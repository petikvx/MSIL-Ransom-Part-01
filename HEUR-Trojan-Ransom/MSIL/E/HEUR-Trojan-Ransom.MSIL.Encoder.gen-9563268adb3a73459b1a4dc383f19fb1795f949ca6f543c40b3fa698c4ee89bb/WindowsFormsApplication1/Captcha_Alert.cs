using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace WindowsFormsApplication1;

public class Captcha_Alert : Form
{
	private IContainer components = null;

	public PictureBox pictureBox1;

	public MetroTextBox captcha_alert_textBox1;

	public Captcha_Alert(string captcha_header)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		InitializeComponent();
		try
		{
			Icon icon = new Icon(update_app.folder_path + "\\Poshmark_.ico");
			((Form)this).set_Icon(icon);
		}
		catch
		{
		}
		((Control)this).BringToFront();
		((Form)this).set_TopMost(true);
		((Control)this).Focus();
		((Control)captcha_alert_textBox1).set_Text(captcha_header);
		Console.Beep(800, 1000);
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
		captcha_alert_textBox1 = new MetroTextBox();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)pictureBox1).set_Dock((DockStyle)2);
		((Control)pictureBox1).set_Location(new Point(0, 57));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(388, 304));
		pictureBox1.set_TabIndex(1);
		pictureBox1.set_TabStop(false);
		((Control)captcha_alert_textBox1).set_Dock((DockStyle)1);
		((Control)captcha_alert_textBox1).set_Location(new Point(0, 0));
		captcha_alert_textBox1.Multiline = true;
		((Control)captcha_alert_textBox1).set_Name("captcha_alert_textBox1");
		captcha_alert_textBox1.ReadOnly = true;
		((Control)captcha_alert_textBox1).set_Size(new Size(388, 51));
		((Control)captcha_alert_textBox1).set_TabIndex(2);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(388, 361));
		((Control)this).get_Controls().Add((Control)(object)captcha_alert_textBox1);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).set_Name("Captcha_Alert");
		((Control)this).set_Text("Captcha Alert");
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
