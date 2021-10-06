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

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using Elastic.Transport;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Aggregations
{
	public enum ValueType
	{
		[EnumMember(Value = "string")]
		String,
		[EnumMember(Value = "numeric")]
		Numeric,
		[EnumMember(Value = "number")]
		Number,
		[EnumMember(Value = "long")]
		Long,
		[EnumMember(Value = "ip")]
		Ip,
		[EnumMember(Value = "geo_point")]
		GeoPoint,
		[EnumMember(Value = "double")]
		Double,
		[EnumMember(Value = "date_nanos")]
		DateNanos,
		[EnumMember(Value = "date")]
		Date,
		[EnumMember(Value = "boolean")]
		Boolean
	}

	public enum TTestType
	{
		[EnumMember(Value = "paired")]
		Paired,
		[EnumMember(Value = "homoscedastic")]
		Homoscedastic,
		[EnumMember(Value = "heteroscedastic")]
		Heteroscedastic
	}

	public enum MissingOrder
	{
		[EnumMember(Value = "last")]
		Last,
		[EnumMember(Value = "first")]
		First,
		[EnumMember(Value = "default")]
		Default
	}

	public enum TermsAggregationExecutionHint
	{
		[EnumMember(Value = "map")]
		Map,
		[EnumMember(Value = "global_ordinals_low_cardinality")]
		GlobalOrdinalsLowCardinality,
		[EnumMember(Value = "global_ordinals_hash")]
		GlobalOrdinalsHash,
		[EnumMember(Value = "global_ordinals")]
		GlobalOrdinals
	}

	public enum TermsAggregationCollectMode
	{
		[EnumMember(Value = "depth_first")]
		DepthFirst,
		[EnumMember(Value = "breadth_first")]
		BreadthFirst
	}

	public enum DateInterval
	{
		[EnumMember(Value = "year")]
		Year,
		[EnumMember(Value = "week")]
		Week,
		[EnumMember(Value = "second")]
		Second,
		[EnumMember(Value = "quarter")]
		Quarter,
		[EnumMember(Value = "month")]
		Month,
		[EnumMember(Value = "minute")]
		Minute,
		[EnumMember(Value = "hour")]
		Hour,
		[EnumMember(Value = "day")]
		Day
	}

	public enum GapPolicy
	{
		[EnumMember(Value = "skip")]
		Skip,
		[EnumMember(Value = "insert_zeros")]
		InsertZeros
	}

	public enum RateMode
	{
		[EnumMember(Value = "value_count")]
		ValueCount,
		[EnumMember(Value = "sum")]
		Sum
	}

	public enum NormalizeMethod
	{
		[EnumMember(Value = "z-score")]
		ZScore,
		[EnumMember(Value = "softmax")]
		Softmax,
		[EnumMember(Value = "rescale_0_100")]
		Rescale0100,
		[EnumMember(Value = "rescale_0_1")]
		Rescale01,
		[EnumMember(Value = "percent_of_sum")]
		PercentOfSum,
		[EnumMember(Value = "mean")]
		Mean
	}

	public enum HoltWintersType
	{
		[EnumMember(Value = "mult")]
		Multiplicative,
		[EnumMember(Value = "add")]
		Additive
	}

	public enum MovingAverageModel
	{
		[EnumMember(Value = "simple")]
		Simple,
		[EnumMember(Value = "linear")]
		Linear,
		[EnumMember(Value = "holt_winters")]
		HoltWinters,
		[EnumMember(Value = "holt")]
		Holt,
		[EnumMember(Value = "ewma")]
		Ewma
	}

	public enum MatrixStatsMode
	{
		[EnumMember(Value = "sum")]
		Sum,
		[EnumMember(Value = "min")]
		Min,
		[EnumMember(Value = "median")]
		Median,
		[EnumMember(Value = "max")]
		Max,
		[EnumMember(Value = "avg")]
		Avg
	}

	public enum SamplerAggregationExecutionHint
	{
		[EnumMember(Value = "map")]
		Map,
		[EnumMember(Value = "global_ordinals")]
		GlobalOrdinals,
		[EnumMember(Value = "bytes_hash")]
		BytesHash
	}

	public enum MinimumInterval
	{
		[EnumMember(Value = "year")]
		Year,
		[EnumMember(Value = "second")]
		Second,
		[EnumMember(Value = "month")]
		Month,
		[EnumMember(Value = "minute")]
		Minute,
		[EnumMember(Value = "hour")]
		Hour,
		[EnumMember(Value = "day")]
		Day
	}
}