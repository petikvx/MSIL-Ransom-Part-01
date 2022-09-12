using System;
using Newtonsoft.Json.Schema;
using ns13;

namespace ns15;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
internal class EventArgs1 : EventArgs
{
	private readonly JsonSchemaException jsonSchemaException_0;

	public JsonSchemaException Exception => jsonSchemaException_0;

	public string Path => jsonSchemaException_0.Path;

	public string Message => jsonSchemaException_0.Message;

	internal EventArgs1(JsonSchemaException jsonSchemaException_1)
	{
		Class112.smethod_0(jsonSchemaException_1, "ex");
		jsonSchemaException_0 = jsonSchemaException_1;
	}
}
