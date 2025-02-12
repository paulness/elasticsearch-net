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
	public sealed partial class DataframeRegressionSummary
	{
		[JsonInclude]
		[JsonPropertyName("huber")]
		public Elastic.Clients.Elasticsearch.Ml.DataframeEvaluationValue? Huber { get; init; }

		[JsonInclude]
		[JsonPropertyName("mse")]
		public Elastic.Clients.Elasticsearch.Ml.DataframeEvaluationValue? Mse { get; init; }

		[JsonInclude]
		[JsonPropertyName("msle")]
		public Elastic.Clients.Elasticsearch.Ml.DataframeEvaluationValue? Msle { get; init; }

		[JsonInclude]
		[JsonPropertyName("r_squared")]
		public Elastic.Clients.Elasticsearch.Ml.DataframeEvaluationValue? RSquared { get; init; }
	}
}