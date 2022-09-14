using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Windows;

namespace Ty6CWyxFEL;

public class v3DIBAK4ky : Application
{
	private bool W48C7l6Gbe;

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void IhmZIN8aO7()
	{
		if (!W48C7l6Gbe)
		{
			W48C7l6Gbe = true;
			((Application)this).set_StartupUri(new Uri("MainWindow.xaml", UriKind.Relative));
			Uri uri = new Uri("/Ty6CWyxFEL;component/app.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[STAThread]
	public static void LgfC4Lv63x()
	{
		v3DIBAK4ky v3DIBAK4ky2 = new v3DIBAK4ky();
		v3DIBAK4ky2.IhmZIN8aO7();
		((Application)v3DIBAK4ky2).Run();
	}
}
