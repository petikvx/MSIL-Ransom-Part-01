using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;
using Zika.Properties;

namespace Zika;

public class Form6 : Form
{
	private SoundPlayer s = new SoundPlayer();

	private long inodes;

	private long in2;

	private Random r;

	private int w;

	private int h;

	private IContainer components;

	private Label label1;

	private Label label2;

	private ProgressBar progressBar1;

	private PictureBox pictureBox1;

	private Timer timer1;

	private Timer timer2;

	public Form6()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		InitializeComponent();
	}

	private void Form6_Load(object sender, EventArgs e)
	{
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		inodes = new Random().Next(100000, 400000);
		progressBar1.set_Minimum(0);
		progressBar1.set_Maximum(100);
		progressBar1.set_Value(0);
		r = new Random();
		((Control)label2).set_Text(inodes + " index bit");
		w = Screen.get_PrimaryScreen().get_Bounds().Width;
		h = Screen.get_PrimaryScreen().get_Bounds().Height;
		((Control)this).set_Top(h / 2 - 35);
		((Control)this).set_Left(w / 2 - 210);
		s = new SoundPlayer((Stream)Resources.NavaShield_Delete_C);
		s.PlayLooping();
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		in2 += r.Next(400, 2000);
		((Control)label2).set_Text(in2 + " index bit");
		try
		{
			progressBar1.set_Value((int)(100L * in2 / inodes));
		}
		catch (Exception)
		{
		}
		if (in2 >= inodes)
		{
			((Control)this).set_BackColor(Color.FromArgb(51, 110, 165));
			((Control)label1).set_Visible(false);
			((Control)label2).set_Visible(false);
			((Control)pictureBox1).set_Visible(false);
			((Control)progressBar1).set_Visible(false);
			timer1.Stop();
			timer2.Stop();
		}
	}

	private void Form6_FormClosing(object sender, FormClosingEventArgs e)
	{
		s.Stop();
		Form1.f6open = false;
	}

	private void timer2_Tick(object sender, EventArgs e)
	{
		((Control)this).set_Top(Math.Max(((Control)this).get_Top() - 1, 0));
		((Control)this).set_Left(Math.Max(((Control)this).get_Left() - 1, 0));
		((Control)this).set_Width(Math.Min(((Control)this).get_Width() + 2, w));
		((Control)this).set_Height(Math.Min(((Control)this).get_Height() + 2, h));
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
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected O, but got Unknown
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form6));
		label1 = new Label();
		label2 = new Label();
		progressBar1 = new ProgressBar();
		pictureBox1 = new PictureBox();
		timer1 = new Timer(components);
		timer2 = new Timer(components);
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)label1).set_Anchor((AnchorStyles)0);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(71, 11));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(156, 12));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Disk drive C: is being deleted");
		((Control)label2).set_Anchor((AnchorStyles)0);
		((Control)label2).set_Location(new Point(267, 11));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(144, 12));
		((Control)label2).set_TabIndex(1);
		((Control)label2).set_Text("0 index bit");
		label2.set_TextAlign((ContentAlignment)4);
		((Control)progressBar1).set_Anchor((AnchorStyles)0);
		((Control)progressBar1).set_Location(new Point(74, 35));
		((Control)progressBar1).set_Name("progressBar1");
		((Control)progressBar1).set_Size(new Size(337, 19));
		((Control)progressBar1).set_TabIndex(2);
		((Control)pictureBox1).set_Anchor((AnchorStyles)0);
		((Control)pictureBox1).set_BackgroundImageLayout((ImageLayout)2);
		pictureBox1.set_Image((Image)componentResourceManager.GetObject("pictureBox1.Image"));
		((Control)pictureBox1).set_Location(new Point(4, 4));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(64, 59));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)3);
		pictureBox1.set_TabIndex(3);
		pictureBox1.set_TabStop(false);
		timer1.set_Enabled(true);
		timer1.set_Interval(2000);
		timer1.add_Tick((EventHandler)timer1_Tick);
		timer2.set_Enabled(true);
		timer2.set_Interval(400);
		timer2.add_Tick((EventHandler)timer2_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(420, 65));
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).get_Controls().Add((Control)(object)progressBar1);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form6");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Form6");
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form6_FormClosing));
		((Form)this).add_Load((EventHandler)Form6_Load);
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
