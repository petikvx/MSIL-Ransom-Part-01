using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace othvidtiraw;

public class Form2 : Form
{
	private IContainer components = null;

	private PictureBox pictureBox1;

	public Form2()
	{
		InitializeComponent();
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		pictureBox1 = new PictureBox();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)pictureBox1).set_Location(new Point(48, 12));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(708, 347));
		pictureBox1.set_TabIndex(0);
		pictureBox1.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(821, 371));
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).set_Name("Form2");
		((Control)this).set_Text("Form2");
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
