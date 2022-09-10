using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Timers;
using System.Web.UI;
using System.Windows.Forms;
using System.Xml;

namespace WebCruiserWVS;

public class FormScanner : Form
{
	private delegate void Delegate6(string string_0);

	private delegate void Delegate7(TreeView treeView_0, TreeView treeView_1);

	private delegate ListViewItem Delegate8(int int_0);

	private FormMain formMain_0;

	private GClass0 gclass0_0;

	private int int_0;

	private List<string> list_0 = new List<string>();

	private bool bool_0;

	private System.Timers.Timer timer_0;

	private IContainer icontainer_0;

	private SplitContainer splitScanner;

	private TreeView treeViewWVS;

	private ToolStrip toolStripScanner;

	private ToolStripButton toolStripWVScan;

	private ToolStripSeparator toolStripSeparator1;

	private ToolStripButton toolStripURLScan;

	private ToolStripSeparator toolStripSeparator2;

	private ToolStripButton toolStripMultiScan;

	private ToolStripSeparator toolStripSeparator3;

	private ToolStripButton toolStripClearWVS;

	private ToolStripSeparator toolStripSeparator4;

	private ToolStripButton toolStripImpWVS;

	private ToolStripSeparator toolStripSeparator5;

	private ToolStripButton toolStripExpWVS;

	private ToolStripSeparator toolStripSeparator6;

	private StatusStrip statusScanner;

	private ToolStripStatusLabel lblProgress;

	private ImageList imageList_0;

	private ToolStripStatusLabel toolStripStatusLabel1;

	private ToolStripStatusLabel lblThreadNum;

	private ToolStripSeparator toolStripSeparator7;

	private ListView listViewWVS;

	private ColumnHeader columnHeader_0;

	private ColumnHeader columnHeader_1;

	private ColumnHeader columnHeader_2;

	private ColumnHeader columnHeader_3;

	private ColumnHeader columnHeader_4;

	public FormScanner(FormMain formMain_1)
	{
		InitializeComponent();
		formMain_0 = formMain_1;
		gclass0_0 = formMain_0.gclass0_0;
		method_1();
	}

	public FormScanner(FormMain formMain_1, GClass0 gclass0_1)
	{
		InitializeComponent();
		formMain_0 = formMain_1;
		bool_0 = true;
		GClass0.int_2++;
		((Control)toolStripScanner).set_Enabled(false);
		((Form)this).set_FormBorderStyle((FormBorderStyle)4);
		gclass0_0 = gclass0_1;
		((Control)this).set_Text(gclass0_0.method_8() + " - Scanner");
		method_1();
		if (!string.IsNullOrEmpty(gclass0_0.method_8()))
		{
			ThreadPool.QueueUserWorkItem(method_21);
		}
	}

	public void method_0(bool bool_1)
	{
		((ToolStripItem)toolStripWVScan).set_Enabled(bool_1);
	}

	private void method_1()
	{
		timer_0 = new System.Timers.Timer();
		timer_0.Interval = 2500.0;
		timer_0.Elapsed += timer_0_Elapsed;
		timer_0.Enabled = true;
	}

	private void method_2(TreeView treeView_0, TreeView treeView_1)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		if (!((Control)treeViewWVS).get_InvokeRequired())
		{
			treeView_1.get_Nodes().Clear();
			foreach (TreeNode node in treeView_0.get_Nodes())
			{
				TreeNode val = node;
				treeView_1.get_Nodes().Add((TreeNode)val.Clone());
			}
			treeView_1.ExpandAll();
		}
		else
		{
			Delegate7 @delegate = method_2;
			((Control)this).Invoke((Delegate)@delegate, new object[2] { treeView_0, treeView_1 });
		}
	}

	private void method_3(string string_0)
	{
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected O, but got Unknown
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrEmpty(string_0))
		{
			return;
		}
		if (string_0.IndexOf('^') > 0)
		{
			string[] array = string_0.Split(new char[1] { '^' });
			string_0 = array[0];
		}
		try
		{
			string_0 = string_0.Replace("/./", "/");
			Uri uri = new Uri(string_0);
			if (!uri.Host.Equals(gclass0_0.method_11()))
			{
				return;
			}
			if (!((Control)treeViewWVS).get_InvokeRequired())
			{
				int num = string_0.IndexOf('/', 9) + 1;
				if (num == 0)
				{
					return;
				}
				string[] array2 = string_0.Substring(num).Split(new char[1] { '?' });
				string[] array3 = array2[0].Split(new char[1] { '/' });
				string text = "";
				if (array2.Length > 1)
				{
					for (int i = 1; i < array2.Length; i++)
					{
						if (!string.IsNullOrEmpty(text))
						{
							text += "?";
						}
						text += array2[i];
					}
					string[] array4;
					string[] array5 = (array4 = array3);
					int num2 = array3.Length - 1;
					nint num3 = num2;
					array5[num2] = array4[num3] + "?" + text;
				}
				TreeNode val = new TreeNode();
				TreeNode val2 = new TreeNode();
				int num4 = 0;
				while (true)
				{
					if (num4 < array3.Length)
					{
						if (string.IsNullOrEmpty(array3[num4]))
						{
							break;
						}
						if (num4 == 0)
						{
							val = method_5(treeViewWVS.get_Nodes(), array3[0]);
							if (val == null)
							{
								val = treeViewWVS.get_Nodes().Add(array3[0]);
							}
						}
						else
						{
							val2 = method_5(val.get_Nodes(), array3[num4]);
							if (val2 == null)
							{
								val2 = val.get_Nodes().Add(array3[num4]);
							}
							val = val2;
						}
						num4++;
						continue;
					}
					treeViewWVS.ExpandAll();
					((Control)treeViewWVS).Refresh();
					break;
				}
			}
			else
			{
				Delegate6 @delegate = method_3;
				((Control)this).Invoke((Delegate)@delegate, new object[1] { string_0 });
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	public void method_4(string string_0)
	{
		if (!((Control)listViewWVS).get_InvokeRequired())
		{
			string[] separator = new string[1] { "^^" };
			string[] array = string_0.Split(separator, StringSplitOptions.None);
			ListViewItem val = listViewWVS.get_Items().Add(array[0]);
			val.set_ImageKey("vul.png");
			for (int i = 1; i < array.Length; i++)
			{
				val.get_SubItems().Add(array[i]);
			}
			((Control)listViewWVS).Refresh();
		}
		else
		{
			Delegate6 @delegate = method_4;
			((Control)this).Invoke((Delegate)@delegate, new object[1] { string_0 });
		}
	}

	private TreeNode method_5(TreeNodeCollection treeNodeCollection_0, string string_0)
	{
		string text = string_0;
		string text2 = "";
		if (string_0.IndexOf('?') >= 0)
		{
			string[] array = string_0.Split(new char[1] { '?' });
			text = array[0];
			if (array.Length >= 2)
			{
				string[] array2 = array[1].Split(new char[1] { '&' });
				string[] array3 = array2;
				foreach (string text3 in array3)
				{
					string[] array4 = text3.Split(new char[1] { '=' });
					text = text + "?" + array4[0];
				}
			}
		}
		int num = 0;
		while (true)
		{
			if (num < treeNodeCollection_0.get_Count())
			{
				text2 = treeNodeCollection_0.get_Item(num).get_Text();
				if (text2.IndexOf('?') >= 0)
				{
					string[] array5 = text2.Split(new char[1] { '?' });
					if (array5.Length < 2)
					{
						text2 = array5[0];
					}
					else
					{
						text2 = array5[0];
						string[] array6 = array5[1].Split(new char[1] { '&' });
						string[] array7 = array6;
						foreach (string text4 in array7)
						{
							string[] array8 = text4.Split(new char[1] { '=' });
							text2 = text2 + "?" + array8[0];
						}
					}
				}
				if (text2.Equals(text))
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return treeNodeCollection_0.get_Item(num);
	}

	private void method_6(object object_0)
	{
		try
		{
			string string_ = gclass0_0.method_10() + "robots.txt";
			HttpWebResponse httpWebResponse = gclass0_0.method_28(string_, GEnum0.GET);
			if (httpWebResponse.StatusCode != HttpStatusCode.OK)
			{
				return;
			}
			string input = formMain_0.gclass0_0.method_29(httpWebResponse);
			Regex regex = new Regex("(?<=allow:\\s+)[^\\s?*$]+", RegexOptions.IgnoreCase | RegexOptions.Singleline);
			MatchCollection matchCollection = regex.Matches(input);
			foreach (Match item in matchCollection)
			{
				string value = item.Value;
				if (value.Length > 1)
				{
					value = gclass0_0.method_10() + value.Substring(1);
					method_3(value);
				}
			}
		}
		catch
		{
		}
	}

	private void method_7(object object_0)
	{
		try
		{
			string string_ = gclass0_0.method_10() + "sitemap.xml";
			HttpWebResponse httpWebResponse = gclass0_0.method_28(string_, GEnum0.GET);
			if (httpWebResponse.StatusCode != HttpStatusCode.OK)
			{
				return;
			}
			string input = formMain_0.gclass0_0.method_29(httpWebResponse);
			Regex regex = new Regex("(?<=<loc>)[\\S]+(?=<\\/loc>)", RegexOptions.IgnoreCase | RegexOptions.Singleline);
			MatchCollection matchCollection = regex.Matches(input);
			foreach (Match item in matchCollection)
			{
				string value = item.Value;
				if (value.Length > 1)
				{
					value = value.Replace("&amp;", "&");
					method_3(value);
				}
			}
		}
		catch
		{
		}
	}

	private bool method_8(string string_0)
	{
		string text = gclass0_0.method_23(string_0);
		if (string.IsNullOrEmpty(text))
		{
			return true;
		}
		text = text.Substring(1).ToLower();
		string[] array = WCRSetting.CrawlableExt.Split(new char[1] { ':' });
		int num = 0;
		while (true)
		{
			if (num < array.Length)
			{
				if (text.Equals(array[num]))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public void method_9(string string_0)
	{
		if (!((Control)statusScanner).get_InvokeRequired())
		{
			((ToolStripItem)lblProgress).set_Text(string_0);
			((Control)statusScanner).Refresh();
		}
		else
		{
			Delegate6 @delegate = method_9;
			((Control)this).Invoke((Delegate)@delegate, new object[1] { string_0 });
		}
	}

	private void method_10(object object_0)
	{
		if (GClass0.genum4_0 == GEnum4.Stop)
		{
			return;
		}
		try
		{
			string text = (string)object_0;
			if (gclass0_0.method_37(text))
			{
				return;
			}
			gclass0_0.method_1(GClass0.smethod_7(text));
			if (!method_8(text))
			{
				return;
			}
			string string_ = gclass0_0.method_23(text);
			method_9("Depth: " + int_0 + "  Scanning: " + text);
			HttpWebResponse httpWebResponse = gclass0_0.method_28(text, GEnum0.GET);
			if (httpWebResponse == null)
			{
				return;
			}
			string string_2 = formMain_0.gclass0_0.method_29(httpWebResponse);
			string text2 = httpWebResponse.ResponseUri.ToString();
			if (!text2.Equals(text))
			{
				gclass0_0.method_1(GClass0.smethod_7(text2));
			}
			string string_3 = GClass0.smethod_8(text2);
			string[] array = gclass0_0.method_38(string_2, string_3, string_);
			string text3 = "";
			for (int i = 0; i < array.Length; i++)
			{
				if (GClass0.genum4_0 == GEnum4.Stop)
				{
					break;
				}
				text3 = array[i];
				Uri uri = new Uri(text3);
				if (uri.Host.Equals(gclass0_0.method_11()))
				{
					method_3(text3);
					method_3(GClass0.smethod_2(text3));
					if (!gclass0_0.method_36(text3) && method_8(text3))
					{
						ThreadPool.QueueUserWorkItem(method_12, text3);
					}
				}
			}
		}
		catch
		{
		}
	}

	private string[] method_11(string string_0)
	{
		List<string> list = new List<string>();
		if (GClass0.genum4_0 == GEnum4.Stop)
		{
			return list.ToArray();
		}
		string[] array = string_0.Split(new char[1] { '?' });
		if (array.Length < 2)
		{
			return list.ToArray();
		}
		string[] array2 = array[1].Split(new char[1] { '&' });
		for (int i = 0; i < array2.Length; i++)
		{
			string text = array[0];
			string text2 = "";
			for (int j = 0; j < i; j++)
			{
				if (!string.IsNullOrEmpty(text2))
				{
					text2 += "&";
				}
				text2 += array2[j];
			}
			string[] array3 = array2[i].Split(new char[1] { '=' });
			string text3 = array3[0];
			string string_ = GClass0.smethod_2(string_0) + "^" + text3.ToLower() + "^XSS";
			if (gclass0_0.method_32(string_))
			{
				continue;
			}
			gclass0_0.method_2(string_);
			if (!string.IsNullOrEmpty(text2))
			{
				text2 += "&";
			}
			text2 = text2 + text3 + "=" + GClass0.smethod_12(i, "<>%3c%3e%253c%253e");
			for (int k = i + 1; k < array2.Length; k++)
			{
				if (!string.IsNullOrEmpty(text2))
				{
					text2 += "&";
				}
				text2 += array2[k];
			}
			text = text + "?" + text2;
			string string_2 = gclass0_0.method_30(text, GEnum0.GET);
			string text4 = GClass0.smethod_16(string_2, i);
			if (!string.IsNullOrEmpty(text4) && text4.IndexOf("<>") >= 0)
			{
				string text5 = GClass0.smethod_6(text);
				string item = string_0 + "^^" + text3 + "^^GET^^" + text5 + "^^Cross Site Scripting(URL)";
				list.Add(item);
			}
		}
		return list.ToArray();
	}

	private void method_12(object object_0)
	{
		try
		{
			if (GClass0.genum4_0 == GEnum4.Stop)
			{
				Thread.CurrentThread.Abort();
			}
			string text = (string)object_0;
			if (gclass0_0.method_36(text))
			{
				return;
			}
			gclass0_0.method_0(GClass0.smethod_7(text));
			if (gclass0_0.method_23(text).Equals(".js"))
			{
				return;
			}
			if (text.IndexOf('=') > 0)
			{
				method_9("Checking SQL Injection: " + text);
				string[] array = gclass0_0.method_35(text, GEnum0.GET, "");
				string[] array2 = array;
				foreach (string string_ in array2)
				{
					method_4(string_);
				}
			}
			if (GClass0.genum4_0 == GEnum4.Stop)
			{
				Thread.CurrentThread.Abort();
			}
			if (WCRSetting.bool_4)
			{
				method_9("Checking URL XSS: " + text);
				string[] array3 = method_11(text);
				string[] array4 = array3;
				foreach (string text2 in array4)
				{
					if (!string.IsNullOrEmpty(text2))
					{
						method_4(text2);
					}
				}
			}
			if (GClass0.genum4_0 == GEnum4.Stop)
			{
				Thread.CurrentThread.Abort();
			}
			method_9("Checking Form Vul: " + text);
			string[] array5 = gclass0_0.method_40(text);
			string[] array6 = array5;
			foreach (string text3 in array6)
			{
				if (!string.IsNullOrEmpty(text3))
				{
					method_4(text3);
				}
			}
		}
		catch
		{
		}
	}

	private void method_13(string string_0, TreeNode treeNode_0)
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		if (GClass0.genum4_0 == GEnum4.Stop)
		{
			return;
		}
		if (treeNode_0.get_Nodes().get_Count() == 0)
		{
			string string_ = string_0 + treeNode_0.get_Text();
			if (method_8(string_))
			{
				list_0.Add(string_0 + treeNode_0.get_Text());
			}
			return;
		}
		list_0.Add(string_0 + treeNode_0.get_Text() + "/");
		foreach (TreeNode node in treeNode_0.get_Nodes())
		{
			TreeNode treeNode_ = node;
			method_13(string_0 + treeNode_0.get_Text() + "/", treeNode_);
		}
	}

	private void method_14()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		try
		{
			list_0.Clear();
			TreeView val = new TreeView();
			method_2(treeViewWVS, val);
			foreach (TreeNode node in val.get_Nodes())
			{
				TreeNode val2 = node;
				if (val2.get_Nodes().get_Count() == 0)
				{
					string text = gclass0_0.method_10() + val2.get_Text();
					if (method_8(text))
					{
						list_0.Add(text);
					}
				}
				else
				{
					method_13(gclass0_0.method_10(), val2);
				}
			}
			for (int i = 0; i < list_0.Count; i++)
			{
				if (GClass0.genum4_0 == GEnum4.Stop)
				{
					Thread.CurrentThread.Abort();
				}
				if (method_8(list_0[i]))
				{
					method_10(list_0[i]);
				}
			}
		}
		catch
		{
		}
	}

	private ListViewItem method_15(int int_1)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		if (!((Control)listViewWVS).get_InvokeRequired())
		{
			return listViewWVS.get_Items().get_Item(int_1);
		}
		Delegate8 @delegate = method_15;
		return (ListViewItem)((Control)this).Invoke((Delegate)@delegate, new object[1] { int_1 });
	}

	private XmlDocument method_16(XmlDocument xmlDocument_0, XmlElement xmlElement_0, TreeNode treeNode_0)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		XmlElement xmlElement = xmlDocument_0.CreateElement("DIR");
		xmlElement.SetAttribute("Value", treeNode_0.get_Text());
		foreach (TreeNode node in treeNode_0.get_Nodes())
		{
			TreeNode treeNode_ = node;
			xmlDocument_0 = method_16(xmlDocument_0, xmlElement, treeNode_);
		}
		xmlElement_0.AppendChild(xmlElement);
		return xmlDocument_0;
	}

	public XmlDocument method_17()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		XmlDocument xmlDocument = new XmlDocument();
		XmlNode newChild = xmlDocument.CreateXmlDeclaration("1.0", "utf-8", "");
		xmlDocument.AppendChild(newChild);
		XmlElement xmlElement = xmlDocument.CreateElement("ROOT");
		xmlDocument.AppendChild(xmlElement);
		XmlElement xmlElement2 = xmlDocument.CreateElement("SiteDirTree");
		xmlElement.AppendChild(xmlElement2);
		foreach (TreeNode node in treeViewWVS.get_Nodes())
		{
			TreeNode treeNode_ = node;
			xmlDocument = method_16(xmlDocument, xmlElement2, treeNode_);
		}
		return xmlDocument;
	}

	public XmlDocument method_18()
	{
		XmlDocument xmlDocument = new XmlDocument();
		XmlNode newChild = xmlDocument.CreateXmlDeclaration("1.0", "utf-8", "");
		xmlDocument.AppendChild(newChild);
		XmlElement xmlElement = xmlDocument.CreateElement("ROOT");
		xmlDocument.AppendChild(xmlElement);
		XmlElement xmlElement2 = xmlDocument.CreateElement("SiteVulList");
		xmlElement.AppendChild(xmlElement2);
		for (int i = 0; i < listViewWVS.get_Items().get_Count(); i++)
		{
			ListViewItem val = method_15(i);
			XmlElement xmlElement3 = xmlDocument.CreateElement("VulRow");
			XmlElement xmlElement4 = xmlDocument.CreateElement("ReferURL");
			xmlElement4.InnerText = val.get_SubItems().get_Item(0).get_Text();
			xmlElement3.AppendChild(xmlElement4);
			xmlElement4 = xmlDocument.CreateElement("Parameter");
			xmlElement4.InnerText = val.get_SubItems().get_Item(1).get_Text();
			xmlElement3.AppendChild(xmlElement4);
			xmlElement4 = xmlDocument.CreateElement("Type");
			xmlElement4.InnerText = val.get_SubItems().get_Item(2).get_Text();
			xmlElement3.AppendChild(xmlElement4);
			xmlElement4 = xmlDocument.CreateElement("KWordActionURL");
			xmlElement4.InnerText = val.get_SubItems().get_Item(3).get_Text();
			xmlElement3.AppendChild(xmlElement4);
			xmlElement4 = xmlDocument.CreateElement("Vulnerability");
			xmlElement4.InnerText = val.get_SubItems().get_Item(4).get_Text();
			xmlElement3.AppendChild(xmlElement4);
			xmlElement2.AppendChild(xmlElement3);
		}
		return xmlDocument;
	}

	private void method_19(string string_0)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			XmlDocument xmlDocument = method_18();
			int num = 1;
			while (File.Exists(Application.get_StartupPath() + "\\" + string_0))
			{
				string_0 = num + "_" + string_0;
				num++;
			}
			xmlDocument.Save(string_0);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private string method_20(XmlDocument xmlDocument_0)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		string text = gclass0_0.method_11() + "_Scan_Report_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".html";
		StringWriter stringWriter = new StringWriter();
		try
		{
			HtmlTextWriter val = new HtmlTextWriter((TextWriter)stringWriter);
			val.RenderBeginTag((HtmlTextWriterTag)43);
			val.RenderBeginTag((HtmlTextWriterTag)41);
			((TextWriter)(object)val).Write("<meta http-equiv=\"content-type\" content=\"text/html; charset=UTF-8\">");
			((TextWriter)(object)val).Write("<style>table{table-layout:fixed;overflow:hidden;}</style>");
			val.RenderBeginTag((HtmlTextWriterTag)89);
			((TextWriter)(object)val).Write("Scan Report");
			val.RenderEndTag();
			val.RenderEndTag();
			val.RenderBeginTag((HtmlTextWriterTag)12);
			val.RenderBeginTag((HtmlTextWriterTag)16);
			((TextWriter)(object)val).Write("<br><br><br><br><br><br><br><br>");
			val.RenderBeginTag((HtmlTextWriterTag)35);
			((TextWriter)(object)val).Write(gclass0_0.method_11() + " Scan Report<br>");
			val.RenderEndTag();
			((TextWriter)(object)val).Write("<br><br><br><br><br><br><br><br>Created By WebCruiser - Web Vulnerability Scanner<br>" + DateTime.Now.ToString("yyyy-MM-dd"));
			((TextWriter)(object)val).Write("<div style=\"page-break-after:always\">&nbsp;</div>");
			XmlNodeList xmlNodeList = xmlDocument_0.SelectNodes("//ROOT/SiteVulList/VulRow");
			if (xmlNodeList.Count > 0)
			{
				val.RenderBeginTag((HtmlTextWriterTag)36);
				((TextWriter)(object)val).Write("Vulnerability Result");
				val.RenderEndTag();
				for (int i = 0; i < xmlNodeList.Count; i++)
				{
					val.AddAttribute("border", "1");
					val.AddAttribute("width", "640");
					val.AddAttribute("cellspacing", "0");
					val.AddAttribute("bordercolordark", "009099");
					val.RenderBeginTag((HtmlTextWriterTag)82);
					((TextWriter)(object)val).Write("<tr><td width=\"150\">No.</td><td>" + (i + 1) + "</td></tr>");
					XmlNode xmlNode = xmlNodeList[i];
					for (int j = 0; j < xmlNode.ChildNodes.Count; j++)
					{
						((TextWriter)(object)val).Write("<tr><td width=\"150\">");
						((TextWriter)(object)val).Write(xmlNode.ChildNodes[j]!.Name);
						((TextWriter)(object)val).Write("</td><td>");
						((TextWriter)(object)val).Write(xmlNode.ChildNodes[j]!.InnerText.Replace("<>", "&lt;&gt;"));
						((TextWriter)(object)val).Write("</td></tr>");
					}
					val.RenderEndTag();
					((TextWriter)(object)val).Write("<br>");
				}
			}
			val.RenderEndTag();
			val.RenderEndTag();
			val.RenderEndTag();
			File.WriteAllText(text, stringWriter.ToString());
			return text;
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
			File.WriteAllText(text, stringWriter.ToString());
			return text;
		}
	}

	private void method_21(object object_0)
	{
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			method_22();
			bool flag = false;
			while (!flag)
			{
				Thread.Sleep(1000);
				if (DateTime.Now.Subtract(gclass0_0.dateTime_2).Seconds > 20 && gclass0_0.method_12() == 0)
				{
					flag = true;
				}
			}
			if (bool_0)
			{
				GClass0.int_2--;
			}
			method_19(gclass0_0.method_11() + "_Vuls_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".xml");
			XmlDocument xmlDocument_ = method_18();
			method_20(xmlDocument_);
			formMain_0.method_38(this);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void method_22()
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		if (!bool_0)
		{
			gclass0_0.method_9(formMain_0.method_2());
		}
		if (string.IsNullOrEmpty(gclass0_0.method_8()))
		{
			MessageBox.Show("Null URL!", "Notice", (MessageBoxButtons)0, (MessageBoxIcon)48);
			return;
		}
		method_3(gclass0_0.method_8());
		method_9("Scanning...");
		ThreadPool.QueueUserWorkItem(method_6);
		ThreadPool.QueueUserWorkItem(method_7);
		ThreadPool.QueueUserWorkItem(method_10, gclass0_0.method_8());
		Thread thread = new Thread((ThreadStart)delegate
		{
			for (int i = 0; i < WCRSetting.ScanDepth; i++)
			{
				while (gclass0_0.method_12() > 0)
				{
					Thread.Sleep(200);
				}
				if (GClass0.genum4_0 == GEnum4.Stop)
				{
					break;
				}
				if (i == 0)
				{
					ThreadPool.QueueUserWorkItem(method_12, gclass0_0.method_8());
				}
				int_0 = i + 1;
				Thread.Sleep(1000);
				method_14();
				if (GClass0.genum4_0 == GEnum4.Stop)
				{
					break;
				}
			}
		});
		thread.Start();
	}

	private void toolStripWVScan_Click(object sender, EventArgs e)
	{
		method_23();
	}

	public void method_23()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Invalid comparison between Unknown and I4
		gclass0_0.method_9(formMain_0.method_2());
		if (string.IsNullOrEmpty(gclass0_0.method_8()))
		{
			MessageBox.Show("Please input the URL!", "Notice", (MessageBoxButtons)0, (MessageBoxIcon)64);
			formMain_0.method_45();
		}
		else if ((int)MessageBox.Show("* Software Disclaimer: \r\n* Authorization must be obtained from the web application owner;\r\n* This program will try to get each link and post any data when scanning;\r\n* Backup the database before scanning so as to avoid disaster;\r\n* Using this software at your own risk.\r\n\r\n* Login as a legal user will help you find vulnerabilities to the most extent.\r\n* But not login is better if you intend to scan the login/authentication page.\r\n* Continue?\r\n", "Confirm", (MessageBoxButtons)1, (MessageBoxIcon)64) != 2)
		{
			method_22();
		}
	}

	private void toolStripURLScan_Click(object sender, EventArgs e)
	{
		method_24();
	}

	public void method_24()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrEmpty(gclass0_0.method_8()))
		{
			MessageBox.Show("Please input the URL!", "Notice", (MessageBoxButtons)0, (MessageBoxIcon)64);
			formMain_0.method_45();
		}
		else
		{
			ThreadPool.QueueUserWorkItem(method_12, gclass0_0.method_8());
			method_9("Scanning...");
			MessageBox.Show("* Scanning Has Been Launched.\r\n* The Result Will List In The Vulnerabilities ListView.", "Information", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
	}

	private void method_25(object object_0)
	{
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		string text = (string)object_0;
		string[] separator = new string[1] { "^^" };
		string[] array = text.Split(separator, StringSplitOptions.None);
		for (int i = 0; i < array.Length; i++)
		{
			string text2 = array[i].ToString().Trim();
			if (!string.IsNullOrEmpty(text2) && text2.IndexOf("http") >= 0)
			{
				while (GClass0.int_2 >= WCRSetting.MultiSitesNum)
				{
					Thread.Sleep(1000);
				}
				GClass0 gclass0_ = new GClass0(text2);
				FormScanner formScanner = new FormScanner(formMain_0, gclass0_);
				MethodInvoker val = new MethodInvoker(((Control)formScanner).Show);
				((Control)this).Invoke((Delegate)(object)val, (object[])null);
			}
		}
	}

	private void toolStripMultiScan_Click(object sender, EventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Invalid comparison between Unknown and I4
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Invalid comparison between Unknown and I4
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if ((int)MessageBox.Show("* Software Disclaimer: \r\n* Authorization must be obtained from the web application owner;\r\n* This program will try to get each link and post any data when scanning;\r\n* Backup the database before scanning so as to avoid disaster;\r\n* Using this software at your own risk. \r\n\r\n* Multi-Site scanning will read the sites list from a text file.\r\n* Continue?\r\n", "Confirm", (MessageBoxButtons)1, (MessageBoxIcon)64) == 2)
			{
				return;
			}
			OpenFileDialog val = new OpenFileDialog();
			((FileDialog)val).set_Filter("Text File(*.txt)|*.txt");
			((FileDialog)val).set_FileName("SiteList.txt");
			((FileDialog)val).set_InitialDirectory(Application.get_StartupPath());
			DialogResult val2 = ((CommonDialog)val).ShowDialog();
			if ((int)val2 != 1)
			{
				return;
			}
			string fileName = ((FileDialog)val).get_FileName();
			((Component)(object)val).Dispose();
			StreamReader streamReader = new StreamReader(fileName);
			string text = "";
			string text2 = "";
			while ((text = streamReader.ReadLine()) != null)
			{
				if (!string.IsNullOrEmpty(text))
				{
					text2 = ((!string.IsNullOrEmpty(text2)) ? (text2 + "^^" + text) : (text2 + text));
				}
			}
			streamReader.Close();
			ThreadPool.QueueUserWorkItem(method_25, text2);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void toolStripClearWVS_Click(object sender, EventArgs e)
	{
		treeViewWVS.get_Nodes().Clear();
		listViewWVS.get_Items().Clear();
		gclass0_0.method_5();
	}

	private void method_26(XmlNode xmlNode_0, TreeNode treeNode_0)
	{
		foreach (XmlNode childNode in xmlNode_0.ChildNodes)
		{
			TreeNode treeNode_ = treeNode_0.get_Nodes().Add(childNode.Attributes!["Value"]!.Value);
			if (childNode.ChildNodes.Count > 0)
			{
				method_26(childNode, treeNode_);
			}
		}
	}

	public void method_27(XmlDocument xmlDocument_0)
	{
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		XmlNodeList xmlNodeList = xmlDocument_0.SelectNodes("//ROOT/SiteDirTree/DIR");
		foreach (XmlNode item in xmlNodeList)
		{
			TreeNode treeNode_ = treeViewWVS.get_Nodes().Add(item.Attributes!["Value"]!.Value);
			if (item.ChildNodes.Count > 0)
			{
				method_26(item, treeNode_);
			}
		}
		treeViewWVS.ExpandAll();
		XmlNodeList xmlNodeList2 = xmlDocument_0.SelectNodes("//ROOT/SiteVulList/VulRow");
		listViewWVS.get_Items().Clear();
		foreach (XmlNode item2 in xmlNodeList2)
		{
			ListViewItem val = new ListViewItem(item2.ChildNodes[0]!.InnerText);
			val.get_SubItems().Add(item2.ChildNodes[1]!.InnerText);
			val.get_SubItems().Add(item2.ChildNodes[2]!.InnerText);
			val.get_SubItems().Add(item2.ChildNodes[3]!.InnerText);
			val.get_SubItems().Add(item2.ChildNodes[4]!.InnerText);
			val.set_ImageKey("vul.png");
			listViewWVS.get_Items().Add(val);
		}
	}

	private void toolStripImpWVS_Click(object sender, EventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Invalid comparison between Unknown and I4
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (listViewWVS.get_Items().get_Count() > 0)
			{
				if ((int)MessageBox.Show("* Import Vuls Will Clear Current Vuls Information.\r\n* Continue?\r\n", "Confirm", (MessageBoxButtons)1, (MessageBoxIcon)64) == 2)
				{
					return;
				}
				listViewWVS.get_Items().Clear();
			}
			OpenFileDialog val = new OpenFileDialog();
			((FileDialog)val).set_Filter("XML File(*.xml)|*.xml");
			((FileDialog)val).set_InitialDirectory(Application.get_StartupPath());
			DialogResult val2 = ((CommonDialog)val).ShowDialog();
			if ((int)val2 == 1)
			{
				string fileName = ((FileDialog)val).get_FileName();
				((Component)(object)val).Dispose();
				if (!string.IsNullOrEmpty(fileName))
				{
					XmlDocument xmlDocument = new XmlDocument();
					xmlDocument.Load(fileName);
					method_27(xmlDocument);
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void toolStripExpWVS_Click(object sender, EventArgs e)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Invalid comparison between Unknown and I4
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (listViewWVS.get_Items().get_Count() >= 1)
			{
				string fileName = gclass0_0.method_11() + "_Vuls_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".xml";
				SaveFileDialog val = new SaveFileDialog();
				((FileDialog)val).set_Filter("XML File(*.xml) | *.xml");
				((FileDialog)val).set_InitialDirectory(Application.get_StartupPath());
				((FileDialog)val).set_FileName(fileName);
				DialogResult val2 = ((CommonDialog)val).ShowDialog();
				if ((int)val2 == 1)
				{
					fileName = ((FileDialog)val).get_FileName();
					((Component)(object)val).Dispose();
					method_19(fileName);
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void treeViewWVS_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		Point point = new Point(((MouseEventArgs)e).get_X(), ((MouseEventArgs)e).get_Y());
		TreeNode nodeAt = treeViewWVS.GetNodeAt(point);
		treeViewWVS.set_SelectedNode(nodeAt);
		ContextMenuStrip val = new ContextMenuStrip();
		((ToolStrip)val).get_Items().Add("Copy To ClipBoard", (Image)null, (EventHandler)method_28);
		((Control)treeViewWVS).set_ContextMenuStrip(val);
	}

	private void method_28(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string text;
			if ((text = ((ToolStripItem)(ToolStripMenuItem)sender).get_Text()) != null && text == "Copy To ClipBoard")
			{
				Clipboard.SetText(treeViewWVS.get_SelectedNode().get_Text());
			}
		}
		catch
		{
		}
	}

	private void listViewWVS_MouseClick(object sender, MouseEventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		if (listViewWVS.get_SelectedItems().get_Count() >= 1)
		{
			ContextMenuStrip val = new ContextMenuStrip();
			((ToolStrip)val).get_Items().Add("Copy URL To ClipBoard", (Image)null, (EventHandler)method_29);
			string text = listViewWVS.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(4)
				.get_Text();
			if (text.IndexOf("SQL INJECTION") >= 0)
			{
				((ToolStrip)val).get_Items().Add("SQL INJECTION POC", (Image)null, (EventHandler)method_29);
			}
			else if (text.IndexOf("XPath INJECTION") >= 0)
			{
				((ToolStrip)val).get_Items().Add("XPath INJECTION POC", (Image)null, (EventHandler)method_29);
			}
			else if (text.IndexOf("Cross Site Scripting(URL)") >= 0)
			{
				((ToolStrip)val).get_Items().Add("Cross Site Scripting(URL) POC", (Image)null, (EventHandler)method_29);
			}
			else if (text.IndexOf("Cross Site Scripting(Form)") >= 0)
			{
				((ToolStrip)val).get_Items().Add("Cross Site Scripting(Form) POC", (Image)null, (EventHandler)method_29);
			}
			((ToolStrip)val).get_Items().Add("Delete Vulnerability", (Image)null, (EventHandler)method_29);
			((Control)listViewWVS).set_ContextMenuStrip(val);
		}
	}

	private void method_29(object sender, EventArgs e)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string text = listViewWVS.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(1)
				.get_Text();
			string text2 = listViewWVS.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(4)
				.get_Text();
			switch (((ToolStripItem)(ToolStripMenuItem)sender).get_Text())
			{
			case "Cross Site Scripting(URL) POC":
			case "Cross Site Scripting(Form) POC":
			{
				string text5 = listViewWVS.get_SelectedItems().get_Item(0).get_Text();
				string text6 = listViewWVS.get_SelectedItems().get_Item(0).get_SubItems()
					.get_Item(3)
					.get_Text();
				formMain_0.method_36(text5, text6);
				formMain_0.method_24("XSS");
				break;
			}
			case "XPath INJECTION POC":
			{
				string text7 = listViewWVS.get_SelectedItems().get_Item(0).get_SubItems()
					.get_Item(3)
					.get_Text();
				string text8 = listViewWVS.get_SelectedItems().get_Item(0).get_Text();
				formMain_0.method_24("WebBrowser");
				formMain_0.method_35(text8, text7, text);
				break;
			}
			case "Delete Vulnerability":
				listViewWVS.get_SelectedItems().get_Item(0).Remove();
				break;
			case "Copy URL To ClipBoard":
				Clipboard.SetText(listViewWVS.get_SelectedItems().get_Item(0).get_Text());
				break;
			case "SQL INJECTION POC":
			{
				string text3 = listViewWVS.get_SelectedItems().get_Item(0).get_Text();
				if (text3.IndexOf('^') > 0)
				{
					string[] array = GClass0.smethod_1(text3, '^');
					text3 = array[0];
					formMain_0.method_17(array[1]);
					if (text2.IndexOf("POST") >= 0)
					{
						formMain_0.method_1(GEnum0.POST);
					}
					else if (text2.IndexOf("COOKIE") >= 0)
					{
						formMain_0.method_1(GEnum0.COOKIE);
					}
				}
				else
				{
					formMain_0.method_1(GEnum0.GET);
				}
				formMain_0.method_3(text3);
				string text4 = listViewWVS.get_SelectedItems().get_Item(0).get_SubItems()
					.get_Item(2)
					.get_Text();
				if (text4.Equals("Integer"))
				{
					gclass0_0.method_19(GEnum2.Integer);
					formMain_0.method_33(GEnum2.Integer);
				}
				else if (text4.Equals("String"))
				{
					gclass0_0.method_19(GEnum2.String);
					formMain_0.method_33(GEnum2.String);
				}
				else if (text4.Equals("Search"))
				{
					gclass0_0.method_19(GEnum2.Search);
					formMain_0.method_33(GEnum2.Search);
				}
				gclass0_0.method_4(listViewWVS.get_SelectedItems().get_Item(0).get_SubItems()
					.get_Item(3)
					.get_Text());
				formMain_0.method_34(gclass0_0.method_3());
				formMain_0.method_24("SQL");
				break;
			}
			}
		}
		catch
		{
		}
	}

	private void FormScanner_Resize(object sender, EventArgs e)
	{
		((ToolStripItem)lblProgress).set_Width(((Control)toolStripScanner).get_Width() - 150);
	}

	public void method_30(string string_0)
	{
		if (!((Control)statusScanner).get_InvokeRequired())
		{
			((ToolStripItem)lblThreadNum).set_Text(string_0);
			((Control)statusScanner).Refresh();
		}
		else
		{
			Delegate6 @delegate = method_30;
			((Control)this).Invoke((Delegate)@delegate, new object[1] { string_0 });
		}
	}

	private void method_31()
	{
		method_30("HTTP Thread: " + gclass0_0.method_12());
		DateTime now = DateTime.Now;
		TimeSpan timeSpan = now.Subtract(GClass0.dateTime_3);
		timeSpan = now.Subtract(gclass0_0.dateTime_2);
		if (timeSpan.Seconds > 20 && gclass0_0.method_12() == 0)
		{
			method_9("Done");
		}
		if (timeSpan.Seconds > 30 && gclass0_0.method_12() > 0)
		{
			gclass0_0.method_13(0);
		}
	}

	private void timer_0_Elapsed(object sender, EventArgs e)
	{
		method_31();
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
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected O, but got Unknown
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected O, but got Unknown
		//IL_043f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected O, but got Unknown
		//IL_04e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Expected O, but got Unknown
		//IL_0589: Unknown result type (might be due to invalid IL or missing references)
		//IL_0593: Expected O, but got Unknown
		//IL_062e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0638: Expected O, but got Unknown
		//IL_06d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dd: Expected O, but got Unknown
		//IL_0778: Unknown result type (might be due to invalid IL or missing references)
		//IL_0782: Expected O, but got Unknown
		//IL_0aee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af8: Expected O, but got Unknown
		//IL_0b6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b79: Expected O, but got Unknown
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormScanner));
		splitScanner = new SplitContainer();
		treeViewWVS = new TreeView();
		imageList_0 = new ImageList(icontainer_0);
		toolStripScanner = new ToolStrip();
		toolStripSeparator7 = new ToolStripSeparator();
		toolStripWVScan = new ToolStripButton();
		toolStripSeparator1 = new ToolStripSeparator();
		toolStripURLScan = new ToolStripButton();
		toolStripSeparator2 = new ToolStripSeparator();
		toolStripMultiScan = new ToolStripButton();
		toolStripSeparator3 = new ToolStripSeparator();
		toolStripClearWVS = new ToolStripButton();
		toolStripSeparator4 = new ToolStripSeparator();
		toolStripImpWVS = new ToolStripButton();
		toolStripSeparator5 = new ToolStripSeparator();
		toolStripExpWVS = new ToolStripButton();
		toolStripSeparator6 = new ToolStripSeparator();
		statusScanner = new StatusStrip();
		lblProgress = new ToolStripStatusLabel();
		toolStripStatusLabel1 = new ToolStripStatusLabel();
		lblThreadNum = new ToolStripStatusLabel();
		columnHeader_0 = new ColumnHeader();
		columnHeader_1 = new ColumnHeader();
		columnHeader_2 = new ColumnHeader();
		columnHeader_3 = new ColumnHeader();
		columnHeader_4 = new ColumnHeader();
		listViewWVS = new ListView();
		((Control)splitScanner.get_Panel1()).SuspendLayout();
		((Control)splitScanner.get_Panel2()).SuspendLayout();
		((Control)splitScanner).SuspendLayout();
		((Control)toolStripScanner).SuspendLayout();
		((Control)statusScanner).SuspendLayout();
		((Control)this).SuspendLayout();
		splitScanner.set_Dock((DockStyle)5);
		((Control)splitScanner).set_Location(new Point(0, 25));
		((Control)splitScanner).set_Name("splitScanner");
		splitScanner.set_Orientation((Orientation)0);
		((Control)splitScanner.get_Panel1()).get_Controls().Add((Control)(object)treeViewWVS);
		((Control)splitScanner.get_Panel2()).get_Controls().Add((Control)(object)listViewWVS);
		((Control)splitScanner).set_Size(new Size(642, 361));
		splitScanner.set_SplitterDistance(175);
		((Control)splitScanner).set_TabIndex(0);
		((Control)treeViewWVS).set_Dock((DockStyle)5);
		treeViewWVS.set_FullRowSelect(true);
		((Control)treeViewWVS).set_Location(new Point(0, 0));
		((Control)treeViewWVS).set_Name("treeViewWVS");
		((Control)treeViewWVS).set_Size(new Size(642, 175));
		((Control)treeViewWVS).set_TabIndex(5);
		treeViewWVS.add_NodeMouseClick(new TreeNodeMouseClickEventHandler(treeViewWVS_NodeMouseClick));
		imageList_0.set_ImageStream((ImageListStreamer)componentResourceManager.GetObject("ImageListScanner.ImageStream"));
		imageList_0.set_TransparentColor(Color.Transparent);
		imageList_0.get_Images().SetKeyName(0, "vul.png");
		toolStripScanner.set_BackColor(SystemColors.ButtonFace);
		toolStripScanner.set_GripStyle((ToolStripGripStyle)0);
		toolStripScanner.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[13]
		{
			(ToolStripItem)toolStripSeparator7,
			(ToolStripItem)toolStripWVScan,
			(ToolStripItem)toolStripSeparator1,
			(ToolStripItem)toolStripURLScan,
			(ToolStripItem)toolStripSeparator2,
			(ToolStripItem)toolStripMultiScan,
			(ToolStripItem)toolStripSeparator3,
			(ToolStripItem)toolStripClearWVS,
			(ToolStripItem)toolStripSeparator4,
			(ToolStripItem)toolStripImpWVS,
			(ToolStripItem)toolStripSeparator5,
			(ToolStripItem)toolStripExpWVS,
			(ToolStripItem)toolStripSeparator6
		});
		toolStripScanner.set_LayoutStyle((ToolStripLayoutStyle)1);
		((Control)toolStripScanner).set_Location(new Point(0, 0));
		((Control)toolStripScanner).set_Name("toolStripScanner");
		((Control)toolStripScanner).set_Size(new Size(642, 25));
		((Control)toolStripScanner).set_TabIndex(1);
		((Control)toolStripScanner).set_Text("toolStrip1");
		((ToolStripItem)toolStripSeparator7).set_Name("toolStripSeparator7");
		((ToolStripItem)toolStripSeparator7).set_Size(new Size(6, 25));
		((ToolStripItem)toolStripWVScan).set_DisplayStyle((ToolStripItemDisplayStyle)1);
		((ToolStripItem)toolStripWVScan).set_Image((Image)componentResourceManager.GetObject("toolStripWVScan.Image"));
		((ToolStripItem)toolStripWVScan).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)toolStripWVScan).set_Name("toolStripWVScan");
		((ToolStripItem)toolStripWVScan).set_Size(new Size(111, 22));
		((ToolStripItem)toolStripWVScan).set_Text("Scan Current Site");
		((ToolStripItem)toolStripWVScan).add_Click((EventHandler)toolStripWVScan_Click);
		((ToolStripItem)toolStripSeparator1).set_Name("toolStripSeparator1");
		((ToolStripItem)toolStripSeparator1).set_Size(new Size(6, 25));
		((ToolStripItem)toolStripURLScan).set_DisplayStyle((ToolStripItemDisplayStyle)1);
		((ToolStripItem)toolStripURLScan).set_Image((Image)componentResourceManager.GetObject("toolStripURLScan.Image"));
		((ToolStripItem)toolStripURLScan).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)toolStripURLScan).set_Name("toolStripURLScan");
		((ToolStripItem)toolStripURLScan).set_Size(new Size(105, 22));
		((ToolStripItem)toolStripURLScan).set_Text("Scan Current URL");
		((ToolStripItem)toolStripURLScan).add_Click((EventHandler)toolStripURLScan_Click);
		((ToolStripItem)toolStripSeparator2).set_Name("toolStripSeparator2");
		((ToolStripItem)toolStripSeparator2).set_Size(new Size(6, 25));
		((ToolStripItem)toolStripMultiScan).set_DisplayStyle((ToolStripItemDisplayStyle)1);
		((ToolStripItem)toolStripMultiScan).set_Image((Image)componentResourceManager.GetObject("toolStripMultiScan.Image"));
		((ToolStripItem)toolStripMultiScan).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)toolStripMultiScan).set_Name("toolStripMultiScan");
		((ToolStripItem)toolStripMultiScan).set_Size(new Size(99, 22));
		((ToolStripItem)toolStripMultiScan).set_Text("Scan Multi-Site");
		((ToolStripItem)toolStripMultiScan).add_Click((EventHandler)toolStripMultiScan_Click);
		((ToolStripItem)toolStripSeparator3).set_Name("toolStripSeparator3");
		((ToolStripItem)toolStripSeparator3).set_Size(new Size(6, 25));
		((ToolStripItem)toolStripClearWVS).set_DisplayStyle((ToolStripItemDisplayStyle)1);
		((ToolStripItem)toolStripClearWVS).set_Image((Image)componentResourceManager.GetObject("toolStripClearWVS.Image"));
		((ToolStripItem)toolStripClearWVS).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)toolStripClearWVS).set_Name("toolStripClearWVS");
		((ToolStripItem)toolStripClearWVS).set_Size(new Size(123, 22));
		((ToolStripItem)toolStripClearWVS).set_Text("Reset/Clear Scanner");
		((ToolStripItem)toolStripClearWVS).add_Click((EventHandler)toolStripClearWVS_Click);
		((ToolStripItem)toolStripSeparator4).set_Name("toolStripSeparator4");
		((ToolStripItem)toolStripSeparator4).set_Size(new Size(6, 25));
		((ToolStripItem)toolStripImpWVS).set_DisplayStyle((ToolStripItemDisplayStyle)1);
		((ToolStripItem)toolStripImpWVS).set_Image((Image)componentResourceManager.GetObject("toolStripImpWVS.Image"));
		((ToolStripItem)toolStripImpWVS).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)toolStripImpWVS).set_Name("toolStripImpWVS");
		((ToolStripItem)toolStripImpWVS).set_Size(new Size(45, 22));
		((ToolStripItem)toolStripImpWVS).set_Text("Import");
		((ToolStripItem)toolStripImpWVS).add_Click((EventHandler)toolStripImpWVS_Click);
		((ToolStripItem)toolStripSeparator5).set_Name("toolStripSeparator5");
		((ToolStripItem)toolStripSeparator5).set_Size(new Size(6, 25));
		((ToolStripItem)toolStripExpWVS).set_DisplayStyle((ToolStripItemDisplayStyle)1);
		((ToolStripItem)toolStripExpWVS).set_Image((Image)componentResourceManager.GetObject("toolStripExpWVS.Image"));
		((ToolStripItem)toolStripExpWVS).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)toolStripExpWVS).set_Name("toolStripExpWVS");
		((ToolStripItem)toolStripExpWVS).set_Size(new Size(45, 22));
		((ToolStripItem)toolStripExpWVS).set_Text("Export");
		((ToolStripItem)toolStripExpWVS).add_Click((EventHandler)toolStripExpWVS_Click);
		((ToolStripItem)toolStripSeparator6).set_Name("toolStripSeparator6");
		((ToolStripItem)toolStripSeparator6).set_Size(new Size(6, 25));
		((ToolStrip)statusScanner).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)lblProgress,
			(ToolStripItem)toolStripStatusLabel1,
			(ToolStripItem)lblThreadNum
		});
		((Control)statusScanner).set_Location(new Point(0, 364));
		((Control)statusScanner).set_Name("statusScanner");
		((Control)statusScanner).set_Size(new Size(642, 22));
		((Control)statusScanner).set_TabIndex(2);
		((Control)statusScanner).set_Text("statusStrip1");
		((ToolStripItem)lblProgress).set_AutoSize(false);
		((ToolStripItem)lblProgress).set_Name("lblProgress");
		((ToolStripItem)lblProgress).set_Size(new Size(460, 17));
		((ToolStripItem)lblProgress).set_Text("Done");
		((ToolStripItem)lblProgress).set_TextAlign((ContentAlignment)16);
		((ToolStripItem)toolStripStatusLabel1).set_ForeColor(SystemColors.ButtonShadow);
		((ToolStripItem)toolStripStatusLabel1).set_Name("toolStripStatusLabel1");
		((ToolStripItem)toolStripStatusLabel1).set_Size(new Size(11, 17));
		((ToolStripItem)toolStripStatusLabel1).set_Text("|");
		((ToolStripItem)lblThreadNum).set_AutoSize(false);
		((ToolStripItem)lblThreadNum).set_Name("lblThreadNum");
		((ToolStripItem)lblThreadNum).set_Size(new Size(125, 17));
		((ToolStripItem)lblThreadNum).set_Text("HTTP Thread:");
		((ToolStripItem)lblThreadNum).set_TextAlign((ContentAlignment)16);
		columnHeader_0.set_Text("URL / Refer URL");
		columnHeader_0.set_Width(270);
		columnHeader_1.set_Text("Parameter");
		columnHeader_1.set_Width(78);
		columnHeader_2.set_Text("Type");
		columnHeader_2.set_Width(59);
		columnHeader_3.set_Text("KeyWord/ActionURL");
		columnHeader_3.set_Width(130);
		columnHeader_4.set_Text("Vulnerability");
		columnHeader_4.set_Width(170);
		listViewWVS.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[5] { columnHeader_0, columnHeader_1, columnHeader_2, columnHeader_3, columnHeader_4 });
		((Control)listViewWVS).set_Dock((DockStyle)5);
		listViewWVS.set_FullRowSelect(true);
		((Control)listViewWVS).set_Location(new Point(0, 0));
		listViewWVS.set_MultiSelect(false);
		((Control)listViewWVS).set_Name("listViewWVS");
		((Control)listViewWVS).set_Size(new Size(642, 182));
		listViewWVS.set_SmallImageList(imageList_0);
		((Control)listViewWVS).set_TabIndex(3);
		listViewWVS.set_UseCompatibleStateImageBehavior(false);
		listViewWVS.set_View((View)1);
		((Control)listViewWVS).add_MouseClick(new MouseEventHandler(listViewWVS_MouseClick));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(642, 386));
		((Control)this).get_Controls().Add((Control)(object)splitScanner);
		((Control)this).get_Controls().Add((Control)(object)toolStripScanner);
		((Control)this).get_Controls().Add((Control)(object)statusScanner);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("FormScanner");
		((Control)this).set_Text("FormScanner");
		((Control)this).add_Resize((EventHandler)FormScanner_Resize);
		((Control)splitScanner.get_Panel1()).ResumeLayout(false);
		((Control)splitScanner.get_Panel2()).ResumeLayout(false);
		((Control)splitScanner).ResumeLayout(false);
		((Control)toolStripScanner).ResumeLayout(false);
		((Control)toolStripScanner).PerformLayout();
		((Control)statusScanner).ResumeLayout(false);
		((Control)statusScanner).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[CompilerGenerated]
	private void method_32()
	{
		for (int i = 0; i < WCRSetting.ScanDepth; i++)
		{
			while (gclass0_0.method_12() > 0)
			{
				Thread.Sleep(200);
			}
			if (GClass0.genum4_0 == GEnum4.Stop)
			{
				break;
			}
			if (i == 0)
			{
				ThreadPool.QueueUserWorkItem(method_12, gclass0_0.method_8());
			}
			int_0 = i + 1;
			Thread.Sleep(1000);
			method_14();
			if (GClass0.genum4_0 == GEnum4.Stop)
			{
				break;
			}
		}
	}
}
