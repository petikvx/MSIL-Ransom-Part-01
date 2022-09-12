using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

internal class c184d4f4
{
	[ThreadStatic]
	private static Dictionary<Module, c184d4f4> dictionary_0;

	private static readonly object object_0 = new object();

	private static Dictionary<Module, int> dictionary_1 = new Dictionary<Module, int>();

	private Stack<Class52> a64596ae = new Stack<Class52>();

	private Class52 class52_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private eb82ed4b a5772a10;

	public static c184d4f4 c8dafbc3(Module module_0)
	{
		if (dictionary_0 == null)
		{
			dictionary_0 = new Dictionary<Module, c184d4f4>();
		}
		if (!dictionary_0.TryGetValue(module_0, out var value))
		{
			value = new c184d4f4(eb82ed4b.c8dafbc3(module_0));
			dictionary_0[module_0] = value;
			lock (object_0)
			{
				if (!dictionary_1.ContainsKey(module_0))
				{
					value.e259e1a7();
					dictionary_1.Add(module_0, dictionary_1.Count);
				}
			}
		}
		return value;
	}

	public static c184d4f4 c8dafbc3(int int_0)
	{
		foreach (KeyValuePair<Module, int> item in dictionary_1)
		{
			if (item.Value == int_0)
			{
				return c8dafbc3(item.Key);
			}
		}
		return null;
	}

	public static int smethod_0(Module module_0)
	{
		return dictionary_1[module_0];
	}

	private c184d4f4(eb82ed4b eb82ed4b_0)
	{
		method_1(eb82ed4b_0);
	}

	[SpecialName]
	public eb82ed4b method_0()
	{
		return a5772a10;
	}

	[SpecialName]
	private void method_1(eb82ed4b eb82ed4b_0)
	{
		a5772a10 = eb82ed4b_0;
	}

	private unsafe void e259e1a7()
	{
		Struct3 @struct = method_0().d92c25c4(fae0f10.byte_51);
		ulong ulong_ = (ulong)(method_0().f1a90190() + @struct.e2541d3c);
		method_6(ulong_, @struct.uint_0, @struct.b47905ce, new object[0]);
	}

	public unsafe object method_2(uint uint_0, object[] object_1)
	{
		Struct3 @struct = method_0().d92c25c4(uint_0);
		ulong ulong_ = (ulong)(method_0().f1a90190() + @struct.e2541d3c);
		return method_6(ulong_, @struct.uint_0, @struct.b47905ce, object_1);
	}

	public object method_3(ulong ulong_0, uint uint_0, uint uint_1, object[] object_1)
	{
		Class62 b47905ce = method_0().d92c25c4(uint_1).b47905ce;
		return method_6(ulong_0, uint_0, b47905ce, object_1);
	}

	public unsafe void method_4(uint uint_0, void*[] pVoid_0, void* pVoid_1)
	{
		Struct3 @struct = method_0().d92c25c4(uint_0);
		ulong ulong_ = (ulong)(method_0().f1a90190() + @struct.e2541d3c);
		method_7(ulong_, @struct.uint_0, @struct.b47905ce, pVoid_0, pVoid_1);
	}

	public unsafe void method_5(ulong ulong_0, uint uint_0, uint uint_1, void*[] pVoid_0, void* pVoid_1)
	{
		Class62 b47905ce = method_0().d92c25c4(uint_1).b47905ce;
		method_7(ulong_0, uint_0, b47905ce, pVoid_0, pVoid_1);
	}

	private object method_6(ulong ulong_0, uint uint_0, Class62 class62_0, object[] object_1)
	{
		if (class52_0 != null)
		{
			a64596ae.Push(class52_0);
		}
		class52_0 = new Class52(this);
		try
		{
			class52_0.c6a36180_0.method_0((uint)(object_1.Length + 1));
			for (uint num = 0u; num < object_1.Length; num++)
			{
				class52_0.c6a36180_0.f43586b2(num + 1, Struct2.smethod_0(object_1[num], class62_0.b05b0630()[num]));
			}
			c6a36180 c6a36180_ = class52_0.c6a36180_0;
			int uint_ = object_1.Length + 1;
			Struct2 struct2_ = default(Struct2);
			struct2_.f6b2288d(1uL);
			c6a36180_.f43586b2((uint)uint_, struct2_);
			Struct2[] struct2_2 = class52_0.struct2_0;
			byte ccfef7db = fae0f10.ccfef7db;
			struct2_ = default(Struct2);
			struct2_.b3579a47(uint_0);
			struct2_2[ccfef7db] = struct2_;
			Struct2[] struct2_3 = class52_0.struct2_0;
			byte byte_ = fae0f10.byte_4;
			struct2_ = default(Struct2);
			struct2_.b3579a47(0u);
			struct2_3[byte_] = struct2_;
			Struct2[] struct2_4 = class52_0.struct2_0;
			byte byte_2 = fae0f10.byte_5;
			struct2_ = default(Struct2);
			struct2_.b3579a47((uint)(object_1.Length + 1));
			struct2_4[byte_2] = struct2_;
			Struct2[] struct2_5 = class52_0.struct2_0;
			byte d1e = fae0f10.d1e82201;
			struct2_ = default(Struct2);
			struct2_.f6b2288d(ulong_0);
			struct2_5[d1e] = struct2_;
			Class53.smethod_0(class52_0);
			object result = null;
			if ((object)class62_0.method_0() != typeof(void))
			{
				Struct2 @struct = class52_0.struct2_0[fae0f10.dad6172f];
				result = ((Type.GetTypeCode(class62_0.method_0()) != TypeCode.String || @struct.a90ed1e2() != null) ? @struct.method_9(class62_0.method_0()) : method_0().f54a7fb9(@struct.b5683088()));
			}
			return result;
		}
		finally
		{
			class52_0.c6a36180_0.method_3();
			if (a64596ae.Count > 0)
			{
				class52_0 = a64596ae.Pop();
			}
		}
	}

	private unsafe void method_7(ulong ulong_0, uint uint_0, Class62 class62_0, void*[] pVoid_0, void* pVoid_1)
	{
		if (class52_0 != null)
		{
			a64596ae.Push(class52_0);
		}
		class52_0 = new Class52(this);
		try
		{
			class52_0.c6a36180_0.method_0((uint)(pVoid_0.Length + 1));
			Struct2 struct2_;
			for (uint num = 0u; num < pVoid_0.Length; num++)
			{
				Type type = class62_0.b05b0630()[num];
				if (type.IsByRef)
				{
					c6a36180 c6a36180_ = class52_0.c6a36180_0;
					uint uint_ = num + 1;
					struct2_ = default(Struct2);
					struct2_.method_7(new Class51(Struct1.d9a770c4(pVoid_0[num])));
					c6a36180_.f43586b2(uint_, struct2_);
				}
				else
				{
					TypedReference typedReference = *(TypedReference*)pVoid_0[num];
					class52_0.c6a36180_0.f43586b2(num + 1, Struct2.smethod_0(TypedReference.ToObject(typedReference), __reftype(typedReference)));
				}
			}
			c6a36180 c6a36180_2 = class52_0.c6a36180_0;
			int uint_2 = pVoid_0.Length + 1;
			struct2_ = default(Struct2);
			struct2_.f6b2288d(1uL);
			c6a36180_2.f43586b2((uint)uint_2, struct2_);
			Struct2[] struct2_2 = class52_0.struct2_0;
			byte ccfef7db = fae0f10.ccfef7db;
			struct2_ = default(Struct2);
			struct2_.b3579a47(uint_0);
			struct2_2[ccfef7db] = struct2_;
			Struct2[] struct2_3 = class52_0.struct2_0;
			byte byte_ = fae0f10.byte_4;
			struct2_ = default(Struct2);
			struct2_.b3579a47(0u);
			struct2_3[byte_] = struct2_;
			Struct2[] struct2_4 = class52_0.struct2_0;
			byte byte_2 = fae0f10.byte_5;
			struct2_ = default(Struct2);
			struct2_.b3579a47((uint)(pVoid_0.Length + 1));
			struct2_4[byte_2] = struct2_;
			Struct2[] struct2_5 = class52_0.struct2_0;
			byte d1e = fae0f10.d1e82201;
			struct2_ = default(Struct2);
			struct2_.f6b2288d(ulong_0);
			struct2_5[d1e] = struct2_;
			Class53.smethod_0(class52_0);
			if ((object)class62_0.method_0() == typeof(void))
			{
				return;
			}
			if (class62_0.method_0().IsByRef)
			{
				object obj = class52_0.struct2_0[fae0f10.dad6172f].a90ed1e2();
				if (!(obj is Interface1))
				{
					throw new ExecutionEngineException();
				}
				((Interface1)obj).imethod_1(class52_0, Struct1.d9a770c4(pVoid_1), class62_0.method_0().GetElementType());
			}
			else
			{
				Struct2 @struct = class52_0.struct2_0[fae0f10.dad6172f];
				object obj2 = ((Type.GetTypeCode(class62_0.method_0()) != TypeCode.String || @struct.a90ed1e2() != null) ? @struct.method_9(class62_0.method_0()) : method_0().f54a7fb9(@struct.b5683088()));
				Class57.e8c6cd7c(obj2, Struct1.d9a770c4(pVoid_1));
			}
		}
		finally
		{
			class52_0.c6a36180_0.method_3();
			if (a64596ae.Count > 0)
			{
				class52_0 = a64596ae.Pop();
			}
		}
	}
}
