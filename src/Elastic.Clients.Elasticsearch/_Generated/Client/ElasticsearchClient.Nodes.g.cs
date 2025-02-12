// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
//
// ------------------------------------------------

using System;
using System.Threading;
using System.Threading.Tasks;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Nodes
{
	public class NodesNamespace : NamespacedClientProxy
	{
		internal NodesNamespace(ElasticsearchClient client) : base(client)
		{
		}

		public NodesHotThreadsResponse HotThreads(NodesHotThreadsRequest request)
		{
			request.BeforeRequest();
			return DoRequest<NodesHotThreadsRequest, NodesHotThreadsResponse>(request);
		}

		public Task<NodesHotThreadsResponse> HotThreadsAsync(NodesHotThreadsRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<NodesHotThreadsRequest, NodesHotThreadsResponse>(request, cancellationToken);
		}

		public NodesHotThreadsResponse HotThreads()
		{
			var descriptor = new NodesHotThreadsRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequest<NodesHotThreadsRequestDescriptor, NodesHotThreadsResponse>(descriptor);
		}

		public NodesHotThreadsResponse HotThreads(Action<NodesHotThreadsRequestDescriptor> configureRequest)
		{
			var descriptor = new NodesHotThreadsRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<NodesHotThreadsRequestDescriptor, NodesHotThreadsResponse>(descriptor);
		}

		public Task<NodesHotThreadsResponse> HotThreadsAsync(CancellationToken cancellationToken = default)
		{
			var descriptor = new NodesHotThreadsRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequestAsync<NodesHotThreadsRequestDescriptor, NodesHotThreadsResponse>(descriptor);
		}

		public Task<NodesHotThreadsResponse> HotThreadsAsync(Action<NodesHotThreadsRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new NodesHotThreadsRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<NodesHotThreadsRequestDescriptor, NodesHotThreadsResponse>(descriptor);
		}

		public NodesInfoResponse Info(NodesInfoRequest request)
		{
			request.BeforeRequest();
			return DoRequest<NodesInfoRequest, NodesInfoResponse>(request);
		}

		public Task<NodesInfoResponse> InfoAsync(NodesInfoRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<NodesInfoRequest, NodesInfoResponse>(request, cancellationToken);
		}

		public NodesInfoResponse Info()
		{
			var descriptor = new NodesInfoRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequest<NodesInfoRequestDescriptor, NodesInfoResponse>(descriptor);
		}

		public NodesInfoResponse Info(Action<NodesInfoRequestDescriptor> configureRequest)
		{
			var descriptor = new NodesInfoRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<NodesInfoRequestDescriptor, NodesInfoResponse>(descriptor);
		}

		public Task<NodesInfoResponse> InfoAsync(CancellationToken cancellationToken = default)
		{
			var descriptor = new NodesInfoRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequestAsync<NodesInfoRequestDescriptor, NodesInfoResponse>(descriptor);
		}

		public Task<NodesInfoResponse> InfoAsync(Action<NodesInfoRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new NodesInfoRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<NodesInfoRequestDescriptor, NodesInfoResponse>(descriptor);
		}

		public NodesReloadSecureSettingsResponse ReloadSecureSettings(NodesReloadSecureSettingsRequest request)
		{
			request.BeforeRequest();
			return DoRequest<NodesReloadSecureSettingsRequest, NodesReloadSecureSettingsResponse>(request);
		}

		public Task<NodesReloadSecureSettingsResponse> ReloadSecureSettingsAsync(NodesReloadSecureSettingsRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<NodesReloadSecureSettingsRequest, NodesReloadSecureSettingsResponse>(request, cancellationToken);
		}

		public NodesReloadSecureSettingsResponse ReloadSecureSettings()
		{
			var descriptor = new NodesReloadSecureSettingsRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequest<NodesReloadSecureSettingsRequestDescriptor, NodesReloadSecureSettingsResponse>(descriptor);
		}

		public NodesReloadSecureSettingsResponse ReloadSecureSettings(Action<NodesReloadSecureSettingsRequestDescriptor> configureRequest)
		{
			var descriptor = new NodesReloadSecureSettingsRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<NodesReloadSecureSettingsRequestDescriptor, NodesReloadSecureSettingsResponse>(descriptor);
		}

		public Task<NodesReloadSecureSettingsResponse> ReloadSecureSettingsAsync(CancellationToken cancellationToken = default)
		{
			var descriptor = new NodesReloadSecureSettingsRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequestAsync<NodesReloadSecureSettingsRequestDescriptor, NodesReloadSecureSettingsResponse>(descriptor);
		}

		public Task<NodesReloadSecureSettingsResponse> ReloadSecureSettingsAsync(Action<NodesReloadSecureSettingsRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new NodesReloadSecureSettingsRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<NodesReloadSecureSettingsRequestDescriptor, NodesReloadSecureSettingsResponse>(descriptor);
		}

		public NodesStatsResponse Stats(NodesStatsRequest request)
		{
			request.BeforeRequest();
			return DoRequest<NodesStatsRequest, NodesStatsResponse>(request);
		}

		public Task<NodesStatsResponse> StatsAsync(NodesStatsRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<NodesStatsRequest, NodesStatsResponse>(request, cancellationToken);
		}

		public NodesStatsResponse Stats()
		{
			var descriptor = new NodesStatsRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequest<NodesStatsRequestDescriptor, NodesStatsResponse>(descriptor);
		}

		public NodesStatsResponse Stats(Action<NodesStatsRequestDescriptor> configureRequest)
		{
			var descriptor = new NodesStatsRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<NodesStatsRequestDescriptor, NodesStatsResponse>(descriptor);
		}

		public NodesStatsResponse Stats<TDocument>(Action<NodesStatsRequestDescriptor<TDocument>> configureRequest)
		{
			var descriptor = new NodesStatsRequestDescriptor<TDocument>();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<NodesStatsRequestDescriptor<TDocument>, NodesStatsResponse>(descriptor);
		}

		public Task<NodesStatsResponse> StatsAsync(CancellationToken cancellationToken = default)
		{
			var descriptor = new NodesStatsRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequestAsync<NodesStatsRequestDescriptor, NodesStatsResponse>(descriptor);
		}

		public Task<NodesStatsResponse> StatsAsync(Action<NodesStatsRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new NodesStatsRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<NodesStatsRequestDescriptor, NodesStatsResponse>(descriptor);
		}

		public Task<NodesStatsResponse> StatsAsync<TDocument>(Action<NodesStatsRequestDescriptor<TDocument>> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new NodesStatsRequestDescriptor<TDocument>();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<NodesStatsRequestDescriptor<TDocument>, NodesStatsResponse>(descriptor);
		}

		public NodesUsageResponse Usage(NodesUsageRequest request)
		{
			request.BeforeRequest();
			return DoRequest<NodesUsageRequest, NodesUsageResponse>(request);
		}

		public Task<NodesUsageResponse> UsageAsync(NodesUsageRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<NodesUsageRequest, NodesUsageResponse>(request, cancellationToken);
		}

		public NodesUsageResponse Usage()
		{
			var descriptor = new NodesUsageRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequest<NodesUsageRequestDescriptor, NodesUsageResponse>(descriptor);
		}

		public NodesUsageResponse Usage(Action<NodesUsageRequestDescriptor> configureRequest)
		{
			var descriptor = new NodesUsageRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<NodesUsageRequestDescriptor, NodesUsageResponse>(descriptor);
		}

		public Task<NodesUsageResponse> UsageAsync(CancellationToken cancellationToken = default)
		{
			var descriptor = new NodesUsageRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequestAsync<NodesUsageRequestDescriptor, NodesUsageResponse>(descriptor);
		}

		public Task<NodesUsageResponse> UsageAsync(Action<NodesUsageRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new NodesUsageRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<NodesUsageRequestDescriptor, NodesUsageResponse>(descriptor);
		}
	}
}