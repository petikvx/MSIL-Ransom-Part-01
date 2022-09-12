using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

internal class Class2
{
	[ThreadStatic]
	private static Dictionary<Module, Class2> dictionary_0;

	private static readonly object object_0 = new object();

	private static Dictionary<Module, int> f87d5b7e = new Dictionary<Module, int>();

	private Stack<fdc40966> bc8eccc5 = new Stack<fdc40966>();

	private fdc40966 b482d760;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Class65 class65_0;

	public static Class2 smethod_0(Module module_0)
	{
		if (dictionary_0 == null)
		{
			dictionary_0 = new Dictionary<Module, Class2>();
		}
		if (!dictionary_0.TryGetValue(module_0, out var value))
		{
			value = new Class2(Class65.smethod_0(module_0));
			dictionary_0[module_0] = value;
			lock (object_0)
			{
				if (!f87d5b7e.ContainsKey(module_0))
				{
					value.method_2();
					f87d5b7e.Add(module_0, f87d5b7e.Count);
				}
			}
		}
		return value;
	}

	public static Class2 smethod_1(int int_0)
	{
		foreach (KeyValuePair<Module, int> item in f87d5b7e)
		{
			if (item.Value == int_0)
			{
				return smethod_0(item.Key);
			}
		}
		return null;
	}

	public static int smethod_2(Module module_0)
	{
		return f87d5b7e[module_0];
	}

	private Class2(Class65 class65_1)
	{
		method_1(class65_1);
	}

	[SpecialName]
	public Class65 method_0()
	{
		return class65_0;
	}

	[SpecialName]
	private void method_1(Class65 class65_1)
	{
		class65_0 = class65_1;
	}

	private unsafe void method_2()
	{
		Struct5 @struct = method_0().method_5(fb3c043f.byte_68);
		ulong ulong_ = (ulong)(method_0().e6f174bf() + @struct.uint_0);
		method_7(ulong_, @struct.a645929e, @struct.b7d05965, new object[0]);
	}

	public unsafe object method_3(uint uint_0, object[] object_1)
	{
		Struct5 @struct = method_0().method_5(uint_0);
		ulong ulong_ = (ulong)(method_0().e6f174bf() + @struct.uint_0);
		return method_7(ulong_, @struct.a645929e, @struct.b7d05965, object_1);
	}

	public object method_4(ulong ulong_0, uint uint_0, uint uint_1, object[] object_1)
	{
		Class68 b7d = method_0().method_5(uint_1).b7d05965;
		return method_7(ulong_0, uint_0, b7d, object_1);
	}

	public unsafe void method_5(uint uint_0, void*[] pVoid_0, void* pVoid_1)
	{
		Struct5 @struct = method_0().method_5(uint_0);
		ulong ulong_ = (ulong)(method_0().e6f174bf() + @struct.uint_0);
		method_8(ulong_, @struct.a645929e, @struct.b7d05965, pVoid_0, pVoid_1);
	}

	public unsafe void method_6(ulong ulong_0, uint uint_0, uint uint_1, void*[] pVoid_0, void* pVoid_1)
	{
		Class68 b7d = method_0().method_5(uint_1).b7d05965;
		method_8(ulong_0, uint_0, b7d, pVoid_0, pVoid_1);
	}

	private object method_7(ulong ulong_0, uint uint_0, Class68 class68_0, object[] object_1)
	{
		if (b482d760 != null)
		{
			bc8eccc5.Push(b482d760);
		}
		b482d760 = new fdc40966(this);
		try
		{
			b482d760.class58_0.method_1((uint)(object_1.Length + 1));
			for (uint num = 0u; num < object_1.Length; num++)
			{
				b482d760.class58_0.b53f41f9(num + 1, Struct3.smethod_0(object_1[num], class68_0.method_0()[num]));
			}
			Class58 class58_ = b482d760.class58_0;
			int uint_ = object_1.Length + 1;
			Struct3 struct3_ = default(Struct3);
			struct3_.method_0(1uL);
			class58_.b53f41f9((uint)uint_, struct3_);
			Struct3[] struct3_2 = b482d760.struct3_0;
			byte byte_ = fb3c043f.byte_6;
			struct3_ = default(Struct3);
			struct3_.e63a4aca(uint_0);
			struct3_2[byte_] = struct3_;
			Struct3[] struct3_3 = b482d760.struct3_0;
			byte byte_2 = fb3c043f.byte_5;
			struct3_ = default(Struct3);
			struct3_.e63a4aca(0u);
			struct3_3[byte_2] = struct3_;
			Struct3[] struct3_4 = b482d760.struct3_0;
			byte c55b = fb3c043f.c55b5391;
			struct3_ = default(Struct3);
			struct3_.e63a4aca((uint)(object_1.Length + 1));
			struct3_4[c55b] = struct3_;
			Struct3[] struct3_5 = b482d760.struct3_0;
			byte ce86f7bc = fb3c043f.ce86f7bc;
			struct3_ = default(Struct3);
			struct3_.method_0(ulong_0);
			struct3_5[ce86f7bc] = struct3_;
			Class57.smethod_0(b482d760);
			object result = null;
			if ((object)class68_0.method_1() != typeof(void))
			{
				Struct3 @struct = b482d760.struct3_0[fb3c043f.byte_0];
				result = ((Type.GetTypeCode(class68_0.method_1()) != TypeCode.String || @struct.c9550f69() != null) ? @struct.e3ce4628(class68_0.method_1()) : method_0().method_4(@struct.method_1()));
			}
			return result;
		}
		finally
		{
			b482d760.class58_0.cf3316d6();
			if (bc8eccc5.Count > 0)
			{
				b482d760 = bc8eccc5.Pop();
			}
		}
	}

	private unsafe void method_8(ulong ulong_0, uint uint_0, Class68 class68_0, void*[] pVoid_0, void* pVoid_1)
	{
		if (b482d760 != null)
		{
			bc8eccc5.Push(b482d760);
		}
		b482d760 = new fdc40966(this);
		try
		{
			b482d760.class58_0.method_1((uint)(pVoid_0.Length + 1));
			Struct3 struct3_;
			for (uint num = 0u; num < pVoid_0.Length; num++)
			{
				Type type = class68_0.method_0()[num];
				if (type.IsByRef)
				{
					Class58 class58_ = b482d760.class58_0;
					uint uint_ = num + 1;
					struct3_ = default(Struct3);
					struct3_.db2591b4(new Class56(Struct2.smethod_0(pVoid_0[num])));
					class58_.b53f41f9(uint_, struct3_);
				}
				else
				{
					TypedReference typedReference = *(TypedReference*)pVoid_0[num];
					b482d760.class58_0.b53f41f9(num + 1, Struct3.smethod_0(TypedReference.ToObject(typedReference), __reftype(typedReference)));
				}
			}
			Class58 class58_2 = b482d760.class58_0;
			int uint_2 = pVoid_0.Length + 1;
			struct3_ = default(Struct3);
			struct3_.method_0(1uL);
			class58_2.b53f41f9((uint)uint_2, struct3_);
			Struct3[] struct3_2 = b482d760.struct3_0;
			byte byte_ = fb3c043f.byte_6;
			struct3_ = default(Struct3);
			struct3_.e63a4aca(uint_0);
			struct3_2[byte_] = struct3_;
			Struct3[] struct3_3 = b482d760.struct3_0;
			byte byte_2 = fb3c043f.byte_5;
			struct3_ = default(Struct3);
			struct3_.e63a4aca(0u);
			struct3_3[byte_2] = struct3_;
			Struct3[] struct3_4 = b482d760.struct3_0;
			byte c55b = fb3c043f.c55b5391;
			struct3_ = default(Struct3);
			struct3_.e63a4aca((uint)(pVoid_0.Length + 1));
			struct3_4[c55b] = struct3_;
			Struct3[] struct3_5 = b482d760.struct3_0;
			byte ce86f7bc = fb3c043f.ce86f7bc;
			struct3_ = default(Struct3);
			struct3_.method_0(ulong_0);
			struct3_5[ce86f7bc] = struct3_;
			Class57.smethod_0(b482d760);
			if ((object)class68_0.method_1() == typeof(void))
			{
				return;
			}
			if (class68_0.method_1().IsByRef)
			{
				object obj = b482d760.struct3_0[fb3c043f.byte_0].c9550f69();
				if (!(obj is Interface1))
				{
					throw new ExecutionEngineException();
				}
				((Interface1)obj).imethod_0(b482d760, Struct2.smethod_0(pVoid_1), class68_0.method_1().GetElementType());
			}
			else
			{
				Struct3 @struct = b482d760.struct3_0[fb3c043f.byte_0];
				object obj2 = ((Type.GetTypeCode(class68_0.method_1()) != TypeCode.String || @struct.c9550f69() != null) ? @struct.e3ce4628(class68_0.method_1()) : method_0().method_4(@struct.method_1()));
				Class61.smethod_3(obj2, Struct2.smethod_0(pVoid_1));
			}
		}
		finally
		{
			b482d760.class58_0.cf3316d6();
			if (bc8eccc5.Count > 0)
			{
				b482d760 = bc8eccc5.Pop();
			}
		}
	}
}
