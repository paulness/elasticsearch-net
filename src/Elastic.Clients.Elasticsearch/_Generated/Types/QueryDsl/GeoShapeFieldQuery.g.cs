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
namespace Elastic.Clients.Elasticsearch.QueryDsl
{
	public sealed partial class GeoShapeFieldQuery : Query
	{
		[JsonInclude]
		[JsonPropertyName("indexed_shape")]
		public Elastic.Clients.Elasticsearch.QueryDsl.FieldLookup? IndexedShape { get; set; }

		[JsonInclude]
		[JsonPropertyName("relation")]
		public Elastic.Clients.Elasticsearch.GeoShapeRelation? Relation { get; set; }

		[JsonInclude]
		[JsonPropertyName("shape")]
		public object? Shape { get; set; }
	}

	public sealed partial class GeoShapeFieldQueryDescriptor<TDocument> : SerializableDescriptorBase<GeoShapeFieldQueryDescriptor<TDocument>>
	{
		internal GeoShapeFieldQueryDescriptor(Action<GeoShapeFieldQueryDescriptor<TDocument>> configure) => configure.Invoke(this);
		public GeoShapeFieldQueryDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.QueryDsl.FieldLookup? IndexedShapeValue { get; set; }

		private FieldLookupDescriptor<TDocument> IndexedShapeDescriptor { get; set; }

		private Action<FieldLookupDescriptor<TDocument>> IndexedShapeDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.GeoShapeRelation? RelationValue { get; set; }

		private object? ShapeValue { get; set; }

		public GeoShapeFieldQueryDescriptor<TDocument> IndexedShape(Elastic.Clients.Elasticsearch.QueryDsl.FieldLookup? indexedShape)
		{
			IndexedShapeDescriptor = null;
			IndexedShapeDescriptorAction = null;
			IndexedShapeValue = indexedShape;
			return Self;
		}

		public GeoShapeFieldQueryDescriptor<TDocument> IndexedShape(FieldLookupDescriptor<TDocument> descriptor)
		{
			IndexedShapeValue = null;
			IndexedShapeDescriptorAction = null;
			IndexedShapeDescriptor = descriptor;
			return Self;
		}

		public GeoShapeFieldQueryDescriptor<TDocument> IndexedShape(Action<FieldLookupDescriptor<TDocument>> configure)
		{
			IndexedShapeValue = null;
			IndexedShapeDescriptor = null;
			IndexedShapeDescriptorAction = configure;
			return Self;
		}

		public GeoShapeFieldQueryDescriptor<TDocument> Relation(Elastic.Clients.Elasticsearch.GeoShapeRelation? relation)
		{
			RelationValue = relation;
			return Self;
		}

		public GeoShapeFieldQueryDescriptor<TDocument> Shape(object? shape)
		{
			ShapeValue = shape;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (IndexedShapeDescriptor is not null)
			{
				writer.WritePropertyName("indexed_shape");
				JsonSerializer.Serialize(writer, IndexedShapeDescriptor, options);
			}
			else if (IndexedShapeDescriptorAction is not null)
			{
				writer.WritePropertyName("indexed_shape");
				JsonSerializer.Serialize(writer, new FieldLookupDescriptor<TDocument>(IndexedShapeDescriptorAction), options);
			}
			else if (IndexedShapeValue is not null)
			{
				writer.WritePropertyName("indexed_shape");
				JsonSerializer.Serialize(writer, IndexedShapeValue, options);
			}

			if (RelationValue is not null)
			{
				writer.WritePropertyName("relation");
				JsonSerializer.Serialize(writer, RelationValue, options);
			}

			if (ShapeValue is not null)
			{
				writer.WritePropertyName("shape");
				JsonSerializer.Serialize(writer, ShapeValue, options);
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class GeoShapeFieldQueryDescriptor : SerializableDescriptorBase<GeoShapeFieldQueryDescriptor>
	{
		internal GeoShapeFieldQueryDescriptor(Action<GeoShapeFieldQueryDescriptor> configure) => configure.Invoke(this);
		public GeoShapeFieldQueryDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.QueryDsl.FieldLookup? IndexedShapeValue { get; set; }

		private FieldLookupDescriptor IndexedShapeDescriptor { get; set; }

		private Action<FieldLookupDescriptor> IndexedShapeDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.GeoShapeRelation? RelationValue { get; set; }

		private object? ShapeValue { get; set; }

		public GeoShapeFieldQueryDescriptor IndexedShape(Elastic.Clients.Elasticsearch.QueryDsl.FieldLookup? indexedShape)
		{
			IndexedShapeDescriptor = null;
			IndexedShapeDescriptorAction = null;
			IndexedShapeValue = indexedShape;
			return Self;
		}

		public GeoShapeFieldQueryDescriptor IndexedShape(FieldLookupDescriptor descriptor)
		{
			IndexedShapeValue = null;
			IndexedShapeDescriptorAction = null;
			IndexedShapeDescriptor = descriptor;
			return Self;
		}

		public GeoShapeFieldQueryDescriptor IndexedShape(Action<FieldLookupDescriptor> configure)
		{
			IndexedShapeValue = null;
			IndexedShapeDescriptor = null;
			IndexedShapeDescriptorAction = configure;
			return Self;
		}

		public GeoShapeFieldQueryDescriptor Relation(Elastic.Clients.Elasticsearch.GeoShapeRelation? relation)
		{
			RelationValue = relation;
			return Self;
		}

		public GeoShapeFieldQueryDescriptor Shape(object? shape)
		{
			ShapeValue = shape;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (IndexedShapeDescriptor is not null)
			{
				writer.WritePropertyName("indexed_shape");
				JsonSerializer.Serialize(writer, IndexedShapeDescriptor, options);
			}
			else if (IndexedShapeDescriptorAction is not null)
			{
				writer.WritePropertyName("indexed_shape");
				JsonSerializer.Serialize(writer, new FieldLookupDescriptor(IndexedShapeDescriptorAction), options);
			}
			else if (IndexedShapeValue is not null)
			{
				writer.WritePropertyName("indexed_shape");
				JsonSerializer.Serialize(writer, IndexedShapeValue, options);
			}

			if (RelationValue is not null)
			{
				writer.WritePropertyName("relation");
				JsonSerializer.Serialize(writer, RelationValue, options);
			}

			if (ShapeValue is not null)
			{
				writer.WritePropertyName("shape");
				JsonSerializer.Serialize(writer, ShapeValue, options);
			}

			writer.WriteEndObject();
		}
	}
}