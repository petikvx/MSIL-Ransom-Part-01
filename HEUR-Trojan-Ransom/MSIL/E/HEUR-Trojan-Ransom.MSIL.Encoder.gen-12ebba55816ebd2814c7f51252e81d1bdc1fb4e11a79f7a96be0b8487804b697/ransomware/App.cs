using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Windows;

namespace ransomware;

public class App : Application
{
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		((Application)this).set_StartupUri(new Uri("BGWin.xaml", UriKind.Relative));
	}

	[STAThread]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public static void Main()
	{
		App app = new App();
		app.InitializeComponent();
		((Application)app).Run();
	}
}
