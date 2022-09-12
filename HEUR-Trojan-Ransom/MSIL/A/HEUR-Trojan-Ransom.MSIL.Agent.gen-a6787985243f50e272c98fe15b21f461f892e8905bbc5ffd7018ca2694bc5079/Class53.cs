using System;
using System.Text;

internal static class Class53
{
	private static uint uint_0 = (uint)Environment.TickCount;

	public static a82ced3b smethod_0(Class52 class52_0)
	{
		a82ced3b a82ced3b_ = (a82ced3b)0;
		bool flag = true;
		do
		{
			try
			{
				a82ced3b_ = smethod_1(class52_0);
				switch (a82ced3b_)
				{
				case (a82ced3b)3:
				{
					uint uint_2 = class52_0.struct2_0[fae0f10.byte_5].b5683088();
					Struct2 struct2 = class52_0.c6a36180_0.f113e6df(uint_2--);
					class52_0.struct2_0[fae0f10.byte_5].b3579a47(uint_2);
					smethod_3(class52_0, struct2.a90ed1e2());
					return a82ced3b_;
				}
				case (a82ced3b)2:
				{
					uint uint_ = class52_0.struct2_0[fae0f10.byte_5].b5683088();
					Struct2 @struct = class52_0.c6a36180_0.f113e6df(uint_--);
					class52_0.struct2_0[fae0f10.byte_5].b3579a47(uint_);
					f0a834e0(class52_0, @struct.a90ed1e2());
					break;
				}
				}
				flag = false;
			}
			catch (object object_)
			{
				smethod_2(class52_0, object_);
				flag = false;
			}
			finally
			{
				if (flag)
				{
					smethod_4(class52_0);
					a82ced3b_ = (a82ced3b)1;
				}
				else if (class52_0.e9b2ac2a.Count > 0)
				{
					do
					{
						a3eae2bf(class52_0, ref a82ced3b_);
					}
					while (a82ced3b_ == (a82ced3b)3);
				}
			}
		}
		while (a82ced3b_ != (a82ced3b)1);
		return a82ced3b_;
	}

	private static a82ced3b smethod_1(Class52 class52_0)
	{
		a82ced3b a82ced3b_;
		do
		{
			byte byte_ = class52_0.method_0();
			class52_0.method_0();
			Class60.smethod_0(byte_).imethod_0(class52_0, out a82ced3b_);
			if (class52_0.struct2_0[fae0f10.d1e82201].method_0() == 1L)
			{
				a82ced3b_ = (a82ced3b)1;
			}
		}
		while (a82ced3b_ == (a82ced3b)0);
		return a82ced3b_;
	}

	private static void smethod_2(Class52 class52_0, object object_0)
	{
		b993a733 b993a734;
		if (class52_0.e9b2ac2a.Count != 0)
		{
			b993a734 = class52_0.e9b2ac2a[class52_0.e9b2ac2a.Count - 1];
			if (b993a734.a610ba8a.HasValue)
			{
				if (b993a734.d187c2f6 == (b993a733.Enum0)0)
				{
					class52_0.struct2_0[fae0f10.ea21dac2].b65cc66b(0);
				}
				else if (b993a734.d187c2f6 == (b993a733.Enum0)1)
				{
					b993a734.object_0 = object_0;
				}
				return;
			}
		}
		b993a734 = new b993a733
		{
			struct2_0 = class52_0.struct2_0[fae0f10.byte_4],
			d5950c17 = class52_0.struct2_0[fae0f10.byte_5],
			object_0 = object_0,
			d187c2f6 = (b993a733.Enum0)0,
			a610ba8a = null,
			nullable_0 = null
		};
		class52_0.e9b2ac2a.Add(b993a734);
	}

	private static void smethod_3(Class52 class52_0, object object_0)
	{
		if (class52_0.e9b2ac2a.Count > 0)
		{
			smethod_2(class52_0, object_0);
		}
		else
		{
			f0a834e0(class52_0, object_0);
		}
	}

	private unsafe static string ad73c045(Class52 class52_0)
	{
		uint num = (uint)(class52_0.struct2_0[fae0f10.d1e82201].method_0() - (ulong)class52_0.c8dafbc3.method_0().f1a90190());
		uint num2 = class52_0.struct2_0[fae0f10.byte_4].b5683088();
		StringBuilder stringBuilder = new StringBuilder();
		do
		{
			uint_0 = uint_0 * 1664525 + 1013904223;
			ulong num3 = uint_0 | 1u;
			stringBuilder.AppendFormat("|{0:x16}", (num * num3 << 32) | (num3 & 0xFFFFFFFFFFFFFFFEuL));
			if (num2 <= 1)
			{
				break;
			}
			num = (uint)(class52_0.c6a36180_0.f113e6df(num2 - 1).method_0() - (ulong)class52_0.c8dafbc3.method_0().f1a90190());
			if (!(class52_0.c6a36180_0.f113e6df(num2).a90ed1e2() is a32d2227 a32d2228))
			{
				break;
			}
			num2 = a32d2228.d724395a();
		}
		while (num2 != 0);
		return stringBuilder.ToString(1, stringBuilder.Length - 1);
	}

	internal static void f0a834e0(Class52 class52_0, object object_0)
	{
		if (object_0 is Exception)
		{
			ac56c39b.smethod_0((Exception)object_0, null);
		}
		throw object_0;
	}

	private static void a3eae2bf(Class52 class52_0, ref a82ced3b a82ced3b_0)
	{
		b993a733 b993a734 = class52_0.e9b2ac2a[class52_0.e9b2ac2a.Count - 1];
		switch (b993a734.d187c2f6)
		{
		default:
			throw new ExecutionEngineException();
		case (b993a733.Enum0)0:
		{
			if (b993a734.a610ba8a.HasValue)
			{
				if (class52_0.struct2_0[fae0f10.ea21dac2].method_3() != 0)
				{
					b993a734.d187c2f6 = (b993a733.Enum0)1;
					b993a734.nullable_0 = b993a734.a610ba8a;
					b993a734.a610ba8a = class52_0.b842fc37.Count;
					a82ced3b_0 = (a82ced3b)0;
					goto case (b993a733.Enum0)1;
				}
				b993a734.a610ba8a--;
			}
			else
			{
				b993a734.a610ba8a = class52_0.b842fc37.Count - 1;
			}
			Type type = b993a734.object_0.GetType();
			while (true)
			{
				if (b993a734.a610ba8a >= 0 && !b993a734.nullable_0.HasValue)
				{
					ef6a318e ef6a318e2 = class52_0.b842fc37[b993a734.a610ba8a.Value];
					if (ef6a318e2.byte_0 != fae0f10.byte_55)
					{
						if (ef6a318e2.byte_0 == fae0f10.ef8a8474 && ef6a318e2.type_0.IsAssignableFrom(type))
						{
							break;
						}
						b993a734.a610ba8a--;
						continue;
					}
					uint num = b993a734.d5950c17.b5683088();
					class52_0.c6a36180_0.method_0(++num);
					c6a36180 c6a36180_ = class52_0.c6a36180_0;
					uint uint_ = num;
					Struct2 struct2_ = default(Struct2);
					struct2_.method_7(b993a734.object_0);
					c6a36180_.f43586b2(uint_, struct2_);
					class52_0.struct2_0[fae0f10.ccfef7db].b65cc66b(0);
					class52_0.struct2_0[fae0f10.byte_5].b3579a47(num);
					class52_0.struct2_0[fae0f10.byte_4] = ef6a318e2.struct2_0;
					class52_0.struct2_0[fae0f10.d1e82201].f6b2288d(ef6a318e2.ulong_0);
				}
				if (b993a734.a610ba8a == -1 && !b993a734.nullable_0.HasValue)
				{
					class52_0.e9b2ac2a.RemoveAt(class52_0.e9b2ac2a.Count - 1);
					a82ced3b_0 = (a82ced3b)3;
					if (class52_0.e9b2ac2a.Count == 0)
					{
						smethod_3(class52_0, b993a734.object_0);
					}
				}
				else
				{
					a82ced3b_0 = (a82ced3b)0;
				}
				return;
			}
			b993a734.d187c2f6 = (b993a733.Enum0)1;
			b993a734.nullable_0 = b993a734.a610ba8a;
			b993a734.a610ba8a = class52_0.b842fc37.Count;
			goto case (b993a733.Enum0)1;
		}
		case (b993a733.Enum0)1:
		{
			b993a734.a610ba8a--;
			int num2 = b993a734.a610ba8a.Value;
			while (num2 > b993a734.nullable_0.Value)
			{
				ef6a318e ef6a318e_ = class52_0.b842fc37[num2];
				class52_0.b842fc37.RemoveAt(num2);
				if (ef6a318e_.byte_0 != fae0f10.byte_56 && ef6a318e_.byte_0 != fae0f10.b7ac966d)
				{
					num2--;
					continue;
				}
				a9a47d49(class52_0, ef6a318e_);
				break;
			}
			b993a734.a610ba8a = num2;
			if (b993a734.a610ba8a == b993a734.nullable_0)
			{
				ef6a318e ef6a318e3 = class52_0.b842fc37[b993a734.nullable_0.Value];
				class52_0.b842fc37.RemoveAt(b993a734.nullable_0.Value);
				ref Struct2 struct2_2 = ref ef6a318e3.struct2_1;
				uint num3 = struct2_2.b5683088();
				struct2_2.b3579a47(num3 + 1);
				class52_0.c6a36180_0.method_0(ef6a318e3.struct2_1.b5683088());
				c6a36180 c6a36180_2 = class52_0.c6a36180_0;
				uint uint_2 = ef6a318e3.struct2_1.b5683088();
				Struct2 struct2_ = default(Struct2);
				struct2_.method_7(b993a734.object_0);
				c6a36180_2.f43586b2(uint_2, struct2_);
				class52_0.struct2_0[fae0f10.ccfef7db].b65cc66b(0);
				class52_0.struct2_0[fae0f10.byte_5] = ef6a318e3.struct2_1;
				class52_0.struct2_0[fae0f10.byte_4] = ef6a318e3.struct2_0;
				class52_0.struct2_0[fae0f10.d1e82201].f6b2288d(ef6a318e3.ulong_1);
				class52_0.e9b2ac2a.RemoveAt(class52_0.e9b2ac2a.Count - 1);
			}
			a82ced3b_0 = (a82ced3b)0;
			break;
		}
		}
	}

	private static void smethod_4(Class52 class52_0)
	{
		for (int num = class52_0.b842fc37.Count - 1; num >= 0; num--)
		{
			ef6a318e ef6a318e_ = class52_0.b842fc37[num];
			if (ef6a318e_.byte_0 == fae0f10.byte_56 || ef6a318e_.byte_0 == fae0f10.b7ac966d)
			{
				a9a47d49(class52_0, ef6a318e_);
				smethod_0(class52_0);
			}
		}
		class52_0.b842fc37.Clear();
	}

	private static void a9a47d49(Class52 class52_0, ef6a318e ef6a318e_0)
	{
		ref Struct2 struct2_ = ref ef6a318e_0.struct2_1;
		uint num = struct2_.b5683088();
		struct2_.b3579a47(num + 1);
		class52_0.struct2_0[fae0f10.ccfef7db].b65cc66b(0);
		class52_0.struct2_0[fae0f10.byte_5] = ef6a318e_0.struct2_1;
		class52_0.struct2_0[fae0f10.byte_4] = ef6a318e_0.struct2_0;
		class52_0.struct2_0[fae0f10.d1e82201].f6b2288d(ef6a318e_0.ulong_1);
		c6a36180 c6a36180_ = class52_0.c6a36180_0;
		uint uint_ = ef6a318e_0.struct2_1.b5683088();
		Struct2 struct2_2 = default(Struct2);
		struct2_2.f6b2288d(1uL);
		c6a36180_.f43586b2(uint_, struct2_2);
	}
}
