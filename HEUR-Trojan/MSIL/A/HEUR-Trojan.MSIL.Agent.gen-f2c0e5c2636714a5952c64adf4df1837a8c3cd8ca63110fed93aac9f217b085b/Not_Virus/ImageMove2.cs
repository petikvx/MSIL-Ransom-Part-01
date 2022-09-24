using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Not_Virus;

public class ImageMove2 : Form
{
	private Random rnd = new Random();

	private List<MovingPic2> picList = new List<MovingPic2>();

	private IContainer components = null;

	private Timer timer1;

	public ImageMove2()
	{
		InitializeComponent();
		((Control)this).SetStyle((ControlStyles)131072, true);
		((Control)this).SetStyle((ControlStyles)8192, true);
		((Control)this).SetStyle((ControlStyles)2, true);
		for (int i = 0; i < rnd.Next(5, 11); i++)
		{
			MovingPic2 item = new MovingPic2(rnd.Next(0, ((Form)this).get_ClientSize().Width - 100), rnd.Next(0, ((Form)this).get_ClientSize().Height - 100), ((Form)this).get_ClientSize().Width, ((Form)this).get_ClientSize().Height, rnd.Next(1, 21), rnd.Next(1, 21), Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)), rnd.Next(50, 201), rnd.Next(50, 201));
			picList.Add(item);
		}
		((Control)this).set_Text($"{picList.Count} images currently on the screen!");
	}

	private void timer1_Tick_1(object sender, EventArgs e)
	{
		((Control)this).Invalidate(false);
	}

	private void ImageMove2_Resize(object sender, EventArgs e)
	{
		MovingPic2 movingPic = new MovingPic2(1, 1, 1, 1, 1, 1, Color.Black, 1, 1);
		movingPic.formHeight = ((Form)this).get_ClientSize().Height;
		movingPic.formWidth = ((Form)this).get_ClientSize().Width;
	}

	private void ImageMove2_Paint(object sender, PaintEventArgs e)
	{
		timer1.set_Enabled(true);
		foreach (MovingPic2 pic in picList)
		{
			pic.Draw(e.get_Graphics());
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		components = new Container();
		timer1 = new Timer(components);
		((Control)this).SuspendLayout();
		timer1.add_Tick((EventHandler)timer1_Tick_1);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).set_Name("ImageMove2");
		((Control)this).set_Text("ImageMove2");
		((Control)this).add_Paint(new PaintEventHandler(ImageMove2_Paint));
		((Control)this).add_Resize((EventHandler)ImageMove2_Resize);
		((Control)this).ResumeLayout(false);
	}
}
