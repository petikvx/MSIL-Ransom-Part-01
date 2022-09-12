using System;
using System.Collections.Generic;
using Newtonsoft.Json.Schema;
using ns19;
using ns9;

namespace ns11;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
internal class Class170
{
	internal Class171 class171_0 = new Class171();

	internal Dictionary<JsonSchemaNode, JsonSchemaModel> dictionary_0 = new Dictionary<JsonSchemaNode, JsonSchemaModel>();

	internal JsonSchemaNode jsonSchemaNode_0;

	internal JsonSchemaModel method_0(JsonSchemaNode jsonSchemaNode_1)
	{
		if (dictionary_0.TryGetValue(jsonSchemaNode_1, out var value))
		{
			return value;
		}
		value = Class7.smethod_350((IList<JsonSchema>)jsonSchemaNode_1.Schemas);
		dictionary_0[jsonSchemaNode_1] = value;
		foreach (KeyValuePair<string, JsonSchemaNode> property in jsonSchemaNode_1.Properties)
		{
			if (value.Properties == null)
			{
				value.Properties = new Dictionary<string, JsonSchemaModel>();
			}
			value.Properties[property.Key] = method_0(property.Value);
		}
		foreach (KeyValuePair<string, JsonSchemaNode> patternProperty in jsonSchemaNode_1.PatternProperties)
		{
			if (value.PatternProperties == null)
			{
				value.PatternProperties = new Dictionary<string, JsonSchemaModel>();
			}
			value.PatternProperties[patternProperty.Key] = method_0(patternProperty.Value);
		}
		foreach (JsonSchemaNode item in jsonSchemaNode_1.Items)
		{
			if (value.Items == null)
			{
				value.Items = new List<JsonSchemaModel>();
			}
			value.Items.Add(method_0(item));
		}
		if (jsonSchemaNode_1.AdditionalProperties != null)
		{
			value.AdditionalProperties = method_0(jsonSchemaNode_1.AdditionalProperties);
		}
		if (jsonSchemaNode_1.AdditionalItems != null)
		{
			value.AdditionalItems = method_0(jsonSchemaNode_1.AdditionalItems);
		}
		return value;
	}
}
