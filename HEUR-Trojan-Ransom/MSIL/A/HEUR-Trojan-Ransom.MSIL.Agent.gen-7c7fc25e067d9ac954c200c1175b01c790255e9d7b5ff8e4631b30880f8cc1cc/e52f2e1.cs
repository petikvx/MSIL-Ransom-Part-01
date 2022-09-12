using System;
using System.Text;

internal static class e52f2e1
{
	private static uint ee727f4 = (uint)Environment.TickCount;

	public static a0aa499b smethod_0(Class54 class54_0)
	{
		a0aa499b a0aa499b_ = (a0aa499b)0;
		bool flag = true;
		do
		{
			try
			{
				a0aa499b_ = bb63eecc(class54_0);
				switch (a0aa499b_)
				{
				case (a0aa499b)3:
				{
					uint uint_2 = class54_0.feeb32c3_0[c34ccaf0.byte_3].method_0();
					feeb32c3 feeb32c5 = class54_0.class55_0.ff4c393f(uint_2--);
					class54_0.feeb32c3_0[c34ccaf0.byte_3].method_1(uint_2);
					smethod_1(class54_0, feeb32c5.cc3408c2());
					return a0aa499b_;
				}
				case (a0aa499b)2:
				{
					uint uint_ = class54_0.feeb32c3_0[c34ccaf0.byte_3].method_0();
					feeb32c3 feeb32c4 = class54_0.class55_0.ff4c393f(uint_--);
					class54_0.feeb32c3_0[c34ccaf0.byte_3].method_1(uint_);
					smethod_3(class54_0, feeb32c4.cc3408c2());
					break;
				}
				}
				flag = false;
			}
			catch (object object_)
			{
				e3935bbb(class54_0, object_);
				flag = false;
			}
			finally
			{
				if (flag)
				{
					c7458ff2(class54_0);
					a0aa499b_ = (a0aa499b)1;
				}
				else if (class54_0.list_0.Count > 0)
				{
					do
					{
						smethod_4(class54_0, ref a0aa499b_);
					}
					while (a0aa499b_ == (a0aa499b)3);
				}
			}
		}
		while (a0aa499b_ != (a0aa499b)1);
		return a0aa499b_;
	}

	private static a0aa499b bb63eecc(Class54 class54_0)
	{
		a0aa499b a0aa499b_;
		do
		{
			byte byte_ = class54_0.method_0();
			class54_0.method_0();
			Class62.ff226187(byte_).imethod_1(class54_0, out a0aa499b_);
			if (class54_0.feeb32c3_0[c34ccaf0.cb256761].d9a53946() == 1L)
			{
				a0aa499b_ = (a0aa499b)1;
			}
		}
		while (a0aa499b_ == (a0aa499b)0);
		return a0aa499b_;
	}

	private static void e3935bbb(Class54 class54_0, object object_0)
	{
		Class51 @class;
		if (class54_0.list_0.Count != 0)
		{
			@class = class54_0.list_0[class54_0.list_0.Count - 1];
			if (@class.nullable_0.HasValue)
			{
				if (@class.ec0917d6 == (Class51.Enum0)0)
				{
					class54_0.feeb32c3_0[c34ccaf0.c27061a2].e885eacb(0);
				}
				else if (@class.ec0917d6 == (Class51.Enum0)1)
				{
					@class.object_0 = object_0;
				}
				return;
			}
		}
		@class = new Class51
		{
			ceb1cd78 = class54_0.feeb32c3_0[c34ccaf0.d51d7317],
			a40c3277 = class54_0.feeb32c3_0[c34ccaf0.byte_3],
			object_0 = object_0,
			ec0917d6 = (Class51.Enum0)0,
			nullable_0 = null,
			b0883dc1 = null
		};
		class54_0.list_0.Add(@class);
	}

	private static void smethod_1(Class54 class54_0, object object_0)
	{
		if (class54_0.list_0.Count > 0)
		{
			e3935bbb(class54_0, object_0);
		}
		else
		{
			smethod_3(class54_0, object_0);
		}
	}

	private unsafe static string smethod_2(Class54 class54_0)
	{
		uint num = (uint)(class54_0.feeb32c3_0[c34ccaf0.cb256761].d9a53946() - (ulong)class54_0.class1_0.method_0().b6037d70());
		uint num2 = class54_0.feeb32c3_0[c34ccaf0.d51d7317].method_0();
		StringBuilder stringBuilder = new StringBuilder();
		do
		{
			ee727f4 = ee727f4 * 1664525 + 1013904223;
			ulong num3 = ee727f4 | 1u;
			stringBuilder.AppendFormat("|{0:x16}", (num * num3 << 32) | (num3 & 0xFFFFFFFFFFFFFFFEuL));
			if (num2 <= 1)
			{
				break;
			}
			num = (uint)(class54_0.class55_0.ff4c393f(num2 - 1).d9a53946() - (ulong)class54_0.class1_0.method_0().b6037d70());
			if (!(class54_0.class55_0.ff4c393f(num2).cc3408c2() is d6c76087 d6c76088))
			{
				break;
			}
			num2 = d6c76088.method_0();
		}
		while (num2 != 0);
		return stringBuilder.ToString(1, stringBuilder.Length - 1);
	}

	internal static void smethod_3(Class54 class54_0, object object_0)
	{
		if (object_0 is Exception)
		{
			Class57.a09b3200((Exception)object_0, null);
		}
		throw object_0;
	}

	private static void smethod_4(Class54 class54_0, ref a0aa499b a0aa499b_0)
	{
		Class51 @class = class54_0.list_0[class54_0.list_0.Count - 1];
		switch (@class.ec0917d6)
		{
		default:
			throw new ExecutionEngineException();
		case (Class51.Enum0)0:
		{
			if (@class.nullable_0.HasValue)
			{
				if (class54_0.feeb32c3_0[c34ccaf0.c27061a2].f939861c() != 0)
				{
					@class.ec0917d6 = (Class51.Enum0)1;
					@class.b0883dc1 = @class.nullable_0;
					@class.nullable_0 = class54_0.d6265297.Count;
					a0aa499b_0 = (a0aa499b)0;
					goto case (Class51.Enum0)1;
				}
				@class.nullable_0--;
			}
			else
			{
				@class.nullable_0 = class54_0.d6265297.Count - 1;
			}
			Type type = @class.object_0.GetType();
			while (true)
			{
				if (@class.nullable_0 >= 0 && !@class.b0883dc1.HasValue)
				{
					eec46a6e eec46a6e2 = class54_0.d6265297[@class.nullable_0.Value];
					if (eec46a6e2.byte_0 != c34ccaf0.c8a44da3)
					{
						if (eec46a6e2.byte_0 == c34ccaf0.af95d654 && eec46a6e2.type_0.IsAssignableFrom(type))
						{
							break;
						}
						@class.nullable_0--;
						continue;
					}
					uint num = @class.a40c3277.method_0();
					class54_0.class55_0.method_1(++num);
					Class55 class55_ = class54_0.class55_0;
					uint uint_ = num;
					feeb32c3 feeb32c3_ = default(feeb32c3);
					feeb32c3_.method_7(@class.object_0);
					class55_.method_0(uint_, feeb32c3_);
					class54_0.feeb32c3_0[c34ccaf0.byte_5].e885eacb(0);
					class54_0.feeb32c3_0[c34ccaf0.byte_3].method_1(num);
					class54_0.feeb32c3_0[c34ccaf0.d51d7317] = eec46a6e2.c9adfef9;
					class54_0.feeb32c3_0[c34ccaf0.cb256761].b67abfed(eec46a6e2.a749f3d0);
				}
				if (@class.nullable_0 == -1 && !@class.b0883dc1.HasValue)
				{
					class54_0.list_0.RemoveAt(class54_0.list_0.Count - 1);
					a0aa499b_0 = (a0aa499b)3;
					if (class54_0.list_0.Count == 0)
					{
						smethod_1(class54_0, @class.object_0);
					}
				}
				else
				{
					a0aa499b_0 = (a0aa499b)0;
				}
				return;
			}
			@class.ec0917d6 = (Class51.Enum0)1;
			@class.b0883dc1 = @class.nullable_0;
			@class.nullable_0 = class54_0.d6265297.Count;
			goto case (Class51.Enum0)1;
		}
		case (Class51.Enum0)1:
		{
			@class.nullable_0--;
			int num2 = @class.nullable_0.Value;
			while (num2 > @class.b0883dc1.Value)
			{
				eec46a6e eec46a6e_ = class54_0.d6265297[num2];
				class54_0.d6265297.RemoveAt(num2);
				if (eec46a6e_.byte_0 != c34ccaf0.byte_73 && eec46a6e_.byte_0 != c34ccaf0.byte_74)
				{
					num2--;
					continue;
				}
				smethod_5(class54_0, eec46a6e_);
				break;
			}
			@class.nullable_0 = num2;
			if (@class.nullable_0 == @class.b0883dc1)
			{
				eec46a6e eec46a6e3 = class54_0.d6265297[@class.b0883dc1.Value];
				class54_0.d6265297.RemoveAt(@class.b0883dc1.Value);
				ref feeb32c3 b42d1c = ref eec46a6e3.b42d1c04;
				uint num3 = b42d1c.method_0();
				b42d1c.method_1(num3 + 1);
				class54_0.class55_0.method_1(eec46a6e3.b42d1c04.method_0());
				Class55 class55_2 = class54_0.class55_0;
				uint uint_2 = eec46a6e3.b42d1c04.method_0();
				feeb32c3 feeb32c3_ = default(feeb32c3);
				feeb32c3_.method_7(@class.object_0);
				class55_2.method_0(uint_2, feeb32c3_);
				class54_0.feeb32c3_0[c34ccaf0.byte_5].e885eacb(0);
				class54_0.feeb32c3_0[c34ccaf0.byte_3] = eec46a6e3.b42d1c04;
				class54_0.feeb32c3_0[c34ccaf0.d51d7317] = eec46a6e3.c9adfef9;
				class54_0.feeb32c3_0[c34ccaf0.cb256761].b67abfed(eec46a6e3.ulong_0);
				class54_0.list_0.RemoveAt(class54_0.list_0.Count - 1);
			}
			a0aa499b_0 = (a0aa499b)0;
			break;
		}
		}
	}

	private static void c7458ff2(Class54 class54_0)
	{
		for (int num = class54_0.d6265297.Count - 1; num >= 0; num--)
		{
			eec46a6e eec46a6e_ = class54_0.d6265297[num];
			if (eec46a6e_.byte_0 == c34ccaf0.byte_73 || eec46a6e_.byte_0 == c34ccaf0.byte_74)
			{
				smethod_5(class54_0, eec46a6e_);
				smethod_0(class54_0);
			}
		}
		class54_0.d6265297.Clear();
	}

	private static void smethod_5(Class54 class54_0, eec46a6e eec46a6e_0)
	{
		ref feeb32c3 b42d1c = ref eec46a6e_0.b42d1c04;
		uint num = b42d1c.method_0();
		b42d1c.method_1(num + 1);
		class54_0.feeb32c3_0[c34ccaf0.byte_5].e885eacb(0);
		class54_0.feeb32c3_0[c34ccaf0.byte_3] = eec46a6e_0.b42d1c04;
		class54_0.feeb32c3_0[c34ccaf0.d51d7317] = eec46a6e_0.c9adfef9;
		class54_0.feeb32c3_0[c34ccaf0.cb256761].b67abfed(eec46a6e_0.ulong_0);
		Class55 class55_ = class54_0.class55_0;
		uint uint_ = eec46a6e_0.b42d1c04.method_0();
		feeb32c3 feeb32c3_ = default(feeb32c3);
		feeb32c3_.b67abfed(1uL);
		class55_.method_0(uint_, feeb32c3_);
	}
}
