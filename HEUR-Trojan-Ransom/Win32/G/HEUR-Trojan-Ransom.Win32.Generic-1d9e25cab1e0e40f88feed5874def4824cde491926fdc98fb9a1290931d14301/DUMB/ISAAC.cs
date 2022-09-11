namespace DUMB;

public class ISAAC
{
	public const int SIZEL = 9;

	public const int SIZE = 512;

	public const int MASK = 2044;

	public int count;

	public int[] rsl;

	public int[] mem;

	private int a;

	private int b;

	private int c;

	public ISAAC()
	{
		mem = new int[512];
		rsl = new int[512];
		Init(flag: false);
	}

	public ISAAC(int[] seed)
	{
		mem = new int[512];
		rsl = new int[512];
		for (int i = 0; i < seed.Length; i++)
		{
			rsl[i] = seed[i];
		}
		Init(flag: true);
	}

	public void Isaac()
	{
		b += ++c;
		int num = 0;
		int num2 = 256;
		while (num < 256)
		{
			int num3 = mem[num];
			a ^= a << 13;
			a += mem[num2++];
			int num4 = (mem[num] = mem[(num3 & 0x7FC) >> 2] + a + b);
			rsl[num++] = (b = mem[((num4 >> 9) & 0x7FC) >> 2] + num3);
			num3 = mem[num];
			a ^= (int)((uint)a >> 6);
			a += mem[num2++];
			num4 = (mem[num] = mem[(num3 & 0x7FC) >> 2] + a + b);
			rsl[num++] = (b = mem[((num4 >> 9) & 0x7FC) >> 2] + num3);
			num3 = mem[num];
			a ^= a << 2;
			a += mem[num2++];
			num4 = (mem[num] = mem[(num3 & 0x7FC) >> 2] + a + b);
			rsl[num++] = (b = mem[((num4 >> 9) & 0x7FC) >> 2] + num3);
			num3 = mem[num];
			a ^= (int)((uint)a >> 16);
			a += mem[num2++];
			num4 = (mem[num] = mem[(num3 & 0x7FC) >> 2] + a + b);
			rsl[num++] = (b = mem[((num4 >> 9) & 0x7FC) >> 2] + num3);
		}
		num2 = 0;
		while (num2 < 256)
		{
			int num3 = mem[num];
			a ^= a << 13;
			a += mem[num2++];
			int num4 = (mem[num] = mem[(num3 & 0x7FC) >> 2] + a + b);
			rsl[num++] = (b = mem[((num4 >> 9) & 0x7FC) >> 2] + num3);
			num3 = mem[num];
			a ^= (int)((uint)a >> 6);
			a += mem[num2++];
			num4 = (mem[num] = mem[(num3 & 0x7FC) >> 2] + a + b);
			rsl[num++] = (b = mem[((num4 >> 9) & 0x7FC) >> 2] + num3);
			num3 = mem[num];
			a ^= a << 2;
			a += mem[num2++];
			num4 = (mem[num] = mem[(num3 & 0x7FC) >> 2] + a + b);
			rsl[num++] = (b = mem[((num4 >> 9) & 0x7FC) >> 2] + num3);
			num3 = mem[num];
			a ^= (int)((uint)a >> 16);
			a += mem[num2++];
			num4 = (mem[num] = mem[(num3 & 0x7FC) >> 2] + a + b);
			rsl[num++] = (b = mem[((num4 >> 9) & 0x7FC) >> 2] + num3);
		}
	}

	public void Init(bool flag)
	{
		int num = -1640531527;
		int num2 = -1640531527;
		int num3 = -1640531527;
		int num4 = -1640531527;
		int num5 = -1640531527;
		int num6 = -1640531527;
		int num7 = -1640531527;
		int num8 = -1640531527;
		for (int i = 0; i < 4; i++)
		{
			num8 ^= num7 << 11;
			num5 += num8;
			num7 += num6;
			num7 ^= (int)((uint)num6 >> 2);
			num4 += num7;
			num6 += num5;
			num6 ^= num5 << 8;
			num3 += num6;
			num5 += num4;
			num5 ^= (int)((uint)num4 >> 16);
			num2 += num5;
			num4 += num3;
			num4 ^= num3 << 10;
			num += num4;
			num3 += num2;
			num3 ^= (int)((uint)num2 >> 4);
			num8 += num3;
			num2 += num;
			num2 ^= num << 8;
			num7 += num2;
			num += num8;
			num ^= (int)((uint)num8 >> 9);
			num6 += num;
			num8 += num7;
		}
		for (int i = 0; i < 512; i += 8)
		{
			if (flag)
			{
				num8 += rsl[i];
				num7 += rsl[i + 1];
				num6 += rsl[i + 2];
				num5 += rsl[i + 3];
				num4 += rsl[i + 4];
				num3 += rsl[i + 5];
				num2 += rsl[i + 6];
				num += rsl[i + 7];
			}
			num8 ^= num7 << 11;
			num5 += num8;
			num7 += num6;
			num7 ^= (int)((uint)num6 >> 2);
			num4 += num7;
			num6 += num5;
			num6 ^= num5 << 8;
			num3 += num6;
			num5 += num4;
			num5 ^= (int)((uint)num4 >> 16);
			num2 += num5;
			num4 += num3;
			num4 ^= num3 << 10;
			num += num4;
			num3 += num2;
			num3 ^= (int)((uint)num2 >> 4);
			num8 += num3;
			num2 += num;
			num2 ^= num << 8;
			num7 += num2;
			num += num8;
			num ^= (int)((uint)num8 >> 9);
			num6 += num;
			num8 += num7;
			mem[i] = num8;
			mem[i + 1] = num7;
			mem[i + 2] = num6;
			mem[i + 3] = num5;
			mem[i + 4] = num4;
			mem[i + 5] = num3;
			mem[i + 6] = num2;
			mem[i + 7] = num;
		}
		if (flag)
		{
			for (int i = 0; i < 512; i += 8)
			{
				num8 += mem[i];
				num7 += mem[i + 1];
				num6 += mem[i + 2];
				num5 += mem[i + 3];
				num4 += mem[i + 4];
				num3 += mem[i + 5];
				num2 += mem[i + 6];
				num += mem[i + 7];
				num8 ^= num7 << 11;
				num5 += num8;
				num7 += num6;
				num7 ^= (int)((uint)num6 >> 2);
				num4 += num7;
				num6 += num5;
				num6 ^= num5 << 8;
				num3 += num6;
				num5 += num4;
				num5 ^= (int)((uint)num4 >> 16);
				num2 += num5;
				num4 += num3;
				num4 ^= num3 << 10;
				num += num4;
				num3 += num2;
				num3 ^= (int)((uint)num2 >> 4);
				num8 += num3;
				num2 += num;
				num2 ^= num << 8;
				num7 += num2;
				num += num8;
				num ^= (int)((uint)num8 >> 9);
				num6 += num;
				num8 += num7;
				mem[i] = num8;
				mem[i + 1] = num7;
				mem[i + 2] = num6;
				mem[i + 3] = num5;
				mem[i + 4] = num4;
				mem[i + 5] = num3;
				mem[i + 6] = num2;
				mem[i + 7] = num;
			}
		}
		Isaac();
		count = 512;
	}

	public int val()
	{
		if (count-- == 0)
		{
			Isaac();
			count = 511;
		}
		return rsl[count];
	}
}
