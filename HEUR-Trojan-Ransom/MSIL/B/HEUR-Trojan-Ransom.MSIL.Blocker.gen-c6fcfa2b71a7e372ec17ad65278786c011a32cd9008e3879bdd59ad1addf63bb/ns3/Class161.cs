using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using ns13;
using ns14;
using ns15;
using ns7;

namespace ns3;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
internal static class Class161
{
	[CompilerGenerated]
	private sealed class Class162
	{
		public bool bool_0;

		internal void method_0(object sender, EventArgs1 e)
		{
			bool_0 = false;
		}
	}

	[CompilerGenerated]
	private sealed class Class163
	{
		public IList<string> ilist_0;

		internal void method_0(object sender, EventArgs1 e)
		{
			ilist_0.Add(e.Message);
		}
	}

	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	public static bool smethod_0(this JToken jtoken_0, JsonSchema jsonSchema_0)
	{
		bool bool_0 = true;
		jtoken_0.smethod_3(jsonSchema_0, delegate
		{
			bool_0 = false;
		});
		return bool_0;
	}

	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	public static bool smethod_1(this JToken jtoken_0, JsonSchema jsonSchema_0, out IList<string> ilist_0)
	{
		IList<string> ilist_ = new List<string>();
		jtoken_0.smethod_3(jsonSchema_0, delegate(object sender, EventArgs1 e)
		{
			ilist_.Add(e.Message);
		});
		ilist_0 = ilist_;
		return ilist_0.Count == 0;
	}

	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	public static void smethod_2(this JToken jtoken_0, JsonSchema jsonSchema_0)
	{
		jtoken_0.smethod_3(jsonSchema_0, null);
	}

	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	public static void smethod_3(this JToken jtoken_0, JsonSchema jsonSchema_0, Delegate8 delegate8_0)
	{
		Class112.smethod_0(jtoken_0, "source");
		Class112.smethod_0(jsonSchema_0, "schema");
		using JsonValidatingReader jsonValidatingReader = new JsonValidatingReader(new Class31(jtoken_0));
		jsonValidatingReader.Schema = jsonSchema_0;
		if (delegate8_0 != null)
		{
			jsonValidatingReader.ValidationEventHandler += delegate8_0;
		}
		while (jsonValidatingReader.vmethod_0())
		{
		}
	}
}
