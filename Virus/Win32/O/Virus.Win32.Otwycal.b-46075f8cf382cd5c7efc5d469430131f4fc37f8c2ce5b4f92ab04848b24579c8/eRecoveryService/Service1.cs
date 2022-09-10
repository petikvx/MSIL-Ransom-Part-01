using System;
using System.Collections;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Ipc;
using System.Runtime.Serialization.Formatters;
using System.Security.Principal;
using System.ServiceProcess;
using System.Timers;
using IERYETF;
using Microsoft.Win32;
using ServiceInterface;
using eSettings.Model.Library;

namespace eRecoveryService;

public class Service1 : ServiceBase
{
	private IContainer components;

	private ServerClass eRServer;

	private ETFclass ETFServer;

	private IpcChannel channel;

	private Timer aTimer;

	private Timer obrTimer;

	private DateTime TotalTime;

	private bool IsPollingOBR;

	private bool bLog;

	private string szLogPath = "C:\\Acer\\Empowering Technology\\Logs";

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((ServiceBase)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		components = new Container();
		((ServiceBase)this).set_ServiceName("Service1");
		((ServiceBase)this).set_CanHandlePowerEvent(true);
	}

	public Service1()
	{
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		InitializeComponent();
		eRServer = new ServerClass();
		ETFServer = new ETFclass();
		RemotingServices.Marshal((MarshalByRefObject)eRServer, "ServerObj", typeof(Interface));
		SecurityIdentifier securityIdentifier = new SecurityIdentifier(WellKnownSidType.BuiltinUsersSid, null);
		RemotingServices.Marshal((MarshalByRefObject)ETFServer, "ETFServerObj", typeof(IERY));
		IDictionary dictionary = new Hashtable
		{
			[(object)"name"] = "ipcEr",
			[(object)"portName"] = "ipcErServer",
			[(object)"authorizedGroup"] = securityIdentifier.Translate(typeof(NTAccount)).ToString()
		};
		BinaryServerFormatterSinkProvider val = new BinaryServerFormatterSinkProvider();
		val.set_TypeFilterLevel(TypeFilterLevel.Full);
		BinaryClientFormatterSinkProvider val2 = new BinaryClientFormatterSinkProvider();
		channel = new IpcChannel(dictionary, (IClientChannelSinkProvider)(object)val2, (IServerChannelSinkProvider)(object)val);
	}

	private void OnTimedEvent(object sender, ElapsedEventArgs e)
	{
		aTimer.Enabled = false;
		if (!ImpersonateUser.IsHiddenPartitionExist())
		{
			ImpersonateUser.DeleteeRecovery();
			return;
		}
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\acer\\eRecovery", writable: false);
		string text = ((registryKey == null) ? "C:\\Acer\\Empowering Technology\\eRecovery" : ((registryKey.GetValue("InstallPath") == null) ? "C:\\Acer\\Empowering Technology\\eRecovery" : registryKey.GetValue("InstallPath")!.ToString()));
		text += "\\mbrwrwin.exe reinstall";
		WIN32.PROCESS_INFORMATION lpProcessInformation = default(WIN32.PROCESS_INFORMATION);
		WIN32.STARTUPINFO lpStartupInfo = default(WIN32.STARTUPINFO);
		WIN32.SECURITY_ATTRIBUTES lpProcessAttributes = default(WIN32.SECURITY_ATTRIBUTES);
		WIN32.SECURITY_ATTRIBUTES lpThreadAttributes = default(WIN32.SECURITY_ATTRIBUTES);
		lpProcessAttributes.nLength = Marshal.SizeOf((object)lpProcessAttributes);
		lpThreadAttributes.nLength = Marshal.SizeOf((object)lpThreadAttributes);
		WIN32.CreateProcess(null, text, ref lpProcessAttributes, ref lpThreadAttributes, bInheritHandles: false, 0u, IntPtr.Zero, null, ref lpStartupInfo, out lpProcessInformation);
	}

	protected override bool OnPowerEvent(PowerBroadcastStatus powerStatus)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Invalid comparison between Unknown and I4
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Invalid comparison between Unknown and I4
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		if ((int)powerStatus != 0)
		{
			if ((int)powerStatus != 4)
			{
				if ((int)powerStatus != 7)
				{
					return ((ServiceBase)this).OnPowerEvent(powerStatus);
				}
				if (bLog)
				{
					LogToFile("eRecoveryService", "OnPowerEvent ResumeSuspend", "IsPollingOBR is" + IsPollingOBR);
				}
				if (IsPollingOBR)
				{
					obrTimer.Enabled = true;
				}
				return true;
			}
			if (bLog)
			{
				LogToFile("eRecoveryService", "OnPowerEvent Suspend", "IsPollingOBR is" + IsPollingOBR);
			}
			if (IsPollingOBR)
			{
				obrTimer.Enabled = false;
			}
			return true;
		}
		if (bLog)
		{
			LogToFile("eRecoveryService", "OnPowerEvent QuerySuspend", "IsPollingOBR is" + IsPollingOBR);
		}
		if (IsPollingOBR)
		{
			obrTimer.Enabled = false;
		}
		return true;
	}

	private void obrTimer_Elapsed(object sender, ElapsedEventArgs e)
	{
		obrTimer.Enabled = false;
		if (bLog)
		{
			LogToFile("eRecoveryService Constructor", "obrTimer_Elapsed", "Polling OBR State");
		}
		if (INT15.GetOBRState() == 1)
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\acer\\eRecovery\\Main", writable: true);
			int num = Convert.ToInt32(registryKey.GetValue("obrpressed")!.ToString()) + 1;
			registryKey.SetValue("obrpressed", num);
			INT15.ClearOBRState();
		}
		obrTimer.Enabled = true;
	}

	private bool FirstRestortBoot()
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\acer\\eRecovery", writable: false);
		string text = ((registryKey == null) ? "C:\\Acer\\Empowering Technology\\eRecovery" : ((registryKey.GetValue("InstallPath") == null) ? "C:\\Acer\\Empowering Technology\\eRecovery" : registryKey.GetValue("InstallPath")!.ToString()));
		text += "\\FirstRestoreBoot.ini";
		if (File.Exists(text))
		{
			File.Delete(text);
			return true;
		}
		return false;
	}

	protected override void OnStart(string[] args)
	{
		bLog = NeedLog();
		if (bLog)
		{
			LogStart();
		}
		eRServer.GetSystemVolumnInfo();
		IChannel val = ChannelServices.GetChannel("ipcErServer");
		if (val != null)
		{
			ChannelServices.UnregisterChannel(val);
		}
		if (channel != null)
		{
			ChannelServices.RegisterChannel((IChannel)(object)channel, true);
		}
		eRServer.WriteLocalRegString("Software\\acer\\eRecovery\\Main", "obrpressed", 0);
		aTimer = new Timer();
		aTimer.Elapsed += OnTimedEvent;
		aTimer.Interval = 2000.0;
		aTimer.Enabled = true;
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\acer\\Empowering Technology 2.5\\Framework", writable: false);
		if (registryKey.GetValue("MachineType") != null)
		{
			if (Convert.ToInt32(registryKey.GetValue("MachineType")!.ToString()) != 1)
			{
				return;
			}
			RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("Software\\acer\\eRecovery\\Main", writable: false);
			if (registryKey2.GetValue("OBRpolling") != null)
			{
				if (Convert.ToInt32(registryKey2.GetValue("OBRpolling")) == 1)
				{
					int oBRState = INT15.GetOBRState();
					if (oBRState != 2)
					{
						IsPollingOBR = true;
						obrTimer = new Timer();
						obrTimer.Elapsed += obrTimer_Elapsed;
						obrTimer.Interval = 1000.0;
						obrTimer.Enabled = true;
					}
				}
			}
			else
			{
				int oBRState = INT15.GetOBRState();
				if (oBRState != 2)
				{
					IsPollingOBR = true;
					obrTimer = new Timer();
					obrTimer.Elapsed += obrTimer_Elapsed;
					obrTimer.Interval = 1000.0;
					obrTimer.Enabled = true;
				}
			}
			return;
		}
		RegistryKey registryKey3 = Registry.LocalMachine.OpenSubKey("Software\\acer\\eRecovery\\Main", writable: false);
		if (registryKey3.GetValue("OBRpolling") != null)
		{
			if (Convert.ToInt32(registryKey3.GetValue("OBRpolling")) == 1)
			{
				int oBRState = INT15.GetOBRState();
				if (oBRState != 2)
				{
					IsPollingOBR = true;
					obrTimer = new Timer();
					obrTimer.Elapsed += obrTimer_Elapsed;
					obrTimer.Interval = 1000.0;
					obrTimer.Enabled = true;
				}
			}
		}
		else
		{
			int oBRState = INT15.GetOBRState();
			if (oBRState != 2)
			{
				IsPollingOBR = true;
				obrTimer = new Timer();
				obrTimer.Elapsed += obrTimer_Elapsed;
				obrTimer.Interval = 1000.0;
				obrTimer.Enabled = true;
			}
		}
	}

	protected override void OnStop()
	{
		if (channel != null)
		{
			ChannelServices.UnregisterChannel((IChannel)(object)channel);
		}
	}

	protected override void OnCustomCommand(int command)
	{
		switch (command)
		{
		case 187:
			ImpersonateUser.ImpersonateUserToCreateProcessSilent();
			break;
		case 188:
			ImpersonateUser.ImpersonateUserToCreateProcess();
			break;
		}
		((ServiceBase)this).OnCustomCommand(command);
	}

	protected override void OnShutdown()
	{
		WIN32.SERVICE_STATUS lpServiceStatus = default(WIN32.SERVICE_STATUS);
		lpServiceStatus.ServiceType = (WIN32.SERVICE_TYPES)272;
		lpServiceStatus.CurrentState = WIN32.SERVICE_STATE.SERVICE_STOPPED;
		lpServiceStatus.Win32ExitCode = 0;
		bool flag;
		if (!(flag = WIN32.SetServiceStatus(((ServiceBase)this).get_ServiceHandle(), ref lpServiceStatus)) && bLog)
		{
			LogToFile("eRecoveryService", "OnShutdown: SetServiceStatus faile", flag.ToString());
		}
	}

	private bool NeedLog()
	{
		bool result = false;
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\Acer\\Empowering Technology 2.5\\Log\\eRecovery", writable: false);
			if (Convert.ToInt32(registryKey.GetValue("Service")) != 0)
			{
				result = true;
				return result;
			}
			result = false;
			return result;
		}
		catch
		{
			return result;
		}
	}

	private void LogStart()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\acer\\eRecovery", writable: false);
			if (registryKey.GetValue("InstallPath") != null)
			{
				szLogPath = registryKey.GetValue("InstallPath")!.ToString();
				int num = szLogPath.IndexOf("eRecovery");
				if (num != -1)
				{
					szLogPath = szLogPath.Remove(num);
					szLogPath += "Logs";
				}
				else
				{
					szLogPath = "C:\\Acer\\Empowering Technology\\Logs";
				}
			}
		}
		catch
		{
		}
		if (!Directory.Exists(szLogPath))
		{
			Directory.CreateDirectory(szLogPath);
		}
	}

	private void LogToFile(string lpAppName, string lpKeyName, string lpString)
	{
		DateTime now = DateTime.Now;
		WIN32.WritePrivateProfileString(lpAppName, "[" + now.ToString() + "." + now.Millisecond + "] " + lpKeyName, lpString, szLogPath + "\\eRecovery_Service.Log");
	}
}
