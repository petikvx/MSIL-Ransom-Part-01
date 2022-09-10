using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using Microsoft.Win32;
using WebCruiserWVS.Properties;

namespace WebCruiserWVS;

public class FormMain : Form
{
	private delegate void Delegate0(string string_0);

	private delegate string Delegate1();

	private delegate void Delegate2(bool bool_0);

	public struct GStruct0
	{
		public TextBox textBox_0;

		public string string_0;
	}

	private delegate void Delegate3(GStruct0 gstruct0_0);

	private delegate void Delegate4(FormScanner formScanner_0);

	private GEnum0 genum0_0;

	public GClass0 gclass0_0 = new GClass0("");

	private FormBrowser formBrowser_0;

	private FormScanner formScanner_0;

	private FormSQL formSQL_0;

	private FormXSS formXSS_0;

	private FormCode formCode_0;

	private FormCookie formCookie_0;

	private FormSetting formSetting_0;

	private FormAdmin formAdmin_0;

	private FormReport formReport_0;

	private FormAbout formAbout_0;

	private string string_0 = "http://www.janusec.com/";

	private IContainer icontainer_0;

	private MenuStrip menuStripMain;

	private ToolStrip toolStripMain;

	private StatusStrip statusStripMain;

	private ToolStrip toolStripURL;

	private SplitContainer splitMain;

	private ToolStripMenuItem MenuItemFile;

	private TreeView treeViewToolTree;

	private ToolStripLabel toolStripLabel1;

	private ToolStripSeparator toolStripSeparator1;

	private ToolStripTextBox txtURL;

	private ToolStripButton toolStripBtnGo;

	private ToolStripButton toolStripBtnPause;

	private ToolStripButton toolStripBtnStop;

	private ImageList imageList_0;

	private ToolStripStatusLabel toolStripStatusProgress;

	private ToolStripComboBox cmbReqType;

	private ToolStrip toolStripData;

	private ToolStripLabel lblSubmitData;

	private ToolStripSeparator toolStripSeparator2;

	private ToolStripTextBox txtSubmitData;

	private ToolStripSeparator toolStripSeparator3;

	private ToolStripStatusLabel toolStripStatusSep1;

	private ToolStripMenuItem MenuItemExit;

	private ToolStripButton toolStripButtonNew;

	private ToolStripButton toolStripButtonOpen;

	private ToolStripButton toolStripButtonSave;

	private ToolStripSeparator toolStripSeparator4;

	private ToolStripMenuItem MenuItemTool;

	private ToolStripMenuItem MenuItemHelp;

	private ToolStripMenuItem MenuItemNew;

	private ToolStripMenuItem MenuItemOpen;

	private ToolStripMenuItem MenuItemSave;

	private ToolStripMenuItem MenuItemAbout;

	private ToolStripMenuItem MenuItemCheckUpdate;

	private ToolStripMenuItem MenuItemWebBrowser;

	private ToolStripSeparator toolStripSeparator5;

	private ToolStripSeparator toolStripSeparator6;

	private ToolStripSeparator toolStripSeparator7;

	private ToolStripSeparator toolStripSeparator8;

	private ToolStripMenuItem MenuItemSaveAs;

	private ToolStripMenuItem MenuItemScanner;

	private ToolStripSeparator toolStripSeparator9;

	private ToolStripMenuItem MenuItemSQLInjection;

	private ToolStripMenuItem MenuItemXSS;

	private ToolStripButton toolStripButtonBrowser;

	private ToolStripButton toolStripButtonScanner;

	private ToolStripSeparator toolStripSeparator10;

	private ToolStripButton toolStripButtonSQL;

	private ToolStripButton toolStripButtonXSS;

	private ToolStripSeparator toolStripSeparator11;

	private ToolStripButton ButtonSetting;

	private ToolStripButton ButtonReport;

	private ToolStripMenuItem MenuItemReport;

	private ToolStripSeparator toolStripSeparator12;

	private Timer timer_0;

	private ToolStripStatusLabel lblThreadNum;

	private ToolStripSeparator toolStripSeparator13;

	private ToolStripButton ButtonScanURL;

	private ToolStripButton ButtonScanSite;

	private ToolStripSeparator toolStripSeparator14;

	private ToolStripSeparator toolStripSeparator15;

	private ToolStripMenuItem MenuItemOrder;

	private ToolStripSeparator toolStripSeparator16;

	private ToolStripButton ButtonAutoFill;

	private ToolStripButton ButtonCookie;

	private ToolStripButton ButtonTest;

	private ToolStripButton ButtonResend;

	private ToolStripSeparator toolStripSeparator17;

	private ToolStripSeparator toolStripSeparator18;

	private ToolStripMenuItem MenuItemOnlineHelp;

	private ToolStripMenuItem MenuItemFeedback;

	private ToolStripMenuItem MenuItemConfig;

	private ToolStripMenuItem MenuItemSettings;

	private ToolStripMenuItem MenuItemWebsite;

	private ToolStripMenuItem MenuItemResend;

	private ToolStripMenuItem MenuItemCookie;

	private ToolStripSeparator toolStripSeparator19;

	private ToolStripMenuItem MenuItemRefreshURL;

	private ToolStripMenuItem MenuItemEscapeCookie;

	private ToolStripSeparator toolStripSeparator20;

	private ToolStripMenuItem MenuItemTextAd;

	private Timer timer_1;

	private ToolStripMenuItem MenuItemView;

	private ToolStripMenuItem MenuItemWebEncoding;

	private ToolStripMenuItem MenuItemDBEncoding;

	private ToolStripMenuItem MenuItemWebEncodingUTF8;

	private ToolStripMenuItem MenuItemWebEncodingUTF16;

	private ToolStripMenuItem MenuItemWebEncodingISO8859;

	private ToolStripMenuItem MenuItemWebEncodingGB2312;

	private ToolStripMenuItem MenuItemWebEncodingBIG5;

	private ToolStripMenuItem MenuItemDBEncodingUTF8;

	private ToolStripMenuItem MenuItemDBEncodingUTF16;

	private ToolStripMenuItem MenuItemDBEncodingISO8859;

	private ToolStripMenuItem MenuItemDBEncodingGB2312;

	private ToolStripMenuItem MenuItemDBEncodingBIG5;

	[SpecialName]
	public GEnum0 method_0()
	{
		return genum0_0;
	}

	[SpecialName]
	public void method_1(GEnum0 genum0_1)
	{
		genum0_0 = genum0_1;
		method_19(genum0_0);
	}

	[SpecialName]
	public string method_2()
	{
		return method_13();
	}

	[SpecialName]
	public void method_3(string string_1)
	{
		gclass0_0.method_9(string_1);
		method_16(string_1);
	}

	[SpecialName]
	public string method_4()
	{
		return method_18();
	}

	[SpecialName]
	public void method_5(string string_1)
	{
		method_17(string_1);
	}

	public FormMain()
	{
		InitializeComponent();
		cmbReqType.set_SelectedIndex(0);
		treeViewToolTree.ExpandAll();
		method_7();
		method_8();
		method_9();
		toolStripURL.set_ImageList(imageList_0);
		method_6();
		((ToolStripItem)ButtonTest).set_Visible(false);
	}

	private void method_6()
	{
		timer_1.set_Enabled(false);
		((ToolStripItem)MenuItemTextAd).set_Visible(false);
	}

	private void method_7()
	{
		((Control)this).set_Text("WebCruiser - Web Vulnerability Scanner Enterprise Edition");
		formBrowser_0 = new FormBrowser(this);
		((Form)formBrowser_0).set_MdiParent((Form)(object)this);
		((Control)splitMain.get_Panel2()).get_Controls().Add((Control)(object)formBrowser_0);
		((Control)formBrowser_0).set_Dock((DockStyle)5);
		((Form)this).LayoutMdi((MdiLayout)0);
		((Control)formBrowser_0).Show();
		formScanner_0 = new FormScanner(this);
		((Form)formScanner_0).set_MdiParent((Form)(object)this);
		((Control)splitMain.get_Panel2()).get_Controls().Add((Control)(object)formScanner_0);
		((Control)formScanner_0).set_Dock((DockStyle)5);
		formSQL_0 = new FormSQL(this);
		((Form)formSQL_0).set_MdiParent((Form)(object)this);
		((Control)splitMain.get_Panel2()).get_Controls().Add((Control)(object)formSQL_0);
		((Control)formSQL_0).set_Dock((DockStyle)5);
		formXSS_0 = new FormXSS(this);
		((Form)formXSS_0).set_MdiParent((Form)(object)this);
		((Control)splitMain.get_Panel2()).get_Controls().Add((Control)(object)formXSS_0);
		((Control)formXSS_0).set_Dock((DockStyle)5);
		formCode_0 = new FormCode(this);
		((Form)formCode_0).set_MdiParent((Form)(object)this);
		((Control)splitMain.get_Panel2()).get_Controls().Add((Control)(object)formCode_0);
		((Control)formCode_0).set_Dock((DockStyle)5);
		formCookie_0 = new FormCookie(this);
		((Form)formCookie_0).set_MdiParent((Form)(object)this);
		((Control)splitMain.get_Panel2()).get_Controls().Add((Control)(object)formCookie_0);
		((Control)formCookie_0).set_Dock((DockStyle)5);
		formSetting_0 = new FormSetting();
		((Form)formSetting_0).set_MdiParent((Form)(object)this);
		((Control)splitMain.get_Panel2()).get_Controls().Add((Control)(object)formSetting_0);
		((Control)formSetting_0).set_Dock((DockStyle)5);
		formAdmin_0 = new FormAdmin(this);
		((Form)formAdmin_0).set_MdiParent((Form)(object)this);
		((Control)splitMain.get_Panel2()).get_Controls().Add((Control)(object)formAdmin_0);
		((Control)formAdmin_0).set_Dock((DockStyle)5);
		formReport_0 = new FormReport(this);
		((Form)formReport_0).set_MdiParent((Form)(object)this);
		((Control)splitMain.get_Panel2()).get_Controls().Add((Control)(object)formReport_0);
		((Control)formReport_0).set_Dock((DockStyle)5);
		formAbout_0 = new FormAbout(this);
		((Form)formAbout_0).set_MdiParent((Form)(object)this);
		((Control)splitMain.get_Panel2()).get_Controls().Add((Control)(object)formAbout_0);
		((Control)formAbout_0).set_Dock((DockStyle)5);
	}

	private void method_8()
	{
		WCRSetting.UseProxy = WebCruiserWVS.Default.UseProxy;
		WCRSetting.ProxyAddress = WebCruiserWVS.Default.ProxyAddress;
		WCRSetting.ProxyPort = WebCruiserWVS.Default.ProxyPort;
		WCRSetting.ProxyUsername = WebCruiserWVS.Default.ProxyUsername;
		WCRSetting.ProxyPassword = WebCruiserWVS.Default.ProxyPassword;
		WCRSetting.UserAgent = WebCruiserWVS.Default.UserAgent;
		WCRSetting.MaxHTTPThreadNum = WebCruiserWVS.Default.MaxHTTPThread;
		ThreadPool.SetMaxThreads(WCRSetting.MaxHTTPThreadNum + 10, (WCRSetting.MaxHTTPThreadNum + 10) * 2);
		WCRSetting.SecondsDelay = WebCruiserWVS.Default.SecondsDelay;
		WCRSetting.bool_0 = WebCruiserWVS.Default.ScanSQLInjection;
		WCRSetting.bool_4 = WebCruiserWVS.Default.ScanXSS;
		WCRSetting.bool_5 = WebCruiserWVS.Default.ScanXPathInjection;
		WCRSetting.bool_1 = WebCruiserWVS.Default.ScanURLSQL;
		WCRSetting.bool_2 = WebCruiserWVS.Default.ScanPostSQL;
		WCRSetting.bool_3 = WebCruiserWVS.Default.ScanCookieSQL;
		WCRSetting.chkReplace1 = WebCruiserWVS.Default.chkReplace1;
		WCRSetting.FiltExpr1 = WebCruiserWVS.Default.FiltExpr1;
		WCRSetting.RepExpr1 = WebCruiserWVS.Default.RepExpr1;
		WCRSetting.chkReplace2 = WebCruiserWVS.Default.chkReplace2;
		WCRSetting.FiltExpr2 = WebCruiserWVS.Default.FiltExpr2;
		WCRSetting.RepExpr2 = WebCruiserWVS.Default.RepExpr2;
		WCRSetting.chkReplace3 = WebCruiserWVS.Default.chkReplace3;
		WCRSetting.FiltExpr3 = WebCruiserWVS.Default.FiltExpr3;
		WCRSetting.RepExpr3 = WebCruiserWVS.Default.RepExpr3;
		WCRSetting.Edition = WebCruiserWVS.Default.Edition;
		WCRSetting.ScanDepth = WebCruiserWVS.Default.ScanDepth;
		WCRSetting.CrawlableExt = WebCruiserWVS.Default.CrawlableExt;
		WCRSetting.MultiSitesNum = WebCruiserWVS.Default.MultiSitesNum;
		WCRSetting.string_0 = WebCruiserWVS.Default.CrossSiteURL;
		WCRSetting.string_1 = WebCruiserWVS.Default.CrossSiteRecord;
	}

	private void method_9()
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Sec4App\\WebCruiser", writable: true);
			if (registryKey == null)
			{
				registryKey = Registry.CurrentUser.CreateSubKey("Software\\Sec4App\\WebCruiser");
				string string_ = DateTime.Now.ToString("yyyy-MM-dd");
				string_ = Class2.smethod_8(string_);
				registryKey.SetValue("InitDate", string_);
				formAbout_0.method_0();
			}
			else
			{
				string text = (string)registryKey.GetValue("Username");
				string text2 = (string)registryKey.GetValue("RegCode");
				if (!string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(text2) && (Class2.smethod_5(text, text2) || Class2.smethod_4(text, text2)))
				{
					Class2.smethod_1(bool_1: true);
				}
				if (!Class2.smethod_0())
				{
					string text3 = (string)registryKey.GetValue("InitDate");
					int num;
					if (string.IsNullOrEmpty(text3))
					{
						num = 30;
					}
					else
					{
						text3 = Class2.smethod_9(text3);
						DateTime value = DateTime.ParseExact(text3, "yyyy-MM-dd", null);
						num = DateTime.Now.Subtract(value).Days;
					}
					Class2.int_0 = 30 - num;
				}
				formAbout_0.method_0();
				string text4 = (string)registryKey.GetValue("Edition");
				if (!string.IsNullOrEmpty(text4) && text4.Equals("Debug"))
				{
					GClass0.bool_2 = true;
				}
				registryKey.Close();
			}
			if (WCRSetting.UseProxy)
			{
				WCRSetting.RefreshIESettings(WCRSetting.ProxyAddress + ":" + WCRSetting.ProxyPort);
			}
		}
		catch
		{
			Class2.smethod_1(bool_1: false);
			formAbout_0.method_0();
		}
	}

	public void method_10(string string_1)
	{
		formScanner_0.method_4(string_1);
	}

	public void method_11(string string_1)
	{
		if (!((Control)statusStripMain).get_InvokeRequired())
		{
			((ToolStripItem)toolStripStatusProgress).set_Text(string_1);
			((Control)statusStripMain).Refresh();
			if (string_1.Length > 5)
			{
				GClass0.smethod_0(string_1);
			}
		}
		else
		{
			Delegate0 @delegate = method_11;
			((Control)this).Invoke((Delegate)@delegate, new object[1] { string_1 });
		}
	}

	public void method_12(string string_1)
	{
		if (!((Control)statusStripMain).get_InvokeRequired())
		{
			((ToolStripItem)toolStripStatusProgress).set_Text(string_1);
			((Control)statusStripMain).Refresh();
		}
		else
		{
			Delegate0 @delegate = method_11;
			((Control)this).Invoke((Delegate)@delegate, new object[1] { string_1 });
		}
	}

	private string method_13()
	{
		if (!((Control)toolStripMain).get_InvokeRequired())
		{
			return ((ToolStripItem)txtURL).get_Text().Trim();
		}
		Delegate1 @delegate = method_13;
		return (string)((Control)this).Invoke((Delegate)@delegate, new object[0]);
	}

	private void method_14(string string_1)
	{
		if (!((Control)toolStripURL).get_InvokeRequired())
		{
			cmbReqType.set_SelectedIndex(cmbReqType.FindString(string_1));
			return;
		}
		Delegate0 @delegate = method_14;
		((Control)this).Invoke((Delegate)@delegate, new object[1] { string_1 });
	}

	private void method_15(bool bool_0)
	{
		if (!((Control)toolStripData).get_InvokeRequired())
		{
			((Control)toolStripData).set_Visible(bool_0);
			((ToolStripItem)txtSubmitData).set_Width(((Control)toolStripData).get_Width() - 85);
		}
		else
		{
			Delegate2 @delegate = method_15;
			((Control)this).Invoke((Delegate)@delegate, new object[1] { bool_0 });
		}
	}

	public void method_16(string string_1)
	{
		if (!((Control)toolStripURL).get_InvokeRequired())
		{
			((ToolStripItem)txtURL).set_Text(string_1);
			return;
		}
		Delegate0 @delegate = method_16;
		((Control)this).Invoke((Delegate)@delegate, new object[1] { string_1 });
	}

	public void method_17(string string_1)
	{
		if (!((Control)toolStripData).get_InvokeRequired())
		{
			((ToolStripItem)txtSubmitData).set_Text(string_1);
			return;
		}
		Delegate0 @delegate = method_17;
		((Control)this).Invoke((Delegate)@delegate, new object[1] { string_1 });
	}

	private string method_18()
	{
		if (!((Control)toolStripData).get_InvokeRequired())
		{
			return ((ToolStripItem)txtSubmitData).get_Text();
		}
		Delegate1 @delegate = method_18;
		return (string)((Control)this).Invoke((Delegate)@delegate, new object[0]);
	}

	public void method_19(GEnum0 genum0_1)
	{
		switch (genum0_1)
		{
		case GEnum0.GET:
			method_14("GET");
			method_15(bool_0: false);
			break;
		case GEnum0.POST:
			method_14("POST");
			method_15(bool_0: true);
			break;
		case GEnum0.COOKIE:
			method_14("COOKIE");
			method_15(bool_0: true);
			break;
		}
	}

	private void method_20(GStruct0 gstruct0_0)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (!((Control)gstruct0_0.textBox_0).get_InvokeRequired())
			{
				((Control)gstruct0_0.textBox_0).set_Text(gstruct0_0.string_0);
				return;
			}
			Delegate3 @delegate = method_20;
			((Control)this).Invoke((Delegate)@delegate, new object[1] { gstruct0_0 });
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void method_21(TextBox textBox_0, string string_1)
	{
		GStruct0 gstruct0_ = default(GStruct0);
		gstruct0_.textBox_0 = textBox_0;
		gstruct0_.string_0 = string_1;
		method_20(gstruct0_);
	}

	private void txtURL_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (e.get_KeyChar() == '\r')
		{
			method_22();
		}
	}

	private void method_22()
	{
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Invalid comparison between Unknown and I4
		method_24("WebBrowser");
		string text = ((ToolStripItem)txtURL).get_Text().Trim();
		gclass0_0.method_9(text);
		string text2 = "";
		string text3 = genum0_0.ToString() + "  " + text;
		if (genum0_0 != 0)
		{
			text2 = ((ToolStripItem)txtSubmitData).get_Text();
			text3 = text3 + "^" + text2;
			if (genum0_0 == GEnum0.POST)
			{
				text2 = gclass0_0.method_27(text2);
			}
		}
		else if (text.IndexOf('^') > 0)
		{
			if ((int)MessageBox.Show("* URL is not a valid for GET Request.\r\n* Do you want it switch to POST?\r\n", "Confirm", (MessageBoxButtons)1, (MessageBoxIcon)64) == 2)
			{
				return;
			}
			string[] array = text.Split(new char[1] { '^' });
			text = array[0];
			string text4 = "";
			for (int i = 1; i < array.Length; i++)
			{
				if (!string.IsNullOrEmpty(text4))
				{
					text4 += "^";
				}
				text4 += array[i];
			}
			genum0_0 = GEnum0.POST;
			method_19(genum0_0);
			method_16(text);
			method_17(text4);
			text2 = ((ToolStripItem)txtSubmitData).get_Text();
			text2 = gclass0_0.method_27(text2);
		}
		formBrowser_0.method_2(text, genum0_0, text2);
		if (GClass0.bool_2)
		{
			GClass0.smethod_0(text3);
		}
	}

	private void toolStripBtnGo_Click(object sender, EventArgs e)
	{
		method_22();
	}

	private void FormMain_Resize(object sender, EventArgs e)
	{
		((ToolStripItem)txtURL).set_Width(((Control)toolStripMain).get_Width() - 211);
		((ToolStripItem)txtSubmitData).set_Width(((Control)toolStripData).get_Width() - 85);
		((ToolStripItem)toolStripStatusProgress).set_Width(((Control)statusStripMain).get_Width() - 150);
	}

	private void cmbReqType_DropDownClosed(object sender, EventArgs e)
	{
		if (((ToolStripItem)cmbReqType).get_Text().Equals("GET"))
		{
			genum0_0 = GEnum0.GET;
		}
		else if (((ToolStripItem)cmbReqType).get_Text().Equals("POST"))
		{
			genum0_0 = GEnum0.POST;
		}
		else if (((ToolStripItem)cmbReqType).get_Text().Equals("COOKIE"))
		{
			genum0_0 = GEnum0.COOKIE;
		}
		method_19(genum0_0);
	}

	private void method_23()
	{
		((Control)formBrowser_0).Hide();
		((Control)formScanner_0).Hide();
		((Control)formSQL_0).Hide();
		((Control)formXSS_0).Hide();
		((Control)formCode_0).Hide();
		((Control)formCookie_0).Hide();
		((Control)formSetting_0).Hide();
		((Control)formAdmin_0).Hide();
		((Control)formReport_0).Hide();
		((Control)formAbout_0).Hide();
	}

	public void method_24(string string_1)
	{
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		switch (string_1)
		{
		case "WebBrowser":
			method_23();
			((Control)formBrowser_0).Show();
			formBrowser_0.method_12("tabBrowser");
			break;
		case "Scanner":
			method_23();
			((Control)formScanner_0).Show();
			break;
		case "SQL":
			method_23();
			((Control)formSQL_0).Show();
			formSQL_0.method_101("tabEnv");
			break;
		case "XSS":
			method_23();
			((Control)formXSS_0).Show();
			break;
		case "Code":
			method_23();
			((Control)formCode_0).Show();
			break;
		case "Cookie":
			method_23();
			((Control)formCookie_0).Show();
			break;
		case "Setting":
			method_23();
			((Control)formSetting_0).Show();
			break;
		case "Admin":
			method_23();
			((Control)formAdmin_0).Show();
			break;
		case "Report":
			method_23();
			((Control)formReport_0).Show();
			break;
		case "Resend":
			method_23();
			((Control)formBrowser_0).Show();
			formBrowser_0.method_12("tabResend");
			break;
		case "StringTool":
			method_23();
			((Control)formSQL_0).Show();
			formSQL_0.method_101("tabEscapeString");
			break;
		case "About":
			method_23();
			((Control)formAbout_0).Show();
			break;
		default:
			MessageBox.Show("Not Handled");
			break;
		case "POCTool":
		case "SystemTool":
			break;
		}
	}

	private void treeViewToolTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
	{
		Point point = new Point(((MouseEventArgs)e).get_X(), ((MouseEventArgs)e).get_Y());
		TreeNode nodeAt = treeViewToolTree.GetNodeAt(point);
		string name = nodeAt.get_Name();
		method_24(name);
	}

	private void MenuItemExit_Click(object sender, EventArgs e)
	{
		Application.Exit();
	}

	public string method_25()
	{
		return formBrowser_0.method_6();
	}

	public void method_26(string string_1)
	{
		formCode_0.method_0(string_1);
	}

	public void method_27(int int_0, int int_1)
	{
		formCode_0.method_1(int_0, int_1);
	}

	public void method_28(string string_1, GEnum0 genum0_1, string string_2)
	{
		method_24("WebBrowser");
		formBrowser_0.method_2(string_1, genum0_1, string_2);
	}

	public void method_29(bool bool_0, int int_0)
	{
		bool flag = false;
		flag = bool_0 || int_0 > 0;
		method_30(flag);
	}

	public void method_30(bool bool_0)
	{
		((ToolStripItem)toolStripBtnGo).set_Enabled(bool_0);
		formScanner_0.method_0(bool_0);
		formSQL_0.method_100(bool_0);
	}

	private void MenuItemWebBrowser_Click(object sender, EventArgs e)
	{
		method_24("WebBrowser");
	}

	private void MenuItemScanner_Click(object sender, EventArgs e)
	{
		method_24("Scanner");
	}

	private void MenuItemSQLInjection_Click(object sender, EventArgs e)
	{
		method_24("SQL");
	}

	private void MenuItemXSS_Click(object sender, EventArgs e)
	{
		method_24("XSS");
	}

	private void method_31(object sender, EventArgs e)
	{
		method_24("Setting");
	}

	private void toolStripButtonBrowser_Click(object sender, EventArgs e)
	{
		method_24("WebBrowser");
	}

	private void toolStripButtonScanner_Click(object sender, EventArgs e)
	{
		method_24("Scanner");
	}

	private void toolStripButtonSQL_Click(object sender, EventArgs e)
	{
		method_24("SQL");
	}

	private void toolStripButtonXSS_Click(object sender, EventArgs e)
	{
		method_24("XSS");
	}

	private void ButtonSetting_Click(object sender, EventArgs e)
	{
		method_24("Setting");
	}

	private void ButtonReport_Click(object sender, EventArgs e)
	{
		method_24("Report");
	}

	private void MenuItemReport_Click(object sender, EventArgs e)
	{
		method_24("Report");
	}

	private void MenuItemAbout_Click(object sender, EventArgs e)
	{
		method_24("About");
	}

	private void method_32(object object_0)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Invalid comparison between Unknown and I4
		string strA = Assembly.GetExecutingAssembly().GetName().Version!.ToString();
		string text = gclass0_0.method_30("http://sec4app.com/files/version.xml", GEnum0.GET);
		if (!string.IsNullOrEmpty(text))
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(text);
			string value = xmlDocument.SelectSingleNode("//ROOT/Version")!.Attributes!["Value"]!.Value;
			int num = string.Compare(strA, value);
			if (num >= 0)
			{
				MessageBox.Show("Current version is up-to-date!", "Information", (MessageBoxButtons)0, (MessageBoxIcon)64);
			}
			else if ((int)MessageBox.Show("Found New Version: " + value + " , Update Now?", "Information", (MessageBoxButtons)1, (MessageBoxIcon)64) == 1)
			{
				string text2 = "Ent";
				string value2 = xmlDocument.SelectSingleNode("//ROOT/Download/URL[@Edition=\"" + text2 + "\"]")!.Attributes!["Value"]!.Value;
				method_28(value2, GEnum0.GET, "");
			}
		}
		else
		{
			method_24("WebBrowser");
			method_28("http://sec4app.com/", GEnum0.GET, "");
		}
	}

	private void MenuItemCheckUpdate_Click(object sender, EventArgs e)
	{
		ThreadPool.QueueUserWorkItem(method_32);
	}

	public void method_33(GEnum2 genum2_0)
	{
		formSQL_0.method_4(genum2_0);
	}

	public void method_34(string string_1)
	{
		formSQL_0.method_5(string_1);
	}

	public void method_35(string string_1, string string_2, string string_3)
	{
		formBrowser_0.method_7(string_1, string_2, string_3);
	}

	public void method_36(string string_1, string string_2)
	{
		formXSS_0.method_3(string_1, string_2);
	}

	private void txtSubmitData_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (e.get_KeyChar() == '\r')
		{
			method_22();
		}
	}

	public void method_37(string string_1)
	{
		if (!((Control)statusStripMain).get_InvokeRequired())
		{
			((ToolStripItem)lblThreadNum).set_Text(string_1);
			((Control)statusStripMain).Refresh();
		}
		else
		{
			Delegate0 @delegate = method_37;
			((Control)this).Invoke((Delegate)@delegate, new object[1] { string_1 });
		}
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		method_37("HTTP Thread: " + gclass0_0.method_12());
		DateTime now = DateTime.Now;
		if (now.Subtract(GClass0.dateTime_3).Seconds > 8)
		{
			if (GClass0.genum4_0 == GEnum4.Stop)
			{
				GClass0.genum4_0 = GEnum4.Ready;
				gclass0_0.method_13(0);
			}
			((ToolStripItem)toolStripBtnStop).set_Enabled(true);
		}
		TimeSpan timeSpan = now.Subtract(gclass0_0.dateTime_2);
		if (timeSpan.Seconds > 30 && gclass0_0.method_12() == 0)
		{
			method_11("Done");
		}
		if (timeSpan.Seconds > 30 && gclass0_0.method_12() > 0)
		{
			gclass0_0.method_13(0);
		}
	}

	private void toolStripBtnPause_Click(object sender, EventArgs e)
	{
		if (GClass0.genum4_0 == GEnum4.Ready)
		{
			GClass0.genum4_0 = GEnum4.Pause;
			((ToolStripItem)toolStripBtnPause).set_ImageKey("start.png");
			method_11("PAUSE");
		}
		else if (GClass0.genum4_0 == GEnum4.Pause)
		{
			GClass0.genum4_0 = GEnum4.Ready;
			((ToolStripItem)toolStripBtnPause).set_ImageKey("pause.png");
		}
	}

	private void toolStripBtnStop_Click(object sender, EventArgs e)
	{
		GClass0.genum4_0 = GEnum4.Stop;
		((ToolStripItem)toolStripBtnStop).set_Enabled(false);
		method_11("Terminating Threads... ");
		GClass0.dateTime_3 = DateTime.Now;
	}

	private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Invalid comparison between Unknown and I4
		if (GClass0.int_2 > 0 && (int)MessageBox.Show("* Multi-Site Scanning Task Is Not Complete.\r\n* Site Number: " + GClass0.int_2 + "\r\n* Continue Exit?\r\n", "Confirm", (MessageBoxButtons)1, (MessageBoxIcon)64) == 2)
		{
			((CancelEventArgs)(object)e).Cancel = true;
		}
	}

	public void method_38(FormScanner formScanner_1)
	{
		if (!((Control)formScanner_1).get_InvokeRequired())
		{
			((Component)(object)formScanner_1).Dispose();
			return;
		}
		Delegate4 @delegate = method_38;
		((Control)this).Invoke((Delegate)@delegate, new object[1] { formScanner_1 });
	}

	private void toolStripButtonSave_Click(object sender, EventArgs e)
	{
		method_39(bool_0: false);
	}

	private void MenuItemSave_Click(object sender, EventArgs e)
	{
		method_39(bool_0: false);
	}

	private void method_39(bool bool_0)
	{
		method_41(gclass0_0.xmlDocument_0);
		string text = gclass0_0.method_6(bool_0);
		if (!string.IsNullOrEmpty(text))
		{
			method_11(text + " Saved!");
		}
	}

	private XmlDocument method_40()
	{
		XmlDocument xmlDocument = new XmlDocument();
		XmlNode newChild = xmlDocument.CreateXmlDeclaration("1.0", "utf-8", "");
		xmlDocument.AppendChild(newChild);
		XmlElement xmlElement = xmlDocument.CreateElement("ROOT");
		xmlDocument.AppendChild(xmlElement);
		XmlElement xmlElement2 = xmlDocument.CreateElement("CurrentSite");
		xmlElement.AppendChild(xmlElement2);
		XmlElement xmlElement3 = xmlDocument.CreateElement("URL");
		xmlElement3.SetAttribute("Value", gclass0_0.method_8());
		xmlElement2.AppendChild(xmlElement3);
		XmlElement xmlElement4 = xmlDocument.CreateElement("RequestType");
		xmlElement4.SetAttribute("Value", genum0_0.ToString());
		xmlElement2.AppendChild(xmlElement4);
		XmlElement xmlElement5 = xmlDocument.CreateElement("SubmitData");
		xmlElement5.SetAttribute("Value", ((ToolStripItem)txtSubmitData).get_Text());
		xmlElement2.AppendChild(xmlElement5);
		XmlElement xmlElement6 = xmlDocument.CreateElement("DatabaseType");
		xmlElement6.SetAttribute("Value", gclass0_0.method_16().ToString());
		xmlElement2.AppendChild(xmlElement6);
		XmlElement xmlElement7 = xmlDocument.CreateElement("CurrentKeyWord");
		xmlElement7.SetAttribute("Value", gclass0_0.method_3());
		xmlElement2.AppendChild(xmlElement7);
		XmlElement xmlElement8 = xmlDocument.CreateElement("CurrentInjType");
		xmlElement8.SetAttribute("Value", gclass0_0.method_18().ToString());
		xmlElement2.AppendChild(xmlElement8);
		XmlElement xmlElement9 = xmlDocument.CreateElement("CurrentBlindInjType");
		xmlElement9.SetAttribute("Value", gclass0_0.method_20().ToString());
		xmlElement9.SetAttribute("CurrentFieldEchoIndex", gclass0_0.int_3.ToString());
		xmlElement9.SetAttribute("CurrentFieldNum", gclass0_0.int_4.ToString());
		xmlElement2.AppendChild(xmlElement9);
		XmlElement xmlElement10 = xmlDocument.CreateElement("WebRoot");
		xmlElement10.SetAttribute("Value", gclass0_0.string_6);
		xmlElement2.AppendChild(xmlElement10);
		XmlElement xmlElement11 = xmlDocument.CreateElement("EscapeCookie");
		xmlElement11.SetAttribute("Value", GClass0.bool_0.ToString());
		xmlElement2.AppendChild(xmlElement11);
		return xmlDocument;
	}

	public void method_41(XmlDocument xmlDocument_0)
	{
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			XmlNode xmlNode = xmlDocument_0.SelectSingleNode("//ROOT");
			XmlDocument xmlDocument = method_40();
			XmlNode newChild = xmlDocument_0.ImportNode(xmlDocument.SelectSingleNode("//ROOT/CurrentSite"), deep: true);
			XmlNode xmlNode2 = xmlDocument_0.SelectSingleNode("//ROOT/CurrentSite");
			if (xmlNode2 == null)
			{
				xmlNode.AppendChild(newChild);
			}
			else
			{
				xmlNode.ReplaceChild(newChild, xmlNode2);
			}
			XmlDocument xmlDocument2 = formScanner_0.method_17();
			XmlNode newChild2 = xmlDocument_0.ImportNode(xmlDocument2.SelectSingleNode("//ROOT/SiteDirTree"), deep: true);
			XmlNode xmlNode3 = xmlDocument_0.SelectSingleNode("//ROOT/SiteDirTree");
			if (xmlNode3 == null)
			{
				xmlNode.AppendChild(newChild);
			}
			else
			{
				xmlNode.ReplaceChild(newChild2, xmlNode3);
			}
			XmlDocument xmlDocument3 = formScanner_0.method_18();
			XmlNode newChild3 = xmlDocument_0.ImportNode(xmlDocument3.SelectSingleNode("//ROOT/SiteVulList"), deep: true);
			XmlNode xmlNode4 = xmlDocument_0.SelectSingleNode("//ROOT/SiteVulList");
			if (xmlNode4 == null)
			{
				xmlNode.AppendChild(newChild3);
			}
			else
			{
				xmlNode.ReplaceChild(newChild3, xmlNode4);
			}
			XmlDocument xmlDocument4 = formSQL_0.method_93();
			XmlNode newChild4 = xmlDocument_0.ImportNode(xmlDocument4.SelectSingleNode("//ROOT/SiteDBStructure"), deep: true);
			XmlNode xmlNode5 = xmlDocument_0.SelectSingleNode("//ROOT/SiteDBStructure");
			if (xmlNode5 == null)
			{
				xmlNode.AppendChild(newChild4);
			}
			else
			{
				xmlNode.ReplaceChild(newChild4, xmlNode5);
			}
			XmlDocument xmlDocument5 = formSQL_0.method_92();
			XmlNode newChild5 = xmlDocument_0.ImportNode(xmlDocument5.SelectSingleNode("//ROOT/SiteSQLEnv"), deep: true);
			XmlNode xmlNode6 = xmlDocument_0.SelectSingleNode("//ROOT/SiteSQLEnv");
			if (xmlNode6 == null)
			{
				xmlNode.AppendChild(newChild5);
			}
			else
			{
				xmlNode.ReplaceChild(newChild5, xmlNode6);
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void MenuItemSaveAs_Click(object sender, EventArgs e)
	{
		method_39(bool_0: true);
	}

	private void toolStripButtonOpen_Click(object sender, EventArgs e)
	{
		method_42();
	}

	private void MenuItemOpen_Click(object sender, EventArgs e)
	{
		method_42();
	}

	private void method_42()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Invalid comparison between Unknown and I4
		OpenFileDialog val = new OpenFileDialog();
		((FileDialog)val).set_Filter("XML File(*.xml)|*.xml");
		((FileDialog)val).set_InitialDirectory(Application.get_StartupPath());
		DialogResult val2 = ((CommonDialog)val).ShowDialog();
		string fileName = ((FileDialog)val).get_FileName();
		((Component)(object)val).Dispose();
		if ((int)val2 == 1)
		{
			gclass0_0.xmlDocument_0.Load(fileName);
			gclass0_0.string_3 = fileName;
			method_43(gclass0_0.xmlDocument_0);
			method_22();
		}
	}

	private void method_43(XmlDocument xmlDocument_0)
	{
		try
		{
			formScanner_0.method_27(xmlDocument_0);
			formSQL_0.method_91(xmlDocument_0);
			method_3(xmlDocument_0.SelectSingleNode("//ROOT/CurrentSite/URL")!.Attributes!["Value"]!.Value);
			string value = xmlDocument_0.SelectSingleNode("//ROOT/CurrentSite/RequestType")!.Attributes!["Value"]!.Value;
			method_14(value);
			method_1((GEnum0)Enum.Parse(typeof(GEnum0), value));
			method_5(xmlDocument_0.SelectSingleNode("//ROOT/CurrentSite/SubmitData")!.Attributes!["Value"]!.Value);
			gclass0_0.string_6 = xmlDocument_0.SelectSingleNode("//ROOT/CurrentSite/WebRoot")!.Attributes!["Value"]!.Value;
			GClass0.bool_0 = bool.Parse(xmlDocument_0.SelectSingleNode("//ROOT/CurrentSite/EscapeCookie")!.Attributes!["Value"]!.Value);
			formCookie_0.method_0(GClass0.bool_0);
		}
		catch
		{
		}
	}

	private void MenuItemNew_Click(object sender, EventArgs e)
	{
		method_44();
	}

	private void method_44()
	{
		_ = Process.GetCurrentProcess().ProcessName;
		Process.Start(Application.get_ExecutablePath());
	}

	private void toolStripButtonNew_Click(object sender, EventArgs e)
	{
		method_44();
	}

	private void ButtonScanSite_Click(object sender, EventArgs e)
	{
		method_24("Scanner");
		formScanner_0.method_23();
	}

	private void ButtonScanURL_Click(object sender, EventArgs e)
	{
		method_24("Scanner");
		formScanner_0.method_24();
	}

	public void method_45()
	{
		((ToolStripControlHost)txtURL).Focus();
	}

	private void MenuItemOrder_Click(object sender, EventArgs e)
	{
		string text = "http://sec4app.com/order.htm";
		try
		{
			Process.Start(text);
		}
		catch
		{
			method_28(text, GEnum0.GET, "");
		}
	}

	private void ButtonAutoFill_Click(object sender, EventArgs e)
	{
		formBrowser_0.method_8(((ToolStripItem)txtSubmitData).get_Text());
	}

	public int method_46()
	{
		return formBrowser_0.method_9();
	}

	public string method_47(int int_0)
	{
		return formBrowser_0.method_10(int_0);
	}

	public string method_48(int int_0)
	{
		return formBrowser_0.method_11(int_0);
	}

	private void txtURL_DoubleClick(object sender, EventArgs e)
	{
		txtURL.SelectAll();
	}

	private void ButtonCookie_Click(object sender, EventArgs e)
	{
		method_24("Cookie");
	}

	private void ButtonTest_Click(object sender, EventArgs e)
	{
	}

	private void txtSubmitData_DoubleClick(object sender, EventArgs e)
	{
		txtSubmitData.SelectAll();
	}

	private void ButtonResend_Click(object sender, EventArgs e)
	{
		method_24("Resend");
	}

	private void MenuItemOnlineHelp_Click(object sender, EventArgs e)
	{
		string text = "http://sec4app.com/help.htm";
		try
		{
			Process.Start(text);
		}
		catch
		{
			method_28(text, GEnum0.GET, "");
		}
	}

	private void MenuItemFeedback_Click(object sender, EventArgs e)
	{
		try
		{
			Process.Start("mailto:zhyale@gmail.com");
		}
		catch
		{
		}
	}

	private void MenuItemSettings_Click(object sender, EventArgs e)
	{
		method_24("Setting");
	}

	private void MenuItemWebsite_Click(object sender, EventArgs e)
	{
		string text = "http://sec4app.com/";
		try
		{
			Process.Start(text);
		}
		catch
		{
			method_28(text, GEnum0.GET, "");
		}
	}

	private void MenuItemResend_Click(object sender, EventArgs e)
	{
		method_24("Resend");
	}

	private void MenuItemCookie_Click(object sender, EventArgs e)
	{
		method_24("Cookie");
	}

	private void MenuItemRefreshURL_Click(object sender, EventArgs e)
	{
		if (MenuItemRefreshURL.get_Checked())
		{
			MenuItemRefreshURL.set_Checked(false);
			WCRSetting.bool_6 = false;
		}
		else
		{
			MenuItemRefreshURL.set_Checked(true);
			WCRSetting.bool_6 = true;
		}
	}

	private void MenuItemEscapeCookie_Click(object sender, EventArgs e)
	{
		if (MenuItemEscapeCookie.get_Checked())
		{
			MenuItemEscapeCookie.set_Checked(false);
			GClass0.bool_0 = false;
			formCookie_0.method_0(bool_0: false);
		}
		else
		{
			MenuItemEscapeCookie.set_Checked(true);
			GClass0.bool_0 = true;
			formCookie_0.method_0(bool_0: true);
		}
	}

	public void method_49(bool bool_0)
	{
		if (bool_0)
		{
			MenuItemEscapeCookie.set_Checked(true);
		}
		else
		{
			MenuItemEscapeCookie.set_Checked(false);
		}
	}

	private void MenuItemTextAd_Click(object sender, EventArgs e)
	{
		try
		{
			Process.Start(string_0);
		}
		catch
		{
		}
		try
		{
			gclass0_0.method_30("http://sec4app.com/files/textadclick.php?id=" + ((ToolStripItem)MenuItemTextAd).get_Text(), GEnum0.GET);
		}
		catch
		{
		}
	}

	private void timer_1_Tick(object sender, EventArgs e)
	{
		try
		{
			string text = gclass0_0.method_31("http://sec4app.com/files/textad.php", GEnum0.GET, Encoding.UTF8);
			if (!string.IsNullOrEmpty(text))
			{
				string[] array = text.Split(new char[1] { '^' });
				((ToolStripItem)MenuItemTextAd).set_Text(array[0]);
				string_0 = array[1];
			}
		}
		catch
		{
		}
	}

	private void MenuItemTextAd_MouseMove(object sender, MouseEventArgs e)
	{
		((Control)this).set_Cursor(Cursors.get_Hand());
	}

	private void MenuItemTextAd_MouseLeave(object sender, EventArgs e)
	{
		((Control)this).set_Cursor(Cursors.get_Arrow());
	}

	private void MenuItemWebEncodingBIG5_Click(object sender, EventArgs e)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			MenuItemWebEncodingUTF8.set_Checked(false);
			MenuItemWebEncodingUTF16.set_Checked(false);
			MenuItemWebEncodingISO8859.set_Checked(false);
			MenuItemWebEncodingGB2312.set_Checked(false);
			MenuItemWebEncodingBIG5.set_Checked(false);
			((ToolStripMenuItem)sender).set_Checked(true);
			gclass0_0.encoding_0 = Encoding.GetEncoding(((ToolStripItem)(ToolStripMenuItem)sender).get_Text());
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void MenuItemDBEncodingBIG5_Click(object sender, EventArgs e)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			MenuItemDBEncodingUTF8.set_Checked(false);
			MenuItemDBEncodingUTF16.set_Checked(false);
			MenuItemDBEncodingISO8859.set_Checked(false);
			MenuItemDBEncodingGB2312.set_Checked(false);
			MenuItemDBEncodingBIG5.set_Checked(false);
			((ToolStripMenuItem)sender).set_Checked(true);
			gclass0_0.encoding_1 = Encoding.GetEncoding(((ToolStripItem)(ToolStripMenuItem)sender).get_Text());
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

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
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected O, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected O, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected O, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected O, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected O, but got Unknown
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected O, but got Unknown
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected O, but got Unknown
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected O, but got Unknown
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected O, but got Unknown
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected O, but got Unknown
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected O, but got Unknown
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected O, but got Unknown
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected O, but got Unknown
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected O, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected O, but got Unknown
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected O, but got Unknown
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected O, but got Unknown
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected O, but got Unknown
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected O, but got Unknown
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected O, but got Unknown
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected O, but got Unknown
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected O, but got Unknown
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected O, but got Unknown
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected O, but got Unknown
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected O, but got Unknown
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Expected O, but got Unknown
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected O, but got Unknown
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected O, but got Unknown
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected O, but got Unknown
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected O, but got Unknown
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected O, but got Unknown
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Expected O, but got Unknown
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected O, but got Unknown
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected O, but got Unknown
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Expected O, but got Unknown
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected O, but got Unknown
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected O, but got Unknown
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Expected O, but got Unknown
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Expected O, but got Unknown
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Expected O, but got Unknown
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Expected O, but got Unknown
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Expected O, but got Unknown
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Expected O, but got Unknown
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Expected O, but got Unknown
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Expected O, but got Unknown
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Expected O, but got Unknown
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Expected O, but got Unknown
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected O, but got Unknown
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Expected O, but got Unknown
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Expected O, but got Unknown
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Expected O, but got Unknown
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Expected O, but got Unknown
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Expected O, but got Unknown
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fa: Expected O, but got Unknown
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Expected O, but got Unknown
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Expected O, but got Unknown
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Expected O, but got Unknown
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Expected O, but got Unknown
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Expected O, but got Unknown
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		//IL_043c: Expected O, but got Unknown
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Expected O, but got Unknown
		//IL_0448: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Expected O, but got Unknown
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Expected O, but got Unknown
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0468: Expected O, but got Unknown
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Expected O, but got Unknown
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_047e: Expected O, but got Unknown
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Expected O, but got Unknown
		//IL_048a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Expected O, but got Unknown
		//IL_0495: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Expected O, but got Unknown
		//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Expected O, but got Unknown
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b5: Expected O, but got Unknown
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Expected O, but got Unknown
		//IL_04c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Expected O, but got Unknown
		//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d6: Expected O, but got Unknown
		//IL_04d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e1: Expected O, but got Unknown
		//IL_04e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ec: Expected O, but got Unknown
		//IL_04ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f7: Expected O, but got Unknown
		//IL_04f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0502: Expected O, but got Unknown
		//IL_0503: Unknown result type (might be due to invalid IL or missing references)
		//IL_050d: Expected O, but got Unknown
		//IL_0514: Unknown result type (might be due to invalid IL or missing references)
		//IL_051e: Expected O, but got Unknown
		//IL_0525: Unknown result type (might be due to invalid IL or missing references)
		//IL_052f: Expected O, but got Unknown
		//IL_08ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f7: Expected O, but got Unknown
		//IL_0909: Unknown result type (might be due to invalid IL or missing references)
		//IL_0913: Expected O, but got Unknown
		//IL_0c93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9d: Expected O, but got Unknown
		//IL_0cfd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d07: Expected O, but got Unknown
		//IL_0d8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d94: Expected O, but got Unknown
		//IL_1b58: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b62: Expected O, but got Unknown
		//IL_1bb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bc0: Expected O, but got Unknown
		//IL_1d71: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d7b: Expected O, but got Unknown
		//IL_1e04: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e0e: Expected O, but got Unknown
		//IL_1e97: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ea1: Expected O, but got Unknown
		//IL_2211: Unknown result type (might be due to invalid IL or missing references)
		//IL_221b: Expected O, but got Unknown
		//IL_2864: Unknown result type (might be due to invalid IL or missing references)
		//IL_286e: Expected O, but got Unknown
		//IL_293b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2945: Expected O, but got Unknown
		//IL_29ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_29d8: Expected O, but got Unknown
		//IL_2a61: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a6b: Expected O, but got Unknown
		//IL_2bee: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bf8: Expected O, but got Unknown
		//IL_2c66: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c70: Expected O, but got Unknown
		//IL_2e14: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e1e: Expected O, but got Unknown
		//IL_2e56: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e60: Expected O, but got Unknown
		icontainer_0 = new Container();
		TreeNode val = new TreeNode("WebBrowser");
		TreeNode val2 = new TreeNode("VulnerabilityScanner");
		TreeNode val3 = new TreeNode("SQL Injection");
		TreeNode val4 = new TreeNode("Cross Site Scripting");
		TreeNode val5 = new TreeNode("AdministrationEntrance");
		TreeNode val6 = new TreeNode("POC(Proof Of Concept)", (TreeNode[])(object)new TreeNode[3] { val3, val4, val5 });
		TreeNode val7 = new TreeNode("ResendTool");
		TreeNode val8 = new TreeNode("CookieTool");
		TreeNode val9 = new TreeNode("CodeTool");
		TreeNode val10 = new TreeNode("StringTool");
		TreeNode val11 = new TreeNode("Settings");
		TreeNode val12 = new TreeNode("Report");
		TreeNode val13 = new TreeNode("SystemTool", (TreeNode[])(object)new TreeNode[6] { val7, val8, val9, val10, val11, val12 });
		TreeNode val14 = new TreeNode("About");
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormMain));
		splitMain = new SplitContainer();
		treeViewToolTree = new TreeView();
		imageList_0 = new ImageList(icontainer_0);
		menuStripMain = new MenuStrip();
		MenuItemFile = new ToolStripMenuItem();
		MenuItemNew = new ToolStripMenuItem();
		MenuItemOpen = new ToolStripMenuItem();
		toolStripSeparator8 = new ToolStripSeparator();
		MenuItemSave = new ToolStripMenuItem();
		MenuItemSaveAs = new ToolStripMenuItem();
		toolStripSeparator6 = new ToolStripSeparator();
		MenuItemExit = new ToolStripMenuItem();
		MenuItemTool = new ToolStripMenuItem();
		MenuItemWebBrowser = new ToolStripMenuItem();
		MenuItemScanner = new ToolStripMenuItem();
		toolStripSeparator9 = new ToolStripSeparator();
		MenuItemSQLInjection = new ToolStripMenuItem();
		MenuItemXSS = new ToolStripMenuItem();
		toolStripSeparator5 = new ToolStripSeparator();
		MenuItemResend = new ToolStripMenuItem();
		MenuItemCookie = new ToolStripMenuItem();
		toolStripSeparator12 = new ToolStripSeparator();
		MenuItemReport = new ToolStripMenuItem();
		MenuItemView = new ToolStripMenuItem();
		MenuItemWebEncoding = new ToolStripMenuItem();
		MenuItemWebEncodingUTF8 = new ToolStripMenuItem();
		MenuItemWebEncodingUTF16 = new ToolStripMenuItem();
		MenuItemWebEncodingISO8859 = new ToolStripMenuItem();
		MenuItemWebEncodingGB2312 = new ToolStripMenuItem();
		MenuItemWebEncodingBIG5 = new ToolStripMenuItem();
		MenuItemDBEncoding = new ToolStripMenuItem();
		MenuItemDBEncodingUTF8 = new ToolStripMenuItem();
		MenuItemDBEncodingUTF16 = new ToolStripMenuItem();
		MenuItemDBEncodingISO8859 = new ToolStripMenuItem();
		MenuItemDBEncodingGB2312 = new ToolStripMenuItem();
		MenuItemDBEncodingBIG5 = new ToolStripMenuItem();
		MenuItemConfig = new ToolStripMenuItem();
		MenuItemSettings = new ToolStripMenuItem();
		toolStripSeparator19 = new ToolStripSeparator();
		MenuItemRefreshURL = new ToolStripMenuItem();
		MenuItemEscapeCookie = new ToolStripMenuItem();
		MenuItemHelp = new ToolStripMenuItem();
		MenuItemOnlineHelp = new ToolStripMenuItem();
		MenuItemOrder = new ToolStripMenuItem();
		MenuItemCheckUpdate = new ToolStripMenuItem();
		MenuItemFeedback = new ToolStripMenuItem();
		MenuItemWebsite = new ToolStripMenuItem();
		toolStripSeparator7 = new ToolStripSeparator();
		MenuItemAbout = new ToolStripMenuItem();
		MenuItemTextAd = new ToolStripMenuItem();
		toolStripMain = new ToolStrip();
		toolStripButtonNew = new ToolStripButton();
		toolStripButtonOpen = new ToolStripButton();
		toolStripButtonSave = new ToolStripButton();
		toolStripSeparator4 = new ToolStripSeparator();
		toolStripButtonBrowser = new ToolStripButton();
		toolStripButtonScanner = new ToolStripButton();
		toolStripSeparator10 = new ToolStripSeparator();
		toolStripButtonSQL = new ToolStripButton();
		toolStripSeparator20 = new ToolStripSeparator();
		toolStripButtonXSS = new ToolStripButton();
		toolStripSeparator11 = new ToolStripSeparator();
		ButtonResend = new ToolStripButton();
		ButtonCookie = new ToolStripButton();
		toolStripSeparator17 = new ToolStripSeparator();
		ButtonReport = new ToolStripButton();
		toolStripSeparator18 = new ToolStripSeparator();
		ButtonSetting = new ToolStripButton();
		toolStripSeparator13 = new ToolStripSeparator();
		ButtonTest = new ToolStripButton();
		toolStripSeparator15 = new ToolStripSeparator();
		ButtonScanURL = new ToolStripButton();
		toolStripSeparator14 = new ToolStripSeparator();
		ButtonScanSite = new ToolStripButton();
		statusStripMain = new StatusStrip();
		toolStripStatusProgress = new ToolStripStatusLabel();
		toolStripStatusSep1 = new ToolStripStatusLabel();
		lblThreadNum = new ToolStripStatusLabel();
		toolStripURL = new ToolStrip();
		toolStripLabel1 = new ToolStripLabel();
		toolStripSeparator1 = new ToolStripSeparator();
		txtURL = new ToolStripTextBox();
		toolStripSeparator3 = new ToolStripSeparator();
		cmbReqType = new ToolStripComboBox();
		toolStripBtnGo = new ToolStripButton();
		toolStripBtnPause = new ToolStripButton();
		toolStripBtnStop = new ToolStripButton();
		toolStripData = new ToolStrip();
		lblSubmitData = new ToolStripLabel();
		toolStripSeparator2 = new ToolStripSeparator();
		txtSubmitData = new ToolStripTextBox();
		toolStripSeparator16 = new ToolStripSeparator();
		ButtonAutoFill = new ToolStripButton();
		timer_0 = new Timer(icontainer_0);
		timer_1 = new Timer(icontainer_0);
		((Control)splitMain.get_Panel1()).SuspendLayout();
		((Control)splitMain).SuspendLayout();
		((Control)menuStripMain).SuspendLayout();
		((Control)toolStripMain).SuspendLayout();
		((Control)statusStripMain).SuspendLayout();
		((Control)toolStripURL).SuspendLayout();
		((Control)toolStripData).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)splitMain).set_BackColor(SystemColors.ButtonFace);
		splitMain.set_Dock((DockStyle)5);
		((Control)splitMain).set_Location(new Point(0, 74));
		((Control)splitMain).set_Name("splitMain");
		((Control)splitMain.get_Panel1()).set_BackColor(Color.WhiteSmoke);
		((Control)splitMain.get_Panel1()).get_Controls().Add((Control)(object)treeViewToolTree);
		((Control)splitMain.get_Panel2()).set_BackColor(Color.WhiteSmoke);
		((Control)splitMain).set_Size(new Size(792, 420));
		splitMain.set_SplitterDistance(151);
		((Control)splitMain).set_TabIndex(4);
		((Control)treeViewToolTree).set_Dock((DockStyle)5);
		treeViewToolTree.set_ImageIndex(0);
		treeViewToolTree.set_ImageList(imageList_0);
		((Control)treeViewToolTree).set_Location(new Point(0, 0));
		((Control)treeViewToolTree).set_Name("treeViewToolTree");
		val.set_ImageKey("ie.png");
		val.set_Name("WebBrowser");
		val.set_Text("WebBrowser");
		val2.set_ImageKey("scan.png");
		val2.set_Name("Scanner");
		val2.set_Text("VulnerabilityScanner");
		val3.set_ImageKey("db.png");
		val3.set_Name("SQL");
		val3.set_Text("SQL Injection");
		val4.set_ImageKey("xss.png");
		val4.set_Name("XSS");
		val4.set_Text("Cross Site Scripting");
		val5.set_ImageKey("admin.png");
		val5.set_Name("Admin");
		val5.set_Text("AdministrationEntrance");
		val6.set_ImageKey("tool.png");
		val6.set_Name("POCTool");
		val6.set_Text("POC(Proof Of Concept)");
		val7.set_ImageKey("resend.png");
		val7.set_Name("Resend");
		val7.set_Text("ResendTool");
		val8.set_ImageKey("cookie.png");
		val8.set_Name("Cookie");
		val8.set_Text("CookieTool");
		val9.set_ImageKey("code.png");
		val9.set_Name("Code");
		val9.set_Text("CodeTool");
		val10.set_ImageKey("encode.png");
		val10.set_Name("StringTool");
		val10.set_Text("StringTool");
		val11.set_ImageKey("tool.png");
		val11.set_Name("Setting");
		val11.set_Text("Settings");
		val12.set_ImageKey("report.png");
		val12.set_Name("Report");
		val12.set_Text("Report");
		val13.set_ImageKey("tool.png");
		val13.set_Name("SystemTool");
		val13.set_Text("SystemTool");
		val14.set_ImageKey("about.png");
		val14.set_Name("About");
		val14.set_Text("About");
		treeViewToolTree.get_Nodes().AddRange((TreeNode[])(object)new TreeNode[5] { val, val2, val6, val13, val14 });
		treeViewToolTree.set_SelectedImageIndex(0);
		((Control)treeViewToolTree).set_Size(new Size(151, 420));
		((Control)treeViewToolTree).set_TabIndex(0);
		treeViewToolTree.add_NodeMouseClick(new TreeNodeMouseClickEventHandler(treeViewToolTree_NodeMouseClick));
		imageList_0.set_ImageStream((ImageListStreamer)componentResourceManager.GetObject("WCRImageList.ImageStream"));
		imageList_0.set_TransparentColor(Color.Transparent);
		imageList_0.get_Images().SetKeyName(0, "select.png");
		imageList_0.get_Images().SetKeyName(1, "ie.png");
		imageList_0.get_Images().SetKeyName(2, "scan.png");
		imageList_0.get_Images().SetKeyName(3, "env.png");
		imageList_0.get_Images().SetKeyName(4, "db.png");
		imageList_0.get_Images().SetKeyName(5, "xss.png");
		imageList_0.get_Images().SetKeyName(6, "cmd.png");
		imageList_0.get_Images().SetKeyName(7, "admin.png");
		imageList_0.get_Images().SetKeyName(8, "file.png");
		imageList_0.get_Images().SetKeyName(9, "tool.png");
		imageList_0.get_Images().SetKeyName(10, "code.png");
		imageList_0.get_Images().SetKeyName(11, "about.png");
		imageList_0.get_Images().SetKeyName(12, "go.png");
		imageList_0.get_Images().SetKeyName(13, "start.png");
		imageList_0.get_Images().SetKeyName(14, "pause.png");
		imageList_0.get_Images().SetKeyName(15, "stop.png");
		imageList_0.get_Images().SetKeyName(16, "table.png");
		imageList_0.get_Images().SetKeyName(17, "column.png");
		imageList_0.get_Images().SetKeyName(18, "vul.png");
		imageList_0.get_Images().SetKeyName(19, "xml.png");
		imageList_0.get_Images().SetKeyName(20, "report.png");
		imageList_0.get_Images().SetKeyName(21, "cookie.png");
		imageList_0.get_Images().SetKeyName(22, "resend.png");
		imageList_0.get_Images().SetKeyName(23, "encode.png");
		((ToolStrip)menuStripMain).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)MenuItemFile,
			(ToolStripItem)MenuItemTool,
			(ToolStripItem)MenuItemView,
			(ToolStripItem)MenuItemConfig,
			(ToolStripItem)MenuItemHelp,
			(ToolStripItem)MenuItemTextAd
		});
		((Control)menuStripMain).set_Location(new Point(0, 0));
		((Control)menuStripMain).set_Name("menuStripMain");
		((Control)menuStripMain).set_Size(new Size(792, 24));
		((Control)menuStripMain).set_TabIndex(0);
		((Control)menuStripMain).set_Text("menuStrip1");
		((ToolStripDropDownItem)MenuItemFile).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[7]
		{
			(ToolStripItem)MenuItemNew,
			(ToolStripItem)MenuItemOpen,
			(ToolStripItem)toolStripSeparator8,
			(ToolStripItem)MenuItemSave,
			(ToolStripItem)MenuItemSaveAs,
			(ToolStripItem)toolStripSeparator6,
			(ToolStripItem)MenuItemExit
		});
		((ToolStripItem)MenuItemFile).set_Name("MenuItemFile");
		((ToolStripItem)MenuItemFile).set_Size(new Size(41, 20));
		((ToolStripItem)MenuItemFile).set_Text("&File");
		((ToolStripItem)MenuItemNew).set_Image((Image)componentResourceManager.GetObject("MenuItemNew.Image"));
		((ToolStripItem)MenuItemNew).set_Name("MenuItemNew");
		((ToolStripItem)MenuItemNew).set_Size(new Size(130, 22));
		((ToolStripItem)MenuItemNew).set_Text("New");
		((ToolStripItem)MenuItemNew).add_Click((EventHandler)MenuItemNew_Click);
		((ToolStripItem)MenuItemOpen).set_Image((Image)componentResourceManager.GetObject("MenuItemOpen.Image"));
		((ToolStripItem)MenuItemOpen).set_Name("MenuItemOpen");
		((ToolStripItem)MenuItemOpen).set_Size(new Size(130, 22));
		((ToolStripItem)MenuItemOpen).set_Text("Open");
		((ToolStripItem)MenuItemOpen).add_Click((EventHandler)MenuItemOpen_Click);
		((ToolStripItem)toolStripSeparator8).set_Name("toolStripSeparator8");
		((ToolStripItem)toolStripSeparator8).set_Size(new Size(127, 6));
		((ToolStripItem)MenuItemSave).set_Image((Image)componentResourceManager.GetObject("MenuItemSave.Image"));
		((ToolStripItem)MenuItemSave).set_Name("MenuItemSave");
		((ToolStripItem)MenuItemSave).set_Size(new Size(130, 22));
		((ToolStripItem)MenuItemSave).set_Text("Save");
		((ToolStripItem)MenuItemSave).add_Click((EventHandler)MenuItemSave_Click);
		((ToolStripItem)MenuItemSaveAs).set_Name("MenuItemSaveAs");
		((ToolStripItem)MenuItemSaveAs).set_Size(new Size(130, 22));
		((ToolStripItem)MenuItemSaveAs).set_Text("Save As...");
		((ToolStripItem)MenuItemSaveAs).add_Click((EventHandler)MenuItemSaveAs_Click);
		((ToolStripItem)toolStripSeparator6).set_Name("toolStripSeparator6");
		((ToolStripItem)toolStripSeparator6).set_Size(new Size(127, 6));
		((ToolStripItem)MenuItemExit).set_Name("MenuItemExit");
		((ToolStripItem)MenuItemExit).set_Size(new Size(130, 22));
		((ToolStripItem)MenuItemExit).set_Text("E&xit");
		((ToolStripItem)MenuItemExit).add_Click((EventHandler)MenuItemExit_Click);
		((ToolStripDropDownItem)MenuItemTool).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[10]
		{
			(ToolStripItem)MenuItemWebBrowser,
			(ToolStripItem)MenuItemScanner,
			(ToolStripItem)toolStripSeparator9,
			(ToolStripItem)MenuItemSQLInjection,
			(ToolStripItem)MenuItemXSS,
			(ToolStripItem)toolStripSeparator5,
			(ToolStripItem)MenuItemResend,
			(ToolStripItem)MenuItemCookie,
			(ToolStripItem)toolStripSeparator12,
			(ToolStripItem)MenuItemReport
		});
		((ToolStripItem)MenuItemTool).set_Name("MenuItemTool");
		((ToolStripItem)MenuItemTool).set_Size(new Size(47, 20));
		((ToolStripItem)MenuItemTool).set_Text("&Tools");
		((ToolStripItem)MenuItemWebBrowser).set_Image((Image)(object)Resources.Bitmap_1);
		((ToolStripItem)MenuItemWebBrowser).set_Name("MenuItemWebBrowser");
		((ToolStripItem)MenuItemWebBrowser).set_Size(new Size(196, 22));
		((ToolStripItem)MenuItemWebBrowser).set_Text("WebBrowser");
		((ToolStripItem)MenuItemWebBrowser).add_Click((EventHandler)MenuItemWebBrowser_Click);
		((ToolStripItem)MenuItemScanner).set_Image((Image)(object)Resources.scan);
		((ToolStripItem)MenuItemScanner).set_Name("MenuItemScanner");
		((ToolStripItem)MenuItemScanner).set_Size(new Size(196, 22));
		((ToolStripItem)MenuItemScanner).set_Text("Vulnerability Scanner");
		((ToolStripItem)MenuItemScanner).add_Click((EventHandler)MenuItemScanner_Click);
		((ToolStripItem)toolStripSeparator9).set_Name("toolStripSeparator9");
		((ToolStripItem)toolStripSeparator9).set_Size(new Size(193, 6));
		((ToolStripItem)MenuItemSQLInjection).set_Image((Image)(object)Resources.Bitmap_0);
		((ToolStripItem)MenuItemSQLInjection).set_Name("MenuItemSQLInjection");
		((ToolStripItem)MenuItemSQLInjection).set_Size(new Size(196, 22));
		((ToolStripItem)MenuItemSQLInjection).set_Text("SQL Injection");
		((ToolStripItem)MenuItemSQLInjection).add_Click((EventHandler)MenuItemSQLInjection_Click);
		((ToolStripItem)MenuItemXSS).set_Image((Image)(object)Resources.Bitmap_2);
		((ToolStripItem)MenuItemXSS).set_Name("MenuItemXSS");
		((ToolStripItem)MenuItemXSS).set_Size(new Size(196, 22));
		((ToolStripItem)MenuItemXSS).set_Text("Cross Site Scripting");
		((ToolStripItem)MenuItemXSS).add_Click((EventHandler)MenuItemXSS_Click);
		((ToolStripItem)toolStripSeparator5).set_Name("toolStripSeparator5");
		((ToolStripItem)toolStripSeparator5).set_Size(new Size(193, 6));
		((ToolStripItem)MenuItemResend).set_Image((Image)(object)Resources.resend);
		((ToolStripItem)MenuItemResend).set_Name("MenuItemResend");
		((ToolStripItem)MenuItemResend).set_Size(new Size(196, 22));
		((ToolStripItem)MenuItemResend).set_Text("POST Resend");
		((ToolStripItem)MenuItemResend).add_Click((EventHandler)MenuItemResend_Click);
		((ToolStripItem)MenuItemCookie).set_Image((Image)(object)Resources.cookie);
		((ToolStripItem)MenuItemCookie).set_Name("MenuItemCookie");
		((ToolStripItem)MenuItemCookie).set_Size(new Size(196, 22));
		((ToolStripItem)MenuItemCookie).set_Text("Cookie");
		((ToolStripItem)MenuItemCookie).add_Click((EventHandler)MenuItemCookie_Click);
		((ToolStripItem)toolStripSeparator12).set_Name("toolStripSeparator12");
		((ToolStripItem)toolStripSeparator12).set_Size(new Size(193, 6));
		((ToolStripItem)MenuItemReport).set_Image((Image)(object)Resources.report);
		((ToolStripItem)MenuItemReport).set_Name("MenuItemReport");
		((ToolStripItem)MenuItemReport).set_Size(new Size(196, 22));
		((ToolStripItem)MenuItemReport).set_Text("Report");
		((ToolStripItem)MenuItemReport).add_Click((EventHandler)MenuItemReport_Click);
		((ToolStripDropDownItem)MenuItemView).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)MenuItemWebEncoding,
			(ToolStripItem)MenuItemDBEncoding
		});
		((ToolStripItem)MenuItemView).set_Name("MenuItemView");
		((ToolStripItem)MenuItemView).set_Size(new Size(41, 20));
		((ToolStripItem)MenuItemView).set_Text("&View");
		((ToolStripDropDownItem)MenuItemWebEncoding).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)MenuItemWebEncodingUTF8,
			(ToolStripItem)MenuItemWebEncodingUTF16,
			(ToolStripItem)MenuItemWebEncodingISO8859,
			(ToolStripItem)MenuItemWebEncodingGB2312,
			(ToolStripItem)MenuItemWebEncodingBIG5
		});
		((ToolStripItem)MenuItemWebEncoding).set_Name("MenuItemWebEncoding");
		((ToolStripItem)MenuItemWebEncoding).set_Size(new Size(172, 22));
		((ToolStripItem)MenuItemWebEncoding).set_Text("Web Encoding");
		((ToolStripItem)MenuItemWebEncodingUTF8).set_Name("MenuItemWebEncodingUTF8");
		((ToolStripItem)MenuItemWebEncodingUTF8).set_Size(new Size(130, 22));
		((ToolStripItem)MenuItemWebEncodingUTF8).set_Text("UTF-8");
		((ToolStripItem)MenuItemWebEncodingUTF8).add_Click((EventHandler)MenuItemWebEncodingBIG5_Click);
		((ToolStripItem)MenuItemWebEncodingUTF16).set_Name("MenuItemWebEncodingUTF16");
		((ToolStripItem)MenuItemWebEncodingUTF16).set_Size(new Size(130, 22));
		((ToolStripItem)MenuItemWebEncodingUTF16).set_Text("UTF-16");
		((ToolStripItem)MenuItemWebEncodingUTF16).add_Click((EventHandler)MenuItemWebEncodingBIG5_Click);
		((ToolStripItem)MenuItemWebEncodingISO8859).set_Name("MenuItemWebEncodingISO8859");
		((ToolStripItem)MenuItemWebEncodingISO8859).set_Size(new Size(130, 22));
		((ToolStripItem)MenuItemWebEncodingISO8859).set_Text("ISO-8859-1");
		((ToolStripItem)MenuItemWebEncodingISO8859).add_Click((EventHandler)MenuItemWebEncodingBIG5_Click);
		((ToolStripItem)MenuItemWebEncodingGB2312).set_Name("MenuItemWebEncodingGB2312");
		((ToolStripItem)MenuItemWebEncodingGB2312).set_Size(new Size(130, 22));
		((ToolStripItem)MenuItemWebEncodingGB2312).set_Text("GB2312");
		((ToolStripItem)MenuItemWebEncodingGB2312).add_Click((EventHandler)MenuItemWebEncodingBIG5_Click);
		((ToolStripItem)MenuItemWebEncodingBIG5).set_Name("MenuItemWebEncodingBIG5");
		((ToolStripItem)MenuItemWebEncodingBIG5).set_Size(new Size(130, 22));
		((ToolStripItem)MenuItemWebEncodingBIG5).set_Text("BIG5");
		((ToolStripItem)MenuItemWebEncodingBIG5).add_Click((EventHandler)MenuItemWebEncodingBIG5_Click);
		((ToolStripDropDownItem)MenuItemDBEncoding).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)MenuItemDBEncodingUTF8,
			(ToolStripItem)MenuItemDBEncodingUTF16,
			(ToolStripItem)MenuItemDBEncodingISO8859,
			(ToolStripItem)MenuItemDBEncodingGB2312,
			(ToolStripItem)MenuItemDBEncodingBIG5
		});
		((ToolStripItem)MenuItemDBEncoding).set_Name("MenuItemDBEncoding");
		((ToolStripItem)MenuItemDBEncoding).set_Size(new Size(172, 22));
		((ToolStripItem)MenuItemDBEncoding).set_Text("Database Encoding");
		((ToolStripItem)MenuItemDBEncodingUTF8).set_Name("MenuItemDBEncodingUTF8");
		((ToolStripItem)MenuItemDBEncodingUTF8).set_Size(new Size(130, 22));
		((ToolStripItem)MenuItemDBEncodingUTF8).set_Text("UTF-8");
		((ToolStripItem)MenuItemDBEncodingUTF8).add_Click((EventHandler)MenuItemDBEncodingBIG5_Click);
		((ToolStripItem)MenuItemDBEncodingUTF16).set_Name("MenuItemDBEncodingUTF16");
		((ToolStripItem)MenuItemDBEncodingUTF16).set_Size(new Size(130, 22));
		((ToolStripItem)MenuItemDBEncodingUTF16).set_Text("UTF-16");
		((ToolStripItem)MenuItemDBEncodingUTF16).add_Click((EventHandler)MenuItemDBEncodingBIG5_Click);
		((ToolStripItem)MenuItemDBEncodingISO8859).set_Name("MenuItemDBEncodingISO8859");
		((ToolStripItem)MenuItemDBEncodingISO8859).set_Size(new Size(130, 22));
		((ToolStripItem)MenuItemDBEncodingISO8859).set_Text("ISO-8859-1");
		((ToolStripItem)MenuItemDBEncodingISO8859).add_Click((EventHandler)MenuItemDBEncodingBIG5_Click);
		((ToolStripItem)MenuItemDBEncodingGB2312).set_Name("MenuItemDBEncodingGB2312");
		((ToolStripItem)MenuItemDBEncodingGB2312).set_Size(new Size(130, 22));
		((ToolStripItem)MenuItemDBEncodingGB2312).set_Text("GB2312");
		((ToolStripItem)MenuItemDBEncodingGB2312).add_Click((EventHandler)MenuItemDBEncodingBIG5_Click);
		((ToolStripItem)MenuItemDBEncodingBIG5).set_Name("MenuItemDBEncodingBIG5");
		((ToolStripItem)MenuItemDBEncodingBIG5).set_Size(new Size(130, 22));
		((ToolStripItem)MenuItemDBEncodingBIG5).set_Text("BIG5");
		((ToolStripItem)MenuItemDBEncodingBIG5).add_Click((EventHandler)MenuItemDBEncodingBIG5_Click);
		((ToolStripDropDownItem)MenuItemConfig).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[4]
		{
			(ToolStripItem)MenuItemSettings,
			(ToolStripItem)toolStripSeparator19,
			(ToolStripItem)MenuItemRefreshURL,
			(ToolStripItem)MenuItemEscapeCookie
		});
		((ToolStripItem)MenuItemConfig).set_Name("MenuItemConfig");
		((ToolStripItem)MenuItemConfig).set_Size(new Size(95, 20));
		((ToolStripItem)MenuItemConfig).set_Text("&Configuration");
		((ToolStripItem)MenuItemSettings).set_Image((Image)(object)Resources.tool);
		((ToolStripItem)MenuItemSettings).set_Name("MenuItemSettings");
		((ToolStripItem)MenuItemSettings).set_Size(new Size(280, 22));
		((ToolStripItem)MenuItemSettings).set_Text("Settings");
		((ToolStripItem)MenuItemSettings).add_Click((EventHandler)MenuItemSettings_Click);
		((ToolStripItem)toolStripSeparator19).set_Name("toolStripSeparator19");
		((ToolStripItem)toolStripSeparator19).set_Size(new Size(277, 6));
		MenuItemRefreshURL.set_Checked(true);
		MenuItemRefreshURL.set_CheckState((CheckState)1);
		((ToolStripItem)MenuItemRefreshURL).set_DisplayStyle((ToolStripItemDisplayStyle)1);
		((ToolStripItem)MenuItemRefreshURL).set_Name("MenuItemRefreshURL");
		((ToolStripItem)MenuItemRefreshURL).set_Size(new Size(280, 22));
		((ToolStripItem)MenuItemRefreshURL).set_Text("Refresh URL when Navigating");
		((ToolStripItem)MenuItemRefreshURL).add_Click((EventHandler)MenuItemRefreshURL_Click);
		MenuItemEscapeCookie.set_Checked(true);
		MenuItemEscapeCookie.set_CheckState((CheckState)1);
		((ToolStripItem)MenuItemEscapeCookie).set_DisplayStyle((ToolStripItemDisplayStyle)1);
		((ToolStripItem)MenuItemEscapeCookie).set_Name("MenuItemEscapeCookie");
		((ToolStripItem)MenuItemEscapeCookie).set_Size(new Size(280, 22));
		((ToolStripItem)MenuItemEscapeCookie).set_Text("Escape Special Characters in Cookie");
		((ToolStripItem)MenuItemEscapeCookie).add_Click((EventHandler)MenuItemEscapeCookie_Click);
		((ToolStripDropDownItem)MenuItemHelp).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[7]
		{
			(ToolStripItem)MenuItemOnlineHelp,
			(ToolStripItem)MenuItemOrder,
			(ToolStripItem)MenuItemCheckUpdate,
			(ToolStripItem)MenuItemFeedback,
			(ToolStripItem)MenuItemWebsite,
			(ToolStripItem)toolStripSeparator7,
			(ToolStripItem)MenuItemAbout
		});
		((ToolStripItem)MenuItemHelp).set_Name("MenuItemHelp");
		((ToolStripItem)MenuItemHelp).set_Size(new Size(41, 20));
		((ToolStripItem)MenuItemHelp).set_Text("&Help");
		((ToolStripItem)MenuItemOnlineHelp).set_Name("MenuItemOnlineHelp");
		((ToolStripItem)MenuItemOnlineHelp).set_Size(new Size(178, 22));
		((ToolStripItem)MenuItemOnlineHelp).set_Text("Online Help");
		((ToolStripItem)MenuItemOnlineHelp).add_Click((EventHandler)MenuItemOnlineHelp_Click);
		((ToolStripItem)MenuItemOrder).set_Name("MenuItemOrder");
		((ToolStripItem)MenuItemOrder).set_Size(new Size(178, 22));
		((ToolStripItem)MenuItemOrder).set_Text("Order WebCruiser");
		((ToolStripItem)MenuItemOrder).add_Click((EventHandler)MenuItemOrder_Click);
		((ToolStripItem)MenuItemCheckUpdate).set_Name("MenuItemCheckUpdate");
		((ToolStripItem)MenuItemCheckUpdate).set_Size(new Size(178, 22));
		((ToolStripItem)MenuItemCheckUpdate).set_Text("Check Updates");
		((ToolStripItem)MenuItemCheckUpdate).add_Click((EventHandler)MenuItemCheckUpdate_Click);
		((ToolStripItem)MenuItemFeedback).set_Name("MenuItemFeedback");
		((ToolStripItem)MenuItemFeedback).set_Size(new Size(178, 22));
		((ToolStripItem)MenuItemFeedback).set_Text("Feedback to Author");
		((ToolStripItem)MenuItemFeedback).add_Click((EventHandler)MenuItemFeedback_Click);
		((ToolStripItem)MenuItemWebsite).set_Name("MenuItemWebsite");
		((ToolStripItem)MenuItemWebsite).set_Size(new Size(178, 22));
		((ToolStripItem)MenuItemWebsite).set_Text("WebCruiser Website");
		((ToolStripItem)MenuItemWebsite).add_Click((EventHandler)MenuItemWebsite_Click);
		((ToolStripItem)toolStripSeparator7).set_Name("toolStripSeparator7");
		((ToolStripItem)toolStripSeparator7).set_Size(new Size(175, 6));
		((ToolStripItem)MenuItemAbout).set_Name("MenuItemAbout");
		((ToolStripItem)MenuItemAbout).set_Size(new Size(178, 22));
		((ToolStripItem)MenuItemAbout).set_Text("About WebCruiser");
		((ToolStripItem)MenuItemAbout).add_Click((EventHandler)MenuItemAbout_Click);
		((ToolStripItem)MenuItemTextAd).set_Alignment((ToolStripItemAlignment)1);
		((ToolStripItem)MenuItemTextAd).set_Font(new Font("Arial", 9f, (FontStyle)4, (GraphicsUnit)3, (byte)0));
		((ToolStripItem)MenuItemTextAd).set_ForeColor(Color.Blue);
		((ToolStripItem)MenuItemTextAd).set_Name("MenuItemTextAd");
		((ToolStripItem)MenuItemTextAd).set_Size(new Size(150, 20));
		((ToolStripItem)MenuItemTextAd).set_Text("Janus Security Software");
		((ToolStripItem)MenuItemTextAd).add_MouseMove(new MouseEventHandler(MenuItemTextAd_MouseMove));
		((ToolStripItem)MenuItemTextAd).add_MouseLeave((EventHandler)MenuItemTextAd_MouseLeave);
		((ToolStripItem)MenuItemTextAd).add_Click((EventHandler)MenuItemTextAd_Click);
		toolStripMain.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[23]
		{
			(ToolStripItem)toolStripButtonNew,
			(ToolStripItem)toolStripButtonOpen,
			(ToolStripItem)toolStripButtonSave,
			(ToolStripItem)toolStripSeparator4,
			(ToolStripItem)toolStripButtonBrowser,
			(ToolStripItem)toolStripButtonScanner,
			(ToolStripItem)toolStripSeparator10,
			(ToolStripItem)toolStripButtonSQL,
			(ToolStripItem)toolStripSeparator20,
			(ToolStripItem)toolStripButtonXSS,
			(ToolStripItem)toolStripSeparator11,
			(ToolStripItem)ButtonResend,
			(ToolStripItem)ButtonCookie,
			(ToolStripItem)toolStripSeparator17,
			(ToolStripItem)ButtonReport,
			(ToolStripItem)toolStripSeparator18,
			(ToolStripItem)ButtonSetting,
			(ToolStripItem)toolStripSeparator13,
			(ToolStripItem)ButtonTest,
			(ToolStripItem)toolStripSeparator15,
			(ToolStripItem)ButtonScanURL,
			(ToolStripItem)toolStripSeparator14,
			(ToolStripItem)ButtonScanSite
		});
		((Control)toolStripMain).set_Location(new Point(0, 24));
		((Control)toolStripMain).set_Name("toolStripMain");
		((Control)toolStripMain).set_Size(new Size(792, 25));
		((Control)toolStripMain).set_TabIndex(1);
		((Control)toolStripMain).set_Text("toolStrip1");
		((ToolStripItem)toolStripButtonNew).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)toolStripButtonNew).set_Image((Image)componentResourceManager.GetObject("toolStripButtonNew.Image"));
		((ToolStripItem)toolStripButtonNew).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)toolStripButtonNew).set_Name("toolStripButtonNew");
		((ToolStripItem)toolStripButtonNew).set_Size(new Size(23, 22));
		((ToolStripItem)toolStripButtonNew).set_Text("toolStripButton1");
		((ToolStripItem)toolStripButtonNew).set_ToolTipText("New Scan");
		((ToolStripItem)toolStripButtonNew).add_Click((EventHandler)toolStripButtonNew_Click);
		((ToolStripItem)toolStripButtonOpen).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)toolStripButtonOpen).set_Image((Image)componentResourceManager.GetObject("toolStripButtonOpen.Image"));
		((ToolStripItem)toolStripButtonOpen).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)toolStripButtonOpen).set_Name("toolStripButtonOpen");
		((ToolStripItem)toolStripButtonOpen).set_Size(new Size(23, 22));
		((ToolStripItem)toolStripButtonOpen).set_Text("toolStripButton2");
		((ToolStripItem)toolStripButtonOpen).set_ToolTipText("Open Existed Data");
		((ToolStripItem)toolStripButtonOpen).add_Click((EventHandler)toolStripButtonOpen_Click);
		((ToolStripItem)toolStripButtonSave).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)toolStripButtonSave).set_Image((Image)componentResourceManager.GetObject("toolStripButtonSave.Image"));
		((ToolStripItem)toolStripButtonSave).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)toolStripButtonSave).set_Name("toolStripButtonSave");
		((ToolStripItem)toolStripButtonSave).set_Size(new Size(23, 22));
		((ToolStripItem)toolStripButtonSave).set_Text("toolStripButton3");
		((ToolStripItem)toolStripButtonSave).set_ToolTipText("Save Current Data");
		((ToolStripItem)toolStripButtonSave).add_Click((EventHandler)toolStripButtonSave_Click);
		((ToolStripItem)toolStripSeparator4).set_Name("toolStripSeparator4");
		((ToolStripItem)toolStripSeparator4).set_Size(new Size(6, 25));
		((ToolStripItem)toolStripButtonBrowser).set_Image((Image)(object)Resources.Bitmap_1);
		((ToolStripItem)toolStripButtonBrowser).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)toolStripButtonBrowser).set_Name("toolStripButtonBrowser");
		((ToolStripItem)toolStripButtonBrowser).set_Size(new Size(67, 22));
		((ToolStripItem)toolStripButtonBrowser).set_Text("Browser");
		((ToolStripItem)toolStripButtonBrowser).set_ToolTipText("Web Browser");
		((ToolStripItem)toolStripButtonBrowser).add_Click((EventHandler)toolStripButtonBrowser_Click);
		((ToolStripItem)toolStripButtonScanner).set_Image((Image)(object)Resources.scan);
		((ToolStripItem)toolStripButtonScanner).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)toolStripButtonScanner).set_Name("toolStripButtonScanner");
		((ToolStripItem)toolStripButtonScanner).set_Size(new Size(67, 22));
		((ToolStripItem)toolStripButtonScanner).set_Text("Scanner");
		((ToolStripItem)toolStripButtonScanner).set_ToolTipText("Vulnerability Scanner");
		((ToolStripItem)toolStripButtonScanner).add_Click((EventHandler)toolStripButtonScanner_Click);
		((ToolStripItem)toolStripSeparator10).set_Name("toolStripSeparator10");
		((ToolStripItem)toolStripSeparator10).set_Size(new Size(6, 25));
		((ToolStripItem)toolStripButtonSQL).set_Image((Image)(object)Resources.Bitmap_0);
		((ToolStripItem)toolStripButtonSQL).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)toolStripButtonSQL).set_Name("toolStripButtonSQL");
		((ToolStripItem)toolStripButtonSQL).set_Size(new Size(43, 22));
		((ToolStripItem)toolStripButtonSQL).set_Text("SQL");
		((ToolStripItem)toolStripButtonSQL).set_ToolTipText("SQL Injection");
		((ToolStripItem)toolStripButtonSQL).add_Click((EventHandler)toolStripButtonSQL_Click);
		((ToolStripItem)toolStripSeparator20).set_Name("toolStripSeparator20");
		((ToolStripItem)toolStripSeparator20).set_Size(new Size(6, 25));
		((ToolStripItem)toolStripButtonXSS).set_Image((Image)(object)Resources.Bitmap_2);
		((ToolStripItem)toolStripButtonXSS).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)toolStripButtonXSS).set_Name("toolStripButtonXSS");
		((ToolStripItem)toolStripButtonXSS).set_Size(new Size(43, 22));
		((ToolStripItem)toolStripButtonXSS).set_Text("XSS");
		((ToolStripItem)toolStripButtonXSS).set_ToolTipText("Cross Site Scripting");
		((ToolStripItem)toolStripButtonXSS).add_Click((EventHandler)toolStripButtonXSS_Click);
		((ToolStripItem)toolStripSeparator11).set_Name("toolStripSeparator11");
		((ToolStripItem)toolStripSeparator11).set_Size(new Size(6, 25));
		((ToolStripItem)ButtonResend).set_Image((Image)(object)Resources.resend);
		((ToolStripItem)ButtonResend).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)ButtonResend).set_Name("ButtonResend");
		((ToolStripItem)ButtonResend).set_Size(new Size(61, 22));
		((ToolStripItem)ButtonResend).set_Text("Resend");
		((ToolStripItem)ButtonResend).set_ToolTipText("Resend Tool");
		((ToolStripItem)ButtonResend).add_Click((EventHandler)ButtonResend_Click);
		((ToolStripItem)ButtonCookie).set_Image((Image)componentResourceManager.GetObject("ButtonCookie.Image"));
		((ToolStripItem)ButtonCookie).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)ButtonCookie).set_Name("ButtonCookie");
		((ToolStripItem)ButtonCookie).set_Size(new Size(61, 22));
		((ToolStripItem)ButtonCookie).set_Text("Cookie");
		((ToolStripItem)ButtonCookie).add_Click((EventHandler)ButtonCookie_Click);
		((ToolStripItem)toolStripSeparator17).set_Name("toolStripSeparator17");
		((ToolStripItem)toolStripSeparator17).set_Size(new Size(6, 25));
		((ToolStripItem)ButtonReport).set_Image((Image)(object)Resources.report);
		((ToolStripItem)ButtonReport).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)ButtonReport).set_Name("ButtonReport");
		((ToolStripItem)ButtonReport).set_Size(new Size(61, 22));
		((ToolStripItem)ButtonReport).set_Text("Report");
		((ToolStripItem)ButtonReport).add_Click((EventHandler)ButtonReport_Click);
		((ToolStripItem)toolStripSeparator18).set_Name("toolStripSeparator18");
		((ToolStripItem)toolStripSeparator18).set_Size(new Size(6, 25));
		((ToolStripItem)ButtonSetting).set_Image((Image)(object)Resources.tool);
		((ToolStripItem)ButtonSetting).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)ButtonSetting).set_Name("ButtonSetting");
		((ToolStripItem)ButtonSetting).set_Size(new Size(67, 22));
		((ToolStripItem)ButtonSetting).set_Text("Setting");
		((ToolStripItem)ButtonSetting).add_Click((EventHandler)ButtonSetting_Click);
		((ToolStripItem)toolStripSeparator13).set_Name("toolStripSeparator13");
		((ToolStripItem)toolStripSeparator13).set_Size(new Size(6, 25));
		((ToolStripItem)ButtonTest).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ButtonTest).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)ButtonTest).set_Name("ButtonTest");
		((ToolStripItem)ButtonTest).set_Size(new Size(23, 22));
		((ToolStripItem)ButtonTest).set_Text("Test");
		((ToolStripItem)ButtonTest).add_Click((EventHandler)ButtonTest_Click);
		((ToolStripItem)toolStripSeparator15).set_Alignment((ToolStripItemAlignment)1);
		((ToolStripItem)toolStripSeparator15).set_Name("toolStripSeparator15");
		((ToolStripItem)toolStripSeparator15).set_Size(new Size(6, 25));
		((ToolStripItem)ButtonScanURL).set_Alignment((ToolStripItemAlignment)1);
		((ToolStripItem)ButtonScanURL).set_Image((Image)(object)Resources.scan);
		((ToolStripItem)ButtonScanURL).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)ButtonScanURL).set_Name("ButtonScanURL");
		((ToolStripItem)ButtonScanURL).set_Size(new Size(73, 22));
		((ToolStripItem)ButtonScanURL).set_Text("Scan URL");
		((ToolStripItem)ButtonScanURL).set_ToolTipText("Scan Current URL");
		((ToolStripItem)ButtonScanURL).add_Click((EventHandler)ButtonScanURL_Click);
		((ToolStripItem)toolStripSeparator14).set_Alignment((ToolStripItemAlignment)1);
		((ToolStripItem)toolStripSeparator14).set_Name("toolStripSeparator14");
		((ToolStripItem)toolStripSeparator14).set_Size(new Size(6, 25));
		((ToolStripItem)ButtonScanSite).set_Alignment((ToolStripItemAlignment)1);
		((ToolStripItem)ButtonScanSite).set_Image((Image)(object)Resources.scan);
		((ToolStripItem)ButtonScanSite).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)ButtonScanSite).set_Name("ButtonScanSite");
		((ToolStripItem)ButtonScanSite).set_Size(new Size(79, 22));
		((ToolStripItem)ButtonScanSite).set_Text("Scan Site");
		((ToolStripItem)ButtonScanSite).set_ToolTipText("Scan Current Site");
		((ToolStripItem)ButtonScanSite).add_Click((EventHandler)ButtonScanSite_Click);
		((ToolStrip)statusStripMain).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)toolStripStatusProgress,
			(ToolStripItem)toolStripStatusSep1,
			(ToolStripItem)lblThreadNum
		});
		((Control)statusStripMain).set_Location(new Point(0, 494));
		((Control)statusStripMain).set_Name("statusStripMain");
		((Control)statusStripMain).set_Size(new Size(792, 22));
		((Control)statusStripMain).set_TabIndex(2);
		((Control)statusStripMain).set_Text("statusStrip1");
		((ToolStripItem)toolStripStatusProgress).set_AutoSize(false);
		((ToolStripItem)toolStripStatusProgress).set_Name("toolStripStatusProgress");
		((ToolStripItem)toolStripStatusProgress).set_Size(new Size(642, 17));
		((ToolStripItem)toolStripStatusProgress).set_Text("Done");
		((ToolStripItem)toolStripStatusProgress).set_TextAlign((ContentAlignment)16);
		((ToolStripItem)toolStripStatusSep1).set_ForeColor(SystemColors.ControlDark);
		((ToolStripItem)toolStripStatusSep1).set_Name("toolStripStatusSep1");
		((ToolStripItem)toolStripStatusSep1).set_Size(new Size(11, 17));
		((ToolStripItem)toolStripStatusSep1).set_Text("|");
		((ToolStripItem)lblThreadNum).set_AutoSize(false);
		((ToolStripItem)lblThreadNum).set_Name("lblThreadNum");
		((ToolStripItem)lblThreadNum).set_Size(new Size(125, 17));
		((ToolStripItem)lblThreadNum).set_TextAlign((ContentAlignment)16);
		toolStripURL.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)toolStripLabel1,
			(ToolStripItem)toolStripSeparator1,
			(ToolStripItem)txtURL,
			(ToolStripItem)toolStripSeparator3,
			(ToolStripItem)cmbReqType,
			(ToolStripItem)toolStripBtnGo,
			(ToolStripItem)toolStripBtnPause,
			(ToolStripItem)toolStripBtnStop
		});
		((Control)toolStripURL).set_Location(new Point(0, 49));
		((Control)toolStripURL).set_Name("toolStripURL");
		((Control)toolStripURL).set_Size(new Size(792, 25));
		((Control)toolStripURL).set_TabIndex(3);
		((Control)toolStripURL).set_Text("toolStrip1");
		((ToolStripItem)toolStripLabel1).set_Name("toolStripLabel1");
		((ToolStripItem)toolStripLabel1).set_Size(new Size(29, 22));
		((ToolStripItem)toolStripLabel1).set_Text("URL:");
		((ToolStripItem)toolStripSeparator1).set_Name("toolStripSeparator1");
		((ToolStripItem)toolStripSeparator1).set_Size(new Size(6, 25));
		((ToolStripItem)txtURL).set_AutoSize(false);
		((ToolStripItem)txtURL).set_Name("txtURL");
		((ToolStripItem)txtURL).set_Overflow((ToolStripItemOverflow)0);
		((ToolStripItem)txtURL).set_Size(new Size(581, 25));
		((ToolStripItem)txtURL).add_DoubleClick((EventHandler)txtURL_DoubleClick);
		((ToolStripControlHost)txtURL).add_KeyPress(new KeyPressEventHandler(txtURL_KeyPress));
		((ToolStripItem)toolStripSeparator3).set_Name("toolStripSeparator3");
		((ToolStripItem)toolStripSeparator3).set_Size(new Size(6, 25));
		cmbReqType.set_DropDownStyle((ComboBoxStyle)2);
		cmbReqType.get_Items().AddRange(new object[3] { "GET", "POST", "COOKIE" });
		((ToolStripItem)cmbReqType).set_Name("cmbReqType");
		((ToolStripItem)cmbReqType).set_Size(new Size(75, 25));
		((ToolStripItem)cmbReqType).set_ToolTipText("Request Type");
		cmbReqType.add_DropDownClosed((EventHandler)cmbReqType_DropDownClosed);
		((ToolStripItem)toolStripBtnGo).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)toolStripBtnGo).set_Image((Image)componentResourceManager.GetObject("toolStripBtnGo.Image"));
		((ToolStripItem)toolStripBtnGo).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)toolStripBtnGo).set_Name("toolStripBtnGo");
		((ToolStripItem)toolStripBtnGo).set_Size(new Size(23, 22));
		((ToolStripItem)toolStripBtnGo).set_Text("toolStripButton1");
		((ToolStripItem)toolStripBtnGo).set_ToolTipText("Browser");
		((ToolStripItem)toolStripBtnGo).add_Click((EventHandler)toolStripBtnGo_Click);
		((ToolStripItem)toolStripBtnPause).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)toolStripBtnPause).set_Image((Image)componentResourceManager.GetObject("toolStripBtnPause.Image"));
		((ToolStripItem)toolStripBtnPause).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)toolStripBtnPause).set_Name("toolStripBtnPause");
		((ToolStripItem)toolStripBtnPause).set_Size(new Size(23, 22));
		((ToolStripItem)toolStripBtnPause).set_Text("toolStripButton1");
		((ToolStripItem)toolStripBtnPause).set_ToolTipText("Pause");
		((ToolStripItem)toolStripBtnPause).add_Click((EventHandler)toolStripBtnPause_Click);
		((ToolStripItem)toolStripBtnStop).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)toolStripBtnStop).set_Image((Image)componentResourceManager.GetObject("toolStripBtnStop.Image"));
		((ToolStripItem)toolStripBtnStop).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)toolStripBtnStop).set_Name("toolStripBtnStop");
		((ToolStripItem)toolStripBtnStop).set_Size(new Size(23, 22));
		((ToolStripItem)toolStripBtnStop).set_Text("toolStripButton1");
		((ToolStripItem)toolStripBtnStop).set_ToolTipText("Stop");
		((ToolStripItem)toolStripBtnStop).add_Click((EventHandler)toolStripBtnStop_Click);
		toolStripData.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)lblSubmitData,
			(ToolStripItem)toolStripSeparator2,
			(ToolStripItem)txtSubmitData,
			(ToolStripItem)toolStripSeparator16,
			(ToolStripItem)ButtonAutoFill
		});
		((Control)toolStripData).set_Location(new Point(0, 74));
		((Control)toolStripData).set_Name("toolStripData");
		((Control)toolStripData).set_Size(new Size(792, 25));
		((Control)toolStripData).set_TabIndex(6);
		((Control)toolStripData).set_Visible(false);
		((ToolStripItem)lblSubmitData).set_Name("lblSubmitData");
		((ToolStripItem)lblSubmitData).set_Size(new Size(29, 22));
		((ToolStripItem)lblSubmitData).set_Text("Data");
		((ToolStripItem)toolStripSeparator2).set_Name("toolStripSeparator2");
		((ToolStripItem)toolStripSeparator2).set_Size(new Size(6, 25));
		((ToolStripItem)txtSubmitData).set_AutoSize(false);
		((ToolStripItem)txtSubmitData).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((ToolStripItem)txtSubmitData).set_Name("txtSubmitData");
		((ToolStripItem)txtSubmitData).set_Overflow((ToolStripItemOverflow)0);
		((ToolStripItem)txtSubmitData).set_Size(new Size(650, 25));
		((ToolStripItem)txtSubmitData).set_ToolTipText(componentResourceManager.GetString("txtSubmitData.ToolTipText"));
		((ToolStripItem)txtSubmitData).add_DoubleClick((EventHandler)txtSubmitData_DoubleClick);
		((ToolStripControlHost)txtSubmitData).add_KeyPress(new KeyPressEventHandler(txtSubmitData_KeyPress));
		((ToolStripItem)toolStripSeparator16).set_Name("toolStripSeparator16");
		((ToolStripItem)toolStripSeparator16).set_Size(new Size(6, 25));
		((ToolStripItem)ButtonAutoFill).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ButtonAutoFill).set_Image((Image)(object)Resources.fill);
		((ToolStripItem)ButtonAutoFill).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)ButtonAutoFill).set_Name("ButtonAutoFill");
		((ToolStripItem)ButtonAutoFill).set_Size(new Size(23, 22));
		((ToolStripItem)ButtonAutoFill).set_Text("Fill in Form");
		((ToolStripItem)ButtonAutoFill).add_Click((EventHandler)ButtonAutoFill_Click);
		timer_0.set_Enabled(true);
		timer_0.set_Interval(2500);
		timer_0.add_Tick((EventHandler)timer_0_Tick);
		timer_1.set_Enabled(true);
		timer_1.set_Interval(90000);
		timer_1.add_Tick((EventHandler)timer_1_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(792, 516));
		((Control)this).get_Controls().Add((Control)(object)splitMain);
		((Control)this).get_Controls().Add((Control)(object)toolStripData);
		((Control)this).get_Controls().Add((Control)(object)toolStripURL);
		((Control)this).get_Controls().Add((Control)(object)statusStripMain);
		((Control)this).get_Controls().Add((Control)(object)toolStripMain);
		((Control)this).get_Controls().Add((Control)(object)menuStripMain);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_IsMdiContainer(true);
		((Form)this).set_MainMenuStrip(menuStripMain);
		((Control)this).set_Name("FormMain");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("WebCruiser - Web Vulnerability Scanner Personal Edition");
		((Form)this).add_FormClosing(new FormClosingEventHandler(FormMain_FormClosing));
		((Control)this).add_Resize((EventHandler)FormMain_Resize);
		((Control)splitMain.get_Panel1()).ResumeLayout(false);
		((Control)splitMain).ResumeLayout(false);
		((Control)menuStripMain).ResumeLayout(false);
		((Control)menuStripMain).PerformLayout();
		((Control)toolStripMain).ResumeLayout(false);
		((Control)toolStripMain).PerformLayout();
		((Control)statusStripMain).ResumeLayout(false);
		((Control)statusStripMain).PerformLayout();
		((Control)toolStripURL).ResumeLayout(false);
		((Control)toolStripURL).PerformLayout();
		((Control)toolStripData).ResumeLayout(false);
		((Control)toolStripData).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
