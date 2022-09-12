using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Serialization;
using ns13;
using ns5;
using ns7;
using ns8;

namespace Newtonsoft.Json.Utilities;

internal class FSharpUtils
{
	[CompilerGenerated]
	internal sealed class Class80
	{
		public Delegate1<object?, object?> delegate1_0;

		public Delegate1<object?, object> delegate1_1;

		internal object method_0(object? object_0, object?[] object_1)
		{
			return new Class79(delegate1_0(object_0, object_1), delegate1_1);
		}
	}

	[CompilerGenerated]
	private sealed class Class81<T, U> where T : notnull where U : notnull
	{
		public Delegate7<object> delegate7_0;

		internal object method_0(object?[] object_0)
		{
			IEnumerable<Tuple<T, U>> enumerable = ((IEnumerable<KeyValuePair<T, U>>)object_0[0]).Select((KeyValuePair<T, U> keyValuePair_0) => new Tuple<T, U>(keyValuePair_0.Key, keyValuePair_0.Value));
			return delegate7_0(enumerable);
		}
	}

	internal static readonly object object_0 = new object();

	internal static FSharpUtils? fsharpUtils_0;

	internal MethodInfo methodInfo_0;

	private Type type_0;

	[CompilerGenerated]
	private Assembly assembly_0;

	[CompilerGenerated]
	private Delegate1<object?, object> delegate1_0;

	[CompilerGenerated]
	private Delegate1<object?, object> delegate1_1;

	[CompilerGenerated]
	private Delegate1<object?, object> delegate1_2;

	[CompilerGenerated]
	private Delegate1<object?, object> delegate1_3;

	[CompilerGenerated]
	private Delegate1<object?, object> delegate1_4;

	[CompilerGenerated]
	private Func<object, object> func_0;

	[CompilerGenerated]
	private Func<object, object> func_1;

	[CompilerGenerated]
	private Func<object, object> func_2;

	[CompilerGenerated]
	private Delegate1<object, object?> delegate1_5;

	public const string string_0 = "FSharpSet`1";

	public const string string_1 = "FSharpList`1";

	public const string string_2 = "FSharpMap`2";

	public static FSharpUtils Instance => fsharpUtils_0;

	public Assembly FSharpCoreAssembly
	{
		[CompilerGenerated]
		get
		{
			return assembly_0;
		}
		[CompilerGenerated]
		private set
		{
			assembly_0 = value;
		}
	}

	public Delegate1<object?, object> IsUnion
	{
		[CompilerGenerated]
		get
		{
			return delegate1_0;
		}
		[CompilerGenerated]
		private set
		{
			delegate1_0 = value;
		}
	}

	public Delegate1<object?, object> GetUnionCases
	{
		[CompilerGenerated]
		get
		{
			return delegate1_1;
		}
		[CompilerGenerated]
		private set
		{
			delegate1_1 = value;
		}
	}

	public Delegate1<object?, object> PreComputeUnionTagReader
	{
		[CompilerGenerated]
		get
		{
			return delegate1_2;
		}
		[CompilerGenerated]
		private set
		{
			delegate1_2 = value;
		}
	}

	public Delegate1<object?, object> PreComputeUnionReader
	{
		[CompilerGenerated]
		get
		{
			return delegate1_3;
		}
		[CompilerGenerated]
		private set
		{
			delegate1_3 = value;
		}
	}

	public Delegate1<object?, object> PreComputeUnionConstructor
	{
		[CompilerGenerated]
		get
		{
			return delegate1_4;
		}
		[CompilerGenerated]
		private set
		{
			delegate1_4 = value;
		}
	}

	public Func<object, object> GetUnionCaseInfoDeclaringType
	{
		[CompilerGenerated]
		get
		{
			return func_0;
		}
		[CompilerGenerated]
		private set
		{
			func_0 = value;
		}
	}

	public Func<object, object> GetUnionCaseInfoName
	{
		[CompilerGenerated]
		get
		{
			return func_1;
		}
		[CompilerGenerated]
		private set
		{
			func_1 = value;
		}
	}

	public Func<object, object> GetUnionCaseInfoTag
	{
		[CompilerGenerated]
		get
		{
			return func_2;
		}
		[CompilerGenerated]
		private set
		{
			func_2 = value;
		}
	}

	public Delegate1<object, object?> GetUnionCaseInfoFields
	{
		[CompilerGenerated]
		get
		{
			return delegate1_5;
		}
		[CompilerGenerated]
		private set
		{
			delegate1_5 = value;
		}
	}

	internal FSharpUtils(Assembly fsharpCoreAssembly)
	{
		FSharpCoreAssembly = fsharpCoreAssembly;
		Type? type = fsharpCoreAssembly.GetType("Microsoft.FSharp.Reflection.FSharpType");
		MethodInfo methodBase_ = Class131.smethod_235(type, "IsUnion", BindingFlags.Static | BindingFlags.Public);
		IsUnion = JsonTypeReflector.ReflectionDelegateFactory.vmethod_0<object>(methodBase_);
		MethodInfo methodBase_2 = Class131.smethod_235(type, "GetUnionCases", BindingFlags.Static | BindingFlags.Public);
		GetUnionCases = JsonTypeReflector.ReflectionDelegateFactory.vmethod_0<object>(methodBase_2);
		Type type2 = fsharpCoreAssembly.GetType("Microsoft.FSharp.Reflection.FSharpValue");
		PreComputeUnionTagReader = Class131.smethod_93(type2, "PreComputeUnionTagReader");
		PreComputeUnionReader = Class131.smethod_93(type2, "PreComputeUnionReader");
		PreComputeUnionConstructor = Class131.smethod_93(type2, "PreComputeUnionConstructor");
		Type type3 = fsharpCoreAssembly.GetType("Microsoft.FSharp.Reflection.UnionCaseInfo");
		GetUnionCaseInfoName = JsonTypeReflector.ReflectionDelegateFactory.vmethod_3<object>(type3.GetProperty("Name"));
		GetUnionCaseInfoTag = JsonTypeReflector.ReflectionDelegateFactory.vmethod_3<object>(type3.GetProperty("Tag"));
		GetUnionCaseInfoDeclaringType = JsonTypeReflector.ReflectionDelegateFactory.vmethod_3<object>(type3.GetProperty("DeclaringType"));
		GetUnionCaseInfoFields = JsonTypeReflector.ReflectionDelegateFactory.vmethod_0<object>(type3.GetMethod("GetFields"));
		Type type4 = fsharpCoreAssembly.GetType("Microsoft.FSharp.Collections.ListModule");
		methodInfo_0 = type4.GetMethod("OfSeq");
		type_0 = fsharpCoreAssembly.GetType("Microsoft.FSharp.Collections.FSharpMap`2");
	}

	public Delegate7<object> method_0(Type type_1, Type type_2)
	{
		return (Delegate7<object>)typeof(FSharpUtils).GetMethod("BuildMapCreator")!.MakeGenericMethod(type_1, type_2).Invoke(this, null);
	}

	public Delegate7<object> method_1<T, U>()
	{
		ConstructorInfo constructor = type_0.MakeGenericType(typeof(T), typeof(U)).GetConstructor(new Type[1] { typeof(IEnumerable<Tuple<T, U>>) });
		Delegate7<object> delegate7_0 = JsonTypeReflector.ReflectionDelegateFactory.vmethod_1(constructor);
		return delegate(object?[] object_0)
		{
			IEnumerable<Tuple<T, U>> enumerable = ((IEnumerable<KeyValuePair<T, U>>)object_0[0]).Select((KeyValuePair<T, U> keyValuePair_0) => new Tuple<T, U>(keyValuePair_0.Key, keyValuePair_0.Value));
			return delegate7_0(enumerable);
		};
	}
}
