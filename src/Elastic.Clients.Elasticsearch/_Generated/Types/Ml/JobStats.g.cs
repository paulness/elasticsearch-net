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
	public sealed partial class JobStats
	{
		[JsonInclude]
		[JsonPropertyName("assignment_explanation")]
		public string? AssignmentExplanation { get; init; }

		[JsonInclude]
		[JsonPropertyName("data_counts")]
		public Elastic.Clients.Elasticsearch.Ml.DataCounts DataCounts { get; init; }

		[JsonInclude]
		[JsonPropertyName("deleting")]
		public bool? Deleting { get; init; }

		[JsonInclude]
		[JsonPropertyName("forecasts_stats")]
		public Elastic.Clients.Elasticsearch.Ml.JobForecastStatistics ForecastsStats { get; init; }

		[JsonInclude]
		[JsonPropertyName("job_id")]
		public string JobId { get; init; }

		[JsonInclude]
		[JsonPropertyName("model_size_stats")]
		public Elastic.Clients.Elasticsearch.Ml.ModelSizeStats ModelSizeStats { get; init; }

		[JsonInclude]
		[JsonPropertyName("node")]
		public Elastic.Clients.Elasticsearch.Ml.DiscoveryNode? Node { get; init; }

		[JsonInclude]
		[JsonPropertyName("open_time")]
		public DateTimeOffset? OpenTime { get; init; }

		[JsonInclude]
		[JsonPropertyName("state")]
		public Elastic.Clients.Elasticsearch.Ml.JobState State { get; init; }

		[JsonInclude]
		[JsonPropertyName("timing_stats")]
		public Elastic.Clients.Elasticsearch.Ml.JobTimingStats TimingStats { get; init; }
	}
}