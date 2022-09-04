using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

internal class Class11
{
	private static string string_0;

	private static CookieContainer cookieContainer_0 = new CookieContainer();

	public static bool smethod_0()
	{
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://customer.cc.at.paysafecard.com/psccustomer/GetWelcomePanelServlet?language=de");
			httpWebRequest.Method = "GET";
			httpWebRequest.AllowAutoRedirect = true;
			httpWebRequest.CookieContainer = cookieContainer_0;
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			string input = new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
			string_0 = new Regex("id=\"javax.faces.ViewState\" value=\"(.+?)\"").Match(input).Groups[1].Value;
			httpWebRequest = (HttpWebRequest)WebRequest.Create("https://customer.cc.at.paysafecard.com/seam/resource/captcha");
			httpWebRequest.CookieContainer = cookieContainer_0;
			Image image = Image.FromStream(((HttpWebResponse)httpWebRequest.GetResponse()).GetResponseStream());
			Class1.smethod_2().method_0().vmethod_26()
				.set_Image(image);
			((Control)Class1.smethod_2().method_0().vmethod_26()).set_Visible(true);
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}
}
