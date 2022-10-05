using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
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
using t7Z;
using y0J;
using y9M;

namespace Af6;

public class Tr3 : Application
{
	internal delegate void En1();

	internal static byte[] G;

	internal static string[] H;

	internal static byte[] Y;

	internal static Type f;

	internal static bool Zp0(string string_0, string string_1)
	{
		if (string_0.Contains(string_1))
		{
			return true;
		}
		return false;
	}

	[STAThread]
	public static void Yf1()
	{
		checked
		{
			try
			{
				int num = 0;
				int num2 = 61440;
				string string_2 = default(string);
				string string_ = default(string);
				while (num < 9)
				{
					switch (num)
					{
					case 0:
						Wj3.x9F();
						num++;
						break;
					case 1:
						num2 *= 2;
						num++;
						break;
					case 2:
						G = Gj7.m5G(num2);
						num++;
						break;
					case 3:
						Y = Aj8.m5A(num * 2);
						num++;
						break;
					case 4:
						G = Aj8.Cm3(G, Y, num + 2);
						num++;
						break;
					case 5:
					{
						string[] array = new string[3];
						array[0] = "r".ToUpper();
						array[2] = "z";
						array[1] = array[0].ToLower();
						StringBuilder stringBuilder = new StringBuilder();
						string[] array2 = array;
						foreach (string value in array2)
						{
							stringBuilder.Append(value);
						}
						string_2 = stringBuilder.ToString();
						num++;
						break;
					}
					case 6:
					{
						Type[] array5 = y0D.Jd4();
						foreach (Type type in array5)
						{
							if (Zp0(type.Name, string_2))
							{
								f = type;
							}
						}
						num++;
						break;
					}
					case 7:
					{
						string[] array3 = new string[4]
						{
							"p",
							"e",
							"q",
							"r".ToUpper()
						};
						StringBuilder stringBuilder2 = new StringBuilder();
						string[] array4 = array3;
						foreach (string value2 in array4)
						{
							stringBuilder2.Append(value2);
						}
						string_ = stringBuilder2.ToString();
						num++;
						break;
					}
					case 8:
						if ((object)f != null)
						{
							Type typeFromHandle = typeof(En1);
							Kz1.Ts5(typeFromHandle, f, string_);
						}
						num++;
						break;
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	static void Bt6()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Aj8 aj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d5W d5W);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d2N d2N);
		try
		{
			checked
			{
				num *= unchecked((nuint)(UIntPtr)Cq8.Default);
				if (num == 0)
				{
					try
					{
						array = array;
						byte[] nx = array;
						num2 = 422624911;
						_ = (Aj8)(object)Aj8.Cm3(nx, null, 422624911);
					}
					catch
					{
						_ = (n9L)(object)Cq8.Default;
					}
				}
			}
		}
		finally
		{
			try
			{
				d2N = default(d2N);
				d2N = d2N;
				d2N = d2N;
				_ = (y6Z)(object)Aj8.Cm3(Aj8.Cm3(null, Aj8.Cm3((byte[])(object)Cq8.Default, (byte[])(object)Cq8.Default, (int)Cq8.Default), (int)Aj8.Cm3(array, array, num2)), array, (int)Aj8.Cm3(Aj8.Cm3(array, array, 1909023604), array, (int)Aj8.Cm3(array, null, 1875654359)));
				_ = (z3X)(object)Aj8.Cm3((byte[])(object)Cq8.Default, array, num2);
				Tr3 tr = tr;
				tr = tr;
			}
			finally
			{
				try
				{
					_ = (d5W)(object)Aj8.Cm3(array, null, (int)Aj8.Cm3(Aj8.Cm3(array, array, num2), (byte[])(object)Cq8.Default, -1864406752));
				}
				catch
				{
					_ = (n9L)(object)Aj8.Cm3(array, array, 1192065551);
					Aj8 obj2 = (Aj8)(object)Aj8.Cm3(null, array, (int)Cq8.Default);
					aj = aj;
					aj = obj2;
					d5W = null;
					d5W = d5W;
				}
				goto IL_01c5;
			}
		}
		IL_01c5:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z3X z3X);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y6Z y6Z);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n9L n9L);
		try
		{
			z3X = z3X;
			z3X = z3X;
		}
		catch
		{
			y6Z = (y6Z)(object)Aj8.Cm3(array, null, num2);
			y6Z = y6Z;
			n9L = null;
			n9L = null;
			obj4 = null;
		}
		_ = (d5W)(object)Aj8.Cm3(Aj8.Cm3(null, null, num2), array, (int)checked(unchecked((uint)(int)Aj8.Cm3(array, array, (int)checked(unchecked((uint)num2) * 513824009u))) * 2363463032u));
		num = default(UIntPtr);
		checked
		{
			if (unchecked((nuint)default(UIntPtr)) - num == 0)
			{
				try
				{
					d2N = (d2N)Aj8.Cm3(array, array, num2);
				}
				catch
				{
					_ = (Lw6)(object)Cq8.Default;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Lw6 lw);
		while (obj4 != null)
		{
			try
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					Lw6 obj7 = (Lw6)(object)Aj8.Cm3(null, null, (int)((uint)num2 / (uint)num2));
					lw = null;
					lw = obj7;
				}
				else
				{
					_ = (d2N)Aj8.Cm3((byte[])(object)Cq8.Default, null, -888790755);
				}
			}
			finally
			{
				if (num == 0)
				{
					d5W = d5W;
					continue;
				}
				c2M c2M = (c2M)(object)Cq8.Default;
				c2M = c2M;
				continue;
			}
		}
		Cq8 cq = (Cq8)(object)Aj8.Cm3(array, array, (int)checked(unchecked((uint)(int)Cq8.Default) - unchecked((uint)(int)Cq8.Default)));
		cq = cq;
		try
		{
			_ = (Kj1)Cq8.Default;
		}
		finally
		{
			_ = (d5W)(object)Aj8.Cm3((byte[])(object)Cq8.Default, array, (int)Cq8.Default);
			goto IL_037b;
		}
		IL_120c:
		z3X = z3X;
		Gj7 gj = gj;
		nuint num3 = num;
		num = default(UIntPtr);
		checked
		{
			if (num3 + (unchecked((nuint)default(UIntPtr)) - unchecked(checked(num * unchecked((nuint)(UIntPtr)Cq8.Default)) / (nuint)(UIntPtr)Aj8.Cm3(Aj8.Cm3(array, array, 784312614), (byte[])(object)Cq8.Default, num2)) - num - unchecked((nuint)(UIntPtr)Cq8.Default)) == 0)
			{
				_ = (_003CModule_003E)(object)Aj8.Cm3(null, array, num2);
			}
			return;
		}
		IL_0549:
		do
		{
			try
			{
				try
				{
					_ = (_003CModule_003E)(object)Aj8.Cm3(Aj8.Cm3(array, null, 137384923), null, -1043330757);
				}
				catch
				{
					_ = (n9L)(object)Aj8.Cm3(array, array, (int)Aj8.Cm3(Aj8.Cm3((byte[])(object)Cq8.Default, array, -1851722695), Aj8.Cm3(array, array, 883808866), 2078893783));
				}
			}
			catch
			{
				num = default(UIntPtr);
				if (num == (UIntPtr)(nuint)0u)
				{
					_ = (Kz1)(object)Aj8.Cm3(null, array, (int)checked(unchecked((uint)num2) - 2202850711u));
				}
			}
		}
		while (obj4 != null);
		_ = (Cq8)(object)Aj8.Cm3(array, null, (int)checked(unchecked((uint)num2 / (uint)(int)Cq8.Default) - unchecked((uint)num2) + unchecked((uint)(int)Cq8.Default)));
		try
		{
			_ = (d5W)(object)Cq8.Default;
		}
		catch
		{
			gj = gj;
			gj = gj;
		}
		while (obj4 != null)
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (d2N)Aj8.Cm3(array, array, num2);
				}
				catch
				{
					_ = (z3X)(object)Aj8.Cm3(array, array, num2);
				}
			}
		}
		_ = (n9L)(object)Cq8.Default;
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Kz1 kz);
		if (num / num == 0)
		{
			if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
			{
				lw = null;
				_ = (Lw6)(object)Aj8.Cm3(Aj8.Cm3(null, null, (int)Cq8.Default), Aj8.Cm3((byte[])(object)Cq8.Default, null, 1017996783), (int)checked(3852376468u - unchecked((uint)num2) - unchecked(3168050374u / (uint)(int)Cq8.Default) - unchecked((uint)(int)Cq8.Default)));
				_ = (Kj1)Aj8.Cm3((byte[])(object)Cq8.Default, array, 1291229797);
				_ = (Wj3)(object)Cq8.Default;
			}
			else
			{
				kz = kz;
			}
		}
		num = default(UIntPtr);
		if (num == 0)
		{
			try
			{
				_ = (d5W)(object)Cq8.Default;
			}
			catch
			{
				_ = (n9L)(object)Aj8.Cm3(array, array, (int)Cq8.Default);
			}
			finally
			{
				_ = (n9L)(object)Aj8.Cm3(Aj8.Cm3(array, array, (int)checked(2808062149u * 1137945465u)), array, (int)Cq8.Default);
				goto IL_07d6;
			}
		}
		goto IL_07d6;
		IL_0aa4:
		y6Z = y6Z;
		_ = (Kz1)(object)Aj8.Cm3(array, array, 1421636877);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		try
		{
			if ((UIntPtr)Cq8.Default != (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Gj7)(object)Aj8.Cm3((byte[])(object)Cq8.Default, array, num2);
				}
				finally
				{
					y6Z = y6Z;
					goto end_IL_0ac4;
				}
			}
			num = default(UIntPtr);
			if (num == 0)
			{
				_003CModule_003E = (_003CModule_003E)(object)Cq8.Default;
			}
			else
			{
				kz = kz;
			}
			end_IL_0ac4:;
		}
		catch
		{
			if ((UIntPtr)Cq8.Default != (UIntPtr)(nuint)0u)
			{
				try
				{
					cq = cq;
				}
				finally
				{
					cq = cq;
					goto end_IL_0b26;
				}
			}
			_ = (d2N)Cq8.Default;
			end_IL_0b26:;
		}
		_ = (y6Z)(object)Aj8.Cm3(array, null, num2);
		_ = (Aj8)(object)Cq8.Default;
		while (obj4 != null)
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				try
				{
					_ = (_003CModule_003E)(object)Aj8.Cm3(array, array, num2);
				}
				catch
				{
					_ = (Cq8)(object)Aj8.Cm3(null, array, -439299273);
				}
			}
		}
		while (obj4 != null)
		{
			nuint num4 = num;
			num = default(UIntPtr);
			if (checked(num4 - (num - num)) / num == 0)
			{
				try
				{
					_ = (c2M)(object)Aj8.Cm3(Aj8.Cm3(array, array, num2), null, num2);
				}
				catch
				{
					cq = cq;
					d5W = null;
					_ = Cq8.Default;
				}
			}
		}
		if (num == 0)
		{
			_ = (Kz1)(object)Aj8.Cm3(null, array, num2);
		}
		cq = cq;
		while (true)
		{
			if ((object)Aj8.Cm3(null, array, (int)checked(2227592941u + unchecked((uint)num2) - 3840714843u)) != null)
			{
				while (obj4 != null)
				{
					n9L = n9L;
					lw = null;
				}
			}
			else if ((object)Aj8.Cm3(array, array, (int)Cq8.Default) == null)
			{
				break;
			}
		}
		_ = (z3X)(object)Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)Aj8.Cm3(array, array, num2));
		if ((UIntPtr)Aj8.Cm3((byte[])(object)Cq8.Default, array, (int)Cq8.Default) == (UIntPtr)(nuint)0u)
		{
			while (obj4 != null)
			{
				if ((UIntPtr)Aj8.Cm3(array, array, -1412953413) == (UIntPtr)(nuint)0u)
				{
					_ = (_003CModule_003E)(object)Aj8.Cm3(array, array, (int)Cq8.Default);
				}
				else
				{
					_ = (Tr3)(object)Cq8.Default;
				}
			}
		}
		_ = (Aj8)(object)Cq8.Default;
		num = default(UIntPtr);
		if (checked(unchecked((nuint)default(UIntPtr)) + num) == 0)
		{
			while (obj4 != null)
			{
				if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
				{
					d5W = d5W;
				}
				else
				{
					lw = lw;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y0D y0D);
		try
		{
			try
			{
				while (obj4 != null)
				{
					y0D = y0D;
					y0D = y0D;
				}
			}
			finally
			{
				while (obj4 != null)
				{
					_ = (n9L)(object)Aj8.Cm3(null, array, (int)Aj8.Cm3(array, array, (int)checked(unchecked((uint)(int)Cq8.Default) + (unchecked((uint)num2) - unchecked((uint)(int)Aj8.Cm3(array, null, num2))))));
				}
				goto end_IL_0d92;
			}
			end_IL_0d92:;
		}
		catch
		{
			try
			{
				try
				{
					_ = (c2M)(object)Aj8.Cm3((byte[])(object)Cq8.Default, array, num2);
				}
				finally
				{
					Tr3 tr = (Tr3)(object)Aj8.Cm3(array, Aj8.Cm3(array, null, 22920793), -2074475267);
					goto end_IL_0e01;
				}
				end_IL_0e01:;
			}
			finally
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					aj = (Aj8)(object)Aj8.Cm3(null, array, num2);
				}
				goto end_IL_0e00;
			}
			end_IL_0e00:;
		}
		Kj1 obj17 = (Kj1)Cq8.Default;
		Kj1 kj = kj;
		kj = obj17;
		if (checked(num + num) == 0)
		{
			num = default(UIntPtr);
			if (unchecked((nuint)default(UIntPtr)) / checked(unchecked((nuint)default(UIntPtr)) + num - (unchecked((nuint)(UIntPtr)Cq8.Default) + num)) == 0)
			{
				_ = (Tr3)(object)Aj8.Cm3(array, array, (int)Cq8.Default);
			}
		}
		else
		{
			_ = Cq8.Default;
		}
		num = default(UIntPtr);
		if (num == 0)
		{
			try
			{
				d2N = (d2N)Aj8.Cm3((byte[])(object)Cq8.Default, array, num2);
			}
			catch
			{
				y0D = null;
			}
		}
		try
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				try
				{
					_003CModule_003E = _003CModule_003E;
				}
				finally
				{
					_ = (d5W)(object)Cq8.Default;
					_ = (Gj7)(object)Aj8.Cm3((byte[])(object)Cq8.Default, array, (int)Aj8.Cm3(array, array, num2));
					goto end_IL_0f3f;
				}
			}
			try
			{
				_ = (Kz1)(object)Cq8.Default;
			}
			catch
			{
				_ = (Kj1)Aj8.Cm3(null, array, (int)((uint)num2 / (uint)(int)Aj8.Cm3(array, Aj8.Cm3(array, array, num2), 1668291238)));
			}
			end_IL_0f3f:;
		}
		catch
		{
			if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u && (UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
			{
				kj = kj;
				_ = (Tr3)(object)Cq8.Default;
				_ = (Gj7)(object)Cq8.Default;
				y0D = y0D;
			}
		}
		if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
		{
			while ((object)Cq8.Default != null)
			{
				try
				{
					_ = (Aj8)(object)Aj8.Cm3(null, (byte[])(object)Cq8.Default, num2);
				}
				catch
				{
					y0D = (y0D)(object)Cq8.Default;
				}
			}
		}
		_ = (Kz1)(object)Aj8.Cm3(array, Aj8.Cm3(null, array, num2), num2);
		n9L = null;
		while (obj4 != null)
		{
			while ((object)Cq8.Default != null)
			{
				_003CModule_003E = (_003CModule_003E)(object)Aj8.Cm3(array, array, (int)checked(unchecked((uint)num2) + 2716325817u));
				y0D = y0D;
				_ = (y0D)(object)Aj8.Cm3(Aj8.Cm3(array, null, (int)checked(4158082360u - unchecked((uint)num2) + unchecked((uint)(int)Cq8.Default) + unchecked((uint)(int)Aj8.Cm3(array, array, (int)Cq8.Default)))), array, (int)Aj8.Cm3(null, array, num2));
			}
		}
		while (true)
		{
			if (obj4 != null)
			{
				UIntPtr num5 = (UIntPtr)Cq8.Default;
				num = default(UIntPtr);
				checked
				{
					if (unchecked((nuint)num5) + num == 0)
					{
						_003CModule_003E = _003CModule_003E;
						n9L = n9L;
						_ = (d2N)Cq8.Default;
					}
				}
			}
			else if (obj4 == null)
			{
				break;
			}
		}
		_ = (c2M)(object)Aj8.Cm3((byte[])(object)Cq8.Default, array, -2135507473);
		_ = (Aj8)(object)Aj8.Cm3(array, array, -840683785);
		_ = (Wj3)(object)Cq8.Default;
		_ = (Lw6)(object)Aj8.Cm3(array, null, 757583717);
		if (num == 0)
		{
			try
			{
				while (obj4 != null)
				{
					aj = aj;
				}
			}
			finally
			{
				if (num == 0)
				{
					_ = (c2M)(object)Cq8.Default;
				}
				goto IL_120c;
			}
		}
		goto IL_120c;
		IL_07d6:
		if (num == 0)
		{
			try
			{
				do
				{
					_ = (Kz1)(object)Aj8.Cm3(Aj8.Cm3(array, null, -1970472858), array, num2);
				}
				while ((object)Aj8.Cm3(array, array, (int)checked(unchecked((uint)num2) + unchecked((uint)num2))) != null);
			}
			catch
			{
				_ = (Wj3)(object)Aj8.Cm3(null, array, (int)checked(unchecked((uint)(int)Cq8.Default) + unchecked((uint)num2)));
			}
		}
		_ = (y6Z)(object)Aj8.Cm3(array, array, -2031090302);
		if (num == 0)
		{
			do
			{
				try
				{
					_ = (Kz1)(object)Aj8.Cm3(array, array, (int)Cq8.Default);
				}
				catch
				{
					d5W = null;
				}
			}
			while (obj4 != null);
		}
		while (true)
		{
			if ((object)Cq8.Default != null)
			{
				_ = (Lw6)(object)Cq8.Default;
			}
			else if (obj4 == null && (object)Aj8.Cm3(array, null, 2040833224) == null)
			{
				break;
			}
		}
		if ((UIntPtr)Aj8.Cm3(null, null, 756366512) == (UIntPtr)(nuint)0u)
		{
			kz = null;
		}
		try
		{
			_ = (Kz1)(object)Cq8.Default;
		}
		catch
		{
			if (checked(unchecked((nuint)(UIntPtr)Aj8.Cm3((byte[])(object)Cq8.Default, Aj8.Cm3(array, array, (int)checked(unchecked((uint)num2) - unchecked((uint)(int)Cq8.Default))), -1481516183)) * unchecked((nuint)(UIntPtr)Cq8.Default) * (unchecked((nuint)(UIntPtr)Aj8.Cm3(null, array, (int)checked(4226806369u * unchecked((uint)num2)))) - unchecked((nuint)(UIntPtr)Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)Aj8.Cm3(Aj8.Cm3(array, array, (int)Aj8.Cm3(array, array, (int)Aj8.Cm3(array, array, -465782160))), null, -1719218599))))) / ((nuint)(UIntPtr)Aj8.Cm3((byte[])(object)Cq8.Default, array, (int)Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)Aj8.Cm3(Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)Cq8.Default), (byte[])(object)Cq8.Default, (int)Cq8.Default))) / num) == 0)
			{
				_ = (d5W)(object)Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)checked(unchecked((uint)(int)Cq8.Default) * unchecked((uint)(int)Cq8.Default) * unchecked((uint)(int)Aj8.Cm3(null, null, 1749477827))));
			}
			else
			{
				_ = (n9L)(object)Aj8.Cm3(null, array, num2);
			}
		}
		finally
		{
			if (num == 0)
			{
				try
				{
					n9L = n9L;
				}
				catch
				{
					Tr3 tr = null;
				}
			}
			goto IL_0aa4;
		}
		IL_037b:
		if ((UIntPtr)Aj8.Cm3(null, Aj8.Cm3(null, array, num2), 458693522) == (UIntPtr)(nuint)0u)
		{
			if ((nuint)(UIntPtr)Cq8.Default / num == 0)
			{
				_ = (_003CModule_003E)(object)Aj8.Cm3(null, Aj8.Cm3(Aj8.Cm3(null, (byte[])(object)Cq8.Default, (int)Aj8.Cm3(array, null, 1680602698)), array, (int)checked(unchecked((uint)num2) * 1857518523u + unchecked((uint)(int)Cq8.Default))), (int)Cq8.Default);
			}
			else
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					d2N = d2N;
					_ = (Gj7)(object)Cq8.Default;
					c2M c2M = (c2M)(object)Aj8.Cm3((byte[])(object)Cq8.Default, null, num2);
					Tr3 tr = null;
				}
				else
				{
					_003CModule_003E obj26 = (_003CModule_003E)(object)Aj8.Cm3(array, Aj8.Cm3((byte[])(object)Cq8.Default, array, (int)checked(unchecked((uint)(int)Aj8.Cm3(null, array, num2)) * unchecked((uint)num2))), -1639262479);
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = obj26;
				}
			}
		}
		if (num == 0)
		{
			d2N = d2N;
		}
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			try
			{
				while ((object)Aj8.Cm3(Aj8.Cm3(null, array, (int)Cq8.Default), (byte[])(object)Cq8.Default, -994174714) != null)
				{
					_ = (Gj7)(object)Cq8.Default;
				}
			}
			catch
			{
				n9L = n9L;
				z3X = null;
			}
		}
		try
		{
			_ = (z3X)(object)Cq8.Default;
		}
		finally
		{
			kz = kz;
			kz = kz;
			goto IL_0549;
		}
	}

	static void Kb6()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Kj1 kj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Tr3 tr);
		while (true)
		{
			obj = obj;
			if (obj != null)
			{
				try
				{
					tr = tr;
					tr = null;
				}
				finally
				{
					kj = default(Kj1);
					kj = default(Kj1);
					continue;
				}
			}
			break;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d2N d2N);
		while (obj != null)
		{
			d2N obj2 = (d2N)Cq8.Default;
			d2N = (d2N)Cq8.Default;
			d2N = obj2;
		}
		Cq8 cq = cq;
		cq = cq;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		checked
		{
			num = unchecked((nuint)(UIntPtr)Cq8.Default) * (num + unchecked((nuint)(UIntPtr)Cq8.Default));
			if (num == 0)
			{
				kj = kj;
			}
			array = array;
			byte[] nx = array;
			byte[] nx2 = array;
			byte[] ko = array;
			num2 = num2;
			if (unchecked((nuint)(UIntPtr)Aj8.Cm3(null, Aj8.Cm3(nx, null, (int)Aj8.Cm3(nx2, ko, (int)(3942008732u / checked(unchecked((uint)num2 / checked((unchecked((uint)(int)Cq8.Default) * unchecked((uint)(int)Cq8.Default) - unchecked((uint)num2)) * 3636931443u)) + unchecked((uint)(int)Cq8.Default / (uint)num2))))), (int)Cq8.Default)) + unchecked((nuint)(UIntPtr)Aj8.Cm3(array, null, -663523011)) + num + unchecked((nuint)default(UIntPtr)) + unchecked((nuint)default(UIntPtr)) == 0)
			{
				c2M c2M = c2M;
				c2M = c2M;
			}
			else
			{
				while (obj != null)
				{
				}
			}
		}
		_ = (Kj1)Aj8.Cm3((byte[])(object)Cq8.Default, array, (int)Aj8.Cm3(array, array, num2));
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Wj3 wj);
		if (checked(num - unchecked((nuint)(UIntPtr)Cq8.Default / num)) == 0)
		{
			try
			{
				Wj3 obj3 = (Wj3)(object)Aj8.Cm3(array, Aj8.Cm3(Aj8.Cm3(array, array, num2), (byte[])(object)Cq8.Default, (int)Cq8.Default), (int)Aj8.Cm3(null, null, num2));
				wj = (Wj3)(object)Cq8.Default;
				wj = obj3;
			}
			catch
			{
				do
				{
					_ = (n9L)(object)Aj8.Cm3(array, Aj8.Cm3(array, Aj8.Cm3(array, (byte[])(object)Cq8.Default, 329312362), (int)Cq8.Default), num2);
				}
				while (obj != null);
			}
		}
		else
		{
			_ = Cq8.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z3X z3X);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		if ((UIntPtr)Aj8.Cm3(array, array, (int)((uint)num2 / checked(unchecked((uint)num2) - 3952072630u))) == (UIntPtr)(nuint)0u)
		{
			_ = (c2M)(object)Aj8.Cm3(array, null, (int)((uint)(int)Cq8.Default / ((uint)num2 / checked(unchecked((uint)num2) + 3762691366u))));
		}
		else
		{
			while ((object)Cq8.Default != null)
			{
				try
				{
					_ = (n9L)(object)Cq8.Default;
					z3X obj5 = (z3X)(object)Aj8.Cm3(Aj8.Cm3(array, array, (int)Cq8.Default), null, (int)checked(unchecked((uint)num2) * unchecked((uint)(int)Aj8.Cm3(array, array, (int)checked(unchecked((uint)num2) * unchecked((uint)(int)Cq8.Default)))) + 0u));
					z3X = z3X;
					z3X = obj5;
				}
				catch
				{
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = _003CModule_003E;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y0D y0D);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n9L n9L);
		while (obj != null)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (Kz1)(object)Aj8.Cm3(array, (byte[])(object)Cq8.Default, -377449846);
			}
			else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				y0D = (y0D)(object)Aj8.Cm3(null, array, (int)Aj8.Cm3(null, array, num2));
				y0D = y0D;
			}
			else
			{
				n9L obj7 = (n9L)(object)Cq8.Default;
				n9L = n9L;
				n9L = obj7;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Lw6 lw);
		try
		{
			do
			{
				try
				{
					_ = (Kj1)Aj8.Cm3(null, Aj8.Cm3(Aj8.Cm3(null, array, -888939776), null, num2), (int)Cq8.Default);
				}
				finally
				{
					_ = (Kz1)(object)Aj8.Cm3(array, array, (int)checked(3506313589u * 2715236485u));
					y0D = y0D;
					lw = lw;
					lw = null;
					continue;
				}
			}
			while (obj != null);
		}
		finally
		{
			kj = kj;
			goto IL_04a7;
		}
		IL_0a5c:
		while (obj != null)
		{
			do
			{
				kj = default(Kj1);
				wj = wj;
				d2N = d2N;
			}
			while (obj != null || (object)Aj8.Cm3(null, array, num2) != null);
		}
		_ = (Tr3)(object)Aj8.Cm3(null, array, (int)Aj8.Cm3(array, null, (int)Cq8.Default));
		do
		{
			if ((UIntPtr)Aj8.Cm3(null, null, num2) == (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = (Kz1)(object)Cq8.Default;
				}
				while (obj != null);
			}
		}
		while (obj != null);
		_003CModule_003E = _003CModule_003E;
		_ = (Aj8)(object)Cq8.Default;
		try
		{
			do
			{
				_ = (Tr3)(object)Aj8.Cm3(null, (byte[])(object)Cq8.Default, num2);
			}
			while (obj != null);
		}
		catch
		{
			z3X = z3X;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Kz1 kz);
		try
		{
			do
			{
				kz = kz;
				_ = (Wj3)(object)Aj8.Cm3((byte[])(object)Cq8.Default, null, -967755466);
				_ = (c2M)(object)Aj8.Cm3((byte[])(object)Cq8.Default, (byte[])(object)Cq8.Default, num2);
			}
			while (obj != null || (object)Aj8.Cm3((byte[])(object)Cq8.Default, null, (int)Aj8.Cm3(array, array, (int)checked(unchecked((uint)num2) - 1547810558u))) != null);
		}
		finally
		{
			while ((object)Cq8.Default != null)
			{
				try
				{
					kj = default(Kj1);
					kj = kj;
				}
				catch
				{
					z3X = z3X;
				}
			}
			goto IL_0bb8;
		}
		IL_0cf8:
		if (num == 0)
		{
			_ = (d2N)Aj8.Cm3(array, array, num2);
		}
		else
		{
			_ = (n9L)(object)Cq8.Default;
		}
		lw = lw;
		_ = (Aj8)(object)Cq8.Default;
		Gj7 gj = gj;
		_003CModule_003E = (_003CModule_003E)(object)Aj8.Cm3(array, array, -1823917751);
		Aj8 aj = aj;
		if (checked(num + unchecked((nuint)default(UIntPtr))) == 0)
		{
			try
			{
				cq = cq;
				n9L = n9L;
			}
			catch
			{
				do
				{
					_ = (c2M)(object)Cq8.Default;
				}
				while (obj != null);
			}
		}
		else
		{
			try
			{
				while ((object)Aj8.Cm3(null, array, num2) != null)
				{
					_ = (c2M)(object)Aj8.Cm3(array, null, (int)((uint)(int)Cq8.Default / checked(unchecked((uint)(int)Cq8.Default) - unchecked((uint)num2))));
				}
			}
			catch
			{
				_ = (Kz1)(object)Cq8.Default;
				_ = (Kj1)Aj8.Cm3(array, (byte[])(object)Cq8.Default, -2113922308);
			}
		}
		while ((object)Cq8.Default != null)
		{
			if ((UIntPtr)Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)checked(unchecked((uint)(int)Aj8.Cm3(array, array, num2)) - 934215529u)) == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
				{
					wj = wj;
				}
				else
				{
					_ = (_003CModule_003E)(object)Cq8.Default;
				}
			}
		}
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d5W d5W);
		if (num == 0)
		{
			try
			{
				d5W obj12 = (d5W)(object)Cq8.Default;
				d5W = d5W;
				d5W = obj12;
				aj = aj;
				_003CModule_003E = null;
			}
			finally
			{
				kj = kj;
				goto IL_0ee2;
			}
		}
		try
		{
			_ = (Kj1)Cq8.Default;
		}
		finally
		{
			try
			{
				_ = (Aj8)(object)Cq8.Default;
			}
			finally
			{
				_ = (y6Z)(object)Cq8.Default;
				goto IL_0ee2;
			}
		}
		IL_0bb8:
		try
		{
			while ((object)Cq8.Default != null)
			{
				kj = default(Kj1);
				kj = kj;
			}
		}
		finally
		{
			if ((UIntPtr)Aj8.Cm3(Aj8.Cm3(null, array, 1975797111), Aj8.Cm3((byte[])(object)Cq8.Default, null, (int)Cq8.Default), (int)Cq8.Default) == (UIntPtr)(nuint)0u)
			{
				if (num == 0)
				{
					wj = wj;
					z3X = z3X;
					lw = (Lw6)(object)Aj8.Cm3(Aj8.Cm3(Aj8.Cm3(null, Aj8.Cm3(null, array, 242182131), (int)checked(unchecked((uint)num2) + unchecked((uint)num2) - (unchecked((uint)num2) * (unchecked((uint)(int)Aj8.Cm3(Aj8.Cm3(array, array, num2), array, (int)Aj8.Cm3(array, array, (int)Cq8.Default))) * unchecked((uint)(int)Cq8.Default)) - 2537129156u))), array, num2), null, 1345890614);
				}
				else
				{
					_ = (n9L)(object)Cq8.Default;
				}
			}
			goto IL_0cf8;
		}
		IL_0f3d:
		if (num == 0)
		{
			if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
			{
				gj = gj;
			}
			else
			{
				while (obj != null)
				{
					_ = (z3X)(object)Cq8.Default;
				}
			}
		}
		if ((UIntPtr)Aj8.Cm3(array, array, num2) == (UIntPtr)(nuint)0u)
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				d2N = default(d2N);
			}
			else
			{
				UIntPtr num3 = (UIntPtr)Aj8.Cm3((byte[])(object)Cq8.Default, null, 1146412659);
				num = default(UIntPtr);
				checked
				{
					if (unchecked((nuint)num3) * num == 0)
					{
						d2N = d2N;
						n9L = (n9L)(object)Aj8.Cm3(null, array, -95413866);
						_003CModule_003E = (_003CModule_003E)(object)Cq8.Default;
						aj = null;
					}
					else
					{
						_ = (Wj3)(object)Aj8.Cm3(array, array, 922287805);
					}
				}
			}
		}
		try
		{
			try
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					gj = gj;
				}
			}
			finally
			{
				do
				{
					_ = (Kz1)(object)Aj8.Cm3(array, null, (int)Aj8.Cm3((byte[])(object)Cq8.Default, array, 1889900850));
					d2N = default(d2N);
					d2N = d2N;
				}
				while (obj != null);
				goto end_IL_1022;
			}
			end_IL_1022:;
		}
		catch
		{
			_ = (_003CModule_003E)(object)Cq8.Default;
		}
		try
		{
			if (num == 0)
			{
				try
				{
					_ = (Wj3)(object)Cq8.Default;
				}
				catch
				{
					_ = (y6Z)(object)Aj8.Cm3(array, array, -1284891242);
				}
			}
		}
		catch
		{
			try
			{
				if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Wj3)(object)Aj8.Cm3(null, null, (int)Cq8.Default);
				}
				else
				{
					_ = (z3X)(object)Aj8.Cm3(array, null, num2);
				}
			}
			finally
			{
				do
				{
					_ = (z3X)(object)Cq8.Default;
				}
				while (obj != null);
				goto end_IL_10c6;
			}
			end_IL_10c6:;
		}
		try
		{
			_ = (d2N)Aj8.Cm3(array, array, -1985175470);
			_ = (Tr3)(object)Aj8.Cm3(array, array, (int)Cq8.Default);
		}
		catch
		{
			if (num == 0)
			{
				try
				{
					wj = (Wj3)(object)Aj8.Cm3(null, array, -471490395);
				}
				finally
				{
					kj = default(Kj1);
					goto end_IL_1150;
				}
			}
			end_IL_1150:;
		}
		try
		{
			if (num == 0)
			{
				nuint num4 = num;
				num = default(UIntPtr);
				if (num4 / num == 0)
				{
					tr = (Tr3)(object)Cq8.Default;
					_ = (Aj8)(object)Cq8.Default;
					_ = (n9L)(object)Aj8.Cm3(array, array, 315257652);
				}
			}
			else
			{
				_ = (n9L)(object)Aj8.Cm3(null, null, (int)Aj8.Cm3((byte[])(object)Cq8.Default, array, (int)Cq8.Default));
				d5W = d5W;
				_ = (Tr3)(object)Cq8.Default;
			}
		}
		catch
		{
			_ = (n9L)(object)Aj8.Cm3(array, array, (int)(checked(unchecked((uint)num2) - unchecked((uint)num2)) / checked(unchecked((uint)(int)Cq8.Default) - unchecked(checked(unchecked((uint)(int)Cq8.Default) * (442865706u * unchecked((uint)num2))) / 2440744787u))));
		}
		do
		{
			try
			{
				try
				{
					_ = (y6Z)(object)Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)Cq8.Default);
					_ = (_003CModule_003E)(object)Aj8.Cm3(array, Aj8.Cm3(array, array, 1229237545), -937375195);
				}
				catch
				{
					kj = (Kj1)Cq8.Default;
				}
			}
			catch
			{
				try
				{
					_ = (Aj8)(object)Aj8.Cm3(null, array, num2);
				}
				catch
				{
					_ = (d2N)Cq8.Default;
				}
			}
		}
		while (obj != null);
		try
		{
			num = default(UIntPtr);
			nuint num5 = num;
			num = default(UIntPtr);
			if (num5 / num == 0)
			{
				_ = (Cq8)(object)Aj8.Cm3(array, null, (int)checked(unchecked((uint)num2) + 3438339017u));
				aj = (Aj8)(object)Aj8.Cm3(array, array, 892415915);
				y6Z y6Z = null;
			}
		}
		catch
		{
			if (checked(num - unchecked((nuint)(UIntPtr)Cq8.Default)) == 0)
			{
				while (obj != null)
				{
					_ = (_003CModule_003E)(object)Cq8.Default;
					_ = (Tr3)(object)Cq8.Default;
					lw = null;
					_ = (y6Z)(object)Aj8.Cm3(array, array, (int)checked(487681928u * unchecked((uint)(int)Aj8.Cm3(array, array, 1751949761) / (uint)num2)));
				}
			}
		}
		try
		{
			try
			{
				_ = (c2M)(object)Cq8.Default;
			}
			catch
			{
				c2M c2M = (c2M)(object)Aj8.Cm3(array, array, (int)(checked(2617359536u * unchecked((uint)(int)Aj8.Cm3(array, null, (int)((uint)(int)Cq8.Default / 612167389u)))) / 4001461085u));
			}
		}
		catch
		{
			try
			{
				d2N = d2N;
			}
			catch
			{
				y6Z y6Z = null;
				_ = (z3X)(object)Aj8.Cm3(null, array, num2);
			}
		}
		finally
		{
			try
			{
				_ = (Tr3)(object)Cq8.Default;
				y0D = (y0D)(object)Aj8.Cm3((byte[])(object)Cq8.Default, (byte[])(object)Cq8.Default, 336284643);
				y6Z y6Z = (y6Z)(object)Cq8.Default;
				z3X = (z3X)(object)Aj8.Cm3(array, null, (int)Cq8.Default);
			}
			finally
			{
				tr = tr;
				goto IL_14b1;
			}
		}
		IL_09b3:
		try
		{
			num = default(UIntPtr);
			if (num != 0)
			{
				try
				{
					aj = aj;
				}
				finally
				{
					n9L = n9L;
					goto end_IL_09b4;
				}
			}
			if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
			{
				cq = cq;
			}
			else
			{
				n9L = null;
			}
			end_IL_09b4:;
		}
		finally
		{
			do
			{
				try
				{
					_ = (Gj7)(object)Cq8.Default;
				}
				catch
				{
					_ = (d2N)Cq8.Default;
				}
			}
			while (obj != null);
			goto IL_0a5c;
		}
		IL_04a7:
		do
		{
			if (default(UIntPtr) != (UIntPtr)(nuint)0u)
			{
				_ = (Lw6)(object)Cq8.Default;
			}
			else
			{
				_ = (Tr3)(object)Cq8.Default;
			}
		}
		while (obj != null);
		try
		{
			if ((UIntPtr)Aj8.Cm3(null, array, -1219105051) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Gj7)(object)Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)checked(unchecked((uint)(int)Cq8.Default) + unchecked((uint)(int)Cq8.Default) * unchecked((uint)num2) * unchecked((uint)(int)Cq8.Default)));
				}
				finally
				{
					cq = null;
					goto end_IL_04b9;
				}
			}
			y0D = (y0D)(object)Cq8.Default;
			end_IL_04b9:;
		}
		catch
		{
			if (checked(unchecked((nuint)(UIntPtr)Aj8.Cm3(array, Aj8.Cm3(array, array, (int)Aj8.Cm3(array, array, (int)checked(unchecked((uint)num2) + 3271371251u))), (int)Cq8.Default)) + unchecked((nuint)(UIntPtr)Cq8.Default)) == 0)
			{
				while (obj != null)
				{
					_ = (Aj8)(object)Cq8.Default;
					n9L = null;
					lw = null;
					d2N = d2N;
				}
			}
			else
			{
				try
				{
					Gj7 obj26 = (Gj7)(object)Aj8.Cm3((byte[])(object)Cq8.Default, array, num2);
					gj = null;
					gj = obj26;
				}
				catch
				{
					_ = (d5W)(object)Aj8.Cm3(Aj8.Cm3(null, (byte[])(object)Cq8.Default, num2), null, (int)Cq8.Default);
				}
			}
		}
		num = default(UIntPtr);
		if (num == 0)
		{
			if ((UIntPtr)Aj8.Cm3(array, null, (int)checked(unchecked((uint)(int)Cq8.Default / (uint)(int)Aj8.Cm3(array, array, (int)checked(97711571u * 947834551u))) * (unchecked((uint)(int)Cq8.Default) * unchecked(checked(unchecked((uint)num2) * unchecked((uint)(int)Aj8.Cm3(array, array, (int)checked(1318408967u + unchecked((uint)num2 / (uint)num2) + unchecked((uint)(int)Aj8.Cm3(array, null, -436259467)))))) / 0u) - unchecked((uint)(int)Aj8.Cm3(null, null, 2094406652))))) == (UIntPtr)(nuint)0u)
			{
				while ((object)Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)Cq8.Default) != null)
				{
					n9L = n9L;
				}
			}
			else
			{
				_ = (y6Z)(object)Cq8.Default;
			}
		}
		_ = Cq8.Default;
		try
		{
			try
			{
				_ = (Aj8)(object)Cq8.Default;
			}
			catch
			{
				if (num == 0)
				{
					kz = (Kz1)(object)Cq8.Default;
					kz = null;
				}
			}
		}
		catch
		{
			num = default(UIntPtr);
			if (checked(unchecked((nuint)default(UIntPtr)) + unchecked((nuint)default(UIntPtr)) * num == 0 && unchecked((nuint)(UIntPtr)Cq8.Default) + num == 0))
			{
				_ = (Aj8)(object)Aj8.Cm3(null, null, (int)checked(1791104104u + unchecked((uint)(int)Aj8.Cm3(array, array, -242227597))));
			}
		}
		try
		{
			kz = kz;
			_ = (Wj3)(object)Aj8.Cm3(array, array, (int)Aj8.Cm3(Aj8.Cm3(array, array, (int)checked(unchecked((uint)(int)Aj8.Cm3(array, array, num2)) - 2495099647u)), Aj8.Cm3(array, array, 2137986105), 1099804682));
			_ = (Wj3)(object)Aj8.Cm3(array, array, -1364834239);
			wj = (Wj3)(object)Cq8.Default;
		}
		catch
		{
			try
			{
				try
				{
					z3X = z3X;
				}
				catch
				{
					_ = (Gj7)(object)Cq8.Default;
					aj = null;
					aj = null;
				}
			}
			catch
			{
				y0D = null;
			}
		}
		try
		{
			do
			{
				num = default(UIntPtr);
				if (num != 0)
				{
					_003CModule_003E = _003CModule_003E;
					_ = (Kz1)(object)Aj8.Cm3(array, Aj8.Cm3((byte[])(object)Cq8.Default, array, (int)checked(unchecked((uint)(int)Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)(1389190744u / (uint)(int)Cq8.Default))) - unchecked((uint)num2) * 3837342755u + unchecked((uint)(int)Cq8.Default))), -1574890327);
				}
				else
				{
					_ = (Aj8)(object)Aj8.Cm3(Aj8.Cm3(Aj8.Cm3(array, Aj8.Cm3(array, array, 1701534988), -2138204593), (byte[])(object)Cq8.Default, (int)checked(unchecked((uint)num2) + 2802601992u)), null, 1359343451);
				}
			}
			while (obj != null);
		}
		finally
		{
			try
			{
				try
				{
					_ = (Cq8)(object)Aj8.Cm3(null, null, -1751486967);
				}
				finally
				{
					_ = (Aj8)(object)Aj8.Cm3(null, array, (int)checked(635221785u - 2859514574u));
					goto end_IL_093f;
				}
				end_IL_093f:;
			}
			catch
			{
				try
				{
					y6Z y6Z = y6Z;
					y6Z = y6Z;
				}
				catch
				{
					tr = (Tr3)(object)Aj8.Cm3(array, array, -1415138098);
					_ = (y0D)(object)Cq8.Default;
				}
			}
			goto IL_09b3;
		}
		IL_0ee2:
		try
		{
			do
			{
				try
				{
					lw = null;
				}
				catch
				{
					kj = kj;
				}
			}
			while (obj != null);
		}
		finally
		{
			if ((UIntPtr)Aj8.Cm3(array, array, -283604046) == (UIntPtr)(nuint)0u)
			{
				_ = (Gj7)(object)Aj8.Cm3((byte[])(object)Cq8.Default, array, (int)Cq8.Default);
			}
			goto IL_0f3d;
		}
		IL_14b1:
		cq = cq;
		try
		{
			_ = (Wj3)(object)Cq8.Default;
		}
		finally
		{
			d5W = null;
			goto IL_14cd;
		}
		IL_14cd:
		cq = null;
		_003CModule_003E = _003CModule_003E;
		if (num == 0)
		{
			try
			{
				if (num == 0)
				{
					_ = Cq8.Default;
				}
			}
			catch
			{
				try
				{
					_ = (y6Z)(object)Cq8.Default;
				}
				finally
				{
					n9L = n9L;
					goto end_IL_14f3;
				}
				end_IL_14f3:;
			}
		}
		else
		{
			try
			{
				d2N = d2N;
			}
			catch
			{
				do
				{
					d2N = default(d2N);
				}
				while (obj != null);
			}
		}
		try
		{
			kz = kz;
		}
		catch
		{
			aj = aj;
			gj = gj;
		}
		_ = (Kz1)(object)Aj8.Cm3(null, array, -170191564);
	}

	static void q0P()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Lw6 lw);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Kz1 kz);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		try
		{
			checked
			{
				num -= unchecked((nuint)(UIntPtr)Cq8.Default);
				if (num == 0)
				{
					_ = (Tr3)(object)Cq8.Default;
				}
				obj = null;
			}
		}
		finally
		{
			try
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					kz = kz;
					kz = null;
				}
			}
			catch
			{
				try
				{
					array = null;
					_ = (y6Z)(object)Aj8.Cm3(array, array, (int)Cq8.Default);
					_ = (_003CModule_003E)(object)Aj8.Cm3(array, null, -1574755472);
				}
				finally
				{
					lw = (Lw6)(object)Aj8.Cm3(null, array, 374216747);
					lw = lw;
					goto end_IL_004e;
				}
				end_IL_004e:;
			}
			goto IL_00ae;
		}
		IL_00ae:
		y6Z y6Z = (y6Z)(object)Cq8.Default;
		y6Z = y6Z;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d2N d2N);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y0D y0D);
		if (num == 0)
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				while ((object)Cq8.Default != null)
				{
					_ = (Lw6)(object)Cq8.Default;
					y0D = null;
					y0D = y0D;
					d2N = d2N;
					d2N = d2N;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Tr3 tr);
		while (obj != null)
		{
			while (true)
			{
				byte[] nx = array;
				byte[] ko = array;
				num2 = (int)Cq8.Default;
				if ((object)Aj8.Cm3(nx, ko, num2) == null)
				{
					break;
				}
				Tr3 obj3 = (Tr3)(object)Cq8.Default;
				tr = tr;
				tr = obj3;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c2M c2M);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cq8 cq);
		while (obj != null)
		{
			try
			{
				do
				{
					d2N = (d2N)Aj8.Cm3(Aj8.Cm3(array, null, (int)Cq8.Default), Aj8.Cm3(array, array, num2), (int)checked(unchecked((uint)num2) - 1724567915u));
				}
				while ((object)Cq8.Default != null);
			}
			finally
			{
				try
				{
					c2M = null;
					c2M = c2M;
					_ = (y0D)(object)Cq8.Default;
				}
				catch
				{
					d2N = default(d2N);
					Cq8 obj4 = Cq8.Default;
					cq = cq;
					cq = obj4;
					_ = (_003CModule_003E)(object)Aj8.Cm3(array, null, 1920703115);
				}
				continue;
			}
		}
		if (num == 0)
		{
			if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					y0D = null;
				}
				catch
				{
					_ = (y6Z)(object)Cq8.Default;
				}
			}
			else
			{
				Kj1 kj = kj;
				kj = kj;
			}
			goto IL_02c8;
		}
		try
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				_ = (Gj7)(object)Cq8.Default;
			}
		}
		finally
		{
			if (checked(num + unchecked((nuint)(UIntPtr)Cq8.Default)) == 0)
			{
				_ = (y0D)(object)Cq8.Default;
				_ = (_003CModule_003E)(object)Cq8.Default;
				_ = (n9L)(object)Aj8.Cm3((byte[])(object)Cq8.Default, (byte[])(object)Cq8.Default, (int)((uint)num2 / 235361272u));
			}
			goto IL_02c8;
		}
		IL_09e9:
		_ = (Gj7)(object)Cq8.Default;
		num = default(UIntPtr);
		if (num == 0)
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				while (obj != null)
				{
					_ = (Cq8)(object)Aj8.Cm3(Aj8.Cm3(array, null, (int)((uint)(int)Cq8.Default / 2462577956u)), Aj8.Cm3(array, null, 1094280412), (int)Cq8.Default);
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d5W d5W);
		if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
		{
			if ((nuint)(UIntPtr)Aj8.Cm3((byte[])(object)Cq8.Default, null, (int)checked(unchecked((uint)(int)Cq8.Default) * unchecked((uint)(int)Cq8.Default) + unchecked((uint)num2) * unchecked((uint)num2))) / (nuint)(UIntPtr)Cq8.Default == 0)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (c2M)(object)Cq8.Default;
					c2M = (c2M)(object)Cq8.Default;
					y6Z = y6Z;
				}
				else
				{
					c2M = null;
				}
			}
			else
			{
				d5W = d5W;
				d5W = null;
				_ = (_003CModule_003E)(object)Cq8.Default;
				_ = (y0D)(object)Cq8.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Wj3 wj);
		checked
		{
			try
			{
				try
				{
					do
					{
						_ = (Lw6)(object)Cq8.Default;
						d5W = d5W;
					}
					while ((object)Cq8.Default != null);
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
				do
				{
					if (num * (unchecked((nuint)(UIntPtr)Aj8.Cm3(array, null, num2)) * unchecked((nuint)(UIntPtr)Aj8.Cm3(array, array, 1201246332))) != 0)
					{
						_ = (n9L)(object)Aj8.Cm3(array, array, -1733350310);
					}
					else
					{
						d5W = (d5W)(object)Aj8.Cm3(null, array, num2);
					}
				}
				while (obj != null);
			}
			do
			{
				if (num != 0)
				{
					d2N = (d2N)Cq8.Default;
					continue;
				}
				do
				{
					wj = wj;
				}
				while (obj != null);
			}
			while (obj != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Aj8 aj);
		try
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				try
				{
					d5W = d5W;
					_ = (y0D)(object)Aj8.Cm3(Aj8.Cm3(array, null, (int)Aj8.Cm3(array, array, (int)Cq8.Default)), null, num2);
					aj = (Aj8)(object)Aj8.Cm3(array, array, (int)checked(1093383883u + unchecked((uint)num2)));
					aj = null;
				}
				finally
				{
					wj = wj;
					_ = Cq8.Default;
					goto end_IL_0be9;
				}
			}
			end_IL_0be9:;
		}
		finally
		{
			if (num == 0)
			{
				if (num == 0)
				{
					_ = (y6Z)(object)Aj8.Cm3(array, array, num2);
				}
				else
				{
					aj = aj;
					c2M = null;
					lw = lw;
					_ = (Kj1)Aj8.Cm3(Aj8.Cm3(array, array, num2), array, (int)checked(3208379589u * 552664401u));
				}
			}
			goto IL_0ce9;
		}
		IL_02c8:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z3X z3X);
		try
		{
		}
		finally
		{
			if (num == 0)
			{
				do
				{
					z3X = null;
					z3X = z3X;
				}
				while ((object)Aj8.Cm3(array, (byte[])(object)Cq8.Default, num2) != null);
			}
			goto IL_02fe;
		}
		IL_1170:
		_ = (n9L)(object)Aj8.Cm3(null, (byte[])(object)Cq8.Default, (int)Aj8.Cm3(array, null, (int)(checked(unchecked((uint)num2) + unchecked((uint)num2)) / (uint)num2)));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Gj7 gj);
		try
		{
			d5W = (d5W)(object)Cq8.Default;
		}
		catch
		{
			try
			{
				if ((UIntPtr)Aj8.Cm3(null, array, -954976387) == (UIntPtr)(nuint)0u)
				{
					_ = (Wj3)(object)Cq8.Default;
				}
			}
			catch
			{
				try
				{
					_ = (z3X)(object)Aj8.Cm3(null, Aj8.Cm3(null, null, (int)((uint)(int)Aj8.Cm3((byte[])(object)Cq8.Default, (byte[])(object)Cq8.Default, -1066933002) / 2262997370u)), 1886489661);
					gj = null;
					goto end_IL_11da;
				}
				catch
				{
					_ = (c2M)(object)Cq8.Default;
					goto end_IL_11da;
				}
				end_IL_11da:;
			}
		}
		_ = (d5W)(object)Aj8.Cm3((byte[])(object)Cq8.Default, array, (int)((uint)(int)Cq8.Default / 2028785679u / (uint)num2));
		_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)Aj8.Cm3(array, null, (int)Aj8.Cm3(array, null, (int)Aj8.Cm3((byte[])(object)Cq8.Default, Aj8.Cm3((byte[])(object)Cq8.Default, null, (int)Cq8.Default), (int)checked(unchecked((uint)(int)Aj8.Cm3(null, null, 156590416)) + unchecked((uint)(int)Cq8.Default) * unchecked((uint)num2)))));
		while (obj != null)
		{
			kz = (Kz1)(object)Aj8.Cm3(null, null, -802759975);
		}
		return;
		IL_090b:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n9L n9L);
		try
		{
			tr = tr;
			n9L = n9L;
		}
		catch
		{
			while (obj != null)
			{
				y6Z = y6Z;
				kz = (Kz1)(object)Cq8.Default;
				y0D = y0D;
				_ = (Aj8)(object)Cq8.Default;
			}
		}
		finally
		{
			try
			{
				if (num == 0)
				{
					y6Z = (y6Z)(object)Cq8.Default;
				}
			}
			catch
			{
				try
				{
					Wj3 obj13 = (Wj3)(object)Aj8.Cm3((byte[])(object)Cq8.Default, array, 2078079063);
					wj = (Wj3)(object)Cq8.Default;
					wj = obj13;
				}
				finally
				{
					_ = (Kj1)Cq8.Default;
					_ = (Gj7)(object)Cq8.Default;
					lw = (Lw6)(object)Aj8.Cm3((byte[])(object)Cq8.Default, array, -1803974885);
					_ = (Kj1)Cq8.Default;
					goto end_IL_096f;
				}
				end_IL_096f:;
			}
			goto IL_09e9;
		}
		IL_02fe:
		if (unchecked((nuint)default(UIntPtr)) / (nuint)(UIntPtr)Cq8.Default == 0)
		{
			do
			{
				try
				{
					_ = (Aj8)(object)Cq8.Default;
					_ = (Cq8)(object)Aj8.Cm3(null, Aj8.Cm3(array, array, (int)Aj8.Cm3(array, null, (int)checked(unchecked((uint)(int)Aj8.Cm3(array, Aj8.Cm3(array, array, (int)checked(unchecked((uint)(int)Aj8.Cm3((byte[])(object)Cq8.Default, Aj8.Cm3(Aj8.Cm3(null, Aj8.Cm3(null, array, 2075561356), 377928185), array, (int)Aj8.Cm3((byte[])(object)Cq8.Default, (byte[])(object)Cq8.Default, (int)Cq8.Default)), 1713733494)) * unchecked((uint)(int)Cq8.Default) - unchecked((uint)(int)Aj8.Cm3(array, null, (int)Cq8.Default)) - unchecked((uint)num2 / (uint)(int)Aj8.Cm3((byte[])(object)Cq8.Default, array, -193254262)) * unchecked((uint)num2))), (int)Cq8.Default)) + unchecked((uint)(int)Aj8.Cm3(null, null, (int)Aj8.Cm3(array, array, (int)checked(unchecked((uint)num2) + 2237661711u - unchecked((uint)num2) * 731595806u))))))), num2);
					gj = (Gj7)(object)Aj8.Cm3(array, null, (int)checked(unchecked((uint)(int)Cq8.Default) + unchecked((uint)num2)));
					gj = gj;
					_ = (n9L)(object)Aj8.Cm3(array, Aj8.Cm3(null, array, num2), (int)Aj8.Cm3(null, (byte[])(object)Cq8.Default, num2));
				}
				finally
				{
					_ = (_003CModule_003E)(object)Cq8.Default;
					_ = (_003CModule_003E)(object)Aj8.Cm3(array, null, (int)Cq8.Default);
					_ = (Tr3)(object)Aj8.Cm3(array, array, 2120459198);
					_ = (Gj7)(object)Cq8.Default;
					continue;
				}
			}
			while (obj != null);
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u && default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (d5W)(object)Cq8.Default;
		}
		try
		{
			Kj1 kj = (Kj1)Aj8.Cm3(null, null, num2);
			c2M = c2M;
			_ = (z3X)(object)Cq8.Default;
			kj = (Kj1)Cq8.Default;
		}
		catch
		{
			while ((object)Cq8.Default != null)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					gj = gj;
				}
				else
				{
					_ = (y6Z)(object)Cq8.Default;
				}
			}
		}
		_ = (Tr3)(object)Cq8.Default;
		_ = (z3X)(object)Aj8.Cm3(array, null, (int)Aj8.Cm3(array, array, num2));
		do
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				_ = (d5W)(object)Cq8.Default;
			}
		}
		while ((object)Aj8.Cm3(array, array, num2) != null);
		while (obj != null)
		{
			_ = (Kz1)(object)Cq8.Default;
		}
		if (num == (UIntPtr)(nuint)0u)
		{
			while ((object)Cq8.Default != null)
			{
				_ = (Aj8)(object)Aj8.Cm3(array, null, (int)Aj8.Cm3(array, null, 449579437));
			}
		}
		if ((UIntPtr)Aj8.Cm3(array, array, -318933185) == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					_ = (Cq8)(object)Aj8.Cm3(null, null, (int)Cq8.Default);
				}
				catch
				{
					_ = (Aj8)(object)Cq8.Default;
				}
			}
			catch
			{
				lw = lw;
			}
		}
		lw = lw;
		try
		{
			_ = (Kz1)(object)Aj8.Cm3(null, null, num2);
		}
		finally
		{
			num = default(UIntPtr);
			if (num / (num / num) == 0)
			{
				z3X = z3X;
			}
			else
			{
				y6Z = y6Z;
			}
			goto IL_0754;
		}
		IL_0754:
		while ((object)Cq8.Default != null)
		{
			while (true)
			{
				if ((object)Cq8.Default != null)
				{
					_ = (Kj1)Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)checked(unchecked((uint)num2) - unchecked((uint)(int)Cq8.Default)));
				}
				else if (obj == null)
				{
					break;
				}
			}
		}
		while (obj != null)
		{
			d2N = ((default(UIntPtr) != (UIntPtr)(nuint)0u) ? default(d2N) : d2N);
		}
		do
		{
			num = default(UIntPtr);
			if (checked(num * unchecked((nuint)(UIntPtr)Aj8.Cm3(array, array, (int)Aj8.Cm3(array, array, (int)Aj8.Cm3(array, (byte[])(object)Cq8.Default, num2))) / (nuint)(UIntPtr)Cq8.Default)) / num == 0 && (UIntPtr)Aj8.Cm3(array, array, num2) == (UIntPtr)(nuint)0u)
			{
				d2N = (d2N)Cq8.Default;
			}
		}
		while (obj != null);
		do
		{
			try
			{
				_ = (d2N)Cq8.Default;
			}
			finally
			{
				try
				{
					cq = cq;
				}
				finally
				{
					_ = (z3X)(object)Cq8.Default;
					continue;
				}
			}
		}
		while (obj != null);
		try
		{
			_ = (Lw6)(object)Aj8.Cm3(array, array, (int)Aj8.Cm3((byte[])(object)Cq8.Default, Aj8.Cm3((byte[])(object)Cq8.Default, array, num2), num2));
		}
		catch
		{
			try
			{
				z3X = z3X;
			}
			finally
			{
				_ = (y6Z)(object)Aj8.Cm3(array, array, num2);
				goto end_IL_08aa;
			}
			end_IL_08aa:;
		}
		finally
		{
			try
			{
				try
				{
					n9L = n9L;
				}
				catch
				{
					_ = (Kz1)(object)Aj8.Cm3(array, array, 1476959904);
				}
			}
			catch
			{
				_ = Cq8.Default;
			}
			goto IL_090b;
		}
		IL_0ce9:
		do
		{
			try
			{
				_ = (y0D)(object)Cq8.Default;
			}
			finally
			{
				do
				{
					y6Z = y6Z;
				}
				while ((object)Cq8.Default != null);
				continue;
			}
		}
		while (obj != null);
		try
		{
			c2M = c2M;
			_ = (Kz1)(object)Cq8.Default;
		}
		catch
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				lw = (Lw6)(object)Cq8.Default;
			}
		}
		finally
		{
			if ((UIntPtr)Aj8.Cm3(array, Aj8.Cm3(array, array, num2), (int)Cq8.Default) == (UIntPtr)(nuint)0u)
			{
				if (num == 0)
				{
					y0D = (y0D)(object)Aj8.Cm3(array, array, -1779466658);
				}
				else
				{
					_ = (Wj3)(object)Cq8.Default;
				}
				goto IL_0df4;
			}
			try
			{
				gj = null;
				_003CModule_003E obj22 = (_003CModule_003E)(object)Cq8.Default;
				_003CModule_003E = _003CModule_003E;
				_003CModule_003E = obj22;
				d5W = (d5W)(object)Aj8.Cm3(array, array, -1259425844);
			}
			finally
			{
				cq = null;
				goto IL_0df4;
			}
		}
		IL_0df4:
		_ = (d2N)Cq8.Default;
		do
		{
			try
			{
				do
				{
					gj = gj;
				}
				while ((object)Aj8.Cm3((byte[])(object)Cq8.Default, array, (int)checked(unchecked((uint)(int)Cq8.Default) * unchecked((uint)(int)Aj8.Cm3(null, Aj8.Cm3(Aj8.Cm3(null, array, (int)Cq8.Default), array, 0), -1143645556)))) != null);
			}
			finally
			{
				try
				{
					n9L = n9L;
				}
				catch
				{
					_ = (_003CModule_003E)(object)Cq8.Default;
				}
				continue;
			}
		}
		while (obj != null);
		_003CModule_003E = null;
		_ = (y6Z)(object)Aj8.Cm3(array, (byte[])(object)Cq8.Default, num2);
		_ = (Kz1)(object)Aj8.Cm3(Aj8.Cm3(array, Aj8.Cm3(array, (byte[])(object)Cq8.Default, num2), num2), null, num2);
		if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
		{
			do
			{
				num = default(UIntPtr);
				if (num != 0)
				{
					aj = null;
				}
				else
				{
					_ = (Aj8)(object)Cq8.Default;
				}
			}
			while (obj != null);
		}
		else
		{
			y6Z = y6Z;
			kz = kz;
			y6Z = y6Z;
			_ = (Lw6)(object)Aj8.Cm3(null, array, (int)checked(3999195497u * 1878708911u));
		}
		y6Z = null;
		_ = (Cq8)(object)Aj8.Cm3(null, array, -14476167);
		y6Z = (y6Z)(object)Cq8.Default;
		_ = (z3X)(object)Cq8.Default;
		z3X = null;
		_ = (d5W)(object)Cq8.Default;
		if (num == 0)
		{
			try
			{
				do
				{
					_ = (Wj3)(object)Cq8.Default;
				}
				while (obj != null);
			}
			catch
			{
				try
				{
					_ = (Kj1)Aj8.Cm3(array, null, 867132837);
				}
				finally
				{
					y6Z = y6Z;
					goto end_IL_0fb6;
				}
				end_IL_0fb6:;
			}
		}
		else if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
		{
			_ = (Aj8)(object)Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)checked(unchecked((uint)(int)Cq8.Default) - (3288795733u + unchecked((uint)num2))));
			d5W = (d5W)(object)Aj8.Cm3(array, array, 781004740);
		}
		_ = (d2N)Cq8.Default;
		if (num == 0 && num == 0)
		{
			try
			{
				d2N = (d2N)Cq8.Default;
				_ = (Kz1)(object)Cq8.Default;
			}
			catch
			{
				_ = (Gj7)(object)Cq8.Default;
				_ = (Lw6)(object)Cq8.Default;
			}
		}
		while ((object)Cq8.Default != null)
		{
			_ = (Kz1)(object)Aj8.Cm3((byte[])(object)Cq8.Default, null, num2);
		}
		while ((object)Cq8.Default != null)
		{
			c2M = null;
		}
		while (obj != null)
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (d2N)Cq8.Default;
				}
				else
				{
					c2M = c2M;
				}
			}
			finally
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
		num = default(UIntPtr);
		if (checked(num - num) == 0)
		{
			try
			{
				if (num == 0)
				{
					tr = tr;
				}
			}
			catch
			{
				while ((object)Aj8.Cm3(null, array, num2) != null)
				{
					wj = wj;
				}
			}
		}
		else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (y6Z)(object)Cq8.Default;
			}
			finally
			{
				y0D = null;
				_ = (Aj8)(object)Cq8.Default;
				goto IL_1170;
			}
		}
		goto IL_1170;
	}

	static void z6X()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Lw6 lw);
		do
		{
			try
			{
				array = array;
				_ = (Aj8)(object)Aj8.Cm3(array, Aj8.Cm3(array, array, (int)Cq8.Default), (int)Cq8.Default);
			}
			catch
			{
				do
				{
					lw = lw;
					lw = lw;
					obj = Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)Aj8.Cm3(Aj8.Cm3(null, null, (int)Cq8.Default), array, -1769520682));
				}
				while (obj != null);
			}
		}
		while (obj != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Aj8 aj);
		while (obj != null)
		{
			Aj8 obj3 = (Aj8)(object)Cq8.Default;
			aj = aj;
			aj = obj3;
		}
		_ = (d2N)Cq8.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num);
		if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
		{
			byte[] nx = (byte[])(object)Cq8.Default;
			byte[] ko = (byte[])(object)Cq8.Default;
			num = num;
			_ = (Wj3)(object)Aj8.Cm3(nx, ko, num);
		}
		else
		{
			lw = lw;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n9L n9L);
		do
		{
			n9L = n9L;
			n9L = null;
		}
		while (obj != null || obj != null);
		nuint uIntPtr = uIntPtr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Kz1 kz);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Gj7 gj);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					gj = (Gj7)(object)Aj8.Cm3(array, null, num);
					gj = gj;
					_ = (d2N)Cq8.Default;
					n9L = n9L;
				}
				finally
				{
					_ = (Kj1)Cq8.Default;
					goto end_IL_00e8;
				}
				end_IL_00e8:;
			}
			finally
			{
				try
				{
					kz = kz;
					kz = kz;
				}
				catch
				{
					_ = (d5W)(object)Cq8.Default;
					_ = (Lw6)(object)Aj8.Cm3(null, null, 1216218521);
				}
				goto IL_0203;
			}
		}
		goto IL_0203;
		IL_1162:
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			do
			{
				_ = (Gj7)(object)Aj8.Cm3((byte[])(object)Cq8.Default, array, (int)Cq8.Default);
			}
			while ((object)Aj8.Cm3(null, array, -2001286614) != null);
		}
		else
		{
			_ = (z3X)(object)Cq8.Default;
		}
		while ((object)Cq8.Default != null)
		{
			try
			{
				_ = (Wj3)(object)Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)Cq8.Default);
			}
			catch
			{
				_ = (n9L)(object)Cq8.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y0D y0D);
		do
		{
			if (uIntPtr != (UIntPtr)(nuint)0u)
			{
				_ = (Wj3)(object)Cq8.Default;
			}
			else
			{
				y0D = (y0D)(object)Aj8.Cm3(null, null, -129917568);
			}
		}
		while (obj != null);
		if ((UIntPtr)Aj8.Cm3(array, Aj8.Cm3((byte[])(object)Cq8.Default, Aj8.Cm3((byte[])(object)Cq8.Default, (byte[])(object)Cq8.Default, num), (int)Aj8.Cm3(Aj8.Cm3(null, array, (int)checked(unchecked((uint)(int)Aj8.Cm3(array, array, (int)Cq8.Default)) + unchecked((uint)num / (uint)num))), null, num)), (int)Cq8.Default) == (UIntPtr)(nuint)0u)
		{
			_ = (c2M)(object)Cq8.Default;
		}
		y0D = null;
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			_ = (Aj8)(object)Aj8.Cm3(array, array, 1783888512);
		}
		_ = (n9L)(object)Aj8.Cm3((byte[])(object)Cq8.Default, array, (int)checked(2268837033u - unchecked((uint)(int)Cq8.Default) - 1961109326u));
		_ = (c2M)(object)Cq8.Default;
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			n9L = null;
		}
		else
		{
			_ = (z3X)(object)Aj8.Cm3(array, null, num);
			_ = (_003CModule_003E)(object)Aj8.Cm3((byte[])(object)Cq8.Default, array, -2085753999);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d2N d2N);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Tr3 tr);
		while (obj != null)
		{
			try
			{
				while (obj != null)
				{
					tr = (Tr3)(object)Cq8.Default;
				}
			}
			catch
			{
				try
				{
					d2N = (d2N)Cq8.Default;
					_ = (y0D)(object)Aj8.Cm3(null, array, (int)Aj8.Cm3(array, array, num));
					_ = (Kz1)(object)Aj8.Cm3(array, array, 1761043459);
				}
				catch
				{
					y0D = null;
				}
			}
		}
		return;
		IL_0686:
		_ = (Gj7)(object)Aj8.Cm3(null, (byte[])(object)Cq8.Default, (int)checked(unchecked((uint)num) - unchecked((uint)(int)Cq8.Default)));
		_ = Cq8.Default;
		_003CModule_003E _003CModule_003E = _003CModule_003E;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				while (obj != null)
				{
					_ = (y0D)(object)Cq8.Default;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c2M c2M);
		while (obj != null)
		{
			try
			{
				try
				{
					_ = (Tr3)(object)Cq8.Default;
				}
				finally
				{
					_ = (d5W)(object)Cq8.Default;
					goto end_IL_06dd;
				}
				end_IL_06dd:;
			}
			catch
			{
				_ = Cq8.Default;
				_ = (d5W)(object)Cq8.Default;
				c2M = null;
				_ = (d5W)(object)Aj8.Cm3((byte[])(object)Cq8.Default, Aj8.Cm3(null, null, -156179846), (int)checked(3231267076u - unchecked((uint)num) * 686298200u));
			}
		}
		if ((UIntPtr)Aj8.Cm3(array, array, (int)checked(1516724129u - unchecked(checked(3055425294u + (unchecked((uint)(int)Cq8.Default) - 4129646444u * unchecked((uint)(int)Cq8.Default))) / (uint)(int)Aj8.Cm3(null, Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)Aj8.Cm3((byte[])(object)Cq8.Default, array, num)), (int)Cq8.Default)))) == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)Aj8.Cm3(null, array, (int)checked(unchecked((uint)num) - 3522511634u * unchecked((uint)num))) == (UIntPtr)(nuint)0u)
			{
				checked
				{
					if (unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr)) == 0)
					{
						_ = (Wj3)(object)Aj8.Cm3(array, array, 1744946843);
					}
					else
					{
						_ = (d5W)(object)Aj8.Cm3(null, (byte[])(object)Cq8.Default, num);
					}
				}
			}
			else
			{
				_ = (Gj7)(object)Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)Cq8.Default);
			}
		}
		gj = gj;
		_ = (Aj8)(object)Cq8.Default;
		y0D = y0D;
		y0D = null;
		try
		{
			_ = (c2M)(object)Cq8.Default;
		}
		catch
		{
			try
			{
				while (obj != null)
				{
					n9L = n9L;
				}
			}
			finally
			{
				_ = (Tr3)(object)Aj8.Cm3(array, array, (int)checked(1160933015u - unchecked((uint)num)));
				goto end_IL_0865;
			}
			end_IL_0865:;
		}
		try
		{
			while (obj != null)
			{
				if (checked(unchecked((nuint)default(UIntPtr)) * unchecked((nuint)default(UIntPtr))) == 0)
				{
					_ = (Kj1)Aj8.Cm3(array, null, -602202487);
					_ = Cq8.Default;
					y0D = y0D;
					_ = (d5W)(object)Cq8.Default;
				}
				else
				{
					_ = (d2N)Cq8.Default;
					_ = (d5W)(object)Aj8.Cm3(null, array, (int)checked(unchecked((uint)num) + 3128016130u));
				}
			}
		}
		catch
		{
			while (obj != null)
			{
			}
		}
		if ((UIntPtr)Aj8.Cm3(array, Aj8.Cm3(array, array, -652683695), 1770602948) == (UIntPtr)(nuint)0u)
		{
			uIntPtr = default(UIntPtr);
			checked
			{
				if (uIntPtr + unchecked((nuint)(UIntPtr)Cq8.Default) == 0 && uIntPtr * uIntPtr == 0)
				{
					_ = (y0D)(object)Aj8.Cm3(array, null, -463094104);
					_ = (y6Z)(object)Aj8.Cm3(array, array, 1145977906);
					_ = (d5W)(object)Cq8.Default;
					d2N = d2N;
				}
			}
		}
		else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			d2N = d2N;
		}
		_ = (n9L)(object)Aj8.Cm3(null, null, 1539763912);
		try
		{
			while (obj != null)
			{
				if ((nuint)(UIntPtr)Cq8.Default / unchecked((nuint)default(UIntPtr)) == 0)
				{
					_ = (Gj7)(object)Cq8.Default;
				}
			}
		}
		finally
		{
			_ = (Gj7)(object)Cq8.Default;
			_ = (Tr3)(object)Aj8.Cm3(null, array, 152650598);
			lw = lw;
			goto IL_09e5;
		}
		IL_02dd:
		while (obj != null)
		{
			_ = (Kz1)(object)Aj8.Cm3(array, array, -641499119);
		}
		try
		{
		}
		catch
		{
			try
			{
				_ = (c2M)(object)Aj8.Cm3((byte[])(object)Cq8.Default, array, num);
				_ = (_003CModule_003E)(object)Aj8.Cm3(null, null, (int)checked(unchecked((uint)num) - unchecked((uint)num)));
				_ = (d5W)(object)Aj8.Cm3(array, null, num);
				_ = (d5W)(object)Cq8.Default;
				kz = kz;
			}
			catch
			{
				try
				{
					kz = kz;
					goto end_IL_032d;
				}
				finally
				{
					_ = (c2M)(object)Aj8.Cm3(array, array, num);
					goto end_IL_032d;
				}
				end_IL_032d:;
			}
		}
		try
		{
			_ = (Lw6)(object)Aj8.Cm3(null, array, num);
			_003CModule_003E = null;
		}
		finally
		{
			do
			{
				if (uIntPtr == 0)
				{
					_ = (y0D)(object)Aj8.Cm3(array, Aj8.Cm3(Aj8.Cm3(array, Aj8.Cm3(array, null, (int)((uint)num / 1434372143u)), -1142076811), null, (int)checked(3079061661u * unchecked((uint)(int)Aj8.Cm3((byte[])(object)Cq8.Default, Aj8.Cm3(null, null, num), 502335841)))), (int)checked(unchecked((uint)num) + unchecked((uint)num)));
				}
			}
			while (obj != null);
			goto IL_03dd;
		}
		IL_0614:
		try
		{
			if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (_003CModule_003E)(object)Cq8.Default;
				}
				catch
				{
					_ = (Tr3)(object)Aj8.Cm3(null, null, num);
				}
			}
			else
			{
				_ = (y0D)(object)Aj8.Cm3(null, array, num);
			}
		}
		finally
		{
			try
			{
				if ((UIntPtr)Aj8.Cm3(null, array, -1519706221) == (UIntPtr)(nuint)0u)
				{
					gj = null;
				}
			}
			catch
			{
				if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
				{
					_ = (y0D)(object)Cq8.Default;
				}
			}
			goto IL_0686;
		}
		IL_03dd:
		if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
		{
			_ = (c2M)(object)Cq8.Default;
		}
		else
		{
			while (true)
			{
				if (obj != null)
				{
					_ = (c2M)(object)Aj8.Cm3((byte[])(object)Cq8.Default, array, (int)Aj8.Cm3((byte[])(object)Cq8.Default, array, num));
				}
				else if ((object)Cq8.Default == null)
				{
					break;
				}
			}
		}
		try
		{
			_ = (Lw6)(object)Aj8.Cm3(Aj8.Cm3(array, array, -62952156), array, (int)checked(3411667021u + unchecked((uint)(int)Aj8.Cm3(array, array, num))));
			n9L = n9L;
		}
		catch
		{
		}
		while ((object)Cq8.Default != null)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				nuint num2 = uIntPtr;
				uIntPtr = default(UIntPtr);
				if (num2 / uIntPtr == 0)
				{
					_ = (_003CModule_003E)(object)Aj8.Cm3(array, array, (int)checked(unchecked((uint)(int)Cq8.Default) - 1440323100u));
				}
			}
			else
			{
				do
				{
					tr = tr;
				}
				while (obj != null);
			}
		}
		while ((object)Cq8.Default != null)
		{
			tr = null;
		}
		do
		{
			_ = (y6Z)(object)Cq8.Default;
		}
		while (obj != null);
		checked
		{
			try
			{
				nuint num3 = uIntPtr;
				UIntPtr num4 = unchecked((UIntPtr)Cq8.Default);
				uIntPtr = default(UIntPtr);
				if (num3 * (unchecked((nuint)num4) + uIntPtr) == 0)
				{
					if (uIntPtr == 0)
					{
						_ = Cq8.Default;
					}
				}
				else
				{
					d2N obj16 = (d2N)Aj8.Cm3(null, array, num);
					d2N = d2N;
					d2N = obj16;
					lw = null;
					c2M = (c2M)(object)Cq8.Default;
				}
			}
			catch
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr * unchecked((nuint)(UIntPtr)Cq8.Default) == 0)
				{
					c2M = (c2M)(object)Aj8.Cm3(array, array, num);
				}
			}
			_ = (n9L)(object)Cq8.Default;
		}
		_ = (Cq8)(object)Aj8.Cm3(null, array, (int)checked(488465783u - (unchecked((uint)(int)Cq8.Default) - unchecked((uint)num))));
		try
		{
			do
			{
				_ = (Lw6)(object)Cq8.Default;
			}
			while (obj != null);
		}
		catch
		{
			_ = (Aj8)(object)Cq8.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y6Z y6Z);
		try
		{
			do
			{
				y6Z = y6Z;
			}
			while ((object)Cq8.Default != null);
		}
		catch
		{
			if (uIntPtr == 0)
			{
				_ = (d2N)Aj8.Cm3(Aj8.Cm3(array, array, 1315332614), (byte[])(object)Cq8.Default, num);
			}
			else
			{
				_ = (Kj1)Aj8.Cm3(Aj8.Cm3(array, array, num), array, 1754954215);
			}
		}
		finally
		{
			_ = (Tr3)(object)Cq8.Default;
			goto IL_0614;
		}
		IL_0b01:
		do
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				do
				{
					_ = (Aj8)(object)Cq8.Default;
				}
				while (obj != null);
			}
		}
		while ((object)Aj8.Cm3(null, array, (int)checked(2081564045u * ((unchecked((uint)num) - unchecked((uint)(int)Cq8.Default)) * unchecked((uint)(int)Aj8.Cm3(array, (byte[])(object)Cq8.Default, num))))) != null);
		if (checked(unchecked((nuint)(UIntPtr)Aj8.Cm3(array, null, (int)(checked(1218305825u * 3846395670u) / (uint)num))) - uIntPtr) == 0)
		{
			if (uIntPtr == 0 && (UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
			{
				aj = null;
			}
		}
		else
		{
			try
			{
				if (checked(unchecked((nuint)(UIntPtr)Aj8.Cm3(null, (byte[])(object)Cq8.Default, (int)Aj8.Cm3(array, array, num))) * unchecked((nuint)(UIntPtr)Cq8.Default)) == 0)
				{
					_ = (Kz1)(object)Aj8.Cm3(Aj8.Cm3(Aj8.Cm3(array, null, (int)Cq8.Default), Aj8.Cm3(array, (byte[])(object)Cq8.Default, num), num), Aj8.Cm3(array, array, num), (int)checked(unchecked((uint)num) - unchecked((uint)(int)Aj8.Cm3(array, array, num))));
				}
				else
				{
					_ = (z3X)(object)Aj8.Cm3(null, array, (int)Cq8.Default);
				}
			}
			catch
			{
				try
				{
					_ = (n9L)(object)Aj8.Cm3(null, array, (int)(checked(unchecked((uint)num) + unchecked((uint)num)) / (3572361469u / (uint)(int)Cq8.Default)));
				}
				catch
				{
					_ = (_003CModule_003E)(object)Cq8.Default;
					tr = null;
					d2N = d2N;
				}
			}
		}
		_ = (y6Z)(object)Aj8.Cm3(null, array, (int)Cq8.Default);
		if (uIntPtr == 0)
		{
			d2N = d2N;
		}
		try
		{
			if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (y6Z)(object)Cq8.Default;
					Kj1 kj = default(Kj1);
					_ = (d5W)(object)Cq8.Default;
				}
				finally
				{
					_ = (Kz1)(object)Aj8.Cm3(array, array, (int)checked((unchecked((uint)num) - 2629802690u - 4080541136u) * unchecked(checked(3066707171u - 3861307621u) / (uint)(int)Cq8.Default)));
					goto end_IL_0c57;
				}
			}
			end_IL_0c57:;
		}
		finally
		{
			try
			{
				try
				{
					_ = (n9L)(object)Cq8.Default;
				}
				catch
				{
					_ = Cq8.Default;
					_ = (Aj8)(object)Cq8.Default;
					_ = (Gj7)(object)Aj8.Cm3(array, null, (int)checked(unchecked((uint)(int)Aj8.Cm3(array, array, num)) - unchecked((uint)(int)Cq8.Default)));
				}
			}
			catch
			{
				_ = (n9L)(object)Aj8.Cm3(Aj8.Cm3(array, array, num), array, (int)checked(unchecked((uint)num) * (unchecked((uint)(int)Aj8.Cm3(array, array, num)) - unchecked((uint)(int)Aj8.Cm3(null, array, num)) * unchecked((uint)(int)Cq8.Default))));
			}
			goto IL_0d5e;
		}
		IL_1128:
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				do
				{
					_ = (Lw6)(object)Cq8.Default;
				}
				while (obj != null);
			}
			finally
			{
				_ = (y0D)(object)Aj8.Cm3(array, (byte[])(object)Cq8.Default, -970364673);
				goto IL_1162;
			}
		}
		goto IL_1162;
		IL_09e5:
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			while ((object)Cq8.Default != null)
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					y6Z = (y6Z)(object)Aj8.Cm3(array, Aj8.Cm3(array, array, 888637799), (int)Cq8.Default);
					_ = (c2M)(object)Cq8.Default;
					_ = (Gj7)(object)Aj8.Cm3(Aj8.Cm3(array, array, num), Aj8.Cm3(null, array, num), (int)Aj8.Cm3(Aj8.Cm3((byte[])(object)Cq8.Default, array, (int)checked(2350577305u * unchecked((uint)(int)Cq8.Default))), array, (int)Cq8.Default));
				}
			}
			goto IL_0b01;
		}
		try
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
			}
		}
		finally
		{
			do
			{
				gj = gj;
			}
			while (obj != null);
			goto IL_0b01;
		}
		IL_0d5e:
		if ((nuint)(UIntPtr)Cq8.Default / uIntPtr == 0)
		{
			while (obj != null)
			{
				try
				{
					kz = kz;
				}
				catch
				{
					_ = (y6Z)(object)Cq8.Default;
				}
			}
		}
		_ = (n9L)(object)Cq8.Default;
		_ = (d5W)(object)Aj8.Cm3(array, Aj8.Cm3((byte[])(object)Cq8.Default, array, 1834255663), (int)(checked(3454731893u - unchecked((uint)(int)Aj8.Cm3(array, Aj8.Cm3(array, null, (int)(checked(unchecked((uint)num) * unchecked((uint)num)) / (uint)(int)Cq8.Default)), (int)checked(3266289552u * unchecked(3734442053u / (uint)(int)Aj8.Cm3(array, null, (int)Aj8.Cm3(array, array, (int)Cq8.Default))))))) / checked(unchecked((uint)(int)Cq8.Default) * unchecked((uint)(int)Aj8.Cm3(array, Aj8.Cm3(null, (byte[])(object)Cq8.Default, (int)Aj8.Cm3(null, Aj8.Cm3(null, null, num), -1043987569)), num)) - unchecked((uint)(int)Aj8.Cm3(array, array, (int)checked(unchecked((uint)(int)Cq8.Default) + (2543115445u + unchecked((uint)num))))))));
		_ = (Wj3)(object)Aj8.Cm3(array, null, -493712913);
		try
		{
			_ = (Wj3)(object)Cq8.Default;
			c2M = c2M;
			_ = (Wj3)(object)Cq8.Default;
		}
		catch
		{
			while (obj != null)
			{
				try
				{
				}
				finally
				{
					_ = (y0D)(object)Aj8.Cm3(array, null, num);
					continue;
				}
			}
		}
		if ((UIntPtr)Aj8.Cm3(array, (byte[])(object)Cq8.Default, -100722961) == (UIntPtr)(nuint)0u)
		{
			do
			{
				try
				{
					_ = (Wj3)(object)Cq8.Default;
				}
				catch
				{
					_ = (Aj8)(object)Cq8.Default;
				}
			}
			while (obj != null);
		}
		else
		{
			nuint num5 = uIntPtr;
			uIntPtr = default(UIntPtr);
			if (checked(num5 - uIntPtr) == 0)
			{
				try
				{
					_ = (y6Z)(object)Cq8.Default;
					n9L = null;
					_ = (n9L)(object)Aj8.Cm3(null, null, (int)checked(unchecked((uint)(int)Aj8.Cm3(array, null, 177155675)) + unchecked((uint)num) + unchecked((uint)(int)Aj8.Cm3(array, null, num))));
				}
				finally
				{
					_ = (Kz1)(object)Cq8.Default;
					goto IL_0f60;
				}
			}
		}
		goto IL_0f60;
		IL_0203:
		while ((object)Aj8.Cm3(Aj8.Cm3(Aj8.Cm3(null, null, (int)Aj8.Cm3(Aj8.Cm3(Aj8.Cm3(null, array, num), array, -602508162), (byte[])(object)Cq8.Default, (int)Cq8.Default)), array, 0), Aj8.Cm3(null, array, (int)Aj8.Cm3(array, null, (int)checked(unchecked((uint)num) + unchecked((uint)num)))), (int)Cq8.Default) != null)
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (Gj7)(object)Cq8.Default;
				y6Z obj27 = (y6Z)(object)Aj8.Cm3(null, null, (int)Aj8.Cm3(null, (byte[])(object)Cq8.Default, -786455153));
				y6Z = null;
				y6Z = obj27;
			}
			else if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				Tr3 obj28 = (Tr3)(object)Cq8.Default;
				tr = tr;
				tr = obj28;
				_ = (_003CModule_003E)(object)Aj8.Cm3((byte[])(object)Cq8.Default, array, -649580018);
				_ = (y6Z)(object)Aj8.Cm3(null, Aj8.Cm3(array, null, (int)Cq8.Default), (int)checked(1u * unchecked((uint)num) * unchecked((uint)num) * unchecked((uint)(int)Cq8.Default) * unchecked((uint)(int)Cq8.Default) + unchecked((uint)num)));
			}
			else
			{
				tr = tr;
			}
		}
		uIntPtr = default(UIntPtr);
		if (checked(uIntPtr - uIntPtr - uIntPtr) == 0)
		{
			try
			{
				_ = (n9L)(object)Cq8.Default;
				_003CModule_003E = null;
				_003CModule_003E = null;
			}
			finally
			{
				try
				{
					_ = (z3X)(object)Cq8.Default;
				}
				finally
				{
					c2M = null;
					c2M = c2M;
					goto IL_02dd;
				}
			}
		}
		goto IL_02dd;
		IL_0f60:
		nuint num6 = uIntPtr;
		uIntPtr = default(UIntPtr);
		if (checked(num6 - uIntPtr) == 0)
		{
			while (obj != null)
			{
			}
		}
		do
		{
			_ = (d2N)Cq8.Default;
		}
		while (obj != null);
		if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
		{
			_ = (c2M)(object)Cq8.Default;
		}
		else
		{
			try
			{
				if (checked((uIntPtr + uIntPtr + unchecked((nuint)(UIntPtr)Cq8.Default)) * unchecked((nuint)(UIntPtr)Aj8.Cm3(null, array, (int)checked(unchecked((uint)num) - unchecked((uint)(int)Aj8.Cm3(array, array, (int)Aj8.Cm3(array, Aj8.Cm3(array, null, (int)Cq8.Default), (int)Cq8.Default))))))) == 0)
				{
					_ = (Kz1)(object)Aj8.Cm3(null, array, (int)Cq8.Default);
				}
				else
				{
					_ = (Tr3)(object)Cq8.Default;
					_ = (d2N)Cq8.Default;
				}
			}
			catch
			{
				while (obj != null)
				{
					_ = (Wj3)(object)Cq8.Default;
					_ = (d5W)(object)Cq8.Default;
					_ = (c2M)(object)Aj8.Cm3(null, array, (int)Cq8.Default);
				}
			}
		}
		try
		{
			checked
			{
				while (obj != null)
				{
					nuint num7 = uIntPtr - unchecked((nuint)(UIntPtr)Aj8.Cm3(array, array, 178186356));
					uIntPtr = default(UIntPtr);
					if (num7 - uIntPtr == 0)
					{
						y0D = y0D;
					}
				}
			}
		}
		finally
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (Gj7)(object)Cq8.Default;
				}
				else
				{
					y0D = y0D;
					n9L = (n9L)(object)Aj8.Cm3(null, null, 338382961);
				}
			}
			finally
			{
				if (checked(unchecked((nuint)(UIntPtr)Cq8.Default) - unchecked((nuint)(UIntPtr)Aj8.Cm3((byte[])(object)Cq8.Default, array, -1904686701))) / uIntPtr == 0)
				{
					n9L = (n9L)(object)Aj8.Cm3(array, array, (int)Cq8.Default);
					_ = (Gj7)(object)Aj8.Cm3(array, array, num);
					gj = null;
				}
				else
				{
					_ = (y6Z)(object)Cq8.Default;
				}
				goto IL_1128;
			}
		}
	}
}
