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
	public partial class DataframeEvaluationOutlierDetection : IDataframeEvaluationVariant
	{
		[JsonInclude]
		[JsonPropertyName("actual_field")]
		public Elastic.Clients.Elasticsearch.Field ActualField { get; set; }

		[JsonInclude]
		[JsonPropertyName("metrics")]
		public Elastic.Clients.Elasticsearch.Ml.DataframeEvaluationOutlierDetectionMetrics? Metrics { get; set; }

		[JsonInclude]
		[JsonPropertyName("predicted_probability_field")]
		public Elastic.Clients.Elasticsearch.Field PredictedProbabilityField { get; set; }
	}

	public sealed partial class DataframeEvaluationOutlierDetectionDescriptor<TDocument> : SerializableDescriptorBase<DataframeEvaluationOutlierDetectionDescriptor<TDocument>>
	{
		internal DataframeEvaluationOutlierDetectionDescriptor(Action<DataframeEvaluationOutlierDetectionDescriptor<TDocument>> configure) => configure.Invoke(this);
		public DataframeEvaluationOutlierDetectionDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.Field ActualFieldValue { get; set; }

		private Elastic.Clients.Elasticsearch.Ml.DataframeEvaluationOutlierDetectionMetrics? MetricsValue { get; set; }

		private DataframeEvaluationOutlierDetectionMetricsDescriptor MetricsDescriptor { get; set; }

		private Action<DataframeEvaluationOutlierDetectionMetricsDescriptor> MetricsDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.Field PredictedProbabilityFieldValue { get; set; }

		public DataframeEvaluationOutlierDetectionDescriptor<TDocument> ActualField(Elastic.Clients.Elasticsearch.Field actualField)
		{
			ActualFieldValue = actualField;
			return Self;
		}

		public DataframeEvaluationOutlierDetectionDescriptor<TDocument> ActualField<TValue>(Expression<Func<TDocument, TValue>> actualField)
		{
			ActualFieldValue = actualField;
			return Self;
		}

		public DataframeEvaluationOutlierDetectionDescriptor<TDocument> Metrics(Elastic.Clients.Elasticsearch.Ml.DataframeEvaluationOutlierDetectionMetrics? metrics)
		{
			MetricsDescriptor = null;
			MetricsDescriptorAction = null;
			MetricsValue = metrics;
			return Self;
		}

		public DataframeEvaluationOutlierDetectionDescriptor<TDocument> Metrics(DataframeEvaluationOutlierDetectionMetricsDescriptor descriptor)
		{
			MetricsValue = null;
			MetricsDescriptorAction = null;
			MetricsDescriptor = descriptor;
			return Self;
		}

		public DataframeEvaluationOutlierDetectionDescriptor<TDocument> Metrics(Action<DataframeEvaluationOutlierDetectionMetricsDescriptor> configure)
		{
			MetricsValue = null;
			MetricsDescriptor = null;
			MetricsDescriptorAction = configure;
			return Self;
		}

		public DataframeEvaluationOutlierDetectionDescriptor<TDocument> PredictedProbabilityField(Elastic.Clients.Elasticsearch.Field predictedProbabilityField)
		{
			PredictedProbabilityFieldValue = predictedProbabilityField;
			return Self;
		}

		public DataframeEvaluationOutlierDetectionDescriptor<TDocument> PredictedProbabilityField<TValue>(Expression<Func<TDocument, TValue>> predictedProbabilityField)
		{
			PredictedProbabilityFieldValue = predictedProbabilityField;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("actual_field");
			JsonSerializer.Serialize(writer, ActualFieldValue, options);
			if (MetricsDescriptor is not null)
			{
				writer.WritePropertyName("metrics");
				JsonSerializer.Serialize(writer, MetricsDescriptor, options);
			}
			else if (MetricsDescriptorAction is not null)
			{
				writer.WritePropertyName("metrics");
				JsonSerializer.Serialize(writer, new DataframeEvaluationOutlierDetectionMetricsDescriptor(MetricsDescriptorAction), options);
			}
			else if (MetricsValue is not null)
			{
				writer.WritePropertyName("metrics");
				JsonSerializer.Serialize(writer, MetricsValue, options);
			}

			writer.WritePropertyName("predicted_probability_field");
			JsonSerializer.Serialize(writer, PredictedProbabilityFieldValue, options);
			writer.WriteEndObject();
		}
	}

	public sealed partial class DataframeEvaluationOutlierDetectionDescriptor : SerializableDescriptorBase<DataframeEvaluationOutlierDetectionDescriptor>
	{
		internal DataframeEvaluationOutlierDetectionDescriptor(Action<DataframeEvaluationOutlierDetectionDescriptor> configure) => configure.Invoke(this);
		public DataframeEvaluationOutlierDetectionDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.Field ActualFieldValue { get; set; }

		private Elastic.Clients.Elasticsearch.Ml.DataframeEvaluationOutlierDetectionMetrics? MetricsValue { get; set; }

		private DataframeEvaluationOutlierDetectionMetricsDescriptor MetricsDescriptor { get; set; }

		private Action<DataframeEvaluationOutlierDetectionMetricsDescriptor> MetricsDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.Field PredictedProbabilityFieldValue { get; set; }

		public DataframeEvaluationOutlierDetectionDescriptor ActualField(Elastic.Clients.Elasticsearch.Field actualField)
		{
			ActualFieldValue = actualField;
			return Self;
		}

		public DataframeEvaluationOutlierDetectionDescriptor ActualField<TDocument, TValue>(Expression<Func<TDocument, TValue>> actualField)
		{
			ActualFieldValue = actualField;
			return Self;
		}

		public DataframeEvaluationOutlierDetectionDescriptor ActualField<TDocument>(Expression<Func<TDocument, object>> actualField)
		{
			ActualFieldValue = actualField;
			return Self;
		}

		public DataframeEvaluationOutlierDetectionDescriptor Metrics(Elastic.Clients.Elasticsearch.Ml.DataframeEvaluationOutlierDetectionMetrics? metrics)
		{
			MetricsDescriptor = null;
			MetricsDescriptorAction = null;
			MetricsValue = metrics;
			return Self;
		}

		public DataframeEvaluationOutlierDetectionDescriptor Metrics(DataframeEvaluationOutlierDetectionMetricsDescriptor descriptor)
		{
			MetricsValue = null;
			MetricsDescriptorAction = null;
			MetricsDescriptor = descriptor;
			return Self;
		}

		public DataframeEvaluationOutlierDetectionDescriptor Metrics(Action<DataframeEvaluationOutlierDetectionMetricsDescriptor> configure)
		{
			MetricsValue = null;
			MetricsDescriptor = null;
			MetricsDescriptorAction = configure;
			return Self;
		}

		public DataframeEvaluationOutlierDetectionDescriptor PredictedProbabilityField(Elastic.Clients.Elasticsearch.Field predictedProbabilityField)
		{
			PredictedProbabilityFieldValue = predictedProbabilityField;
			return Self;
		}

		public DataframeEvaluationOutlierDetectionDescriptor PredictedProbabilityField<TDocument, TValue>(Expression<Func<TDocument, TValue>> predictedProbabilityField)
		{
			PredictedProbabilityFieldValue = predictedProbabilityField;
			return Self;
		}

		public DataframeEvaluationOutlierDetectionDescriptor PredictedProbabilityField<TDocument>(Expression<Func<TDocument, object>> predictedProbabilityField)
		{
			PredictedProbabilityFieldValue = predictedProbabilityField;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("actual_field");
			JsonSerializer.Serialize(writer, ActualFieldValue, options);
			if (MetricsDescriptor is not null)
			{
				writer.WritePropertyName("metrics");
				JsonSerializer.Serialize(writer, MetricsDescriptor, options);
			}
			else if (MetricsDescriptorAction is not null)
			{
				writer.WritePropertyName("metrics");
				JsonSerializer.Serialize(writer, new DataframeEvaluationOutlierDetectionMetricsDescriptor(MetricsDescriptorAction), options);
			}
			else if (MetricsValue is not null)
			{
				writer.WritePropertyName("metrics");
				JsonSerializer.Serialize(writer, MetricsValue, options);
			}

			writer.WritePropertyName("predicted_probability_field");
			JsonSerializer.Serialize(writer, PredictedProbabilityFieldValue, options);
			writer.WriteEndObject();
		}
	}
}