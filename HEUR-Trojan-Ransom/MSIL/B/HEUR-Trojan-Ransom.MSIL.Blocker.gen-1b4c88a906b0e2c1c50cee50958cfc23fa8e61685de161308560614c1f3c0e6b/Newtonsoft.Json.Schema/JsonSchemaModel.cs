using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;

namespace Newtonsoft.Json.Schema;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
internal class JsonSchemaModel
{
	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private JsonSchemaType jsonSchemaType_0;

	[CompilerGenerated]
	private int? nullable_0;

	[CompilerGenerated]
	private int? nullable_1;

	[CompilerGenerated]
	private double? nullable_2;

	[CompilerGenerated]
	private double? nullable_3;

	[CompilerGenerated]
	private double? nullable_4;

	[CompilerGenerated]
	private bool bool_1;

	[CompilerGenerated]
	private bool bool_2;

	[CompilerGenerated]
	private int? nullable_5;

	[CompilerGenerated]
	private int? nullable_6;

	[CompilerGenerated]
	private IList<string> ilist_0;

	[CompilerGenerated]
	private IList<JsonSchemaModel> ilist_1;

	[CompilerGenerated]
	private IDictionary<string, JsonSchemaModel> idictionary_0;

	[CompilerGenerated]
	private IDictionary<string, JsonSchemaModel> idictionary_1;

	[CompilerGenerated]
	private JsonSchemaModel jsonSchemaModel_0;

	[CompilerGenerated]
	private JsonSchemaModel jsonSchemaModel_1;

	[CompilerGenerated]
	private bool bool_3;

	[CompilerGenerated]
	private bool bool_4;

	[CompilerGenerated]
	private bool bool_5;

	[CompilerGenerated]
	private bool bool_6;

	[CompilerGenerated]
	private IList<JToken> ilist_2;

	[CompilerGenerated]
	private JsonSchemaType jsonSchemaType_1;

	public bool Required
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

	public JsonSchemaType Type
	{
		[CompilerGenerated]
		get
		{
			return jsonSchemaType_0;
		}
		[CompilerGenerated]
		set
		{
			jsonSchemaType_0 = value;
		}
	}

	public int? MinimumLength
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

	public int? MaximumLength
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

	public double? DivisibleBy
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

	public double? Minimum
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

	public double? Maximum
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

	public bool ExclusiveMinimum
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

	public bool ExclusiveMaximum
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

	public int? MinimumItems
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

	public int? MaximumItems
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

	public IList<string> Patterns
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

	public IList<JsonSchemaModel> Items
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

	public IDictionary<string, JsonSchemaModel> Properties
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

	public IDictionary<string, JsonSchemaModel> PatternProperties
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

	public JsonSchemaModel AdditionalProperties
	{
		[CompilerGenerated]
		get
		{
			return jsonSchemaModel_0;
		}
		[CompilerGenerated]
		set
		{
			jsonSchemaModel_0 = value;
		}
	}

	public JsonSchemaModel AdditionalItems
	{
		[CompilerGenerated]
		get
		{
			return jsonSchemaModel_1;
		}
		[CompilerGenerated]
		set
		{
			jsonSchemaModel_1 = value;
		}
	}

	public bool PositionalItemsValidation
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

	public bool AllowAdditionalProperties
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

	public bool AllowAdditionalItems
	{
		[CompilerGenerated]
		get
		{
			return bool_5;
		}
		[CompilerGenerated]
		set
		{
			bool_5 = value;
		}
	}

	public bool UniqueItems
	{
		[CompilerGenerated]
		get
		{
			return bool_6;
		}
		[CompilerGenerated]
		set
		{
			bool_6 = value;
		}
	}

	public IList<JToken> Enum
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

	public JsonSchemaType Disallow
	{
		[CompilerGenerated]
		get
		{
			return jsonSchemaType_1;
		}
		[CompilerGenerated]
		set
		{
			jsonSchemaType_1 = value;
		}
	}

	public JsonSchemaModel()
	{
		Type = JsonSchemaType.Any;
		AllowAdditionalProperties = true;
		AllowAdditionalItems = true;
		Required = false;
	}
}
