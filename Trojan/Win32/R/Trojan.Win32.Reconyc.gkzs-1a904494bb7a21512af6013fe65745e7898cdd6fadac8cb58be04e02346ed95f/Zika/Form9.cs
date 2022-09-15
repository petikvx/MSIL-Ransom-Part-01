using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Zika;

public class Form9 : Form
{
	private IContainer components;

	private Button button1;

	public Form9()
	{
		InitializeComponent();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void Form9_Load(object sender, EventArgs e)
	{
		int width = Screen.get_PrimaryScreen().get_Bounds().Width;
		int height = Screen.get_PrimaryScreen().get_Bounds().Height;
		Random random = new Random();
		((Control)this).set_Top(random.Next(0, width - ((Control)this).get_Width()));
		((Control)this).set_Left(random.Next(0, height - ((Control)this).get_Height()));
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
		((Control)button1).set_Location(new Point(56, 42));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(75, 23));
		((Control)button1).set_TabIndex(0);
		((Control)button1).set_Text("OK");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(189, 112));
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form9");
		((Form)this).set_ShowIcon(false);
		((Control)this).set_Text("Warning!");
		((Form)this).add_Load((EventHandler)Form9_Load);
		((Control)this).ResumeLayout(false);
	}
}
