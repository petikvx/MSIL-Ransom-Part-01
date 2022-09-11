using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns1;

namespace ns0;

public class cc : Control
{
	private IContainer icontainer_0;

	public cc()
	{
		method_0();
	}

	protected override void vmethod_0(PaintEventArgs paintEventArgs_0)
	{
		((Control)this).OnPaint(paintEventArgs_0);
	}

	protected override void vmethod_1(bool bool_0)
	{
		if (bool_0 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Control)this).Dispose(bool_0);
	}

	public static void smethod_0()
	{
		Class0.smethod_0();
		Control2.smethod_0();
	}

	public static void smethod_1(AppDomain appDomain_0)
	{
	}

	public static void smethod_2(AppDomain appDomain_0)
	{
		try
		{
			Class2.smethod_0(appDomain_0);
		}
		catch (Exception ex)
		{
			Console.WriteLine();
			Console.WriteLine(ex.Message);
		}
	}

	private void method_0()
	{
		icontainer_0 = new Container();
	}

	unsafe static void esawasog5()
	{
		//IL_0017: Expected O, but got I4
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got I4
		//IL_0042: Expected O, but got I4
		//IL_004c: Expected O, but got I4
		//IL_0077: Expected O, but got I4
		//IL_00c7: Expected O, but got I4
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected Ref, but got Unknown
		//IL_00dd: Expected O, but got I4
		//IL_0110: Expected O, but got I4
		//IL_011f: Expected O, but got I4
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b);
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Class1 @class);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b2);
			object obj;
			do
			{
				@class = @class;
				@class = null;
				b = 66;
				b = b2;
				obj = ((byte*)b)->GetHashCode();
			}
			while (checked(2 + (0 + ((obj is bool) ? obj : null))) != 0);
		}
		finally
		{
			goto IL_0023;
		}
		IL_0023:
		string text;
		try
		{
			b = b;
		}
		catch
		{
			while (true)
			{
				_ = ((byte*)203)->Equals(null) is _003CModule_003E;
				object obj2 = ((byte*)b)->GetHashCode();
				_ = ((byte*)((obj2 is byte) ? obj2 : null))->GetHashCode() is string;
			}
		}
		finally
		{
			text = (string)(object)Control4.smethod_1(null);
			byte.Parse(text);
			goto IL_006a;
		}
		IL_006a:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles numberStyles);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] byte_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out uc uc2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out uc uc3);
		while (true)
		{
			text = text;
			text = text2;
			_ = text.EndsWith(text) is ResolveEventArgs;
			string s = text;
			numberStyles = numberStyles;
			numberStyles = default(NumberStyles);
			NumberStyles style = numberStyles;
			byte num = (byte)Control4.smethod_1(byte_);
			IFormatProvider formatProvider = (IFormatProvider)(object)((byte*)checked(159u - unchecked((uint)byte.Parse(text, numberStyles))))->ToString();
			formatProvider = formatProvider2;
			object obj4 = ((byte*)num)->ToString(formatProvider3).LastIndexOfAny(null, -2062869233);
			byte_ = ((byte*)checked(((obj4 is byte) ? obj4 : null) + 22 + 19))->GetHashCode() as byte[];
			_ = (IFormatProvider)(object)Control4.smethod_1(byte_);
			formatProvider = (IFormatProvider)GClass0.smethod_0(null, resolveEventArgs_);
			formatProvider = formatProvider4;
			formatProvider = formatProvider5;
			resolveEventArgs_ = byte.TryParse(s, style, formatProvider, out *(byte*)null) as ResolveEventArgs;
			object object_ = Control1.smethod_0(resolveEventArgs_) as object;
			_ = (Control4)(object)GClass0.smethod_0(object_, resolveEventArgs_);
			uc2 = uc2;
			uc2 = uc3;
			uc2 = uc2;
		}
	}
}
