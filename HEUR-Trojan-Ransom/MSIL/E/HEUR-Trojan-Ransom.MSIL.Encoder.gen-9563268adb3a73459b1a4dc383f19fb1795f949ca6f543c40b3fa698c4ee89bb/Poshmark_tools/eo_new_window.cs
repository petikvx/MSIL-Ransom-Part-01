using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using EO.WebBrowser;
using EO.WinForm;

namespace Poshmark_tools;

public class eo_new_window : Form
{
	private IContainer components = null;

	public WebView webView1;

	private WebView webView2;

	public WebControl webControl1;

	public eo_new_window()
	{
		InitializeComponent();
		((Control)webControl1).set_Dock((DockStyle)5);
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		webView1 = new WebView();
		webControl1 = new WebControl();
		webView2 = new WebView();
		((Control)this).SuspendLayout();
		webView1.set_InputMsgFilter((IInputMsgFilter)null);
		webView1.set_ObjectForScripting((object)null);
		webView1.set_Title((string)null);
		((Control)webControl1).set_BackColor(Color.White);
		((Control)webControl1).set_Location(new Point(0, 0));
		((Control)webControl1).set_Name("webControl1");
		((Control)webControl1).set_Size(new Size(250, 250));
		((Control)webControl1).set_TabIndex(0);
		((Control)webControl1).set_Text("webControl1");
		webControl1.set_WebView(webView2);
		webView2.set_InputMsgFilter((IInputMsgFilter)null);
		webView2.set_ObjectForScripting((object)null);
		webView2.set_Title((string)null);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(9f, 20f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(797, 360));
		((Control)this).get_Controls().Add((Control)(object)webControl1);
		((Control)this).set_Name("eo_new_window");
		((Control)this).set_Text("eo_new_window");
		((Control)this).ResumeLayout(false);
	}
}
