using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;

namespace SEO_BB.Harvester;

public class C2CaptchaService
{
	private string userName = string.Empty;

	private string password = string.Empty;

	private string captchaID = string.Empty;

	private uint major_id;

	private uint minor_id;

	public static uint port = 9816u;

	public static string host = "2captcha.com";

	public static int timeOut = 60000;

	public string proxy = "";

	public string proxyType = "";

	public int secondsDelay = 10000;

	public C2CaptchaService(string username, string pass)
	{
		userName = username;
		password = pass;
		major_id = 0u;
		minor_id = 0u;
	}

	public double GetBalance()
	{
		double result = 0.0;
		try
		{
			HttpWebRequest webRequest = HTMLReader.GetWebRequest("http://2captcha.com/res.php?key=" + userName + "&action=getbalance");
			webRequest.AllowAutoRedirect = false;
			webRequest.Timeout = 3000;
			webRequest.Method = "GET";
			webRequest.ServicePoint.Expect100Continue = false;
			webRequest.Headers.Add("Cache-Control", "max-age=0");
			WebResponse webResponse = null;
			string empty = string.Empty;
			try
			{
				webResponse = webRequest.GetResponse();
				empty = HTMLReader.GetHTML(webResponse);
				result = double.Parse(empty.Trim());
			}
			catch
			{
				result = -1.0;
			}
			finally
			{
				if (webResponse != null)
				{
					webResponse.Close();
					webResponse.Close();
				}
			}
		}
		catch
		{
			result = 0.0;
		}
		finally
		{
		}
		return result;
	}

	private string GetCaptchaText(ref int seconds)
	{
		try
		{
			HttpWebRequest webRequest = HTMLReader.GetWebRequest("http://2captcha.com/res.php?key=" + userName + "&action=get&id=" + captchaID);
			webRequest.AllowAutoRedirect = false;
			webRequest.Timeout = 3000;
			webRequest.Method = "GET";
			webRequest.ServicePoint.Expect100Continue = false;
			webRequest.Headers.Add("Cache-Control", "max-age=0");
			WebResponse webResponse = null;
			string empty = string.Empty;
			try
			{
				webResponse = webRequest.GetResponse();
				empty = HTMLReader.GetHTML(webResponse);
				if (empty.Contains("ERROR_NO_SLOT_AVAILABLE"))
				{
					seconds = 30000;
				}
				else if (empty.Contains("ERROR_ZERO_BALANCE"))
				{
					seconds = 5000;
				}
				else
				{
					if (empty.Contains("ERROR_CAPTCHA_UNSOLVABLE"))
					{
						return null;
					}
					if (empty.Contains("CAPCHA_NOT_READY"))
					{
						seconds = 35000;
					}
					else
					{
						seconds = 15000;
					}
				}
				string[] array = empty.Split(new char[1] { '|' }, StringSplitOptions.RemoveEmptyEntries);
				if (array.Length > 1 && array[0].Trim().Equals("OK"))
				{
					return array[1].Trim();
				}
			}
			catch (WebException ex)
			{
				empty = HTMLReader.GetHTML(ex.Response);
				if (empty.Contains("ERROR_NO_SLOT_AVAILABLE"))
				{
					seconds = 30000;
				}
				else if (empty.Contains("ERROR_ZERO_BALANCE"))
				{
					seconds = 5000;
				}
			}
			catch (Exception)
			{
			}
			finally
			{
				if (webResponse != null)
				{
					webResponse.Close();
					webResponse.Close();
				}
			}
		}
		catch
		{
		}
		finally
		{
		}
		return null;
	}

	public string SolveCaptcha(string key, string url)
	{
		string text = string.Empty;
		try
		{
			string text2 = string.Empty;
			if (!string.IsNullOrWhiteSpace(proxy))
			{
				text2 = "&proxy=" + proxy + "&proxytype=HTTP";
			}
			HttpWebRequest webRequest = HTMLReader.GetWebRequest(string.Concat("http://2captcha.com/in.php?key=" + userName + "&method=userrecaptcha&googlekey=" + key, text2, "&pageurl=", url));
			webRequest.AllowAutoRedirect = false;
			webRequest.Timeout = 3000;
			webRequest.Method = "GET";
			webRequest.ServicePoint.Expect100Continue = false;
			webRequest.Headers.Add("Cache-Control", "max-age=0");
			WebResponse webResponse = null;
			string empty = string.Empty;
			try
			{
				webResponse = webRequest.GetResponse();
				empty = HTMLReader.GetHTML(webResponse);
				if (empty.Contains("ERROR_NO_SLOT_AVAILABLE"))
				{
					secondsDelay = 32000;
				}
				else if (empty.Contains("ERROR_ZERO_BALANCE"))
				{
					secondsDelay = 5200;
				}
				else
				{
					secondsDelay = 20000;
				}
				string[] array = empty.Split(new char[1] { '|' }, StringSplitOptions.RemoveEmptyEntries);
				if (array.Length > 1 && array[0].Trim().Equals("OK"))
				{
					captchaID = array[1].Trim();
					Thread.Sleep(secondsDelay);
					int num = 30;
					while (num > 0)
					{
						text = GetCaptchaText(ref secondsDelay);
						if (string.IsNullOrWhiteSpace(text))
						{
							Thread.Sleep(secondsDelay);
							num--;
							continue;
						}
						break;
					}
				}
			}
			catch
			{
			}
			finally
			{
				if (webResponse != null)
				{
					webResponse.Close();
					webResponse.Close();
				}
			}
		}
		catch
		{
		}
		finally
		{
		}
		return text;
	}

	public string SolveCaptcha(byte[] buffer)
	{
		string text = string.Empty;
		try
		{
			string empty = string.Empty;
			byte[] array = null;
			string empty2 = string.Empty;
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("------WebKitFormBoundarybE4l65B7E7JAwGmq");
			stringBuilder.AppendLine("Content-Disposition: form-data; name=\"method\"");
			stringBuilder.AppendLine();
			stringBuilder.AppendLine("post");
			stringBuilder.AppendLine("------WebKitFormBoundarybE4l65B7E7JAwGmq");
			stringBuilder.AppendLine("Content-Disposition: form-data; name=\"key\"");
			stringBuilder.AppendLine();
			stringBuilder.AppendLine(userName);
			stringBuilder.AppendLine("------WebKitFormBoundarybE4l65B7E7JAwGmq");
			stringBuilder.AppendLine("Content-Disposition: form-data; name=\"file\"; filename=\"captcha.jpg\"");
			stringBuilder.AppendLine("Content-Type: image/jpeg");
			stringBuilder.AppendLine();
			array = buffer;
			empty = stringBuilder.ToString();
			stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("------WebKitFormBoundarybE4l65B7E7JAwGmq--");
			stringBuilder.AppendLine();
			empty2 = stringBuilder.ToString();
			HttpWebRequest webRequest = HTMLReader.GetWebRequest("http://2captcha.com/in.php");
			webRequest.AllowAutoRedirect = false;
			webRequest.Timeout = timeOut;
			webRequest.Method = "POST";
			webRequest.ContentType = "multipart/form-data; boundary=----WebKitFormBoundarybE4l65B7E7JAwGmq";
			webRequest.ContentLength = empty.Length + array.Length + empty2.Length;
			webRequest.ServicePoint.Expect100Continue = false;
			webRequest.Headers.Add("Cache-Control", "max-age=0");
			webRequest.ReadWriteTimeout = 600000;
			webRequest.Timeout = 600000;
			byte[] bytes = Encoding.UTF8.GetBytes(empty.ToString());
			Stream requestStream = webRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			bytes = array;
			requestStream.Write(bytes, 0, bytes.Length);
			bytes = Encoding.UTF8.GetBytes(empty2.ToString());
			requestStream.Write(bytes, 0, bytes.Length);
			requestStream.Close();
			WebResponse webResponse = null;
			string empty3 = string.Empty;
			try
			{
				webResponse = webRequest.GetResponse();
				empty3 = HTMLReader.GetHTML(webResponse);
				string[] array2 = empty3.Split(new char[1] { '|' }, StringSplitOptions.RemoveEmptyEntries);
				if (array2.Length > 1 && array2[0].Trim().Equals("OK"))
				{
					captchaID = array2[1].Trim();
					int num = 3;
					int seconds = 30000;
					Thread.Sleep(30000);
					while (num > 0)
					{
						text = GetCaptchaText(ref seconds);
						if (string.IsNullOrWhiteSpace(text))
						{
							Thread.Sleep(seconds);
							num--;
							continue;
						}
						break;
					}
				}
			}
			catch
			{
			}
			finally
			{
				if (webResponse != null)
				{
					webResponse.Close();
					webResponse.Close();
				}
			}
		}
		catch
		{
		}
		finally
		{
		}
		return text;
	}

	public void BadPicture()
	{
		try
		{
			HttpWebRequest webRequest = HTMLReader.GetWebRequest("action=reportbad&id=" + captchaID);
			webRequest.AllowAutoRedirect = false;
			webRequest.Timeout = 3000;
			webRequest.Method = "GET";
			webRequest.ServicePoint.Expect100Continue = false;
			webRequest.Headers.Add("Cache-Control", "max-age=0");
			WebResponse webResponse = null;
			try
			{
				webResponse = webRequest.GetResponse();
				HTMLReader.GetHTML(webResponse);
			}
			catch
			{
			}
			finally
			{
				if (webResponse != null)
				{
					webResponse.Close();
					webResponse.Close();
				}
			}
		}
		catch
		{
		}
		finally
		{
		}
	}

	public void Close()
	{
	}
}
