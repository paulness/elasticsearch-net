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
// Run the following in the root of the repository:
//
// ------------------------------------------------

using Elastic.Transport.Products.Elasticsearch.Failures;
using OneOf;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable restore
namespace Nest.Ml
{
	public partial class AnalysisConfig
	{
		[JsonPropertyName("bucket_span")]
		public Nest.Time BucketSpan
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("categorization_analyzer")]
		public Union<Nest.Ml.CategorizationAnalyzer, string>? CategorizationAnalyzer
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("categorization_field_name")]
		public Nest.Field? CategorizationFieldName
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("categorization_filters")]
		public IReadOnlyCollection<string>? CategorizationFilters
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("detectors")]
		public IReadOnlyCollection<Nest.Ml.Detector> Detectors
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("influencers")]
		public IReadOnlyCollection<Nest.Field> Influencers
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("latency")]
		public Nest.Time? Latency
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("model_prune_window")]
		public Nest.Time? ModelPruneWindow
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("multivariate_by_fields")]
		public bool? MultivariateByFields
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("per_partition_categorization")]
		public Nest.Ml.PerPartitionCategorization? PerPartitionCategorization
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("summary_count_field_name")]
		public Nest.Field? SummaryCountFieldName
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class AnalysisLimits
	{
		[JsonPropertyName("categorization_examples_limit")]
		public long? CategorizationExamplesLimit
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("model_memory_limit")]
		public string? ModelMemoryLimit
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class CategorizationAnalyzer
	{
		[JsonPropertyName("char_filter")]
		public IReadOnlyCollection<Union<string, Nest.Analysis.CharFilter>>? CharFilter
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("filter")]
		public IReadOnlyCollection<Union<string, Nest.Analysis.TokenFilter>>? Filter
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("tokenizer")]
		public Union<string, Nest.Analysis.Tokenizer>? Tokenizer
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ChunkingConfig
	{
		[JsonPropertyName("mode")]
		public Nest.Ml.ChunkingMode Mode
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("time_span")]
		public Nest.Time? TimeSpan
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class CustomSettings
	{
		[JsonPropertyName("created_by")]
		public string? CreatedBy
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("custom_urls")]
		public IReadOnlyCollection<Nest.Xpack.Usage.UrlConfig>? CustomUrls
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("job_tags")]
		public Dictionary<string, string>? JobTags
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class DataDescription
	{
		[JsonPropertyName("field_delimiter")]
		public string? FieldDelimiter
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("format")]
		public string? Format
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("time_field")]
		public Nest.Field TimeField
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("time_format")]
		public string? TimeFormat
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class Datafeed
	{
		[JsonPropertyName("aggregations")]
		public Dictionary<string, Nest.Aggregations.AggregationContainer>? Aggregations
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("aggs")]
		public Dictionary<string, Nest.Aggregations.AggregationContainer>? Aggs
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("chunking_config")]
		public Nest.Ml.ChunkingConfig? ChunkingConfig
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("datafeed_id")]
		public Nest.Id DatafeedId
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("delayed_data_check_config")]
		public Nest.Ml.DelayedDataCheckConfig DelayedDataCheckConfig
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("frequency")]
		public Nest.Timestamp? Frequency
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("indexes")]
		public IReadOnlyCollection<string>? Indexes
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("indices")]
		public IReadOnlyCollection<string> Indices
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("indices_options")]
		public Nest.Ml.DatafeedIndicesOptions? IndicesOptions
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("job_id")]
		public Nest.Id JobId
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("max_empty_searches")]
		public int? MaxEmptySearches
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("query")]
		public Nest.QueryDsl.QueryContainer Query
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("query_delay")]
		public Nest.Timestamp? QueryDelay
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("runtime_mappings")]
		public Nest.Mapping.RuntimeFields? RuntimeMappings
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("script_fields")]
		public Dictionary<string, Nest.ScriptField>? ScriptFields
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("scroll_size")]
		public int? ScrollSize
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class DatafeedIndicesOptions
	{
		[JsonPropertyName("allow_no_indices")]
		public bool? AllowNoIndices
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("expand_wildcards")]
		public Nest.ExpandWildcards? ExpandWildcards
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("ignore_throttled")]
		public bool? IgnoreThrottled
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("ignore_unavailable")]
		public bool? IgnoreUnavailable
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class DataframeAnalysisAnalyzedFieldsIncludeExclude
	{
		[JsonPropertyName("excludes")]
		public IReadOnlyCollection<string> Excludes
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("includes")]
		public IReadOnlyCollection<string> Includes
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class DelayedDataCheckConfig
	{
		[JsonPropertyName("check_window")]
		public Nest.Time? CheckWindow
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("enabled")]
		public bool Enabled
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class DetectionRule
	{
		[JsonPropertyName("actions")]
		public IReadOnlyCollection<Nest.Ml.RuleAction>? Actions
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("conditions")]
		public IReadOnlyCollection<Nest.Ml.RuleCondition>? Conditions
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("scope")]
		public Dictionary<Nest.Field, Nest.Ml.FilterRef>? Scope
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class Detector
	{
		[JsonPropertyName("by_field_name")]
		public Nest.Field? ByFieldName
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("custom_rules")]
		public IReadOnlyCollection<Nest.Ml.DetectionRule>? CustomRules
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("detector_description")]
		public string? DetectorDescription
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("detector_index")]
		public int? DetectorIndex
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("exclude_frequent")]
		public Nest.Ml.ExcludeFrequent? ExcludeFrequent
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("field_name")]
		public Nest.Field? FieldName
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("function")]
		public string Function
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("over_field_name")]
		public Nest.Field? OverFieldName
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("partition_field_name")]
		public Nest.Field? PartitionFieldName
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("use_null")]
		public bool? UseNull
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class FilterRef
	{
		[JsonPropertyName("filter_id")]
		public Nest.Id FilterId
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("filter_type")]
		public Nest.Ml.FilterType? FilterType
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class Job
	{
		[JsonPropertyName("allow_lazy_open")]
		public bool AllowLazyOpen
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("analysis_config")]
		public Nest.Ml.AnalysisConfig AnalysisConfig
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("analysis_limits")]
		public Nest.Ml.AnalysisLimits? AnalysisLimits
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("background_persist_interval")]
		public Nest.Time BackgroundPersistInterval
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("blocked")]
		public Nest.Ml.JobBlocked? Blocked
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("create_time")]
		public int CreateTime
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("custom_settings")]
		public Nest.Ml.CustomSettings? CustomSettings
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("daily_model_snapshot_retention_after_days")]
		public long? DailyModelSnapshotRetentionAfterDays
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("data_description")]
		public Nest.Ml.DataDescription DataDescription
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("datafeed_config")]
		public Nest.Ml.Datafeed? DatafeedConfig
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("deleting")]
		public bool? Deleting
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("description")]
		public string? Description
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("finished_time")]
		public int? FinishedTime
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("groups")]
		public IReadOnlyCollection<string>? Groups
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("job_id")]
		public Nest.Id JobId
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("job_type")]
		public string JobType
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("job_version")]
		public Nest.VersionString JobVersion
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("model_plot_config")]
		public Nest.Ml.ModelPlotConfig? ModelPlotConfig
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("model_snapshot_id")]
		public Nest.Id? ModelSnapshotId
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("model_snapshot_retention_days")]
		public long ModelSnapshotRetentionDays
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("renormalization_window_days")]
		public long? RenormalizationWindowDays
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("results_index_name")]
		public Nest.IndexName ResultsIndexName
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("results_retention_days")]
		public long? ResultsRetentionDays
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class JobBlocked
	{
		[JsonPropertyName("reason")]
		public Nest.Ml.JobBlockedReason Reason
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("task_id")]
		public Nest.TaskId? TaskId
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class JobStatistics
	{
		[JsonPropertyName("avg")]
		public double Avg
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("max")]
		public double Max
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("min")]
		public double Min
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("total")]
		public double Total
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ModelPlotConfig
	{
		[JsonPropertyName("annotations_enabled")]
		public bool? AnnotationsEnabled
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("enabled")]
		public bool? Enabled
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("terms")]
		public Nest.Field? Terms
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class PerPartitionCategorization
	{
		[JsonPropertyName("enabled")]
		public bool? Enabled
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("stop_on_warn")]
		public bool? StopOnWarn
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class RuleCondition
	{
		[JsonPropertyName("applies_to")]
		public Nest.Ml.AppliesTo AppliesTo
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("operator")]
		public Nest.Ml.ConditionOperator Operator
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("value")]
		public double Value
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}
}