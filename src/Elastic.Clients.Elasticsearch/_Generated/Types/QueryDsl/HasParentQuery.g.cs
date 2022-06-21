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
namespace Elastic.Clients.Elasticsearch.QueryDsl
{
	public partial class HasParentQuery : QueryBase, IQueryVariant
	{
		[JsonInclude]
		[JsonPropertyName("ignore_unmapped")]
		public bool? IgnoreUnmapped { get; set; }

		[JsonInclude]
		[JsonPropertyName("inner_hits")]
		public Elastic.Clients.Elasticsearch.InnerHits? InnerHits { get; set; }

		[JsonInclude]
		[JsonPropertyName("parent_type")]
		public string ParentType { get; set; }

		[JsonInclude]
		[JsonPropertyName("query")]
		public Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer Query { get; set; }

		[JsonInclude]
		[JsonPropertyName("score")]
		public bool? Score { get; set; }
	}

	public sealed partial class HasParentQueryDescriptor<TDocument> : SerializableDescriptorBase<HasParentQueryDescriptor<TDocument>>
	{
		internal HasParentQueryDescriptor(Action<HasParentQueryDescriptor<TDocument>> configure) => configure.Invoke(this);
		public HasParentQueryDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.InnerHits? InnerHitsValue { get; set; }

		private InnerHitsDescriptor<TDocument> InnerHitsDescriptor { get; set; }

		private Action<InnerHitsDescriptor<TDocument>> InnerHitsDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer QueryValue { get; set; }

		private QueryContainerDescriptor<TDocument> QueryDescriptor { get; set; }

		private Action<QueryContainerDescriptor<TDocument>> QueryDescriptorAction { get; set; }

		private string? QueryNameValue { get; set; }

		private float? BoostValue { get; set; }

		private bool? IgnoreUnmappedValue { get; set; }

		private string ParentTypeValue { get; set; }

		private bool? ScoreValue { get; set; }

		public HasParentQueryDescriptor<TDocument> InnerHits(Elastic.Clients.Elasticsearch.InnerHits? innerHits)
		{
			InnerHitsDescriptor = null;
			InnerHitsDescriptorAction = null;
			InnerHitsValue = innerHits;
			return Self;
		}

		public HasParentQueryDescriptor<TDocument> InnerHits(InnerHitsDescriptor<TDocument> descriptor)
		{
			InnerHitsValue = null;
			InnerHitsDescriptorAction = null;
			InnerHitsDescriptor = descriptor;
			return Self;
		}

		public HasParentQueryDescriptor<TDocument> InnerHits(Action<InnerHitsDescriptor<TDocument>> configure)
		{
			InnerHitsValue = null;
			InnerHitsDescriptor = null;
			InnerHitsDescriptorAction = configure;
			return Self;
		}

		public HasParentQueryDescriptor<TDocument> Query(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer query)
		{
			QueryDescriptor = null;
			QueryDescriptorAction = null;
			QueryValue = query;
			return Self;
		}

		public HasParentQueryDescriptor<TDocument> Query(QueryContainerDescriptor<TDocument> descriptor)
		{
			QueryValue = null;
			QueryDescriptorAction = null;
			QueryDescriptor = descriptor;
			return Self;
		}

		public HasParentQueryDescriptor<TDocument> Query(Action<QueryContainerDescriptor<TDocument>> configure)
		{
			QueryValue = null;
			QueryDescriptor = null;
			QueryDescriptorAction = configure;
			return Self;
		}

		public HasParentQueryDescriptor<TDocument> QueryName(string? queryName)
		{
			QueryNameValue = queryName;
			return Self;
		}

		public HasParentQueryDescriptor<TDocument> Boost(float? boost)
		{
			BoostValue = boost;
			return Self;
		}

		public HasParentQueryDescriptor<TDocument> IgnoreUnmapped(bool? ignoreUnmapped = true)
		{
			IgnoreUnmappedValue = ignoreUnmapped;
			return Self;
		}

		public HasParentQueryDescriptor<TDocument> ParentType(string parentType)
		{
			ParentTypeValue = parentType;
			return Self;
		}

		public HasParentQueryDescriptor<TDocument> Score(bool? score = true)
		{
			ScoreValue = score;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (InnerHitsDescriptor is not null)
			{
				writer.WritePropertyName("inner_hits");
				JsonSerializer.Serialize(writer, InnerHitsDescriptor, options);
			}
			else if (InnerHitsDescriptorAction is not null)
			{
				writer.WritePropertyName("inner_hits");
				JsonSerializer.Serialize(writer, new InnerHitsDescriptor<TDocument>(InnerHitsDescriptorAction), options);
			}
			else if (InnerHitsValue is not null)
			{
				writer.WritePropertyName("inner_hits");
				JsonSerializer.Serialize(writer, InnerHitsValue, options);
			}

			if (QueryDescriptor is not null)
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, QueryDescriptor, options);
			}
			else if (QueryDescriptorAction is not null)
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, new QueryContainerDescriptor<TDocument>(QueryDescriptorAction), options);
			}
			else
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, QueryValue, options);
			}

			if (!string.IsNullOrEmpty(QueryNameValue))
			{
				writer.WritePropertyName("_name");
				writer.WriteStringValue(QueryNameValue);
			}

			if (BoostValue.HasValue)
			{
				writer.WritePropertyName("boost");
				writer.WriteNumberValue(BoostValue.Value);
			}

			if (IgnoreUnmappedValue.HasValue)
			{
				writer.WritePropertyName("ignore_unmapped");
				writer.WriteBooleanValue(IgnoreUnmappedValue.Value);
			}

			writer.WritePropertyName("parent_type");
			JsonSerializer.Serialize(writer, ParentTypeValue, options);
			if (ScoreValue.HasValue)
			{
				writer.WritePropertyName("score");
				writer.WriteBooleanValue(ScoreValue.Value);
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class HasParentQueryDescriptor : SerializableDescriptorBase<HasParentQueryDescriptor>
	{
		internal HasParentQueryDescriptor(Action<HasParentQueryDescriptor> configure) => configure.Invoke(this);
		public HasParentQueryDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.InnerHits? InnerHitsValue { get; set; }

		private InnerHitsDescriptor InnerHitsDescriptor { get; set; }

		private Action<InnerHitsDescriptor> InnerHitsDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer QueryValue { get; set; }

		private QueryContainerDescriptor QueryDescriptor { get; set; }

		private Action<QueryContainerDescriptor> QueryDescriptorAction { get; set; }

		private string? QueryNameValue { get; set; }

		private float? BoostValue { get; set; }

		private bool? IgnoreUnmappedValue { get; set; }

		private string ParentTypeValue { get; set; }

		private bool? ScoreValue { get; set; }

		public HasParentQueryDescriptor InnerHits(Elastic.Clients.Elasticsearch.InnerHits? innerHits)
		{
			InnerHitsDescriptor = null;
			InnerHitsDescriptorAction = null;
			InnerHitsValue = innerHits;
			return Self;
		}

		public HasParentQueryDescriptor InnerHits(InnerHitsDescriptor descriptor)
		{
			InnerHitsValue = null;
			InnerHitsDescriptorAction = null;
			InnerHitsDescriptor = descriptor;
			return Self;
		}

		public HasParentQueryDescriptor InnerHits(Action<InnerHitsDescriptor> configure)
		{
			InnerHitsValue = null;
			InnerHitsDescriptor = null;
			InnerHitsDescriptorAction = configure;
			return Self;
		}

		public HasParentQueryDescriptor Query(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer query)
		{
			QueryDescriptor = null;
			QueryDescriptorAction = null;
			QueryValue = query;
			return Self;
		}

		public HasParentQueryDescriptor Query(QueryContainerDescriptor descriptor)
		{
			QueryValue = null;
			QueryDescriptorAction = null;
			QueryDescriptor = descriptor;
			return Self;
		}

		public HasParentQueryDescriptor Query(Action<QueryContainerDescriptor> configure)
		{
			QueryValue = null;
			QueryDescriptor = null;
			QueryDescriptorAction = configure;
			return Self;
		}

		public HasParentQueryDescriptor QueryName(string? queryName)
		{
			QueryNameValue = queryName;
			return Self;
		}

		public HasParentQueryDescriptor Boost(float? boost)
		{
			BoostValue = boost;
			return Self;
		}

		public HasParentQueryDescriptor IgnoreUnmapped(bool? ignoreUnmapped = true)
		{
			IgnoreUnmappedValue = ignoreUnmapped;
			return Self;
		}

		public HasParentQueryDescriptor ParentType(string parentType)
		{
			ParentTypeValue = parentType;
			return Self;
		}

		public HasParentQueryDescriptor Score(bool? score = true)
		{
			ScoreValue = score;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (InnerHitsDescriptor is not null)
			{
				writer.WritePropertyName("inner_hits");
				JsonSerializer.Serialize(writer, InnerHitsDescriptor, options);
			}
			else if (InnerHitsDescriptorAction is not null)
			{
				writer.WritePropertyName("inner_hits");
				JsonSerializer.Serialize(writer, new InnerHitsDescriptor(InnerHitsDescriptorAction), options);
			}
			else if (InnerHitsValue is not null)
			{
				writer.WritePropertyName("inner_hits");
				JsonSerializer.Serialize(writer, InnerHitsValue, options);
			}

			if (QueryDescriptor is not null)
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, QueryDescriptor, options);
			}
			else if (QueryDescriptorAction is not null)
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, new QueryContainerDescriptor(QueryDescriptorAction), options);
			}
			else
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, QueryValue, options);
			}

			if (!string.IsNullOrEmpty(QueryNameValue))
			{
				writer.WritePropertyName("_name");
				writer.WriteStringValue(QueryNameValue);
			}

			if (BoostValue.HasValue)
			{
				writer.WritePropertyName("boost");
				writer.WriteNumberValue(BoostValue.Value);
			}

			if (IgnoreUnmappedValue.HasValue)
			{
				writer.WritePropertyName("ignore_unmapped");
				writer.WriteBooleanValue(IgnoreUnmappedValue.Value);
			}

			writer.WritePropertyName("parent_type");
			JsonSerializer.Serialize(writer, ParentTypeValue, options);
			if (ScoreValue.HasValue)
			{
				writer.WritePropertyName("score");
				writer.WriteBooleanValue(ScoreValue.Value);
			}

			writer.WriteEndObject();
		}
	}
}