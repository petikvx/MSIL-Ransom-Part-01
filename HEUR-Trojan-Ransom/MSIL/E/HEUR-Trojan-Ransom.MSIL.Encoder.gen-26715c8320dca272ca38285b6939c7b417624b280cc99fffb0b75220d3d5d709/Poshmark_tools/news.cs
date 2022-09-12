using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace Poshmark_tools;

public class news : UserControl
{
	private IContainer components = null;

	public news()
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		InitializeComponent();
		((Control)Form1.news_webbrowser_2).set_Dock((DockStyle)5);
		Form1.news_webbrowser_2.set_ScriptErrorsSuppressed(true);
		((Control)this).get_Controls().Add((Control)(object)Form1.news_webbrowser_2);
		Form1.news_webbrowser_2.Navigate("www.poshmarktools.com/news");
		Form1.news_webbrowser_2.add_Navigating(new WebBrowserNavigatingEventHandler(webBrowser1_Navigating));
	}

	public void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
		if (e.get_Url().AbsolutePath != "/plugins/like.php")
		{
			Process.Start(e.get_Url().ToString());
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((ContainerControl)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_Name("news");
		((Control)this).set_Size(new Size(454, 335));
		((Control)this).ResumeLayout(false);
	}
}
