using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Windows;

namespace Creep;

public class App : Application
{
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		((Application)this).set_StartupUri(new Uri("MainWindow.xaml", UriKind.Relative));
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[STAThread]
	[DebuggerNonUserCode]
	public static void Main()
	{
		App app = new App();
		app.InitializeComponent();
		((Application)app).Run();
	}
}
