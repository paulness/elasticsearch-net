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
namespace Elastic.Clients.Elasticsearch.Ingest
{
	public partial class GrokProcessor : Ingest.ProcessorBase, IProcessorContainerVariant
	{
		[JsonIgnore]
		string Ingest.IProcessorContainerVariant.ProcessorContainerVariantName => "grok";
		[JsonInclude]
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field Field { get; set; }

		[JsonInclude]
		[JsonPropertyName("ignore_missing")]
		public bool? IgnoreMissing { get; set; }

		[JsonInclude]
		[JsonPropertyName("pattern_definitions")]
		public Dictionary<string, string> PatternDefinitions { get; set; }

		[JsonInclude]
		[JsonPropertyName("patterns")]
		public IEnumerable<string> Patterns { get; set; }

		[JsonInclude]
		[JsonPropertyName("trace_match")]
		public bool? TraceMatch { get; set; }
	}

	public sealed partial class GrokProcessorDescriptor<TDocument> : DescriptorBase<GrokProcessorDescriptor<TDocument>>
	{
		internal GrokProcessorDescriptor(Action<GrokProcessorDescriptor<TDocument>> configure) => configure.Invoke(this);
		public GrokProcessorDescriptor() : base()
		{
		}

		private IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? OnFailureValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }

		private string? IfValue { get; set; }

		private bool? IgnoreFailureValue { get; set; }

		private bool? IgnoreMissingValue { get; set; }

		private Dictionary<string, string> PatternDefinitionsValue { get; set; }

		private IEnumerable<string> PatternsValue { get; set; }

		private string? TagValue { get; set; }

		private bool? TraceMatchValue { get; set; }

		public GrokProcessorDescriptor<TDocument> OnFailure(IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? onFailure)
		{
			OnFailureValue = onFailure;
			return Self;
		}

		public GrokProcessorDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field field)
		{
			FieldValue = field;
			return Self;
		}

		public GrokProcessorDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		public GrokProcessorDescriptor<TDocument> If(string? ifValue)
		{
			IfValue = ifValue;
			return Self;
		}

		public GrokProcessorDescriptor<TDocument> IgnoreFailure(bool? ignoreFailure = true)
		{
			IgnoreFailureValue = ignoreFailure;
			return Self;
		}

		public GrokProcessorDescriptor<TDocument> IgnoreMissing(bool? ignoreMissing = true)
		{
			IgnoreMissingValue = ignoreMissing;
			return Self;
		}

		public GrokProcessorDescriptor<TDocument> PatternDefinitions(Func<FluentDictionary<string, string>, FluentDictionary<string, string>> selector)
		{
			PatternDefinitionsValue = selector?.Invoke(new FluentDictionary<string, string>());
			return Self;
		}

		public GrokProcessorDescriptor<TDocument> Patterns(IEnumerable<string> patterns)
		{
			PatternsValue = patterns;
			return Self;
		}

		public GrokProcessorDescriptor<TDocument> Tag(string? tag)
		{
			TagValue = tag;
			return Self;
		}

		public GrokProcessorDescriptor<TDocument> TraceMatch(bool? traceMatch = true)
		{
			TraceMatchValue = traceMatch;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (OnFailureValue is not null)
			{
				writer.WritePropertyName("on_failure");
				JsonSerializer.Serialize(writer, OnFailureValue, options);
			}

			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
			if (!string.IsNullOrEmpty(IfValue))
			{
				writer.WritePropertyName("if");
				writer.WriteStringValue(IfValue);
			}

			if (IgnoreFailureValue.HasValue)
			{
				writer.WritePropertyName("ignore_failure");
				writer.WriteBooleanValue(IgnoreFailureValue.Value);
			}

			if (IgnoreMissingValue.HasValue)
			{
				writer.WritePropertyName("ignore_missing");
				writer.WriteBooleanValue(IgnoreMissingValue.Value);
			}

			writer.WritePropertyName("pattern_definitions");
			JsonSerializer.Serialize(writer, PatternDefinitionsValue, options);
			writer.WritePropertyName("patterns");
			JsonSerializer.Serialize(writer, PatternsValue, options);
			if (!string.IsNullOrEmpty(TagValue))
			{
				writer.WritePropertyName("tag");
				writer.WriteStringValue(TagValue);
			}

			if (TraceMatchValue.HasValue)
			{
				writer.WritePropertyName("trace_match");
				writer.WriteBooleanValue(TraceMatchValue.Value);
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class GrokProcessorDescriptor : DescriptorBase<GrokProcessorDescriptor>
	{
		internal GrokProcessorDescriptor(Action<GrokProcessorDescriptor> configure) => configure.Invoke(this);
		public GrokProcessorDescriptor() : base()
		{
		}

		private IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? OnFailureValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }

		private string? IfValue { get; set; }

		private bool? IgnoreFailureValue { get; set; }

		private bool? IgnoreMissingValue { get; set; }

		private Dictionary<string, string> PatternDefinitionsValue { get; set; }

		private IEnumerable<string> PatternsValue { get; set; }

		private string? TagValue { get; set; }

		private bool? TraceMatchValue { get; set; }

		public GrokProcessorDescriptor OnFailure(IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? onFailure)
		{
			OnFailureValue = onFailure;
			return Self;
		}

		public GrokProcessorDescriptor Field(Elastic.Clients.Elasticsearch.Field field)
		{
			FieldValue = field;
			return Self;
		}

		public GrokProcessorDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		public GrokProcessorDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
		{
			FieldValue = field;
			return Self;
		}

		public GrokProcessorDescriptor If(string? ifValue)
		{
			IfValue = ifValue;
			return Self;
		}

		public GrokProcessorDescriptor IgnoreFailure(bool? ignoreFailure = true)
		{
			IgnoreFailureValue = ignoreFailure;
			return Self;
		}

		public GrokProcessorDescriptor IgnoreMissing(bool? ignoreMissing = true)
		{
			IgnoreMissingValue = ignoreMissing;
			return Self;
		}

		public GrokProcessorDescriptor PatternDefinitions(Func<FluentDictionary<string, string>, FluentDictionary<string, string>> selector)
		{
			PatternDefinitionsValue = selector?.Invoke(new FluentDictionary<string, string>());
			return Self;
		}

		public GrokProcessorDescriptor Patterns(IEnumerable<string> patterns)
		{
			PatternsValue = patterns;
			return Self;
		}

		public GrokProcessorDescriptor Tag(string? tag)
		{
			TagValue = tag;
			return Self;
		}

		public GrokProcessorDescriptor TraceMatch(bool? traceMatch = true)
		{
			TraceMatchValue = traceMatch;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (OnFailureValue is not null)
			{
				writer.WritePropertyName("on_failure");
				JsonSerializer.Serialize(writer, OnFailureValue, options);
			}

			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
			if (!string.IsNullOrEmpty(IfValue))
			{
				writer.WritePropertyName("if");
				writer.WriteStringValue(IfValue);
			}

			if (IgnoreFailureValue.HasValue)
			{
				writer.WritePropertyName("ignore_failure");
				writer.WriteBooleanValue(IgnoreFailureValue.Value);
			}

			if (IgnoreMissingValue.HasValue)
			{
				writer.WritePropertyName("ignore_missing");
				writer.WriteBooleanValue(IgnoreMissingValue.Value);
			}

			writer.WritePropertyName("pattern_definitions");
			JsonSerializer.Serialize(writer, PatternDefinitionsValue, options);
			writer.WritePropertyName("patterns");
			JsonSerializer.Serialize(writer, PatternsValue, options);
			if (!string.IsNullOrEmpty(TagValue))
			{
				writer.WritePropertyName("tag");
				writer.WriteStringValue(TagValue);
			}

			if (TraceMatchValue.HasValue)
			{
				writer.WritePropertyName("trace_match");
				writer.WriteBooleanValue(TraceMatchValue.Value);
			}

			writer.WriteEndObject();
		}
	}
}