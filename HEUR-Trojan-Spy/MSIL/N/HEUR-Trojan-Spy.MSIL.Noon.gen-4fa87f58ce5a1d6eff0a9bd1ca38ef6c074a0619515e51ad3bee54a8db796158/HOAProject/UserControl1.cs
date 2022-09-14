using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace HOAProject;

[DesignerGenerated]
public class UserControl1 : UserControl
{
	private IContainer components;

	public UserControl1()
	{
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
			((ContainerControl)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		components = new Container();
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
	}
}
