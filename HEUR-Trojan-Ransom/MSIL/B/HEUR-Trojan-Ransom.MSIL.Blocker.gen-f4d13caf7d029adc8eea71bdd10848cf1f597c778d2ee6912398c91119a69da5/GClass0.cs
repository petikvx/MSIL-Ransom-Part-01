using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Windows;

public class GClass0 : Application
{
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void method_0()
	{
		GClass0.smethod_1((Application)(object)this, GClass0.smethod_0("kltidlvmddmafzjtpegdvcuwmajt.xaml", UriKind.Relative));
	}

	[STAThread]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public static void Main()
	{
		GClass0 gClass = new GClass0();
		gClass.method_0();
		((Application)gClass).Run();
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
