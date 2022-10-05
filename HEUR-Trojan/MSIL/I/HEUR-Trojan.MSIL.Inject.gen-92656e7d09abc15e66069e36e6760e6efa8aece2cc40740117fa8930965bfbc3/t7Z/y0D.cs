using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Af6;
using Cz1;
using Em4;
using Gb9;
using Jb7;
using Microsoft.VisualBasic.CompilerServices;
using Qa4;
using Yb9;
using a1G;
using a2W;
using f8F;
using n7E;
using r6F;
using y0J;
using y9M;

namespace t7Z;

public class y0D
{
	internal static Type[] Jd4()
	{
		Type[] array = new Type[30];
		try
		{
			int num = 0;
			foreach (Type exportedType in q9W().ExportedTypes)
			{
				Type type = (array[num] = exportedType);
				num = checked(num + 1);
				if (num > 29)
				{
					break;
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return array;
	}

	private static object Zp5()
	{
		return AppDomain.CurrentDomain;
	}

	internal static Assembly q9W()
	{
		object obj = Zp5();
		object[] obj2 = new object[1] { Tr3.G };
		object[] array = obj2;
		bool[] obj3 = new bool[1] { true };
		bool[] array2 = obj3;
		Assembly result = (Assembly)NewLateBinding.LateGet(obj, (Type)null, "Load", obj2, (string[])null, (Type[])null, obj3);
		if (array2[0])
		{
			Tr3.G = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(byte[]));
		}
		return result;
	}

	static void x0E()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		c2M c2M;
		while (true)
		{
			obj = obj;
			if (obj != null)
			{
				c2M = (c2M)(object)Cq8.Default;
				c2M = c2M;
			}
			else if ((object)Cq8.Default == null)
			{
				break;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		c2M = (c2M)(object)Aj8.Cm3(array, null, (int)Aj8.Cm3(array, array, (int)Cq8.Default));
		_ = (Tr3)(object)Aj8.Cm3(null, null, (int)Cq8.Default);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d2N d2N);
		do
		{
			try
			{
				try
				{
					_ = (n9L)(object)Aj8.Cm3(array, array, -1888806213);
				}
				catch
				{
					_ = (Aj8)(object)Cq8.Default;
				}
			}
			catch
			{
				while (obj != null)
				{
					d2N = d2N;
					d2N = d2N;
				}
			}
		}
		while ((object)Cq8.Default != null);
		y6Z y6Z;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Wj3 wj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cq8 cq);
		try
		{
			try
			{
				y6Z = null;
				y6Z = y6Z;
				d2N = d2N;
				cq = Cq8.Default;
				cq = cq;
				_ = (d5W)(object)Aj8.Cm3(array, array, -62557108);
			}
			finally
			{
				while (obj != null)
				{
					_ = (y0D)(object)Cq8.Default;
				}
				goto end_IL_00cc;
			}
			end_IL_00cc:;
		}
		finally
		{
			wj = wj;
			wj = wj;
			_ = (Kj1)Cq8.Default;
			_ = (Kj1)Cq8.Default;
			cq = cq;
			goto IL_015a;
		}
		IL_037c:
		while (obj != null)
		{
			_ = (Kz1)(object)Cq8.Default;
		}
		_ = (y0D)(object)Cq8.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Aj8 aj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Kj1 kj);
		Tr3 tr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Kz1 kz);
		checked
		{
			if (num != 0)
			{
				if (num + num == 0)
				{
					_ = (Wj3)(object)Cq8.Default;
					kj = (Kj1)Cq8.Default;
					kj = default(Kj1);
					_ = (z3X)(object)Cq8.Default;
				}
				else if (num == 0)
				{
					_ = (z3X)(object)Cq8.Default;
				}
				else
				{
					_ = (c2M)(object)Cq8.Default;
				}
			}
			do
			{
				try
				{
					if (unchecked((nuint)(UIntPtr)Cq8.Default) + num == 0)
					{
						tr = tr;
					}
				}
				catch
				{
					kz = (Kz1)(object)Aj8.Cm3(array, null, unchecked((int)Cq8.Default));
				}
			}
			while ((object)Cq8.Default != null);
			try
			{
				try
				{
					_ = (Lw6)(object)Cq8.Default;
				}
				catch
				{
					c2M = c2M;
				}
				finally
				{
					aj = aj;
					y6Z = y6Z;
					goto end_IL_0443;
				}
				end_IL_0443:;
			}
			finally
			{
				while (true)
				{
					if ((object)Cq8.Default != null)
					{
						_ = Cq8.Default;
					}
					else if ((object)Cq8.Default == null)
					{
						break;
					}
				}
				goto IL_049f;
			}
		}
		IL_0cf9:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num2);
		do
		{
			try
			{
				if (num == 0)
				{
					_ = (d5W)(object)Aj8.Cm3(null, Aj8.Cm3(null, array, num2), -2094058790);
				}
				else
				{
					_ = (y0D)(object)Cq8.Default;
				}
			}
			catch
			{
				if ((UIntPtr)Aj8.Cm3(null, null, (int)Aj8.Cm3(array, array, num2)) == (UIntPtr)(nuint)0u)
				{
					kj = kj;
					continue;
				}
				_ = (Gj7)(object)Cq8.Default;
				_ = (z3X)(object)Aj8.Cm3(null, array, -178899303);
			}
		}
		while (obj != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y0D y0D2);
		while ((object)Aj8.Cm3(null, array, (int)checked(unchecked((uint)num2) + unchecked((uint)(int)Aj8.Cm3(array, Aj8.Cm3(array, Aj8.Cm3(array, (byte[])(object)Cq8.Default, 2114680874), num2), num2)))) != null)
		{
			if (num == 0)
			{
				_ = (Wj3)(object)Cq8.Default;
			}
			else
			{
				y0D2 = y0D2;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Gj7 gj);
		do
		{
			if (num == 0)
			{
				do
				{
					gj = gj;
				}
				while (obj != null);
			}
		}
		while (obj != null);
		wj = wj;
		_ = (Tr3)(object)Cq8.Default;
		_ = (Cq8)(object)Aj8.Cm3(array, array, -483156947);
		checked
		{
			while ((object)Aj8.Cm3(array, null, 1199996802) != null)
			{
				try
				{
					nuint num3 = num;
					num = default(UIntPtr);
					nuint num4 = num3 * (num - unchecked((nuint)(UIntPtr)Cq8.Default));
					nuint num5 = num;
					num = default(UIntPtr);
					if (num4 + (num5 - (num + unchecked((nuint)(UIntPtr)Cq8.Default))) == 0)
					{
						unchecked
						{
							_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)Aj8.Cm3(array, null, (int)checked(2910268523u * unchecked((uint)num2 / 2401842549u)));
						}
					}
					else
					{
						y0D2 = (y0D)(object)Cq8.Default;
					}
				}
				catch
				{
					_ = (Aj8)(object)Cq8.Default;
				}
			}
			_ = (Kz1)(object)Aj8.Cm3(array, Aj8.Cm3(array, array, -1382185775), num2);
		}
		while (obj != null)
		{
			if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Kj1)Aj8.Cm3((byte[])(object)Cq8.Default, array, num2);
					continue;
				}
				_ = (_003CModule_003E)(object)Cq8.Default;
				_ = (Tr3)(object)Cq8.Default;
				kj = default(Kj1);
				tr = tr;
			}
		}
		kj = kj;
		num = default(UIntPtr);
		z3X z3X;
		if (num == 0)
		{
			try
			{
				_ = (Cq8)(object)Aj8.Cm3((byte[])(object)Cq8.Default, array, (int)checked((unchecked((uint)(int)Aj8.Cm3(null, null, -497304914)) + 1204101955u) * unchecked((uint)num2) + unchecked((uint)(int)Cq8.Default)));
				wj = wj;
			}
			finally
			{
				z3X = z3X;
				goto IL_0ff4;
			}
		}
		goto IL_0ff4;
		IL_122b:
		while ((object)Aj8.Cm3(array, null, num2) != null)
		{
			aj = aj;
		}
		if ((UIntPtr)Aj8.Cm3(array, Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)Aj8.Cm3(null, array, num2)), (int)checked(1895260602u + unchecked((uint)num2))) == (UIntPtr)(nuint)0u)
		{
			checked
			{
				if (unchecked((nuint)(UIntPtr)Cq8.Default) * num == 0)
				{
					aj = aj;
				}
			}
		}
		else
		{
			while (obj != null)
			{
				_ = (c2M)(object)Cq8.Default;
			}
		}
		try
		{
			_ = (y0D)(object)Cq8.Default;
			_ = (c2M)(object)Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)checked(2573266551u + unchecked((uint)(int)Cq8.Default)));
			_ = (Tr3)(object)Cq8.Default;
			_ = (Kz1)(object)Cq8.Default;
		}
		catch
		{
			if (num == 0)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Cq8)(object)Aj8.Cm3(array, null, num2);
				}
				else
				{
					_ = (Kz1)(object)Cq8.Default;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n9L n9L);
		if ((UIntPtr)Aj8.Cm3(null, array, num2) == (UIntPtr)(nuint)0u)
		{
			wj = null;
			_ = Cq8.Default;
		}
		else
		{
			do
			{
				if (default(UIntPtr) != (UIntPtr)(nuint)0u)
				{
					y6Z = (y6Z)(object)Cq8.Default;
				}
				else
				{
					n9L = (n9L)(object)Aj8.Cm3(array, Aj8.Cm3((byte[])(object)Cq8.Default, array, 637871298), (int)((uint)num2 / 4235936670u));
				}
			}
			while (obj != null);
		}
		do
		{
			try
			{
				n9L = null;
			}
			finally
			{
				try
				{
					y6Z = y6Z;
				}
				catch
				{
					_ = Cq8.Default;
				}
				continue;
			}
		}
		while (obj != null);
		return;
		IL_0abf:
		_ = (Gj7)(object)Cq8.Default;
		if ((UIntPtr)Aj8.Cm3(null, array, (int)checked(unchecked((uint)num2) * unchecked((uint)num2))) == (UIntPtr)(nuint)0u)
		{
			_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)Aj8.Cm3(array, Aj8.Cm3(Aj8.Cm3((byte[])(object)Cq8.Default, array, (int)checked(unchecked((uint)num2) - unchecked(checked(unchecked((uint)num2 / (uint)(int)Cq8.Default) + unchecked((uint)(int)Aj8.Cm3(null, array, (int)checked(unchecked((uint)(int)Cq8.Default) * 3692893349u)))) / (uint)(int)Cq8.Default))), array, (int)Aj8.Cm3(array, Aj8.Cm3(null, array, (int)checked(unchecked((uint)(int)Cq8.Default) * (unchecked((uint)(int)Aj8.Cm3(null, array, (int)Cq8.Default)) - unchecked((uint)(int)Aj8.Cm3(null, array, (int)checked(unchecked((uint)num2) * unchecked((uint)num2))))))), 705594956)), (int)checked(367717205u + (361693602u - unchecked((uint)(int)Cq8.Default) + unchecked((uint)(int)Cq8.Default))));
			_003CModule_003E = _003CModule_003E;
		}
		else if (num == 0)
		{
			_ = (d2N)Cq8.Default;
		}
		else
		{
			do
			{
				_ = (d5W)(object)Cq8.Default;
			}
			while ((object)Aj8.Cm3(Aj8.Cm3(array, null, (int)Aj8.Cm3(array, Aj8.Cm3(array, array, num2), 621640194)), Aj8.Cm3(null, null, (int)Aj8.Cm3(array, array, 970834763)), (int)Cq8.Default) != null);
		}
		try
		{
			_ = (y6Z)(object)Aj8.Cm3(null, array, (int)checked(297040910u * 4115927579u));
			_ = (d2N)Cq8.Default;
		}
		finally
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (Aj8)(object)Cq8.Default;
					kj = kj;
				}
			}
			else
			{
				try
				{
					z3X = z3X;
				}
				catch
				{
					_ = (y6Z)(object)Cq8.Default;
				}
			}
			goto IL_0cf9;
		}
		IL_0ff4:
		Lw6 lw;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d5W d5W);
		try
		{
			try
			{
				_ = (y0D)(object)Cq8.Default;
			}
			catch
			{
				_ = (c2M)(object)Cq8.Default;
				_ = (d2N)Aj8.Cm3(array, null, num2);
			}
			finally
			{
				if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
				{
					cq = Cq8.Default;
					_ = (d2N)Aj8.Cm3(null, null, -268018562);
					d2N = d2N;
					d5W = d5W;
				}
				else
				{
					gj = null;
					z3X = z3X;
					gj = gj;
				}
				goto end_IL_0ff5;
			}
			end_IL_0ff5:;
		}
		catch
		{
			checked
			{
				try
				{
					if (unchecked((nuint)(UIntPtr)Cq8.Default) * num == 0)
					{
						_ = (n9L)(object)Cq8.Default;
					}
				}
				catch
				{
					if (num == 0)
					{
						lw = (Lw6)(object)Cq8.Default;
					}
					else
					{
						kj = kj;
					}
				}
			}
		}
		gj = null;
		kz = (Kz1)(object)Aj8.Cm3(array, null, 474538862);
		do
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				try
				{
					_ = (Gj7)(object)Cq8.Default;
				}
				finally
				{
					_ = (y0D)(object)Cq8.Default;
					_ = (Cq8)(object)Aj8.Cm3(Aj8.Cm3(null, array, 921985173), array, (int)Aj8.Cm3(array, array, num2));
					continue;
				}
			}
		}
		while (obj != null);
		try
		{
			num = default(UIntPtr);
			if (checked(num * num) == 0)
			{
				_ = (y0D)(object)Cq8.Default;
			}
		}
		finally
		{
			try
			{
				_ = (y6Z)(object)Aj8.Cm3(array, array, (int)checked(unchecked((uint)num2) * (4099608736u * 3322506151u * 3522457652u)));
			}
			catch
			{
				while (obj != null)
				{
					lw = null;
				}
			}
			goto IL_11a7;
		}
		IL_11a7:
		try
		{
			if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (Lw6)(object)Cq8.Default;
					cq = Cq8.Default;
				}
				else
				{
					_ = (n9L)(object)Cq8.Default;
					_ = (d5W)(object)Cq8.Default;
					kz = (Kz1)(object)Aj8.Cm3(null, array, (int)Aj8.Cm3(array, array, -1904998995));
				}
			}
		}
		finally
		{
			goto IL_122b;
		}
		IL_015a:
		y0D obj15 = (y0D)(object)Cq8.Default;
		y0D2 = y0D2;
		y0D2 = obj15;
		lw = (Lw6)(object)Aj8.Cm3(null, Aj8.Cm3(Aj8.Cm3(array, null, -1213880651), array, 574487959), (int)Cq8.Default);
		lw = lw;
		tr = null;
		tr = tr;
		_ = (Kj1)Aj8.Cm3(array, Aj8.Cm3(array, Aj8.Cm3(Aj8.Cm3((byte[])(object)Cq8.Default, null, (int)checked(unchecked((uint)num2) * unchecked((uint)num2))), array, (int)(checked(4292339634u + unchecked((uint)num2)) / 3088781794u)), (int)checked(unchecked(checked(unchecked((uint)num2) * 520073611u) / checked(unchecked((uint)num2) * unchecked((uint)num2 / (uint)num2))) * 1499465857u)), -1769576528);
		z3X = (z3X)(object)Cq8.Default;
		z3X = z3X;
		_ = (Gj7)(object)Cq8.Default;
		lw = null;
		_ = (Lw6)(object)Aj8.Cm3(array, array, -290769112);
		cq = (Cq8)(object)Aj8.Cm3(null, (byte[])(object)Cq8.Default, -274686341);
		while ((object)Cq8.Default != null)
		{
		}
		y6Z = null;
		try
		{
			num = default(UIntPtr);
			if (num == 0 && (UIntPtr)Aj8.Cm3(array, array, num2) == (UIntPtr)(nuint)0u)
			{
				_ = (Cq8)(object)Aj8.Cm3(Aj8.Cm3(null, array, (int)Aj8.Cm3(array, null, (int)checked((495090015u - (unchecked((uint)num2) + unchecked((uint)(int)Cq8.Default))) * unchecked((uint)(int)Cq8.Default)))), Aj8.Cm3(array, array, num2), (int)Cq8.Default);
			}
		}
		finally
		{
			do
			{
				Kz1 obj16 = (Kz1)(object)Cq8.Default;
				kz = kz;
				kz = obj16;
			}
			while (obj != null || obj != null);
			goto IL_037c;
		}
		IL_049f:
		try
		{
			if (num / (nuint)(UIntPtr)Cq8.Default == 0)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (Tr3)(object)Aj8.Cm3(array, null, num2);
				}
				else
				{
					_ = (c2M)(object)Aj8.Cm3((byte[])(object)Cq8.Default, null, (int)checked(3322264416u * unchecked((uint)(int)Aj8.Cm3(array, Aj8.Cm3(null, null, (int)Aj8.Cm3(Aj8.Cm3(array, array, (int)checked(2422821593u + unchecked((uint)(int)Aj8.Cm3(array, null, (int)Aj8.Cm3(null, array, num2))) * (6u + unchecked((uint)(int)Cq8.Default)))), array, (int)checked(unchecked((uint)(int)Aj8.Cm3(array, array, num2)) * ((unchecked(checked(unchecked((uint)num2) * 2825145177u) / ((uint)(int)Cq8.Default / 4042338273u)) + 2303921213u) * unchecked((uint)(int)Cq8.Default))))), (int)Cq8.Default))));
				}
			}
		}
		catch
		{
			do
			{
				_ = (y6Z)(object)Cq8.Default;
			}
			while (obj != null);
		}
		if ((UIntPtr)Aj8.Cm3(null, null, (int)(checked(unchecked((uint)(int)Aj8.Cm3(Aj8.Cm3(null, Aj8.Cm3(array, array, (int)(checked(unchecked((uint)(int)Aj8.Cm3(null, null, (int)checked(3339142634u + unchecked((uint)num2)))) - 4060567870u) / (697278754u / (uint)num2))), (int)Cq8.Default), (byte[])(object)Cq8.Default, (int)checked(1250853156u - unchecked((uint)(int)Aj8.Cm3(null, null, (int)checked(unchecked((uint)(int)Aj8.Cm3(array, null, (int)checked((unchecked((uint)(int)Cq8.Default) - (unchecked((uint)num2) - 1313459665u)) * unchecked((uint)num2) + 154205698u)) / checked(unchecked((uint)(int)Aj8.Cm3(null, null, (int)Aj8.Cm3(array, Aj8.Cm3(Aj8.Cm3(array, null, (int)checked(unchecked((uint)(int)Cq8.Default) + unchecked((uint)num2 / (uint)num2))), Aj8.Cm3(null, (byte[])(object)Cq8.Default, (int)Aj8.Cm3(array, Aj8.Cm3(array, array, (int)Cq8.Default), (int)Aj8.Cm3((byte[])(object)Cq8.Default, array, num2))), num2), -2123526990))) + unchecked(1015898211u / (uint)(int)Cq8.Default))) - 3742630132u))) - unchecked((uint)num2)))) * unchecked((uint)num2)) / 611269602u)) == (UIntPtr)(nuint)0u && (UIntPtr)Aj8.Cm3(array, null, num2) == (UIntPtr)(nuint)0u)
		{
			wj = (Wj3)(object)Aj8.Cm3(array, null, (int)checked(3974193890u - (3475027514u - unchecked((uint)(int)Cq8.Default))));
			_ = (Gj7)(object)Aj8.Cm3(array, null, (int)Cq8.Default);
		}
		try
		{
			do
			{
				_ = (Gj7)(object)Cq8.Default;
			}
			while ((object)Cq8.Default != null);
		}
		catch
		{
			try
			{
				_ = (Aj8)(object)Cq8.Default;
			}
			catch
			{
				_ = (d2N)Aj8.Cm3(array, array, num2);
			}
		}
		finally
		{
			z3X = (z3X)(object)Cq8.Default;
			d2N = default(d2N);
			_ = (Gj7)(object)Cq8.Default;
			c2M = (c2M)(object)Aj8.Cm3(array, (byte[])(object)Cq8.Default, 437661160);
			goto IL_083d;
		}
		IL_083d:
		if (num == 0)
		{
			try
			{
				kz = (Kz1)(object)Aj8.Cm3(null, array, num2);
				d2N = (d2N)Cq8.Default;
				_ = (Tr3)(object)Cq8.Default;
				_ = (Wj3)(object)Cq8.Default;
			}
			catch
			{
				kz = null;
			}
		}
		else
		{
			try
			{
				try
				{
					c2M = null;
				}
				finally
				{
					_ = (y6Z)(object)Cq8.Default;
					gj = null;
					gj = gj;
					kj = default(Kj1);
					kj = kj;
					goto end_IL_0889;
				}
				end_IL_0889:;
			}
			catch
			{
				d2N = (d2N)Cq8.Default;
			}
		}
		if (num == 0)
		{
			do
			{
				if (num == 0)
				{
					_ = (c2M)(object)Aj8.Cm3(array, array, (int)Aj8.Cm3(null, array, (int)checked(2669689743u + unchecked((uint)num2))));
				}
			}
			while ((object)Cq8.Default != null);
		}
		else if (num == 0)
		{
			_ = (Kj1)Cq8.Default;
		}
		while (obj != null)
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				if (num == 0)
				{
					n9L = n9L;
					n9L = n9L;
				}
				else
				{
					wj = wj;
					lw = lw;
				}
			}
		}
		while (obj != null)
		{
			if (num == 0)
			{
				c2M = (c2M)(object)Aj8.Cm3((byte[])(object)Cq8.Default, array, (int)((uint)num2 / checked(2518166122u * 3707543502u)));
			}
		}
		try
		{
			try
			{
				d2N = default(d2N);
				d2N = d2N;
			}
			catch
			{
				_ = (Tr3)(object)Aj8.Cm3(array, null, (int)Cq8.Default);
			}
			finally
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					z3X = z3X;
					y6Z = (y6Z)(object)Aj8.Cm3(array, array, (int)Cq8.Default);
					_ = (_003CModule_003E)(object)Cq8.Default;
					z3X = z3X;
				}
				else
				{
					_ = (Kj1)Cq8.Default;
				}
				goto end_IL_09aa;
			}
			end_IL_09aa:;
		}
		finally
		{
			try
			{
				try
				{
					_ = (c2M)(object)Aj8.Cm3((byte[])(object)Cq8.Default, Aj8.Cm3(null, array, (int)Cq8.Default), -562886274);
				}
				catch
				{
					lw = lw;
					y6Z = y6Z;
				}
			}
			catch
			{
				if (num == 0)
				{
					d5W obj24 = (d5W)(object)Aj8.Cm3(null, array, -2112931565);
					d5W = d5W;
					d5W = obj24;
				}
				else
				{
					n9L = n9L;
				}
			}
			goto IL_0abf;
		}
	}

	static void Bc1()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		object obj;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Aj8 aj);
		nuint num2;
		do
		{
			num = num;
			num2 = (nuint)(UIntPtr)Aj8.Cm3(null, null, num) / (nuint)(UIntPtr)Aj8.Cm3(null, null, 771804621);
			if (num2 == 0)
			{
				num2 = default(UIntPtr);
				if (checked(num2 - num2) == 0)
				{
					array = array;
					_ = (Kz1)(object)Aj8.Cm3(array, Aj8.Cm3((byte[])(object)Cq8.Default, Aj8.Cm3(Aj8.Cm3((byte[])(object)Cq8.Default, (byte[])(object)Cq8.Default, (int)Cq8.Default), array, (int)Aj8.Cm3(null, array, (int)Aj8.Cm3(Aj8.Cm3(array, Aj8.Cm3(array, null, num), (int)Cq8.Default), array, -1948860122))), (int)((uint)(int)Cq8.Default / 3055139611u)), (int)Cq8.Default);
				}
				else
				{
					aj = null;
					aj = aj;
					_ = (Cq8)(object)Aj8.Cm3(array, null, 1659191446);
				}
			}
			obj = Cq8.Default;
		}
		while (obj != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z3X z3X);
		c2M c2M;
		if (num2 == 0)
		{
			try
			{
				try
				{
					_ = Cq8.Default;
				}
				finally
				{
					c2M = null;
					c2M = c2M;
					_ = (d5W)(object)Cq8.Default;
					z3X = z3X;
					z3X = z3X;
					goto end_IL_011a;
				}
				end_IL_011a:;
			}
			finally
			{
				while (obj != null)
				{
					_ = (_003CModule_003E)(object)Aj8.Cm3(array, null, (int)Aj8.Cm3(array, array, (int)Cq8.Default));
				}
				goto IL_0172;
			}
		}
		goto IL_0172;
		IL_0d35:
		_ = (Gj7)(object)Aj8.Cm3(array, array, -885652304);
		_ = (z3X)(object)Cq8.Default;
		c2M = (c2M)(object)Cq8.Default;
		try
		{
			_ = (Kj1)Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)checked(unchecked((uint)num) * 4124779791u + 946105286u));
		}
		finally
		{
			goto IL_0dc0;
		}
		IL_0be6:
		while (obj != null)
		{
			if ((UIntPtr)Aj8.Cm3(array, null, num) == (UIntPtr)(nuint)0u)
			{
				while (obj != null)
				{
					_ = (Aj8)(object)Cq8.Default;
				}
			}
		}
		num2 = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y0D y0D2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Tr3 tr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Kj1 kj);
		if (num2 == (UIntPtr)(nuint)0u)
		{
			num2 = default(UIntPtr);
			checked
			{
				if (num2 == 0)
				{
					try
					{
						aj = aj;
						_ = (y0D)(object)Cq8.Default;
					}
					catch
					{
						_ = (_003CModule_003E)(object)Aj8.Cm3(array, array, num);
						kj = kj;
						_ = (y0D)(object)Cq8.Default;
						_ = (d2N)Cq8.Default;
					}
				}
				else if (unchecked((nuint)(UIntPtr)Cq8.Default) * num2 * unchecked((nuint)(UIntPtr)Aj8.Cm3(null, null, 906862112)) + unchecked((nuint)default(UIntPtr)) == 0)
				{
					y0D2 = y0D2;
				}
			}
		}
		else if (num2 == (UIntPtr)(nuint)0u)
		{
			_ = (Wj3)(object)Aj8.Cm3(null, array, -311191458);
			kj = kj;
			_ = (Kz1)(object)Aj8.Cm3(array, null, (int)checked(unchecked((uint)num) + 2542322418u * (unchecked((uint)(int)Aj8.Cm3(array, null, (int)Aj8.Cm3(Aj8.Cm3((byte[])(object)Cq8.Default, array, num), array, (int)checked(747138816u * unchecked((uint)num))))) - unchecked((uint)(int)Aj8.Cm3(array, array, -1155501693)))));
			tr = (Tr3)(object)Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)Cq8.Default);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
		{
			_003CModule_003E = null;
			goto IL_0d35;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cq8 cq);
		try
		{
			while (obj != null)
			{
				cq = cq;
			}
		}
		finally
		{
			_003CModule_003E = null;
			goto IL_0d35;
		}
		IL_0ada:
		_ = (n9L)(object)Aj8.Cm3((byte[])(object)Cq8.Default, null, -1168250285);
		_ = (d2N)Cq8.Default;
		_ = (_003CModule_003E)(object)Cq8.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d5W d5W);
		try
		{
			try
			{
				c2M = (c2M)(object)Cq8.Default;
			}
			catch
			{
				if ((UIntPtr)Aj8.Cm3(null, array, (int)checked(unchecked((uint)(int)Aj8.Cm3(array, (byte[])(object)Cq8.Default, num)) - 2373855565u)) == (UIntPtr)(nuint)0u)
				{
					d5W = d5W;
				}
				else
				{
					d5W = d5W;
				}
			}
		}
		catch
		{
			y0D2 = y0D2;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d2N d2N);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y6Z y6Z);
		try
		{
			try
			{
				tr = tr;
			}
			catch
			{
				while (obj != null)
				{
					d2N = d2N;
				}
			}
		}
		catch
		{
			y6Z = y6Z;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Wj3 wj);
		while (obj != null)
		{
			wj = wj;
		}
		checked
		{
			try
			{
				if (num2 + num2 == 0 && unchecked((nuint)(UIntPtr)Aj8.Cm3(null, (byte[])(object)Cq8.Default, -517093393)) * unchecked((nuint)(UIntPtr)Aj8.Cm3(null, Aj8.Cm3(array, array, num), 1790818315)) == 0)
				{
					y0D2 = null;
				}
			}
			finally
			{
				goto IL_0be6;
			}
		}
		IL_0e59:
		n9L n9L = n9L;
		do
		{
			try
			{
				y6Z = null;
			}
			catch
			{
				_ = (Kj1)Aj8.Cm3(array, null, (int)checked(unchecked((uint)num) + unchecked((uint)num)));
			}
			finally
			{
				if (checked(unchecked((nuint)(UIntPtr)Aj8.Cm3(null, array, -1477832803)) - unchecked((nuint)(UIntPtr)Cq8.Default)) == 0)
				{
					_ = (Gj7)(object)Cq8.Default;
					_ = (d5W)(object)Aj8.Cm3(array, array, num);
					y6Z = y6Z;
					c2M = (c2M)(object)Aj8.Cm3(array, null, num);
				}
				else
				{
					_ = (d5W)(object)Aj8.Cm3(array, array, (int)checked(unchecked((uint)num) - 1992575331u));
				}
				continue;
			}
		}
		while (obj != null);
		do
		{
			_ = Cq8.Default;
		}
		while (obj != null);
		try
		{
			_ = (Kz1)(object)Cq8.Default;
			return;
		}
		catch
		{
			while ((object)Aj8.Cm3(array, null, (int)checked(unchecked((uint)num) * 3198180489u)) != null)
			{
				do
				{
					_ = (Wj3)(object)Aj8.Cm3(array, null, 2000213043);
				}
				while (obj != null);
			}
			return;
		}
		IL_0dc0:
		do
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u && (UIntPtr)Aj8.Cm3(Aj8.Cm3(array, null, (int)Cq8.Default), null, 961496422) == (UIntPtr)(nuint)0u)
			{
				_ = (Gj7)(object)Cq8.Default;
			}
		}
		while (obj != null);
		do
		{
			num2 = default(UIntPtr);
			if (num2 == (UIntPtr)(nuint)0u)
			{
				c2M = null;
			}
		}
		while ((object)Cq8.Default != null || (object)Aj8.Cm3(array, array, num) != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Lw6 lw);
		if (num2 == (UIntPtr)(nuint)0u)
		{
			try
			{
				while ((object)Aj8.Cm3(array, null, (int)Cq8.Default) != null)
				{
					c2M = c2M;
				}
			}
			finally
			{
				while ((object)Aj8.Cm3(array, null, (int)Cq8.Default) != null)
				{
					lw = null;
				}
				goto IL_0e59;
			}
		}
		if (num2 == (UIntPtr)(nuint)0u && default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (y6Z)(object)Cq8.Default;
		}
		goto IL_0e59;
		IL_06d3:
		if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
		{
			if (num2 == 0)
			{
				do
				{
					_ = (c2M)(object)Cq8.Default;
				}
				while (obj != null);
			}
			else
			{
				do
				{
					cq = cq;
				}
				while (obj != null);
			}
		}
		else if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (Aj8)(object)Aj8.Cm3(array, array, -1462938805);
			}
			catch
			{
				z3X = z3X;
			}
		}
		n9L = (n9L)(object)Cq8.Default;
		while ((object)Aj8.Cm3(array, null, num) != null)
		{
			try
			{
				try
				{
					d5W = d5W;
				}
				finally
				{
					z3X = z3X;
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = null;
					_ = (Kj1)Cq8.Default;
					goto end_IL_0733;
				}
				end_IL_0733:;
			}
			catch
			{
				_ = (Aj8)(object)Aj8.Cm3(null, array, (int)checked(unchecked((uint)num) * 4097379977u));
			}
		}
		if (num2 == 0)
		{
			checked
			{
				try
				{
					if ((num2 + num2) * unchecked(checked(num2 * unchecked(num2 / checked(num2 + unchecked((nuint)default(UIntPtr))))) / (nuint)(UIntPtr)Cq8.Default) == 0)
					{
						lw = lw;
					}
				}
				catch
				{
					try
					{
						_ = (Kj1)Cq8.Default;
					}
					finally
					{
						cq = cq;
						y6Z = y6Z;
						_ = (Aj8)(object)Aj8.Cm3((byte[])(object)Cq8.Default, array, 1468608196);
						goto end_IL_07a3;
					}
					end_IL_07a3:;
				}
			}
		}
		else if (num2 == 0 && num2 == 0)
		{
			_ = (c2M)(object)Aj8.Cm3(array, null, (int)((uint)num / (uint)num));
		}
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)Aj8.Cm3(array, array, num) == (UIntPtr)(nuint)0u)
				{
					_ = (_003CModule_003E)(object)Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)Cq8.Default);
				}
			}
			else
			{
				c2M = (c2M)(object)Cq8.Default;
				_ = (Lw6)(object)Aj8.Cm3(array, array, (int)Cq8.Default);
				lw = lw;
				_ = (y6Z)(object)Cq8.Default;
			}
		}
		catch
		{
			y0D2 = y0D2;
		}
		num2 = default(UIntPtr);
		checked
		{
			if (num2 * unchecked((nuint)(UIntPtr)Aj8.Cm3(null, Aj8.Cm3(array, Aj8.Cm3(null, array, (int)Aj8.Cm3(Aj8.Cm3(array, array, 777535729), array, -2079250143)), (int)Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)checked(unchecked((uint)(int)Aj8.Cm3(Aj8.Cm3(array, array, (int)checked(unchecked((uint)num) - unchecked((uint)(int)Aj8.Cm3(array, array, (int)checked(unchecked((uint)num) + unchecked((uint)num)))))), array, (int)Cq8.Default)) - unchecked((uint)num)))), num)) * unchecked((nuint)(UIntPtr)Aj8.Cm3(array, array, (int)checked(unchecked((uint)num) - unchecked((uint)(int)Aj8.Cm3(array, array, num)))) / (nuint)(UIntPtr)Cq8.Default / (num2 / num2)) == 0)
			{
				try
				{
					y6Z = null;
				}
				catch
				{
					_ = (d2N)Aj8.Cm3(array, array, 1686503020);
				}
			}
			_ = (Gj7)(object)Cq8.Default;
			try
			{
				kj = kj;
			}
			catch
			{
				z3X = z3X;
			}
			num2 = default(UIntPtr);
			if (num2 == 0 && num2 == 0)
			{
				_ = (d2N)Cq8.Default;
			}
		}
		_ = (Kz1)(object)Aj8.Cm3(array, array, (int)Aj8.Cm3(array, null, 1822718818));
		if (num2 == 0)
		{
			if ((UIntPtr)Aj8.Cm3(array, array, (int)checked(unchecked((uint)(int)Cq8.Default) - unchecked((uint)num))) == (UIntPtr)(nuint)0u)
			{
				while ((object)Cq8.Default != null)
				{
					d5W = d5W;
				}
			}
		}
		else if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
		{
			num2 = default(UIntPtr);
			if (num2 == 0)
			{
				_ = (Kz1)(object)Cq8.Default;
			}
			else
			{
				_003CModule_003E = _003CModule_003E;
			}
		}
		else
		{
			do
			{
				cq = Cq8.Default;
			}
			while (obj != null);
		}
		while (obj != null)
		{
			num2 = default(UIntPtr);
			if (num2 == 0)
			{
				do
				{
					n9L = (n9L)(object)Aj8.Cm3((byte[])(object)Cq8.Default, (byte[])(object)Cq8.Default, (int)((uint)(int)Cq8.Default / 3935342191u));
				}
				while (obj != null);
			}
		}
		n9L = null;
		_ = (d2N)Aj8.Cm3(Aj8.Cm3(array, Aj8.Cm3(null, array, num), -1114426057), array, (int)Cq8.Default);
		_ = (Kj1)Aj8.Cm3(Aj8.Cm3(array, null, num), array, (int)checked(unchecked((uint)(int)Aj8.Cm3(array, null, 85314428)) * unchecked((uint)num)));
		try
		{
			wj = wj;
		}
		catch
		{
			do
			{
				z3X = z3X;
			}
			while (obj != null);
		}
		checked
		{
			if (num2 == 0)
			{
				try
				{
					nuint num3 = num2;
					num2 = default(UIntPtr);
					if (unchecked(num3 / num2) + num2 == 0)
					{
						_ = (y6Z)(object)Cq8.Default;
					}
				}
				finally
				{
					goto IL_0ada;
				}
			}
			goto IL_0ada;
		}
		IL_0172:
		try
		{
			while ((object)Aj8.Cm3(null, array, (int)checked(2863880506u + unchecked((uint)num))) != null)
			{
				do
				{
					z3X = (z3X)(object)Cq8.Default;
				}
				while ((object)Aj8.Cm3(Aj8.Cm3(Aj8.Cm3(array, array, (int)Cq8.Default), null, (int)Aj8.Cm3(Aj8.Cm3(array, array, num), array, 514968382)), array, num) != null);
			}
		}
		catch
		{
			d2N = default(d2N);
		}
		y0D2 = y0D2;
		y0D2 = y0D2;
		try
		{
			while (obj != null)
			{
				y0D2 = null;
			}
		}
		finally
		{
			if (num2 == 0)
			{
				try
				{
					_ = (c2M)(object)Aj8.Cm3(array, Aj8.Cm3(Aj8.Cm3(array, Aj8.Cm3(array, (byte[])(object)Cq8.Default, 1611450507), -546039746), null, (int)Aj8.Cm3(array, null, (int)checked(unchecked((uint)num) + unchecked((uint)(int)Aj8.Cm3(array, array, (int)(checked(unchecked((uint)(int)Cq8.Default) + unchecked((uint)(int)Aj8.Cm3(null, array, num))) / (uint)(int)Cq8.Default))) + unchecked((uint)(int)Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)Cq8.Default))))), (int)checked(unchecked((uint)num) + 1948986016u));
				}
				catch
				{
					_ = (Lw6)(object)Cq8.Default;
				}
			}
			else
			{
				_ = (z3X)(object)Cq8.Default;
			}
			goto IL_02d3;
		}
		IL_05bb:
		if (num2 == 0)
		{
			y6Z = y6Z;
			_ = (Gj7)(object)Cq8.Default;
		}
		else
		{
			tr = tr;
		}
		_ = (Cq8)(object)Aj8.Cm3((byte[])(object)Cq8.Default, array, 2030888858);
		_ = (y0D)(object)Aj8.Cm3(array, null, (int)checked(1537237429u * (unchecked((uint)(int)Aj8.Cm3(null, null, num)) * unchecked(checked(unchecked((uint)(int)Cq8.Default) - unchecked(checked(unchecked((uint)(int)Cq8.Default) * unchecked((uint)num / 3532546174u)) / checked(unchecked((uint)num) + unchecked((uint)(int)Aj8.Cm3(Aj8.Cm3(array, array, (int)(641450244u / (uint)(int)Cq8.Default)), array, 1694457642)) + unchecked((uint)num)))) / (uint)(int)Aj8.Cm3(array, Aj8.Cm3(array, array, (int)Aj8.Cm3(array, null, 1490059930)), num)))));
		if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
		{
			_ = (Kj1)Cq8.Default;
		}
		if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				while ((object)Cq8.Default != null)
				{
					_ = (_003CModule_003E)(object)Cq8.Default;
				}
			}
			finally
			{
				_ = Cq8.Default;
				goto IL_06d3;
			}
		}
		goto IL_06d3;
		IL_02d3:
		if ((UIntPtr)Aj8.Cm3(array, null, (int)Aj8.Cm3((byte[])(object)Cq8.Default, Aj8.Cm3((byte[])(object)Cq8.Default, null, (int)Aj8.Cm3(array, array, num)), (int)checked(unchecked((uint)num) - unchecked((uint)num)))) == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
			}
		}
		else if ((UIntPtr)Aj8.Cm3((byte[])(object)Cq8.Default, Aj8.Cm3(array, Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)checked(unchecked((uint)num) * 656719156u)), (int)Aj8.Cm3(array, array, 1905888781)), -1961340211) == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (d5W)(object)Aj8.Cm3(null, (byte[])(object)Cq8.Default, num);
			}
			catch
			{
				cq = cq;
				cq = cq;
				d5W = null;
				d5W = d5W;
				Tr3 obj18 = (Tr3)(object)Cq8.Default;
				tr = (Tr3)(object)Cq8.Default;
				tr = obj18;
				_ = (Aj8)(object)Aj8.Cm3(Aj8.Cm3(Aj8.Cm3(array, array, (int)checked(unchecked((uint)num) * (unchecked((uint)num) * unchecked((uint)num)))), null, num), null, num);
			}
		}
		while (obj != null)
		{
			while ((object)Aj8.Cm3(array, null, num) != null)
			{
				y0D2 = (y0D)(object)Cq8.Default;
				cq = cq;
				_ = (y0D)(object)Cq8.Default;
			}
		}
		num2 = default(UIntPtr);
		if (checked((num2 - unchecked((nuint)(UIntPtr)Aj8.Cm3(null, null, -1464514003))) * unchecked((nuint)(UIntPtr)Aj8.Cm3(Aj8.Cm3(Aj8.Cm3(null, array, num), (byte[])(object)Cq8.Default, 1328014098), array, num))) == 0)
		{
			do
			{
				kj = kj;
				kj = default(Kj1);
			}
			while ((object)Aj8.Cm3((byte[])(object)Cq8.Default, null, (int)checked(unchecked((uint)num / (uint)(int)Cq8.Default / (uint)(int)Aj8.Cm3(null, array, (int)checked(unchecked((uint)num) - (unchecked((uint)num) + unchecked((uint)num)) - unchecked((uint)(int)Cq8.Default)))) - 2578233240u)) != null);
		}
		while ((object)Aj8.Cm3(array, array, -1052854995) != null)
		{
			try
			{
				try
				{
					cq = null;
				}
				finally
				{
					_ = (_003CModule_003E)(object)Cq8.Default;
					aj = null;
					goto end_IL_04bd;
				}
				end_IL_04bd:;
			}
			finally
			{
				continue;
			}
		}
		while (obj != null)
		{
			try
			{
				_ = Cq8.Default;
			}
			catch
			{
			}
		}
		try
		{
			while (obj != null)
			{
				wj = wj;
				wj = null;
			}
		}
		catch
		{
			try
			{
				lw = (Lw6)(object)Aj8.Cm3(null, array, num);
				lw = lw;
			}
			catch
			{
				_ = (Gj7)(object)Aj8.Cm3(array, Aj8.Cm3(array, null, (int)Cq8.Default), num);
			}
		}
		if (num2 != 0)
		{
		}
		try
		{
			while (obj != null)
			{
				try
				{
					y6Z = (y6Z)(object)Cq8.Default;
					n9L = n9L;
					n9L = n9L;
					lw = lw;
				}
				finally
				{
					kj = default(Kj1);
					kj = kj;
					_ = (Tr3)(object)Aj8.Cm3((byte[])(object)Cq8.Default, array, num);
					continue;
				}
			}
		}
		finally
		{
			while (obj != null)
			{
				while ((object)Cq8.Default != null)
				{
					_ = (d2N)Cq8.Default;
				}
			}
			goto IL_05bb;
		}
	}

	static void n7T()
	{
		byte[] array = array;
		byte[] nx = array;
		byte[] ko = array;
		byte[] nx2 = array;
		byte[] ko2 = array;
		int num = (int)Cq8.Default;
		int num2 = num2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Tr3 tr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cq8 cq);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Lw6 lw);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Kj1 kj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y6Z y6Z);
		d5W d5W;
		nuint num3;
		checked
		{
			num3 = unchecked((nuint)default(UIntPtr)) + (unchecked((nuint)(UIntPtr)Aj8.Cm3(nx, ko, (int)Aj8.Cm3(nx2, ko2, (int)checked(unchecked((uint)num) * unchecked((uint)num2))))) + unchecked((nuint)(UIntPtr)Aj8.Cm3(array, array, (int)Cq8.Default)));
			num3 = default(UIntPtr);
			if (num3 - unchecked((nuint)(UIntPtr)Cq8.Default) == 0)
			{
				if (unchecked((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u))
				{
					try
					{
						_ = (Kj1)Cq8.Default;
					}
					catch
					{
						y6Z = y6Z;
						y6Z = y6Z;
						_ = (_003CModule_003E)(object)Cq8.Default;
						kj = default(Kj1);
						kj = default(Kj1);
						_ = (_003CModule_003E)(object)Cq8.Default;
					}
				}
				else
				{
					Lw6 obj2 = (Lw6)(object)Cq8.Default;
					lw = null;
					lw = obj2;
					obj3 = null;
				}
			}
			if (unchecked((nuint)(UIntPtr)Cq8.Default) * unchecked(num3 / (nuint)(UIntPtr)Aj8.Cm3(Aj8.Cm3(null, array, num2), null, (int)Cq8.Default)) == 0)
			{
				y6Z = null;
				kj = kj;
				y6Z = null;
			}
			nuint num4 = num3;
			num3 = default(UIntPtr);
			if ((num4 - (unchecked((nuint)default(UIntPtr)) - unchecked(checked(num3 * num3) / (nuint)(UIntPtr)Cq8.Default))) * unchecked((nuint)(UIntPtr)Cq8.Default) == 0)
			{
				unchecked
				{
					try
					{
						while (obj3 != null)
						{
							Tr3 obj4 = (Tr3)(object)Cq8.Default;
							tr = tr;
							tr = obj4;
						}
					}
					catch
					{
						while (obj3 != null)
						{
							_ = (Tr3)(object)Aj8.Cm3(Aj8.Cm3(Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)Cq8.Default), (byte[])(object)Cq8.Default, 92748901), array, (int)checked(unchecked((uint)(int)Aj8.Cm3((byte[])(object)Cq8.Default, (byte[])(object)Cq8.Default, (int)Aj8.Cm3(array, null, (int)Aj8.Cm3(array, array, (int)checked(1560529506u * (unchecked((uint)(int)Aj8.Cm3(array, Aj8.Cm3(array, null, (int)checked(unchecked((uint)num2) + unchecked((uint)(int)Cq8.Default))), (int)(1390932630u / checked(unchecked((uint)(int)Cq8.Default) + unchecked((uint)num2))))) + unchecked((uint)(int)Aj8.Cm3(null, array, num2)))))))) + 1505815622u));
							_ = (n9L)(object)Aj8.Cm3(array, array, (int)Cq8.Default);
							cq = (Cq8)(object)Aj8.Cm3(array, array, -815404226);
							cq = null;
						}
					}
				}
			}
			d5W = null;
			d5W = d5W;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c2M c2M);
		try
		{
			while (obj3 != null)
			{
				cq = cq;
			}
		}
		catch
		{
			_ = (Lw6)(object)Aj8.Cm3(array, null, -704448079);
		}
		finally
		{
			try
			{
				try
				{
					_ = (Tr3)(object)Aj8.Cm3((byte[])(object)Cq8.Default, array, (int)Aj8.Cm3((byte[])(object)Cq8.Default, null, (int)checked(unchecked((uint)(int)Cq8.Default / (uint)(int)Cq8.Default) - 313037235u)));
				}
				finally
				{
					_ = (Wj3)(object)Cq8.Default;
					goto end_IL_0335;
				}
				end_IL_0335:;
			}
			finally
			{
				try
				{
					_ = (Kj1)Cq8.Default;
				}
				finally
				{
					y6Z = (y6Z)(object)Cq8.Default;
					c2M = c2M;
					c2M = c2M;
					_ = (_003CModule_003E)(object)Aj8.Cm3(array, null, 1951386820);
					_ = (y0D)(object)Cq8.Default;
					goto IL_03e2;
				}
			}
		}
		IL_1754:
		y0D y0D2;
		z3X z3X;
		while ((object)Cq8.Default != null)
		{
			num3 = default(UIntPtr);
			if (num3 == 0)
			{
				c2M = null;
				z3X = z3X;
				y0D2 = y0D2;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n9L n9L);
		try
		{
			lw = lw;
		}
		catch
		{
			if (num3 == 0)
			{
				try
				{
					n9L = null;
				}
				catch
				{
					_ = Cq8.Default;
				}
			}
		}
		num3 = default(UIntPtr);
		if (checked(unchecked((nuint)default(UIntPtr)) * (unchecked((nuint)default(UIntPtr)) * num3)) == 0)
		{
			_ = (Aj8)(object)Cq8.Default;
		}
		else
		{
			lw = (Lw6)(object)Aj8.Cm3(Aj8.Cm3((byte[])(object)Cq8.Default, array, -1169792630), array, (int)checked((1178738513u + unchecked((uint)(int)Aj8.Cm3(null, array, num2))) * unchecked((uint)num2)));
			tr = (Tr3)(object)Cq8.Default;
		}
		while (obj3 != null)
		{
			c2M = c2M;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Gj7 gj);
		do
		{
			try
			{
				if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
				{
					gj = (Gj7)(object)Aj8.Cm3(null, array, (int)Aj8.Cm3(array, array, (int)Cq8.Default));
				}
			}
			catch
			{
				while (obj3 != null)
				{
					_ = (c2M)(object)Aj8.Cm3(array, array, -1238510902);
				}
			}
		}
		while (obj3 != null);
		_ = (c2M)(object)Cq8.Default;
		try
		{
			do
			{
				try
				{
					_ = (y0D)(object)Aj8.Cm3(null, array, 1277990992);
				}
				finally
				{
					_ = (y6Z)(object)Cq8.Default;
					continue;
				}
			}
			while ((object)Aj8.Cm3(array, array, 2102502360) != null);
		}
		finally
		{
			_ = (Gj7)(object)Cq8.Default;
			_ = (Kz1)(object)Cq8.Default;
			goto IL_18fa;
		}
		IL_14e4:
		do
		{
			nuint num5 = num3;
			num3 = default(UIntPtr);
			if (checked(num5 * num3) != 0)
			{
				if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
				{
					_ = (y0D)(object)Aj8.Cm3(null, null, (int)Aj8.Cm3(null, array, 565727549));
					tr = (Tr3)(object)Aj8.Cm3(array, array, (int)checked(unchecked((uint)(int)Cq8.Default) - 3695978134u));
				}
			}
			else if (num3 == 0)
			{
				_ = (Kz1)(object)Aj8.Cm3(Aj8.Cm3((byte[])(object)Cq8.Default, array, (int)checked(unchecked((uint)num2) * 1381252906u)), array, -2051854687);
			}
		}
		while (obj3 != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Aj8 aj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Kz1 kz);
		Wj3 wj;
		try
		{
			num3 = default(UIntPtr);
			if (num3 == 0)
			{
				c2M = null;
				lw = null;
				aj = aj;
			}
			else
			{
				do
				{
					_ = (Kj1)Cq8.Default;
					gj = gj;
					wj = (Wj3)(object)Aj8.Cm3(array, array, num2);
				}
				while ((object)Aj8.Cm3(array, array, num2) != null);
			}
		}
		finally
		{
			try
			{
				kz = kz;
			}
			catch
			{
				n9L = null;
				_ = (Gj7)(object)Aj8.Cm3(array, Aj8.Cm3(array, array, (int)Cq8.Default), (int)Aj8.Cm3(array, array, (int)Cq8.Default));
				_ = (Aj8)(object)Cq8.Default;
			}
			goto IL_15d0;
		}
		IL_104c:
		if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
		{
			num3 = default(UIntPtr);
			if (checked(num3 - num3) == 0)
			{
				_ = (y6Z)(object)Aj8.Cm3(null, array, (int)Cq8.Default);
			}
			else
			{
				_ = (Lw6)(object)Cq8.Default;
			}
		}
		try
		{
			n9L = n9L;
		}
		finally
		{
			_ = (Wj3)(object)Aj8.Cm3((byte[])(object)Cq8.Default, (byte[])(object)Cq8.Default, (int)checked(unchecked((uint)(int)Aj8.Cm3(Aj8.Cm3(Aj8.Cm3(array, null, (int)checked(1268903915u * (unchecked((uint)(int)Cq8.Default) - unchecked((uint)(int)Cq8.Default)))), array, (int)Cq8.Default), (byte[])(object)Cq8.Default, -1956780440)) * (unchecked((uint)(int)Aj8.Cm3(null, null, 1524499696)) - unchecked((uint)(int)Cq8.Default)) - (unchecked((uint)num2) - unchecked((uint)num2)) - unchecked((uint)num2)));
			goto IL_114a;
		}
		IL_114a:
		num3 = default(UIntPtr);
		if (num3 == 0)
		{
			do
			{
				nuint num6 = num3;
				num3 = default(UIntPtr);
				if (checked(num6 + num3) != 0)
				{
					tr = tr;
				}
				else
				{
					c2M = null;
				}
			}
			while ((object)Aj8.Cm3(array, Aj8.Cm3(null, (byte[])(object)Cq8.Default, num2), (int)checked(unchecked((uint)(int)Cq8.Default) * unchecked((uint)num2) * unchecked((uint)(int)Aj8.Cm3(array, null, -1124308329)))) != null);
		}
		else if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
		{
			kj = default(Kj1);
		}
		try
		{
			if (num3 == 0)
			{
				while (obj3 != null)
				{
					_ = (z3X)(object)Aj8.Cm3(array, null, num2);
				}
			}
		}
		catch
		{
			try
			{
				if (checked(num3 + (num3 + num3)) == 0)
				{
					y0D2 = y0D2;
				}
			}
			finally
			{
				try
				{
					kz = kz;
				}
				finally
				{
					kz = null;
					goto end_IL_1214;
				}
			}
			end_IL_1214:;
		}
		gj = gj;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d2N d2N);
		try
		{
			if ((UIntPtr)Aj8.Cm3(Aj8.Cm3((byte[])(object)Cq8.Default, array, (int)Cq8.Default), array, num2) == (UIntPtr)(nuint)0u)
			{
				z3X = null;
			}
		}
		catch
		{
			d2N = default(d2N);
		}
		try
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					kz = (Kz1)(object)Aj8.Cm3(array, (byte[])(object)Cq8.Default, num2);
				}
				else
				{
					_ = (z3X)(object)Aj8.Cm3(array, array, num2);
				}
			}
			finally
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (y6Z)(object)Aj8.Cm3(array, array, num2);
				}
				else
				{
					aj = (Aj8)(object)Cq8.Default;
				}
				goto end_IL_12a0;
			}
			end_IL_12a0:;
		}
		catch
		{
			_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)Aj8.Cm3(null, array, -1103781318);
		}
		try
		{
			while (obj3 != null)
			{
				do
				{
					wj = (Wj3)(object)Cq8.Default;
					n9L = n9L;
					_ = (Cq8)(object)Aj8.Cm3(Aj8.Cm3(null, array, (int)checked(unchecked((uint)num2) * 1675747015u)), array, 911261258);
				}
				while (obj3 != null);
			}
		}
		finally
		{
			num3 = default(UIntPtr);
			if (num3 / (nuint)(UIntPtr)Aj8.Cm3(array, null, (int)checked(1475589592u + unchecked((uint)(int)Aj8.Cm3(null, array, num2)))) == 0)
			{
				try
				{
					_ = (n9L)(object)Cq8.Default;
				}
				catch
				{
					_ = (_003CModule_003E)(object)Aj8.Cm3(null, null, -1466465793);
				}
			}
			else if (checked(unchecked((nuint)(UIntPtr)Cq8.Default) - (unchecked((nuint)(UIntPtr)Aj8.Cm3((byte[])(object)Cq8.Default, array, -372009582)) - num3)) == 0)
			{
				_ = (Kz1)(object)Cq8.Default;
			}
			else
			{
				_ = (Kj1)Aj8.Cm3(array, null, -1491475719);
			}
			goto IL_14e4;
		}
		IL_15d0:
		nuint num7 = num3;
		num3 = default(UIntPtr);
		if (checked(unchecked(checked(unchecked(num7 / num3) - num3) / num3) - num3) == 0)
		{
			try
			{
				while (obj3 != null)
				{
					aj = aj;
				}
			}
			catch
			{
				do
				{
					kz = kz;
				}
				while (obj3 != null);
			}
		}
		else
		{
			while ((object)Aj8.Cm3(array, array, num2) != null)
			{
				kj = kj;
				_ = (Lw6)(object)Aj8.Cm3(null, (byte[])(object)Cq8.Default, (int)checked(unchecked((uint)num2 / checked(unchecked((uint)(int)Cq8.Default) + 1917612955u + unchecked((uint)(int)Aj8.Cm3(null, array, 1601450099)) * 3398084964u)) - 54u));
				cq = cq;
			}
		}
		try
		{
			try
			{
				gj = (Gj7)(object)Cq8.Default;
			}
			finally
			{
				kj = (Kj1)Cq8.Default;
				goto end_IL_1690;
			}
			end_IL_1690:;
		}
		catch
		{
			while (obj3 != null)
			{
				d2N = d2N;
			}
		}
		try
		{
			_ = (Tr3)(object)Cq8.Default;
		}
		catch
		{
			_ = (d5W)(object)Cq8.Default;
		}
		finally
		{
			if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
			{
				do
				{
					gj = gj;
				}
				while ((object)Aj8.Cm3(array, array, (int)checked(3395998183u * 4165616418u * unchecked((uint)(int)Aj8.Cm3(array, null, 169661538)))) != null);
			}
			goto IL_1754;
		}
		IL_1a00:
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (Aj8)(object)Aj8.Cm3(null, array, (int)(checked(unchecked((uint)num2) * (3517353040u - unchecked((uint)(int)Cq8.Default))) / (1106191725u / (uint)num2)));
		}
		_ = (Lw6)(object)Cq8.Default;
		return;
		IL_0d4c:
		do
		{
			if ((nuint)(UIntPtr)Aj8.Cm3(array, (byte[])(object)Cq8.Default, 185873678) / num3 == 0)
			{
				if (num3 == 0)
				{
					_ = Cq8.Default;
				}
				else
				{
					gj = gj;
				}
			}
		}
		while ((object)Aj8.Cm3((byte[])(object)Cq8.Default, (byte[])(object)Cq8.Default, num2) != null);
		while (obj3 != null)
		{
			do
			{
				if (num3 == 0)
				{
					d2N = d2N;
				}
			}
			while (obj3 != null);
		}
		_ = (Aj8)(object)Cq8.Default;
		try
		{
			try
			{
				num3 = default(UIntPtr);
				if (num3 == 0)
				{
					_ = (Kz1)(object)Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)Cq8.Default);
				}
			}
			catch
			{
				if (checked(num3 - num3) == 0)
				{
					tr = null;
				}
				else
				{
					_ = (Aj8)(object)Cq8.Default;
				}
			}
		}
		catch
		{
			if (checked(unchecked((nuint)(UIntPtr)Aj8.Cm3(array, array, num2)) - num3) / (nuint)(UIntPtr)Cq8.Default == 0)
			{
				if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
				{
					_ = (d2N)Cq8.Default;
				}
			}
			else
			{
				try
				{
					y0D2 = y0D2;
				}
				catch
				{
					_ = (Gj7)(object)Cq8.Default;
				}
			}
		}
		lw = null;
		try
		{
			num3 = default(UIntPtr);
			if (num3 == 0)
			{
				if ((UIntPtr)Aj8.Cm3(array, array, num2) == (UIntPtr)(nuint)0u)
				{
					_ = (_003CModule_003E)(object)Aj8.Cm3(null, (byte[])(object)Cq8.Default, -116664843);
					wj = wj;
					y0D2 = null;
				}
				else
				{
					_ = (_003CModule_003E)(object)Aj8.Cm3(Aj8.Cm3(null, array, (int)Cq8.Default), Aj8.Cm3(null, array, (int)Cq8.Default), num2);
					_ = (y6Z)(object)Aj8.Cm3(null, (byte[])(object)Cq8.Default, (int)Aj8.Cm3(array, null, (int)Cq8.Default));
					_ = (Kj1)Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)Aj8.Cm3(array, array, (int)Cq8.Default));
					kj = kj;
				}
			}
		}
		catch
		{
			try
			{
				try
				{
					_ = (Kz1)(object)Aj8.Cm3((byte[])(object)Cq8.Default, Aj8.Cm3(array, array, 955818375), 1592232504);
				}
				catch
				{
					_ = (d2N)Cq8.Default;
				}
			}
			catch
			{
				if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
				{
					y6Z = null;
				}
			}
		}
		if (num3 == 0)
		{
			try
			{
				_ = (Kz1)(object)Aj8.Cm3(array, array, (int)checked(unchecked((uint)num2 / 3744709172u) - unchecked((uint)num2) + 2397997901u));
			}
			catch
			{
				_ = (c2M)(object)Aj8.Cm3(array, null, (int)Cq8.Default);
			}
			finally
			{
				try
				{
					tr = tr;
				}
				finally
				{
					_ = (y6Z)(object)Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)Aj8.Cm3(null, array, num2));
					goto IL_104c;
				}
			}
		}
		gj = null;
		goto IL_104c;
		IL_18fa:
		try
		{
			_ = (Kj1)Cq8.Default;
		}
		catch
		{
			if (num3 == 0)
			{
				try
				{
					_ = (Kj1)Aj8.Cm3(array, array, (int)Aj8.Cm3((byte[])(object)Cq8.Default, array, (int)checked(4033348244u + 1335301975u - unchecked((uint)num2))));
				}
				finally
				{
					n9L = n9L;
					goto end_IL_190b;
				}
			}
			while (obj3 != null)
			{
				y6Z = y6Z;
				_ = (Cq8)(object)Aj8.Cm3(Aj8.Cm3(null, null, -1229716207), (byte[])(object)Cq8.Default, num2);
				z3X = z3X;
				tr = tr;
			}
			end_IL_190b:;
		}
		try
		{
			while (obj3 != null)
			{
				if (num3 == 0)
				{
					cq = cq;
				}
				else
				{
					y6Z = null;
				}
			}
		}
		finally
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (d5W)(object)Aj8.Cm3(array, array, (int)Cq8.Default);
				}
			}
			catch
			{
				wj = null;
			}
			goto IL_1a00;
		}
		IL_03e2:
		Wj3 obj27 = (Wj3)(object)Aj8.Cm3(array, (byte[])(object)Cq8.Default, num2);
		wj = null;
		wj = obj27;
		while ((object)Cq8.Default != null)
		{
			num3 = default(UIntPtr);
			if (num3 == 0)
			{
				do
				{
					_ = (z3X)(object)Aj8.Cm3(array, null, (int)checked((unchecked((uint)num2) + unchecked((uint)num2)) * unchecked((uint)(int)Aj8.Cm3(array, Aj8.Cm3(null, Aj8.Cm3(Aj8.Cm3(array, null, -1762398147), array, -1174996482), (int)checked(unchecked((uint)(int)Cq8.Default) * unchecked((uint)num2))), (int)checked(unchecked((uint)(int)Cq8.Default) * unchecked((uint)num2))))));
				}
				while ((object)Aj8.Cm3(array, (byte[])(object)Cq8.Default, num2) != null);
			}
			else
			{
				cq = cq;
				_ = (Tr3)(object)Cq8.Default;
			}
		}
		_ = (n9L)(object)Aj8.Cm3(array, array, (int)(2521760632u / checked(unchecked((uint)num2) - 1725683239u)));
		do
		{
			try
			{
				if (num3 / (nuint)(UIntPtr)Cq8.Default == 0)
				{
					_ = (Tr3)(object)Aj8.Cm3(Aj8.Cm3(Aj8.Cm3(null, null, 1891155146), null, (int)Cq8.Default), (byte[])(object)Cq8.Default, 595610143);
					gj = gj;
					gj = gj;
					Kz1 obj28 = (Kz1)(object)Aj8.Cm3(null, array, (int)(3075103140u / checked(4088924675u - unchecked((uint)num2)) / (uint)num2));
					kz = (Kz1)(object)Cq8.Default;
					kz = obj28;
					z3X obj29 = (z3X)(object)Aj8.Cm3(array, array, -901266367);
					z3X = (z3X)(object)Cq8.Default;
					z3X = obj29;
				}
				else
				{
					d5W = d5W;
				}
			}
			finally
			{
				try
				{
					aj = (Aj8)(object)Cq8.Default;
					aj = aj;
				}
				catch
				{
					_ = (c2M)(object)Aj8.Cm3(array, array, num2);
				}
				continue;
			}
		}
		while ((object)Cq8.Default != null);
		if (num3 == 0)
		{
			while ((object)Aj8.Cm3(array, null, (int)Cq8.Default) != null)
			{
				aj = aj;
			}
		}
		_ = (y6Z)(object)Cq8.Default;
		y0D2 = (y0D)(object)Aj8.Cm3(null, null, (int)(443451745u / (uint)num2));
		y0D2 = y0D2;
		z3X = null;
		d5W = null;
		do
		{
			if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
			{
				c2M = c2M;
			}
		}
		while ((object)Cq8.Default != null || (object)Aj8.Cm3(array, array, num2) != null);
		if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
		{
			_ = (Aj8)(object)Aj8.Cm3(array, array, (int)checked(unchecked((uint)(int)Aj8.Cm3(Aj8.Cm3(null, null, (int)checked(unchecked((uint)num2) + unchecked((uint)num2))), Aj8.Cm3(array, (byte[])(object)Cq8.Default, -816901914), (int)(1198479145u / (uint)(int)Aj8.Cm3(array, array, num2)))) - unchecked((uint)num2)));
		}
		else
		{
			nuint num8 = num3;
			num3 = default(UIntPtr);
			if (checked(num8 * num3) == 0)
			{
				try
				{
					y0D2 = y0D2;
				}
				catch
				{
					d2N = (d2N)Cq8.Default;
					d2N = d2N;
				}
			}
			else
			{
				_ = (Kj1)Cq8.Default;
			}
		}
		if (num3 == 0)
		{
			try
			{
				while (obj3 != null)
				{
					tr = (Tr3)(object)Aj8.Cm3(null, array, num2);
					kj = kj;
					n9L = n9L;
					n9L = n9L;
					_ = (y0D)(object)Aj8.Cm3((byte[])(object)Cq8.Default, Aj8.Cm3(array, null, (int)Cq8.Default), -695748001);
				}
			}
			catch
			{
				if ((UIntPtr)Aj8.Cm3(array, Aj8.Cm3(null, Aj8.Cm3(Aj8.Cm3(null, (byte[])(object)Cq8.Default, num2), null, (int)Aj8.Cm3(Aj8.Cm3(array, null, -845198003), array, 2085062035)), (int)checked(unchecked((uint)(int)Aj8.Cm3(Aj8.Cm3(null, Aj8.Cm3(array, array, 1097052082), 766210209), Aj8.Cm3(Aj8.Cm3(null, Aj8.Cm3(null, array, (int)checked(2087730313u - 3888684011u * 3178305298u * 2193404031u)), num2), array, num2), (int)Aj8.Cm3(null, null, (int)Cq8.Default))) * 1614652148u)), (int)Cq8.Default) == (UIntPtr)(nuint)0u)
				{
					_ = (d5W)(object)Cq8.Default;
				}
			}
		}
		else
		{
			try
			{
				if (num3 == 0)
				{
					tr = (Tr3)(object)Aj8.Cm3((byte[])(object)Cq8.Default, array, num2);
				}
				else
				{
					_ = (Kz1)(object)Aj8.Cm3(array, null, (int)Aj8.Cm3((byte[])(object)Cq8.Default, null, (int)Aj8.Cm3(Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)Cq8.Default), array, (int)Cq8.Default)));
				}
			}
			catch
			{
				kz = (Kz1)(object)Cq8.Default;
			}
		}
		z3X = z3X;
		do
		{
			try
			{
				if (num3 == 0)
				{
					c2M = null;
				}
				else
				{
					_ = (Gj7)(object)Aj8.Cm3(array, null, num2);
				}
			}
			finally
			{
				kj = (Kj1)Aj8.Cm3((byte[])(object)Cq8.Default, array, (int)Aj8.Cm3(null, array, (int)Cq8.Default));
				continue;
			}
		}
		while (obj3 != null);
		_ = (y6Z)(object)Aj8.Cm3(array, Aj8.Cm3(null, array, (int)Aj8.Cm3(array, array, (int)checked(unchecked((uint)(int)Aj8.Cm3(array, null, (int)checked(unchecked((uint)num2) + 235907456u))) + (unchecked((uint)num2) + unchecked(checked(unchecked((uint)(int)Cq8.Default) - (unchecked((uint)(int)Cq8.Default) - unchecked((uint)num2))) / 11248482u / (uint)num2) - unchecked((uint)(int)Aj8.Cm3(array, array, (int)(1928240525u / (uint)num2))) + 2407160764u) * unchecked((uint)num2)))), (int)Aj8.Cm3(array, array, num2));
		try
		{
			while ((object)Aj8.Cm3(array, array, num2) != null)
			{
				try
				{
					y6Z = (y6Z)(object)Cq8.Default;
				}
				finally
				{
					_ = (d2N)Aj8.Cm3(array, array, num2);
					continue;
				}
			}
		}
		catch
		{
			try
			{
				_ = (Gj7)(object)Cq8.Default;
			}
			catch
			{
				try
				{
					_ = (Tr3)(object)Cq8.Default;
					goto end_IL_0b12;
				}
				catch
				{
					n9L = (n9L)(object)Aj8.Cm3(array, (byte[])(object)Cq8.Default, -138256864);
					goto end_IL_0b12;
				}
				end_IL_0b12:;
			}
		}
		do
		{
			try
			{
				y0D2 = y0D2;
			}
			catch
			{
				if (num3 == 0)
				{
					aj = null;
					_ = (_003CModule_003E)(object)Cq8.Default;
				}
			}
		}
		while ((object)Aj8.Cm3(Aj8.Cm3((byte[])(object)Cq8.Default, (byte[])(object)Cq8.Default, -552717885), array, (int)Cq8.Default) != null);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
			do
			{
				try
				{
					_003CModule_003E obj38 = (_003CModule_003E)(object)Cq8.Default;
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = obj38;
				}
				finally
				{
					lw = lw;
					continue;
				}
			}
			while ((object)Cq8.Default != null);
		}
		do
		{
			_ = (d2N)Cq8.Default;
		}
		while ((object)Cq8.Default != null);
		num3 = default(UIntPtr);
		if (num3 == 0)
		{
			if ((nuint)(UIntPtr)Aj8.Cm3(array, null, num2) / num3 != 0)
			{
				try
				{
					d5W = d5W;
				}
				finally
				{
					_ = (Tr3)(object)Cq8.Default;
					goto IL_0d4c;
				}
			}
			num3 = default(UIntPtr);
			nuint num9 = num3;
			checked
			{
				nuint num10 = num3 - unchecked((nuint)(UIntPtr)Cq8.Default);
				num3 = default(UIntPtr);
				if (unchecked((nuint)default(UIntPtr)) + (num9 - (num10 - (num3 - num3 + unchecked((nuint)(UIntPtr)Cq8.Default))) + num3) == 0)
				{
					gj = gj;
					c2M = null;
					unchecked
					{
						_ = (Kj1)Aj8.Cm3(Aj8.Cm3(null, array, -693747930), null, (int)checked(unchecked((uint)(int)Cq8.Default) - unchecked((uint)(int)Aj8.Cm3((byte[])(object)Cq8.Default, array, (int)checked(unchecked((uint)(int)Cq8.Default) + 2953093599u)))));
						kz = kz;
					}
				}
			}
		}
		goto IL_0d4c;
	}

	static void p2M()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		byte[] nx = array;
		byte[] ko = array;
		byte[] nx2 = array;
		byte[] ko2 = (byte[])(object)Cq8.Default;
		int num = num;
		array = Aj8.Cm3(nx, null, (int)Aj8.Cm3(null, ko, (int)Aj8.Cm3(Aj8.Cm3(Aj8.Cm3(nx2, ko2, num), null, (int)Cq8.Default), null, (int)checked(2299823005u * unchecked((uint)(int)Cq8.Default / checked(unchecked((uint)num) - unchecked(checked(unchecked((uint)(int)Aj8.Cm3(array, array, (int)Cq8.Default)) - 3836212794u) / (uint)num)))))));
		_ = (Kz1)(object)Aj8.Cm3(array, null, num);
		nuint uIntPtr = uIntPtr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y6Z y6Z);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			_ = (d5W)(object)Aj8.Cm3(array, array, -65164104);
		}
		else
		{
			y6Z obj = (y6Z)(object)Aj8.Cm3(null, array, (int)checked(unchecked((uint)num) + unchecked((uint)num)));
			y6Z = (y6Z)(object)Aj8.Cm3(null, null, num);
			y6Z = obj;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z3X z3X);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Gj7 gj);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			do
			{
				try
				{
					_ = (y0D)(object)Aj8.Cm3(array, array, num);
				}
				finally
				{
					z3X = z3X;
					z3X = z3X;
					_ = (d5W)(object)Cq8.Default;
					continue;
				}
			}
			while ((object)Cq8.Default != null);
		}
		else
		{
			gj = gj;
			gj = null;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Tr3 tr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Wj3 wj);
		y0D y0D2;
		try
		{
			checked
			{
				try
				{
					uIntPtr = default(UIntPtr);
					UIntPtr num2 = uIntPtr;
					UIntPtr num3 = uIntPtr;
					uIntPtr = default(UIntPtr);
					if (unchecked((nuint)num2) + unchecked((nuint)num3 / (checked(uIntPtr + (uIntPtr + uIntPtr)) / checked(uIntPtr * unchecked((nuint)default(UIntPtr))))) == 0)
					{
						_ = Cq8.Default;
					}
				}
				finally
				{
					y0D2 = null;
					y0D2 = y0D2;
					tr = null;
					tr = tr;
					wj = wj;
					wj = null;
					goto end_IL_010e;
				}
			}
			end_IL_010e:;
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr != (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Lw6)(object)Aj8.Cm3(Aj8.Cm3((byte[])(object)Cq8.Default, Aj8.Cm3((byte[])(object)Cq8.Default, Aj8.Cm3(array, null, (int)Aj8.Cm3(array, array, (int)checked(121919494u - 3263499221u))), 1216541112), (int)checked(unchecked((uint)(int)Aj8.Cm3(array, array, 967756352)) * 1280629716u)), null, (int)Aj8.Cm3((byte[])(object)Cq8.Default, Aj8.Cm3(array, array, num), (int)checked(3329643474u * (1421282579u + 3584695477u) - unchecked((uint)num))));
				}
				finally
				{
					z3X = z3X;
					goto IL_021f;
				}
			}
			goto IL_021f;
		}
		IL_0b39:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c2M c2M);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		try
		{
			if (uIntPtr == 0)
			{
				c2M = c2M;
			}
			else
			{
				while (obj2 != null)
				{
					y6Z = (y6Z)(object)Aj8.Cm3(array, array, 668884859);
				}
			}
		}
		catch
		{
			_ = (Kz1)(object)Aj8.Cm3(null, array, num);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d5W d5W);
		try
		{
			if ((UIntPtr)Aj8.Cm3(null, Aj8.Cm3(null, Aj8.Cm3(array, array, (int)checked(unchecked((uint)num / 2337550225u) - 2832697396u)), -56142522), (int)((uint)(int)Cq8.Default / 4044441513u)) == (UIntPtr)(nuint)0u)
			{
				y6Z = (y6Z)(object)Aj8.Cm3(array, array, (int)checked(2644652121u + unchecked((uint)num)));
				gj = null;
				gj = null;
			}
			else
			{
				tr = tr;
				d5W = d5W;
			}
		}
		finally
		{
			_ = (y6Z)(object)Cq8.Default;
			goto IL_0be6;
		}
		IL_0c91:
		_ = (n9L)(object)Cq8.Default;
		_ = (Wj3)(object)Cq8.Default;
		_ = (Tr3)(object)Aj8.Cm3(Aj8.Cm3(Aj8.Cm3(array, Aj8.Cm3(array, array, (int)Aj8.Cm3(array, array, (int)Cq8.Default)), (int)checked(unchecked((uint)(int)Cq8.Default) + (4185052382u + unchecked((uint)(int)Cq8.Default / ((uint)num / (uint)num / checked(unchecked((uint)num) + unchecked(checked(unchecked((uint)(int)Cq8.Default) * 2025506780u) / ((uint)(int)Aj8.Cm3(array, array, num) / checked(unchecked((uint)(int)Cq8.Default) - 3963481602u))) + unchecked((uint)(int)Cq8.Default))) / (uint)num)))), Aj8.Cm3(Aj8.Cm3(array, null, (int)Aj8.Cm3(null, null, (int)Aj8.Cm3(array, Aj8.Cm3(Aj8.Cm3(Aj8.Cm3(null, (byte[])(object)Cq8.Default, 1384267417), null, (int)Aj8.Cm3(null, (byte[])(object)Cq8.Default, -2066150609)), (byte[])(object)Cq8.Default, num), num))), (byte[])(object)Cq8.Default, 287829490), (int)(2651348312u / (uint)num)), array, (int)Cq8.Default);
		z3X = null;
		_ = (n9L)(object)Aj8.Cm3(Aj8.Cm3(array, array, (int)Aj8.Cm3(array, array, (int)Aj8.Cm3(null, null, num))), null, (int)Aj8.Cm3(Aj8.Cm3(array, array, (int)Aj8.Cm3(array, array, num)), null, num));
		n9L n9L = null;
		d2N d2N = d2N;
		_ = (Wj3)(object)Cq8.Default;
		try
		{
			_ = (Cq8)(object)Aj8.Cm3(array, array, (int)Aj8.Cm3(array, array, (int)checked(unchecked((uint)num) * (unchecked((uint)(int)Aj8.Cm3(null, null, -2103263750)) + (unchecked((uint)(int)Cq8.Default) + unchecked((uint)num))))));
		}
		catch
		{
			nuint num4 = uIntPtr;
			uIntPtr = default(UIntPtr);
			if (num4 / checked(uIntPtr * uIntPtr) == 0)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (Lw6)(object)Aj8.Cm3(Aj8.Cm3(array, Aj8.Cm3(array, null, -1646705263), -722976040), Aj8.Cm3(array, array, 873070991), num);
				}
			}
		}
		if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
		{
			_ = (Kz1)(object)Cq8.Default;
		}
		_ = (z3X)(object)Aj8.Cm3(null, (byte[])(object)Cq8.Default, num);
		n9L = null;
		checked
		{
			try
			{
				try
				{
					_ = (d5W)(object)Aj8.Cm3((byte[])(object)Cq8.Default, array, unchecked((int)Cq8.Default));
					_ = (d5W)(object)Aj8.Cm3(array, array, -1067924147);
					z3X = null;
				}
				finally
				{
					wj = wj;
					goto end_IL_0f1c;
				}
				end_IL_0f1c:;
			}
			catch
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr + unchecked((nuint)(UIntPtr)Aj8.Cm3(array, null, (int)checked((unchecked((uint)(int)Aj8.Cm3((byte[])(object)Cq8.Default, array, (int)Aj8.Cm3(array, array, -1101452492))) + unchecked((uint)(int)Cq8.Default)) * 1820204456u * (unchecked((uint)num) - unchecked((uint)(int)Aj8.Cm3(null, (byte[])(object)Cq8.Default, num))) - unchecked((uint)(int)Cq8.Default)))) == 0)
				{
					while (obj2 != null)
					{
						_ = (Tr3)(object)Cq8.Default;
					}
				}
			}
			try
			{
				if (unchecked((nuint)(UIntPtr)Aj8.Cm3((byte[])(object)Cq8.Default, array, (int)Cq8.Default)) * uIntPtr == 0)
				{
					d2N = default(d2N);
					_ = (y6Z)(object)Aj8.Cm3(array, array, num);
				}
				else
				{
					_ = (Wj3)(object)Cq8.Default;
				}
				return;
			}
			catch
			{
				_ = (d2N)Cq8.Default;
				return;
			}
			finally
			{
				d5W = d5W;
				return;
			}
		}
		IL_0902:
		Kz1 kz = kz;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		checked
		{
			if (unchecked((nuint)(UIntPtr)Aj8.Cm3((byte[])(object)Cq8.Default, null, num) / (nuint)(UIntPtr)Cq8.Default) == 0)
			{
				nuint num5 = uIntPtr;
				uIntPtr = default(UIntPtr);
				nuint num6 = unchecked((nuint)default(UIntPtr)) + uIntPtr - unchecked((nuint)(UIntPtr)Aj8.Cm3(Aj8.Cm3(array, array, 1366811646), null, -1810841946)) * uIntPtr;
				nuint num7 = uIntPtr;
				uIntPtr = default(UIntPtr);
				nuint num8;
				unchecked
				{
					num8 = num6 / checked(num7 + unchecked(checked(uIntPtr - uIntPtr) / checked(uIntPtr + unchecked((nuint)default(UIntPtr)))) + unchecked((nuint)(UIntPtr)Aj8.Cm3(array, Aj8.Cm3(array, array, num), num)));
					uIntPtr = default(UIntPtr);
				}
				if (num5 - unchecked(checked(num8 - uIntPtr) / checked(uIntPtr - unchecked((nuint)default(UIntPtr)))) != 0)
				{
				}
			}
			do
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr * uIntPtr != 0)
				{
					do
					{
						_ = (z3X)(object)Cq8.Default;
					}
					while (obj2 != null);
				}
				else
				{
					_ = (Gj7)(object)Aj8.Cm3(Aj8.Cm3(array, array, -315232029), (byte[])(object)Cq8.Default, 12701112);
				}
			}
			while (obj2 != null);
			UIntPtr num9 = unchecked((UIntPtr)Aj8.Cm3(null, (byte[])(object)Cq8.Default, -1200472835));
			nuint num10 = uIntPtr;
			uIntPtr = default(UIntPtr);
			if (unchecked((nuint)num9) * unchecked(checked(num10 + uIntPtr) / (nuint)(UIntPtr)Aj8.Cm3(null, Aj8.Cm3(null, null, (int)((uint)num / checked(unchecked((uint)(int)Cq8.Default) + unchecked((uint)num)))), (int)checked(unchecked((uint)(int)Aj8.Cm3(null, array, -613144056)) - unchecked((uint)(int)Aj8.Cm3(array, null, num))))) == 0)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (_003CModule_003E)(object)Aj8.Cm3(array, array, num);
				}
			}
			_003CModule_003E = _003CModule_003E;
			gj = null;
			y0D2 = null;
			z3X = (z3X)(object)Aj8.Cm3(array, array, num);
			while (obj2 != null)
			{
				y0D2 = y0D2;
			}
		}
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				while ((object)Cq8.Default != null)
				{
					y0D2 = y0D2;
				}
			}
		}
		finally
		{
			while (obj2 != null)
			{
				_ = (d2N)Aj8.Cm3(Aj8.Cm3(array, null, (int)checked(unchecked((uint)num / (uint)(int)Aj8.Cm3(array, array, (int)checked(unchecked((uint)(int)Cq8.Default) * (unchecked((uint)(int)Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)checked(unchecked((uint)num) * (unchecked((uint)num) + (422362564u - (3871721639u - 3942183107u)))))) + unchecked((uint)num))))) - unchecked((uint)num))), array, -1200204612);
			}
			goto IL_0b39;
		}
		IL_0c33:
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			_003CModule_003E = (_003CModule_003E)(object)Cq8.Default;
		}
		Aj8 aj;
		try
		{
			n9L = n9L;
			aj = aj;
			z3X = (z3X)(object)Cq8.Default;
			_ = (d2N)Cq8.Default;
		}
		finally
		{
			try
			{
				_ = (d5W)(object)Aj8.Cm3(null, null, 129040120);
			}
			catch
			{
				_ = (Kz1)(object)Cq8.Default;
			}
			goto IL_0c91;
		}
		IL_0be6:
		try
		{
			try
			{
				_ = (Lw6)(object)Cq8.Default;
			}
			catch
			{
				gj = (Gj7)(object)Aj8.Cm3(array, array, (int)Cq8.Default);
			}
		}
		catch
		{
			try
			{
				aj = null;
			}
			catch
			{
			}
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr != (UIntPtr)(nuint)0u && uIntPtr == (UIntPtr)(nuint)0u)
			{
				y0D2 = null;
			}
			goto IL_0c33;
		}
		IL_07d4:
		try
		{
			uIntPtr = default(UIntPtr);
			if (checked(uIntPtr - unchecked((nuint)(UIntPtr)Cq8.Default) + uIntPtr) == 0)
			{
				try
				{
					gj = (Gj7)(object)Aj8.Cm3(array, null, (int)Cq8.Default);
				}
				catch
				{
					_ = (Kz1)(object)Aj8.Cm3(array, null, (int)Aj8.Cm3(Aj8.Cm3(array, (byte[])(object)Cq8.Default, num), Aj8.Cm3(array, Aj8.Cm3(array, array, (int)((uint)num / (uint)num)), (int)(checked(unchecked((uint)num) - unchecked((uint)(int)Cq8.Default)) / (uint)num)), (int)checked(unchecked((uint)(int)Aj8.Cm3(array, array, num)) - 1623195862u)));
				}
			}
			else
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (z3X)(object)Aj8.Cm3(array, null, (int)Cq8.Default);
				}
			}
		}
		finally
		{
			do
			{
				_ = (Cq8)(object)Aj8.Cm3(Aj8.Cm3(null, array, (int)checked(unchecked((uint)(int)Cq8.Default) - unchecked((uint)(int)Aj8.Cm3(Aj8.Cm3((byte[])(object)Cq8.Default, null, (int)Cq8.Default), array, (int)Aj8.Cm3(null, array, 1756456824))))), array, num);
			}
			while (obj2 != null);
			goto IL_0902;
		}
		IL_076e:
		do
		{
			Kz1 obj12 = (Kz1)(object)Cq8.Default;
			kz = kz;
			kz = obj12;
		}
		while (obj2 != null);
		_ = (d5W)(object)Aj8.Cm3(array, array, (int)checked(unchecked((uint)num) - unchecked((uint)(int)Cq8.Default)));
		while ((object)Aj8.Cm3(array, (byte[])(object)Cq8.Default, 245237220) != null)
		{
			kz = null;
			kz = kz;
			z3X = z3X;
		}
		try
		{
			d2N = default(d2N);
			d2N = d2N;
		}
		finally
		{
			goto IL_07d4;
		}
		IL_021f:
		try
		{
			try
			{
				z3X = z3X;
			}
			finally
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					d2N = d2N;
					d2N = d2N;
				}
				else
				{
					c2M = (c2M)(object)Cq8.Default;
					c2M = c2M;
				}
				goto end_IL_0220;
			}
			end_IL_0220:;
		}
		finally
		{
			try
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (Tr3)(object)Aj8.Cm3(array, array, (int)((uint)(int)Aj8.Cm3(array, array, num) / ((uint)(int)Cq8.Default / (uint)(int)Cq8.Default)));
				}
			}
			catch
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Tr3)(object)Aj8.Cm3(array, null, num);
				}
			}
			goto IL_02a4;
		}
		IL_02a4:
		checked
		{
			try
			{
				while (true)
				{
					obj2 = obj2;
					if (obj2 != null)
					{
						_ = (d2N)Cq8.Default;
					}
					else if ((object)Cq8.Default == null)
					{
						break;
					}
				}
			}
			finally
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					if (unchecked((nuint)(UIntPtr)Cq8.Default) * (unchecked((nuint)(UIntPtr)Aj8.Cm3(null, array, (int)checked(unchecked((uint)num) * unchecked((uint)num)))) - uIntPtr) == 0)
					{
						Cq8 cq = null;
						cq = cq;
					}
					else
					{
						_ = (_003CModule_003E)(object)Aj8.Cm3(null, Aj8.Cm3(null, null, 1277124752), num);
					}
				}
				else if (unchecked((nuint)(UIntPtr)Aj8.Cm3(Aj8.Cm3(array, Aj8.Cm3(array, null, 1354628558), (int)checked(unchecked((uint)(int)Aj8.Cm3(array, Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)Cq8.Default), num)) * unchecked((uint)num))), null, num)) + unchecked((nuint)(UIntPtr)Cq8.Default) == 0)
				{
					d2N = default(d2N);
				}
				else
				{
					d5W obj14 = (d5W)(object)Cq8.Default;
					d5W = d5W;
					d5W = obj14;
				}
				goto IL_03aa;
			}
		}
		IL_03aa:
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				_ = (n9L)(object)Cq8.Default;
			}
		}
		catch
		{
			n9L = n9L;
			n9L = n9L;
		}
		while ((object)Cq8.Default != null)
		{
			while (obj2 != null)
			{
				do
				{
					_ = (z3X)(object)Aj8.Cm3(array, array, -23683109);
					_ = (c2M)(object)Aj8.Cm3(array, array, (int)Cq8.Default);
				}
				while (obj2 != null);
			}
		}
		Aj8 obj16 = (Aj8)(object)Cq8.Default;
		aj = (Aj8)(object)Aj8.Cm3(Aj8.Cm3((byte[])(object)Cq8.Default, null, num), array, 1548534740);
		aj = obj16;
		do
		{
			try
			{
				gj = gj;
			}
			catch
			{
				_ = (Tr3)(object)Cq8.Default;
			}
		}
		while ((object)Aj8.Cm3(Aj8.Cm3(array, array, (int)Aj8.Cm3(array, array, (int)Aj8.Cm3(array, (byte[])(object)Cq8.Default, num))), (byte[])(object)Cq8.Default, (int)checked(unchecked((uint)num) * unchecked((uint)num))) != null || obj2 != null);
		try
		{
			try
			{
				try
				{
					_ = (Wj3)(object)Aj8.Cm3(array, null, num);
					_ = (Lw6)(object)Aj8.Cm3(array, (byte[])(object)Cq8.Default, 2137188777);
				}
				finally
				{
					y6Z = y6Z;
					goto end_IL_04a4;
				}
				end_IL_04a4:;
			}
			finally
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					n9L = (n9L)(object)Cq8.Default;
				}
				goto end_IL_04a3;
			}
			end_IL_04a3:;
		}
		catch
		{
			try
			{
				do
				{
					n9L = (n9L)(object)Cq8.Default;
				}
				while (obj2 != null);
			}
			finally
			{
				do
				{
					_ = (Gj7)(object)Aj8.Cm3(null, (byte[])(object)Cq8.Default, -492001661);
				}
				while ((object)Cq8.Default != null);
				goto end_IL_04f1;
			}
			end_IL_04f1:;
		}
		if ((UIntPtr)Aj8.Cm3(null, array, num) == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					_ = (Lw6)(object)Aj8.Cm3(Aj8.Cm3(array, array, (int)Cq8.Default), array, (int)checked(unchecked((uint)(int)Aj8.Cm3(array, null, -1045748248)) - 642026554u - unchecked((uint)num)));
					_ = (Cq8)(object)Aj8.Cm3(array, null, (int)checked((unchecked((uint)num) - 1821381609u) * unchecked((uint)num)));
				}
				finally
				{
					d2N = default(d2N);
					d2N = d2N;
					goto end_IL_0540;
				}
				end_IL_0540:;
			}
			finally
			{
				if (uIntPtr == 0)
				{
					z3X = null;
				}
				goto IL_05ac;
			}
		}
		goto IL_05ac;
		IL_05ac:
		try
		{
			do
			{
				try
				{
					_ = (d2N)Cq8.Default;
					aj = aj;
					_ = (y0D)(object)Cq8.Default;
				}
				catch
				{
					_ = (y0D)(object)Aj8.Cm3(null, array, (int)checked(unchecked((uint)(int)Aj8.Cm3(null, (byte[])(object)Cq8.Default, -2076898657)) * 2116828567u));
				}
			}
			while (obj2 != null);
		}
		finally
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				while (obj2 != null)
				{
					d2N = d2N;
				}
			}
			goto IL_0618;
		}
		IL_0618:
		gj = (Gj7)(object)Cq8.Default;
		gj = null;
		_ = (c2M)(object)Cq8.Default;
		_ = (y6Z)(object)Cq8.Default;
		n9L = n9L;
		while (obj2 != null)
		{
			try
			{
				if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
				{
					Cq8 cq = (Cq8)(object)Aj8.Cm3(null, array, num);
				}
			}
			catch
			{
				_ = (y6Z)(object)Cq8.Default;
				_ = (n9L)(object)Aj8.Cm3(null, (byte[])(object)Cq8.Default, (int)Cq8.Default);
			}
		}
		do
		{
			try
			{
				gj = (Gj7)(object)Aj8.Cm3(null, null, num);
			}
			catch
			{
				do
				{
					c2M = null;
					_ = (Tr3)(object)Cq8.Default;
				}
				while (obj2 != null);
			}
		}
		while (obj2 != null);
		wj = null;
		while ((object)Cq8.Default != null)
		{
			while (obj2 != null)
			{
				Kj1 obj22 = (Kj1)Aj8.Cm3(Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)((uint)num / checked(unchecked((uint)num) - 519227763u))), array, 1795098304);
				Kj1 kj = default(Kj1);
				kj = obj22;
			}
		}
		uIntPtr = default(UIntPtr);
		checked
		{
			if (uIntPtr + uIntPtr == 0)
			{
				n9L = n9L;
			}
			try
			{
				if (unchecked((nuint)(UIntPtr)Cq8.Default) * uIntPtr == 0)
				{
					try
					{
						_ = (Gj7)(object)Aj8.Cm3(array, Aj8.Cm3(array, array, unchecked((int)((uint)num / (uint)num))), num);
					}
					catch
					{
						_ = (y0D)(object)Cq8.Default;
					}
				}
			}
			finally
			{
				if (uIntPtr == 0)
				{
					do
					{
						_003CModule_003E = _003CModule_003E;
						_003CModule_003E = _003CModule_003E;
					}
					while (obj2 != null);
				}
				goto IL_076e;
			}
		}
	}

	static void Cn4()
	{
		UIntPtr uIntPtr = default(UIntPtr);
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Lw6 lw);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cq8 cq);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Kj1 kj);
		if (uIntPtr == 0)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0 && uIntPtr == 0)
			{
				array = array;
				byte[] nx = array;
				byte[] ko = array;
				num = num;
				_ = (d5W)(object)Aj8.Cm3(nx, ko, (int)checked(unchecked((uint)num) * unchecked((uint)(int)Cq8.Default)));
				Kj1 obj = (Kj1)Cq8.Default;
				kj = kj;
				kj = obj;
				cq = cq;
				cq = null;
				_ = (_003CModule_003E)(object)Aj8.Cm3(array, null, (int)checked(unchecked((uint)(int)Aj8.Cm3(array, array, num)) * unchecked((uint)(int)Cq8.Default)));
			}
		}
		else if (uIntPtr == 0)
		{
			_ = (z3X)(object)Aj8.Cm3((byte[])(object)Cq8.Default, Aj8.Cm3(null, Aj8.Cm3(array, array, (int)Aj8.Cm3((byte[])(object)Cq8.Default, array, (int)Cq8.Default)), (int)Cq8.Default), 1914811395);
		}
		else
		{
			try
			{
				Lw6 obj2 = (Lw6)(object)Aj8.Cm3(array, array, num);
				lw = null;
				lw = obj2;
			}
			catch
			{
				_ = (Kz1)(object)Aj8.Cm3(array, array, 486247447);
				_ = (y6Z)(object)Cq8.Default;
				_ = (_003CModule_003E)(object)Cq8.Default;
				_ = (y6Z)(object)Cq8.Default;
			}
		}
		_ = (y0D)(object)Aj8.Cm3(Aj8.Cm3(array, Aj8.Cm3((byte[])(object)Cq8.Default, array, 1623910881), -2002505694), Aj8.Cm3(null, Aj8.Cm3(array, array, -1468229456), num), (int)Aj8.Cm3(array, Aj8.Cm3(array, null, (int)Cq8.Default), num));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c2M c2M);
		Gj7 gj;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d2N d2N);
		try
		{
			while (true)
			{
				obj4 = obj4;
				if (obj4 != null)
				{
					d2N = (d2N)Cq8.Default;
					d2N = d2N;
					continue;
				}
				break;
			}
		}
		catch
		{
			try
			{
				try
				{
					gj = null;
					gj = gj;
				}
				finally
				{
					Aj8 obj5 = (Aj8)(object)Aj8.Cm3(array, array, 528117664);
					Aj8 aj = aj;
					aj = obj5;
					_ = (Tr3)(object)Cq8.Default;
					goto end_IL_024e;
				}
				end_IL_024e:;
			}
			finally
			{
				do
				{
					_ = (d2N)Aj8.Cm3(array, null, 849345600);
					lw = lw;
					c2M = null;
					c2M = c2M;
				}
				while ((object)Aj8.Cm3(array, array, 98637534) != null);
				goto end_IL_024d;
			}
			end_IL_024d:;
		}
		_ = Cq8.Default;
		Kz1 kz = (Kz1)(object)Aj8.Cm3(array, null, 2049183219);
		kz = kz;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z3X z3X);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d5W d5W);
		try
		{
			if (uIntPtr / (nuint)(UIntPtr)Aj8.Cm3(null, array, 545927687) == 0)
			{
				_ = (n9L)(object)Aj8.Cm3(array, array, num);
			}
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			if (checked(uIntPtr + uIntPtr) == 0)
			{
				_ = (d5W)(object)Cq8.Default;
				c2M = c2M;
				_ = (d2N)Aj8.Cm3(null, (byte[])(object)Cq8.Default, (int)Aj8.Cm3(null, null, num));
				_ = (Aj8)(object)Aj8.Cm3(array, array, num);
			}
			else
			{
				z3X = (z3X)(object)Aj8.Cm3(null, Aj8.Cm3(array, null, (int)checked(unchecked((uint)num) * 3089548440u)), (int)checked((563345672u + unchecked((uint)num)) * (unchecked((uint)num / (uint)(int)Aj8.Cm3(null, array, 985263776)) - unchecked((uint)num)) * unchecked((uint)num)));
				z3X = z3X;
				_ = (n9L)(object)Aj8.Cm3(Aj8.Cm3(array, (byte[])(object)Cq8.Default, -2060318366), array, (int)checked(4065139856u - unchecked((uint)(int)Cq8.Default / 861277950u)));
				_ = (_003CModule_003E)(object)Cq8.Default;
				d5W obj7 = (d5W)(object)Aj8.Cm3(null, Aj8.Cm3(Aj8.Cm3(array, array, (int)(checked(149347209u - (1323468865u + unchecked((uint)(int)Cq8.Default))) / 786713866u / (uint)(int)Cq8.Default)), array, -1768239552), (int)((uint)num / 1085820888u));
				d5W = d5W;
				d5W = obj7;
			}
			goto IL_04be;
		}
		IL_0ed5:
		_ = (Lw6)(object)Aj8.Cm3(array, null, num);
		Wj3 wj;
		do
		{
			try
			{
				kz = kz;
			}
			catch
			{
				gj = (Gj7)(object)Aj8.Cm3(null, array, 1140555497);
			}
			finally
			{
				try
				{
					wj = wj;
				}
				finally
				{
					_ = (Lw6)(object)Aj8.Cm3((byte[])(object)Cq8.Default, (byte[])(object)Cq8.Default, (int)Aj8.Cm3(Aj8.Cm3(array, array, num), array, (int)checked(3915373786u + 2860786636u * 2114597720u + (unchecked((uint)(int)Cq8.Default) + (unchecked((uint)(int)Aj8.Cm3(array, array, 832448430)) + unchecked((uint)(int)Aj8.Cm3(null, array, num)))))));
					continue;
				}
			}
		}
		while ((object)Cq8.Default != null);
		if ((UIntPtr)Aj8.Cm3(null, array, (int)Cq8.Default) == (UIntPtr)(nuint)0u)
		{
			_ = (y0D)(object)Cq8.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n9L n9L);
		if (uIntPtr == 0)
		{
			if (uIntPtr == 0)
			{
				_ = (Wj3)(object)Cq8.Default;
			}
		}
		else
		{
			n9L obj9 = (n9L)(object)Aj8.Cm3(null, null, num);
			n9L = (n9L)(object)Cq8.Default;
			n9L = obj9;
			n9L = (n9L)(object)Cq8.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y6Z y6Z);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Tr3 tr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				if ((UIntPtr)Aj8.Cm3(array, null, (int)checked(unchecked((uint)(int)Cq8.Default) - (112866805u + unchecked((uint)(int)Cq8.Default)))) == (UIntPtr)(nuint)0u)
				{
					_ = (d2N)Aj8.Cm3((byte[])(object)Cq8.Default, array, (int)Cq8.Default);
					tr = tr;
					_ = (Kz1)(object)Cq8.Default;
					_ = (_003CModule_003E)(object)Aj8.Cm3(array, array, (int)Aj8.Cm3((byte[])(object)Cq8.Default, array, -650556210));
				}
			}
			else
			{
				try
				{
					d5W = null;
				}
				catch
				{
					_ = (Lw6)(object)Aj8.Cm3(Aj8.Cm3(array, array, 635843186), array, -1723114286);
					y6Z = null;
				}
			}
		}
		finally
		{
			try
			{
				cq = cq;
				_003CModule_003E = (_003CModule_003E)(object)Aj8.Cm3(null, null, (int)Aj8.Cm3(null, Aj8.Cm3(null, array, num), (int)checked(3381916632u * (unchecked((uint)(int)Cq8.Default) - unchecked((uint)(int)Cq8.Default)))));
				gj = gj;
				_ = (Kz1)(object)Cq8.Default;
			}
			finally
			{
				y6Z = y6Z;
				n9L = n9L;
				lw = lw;
				_ = (Gj7)(object)Aj8.Cm3(array, null, -1385505615);
				goto IL_11b3;
			}
		}
		IL_0a8f:
		_ = (c2M)(object)Cq8.Default;
		try
		{
			try
			{
				_003CModule_003E = null;
			}
			finally
			{
				c2M = c2M;
				goto end_IL_0a9a;
			}
			end_IL_0a9a:;
		}
		finally
		{
			goto IL_0ab0;
		}
		IL_1339:
		if ((UIntPtr)Aj8.Cm3(null, Aj8.Cm3(array, null, num), (int)Aj8.Cm3(array, Aj8.Cm3(Aj8.Cm3(array, null, 2131074949), array, (int)Aj8.Cm3(null, array, -1425205686)), 1893964625)) == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (y0D)(object)Aj8.Cm3(array, array, (int)Cq8.Default);
			}
			catch
			{
				lw = lw;
			}
		}
		UIntPtr num2 = (UIntPtr)Aj8.Cm3((byte[])(object)Cq8.Default, array, 1229810364);
		uIntPtr = default(UIntPtr);
		if ((nuint)num2 / uIntPtr == 0 && (UIntPtr)Aj8.Cm3((byte[])(object)Cq8.Default, null, (int)(3817342979u / checked(unchecked((uint)num) - unchecked((uint)num)))) == (UIntPtr)(nuint)0u)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr / checked(uIntPtr - uIntPtr) == 0)
			{
				lw = lw;
			}
			else
			{
				_ = (n9L)(object)Cq8.Default;
			}
		}
		while ((object)Cq8.Default != null)
		{
			nuint num3 = uIntPtr;
			UIntPtr num4 = (UIntPtr)Cq8.Default;
			uIntPtr = default(UIntPtr);
			if (num3 / checked(unchecked((nuint)num4) * (unchecked((nuint)default(UIntPtr)) - uIntPtr)) == 0)
			{
				_ = (_003CModule_003E)(object)Aj8.Cm3(array, Aj8.Cm3(array, null, (int)Cq8.Default), -682656877);
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
				do
				{
					d5W = null;
					c2M = c2M;
					kj = default(Kj1);
				}
				while ((object)Aj8.Cm3(null, array, (int)Cq8.Default) != null);
				goto end_IL_14bf;
			}
			end_IL_14bf:;
		}
		finally
		{
			try
			{
				z3X = z3X;
			}
			finally
			{
				try
				{
					_003CModule_003E = null;
				}
				finally
				{
					_ = (c2M)(object)Cq8.Default;
					goto IL_1530;
				}
			}
		}
		IL_1610:
		if ((UIntPtr)Aj8.Cm3(null, null, (int)Aj8.Cm3(array, array, (int)checked(896316927u * unchecked(checked(unchecked((uint)num) + (2465826621u - unchecked((uint)(int)Aj8.Cm3(array, array, -1497263682)))) / (uint)num)))) == (UIntPtr)(nuint)0u)
		{
			cq = null;
		}
		else
		{
			c2M = c2M;
		}
		return;
		IL_1530:
		c2M = (c2M)(object)Aj8.Cm3((byte[])(object)Cq8.Default, array, (int)checked(unchecked((uint)num) * 52206831u));
		kz = (Kz1)(object)Cq8.Default;
		_ = (Wj3)(object)Aj8.Cm3(array, null, (int)Aj8.Cm3(null, null, -1168175255));
		try
		{
			do
			{
				if ((UIntPtr)Cq8.Default != (UIntPtr)(nuint)0u)
				{
					gj = null;
				}
				else
				{
					c2M = c2M;
				}
			}
			while ((object)Cq8.Default != null);
		}
		finally
		{
			if ((UIntPtr)Aj8.Cm3(null, (byte[])(object)Cq8.Default, num) == (UIntPtr)(nuint)0u)
			{
				try
				{
					cq = cq;
				}
				catch
				{
					_ = (c2M)(object)Aj8.Cm3(array, array, -2113484299);
				}
			}
			else
			{
				try
				{
					wj = wj;
				}
				catch
				{
					_ = (Lw6)(object)Cq8.Default;
				}
			}
			goto IL_1610;
		}
		IL_0ab0:
		if (uIntPtr == 0)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u && uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (Kj1)Cq8.Default;
			}
		}
		else if ((UIntPtr)Aj8.Cm3(Aj8.Cm3(array, null, num), array, (int)Cq8.Default) == (UIntPtr)(nuint)0u)
		{
			do
			{
				_ = (z3X)(object)Cq8.Default;
			}
			while (obj4 != null);
		}
		else
		{
			while ((object)Aj8.Cm3(array, array, (int)Aj8.Cm3(array, null, num)) != null)
			{
				_ = (_003CModule_003E)(object)Cq8.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y0D y0D2);
		if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Kz1)(object)Aj8.Cm3(array, array, num);
				}
			}
			catch
			{
				while (obj4 != null)
				{
					y0D2 = (y0D)(object)Cq8.Default;
				}
			}
		}
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
				{
					_ = (d2N)Cq8.Default;
				}
				else
				{
					Aj8 aj = null;
				}
			}
		}
		finally
		{
			gj = gj;
			goto IL_0bd3;
		}
		IL_11b3:
		try
		{
			while ((object)Aj8.Cm3((byte[])(object)Cq8.Default, (byte[])(object)Cq8.Default, (int)checked(unchecked((uint)(int)Cq8.Default) - 3643622211u)) != null)
			{
				d5W = (d5W)(object)Aj8.Cm3(Aj8.Cm3((byte[])(object)Cq8.Default, null, (int)Cq8.Default), null, -294340412);
			}
		}
		catch
		{
			d5W = (d5W)(object)Aj8.Cm3(Aj8.Cm3(Aj8.Cm3(Aj8.Cm3(null, array, 813765882), array, (int)Aj8.Cm3(null, array, (int)checked(unchecked((uint)(int)Aj8.Cm3((byte[])(object)Cq8.Default, array, (int)Aj8.Cm3(array, array, 188434838))) * unchecked((uint)(int)Cq8.Default) - 3983648009u))), null, 883483805), null, (int)Cq8.Default);
			_ = (Aj8)(object)Cq8.Default;
			_ = (d2N)Cq8.Default;
		}
		if (uIntPtr == 0)
		{
			while ((object)Aj8.Cm3(array, array, -1622955986) != null)
			{
				if ((UIntPtr)Aj8.Cm3(null, array, -1220047430) == (UIntPtr)(nuint)0u)
				{
					tr = (Tr3)(object)Cq8.Default;
				}
			}
		}
		try
		{
			_ = (Kz1)(object)Cq8.Default;
		}
		finally
		{
			do
			{
				_ = (n9L)(object)Cq8.Default;
			}
			while (obj4 != null);
			goto IL_1339;
		}
		IL_0744:
		try
		{
			_ = (Wj3)(object)Cq8.Default;
		}
		catch
		{
			lw = (Lw6)(object)Cq8.Default;
		}
		if (uIntPtr / (nuint)(UIntPtr)Cq8.Default == 0)
		{
			kz = null;
		}
		do
		{
			try
			{
				do
				{
					c2M = c2M;
					kj = kj;
				}
				while (obj4 != null);
			}
			finally
			{
				_ = (z3X)(object)Aj8.Cm3(array, (byte[])(object)Cq8.Default, num);
				cq = cq;
				continue;
			}
		}
		while (obj4 != null);
		try
		{
			try
			{
				_003CModule_003E = null;
				_003CModule_003E = _003CModule_003E;
			}
			finally
			{
				try
				{
					_ = (Kz1)(object)Cq8.Default;
				}
				catch
				{
					c2M = c2M;
				}
				goto end_IL_07c4;
			}
			end_IL_07c4:;
		}
		catch
		{
			if (uIntPtr / checked(unchecked((nuint)(UIntPtr)Cq8.Default) * unchecked((nuint)(UIntPtr)Cq8.Default)) == 0)
			{
				try
				{
					d5W = d5W;
				}
				catch
				{
					cq = Cq8.Default;
				}
			}
			else if ((UIntPtr)Aj8.Cm3(null, null, num) == (UIntPtr)(nuint)0u)
			{
				z3X = z3X;
			}
		}
		try
		{
			if (uIntPtr == 0)
			{
				_ = Cq8.Default;
			}
			else
			{
				_ = (Kz1)(object)Cq8.Default;
			}
		}
		catch
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				do
				{
					_ = (y6Z)(object)Aj8.Cm3(array, Aj8.Cm3(null, array, num), -108766598);
				}
				while ((object)Cq8.Default != null);
			}
		}
		c2M = c2M;
		try
		{
			while (obj4 != null)
			{
				do
				{
					z3X = z3X;
				}
				while (obj4 != null);
			}
		}
		catch
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				_ = (_003CModule_003E)(object)Aj8.Cm3(array, null, (int)Aj8.Cm3(null, null, num));
				_ = (Kj1)Aj8.Cm3(null, array, num);
			}
		}
		try
		{
			if ((UIntPtr)Aj8.Cm3(array, array, num) == (UIntPtr)(nuint)0u)
			{
				try
				{
					d5W = d5W;
				}
				catch
				{
					c2M = c2M;
					gj = gj;
				}
			}
		}
		catch
		{
			if (uIntPtr == 0)
			{
				try
				{
					_ = (Kj1)Cq8.Default;
				}
				catch
				{
					_ = (y0D)(object)Aj8.Cm3(array, null, 639761113);
				}
			}
		}
		nuint num5 = uIntPtr;
		uIntPtr = default(UIntPtr);
		if (num5 / uIntPtr == 0)
		{
			try
			{
				_ = (Kz1)(object)Cq8.Default;
			}
			catch
			{
				kj = kj;
			}
		}
		try
		{
			try
			{
				_ = (c2M)(object)Cq8.Default;
				y6Z obj26 = (y6Z)(object)Cq8.Default;
				y6Z = (y6Z)(object)Aj8.Cm3((byte[])(object)Cq8.Default, Aj8.Cm3(array, (byte[])(object)Cq8.Default, 426026046), -2036464865);
				y6Z = obj26;
			}
			catch
			{
				_ = (Kj1)Aj8.Cm3(array, array, 1365668861);
			}
		}
		catch
		{
			try
			{
				_ = (y6Z)(object)Aj8.Cm3(array, array, (int)Aj8.Cm3((byte[])(object)Cq8.Default, (byte[])(object)Cq8.Default, (int)Aj8.Cm3(Aj8.Cm3(null, null, -1960483890), null, (int)Cq8.Default)));
			}
			catch
			{
				_ = (d2N)Cq8.Default;
			}
		}
		finally
		{
			wj = null;
			goto IL_0a8f;
		}
		IL_04be:
		_ = (c2M)(object)Aj8.Cm3((byte[])(object)Cq8.Default, (byte[])(object)Cq8.Default, 935384789);
		_ = (Wj3)(object)Cq8.Default;
		_ = (Lw6)(object)Cq8.Default;
		try
		{
			do
			{
				d5W = d5W;
			}
			while ((object)Aj8.Cm3(array, null, num) != null);
		}
		catch
		{
			try
			{
				_ = (Tr3)(object)Aj8.Cm3((byte[])(object)Cq8.Default, array, num);
			}
			catch
			{
				y0D2 = (y0D)(object)Cq8.Default;
				y0D2 = y0D2;
			}
		}
		gj = null;
		if ((UIntPtr)Aj8.Cm3(array, null, num) == (UIntPtr)(nuint)0u)
		{
			_ = (c2M)(object)Aj8.Cm3((byte[])(object)Cq8.Default, array, num);
		}
		wj = null;
		wj = wj;
		while ((object)Aj8.Cm3((byte[])(object)Cq8.Default, array, (int)Cq8.Default) != null)
		{
			y0D2 = y0D2;
			_ = (d2N)Cq8.Default;
			d5W = null;
		}
		if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				_ = (z3X)(object)Aj8.Cm3(array, array, -1233117705);
			}
		}
		cq = cq;
		_ = (z3X)(object)Cq8.Default;
		y0D2 = (y0D)(object)Cq8.Default;
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr != 0)
			{
				try
				{
					cq = cq;
				}
				finally
				{
					_ = (Tr3)(object)Cq8.Default;
					goto end_IL_062a;
				}
			}
			d2N = d2N;
			end_IL_062a:;
		}
		finally
		{
			while ((object)Aj8.Cm3(Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)checked(1546529257u * unchecked((uint)(int)Cq8.Default))), Aj8.Cm3(array, null, 867257178), -1545930811) != null)
			{
				if (uIntPtr == 0)
				{
					gj = (Gj7)(object)Aj8.Cm3(null, Aj8.Cm3(Aj8.Cm3(null, array, (int)checked(unchecked((uint)(int)Cq8.Default) + 3939237764u)), array, num), 1423939674);
					continue;
				}
				_ = (d5W)(object)Cq8.Default;
				z3X = (z3X)(object)Cq8.Default;
				_ = (y6Z)(object)Aj8.Cm3((byte[])(object)Cq8.Default, array, num);
				wj = wj;
			}
			goto IL_0744;
		}
		IL_0bd3:
		uIntPtr = default(UIntPtr);
		if (unchecked((nuint)default(UIntPtr)) / checked(uIntPtr + unchecked((nuint)(UIntPtr)Aj8.Cm3((byte[])(object)Cq8.Default, Aj8.Cm3(Aj8.Cm3(array, array, (int)Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)((uint)(int)Aj8.Cm3(array, array, num) / 1294975802u))), array, -625598068), num)) * uIntPtr) == 0)
		{
			try
			{
				try
				{
					cq = null;
				}
				finally
				{
					_ = (Kj1)Cq8.Default;
					goto end_IL_0c69;
				}
				end_IL_0c69:;
			}
			catch
			{
				if (uIntPtr == 0)
				{
					_ = (Kz1)(object)Cq8.Default;
				}
			}
		}
		try
		{
			if (uIntPtr == 0)
			{
				while ((object)Cq8.Default != null)
				{
					cq = cq;
				}
			}
			else
			{
				try
				{
					_ = (y6Z)(object)Aj8.Cm3(array, array, 953999044);
					kj = kj;
				}
				catch
				{
					_ = (Aj8)(object)Cq8.Default;
				}
			}
		}
		catch
		{
			if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (d2N)Cq8.Default;
				}
				finally
				{
					lw = null;
					goto end_IL_0ce9;
				}
			}
			end_IL_0ce9:;
		}
		while (obj4 != null)
		{
			y6Z = y6Z;
			_ = (y0D)(object)Cq8.Default;
			z3X = (z3X)(object)Aj8.Cm3(array, null, (int)(545386810u / (uint)(int)Aj8.Cm3(array, array, (int)checked((unchecked((uint)(int)Aj8.Cm3(array, array, (int)((uint)num / (uint)num))) - 1242262519u) * 3389951013u))));
			_003CModule_003E = _003CModule_003E;
		}
		try
		{
			if (uIntPtr == 0)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (Wj3)(object)Cq8.Default;
				}
			}
		}
		catch
		{
			try
			{
				if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
				{
					gj = (Gj7)(object)Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)checked(911937161u * unchecked((uint)num)));
					tr = (Tr3)(object)Aj8.Cm3(null, array, num);
					tr = null;
				}
			}
			finally
			{
				do
				{
					_003CModule_003E = _003CModule_003E;
				}
				while ((object)Aj8.Cm3(Aj8.Cm3(Aj8.Cm3(array, (byte[])(object)Cq8.Default, num), Aj8.Cm3(Aj8.Cm3(Aj8.Cm3(array, array, -10341999), array, num), array, (int)checked(unchecked((uint)num) + 1113727299u)), (int)Cq8.Default), null, 730873558) != null);
				goto end_IL_0da5;
			}
			end_IL_0da5:;
		}
		if (uIntPtr == 0)
		{
			y0D2 = null;
		}
		_ = (Kj1)Cq8.Default;
		try
		{
			_ = (Kj1)Cq8.Default;
			_003CModule_003E = _003CModule_003E;
			c2M = c2M;
		}
		finally
		{
			while (obj4 != null)
			{
				_ = (Aj8)(object)Cq8.Default;
			}
			goto IL_0ed5;
		}
	}
}
