using System;
using System.Text;

internal static class Class50
{
	private static uint uint_0 = (uint)Environment.TickCount;

	public static Enum1 smethod_0(Class49 class49_0)
	{
		Enum1 enum1_ = (Enum1)0;
		bool flag = true;
		do
		{
			try
			{
				enum1_ = c9ee2ef1(class49_0);
				switch (enum1_)
				{
				case (Enum1)3:
				{
					uint num2 = class49_0.struct2_0[cb1fcba5.byte_8].method_2();
					Struct2 struct2 = class49_0.ec45936d.a59d7f30(num2--);
					class49_0.struct2_0[cb1fcba5.byte_8].c85fac38(num2);
					smethod_1(class49_0, struct2.method_6());
					return enum1_;
				}
				case (Enum1)2:
				{
					uint num = class49_0.struct2_0[cb1fcba5.byte_8].method_2();
					Struct2 @struct = class49_0.ec45936d.a59d7f30(num--);
					class49_0.struct2_0[cb1fcba5.byte_8].c85fac38(num);
					a02660b5(class49_0, @struct.method_6());
					break;
				}
				}
				flag = false;
			}
			catch (object object_)
			{
				f9c45b9c(class49_0, object_);
				flag = false;
			}
			finally
			{
				if (flag)
				{
					smethod_3(class49_0);
					enum1_ = (Enum1)1;
				}
				else if (class49_0.list_1.Count > 0)
				{
					do
					{
						smethod_2(class49_0, ref enum1_);
					}
					while (enum1_ == (Enum1)3);
				}
			}
		}
		while (enum1_ != (Enum1)1);
		return enum1_;
	}

	private static Enum1 c9ee2ef1(Class49 class49_0)
	{
		Enum1 enum1_;
		do
		{
			byte byte_ = class49_0.method_0();
			class49_0.method_0();
			Class58.smethod_0(byte_).imethod_1(class49_0, out enum1_);
			if (class49_0.struct2_0[cb1fcba5.byte_9].method_0() == 1L)
			{
				enum1_ = (Enum1)1;
			}
		}
		while (enum1_ == (Enum1)0);
		return enum1_;
	}

	private static void f9c45b9c(Class49 class49_0, object object_0)
	{
		d10246d4 d10246d5;
		if (class49_0.list_1.Count != 0)
		{
			d10246d5 = class49_0.list_1[class49_0.list_1.Count - 1];
			if (d10246d5.bdcb4007.HasValue)
			{
				if (d10246d5.ac790423 == (d10246d4.Enum0)0)
				{
					class49_0.struct2_0[cb1fcba5.byte_1].dc0866ec(0);
				}
				else if (d10246d5.ac790423 == (d10246d4.Enum0)1)
				{
					d10246d5.object_0 = object_0;
				}
				return;
			}
		}
		d10246d5 = new d10246d4
		{
			ad58784d = class49_0.struct2_0[cb1fcba5.byte_7],
			struct2_0 = class49_0.struct2_0[cb1fcba5.byte_8],
			object_0 = object_0,
			ac790423 = (d10246d4.Enum0)0,
			bdcb4007 = null,
			nullable_0 = null
		};
		class49_0.list_1.Add(d10246d5);
	}

	private static void smethod_1(Class49 class49_0, object object_0)
	{
		if (class49_0.list_1.Count > 0)
		{
			f9c45b9c(class49_0, object_0);
		}
		else
		{
			a02660b5(class49_0, object_0);
		}
	}

	private unsafe static string c8fcb32e(Class49 class49_0)
	{
		uint num = (uint)(class49_0.struct2_0[cb1fcba5.byte_9].method_0() - (ulong)class49_0.class2_0.c73a3276().method_2());
		uint num2 = class49_0.struct2_0[cb1fcba5.byte_7].method_2();
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
			num = (uint)(class49_0.ec45936d.a59d7f30(num2 - 1).method_0() - (ulong)class49_0.class2_0.c73a3276().method_2());
			if (!(class49_0.ec45936d.a59d7f30(num2).method_6() is Class48 @class))
			{
				break;
			}
			num2 = @class.a4a01217();
		}
		while (num2 != 0);
		return stringBuilder.ToString(1, stringBuilder.Length - 1);
	}

	internal static void a02660b5(Class49 class49_0, object object_0)
	{
		if (object_0 is Exception)
		{
			Class53.a30f0ef5((Exception)object_0, null);
		}
		throw object_0;
	}

	private static void smethod_2(Class49 class49_0, ref Enum1 enum1_0)
	{
		d10246d4 d10246d5 = class49_0.list_1[class49_0.list_1.Count - 1];
		switch (d10246d5.ac790423)
		{
		default:
			throw new ExecutionEngineException();
		case (d10246d4.Enum0)0:
		{
			if (d10246d5.bdcb4007.HasValue)
			{
				if (class49_0.struct2_0[cb1fcba5.byte_1].method_4() != 0)
				{
					d10246d5.ac790423 = (d10246d4.Enum0)1;
					d10246d5.nullable_0 = d10246d5.bdcb4007;
					d10246d5.bdcb4007 = class49_0.list_0.Count;
					enum1_0 = (Enum1)0;
					goto case (d10246d4.Enum0)1;
				}
				d10246d5.bdcb4007--;
			}
			else
			{
				d10246d5.bdcb4007 = class49_0.list_0.Count - 1;
			}
			Type type = d10246d5.object_0.GetType();
			while (true)
			{
				if (d10246d5.bdcb4007 >= 0 && !d10246d5.nullable_0.HasValue)
				{
					Struct0 @struct = class49_0.list_0[d10246d5.bdcb4007.Value];
					if (@struct.byte_0 != cb1fcba5.byte_67)
					{
						if (@struct.byte_0 == cb1fcba5.byte_66 && @struct.f3e0d07f.IsAssignableFrom(type))
						{
							break;
						}
						d10246d5.bdcb4007--;
						continue;
					}
					uint num = d10246d5.struct2_0.method_2();
					class49_0.ec45936d.method_0(++num);
					a5c16fd5 ec45936d = class49_0.ec45936d;
					uint uint_ = num;
					Struct2 struct2_ = default(Struct2);
					struct2_.method_7(d10246d5.object_0);
					ec45936d.d1cb88cf(uint_, struct2_);
					class49_0.struct2_0[cb1fcba5.dcbee61c].dc0866ec(0);
					class49_0.struct2_0[cb1fcba5.byte_8].c85fac38(num);
					class49_0.struct2_0[cb1fcba5.byte_7] = @struct.struct2_0;
					class49_0.struct2_0[cb1fcba5.byte_9].method_1(@struct.beef1805);
				}
				if (d10246d5.bdcb4007 == -1 && !d10246d5.nullable_0.HasValue)
				{
					class49_0.list_1.RemoveAt(class49_0.list_1.Count - 1);
					enum1_0 = (Enum1)3;
					if (class49_0.list_1.Count == 0)
					{
						smethod_1(class49_0, d10246d5.object_0);
					}
				}
				else
				{
					enum1_0 = (Enum1)0;
				}
				return;
			}
			d10246d5.ac790423 = (d10246d4.Enum0)1;
			d10246d5.nullable_0 = d10246d5.bdcb4007;
			d10246d5.bdcb4007 = class49_0.list_0.Count;
			goto case (d10246d4.Enum0)1;
		}
		case (d10246d4.Enum0)1:
		{
			d10246d5.bdcb4007--;
			int num2 = d10246d5.bdcb4007.Value;
			while (num2 > d10246d5.nullable_0.Value)
			{
				Struct0 struct0_ = class49_0.list_0[num2];
				class49_0.list_0.RemoveAt(num2);
				if (struct0_.byte_0 != cb1fcba5.fac9fe33 && struct0_.byte_0 != cb1fcba5.byte_68)
				{
					num2--;
					continue;
				}
				d6875242(class49_0, struct0_);
				break;
			}
			d10246d5.bdcb4007 = num2;
			if (d10246d5.bdcb4007 == d10246d5.nullable_0)
			{
				Struct0 struct2 = class49_0.list_0[d10246d5.nullable_0.Value];
				class49_0.list_0.RemoveAt(d10246d5.nullable_0.Value);
				ref Struct2 struct2_2 = ref struct2.struct2_1;
				uint num3 = struct2_2.method_2();
				struct2_2.c85fac38(num3 + 1);
				class49_0.ec45936d.method_0(struct2.struct2_1.method_2());
				a5c16fd5 ec45936d2 = class49_0.ec45936d;
				uint uint_2 = struct2.struct2_1.method_2();
				Struct2 struct2_ = default(Struct2);
				struct2_.method_7(d10246d5.object_0);
				ec45936d2.d1cb88cf(uint_2, struct2_);
				class49_0.struct2_0[cb1fcba5.dcbee61c].dc0866ec(0);
				class49_0.struct2_0[cb1fcba5.byte_8] = struct2.struct2_1;
				class49_0.struct2_0[cb1fcba5.byte_7] = struct2.struct2_0;
				class49_0.struct2_0[cb1fcba5.byte_9].method_1(struct2.ulong_0);
				class49_0.list_1.RemoveAt(class49_0.list_1.Count - 1);
			}
			enum1_0 = (Enum1)0;
			break;
		}
		}
	}

	private static void smethod_3(Class49 class49_0)
	{
		for (int num = class49_0.list_0.Count - 1; num >= 0; num--)
		{
			Struct0 struct0_ = class49_0.list_0[num];
			if (struct0_.byte_0 == cb1fcba5.fac9fe33 || struct0_.byte_0 == cb1fcba5.byte_68)
			{
				d6875242(class49_0, struct0_);
				smethod_0(class49_0);
			}
		}
		class49_0.list_0.Clear();
	}

	private static void d6875242(Class49 class49_0, Struct0 struct0_0)
	{
		ref Struct2 struct2_ = ref struct0_0.struct2_1;
		uint num = struct2_.method_2();
		struct2_.c85fac38(num + 1);
		class49_0.struct2_0[cb1fcba5.dcbee61c].dc0866ec(0);
		class49_0.struct2_0[cb1fcba5.byte_8] = struct0_0.struct2_1;
		class49_0.struct2_0[cb1fcba5.byte_7] = struct0_0.struct2_0;
		class49_0.struct2_0[cb1fcba5.byte_9].method_1(struct0_0.ulong_0);
		a5c16fd5 ec45936d = class49_0.ec45936d;
		uint uint_ = struct0_0.struct2_1.method_2();
		Struct2 struct2_2 = default(Struct2);
		struct2_2.method_1(1uL);
		ec45936d.d1cb88cf(uint_, struct2_2);
	}
}
