using System;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Security;
using Fm;

internal sealed class vjAfyyHERCFsPlRLQPFPIdrADjevb : CustomLineCap
{
	private sealed class WiFgPfibGGcZDPzNNChkkJsHzPHTA
	{
		private WiFgPfibGGcZDPzNNChkkJsHzPHTA()
		{
		}

		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		internal static extern bool MessageBeep(int int_0);
	}

	private int QAPxdMffuECfbEpkmKZjGGWPipqQA;

	static vjAfyyHERCFsPlRLQPFPIdrADjevb()
	{
		jloCgwDFQlKmYgFAYzIZkkQpeKLt.smethod_1();
	}

	public void method_0()
	{
		AXSXXRjemidGzjsdUNVflPwajeRhb.obvEJoafjvJYqXSHAtzosYubGyYl.Assert();
		try
		{
			WiFgPfibGGcZDPzNNChkkJsHzPHTA.MessageBeep(QAPxdMffuECfbEpkmKZjGGWPipqQA);
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

	public vjAfyyHERCFsPlRLQPFPIdrADjevb(GraphicsPath graphicsPath_0, GraphicsPath graphicsPath_1)
		: base(graphicsPath_0, graphicsPath_1)
	{
	}

	public vjAfyyHERCFsPlRLQPFPIdrADjevb(GraphicsPath graphicsPath_0, GraphicsPath graphicsPath_1, LineCap lineCap_0)
		: base(graphicsPath_0, graphicsPath_1, lineCap_0)
	{
	}//IL_0003: Unknown result type (might be due to invalid IL or missing references)


	public vjAfyyHERCFsPlRLQPFPIdrADjevb(GraphicsPath graphicsPath_0, GraphicsPath graphicsPath_1, LineCap lineCap_0, float float_0)
		: base(graphicsPath_0, graphicsPath_1, lineCap_0, float_0)
	{
	}//IL_0003: Unknown result type (might be due to invalid IL or missing references)

}
