using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Windows;

namespace Traffic_Simulation;

public class App : Application
{
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		while (true)
		{
			int num = 1565241146;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x19DA7060u) % 4u)
				{
				case 3u:
					num = ((int)num2 * -898722161) ^ -915722400;
					continue;
				case 2u:
					App.smethod_1((Application)(object)this, App.smethod_0("MainWindow.xaml", UriKind.Relative));
					num = ((int)num2 * -248154515) ^ 0x4784A381;
					continue;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	[STAThread]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public static void Main()
	{
		App app = default(App);
		while (true)
		{
			int num = 1095849201;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x31919419u) % 5u)
				{
				case 3u:
					app = new App();
					num = ((int)num2 * -1811301616) ^ -1605567937;
					continue;
				case 1u:
					((Application)app).Run();
					num = ((int)num2 * -1127312859) ^ 0x3AF43024;
					continue;
				case 0u:
					app.InitializeComponent();
					num = ((int)num2 * -94083303) ^ 0x342E9496;
					continue;
				default:
					return;
				case 4u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	static Uri smethod_0(string string_0, UriKind uriKind_0)
	{
		return new Uri(string_0, uriKind_0);
	}

	static void smethod_1(Application application_0, Uri uri_0)
	{
		application_0.set_StartupUri(uri_0);
	}

	static int smethod_2(Application application_0)
	{
		return application_0.Run();
	}
}
