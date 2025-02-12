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
namespace Elastic.Clients.Elasticsearch.Cluster
{
	public sealed partial class ClusterInfo
	{
		[JsonInclude]
		[JsonPropertyName("nodes")]
		public Dictionary<string, Elastic.Clients.Elasticsearch.Cluster.NodeDiskUsage> Nodes { get; init; }

		[JsonInclude]
		[JsonPropertyName("reserved_sizes")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Cluster.ReservedSize> ReservedSizes { get; init; }

		[JsonInclude]
		[JsonPropertyName("shard_data_set_sizes")]
		public Dictionary<string, string>? ShardDataSetSizes { get; init; }

		[JsonInclude]
		[JsonPropertyName("shard_paths")]
		public Dictionary<string, string> ShardPaths { get; init; }

		[JsonInclude]
		[JsonPropertyName("shard_sizes")]
		public Dictionary<string, long> ShardSizes { get; init; }
	}
}