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

using Elastic.Transport.Products.Elasticsearch;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Ilm
{
	public sealed partial class IlmMigrateToDataTiersResponse : ElasticsearchResponseBase
	{
		[JsonInclude]
		[JsonPropertyName("dry_run")]
		public bool DryRun { get; init; }

		[JsonInclude]
		[JsonPropertyName("migrated_component_templates")]
		public IReadOnlyCollection<string> MigratedComponentTemplates { get; init; }

		[JsonInclude]
		[JsonPropertyName("migrated_composable_templates")]
		public IReadOnlyCollection<string> MigratedComposableTemplates { get; init; }

		[JsonInclude]
		[JsonPropertyName("migrated_ilm_policies")]
		public IReadOnlyCollection<string> MigratedIlmPolicies { get; init; }

		[JsonInclude]
		[JsonPropertyName("migrated_indices")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.IndexName> MigratedIndices { get; init; }

		[JsonInclude]
		[JsonPropertyName("migrated_legacy_templates")]
		public IReadOnlyCollection<string> MigratedLegacyTemplates { get; init; }

		[JsonInclude]
		[JsonPropertyName("removed_legacy_template")]
		public string RemovedLegacyTemplate { get; init; }
	}
}