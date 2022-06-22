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

using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Snapshot
{
	public sealed class SnapshotStatusRequestParameters : RequestParameters<SnapshotStatusRequestParameters>
	{
		[JsonIgnore]
		public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }
	}

	public partial class SnapshotStatusRequest : PlainRequestBase<SnapshotStatusRequestParameters>
	{
		public SnapshotStatusRequest()
		{
		}

		public SnapshotStatusRequest(Elastic.Clients.Elasticsearch.Name? repository) : base(r => r.Optional("repository", repository))
		{
		}

		public SnapshotStatusRequest(Elastic.Clients.Elasticsearch.Name? repository, Elastic.Clients.Elasticsearch.Names? snapshot) : base(r => r.Optional("repository", repository).Optional("snapshot", snapshot))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotStatus;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		[JsonIgnore]
		public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }
	}

	public sealed partial class SnapshotStatusRequestDescriptor : RequestDescriptorBase<SnapshotStatusRequestDescriptor, SnapshotStatusRequestParameters>
	{
		internal SnapshotStatusRequestDescriptor(Action<SnapshotStatusRequestDescriptor> configure) => configure.Invoke(this);
		public SnapshotStatusRequestDescriptor()
		{
		}

		public SnapshotStatusRequestDescriptor(Elastic.Clients.Elasticsearch.Name? repository, Elastic.Clients.Elasticsearch.Names? snapshot) : base(r => r.Optional("repository", repository).Optional("snapshot", snapshot))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotStatus;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		public SnapshotStatusRequestDescriptor IgnoreUnavailable(bool? ignoreUnavailable = true) => Qs("ignore_unavailable", ignoreUnavailable);
		public SnapshotStatusRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);
		public SnapshotStatusRequestDescriptor Repository(Elastic.Clients.Elasticsearch.Name? repository)
		{
			RouteValues.Optional("repository", repository);
			return Self;
		}

		public SnapshotStatusRequestDescriptor Snapshot(Elastic.Clients.Elasticsearch.Names? snapshot)
		{
			RouteValues.Optional("snapshot", snapshot);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}
}