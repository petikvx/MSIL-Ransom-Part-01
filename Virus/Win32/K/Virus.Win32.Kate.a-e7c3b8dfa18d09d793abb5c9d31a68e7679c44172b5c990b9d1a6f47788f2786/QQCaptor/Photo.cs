using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace QQCaptor;

public class Photo : Form
{
	private IContainer components;

	private WebBrowser webBrowserPhoto2;

	public string strPath = "";

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
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		webBrowserPhoto2 = new WebBrowser();
		((Control)this).SuspendLayout();
		((Control)webBrowserPhoto2).set_Dock((DockStyle)5);
		((Control)webBrowserPhoto2).set_Location(new Point(0, 0));
		((Control)webBrowserPhoto2).set_MinimumSize(new Size(20, 20));
		((Control)webBrowserPhoto2).set_Name("webBrowserPhoto2");
		((Control)webBrowserPhoto2).set_Size(new Size(682, 496));
		((Control)webBrowserPhoto2).set_TabIndex(0);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(682, 496));
		((Control)this).get_Controls().Add((Control)(object)webBrowserPhoto2);
		((Control)this).set_Name("Photo");
		((Form)this).set_StartPosition((FormStartPosition)4);
		((Control)this).set_Text("QQ相册");
		((Form)this).add_FormClosed(new FormClosedEventHandler(Photo_FormClosed));
		((Form)this).add_Load((EventHandler)Photo_Load);
		((Control)this).ResumeLayout(false);
	}

	public Photo()
	{
		InitializeComponent();
	}

	private void Photo_Load(object sender, EventArgs e)
	{
		webBrowserPhoto2.Navigate(strPath);
	}

	private void Photo_FormClosed(object sender, FormClosedEventArgs e)
	{
		((Component)(object)webBrowserPhoto2).Dispose();
	}
}
