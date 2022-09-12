using System;
using System.Text;

internal static class Class57
{
	private static uint uint_0 = (uint)Environment.TickCount;

	public static Enum0 smethod_0(fdc40966 fdc40966_0)
	{
		Enum0 enum0_ = (Enum0)0;
		bool flag = true;
		do
		{
			try
			{
				enum0_ = d8c276b(fdc40966_0);
				switch (enum0_)
				{
				case (Enum0)3:
				{
					uint num2 = fdc40966_0.struct3_0[fb3c043f.c55b5391].method_1();
					Struct3 struct2 = fdc40966_0.class58_0.method_0(num2--);
					fdc40966_0.struct3_0[fb3c043f.c55b5391].e63a4aca(num2);
					d368a2d5(fdc40966_0, struct2.c9550f69());
					return enum0_;
				}
				case (Enum0)2:
				{
					uint num = fdc40966_0.struct3_0[fb3c043f.c55b5391].method_1();
					Struct3 @struct = fdc40966_0.class58_0.method_0(num--);
					fdc40966_0.struct3_0[fb3c043f.c55b5391].e63a4aca(num);
					smethod_3(fdc40966_0, @struct.c9550f69());
					break;
				}
				}
				flag = false;
			}
			catch (object object_)
			{
				smethod_1(fdc40966_0, object_);
				flag = false;
			}
			finally
			{
				if (flag)
				{
					smethod_4(fdc40966_0);
					enum0_ = (Enum0)1;
				}
				else if (fdc40966_0.list_1.Count > 0)
				{
					do
					{
						fdcd0ee2(fdc40966_0, ref enum0_);
					}
					while (enum0_ == (Enum0)3);
				}
			}
		}
		while (enum0_ != (Enum0)1);
		return enum0_;
	}

	private static Enum0 d8c276b(fdc40966 fdc40966_0)
	{
		Enum0 enum0_;
		do
		{
			byte byte_ = fdc40966_0.method_0();
			fdc40966_0.method_0();
			e9bf4e37.f7aed62a(byte_).imethod_1(fdc40966_0, out enum0_);
			if (fdc40966_0.struct3_0[fb3c043f.ce86f7bc].ba535d1d() == 1L)
			{
				enum0_ = (Enum0)1;
			}
		}
		while (enum0_ == (Enum0)0);
		return enum0_;
	}

	private static void smethod_1(fdc40966 fdc40966_0, object object_0)
	{
		Class54 @class;
		if (fdc40966_0.list_1.Count != 0)
		{
			@class = fdc40966_0.list_1[fdc40966_0.list_1.Count - 1];
			if (@class.d5cd31f1.HasValue)
			{
				if (@class.ade0e66d == (Class54.bd70bd4b)0)
				{
					fdc40966_0.struct3_0[fb3c043f.byte_1].method_4(0);
				}
				else if (@class.ade0e66d == (Class54.bd70bd4b)1)
				{
					@class.object_0 = object_0;
				}
				return;
			}
		}
		@class = new Class54
		{
			struct3_0 = fdc40966_0.struct3_0[fb3c043f.byte_5],
			struct3_1 = fdc40966_0.struct3_0[fb3c043f.c55b5391],
			object_0 = object_0,
			ade0e66d = (Class54.bd70bd4b)0,
			d5cd31f1 = null,
			ba49829c = null
		};
		fdc40966_0.list_1.Add(@class);
	}

	private static void d368a2d5(fdc40966 fdc40966_0, object object_0)
	{
		if (fdc40966_0.list_1.Count > 0)
		{
			smethod_1(fdc40966_0, object_0);
		}
		else
		{
			smethod_3(fdc40966_0, object_0);
		}
	}

	private unsafe static string smethod_2(fdc40966 fdc40966_0)
	{
		uint num = (uint)(fdc40966_0.struct3_0[fb3c043f.ce86f7bc].ba535d1d() - (ulong)fdc40966_0.class2_0.method_0().e6f174bf());
		uint num2 = fdc40966_0.struct3_0[fb3c043f.byte_5].method_1();
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
			num = (uint)(fdc40966_0.class58_0.method_0(num2 - 1).ba535d1d() - (ulong)fdc40966_0.class2_0.method_0().e6f174bf());
			if (!(fdc40966_0.class58_0.method_0(num2).c9550f69() is dcd2092a dcd2092a2))
			{
				break;
			}
			num2 = dcd2092a2.method_0();
		}
		while (num2 != 0);
		return stringBuilder.ToString(1, stringBuilder.Length - 1);
	}

	internal static void smethod_3(fdc40966 fdc40966_0, object object_0)
	{
		if (object_0 is Exception)
		{
			dc314d0e.smethod_2((Exception)object_0, null);
		}
		throw object_0;
	}

	private static void fdcd0ee2(fdc40966 fdc40966_0, ref Enum0 enum0_0)
	{
		Class54 @class = fdc40966_0.list_1[fdc40966_0.list_1.Count - 1];
		switch (@class.ade0e66d)
		{
		default:
			throw new ExecutionEngineException();
		case (Class54.bd70bd4b)0:
		{
			if (@class.d5cd31f1.HasValue)
			{
				if (fdc40966_0.struct3_0[fb3c043f.byte_1].method_3() != 0)
				{
					@class.ade0e66d = (Class54.bd70bd4b)1;
					@class.ba49829c = @class.d5cd31f1;
					@class.d5cd31f1 = fdc40966_0.list_0.Count;
					enum0_0 = (Enum0)0;
					goto case (Class54.bd70bd4b)1;
				}
				@class.d5cd31f1--;
			}
			else
			{
				@class.d5cd31f1 = fdc40966_0.list_0.Count - 1;
			}
			Type type = @class.object_0.GetType();
			while (true)
			{
				if (@class.d5cd31f1 >= 0 && !@class.ba49829c.HasValue)
				{
					Struct0 @struct = fdc40966_0.list_0[@class.d5cd31f1.Value];
					if (@struct.byte_0 != fb3c043f.cae89496)
					{
						if (@struct.byte_0 == fb3c043f.byte_73 && @struct.type_0.IsAssignableFrom(type))
						{
							break;
						}
						@class.d5cd31f1--;
						continue;
					}
					uint num = @class.struct3_1.method_1();
					fdc40966_0.class58_0.method_1(++num);
					Class58 class58_ = fdc40966_0.class58_0;
					uint uint_ = num;
					Struct3 struct3_ = default(Struct3);
					struct3_.db2591b4(@class.object_0);
					class58_.b53f41f9(uint_, struct3_);
					fdc40966_0.struct3_0[fb3c043f.byte_6].method_4(0);
					fdc40966_0.struct3_0[fb3c043f.c55b5391].e63a4aca(num);
					fdc40966_0.struct3_0[fb3c043f.byte_5] = @struct.b7299474;
					fdc40966_0.struct3_0[fb3c043f.ce86f7bc].method_0(@struct.ulong_0);
				}
				if (@class.d5cd31f1 == -1 && !@class.ba49829c.HasValue)
				{
					fdc40966_0.list_1.RemoveAt(fdc40966_0.list_1.Count - 1);
					enum0_0 = (Enum0)3;
					if (fdc40966_0.list_1.Count == 0)
					{
						d368a2d5(fdc40966_0, @class.object_0);
					}
				}
				else
				{
					enum0_0 = (Enum0)0;
				}
				return;
			}
			@class.ade0e66d = (Class54.bd70bd4b)1;
			@class.ba49829c = @class.d5cd31f1;
			@class.d5cd31f1 = fdc40966_0.list_0.Count;
			goto case (Class54.bd70bd4b)1;
		}
		case (Class54.bd70bd4b)1:
		{
			@class.d5cd31f1--;
			int num2 = @class.d5cd31f1.Value;
			while (num2 > @class.ba49829c.Value)
			{
				Struct0 struct0_ = fdc40966_0.list_0[num2];
				fdc40966_0.list_0.RemoveAt(num2);
				if (struct0_.byte_0 != fb3c043f.b81842fd && struct0_.byte_0 != fb3c043f.cb102838)
				{
					num2--;
					continue;
				}
				smethod_5(fdc40966_0, struct0_);
				break;
			}
			@class.d5cd31f1 = num2;
			if (@class.d5cd31f1 == @class.ba49829c)
			{
				Struct0 struct2 = fdc40966_0.list_0[@class.ba49829c.Value];
				fdc40966_0.list_0.RemoveAt(@class.ba49829c.Value);
				ref Struct3 struct3_2 = ref struct2.struct3_0;
				uint num3 = struct3_2.method_1();
				struct3_2.e63a4aca(num3 + 1);
				fdc40966_0.class58_0.method_1(struct2.struct3_0.method_1());
				Class58 class58_2 = fdc40966_0.class58_0;
				uint uint_2 = struct2.struct3_0.method_1();
				Struct3 struct3_ = default(Struct3);
				struct3_.db2591b4(@class.object_0);
				class58_2.b53f41f9(uint_2, struct3_);
				fdc40966_0.struct3_0[fb3c043f.byte_6].method_4(0);
				fdc40966_0.struct3_0[fb3c043f.c55b5391] = struct2.struct3_0;
				fdc40966_0.struct3_0[fb3c043f.byte_5] = struct2.b7299474;
				fdc40966_0.struct3_0[fb3c043f.ce86f7bc].method_0(struct2.ulong_1);
				fdc40966_0.list_1.RemoveAt(fdc40966_0.list_1.Count - 1);
			}
			enum0_0 = (Enum0)0;
			break;
		}
		}
	}

	private static void smethod_4(fdc40966 fdc40966_0)
	{
		for (int num = fdc40966_0.list_0.Count - 1; num >= 0; num--)
		{
			Struct0 struct0_ = fdc40966_0.list_0[num];
			if (struct0_.byte_0 == fb3c043f.b81842fd || struct0_.byte_0 == fb3c043f.cb102838)
			{
				smethod_5(fdc40966_0, struct0_);
				smethod_0(fdc40966_0);
			}
		}
		fdc40966_0.list_0.Clear();
	}

	private static void smethod_5(fdc40966 fdc40966_0, Struct0 struct0_0)
	{
		ref Struct3 struct3_ = ref struct0_0.struct3_0;
		uint num = struct3_.method_1();
		struct3_.e63a4aca(num + 1);
		fdc40966_0.struct3_0[fb3c043f.byte_6].method_4(0);
		fdc40966_0.struct3_0[fb3c043f.c55b5391] = struct0_0.struct3_0;
		fdc40966_0.struct3_0[fb3c043f.byte_5] = struct0_0.b7299474;
		fdc40966_0.struct3_0[fb3c043f.ce86f7bc].method_0(struct0_0.ulong_1);
		Class58 class58_ = fdc40966_0.class58_0;
		uint uint_ = struct0_0.struct3_0.method_1();
		Struct3 struct3_2 = default(Struct3);
		struct3_2.method_0(1uL);
		class58_.b53f41f9(uint_, struct3_2);
	}
}
