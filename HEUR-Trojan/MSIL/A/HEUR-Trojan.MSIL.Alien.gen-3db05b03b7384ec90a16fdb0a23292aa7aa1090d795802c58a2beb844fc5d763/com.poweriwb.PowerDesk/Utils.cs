using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows;
using System.Windows.Threading;
using Microsoft.Win32;
using VirusTotalNET.Objects;
using com.poweriwb.PowerDesk.VirusTotalNET;

namespace com.poweriwb.PowerDesk;

public class Utils
{
	public const string NT_TRUSTINSTALLER = "NT SERVICE\\TrustedInstaller";

	public const string NT_SYSTEM = "NT AUTHORITY\\SYSTEM";

	public const string NT_Administrators = "BUILTIN\\Administrators";

	public const string SE_RESTOREPRIVILEGE = "SeRestorePrivilege";

	public const string SE_BACKUPPRIVILEGE = "SeBackupPrivilege";

	public const string SE_TAKEOWNERSHIPPRIVILEGE = "SeTakeOwnershipPrivilege";

	public static List<string> lst_cmd_reserved = null;

	private static string _assemblyShortName = null;

	private static string MGUID = null;

	private static string m_SEPA = null;

	private static string m_AppRootPath = null;

	private static string[] m_DriveArray = null;

	private static string m_GetMyRecentFolder = null;

	private static string m_GetCurrentProcessFileFullNameLowercase = null;

	private static bool? m_isWindows7over = null;

	public static string strBeforeP_Environment_GetEnvironmentVariable = null;

	private static object resultOf_BeforeP_Environment_GetEnvironmentVariable = null;

	private static bool? mIsNotServerMachine = null;

	private static bool? mIsWindows11 = null;

	public static string SEPA
	{
		get
		{
			if (m_SEPA == null)
			{
				m_SEPA = string.Concat(Path.DirectorySeparatorChar);
			}
			return m_SEPA;
		}
	}

	public static string AssemblyShortName
	{
		get
		{
			if (_assemblyShortName == null)
			{
				Assembly assembly = typeof(Utils).Assembly;
				_assemblyShortName = assembly.ToString().Split(new char[1] { ',' })[0];
			}
			return _assemblyShortName;
		}
	}

	public static bool isWindows7over
	{
		get
		{
			if (!m_isWindows7over.HasValue)
			{
				OperatingSystem oSVersion = Environment.OSVersion;
				Version version = oSVersion.Version;
				bool flag = false;
				flag = version.Major >= 6 && version.Minor >= 1;
				m_isWindows7over = flag;
			}
			return m_isWindows7over == true;
		}
	}

	public static bool IsWindows11
	{
		get
		{
			if (!mIsWindows11.HasValue)
			{
				if (-1 < GetOsName().IndexOf("Windows 11"))
				{
					mIsWindows11 = true;
				}
				else
				{
					mIsWindows11 = false;
				}
			}
			return mIsWindows11.Value;
		}
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	public static extern bool Wow64DisableWow64FsRedirection(ref IntPtr oldValue);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	public static extern bool Wow64RevertWow64FsRedirection(ref IntPtr oldValue);

	public static bool FileExistsDos(string path, ref bool isHidden)
	{
		bool result = false;
		string text = "";
		string text2 = "";
		text2 = onlyFileNameEx(path);
		text = ExecuteCommandSync("dir \"" + path + "\"");
		if (-1 < text.IndexOf(text2, StringComparison.CurrentCultureIgnoreCase))
		{
			result = true;
		}
		else
		{
			text = ExecuteCommandSync("dir \"" + path + "\" /ah");
			if (-1 < text.IndexOf(text2, StringComparison.CurrentCultureIgnoreCase))
			{
				result = true;
				isHidden = true;
			}
		}
		return result;
	}

	public static string FilesDosDir(string path_with_pattern_parameter)
	{
		return ExecuteCommandSync("dir " + path_with_pattern_parameter);
	}

	public static bool FileExists(string path)
	{
		bool flag = false;
		if (File.Exists(path))
		{
			flag = true;
		}
		if (!flag)
		{
			IntPtr oldValue = IntPtr.Zero;
			try
			{
				if (Environment_GetEnvironmentVariable("PROCESSOR_ARCHITEW6432") == null)
				{
					flag = false;
					return flag;
				}
				Wow64DisableWow64FsRedirection(ref oldValue);
				if (File.Exists(path))
				{
					flag = true;
					return flag;
				}
				return flag;
			}
			catch (Exception)
			{
				return flag;
			}
			finally
			{
				if (oldValue != IntPtr.Zero)
				{
					Wow64RevertWow64FsRedirection(ref oldValue);
				}
			}
		}
		return flag;
	}

	private static object Environment_GetEnvironmentVariable(string p)
	{
		if (p == strBeforeP_Environment_GetEnvironmentVariable)
		{
			return resultOf_BeforeP_Environment_GetEnvironmentVariable;
		}
		strBeforeP_Environment_GetEnvironmentVariable = p;
		resultOf_BeforeP_Environment_GetEnvironmentVariable = Environment.GetEnvironmentVariable(p);
		return resultOf_BeforeP_Environment_GetEnvironmentVariable;
	}

	public static void ListProduct()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher("SELECT * FROM Win32_Product");
		ManagementObjectCollection val2 = val.Get();
		ManagementObjectEnumerator enumerator = val2.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val3 = (ManagementObject)enumerator.get_Current();
				Console.WriteLine("\n\nCaption : " + ((ManagementBaseObject)val3).get_Item("Caption").ToString());
				Console.WriteLine("Description : " + ((ManagementBaseObject)val3).get_Item("Description").ToString());
				Console.WriteLine("InstallLocation : " + ((((ManagementBaseObject)val3).get_Item("InstallLocation") == null) ? " " : ((ManagementBaseObject)val3).get_Item("InstallLocation").ToString()));
				Console.WriteLine("InstallState : " + ((ManagementBaseObject)val3).get_Item("InstallState").ToString());
				Console.WriteLine("Name : " + ((ManagementBaseObject)val3).get_Item("Name").ToString());
				Console.WriteLine("PackageCache : " + ((ManagementBaseObject)val3).get_Item("PackageCache").ToString());
				Console.WriteLine("SKUNumber : " + ((((ManagementBaseObject)val3).get_Item("SKUNumber") == null) ? " " : ((ManagementBaseObject)val3).get_Item("SKUNumber").ToString()));
				Console.WriteLine("Vendor : " + ((ManagementBaseObject)val3).get_Item("Vendor").ToString());
				Console.WriteLine("Version : " + ((ManagementBaseObject)val3).get_Item("Version").ToString());
				Console.ReadLine();
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		val2 = null;
		val = null;
	}

	public static string GetMGUIDbyCPUAndHardDisk()
	{
		if (MGUID == null)
		{
			string text = "";
			string volumeSerialNumber = GetVolumeSerialNumber();
			string data = GetCPUId() + volumeSerialNumber;
			string mD5string = GetMD5string(data);
			string mD5CheckSum = GetMD5CheckSum(mD5string);
			text = mD5string + mD5CheckSum;
			MGUID = text.ToLower();
		}
		return MGUID;
	}

	private static string GetMD5CheckSum(string md5_string)
	{
		int num = 0;
		string text = null;
		int num2;
		for (num2 = 0; num2 < md5_string.Length; num2++)
		{
			text = md5_string.Substring(num2, 2);
			num2++;
			string value = text;
			num += Convert.ToInt32(value, 16);
		}
		int num3 = num % 256;
		return $"{num3:x2}";
	}

	private static string GetVolumeSerialNumber()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		string text = "C";
		string result = "";
		try
		{
			ManagementObject val = new ManagementObject("win32_logicaldisk.deviceid=\"" + text + ":\"");
			val.Get();
			result = ((ManagementBaseObject)val).get_Item("VolumeSerialNumber").ToString();
		}
		catch (Exception)
		{
		}
		return result;
	}

	public static string GetMD5string(string data)
	{
		MD5 mD = MD5.Create();
		byte[] bytes = Encoding.ASCII.GetBytes(data);
		byte[] array = mD.ComputeHash(bytes);
		return BitConverter.ToString(array).Replace("-", "");
	}

	public static string GetCPUId()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		ManagementClass val = new ManagementClass("Win32_Processor");
		ManagementObjectCollection val2 = null;
		string text = string.Empty;
		try
		{
			val2 = val.GetInstances();
			ManagementObjectEnumerator enumerator = val2.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val3 = (ManagementObject)enumerator.get_Current();
					if (text == string.Empty)
					{
						text = ((ManagementBaseObject)val3).get_Properties().get_Item("ProcessorId").get_Value()
							.ToString();
						break;
					}
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}
		catch (COMException)
		{
		}
		catch (Exception)
		{
		}
		return text;
	}

	public static string VirunInfo(string sha256)
	{
		VirusTotal virusTotal = new VirusTotal("f56ab1f18e2759f47d14ba8bd08b48646658f7a4335909198a5f1d6e5356beb2");
		virusTotal.UseTLS = false;
		FileReport fileReport = virusTotal.GetFileReport(sha256);
		return fileReport.Positives + "/" + fileReport.Total;
	}

	internal static bool Is64OS()
	{
		return Environment.Is64BitOperatingSystem;
	}

	internal static bool Is64Process()
	{
		return Environment.Is64BitProcess;
	}

	internal static bool Is64App()
	{
		bool flag = false;
		bool flag2 = false;
		flag = 8 == IntPtr.Size;
		flag2 = -1 == Application.get_ResourceAssembly().Location.IndexOf("(x86)", StringComparison.CurrentCultureIgnoreCase);
		return flag && flag2;
	}

	internal static void alert(string p, string c)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(p, c, (MessageBoxButton)0, (MessageBoxImage)48);
	}

	internal static bool question(string p)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Invalid comparison between Unknown and I4
		bool result = false;
		MessageBoxResult val = MessageBox.Show(p, Application.get_Current().get_MainWindow().get_Title(), (MessageBoxButton)4, (MessageBoxImage)32);
		if ((int)val == 6)
		{
			result = true;
		}
		return result;
	}

	internal static void alert(string p)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(p, Application.get_Current().get_MainWindow().get_Title(), (MessageBoxButton)0, (MessageBoxImage)48);
	}

	public static string AppRootPath()
	{
		if (m_AppRootPath == null)
		{
			string location = Assembly.GetExecutingAssembly().Location;
			m_AppRootPath = location.Remove(location.LastIndexOf(Path.DirectorySeparatorChar) + 1);
		}
		return m_AppRootPath;
	}

	public static string[] DriveArray()
	{
		if (m_DriveArray == null)
		{
			List<string> list = new List<string>();
			DriveInfo[] drives = DriveInfo.GetDrives();
			foreach (DriveInfo driveInfo in drives)
			{
				if (driveInfo.IsReady && driveInfo.DriveType == DriveType.Fixed)
				{
					list.Add(driveInfo.Name);
				}
			}
			m_DriveArray = list.ToArray();
		}
		return m_DriveArray;
	}

	public static string getNetShare()
	{
		string text = ExecuteCommandSync("net config");
		if (-1 == text.IndexOf("server", StringComparison.CurrentCultureIgnoreCase))
		{
			return "";
		}
		return ExecuteCommandSync("net share");
	}

	public static string getBCDEdit()
	{
		if (File.Exists("c:\\windows\\system32\\bcdedit2.exe"))
		{
			return ExecuteCommandSync("bcdedit2.exe /v");
		}
		return ExecuteCommandSync("bcdedit.exe /v");
	}

	public static string getUserAccount()
	{
		return ExecuteCommandSync("wmic.exe useraccount get name,disabled,sid");
	}

	public static string getUSERNAME()
	{
		string text = ExecuteCommandSync("echo %USERNAME%");
		return text.Replace("\r", "").Replace("\n", "");
	}

	public static string ExecuteCommandSync(string command, bool showError = true)
	{
		string result = "";
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd", "/d /c " + command);
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.UseShellExecute = false;
			processStartInfo.CreateNoWindow = true;
			Process process = new Process();
			process.StartInfo = processStartInfo;
			process.Start();
			result = process.StandardOutput.ReadToEnd();
			return result;
		}
		catch (Exception ex)
		{
			if (showError)
			{
				alert(ex.Message + "{" + command + "}");
			}
		}
		return result;
	}

	public static void UAC_owner(bool secure)
	{
		try
		{
			TokenManipulator.AddPrivilege("SeRestorePrivilege");
			TokenManipulator.AddPrivilege("SeBackupPrivilege");
			TokenManipulator.AddPrivilege("SeTakeOwnershipPrivilege");
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies", RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.TakeOwnership);
			if (registryKey != null)
			{
				RegistrySecurity accessControl = registryKey.GetAccessControl();
				IdentityReference owner = accessControl.GetOwner(typeof(SecurityIdentifier));
				NTAccount nTAccount = owner.Translate(typeof(NTAccount)) as NTAccount;
				string text = nTAccount.Value.ToLower();
				if (text != "builtin\\administrators")
				{
					NTAccount nTAccount2 = new NTAccount("BUILTIN\\Administrators");
					accessControl.SetOwner(nTAccount2);
					accessControl.AddAccessRule(new RegistryAccessRule(nTAccount2, RegistryRights.FullControl, AccessControlType.Allow));
					registryKey.SetAccessControl(accessControl);
				}
			}
			if (secure)
			{
				registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.TakeOwnership);
				if (registryKey != null)
				{
					RegistrySecurity accessControl = registryKey.GetAccessControl();
					IdentityReference owner = accessControl.GetOwner(typeof(SecurityIdentifier));
					NTAccount nTAccount = owner.Translate(typeof(NTAccount)) as NTAccount;
					string text = nTAccount.Value.ToLower();
					if (text != "builtin\\administrators")
					{
						NTAccount nTAccount2 = new NTAccount("Administrators");
						accessControl.SetOwner(nTAccount2);
						accessControl.AddAccessRule(new RegistryAccessRule(nTAccount2, RegistryRights.FullControl, AccessControlType.Allow));
						registryKey.SetAccessControl(accessControl);
					}
				}
				return;
			}
			registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.TakeOwnership);
			if (registryKey != null)
			{
				RegistrySecurity accessControl = registryKey.GetAccessControl();
				IdentityReference owner = accessControl.GetOwner(typeof(SecurityIdentifier));
				NTAccount nTAccount = owner.Translate(typeof(NTAccount)) as NTAccount;
				string text = nTAccount.Value.ToLower();
				if (text != "NT AUTHORITY\\SYSTEM".ToLower())
				{
					NTAccount nTAccount2 = new NTAccount("NT AUTHORITY\\SYSTEM");
					accessControl.SetOwner(nTAccount2);
					accessControl.AddAccessRule(new RegistryAccessRule(nTAccount2, RegistryRights.FullControl, AccessControlType.Allow));
					registryKey.SetAccessControl(accessControl);
				}
			}
		}
		finally
		{
			TokenManipulator.RemovePrivilege("SeRestorePrivilege");
			TokenManipulator.RemovePrivilege("SeBackupPrivilege");
			TokenManipulator.RemovePrivilege("SeTakeOwnershipPrivilege");
		}
	}

	public static void SetReigistry_owner(int keyroot, string reg_path, bool secure)
	{
		try
		{
			TokenManipulator.AddPrivilege("SeRestorePrivilege");
			TokenManipulator.AddPrivilege("SeBackupPrivilege");
			TokenManipulator.AddPrivilege("SeTakeOwnershipPrivilege");
			RegistryKey registryKey = null;
			switch (keyroot)
			{
			default:
				throw new NotImplementedException("SetReigistry_owner");
			case 1:
				if (Is64OS())
				{
					RegistryKey registryKey2 = RegistryKey.OpenBaseKey(RegistryHive.ClassesRoot, RegistryView.Registry64);
					registryKey = registryKey2.OpenSubKey(reg_path, RegistryKeyPermissionCheck.ReadWriteSubTree);
				}
				else
				{
					registryKey = Registry.ClassesRoot.OpenSubKey(reg_path, RegistryKeyPermissionCheck.ReadWriteSubTree);
				}
				break;
			case 2:
				if (Is64OS())
				{
					RegistryKey registryKey2 = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
					registryKey = registryKey2.OpenSubKey(reg_path, RegistryKeyPermissionCheck.ReadWriteSubTree);
				}
				else
				{
					registryKey = Registry.CurrentUser.OpenSubKey(reg_path, RegistryKeyPermissionCheck.ReadWriteSubTree);
				}
				break;
			case 3:
				if (Is64OS())
				{
					RegistryKey registryKey2 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
					registryKey = registryKey2.OpenSubKey(reg_path, RegistryKeyPermissionCheck.ReadWriteSubTree);
				}
				else
				{
					registryKey = Registry.LocalMachine.OpenSubKey(reg_path, RegistryKeyPermissionCheck.ReadWriteSubTree);
				}
				break;
			case 4:
				if (Is64OS())
				{
					RegistryKey registryKey2 = RegistryKey.OpenBaseKey(RegistryHive.CurrentConfig, RegistryView.Registry64);
					registryKey = registryKey2.OpenSubKey(reg_path, RegistryKeyPermissionCheck.ReadWriteSubTree);
				}
				else
				{
					registryKey = Registry.CurrentConfig.OpenSubKey(reg_path, RegistryKeyPermissionCheck.ReadWriteSubTree);
				}
				break;
			}
			if (registryKey == null)
			{
				return;
			}
			RegistrySecurity accessControl = registryKey.GetAccessControl();
			IdentityReference owner = accessControl.GetOwner(typeof(SecurityIdentifier));
			NTAccount nTAccount = owner.Translate(typeof(NTAccount)) as NTAccount;
			string text = nTAccount.Value.ToLower();
			if (text != "builtin\\administrators")
			{
				NTAccount nTAccount2 = new NTAccount("BUILTIN\\Administrators");
				accessControl.SetOwner(nTAccount2);
				accessControl.AddAccessRule(new RegistryAccessRule(nTAccount2, RegistryRights.FullControl, AccessControlType.Allow));
				registryKey.SetAccessControl(accessControl);
			}
			if (secure)
			{
				RegistrySecurity accessControl2 = registryKey.GetAccessControl();
				IdentityReference owner2 = accessControl2.GetOwner(typeof(SecurityIdentifier));
				NTAccount nTAccount3 = owner2.Translate(typeof(NTAccount)) as NTAccount;
				string text2 = nTAccount3.Value.ToLower();
				if (text2 != "builtin\\administrators")
				{
					NTAccount nTAccount2 = new NTAccount("Administrators");
					accessControl2.SetOwner(nTAccount2);
					accessControl2.AddAccessRule(new RegistryAccessRule(nTAccount2, RegistryRights.FullControl, AccessControlType.Allow));
					registryKey.SetAccessControl(accessControl2);
				}
			}
			else
			{
				RegistrySecurity accessControl2 = registryKey.GetAccessControl();
				IdentityReference owner2 = accessControl2.GetOwner(typeof(SecurityIdentifier));
				NTAccount nTAccount3 = owner2.Translate(typeof(NTAccount)) as NTAccount;
				string text2 = nTAccount3.Value.ToLower();
				if (text2 != "NT AUTHORITY\\SYSTEM".ToLower())
				{
					NTAccount nTAccount2 = new NTAccount("NT AUTHORITY\\SYSTEM");
					accessControl2.SetOwner(nTAccount2);
					accessControl2.AddAccessRule(new RegistryAccessRule(nTAccount2, RegistryRights.FullControl, AccessControlType.Allow));
					registryKey.SetAccessControl(accessControl2);
				}
			}
		}
		finally
		{
			TokenManipulator.RemovePrivilege("SeRestorePrivilege");
			TokenManipulator.RemovePrivilege("SeBackupPrivilege");
			TokenManipulator.RemovePrivilege("SeTakeOwnershipPrivilege");
		}
	}

	public static void RECENT_system(bool secure)
	{
		string myRecentFolder = GetMyRecentFolder();
		Folder_secure(myRecentFolder, secure);
	}

	public static void Folder_secure(string strFolder, bool secure)
	{
		try
		{
			TokenManipulator.AddPrivilege("SeRestorePrivilege");
			TokenManipulator.AddPrivilege("SeBackupPrivilege");
			TokenManipulator.AddPrivilege("SeTakeOwnershipPrivilege");
			if (Directory.Exists(strFolder))
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(strFolder);
				DirectorySecurity accessControl = directoryInfo.GetAccessControl();
				IdentityReference owner = accessControl.GetOwner(typeof(SecurityIdentifier));
				NTAccount nTAccount = owner.Translate(typeof(NTAccount)) as NTAccount;
				string value = nTAccount.Value;
				if (string.Compare(value, WindowsIdentity.GetCurrent().Name, ignoreCase: true) != 0)
				{
					NTAccount identity = new NTAccount(WindowsIdentity.GetCurrent().Name);
					accessControl.SetOwner(WindowsIdentity.GetCurrent().User);
					accessControl.AddAccessRule(new FileSystemAccessRule(identity, FileSystemRights.FullControl, AccessControlType.Allow));
					directoryInfo.SetAccessControl(accessControl);
					TokenManipulator.RemovePrivilege("SeRestorePrivilege");
					TokenManipulator.RemovePrivilege("SeBackupPrivilege");
					TokenManipulator.RemovePrivilege("SeTakeOwnershipPrivilege");
					TokenManipulator.AddPrivilege("SeRestorePrivilege");
					TokenManipulator.AddPrivilege("SeBackupPrivilege");
					TokenManipulator.AddPrivilege("SeTakeOwnershipPrivilege");
				}
				if (secure)
				{
					NTAccount identity2 = new NTAccount("NT AUTHORITY\\SYSTEM");
					accessControl.AddAccessRule(new FileSystemAccessRule(identity2, FileSystemRights.ExecuteFile, AccessControlType.Deny));
					directoryInfo.SetAccessControl(accessControl);
				}
				else
				{
					NTAccount identity2 = new NTAccount("NT AUTHORITY\\SYSTEM");
					accessControl.RemoveAccessRule(new FileSystemAccessRule(identity2, FileSystemRights.ExecuteFile, AccessControlType.Deny));
					directoryInfo.SetAccessControl(accessControl);
				}
			}
		}
		finally
		{
			TokenManipulator.RemovePrivilege("SeRestorePrivilege");
			TokenManipulator.RemovePrivilege("SeBackupPrivilege");
			TokenManipulator.RemovePrivilege("SeTakeOwnershipPrivilege");
		}
	}

	public static void File_secure(string strFile, bool secure, bool byUser)
	{
		try
		{
			TokenManipulator.AddPrivilege("SeRestorePrivilege");
			TokenManipulator.AddPrivilege("SeBackupPrivilege");
			TokenManipulator.AddPrivilege("SeTakeOwnershipPrivilege");
			if (!File.Exists(strFile))
			{
				return;
			}
			FileInfo fileInfo = new FileInfo(strFile);
			FileSecurity accessControl = fileInfo.GetAccessControl();
			IdentityReference owner = accessControl.GetOwner(typeof(SecurityIdentifier));
			NTAccount nTAccount = owner.Translate(typeof(NTAccount)) as NTAccount;
			string value = nTAccount.Value;
			if (byUser)
			{
				if (string.Compare(value, WindowsIdentity.GetCurrent().Name, ignoreCase: true) != 0)
				{
					NTAccount identity = new NTAccount(WindowsIdentity.GetCurrent().Name);
					accessControl.SetOwner(WindowsIdentity.GetCurrent().User);
					accessControl.AddAccessRule(new FileSystemAccessRule(identity, FileSystemRights.FullControl, AccessControlType.Allow));
					fileInfo.SetAccessControl(accessControl);
					TokenManipulator.RemovePrivilege("SeRestorePrivilege");
					TokenManipulator.RemovePrivilege("SeBackupPrivilege");
					TokenManipulator.RemovePrivilege("SeTakeOwnershipPrivilege");
					TokenManipulator.AddPrivilege("SeRestorePrivilege");
					TokenManipulator.AddPrivilege("SeBackupPrivilege");
					TokenManipulator.AddPrivilege("SeTakeOwnershipPrivilege");
				}
			}
			else if (string.Compare(value, "builtin\administrators", ignoreCase: true) != 0)
			{
				NTAccount nTAccount2 = new NTAccount("BUILTIN\\Administrators");
				accessControl.SetOwner(nTAccount2);
				accessControl.AddAccessRule(new FileSystemAccessRule(nTAccount2, FileSystemRights.FullControl, AccessControlType.Allow));
				fileInfo.SetAccessControl(accessControl);
				TokenManipulator.RemovePrivilege("SeRestorePrivilege");
				TokenManipulator.RemovePrivilege("SeBackupPrivilege");
				TokenManipulator.RemovePrivilege("SeTakeOwnershipPrivilege");
				TokenManipulator.AddPrivilege("SeRestorePrivilege");
				TokenManipulator.AddPrivilege("SeBackupPrivilege");
				TokenManipulator.AddPrivilege("SeTakeOwnershipPrivilege");
			}
			if (secure)
			{
				NTAccount identity2 = new NTAccount("NT AUTHORITY\\SYSTEM");
				accessControl.AddAccessRule(new FileSystemAccessRule(identity2, FileSystemRights.ExecuteFile, AccessControlType.Deny));
				fileInfo.SetAccessControl(accessControl);
			}
			else
			{
				NTAccount identity2 = new NTAccount("NT AUTHORITY\\SYSTEM");
				accessControl.RemoveAccessRule(new FileSystemAccessRule(identity2, FileSystemRights.ExecuteFile, AccessControlType.Deny));
				fileInfo.SetAccessControl(accessControl);
			}
		}
		finally
		{
			TokenManipulator.RemovePrivilege("SeRestorePrivilege");
			TokenManipulator.RemovePrivilege("SeBackupPrivilege");
			TokenManipulator.RemovePrivilege("SeTakeOwnershipPrivilege");
		}
	}

	public static void PICALUA_system(bool secure)
	{
		string pcalus_exe = "pcalua.exe";
		system32_file_secure(secure, pcalus_exe);
	}

	public static void URLMON_system(bool secure)
	{
		string pcalus_exe = "urlmon.dll";
		system32_file_secure(secure, pcalus_exe);
	}

	public static void WISPTIS_system(bool secure)
	{
		string pcalus_exe = "WISPTIS.exe";
		system32_file_secure_sysdeny(secure, pcalus_exe);
	}

	public static void USOCOREWORKER_system(bool secure)
	{
		string pcalus_exe = "usocoreworker.exe";
		system32_file_secure_sysdeny(secure, pcalus_exe);
	}

	public static void RASERVER_system(bool secure)
	{
		string pcalus_exe = "raserver.exe";
		system32_file_secure_sysdeny(secure, pcalus_exe);
	}

	public static void NTOSKRNL_system(bool secure)
	{
		string pcalus_exe = "ntoskrnl.exe";
		system32_file_secure_sysdeny(secure, pcalus_exe);
	}

	internal static void system32_file_secure(bool secure, string pcalus_exe)
	{
		try
		{
			TokenManipulator.AddPrivilege("SeRestorePrivilege");
			TokenManipulator.AddPrivilege("SeBackupPrivilege");
			TokenManipulator.AddPrivilege("SeTakeOwnershipPrivilege");
			string text = ((-1 >= pcalus_exe.IndexOf(":")) ? GetSystemFileName(pcalus_exe) : pcalus_exe);
			if (File.Exists(text))
			{
				FileInfo fileInfo = new FileInfo(text);
				FileSecurity accessControl = fileInfo.GetAccessControl();
				IdentityReference owner = accessControl.GetOwner(typeof(SecurityIdentifier));
				NTAccount nTAccount = owner.Translate(typeof(NTAccount)) as NTAccount;
				string value = nTAccount.Value;
				_ = WindowsIdentity.GetCurrent().User;
				if (string.Compare(value, WindowsIdentity.GetCurrent().Name, ignoreCase: true) != 0)
				{
					NTAccount owner2 = new NTAccount(WindowsIdentity.GetCurrent().Name);
					accessControl.SetOwner(owner2);
					fileInfo.SetAccessControl(accessControl);
					TokenManipulator.RemovePrivilege("SeRestorePrivilege");
					TokenManipulator.RemovePrivilege("SeBackupPrivilege");
					TokenManipulator.RemovePrivilege("SeTakeOwnershipPrivilege");
					TokenManipulator.AddPrivilege("SeRestorePrivilege");
					TokenManipulator.AddPrivilege("SeBackupPrivilege");
					TokenManipulator.AddPrivilege("SeTakeOwnershipPrivilege");
				}
				if (secure)
				{
					NTAccount identity = new NTAccount("NT AUTHORITY\\SYSTEM");
					accessControl.RemoveAccessRule(new FileSystemAccessRule(identity, FileSystemRights.ReadAndExecute, AccessControlType.Allow));
					accessControl.AddAccessRule(new FileSystemAccessRule(identity, FileSystemRights.ReadAndExecute, AccessControlType.Deny));
				}
				else
				{
					NTAccount identity = new NTAccount("NT AUTHORITY\\SYSTEM");
					accessControl.AddAccessRule(new FileSystemAccessRule(identity, FileSystemRights.ReadAndExecute, AccessControlType.Allow));
					accessControl.RemoveAccessRule(new FileSystemAccessRule(identity, FileSystemRights.ReadAndExecute, AccessControlType.Deny));
				}
				NTAccount owner3 = new NTAccount("NT SERVICE\\TrustedInstaller");
				accessControl.SetOwner(owner3);
				fileInfo.SetAccessControl(accessControl);
			}
		}
		finally
		{
			TokenManipulator.RemovePrivilege("SeRestorePrivilege");
			TokenManipulator.RemovePrivilege("SeBackupPrivilege");
			TokenManipulator.RemovePrivilege("SeTakeOwnershipPrivilege");
		}
	}

	internal static void system32_file_secure_sysdeny(bool secure, string pcalus_exe)
	{
		try
		{
			TokenManipulator.AddPrivilege("SeRestorePrivilege");
			TokenManipulator.AddPrivilege("SeBackupPrivilege");
			TokenManipulator.AddPrivilege("SeTakeOwnershipPrivilege");
			string text = ((-1 >= pcalus_exe.IndexOf(":")) ? GetSystemFileName(pcalus_exe) : pcalus_exe);
			if (File.Exists(text))
			{
				FileInfo fileInfo = new FileInfo(text);
				FileSecurity accessControl = fileInfo.GetAccessControl();
				IdentityReference owner = accessControl.GetOwner(typeof(SecurityIdentifier));
				NTAccount nTAccount = owner.Translate(typeof(NTAccount)) as NTAccount;
				string value = nTAccount.Value;
				_ = WindowsIdentity.GetCurrent().User;
				if (string.Compare(value, WindowsIdentity.GetCurrent().Name, ignoreCase: true) != 0)
				{
					NTAccount owner2 = new NTAccount(WindowsIdentity.GetCurrent().Name);
					accessControl.SetOwner(owner2);
					fileInfo.SetAccessControl(accessControl);
					TokenManipulator.RemovePrivilege("SeRestorePrivilege");
					TokenManipulator.RemovePrivilege("SeBackupPrivilege");
					TokenManipulator.RemovePrivilege("SeTakeOwnershipPrivilege");
					TokenManipulator.AddPrivilege("SeRestorePrivilege");
					TokenManipulator.AddPrivilege("SeBackupPrivilege");
					TokenManipulator.AddPrivilege("SeTakeOwnershipPrivilege");
				}
				if (secure)
				{
					NTAccount identity = new NTAccount("NT AUTHORITY\\SYSTEM");
					accessControl.RemoveAccessRule(new FileSystemAccessRule(identity, FileSystemRights.ReadAndExecute, AccessControlType.Allow));
					accessControl.AddAccessRule(new FileSystemAccessRule(identity, FileSystemRights.ReadAndExecute, AccessControlType.Deny));
					NTAccount identity2 = new NTAccount("BUILTIN\\Administrators");
					accessControl.RemoveAccessRule(new FileSystemAccessRule(identity2, FileSystemRights.ReadAndExecute, AccessControlType.Allow));
					accessControl.AddAccessRule(new FileSystemAccessRule(identity2, FileSystemRights.ReadAndExecute, AccessControlType.Deny));
				}
				else
				{
					NTAccount identity = new NTAccount("NT AUTHORITY\\SYSTEM");
					accessControl.AddAccessRule(new FileSystemAccessRule(identity, FileSystemRights.ReadAndExecute, AccessControlType.Allow));
					accessControl.RemoveAccessRule(new FileSystemAccessRule(identity, FileSystemRights.ReadAndExecute, AccessControlType.Deny));
					NTAccount identity2 = new NTAccount("BUILTIN\\Administrators");
					accessControl.AddAccessRule(new FileSystemAccessRule(identity, FileSystemRights.ReadAndExecute, AccessControlType.Allow));
					accessControl.RemoveAccessRule(new FileSystemAccessRule(identity, FileSystemRights.ReadAndExecute, AccessControlType.Deny));
				}
				NTAccount owner3 = new NTAccount("NT SERVICE\\TrustedInstaller");
				accessControl.SetOwner(owner3);
				fileInfo.SetAccessControl(accessControl);
			}
		}
		finally
		{
			TokenManipulator.RemovePrivilege("SeRestorePrivilege");
			TokenManipulator.RemovePrivilege("SeBackupPrivilege");
			TokenManipulator.RemovePrivilege("SeTakeOwnershipPrivilege");
		}
	}

	public static void AddDirectorySecurity(string FileName, string Account, FileSystemRights Rights, AccessControlType ControlType)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(FileName);
		DirectorySecurity accessControl = directoryInfo.GetAccessControl();
		accessControl.AddAccessRule(new FileSystemAccessRule(Account, Rights, ControlType));
		directoryInfo.SetAccessControl(accessControl);
	}

	public static void RemoveDirectorySecurity(string FileName, string Account, FileSystemRights Rights, AccessControlType ControlType)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(FileName);
		DirectorySecurity accessControl = directoryInfo.GetAccessControl();
		accessControl.RemoveAccessRule(new FileSystemAccessRule(Account, Rights, ControlType));
		directoryInfo.SetAccessControl(accessControl);
	}

	public static bool SelectDirectorySecurity(string path)
	{
		bool result = true;
		bool flag = false;
		try
		{
			TokenManipulator.AddPrivilege("SeRestorePrivilege");
			TokenManipulator.AddPrivilege("SeBackupPrivilege");
			TokenManipulator.AddPrivilege("SeTakeOwnershipPrivilege");
			DirectoryInfo directoryInfo = new DirectoryInfo(path);
			DirectorySecurity accessControl = directoryInfo.GetAccessControl();
			AuthorizationRuleCollection accessRules = accessControl.GetAccessRules(includeExplicit: true, includeInherited: false, typeof(NTAccount));
			foreach (AuthorizationRule item in accessRules)
			{
				if (item.IdentityReference.Value == "NT AUTHORITY\\SYSTEM")
				{
					flag = true;
					FileSystemAccessRule fileSystemAccessRule = item as FileSystemAccessRule;
					if ((fileSystemAccessRule.FileSystemRights & FileSystemRights.ExecuteFile) == FileSystemRights.ExecuteFile && fileSystemAccessRule.AccessControlType == AccessControlType.Deny)
					{
						result = false;
						break;
					}
				}
			}
			if (!flag)
			{
				AuthorizationRuleCollection accessRules2 = accessControl.GetAccessRules(includeExplicit: false, includeInherited: true, typeof(NTAccount));
				foreach (AuthorizationRule item2 in accessRules2)
				{
					if (item2.IdentityReference.Value == "NT AUTHORITY\\SYSTEM")
					{
						FileSystemAccessRule fileSystemAccessRule = item2 as FileSystemAccessRule;
						if ((fileSystemAccessRule.FileSystemRights & FileSystemRights.ExecuteFile) == FileSystemRights.ExecuteFile && fileSystemAccessRule.AccessControlType == AccessControlType.Deny)
						{
							result = false;
							break;
						}
					}
				}
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

	public static bool SelectFileSecurity(string path)
	{
		bool result = true;
		try
		{
			TokenManipulator.AddPrivilege("SeRestorePrivilege");
			TokenManipulator.AddPrivilege("SeBackupPrivilege");
			TokenManipulator.AddPrivilege("SeTakeOwnershipPrivilege");
			if (File.Exists(path))
			{
				FileInfo fileInfo = new FileInfo(path);
				FileSecurity accessControl = fileInfo.GetAccessControl();
				AuthorizationRuleCollection accessRules = accessControl.GetAccessRules(includeExplicit: true, includeInherited: false, typeof(NTAccount));
				foreach (AuthorizationRule item in accessRules)
				{
					if (item.IdentityReference.Value == "NT AUTHORITY\\SYSTEM")
					{
						FileSystemAccessRule fileSystemAccessRule = item as FileSystemAccessRule;
						if ((fileSystemAccessRule.FileSystemRights & FileSystemRights.ReadAndExecute) == FileSystemRights.ReadAndExecute && fileSystemAccessRule.AccessControlType == AccessControlType.Deny)
						{
							result = false;
							break;
						}
					}
				}
			}
			else
			{
				result = false;
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

	public static bool SelectFileSecurity_sysdeny(string path)
	{
		bool flag = true;
		bool flag2 = true;
		try
		{
			TokenManipulator.AddPrivilege("SeRestorePrivilege");
			TokenManipulator.AddPrivilege("SeBackupPrivilege");
			TokenManipulator.AddPrivilege("SeTakeOwnershipPrivilege");
			if (File.Exists(path))
			{
				FileInfo fileInfo = new FileInfo(path);
				FileSecurity fileSecurity = null;
				try
				{
					fileSecurity = fileInfo.GetAccessControl();
				}
				catch (UnauthorizedAccessException)
				{
					ExecuteCommandSync("takeown /F " + path + " /A");
					Thread.Sleep(1000);
					fileSecurity = fileInfo.GetAccessControl();
				}
				AuthorizationRuleCollection accessRules = fileSecurity.GetAccessRules(includeExplicit: true, includeInherited: false, typeof(NTAccount));
				foreach (AuthorizationRule item in accessRules)
				{
					if (item.IdentityReference.Value == "NT AUTHORITY\\SYSTEM")
					{
						FileSystemAccessRule fileSystemAccessRule = item as FileSystemAccessRule;
						if ((fileSystemAccessRule.FileSystemRights & FileSystemRights.ReadAndExecute) == FileSystemRights.ReadAndExecute && fileSystemAccessRule.AccessControlType == AccessControlType.Deny)
						{
							flag = false;
						}
					}
					else if (item.IdentityReference.Value == "BUILTIN\\Administrators")
					{
						FileSystemAccessRule fileSystemAccessRule = item as FileSystemAccessRule;
						if ((fileSystemAccessRule.FileSystemRights & FileSystemRights.ReadAndExecute) == FileSystemRights.ReadAndExecute && fileSystemAccessRule.AccessControlType == AccessControlType.Deny)
						{
							flag2 = false;
						}
					}
				}
			}
			else
			{
				flag = false;
				flag2 = false;
			}
			return flag || flag2;
		}
		finally
		{
			TokenManipulator.RemovePrivilege("SeRestorePrivilege");
			TokenManipulator.RemovePrivilege("SeBackupPrivilege");
			TokenManipulator.RemovePrivilege("SeTakeOwnershipPrivilege");
		}
	}

	public static bool ExplorerExecuteSecurity(string exename, int mode)
	{
		bool flag = false;
		RegistryKey registryKey = null;
		RegistryKey registryKey2 = null;
		string text = "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer";
		string subkey = "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\disallowrun";
		registryKey = Registry.CurrentUser.OpenSubKey(SepaString(text), RegistryKeyPermissionCheck.ReadWriteSubTree);
		if (registryKey == null)
		{
			registryKey = Registry.CurrentUser.CreateSubKey(text);
		}
		if (registryKey2 == null)
		{
			registryKey2 = Registry.CurrentUser.CreateSubKey(subkey);
		}
		int num = (int)registryKey.GetValue("disallowrun", 0);
		if (num != 1)
		{
			registryKey.SetValue("disallowrun", 1);
		}
		string[] valueNames = registryKey2.GetValueNames();
		string value = exename.ToLower();
		for (int i = 0; i < valueNames.Length; i++)
		{
			string text2 = registryKey2.GetValue(valueNames[i])!.ToString()!.ToLower();
			if (text2.Equals(value))
			{
				if (mode != 2)
				{
					flag = true;
					break;
				}
				registryKey2.DeleteValue(valueNames[i]);
			}
		}
		if (mode == 1 && !flag)
		{
			bool flag2 = true;
			string text3 = "0";
			int i = 1;
			while (flag2 && i <= valueNames.Length + 1)
			{
				text3 = string.Concat(i);
				flag2 = false;
				for (int j = 0; j < valueNames.Length; j++)
				{
					if (valueNames[j] == text3)
					{
						flag2 = true;
						break;
					}
				}
				i++;
			}
			string name = text3;
			registryKey2.SetValue(name, exename);
			registryKey2.Close();
			registryKey2 = null;
		}
		return flag;
	}

	public static string GetMyRecentFolder()
	{
		if (m_GetMyRecentFolder == null)
		{
			m_GetMyRecentFolder = Environment.GetFolderPath(Environment.SpecialFolder.Recent);
			if (!Directory.Exists(m_GetMyRecentFolder))
			{
				Directory.CreateDirectory(m_GetMyRecentFolder);
			}
		}
		return m_GetMyRecentFolder;
	}

	public static string GetSystemFileName(string onlyFileName)
	{
		string text = "";
		text = Environment.GetFolderPath(Environment.SpecialFolder.SystemX86) + SEPA + onlyFileName;
		if (!File.Exists(text) && Environment.Is64BitOperatingSystem)
		{
			text = Environment.GetFolderPath(Environment.SpecialFolder.System) + SEPA + onlyFileName;
		}
		return text;
	}

	public static bool FindFireWallAllow(string onlyFileName)
	{
		return RegiHelperSrc.FindFireWallAllow(onlyFileName);
	}

	public static bool FindFireWallBlock(string onlyFileName)
	{
		return RegiHelperSrc.FindFireWallBlock(onlyFileName);
	}

	public static string getParamValue(string[] args, string strParam, string strDefault)
	{
		string result = strDefault;
		if (string.IsNullOrEmpty(strParam))
		{
			throw new Exception("2th Augement must be not null or empty in [getParamValue] Method");
		}
		for (int i = 1; i < args.Length; i++)
		{
			if (args[i].StartsWith(strParam, StringComparison.OrdinalIgnoreCase))
			{
				result = args[i].Substring(strParam.Length);
				break;
			}
		}
		return result;
	}

	public static string SepaString(string str)
	{
		if (SEPA == "\\")
		{
			return str;
		}
		return str.Replace("\\", SEPA);
	}

	public static FileInfo[] strToFileInfoes(string[] p)
	{
		List<FileInfo> list = new List<FileInfo>();
		for (int i = 0; i < p.Length; i++)
		{
			list.Add(new FileInfo(p[i]));
		}
		return list.ToArray();
	}

	public static string Now()
	{
		return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ");
	}

	public static int SetFireWallOutBlock(string strKey, string strApp)
	{
		int cnt = 0;
		string strFireWallVersion = "v2.10";
		strFireWallVersion = RegiHelperSrc.Instance.GetFireWallVersion(strFireWallVersion);
		RegistryKey regKey = Registry.LocalMachine.OpenSubKey(SepaString("SYSTEM\\CurrentControlSet\\services\\SharedAccess\\Parameters\\FirewallPolicy\\FirewallRules"), RegistryKeyPermissionCheck.ReadWriteSubTree);
		if (regKey != null)
		{
			strApp = strApp.Replace("\"", "");
			if (strApp.ToLower() != "c:\\windows\\system32\\svchost.exe")
			{
				try
				{
					if (-1 < strApp.IndexOf(":" + SEPA))
					{
						string onlyFileName = new FileInfo(strApp).Name;
						string text = regKey.GetValue(strKey, "")!.ToString();
						bool flag = false;
						bool flag2;
						if (0 == text.Length)
						{
							flag2 = true;
						}
						else
						{
							string text2 = text.ToLower();
							if (-1 < text2.IndexOf("not"))
							{
								flag = true;
							}
							flag2 = false;
						}
						if (!flag && flag2)
						{
							string text3 = onlyFileName.ToLower();
							bool isMsMpGroupCritical = false;
							if (text3.CompareTo("ConfigSecurityPolicy.exe".ToLower()) == 0 || text3.CompareTo("MpCmdRun.exe".ToLower()) == 0 || text3.CompareTo("MsMpEng.exe".ToLower()) == 0)
							{
								isMsMpGroupCritical = true;
							}
							Action action = delegate
							{
								try
								{
									if (!isMsMpGroupCritical)
									{
										regKey.SetValue(strKey, strFireWallVersion + "|Action=Block|Active=TRUE|Dir=Out|App=" + strApp + "|Name=Deny " + onlyFileName + " Out|");
									}
									else
									{
										regKey.SetValue(strKey, strFireWallVersion + "|Action=Block|Active=FALSE|Dir=Out|App=" + strApp + "|Name=Not Deny " + onlyFileName + " Out|");
										RegiHelperSrc.Instance.AppApprovalColor = true;
									}
								}
								catch (Exception)
								{
								}
								cnt++;
							};
							((DispatcherObject)PowerDeskApp2014.Instance).get_Dispatcher().Invoke((Delegate)action, new object[0]);
						}
					}
					else
					{
						string text = regKey.GetValue(strKey, "")!.ToString();
						bool flag = false;
						bool flag2;
						if (0 == text.Length)
						{
							if (-1 < text.IndexOf("Not"))
							{
								flag = true;
							}
							flag2 = true;
						}
						else
						{
							flag2 = false;
						}
						if (!flag && Regex.IsMatch(strApp, "[\\d]{1,3}\\.[\\d]{1,3}\\.[\\d]{1,3}\\.[\\d]{1,3}") && -1 == strApp.ToLower().IndexOf("ConfigSecurityPolicy.exe".ToLower()))
						{
							regKey.SetValue(strKey, strFireWallVersion + "|Action=Block|Active=TRUE|Dir=Out|Protocol=6|RA4=" + strApp + "|Name=Deny " + strApp + "|");
							if (flag2)
							{
								string strMsg = "방화벽 차단 정책을 추가하였습니다. [IP: " + strApp + "] Out Block";
								MessageBoxTimerClose messageBoxTimerClose = new MessageBoxTimerClose(strMsg);
								((Window)messageBoxTimerClose).ShowDialog();
								((Window)messageBoxTimerClose).Close();
								cnt++;
							}
						}
					}
				}
				catch (Exception)
				{
					string strMsg = "[" + strApp + "] 경로가 잘못되었습니다. SetFireWallOutBlock";
					MessageBoxTimerClose messageBoxTimerClose = new MessageBoxTimerClose(strMsg);
					((Window)messageBoxTimerClose).ShowDialog();
					((Window)messageBoxTimerClose).Close();
				}
			}
			else
			{
				string strMsg = "방화벽 차단 할 수 없는 파일입니다. [" + strApp + "]";
				MessageBoxTimerClose messageBoxTimerClose = new MessageBoxTimerClose(strMsg);
				((Window)messageBoxTimerClose).ShowDialog();
				((Window)messageBoxTimerClose).Close();
			}
		}
		return cnt;
	}

	public static void RemoveFireWallOutBlock(string strKey)
	{
		string strDefault = "v2.10";
		strDefault = RegiHelperSrc.Instance.GetFireWallVersion(strDefault);
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(SepaString("SYSTEM\\CurrentControlSet\\services\\SharedAccess\\Parameters\\FirewallPolicy\\FirewallRules"), RegistryKeyPermissionCheck.ReadWriteSubTree);
		if (registryKey != null)
		{
			string text = registryKey.GetValue(strKey, "")!.ToString();
			if (0 < text.Length)
			{
				registryKey.DeleteValue(strKey);
				alert("방화벽 차단 정책을 지웠습니다.");
			}
			else
			{
				alert("PowerHealthChecker에서 관리되는 방화벽 정책만 지울수 있습니다.");
			}
		}
	}

	public static void RemoveFireWallInBlock(string strKeyName)
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(SepaString("SYSTEM\\CurrentControlSet\\services\\SharedAccess\\Parameters\\FirewallPolicy\\FirewallRules"), RegistryKeyPermissionCheck.ReadWriteSubTree);
		if (registryKey != null)
		{
			string text = registryKey.GetValue(strKeyName, "")!.ToString();
			if (0 < text.Length)
			{
				registryKey.DeleteValue(strKeyName);
			}
		}
	}

	public static int SetFireWallInBlock(string strKey, string strApp)
	{
		int num = 0;
		string strDefault = "v2.10";
		strDefault = RegiHelperSrc.Instance.GetFireWallVersion(strDefault);
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(SepaString("SYSTEM\\CurrentControlSet\\services\\SharedAccess\\Parameters\\FirewallPolicy\\FirewallRules"), RegistryKeyPermissionCheck.ReadWriteSubTree);
		if (registryKey != null)
		{
			string name = new FileInfo(strApp).Name;
			string text = registryKey.GetValue(strKey, "")!.ToString();
			bool flag = false;
			bool flag2;
			if (0 == text.Length)
			{
				if (-1 < text.IndexOf("Not"))
				{
					flag = true;
				}
				flag2 = true;
			}
			else
			{
				flag2 = false;
			}
			if (!flag)
			{
				registryKey.SetValue(strKey, strDefault + "|Action=Block|Active=TRUE|Dir=In|App=" + strApp + "|Name=Deny " + name + " In|");
				if (flag2)
				{
					string strMsg = "방화벽 차단 정책을 추가하였습니다. [" + name + "] In Block";
					MessageBoxTimerClose messageBoxTimerClose = new MessageBoxTimerClose(strMsg);
					((Window)messageBoxTimerClose).ShowDialog();
					((Window)messageBoxTimerClose).Close();
					num++;
				}
			}
		}
		return num;
	}

	public static string GetComputerName()
	{
		return Dns.GetHostName();
	}

	public static string GetMainModuleFilepath(int processId)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		string text = "SELECT ProcessId, ExecutablePath FROM Win32_Process WHERE ProcessId = " + processId;
		ManagementObjectSearcher val = new ManagementObjectSearcher(text);
		try
		{
			ManagementObjectCollection val2 = val.Get();
			try
			{
				ManagementObject val3 = ((IEnumerable)val2).Cast<ManagementObject>().FirstOrDefault();
				if (val3 != null)
				{
					return (string)((ManagementBaseObject)val3).get_Item("ExecutablePath");
				}
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		return null;
	}

	public static string GetCurrentProcessFileFullNameLowercase()
	{
		if (m_GetCurrentProcessFileFullNameLowercase == null)
		{
			m_GetCurrentProcessFileFullNameLowercase = Process.GetCurrentProcess().MainModule!.FileName!.ToLower();
		}
		return m_GetCurrentProcessFileFullNameLowercase;
	}

	public static string GetWMIOSInstallDate()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		string text = "";
		ManagementObjectSearcher val = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				text = ((ManagementBaseObject)val2).GetPropertyValue("InstallDate").ToString();
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		if (0 < text.Length)
		{
			text = text.SafeSubstring(0, 4) + "-" + text.SafeSubstring(4, 2) + "-" + text.SafeSubstring(6, 2);
		}
		return text;
	}

	public static string GetDfrgDateTime()
	{
		string result = "";
		byte[] array = null;
		array = GetMaxDfrgDateTime();
		if (array != null && array.Length == 16)
		{
			result = new DateTime(array[0] + array[1] * 256, array[2], array[6]).ToString("yyyyMMdd");
		}
		return result;
	}

	public static byte[] GetMaxDfrgDateTime()
	{
		byte[] result = null;
		byte[] array = null;
		DateTime dateTime = DateTime.MinValue;
		DateTime minValue = DateTime.MinValue;
		RegistryKey registryKey = null;
		RegistryKey registryKey2 = null;
		string[] array2 = null;
		registryKey = Registry.LocalMachine.OpenSubKey(SepaString("SOFTWARE\\Microsoft\\Dfrg\\Statistics"));
		if (registryKey != null)
		{
			array2 = registryKey.GetSubKeyNames();
			for (int i = 0; i < array2.Length; i++)
			{
				registryKey2 = registryKey.OpenSubKey(array2[i]);
				array = registryKey2.GetValue("LastRunTime") as byte[];
				if (i == 0)
				{
					result = array;
					if (0 < array[0] + array[1] * 256)
					{
						dateTime = new DateTime(array[0] + array[1] * 256, array[2], array[6]);
					}
				}
				else if (0 < array[0] + array[1] * 256)
				{
					minValue = new DateTime(array[0] + array[1] * 256, array[2], array[6]);
					if (dateTime < minValue)
					{
						dateTime = minValue;
						result = array;
					}
				}
			}
		}
		if (dateTime == DateTime.MinValue)
		{
			result = null;
		}
		return result;
	}

	public static bool isServiceExists(string svc_nm)
	{
		bool result = false;
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(SepaString("SYSTEM\\CurrentControlSet\\services"));
		string[] subKeyNames = registryKey.GetSubKeyNames();
		string strB = svc_nm.ToLower();
		for (int i = 0; i < subKeyNames.Length; i++)
		{
			string text = subKeyNames[i].ToLower();
			if (text.CompareTo(strB) == 0)
			{
				result = true;
				break;
			}
		}
		registryKey.Close();
		registryKey = null;
		return result;
	}

	public static bool isServiceUse(string p)
	{
		return !IsServiceDisabled(p);
	}

	public static bool IsServiceDisabled(string p)
	{
		bool result = true;
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\services\\" + p);
		int num = 0;
		if (registryKey != null)
		{
			string text = registryKey.GetValue("ImagePath", "")!.ToString();
			if (-1 < text.IndexOf("svchost.exe") && -1 < text.IndexOf("system32") && p != "wuauserv" && !CNativeWIN32.IsWindows7())
			{
				result = true;
			}
			else
			{
				num = Convert.ToInt32(registryKey.GetValue("Start", 0));
				if (num == 4)
				{
					result = true;
				}
				else if (Convert.ToInt32(registryKey.GetValue("Start_lock", 0)) != 1)
				{
					result = false;
					RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\services\\" + p, RegistryKeyPermissionCheck.ReadWriteSubTree);
					registryKey2.SetValue("Start_bak", num);
				}
			}
		}
		return result;
	}

	internal static string onlyFileName(string p)
	{
		string text = "";
		int num = -1;
		num = p.LastIndexOf(SEPA);
		if (-1 < num)
		{
			return p.Substring(num + 1);
		}
		return p;
	}

	internal static string onlyFileNameEx(string p)
	{
		string text = "";
		int num = -1;
		num = p.LastIndexOf(SEPA);
		if (-1 < num)
		{
			return p.Substring(num + 1);
		}
		return p;
	}

	internal static string getFileExt(string f)
	{
		string result = "";
		int num = f.LastIndexOf(".");
		int num2 = f.LastIndexOf(SEPA);
		if (num2 < num)
		{
			result = f.Substring(num);
		}
		return result;
	}

	internal static void saveToLog(string str, string str2)
	{
		File.WriteAllText(RegiHelperSrc.Instance.logPath + DateTime.Now.ToString("MMdd_hhmmss") + "_" + str2 + ".txt", str);
	}

	internal static bool ExistPathLocalWindowsapps()
	{
		bool flag = false;
		try
		{
			string text = Environment.GetEnvironmentVariable("Path", EnvironmentVariableTarget.User)!.ToLower();
			string text2 = Environment.GetEnvironmentVariable("Path", EnvironmentVariableTarget.Machine)!.ToLower();
			string value = "%userprofile%\\appdata\\local\\microsoft\\windowsapps";
			string text3 = Environment.GetEnvironmentVariable("userprofile")!.ToLower() + "\\appdata\\local\\microsoft\\windowsapps";
			if (!(flag = -1 < text.IndexOf(value) || -1 < text.IndexOf(text3)))
			{
				flag = -1 < text2.IndexOf(value) || -1 < text2.IndexOf(text3);
			}
			if (!flag)
			{
				return Directory.Exists(text3);
			}
			return flag;
		}
		catch (Exception)
		{
			return false;
		}
	}

	internal static void SolveVaccine53(bool value)
	{
		if (value)
		{
			string environmentVariable = Environment.GetEnvironmentVariable("Path", EnvironmentVariableTarget.User);
			string environmentVariable2 = Environment.GetEnvironmentVariable("Path", EnvironmentVariableTarget.Machine);
			string text = "%userprofile%\\appdata\\local\\microsoft\\windowsapps";
			string text2 = Environment.GetEnvironmentVariable("userprofile")!.ToLower() + "\\appdata\\local\\microsoft\\windowsapps";
			environmentVariable = ReplaceIgnoreCase(environmentVariable, text.Replace("\\", "\\\\"), "");
			environmentVariable = ReplaceIgnoreCase(environmentVariable, text2.Replace("\\", "\\\\"), "");
			environmentVariable = ReplaceIgnoreCase(environmentVariable, ";;", ";");
			environmentVariable2 = ReplaceIgnoreCase(environmentVariable2, text.Replace("\\", "\\\\"), "");
			environmentVariable2 = ReplaceIgnoreCase(environmentVariable2, text2.Replace("\\", "\\\\"), "");
			environmentVariable2 = ReplaceIgnoreCase(environmentVariable2, ";;", ";");
			Environment.SetEnvironmentVariable("Path", environmentVariable, EnvironmentVariableTarget.User);
			Environment.SetEnvironmentVariable("Path", environmentVariable2, EnvironmentVariableTarget.Machine);
			if (Directory.Exists(text2))
			{
				ExecuteCommandSync("rd /s /q \"" + text2 + "\"");
			}
		}
	}

	public static string ReplaceIgnoreCase(string strSrc, string findStrRegEx, string replaceString)
	{
		return Regex.Replace(strSrc, findStrRegEx, replaceString, RegexOptions.IgnoreCase);
	}

	internal static string cplDesc(string p)
	{
		string text = "";
		switch (p.ToLower())
		{
		case "access.cpl":
			text = "내게 필요한 옵션";
			break;
		case "appwiz.cpl":
			text = "프로그램 추가/제거";
			break;
		case "bthprops.cpl":
			text = "블루투스장치설정";
			break;
		case "desk.cpl":
			text = "디스플레이 등록정보";
			break;
		case "firewall.cpl":
			text = "Windows 방화벽";
			break;
		case "hdwwiz.cpl":
			text = "새하드웨어추가마법사";
			break;
		case "inetcpl.cpl":
			text = "인터넷 등록정보";
			break;
		case "intl.cpl":
			text = "국가 및 언어옵션";
			break;
		case "irprops.cpl":
			text = "적외선포트 설정";
			break;
		case "joy.cpl":
			text = "게임컨트롤러";
			break;
		case "main.cpl":
			text = "마우스 등록정보";
			break;
		case "mmsys.cpl":
			text = "사운드및 오디오장치 등록정보";
			break;
		case "ncpa.cpl":
			text = "네트워크 연결";
			break;
		case "netsetup.cpl":
			text = "네트워크 설정 마법사";
			break;
		case "nusrmgr.cpl":
			text = "사용자계정";
			break;
		case "nwc.cpl":
			text = "네트워크 게이트웨이";
			break;
		case "odbccp32.cpl":
			text = "ODBC 데이터원본 관리자";
			break;
		case "powercfg.cpl":
			text = " 전원옵션 등록정보";
			break;
		case "sysdm.cpl":
			text = "시스템 등록정보";
			break;
		case "telephon.cpl":
			text = "전화 및 모뎀 옵션";
			break;
		case "timedate.cpl":
			text = "날짜 및 시간 등록정보";
			break;
		case "wscui.cpl":
			text = "Windows 보안센터";
			break;
		case "wuaucpl.cpl":
			text = "자동 업데이트";
			break;
		case "sapi.cpl":
			text = "텍스트 음성 변환설정";
			break;
		case "tabletpc.cpl":
			text = "펜 및 터치";
			break;
		case "rtsnmg64.cpl":
			text = "Realtek HD Audio Sound Effect Manager";
			break;
		case "collab.cpl":
			text = "주변 사람 찾기";
			break;
		case "igfxcpl.cpl":
			text = "인텔 HD 그래픽 제어판";
			break;
		case "infocardcpl.cpl":
			text = "Windows CardSpace";
			break;
		case "inprops.cpl":
			text = "적외선 포트 설정";
			break;
		case "javacpl.cpl":
			text = "Java 제어판";
			break;
		}
		return "  " + text;
	}

	internal static string mscDesc(string p)
	{
		string text = "";
		switch (p.ToLower())
		{
		case "eventvwr.msc":
			text = "이벤트 뷰어";
			break;
		case "diskmgmt.msc":
			text = "디스크 관리";
			break;
		case "lusrmgr.msc":
			text = "로컬 사용자 및 그룹";
			break;
		case "wf.msc":
			text = "Windows 방화벽(고급설정)";
			break;
		case "devmgmt.msc":
			text = "장치 관리자";
			break;
		case "gpedit.msc":
			text = "로컬 그룹 정책 편집기";
			break;
		case "perfmon.msc":
			text = "성능 모니터";
			break;
		case "compmgmt.msc":
			text = "컴퓨터 관리";
			break;
		case "azman.msc":
			text = "권한 부여 관리자";
			break;
		case "certlm.msc":
			text = "인증서 관리(전역)";
			break;
		case "certmgr.msc":
			text = "인증서 관리(" + getUSERNAME() + "용)";
			break;
		case "comexp.msc":
			text = "구성요소 서비스";
			break;
		case "fsmgmt.msc":
			text = "공유폴더";
			break;
		case "napclcfg.msc":
			text = "NAP클라이언트 구성";
			break;
		case "printmanagement.msc":
			text = "인쇄 관리";
			break;
		case "rsop.msc":
			text = "정책 결과 집합";
			break;
		case "secpol.msc":
			text = "로컬 보안 정책";
			break;
		case "services.msc":
			text = "서비스";
			break;
		case "taskschd.msc":
			text = "작업스케줄러";
			break;
		case "tpm.msc":
			text = "로컬컴퓨터의 TPM 관리";
			break;
		case "wmimgmt.msc":
			text = "콘솔루트 WMI컨트롤";
			break;
		case "dfrg.msc":
			text = "디스크 조각모음";
			break;
		case "dfsgui.msc":
			text = "분산 파일 시스템";
			break;
		case "dhcpmgmt.msc":
			text = "DHCP 관리화면";
			break;
		case "domain.msc":
			text = "Domain and Trusts";
			break;
		case "tapimgmt.msc":
			text = "Telephony";
			break;
		case "dompol.msc":
			text = "Domain 보안 정책";
			break;
		case "dsa.msc":
			text = "Active Directory users and computers";
			break;
		case "dssite.msc":
			text = "Active Directory Sites and Services";
			break;
		case "faxserv.msc":
			text = "팩스 서비스 관리";
			break;
		case "ias.msc":
			text = "Internet Authentification System 관리";
			break;
		case "iis.msc":
			text = "Internet Information Services";
			break;
		case "msinfo32.msc":
			text = "시스템 정보";
			break;
		case "ntmsmgr.msc":
			text = "Removable Storage";
			break;
		case "ntmsoprq.msc":
			text = "Removable Storage Operator Requests";
			break;
		case "rrasmgmt.msc":
			text = "Routing and Remote Access";
			break;
		case "tscc.msc":
			text = "Terminal Services Configuration";
			break;
		case "dcpol.msc":
			text = "도메인 컨트롤러 보안 정책";
			break;
		case "ciadv.msc":
			text = "인덱스 서비스";
			break;
		case "acssnap.msc":
			text = "QoS 관리자 콘솔";
			break;
		case "dnsmgmt.msc":
			text = "DNS 관리자";
			break;
		case "wbadmin.msc":
			text = "Windows Server 백업(로컬)";
			break;
		case "wlbadmin.msc":
			text = "로컬 백업(로컬)";
			break;
		case "sqlservermanager10.msc":
			text = "SQL 서버 매니저(2008R2)";
			break;
		case "sqlservermanager11.msc":
			text = "SQL 서버 매니저(2012)";
			break;
		case "sqlservermanager12.msc":
			text = "SQL 서버 매니저(2014)";
			break;
		case "sqlservermanager13.msc":
			text = "SQL 서버 매니저(2016)";
			break;
		case "sqlservermanager14.msc":
			text = "SQL 서버 매니저(2017)";
			break;
		case "sqlservermanager15.msc":
			text = "SQL 서버 매니저";
			break;
		}
		return p + " [" + text + "]";
	}

	internal static bool ProtectTemp3582FolderVulnerable(int get_set, bool protect)
	{
		bool result = true;
		string text = Environment.GetEnvironmentVariable("userprofile")!.ToLower();
		string text2 = text + "\\AppData\\Local\\Temp\\3582-490";
		if (!Directory.Exists(text2) && !File.Exists(text2) && get_set == 0)
		{
			result = true;
		}
		else
		{
			string text3 = ExecuteCommandSync("icacls \"" + text2 + "\"");
			string[] array = text3.Replace("\n", "\r").Replace("\r\r", "\r").Split(new char[1] { '\r' });
			for (int i = 0; i < array.Count(); i++)
			{
				if (-1 < array[i].IndexOf("Everyone:(OI)(CI)(DENY)(S,X)"))
				{
					result = false;
					break;
				}
			}
			if (get_set == 1)
			{
				string text4 = "";
				text4 = Environment.GetEnvironmentVariable("username");
				if (protect)
				{
					if (!Directory.Exists(text2) && !File.Exists(text2))
					{
						Directory.CreateDirectory(text2);
						text3 = ExecuteCommandSync("attrib +s +h +r \"" + text + "\"");
					}
					text3 = ExecuteCommandSync("TAKEOWN /F \"" + text2 + "\" " + text4);
					Thread.Sleep(100);
					text3 = ExecuteCommandSync("attrib +s +h +r \"" + text + "\"");
					Thread.Sleep(100);
					text3 = ExecuteCommandSync("icacls \"" + text2 + "\" /deny SYSTEM:(OI)(CI)(X)");
					text3 = ExecuteCommandSync("icacls \"" + text2 + "\" /deny Everyone:(OI)(CI)(X)");
					Thread.Sleep(100);
				}
				else if (Directory.Exists(text2) || File.Exists(text2))
				{
					text3 = ExecuteCommandSync("TAKEOWN /F \"" + text2 + "\" " + text4);
					Thread.Sleep(100);
					text3 = ExecuteCommandSync("icacls \"" + text2 + "\" /remove:d SYSTEM");
					text3 = ExecuteCommandSync("icacls \"" + text2 + "\" /remove:d Everyone");
					Thread.Sleep(100);
					text3 = ExecuteCommandSync("attrib -s -h -r \"" + text + "\"");
					Thread.Sleep(100);
				}
			}
		}
		return result;
	}

	internal static void SolveVaccine54(bool value)
	{
		ProtectTemp3582FolderVulnerable(1, value);
	}

	internal static bool SolvedProblem55()
	{
		bool result = false;
		string name = "SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Power";
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(name, writable: false);
		string name2 = "HiberbootEnabled";
		if (registryKey != null)
		{
			object value = registryKey.GetValue(name2, "0");
			double num = ToDouble(value.ToString());
			if (num == 0.0)
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

	internal static void SolveVaccine55(bool value)
	{
		string name = "SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Power";
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(name, RegistryKeyPermissionCheck.ReadWriteSubTree);
		string name2 = "HiberbootEnabled";
		if (registryKey != null)
		{
			if (value)
			{
				registryKey.SetValue(name2, 0);
			}
			else
			{
				registryKey.SetValue(name2, 1);
			}
			registryKey.Close();
		}
	}

	public static double ToDouble(string strValue, double p = 0.0)
	{
		double result = p;
		if (!double.TryParse(strValue, NumberStyles.Any, CultureInfo.CurrentCulture, out result) && !double.TryParse(strValue, NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out result) && !double.TryParse(strValue, NumberStyles.Any, CultureInfo.InvariantCulture, out result))
		{
			result = p;
		}
		return result;
	}

	public static string ExecuteCommandSync2(string command, string param, bool showError = false, bool bRedirect = true)
	{
		string result = null;
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo(command, param);
			processStartInfo.RedirectStandardOutput = bRedirect;
			processStartInfo.UseShellExecute = false;
			processStartInfo.CreateNoWindow = true;
			processStartInfo.WorkingDirectory = Environment.GetEnvironmentVariable("windir") + SEPA + "system32";
			Process process = new Process();
			process.StartInfo = processStartInfo;
			process.Start();
			if (bRedirect)
			{
				StringBuilder stringBuilder = new StringBuilder();
				StreamReader standardOutput = process.StandardOutput;
				char[] array = new char[1024];
				int num = 0;
				while (!standardOutput.EndOfStream)
				{
					if (0 < num)
					{
						string value = new string(array, 0, num);
						stringBuilder.Append(value);
					}
					num = standardOutput.Read(array, 0, 1024);
				}
				if (0 < num)
				{
					string value = new string(array, 0, num);
					stringBuilder.Append(value);
				}
				result = stringBuilder.ToString();
			}
			else
			{
				process.WaitForExit();
			}
			return result;
		}
		catch (Exception ex)
		{
			if (showError)
			{
				alert(ex.Message + "\n" + ex.StackTrace);
			}
		}
		return result;
	}

	public static void allRunZisable2(string svc_name)
	{
		doAllRunDisabled(svc_name);
	}

	public static void doAllRunDisabled(string p)
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", RegistryKeyPermissionCheck.ReadWriteSubTree);
		if (registryKey != null)
		{
			string value = registryKey.GetValue(p, null) as string;
			RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\AutorunsDisabled", RegistryKeyPermissionCheck.ReadWriteSubTree);
			if (registryKey2 == null)
			{
				registryKey2 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\AutorunsDisabled");
			}
			registryKey2.SetValue(p, value);
			registryKey.DeleteValue(p);
		}
	}

	public static void userRunZisable2(string svc_name)
	{
		doUserRunDisabled(svc_name);
	}

	public static void doUserRunDisabled(string p)
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", RegistryKeyPermissionCheck.ReadWriteSubTree);
		if (registryKey != null)
		{
			string value = registryKey.GetValue(p, null) as string;
			RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\AutorunsDisabled", RegistryKeyPermissionCheck.ReadWriteSubTree);
			if (registryKey2 == null)
			{
				registryKey2 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\AutorunsDisabled");
			}
			registryKey2.SetValue(p, value);
			registryKey.DeleteValue(p);
		}
		registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", RegistryKeyPermissionCheck.ReadWriteSubTree);
		if (registryKey != null)
		{
			string value = registryKey.GetValue(p, null) as string;
			RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\AutorunsDisabled", RegistryKeyPermissionCheck.ReadWriteSubTree);
			if (registryKey2 == null)
			{
				registryKey2 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\AutorunsDisabled");
			}
			registryKey2.SetValue(p, value);
			registryKey.DeleteValue(p);
		}
		registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\Run", RegistryKeyPermissionCheck.ReadWriteSubTree);
		if (registryKey != null)
		{
			string value = registryKey.GetValue(p, null) as string;
			RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\Run\\AutorunsDisabled", RegistryKeyPermissionCheck.ReadWriteSubTree);
			if (registryKey2 == null)
			{
				registryKey2 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\Run\\AutorunsDisabled");
			}
			registryKey2.SetValue(p, value);
			registryKey.DeleteValue(p);
		}
	}

	internal static bool SolvedMicAvailabilityProblem()
	{
		if (CNativeWIN32.isWindows10)
		{
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			string name = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\microphone";
			string name2 = "Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\microphone";
			string name3 = "SOFTWARE\\Policies\\Microsoft\\Windows\\AppPrivacy";
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(name, RegistryKeyPermissionCheck.ReadWriteSubTree);
			string name4 = "Value";
			if (registryKey != null)
			{
				string strA = registryKey.GetValue(name4, "") as string;
				if (string.Compare(strA, "Allow", StringComparison.OrdinalIgnoreCase) == 0)
				{
					flag = true;
				}
				registryKey.Close();
				registryKey.Dispose();
				registryKey = null;
			}
			else
			{
				flag = false;
			}
			registryKey = Registry.CurrentUser.OpenSubKey(name2, writable: false);
			if (registryKey != null)
			{
				string strA = registryKey.GetValue(name4, "") as string;
				if (string.Compare(strA, "Allow", StringComparison.OrdinalIgnoreCase) == 0)
				{
					flag2 = true;
				}
				registryKey.Close();
				registryKey.Dispose();
				registryKey = null;
			}
			else
			{
				flag2 = false;
			}
			flag3 = true;
			registryKey = Registry.LocalMachine.OpenSubKey(name3, writable: false);
			if (registryKey != null)
			{
				string[] valueNames = registryKey.GetValueNames();
				for (int i = 0; i < valueNames.Length; i++)
				{
					if (string.Compare(valueNames[i], "LetAppsAccessMicrophone", StringComparison.OrdinalIgnoreCase) == 0 || string.Compare(valueNames[i], "LetAppsAccessMicrophone_UserInControlOfTheseApps", StringComparison.OrdinalIgnoreCase) == 0 || string.Compare(valueNames[i], "LetAppsAccessMicrophone_ForceAllowTheseApps", StringComparison.OrdinalIgnoreCase) == 0 || string.Compare(valueNames[i], "LetAppsAccessMicrophone_ForceDenyTheseApps", StringComparison.OrdinalIgnoreCase) == 0)
					{
						flag3 = false;
						break;
					}
				}
				registryKey.Close();
				registryKey.Dispose();
				registryKey = null;
			}
			else
			{
				flag3 = true;
			}
			return flag && flag2 && flag3;
		}
		return true;
	}

	internal static void DoSolveMicAvailability()
	{
		string text = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\microphone";
		string text2 = "Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\microphone";
		string name = "SOFTWARE\\Policies\\Microsoft\\Windows\\AppPrivacy";
		string name2 = "Value";
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(text, RegistryKeyPermissionCheck.ReadWriteSubTree);
		if (registryKey == null)
		{
			registryKey = Registry.LocalMachine.CreateSubKey(text);
		}
		if (registryKey != null)
		{
			registryKey.SetValue(name2, "Allow");
			registryKey.Close();
			registryKey.Dispose();
			registryKey = null;
		}
		registryKey = Registry.CurrentUser.OpenSubKey(text2, RegistryKeyPermissionCheck.ReadWriteSubTree);
		if (registryKey == null)
		{
			registryKey = Registry.CurrentUser.CreateSubKey(text2);
		}
		if (registryKey != null)
		{
			registryKey.SetValue(name2, "Allow");
			registryKey.Close();
			registryKey.Dispose();
			registryKey = null;
		}
		registryKey = Registry.LocalMachine.OpenSubKey(name, RegistryKeyPermissionCheck.ReadWriteSubTree);
		if (registryKey == null)
		{
			return;
		}
		string[] valueNames = registryKey.GetValueNames();
		for (int i = 0; i < valueNames.Length; i++)
		{
			if (string.Compare(valueNames[i], "LetAppsAccessMicrophone", StringComparison.OrdinalIgnoreCase) == 0 || string.Compare(valueNames[i], "LetAppsAccessMicrophone_UserInControlOfTheseApps", StringComparison.OrdinalIgnoreCase) == 0 || string.Compare(valueNames[i], "LetAppsAccessMicrophone_ForceAllowTheseApps", StringComparison.OrdinalIgnoreCase) == 0 || string.Compare(valueNames[i], "LetAppsAccessMicrophone_ForceDenyTheseApps", StringComparison.OrdinalIgnoreCase) == 0)
			{
				registryKey.DeleteValue(valueNames[i]);
			}
		}
		registryKey.Close();
		registryKey.Dispose();
		registryKey = null;
	}

	internal static bool SolvedCamAvailabilityProblem()
	{
		if (CNativeWIN32.isWindows10)
		{
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			string name = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\microphone";
			string name2 = "Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\microphone";
			string name3 = "SOFTWARE\\Policies\\Microsoft\\Windows\\AppPrivacy";
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(name, RegistryKeyPermissionCheck.ReadWriteSubTree);
			string name4 = "Value";
			if (registryKey != null)
			{
				string strA = registryKey.GetValue(name4, "") as string;
				if (string.Compare(strA, "Allow", StringComparison.OrdinalIgnoreCase) == 0)
				{
					flag = true;
				}
				registryKey.Close();
				registryKey.Dispose();
				registryKey = null;
			}
			else
			{
				flag = false;
			}
			registryKey = Registry.CurrentUser.OpenSubKey(name2, writable: false);
			if (registryKey != null)
			{
				string strA = registryKey.GetValue(name4, "") as string;
				if (string.Compare(strA, "Allow", StringComparison.OrdinalIgnoreCase) == 0)
				{
					flag2 = true;
				}
				registryKey.Close();
				registryKey.Dispose();
				registryKey = null;
			}
			else
			{
				flag2 = false;
			}
			flag3 = true;
			registryKey = Registry.LocalMachine.OpenSubKey(name3, writable: false);
			if (registryKey != null)
			{
				string[] valueNames = registryKey.GetValueNames();
				for (int i = 0; i < valueNames.Length; i++)
				{
					if (string.Compare(valueNames[i], "LetAppsAccessMicrophone", StringComparison.OrdinalIgnoreCase) == 0 || string.Compare(valueNames[i], "LetAppsAccessMicrophone_UserInControlOfTheseApps", StringComparison.OrdinalIgnoreCase) == 0 || string.Compare(valueNames[i], "LetAppsAccessMicrophone_ForceAllowTheseApps", StringComparison.OrdinalIgnoreCase) == 0 || string.Compare(valueNames[i], "LetAppsAccessMicrophone_ForceDenyTheseApps", StringComparison.OrdinalIgnoreCase) == 0)
					{
						flag3 = false;
						break;
					}
				}
				registryKey.Close();
				registryKey.Dispose();
				registryKey = null;
			}
			else
			{
				flag3 = true;
			}
			return flag && flag2 && flag3;
		}
		return true;
	}

	internal static void DoSolveCamAvailability()
	{
		string text = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\webcam";
		string text2 = "Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\webcam";
		string name = "SOFTWARE\\Policies\\Microsoft\\Windows\\AppPrivacy";
		string name2 = "Value";
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(text, RegistryKeyPermissionCheck.ReadWriteSubTree);
		if (registryKey == null)
		{
			registryKey = Registry.LocalMachine.CreateSubKey(text);
		}
		if (registryKey != null)
		{
			registryKey.SetValue(name2, "Allow");
			registryKey.Close();
			registryKey.Dispose();
			registryKey = null;
		}
		registryKey = Registry.CurrentUser.OpenSubKey(text2, RegistryKeyPermissionCheck.ReadWriteSubTree);
		if (registryKey == null)
		{
			registryKey = Registry.CurrentUser.CreateSubKey(text2);
		}
		if (registryKey != null)
		{
			registryKey.SetValue(name2, "Allow");
			registryKey.Close();
			registryKey.Dispose();
			registryKey = null;
		}
		registryKey = Registry.LocalMachine.OpenSubKey(name, RegistryKeyPermissionCheck.ReadWriteSubTree);
		if (registryKey == null)
		{
			return;
		}
		string[] valueNames = registryKey.GetValueNames();
		for (int i = 0; i < valueNames.Length; i++)
		{
			if (string.Compare(valueNames[i], "LetAppsAccessCamera", StringComparison.OrdinalIgnoreCase) == 0 || string.Compare(valueNames[i], "LetAppsAccessCamera_UserInControlOfTheseApps", StringComparison.OrdinalIgnoreCase) == 0 || string.Compare(valueNames[i], "LetAppsAccessCamera_ForceAllowTheseApps", StringComparison.OrdinalIgnoreCase) == 0 || string.Compare(valueNames[i], "LetAppsAccessCamera_ForceDenyTheseApps", StringComparison.OrdinalIgnoreCase) == 0)
			{
				registryKey.DeleteValue(valueNames[i]);
			}
		}
		registryKey.Close();
		registryKey.Dispose();
		registryKey = null;
	}

	internal static bool AuthBiosDateCompare(string email, string ser_chr1)
	{
		bool result = false;
		string text = "";
		string text2 = "";
		string text3 = "";
		text = RegiHelperSrc.BiosDate();
		text2 = getYYYYMMDD();
		if (text == null || text.Length < 8)
		{
			text = text2;
		}
		else
		{
			text = text.Substring(0, 8);
			if (text.Length < text2.Length || text.CompareTo(text2) < 0)
			{
				Random random = new Random();
				if (Math.Ceiling(Math.Ceiling(random.NextDouble() * 100.0)) % 2.0 == 0.0)
				{
					text = text2;
				}
			}
		}
		text3 = text.Substring(0, 4) + text2.Substring(4, 4);
		switch (ser_chr1.ToUpper())
		{
		case "P":
			if (text3.CompareTo(AuthYearReplace(2023, text3)) < 0)
			{
				result = true;
			}
			break;
		case "Q":
			if (text3.CompareTo(AuthYearReplace(2025, text3)) < 0)
			{
				result = true;
			}
			break;
		case "R":
			if (text3.CompareTo(AuthYearReplace(2027, text3)) < 0)
			{
				result = true;
			}
			break;
		case "S":
			if (text3.CompareTo(AuthYearReplace(2029, text3)) < 0)
			{
				result = true;
			}
			break;
		case "T":
			if (text3.CompareTo(AuthYearReplace(2031, text3)) < 0)
			{
				result = true;
			}
			break;
		case "U":
			if (text3.CompareTo(AuthYearReplace(2033, text3)) < 0)
			{
				result = true;
			}
			break;
		case "V":
			if (text3.CompareTo(AuthYearReplace(2035, text3)) < 0)
			{
				result = true;
			}
			break;
		case "W":
			if (text3.CompareTo(AuthYearReplace(2037, text3)) < 0)
			{
				result = true;
			}
			break;
		case "X":
			if (text3.CompareTo(AuthYearReplace(2039, text3)) < 0)
			{
				result = true;
			}
			break;
		case "Z":
			if (text3.CompareTo(AuthYearReplace(2041, text3)) < 0)
			{
				result = true;
			}
			break;
		case "A":
			if (text3.CompareTo(AuthYearReplace(2043, text3)) < 0)
			{
				result = true;
			}
			break;
		case "B":
			if (text3.CompareTo(AuthYearReplace(2045, text3)) < 0)
			{
				result = true;
			}
			break;
		case "C":
			if (text3.CompareTo(AuthYearReplace(2047, text3)) < 0)
			{
				result = true;
			}
			break;
		case "D":
			if (text3.CompareTo(AuthYearReplace(2049, text3)) < 0)
			{
				result = true;
			}
			break;
		case "E":
			if (text3.CompareTo(AuthYearReplace(2051, text3)) < 0)
			{
				result = true;
			}
			break;
		case "F":
			if (text3.CompareTo(AuthYearReplace(2053, text3)) < 0)
			{
				result = true;
			}
			break;
		case "G":
			if (text3.CompareTo(AuthYearReplace(2055, text3)) < 0)
			{
				result = true;
			}
			break;
		case "H":
			if (text3.CompareTo(AuthYearReplace(2057, text3)) < 0)
			{
				result = true;
			}
			break;
		case "J":
			if (text3.CompareTo(AuthYearReplace(2059, text3)) < 0)
			{
				result = true;
			}
			break;
		case "K":
			if (text3.CompareTo(AuthYearReplace(2061, text3)) < 0)
			{
				result = true;
			}
			break;
		case "L":
			if (text3.CompareTo(AuthYearReplace(2063, text3)) < 0)
			{
				result = true;
			}
			break;
		case "M":
			if (text3.CompareTo(AuthYearReplace(2065, text3)) < 0)
			{
				result = true;
			}
			break;
		case "N":
			if (text3.CompareTo(AuthYearReplace(2067, text3)) < 0)
			{
				result = true;
			}
			break;
		case "Y":
			if (email.Substring(0, 1).Equals("g", StringComparison.CurrentCultureIgnoreCase))
			{
				result = true;
			}
			break;
		}
		return result;
	}

	private static string AuthYearReplace(int p, string limit_ymd)
	{
		return p + limit_ymd.Substring(4, 4);
	}

	private static string getYYYYMMDD()
	{
		string text = "";
		return DateTime.Now.ToString("yyyyMMdd");
	}

	internal static string GetBootTime()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		string result = "";
		SelectQuery val = new SelectQuery("SELECT LastBootUpTime FROM Win32_OperatingSystem WHERE Primary='true'");
		ManagementObjectSearcher val2 = new ManagementObjectSearcher((ObjectQuery)(object)val);
		ManagementObjectEnumerator enumerator = val2.Get().GetEnumerator();
		try
		{
			if (enumerator.MoveNext())
			{
				ManagementObject val3 = (ManagementObject)enumerator.get_Current();
				result = ManagementDateTimeConverter.ToDateTime(((ManagementBaseObject)val3).get_Properties().get_Item("LastBootUpTime").get_Value()
					.ToString()).ToString("yyyy-MM-dd HH:mm:ss");
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		return result;
	}

	internal static void DeleteEdgeBHO()
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Browser Helper Objects", RegistryKeyPermissionCheck.ReadWriteSubTree);
		string[] subKeyNames = registryKey.GetSubKeyNames();
		for (int i = 0; i < subKeyNames.Count(); i++)
		{
			try
			{
				string[] valueNames = registryKey.OpenSubKey(subKeyNames[i])!.GetValueNames();
				for (int j = 0; j < valueNames.Count(); j++)
				{
					if ("NoExplorer".Equals(valueNames[j]))
					{
						registryKey.DeleteSubKey(subKeyNames[i], throwOnMissingSubKey: false);
						break;
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	public static string GetOsName()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		string result = "";
		try
		{
			ManagementClass val = new ManagementClass("Win32_OperatingSystem");
			ManagementObjectCollection instances = val.GetInstances();
			bool flag = false;
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					PropertyDataEnumerator enumerator2 = ((ManagementBaseObject)val2).get_Properties().GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							PropertyData current = enumerator2.get_Current();
							if ("caption" == current.get_Name().ToLower())
							{
								result = current.get_Value() as string;
								flag = true;
								break;
							}
						}
					}
					finally
					{
						if (enumerator2 is IDisposable disposable)
						{
							disposable.Dispose();
						}
					}
					if (flag)
					{
						break;
					}
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}
		catch (Exception)
		{
			result = "Not found";
		}
		return result;
	}

	internal static bool CheckOtherSession(string[] arrStr, string p)
	{
		bool result = false;
		for (int i = 0; i < arrStr.Count(); i++)
		{
			if (-1 == arrStr[i].IndexOf("Console") && -1 < arrStr[i].IndexOf(p))
			{
				result = true;
				break;
			}
		}
		return result;
	}

	internal static string GetSubFolderLikes(string sourceDirectory, string p_2, string in_file)
	{
		string text = "";
		if (Directory.Exists(sourceDirectory))
		{
			IEnumerable<string> enumerable = Directory.EnumerateDirectories(sourceDirectory, p_2 + "*");
			foreach (string item in enumerable)
			{
				text = item + "\\" + in_file;
				if (!FileExists(text))
				{
					text = "";
					continue;
				}
				break;
			}
		}
		return text;
	}

	internal static bool IsNotServerMachine()
	{
		if (!mIsNotServerMachine.HasValue)
		{
			string text = null;
			bool flag = false;
			text = GetOsName();
			if (-1 < text.IndexOf("server", StringComparison.CurrentCultureIgnoreCase))
			{
				flag = true;
			}
			mIsNotServerMachine = !flag;
		}
		return mIsNotServerMachine.Value;
	}

	public static bool IsKeyBoardStateCapsLockOn()
	{
		return ((ushort)CNativeWIN32.GetKeyState(20) & 0xFFFF) != 0;
	}

	public static bool CheckVirusIP(ref string virus_ip)
	{
		bool result = false;
		string text = null;
		string text2 = "";
		text = ExecuteCommandSync(Environment.GetEnvironmentVariable("windir") + SEPA + "system32" + "\\ar___".Replace("_", "") + "p.exe -a|find /V \"255\"");
		Regex regex = new Regex("[0-9,a-f]+\\-+[0-9,a-f]+\\-+[0-9,a-f]+\\-+[0-9,a-f]+\\-+[0-9,a-f]+\\-+[0-9,a-f]+");
		string[] array = text.Replace('\n', '\r').Replace("\r\r", "\r").Split(new char[1] { '\r' });
		string text3 = "";
		bool flag = false;
		MatchCollection matchCollection = null;
		for (int i = 0; i < array.Count() - 1; i++)
		{
			if (-1 < array[i].IndexOf("---"))
			{
				text2 = array[i];
			}
			matchCollection = regex.Matches(array[i]);
			if (0 >= matchCollection.Count)
			{
				continue;
			}
			text3 = matchCollection[0].Value;
			for (int j = i + 1; j < array.Count(); j++)
			{
				if (-1 < array[j].IndexOf(text3) && !array[i].Equals(array[j]))
				{
					result = true;
					flag = true;
					virus_ip = "바이러스 배포하는 IP: " + array[j] + "\n" + text2;
					App.WorkLog(virus_ip);
					break;
				}
			}
			if (flag)
			{
				break;
			}
		}
		return result;
	}
}
