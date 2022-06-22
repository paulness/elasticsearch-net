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
	public partial class AnalysisConfig
	{
		[JsonInclude]
		[JsonPropertyName("bucket_span")]
		public Elastic.Clients.Elasticsearch.Duration BucketSpan { get; set; }

		[JsonInclude]
		[JsonPropertyName("categorization_analyzer")]
		public Elastic.Clients.Elasticsearch.Ml.CategorizationAnalyzer? CategorizationAnalyzer { get; set; }

		[JsonInclude]
		[JsonPropertyName("categorization_field_name")]
		public Elastic.Clients.Elasticsearch.Field? CategorizationFieldName { get; set; }

		[JsonInclude]
		[JsonPropertyName("categorization_filters")]
		public IEnumerable<string>? CategorizationFilters { get; set; }

		[JsonInclude]
		[JsonPropertyName("detectors")]
		public IEnumerable<Elastic.Clients.Elasticsearch.Ml.Detector> Detectors { get; set; }

		[JsonInclude]
		[JsonPropertyName("influencers")]
		public IEnumerable<Elastic.Clients.Elasticsearch.Field>? Influencers { get; set; }

		[JsonInclude]
		[JsonPropertyName("latency")]
		public Elastic.Clients.Elasticsearch.Duration? Latency { get; set; }

		[JsonInclude]
		[JsonPropertyName("model_prune_window")]
		public Elastic.Clients.Elasticsearch.Duration? ModelPruneWindow { get; set; }

		[JsonInclude]
		[JsonPropertyName("multivariate_by_fields")]
		public bool? MultivariateByFields { get; set; }

		[JsonInclude]
		[JsonPropertyName("per_partition_categorization")]
		public Elastic.Clients.Elasticsearch.Ml.PerPartitionCategorization? PerPartitionCategorization { get; set; }

		[JsonInclude]
		[JsonPropertyName("summary_count_field_name")]
		public Elastic.Clients.Elasticsearch.Field? SummaryCountFieldName { get; set; }
	}

	public sealed partial class AnalysisConfigDescriptor<TDocument> : SerializableDescriptorBase<AnalysisConfigDescriptor<TDocument>>
	{
		internal AnalysisConfigDescriptor(Action<AnalysisConfigDescriptor<TDocument>> configure) => configure.Invoke(this);
		public AnalysisConfigDescriptor() : base()
		{
		}

		private IEnumerable<Elastic.Clients.Elasticsearch.Ml.Detector> DetectorsValue { get; set; }

		private DetectorDescriptor<TDocument> DetectorsDescriptor { get; set; }

		private Action<DetectorDescriptor<TDocument>> DetectorsDescriptorAction { get; set; }

		private Action<DetectorDescriptor<TDocument>>[] DetectorsDescriptorActions { get; set; }

		private Elastic.Clients.Elasticsearch.Duration BucketSpanValue { get; set; }

		private Elastic.Clients.Elasticsearch.Ml.CategorizationAnalyzer? CategorizationAnalyzerValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field? CategorizationFieldNameValue { get; set; }

		private IEnumerable<string>? CategorizationFiltersValue { get; set; }

		private IEnumerable<Elastic.Clients.Elasticsearch.Field>? InfluencersValue { get; set; }

		private Elastic.Clients.Elasticsearch.Duration? LatencyValue { get; set; }

		private Elastic.Clients.Elasticsearch.Duration? ModelPruneWindowValue { get; set; }

		private bool? MultivariateByFieldsValue { get; set; }

		private Elastic.Clients.Elasticsearch.Ml.PerPartitionCategorization? PerPartitionCategorizationValue { get; set; }

		private PerPartitionCategorizationDescriptor PerPartitionCategorizationDescriptor { get; set; }

		private Action<PerPartitionCategorizationDescriptor> PerPartitionCategorizationDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.Field? SummaryCountFieldNameValue { get; set; }

		public AnalysisConfigDescriptor<TDocument> Detectors(IEnumerable<Elastic.Clients.Elasticsearch.Ml.Detector> detectors)
		{
			DetectorsDescriptor = null;
			DetectorsDescriptorAction = null;
			DetectorsDescriptorActions = null;
			DetectorsValue = detectors;
			return Self;
		}

		public AnalysisConfigDescriptor<TDocument> Detectors(DetectorDescriptor<TDocument> descriptor)
		{
			DetectorsValue = null;
			DetectorsDescriptorAction = null;
			DetectorsDescriptorActions = null;
			DetectorsDescriptor = descriptor;
			return Self;
		}

		public AnalysisConfigDescriptor<TDocument> Detectors(Action<DetectorDescriptor<TDocument>> configure)
		{
			DetectorsValue = null;
			DetectorsDescriptor = null;
			DetectorsDescriptorActions = null;
			DetectorsDescriptorAction = configure;
			return Self;
		}

		public AnalysisConfigDescriptor<TDocument> Detectors(params Action<DetectorDescriptor<TDocument>>[] configure)
		{
			DetectorsValue = null;
			DetectorsDescriptor = null;
			DetectorsDescriptorAction = null;
			DetectorsDescriptorActions = configure;
			return Self;
		}

		public AnalysisConfigDescriptor<TDocument> BucketSpan(Elastic.Clients.Elasticsearch.Duration bucketSpan)
		{
			BucketSpanValue = bucketSpan;
			return Self;
		}

		public AnalysisConfigDescriptor<TDocument> CategorizationAnalyzer(Elastic.Clients.Elasticsearch.Ml.CategorizationAnalyzer? categorizationAnalyzer)
		{
			CategorizationAnalyzerValue = categorizationAnalyzer;
			return Self;
		}

		public AnalysisConfigDescriptor<TDocument> CategorizationFieldName(Elastic.Clients.Elasticsearch.Field? categorizationFieldName)
		{
			CategorizationFieldNameValue = categorizationFieldName;
			return Self;
		}

		public AnalysisConfigDescriptor<TDocument> CategorizationFieldName<TValue>(Expression<Func<TDocument, TValue>> categorizationFieldName)
		{
			CategorizationFieldNameValue = categorizationFieldName;
			return Self;
		}

		public AnalysisConfigDescriptor<TDocument> CategorizationFilters(IEnumerable<string>? categorizationFilters)
		{
			CategorizationFiltersValue = categorizationFilters;
			return Self;
		}

		public AnalysisConfigDescriptor<TDocument> Influencers(IEnumerable<Elastic.Clients.Elasticsearch.Field>? influencers)
		{
			InfluencersValue = influencers;
			return Self;
		}

		public AnalysisConfigDescriptor<TDocument> Latency(Elastic.Clients.Elasticsearch.Duration? latency)
		{
			LatencyValue = latency;
			return Self;
		}

		public AnalysisConfigDescriptor<TDocument> ModelPruneWindow(Elastic.Clients.Elasticsearch.Duration? modelPruneWindow)
		{
			ModelPruneWindowValue = modelPruneWindow;
			return Self;
		}

		public AnalysisConfigDescriptor<TDocument> MultivariateByFields(bool? multivariateByFields = true)
		{
			MultivariateByFieldsValue = multivariateByFields;
			return Self;
		}

		public AnalysisConfigDescriptor<TDocument> PerPartitionCategorization(Elastic.Clients.Elasticsearch.Ml.PerPartitionCategorization? perPartitionCategorization)
		{
			PerPartitionCategorizationDescriptor = null;
			PerPartitionCategorizationDescriptorAction = null;
			PerPartitionCategorizationValue = perPartitionCategorization;
			return Self;
		}

		public AnalysisConfigDescriptor<TDocument> PerPartitionCategorization(PerPartitionCategorizationDescriptor descriptor)
		{
			PerPartitionCategorizationValue = null;
			PerPartitionCategorizationDescriptorAction = null;
			PerPartitionCategorizationDescriptor = descriptor;
			return Self;
		}

		public AnalysisConfigDescriptor<TDocument> PerPartitionCategorization(Action<PerPartitionCategorizationDescriptor> configure)
		{
			PerPartitionCategorizationValue = null;
			PerPartitionCategorizationDescriptor = null;
			PerPartitionCategorizationDescriptorAction = configure;
			return Self;
		}

		public AnalysisConfigDescriptor<TDocument> SummaryCountFieldName(Elastic.Clients.Elasticsearch.Field? summaryCountFieldName)
		{
			SummaryCountFieldNameValue = summaryCountFieldName;
			return Self;
		}

		public AnalysisConfigDescriptor<TDocument> SummaryCountFieldName<TValue>(Expression<Func<TDocument, TValue>> summaryCountFieldName)
		{
			SummaryCountFieldNameValue = summaryCountFieldName;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (DetectorsDescriptor is not null)
			{
				writer.WritePropertyName("detectors");
				JsonSerializer.Serialize(writer, DetectorsDescriptor, options);
			}
			else if (DetectorsDescriptorAction is not null)
			{
				writer.WritePropertyName("detectors");
				JsonSerializer.Serialize(writer, new DetectorDescriptor<TDocument>(DetectorsDescriptorAction), options);
			}
			else if (DetectorsDescriptorActions is not null)
			{
				writer.WritePropertyName("detectors");
				writer.WriteStartArray();
				foreach (var action in DetectorsDescriptorActions)
				{
					JsonSerializer.Serialize(writer, new DetectorDescriptor<TDocument>(action), options);
				}

				writer.WriteEndArray();
			}
			else
			{
				writer.WritePropertyName("detectors");
				JsonSerializer.Serialize(writer, DetectorsValue, options);
			}

			writer.WritePropertyName("bucket_span");
			JsonSerializer.Serialize(writer, BucketSpanValue, options);
			if (CategorizationAnalyzerValue is not null)
			{
				writer.WritePropertyName("categorization_analyzer");
				JsonSerializer.Serialize(writer, CategorizationAnalyzerValue, options);
			}

			if (CategorizationFieldNameValue is not null)
			{
				writer.WritePropertyName("categorization_field_name");
				JsonSerializer.Serialize(writer, CategorizationFieldNameValue, options);
			}

			if (CategorizationFiltersValue is not null)
			{
				writer.WritePropertyName("categorization_filters");
				JsonSerializer.Serialize(writer, CategorizationFiltersValue, options);
			}

			if (InfluencersValue is not null)
			{
				writer.WritePropertyName("influencers");
				JsonSerializer.Serialize(writer, InfluencersValue, options);
			}

			if (LatencyValue is not null)
			{
				writer.WritePropertyName("latency");
				JsonSerializer.Serialize(writer, LatencyValue, options);
			}

			if (ModelPruneWindowValue is not null)
			{
				writer.WritePropertyName("model_prune_window");
				JsonSerializer.Serialize(writer, ModelPruneWindowValue, options);
			}

			if (MultivariateByFieldsValue.HasValue)
			{
				writer.WritePropertyName("multivariate_by_fields");
				writer.WriteBooleanValue(MultivariateByFieldsValue.Value);
			}

			if (PerPartitionCategorizationDescriptor is not null)
			{
				writer.WritePropertyName("per_partition_categorization");
				JsonSerializer.Serialize(writer, PerPartitionCategorizationDescriptor, options);
			}
			else if (PerPartitionCategorizationDescriptorAction is not null)
			{
				writer.WritePropertyName("per_partition_categorization");
				JsonSerializer.Serialize(writer, new PerPartitionCategorizationDescriptor(PerPartitionCategorizationDescriptorAction), options);
			}
			else if (PerPartitionCategorizationValue is not null)
			{
				writer.WritePropertyName("per_partition_categorization");
				JsonSerializer.Serialize(writer, PerPartitionCategorizationValue, options);
			}

			if (SummaryCountFieldNameValue is not null)
			{
				writer.WritePropertyName("summary_count_field_name");
				JsonSerializer.Serialize(writer, SummaryCountFieldNameValue, options);
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class AnalysisConfigDescriptor : SerializableDescriptorBase<AnalysisConfigDescriptor>
	{
		internal AnalysisConfigDescriptor(Action<AnalysisConfigDescriptor> configure) => configure.Invoke(this);
		public AnalysisConfigDescriptor() : base()
		{
		}

		private IEnumerable<Elastic.Clients.Elasticsearch.Ml.Detector> DetectorsValue { get; set; }

		private DetectorDescriptor DetectorsDescriptor { get; set; }

		private Action<DetectorDescriptor> DetectorsDescriptorAction { get; set; }

		private Action<DetectorDescriptor>[] DetectorsDescriptorActions { get; set; }

		private Elastic.Clients.Elasticsearch.Duration BucketSpanValue { get; set; }

		private Elastic.Clients.Elasticsearch.Ml.CategorizationAnalyzer? CategorizationAnalyzerValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field? CategorizationFieldNameValue { get; set; }

		private IEnumerable<string>? CategorizationFiltersValue { get; set; }

		private IEnumerable<Elastic.Clients.Elasticsearch.Field>? InfluencersValue { get; set; }

		private Elastic.Clients.Elasticsearch.Duration? LatencyValue { get; set; }

		private Elastic.Clients.Elasticsearch.Duration? ModelPruneWindowValue { get; set; }

		private bool? MultivariateByFieldsValue { get; set; }

		private Elastic.Clients.Elasticsearch.Ml.PerPartitionCategorization? PerPartitionCategorizationValue { get; set; }

		private PerPartitionCategorizationDescriptor PerPartitionCategorizationDescriptor { get; set; }

		private Action<PerPartitionCategorizationDescriptor> PerPartitionCategorizationDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.Field? SummaryCountFieldNameValue { get; set; }

		public AnalysisConfigDescriptor Detectors(IEnumerable<Elastic.Clients.Elasticsearch.Ml.Detector> detectors)
		{
			DetectorsDescriptor = null;
			DetectorsDescriptorAction = null;
			DetectorsDescriptorActions = null;
			DetectorsValue = detectors;
			return Self;
		}

		public AnalysisConfigDescriptor Detectors(DetectorDescriptor descriptor)
		{
			DetectorsValue = null;
			DetectorsDescriptorAction = null;
			DetectorsDescriptorActions = null;
			DetectorsDescriptor = descriptor;
			return Self;
		}

		public AnalysisConfigDescriptor Detectors(Action<DetectorDescriptor> configure)
		{
			DetectorsValue = null;
			DetectorsDescriptor = null;
			DetectorsDescriptorActions = null;
			DetectorsDescriptorAction = configure;
			return Self;
		}

		public AnalysisConfigDescriptor Detectors(params Action<DetectorDescriptor>[] configure)
		{
			DetectorsValue = null;
			DetectorsDescriptor = null;
			DetectorsDescriptorAction = null;
			DetectorsDescriptorActions = configure;
			return Self;
		}

		public AnalysisConfigDescriptor BucketSpan(Elastic.Clients.Elasticsearch.Duration bucketSpan)
		{
			BucketSpanValue = bucketSpan;
			return Self;
		}

		public AnalysisConfigDescriptor CategorizationAnalyzer(Elastic.Clients.Elasticsearch.Ml.CategorizationAnalyzer? categorizationAnalyzer)
		{
			CategorizationAnalyzerValue = categorizationAnalyzer;
			return Self;
		}

		public AnalysisConfigDescriptor CategorizationFieldName(Elastic.Clients.Elasticsearch.Field? categorizationFieldName)
		{
			CategorizationFieldNameValue = categorizationFieldName;
			return Self;
		}

		public AnalysisConfigDescriptor CategorizationFieldName<TDocument, TValue>(Expression<Func<TDocument, TValue>> categorizationFieldName)
		{
			CategorizationFieldNameValue = categorizationFieldName;
			return Self;
		}

		public AnalysisConfigDescriptor CategorizationFieldName<TDocument>(Expression<Func<TDocument, object>> categorizationFieldName)
		{
			CategorizationFieldNameValue = categorizationFieldName;
			return Self;
		}

		public AnalysisConfigDescriptor CategorizationFilters(IEnumerable<string>? categorizationFilters)
		{
			CategorizationFiltersValue = categorizationFilters;
			return Self;
		}

		public AnalysisConfigDescriptor Influencers(IEnumerable<Elastic.Clients.Elasticsearch.Field>? influencers)
		{
			InfluencersValue = influencers;
			return Self;
		}

		public AnalysisConfigDescriptor Latency(Elastic.Clients.Elasticsearch.Duration? latency)
		{
			LatencyValue = latency;
			return Self;
		}

		public AnalysisConfigDescriptor ModelPruneWindow(Elastic.Clients.Elasticsearch.Duration? modelPruneWindow)
		{
			ModelPruneWindowValue = modelPruneWindow;
			return Self;
		}

		public AnalysisConfigDescriptor MultivariateByFields(bool? multivariateByFields = true)
		{
			MultivariateByFieldsValue = multivariateByFields;
			return Self;
		}

		public AnalysisConfigDescriptor PerPartitionCategorization(Elastic.Clients.Elasticsearch.Ml.PerPartitionCategorization? perPartitionCategorization)
		{
			PerPartitionCategorizationDescriptor = null;
			PerPartitionCategorizationDescriptorAction = null;
			PerPartitionCategorizationValue = perPartitionCategorization;
			return Self;
		}

		public AnalysisConfigDescriptor PerPartitionCategorization(PerPartitionCategorizationDescriptor descriptor)
		{
			PerPartitionCategorizationValue = null;
			PerPartitionCategorizationDescriptorAction = null;
			PerPartitionCategorizationDescriptor = descriptor;
			return Self;
		}

		public AnalysisConfigDescriptor PerPartitionCategorization(Action<PerPartitionCategorizationDescriptor> configure)
		{
			PerPartitionCategorizationValue = null;
			PerPartitionCategorizationDescriptor = null;
			PerPartitionCategorizationDescriptorAction = configure;
			return Self;
		}

		public AnalysisConfigDescriptor SummaryCountFieldName(Elastic.Clients.Elasticsearch.Field? summaryCountFieldName)
		{
			SummaryCountFieldNameValue = summaryCountFieldName;
			return Self;
		}

		public AnalysisConfigDescriptor SummaryCountFieldName<TDocument, TValue>(Expression<Func<TDocument, TValue>> summaryCountFieldName)
		{
			SummaryCountFieldNameValue = summaryCountFieldName;
			return Self;
		}

		public AnalysisConfigDescriptor SummaryCountFieldName<TDocument>(Expression<Func<TDocument, object>> summaryCountFieldName)
		{
			SummaryCountFieldNameValue = summaryCountFieldName;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (DetectorsDescriptor is not null)
			{
				writer.WritePropertyName("detectors");
				JsonSerializer.Serialize(writer, DetectorsDescriptor, options);
			}
			else if (DetectorsDescriptorAction is not null)
			{
				writer.WritePropertyName("detectors");
				JsonSerializer.Serialize(writer, new DetectorDescriptor(DetectorsDescriptorAction), options);
			}
			else if (DetectorsDescriptorActions is not null)
			{
				writer.WritePropertyName("detectors");
				writer.WriteStartArray();
				foreach (var action in DetectorsDescriptorActions)
				{
					JsonSerializer.Serialize(writer, new DetectorDescriptor(action), options);
				}

				writer.WriteEndArray();
			}
			else
			{
				writer.WritePropertyName("detectors");
				JsonSerializer.Serialize(writer, DetectorsValue, options);
			}

			writer.WritePropertyName("bucket_span");
			JsonSerializer.Serialize(writer, BucketSpanValue, options);
			if (CategorizationAnalyzerValue is not null)
			{
				writer.WritePropertyName("categorization_analyzer");
				JsonSerializer.Serialize(writer, CategorizationAnalyzerValue, options);
			}

			if (CategorizationFieldNameValue is not null)
			{
				writer.WritePropertyName("categorization_field_name");
				JsonSerializer.Serialize(writer, CategorizationFieldNameValue, options);
			}

			if (CategorizationFiltersValue is not null)
			{
				writer.WritePropertyName("categorization_filters");
				JsonSerializer.Serialize(writer, CategorizationFiltersValue, options);
			}

			if (InfluencersValue is not null)
			{
				writer.WritePropertyName("influencers");
				JsonSerializer.Serialize(writer, InfluencersValue, options);
			}

			if (LatencyValue is not null)
			{
				writer.WritePropertyName("latency");
				JsonSerializer.Serialize(writer, LatencyValue, options);
			}

			if (ModelPruneWindowValue is not null)
			{
				writer.WritePropertyName("model_prune_window");
				JsonSerializer.Serialize(writer, ModelPruneWindowValue, options);
			}

			if (MultivariateByFieldsValue.HasValue)
			{
				writer.WritePropertyName("multivariate_by_fields");
				writer.WriteBooleanValue(MultivariateByFieldsValue.Value);
			}

			if (PerPartitionCategorizationDescriptor is not null)
			{
				writer.WritePropertyName("per_partition_categorization");
				JsonSerializer.Serialize(writer, PerPartitionCategorizationDescriptor, options);
			}
			else if (PerPartitionCategorizationDescriptorAction is not null)
			{
				writer.WritePropertyName("per_partition_categorization");
				JsonSerializer.Serialize(writer, new PerPartitionCategorizationDescriptor(PerPartitionCategorizationDescriptorAction), options);
			}
			else if (PerPartitionCategorizationValue is not null)
			{
				writer.WritePropertyName("per_partition_categorization");
				JsonSerializer.Serialize(writer, PerPartitionCategorizationValue, options);
			}

			if (SummaryCountFieldNameValue is not null)
			{
				writer.WritePropertyName("summary_count_field_name");
				JsonSerializer.Serialize(writer, SummaryCountFieldNameValue, options);
			}

			writer.WriteEndObject();
		}
	}
}