using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Qhvqj;

public class Form6 : Form
{
	private IContainer components = null;

	private Button button1;

	public Form6()
	{
		InitializeComponent();
	}

	internal void button1_Click(object sender, EventArgs e)
	{
		new Form5().methodInfo.Invoke(null, null);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		button1 = new Button();
		((Control)this).SuspendLayout();
		((Control)button1).set_Location(new Point(305, 165));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(108, 41));
		((Control)button1).set_TabIndex(1);
		((Control)button1).set_Text("button1");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(11f, 24f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(684, 353));
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).set_Name("Form6");
		((Control)this).set_Text("Form6");
		((Control)this).ResumeLayout(false);
	}
}
