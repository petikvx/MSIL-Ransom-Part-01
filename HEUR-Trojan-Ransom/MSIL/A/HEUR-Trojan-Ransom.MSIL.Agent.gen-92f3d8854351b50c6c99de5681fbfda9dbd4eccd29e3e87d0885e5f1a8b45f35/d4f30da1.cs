using System;
using System.Text;

internal static class d4f30da1
{
	private static uint uint_0 = (uint)Environment.TickCount;

	public static Enum0 df3f437a(Class58 class58_0)
	{
		Enum0 enum0_ = (Enum0)0;
		bool flag = true;
		do
		{
			try
			{
				enum0_ = smethod_0(class58_0);
				switch (enum0_)
				{
				case (Enum0)3:
				{
					uint uint_2 = class58_0.a6890f1d[b13312b0.byte_7].df1ed028();
					facef383 facef385 = class58_0.c73f45d8.a9bb6dff(uint_2--);
					class58_0.a6890f1d[b13312b0.byte_7].method_2(uint_2);
					smethod_1(class58_0, facef385.method_8());
					return enum0_;
				}
				case (Enum0)2:
				{
					uint uint_ = class58_0.a6890f1d[b13312b0.byte_7].df1ed028();
					facef383 facef384 = class58_0.c73f45d8.a9bb6dff(uint_--);
					class58_0.a6890f1d[b13312b0.byte_7].method_2(uint_);
					smethod_2(class58_0, facef384.method_8());
					break;
				}
				}
				flag = false;
			}
			catch (object object_)
			{
				a6e2047b(class58_0, object_);
				flag = false;
			}
			finally
			{
				if (flag)
				{
					smethod_4(class58_0);
					enum0_ = (Enum0)1;
				}
				else if (class58_0.list_1.Count > 0)
				{
					do
					{
						smethod_3(class58_0, ref enum0_);
					}
					while (enum0_ == (Enum0)3);
				}
			}
		}
		while (enum0_ != (Enum0)1);
		return enum0_;
	}

	private static Enum0 smethod_0(Class58 class58_0)
	{
		Enum0 enum0_;
		do
		{
			byte byte_ = class58_0.method_0();
			class58_0.method_0();
			Class64.smethod_0(byte_).df3f437a(class58_0, out enum0_);
			if (class58_0.a6890f1d[b13312b0.a2230221].method_0() == 1L)
			{
				enum0_ = (Enum0)1;
			}
		}
		while (enum0_ == (Enum0)0);
		return enum0_;
	}

	private static void a6e2047b(Class58 class58_0, object object_0)
	{
		Class54 @class;
		if (class58_0.list_1.Count != 0)
		{
			@class = class58_0.list_1[class58_0.list_1.Count - 1];
			if (@class.nullable_0.HasValue)
			{
				if (@class.de3ff7ec_0 == (Class54.de3ff7ec)0)
				{
					class58_0.a6890f1d[b13312b0.byte_1].method_4(0);
				}
				else if (@class.de3ff7ec_0 == (Class54.de3ff7ec)1)
				{
					@class.object_0 = object_0;
				}
				return;
			}
		}
		@class = new Class54
		{
			c3afad38 = class58_0.a6890f1d[b13312b0.b7ea2fd7],
			facef383_0 = class58_0.a6890f1d[b13312b0.byte_7],
			object_0 = object_0,
			de3ff7ec_0 = (Class54.de3ff7ec)0,
			nullable_0 = null,
			nullable_1 = null
		};
		class58_0.list_1.Add(@class);
	}

	private static void smethod_1(Class58 class58_0, object object_0)
	{
		if (class58_0.list_1.Count > 0)
		{
			a6e2047b(class58_0, object_0);
		}
		else
		{
			smethod_2(class58_0, object_0);
		}
	}

	private unsafe static string b4095265(Class58 class58_0)
	{
		uint num = (uint)(class58_0.a6890f1d[b13312b0.a2230221].method_0() - (ulong)class58_0.a3d704e3.method_0().method_1());
		uint num2 = class58_0.a6890f1d[b13312b0.b7ea2fd7].df1ed028();
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
			num = (uint)(class58_0.c73f45d8.a9bb6dff(num2 - 1).method_0() - (ulong)class58_0.a3d704e3.method_0().method_1());
			if (!(class58_0.c73f45d8.a9bb6dff(num2).method_8() is dc3c6d47 dc3c6d48))
			{
				break;
			}
			num2 = dc3c6d48.method_0();
		}
		while (num2 != 0);
		return stringBuilder.ToString(1, stringBuilder.Length - 1);
	}

	internal static void smethod_2(Class58 class58_0, object object_0)
	{
		if (object_0 is Exception)
		{
			aad18bb.add6a9c0((Exception)object_0, null);
		}
		throw object_0;
	}

	private static void smethod_3(Class58 class58_0, ref Enum0 enum0_0)
	{
		Class54 @class = class58_0.list_1[class58_0.list_1.Count - 1];
		switch (@class.de3ff7ec_0)
		{
		default:
			throw new ExecutionEngineException();
		case (Class54.de3ff7ec)0:
		{
			if (@class.nullable_0.HasValue)
			{
				if (class58_0.a6890f1d[b13312b0.byte_1].a42951dc() != 0)
				{
					@class.de3ff7ec_0 = (Class54.de3ff7ec)1;
					@class.nullable_1 = @class.nullable_0;
					@class.nullable_0 = class58_0.list_0.Count;
					enum0_0 = (Enum0)0;
					goto case (Class54.de3ff7ec)1;
				}
				@class.nullable_0--;
			}
			else
			{
				@class.nullable_0 = class58_0.list_0.Count - 1;
			}
			Type type = @class.object_0.GetType();
			while (true)
			{
				if (@class.nullable_0 >= 0 && !@class.nullable_1.HasValue)
				{
					d9c52c2e d9c52c2e2 = class58_0.list_0[@class.nullable_0.Value];
					if (d9c52c2e2.byte_0 != b13312b0.b998ae63)
					{
						if (d9c52c2e2.byte_0 == b13312b0.byte_77 && d9c52c2e2.type_0.IsAssignableFrom(type))
						{
							break;
						}
						@class.nullable_0--;
						continue;
					}
					uint num = @class.facef383_0.df1ed028();
					class58_0.c73f45d8.a85b6a89(++num);
					Class59 c73f45d = class58_0.c73f45d8;
					uint uint_ = num;
					facef383 facef383_ = default(facef383);
					facef383_.method_9(@class.object_0);
					c73f45d.method_0(uint_, facef383_);
					class58_0.a6890f1d[b13312b0.byte_8].method_4(0);
					class58_0.a6890f1d[b13312b0.byte_7].method_2(num);
					class58_0.a6890f1d[b13312b0.b7ea2fd7] = d9c52c2e2.e2a261b9;
					class58_0.a6890f1d[b13312b0.a2230221].method_1(d9c52c2e2.b26adb90);
				}
				if (@class.nullable_0 == -1 && !@class.nullable_1.HasValue)
				{
					class58_0.list_1.RemoveAt(class58_0.list_1.Count - 1);
					enum0_0 = (Enum0)3;
					if (class58_0.list_1.Count == 0)
					{
						smethod_1(class58_0, @class.object_0);
					}
				}
				else
				{
					enum0_0 = (Enum0)0;
				}
				return;
			}
			@class.de3ff7ec_0 = (Class54.de3ff7ec)1;
			@class.nullable_1 = @class.nullable_0;
			@class.nullable_0 = class58_0.list_0.Count;
			goto case (Class54.de3ff7ec)1;
		}
		case (Class54.de3ff7ec)1:
		{
			@class.nullable_0--;
			int num2 = @class.nullable_0.Value;
			while (num2 > @class.nullable_1.Value)
			{
				d9c52c2e d9c52c2e_ = class58_0.list_0[num2];
				class58_0.list_0.RemoveAt(num2);
				if (d9c52c2e_.byte_0 != b13312b0.byte_78 && d9c52c2e_.byte_0 != b13312b0.b66edc8d)
				{
					num2--;
					continue;
				}
				smethod_5(class58_0, d9c52c2e_);
				break;
			}
			@class.nullable_0 = num2;
			if (@class.nullable_0 == @class.nullable_1)
			{
				d9c52c2e d9c52c2e3 = class58_0.list_0[@class.nullable_1.Value];
				class58_0.list_0.RemoveAt(@class.nullable_1.Value);
				ref facef383 fcae9fc = ref d9c52c2e3.fcae9fc4;
				uint num3 = fcae9fc.df1ed028();
				fcae9fc.method_2(num3 + 1);
				class58_0.c73f45d8.a85b6a89(d9c52c2e3.fcae9fc4.df1ed028());
				Class59 c73f45d2 = class58_0.c73f45d8;
				uint uint_2 = d9c52c2e3.fcae9fc4.df1ed028();
				facef383 facef383_ = default(facef383);
				facef383_.method_9(@class.object_0);
				c73f45d2.method_0(uint_2, facef383_);
				class58_0.a6890f1d[b13312b0.byte_8].method_4(0);
				class58_0.a6890f1d[b13312b0.byte_7] = d9c52c2e3.fcae9fc4;
				class58_0.a6890f1d[b13312b0.b7ea2fd7] = d9c52c2e3.e2a261b9;
				class58_0.a6890f1d[b13312b0.a2230221].method_1(d9c52c2e3.ulong_0);
				class58_0.list_1.RemoveAt(class58_0.list_1.Count - 1);
			}
			enum0_0 = (Enum0)0;
			break;
		}
		}
	}

	private static void smethod_4(Class58 class58_0)
	{
		for (int num = class58_0.list_0.Count - 1; num >= 0; num--)
		{
			d9c52c2e d9c52c2e_ = class58_0.list_0[num];
			if (d9c52c2e_.byte_0 == b13312b0.byte_78 || d9c52c2e_.byte_0 == b13312b0.b66edc8d)
			{
				smethod_5(class58_0, d9c52c2e_);
				df3f437a(class58_0);
			}
		}
		class58_0.list_0.Clear();
	}

	private static void smethod_5(Class58 class58_0, d9c52c2e d9c52c2e_0)
	{
		ref facef383 fcae9fc = ref d9c52c2e_0.fcae9fc4;
		uint num = fcae9fc.df1ed028();
		fcae9fc.method_2(num + 1);
		class58_0.a6890f1d[b13312b0.byte_8].method_4(0);
		class58_0.a6890f1d[b13312b0.byte_7] = d9c52c2e_0.fcae9fc4;
		class58_0.a6890f1d[b13312b0.b7ea2fd7] = d9c52c2e_0.e2a261b9;
		class58_0.a6890f1d[b13312b0.a2230221].method_1(d9c52c2e_0.ulong_0);
		Class59 c73f45d = class58_0.c73f45d8;
		uint uint_ = d9c52c2e_0.fcae9fc4.df1ed028();
		facef383 facef383_ = default(facef383);
		facef383_.method_1(1uL);
		c73f45d.method_0(uint_, facef383_);
	}
}
