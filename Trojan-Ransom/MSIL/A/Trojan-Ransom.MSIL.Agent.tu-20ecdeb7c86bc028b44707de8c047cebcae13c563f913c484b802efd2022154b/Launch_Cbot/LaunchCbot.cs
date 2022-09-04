using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using HtmlAgilityPack;
using denetim;

namespace Launch_Cbot;

public class LaunchCbot : Form
{
	private int indir = 0;

	private int say = 0;

	private IContainer components = null;

	public LaunchCbot()
	{
		InitializeComponent();
	}

	private void LaunchCbot_Load(object sender, EventArgs e)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		string text = acikmi();
		LaunchCbot launchCbot = new LaunchCbot();
		((Control)launchCbot).Hide();
		((Control)this).Hide();
		if (text == "kapali")
		{
			cntragi();
		}
		else if (indir == 0)
		{
			MessageBox.Show("program zaten açık.! Güncelleme sırasında olabilir.Bekleyiniz.", "Crzyyzlm - Cbot");
			Application.Exit();
		}
	}

	private bool nettest()
	{
		try
		{
			Ping ping = new Ping();
			PingReply pingReply = ping.Send(IPAddress.Parse("208.69.34.231"), 3000);
			if (pingReply.Status == IPStatus.Success)
			{
				return true;
			}
			return false;
		}
		catch
		{
			return false;
		}
	}

	protected void cntr()
	{
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		if (File.Exists("control.dll"))
		{
			FileVersionInfo.GetVersionInfo(Path.Combine("control.dll"));
			FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo("control.dll");
			do
			{
				switch (control_active())
				{
				default:
					return;
				case "error":
					break;
				case "active":
				{
					string text = control_version();
					if (text != versionInfo.FileVersion)
					{
						dwncontrol();
					}
					else
					{
						open();
					}
					return;
				}
				case "deactive":
					MessageBox.Show("Sunucumuzdaki bakım dolayısıyla program geçici bir süre kapatılmıştır.", "Crzyyzlm - Sunucu Bakımı.");
					Application.Exit();
					return;
				}
				say++;
			}
			while (say < 3);
			MessageBox.Show("İnternet bağlantınızda zayıflık veya kopukluk durumu oldu ve bu nedenle bağlantı kurulamadı. Eğer kurulum esnasında olduysa LaunchCbot.exe dışındakileri silin ve LaunchCbot.exe'yi çalıştırın. #550", "Crzyyzlm - Bağlantı hatası.");
			Process.Start("http://www.crzyyzlm.com");
			Process.Start("https://www.facebook.com/crzyyzlm");
			Application.Exit();
		}
		else
		{
			dwncontrol();
		}
	}

	private string acikmi()
	{
		string result = "kapali";
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(executingAssembly.Location);
		string productName = versionInfo.ProductName;
		Process currentProcess = Process.GetCurrentProcess();
		Process[] processesByName = Process.GetProcessesByName(productName);
		Process[] array = processesByName;
		foreach (Process process in array)
		{
			if (process.Id.ToString() != currentProcess.Id.ToString())
			{
				result = "acik";
			}
		}
		return result;
	}

	private void dwncontrol()
	{
		indir = 1;
		WebClient webClient = new WebClient();
		webClient.DownloadFileCompleted += Completedcontrol;
		webClient.DownloadFileAsync(new Uri("http://bot.crzyyzlm.com/control.dll"), "control.dll");
	}

	private void Completedcontrol(object sender, AsyncCompletedEventArgs e)
	{
		Process.Start(Application.get_ExecutablePath());
		((Form)this).Close();
	}

	protected void cntragi()
	{
		if (File.Exists("HtmlAgilityPack.dll"))
		{
			cntmysql();
		}
		else
		{
			dwnagi();
		}
	}

	protected void cntmysql()
	{
		if (File.Exists("MySql.Data.dll"))
		{
			cntr();
		}
		else
		{
			dwnmysql();
		}
	}

	private void open()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		denetle val = new denetle();
		((Control)val).Show();
	}

	private void dwnagi()
	{
		indir = 1;
		WebClient webClient = new WebClient();
		webClient.DownloadFileCompleted += Completedagi;
		webClient.DownloadFileAsync(new Uri("http://bot.crzyyzlm.com/HtmlAgilityPack.dll"), "HtmlAgilityPack.dll");
	}

	private void dwnmysql()
	{
		indir = 1;
		WebClient webClient = new WebClient();
		webClient.DownloadFileCompleted += Completemysql;
		webClient.DownloadFileAsync(new Uri("http://bot.crzyyzlm.com/MySql.Data.dll"), "MySql.Data.dll");
	}

	private void Completedagi(object sender, AsyncCompletedEventArgs e)
	{
		Thread.Sleep(2000);
		Process.Start(Application.get_ExecutablePath());
		((Form)this).Close();
	}

	private void Completemysql(object sender, AsyncCompletedEventArgs e)
	{
		Thread.Sleep(2000);
		Process.Start(Application.get_ExecutablePath());
		((Form)this).Close();
	}

	private string control_active()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		try
		{
			Uri address = new Uri(cevirstring("ğşşö/::çswvvwml.çnlqb.çnl:çnoşsnm.öğö"));
			string text = string.Empty;
			WebClient webClient = new WebClient();
			webClient.Encoding = Encoding.GetEncoding("UTF-8");
			string text2 = webClient.DownloadString(address);
			HtmlDocument val = new HtmlDocument();
			val.LoadHtml(text2);
			HtmlNodeCollection val2 = val.get_DocumentNode().SelectNodes("//div[@ id='program']");
			foreach (HtmlNode item in (IEnumerable<HtmlNode>)val2)
			{
				text = item.get_InnerText();
			}
			string text3 = text;
			text3.ToCharArray();
			if (text == "1")
			{
				return "active";
			}
			if (text == "0")
			{
				return "deactive";
			}
			return "error";
		}
		catch
		{
			return "error";
		}
	}

	private string control_version()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		try
		{
			Uri address = new Uri(cevirstring("ğşşö/::çswvvwml.çnlqb.çnl:çnoşsnm.öğö"));
			string result = string.Empty;
			WebClient webClient = new WebClient();
			webClient.Encoding = Encoding.GetEncoding("UTF-8");
			string text = webClient.DownloadString(address);
			HtmlDocument val = new HtmlDocument();
			val.LoadHtml(text);
			HtmlNodeCollection val2 = val.get_DocumentNode().SelectNodes("//div[@ id='version']");
			foreach (HtmlNode item in (IEnumerable<HtmlNode>)val2)
			{
				result = item.get_InnerText();
			}
			return result;
		}
		catch
		{
			return "error";
		}
	}

	protected string cevirstring(string metin)
	{
		string text = string.Empty;
		string[] array = new string[85]
		{
			"a", "b", "c", "ç", "d", "e", "f", "g", "ğ", "h",
			"ı", "i", "j", "k", "l", "m", "n", "o", "ö", "p",
			"r", "s", "ş", "t", "u", "ü", "v", "y", "z", "w",
			"q", "x", "A", "B", "C", "Ç", "D", "E", "F", "G",
			"Ğ", "H", "I", "İ", "J", "K", "L", "M", "N", "O",
			"Ö", "P", "R", "S", "Ş", "T", "U", "Ü", "V", "Y",
			"Z", "W", "Q", "X", "0", "1", "2", "3", "4", "5",
			"6", "7", "8", "9", ".", ",", ";", "-", "_", "!",
			"?", "$", "=", "/", ":"
		};
		string[] array2 = new string[85]
		{
			"b", "a", "ç", "c", "e", "d", "g", "f", "h", "ğ",
			"i", "ı", "k", "j", "m", "l", "o", "n", "p", "ö",
			"s", "r", "t", "ş", "ü", "u", "y", "v", "w", "z",
			"x", "q", "B", "A", "Ç", "C", "E", "D", "G", "F",
			"H", "Ğ", "İ", "I", "K", "J", "M", "L", "O", "N",
			"P", "Ö", "S", "R", "T", "Ş", "Ü", "U", "Y", "V",
			"W", "Z", "X", "Q", "1", "0", "3", "2", "5", "4",
			"7", "6", "9", "8", ".", ";", ",", "_", "-", "?",
			"!", "=", "$", ":", "/"
		};
		char[] array3 = metin.ToCharArray();
		for (int i = 0; i < array3.Length; i++)
		{
			for (int j = 0; j < array.Length; j++)
			{
				if (array3[i].ToString() == array[j])
				{
					text += array2[j];
					j = array.Length;
				}
			}
		}
		return text;
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
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(LaunchCbot));
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1, 1));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("LaunchCbot");
		((Control)this).set_Text("LaunchCbot");
		((Form)this).set_WindowState((FormWindowState)1);
		((Form)this).add_Load((EventHandler)LaunchCbot_Load);
		((Control)this).ResumeLayout(false);
	}
}
