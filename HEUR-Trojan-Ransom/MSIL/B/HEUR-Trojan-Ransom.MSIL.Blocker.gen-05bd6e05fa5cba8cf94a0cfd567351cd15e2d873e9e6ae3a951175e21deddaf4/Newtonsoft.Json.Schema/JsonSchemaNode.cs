using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using ns10;

namespace Newtonsoft.Json.Schema;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
internal class JsonSchemaNode
{
	[CompilerGenerated]
	private readonly string string_0;

	[CompilerGenerated]
	private readonly ReadOnlyCollection<JsonSchema> readOnlyCollection_0;

	[CompilerGenerated]
	private readonly Dictionary<string, JsonSchemaNode> dictionary_0;

	[CompilerGenerated]
	private readonly Dictionary<string, JsonSchemaNode> dictionary_1;

	[CompilerGenerated]
	private readonly List<JsonSchemaNode> list_0;

	[CompilerGenerated]
	private JsonSchemaNode jsonSchemaNode_0;

	[CompilerGenerated]
	private JsonSchemaNode jsonSchemaNode_1;

	public string Id
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
	}

	public ReadOnlyCollection<JsonSchema> Schemas
	{
		[CompilerGenerated]
		get
		{
			return readOnlyCollection_0;
		}
	}

	public Dictionary<string, JsonSchemaNode> Properties
	{
		[CompilerGenerated]
		get
		{
			return dictionary_0;
		}
	}

	public Dictionary<string, JsonSchemaNode> PatternProperties
	{
		[CompilerGenerated]
		get
		{
			return dictionary_1;
		}
	}

	public List<JsonSchemaNode> Items
	{
		[CompilerGenerated]
		get
		{
			return list_0;
		}
	}

	public JsonSchemaNode AdditionalProperties
	{
		[CompilerGenerated]
		get
		{
			return jsonSchemaNode_0;
		}
		[CompilerGenerated]
		set
		{
			jsonSchemaNode_0 = value;
		}
	}

	public JsonSchemaNode AdditionalItems
	{
		[CompilerGenerated]
		get
		{
			return jsonSchemaNode_1;
		}
		[CompilerGenerated]
		set
		{
			jsonSchemaNode_1 = value;
		}
	}

	public JsonSchemaNode(JsonSchema schema)
	{
		readOnlyCollection_0 = new ReadOnlyCollection<JsonSchema>(new JsonSchema[1] { schema });
		dictionary_0 = new Dictionary<string, JsonSchemaNode>();
		dictionary_1 = new Dictionary<string, JsonSchemaNode>();
		list_0 = new List<JsonSchemaNode>();
		string_0 = Class4.smethod_76((IEnumerable<JsonSchema>)Schemas);
	}

	internal JsonSchemaNode(JsonSchemaNode source, JsonSchema schema)
	{
		readOnlyCollection_0 = new ReadOnlyCollection<JsonSchema>(source.Schemas.Union(new JsonSchema[1] { schema }).ToList());
		dictionary_0 = new Dictionary<string, JsonSchemaNode>(source.Properties);
		dictionary_1 = new Dictionary<string, JsonSchemaNode>(source.PatternProperties);
		list_0 = new List<JsonSchemaNode>(source.Items);
		AdditionalProperties = source.AdditionalProperties;
		AdditionalItems = source.AdditionalItems;
		string_0 = Class4.smethod_76((IEnumerable<JsonSchema>)Schemas);
	}
}
