using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace CNBC_MONEY_2009;

[DesignerGenerated]
public class frmTest : Form
{
	private static ArrayList __ENCList = new ArrayList();

	private IContainer components;

	[DebuggerNonUserCode]
	public frmTest()
	{
		((Form)this).add_Load((EventHandler)frmTest_Load);
		__ENCList.Add(new WeakReference(this));
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if ((disposing && components != null) ? true : false)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		((Control)this).SuspendLayout();
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Size clientSize = new Size(565, 326);
		((Form)this).set_ClientSize(clientSize);
		((Control)this).set_Name("frmTest");
		((Form)this).set_Text("frmTest");
		((Control)this).ResumeLayout(false);
	}

	private void frmTest_Load(object sender, EventArgs e)
	{
	}
}
