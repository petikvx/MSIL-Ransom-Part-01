using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Zika;

public class Form4 : Form
{
	private Graphics g;

	private Bitmap b;

	private int w;

	private int h;

	private Random r = new Random();

	private int first;

	private IContainer components;

	private Timer timer1;

	private Timer timer2;

	public Form4()
	{
		InitializeComponent();
	}

	private void Form4_Load(object sender, EventArgs e)
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		((Control)this).set_Top(0);
		((Control)this).set_Left(0);
		((Form)this).set_TopMost(true);
		((Control)this).set_Width(Screen.get_PrimaryScreen().get_Bounds().Width);
		((Control)this).set_Height(Screen.get_PrimaryScreen().get_Bounds().Height);
		Bitmap val = new Bitmap(Screen.get_PrimaryScreen().get_Bounds().Width, Screen.get_PrimaryScreen().get_Bounds().Height, (PixelFormat)2498570);
		Graphics.FromImage((Image)(object)val).CopyFromScreen(Screen.get_PrimaryScreen().get_Bounds().X, Screen.get_PrimaryScreen().get_Bounds().Y, 0, 0, Screen.get_PrimaryScreen().get_Bounds().Size, (CopyPixelOperation)13369376);
		g = ((Control)this).CreateGraphics();
		b = val;
		w = ((Image)val).get_Width();
		h = ((Image)val).get_Height();
		g.set_CompositingQuality((CompositingQuality)1);
		timer1.Start();
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		if (first > 0)
		{
			int num = r.Next(50, 150);
			int x = r.Next(0, w - num);
			g.CopyFromScreen(new Point(x, 0), new Point(x, 1), new Size(num, h - 1));
		}
		else
		{
			g.DrawImage((Image)(object)b, 0, 0);
			first = 1;
		}
	}

	private void timer2_Tick(object sender, EventArgs e)
	{
		((Form)this).Close();
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		components = new Container();
		timer1 = new Timer(components);
		timer2 = new Timer(components);
		((Control)this).SuspendLayout();
		timer1.set_Interval(50);
		timer1.add_Tick((EventHandler)timer1_Tick);
		timer2.set_Enabled(true);
		timer2.set_Interval(5000);
		timer2.add_Tick((EventHandler)timer2_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(284, 241));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form4");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Form4");
		((Form)this).add_Load((EventHandler)Form4_Load);
		((Control)this).ResumeLayout(false);
	}
}
