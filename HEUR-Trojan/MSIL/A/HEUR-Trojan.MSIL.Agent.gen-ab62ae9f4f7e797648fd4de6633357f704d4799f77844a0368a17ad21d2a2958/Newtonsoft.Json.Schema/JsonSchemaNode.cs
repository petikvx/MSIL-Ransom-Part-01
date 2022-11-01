using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Newtonsoft.Json.Schema;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
internal class JsonSchemaNode
{
	public string Id { get; }

	public ReadOnlyCollection<JsonSchema> Schemas { get; }

	public Dictionary<string, JsonSchemaNode> Properties { get; }

	public Dictionary<string, JsonSchemaNode> PatternProperties { get; }

	public List<JsonSchemaNode> Items { get; }

	public JsonSchemaNode AdditionalProperties { get; set; }

	public JsonSchemaNode AdditionalItems { get; set; }

	public JsonSchemaNode(JsonSchema schema)
	{
		Schemas = new ReadOnlyCollection<JsonSchema>(new JsonSchema[1] { schema });
		Properties = new Dictionary<string, JsonSchemaNode>();
		PatternProperties = new Dictionary<string, JsonSchemaNode>();
		Items = new List<JsonSchemaNode>();
		Id = GetId(Schemas);
	}

	private JsonSchemaNode(JsonSchemaNode source, JsonSchema schema)
	{
		Schemas = new ReadOnlyCollection<JsonSchema>(source.Schemas.Union(new JsonSchema[1] { schema }).ToList());
		Properties = new Dictionary<string, JsonSchemaNode>(source.Properties);
		PatternProperties = new Dictionary<string, JsonSchemaNode>(source.PatternProperties);
		Items = new List<JsonSchemaNode>(source.Items);
		AdditionalProperties = source.AdditionalProperties;
		AdditionalItems = source.AdditionalItems;
		Id = GetId(Schemas);
	}

	public JsonSchemaNode Combine(JsonSchema schema)
	{
		return new JsonSchemaNode(this, schema);
	}

	public static string GetId(IEnumerable<JsonSchema> schemata)
	{
		return string.Join("-", schemata.Select((JsonSchema s) => s.InternalId).OrderBy<string, string>((string id) => id, StringComparer.Ordinal));
	}
}
