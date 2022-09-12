using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using ns3;

namespace ns19;

[DesignerGenerated]
public class StartUpForm : Form
{
	private IContainer icontainer_0;

	public StartUpForm()
	{
		((Form)this).add_Load((EventHandler)StartUpForm_Load);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && icontainer_0 != null)
			{
				icontainer_0.Dispose();
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
		((Form)this).set_ClientSize(new Size(139, 68));
		((Control)this).set_Name("StartUpForm");
		((Form)this).set_Text("StartUpForm");
		((Control)this).ResumeLayout(false);
	}

	private void StartUpForm_Load(object sender, EventArgs e)
	{
		((Form)this).set_Opacity(0.0);
		((Control)Class2.Forms.MainMenu).Show();
	}
}
