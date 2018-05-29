﻿using System;
using System.Collections.Generic;
using System.Linq;
using AzureLogsViewer.Model.Entities;
using Microsoft.WindowsAzure.Storage;

namespace AzureLogsViewer.Model.WadLogs
{
    public class WadLogsReader : IIWadLogsReader
    {
        private readonly WadLogsStorageSettings _settings;

        public WadLogsReader(WadLogsStorageSettings settings)
        {
            _settings = settings;
        }

        private string CloudStorageConnectionString => _settings.StorageConnectionString;

        public List<WadLogEntry> Read(DateTime from, DateTime to)
        {
            var storageAccount = CloudStorageAccount.Parse(CloudStorageConnectionString);
            var tableClient = storageAccount.CreateCloudTableClient();
            var wadLogs = tableClient.GetTableReference("WADLogsTable");

            return wadLogs.CreateQuery<WadLogEntity>()
                .Where(
                wl => 
                        String.Compare(wl.PartitionKey,"0" + from.Ticks.ToString()) >=0 && 
                        String.Compare(wl.PartitionKey, "0" + to.Ticks.ToString()) < 0
                )
                .ToList()
                .Select(x => new WadLogEntry(x, _settings))
                .ToList();
        }
    }
}