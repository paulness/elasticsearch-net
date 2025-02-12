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
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Ml
{
	public sealed partial class DataframeAnalyticsSource
	{
		[JsonInclude]
		[JsonPropertyName("_source")]
		public Elastic.Clients.Elasticsearch.Ml.DataframeAnalysisAnalyzedFields? Source { get; set; }

		[JsonInclude]
		[JsonPropertyName("index")]
		public Elastic.Clients.Elasticsearch.Indices Index { get; set; }

		[JsonInclude]
		[JsonPropertyName("query")]
		public Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? Query { get; set; }

		[JsonInclude]
		[JsonPropertyName("runtime_mappings")]
		public Dictionary<Elastic.Clients.Elasticsearch.Field, IEnumerable<Elastic.Clients.Elasticsearch.Mapping.RuntimeField>>? RuntimeMappings { get; set; }
	}

	public sealed partial class DataframeAnalyticsSourceDescriptor<TDocument> : SerializableDescriptorBase<DataframeAnalyticsSourceDescriptor<TDocument>>
	{
		internal DataframeAnalyticsSourceDescriptor(Action<DataframeAnalyticsSourceDescriptor<TDocument>> configure) => configure.Invoke(this);
		public DataframeAnalyticsSourceDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? QueryValue { get; set; }

		private QueryDsl.QueryContainerDescriptor<TDocument> QueryDescriptor { get; set; }

		private Action<QueryDsl.QueryContainerDescriptor<TDocument>> QueryDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.Ml.DataframeAnalysisAnalyzedFields? SourceValue { get; set; }

		private DataframeAnalysisAnalyzedFieldsDescriptor SourceDescriptor { get; set; }

		private Action<DataframeAnalysisAnalyzedFieldsDescriptor> SourceDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.Indices IndexValue { get; set; }

		private Dictionary<Elastic.Clients.Elasticsearch.Field, IEnumerable<Elastic.Clients.Elasticsearch.Mapping.RuntimeField>>? RuntimeMappingsValue { get; set; }

		public DataframeAnalyticsSourceDescriptor<TDocument> Query(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? query)
		{
			QueryDescriptor = null;
			QueryDescriptorAction = null;
			QueryValue = query;
			return Self;
		}

		public DataframeAnalyticsSourceDescriptor<TDocument> Query(QueryDsl.QueryContainerDescriptor<TDocument> descriptor)
		{
			QueryValue = null;
			QueryDescriptorAction = null;
			QueryDescriptor = descriptor;
			return Self;
		}

		public DataframeAnalyticsSourceDescriptor<TDocument> Query(Action<QueryDsl.QueryContainerDescriptor<TDocument>> configure)
		{
			QueryValue = null;
			QueryDescriptor = null;
			QueryDescriptorAction = configure;
			return Self;
		}

		public DataframeAnalyticsSourceDescriptor<TDocument> Source(Elastic.Clients.Elasticsearch.Ml.DataframeAnalysisAnalyzedFields? source)
		{
			SourceDescriptor = null;
			SourceDescriptorAction = null;
			SourceValue = source;
			return Self;
		}

		public DataframeAnalyticsSourceDescriptor<TDocument> Source(DataframeAnalysisAnalyzedFieldsDescriptor descriptor)
		{
			SourceValue = null;
			SourceDescriptorAction = null;
			SourceDescriptor = descriptor;
			return Self;
		}

		public DataframeAnalyticsSourceDescriptor<TDocument> Source(Action<DataframeAnalysisAnalyzedFieldsDescriptor> configure)
		{
			SourceValue = null;
			SourceDescriptor = null;
			SourceDescriptorAction = configure;
			return Self;
		}

		public DataframeAnalyticsSourceDescriptor<TDocument> Index(Elastic.Clients.Elasticsearch.Indices index)
		{
			IndexValue = index;
			return Self;
		}

		public DataframeAnalyticsSourceDescriptor<TDocument> RuntimeMappings(Func<FluentDictionary<Elastic.Clients.Elasticsearch.Field, IEnumerable<Elastic.Clients.Elasticsearch.Mapping.RuntimeField>>, FluentDictionary<Elastic.Clients.Elasticsearch.Field, IEnumerable<Elastic.Clients.Elasticsearch.Mapping.RuntimeField>>> selector)
		{
			RuntimeMappingsValue = selector?.Invoke(new FluentDictionary<Elastic.Clients.Elasticsearch.Field, IEnumerable<Elastic.Clients.Elasticsearch.Mapping.RuntimeField>>());
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (QueryDescriptor is not null)
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, QueryDescriptor, options);
			}
			else if (QueryDescriptorAction is not null)
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, new QueryDsl.QueryContainerDescriptor<TDocument>(QueryDescriptorAction), options);
			}
			else if (QueryValue is not null)
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, QueryValue, options);
			}

			if (SourceDescriptor is not null)
			{
				writer.WritePropertyName("_source");
				JsonSerializer.Serialize(writer, SourceDescriptor, options);
			}
			else if (SourceDescriptorAction is not null)
			{
				writer.WritePropertyName("_source");
				JsonSerializer.Serialize(writer, new DataframeAnalysisAnalyzedFieldsDescriptor(SourceDescriptorAction), options);
			}
			else if (SourceValue is not null)
			{
				writer.WritePropertyName("_source");
				JsonSerializer.Serialize(writer, SourceValue, options);
			}

			writer.WritePropertyName("index");
			JsonSerializer.Serialize(writer, IndexValue, options);
			if (RuntimeMappingsValue is not null)
			{
				writer.WritePropertyName("runtime_mappings");
				JsonSerializer.Serialize(writer, RuntimeMappingsValue, options);
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class DataframeAnalyticsSourceDescriptor : SerializableDescriptorBase<DataframeAnalyticsSourceDescriptor>
	{
		internal DataframeAnalyticsSourceDescriptor(Action<DataframeAnalyticsSourceDescriptor> configure) => configure.Invoke(this);
		public DataframeAnalyticsSourceDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? QueryValue { get; set; }

		private QueryDsl.QueryContainerDescriptor QueryDescriptor { get; set; }

		private Action<QueryDsl.QueryContainerDescriptor> QueryDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.Ml.DataframeAnalysisAnalyzedFields? SourceValue { get; set; }

		private DataframeAnalysisAnalyzedFieldsDescriptor SourceDescriptor { get; set; }

		private Action<DataframeAnalysisAnalyzedFieldsDescriptor> SourceDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.Indices IndexValue { get; set; }

		private Dictionary<Elastic.Clients.Elasticsearch.Field, IEnumerable<Elastic.Clients.Elasticsearch.Mapping.RuntimeField>>? RuntimeMappingsValue { get; set; }

		public DataframeAnalyticsSourceDescriptor Query(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? query)
		{
			QueryDescriptor = null;
			QueryDescriptorAction = null;
			QueryValue = query;
			return Self;
		}

		public DataframeAnalyticsSourceDescriptor Query(QueryDsl.QueryContainerDescriptor descriptor)
		{
			QueryValue = null;
			QueryDescriptorAction = null;
			QueryDescriptor = descriptor;
			return Self;
		}

		public DataframeAnalyticsSourceDescriptor Query(Action<QueryDsl.QueryContainerDescriptor> configure)
		{
			QueryValue = null;
			QueryDescriptor = null;
			QueryDescriptorAction = configure;
			return Self;
		}

		public DataframeAnalyticsSourceDescriptor Source(Elastic.Clients.Elasticsearch.Ml.DataframeAnalysisAnalyzedFields? source)
		{
			SourceDescriptor = null;
			SourceDescriptorAction = null;
			SourceValue = source;
			return Self;
		}

		public DataframeAnalyticsSourceDescriptor Source(DataframeAnalysisAnalyzedFieldsDescriptor descriptor)
		{
			SourceValue = null;
			SourceDescriptorAction = null;
			SourceDescriptor = descriptor;
			return Self;
		}

		public DataframeAnalyticsSourceDescriptor Source(Action<DataframeAnalysisAnalyzedFieldsDescriptor> configure)
		{
			SourceValue = null;
			SourceDescriptor = null;
			SourceDescriptorAction = configure;
			return Self;
		}

		public DataframeAnalyticsSourceDescriptor Index(Elastic.Clients.Elasticsearch.Indices index)
		{
			IndexValue = index;
			return Self;
		}

		public DataframeAnalyticsSourceDescriptor RuntimeMappings(Func<FluentDictionary<Elastic.Clients.Elasticsearch.Field, IEnumerable<Elastic.Clients.Elasticsearch.Mapping.RuntimeField>>, FluentDictionary<Elastic.Clients.Elasticsearch.Field, IEnumerable<Elastic.Clients.Elasticsearch.Mapping.RuntimeField>>> selector)
		{
			RuntimeMappingsValue = selector?.Invoke(new FluentDictionary<Elastic.Clients.Elasticsearch.Field, IEnumerable<Elastic.Clients.Elasticsearch.Mapping.RuntimeField>>());
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (QueryDescriptor is not null)
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, QueryDescriptor, options);
			}
			else if (QueryDescriptorAction is not null)
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, new QueryDsl.QueryContainerDescriptor(QueryDescriptorAction), options);
			}
			else if (QueryValue is not null)
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, QueryValue, options);
			}

			if (SourceDescriptor is not null)
			{
				writer.WritePropertyName("_source");
				JsonSerializer.Serialize(writer, SourceDescriptor, options);
			}
			else if (SourceDescriptorAction is not null)
			{
				writer.WritePropertyName("_source");
				JsonSerializer.Serialize(writer, new DataframeAnalysisAnalyzedFieldsDescriptor(SourceDescriptorAction), options);
			}
			else if (SourceValue is not null)
			{
				writer.WritePropertyName("_source");
				JsonSerializer.Serialize(writer, SourceValue, options);
			}

			writer.WritePropertyName("index");
			JsonSerializer.Serialize(writer, IndexValue, options);
			if (RuntimeMappingsValue is not null)
			{
				writer.WritePropertyName("runtime_mappings");
				JsonSerializer.Serialize(writer, RuntimeMappingsValue, options);
			}

			writer.WriteEndObject();
		}
	}
}