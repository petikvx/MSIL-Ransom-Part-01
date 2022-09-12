using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Schema;

namespace ns17;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
internal class Class172
{
	[CompilerGenerated]
	private sealed class Class173
	{
		public string string_0;

		internal bool method_0(JsonSchema jsonSchema_0)
		{
			return string.Equals(jsonSchema_0.Id, string_0, StringComparison.Ordinal);
		}

		internal bool method_1(JsonSchema jsonSchema_0)
		{
			return string.Equals(jsonSchema_0.Location, string_0, StringComparison.Ordinal);
		}
	}

	[CompilerGenerated]
	private IList<JsonSchema> ilist_0;

	public IList<JsonSchema> LoadedSchemas
	{
		[CompilerGenerated]
		get
		{
			return ilist_0;
		}
		[CompilerGenerated]
		protected set
		{
			ilist_0 = value;
		}
	}

	public Class172()
	{
		LoadedSchemas = new List<JsonSchema>();
	}

	public virtual JsonSchema vmethod_0(string string_0)
	{
		JsonSchema jsonSchema = LoadedSchemas.SingleOrDefault((JsonSchema jsonSchema_0) => string.Equals(jsonSchema_0.Id, string_0, StringComparison.Ordinal));
		if (jsonSchema == null)
		{
			jsonSchema = LoadedSchemas.SingleOrDefault((JsonSchema jsonSchema_0) => string.Equals(jsonSchema_0.Location, string_0, StringComparison.Ordinal));
		}
		return jsonSchema;
	}
}
