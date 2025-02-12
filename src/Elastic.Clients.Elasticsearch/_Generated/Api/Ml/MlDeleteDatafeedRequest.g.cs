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
namespace Elastic.Clients.Elasticsearch.Ml
{
	public sealed class MlDeleteDatafeedRequestParameters : RequestParameters<MlDeleteDatafeedRequestParameters>
	{
		[JsonIgnore]
		public bool? Force { get => Q<bool?>("force"); set => Q("force", value); }
	}

	public sealed partial class MlDeleteDatafeedRequest : PlainRequestBase<MlDeleteDatafeedRequestParameters>
	{
		public MlDeleteDatafeedRequest(Elastic.Clients.Elasticsearch.Id datafeed_id) : base(r => r.Required("datafeed_id", datafeed_id))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.MachineLearningDeleteDatafeed;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		[JsonIgnore]
		public bool? Force { get => Q<bool?>("force"); set => Q("force", value); }
	}

	public sealed partial class MlDeleteDatafeedRequestDescriptor : RequestDescriptorBase<MlDeleteDatafeedRequestDescriptor, MlDeleteDatafeedRequestParameters>
	{
		internal MlDeleteDatafeedRequestDescriptor(Action<MlDeleteDatafeedRequestDescriptor> configure) => configure.Invoke(this);
		public MlDeleteDatafeedRequestDescriptor(Elastic.Clients.Elasticsearch.Id datafeed_id) : base(r => r.Required("datafeed_id", datafeed_id))
		{
		}

		internal MlDeleteDatafeedRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.MachineLearningDeleteDatafeed;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		public MlDeleteDatafeedRequestDescriptor Force(bool? force = true) => Qs("force", force);
		public MlDeleteDatafeedRequestDescriptor DatafeedId(Elastic.Clients.Elasticsearch.Id datafeed_id)
		{
			RouteValues.Required("datafeed_id", datafeed_id);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}
}