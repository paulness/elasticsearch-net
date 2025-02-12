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
	public sealed partial class AnalysisLimits
	{
		[JsonInclude]
		[JsonPropertyName("categorization_examples_limit")]
		public long? CategorizationExamplesLimit { get; set; }

		[JsonInclude]
		[JsonPropertyName("model_memory_limit")]
		public string? ModelMemoryLimit { get; set; }
	}

	public sealed partial class AnalysisLimitsDescriptor : SerializableDescriptorBase<AnalysisLimitsDescriptor>
	{
		internal AnalysisLimitsDescriptor(Action<AnalysisLimitsDescriptor> configure) => configure.Invoke(this);
		public AnalysisLimitsDescriptor() : base()
		{
		}

		private long? CategorizationExamplesLimitValue { get; set; }

		private string? ModelMemoryLimitValue { get; set; }

		public AnalysisLimitsDescriptor CategorizationExamplesLimit(long? categorizationExamplesLimit)
		{
			CategorizationExamplesLimitValue = categorizationExamplesLimit;
			return Self;
		}

		public AnalysisLimitsDescriptor ModelMemoryLimit(string? modelMemoryLimit)
		{
			ModelMemoryLimitValue = modelMemoryLimit;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (CategorizationExamplesLimitValue.HasValue)
			{
				writer.WritePropertyName("categorization_examples_limit");
				writer.WriteNumberValue(CategorizationExamplesLimitValue.Value);
			}

			if (!string.IsNullOrEmpty(ModelMemoryLimitValue))
			{
				writer.WritePropertyName("model_memory_limit");
				writer.WriteStringValue(ModelMemoryLimitValue);
			}

			writer.WriteEndObject();
		}
	}
}