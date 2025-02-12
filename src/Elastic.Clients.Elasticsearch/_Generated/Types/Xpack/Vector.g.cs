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
namespace Elastic.Clients.Elasticsearch.Xpack
{
	public sealed partial class Vector
	{
		[JsonInclude]
		[JsonPropertyName("available")]
		public bool Available { get; init; }

		[JsonInclude]
		[JsonPropertyName("dense_vector_dims_avg_count")]
		public int DenseVectorDimsAvgCount { get; init; }

		[JsonInclude]
		[JsonPropertyName("dense_vector_fields_count")]
		public int DenseVectorFieldsCount { get; init; }

		[JsonInclude]
		[JsonPropertyName("enabled")]
		public bool Enabled { get; init; }

		[JsonInclude]
		[JsonPropertyName("sparse_vector_fields_count")]
		public int? SparseVectorFieldsCount { get; init; }
	}
}