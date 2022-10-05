using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using Af6;
using Cz1;
using Em4;
using Gb9;
using Jb7;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.Logging;
using Yb9;
using a1G;
using a2W;
using f8F;
using n7E;
using r6F;
using t7Z;
using y0J;
using y9M;

namespace Qa4;

[StandardModule]
[HideModuleName]
internal sealed class z3X
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Window", "Create__Instance__", "Dispose__Instance__", "My.MyWpfExtenstionModule.Windows")]
	internal sealed class Ws9
	{
		[ThreadStatic]
		private static Hashtable D;

		private static Sq3 Dg8<Sq3>(Sq3 gparam_0) where Sq3 : Window, new()
		{
			if (gparam_0 == null)
			{
				if (D != null)
				{
					if (D.ContainsKey(typeof(Sq3)))
					{
						throw new InvalidOperationException("The window cannot be accessed via My.Windows from the Window constructor.");
					}
				}
				else
				{
					D = new Hashtable();
				}
				D.Add(typeof(Sq3), null);
				return new Sq3();
			}
			return gparam_0;
		}

		private void z6R<c6H>(ref c6H gparam_0) where c6H : Window
		{
			gparam_0 = default(c6H);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ws9()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool c5W(object object_0)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(object_0));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int w0N()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Fr9()
		{
			return typeof(Ws9);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string Ek9()
		{
			return base.ToString();
		}
	}

	private static c2M.Qi5<Computer> D = new c2M.Qi5<Computer>();

	private static c2M.Qi5<User> T = new c2M.Qi5<User>();

	private static c2M.Qi5<Ws9> H = new c2M.Qi5<Ws9>();

	private static c2M.Qi5<Log> s = new c2M.Qi5<Log>();

	[SpecialName]
	internal static Ws9 r2H()
	{
		return H.s();
	}

	static void c8F()
	{
		nuint uIntPtr = (UIntPtr)Cq8.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d2N d2N);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					_ = (_003CModule_003E)(object)Cq8.Default;
				}
				finally
				{
					array = Aj8.Cm3(array, null, 1656828653);
					_ = (z3X)(object)Aj8.Cm3(array, null, -665362043);
					goto end_IL_0017;
				}
				end_IL_0017:;
			}
			catch
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					d2N = (d2N)Cq8.Default;
					d2N = default(d2N);
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num);
		while (obj2 != null)
		{
			while (obj2 != null)
			{
				do
				{
					byte[] nx = array;
					byte[] ko = (byte[])(object)Cq8.Default;
					num = 592722564;
					_ = (Lw6)(object)Aj8.Cm3(nx, ko, (int)(checked((unchecked(592722564u / (uint)(int)Cq8.Default) - unchecked((uint)(int)Aj8.Cm3(array, array, 592722564))) * (unchecked((uint)(int)Cq8.Default) - unchecked(592722564u / (uint)(int)Cq8.Default))) / (uint)(int)Aj8.Cm3(Aj8.Cm3((byte[])(object)Cq8.Default, null, (int)checked(unchecked((uint)(int)Cq8.Default) * 3869579461u)), array, -1382496263)));
					obj2 = obj2;
				}
				while (obj2 != null);
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Tr3 tr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Kj1 kj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Wj3 wj);
		try
		{
			if ((UIntPtr)Cq8.Default != (UIntPtr)(nuint)0u)
			{
				try
				{
					wj = (Wj3)(object)Aj8.Cm3(Aj8.Cm3(array, Aj8.Cm3(Aj8.Cm3(array, Aj8.Cm3(array, null, (int)((uint)(int)Cq8.Default / checked(unchecked((uint)(int)Aj8.Cm3(array, array, (int)Aj8.Cm3(array, null, 1349943380))) * unchecked((uint)num)))), (int)Cq8.Default), (byte[])(object)Cq8.Default, -1217183461), (int)Cq8.Default), (byte[])(object)Cq8.Default, (int)Aj8.Cm3(null, Aj8.Cm3(null, null, 1085100915), (int)Cq8.Default));
					wj = null;
				}
				finally
				{
					Kj1 obj3 = (Kj1)Cq8.Default;
					kj = default(Kj1);
					kj = kj;
					kj = obj3;
					goto end_IL_014e;
				}
			}
			do
			{
				tr = tr;
				tr = null;
			}
			while (obj2 != null);
			end_IL_014e:;
		}
		catch
		{
			_ = (n9L)(object)Cq8.Default;
		}
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Lw6 lw);
		if (uIntPtr == 0)
		{
			do
			{
				try
				{
					_ = Cq8.Default;
					d2N = d2N;
					_ = (Aj8)(object)Cq8.Default;
					kj = (Kj1)Aj8.Cm3((byte[])(object)Cq8.Default, null, (int)checked(unchecked((uint)(int)Cq8.Default) - (39979004u - unchecked(checked(1293413796u * unchecked((uint)num)) / 2889136985u))));
				}
				finally
				{
					_ = (_003CModule_003E)(object)Cq8.Default;
					continue;
				}
			}
			while ((object)Aj8.Cm3(array, array, -2001896550) != null);
		}
		else if ((UIntPtr)Aj8.Cm3(null, (byte[])(object)Cq8.Default, -252822686) == (UIntPtr)(nuint)0u)
		{
			wj = wj;
			Lw6 obj5 = (Lw6)(object)Aj8.Cm3(array, null, (int)checked(258865985u - 1384815523u));
			lw = lw;
			lw = obj5;
			_ = (z3X)(object)Aj8.Cm3(Aj8.Cm3(Aj8.Cm3((byte[])(object)Cq8.Default, array, num), (byte[])(object)Cq8.Default, (int)Cq8.Default), array, num);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y0D y0D);
		do
		{
			y0D = y0D;
			y0D = y0D;
		}
		while (obj2 != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Gj7 gj);
		try
		{
			if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (Wj3)(object)Aj8.Cm3(array, Aj8.Cm3(Aj8.Cm3(null, array, -896224999), null, num), (int)checked(3935905038u + unchecked((uint)(int)Aj8.Cm3(array, null, (int)Cq8.Default))));
				}
			}
		}
		catch
		{
			do
			{
				Gj7 obj6 = (Gj7)(object)Cq8.Default;
				gj = gj;
				gj = obj6;
			}
			while ((object)Aj8.Cm3(array, array, num) != null);
		}
		if ((UIntPtr)Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)checked(898337171u - unchecked((uint)(int)Aj8.Cm3((byte[])(object)Cq8.Default, null, num)))) == (UIntPtr)(nuint)0u)
		{
			uIntPtr = default(UIntPtr);
			if (unchecked((nuint)default(UIntPtr)) / uIntPtr == 0 && (UIntPtr)Aj8.Cm3(array, null, 762562441) == (UIntPtr)(nuint)0u)
			{
				_ = (y0D)(object)Cq8.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z3X z3X2);
		try
		{
			z3X2 = null;
			z3X2 = null;
			y0D = null;
		}
		catch
		{
			try
			{
				_003CModule_003E = _003CModule_003E;
				_003CModule_003E = _003CModule_003E;
			}
			catch
			{
				wj = wj;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c2M c2M);
		while ((object)Aj8.Cm3(null, (byte[])(object)Cq8.Default, (int)Cq8.Default) != null)
		{
			do
			{
				kj = kj;
				_ = (Cq8)(object)Aj8.Cm3(array, array, num);
				_ = (n9L)(object)Aj8.Cm3(null, array, (int)Cq8.Default);
				c2M = c2M;
				c2M = c2M;
			}
			while ((object)Aj8.Cm3(array, array, (int)((uint)(int)Aj8.Cm3(null, array, (int)((uint)(int)Cq8.Default / checked(unchecked((uint)(int)Aj8.Cm3((byte[])(object)Cq8.Default, null, -1652451467)) - 2504735449u + 3668524361u))) / 1098498480u)) != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cq8 cq);
		do
		{
			try
			{
				cq = cq;
				cq = cq;
				_ = (c2M)(object)Aj8.Cm3(array, Aj8.Cm3(array, array, (int)checked(unchecked((uint)(int)Cq8.Default) + unchecked((uint)(int)Cq8.Default))), (int)Aj8.Cm3(null, null, -1216134159));
			}
			finally
			{
				try
				{
					_ = (Kj1)Cq8.Default;
					_ = (Tr3)(object)Aj8.Cm3(null, array, 1930917896);
				}
				finally
				{
					c2M = null;
					continue;
				}
			}
		}
		while (obj2 != null);
		if (uIntPtr / (nuint)(UIntPtr)Aj8.Cm3(null, null, (int)checked(unchecked((uint)(int)Aj8.Cm3(array, array, (int)Cq8.Default)) * 2334465917u)) == 0)
		{
			try
			{
				_ = (Cq8)(object)Aj8.Cm3(array, array, (int)Cq8.Default);
			}
			catch
			{
				kj = kj;
			}
		}
		else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (y0D)(object)Cq8.Default;
		}
		do
		{
			c2M = c2M;
		}
		while (obj2 != null);
		Kz1 kz = (Kz1)(object)Cq8.Default;
		kz = kz;
		Aj8 obj11 = (Aj8)(object)Cq8.Default;
		Aj8 aj = null;
		aj = obj11;
		_ = (c2M)(object)Aj8.Cm3(array, Aj8.Cm3(array, array, num), num);
		c2M = (c2M)(object)Aj8.Cm3(Aj8.Cm3(array, array, num), array, -187999642);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n9L n9L);
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (y6Z)(object)Aj8.Cm3(array, Aj8.Cm3(array, array, num), 277007144);
					_ = (Kj1)Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)Cq8.Default);
					lw = lw;
				}
				catch
				{
					kj = kj;
				}
			}
			else if ((UIntPtr)Aj8.Cm3(null, array, (int)Cq8.Default) == (UIntPtr)(nuint)0u)
			{
				n9L = (n9L)(object)Cq8.Default;
				n9L = null;
				_ = (_003CModule_003E)(object)Aj8.Cm3(array, array, num);
				z3X2 = (z3X)(object)Cq8.Default;
				_ = (d5W)(object)Cq8.Default;
			}
		}
		catch
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (Lw6)(object)Aj8.Cm3(array, array, (int)checked(940971020u * unchecked((uint)(int)Aj8.Cm3(array, array, (int)checked(2875832731u + unchecked((uint)num / checked(unchecked((uint)(int)Cq8.Default) * unchecked((uint)(int)Aj8.Cm3(array, null, -277846879)))))))));
			}
		}
		n9L = n9L;
		do
		{
			gj = gj;
		}
		while ((object)Aj8.Cm3(null, (byte[])(object)Cq8.Default, (int)Aj8.Cm3(null, array, (int)checked(unchecked((uint)(int)Cq8.Default / (uint)(int)Cq8.Default) + unchecked((uint)(int)Aj8.Cm3(array, null, 435052684))))) != null);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			wj = wj;
		}
		checked
		{
			while (obj2 != null)
			{
				if (unchecked((nuint)(UIntPtr)Aj8.Cm3(array, array, (int)checked(unchecked((uint)num) + unchecked((uint)num)))) * unchecked((nuint)(UIntPtr)Cq8.Default) == 0)
				{
					while ((object)Cq8.Default != null)
					{
						_ = (Gj7)(object)Cq8.Default;
					}
				}
			}
		}
		_ = (Lw6)(object)Aj8.Cm3(null, (byte[])(object)Cq8.Default, (int)Cq8.Default);
		cq = (Cq8)(object)Aj8.Cm3((byte[])(object)Cq8.Default, array, num);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
				{
					y0D = y0D;
				}
			}
			catch
			{
				if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
				{
					_003CModule_003E = _003CModule_003E;
				}
			}
		}
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y6Z y6Z);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				z3X2 = (z3X)(object)Cq8.Default;
			}
			finally
			{
				y6Z obj15 = (y6Z)(object)Cq8.Default;
				y6Z = y6Z;
				y6Z = obj15;
				goto IL_0a18;
			}
		}
		goto IL_0a18;
		IL_13a3:
		cq = null;
		try
		{
		}
		catch
		{
			try
			{
				if (uIntPtr == 0)
				{
					_ = (Gj7)(object)Cq8.Default;
				}
				else
				{
					_ = (d2N)Aj8.Cm3(array, Aj8.Cm3(array, array, (int)((uint)num / (uint)num)), (int)Aj8.Cm3(Aj8.Cm3(null, Aj8.Cm3(Aj8.Cm3(array, Aj8.Cm3(array, array, (int)Cq8.Default), 1286152532), array, (int)checked(unchecked((uint)(int)Cq8.Default) * unchecked((uint)(int)Aj8.Cm3(array, array, num)))), (int)Cq8.Default), array, (int)checked(unchecked((uint)num) + (unchecked((uint)num) - unchecked((uint)(int)Aj8.Cm3((byte[])(object)Cq8.Default, null, num))))));
				}
			}
			finally
			{
				do
				{
					lw = (Lw6)(object)Aj8.Cm3(array, array, (int)Cq8.Default);
				}
				while ((object)Cq8.Default != null);
				goto end_IL_13ad;
			}
			end_IL_13ad:;
		}
		checked
		{
			try
			{
				if (uIntPtr == 0)
				{
					try
					{
						aj = aj;
						return;
					}
					catch
					{
						_ = (Aj8)(object)Aj8.Cm3(null, null, num);
						return;
					}
				}
				if (unchecked((nuint)(UIntPtr)Aj8.Cm3(array, array, (int)checked(unchecked((uint)(int)Cq8.Default) + 2677102670u + 3731013009u))) - unchecked((nuint)(UIntPtr)Cq8.Default) == 0)
				{
					kz = kz;
				}
				return;
			}
			catch
			{
				if (uIntPtr == 0)
				{
					_ = (y6Z)(object)Cq8.Default;
				}
				return;
			}
		}
		IL_104a:
		if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				kj = default(Kj1);
			}
			finally
			{
				nuint num2 = uIntPtr;
				uIntPtr = default(UIntPtr);
				checked
				{
					nuint num3 = uIntPtr + unchecked((nuint)(UIntPtr)Cq8.Default) + uIntPtr;
					uIntPtr = default(UIntPtr);
					if (num2 + unchecked(num3 / uIntPtr) == 0)
					{
						_ = (d5W)(object)Cq8.Default;
						tr = null;
						_ = (Gj7)(object)Aj8.Cm3(array, null, num);
						unchecked
						{
							_ = (Lw6)(object)Aj8.Cm3(array, Aj8.Cm3(Aj8.Cm3(array, (byte[])(object)Cq8.Default, num), array, (int)Cq8.Default), (int)checked(2625256168u - unchecked((uint)num)));
						}
					}
					goto IL_1117;
				}
			}
		}
		goto IL_1117;
		IL_0a18:
		try
		{
			_ = (Kz1)(object)Aj8.Cm3(array, null, num);
		}
		catch
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (y0D)(object)Cq8.Default;
				}
			}
			catch
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = Cq8.Default;
				}
			}
		}
		do
		{
			_ = (Aj8)(object)Cq8.Default;
		}
		while (obj2 != null);
		while (obj2 != null)
		{
			try
			{
				try
				{
					lw = (Lw6)(object)Aj8.Cm3(null, (byte[])(object)Cq8.Default, num);
				}
				finally
				{
					y6Z = y6Z;
					goto end_IL_0a81;
				}
				end_IL_0a81:;
			}
			finally
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (_003CModule_003E)(object)Cq8.Default;
				}
				continue;
			}
		}
		while (obj2 != null)
		{
			z3X2 = z3X2;
			z3X2 = z3X2;
			_ = Cq8.Default;
			kj = kj;
		}
		_003CModule_003E = _003CModule_003E;
		_ = (y6Z)(object)Aj8.Cm3(null, array, num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d5W d5W);
		while (obj2 != null)
		{
			uIntPtr = default(UIntPtr);
			if (checked(uIntPtr * uIntPtr) == 0)
			{
				try
				{
					_ = (Kj1)Cq8.Default;
				}
				catch
				{
					d5W obj21 = (d5W)(object)Aj8.Cm3(null, null, (int)Cq8.Default);
					d5W = (d5W)(object)Aj8.Cm3(null, array, (int)(3248675190u / (uint)(int)Cq8.Default));
					d5W = obj21;
				}
			}
		}
		try
		{
			try
			{
				_ = (Lw6)(object)Cq8.Default;
			}
			finally
			{
				try
				{
					y6Z = null;
				}
				finally
				{
					gj = (Gj7)(object)Aj8.Cm3(null, Aj8.Cm3(array, array, -906092485), (int)Aj8.Cm3(array, array, (int)Aj8.Cm3(array, array, 1291005267)));
					goto end_IL_0b77;
				}
			}
			end_IL_0b77:;
		}
		finally
		{
			do
			{
				kz = (Kz1)(object)Cq8.Default;
			}
			while (obj2 != null);
			goto IL_0c1a;
		}
		IL_12ce:
		_ = (y6Z)(object)Cq8.Default;
		_ = (Cq8)(object)Aj8.Cm3(array, array, 318916226);
		wj = (Wj3)(object)Aj8.Cm3(array, array, -261867319);
		while (obj2 != null)
		{
			if (uIntPtr == 0)
			{
				_ = (_003CModule_003E)(object)Aj8.Cm3(array, null, (int)Aj8.Cm3(array, array, 1906037671));
			}
		}
		try
		{
			gj = (Gj7)(object)Aj8.Cm3(array, array, (int)Cq8.Default);
		}
		finally
		{
			checked
			{
				if (unchecked((nuint)(UIntPtr)Aj8.Cm3(array, array, (int)checked(unchecked((uint)num) + 3034008869u))) - unchecked((nuint)(UIntPtr)Cq8.Default) == 0)
				{
					gj = gj;
				}
				else
				{
					_ = Cq8.Default;
				}
				goto IL_13a3;
			}
		}
		IL_0c1a:
		checked
		{
			do
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr + unchecked((nuint)(UIntPtr)Aj8.Cm3(array, array, num)) == 0)
				{
					do
					{
						_ = (Kj1)Cq8.Default;
					}
					while (obj2 != null);
				}
			}
			while ((object)Cq8.Default != null);
		}
		if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
		{
			aj = aj;
			goto IL_0c96;
		}
		try
		{
			while (obj2 != null)
			{
				_ = (z3X)(object)Aj8.Cm3(array, array, num);
			}
		}
		finally
		{
			_ = (y6Z)(object)Aj8.Cm3(array, array, -750962933);
			goto IL_0c96;
		}
		IL_1117:
		_ = (d5W)(object)Aj8.Cm3(null, array, (int)Cq8.Default);
		tr = tr;
		do
		{
			try
			{
				d5W = d5W;
				_ = (Lw6)(object)Cq8.Default;
				cq = Cq8.Default;
				kj = default(Kj1);
			}
			catch
			{
				y6Z = null;
			}
		}
		while (obj2 != null || obj2 != null);
		do
		{
			aj = aj;
		}
		while (obj2 != null);
		_ = (y0D)(object)Aj8.Cm3(Aj8.Cm3(null, (byte[])(object)Cq8.Default, (int)checked(unchecked((uint)num) * unchecked((uint)(int)Cq8.Default))), null, 40158854);
		y6Z = y6Z;
		aj = null;
		_ = (y0D)(object)Aj8.Cm3(array, Aj8.Cm3(array, array, num), num);
		while ((object)Aj8.Cm3(null, array, (int)(checked(2686543277u + (unchecked((uint)(int)Aj8.Cm3(null, (byte[])(object)Cq8.Default, -518488208)) + unchecked((uint)(int)Cq8.Default)) - unchecked((uint)(int)Aj8.Cm3(array, array, num))) / (uint)(int)Cq8.Default)) != null)
		{
			try
			{
				try
				{
					gj = gj;
				}
				catch
				{
					d2N = d2N;
				}
			}
			catch
			{
				while (obj2 != null)
				{
					z3X2 = (z3X)(object)Cq8.Default;
				}
			}
		}
		if (uIntPtr == 0)
		{
			try
			{
				_ = (d5W)(object)Aj8.Cm3(array, array, num);
			}
			finally
			{
				kj = (Kj1)Aj8.Cm3(array, null, 109600438);
				goto IL_12ce;
			}
		}
		goto IL_12ce;
		IL_0c96:
		try
		{
			wj = wj;
		}
		catch
		{
			_ = (z3X)(object)Aj8.Cm3(array, array, (int)Cq8.Default);
		}
		do
		{
			try
			{
				y6Z = null;
			}
			catch
			{
				gj = (Gj7)(object)Aj8.Cm3(array, (byte[])(object)Cq8.Default, num);
			}
		}
		while ((object)Aj8.Cm3(null, array, (int)checked((unchecked((uint)(int)Cq8.Default) - 437476352u + 6083026u) * unchecked((uint)num))) != null);
		try
		{
			try
			{
				kj = kj;
			}
			finally
			{
				_ = (Wj3)(object)Aj8.Cm3(Aj8.Cm3((byte[])(object)Cq8.Default, array, -804411485), null, num);
				_ = (d2N)Cq8.Default;
				c2M = null;
				_ = (z3X)(object)Aj8.Cm3(array, array, (int)checked(unchecked((uint)(int)Cq8.Default) * 3901927016u * unchecked(checked(unchecked((uint)num) - unchecked((uint)(int)Cq8.Default)) / (uint)num)));
				goto end_IL_0d1b;
			}
			end_IL_0d1b:;
		}
		catch
		{
			try
			{
				_ = (Kz1)(object)Cq8.Default;
				_ = (Kj1)Aj8.Cm3(null, null, (int)checked(unchecked((uint)num) - unchecked((uint)(int)Cq8.Default)));
				_ = (Lw6)(object)Aj8.Cm3((byte[])(object)Cq8.Default, (byte[])(object)Cq8.Default, (int)Cq8.Default);
			}
			catch
			{
				y0D = y0D;
			}
		}
		try
		{
			_ = (n9L)(object)Aj8.Cm3((byte[])(object)Cq8.Default, array, -1230828124);
		}
		catch
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				do
				{
					y6Z = y6Z;
				}
				while (obj2 != null);
			}
		}
		do
		{
			try
			{
				try
				{
					tr = tr;
				}
				finally
				{
					_ = (Tr3)(object)Cq8.Default;
					tr = null;
					_ = (Kz1)(object)Cq8.Default;
					_ = (Lw6)(object)Aj8.Cm3(array, array, (int)checked(1245644078u - unchecked((uint)(int)Cq8.Default)));
					goto end_IL_0e47;
				}
				end_IL_0e47:;
			}
			catch
			{
				try
				{
					_ = (Aj8)(object)Aj8.Cm3(null, array, num);
				}
				catch
				{
					gj = null;
					lw = (Lw6)(object)Cq8.Default;
					_ = (Kj1)Cq8.Default;
					_ = (Gj7)(object)Cq8.Default;
				}
			}
		}
		while (obj2 != null);
		do
		{
			if (uIntPtr != 0)
			{
				try
				{
					kz = (Kz1)(object)Aj8.Cm3(Aj8.Cm3((byte[])(object)Cq8.Default, null, (int)Cq8.Default), array, (int)Aj8.Cm3(array, Aj8.Cm3(null, array, 1363697825), (int)Aj8.Cm3(array, array, -1077051043)));
					_ = (Gj7)(object)Cq8.Default;
					_ = (Kj1)Aj8.Cm3(null, null, (int)Aj8.Cm3(array, (byte[])(object)Cq8.Default, 2140435402));
					z3X2 = null;
				}
				catch
				{
					kj = kj;
					y0D = y0D;
					_ = (z3X)(object)Aj8.Cm3(array, Aj8.Cm3(Aj8.Cm3(array, null, 969411395), null, -2069969438), (int)Cq8.Default);
					_ = (z3X)(object)Aj8.Cm3(array, Aj8.Cm3(null, array, -1744514447), (int)checked(1863595088u + unchecked((uint)num)));
				}
			}
			else
			{
				try
				{
					_ = (Gj7)(object)Cq8.Default;
				}
				catch
				{
					d2N = d2N;
					kz = kz;
				}
			}
		}
		while (obj2 != null);
		try
		{
			wj = wj;
		}
		finally
		{
			goto IL_104a;
		}
	}

	static void Mc1()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y0D y0D);
		try
		{
			y0D = null;
			y0D = y0D;
		}
		finally
		{
			while ((object)Cq8.Default != null)
			{
				try
				{
					byte[] ko = array;
					num = (int)checked(unchecked((uint)(int)Aj8.Cm3(array, (byte[])(object)Cq8.Default, num)) + 2557852619u);
					array = Aj8.Cm3(null, ko, (int)checked(unchecked((uint)num) * unchecked((uint)(int)Cq8.Default) - unchecked((uint)(int)Aj8.Cm3(null, null, num))));
					_ = (_003CModule_003E)(object)Aj8.Cm3(null, array, (int)Cq8.Default);
				}
				catch
				{
					_ = (Kj1)Cq8.Default;
				}
			}
			goto IL_0083;
		}
		IL_0083:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Kj1 kj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d2N d2N);
		if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
		{
			_ = (Wj3)(object)Aj8.Cm3(null, array, num);
			obj2 = null;
		}
		else
		{
			num2 = num2;
			num2 = default(UIntPtr);
			if (num2 == 0)
			{
				do
				{
					Kj1 obj3 = (Kj1)Cq8.Default;
					kj = kj;
					kj = obj3;
					d2N = d2N;
					d2N = d2N;
				}
				while (obj2 != null);
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y6Z y6Z);
		try
		{
			if ((UIntPtr)Aj8.Cm3(array, null, (int)checked(unchecked((uint)num) * unchecked((uint)(int)Aj8.Cm3(array, array, (int)Cq8.Default)))) == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)Aj8.Cm3(array, array, (int)Aj8.Cm3(array, null, num)) == (UIntPtr)(nuint)0u)
				{
					_ = (Lw6)(object)Aj8.Cm3(array, null, (int)Aj8.Cm3(array, array, 649999742));
				}
			}
			else if (num2 == 0)
			{
				_ = (Aj8)(object)Aj8.Cm3(array, Aj8.Cm3(null, array, (int)Cq8.Default), (int)Aj8.Cm3((byte[])(object)Cq8.Default, Aj8.Cm3(null, array, num), (int)Cq8.Default));
			}
		}
		catch
		{
			try
			{
				_ = (Wj3)(object)Cq8.Default;
			}
			finally
			{
				y6Z = null;
				y6Z = null;
				goto end_IL_0181;
			}
			end_IL_0181:;
		}
		d5W d5W = null;
		d5W = d5W;
		while ((object)Cq8.Default != null)
		{
			y6Z = ((num2 != 0) ? y6Z : ((y6Z)(object)Aj8.Cm3(Aj8.Cm3((byte[])(object)Cq8.Default, Aj8.Cm3(null, array, (int)Aj8.Cm3(null, null, -1069115236)), (int)checked(unchecked((uint)num) - (unchecked((uint)(int)Aj8.Cm3(array, array, num)) + unchecked((uint)num)))), null, num)));
		}
		z3X z3X2 = null;
		z3X2 = z3X2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Aj8 aj);
		try
		{
			try
			{
				Lw6 lw = lw;
				lw = lw;
			}
			catch
			{
				aj = null;
				aj = aj;
			}
		}
		catch
		{
			if (checked((num2 - unchecked((nuint)(UIntPtr)Aj8.Cm3(array, Aj8.Cm3(array, array, (int)checked(unchecked((uint)num) * 1513277825u)), (int)checked(2917903243u - 3866890745u)))) * num2) == 0)
			{
				do
				{
					_ = (z3X)(object)Aj8.Cm3(array, array, (int)Aj8.Cm3((byte[])(object)Cq8.Default, null, 1442764197));
				}
				while (obj2 != null);
			}
			else
			{
				try
				{
					_ = (c2M)(object)Aj8.Cm3(null, array, num);
				}
				catch
				{
					_ = (y6Z)(object)Cq8.Default;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n9L n9L);
		try
		{
			try
			{
				do
				{
					_ = (y6Z)(object)Cq8.Default;
					_ = (d2N)Cq8.Default;
					_ = (Kj1)Cq8.Default;
				}
				while (obj2 != null);
			}
			catch
			{
				if (num2 == 0)
				{
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = null;
				}
			}
		}
		catch
		{
			n9L = null;
			n9L = n9L;
		}
		num2 = default(UIntPtr);
		if (num2 == 0)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Tr3 tr);
			do
			{
				try
				{
					_ = (d2N)Aj8.Cm3(Aj8.Cm3(null, null, num), null, (int)Aj8.Cm3(array, array, (int)checked(1196598168u - (unchecked((uint)num) + unchecked((uint)(int)Aj8.Cm3(array, Aj8.Cm3(array, array, (int)checked(3589967316u + (unchecked((uint)num / (uint)num) + 1826947634u - unchecked((uint)num)))), (int)Aj8.Cm3(Aj8.Cm3(null, null, (int)checked(1277436567u + unchecked((uint)(int)Aj8.Cm3(array, null, -1012434247)))), array, (int)Cq8.Default)))))));
				}
				catch
				{
					_003CModule_003E = _003CModule_003E;
					_ = (y6Z)(object)Cq8.Default;
					kj = default(Kj1);
					tr = tr;
					tr = null;
				}
			}
			while ((object)Cq8.Default != null);
		}
		checked
		{
			while ((object)Cq8.Default != null)
			{
				if (num2 - unchecked((nuint)(UIntPtr)Aj8.Cm3(array, null, (int)Cq8.Default)) == 0)
				{
					unchecked
					{
						try
						{
							_ = (c2M)(object)Aj8.Cm3(null, array, (int)checked(unchecked((uint)num) + unchecked((uint)num)));
						}
						catch
						{
							_ = (Tr3)(object)Cq8.Default;
						}
					}
				}
			}
			try
			{
				if (num2 * (unchecked((nuint)(UIntPtr)Cq8.Default) + num2) == 0)
				{
					_ = (y6Z)(object)Aj8.Cm3(array, array, num);
				}
			}
			finally
			{
				z3X2 = z3X2;
				goto IL_042c;
			}
		}
		IL_042c:
		if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
		{
			while ((object)Aj8.Cm3((byte[])(object)Cq8.Default, array, num) != null)
			{
				d2N = d2N;
			}
		}
		Kz1 kz = kz;
		kz = kz;
		while (obj2 != null)
		{
			do
			{
				_ = (Gj7)(object)Aj8.Cm3(Aj8.Cm3(array, (byte[])(object)Cq8.Default, num), array, 287447205);
			}
			while ((object)Aj8.Cm3(null, Aj8.Cm3(Aj8.Cm3(array, null, (int)Aj8.Cm3((byte[])(object)Cq8.Default, array, -1457073573)), array, (int)Cq8.Default), (int)Aj8.Cm3(array, null, (int)checked(2255712657u + unchecked((uint)(int)Cq8.Default)))) != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cq8 cq);
		do
		{
			try
			{
				do
				{
					kj = default(Kj1);
					kj = kj;
				}
				while (obj2 != null);
			}
			finally
			{
				cq = cq;
				cq = null;
				_ = Cq8.Default;
				z3X2 = (z3X)(object)Aj8.Cm3(array, array, -1795914692);
				continue;
			}
		}
		while ((object)Aj8.Cm3(array, Aj8.Cm3(array, (byte[])(object)Cq8.Default, 856224649), (int)checked(unchecked((uint)num) + unchecked((uint)num))) != null);
		try
		{
			cq = cq;
		}
		finally
		{
			if (num2 == 0)
			{
				_ = (d2N)Aj8.Cm3(array, null, 791453204);
			}
			goto IL_0579;
		}
		IL_0f03:
		try
		{
			try
			{
				kz = null;
			}
			finally
			{
				y0D = null;
				d5W = null;
				goto end_IL_0f04;
			}
			end_IL_0f04:;
		}
		finally
		{
			while ((object)Aj8.Cm3(Aj8.Cm3(array, null, num), array, 158339505) != null)
			{
				Lw6 lw = (Lw6)(object)Cq8.Default;
			}
			goto IL_0f43;
		}
		IL_0fdf:
		_ = (Tr3)(object)Cq8.Default;
		_ = Cq8.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Gj7 gj);
		if (num2 == 0)
		{
			try
			{
				if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
				{
					gj = null;
				}
			}
			finally
			{
				while (obj2 != null)
				{
					Tr3 tr = null;
				}
				goto IL_1015;
			}
		}
		goto IL_1015;
		IL_068e:
		try
		{
			num2 = default(UIntPtr);
			if (num2 == 0)
			{
				UIntPtr num3 = (UIntPtr)Aj8.Cm3(array, array, (int)Cq8.Default);
				nuint num4 = num2;
				UIntPtr num5 = (UIntPtr)Cq8.Default;
				num2 = default(UIntPtr);
				checked
				{
					if (unchecked((nuint)num3) + (num4 - (unchecked((nuint)num5) + num2)) == 0)
					{
						_ = (d2N)Aj8.Cm3(array, array, 358944556);
					}
				}
			}
		}
		finally
		{
			try
			{
				if (num2 == 0)
				{
					d5W = null;
				}
				else
				{
					aj = aj;
				}
			}
			finally
			{
				if (checked(num2 + num2) == 0)
				{
					_ = (y0D)(object)Aj8.Cm3(Aj8.Cm3(Aj8.Cm3(Aj8.Cm3(Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)checked(3635890476u - unchecked((uint)num))), array, (int)Cq8.Default), array, (int)((uint)(int)Aj8.Cm3(null, array, (int)Cq8.Default) / 4059750232u)), array, (int)Aj8.Cm3(array, null, (int)Cq8.Default)), null, (int)Cq8.Default);
				}
				else
				{
					z3X2 = z3X2;
					_ = (d5W)(object)Cq8.Default;
				}
				goto IL_07a4;
			}
		}
		IL_07a4:
		if ((UIntPtr)Aj8.Cm3(null, (byte[])(object)Cq8.Default, num) == (UIntPtr)(nuint)0u)
		{
			_ = (d5W)(object)Cq8.Default;
		}
		else
		{
			while (obj2 != null)
			{
				do
				{
					_ = (Wj3)(object)Aj8.Cm3(array, Aj8.Cm3(Aj8.Cm3(null, Aj8.Cm3(null, null, (int)Aj8.Cm3(Aj8.Cm3(Aj8.Cm3(Aj8.Cm3((byte[])(object)Cq8.Default, array, 1646733957), array, (int)checked(441783641u * 2111446603u)), null, num), (byte[])(object)Cq8.Default, (int)checked(3026138450u * unchecked((uint)(int)Cq8.Default)))), (int)Aj8.Cm3(array, array, 787052409)), null, (int)Cq8.Default), num);
				}
				while (obj2 != null);
			}
		}
		while (obj2 != null)
		{
			d5W = d5W;
		}
		try
		{
			num2 = default(UIntPtr);
			if (num2 == 0)
			{
				try
				{
					aj = (Aj8)(object)Aj8.Cm3((byte[])(object)Cq8.Default, array, (int)checked(3274828666u + 2292881709u));
				}
				catch
				{
					n9L = n9L;
				}
			}
			else
			{
				while (obj2 != null)
				{
					_ = (c2M)(object)Aj8.Cm3(null, Aj8.Cm3(null, Aj8.Cm3(null, (byte[])(object)Cq8.Default, -123528784), (int)checked(unchecked((uint)(int)Aj8.Cm3(array, array, (int)Aj8.Cm3(array, array, num))) + unchecked((uint)(int)Aj8.Cm3((byte[])(object)Cq8.Default, array, (int)Cq8.Default)) * 1332928937u)), num);
				}
			}
		}
		finally
		{
			cq = Cq8.Default;
			_ = (z3X)(object)Cq8.Default;
			_ = (z3X)(object)Aj8.Cm3(array, array, -1423257270);
			_ = (_003CModule_003E)(object)Aj8.Cm3(array, null, -6571587);
			goto IL_097b;
		}
		IL_0a35:
		Gj7 obj13 = (Gj7)(object)Aj8.Cm3(array, Aj8.Cm3(array, (byte[])(object)Cq8.Default, 87862314), (int)checked(1566961354u - (unchecked((uint)(int)Cq8.Default) - 1148266686u)));
		gj = gj;
		gj = obj13;
		checked
		{
			if (num2 == 0)
			{
				nuint num6 = unchecked((nuint)(UIntPtr)Cq8.Default) * unchecked((nuint)default(UIntPtr));
				num2 = default(UIntPtr);
				if (num6 * (num2 * (num2 * num2)) == 0)
				{
					while (obj2 != null)
					{
						_ = (c2M)(object)Aj8.Cm3(null, null, unchecked((int)Aj8.Cm3(array, array, 612198699)));
					}
				}
			}
		}
		while ((object)Aj8.Cm3(array, null, 359497004) != null)
		{
			if (num2 == 0)
			{
				do
				{
					_ = (Tr3)(object)Aj8.Cm3(null, array, (int)checked(2857399059u * 2207667367u));
				}
				while ((object)Aj8.Cm3(null, array, (int)checked(unchecked((uint)num) - unchecked((uint)(int)Aj8.Cm3(array, null, (int)checked(unchecked((uint)(int)Cq8.Default) - (unchecked((uint)(int)Cq8.Default) + 2837572804u) - unchecked((uint)(int)Aj8.Cm3(null, array, num))))))) != null);
			}
			else
			{
				while ((object)Aj8.Cm3(array, array, -215461207) != null)
				{
					_ = (_003CModule_003E)(object)Cq8.Default;
				}
			}
		}
		while (true)
		{
			if (obj2 != null)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (y6Z)(object)Cq8.Default;
				}
				else
				{
					_ = (c2M)(object)Cq8.Default;
				}
			}
			else if (obj2 == null)
			{
				break;
			}
		}
		try
		{
			while (obj2 != null)
			{
				try
				{
					kj = kj;
				}
				finally
				{
					z3X2 = (z3X)(object)Cq8.Default;
					continue;
				}
			}
		}
		catch
		{
			if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
			{
				while (obj2 != null)
				{
					kj = kj;
				}
			}
			else
			{
				d2N = default(d2N);
			}
		}
		_ = (y0D)(object)Cq8.Default;
		try
		{
			while (obj2 != null)
			{
				gj = (Gj7)(object)Cq8.Default;
			}
		}
		finally
		{
			aj = null;
			goto IL_0c0d;
		}
		IL_1015:
		try
		{
			try
			{
				_ = (Kj1)Aj8.Cm3(null, (byte[])(object)Cq8.Default, num);
			}
			catch
			{
				y0D = (y0D)(object)Cq8.Default;
				kz = kz;
				z3X2 = null;
				_ = (Wj3)(object)Aj8.Cm3(array, Aj8.Cm3((byte[])(object)Cq8.Default, array, -1679717216), 806969762);
			}
			finally
			{
				num2 = default(UIntPtr);
				if (num2 == 0)
				{
					z3X2 = z3X2;
					_ = (Kz1)(object)Aj8.Cm3(array, array, num);
				}
				goto end_IL_1016;
			}
			end_IL_1016:;
		}
		finally
		{
			if (num2 == 0)
			{
				num2 = default(UIntPtr);
				if (num2 == 0)
				{
					_ = (Tr3)(object)Aj8.Cm3((byte[])(object)Cq8.Default, Aj8.Cm3(null, (byte[])(object)Cq8.Default, (int)checked(unchecked((uint)(int)Cq8.Default) + unchecked((uint)(int)Aj8.Cm3(array, array, (int)checked(unchecked((uint)num) * (unchecked((uint)(int)Cq8.Default) - (1643902787u + unchecked((uint)(int)Cq8.Default)) - unchecked((uint)(int)Cq8.Default))))))), 667132825);
				}
				else
				{
					_ = Cq8.Default;
				}
			}
			else
			{
				num2 = default(UIntPtr);
				if (num2 / (nuint)(UIntPtr)Cq8.Default == 0)
				{
					n9L = (n9L)(object)Aj8.Cm3(array, (byte[])(object)Cq8.Default, -1490488934);
				}
			}
			goto IL_115d;
		}
		IL_115d:
		if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
		{
			while (obj2 != null)
			{
				kz = kz;
				_003CModule_003E = _003CModule_003E;
				_ = (z3X)(object)Cq8.Default;
			}
		}
		while (obj2 != null)
		{
			try
			{
				if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
				{
					Tr3 tr = null;
				}
				else
				{
					_ = (Gj7)(object)Aj8.Cm3(array, array, num);
				}
			}
			catch
			{
			}
		}
		try
		{
			return;
		}
		catch
		{
			do
			{
				if (num2 != 0)
				{
					_ = (Cq8)(object)Aj8.Cm3(array, array, (int)Aj8.Cm3(array, array, (int)(2380987983u / (uint)(int)Aj8.Cm3(null, (byte[])(object)Cq8.Default, -1455232615))));
				}
				else
				{
					gj = gj;
				}
			}
			while (obj2 != null);
			return;
		}
		IL_0c0d:
		while (obj2 != null)
		{
			while (obj2 != null)
			{
				while (obj2 != null)
				{
					_ = (Kj1)Cq8.Default;
				}
			}
		}
		num2 = default(UIntPtr);
		nuint num7;
		nuint num8;
		nuint num10;
		nuint num11;
		checked
		{
			num7 = num2 + num2;
			num8 = num2;
			nuint num9 = unchecked((nuint)(UIntPtr)Aj8.Cm3(null, array, 212416462)) * (unchecked((nuint)(UIntPtr)Aj8.Cm3(array, array, (int)Aj8.Cm3(array, null, 1033825322))) + unchecked((nuint)(UIntPtr)Aj8.Cm3(array, null, 1307429673)) * unchecked((nuint)default(UIntPtr)) - unchecked((nuint)(UIntPtr)Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)checked(unchecked((uint)num) * 4093003766u))));
			num2 = default(UIntPtr);
			num10 = num9 * num2;
			num11 = num2;
		}
		UIntPtr num12 = (UIntPtr)Aj8.Cm3(Aj8.Cm3(array, array, -2068693063), array, (int)((uint)(int)Cq8.Default / (uint)(int)Aj8.Cm3(array, Aj8.Cm3(array, Aj8.Cm3(array, array, (int)Cq8.Default), (int)checked(unchecked((uint)(int)Cq8.Default) - unchecked((uint)(int)Cq8.Default))), (int)Aj8.Cm3(null, array, 200634763))));
		UIntPtr num13 = (UIntPtr)Aj8.Cm3(array, array, num);
		num2 = default(UIntPtr);
		UIntPtr num14 = num2;
		UIntPtr num15 = num2;
		num2 = default(UIntPtr);
		checked
		{
			nuint num16 = unchecked((nuint)num13) + (unchecked((nuint)num14) - unchecked((nuint)num15) * num2);
			nuint num17 = num2;
			num2 = default(UIntPtr);
			if (unchecked((nuint)default(UIntPtr)) - unchecked(num7 / checked(num8 * unchecked(checked(num10 - (unchecked(num11 / checked(unchecked((nuint)num12) + (num16 + num17 * num2))) + unchecked((nuint)(UIntPtr)Cq8.Default))) / checked(num2 - unchecked((nuint)(UIntPtr)Aj8.Cm3(array, array, num))) / num2) - (num2 + num2))) == 0)
			{
				_ = (d2N)Cq8.Default;
			}
			else
			{
				while (obj2 != null)
				{
					try
					{
						kj = kj;
					}
					catch
					{
						d5W = (d5W)(object)Aj8.Cm3(null, null, unchecked((int)Cq8.Default));
					}
				}
			}
			gj = gj;
			_ = (_003CModule_003E)(object)Aj8.Cm3(array, array, 56013437);
			_ = (Aj8)(object)Cq8.Default;
			y6Z = null;
		}
		do
		{
			try
			{
				try
				{
					aj = (Aj8)(object)Aj8.Cm3((byte[])(object)Cq8.Default, (byte[])(object)Cq8.Default, num);
				}
				finally
				{
					n9L = (n9L)(object)Cq8.Default;
					goto end_IL_0dd0;
				}
				end_IL_0dd0:;
			}
			finally
			{
				try
				{
					_ = (Gj7)(object)Cq8.Default;
				}
				finally
				{
					_ = (n9L)(object)Aj8.Cm3(null, array, (int)Cq8.Default);
					continue;
				}
			}
		}
		while (obj2 != null);
		z3X2 = z3X2;
		_003CModule_003E = _003CModule_003E;
		try
		{
			while (obj2 != null)
			{
				if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
				{
					_ = (n9L)(object)Cq8.Default;
				}
				else
				{
					Lw6 lw = (Lw6)(object)Cq8.Default;
				}
			}
		}
		catch
		{
			_ = (Aj8)(object)Aj8.Cm3((byte[])(object)Cq8.Default, array, (int)checked(407452217u * (unchecked((uint)num) - unchecked((uint)(int)Cq8.Default))));
		}
		_ = (Aj8)(object)Cq8.Default;
		try
		{
			do
			{
				if (num2 / (nuint)(UIntPtr)Aj8.Cm3(array, null, 1851173627) / num2 == 0)
				{
					Tr3 tr = (Tr3)(object)Aj8.Cm3(array, array, (int)checked(unchecked((uint)num / checked(1284317494u - unchecked((uint)(int)Aj8.Cm3((byte[])(object)Cq8.Default, array, (int)Cq8.Default)))) * 1322612066u));
				}
			}
			while (obj2 != null);
		}
		finally
		{
			kz = kz;
			goto IL_0f03;
		}
		IL_097b:
		d2N = (d2N)Cq8.Default;
		cq = Cq8.Default;
		while (obj2 != null)
		{
			if ((UIntPtr)Cq8.Default == (UIntPtr)(nuint)0u)
			{
				_ = (z3X)(object)Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)(checked(unchecked((uint)num) + unchecked((uint)num)) / (uint)num));
				_ = (Wj3)(object)Cq8.Default;
				kz = kz;
			}
		}
		try
		{
			y6Z = null;
			n9L = (n9L)(object)Aj8.Cm3(null, (byte[])(object)Cq8.Default, (int)checked(unchecked((uint)num / checked(unchecked((uint)num) + unchecked((uint)(int)Aj8.Cm3(array, array, num)))) * unchecked((uint)(int)Aj8.Cm3(array, array, 588893503))));
			n9L = null;
		}
		finally
		{
			_ = (y0D)(object)Aj8.Cm3(array, null, (int)checked(unchecked((uint)(int)Cq8.Default) * unchecked((uint)(int)Cq8.Default)));
			goto IL_0a35;
		}
		IL_0f43:
		_ = (n9L)(object)Aj8.Cm3(array, Aj8.Cm3(array, array, -1679684755), (int)(2275160576u / (uint)(int)Cq8.Default));
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
			num2 = default(UIntPtr);
			if (num2 == 0)
			{
				do
				{
					_ = Cq8.Default;
				}
				while ((object)Cq8.Default != null);
			}
		}
		try
		{
			do
			{
				if ((UIntPtr)Aj8.Cm3(array, null, num) == (UIntPtr)(nuint)0u)
				{
					_003CModule_003E = _003CModule_003E;
				}
			}
			while (obj2 != null);
		}
		finally
		{
			_ = (Tr3)(object)Cq8.Default;
			goto IL_0fdf;
		}
		IL_0579:
		try
		{
			while (obj2 != null)
			{
				y0D = y0D;
			}
		}
		catch
		{
			while ((object)Cq8.Default != null)
			{
				while ((object)Aj8.Cm3(null, Aj8.Cm3(array, null, (int)((uint)num / ((uint)num / (uint)(int)Aj8.Cm3(array, array, (int)checked(unchecked((uint)(int)Cq8.Default) - 2990429494u))) / (uint)num)), (int)Aj8.Cm3(array, Aj8.Cm3(array, array, (int)checked(unchecked(1068623497u / 0u) * (750789984u - (1117424652u - 1780714809u + unchecked((uint)(int)Aj8.Cm3(array, Aj8.Cm3(array, (byte[])(object)Cq8.Default, (int)Aj8.Cm3(array, null, (int)Cq8.Default)), (int)checked(18220381u * unchecked((uint)(int)Cq8.Default)))))))), num)) != null)
				{
					_ = (z3X)(object)Aj8.Cm3(null, array, num);
				}
			}
		}
		try
		{
			_ = (Wj3)(object)Aj8.Cm3(null, array, num);
		}
		finally
		{
			num2 = default(UIntPtr);
			if (num2 == 0)
			{
				if (num2 == 0)
				{
					_003CModule_003E = _003CModule_003E;
				}
				else
				{
					z3X2 = null;
				}
			}
			goto IL_068e;
		}
	}
}
