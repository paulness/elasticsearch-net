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

using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Logstash
{
	public sealed class LogstashDeletePipelineRequestParameters : RequestParameters<LogstashDeletePipelineRequestParameters>
	{
	}

	public sealed partial class LogstashDeletePipelineRequest : PlainRequestBase<LogstashDeletePipelineRequestParameters>
	{
		public LogstashDeletePipelineRequest(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.LogstashDeletePipeline;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
	}

	public sealed partial class LogstashDeletePipelineRequestDescriptor<TDocument> : RequestDescriptorBase<LogstashDeletePipelineRequestDescriptor<TDocument>, LogstashDeletePipelineRequestParameters>
	{
		internal LogstashDeletePipelineRequestDescriptor(Action<LogstashDeletePipelineRequestDescriptor<TDocument>> configure) => configure.Invoke(this);
		public LogstashDeletePipelineRequestDescriptor(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
		{
		}

		internal LogstashDeletePipelineRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.LogstashDeletePipeline;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		public LogstashDeletePipelineRequestDescriptor<TDocument> Id(Elastic.Clients.Elasticsearch.Id id)
		{
			RouteValues.Required("id", id);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}

	public sealed partial class LogstashDeletePipelineRequestDescriptor : RequestDescriptorBase<LogstashDeletePipelineRequestDescriptor, LogstashDeletePipelineRequestParameters>
	{
		internal LogstashDeletePipelineRequestDescriptor(Action<LogstashDeletePipelineRequestDescriptor> configure) => configure.Invoke(this);
		public LogstashDeletePipelineRequestDescriptor(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
		{
		}

		internal LogstashDeletePipelineRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.LogstashDeletePipeline;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		public LogstashDeletePipelineRequestDescriptor Id(Elastic.Clients.Elasticsearch.Id id)
		{
			RouteValues.Required("id", id);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}
}