using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

public class GClass6
{
	public delegate void GDelegate3(string string_0, string string_1, string string_2, string string_3);

	public delegate void GDelegate4(string string_0, int int_0, int int_1);

	public delegate void GDelegate5(string string_0);

	public delegate void GDelegate6(int int_0);

	private string string_0 = "http://s2.travian.dk";

	private bool bool_0;

	private GDelegate3 gdelegate3_0;

	private GDelegate4 gdelegate4_0;

	private GDelegate5 gdelegate5_0;

	private GDelegate5 gdelegate5_1;

	private GDelegate6 gdelegate6_0;

	private ToolStripProgressBar toolStripProgressBar_0;

	private ToolStripStatusLabel toolStripStatusLabel_0;

	private int int_0;

	private int int_1;

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	public void method_0(GDelegate3 gdelegate3_1)
	{
		gdelegate3_0 = (GDelegate3)Delegate.Combine(gdelegate3_0, gdelegate3_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	public void method_1(GDelegate3 gdelegate3_1)
	{
		gdelegate3_0 = (GDelegate3)Delegate.Remove(gdelegate3_0, gdelegate3_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	public void method_2(GDelegate4 gdelegate4_1)
	{
		gdelegate4_0 = (GDelegate4)Delegate.Combine(gdelegate4_0, gdelegate4_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	public void method_3(GDelegate4 gdelegate4_1)
	{
		gdelegate4_0 = (GDelegate4)Delegate.Remove(gdelegate4_0, gdelegate4_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	public void method_4(GDelegate5 gdelegate5_2)
	{
		gdelegate5_0 = (GDelegate5)Delegate.Combine(gdelegate5_0, gdelegate5_2);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	public void method_5(GDelegate5 gdelegate5_2)
	{
		gdelegate5_0 = (GDelegate5)Delegate.Remove(gdelegate5_0, gdelegate5_2);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	public void method_6(GDelegate5 gdelegate5_2)
	{
		gdelegate5_1 = (GDelegate5)Delegate.Combine(gdelegate5_1, gdelegate5_2);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	public void method_7(GDelegate5 gdelegate5_2)
	{
		gdelegate5_1 = (GDelegate5)Delegate.Remove(gdelegate5_1, gdelegate5_2);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	public void method_8(GDelegate6 gdelegate6_1)
	{
		gdelegate6_0 = (GDelegate6)Delegate.Combine(gdelegate6_0, gdelegate6_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	public void method_9(GDelegate6 gdelegate6_1)
	{
		gdelegate6_0 = (GDelegate6)Delegate.Remove(gdelegate6_0, gdelegate6_1);
	}

	[SpecialName]
	public bool method_10()
	{
		return bool_0;
	}

	[SpecialName]
	public void method_11(bool bool_1)
	{
		bool_0 = bool_1;
	}

	[SpecialName]
	public string method_12()
	{
		return string_0;
	}

	[SpecialName]
	public void method_13(string string_1)
	{
		string_0 = string_1;
	}

	public GClass6(ToolStripProgressBar toolStripProgressBar_1, ToolStripStatusLabel toolStripStatusLabel_1)
	{
		toolStripProgressBar_0 = toolStripProgressBar_1;
		toolStripStatusLabel_0 = toolStripStatusLabel_1;
	}

	public GClass6()
	{
		method_13(GClass3.string_0);
	}

	public string method_14(string string_1)
	{
		HttpWebRequest httpWebRequest = method_17(string_1);
		HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		Stream responseStream = httpWebResponse.GetResponseStream();
		StreamReader streamReader = new StreamReader(responseStream, Encoding.UTF8);
		string result = streamReader.ReadToEnd();
		streamReader.Close();
		return result;
	}

	public bool method_15()
	{
		try
		{
			string input = method_14("http://www.cs-network.dk/ASP/Version.aspx");
			Regex regex = new Regex("version([0-9]*)(.)([0-9]*)version", RegexOptions.IgnoreCase);
			Match match = regex.Match(input);
			string string_ = match.Value.Replace("version", "");
			double num = method_26(string_);
			return GClass3.double_1 < num;
		}
		catch
		{
		}
		return false;
	}

	public string method_16(string string_1, string string_2)
	{
		HttpWebRequest httpWebRequest = method_17(string_1);
		httpWebRequest.Method = "POST";
		byte[] bytes = Encoding.UTF8.GetBytes(string_2);
		httpWebRequest.ContentType = "application/x-www-form-urlencoded";
		httpWebRequest.ContentLength = bytes.Length;
		Stream requestStream = httpWebRequest.GetRequestStream();
		requestStream.Write(bytes, 0, bytes.Length);
		requestStream.Close();
		HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		if (GClass3.cookieCollection_0 == null)
		{
			GClass3.cookieCollection_0 = httpWebResponse.Cookies;
		}
		requestStream = httpWebResponse.GetResponseStream();
		StreamReader streamReader = new StreamReader(requestStream);
		string result = streamReader.ReadToEnd();
		streamReader.Close();
		requestStream.Close();
		httpWebResponse.Close();
		return result;
	}

	private HttpWebRequest method_17(string string_1)
	{
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string_1);
		httpWebRequest.CookieContainer = new CookieContainer();
		httpWebRequest.Accept = "image/gif, image/x-xbitmap, image/jpeg, image/pjpeg, application/x-shockwave-flash, application/vnd.ms-excel, application/vnd.ms-powerpoint, application/msword, application/xaml+xml, application/vnd.ms-xpsdocument, application/x-ms-xbap, application/x-ms-application, */*";
		httpWebRequest.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1; .NET CLR 2.0.50727; InfoPath.1; .NET CLR 1.1.4322; .NET CLR 3.0.04506.30)";
		httpWebRequest.Referer = "http://www.google.com";
		httpWebRequest.Headers.Add("UA-CPU: x86");
		httpWebRequest.Headers.Add("Accept-Language: en,ja;q=0.9,fr;q=0.8,de;q=0.7,es;q=0.6,it;q=0.5,nl;q=0.4,sv;q=0.3,nb;q=0.2");
		if (GClass3.cookieCollection_0 != null)
		{
			httpWebRequest.CookieContainer!.Add(httpWebRequest.RequestUri, GClass3.cookieCollection_0);
		}
		httpWebRequest.Credentials = CredentialCache.DefaultCredentials;
		WebProxy webProxy = method_18();
		if (webProxy != null)
		{
			httpWebRequest.Proxy = webProxy;
		}
		return httpWebRequest;
	}

	private WebProxy method_18()
	{
		try
		{
			GClass0 gclass0_ = GClass0.gclass0_0;
			string text = gclass0_.method_6(GClass0.GEnum0.const_0.ToString());
			if (text == null)
			{
				return null;
			}
			if (text.ToLower().Contains("true"))
			{
				string text2 = gclass0_.method_6(GClass0.GEnum0.const_1.ToString());
				string text3 = gclass0_.method_6(GClass0.GEnum0.const_2.ToString());
				string text4 = gclass0_.method_6(GClass0.GEnum0.const_3.ToString());
				string text5 = gclass0_.method_6(GClass0.GEnum0.const_4.ToString());
				WebProxy webProxy = new WebProxy(text2 + ":" + text3 + "/", text4.ToLower().Contains("true"));
				if (text5 != null && text5.ToLower().Contains("true"))
				{
					string userName = gclass0_.method_6(GClass0.GEnum0.const_5.ToString());
					string password = gclass0_.method_6(GClass0.GEnum0.const_6.ToString());
					string text6 = gclass0_.method_6(GClass0.GEnum0.const_7.ToString());
					webProxy.Credentials = new NetworkCredential(userName, password, (text6 != null) ? text6 : "");
				}
				return webProxy;
			}
		}
		catch
		{
			return null;
		}
		return null;
	}

	public bool method_19(string string_1, string string_2)
	{
		string text = method_14(string_0 + "/login.php");
		GClass3.cookieCollection_0 = null;
		string text2 = text.Substring(text.IndexOf("type=\"hidden\" name=\"login\""), 50);
		string text3 = text2.Substring(text2.IndexOf("value") + 7, text2.IndexOf("\">") - text2.IndexOf("value") - 7);
		text2 = text.Substring(text.IndexOf("class=\"fm fm110\" type=\"text\" name=\""), 50);
		string text4 = text2.Substring(text2.IndexOf("name=") + 6, text2.IndexOf("\" value") - text2.IndexOf("name=") - 6);
		text2 = text.Substring(text.IndexOf("class=\"fm fm110\" type=\"password\""), 60);
		string text5 = text2.Substring(text2.IndexOf("name=") + 6, text2.IndexOf("\" value") - text2.IndexOf("name=") - 6);
		text2 = text.Substring(text.IndexOf("<p align=\"center\"><input type=\"hidden\" name=\""), 60);
		string text6 = text2.Substring(text2.IndexOf("name=") + 6, text2.IndexOf("\" value") - text2.IndexOf("name=") - 6);
		string string_3 = "'w=1024%3A1024&login=" + text3 + "&" + text4 + "=" + string_1 + "&" + text5 + "=" + string_2 + "&" + text6 + "=1451c95544&s1.x=45&s1.y=6&s1=login&autologin=ja'\n\n";
		string string_4 = method_16(string_0 + "/dorf1.php", string_3);
		return method_20(string_4);
	}

	private bool method_20(string string_1)
	{
		return string_1.IndexOf("area") > -1;
	}

	public bool method_21()
	{
		string text = method_16(string_0 + "/logout.php", "");
		return text.Contains("login.php?del_cookie");
	}

	public void method_22(int int_2, int int_3, int int_4)
	{
		method_11(bool_1: false);
		int num = int_2 - int_4 * 7;
		int num2 = int_3 - int_4 * 7;
		int num3 = 1 + 2 * int_4;
		int_1 = Math.Max(num3 * num3 / 10, 1);
		int_0 = 0;
		if (gdelegate4_0 != null)
		{
			gdelegate4_0("", 0, num3 * 7 * num3 * 7);
		}
		int num4 = 0;
		while (true)
		{
			if (num4 < num3)
			{
				for (int i = 0; i < num3; i++)
				{
					if (!method_10())
					{
						int int_5 = num + i * 7;
						int int_6 = num2 + num4 * 7;
						string string_ = method_25(int_5, int_6);
						if (method_20(string_))
						{
							method_23(string_);
							continue;
						}
						throw new Exception("Session timed out, please login again.");
					}
					if (gdelegate5_0 != null)
					{
						gdelegate5_0("");
					}
					return;
				}
				num4++;
				continue;
			}
			if (gdelegate5_1 != null)
			{
				gdelegate5_1("");
			}
			break;
		}
	}

	private void method_23(string string_1)
	{
		string_1 = string_1.ToLower();
		Regex regex = new Regex("<area(.*)/>");
		Regex regex2 = new Regex("href\\s*=\\s*(?:\"(?<1>[^\"]*)\"|(?<1>\\S+))", RegexOptions.IgnoreCase | RegexOptions.Compiled);
		MatchCollection matchCollection = regex.Matches(string_1);
		foreach (Match item in matchCollection)
		{
			if (!method_10())
			{
				string value = item.Value;
				Match match2 = regex2.Match(value);
				if (!match2.Success)
				{
					continue;
				}
				string value2 = match2.Value;
				if (value2.IndexOf("karte.php?d=") > -1)
				{
					value2 = value2.Replace("href=", "").Replace("\"", "");
					method_24(value2);
					int_0++;
					if (int_0 % int_1 == 0 && gdelegate6_0 != null)
					{
						gdelegate6_0(int_0);
					}
				}
				continue;
			}
			if (gdelegate5_0 != null)
			{
				gdelegate5_0("");
			}
			break;
		}
	}

	private void method_24(string string_1)
	{
		Regex regex = new Regex("(.*):");
		string_1 = regex.Replace(string_1, "");
		string_1 = string_1.Replace("amp;", "");
		string_1 = string_0 + "/" + string_1;
		string text = method_16(string_1, "");
		if (gdelegate3_0 != null)
		{
			string text2 = "";
			text2 = ((text.IndexOf("div id=\"f1\"") > -1) ? "f1" : ((text.IndexOf("div id=\"f2\"") > -1) ? "f2" : ((text.IndexOf("div id=\"f3\"") > -1) ? "f3" : ((text.IndexOf("div id=\"f4\"") > -1) ? "f4" : ((text.IndexOf("div id=\"f5\"") > -1) ? "f5" : ((text.IndexOf("div id=\"f6\"") <= -1) ? "f?" : "f6"))))));
			Regex regex2 = new Regex("<div.*<h1>(.*)</h1>", RegexOptions.IgnoreCase);
			Match match = regex2.Match(text);
			if (match != null && match.Captures.Count > 0)
			{
				Regex regex3 = new Regex("([\\s]*[\\w]*[\\s]*)*[\\(]([-]*[0-9]*)\\|([-]*[0-9]*)[\\)]([\\s]*[\\w]*[\\s]*)*", RegexOptions.IgnoreCase);
				Match match2 = regex3.Match(match.Value);
				gdelegate3_0(text2, match2.Value, match.Value, text);
			}
		}
	}

	private string method_25(int int_2, int int_3)
	{
		string string_ = string_0 + "/karte.php";
		string string_2 = "xp=" + int_2 + "&yp=" + int_3 + "&s1.x=45&s1.y=6";
		return method_16(string_, string_2);
	}

	private double method_26(string string_1)
	{
		string_1 = string_1.Replace(',', '.');
		double.TryParse(string_1, NumberStyles.Any, CultureInfo.InvariantCulture, out var result);
		return result;
	}
}
