using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using Af6;
using Cz1;
using Gb9;
using Jb7;
using Qa4;
using Yb9;
using a1G;
using a2W;
using f8F;
using n7E;
using r6F;
using t7Z;
using y0J;
using y9M;

namespace Em4;

public class Lw6
{
	internal static List<byte[]> s4Y()
	{
		List<byte[]> list = new List<byte[]>();
		string[] h = Tr3.H;
		foreach (string name in h)
		{
			using Stream stream_ = a2Q().GetManifestResourceStream(name);
			list.Add(Gj7.Ko2(stream_));
		}
		return list;
	}

	internal static Assembly a2Q()
	{
		return Assembly.GetExecutingAssembly();
	}

	static void Ff1()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		nuint num2 = num;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		byte[] nx = array;
		int num3 = -1689779635;
		array = Aj8.Cm3(nx, null, -1689779635);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Kz1 kz);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z3X z3X);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n9L n9L);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Gj7 gj);
		checked
		{
			num = num2 + (unchecked((nuint)(UIntPtr)Aj8.Cm3(array, null, -1689779635)) - (num + unchecked((nuint)(UIntPtr)Aj8.Cm3(array, Aj8.Cm3((byte[])(object)Cq8.Default, null, -584763292), (int)checked(2605187661u + unchecked((uint)(int)Cq8.Default) * 2969216272u)))) * (num + unchecked((nuint)(UIntPtr)Cq8.Default)));
			if (num == 0)
			{
				gj = (Gj7)(object)Cq8.Default;
				gj = gj;
			}
			else
			{
				try
				{
					try
					{
						_ = (z3X)(object)Aj8.Cm3(array, array, -571323769);
					}
					finally
					{
						_ = (Wj3)(object)Aj8.Cm3(Aj8.Cm3(array, null, num3), (byte[])(object)Cq8.Default, unchecked((int)((uint)(int)Cq8.Default / (uint)(int)Cq8.Default)));
						goto end_IL_00b4;
					}
					end_IL_00b4:;
				}
				catch
				{
					if (num - unchecked((nuint)default(UIntPtr)) == 0)
					{
						_ = (Wj3)(object)Aj8.Cm3((byte[])(object)Cq8.Default, null, -815620077);
						n9L = n9L;
						n9L = n9L;
						Kz1 obj = (Kz1)(object)Cq8.Default;
						kz = kz;
						kz = obj;
						_ = (d2N)Aj8.Cm3(Aj8.Cm3(array, array, num3), null, -529567311);
					}
					else
					{
						z3X = z3X;
						z3X = null;
					}
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Wj3 wj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		try
		{
			do
			{
				_003CModule_003E obj3 = (_003CModule_003E)(object)Cq8.Default;
				_003CModule_003E = (_003CModule_003E)(object)Aj8.Cm3(array, array, (int)checked(unchecked((uint)num3) * unchecked((uint)(int)Cq8.Default)));
				_003CModule_003E = obj3;
			}
			while ((object)Aj8.Cm3(null, null, (int)Aj8.Cm3((byte[])(object)Cq8.Default, Aj8.Cm3(array, array, (int)checked(unchecked((uint)(int)Cq8.Default) * unchecked((uint)num3))), (int)checked(unchecked((uint)num3) * unchecked((uint)num3) + (unchecked((uint)(int)Cq8.Default) + unchecked((uint)(int)Cq8.Default))))) != null);
		}
		catch
		{
			do
			{
				try
				{
					wj = wj;
					wj = null;
				}
				finally
				{
					z3X = null;
					goto IL_0256;
				}
				IL_0256:
				obj4 = obj4;
			}
			while (obj4 != null);
		}
		Cq8 cq = cq;
		cq = null;
		do
		{
			try
			{
				n9L = n9L;
				_ = (z3X)(object)Cq8.Default;
				z3X = z3X;
				_ = (Tr3)(object)Aj8.Cm3(null, array, num3);
			}
			finally
			{
				try
				{
					cq = (Cq8)(object)Aj8.Cm3(array, array, (int)Aj8.Cm3(array, null, (int)Cq8.Default));
				}
				catch
				{
					_ = (Aj8)(object)Cq8.Default;
				}
				continue;
			}
		}
		while ((object)Cq8.Default != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d5W d5W);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y0D y0D);
		try
		{
			while (obj4 != null)
			{
				try
				{
					d5W = null;
					d5W = d5W;
					y0D = y0D;
					y0D = null;
				}
				catch
				{
					_ = (d5W)(object)Cq8.Default;
				}
			}
		}
		catch
		{
			num = default(UIntPtr);
			if (checked(num + num) == 0)
			{
				_ = (Gj7)(object)Cq8.Default;
			}
			else
			{
				do
				{
					_ = (_003CModule_003E)(object)Aj8.Cm3(null, array, num3);
				}
				while (obj4 != null);
			}
		}
		_ = (n9L)(object)Cq8.Default;
		while (obj4 != null)
		{
			do
			{
				_ = (y6Z)(object)Aj8.Cm3(array, null, (int)Aj8.Cm3((byte[])(object)Cq8.Default, array, (int)checked(206745546u + 145005078u * 675952838u)));
			}
			while ((object)Aj8.Cm3(Aj8.Cm3(array, array, (int)Aj8.Cm3((byte[])(object)Cq8.Default, array, (int)((uint)num3 / 44951609u))), null, num3) != null || obj4 != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c2M c2M);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Aj8 aj);
		try
		{
			do
			{
				try
				{
					c2M = c2M;
					c2M = c2M;
					_ = (y6Z)(object)Cq8.Default;
					aj = (Aj8)(object)Cq8.Default;
					aj = aj;
				}
				catch
				{
					_ = (Lw6)(object)Aj8.Cm3(null, array, (int)Cq8.Default);
					_003CModule_003E = _003CModule_003E;
					_ = (_003CModule_003E)(object)Aj8.Cm3(array, array, (int)Aj8.Cm3((byte[])(object)Cq8.Default, array, -1830235777));
				}
			}
			while ((object)Aj8.Cm3(array, null, (int)Cq8.Default) != null);
		}
		catch
		{
			while ((object)Cq8.Default != null)
			{
				_ = (Tr3)(object)Cq8.Default;
				_ = (y0D)(object)Cq8.Default;
				_ = (n9L)(object)Cq8.Default;
				_ = (Aj8)(object)Cq8.Default;
			}
		}
		while ((object)Cq8.Default != null)
		{
			try
			{
				_ = (Kz1)(object)Cq8.Default;
			}
			finally
			{
				n9L = n9L;
				_ = (Lw6)(object)Aj8.Cm3(array, array, (int)Cq8.Default);
				continue;
			}
		}
		try
		{
			do
			{
				d5W = null;
			}
			while (obj4 != null);
		}
		catch
		{
			do
			{
				_ = (c2M)(object)Cq8.Default;
			}
			while (obj4 != null || obj4 != null);
		}
		try
		{
			while (obj4 != null)
			{
				_ = (c2M)(object)Aj8.Cm3((byte[])(object)Cq8.Default, (byte[])(object)Cq8.Default, num3);
				c2M = null;
			}
		}
		catch
		{
			kz = kz;
		}
		aj = aj;
		z3X = null;
		_ = (Lw6)(object)Cq8.Default;
		UIntPtr num4 = (UIntPtr)Cq8.Default;
		num = default(UIntPtr);
		if ((nuint)num4 / num == 0)
		{
			while (obj4 != null)
			{
				try
				{
					_ = (y0D)(object)Cq8.Default;
				}
				finally
				{
					_ = (d2N)Cq8.Default;
					continue;
				}
			}
		}
		try
		{
			_ = (Gj7)(object)Aj8.Cm3((byte[])(object)Cq8.Default, (byte[])(object)Cq8.Default, (int)Cq8.Default);
		}
		finally
		{
			goto IL_0675;
		}
		IL_0e18:
		nuint num5 = num;
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y6Z y6Z);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Tr3 tr);
		if (num5 / num == 0)
		{
			_ = (y0D)(object)Cq8.Default;
			z3X = z3X;
			tr = null;
		}
		else
		{
			n9L = null;
			y6Z = y6Z;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Kj1 kj);
		do
		{
			if (num != 0)
			{
				if (num / (nuint)(UIntPtr)Cq8.Default == 0)
				{
					_ = (y6Z)(object)Aj8.Cm3((byte[])(object)Cq8.Default, array, (int)checked(unchecked((uint)num3) - unchecked((uint)(int)Cq8.Default)));
				}
				else
				{
					_ = (Kj1)Aj8.Cm3(array, array, -1279105748);
				}
			}
			else
			{
				cq = null;
				kj = kj;
			}
		}
		while (obj4 != null);
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				_ = (d2N)Cq8.Default;
			}
			else
			{
				do
				{
					y6Z = y6Z;
					_ = (d2N)Aj8.Cm3(null, null, 1626360266);
				}
				while (obj4 != null);
			}
		}
		else if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (d5W)(object)Cq8.Default;
			}
			catch
			{
				kj = kj;
			}
		}
		else
		{
			do
			{
				_ = (Kj1)Cq8.Default;
			}
			while (obj4 != null);
		}
		aj = (Aj8)(object)Cq8.Default;
		try
		{
			_ = (n9L)(object)Cq8.Default;
		}
		catch
		{
			_ = (d2N)Cq8.Default;
		}
		do
		{
			aj = aj;
		}
		while (obj4 != null);
		checked
		{
			try
			{
				UIntPtr num6 = num;
				num = default(UIntPtr);
				if (unchecked((nuint)num6) + num == 0)
				{
					if (unchecked((UIntPtr)Aj8.Cm3(null, array, 523446959) == (UIntPtr)(nuint)0u))
					{
						_ = (_003CModule_003E)(object)Aj8.Cm3(array, null, num3);
					}
					else
					{
						kz = kz;
					}
				}
				else if (num == 0)
				{
					_ = (z3X)(object)Cq8.Default;
				}
				else
				{
					c2M = (c2M)(object)Cq8.Default;
				}
			}
			catch
			{
				_ = (Aj8)(object)Cq8.Default;
			}
			if (unchecked((nuint)(UIntPtr)Aj8.Cm3(null, array, num3)) * unchecked((nuint)(UIntPtr)Aj8.Cm3(array, array, num3)) == 0)
			{
				num = default(UIntPtr);
				unchecked
				{
					if (checked(num - num) == 0)
					{
						try
						{
							c2M = c2M;
						}
						catch
						{
							_ = (d5W)(object)Aj8.Cm3(null, array, (int)Aj8.Cm3((byte[])(object)Cq8.Default, (byte[])(object)Cq8.Default, (int)Aj8.Cm3(array, null, (int)checked(3702483859u + (unchecked((uint)num3) - unchecked((uint)num3))))));
						}
					}
					else
					{
						_ = (c2M)(object)Aj8.Cm3((byte[])(object)Cq8.Default, null, (int)Aj8.Cm3(null, (byte[])(object)Cq8.Default, (int)checked(unchecked((uint)(int)Cq8.Default) - unchecked((uint)num3))));
					}
				}
			}
			cq = cq;
		}
		_ = (Tr3)(object)Aj8.Cm3(null, null, (int)Aj8.Cm3(null, Aj8.Cm3(array, null, (int)(954155102u / (uint)(int)Cq8.Default)), (int)Aj8.Cm3(Aj8.Cm3(array, array, num3), array, (int)Aj8.Cm3(array, array, (int)checked(unchecked((uint)num3) + unchecked((uint)num3))))));
		cq = cq;
		gj = gj;
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			while (obj4 != null)
			{
				z3X = (z3X)(object)Cq8.Default;
			}
		}
		try
		{
			try
			{
				_ = (y6Z)(object)Cq8.Default;
			}
			catch
			{
				if ((UIntPtr)Aj8.Cm3((byte[])(object)Cq8.Default, array, (int)((uint)(int)Cq8.Default / 2253343135u)) == (UIntPtr)(nuint)0u)
				{
					y0D = y0D;
				}
			}
		}
		catch
		{
			do
			{
				_ = (y0D)(object)Cq8.Default;
			}
			while ((object)Aj8.Cm3(Aj8.Cm3((byte[])(object)Cq8.Default, array, 611626148), array, -2017346565) != null);
		}
		while (obj4 != null)
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				do
				{
					wj = wj;
					_ = (Cq8)(object)Aj8.Cm3(null, array, num3);
					_ = (Gj7)(object)Aj8.Cm3((byte[])(object)Cq8.Default, array, -658343593);
				}
				while (obj4 != null);
			}
			else
			{
				do
				{
					gj = gj;
					d2N d2N = default(d2N);
				}
				while ((object)Cq8.Default != null);
			}
		}
		num = default(UIntPtr);
		if (num == 0)
		{
			do
			{
				kj = (Kj1)Cq8.Default;
			}
			while (obj4 != null);
		}
		z3X = null;
		_ = (Tr3)(object)Cq8.Default;
		_ = (Kz1)(object)Aj8.Cm3(null, array, (int)Aj8.Cm3(array, array, num3));
		_ = (d5W)(object)Cq8.Default;
		_ = (y0D)(object)Cq8.Default;
		_ = (Tr3)(object)Aj8.Cm3(null, array, num3);
		kj = kj;
		_ = (c2M)(object)Aj8.Cm3(Aj8.Cm3(array, (byte[])(object)Cq8.Default, num3), null, (int)Aj8.Cm3(null, array, -932322651));
		tr = tr;
		checked
		{
			while (obj4 != null)
			{
				if (unchecked((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u))
				{
					num = default(UIntPtr);
					if (num * (unchecked((nuint)(UIntPtr)Cq8.Default) * unchecked((nuint)(UIntPtr)Aj8.Cm3(null, null, (int)Aj8.Cm3(array, array, 642629335)))) == 0)
					{
						c2M = c2M;
					}
				}
			}
			if (num == 0)
			{
				_ = (y0D)(object)Aj8.Cm3(array, array, 959783155);
			}
			try
			{
				if (unchecked((nuint)(UIntPtr)Aj8.Cm3(null, Aj8.Cm3(null, array, (int)checked(1575426110u * unchecked((uint)num3))), (int)Aj8.Cm3(Aj8.Cm3(array, null, num3), null, (int)((uint)(int)Aj8.Cm3(null, null, (int)((uint)(int)Cq8.Default / (uint)num3)) / 709881904u)))) * num == 0)
				{
					if (num == 0)
					{
						_ = (d2N)Aj8.Cm3(null, Aj8.Cm3(array, array, unchecked((int)Aj8.Cm3(array, null, (int)Cq8.Default))), num3);
					}
					else
					{
						aj = null;
					}
				}
			}
			finally
			{
				do
				{
					if (num != 0)
					{
						_ = (Tr3)(object)Cq8.Default;
					}
					else
					{
						n9L = n9L;
					}
				}
				while ((object)Cq8.Default != null);
				goto IL_14b8;
			}
		}
		IL_168c:
		_ = (n9L)(object)Cq8.Default;
		return;
		IL_0949:
		num = default(UIntPtr);
		if (num == 0)
		{
			try
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					kz = (Kz1)(object)Aj8.Cm3(array, array, num3);
				}
			}
			finally
			{
				while (obj4 != null)
				{
					_ = (_003CModule_003E)(object)Cq8.Default;
					n9L = n9L;
					c2M = c2M;
				}
				goto IL_09e8;
			}
		}
		try
		{
			try
			{
				_ = (Kz1)(object)Cq8.Default;
			}
			catch
			{
				d5W = d5W;
			}
		}
		catch
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				c2M = (c2M)(object)Cq8.Default;
			}
		}
		goto IL_09e8;
		IL_09e8:
		checked
		{
			if (unchecked((nuint)(UIntPtr)Aj8.Cm3(array, Aj8.Cm3(array, array, (int)Cq8.Default), -1622171100)) + unchecked((nuint)(UIntPtr)Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)checked(2649759459u + unchecked((uint)(int)Cq8.Default)))) == 0)
			{
				do
				{
					_ = (Wj3)(object)Cq8.Default;
				}
				while ((object)Cq8.Default != null || obj4 != null);
			}
			else
			{
				try
				{
					UIntPtr num7 = unchecked((UIntPtr)Cq8.Default);
					num = default(UIntPtr);
					if (unchecked((nuint)num7) - num == 0)
					{
						d2N d2N = (d2N)Aj8.Cm3(array, (byte[])(object)Cq8.Default, num3);
						z3X = z3X;
						_003CModule_003E = _003CModule_003E;
					}
				}
				catch
				{
					do
					{
						kz = (Kz1)(object)Aj8.Cm3(array, array, num3);
					}
					while (obj4 != null);
				}
			}
			_ = (Tr3)(object)Cq8.Default;
			if (num == 0)
			{
				try
				{
					try
					{
						cq = (Cq8)(object)Aj8.Cm3(null, null, num3);
					}
					finally
					{
						y6Z = (y6Z)(object)Cq8.Default;
						y6Z = y6Z;
						goto end_IL_0ae8;
					}
					end_IL_0ae8:;
				}
				catch
				{
					_ = (Lw6)(object)Cq8.Default;
				}
			}
		}
		while ((object)Aj8.Cm3(array, array, num3) != null)
		{
			try
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (d2N)Cq8.Default;
				}
				else
				{
					y0D = null;
				}
			}
			finally
			{
				_ = (y0D)(object)Aj8.Cm3(null, null, (int)checked(unchecked((uint)num3) + 3462143557u));
				continue;
			}
		}
		if (num == 0)
		{
			try
			{
				cq = (Cq8)(object)Aj8.Cm3(array, array, 1050675063);
			}
			catch
			{
				try
				{
					d5W = null;
				}
				catch
				{
					_ = (d2N)Aj8.Cm3(null, array, num3);
					z3X = z3X;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Lw6 lw);
		if ((UIntPtr)Aj8.Cm3(Aj8.Cm3(null, null, (int)Aj8.Cm3(array, (byte[])(object)Cq8.Default, -2071478015)), array, (int)checked(unchecked((uint)(int)Aj8.Cm3(array, array, -2060691683)) * unchecked((uint)(int)Aj8.Cm3(array, null, (int)Cq8.Default)))) == (UIntPtr)(nuint)0u)
		{
			if (num == 0)
			{
				tr = tr;
				tr = null;
				wj = null;
				lw = null;
				z3X = z3X;
			}
		}
		else
		{
			do
			{
				y0D = (y0D)(object)Aj8.Cm3(Aj8.Cm3(Aj8.Cm3(array, null, -1112913890), array, num3), (byte[])(object)Cq8.Default, -83815177);
			}
			while (obj4 != null);
		}
		nuint num8 = num;
		num = default(UIntPtr);
		if (checked(num8 * (num - num - num)) == 0)
		{
			d5W = null;
			goto IL_0e18;
		}
		try
		{
			do
			{
				_ = (Gj7)(object)Aj8.Cm3((byte[])(object)Cq8.Default, null, (int)checked(unchecked((uint)(int)Aj8.Cm3((byte[])(object)Cq8.Default, Aj8.Cm3(null, array, (int)checked(1018240367u + unchecked((uint)num3))), -1382425804)) - unchecked((uint)(int)Aj8.Cm3(array, array, (int)((uint)num3 / (uint)(int)Aj8.Cm3(Aj8.Cm3(Aj8.Cm3((byte[])(object)Cq8.Default, Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)Aj8.Cm3(null, array, num3)), (int)Aj8.Cm3(array, array, num3)), array, (int)((uint)num3 / checked(unchecked((uint)num3) * (unchecked((uint)(int)Cq8.Default) * unchecked((uint)(int)Aj8.Cm3(array, null, (int)checked(unchecked((uint)(int)Aj8.Cm3(array, null, (int)Cq8.Default)) - 2057704716u))))) / (uint)num3)), array, (int)Cq8.Default))))));
			}
			while (obj4 != null);
		}
		finally
		{
			while ((object)Cq8.Default != null)
			{
				_ = (z3X)(object)Cq8.Default;
			}
			goto IL_0e18;
		}
		IL_0675:
		while ((object)Aj8.Cm3(null, null, (int)Cq8.Default) != null)
		{
			if (num == 0)
			{
				while (obj4 != null)
				{
					cq = cq;
				}
				continue;
			}
			num = default(UIntPtr);
			if (num == 0)
			{
				_ = (Gj7)(object)Aj8.Cm3(array, (byte[])(object)Cq8.Default, num3);
				kj = kj;
				kj = kj;
			}
		}
		nuint num9;
		checked
		{
			num9 = unchecked((nuint)(UIntPtr)Aj8.Cm3((byte[])(object)Cq8.Default, array, (int)Cq8.Default)) + unchecked((nuint)(UIntPtr)Aj8.Cm3(null, array, num3));
			num = default(UIntPtr);
		}
		if (num9 / num == 0)
		{
			do
			{
				num = default(UIntPtr);
				if (num != 0)
				{
					_ = (d5W)(object)Aj8.Cm3(Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)checked(unchecked((uint)(int)Aj8.Cm3(array, array, (int)checked(unchecked((uint)(int)Aj8.Cm3(array, array, -144678939)) * (unchecked((uint)num3 / 3251458332u) + unchecked((uint)num3)) + unchecked((uint)(int)Aj8.Cm3(array, Aj8.Cm3(null, (byte[])(object)Cq8.Default, (int)Aj8.Cm3(array, null, num3)), (int)Aj8.Cm3(array, null, (int)Aj8.Cm3(array, Aj8.Cm3(array, null, (int)Cq8.Default), (int)Aj8.Cm3(array, array, (int)Aj8.Cm3((byte[])(object)Cq8.Default, Aj8.Cm3(array, Aj8.Cm3(array, array, -1639534051), 1), (int)checked(unchecked((uint)num3) * unchecked((uint)num3))))))))))) * unchecked((uint)num3))), array, num3);
					aj = (Aj8)(object)Aj8.Cm3(array, array, 2077245691);
					Lw6 obj25 = (Lw6)(object)Aj8.Cm3(array, array, num3);
					lw = lw;
					lw = obj25;
				}
				else
				{
					y0D = null;
				}
			}
			while (obj4 != null);
		}
		if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u && num / num == 0 && default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (Tr3)(object)Cq8.Default;
			d2N d2N = d2N;
			_ = (Aj8)(object)Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)Cq8.Default);
			_ = (n9L)(object)Aj8.Cm3(array, array, num3);
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				z3X = z3X;
			}
			finally
			{
				if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
				{
					lw = lw;
				}
				else
				{
					_ = (Kj1)Cq8.Default;
					_ = (z3X)(object)Cq8.Default;
					aj = null;
				}
				goto IL_0949;
			}
		}
		while (obj4 != null)
		{
			do
			{
				d5W = (d5W)(object)Cq8.Default;
			}
			while ((object)Cq8.Default != null);
		}
		goto IL_0949;
		IL_14b8:
		try
		{
			do
			{
				nuint num10 = num;
				num = default(UIntPtr);
				if (checked(num10 - num) != 0)
				{
					n9L = n9L;
					n9L = n9L;
				}
				else
				{
					c2M = c2M;
				}
			}
			while (obj4 != null);
		}
		finally
		{
			UIntPtr num11 = (UIntPtr)Aj8.Cm3(null, array, (int)Aj8.Cm3(array, Aj8.Cm3(Aj8.Cm3(null, null, 605566374), array, (int)Aj8.Cm3(Aj8.Cm3(array, (byte[])(object)Cq8.Default, num3), Aj8.Cm3(array, null, (int)Cq8.Default), 115103438)), 1714046444));
			num = default(UIntPtr);
			if ((nuint)num11 / checked((unchecked((nuint)default(UIntPtr)) + num) * num) == 0)
			{
				try
				{
					kj = (Kj1)Cq8.Default;
				}
				catch
				{
					_ = (n9L)(object)Cq8.Default;
				}
			}
			goto IL_15c4;
		}
		IL_15c4:
		try
		{
			do
			{
				y6Z = null;
				lw = null;
				tr = null;
				lw = lw;
			}
			while (obj4 != null);
		}
		catch
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (y6Z)(object)Cq8.Default;
			}
		}
		lw = lw;
		lw = null;
		if (unchecked((nuint)default(UIntPtr)) / unchecked((nuint)default(UIntPtr)) == 0)
		{
			try
			{
				gj = gj;
			}
			finally
			{
				try
				{
					_ = (Gj7)(object)Cq8.Default;
				}
				finally
				{
					y0D = (y0D)(object)Aj8.Cm3((byte[])(object)Cq8.Default, Aj8.Cm3(null, Aj8.Cm3(array, array, num3), num3), num3);
					goto IL_168c;
				}
			}
		}
		goto IL_168c;
	}

	static void Ht4()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num2);
		n9L n9L;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		try
		{
			num = default(UIntPtr);
			num = num;
			if (num == 0)
			{
				obj = null;
			}
			else
			{
				_ = (Gj7)(object)Cq8.Default;
			}
		}
		finally
		{
			try
			{
				_ = (_003CModule_003E)(object)Cq8.Default;
			}
			finally
			{
				byte[] nx = (byte[])(object)Cq8.Default;
				array = array;
				byte[] ko = array;
				num2 = num2;
				n9L obj2 = (n9L)(object)Aj8.Cm3(nx, ko, (int)checked(251738650u + unchecked((uint)num2)));
				n9L = null;
				n9L = obj2;
				_ = (y0D)(object)Aj8.Cm3(Aj8.Cm3(array, array, num2), array, num2);
				goto IL_006f;
			}
		}
		IL_006f:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Kz1 kz);
		if ((UIntPtr)Aj8.Cm3(null, Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)Cq8.Default), (int)Aj8.Cm3(null, null, -1852622447)) == (UIntPtr)(nuint)0u && (UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
		{
			kz = kz;
			kz = null;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Gj7 gj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Wj3 wj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y0D y0D);
		while ((object)Cq8.Default != null)
		{
			try
			{
				try
				{
					_ = (c2M)(object)Aj8.Cm3(array, Aj8.Cm3(array, Aj8.Cm3(array, array, (int)(1579321870u / (uint)num2)), (int)checked((unchecked((uint)num2) + unchecked((uint)(int)Cq8.Default)) * unchecked((uint)num2))), -1232364671);
					y0D = y0D;
					y0D = null;
					_ = (c2M)(object)Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)checked(2124198318u + 2512002796u));
					wj = null;
					wj = null;
				}
				finally
				{
					Gj7 obj3 = (Gj7)(object)Aj8.Cm3(Aj8.Cm3((byte[])(object)Cq8.Default, (byte[])(object)Cq8.Default, -95552278), array, (int)checked(unchecked((uint)(int)Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)checked(unchecked((uint)(int)Aj8.Cm3(array, null, 1559055026) / 0u) - unchecked((uint)(int)Aj8.Cm3(array, array, num2))))) + unchecked((uint)(int)Cq8.Default)));
					gj = gj;
					gj = obj3;
					goto end_IL_00cb;
				}
				end_IL_00cb:;
			}
			finally
			{
				while ((object)Cq8.Default != null)
				{
					y0D = y0D;
				}
				continue;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y6Z y6Z);
		try
		{
			while ((object)Cq8.Default != null)
			{
				while (obj != null)
				{
					y6Z = y6Z;
					y6Z = y6Z;
				}
			}
		}
		catch
		{
			_ = (Aj8)(object)Aj8.Cm3(array, array, (int)checked(unchecked((uint)(int)Aj8.Cm3(null, null, -781481045)) + 2866777719u));
			_ = (Kj1)Aj8.Cm3(Aj8.Cm3(array, array, -629981240), null, -443855787);
			n9L = null;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cq8 cq);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Tr3 tr);
		try
		{
			try
			{
				do
				{
					_ = (Wj3)(object)Aj8.Cm3(array, null, num2);
				}
				while (obj != null);
			}
			catch
			{
				try
				{
					_ = Cq8.Default;
				}
				finally
				{
					y0D = y0D;
					Tr3 obj5 = (Tr3)(object)Cq8.Default;
					tr = tr;
					tr = obj5;
					kz = null;
					goto end_IL_0254;
				}
				end_IL_0254:;
			}
		}
		catch
		{
			if (num != 0)
			{
				try
				{
					_ = (y6Z)(object)Cq8.Default;
				}
				finally
				{
					_ = (_003CModule_003E)(object)Cq8.Default;
					_ = (Tr3)(object)Aj8.Cm3(null, array, (int)(checked(601967701u + unchecked((uint)(int)Cq8.Default)) / checked(unchecked((uint)num2) + unchecked((uint)(int)Aj8.Cm3(array, array, (int)checked(unchecked((uint)num2) - unchecked((uint)(int)Cq8.Default)))))));
					_ = (Wj3)(object)Cq8.Default;
					goto end_IL_0282;
				}
			}
			num = default(UIntPtr);
			if (num == 0)
			{
				_ = (y6Z)(object)Cq8.Default;
			}
			else
			{
				cq = null;
				cq = cq;
			}
			end_IL_0282:;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Aj8 aj);
		while (obj != null)
		{
			try
			{
				try
				{
					wj = null;
				}
				finally
				{
					Aj8 obj8 = (Aj8)(object)Cq8.Default;
					aj = (Aj8)(object)Aj8.Cm3(Aj8.Cm3((byte[])(object)Cq8.Default, array, (int)Aj8.Cm3(array, null, (int)Cq8.Default)), array, (int)Aj8.Cm3(array, null, (int)checked((unchecked((uint)num2) - 408329230u) * 3936271553u)));
					aj = obj8;
					goto end_IL_030b;
				}
				end_IL_030b:;
			}
			catch
			{
				y0D = y0D;
				_ = (d2N)Cq8.Default;
				_ = (Aj8)(object)Cq8.Default;
			}
		}
		_003CModule_003E obj10 = (_003CModule_003E)(object)Cq8.Default;
		_003CModule_003E _003CModule_003E = null;
		_003CModule_003E = obj10;
		kz = kz;
		try
		{
			while (obj != null)
			{
				_ = (Aj8)(object)Aj8.Cm3(Aj8.Cm3(null, array, (int)Aj8.Cm3(array, null, (int)checked(2078135918u + unchecked((uint)(int)Cq8.Default)))), (byte[])(object)Cq8.Default, -155356802);
				_ = (Wj3)(object)Aj8.Cm3(null, array, (int)Cq8.Default);
				_ = (Tr3)(object)Aj8.Cm3(array, Aj8.Cm3(array, Aj8.Cm3(Aj8.Cm3(null, array, num2), (byte[])(object)Cq8.Default, (int)Cq8.Default), 670287588), (int)checked(unchecked((uint)num2) + (unchecked((uint)(int)Aj8.Cm3(null, array, (int)(4177780489u / checked(unchecked((uint)(int)Cq8.Default) * 906948765u))) / (uint)num2) + (unchecked((uint)num2 / checked((unchecked((uint)num2) - unchecked((uint)(int)Cq8.Default)) * unchecked((uint)num2))) + 2117131430u + unchecked((uint)num2))) - 1823214742u));
			}
		}
		finally
		{
			if ((UIntPtr)Aj8.Cm3(array, array, (int)Cq8.Default) == (UIntPtr)(nuint)0u)
			{
				_ = (d5W)(object)Aj8.Cm3(Aj8.Cm3(null, array, (int)Cq8.Default), null, num2);
			}
			else
			{
				try
				{
					wj = null;
				}
				catch
				{
					cq = null;
				}
			}
			goto IL_04e6;
		}
		IL_0bd5:
		if ((UIntPtr)Aj8.Cm3(array, array, (int)Aj8.Cm3(null, array, (int)Aj8.Cm3(array, array, (int)Aj8.Cm3(null, Aj8.Cm3(null, array, -1545450292), -1766757019)))) == (UIntPtr)(nuint)0u && num == (UIntPtr)(nuint)0u)
		{
			_ = (Gj7)(object)Cq8.Default;
		}
		d5W d5W;
		if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				_ = (Lw6)(object)Aj8.Cm3((byte[])(object)Cq8.Default, array, -2041113216);
			}
			else
			{
				tr = tr;
				_ = (_003CModule_003E)(object)Aj8.Cm3((byte[])(object)Cq8.Default, array, -1911844504);
				_ = (c2M)(object)Cq8.Default;
			}
		}
		else
		{
			do
			{
				try
				{
					_ = (Lw6)(object)Cq8.Default;
				}
				catch
				{
					d5W = null;
				}
			}
			while ((object)Aj8.Cm3(array, null, num2) != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Kj1 kj);
		if (num == (UIntPtr)(nuint)0u)
		{
			do
			{
				y0D = null;
			}
			while (obj != null);
		}
		else
		{
			if (num != (UIntPtr)(nuint)0u)
			{
				try
				{
					gj = gj;
				}
				finally
				{
					kj = (Kj1)Aj8.Cm3(array, null, -1644643895);
					goto IL_0d1c;
				}
			}
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				_ = (Tr3)(object)Cq8.Default;
				gj = (Gj7)(object)Aj8.Cm3(null, array, num2);
				_ = (Cq8)(object)Aj8.Cm3(array, array, num2);
				_ = (Lw6)(object)Cq8.Default;
			}
			else
			{
				_ = Cq8.Default;
			}
		}
		goto IL_0d1c;
		IL_065b:
		if (num == 0)
		{
			cq = cq;
			goto IL_06a6;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c2M c2M);
		try
		{
			_ = (Wj3)(object)Cq8.Default;
			wj = (Wj3)(object)Cq8.Default;
			wj = wj;
			c2M obj13 = (c2M)(object)Aj8.Cm3(array, array, 1182278252);
			c2M = c2M;
			c2M = obj13;
		}
		finally
		{
			_ = (Tr3)(object)Cq8.Default;
			goto IL_06a6;
		}
		IL_0aa3:
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				try
				{
					c2M = null;
				}
				finally
				{
					c2M = c2M;
					_ = (y0D)(object)Aj8.Cm3(array, array, (int)checked((3125607471u - unchecked((uint)(int)Cq8.Default) * unchecked((uint)(int)Aj8.Cm3(array, array, (int)((uint)num2 / (uint)(int)Cq8.Default)))) * unchecked(checked(unchecked((uint)num2) + 1010525213u) / (uint)num2)));
					goto IL_0b70;
				}
			}
		}
		else
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (d2N)Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)checked(unchecked(3629265478u / checked(unchecked((uint)(int)Cq8.Default / checked(2212939630u - 2965172118u * 3610297903u)) + unchecked((uint)num2)) / (uint)(int)Cq8.Default) * 1894204416u));
				}
				catch
				{
					_ = (c2M)(object)Cq8.Default;
				}
			}
		}
		goto IL_0b70;
		IL_0d1c:
		if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)Cq8.Default != (UIntPtr)(nuint)0u)
			{
				try
				{
					y6Z = y6Z;
				}
				finally
				{
					y6Z = (y6Z)(object)Cq8.Default;
					goto IL_0d91;
				}
			}
			if ((UIntPtr)Aj8.Cm3((byte[])(object)Cq8.Default, array, (int)checked(unchecked((uint)(int)Cq8.Default) - 3597228459u)) == (UIntPtr)(nuint)0u)
			{
				_ = (Lw6)(object)Aj8.Cm3(null, array, -1842547073);
			}
			else
			{
				_ = (Aj8)(object)Cq8.Default;
			}
		}
		goto IL_0d91;
		IL_0ee9:
		try
		{
			UIntPtr num3 = (UIntPtr)Aj8.Cm3(array, Aj8.Cm3(array, array, (int)checked(1334119189u * unchecked((uint)(int)Cq8.Default))), -1772991361);
			num = default(UIntPtr);
			if (checked(unchecked((nuint)num3) - num + num * num) == 0)
			{
				kz = (Kz1)(object)Aj8.Cm3(null, array, (int)checked(unchecked((uint)(int)Aj8.Cm3(null, array, 31768225)) - unchecked((uint)num2)));
			}
		}
		catch
		{
			while (obj != null)
			{
				try
				{
					_ = Cq8.Default;
				}
				finally
				{
					d5W = d5W;
					continue;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z3X z3X);
		if (num == 0)
		{
			while (obj != null)
			{
				try
				{
					_ = (d2N)Cq8.Default;
				}
				finally
				{
					z3X = z3X;
					continue;
				}
			}
		}
		else
		{
			y6Z = y6Z;
		}
		while ((object)Aj8.Cm3(null, array, -276886203) != null)
		{
			d5W = null;
		}
		num = default(UIntPtr);
		if (num == 0)
		{
			try
			{
				while (obj != null)
				{
					gj = null;
				}
			}
			finally
			{
				try
				{
					y6Z = null;
				}
				catch
				{
					kj = default(Kj1);
				}
				goto IL_0ff7;
			}
		}
		do
		{
			c2M = c2M;
		}
		while ((object)Aj8.Cm3(null, null, 79548617) != null || obj != null);
		goto IL_0ff7;
		IL_06a6:
		do
		{
			_ = (_003CModule_003E)(object)Cq8.Default;
		}
		while ((object)Cq8.Default != null);
		kz = (Kz1)(object)Cq8.Default;
		_ = (d5W)(object)Aj8.Cm3(array, null, (int)checked(unchecked((uint)num2) - unchecked((uint)(int)Cq8.Default / (uint)(int)Aj8.Cm3(array, array, (int)checked(unchecked((uint)num2) * 267773168u))) + unchecked((uint)(int)Cq8.Default) * unchecked((uint)(int)Aj8.Cm3(array, Aj8.Cm3(array, Aj8.Cm3(null, Aj8.Cm3(null, null, (int)Aj8.Cm3(null, array, (int)Aj8.Cm3(array, array, (int)Cq8.Default))), (int)checked((unchecked((uint)num2) - (unchecked((uint)(int)Cq8.Default) + unchecked((uint)num2))) * (unchecked((uint)(int)Cq8.Default) + unchecked((uint)(int)Cq8.Default / (uint)num2)))), num2), -167883423)) * unchecked((uint)num2)));
		d5W = (d5W)(object)Aj8.Cm3(array, array, (int)Aj8.Cm3(null, (byte[])(object)Cq8.Default, (int)checked(3160912324u - unchecked((uint)num2))));
		d5W = null;
		try
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				_ = (y6Z)(object)Cq8.Default;
			}
		}
		catch
		{
			if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					kj = kj;
					kj = kj;
				}
				catch
				{
					kj = kj;
				}
			}
		}
		do
		{
			try
			{
				if (num == 0)
				{
					y6Z = y6Z;
				}
				else
				{
					z3X = z3X;
				}
			}
			catch
			{
				_ = (_003CModule_003E)(object)Cq8.Default;
				c2M = c2M;
			}
		}
		while (obj != null);
		_ = (Lw6)(object)Cq8.Default;
		while (true)
		{
			if ((object)Aj8.Cm3(array, array, num2) != null)
			{
				_ = (_003CModule_003E)(object)Cq8.Default;
			}
			else if (obj == null && (object)Cq8.Default == null)
			{
				break;
			}
		}
		_ = (Lw6)(object)Cq8.Default;
		try
		{
			try
			{
				try
				{
					_ = (n9L)(object)Cq8.Default;
				}
				finally
				{
					_ = (d5W)(object)Cq8.Default;
					wj = wj;
					n9L = n9L;
					wj = (Wj3)(object)Aj8.Cm3(null, null, num2);
					goto end_IL_0851;
				}
				end_IL_0851:;
			}
			finally
			{
				try
				{
					_ = (Gj7)(object)Cq8.Default;
				}
				finally
				{
					_ = (Kz1)(object)Aj8.Cm3(null, null, (int)checked(unchecked((uint)num2) - 1315017920u));
					goto end_IL_0850;
				}
			}
			end_IL_0850:;
		}
		finally
		{
			_003CModule_003E = _003CModule_003E;
			goto IL_08b3;
		}
		IL_0b70:
		_ = (Gj7)(object)Cq8.Default;
		_ = (d5W)(object)Cq8.Default;
		if (num == (UIntPtr)(nuint)0u)
		{
			try
			{
				gj = null;
				_ = (Lw6)(object)Aj8.Cm3(array, array, 502793459);
				_ = (Gj7)(object)Aj8.Cm3(Aj8.Cm3(null, array, num2), (byte[])(object)Cq8.Default, (int)Cq8.Default);
				aj = null;
			}
			finally
			{
				wj = wj;
				goto IL_0bd5;
			}
		}
		goto IL_0bd5;
		IL_04e6:
		if (num == 0)
		{
			while (obj != null)
			{
			}
		}
		while (true)
		{
			if (obj != null)
			{
				_ = (c2M)(object)Aj8.Cm3(null, (byte[])(object)Cq8.Default, 1431758018);
			}
			else if (obj == null)
			{
				break;
			}
		}
		try
		{
			num = default(UIntPtr);
			if (num != 0)
			{
				try
				{
					_ = (c2M)(object)Aj8.Cm3(Aj8.Cm3(null, null, (int)Cq8.Default), Aj8.Cm3(Aj8.Cm3(array, array, num2), null, (int)Aj8.Cm3(null, (byte[])(object)Cq8.Default, (int)checked(2730774663u + unchecked((uint)num2) - unchecked((uint)(int)Aj8.Cm3((byte[])(object)Cq8.Default, array, (int)checked(4002048490u + unchecked((uint)num2))))))), -1437387266);
				}
				finally
				{
					_ = (d5W)(object)Aj8.Cm3(array, null, num2);
					goto end_IL_0513;
				}
			}
			_ = (Aj8)(object)Cq8.Default;
			end_IL_0513:;
		}
		catch
		{
			try
			{
				try
				{
					_ = (Kj1)Aj8.Cm3(array, null, (int)Cq8.Default);
				}
				finally
				{
					_ = (Tr3)(object)Cq8.Default;
					goto end_IL_05bb;
				}
				end_IL_05bb:;
			}
			finally
			{
				_ = (n9L)(object)Cq8.Default;
				_ = (Aj8)(object)Aj8.Cm3(Aj8.Cm3(array, array, num2), array, -1944327559);
				goto end_IL_05ba;
			}
			end_IL_05ba:;
		}
		try
		{
			try
			{
				do
				{
					_ = (d2N)Aj8.Cm3(array, null, -1927755643);
				}
				while ((object)Aj8.Cm3(null, null, num2) != null);
			}
			finally
			{
				_ = (z3X)(object)Aj8.Cm3((byte[])(object)Cq8.Default, array, 370766555);
				goto end_IL_0612;
			}
			end_IL_0612:;
		}
		finally
		{
			if (num == 0)
			{
			}
			goto IL_065b;
		}
		IL_0d91:
		_ = (Gj7)(object)Aj8.Cm3(array, null, (int)checked(2362660755u * unchecked((uint)(int)Cq8.Default) + unchecked((uint)num2)));
		aj = aj;
		while ((object)Cq8.Default != null)
		{
			if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
			{
				while (obj != null)
				{
					_ = (Lw6)(object)Cq8.Default;
				}
			}
			else
			{
				do
				{
					y0D = y0D;
				}
				while ((object)Aj8.Cm3(null, (byte[])(object)Cq8.Default, (int)checked(unchecked((uint)num2) * unchecked((uint)num2))) != null);
			}
		}
		if (num == (UIntPtr)(nuint)0u)
		{
			do
			{
				try
				{
					gj = gj;
				}
				catch
				{
					n9L = n9L;
					gj = gj;
					aj = aj;
				}
			}
			while ((object)Aj8.Cm3(array, Aj8.Cm3(array, array, num2), 598491691) != null);
		}
		do
		{
			gj = gj;
			y0D = (y0D)(object)Cq8.Default;
			_ = (Wj3)(object)Aj8.Cm3(array, array, (int)Cq8.Default);
			tr = tr;
		}
		while (obj != null);
		_ = (Kz1)(object)Cq8.Default;
		num = default(UIntPtr);
		if (num == 0)
		{
			try
			{
				try
				{
					_ = (d2N)Aj8.Cm3(array, array, (int)checked(unchecked((uint)num2) - unchecked((uint)num2)));
				}
				finally
				{
					_ = (Gj7)(object)Aj8.Cm3(array, array, num2);
					kj = default(Kj1);
					goto end_IL_0e7a;
				}
				end_IL_0e7a:;
			}
			finally
			{
				kz = kz;
				goto IL_0ee9;
			}
		}
		if (num == 0)
		{
			_ = (Tr3)(object)Cq8.Default;
			gj = gj;
			_ = (Aj8)(object)Cq8.Default;
			tr = null;
		}
		else
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				_ = (n9L)(object)Cq8.Default;
			}
		}
		goto IL_0ee9;
		IL_08b3:
		_ = (Aj8)(object)Aj8.Cm3(array, Aj8.Cm3(null, array, 1875610253), (int)checked(2913064919u + unchecked((uint)(int)Aj8.Cm3(Aj8.Cm3(Aj8.Cm3(array, null, num2), (byte[])(object)Cq8.Default, (int)checked(unchecked(334784070u / (3971626017u / (uint)(int)Aj8.Cm3(array, null, (int)checked(unchecked((uint)(int)Cq8.Default) + unchecked((uint)num2) + unchecked((uint)num2))))) - unchecked(checked(unchecked((uint)num2) * (unchecked((uint)(int)Cq8.Default) - 1443996893u + (unchecked((uint)(int)Cq8.Default) + unchecked((uint)(int)Cq8.Default)))) / (uint)num2))), null, num2))));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d2N d2N);
		if (num == 0)
		{
			if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
			{
				nuint num4 = num;
				nuint num5 = num;
				UIntPtr num6 = (UIntPtr)Cq8.Default;
				num = default(UIntPtr);
				if (num4 / (num5 / ((nuint)num6 / num)) == 0)
				{
					gj = (Gj7)(object)Cq8.Default;
				}
				else
				{
					_ = (Lw6)(object)Aj8.Cm3(array, Aj8.Cm3(array, array, 1673555203), 649387552);
				}
			}
		}
		else
		{
			d2N obj22 = (d2N)Cq8.Default;
			d2N = (d2N)Aj8.Cm3(array, Aj8.Cm3((byte[])(object)Cq8.Default, null, num2), num2);
			d2N = obj22;
		}
		while ((object)Aj8.Cm3(Aj8.Cm3(array, array, (int)checked(unchecked(4056187661u / checked(unchecked((uint)(int)Aj8.Cm3(array, null, num2) / (uint)(int)Aj8.Cm3(array, array, num2)) * 960518468u + 2714870701u)) + 2241353111u)), array, 1748904374) != null)
		{
			aj = aj;
		}
		while (obj != null)
		{
			_003CModule_003E = _003CModule_003E;
		}
		try
		{
			do
			{
				d2N = d2N;
			}
			while (obj != null);
		}
		finally
		{
			if (num == 0)
			{
				while ((object)Aj8.Cm3(array, array, num2) != null)
				{
					_ = (d5W)(object)Aj8.Cm3(Aj8.Cm3(array, null, (int)(checked(unchecked((uint)(int)Aj8.Cm3(array, null, 1572273513)) + 2556275271u) / (uint)num2)), null, (int)Cq8.Default);
				}
			}
			else
			{
				kj = kj;
			}
			goto IL_0aa3;
		}
		IL_0ff7:
		do
		{
			if (num == 0)
			{
				try
				{
					gj = gj;
				}
				finally
				{
					c2M = c2M;
					continue;
				}
			}
		}
		while (obj != null);
		try
		{
			do
			{
				d2N = default(d2N);
			}
			while (obj != null);
		}
		catch
		{
			_ = (n9L)(object)Aj8.Cm3(null, (byte[])(object)Cq8.Default, num2);
		}
		while (obj != null)
		{
			d5W = d5W;
		}
		do
		{
			if (checked(num + unchecked((nuint)(UIntPtr)Aj8.Cm3(array, array, num2))) != 0)
			{
				while ((object)Cq8.Default != null)
				{
					_003CModule_003E = _003CModule_003E;
				}
			}
			else
			{
				_ = (Cq8)(object)Aj8.Cm3(Aj8.Cm3(Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)checked((unchecked(3900992854u / (uint)(int)Aj8.Cm3(array, array, (int)(checked(unchecked((uint)num2) - 3906133842u) / (uint)(int)Aj8.Cm3(array, Aj8.Cm3(array, array, (int)checked(unchecked((uint)num2) * unchecked((uint)(int)Cq8.Default))), (int)checked(1448183700u - (unchecked((uint)num2) - unchecked((uint)num2))))))) + unchecked(checked(unchecked((uint)(int)Aj8.Cm3(null, null, num2)) - 2576512582u) / checked(922353253u * 3729992352u - 3200079605u))) * unchecked((uint)(int)Cq8.Default))), array, num2), (byte[])(object)Cq8.Default, num2);
			}
		}
		while (obj != null);
		_ = (Wj3)(object)Cq8.Default;
		_ = (d2N)Cq8.Default;
	}
}
