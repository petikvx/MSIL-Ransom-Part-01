using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Ransom.Properties;

namespace Ransom;

public class Form2 : Form
{
	private IContainer components = null;

	private PictureBox pictureBox1;

	private PictureBox pictureBox2;

	private PictureBox pictureBox3;

	private PictureBox pictureBox4;

	private Label label1;

	public Form2()
	{
		InitializeComponent();
	}

	private void Form2_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void Form2_Load(object sender, EventArgs e)
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
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected O, but got Unknown
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Expected O, but got Unknown
		pictureBox1 = new PictureBox();
		pictureBox2 = new PictureBox();
		pictureBox3 = new PictureBox();
		pictureBox4 = new PictureBox();
		label1 = new Label();
		((ISupportInitialize)pictureBox1).BeginInit();
		((ISupportInitialize)pictureBox2).BeginInit();
		((ISupportInitialize)pictureBox3).BeginInit();
		((ISupportInitialize)pictureBox4).BeginInit();
		((Control)this).SuspendLayout();
		((Control)pictureBox1).set_BackgroundImage((Image)(object)Resources.Annabelle_tear);
		((Control)pictureBox1).set_BackgroundImageLayout((ImageLayout)3);
		((Control)pictureBox1).set_Location(new Point(13, 655));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(247, 194));
		pictureBox1.set_TabIndex(0);
		pictureBox1.set_TabStop(false);
		((Control)pictureBox2).set_BackgroundImage((Image)(object)Resources.Annabelle_tear);
		((Control)pictureBox2).set_BackgroundImageLayout((ImageLayout)3);
		((Control)pictureBox2).set_Location(new Point(13, 12));
		((Control)pictureBox2).set_Name("pictureBox2");
		((Control)pictureBox2).set_Size(new Size(247, 194));
		pictureBox2.set_TabIndex(1);
		pictureBox2.set_TabStop(false);
		((Control)pictureBox3).set_BackgroundImage((Image)(object)Resources.Annabelle_tear);
		((Control)pictureBox3).set_BackgroundImageLayout((ImageLayout)3);
		((Control)pictureBox3).set_Location(new Point(1197, 12));
		((Control)pictureBox3).set_Name("pictureBox3");
		((Control)pictureBox3).set_Size(new Size(247, 194));
		pictureBox3.set_TabIndex(2);
		pictureBox3.set_TabStop(false);
		((Control)pictureBox4).set_BackgroundImage((Image)(object)Resources.Annabelle_tear);
		((Control)pictureBox4).set_BackgroundImageLayout((ImageLayout)3);
		((Control)pictureBox4).set_Location(new Point(1197, 655));
		((Control)pictureBox4).set_Name("pictureBox4");
		((Control)pictureBox4).set_Size(new Size(247, 194));
		pictureBox4.set_TabIndex(3);
		pictureBox4.set_TabStop(false);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 24f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)label1).set_ForeColor(Color.Red);
		((Control)label1).set_Location(new Point(407, 125));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(592, 37));
		((Control)label1).set_TabIndex(4);
		((Control)label1).set_Text("Oops... Your computer has been locked!");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(1456, 861));
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)pictureBox4);
		((Control)this).get_Controls().Add((Control)(object)pictureBox3);
		((Control)this).get_Controls().Add((Control)(object)pictureBox2);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form2");
		((Control)this).set_Text("Form2");
		((Form)this).set_TopMost(true);
		((Form)this).set_WindowState((FormWindowState)2);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form2_FormClosing));
		((Form)this).add_Load((EventHandler)Form2_Load);
		((ISupportInitialize)pictureBox1).EndInit();
		((ISupportInitialize)pictureBox2).EndInit();
		((ISupportInitialize)pictureBox3).EndInit();
		((ISupportInitialize)pictureBox4).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
