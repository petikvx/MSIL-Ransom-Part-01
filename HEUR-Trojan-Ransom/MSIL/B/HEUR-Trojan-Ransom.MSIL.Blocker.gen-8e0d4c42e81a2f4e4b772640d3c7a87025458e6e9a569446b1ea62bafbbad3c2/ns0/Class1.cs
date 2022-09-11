using System;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Security;
using Fm;
using ns1;

namespace ns0;

internal sealed class Class1 : CustomLineCap
{
	private sealed class Class2
	{
		private Class2()
		{
		}

		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		internal static extern bool MessageBeep(int int_0);
	}

	private int int_0;

	static Class1()
	{
		GClass1.smethod_1();
	}

	public void method_0()
	{
		Class7.codeAccessPermission_0.Assert();
		try
		{
			Class2.MessageBeep(int_0);
		}
		finally
		{
			CodeAccessPermission.RevertAssert();
		}
	}

	[STAThread]
	public static int Main()
	{
		Program.Main();
		return 0;
	}

	public Class1(GraphicsPath graphicsPath_0, GraphicsPath graphicsPath_1)
		: base(graphicsPath_0, graphicsPath_1)
	{
	}

	public Class1(GraphicsPath graphicsPath_0, GraphicsPath graphicsPath_1, LineCap lineCap_0)
		: base(graphicsPath_0, graphicsPath_1, lineCap_0)
	{
	}//IL_0003: Unknown result type (might be due to invalid IL or missing references)


	public Class1(GraphicsPath graphicsPath_0, GraphicsPath graphicsPath_1, LineCap lineCap_0, float float_0)
		: base(graphicsPath_0, graphicsPath_1, lineCap_0, float_0)
	{
	}//IL_0003: Unknown result type (might be due to invalid IL or missing references)

}
