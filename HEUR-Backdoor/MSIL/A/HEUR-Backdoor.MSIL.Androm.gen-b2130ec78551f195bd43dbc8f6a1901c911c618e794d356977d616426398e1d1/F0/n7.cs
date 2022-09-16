using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Windows;

namespace F0;

public class n7 : Application
{
	internal static n7 WI;

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void ugK()
	{
		((Application)this).set_StartupUri(new Uri((string)kx(372), UriKind.Relative));
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[STAThread]
	[DebuggerNonUserCode]
	public static void Fgl()
	{
		n7 n8 = new n7();
		n8.ugK();
		((Application)n8).Run();
	}

	internal static object kx(int int_0)
	{
		return sE.znu(int_0);
	}

	internal static bool ju()
	{
		return WI == null;
	}

	internal static n7 LT()
	{
		return WI;
	}
}
