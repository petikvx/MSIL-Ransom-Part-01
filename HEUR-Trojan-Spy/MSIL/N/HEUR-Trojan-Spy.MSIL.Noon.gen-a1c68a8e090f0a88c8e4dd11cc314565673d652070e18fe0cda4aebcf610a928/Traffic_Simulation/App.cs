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
		App.smethod_1((Application)(object)this, App.smethod_0("MainWindow.xaml", UriKind.Relative));
	}

	[STAThread]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public static void Main()
	{
		App app = default(App);
		while (true)
		{
			int num = 1028573004;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x354E116Bu) % 5u)
				{
				case 3u:
					app.InitializeComponent();
					num = (int)((num2 * 2089481470) ^ 0x26F2C228);
					continue;
				case 2u:
					((Application)app).Run();
					num = (int)((num2 * 1141400305) ^ 0x2BCC5786);
					continue;
				case 1u:
					app = new App();
					num = ((int)num2 * -1075739835) ^ -1172298477;
					continue;
				default:
					return;
				case 4u:
					break;
				case 0u:
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
