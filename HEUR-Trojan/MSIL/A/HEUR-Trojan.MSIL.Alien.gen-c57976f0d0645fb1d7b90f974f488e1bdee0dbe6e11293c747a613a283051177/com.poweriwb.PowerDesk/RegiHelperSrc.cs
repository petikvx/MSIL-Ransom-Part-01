using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;
using Microsoft.Win32;
using Microsoft.Win32.TaskScheduler;

namespace com.poweriwb.PowerDesk;

public class RegiHelperSrc : INotifyPropertyChanged
{
	public const string YMDHMS = "yyyy-MM-dd HH:mm:ss";

	private const string METAHANJA_KEYPATH = "Software\\VB and VBA Program Settings\\VacaLevel Co.\\MetaHanja";

	private const string POWERHEALTHCHECK = "PowerHealthCheck";

	private const string POWERHEALTHNET = "PowerHealthNet";

	private const string STR_WORKGROUP = "WORKGROUP";

	private Timer tmrW32TimeAsynchExec = null;

	private bool tmrW32TimeOning = false;

	private int tmrW32TimeCount = 30;

	private DateTime dtBeforeTimeSynch;

	private int dtBeforeTimeSynch_y;

	private int dtBeforeTimeSynch_m;

	private int dtBeforeTimeSynch_d;

	private int dtBeforeTimeSynch_hh;

	private int dtBeforeTimeSynch_mm;

	private int dtBeforeTimeSynch_ss;

	private int dtBeforeTimeSynch_milisec;

	private long nBeforeTimeSynchTick;

	private DateTime dtAfterTimeSynch;

	private long nAfterTimeSynchTick;

	private static string gComputerName = null;

	public static int iStartVolume = -3;

	public int iDoApplyAll = 0;

	public static Dictionary<string, int> dictSV = new Dictionary<string, int>();

	private Regex regexp_azAZ1 = new Regex("^[a-zA-Z]{1,}\\$", RegexOptions.IgnoreCase | RegexOptions.Multiline);

	private Regex regexp_falsessd20s = new Regex("FALSE\\s+(.+)\\s+[^\\$]+\\-\\d{2}0\\s*$", RegexOptions.IgnoreCase | RegexOptions.Multiline);

	internal static string strKey = Utils.SepaString("Software\\PowerIWB\\PowerHealthChecker");

	private static string strKeyApproval = Utils.SepaString("Software\\PowerIWB\\PowerHealthChecker\\Approval");

	private static BrushConverter mBrushConverter = null;

	private static Dictionary<string, SolidColorBrush> ResourcePackBrushes = null;

	private static RegiHelperSrc m_Instance = null;

	public string OemProductTitle = "";

	private string m_logPath = "";

	private string m_oneYearAgoDate = "";

	public bool bAuthSemi = false;

	public bool mAuth = false;

	private Brush mURLProtocolBackgroundBrush = null;

	private string mFileNameOfOneMinExecute = null;

	private string mBootTime = null;

	private bool m_EnableAntigen41_fileExists = true;

	private bool m_EnableAntigen42_fileExists = true;

	private bool m_EnableAntigen43_fileExists = true;

	private bool m_EnableAntigen44_fileExists = true;

	private bool m_EnableAntigen45_fileExists = true;

	private bool m_EnableAntigen46_fileExists = true;

	private bool m_EnableAntigen47_fileExists = true;

	private bool m_EnableAntigen48_fileExists = true;

	private bool? m_EnableAntigen49_fileExists = null;

	private bool? m_EnableAntigen57_fileExists = null;

	private bool? m_EnableAntigen56_fileExists = null;

	private bool? m_EnableAntigen58_fileExists = null;

	private bool bEnableAntigen22 = true;

	private static bool bCreateOfficeClickToRunService = false;

	public static bool IsOldVaccine = false;

	public static bool IsOldVaccine36 = false;

	internal bool IsStrVaccineAllEntered = false;

	private static string m_AppRootPath = "";

	private static string mDIR_PUBLIC_APP_CERTIFICATION_ENV_INI = null;

	private static string mDIR_PUBLIC_APP_CERTIFICATION_APPROVAL_INI = null;

	private static string mDIR_PUBLIC_APP_CERTIFICATION_APPOUTBLK_INI = null;

	public static string STR_4VV = "%windir%\\system32\\jscript.dll";

	private string grp_name;

	private static string m_FireWallVersion = null;

	private bool? mIsErrorWindowDefender = null;

	private bool? mIsBlockMsTeams = null;

	private bool? mIsBlockMsEdge = null;

	private bool? mIsBlockWizvera = null;

	private bool mAppApprovalColor = false;

	private bool? mIsBlockApps;

	private bool? mResolve01Checked;

	private bool? mResolve02Checked;

	private bool? mResolve03Checked;

	private bool? mResolve04Checked;

	private bool? mResolve05Checked;

	private bool? mResolve06Checked;

	private bool? mResolve07Checked;

	private bool? mResolve08Checked;

	private bool? mResolve10Checked;

	private string mResolve10s;

	private bool? mResolve20Checked;

	private string mResolve20s;

	private bool? mAutoW32TimeSynchChecked;

	private int? mProcessHWND = null;

	private bool? mIsJsonInstallerNoti = null;

	private bool? mAutoSaveMedicalReport = null;

	private bool? mVaccAllUInewed = null;

	private string mStrSecHealthUI_path = null;

	private bool? mIsWin11RmbSolved = null;

	private bool? mIsCopyPathActive = null;

	private bool? mIsCopyToFolderActive = null;

	private bool? mIsMoveToFolderActive = null;

	private bool? mIsEndReDiagnosis = null;

	private bool? mIsKoreaOS = null;

	private int nRdpPort = -2;

	internal bool bOnApplyAll = false;

	public static RegiHelperSrc Instance
	{
		get
		{
			if (m_Instance == null)
			{
				new RegiHelperSrc();
			}
			return m_Instance;
		}
		set
		{
			m_Instance = value;
		}
	}

	public bool CheckedWndStarted
	{
		get
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected O, but got Unknown
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			bool flag = false;
			if (CNativeWIN32.IsWindows7() || CNativeWIN32.IsWindows7OverFunction())
			{
				TaskService val = new TaskService();
				try
				{
					Task val2 = val.FindTask("PowerHealthCheck", true);
					if (val2 != null)
					{
						string text = ((ExecAction)((IEnumerable<Action>)val2.get_Definition().get_Actions()).First()).get_Path().Replace("\"", "");
						bool flag2 = Process.GetCurrentProcess().ProcessName.IndexOf(".vshost") > -1;
						bool flag3 = false;
						if (!new FileInfo(text).Exists)
						{
							flag3 = true;
						}
						else if (text.ToLower().CompareTo(Path.Combine(AppRootPath, Process.GetCurrentProcess().ProcessName + ".exe").ToLower()) != 0 && !flag2)
						{
							flag3 = true;
						}
						if (flag3)
						{
							val.get_RootFolder().DeleteTask("PowerHealthCheck");
							MakeNewTask(val);
							return bAuth;
						}
						return bAuth;
					}
					return false;
				}
				catch (Exception ex)
				{
					Console.Error.WriteLine(ex.Message);
					return false;
				}
				finally
				{
					((IDisposable)val)?.Dispose();
				}
			}
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Utils.SepaString("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run"), writable: false);
			if (registryKey != null)
			{
				flag = registryKey.GetValue("PowerHealthCheck") is string text2 && text2.IndexOf(Application.get_ResourceAssembly().Location) > -1;
			}
			return flag && bAuth;
		}
		set
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected O, but got Unknown
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Expected O, but got Unknown
			if (CNativeWIN32.IsWindows7() || CNativeWIN32.IsWindows7OverFunction())
			{
				if (value)
				{
					TaskService val = new TaskService();
					try
					{
						MakeNewTask(val);
					}
					finally
					{
						((IDisposable)val)?.Dispose();
					}
				}
				else
				{
					try
					{
						TaskService val = new TaskService();
						try
						{
							val.get_RootFolder().DeleteTask("PowerHealthCheck");
						}
						finally
						{
							((IDisposable)val)?.Dispose();
						}
					}
					catch (Exception)
					{
					}
				}
			}
			else
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Utils.SepaString("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run"), RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (value)
				{
					registryKey.SetValue("PowerHealthCheck", "\"" + Application.get_ResourceAssembly().Location + "\" bg");
				}
				else if (registryKey.GetValue("PowerHealthCheck") != null)
				{
					registryKey.DeleteValue("PowerHealthCheck", throwOnMissingValue: false);
				}
			}
			NotifyPropertyChanged("CheckedWndStarted");
			NotifyPropertyChanged("StrTimeSynchMenuName2Week");
		}
	}

	public bool CheckedAutoNetCloseStarted
	{
		get
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected O, but got Unknown
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			bool result = false;
			if (CNativeWIN32.IsWindows7() || CNativeWIN32.IsWindows7OverFunction())
			{
				TaskService val = new TaskService();
				try
				{
					Task val2 = val.FindTask("PowerHealthNet", true);
					if (val2 != null)
					{
						string text = ((ExecAction)((IEnumerable<Action>)val2.get_Definition().get_Actions()).First()).get_Path().Replace("\"", "");
						bool flag = Process.GetCurrentProcess().ProcessName.IndexOf(".vshost") > -1;
						bool flag2 = false;
						string[] args = ((ExecAction)((IEnumerable<Action>)val2.get_Definition().get_Actions()).First()).get_Arguments().Split(new char[1] { ' ' });
						int num = (iStartVolume = Convert.ToInt32(Utils.getParamValue(args, "/volume:", "-2")));
						if (!new FileInfo(text).Exists)
						{
							flag2 = true;
						}
						else if (text.ToLower() != Path.Combine(AppRootPath, Process.GetCurrentProcess().ProcessName + ".exe").ToLower() && !flag)
						{
							flag2 = true;
						}
						if (flag2)
						{
							val.get_RootFolder().DeleteTask("PowerHealthNet");
							MakeNewTask2(val);
							return true;
						}
						return true;
					}
					return false;
				}
				catch (Exception ex)
				{
					Console.Error.WriteLine(ex.Message);
					return false;
				}
				finally
				{
					((IDisposable)val)?.Dispose();
				}
			}
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Utils.SepaString("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run"), writable: false);
			if (registryKey != null)
			{
				result = registryKey.GetValue("PowerHealthNet") is string text2 && text2.IndexOf(Application.get_ResourceAssembly().Location) > -1;
			}
			return result;
		}
		set
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected O, but got Unknown
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Expected O, but got Unknown
			if (CNativeWIN32.IsWindows7() || CNativeWIN32.IsWindows7OverFunction())
			{
				if (value)
				{
					TaskService val = new TaskService();
					try
					{
						MakeNewTask2(val);
						return;
					}
					finally
					{
						((IDisposable)val)?.Dispose();
					}
				}
				try
				{
					TaskService val = new TaskService();
					try
					{
						val.get_RootFolder().DeleteTask("PowerHealthNet");
						return;
					}
					finally
					{
						((IDisposable)val)?.Dispose();
					}
				}
				catch (Exception)
				{
					return;
				}
			}
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Utils.SepaString("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run"), RegistryKeyPermissionCheck.ReadWriteSubTree);
			if (value)
			{
				registryKey.SetValue("PowerHealthNet", "\"" + Application.get_ResourceAssembly().Location + "\" /vshare:true");
			}
			else if (registryKey.GetValue("PowerHealthNet") != null)
			{
				registryKey.DeleteValue("PowerHealthNet", throwOnMissingValue: false);
			}
		}
	}

	public string logPath
	{
		get
		{
			if (m_logPath == "")
			{
				m_logPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Utils.SepaString("\\HealthChecker\\Log\\");
				if (!Directory.Exists(logPath))
				{
					Directory.CreateDirectory(logPath);
				}
			}
			return m_logPath;
		}
	}

	public bool Installed
	{
		get
		{
			bool result = false;
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(strKey);
			if (registryKey == null)
			{
				registryKey = Registry.CurrentUser.CreateSubKey(strKey);
			}
			if (registryKey.GetValue("installed", -1) as int? == 1)
			{
				result = true;
			}
			registryKey.Close();
			registryKey.Dispose();
			registryKey = null;
			return result;
		}
		set
		{
			if (value)
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(strKey, RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey == null)
				{
					registryKey = Registry.CurrentUser.CreateSubKey(strKey);
				}
				registryKey.SetValue("installed", 1, RegistryValueKind.DWord);
				registryKey.Close();
				registryKey.Dispose();
				registryKey = null;
			}
			else
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(strKey, RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey == null)
				{
					registryKey = Registry.CurrentUser.CreateSubKey(strKey);
				}
				registryKey.SetValue("installed", 0);
				registryKey.Close();
				registryKey.Dispose();
				registryKey = null;
			}
		}
	}

	public string oneYearAgoDate
	{
		get
		{
			if (m_oneYearAgoDate == "")
			{
				m_oneYearAgoDate = DateTime.Now.AddDays(-365.0).ToString("yyyyMMdd");
			}
			return m_oneYearAgoDate;
		}
	}

	public static string nowYYYYMMDD => DateTime.Now.ToString("yyyyMMdd");

	public bool EnableAntigen1 => Utils.FileExists(PowerDeskApp2014.replaceNormalizePath("%windir%\\system32\\WSHom.Ocx"));

	public bool EnableAntigen2 => Utils.FileExists(PowerDeskApp2014.replaceNormalizePath("%windir%\\system32\\scrrun.dll"));

	public bool EnableAntigen3 => Utils.FileExists(PowerDeskApp2014.replaceNormalizePath("C:\\Program Files\\Common Files\\System\\ado\\msado15.dll"));

	public bool EnableAntigen7
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected O, but got Unknown
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			ManagementObjectSearcher val = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_ComputerSystem");
			ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					object obj = ((ManagementBaseObject)val2).get_Item("Workgroup");
					if (obj != null)
					{
						grp_name = obj.ToString();
					}
					else
					{
						grp_name = "";
					}
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			return grp_name == "WORKGROUP";
		}
	}

	public bool EnableAntigen4_fileExists => Utils.FileExists(PowerDeskApp2014.replaceNormalizePath(STR_4VV));

	public bool EnableAntigen5_fileExists => true;

	public bool EnableAntigen6_fileExists => true;

	public bool EnableAntigen7_fileExists => true;

	public bool EnableAntigen8_fileExists => true;

	public bool EnableAntigen9_fileExists => true;

	public bool EnableAntigen10_fileExists => true;

	public bool EnableAntigen11_fileExists => true;

	public bool EnableAntigen12_fileExists => true;

	public bool EnableAntigen13_fileExists => true;

	public bool EnableAntigen14_fileExists => true;

	public bool EnableAntigen15_fileExists => true;

	public bool EnableAntigen16_fileExists => true;

	public bool EnableAntigen17_fileExists => true;

	public bool EnableGPEdit_fileExists => File.Exists(Path.Combine(Environment.SystemDirectory, "gpedit.msc"));

	public Visibility mnuPU91Visibility
	{
		get
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			if (File.Exists(Path.Combine(Environment.SystemDirectory, "netsetup.cpl")))
			{
				return (Visibility)0;
			}
			return (Visibility)2;
		}
	}

	public bool bAuth
	{
		get
		{
			return mAuth;
		}
		set
		{
			mAuth = value;
			NotifyPropertyChanged("AuthTabBackGroundColor");
			NotifyPropertyChanged("AuthActiveOKVisible");
			NotifyPropertyChanged("AuthActiveNotVisible");
			NotifyPropertyChanged("AuthEnabled");
			NotifyPropertyChanged("bAuth");
			NotifyPropertyChanged("StrHealthCheck");
			NotifyPropertyChanged("AutoW32TimeSynchChecked");
		}
	}

	public bool AuthEnabled => bAuth;

	public SolidColorBrush AuthTabBackGroundColor
	{
		get
		{
			if (bAuth)
			{
				if (bAuthSemi)
				{
					return ResourcePackBrush("#66f0f006");
				}
				return ResourcePackBrush("#6600ff00");
			}
			return ResourcePackBrush("#66ff0000");
		}
	}

	public Brush URLProtocolBackgroundBrush
	{
		get
		{
			return mURLProtocolBackgroundBrush;
		}
		set
		{
			mURLProtocolBackgroundBrush = value;
			NotifyPropertyChanged("AppApprovalBackGroundColor");
		}
	}

	public Brush AppApprovalBackGroundColor
	{
		get
		{
			if (AppApprovalColor)
			{
				return (Brush)(object)ResourcePackBrush("#66ff0000");
			}
			if (null == mURLProtocolBackgroundBrush)
			{
				return (Brush)(object)ResourcePackBrush("Gray");
			}
			return mURLProtocolBackgroundBrush;
		}
	}

	public string FileNameOfOneMinExecute
	{
		get
		{
			if (mFileNameOfOneMinExecute == null)
			{
				string text = "";
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(strKey);
				if (registryKey == null)
				{
					registryKey = Registry.CurrentUser.CreateSubKey(strKey);
				}
				if (registryKey.GetValue("FileNameOfOneMinExecute") is string text2)
				{
					text = text2;
				}
				registryKey.Close();
				registryKey.Dispose();
				registryKey = null;
				mFileNameOfOneMinExecute = text;
			}
			return mFileNameOfOneMinExecute;
		}
		set
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(strKey, RegistryKeyPermissionCheck.ReadWriteSubTree);
			if (registryKey == null)
			{
				registryKey = Registry.CurrentUser.CreateSubKey(strKey);
			}
			mFileNameOfOneMinExecute = value.Replace("\"", "");
			registryKey.SetValue("FileNameOfOneMinExecute", mFileNameOfOneMinExecute, RegistryValueKind.String);
			registryKey.Close();
			registryKey.Dispose();
			registryKey = null;
			NotifyPropertyChanged("FileNameOfOneMinExecute");
			NotifyPropertyChanged("FileNameOfOneMinExecuteColor");
		}
	}

	public string BootTime
	{
		get
		{
			if (mBootTime == null)
			{
				string text = "";
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(strKey);
				if (registryKey == null)
				{
					registryKey = Registry.CurrentUser.CreateSubKey(strKey);
				}
				if (registryKey.GetValue("BootTime") is string text2)
				{
					text = text2;
				}
				registryKey.Close();
				registryKey.Dispose();
				registryKey = null;
				mBootTime = text;
			}
			return mBootTime;
		}
		set
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(strKey, RegistryKeyPermissionCheck.ReadWriteSubTree);
			if (registryKey == null)
			{
				registryKey = Registry.CurrentUser.CreateSubKey(strKey);
			}
			registryKey.SetValue("BootTime", value, RegistryValueKind.String);
			registryKey.Close();
			registryKey.Dispose();
			registryKey = null;
			mBootTime = value.Replace("\"", "");
			NotifyPropertyChanged("BootTime");
		}
	}

	public Brush FileNameOfOneMinExecuteColor
	{
		get
		{
			if (FileNameOfOneMinExecute.Length < 3)
			{
				return (Brush)(object)ResourcePackBrush("White");
			}
			if (Utils.FileExists(FileNameOfOneMinExecute))
			{
				return (Brush)(object)ResourcePackBrush("#4400ff00");
			}
			return (Brush)(object)ResourcePackBrush("#44ff0000");
		}
	}

	public Visibility AuthActiveOKVisible
	{
		get
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			if (bAuth)
			{
				return (Visibility)0;
			}
			return (Visibility)2;
		}
	}

	public Visibility AuthActiveNotVisible
	{
		get
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			if (bAuth)
			{
				return (Visibility)2;
			}
			return (Visibility)0;
		}
	}

	public bool EnableServerManager_fileExists => File.Exists(Path.Combine(Environment.SystemDirectory, "servermanager.msc"));

	public bool EnableAntigen41_fileExists => m_EnableAntigen41_fileExists;

	public bool EnableAntigen42_fileExists => m_EnableAntigen42_fileExists;

	public bool EnableAntigen43_fileExists => m_EnableAntigen43_fileExists;

	public bool EnableAntigen44_fileExists => m_EnableAntigen44_fileExists;

	public bool EnableAntigen45_fileExists => m_EnableAntigen45_fileExists;

	public bool EnableAntigen46_fileExists => m_EnableAntigen46_fileExists;

	public bool EnableAntigen47_fileExists => m_EnableAntigen47_fileExists;

	public bool EnableAntigen48_fileExists => m_EnableAntigen48_fileExists;

	public bool EnableAntigen49_fileExists
	{
		get
		{
			if (!m_EnableAntigen49_fileExists.HasValue)
			{
				m_EnableAntigen49_fileExists = File.Exists(Utils.GetSystemFileName("wisptis.exe"));
			}
			return m_EnableAntigen49_fileExists.Value;
		}
	}

	public bool EnableAntigen57_fileExists
	{
		get
		{
			if (!m_EnableAntigen57_fileExists.HasValue)
			{
				m_EnableAntigen57_fileExists = File.Exists(Utils.GetSystemFileName("usocoreworker.exe"));
			}
			return m_EnableAntigen57_fileExists.Value;
		}
	}

	public bool EnableAntigen56_fileExists
	{
		get
		{
			if (!m_EnableAntigen56_fileExists.HasValue)
			{
				m_EnableAntigen56_fileExists = File.Exists(Utils.GetSystemFileName("raserver.exe"));
			}
			return m_EnableAntigen56_fileExists.Value;
		}
	}

	public bool EnableAntigen58_fileExists
	{
		get
		{
			if (!m_EnableAntigen58_fileExists.HasValue)
			{
				m_EnableAntigen58_fileExists = File.Exists(Utils.GetSystemFileName("ntoskrnl.exe"));
			}
			return m_EnableAntigen58_fileExists.Value;
		}
	}

	public bool EnableAntigen4
	{
		get
		{
			bool result = false;
			string text = "";
			RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey(Utils.SepaString("ECMAScript\\CLSID"));
			if (registryKey != null)
			{
				string text2 = registryKey.GetValue("") as string;
				registryKey = Registry.ClassesRoot.OpenSubKey(Utils.SepaString("CLSID\\") + text2 + Utils.SepaString("\\InprocServer32"));
				if (registryKey != null)
				{
					result = Utils.FileExists(PowerDeskApp2014.replaceNormalizePath(STR_4VV = registryKey.GetValue("") as string));
				}
			}
			return result;
		}
	}

	public bool EnableAntigen5
	{
		get
		{
			bool flag = false;
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Utils.SepaString("SOFTWARE\\Microsoft\\Windows Script Host\\Settings"));
			if (registryKey != null)
			{
				int? num = registryKey.GetValue("Enabled") as int?;
				if (!num.HasValue)
				{
					flag = true;
				}
				else
				{
					int? num2 = num;
					if (num2.GetValueOrDefault() != 0 || !num2.HasValue)
					{
						flag = true;
					}
				}
				registryKey.Dispose();
				registryKey = null;
			}
			if (!flag)
			{
				RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SOFTWARE\\Microsoft\\Windows Script Host\\Settings"));
				if (registryKey2 != null)
				{
					int? num = registryKey2.GetValue("Enabled") as int?;
					if (!num.HasValue)
					{
						flag = true;
					}
					else
					{
						int? num2 = num;
						if (num2.GetValueOrDefault() != 0 || !num2.HasValue)
						{
							flag = true;
						}
					}
					registryKey2.Dispose();
					registryKey2 = null;
				}
			}
			return flag;
		}
	}

	public bool EnableAntigen6
	{
		get
		{
			bool result = false;
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\Control\\Lsa"));
			if (registryKey != null)
			{
				int? num = registryKey.GetValue("LmCompatibilityLevel") as int?;
				if (!num.HasValue)
				{
					result = true;
				}
				else if (num != 5)
				{
					result = true;
				}
				registryKey.Dispose();
				registryKey = null;
			}
			return result;
		}
	}

	public bool EnableAntigen8
	{
		get
		{
			bool result = false;
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SOFTWARE\\Policies\\Microsoft\\WindowsMediaPlayer"));
			if (registryKey != null)
			{
				int? num = registryKey.GetValue("DisableAutoUpdate") as int?;
				if (!num.HasValue)
				{
					result = true;
				}
				else if (num != 1)
				{
					result = true;
				}
				registryKey.Dispose();
				registryKey = null;
			}
			else
			{
				result = true;
			}
			return result;
		}
	}

	public bool EnableAntigen9
	{
		get
		{
			bool result = false;
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\Control\\Lsa"));
			if (registryKey != null)
			{
				int? num = registryKey.GetValue("restrictanonymous") as int?;
				if (!num.HasValue)
				{
					result = true;
				}
				else if (num != 1)
				{
					result = true;
				}
				registryKey.Dispose();
				registryKey = null;
			}
			else
			{
				result = true;
			}
			return result;
		}
	}

	public bool EnableAntigen59
	{
		get
		{
			bool result = false;
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\Control\\Session Manager"));
			if (registryKey != null)
			{
				int? num = registryKey.GetValue("CWDIllegalInDllSearch") as int?;
				if (!num.HasValue)
				{
					result = true;
				}
				else if (num != 2)
				{
					result = true;
				}
				registryKey.Dispose();
				registryKey = null;
			}
			else
			{
				result = true;
			}
			return result;
		}
	}

	public bool EnableAntigen10
	{
		get
		{
			bool result = true;
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Device Metadata");
			if (registryKey != null)
			{
				int? num = registryKey.GetValue("PreventDeviceMetadataFromNetwork") as int?;
				if (!num.HasValue)
				{
					result = true;
				}
				else if (num == 1)
				{
					result = false;
				}
				registryKey.Dispose();
				registryKey = null;
			}
			else
			{
				result = true;
			}
			return result;
		}
	}

	public bool EnableAntigen11 => Utils.SelectFileSecurity(Utils.GetSystemFileName("urlmon.dll"));

	public bool CheckedServiceSecure
	{
		get
		{
			bool result = true;
			string text = Utils.ExecuteCommandSync("netstat -bon");
			string[] array = text.Replace("\n", "\r").Replace("\r\r", "\r").Split(new char[1] { '\r' });
			for (int i = 1; i < array.Count(); i++)
			{
				if (-1 != array[i].IndexOf(".") || -1 != array[i].IndexOf("[") || 0 >= array[i].Trim().Length)
				{
					continue;
				}
				int num = array[i - 1].IndexOf("ESTABLISHED");
				if (-1 == num)
				{
					num = array[i - 1].IndexOf("CLOSE_WAIT");
				}
				if (-1 >= num)
				{
					continue;
				}
				int num2 = Convert.ToInt32(array[i - 1].Substring(num + 13).Trim());
				if (1024 < num2)
				{
					string text2 = array[i].Trim();
					if (-1 < text2.IndexOf(" "))
					{
						text2 = "\"" + text2 + "\"";
					}
					if (!dictSV.ContainsKey(text2))
					{
						dictSV.Add(text2, num2);
						result = false;
					}
				}
			}
			return result;
		}
	}

	public bool EnableAntigen12
	{
		get
		{
			bool result = false;
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System"));
			if (registryKey != null)
			{
				int? num = registryKey.GetValue("PromptOnSecureDesktop") as int?;
				if (!num.HasValue)
				{
					result = true;
				}
				else if (num != 1)
				{
					result = true;
				}
				registryKey.Dispose();
				registryKey = null;
			}
			else
			{
				result = true;
			}
			return result;
		}
	}

	public bool EnableAntigen13
	{
		get
		{
			bool result = false;
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\Control\\Session Manager\\kernel"));
			if (registryKey != null)
			{
				int? num = registryKey.GetValue("DisableExceptionChainValidation") as int?;
				if (!num.HasValue)
				{
					result = true;
				}
				else
				{
					int? num2 = num;
					if (num2.GetValueOrDefault() != 0 || !num2.HasValue)
					{
						result = true;
					}
				}
				registryKey.Dispose();
				registryKey = null;
			}
			else
			{
				result = true;
			}
			return result;
		}
	}

	public bool EnableAntigen14
	{
		get
		{
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("System\\CurrentControlSet\\Services\\LanmanServer\\Parameters"));
			if (registryKey != null)
			{
				int? num = registryKey.GetValue("AutoShareServer") as int?;
				if (!num.HasValue)
				{
					flag2 = true;
				}
				else if (num != 1)
				{
					flag2 = true;
				}
				int? num2 = registryKey.GetValue("AutoShareWks를") as int?;
				if (!num2.HasValue)
				{
					flag3 = true;
				}
				else if (num2 != 1)
				{
					flag3 = true;
				}
				flag = flag2 && flag3;
				registryKey.Dispose();
				registryKey = null;
			}
			else
			{
				flag = true;
			}
			return flag;
		}
	}

	public bool EnableAntigen15
	{
		get
		{
			bool flag = false;
			string netShare = Utils.getNetShare();
			MatchCollection matchCollection = null;
			matchCollection = regexp_azAZ1.Matches(netShare);
			if (0 < matchCollection.Count)
			{
				int num = 0;
				for (int i = 0; i < matchCollection.Count; i++)
				{
					string text = matchCollection[i].Groups[matchCollection[i].Groups.Count - 1].ToString().ToLower();
					if (text != "ipc$" && text != "print$")
					{
						num++;
						break;
					}
				}
				if (0 < num)
				{
					flag = true;
				}
			}
			if (!flag)
			{
				netShare = Utils.getUserAccount();
				if (Regex.IsMatch(netShare, "FALSE\\s+Guest\\s+"))
				{
					flag = true;
				}
			}
			return flag;
		}
	}

	public bool EnableAntigen16
	{
		get
		{
			bool flag = true;
			string uSERNAME = Utils.getUSERNAME();
			string userAccount = Utils.getUserAccount();
			MatchCollection matchCollection = null;
			matchCollection = regexp_falsessd20s.Matches(userAccount);
			if (0 < matchCollection.Count)
			{
				if (uSERNAME == matchCollection[0].Groups[matchCollection[0].Groups.Count - 1].ToString().Trim())
				{
					flag = true;
				}
			}
			else
			{
				flag = false;
			}
			if (!flag)
			{
				matchCollection = Regex.Matches(userAccount, "FALSE\\s+Guest\\s+", RegexOptions.IgnoreCase | RegexOptions.Multiline);
				if (0 < matchCollection.Count)
				{
					flag = true;
				}
			}
			return flag;
		}
	}

	public bool EnableAntigen17
	{
		get
		{
			bool result = true;
			try
			{
				TokenManipulator.AddPrivilege("SeRestorePrivilege");
				TokenManipulator.AddPrivilege("SeBackupPrivilege");
				TokenManipulator.AddPrivilege("SeTakeOwnershipPrivilege");
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System"), RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.TakeOwnership);
				if (registryKey != null)
				{
					RegistrySecurity accessControl = registryKey.GetAccessControl();
					IdentityReference owner = accessControl.GetOwner(typeof(SecurityIdentifier));
					NTAccount nTAccount = owner.Translate(typeof(NTAccount)) as NTAccount;
					string text = nTAccount.Value.ToLower();
					if (text == Utils.SepaString("builtin\\administrators"))
					{
						return false;
					}
					return result;
				}
				return result;
			}
			finally
			{
				TokenManipulator.RemovePrivilege("SeRestorePrivilege");
				TokenManipulator.RemovePrivilege("SeBackupPrivilege");
				TokenManipulator.RemovePrivilege("SeTakeOwnershipPrivilege");
			}
		}
	}

	public bool EnableAntigen18 => Utils.SelectDirectorySecurity(Utils.GetMyRecentFolder());

	public bool EnableAntigen19
	{
		get
		{
			bool flag = true;
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\services\\SharedAccess\\Parameters\\FirewallPolicy\\StandardProfile"), RegistryKeyPermissionCheck.ReadSubTree);
			if (registryKey != null)
			{
				if (registryKey.GetValue("EnableFirewall") as int? == 1)
				{
					flag = false;
				}
				registryKey.Dispose();
				registryKey = null;
			}
			if (flag)
			{
				registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\services\\SharedAccess\\Parameters\\FirewallPolicy\\PublicProfile"), RegistryKeyPermissionCheck.ReadSubTree);
				if (registryKey != null)
				{
					if (registryKey.GetValue("EnableFirewall") as int? == 1)
					{
						flag = false;
					}
					registryKey.Dispose();
					registryKey = null;
				}
			}
			return flag;
		}
	}

	public bool EnableAntigen20
	{
		get
		{
			bool result = true;
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\services\\COMSysApp"));
			if (registryKey != null)
			{
				if (registryKey.GetValue("Start") as int? == 4)
				{
					result = false;
				}
				registryKey.Dispose();
				registryKey = null;
			}
			return result;
		}
	}

	public bool EnableAntigen21
	{
		get
		{
			bool result = true;
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\services\\W32Time"));
			if (registryKey != null)
			{
				if (registryKey.GetValue("Start") as int? == 4)
				{
					result = false;
				}
				registryKey.Dispose();
				registryKey = null;
			}
			return result;
		}
	}

	public bool EnableAntigen22
	{
		get
		{
			int rdpPort = GetRdpPort();
			if (rdpPort < 0)
			{
				return bEnableAntigen22;
			}
			string text = "LanmanServer";
			bool flag = true;
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\services\\" + text);
			if (registryKey != null)
			{
				if (registryKey.GetValue("Start") as int? == 4)
				{
					flag = false;
				}
				registryKey.Dispose();
				registryKey = null;
			}
			if (!flag)
			{
				return bEnableAntigen22;
			}
			return false;
		}
		set
		{
			bEnableAntigen22 = value;
			NotifyPropertyChanged("EnableAntigen22");
		}
	}

	public bool EnableAntigen23
	{
		get
		{
			string text = "Browser";
			bool result = true;
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\services\\" + text);
			if (registryKey != null)
			{
				if (registryKey.GetValue("Start") as int? == 4)
				{
					result = false;
				}
				registryKey.Dispose();
				registryKey = null;
			}
			else
			{
				result = false;
			}
			return result;
		}
	}

	public bool EnableAntigen24
	{
		get
		{
			bool result = true;
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("Software\\Policies\\Microsoft\\Windows\\Explorer"));
			if (registryKey != null)
			{
				int? num = registryKey.GetValue("NoDataExecutionPrevention") as int?;
				int? num2 = num;
				if (num2.GetValueOrDefault() == 0 && num2.HasValue)
				{
					result = false;
				}
				registryKey.Dispose();
				registryKey = null;
			}
			return result;
		}
	}

	public bool EnableAntigen25
	{
		get
		{
			bool result = true;
			string bCDEdit = Utils.getBCDEdit();
			MatchCollection matchCollection = null;
			matchCollection = Regex.Matches(bCDEdit, "nx\\s+AlwaysOn", RegexOptions.IgnoreCase | RegexOptions.Multiline);
			if (0 < matchCollection.Count)
			{
				result = false;
			}
			return result;
		}
	}

	public bool EnableAntigen26
	{
		get
		{
			bool flag = false;
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters"));
			if (registryKey != null)
			{
				int? num = registryKey.GetValue("SynAttackProtect") as int?;
				int? num2 = num;
				if (num2.GetValueOrDefault() == 0 && num2.HasValue)
				{
					flag = true;
				}
				if (!flag && registryKey.GetValue("TcpMaxHalfOpen") as int? != 100)
				{
					flag = true;
				}
				if (!flag && registryKey.GetValue("TcpMaxHalfOpenRetried") as int? != 80)
				{
					flag = true;
				}
				if (!flag && registryKey.GetValue("EnableICMPRedirect") as int? != 1)
				{
					flag = true;
				}
				if (!flag)
				{
					num = registryKey.GetValue("EnableDeadGWDetect") as int?;
					num2 = num;
					if (num2.GetValueOrDefault() != 0 || !num2.HasValue)
					{
						flag = true;
					}
				}
				if (!flag && registryKey.GetValue("KeepAliveTime") as int? != 300000)
				{
					flag = true;
				}
				if (!flag)
				{
					num = registryKey.GetValue("PerformRouterDiscovery") as int?;
					num2 = num;
					if (num2.GetValueOrDefault() != 0 || !num2.HasValue)
					{
						flag = true;
					}
				}
				if (!flag)
				{
					num = registryKey.GetValue("EnableICMPRedirects") as int?;
					num2 = num;
					if (num2.GetValueOrDefault() != 0 || !num2.HasValue)
					{
						flag = true;
					}
				}
				if (!flag)
				{
					num = registryKey.GetValue("EnablePMTUDiscovery") as int?;
					num2 = num;
					if (num2.GetValueOrDefault() != 0 || !num2.HasValue)
					{
						flag = true;
					}
				}
				registryKey.Dispose();
				registryKey = null;
			}
			if (!flag)
			{
				registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\Services\\NetBT\\Parameters"));
				if (registryKey.GetValue("NoNameReleaseOnDemand") as int? != 1)
				{
					flag = true;
				}
				registryKey.Dispose();
				registryKey = null;
			}
			return flag;
		}
	}

	public bool EnableAntigen27
	{
		get
		{
			bool result = true;
			int num = 0;
			string bCDEdit = Utils.getBCDEdit();
			MatchCollection matchCollection = null;
			matchCollection = Regex.Matches(bCDEdit, "recoveryenabled\\s+Yes", RegexOptions.IgnoreCase | RegexOptions.Multiline);
			if (0 < matchCollection.Count)
			{
				result = false;
				Action action = delegate
				{
					PowerDeskApp2014.Instance.mnuPU32.set_IsChecked(true);
				};
				((DispatcherObject)PowerDeskApp2014.Instance).get_Dispatcher().Invoke((Delegate)action, new object[0]);
				num++;
			}
			matchCollection = Regex.Matches(bCDEdit, "bootstatuspolicy\\s+DisplayAllFailures", RegexOptions.IgnoreCase | RegexOptions.Multiline);
			if (0 < matchCollection.Count)
			{
				Action action = delegate
				{
					PowerDeskApp2014.Instance.mnuPU31.set_IsChecked(true);
				};
				((DispatcherObject)PowerDeskApp2014.Instance).get_Dispatcher().Invoke((Delegate)action, new object[0]);
				num++;
			}
			if (num == 2)
			{
				Action action2 = delegate
				{
					PowerDeskApp2014.Instance.mnuPU30.set_IsChecked(true);
				};
				((DispatcherObject)PowerDeskApp2014.Instance).get_Dispatcher().Invoke((Delegate)action2, new object[0]);
			}
			else
			{
				Action action2 = delegate
				{
					PowerDeskApp2014.Instance.mnuPU30.set_IsChecked(false);
				};
				((DispatcherObject)PowerDeskApp2014.Instance).get_Dispatcher().Invoke((Delegate)action2, new object[0]);
			}
			return result;
		}
	}

	public bool EnableAntigen28
	{
		get
		{
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\Services\\LanmanServer\\Parameters"));
			if (registryKey != null)
			{
				int? num = registryKey.GetValue("SMB1") as int?;
				int? num2 = num;
				if (num2.GetValueOrDefault() != 0 || !num2.HasValue)
				{
					flag = true;
				}
				registryKey.Dispose();
				registryKey = null;
			}
			else
			{
				flag = true;
			}
			registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\services\\mrxsmb10"), RegistryKeyPermissionCheck.ReadWriteSubTree);
			if (registryKey != null)
			{
				int? num = registryKey.GetValue("Start") as int?;
				if (num.HasValue && num.Value != 4)
				{
					flag2 = true;
				}
				registryKey.Dispose();
				registryKey = null;
			}
			RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\services\\mrxsmb"), RegistryKeyPermissionCheck.ReadWriteSubTree);
			if (registryKey2 != null)
			{
				int? num = registryKey2.GetValue("Start") as int?;
				if (num.HasValue && num.Value != 4)
				{
					flag3 = true;
				}
				registryKey2.Dispose();
				registryKey2 = null;
			}
			if (!(flag = flag || flag2 || flag3))
			{
				registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\Services\\LanmanWorkstation"), RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey != null)
				{
					if (registryKey.GetValue("DependOnService") is string[] array)
					{
						for (int i = 0; i < array.Length; i++)
						{
							if (-1 < array[i].IndexOf("MRxSmb10", StringComparison.CurrentCultureIgnoreCase) || 0 == string.Compare(array[i], "MRxSmb", ignoreCase: true))
							{
								flag = true;
								break;
							}
						}
					}
					registryKey.Dispose();
					registryKey = null;
				}
				else
				{
					flag = true;
				}
			}
			return flag;
		}
	}

	public bool EnableAntigen29 => Utils.SelectFileSecurity(Utils.GetSystemFileName("pcalua.exe"));

	public bool EnableAntigen30 => Utils.FindFireWallAllow("explorer.exe");

	public bool EnableAntigen31 => Utils.FindFireWallBlock("vlc.exe");

	public bool EnableAntigen32 => Utils.FindFireWallAllow("wmplayer.exe");

	public bool EnableAntigen33 => Utils.FindFireWallAllow("services.exe");

	public bool EnableAntigen34
	{
		get
		{
			bool result = false;
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Utils.SepaString("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer"));
			if (registryKey != null && registryKey.GetValue("NoDriveTypeAutoRun") as int? != 255)
			{
				result = true;
			}
			return result;
		}
	}

	public bool EnableAntigen35
	{
		get
		{
			bool result = true;
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\services\\RemoteRegistry"));
			if (registryKey != null)
			{
				if (registryKey.GetValue("Start") as int? == 4)
				{
					result = false;
				}
				registryKey.Dispose();
				registryKey = null;
			}
			return result;
		}
	}

	public bool EnableAntigen36
	{
		get
		{
			bool result = false;
			string maxLatestDfrg = GetMaxLatestDfrg();
			if (maxLatestDfrg != "")
			{
				if (string.Compare(maxLatestDfrg, oneYearAgoDate) < 0)
				{
					result = true;
				}
			}
			else
			{
				result = true;
			}
			return result;
		}
	}

	public bool EnableAntigen37
	{
		get
		{
			bool flag = true;
			RegistryKey registryKey = ((!CNativeWIN32.IsWindows7()) ? Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows Defender") : Registry.LocalMachine.OpenSubKey("SOFTWARE\\Windows Defender"));
			if (registryKey == null)
			{
				return false;
			}
			return !IsErrorWindowDefender;
		}
	}

	public bool EnableAntigen38
	{
		get
		{
			bool flag = false;
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Active Setup\\Installed Components");
			if (registryKey != null)
			{
				string[] subKeyNames = registryKey.GetSubKeyNames();
				for (int i = 0; i < subKeyNames.Length; i++)
				{
					RegistryKey registryKey2 = registryKey.OpenSubKey(subKeyNames[i]);
					if (registryKey2 != null)
					{
						string value = registryKey2.GetValue("StubPath", "") as string;
						if (!string.IsNullOrEmpty(value))
						{
							flag = true;
							registryKey2.Close();
							registryKey2.Dispose();
							break;
						}
						registryKey2.Close();
						registryKey2.Dispose();
					}
				}
				registryKey.Close();
				registryKey.Dispose();
			}
			if (!flag)
			{
				registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Wow6432Node\\Microsoft\\Active Setup\\Installed Components");
				if (registryKey != null)
				{
					string[] subKeyNames = registryKey.GetSubKeyNames();
					for (int i = 0; i < subKeyNames.Length; i++)
					{
						RegistryKey registryKey2 = registryKey.OpenSubKey(subKeyNames[i]);
						if (registryKey2 != null)
						{
							string value = registryKey2.GetValue("StubPath", "") as string;
							if (!string.IsNullOrEmpty(value))
							{
								flag = true;
								registryKey2.Close();
								registryKey2.Dispose();
								break;
							}
							registryKey2.Close();
							registryKey2.Dispose();
						}
					}
					registryKey.Close();
					registryKey.Dispose();
				}
			}
			return flag;
		}
	}

	public bool EnableAntigen39
	{
		get
		{
			bool result = false;
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Utils.SepaString("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer"));
			if (registryKey != null && registryKey.GetValue("NoActiveDesktop") as int? != 1)
			{
				result = true;
			}
			return result;
		}
	}

	public bool EnableAntigen40
	{
		get
		{
			bool result = false;
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Utils.SepaString("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer"));
			if (registryKey != null && registryKey.GetValue("NoAddPrinter") as int? != 1)
			{
				result = true;
			}
			return result;
		}
	}

	public bool EnableAntigen60
	{
		get
		{
			bool result = false;
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Utils.SepaString("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer"));
			if (registryKey != null && registryKey.GetValue("disallowrun") as int? != 1)
			{
				result = true;
			}
			return result;
		}
	}

	public bool EnableAntigen41
	{
		get
		{
			bool result = false;
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\services"));
			if (registryKey != null)
			{
				bool flag = false;
				string[] subKeyNames = registryKey.GetSubKeyNames();
				for (int i = 0; i < subKeyNames.Count(); i++)
				{
					if (Regex.IsMatch(subKeyNames[i], "^xb[glo]{1}", RegexOptions.IgnoreCase))
					{
						flag = true;
						RegistryKey registryKey2 = registryKey.OpenSubKey(subKeyNames[i]);
						object value = registryKey2.GetValue("start");
						if (value != null && value.ToString() != "4")
						{
							result = true;
							registryKey2.Dispose();
							break;
						}
						registryKey2.Dispose();
					}
				}
				if (!flag)
				{
					m_EnableAntigen41_fileExists = false;
				}
				registryKey.Dispose();
			}
			return result;
		}
	}

	public bool EnableAntigen42
	{
		get
		{
			bool result = false;
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\services\\wpnservice"));
			if (registryKey != null)
			{
				object value = registryKey.GetValue("start");
				if (value != null && value.ToString() != "4")
				{
					result = true;
				}
			}
			else
			{
				m_EnableAntigen42_fileExists = false;
			}
			return result;
		}
	}

	public bool EnableAntigen43
	{
		get
		{
			bool result = false;
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\services\\ibtsiva"));
			if (registryKey != null)
			{
				object value = registryKey.GetValue("start");
				if (value != null && value.ToString() != "4")
				{
					result = true;
				}
			}
			else
			{
				m_EnableAntigen43_fileExists = false;
			}
			return result;
		}
	}

	public bool EnableAntigen44
	{
		get
		{
			string text = "w3svc";
			bool result = false;
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\services\\" + text));
			if (registryKey != null)
			{
				object value = registryKey.GetValue("start");
				if (value != null && value.ToString() != "4")
				{
					result = true;
				}
			}
			else
			{
				m_EnableAntigen44_fileExists = false;
			}
			return result;
		}
	}

	public bool EnableAntigen45
	{
		get
		{
			string text = "clicktorunsvc";
			bool result = false;
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\services\\" + text));
			if (registryKey != null)
			{
				object value = registryKey.GetValue("start");
				if (value != null)
				{
					if (value.ToString() == "4" || value.ToString() == "2")
					{
						result = true;
					}
				}
				else
				{
					CreateOfficeClickToRunService();
				}
			}
			else
			{
				m_EnableAntigen45_fileExists = false;
				CreateOfficeClickToRunService();
			}
			return result;
		}
	}

	public bool EnableAntigen46
	{
		get
		{
			string text = "wsearch";
			bool result = false;
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\services\\" + text));
			if (registryKey != null)
			{
				object value = registryKey.GetValue("start");
				if (value != null && value.ToString() != "4" && value.ToString() != "3")
				{
					result = true;
				}
			}
			else
			{
				m_EnableAntigen46_fileExists = false;
			}
			return result;
		}
	}

	public bool EnableAntigen47
	{
		get
		{
			bool flag = false;
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SOFTWARE\\Microsoft\\Internet Explorer\\Extensions"));
			if (registryKey != null)
			{
				string[] subKeyNames = registryKey.GetSubKeyNames();
				for (int i = 0; i < subKeyNames.Count(); i++)
				{
					RegistryKey registryKey2 = registryKey.OpenSubKey(subKeyNames[i]);
					string text = registryKey2.GetValue("ButtonText", "")!.ToString();
					if (-1 >= text.IndexOf("OneNote", StringComparison.OrdinalIgnoreCase))
					{
						registryKey2.Close();
						registryKey2.Dispose();
						continue;
					}
					flag = true;
					registryKey2.Close();
					registryKey2.Dispose();
					m_EnableAntigen47_fileExists = true;
					break;
				}
				registryKey.Close();
				registryKey.Dispose();
			}
			else
			{
				m_EnableAntigen47_fileExists = false;
			}
			if (Utils.Is64OS() && !flag)
			{
				RegistryKey registryKey3 = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SOFTWARE\\Wow6432Node\\Microsoft\\Internet Explorer\\Extensions"));
				if (registryKey3 != null)
				{
					string[] subKeyNames = registryKey3.GetSubKeyNames();
					for (int i = 0; i < subKeyNames.Count(); i++)
					{
						RegistryKey registryKey4 = registryKey3.OpenSubKey(subKeyNames[i]);
						string text = registryKey4.GetValue("ButtonText", "")!.ToString();
						if (-1 >= text.IndexOf("OneNote", StringComparison.OrdinalIgnoreCase))
						{
							registryKey4.Close();
							registryKey4.Dispose();
							continue;
						}
						flag = true;
						registryKey4.Close();
						registryKey4.Dispose();
						m_EnableAntigen47_fileExists = true;
						break;
					}
					registryKey3.Close();
					registryKey3.Dispose();
				}
				else
				{
					m_EnableAntigen47_fileExists = false;
				}
			}
			return flag;
		}
	}

	public bool EnableAntigen48
	{
		get
		{
			bool result = false;
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\services\\CDPSvc"));
			if (registryKey != null)
			{
				object value = registryKey.GetValue("start");
				if (value != null && value.ToString() != "4")
				{
					result = true;
				}
			}
			else
			{
				m_EnableAntigen48_fileExists = false;
			}
			return result;
		}
	}

	public bool EnableAntigen49
	{
		get
		{
			if (EnableAntigen49_fileExists)
			{
				string systemFileName = Utils.GetSystemFileName("wisptis.exe");
				return Utils.SelectFileSecurity_sysdeny(systemFileName);
			}
			return false;
		}
	}

	public bool EnableAntigen57
	{
		get
		{
			if (EnableAntigen57_fileExists)
			{
				string systemFileName = Utils.GetSystemFileName("usocoreworker.exe");
				return Utils.SelectFileSecurity_sysdeny(systemFileName);
			}
			return false;
		}
	}

	public bool EnableAntigen56
	{
		get
		{
			if (EnableAntigen56_fileExists)
			{
				string systemFileName = Utils.GetSystemFileName("raserver.exe");
				return Utils.SelectFileSecurity_sysdeny(systemFileName);
			}
			return false;
		}
	}

	public bool EnableAntigen58
	{
		get
		{
			if (EnableAntigen58_fileExists)
			{
				string systemFileName = Utils.GetSystemFileName("ntoskrnl.exe");
				return Utils.SelectFileSecurity_sysdeny(systemFileName);
			}
			return false;
		}
	}

	public bool EnableAntigen50 => !Utils.ExplorerExecuteSecurity("DllLoader.exe", 0);

	public bool EnableAntigen51 => !Utils.ExplorerExecuteSecurity("powershell.exe", 0);

	public bool EnableAntigen52 => !Utils.ExplorerExecuteSecurity("pingsender.exe", 0);

	public bool EnableAntigen53 => Utils.ExistPathLocalWindowsapps();

	public bool EnableAntigen54 => Utils.ProtectTemp3582FolderVulnerable(0, protect: false);

	public bool SolvedProblem55 => Utils.SolvedProblem55();

	public bool CheckedFunction18
	{
		get
		{
			bool result = true;
			bool flag = false;
			string text = Utils.ExecuteCommandSync("netstat -ano");
			string[] array = text.Replace("\n", "\r").Replace("\r\r", "\r").Split(new char[1] { '\r' });
			for (int i = 1; i < array.Count(); i++)
			{
				if (Regex.IsMatch(array[i], "LISTENING\\s+4$"))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				result = true;
			}
			return result;
		}
	}

	public bool CheckedFunction18a
	{
		get
		{
			bool result = false;
			int num = 0;
			num = GerFirewallRuleResult("[Ransome SMB Block]TCP-445", "in", "TCP", "445");
			if (5 <= num)
			{
				result = true;
			}
			return result;
		}
	}

	public bool CheckedFunction18b
	{
		get
		{
			bool result = false;
			int num = 0;
			num = GerFirewallRuleResult("[Ransome NBT Session Block]TCP-139", "in", "TCP", "139");
			if (5 <= num)
			{
				result = true;
			}
			return result;
		}
	}

	public bool CheckedFunction18c
	{
		get
		{
			bool result = false;
			int num = 0;
			num = GerFirewallRuleResult("[Ransome NBT Datagram Block]UDP-138", "in", "UDP", "138");
			if (5 <= num)
			{
				result = true;
			}
			return result;
		}
	}

	public bool CheckedFunction18d
	{
		get
		{
			bool result = false;
			int num = 0;
			num = GerFirewallRuleResult("[Ransome NBT Naming Block]TCP-137", "in", "TCP", "137");
			if (5 <= num)
			{
				result = true;
			}
			return result;
		}
	}

	public bool CheckedFunction18e
	{
		get
		{
			bool result = false;
			int num = 0;
			num = GerFirewallRuleResult("[Ransome NBT Naming Block]UDP-137", "in", "UDP", "137");
			if (5 <= num)
			{
				result = true;
			}
			return result;
		}
	}

	public bool CheckedFunction19
	{
		get
		{
			bool flag = true;
			bool flag2 = true;
			string text = Utils.ExecuteCommandSync("icacls C:\\WINDOWS\\servicing\\TrustedInstaller.exe");
			string[] array = text.Replace("\n", "\r").Replace("\r\r", "\r").Split(new char[1] { '\r' });
			for (int i = 0; i < array.Count(); i++)
			{
				if (-1 < array[i].IndexOf("SYSTEM:(DENY)"))
				{
					flag2 = false;
					break;
				}
			}
			if (flag2)
			{
				return false;
			}
			return true;
		}
	}

	public bool CheckedFunction20
	{
		get
		{
			bool flag = false;
			bool flag2 = false;
			string text = "";
			text = ((!CNativeWIN32.IsWindows7()) ? "SystemEventsBroker" : "EventLog");
			if (Utils.isServiceExists(text))
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\Services\\Schedule"), writable: false);
				if (registryKey != null)
				{
					List<string> list = new List<string>();
					if (registryKey.GetValue("DependOnService") is string[] array)
					{
						for (int i = 0; i < array.Length; i++)
						{
							if (-1 == array[i].IndexOf(text, StringComparison.CurrentCultureIgnoreCase))
							{
								list.Add(array[i]);
								continue;
							}
							flag2 = true;
							break;
						}
					}
					registryKey.Dispose();
					registryKey = null;
				}
			}
			if (flag2)
			{
				return false;
			}
			return true;
		}
	}

	public bool EnableCheckedFunction13
	{
		get
		{
			bool result = false;
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Utils.SepaString("Control Panel\\Desktop"));
			if (registryKey != null)
			{
				string text = registryKey.GetValue("MenuShowDelay") as string;
				if (text != "0")
				{
					result = true;
				}
				registryKey.Dispose();
				registryKey = null;
			}
			return result;
		}
	}

	public bool CheckedVaccine1
	{
		get
		{
			bool result = false;
			if (EnableAntigen1)
			{
				string text = App.iniFile.ReadValue("CheckedVacc1");
				if (text != "")
				{
					if (string.Compare(text, oneYearAgoDate) >= 0)
					{
						result = true;
					}
					else
					{
						IsOldVaccine = true;
					}
				}
			}
			return result;
		}
		set
		{
			if (value)
			{
				App.iniFile.WriteValue_UTF8("CheckedVacc1", nowYYYYMMDD);
			}
			else
			{
				App.iniFile.WriteValue_UTF8("CheckedVacc1", "");
			}
			NotifyPropertyChanged("CheckedVaccine1");
			NotifyPropertyChanged("StrVaccineAll");
		}
	}

	public bool CheckedVaccine2
	{
		get
		{
			bool result = false;
			if (EnableAntigen2)
			{
				string text = App.iniFile.ReadValue("CheckedVacc2");
				if (text != "")
				{
					if (string.Compare(text, oneYearAgoDate) >= 0)
					{
						result = true;
					}
					else
					{
						IsOldVaccine = true;
					}
				}
			}
			return result;
		}
		set
		{
			if (value)
			{
				App.iniFile.WriteValue_UTF8("CheckedVacc2", nowYYYYMMDD);
			}
			else
			{
				App.iniFile.WriteValue_UTF8("CheckedVacc2", "");
			}
			NotifyPropertyChanged("CheckedVaccine2");
			NotifyPropertyChanged("StrVaccineAll");
		}
	}

	public bool CheckedVaccine3
	{
		get
		{
			bool result = false;
			if (EnableAntigen3)
			{
				string text = App.iniFile.ReadValue("CheckedVacc3");
				if (text != "")
				{
					if (string.Compare(text, oneYearAgoDate) >= 0)
					{
						result = true;
					}
					else
					{
						IsOldVaccine = true;
					}
				}
			}
			return result;
		}
		set
		{
			if (value)
			{
				App.iniFile.WriteValue_UTF8("CheckedVacc3", nowYYYYMMDD);
			}
			else
			{
				App.iniFile.WriteValue_UTF8("CheckedVacc3", "");
			}
			NotifyPropertyChanged("CheckedVaccine3");
			NotifyPropertyChanged("StrVaccineAll");
		}
	}

	public bool CheckedVaccine4
	{
		get
		{
			bool result = false;
			if (EnableAntigen4)
			{
				string text = App.iniFile.ReadValue("CheckedVacc4");
				if (text != "")
				{
					if (string.Compare(text, oneYearAgoDate) >= 0)
					{
						result = true;
					}
					else
					{
						IsOldVaccine = true;
					}
				}
			}
			else
			{
				result = true;
			}
			return result;
		}
		set
		{
			if (value)
			{
				App.iniFile.WriteValue_UTF8("CheckedVacc4", nowYYYYMMDD);
			}
			else
			{
				App.iniFile.WriteValue_UTF8("CheckedVacc4", "");
			}
			NotifyPropertyChanged("CheckedVaccine4");
			NotifyPropertyChanged("StrVaccineAll");
		}
	}

	public bool CheckedVaccine5
	{
		get
		{
			bool result = true;
			if (EnableAntigen5)
			{
				result = false;
			}
			return result;
		}
		set
		{
			if (value)
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Utils.SepaString("SOFTWARE\\Microsoft\\Windows Script Host\\Settings"), RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey == null)
				{
					registryKey = Registry.CurrentUser.CreateSubKey(Utils.SepaString("SOFTWARE\\Microsoft\\Windows Script Host\\Settings"));
				}
				if (registryKey != null)
				{
					registryKey.SetValue("Enabled", 0);
					registryKey.Dispose();
					registryKey = null;
				}
				RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SOFTWARE\\Microsoft\\Windows Script Host\\Settings"), RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey2 == null)
				{
					registryKey2 = Registry.LocalMachine.CreateSubKey(Utils.SepaString("SOFTWARE\\Microsoft\\Windows Script Host\\Settings"));
				}
				if (registryKey2 != null)
				{
					registryKey2.SetValue("Enabled", 0);
					registryKey2.Dispose();
					registryKey2 = null;
				}
			}
			else
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Utils.SepaString("SOFTWARE\\Microsoft\\Windows Script Host\\Settings"), RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey != null)
				{
					registryKey.SetValue("Enabled", 1);
					registryKey.Dispose();
					registryKey = null;
				}
				RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SOFTWARE\\Microsoft\\Windows Script Host\\Settings"), RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey2 != null)
				{
					registryKey2.SetValue("Enabled", 1);
					registryKey2.Dispose();
					registryKey2 = null;
				}
			}
			NotifyPropertyChanged("CheckedVaccine5");
			NotifyPropertyChanged("EnableAntigen5");
			NotifyPropertyChanged("StrVaccineAll");
		}
	}

	public bool CheckedVaccine6
	{
		get
		{
			bool result = true;
			if (EnableAntigen6)
			{
				result = false;
			}
			return result;
		}
		set
		{
			if (value)
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\Control\\Lsa"), RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey != null)
				{
					registryKey.SetValue("LmCompatibilityLevel", 5);
					registryKey.Dispose();
					registryKey = null;
				}
			}
			else
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\Control\\Lsa"), RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey != null)
				{
					registryKey.SetValue("LmCompatibilityLevel", 1);
					registryKey.Dispose();
					registryKey = null;
				}
			}
			NotifyPropertyChanged("CheckedVaccine6");
			NotifyPropertyChanged("EnableAntigen6");
			NotifyPropertyChanged("StrVaccineAll");
		}
	}

	public bool CheckedVaccine7
	{
		get
		{
			bool result = true;
			if (EnableAntigen7)
			{
				result = false;
			}
			return result;
		}
		set
		{
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Invalid comparison between Unknown and I4
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				if (value)
				{
					if (grp_name == "WORKGROUP" && (int)MessageBox.Show("작업그룹이름을 [WORKGROUP]에서 다른 이름으로 변경하여 네트워크 침입을 방지하세요. [변경]버튼 클릭", Process.GetCurrentProcess().ProcessName, (MessageBoxButton)4, (MessageBoxImage)48) == 6)
					{
						do_computername();
					}
				}
				else
				{
					do_computername();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message + ex.StackTrace);
			}
			NotifyPropertyChanged("CheckedVaccine7");
			NotifyPropertyChanged("StrVaccineAll");
		}
	}

	public bool CheckedVaccine8
	{
		get
		{
			bool result = true;
			if (EnableAntigen8)
			{
				result = false;
			}
			return result;
		}
		set
		{
			if (value)
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SOFTWARE\\Policies\\Microsoft\\WindowsMediaPlayer"), RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey != null)
				{
					registryKey.SetValue("DisableAutoUpdate", 1);
					registryKey.Dispose();
					registryKey = null;
				}
				else
				{
					registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SOFTWARE\\Policies\\Microsoft"), RegistryKeyPermissionCheck.ReadWriteSubTree);
					registryKey.CreateSubKey("WindowsMediaPlayer");
					registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SOFTWARE\\Policies\\Microsoft\\WindowsMediaPlayer"), RegistryKeyPermissionCheck.ReadWriteSubTree);
					registryKey.SetValue("DisableAutoUpdate", 1);
					registryKey.Dispose();
					registryKey = null;
				}
			}
			else
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SOFTWARE\\Policies\\Microsoft\\WindowsMediaPlayer"), RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey != null)
				{
					registryKey.SetValue("DisableAutoUpdate", 0);
					registryKey.Dispose();
					registryKey = null;
				}
			}
			NotifyPropertyChanged("CheckedVaccine8");
			NotifyPropertyChanged("EnableAntigen8");
			NotifyPropertyChanged("StrVaccineAll");
		}
	}

	public bool CheckedVaccine9
	{
		get
		{
			bool result = true;
			if (EnableAntigen9)
			{
				result = false;
			}
			return result;
		}
		set
		{
			if (value)
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\Control\\Lsa"), RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey != null)
				{
					registryKey.SetValue("restrictanonymous", 1);
					registryKey.Dispose();
					registryKey = null;
				}
				else
				{
					registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\Control"), RegistryKeyPermissionCheck.ReadWriteSubTree);
					registryKey.CreateSubKey("Lsa");
					registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\Control\\Lsa"), RegistryKeyPermissionCheck.ReadWriteSubTree);
					registryKey.SetValue("restrictanonymous", 1);
					registryKey.Dispose();
					registryKey = null;
				}
			}
			else
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\Control\\Lsa"), RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey != null)
				{
					registryKey.SetValue("restrictanonymous", 0);
					registryKey.Dispose();
					registryKey = null;
				}
				else
				{
					registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\Control"), RegistryKeyPermissionCheck.ReadWriteSubTree);
					registryKey.CreateSubKey("Lsa");
					registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\Control\\Lsa"), RegistryKeyPermissionCheck.ReadWriteSubTree);
					registryKey.SetValue("restrictanonymous", 0);
					registryKey.Dispose();
					registryKey = null;
				}
			}
			NotifyPropertyChanged("CheckedVaccine9");
			NotifyPropertyChanged("EnableAntigen9");
			NotifyPropertyChanged("StrVaccineAll");
		}
	}

	public bool CheckedVaccine59
	{
		get
		{
			bool result = true;
			if (EnableAntigen59)
			{
				result = false;
			}
			return result;
		}
		set
		{
			if (value)
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\Control\\Session Manager"), RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey != null)
				{
					registryKey.SetValue("CWDIllegalInDllSearch", 2);
					registryKey.Dispose();
					registryKey = null;
				}
				else
				{
					registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\Control"), RegistryKeyPermissionCheck.ReadWriteSubTree);
					registryKey.CreateSubKey("Session Manager");
					registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\Control\\Session Manager"), RegistryKeyPermissionCheck.ReadWriteSubTree);
					registryKey.SetValue("CWDIllegalInDllSearch", 2);
					registryKey.Dispose();
					registryKey = null;
				}
			}
			else
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\Control\\Session Manager"), RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey != null)
				{
					registryKey.SetValue("CWDIllegalInDllSearch", 0);
					registryKey.Dispose();
					registryKey = null;
				}
				else
				{
					registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\Control"), RegistryKeyPermissionCheck.ReadWriteSubTree);
					registryKey.CreateSubKey("Session Manager");
					registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\Control\\Session Manager"), RegistryKeyPermissionCheck.ReadWriteSubTree);
					registryKey.SetValue("CWDIllegalInDllSearch", 0);
					registryKey.Dispose();
					registryKey = null;
				}
			}
			NotifyPropertyChanged("CheckedVaccine59");
			NotifyPropertyChanged("EnableAntigen59");
			NotifyPropertyChanged("StrVaccineAll");
		}
	}

	public bool CheckedVaccine10
	{
		get
		{
			bool result = true;
			if (EnableAntigen10)
			{
				result = false;
			}
			return result;
		}
		set
		{
			if (value)
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Device Metadata", RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey != null)
				{
					registryKey.SetValue("PreventDeviceMetadataFromNetwork", 1);
					registryKey.Dispose();
					registryKey = null;
				}
			}
			else
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Device Metadata", RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey != null)
				{
					registryKey.SetValue("PreventDeviceMetadataFromNetwork", 0);
					registryKey.Dispose();
					registryKey = null;
				}
			}
			NotifyPropertyChanged("CheckedVaccine10");
			NotifyPropertyChanged("EnableAntigen10");
			NotifyPropertyChanged("StrVaccineAll");
		}
	}

	public bool CheckedVaccine11
	{
		get
		{
			return !EnableAntigen11;
		}
		set
		{
			Utils.URLMON_system(value);
			NotifyPropertyChanged("CheckedVaccine11");
			NotifyPropertyChanged("EnableAntigen11");
			NotifyPropertyChanged("StrVaccineAll");
		}
	}

	public bool CheckedVaccine12
	{
		get
		{
			bool result = true;
			if (EnableAntigen12)
			{
				result = false;
			}
			return result;
		}
		set
		{
			if (value)
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System"), RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey != null)
				{
					registryKey.SetValue("PromptOnSecureDesktop", 1);
					registryKey.Dispose();
					registryKey = null;
				}
				else
				{
					registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies"), RegistryKeyPermissionCheck.ReadWriteSubTree);
					registryKey.CreateSubKey("System");
					registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System"), RegistryKeyPermissionCheck.ReadWriteSubTree);
					registryKey.SetValue("PromptOnSecureDesktop", 1);
					registryKey.Dispose();
					registryKey = null;
				}
			}
			else
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System"), RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey != null)
				{
					registryKey.SetValue("PromptOnSecureDesktop", 0);
					registryKey.Dispose();
					registryKey = null;
				}
				else
				{
					registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies"), RegistryKeyPermissionCheck.ReadWriteSubTree);
					registryKey.CreateSubKey("System");
					registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System"), RegistryKeyPermissionCheck.ReadWriteSubTree);
					registryKey.SetValue("PromptOnSecureDesktop", 0);
					registryKey.Dispose();
					registryKey = null;
				}
			}
			NotifyPropertyChanged("CheckedVaccine12");
			NotifyPropertyChanged("EnableAntigen12");
			NotifyPropertyChanged("StrVaccineAll");
		}
	}

	public bool CheckedVaccine13
	{
		get
		{
			bool result = true;
			if (EnableAntigen13)
			{
				result = false;
			}
			return result;
		}
		set
		{
			if (value)
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\Control\\Session Manager\\kernel"), RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey != null)
				{
					registryKey.SetValue("DisableExceptionChainValidation", 0);
					registryKey.Dispose();
					registryKey = null;
				}
				else
				{
					registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\Control\\Session Manager"), RegistryKeyPermissionCheck.ReadWriteSubTree);
					registryKey.CreateSubKey("kernel");
					registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\Control\\Session Manager\\kernel"), RegistryKeyPermissionCheck.ReadWriteSubTree);
					registryKey.SetValue("DisableExceptionChainValidation", 0);
					registryKey.Dispose();
					registryKey = null;
				}
			}
			else
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\Control\\Session Manager\\kernel"), RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey != null)
				{
					registryKey.SetValue("DisableExceptionChainValidation", 1);
					registryKey.Dispose();
					registryKey = null;
				}
				else
				{
					registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\Control\\Session Manager"), RegistryKeyPermissionCheck.ReadWriteSubTree);
					registryKey.CreateSubKey("kernel");
					registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\Control\\Session Manager\\kernel"), RegistryKeyPermissionCheck.ReadWriteSubTree);
					registryKey.SetValue("DisableExceptionChainValidation", 1);
					registryKey.Dispose();
					registryKey = null;
				}
			}
			NotifyPropertyChanged("CheckedVaccine13");
			NotifyPropertyChanged("EnableAntigen13");
			NotifyPropertyChanged("StrVaccineAll");
		}
	}

	public bool CheckedVaccine14
	{
		get
		{
			bool result = true;
			if (EnableAntigen14)
			{
				result = false;
			}
			return result;
		}
		set
		{
			if (value)
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("System\\CurrentControlSet\\Services\\LanmanServer\\Parameters"), RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey != null)
				{
					registryKey.SetValue("AutoShareServer", 1);
					registryKey.SetValue("AutoShareWks", 1);
					registryKey.Dispose();
					registryKey = null;
				}
				else
				{
					registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("System\\CurrentControlSet\\Services\\LanmanServer"), RegistryKeyPermissionCheck.ReadWriteSubTree);
					registryKey.CreateSubKey("Parameters");
					registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("System\\CurrentControlSet\\Services\\LanmanServer\\Parameters"), RegistryKeyPermissionCheck.ReadWriteSubTree);
					registryKey.SetValue("AutoShareServer", 1);
					registryKey.SetValue("AutoShareWks", 1);
					registryKey.Dispose();
					registryKey = null;
				}
			}
			else
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("System\\CurrentControlSet\\Services\\LanmanServer\\Parameters"), RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey != null)
				{
					registryKey.SetValue("AutoShareServer", 0);
					registryKey.SetValue("AutoShareWks", 0);
					registryKey.Dispose();
					registryKey = null;
				}
				else
				{
					registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("System\\CurrentControlSet\\Services\\LanmanServer"), RegistryKeyPermissionCheck.ReadWriteSubTree);
					registryKey.CreateSubKey("Parameters");
					registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("System\\CurrentControlSet\\Services\\LanmanServer\\Parameters"), RegistryKeyPermissionCheck.ReadWriteSubTree);
					registryKey.SetValue("AutoShareServer", 0);
					registryKey.SetValue("AutoShareWks", 0);
					registryKey.Dispose();
					registryKey = null;
				}
			}
			NotifyPropertyChanged("CheckedVaccine14");
			NotifyPropertyChanged("EnableAntigen14");
			NotifyPropertyChanged("StrVaccineAll");
		}
	}

	public bool CheckedVaccine15
	{
		get
		{
			return !EnableAntigen15;
		}
		set
		{
			bool flag = false;
			if (value)
			{
				string netShare = Utils.getNetShare();
				MatchCollection matchCollection = null;
				matchCollection = Regex.Matches(netShare, "^[^\\$]{1}\\$", RegexOptions.IgnoreCase | RegexOptions.Multiline);
				for (int i = 0; i < matchCollection.Count; i++)
				{
					string text = matchCollection[i].ToString();
					Utils.ExecuteCommandSync("net share /delete " + text + " /y");
					flag = true;
				}
				Utils.ExecuteCommandSync("net share /delete ADMIN$ /y");
				netShare = Utils.getUserAccount();
				if (Regex.IsMatch(netShare, "FALSE\\s+Guest\\s+"))
				{
					flag = true;
					Utils.ExecuteCommandSync("net user guest /active:no");
				}
			}
			else
			{
				for (int i = 0; i < Utils.DriveArray().Length; i++)
				{
					string text = Utils.DriveArray()[i].Substring(0, 1);
					Utils.ExecuteCommandSync("net share " + text + "$=" + text + ":\\");
					flag = true;
				}
			}
			if (flag)
			{
				int num = 10;
				for (int i = 0; i < num; i++)
				{
					Application.DoEvents();
					CNativeWIN32.Sleep(100);
				}
			}
			NotifyPropertyChanged("CheckedVaccine15");
			NotifyPropertyChanged("CheckedVaccine16");
			NotifyPropertyChanged("EnableAntigen15");
			NotifyPropertyChanged("StrVaccineAll");
		}
	}

	public bool CheckedVaccine16
	{
		get
		{
			bool result = true;
			if (EnableAntigen16)
			{
				result = false;
			}
			return result;
		}
		set
		{
			if (value)
			{
				string uSERNAME = Utils.getUSERNAME();
				MatchCollection matchCollection = null;
				matchCollection = regexp_falsessd20s.Matches(uSERNAME);
				if (0 < matchCollection.Count)
				{
					if (uSERNAME == matchCollection[0].Groups[matchCollection[0].Groups.Count - 1].ToString().Trim())
					{
						Utils.alert("이 계정(" + uSERNAME + ")의 웹브라우저는 UAC설정과 상관없이 관리자권한으로 실행되는 취약점이 있으며,\n랜섬웨어는 이 취약점을 이용하므로 개선하기 위해서는 다른 계정을 사용한 후 해당 보안설정을 적용 하세요.");
					}
				}
				else
				{
					string command = "net user guest /active:no";
					Utils.ExecuteCommandSync(command);
					command = "net user administrator /active:no";
					Utils.ExecuteCommandSync(command);
					command = "net user WDAGUtilityAccount /active:no";
					Utils.ExecuteCommandSync(command);
					command = "NET USE /Persistent:No";
					Utils.ExecuteCommandSync(command);
				}
			}
			else
			{
				string command = "net user administrator /active:yes";
				Utils.ExecuteCommandSync(command);
			}
			NotifyPropertyChanged("CheckedVaccine16");
			NotifyPropertyChanged("CheckedVaccine15");
			NotifyPropertyChanged("EnableAntigen16");
			NotifyPropertyChanged("StrVaccineAll");
		}
	}

	public bool CheckedVaccine17
	{
		get
		{
			bool result = true;
			if (EnableAntigen17)
			{
				result = false;
			}
			return result;
		}
		set
		{
			if (value)
			{
				Utils.UAC_owner(secure: true);
			}
			else
			{
				Utils.UAC_owner(secure: false);
			}
			NotifyPropertyChanged("CheckedVaccine17");
			NotifyPropertyChanged("EnableAntigen17");
			NotifyPropertyChanged("StrVaccineAll");
		}
	}

	public bool CheckedVaccine18
	{
		get
		{
			bool result = true;
			if (EnableAntigen18)
			{
				result = false;
			}
			return result;
		}
		set
		{
			if (value)
			{
				Utils.RECENT_system(secure: true);
			}
			else
			{
				Utils.RECENT_system(secure: false);
			}
			NotifyPropertyChanged("CheckedVaccine18");
			NotifyPropertyChanged("EnableAntigen18");
			NotifyPropertyChanged("StrVaccineAll");
		}
	}

	public bool CheckedVaccine19
	{
		get
		{
			bool result = true;
			if (EnableAntigen19)
			{
				result = false;
			}
			return result;
		}
		set
		{
			if (value)
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\services\\SharedAccess\\Parameters\\FirewallPolicy\\StandardProfile"), RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey != null)
				{
					registryKey.SetValue("EnableFirewall", 1);
					registryKey.Dispose();
					registryKey = null;
				}
				registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\services\\SharedAccess\\Parameters\\FirewallPolicy\\PublicProfile"), RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey != null)
				{
					registryKey.SetValue("EnableFirewall", 1);
					registryKey.Dispose();
					registryKey = null;
				}
			}
			else
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\services\\SharedAccess\\Parameters\\FirewallPolicy\\StandardProfile"), RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey != null)
				{
					registryKey.SetValue("EnableFirewall", 0);
					registryKey.Dispose();
					registryKey = null;
				}
				registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\services\\SharedAccess\\Parameters\\FirewallPolicy\\PublicProfile"), RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey != null)
				{
					registryKey.SetValue("EnableFirewall", 0);
					registryKey.Dispose();
					registryKey = null;
				}
			}
			NotifyPropertyChanged("CheckedVaccine19");
			NotifyPropertyChanged("EnableAntigen19");
			NotifyPropertyChanged("StrVaccineAll");
		}
	}

	public bool CheckedVaccine20
	{
		get
		{
			bool result = true;
			if (EnableAntigen20)
			{
				result = false;
			}
			return result;
		}
		set
		{
			string text = "COMSysApp";
			if (value)
			{
				Utils.ExecuteCommandSync("sc.exe stop " + text);
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\services\\" + text), RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey != null)
				{
					registryKey.SetValue("Start", 4);
					registryKey.Dispose();
					registryKey = null;
					SetServiceDisabled(text);
				}
			}
			else
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\services\\" + text), RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey != null)
				{
					registryKey.SetValue("Start", 3);
					registryKey.Dispose();
					registryKey = null;
					SetServiceDisabled(text, 3);
				}
			}
			NotifyPropertyChanged("CheckedVaccine20");
			NotifyPropertyChanged("EnableAntigen20");
			NotifyPropertyChanged("StrVaccineAll");
		}
	}

	public bool CheckedVaccine21
	{
		get
		{
			bool result = true;
			if (EnableAntigen21)
			{
				result = false;
			}
			return result;
		}
		set
		{
			string text = "W32Time";
			if (value)
			{
				Utils.ExecuteCommandSync("sc.exe stop " + text);
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\services\\" + text), RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey != null)
				{
					registryKey.SetValue("Start", 4);
					registryKey.Dispose();
					registryKey = null;
					SetServiceDisabled(text);
				}
			}
			else
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\services\\" + text), RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey != null)
				{
					registryKey.SetValue("Start", 3);
					registryKey.Dispose();
					registryKey = null;
					SetServiceDisabled(text, 3);
				}
			}
			NotifyPropertyChanged("CheckedVaccine21");
			NotifyPropertyChanged("EnableAntigen21");
			NotifyPropertyChanged("StrVaccineAll");
		}
	}

	public bool CheckedVaccine22
	{
		get
		{
			bool result = true;
			if (EnableAntigen22)
			{
				result = false;
			}
			return result;
		}
		set
		{
			string text = "LanmanServer";
			if (value)
			{
				Utils.ExecuteCommandSync("sc.exe stop " + text);
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\services\\") + text, RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey != null)
				{
					registryKey.SetValue("Start", 4);
					registryKey.Dispose();
					registryKey = null;
					SetServiceDisabled(text);
				}
				registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\Services\\Browser"), RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey != null)
				{
					List<string> list = new List<string>();
					if (registryKey.GetValue("DependOnService") is string[] array)
					{
						for (int i = 0; i < array.Length; i++)
						{
							if (-1 == array[i].IndexOf(text, StringComparison.CurrentCultureIgnoreCase))
							{
								list.Add(array[i]);
							}
						}
					}
					registryKey.SetValue("DependOnService", list.ToArray());
					registryKey.Dispose();
					registryKey = null;
				}
				registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\Services\\HomeGroupListener"), RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey != null)
				{
					List<string> list = new List<string>();
					if (registryKey.GetValue("DependOnService") is string[] array2)
					{
						for (int i = 0; i < array2.Length; i++)
						{
							if (-1 == array2[i].IndexOf(text, StringComparison.CurrentCultureIgnoreCase))
							{
								list.Add(array2[i]);
							}
						}
					}
					registryKey.SetValue("DependOnService", list.ToArray());
					registryKey.Dispose();
					registryKey = null;
				}
			}
			else
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\services\\") + text, RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey != null)
				{
					registryKey.SetValue("Start", 3);
					registryKey.Dispose();
					registryKey = null;
					SetServiceDisabled(text, 3);
				}
				registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\Services\\Browser"), RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey != null)
				{
					bool flag = false;
					List<string> list = new List<string>();
					if (registryKey.GetValue("DependOnService") is string[] array3)
					{
						for (int i = 0; i < array3.Length; i++)
						{
							if (-1 == array3[i].IndexOf(text, StringComparison.CurrentCultureIgnoreCase))
							{
								list.Add(array3[i]);
							}
							else
							{
								flag = true;
							}
						}
					}
					if (!flag)
					{
						list.Add(text);
					}
					registryKey.SetValue("DependOnService", list.ToArray());
					registryKey.Dispose();
					registryKey = null;
				}
				registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\Services\\HomeGroupListener"), RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey != null)
				{
					bool flag = false;
					List<string> list = new List<string>();
					if (registryKey.GetValue("DependOnService") is string[] array4)
					{
						for (int i = 0; i < array4.Length; i++)
						{
							if (-1 == array4[i].IndexOf(text, StringComparison.CurrentCultureIgnoreCase))
							{
								list.Add(array4[i]);
							}
							else
							{
								flag = true;
							}
						}
					}
					if (!flag)
					{
						list.Add(text);
					}
					registryKey.SetValue("DependOnService", list.ToArray());
					registryKey.Dispose();
					registryKey = null;
				}
			}
			NotifyPropertyChanged("CheckedVaccine22");
			NotifyPropertyChanged("EnableAntigen22");
			NotifyPropertyChanged("StrVaccineAll");
		}
	}

	public bool CheckedVaccine23
	{
		get
		{
			bool result = true;
			if (EnableAntigen23)
			{
				result = false;
			}
			return result;
		}
		set
		{
			string text = "Browser";
			if (value)
			{
				Utils.ExecuteCommandSync("sc.exe stop " + text);
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\services\\" + text, RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey != null)
				{
					registryKey.SetValue("Start", 4);
					registryKey.Dispose();
					registryKey = null;
					SetServiceDisabled(text);
				}
			}
			else
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\services\\" + text, RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey != null)
				{
					registryKey.SetValue("Start", 3);
					registryKey.Dispose();
					registryKey = null;
				}
			}
			NotifyPropertyChanged("CheckedVaccine23");
			NotifyPropertyChanged("EnableAntigen23");
			NotifyPropertyChanged("StrVaccineAll");
		}
	}

	public bool CheckedVaccine24
	{
		get
		{
			bool result = true;
			if (EnableAntigen24)
			{
				result = false;
			}
			return result;
		}
		set
		{
			if (value)
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("Software\\Policies\\Microsoft\\Windows\\Explorer"), RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey == null)
				{
					registryKey = Registry.LocalMachine.CreateSubKey(Utils.SepaString("Software\\Policies\\Microsoft\\Windows\\Explorer"));
				}
				if (registryKey != null)
				{
					registryKey.SetValue("NoDataExecutionPrevention", 0);
					registryKey.Dispose();
					registryKey = null;
				}
			}
			else
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("Software\\Policies\\Microsoft\\Windows\\Explorer"), RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey != null)
				{
					registryKey.SetValue("NoDataExecutionPrevention", 1);
					registryKey.Dispose();
					registryKey = null;
				}
			}
			NotifyPropertyChanged("CheckedVaccine24");
			NotifyPropertyChanged("EnableAntigen24");
			NotifyPropertyChanged("StrVaccineAll");
		}
	}

	public bool CheckedVaccine25
	{
		get
		{
			bool result = true;
			if (EnableAntigen25)
			{
				result = false;
			}
			return result;
		}
		set
		{
			if (File.Exists("c:\\windows\\system32\\bcdedit2.exe"))
			{
				if (value)
				{
					Utils.ExecuteCommandSync("bcdedit2.exe /set {current} nx AlwaysOn");
				}
				else
				{
					Utils.ExecuteCommandSync("bcdedit2.exe /set {current} nx OptIn");
				}
			}
			else if (value)
			{
				Utils.ExecuteCommandSync("bcdedit.exe /set {current} nx AlwaysOn");
			}
			else
			{
				Utils.ExecuteCommandSync("bcdedit.exe /set {current} nx OptIn");
			}
			NotifyPropertyChanged("CheckedVaccine25");
			NotifyPropertyChanged("EnableAntigen25");
			NotifyPropertyChanged("StrVaccineAll");
		}
	}

	public bool CheckedVaccine26
	{
		get
		{
			return !EnableAntigen26;
		}
		set
		{
			if (value)
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters"), RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey != null)
				{
					registryKey.SetValue("SynAttackProtect", 1);
					registryKey.SetValue("TcpMaxHalfOpen", 100);
					registryKey.SetValue("TcpMaxHalfOpenRetried", 80);
					registryKey.SetValue("EnableICMPRedirect", 1);
					registryKey.SetValue("EnableDeadGWDetect", 0);
					registryKey.SetValue("KeepAliveTime", 300000);
					registryKey.SetValue("PerformRouterDiscovery", 0);
					registryKey.SetValue("EnableICMPRedirects", 0);
					registryKey.SetValue("EnablePMTUDiscovery", 0);
					registryKey.Dispose();
					registryKey = null;
				}
				registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\Services\\NetBT\\Parameters"), RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey != null)
				{
					registryKey.SetValue("NoNameReleaseOnDemand", 1);
					registryKey.Dispose();
					registryKey = null;
				}
			}
			else
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters"), RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey != null)
				{
					registryKey.SetValue("SynAttackProtect", 0);
					registryKey.SetValue("TcpMaxHalfOpen", 100);
					registryKey.SetValue("TcpMaxHalfOpenRetried", 80);
					registryKey.SetValue("EnableICMPRedirect", 1);
					registryKey.SetValue("EnableDeadGWDetect", 1);
					registryKey.SetValue("KeepAliveTime", 7200000);
					registryKey.SetValue("PerformRouterDiscovery", 0);
					registryKey.SetValue("EnableICMPRedirects", 0);
					registryKey.SetValue("EnablePMTUDiscovery", 1);
					registryKey.Dispose();
					registryKey = null;
				}
				registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\Services\\NetBT\\Parameters"), RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey != null)
				{
					registryKey.SetValue("NoNameReleaseOnDemand", 1);
					registryKey.Dispose();
					registryKey = null;
				}
			}
			NotifyPropertyChanged("CheckedVaccine26");
			NotifyPropertyChanged("EnableAntigen26");
			NotifyPropertyChanged("StrVaccineAll");
		}
	}

	public bool CheckedVaccine27
	{
		get
		{
			return !EnableAntigen27;
		}
		set
		{
			if (File.Exists("c:\\windows\\system32\\bcdedit2.exe"))
			{
				if (value)
				{
					Utils.ExecuteCommandSync("bcdedit2.exe /set {default} recoveryenabled yes");
					Utils.ExecuteCommandSync("bcdedit2.exe /set {default} bootstatuspolicy displayallfailure");
				}
				else
				{
					Utils.ExecuteCommandSync("bcdedit2.exe /set {default} recoveryenabled no");
				}
			}
			else if (value)
			{
				Utils.ExecuteCommandSync("bcdedit.exe /set {default} recoveryenabled yes");
				Utils.ExecuteCommandSync("bcdedit.exe /set {default} bootstatuspolicy displayallfailure");
			}
			else
			{
				Utils.ExecuteCommandSync("bcdedit.exe /set {default} recoveryenabled no");
			}
			NotifyPropertyChanged("CheckedVaccine27");
			NotifyPropertyChanged("EnableAntigen27");
			NotifyPropertyChanged("StrVaccineAll");
		}
	}

	public bool CheckedVaccine28
	{
		get
		{
			return !EnableAntigen28;
		}
		set
		{
			if (value)
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\Services\\LanmanServer\\Parameters"), RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey != null)
				{
					registryKey.SetValue("SMB1", 0);
					registryKey.Dispose();
					registryKey = null;
				}
				registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\services\\mrxsmb10"), RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey != null)
				{
					Utils.ExecuteCommandSync("sc.exe stop mrxsmb10");
					registryKey.SetValue("Start", 4);
					registryKey.Dispose();
					registryKey = null;
				}
				RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\services\\mrxsmb"), RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey2 != null)
				{
					Utils.ExecuteCommandSync("sc.exe stop mrxsmb");
					registryKey2.SetValue("Start", 4);
					registryKey2.Dispose();
					registryKey2 = null;
				}
				registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\Services\\LanmanWorkstation"), RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey != null)
				{
					List<string> list = new List<string>();
					if (registryKey.GetValue("DependOnService") is string[] array)
					{
						for (int i = 0; i < array.Length; i++)
						{
							if (-1 == array[i].IndexOf("MRxSmb10", StringComparison.CurrentCultureIgnoreCase) && 0 != string.Compare(array[i], "MRxSmb", ignoreCase: true))
							{
								list.Add(array[i]);
							}
						}
					}
					registryKey.SetValue("DependOnService", list.ToArray());
					registryKey.Dispose();
					registryKey = null;
				}
			}
			else
			{
				bool flag = false;
				bool flag2 = false;
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\Services\\LanmanServer\\Parameters"), RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey != null)
				{
					registryKey.SetValue("SMB1", 1);
					registryKey.Dispose();
					registryKey = null;
				}
				registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\services\\mrxsmb10"), RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey != null)
				{
					flag2 = true;
					registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\services\\mrxsmb10"), RegistryKeyPermissionCheck.ReadWriteSubTree);
					registryKey.SetValue("Start", 3);
					registryKey.Dispose();
					registryKey = null;
				}
				RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\services\\mrxsmb"), RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey2 != null)
				{
					flag = true;
					registryKey2 = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\services\\mrxsmb"), RegistryKeyPermissionCheck.ReadWriteSubTree);
					registryKey2.SetValue("Start", 3);
					registryKey2.Dispose();
					registryKey2 = null;
				}
				registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\Services\\LanmanWorkstation"), RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey != null)
				{
					bool flag3 = false;
					List<string> list = new List<string>();
					if (registryKey.GetValue("DependOnService") is string[] array2)
					{
						for (int i = 0; i < array2.Length; i++)
						{
							if (-1 == array2[i].IndexOf("MRxSmb10", StringComparison.CurrentCultureIgnoreCase) && 0 != string.Compare(array2[i], "MRxSmb", ignoreCase: true))
							{
								list.Add(array2[i]);
							}
							else
							{
								flag3 = true;
							}
						}
					}
					if (!flag3 && flag2)
					{
						list.Add("MRxSmb10");
						flag3 = true;
					}
					if (!flag3 && flag)
					{
						list.Add("MRxSmb");
					}
					registryKey.SetValue("DependOnService", list.ToArray());
					registryKey.Dispose();
					registryKey = null;
				}
			}
			NotifyPropertyChanged("CheckedVaccine28");
			NotifyPropertyChanged("EnableAntigen28");
			NotifyPropertyChanged("StrVaccineAll");
		}
	}

	public bool CheckedVaccine29
	{
		get
		{
			return !EnableAntigen29;
		}
		set
		{
			Utils.PICALUA_system(value);
			NotifyPropertyChanged("CheckedVaccine29");
			NotifyPropertyChanged("EnableAntigen29");
			NotifyPropertyChanged("StrVaccineAll");
		}
	}

	public bool CheckedVaccine30
	{
		get
		{
			return !EnableAntigen30;
		}
		set
		{
			FirewallApplyBlock("explorer.exe", value);
			NotifyPropertyChanged("CheckedVaccine30");
			NotifyPropertyChanged("EnableAntigen30");
			NotifyPropertyChanged("StrVaccineAll");
		}
	}

	public bool CheckedVaccine31
	{
		get
		{
			return !EnableAntigen31;
		}
		set
		{
			FirewallApplyAllow("vlc.exe", value);
			NotifyPropertyChanged("CheckedVaccine31");
			NotifyPropertyChanged("EnableAntigen31");
			NotifyPropertyChanged("StrVaccineAll");
		}
	}

	public bool CheckedVaccine32
	{
		get
		{
			return !EnableAntigen32;
		}
		set
		{
			FirewallApplyBlock("wmplayer.exe", value);
			NotifyPropertyChanged("CheckedVaccine32");
			NotifyPropertyChanged("EnableAntigen32");
			NotifyPropertyChanged("StrVaccineAll");
		}
	}

	public bool CheckedVaccine33
	{
		get
		{
			return !EnableAntigen33;
		}
		set
		{
			FirewallApplyBlock("services.exe", value);
			NotifyPropertyChanged("CheckedVaccine33");
			NotifyPropertyChanged("EnableAntigen33");
			NotifyPropertyChanged("StrVaccineAll");
		}
	}

	public bool CheckedVaccine34
	{
		get
		{
			return !EnableAntigen34;
		}
		set
		{
			if (value)
			{
				Registry.CurrentUser.OpenSubKey(Utils.SepaString("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer"), RegistryKeyPermissionCheck.ReadWriteSubTree)?.SetValue("NoDriveTypeAutoRun", 255);
			}
			else
			{
				Registry.CurrentUser.OpenSubKey(Utils.SepaString("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer"), RegistryKeyPermissionCheck.ReadWriteSubTree)?.SetValue("NoDriveTypeAutoRun", 145);
			}
			NotifyPropertyChanged("CheckedVaccine34");
			NotifyPropertyChanged("EnableAntigen34");
			NotifyPropertyChanged("StrVaccineAll");
		}
	}

	public bool CheckedVaccine35
	{
		get
		{
			return !EnableAntigen35;
		}
		set
		{
			string text = "RemoteRegistry";
			if (value)
			{
				Utils.ExecuteCommandSync("sc.exe stop " + text);
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\services\\" + text), RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey != null)
				{
					registryKey.SetValue("Start", 4);
					registryKey.Dispose();
					registryKey = null;
					SetServiceDisabled(text);
				}
			}
			else
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\services\\" + text), RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey != null)
				{
					registryKey.SetValue("Start", 3);
					registryKey.Dispose();
					registryKey = null;
					SetServiceDisabled(text, 3);
				}
			}
			NotifyPropertyChanged("CheckedVaccine35");
			NotifyPropertyChanged("EnableAntigen35");
			NotifyPropertyChanged("StrVaccineAll");
		}
	}

	public bool CheckedVaccine36
	{
		get
		{
			bool result = false;
			if (EnableAntigen36)
			{
				string maxLatestDfrg = GetMaxLatestDfrg();
				if (maxLatestDfrg != "")
				{
					if (string.Compare(maxLatestDfrg, oneYearAgoDate) >= 0)
					{
						result = true;
					}
					else
					{
						IsOldVaccine = true;
						IsOldVaccine36 = true;
					}
				}
				else
				{
					IsOldVaccine = true;
					IsOldVaccine36 = true;
				}
			}
			else
			{
				result = true;
			}
			return result;
		}
		set
		{
			if (value)
			{
				App.iniFile.WriteValue_UTF8("CheckedVacc36", nowYYYYMMDD);
				CNativeWIN32.ShellExecute(0, "open", "defrag.exe", "-c -v -u&time /t&pause", PowerDeskApp2014.replaceNormalizePath("%windir%\\system32"), 1);
			}
			else
			{
				App.iniFile.WriteValue_UTF8("CheckedVacc36", "");
			}
			NotifyPropertyChanged("CheckedVaccine36");
			NotifyPropertyChanged("EnableAntigen36");
		}
	}

	public bool CheckedVaccine37
	{
		get
		{
			bool result = false;
			if (EnableAntigen37)
			{
				RegistryKey registryKey = ((!CNativeWIN32.IsWindows7()) ? Registry.LocalMachine.OpenSubKey(Utils.SepaString("SOFTWARE\\Microsoft\\Windows Defender")) : Registry.LocalMachine.OpenSubKey(Utils.SepaString("SOFTWARE\\Windows Defender")));
				if (registryKey != null)
				{
					int num = Convert.ToInt32(registryKey.GetValue("DisableAntiSpyware", "0"));
					if (num == 1)
					{
						result = true;
					}
				}
			}
			else
			{
				result = true;
			}
			return result;
		}
		set
		{
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				if (value)
				{
					RegistryKey registryKey = ((!CNativeWIN32.IsWindows7()) ? Registry.LocalMachine.OpenSubKey(Utils.SepaString("SOFTWARE\\Microsoft\\Windows Defender"), RegistryKeyPermissionCheck.ReadWriteSubTree) : Registry.LocalMachine.OpenSubKey(Utils.SepaString("SOFTWARE\\Windows Defender"), RegistryKeyPermissionCheck.ReadWriteSubTree));
					if (registryKey != null)
					{
						registryKey.SetValue("DisableAntiSpyware", 1);
						registryKey.Dispose();
						registryKey = null;
					}
				}
				else
				{
					RegistryKey registryKey = ((!CNativeWIN32.IsWindows7()) ? Registry.LocalMachine.OpenSubKey(Utils.SepaString("SOFTWARE\\Microsoft\\Windows Defender"), RegistryKeyPermissionCheck.ReadWriteSubTree) : Registry.LocalMachine.OpenSubKey(Utils.SepaString("SOFTWARE\\Windows Defender"), RegistryKeyPermissionCheck.ReadWriteSubTree));
					if (registryKey != null)
					{
						registryKey.SetValue("DisableAntiSpyware", 0);
						registryKey.Dispose();
						registryKey = null;
					}
				}
				NotifyPropertyChanged("CheckedVaccine37");
				NotifyPropertyChanged("EnableAntigen37");
			}
			catch (Exception ex)
			{
				string message = ex.Message;
				IsErrorWindowDefender = true;
				NotifyPropertyChanged("EnableAntigen37");
				AutoClosingMessageBox.Show1(message, "PowerHealthChecker", 3100, 0);
			}
		}
	}

	public bool CheckedVaccine38
	{
		get
		{
			return !EnableAntigen38;
		}
		set
		{
			if (value)
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Active Setup\\Installed Components");
				if (registryKey != null)
				{
					string[] subKeyNames = registryKey.GetSubKeyNames();
					for (int i = 0; i < subKeyNames.Length; i++)
					{
						RegistryKey registryKey2 = registryKey.OpenSubKey(subKeyNames[i], RegistryKeyPermissionCheck.ReadWriteSubTree);
						if (registryKey2 != null)
						{
							string value2 = registryKey2.GetValue("StubPath", "") as string;
							if (!string.IsNullOrEmpty(value2))
							{
								registryKey2.SetValue("StubPath_GoldStar", value2);
								registryKey2.DeleteValue("StubPath");
							}
							registryKey2.Close();
							registryKey2.Dispose();
						}
					}
					registryKey.Close();
					registryKey.Dispose();
				}
				registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Wow6432Node\\Microsoft\\Active Setup\\Installed Components");
				if (registryKey != null)
				{
					string[] subKeyNames = registryKey.GetSubKeyNames();
					for (int i = 0; i < subKeyNames.Length; i++)
					{
						RegistryKey registryKey2 = registryKey.OpenSubKey(subKeyNames[i], RegistryKeyPermissionCheck.ReadWriteSubTree);
						if (registryKey2 != null)
						{
							string value2 = registryKey2.GetValue("StubPath", "") as string;
							if (!string.IsNullOrEmpty(value2))
							{
								registryKey2.SetValue("StubPath_GoldStar", value2);
								registryKey2.DeleteValue("StubPath");
							}
							registryKey2.Close();
							registryKey2.Dispose();
						}
					}
					registryKey.Close();
					registryKey.Dispose();
				}
			}
			else
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Active Setup\\Installed Components");
				if (registryKey != null)
				{
					string[] subKeyNames = registryKey.GetSubKeyNames();
					for (int i = 0; i < subKeyNames.Length; i++)
					{
						RegistryKey registryKey2 = registryKey.OpenSubKey(subKeyNames[i], RegistryKeyPermissionCheck.ReadWriteSubTree);
						if (registryKey2 != null)
						{
							string value2 = registryKey2.GetValue("StubPath_GoldStar", "") as string;
							if (!string.IsNullOrEmpty(value2))
							{
								registryKey2.SetValue("StubPath", value2);
								registryKey2.DeleteValue("StubPath_GoldStar");
							}
							registryKey2.Close();
							registryKey2.Dispose();
						}
					}
					registryKey.Close();
					registryKey.Dispose();
				}
				registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Wow6432Node\\Microsoft\\Active Setup\\Installed Components");
				if (registryKey != null)
				{
					string[] subKeyNames = registryKey.GetSubKeyNames();
					for (int i = 0; i < subKeyNames.Length; i++)
					{
						RegistryKey registryKey2 = registryKey.OpenSubKey(subKeyNames[i], RegistryKeyPermissionCheck.ReadWriteSubTree);
						if (registryKey2 != null)
						{
							string value2 = registryKey2.GetValue("StubPath_GoldStar", "") as string;
							if (!string.IsNullOrEmpty(value2))
							{
								registryKey2.SetValue("StubPath", value2);
								registryKey2.DeleteValue("StubPath_GoldStar");
							}
							registryKey2.Close();
							registryKey2.Dispose();
						}
					}
					registryKey.Close();
					registryKey.Dispose();
				}
			}
			NotifyPropertyChanged("CheckedVaccine38");
			NotifyPropertyChanged("EnableAntigen38");
		}
	}

	public bool CheckedVaccine39
	{
		get
		{
			return !EnableAntigen39;
		}
		set
		{
			if (value)
			{
				Registry.CurrentUser.OpenSubKey(Utils.SepaString("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer"), RegistryKeyPermissionCheck.ReadWriteSubTree)?.SetValue("NoActiveDesktop", 1);
			}
			else
			{
				Registry.CurrentUser.OpenSubKey(Utils.SepaString("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer"), RegistryKeyPermissionCheck.ReadWriteSubTree)?.SetValue("NoActiveDesktop", 0);
			}
			NotifyPropertyChanged("CheckedVaccine39");
			NotifyPropertyChanged("EnableAntigen39");
		}
	}

	public bool CheckedVaccine40
	{
		get
		{
			return !EnableAntigen40;
		}
		set
		{
			if (value)
			{
				Registry.CurrentUser.OpenSubKey(Utils.SepaString("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer"), RegistryKeyPermissionCheck.ReadWriteSubTree)?.SetValue("NoAddPrinter", 1);
			}
			else
			{
				Registry.CurrentUser.OpenSubKey(Utils.SepaString("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer"), RegistryKeyPermissionCheck.ReadWriteSubTree)?.SetValue("NoAddPrinter", 0);
			}
			NotifyPropertyChanged("CheckedVaccine40");
			NotifyPropertyChanged("EnableAntigen40");
			NotifyPropertyChanged("StrVaccineAll");
		}
	}

	public bool CheckedVaccine60
	{
		get
		{
			return !EnableAntigen60;
		}
		set
		{
			if (value)
			{
				Registry.CurrentUser.OpenSubKey(Utils.SepaString("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer"), RegistryKeyPermissionCheck.ReadWriteSubTree)?.SetValue("disallowrun", 1);
			}
			else
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Utils.SepaString("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer"), RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey != null)
				{
				}
			}
			NotifyPropertyChanged("CheckedVaccine60");
			NotifyPropertyChanged("EnableAntigen60");
			NotifyPropertyChanged("StrVaccineAll");
		}
	}

	public bool CheckedVaccine41
	{
		get
		{
			return !EnableAntigen41;
		}
		set
		{
			if (value)
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\services"), RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey != null)
				{
					string[] subKeyNames = registryKey.GetSubKeyNames();
					for (int i = 0; i < subKeyNames.Count(); i++)
					{
						if (!Regex.IsMatch(subKeyNames[i], "^xb[glo]{1}", RegexOptions.IgnoreCase))
						{
							continue;
						}
						RegistryKey registryKey2 = registryKey.OpenSubKey(subKeyNames[i]);
						object value2 = registryKey2.GetValue("start");
						if (value2 != null)
						{
							string text = value2.ToString();
							if (text == null || !(text == "4"))
							{
								SetServiceDisabled(subKeyNames[i]);
							}
						}
					}
				}
			}
			else
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\services"), RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey != null)
				{
					string[] subKeyNames = registryKey.GetSubKeyNames();
					for (int i = 0; i < subKeyNames.Count(); i++)
					{
						if (!Regex.IsMatch(subKeyNames[i], "^xb[glo]{1}", RegexOptions.IgnoreCase))
						{
							continue;
						}
						RegistryKey registryKey2 = registryKey.OpenSubKey(subKeyNames[i]);
						object value2 = registryKey2.GetValue("start");
						if (value2 != null)
						{
							string text = value2.ToString();
							if (text != null && text == "4")
							{
								SetServiceDisabled(subKeyNames[i], 3);
							}
						}
					}
				}
			}
			NotifyPropertyChanged("CheckedVaccine41");
			NotifyPropertyChanged("EnableAntigen41");
			NotifyPropertyChanged("StrVaccineAll");
			NotifyPropertyChanged("EnableAntigen41_fileExists");
		}
	}

	public bool CheckedVaccine42
	{
		get
		{
			return !EnableAntigen42;
		}
		set
		{
			if (value)
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\services\\wpnservice"));
				if (registryKey != null)
				{
					object value2 = registryKey.GetValue("start");
					if (value2 != null && value2.ToString() != "4")
					{
						SetServiceDisabled("wpnservice");
					}
				}
			}
			else
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\services\\wpnservice"));
				if (registryKey != null)
				{
					object value2 = registryKey.GetValue("start");
					if (value2 != null && value2.ToString() == "4")
					{
						SetServiceDisabled("wpnservice", 3);
					}
				}
			}
			NotifyPropertyChanged("CheckedVaccine42");
			NotifyPropertyChanged("EnableAntigen42");
			NotifyPropertyChanged("StrVaccineAll");
			NotifyPropertyChanged("EnableAntigen42_fileExists");
		}
	}

	public bool CheckedVaccine43
	{
		get
		{
			return !EnableAntigen43;
		}
		set
		{
			if (value)
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\services\\ibtsiva"));
				if (registryKey != null)
				{
					object value2 = registryKey.GetValue("start");
					if (value2 != null && value2.ToString() != "4")
					{
						SetServiceDisabled("ibtsiva");
					}
				}
			}
			else
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\services\\ibtsiva"));
				if (registryKey != null)
				{
					object value2 = registryKey.GetValue("start");
					if (value2 != null && value2.ToString() == "4")
					{
						SetServiceDisabled("ibtsiva", 3);
					}
				}
			}
			NotifyPropertyChanged("CheckedVaccine43");
			NotifyPropertyChanged("EnableAntigen43");
			NotifyPropertyChanged("StrVaccineAll");
			NotifyPropertyChanged("EnableAntigen43_fileExists");
		}
	}

	public bool CheckedVaccine44
	{
		get
		{
			return !EnableAntigen44;
		}
		set
		{
			string text = "w3svc";
			if (value)
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\services\\" + text));
				if (registryKey != null)
				{
					object value2 = registryKey.GetValue("start");
					if (value2 != null && value2.ToString() != "4")
					{
						SetServiceDisabled(text);
					}
				}
			}
			else
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\services\\" + text));
				if (registryKey != null)
				{
					object value2 = registryKey.GetValue("start");
					if (value2 != null && value2.ToString() == "4")
					{
						SetServiceDisabled(text, 3);
					}
				}
			}
			NotifyPropertyChanged("CheckedVaccine44");
			NotifyPropertyChanged("EnableAntigen44");
			NotifyPropertyChanged("StrVaccineAll");
			NotifyPropertyChanged("EnableAntigen44_fileExists");
		}
	}

	public bool CheckedVaccine45
	{
		get
		{
			return !EnableAntigen45;
		}
		set
		{
			string text = "clicktorunsvc";
			if (value)
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\services\\" + text));
				if (registryKey != null)
				{
					object value2 = registryKey.GetValue("start");
					if (value2 != null && value2.ToString() != "3")
					{
						SetServiceDisabled(text, 3);
					}
				}
			}
			else
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\services\\" + text));
				if (registryKey != null)
				{
					object value2 = registryKey.GetValue("start");
					if (value2 != null && value2.ToString() != "2")
					{
						SetServiceDisabled(text, 2);
					}
				}
			}
			NotifyPropertyChanged("CheckedVaccine45");
			NotifyPropertyChanged("EnableAntigen45");
			NotifyPropertyChanged("StrVaccineAll");
			NotifyPropertyChanged("EnableAntigen45_fileExists");
		}
	}

	public bool CheckedVaccine46
	{
		get
		{
			return !EnableAntigen46;
		}
		set
		{
			string text = "wsearch";
			if (value)
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\services\\" + text));
				if (registryKey != null)
				{
					object value2 = registryKey.GetValue("start");
					if (value2 != null && value2.ToString() != "4" && value2.ToString() != "3")
					{
						SetServiceDisabled(text, 3);
					}
				}
			}
			else
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\services\\" + text));
				if (registryKey != null)
				{
					object value2 = registryKey.GetValue("start");
					if (value2 != null && (value2.ToString() == "4" || value2.ToString() == "3"))
					{
						SetServiceDisabled(text, 2);
					}
				}
			}
			NotifyPropertyChanged("CheckedVaccine46");
			NotifyPropertyChanged("EnableAntigen46");
			NotifyPropertyChanged("StrVaccineAll");
			NotifyPropertyChanged("EnableAntigen46_fileExists");
		}
	}

	public bool CheckedVaccine47
	{
		get
		{
			return !EnableAntigen47;
		}
		set
		{
			if (value)
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SOFTWARE\\Microsoft\\Internet Explorer\\Extensions"), RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey != null)
				{
					string[] subKeyNames = registryKey.GetSubKeyNames();
					for (int i = 0; i < subKeyNames.Count(); i++)
					{
						RegistryKey registryKey2 = registryKey.OpenSubKey(subKeyNames[i]);
						string text = registryKey2.GetValue("ButtonText", "")!.ToString();
						if (-1 < text.IndexOf("OneNote", StringComparison.OrdinalIgnoreCase))
						{
							registryKey2.Close();
							registryKey2.Dispose();
							registryKey.DeleteSubKey(subKeyNames[i]);
						}
						else
						{
							registryKey2.Close();
							registryKey2.Dispose();
						}
					}
					registryKey.Close();
					registryKey.Dispose();
				}
				if (Utils.Is64OS())
				{
					RegistryKey registryKey3 = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SOFTWARE\\Wow6432Node\\Microsoft\\Internet Explorer\\Extensions"), RegistryKeyPermissionCheck.ReadWriteSubTree);
					if (registryKey3 != null)
					{
						string[] subKeyNames = registryKey3.GetSubKeyNames();
						for (int i = 0; i < subKeyNames.Count(); i++)
						{
							RegistryKey registryKey4 = registryKey3.OpenSubKey(subKeyNames[i]);
							string text = registryKey4.GetValue("ButtonText", "")!.ToString();
							if (-1 < text.IndexOf("OneNote", StringComparison.OrdinalIgnoreCase))
							{
								registryKey4.Close();
								registryKey4.Dispose();
								registryKey3.DeleteSubKey(subKeyNames[i]);
							}
							else
							{
								registryKey4.Close();
								registryKey4.Dispose();
							}
						}
						registryKey3.Close();
						registryKey3.Dispose();
					}
				}
			}
			NotifyPropertyChanged("CheckedVaccine47");
			NotifyPropertyChanged("EnableAntigen47");
			NotifyPropertyChanged("StrVaccineAll");
			NotifyPropertyChanged("EnableAntigen47_fileExists");
		}
	}

	public bool CheckedVaccine48
	{
		get
		{
			return !EnableAntigen48;
		}
		set
		{
			if (value)
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\services\\CDPSvc"));
				if (registryKey != null)
				{
					object value2 = registryKey.GetValue("start");
					if (value2 != null && value2.ToString() != "4")
					{
						SetServiceDisabled("CDPSvc");
					}
				}
			}
			else
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\services\\CDPSvc"));
				if (registryKey != null)
				{
					object value2 = registryKey.GetValue("start");
					if (value2 != null && value2.ToString() == "4")
					{
						SetServiceDisabled("CDPSvc", 3);
					}
				}
			}
			NotifyPropertyChanged("CheckedVaccine48");
			NotifyPropertyChanged("EnableAntigen48");
			NotifyPropertyChanged("StrVaccineAll");
			NotifyPropertyChanged("EnableAntigen48_fileExists");
		}
	}

	public bool CheckedVaccine49
	{
		get
		{
			return !EnableAntigen49;
		}
		set
		{
			Utils.WISPTIS_system(value);
			NotifyPropertyChanged("CheckedVaccine49");
			NotifyPropertyChanged("EnableAntigen49");
			NotifyPropertyChanged("StrVaccineAll");
		}
	}

	public bool CheckedVaccine57
	{
		get
		{
			return !EnableAntigen57;
		}
		set
		{
			Utils.USOCOREWORKER_system(value);
			NotifyPropertyChanged("CheckedVaccine57");
			NotifyPropertyChanged("EnableAntigen57");
			NotifyPropertyChanged("StrVaccineAll");
		}
	}

	public bool CheckedVaccine56
	{
		get
		{
			return !EnableAntigen56;
		}
		set
		{
			Utils.RASERVER_system(value);
			NotifyPropertyChanged("CheckedVaccine56");
			NotifyPropertyChanged("EnableAntigen56");
			NotifyPropertyChanged("StrVaccineAll");
		}
	}

	public bool CheckedVaccine58
	{
		get
		{
			return !EnableAntigen58;
		}
		set
		{
			Utils.NTOSKRNL_system(value);
			NotifyPropertyChanged("CheckedVaccine58");
			NotifyPropertyChanged("EnableAntigen58");
			NotifyPropertyChanged("StrVaccineAll");
		}
	}

	public bool CheckedVaccine50
	{
		get
		{
			return !EnableAntigen50;
		}
		set
		{
			Utils.ExplorerExecuteSecurity("sidebar.exe", value ? 1 : 2);
			if (value)
			{
				Utils.ExplorerExecuteSecurity("DW20.exe", 1);
				Utils.ExplorerExecuteSecurity("chromehelper.exe", 1);
				Utils.ExplorerExecuteSecurity("flash.exe", 1);
				Utils.ExplorerExecuteSecurity("msmsgs.exe", 1);
				Utils.ExplorerExecuteSecurity("CNFNOT32.EXE", 1);
				Utils.ExplorerExecuteSecurity("AdobeARMHelper.exe", 1);
				Utils.ExplorerExecuteSecurity("AcroBroker.exe", 1);
				Utils.ExplorerExecuteSecurity("VBoxControl.exe", 1);
				Utils.ExplorerExecuteSecurity("nacl64.exe", 1);
				Utils.ExplorerExecuteSecurity("crashreporter.exe", 1);
				Utils.ExplorerExecuteSecurity("icwconn2.exe", 1);
				Utils.ExplorerExecuteSecurity("RdrCEF.exe", 1);
				Utils.ExplorerExecuteSecurity("icwconn1.exe", 1);
				Utils.ExplorerExecuteSecurity("Rar.exe", 1);
				Utils.ExplorerExecuteSecurity("clview.exe", 1);
				Utils.ExplorerExecuteSecurity("drwtsn32.exe", 1);
				Utils.ExplorerExecuteSecurity("ncscv32.exe", 1);
				Utils.ExplorerExecuteSecurity("fkwk.exe", 1);
				Utils.ExplorerExecuteSecurity("netcore.exe", 1);
				Utils.ExplorerExecuteSecurity("ntuost.exe", 1);
				Utils.ExplorerExecuteSecurity("winhost.exe", 1);
				Utils.ExplorerExecuteSecurity("996E.exe", 1);
				Utils.ExplorerExecuteSecurity("vssadmin.exe", 1);
				Utils.ExplorerExecuteSecurity("powercfg.exe", 1);
				Utils.ExplorerExecuteSecurity("svchost.com", 1);
				Utils.ExplorerExecuteSecurity("mso7ftp.exe", 1);
				Utils.ExplorerExecuteSecurity("syswin.exe", 1);
				Utils.ExplorerExecuteSecurity("mdm.exe", 1);
				Utils.ExplorerExecuteSecurity("praxishotbackup.exe", 1);
				Utils.ExplorerExecuteSecurity("ptspack.exe", 1);
				Utils.ExplorerExecuteSecurity("suf_launch.exe", 1);
				Utils.ExplorerExecuteSecurity("osppsvc.exe", 1);
				Utils.ExplorerExecuteSecurity("pts.exe", 1);
				Utils.ExplorerExecuteSecurity("Silentinstaller.com-Everything-1.4.1.935.x86-Setup.exe", 1);
				Utils.ExplorerExecuteSecurity("555.exe", 1);
				Utils.ExplorerExecuteSecurity("noname.exe", 1);
				Utils.ExplorerExecuteSecurity("ExplorerMax.exe", 1);
				Utils.ExplorerExecuteSecurity("myfile.exe", 1);
				Utils.ExplorerExecuteSecurity("_cache_procexp.exe", 1);
				Utils.ExplorerExecuteSecurity("_cache_procexp.exe", 1);
				Utils.ExplorerExecuteSecurity("synaptics.exe", 1);
				Utils.ExplorerExecuteSecurity("sogouexplorerup.exe", 1);
				Utils.ExplorerExecuteSecurity("SogouExplorer.exe", 1);
				Utils.ExplorerExecuteSecurity("TXSSOSetup.exe", 1);
				Utils.ExplorerExecuteSecurity("QQSetupEx.exe", 1);
				Utils.ExplorerExecuteSecurity("DllLoader.exe", 1);
				Utils.ExplorerExecuteSecurity("program.exe", 1);
				Utils.ExplorerExecuteSecurity("Antivirus.Upgrade.Database.Cloud.cpl", 1);
				Utils.ExplorerExecuteSecurity("ie_to_edge_stub.exe", 1);
				Utils.ExplorerExecuteSecurity("anydeskprivateversion.exe", 1);
				Utils.ExplorerExecuteSecurity("virusanydesk.exe", 1);
				Utils.ExplorerExecuteSecurity("AnyDesk (1).exe", 1);
				Utils.ExplorerExecuteSecurity("cucklord.exe", 1);
				Utils.ExplorerExecuteSecurity("xmlala.exe", 1);
				Utils.ExplorerExecuteSecurity("OUTLOOK.EXE", 1);
				Utils.ExplorerExecuteSecurity("Security.Upgrade.Hotfix.Cloud.cpl", 1);
				Utils.ExplorerExecuteSecurity("chrome_proxy.exe", 1);
				Utils.ExplorerExecuteSecurity("SnippingTool.exe", 1);
				Utils.ExplorerExecuteSecurity("ScreenSketch.exe", 1);
			}
			else
			{
				Utils.ExplorerExecuteSecurity("DW20.exe", 2);
				Utils.ExplorerExecuteSecurity("chromehelper.exe", 2);
				Utils.ExplorerExecuteSecurity("flash.exe", 2);
				Utils.ExplorerExecuteSecurity("msmsgs.exe", 2);
				Utils.ExplorerExecuteSecurity("CNFNOT32.EXE", 2);
				Utils.ExplorerExecuteSecurity("AdobeARMHelper.exe", 2);
				Utils.ExplorerExecuteSecurity("AcroBroker.exe", 2);
				Utils.ExplorerExecuteSecurity("VBoxControl.exe", 2);
				Utils.ExplorerExecuteSecurity("nacl64.exe", 2);
				Utils.ExplorerExecuteSecurity("crashreporter.exe", 2);
				Utils.ExplorerExecuteSecurity("icwconn2.exe", 2);
				Utils.ExplorerExecuteSecurity("RdrCEF.exe", 2);
				Utils.ExplorerExecuteSecurity("icwconn1.exe", 2);
				Utils.ExplorerExecuteSecurity("Rar.exe", 2);
				Utils.ExplorerExecuteSecurity("clview.exe", 2);
				Utils.ExplorerExecuteSecurity("drwtsn32.exe", 2);
				Utils.ExplorerExecuteSecurity("ncscv32.exe", 2);
				Utils.ExplorerExecuteSecurity("fkwk.exe", 2);
				Utils.ExplorerExecuteSecurity("netcore.exe", 2);
				Utils.ExplorerExecuteSecurity("ntuost.exe", 2);
				Utils.ExplorerExecuteSecurity("winhost.exe", 2);
				Utils.ExplorerExecuteSecurity("996E.exe", 2);
				Utils.ExplorerExecuteSecurity("vssadmin.exe", 2);
				Utils.ExplorerExecuteSecurity("powercfg.exe", 2);
				Utils.ExplorerExecuteSecurity("svchost.com", 2);
				Utils.ExplorerExecuteSecurity("mso7ftp.exe", 2);
				Utils.ExplorerExecuteSecurity("syswin.exe", 2);
				Utils.ExplorerExecuteSecurity("mdm.exe", 2);
				Utils.ExplorerExecuteSecurity("praxishotbackup.exe", 2);
				Utils.ExplorerExecuteSecurity("ptspack.exe", 2);
				Utils.ExplorerExecuteSecurity("suf_launch.exe", 2);
				Utils.ExplorerExecuteSecurity("osppsvc.exe", 2);
				Utils.ExplorerExecuteSecurity("pts.exe", 2);
				Utils.ExplorerExecuteSecurity("Silentinstaller.com-Everything-1.4.1.935.x86-Setup.exe", 2);
				Utils.ExplorerExecuteSecurity("555.exe", 2);
				Utils.ExplorerExecuteSecurity("noname.exe", 2);
				Utils.ExplorerExecuteSecurity("ExplorerMax.exe", 2);
				Utils.ExplorerExecuteSecurity("myfile.exe", 2);
				Utils.ExplorerExecuteSecurity("_cache_procexp.exe", 2);
				Utils.ExplorerExecuteSecurity("_cache_procexp.exe", 2);
				Utils.ExplorerExecuteSecurity("synaptics.exe", 2);
				Utils.ExplorerExecuteSecurity("sogouexplorerup.exe", 2);
				Utils.ExplorerExecuteSecurity("SogouExplorer.exe", 2);
				Utils.ExplorerExecuteSecurity("TXSSOSetup.exe", 2);
				Utils.ExplorerExecuteSecurity("QQSetupEx.exe", 2);
				Utils.ExplorerExecuteSecurity("DllLoader.exe", 2);
				Utils.ExplorerExecuteSecurity("program.exe", 2);
				Utils.ExplorerExecuteSecurity("Antivirus.Upgrade.Database.Cloud.cpl", 2);
				Utils.ExplorerExecuteSecurity("ie_to_edge_stub.exe", 2);
				Utils.ExplorerExecuteSecurity("anydeskprivateversion.exe", 2);
				Utils.ExplorerExecuteSecurity("virusanydesk.exe", 2);
				Utils.ExplorerExecuteSecurity("AnyDesk (1).exe", 2);
				Utils.ExplorerExecuteSecurity("cucklord.exe", 2);
				Utils.ExplorerExecuteSecurity("xmlala.exe", 2);
				Utils.ExplorerExecuteSecurity("OUTLOOK.EXE", 2);
				Utils.ExplorerExecuteSecurity("Security.Upgrade.Hotfix.Cloud.cpl", 2);
				Utils.ExplorerExecuteSecurity("chrome_proxy.exe", 2);
				Utils.ExplorerExecuteSecurity("SnippingTool.exe", 2);
				Utils.ExplorerExecuteSecurity("ScreenSketch.exe", 2);
			}
			NotifyPropertyChanged("CheckedVaccine50");
			NotifyPropertyChanged("EnableAntigen50");
			NotifyPropertyChanged("StrVaccineAll");
		}
	}

	public bool CheckedVaccine51
	{
		get
		{
			return !EnableAntigen51;
		}
		set
		{
			Utils.ExplorerExecuteSecurity("powershell.exe", value ? 1 : 2);
			NotifyPropertyChanged("CheckedVaccine51");
			NotifyPropertyChanged("EnableAntigen51");
			NotifyPropertyChanged("StrVaccineAll");
		}
	}

	public bool CheckedVaccine52
	{
		get
		{
			return !EnableAntigen52;
		}
		set
		{
			Utils.ExplorerExecuteSecurity("pingsender.exe", value ? 1 : 2);
			NotifyPropertyChanged("CheckedVaccine52");
			NotifyPropertyChanged("EnableAntigen52");
			NotifyPropertyChanged("StrVaccineAll");
		}
	}

	public bool CheckedVaccine53
	{
		get
		{
			return !EnableAntigen53;
		}
		set
		{
			Utils.SolveVaccine53(value);
			NotifyPropertyChanged("CheckedVaccine53");
			NotifyPropertyChanged("EnableAntigen53");
			NotifyPropertyChanged("StrVaccineAll");
		}
	}

	public bool CheckedVaccine54
	{
		get
		{
			return !EnableAntigen54;
		}
		set
		{
			Utils.SolveVaccine54(value);
			NotifyPropertyChanged("CheckedVaccine54");
			NotifyPropertyChanged("EnableAntigen54");
			NotifyPropertyChanged("StrVaccineAll");
		}
	}

	public bool CheckedVaccine55
	{
		get
		{
			return SolvedProblem55;
		}
		set
		{
			Utils.SolveVaccine55(value);
			NotifyPropertyChanged("CheckedVaccine55");
			NotifyPropertyChanged("EnableAntigen55");
			NotifyPropertyChanged("StrVaccineAll");
		}
	}

	public bool CheckedFunction13
	{
		get
		{
			return !EnableCheckedFunction13;
		}
		set
		{
			if (value)
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Utils.SepaString("Control Panel\\Desktop"), RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey != null)
				{
					registryKey.SetValue("MenuShowDelay", "0");
					registryKey.Dispose();
					registryKey = null;
				}
			}
			else
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Utils.SepaString("Control Panel\\Desktop"), RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey != null)
				{
					registryKey.SetValue("MenuShowDelay", "400");
					registryKey.Dispose();
					registryKey = null;
				}
			}
			NotifyPropertyChanged("CheckedFunction13");
		}
	}

	public string StrVaccineAll
	{
		get
		{
			if (!bAuth || VaccAllUInewed)
			{
				return "기본 백신";
			}
			string text = "";
			if (PowerDeskApp2014.Instance != null)
			{
				IsStrVaccineAllEntered = true;
				if (CheckedVaccine1 && CheckedVaccine2 && CheckedVaccine3 && CheckedVaccine4 && CheckedVaccine5 && CheckedVaccine6 && CheckedVaccine7 && CheckedVaccine8 && CheckedVaccine9 && CheckedVaccine59 && CheckedVaccine10 && CheckedVaccine11 && CheckedVaccine49 && CheckedVaccine12 && CheckedVaccine13 && CheckedVaccine14 && CheckedVaccine15 && CheckedVaccine16 && CheckedVaccine17 && CheckedVaccine18 && CheckedVaccine19 && CheckedVaccine20 && CheckedVaccine21 && CheckedVaccine23 && CheckedVaccine24 && CheckedVaccine26 && CheckedVaccine27 && CheckedVaccine29 && CheckedVaccine30 && CheckedVaccine31 && CheckedVaccine32 && CheckedVaccine33 && CheckedVaccine34 && CheckedVaccine35 && CheckedVaccine40 && CheckedVaccine60 && CheckedVaccine41 && CheckedVaccine42 && CheckedVaccine43 && CheckedVaccine44 && CheckedVaccine45 && CheckedVaccine46 && CheckedVaccine47 && CheckedVaccine48 && CheckedVaccine50 && CheckedVaccine51 && CheckedVaccine52 && CheckedVaccine54 && CheckedVaccine55 && CheckedVaccine56 && CheckedVaccine57 && CheckedVaccine58)
				{
					iDoApplyAll = 0;
					return "<백신 접종 완료(" + 52 + ")종 >";
				}
				text = ((!CheckedVaccine30) ? (text + "◇") : (text + "◆"));
				text = ((!CheckedVaccine31) ? (text + "◇") : (text + "◆"));
				text = ((!CheckedVaccine32) ? (text + "◇") : (text + "◆"));
				text = ((!CheckedVaccine33) ? (text + "◇") : (text + "◆"));
				text = ((!CheckedVaccine1) ? (text + "◇") : (text + "◆"));
				text = ((!CheckedVaccine2) ? (text + "◇") : (text + "◆"));
				text = ((!CheckedVaccine3) ? (text + "◇") : (text + "◆"));
				text = ((!CheckedVaccine4) ? (text + "◇") : (text + "◆"));
				text = ((!CheckedVaccine5) ? (text + "◇") : (text + "◆"));
				text = ((!CheckedVaccine6) ? (text + "◇") : (text + "◆"));
				text = ((!CheckedVaccine7) ? (text + "◇") : (text + "◆"));
				text = ((!CheckedVaccine8) ? (text + "◇") : (text + "◆"));
				text = ((!CheckedVaccine9) ? (text + "◇") : (text + "◆"));
				text = ((!CheckedVaccine59) ? (text + "◇") : (text + "◆"));
				text = ((!CheckedVaccine10) ? (text + "◇") : (text + "◆"));
				text = ((!CheckedVaccine11) ? (text + "◇") : (text + "◆"));
				text = ((!CheckedVaccine49) ? (text + "◇") : (text + "◆"));
				text = ((!CheckedVaccine12) ? (text + "◇") : (text + "◆"));
				text = ((!CheckedVaccine13) ? (text + "◇") : (text + "◆"));
				text = ((!CheckedVaccine14) ? (text + "◇") : (text + "◆"));
				text = ((!CheckedVaccine15) ? (text + "◇") : (text + "◆"));
				text = ((!CheckedVaccine16) ? (text + "◇") : (text + "◆"));
				text = ((!CheckedVaccine17) ? (text + "◇") : (text + "◆"));
				text = ((!CheckedVaccine18) ? (text + "◇") : (text + "◆"));
				text = ((!CheckedVaccine19) ? (text + "◇") : (text + "◆"));
				text = ((!CheckedVaccine20) ? (text + "◇") : (text + "◆"));
				text = ((!CheckedVaccine21) ? (text + "◇") : (text + "◆"));
				text = ((!CheckedVaccine23) ? (text + "◇") : (text + "◆"));
				text = ((!CheckedVaccine24) ? (text + "◇") : (text + "◆"));
				text = ((!CheckedVaccine26) ? (text + "◇") : (text + "◆"));
				text = ((!CheckedVaccine27) ? (text + "◇") : (text + "◆"));
				text = ((!CheckedVaccine29) ? (text + "◇") : (text + "◆"));
				text = ((!CheckedVaccine34) ? (text + "◇") : (text + "◆"));
				text = ((!CheckedVaccine35) ? (text + "◇") : (text + "◆"));
				text = ((!CheckedVaccine40) ? (text + "◇") : (text + "◆"));
				text = ((!CheckedVaccine60) ? (text + "◇") : (text + "◆"));
				text = ((!CheckedVaccine41) ? (text + "◇") : (text + "◆"));
				text = ((!CheckedVaccine42) ? (text + "◇") : (text + "◆"));
				text = ((!CheckedVaccine43) ? (text + "◇") : (text + "◆"));
				text = ((!CheckedVaccine44) ? (text + "◇") : (text + "◆"));
				text = ((!CheckedVaccine45) ? (text + "◇") : (text + "◆"));
				text = ((!CheckedVaccine46) ? (text + "◇") : (text + "◆"));
				text = ((!CheckedVaccine47) ? (text + "◇") : (text + "◆"));
				text = ((!CheckedVaccine48) ? (text + "◇") : (text + "◆"));
				text = ((!CheckedVaccine50) ? (text + "◇") : (text + "◆"));
				text = ((!CheckedVaccine51) ? (text + "◇") : (text + "◆"));
				text = ((!CheckedVaccine52) ? (text + "◇") : (text + "◆"));
				text = ((!CheckedVaccine54) ? (text + "◇") : (text + "◆"));
				text = ((!CheckedVaccine55) ? (text + "◇") : (text + "◆"));
				text = ((!CheckedVaccine56) ? (text + "◇") : (text + "◆"));
				text = ((!CheckedVaccine57) ? (text + "◇") : (text + "◆"));
				text = ((!CheckedVaccine58) ? (text + "◇") : (text + "◆"));
				((FrameworkElement)PowerDeskApp2014.Instance).set_Cursor(Cursors.get_Arrow());
				text = text.Replace("◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇", "[◇x51] ");
				text = text.Replace("◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆", "[◆x51] ");
				text = text.Replace("◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇", "[◇x50] ");
				text = text.Replace("◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆", "[◆x50] ");
				text = text.Replace("◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇", "[◇x49] ");
				text = text.Replace("◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆", "[◆x49] ");
				text = text.Replace("◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇", "[◇x48] ");
				text = text.Replace("◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆", "[◆x48] ");
				text = text.Replace("◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇", "[◇x47] ");
				text = text.Replace("◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆", "[◆x47] ");
				text = text.Replace("◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇", "[◇x46] ");
				text = text.Replace("◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆", "[◆x46] ");
				text = text.Replace("◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇", "[◇x45] ");
				text = text.Replace("◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆", "[◆x45] ");
				text = text.Replace("◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇", "[◇x44] ");
				text = text.Replace("◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆", "[◆x44] ");
				text = text.Replace("◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇", "[◇x43] ");
				text = text.Replace("◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆", "[◆x43] ");
				text = text.Replace("◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇", "[◇x42] ");
				text = text.Replace("◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆", "[◆x42] ");
				text = text.Replace("◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇", "[◇x41] ");
				text = text.Replace("◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆", "[◆x41] ");
				text = text.Replace("◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇", "[◇x40] ");
				text = text.Replace("◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆", "[◆x40] ");
				text = text.Replace("◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇", "[◇x39] ");
				text = text.Replace("◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆", "[◆x39] ");
				text = text.Replace("◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇", "[◇x38] ");
				text = text.Replace("◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆", "[◆x38] ");
				text = text.Replace("◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇", "[◇x37] ");
				text = text.Replace("◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆", "[◆x37] ");
				text = text.Replace("◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇", "[◇x36] ");
				text = text.Replace("◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆", "[◆x36] ");
				text = text.Replace("◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇", "[◇x35] ");
				text = text.Replace("◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆", "[◆x35] ");
				text = text.Replace("◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇", "[◇x34] ");
				text = text.Replace("◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆", "[◆x34] ");
				text = text.Replace("◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇", "[◇x33] ");
				text = text.Replace("◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆", "[◆x33] ");
				text = text.Replace("◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇", "[◇x32] ");
				text = text.Replace("◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆", "[◆x32] ");
				text = text.Replace("◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇", "[◇x31] ");
				text = text.Replace("◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆", "[◆x31] ");
				text = text.Replace("◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇", "[◇x30] ");
				text = text.Replace("◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆", "[◆x30] ");
				text = text.Replace("◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇", "[◇x29] ");
				text = text.Replace("◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆", "[◆x29] ");
				text = text.Replace("◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇", "[◇x28] ");
				text = text.Replace("◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆", "[◆x28] ");
				text = text.Replace("◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇", "[◇x27] ");
				text = text.Replace("◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆", "[◆x27] ");
				text = text.Replace("◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇", "[◇x26] ");
				text = text.Replace("◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆", "[◆x26] ");
				text = text.Replace("◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇", "[◇x25]");
				text = text.Replace("◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆", "[◆x25]");
				text = text.Replace("◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇", "[◇x24]");
				text = text.Replace("◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆", "[◆x24]");
				text = text.Replace("◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇", "[◇x23]");
				text = text.Replace("◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆", "[◆x23]");
				text = text.Replace("◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇", "[◇x22]");
				text = text.Replace("◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆", "[◆x22]");
				text = text.Replace("◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇", "[◇x21]");
				text = text.Replace("◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆", "[◆x21]");
				text = text.Replace("◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇", "[◇x20]");
				text = text.Replace("◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆", "[◆x20]");
				text = text.Replace("◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇", "[◇x19]");
				text = text.Replace("◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆", "[◆x19]");
				text = text.Replace("◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇", "[◇x18]");
				text = text.Replace("◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆", "[◆x18]");
				text = text.Replace("◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇", "[◇x17]");
				text = text.Replace("◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆", "[◆x17]");
				text = text.Replace("◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇", "[◇x16]");
				text = text.Replace("◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆", "[◆x16]");
				text = text.Replace("◇◇◇◇◇◇◇◇◇◇◇◇◇◇◇", "[◇x15]");
				text = text.Replace("◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆", "[◆x15]");
				text = text.Replace("◇◇◇◇◇◇◇◇◇◇◇◇◇◇", "[◇x14]");
				text = text.Replace("◆◆◆◆◆◆◆◆◆◆◆◆◆◆", "[◆x14]");
				text = text.Replace("◇◇◇◇◇◇◇◇◇◇◇◇◇", "[◇x13]");
				text = text.Replace("◆◆◆◆◆◆◆◆◆◆◆◆◆", "[◆x13]");
				text = text.Replace("◇◇◇◇◇◇◇◇◇◇◇◇", "[◇x12]");
				text = text.Replace("◆◆◆◆◆◆◆◆◆◆◆◆", "[◆x12]");
				text = text.Replace("◇◇◇◇◇◇◇◇◇◇◇", "[◇x11]");
				text = text.Replace("◆◆◆◆◆◆◆◆◆◆◆", "[◆x11]");
				text = text.Replace("◇◇◇◇◇◇◇◇◇◇", "[◇x10]");
				text = text.Replace("◆◆◆◆◆◆◆◆◆◆", "[◆x10]");
				text = text.Replace("◇◇◇◇◇◇◇◇◇", "[◇x9]");
				text = text.Replace("◆◆◆◆◆◆◆◆◆", "[◆x9]");
				text = text.Replace("◇◇◇◇◇◇◇◇", "[◇x8]");
				text = text.Replace("◆◆◆◆◆◆◆◆", "[◆x8]");
				text = text.Replace("◇◇◇◇◇◇◇", "[◇x7]");
				text = text.Replace("◆◆◆◆◆◆◆", "[◆x7]");
				text = text.Replace("◇◇◇◇◇◇", "[◇x6]");
				text = text.Replace("◆◆◆◆◆◆", "[◆x6]");
				text = text.Replace("◇◇◇◇◇", "[◇x5]");
				text = text.Replace("◆◆◆◆◆", "[◆x5]");
				text = text.Replace("◇◇◇◇", "[◇x4]");
				text = text.Replace("◆◆◆◆", "[◆x4]");
				text = text.Replace("◆◆◆", "[◆x3]");
				text = text.Replace("◆◆◆", "[◆x3]");
				text = text.Replace("◆◆", "[◆x2]");
				text = text.Replace("◆◆", "[◆x2]");
			}
			return "백신 < " + text + ">";
		}
	}

	public static string AppRootPath
	{
		get
		{
			if (m_AppRootPath == "")
			{
				m_AppRootPath = Assembly.GetExecutingAssembly().Location.Remove(Assembly.GetExecutingAssembly().Location.LastIndexOf("\\"));
			}
			return m_AppRootPath;
		}
	}

	public string SavedGmailID
	{
		get
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(strKey, RegistryKeyPermissionCheck.ReadWriteSubTree);
			if (registryKey == null)
			{
				registryKey = Registry.CurrentUser.CreateSubKey(strKey);
			}
			string text = (string)registryKey.GetValue("SavedGmailID", "");
			if (text == "")
			{
				text = "";
				registryKey.SetValue("SavedGmailID", text);
			}
			return text;
		}
		set
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(strKey, RegistryKeyPermissionCheck.ReadWriteSubTree);
			if (registryKey == null)
			{
				registryKey = Registry.CurrentUser.CreateSubKey(strKey);
			}
			if (value != null)
			{
				registryKey.SetValue("SavedGmailID", value);
			}
		}
	}

	public string SavedMailPasswd
	{
		get
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(strKey, RegistryKeyPermissionCheck.ReadWriteSubTree);
			if (registryKey == null)
			{
				registryKey = Registry.CurrentUser.CreateSubKey(strKey);
			}
			string text = (string)registryKey.GetValue("SavedMailPasswd", "");
			if (text == "")
			{
				text = "";
				registryKey.SetValue("SavedMailPasswd", text);
			}
			return text;
		}
		set
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(strKey, RegistryKeyPermissionCheck.ReadWriteSubTree);
			if (registryKey == null)
			{
				registryKey = Registry.CurrentUser.CreateSubKey(strKey);
			}
			if (value != null)
			{
				registryKey.SetValue("SavedMailPasswd", value);
			}
		}
	}

	public string SavedReceiverMail
	{
		get
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(strKey, RegistryKeyPermissionCheck.ReadWriteSubTree);
			if (registryKey == null)
			{
				registryKey = Registry.CurrentUser.CreateSubKey(strKey);
			}
			string text = (string)registryKey.GetValue("SavedReceiverMail", "");
			if (text == "")
			{
				text = "";
				registryKey.SetValue("SavedReceiverMail", text);
			}
			return text;
		}
		set
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(strKey, RegistryKeyPermissionCheck.ReadWriteSubTree);
			if (registryKey == null)
			{
				registryKey = Registry.CurrentUser.CreateSubKey(strKey);
			}
			if (value != null)
			{
				registryKey.SetValue("SavedReceiverMail", value);
			}
		}
	}

	public bool Saved1
	{
		get
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(strKey);
			if (registryKey == null)
			{
				registryKey = Registry.CurrentUser.CreateSubKey(strKey);
			}
			return Convert.ToBoolean(registryKey.GetValue("Saved1", true));
		}
		set
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(strKey, RegistryKeyPermissionCheck.ReadWriteSubTree);
			if (registryKey == null)
			{
				registryKey = Registry.CurrentUser.CreateSubKey(strKey);
			}
			registryKey.SetValue("Saved1", value);
			NotifyPropertyChanged("Saved1");
		}
	}

	public bool Saved2
	{
		get
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(strKey);
			if (registryKey == null)
			{
				registryKey = Registry.CurrentUser.CreateSubKey(strKey);
			}
			return Convert.ToBoolean(registryKey.GetValue("Saved2", true));
		}
		set
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(strKey, RegistryKeyPermissionCheck.ReadWriteSubTree);
			if (registryKey == null)
			{
				registryKey = Registry.CurrentUser.CreateSubKey(strKey);
			}
			registryKey.SetValue("Saved2", value);
			NotifyPropertyChanged("Saved2");
		}
	}

	public bool Saved3
	{
		get
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(strKey);
			if (registryKey == null)
			{
				registryKey = Registry.CurrentUser.CreateSubKey(strKey);
			}
			return Convert.ToBoolean(registryKey.GetValue("Saved3", true));
		}
		set
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(strKey, RegistryKeyPermissionCheck.ReadWriteSubTree);
			if (registryKey == null)
			{
				registryKey = Registry.CurrentUser.CreateSubKey(strKey);
			}
			registryKey.SetValue("Saved3", value);
			NotifyPropertyChanged("Saved3");
		}
	}

	public static string DIR_PUBLIC_APP_CERTIFICATION_ENV_INI
	{
		get
		{
			if (mDIR_PUBLIC_APP_CERTIFICATION_ENV_INI == null)
			{
				mDIR_PUBLIC_APP_CERTIFICATION_ENV_INI = Instance.logPath + "aenv.ini";
			}
			return mDIR_PUBLIC_APP_CERTIFICATION_ENV_INI;
		}
	}

	public static string DIR_PUBLIC_APP_CERTIFICATION_APPROVAL_INI
	{
		get
		{
			if (mDIR_PUBLIC_APP_CERTIFICATION_APPROVAL_INI == null)
			{
				mDIR_PUBLIC_APP_CERTIFICATION_APPROVAL_INI = Instance.logPath + "approval.ini";
			}
			return mDIR_PUBLIC_APP_CERTIFICATION_APPROVAL_INI;
		}
	}

	public static string DIR_PUBLIC_APP_CERTIFICATION_APPOUTBLK_INI
	{
		get
		{
			if (mDIR_PUBLIC_APP_CERTIFICATION_APPOUTBLK_INI == null)
			{
				mDIR_PUBLIC_APP_CERTIFICATION_APPOUTBLK_INI = Instance.logPath + "appoutblk.ini";
			}
			return mDIR_PUBLIC_APP_CERTIFICATION_APPOUTBLK_INI;
		}
	}

	public string RegserveMsg
	{
		get
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(strKey);
			if (registryKey == null)
			{
				registryKey = Registry.CurrentUser.CreateSubKey(strKey);
			}
			string result = (string)registryKey.GetValue("RegserveMsg", "");
			registryKey.Close();
			registryKey.Dispose();
			return result;
		}
		set
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(strKey, RegistryKeyPermissionCheck.ReadWriteSubTree);
			if (registryKey == null)
			{
				registryKey = Registry.CurrentUser.CreateSubKey(strKey);
			}
			if (value != null)
			{
				registryKey.SetValue("RegserveMsg", value);
			}
			registryKey.Close();
			registryKey.Dispose();
		}
	}

	public bool EnableAntigen117 => CNativeWIN32.isWindows10;

	public bool CheckedVaccine117
	{
		get
		{
			return Utils.SolvedMicAvailabilityProblem();
		}
		set
		{
			if (value && CNativeWIN32.isWindows10)
			{
				Utils.DoSolveMicAvailability();
			}
		}
	}

	public bool EnableAntigen118 => CNativeWIN32.isWindows10;

	public bool EnableMnuPU33 => Utils.FileExists("c:\\windows\\system32\\winver.exe");

	public bool CheckedVaccine118
	{
		get
		{
			return Utils.SolvedCamAvailabilityProblem();
		}
		set
		{
			if (value && CNativeWIN32.isWindows10)
			{
				Utils.DoSolveCamAvailability();
			}
		}
	}

	public bool IsErrorWindowDefender
	{
		get
		{
			if (!mIsErrorWindowDefender.HasValue)
			{
				bool value = false;
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(strKey);
				if (registryKey == null)
				{
					registryKey = Registry.CurrentUser.CreateSubKey(strKey);
				}
				if (registryKey.GetValue("IsErrorWindowDefender", -1) as int? == 1)
				{
					value = true;
				}
				registryKey.Close();
				registryKey.Dispose();
				registryKey = null;
				mIsErrorWindowDefender = value;
			}
			return mIsErrorWindowDefender == true;
		}
		set
		{
			mIsErrorWindowDefender = null;
			if (value)
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(strKey, RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey == null)
				{
					registryKey = Registry.CurrentUser.CreateSubKey(strKey);
				}
				registryKey.SetValue("IsErrorWindowDefender", 1, RegistryValueKind.DWord);
				registryKey.Close();
				registryKey.Dispose();
				registryKey = null;
				mIsErrorWindowDefender = true;
			}
			else
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(strKey, RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey == null)
				{
					registryKey = Registry.CurrentUser.CreateSubKey(strKey);
				}
				registryKey.SetValue("IsErrorWindowDefender", 0);
				registryKey.Close();
				registryKey.Dispose();
				registryKey = null;
				mIsErrorWindowDefender = false;
			}
			NotifyPropertyChanged("IsErrorWindowDefender");
		}
	}

	public bool IsBlockMsTeams
	{
		get
		{
			if (!mIsBlockMsTeams.HasValue)
			{
				bool value = false;
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(strKey);
				if (registryKey == null)
				{
					registryKey = Registry.CurrentUser.CreateSubKey(strKey);
				}
				if (registryKey.GetValue("IsBlockMsTeams", -1) as int? == 1)
				{
					value = true;
				}
				registryKey.Close();
				registryKey.Dispose();
				registryKey = null;
				mIsBlockMsTeams = value;
			}
			return mIsBlockMsTeams == true;
		}
		set
		{
			mIsBlockMsTeams = null;
			if (value)
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(strKey, RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey == null)
				{
					registryKey = Registry.CurrentUser.CreateSubKey(strKey);
				}
				registryKey.SetValue("IsBlockMsTeams", 1, RegistryValueKind.DWord);
				registryKey.Close();
				registryKey.Dispose();
				registryKey = null;
				mIsBlockMsTeams = true;
			}
			else
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(strKey, RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey == null)
				{
					registryKey = Registry.CurrentUser.CreateSubKey(strKey);
				}
				registryKey.SetValue("IsBlockMsTeams", 0);
				registryKey.Close();
				registryKey.Dispose();
				registryKey = null;
				mIsBlockMsTeams = false;
			}
			NotifyPropertyChanged("IsBlockMsTeams");
		}
	}

	public bool IsBlockMsEdge
	{
		get
		{
			if (!mIsBlockMsEdge.HasValue)
			{
				bool value = false;
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(strKey);
				if (registryKey == null)
				{
					registryKey = Registry.CurrentUser.CreateSubKey(strKey);
				}
				if (registryKey.GetValue("IsBlockMsEdge", -1) as int? == 1)
				{
					value = true;
				}
				registryKey.Close();
				registryKey.Dispose();
				registryKey = null;
				mIsBlockMsEdge = value;
			}
			return mIsBlockMsEdge == true;
		}
		set
		{
			mIsBlockMsEdge = null;
			if (value)
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(strKey, RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey == null)
				{
					registryKey = Registry.CurrentUser.CreateSubKey(strKey);
				}
				registryKey.SetValue("IsBlockMsEdge", 1, RegistryValueKind.DWord);
				registryKey.Close();
				registryKey.Dispose();
				registryKey = null;
				mIsBlockMsEdge = true;
			}
			else
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(strKey, RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey == null)
				{
					registryKey = Registry.CurrentUser.CreateSubKey(strKey);
				}
				registryKey.SetValue("IsBlockMsEdge", 0);
				registryKey.Close();
				registryKey.Dispose();
				registryKey = null;
				mIsBlockMsEdge = false;
			}
			NotifyPropertyChanged("IsBlockMsEdge");
		}
	}

	public bool IsBlockWizvera
	{
		get
		{
			if (!mIsBlockWizvera.HasValue)
			{
				bool value = false;
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(strKey);
				if (registryKey == null)
				{
					registryKey = Registry.CurrentUser.CreateSubKey(strKey);
				}
				if (registryKey.GetValue("IsBlockWizvera", -1) as int? == 1)
				{
					value = true;
				}
				registryKey.Close();
				registryKey.Dispose();
				registryKey = null;
				mIsBlockWizvera = value;
			}
			return mIsBlockWizvera == true;
		}
		set
		{
			mIsBlockWizvera = null;
			if (value)
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(strKey, RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey == null)
				{
					registryKey = Registry.CurrentUser.CreateSubKey(strKey);
				}
				registryKey.SetValue("IsBlockWizvera", 1, RegistryValueKind.DWord);
				registryKey.Close();
				registryKey.Dispose();
				registryKey = null;
				mIsBlockWizvera = true;
			}
			else
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(strKey, RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey == null)
				{
					registryKey = Registry.CurrentUser.CreateSubKey(strKey);
				}
				registryKey.SetValue("IsBlockWizvera", 0);
				registryKey.Close();
				registryKey.Dispose();
				registryKey = null;
				mIsBlockWizvera = false;
			}
			NotifyPropertyChanged("IsBlockWizvera");
		}
	}

	public bool AppApprovalColor
	{
		get
		{
			return mAppApprovalColor;
		}
		set
		{
			if (mAppApprovalColor != value)
			{
				mAppApprovalColor = value;
				NotifyPropertyChanged("AppApprovalColor");
			}
		}
	}

	public SolidColorBrush IsBlockAppsColor
	{
		get
		{
			if (IsBlockApps)
			{
				return ResourcePackBrush("Green");
			}
			return ResourcePackBrush("OrangeRed");
		}
	}

	public bool IsBlockApps
	{
		get
		{
			return BoolPropertyGet(ref mIsBlockApps, "IsBlockApps", defaultValue: true);
		}
		set
		{
			BoolPropertySet(ref mIsBlockApps, "IsBlockApps", value);
			NotifyPropertyChanged("IsBlockApps");
			NotifyPropertyChanged("IsBlockAppsColor");
		}
	}

	public bool Resolve01Checked
	{
		get
		{
			return BoolPropertyGet(ref mResolve01Checked, "Resolve01Checked", defaultValue: false);
		}
		set
		{
			BoolPropertySet(ref mResolve01Checked, "Resolve01Checked", value);
			NotifyPropertyChanged("Resolve01Checked");
		}
	}

	public bool Resolve02Checked
	{
		get
		{
			return BoolPropertyGet(ref mResolve02Checked, "Resolve02Checked", defaultValue: false);
		}
		set
		{
			BoolPropertySet(ref mResolve02Checked, "Resolve02Checked", value);
			NotifyPropertyChanged("Resolve02Checked");
		}
	}

	public bool Resolve03Checked
	{
		get
		{
			return BoolPropertyGet(ref mResolve03Checked, "Resolve03Checked", defaultValue: false);
		}
		set
		{
			BoolPropertySet(ref mResolve03Checked, "Resolve03Checked", value);
			NotifyPropertyChanged("Resolve03Checked");
		}
	}

	public bool Resolve04Checked
	{
		get
		{
			return BoolPropertyGet(ref mResolve04Checked, "Resolve04Checked", defaultValue: false);
		}
		set
		{
			BoolPropertySet(ref mResolve04Checked, "Resolve04Checked", value);
			NotifyPropertyChanged("Resolve04Checked");
		}
	}

	public bool Resolve05Checked
	{
		get
		{
			return BoolPropertyGet(ref mResolve05Checked, "Resolve05Checked", defaultValue: false);
		}
		set
		{
			BoolPropertySet(ref mResolve05Checked, "Resolve05Checked", value);
			NotifyPropertyChanged("Resolve05Checked");
		}
	}

	public bool Resolve06Checked
	{
		get
		{
			return BoolPropertyGet(ref mResolve06Checked, "Resolve06Checked", defaultValue: false);
		}
		set
		{
			BoolPropertySet(ref mResolve06Checked, "Resolve06Checked", value);
			NotifyPropertyChanged("Resolve06Checked");
		}
	}

	public bool Resolve07Checked
	{
		get
		{
			return BoolPropertyGet(ref mResolve07Checked, "Resolve07Checked", defaultValue: false);
		}
		set
		{
			BoolPropertySet(ref mResolve07Checked, "Resolve07Checked", value);
			NotifyPropertyChanged("Resolve07Checked");
		}
	}

	public bool Resolve08Checked
	{
		get
		{
			return BoolPropertyGet(ref mResolve08Checked, "Resolve08Checked", defaultValue: false);
		}
		set
		{
			BoolPropertySet(ref mResolve08Checked, "Resolve08Checked", value);
			NotifyPropertyChanged("Resolve08Checked");
		}
	}

	public bool Resolve10Checked
	{
		get
		{
			return BoolPropertyGet(ref mResolve10Checked, "Resolve10Checked", defaultValue: false);
		}
		set
		{
			BoolPropertySet(ref mResolve10Checked, "Resolve10Checked", value);
			NotifyPropertyChanged("Resolve10Checked");
			NotifyPropertyChanged("Resolve10sEnabled");
		}
	}

	public string Resolve10s
	{
		get
		{
			return StringPropertyGet(ref mResolve10s, "Resolve10s");
		}
		set
		{
			StringPropertySet(ref mResolve10s, "Resolve10s", ref value);
			NotifyPropertyChanged("Resolve10s");
			NotifyPropertyChanged("Resolve10Enabled");
		}
	}

	public bool Resolve10Enabled
	{
		get
		{
			if (StringPropertyGet(ref mResolve10s, "Resolve10s").Length == 0 && !Resolve10Checked)
			{
				return false;
			}
			return true;
		}
		set
		{
		}
	}

	public bool Resolve10sEnabled
	{
		get
		{
			return !Resolve10Checked;
		}
		set
		{
		}
	}

	public bool Resolve20Checked
	{
		get
		{
			return BoolPropertyGet(ref mResolve20Checked, "Resolve20Checked", defaultValue: false);
		}
		set
		{
			BoolPropertySet(ref mResolve20Checked, "Resolve20Checked", value);
			NotifyPropertyChanged("Resolve20Checked");
			NotifyPropertyChanged("Resolve20sEnabled");
		}
	}

	public string Resolve20s
	{
		get
		{
			return StringPropertyGet(ref mResolve20s, "Resolve20s");
		}
		set
		{
			StringPropertySet(ref mResolve20s, "Resolve20s", ref value);
			NotifyPropertyChanged("Resolve20s");
			NotifyPropertyChanged("Resolve20Enabled");
		}
	}

	public bool Resolve20Enabled
	{
		get
		{
			if (StringPropertyGet(ref mResolve20s, "Resolve20s").Length == 0 && !Resolve20Checked)
			{
				return false;
			}
			return true;
		}
		set
		{
		}
	}

	public bool Resolve20sEnabled
	{
		get
		{
			return !Resolve20Checked;
		}
		set
		{
		}
	}

	public bool AutoW32TimeSynchChecked
	{
		get
		{
			return bAuth && BoolPropertyGet(ref mAutoW32TimeSynchChecked, "AutoW32TimeSynchChecked", defaultValue: false);
		}
		set
		{
			BoolPropertySet(ref mAutoW32TimeSynchChecked, "AutoW32TimeSynchChecked", value);
			NotifyPropertyChanged("AutoW32TimeSynchChecked");
		}
	}

	public int ProcessHWND
	{
		get
		{
			if (!mProcessHWND.HasValue)
			{
				RegistryKey registryKey = GetReadModeRegistryKeyFactory();
				if (registryKey == null)
				{
					registryKey = Registry.CurrentUser.CreateSubKey(strKey);
				}
				mProcessHWND = (int)registryKey.GetValue("ProcessHWND", -1);
			}
			return mProcessHWND.Value;
		}
		set
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(strKey, writable: true);
			if (registryKey == null)
			{
				registryKey = Registry.CurrentUser.CreateSubKey(strKey);
			}
			mProcessHWND = value;
			registryKey.SetValue("ProcessHWND", value);
		}
	}

	public bool IsJsonInstallerNoti
	{
		get
		{
			if (!mIsJsonInstallerNoti.HasValue)
			{
				bool value = false;
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(strKey);
				if (registryKey == null)
				{
					registryKey = Registry.CurrentUser.CreateSubKey(strKey);
				}
				if (registryKey.GetValue("IsJsonInstallerNoti", -1) as int? == 1)
				{
					value = true;
				}
				registryKey.Close();
				registryKey.Dispose();
				registryKey = null;
				mIsJsonInstallerNoti = value;
			}
			return mIsJsonInstallerNoti == true;
		}
		set
		{
			mIsJsonInstallerNoti = null;
			if (value)
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(strKey, RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey == null)
				{
					registryKey = Registry.CurrentUser.CreateSubKey(strKey);
				}
				registryKey.SetValue("IsJsonInstallerNoti", 1, RegistryValueKind.DWord);
				registryKey.Close();
				registryKey.Dispose();
				registryKey = null;
				mIsJsonInstallerNoti = true;
			}
			else
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(strKey, RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey == null)
				{
					registryKey = Registry.CurrentUser.CreateSubKey(strKey);
				}
				registryKey.SetValue("IsJsonInstallerNoti", 0);
				registryKey.Close();
				registryKey.Dispose();
				registryKey = null;
				mIsJsonInstallerNoti = false;
			}
			NotifyPropertyChanged("IsJsonInstallerNoti");
		}
	}

	public string CmdTitle
	{
		get
		{
			string text = "";
			if (App.IsAdministrator())
			{
				return "[관리자]cmd";
			}
			return "cmd";
		}
	}

	public string RecentTimeSynchDateTime
	{
		get
		{
			RegistryKey registryKey = GetReadModeRegistryKeyFactory();
			if (registryKey == null)
			{
				registryKey = Registry.CurrentUser.CreateSubKey(strKey);
			}
			string text = (string)registryKey.GetValue("RecentTimeSynchDateTime", "");
			if (text.Length == 0)
			{
				text = (RecentTimeSynchDateTime = DateTime.Now.AddDays(-14.0).ToString("yyyy-MM-dd HH:mm:ss"));
			}
			return text;
		}
		set
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(strKey, writable: true);
			if (registryKey == null)
			{
				registryKey = Registry.CurrentUser.CreateSubKey(strKey);
			}
			registryKey.SetValue("RecentTimeSynchDateTime", value);
			NotifyPropertyChanged("RecentTimeSynchDateTime");
		}
	}

	public bool AutoSaveMedicalReport
	{
		get
		{
			return BoolPropertyGet(ref mAutoSaveMedicalReport, "AutoSaveMedicalReport", defaultValue: true);
		}
		set
		{
			BoolPropertySet(ref mAutoSaveMedicalReport, "AutoSaveMedicalReport", value);
			NotifyPropertyChanged("AutoSaveMedicalReport");
			NotifyPropertyChanged("VisibilityMedicalReport");
		}
	}

	public Visibility VisibilityMedicalReport
	{
		get
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			if (!mAutoSaveMedicalReport.HasValue || mAutoSaveMedicalReport.Value)
			{
				return (Visibility)2;
			}
			return (Visibility)0;
		}
		set
		{
		}
	}

	public bool VaccAllUInewed
	{
		get
		{
			return BoolPropertyGet(ref mVaccAllUInewed, "VaccAllUInewed", defaultValue: true);
		}
		set
		{
			BoolPropertySet(ref mVaccAllUInewed, "VaccAllUInewed", value);
			NotifyPropertyChanged("VaccAllUInewed");
			NotifyPropertyChanged("StrVaccineAll");
		}
	}

	public int MetaHanjaTAvalue
	{
		get
		{
			int num = 0;
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\VB and VBA Program Settings\\VacaLevel Co.\\MetaHanja", RegistryKeyPermissionCheck.ReadWriteSubTree);
			if (registryKey == null)
			{
				registryKey = Registry.CurrentUser.CreateSubKey("Software\\VB and VBA Program Settings\\VacaLevel Co.\\MetaHanja", RegistryKeyPermissionCheck.ReadWriteSubTree);
			}
			return (int)registryKey.GetValue("TA", 0);
		}
		set
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\VB and VBA Program Settings\\VacaLevel Co.\\MetaHanja", RegistryKeyPermissionCheck.ReadWriteSubTree);
			if (registryKey == null)
			{
				registryKey = Registry.CurrentUser.CreateSubKey("Software\\VB and VBA Program Settings\\VacaLevel Co.\\MetaHanja");
			}
			registryKey.SetValue("TA", value);
		}
	}

	public string StrSecHealthUI_path
	{
		get
		{
			if (mStrSecHealthUI_path == null)
			{
				string text = null;
				text = (mStrSecHealthUI_path = ((!Utils.IsNotServerMachine()) ? Utils.GetSubFolderLikes("C:\\Windows\\SystemApps", "Microsoft.Windows.SecHealthUI", "SecHealthUI.exe") : Utils.GetSubFolderLikes("C:\\Program Files\\WindowsApps", "Microsoft.SecHealthUI", "SecHealthUI.exe")));
			}
			return mStrSecHealthUI_path;
		}
	}

	public Visibility IsPU34Visibility
	{
		get
		{
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			if (File.Exists(StrSecHealthUI_path))
			{
				return (Visibility)0;
			}
			return (Visibility)2;
		}
	}

	public bool EnableMnuPU34 => 0 < StrSecHealthUI_path.Length;

	public string StrHealthCheck
	{
		get
		{
			if (bAuth)
			{
				return "건강 진단";
			}
			return "진단(인증필요)";
		}
	}

	public string StrTimeSynchMenuName2Week
	{
		get
		{
			if (CheckedWndStarted && bAuth)
			{
				return "2주 마다 시간 동기화(자동)";
			}
			return "2주 이상 시간 동기화(수동)";
		}
	}

	public bool IsWin11RmbSolved
	{
		get
		{
			if (!mIsWin11RmbSolved.HasValue)
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Classes\\CLSID\\{86ca1aa0-34aa-4e8b-a509-50c905bae2a2}\\InprocServer32", RegistryKeyPermissionCheck.ReadSubTree);
				if (registryKey != null && "".Equals(registryKey.GetValue("", "-.-") as string, StringComparison.CurrentCultureIgnoreCase))
				{
					mIsWin11RmbSolved = true;
				}
				else
				{
					mIsWin11RmbSolved = false;
				}
			}
			return mIsWin11RmbSolved.Value;
		}
	}

	public bool IsWin11RmbNotSolved => !IsWin11RmbSolved;

	public Visibility Win11OKVisibility
	{
		get
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			if (-1 < Utils.GetOsName().IndexOf("Windows 11"))
			{
				return (Visibility)0;
			}
			return (Visibility)2;
		}
	}

	public bool IsCopyPathActive
	{
		get
		{
			if (!mIsCopyPathActive.HasValue)
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Classes\\Directory\\shell", RegistryKeyPermissionCheck.ReadWriteSubTree);
				RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Classes\\*\\shell", RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey.OpenSubKey("Copy as Path") == null || registryKey2.OpenSubKey("Copy as Path") == null)
				{
					mIsCopyPathActive = false;
				}
				else
				{
					mIsCopyPathActive = true;
				}
			}
			return mIsCopyPathActive.Value;
		}
		set
		{
			if (value)
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Classes\\Directory\\shell", RegistryKeyPermissionCheck.ReadWriteSubTree);
				RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Classes\\*\\shell", RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey.OpenSubKey("Copy as Path") == null)
				{
					RegistryKey registryKey3 = registryKey.CreateSubKey("Copy as Path", RegistryKeyPermissionCheck.ReadWriteSubTree);
					if (IsKoreaOS)
					{
						registryKey3.SetValue("", "경로 복사");
					}
					RegistryKey registryKey4 = registryKey3.CreateSubKey("Command", RegistryKeyPermissionCheck.ReadWriteSubTree);
					registryKey4.SetValue("", "cmd.exe /s /c mode con: cols=60 lines=1&(echo.|set /p=\"%w\") | clip");
				}
				if (registryKey2.OpenSubKey("Copy as Path") == null)
				{
					RegistryKey registryKey5 = registryKey2.CreateSubKey("Copy as Path", RegistryKeyPermissionCheck.ReadWriteSubTree);
					if (IsKoreaOS)
					{
						registryKey5.SetValue("", "경로 복사");
					}
					RegistryKey registryKey6 = registryKey5.CreateSubKey("Command", RegistryKeyPermissionCheck.ReadWriteSubTree);
					registryKey6.SetValue("", "cmd.exe /s /c mode con: cols=60 lines=1&(echo.|set /p=\"%1\") | clip");
				}
			}
			else
			{
				RegistryKey registryKey7 = Registry.ClassesRoot.OpenSubKey("AllFilesystemObjects\\shellex\\ContextMenuHandlers", RegistryKeyPermissionCheck.ReadWriteSubTree);
				RegistryKey registryKey8 = registryKey7.OpenSubKey("CopyAsPathMenu", RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey8 == null)
				{
					registryKey8 = registryKey7.CreateSubKey("CopyAsPathMenu", RegistryKeyPermissionCheck.ReadWriteSubTree);
				}
				registryKey8.SetValue("", "{f3d06e7c-1e45-4a26-847e-f9fcdee59be0}");
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Classes\\Directory\\shell", RegistryKeyPermissionCheck.ReadWriteSubTree);
				RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Classes\\*\\shell", RegistryKeyPermissionCheck.ReadWriteSubTree);
				registryKey.DeleteSubKeyTree("Copy as Path", throwOnMissingSubKey: false);
				registryKey2.DeleteSubKeyTree("Copy as Path", throwOnMissingSubKey: false);
			}
			mIsCopyPathActive = null;
			NotifyPropertyChanged("IsCopyPathActive");
		}
	}

	public bool IsCopyToFolderActive
	{
		get
		{
			if (!mIsCopyToFolderActive.HasValue)
			{
				RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey("AllFilesystemObjects\\shellex\\ContextMenuHandlers\\Copy to Folder", RegistryKeyPermissionCheck.ReadSubTree);
				if (registryKey == null || !"{C2FBB630-2971-11D1-A18C-00C04FD75D13}".Equals(registryKey.GetValue("", "") as string, StringComparison.CurrentCultureIgnoreCase))
				{
					mIsCopyToFolderActive = false;
				}
				else
				{
					mIsCopyToFolderActive = true;
				}
			}
			return mIsCopyToFolderActive.Value;
		}
		set
		{
			if (value)
			{
				RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey("AllFilesystemObjects\\shellex\\ContextMenuHandlers", RegistryKeyPermissionCheck.ReadWriteSubTree);
				RegistryKey registryKey2 = registryKey.OpenSubKey("Copy to Folder", RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey2 == null)
				{
					registryKey2 = registryKey.CreateSubKey("Copy to Folder", RegistryKeyPermissionCheck.ReadWriteSubTree);
				}
				registryKey2.SetValue("", "{C2FBB630-2971-11D1-A18C-00C04FD75D13}");
				mIsCopyToFolderActive = true;
			}
			else
			{
				RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey("AllFilesystemObjects\\shellex\\ContextMenuHandlers", RegistryKeyPermissionCheck.ReadWriteSubTree);
				registryKey.DeleteSubKeyTree("Copy to Folder");
				mIsCopyToFolderActive = false;
			}
			NotifyPropertyChanged("IsCopyToFolderActive");
		}
	}

	public bool IsMoveToFolderActive
	{
		get
		{
			if (!mIsMoveToFolderActive.HasValue)
			{
				RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey("AllFilesystemObjects\\shellex\\ContextMenuHandlers\\Move to Folder", RegistryKeyPermissionCheck.ReadSubTree);
				if (registryKey == null || !"{C2FBB631-2971-11D1-A18C-00C04FD75D13}".Equals(registryKey.GetValue("", "") as string, StringComparison.CurrentCultureIgnoreCase))
				{
					mIsMoveToFolderActive = false;
				}
				else
				{
					mIsMoveToFolderActive = true;
				}
			}
			return mIsMoveToFolderActive.Value;
		}
		set
		{
			if (value)
			{
				RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey("AllFilesystemObjects\\shellex\\ContextMenuHandlers", RegistryKeyPermissionCheck.ReadWriteSubTree);
				RegistryKey registryKey2 = registryKey.OpenSubKey("Move to Folder", RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey2 == null)
				{
					registryKey2 = registryKey.CreateSubKey("Move to Folder", RegistryKeyPermissionCheck.ReadWriteSubTree);
				}
				registryKey2.SetValue("", "{C2FBB631-2971-11D1-A18C-00C04FD75D13}");
				mIsMoveToFolderActive = true;
			}
			else
			{
				RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey("AllFilesystemObjects\\shellex\\ContextMenuHandlers", RegistryKeyPermissionCheck.ReadWriteSubTree);
				registryKey.DeleteSubKeyTree("Move to Folder");
				mIsMoveToFolderActive = false;
			}
			NotifyPropertyChanged("IsMoveToFolderActive");
		}
	}

	public bool IsEndReDiagnosis
	{
		get
		{
			return BoolPropertyGet(ref mIsEndReDiagnosis, "IsEndReDiagnosis", defaultValue: false);
		}
		set
		{
			BoolPropertySet(ref mIsEndReDiagnosis, "IsEndReDiagnosis", value);
			NotifyPropertyChanged("IsEndReDiagnosis");
		}
	}

	public bool IsBeforeVersionRecoverNotUse
	{
		get
		{
			RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey("AllFilesystemObjects\\shellex\\ContextMenuHandlers", RegistryKeyPermissionCheck.ReadWriteSubTree);
			RegistryKey registryKey2 = Registry.ClassesRoot.OpenSubKey("CLSID\\{450D8FBA-AD25-11D0-98A8-0800361B1103}\\shellex\\ContextMenuHandlers", RegistryKeyPermissionCheck.ReadWriteSubTree);
			RegistryKey registryKey3 = Registry.ClassesRoot.OpenSubKey("Directory\\shellex\\ContextMenuHandlers", RegistryKeyPermissionCheck.ReadWriteSubTree);
			RegistryKey registryKey4 = Registry.ClassesRoot.OpenSubKey("Drive\\shellex\\ContextMenuHandlers", RegistryKeyPermissionCheck.ReadWriteSubTree);
			if (registryKey.OpenSubKey("{596AB062-B4D2-4215-9F74-E9109B0A8153}") != null && registryKey2.OpenSubKey("{596AB062-B4D2-4215-9F74-E9109B0A8153}") != null && registryKey3.OpenSubKey("{596AB062-B4D2-4215-9F74-E9109B0A8153}") != null && registryKey4.OpenSubKey("{596AB062-B4D2-4215-9F74-E9109B0A8153}") != null)
			{
				return false;
			}
			return true;
		}
		set
		{
			RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey("AllFilesystemObjects\\shellex\\ContextMenuHandlers", RegistryKeyPermissionCheck.ReadWriteSubTree);
			RegistryKey registryKey2 = Registry.ClassesRoot.OpenSubKey("CLSID\\{450D8FBA-AD25-11D0-98A8-0800361B1103}\\shellex\\ContextMenuHandlers", RegistryKeyPermissionCheck.ReadWriteSubTree);
			RegistryKey registryKey3 = Registry.ClassesRoot.OpenSubKey("Directory\\shellex\\ContextMenuHandlers", RegistryKeyPermissionCheck.ReadWriteSubTree);
			RegistryKey registryKey4 = Registry.ClassesRoot.OpenSubKey("Drive\\shellex\\ContextMenuHandlers", RegistryKeyPermissionCheck.ReadWriteSubTree);
			if (!value)
			{
				registryKey.CreateSubKey("{596AB062-B4D2-4215-9F74-E9109B0A8153}", RegistryKeyPermissionCheck.ReadWriteSubTree);
				registryKey2.CreateSubKey("{596AB062-B4D2-4215-9F74-E9109B0A8153}", RegistryKeyPermissionCheck.ReadWriteSubTree);
				registryKey3.CreateSubKey("{596AB062-B4D2-4215-9F74-E9109B0A8153}", RegistryKeyPermissionCheck.ReadWriteSubTree);
				registryKey4.CreateSubKey("{596AB062-B4D2-4215-9F74-E9109B0A8153}", RegistryKeyPermissionCheck.ReadWriteSubTree);
				registryKey.DeleteSubKey("-{596AB062-B4D2-4215-9F74-E9109B0A8153}", throwOnMissingSubKey: false);
				registryKey2.DeleteSubKey("-{596AB062-B4D2-4215-9F74-E9109B0A8153}", throwOnMissingSubKey: false);
				registryKey3.DeleteSubKey("-{596AB062-B4D2-4215-9F74-E9109B0A8153}", throwOnMissingSubKey: false);
				registryKey4.DeleteSubKey("-{596AB062-B4D2-4215-9F74-E9109B0A8153}", throwOnMissingSubKey: false);
			}
			else
			{
				registryKey.CreateSubKey("-{596AB062-B4D2-4215-9F74-E9109B0A8153}", RegistryKeyPermissionCheck.ReadWriteSubTree);
				registryKey2.CreateSubKey("-{596AB062-B4D2-4215-9F74-E9109B0A8153}", RegistryKeyPermissionCheck.ReadWriteSubTree);
				registryKey3.CreateSubKey("-{596AB062-B4D2-4215-9F74-E9109B0A8153}", RegistryKeyPermissionCheck.ReadWriteSubTree);
				registryKey4.CreateSubKey("-{596AB062-B4D2-4215-9F74-E9109B0A8153}", RegistryKeyPermissionCheck.ReadWriteSubTree);
				registryKey.DeleteSubKey("{596AB062-B4D2-4215-9F74-E9109B0A8153}", throwOnMissingSubKey: false);
				registryKey2.DeleteSubKey("{596AB062-B4D2-4215-9F74-E9109B0A8153}", throwOnMissingSubKey: false);
				registryKey3.DeleteSubKey("{596AB062-B4D2-4215-9F74-E9109B0A8153}", throwOnMissingSubKey: false);
				registryKey4.DeleteSubKey("{596AB062-B4D2-4215-9F74-E9109B0A8153}", throwOnMissingSubKey: false);
			}
			NotifyPropertyChanged("IsBeforeVersionRecoverNotUse");
		}
	}

	public bool IsKoreaOS
	{
		get
		{
			if (!mIsKoreaOS.HasValue)
			{
				mIsKoreaOS = -1 < Utils.ExecuteCommandSync("wmic os get CountryCode").IndexOf("82");
			}
			return mIsKoreaOS.Value;
		}
	}

	public Visibility IsKoreaOSVisibility
	{
		get
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			if (IsKoreaOS)
			{
				return (Visibility)0;
			}
			return (Visibility)2;
		}
	}

	public Visibility IsExistsMsraVisibility
	{
		get
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			string text = null;
			text = Environment.GetFolderPath(Environment.SpecialFolder.SystemX86) + Utils.SEPA + "msra.exe";
			if (Utils.FileExists(text))
			{
				return (Visibility)2;
			}
			return (Visibility)0;
		}
	}

	public event PropertyChangedEventHandler PropertyChanged;

	[DllImport("Kernel32", CharSet = CharSet.Auto)]
	private static extern bool GetComputerName(StringBuilder buffer, ref uint size);

	public static SolidColorBrush ResourcePackBrush(string colorcode)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		SolidColorBrush val = null;
		if (ResourcePackBrushes == null)
		{
			ResourcePackBrushes = new Dictionary<string, SolidColorBrush>();
		}
		if (ResourcePackBrushes.ContainsKey(colorcode))
		{
			val = ResourcePackBrushes[colorcode];
		}
		else
		{
			if (mBrushConverter == null)
			{
				mBrushConverter = new BrushConverter();
			}
			object? obj = ((TypeConverter)(object)mBrushConverter).ConvertFromString(colorcode);
			val = (SolidColorBrush)((obj is SolidColorBrush) ? obj : null);
			ResourcePackBrushes.Add(colorcode, val);
		}
		return val;
	}

	public void NotifyPropertyChanged(string info)
	{
		if (this.PropertyChanged != null && (!(info == "StrVaccineAll") || iDoApplyAll != 2))
		{
			if (1 < iDoApplyAll)
			{
				iDoApplyAll--;
			}
			this.PropertyChanged(this, new PropertyChangedEventArgs(info));
		}
	}

	public RegiHelperSrc()
	{
		Instance = this;
		OemProductTitle = "PowerHealthChecker";
	}

	private static RegistryKey GetReadModeRegistryKeyFactory()
	{
		return Registry.CurrentUser.OpenSubKey(strKey);
	}

	public static bool IsBootMenuStandard()
	{
		bool flag = true;
		string bCDEdit = Utils.getBCDEdit();
		MatchCollection matchCollection = null;
		matchCollection = Regex.Matches(bCDEdit, "bootmenupolicy\\s+Standard", RegexOptions.IgnoreCase | RegexOptions.Multiline);
		if (0 < matchCollection.Count)
		{
			return true;
		}
		return false;
	}

	public bool deleteRunOnce()
	{
		bool result = false;
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("Software\\Microsoft\\Windows\\CurrentVersion\\RunOnce"), RegistryKeyPermissionCheck.ReadWriteSubTree);
		if (registryKey != null)
		{
			string[] valueNames = registryKey.GetValueNames();
			for (int i = 0; i < valueNames.Length; i++)
			{
				dictionary.Add(valueNames[i], registryKey.GetValue(valueNames[i])!.ToString());
				registryKey.DeleteValue(valueNames[i]);
			}
			registryKey.Close();
		}
		int num = 0;
		if (0 < dictionary.Count)
		{
			for (int i = 0; i < dictionary.Count; i++)
			{
				if (i == 0)
				{
					result = true;
					registryKey = Registry.CurrentUser.OpenSubKey(strKey, RegistryKeyPermissionCheck.ReadWriteSubTree);
					if (registryKey == null)
					{
						registryKey = Registry.CurrentUser.CreateSubKey(strKey);
					}
					RegistryKey registryKey2 = registryKey.OpenSubKey("RunOnce");
					if (registryKey2 != null)
					{
						registryKey2 = registryKey.CreateSubKey("RunOnce");
					}
					string[] valueNames = registryKey2.GetValueNames();
					for (int j = 0; j < valueNames.Count(); j++)
					{
						registryKey2.DeleteValue(valueNames[j]);
					}
					if (dictionary.ContainsKey(valueNames[i]))
					{
						registryKey2.SetValue(valueNames[i] + "_" + ++num, dictionary[valueNames[i]]);
					}
				}
			}
		}
		registryKey = Registry.CurrentUser.OpenSubKey(Utils.SepaString("Software\\Microsoft\\Windows\\CurrentVersion\\RunOnce"), RegistryKeyPermissionCheck.ReadWriteSubTree);
		if (registryKey != null)
		{
			string[] valueNames = registryKey.GetValueNames();
			for (int i = 0; i < valueNames.Length; i++)
			{
				dictionary.Add(valueNames[i], registryKey.GetValue(valueNames[i])!.ToString());
				registryKey.DeleteValue(valueNames[i]);
			}
			registryKey.Close();
		}
		if (0 < dictionary.Count)
		{
			for (int i = 0; i < dictionary.Count; i++)
			{
				if (i == 0)
				{
					result = true;
					registryKey = Registry.CurrentUser.OpenSubKey(strKey, RegistryKeyPermissionCheck.ReadWriteSubTree);
					if (registryKey == null)
					{
						registryKey = Registry.CurrentUser.CreateSubKey(strKey);
					}
					RegistryKey registryKey2 = registryKey.OpenSubKey("RunOnce");
					if (registryKey2 != null)
					{
						registryKey2 = registryKey.CreateSubKey("RunOnce");
					}
					string[] valueNames = registryKey2.GetValueNames();
					for (int j = 0; j < valueNames.Count(); j++)
					{
						registryKey2.DeleteValue(valueNames[j]);
					}
					if (dictionary.ContainsKey(valueNames[i]))
					{
						registryKey2.SetValue(valueNames[i] + "_" + ++num, dictionary[valueNames[i]]);
					}
				}
			}
		}
		return result;
	}

	public void deleteRunOnceMy()
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(strKey, RegistryKeyPermissionCheck.ReadWriteSubTree);
		if (registryKey == null)
		{
			return;
		}
		RegistryKey registryKey2 = registryKey.OpenSubKey("RunOnce");
		if (registryKey2 == null)
		{
			return;
		}
		string[] valueNames = registryKey2.GetValueNames();
		for (int i = 0; i < valueNames.Length; i++)
		{
			string text = registryKey2.GetValue(valueNames[i], "") as string;
			if (Utils.question("[" + valueNames[i] + "]" + Environment.NewLine + text + Environment.NewLine + "를 한번 실행하시겠습니까?[RunOnce]"))
			{
				ProcessStartInfo processStartInfo = new ProcessStartInfo(text);
				processStartInfo.UseShellExecute = true;
				Process.Start(processStartInfo);
			}
		}
		registryKey2.Close();
		registryKey.DeleteSubKeyTree("RunOnce");
	}

	private static void CreateOfficeClickToRunService()
	{
		if (!bCreateOfficeClickToRunService && ((UIElement)Application.get_Current().get_MainWindow()).get_IsVisible())
		{
			string text = "C:\\Program Files\\Common Files\\Microsoft Shared\\ClickToRun\\OfficeClickToRun.exe";
			if (File.Exists(text) && Utils.question("ClickToRunSvc 서비스를 등록하여 Office실행 오류를 개선하시겠습니까?"))
			{
				Utils.ExecuteCommandSync(Environment.GetEnvironmentVariable("windir") + Utils.SEPA + "system32\\sc create \"ClickToRunSvc\" binPath= \"\"" + text + "\" /service\" DisplayName= \"Microsoft Office Click To Run Service\" start= demand");
			}
			bCreateOfficeClickToRunService = true;
		}
	}

	internal static int GerFirewallRuleResult(string sName, string sDir, string sProtocol, string sPort)
	{
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		bool flag4 = false;
		int num = 0;
		string text = Utils.ExecuteCommandSync("netsh advfirewall firewall show rule name=\"" + sName + "\" dir=" + sDir);
		string[] array = text.Replace("\n", "\r").Replace("\r\r", "\r").Split(new char[1] { '\r' });
		for (int i = 1; i < array.Count(); i++)
		{
			if (num == 0 && -1 < array[i].IndexOf(sName))
			{
				num++;
				continue;
			}
			if (num == 0)
			{
				break;
			}
			if (!flag && Regex.IsMatch(array[i], "Protocol:\\s+" + sProtocol + "$"))
			{
				num++;
				flag = true;
			}
			else if (!flag2 && Regex.IsMatch(array[i], "LocalPort:\\s+" + sPort + "$"))
			{
				num++;
				flag2 = true;
			}
			else if (!flag3 && Regex.IsMatch(array[i], "사용:\\s+예$"))
			{
				num++;
				flag3 = true;
			}
			else if (!flag4 && Regex.IsMatch(array[i], "작업:\\s+차단$"))
			{
				num++;
				flag4 = true;
			}
			else if (!flag3 && Regex.IsMatch(array[i], "Enabled:\\s+Yes$"))
			{
				num++;
				flag3 = true;
			}
			else if (!flag4 && Regex.IsMatch(array[i], "Action:\\s+Block$"))
			{
				num++;
				flag4 = true;
			}
		}
		return num;
	}

	private static string GetMaxLatestDfrg()
	{
		string text = Utils.GetWMIOSInstallDate().Replace("\\-", "");
		string text2 = App.iniFile.ReadValue("CheckedVacc36");
		if (text != "" && text.CompareTo(text2) > 0)
		{
			text2 = text;
		}
		string dfrgDateTime = Utils.GetDfrgDateTime();
		if (dfrgDateTime != "" && dfrgDateTime.CompareTo(text2) > 0)
		{
			text2 = dfrgDateTime;
		}
		return text2;
	}

	private static void SetServiceDisabled(string serviceName, int start = 4)
	{
		if (-1 < serviceName.IndexOf(" "))
		{
			serviceName = "\"" + serviceName + "\"";
		}
		switch (start)
		{
		case 4:
			Utils.ExecuteCommandSync(Environment.GetEnvironmentVariable("windir") + Utils.SEPA + "system32\\sc stop " + serviceName);
			Utils.ExecuteCommandSync(Environment.GetEnvironmentVariable("windir") + Utils.SEPA + "system32\\sc config " + serviceName + " start= disabled");
			break;
		case 3:
			Utils.ExecuteCommandSync(Environment.GetEnvironmentVariable("windir") + Utils.SEPA + "system32\\sc stop " + serviceName);
			Utils.ExecuteCommandSync(Environment.GetEnvironmentVariable("windir") + Utils.SEPA + "system32\\sc config " + serviceName + " start= demand");
			break;
		case 2:
			Utils.ExecuteCommandSync(Environment.GetEnvironmentVariable("windir") + Utils.SEPA + "system32\\sc stop " + serviceName);
			Utils.ExecuteCommandSync(Environment.GetEnvironmentVariable("windir") + Utils.SEPA + "system32\\sc config " + serviceName + " start= auto");
			break;
		}
	}

	public static void SetServiceRemove(string serviceName)
	{
		if (-1 < serviceName.IndexOf(" "))
		{
			serviceName = "\"" + serviceName + "\"";
		}
		Utils.ExecuteCommandSync(Environment.GetEnvironmentVariable("windir") + Utils.SEPA + "system32\\sc delete " + serviceName);
	}

	private void FirewallApplyBlock(string fileName, bool secure)
	{
		RegistryKey registryKey;
		string[] valueNames;
		if (secure)
		{
			registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\services\\SharedAccess\\Parameters\\FirewallPolicy\\FirewallRules"), RegistryKeyPermissionCheck.ReadWriteSubTree);
			if (registryKey == null)
			{
				return;
			}
			valueNames = registryKey.GetValueNames();
			for (int i = 0; i < valueNames.Count(); i++)
			{
				string text = registryKey.GetValue(valueNames[i])!.ToString();
				if (-1 < text.IndexOf(fileName, StringComparison.CurrentCultureIgnoreCase) && -1 < text.IndexOf("Action=Allow", StringComparison.CurrentCultureIgnoreCase))
				{
					text = text.Replace("Action=Allow", "Action=Block");
					registryKey.SetValue(valueNames[i], text);
				}
			}
			return;
		}
		registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\services\\SharedAccess\\Parameters\\FirewallPolicy\\FirewallRules"), RegistryKeyPermissionCheck.ReadWriteSubTree);
		if (registryKey == null)
		{
			return;
		}
		valueNames = registryKey.GetValueNames();
		for (int i = 0; i < valueNames.Count(); i++)
		{
			string text = registryKey.GetValue(valueNames[i])!.ToString();
			if (-1 < text.IndexOf(fileName, StringComparison.CurrentCultureIgnoreCase) && -1 < text.IndexOf("Action=Block", StringComparison.CurrentCultureIgnoreCase))
			{
				text = text.Replace("Action=Block", "Action=Allow");
				registryKey.SetValue(valueNames[i], text);
			}
		}
	}

	private void FirewallApplyAllow(string fileName, bool secure)
	{
		RegistryKey registryKey;
		string[] valueNames;
		if (secure)
		{
			registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\services\\SharedAccess\\Parameters\\FirewallPolicy\\FirewallRules"), RegistryKeyPermissionCheck.ReadWriteSubTree);
			if (registryKey == null)
			{
				return;
			}
			valueNames = registryKey.GetValueNames();
			for (int i = 0; i < valueNames.Count(); i++)
			{
				string text = registryKey.GetValue(valueNames[i])!.ToString();
				if (-1 < text.IndexOf(fileName, StringComparison.CurrentCultureIgnoreCase) && -1 < text.IndexOf("Action=Block", StringComparison.CurrentCultureIgnoreCase))
				{
					text = text.Replace("Action=Block", "Action=Allow");
					registryKey.SetValue(valueNames[i], text);
				}
			}
			return;
		}
		registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\services\\SharedAccess\\Parameters\\FirewallPolicy\\FirewallRules"), RegistryKeyPermissionCheck.ReadWriteSubTree);
		if (registryKey == null)
		{
			return;
		}
		valueNames = registryKey.GetValueNames();
		for (int i = 0; i < valueNames.Count(); i++)
		{
			string text = registryKey.GetValue(valueNames[i])!.ToString();
			if (-1 < text.IndexOf(fileName, StringComparison.CurrentCultureIgnoreCase) && -1 < text.IndexOf("Action=Allow", StringComparison.CurrentCultureIgnoreCase))
			{
				text = text.Replace("Action=Allow", "Action=Block");
				registryKey.SetValue(valueNames[i], text);
			}
		}
	}

	private static void do_computername()
	{
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string systemDirectory = Environment.SystemDirectory;
			string path = "SystemPropertiesComputerName.exe";
			string text = Path.Combine(systemDirectory, path);
			if (Environment.Is64BitOperatingSystem)
			{
				if (File.Exists(text))
				{
					IntPtr ptr = default(IntPtr);
					CNativeWIN32.Wow64DisableWow64FsRedirection(ref ptr);
					CNativeWIN32.ShellExecute(0, "open", text, null, null, 1);
					CNativeWIN32.Wow64RevertWow64FsRedirection(ptr);
				}
			}
			else
			{
				CNativeWIN32.ShellExecute(0, "open", text, null, null, 1);
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message + ex.StackTrace);
		}
	}

	private static void MakeNewTask(TaskService ts)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		try
		{
			TaskDefinition val = ts.NewTask();
			val.get_RegistrationInfo().set_Description("Health Check");
			LogonTrigger val2 = new LogonTrigger();
			val2.set_Delay(new TimeSpan(0, 60, 0));
			val.get_Triggers().Add((Trigger)(object)val2);
			string text = Path.Combine(AppRootPath, Instance.OemProductTitle + ".exe");
			val.get_Actions().Add((Action)new ExecAction("\"" + text + "\"", "bg", AppRootPath));
			val.get_Principal().set_RunLevel((TaskRunLevel)1);
			val.get_Settings().get_IdleSettings().set_IdleDuration(new TimeSpan(0, 10, 0));
			val.get_Settings().get_IdleSettings().set_WaitTimeout(TimeSpan.FromDays(365.0));
			val.get_Settings().get_IdleSettings().set_RestartOnIdle(false);
			val.get_Settings().get_IdleSettings().set_StopOnIdleEnd(false);
			val.get_Settings().set_StopIfGoingOnBatteries(false);
			val.get_Settings().set_RunOnlyIfIdle(true);
			ts.get_RootFolder().RegisterTaskDefinition("PowerHealthCheck", val);
		}
		catch (Exception)
		{
		}
	}

	private static void MakeNewTask2(TaskService ts)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		try
		{
			TaskDefinition val = ts.NewTask();
			val.get_RegistrationInfo().set_Description("Health Net Check");
			LogonTrigger val2 = new LogonTrigger();
			val2.set_Delay(new TimeSpan(0, 0, 30));
			val.get_Triggers().Add((Trigger)(object)val2);
			string text = App.iniFile.ReadValueDefault("InitVolume", "-2");
			string text2 = Path.Combine(AppRootPath, Instance.OemProductTitle + ".exe");
			val.get_Actions().Add((Action)new ExecAction("\"" + text2 + "\"", "/vshare:true /volume:" + text, AppRootPath));
			val.get_Principal().set_RunLevel((TaskRunLevel)1);
			val.get_Settings().set_DisallowStartIfOnBatteries(false);
			ts.get_RootFolder().RegisterTaskDefinition("PowerHealthNet", val);
		}
		catch (Exception)
		{
		}
	}

	internal void WriteValue_Reg(string section, string key, string value)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(strKeyApproval + "\\" + section, RegistryKeyPermissionCheck.ReadWriteSubTree);
			if (registryKey == null)
			{
				registryKey = Registry.CurrentUser.CreateSubKey(strKeyApproval + "\\" + section);
			}
			registryKey.SetValue(key, value, RegistryValueKind.String);
		}
		catch (ArgumentException ex)
		{
			Console.Error.WriteLine(ex.Message);
		}
	}

	internal string ReadValue_Reg(string section, string key, string default_value = "")
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(strKeyApproval + "\\" + section, RegistryKeyPermissionCheck.ReadWriteSubTree);
		if (registryKey == null)
		{
			registryKey = Registry.CurrentUser.CreateSubKey(strKeyApproval + "\\" + section);
		}
		return registryKey.GetValue(key, default_value) as string;
	}

	internal string[] ReadAllSection_Reg()
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(strKeyApproval);
		if (registryKey == null)
		{
			registryKey = Registry.CurrentUser.CreateSubKey(strKeyApproval);
		}
		return registryKey.GetSubKeyNames();
	}

	internal void RemoveSection_Reg(string section)
	{
		Registry.CurrentUser.OpenSubKey(strKeyApproval, RegistryKeyPermissionCheck.ReadWriteSubTree)?.DeleteSubKey(section, throwOnMissingSubKey: false);
	}

	internal string ApprovalYN_Reg(string p)
	{
		string result = "";
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(strKeyApproval, RegistryKeyPermissionCheck.ReadWriteSubTree);
		if (registryKey != null)
		{
			RegistryKey registryKey2 = registryKey.OpenSubKey(p, writable: false);
			result = registryKey2.GetValue("YN") as string;
		}
		return result;
	}

	internal bool isMsSpellCheckUse()
	{
		bool result = false;
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Utils.SepaString("Software\\Microsoft\\Internet Explorer\\Main"), writable: false);
		if (registryKey != null)
		{
			object value = registryKey.GetValue("SpellChecking");
			if (value != null)
			{
				result = Convert.ToInt32(value) == 1;
			}
		}
		return result;
	}

	internal void setMsSpellCheckUse(int p)
	{
		Registry.CurrentUser.OpenSubKey(Utils.SepaString("Software\\Microsoft\\Internet Explorer\\Main"), RegistryKeyPermissionCheck.ReadWriteSubTree)?.SetValue("SpellChecking", p);
	}

	public static bool FindFireWallAllow(string onlyFileName)
	{
		bool result = false;
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\services\\SharedAccess\\Parameters\\FirewallPolicy\\FirewallRules"));
		if (registryKey != null)
		{
			string[] valueNames = registryKey.GetValueNames();
			for (int i = 0; i < valueNames.Count(); i++)
			{
				string text = registryKey.GetValue(valueNames[i])!.ToString();
				if (-1 < text.IndexOf(onlyFileName, StringComparison.CurrentCultureIgnoreCase) && -1 < text.IndexOf("Action=Allow", StringComparison.CurrentCultureIgnoreCase))
				{
					result = true;
					break;
				}
			}
		}
		return result;
	}

	public static bool FindFireWallBlock(string onlyFileName)
	{
		bool result = false;
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\services\\SharedAccess\\Parameters\\FirewallPolicy\\FirewallRules"));
		if (registryKey != null)
		{
			string[] valueNames = registryKey.GetValueNames();
			for (int i = 0; i < valueNames.Count(); i++)
			{
				string text = registryKey.GetValue(valueNames[i])!.ToString();
				if (-1 < text.IndexOf(onlyFileName, StringComparison.CurrentCultureIgnoreCase) && -1 < text.IndexOf("Action=Block", StringComparison.CurrentCultureIgnoreCase))
				{
					result = true;
					break;
				}
			}
		}
		return result;
	}

	public static void removeHarmFul()
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Utils.SepaString("Software\\Microsoft\\Windows NT\\CurrentVersion\\Windows"), RegistryKeyPermissionCheck.ReadWriteSubTree);
		if (registryKey != null && registryKey.GetValue("Load") is string text)
		{
			if (-1 < text.IndexOf(":"))
			{
				string text2 = text;
				MatchCollection matchCollection = PowerDeskApp2014.regexp_file.Matches(text2);
				if (0 < matchCollection.Count)
				{
					text2 = matchCollection[0].Groups[matchCollection[0].Groups.Count - 1].ToString().ToLower();
				}
				FileInfo fileInfo = new FileInfo(text2);
				if ((fileInfo.Extension.ToLower() == ".cmd" || fileInfo.Extension.ToLower() == ".bat") && App.deleteHarmFile(text2))
				{
					registryKey.SetValue("Load", "");
				}
			}
			if (-1 < text.IndexOf(".pif", StringComparison.OrdinalIgnoreCase))
			{
				registryKey.SetValue("Load", "");
			}
		}
		registryKey = Registry.CurrentUser.OpenSubKey(Utils.SepaString("Software\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon"), RegistryKeyPermissionCheck.ReadWriteSubTree);
		if (registryKey != null && registryKey.GetValue("Shell") is string)
		{
			registryKey.DeleteValue("Shell");
		}
	}

	public void Del_DisableTaskmgr()
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Utils.SepaString("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System"), RegistryKeyPermissionCheck.ReadWriteSubTree);
		if (registryKey != null)
		{
			if (1 == (int)registryKey.GetValue("DisableTaskmgr", -1))
			{
				registryKey.DeleteValue("DisableTaskmgr");
			}
			if (1 == (int)registryKey.GetValue("DisableCMD", -1))
			{
				registryKey.DeleteValue("DisableCMD");
			}
			if (1 == (int)registryKey.GetValue("DisableRegistryTools", -1))
			{
				registryKey.DeleteValue("DisableRegistryTools");
			}
		}
	}

	public bool IfSpooler4to3()
	{
		bool result = true;
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\services\\Spooler"), RegistryKeyPermissionCheck.ReadWriteSubTree);
		if (registryKey != null)
		{
			int num = (int)registryKey.GetValue("Start", -1);
			if (4 == num)
			{
				if (Utils.question("프린터 Spooler 서비스가 중지되었습니다. 수동시작 으로 바꿀까요?"))
				{
					Utils.ExecuteCommandSync("sc.exe config Spooler start= demand");
					Utils.ExecuteCommandSync("sc.exe start Spooler");
				}
				else
				{
					result = false;
				}
			}
			else if (3 == num)
			{
				Utils.ExecuteCommandSync("sc.exe start Spooler");
			}
		}
		return result;
	}

	public int GetUSBSTOR_Start()
	{
		int num = -1;
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\services\\USBSTOR");
		if (registryKey != null)
		{
			return (int)registryKey.GetValue("Start", -1);
		}
		return -100;
	}

	public string GetFireWallVersion(string strDefault)
	{
		string text = strDefault;
		if (m_FireWallVersion == null)
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\services\\SharedAccess\\Parameters\\FirewallPolicy\\FirewallRules");
			if (registryKey != null)
			{
				string[] valueNames = registryKey.GetValueNames();
				if (3 < valueNames.Length)
				{
					string text2 = registryKey.GetValue(valueNames[0], "")!.ToString();
					string text3 = registryKey.GetValue(valueNames[1], "")!.ToString();
					string text4 = registryKey.GetValue(valueNames[2], "")!.ToString();
					text2 = text2.Split(new char[1] { '|' })[0];
					text3 = text2.Split(new char[1] { '|' })[0];
					text4 = text2.Split(new char[1] { '|' })[0];
					if (text2 == text3 && text2.StartsWith("v"))
					{
						text = text2;
					}
					else if (text3 == text4 && text3.StartsWith("v"))
					{
						text = text3;
					}
					else if (text4 == text2 && text4.StartsWith("v"))
					{
						text = text4;
					}
				}
			}
			m_FireWallVersion = text;
		}
		else
		{
			text = m_FireWallVersion;
		}
		return text;
	}

	public bool isAllRunUse(string p)
	{
		bool result = false;
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
		if (registryKey != null && registryKey.GetValue(p, null) is string)
		{
			result = true;
		}
		return result;
	}

	public bool isUserRunUse(string p)
	{
		bool result = false;
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
		if (registryKey != null && registryKey.GetValue(p, null) is string)
		{
			result = true;
		}
		return result;
	}

	internal static string ComputerName()
	{
		if (null == gComputerName)
		{
			StringBuilder stringBuilder = new StringBuilder(512);
			uint size = (uint)(stringBuilder.Capacity + 1);
			GetComputerName(stringBuilder, ref size);
			gComputerName = stringBuilder.ToString().Replace("\0", string.Empty);
			if (50 < gComputerName.Length)
			{
				gComputerName = gComputerName.Substring(0, 50);
			}
		}
		return gComputerName;
	}

	internal void doRegAuth(string p, string sAuthCode)
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(strKey, RegistryKeyPermissionCheck.ReadWriteSubTree);
		if (registryKey == null)
		{
			registryKey = Registry.CurrentUser.CreateSubKey(strKey);
		}
		registryKey.SetValue("UAuthEmail", p.ToLower());
		registryKey.SetValue("UAuthCode", sAuthCode);
	}

	internal bool isAuthCheck()
	{
		if (!bAuth)
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(strKey, RegistryKeyPermissionCheck.ReadWriteSubTree);
			if (registryKey == null)
			{
				registryKey = Registry.CurrentUser.CreateSubKey(strKey);
			}
			if (registryKey.GetValue("UAuthEmail") is string text)
			{
				string value = Utils.GetMD5string("PowerHealthChecker".ToLower() + "10+" + text + ComputerName().ToLower() + BiosDate()).ToLower();
				string text2 = registryKey.GetValue("UAuthCode") as string;
				if (text2 != null && text2.Equals(value))
				{
					bAuthSemi = false;
					bAuth = true;
				}
				else
				{
					string mD5string = Utils.GetMD5string("PowerHealthChecker".ToLower() + "1+" + text.ToLower() + ComputerName().ToLower() + DateTime.Now.ToString("yyyy-MM-dd"));
					if (text2 != null && text2.Equals(mD5string))
					{
						bAuthSemi = true;
						bAuth = true;
					}
				}
			}
		}
		return bAuth;
	}

	internal static string BiosDate()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		string text = "";
		string text2 = "";
		string text3 = "\\\\.\\ROOT\\cimv2";
		string text4 = "Win32_BIOS";
		ManagementClass val = new ManagementClass(text3 + ":" + text4);
		ManagementObjectEnumerator enumerator = val.GetInstances().GetEnumerator();
		try
		{
			if (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				text2 = ((ManagementBaseObject)val2).get_Item("ReleaseDate") as string;
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		return text2.Substring(0, 8);
	}

	private void BoolPropertySet(ref bool? propValue, string propName, bool value)
	{
		propValue = null;
		if (value)
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(strKey, RegistryKeyPermissionCheck.ReadWriteSubTree);
			if (registryKey == null)
			{
				registryKey = Registry.CurrentUser.CreateSubKey(strKey);
			}
			registryKey.SetValue(propName, 1, RegistryValueKind.DWord);
			registryKey.Close();
			registryKey.Dispose();
			registryKey = null;
			propValue = true;
		}
		else
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(strKey, RegistryKeyPermissionCheck.ReadWriteSubTree);
			if (registryKey == null)
			{
				registryKey = Registry.CurrentUser.CreateSubKey(strKey);
			}
			registryKey.SetValue(propName, 0);
			registryKey.Close();
			registryKey.Dispose();
			registryKey = null;
			propValue = false;
		}
	}

	private bool BoolPropertyGet(ref bool? prop, string PropName, bool defaultValue)
	{
		if (!prop.HasValue)
		{
			bool flag = defaultValue;
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(strKey, RegistryKeyPermissionCheck.ReadWriteSubTree);
			if (registryKey == null)
			{
				registryKey = Registry.CurrentUser.CreateSubKey(strKey);
			}
			int? num = registryKey.GetValue(PropName, -1) as int?;
			if (num == 1)
			{
				flag = true;
			}
			else
			{
				int? num2 = num;
				flag = (num2.GetValueOrDefault() != 0 || !num2.HasValue) && defaultValue;
			}
			registryKey.Close();
			registryKey.Dispose();
			registryKey = null;
			prop = flag;
		}
		return prop == true;
	}

	internal string StringPropertyGet(ref string prop, string PropName)
	{
		if (prop == null)
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(strKey, RegistryKeyPermissionCheck.ReadWriteSubTree);
			if (registryKey == null)
			{
				registryKey = Registry.CurrentUser.CreateSubKey(strKey);
			}
			string text = registryKey.GetValue(PropName, "") as string;
			string text2 = text;
			registryKey.Close();
			registryKey.Dispose();
			registryKey = null;
			prop = text2;
		}
		return prop;
	}

	private void StringPropertySet(ref string propValue, string propName, ref string value)
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(strKey, RegistryKeyPermissionCheck.ReadWriteSubTree);
		if (registryKey == null)
		{
			registryKey = Registry.CurrentUser.CreateSubKey(strKey);
		}
		registryKey.SetValue(propName, value, RegistryValueKind.String);
		registryKey.Close();
		registryKey.Dispose();
		registryKey = null;
		propValue = value;
	}

	internal void ShowTrialUseGuide()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		AutoClosingMessageBox.Show("해당 기능은 인증받은 경우만 이용 가능합니다.\n<안내 파일에 트라이얼 인증 방법이 있습니다.>", "PowerHealthChecker", 3100, 0);
		if (PowerDeskApp2014.Instance != null)
		{
			PowerDeskApp2014.Instance.mnuReadRTF_Click(null, null);
		}
	}

	internal void SetW32timeEnable(bool bShowStartGuide = true)
	{
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		if (!Instance.bAuth)
		{
			ShowTrialUseGuide();
			return;
		}
		Instance.RecentTimeSynchDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\Services\\W32Time\\Parameters"), RegistryKeyPermissionCheck.ReadWriteSubTree);
		string text = registryKey.GetValue("Type") as string;
		if (!"NTP".Equals(text))
		{
			if ("NoSync".Equals(text))
			{
				registryKey.SetValue("Type", "NTP");
			}
			else
			{
				if (PowerDeskApp2014.Instance == null || !((UIElement)PowerDeskApp2014.Instance).get_IsVisible())
				{
					WriteLogging("W32TimeSynch.txt", "[NTP]!=[" + text + "]");
					return;
				}
				if (!Utils.question("시간동기화 Type이 NTP가 아닙니다.\n현재 설정: " + text + "\nNTP로 바꾸시고 계속 하시겠습니까?"))
				{
					WriteLogging("W32TimeSynch.txt", "112233");
					return;
				}
				registryKey.SetValue("Type", "NTP");
			}
		}
		string text2 = registryKey.GetValue("NtpServer") as string;
		bool flag = false;
		if (text2.Equals("time.bora.net,0x9"))
		{
			flag = true;
		}
		else if (text2.Equals("time.google.com,0x9"))
		{
			flag = true;
		}
		else if (text2.Equals("time.windows.com,0x9"))
		{
			flag = true;
		}
		else if (-1 == text2.IndexOf(",") || -1 == text2.IndexOf(".") || -1 == text2.IndexOf("0x"))
		{
			registryKey.SetValue("NtpServer", "time.google.com,0x9");
			text2 = "time.google.com,0x9";
			flag = true;
		}
		else
		{
			string text3 = text2.Split(new char[1] { ',' })[0];
			string text4 = null;
			text4 = Utils.ExecuteCommandSync("ping " + text3 + " /n 1");
			if (-1 < text4.IndexOf("127.0.0."))
			{
				bool flag2 = false;
				if (PowerDeskApp2014.Instance != null && ((UIElement)PowerDeskApp2014.Instance).get_IsVisible())
				{
					flag2 = Utils.question("시간동기화 도메인은 알려져 있지 않습니다.\n현재 설정: " + text2 + "\ntime.google.com으로 바꾸시고 계속 하시겠습니까?");
				}
				if (!flag2)
				{
					WriteLogging("W32TimeSynch.txt", "445566");
					return;
				}
				registryKey.SetValue("NtpServer", "time.google.com,0x9");
				text2 = "time.google.com,0x9";
				flag = true;
			}
			else if (-1 == text4.IndexOf("0") && -1 == text4.IndexOf("1") && -1 == text4.IndexOf("2") && -1 == text4.IndexOf("3") && -1 == text4.IndexOf("4") && -1 == text4.IndexOf("5") && -1 == text4.IndexOf("6") && -1 == text4.IndexOf("7") && -1 == text4.IndexOf("8") && -1 == text4.IndexOf("9"))
			{
				bool flag2 = false;
				if (PowerDeskApp2014.Instance != null && ((UIElement)PowerDeskApp2014.Instance).get_IsVisible())
				{
					flag2 = Utils.question("시간동기화 도메인은 알려져 있지 않습니다.\n현재 설정: " + text2 + "\ntime.google.com으로 바꾸시고 계속 하시겠습니까?");
				}
				if (!flag2)
				{
					WriteLogging("W32TimeSynch.txt", "7788");
					return;
				}
				registryKey.SetValue("NtpServer", "time.google.com,0x9");
				text2 = "time.google.com,0x9";
				flag = true;
			}
		}
		if (tmrW32TimeAsynchExec != null)
		{
			if (PowerDeskApp2014.Instance != null && ((UIElement)PowerDeskApp2014.Instance).get_IsVisible() && bShowStartGuide)
			{
				AutoClosingMessageBox.Show("이미 동기화 처리중입니다.", "PowerHealthChecker", 3100, 0);
			}
			WriteLogging("W32TimeSynch.txt", "99aa");
			return;
		}
		if (flag)
		{
			if (PowerDeskApp2014.Instance != null && ((UIElement)PowerDeskApp2014.Instance).get_IsVisible() && bShowStartGuide)
			{
				AutoClosingMessageBox.Show("시간동기화 요청하였습니다 30초 정도 걸립니다.", "PowerHealthChecker", 3100, 0);
			}
		}
		else if (PowerDeskApp2014.Instance != null && ((UIElement)PowerDeskApp2014.Instance).get_IsVisible() && bShowStartGuide)
		{
			AutoClosingMessageBox.Show(text2.Split(new char[1] { ',' })[0] + "로 시간동기화 요청하였습니다. 30초 정도 걸립니다.", "PowerHealthChecker", 3100, 0);
		}
		AutoResetEvent state = new AutoResetEvent(initialState: false);
		tmrW32TimeOning = false;
		tmrW32TimeCount = 30;
		dtBeforeTimeSynch = DateTime.Now;
		dtBeforeTimeSynch_y = dtBeforeTimeSynch.Year;
		dtBeforeTimeSynch_m = dtBeforeTimeSynch.Month;
		dtBeforeTimeSynch_d = dtBeforeTimeSynch.Day;
		dtBeforeTimeSynch_hh = dtBeforeTimeSynch.Hour;
		dtBeforeTimeSynch_mm = dtBeforeTimeSynch.Minute;
		dtBeforeTimeSynch_ss = dtBeforeTimeSynch.Second;
		dtBeforeTimeSynch_milisec = dtBeforeTimeSynch.Millisecond;
		nBeforeTimeSynchTick = Environment.TickCount;
		tmrW32TimeAsynchExec = new Timer(actTimeSynch, state, 100, 1000);
	}

	private void actTimeSynch(object obj)
	{
		AutoResetEvent autoResetEvent = (AutoResetEvent)obj;
		Action action2;
		if (!tmrW32TimeOning)
		{
			tmrW32TimeOning = true;
			autoResetEvent.Set();
			CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
			try
			{
				CancellationToken token = cancellationTokenSource.Token;
				Action<object> action = delegate(object pObj)
				{
					AutoResetEvent autoResetEvent2 = (AutoResetEvent)pObj;
					Utils.ExecuteCommandSync(Environment.GetEnvironmentVariable("windir") + Utils.SEPA + "system32\\sc config w32time start= demand");
					Utils.ExecuteCommandSync(Environment.GetEnvironmentVariable("windir") + Utils.SEPA + "system32\\sc stop w32time");
					Utils.ExecuteCommandSync(Environment.GetEnvironmentVariable("windir") + Utils.SEPA + "system32\\timeout 2&sc start w32time");
					Utils.ExecuteCommandSync(Environment.GetEnvironmentVariable("windir") + Utils.SEPA + "system32\\timeout 2&w32tm /resync /rediscover /nowait&timeout 20&sc stop w32time&sc config w32time start= disabled");
					autoResetEvent2.Close();
					if (tmrW32TimeAsynchExec != null)
					{
						tmrW32TimeAsynchExec.Dispose();
						tmrW32TimeAsynchExec = null;
						AlterW32TimeSynchInfo();
						Action action3 = delegate
						{
							((HeaderedItemsControl)PowerDeskApp2014.Instance.mnuSleepMilisec).set_Header((object)"");
						};
						((DispatcherObject)PowerDeskApp2014.Instance).get_Dispatcher().BeginInvoke((Delegate)action3, new object[0]);
					}
				};
				Task task = Task.Factory.StartNew(action, autoResetEvent, token);
				if (task.Wait(TimeSpan.FromSeconds(30.0)))
				{
					return;
				}
				cancellationTokenSource.Cancel();
				if (tmrW32TimeAsynchExec != null)
				{
					tmrW32TimeAsynchExec.Dispose();
					tmrW32TimeAsynchExec = null;
					autoResetEvent.Close();
					action2 = delegate
					{
						((HeaderedItemsControl)PowerDeskApp2014.Instance.mnuSleepMilisec).set_Header((object)"");
					};
					Utils.ExecuteCommandSync(Environment.GetEnvironmentVariable("windir") + Utils.SEPA + "system32\\sc stop w32time&sc config w32time start= disabled");
					((DispatcherObject)PowerDeskApp2014.Instance).get_Dispatcher().BeginInvoke((Delegate)action2, new object[0]);
					AlterW32TimeSynchInfo();
				}
				return;
			}
			catch (Exception ex)
			{
				Console.Error.WriteLine(ex.Message);
				return;
			}
		}
		action2 = delegate
		{
			switch (--tmrW32TimeCount % 4)
			{
			case 0:
				((HeaderedItemsControl)PowerDeskApp2014.Instance.mnuSleepMilisec).set_Header((object)"◎시간 동기화◎");
				break;
			case 1:
				((HeaderedItemsControl)PowerDeskApp2014.Instance.mnuSleepMilisec).set_Header((object)("●" + tmrW32TimeCount + "초 남음●"));
				break;
			case 2:
				((HeaderedItemsControl)PowerDeskApp2014.Instance.mnuSleepMilisec).set_Header((object)"●시간 동기화●");
				break;
			case 3:
				((HeaderedItemsControl)PowerDeskApp2014.Instance.mnuSleepMilisec).set_Header((object)("◎" + tmrW32TimeCount + "초 남음◎"));
				break;
			}
			if (tmrW32TimeCount < 1)
			{
				((HeaderedItemsControl)PowerDeskApp2014.Instance.mnuSleepMilisec).set_Header((object)"");
			}
		};
		((DispatcherObject)PowerDeskApp2014.Instance).get_Dispatcher().BeginInvoke((Delegate)action2, new object[0]);
	}

	private void AlterW32TimeSynchInfo()
	{
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		dtAfterTimeSynch = DateTime.Now;
		nAfterTimeSynchTick = Environment.TickCount;
		dtBeforeTimeSynch = new DateTime(dtBeforeTimeSynch_y, dtBeforeTimeSynch_m, dtBeforeTimeSynch_d, dtBeforeTimeSynch_hh, dtBeforeTimeSynch_mm, dtBeforeTimeSynch_ss, dtBeforeTimeSynch_milisec);
		dtBeforeTimeSynch = dtBeforeTimeSynch.AddMilliseconds(nAfterTimeSynchTick - nBeforeTimeSynchTick);
		double num = dtBeforeTimeSynch.Subtract(dtAfterTimeSynch).Ticks;
		DateTime now = DateTime.Now;
		DateTime dateTime = now.AddSeconds(1.0);
		long num2 = now.Ticks - dateTime.Ticks;
		double num3 = 1.0 * num / (double)num2;
		string text = "";
		string text2 = "";
		if (0.0 < num3)
		{
			text = " +";
			text2 = "+";
		}
		else
		{
			num3 *= -1.0;
			text = " −";
			text2 = "-";
		}
		string text4 = (RecentTimeSynchDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
		string sLog = text4 + "\t" + text2 + num3;
		WriteLogging("W32TimeSynch.txt", sLog);
		if (PowerDeskApp2014.Instance != null && ((UIElement)PowerDeskApp2014.Instance).get_IsVisible())
		{
			AutoClosingMessageBox.Show("시간동기화 처리 되었습니다.\n" + text + num3 + "초 수정되었습니다.\nW32TimeSynch.txt 파일에 로깅됩니다.", "PowerHealthChecker", 3100, 0);
			NotifyPropertyChanged("CheckedVaccine21");
			NotifyPropertyChanged("StrVaccineAll");
		}
	}

	private void WriteLogging(string logFile, string sLog)
	{
		string lOGPATH = App.LOGPATH;
		Directory.CreateDirectory(lOGPATH);
		StreamWriter streamWriter = new StreamWriter(lOGPATH + logFile, append: true);
		streamWriter.WriteLine(sLog);
		streamWriter.Close();
	}

	internal void Win11_RMB_Solve()
	{
		mIsWin11RmbSolved = null;
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Classes\\CLSID", RegistryKeyPermissionCheck.ReadWriteSubTree);
		registryKey = registryKey.CreateSubKey("{86ca1aa0-34aa-4e8b-a509-50c905bae2a2}\\InprocServer32", RegistryKeyPermissionCheck.ReadWriteSubTree);
		registryKey.SetValue("", "");
		mIsWin11RmbSolved = true;
		NotifyPropertyChanged("IsWin11RmbSolved");
		NotifyPropertyChanged("IsWin11RmbNotSolved");
	}

	internal void Win11_RMB_Restore()
	{
		mIsWin11RmbSolved = null;
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Classes\\CLSID", RegistryKeyPermissionCheck.ReadWriteSubTree);
		registryKey.DeleteSubKeyTree("{86ca1aa0-34aa-4e8b-a509-50c905bae2a2}", throwOnMissingSubKey: false);
		mIsWin11RmbSolved = false;
		NotifyPropertyChanged("IsWin11RmbSolved");
		NotifyPropertyChanged("IsWin11RmbNotSolved");
	}

	internal bool ExistsEventLogParameter()
	{
		bool result = false;
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\Services\\EventLog"), writable: false);
		if (registryKey != null)
		{
			RegistryKey registryKey2 = registryKey.OpenSubKey("Parameters");
			if (registryKey2 != null && registryKey2.GetValue("ServiceDLL") == null)
			{
				result = true;
			}
		}
		return result;
	}

	internal void fixEventLogParameters()
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\Services\\EventLog"), RegistryKeyPermissionCheck.ReadWriteSubTree);
		if (registryKey != null)
		{
			RegistryKey registryKey2 = registryKey.OpenSubKey("Parameters", RegistryKeyPermissionCheck.ReadWriteSubTree);
			if (registryKey2 == null)
			{
				registryKey2 = registryKey.CreateSubKey("Parameters", RegistryKeyPermissionCheck.ReadWriteSubTree);
			}
			registryKey2.SetValue("ServiceDLL", "%SystemRoot%\\System32\\wevtsvc.dll", RegistryValueKind.ExpandString);
			registryKey2.SetValue("ServiceDllUnloadOnStop", 1, RegistryValueKind.DWord);
			registryKey2.SetValue("ServiceMain", "ServiceMain", RegistryValueKind.String);
			App.WorkLog("EventLog Param Fixed");
		}
	}

	internal int GetRdpPort()
	{
		if (nRdpPort == -2)
		{
			RegistryKey registryKey = null;
			registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Terminal Server\\WinStations\\RDP-Tcp");
			if (registryKey != null)
			{
				nRdpPort = (int)registryKey.GetValue("PortNumber", 3389);
			}
			else
			{
				nRdpPort = -1;
			}
		}
		return nRdpPort;
	}
}
