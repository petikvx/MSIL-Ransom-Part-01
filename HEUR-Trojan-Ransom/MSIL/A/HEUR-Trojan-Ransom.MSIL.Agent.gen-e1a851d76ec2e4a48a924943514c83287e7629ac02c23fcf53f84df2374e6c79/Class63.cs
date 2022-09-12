using System;
using System.Text;

internal static class Class63
{
	private static uint uint_0 = (uint)Environment.TickCount;

	public static Enum1 smethod_0(Class62 class62_0)
	{
		Enum1 enum1_ = (Enum1)0;
		bool flag = true;
		do
		{
			try
			{
				enum1_ = smethod_1(class62_0);
				switch (enum1_)
				{
				case (Enum1)3:
				{
					uint uint_2 = class62_0.ebd9b488_0[Class69.byte_4].b585a11();
					ebd9b488 ebd9b490 = class62_0.class64_0.method_0(uint_2--);
					class62_0.ebd9b488_0[Class69.byte_4].cf774c3c(uint_2);
					bba016bf(class62_0, ebd9b490.ec0d6773());
					return enum1_;
				}
				case (Enum1)2:
				{
					uint uint_ = class62_0.ebd9b488_0[Class69.byte_4].b585a11();
					ebd9b488 ebd9b489 = class62_0.class64_0.method_0(uint_--);
					class62_0.ebd9b488_0[Class69.byte_4].cf774c3c(uint_);
					cef3d149(class62_0, ebd9b489.ec0d6773());
					break;
				}
				}
				flag = false;
			}
			catch (object object_)
			{
				f8f938e0(class62_0, object_);
				flag = false;
			}
			finally
			{
				if (flag)
				{
					dc738e63(class62_0);
					enum1_ = (Enum1)1;
				}
				else if (class62_0.dd0ec35b.Count > 0)
				{
					do
					{
						smethod_2(class62_0, ref enum1_);
					}
					while (enum1_ == (Enum1)3);
				}
			}
		}
		while (enum1_ != (Enum1)1);
		return enum1_;
	}

	private static Enum1 smethod_1(Class62 class62_0)
	{
		Enum1 enum1_;
		do
		{
			byte byte_ = class62_0.method_0();
			class62_0.method_0();
			dfbbb5f1.smethod_0(byte_).imethod_0(class62_0, out enum1_);
			if (class62_0.ebd9b488_0[Class69.byte_5].method_0() == 1L)
			{
				enum1_ = (Enum1)1;
			}
		}
		while (enum1_ == (Enum1)0);
		return enum1_;
	}

	private static void f8f938e0(Class62 class62_0, object object_0)
	{
		fc6ec998 fc6ec999;
		if (class62_0.dd0ec35b.Count != 0)
		{
			fc6ec999 = class62_0.dd0ec35b[class62_0.dd0ec35b.Count - 1];
			if (fc6ec999.nullable_0.HasValue)
			{
				if (fc6ec999.e239c017 == (fc6ec998.Enum0)0)
				{
					class62_0.ebd9b488_0[Class69.byte_0].f7b1a530(0);
				}
				else if (fc6ec999.e239c017 == (fc6ec998.Enum0)1)
				{
					fc6ec999.object_0 = object_0;
				}
				return;
			}
		}
		fc6ec999 = new fc6ec998
		{
			ebd9b488_0 = class62_0.ebd9b488_0[Class69.ad8cd76c],
			ebd9b488_1 = class62_0.ebd9b488_0[Class69.byte_4],
			object_0 = object_0,
			e239c017 = (fc6ec998.Enum0)0,
			nullable_0 = null,
			nullable_1 = null
		};
		class62_0.dd0ec35b.Add(fc6ec999);
	}

	private static void bba016bf(Class62 class62_0, object object_0)
	{
		if (class62_0.dd0ec35b.Count > 0)
		{
			f8f938e0(class62_0, object_0);
		}
		else
		{
			cef3d149(class62_0, object_0);
		}
	}

	private unsafe static string c5473512(Class62 class62_0)
	{
		uint num = (uint)(class62_0.ebd9b488_0[Class69.byte_5].method_0() - (ulong)class62_0.da79a168.de5d16da().method_1());
		uint num2 = class62_0.ebd9b488_0[Class69.ad8cd76c].b585a11();
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
			num = (uint)(class62_0.class64_0.method_0(num2 - 1).method_0() - (ulong)class62_0.da79a168.de5d16da().method_1());
			if (!(class62_0.class64_0.method_0(num2).ec0d6773() is Class61 @class))
			{
				break;
			}
			num2 = @class.method_0();
		}
		while (num2 != 0);
		return stringBuilder.ToString(1, stringBuilder.Length - 1);
	}

	internal static void cef3d149(Class62 class62_0, object object_0)
	{
		if (object_0 is Exception)
		{
			Class66.smethod_2((Exception)object_0, null);
		}
		throw object_0;
	}

	private static void smethod_2(Class62 class62_0, ref Enum1 enum1_0)
	{
		fc6ec998 fc6ec999 = class62_0.dd0ec35b[class62_0.dd0ec35b.Count - 1];
		switch (fc6ec999.e239c017)
		{
		default:
			throw new ExecutionEngineException();
		case (fc6ec998.Enum0)0:
		{
			if (fc6ec999.nullable_0.HasValue)
			{
				if (class62_0.ebd9b488_0[Class69.byte_0].fc52add5() != 0)
				{
					fc6ec999.e239c017 = (fc6ec998.Enum0)1;
					fc6ec999.nullable_1 = fc6ec999.nullable_0;
					fc6ec999.nullable_0 = class62_0.list_0.Count;
					enum1_0 = (Enum1)0;
					goto case (fc6ec998.Enum0)1;
				}
				fc6ec999.nullable_0--;
			}
			else
			{
				fc6ec999.nullable_0 = class62_0.list_0.Count - 1;
			}
			Type type = fc6ec999.object_0.GetType();
			while (true)
			{
				if (fc6ec999.nullable_0 >= 0 && !fc6ec999.nullable_1.HasValue)
				{
					Struct0 @struct = class62_0.list_0[fc6ec999.nullable_0.Value];
					if (@struct.byte_0 != Class69.byte_65)
					{
						if (@struct.byte_0 == Class69.byte_64 && @struct.a85b1b33.IsAssignableFrom(type))
						{
							break;
						}
						fc6ec999.nullable_0--;
						continue;
					}
					uint num = fc6ec999.ebd9b488_1.b585a11();
					class62_0.class64_0.method_2(++num);
					Class64 class64_ = class62_0.class64_0;
					uint num2 = num;
					ebd9b488 ebd9b488_ = default(ebd9b488);
					ebd9b488_.aa900636(fc6ec999.object_0);
					class64_.method_1(num2, ebd9b488_);
					class62_0.ebd9b488_0[Class69.ac2dcb60].f7b1a530(0);
					class62_0.ebd9b488_0[Class69.byte_4].cf774c3c(num);
					class62_0.ebd9b488_0[Class69.ad8cd76c] = @struct.bde0a6f6;
					class62_0.ebd9b488_0[Class69.byte_5].eca936fa(@struct.ulong_0);
				}
				if (fc6ec999.nullable_0 == -1 && !fc6ec999.nullable_1.HasValue)
				{
					class62_0.dd0ec35b.RemoveAt(class62_0.dd0ec35b.Count - 1);
					enum1_0 = (Enum1)3;
					if (class62_0.dd0ec35b.Count == 0)
					{
						bba016bf(class62_0, fc6ec999.object_0);
					}
				}
				else
				{
					enum1_0 = (Enum1)0;
				}
				return;
			}
			fc6ec999.e239c017 = (fc6ec998.Enum0)1;
			fc6ec999.nullable_1 = fc6ec999.nullable_0;
			fc6ec999.nullable_0 = class62_0.list_0.Count;
			goto case (fc6ec998.Enum0)1;
		}
		case (fc6ec998.Enum0)1:
		{
			fc6ec999.nullable_0--;
			int num3 = fc6ec999.nullable_0.Value;
			while (num3 > fc6ec999.nullable_1.Value)
			{
				Struct0 struct0_ = class62_0.list_0[num3];
				class62_0.list_0.RemoveAt(num3);
				if (struct0_.byte_0 != Class69.ab985727 && struct0_.byte_0 != Class69.byte_66)
				{
					num3--;
					continue;
				}
				smethod_3(class62_0, struct0_);
				break;
			}
			fc6ec999.nullable_0 = num3;
			if (fc6ec999.nullable_0 == fc6ec999.nullable_1)
			{
				Struct0 struct2 = class62_0.list_0[fc6ec999.nullable_1.Value];
				class62_0.list_0.RemoveAt(fc6ec999.nullable_1.Value);
				ref ebd9b488 b16371dd = ref struct2.b16371dd;
				uint num4 = b16371dd.b585a11();
				b16371dd.cf774c3c(num4 + 1);
				class62_0.class64_0.method_2(struct2.b16371dd.b585a11());
				Class64 class64_2 = class62_0.class64_0;
				uint num5 = struct2.b16371dd.b585a11();
				ebd9b488 ebd9b488_ = default(ebd9b488);
				ebd9b488_.aa900636(fc6ec999.object_0);
				class64_2.method_1(num5, ebd9b488_);
				class62_0.ebd9b488_0[Class69.ac2dcb60].f7b1a530(0);
				class62_0.ebd9b488_0[Class69.byte_4] = struct2.b16371dd;
				class62_0.ebd9b488_0[Class69.ad8cd76c] = struct2.bde0a6f6;
				class62_0.ebd9b488_0[Class69.byte_5].eca936fa(struct2.ulong_1);
				class62_0.dd0ec35b.RemoveAt(class62_0.dd0ec35b.Count - 1);
			}
			enum1_0 = (Enum1)0;
			break;
		}
		}
	}

	private static void dc738e63(Class62 class62_0)
	{
		for (int num = class62_0.list_0.Count - 1; num >= 0; num--)
		{
			Struct0 struct0_ = class62_0.list_0[num];
			if (struct0_.byte_0 == Class69.ab985727 || struct0_.byte_0 == Class69.byte_66)
			{
				smethod_3(class62_0, struct0_);
				smethod_0(class62_0);
			}
		}
		class62_0.list_0.Clear();
	}

	private static void smethod_3(Class62 class62_0, Struct0 struct0_0)
	{
		ref ebd9b488 b16371dd = ref struct0_0.b16371dd;
		uint num = b16371dd.b585a11();
		b16371dd.cf774c3c(num + 1);
		class62_0.ebd9b488_0[Class69.ac2dcb60].f7b1a530(0);
		class62_0.ebd9b488_0[Class69.byte_4] = struct0_0.b16371dd;
		class62_0.ebd9b488_0[Class69.ad8cd76c] = struct0_0.bde0a6f6;
		class62_0.ebd9b488_0[Class69.byte_5].eca936fa(struct0_0.ulong_1);
		Class64 class64_ = class62_0.class64_0;
		uint num2 = struct0_0.b16371dd.b585a11();
		ebd9b488 ebd9b488_ = default(ebd9b488);
		ebd9b488_.eca936fa(1uL);
		class64_.method_1(num2, ebd9b488_);
	}
}
