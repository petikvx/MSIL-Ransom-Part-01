using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Windows;

namespace xbot_wpf;

public class App : Application
{
	private bool bool_0;

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!bool_0)
		{
			bool_0 = true;
			Uri uri = new Uri("/xtrades;component/app.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[DebuggerNonUserCode]
	[STAThread]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public static void Main()
	{
		App app = new App();
		app.InitializeComponent();
		((Application)app).Run();
	}
}
