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
	public partial class DelayedDataCheckConfig
	{
		[JsonInclude]
		[JsonPropertyName("check_window")]
		public Elastic.Clients.Elasticsearch.Duration? CheckWindow { get; set; }

		[JsonInclude]
		[JsonPropertyName("enabled")]
		public bool Enabled { get; set; }
	}

	public sealed partial class DelayedDataCheckConfigDescriptor : SerializableDescriptorBase<DelayedDataCheckConfigDescriptor>
	{
		internal DelayedDataCheckConfigDescriptor(Action<DelayedDataCheckConfigDescriptor> configure) => configure.Invoke(this);
		public DelayedDataCheckConfigDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.Duration? CheckWindowValue { get; set; }

		private bool EnabledValue { get; set; }

		public DelayedDataCheckConfigDescriptor CheckWindow(Elastic.Clients.Elasticsearch.Duration? checkWindow)
		{
			CheckWindowValue = checkWindow;
			return Self;
		}

		public DelayedDataCheckConfigDescriptor Enabled(bool enabled = true)
		{
			EnabledValue = enabled;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (CheckWindowValue is not null)
			{
				writer.WritePropertyName("check_window");
				JsonSerializer.Serialize(writer, CheckWindowValue, options);
			}

			writer.WritePropertyName("enabled");
			writer.WriteBooleanValue(EnabledValue);
			writer.WriteEndObject();
		}
	}
}