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
namespace Elastic.Clients.Elasticsearch.Nodes
{
	public sealed partial class Discovery
	{
		[JsonInclude]
		[JsonPropertyName("cluster_applier_stats")]
		public Elastic.Clients.Elasticsearch.Nodes.ClusterAppliedStats? ClusterApplierStats { get; init; }

		[JsonInclude]
		[JsonPropertyName("cluster_state_queue")]
		public Elastic.Clients.Elasticsearch.Nodes.ClusterStateQueue? ClusterStateQueue { get; init; }

		[JsonInclude]
		[JsonPropertyName("cluster_state_update")]
		public Dictionary<string, Elastic.Clients.Elasticsearch.Nodes.ClusterStateUpdate>? ClusterStateUpdate { get; init; }

		[JsonInclude]
		[JsonPropertyName("published_cluster_states")]
		public Elastic.Clients.Elasticsearch.Nodes.PublishedClusterStates? PublishedClusterStates { get; init; }

		[JsonInclude]
		[JsonPropertyName("serialized_cluster_states")]
		public Elastic.Clients.Elasticsearch.Nodes.SerializedClusterState? SerializedClusterStates { get; init; }
	}
}