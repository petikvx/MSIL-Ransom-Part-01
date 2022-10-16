using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

internal class a49ada94
{
	[ThreadStatic]
	private static Dictionary<Module, a49ada94> dictionary_0;

	private static readonly object object_0 = new object();

	private static Dictionary<Module, int> de0c00eb = new Dictionary<Module, int>();

	private Stack<Class58> stack_0 = new Stack<Class58>();

	private Class58 class58_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Class66 class66_0;

	public static a49ada94 a3d704e3(Module module_0)
	{
		if (dictionary_0 == null)
		{
			dictionary_0 = new Dictionary<Module, a49ada94>();
		}
		if (!dictionary_0.TryGetValue(module_0, out var value))
		{
			value = new a49ada94(Class66.a3d704e3(module_0));
			dictionary_0[module_0] = value;
			lock (object_0)
			{
				if (!de0c00eb.ContainsKey(module_0))
				{
					value.c776ecc7();
					de0c00eb.Add(module_0, de0c00eb.Count);
				}
			}
		}
		return value;
	}

	public static a49ada94 a3d704e3(int int_0)
	{
		foreach (KeyValuePair<Module, int> item in de0c00eb)
		{
			if (item.Value == int_0)
			{
				return a3d704e3(item.Key);
			}
		}
		return null;
	}

	public static int b477a4e6(Module module_0)
	{
		return de0c00eb[module_0];
	}

	private a49ada94(Class66 class66_1)
	{
		method_1(class66_1);
	}

	[SpecialName]
	public Class66 method_0()
	{
		return class66_0;
	}

	[SpecialName]
	private void method_1(Class66 class66_1)
	{
		class66_0 = class66_1;
	}

	private unsafe void c776ecc7()
	{
		Struct2 @struct = method_0().a1cfd364(b13312b0.byte_73);
		ulong ulong_ = (ulong)(method_0().method_1() + @struct.uint_0);
		df3f437a(ulong_, @struct.uint_1, @struct.f8b7206e, new object[0]);
	}

	public unsafe object df3f437a(uint uint_0, object[] object_1)
	{
		Struct2 @struct = method_0().a1cfd364(uint_0);
		ulong ulong_ = (ulong)(method_0().method_1() + @struct.uint_0);
		return df3f437a(ulong_, @struct.uint_1, @struct.f8b7206e, object_1);
	}

	public object df3f437a(ulong ulong_0, uint uint_0, uint uint_1, object[] object_1)
	{
		ff656cf5 f8b7206e = method_0().a1cfd364(uint_1).f8b7206e;
		return df3f437a(ulong_0, uint_0, f8b7206e, object_1);
	}

	public unsafe void df3f437a(uint uint_0, void*[] pVoid_0, void* pVoid_1)
	{
		Struct2 @struct = method_0().a1cfd364(uint_0);
		ulong ulong_ = (ulong)(method_0().method_1() + @struct.uint_0);
		df3f437a(ulong_, @struct.uint_1, @struct.f8b7206e, pVoid_0, pVoid_1);
	}

	public unsafe void df3f437a(ulong ulong_0, uint uint_0, uint uint_1, void*[] pVoid_0, void* pVoid_1)
	{
		ff656cf5 f8b7206e = method_0().a1cfd364(uint_1).f8b7206e;
		df3f437a(ulong_0, uint_0, f8b7206e, pVoid_0, pVoid_1);
	}

	private object df3f437a(ulong ulong_0, uint uint_0, ff656cf5 ff656cf5_0, object[] object_1)
	{
		if (class58_0 != null)
		{
			stack_0.Push(class58_0);
		}
		class58_0 = new Class58(this);
		try
		{
			class58_0.c73f45d8.a85b6a89((uint)(object_1.Length + 1));
			for (uint num = 0u; num < object_1.Length; num++)
			{
				class58_0.c73f45d8.method_0(num + 1, facef383.b3e8ed04(object_1[num], ff656cf5_0.method_0()[num]));
			}
			Class59 c73f45d = class58_0.c73f45d8;
			int uint_ = object_1.Length + 1;
			facef383 facef383_ = default(facef383);
			facef383_.method_1(1uL);
			c73f45d.method_0((uint)uint_, facef383_);
			facef383[] a6890f1d = class58_0.a6890f1d;
			byte byte_ = b13312b0.byte_8;
			facef383_ = default(facef383);
			facef383_.method_2(uint_0);
			a6890f1d[byte_] = facef383_;
			facef383[] a6890f1d2 = class58_0.a6890f1d;
			byte b7ea2fd = b13312b0.b7ea2fd7;
			facef383_ = default(facef383);
			facef383_.method_2(0u);
			a6890f1d2[b7ea2fd] = facef383_;
			facef383[] a6890f1d3 = class58_0.a6890f1d;
			byte byte_2 = b13312b0.byte_7;
			facef383_ = default(facef383);
			facef383_.method_2((uint)(object_1.Length + 1));
			a6890f1d3[byte_2] = facef383_;
			facef383[] a6890f1d4 = class58_0.a6890f1d;
			byte a = b13312b0.a2230221;
			facef383_ = default(facef383);
			facef383_.method_1(ulong_0);
			a6890f1d4[a] = facef383_;
			d4f30da1.df3f437a(class58_0);
			object result = null;
			if ((object)ff656cf5_0.method_1() != typeof(void))
			{
				facef383 facef384 = class58_0.a6890f1d[b13312b0.byte_0];
				result = ((Type.GetTypeCode(ff656cf5_0.method_1()) != TypeCode.String || facef384.method_8() != null) ? facef384.f3c5123d(ff656cf5_0.method_1()) : method_0().method_3(facef384.df1ed028()));
			}
			return result;
		}
		finally
		{
			class58_0.c73f45d8.e2eab9a3();
			if (stack_0.Count > 0)
			{
				class58_0 = stack_0.Pop();
			}
		}
	}

	private unsafe void df3f437a(ulong ulong_0, uint uint_0, ff656cf5 ff656cf5_0, void*[] pVoid_0, void* pVoid_1)
	{
		if (class58_0 != null)
		{
			stack_0.Push(class58_0);
		}
		class58_0 = new Class58(this);
		try
		{
			class58_0.c73f45d8.a85b6a89((uint)(pVoid_0.Length + 1));
			facef383 facef383_;
			for (uint num = 0u; num < pVoid_0.Length; num++)
			{
				Type type = ff656cf5_0.method_0()[num];
				if (type.IsByRef)
				{
					Class59 c73f45d = class58_0.c73f45d8;
					uint uint_ = num + 1;
					facef383_ = default(facef383);
					facef383_.method_9(new Class57(Struct0.smethod_0(pVoid_0[num])));
					c73f45d.method_0(uint_, facef383_);
				}
				else
				{
					TypedReference typedReference = *(TypedReference*)pVoid_0[num];
					class58_0.c73f45d8.method_0(num + 1, facef383.b3e8ed04(TypedReference.ToObject(typedReference), __reftype(typedReference)));
				}
			}
			Class59 c73f45d2 = class58_0.c73f45d8;
			int uint_2 = pVoid_0.Length + 1;
			facef383_ = default(facef383);
			facef383_.method_1(1uL);
			c73f45d2.method_0((uint)uint_2, facef383_);
			facef383[] a6890f1d = class58_0.a6890f1d;
			byte byte_ = b13312b0.byte_8;
			facef383_ = default(facef383);
			facef383_.method_2(uint_0);
			a6890f1d[byte_] = facef383_;
			facef383[] a6890f1d2 = class58_0.a6890f1d;
			byte b7ea2fd = b13312b0.b7ea2fd7;
			facef383_ = default(facef383);
			facef383_.method_2(0u);
			a6890f1d2[b7ea2fd] = facef383_;
			facef383[] a6890f1d3 = class58_0.a6890f1d;
			byte byte_2 = b13312b0.byte_7;
			facef383_ = default(facef383);
			facef383_.method_2((uint)(pVoid_0.Length + 1));
			a6890f1d3[byte_2] = facef383_;
			facef383[] a6890f1d4 = class58_0.a6890f1d;
			byte a = b13312b0.a2230221;
			facef383_ = default(facef383);
			facef383_.method_1(ulong_0);
			a6890f1d4[a] = facef383_;
			d4f30da1.df3f437a(class58_0);
			if ((object)ff656cf5_0.method_1() == typeof(void))
			{
				return;
			}
			if (ff656cf5_0.method_1().IsByRef)
			{
				object obj = class58_0.a6890f1d[b13312b0.byte_0].method_8();
				if (!(obj is Interface0))
				{
					throw new ExecutionEngineException();
				}
				((Interface0)obj).imethod_0(class58_0, Struct0.smethod_0(pVoid_1), ff656cf5_0.method_1().GetElementType());
			}
			else
			{
				facef383 facef384 = class58_0.a6890f1d[b13312b0.byte_0];
				object obj2 = ((Type.GetTypeCode(ff656cf5_0.method_1()) != TypeCode.String || facef384.method_8() != null) ? facef384.f3c5123d(ff656cf5_0.method_1()) : method_0().method_3(facef384.df1ed028()));
				Class63.smethod_2(obj2, Struct0.smethod_0(pVoid_1));
			}
		}
		finally
		{
			class58_0.c73f45d8.e2eab9a3();
			if (stack_0.Count > 0)
			{
				class58_0 = stack_0.Pop();
			}
		}
	}
}
