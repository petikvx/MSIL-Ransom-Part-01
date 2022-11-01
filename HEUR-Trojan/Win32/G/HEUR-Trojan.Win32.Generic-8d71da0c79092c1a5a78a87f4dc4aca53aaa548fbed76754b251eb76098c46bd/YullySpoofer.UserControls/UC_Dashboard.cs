using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace YullySpoofer.UserControls;

public class UC_Dashboard : UserControl
{
	private IContainer components = null;

	private Panel panel1;

	private PictureBox pictureBox1;

	private Label username;

	private Label label2;

	private Label label3;

	private Label label5;

	private Label label4;

	private Label label1;

	public UC_Dashboard()
	{
		InitializeComponent();
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
		Process.Start("");
	}

	private void UC_Dashboard_Load(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((ContainerControl)this).Dispose(disposing);
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
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected O, but got Unknown
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Expected O, but got Unknown
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Expected O, but got Unknown
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Expected O, but got Unknown
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Expected O, but got Unknown
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0524: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(UC_Dashboard));
		panel1 = new Panel();
		label5 = new Label();
		label4 = new Label();
		label1 = new Label();
		username = new Label();
		label2 = new Label();
		label3 = new Label();
		pictureBox1 = new PictureBox();
		((Control)panel1).SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)panel1).set_BackColor(Color.FromArgb(10, 10, 10));
		((Control)panel1).get_Controls().Add((Control)(object)label5);
		((Control)panel1).get_Controls().Add((Control)(object)label4);
		((Control)panel1).get_Controls().Add((Control)(object)label1);
		((Control)panel1).get_Controls().Add((Control)(object)pictureBox1);
		((Control)panel1).get_Controls().Add((Control)(object)username);
		((Control)panel1).get_Controls().Add((Control)(object)label2);
		((Control)panel1).get_Controls().Add((Control)(object)label3);
		((Control)panel1).set_Location(new Point(92, 51));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(500, 221));
		((Control)panel1).set_TabIndex(6);
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font("Segoe UI", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_ForeColor(Color.FromArgb(127, 60, 126));
		((Control)label5).set_Location(new Point(26, 111));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(282, 17));
		((Control)label5).set_TabIndex(9);
		((Control)label5).set_Text("  went detected after you've redeemed the key.");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Segoe UI", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_ForeColor(Color.FromArgb(127, 60, 126));
		((Control)label4).set_Location(new Point(25, 87));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(284, 17));
		((Control)label4).set_TabIndex(8);
		((Control)label4).set_Text("  Compensatins will only Happen if the product,");
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Segoe UI", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.FromArgb(127, 60, 126));
		((Control)label1).set_Location(new Point(25, 65));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(384, 17));
		((Control)label1).set_TabIndex(7);
		((Control)label1).set_Text("  Please check the status of the product before use or redeem it.");
		((Control)username).set_AutoSize(true);
		((Control)username).set_Font(new Font("Segoe UI", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)username).set_ForeColor(Color.FromArgb(126, 65, 146));
		((Control)username).set_Location(new Point(13, 194));
		((Control)username).set_Name("username");
		((Control)username).set_Size(new Size(51, 15));
		((Control)username).set_TabIndex(5);
		((Control)username).set_Text("+Admin");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.FromArgb(126, 65, 146));
		((Control)label2).set_Location(new Point(13, 17));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(129, 17));
		((Control)label2).set_TabIndex(1);
		((Control)label2).set_Text("News / Information");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Segoe UI", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(Color.FromArgb(127, 60, 126));
		((Control)label3).set_Location(new Point(25, 43));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(175, 17));
		((Control)label3).set_TabIndex(2);
		((Control)label3).set_Text("Welcome to YullySpoofer.xyz\r\n");
		pictureBox1.set_Image((Image)componentResourceManager.GetObject("pictureBox1.Image"));
		((Control)pictureBox1).set_Location(new Point(461, 186));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(24, 24));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)4);
		pictureBox1.set_TabIndex(6);
		pictureBox1.set_TabStop(false);
		((Control)pictureBox1).add_Click((EventHandler)pictureBox1_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Transparent);
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).set_Name("UC_Dashboard");
		((Control)this).set_Size(new Size(690, 574));
		((UserControl)this).add_Load((EventHandler)UC_Dashboard_Load);
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
