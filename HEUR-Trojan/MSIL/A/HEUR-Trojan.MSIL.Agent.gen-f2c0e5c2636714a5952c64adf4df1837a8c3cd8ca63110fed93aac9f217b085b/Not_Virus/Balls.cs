using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Not_Virus;

public class Balls : Form
{
	private Random rnd = new Random();

	private List<Ball> ballList = new List<Ball>();

	private IContainer components = null;

	private Timer timer1;

	public Balls()
	{
		InitializeComponent();
		((Control)this).SetStyle((ControlStyles)131072, true);
		((Control)this).SetStyle((ControlStyles)8192, true);
		((Control)this).SetStyle((ControlStyles)2, true);
		for (int i = 0; i < rnd.Next(1000, 15000); i++)
		{
			Ball item = new Ball(rnd.Next(0, ((Form)this).get_ClientSize().Width - 100), rnd.Next(0, ((Form)this).get_ClientSize().Height - 100), ((Form)this).get_ClientSize().Width, ((Form)this).get_ClientSize().Height, rnd.Next(1, 21), rnd.Next(1, 21), Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)), rnd.Next(1, 101), rnd.Next(1, 101));
			ballList.Add(item);
		}
		((Control)this).set_Text($"{ballList.Count} balls currently on the screen!");
	}

	private void Balls_Paint(object sender, PaintEventArgs e)
	{
		timer1.set_Enabled(true);
		foreach (Ball ball in ballList)
		{
			ball.Draw(e.get_Graphics());
		}
	}

	private void Balls_Resize(object sender, EventArgs e)
	{
		Ball ball = new Ball(1, 1, 1, 1, 1, 1, Color.Black, 1, 1);
		ball.formHeight = ((Form)this).get_ClientSize().Height;
		ball.formWidth = ((Form)this).get_ClientSize().Width;
	}

	private void timer1_Tick_1(object sender, EventArgs e)
	{
		((Control)this).Invalidate(false);
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
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		components = new Container();
		timer1 = new Timer(components);
		((Control)this).SuspendLayout();
		timer1.set_Interval(1);
		timer1.add_Tick((EventHandler)timer1_Tick_1);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).set_Name("Balls");
		((Control)this).set_Text("Balls");
		((Control)this).add_Paint(new PaintEventHandler(Balls_Paint));
		((Control)this).add_Resize((EventHandler)Balls_Resize);
		((Control)this).ResumeLayout(false);
	}
}
