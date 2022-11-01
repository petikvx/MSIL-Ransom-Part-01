using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Sapphire_Ransomware;

[DesignerGenerated]
public class Form4 : Form
{
	private IContainer components;

	public Form4()
	{
		((Form)this).add_Load((EventHandler)Form4_Load);
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
		((Form)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form4");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Form4");
		((Form)this).set_WindowState((FormWindowState)2);
		((Control)this).ResumeLayout(false);
	}

	private void Form4_Load(object sender, EventArgs e)
	{
		((Control)this).BringToFront();
	}
}
