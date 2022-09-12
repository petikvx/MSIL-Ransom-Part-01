using System;
using ns2;
using ns4;
using ns5;

namespace Newtonsoft.Json.Schema;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
internal class JsonSchemaWriter
{
	internal readonly Class38 class38_0;

	internal readonly Class172 class172_0;

	public JsonSchemaWriter(Class38 writer, Class172 resolver)
	{
		Class113.smethod_0(writer, "writer");
		class38_0 = writer;
		class172_0 = resolver;
	}
}
