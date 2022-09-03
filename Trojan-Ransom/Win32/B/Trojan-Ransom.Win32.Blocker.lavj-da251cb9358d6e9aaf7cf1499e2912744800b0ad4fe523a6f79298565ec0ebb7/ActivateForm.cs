using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public sealed class ActivateForm : Form
{
	private IContainer icontainer_0;

	private Class7 panel1;

	private WebBrowser webBrowser1;

	private PictureBox pictureBox1;

	private Timer timer_0;

	public ActivateForm()
	{
		InitializeComponent();
		((Form)this).set_WindowState((FormWindowState)2);
		timer_0.add_Tick((EventHandler)timer_0_Tick);
	}

	private void ActivateForm_Load(object sender, EventArgs e)
	{
		webBrowser1.Navigate(Class6.string_3);
	}

	private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
		try
		{
			HtmlElementCollection elementsByTagName = webBrowser1.get_Document().GetElementsByTagName("head");
			if (elementsByTagName != null)
			{
				string text = Class3.smethod_15();
				HtmlElement val = webBrowser1.get_Document().CreateElement("script");
				val.SetAttribute("type", "text/javascript");
				val.SetAttribute("text", text);
				elementsByTagName.get_Item(0).AppendChild(val);
				string text2 = Class3.smethod_3();
				HtmlElement val2 = webBrowser1.get_Document().CreateElement("script");
				val2.SetAttribute("type", "text/javascript");
				val2.SetAttribute("text", text2);
				elementsByTagName.get_Item(0).AppendChild(val2);
			}
		}
		catch (Exception)
		{
		}
		timer_0.set_Interval(500);
		timer_0.Start();
	}

	private void panel1_Resize(object sender, EventArgs e)
	{
		((Control)webBrowser1).set_Size(new Size(((Control)this).get_ClientRectangle().Width - 24, ((Control)this).get_ClientRectangle().Height - 24));
		((Control)this).Invalidate();
	}

	private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
	{
		((Control)pictureBox1).set_Visible(true);
		((Control)webBrowser1).set_Visible(false);
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		timer_0.Stop();
		((Control)webBrowser1).set_Visible(true);
		((Control)pictureBox1).set_Visible(false);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected O, but got Unknown
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected O, but got Unknown
		panel1 = new Class7();
		pictureBox1 = new PictureBox();
		webBrowser1 = new WebBrowser();
		timer_0 = new Timer();
		((Control)panel1).SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)panel1).set_BackgroundImageLayout((ImageLayout)0);
		panel1.method_5(Color.FromArgb(92, 103, 115));
		((Control)panel1).get_Controls().Add((Control)(object)pictureBox1);
		((Control)panel1).get_Controls().Add((Control)(object)webBrowser1);
		((Control)panel1).set_Dock((DockStyle)5);
		panel1.method_7(0f);
		panel1.method_1(Color.Empty);
		panel1.method_3(Color.Empty);
		((Control)panel1).set_Location(new Point(0, 0));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(858, 492));
		((Control)panel1).set_TabIndex(0);
		((Control)panel1).add_Resize((EventHandler)panel1_Resize);
		((Control)pictureBox1).set_Anchor((AnchorStyles)15);
		((Control)pictureBox1).set_BackColor(SystemColors.Window);
		((Control)pictureBox1).set_BackgroundImageLayout((ImageLayout)2);
		pictureBox1.set_Image((Image)(object)Class3.smethod_16());
		((Control)pictureBox1).set_Location(new Point(12, 12));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(834, 468));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)3);
		pictureBox1.set_TabIndex(1);
		pictureBox1.set_TabStop(false);
		((Control)pictureBox1).set_UseWaitCursor(true);
		webBrowser1.set_IsWebBrowserContextMenuEnabled(false);
		((Control)webBrowser1).set_Location(new Point(12, 12));
		((Control)webBrowser1).set_MinimumSize(new Size(20, 20));
		((Control)webBrowser1).set_Name("webBrowser1");
		((Control)webBrowser1).set_Size(new Size(834, 468));
		((Control)webBrowser1).set_TabIndex(0);
		webBrowser1.add_DocumentCompleted(new WebBrowserDocumentCompletedEventHandler(webBrowser1_DocumentCompleted));
		webBrowser1.add_Navigating(new WebBrowserNavigatingEventHandler(webBrowser1_Navigating));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(858, 492));
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("ActivateForm");
		((Control)this).set_Text("Follow steps to activate Total Protection");
		((Form)this).set_TopMost(true);
		((Form)this).set_WindowState((FormWindowState)2);
		((Form)this).add_Load((EventHandler)ActivateForm_Load);
		((Control)panel1).ResumeLayout(false);
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
