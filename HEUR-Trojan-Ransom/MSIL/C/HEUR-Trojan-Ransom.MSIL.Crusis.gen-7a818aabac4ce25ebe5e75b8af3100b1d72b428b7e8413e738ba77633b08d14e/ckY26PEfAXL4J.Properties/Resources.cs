using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using U;

namespace ckY26PEfAXL4J.Properties;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal sealed class Resources
{
	private static ResourceManager K;

	private static CultureInfo E;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager s
	{
		get
		{
			//IL_0002: Expected O, but got I4
			//IL_002a: Expected O, but got I4
			//IL_0030: Expected O, but got I4
			//IL_0049: Expected O, but got I4
			//IL_005c: Expected O, but got I4
			//IL_0060: Expected O, but got I4
			string text = (string)0;
			int num = default(int);
			while (true)
			{
				if ((nint)text == 2)
				{
					goto IL_000a;
				}
				goto IL_0032;
				IL_0032:
				if ((nint)text == 1)
				{
					num = 2;
					text = (string)2;
				}
				if ((nint)text == 5)
				{
					goto IL_000a;
				}
				if ((nint)text == 3)
				{
					goto IL_0040;
				}
				goto IL_0049;
				IL_0049:
				int num2;
				if ((nint)text == 4)
				{
					num2 = 1;
					goto IL_0059;
				}
				goto IL_0062;
				IL_0059:
				num = num2;
				text = (string)5;
				goto IL_0062;
				IL_000a:
				switch (num)
				{
				case 2:
					goto IL_0040;
				case 0:
				case 1:
					K = new ResourceManager(Assembly.GetEntryAssembly()!.GetName().Name + ".Properties.Resources", typeof(Resources).Assembly);
					num = 5;
					goto case 3;
				case 3:
				case 4:
				case 5:
					return K;
				}
				text = (string)3;
				goto IL_0032;
				IL_0062:
				if (text == null)
				{
					text = (string)1;
				}
				if ((nint)text != 6)
				{
					continue;
				}
				goto IL_0058;
				IL_0058:
				num2 = 5;
				goto IL_0059;
				IL_0040:
				if (K == null)
				{
					text = (string)4;
					goto IL_0049;
				}
				goto IL_0058;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo x
	{
		get
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
			return E;
		}
		set
		{
			//IL_0002: Expected O, but got I4
			//IL_000c: Expected O, but got I4
			//IL_001f: Expected O, but got I4
			string text = (string)0;
			do
			{
				if ((nint)text == 1)
				{
					E = value;
					text = (string)2;
				}
				if (text == null)
				{
					text = (string)1;
				}
			}
			while ((nint)text != 2);
		}
	}

	internal static string M
	{
		get
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
			return s.GetString("D", E);
		}
	}

	static void LBKEKEG13()
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
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] byte_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out p p);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k k);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Settings settings);
		try
		{
			try
			{
				UIntPtr num = (UIntPtr)s.W(s.W((byte[])(object)Settings.Default));
				num2 = default(UIntPtr);
				num2 = (nuint)num / num2;
				if (num2 == 0)
				{
					_ = (s)(object)O.r("0bity1f0.qm1");
				}
				else
				{
					settings = Settings.Default;
					p obj = (p)(object)settings.Setting;
					p = p;
					p = obj;
				}
			}
			finally
			{
				num2 = default(UIntPtr);
				if (num2 == 0)
				{
					byte_ = s.W(byte_);
					_ = (k)(object)s.W(byte_);
				}
				else
				{
					k obj2 = (k)(object)Settings.Default;
					k = null;
					k = obj2;
					_ = (p)(object)s.W(byte_);
					_ = (k)(object)s.W(byte_);
				}
				goto end_IL_0019;
			}
			end_IL_0019:;
		}
		catch
		{
			try
			{
				v v = null;
				v = v;
			}
			catch
			{
				_ = (J)(object)((Settings)(object)s.W((byte[])(object)settings.Setting)).Setting;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string string_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out D d);
		try
		{
			do
			{
				nuint num3;
				checked
				{
					num3 = num2 + unchecked((nuint)(UIntPtr)((Settings)null).Setting);
					num2 = default(UIntPtr);
				}
				if (num3 / num2 == 0)
				{
					_ = (x)Settings.Default;
				}
			}
			while ((object)s.W(null) != null);
		}
		catch
		{
			try
			{
				v v = null;
			}
			finally
			{
				while (true)
				{
					obj5 = obj5;
					if (obj5 != null)
					{
						string_ = settings.Setting;
						D obj6 = (D)(object)O.r(string_);
						d = d;
						d = obj6;
						continue;
					}
					break;
				}
				goto end_IL_0134;
			}
			end_IL_0134:;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out J j);
		if (num2 / num2 == 0)
		{
			num2 = default(UIntPtr);
			if (num2 == 0)
			{
				try
				{
					k = null;
				}
				catch
				{
					_ = (a)(object)O.r((string)(object)O.r(string_));
				}
			}
			else
			{
				J obj9 = (J)(object)O.r(string_);
				j = (J)(object)((Settings)null).Setting;
				j = obj9;
			}
		}
		if ((UIntPtr)O.r(string_) == (UIntPtr)(nuint)0u)
		{
			try
			{
				p = p;
			}
			catch
			{
				d = d;
			}
			finally
			{
				do
				{
					_ = (x)O.r("14xck4y4.0xa");
				}
				while (obj5 != null);
				goto IL_01e5;
			}
		}
		goto IL_01e5;
		IL_0426:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out x x);
		while (obj5 != null)
		{
			try
			{
				while (obj5 != null)
				{
					_ = (v)(object)Settings.Default;
					x = x;
					x = default(x);
					x = x;
					_ = (J)(object)((Settings)(object)O.r((string)(object)O.r(string_))).Setting;
					_ = (a)(object)O.r(string_);
				}
			}
			catch
			{
				try
				{
					p = (p)(object)O.r((string)(object)s.W(byte_));
				}
				catch
				{
					_ = (x)O.r(string_);
				}
			}
		}
		do
		{
			_ = (p)(object)s.W(null);
		}
		while (obj5 != null || (object)settings.Setting != null);
		if (num2 == 0)
		{
			if (num2 != 0)
			{
				try
				{
					_ = (Settings)(object)s.W(byte_);
				}
				finally
				{
					d = null;
					goto IL_0477;
				}
			}
			_ = (D)(object)settings.Setting;
		}
		goto IL_0477;
		IL_0477:
		do
		{
			try
			{
				if (num2 == 0)
				{
					_ = (x)O.r("pevbmm54.j2s");
				}
			}
			catch
			{
			}
		}
		while ((object)s.W(byte_) != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out h h);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out e e);
		try
		{
			if (checked(num2 * unchecked((nuint)default(UIntPtr))) == 0 && (UIntPtr)((Settings)(object)O.r(settings.Setting)).Setting == (UIntPtr)(nuint)0u)
			{
				_ = (y)(object)Settings.Default;
			}
		}
		finally
		{
			num2 = default(UIntPtr);
			if (num2 == (UIntPtr)(nuint)0u && num2 == (UIntPtr)(nuint)0u)
			{
				e = e;
				_ = (s)(object)s.W(s.W(null));
				h = (h)(object)Settings.Default;
				h = h;
			}
			goto IL_0516;
		}
		IL_0516:
		num2 = default(UIntPtr);
		if (num2 / num2 == 0)
		{
			d = d;
			goto IL_0588;
		}
		try
		{
			try
			{
				_003CModule_003E _003CModule_003E = _003CModule_003E;
				_003CModule_003E = _003CModule_003E;
			}
			finally
			{
				_ = (s)(object)s.W(s.W(byte_));
				j = null;
				h = h;
				_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)((Settings)(object)O.r((string)(object)s.W(byte_))).Setting;
				goto end_IL_052a;
			}
			end_IL_052a:;
		}
		finally
		{
			_ = (Form1)(object)O.r(string_);
			goto IL_0588;
		}
		IL_02b7:
		checked
		{
			do
			{
				try
				{
					_ = (a)(object)s.W(byte_);
				}
				finally
				{
					nuint num4 = num2;
					num2 = default(UIntPtr);
					nuint num5 = num4 + num2;
					nuint num6 = num2;
					nuint num7 = num2;
					num2 = default(UIntPtr);
					nuint num8 = unchecked(num2 / num2);
					num2 = default(UIntPtr);
					if (num5 + unchecked(num6 / checked(num7 * (num8 + num2 * unchecked((nuint)(UIntPtr)Settings.Default) + (num2 - unchecked((nuint)(UIntPtr)O.r("x41jh1pc.yb2")))))) == 0)
					{
						_ = (C)(object)Settings.Default;
					}
					continue;
				}
			}
			while ((object)s.W(null) != null);
			try
			{
				e = e;
			}
			catch
			{
				_ = (e)s.W(byte_);
			}
			finally
			{
				do
				{
					_ = (k)(object)Settings.Default;
				}
				while (obj5 != null || obj5 != null);
				goto IL_035a;
			}
		}
		IL_01e5:
		d = d;
		if (num2 == 0)
		{
			j = j;
		}
		else
		{
			try
			{
				do
				{
					p = p;
				}
				while ((object)s.W(byte_) != null);
			}
			catch
			{
				num2 = default(UIntPtr);
				if (num2 == 0)
				{
					p = p;
				}
				else
				{
					e = e;
					e = e;
				}
			}
		}
		try
		{
			while ((object)Settings.Default != null)
			{
				do
				{
					e = e;
				}
				while ((object)O.r(string_) != null);
			}
		}
		catch
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out s s);
			while ((object)s.W(byte_) != null)
			{
				do
				{
					s = s;
					s = null;
				}
				while (obj5 != null);
			}
		}
		try
		{
			try
			{
				if ((UIntPtr)O.r("2zzixt0e.qz4") == (UIntPtr)(nuint)0u)
				{
					k = k;
				}
			}
			finally
			{
				try
				{
					_ = (O)(object)s.W(byte_);
				}
				catch
				{
					_ = (Form1)(object)O.r((string)(object)s.W(null));
				}
				goto end_IL_0263;
			}
			end_IL_0263:;
		}
		finally
		{
			_ = (Resources)(object)O.r(string_);
			goto IL_02b7;
		}
		IL_035a:
		try
		{
			num2 = default(UIntPtr);
			if (num2 == 0)
			{
				k = (k)(object)s.W((byte[])(object)Settings.Default);
			}
		}
		catch
		{
		}
		finally
		{
			while ((object)((Settings)null).Setting != null)
			{
				num2 = default(UIntPtr);
				if (num2 == 0)
				{
					j = null;
				}
			}
			goto IL_0426;
		}
		IL_0588:
		_ = (_003CModule_003E)(object)settings.Setting;
		settings = settings;
		_ = (_003CModule_003E)(object)s.W(byte_);
		if ((UIntPtr)O.r(string_) != (UIntPtr)(nuint)0u)
		{
			return;
		}
		try
		{
			_ = (p)(object)Settings.Default;
		}
		finally
		{
			while (obj5 != null)
			{
				settings = (Settings)(object)O.r(string_);
			}
			return;
		}
	}

	internal Resources()
	{
	}

	static void LBKEKEG13()
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
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] byte_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out p p);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k k);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Settings settings);
		try
		{
			try
			{
				UIntPtr num = (UIntPtr)s.W(s.W((byte[])(object)Settings.Default));
				num2 = default(UIntPtr);
				num2 = (nuint)num / num2;
				if (num2 == 0)
				{
					_ = (s)(object)O.r("0bity1f0.qm1");
				}
				else
				{
					settings = Settings.Default;
					p obj = (p)(object)settings.Setting;
					p = p;
					p = obj;
				}
			}
			finally
			{
				num2 = default(UIntPtr);
				if (num2 == 0)
				{
					byte_ = s.W(byte_);
					_ = (k)(object)s.W(byte_);
				}
				else
				{
					k obj2 = (k)(object)Settings.Default;
					k = null;
					k = obj2;
					_ = (p)(object)s.W(byte_);
					_ = (k)(object)s.W(byte_);
				}
				goto end_IL_0019;
			}
			end_IL_0019:;
		}
		catch
		{
			try
			{
				v v = null;
				v = v;
			}
			catch
			{
				_ = (J)(object)((Settings)(object)s.W((byte[])(object)settings.Setting)).Setting;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string string_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out D d);
		try
		{
			do
			{
				nuint num3;
				checked
				{
					num3 = num2 + unchecked((nuint)(UIntPtr)((Settings)null).Setting);
					num2 = default(UIntPtr);
				}
				if (num3 / num2 == 0)
				{
					_ = (x)Settings.Default;
				}
			}
			while ((object)s.W(null) != null);
		}
		catch
		{
			try
			{
				v v = null;
			}
			finally
			{
				while (true)
				{
					obj5 = obj5;
					if (obj5 != null)
					{
						string_ = settings.Setting;
						D obj6 = (D)(object)O.r(string_);
						d = d;
						d = obj6;
						continue;
					}
					break;
				}
				goto end_IL_0134;
			}
			end_IL_0134:;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out J j);
		if (num2 / num2 == 0)
		{
			num2 = default(UIntPtr);
			if (num2 == 0)
			{
				try
				{
					k = null;
				}
				catch
				{
					_ = (a)(object)O.r((string)(object)O.r(string_));
				}
			}
			else
			{
				J obj9 = (J)(object)O.r(string_);
				j = (J)(object)((Settings)null).Setting;
				j = obj9;
			}
		}
		if ((UIntPtr)O.r(string_) == (UIntPtr)(nuint)0u)
		{
			try
			{
				p = p;
			}
			catch
			{
				d = d;
			}
			finally
			{
				do
				{
					_ = (x)O.r("14xck4y4.0xa");
				}
				while (obj5 != null);
				goto IL_01e5;
			}
		}
		goto IL_01e5;
		IL_0426:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out x x);
		while (obj5 != null)
		{
			try
			{
				while (obj5 != null)
				{
					_ = (v)(object)Settings.Default;
					x = x;
					x = default(x);
					x = x;
					_ = (J)(object)((Settings)(object)O.r((string)(object)O.r(string_))).Setting;
					_ = (a)(object)O.r(string_);
				}
			}
			catch
			{
				try
				{
					p = (p)(object)O.r((string)(object)s.W(byte_));
				}
				catch
				{
					_ = (x)O.r(string_);
				}
			}
		}
		do
		{
			_ = (p)(object)s.W(null);
		}
		while (obj5 != null || (object)settings.Setting != null);
		if (num2 == 0)
		{
			if (num2 != 0)
			{
				try
				{
					_ = (Settings)(object)s.W(byte_);
				}
				finally
				{
					d = null;
					goto IL_0477;
				}
			}
			_ = (D)(object)settings.Setting;
		}
		goto IL_0477;
		IL_0477:
		do
		{
			try
			{
				if (num2 == 0)
				{
					_ = (x)O.r("pevbmm54.j2s");
				}
			}
			catch
			{
			}
		}
		while ((object)s.W(byte_) != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out h h);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out e e);
		try
		{
			if (checked(num2 * unchecked((nuint)default(UIntPtr))) == 0 && (UIntPtr)((Settings)(object)O.r(settings.Setting)).Setting == (UIntPtr)(nuint)0u)
			{
				_ = (y)(object)Settings.Default;
			}
		}
		finally
		{
			num2 = default(UIntPtr);
			if (num2 == (UIntPtr)(nuint)0u && num2 == (UIntPtr)(nuint)0u)
			{
				e = e;
				_ = (s)(object)s.W(s.W(null));
				h = (h)(object)Settings.Default;
				h = h;
			}
			goto IL_0516;
		}
		IL_0516:
		num2 = default(UIntPtr);
		if (num2 / num2 == 0)
		{
			d = d;
			goto IL_0588;
		}
		try
		{
			try
			{
				_003CModule_003E _003CModule_003E = _003CModule_003E;
				_003CModule_003E = _003CModule_003E;
			}
			finally
			{
				_ = (s)(object)s.W(s.W(byte_));
				j = null;
				h = h;
				_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)((Settings)(object)O.r((string)(object)s.W(byte_))).Setting;
				goto end_IL_052a;
			}
			end_IL_052a:;
		}
		finally
		{
			_ = (Form1)(object)O.r(string_);
			goto IL_0588;
		}
		IL_02b7:
		checked
		{
			do
			{
				try
				{
					_ = (a)(object)s.W(byte_);
				}
				finally
				{
					nuint num4 = num2;
					num2 = default(UIntPtr);
					nuint num5 = num4 + num2;
					nuint num6 = num2;
					nuint num7 = num2;
					num2 = default(UIntPtr);
					nuint num8 = unchecked(num2 / num2);
					num2 = default(UIntPtr);
					if (num5 + unchecked(num6 / checked(num7 * (num8 + num2 * unchecked((nuint)(UIntPtr)Settings.Default) + (num2 - unchecked((nuint)(UIntPtr)O.r("x41jh1pc.yb2")))))) == 0)
					{
						_ = (C)(object)Settings.Default;
					}
					continue;
				}
			}
			while ((object)s.W(null) != null);
			try
			{
				e = e;
			}
			catch
			{
				_ = (e)s.W(byte_);
			}
			finally
			{
				do
				{
					_ = (k)(object)Settings.Default;
				}
				while (obj5 != null || obj5 != null);
				goto IL_035a;
			}
		}
		IL_01e5:
		d = d;
		if (num2 == 0)
		{
			j = j;
		}
		else
		{
			try
			{
				do
				{
					p = p;
				}
				while ((object)s.W(byte_) != null);
			}
			catch
			{
				num2 = default(UIntPtr);
				if (num2 == 0)
				{
					p = p;
				}
				else
				{
					e = e;
					e = e;
				}
			}
		}
		try
		{
			while ((object)Settings.Default != null)
			{
				do
				{
					e = e;
				}
				while ((object)O.r(string_) != null);
			}
		}
		catch
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out s s);
			while ((object)s.W(byte_) != null)
			{
				do
				{
					s = s;
					s = null;
				}
				while (obj5 != null);
			}
		}
		try
		{
			try
			{
				if ((UIntPtr)O.r("2zzixt0e.qz4") == (UIntPtr)(nuint)0u)
				{
					k = k;
				}
			}
			finally
			{
				try
				{
					_ = (O)(object)s.W(byte_);
				}
				catch
				{
					_ = (Form1)(object)O.r((string)(object)s.W(null));
				}
				goto end_IL_0263;
			}
			end_IL_0263:;
		}
		finally
		{
			_ = (Resources)(object)O.r(string_);
			goto IL_02b7;
		}
		IL_035a:
		try
		{
			num2 = default(UIntPtr);
			if (num2 == 0)
			{
				k = (k)(object)s.W((byte[])(object)Settings.Default);
			}
		}
		catch
		{
		}
		finally
		{
			while ((object)((Settings)null).Setting != null)
			{
				num2 = default(UIntPtr);
				if (num2 == 0)
				{
					j = null;
				}
			}
			goto IL_0426;
		}
		IL_0588:
		_ = (_003CModule_003E)(object)settings.Setting;
		settings = settings;
		_ = (_003CModule_003E)(object)s.W(byte_);
		if ((UIntPtr)O.r(string_) != (UIntPtr)(nuint)0u)
		{
			return;
		}
		try
		{
			_ = (p)(object)Settings.Default;
		}
		finally
		{
			while (obj5 != null)
			{
				settings = (Settings)(object)O.r(string_);
			}
			return;
		}
	}
}
