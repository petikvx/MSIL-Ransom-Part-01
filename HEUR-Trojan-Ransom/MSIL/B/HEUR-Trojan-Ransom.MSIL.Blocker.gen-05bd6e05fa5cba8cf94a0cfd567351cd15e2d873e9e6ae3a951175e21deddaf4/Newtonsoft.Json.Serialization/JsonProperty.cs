using System;
using System.Runtime.CompilerServices;
using ns0;
using ns10;
using ns11;
using ns15;
using ns2;
using ns3;
using ns6;
using ns7;
using ns9;

namespace Newtonsoft.Json.Serialization;

public class JsonProperty
{
	internal Enum16? nullable_0;

	internal bool bool_0;

	internal object? object_0;

	internal bool bool_1;

	internal string? string_0;

	internal bool bool_2;

	internal Type? type_0;

	[CompilerGenerated]
	private Class137? class137_0;

	[CompilerGenerated]
	private Type? type_1;

	[CompilerGenerated]
	private int? nullable_1;

	[CompilerGenerated]
	private string? string_1;

	[CompilerGenerated]
	private Interface8? interface8_0;

	[CompilerGenerated]
	private Interface9? interface9_0;

	[CompilerGenerated]
	private Class9? class9_0;

	[CompilerGenerated]
	private bool bool_3;

	[CompilerGenerated]
	private bool bool_4;

	[CompilerGenerated]
	private bool bool_5;

	[CompilerGenerated]
	private bool bool_6;

	[CompilerGenerated]
	private bool? nullable_2;

	[CompilerGenerated]
	private Enum12? nullable_3;

	[CompilerGenerated]
	private Enum4? nullable_4;

	[CompilerGenerated]
	private Enum15? nullable_5;

	[CompilerGenerated]
	private Enum13? nullable_6;

	[CompilerGenerated]
	private Enum19? nullable_7;

	[CompilerGenerated]
	private Predicate<object>? predicate_0;

	[CompilerGenerated]
	private Predicate<object>? predicate_1;

	[CompilerGenerated]
	private Predicate<object>? predicate_2;

	[CompilerGenerated]
	private Action<object, object?>? action_0;

	[CompilerGenerated]
	private Class9? class9_1;

	[CompilerGenerated]
	private bool? nullable_8;

	[CompilerGenerated]
	private Enum19? nullable_9;

	[CompilerGenerated]
	private Enum15? nullable_10;

	internal Class137? PropertyContract
	{
		[CompilerGenerated]
		get
		{
			return class137_0;
		}
		[CompilerGenerated]
		set
		{
			class137_0 = value;
		}
	}

	public string? PropertyName
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = value;
			bool_2 = !Class4.smethod_626(string_0, Class88.bool_2);
		}
	}

	public Type? DeclaringType
	{
		[CompilerGenerated]
		get
		{
			return type_1;
		}
		[CompilerGenerated]
		set
		{
			type_1 = value;
		}
	}

	public int? Order
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

	public string? UnderlyingName
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

	public Interface8? ValueProvider
	{
		[CompilerGenerated]
		get
		{
			return interface8_0;
		}
		[CompilerGenerated]
		set
		{
			interface8_0 = value;
		}
	}

	public Interface9? AttributeProvider
	{
		[CompilerGenerated]
		get
		{
			return interface9_0;
		}
		[CompilerGenerated]
		set
		{
			interface9_0 = value;
		}
	}

	public Type? PropertyType
	{
		get
		{
			return type_0;
		}
		set
		{
			if (type_0 != value)
			{
				type_0 = value;
				bool_1 = false;
			}
		}
	}

	public Class9? Converter
	{
		[CompilerGenerated]
		get
		{
			return class9_0;
		}
		[CompilerGenerated]
		set
		{
			class9_0 = value;
		}
	}

	[Obsolete("MemberConverter is obsolete. Use Converter instead.")]
	public Class9? MemberConverter
	{
		get
		{
			return Converter;
		}
		set
		{
			Converter = value;
		}
	}

	public bool Ignored
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

	public bool Readable
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

	public bool Writable
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

	public bool HasMemberAttribute
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

	public object? DefaultValue
	{
		get
		{
			if (!bool_0)
			{
				return null;
			}
			return object_0;
		}
		set
		{
			bool_0 = true;
			object_0 = value;
		}
	}

	public Enum16 Required
	{
		get
		{
			return nullable_0.GetValueOrDefault();
		}
		set
		{
			nullable_0 = value;
		}
	}

	public bool IsRequiredSpecified => nullable_0.HasValue;

	public bool? IsReference
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

	public Enum12? NullValueHandling
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

	public Enum4? DefaultValueHandling
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

	public Enum15? ReferenceLoopHandling
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

	public Enum13? ObjectCreationHandling
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

	public Enum19? TypeNameHandling
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

	public Predicate<object>? ShouldSerialize
	{
		[CompilerGenerated]
		get
		{
			return predicate_0;
		}
		[CompilerGenerated]
		set
		{
			predicate_0 = value;
		}
	}

	public Predicate<object>? ShouldDeserialize
	{
		[CompilerGenerated]
		get
		{
			return predicate_1;
		}
		[CompilerGenerated]
		set
		{
			predicate_1 = value;
		}
	}

	public Predicate<object>? GetIsSpecified
	{
		[CompilerGenerated]
		get
		{
			return predicate_2;
		}
		[CompilerGenerated]
		set
		{
			predicate_2 = value;
		}
	}

	public Action<object, object?>? SetIsSpecified
	{
		[CompilerGenerated]
		get
		{
			return action_0;
		}
		[CompilerGenerated]
		set
		{
			action_0 = value;
		}
	}

	public Class9? ItemConverter
	{
		[CompilerGenerated]
		get
		{
			return class9_1;
		}
		[CompilerGenerated]
		set
		{
			class9_1 = value;
		}
	}

	public bool? ItemIsReference
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

	public Enum19? ItemTypeNameHandling
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

	public Enum15? ItemReferenceLoopHandling
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

	string object.ToString()
	{
		return string_0 ?? string.Empty;
	}

	internal void method_0(Class38 class38_0)
	{
		string text = string_0;
		if (bool_2)
		{
			class38_0.vmethod_10(text, bool_2: false);
		}
		else
		{
			class38_0.vmethod_9(text);
		}
	}
}
