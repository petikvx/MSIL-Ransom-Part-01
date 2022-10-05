using System;
using System.Runtime.CompilerServices;
using Af6;
using Cz1;
using Em4;
using Gb9;
using Jb7;
using Qa4;
using Yb9;
using a2W;
using f8F;
using n7E;
using r6F;
using t7Z;
using y0J;
using y9M;

namespace a1G;

public class Aj8
{
	public static byte[] Cm3(byte[] Nx4, byte[] Ko8, int Wc6)
	{
		checked
		{
			int num = Nx4.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				Nx4[i] = Da0(Nx4[i], (byte)(Ko8[unchecked(i % Ko8.Length)] ^ ((i + unchecked(Wc6 % Ko8.Length)) & Wc6)));
			}
			return Nx4;
		}
	}

	internal static byte Da0(byte byte_0, byte byte_1)
	{
		return (byte)(byte_0 ^ byte_1);
	}

	internal static byte[] m5A(int int_0)
	{
		return n9L.a2C(int_0, checked(int_0 + 9));
	}

	static void c3E()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d5W d5W);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		Kz1 kz;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Lw6 lw);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n9L n9L);
		try
		{
			try
			{
				try
				{
					_ = (_003CModule_003E)(object)Cq8.Default;
				}
				finally
				{
					_ = (c2M)(object)Cq8.Default;
					n9L obj = (n9L)(object)Cq8.Default;
					n9L = n9L;
					n9L = obj;
					Aj8 obj2 = (Aj8)(object)Cq8.Default;
					Aj8 aj = aj;
					aj = obj2;
					goto end_IL_0001;
				}
				end_IL_0001:;
			}
			finally
			{
				do
				{
					_ = (z3X)(object)Cq8.Default;
					obj3 = Cq8.Default;
				}
				while (obj3 != null);
				goto end_IL_0000;
			}
			end_IL_0000:;
		}
		catch
		{
			try
			{
				try
				{
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = _003CModule_003E;
					n9L = null;
					array = (byte[])(object)Cq8.Default;
					byte[] nx = array;
					byte[] ko = array;
					num = 1619756088;
					d5W = (d5W)(object)Cm3(nx, ko, 1619756088);
					d5W = d5W;
					_ = (n9L)(object)Cm3(array, array, (int)Cq8.Default);
				}
				finally
				{
					_ = (z3X)(object)Cq8.Default;
					goto end_IL_005a;
				}
				end_IL_005a:;
			}
			finally
			{
				try
				{
					_ = (Tr3)(object)Cm3(array, (byte[])(object)Cq8.Default, 1908561033);
				}
				catch
				{
					_ = (Wj3)(object)Cm3(array, Cm3(array, null, num), num);
					kz = (Kz1)(object)Cm3((byte[])(object)Cq8.Default, array, (int)checked(unchecked((uint)num) * unchecked((uint)(int)Cq8.Default)));
					kz = null;
					_ = (Lw6)(object)Cm3(null, array, (int)checked((unchecked((uint)num) + (286906516u + (527855215u + unchecked((uint)num))) * (unchecked((uint)(int)Cq8.Default) * unchecked((uint)num))) * unchecked((uint)(int)Cq8.Default)));
					lw = lw;
					lw = null;
				}
				goto end_IL_0059;
			}
			end_IL_0059:;
		}
		while (obj3 != null)
		{
			kz = null;
		}
		_003CModule_003E = _003CModule_003E;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y6Z y6Z);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z3X z3X);
		try
		{
			_ = (y6Z)(object)Cm3(array, Cm3(array, array, (int)Cm3(Cm3(array, array, (int)checked(unchecked((uint)(int)Cm3((byte[])(object)Cq8.Default, (byte[])(object)Cq8.Default, (int)checked(1161777971u * unchecked((uint)(int)Cm3(array, (byte[])(object)Cq8.Default, (int)Cq8.Default))))) - unchecked((uint)num))), (byte[])(object)Cq8.Default, num)), (int)checked(unchecked((uint)(int)Cq8.Default) + unchecked((uint)(int)Cq8.Default)));
			_ = (Lw6)(object)Cm3(null, (byte[])(object)Cq8.Default, 511403892);
			y6Z = y6Z;
			y6Z = y6Z;
			_003CModule_003E = _003CModule_003E;
		}
		catch
		{
			do
			{
				z3X = (z3X)(object)Cm3(array, Cm3(null, null, (int)((uint)num / ((uint)num / (uint)num) / (checked(2599579236u + unchecked((uint)num)) / 3266610425u))), -1975957777);
				z3X = z3X;
				_ = (n9L)(object)Cm3(null, null, (int)Cq8.Default);
			}
			while ((object)Cq8.Default != null);
		}
		finally
		{
			try
			{
				do
				{
					_ = (Tr3)(object)Cq8.Default;
				}
				while ((object)Cq8.Default != null);
			}
			finally
			{
				goto IL_02b4;
			}
		}
		IL_1312:
		_ = (Wj3)(object)Cm3(Cm3(null, array, (int)(183582701u / (uint)num)), Cm3(array, null, -1666834855), num);
		nuint num2 = default(UIntPtr);
		Wj3 wj;
		checked
		{
			if (num2 + unchecked((nuint)(UIntPtr)Cm3(Cm3(array, array, 1060404256), array, (int)checked(unchecked((uint)num) + (unchecked((uint)num) + 3351754303u) * unchecked((uint)(int)Cm3((byte[])(object)Cq8.Default, (byte[])(object)Cq8.Default, (int)checked(unchecked((uint)num) * (unchecked((uint)(int)Cm3(array, array, (int)checked(unchecked((uint)num) * unchecked((uint)(int)Cq8.Default)))) + 1928431335u + 2353333285u))))))) == 0)
			{
				_ = (d5W)(object)Cq8.Default;
			}
			else
			{
				wj = (Wj3)(object)Cq8.Default;
			}
			do
			{
				_003CModule_003E = _003CModule_003E;
				d5W = d5W;
			}
			while (obj3 != null);
			if (num2 == 0)
			{
				while (obj3 != null)
				{
					do
					{
						_ = (Gj7)(object)Cq8.Default;
					}
					while (obj3 != null);
				}
			}
		}
		_ = (_003CModule_003E)(object)Cm3((byte[])(object)Cq8.Default, Cm3(array, Cm3(array, array, (int)checked(unchecked((uint)(int)Cq8.Default) * (unchecked((uint)num) * (unchecked((uint)(int)Cq8.Default) - 1551186767u) * 3138611552u * 3530266023u))), 273358309), (int)checked(unchecked((uint)(int)Cq8.Default) + unchecked((uint)(int)Cm3(array, array, (int)Cm3(array, Cm3((byte[])(object)Cq8.Default, array, (int)Cm3(Cm3(array, null, num), array, 208476097)), (int)Cq8.Default))) - unchecked((uint)(int)Cm3(Cm3(Cm3(Cm3((byte[])(object)Cq8.Default, array, -197337176), null, (int)Cm3(null, null, (int)checked(3977826507u + unchecked((uint)num) - unchecked((uint)(int)Cq8.Default)))), (byte[])(object)Cq8.Default, num), null, num))));
		_ = (_003CModule_003E)(object)Cq8.Default;
		_ = (y6Z)(object)Cm3(null, (byte[])(object)Cq8.Default, num);
		try
		{
			try
			{
				_003CModule_003E = _003CModule_003E;
			}
			catch
			{
				_ = (d2N)Cm3((byte[])(object)Cq8.Default, null, (int)Cq8.Default);
			}
		}
		catch
		{
			try
			{
				Aj8 aj = (Aj8)(object)Cm3(array, Cm3(array, array, 1060726798), -1454155833);
			}
			catch
			{
				n9L = n9L;
				_ = (d5W)(object)Cq8.Default;
				kz = kz;
			}
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u && default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (z3X)(object)Cm3(null, array, num);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d2N d2N);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y0D y0D);
		try
		{
			while (true)
			{
				if ((object)Cm3(array, Cm3((byte[])(object)Cq8.Default, null, (int)Cm3(array, array, (int)checked(unchecked((uint)num) - unchecked((uint)(int)Cm3((byte[])(object)Cq8.Default, Cm3(null, array, (int)checked(unchecked((uint)num / (uint)(int)Cm3(Cm3(null, array, num), array, 361954949)) * unchecked((uint)(int)Cm3(array, Cm3(array, Cm3(null, null, (int)Cm3(Cm3(null, (byte[])(object)Cq8.Default, num), null, -1713721371)), 304674664), (int)checked(unchecked((uint)num) - unchecked(checked((unchecked((uint)(int)Cq8.Default) - unchecked((uint)(int)Cq8.Default)) * unchecked((uint)(int)Cm3(array, array, num))) / (uint)(int)Cm3(array, (byte[])(object)Cq8.Default, (int)checked(3469133658u * 3762522084u)))))))), (int)(2340879435u / (uint)num))) + (unchecked((uint)(int)Cm3(null, Cm3(array, array, num), num)) + 450424479u)))), (int)Cq8.Default) != null)
				{
					d2N = d2N;
				}
				else if (obj3 == null)
				{
					break;
				}
			}
		}
		finally
		{
			_ = (d5W)(object)Cq8.Default;
			y0D = y0D;
			goto IL_1753;
		}
		IL_07ca:
		z3X = z3X;
		do
		{
			try
			{
				_ = (_003CModule_003E)(object)Cq8.Default;
			}
			catch
			{
				if (num2 == 0)
				{
					_ = (y0D)(object)Cm3(null, null, (int)Cq8.Default);
				}
				else
				{
					_ = (z3X)(object)Cm3((byte[])(object)Cq8.Default, array, 123674184);
				}
			}
		}
		while (obj3 != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Kj1 kj);
		try
		{
			while (obj3 != null)
			{
				_ = (_003CModule_003E)(object)Cq8.Default;
			}
		}
		catch
		{
			kj = default(Kj1);
		}
		_ = (Tr3)(object)Cm3(array, Cm3(Cm3(array, null, num), array, (int)Cm3(array, (byte[])(object)Cq8.Default, num)), (int)Cq8.Default);
		wj = (Wj3)(object)Cm3(array, (byte[])(object)Cq8.Default, 1595385443);
		num2 = default(UIntPtr);
		checked
		{
			if (num2 - unchecked((nuint)(UIntPtr)Cm3((byte[])(object)Cq8.Default, null, (int)Cq8.Default)) == 0)
			{
				num2 = default(UIntPtr);
				if (num2 == 0)
				{
					Aj8 aj = null;
				}
				else
				{
					_ = (y0D)(object)Cq8.Default;
				}
			}
			else
			{
				_ = (Gj7)(object)Cm3(array, (byte[])(object)Cq8.Default, num);
			}
		}
		do
		{
			try
			{
				try
				{
					_ = (y0D)(object)Cq8.Default;
				}
				finally
				{
					_ = (Wj3)(object)Cm3(array, array, (int)checked(3919780477u * unchecked((uint)num / checked(unchecked((uint)(int)Cm3(array, array, (int)Cm3(null, null, (int)Cm3(array, array, (int)Cm3(array, (byte[])(object)Cq8.Default, (int)checked(unchecked((uint)(int)Cm3(null, null, -2083445399)) * unchecked((uint)num))))))) * 2224329177u))));
					goto end_IL_0911;
				}
				end_IL_0911:;
			}
			catch
			{
			}
		}
		while (obj3 != null);
		_ = (Gj7)(object)Cq8.Default;
		_ = (n9L)(object)Cm3(null, array, (int)Cm3((byte[])(object)Cq8.Default, array, num));
		d2N = d2N;
		_ = (Wj3)(object)Cq8.Default;
		try
		{
			wj = wj;
			d5W = null;
		}
		catch
		{
			_003CModule_003E = _003CModule_003E;
			_003CModule_003E = _003CModule_003E;
			_ = (Cq8)(object)Cm3(array, array, (int)checked(unchecked((uint)(int)Cm3(Cm3(array, array, (int)Cq8.Default), array, (int)checked(unchecked((uint)num) * 2442262622u - 44421393u))) + unchecked((uint)(int)Cm3(array, array, (int)Cq8.Default))));
		}
		_ = (z3X)(object)Cq8.Default;
		y6Z = null;
		_ = (Tr3)(object)Cq8.Default;
		try
		{
			if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
			{
				wj = wj;
			}
		}
		finally
		{
			try
			{
				y6Z = null;
			}
			finally
			{
				_ = (_003CModule_003E)(object)Cm3(array, array, num);
				goto IL_0a8f;
			}
		}
		IL_02b4:
		if ((UIntPtr)Cm3(array, Cm3(array, null, 1131217221), 725828848) == (UIntPtr)(nuint)0u)
		{
			num2 = (UIntPtr)Cm3(null, null, num);
			num2 = default(UIntPtr);
			if (num2 == (UIntPtr)(nuint)0u)
			{
				kj = (Kj1)Cq8.Default;
				kj = kj;
			}
		}
		_ = (Tr3)(object)Cm3(array, array, (int)((uint)num / (uint)(int)Cm3(array, array, (int)Cm3(null, (byte[])(object)Cq8.Default, (int)Cq8.Default))));
		kz = (Kz1)(object)Cm3(array, array, -1060060753);
		do
		{
			if (num2 != (UIntPtr)(nuint)0u)
			{
				_ = (Lw6)(object)Cm3(array, (byte[])(object)Cq8.Default, num);
				continue;
			}
			try
			{
				n9L = n9L;
			}
			finally
			{
				_ = (y0D)(object)Cq8.Default;
				d2N = (d2N)Cm3(array, Cm3(null, array, -270115481), (int)Cq8.Default);
				d2N = default(d2N);
				_ = (Cq8)(object)Cm3(null, null, (int)checked(unchecked((uint)num) * unchecked((uint)num)));
				continue;
			}
		}
		while ((object)Cm3(array, (byte[])(object)Cq8.Default, (int)Cq8.Default) != null);
		checked
		{
			if (unchecked((nuint)(UIntPtr)Cm3(array, array, (int)Cq8.Default)) * unchecked((nuint)(UIntPtr)Cq8.Default) == 0)
			{
				_ = (n9L)(object)Cq8.Default;
			}
			else
			{
				unchecked
				{
					try
					{
						_ = (Tr3)(object)Cq8.Default;
						_ = (n9L)(object)Cm3(array, array, 720454057);
						_ = (Lw6)(object)Cq8.Default;
					}
					catch
					{
						if (num2 == (UIntPtr)(nuint)0u)
						{
							kj = kj;
						}
						else
						{
							_ = Cq8.Default;
							_ = Cq8.Default;
							_ = (d2N)Cm3(Cm3((byte[])(object)Cq8.Default, array, (int)Cm3(null, null, num)), array, (int)((uint)(int)Cm3(null, array, -535049545) / (uint)(int)Cq8.Default));
						}
					}
				}
			}
			if (unchecked((nuint)default(UIntPtr)) * unchecked((nuint)default(UIntPtr)) * unchecked((nuint)(UIntPtr)Cq8.Default) - unchecked((nuint)default(UIntPtr)) != 0)
			{
				_ = (y0D)(object)Cm3(null, null, -1713619287);
			}
		}
		if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
		{
			num2 = default(UIntPtr);
			if (num2 / num2 / checked(unchecked((nuint)default(UIntPtr)) + unchecked((nuint)default(UIntPtr))) == 0)
			{
				_ = (_003CModule_003E)(object)Cq8.Default;
				_ = (z3X)(object)Cm3(null, null, -1470814693);
			}
			else if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
			{
				kj = default(Kj1);
				_ = (Kj1)Cq8.Default;
				_ = (z3X)(object)Cq8.Default;
			}
		}
		else
		{
			do
			{
				_ = (Gj7)(object)Cq8.Default;
			}
			while ((object)Cq8.Default != null);
		}
		try
		{
			while (true)
			{
				if (obj3 != null)
				{
					_ = (Kz1)(object)Cm3((byte[])(object)Cq8.Default, array, (int)Cq8.Default);
				}
				else if ((object)Cm3((byte[])(object)Cq8.Default, array, 1737430511) == null)
				{
					break;
				}
			}
		}
		catch
		{
			try
			{
				z3X = z3X;
			}
			catch
			{
				try
				{
					_ = (Aj8)(object)Cm3(array, array, -985892618);
					y0D obj15 = (y0D)(object)Cq8.Default;
					y0D = y0D;
					y0D = obj15;
					_ = (Gj7)(object)Cm3(null, (byte[])(object)Cq8.Default, num);
					goto end_IL_05f7;
				}
				catch
				{
					lw = lw;
					y0D = (y0D)(object)Cm3(Cm3(array, array, num), Cm3((byte[])(object)Cq8.Default, array, num), num);
					Wj3 obj16 = (Wj3)(object)Cq8.Default;
					wj = (Wj3)(object)Cm3(array, array, (int)Cq8.Default);
					wj = obj16;
					goto end_IL_05f7;
				}
				end_IL_05f7:;
			}
		}
		num2 = default(UIntPtr);
		if (num2 == 0)
		{
			num2 = default(UIntPtr);
			if (num2 != 0)
			{
			}
			goto IL_07ca;
		}
		try
		{
			UIntPtr num3 = (UIntPtr)Cm3(Cm3(Cm3(null, array, num), array, -971357315), Cm3(array, null, -156681147), (int)Cq8.Default);
			UIntPtr num4 = (UIntPtr)Cm3(Cm3(array, array, (int)checked(2762701822u - (449043625u * unchecked((uint)(int)Cq8.Default) - 1391924907u))), array, num);
			num2 = default(UIntPtr);
			checked
			{
				nuint num5 = unchecked((nuint)num4) - (num2 - unchecked((nuint)(UIntPtr)Cm3((byte[])(object)Cq8.Default, array, (int)checked(unchecked((uint)(int)Cm3(array, array, (int)checked(unchecked((uint)num) + unchecked((uint)num)))) + unchecked((uint)num)))));
				num2 = default(UIntPtr);
				if (unchecked((nuint)num3) * (num5 + num2) == 0)
				{
					_ = (Tr3)(object)Cm3(Cm3(null, array, num), array, unchecked((int)Cm3(array, array, num)));
				}
			}
		}
		finally
		{
			try
			{
				_ = (c2M)(object)Cq8.Default;
			}
			catch
			{
				c2M c2M = null;
				c2M = c2M;
			}
			goto IL_07ca;
		}
		IL_105d:
		do
		{
			try
			{
				if ((UIntPtr)Cm3(array, (byte[])(object)Cq8.Default, num) == (UIntPtr)(nuint)0u)
				{
					lw = lw;
					lw = lw;
					lw = lw;
					_ = (Gj7)(object)Cq8.Default;
				}
				else
				{
					d5W = null;
				}
			}
			finally
			{
				if ((nuint)(UIntPtr)Cq8.Default / (nuint)(UIntPtr)Cm3(array, Cm3(array, array, num), 1938739799) == 0)
				{
					_ = (_003CModule_003E)(object)Cq8.Default;
					_ = Cq8.Default;
					_ = (Cq8)(object)Cm3(Cm3(array, (byte[])(object)Cq8.Default, -2090411873), array, 999386248);
				}
				continue;
			}
		}
		while (obj3 != null);
		Tr3 tr = tr;
		wj = null;
		_ = (Kj1)Cq8.Default;
		_ = (Wj3)(object)Cm3(array, array, num);
		try
		{
			_ = (Kz1)(object)Cm3(null, null, (int)checked(unchecked((uint)(int)Cm3((byte[])(object)Cq8.Default, null, (int)checked(2805077305u + unchecked((uint)(int)Cq8.Default) * unchecked((uint)(int)Cq8.Default)))) * (2894331962u - unchecked((uint)(int)Cq8.Default)) * unchecked((uint)(int)Cm3(array, array, (int)Cm3(array, Cm3(array, null, 71563478), (int)checked(unchecked((uint)(int)Cq8.Default) - unchecked((uint)num) * unchecked((uint)num / (uint)num)))))));
		}
		catch
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = (Wj3)(object)Cm3(null, null, num);
				}
				while ((object)Cm3(array, Cm3(array, array, (int)Cq8.Default), (int)Cm3(null, null, (int)checked(unchecked((uint)(int)Cq8.Default) - unchecked((uint)num) - unchecked((uint)num)))) != null);
			}
		}
		if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				while (obj3 != null)
				{
				}
			}
			finally
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Gj7)(object)Cq8.Default;
				}
				goto IL_1312;
			}
		}
		if ((UIntPtr)Cm3(array, null, (int)Cq8.Default) == (UIntPtr)(nuint)0u)
		{
			try
			{
				_003CModule_003E = _003CModule_003E;
			}
			catch
			{
				_ = (Wj3)(object)Cm3(null, null, (int)Cq8.Default);
				_ = (z3X)(object)Cq8.Default;
			}
		}
		else
		{
			_ = (Tr3)(object)Cm3(Cm3(null, (byte[])(object)Cq8.Default, num), Cm3((byte[])(object)Cq8.Default, array, (int)checked(376727835u - unchecked((uint)num) - unchecked((uint)(int)Cm3(array, array, (int)checked(2026597600u * unchecked((uint)num)))))), (int)checked(unchecked((uint)(int)Cm3(array, (byte[])(object)Cq8.Default, 1590266602)) - unchecked((uint)num)));
		}
		goto IL_1312;
		IL_0d5a:
		try
		{
			num2 = default(UIntPtr);
			nuint num6 = num2;
			UIntPtr num7 = (UIntPtr)Cq8.Default;
			num2 = default(UIntPtr);
			nuint num8 = num2;
			num2 = default(UIntPtr);
			nuint num9 = num8 / num2;
			num2 = default(UIntPtr);
			nuint num11;
			nuint num12;
			checked
			{
				nuint num10 = num6 + (unchecked((nuint)num7) - num9 * num2);
				num2 = default(UIntPtr);
				num11 = num10 + num2;
				num12 = num2;
				num2 = default(UIntPtr);
			}
			if (checked(num11 * (num12 * num2) + num2) == 0)
			{
				_ = (Lw6)(object)Cm3(array, null, (int)Cq8.Default);
				_ = (z3X)(object)Cm3(array, array, (int)Cq8.Default);
				y6Z = y6Z;
			}
		}
		finally
		{
			kz = kz;
			goto IL_0dec;
		}
		IL_0dec:
		tr = null;
		if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				if (num2 == 0)
				{
					d2N = default(d2N);
					d2N = d2N;
				}
				else
				{
					_ = (n9L)(object)Cm3(array, array, (int)((uint)(int)Cq8.Default / (uint)(int)Cq8.Default));
					y0D = null;
					wj = wj;
				}
			}
			finally
			{
				_ = (Gj7)(object)Cq8.Default;
				goto IL_0e52;
			}
		}
		_ = (Gj7)(object)Cq8.Default;
		goto IL_0e52;
		IL_0a8f:
		d5W = d5W;
		lw = null;
		lw = lw;
		try
		{
			if ((nuint)(UIntPtr)Cm3((byte[])(object)Cq8.Default, (byte[])(object)Cq8.Default, 2027679781) / checked(unchecked((nuint)(UIntPtr)Cq8.Default) + unchecked((nuint)(UIntPtr)Cq8.Default)) == 0)
			{
				if ((UIntPtr)Cm3(array, array, (int)checked(unchecked((uint)(int)Cq8.Default) + unchecked((uint)(int)Cq8.Default))) == (UIntPtr)(nuint)0u)
				{
					z3X = z3X;
				}
			}
			else
			{
				while (obj3 != null)
				{
					_ = (Kj1)Cm3(null, Cm3(Cm3(array, null, num), Cm3(array, array, num), (int)Cm3(array, array, num)), 409533835);
				}
			}
		}
		finally
		{
			try
			{
				_ = (_003CModule_003E)(object)Cm3(null, array, (int)Cm3(null, null, (int)Cm3(array, array, (int)((uint)(int)Cm3(array, null, 123468846) / (uint)(int)Cm3(array, null, (int)Cq8.Default)))));
			}
			catch
			{
				num2 = default(UIntPtr);
				if (num2 == 0)
				{
					_003CModule_003E = null;
					_ = (d5W)(object)Cq8.Default;
					_ = (d5W)(object)Cq8.Default;
				}
				else
				{
					_ = (Kz1)(object)Cq8.Default;
				}
			}
			goto IL_0c03;
		}
		IL_1753:
		n9L = n9L;
		return;
		IL_0e52:
		if (num2 == 0)
		{
			num2 = default(UIntPtr);
			if (num2 == 0)
			{
				d5W = (d5W)(object)Cm3((byte[])(object)Cq8.Default, Cm3(Cm3(null, array, (int)Cm3(array, (byte[])(object)Cq8.Default, num)), Cm3(Cm3(array, Cm3(array, (byte[])(object)Cq8.Default, (int)Cm3(array, array, num)), 137312374), null, (int)Cq8.Default), -98563020), num);
			}
			else
			{
				kj = kj;
			}
		}
		try
		{
			_ = (Cq8)(object)Cm3(null, array, num);
		}
		finally
		{
			try
			{
				try
				{
					kj = kj;
				}
				catch
				{
					d2N = default(d2N);
					d2N = d2N;
				}
			}
			catch
			{
				while ((object)Cq8.Default != null)
				{
					d5W = (d5W)(object)Cq8.Default;
				}
			}
			goto IL_0f51;
		}
		IL_0f51:
		do
		{
			lw = lw;
		}
		while (obj3 != null);
		if (num2 == 0)
		{
			try
			{
			}
			catch
			{
				if (unchecked((nuint)default(UIntPtr)) / (unchecked((nuint)default(UIntPtr)) / (nuint)(UIntPtr)Cm3(null, (byte[])(object)Cq8.Default, -1411476898)) == 0)
				{
					d5W = d5W;
				}
			}
		}
		else
		{
			d5W = d5W;
			_ = (Tr3)(object)Cq8.Default;
			_ = (Kj1)Cq8.Default;
			tr = tr;
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			if (default(UIntPtr) != (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Kz1)(object)Cq8.Default;
				}
				finally
				{
					_ = (y0D)(object)Cq8.Default;
					_ = (z3X)(object)Cq8.Default;
					_ = (Kj1)Cm3(Cm3(null, (byte[])(object)Cq8.Default, (int)Cq8.Default), array, (int)checked(unchecked((uint)(int)Cm3((byte[])(object)Cq8.Default, null, 1381102758)) - unchecked((uint)(int)Cq8.Default)));
					goto IL_105d;
				}
			}
			_ = (c2M)(object)Cq8.Default;
		}
		goto IL_105d;
		IL_0c03:
		do
		{
			if ((UIntPtr)Cm3(array, array, (int)Cm3(array, Cm3(null, array, 486701911), (int)Cq8.Default)) == (UIntPtr)(nuint)0u)
			{
				while ((object)Cq8.Default != null)
				{
					_ = (Gj7)(object)Cm3(array, null, -1783973467);
				}
			}
		}
		while (obj3 != null);
		_ = (y0D)(object)Cq8.Default;
		while (obj3 != null)
		{
			try
			{
				if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Gj7)(object)Cm3((byte[])(object)Cq8.Default, null, (int)checked(unchecked((uint)num) + unchecked((uint)(int)Cq8.Default)));
					continue;
				}
				_003CModule_003E = _003CModule_003E;
				y6Z = (y6Z)(object)Cm3(array, array, (int)((uint)(int)Cm3(null, array, num) / (uint)num));
				_ = (Kj1)Cm3(null, null, (int)checked(2029507127u + unchecked((uint)num) + 1927417922u));
				tr = (Tr3)(object)Cm3((byte[])(object)Cq8.Default, (byte[])(object)Cq8.Default, (int)Cq8.Default);
			}
			catch
			{
			}
		}
		if ((nuint)(UIntPtr)Cq8.Default / (nuint)(UIntPtr)Cq8.Default == 0)
		{
			try
			{
				tr = tr;
			}
			catch
			{
				kz = kz;
			}
		}
		try
		{
			try
			{
				try
				{
					_ = (d5W)(object)Cm3(array, array, num);
				}
				finally
				{
					_ = (y6Z)(object)Cm3(array, (byte[])(object)Cq8.Default, 1564860395);
					goto end_IL_0d19;
				}
				end_IL_0d19:;
			}
			finally
			{
				tr = null;
				goto end_IL_0d18;
			}
			end_IL_0d18:;
		}
		finally
		{
			lw = lw;
			goto IL_0d5a;
		}
	}

	static void Ff3()
	{
		object obj;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d5W d5W);
		while (true)
		{
			obj = Cm3(null, array, num);
			if (obj != null)
			{
				try
				{
					byte[] nx = (byte[])(object)Cq8.Default;
					array = null;
					byte[] ko = array;
					num = num;
					d5W obj2 = (d5W)(object)Cm3(nx, ko, num);
					d5W = (d5W)(object)Cm3((byte[])(object)Cq8.Default, array, -1101849753);
					d5W = obj2;
				}
				catch
				{
					_ = (z3X)(object)Cq8.Default;
				}
			}
			else if (obj == null)
			{
				break;
			}
		}
		if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
		{
			_ = (n9L)(object)Cq8.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Lw6 lw);
		try
		{
		}
		finally
		{
			try
			{
			}
			catch
			{
				do
				{
					Lw6 obj4 = (Lw6)(object)Cq8.Default;
					lw = lw;
					lw = obj4;
				}
				while (obj != null);
			}
			goto IL_0097;
		}
		IL_091e:
		nuint num2;
		checked
		{
			if (num2 * num2 + unchecked((nuint)(UIntPtr)Cq8.Default) == 0)
			{
				while (obj != null)
				{
				}
			}
			_ = (Lw6)(object)Cm3(array, Cm3(Cm3(array, array, num), (byte[])(object)Cq8.Default, num), num);
			while (obj != null)
			{
				_ = (d2N)Cq8.Default;
			}
			if (unchecked(unchecked((nuint)default(UIntPtr)) / unchecked((nuint)default(UIntPtr))) + unchecked((nuint)(UIntPtr)Cq8.Default) == 0)
			{
				do
				{
					try
					{
						d5W = d5W;
						lw = lw;
					}
					finally
					{
						_ = (Tr3)(object)Cm3((byte[])(object)Cq8.Default, null, -926070828);
						continue;
					}
				}
				while (obj != null);
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d2N d2N);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n9L n9L);
		Kz1 kz;
		if ((UIntPtr)Cm3(null, Cm3(array, (byte[])(object)Cq8.Default, (int)checked((unchecked((uint)num) - unchecked((uint)num) + unchecked((uint)(int)Cq8.Default)) * unchecked((uint)(int)Cq8.Default))), (int)checked(unchecked((uint)num) + (unchecked((uint)num) - unchecked((uint)(int)Cq8.Default)) + 434957685u - (715516986u + unchecked((uint)(int)Cm3(array, null, (int)checked(3343406735u - (unchecked((uint)num) + 629974081u - 3141555391u))) / (uint)num)))) == (UIntPtr)(nuint)0u)
		{
			n9L = (n9L)(object)Cm3(array, null, (int)checked(1916571475u * unchecked((uint)num)));
		}
		else
		{
			num2 = default(UIntPtr);
			if (num2 == (UIntPtr)(nuint)0u)
			{
				if (num2 == (UIntPtr)(nuint)0u)
				{
					kz = kz;
					_ = (Kj1)Cq8.Default;
					d5W = null;
					kz = kz;
				}
				else
				{
					d2N = default(d2N);
				}
			}
		}
		_ = (n9L)(object)Cq8.Default;
		_ = (z3X)(object)Cq8.Default;
		_003CModule_003E _003CModule_003E = _003CModule_003E;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Kj1 kj);
		try
		{
			do
			{
				_ = (Gj7)(object)Cq8.Default;
			}
			while (obj != null);
		}
		catch
		{
			do
			{
				if ((UIntPtr)Cq8.Default != (UIntPtr)(nuint)0u)
				{
					_ = (_003CModule_003E)(object)Cm3(Cm3(array, array, num), (byte[])(object)Cq8.Default, (int)Cm3(Cm3(Cm3(Cm3(Cm3(array, (byte[])(object)Cq8.Default, (int)Cm3(array, array, (int)Cm3(Cm3(array, array, (int)Cm3(array, array, (int)((uint)(int)Cm3(array, null, (int)checked(unchecked((uint)(int)Cm3(array, array, (int)Cq8.Default)) * (unchecked((uint)num) + (unchecked((uint)num) + 3424889943u)))) / checked(unchecked((uint)num) + unchecked((uint)num))))), array, (int)Cm3(array, null, (int)checked(unchecked((uint)(int)Cm3(null, array, (int)Cq8.Default)) - 811679454u))))), array, (int)checked(unchecked((uint)(int)Cm3(array, (byte[])(object)Cq8.Default, (int)checked(3367106532u + unchecked((uint)(int)Cq8.Default)))) - unchecked((uint)(int)Cm3(null, array, -643932991)) - (unchecked((uint)num) - unchecked((uint)num)))), array, num), array, (int)Cq8.Default), null, num));
				}
				else
				{
					kj = default(Kj1);
				}
			}
			while (obj != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y0D y0D);
		while (obj != null)
		{
			y0D = y0D;
		}
		Cq8 cq = (Cq8)(object)Cm3(null, null, (int)Cm3(array, array, 1239472556));
		return;
		IL_06d1:
		if ((UIntPtr)Cm3(null, array, num) != (UIntPtr)(nuint)0u)
		{
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Wj3 wj);
		if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
		{
			_ = (Kj1)Cm3(array, array, num);
			kz = kz;
			n9L = n9L;
		}
		else
		{
			wj = (Wj3)(object)Cm3(null, array, num);
			_ = (c2M)(object)Cq8.Default;
			_ = (Wj3)(object)Cm3(null, array, (int)Cq8.Default);
		}
		while ((object)Cq8.Default != null)
		{
		}
		wj = wj;
		kj = default(Kj1);
		num2 = default(UIntPtr);
		if (num2 / (nuint)(UIntPtr)Cq8.Default == 0)
		{
			try
			{
				if (num2 == 0)
				{
					_ = (Wj3)(object)Cq8.Default;
					_ = (y0D)(object)Cm3(array, array, num);
					n9L = null;
				}
			}
			catch
			{
				do
				{
					_ = (Gj7)(object)Cm3((byte[])(object)Cq8.Default, (byte[])(object)Cq8.Default, (int)Cq8.Default);
				}
				while (obj != null);
			}
		}
		do
		{
			try
			{
				kz = kz;
			}
			catch
			{
				if (num2 == 0)
				{
					z3X z3X = (z3X)(object)Cm3(array, (byte[])(object)Cq8.Default, num);
				}
			}
		}
		while (obj != null);
		num2 = default(UIntPtr);
		if (num2 == 0)
		{
			wj = wj;
		}
		else
		{
			_ = (Gj7)(object)Cq8.Default;
			_ = (Kj1)Cm3(array, array, (int)(2114753319u / checked(unchecked((uint)num) - unchecked((uint)num))));
		}
		try
		{
			Aj8 aj = null;
		}
		finally
		{
			if (num2 / num2 == 0)
			{
				while (obj != null)
				{
					_ = (Tr3)(object)Cq8.Default;
				}
			}
			else
			{
				_ = (d2N)Cq8.Default;
			}
			goto IL_0846;
		}
		IL_05c7:
		try
		{
			d2N = default(d2N);
		}
		finally
		{
			do
			{
				if (num2 != 0)
				{
					_ = Cq8.Default;
				}
				else
				{
					_ = (Kj1)Cq8.Default;
				}
			}
			while (obj != null);
			goto IL_05fe;
		}
		IL_04d6:
		num2 = default(UIntPtr);
		if (num2 == (UIntPtr)(nuint)0u && (UIntPtr)Cm3(array, (byte[])(object)Cq8.Default, num) == (UIntPtr)(nuint)0u)
		{
			try
			{
				y0D = y0D;
			}
			catch
			{
				_ = Cq8.Default;
			}
		}
		while (obj != null)
		{
			wj = wj;
			_ = (Lw6)(object)Cq8.Default;
			_ = (Tr3)(object)Cm3(null, Cm3(null, array, (int)Cq8.Default), num);
			_ = (c2M)(object)Cm3((byte[])(object)Cq8.Default, array, (int)Cm3((byte[])(object)Cq8.Default, null, -2009728452));
		}
		UIntPtr num3 = num2;
		num2 = default(UIntPtr);
		if ((nuint)num3 / num2 == 0)
		{
			try
			{
				y0D = (y0D)(object)Cm3(null, array, 440798758);
				_ = (z3X)(object)Cq8.Default;
			}
			finally
			{
				_ = (Aj8)(object)Cq8.Default;
				goto IL_05c7;
			}
		}
		try
		{
			_ = (n9L)(object)Cq8.Default;
		}
		finally
		{
			y0D = y0D;
			goto IL_05c7;
		}
		IL_06b6:
		try
		{
			_ = (Aj8)(object)Cq8.Default;
		}
		finally
		{
			_ = (Kz1)(object)Cq8.Default;
			goto IL_06d1;
		}
		IL_0097:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y6Z y6Z);
		Gj7 gj;
		try
		{
			y6Z obj10 = (y6Z)(object)Cq8.Default;
			y6Z = y6Z;
			y6Z = obj10;
		}
		finally
		{
			if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					gj = (Gj7)(object)Cq8.Default;
					gj = null;
				}
				finally
				{
					y0D = null;
					y0D = y0D;
					goto IL_00fa;
				}
			}
			Kj1 obj11 = (Kj1)Cm3(Cm3(null, null, num), null, (int)Cq8.Default);
			kj = kj;
			kj = obj11;
			goto IL_00fa;
		}
		IL_00fa:
		do
		{
			try
			{
				Aj8 aj = null;
				aj = aj;
			}
			catch
			{
				z3X z3X = null;
				z3X = z3X;
			}
		}
		while (obj != null || obj != null);
		gj = (Gj7)(object)Cm3(array, null, 1921902172);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Tr3 tr);
		checked
		{
			num2 = unchecked((nuint)default(UIntPtr)) - unchecked((nuint)(UIntPtr)Cq8.Default);
			if (num2 != 0 && num2 == 0)
			{
				while (obj != null)
				{
					lw = lw;
				}
			}
			while ((object)Cm3(null, null, -370030702) != null)
			{
				tr = (Tr3)(object)Cm3(array, array, num);
				tr = null;
			}
			while (obj != null)
			{
				try
				{
					lw = lw;
				}
				catch
				{
					try
					{
						_ = (y6Z)(object)Cq8.Default;
					}
					catch
					{
						_ = (c2M)(object)Cq8.Default;
					}
				}
			}
		}
		do
		{
			IL_01fc:
			if (obj != null)
			{
				try
				{
					d2N obj15 = (d2N)Cq8.Default;
					d2N = d2N;
					d2N = obj15;
				}
				finally
				{
					_ = (Wj3)(object)Cq8.Default;
					goto IL_01fc;
				}
			}
		}
		while ((object)Cm3((byte[])(object)Cq8.Default, Cm3(null, array, (int)checked(unchecked((uint)num) - 4132999736u * unchecked((uint)num))), (int)Cm3(array, array, num)) != null);
		_ = (Aj8)(object)Cm3(array, Cm3(array, array, (int)Cq8.Default), num);
		if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
		{
			num2 = default(UIntPtr);
			if (num2 == 0)
			{
				try
				{
					gj = gj;
				}
				finally
				{
					_ = (y0D)(object)Cq8.Default;
					goto IL_0280;
				}
			}
		}
		else
		{
			while (obj != null)
			{
				_ = (d2N)Cm3(null, array, num);
			}
		}
		goto IL_0280;
		IL_0846:
		d2N = (d2N)Cq8.Default;
		num2 = default(UIntPtr);
		if (num2 == 0)
		{
			try
			{
				do
				{
					kz = kz;
					_ = (n9L)(object)Cq8.Default;
					kj = (Kj1)Cm3(array, Cm3(Cm3(null, array, 1334348230), array, (int)Cq8.Default), num);
				}
				while (obj != null);
			}
			finally
			{
				n9L = n9L;
				goto IL_091e;
			}
		}
		try
		{
			_ = (Kz1)(object)Cm3(array, array, num);
			_ = (n9L)(object)Cq8.Default;
			gj = gj;
			_ = (n9L)(object)Cq8.Default;
		}
		catch
		{
			_ = (Kz1)(object)Cq8.Default;
		}
		finally
		{
			if ((UIntPtr)Cm3(array, array, num) == (UIntPtr)(nuint)0u)
			{
				cq = cq;
			}
			else
			{
				y0D = (y0D)(object)Cm3(null, array, (int)checked(unchecked((uint)(int)Cq8.Default) + 2422326634u));
			}
			goto IL_091e;
		}
		IL_05fe:
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
			}
		}
		catch
		{
			_ = (z3X)(object)Cq8.Default;
		}
		_ = (Aj8)(object)Cq8.Default;
		_ = (Wj3)(object)Cm3(null, array, (int)checked(3354277247u + unchecked((uint)num)));
		while ((object)Cq8.Default != null)
		{
			gj = gj;
		}
		cq = (Cq8)(object)Cm3(array, array, (int)checked(unchecked((uint)num) - unchecked((uint)(int)Cm3(array, null, num))));
		try
		{
			do
			{
				try
				{
					lw = lw;
				}
				finally
				{
					_ = (Kz1)(object)Cm3(array, null, num);
					continue;
				}
			}
			while (obj != null);
		}
		finally
		{
			do
			{
				kz = null;
				_ = (d2N)Cq8.Default;
				kz = (Kz1)(object)Cm3(array, (byte[])(object)Cq8.Default, 1697973135);
			}
			while (obj != null);
			goto IL_06b6;
		}
		IL_02f4:
		if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
		{
			y6Z = null;
		}
		else
		{
			while (obj != null)
			{
				if ((UIntPtr)Cm3((byte[])(object)Cq8.Default, array, (int)checked(unchecked((uint)num) + (unchecked((uint)(int)Cq8.Default / (uint)num) * 3378942127u + unchecked((uint)(int)Cm3(array, null, num))) * unchecked((uint)(int)Cq8.Default))) == (UIntPtr)(nuint)0u)
				{
					_ = (Kz1)(object)Cm3(array, (byte[])(object)Cq8.Default, 62788188);
				}
			}
		}
		do
		{
			_ = (n9L)(object)Cq8.Default;
			kj = kj;
			wj = wj;
		}
		while (obj != null);
		if (num2 == 0)
		{
			d5W = (d5W)(object)Cm3(array, array, (int)checked(558057297u * unchecked((uint)num)));
		}
		else if (num2 == 0)
		{
			num2 = default(UIntPtr);
			if (num2 == 0)
			{
				d5W = d5W;
			}
		}
		else
		{
			y6Z = y6Z;
		}
		_ = (c2M)(object)Cm3(array, null, (int)checked(1u * unchecked((uint)(int)Cm3(array, Cm3(Cm3(array, array, 955805994), null, (int)Cq8.Default), -446672199))));
		tr = tr;
		gj = (Gj7)(object)Cq8.Default;
		checked
		{
			if (unchecked((nuint)(UIntPtr)Cq8.Default) - num2 == 0)
			{
				try
				{
					try
					{
						_ = (Aj8)(object)Cm3(array, array, num);
					}
					finally
					{
						goto end_IL_0413;
					}
					end_IL_0413:;
				}
				catch
				{
				}
			}
			try
			{
				num2 = default(UIntPtr);
				if (num2 == 0)
				{
					Cq8 obj19 = (Cq8)(object)Cm3(array, array, 1633776222);
					cq = cq;
					cq = obj19;
					_ = (c2M)(object)Cm3(null, array, num);
					_ = Cq8.Default;
					wj = null;
				}
				else
				{
					_ = (Aj8)(object)Cq8.Default;
				}
			}
			catch
			{
				unchecked
				{
					wj = (Wj3)(object)Cm3(array, array, (int)(3354137527u / checked(unchecked((uint)num) - 3518420730u)));
				}
			}
			finally
			{
				if (num2 * unchecked((nuint)(UIntPtr)Cq8.Default) == 0)
				{
					do
					{
						n9L = n9L;
						_ = (Cq8)(object)Cm3((byte[])(object)Cq8.Default, array, num);
						y6Z = null;
					}
					while ((object)Cq8.Default != null);
				}
				goto IL_04d6;
			}
		}
		IL_0280:
		do
		{
			IL_0280_2:
			if ((object)Cq8.Default != null)
			{
				try
				{
					_ = (n9L)(object)Cq8.Default;
				}
				finally
				{
					_ = (_003CModule_003E)(object)Cq8.Default;
					goto IL_0280_2;
				}
			}
		}
		while (obj != null);
		if (num2 == 0)
		{
			try
			{
				Aj8 aj = null;
			}
			catch
			{
				n9L = null;
				n9L = n9L;
			}
			finally
			{
				try
				{
					wj = wj;
					gj = gj;
					_ = (d5W)(object)Cq8.Default;
					d5W = null;
				}
				finally
				{
					_ = (Wj3)(object)Cm3((byte[])(object)Cq8.Default, array, num);
					_ = (z3X)(object)Cm3(array, null, 2083085728);
					_ = (Kz1)(object)Cq8.Default;
					goto IL_02f4;
				}
			}
		}
		goto IL_02f4;
	}

	static void Zy9()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		do
		{
			try
			{
				num = default(UIntPtr);
				num = num;
				if (num == 0)
				{
					array = (byte[])(object)Cq8.Default;
					byte[] ko = array;
					byte[] nx = array;
					byte[] ko2 = array;
					num2 = num2;
					_ = (Tr3)(object)Cm3(null, ko, (int)Cm3(nx, ko2, num2));
				}
			}
			finally
			{
				try
				{
					_ = (d5W)(object)Cq8.Default;
				}
				finally
				{
					_ = (_003CModule_003E)(object)Cq8.Default;
					continue;
				}
			}
		}
		while ((object)Cm3(array, array, num2) != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Gj7 gj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Aj8 aj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n9L n9L);
		if (num == 0)
		{
			gj = gj;
			gj = gj;
		}
		else
		{
			try
			{
				if ((UIntPtr)Cm3(array, array, 1240709026) == (UIntPtr)(nuint)0u)
				{
					n9L = (n9L)(object)Cq8.Default;
					n9L = n9L;
				}
			}
			catch
			{
				try
				{
					n9L = n9L;
				}
				catch
				{
					_ = (c2M)(object)Cm3(array, Cm3(Cm3(null, null, (int)checked(unchecked((uint)(int)Cq8.Default) - 3631931345u)), Cm3(array, null, num2), -1719964362), 209356150);
					_ = (y6Z)(object)Cm3(array, null, num2);
					_003CModule_003E obj = (_003CModule_003E)(object)Cq8.Default;
					_003CModule_003E = (_003CModule_003E)(object)Cq8.Default;
					_003CModule_003E = obj;
					aj = (Aj8)(object)Cm3(array, Cm3(Cm3(null, null, (int)checked(unchecked((uint)(int)Cq8.Default / 2834512626u) - unchecked((uint)(int)Cq8.Default))), null, -1580259054), num2);
					aj = aj;
				}
			}
		}
		do
		{
			_ = (Lw6)(object)Cq8.Default;
		}
		while ((object)Cq8.Default != null);
		_ = Cq8.Default;
		_ = Cq8.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj4);
		while (obj4 != null)
		{
			do
			{
				try
				{
					_ = (_003CModule_003E)(object)Cq8.Default;
				}
				catch
				{
					_ = (Gj7)(object)Cq8.Default;
				}
				obj4 = obj4;
			}
			while (obj4 != null);
		}
		_ = (c2M)(object)Cq8.Default;
		Lw6 lw;
		try
		{
			try
			{
				gj = gj;
			}
			finally
			{
				while ((object)Cq8.Default != null)
				{
					_ = (n9L)(object)Cm3(array, Cm3(Cm3(array, array, num2), array, (int)checked(unchecked((uint)num2) - unchecked((uint)(int)Cm3(array, array, (int)checked(unchecked((uint)(int)Cm3(array, array, (int)Cq8.Default)) - 2902023973u * 1016740643u))))), -254233975);
				}
				goto end_IL_01c1;
			}
			end_IL_01c1:;
		}
		finally
		{
			try
			{
				try
				{
					_ = (Cq8)(object)Cm3(array, array, 105960670);
				}
				finally
				{
					lw = null;
					lw = null;
					goto end_IL_0233;
				}
				end_IL_0233:;
			}
			catch
			{
				try
				{
					_ = (y0D)(object)Cq8.Default;
				}
				catch
				{
					_ = (_003CModule_003E)(object)Cm3(null, array, num2);
				}
			}
			goto IL_0275;
		}
		IL_0e9c:
		_ = (d2N)Cq8.Default;
		if (num == 0)
		{
			try
			{
				y6Z y6Z = y6Z;
				y6Z = null;
			}
			finally
			{
				while (obj4 != null)
				{
					_ = (c2M)(object)Cm3((byte[])(object)Cq8.Default, (byte[])(object)Cq8.Default, -1836402307);
				}
				goto IL_0f02;
			}
		}
		Kz1 kz = null;
		c2M c2M = c2M;
		z3X z3X = z3X;
		_ = (Tr3)(object)Cm3(array, null, (int)Cq8.Default);
		goto IL_0f02;
		IL_02ce:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Kj1 kj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d2N d2N);
		checked
		{
			if (num == 0)
			{
				if (num * unchecked((nuint)default(UIntPtr)) == 0)
				{
					n9L = n9L;
				}
				else if (default(UIntPtr) == unchecked((UIntPtr)(nuint)0u))
				{
					_ = (n9L)(object)Cm3(array, (byte[])(object)Cq8.Default, num2);
				}
			}
			else
			{
				_ = Cq8.Default;
			}
			num = default(UIntPtr);
			if (num == 0)
			{
				_ = (Tr3)(object)Cm3(array, array, -1082541406);
				_ = (Tr3)(object)Cq8.Default;
				_ = (z3X)(object)Cm3(array, Cm3(array, null, 445722180), num2);
			}
			else
			{
				_ = (d5W)(object)Cq8.Default;
			}
			if (unchecked((nuint)(UIntPtr)Cm3(Cm3(array, null, num2), (byte[])(object)Cq8.Default, (int)checked(unchecked((uint)(int)Cm3(null, null, (int)Cm3(null, array, num2))) * unchecked((uint)(int)Cq8.Default)))) + num == 0)
			{
				if (num == 0)
				{
					if (unchecked((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u))
					{
						_ = (Lw6)(object)Cq8.Default;
					}
					else
					{
						kj = (Kj1)Cq8.Default;
						kj = kj;
					}
				}
			}
			else
			{
				try
				{
					aj = aj;
				}
				catch
				{
					do
					{
						d2N = d2N;
						d2N = default(d2N);
					}
					while (obj4 != null);
				}
			}
			gj = gj;
			_ = (y0D)(object)Cq8.Default;
			_ = (y6Z)(object)Cm3(null, array, unchecked((int)Cq8.Default));
			if (num * unchecked((nuint)(UIntPtr)Cm3(array, array, -865803392)) == 0)
			{
				_ = (d2N)Cm3(null, array, num2);
				goto IL_0455;
			}
			try
			{
				kz = kz;
				kz = kz;
			}
			finally
			{
				aj = aj;
				goto IL_0455;
			}
		}
		IL_065e:
		num = default(UIntPtr);
		if (num == 0)
		{
			checked
			{
				if (unchecked((nuint)(UIntPtr)Cq8.Default) * unchecked((nuint)(UIntPtr)Cq8.Default) == 0)
				{
					do
					{
						_ = (y6Z)(object)Cq8.Default;
					}
					while (obj4 != null);
				}
			}
		}
		else if (num == 0)
		{
			try
			{
				_003CModule_003E = _003CModule_003E;
			}
			catch
			{
				_ = (n9L)(object)Cq8.Default;
			}
		}
		else
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				_ = (d2N)Cm3((byte[])(object)Cq8.Default, Cm3(array, null, 1721794805), (int)checked(unchecked((uint)num2) * 2840673081u));
				_ = Cq8.Default;
				_ = (Wj3)(object)Cm3(null, array, (int)checked(148366457u * unchecked((uint)(int)Cm3(null, Cm3(null, null, -565188148), -1452168804)) - unchecked((uint)num2)));
			}
			else
			{
				_ = (y0D)(object)Cm3(array, array, (int)checked(unchecked((uint)(int)Cm3(Cm3(array, array, (int)Cq8.Default), null, 65035164)) * (unchecked((uint)num2) - unchecked((uint)num2) - unchecked((uint)num2)) + 12u));
			}
		}
		try
		{
			try
			{
				try
				{
					kz = null;
				}
				finally
				{
					n9L = n9L;
					goto end_IL_076d;
				}
				end_IL_076d:;
			}
			finally
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (Aj8)(object)Cq8.Default;
				}
				goto end_IL_076c;
			}
			end_IL_076c:;
		}
		finally
		{
			_ = (Aj8)(object)Cm3(null, (byte[])(object)Cq8.Default, (int)Cm3((byte[])(object)Cq8.Default, array, (int)Cq8.Default));
			goto IL_07cc;
		}
		IL_07cc:
		if ((nuint)(UIntPtr)Cm3(array, array, 1171670487) / checked(num * unchecked((nuint)(UIntPtr)Cm3(Cm3((byte[])(object)Cq8.Default, array, 660791915), array, -893709393))) == 0)
		{
			while (true)
			{
				if (obj4 != null)
				{
					_ = (c2M)(object)Cq8.Default;
					_ = (Wj3)(object)Cq8.Default;
				}
				else if (obj4 == null)
				{
					break;
				}
			}
		}
		try
		{
			_ = (_003CModule_003E)(object)Cm3(Cm3((byte[])(object)Cq8.Default, Cm3(array, null, (int)checked(unchecked((uint)num2) - unchecked((uint)num2))), (int)((uint)(int)Cq8.Default / checked(2143313055u - unchecked(checked(unchecked((uint)num2) * unchecked((uint)(int)Cq8.Default)) / (uint)(int)Cq8.Default / checked(unchecked((uint)(int)Cm3(array, (byte[])(object)Cq8.Default, (int)Cm3((byte[])(object)Cq8.Default, Cm3(array, array, (int)checked(unchecked((uint)(int)Cq8.Default) * unchecked((uint)num2))), 1479858967))) - unchecked((uint)num2) + unchecked((uint)(int)Cm3(null, array, 2118237800))))))), null, (int)Cm3(array, null, 1011080297));
		}
		finally
		{
			while ((object)Cm3(array, array, num2) != null)
			{
				_ = (_003CModule_003E)(object)Cq8.Default;
			}
			goto IL_0915;
		}
		IL_054f:
		while (obj4 != null)
		{
		}
		try
		{
			z3X obj10 = (z3X)(object)Cm3(array, array, num2);
			z3X = z3X;
			z3X = obj10;
		}
		finally
		{
			_ = (Gj7)(object)Cq8.Default;
			goto IL_0575;
		}
		IL_0575:
		try
		{
		}
		catch
		{
			try
			{
				while (obj4 != null)
				{
					_ = (Kz1)(object)Cq8.Default;
				}
			}
			finally
			{
				if ((UIntPtr)Cm3(null, array, (int)checked(unchecked((uint)num2) * 4141987059u)) == (UIntPtr)(nuint)0u)
				{
					_ = (y6Z)(object)Cq8.Default;
				}
				else
				{
					_ = (n9L)(object)Cm3(Cm3(null, null, (int)Cm3(null, null, num2)), array, num2);
				}
				goto end_IL_057b;
			}
			end_IL_057b:;
		}
		while (true)
		{
			if (obj4 != null)
			{
				_ = (Aj8)(object)Cm3(array, array, (int)checked(unchecked((uint)(int)Cq8.Default) + 3278631257u * 206395989u));
			}
			else if (obj4 == null)
			{
				break;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d5W d5W);
		try
		{
			_ = (_003CModule_003E)(object)Cq8.Default;
			_ = (y0D)(object)Cm3(array, array, (int)Cq8.Default);
			_ = (Kj1)Cq8.Default;
			_ = (Lw6)(object)Cq8.Default;
		}
		finally
		{
			while (obj4 != null)
			{
				d5W obj12 = (d5W)(object)Cq8.Default;
				d5W = d5W;
				d5W = obj12;
			}
			goto IL_065e;
		}
		IL_0455:
		num = default(UIntPtr);
		checked
		{
			if (num == 0 && num + unchecked((nuint)default(UIntPtr)) == 0)
			{
				Tr3 tr = null;
				tr = tr;
			}
		}
		while ((object)Cm3(array, array, num2) != null)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)Cm3(null, (byte[])(object)Cq8.Default, num2) == (UIntPtr)(nuint)0u)
				{
					gj = gj;
				}
				else
				{
					_ = (n9L)(object)Cq8.Default;
				}
			}
		}
		d2N = d2N;
		try
		{
		}
		catch
		{
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (d5W)(object)Cq8.Default;
			goto IL_054f;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y0D y0D);
		try
		{
			do
			{
				_ = (d5W)(object)Cq8.Default;
				gj = gj;
				_ = (d5W)(object)Cm3(null, Cm3(null, Cm3(null, array, (int)((uint)(int)Cq8.Default / (uint)num2)), num2), num2);
				y0D obj14 = (y0D)(object)Cm3(array, null, num2);
				y0D = y0D;
				y0D = obj14;
			}
			while (obj4 != null);
		}
		finally
		{
			try
			{
				kj = default(Kj1);
				kj = kj;
			}
			finally
			{
				_ = (d5W)(object)Cq8.Default;
				goto IL_054f;
			}
		}
		IL_0e1c:
		num = default(UIntPtr);
		if (checked(num + (num + num)) == 0)
		{
			do
			{
				try
				{
					d2N = default(d2N);
					d2N = d2N;
					kj = kj;
					_ = (Kz1)(object)Cq8.Default;
				}
				finally
				{
					_003CModule_003E = _003CModule_003E;
					continue;
				}
			}
			while (obj4 != null);
			goto IL_0e9c;
		}
		try
		{
			if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
			{
				_ = (z3X)(object)Cq8.Default;
			}
			else
			{
				_ = (Kj1)Cq8.Default;
				n9L = (n9L)(object)Cq8.Default;
			}
		}
		finally
		{
			_ = (Cq8)(object)Cm3(array, null, 869773487);
			goto IL_0e9c;
		}
		IL_09bf:
		checked
		{
			do
			{
				num = default(UIntPtr);
				if (num + unchecked((nuint)(UIntPtr)Cm3(Cm3(array, array, (int)checked(unchecked(checked(487220330u + unchecked(checked(unchecked((uint)(int)Cm3(array, array, 895913814)) + unchecked((uint)num2)) / 3068760326u)) / (uint)num2) + 1284649677u)), array, 334328285)) - num != 0)
				{
					try
					{
						_ = (z3X)(object)Cq8.Default;
					}
					catch
					{
						_ = (Cq8)(object)Cm3((byte[])(object)Cq8.Default, array, num2);
					}
				}
				else
				{
					d2N = default(d2N);
				}
			}
			while ((object)Cm3(array, array, -36173531) != null);
		}
		if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
		{
			z3X = z3X;
		}
		if (num == 0)
		{
			try
			{
				if ((UIntPtr)Cm3(null, array, (int)Cm3(array, (byte[])(object)Cq8.Default, (int)Cm3((byte[])(object)Cq8.Default, array, (int)checked(unchecked((uint)num2) * (unchecked((uint)num2) + unchecked((uint)(int)Cq8.Default)) - 4250225753u)))) == (UIntPtr)(nuint)0u)
				{
					kz = null;
				}
			}
			catch
			{
				try
				{
					_ = (y0D)(object)Cq8.Default;
				}
				finally
				{
					_ = (Lw6)(object)Cm3(array, array, -342288048);
					goto end_IL_0a79;
				}
				end_IL_0a79:;
			}
		}
		else
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				if (num == 0)
				{
					n9L = n9L;
				}
			}
			else
			{
				z3X = null;
			}
		}
		while (obj4 != null)
		{
			do
			{
				_ = (n9L)(object)Cq8.Default;
			}
			while ((object)Cm3(array, array, 1290511583) != null || (object)Cq8.Default != null);
		}
		d2N = (d2N)Cq8.Default;
		_ = (Cq8)(object)Cm3(array, array, num2);
		_ = (Gj7)(object)Cm3((byte[])(object)Cq8.Default, null, -564657157);
		d5W = d5W;
		if (num == 0)
		{
			try
			{
				_ = (d5W)(object)Cq8.Default;
			}
			catch
			{
				_ = (n9L)(object)Cq8.Default;
			}
		}
		lw = (Lw6)(object)Cq8.Default;
		while (obj4 != null)
		{
			if (num == 0)
			{
				aj = aj;
			}
			else
			{
				_ = (n9L)(object)Cq8.Default;
			}
		}
		Wj3 wj;
		checked
		{
			try
			{
				_ = (Aj8)(object)Cq8.Default;
			}
			catch
			{
				nuint num3 = unchecked((nuint)(UIntPtr)Cm3(array, array, (int)((uint)(int)Cm3((byte[])(object)Cq8.Default, null, (int)checked(unchecked((uint)num2) * (unchecked((uint)num2) - 3438673111u))) / checked(unchecked((uint)num2) + unchecked((uint)(int)Cq8.Default))))) + num;
				nuint num4 = num;
				num = default(UIntPtr);
				nuint num5 = num4 * (unchecked((nuint)default(UIntPtr)) * num - unchecked((nuint)(UIntPtr)Cq8.Default) - num * unchecked((nuint)(UIntPtr)Cm3(null, array, (int)Cm3(array, null, -2090252690))));
				num = default(UIntPtr);
				if (num3 * (num5 * num * unchecked((nuint)(UIntPtr)Cq8.Default)) == 0)
				{
					d2N = d2N;
				}
				else
				{
					wj = null;
					wj = wj;
				}
			}
		}
		while (obj4 != null)
		{
			while (obj4 != null)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					y0D = (y0D)(object)Cm3(array, array, (int)checked(unchecked((uint)(int)Cm3(null, array, (int)checked(unchecked((uint)num2) - unchecked(216050858u / (uint)num2)))) - 2094969898u));
				}
				else
				{
					_ = Cq8.Default;
				}
			}
		}
		try
		{
			try
			{
				do
				{
					_ = (Kj1)Cm3(Cm3(Cm3((byte[])(object)Cq8.Default, array, (int)checked(unchecked((uint)num2) * 3209248955u)), null, (int)Cq8.Default), Cm3(Cm3(array, array, 1070487302), Cm3(array, Cm3(array, array, (int)checked(2086799293u + 2961080233u - 1873758886u + unchecked((uint)num2))), (int)Cm3(array, array, (int)checked(unchecked((uint)(int)Cq8.Default / (uint)(int)Cq8.Default) + unchecked((uint)(int)Cq8.Default)))), num2), num2);
				}
				while (obj4 != null);
			}
			catch
			{
				try
				{
					n9L = n9L;
					_ = (_003CModule_003E)(object)Cm3((byte[])(object)Cq8.Default, array, num2);
				}
				finally
				{
					_ = (Tr3)(object)Cq8.Default;
					goto end_IL_0d18;
				}
				end_IL_0d18:;
			}
		}
		catch
		{
			lw = lw;
		}
		wj = (Wj3)(object)Cq8.Default;
		d5W = d5W;
		_ = (y6Z)(object)Cq8.Default;
		checked
		{
			try
			{
				if (unchecked((nuint)(UIntPtr)Cm3((byte[])(object)Cq8.Default, array, (int)Cm3((byte[])(object)Cq8.Default, null, (int)checked((unchecked((uint)(int)Cm3(array, null, (int)(3218087079u / (uint)num2))) * (unchecked((uint)(int)Cq8.Default) * 3321736400u) - 1273070022u) * unchecked((uint)num2) + unchecked((uint)(int)Cm3((byte[])(object)Cq8.Default, null, 305029527)))))) * num == 0)
				{
					wj = (Wj3)(object)Cm3(null, array, 84714680);
				}
			}
			finally
			{
				_ = (d2N)Cm3(array, Cm3(array, (byte[])(object)Cq8.Default, 1909377817), num2);
				goto IL_0e1c;
			}
		}
		IL_0f02:
		try
		{
			num = default(UIntPtr);
			checked
			{
				if (num == 0 && unchecked((nuint)(UIntPtr)Cm3(array, array, num2)) + unchecked((nuint)(UIntPtr)Cq8.Default) == 0)
				{
					aj = null;
					_003CModule_003E = _003CModule_003E;
				}
			}
		}
		catch
		{
			do
			{
				try
				{
					_ = (Aj8)(object)Cq8.Default;
					_ = (n9L)(object)Cm3(Cm3(array, array, -1514481962), array, (int)checked(unchecked((uint)(int)Cq8.Default) - 955205944u));
					aj = null;
					_ = (y0D)(object)Cm3(null, array, (int)Cm3(array, array, num2));
				}
				finally
				{
					_003CModule_003E = _003CModule_003E;
					continue;
				}
			}
			while ((object)Cm3(null, array, (int)Cm3(Cm3(array, null, (int)((uint)num2 / 771107926u)), array, (int)checked(unchecked((uint)num2) * unchecked((uint)num2)))) != null);
		}
		if (num == 0)
		{
			if (num == 0)
			{
				while ((object)Cq8.Default != null)
				{
					kj = (Kj1)Cm3(null, array, 1174088434);
					aj = (Aj8)(object)Cm3(array, array, -1215673522);
					wj = wj;
				}
			}
			else
			{
				d2N = d2N;
				_ = Cq8.Default;
				_ = (y6Z)(object)Cq8.Default;
			}
		}
		try
		{
			try
			{
				try
				{
					_ = (Tr3)(object)Cq8.Default;
				}
				finally
				{
					_ = (d5W)(object)Cm3((byte[])(object)Cq8.Default, null, 2058708645);
					goto end_IL_1023;
				}
				end_IL_1023:;
			}
			catch
			{
				try
				{
					_ = (n9L)(object)Cm3(array, array, (int)checked(unchecked((uint)(int)Cq8.Default) + unchecked((uint)(int)Cm3((byte[])(object)Cq8.Default, Cm3(Cm3(array, (byte[])(object)Cq8.Default, (int)Cq8.Default), Cm3(array, Cm3(array, array, -1203431257), num2), (int)checked(3663702394u * unchecked((uint)num2 / (uint)(int)Cm3(array, (byte[])(object)Cq8.Default, (int)checked(unchecked((uint)(int)Cm3(Cm3(array, null, 614030278), array, (int)((uint)(int)Cq8.Default / (uint)(int)Cq8.Default))) - unchecked((uint)(int)Cq8.Default)))))), 1560027612))));
				}
				catch
				{
					_ = (y6Z)(object)Cq8.Default;
				}
			}
		}
		catch
		{
			_003CModule_003E = _003CModule_003E;
		}
		if (num == 0)
		{
			do
			{
				try
				{
					_ = (Tr3)(object)Cm3(array, null, 1083002828);
					n9L = (n9L)(object)Cq8.Default;
					_ = (Gj7)(object)Cm3(array, null, (int)checked(unchecked((uint)num2 / checked(unchecked((uint)(int)Cm3((byte[])(object)Cq8.Default, Cm3(null, array, (int)checked(4202889632u + 637282320u)), -256433510)) + unchecked((uint)num2))) + unchecked((uint)num2 / (uint)(int)Cm3(array, array, (int)Cq8.Default)) + (unchecked((uint)num2) + unchecked((uint)num2))));
				}
				finally
				{
					y0D = y0D;
					continue;
				}
			}
			while (obj4 != null);
		}
		_ = (d2N)Cm3(array, Cm3(array, array, num2), 1734598214);
		_ = (y0D)(object)Cq8.Default;
		while (obj4 != null)
		{
			try
			{
				_ = (Kj1)Cq8.Default;
			}
			finally
			{
				do
				{
					z3X = z3X;
				}
				while ((object)Cm3(array, array, num2) != null);
				continue;
			}
		}
		if (checked(unchecked((nuint)(UIntPtr)Cq8.Default / (nuint)(UIntPtr)Cm3(array, array, (int)Cm3(Cm3(null, null, num2), null, (int)((uint)(int)Cq8.Default / (uint)(int)Cm3(array, null, (int)(checked(1440317506u * unchecked((uint)(int)Cm3(array, array, (int)Cq8.Default)) - unchecked((uint)num2)) / (uint)num2)))))) + unchecked((nuint)(UIntPtr)Cq8.Default)) == 0)
		{
			_ = (Cq8)(object)Cm3(Cm3(array, array, 133282268), array, (int)Cq8.Default);
		}
		try
		{
			_ = (n9L)(object)Cq8.Default;
			return;
		}
		catch
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = (d5W)(object)Cq8.Default;
				}
				while (obj4 != null);
			}
			else if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
			{
				n9L = n9L;
			}
			else
			{
				_ = (y0D)(object)Cm3(null, array, num2);
			}
			return;
		}
		IL_0275:
		if (num == 0)
		{
			try
			{
				while (obj4 != null)
				{
					_ = (Cq8)(object)Cm3(null, Cm3(null, (byte[])(object)Cq8.Default, 1393950554), 1375136108);
				}
			}
			finally
			{
				do
				{
					_ = (z3X)(object)Cm3(array, (byte[])(object)Cq8.Default, 1592175648);
				}
				while (obj4 != null);
				goto IL_02ce;
			}
		}
		goto IL_02ce;
		IL_0915:
		try
		{
			_ = (y6Z)(object)Cq8.Default;
		}
		catch
		{
			while ((object)Cq8.Default != null)
			{
				try
				{
					_ = (n9L)(object)Cq8.Default;
				}
				finally
				{
					aj = null;
					continue;
				}
			}
		}
		try
		{
			while (obj4 != null)
			{
				kz = kz;
			}
		}
		finally
		{
			while (obj4 != null)
			{
				try
				{
					d2N = d2N;
				}
				catch
				{
					_ = (Wj3)(object)Cm3(null, null, num2);
				}
			}
			goto IL_09bf;
		}
	}
}
