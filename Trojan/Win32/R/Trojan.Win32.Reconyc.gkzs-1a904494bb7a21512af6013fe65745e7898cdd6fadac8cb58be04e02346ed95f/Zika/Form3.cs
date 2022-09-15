using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Zika;

public class Form3 : Form
{
	private Graphics g;

	private Bitmap b;

	private int w;

	private int h;

	private Random r = new Random();

	private int x;

	private IContainer components;

	private Timer timer1;

	private Timer timer2;

	public Form3()
	{
		InitializeComponent();
	}

	private void Form3_Load(object sender, EventArgs e)
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected O, but got Unknown
		((Control)this).set_Top(0);
		((Control)this).set_Left(0);
		((Form)this).set_TopMost(true);
		((Control)this).set_Width(Screen.get_PrimaryScreen().get_Bounds().Width);
		((Control)this).set_Height(Screen.get_PrimaryScreen().get_Bounds().Height);
		Bitmap val = new Bitmap(Screen.get_PrimaryScreen().get_Bounds().Width, Screen.get_PrimaryScreen().get_Bounds().Height, (PixelFormat)2498570);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		val2.CopyFromScreen(Screen.get_PrimaryScreen().get_Bounds().X, Screen.get_PrimaryScreen().get_Bounds().Y, 0, 0, Screen.get_PrimaryScreen().get_Bounds().Size, (CopyPixelOperation)13369376);
		g = ((Control)this).CreateGraphics();
		b = val;
		w = ((Image)val).get_Width();
		h = ((Image)val).get_Height();
		g.set_CompositingQuality((CompositingQuality)1);
		int num = 0;
		for (int i = 1; i < 16; i++)
		{
			int num2 = 0;
			for (int j = 0; j < w; j++)
			{
				int blue;
				int green;
				int red;
				if (i > 0 && num2 > num && i % j != 0)
				{
					blue = 0;
					green = 0;
					red = 0;
				}
				else
				{
					red = 255 - r.Next(0, 4 * i) / (4 * i - 1) * 255;
					green = 255 - r.Next(0, 4 * i) / (4 * i - 1) * 255;
					blue = 255 - r.Next(0, 4 * i) / (4 * i - 1) * 255;
				}
				val2.DrawLine(new Pen(Color.FromArgb(red, green, blue)), j, h - num2, j, h);
				num2 += r.Next(0, 2 * i) / (2 * i - 1);
				num2 += r.Next(0, 2);
			}
			if (i == 1)
			{
				num = num2;
			}
		}
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		if (x < w)
		{
			g.DrawImage((Image)(object)b, new Rectangle(0, 0, w - x, h - x), new Rectangle(0, 0, w - x, h - x), (GraphicsUnit)2);
			g.RotateTransform(-0.7f);
			g.DrawImage((Image)(object)b, new Rectangle(0, h - x, w - x, h - x), new Rectangle(0, h - x, w - x, h - x), (GraphicsUnit)2);
			g.RotateTransform(0.7f);
			g.DrawImage((Image)(object)b, new Rectangle(w - x, 0, w - x, h - x), new Rectangle(w - x, 0, w - x, h - x), (GraphicsUnit)2);
			g.RotateTransform(0.7f);
			g.DrawImage((Image)(object)b, new Rectangle(w - x, h - x, w - x, h - x), new Rectangle(w - x, h - x, w - x, h - x), (GraphicsUnit)2);
			g.RotateTransform(-0.7f);
			x += 9;
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
		timer1.set_Enabled(true);
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
		((Control)this).set_Name("Form3");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Form3");
		((Form)this).add_Load((EventHandler)Form3_Load);
		((Control)this).ResumeLayout(false);
	}
}
