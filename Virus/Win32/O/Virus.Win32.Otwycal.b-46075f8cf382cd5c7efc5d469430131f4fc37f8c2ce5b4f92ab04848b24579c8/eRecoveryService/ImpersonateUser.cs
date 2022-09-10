using System;
using System.IO;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Win32;

namespace eRecoveryService;

public class ImpersonateUser
{
	private static IntPtr nToken = IntPtr.Zero;

	private static string currentLoggedOnUser = string.Empty;

	public static IntPtr CurrentUserToken => nToken;

	public static string CurrentLoggedOnUser => currentLoggedOnUser;

	public static void DeleteeRecovery()
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\acer\\eRecovery", writable: false);
		string text;
		if (registryKey.GetValue("InstallPath") != null)
		{
			text = registryKey.GetValue("InstallPath")!.ToString();
			int startIndex = text.IndexOf("\\eRecovery", StringComparison.OrdinalIgnoreCase);
			text = text.Remove(startIndex);
		}
		else
		{
			text = "C:\\Acer\\Empowering Technology";
		}
		text += "\\Remove_eRecovery.exe";
		WIN32.PROCESS_INFORMATION lpProcessInformation = default(WIN32.PROCESS_INFORMATION);
		WIN32.STARTUPINFO lpStartupInfo = default(WIN32.STARTUPINFO);
		WIN32.SECURITY_ATTRIBUTES lpProcessAttributes = default(WIN32.SECURITY_ATTRIBUTES);
		WIN32.SECURITY_ATTRIBUTES lpThreadAttributes = default(WIN32.SECURITY_ATTRIBUTES);
		lpProcessAttributes.nLength = Marshal.SizeOf((object)lpProcessAttributes);
		lpThreadAttributes.nLength = Marshal.SizeOf((object)lpThreadAttributes);
		WIN32.CreateProcess(text, "", ref lpProcessAttributes, ref lpThreadAttributes, bInheritHandles: false, 0u, IntPtr.Zero, null, ref lpStartupInfo, out lpProcessInformation);
	}

	public static bool IsHiddenPartitionExist()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		ConnectionOptions val = null;
		int num = 10;
		int num2 = 10;
		bool result = true;
		bool flag = false;
		val = new ConnectionOptions();
		val.set_Username((string)null);
		val.set_Password((string)null);
		ManagementScope val2 = new ManagementScope("root\\cimv2", val);
		ObjectQuery val3 = new ObjectQuery("SELECT * FROM Win32_LogicalDiskToPartition");
		ManagementObjectSearcher val4 = new ManagementObjectSearcher(val2, val3);
		ManagementObjectCollection val5 = val4.Get();
		ManagementObjectEnumerator enumerator = val5.GetEnumerator();
		try
		{
			while (true)
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val6 = (ManagementObject)enumerator.get_Current();
					string text = ((ManagementBaseObject)val6).get_Item("Dependent").ToString();
					string text2 = ((ManagementBaseObject)val6).get_Item("Antecedent").ToString();
					if (flag)
					{
						if (num == 10 || num2 == 10)
						{
							continue;
						}
						int num3 = text2.IndexOf("Disk #", StringComparison.OrdinalIgnoreCase);
						if (num3 == -1)
						{
							break;
						}
						string value = text2.Substring(num3 + 6, 1);
						if (num != Convert.ToInt32(value))
						{
							continue;
						}
						num3 = text2.IndexOf("Partition #", StringComparison.OrdinalIgnoreCase);
						if (num3 == -1)
						{
							return result;
						}
						value = text2.Substring(num3 + 11, 1);
						if (num2 + 1 != Convert.ToInt32(value))
						{
							continue;
						}
						num3 = text.IndexOf("Win32_LogicalDisk.DeviceID", StringComparison.OrdinalIgnoreCase);
						if (num3 != -1)
						{
							value = text.Substring(num3 + 26);
							num3 = value.IndexOf(":", StringComparison.OrdinalIgnoreCase);
							if (num3 != -1)
							{
								string text3 = value.Substring(num3 - 1, 1);
								if (Directory.Exists(text3 + ":\\erData"))
								{
									RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("Software\\acer\\eRecovery\\Main");
									try
									{
										registryKey.SetValue("3rdDisk_Drive", text3);
										return result;
									}
									catch
									{
										return result;
									}
								}
								RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("Software\\acer\\eRecovery", writable: false);
								string text4 = ((registryKey2.GetValue("InstallPath") == null) ? "C:\\Acer\\Empowering Technology\\eRecovery" : registryKey2.GetValue("InstallPath")!.ToString());
								text4 += "\\CheckD2DSystem.exe";
								WIN32.PROCESS_INFORMATION lpProcessInformation = default(WIN32.PROCESS_INFORMATION);
								WIN32.STARTUPINFO lpStartupInfo = default(WIN32.STARTUPINFO);
								WIN32.SECURITY_ATTRIBUTES lpProcessAttributes = default(WIN32.SECURITY_ATTRIBUTES);
								WIN32.SECURITY_ATTRIBUTES lpThreadAttributes = default(WIN32.SECURITY_ATTRIBUTES);
								lpProcessAttributes.nLength = Marshal.SizeOf((object)lpProcessAttributes);
								lpThreadAttributes.nLength = Marshal.SizeOf((object)lpThreadAttributes);
								WIN32.CreateProcess(text4, null, ref lpProcessAttributes, ref lpThreadAttributes, bInheritHandles: false, 0u, IntPtr.Zero, null, ref lpStartupInfo, out lpProcessInformation);
								return result;
							}
							return result;
						}
						return result;
					}
					if (!FindCPartition(text))
					{
						continue;
					}
					if (IsCtheSecondPartition(text2))
					{
						flag = true;
						int num3 = text2.IndexOf("Partition #", StringComparison.OrdinalIgnoreCase);
						if (num3 > 0)
						{
							string value = text2.Substring(num3 + 11, 1);
							num2 = Convert.ToInt32(value);
						}
						num3 = text2.IndexOf("Disk #", StringComparison.OrdinalIgnoreCase);
						if (num3 > 0)
						{
							string value = text2.Substring(num3 + 6, 1);
							num = Convert.ToInt32(value);
						}
						result = true;
					}
					else
					{
						RegistryKey registryKey3 = Registry.LocalMachine.OpenSubKey("Software\\acer\\Empowering Technology 2.5\\Framework", writable: false);
						string text5;
						if (registryKey3.GetValue("BaseFolder") != null)
						{
							text5 = registryKey3.GetValue("BaseFolder")!.ToString();
							text5 += "\\eRecoveryLog.ini";
						}
						else
						{
							text5 = "C:\\Acer\\Empowering Technology\\eRecoveryLog.ini";
						}
						WIN32.WritePrivateProfileString("Service delete eRecovery", "Time", DateTime.Now.ToString(), text5);
						WIN32.WritePrivateProfileString("Service delete eRecovery", "Dependent", text.ToString(), text5);
						WIN32.WritePrivateProfileString("Service delete eRecovery", "Antecedent", text2.ToString(), text5);
						result = false;
					}
					continue;
				}
				return result;
			}
			return result;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	private static bool FindCPartition(string szDepedent)
	{
		int num = szDepedent.IndexOf("Win32_LogicalDisk.DeviceID", StringComparison.OrdinalIgnoreCase);
		if (num > 0)
		{
			string text = szDepedent.Substring(num + 26);
			if (text.IndexOf("c:", StringComparison.OrdinalIgnoreCase) > 0)
			{
				return true;
			}
		}
		return false;
	}

	private static bool IsCtheSecondPartition(string szAntecedent)
	{
		int num = szAntecedent.IndexOf("Win32_DiskPartition.DeviceID", StringComparison.OrdinalIgnoreCase);
		if (num > 0)
		{
			string text = szAntecedent.Substring(num + 28);
			num = text.IndexOf("Partition", StringComparison.OrdinalIgnoreCase);
			if (num > 0)
			{
				text = text.Substring(num + 9);
				if (text.IndexOf("#1", StringComparison.OrdinalIgnoreCase) > 0)
				{
					return true;
				}
			}
		}
		return false;
	}

	public static void StopToImpersonateCurrentUser()
	{
		if (nToken != IntPtr.Zero)
		{
			WIN32.CloseHandle(nToken);
			nToken = IntPtr.Zero;
			currentLoggedOnUser = string.Empty;
			WIN32.RevertToSelf();
		}
	}

	private static string getAccountNameFromSid(IntPtr SID)
	{
		int cbName = 0;
		int cbDomainName = 0;
		int peUse = 0;
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder account = null;
		StringBuilder domainName = null;
		if (WIN32.LookupAccountSid(null, SID, account, ref cbName, domainName, ref cbDomainName, ref peUse) && Marshal.GetLastWin32Error() == 259)
		{
			return "Error";
		}
		account = new StringBuilder(cbName);
		domainName = new StringBuilder(cbDomainName);
		if (WIN32.LookupAccountSid(null, SID, account, ref cbName, domainName, ref cbDomainName, ref peUse))
		{
			stringBuilder.Append((object?)domainName);
			stringBuilder.Append("\\");
			stringBuilder.Append((object?)account);
		}
		else
		{
			stringBuilder.Append("Win32 Error: " + Marshal.GetLastWin32Error());
		}
		return stringBuilder.ToString();
	}

	public static bool StartToImpersonateCurrentUser()
	{
		bool flag = false;
		if (nToken != IntPtr.Zero)
		{
			return flag;
		}
		uint num = WIN32.WTSGetActiveConsoleSessionId();
		if (num != uint.MaxValue)
		{
			IntPtr intPtr = IntPtr.Zero;
			IntPtr ppProcessInfo = IntPtr.Zero;
			uint pCount = 0u;
			if (WIN32.WTSEnumerateProcesses(WIN32.WTC_CURRENT_SERVER_HANDLE, 0, 1u, ref ppProcessInfo, ref pCount))
			{
				IntPtr pMemory = ppProcessInfo;
				for (int i = 0; i < pCount; i++)
				{
					WIN32.WTSProcessInfo wTSProcessInfo = (WIN32.WTSProcessInfo)Marshal.PtrToStructure(ppProcessInfo, typeof(WIN32.WTSProcessInfo));
					int num2 = (int)ppProcessInfo + Marshal.SizeOf((object)wTSProcessInfo);
					ppProcessInfo = (IntPtr)num2;
					if (wTSProcessInfo.pProcessName.ToLower().IndexOf("explorer") != -1 && wTSProcessInfo.SessionId == num)
					{
						currentLoggedOnUser = getAccountNameFromSid(wTSProcessInfo.pUserSid);
						intPtr = WIN32.OpenProcess(2035711u, bInheritHandle: false, wTSProcessInfo.ProcessId);
						break;
					}
				}
				WIN32.WTSFreeMemory(pMemory);
			}
			if (intPtr != IntPtr.Zero && WIN32.OpenProcessToken(intPtr, 10u, out var TokenHandle))
			{
				if (WIN32.DuplicateTokenEx(TokenHandle, 11u, IntPtr.Zero, WIN32.SECURITY_IMPERSONATION_LEVEL.SecurityImpersonation, WIN32.TOKEN_TYPE.TokenPrimary, out nToken) && WIN32.ImpersonateLoggedOnUser(nToken))
				{
					flag = true;
				}
				WIN32.CloseHandle(TokenHandle);
			}
		}
		if (!flag)
		{
			currentLoggedOnUser = string.Empty;
		}
		return flag;
	}

	public static bool ImpersonateUserToCreateProcessSilent()
	{
		bool result = false;
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\acer\\eRecovery", writable: false);
		string text;
		try
		{
			registryKey.GetValue("InstallPath");
			text = registryKey.GetValue("InstallPath")!.ToString();
		}
		catch
		{
			text = "C:\\Acer\\Empowering Technology\\eRecovery";
		}
		text += "\\eRAgent.exe -s";
		if (StartToImpersonateCurrentUser())
		{
			WIN32.STARTUPINFO lpStartupInfo = default(WIN32.STARTUPINFO);
			lpStartupInfo.cb = Marshal.SizeOf((object)lpStartupInfo);
			if (WIN32.CreateProcessAsUser(nToken, null, text, IntPtr.Zero, IntPtr.Zero, bInheritHandles: false, 48u, IntPtr.Zero, null, ref lpStartupInfo, out var _))
			{
				result = true;
			}
			StopToImpersonateCurrentUser();
		}
		return result;
	}

	public static bool ImpersonateUserToCreateProcess()
	{
		bool result = false;
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\acer\\eRecovery", writable: false);
		string text;
		try
		{
			registryKey.GetValue("InstallPath");
			text = registryKey.GetValue("InstallPath")!.ToString();
		}
		catch
		{
			text = "C:\\Acer\\Empowering Technology\\eRecovery";
		}
		string lpCommandLine = text + "\\eRAgent.exe -init";
		registryKey.Close();
		RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("Software\\acer\\Empowering Technology 2.5\\Framework", writable: false);
		try
		{
			registryKey2.GetValue("BaseFolder");
			text = registryKey2.GetValue("BaseFolder")!.ToString();
		}
		catch
		{
			text = "C:\\Acer\\Empowering Technology";
		}
		string lpApplicationName = text + "\\Acer.Empowering.Framework.Supervisor.exe";
		registryKey2.Close();
		if (StartToImpersonateCurrentUser())
		{
			WIN32.STARTUPINFO lpStartupInfo = default(WIN32.STARTUPINFO);
			lpStartupInfo.cb = Marshal.SizeOf((object)lpStartupInfo);
			WIN32.STARTUPINFO lpStartupInfo2 = default(WIN32.STARTUPINFO);
			lpStartupInfo2.cb = Marshal.SizeOf((object)lpStartupInfo2);
			if (WIN32.CreateProcessAsUser(nToken, lpApplicationName, null, IntPtr.Zero, IntPtr.Zero, bInheritHandles: false, 48u, IntPtr.Zero, null, ref lpStartupInfo2, out var lpProcessInformation))
			{
				result = true;
			}
			if (WIN32.CreateProcessAsUser(nToken, null, lpCommandLine, IntPtr.Zero, IntPtr.Zero, bInheritHandles: false, 48u, IntPtr.Zero, null, ref lpStartupInfo, out lpProcessInformation))
			{
				result = true;
			}
			StopToImpersonateCurrentUser();
		}
		return result;
	}
}
