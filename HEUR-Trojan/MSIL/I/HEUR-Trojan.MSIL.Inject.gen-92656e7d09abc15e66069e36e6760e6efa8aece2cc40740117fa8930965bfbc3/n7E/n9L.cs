using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Af6;
using Cz1;
using Em4;
using Gb9;
using Jb7;
using Qa4;
using Yb9;
using a1G;
using a2W;
using f8F;
using r6F;
using t7Z;
using y0J;
using y9M;

namespace n7E;

public class n9L
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 244)]
	private struct d9L
	{
	}

	private static readonly Array q;

	private static readonly Array B;

	private static readonly Array G;

	internal static byte c/* Not supported: data(00) */;

	internal static byte[] a2C(int int_0, int int_1)
	{
		if (int_0 <= 0)
		{
			return null;
		}
		checked
		{
			int[] array = new int[int_1 + 1];
			for (int i = 0; i <= int_1; i++)
			{
				int num = int_0 * i;
				if (num > 255)
				{
					num = 255;
				}
				array[i] = num;
			}
			return Lp6(array, int_1);
		}
	}

	internal static byte[] Lp6(int[] int_0, int int_1)
	{
		checked
		{
			byte[] array = new byte[int_1 + 1];
			int num = int_0.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = (byte)int_0[i];
			}
			return array;
		}
	}

	static n9L()
	{
		B = new char[122];
		char[] array = new char[8];
		array[3] = 'μ';
		array[6] = 'ቸ';
		array[2] = '㸋';
		array[4] = '⣌';
		array[1] = 'ⶱ';
		array[7] = '㢭';
		array[5] = '∽';
		array[0] = 'ᶔ';
		G = new string[8];
		q = array;
	}

	static void Gf0()
	{
		nuint num2;
		byte[] ko;
		UIntPtr num;
		checked
		{
			num = unchecked((nuint)(UIntPtr)Cq8.Default) + unchecked((nuint)default(UIntPtr));
			num2 = num + unchecked((nuint)(UIntPtr)Cq8.Default / (nuint)(UIntPtr)Cq8.Default);
			ko = (byte[])(object)Cq8.Default;
		}
		int num3 = (int)checked(2371035166u * 3072983291u);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		checked
		{
			if (num2 * unchecked((nuint)(UIntPtr)Aj8.Cm3(null, ko, num3)) == 0)
			{
				array = array;
				unchecked
				{
					_ = (Cq8)(object)Aj8.Cm3(Aj8.Cm3(array, array, (int)checked(unchecked((uint)(int)Aj8.Cm3(null, null, 628045174)) - 2116117506u)), (byte[])(object)Cq8.Default, (int)checked(unchecked((uint)num3) * (unchecked((uint)num3) - 3055040848u) - unchecked((uint)(int)Cq8.Default)));
				}
			}
			num = default(UIntPtr);
			if (num + num == 0)
			{
				_ = (y0D)(object)Cq8.Default;
			}
			try
			{
				_003CModule_003E = _003CModule_003E;
				_003CModule_003E = null;
			}
			finally
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					while (true)
					{
						obj = obj;
						if (obj != null)
						{
							y6Z y6Z = null;
							y6Z = y6Z;
							continue;
						}
						break;
					}
				}
				else
				{
					num = default(UIntPtr);
					if (unchecked((nuint)default(UIntPtr)) + num == 0)
					{
						_ = (Tr3)(object)Cq8.Default;
					}
					else
					{
						unchecked
						{
							_ = (z3X)(object)Aj8.Cm3(array, array, (int)checked(unchecked((uint)num3) * unchecked(1752773626u / (uint)(int)Cq8.Default)));
						}
					}
				}
				goto IL_0198;
			}
		}
		IL_0b88:
		_ = (n9L)(object)Cq8.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Kz1 kz);
		y0D y0D;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z3X z3X);
		try
		{
			try
			{
				try
				{
					_ = (c2M)(object)Aj8.Cm3(Aj8.Cm3(null, null, num3), null, (int)checked(3998660958u * 2645757119u));
				}
				catch
				{
					kz = kz;
					kz = kz;
					_ = (Wj3)(object)Aj8.Cm3(null, array, -937601894);
					y0D = (y0D)(object)Aj8.Cm3(array, array, (int)Aj8.Cm3(Aj8.Cm3(null, null, -1619777552), array, -105979254));
					_ = (Kj1)Cq8.Default;
				}
			}
			catch
			{
				checked
				{
					nuint num4 = unchecked((nuint)(UIntPtr)Cq8.Default) * num;
					num = default(UIntPtr);
					if (num4 - num == 0)
					{
						_ = (Gj7)(object)Aj8.Cm3(array, array, unchecked((int)Cq8.Default));
					}
					else
					{
						z3X = (z3X)(object)Cq8.Default;
					}
				}
			}
		}
		catch
		{
			num = default(UIntPtr);
			if (checked(num - unchecked(num / checked(unchecked((nuint)(UIntPtr)Cq8.Default) - num))) == 0 && (UIntPtr)Aj8.Cm3(null, array, (int)Aj8.Cm3(array, array, (int)Cq8.Default)) == (UIntPtr)(nuint)0u)
			{
				_ = (y0D)(object)Cq8.Default;
			}
		}
		do
		{
			try
			{
				while ((object)Cq8.Default != null)
				{
					_ = (Kz1)(object)Cq8.Default;
				}
			}
			finally
			{
				do
				{
					_ = (Tr3)(object)Aj8.Cm3(null, (byte[])(object)Cq8.Default, 1921353454);
					_ = (z3X)(object)Aj8.Cm3((byte[])(object)Cq8.Default, array, (int)((uint)(int)Cq8.Default / (checked(unchecked((uint)(int)Aj8.Cm3(array, array, (int)Aj8.Cm3(null, Aj8.Cm3((byte[])(object)Cq8.Default, array, num3), num3))) * unchecked((uint)(int)Cq8.Default)) / (uint)num3)));
				}
				while ((object)Aj8.Cm3(null, array, -492594221) != null);
				continue;
			}
		}
		while (obj != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n9L n9L2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cq8 cq);
		if ((UIntPtr)Aj8.Cm3(null, null, -869760880) == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				while (obj != null)
				{
					n9L2 = n9L2;
					cq = null;
				}
			}
		}
		_ = Cq8.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d5W d5W);
		if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u && num == 0)
		{
			num = default(UIntPtr);
			if (checked(num - num) / (nuint)(UIntPtr)Cq8.Default / num / (nuint)(UIntPtr)Cq8.Default == 0)
			{
				d5W = d5W;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c2M c2M);
		try
		{
			cq = null;
		}
		finally
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u && default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				z3X = z3X;
				_ = (Kj1)Cq8.Default;
				cq = (Cq8)(object)Aj8.Cm3(null, null, (int)checked(unchecked((uint)num3) - unchecked((uint)(int)Cq8.Default)));
				c2M = c2M;
			}
			goto IL_0e9f;
		}
		IL_0e9f:
		y0D = (y0D)(object)Cq8.Default;
		_ = (c2M)(object)Aj8.Cm3(null, null, -349293983);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Tr3 tr);
		while ((object)Cq8.Default != null)
		{
			do
			{
				tr = (Tr3)(object)Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)Cq8.Default);
				_ = (y0D)(object)Aj8.Cm3(array, array, (int)Cq8.Default);
				_003CModule_003E = _003CModule_003E;
			}
			while (obj != null);
		}
		while (obj != null)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
			}
		}
		try
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				try
				{
					_ = (d5W)(object)Cq8.Default;
					_ = (Lw6)(object)Aj8.Cm3((byte[])(object)Cq8.Default, array, num3);
					_ = (d2N)Aj8.Cm3(null, array, num3);
				}
				catch
				{
					cq = cq;
				}
			}
			else
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (Gj7)(object)Cq8.Default;
				}
			}
		}
		catch
		{
			do
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (y6Z)(object)Aj8.Cm3(array, null, num3);
				}
			}
			while ((object)Aj8.Cm3(Aj8.Cm3(array, (byte[])(object)Cq8.Default, num3), null, (int)checked(unchecked((uint)(int)Aj8.Cm3(array, array, (int)Cq8.Default)) * unchecked((uint)(int)Aj8.Cm3(null, (byte[])(object)Cq8.Default, (int)Aj8.Cm3(null, array, num3)) / (uint)(int)Cq8.Default) + unchecked((uint)(int)Cq8.Default))) != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Kj1 kj);
		Wj3 wj;
		try
		{
			if (num == 0)
			{
				try
				{
					d5W = d5W;
				}
				catch
				{
					cq = null;
				}
			}
			else
			{
				wj = null;
			}
		}
		catch
		{
			try
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (Kj1)Cq8.Default;
				}
				else
				{
					_ = (Gj7)(object)Aj8.Cm3(Aj8.Cm3(null, array, num3), array, num3);
				}
			}
			catch
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					kj = (Kj1)Aj8.Cm3(array, null, (int)checked(unchecked(3117852442u / (checked(unchecked((uint)(int)Cq8.Default) * 3604600956u) / (uint)num3)) - 2032923494u));
					_ = (Kj1)Aj8.Cm3(null, (byte[])(object)Cq8.Default, (int)Cq8.Default);
					_ = (z3X)(object)Cq8.Default;
				}
			}
		}
		checked
		{
			try
			{
			}
			catch
			{
				if (num * unchecked((nuint)default(UIntPtr)) == 0)
				{
					Lw6 lw = (Lw6)(object)Aj8.Cm3(null, array, -1720399289);
				}
			}
			nuint num5 = unchecked((nuint)default(UIntPtr)) * unchecked((nuint)default(UIntPtr));
			num = default(UIntPtr);
			if (num5 + num == 0)
			{
				if (num == 0)
				{
					while (obj != null)
					{
						_ = (Kz1)(object)Aj8.Cm3(array, array, 327329148);
						_ = (y6Z)(object)Cq8.Default;
					}
				}
				else
				{
					_ = (_003CModule_003E)(object)Aj8.Cm3(null, array, unchecked((int)Aj8.Cm3(array, array, -2090948762)));
				}
			}
			else if (unchecked((nuint)(UIntPtr)Aj8.Cm3(array, array, (int)Aj8.Cm3(array, Aj8.Cm3(null, (byte[])(object)Cq8.Default, (int)checked(unchecked(379455309u / ((uint)num3 / 1853665461u)) + 4271983471u)), (int)Cq8.Default))) + num == 0)
			{
				_ = (Aj8)(object)Aj8.Cm3(array, array, unchecked((int)Cq8.Default));
			}
			_ = (Tr3)(object)Cq8.Default;
		}
		try
		{
		}
		finally
		{
			if (num / (nuint)(UIntPtr)Aj8.Cm3(null, (byte[])(object)Cq8.Default, num3) == 0 && (UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Aj8)(object)Cq8.Default;
			}
			goto IL_12e3;
		}
		IL_0a99:
		c2M = c2M;
		c2M = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Aj8 aj);
		try
		{
			if ((UIntPtr)Aj8.Cm3(array, null, -100501697) == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)Aj8.Cm3(null, array, num3) == (UIntPtr)(nuint)0u)
				{
					_ = (d5W)(object)Aj8.Cm3((byte[])(object)Cq8.Default, array, 1815926355);
				}
				else
				{
					n9L2 = n9L2;
					aj = (Aj8)(object)Cq8.Default;
				}
			}
		}
		finally
		{
			if (num == 0)
			{
				tr = tr;
			}
			goto IL_0b19;
		}
		IL_1406:
		if (num == (UIntPtr)(nuint)0u)
		{
			try
			{
				y0D = y0D;
				_ = Cq8.Default;
				_ = (Aj8)(object)Cq8.Default;
				cq = null;
			}
			catch
			{
				_ = (d5W)(object)Cq8.Default;
			}
		}
		else
		{
			while (obj != null)
			{
				_ = (Kz1)(object)Aj8.Cm3(null, array, (int)Aj8.Cm3(null, null, -413198282));
			}
		}
		num = default(UIntPtr);
		if (num == 0)
		{
			try
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (Lw6)(object)Aj8.Cm3((byte[])(object)Cq8.Default, array, num3);
				}
				else
				{
					y0D = y0D;
				}
			}
			catch
			{
				try
				{
					d2N d2N = default(d2N);
				}
				finally
				{
					_ = (Lw6)(object)Cq8.Default;
					goto end_IL_14b3;
				}
				end_IL_14b3:;
			}
		}
		while (obj != null)
		{
			do
			{
				wj = null;
				kj = kj;
				_003CModule_003E = _003CModule_003E;
			}
			while (obj != null || obj != null);
		}
		if ((UIntPtr)Aj8.Cm3(array, (byte[])(object)Cq8.Default, -1187594687) == (UIntPtr)(nuint)0u)
		{
			do
			{
				if ((UIntPtr)Aj8.Cm3(null, array, num3) != (UIntPtr)(nuint)0u)
				{
					_ = (z3X)(object)Aj8.Cm3(array, array, (int)Aj8.Cm3(array, array, -472093620));
				}
				else
				{
					_ = (y0D)(object)Cq8.Default;
				}
			}
			while ((object)Aj8.Cm3(array, array, num3) != null);
		}
		else
		{
			while (obj != null)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (d5W)(object)Cq8.Default;
				}
			}
		}
		wj = null;
		wj = (Wj3)(object)Cq8.Default;
		if ((UIntPtr)Aj8.Cm3(null, array, -1113523872) == (UIntPtr)(nuint)0u)
		{
			_ = (z3X)(object)Aj8.Cm3(array, null, (int)checked(unchecked((uint)num3) - unchecked((uint)num3)));
		}
		if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
		{
			_ = (Cq8)(object)Aj8.Cm3(array, null, -104211094);
		}
		else
		{
			_ = (Kz1)(object)Aj8.Cm3(Aj8.Cm3(Aj8.Cm3(Aj8.Cm3((byte[])(object)Cq8.Default, null, (int)checked(515655935u + (unchecked((uint)num3) + unchecked((uint)num3)))), (byte[])(object)Cq8.Default, (int)(checked((unchecked((uint)(int)Cq8.Default) + unchecked(checked(unchecked((uint)(int)Cq8.Default) - unchecked((uint)num3)) / (uint)num3)) * unchecked((uint)(int)Aj8.Cm3(array, (byte[])(object)Cq8.Default, num3))) / (uint)num3)), (byte[])(object)Cq8.Default, 251550473), null, num3);
		}
		while ((object)Aj8.Cm3(array, array, (int)Aj8.Cm3((byte[])(object)Cq8.Default, null, num3)) != null)
		{
			cq = null;
		}
		checked
		{
			try
			{
				if (unchecked((nuint)(UIntPtr)Aj8.Cm3(array, Aj8.Cm3(null, array, -1101525548), (int)Aj8.Cm3(array, Aj8.Cm3(array, (byte[])(object)Cq8.Default, -589547620), (int)checked(unchecked((uint)(int)Cq8.Default) - unchecked((uint)num3))))) + num == 0)
				{
					aj = null;
				}
				return;
			}
			catch
			{
				num = default(UIntPtr);
				if (num * num == 0)
				{
					c2M = null;
				}
				return;
			}
			finally
			{
				while (obj != null)
				{
					if (num == 0)
					{
						kz = kz;
						z3X = (z3X)(object)Cq8.Default;
					}
				}
				return;
			}
		}
		IL_0198:
		while (obj != null)
		{
			if (checked(num * num) == 0)
			{
				while (obj != null)
				{
					_ = (_003CModule_003E)(object)Cq8.Default;
				}
			}
		}
		do
		{
			_ = (n9L)(object)Aj8.Cm3(array, Aj8.Cm3(null, array, num3), -587781436);
		}
		while ((object)Aj8.Cm3(array, null, (int)Cq8.Default) != null || (object)Aj8.Cm3(array, null, (int)Aj8.Cm3(null, array, (int)checked((unchecked((uint)(int)Aj8.Cm3(array, array, (int)Cq8.Default)) + unchecked((uint)num3)) * unchecked((uint)(int)Cq8.Default) - 2732092835u))) != null);
		num = default(UIntPtr);
		if (num == 0)
		{
			try
			{
				_ = (z3X)(object)Cq8.Default;
			}
			catch
			{
				d5W = (d5W)(object)Aj8.Cm3(array, array, -1970278200);
				d5W = null;
			}
		}
		else
		{
			do
			{
				try
				{
					kj = kj;
					kj = kj;
				}
				catch
				{
					_ = (n9L)(object)Aj8.Cm3(Aj8.Cm3(Aj8.Cm3(null, null, 924730093), Aj8.Cm3(array, array, (int)Cq8.Default), -1496668227), null, (int)Aj8.Cm3(null, null, -285831321));
				}
			}
			while (obj != null);
		}
		try
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				while (obj != null)
				{
					_003CModule_003E = (_003CModule_003E)(object)Aj8.Cm3(null, null, num3);
				}
			}
			else
			{
				do
				{
					_ = (y0D)(object)Aj8.Cm3(Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)checked(4166082364u - unchecked((uint)(int)Cq8.Default))), null, (int)Aj8.Cm3(null, Aj8.Cm3(array, array, -1749284807), num3));
				}
				while ((object)Aj8.Cm3(array, Aj8.Cm3(null, array, 2133209789), num3) != null);
			}
		}
		finally
		{
			_003CModule_003E = (_003CModule_003E)(object)Aj8.Cm3(Aj8.Cm3(array, array, (int)Cq8.Default), Aj8.Cm3(Aj8.Cm3(array, Aj8.Cm3(Aj8.Cm3(array, array, 0), array, (int)Aj8.Cm3(array, array, (int)(checked(533231994u + unchecked((uint)num3) * unchecked((uint)num3)) / (uint)num3))), (int)Aj8.Cm3(Aj8.Cm3(Aj8.Cm3((byte[])(object)Cq8.Default, null, (int)(1460784862u / (uint)(int)Aj8.Cm3(array, Aj8.Cm3(Aj8.Cm3(Aj8.Cm3((byte[])(object)Cq8.Default, null, (int)Cq8.Default), array, num3), array, 489495221), 687239167))), (byte[])(object)Cq8.Default, (int)checked(unchecked((uint)num3) + unchecked((uint)(int)Aj8.Cm3(array, array, 208844743)))), array, (int)(2372374480u / checked(unchecked((uint)(int)Cq8.Default) - unchecked((uint)num3) - unchecked((uint)(int)Cq8.Default))))), array, -1578353783), (int)checked(unchecked((uint)(int)Cq8.Default) + unchecked((uint)(int)Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)checked(unchecked((uint)num3) * unchecked((uint)(int)Cq8.Default))))));
			goto IL_0543;
		}
		IL_0543:
		try
		{
			if (num == 0)
			{
				_ = (d5W)(object)Aj8.Cm3(array, null, (int)Aj8.Cm3(array, array, (int)checked(1038187914u * unchecked((uint)(int)Aj8.Cm3(Aj8.Cm3(null, array, -433700059), array, (int)checked(unchecked((uint)(int)Cq8.Default) - unchecked((uint)(int)Aj8.Cm3(Aj8.Cm3((byte[])(object)Cq8.Default, array, (int)Aj8.Cm3((byte[])(object)Cq8.Default, array, (int)Cq8.Default)), array, (int)checked(2920996233u + unchecked((uint)(int)Aj8.Cm3(array, array, (int)Aj8.Cm3(array, null, 1800861320))))))))) - 3846346510u)));
			}
		}
		catch
		{
			wj = (Wj3)(object)Aj8.Cm3((byte[])(object)Cq8.Default, array, (int)checked(unchecked((uint)(int)Cq8.Default) + unchecked((uint)(int)Cq8.Default)));
			wj = wj;
		}
		_ = (Tr3)(object)Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)Cq8.Default);
		if (checked(num * unchecked((nuint)default(UIntPtr))) == 0)
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				z3X = null;
				z3X = z3X;
				_ = (d5W)(object)Aj8.Cm3(null, null, (int)Cq8.Default);
				aj = aj;
				aj = aj;
			}
		}
		else
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)Aj8.Cm3((byte[])(object)Cq8.Default, (byte[])(object)Cq8.Default, (int)((uint)(int)Aj8.Cm3(array, array, (int)Aj8.Cm3((byte[])(object)Cq8.Default, array, (int)Aj8.Cm3(array, null, (int)Cq8.Default))) / 412949810u)) == (UIntPtr)(nuint)0u)
				{
					_ = (Kz1)(object)Cq8.Default;
				}
				else
				{
					Lw6 lw = (Lw6)(object)Aj8.Cm3(array, null, num3);
					lw = lw;
				}
			}
			else
			{
				kj = kj;
				tr = (Tr3)(object)Aj8.Cm3(Aj8.Cm3((byte[])(object)Cq8.Default, null, (int)checked(unchecked((uint)num3) * unchecked((uint)(int)Aj8.Cm3(null, array, num3)))), array, (int)Cq8.Default);
				tr = null;
				z3X = z3X;
			}
		}
		try
		{
			cq = (Cq8)(object)Aj8.Cm3((byte[])(object)Cq8.Default, (byte[])(object)Cq8.Default, (int)Aj8.Cm3(Aj8.Cm3(array, array, (int)Cq8.Default), array, (int)Cq8.Default));
			cq = null;
		}
		catch
		{
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Gj7 gj);
		checked
		{
			if (unchecked((nuint)(UIntPtr)Cq8.Default) * unchecked((nuint)(UIntPtr)Cq8.Default) == 0)
			{
				unchecked
				{
					try
					{
						try
						{
							_ = (Tr3)(object)Cq8.Default;
						}
						catch
						{
							_ = (Tr3)(object)Aj8.Cm3(array, array, (int)Aj8.Cm3(Aj8.Cm3(array, array, (int)checked(unchecked((uint)(int)Aj8.Cm3(null, null, (int)checked(unchecked((uint)(int)Cq8.Default) * unchecked((uint)(int)Cq8.Default)))) + 371153571u)), array, num3));
						}
					}
					catch
					{
						_ = (n9L)(object)Cq8.Default;
					}
				}
			}
			else
			{
				_ = (Tr3)(object)Cq8.Default;
				gj = gj;
				gj = gj;
			}
			UIntPtr num6 = num;
			num = default(UIntPtr);
			if (unchecked((nuint)num6) * num == 0)
			{
				unchecked
				{
					try
					{
						while (obj != null)
						{
							_003CModule_003E = (_003CModule_003E)(object)Aj8.Cm3(array, array, (int)Cq8.Default);
						}
					}
					catch
					{
						while ((object)Aj8.Cm3(null, null, (int)Cq8.Default) != null)
						{
							_ = (Gj7)(object)Cq8.Default;
						}
					}
				}
			}
			while (obj != null)
			{
				try
				{
					num = default(UIntPtr);
					if (num == 0)
					{
						cq = null;
					}
					else
					{
						_003CModule_003E = _003CModule_003E;
					}
				}
				finally
				{
					gj = null;
					continue;
				}
			}
			do
			{
				try
				{
					_ = (d5W)(object)Cq8.Default;
				}
				finally
				{
					try
					{
						_ = (y6Z)(object)Cq8.Default;
						n9L2 = null;
						n9L2 = n9L2;
						y0D = null;
						y0D = y0D;
					}
					finally
					{
						_ = (Kj1)Aj8.Cm3(array, (byte[])(object)Cq8.Default, -760160374);
						continue;
					}
				}
			}
			while (obj != null);
		}
		if ((UIntPtr)Aj8.Cm3(array, array, (int)Cq8.Default) == (UIntPtr)(nuint)0u)
		{
			do
			{
				gj = gj;
				wj = (Wj3)(object)Cq8.Default;
				aj = aj;
			}
			while (obj != null);
			goto IL_0a99;
		}
		try
		{
			if ((UIntPtr)Aj8.Cm3(array, null, (int)checked(unchecked((uint)(int)Cq8.Default) + unchecked((uint)num3))) == (UIntPtr)(nuint)0u)
			{
				gj = gj;
			}
		}
		finally
		{
			while (obj != null)
			{
				n9L2 = n9L2;
				aj = aj;
				d2N d2N = default(d2N);
			}
			goto IL_0a99;
		}
		IL_12e3:
		while ((object)Aj8.Cm3(array, Aj8.Cm3(null, array, -1184229430), num3) != null)
		{
			d5W = (d5W)(object)Aj8.Cm3((byte[])(object)Cq8.Default, array, num3);
		}
		try
		{
			if ((UIntPtr)Aj8.Cm3(array, array, (int)checked(unchecked((uint)(int)Cq8.Default) - unchecked((uint)(int)Aj8.Cm3(array, array, 1080490847)))) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Kz1)(object)Aj8.Cm3(array, array, num3);
				}
				catch
				{
					gj = (Gj7)(object)Aj8.Cm3(Aj8.Cm3(null, array, num3), Aj8.Cm3((byte[])(object)Cq8.Default, array, 1735164131), 735030269);
				}
			}
			else
			{
				do
				{
					kj = default(Kj1);
					kj = kj;
				}
				while ((object)Cq8.Default != null);
			}
		}
		finally
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Kj1)Cq8.Default;
					Lw6 lw = (Lw6)(object)Cq8.Default;
					z3X = z3X;
				}
				catch
				{
					wj = (Wj3)(object)Cq8.Default;
				}
			}
			goto IL_1406;
		}
		IL_0b19:
		try
		{
			if ((nuint)(UIntPtr)Cq8.Default / num == 0)
			{
				Lw6 lw = null;
			}
			else
			{
				_ = (Lw6)(object)Cq8.Default;
			}
		}
		finally
		{
			_ = (Kz1)(object)Aj8.Cm3(Aj8.Cm3(null, array, (int)checked(unchecked((uint)(int)Cq8.Default) * unchecked((uint)(int)Cq8.Default))), array, (int)checked(unchecked((uint)(int)Cq8.Default) + (unchecked((uint)num3) - unchecked((uint)num3))));
			goto IL_0b88;
		}
	}

	static void c0C()
	{
		Wj3 wj = wj;
		wj = wj;
		UIntPtr num = (UIntPtr)Cq8.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num2);
		nuint num3 = num2;
		byte[] array = null;
		nuint num6;
		checked
		{
			nuint num4 = unchecked((nuint)num) - (num3 + unchecked((nuint)(UIntPtr)Aj8.Cm3(array, array, -1682366479)) * num2);
			UIntPtr num5 = unchecked((UIntPtr)Cq8.Default);
			num2 = default(UIntPtr);
			num2 = num4 + (unchecked((nuint)num5) - num2 - num2);
			num2 = default(UIntPtr);
			num6 = unchecked(num2 / (nuint)(UIntPtr)Cq8.Default / (num2 / num2)) + num2;
		}
		UIntPtr num7 = (UIntPtr)Cq8.Default;
		num2 = default(UIntPtr);
		if (num6 / ((nuint)num7 / num2) == 0)
		{
			try
			{
				if (num2 == 0)
				{
					_ = (Wj3)(object)Cq8.Default;
				}
			}
			catch
			{
				try
				{
					_ = (c2M)(object)Cq8.Default;
				}
				catch
				{
					_ = (Kz1)(object)Cq8.Default;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num8);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y0D y0D);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cq8 cq);
		try
		{
			if (num2 == 0)
			{
				while (true)
				{
					obj3 = obj3;
					if (obj3 != null)
					{
						_ = (n9L)(object)Cq8.Default;
						cq = cq;
						cq = cq;
						_ = (y0D)(object)Cq8.Default;
						y0D = y0D;
						y0D = null;
						continue;
					}
					break;
				}
			}
		}
		finally
		{
			while ((object)Aj8.Cm3(Aj8.Cm3(null, array, 499815688), array, num8) != null)
			{
				while ((object)Aj8.Cm3((byte[])(object)Cq8.Default, null, -1997343460) != null)
				{
					byte[] nx = (byte[])(object)Cq8.Default;
					byte[] ko = Aj8.Cm3((byte[])(object)Cq8.Default, null, (int)checked(2951117347u + unchecked((uint)(int)Cq8.Default)));
					num8 = (int)Cq8.Default;
					_ = (Cq8)(object)Aj8.Cm3(nx, ko, (int)Aj8.Cm3(array, array, num8));
				}
			}
			goto IL_01cf;
		}
		IL_0b36:
		if (num2 == 0)
		{
			_ = (d2N)Cq8.Default;
		}
		try
		{
			while (true)
			{
				if (obj3 != null)
				{
					_ = (Lw6)(object)Aj8.Cm3(Aj8.Cm3((byte[])(object)Cq8.Default, array, num8), array, -1605460486);
				}
				else if ((object)Cq8.Default == null)
				{
					break;
				}
			}
		}
		catch
		{
			num2 = default(UIntPtr);
			if (num2 == 0)
			{
				try
				{
					_ = (Kz1)(object)Aj8.Cm3(null, null, num8);
				}
				catch
				{
					_ = (Wj3)(object)Aj8.Cm3(array, array, (int)Aj8.Cm3((byte[])(object)Cq8.Default, null, (int)Cq8.Default));
				}
			}
		}
		_ = (z3X)(object)Cq8.Default;
		_ = (y6Z)(object)Aj8.Cm3(array, null, (int)Cq8.Default);
		_ = (Kj1)Cq8.Default;
		_ = (z3X)(object)Cq8.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Tr3 tr);
		Lw6 lw;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d2N d2N);
		try
		{
			tr = tr;
		}
		finally
		{
			try
			{
				if (checked(num2 + unchecked((nuint)(UIntPtr)Aj8.Cm3(array, null, -1467090079))) == 0)
				{
					d2N = d2N;
				}
				else
				{
					_ = (d5W)(object)Aj8.Cm3(array, array, (int)Cq8.Default);
				}
			}
			finally
			{
				try
				{
					_ = (Kj1)Cq8.Default;
				}
				catch
				{
					lw = null;
				}
				goto IL_0c92;
			}
		}
		IL_0527:
		while (obj3 != null)
		{
			if (num2 == 0)
			{
				_ = (_003CModule_003E)(object)Cq8.Default;
				continue;
			}
			_ = (_003CModule_003E)(object)Aj8.Cm3(null, array, (int)Aj8.Cm3((byte[])(object)Cq8.Default, null, num8));
			_ = (_003CModule_003E)(object)Cq8.Default;
		}
		while (obj3 != null)
		{
		}
		_ = (Kj1)Cq8.Default;
		if ((UIntPtr)Cq8.Default != (UIntPtr)(nuint)0u)
		{
		}
		y0D = (y0D)(object)Cq8.Default;
		y6Z y6Z = y6Z;
		_ = (d5W)(object)Aj8.Cm3(array, array, num8);
		_ = (Lw6)(object)Cq8.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Aj8 aj);
		do
		{
			if (num2 == 0)
			{
				try
				{
					d2N = default(d2N);
					d2N = d2N;
				}
				catch
				{
					aj = aj;
					aj = null;
				}
			}
		}
		while (obj3 != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Gj7 gj);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				lw = null;
				lw = lw;
			}
			else
			{
				try
				{
					_ = (y0D)(object)Cq8.Default;
				}
				catch
				{
					gj = gj;
					gj = null;
				}
			}
		}
		else
		{
			while ((object)Aj8.Cm3(null, (byte[])(object)Cq8.Default, 1797566181) != null)
			{
				try
				{
					wj = (Wj3)(object)Aj8.Cm3(null, null, (int)((uint)(int)Aj8.Cm3((byte[])(object)Cq8.Default, array, (int)checked(unchecked((uint)num8) * unchecked((uint)num8) * 1778915178u)) / (uint)num8));
					_ = (Gj7)(object)Cq8.Default;
					Tr3 obj9 = (Tr3)(object)Cq8.Default;
					tr = tr;
					tr = obj9;
				}
				catch
				{
					lw = (Lw6)(object)Cq8.Default;
				}
			}
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (y6Z)(object)Aj8.Cm3(array, array, (int)Cq8.Default);
			}
			else
			{
				_ = (y6Z)(object)Cq8.Default;
			}
		}
		else if (checked(unchecked((nuint)default(UIntPtr)) * (unchecked((nuint)(UIntPtr)Aj8.Cm3(array, array, (int)checked(3943574910u - unchecked((uint)num8)))) + (unchecked((nuint)default(UIntPtr)) - (unchecked((nuint)(UIntPtr)Cq8.Default) + unchecked((nuint)default(UIntPtr)))))) == 0)
		{
			do
			{
				tr = null;
			}
			while (obj3 != null);
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			aj = aj;
		}
		else
		{
			while (obj3 != null)
			{
				try
				{
					_ = (Gj7)(object)Cq8.Default;
				}
				finally
				{
					_ = (y0D)(object)Cq8.Default;
					continue;
				}
			}
		}
		do
		{
			num2 = default(UIntPtr);
			if (num2 == (UIntPtr)(nuint)0u)
			{
				while ((object)Cq8.Default != null)
				{
					_ = (Tr3)(object)Aj8.Cm3(array, Aj8.Cm3(array, array, num8), (int)Cq8.Default);
				}
			}
		}
		while (obj3 != null);
		n9L n9L2 = n9L2;
		lw = (Lw6)(object)Cq8.Default;
		_ = (_003CModule_003E)(object)Aj8.Cm3(array, null, (int)checked(unchecked((uint)(int)Aj8.Cm3(array, Aj8.Cm3((byte[])(object)Cq8.Default, array, num8), (int)Aj8.Cm3(null, null, num8))) + unchecked((uint)(int)Aj8.Cm3(Aj8.Cm3(array, Aj8.Cm3(array, array, (int)Aj8.Cm3(array, array, 1254233062)), 463756392), array, (int)((uint)(int)Cq8.Default / 720233567u)))));
		cq = (Cq8)(object)Aj8.Cm3(null, null, (int)checked(unchecked((uint)(int)Cq8.Default) + unchecked((uint)(int)Cq8.Default)));
		n9L2 = (n9L)(object)Cq8.Default;
		do
		{
			if (num2 == (UIntPtr)(nuint)0u)
			{
				gj = (Gj7)(object)Aj8.Cm3(array, array, (int)Cq8.Default);
				_ = (n9L)(object)Cq8.Default;
				_ = (Kz1)(object)Cq8.Default;
			}
		}
		while ((object)Aj8.Cm3(Aj8.Cm3(null, null, num8), null, -318875820) != null);
		num2 = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Kz1 kz);
		if (num2 == 0)
		{
			num2 = default(UIntPtr);
			if (num2 == 0)
			{
				try
				{
					_003CModule_003E _003CModule_003E = _003CModule_003E;
					_003CModule_003E = null;
					_ = (Aj8)(object)Aj8.Cm3((byte[])(object)Cq8.Default, array, num8);
				}
				catch
				{
					_ = (d5W)(object)Cq8.Default;
					tr = (Tr3)(object)Aj8.Cm3(null, null, num8);
					kz = null;
				}
			}
		}
		else if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
		{
			d2N = (d2N)Cq8.Default;
		}
		try
		{
			num2 = default(UIntPtr);
			if (num2 == 0)
			{
				_ = (Wj3)(object)Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)Aj8.Cm3((byte[])(object)Cq8.Default, null, (int)checked(unchecked((uint)(int)Aj8.Cm3(Aj8.Cm3(array, null, (int)Aj8.Cm3(array, Aj8.Cm3(array, array, (int)checked(unchecked((uint)(int)Aj8.Cm3(Aj8.Cm3(Aj8.Cm3(array, array, (int)checked(unchecked((uint)(int)Aj8.Cm3((byte[])(object)Cq8.Default, array, -759725178) / (uint)(int)Aj8.Cm3((byte[])(object)Cq8.Default, array, num8)) - 3446737851u - unchecked((uint)(int)Aj8.Cm3(null, Aj8.Cm3(Aj8.Cm3(array, null, num8), array, num8), (int)checked(2502543702u * 266281761u - unchecked((uint)num8)))))), array, -1548745162), array, -785658312)) - 2963173919u)), -2001407035)), null, 1123284619)) + unchecked((uint)num8))));
			}
			else
			{
				num2 = default(UIntPtr);
				if (num2 == 0)
				{
					_ = (d5W)(object)Cq8.Default;
				}
			}
		}
		finally
		{
			_ = (n9L)(object)Cq8.Default;
			goto IL_0b36;
		}
		IL_01cf:
		_ = (_003CModule_003E)(object)Cq8.Default;
		_ = (y0D)(object)Cq8.Default;
		n9L2 = null;
		n9L2 = n9L2;
		_ = (c2M)(object)Aj8.Cm3(array, Aj8.Cm3(null, (byte[])(object)Cq8.Default, (int)Aj8.Cm3(null, array, (int)checked((1391718555u - 2264841673u) * unchecked((uint)num8)))), (int)Cq8.Default);
		if (num2 == 0)
		{
			_ = (z3X)(object)Cq8.Default;
		}
		_ = (d5W)(object)Cq8.Default;
		n9L2 = (n9L)(object)Cq8.Default;
		if ((UIntPtr)Aj8.Cm3(Aj8.Cm3(array, array, (int)(844788911u / (uint)(int)Cq8.Default / (uint)num8)), null, 701696645) == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					n9L2 = null;
					_ = (d5W)(object)Cq8.Default;
				}
				finally
				{
					_ = (z3X)(object)Aj8.Cm3(Aj8.Cm3(array, Aj8.Cm3((byte[])(object)Cq8.Default, null, -75422598), num8), array, -1798508422);
					goto end_IL_02a5;
				}
				end_IL_02a5:;
			}
			catch
			{
				while (obj3 != null)
				{
					_ = (Gj7)(object)Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)checked(3822430236u * unchecked((uint)(int)Cq8.Default) + unchecked((uint)num8) * 3038198229u));
					_ = (n9L)(object)Cq8.Default;
				}
			}
		}
		d5W d5W = d5W;
		d5W = d5W;
		try
		{
			num2 = default(UIntPtr);
			if (num2 == 0)
			{
				d2N = d2N;
				d2N = default(d2N);
				d2N = d2N;
			}
			else
			{
				_ = (Gj7)(object)Aj8.Cm3(null, null, 0);
			}
		}
		finally
		{
			if (num2 == 0)
			{
				d5W = d5W;
			}
			else
			{
				_ = (Kj1)Cq8.Default;
				_ = (d2N)Aj8.Cm3(array, Aj8.Cm3(array, null, (int)Aj8.Cm3((byte[])(object)Cq8.Default, array, (int)checked(unchecked((uint)(int)Aj8.Cm3((byte[])(object)Cq8.Default, Aj8.Cm3(array, array, (int)(408573097u / (uint)(int)Cq8.Default)), 1387998220)) * ((unchecked((uint)(int)Cq8.Default) + unchecked((uint)(int)Aj8.Cm3(null, array, (int)Aj8.Cm3((byte[])(object)Cq8.Default, array, 1772218054)))) * unchecked((uint)(int)Aj8.Cm3(Aj8.Cm3(array, array, (int)Aj8.Cm3(array, Aj8.Cm3(array, null, (int)Cq8.Default), num8)), array, -328463463))) * unchecked((uint)num8) + 1536026376u))), 2084188238);
				_ = (Kj1)Cq8.Default;
				y6Z = (y6Z)(object)Cq8.Default;
				y6Z = y6Z;
			}
			goto IL_0527;
		}
		IL_13b7:
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (c2M)(object)Aj8.Cm3(array, array, (int)Cq8.Default);
			return;
		}
		do
		{
			try
			{
				_ = (d5W)(object)Cq8.Default;
			}
			catch
			{
				lw = lw;
			}
		}
		while (obj3 != null);
		return;
		IL_0c92:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c2M c2M);
		try
		{
			try
			{
				try
				{
					_ = (y0D)(object)Aj8.Cm3(null, array, num8);
				}
				finally
				{
					c2M = c2M;
					goto end_IL_0c94;
				}
				end_IL_0c94:;
			}
			finally
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Lw6)(object)Cq8.Default;
				}
				else
				{
					Kj1 obj14 = (Kj1)Aj8.Cm3(Aj8.Cm3((byte[])(object)Cq8.Default, Aj8.Cm3(null, null, num8), (int)Cq8.Default), array, num8);
					Kj1 kj = kj;
					kj = obj14;
				}
				goto end_IL_0c93;
			}
			end_IL_0c93:;
		}
		catch
		{
			try
			{
				while ((object)Cq8.Default != null)
				{
					_ = (Tr3)(object)Aj8.Cm3((byte[])(object)Cq8.Default, Aj8.Cm3(null, null, (int)Aj8.Cm3(array, array, num8)), -1668662581);
				}
			}
			catch
			{
				try
				{
					wj = wj;
					gj = gj;
					goto end_IL_0d75;
				}
				finally
				{
					_ = (z3X)(object)Aj8.Cm3(Aj8.Cm3(null, null, (int)Cq8.Default), null, (int)Cq8.Default);
					gj = gj;
					_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)Cq8.Default;
					goto end_IL_0d75;
				}
				end_IL_0d75:;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z3X z3X);
		do
		{
			num2 = default(UIntPtr);
			if (num2 != 0)
			{
				try
				{
					_ = (y0D)(object)Aj8.Cm3(null, array, (int)Aj8.Cm3(null, array, (int)checked((43931285u + unchecked((uint)(int)Aj8.Cm3(Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)checked(unchecked((uint)num8) * unchecked((uint)(int)Cq8.Default))), array, 1880413750)) + unchecked((uint)num8)) * unchecked((uint)num8))));
				}
				catch
				{
					cq = (Cq8)(object)Aj8.Cm3(array, null, (int)checked(2512371675u + 3730616707u));
				}
				continue;
			}
			try
			{
				_ = (Tr3)(object)Aj8.Cm3(array, null, num8);
			}
			catch
			{
				d5W = d5W;
				_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)Aj8.Cm3(null, null, num8);
				z3X = z3X;
				z3X = z3X;
			}
		}
		while (obj3 != null);
		if ((UIntPtr)Aj8.Cm3(Aj8.Cm3(Aj8.Cm3(null, array, (int)Aj8.Cm3(null, array, (int)(3879249290u / (uint)(int)Cq8.Default))), Aj8.Cm3(array, array, (int)Cq8.Default), (int)Aj8.Cm3(array, array, num8)), (byte[])(object)Cq8.Default, num8) == (UIntPtr)(nuint)0u)
		{
			if (num2 == 0)
			{
				try
				{
					_ = (y0D)(object)Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)Cq8.Default);
				}
				catch
				{
					_ = Cq8.Default;
				}
			}
			else
			{
				_ = (z3X)(object)Aj8.Cm3(array, array, 39003366);
			}
		}
		try
		{
			try
			{
				_ = (y6Z)(object)Cq8.Default;
			}
			finally
			{
				lw = lw;
				goto end_IL_0f94;
			}
			end_IL_0f94:;
		}
		catch
		{
			_ = (d5W)(object)Cq8.Default;
			gj = null;
		}
		if (num2 == 0)
		{
			num2 = default(UIntPtr);
			if (num2 != 0)
			{
				try
				{
					_ = (y6Z)(object)Cq8.Default;
				}
				finally
				{
					_ = (d5W)(object)Cq8.Default;
					goto IL_1048;
				}
			}
			try
			{
				_ = Cq8.Default;
			}
			catch
			{
				cq = Cq8.Default;
			}
		}
		else
		{
			do
			{
				if (num2 == 0)
				{
					_ = (c2M)(object)Cq8.Default;
				}
			}
			while ((object)Cq8.Default != null);
		}
		goto IL_1048;
		IL_1274:
		if (num2 == 0)
		{
			_ = (Kj1)Cq8.Default;
		}
		_ = (y0D)(object)Aj8.Cm3(null, null, (int)checked(unchecked((uint)num8) + 455343527u));
		d2N = (d2N)Aj8.Cm3(array, null, 6);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			do
			{
				try
				{
					n9L2 = (n9L)(object)Aj8.Cm3(array, null, -436777107);
				}
				catch
				{
					gj = (Gj7)(object)Aj8.Cm3(null, (byte[])(object)Cq8.Default, (int)checked(unchecked((uint)num8) - unchecked((uint)(int)Aj8.Cm3((byte[])(object)Cq8.Default, array, 1868668133))));
					n9L2 = n9L2;
					d5W = d5W;
					d5W = (d5W)(object)Aj8.Cm3(null, array, num8);
				}
			}
			while (obj3 != null);
		}
		else
		{
			_ = (Wj3)(object)Cq8.Default;
		}
		kz = kz;
		_ = Cq8.Default;
		try
		{
		}
		catch
		{
			do
			{
				try
				{
					_ = (Tr3)(object)Aj8.Cm3(null, array, num8);
				}
				finally
				{
					kz = kz;
					continue;
				}
			}
			while (obj3 != null);
		}
		try
		{
			d2N = default(d2N);
		}
		finally
		{
			c2M = c2M;
			goto IL_13b7;
		}
		IL_1048:
		do
		{
			if (num2 == 0)
			{
				_ = (Lw6)(object)Cq8.Default;
			}
		}
		while (obj3 != null);
		_ = (d5W)(object)Aj8.Cm3(array, Aj8.Cm3(null, array, num8), (int)Cq8.Default);
		_ = (_003CModule_003E)(object)Cq8.Default;
		if (num2 == 0)
		{
			UIntPtr num9 = (UIntPtr)Aj8.Cm3(array, array, (int)(checked(unchecked((uint)num8) - 1272527837u) / (uint)num8));
			UIntPtr num10 = (UIntPtr)Aj8.Cm3(array, null, (int)Cq8.Default);
			nuint num11 = num2;
			UIntPtr num12 = (UIntPtr)Aj8.Cm3(array, Aj8.Cm3(array, null, (int)checked(unchecked((uint)(int)Cq8.Default / 1200533574u) + unchecked((uint)(int)Aj8.Cm3(null, array, 588623764)))), num8);
			num2 = default(UIntPtr);
			checked
			{
				if (unchecked((nuint)num9) + unchecked((nuint)num10) * unchecked(num11 / checked(unchecked((nuint)num12) + (unchecked((nuint)default(UIntPtr)) - num2 - unchecked((nuint)(UIntPtr)Aj8.Cm3(null, array, num8))))) == 0)
				{
					_ = (Aj8)(object)Cq8.Default;
				}
			}
		}
		_ = (Aj8)(object)Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)Aj8.Cm3(Aj8.Cm3(array, array, (int)checked(1160255657u * unchecked((uint)num8))), null, (int)checked(unchecked((uint)(int)Cq8.Default) - 2925706417u)));
		z3X = null;
		wj = (Wj3)(object)Aj8.Cm3(array, Aj8.Cm3(Aj8.Cm3(array, null, num8), array, 1921641229), (int)((uint)(int)Aj8.Cm3((byte[])(object)Cq8.Default, array, (int)checked(unchecked((uint)(int)Cq8.Default) - 1734597230u + unchecked((uint)(int)Aj8.Cm3(null, Aj8.Cm3(array, array, 1434613823), num8)) - unchecked((uint)(int)Aj8.Cm3(null, null, num8)))) / 3649539653u));
		try
		{
			do
			{
				d5W = d5W;
			}
			while (obj3 != null || (object)Cq8.Default != null);
		}
		finally
		{
			z3X = z3X;
			goto IL_1274;
		}
	}
}
