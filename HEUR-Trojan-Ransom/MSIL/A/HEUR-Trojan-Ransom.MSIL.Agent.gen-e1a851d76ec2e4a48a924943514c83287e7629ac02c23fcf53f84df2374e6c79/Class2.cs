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

	private static Dictionary<Module, int> dictionary_1 = new Dictionary<Module, int>();

	private Stack<Class62> b0beaa2f = new Stack<Class62>();

	private Class62 cc8351c2;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private f90590 ed9f6639;

	public static Class2 da79a168(Module module_0)
	{
		if (dictionary_0 == null)
		{
			dictionary_0 = new Dictionary<Module, Class2>();
		}
		if (!dictionary_0.TryGetValue(module_0, out var value))
		{
			value = new Class2(f90590.da79a168(module_0));
			dictionary_0[module_0] = value;
			lock (object_0)
			{
				if (!dictionary_1.ContainsKey(module_0))
				{
					value.method_0();
					dictionary_1.Add(module_0, dictionary_1.Count);
				}
			}
		}
		return value;
	}

	public static Class2 da79a168(int int_0)
	{
		foreach (KeyValuePair<Module, int> item in dictionary_1)
		{
			if (item.Value == int_0)
			{
				return da79a168(item.Key);
			}
		}
		return null;
	}

	public static int smethod_0(Module module_0)
	{
		return dictionary_1[module_0];
	}

	private Class2(f90590 f90590_0)
	{
		d98df871(f90590_0);
	}

	[SpecialName]
	public f90590 de5d16da()
	{
		return ed9f6639;
	}

	[SpecialName]
	private void d98df871(f90590 f90590_0)
	{
		ed9f6639 = f90590_0;
	}

	private unsafe void method_0()
	{
		Struct3 @struct = de5d16da().method_5(Class69.eab7839f);
		ulong ulong_ = (ulong)(de5d16da().method_1() + @struct.f55f66d5);
		method_5(ulong_, @struct.c00d0a30, @struct.class71_0, new object[0]);
	}

	public unsafe object method_1(uint uint_0, object[] object_1)
	{
		Struct3 @struct = de5d16da().method_5(uint_0);
		ulong ulong_ = (ulong)(de5d16da().method_1() + @struct.f55f66d5);
		return method_5(ulong_, @struct.c00d0a30, @struct.class71_0, object_1);
	}

	public object method_2(ulong ulong_0, uint uint_0, uint uint_1, object[] object_1)
	{
		Class71 class71_ = de5d16da().method_5(uint_1).class71_0;
		return method_5(ulong_0, uint_0, class71_, object_1);
	}

	public unsafe void method_3(uint uint_0, void*[] pVoid_0, void* pVoid_1)
	{
		Struct3 @struct = de5d16da().method_5(uint_0);
		ulong ulong_ = (ulong)(de5d16da().method_1() + @struct.f55f66d5);
		method_6(ulong_, @struct.c00d0a30, @struct.class71_0, pVoid_0, pVoid_1);
	}

	public unsafe void method_4(ulong ulong_0, uint uint_0, uint uint_1, void*[] pVoid_0, void* pVoid_1)
	{
		Class71 class71_ = de5d16da().method_5(uint_1).class71_0;
		method_6(ulong_0, uint_0, class71_, pVoid_0, pVoid_1);
	}

	private object method_5(ulong ulong_0, uint uint_0, Class71 class71_0, object[] object_1)
	{
		if (cc8351c2 != null)
		{
			b0beaa2f.Push(cc8351c2);
		}
		cc8351c2 = new Class62(this);
		try
		{
			cc8351c2.class64_0.method_2((uint)(object_1.Length + 1));
			for (uint num = 0u; num < object_1.Length; num++)
			{
				cc8351c2.class64_0.method_1(num + 1, ebd9b488.e37ec81d(object_1[num], class71_0.d379c4d9()[num]));
			}
			Class64 class64_ = cc8351c2.class64_0;
			int uint_ = object_1.Length + 1;
			ebd9b488 ebd9b488_ = default(ebd9b488);
			ebd9b488_.eca936fa(1uL);
			class64_.method_1((uint)uint_, ebd9b488_);
			ebd9b488[] ebd9b488_2 = cc8351c2.ebd9b488_0;
			byte ac2dcb = Class69.ac2dcb60;
			ebd9b488_ = default(ebd9b488);
			ebd9b488_.cf774c3c(uint_0);
			ebd9b488_2[ac2dcb] = ebd9b488_;
			ebd9b488[] ebd9b488_3 = cc8351c2.ebd9b488_0;
			byte ad8cd76c = Class69.ad8cd76c;
			ebd9b488_ = default(ebd9b488);
			ebd9b488_.cf774c3c(0u);
			ebd9b488_3[ad8cd76c] = ebd9b488_;
			ebd9b488[] ebd9b488_4 = cc8351c2.ebd9b488_0;
			byte byte_ = Class69.byte_4;
			ebd9b488_ = default(ebd9b488);
			ebd9b488_.cf774c3c((uint)(object_1.Length + 1));
			ebd9b488_4[byte_] = ebd9b488_;
			ebd9b488[] ebd9b488_5 = cc8351c2.ebd9b488_0;
			byte byte_2 = Class69.byte_5;
			ebd9b488_ = default(ebd9b488);
			ebd9b488_.eca936fa(ulong_0);
			ebd9b488_5[byte_2] = ebd9b488_;
			Class63.smethod_0(cc8351c2);
			object result = null;
			if ((object)class71_0.b73d6864() != typeof(void))
			{
				ebd9b488 ebd9b489 = cc8351c2.ebd9b488_0[Class69.e29d8f44];
				result = ((Type.GetTypeCode(class71_0.b73d6864()) != TypeCode.String || ebd9b489.ec0d6773() != null) ? ebd9b489.method_5(class71_0.b73d6864()) : de5d16da().method_4(ebd9b489.b585a11()));
			}
			return result;
		}
		finally
		{
			cc8351c2.class64_0.method_4();
			if (b0beaa2f.Count > 0)
			{
				cc8351c2 = b0beaa2f.Pop();
			}
		}
	}

	private unsafe void method_6(ulong ulong_0, uint uint_0, Class71 class71_0, void*[] pVoid_0, void* pVoid_1)
	{
		if (cc8351c2 != null)
		{
			b0beaa2f.Push(cc8351c2);
		}
		cc8351c2 = new Class62(this);
		try
		{
			cc8351c2.class64_0.method_2((uint)(pVoid_0.Length + 1));
			ebd9b488 ebd9b488_;
			for (uint num = 0u; num < pVoid_0.Length; num++)
			{
				Type type = class71_0.d379c4d9()[num];
				if (type.IsByRef)
				{
					Class64 class64_ = cc8351c2.class64_0;
					uint uint_ = num + 1;
					ebd9b488_ = default(ebd9b488);
					ebd9b488_.aa900636(new d4882090(f06aee96.smethod_0(pVoid_0[num])));
					class64_.method_1(uint_, ebd9b488_);
				}
				else
				{
					TypedReference typedReference = *(TypedReference*)pVoid_0[num];
					cc8351c2.class64_0.method_1(num + 1, ebd9b488.e37ec81d(TypedReference.ToObject(typedReference), __reftype(typedReference)));
				}
			}
			Class64 class64_2 = cc8351c2.class64_0;
			int uint_2 = pVoid_0.Length + 1;
			ebd9b488_ = default(ebd9b488);
			ebd9b488_.eca936fa(1uL);
			class64_2.method_1((uint)uint_2, ebd9b488_);
			ebd9b488[] ebd9b488_2 = cc8351c2.ebd9b488_0;
			byte ac2dcb = Class69.ac2dcb60;
			ebd9b488_ = default(ebd9b488);
			ebd9b488_.cf774c3c(uint_0);
			ebd9b488_2[ac2dcb] = ebd9b488_;
			ebd9b488[] ebd9b488_3 = cc8351c2.ebd9b488_0;
			byte ad8cd76c = Class69.ad8cd76c;
			ebd9b488_ = default(ebd9b488);
			ebd9b488_.cf774c3c(0u);
			ebd9b488_3[ad8cd76c] = ebd9b488_;
			ebd9b488[] ebd9b488_4 = cc8351c2.ebd9b488_0;
			byte byte_ = Class69.byte_4;
			ebd9b488_ = default(ebd9b488);
			ebd9b488_.cf774c3c((uint)(pVoid_0.Length + 1));
			ebd9b488_4[byte_] = ebd9b488_;
			ebd9b488[] ebd9b488_5 = cc8351c2.ebd9b488_0;
			byte byte_2 = Class69.byte_5;
			ebd9b488_ = default(ebd9b488);
			ebd9b488_.eca936fa(ulong_0);
			ebd9b488_5[byte_2] = ebd9b488_;
			Class63.smethod_0(cc8351c2);
			if ((object)class71_0.b73d6864() == typeof(void))
			{
				return;
			}
			if (class71_0.b73d6864().IsByRef)
			{
				object obj = cc8351c2.ebd9b488_0[Class69.e29d8f44].ec0d6773();
				if (!(obj is Interface1))
				{
					throw new ExecutionEngineException();
				}
				((Interface1)obj).imethod_3(cc8351c2, f06aee96.smethod_0(pVoid_1), class71_0.b73d6864().GetElementType());
			}
			else
			{
				ebd9b488 ebd9b489 = cc8351c2.ebd9b488_0[Class69.e29d8f44];
				object obj2 = ((Type.GetTypeCode(class71_0.b73d6864()) != TypeCode.String || ebd9b489.ec0d6773() != null) ? ebd9b489.method_5(class71_0.b73d6864()) : de5d16da().method_4(ebd9b489.b585a11()));
				bc2a451.smethod_4(obj2, f06aee96.smethod_0(pVoid_1));
			}
		}
		finally
		{
			cc8351c2.class64_0.method_4();
			if (b0beaa2f.Count > 0)
			{
				cc8351c2 = b0beaa2f.Pop();
			}
		}
	}
}
