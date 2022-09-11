using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SL7;

public class Choose : Form
{
	private IContainer components = null;

	private Button button1;

	private Button button2;

	private Button button3;

	public Choose()
	{
		InitializeComponent();
	}

	private void button3_Click(object sender, EventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		((Control)new Main()).Show();
		MessageBox.Show("FREE TRIAL");
		((Control)this).Hide();
	}

	private void button2_Click(object sender, EventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		((Control)new WhiteList()).Show();
		MessageBox.Show("Welcome Ghost");
		((Control)this).Hide();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		((Control)new Main()).Show();
		MessageBox.Show("FREE TRIAL");
		((Control)this).Hide();
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		button1 = new Button();
		button2 = new Button();
		button3 = new Button();
		((Control)this).SuspendLayout();
		((Control)button1).set_Location(new Point(3, 10));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(75, 23));
		((Control)button1).set_TabIndex(0);
		((Control)button1).set_Text("Simba");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)button2).set_Location(new Point(84, 10));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(75, 23));
		((Control)button2).set_TabIndex(1);
		((Control)button2).set_Text("Ghost");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)button3).set_Location(new Point(165, 10));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(75, 23));
		((Control)button3).set_TabIndex(2);
		((Control)button3).set_Text("Tetunus");
		((ButtonBase)button3).set_UseVisualStyleBackColor(true);
		((Control)button3).add_Click((EventHandler)button3_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(250, 46));
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).set_Name("Choose");
		((Control)this).set_Text("Choose");
		((Control)this).ResumeLayout(false);
	}
}
