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
	public partial class SpanOrQuery : QueryDsl.QueryBase, IQueryContainerVariant, ISpanQueryVariant
	{
		[JsonIgnore]
		string QueryDsl.IQueryContainerVariant.QueryContainerVariantName => "span_or";
		[JsonIgnore]
		string QueryDsl.ISpanQueryVariant.SpanQueryVariantName => "span_or";
		[JsonInclude]
		[JsonPropertyName("clauses")]
		public IEnumerable<Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery> Clauses { get; set; }
	}

	public sealed partial class SpanOrQueryDescriptor : DescriptorBase<SpanOrQueryDescriptor>
	{
		internal SpanOrQueryDescriptor(Action<SpanOrQueryDescriptor> configure) => configure.Invoke(this);
		public SpanOrQueryDescriptor() : base()
		{
		}

		private string? QueryNameValue { get; set; }

		private float? BoostValue { get; set; }

		private IEnumerable<Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery> ClausesValue { get; set; }

		public SpanOrQueryDescriptor QueryName(string? queryName)
		{
			QueryNameValue = queryName;
			return Self;
		}

		public SpanOrQueryDescriptor Boost(float? boost)
		{
			BoostValue = boost;
			return Self;
		}

		public SpanOrQueryDescriptor Clauses(IEnumerable<Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery> clauses)
		{
			ClausesValue = clauses;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
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

			writer.WritePropertyName("clauses");
			JsonSerializer.Serialize(writer, ClausesValue, options);
			writer.WriteEndObject();
		}
	}
}