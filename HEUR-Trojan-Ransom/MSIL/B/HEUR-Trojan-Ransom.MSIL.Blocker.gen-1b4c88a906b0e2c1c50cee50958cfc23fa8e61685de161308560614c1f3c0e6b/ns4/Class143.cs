using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using ns1;
using ns10;
using ns12;
using ns13;
using ns15;
using ns16;
using ns18;

namespace ns4;

internal class Class143 : Class138
{
	[CompilerGenerated]
	private Enum9 enum9_0;

	[CompilerGenerated]
	private Enum11? nullable_4;

	[CompilerGenerated]
	private Enum16? nullable_5;

	[CompilerGenerated]
	private Enum12? nullable_6;

	[CompilerGenerated]
	private readonly Class150 class150_0;

	[CompilerGenerated]
	private Delegate5? delegate5_0;

	[CompilerGenerated]
	private Delegate6? delegate6_0;

	[CompilerGenerated]
	private Func<string, string>? func_1;

	internal bool bool_7;

	private bool? nullable_7;

	internal Delegate7<object>? delegate7_0;

	internal Delegate7<object>? delegate7_1;

	private Class150? class150_1;

	private Type? type_3;

	public Enum9 MemberSerialization
	{
		[CompilerGenerated]
		get
		{
			return enum9_0;
		}
		[CompilerGenerated]
		set
		{
			enum9_0 = value;
		}
	}

	public Enum11? MissingMemberHandling
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

	public Enum16? ItemRequired
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

	public Enum12? ItemNullValueHandling
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

	public Class150 Properties
	{
		[CompilerGenerated]
		get
		{
			return class150_0;
		}
	}

	public Class150 CreatorParameters
	{
		get
		{
			if (class150_1 == null)
			{
				class150_1 = new Class150(base.UnderlyingType);
			}
			return class150_1;
		}
	}

	public Delegate7<object>? OverrideCreator
	{
		get
		{
			return delegate7_0;
		}
		set
		{
			delegate7_0 = value;
		}
	}

	internal Delegate7<object>? ParameterizedCreator
	{
		get
		{
			return delegate7_1;
		}
		set
		{
			delegate7_1 = value;
		}
	}

	public Delegate5? ExtensionDataSetter
	{
		[CompilerGenerated]
		get
		{
			return delegate5_0;
		}
		[CompilerGenerated]
		set
		{
			delegate5_0 = value;
		}
	}

	public Delegate6? ExtensionDataGetter
	{
		[CompilerGenerated]
		get
		{
			return delegate6_0;
		}
		[CompilerGenerated]
		set
		{
			delegate6_0 = value;
		}
	}

	public Type? ExtensionDataValueType
	{
		get
		{
			return type_3;
		}
		set
		{
			type_3 = value;
			bool_7 = value != null && typeof(JToken).IsAssignableFrom(value);
		}
	}

	public Func<string, string>? ExtensionDataNameResolver
	{
		[CompilerGenerated]
		get
		{
			return func_1;
		}
		[CompilerGenerated]
		set
		{
			func_1 = value;
		}
	}

	internal bool HasRequiredOrDefaultValueProperties
	{
		get
		{
			if (!nullable_7.HasValue)
			{
				nullable_7 = false;
				if (ItemRequired.GetValueOrDefault(Enum16.const_0) != 0)
				{
					nullable_7 = true;
				}
				else
				{
					foreach (JsonProperty property in Properties)
					{
						if (property.Required != 0 || ((uint?)property.DefaultValueHandling & 2u) == 2)
						{
							nullable_7 = true;
							break;
						}
					}
				}
			}
			return nullable_7.GetValueOrDefault();
		}
	}

	public Class143(Type type_4)
		: base(type_4)
	{
		enum26_0 = Enum26.const_1;
		class150_0 = new Class150(base.UnderlyingType);
	}

	[SecuritySafeCritical]
	internal object method_5()
	{
		if (!JsonTypeReflector.FullyTrusted)
		{
			throw new JsonException("Insufficient permissions. Creating an uninitialized '{0}' type requires full trust.".smethod_1(CultureInfo.InvariantCulture, type_0));
		}
		return FormatterServices.GetUninitializedObject(type_0);
	}
}
