using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;
using ns10;
using ns15;
using ns2;

namespace Newtonsoft.Json.Schema;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
public class JsonSchema
{
	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private string string_1;

	[CompilerGenerated]
	private bool? nullable_0;

	[CompilerGenerated]
	private bool? nullable_1;

	[CompilerGenerated]
	private bool? nullable_2;

	[CompilerGenerated]
	private bool? nullable_3;

	[CompilerGenerated]
	private string string_2;

	[CompilerGenerated]
	private JsonSchemaType? nullable_4;

	[CompilerGenerated]
	private string string_3;

	[CompilerGenerated]
	private int? nullable_5;

	[CompilerGenerated]
	private int? nullable_6;

	[CompilerGenerated]
	private double? nullable_7;

	[CompilerGenerated]
	private double? nullable_8;

	[CompilerGenerated]
	private double? nullable_9;

	[CompilerGenerated]
	private bool? nullable_10;

	[CompilerGenerated]
	private bool? nullable_11;

	[CompilerGenerated]
	private int? nullable_12;

	[CompilerGenerated]
	private int? nullable_13;

	[CompilerGenerated]
	private IList<JsonSchema> ilist_0;

	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private JsonSchema jsonSchema_0;

	[CompilerGenerated]
	private bool bool_1;

	[CompilerGenerated]
	private bool bool_2;

	[CompilerGenerated]
	private IDictionary<string, JsonSchema> idictionary_0;

	[CompilerGenerated]
	private JsonSchema jsonSchema_1;

	[CompilerGenerated]
	private IDictionary<string, JsonSchema> idictionary_1;

	[CompilerGenerated]
	private bool bool_3;

	[CompilerGenerated]
	private string string_4;

	[CompilerGenerated]
	private IList<JToken> ilist_1;

	[CompilerGenerated]
	private JsonSchemaType? nullable_14;

	[CompilerGenerated]
	private JToken jtoken_0;

	[CompilerGenerated]
	private IList<JsonSchema> ilist_2;

	[CompilerGenerated]
	private string string_5;

	[CompilerGenerated]
	private string string_6;

	internal readonly string string_7 = Guid.NewGuid().ToString("N");

	[CompilerGenerated]
	private string string_8;

	[CompilerGenerated]
	private bool bool_4;

	public string Id
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		set
		{
			string_0 = value;
		}
	}

	public string Title
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
		[CompilerGenerated]
		set
		{
			string_1 = value;
		}
	}

	public bool? Required
	{
		[CompilerGenerated]
		get
		{
			return nullable_0;
		}
		[CompilerGenerated]
		set
		{
			nullable_0 = value;
		}
	}

	public bool? ReadOnly
	{
		[CompilerGenerated]
		get
		{
			return nullable_1;
		}
		[CompilerGenerated]
		set
		{
			nullable_1 = value;
		}
	}

	public bool? Hidden
	{
		[CompilerGenerated]
		get
		{
			return nullable_2;
		}
		[CompilerGenerated]
		set
		{
			nullable_2 = value;
		}
	}

	public bool? Transient
	{
		[CompilerGenerated]
		get
		{
			return nullable_3;
		}
		[CompilerGenerated]
		set
		{
			nullable_3 = value;
		}
	}

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return string_2;
		}
		[CompilerGenerated]
		set
		{
			string_2 = value;
		}
	}

	public JsonSchemaType? Type
	{
		[CompilerGenerated]
		get
		{
			return nullable_4;
		}
		[CompilerGenerated]
		set
		{
			nullable_4 = value;
		}
	}

	public string Pattern
	{
		[CompilerGenerated]
		get
		{
			return string_3;
		}
		[CompilerGenerated]
		set
		{
			string_3 = value;
		}
	}

	public int? MinimumLength
	{
		[CompilerGenerated]
		get
		{
			return nullable_5;
		}
		[CompilerGenerated]
		set
		{
			nullable_5 = value;
		}
	}

	public int? MaximumLength
	{
		[CompilerGenerated]
		get
		{
			return nullable_6;
		}
		[CompilerGenerated]
		set
		{
			nullable_6 = value;
		}
	}

	public double? DivisibleBy
	{
		[CompilerGenerated]
		get
		{
			return nullable_7;
		}
		[CompilerGenerated]
		set
		{
			nullable_7 = value;
		}
	}

	public double? Minimum
	{
		[CompilerGenerated]
		get
		{
			return nullable_8;
		}
		[CompilerGenerated]
		set
		{
			nullable_8 = value;
		}
	}

	public double? Maximum
	{
		[CompilerGenerated]
		get
		{
			return nullable_9;
		}
		[CompilerGenerated]
		set
		{
			nullable_9 = value;
		}
	}

	public bool? ExclusiveMinimum
	{
		[CompilerGenerated]
		get
		{
			return nullable_10;
		}
		[CompilerGenerated]
		set
		{
			nullable_10 = value;
		}
	}

	public bool? ExclusiveMaximum
	{
		[CompilerGenerated]
		get
		{
			return nullable_11;
		}
		[CompilerGenerated]
		set
		{
			nullable_11 = value;
		}
	}

	public int? MinimumItems
	{
		[CompilerGenerated]
		get
		{
			return nullable_12;
		}
		[CompilerGenerated]
		set
		{
			nullable_12 = value;
		}
	}

	public int? MaximumItems
	{
		[CompilerGenerated]
		get
		{
			return nullable_13;
		}
		[CompilerGenerated]
		set
		{
			nullable_13 = value;
		}
	}

	public IList<JsonSchema> Items
	{
		[CompilerGenerated]
		get
		{
			return ilist_0;
		}
		[CompilerGenerated]
		set
		{
			ilist_0 = value;
		}
	}

	public bool PositionalItemsValidation
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
		[CompilerGenerated]
		set
		{
			bool_0 = value;
		}
	}

	public JsonSchema AdditionalItems
	{
		[CompilerGenerated]
		get
		{
			return jsonSchema_0;
		}
		[CompilerGenerated]
		set
		{
			jsonSchema_0 = value;
		}
	}

	public bool AllowAdditionalItems
	{
		[CompilerGenerated]
		get
		{
			return bool_1;
		}
		[CompilerGenerated]
		set
		{
			bool_1 = value;
		}
	}

	public bool UniqueItems
	{
		[CompilerGenerated]
		get
		{
			return bool_2;
		}
		[CompilerGenerated]
		set
		{
			bool_2 = value;
		}
	}

	public IDictionary<string, JsonSchema> Properties
	{
		[CompilerGenerated]
		get
		{
			return idictionary_0;
		}
		[CompilerGenerated]
		set
		{
			idictionary_0 = value;
		}
	}

	public JsonSchema AdditionalProperties
	{
		[CompilerGenerated]
		get
		{
			return jsonSchema_1;
		}
		[CompilerGenerated]
		set
		{
			jsonSchema_1 = value;
		}
	}

	public IDictionary<string, JsonSchema> PatternProperties
	{
		[CompilerGenerated]
		get
		{
			return idictionary_1;
		}
		[CompilerGenerated]
		set
		{
			idictionary_1 = value;
		}
	}

	public bool AllowAdditionalProperties
	{
		[CompilerGenerated]
		get
		{
			return bool_3;
		}
		[CompilerGenerated]
		set
		{
			bool_3 = value;
		}
	}

	public string Requires
	{
		[CompilerGenerated]
		get
		{
			return string_4;
		}
		[CompilerGenerated]
		set
		{
			string_4 = value;
		}
	}

	public IList<JToken> Enum
	{
		[CompilerGenerated]
		get
		{
			return ilist_1;
		}
		[CompilerGenerated]
		set
		{
			ilist_1 = value;
		}
	}

	public JsonSchemaType? Disallow
	{
		[CompilerGenerated]
		get
		{
			return nullable_14;
		}
		[CompilerGenerated]
		set
		{
			nullable_14 = value;
		}
	}

	public JToken Default
	{
		[CompilerGenerated]
		get
		{
			return jtoken_0;
		}
		[CompilerGenerated]
		set
		{
			jtoken_0 = value;
		}
	}

	public IList<JsonSchema> Extends
	{
		[CompilerGenerated]
		get
		{
			return ilist_2;
		}
		[CompilerGenerated]
		set
		{
			ilist_2 = value;
		}
	}

	public string Format
	{
		[CompilerGenerated]
		get
		{
			return string_5;
		}
		[CompilerGenerated]
		set
		{
			string_5 = value;
		}
	}

	internal string Location
	{
		[CompilerGenerated]
		get
		{
			return string_6;
		}
		[CompilerGenerated]
		set
		{
			string_6 = value;
		}
	}

	internal string InternalId => string_7;

	internal string DeferredReference
	{
		[CompilerGenerated]
		get
		{
			return string_8;
		}
		[CompilerGenerated]
		set
		{
			string_8 = value;
		}
	}

	internal bool ReferencesResolved
	{
		[CompilerGenerated]
		get
		{
			return bool_4;
		}
		[CompilerGenerated]
		set
		{
			bool_4 = value;
		}
	}

	public JsonSchema()
	{
		AllowAdditionalProperties = true;
		AllowAdditionalItems = true;
	}

	string object.ToString()
	{
		StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture);
		Class4.smethod_320((Class38)new Class39(stringWriter)
		{
			Formatting = Enum7.const_1
		}, this);
		return stringWriter.ToString();
	}
}
