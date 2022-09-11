using System;
using System.CodeDom.Compiler;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows;
using ns5;
using ns7;

namespace ns1;

public class GClass0 : Application
{
	private static byte[] _array;

	private static GCHandle _pinningHandle;

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void method_0()
	{
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[SecuritySafeCritical]
	[STAThread]
	public static void Main()
	{
		byte[] array = Class3.smethod_0();
		if (array.Length == 0)
		{
			array = new byte[1];
		}
		_array = array;
		_pinningHandle = default(GCHandle);
		new GClass0().method_0();
		GClass2.smethod_0();
	}

	internal static char smethod_0()
	{
		return 'd';
	}
}
