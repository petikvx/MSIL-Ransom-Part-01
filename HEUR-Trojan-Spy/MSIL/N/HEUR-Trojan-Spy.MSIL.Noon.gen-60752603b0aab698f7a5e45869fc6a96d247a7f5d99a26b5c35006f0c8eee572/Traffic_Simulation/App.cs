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
			int num = -1599086785;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8A48B9C4u) % 3u)
				{
				case 2u:
					goto IL_0003;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0003:
				App.smethod_1((Application)(object)this, App.smethod_0("MainWindow.xaml", UriKind.Relative));
				num = ((int)num2 * -1283902518) ^ -2049633386;
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
			int num = 382599648;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7AB1776Cu) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 0u:
					break;
				default:
					((Application)app).Run();
					return;
				}
				break;
				IL_0003:
				app = new App();
				app.InitializeComponent();
				num = (int)((num2 * 936488844) ^ 0x90D4674);
			}
		}
	}

	public App()
	{
		while (true)
		{
			int num = 838408131;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1AA5395Au) % 3u)
				{
				case 1u:
					goto IL_0008;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0008:
				num = ((int)num2 * -967292742) ^ -1648879179;
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
