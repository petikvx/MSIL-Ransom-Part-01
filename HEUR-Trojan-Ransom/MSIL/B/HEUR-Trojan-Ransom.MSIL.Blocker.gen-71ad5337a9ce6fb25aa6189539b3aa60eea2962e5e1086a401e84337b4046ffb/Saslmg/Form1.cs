using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Saslmg;

public class Form1 : Form
{
	private IContainer annotation = null;

	public Form1()
	{
		CalculateProperty();
	}

	private void InvokeProperty(object sender, EventArgs e)
	{
		new Form5();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && annotation != null)
		{
			annotation.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void CalculateProperty()
	{
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(11f, 24f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(710, 369));
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)InvokeProperty);
		((Control)this).ResumeLayout(false);
	}
}
