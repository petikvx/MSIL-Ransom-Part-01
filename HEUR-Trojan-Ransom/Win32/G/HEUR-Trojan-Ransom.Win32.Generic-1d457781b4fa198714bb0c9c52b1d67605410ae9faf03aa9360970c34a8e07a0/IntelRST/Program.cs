using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace IntelRST;

internal static class Program
{
	private static string _mutexID = "a8b65a4f-9ffb-46fd-a432-bdd3338c456783e";

	[STAThread]
	private static void Main()
	{
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			new resourcefileexecuter();
			string embeddedResource = "IntelRST.Microsoft.Win32.TaskScheduler.dll";
			EmbeddedAssembly.Load(embeddedResource, "IntelRST.Microsoft.Win32.TaskScheduler.dll");
			AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
			if (Directory.Exists(folderPath + "\\Intel\\Intel Volume") && File.Exists(folderPath + "\\Intel\\Intel Volume\\IntelRST.exe"))
			{
				FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(folderPath + "\\Intel\\Intel Volume\\IntelRST.exe");
				string s = versionInfo.FileVersion!.Replace(".", string.Empty);
				int num = int.Parse(s);
				string s2 = Application.get_ProductVersion().Replace(".", string.Empty);
				int num2 = int.Parse(s2);
				if (num2 > num)
				{
					try
					{
						Process[] processesByName = Process.GetProcessesByName("IntelRST");
						Process[] array = processesByName;
						foreach (Process process in array)
						{
							if (process.ProcessName.Contains("IntelRST"))
							{
								process.Kill();
							}
						}
						Directory.Delete(folderPath + "\\Intel\\Intel Volume\\Stub", recursive: true);
						File.Delete(folderPath + "\\Intel\\Intel Volume\\Information.zip");
						File.Delete(folderPath + "\\Intel\\Intel Volume\\7za");
						File.Delete(folderPath + "\\Intel\\Intel Volume\\code");
						Directory.Delete(folderPath + "\\Intel\\Intel Volume\\icon", recursive: true);
						Directory.Delete(folderPath + "\\Intel\\Intel Volume\\Lab", recursive: true);
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.ToString() + "inner = " + ex.InnerException);
					}
				}
			}
		}
		catch (Exception ex2)
		{
			MessageBox.Show(ex2.ToString() + "inner = " + ex2.InnerException);
		}
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		bool createdNew;
		using (new Mutex(initiallyOwned: true, _mutexID, out createdNew))
		{
			if (createdNew)
			{
				Application.Run((Form)(object)new Form1());
			}
		}
	}

	private static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
	{
		return EmbeddedAssembly.Get(args.Name);
	}
}
