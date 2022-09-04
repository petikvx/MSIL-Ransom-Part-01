using System;
using System.IO;
using ns1;
using ns4;
using ns6;
using ns8;

namespace ns0;

internal sealed class Class43
{
	private static Class41 class41_0;

	public static void smethod_0()
	{
		if (class41_0 != null)
		{
			class41_0.System_002EIDisposable_002EDispose();
			class41_0 = null;
		}
		class41_0 = new Class41();
		class41_0.method_0(smethod_2);
		new Delegate3(smethod_1).BeginInvoke(null, null);
	}

	private static void smethod_1()
	{
		try
		{
			foreach (Class38 item in class41_0.method_1())
			{
				Class2.smethod_13(item.method_4());
			}
		}
		catch (Exception)
		{
		}
	}

	private static void smethod_2(EventArgs0 eventArgs0_0)
	{
		if (eventArgs0_0.method_2() == Enum7.const_0)
		{
			string text = eventArgs0_0.method_0().method_4();
			string text2 = text;
			char directorySeparatorChar = Path.DirectorySeparatorChar;
			if (!text2.EndsWith(directorySeparatorChar.ToString()))
			{
				text += Path.DirectorySeparatorChar;
			}
			Class2.smethod_13(text);
		}
	}
}
