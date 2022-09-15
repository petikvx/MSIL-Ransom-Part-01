using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;
using Zika.Properties;

namespace Zika;

public class Form7 : Form
{
	private int counter;

	private SoundPlayer s = new SoundPlayer();

	private IContainer components;

	private Timer timer1;

	public Form7()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		InitializeComponent();
	}

	private void Form7_Load(object sender, EventArgs e)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		((Control)this).set_Top(0);
		((Control)this).set_Left(0);
		((Control)this).set_Width(Screen.get_PrimaryScreen().get_Bounds().Width);
		((Control)this).set_Height(Screen.get_PrimaryScreen().get_Bounds().Height);
		s = new SoundPlayer((Stream)Resources.beep);
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		s.Play();
		if (counter % 2 == 0)
		{
			((Control)this).set_BackColor(Color.White);
		}
		else
		{
			((Control)this).set_BackColor(Color.Black);
		}
		counter++;
		if (counter == 24)
		{
			s.Stop();
			((Form)this).Close();
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
		components = new Container();
		timer1 = new Timer(components);
		((Control)this).SuspendLayout();
		timer1.set_Enabled(true);
		timer1.set_Interval(500);
		timer1.add_Tick((EventHandler)timer1_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(284, 261));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form7");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Form7");
		((Form)this).set_TopMost(true);
		((Form)this).add_Load((EventHandler)Form7_Load);
		((Control)this).ResumeLayout(false);
	}
}
