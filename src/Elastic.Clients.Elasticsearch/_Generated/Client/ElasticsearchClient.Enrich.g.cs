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
namespace Elastic.Clients.Elasticsearch.Enrich
{
	public class EnrichNamespace : NamespacedClientProxy
	{
		internal EnrichNamespace(ElasticsearchClient client) : base(client)
		{
		}

		public EnrichDeletePolicyResponse DeletePolicy(EnrichDeletePolicyRequest request)
		{
			request.BeforeRequest();
			return DoRequest<EnrichDeletePolicyRequest, EnrichDeletePolicyResponse>(request);
		}

		public Task<EnrichDeletePolicyResponse> DeletePolicyAsync(EnrichDeletePolicyRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<EnrichDeletePolicyRequest, EnrichDeletePolicyResponse>(request, cancellationToken);
		}

		public EnrichDeletePolicyResponse DeletePolicy(Elastic.Clients.Elasticsearch.Name name)
		{
			var descriptor = new EnrichDeletePolicyRequestDescriptor(name);
			descriptor.BeforeRequest();
			return DoRequest<EnrichDeletePolicyRequestDescriptor, EnrichDeletePolicyResponse>(descriptor);
		}

		public EnrichDeletePolicyResponse DeletePolicy(Elastic.Clients.Elasticsearch.Name name, Action<EnrichDeletePolicyRequestDescriptor> configureRequest)
		{
			var descriptor = new EnrichDeletePolicyRequestDescriptor(name);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<EnrichDeletePolicyRequestDescriptor, EnrichDeletePolicyResponse>(descriptor);
		}

		public Task<EnrichDeletePolicyResponse> DeletePolicyAsync(Elastic.Clients.Elasticsearch.Name name, CancellationToken cancellationToken = default)
		{
			var descriptor = new EnrichDeletePolicyRequestDescriptor(name);
			descriptor.BeforeRequest();
			return DoRequestAsync<EnrichDeletePolicyRequestDescriptor, EnrichDeletePolicyResponse>(descriptor);
		}

		public Task<EnrichDeletePolicyResponse> DeletePolicyAsync(Elastic.Clients.Elasticsearch.Name name, Action<EnrichDeletePolicyRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new EnrichDeletePolicyRequestDescriptor(name);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<EnrichDeletePolicyRequestDescriptor, EnrichDeletePolicyResponse>(descriptor);
		}

		public EnrichExecutePolicyResponse ExecutePolicy(EnrichExecutePolicyRequest request)
		{
			request.BeforeRequest();
			return DoRequest<EnrichExecutePolicyRequest, EnrichExecutePolicyResponse>(request);
		}

		public Task<EnrichExecutePolicyResponse> ExecutePolicyAsync(EnrichExecutePolicyRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<EnrichExecutePolicyRequest, EnrichExecutePolicyResponse>(request, cancellationToken);
		}

		public EnrichExecutePolicyResponse ExecutePolicy(Elastic.Clients.Elasticsearch.Name name)
		{
			var descriptor = new EnrichExecutePolicyRequestDescriptor(name);
			descriptor.BeforeRequest();
			return DoRequest<EnrichExecutePolicyRequestDescriptor, EnrichExecutePolicyResponse>(descriptor);
		}

		public EnrichExecutePolicyResponse ExecutePolicy(Elastic.Clients.Elasticsearch.Name name, Action<EnrichExecutePolicyRequestDescriptor> configureRequest)
		{
			var descriptor = new EnrichExecutePolicyRequestDescriptor(name);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<EnrichExecutePolicyRequestDescriptor, EnrichExecutePolicyResponse>(descriptor);
		}

		public Task<EnrichExecutePolicyResponse> ExecutePolicyAsync(Elastic.Clients.Elasticsearch.Name name, CancellationToken cancellationToken = default)
		{
			var descriptor = new EnrichExecutePolicyRequestDescriptor(name);
			descriptor.BeforeRequest();
			return DoRequestAsync<EnrichExecutePolicyRequestDescriptor, EnrichExecutePolicyResponse>(descriptor);
		}

		public Task<EnrichExecutePolicyResponse> ExecutePolicyAsync(Elastic.Clients.Elasticsearch.Name name, Action<EnrichExecutePolicyRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new EnrichExecutePolicyRequestDescriptor(name);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<EnrichExecutePolicyRequestDescriptor, EnrichExecutePolicyResponse>(descriptor);
		}

		public EnrichGetPolicyResponse GetPolicy(EnrichGetPolicyRequest request)
		{
			request.BeforeRequest();
			return DoRequest<EnrichGetPolicyRequest, EnrichGetPolicyResponse>(request);
		}

		public Task<EnrichGetPolicyResponse> GetPolicyAsync(EnrichGetPolicyRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<EnrichGetPolicyRequest, EnrichGetPolicyResponse>(request, cancellationToken);
		}

		public EnrichGetPolicyResponse GetPolicy()
		{
			var descriptor = new EnrichGetPolicyRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequest<EnrichGetPolicyRequestDescriptor, EnrichGetPolicyResponse>(descriptor);
		}

		public EnrichGetPolicyResponse GetPolicy(Action<EnrichGetPolicyRequestDescriptor> configureRequest)
		{
			var descriptor = new EnrichGetPolicyRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<EnrichGetPolicyRequestDescriptor, EnrichGetPolicyResponse>(descriptor);
		}

		public Task<EnrichGetPolicyResponse> GetPolicyAsync(CancellationToken cancellationToken = default)
		{
			var descriptor = new EnrichGetPolicyRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequestAsync<EnrichGetPolicyRequestDescriptor, EnrichGetPolicyResponse>(descriptor);
		}

		public Task<EnrichGetPolicyResponse> GetPolicyAsync(Action<EnrichGetPolicyRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new EnrichGetPolicyRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<EnrichGetPolicyRequestDescriptor, EnrichGetPolicyResponse>(descriptor);
		}

		public EnrichPutPolicyResponse PutPolicy(EnrichPutPolicyRequest request)
		{
			request.BeforeRequest();
			return DoRequest<EnrichPutPolicyRequest, EnrichPutPolicyResponse>(request);
		}

		public Task<EnrichPutPolicyResponse> PutPolicyAsync(EnrichPutPolicyRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<EnrichPutPolicyRequest, EnrichPutPolicyResponse>(request, cancellationToken);
		}

		public EnrichPutPolicyResponse PutPolicy(Elastic.Clients.Elasticsearch.Name name)
		{
			var descriptor = new EnrichPutPolicyRequestDescriptor(name);
			descriptor.BeforeRequest();
			return DoRequest<EnrichPutPolicyRequestDescriptor, EnrichPutPolicyResponse>(descriptor);
		}

		public EnrichPutPolicyResponse PutPolicy(Elastic.Clients.Elasticsearch.Name name, Action<EnrichPutPolicyRequestDescriptor> configureRequest)
		{
			var descriptor = new EnrichPutPolicyRequestDescriptor(name);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<EnrichPutPolicyRequestDescriptor, EnrichPutPolicyResponse>(descriptor);
		}

		public EnrichPutPolicyResponse PutPolicy<TDocument>(Elastic.Clients.Elasticsearch.Name name, Action<EnrichPutPolicyRequestDescriptor<TDocument>> configureRequest)
		{
			var descriptor = new EnrichPutPolicyRequestDescriptor<TDocument>(name);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<EnrichPutPolicyRequestDescriptor<TDocument>, EnrichPutPolicyResponse>(descriptor);
		}

		public Task<EnrichPutPolicyResponse> PutPolicyAsync(Elastic.Clients.Elasticsearch.Name name, CancellationToken cancellationToken = default)
		{
			var descriptor = new EnrichPutPolicyRequestDescriptor(name);
			descriptor.BeforeRequest();
			return DoRequestAsync<EnrichPutPolicyRequestDescriptor, EnrichPutPolicyResponse>(descriptor);
		}

		public Task<EnrichPutPolicyResponse> PutPolicyAsync(Elastic.Clients.Elasticsearch.Name name, Action<EnrichPutPolicyRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new EnrichPutPolicyRequestDescriptor(name);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<EnrichPutPolicyRequestDescriptor, EnrichPutPolicyResponse>(descriptor);
		}

		public Task<EnrichPutPolicyResponse> PutPolicyAsync<TDocument>(Elastic.Clients.Elasticsearch.Name name, Action<EnrichPutPolicyRequestDescriptor<TDocument>> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new EnrichPutPolicyRequestDescriptor<TDocument>(name);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<EnrichPutPolicyRequestDescriptor<TDocument>, EnrichPutPolicyResponse>(descriptor);
		}

		public EnrichStatsResponse Stats(EnrichStatsRequest request)
		{
			request.BeforeRequest();
			return DoRequest<EnrichStatsRequest, EnrichStatsResponse>(request);
		}

		public Task<EnrichStatsResponse> StatsAsync(EnrichStatsRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<EnrichStatsRequest, EnrichStatsResponse>(request, cancellationToken);
		}

		public EnrichStatsResponse Stats()
		{
			var descriptor = new EnrichStatsRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequest<EnrichStatsRequestDescriptor, EnrichStatsResponse>(descriptor);
		}

		public EnrichStatsResponse Stats(Action<EnrichStatsRequestDescriptor> configureRequest)
		{
			var descriptor = new EnrichStatsRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<EnrichStatsRequestDescriptor, EnrichStatsResponse>(descriptor);
		}

		public Task<EnrichStatsResponse> StatsAsync(CancellationToken cancellationToken = default)
		{
			var descriptor = new EnrichStatsRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequestAsync<EnrichStatsRequestDescriptor, EnrichStatsResponse>(descriptor);
		}

		public Task<EnrichStatsResponse> StatsAsync(Action<EnrichStatsRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new EnrichStatsRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<EnrichStatsRequestDescriptor, EnrichStatsResponse>(descriptor);
		}
	}
}