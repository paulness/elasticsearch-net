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
namespace Elastic.Clients.Elasticsearch.Snapshot
{
	public sealed partial class ShardsStatsSummary
	{
		[JsonInclude]
		[JsonPropertyName("incremental")]
		public Elastic.Clients.Elasticsearch.Snapshot.ShardsStatsSummaryItem Incremental { get; init; }

		[JsonInclude]
		[JsonPropertyName("start_time_in_millis")]
		public long StartTimeInMillis { get; init; }

		[JsonInclude]
		[JsonPropertyName("time")]
		public Elastic.Clients.Elasticsearch.Duration? Time { get; init; }

		[JsonInclude]
		[JsonPropertyName("time_in_millis")]
		public long TimeInMillis { get; init; }

		[JsonInclude]
		[JsonPropertyName("total")]
		public Elastic.Clients.Elasticsearch.Snapshot.ShardsStatsSummaryItem Total { get; init; }
	}
}