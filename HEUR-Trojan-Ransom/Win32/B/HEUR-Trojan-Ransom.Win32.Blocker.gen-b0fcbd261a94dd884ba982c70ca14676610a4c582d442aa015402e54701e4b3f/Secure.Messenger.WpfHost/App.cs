using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Windows;

namespace Secure.Messenger.WpfHost;

public class App : Application
{
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		App.smethod_1((Application)(object)this, App.smethod_0("MainWindow.xaml", UriKind.Relative));
	}

	[STAThread]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public static void Main()
	{
		App app = new App();
		app.InitializeComponent();
		((Application)app).Run();
	}

	static Uri smethod_0(string string_0, UriKind uriKind_0)
	{
		return new Uri(string_0, uriKind_0);
	}

	static void smethod_1(Application application_0, Uri uri_0)
	{
		application_0.set_StartupUri(uri_0);
	}
}
