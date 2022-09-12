using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Gecko;

public class ChromeDialog : Form
{
	private IContainer components = null;

	private GeckoWebBrowser webBrowser;

	public GeckoWebBrowser WebBrowser => webBrowser;

	public ChromeDialog()
	{
		InitializeComponent();
	}

	private void webBrowser_DocumentTitleChanged(object sender, EventArgs e)
	{
		((Control)this).set_Text(webBrowser.DocumentTitle);
	}

	private void webBrowser_WindowSetBounds(object sender, GeckoWindowSetBoundsEventArgs e)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		Rectangle bounds = e.Bounds;
		int x = bounds.X;
		bounds = e.Bounds;
		int y = bounds.Y;
		bounds = e.Bounds;
		int width = bounds.Width;
		bounds = e.Bounds;
		((Control)this).SetBounds(x, y, width, bounds.Height, e.BoundsSpecified);
	}

	private void webBrowser_WindowClosed(object sender, EventArgs e)
	{
		((Form)this).Close();
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
		webBrowser = new GeckoWebBrowser();
		((Control)this).SuspendLayout();
		((Control)webBrowser).set_Dock((DockStyle)5);
		((Control)webBrowser).set_Location(new Point(0, 0));
		((Control)webBrowser).set_Name("webBrowser");
		((Control)webBrowser).set_Size(new Size(500, 353));
		((Control)webBrowser).set_TabIndex(0);
		webBrowser.UseHttpActivityObserver = false;
		webBrowser.WindowClosed += webBrowser_WindowClosed;
		webBrowser.WindowSetBounds += webBrowser_WindowSetBounds;
		webBrowser.DocumentTitleChanged += webBrowser_DocumentTitleChanged;
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(500, 353));
		((Control)this).get_Controls().Add((Control)(object)webBrowser);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("ChromeDialog");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)0);
		((Control)this).set_Text("ChromeDialog");
		((Control)this).ResumeLayout(false);
	}
}
