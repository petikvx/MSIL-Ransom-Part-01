using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Not_Virus;

public class ResizingForm : Form
{
	private Random rnd = new Random();

	private IContainer components = null;

	private Timer timer1;

	public ResizingForm()
	{
		InitializeComponent();
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		((Control)this).set_Width(rnd.Next(10, 1920));
		((Control)this).set_Height(rnd.Next(10, 1080));
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
		timer1.add_Tick((EventHandler)timer1_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).set_Name("ResizingForm");
		((Control)this).set_Text("ResizingForm");
		((Control)this).ResumeLayout(false);
	}
}
