using System;
using System.Collections.ObjectModel;
using Newtonsoft.Json.Schema;

namespace ns16;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
internal class Class171 : KeyedCollection<string, JsonSchemaNode>
{
	string KeyedCollection<string, JsonSchemaNode>.GetKeyForItem(JsonSchemaNode item)
	{
		return item.Id;
	}
}
