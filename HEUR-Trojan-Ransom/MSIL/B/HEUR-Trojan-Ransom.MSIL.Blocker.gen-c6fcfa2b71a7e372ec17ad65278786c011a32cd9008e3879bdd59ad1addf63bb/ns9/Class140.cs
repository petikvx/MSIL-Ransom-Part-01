using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Utilities;
using ns1;
using ns13;
using ns17;
using ns19;
using ns5;

namespace ns9;

internal class Class140 : Class138
{
	[CompilerGenerated]
	private Func<string, string>? func_1;

	[CompilerGenerated]
	private readonly Type? type_3;

	[CompilerGenerated]
	private readonly Type? type_4;

	[CompilerGenerated]
	private Class137? class137_2;

	private readonly Type? type_5;

	private Type? type_6;

	private Delegate7<object>? delegate7_0;

	private Func<object>? func_2;

	[CompilerGenerated]
	private readonly bool bool_7;

	private readonly ConstructorInfo? constructorInfo_0;

	internal Delegate7<object>? delegate7_1;

	private Delegate7<object>? delegate7_2;

	[CompilerGenerated]
	private bool bool_8;

	public Func<string, string>? DictionaryKeyResolver
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

	public Type? DictionaryKeyType
	{
		[CompilerGenerated]
		get
		{
			return type_3;
		}
	}

	public Type? DictionaryValueType
	{
		[CompilerGenerated]
		get
		{
			return type_4;
		}
	}

	internal Class137? KeyContract
	{
		[CompilerGenerated]
		get
		{
			return class137_2;
		}
		[CompilerGenerated]
		set
		{
			class137_2 = value;
		}
	}

	internal bool ShouldCreateWrapper
	{
		[CompilerGenerated]
		get
		{
			return bool_7;
		}
	}

	internal Delegate7<object>? ParameterizedCreator
	{
		get
		{
			if (delegate7_2 == null && constructorInfo_0 != null)
			{
				delegate7_2 = JsonTypeReflector.ReflectionDelegateFactory.vmethod_1(constructorInfo_0);
			}
			return delegate7_2;
		}
	}

	public Delegate7<object>? OverrideCreator
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

	public bool HasParameterizedCreator
	{
		[CompilerGenerated]
		get
		{
			return bool_8;
		}
		[CompilerGenerated]
		set
		{
			bool_8 = value;
		}
	}

	internal bool HasParameterizedCreatorInternal
	{
		get
		{
			if (!HasParameterizedCreator && delegate7_2 == null)
			{
				return constructorInfo_0 != null;
			}
			return true;
		}
	}

	public Class140(Type type_7)
		: base(type_7)
	{
		enum26_0 = Enum26.const_5;
		Type type;
		Type type2;
		if (Class131.smethod_618(type_0, typeof(IDictionary<, >), out type_5))
		{
			type = type_5!.GetGenericArguments()[0];
			type2 = type_5!.GetGenericArguments()[1];
			if (Class131.smethod_219(type_0, typeof(IDictionary<, >)))
			{
				base.CreatedType = typeof(Dictionary<, >).MakeGenericType(type, type2);
			}
			else if (type_0.smethod_4() && type_0.GetGenericTypeDefinition().FullName == "System.Collections.Concurrent.ConcurrentDictionary`2")
			{
				bool_7 = true;
			}
		}
		else
		{
			ReflectionUtils.smethod_3(type_0, out type, out type2);
			if (type_0 == typeof(IDictionary))
			{
				base.CreatedType = typeof(Dictionary<object, object>);
			}
		}
		if (type != null && type2 != null)
		{
			constructorInfo_0 = Class131.smethod_691(type_1, typeof(KeyValuePair<, >).MakeGenericType(type, type2), typeof(IDictionary<, >).MakeGenericType(type, type2));
			if (!HasParameterizedCreatorInternal && type_0.Name == "FSharpMap`2")
			{
				Class131.smethod_594(type_0.smethod_7());
				delegate7_2 = FSharpUtils.fsharpUtils_0!.method_0(type, type2);
			}
		}
		if (!typeof(IDictionary).IsAssignableFrom(type_1))
		{
			bool_7 = true;
		}
		type_3 = type;
		type_4 = type2;
		if (DictionaryKeyType != null && DictionaryValueType != null)
		{
			Type type3 = type_0;
			Type dictionaryKeyType = DictionaryKeyType;
			Type dictionaryValueType = DictionaryValueType;
			Delegate7<object> @delegate = default(Delegate7<object>);
			Type createdType = default(Type);
			if (Class131.smethod_702(ref @delegate, dictionaryKeyType, ref createdType, type3, dictionaryValueType))
			{
				base.CreatedType = createdType;
				delegate7_2 = @delegate;
				bool_3 = true;
			}
		}
	}

	internal Interface3 method_5(object object_0)
	{
		if (delegate7_0 == null)
		{
			type_6 = typeof(DictionaryWrapper<, >).MakeGenericType(DictionaryKeyType, DictionaryValueType);
			ConstructorInfo constructor = type_6!.GetConstructor(new Type[1] { type_5 });
			delegate7_0 = JsonTypeReflector.ReflectionDelegateFactory.vmethod_1(constructor);
		}
		return (Interface3)delegate7_0!(object_0);
	}

	internal IDictionary method_6()
	{
		if (func_2 == null)
		{
			Type type = typeof(Dictionary<, >).MakeGenericType(DictionaryKeyType ?? typeof(object), DictionaryValueType ?? typeof(object));
			func_2 = JsonTypeReflector.ReflectionDelegateFactory.vmethod_2<object>(type);
		}
		return (IDictionary)func_2!();
	}
}
