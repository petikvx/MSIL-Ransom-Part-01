using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace WindowsFormsApplication1;

public class login_poshmark
{
	private const int INTERNET_COOKIE_HTTPONLY = 8192;

	public string user_email
	{
		get
		{
			try
			{
				HtmlDocument htmlDocument = new HtmlDocument();
				for (int i = 0; i < 3; i++)
				{
					if (!Form1.wb.Request_poshmark_com(out var response, "https://poshmark.com/user/account-info", 1, "", ck))
					{
						continue;
					}
					string text = Form1.wb.ReadResponse(response);
					htmlDocument.LoadHtml(text.Replace("\\", ""));
					HtmlNodeCollection htmlNodeCollection = htmlDocument.DocumentNode.SelectNodes("//*[@id='account_info_form_email']");
					if (htmlNodeCollection == null)
					{
						htmlNodeCollection = htmlDocument.DocumentNode.SelectNodes("//*[@class='dropdown-item']");
					}
					if (htmlNodeCollection == null)
					{
						continue;
					}
					using IEnumerator<HtmlNode> enumerator = ((IEnumerable<HtmlNode>)htmlNodeCollection).GetEnumerator();
					if (!enumerator.MoveNext())
					{
						continue;
					}
					HtmlNode current = enumerator.Current;
					return current.Attributes["value"].Value;
				}
			}
			catch
			{
			}
			return null;
		}
	}

	public login_poshmark()
	{
		Form1.wb = new webrequests();
	}

	public void initialized_login(Form1 pm_form)
	{
	}

	[DllImport("wininet.dll", SetLastError = true)]
	private static extern bool InternetGetCookieEx(string url, string cookieName, StringBuilder cookieData, ref int size, int flags, IntPtr pReserved);

	public string GetCookie(string url)
	{
		int size = 512;
		StringBuilder stringBuilder = new StringBuilder(512);
		if (!InternetGetCookieEx(url, null, stringBuilder, ref size, 8192, IntPtr.Zero))
		{
			if (size < 0)
			{
				return null;
			}
			stringBuilder = new StringBuilder(size);
			if (!InternetGetCookieEx(url, null, stringBuilder, ref size, 8192, IntPtr.Zero))
			{
				return null;
			}
		}
		return stringBuilder.ToString();
	}

	public string check_who_is_logined(CookieContainer ck)
	{
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		HtmlDocument htmlDocument = new HtmlDocument();
		HttpWebResponse response;
		for (int i = 0; i < 3; i++)
		{
			if (!Form1.wb.Request_poshmark_com(out response, "https://poshmark.com/feed", 1, "", ck))
			{
				continue;
			}
			string text = Form1.wb.ReadResponse(response);
			htmlDocument.LoadHtml(text.Replace("\\", ""));
			HtmlNodeCollection htmlNodeCollection = htmlDocument.DocumentNode.SelectNodes("//*[@class='dropdown__menu__item']/a");
			if (htmlNodeCollection == null)
			{
				htmlNodeCollection = htmlDocument.DocumentNode.SelectNodes("//*[@class='dropdown-item']");
			}
			if (htmlNodeCollection == null)
			{
				continue;
			}
			foreach (HtmlNode item in (IEnumerable<HtmlNode>)htmlNodeCollection)
			{
				if (!(item.InnerText == "My Closet"))
				{
					continue;
				}
				string value = Regex.Match(item.OuterHtml, "<a.+?href=[\"'](.+?)[\"'].*?>", RegexOptions.IgnoreCase).Groups[1].Value;
				Console.WriteLine("Login User is " + value);
				if (!Form1._canadian_Check)
				{
					if (Form1.wb.Request_poshmark_com(out response, "https://poshmark.com" + value, 1, "", ck))
					{
						string text2 = Form1.wb.ReadResponse(response);
						if (text2.Contains(">In United States. Switch to Canada to see listings in this closet<"))
						{
							try
							{
								object obj = _003C_003Ec._003C_003E9__5_0;
								if (obj == null)
								{
									MethodInvoker val = delegate
									{
										((CheckBox)Form1.pro_configuration_class.canadian_closet_metroCheckBox1).set_Checked(true);
									};
									obj = (object)val;
									_003C_003Ec._003C_003E9__5_0 = val;
								}
								MethodInvoker val2 = (MethodInvoker)obj;
								((Control)Form1.pro_configuration_class).Invoke((Delegate)(object)val2);
								object obj2 = _003C_003Ec._003C_003E9__5_1;
								if (obj2 == null)
								{
									MethodInvoker val3 = delegate
									{
										Form1.mainform.browserToolStripMenuItem_Click(null, null);
									};
									obj2 = (object)val3;
									_003C_003Ec._003C_003E9__5_1 = val3;
								}
								val2 = (MethodInvoker)obj2;
								((Control)Form1.mainform).Invoke((Delegate)(object)val2);
							}
							catch
							{
							}
						}
					}
					Form1._canadian_Check = true;
				}
				return value;
			}
		}
		for (int j = 0; j < 3; j++)
		{
			if (!Form1.wb.Request_poshmark_com(out response, "https://poshmark.com/my-feed", 1, "", ck))
			{
				continue;
			}
			string text3 = Form1.wb.ReadResponse(response);
			htmlDocument.LoadHtml(text3.Replace("\\", ""));
			HtmlNodeCollection htmlNodeCollection2 = htmlDocument.DocumentNode.SelectNodes("//*[@class='dropdown__menu__item']/a");
			if (htmlNodeCollection2 == null)
			{
				htmlNodeCollection2 = htmlDocument.DocumentNode.SelectNodes("//*[@class='dropdown-item']");
			}
			if (htmlNodeCollection2 == null)
			{
				continue;
			}
			foreach (HtmlNode item2 in (IEnumerable<HtmlNode>)htmlNodeCollection2)
			{
				if (item2.InnerText == "My Closet")
				{
					string value2 = Regex.Match(item2.OuterHtml, "<a.+?href=[\"'](.+?)[\"'].*?>", RegexOptions.IgnoreCase).Groups[1].Value;
					Console.WriteLine("Login User is " + value2);
					return value2;
				}
			}
		}
		return null;
	}
}
