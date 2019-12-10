﻿using Jellyfin.ApiClient.Model;
using MediaBrowser.Model.Sync;
using System;
using System.Threading;

namespace Jellyfin.ApiClient.Sync
{
    public interface IFileTransferManager
    {
        System.Threading.Tasks.Task GetItemFileAsync(IApiClient apiClient, ServerInfo server, LocalItem item, string syncJobItemId, IProgress<double> transferProgress, System.Threading.CancellationToken cancellationToken = default(CancellationToken));
    }
}
