using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Windows.Forms;
using Microsoft.JScript;
using SHDocVw;

namespace WebCruiserWVS;

public class FormBrowser : Form
{
	private IContainer icontainer_0;

	private WebBrowser WCRBrowser;

	private Timer timer_0;

	private TabControl tabBrowserForm;

	private TabPage tabBrowser;

	private TabPage tabResend;

	private ToolStrip toolStripResend;

	private ToolStripLabel LabelResendURL;

	private ToolStripSeparator toolStripSeparator1;

	private ToolStripTextBox TextBoxResendURL;

	private ToolStripButton ButtonResend;

	private ToolStripSeparator toolStripSeparator2;

	private ToolStripSeparator toolStripSeparator3;

	private ToolStripSeparator toolStripSeparator4;

	private ImageList imageList_0;

	private ToolStrip toolStripResendResponse;

	private ToolStripSeparator toolStripSeparator5;

	private ToolStripLabel LabelResponseCode;

	private SplitContainer splitContainerResend;

	private TextBox txtResendPostData;

	private TextBox txtResendResponseCode;

	private ToolStripSeparator toolStripSeparator6;

	private ToolStripButton ButtonLoadInBrowser;

	private ToolStripSeparator toolStripSeparator7;

	private FormMain formMain_0;

	private string string_0 = "";

	private string string_1 = "";

	private WebBrowser webBrowser_0;

	void Form.Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected O, but got Unknown
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_0764: Unknown result type (might be due to invalid IL or missing references)
		//IL_076e: Expected O, but got Unknown
		//IL_09db: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e5: Expected O, but got Unknown
		//IL_0a74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7e: Expected O, but got Unknown
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormBrowser));
		WCRBrowser = new WebBrowser();
		timer_0 = new Timer(icontainer_0);
		tabBrowserForm = new TabControl();
		tabBrowser = new TabPage();
		tabResend = new TabPage();
		splitContainerResend = new SplitContainer();
		txtResendPostData = new TextBox();
		txtResendResponseCode = new TextBox();
		toolStripResendResponse = new ToolStrip();
		toolStripSeparator5 = new ToolStripSeparator();
		LabelResponseCode = new ToolStripLabel();
		toolStripSeparator6 = new ToolStripSeparator();
		ButtonLoadInBrowser = new ToolStripButton();
		toolStripSeparator7 = new ToolStripSeparator();
		toolStripResend = new ToolStrip();
		toolStripSeparator4 = new ToolStripSeparator();
		LabelResendURL = new ToolStripLabel();
		toolStripSeparator1 = new ToolStripSeparator();
		TextBoxResendURL = new ToolStripTextBox();
		toolStripSeparator2 = new ToolStripSeparator();
		ButtonResend = new ToolStripButton();
		toolStripSeparator3 = new ToolStripSeparator();
		imageList_0 = new ImageList(icontainer_0);
		((Control)tabBrowserForm).SuspendLayout();
		((Control)tabBrowser).SuspendLayout();
		((Control)tabResend).SuspendLayout();
		((Control)splitContainerResend.get_Panel1()).SuspendLayout();
		((Control)splitContainerResend.get_Panel2()).SuspendLayout();
		((Control)splitContainerResend).SuspendLayout();
		((Control)toolStripResendResponse).SuspendLayout();
		((Control)toolStripResend).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)WCRBrowser).set_Dock((DockStyle)5);
		((Control)WCRBrowser).set_Location(new Point(3, 3));
		((Control)WCRBrowser).set_Margin(new Padding(3, 4, 3, 4));
		((Control)WCRBrowser).set_MinimumSize(new Size(23, 25));
		((Control)WCRBrowser).set_Name("WCRBrowser");
		((Control)WCRBrowser).set_Size(new Size(616, 347));
		((Control)WCRBrowser).set_TabIndex(1);
		WCRBrowser.add_DocumentCompleted(new WebBrowserDocumentCompletedEventHandler(WCRBrowser_DocumentCompleted));
		WCRBrowser.add_StatusTextChanged((EventHandler)WCRBrowser_StatusTextChanged);
		timer_0.set_Interval(30000);
		timer_0.add_Tick((EventHandler)timer_0_Tick);
		((Control)tabBrowserForm).get_Controls().Add((Control)(object)tabBrowser);
		((Control)tabBrowserForm).get_Controls().Add((Control)(object)tabResend);
		((Control)tabBrowserForm).set_Dock((DockStyle)5);
		tabBrowserForm.set_ImageList(imageList_0);
		((Control)tabBrowserForm).set_Location(new Point(0, 0));
		((Control)tabBrowserForm).set_Name("tabBrowserForm");
		tabBrowserForm.set_SelectedIndex(0);
		((Control)tabBrowserForm).set_Size(new Size(630, 380));
		((Control)tabBrowserForm).set_TabIndex(2);
		((Control)tabBrowser).get_Controls().Add((Control)(object)WCRBrowser);
		tabBrowser.set_ImageKey("ie.png");
		tabBrowser.set_Location(new Point(4, 23));
		((Control)tabBrowser).set_Name("tabBrowser");
		((Control)tabBrowser).set_Padding(new Padding(3));
		((Control)tabBrowser).set_Size(new Size(622, 353));
		tabBrowser.set_TabIndex(0);
		((Control)tabBrowser).set_Text("WebBrowser");
		tabBrowser.set_UseVisualStyleBackColor(true);
		((Control)tabResend).get_Controls().Add((Control)(object)splitContainerResend);
		((Control)tabResend).get_Controls().Add((Control)(object)toolStripResendResponse);
		((Control)tabResend).get_Controls().Add((Control)(object)toolStripResend);
		tabResend.set_ImageKey("resend.png");
		tabResend.set_Location(new Point(4, 23));
		((Control)tabResend).set_Name("tabResend");
		((Control)tabResend).set_Padding(new Padding(3));
		((Control)tabResend).set_Size(new Size(622, 353));
		tabResend.set_TabIndex(1);
		((Control)tabResend).set_Text("Resend");
		tabResend.set_UseVisualStyleBackColor(true);
		splitContainerResend.set_Dock((DockStyle)5);
		((Control)splitContainerResend).set_Location(new Point(3, 28));
		((Control)splitContainerResend).set_Name("splitContainerResend");
		splitContainerResend.set_Orientation((Orientation)0);
		((Control)splitContainerResend.get_Panel1()).get_Controls().Add((Control)(object)txtResendPostData);
		((Control)splitContainerResend.get_Panel2()).get_Controls().Add((Control)(object)txtResendResponseCode);
		((Control)splitContainerResend).set_Size(new Size(616, 297));
		splitContainerResend.set_SplitterDistance(95);
		((Control)splitContainerResend).set_TabIndex(3);
		((Control)txtResendPostData).set_Dock((DockStyle)5);
		((Control)txtResendPostData).set_Location(new Point(0, 0));
		((TextBoxBase)txtResendPostData).set_Multiline(true);
		((Control)txtResendPostData).set_Name("txtResendPostData");
		((Control)txtResendPostData).set_Size(new Size(616, 95));
		((Control)txtResendPostData).set_TabIndex(0);
		((Control)txtResendPostData).set_Text("Post Data");
		((Control)txtResendResponseCode).set_Dock((DockStyle)5);
		((Control)txtResendResponseCode).set_Location(new Point(0, 0));
		((TextBoxBase)txtResendResponseCode).set_Multiline(true);
		((Control)txtResendResponseCode).set_Name("txtResendResponseCode");
		txtResendResponseCode.set_ScrollBars((ScrollBars)3);
		((Control)txtResendResponseCode).set_Size(new Size(616, 198));
		((Control)txtResendResponseCode).set_TabIndex(0);
		((Control)txtResendResponseCode).set_Text("Response Source Code");
		toolStripResendResponse.set_BackColor(SystemColors.ButtonFace);
		((Control)toolStripResendResponse).set_Dock((DockStyle)2);
		toolStripResendResponse.set_GripStyle((ToolStripGripStyle)0);
		toolStripResendResponse.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)toolStripSeparator5,
			(ToolStripItem)LabelResponseCode,
			(ToolStripItem)toolStripSeparator6,
			(ToolStripItem)ButtonLoadInBrowser,
			(ToolStripItem)toolStripSeparator7
		});
		((Control)toolStripResendResponse).set_Location(new Point(3, 325));
		((Control)toolStripResendResponse).set_Name("toolStripResendResponse");
		((Control)toolStripResendResponse).set_Size(new Size(616, 25));
		((Control)toolStripResendResponse).set_TabIndex(2);
		((Control)toolStripResendResponse).set_Text("toolStrip1");
		((ToolStripItem)toolStripSeparator5).set_Name("toolStripSeparator5");
		((ToolStripItem)toolStripSeparator5).set_Size(new Size(6, 25));
		((ToolStripItem)LabelResponseCode).set_AutoSize(false);
		((ToolStripItem)LabelResponseCode).set_Name("LabelResponseCode");
		((ToolStripItem)LabelResponseCode).set_Size(new Size(150, 22));
		((ToolStripItem)LabelResponseCode).set_Text("StatusCode");
		((ToolStripItem)LabelResponseCode).set_TextAlign((ContentAlignment)16);
		((ToolStripItem)toolStripSeparator6).set_Name("toolStripSeparator6");
		((ToolStripItem)toolStripSeparator6).set_Size(new Size(6, 25));
		((ToolStripItem)ButtonLoadInBrowser).set_DisplayStyle((ToolStripItemDisplayStyle)1);
		((ToolStripItem)ButtonLoadInBrowser).set_Image((Image)componentResourceManager.GetObject("ButtonLoadInBrowser.Image"));
		((ToolStripItem)ButtonLoadInBrowser).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)ButtonLoadInBrowser).set_Name("ButtonLoadInBrowser");
		((ToolStripItem)ButtonLoadInBrowser).set_Size(new Size(117, 22));
		((ToolStripItem)ButtonLoadInBrowser).set_Text("Load in WebBrowser");
		((ToolStripItem)ButtonLoadInBrowser).add_Click((EventHandler)ButtonLoadInBrowser_Click);
		((ToolStripItem)toolStripSeparator7).set_Name("toolStripSeparator7");
		((ToolStripItem)toolStripSeparator7).set_Size(new Size(6, 25));
		toolStripResend.set_BackColor(SystemColors.ButtonFace);
		toolStripResend.set_GripStyle((ToolStripGripStyle)0);
		toolStripResend.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[7]
		{
			(ToolStripItem)toolStripSeparator4,
			(ToolStripItem)LabelResendURL,
			(ToolStripItem)toolStripSeparator1,
			(ToolStripItem)TextBoxResendURL,
			(ToolStripItem)toolStripSeparator2,
			(ToolStripItem)ButtonResend,
			(ToolStripItem)toolStripSeparator3
		});
		((Control)toolStripResend).set_Location(new Point(3, 3));
		((Control)toolStripResend).set_Name("toolStripResend");
		((Control)toolStripResend).set_Size(new Size(616, 25));
		((Control)toolStripResend).set_TabIndex(0);
		((Control)toolStripResend).set_Text("toolStrip1");
		((Control)toolStripResend).add_Resize((EventHandler)toolStripResend_Resize);
		((ToolStripItem)toolStripSeparator4).set_Name("toolStripSeparator4");
		((ToolStripItem)toolStripSeparator4).set_Size(new Size(6, 25));
		((ToolStripItem)LabelResendURL).set_Name("LabelResendURL");
		((ToolStripItem)LabelResendURL).set_Size(new Size(59, 22));
		((ToolStripItem)LabelResendURL).set_Text("ActionURL");
		((ToolStripItem)toolStripSeparator1).set_Name("toolStripSeparator1");
		((ToolStripItem)toolStripSeparator1).set_Size(new Size(6, 25));
		((ToolStripItem)TextBoxResendURL).set_AutoSize(false);
		((ToolStripItem)TextBoxResendURL).set_Name("TextBoxResendURL");
		((ToolStripItem)TextBoxResendURL).set_Overflow((ToolStripItemOverflow)0);
		((ToolStripItem)TextBoxResendURL).set_Size(new Size(450, 25));
		((ToolStripItem)TextBoxResendURL).add_DoubleClick((EventHandler)TextBoxResendURL_DoubleClick);
		((ToolStripItem)toolStripSeparator2).set_Name("toolStripSeparator2");
		((ToolStripItem)toolStripSeparator2).set_Size(new Size(6, 25));
		((ToolStripItem)ButtonResend).set_DisplayStyle((ToolStripItemDisplayStyle)1);
		((ToolStripItem)ButtonResend).set_Image((Image)componentResourceManager.GetObject("ButtonResend.Image"));
		((ToolStripItem)ButtonResend).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)ButtonResend).set_Name("ButtonResend");
		((ToolStripItem)ButtonResend).set_Size(new Size(45, 22));
		((ToolStripItem)ButtonResend).set_Text("Resend");
		((ToolStripItem)ButtonResend).add_Click((EventHandler)ButtonResend_Click);
		((ToolStripItem)toolStripSeparator3).set_Name("toolStripSeparator3");
		((ToolStripItem)toolStripSeparator3).set_Size(new Size(6, 25));
		imageList_0.set_ImageStream((ImageListStreamer)componentResourceManager.GetObject("ImageListBrowser.ImageStream"));
		imageList_0.set_TransparentColor(Color.Transparent);
		imageList_0.get_Images().SetKeyName(0, "ie.png");
		imageList_0.get_Images().SetKeyName(1, "resend.png");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(630, 380));
		((Control)this).get_Controls().Add((Control)(object)tabBrowserForm);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("FormBrowser");
		((Control)this).set_Text("WebBrowser");
		((Control)tabBrowserForm).ResumeLayout(false);
		((Control)tabBrowser).ResumeLayout(false);
		((Control)tabResend).ResumeLayout(false);
		((Control)tabResend).PerformLayout();
		((Control)splitContainerResend.get_Panel1()).ResumeLayout(false);
		((Control)splitContainerResend.get_Panel1()).PerformLayout();
		((Control)splitContainerResend.get_Panel2()).ResumeLayout(false);
		((Control)splitContainerResend.get_Panel2()).PerformLayout();
		((Control)splitContainerResend).ResumeLayout(false);
		((Control)toolStripResendResponse).ResumeLayout(false);
		((Control)toolStripResendResponse).PerformLayout();
		((Control)toolStripResend).ResumeLayout(false);
		((Control)toolStripResend).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	public FormBrowser(FormMain formMain_1)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		InitializeComponent();
		formMain_0 = formMain_1;
		method_1();
		((Control)toolStripResendResponse).set_Visible(true);
		try
		{
			webBrowser_0 = (WebBrowser)((WebBrowserBase)WCRBrowser).get_ActiveXInstance();
			((DWebBrowserEvents2_Event)webBrowser_0).add_BeforeNavigate2(new DWebBrowserEvents2_BeforeNavigate2EventHandler(wb_BeforeNavigate2));
			((DWebBrowserEvents2_Event)webBrowser_0).add_NewWindow3(new DWebBrowserEvents2_NewWindow3EventHandler(method_0));
		}
		catch
		{
		}
	}

	private void method_0(ref object object_0, ref bool bool_0, uint uint_0, string string_2, string string_3)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (string_3.IndexOf("http") >= 0)
			{
				bool_0 = true;
				WCRBrowser.Navigate(string_3, false);
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void method_1()
	{
		WCRBrowser.Navigate("about:blank");
		string text = "<br>WebCruiser - Web Vulnerability Scanner<br><br>";
		text += "<a href=\"http://sec4app.com\">http://sec4app.com</a><br>";
		WCRBrowser.get_Document().Write(text);
	}

	public void method_2(string string_2, GEnum0 genum0_0, string string_3)
	{
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			byte[] array = null;
			switch (genum0_0)
			{
			case GEnum0.POST:
				array = Encoding.UTF8.GetBytes(string_3);
				break;
			case GEnum0.COOKIE:
				formMain_0.gclass0_0.method_26(string_3);
				break;
			}
			formMain_0.method_11("Navigating ...");
			timer_0.Start();
			WCRBrowser.Navigate(string_2, (string)null, array, "Content-Type: application/x-www-form-urlencoded\r\n");
			tabBrowserForm.SelectTab(tabBrowser);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message + "\r\nWebBrowser Closed! Please Exit and Run again!");
		}
	}

	private bool method_3(string string_2)
	{
		bool result = false;
		if (Regex.IsMatch(string_2, "(.gov.\\w+$)|(.gov$)"))
		{
			result = true;
		}
		else if (Regex.IsMatch(string_2, "(.mil.\\w+$)|(.mil$)"))
		{
			result = true;
		}
		return result;
	}

	private void method_4()
	{
		formMain_0.gclass0_0.method_19(GEnum2.UnKnown);
		formMain_0.gclass0_0.method_21(GEnum3.UnKnown);
		formMain_0.method_34("");
	}

	private void method_5()
	{
		try
		{
			string text = WCRBrowser.get_Url().ToString();
			if (text.IndexOf("about:") != 0)
			{
				if (WCRSetting.bool_6)
				{
					formMain_0.method_3(text);
				}
				string encoding = WCRBrowser.get_Document().get_Encoding();
				if (string.IsNullOrEmpty(encoding))
				{
					formMain_0.gclass0_0.encoding_0 = Encoding.Default;
				}
				else
				{
					formMain_0.gclass0_0.encoding_0 = Encoding.GetEncoding(encoding);
				}
				formMain_0.gclass0_0.encoding_1 = formMain_0.gclass0_0.encoding_0;
			}
			if (!string.IsNullOrEmpty(string_0))
			{
				method_4();
			}
			if (!formMain_0.gclass0_0.method_11().Equals(string_0))
			{
				formMain_0.gclass0_0.string_3 = "";
			}
			string_0 = formMain_0.gclass0_0.method_11();
			formMain_0.method_11("Done");
			string cookie = WCRBrowser.get_Document().get_Cookie();
			if (!string.IsNullOrEmpty(cookie))
			{
				cookie = cookie.Replace(';', ',');
				formMain_0.gclass0_0.cookieContainer_0.SetCookies(formMain_0.gclass0_0.method_7(), cookie);
			}
		}
		catch
		{
		}
	}

	private void WCRBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		if ((int)WCRBrowser.get_ReadyState() == 4 && !(WCRBrowser.get_Url().ToString() == string_1))
		{
			string_1 = WCRBrowser.get_Url().ToString();
			method_5();
		}
	}

	private void WCRBrowser_StatusTextChanged(object sender, EventArgs e)
	{
		formMain_0.method_12(WCRBrowser.get_StatusText().Replace("&", "&&"));
	}

	public string method_6()
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string encoding = WCRBrowser.get_Document().get_Encoding();
			StreamReader streamReader = ((!string.IsNullOrEmpty(encoding)) ? new StreamReader(WCRBrowser.get_DocumentStream(), Encoding.GetEncoding(encoding)) : new StreamReader(WCRBrowser.get_DocumentStream(), Encoding.Default));
			string result = streamReader.ReadToEnd();
			streamReader.Close();
			return result;
		}
		catch
		{
			MessageBox.Show("* Null Source Code: Disabled OR No Page Navigated!\r\n* Try To Get Code From URL.");
			return "";
		}
	}

	public void method_7(string string_2, string string_3, string string_4)
	{
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		formMain_0.method_28(string_2, GEnum0.GET, "");
		string[] array = GClass0.smethod_1(string_4, '=');
		string value = array[0];
		string string_5 = array[1];
		string[] array2 = new string[2];
		if (string_3.IndexOf('^') > 0)
		{
			array2 = GClass0.smethod_1(string_3, '^');
		}
		else
		{
			if (string_3.IndexOf('?') <= 0)
			{
				return;
			}
			array2 = GClass0.smethod_1(string_3, '?');
		}
		string[] array3 = array2[1].Split(new char[1] { '&' });
		MessageBox.Show("* It Will Open The XPath Page And Fill In Input Fields Automatically! \r\n* When Page Load Completed, Click OK To Continue!", "Information", (MessageBoxButtons)0, (MessageBoxIcon)64);
		formMain_0.method_11("Preparing XPath Data...");
		foreach (HtmlElement item in WCRBrowser.get_Document().get_All())
		{
			HtmlElement val = item;
			for (int i = 0; i < array3.Length; i++)
			{
				string[] array4 = GClass0.smethod_1(array3[i], '=');
				if (val.get_Name().Equals(array4[0]))
				{
					val.SetAttribute("value", GlobalObject.unescape((object)GClass0.smethod_6(array4[1])));
				}
			}
			if (val.get_Name().Equals(value))
			{
				val.SetAttribute("value", GlobalObject.unescape((object)(GClass0.smethod_6(string_5) + "%27] | * | user[@role=%27admin")));
			}
		}
		formMain_0.method_11("Done");
		MessageBox.Show("* XPath Data Filled OK, You Can View Or Change It Now!\r\n* Then Click Button To Submit The Form Manually! \r\n* You Will Get The Response Possibly Include Confidential Data!", "Information", (MessageBoxButtons)0, (MessageBoxIcon)64);
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		if ((int)WCRBrowser.get_ReadyState() != 4)
		{
			if (string_1 != WCRBrowser.get_Url().ToString())
			{
				string_1 = WCRBrowser.get_Url().ToString();
				method_5();
			}
			WCRBrowser.Stop();
		}
		timer_0.Stop();
	}

	public void method_8(string string_2)
	{
		formMain_0.method_11("Filling Forms...");
		string_2 = string_2.Replace("&amp;", "&");
		string_2 = HttpUtility.UrlDecode(string_2, formMain_0.gclass0_0.encoding_0);
		string[] array = string_2.Split(new char[1] { '&' });
		string[] array2 = array;
		foreach (string string_3 in array2)
		{
			string[] array3 = GClass0.smethod_1(string_3, '=');
			try
			{
				WCRBrowser.get_Document().get_All().get_Item(array3[0])
					.SetAttribute("value", GlobalObject.unescape((object)array3[1]));
			}
			catch
			{
			}
			HtmlWindowCollection frames = WCRBrowser.get_Document().get_Window().get_Frames();
			for (int j = 0; j < frames.get_Count(); j++)
			{
				try
				{
					HtmlDocument document = WCRBrowser.get_Document().get_Window().get_Frames()
						.get_Item(j)
						.get_Document();
					document.get_All().get_Item(array3[0]).SetAttribute("value", GlobalObject.unescape((object)array3[1]));
				}
				catch
				{
				}
			}
		}
		formMain_0.method_11("Done");
	}

	public int method_9()
	{
		HtmlWindowCollection frames = WCRBrowser.get_Document().get_Window().get_Frames();
		return frames.get_Count();
	}

	public string method_10(int int_0)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			return WCRBrowser.get_Document().get_Window().get_Frames()
				.get_Item(int_0)
				.get_Document()
				.get_Body()
				.get_OuterHtml();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
			return "";
		}
	}

	public string method_11(int int_0)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Uri url = WCRBrowser.get_Document().get_Window().get_Frames()
				.get_Item(int_0)
				.get_Url();
			return url.AbsoluteUri;
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
			return "";
		}
	}

	private void wb_BeforeNavigate2(object pDisp, ref object URL, ref object Flags, ref object TargetFrameName, ref object PostData, ref object Headers, ref bool Cancel)
	{
		string @string = Encoding.ASCII.GetString(PostData as byte[]);
		if (formMain_0.method_0() != GEnum0.COOKIE)
		{
			formMain_0.method_17(@string);
		}
		((ToolStripItem)TextBoxResendURL).set_Text(URL as string);
		((Control)txtResendPostData).set_Text(@string);
	}

	private void TextBoxResendURL_DoubleClick(object sender, EventArgs e)
	{
		TextBoxResendURL.SelectAll();
	}

	private void ButtonResend_Click(object sender, EventArgs e)
	{
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			((ToolStripItem)LabelResponseCode).set_Text("");
			string text = ((Control)txtResendPostData).get_Text();
			string text2 = ((ToolStripItem)TextBoxResendURL).get_Text();
			if (!string.IsNullOrEmpty(text2))
			{
				text2 = text2 + "^" + text;
				formMain_0.method_11("Resend...");
				HttpWebResponse httpWebResponse = formMain_0.gclass0_0.method_28(text2, GEnum0.POST);
				string text3 = formMain_0.gclass0_0.method_29(httpWebResponse);
				((Control)txtResendResponseCode).set_Text(text3);
				((ToolStripItem)LabelResponseCode).set_Text(httpWebResponse.StatusCode.ToString());
				formMain_0.method_11("Done");
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void ButtonLoadInBrowser_Click(object sender, EventArgs e)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Invalid comparison between Unknown and I4
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string text = ((Control)txtResendResponseCode).get_Text();
			if (!string.IsNullOrEmpty(text))
			{
				Encoding encoding_ = formMain_0.gclass0_0.encoding_0;
				WCRBrowser.Navigate("about:blank");
				do
				{
					Application.DoEvents();
				}
				while ((int)WCRBrowser.get_ReadyState() != 4);
				formMain_0.gclass0_0.encoding_0 = encoding_;
				WCRBrowser.get_Document().Write(text);
				tabBrowserForm.SelectTab(tabBrowser);
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void toolStripResend_Resize(object sender, EventArgs e)
	{
		((ToolStripItem)TextBoxResendURL).set_Width(((Control)toolStripResend).get_Width() - 135);
	}

	public void method_12(string string_2)
	{
		tabBrowserForm.SelectTab(string_2);
	}
}
