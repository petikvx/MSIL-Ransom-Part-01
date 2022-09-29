using System;
using System.Diagnostics;

internal struct Struct5
{
	private const int int_0 = 32;

	private int int_1;

	private uint uint_0;

	private uint[] uint_1;

	private bool bool_0;

	internal int Int32_0 => int_1 + 1;

	private int Int32_1
	{
		get
		{
			int num = 0;
			for (int num2 = int_1; num2 >= 0; num2--)
			{
				if (uint_1[num2] != 0)
				{
					num++;
				}
			}
			return num;
		}
	}

	[Conditional("DEBUG")]
	private void method_0(bool bool_1)
	{
	}

	internal Struct5(int int_2)
	{
		int_1 = 0;
		uint_0 = 0u;
		if (int_2 > 1)
		{
			uint_1 = new uint[int_2];
			bool_0 = true;
		}
		else
		{
			uint_1 = null;
			bool_0 = false;
		}
	}

	internal Struct5(Struct4 struct4_0, ref int int_2)
	{
		bool_0 = false;
		uint_1 = struct4_0.UInt32_0;
		int int32_ = struct4_0.Int32_1;
		int num = int32_ >> 31;
		int_2 = (int_2 ^ num) - num;
		if (uint_1 == null)
		{
			int_1 = 0;
			uint_0 = (uint)((int32_ ^ num) - num);
			return;
		}
		int_1 = uint_1.Length - 1;
		uint_0 = uint_1[0];
		while (int_1 > 0 && uint_1[int_1] == 0)
		{
			int_1--;
		}
	}

	internal Struct4 method_1(int int_2)
	{
		method_2(int_2, out int_2, out var uint_);
		return new Struct4(int_2, uint_);
	}

	private void method_2(int int_2, out int int_3, out uint[] uint_2)
	{
		if (int_1 == 0)
		{
			if (uint_0 <= int.MaxValue)
			{
				int_3 = int_2 * (int)uint_0;
				uint_2 = null;
				return;
			}
			if (uint_1 == null)
			{
				uint_1 = new uint[1] { uint_0 };
			}
			else if (bool_0)
			{
				uint_1[0] = uint_0;
			}
			else if (uint_1[0] != uint_0)
			{
				uint_1 = new uint[1] { uint_0 };
			}
		}
		int_3 = int_2;
		int num = uint_1.Length - int_1 - 1;
		if (num <= 1)
		{
			if (num == 0 || uint_1[int_1 + 1] == 0)
			{
				bool_0 = false;
				uint_2 = uint_1;
				return;
			}
			if (bool_0)
			{
				uint_1[int_1 + 1] = 0u;
				bool_0 = false;
				uint_2 = uint_1;
				return;
			}
		}
		uint_2 = uint_1;
		Array.Resize(ref uint_2, int_1 + 1);
		if (!bool_0)
		{
			uint_1 = uint_2;
		}
	}

	private void method_3(uint uint_2)
	{
		uint_0 = uint_2;
		int_1 = 0;
	}

	private void method_4(ulong ulong_0)
	{
		uint num = Class3.smethod_5(ulong_0);
		if (num == 0)
		{
			uint_0 = Class3.smethod_4(ulong_0);
			int_1 = 0;
		}
		else
		{
			method_6(2);
			uint_1[0] = (uint)ulong_0;
			uint_1[1] = num;
		}
	}

	private void method_5()
	{
		if (int_1 > 0 && uint_1[int_1] == 0)
		{
			uint_0 = uint_1[0];
			while (--int_1 > 0 && uint_1[int_1] == 0)
			{
			}
		}
	}

	private void method_6(int int_2)
	{
		if (int_2 <= 1)
		{
			int_1 = 0;
			return;
		}
		if (!bool_0 || uint_1.Length < int_2)
		{
			uint_1 = new uint[int_2];
			bool_0 = true;
		}
		int_1 = int_2 - 1;
	}

	private void method_7(int int_2)
	{
		if (int_2 <= 1)
		{
			int_1 = 0;
			uint_0 = 0u;
			return;
		}
		if (bool_0 && uint_1.Length >= int_2)
		{
			Array.Clear(uint_1, 0, int_2);
		}
		else
		{
			uint_1 = new uint[int_2];
			bool_0 = true;
		}
		int_1 = int_2 - 1;
	}

	private void method_8(int int_2, int int_3)
	{
		if (int_2 <= 1)
		{
			if (int_1 > 0)
			{
				uint_0 = uint_1[0];
			}
			int_1 = 0;
			return;
		}
		if (bool_0 && uint_1.Length >= int_2)
		{
			if (int_1 + 1 < int_2)
			{
				Array.Clear(uint_1, int_1 + 1, int_2 - int_1 - 1);
				if (int_1 == 0)
				{
					uint_1[0] = uint_0;
				}
			}
		}
		else
		{
			uint[] array = new uint[int_2 + int_3];
			if (int_1 == 0)
			{
				array[0] = uint_0;
			}
			else
			{
				Array.Copy(uint_1, array, Math.Min(int_2, int_1 + 1));
			}
			uint_1 = array;
			bool_0 = true;
		}
		int_1 = int_2 - 1;
	}

	private void method_9(int int_2 = 0)
	{
		if (!bool_0)
		{
			uint[] destinationArray = new uint[int_1 + 1 + int_2];
			Array.Copy(uint_1, destinationArray, int_1 + 1);
			uint_1 = destinationArray;
			bool_0 = true;
		}
	}

	private void method_10(ref Struct5 struct5_0, int int_2)
	{
		if (struct5_0.int_1 == 0)
		{
			uint_0 = struct5_0.uint_0;
			int_1 = 0;
			return;
		}
		if (!bool_0 || uint_1.Length <= struct5_0.int_1)
		{
			uint_1 = new uint[struct5_0.int_1 + 1 + int_2];
			bool_0 = true;
		}
		int_1 = struct5_0.int_1;
		Array.Copy(struct5_0.uint_1, uint_1, int_1 + 1);
	}

	private void method_11(uint uint_2)
	{
		switch (uint_2)
		{
		case 0u:
			method_3(0u);
			return;
		case 1u:
			return;
		}
		if (int_1 == 0)
		{
			method_4((ulong)uint_0 * (ulong)uint_2);
			return;
		}
		method_9(1);
		uint num = 0u;
		for (int i = 0; i <= int_1; i++)
		{
			num = smethod_3(ref uint_1[i], uint_2, num);
		}
		if (num != 0)
		{
			method_8(int_1 + 2, 0);
			uint_1[int_1] = num;
		}
	}

	internal void method_12(ref Struct5 struct5_0, ref Struct5 struct5_1)
	{
		if (struct5_0.int_1 == 0)
		{
			if (struct5_1.int_1 == 0)
			{
				method_4((ulong)struct5_0.uint_0 * (ulong)struct5_1.uint_0);
				return;
			}
			method_10(ref struct5_1, 1);
			method_11(struct5_0.uint_0);
			return;
		}
		if (struct5_1.int_1 == 0)
		{
			method_10(ref struct5_0, 1);
			method_11(struct5_1.uint_0);
			return;
		}
		method_7(struct5_0.int_1 + struct5_1.int_1 + 2);
		uint[] array;
		int num;
		uint[] array2;
		int num2;
		if (struct5_0.Int32_1 <= struct5_1.Int32_1)
		{
			array = struct5_0.uint_1;
			num = struct5_0.int_1 + 1;
			array2 = struct5_1.uint_1;
			num2 = struct5_1.int_1 + 1;
		}
		else
		{
			array = struct5_1.uint_1;
			num = struct5_1.int_1 + 1;
			array2 = struct5_0.uint_1;
			num2 = struct5_0.int_1 + 1;
		}
		for (int i = 0; i < num; i++)
		{
			uint num3 = array[i];
			if (num3 != 0)
			{
				uint num4 = 0u;
				int num5 = i;
				int num6 = 0;
				while (num6 < num2)
				{
					num4 = smethod_4(ref uint_1[num5], num3, array2[num6], num4);
					num6++;
					num5++;
				}
				while (num4 != 0)
				{
					num4 = smethod_2(ref uint_1[num5++], 0u, num4);
				}
			}
		}
		method_5();
	}

	private static uint smethod_0(ref Struct5 struct5_0, uint uint_2)
	{
		if (uint_2 == 1)
		{
			return 0u;
		}
		if (struct5_0.int_1 == 0)
		{
			return struct5_0.uint_0 % uint_2;
		}
		ulong num = 0uL;
		for (int num2 = struct5_0.int_1; num2 >= 0; num2--)
		{
			num = Class3.smethod_3((uint)num, struct5_0.uint_1[num2]);
			num %= uint_2;
		}
		return (uint)num;
	}

	internal void method_13(ref Struct5 struct5_0)
	{
		if (struct5_0.int_1 == 0)
		{
			method_3(smethod_0(ref this, struct5_0.uint_0));
		}
		else if (int_1 != 0)
		{
			Struct5 struct5_ = default(Struct5);
			smethod_1(ref this, ref struct5_0, bool_1: false, ref struct5_);
		}
	}

	private static void smethod_1(ref Struct5 struct5_0, ref Struct5 struct5_1, bool bool_1, ref Struct5 struct5_2)
	{
		struct5_2.method_3(0u);
		if (struct5_0.int_1 < struct5_1.int_1)
		{
			return;
		}
		int num = struct5_1.int_1 + 1;
		int num2 = struct5_0.int_1 - struct5_1.int_1;
		int num3 = num2;
		int num4 = struct5_0.int_1;
		while (true)
		{
			if (num4 >= num2)
			{
				if (struct5_1.uint_1[num4 - num2] == struct5_0.uint_1[num4])
				{
					num4--;
					continue;
				}
				if (struct5_1.uint_1[num4 - num2] < struct5_0.uint_1[num4])
				{
					num3++;
				}
				break;
			}
			num3++;
			break;
		}
		if (num3 == 0)
		{
			return;
		}
		if (bool_1)
		{
			struct5_2.method_6(num3);
		}
		uint num5 = struct5_1.uint_1[num - 1];
		uint num6 = struct5_1.uint_1[num - 2];
		int num7 = Class3.smethod_8(num5);
		int num8 = 32 - num7;
		if (num7 > 0)
		{
			num5 = (num5 << num7) | (num6 >> num8);
			num6 <<= num7;
			if (num > 2)
			{
				num6 |= struct5_1.uint_1[num - 3] >> num8;
			}
		}
		struct5_0.method_9();
		int num9 = num3;
		while (--num9 >= 0)
		{
			uint num10 = ((num9 + num <= struct5_0.int_1) ? struct5_0.uint_1[num9 + num] : 0u);
			ulong num11 = Class3.smethod_3(num10, struct5_0.uint_1[num9 + num - 1]);
			uint num12 = struct5_0.uint_1[num9 + num - 2];
			if (num7 > 0)
			{
				num11 = (num11 << num7) | (num12 >> num8);
				num12 <<= num7;
				if (num9 + num >= 3)
				{
					num12 |= struct5_0.uint_1[num9 + num - 3] >> num8;
				}
			}
			ulong num13 = num11 / num5;
			ulong num14 = (uint)(num11 % num5);
			if (num13 > 4294967295L)
			{
				num14 += num5 * (num13 - 4294967295L);
				num13 = 4294967295uL;
			}
			for (; num14 <= 4294967295L && num13 * num6 > Class3.smethod_3((uint)num14, num12); num14 += num5)
			{
				num13--;
			}
			if (num13 > 0L)
			{
				ulong num15 = 0uL;
				for (int i = 0; i < num; i++)
				{
					num15 += struct5_1.uint_1[i] * num13;
					uint num16 = (uint)num15;
					num15 >>= 32;
					if (struct5_0.uint_1[num9 + i] < num16)
					{
						num15++;
					}
					struct5_0.uint_1[num9 + i] -= num16;
				}
				if (num10 < num15)
				{
					uint uint_ = 0u;
					for (int j = 0; j < num; j++)
					{
						uint_ = smethod_2(ref struct5_0.uint_1[num9 + j], struct5_1.uint_1[j], uint_);
					}
					num13--;
				}
				struct5_0.int_1 = num9 + num - 1;
			}
			if (bool_1)
			{
				if (num3 == 1)
				{
					struct5_2.uint_0 = (uint)num13;
				}
				else
				{
					struct5_2.uint_1[num9] = (uint)num13;
				}
			}
		}
		struct5_0.int_1 = num - 1;
		struct5_0.method_5();
	}

	private static uint smethod_2(ref uint uint_2, uint uint_3, uint uint_4)
	{
		ulong num = (ulong)((long)uint_2 + (long)uint_3 + uint_4);
		uint_2 = (uint)num;
		return (uint)(num >> 32);
	}

	private static uint smethod_3(ref uint uint_2, uint uint_3, uint uint_4)
	{
		ulong num = (ulong)((long)uint_2 * (long)uint_3 + uint_4);
		uint_2 = (uint)num;
		return (uint)(num >> 32);
	}

	private static uint smethod_4(ref uint uint_2, uint uint_3, uint uint_4, uint uint_5)
	{
		ulong num = (ulong)((long)uint_3 * (long)uint_4 + uint_2 + uint_5);
		uint_2 = (uint)num;
		return (uint)(num >> 32);
	}
}
