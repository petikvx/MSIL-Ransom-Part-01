using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ContohDashStyle;

public class Form1 : Form
{
	private IContainer components = null;

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
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(251, 266));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Contoh DashStyle");
		((Control)this).add_Paint(new PaintEventHandler(Form1_Paint));
		((Control)this).ResumeLayout(false);
	}

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Paint(object sender, PaintEventArgs e)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		Rectangle rectangle = new Rectangle(50, 50, 150, 150);
		Pen val = new Pen(Color.Blue, 5f);
		val.set_DashStyle((DashStyle)4);
		e.get_Graphics().DrawRectangle(val, rectangle);
	}
}
