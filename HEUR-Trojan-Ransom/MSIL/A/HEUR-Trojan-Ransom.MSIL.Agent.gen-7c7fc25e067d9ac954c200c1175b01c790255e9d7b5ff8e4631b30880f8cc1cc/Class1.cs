using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

internal class Class1
{
	[ThreadStatic]
	private static Dictionary<Module, Class1> b99511d1;

	private static readonly object cb8320fc = new object();

	private static Dictionary<Module, int> dictionary_0 = new Dictionary<Module, int>();

	private Stack<Class54> stack_0 = new Stack<Class54>();

	private Class54 class54_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private b4261ab b61e65f0;

	public static Class1 smethod_0(Module module_0)
	{
		if (b99511d1 == null)
		{
			b99511d1 = new Dictionary<Module, Class1>();
		}
		if (!b99511d1.TryGetValue(module_0, out var value))
		{
			value = new Class1(b4261ab.smethod_0(module_0));
			b99511d1[module_0] = value;
			lock (cb8320fc)
			{
				if (!dictionary_0.ContainsKey(module_0))
				{
					value.method_1();
					dictionary_0.Add(module_0, dictionary_0.Count);
				}
			}
		}
		return value;
	}

	public static Class1 smethod_1(int int_0)
	{
		foreach (KeyValuePair<Module, int> item in dictionary_0)
		{
			if (item.Value == int_0)
			{
				return smethod_0(item.Key);
			}
		}
		return null;
	}

	public static int d214bb26(Module module_0)
	{
		return dictionary_0[module_0];
	}

	private Class1(b4261ab b4261ab_0)
	{
		c4915d48(b4261ab_0);
	}

	[SpecialName]
	public b4261ab method_0()
	{
		return b61e65f0;
	}

	[SpecialName]
	private void c4915d48(b4261ab b4261ab_0)
	{
		b61e65f0 = b4261ab_0;
	}

	private unsafe void method_1()
	{
		Struct4 @struct = method_0().method_4(c34ccaf0.ba78f3e);
		ulong ulong_ = (ulong)(method_0().b6037d70() + @struct.uint_0);
		method_6(ulong_, @struct.uint_1, @struct.class66_0, new object[0]);
	}

	public unsafe object method_2(uint uint_0, object[] object_0)
	{
		Struct4 @struct = method_0().method_4(uint_0);
		ulong ulong_ = (ulong)(method_0().b6037d70() + @struct.uint_0);
		return method_6(ulong_, @struct.uint_1, @struct.class66_0, object_0);
	}

	public object method_3(ulong ulong_0, uint uint_0, uint uint_1, object[] object_0)
	{
		Class66 class66_ = method_0().method_4(uint_1).class66_0;
		return method_6(ulong_0, uint_0, class66_, object_0);
	}

	public unsafe void method_4(uint uint_0, void*[] pVoid_0, void* pVoid_1)
	{
		Struct4 @struct = method_0().method_4(uint_0);
		ulong ulong_ = (ulong)(method_0().b6037d70() + @struct.uint_0);
		method_7(ulong_, @struct.uint_1, @struct.class66_0, pVoid_0, pVoid_1);
	}

	public unsafe void method_5(ulong ulong_0, uint uint_0, uint uint_1, void*[] pVoid_0, void* pVoid_1)
	{
		Class66 class66_ = method_0().method_4(uint_1).class66_0;
		method_7(ulong_0, uint_0, class66_, pVoid_0, pVoid_1);
	}

	private object method_6(ulong ulong_0, uint uint_0, Class66 class66_0, object[] object_0)
	{
		if (class54_0 != null)
		{
			stack_0.Push(class54_0);
		}
		class54_0 = new Class54(this);
		try
		{
			class54_0.class55_0.method_1((uint)(object_0.Length + 1));
			for (uint num = 0u; num < object_0.Length; num++)
			{
				class54_0.class55_0.method_0(num + 1, feeb32c3.smethod_0(object_0[num], class66_0.method_0()[num]));
			}
			Class55 class55_ = class54_0.class55_0;
			int uint_ = object_0.Length + 1;
			feeb32c3 feeb32c3_ = default(feeb32c3);
			feeb32c3_.b67abfed(1uL);
			class55_.method_0((uint)uint_, feeb32c3_);
			feeb32c3[] feeb32c3_2 = class54_0.feeb32c3_0;
			byte byte_ = c34ccaf0.byte_5;
			feeb32c3_ = default(feeb32c3);
			feeb32c3_.method_1(uint_0);
			feeb32c3_2[byte_] = feeb32c3_;
			feeb32c3[] feeb32c3_3 = class54_0.feeb32c3_0;
			byte d51d = c34ccaf0.d51d7317;
			feeb32c3_ = default(feeb32c3);
			feeb32c3_.method_1(0u);
			feeb32c3_3[d51d] = feeb32c3_;
			feeb32c3[] feeb32c3_4 = class54_0.feeb32c3_0;
			byte byte_2 = c34ccaf0.byte_3;
			feeb32c3_ = default(feeb32c3);
			feeb32c3_.method_1((uint)(object_0.Length + 1));
			feeb32c3_4[byte_2] = feeb32c3_;
			feeb32c3[] feeb32c3_5 = class54_0.feeb32c3_0;
			byte cb = c34ccaf0.cb256761;
			feeb32c3_ = default(feeb32c3);
			feeb32c3_.b67abfed(ulong_0);
			feeb32c3_5[cb] = feeb32c3_;
			e52f2e1.smethod_0(class54_0);
			object result = null;
			if ((object)class66_0.method_1() != typeof(void))
			{
				feeb32c3 feeb32c4 = class54_0.feeb32c3_0[c34ccaf0.byte_0];
				result = ((Type.GetTypeCode(class66_0.method_1()) != TypeCode.String || feeb32c4.cc3408c2() != null) ? feeb32c4.method_9(class66_0.method_1()) : method_0().method_3(feeb32c4.method_0()));
			}
			return result;
		}
		finally
		{
			class54_0.class55_0.method_3();
			if (stack_0.Count > 0)
			{
				class54_0 = stack_0.Pop();
			}
		}
	}

	private unsafe void method_7(ulong ulong_0, uint uint_0, Class66 class66_0, void*[] pVoid_0, void* pVoid_1)
	{
		if (class54_0 != null)
		{
			stack_0.Push(class54_0);
		}
		class54_0 = new Class54(this);
		try
		{
			class54_0.class55_0.method_1((uint)(pVoid_0.Length + 1));
			feeb32c3 feeb32c3_;
			for (uint num = 0u; num < pVoid_0.Length; num++)
			{
				Type type = class66_0.method_0()[num];
				if (type.IsByRef)
				{
					Class55 class55_ = class54_0.class55_0;
					uint uint_ = num + 1;
					feeb32c3_ = default(feeb32c3);
					feeb32c3_.method_7(new Class53(Struct1.smethod_0(pVoid_0[num])));
					class55_.method_0(uint_, feeb32c3_);
				}
				else
				{
					TypedReference typedReference = *(TypedReference*)pVoid_0[num];
					class54_0.class55_0.method_0(num + 1, feeb32c3.smethod_0(TypedReference.ToObject(typedReference), __reftype(typedReference)));
				}
			}
			Class55 class55_2 = class54_0.class55_0;
			int uint_2 = pVoid_0.Length + 1;
			feeb32c3_ = default(feeb32c3);
			feeb32c3_.b67abfed(1uL);
			class55_2.method_0((uint)uint_2, feeb32c3_);
			feeb32c3[] feeb32c3_2 = class54_0.feeb32c3_0;
			byte byte_ = c34ccaf0.byte_5;
			feeb32c3_ = default(feeb32c3);
			feeb32c3_.method_1(uint_0);
			feeb32c3_2[byte_] = feeb32c3_;
			feeb32c3[] feeb32c3_3 = class54_0.feeb32c3_0;
			byte d51d = c34ccaf0.d51d7317;
			feeb32c3_ = default(feeb32c3);
			feeb32c3_.method_1(0u);
			feeb32c3_3[d51d] = feeb32c3_;
			feeb32c3[] feeb32c3_4 = class54_0.feeb32c3_0;
			byte byte_2 = c34ccaf0.byte_3;
			feeb32c3_ = default(feeb32c3);
			feeb32c3_.method_1((uint)(pVoid_0.Length + 1));
			feeb32c3_4[byte_2] = feeb32c3_;
			feeb32c3[] feeb32c3_5 = class54_0.feeb32c3_0;
			byte cb = c34ccaf0.cb256761;
			feeb32c3_ = default(feeb32c3);
			feeb32c3_.b67abfed(ulong_0);
			feeb32c3_5[cb] = feeb32c3_;
			e52f2e1.smethod_0(class54_0);
			if ((object)class66_0.method_1() == typeof(void))
			{
				return;
			}
			if (class66_0.method_1().IsByRef)
			{
				object obj = class54_0.feeb32c3_0[c34ccaf0.byte_0].cc3408c2();
				if (!(obj is Interface2))
				{
					throw new ExecutionEngineException();
				}
				((Interface2)obj).imethod_3(class54_0, Struct1.smethod_0(pVoid_1), class66_0.method_1().GetElementType());
			}
			else
			{
				feeb32c3 feeb32c4 = class54_0.feeb32c3_0[c34ccaf0.byte_0];
				object object_ = ((Type.GetTypeCode(class66_0.method_1()) != TypeCode.String || feeb32c4.cc3408c2() != null) ? feeb32c4.method_9(class66_0.method_1()) : method_0().method_3(feeb32c4.method_0()));
				Class59.c380ab5c(object_, Struct1.smethod_0(pVoid_1));
			}
		}
		finally
		{
			class54_0.class55_0.method_3();
			if (stack_0.Count > 0)
			{
				class54_0 = stack_0.Pop();
			}
		}
	}
}
