using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Threading;
using ckY26PEfAXL4J;
using ckY26PEfAXL4J.Properties;

namespace U;

internal sealed class D
{
	static void MEEPP4()
	{
		//IL_0002: Expected O, but got I4
		//IL_0014: Expected O, but got I4
		//IL_001f: Expected O, but got I4
		//IL_0029: Expected O, but got I4
		//IL_003e: Expected O, but got I4
		//IL_0049: Expected O, but got I4
		//IL_005d: Expected O, but got I4
		//IL_0067: Expected O, but got I4
		//IL_006f: Expected O, but got I4
		string text = (string)0;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Settings settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint uIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out v v2);
		while ((nint)text != 8)
		{
			if ((nint)text == 3)
			{
				uIntPtr = default(UIntPtr);
				text = (string)4;
			}
			if ((nint)text == 2)
			{
				if (uIntPtr != (UIntPtr)(nuint)0u)
				{
					goto IL_007e;
				}
				text = (string)3;
			}
			if ((nint)text == 1)
			{
				uIntPtr = uIntPtr;
				text = (string)2;
			}
			if ((nint)text == 7)
			{
				if ((object)((Settings)null).Setting != null)
				{
					goto IL_0063;
				}
				text = (string)8;
			}
			if ((nint)text == 4)
			{
				if (uIntPtr != (UIntPtr)(nuint)0u)
				{
					break;
				}
				text = (string)5;
			}
			if ((nint)text == 6)
			{
				_ = (a)(object)settings.Setting;
				text = (string)7;
			}
			if ((nint)text == 5)
			{
				goto IL_0063;
			}
			goto IL_0067;
			IL_007e:
			try
			{
				do
				{
					_ = (k)(object)((Settings)null).Setting;
					obj = obj;
				}
				while (obj != null);
			}
			finally
			{
				try
				{
					text2 = text2;
					v obj2 = (v)(object)O.r(text2);
					v2 = v2;
					v2 = obj2;
				}
				catch
				{
					_ = (y)(object)O.r(text2);
				}
				break;
			}
			IL_0067:
			if (text == null)
			{
				text = (string)1;
			}
			if ((nint)text != 9)
			{
				continue;
			}
			goto IL_007e;
			IL_0063:
			settings = settings;
			text = (string)6;
			goto IL_0067;
		}
		UIntPtr num = uIntPtr;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		D d;
		checked
		{
			nuint num2 = unchecked((nuint)num) + (uIntPtr + uIntPtr);
			uIntPtr = default(UIntPtr);
			if (num2 - uIntPtr == 0)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					v2 = (v)(object)O.r(text2);
				}
			}
			else if (unchecked((nuint)(UIntPtr)s.W(null)) + uIntPtr == 0)
			{
				if (unchecked((UIntPtr)Settings.Default == (UIntPtr)(nuint)0u))
				{
					_ = (Settings)(object)((Settings)null).Setting;
				}
				else
				{
					_ = (h)(object)((Settings)null).Setting;
				}
			}
			v2 = v2;
			s s2 = s2;
			s2 = s2;
			array = array;
			_ = (Resources)(object)s.W(array);
			d = null;
			d = d;
			settings = settings;
			if (uIntPtr == 0)
			{
				try
				{
					_ = (p)(object)O.r(text2);
				}
				finally
				{
					System.Runtime.CompilerServices.Unsafe.SkipInit(out Form1 form);
					do
					{
						form = form;
						form = form;
						_ = (x)Settings.Default;
						_ = (x)Settings.Default;
						_ = (h)(object)s.W((byte[])(object)((Settings)null).Setting);
					}
					while ((object)s.W(null) != null);
					goto IL_01c1;
				}
			}
			try
			{
				_ = (x)O.r(text2);
			}
			catch
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out J j);
				do
				{
					j = j;
					j = j;
				}
				while (obj != null);
			}
			goto IL_01c1;
		}
		IL_044b:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Resources resources);
		do
		{
			resources = resources;
			resources = null;
			_ = (J)(object)((Settings)(object)s.W(array)).Setting;
		}
		while (obj != null || obj != null || obj != null);
		while ((object)s.W((byte[])(object)Settings.Default) != null)
		{
			if ((UIntPtr)Settings.Default == (UIntPtr)(nuint)0u)
			{
				resources = resources;
			}
			else
			{
				_ = (k)(object)s.W(array);
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out e e2);
		while (obj != null)
		{
			do
			{
				try
				{
					e2 = e2;
				}
				finally
				{
					resources = resources;
					continue;
				}
			}
			while ((object)Settings.Default != null);
		}
		uIntPtr = default(UIntPtr);
		nuint num3;
		nuint num4;
		checked
		{
			num3 = uIntPtr * uIntPtr - unchecked((nuint)default(UIntPtr));
			num4 = unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr));
		}
		UIntPtr num5 = (UIntPtr)O.r(text2);
		uIntPtr = default(UIntPtr);
		if (num3 / (num4 / checked(unchecked((nuint)num5) * uIntPtr)) == 0)
		{
			e2 = (e)O.r(text2);
		}
		C c = (C)(object)Settings.Default;
		checked
		{
			if (uIntPtr * unchecked((nuint)(UIntPtr)O.r(text2)) != 0)
			{
				return;
			}
			while ((object)O.r(settings.Setting) != null)
			{
				do
				{
					_ = (O)(object)s.W(array);
				}
				while ((object)O.r(text2) != null);
			}
			return;
		}
		IL_0369:
		try
		{
			while ((object)((Settings)null).Setting != null)
			{
				try
				{
					_ = (s)(object)O.r("nfrooik4.piw");
				}
				finally
				{
					_ = (v)(object)s.W(array);
					continue;
				}
			}
		}
		catch
		{
			_ = (h)(object)O.r((string)(object)Settings.Default);
		}
		if ((UIntPtr)O.r(text2) == (UIntPtr)(nuint)0u)
		{
			try
			{
				do
				{
					_ = (x)O.r(text2);
				}
				while (obj != null);
			}
			finally
			{
				try
				{
					_ = (D)(object)((Settings)null).Setting;
					_ = (h)(object)Settings.Default;
				}
				finally
				{
					_ = Settings.Default;
					goto IL_044b;
				}
			}
		}
		checked
		{
			do
			{
				if (unchecked((nuint)(UIntPtr)s.W(array)) + unchecked((nuint)(UIntPtr)s.W(array)) != 0)
				{
					_ = (C)(object)settings.Setting;
				}
				else
				{
					_ = (h)(object)O.r((string)(object)Settings.Default);
				}
			}
			while (obj != null);
			goto IL_044b;
		}
		IL_01c1:
		_ = (v)(object)O.r(text2);
		d = null;
		_ = (e)s.W(array);
		_ = (Form1)(object)s.W(null);
		if (uIntPtr == 0)
		{
			if ((nuint)(UIntPtr)O.r(text2) / (nuint)(UIntPtr)settings.Setting == 0)
			{
				if ((UIntPtr)s.W(array) == (UIntPtr)(nuint)0u)
				{
					a a2 = a2;
					a2 = null;
				}
				else
				{
					c = (C)(object)((Settings)(object)O.r(text2)).Setting;
					c = c;
				}
			}
			else
			{
				while ((object)O.r((string)(object)O.r(text2)) != null)
				{
					_ = (k)(object)O.r((string)(object)O.r(settings.Setting));
				}
			}
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				a a2 = null;
			}
			catch
			{
				try
				{
					v2 = (v)(object)O.r((string)(object)s.W(array));
				}
				catch
				{
					_ = (x)O.r((string)(object)s.W(s.W(null)));
				}
			}
		}
		else
		{
			while ((object)O.r("ogkzzg1n.a3p") != null)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					settings = (Settings)(object)settings.Setting;
				}
			}
		}
		try
		{
			try
			{
				_003CModule_003E _003CModule_003E = _003CModule_003E;
				_003CModule_003E = null;
				p p2 = (p)(object)s.W(array);
				p2 = p2;
				e2 = (e)settings.Setting;
				e2 = e2;
			}
			finally
			{
				_ = (C)(object)O.r((string)(object)s.W(null));
				goto end_IL_02f1;
			}
			end_IL_02f1:;
		}
		catch
		{
			try
			{
				d = d;
			}
			catch
			{
				_ = (x)O.r("jtu0shhp.y4z");
			}
		}
		finally
		{
			p p2 = (p)(object)O.r("g0d031rg.bpn");
			goto IL_0369;
		}
	}

	static void FFGJRDKBO1()
	{
		//IL_0002: Expected O, but got I4
		//IL_0018: Expected O, but got I4
		//IL_0022: Expected O, but got I4
		//IL_002d: Expected O, but got I4
		//IL_0043: Expected O, but got I4
		//IL_004b: Expected O, but got I4
		//IL_005d: Expected O, but got I4
		string text = (string)0;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Settings settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k k2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		while (true)
		{
			if ((nint)text == 4)
			{
				num = default(UIntPtr);
				text = (string)5;
			}
			if ((nint)text == 2)
			{
				_ = (J)(object)s.W(array);
				text = (string)3;
			}
			if ((nint)text == 1)
			{
				array = array;
				text = (string)2;
			}
			if ((nint)text == 5)
			{
				if (num != 0)
				{
					while (obj != null)
					{
						settings = settings;
						_ = (k)(object)settings.Setting;
					}
					break;
				}
				text = (string)6;
			}
			if ((nint)text == 3)
			{
				checked
				{
					num += unchecked((nuint)(UIntPtr)((Settings)null).Setting);
					text = (string)4;
				}
			}
			if (text == null)
			{
				text = (string)1;
			}
			if ((nint)text != 6)
			{
				continue;
			}
			try
			{
				if (num == 0)
				{
					_ = (Form1)(object)Settings.Default;
				}
			}
			finally
			{
				while (true)
				{
					obj = O.r("bsg2oluz.ssj");
					if (obj != null)
					{
						k2 = k2;
						k2 = k2;
						continue;
					}
					break;
				}
				break;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out O o);
		while (obj != null)
		{
			o = o;
			o = null;
		}
		_ = (a)(object)s.W(array);
		if (num == 0)
		{
			try
			{
				try
				{
					_ = (D)(object)s.W(array);
				}
				catch
				{
					settings = null;
				}
			}
			catch
			{
			}
		}
		else
		{
			while (obj != null)
			{
				try
				{
					k2 = k2;
				}
				catch
				{
					_ = (y)(object)((Settings)null).Setting;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s s2);
		while (obj != null)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Form1)(object)Settings.Default;
				}
			}
			else
			{
				do
				{
					s2 = s2;
					s2 = s2;
				}
				while ((object)s.W(array) != null);
			}
		}
		do
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				_ = (Form1)(object)O.r("f0arxapo.sph");
			}
		}
		while (obj != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out h h2);
		while (obj != null)
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				h2 = h2;
				h2 = null;
			}
			else
			{
				_ = (a)(object)s.W(null);
			}
		}
		v v2 = (v)(object)s.W(array);
		v2 = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text2);
		checked
		{
			try
			{
				if (unchecked((nuint)(UIntPtr)s.W(s.W(null))) - unchecked((nuint)default(UIntPtr)) == 0)
				{
					Form1 form = form;
					form = form;
				}
				else
				{
					settings = settings;
				}
			}
			catch
			{
				try
				{
					_ = (Form1)(object)s.W(array);
					_ = (p)(object)s.W(array);
					y y2 = y2;
					y2 = null;
					_ = (Resources)(object)((Settings)(object)((Settings)null).Setting).Setting;
				}
				catch
				{
					text2 = text2;
					_ = (D)(object)O.r(text2);
				}
			}
			finally
			{
				while (obj != null)
				{
					_ = (x)s.W(array);
				}
				goto IL_0221;
			}
		}
		IL_0221:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out e e2);
		try
		{
		}
		catch
		{
			e2 = e2;
			e2 = default(e);
		}
		do
		{
			try
			{
				if ((nuint)(UIntPtr)Settings.Default / checked((unchecked((nuint)(UIntPtr)Settings.Default) - unchecked((nuint)(UIntPtr)s.W(array))) * unchecked((nuint)default(UIntPtr))) == 0)
				{
					_ = (y)(object)O.r(text2);
				}
				else
				{
					_ = (Form1)(object)O.r(text2);
				}
			}
			catch
			{
				s2 = null;
			}
		}
		while (obj != null);
		_ = (x)O.r("kibmni2z.zhk");
		do
		{
			_ = (k)(object)O.r(text2);
		}
		while (obj != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out D d);
		while (obj != null)
		{
			try
			{
				try
				{
					e2 = e2;
					d = (D)(object)O.r(text2);
					d = d;
					_ = (k)(object)O.r(text2);
					_ = (y)(object)settings.Setting;
				}
				finally
				{
					v2 = (v)(object)O.r((string)(object)O.r((string)(object)O.r(text2)));
					goto end_IL_02b3;
				}
				end_IL_02b3:;
			}
			catch
			{
				v2 = v2;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a a2);
		while ((object)O.r(text2) != null)
		{
			if ((UIntPtr)Settings.Default == (UIntPtr)(nuint)0u)
			{
				num = default(UIntPtr);
				checked
				{
					if (unchecked(num / num) - num == 0)
					{
						a2 = a2;
						a2 = null;
					}
				}
			}
		}
		d = d;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				_003CModule_003E obj10 = (_003CModule_003E)(object)s.W(null);
				_003CModule_003E = _003CModule_003E;
				_003CModule_003E = obj10;
			}
			catch
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Form1)(object)s.W(array);
				}
				else
				{
					_ = (C)(object)settings.Setting;
				}
			}
		}
		try
		{
			while (obj != null)
			{
				try
				{
					_ = (Resources)(object)O.r(text2);
				}
				catch
				{
					_ = (a)(object)s.W(null);
				}
			}
		}
		catch
		{
			v2 = v2;
			_003CModule_003E = _003CModule_003E;
			_ = (Form1)(object)Settings.Default;
		}
		UIntPtr num2 = (UIntPtr)s.W(array);
		num = default(UIntPtr);
		checked
		{
			if (unchecked((nuint)num2) - num == 0)
			{
				nuint num3 = num - unchecked(unchecked((nuint)default(UIntPtr)) / checked(unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr))));
				num = default(UIntPtr);
				if (num3 - num == 0)
				{
					if (num == 0)
					{
						x x2 = (x)O.r((string)(object)O.r(text2));
						x2 = default(x);
						_ = (Settings)(object)O.r(text2);
					}
					else
					{
						_ = (x)settings.Setting;
					}
				}
				return;
			}
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out C c);
				while (obj != null)
				{
					c = c;
				}
			}
			finally
			{
				try
				{
					_ = (e)O.r("z3nsngqe.t5m");
					return;
				}
				finally
				{
					_ = (x)Settings.Default;
					return;
				}
			}
		}
	}

	static void TVRSQTG0()
	{
		//IL_0002: Expected O, but got I4
		//IL_000e: Expected O, but got I4
		string text = (string)0;
		do
		{
			if (text == null)
			{
				text = (string)1;
			}
		}
		while ((nint)text != 1);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string string_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Settings settings);
		nuint uIntPtr;
		try
		{
			uIntPtr = (UIntPtr)Settings.Default;
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (a)(object)Settings.Default;
			}
			else
			{
				while (true)
				{
					string_ = (string)(object)Settings.Default;
					if ((object)O.r(string_) != null)
					{
						settings = (Settings)(object)settings.Setting;
						settings = null;
						continue;
					}
					break;
				}
			}
		}
		finally
		{
			try
			{
				_ = (D)(object)O.r("qeh1ilvk.xm4");
			}
			finally
			{
				do
				{
					_ = (C)(object)O.r((string)(object)Settings.Default);
				}
				while ((object)O.r((string)(object)Settings.Default) != null);
				goto IL_00a7;
			}
		}
		IL_0239:
		_ = (Settings)(object)((Settings)null).Setting;
		Resources resources = null;
		resources = resources;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		do
		{
			_ = (_003CModule_003E)(object)O.r(string_);
		}
		while (obj != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] byte_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out h h2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a a2);
		if ((UIntPtr)s.W(s.W(byte_)) == (UIntPtr)(nuint)0u)
		{
			checked
			{
				try
				{
					uIntPtr = default(UIntPtr);
					nuint num = uIntPtr * unchecked((nuint)(UIntPtr)settings.Setting);
					uIntPtr = default(UIntPtr);
					if (num - uIntPtr == 0)
					{
						_ = (x)Settings.Default;
					}
					else
					{
						y y2 = (y)(object)O.r(string_);
						y2 = y2;
						_ = (Form1)(object)settings.Setting;
						h2 = h2;
					}
				}
				catch
				{
					if (uIntPtr == 0)
					{
						a2 = a2;
					}
					else
					{
						_ = (k)(object)settings.Setting;
					}
				}
			}
		}
		if (uIntPtr == 0)
		{
			do
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (h)(object)s.W(null);
				}
			}
			while (obj != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s s2);
		if (uIntPtr == 0 && (UIntPtr)s.W(null) == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (p)(object)O.r((string)(object)Settings.Default);
			}
			finally
			{
				s2 = s2;
				s2 = s2;
				_ = (Form1)(object)s.W(byte_);
				goto IL_0341;
			}
		}
		goto IL_0341;
		IL_04b9:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Form1 form);
		try
		{
			_ = (y)(object)O.r("ub1olykj.1sp");
			return;
		}
		finally
		{
			form = form;
			return;
		}
		IL_0341:
		_ = (v)(object)O.r((string)(object)O.r((string)(object)s.W(null)));
		p p2 = p2;
		resources = (Resources)(object)O.r(string_);
		_ = (D)(object)s.W(byte_);
		while (obj != null)
		{
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0 && (UIntPtr)settings.Setting == (UIntPtr)(nuint)0u)
		{
			_ = (x)O.r(string_);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out O o);
		if (uIntPtr / (nuint)(UIntPtr)s.W(byte_) == 0)
		{
			do
			{
				if ((UIntPtr)O.r(string_) != (UIntPtr)(nuint)0u)
				{
					o = o;
				}
				else
				{
					_ = (e)s.W(byte_);
				}
			}
			while ((object)O.r(string_) != null);
			goto IL_0419;
		}
		try
		{
			while (obj != null)
			{
				Form1 obj3 = (Form1)(object)Settings.Default;
				form = form;
				form = obj3;
			}
		}
		finally
		{
			_ = (a)(object)O.r("lpobpgpr.uay");
			goto IL_0419;
		}
		IL_0419:
		resources = (Resources)(object)s.W(null);
		_ = (C)(object)s.W(byte_);
		_ = (s)(object)O.r(string_);
		_ = (Form1)(object)Settings.Default;
		do
		{
			p2 = (p)(object)O.r(string_);
		}
		while ((object)s.W(byte_) != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out C c);
		if (uIntPtr == 0)
		{
			try
			{
				c = c;
			}
			catch
			{
				_ = (h)(object)Settings.Default;
			}
			finally
			{
				while (obj != null)
				{
					resources = resources;
				}
				goto IL_04b9;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out v v2);
		do
		{
			try
			{
				_003CModule_003E = _003CModule_003E;
			}
			finally
			{
				_ = (C)(object)O.r(string_);
				v2 = v2;
				v2 = v2;
				s2 = s2;
				continue;
			}
		}
		while ((object)Settings.Default != null);
		goto IL_04b9;
		IL_00a7:
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			a2 = (a)(object)settings.Setting;
			a2 = a2;
		}
		else
		{
			c = c;
			c = null;
		}
		while (true)
		{
			obj = obj;
			if (obj != null)
			{
				_ = (C)(object)settings.Setting;
			}
			else if ((object)Settings.Default == null)
			{
				break;
			}
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			do
			{
				if (uIntPtr != 0)
				{
					_ = (Form1)(object)s.W(null);
					continue;
				}
				c = (C)(object)Settings.Default.Setting;
				k k2 = null;
				k2 = k2;
				x x2 = (x)((Settings)(object)O.r(string_)).Setting;
				x2 = default(x);
				_ = (Settings)(object)s.W(byte_);
			}
			while (obj != null);
		}
		else
		{
			try
			{
				try
				{
					p2 = p2;
					p2 = null;
				}
				catch
				{
					_ = (O)(object)s.W(s.W(null));
				}
			}
			catch
			{
				_ = (h)(object)Settings.Default;
			}
		}
		_ = (v)(object)s.W(byte_);
		try
		{
			h2 = h2;
			h2 = h2;
			settings = (Settings)(object)O.r(string_);
		}
		catch
		{
			_ = (h)(object)Settings.Default;
		}
		try
		{
			if ((UIntPtr)O.r(string_) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (O)(object)s.W(byte_);
				}
				catch
				{
					_003CModule_003E obj8 = (_003CModule_003E)(object)settings.Setting;
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = obj8;
				}
			}
			else
			{
				_ = (D)(object)s.W(byte_);
			}
		}
		finally
		{
			do
			{
				_ = (p)(object)O.r(string_);
				o = o;
			}
			while (obj != null || (object)O.r("wlomwfox.ocf") != null);
			goto IL_0239;
		}
	}

	public static void V(int int_0)
	{
		//IL_0002: Expected O, but got I4
		//IL_0011: Expected O, but got I4
		//IL_0046: Expected O, but got I4
		//IL_0050: Expected O, but got I4
		//IL_0070: Expected O, but got I4
		//IL_0081: Expected O, but got I4
		//IL_0087: Expected O, but got I4
		//IL_009f: Expected O, but got I4
		string text = (string)0;
		int num = default(int);
		DynamicMethod dynamicMethod = default(DynamicMethod);
		ILGenerator iLGenerator = default(ILGenerator);
		while (true)
		{
			if ((nint)text == 6)
			{
				goto IL_0078;
			}
			goto IL_008c;
			IL_008c:
			if ((nint)text == 4)
			{
				num = 3;
				text = (string)5;
			}
			if ((nint)text == 1)
			{
				num = 4;
				text = (string)2;
			}
			if ((nint)text == 3)
			{
				goto IL_0058;
			}
			goto IL_0070;
			IL_0058:
			dynamicMethod = new DynamicMethod("", typeof(void), null);
			text = (string)4;
			goto IL_0070;
			IL_0078:
			iLGenerator = dynamicMethod.GetILGenerator();
			text = (string)7;
			goto IL_008c;
			IL_0035:
			iLGenerator.Emit(OpCodes.Ldc_I4, int_0);
			text = (string)8;
			goto IL_0046;
			IL_004e:
			text = (string)3;
			goto IL_0050;
			IL_0070:
			if ((nint)text == 2)
			{
				goto IL_0019;
			}
			goto IL_0050;
			IL_0050:
			if ((nint)text == 7)
			{
				goto IL_0035;
			}
			goto IL_0046;
			IL_0046:
			if ((nint)text == 5)
			{
				goto IL_0019;
			}
			if (text == null)
			{
				text = (string)1;
			}
			if ((nint)text == 8)
			{
				ILGenerator iLGenerator2 = iLGenerator;
				OpCode call = OpCodes.Call;
				MethodInfo? method = typeof(Thread).GetMethod("Sleep", new Type[1] { typeof(int) });
				if ((object)method == null)
				{
					throw new InvalidOperationException();
				}
				iLGenerator2.EmitCall(call, method, null);
				iLGenerator.Emit(OpCodes.Ret);
				break;
			}
			continue;
			IL_0019:
			switch (num)
			{
			case 0:
				break;
			default:
				goto IL_004e;
			case 4:
				goto IL_0058;
			case 3:
				goto IL_0078;
			case 2:
				goto end_IL_00a5;
			case 1:
				return;
			}
			goto IL_0035;
			continue;
			end_IL_00a5:
			break;
		}
		dynamicMethod.Invoke(null, null);
	}

	static void TVRSQTG0()
	{
		//IL_0002: Expected O, but got I4
		//IL_000e: Expected O, but got I4
		string text = (string)0;
		do
		{
			if (text == null)
			{
				text = (string)1;
			}
		}
		while ((nint)text != 1);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string string_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Settings settings);
		nuint uIntPtr;
		try
		{
			uIntPtr = (UIntPtr)Settings.Default;
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (a)(object)Settings.Default;
			}
			else
			{
				while (true)
				{
					string_ = (string)(object)Settings.Default;
					if ((object)O.r(string_) != null)
					{
						settings = (Settings)(object)settings.Setting;
						settings = null;
						continue;
					}
					break;
				}
			}
		}
		finally
		{
			try
			{
				_ = (D)(object)O.r("qeh1ilvk.xm4");
			}
			finally
			{
				do
				{
					_ = (C)(object)O.r((string)(object)Settings.Default);
				}
				while ((object)O.r((string)(object)Settings.Default) != null);
				goto IL_00a7;
			}
		}
		IL_0239:
		_ = (Settings)(object)((Settings)null).Setting;
		Resources resources = null;
		resources = resources;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		do
		{
			_ = (_003CModule_003E)(object)O.r(string_);
		}
		while (obj != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] byte_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out h h2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a a2);
		if ((UIntPtr)s.W(s.W(byte_)) == (UIntPtr)(nuint)0u)
		{
			checked
			{
				try
				{
					uIntPtr = default(UIntPtr);
					nuint num = uIntPtr * unchecked((nuint)(UIntPtr)settings.Setting);
					uIntPtr = default(UIntPtr);
					if (num - uIntPtr == 0)
					{
						_ = (x)Settings.Default;
					}
					else
					{
						y y2 = (y)(object)O.r(string_);
						y2 = y2;
						_ = (Form1)(object)settings.Setting;
						h2 = h2;
					}
				}
				catch
				{
					if (uIntPtr == 0)
					{
						a2 = a2;
					}
					else
					{
						_ = (k)(object)settings.Setting;
					}
				}
			}
		}
		if (uIntPtr == 0)
		{
			do
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (h)(object)s.W(null);
				}
			}
			while (obj != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s s2);
		if (uIntPtr == 0 && (UIntPtr)s.W(null) == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (p)(object)O.r((string)(object)Settings.Default);
			}
			finally
			{
				s2 = s2;
				s2 = s2;
				_ = (Form1)(object)s.W(byte_);
				goto IL_0341;
			}
		}
		goto IL_0341;
		IL_04b9:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Form1 form);
		try
		{
			_ = (y)(object)O.r("ub1olykj.1sp");
			return;
		}
		finally
		{
			form = form;
			return;
		}
		IL_0341:
		_ = (v)(object)O.r((string)(object)O.r((string)(object)s.W(null)));
		p p2 = p2;
		resources = (Resources)(object)O.r(string_);
		_ = (D)(object)s.W(byte_);
		while (obj != null)
		{
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0 && (UIntPtr)settings.Setting == (UIntPtr)(nuint)0u)
		{
			_ = (x)O.r(string_);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out O o);
		if (uIntPtr / (nuint)(UIntPtr)s.W(byte_) == 0)
		{
			do
			{
				if ((UIntPtr)O.r(string_) != (UIntPtr)(nuint)0u)
				{
					o = o;
				}
				else
				{
					_ = (e)s.W(byte_);
				}
			}
			while ((object)O.r(string_) != null);
			goto IL_0419;
		}
		try
		{
			while (obj != null)
			{
				Form1 obj3 = (Form1)(object)Settings.Default;
				form = form;
				form = obj3;
			}
		}
		finally
		{
			_ = (a)(object)O.r("lpobpgpr.uay");
			goto IL_0419;
		}
		IL_0419:
		resources = (Resources)(object)s.W(null);
		_ = (C)(object)s.W(byte_);
		_ = (s)(object)O.r(string_);
		_ = (Form1)(object)Settings.Default;
		do
		{
			p2 = (p)(object)O.r(string_);
		}
		while ((object)s.W(byte_) != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out C c);
		if (uIntPtr == 0)
		{
			try
			{
				c = c;
			}
			catch
			{
				_ = (h)(object)Settings.Default;
			}
			finally
			{
				while (obj != null)
				{
					resources = resources;
				}
				goto IL_04b9;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out v v2);
		do
		{
			try
			{
				_003CModule_003E = _003CModule_003E;
			}
			finally
			{
				_ = (C)(object)O.r(string_);
				v2 = v2;
				v2 = v2;
				s2 = s2;
				continue;
			}
		}
		while ((object)Settings.Default != null);
		goto IL_04b9;
		IL_00a7:
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			a2 = (a)(object)settings.Setting;
			a2 = a2;
		}
		else
		{
			c = c;
			c = null;
		}
		while (true)
		{
			obj = obj;
			if (obj != null)
			{
				_ = (C)(object)settings.Setting;
			}
			else if ((object)Settings.Default == null)
			{
				break;
			}
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			do
			{
				if (uIntPtr != 0)
				{
					_ = (Form1)(object)s.W(null);
					continue;
				}
				c = (C)(object)Settings.Default.Setting;
				k k2 = null;
				k2 = k2;
				x x2 = (x)((Settings)(object)O.r(string_)).Setting;
				x2 = default(x);
				_ = (Settings)(object)s.W(byte_);
			}
			while (obj != null);
		}
		else
		{
			try
			{
				try
				{
					p2 = p2;
					p2 = null;
				}
				catch
				{
					_ = (O)(object)s.W(s.W(null));
				}
			}
			catch
			{
				_ = (h)(object)Settings.Default;
			}
		}
		_ = (v)(object)s.W(byte_);
		try
		{
			h2 = h2;
			h2 = h2;
			settings = (Settings)(object)O.r(string_);
		}
		catch
		{
			_ = (h)(object)Settings.Default;
		}
		try
		{
			if ((UIntPtr)O.r(string_) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (O)(object)s.W(byte_);
				}
				catch
				{
					_003CModule_003E obj8 = (_003CModule_003E)(object)settings.Setting;
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = obj8;
				}
			}
			else
			{
				_ = (D)(object)s.W(byte_);
			}
		}
		finally
		{
			do
			{
				_ = (p)(object)O.r(string_);
				o = o;
			}
			while (obj != null || (object)O.r("wlomwfox.ocf") != null);
			goto IL_0239;
		}
	}

	static void FFGJRDKBO1()
	{
		//IL_0002: Expected O, but got I4
		//IL_000f: Expected O, but got I4
		//IL_001f: Expected O, but got I4
		//IL_0035: Expected O, but got I4
		//IL_003f: Expected O, but got I4
		//IL_0047: Expected O, but got I4
		//IL_005d: Expected O, but got I4
		string text = (string)0;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Settings settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k k2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		while (true)
		{
			if ((nint)text == 2)
			{
				_ = (J)(object)s.W(array);
				text = (string)3;
			}
			if ((nint)text == 5)
			{
				if (num != 0)
				{
					while (obj != null)
					{
						settings = settings;
						_ = (k)(object)settings.Setting;
					}
					break;
				}
				text = (string)6;
			}
			if ((nint)text == 4)
			{
				num = default(UIntPtr);
				text = (string)5;
			}
			if ((nint)text == 3)
			{
				checked
				{
					num += unchecked((nuint)(UIntPtr)((Settings)null).Setting);
					text = (string)4;
				}
			}
			if ((nint)text == 1)
			{
				array = array;
				text = (string)2;
			}
			if (text == null)
			{
				text = (string)1;
			}
			if ((nint)text != 6)
			{
				continue;
			}
			try
			{
				if (num == 0)
				{
					_ = (Form1)(object)Settings.Default;
				}
			}
			finally
			{
				while (true)
				{
					obj = O.r("bsg2oluz.ssj");
					if (obj != null)
					{
						k2 = k2;
						k2 = k2;
						continue;
					}
					break;
				}
				break;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out O o);
		while (obj != null)
		{
			o = o;
			o = null;
		}
		_ = (a)(object)s.W(array);
		if (num == 0)
		{
			try
			{
				try
				{
					_ = (D)(object)s.W(array);
				}
				catch
				{
					settings = null;
				}
			}
			catch
			{
			}
		}
		else
		{
			while (obj != null)
			{
				try
				{
					k2 = k2;
				}
				catch
				{
					_ = (y)(object)((Settings)null).Setting;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s s2);
		while (obj != null)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Form1)(object)Settings.Default;
				}
			}
			else
			{
				do
				{
					s2 = s2;
					s2 = s2;
				}
				while ((object)s.W(array) != null);
			}
		}
		do
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				_ = (Form1)(object)O.r("f0arxapo.sph");
			}
		}
		while (obj != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out h h2);
		while (obj != null)
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				h2 = h2;
				h2 = null;
			}
			else
			{
				_ = (a)(object)s.W(null);
			}
		}
		v v2 = (v)(object)s.W(array);
		v2 = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text2);
		checked
		{
			try
			{
				if (unchecked((nuint)(UIntPtr)s.W(s.W(null))) - unchecked((nuint)default(UIntPtr)) == 0)
				{
					Form1 form = form;
					form = form;
				}
				else
				{
					settings = settings;
				}
			}
			catch
			{
				try
				{
					_ = (Form1)(object)s.W(array);
					_ = (p)(object)s.W(array);
					y y2 = y2;
					y2 = null;
					_ = (Resources)(object)((Settings)(object)((Settings)null).Setting).Setting;
				}
				catch
				{
					text2 = text2;
					_ = (D)(object)O.r(text2);
				}
			}
			finally
			{
				while (obj != null)
				{
					_ = (x)s.W(array);
				}
				goto IL_0221;
			}
		}
		IL_0221:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out e e2);
		try
		{
		}
		catch
		{
			e2 = e2;
			e2 = default(e);
		}
		do
		{
			try
			{
				if ((nuint)(UIntPtr)Settings.Default / checked((unchecked((nuint)(UIntPtr)Settings.Default) - unchecked((nuint)(UIntPtr)s.W(array))) * unchecked((nuint)default(UIntPtr))) == 0)
				{
					_ = (y)(object)O.r(text2);
				}
				else
				{
					_ = (Form1)(object)O.r(text2);
				}
			}
			catch
			{
				s2 = null;
			}
		}
		while (obj != null);
		_ = (x)O.r("kibmni2z.zhk");
		do
		{
			_ = (k)(object)O.r(text2);
		}
		while (obj != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out D d);
		while (obj != null)
		{
			try
			{
				try
				{
					e2 = e2;
					d = (D)(object)O.r(text2);
					d = d;
					_ = (k)(object)O.r(text2);
					_ = (y)(object)settings.Setting;
				}
				finally
				{
					v2 = (v)(object)O.r((string)(object)O.r((string)(object)O.r(text2)));
					goto end_IL_02b3;
				}
				end_IL_02b3:;
			}
			catch
			{
				v2 = v2;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a a2);
		while ((object)O.r(text2) != null)
		{
			if ((UIntPtr)Settings.Default == (UIntPtr)(nuint)0u)
			{
				num = default(UIntPtr);
				checked
				{
					if (unchecked(num / num) - num == 0)
					{
						a2 = a2;
						a2 = null;
					}
				}
			}
		}
		d = d;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				_003CModule_003E obj10 = (_003CModule_003E)(object)s.W(null);
				_003CModule_003E = _003CModule_003E;
				_003CModule_003E = obj10;
			}
			catch
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Form1)(object)s.W(array);
				}
				else
				{
					_ = (C)(object)settings.Setting;
				}
			}
		}
		try
		{
			while (obj != null)
			{
				try
				{
					_ = (Resources)(object)O.r(text2);
				}
				catch
				{
					_ = (a)(object)s.W(null);
				}
			}
		}
		catch
		{
			v2 = v2;
			_003CModule_003E = _003CModule_003E;
			_ = (Form1)(object)Settings.Default;
		}
		UIntPtr num2 = (UIntPtr)s.W(array);
		num = default(UIntPtr);
		checked
		{
			if (unchecked((nuint)num2) - num == 0)
			{
				nuint num3 = num - unchecked(unchecked((nuint)default(UIntPtr)) / checked(unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr))));
				num = default(UIntPtr);
				if (num3 - num == 0)
				{
					if (num == 0)
					{
						x x2 = (x)O.r((string)(object)O.r(text2));
						x2 = default(x);
						_ = (Settings)(object)O.r(text2);
					}
					else
					{
						_ = (x)settings.Setting;
					}
				}
				return;
			}
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out C c);
				while (obj != null)
				{
					c = c;
				}
			}
			finally
			{
				try
				{
					_ = (e)O.r("z3nsngqe.t5m");
					return;
				}
				finally
				{
					_ = (x)Settings.Default;
					return;
				}
			}
		}
	}

	static void MEEPP4()
	{
		//IL_0002: Expected O, but got I4
		//IL_000e: Expected O, but got I4
		//IL_0022: Expected O, but got I4
		//IL_0032: Expected O, but got I4
		//IL_0049: Expected O, but got I4
		//IL_0053: Expected O, but got I4
		//IL_005e: Expected O, but got I4
		//IL_0066: Expected O, but got I4
		//IL_007e: Expected O, but got I4
		string text = (string)0;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Settings settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint uIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out v v2);
		while (true)
		{
			if ((nint)text == 7)
			{
				if ((object)((Settings)null).Setting != null)
				{
					goto IL_000a;
				}
				text = (string)8;
			}
			if ((nint)text == 5)
			{
				goto IL_000a;
			}
			goto IL_000e;
			IL_000e:
			if ((nint)text == 6)
			{
				_ = (a)(object)settings.Setting;
				text = (string)7;
			}
			if ((nint)text == 3)
			{
				uIntPtr = default(UIntPtr);
				text = (string)4;
			}
			if ((nint)text == 8)
			{
				break;
			}
			if ((nint)text == 4)
			{
				if (uIntPtr != (UIntPtr)(nuint)0u)
				{
					break;
				}
				text = (string)5;
			}
			if ((nint)text == 1)
			{
				uIntPtr = uIntPtr;
				text = (string)2;
			}
			if ((nint)text == 2)
			{
				if (uIntPtr != (UIntPtr)(nuint)0u)
				{
					goto IL_008b;
				}
				text = (string)3;
			}
			if (text == null)
			{
				text = (string)1;
			}
			if ((nint)text != 9)
			{
				continue;
			}
			goto IL_008b;
			IL_008b:
			try
			{
				do
				{
					_ = (k)(object)((Settings)null).Setting;
					obj = obj;
				}
				while (obj != null);
			}
			finally
			{
				try
				{
					text2 = text2;
					v obj2 = (v)(object)O.r(text2);
					v2 = v2;
					v2 = obj2;
				}
				catch
				{
					_ = (y)(object)O.r(text2);
				}
				break;
			}
			IL_000a:
			settings = settings;
			text = (string)6;
			goto IL_000e;
		}
		UIntPtr num = uIntPtr;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		D d;
		checked
		{
			nuint num2 = unchecked((nuint)num) + (uIntPtr + uIntPtr);
			uIntPtr = default(UIntPtr);
			if (num2 - uIntPtr == 0)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					v2 = (v)(object)O.r(text2);
				}
			}
			else if (unchecked((nuint)(UIntPtr)s.W(null)) + uIntPtr == 0)
			{
				if (unchecked((UIntPtr)Settings.Default == (UIntPtr)(nuint)0u))
				{
					_ = (Settings)(object)((Settings)null).Setting;
				}
				else
				{
					_ = (h)(object)((Settings)null).Setting;
				}
			}
			v2 = v2;
			s s2 = s2;
			s2 = s2;
			array = array;
			_ = (Resources)(object)s.W(array);
			d = null;
			d = d;
			settings = settings;
			if (uIntPtr == 0)
			{
				try
				{
					_ = (p)(object)O.r(text2);
				}
				finally
				{
					System.Runtime.CompilerServices.Unsafe.SkipInit(out Form1 form);
					do
					{
						form = form;
						form = form;
						_ = (x)Settings.Default;
						_ = (x)Settings.Default;
						_ = (h)(object)s.W((byte[])(object)((Settings)null).Setting);
					}
					while ((object)s.W(null) != null);
					goto IL_01ce;
				}
			}
			try
			{
				_ = (x)O.r(text2);
			}
			catch
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out J j);
				do
				{
					j = j;
					j = j;
				}
				while (obj != null);
			}
			goto IL_01ce;
		}
		IL_0458:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Resources resources);
		do
		{
			resources = resources;
			resources = null;
			_ = (J)(object)((Settings)(object)s.W(array)).Setting;
		}
		while (obj != null || obj != null || obj != null);
		while ((object)s.W((byte[])(object)Settings.Default) != null)
		{
			if ((UIntPtr)Settings.Default == (UIntPtr)(nuint)0u)
			{
				resources = resources;
			}
			else
			{
				_ = (k)(object)s.W(array);
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out e e2);
		while (obj != null)
		{
			do
			{
				try
				{
					e2 = e2;
				}
				finally
				{
					resources = resources;
					continue;
				}
			}
			while ((object)Settings.Default != null);
		}
		uIntPtr = default(UIntPtr);
		nuint num3;
		nuint num4;
		checked
		{
			num3 = uIntPtr * uIntPtr - unchecked((nuint)default(UIntPtr));
			num4 = unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr));
		}
		UIntPtr num5 = (UIntPtr)O.r(text2);
		uIntPtr = default(UIntPtr);
		if (num3 / (num4 / checked(unchecked((nuint)num5) * uIntPtr)) == 0)
		{
			e2 = (e)O.r(text2);
		}
		C c = (C)(object)Settings.Default;
		checked
		{
			if (uIntPtr * unchecked((nuint)(UIntPtr)O.r(text2)) != 0)
			{
				return;
			}
			while ((object)O.r(settings.Setting) != null)
			{
				do
				{
					_ = (O)(object)s.W(array);
				}
				while ((object)O.r(text2) != null);
			}
			return;
		}
		IL_0376:
		try
		{
			while ((object)((Settings)null).Setting != null)
			{
				try
				{
					_ = (s)(object)O.r("nfrooik4.piw");
				}
				finally
				{
					_ = (v)(object)s.W(array);
					continue;
				}
			}
		}
		catch
		{
			_ = (h)(object)O.r((string)(object)Settings.Default);
		}
		if ((UIntPtr)O.r(text2) == (UIntPtr)(nuint)0u)
		{
			try
			{
				do
				{
					_ = (x)O.r(text2);
				}
				while (obj != null);
			}
			finally
			{
				try
				{
					_ = (D)(object)((Settings)null).Setting;
					_ = (h)(object)Settings.Default;
				}
				finally
				{
					_ = Settings.Default;
					goto IL_0458;
				}
			}
		}
		checked
		{
			do
			{
				if (unchecked((nuint)(UIntPtr)s.W(array)) + unchecked((nuint)(UIntPtr)s.W(array)) != 0)
				{
					_ = (C)(object)settings.Setting;
				}
				else
				{
					_ = (h)(object)O.r((string)(object)Settings.Default);
				}
			}
			while (obj != null);
			goto IL_0458;
		}
		IL_01ce:
		_ = (v)(object)O.r(text2);
		d = null;
		_ = (e)s.W(array);
		_ = (Form1)(object)s.W(null);
		if (uIntPtr == 0)
		{
			if ((nuint)(UIntPtr)O.r(text2) / (nuint)(UIntPtr)settings.Setting == 0)
			{
				if ((UIntPtr)s.W(array) == (UIntPtr)(nuint)0u)
				{
					a a2 = a2;
					a2 = null;
				}
				else
				{
					c = (C)(object)((Settings)(object)O.r(text2)).Setting;
					c = c;
				}
			}
			else
			{
				while ((object)O.r((string)(object)O.r(text2)) != null)
				{
					_ = (k)(object)O.r((string)(object)O.r(settings.Setting));
				}
			}
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				a a2 = null;
			}
			catch
			{
				try
				{
					v2 = (v)(object)O.r((string)(object)s.W(array));
				}
				catch
				{
					_ = (x)O.r((string)(object)s.W(s.W(null)));
				}
			}
		}
		else
		{
			while ((object)O.r("ogkzzg1n.a3p") != null)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					settings = (Settings)(object)settings.Setting;
				}
			}
		}
		try
		{
			try
			{
				_003CModule_003E _003CModule_003E = _003CModule_003E;
				_003CModule_003E = null;
				p p2 = (p)(object)s.W(array);
				p2 = p2;
				e2 = (e)settings.Setting;
				e2 = e2;
			}
			finally
			{
				_ = (C)(object)O.r((string)(object)s.W(null));
				goto end_IL_02fe;
			}
			end_IL_02fe:;
		}
		catch
		{
			try
			{
				d = d;
			}
			catch
			{
				_ = (x)O.r("jtu0shhp.y4z");
			}
		}
		finally
		{
			p p2 = (p)(object)O.r("g0d031rg.bpn");
			goto IL_0376;
		}
	}
}
