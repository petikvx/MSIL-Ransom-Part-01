using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Windows;

namespace FileEncryptor;

public class App : Application
{
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		((Application)this).set_StartupUri(new Uri("MainWindow.xaml", UriKind.Relative));
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[STAThread]
	public static void Main()
	{
		App app = new App();
		app.InitializeComponent();
		((Application)app).Run();
	}
}
