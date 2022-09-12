using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

internal class Class2
{
	[ThreadStatic]
	private static Dictionary<Module, Class2> dictionary_0;

	private static readonly object fba3e9e1 = new object();

	private static Dictionary<Module, int> dictionary_1 = new Dictionary<Module, int>();

	private Stack<Class49> aeca6abb = new Stack<Class49>();

	private Class49 class49_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private be6c394c be6c394c_0;

	public static Class2 smethod_0(Module module_0)
	{
		if (dictionary_0 == null)
		{
			dictionary_0 = new Dictionary<Module, Class2>();
		}
		if (!dictionary_0.TryGetValue(module_0, out var value))
		{
			value = new Class2(be6c394c.smethod_0(module_0));
			dictionary_0[module_0] = value;
			lock (fba3e9e1)
			{
				if (!dictionary_1.ContainsKey(module_0))
				{
					value.method_1();
					dictionary_1.Add(module_0, dictionary_1.Count);
				}
			}
		}
		return value;
	}

	public static Class2 smethod_1(int int_0)
	{
		foreach (KeyValuePair<Module, int> item in dictionary_1)
		{
			if (item.Value == int_0)
			{
				return smethod_0(item.Key);
			}
		}
		return null;
	}

	public static int b23774b3(Module module_0)
	{
		return dictionary_1[module_0];
	}

	private Class2(be6c394c be6c394c_1)
	{
		method_0(be6c394c_1);
	}

	[SpecialName]
	public be6c394c c73a3276()
	{
		return be6c394c_0;
	}

	[SpecialName]
	private void method_0(be6c394c be6c394c_1)
	{
		be6c394c_0 = be6c394c_1;
	}

	private unsafe void method_1()
	{
		Struct4 @struct = c73a3276().method_4(cb1fcba5.byte_63);
		ulong ulong_ = (ulong)(c73a3276().method_2() + @struct.uint_0);
		method_6(ulong_, @struct.uint_1, @struct.class61_0, new object[0]);
	}

	public unsafe object method_2(uint uint_0, object[] object_0)
	{
		Struct4 @struct = c73a3276().method_4(uint_0);
		ulong ulong_ = (ulong)(c73a3276().method_2() + @struct.uint_0);
		return method_6(ulong_, @struct.uint_1, @struct.class61_0, object_0);
	}

	public object method_3(ulong ulong_0, uint uint_0, uint uint_1, object[] object_0)
	{
		Class61 class61_ = c73a3276().method_4(uint_1).class61_0;
		return method_6(ulong_0, uint_0, class61_, object_0);
	}

	public unsafe void method_4(uint uint_0, void*[] pVoid_0, void* pVoid_1)
	{
		Struct4 @struct = c73a3276().method_4(uint_0);
		ulong ulong_ = (ulong)(c73a3276().method_2() + @struct.uint_0);
		method_7(ulong_, @struct.uint_1, @struct.class61_0, pVoid_0, pVoid_1);
	}

	public unsafe void method_5(ulong ulong_0, uint uint_0, uint uint_1, void*[] pVoid_0, void* pVoid_1)
	{
		Class61 class61_ = c73a3276().method_4(uint_1).class61_0;
		method_7(ulong_0, uint_0, class61_, pVoid_0, pVoid_1);
	}

	private object method_6(ulong ulong_0, uint uint_0, Class61 class61_0, object[] object_0)
	{
		if (class49_0 != null)
		{
			aeca6abb.Push(class49_0);
		}
		class49_0 = new Class49(this);
		try
		{
			class49_0.ec45936d.method_0((uint)(object_0.Length + 1));
			for (uint num = 0u; num < object_0.Length; num++)
			{
				class49_0.ec45936d.d1cb88cf(num + 1, Struct2.a5dd3349(object_0[num], class61_0.c7148f45()[num]));
			}
			a5c16fd5 ec45936d = class49_0.ec45936d;
			int uint_ = object_0.Length + 1;
			Struct2 struct2_ = default(Struct2);
			struct2_.method_1(1uL);
			ec45936d.d1cb88cf((uint)uint_, struct2_);
			Struct2[] struct2_2 = class49_0.struct2_0;
			byte dcbee61c = cb1fcba5.dcbee61c;
			struct2_ = default(Struct2);
			struct2_.c85fac38(uint_0);
			struct2_2[dcbee61c] = struct2_;
			Struct2[] struct2_3 = class49_0.struct2_0;
			byte byte_ = cb1fcba5.byte_7;
			struct2_ = default(Struct2);
			struct2_.c85fac38(0u);
			struct2_3[byte_] = struct2_;
			Struct2[] struct2_4 = class49_0.struct2_0;
			byte byte_2 = cb1fcba5.byte_8;
			struct2_ = default(Struct2);
			struct2_.c85fac38((uint)(object_0.Length + 1));
			struct2_4[byte_2] = struct2_;
			Struct2[] struct2_5 = class49_0.struct2_0;
			byte byte_3 = cb1fcba5.byte_9;
			struct2_ = default(Struct2);
			struct2_.method_1(ulong_0);
			struct2_5[byte_3] = struct2_;
			Class50.smethod_0(class49_0);
			object result = null;
			if ((object)class61_0.method_0() != typeof(void))
			{
				Struct2 @struct = class49_0.struct2_0[cb1fcba5.byte_0];
				result = ((Type.GetTypeCode(class61_0.method_0()) != TypeCode.String || @struct.method_6() != null) ? @struct.method_8(class61_0.method_0()) : c73a3276().method_3(@struct.method_2()));
			}
			return result;
		}
		finally
		{
			class49_0.ec45936d.method_3();
			if (aeca6abb.Count > 0)
			{
				class49_0 = aeca6abb.Pop();
			}
		}
	}

	private unsafe void method_7(ulong ulong_0, uint uint_0, Class61 class61_0, void*[] pVoid_0, void* pVoid_1)
	{
		if (class49_0 != null)
		{
			aeca6abb.Push(class49_0);
		}
		class49_0 = new Class49(this);
		try
		{
			class49_0.ec45936d.method_0((uint)(pVoid_0.Length + 1));
			Struct2 struct2_;
			for (uint num = 0u; num < pVoid_0.Length; num++)
			{
				Type type = class61_0.c7148f45()[num];
				if (type.IsByRef)
				{
					a5c16fd5 ec45936d = class49_0.ec45936d;
					uint uint_ = num + 1;
					struct2_ = default(Struct2);
					struct2_.method_7(new c53b644c(fe387972.smethod_0(pVoid_0[num])));
					ec45936d.d1cb88cf(uint_, struct2_);
				}
				else
				{
					TypedReference typedReference = *(TypedReference*)pVoid_0[num];
					class49_0.ec45936d.d1cb88cf(num + 1, Struct2.a5dd3349(TypedReference.ToObject(typedReference), __reftype(typedReference)));
				}
			}
			a5c16fd5 ec45936d2 = class49_0.ec45936d;
			int uint_2 = pVoid_0.Length + 1;
			struct2_ = default(Struct2);
			struct2_.method_1(1uL);
			ec45936d2.d1cb88cf((uint)uint_2, struct2_);
			Struct2[] struct2_2 = class49_0.struct2_0;
			byte dcbee61c = cb1fcba5.dcbee61c;
			struct2_ = default(Struct2);
			struct2_.c85fac38(uint_0);
			struct2_2[dcbee61c] = struct2_;
			Struct2[] struct2_3 = class49_0.struct2_0;
			byte byte_ = cb1fcba5.byte_7;
			struct2_ = default(Struct2);
			struct2_.c85fac38(0u);
			struct2_3[byte_] = struct2_;
			Struct2[] struct2_4 = class49_0.struct2_0;
			byte byte_2 = cb1fcba5.byte_8;
			struct2_ = default(Struct2);
			struct2_.c85fac38((uint)(pVoid_0.Length + 1));
			struct2_4[byte_2] = struct2_;
			Struct2[] struct2_5 = class49_0.struct2_0;
			byte byte_3 = cb1fcba5.byte_9;
			struct2_ = default(Struct2);
			struct2_.method_1(ulong_0);
			struct2_5[byte_3] = struct2_;
			Class50.smethod_0(class49_0);
			if ((object)class61_0.method_0() == typeof(void))
			{
				return;
			}
			if (class61_0.method_0().IsByRef)
			{
				object obj = class49_0.struct2_0[cb1fcba5.byte_0].method_6();
				if (!(obj is da5e0024))
				{
					throw new ExecutionEngineException();
				}
				((da5e0024)obj).c4cba08f(class49_0, fe387972.smethod_0(pVoid_1), class61_0.method_0().GetElementType());
			}
			else
			{
				Struct2 @struct = class49_0.struct2_0[cb1fcba5.byte_0];
				object object_ = ((Type.GetTypeCode(class61_0.method_0()) != TypeCode.String || @struct.method_6() != null) ? @struct.method_8(class61_0.method_0()) : c73a3276().method_3(@struct.method_2()));
				Class55.smethod_2(object_, fe387972.smethod_0(pVoid_1));
			}
		}
		finally
		{
			class49_0.ec45936d.method_3();
			if (aeca6abb.Count > 0)
			{
				class49_0 = aeca6abb.Pop();
			}
		}
	}
}
