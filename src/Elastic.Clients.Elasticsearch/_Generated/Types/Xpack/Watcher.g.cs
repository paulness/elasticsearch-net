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
	public sealed partial class Watcher
	{
		[JsonInclude]
		[JsonPropertyName("available")]
		public bool Available { get; init; }

		[JsonInclude]
		[JsonPropertyName("count")]
		public Elastic.Clients.Elasticsearch.Xpack.Counter Count { get; init; }

		[JsonInclude]
		[JsonPropertyName("enabled")]
		public bool Enabled { get; init; }

		[JsonInclude]
		[JsonPropertyName("execution")]
		public Elastic.Clients.Elasticsearch.Xpack.WatcherActions Execution { get; init; }

		[JsonInclude]
		[JsonPropertyName("watch")]
		public Elastic.Clients.Elasticsearch.Xpack.WatcherWatch Watch { get; init; }
	}
}