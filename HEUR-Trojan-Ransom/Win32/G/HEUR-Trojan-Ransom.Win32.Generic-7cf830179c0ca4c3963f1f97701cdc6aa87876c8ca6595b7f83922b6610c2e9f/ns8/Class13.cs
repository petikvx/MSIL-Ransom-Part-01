using System;
using System.IO;
using ns2;
using ns5;
using ns6;
using ns7;

namespace ns8;

internal sealed class Class13
{
	private static Class27 class27_0;

	public static void smethod_0()
	{
		if (class27_0 != null)
		{
			class27_0.System_002EIDisposable_002EDispose();
			class27_0 = null;
		}
		class27_0 = new Class27();
		class27_0.method_0(smethod_2);
		new Delegate5(smethod_1).BeginInvoke(null, null);
	}

	private static void smethod_1()
	{
		try
		{
			foreach (Class12 item in class27_0.method_1())
			{
				Class18.smethod_13(item.method_4());
			}
		}
		catch (Exception)
		{
		}
	}

	private static void smethod_2(EventArgs0 eventArgs0_0)
	{
		if (eventArgs0_0.method_2() == Enum1.const_0)
		{
			string text = eventArgs0_0.method_0().method_4();
			string text2 = text;
			char directorySeparatorChar = Path.DirectorySeparatorChar;
			if (!text2.EndsWith(directorySeparatorChar.ToString()))
			{
				text += Path.DirectorySeparatorChar;
			}
			Class18.smethod_13(text);
		}
	}
}
