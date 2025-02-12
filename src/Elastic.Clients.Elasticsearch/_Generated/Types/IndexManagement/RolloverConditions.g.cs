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
namespace Elastic.Clients.Elasticsearch.IndexManagement
{
	public sealed partial class RolloverConditions
	{
		[JsonInclude]
		[JsonPropertyName("max_age")]
		public Elastic.Clients.Elasticsearch.Duration? MaxAge { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_age_millis")]
		public long? MaxAgeMillis { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_docs")]
		public long? MaxDocs { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_primary_shard_size")]
		public Elastic.Clients.Elasticsearch.ByteSize? MaxPrimaryShardSize { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_primary_shard_size_bytes")]
		public Elastic.Clients.Elasticsearch.ByteSize? MaxPrimaryShardSizeBytes { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_size")]
		public string? MaxSize { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_size_bytes")]
		public Elastic.Clients.Elasticsearch.ByteSize? MaxSizeBytes { get; set; }
	}

	public sealed partial class RolloverConditionsDescriptor : SerializableDescriptorBase<RolloverConditionsDescriptor>
	{
		internal RolloverConditionsDescriptor(Action<RolloverConditionsDescriptor> configure) => configure.Invoke(this);
		public RolloverConditionsDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.Duration? MaxAgeValue { get; set; }

		private long? MaxAgeMillisValue { get; set; }

		private long? MaxDocsValue { get; set; }

		private Elastic.Clients.Elasticsearch.ByteSize? MaxPrimaryShardSizeValue { get; set; }

		private Elastic.Clients.Elasticsearch.ByteSize? MaxPrimaryShardSizeBytesValue { get; set; }

		private string? MaxSizeValue { get; set; }

		private Elastic.Clients.Elasticsearch.ByteSize? MaxSizeBytesValue { get; set; }

		public RolloverConditionsDescriptor MaxAge(Elastic.Clients.Elasticsearch.Duration? maxAge)
		{
			MaxAgeValue = maxAge;
			return Self;
		}

		public RolloverConditionsDescriptor MaxAgeMillis(long? maxAgeMillis)
		{
			MaxAgeMillisValue = maxAgeMillis;
			return Self;
		}

		public RolloverConditionsDescriptor MaxDocs(long? maxDocs)
		{
			MaxDocsValue = maxDocs;
			return Self;
		}

		public RolloverConditionsDescriptor MaxPrimaryShardSize(Elastic.Clients.Elasticsearch.ByteSize? maxPrimaryShardSize)
		{
			MaxPrimaryShardSizeValue = maxPrimaryShardSize;
			return Self;
		}

		public RolloverConditionsDescriptor MaxPrimaryShardSizeBytes(Elastic.Clients.Elasticsearch.ByteSize? maxPrimaryShardSizeBytes)
		{
			MaxPrimaryShardSizeBytesValue = maxPrimaryShardSizeBytes;
			return Self;
		}

		public RolloverConditionsDescriptor MaxSize(string? maxSize)
		{
			MaxSizeValue = maxSize;
			return Self;
		}

		public RolloverConditionsDescriptor MaxSizeBytes(Elastic.Clients.Elasticsearch.ByteSize? maxSizeBytes)
		{
			MaxSizeBytesValue = maxSizeBytes;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (MaxAgeValue is not null)
			{
				writer.WritePropertyName("max_age");
				JsonSerializer.Serialize(writer, MaxAgeValue, options);
			}

			if (MaxAgeMillisValue is not null)
			{
				writer.WritePropertyName("max_age_millis");
				JsonSerializer.Serialize(writer, MaxAgeMillisValue, options);
			}

			if (MaxDocsValue.HasValue)
			{
				writer.WritePropertyName("max_docs");
				writer.WriteNumberValue(MaxDocsValue.Value);
			}

			if (MaxPrimaryShardSizeValue is not null)
			{
				writer.WritePropertyName("max_primary_shard_size");
				JsonSerializer.Serialize(writer, MaxPrimaryShardSizeValue, options);
			}

			if (MaxPrimaryShardSizeBytesValue is not null)
			{
				writer.WritePropertyName("max_primary_shard_size_bytes");
				JsonSerializer.Serialize(writer, MaxPrimaryShardSizeBytesValue, options);
			}

			if (!string.IsNullOrEmpty(MaxSizeValue))
			{
				writer.WritePropertyName("max_size");
				writer.WriteStringValue(MaxSizeValue);
			}

			if (MaxSizeBytesValue is not null)
			{
				writer.WritePropertyName("max_size_bytes");
				JsonSerializer.Serialize(writer, MaxSizeBytesValue, options);
			}

			writer.WriteEndObject();
		}
	}
}