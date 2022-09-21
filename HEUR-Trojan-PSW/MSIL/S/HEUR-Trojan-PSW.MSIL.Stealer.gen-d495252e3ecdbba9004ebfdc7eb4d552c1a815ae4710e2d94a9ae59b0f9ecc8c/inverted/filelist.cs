using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace inverted;

public class filelist : Form
{
	private IContainer components = null;

	private TextBox textBox1;

	public filelist()
	{
		InitializeComponent();
	}

	private void filelist_Load(object sender, EventArgs e)
	{
		((Control)textBox1).set_Text(File.ReadAllText("C:\\Users\\" + Environment.UserName + "\\Desktop\\list.txt"));
	}

	private void textBox1_TextChanged(object sender, EventArgs e)
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
		textBox1 = new TextBox();
		((Control)this).SuspendLayout();
		((Control)textBox1).set_Enabled(false);
		((Control)textBox1).set_Location(new Point(7, 5));
		((TextBoxBase)textBox1).set_Multiline(true);
		((Control)textBox1).set_Name("textBox1");
		textBox1.set_ScrollBars((ScrollBars)2);
		((Control)textBox1).set_Size(new Size(540, 321));
		((Control)textBox1).set_TabIndex(0);
		((Control)textBox1).add_TextChanged((EventHandler)textBox1_TextChanged);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(554, 328));
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).set_Name("filelist");
		((Control)this).set_Text("filelist");
		((Form)this).add_Load((EventHandler)filelist_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
