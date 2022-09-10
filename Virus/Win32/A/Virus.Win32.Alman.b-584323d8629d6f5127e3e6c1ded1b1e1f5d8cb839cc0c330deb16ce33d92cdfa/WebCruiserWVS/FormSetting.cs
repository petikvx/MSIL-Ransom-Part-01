using System;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace WebCruiserWVS;

public class FormSetting : Form
{
	private IContainer icontainer_0;

	private ToolStrip toolStripSetting;

	private ToolStripSeparator toolStripSeparator1;

	private TabControl tabSetting;

	private TabPage tabProxy;

	private Label label10;

	private CheckBox chkUseProxy;

	private TextBox txtProxyPassword;

	private TextBox txtProxyUsername;

	private Label label4;

	private Label label3;

	private TextBox txtProxyPort;

	private Label label2;

	private Label label1;

	private TextBox txtProxyAddr;

	private TabPage tabAdvanced;

	private TextBox txtRepExpr3;

	private Label label12;

	private TextBox txtFiltExpr3;

	private CheckBox chkReplace3;

	private TextBox txtRepExpr2;

	private Label label9;

	private TextBox txtFiltExpr2;

	private CheckBox chkReplace2;

	private TextBox txtRepExpr1;

	private Label label5;

	private TextBox txtFiltExpr1;

	private CheckBox chkReplace1;

	private TabPage tabScanner;

	private TextBox txtMultiSitesNum;

	private Label label18;

	private TextBox txtCrawlableExt;

	private Label label14;

	private TextBox txtScanDepth;

	private Label label13;

	private TabPage tabAccess;

	private TextBox txtAccessColumns;

	private Label label11;

	private Label label8;

	private TextBox txtAccessTables;

	private TabPage tabAdmin;

	private Label label17;

	private TextBox txtAdminPage;

	private Label label16;

	private TextBox txtAdminPath;

	private ToolStripButton ButtonSaveSetting;

	private ToolStripSeparator toolStripSeparator2;

	private TabPage tabXSInj;

	private TextBox txtXSinjUsage;

	private Label label20;

	private Label label19;

	private TextBox txtXSRecord;

	private TextBox txtXSInjURL;

	private ToolTip toolTip_0;

	private GroupBox GroupBoxVulSetting;

	private CheckBox CheckBoxXPath;

	private CheckBox CheckBoxXSS;

	private CheckBox CheckBoxSQLInjection;

	private TextBox txtUserAgent;

	private Label label6;

	private Label lblDelay;

	private TextBox txtMaxThread;

	private TextBox txtDelay;

	private Label label7;

	private GroupBox GroupBoxScanSetting;

	private CheckBox CheckBoxScanCookieSQL;

	private CheckBox CheckBoxScanPostSQL;

	private CheckBox CheckBoxScanURLSQL;

	public FormSetting()
	{
		InitializeComponent();
		chkUseProxy.set_Checked(WebCruiserWVS.Default.UseProxy);
		((Control)txtProxyAddr).set_Text(WebCruiserWVS.Default.ProxyAddress);
		((Control)txtProxyPort).set_Text(WebCruiserWVS.Default.ProxyPort.ToString());
		((Control)txtProxyUsername).set_Text(WebCruiserWVS.Default.ProxyUsername);
		((Control)txtProxyPassword).set_Text(WebCruiserWVS.Default.ProxyPassword);
		((Control)txtUserAgent).set_Text(WebCruiserWVS.Default.UserAgent);
		((Control)txtMaxThread).set_Text(WebCruiserWVS.Default.MaxHTTPThread.ToString());
		((Control)txtDelay).set_Text(WebCruiserWVS.Default.SecondsDelay.ToString());
		chkReplace1.set_Checked(WebCruiserWVS.Default.chkReplace1);
		((Control)txtFiltExpr1).set_Text(WebCruiserWVS.Default.FiltExpr1);
		((Control)txtRepExpr1).set_Text(WebCruiserWVS.Default.RepExpr1);
		chkReplace2.set_Checked(WebCruiserWVS.Default.chkReplace2);
		((Control)txtFiltExpr2).set_Text(WebCruiserWVS.Default.FiltExpr2);
		((Control)txtRepExpr2).set_Text(WebCruiserWVS.Default.RepExpr2);
		chkReplace3.set_Checked(WebCruiserWVS.Default.chkReplace3);
		((Control)txtFiltExpr3).set_Text(WebCruiserWVS.Default.FiltExpr3);
		((Control)txtRepExpr3).set_Text(WebCruiserWVS.Default.RepExpr3);
		((Control)txtCrawlableExt).set_Text(WebCruiserWVS.Default.CrawlableExt);
		((Control)txtScanDepth).set_Text(WebCruiserWVS.Default.ScanDepth.ToString());
		((Control)txtMultiSitesNum).set_Text(WebCruiserWVS.Default.MultiSitesNum.ToString());
		CheckBoxSQLInjection.set_Checked(WebCruiserWVS.Default.ScanSQLInjection);
		CheckBoxScanURLSQL.set_Checked(WebCruiserWVS.Default.ScanURLSQL);
		CheckBoxScanPostSQL.set_Checked(WebCruiserWVS.Default.ScanPostSQL);
		CheckBoxScanCookieSQL.set_Checked(WebCruiserWVS.Default.ScanCookieSQL);
		method_0(CheckBoxSQLInjection.get_Checked());
		CheckBoxXSS.set_Checked(WebCruiserWVS.Default.ScanXSS);
		CheckBoxXPath.set_Checked(WebCruiserWVS.Default.ScanXPathInjection);
		string[] array = WebCruiserWVS.Default.AccessTables.Split(new char[1] { ':' });
		string[] array2 = array;
		foreach (string text in array2)
		{
			TextBox obj = txtAccessTables;
			((Control)obj).set_Text(((Control)obj).get_Text() + text + "\r\n");
		}
		string[] array3 = WebCruiserWVS.Default.AccessColumns.Split(new char[1] { ':' });
		string[] array4 = array3;
		foreach (string text2 in array4)
		{
			TextBox obj2 = txtAccessColumns;
			((Control)obj2).set_Text(((Control)obj2).get_Text() + text2 + "\r\n");
		}
		string[] array5 = WebCruiserWVS.Default.AdminPath.Split(new char[1] { ':' });
		string[] array6 = array5;
		foreach (string text3 in array6)
		{
			TextBox obj3 = txtAdminPath;
			((Control)obj3).set_Text(((Control)obj3).get_Text() + text3 + "\r\n");
		}
		string[] array7 = WebCruiserWVS.Default.AdminPage.Split(new char[1] { ':' });
		string[] array8 = array7;
		foreach (string text4 in array8)
		{
			TextBox obj4 = txtAdminPage;
			((Control)obj4).set_Text(((Control)obj4).get_Text() + text4 + "\r\n");
		}
		((Control)txtXSInjURL).set_Text(WebCruiserWVS.Default.CrossSiteURL);
		((Control)txtXSRecord).set_Text(WebCruiserWVS.Default.CrossSiteRecord);
	}

	private void CheckBoxSQLInjection_CheckedChanged(object sender, EventArgs e)
	{
		method_0(CheckBoxSQLInjection.get_Checked());
	}

	private void method_0(bool bool_0)
	{
		((Control)CheckBoxScanURLSQL).set_Enabled(bool_0);
		((Control)CheckBoxScanPostSQL).set_Enabled(bool_0);
		((Control)CheckBoxScanCookieSQL).set_Enabled(bool_0);
	}

	private void ButtonSaveSetting_Click(object sender, EventArgs e)
	{
		//IL_0513: Unknown result type (might be due to invalid IL or missing references)
		//IL_052e: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			WCRSetting.UseProxy = chkUseProxy.get_Checked();
			WebCruiserWVS.Default.UseProxy = WCRSetting.UseProxy;
			WCRSetting.ProxyAddress = ((Control)txtProxyAddr).get_Text();
			WebCruiserWVS.Default.ProxyAddress = WCRSetting.ProxyAddress;
			WCRSetting.ProxyPort = int.Parse(((Control)txtProxyPort).get_Text());
			WebCruiserWVS.Default.ProxyPort = WCRSetting.ProxyPort;
			WCRSetting.ProxyUsername = ((Control)txtProxyUsername).get_Text();
			WebCruiserWVS.Default.ProxyUsername = WCRSetting.ProxyUsername;
			WCRSetting.ProxyPassword = ((Control)txtProxyPassword).get_Text();
			WebCruiserWVS.Default.ProxyPassword = WCRSetting.ProxyPassword;
			WCRSetting.chkReplace1 = chkReplace1.get_Checked();
			WebCruiserWVS.Default.chkReplace1 = WCRSetting.chkReplace1;
			WCRSetting.FiltExpr1 = ((Control)txtFiltExpr1).get_Text();
			WebCruiserWVS.Default.FiltExpr1 = WCRSetting.FiltExpr1;
			WCRSetting.RepExpr1 = ((Control)txtRepExpr1).get_Text();
			WebCruiserWVS.Default.RepExpr1 = WCRSetting.RepExpr1;
			WCRSetting.chkReplace2 = chkReplace2.get_Checked();
			WebCruiserWVS.Default.chkReplace2 = WCRSetting.chkReplace2;
			WCRSetting.FiltExpr2 = ((Control)txtFiltExpr2).get_Text();
			WebCruiserWVS.Default.FiltExpr2 = WCRSetting.FiltExpr2;
			WCRSetting.RepExpr2 = ((Control)txtRepExpr2).get_Text();
			WebCruiserWVS.Default.RepExpr2 = WCRSetting.RepExpr2;
			WCRSetting.chkReplace3 = chkReplace3.get_Checked();
			WebCruiserWVS.Default.chkReplace3 = WCRSetting.chkReplace3;
			WCRSetting.FiltExpr3 = ((Control)txtFiltExpr3).get_Text();
			WebCruiserWVS.Default.FiltExpr3 = WCRSetting.FiltExpr3;
			WCRSetting.RepExpr3 = ((Control)txtRepExpr3).get_Text();
			WebCruiserWVS.Default.RepExpr3 = WCRSetting.RepExpr3;
			WCRSetting.UserAgent = ((Control)txtUserAgent).get_Text();
			WebCruiserWVS.Default.UserAgent = WCRSetting.UserAgent;
			WCRSetting.MaxHTTPThreadNum = int.Parse(((Control)txtMaxThread).get_Text());
			WebCruiserWVS.Default.MaxHTTPThread = WCRSetting.MaxHTTPThreadNum;
			WCRSetting.SecondsDelay = int.Parse(((Control)txtDelay).get_Text());
			WebCruiserWVS.Default.SecondsDelay = WCRSetting.SecondsDelay;
			WCRSetting.ScanDepth = int.Parse(((Control)txtScanDepth).get_Text());
			WebCruiserWVS.Default.ScanDepth = WCRSetting.ScanDepth;
			WCRSetting.CrawlableExt = ((Control)txtCrawlableExt).get_Text();
			WCRSetting.CrawlableExt = WCRSetting.CrawlableExt.Replace(" ", "").Trim();
			WebCruiserWVS.Default.CrawlableExt = WCRSetting.CrawlableExt;
			WCRSetting.MultiSitesNum = int.Parse(((Control)txtMultiSitesNum).get_Text());
			WebCruiserWVS.Default.MultiSitesNum = WCRSetting.MultiSitesNum;
			WCRSetting.bool_0 = CheckBoxSQLInjection.get_Checked();
			WebCruiserWVS.Default.ScanSQLInjection = WCRSetting.bool_0;
			if (WCRSetting.bool_0)
			{
				WCRSetting.bool_1 = CheckBoxScanURLSQL.get_Checked();
				WebCruiserWVS.Default.ScanURLSQL = WCRSetting.bool_1;
				WCRSetting.bool_2 = CheckBoxScanPostSQL.get_Checked();
				WebCruiserWVS.Default.ScanPostSQL = WCRSetting.bool_2;
				WCRSetting.bool_3 = CheckBoxScanCookieSQL.get_Checked();
				WebCruiserWVS.Default.ScanCookieSQL = WCRSetting.bool_3;
			}
			else
			{
				WCRSetting.bool_1 = false;
				WebCruiserWVS.Default.ScanURLSQL = false;
				WCRSetting.bool_2 = false;
				WebCruiserWVS.Default.ScanPostSQL = false;
				WCRSetting.bool_3 = false;
				WebCruiserWVS.Default.ScanCookieSQL = false;
			}
			WCRSetting.bool_4 = CheckBoxXSS.get_Checked();
			WebCruiserWVS.Default.ScanXSS = WCRSetting.bool_4;
			WCRSetting.bool_5 = CheckBoxXPath.get_Checked();
			WebCruiserWVS.Default.ScanXPathInjection = WCRSetting.bool_5;
			string accessTables = ((Control)txtAccessTables).get_Text().Trim().Replace("\r\n", ":")
				.Replace(" ", "");
			WebCruiserWVS.Default.AccessTables = accessTables;
			string accessColumns = ((Control)txtAccessColumns).get_Text().Trim().Replace("\r\n", ":")
				.Replace(" ", "");
			WebCruiserWVS.Default.AccessColumns = accessColumns;
			string adminPath = ((Control)txtAdminPath).get_Text().Trim().Replace("\r\n", ":")
				.Replace(" ", "");
			WebCruiserWVS.Default.AdminPath = adminPath;
			string adminPage = ((Control)txtAdminPage).get_Text().Trim().Replace("\r\n", ":")
				.Replace(" ", "");
			WebCruiserWVS.Default.AdminPage = adminPage;
			string crossSiteURL = (WCRSetting.string_0 = ((Control)txtXSInjURL).get_Text().Trim());
			WebCruiserWVS.Default.CrossSiteURL = crossSiteURL;
			string crossSiteRecord = (WCRSetting.string_1 = ((Control)txtXSRecord).get_Text().Trim());
			WebCruiserWVS.Default.CrossSiteRecord = crossSiteRecord;
			((SettingsBase)WebCruiserWVS.Default).Save();
			if (WCRSetting.UseProxy)
			{
				WCRSetting.RefreshIESettings(WCRSetting.ProxyAddress + ":" + WCRSetting.ProxyPort);
			}
			else
			{
				WCRSetting.RefreshIESettings("");
			}
			MessageBox.Show("Save/Apply OK!", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
		catch (Exception ex)
		{
			MessageBox.Show("Please Check your Input!\r\n" + ex.ToString());
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
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected O, but got Unknown
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected O, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected O, but got Unknown
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected O, but got Unknown
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected O, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected O, but got Unknown
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected O, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected O, but got Unknown
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected O, but got Unknown
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected O, but got Unknown
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected O, but got Unknown
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected O, but got Unknown
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected O, but got Unknown
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected O, but got Unknown
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected O, but got Unknown
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected O, but got Unknown
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected O, but got Unknown
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected O, but got Unknown
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected O, but got Unknown
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected O, but got Unknown
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected O, but got Unknown
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected O, but got Unknown
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Expected O, but got Unknown
		//IL_06eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_159e: Unknown result type (might be due to invalid IL or missing references)
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormSetting));
		toolStripSetting = new ToolStrip();
		toolStripSeparator1 = new ToolStripSeparator();
		ButtonSaveSetting = new ToolStripButton();
		toolStripSeparator2 = new ToolStripSeparator();
		tabSetting = new TabControl();
		tabProxy = new TabPage();
		label10 = new Label();
		chkUseProxy = new CheckBox();
		txtProxyPassword = new TextBox();
		txtProxyUsername = new TextBox();
		label4 = new Label();
		label3 = new Label();
		txtProxyPort = new TextBox();
		label2 = new Label();
		label1 = new Label();
		txtProxyAddr = new TextBox();
		tabScanner = new TabPage();
		GroupBoxScanSetting = new GroupBox();
		label6 = new Label();
		txtUserAgent = new TextBox();
		label13 = new Label();
		txtScanDepth = new TextBox();
		lblDelay = new Label();
		label14 = new Label();
		txtMaxThread = new TextBox();
		txtCrawlableExt = new TextBox();
		txtDelay = new TextBox();
		label18 = new Label();
		label7 = new Label();
		txtMultiSitesNum = new TextBox();
		GroupBoxVulSetting = new GroupBox();
		CheckBoxScanCookieSQL = new CheckBox();
		CheckBoxScanPostSQL = new CheckBox();
		CheckBoxScanURLSQL = new CheckBox();
		CheckBoxXPath = new CheckBox();
		CheckBoxXSS = new CheckBox();
		CheckBoxSQLInjection = new CheckBox();
		tabAdvanced = new TabPage();
		txtRepExpr3 = new TextBox();
		label12 = new Label();
		txtFiltExpr3 = new TextBox();
		chkReplace3 = new CheckBox();
		txtRepExpr2 = new TextBox();
		label9 = new Label();
		txtFiltExpr2 = new TextBox();
		chkReplace2 = new CheckBox();
		txtRepExpr1 = new TextBox();
		label5 = new Label();
		txtFiltExpr1 = new TextBox();
		chkReplace1 = new CheckBox();
		tabAccess = new TabPage();
		txtAccessColumns = new TextBox();
		label11 = new Label();
		label8 = new Label();
		txtAccessTables = new TextBox();
		tabXSInj = new TabPage();
		txtXSRecord = new TextBox();
		txtXSInjURL = new TextBox();
		label20 = new Label();
		label19 = new Label();
		txtXSinjUsage = new TextBox();
		tabAdmin = new TabPage();
		label17 = new Label();
		txtAdminPage = new TextBox();
		label16 = new Label();
		txtAdminPath = new TextBox();
		toolTip_0 = new ToolTip(icontainer_0);
		((Control)toolStripSetting).SuspendLayout();
		((Control)tabSetting).SuspendLayout();
		((Control)tabProxy).SuspendLayout();
		((Control)tabScanner).SuspendLayout();
		((Control)GroupBoxScanSetting).SuspendLayout();
		((Control)GroupBoxVulSetting).SuspendLayout();
		((Control)tabAdvanced).SuspendLayout();
		((Control)tabAccess).SuspendLayout();
		((Control)tabXSInj).SuspendLayout();
		((Control)tabAdmin).SuspendLayout();
		((Control)this).SuspendLayout();
		toolStripSetting.set_BackColor(SystemColors.ButtonFace);
		((Control)toolStripSetting).set_Dock((DockStyle)2);
		toolStripSetting.set_GripStyle((ToolStripGripStyle)0);
		toolStripSetting.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)toolStripSeparator1,
			(ToolStripItem)ButtonSaveSetting,
			(ToolStripItem)toolStripSeparator2
		});
		((Control)toolStripSetting).set_Location(new Point(0, 425));
		((Control)toolStripSetting).set_Name("toolStripSetting");
		((Control)toolStripSetting).set_Size(new Size(1036, 25));
		((Control)toolStripSetting).set_TabIndex(0);
		((Control)toolStripSetting).set_Text("toolStrip1");
		((ToolStripItem)toolStripSeparator1).set_Name("toolStripSeparator1");
		((ToolStripItem)toolStripSeparator1).set_Size(new Size(6, 25));
		((ToolStripItem)ButtonSaveSetting).set_AutoSize(false);
		((ToolStripItem)ButtonSaveSetting).set_DisplayStyle((ToolStripItemDisplayStyle)1);
		((ToolStripItem)ButtonSaveSetting).set_Image((Image)componentResourceManager.GetObject("ButtonSaveSetting.Image"));
		((ToolStripItem)ButtonSaveSetting).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)ButtonSaveSetting).set_Name("ButtonSaveSetting");
		((ToolStripItem)ButtonSaveSetting).set_Size(new Size(150, 22));
		((ToolStripItem)ButtonSaveSetting).set_Text("Save / Apply Settings");
		((ToolStripItem)ButtonSaveSetting).add_Click((EventHandler)ButtonSaveSetting_Click);
		((ToolStripItem)toolStripSeparator2).set_Name("toolStripSeparator2");
		((ToolStripItem)toolStripSeparator2).set_Size(new Size(6, 25));
		((Control)tabSetting).get_Controls().Add((Control)(object)tabProxy);
		((Control)tabSetting).get_Controls().Add((Control)(object)tabScanner);
		((Control)tabSetting).get_Controls().Add((Control)(object)tabAdvanced);
		((Control)tabSetting).get_Controls().Add((Control)(object)tabAccess);
		((Control)tabSetting).get_Controls().Add((Control)(object)tabXSInj);
		((Control)tabSetting).get_Controls().Add((Control)(object)tabAdmin);
		((Control)tabSetting).set_Dock((DockStyle)5);
		((Control)tabSetting).set_Location(new Point(0, 0));
		((Control)tabSetting).set_Name("tabSetting");
		tabSetting.set_SelectedIndex(0);
		((Control)tabSetting).set_Size(new Size(1036, 425));
		((Control)tabSetting).set_TabIndex(1);
		((Control)tabProxy).get_Controls().Add((Control)(object)label10);
		((Control)tabProxy).get_Controls().Add((Control)(object)chkUseProxy);
		((Control)tabProxy).get_Controls().Add((Control)(object)txtProxyPassword);
		((Control)tabProxy).get_Controls().Add((Control)(object)txtProxyUsername);
		((Control)tabProxy).get_Controls().Add((Control)(object)label4);
		((Control)tabProxy).get_Controls().Add((Control)(object)label3);
		((Control)tabProxy).get_Controls().Add((Control)(object)txtProxyPort);
		((Control)tabProxy).get_Controls().Add((Control)(object)label2);
		((Control)tabProxy).get_Controls().Add((Control)(object)label1);
		((Control)tabProxy).get_Controls().Add((Control)(object)txtProxyAddr);
		tabProxy.set_Location(new Point(4, 21));
		((Control)tabProxy).set_Name("tabProxy");
		((Control)tabProxy).set_Padding(new Padding(3));
		((Control)tabProxy).set_Size(new Size(1028, 400));
		tabProxy.set_TabIndex(0);
		((Control)tabProxy).set_Text("Proxy");
		tabProxy.set_UseVisualStyleBackColor(true);
		((Control)label10).set_AutoSize(true);
		((Control)label10).set_Location(new Point(6, 134));
		((Control)label10).set_Name("label10");
		((Control)label10).set_Size(new Size(323, 12));
		((Control)label10).set_TabIndex(9);
		((Control)label10).set_Text("* Leave Username/Password Blank For Active Directory!");
		((Control)chkUseProxy).set_AutoSize(true);
		((Control)chkUseProxy).set_Location(new Point(68, 17));
		((Control)chkUseProxy).set_Name("chkUseProxy");
		((Control)chkUseProxy).set_Size(new Size(132, 16));
		((Control)chkUseProxy).set_TabIndex(8);
		((Control)chkUseProxy).set_Text("Use a Proxy Server");
		((ButtonBase)chkUseProxy).set_UseVisualStyleBackColor(true);
		((Control)txtProxyPassword).set_Location(new Point(67, 105));
		((Control)txtProxyPassword).set_Name("txtProxyPassword");
		txtProxyPassword.set_PasswordChar('*');
		((Control)txtProxyPassword).set_Size(new Size(129, 21));
		((Control)txtProxyPassword).set_TabIndex(7);
		((Control)txtProxyUsername).set_Location(new Point(67, 76));
		((Control)txtProxyUsername).set_Name("txtProxyUsername");
		((Control)txtProxyUsername).set_Size(new Size(129, 21));
		((Control)txtProxyUsername).set_TabIndex(6);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Location(new Point(6, 109));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(59, 12));
		((Control)label4).set_TabIndex(5);
		((Control)label4).set_Text("Password:");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Location(new Point(6, 81));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(59, 12));
		((Control)label3).set_TabIndex(4);
		((Control)label3).set_Text("Username:");
		((Control)txtProxyPort).set_Location(new Point(241, 47));
		((Control)txtProxyPort).set_Name("txtProxyPort");
		((Control)txtProxyPort).set_Size(new Size(44, 21));
		((Control)txtProxyPort).set_TabIndex(3);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(203, 51));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(35, 12));
		((Control)label2).set_TabIndex(2);
		((Control)label2).set_Text("Port:");
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(6, 51));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(53, 12));
		((Control)label1).set_TabIndex(1);
		((Control)label1).set_Text("Address:");
		((Control)txtProxyAddr).set_Location(new Point(67, 47));
		((Control)txtProxyAddr).set_Name("txtProxyAddr");
		((Control)txtProxyAddr).set_Size(new Size(129, 21));
		((Control)txtProxyAddr).set_TabIndex(0);
		((Control)tabScanner).get_Controls().Add((Control)(object)GroupBoxScanSetting);
		((Control)tabScanner).get_Controls().Add((Control)(object)GroupBoxVulSetting);
		tabScanner.set_Location(new Point(4, 21));
		((Control)tabScanner).set_Name("tabScanner");
		((Control)tabScanner).set_Size(new Size(1028, 400));
		tabScanner.set_TabIndex(2);
		((Control)tabScanner).set_Text("Scanner");
		tabScanner.set_UseVisualStyleBackColor(true);
		((Control)GroupBoxScanSetting).get_Controls().Add((Control)(object)label6);
		((Control)GroupBoxScanSetting).get_Controls().Add((Control)(object)txtUserAgent);
		((Control)GroupBoxScanSetting).get_Controls().Add((Control)(object)label13);
		((Control)GroupBoxScanSetting).get_Controls().Add((Control)(object)txtScanDepth);
		((Control)GroupBoxScanSetting).get_Controls().Add((Control)(object)lblDelay);
		((Control)GroupBoxScanSetting).get_Controls().Add((Control)(object)label14);
		((Control)GroupBoxScanSetting).get_Controls().Add((Control)(object)txtMaxThread);
		((Control)GroupBoxScanSetting).get_Controls().Add((Control)(object)txtCrawlableExt);
		((Control)GroupBoxScanSetting).get_Controls().Add((Control)(object)txtDelay);
		((Control)GroupBoxScanSetting).get_Controls().Add((Control)(object)label18);
		((Control)GroupBoxScanSetting).get_Controls().Add((Control)(object)label7);
		((Control)GroupBoxScanSetting).get_Controls().Add((Control)(object)txtMultiSitesNum);
		((Control)GroupBoxScanSetting).set_Location(new Point(13, 5));
		((Control)GroupBoxScanSetting).set_Name("GroupBoxScanSetting");
		((Control)GroupBoxScanSetting).set_Size(new Size(490, 201));
		((Control)GroupBoxScanSetting).set_TabIndex(35);
		GroupBoxScanSetting.set_TabStop(false);
		((Control)GroupBoxScanSetting).set_Text("Parameter Setting");
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Location(new Point(18, 28));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(71, 12));
		((Control)label6).set_TabIndex(33);
		((Control)label6).set_Text("User-Agent:");
		((Control)txtUserAgent).set_Location(new Point(95, 25));
		((Control)txtUserAgent).set_Name("txtUserAgent");
		((Control)txtUserAgent).set_Size(new Size(358, 21));
		((Control)txtUserAgent).set_TabIndex(34);
		((Control)label13).set_AutoSize(true);
		((Control)label13).set_Location(new Point(18, 178));
		((Control)label13).set_Name("label13");
		((Control)label13).set_Size(new Size(95, 12));
		((Control)label13).set_TabIndex(0);
		((Control)label13).set_Text("Scanning Depth:");
		((Control)txtScanDepth).set_Location(new Point(114, 174));
		((Control)txtScanDepth).set_Name("txtScanDepth");
		((Control)txtScanDepth).set_Size(new Size(39, 21));
		((Control)txtScanDepth).set_TabIndex(1);
		((Control)lblDelay).set_AutoSize(true);
		((Control)lblDelay).set_Location(new Point(174, 178));
		((Control)lblDelay).set_Name("lblDelay");
		((Control)lblDelay).set_Size(new Size(233, 12));
		((Control)lblDelay).set_TabIndex(32);
		((Control)lblDelay).set_Text("Seconds Delay For Each Search Request:");
		((Control)label14).set_AutoSize(true);
		((Control)label14).set_Location(new Point(18, 121));
		((Control)label14).set_Name("label14");
		((Control)label14).set_Size(new Size(299, 12));
		((Control)label14).set_TabIndex(2);
		((Control)label14).set_Text("Crawling Pages With Extension (Seperated By ':'):");
		((Control)txtMaxThread).set_Location(new Point(413, 61));
		((Control)txtMaxThread).set_Name("txtMaxThread");
		((Control)txtMaxThread).set_Size(new Size(40, 21));
		((Control)txtMaxThread).set_TabIndex(30);
		((Control)txtCrawlableExt).set_Location(new Point(18, 139));
		((Control)txtCrawlableExt).set_Name("txtCrawlableExt");
		((Control)txtCrawlableExt).set_Size(new Size(435, 21));
		((Control)txtCrawlableExt).set_TabIndex(3);
		((Control)txtDelay).set_Location(new Point(413, 174));
		((TextBoxBase)txtDelay).set_MaxLength(4);
		((Control)txtDelay).set_Name("txtDelay");
		((Control)txtDelay).set_Size(new Size(39, 21));
		((Control)txtDelay).set_TabIndex(31);
		((Control)label18).set_AutoSize(true);
		((Control)label18).set_Location(new Point(18, 94));
		((Control)label18).set_Name("label18");
		((Control)label18).set_Size(new Size(389, 12));
		((Control)label18).set_TabIndex(5);
		((Control)label18).set_Text("Maximum Site Thread Number for Multi-Site Scanning (Default: 3):");
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_Location(new Point(18, 64));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(389, 12));
		((Control)label7).set_TabIndex(29);
		((Control)label7).set_Text("Maximum HTTP Thread Number for Single-Site Scanning(Default: 5):");
		((Control)txtMultiSitesNum).set_Location(new Point(413, 88));
		((Control)txtMultiSitesNum).set_Name("txtMultiSitesNum");
		((Control)txtMultiSitesNum).set_Size(new Size(40, 21));
		((Control)txtMultiSitesNum).set_TabIndex(6);
		((Control)GroupBoxVulSetting).get_Controls().Add((Control)(object)CheckBoxScanCookieSQL);
		((Control)GroupBoxVulSetting).get_Controls().Add((Control)(object)CheckBoxScanPostSQL);
		((Control)GroupBoxVulSetting).get_Controls().Add((Control)(object)CheckBoxScanURLSQL);
		((Control)GroupBoxVulSetting).get_Controls().Add((Control)(object)CheckBoxXPath);
		((Control)GroupBoxVulSetting).get_Controls().Add((Control)(object)CheckBoxXSS);
		((Control)GroupBoxVulSetting).get_Controls().Add((Control)(object)CheckBoxSQLInjection);
		((Control)GroupBoxVulSetting).set_Location(new Point(13, 210));
		((Control)GroupBoxVulSetting).set_Name("GroupBoxVulSetting");
		((Control)GroupBoxVulSetting).set_Size(new Size(490, 158));
		((Control)GroupBoxVulSetting).set_TabIndex(7);
		GroupBoxVulSetting.set_TabStop(false);
		((Control)GroupBoxVulSetting).set_Text("Vulnerabilities Setting");
		((Control)CheckBoxScanCookieSQL).set_AutoSize(true);
		((Control)CheckBoxScanCookieSQL).set_Location(new Point(38, 92));
		((Control)CheckBoxScanCookieSQL).set_Name("CheckBoxScanCookieSQL");
		((Control)CheckBoxScanCookieSQL).set_Size(new Size(174, 16));
		((Control)CheckBoxScanCookieSQL).set_TabIndex(5);
		((Control)CheckBoxScanCookieSQL).set_Text("Scan Cookie SQL Injection");
		((ButtonBase)CheckBoxScanCookieSQL).set_UseVisualStyleBackColor(true);
		((Control)CheckBoxScanPostSQL).set_AutoSize(true);
		((Control)CheckBoxScanPostSQL).set_Location(new Point(38, 67));
		((Control)CheckBoxScanPostSQL).set_Name("CheckBoxScanPostSQL");
		((Control)CheckBoxScanPostSQL).set_Size(new Size(162, 16));
		((Control)CheckBoxScanPostSQL).set_TabIndex(4);
		((Control)CheckBoxScanPostSQL).set_Text("Scan Post SQL Injection");
		((ButtonBase)CheckBoxScanPostSQL).set_UseVisualStyleBackColor(true);
		((Control)CheckBoxScanURLSQL).set_AutoSize(true);
		((Control)CheckBoxScanURLSQL).set_Location(new Point(38, 42));
		((Control)CheckBoxScanURLSQL).set_Name("CheckBoxScanURLSQL");
		((Control)CheckBoxScanURLSQL).set_Size(new Size(156, 16));
		((Control)CheckBoxScanURLSQL).set_TabIndex(3);
		((Control)CheckBoxScanURLSQL).set_Text("Scan URL SQL Injection");
		((ButtonBase)CheckBoxScanURLSQL).set_UseVisualStyleBackColor(true);
		((Control)CheckBoxXPath).set_AutoSize(true);
		((Control)CheckBoxXPath).set_Location(new Point(18, 139));
		((Control)CheckBoxXPath).set_Name("CheckBoxXPath");
		((Control)CheckBoxXPath).set_Size(new Size(144, 16));
		((Control)CheckBoxXPath).set_TabIndex(2);
		((Control)CheckBoxXPath).set_Text("Scan XPath Injection");
		((ButtonBase)CheckBoxXPath).set_UseVisualStyleBackColor(true);
		((Control)CheckBoxXSS).set_AutoSize(true);
		((Control)CheckBoxXSS).set_Location(new Point(18, 114));
		((Control)CheckBoxXSS).set_Name("CheckBoxXSS");
		((Control)CheckBoxXSS).set_Size(new Size(174, 16));
		((Control)CheckBoxXSS).set_TabIndex(1);
		((Control)CheckBoxXSS).set_Text("Scan Cross Site Scripting");
		((ButtonBase)CheckBoxXSS).set_UseVisualStyleBackColor(true);
		((Control)CheckBoxSQLInjection).set_AutoSize(true);
		((Control)CheckBoxSQLInjection).set_Location(new Point(18, 20));
		((Control)CheckBoxSQLInjection).set_Name("CheckBoxSQLInjection");
		((Control)CheckBoxSQLInjection).set_Size(new Size(132, 16));
		((Control)CheckBoxSQLInjection).set_TabIndex(0);
		((Control)CheckBoxSQLInjection).set_Text("Scan SQL Injection");
		((ButtonBase)CheckBoxSQLInjection).set_UseVisualStyleBackColor(true);
		CheckBoxSQLInjection.add_CheckedChanged((EventHandler)CheckBoxSQLInjection_CheckedChanged);
		((Control)tabAdvanced).get_Controls().Add((Control)(object)txtRepExpr3);
		((Control)tabAdvanced).get_Controls().Add((Control)(object)label12);
		((Control)tabAdvanced).get_Controls().Add((Control)(object)txtFiltExpr3);
		((Control)tabAdvanced).get_Controls().Add((Control)(object)chkReplace3);
		((Control)tabAdvanced).get_Controls().Add((Control)(object)txtRepExpr2);
		((Control)tabAdvanced).get_Controls().Add((Control)(object)label9);
		((Control)tabAdvanced).get_Controls().Add((Control)(object)txtFiltExpr2);
		((Control)tabAdvanced).get_Controls().Add((Control)(object)chkReplace2);
		((Control)tabAdvanced).get_Controls().Add((Control)(object)txtRepExpr1);
		((Control)tabAdvanced).get_Controls().Add((Control)(object)label5);
		((Control)tabAdvanced).get_Controls().Add((Control)(object)txtFiltExpr1);
		((Control)tabAdvanced).get_Controls().Add((Control)(object)chkReplace1);
		tabAdvanced.set_Location(new Point(4, 21));
		((Control)tabAdvanced).set_Name("tabAdvanced");
		((Control)tabAdvanced).set_Padding(new Padding(3));
		((Control)tabAdvanced).set_Size(new Size(1028, 400));
		tabAdvanced.set_TabIndex(1);
		((Control)tabAdvanced).set_Text("Advanced");
		tabAdvanced.set_UseVisualStyleBackColor(true);
		((Control)txtRepExpr3).set_Location(new Point(169, 88));
		((Control)txtRepExpr3).set_Name("txtRepExpr3");
		((Control)txtRepExpr3).set_Size(new Size(90, 21));
		((Control)txtRepExpr3).set_TabIndex(23);
		((Control)label12).set_AutoSize(true);
		((Control)label12).set_Location(new Point(145, 92));
		((Control)label12).set_Name("label12");
		((Control)label12).set_Size(new Size(17, 12));
		((Control)label12).set_TabIndex(22);
		((Control)label12).set_Text("By");
		((Control)txtFiltExpr3).set_Location(new Point(88, 88));
		((Control)txtFiltExpr3).set_Name("txtFiltExpr3");
		((Control)txtFiltExpr3).set_Size(new Size(50, 21));
		((Control)txtFiltExpr3).set_TabIndex(21);
		((Control)chkReplace3).set_AutoSize(true);
		((Control)chkReplace3).set_Location(new Point(24, 90));
		((Control)chkReplace3).set_Name("chkReplace3");
		((Control)chkReplace3).set_Size(new Size(66, 16));
		((Control)chkReplace3).set_TabIndex(20);
		((Control)chkReplace3).set_Text("Replace");
		((ButtonBase)chkReplace3).set_UseVisualStyleBackColor(true);
		((Control)txtRepExpr2).set_Location(new Point(169, 59));
		((Control)txtRepExpr2).set_Name("txtRepExpr2");
		((Control)txtRepExpr2).set_Size(new Size(90, 21));
		((Control)txtRepExpr2).set_TabIndex(18);
		((Control)label9).set_AutoSize(true);
		((Control)label9).set_Location(new Point(145, 63));
		((Control)label9).set_Name("label9");
		((Control)label9).set_Size(new Size(17, 12));
		((Control)label9).set_TabIndex(17);
		((Control)label9).set_Text("By");
		((Control)txtFiltExpr2).set_Location(new Point(88, 59));
		((Control)txtFiltExpr2).set_Name("txtFiltExpr2");
		((Control)txtFiltExpr2).set_Size(new Size(50, 21));
		((Control)txtFiltExpr2).set_TabIndex(16);
		((Control)chkReplace2).set_AutoSize(true);
		((Control)chkReplace2).set_Location(new Point(24, 61));
		((Control)chkReplace2).set_Name("chkReplace2");
		((Control)chkReplace2).set_Size(new Size(66, 16));
		((Control)chkReplace2).set_TabIndex(15);
		((Control)chkReplace2).set_Text("Replace");
		((ButtonBase)chkReplace2).set_UseVisualStyleBackColor(true);
		((Control)txtRepExpr1).set_Location(new Point(169, 30));
		((Control)txtRepExpr1).set_Name("txtRepExpr1");
		((Control)txtRepExpr1).set_Size(new Size(90, 21));
		((Control)txtRepExpr1).set_TabIndex(13);
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Location(new Point(145, 34));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(17, 12));
		((Control)label5).set_TabIndex(12);
		((Control)label5).set_Text("By");
		((Control)txtFiltExpr1).set_Location(new Point(88, 30));
		((Control)txtFiltExpr1).set_Name("txtFiltExpr1");
		((Control)txtFiltExpr1).set_Size(new Size(50, 21));
		((Control)txtFiltExpr1).set_TabIndex(11);
		((Control)chkReplace1).set_AutoSize(true);
		((Control)chkReplace1).set_Location(new Point(24, 32));
		((Control)chkReplace1).set_Name("chkReplace1");
		((Control)chkReplace1).set_Size(new Size(66, 16));
		((Control)chkReplace1).set_TabIndex(10);
		((Control)chkReplace1).set_Text("Replace");
		((ButtonBase)chkReplace1).set_UseVisualStyleBackColor(true);
		((Control)tabAccess).get_Controls().Add((Control)(object)txtAccessColumns);
		((Control)tabAccess).get_Controls().Add((Control)(object)label11);
		((Control)tabAccess).get_Controls().Add((Control)(object)label8);
		((Control)tabAccess).get_Controls().Add((Control)(object)txtAccessTables);
		tabAccess.set_Location(new Point(4, 21));
		((Control)tabAccess).set_Name("tabAccess");
		((Control)tabAccess).set_Size(new Size(1028, 400));
		tabAccess.set_TabIndex(4);
		((Control)tabAccess).set_Text("Access");
		tabAccess.set_UseVisualStyleBackColor(true);
		((Control)txtAccessColumns).set_Anchor((AnchorStyles)7);
		((Control)txtAccessColumns).set_Location(new Point(241, 19));
		((TextBoxBase)txtAccessColumns).set_Multiline(true);
		((Control)txtAccessColumns).set_Name("txtAccessColumns");
		txtAccessColumns.set_ScrollBars((ScrollBars)2);
		((Control)txtAccessColumns).set_Size(new Size(200, 362));
		((Control)txtAccessColumns).set_TabIndex(3);
		toolTip_0.SetToolTip((Control)(object)txtAccessColumns, "Editable");
		((Control)label11).set_AutoSize(true);
		((Control)label11).set_Location(new Point(243, 4));
		((Control)label11).set_Name("label11");
		((Control)label11).set_Size(new Size(119, 12));
		((Control)label11).set_TabIndex(2);
		((Control)label11).set_Text("Columns Dictionary:");
		((Control)label8).set_AutoSize(true);
		((Control)label8).set_Location(new Point(4, 4));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(113, 12));
		((Control)label8).set_TabIndex(1);
		((Control)label8).set_Text("Tables Dictionary:");
		((Control)txtAccessTables).set_Anchor((AnchorStyles)7);
		((Control)txtAccessTables).set_Location(new Point(3, 19));
		((TextBoxBase)txtAccessTables).set_Multiline(true);
		((Control)txtAccessTables).set_Name("txtAccessTables");
		txtAccessTables.set_ScrollBars((ScrollBars)2);
		((Control)txtAccessTables).set_Size(new Size(200, 362));
		((Control)txtAccessTables).set_TabIndex(0);
		toolTip_0.SetToolTip((Control)(object)txtAccessTables, "Editable");
		((Control)tabXSInj).get_Controls().Add((Control)(object)txtXSRecord);
		((Control)tabXSInj).get_Controls().Add((Control)(object)txtXSInjURL);
		((Control)tabXSInj).get_Controls().Add((Control)(object)label20);
		((Control)tabXSInj).get_Controls().Add((Control)(object)label19);
		((Control)tabXSInj).get_Controls().Add((Control)(object)txtXSinjUsage);
		tabXSInj.set_Location(new Point(4, 21));
		((Control)tabXSInj).set_Name("tabXSInj");
		((Control)tabXSInj).set_Size(new Size(1028, 400));
		tabXSInj.set_TabIndex(6);
		((Control)tabXSInj).set_Text("CrossSiteInjection");
		tabXSInj.set_UseVisualStyleBackColor(true);
		((Control)txtXSRecord).set_Location(new Point(130, 41));
		((Control)txtXSRecord).set_Name("txtXSRecord");
		((Control)txtXSRecord).set_Size(new Size(351, 21));
		((Control)txtXSRecord).set_TabIndex(4);
		((Control)txtXSInjURL).set_Location(new Point(130, 15));
		((Control)txtXSInjURL).set_Name("txtXSInjURL");
		((Control)txtXSInjURL).set_Size(new Size(351, 21));
		((Control)txtXSInjURL).set_TabIndex(3);
		((Control)label20).set_AutoSize(true);
		((Control)label20).set_Location(new Point(9, 44));
		((Control)label20).set_Name("label20");
		((Control)label20).set_Size(new Size(113, 12));
		((Control)label20).set_TabIndex(2);
		((Control)label20).set_Text("Cross Site Record:");
		((Control)label19).set_AutoSize(true);
		((Control)label19).set_Location(new Point(9, 17));
		((Control)label19).set_Name("label19");
		((Control)label19).set_Size(new Size(95, 12));
		((Control)label19).set_TabIndex(1);
		((Control)label19).set_Text("Cross Site URL:");
		((Control)txtXSinjUsage).set_Location(new Point(9, 68));
		((TextBoxBase)txtXSinjUsage).set_Multiline(true);
		((Control)txtXSinjUsage).set_Name("txtXSinjUsage");
		((TextBoxBase)txtXSinjUsage).set_ReadOnly(true);
		((Control)txtXSinjUsage).set_Size(new Size(472, 203));
		((Control)txtXSinjUsage).set_TabIndex(0);
		((Control)txtXSinjUsage).set_Text(componentResourceManager.GetString("txtXSinjUsage.Text"));
		((Control)tabAdmin).get_Controls().Add((Control)(object)label17);
		((Control)tabAdmin).get_Controls().Add((Control)(object)txtAdminPage);
		((Control)tabAdmin).get_Controls().Add((Control)(object)label16);
		((Control)tabAdmin).get_Controls().Add((Control)(object)txtAdminPath);
		tabAdmin.set_Location(new Point(4, 21));
		((Control)tabAdmin).set_Name("tabAdmin");
		((Control)tabAdmin).set_Size(new Size(1028, 400));
		tabAdmin.set_TabIndex(5);
		((Control)tabAdmin).set_Text("AdminEntrance");
		tabAdmin.set_UseVisualStyleBackColor(true);
		((Control)label17).set_AutoSize(true);
		((Control)label17).set_Location(new Point(240, 4));
		((Control)label17).set_Name("label17");
		((Control)label17).set_Size(new Size(155, 12));
		((Control)label17).set_TabIndex(3);
		((Control)label17).set_Text("Admin Page(No Extension):");
		((Control)txtAdminPage).set_Anchor((AnchorStyles)7);
		((Control)txtAdminPage).set_Location(new Point(241, 19));
		((TextBoxBase)txtAdminPage).set_Multiline(true);
		((Control)txtAdminPage).set_Name("txtAdminPage");
		txtAdminPage.set_ScrollBars((ScrollBars)2);
		((Control)txtAdminPage).set_Size(new Size(200, 365));
		((Control)txtAdminPage).set_TabIndex(2);
		toolTip_0.SetToolTip((Control)(object)txtAdminPage, "Editable");
		((Control)label16).set_AutoSize(true);
		((Control)label16).set_Location(new Point(5, 4));
		((Control)label16).set_Name("label16");
		((Control)label16).set_Size(new Size(155, 12));
		((Control)label16).set_TabIndex(1);
		((Control)label16).set_Text("Admin Path(End with '/'):");
		((Control)txtAdminPath).set_Anchor((AnchorStyles)7);
		((Control)txtAdminPath).set_Location(new Point(3, 19));
		((TextBoxBase)txtAdminPath).set_Multiline(true);
		((Control)txtAdminPath).set_Name("txtAdminPath");
		txtAdminPath.set_ScrollBars((ScrollBars)2);
		((Control)txtAdminPath).set_Size(new Size(200, 365));
		((Control)txtAdminPath).set_TabIndex(0);
		toolTip_0.SetToolTip((Control)(object)txtAdminPath, "Editable");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1036, 450));
		((Control)this).get_Controls().Add((Control)(object)tabSetting);
		((Control)this).get_Controls().Add((Control)(object)toolStripSetting);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("FormSetting");
		((Control)this).set_Text("FormSetting");
		((Control)toolStripSetting).ResumeLayout(false);
		((Control)toolStripSetting).PerformLayout();
		((Control)tabSetting).ResumeLayout(false);
		((Control)tabProxy).ResumeLayout(false);
		((Control)tabProxy).PerformLayout();
		((Control)tabScanner).ResumeLayout(false);
		((Control)GroupBoxScanSetting).ResumeLayout(false);
		((Control)GroupBoxScanSetting).PerformLayout();
		((Control)GroupBoxVulSetting).ResumeLayout(false);
		((Control)GroupBoxVulSetting).PerformLayout();
		((Control)tabAdvanced).ResumeLayout(false);
		((Control)tabAdvanced).PerformLayout();
		((Control)tabAccess).ResumeLayout(false);
		((Control)tabAccess).PerformLayout();
		((Control)tabXSInj).ResumeLayout(false);
		((Control)tabXSInj).PerformLayout();
		((Control)tabAdmin).ResumeLayout(false);
		((Control)tabAdmin).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
