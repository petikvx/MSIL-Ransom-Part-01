using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;
using System.Windows.Forms;
using System.Xml;
using Microsoft.JScript;

namespace WebCruiserWVS;

public class GClass0
{
	private string string_0;

	private string string_1 = "";

	private string string_2 = "";

	private Uri uri_0;

	private int int_0;

	private int int_1 = -1;

	private GEnum1 genum1_0 = GEnum1.UnKnown;

	private GEnum2 genum2_0 = GEnum2.UnKnown;

	private GEnum3 genum3_0 = GEnum3.UnKnown;

	public CookieContainer cookieContainer_0 = new CookieContainer();

	public static bool bool_0 = true;

	public bool bool_1;

	public DateTime dateTime_0 = DateTime.Now;

	public DateTime dateTime_1 = DateTime.Now;

	public DateTime dateTime_2 = DateTime.Now;

	public static GEnum4 genum4_0 = GEnum4.Ready;

	public static bool bool_2 = false;

	private List<string> list_0 = new List<string>();

	private List<string> list_1 = new List<string>();

	private List<string> list_2 = new List<string>();

	public static int int_2 = 0;

	public static DateTime dateTime_3;

	public XmlDocument xmlDocument_0;

	public string string_3 = "";

	public int int_3;

	public int int_4;

	private string string_4 = "";

	public string string_5 = "";

	public string string_6 = "";

	public Encoding encoding_0 = Encoding.UTF8;

	public Encoding encoding_1 = Encoding.UTF8;

	public void method_0(string string_7)
	{
		list_0.Add(string_7);
	}

	public void method_1(string string_7)
	{
		list_1.Add(string_7);
	}

	public void method_2(string string_7)
	{
		list_2.Add(string_7);
	}

	[SpecialName]
	public string method_3()
	{
		return string_4;
	}

	[SpecialName]
	public void method_4(string string_7)
	{
		string_4 = string_7;
	}

	public void method_5()
	{
		list_0.Clear();
		list_1.Clear();
		list_2.Clear();
	}

	public string method_6(bool bool_3)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Invalid comparison between Unknown and I4
		if (string.IsNullOrEmpty(string_3) || bool_3)
		{
			string fileName = "WebCruiserWVS_" + method_11() + ".xml";
			SaveFileDialog val = new SaveFileDialog();
			((FileDialog)val).set_Filter("XML File(*.xml) | *.xml");
			((FileDialog)val).set_InitialDirectory(Application.get_StartupPath());
			((FileDialog)val).set_FileName(fileName);
			DialogResult val2 = ((CommonDialog)val).ShowDialog();
			if ((int)val2 != 1)
			{
				return "";
			}
			string_3 = ((FileDialog)val).get_FileName();
			((Component)(object)val).Dispose();
		}
		xmlDocument_0.Save(string_3);
		return string_3;
	}

	[SpecialName]
	public Uri method_7()
	{
		return uri_0;
	}

	[SpecialName]
	public string method_8()
	{
		return string_0;
	}

	[SpecialName]
	public void method_9(string string_7)
	{
		string_0 = string_7;
		method_22();
	}

	[SpecialName]
	public string method_10()
	{
		return string_1;
	}

	[SpecialName]
	public string method_11()
	{
		return string_2;
	}

	[SpecialName]
	public int method_12()
	{
		return int_0;
	}

	[SpecialName]
	public void method_13(int int_5)
	{
		int_0 = int_5;
	}

	[SpecialName]
	public int method_14()
	{
		return int_1;
	}

	[SpecialName]
	public void method_15(int int_5)
	{
		int_1 = int_5;
	}

	[SpecialName]
	public GEnum1 method_16()
	{
		return genum1_0;
	}

	[SpecialName]
	public void method_17(GEnum1 genum1_1)
	{
		genum1_0 = genum1_1;
	}

	[SpecialName]
	public GEnum2 method_18()
	{
		return genum2_0;
	}

	[SpecialName]
	public void method_19(GEnum2 genum2_1)
	{
		genum2_0 = genum2_1;
	}

	[SpecialName]
	public GEnum3 method_20()
	{
		return genum3_0;
	}

	[SpecialName]
	public void method_21(GEnum3 genum3_1)
	{
		genum3_0 = genum3_1;
	}

	private void method_22()
	{
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(string_0) && string_0.IndexOf("about:blank") != 0)
		{
			if (string_0.IndexOf("http") < 0)
			{
				string_0 = "http://" + string_0.Trim();
			}
			if (string_0.LastIndexOf('/') < 9)
			{
				string_0 = string_0.Trim() + "/";
			}
			string_1 = string_0.Substring(0, string_0.IndexOf("/", 9) + 1);
			try
			{
				uri_0 = new Uri(string_1);
				string_2 = uri_0.Host;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}

	public GClass0(string string_7)
	{
		string_0 = string_7;
		method_22();
		method_24();
	}

	public string method_23(string string_7)
	{
		try
		{
			string[] array = string_7.Split(new char[1] { '?' });
			string text = array[0].Substring(string_7.LastIndexOf('/') + 1);
			string_5 = text.Substring(text.IndexOf('.'));
			return string_5;
		}
		catch
		{
			return "";
		}
	}

	private void method_24()
	{
		xmlDocument_0 = new XmlDocument();
		XmlNode newChild = xmlDocument_0.CreateXmlDeclaration("1.0", "utf-8", "");
		xmlDocument_0.AppendChild(newChild);
		XmlComment newChild2 = xmlDocument_0.CreateComment("Created By WebCruiser - Web Vulnerability Scanner http://sec4app.com");
		xmlDocument_0.AppendChild(newChild2);
		XmlElement xmlElement = xmlDocument_0.CreateElement("ROOT");
		xmlDocument_0.AppendChild(xmlElement);
		XmlElement newChild3 = xmlDocument_0.CreateElement("CurrentSite");
		xmlElement.AppendChild(newChild3);
		XmlElement newChild4 = xmlDocument_0.CreateElement("SiteVulList");
		xmlElement.AppendChild(newChild4);
		XmlElement newChild5 = xmlDocument_0.CreateElement("SiteDirTree");
		xmlElement.AppendChild(newChild5);
		XmlElement newChild6 = xmlDocument_0.CreateElement("SiteSQLEnv");
		xmlElement.AppendChild(newChild6);
		XmlElement newChild7 = xmlDocument_0.CreateElement("SiteDBStructure");
		xmlElement.AppendChild(newChild7);
	}

	public static void smethod_0(string string_7)
	{
		DateTime now = DateTime.Now;
		string path = Application.get_StartupPath() + "\\WebCruiser" + now.ToString("yyyyMMdd") + ".log";
		string s = string.Concat(now, "  ", string_7, "\r\n");
		byte[] bytes = Encoding.Default.GetBytes(s);
		FileStream fileStream = new FileStream(path, FileMode.Append, FileAccess.Write, FileShare.ReadWrite, 8, FileOptions.Asynchronous);
		fileStream.Write(bytes, 0, bytes.Length);
		fileStream.Close();
		fileStream.Dispose();
	}

	[DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool InternetSetCookie(string string_7, string string_8, string string_9);

	public void method_25(string string_7)
	{
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (string.IsNullOrEmpty(string_7) || string.IsNullOrEmpty(string_1))
			{
				return;
			}
			Uri uri = new Uri(string_1);
			string text = "";
			string[] array = string_7.Split(new char[1] { ';' });
			string[] array2 = array;
			foreach (string text2 in array2)
			{
				string[] array3 = text2.Split(new char[1] { '=' });
				string text3 = array3[0];
				string text4 = "";
				for (int j = 1; j < array3.Length; j++)
				{
					text4 = ((!string.IsNullOrEmpty(text4)) ? (text4 + "=" + array3[j]) : (text4 + array3[j]));
				}
				text3 = text3.Trim();
				if (!string.IsNullOrEmpty(text4))
				{
					text4 = text4.Trim();
					text4 = GlobalObject.unescape((object)text4);
					if (bool_0)
					{
						text4 = GlobalObject.escape((object)text4);
					}
					else if (text4.IndexOf("\"") != 0 && (text4.IndexOf('\'') > 0 || text4.IndexOf(' ') > 0))
					{
						text4 = "\"" + text4 + "\"";
					}
				}
				InternetSetCookie(method_10(), text3, text4);
				if (!string.IsNullOrEmpty(text))
				{
					text += ",";
				}
				text = text + text3 + "=" + text4;
			}
			cookieContainer_0.SetCookies(uri, text);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	public void method_26(string string_7)
	{
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (string.IsNullOrEmpty(string_7) || string.IsNullOrEmpty(string_1))
			{
				return;
			}
			Uri uri = new Uri(string_1);
			string text = "";
			string_7.Split(new char[1] { ';' });
			string[] array = string_7.Split(new char[1] { '=' });
			string text2 = array[0];
			string text3 = "";
			for (int i = 1; i < array.Length; i++)
			{
				text3 = ((!string.IsNullOrEmpty(text3)) ? (text3 + "=" + array[i]) : (text3 + array[i]));
			}
			text2 = text2.Trim();
			if (!string.IsNullOrEmpty(text3))
			{
				text3 = text3.Trim();
				text3 = GlobalObject.unescape((object)text3);
				if (bool_0)
				{
					text3 = GlobalObject.escape((object)text3);
				}
				else if (text3.IndexOf("\"") != 0 && (text3.IndexOf('\'') > 0 || text3.IndexOf(' ') > 0))
				{
					text3 = "\"" + text3 + "\"";
				}
			}
			InternetSetCookie(method_10(), text2, text3);
			if (!string.IsNullOrEmpty(text))
			{
				text += ",";
			}
			text = text + text2 + "=" + text3;
			cookieContainer_0.SetCookies(uri, text);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	public static string[] smethod_1(string string_7, char char_0)
	{
		string[] array = string_7.Split(new char[1] { char_0 });
		string[] array2 = new string[2]
		{
			array[0],
			null
		};
		string text = "";
		for (int i = 1; i < array.Length; i++)
		{
			if (!string.IsNullOrEmpty(text))
			{
				text += char_0;
			}
			text += array[i];
		}
		array2[1] = text;
		return array2;
	}

	public string method_27(string string_7)
	{
		string_7 = string_7.Replace("\r\n", "");
		string[] array = string_7.Split(new char[1] { '&' });
		string text = "";
		for (int i = 0; i < array.Length; i++)
		{
			string[] array2 = array[i].Split(new char[1] { '=' });
			string text2 = array2[0];
			string text3 = "";
			for (int j = 1; j < array2.Length; j++)
			{
				if (!string.IsNullOrEmpty(text3))
				{
					text3 += "=";
				}
				text3 += array2[j];
			}
			if (!string.IsNullOrEmpty(text3))
			{
				text3 = HttpUtility.UrlDecode(text3, encoding_0);
				text3 = HttpUtility.UrlEncode(text3, encoding_0)!.Replace("'", "%27");
			}
			if (!string.IsNullOrEmpty(text))
			{
				text += "&";
			}
			text = text + text2 + "=" + text3;
		}
		return text;
	}

	public HttpWebResponse method_28(string string_7, GEnum0 genum0_0)
	{
		string text = "";
		string_7 = string_7.Replace(" ", "%20");
		if (string_7.IndexOf("99999999") > 0)
		{
			string_7 = string_7.Replace("%20and%20(", "%20or%20(");
		}
		if (WCRSetting.chkReplace1)
		{
			string_7 = string_7.Replace(WCRSetting.FiltExpr1, WCRSetting.RepExpr1);
		}
		if (WCRSetting.chkReplace2)
		{
			string_7 = string_7.Replace(WCRSetting.FiltExpr2, WCRSetting.RepExpr2);
		}
		if (WCRSetting.chkReplace3)
		{
			string_7 = string_7.Replace(WCRSetting.FiltExpr3, WCRSetting.RepExpr3);
		}
		if (int_1 == 1)
		{
			string_7 = string_7.Replace("%20", "/**/");
		}
		if (genum1_0 == GEnum1.DB2 || genum1_0 == GEnum1.Access)
		{
			string_7 = string_7.Replace("/**/", "%20");
		}
		if (genum2_0 == GEnum2.Search || genum0_0 == GEnum0.COOKIE)
		{
			while (bool_1)
			{
				Thread.Sleep(1000);
			}
			bool_1 = true;
		}
		if (genum2_0 == GEnum2.Search)
		{
			TimeSpan timeSpan = DateTime.Now.Subtract(dateTime_0);
			int num = WCRSetting.SecondsDelay * 1000;
			if (timeSpan.Milliseconds < num)
			{
				Thread.Sleep(num - timeSpan.Milliseconds);
			}
			dateTime_0 = DateTime.Now;
		}
		while (int_0 >= WCRSetting.MaxHTTPThreadNum)
		{
			Thread.Sleep(300);
		}
		try
		{
			if (genum4_0 == GEnum4.Stop)
			{
				Thread.CurrentThread.Abort();
			}
		}
		catch
		{
		}
		string s = "";
		text = string_7;
		switch (genum0_0)
		{
		case GEnum0.POST:
		{
			string[] array2 = smethod_1(string_7, '^');
			text = array2[0];
			s = method_27(array2[1]);
			break;
		}
		case GEnum0.COOKIE:
			if (string_7.IndexOf('^') > 0)
			{
				string[] array = smethod_1(string_7, '^');
				text = array[0];
				string string_8 = array[1];
				method_26(string_8);
			}
			break;
		}
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(text);
			httpWebRequest.UserAgent = WCRSetting.UserAgent;
			httpWebRequest.ContentType = "application/x-www-form-urlencoded";
			httpWebRequest.CookieContainer = cookieContainer_0;
			if (genum0_0 == GEnum0.POST)
			{
				httpWebRequest.Method = "POST";
				byte[] bytes = Encoding.UTF8.GetBytes(s);
				httpWebRequest.ContentLength = bytes.Length;
				Stream requestStream = httpWebRequest.GetRequestStream();
				requestStream.Write(bytes, 0, bytes.Length);
				requestStream.Close();
			}
			else
			{
				httpWebRequest.Method = "GET";
			}
			if (WCRSetting.UseProxy)
			{
				WebProxy webProxy = new WebProxy(WCRSetting.ProxyAddress, WCRSetting.ProxyPort);
				if (!string.IsNullOrEmpty(WCRSetting.ProxyUsername))
				{
					webProxy.Credentials = new NetworkCredential(WCRSetting.ProxyUsername, WCRSetting.ProxyPassword);
				}
				else
				{
					webProxy.Credentials = CredentialCache.DefaultCredentials;
				}
				httpWebRequest.Proxy = webProxy;
				httpWebRequest.UnsafeAuthenticatedConnectionSharing = true;
			}
			httpWebRequest.Timeout = 30000;
			while (genum4_0 == GEnum4.Pause)
			{
				Thread.Sleep(1000);
			}
			try
			{
				if (genum4_0 == GEnum4.Stop)
				{
					Thread.CurrentThread.Abort();
				}
			}
			catch
			{
			}
			int_0++;
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			_ = httpWebResponse.CharacterSet;
			dateTime_1 = httpWebResponse.LastModified;
			dateTime_2 = DateTime.Now;
			bool_1 = false;
			if (bool_2)
			{
				smethod_0(genum0_0.ToString() + "  " + string_7 + "  " + httpWebResponse.StatusCode);
			}
			return httpWebResponse;
		}
		catch (WebException ex)
		{
			bool_1 = false;
			HttpWebResponse httpWebResponse2 = ex.Response as HttpWebResponse;
			if (bool_2)
			{
				string text2 = genum0_0.ToString() + "  " + string_7;
				text2 = ((httpWebResponse2 != null) ? (text2 + "  " + httpWebResponse2.StatusCode) : (text2 + " NullResponse"));
				smethod_0(text2);
			}
			return httpWebResponse2;
		}
		catch (Exception ex2)
		{
			if (bool_2)
			{
				smethod_0(genum0_0.ToString() + "  " + string_7 + "  Exception:" + ex2.Message);
			}
			return null;
		}
		finally
		{
			bool_1 = false;
			int_0--;
			if (int_0 < 0)
			{
				int_0 = 0;
			}
		}
	}

	public string method_29(HttpWebResponse httpWebResponse_0)
	{
		if (genum4_0 == GEnum4.Stop)
		{
			return "";
		}
		try
		{
			Stream responseStream = httpWebResponse_0.GetResponseStream();
			_ = httpWebResponse_0.CharacterSet;
			StreamReader streamReader = new StreamReader(responseStream, encoding_0);
			string result = streamReader.ReadToEnd();
			streamReader.Close();
			responseStream.Close();
			httpWebResponse_0.Close();
			return result;
		}
		catch
		{
			return "";
		}
	}

	public string method_30(string string_7, GEnum0 genum0_0)
	{
		try
		{
			if (genum4_0 == GEnum4.Stop)
			{
				Thread.CurrentThread.Abort();
			}
			HttpWebResponse httpWebResponse = method_28(string_7, genum0_0);
			if (httpWebResponse == null)
			{
				return "";
			}
			Stream responseStream = httpWebResponse.GetResponseStream();
			StreamReader streamReader = new StreamReader(responseStream, encoding_0);
			string result = streamReader.ReadToEnd();
			streamReader.Close();
			responseStream.Close();
			httpWebResponse.Close();
			return result;
		}
		catch
		{
			return "";
		}
	}

	public string method_31(string string_7, GEnum0 genum0_0, Encoding encoding_2)
	{
		try
		{
			if (genum4_0 == GEnum4.Stop)
			{
				Thread.CurrentThread.Abort();
			}
			HttpWebResponse httpWebResponse = method_28(string_7, genum0_0);
			Stream responseStream = httpWebResponse.GetResponseStream();
			StreamReader streamReader = new StreamReader(responseStream, encoding_2);
			string result = streamReader.ReadToEnd();
			streamReader.Close();
			responseStream.Close();
			httpWebResponse.Close();
			return result;
		}
		catch
		{
			return "";
		}
	}

	public static string smethod_2(string string_7)
	{
		if (string_7.IndexOf('^') > 0)
		{
			string[] array = string_7.Split(new char[1] { '^' });
			string_7 = array[0];
		}
		if (string_7.IndexOf('?') > 0)
		{
			string[] array2 = string_7.Split(new char[1] { '?' });
			string_7 = array2[0];
		}
		return string_7;
	}

	public bool method_32(string string_7)
	{
		int num = 0;
		while (true)
		{
			if (num < list_2.Count)
			{
				if (list_2[num].Equals(string_7))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public static GEnum2 smethod_3(string string_7)
	{
		if (string_7.LastIndexOf('=') < 0)
		{
			return GEnum2.NotInjectable;
		}
		string[] array = ((string_7.IndexOf('^') <= 0) ? string_7.Split(new char[1] { '?' }) : string_7.Split(new char[1] { '^' }));
		if (array.Length < 2)
		{
			return GEnum2.NotInjectable;
		}
		string text = array[1].Split(new char[1] { '&' })[^1];
		string[] array2 = text.Split(new char[1] { '=' });
		if (array2.Length >= 2 && !string.IsNullOrEmpty(array2[1]))
		{
			string text2 = array2[0];
			string input = array2[1];
			if (text2.ToLower().IndexOf("search") >= 0)
			{
				return GEnum2.Search;
			}
			if (text2.ToLower().IndexOf("query") >= 0)
			{
				return GEnum2.Search;
			}
			if (Regex.IsMatch(input, "^\\d+$"))
			{
				return GEnum2.Integer;
			}
			return GEnum2.String;
		}
		return GEnum2.NotInjectable;
	}

	public string method_33()
	{
		try
		{
			CookieCollection cookies = cookieContainer_0.GetCookies(uri_0);
			string text = "";
			for (int i = 0; i < cookies.Count; i++)
			{
				if (!string.IsNullOrEmpty(text))
				{
					text += "; ";
				}
				text = ((!bool_0) ? (text + GlobalObject.unescape((object)cookies[i].ToString())) : (text + cookies[i].ToString()));
			}
			return text;
		}
		catch
		{
			return "";
		}
	}

	public static bool smethod_4(string string_7, string string_8)
	{
		try
		{
			string_7 = string_7.ToLower();
			if (string_7.IndexOf("<") < 0)
			{
				return true;
			}
			if (string_7.Length < 200)
			{
				if (string_7.IndexOf("error") > 0)
				{
					return true;
				}
				if (string_7.IndexOf("UnKnown") > 0)
				{
					return true;
				}
				if (string_7.IndexOf("invalid") > 0)
				{
					return true;
				}
				if (string_7.IndexOf("wrong") > 0)
				{
					return true;
				}
				if (string_7.IndexOf("错误") >= 0)
				{
					return true;
				}
				if (string_7.IndexOf("出错") >= 0)
				{
					return true;
				}
			}
			else if (string_7.Length < 2000)
			{
				if (string_7.IndexOf("sql ") > 0 && string_7.IndexOf(" error") > 0)
				{
					return true;
				}
			}
			else if (string_7.Length < 10240)
			{
				if (string_7.IndexOf("sorry ") > 0 && string_7.IndexOf(" log") > 0)
				{
					return true;
				}
				if (string_7.IndexOf("wrong") > 0 && string_7.IndexOf("password") > 0)
				{
					return true;
				}
				if (string_7.IndexOf("对不起") > 0 && string_7.IndexOf("未登录") > 0)
				{
					return true;
				}
				if (string_7.IndexOf("密码") > 0 && string_7.IndexOf("错误") > 0)
				{
					return true;
				}
			}
			Regex regex = new Regex("(?<=<title>).+(?=</title>)", RegexOptions.IgnoreCase | RegexOptions.Singleline);
			string value = regex.Match(string_7).Value;
			if (!string.IsNullOrEmpty(value))
			{
				if (value.IndexOf("error") > 0)
				{
					return true;
				}
				if (value.IndexOf("UnKnown") > 0)
				{
					return true;
				}
				if (value.IndexOf("invalid") > 0)
				{
					return true;
				}
				if (value.IndexOf("wrong") > 0)
				{
					return true;
				}
				if (value.IndexOf("错误") >= 0)
				{
					return true;
				}
				if (value.IndexOf("出错") >= 0)
				{
					return true;
				}
			}
			if (string_7.IndexOf("99999999") >= 0 || string_7.IndexOf("ParaName") >= 0)
			{
				if (string_7.IndexOf("error") > 0)
				{
					return true;
				}
				if (string_7.IndexOf("UnKnown") > 0)
				{
					return true;
				}
				if (string_7.IndexOf("invalid") > 0)
				{
					return true;
				}
				if (string_7.IndexOf("wrong") > 0)
				{
					return true;
				}
				if (string_7.IndexOf("错误") >= 0)
				{
					return true;
				}
				if (string_7.IndexOf("出错") >= 0)
				{
					return true;
				}
			}
			return false;
		}
		catch
		{
			return false;
		}
	}

	public static string smethod_5(string string_7, string string_8, string string_9)
	{
		if (smethod_4(string_7, string_9))
		{
			return "";
		}
		Regex regex = new Regex("<[^>]+>", RegexOptions.Multiline | RegexOptions.Singleline);
		string_7 = regex.Replace(string_7, " ");
		string_8 = regex.Replace(string_8, " ");
		regex = new Regex("[^a-zA-Z\\u0080-\\uFFFF]+", RegexOptions.Multiline | RegexOptions.Singleline);
		string[] array = regex.Split(string_7);
		string result = "";
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i].Length >= 5 && !array[i].Equals("admin") && string_8.IndexOf(array[i]) < 0)
			{
				result = array[i];
				break;
			}
		}
		return result;
	}

	public string method_34(string string_7, GEnum0 genum0_0, GEnum2 genum2_1, string string_8, bool bool_3, bool bool_4, string string_9)
	{
		if (genum2_1 == GEnum2.NotInjectable)
		{
			return "";
		}
		string string_10 = "";
		if (genum0_0 == GEnum0.COOKIE)
		{
			string_10 = method_33();
		}
		try
		{
			string text = "";
			string text2 = "";
			if (!bool_4)
			{
				if (!WCRSetting.bool_0)
				{
					return "";
				}
				if (genum0_0 == GEnum0.GET && !WCRSetting.bool_1)
				{
					return "";
				}
				if (genum0_0 == GEnum0.POST && !WCRSetting.bool_2)
				{
					return "";
				}
				if (genum0_0 == GEnum0.COOKIE && !WCRSetting.bool_3)
				{
					return "";
				}
				switch (genum2_1)
				{
				case GEnum2.Integer:
					text = string_7 + "%20" + string_8 + "%207=7";
					text2 = string_7 + "%20" + string_8 + "%207=2";
					break;
				case GEnum2.String:
					text = string_7 + "%27%20" + string_8 + "%20%277%27=%277";
					text2 = string_7 + "%27%20" + string_8 + "%20%277%27=%272";
					break;
				case GEnum2.Search:
					text = string_7 + "%25%27%20" + string_8 + "%20%27%25%27%3D%27";
					text2 = string_7 + "%25%27%20" + string_8 + "%20%27%25%27%3D2%27";
					break;
				}
				if (bool_3)
				{
					text = text.Replace("%20", "/**/");
					text2 = text2.Replace("%20", "/**/");
				}
			}
			else
			{
				if (!WCRSetting.bool_5)
				{
					return "";
				}
				text = string_7 + "%27] | * | user[@role=%27admin";
				text2 = string_7;
			}
			HttpWebResponse httpWebResponse = method_28(text, genum0_0);
			if (httpWebResponse == null)
			{
				smethod_0(genum0_0.ToString() + "  " + string_7 + "  " + genum2_1.ToString() + " URL1 Null");
				return "";
			}
			if (httpWebResponse.StatusCode != HttpStatusCode.OK)
			{
				smethod_0(genum0_0.ToString() + "  " + string_7 + "  " + genum2_1.ToString() + " URL1 StatusCode!=OK");
				return "";
			}
			httpWebResponse.ResponseUri.ToString();
			if (genum4_0 == GEnum4.Stop)
			{
				Thread.CurrentThread.Abort();
			}
			string text3 = method_29(httpWebResponse);
			if (string.IsNullOrEmpty(text3))
			{
				smethod_0(genum0_0.ToString() + "  " + string_7 + "  " + genum2_1.ToString() + " KeyWord Null");
				return "";
			}
			string string_11 = method_30(text2, genum0_0);
			string text4 = smethod_5(text3, string_11, string_9);
			if (genum0_0 == GEnum0.COOKIE)
			{
				method_25(string_10);
			}
			smethod_0(genum0_0.ToString() + "  " + string_7 + "  " + genum2_1.ToString() + " KeyWord=" + text4);
			return text4;
		}
		catch
		{
			if (genum0_0 == GEnum0.COOKIE)
			{
				method_25(string_10);
			}
			return "";
		}
	}

	public static string smethod_6(string string_7)
	{
		return string_7.Replace("!S!", "").Replace("!E!", "");
	}

	public string[] method_35(string string_7, GEnum0 genum0_0, string string_8)
	{
		List<string> list = new List<string>();
		method_30(string_7, genum0_0);
		string[] array = ((genum0_0 != 0) ? string_7.Split(new char[1] { '^' }) : string_7.Split(new char[1] { '?' }));
		if (array.Length < 2)
		{
			return list.ToArray();
		}
		string[] array2 = array[1].Split(new char[1] { '&' });
		for (int i = 0; i < 2; i++)
		{
			if (method_14() == 1)
			{
				i++;
			}
			else if (method_14() == 0 && i == 1)
			{
				break;
			}
			for (int j = 0; j < array2.Length; j++)
			{
				string text = array2[(j + array2.Length - 1) % array2.Length];
				string[] array3 = text.Split(new char[1] { '=' });
				if (array3.Length < 2 || string.IsNullOrEmpty(array3[1]))
				{
					continue;
				}
				string text2 = array3[0];
				if (text2.ToLower().Equals("submit"))
				{
					continue;
				}
				string text3 = smethod_2(string_7) + "^" + text2.ToLower() + "^Injection";
				if (method_32(text3))
				{
					continue;
				}
				list_2.Add(text3);
				string text4 = array3[1];
				for (int k = 0; k < 3; k++)
				{
					bool flag = false;
					string text5 = text;
					char c = '&';
					GEnum0 gEnum = genum0_0;
					switch (k)
					{
					case 1:
						if (genum0_0 == GEnum0.GET)
						{
							if (!WCRSetting.bool_3)
							{
								continue;
							}
							c = '^';
							gEnum = GEnum0.COOKIE;
						}
						else
						{
							if (genum0_0 != GEnum0.POST || text4.IndexOf("WCRTESTINPUT") < 0 || !WCRSetting.bool_2)
							{
								continue;
							}
							text5 = text2 + "=1";
						}
						goto default;
					case 2:
						if (genum0_0 == GEnum0.GET)
						{
							if (flag)
							{
								continue;
							}
							text5 = text2 + "=99999999";
						}
						else
						{
							if (genum0_0 != GEnum0.POST || text4.IndexOf("WCRTESTINPUT") < 0 || flag)
							{
								continue;
							}
							text5 = text2 + "=99999999";
						}
						goto default;
					default:
					{
						string text6 = "";
						string text7 = "";
						if (array2.Length == 1)
						{
							text6 = text5;
							text7 = ((genum0_0 != 0 || k == 1) ? (array[0] + "^" + text6) : (array[0] + "?" + text6));
						}
						else
						{
							if (array2.Length <= 1)
							{
								return list.ToArray();
							}
							text6 = array2[j];
							for (int l = 1; l < array2.Length - 1; l++)
							{
								text6 = text6 + "&" + array2[(j + l) % array2.Length];
							}
							if (!string.IsNullOrEmpty(text6))
							{
								text6 += c;
							}
							text6 += text5;
							text7 = ((genum0_0 != 0) ? (array[0] + "^" + text6) : (array[0] + "?" + text6));
						}
						GEnum2 gEnum2 = smethod_3(text7);
						if (gEnum2 == GEnum2.NotInjectable)
						{
							continue;
						}
						bool bool_ = false;
						if (i == 1)
						{
							bool_ = true;
						}
						string string_9 = "and";
						if (k == 2)
						{
							string_9 = "or";
						}
						string text8 = method_34(text7, gEnum, gEnum2, string_9, bool_, bool_4: false, text2);
						if (genum4_0 != GEnum4.Stop)
						{
							if (string.IsNullOrEmpty(text8))
							{
								if (gEnum2 == GEnum2.Integer)
								{
									text8 = method_34(text7, gEnum, GEnum2.String, string_9, bool_, bool_4: false, text2);
									if (genum4_0 == GEnum4.Stop)
									{
										return list.ToArray();
									}
									if (!string.IsNullOrEmpty(text8))
									{
										flag = true;
										gEnum2 = GEnum2.String;
										if (i == 0)
										{
											method_15(0);
										}
										else
										{
											method_15(1);
										}
									}
								}
							}
							else
							{
								flag = true;
								if (i == 0)
								{
									method_15(0);
								}
								else
								{
									method_15(1);
								}
							}
							string text9 = "";
							string text10 = smethod_6(text7);
							string text11 = text8;
							text9 = gEnum switch
							{
								GEnum0.GET => "URL SQL INJECTION", 
								GEnum0.POST => "POST SQL INJECTION", 
								_ => "COOKIE SQL INJECTION", 
							};
							if (k == 2 && !string.IsNullOrEmpty(string_8))
							{
								if (text7.IndexOf("WCRTESTTEXTAREA") > 0)
								{
									continue;
								}
								string value = method_34(text7, gEnum, GEnum2.String, string_9, bool_, bool_4: true, text2);
								if (!string.IsNullOrEmpty(value))
								{
									text9 = "XPath INJECTION";
									text10 = string_8;
									text5 = smethod_6(text5);
									gEnum2 = GEnum2.String;
									text11 = smethod_6(text7);
									flag = true;
								}
							}
							if (!flag)
							{
								continue;
							}
							list.Add(text10 + "^^" + text5 + "^^" + gEnum2.ToString() + "^^" + text11 + "^^" + text9);
							if (genum0_0 != 0 || k != 1)
							{
								continue;
							}
							break;
						}
						return list.ToArray();
					}
					}
					break;
				}
			}
			if (method_14() == 0)
			{
				break;
			}
		}
		return list.ToArray();
	}

	public bool method_36(string string_7)
	{
		string value = smethod_7(string_7);
		int num = 0;
		while (true)
		{
			if (num < list_0.Count)
			{
				if (list_0[num].Equals(value))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public bool method_37(string string_7)
	{
		string value = smethod_7(string_7);
		int num = 0;
		while (true)
		{
			if (num < list_1.Count)
			{
				if (list_1[num].Equals(value))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public static string smethod_7(string string_7)
	{
		if (string_7.IndexOf('?') > 0)
		{
			string[] array = string_7.Split(new char[1] { '?' });
			string text = array[0];
			if (array.Length >= 2)
			{
				string[] array2 = array[1].Split(new char[1] { '&' });
				string[] array3 = array2;
				foreach (string text2 in array3)
				{
					string[] array4 = text2.Split(new char[1] { '=' });
					if (array4.Length > 1 && !string.IsNullOrEmpty(array4[1]))
					{
						if (array4[1].IndexOf('#') > 0)
						{
							array4[1] = array4[1].Substring(0, array4[1].IndexOf('#'));
						}
						text = ((!Regex.IsMatch(array4[1], "^\\d+$")) ? (text + "?" + text2) : (text + "?" + array4[0]));
					}
					else
					{
						text = text + "?" + array4[0];
					}
				}
			}
			Regex regex = new Regex(",\\d+$", RegexOptions.Singleline);
			string value = regex.Match(text).Value;
			if (!string.IsNullOrEmpty(value))
			{
				text = text.Replace(value, ",");
			}
			return text;
		}
		string[] array5 = string_7.Split(new char[1] { '^' });
		return array5[0];
	}

	public static string smethod_8(string string_7)
	{
		string text = "";
		if (string_7.IndexOf('?') < 0)
		{
			return string_7.Substring(0, string_7.LastIndexOf('/') + 1);
		}
		string[] array = string_7.Split(new char[1] { '?' });
		return array[0].Substring(0, array[0].LastIndexOf('/') + 1);
	}

	public static string smethod_9(string string_7)
	{
		Regex regex = new Regex("(?<=<base\\s+href=[\\x27\\x22]?)[^\\x27\\x22\\s>]+(?=[\\x27\\x22\\s>]?)", RegexOptions.IgnoreCase | RegexOptions.Singleline);
		return regex.Match(string_7).Value;
	}

	public static string smethod_10(string string_7, string string_8)
	{
		Regex regex = new Regex("(?<=" + string_8 + "\\s*=\\s*[\\x22\\x27])[^\\x22\\x27\\x3e]+?(?=[\\x22\\x27\\x3e])", RegexOptions.IgnoreCase | RegexOptions.Singleline);
		string value = regex.Match(string_7).Value;
		if (string.IsNullOrEmpty(value))
		{
			regex = new Regex("(?<=" + string_8 + "=)[^\\x22\\x27\\x3e\\s]+?(?=[\\s\\x3e])", RegexOptions.IgnoreCase | RegexOptions.Singleline);
			value = regex.Match(string_7).Value;
		}
		return value;
	}

	public static string smethod_11(string string_7, string string_8)
	{
		string text = "";
		if (string_8.LastIndexOf('/') < 9)
		{
			string_8 = string_8.Trim() + "/";
		}
		string text2 = string_8.Substring(0, string_8.IndexOf("/", 9) + 1);
		if (string_7.IndexOf("http") != 0)
		{
			text = ((string_7.IndexOf('/') != 0) ? (string_8 + string_7) : (text2 + string_7.Substring(1)));
		}
		else
		{
			if (string_7.Length <= 8)
			{
				return "";
			}
			text = string_7;
		}
		text = text.Replace("&amp;", "&").Replace("/./", "/");
		if (text.IndexOf('#') > 0)
		{
			text = text.Substring(0, text.IndexOf('#'));
		}
		return text;
	}

	public static string smethod_12(int int_5, string string_7)
	{
		return "!S!WCRTESTINPUT" + $"{int_5:D6}" + string_7 + "!E!";
	}

	public static string smethod_13(string string_7)
	{
		string text = "";
		Regex regex = new Regex("<select\\s+[^>]+>", RegexOptions.IgnoreCase | RegexOptions.Singleline);
		MatchCollection matchCollection = regex.Matches(string_7);
		int[] array = new int[matchCollection.Count];
		for (int i = 0; i < matchCollection.Count; i++)
		{
			string value = matchCollection[i].Value;
			if (i == 0)
			{
				array[i] = string_7.IndexOf(value);
			}
			else
			{
				array[i] = string_7.IndexOf(value, array[i - 1] + 10);
			}
		}
		for (int j = 0; j < matchCollection.Count; j++)
		{
			string text2 = smethod_10(matchCollection[j].Value, "name");
			if (string.IsNullOrEmpty(text2))
			{
				continue;
			}
			string text3 = "";
			text3 = ((j != matchCollection.Count - 1) ? string_7.Substring(array[j], array[j + 1] - array[j]) : string_7.Substring(array[j]));
			regex = new Regex("<option\\s+[^>]+>", RegexOptions.IgnoreCase | RegexOptions.Singleline);
			MatchCollection matchCollection2 = regex.Matches(text3);
			for (int k = 0; k < matchCollection2.Count; k++)
			{
				string text4 = smethod_10(matchCollection2[k].Value, "value");
				if (!string.IsNullOrEmpty(text4))
				{
					if (!string.IsNullOrEmpty(text))
					{
						text += "&";
					}
					text = text + text2 + "=" + text4;
					break;
				}
			}
		}
		return text;
	}

	public static string[] smethod_14(string string_7, string string_8, string string_9)
	{
		List<string> list = new List<string>();
		Regex regex = new Regex("<" + string_8 + "\\s+[^>]+>", RegexOptions.IgnoreCase | RegexOptions.Singleline);
		MatchCollection matchCollection = regex.Matches(string_7);
		foreach (Match item in matchCollection)
		{
			string text = smethod_10(item.Value, string_9);
			if (!string.IsNullOrEmpty(text) && text.IndexOf("logout", StringComparison.OrdinalIgnoreCase) < 0 && text.IndexOf("signout", StringComparison.OrdinalIgnoreCase) < 0 && text.IndexOf("exit", StringComparison.OrdinalIgnoreCase) < 0 && text.IndexOf("quit", StringComparison.OrdinalIgnoreCase) < 0 && text.IndexOf("delete", StringComparison.OrdinalIgnoreCase) < 0 && text.IndexOf("#") != 0 && text.IndexOf("\\") != 0 && text.IndexOf("@") < 0 && text.IndexOf("javascript", StringComparison.OrdinalIgnoreCase) != 0 && (text.IndexOf("http") != 0 || text.Length >= 10))
			{
				list.Add(text);
			}
		}
		return list.ToArray();
	}

	public static string[] smethod_15(string string_7)
	{
		List<string> list = new List<string>();
		Regex regex = new Regex("(?<=document\\.location\\s*=\\s*[\\x22\\x27])[^\\x22\\x27]+?(?=[\\x22\\x27\\x3b])", RegexOptions.IgnoreCase | RegexOptions.Singleline);
		MatchCollection matchCollection = regex.Matches(string_7);
		foreach (Match item in matchCollection)
		{
			string value = item.Value;
			if (!string.IsNullOrEmpty(value) && value.IndexOf("logout", StringComparison.OrdinalIgnoreCase) < 0 && value.IndexOf("signout", StringComparison.OrdinalIgnoreCase) < 0 && value.IndexOf("delete", StringComparison.OrdinalIgnoreCase) < 0 && value.IndexOf("#") != 0 && value.IndexOf("\\") != 0 && value.IndexOf("@") < 0 && value.IndexOf("javascript", StringComparison.OrdinalIgnoreCase) != 0 && (value.IndexOf("http") != 0 || value.Length >= 10))
			{
				list.Add(value);
			}
		}
		return list.ToArray();
	}

	public string[] method_38(string string_7, string string_8, string string_9)
	{
		string text = smethod_9(string_7);
		if (string.IsNullOrEmpty(text))
		{
			text = string_8;
		}
		List<string> list = new List<string>();
		if (string_9.Equals(".js"))
		{
			string[] array = smethod_15(string_7);
			string[] array2 = array;
			foreach (string item in array2)
			{
				list.Add(item);
			}
		}
		else
		{
			string[] array3 = smethod_14(string_7, "a", "href");
			string[] array4 = array3;
			foreach (string text2 in array4)
			{
				if (text2.IndexOf("mailto:") != 0)
				{
					list.Add(text2);
				}
			}
			string[] array5 = smethod_14(string_7, "form", "action");
			string[] array6 = array5;
			foreach (string item2 in array6)
			{
				list.Add(item2);
			}
			string[] array7 = smethod_14(string_7, "iframe", "src");
			string[] array8 = array7;
			foreach (string item3 in array8)
			{
				list.Add(item3);
			}
			string[] array9 = smethod_14(string_7, "script", "src");
			string[] array10 = array9;
			foreach (string item4 in array10)
			{
				list.Add(item4);
			}
			string[] array11 = smethod_15(string_7);
			string[] array12 = array11;
			foreach (string item5 in array12)
			{
				list.Add(item5);
			}
		}
		for (int num = 0; num < list.Count; num++)
		{
			list[num] = smethod_11(list[num], text);
		}
		return list.ToArray();
	}

	public string[] method_39(string string_7, string string_8)
	{
		string text = smethod_8(string_8);
		Regex regex = new Regex("<form\\s+[^>]+>", RegexOptions.IgnoreCase | RegexOptions.Singleline);
		MatchCollection matchCollection = regex.Matches(string_7);
		List<string> list = new List<string>();
		string text2 = smethod_9(string_7);
		if (string.IsNullOrEmpty(text2))
		{
			text2 = text;
		}
		string text3 = "";
		int[] array = new int[matchCollection.Count];
		string text4 = "";
		for (int i = 0; i < matchCollection.Count; i++)
		{
			text4 = matchCollection[i].Value;
			if (i == 0)
			{
				array[i] = string_7.IndexOf(text4);
			}
			else
			{
				array[i] = string_7.IndexOf(text4, array[i - 1] + 10);
			}
		}
		for (int j = 0; j < matchCollection.Count; j++)
		{
			int num = 0;
			text4 = matchCollection[j].Value;
			text3 = ((j != matchCollection.Count - 1) ? string_7.Substring(array[j], array[j + 1] - array[j]) : string_7.Substring(array[j]));
			string text5 = smethod_10(text4, "action");
			if (string.IsNullOrEmpty(text5))
			{
				text5 = string_8;
			}
			string text6 = smethod_10(text4, "method");
			text6 = ((!string.IsNullOrEmpty(text6)) ? text6.ToUpper() : "POST");
			text5 = smethod_11(text5, text2);
			Uri uri = new Uri(text5);
			if (!uri.Host.Equals(method_11()))
			{
				continue;
			}
			regex = new Regex("<input\\s+[^>]+>", RegexOptions.IgnoreCase | RegexOptions.Singleline);
			MatchCollection matchCollection2 = regex.Matches(text3);
			string text7 = "";
			string text8 = "";
			string text9 = "";
			foreach (Match item in matchCollection2)
			{
				text8 = item.Value;
				string_7.IndexOf(text8);
				text9 = smethod_10(text8, "type");
				if (string.IsNullOrEmpty(text9))
				{
					text9 = "text";
				}
				text9 = text9.ToLower();
				if (text9.Equals("hidden"))
				{
					string text10 = smethod_10(text8, "name");
					if (!string.IsNullOrEmpty(text10))
					{
						string text11 = smethod_10(text8, "value");
						if (!string.IsNullOrEmpty(text7))
						{
							text7 += "&";
						}
						text7 = text7 + text10 + "=" + text11;
					}
					continue;
				}
				if (text9.Equals("radio"))
				{
					string text12 = smethod_10(text8, "checked");
					if (!text12.Equals("checked"))
					{
						continue;
					}
					string text13 = smethod_10(text8, "name");
					if (!string.IsNullOrEmpty(text13))
					{
						string text14 = smethod_10(text8, "value");
						if (!string.IsNullOrEmpty(text7))
						{
							text7 += "&";
						}
						text7 = text7 + text13 + "=" + text14;
					}
					continue;
				}
				if (!text9.Equals("text") && !text9.Equals("password"))
				{
					if (!text9.Equals("submit"))
					{
						continue;
					}
					string text15 = smethod_10(text8, "name");
					if (string.IsNullOrEmpty(text15))
					{
						continue;
					}
					string text16 = smethod_10(text8, "value");
					if (!string.IsNullOrEmpty(text16))
					{
						if (!string.IsNullOrEmpty(text7))
						{
							text7 += "&";
						}
						text7 = text7 + text15 + "=" + text16;
					}
					continue;
				}
				string text17 = smethod_10(text8, "name");
				if (string.IsNullOrEmpty(text17))
				{
					continue;
				}
				string text18 = smethod_10(text8, "value");
				if (!string.IsNullOrEmpty(text18))
				{
					if (!string.IsNullOrEmpty(text7))
					{
						text7 += "&";
					}
					text7 = text7 + text17 + "=" + text18;
					continue;
				}
				text18 = smethod_12(num, "");
				num++;
				if (!string.IsNullOrEmpty(text7))
				{
					text7 += "&";
				}
				text7 = text7 + text17 + "=" + text18;
			}
			regex = new Regex("<textarea\\s+[^>]+>", RegexOptions.IgnoreCase | RegexOptions.Singleline);
			matchCollection2 = regex.Matches(text3);
			foreach (Match item2 in matchCollection2)
			{
				text8 = item2.Value;
				string text19 = smethod_10(text8, "name");
				if (!string.IsNullOrEmpty(text19))
				{
					string text20 = "!S!WCRTESTTEXTAREA" + $"{num:D6}" + "!E!";
					num++;
					if (!string.IsNullOrEmpty(text7))
					{
						text7 += "&";
					}
					text7 = text7 + text19 + "=" + text20;
				}
			}
			string text21 = smethod_13(text3);
			if (!string.IsNullOrEmpty(text21))
			{
				if (!string.IsNullOrEmpty(text7))
				{
					text7 += "&";
				}
				text7 += text21;
			}
			string text22 = "";
			text22 = ((!(text6 == "GET")) ? (text5 + "^" + text7) : (text5 + "?" + text7));
			list.Add(text22);
		}
		return list.ToArray();
	}

	public static string smethod_16(string string_7, int int_5)
	{
		string text = "!S!WCRTESTINPUT" + $"{int_5:D6}";
		if (string_7.IndexOf(text) < 0)
		{
			text = "!S!WCRTESTTEXTAREA" + $"{int_5:D6}";
		}
		Regex regex = new Regex("(?<=(" + text + "))[.\\s\\S]*?(?=(!E!))", RegexOptions.Multiline | RegexOptions.Singleline);
		return regex.Match(string_7).Value;
	}

	public string[] method_40(string string_7)
	{
		List<string> list = new List<string>();
		if (string_7.IndexOf("edit", StringComparison.OrdinalIgnoreCase) >= 0)
		{
			return list.ToArray();
		}
		if (string_7.IndexOf("modify", StringComparison.OrdinalIgnoreCase) >= 0)
		{
			return list.ToArray();
		}
		if (genum4_0 == GEnum4.Stop)
		{
			return list.ToArray();
		}
		try
		{
			HttpWebResponse httpWebResponse = method_28(string_7, GEnum0.GET);
			string string_8 = method_29(httpWebResponse);
			string string_9 = httpWebResponse.ResponseUri.ToString();
			string[] array = method_39(string_8, string_9);
			int num = 0;
			while (true)
			{
				if (num < array.Length)
				{
					string text = array[num];
					GEnum0 gEnum;
					string[] array2;
					if (text.IndexOf('^') < 0)
					{
						gEnum = GEnum0.GET;
						array2 = text.Split(new char[1] { '?' });
					}
					else
					{
						gEnum = GEnum0.POST;
						array2 = text.Split(new char[1] { '^' });
					}
					if (array2.Length >= 2)
					{
						if (WCRSetting.bool_0 || WCRSetting.bool_5)
						{
							string[] array3 = method_35(text, gEnum, string_9);
							string[] array4 = array3;
							foreach (string item in array4)
							{
								list.Add(item);
							}
						}
						if (!WCRSetting.bool_4)
						{
							break;
						}
						string[] array5 = array2[1].Split(new char[1] { '&' });
						for (int j = 0; j < array5.Length; j++)
						{
							string text2 = array2[0];
							string text3 = "";
							for (int k = 0; k < j; k++)
							{
								if (!string.IsNullOrEmpty(text3))
								{
									text3 += "&";
								}
								text3 += array5[k];
							}
							string[] array6 = array5[j].Split(new char[1] { '=' });
							string text4 = array6[0];
							if (text4.ToLower().Equals("submit"))
							{
								continue;
							}
							string string_10 = smethod_2(text2) + "^" + text4.ToLower() + "^XSS";
							if (method_32(string_10))
							{
								continue;
							}
							method_2(string_10);
							if (!string.IsNullOrEmpty(text3))
							{
								text3 += "&";
							}
							text3 = text3 + text4 + "=" + smethod_12(j, "<>%3c%3e%253c%253e");
							for (int l = j + 1; l < array5.Length; l++)
							{
								if (!string.IsNullOrEmpty(text3))
								{
									text3 += "&";
								}
								text3 += array5[l];
							}
							text2 = ((gEnum != 0) ? (text2 + "^" + text3) : (text2 + "?" + text3));
							bool flag = false;
							string_8 = method_30(text2, gEnum);
							string text5 = smethod_16(string_8, j);
							if (!string.IsNullOrEmpty(text5))
							{
								if (text5.IndexOf("<>") >= 0)
								{
									flag = true;
								}
							}
							else if (gEnum == GEnum0.POST)
							{
								string string_11 = method_30(string_7, GEnum0.GET);
								text5 = smethod_16(string_11, j);
								if (!string.IsNullOrEmpty(text5) && text5.IndexOf("<>") >= 0)
								{
									flag = true;
								}
							}
							if (flag)
							{
								string text6 = smethod_6(text2);
								string item2 = string_7 + "^^" + text4 + "^^" + gEnum.ToString() + "^^" + text6 + "^^Cross Site Scripting(Form)";
								list.Add(item2);
							}
						}
					}
					num++;
					continue;
				}
				return list.ToArray();
			}
			return list.ToArray();
		}
		catch
		{
			return list.ToArray();
		}
	}
}
