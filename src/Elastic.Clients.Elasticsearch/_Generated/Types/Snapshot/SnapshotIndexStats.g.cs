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
	public sealed partial class SnapshotIndexStats
	{
		[JsonInclude]
		[JsonPropertyName("shards")]
		public Dictionary<string, Elastic.Clients.Elasticsearch.Snapshot.SnapshotShardsStatus> Shards { get; init; }

		[JsonInclude]
		[JsonPropertyName("shards_stats")]
		public Elastic.Clients.Elasticsearch.Snapshot.ShardsStats ShardsStats { get; init; }

		[JsonInclude]
		[JsonPropertyName("stats")]
		public Elastic.Clients.Elasticsearch.Snapshot.SnapshotStats Stats { get; init; }
	}
}