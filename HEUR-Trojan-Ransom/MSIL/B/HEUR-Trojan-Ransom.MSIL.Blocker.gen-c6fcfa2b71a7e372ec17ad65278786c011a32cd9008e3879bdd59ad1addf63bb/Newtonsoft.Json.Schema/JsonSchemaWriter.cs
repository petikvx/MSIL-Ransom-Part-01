using System;
using ns13;
using ns17;
using ns9;

namespace Newtonsoft.Json.Schema;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
internal class JsonSchemaWriter
{
	internal readonly Class37 class37_0;

	internal readonly Class172 class172_0;

	public JsonSchemaWriter(Class37 writer, Class172 resolver)
	{
		Class112.smethod_0(writer, "writer");
		class37_0 = writer;
		class172_0 = resolver;
	}
}
