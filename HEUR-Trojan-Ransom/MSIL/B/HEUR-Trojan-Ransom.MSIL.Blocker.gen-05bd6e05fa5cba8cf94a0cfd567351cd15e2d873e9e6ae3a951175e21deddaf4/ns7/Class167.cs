using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Serialization;
using ns17;
using ns2;
using ns4;
using ns5;

namespace ns7;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
internal class Class167
{
	internal class Class168
	{
		[CompilerGenerated]
		private readonly Type type_0;

		[CompilerGenerated]
		private readonly JsonSchema jsonSchema_0;

		public Type Type
		{
			[CompilerGenerated]
			get
			{
				return type_0;
			}
		}

		public JsonSchema Schema
		{
			[CompilerGenerated]
			get
			{
				return jsonSchema_0;
			}
		}

		public Class168(Type type_1, JsonSchema jsonSchema_1)
		{
			Class113.smethod_0(type_1, "type");
			Class113.smethod_0(jsonSchema_1, "schema");
			type_0 = type_1;
			jsonSchema_0 = jsonSchema_1;
		}
	}

	[CompilerGenerated]
	internal sealed class Class169
	{
		public Type type_0;

		internal bool method_0(Class168 class168_0)
		{
			return class168_0.Type == type_0;
		}
	}

	[CompilerGenerated]
	private Enum27 enum27_0;

	private Interface4 interface4_0;

	internal Class172 class172_0;

	internal readonly IList<Class168> ilist_0 = new List<Class168>();

	internal JsonSchema jsonSchema_0;

	public Enum27 UndefinedSchemaIdHandling
	{
		[CompilerGenerated]
		get
		{
			return enum27_0;
		}
		[CompilerGenerated]
		set
		{
			enum27_0 = value;
		}
	}

	public Interface4 ContractResolver
	{
		get
		{
			if (interface4_0 == null)
			{
				return DefaultContractResolver.interface4_0;
			}
			return interface4_0;
		}
		set
		{
			interface4_0 = value;
		}
	}

	internal JsonSchema CurrentSchema => jsonSchema_0;
}
