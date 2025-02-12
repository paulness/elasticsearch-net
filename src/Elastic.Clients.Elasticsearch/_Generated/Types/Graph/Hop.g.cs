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
namespace Elastic.Clients.Elasticsearch.Graph
{
	public sealed partial class Hop
	{
		[JsonInclude]
		[JsonPropertyName("connections")]
		public Elastic.Clients.Elasticsearch.Graph.Hop? Connections { get; set; }

		[JsonInclude]
		[JsonPropertyName("query")]
		public Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer Query { get; set; }

		[JsonInclude]
		[JsonPropertyName("vertices")]
		public IEnumerable<Elastic.Clients.Elasticsearch.Graph.VertexDefinition> Vertices { get; set; }
	}

	public sealed partial class HopDescriptor<TDocument> : SerializableDescriptorBase<HopDescriptor<TDocument>>
	{
		internal HopDescriptor(Action<HopDescriptor<TDocument>> configure) => configure.Invoke(this);
		public HopDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.Graph.Hop? ConnectionsValue { get; set; }

		private HopDescriptor<TDocument> ConnectionsDescriptor { get; set; }

		private Action<HopDescriptor<TDocument>> ConnectionsDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer QueryValue { get; set; }

		private QueryDsl.QueryContainerDescriptor<TDocument> QueryDescriptor { get; set; }

		private Action<QueryDsl.QueryContainerDescriptor<TDocument>> QueryDescriptorAction { get; set; }

		private IEnumerable<Elastic.Clients.Elasticsearch.Graph.VertexDefinition> VerticesValue { get; set; }

		private VertexDefinitionDescriptor<TDocument> VerticesDescriptor { get; set; }

		private Action<VertexDefinitionDescriptor<TDocument>> VerticesDescriptorAction { get; set; }

		private Action<VertexDefinitionDescriptor<TDocument>>[] VerticesDescriptorActions { get; set; }

		public HopDescriptor<TDocument> Connections(Elastic.Clients.Elasticsearch.Graph.Hop? connections)
		{
			ConnectionsDescriptor = null;
			ConnectionsDescriptorAction = null;
			ConnectionsValue = connections;
			return Self;
		}

		public HopDescriptor<TDocument> Connections(HopDescriptor<TDocument> descriptor)
		{
			ConnectionsValue = null;
			ConnectionsDescriptorAction = null;
			ConnectionsDescriptor = descriptor;
			return Self;
		}

		public HopDescriptor<TDocument> Connections(Action<HopDescriptor<TDocument>> configure)
		{
			ConnectionsValue = null;
			ConnectionsDescriptor = null;
			ConnectionsDescriptorAction = configure;
			return Self;
		}

		public HopDescriptor<TDocument> Query(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer query)
		{
			QueryDescriptor = null;
			QueryDescriptorAction = null;
			QueryValue = query;
			return Self;
		}

		public HopDescriptor<TDocument> Query(QueryDsl.QueryContainerDescriptor<TDocument> descriptor)
		{
			QueryValue = null;
			QueryDescriptorAction = null;
			QueryDescriptor = descriptor;
			return Self;
		}

		public HopDescriptor<TDocument> Query(Action<QueryDsl.QueryContainerDescriptor<TDocument>> configure)
		{
			QueryValue = null;
			QueryDescriptor = null;
			QueryDescriptorAction = configure;
			return Self;
		}

		public HopDescriptor<TDocument> Vertices(IEnumerable<Elastic.Clients.Elasticsearch.Graph.VertexDefinition> vertices)
		{
			VerticesDescriptor = null;
			VerticesDescriptorAction = null;
			VerticesDescriptorActions = null;
			VerticesValue = vertices;
			return Self;
		}

		public HopDescriptor<TDocument> Vertices(VertexDefinitionDescriptor<TDocument> descriptor)
		{
			VerticesValue = null;
			VerticesDescriptorAction = null;
			VerticesDescriptorActions = null;
			VerticesDescriptor = descriptor;
			return Self;
		}

		public HopDescriptor<TDocument> Vertices(Action<VertexDefinitionDescriptor<TDocument>> configure)
		{
			VerticesValue = null;
			VerticesDescriptor = null;
			VerticesDescriptorActions = null;
			VerticesDescriptorAction = configure;
			return Self;
		}

		public HopDescriptor<TDocument> Vertices(params Action<VertexDefinitionDescriptor<TDocument>>[] configure)
		{
			VerticesValue = null;
			VerticesDescriptor = null;
			VerticesDescriptorAction = null;
			VerticesDescriptorActions = configure;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (ConnectionsDescriptor is not null)
			{
				writer.WritePropertyName("connections");
				JsonSerializer.Serialize(writer, ConnectionsDescriptor, options);
			}
			else if (ConnectionsDescriptorAction is not null)
			{
				writer.WritePropertyName("connections");
				JsonSerializer.Serialize(writer, new HopDescriptor<TDocument>(ConnectionsDescriptorAction), options);
			}
			else if (ConnectionsValue is not null)
			{
				writer.WritePropertyName("connections");
				JsonSerializer.Serialize(writer, ConnectionsValue, options);
			}

			if (QueryDescriptor is not null)
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, QueryDescriptor, options);
			}
			else if (QueryDescriptorAction is not null)
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, new QueryDsl.QueryContainerDescriptor<TDocument>(QueryDescriptorAction), options);
			}
			else
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, QueryValue, options);
			}

			if (VerticesDescriptor is not null)
			{
				writer.WritePropertyName("vertices");
				writer.WriteStartArray();
				JsonSerializer.Serialize(writer, VerticesDescriptor, options);
				writer.WriteEndArray();
			}
			else if (VerticesDescriptorAction is not null)
			{
				writer.WritePropertyName("vertices");
				writer.WriteStartArray();
				JsonSerializer.Serialize(writer, new VertexDefinitionDescriptor<TDocument>(VerticesDescriptorAction), options);
				writer.WriteEndArray();
			}
			else if (VerticesDescriptorActions is not null)
			{
				writer.WritePropertyName("vertices");
				writer.WriteStartArray();
				foreach (var action in VerticesDescriptorActions)
				{
					JsonSerializer.Serialize(writer, new VertexDefinitionDescriptor<TDocument>(action), options);
				}

				writer.WriteEndArray();
			}
			else
			{
				writer.WritePropertyName("vertices");
				JsonSerializer.Serialize(writer, VerticesValue, options);
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class HopDescriptor : SerializableDescriptorBase<HopDescriptor>
	{
		internal HopDescriptor(Action<HopDescriptor> configure) => configure.Invoke(this);
		public HopDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.Graph.Hop? ConnectionsValue { get; set; }

		private HopDescriptor ConnectionsDescriptor { get; set; }

		private Action<HopDescriptor> ConnectionsDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer QueryValue { get; set; }

		private QueryDsl.QueryContainerDescriptor QueryDescriptor { get; set; }

		private Action<QueryDsl.QueryContainerDescriptor> QueryDescriptorAction { get; set; }

		private IEnumerable<Elastic.Clients.Elasticsearch.Graph.VertexDefinition> VerticesValue { get; set; }

		private VertexDefinitionDescriptor VerticesDescriptor { get; set; }

		private Action<VertexDefinitionDescriptor> VerticesDescriptorAction { get; set; }

		private Action<VertexDefinitionDescriptor>[] VerticesDescriptorActions { get; set; }

		public HopDescriptor Connections(Elastic.Clients.Elasticsearch.Graph.Hop? connections)
		{
			ConnectionsDescriptor = null;
			ConnectionsDescriptorAction = null;
			ConnectionsValue = connections;
			return Self;
		}

		public HopDescriptor Connections(HopDescriptor descriptor)
		{
			ConnectionsValue = null;
			ConnectionsDescriptorAction = null;
			ConnectionsDescriptor = descriptor;
			return Self;
		}

		public HopDescriptor Connections(Action<HopDescriptor> configure)
		{
			ConnectionsValue = null;
			ConnectionsDescriptor = null;
			ConnectionsDescriptorAction = configure;
			return Self;
		}

		public HopDescriptor Query(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer query)
		{
			QueryDescriptor = null;
			QueryDescriptorAction = null;
			QueryValue = query;
			return Self;
		}

		public HopDescriptor Query(QueryDsl.QueryContainerDescriptor descriptor)
		{
			QueryValue = null;
			QueryDescriptorAction = null;
			QueryDescriptor = descriptor;
			return Self;
		}

		public HopDescriptor Query(Action<QueryDsl.QueryContainerDescriptor> configure)
		{
			QueryValue = null;
			QueryDescriptor = null;
			QueryDescriptorAction = configure;
			return Self;
		}

		public HopDescriptor Vertices(IEnumerable<Elastic.Clients.Elasticsearch.Graph.VertexDefinition> vertices)
		{
			VerticesDescriptor = null;
			VerticesDescriptorAction = null;
			VerticesDescriptorActions = null;
			VerticesValue = vertices;
			return Self;
		}

		public HopDescriptor Vertices(VertexDefinitionDescriptor descriptor)
		{
			VerticesValue = null;
			VerticesDescriptorAction = null;
			VerticesDescriptorActions = null;
			VerticesDescriptor = descriptor;
			return Self;
		}

		public HopDescriptor Vertices(Action<VertexDefinitionDescriptor> configure)
		{
			VerticesValue = null;
			VerticesDescriptor = null;
			VerticesDescriptorActions = null;
			VerticesDescriptorAction = configure;
			return Self;
		}

		public HopDescriptor Vertices(params Action<VertexDefinitionDescriptor>[] configure)
		{
			VerticesValue = null;
			VerticesDescriptor = null;
			VerticesDescriptorAction = null;
			VerticesDescriptorActions = configure;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (ConnectionsDescriptor is not null)
			{
				writer.WritePropertyName("connections");
				JsonSerializer.Serialize(writer, ConnectionsDescriptor, options);
			}
			else if (ConnectionsDescriptorAction is not null)
			{
				writer.WritePropertyName("connections");
				JsonSerializer.Serialize(writer, new HopDescriptor(ConnectionsDescriptorAction), options);
			}
			else if (ConnectionsValue is not null)
			{
				writer.WritePropertyName("connections");
				JsonSerializer.Serialize(writer, ConnectionsValue, options);
			}

			if (QueryDescriptor is not null)
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, QueryDescriptor, options);
			}
			else if (QueryDescriptorAction is not null)
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, new QueryDsl.QueryContainerDescriptor(QueryDescriptorAction), options);
			}
			else
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, QueryValue, options);
			}

			if (VerticesDescriptor is not null)
			{
				writer.WritePropertyName("vertices");
				writer.WriteStartArray();
				JsonSerializer.Serialize(writer, VerticesDescriptor, options);
				writer.WriteEndArray();
			}
			else if (VerticesDescriptorAction is not null)
			{
				writer.WritePropertyName("vertices");
				writer.WriteStartArray();
				JsonSerializer.Serialize(writer, new VertexDefinitionDescriptor(VerticesDescriptorAction), options);
				writer.WriteEndArray();
			}
			else if (VerticesDescriptorActions is not null)
			{
				writer.WritePropertyName("vertices");
				writer.WriteStartArray();
				foreach (var action in VerticesDescriptorActions)
				{
					JsonSerializer.Serialize(writer, new VertexDefinitionDescriptor(action), options);
				}

				writer.WriteEndArray();
			}
			else
			{
				writer.WritePropertyName("vertices");
				JsonSerializer.Serialize(writer, VerticesValue, options);
			}

			writer.WriteEndObject();
		}
	}
}