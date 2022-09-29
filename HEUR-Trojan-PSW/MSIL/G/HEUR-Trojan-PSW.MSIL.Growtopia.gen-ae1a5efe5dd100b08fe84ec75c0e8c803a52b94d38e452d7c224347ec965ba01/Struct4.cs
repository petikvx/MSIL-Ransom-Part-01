using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[Serializable]
internal struct Struct4
{
	private const uint uint_0 = 2147483648u;

	private const int int_0 = 32;

	private readonly int int_1;

	private readonly uint[] uint_1;

	private static readonly Struct4 struct4_0 = new Struct4(-1, new uint[1] { 2147483648u });

	private static readonly Struct4 struct4_1 = new Struct4(1);

	private static readonly Struct4 struct4_2 = new Struct4(0);

	private static readonly Struct4 struct4_3 = new Struct4(-1);

	private static Struct4 Struct4_0 => struct4_1;

	private bool Boolean_0
	{
		get
		{
			if (uint_1 != null)
			{
				return (uint_1[0] & 1) == 0;
			}
			return (int_1 & 1) == 0;
		}
	}

	private int Int32_0 => (int_1 >> 31) - (-int_1 >> 31);

	internal int Int32_1 => int_1;

	internal uint[] UInt32_0 => uint_1;

	[Conditional("DEBUG")]
	private void method_0()
	{
		if (uint_1 != null)
		{
			smethod_11(uint_1);
		}
	}

	public override bool ACA5E44E(object object_0)
	{
		if (!(object_0 is Struct4))
		{
			return false;
		}
		return Equals((Struct4)object_0);
	}

	public override int vmethod_0()
	{
		if (uint_1 == null)
		{
			return int_1;
		}
		int result = int_1;
		int num = smethod_11(uint_1);
		while (--num >= 0)
		{
			result = Class3.smethod_7(result, (int)uint_1[num]);
		}
		return result;
	}

	private int method_1(Struct4 struct4_4)
	{
		if ((int_1 ^ struct4_4.int_1) < 0)
		{
			if (int_1 >= 0)
			{
				return 1;
			}
			return -1;
		}
		if (uint_1 == null)
		{
			if (struct4_4.uint_1 == null)
			{
				if (int_1 >= struct4_4.int_1)
				{
					if (int_1 <= struct4_4.int_1)
					{
						return 0;
					}
					return 1;
				}
				return -1;
			}
			return -struct4_4.int_1;
		}
		int num;
		int num2;
		if (struct4_4.uint_1 != null && (num = smethod_11(uint_1)) <= (num2 = smethod_11(struct4_4.uint_1)))
		{
			if (num < num2)
			{
				return -int_1;
			}
			int num3 = smethod_12(uint_1, struct4_4.uint_1, num);
			if (num3 == 0)
			{
				return 0;
			}
			if (uint_1[num3 - 1] >= struct4_4.uint_1[num3 - 1])
			{
				return int_1;
			}
			return -int_1;
		}
		return int_1;
	}

	internal byte[] method_2()
	{
		if (uint_1 == null && int_1 == 0)
		{
			return new byte[1];
		}
		uint[] array;
		byte b;
		if (uint_1 == null)
		{
			array = new uint[1] { (uint)int_1 };
			b = (byte)((int_1 < 0) ? 255u : 0u);
		}
		else if (int_1 == -1)
		{
			array = (uint[])uint_1.Clone();
			Class3.smethod_0(array);
			b = byte.MaxValue;
		}
		else
		{
			array = uint_1;
			b = 0;
		}
		byte[] array2 = new byte[checked(4 * array.Length)];
		int num = 0;
		uint[] array3 = array;
		for (int i = 0; i < array3.Length; i++)
		{
			uint num2 = array3[i];
			for (int j = 0; j < 4; j++)
			{
				array2[num++] = (byte)(num2 & 0xFFu);
				num2 >>= 8;
			}
		}
		if ((array2[^1] & 0x80) == (b & 0x80))
		{
			return array2;
		}
		byte[] array4 = new byte[array2.Length + 1];
		Array.Copy(array2, array4, array2.Length);
		array4[^1] = b;
		return array4;
	}

	private Struct4(int int_2)
	{
		if (int_2 == int.MinValue)
		{
			this = struct4_0;
			return;
		}
		int_1 = int_2;
		uint_1 = null;
	}

	internal Struct4(byte[] byte_0)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException("value");
		}
		int num = byte_0.Length;
		bool flag = num > 0 && (byte_0[num - 1] & 0x80) == 128;
		while (num > 0 && byte_0[num - 1] == 0)
		{
			num--;
		}
		if (num == 0)
		{
			int_1 = 0;
			uint_1 = null;
			return;
		}
		if (num <= 4)
		{
			if (flag)
			{
				int_1 = -1;
			}
			else
			{
				int_1 = 0;
			}
			for (int num2 = num - 1; num2 >= 0; num2--)
			{
				int_1 <<= 8;
				int_1 |= byte_0[num2];
			}
			uint_1 = null;
			if (int_1 < 0 && !flag)
			{
				uint_1 = new uint[1];
				uint_1[0] = (uint)int_1;
				int_1 = 1;
			}
			if (int_1 == int.MinValue)
			{
				this = struct4_0;
			}
			return;
		}
		int num3 = num % 4;
		int num4 = num / 4 + ((num3 != 0) ? 1 : 0);
		bool flag2 = true;
		uint[] array = new uint[num4];
		int num5 = 3;
		int i;
		for (i = 0; i < num4 - ((num3 != 0) ? 1 : 0); i++)
		{
			for (int j = 0; j < 4; j++)
			{
				if (byte_0[num5] != 0)
				{
					flag2 = false;
				}
				array[i] <<= 8;
				array[i] |= byte_0[num5];
				num5--;
			}
			num5 += 8;
		}
		if (num3 != 0)
		{
			if (flag)
			{
				array[num4 - 1] = uint.MaxValue;
			}
			for (num5 = num - 1; num5 >= num - num3; num5--)
			{
				if (byte_0[num5] != 0)
				{
					flag2 = false;
				}
				array[i] <<= 8;
				array[i] |= byte_0[num5];
			}
		}
		if (flag2)
		{
			this = struct4_2;
		}
		else if (flag)
		{
			Class3.smethod_0(array);
			int num6 = array.Length;
			while (num6 > 0 && array[num6 - 1] == 0)
			{
				num6--;
			}
			if (num6 == 1 && (int)array[0] > 0)
			{
				if (array[0] == 1)
				{
					this = struct4_3;
					return;
				}
				if (array[0] == 2147483648u)
				{
					this = struct4_0;
					return;
				}
				int_1 = -1 * (int)array[0];
				uint_1 = null;
			}
			else if (num6 != array.Length)
			{
				int_1 = -1;
				uint_1 = new uint[num6];
				Array.Copy(array, uint_1, num6);
			}
			else
			{
				int_1 = -1;
				uint_1 = array;
			}
		}
		else
		{
			int_1 = 1;
			uint_1 = array;
		}
	}

	internal Struct4(int int_2, uint[] uint_2)
	{
		int_1 = int_2;
		uint_1 = uint_2;
	}

	private static void smethod_0(ref Struct5 struct5_0, ref Struct5 struct5_1, ref Struct5 struct5_2, ref Struct5 struct5_3)
	{
		Class3.smethod_2(ref struct5_0, ref struct5_3);
		struct5_0.method_12(ref struct5_3, ref struct5_1);
		struct5_0.method_13(ref struct5_2);
	}

	private static void smethod_1(ref Struct5 struct5_0, ref Struct5 struct5_1, ref Struct5 struct5_2)
	{
		Class3.smethod_2(ref struct5_0, ref struct5_2);
		struct5_0.method_12(ref struct5_2, ref struct5_2);
		struct5_0.method_13(ref struct5_1);
	}

	private static void smethod_2(uint uint_2, ref Struct5 struct5_0, ref Struct5 struct5_1, ref Struct5 struct5_2, ref Struct5 struct5_3)
	{
		while (uint_2 != 0)
		{
			if ((uint_2 & 1) == 1)
			{
				smethod_0(ref struct5_0, ref struct5_1, ref struct5_2, ref struct5_3);
			}
			if (uint_2 != 1)
			{
				smethod_1(ref struct5_1, ref struct5_2, ref struct5_3);
				uint_2 >>= 1;
				continue;
			}
			break;
		}
	}

	private static void smethod_3(uint uint_2, ref Struct5 struct5_0, ref Struct5 struct5_1, ref Struct5 struct5_2, ref Struct5 struct5_3)
	{
		for (int i = 0; i < 32; i++)
		{
			if ((uint_2 & 1) == 1)
			{
				smethod_0(ref struct5_0, ref struct5_1, ref struct5_2, ref struct5_3);
			}
			smethod_1(ref struct5_1, ref struct5_2, ref struct5_3);
			uint_2 >>= 1;
		}
	}

	internal static Struct4 smethod_4(Struct4 struct4_4, Struct4 struct4_5, Struct4 struct4_6)
	{
		if (struct4_5.Int32_0 < 0)
		{
			throw new ArgumentOutOfRangeException("exponent", "ArgumentOutOfRange must be non negative");
		}
		int int_ = 1;
		int int_2 = 1;
		int int_3 = 1;
		bool boolean_ = struct4_5.Boolean_0;
		Struct5 struct5_ = new Struct5(Struct4_0, ref int_);
		Struct5 struct5_2 = new Struct5(struct4_4, ref int_2);
		Struct5 struct5_3 = new Struct5(struct4_6, ref int_3);
		Struct5 struct5_4 = new Struct5(struct5_2.Int32_0);
		struct5_.method_13(ref struct5_3);
		if (struct4_5.uint_1 == null)
		{
			smethod_2((uint)struct4_5.int_1, ref struct5_, ref struct5_2, ref struct5_3, ref struct5_4);
		}
		else
		{
			int num = smethod_11(struct4_5.uint_1);
			for (int i = 0; i < num - 1; i++)
			{
				smethod_3(struct4_5.uint_1[i], ref struct5_, ref struct5_2, ref struct5_3, ref struct5_4);
			}
			smethod_2(struct4_5.uint_1[num - 1], ref struct5_, ref struct5_2, ref struct5_3, ref struct5_4);
		}
		return struct5_.method_1((struct4_4.int_1 > 0) ? 1 : (boolean_ ? 1 : (-1)));
	}

	[SpecialName]
	public static bool smethod_5(Struct4 struct4_4, Struct4 struct4_5)
	{
		return struct4_4.method_1(struct4_5) < 0;
	}

	[SpecialName]
	public static bool smethod_6(Struct4 struct4_4, Struct4 struct4_5)
	{
		return struct4_4.method_1(struct4_5) <= 0;
	}

	[SpecialName]
	public static bool smethod_7(Struct4 struct4_4, Struct4 struct4_5)
	{
		return struct4_4.method_1(struct4_5) > 0;
	}

	[SpecialName]
	public static bool smethod_8(Struct4 struct4_4, Struct4 struct4_5)
	{
		return struct4_4.method_1(struct4_5) >= 0;
	}

	[SpecialName]
	public static bool smethod_9(Struct4 struct4_4, Struct4 struct4_5)
	{
		return struct4_4.Equals(struct4_5);
	}

	[SpecialName]
	public static bool smethod_10(Struct4 struct4_4, Struct4 struct4_5)
	{
		return !struct4_4.Equals(struct4_5);
	}

	private static int smethod_11(uint[] uint_2)
	{
		int num = uint_2.Length;
		if (uint_2[num - 1] != 0)
		{
			return num;
		}
		return num - 1;
	}

	private static int smethod_12(uint[] uint_2, uint[] uint_3, int int_2)
	{
		int num = int_2;
		do
		{
			if (--num < 0)
			{
				return 0;
			}
		}
		while (uint_2[num] == uint_3[num]);
		return num + 1;
	}
}
