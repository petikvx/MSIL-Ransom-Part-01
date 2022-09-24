using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Not_Virus;

public class ImageMove : Form
{
	private Random rnd = new Random();

	private List<MovingPic> picList = new List<MovingPic>();

	private IContainer components = null;

	private Timer timer1;

	public ImageMove()
	{
		InitializeComponent();
		((Control)this).SetStyle((ControlStyles)131072, true);
		((Control)this).SetStyle((ControlStyles)8192, true);
		((Control)this).SetStyle((ControlStyles)2, true);
		for (int i = 0; i < rnd.Next(5, 101); i++)
		{
			MovingPic item = new MovingPic(rnd.Next(0, ((Form)this).get_ClientSize().Width - 100), rnd.Next(0, ((Form)this).get_ClientSize().Height - 100), ((Form)this).get_ClientSize().Width, ((Form)this).get_ClientSize().Height, rnd.Next(1, 21), rnd.Next(1, 21), Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)), rnd.Next(50, 201), rnd.Next(50, 201));
			picList.Add(item);
		}
		((Control)this).set_Text($"{picList.Count} images currently on the screen!");
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		((Control)this).Invalidate(false);
	}

	private void ImageMove_Paint(object sender, PaintEventArgs e)
	{
		timer1.set_Enabled(true);
		foreach (MovingPic pic in picList)
		{
			pic.Draw(e.get_Graphics());
		}
	}

	private void ImageMove_Resize(object sender, EventArgs e)
	{
		MovingPic movingPic = new MovingPic(1, 1, 1, 1, 1, 1, Color.Black, 1, 1);
		movingPic.formHeight = ((Form)this).get_ClientSize().Height;
		movingPic.formWidth = ((Form)this).get_ClientSize().Width;
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
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		components = new Container();
		timer1 = new Timer(components);
		((Control)this).SuspendLayout();
		timer1.set_Interval(50);
		timer1.add_Tick((EventHandler)timer1_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).set_Name("ImageMove");
		((Control)this).set_Text("ImageMove");
		((Control)this).add_Paint(new PaintEventHandler(ImageMove_Paint));
		((Control)this).add_Resize((EventHandler)ImageMove_Resize);
		((Control)this).ResumeLayout(false);
	}
}
