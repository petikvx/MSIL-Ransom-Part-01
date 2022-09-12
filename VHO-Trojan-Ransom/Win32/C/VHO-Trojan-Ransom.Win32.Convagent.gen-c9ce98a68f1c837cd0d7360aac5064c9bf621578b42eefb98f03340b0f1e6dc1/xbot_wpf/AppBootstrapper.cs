using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows;
using System.Windows.Threading;
using Caliburn.Micro;
using Caliburn.Micro.Logging.NLog;
using Microsoft.Win32;
using xbot_wpf.Common;
using xbot_wpf.Services;
using xbot_wpf.Views;

namespace xbot_wpf;

public class AppBootstrapper : BootstrapperBase
{
	private SimpleContainer simpleContainer_0;

	private static Mutex mutex_0;

	private static bool smethod_0()
	{
		mutex_0 = new Mutex(initiallyOwned: true, "Xbot", out var createdNew);
		return createdNew;
	}

	public AppBootstrapper()
	{
		Class24.nhQmSIPz7n4eU();
		((BootstrapperBase)this)._002Ector(true);
		if (!Directory.Exists(Const.DataDirectory))
		{
			Directory.CreateDirectory(Const.DataDirectory);
		}
		AppDomain.CurrentDomain.SetData("DataDirectory", Const.DataDirectory);
		((BootstrapperBase)this).Initialize();
		method_1();
	}

	private bool method_0()
	{
		try
		{
			using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\XBot"))
			{
				if (registryKey != null)
				{
					object value = registryKey.GetValue("x_t__bot");
					if (value != null && value.ToString() == Const.RegistryValue)
					{
						return true;
					}
				}
			}
			return false;
		}
		catch (Exception)
		{
			return false;
		}
	}

	private void method_1()
	{
	}

	protected override void Configure()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		simpleContainer_0 = new SimpleContainer();
		simpleContainer_0.RegisterInstance(typeof(ILog), (string)null, (object)new NLogLogger(((object)this).GetType()));
		ContainerExtensions.Singleton<IWindowManager, WindowManager>(simpleContainer_0, (string)null);
		ContainerExtensions.Singleton<IApiMarketCsgoCom, ApiMarketCsgoCom>(simpleContainer_0, (string)null);
		ContainerExtensions.Singleton<GInterface2, ApiMarketDota2Net>(simpleContainer_0, (string)null);
		ContainerExtensions.Singleton<IEventAggregator, EventAggregator>(simpleContainer_0, (string)null);
		ContainerExtensions.PerRequest<IMainViewModel, MainViewModel>(simpleContainer_0, (string)null);
		ContainerExtensions.PerRequest<ILoginViewModel, LoginViewModel>(simpleContainer_0, (string)null);
		ContainerExtensions.PerRequest<GInterface0, SettingsViewModel>(simpleContainer_0, (string)null);
		ContainerExtensions.PerRequest<ISteamTraderViewModel, SteamTraderViewModel>(simpleContainer_0, (string)null);
		ContainerExtensions.PerRequest<IMessageBox, StandardMessageBox>(simpleContainer_0, (string)null);
		ContainerExtensions.PerRequest<GInterface1, ExporterAnalytics>(simpleContainer_0, (string)null);
	}

	private void method_2()
	{
	}

	protected override object GetInstance(Type service, string key)
	{
		_003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass8_0();
		CS_0024_003C_003E8__locals0.key = key;
		if (service == null && !string.IsNullOrWhiteSpace(CS_0024_003C_003E8__locals0.key))
		{
			service = Type.GetType((from x in Assembly.GetExecutingAssembly().DefinedTypes
				where x.Name == CS_0024_003C_003E8__locals0.key
				select x.FullName).FirstOrDefault() ?? throw new InvalidOperationException("No matching type found"));
			CS_0024_003C_003E8__locals0.key = null;
		}
		object instance = simpleContainer_0.GetInstance(service, CS_0024_003C_003E8__locals0.key);
		if (instance == null)
		{
			throw new InvalidOperationException("Could not locate any instances.");
		}
		return instance;
	}

	protected override IEnumerable<object> GetAllInstances(Type service)
	{
		return simpleContainer_0.GetAllInstances(service);
	}

	protected override void BuildUp(object instance)
	{
		simpleContainer_0.BuildUp(instance);
	}

	protected override void OnStartup(object sender, StartupEventArgs e)
	{
		((BootstrapperBase)this).OnStartup(sender, e);
		method_2();
		method_3();
	}

	private void method_3()
	{
		IWindowManager obj = IoC.Get<IWindowManager>((string)null);
		ILoginViewModel loginViewModel = IoC.Get<ILoginViewModel>((string)null);
		obj.ShowWindow((object)loginViewModel, (object)null, (IDictionary<string, object>)null);
	}

	protected override void OnUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
	{
		ILog obj = IoC.Get<ILog>((string)null);
		obj.Warn("Fatal exception!", Array.Empty<object>());
		obj.Error(e.get_Exception());
	}
}
