using System;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1;

public class webrequests
{
	public bool straight_put(out HttpWebResponse response, string link, CookieContainer ck, string _body)
	{
		response = null;
		string text = link;
		string text2 = "https://poshmark.com";
		string text3 = "https://poshmark.com/feed";
		if (((CheckBox)Form1.pro_configuration_class.canadian_closet_metroCheckBox1).get_Checked())
		{
			text = text.Replace(".com", ".ca");
			text2 = text2.Replace(".com", ".ca");
			text3 = text3.Replace(".com", ".ca");
		}
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(text);
			httpWebRequest.KeepAlive = true;
			httpWebRequest.Accept = "application/json";
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/83.0.4103.116 Safari/537.36";
			httpWebRequest.ContentType = "application/json";
			httpWebRequest.Headers.Add("Origin", "https://poshmark.com");
			httpWebRequest.Headers.Add("Sec-Fetch-Site", "same-origin");
			httpWebRequest.Headers.Add("Sec-Fetch-Mode", "cors");
			httpWebRequest.Headers.Add("Sec-Fetch-Dest", "empty");
			httpWebRequest.Referer = text3;
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate, br");
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptLanguage, "en-US,en;q=0.9");
			httpWebRequest.CookieContainer = ck;
			httpWebRequest.Method = "PUT";
			string s = "{}";
			byte[] bytes = Encoding.UTF8.GetBytes(s);
			httpWebRequest.ContentLength = bytes.Length;
			Stream requestStream = httpWebRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			requestStream.Close();
			response = (HttpWebResponse)httpWebRequest.GetResponse();
		}
		catch (WebException ex)
		{
			if (ex.Status != WebExceptionStatus.ProtocolError)
			{
				return false;
			}
			response = (HttpWebResponse)ex.Response;
		}
		catch (Exception)
		{
			if (response != null)
			{
				response.Close();
			}
			return false;
		}
		return true;
	}

	public bool straight_request(out HttpWebResponse response, string link, CookieContainer ck)
	{
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		response = null;
		try
		{
			string text = link;
			string text2 = "https://poshmark.com";
			string text3 = "https://poshmark.com/feed";
			if (((CheckBox)Form1.pro_configuration_class.canadian_closet_metroCheckBox1).get_Checked())
			{
				text = text.Replace(".com", ".ca");
				text2 = text2.Replace(".com", ".ca");
				text3 = text3.Replace(".com", ".ca");
			}
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(text);
			httpWebRequest.KeepAlive = true;
			httpWebRequest.Accept = "application/json, text/javascript, */*; q=0.01";
			httpWebRequest.Headers.Add("X-Requested-With", "XMLHttpRequest");
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/61.0.3163.91 Safari/537.36";
			httpWebRequest.Referer = text3;
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate, br");
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptLanguage, "en-US,en;q=0.8");
			httpWebRequest.CookieContainer = ck;
			response = (HttpWebResponse)httpWebRequest.GetResponse();
		}
		catch (WebException ex)
		{
			if (ex.Message.Contains("The remote server returned an error: (407) Proxy Authentication Required"))
			{
				MessageBox.Show("The remote server returned an error: (407) Proxy Authentication Required");
			}
			if (ex.Status != WebExceptionStatus.ProtocolError)
			{
				return false;
			}
			response = (HttpWebResponse)ex.Response;
		}
		catch (Exception)
		{
			if (response != null)
			{
				response.Close();
			}
			return false;
		}
		return true;
	}

	public bool Request_poshmark_com_select_all_poshmarket(out HttpWebResponse response, CookieContainer ck, string token)
	{
		string text = "https://poshmark.com/user/update-experience";
		string text2 = "https://poshmark.com";
		string text3 = "https://poshmark.com/feed?login=true";
		if (((CheckBox)Form1.pro_configuration_class.canadian_closet_metroCheckBox1).get_Checked())
		{
			text = text.Replace(".com", ".ca");
			text2 = text2.Replace(".com", ".ca");
			text3 = text3.Replace(".com", ".ca");
		}
		response = null;
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(text);
			httpWebRequest.KeepAlive = true;
			httpWebRequest.Accept = "*/*";
			httpWebRequest.Headers.Add("Origin", text2);
			httpWebRequest.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
			httpWebRequest.Headers.Add("X-CSRF-Token", token);
			httpWebRequest.Headers.Add("X-Requested-With", "XMLHttpRequest");
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/71.0.3578.98 Safari/537.36";
			httpWebRequest.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
			httpWebRequest.Referer = text3;
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate, br");
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptLanguage, "en-US,en;q=0.9");
			httpWebRequest.Headers.Set(HttpRequestHeader.CacheControl, "no-cache");
			httpWebRequest.CookieContainer = ck;
			httpWebRequest.Method = "POST";
			httpWebRequest.ServicePoint.Expect100Continue = false;
			string s = "exp=all";
			byte[] bytes = Encoding.UTF8.GetBytes(s);
			httpWebRequest.ContentLength = bytes.Length;
			Stream requestStream = httpWebRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			requestStream.Close();
			response = (HttpWebResponse)httpWebRequest.GetResponse();
		}
		catch (WebException ex)
		{
			if (ex.Status != WebExceptionStatus.ProtocolError)
			{
				return false;
			}
			response = (HttpWebResponse)ex.Response;
		}
		catch (Exception)
		{
			if (response != null)
			{
				response.Close();
			}
			return false;
		}
		return true;
	}

	public bool Request_poshmark_com(out HttpWebResponse response, string url, int tag, string misc, CookieContainer ck)
	{
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		response = null;
		string text = url;
		string text2 = "https://poshmark.com";
		string text3 = "";
		text3 = tag switch
		{
			1 => "https://poshmark.com/feed?login=true", 
			2 => "https://poshmark.com/feed", 
			_ => "https://poshmark.com/", 
		};
		if (((CheckBox)Form1.pro_configuration_class.canadian_closet_metroCheckBox1).get_Checked())
		{
			text = text.Replace(".com", ".ca");
			text2 = text2.Replace(".com", ".ca");
			text3 = text3.Replace(".com", ".ca");
		}
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(text);
			httpWebRequest.KeepAlive = true;
			httpWebRequest.Headers.Add("Upgrade-Insecure-Requests", "1");
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.186 Safari/537.36";
			httpWebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9";
			httpWebRequest.Referer = text3;
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate, br");
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptLanguage, "en-US,en;q=0.9");
			httpWebRequest.Headers.Add("Sec-Fetch-Site", "same-origin");
			httpWebRequest.Headers.Add("Sec-Fetch-Mode", "navigate");
			httpWebRequest.Headers.Add("Sec-Fetch-User", "?1");
			httpWebRequest.Headers.Add("Sec-Fetch-Dest", "document");
			httpWebRequest.CookieContainer = ck;
			ServicePointManager.Expect100Continue = true;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
			response = (HttpWebResponse)httpWebRequest.GetResponse();
		}
		catch (WebException ex)
		{
			if (!Directory.Exists("logs"))
			{
				Directory.CreateDirectory("logs");
			}
			File.AppendAllText("logs//logs.jk", "1) " + ex.ToString() + "\r\n");
			if (ex.Message.Contains("The remote server returned an error: (407) Proxy Authentication Required"))
			{
				MessageBox.Show("The remote server returned an error: (407) Proxy Authentication Required");
			}
			if (ex.Status != WebExceptionStatus.ProtocolError)
			{
				return false;
			}
			response = (HttpWebResponse)ex.Response;
		}
		catch (Exception)
		{
			if (response != null)
			{
				response.Close();
			}
			return false;
		}
		return true;
	}

	public bool Request_poshmark_com_comment_like(out HttpWebResponse response, string url, string token, int tag, string comment, bool comment_or_not, CookieContainer ck)
	{
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		response = null;
		string text = "";
		text = ((!((CheckBox)Form1.pro_configuration_class.canadian_closet_metroCheckBox1).get_Checked()) ? ((!comment_or_not) ? ("https://poshmark.com/listing/" + url.Substring(url.LastIndexOf("-") + 1, url.Length - (url.LastIndexOf("-") + 1)) + "/like") : ("https://poshmark.com/listing/" + url.Substring(url.LastIndexOf("-") + 1, url.Length - (url.LastIndexOf("-") + 1)) + "/comment")) : ((!comment_or_not) ? ("https://poshmark.ca/listing/" + url.Substring(url.LastIndexOf("-") + 1, url.Length - (url.LastIndexOf("-") + 1)) + "/like") : ("https://poshmark.ca/listing/" + url.Substring(url.LastIndexOf("-") + 1, url.Length - (url.LastIndexOf("-") + 1)) + "/comment")));
		string text2 = "";
		text2 = tag switch
		{
			1 => "https://poshmark.com/feed?login=true", 
			2 => "https://poshmark.com/feed", 
			_ => "https://poshmark.com/", 
		};
		if (((CheckBox)Form1.pro_configuration_class.canadian_closet_metroCheckBox1).get_Checked())
		{
			text2 = text2.Replace(".com", ".ca");
		}
		try
		{
			if (!comment_or_not)
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(text);
				httpWebRequest.KeepAlive = true;
				httpWebRequest.Headers.Add("Upgrade-Insecure-Requests", "1");
				httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.186 Safari/537.36";
				httpWebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8";
				httpWebRequest.Referer = text2;
				httpWebRequest.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate, br");
				httpWebRequest.Headers.Set(HttpRequestHeader.AcceptLanguage, "en-US,en;q=0.9");
				httpWebRequest.CookieContainer = ck;
				ServicePointManager.Expect100Continue = true;
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
				response = (HttpWebResponse)httpWebRequest.GetResponse();
			}
			else
			{
				HttpWebRequest httpWebRequest2 = (HttpWebRequest)WebRequest.Create(text);
				httpWebRequest2.KeepAlive = true;
				httpWebRequest2.Headers.Add("Upgrade-Insecure-Requests", "1");
				httpWebRequest2.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.186 Safari/537.36";
				httpWebRequest2.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8";
				httpWebRequest2.Headers.Add("X-CSRF-Token", token);
				httpWebRequest2.Referer = text2;
				httpWebRequest2.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate, br");
				httpWebRequest2.Headers.Set(HttpRequestHeader.AcceptLanguage, "en-US,en;q=0.9");
				httpWebRequest2.CookieContainer = ck;
				httpWebRequest2.Method = "POST";
				httpWebRequest2.ServicePoint.Expect100Continue = false;
				string s = "utf8=%E2%9C%93&authenticity_token=" + token + "&new_comment=true&comment=" + comment;
				byte[] bytes = Encoding.UTF8.GetBytes(s);
				httpWebRequest2.ContentLength = bytes.Length;
				Stream requestStream = httpWebRequest2.GetRequestStream();
				requestStream.Write(bytes, 0, bytes.Length);
				requestStream.Close();
				ServicePointManager.Expect100Continue = true;
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
				response = (HttpWebResponse)httpWebRequest2.GetResponse();
			}
		}
		catch (WebException ex)
		{
			if (!Directory.Exists("logs"))
			{
				Directory.CreateDirectory("logs");
			}
			File.AppendAllText("logs//logs.jk", "2) " + ex.ToString() + "\r\n");
			if (ex.Message.Contains("The remote server returned an error: (407) Proxy Authentication Required"))
			{
				MessageBox.Show("The remote server returned an error: (407) Proxy Authentication Required");
			}
			if (ex.Status != WebExceptionStatus.ProtocolError)
			{
				return false;
			}
			response = (HttpWebResponse)ex.Response;
		}
		catch (Exception)
		{
			if (response != null)
			{
				response.Close();
			}
			return false;
		}
		return true;
	}

	public string ReadResponse(HttpWebResponse response)
	{
		try
		{
			using Stream stream = response.GetResponseStream();
			Stream stream2 = stream;
			if (response.ContentEncoding.ToLower().Contains("gzip"))
			{
				stream2 = new GZipStream(stream2, CompressionMode.Decompress);
			}
			else if (response.ContentEncoding.ToLower().Contains("deflate"))
			{
				stream2 = new DeflateStream(stream2, CompressionMode.Decompress);
			}
			using StreamReader streamReader = new StreamReader(stream2, Encoding.UTF8);
			return streamReader.ReadToEnd();
		}
		catch
		{
			return "";
		}
	}

	public bool Request_poshmark_com_step1(out HttpWebResponse response, string csrf_token, string user_name, string password, CookieContainer ck)
	{
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		response = null;
		try
		{
			string text = "https://poshmark.com/login";
			string text2 = "https://poshmark.com";
			string text3 = "https://poshmark.com/login";
			if (((CheckBox)Form1.pro_configuration_class.canadian_closet_metroCheckBox1).get_Checked())
			{
				text = text.Replace(".com", ".ca");
				text2 = text2.Replace(".com", ".ca");
				text3 = text3.Replace(".com", ".ca");
			}
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(text);
			httpWebRequest.KeepAlive = true;
			httpWebRequest.Headers.Set(HttpRequestHeader.CacheControl, "max-age=0");
			httpWebRequest.Headers.Add("Origin", text2);
			httpWebRequest.Headers.Add("Upgrade-Insecure-Requests", "1");
			httpWebRequest.ContentType = "application/x-www-form-urlencoded";
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.186 Safari/537.36";
			httpWebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8";
			httpWebRequest.Referer = text3;
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate, br");
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptLanguage, "en-US,en;q=0.9");
			httpWebRequest.CookieContainer = ck;
			httpWebRequest.Method = "POST";
			httpWebRequest.ServicePoint.Expect100Continue = false;
			string s = "utf8=%E2%9C%93&authenticity_token=" + csrf_token + "&login_form%5Biobb%5D=0400nyhffR%2BvPCUNf94lis1ztshEYOhBj8SQ7zRJ4SEK%2Ftx%2BB9YG489wN0OwfSCagD7D7TfUHMAsnWovNLzPeiz1ZT%2FKhUgGeNqKfeXqFvOptJPoI3wPfSLP5wc3%2Bc5%2Fs4JyAGurmwdCpqOHTKUkZ8zWbl1IO8WxD1KhlUJdMxXELpCCuJoygDKlC7I%2BvS3zO1UWKyNRXh0mw7Kb1x4cMpEKIrjEjVFMhgLyi4PvWoIpyZmpr5zlQx90s1eovP7W%2BWpQCv10TaNx%2BXTCCuhAF%2BnK4jEpDoP9KZRBo0l145frPLlVPDYLihDankoqWDbHA4su0%2B1vm3fbD4quAUSAQSG8s90owQNHHqsALyn1uCD1ChVkDI5rhjxCsXBowhJbBEO9MzbHtAh0fojz3wafI%2FWYHEsTCs2TKRSUB860%2FYtAXmzRhLqdI1qchaYiJ%2F%2BIO4wJwtQHr2DgT3vFL0ZMZD89ca0DEJaWk%2FhJwKr0Mf%2BogWbXGwJTIPPVuA6sDyJjVzKCAfZZI2qHQ6%2FU9ek3jOXYhB3%2B1lLYqHZEvsu0hSDxTtbne0Pn%2FWMee7UlT624AE8IzdfxLylYBibsEVBWO8XQIqpa9NvP9z6vD4kNdqyFpzdlYf3u7up4%2FDntEcVmW1kMV3qhf8WVO3WSnrbJSNyIsSmjGMMzIohomH5DQ5wKrsXpSfug1xQFTkrB5yOYdQcs6LuRi%2B5UtR9WRfBd3jXbtgHzj486sjgyUO%2BAInpd%2BUykzlhvKatVjussydRjZjLjFmQWppRl6Bv4pp48B2PR0LUM6Rn3JtHEfF9hXdZ4DRRiwxmZVjl9I5e6IYgLlkuSSBWze4e8Jua7rzbxH0ZCbqQct2fIUhDBy%2FZGi%2FOZc1PWD1Ek94E2JxvvIApWVhTfj9Vx2xW1nbvSIBfLN%2BR0M79MOnRTMthL4qMDk5M2ilFC2dweZ48L7VLB6M5fl2EoZiuy7XetzhEJuvK70bwBpHGL9SBAEfPHBSRpGgPrZlXpxI1YZV0CR0g6csi1i%2BB%2BoDxrhW4B4zTVvRRlbd6dv%2BPKCls0sRkLEbGgzVk1%2Foq%2FSCMRvN0gSp6NwYUSrbXOMupDLTQGMm9%2BpgCd2Ux7tpGQOR3YJIJcPDGBZAe5VzQsBAAQcH4loNwTidneZ5Wedvp3EOKiSx6OC0ceqoTbyG%2Fm3Zqxt3w1Bn6LxoWOnZu64rr07LwRGXZpyc7oQIV63xadNE2jqb6o3IAEdbB%2BxCVNS65m83pQ%2BqMTRH6GRVfg7HAcS5fnS33EPopga4%2FZK1h8TFCICVW3lANmmRye0BJZ6AEDl6uXQP7CwjS%2BxfyVT31SgfbGSaI8fNBXXWV94ljPIghnXbwXiRMbtULROlb9rbbQlrtxZmsJ8pJLKwahcOelCwUAdTFYZliFBpt9%2FmBw%2Fctps5GZjJVUXnbzsEMDW5qVgC68HCuS86kqUEk2Wcme8SbnejTO9HZVQWKolrdzeNWV2gQ%3D&login_form%5Busername_email%5D=" + user_name + "&login_form%5Bpassword%5D=" + password;
			byte[] bytes = Encoding.UTF8.GetBytes(s);
			httpWebRequest.ContentLength = bytes.Length;
			Stream requestStream = httpWebRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			requestStream.Close();
			ServicePointManager.Expect100Continue = true;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
			response = (HttpWebResponse)httpWebRequest.GetResponse();
		}
		catch (WebException ex)
		{
			if (!Directory.Exists("logs"))
			{
				Directory.CreateDirectory("logs");
			}
			File.AppendAllText("logs//logs.jk", "3) " + ex.ToString() + "\r\n");
			if (ex.Message.Contains("The remote server returned an error: (407) Proxy Authentication Required"))
			{
				MessageBox.Show("The remote server returned an error: (407) Proxy Authentication Required");
			}
			if (ex.Status != WebExceptionStatus.ProtocolError)
			{
				return false;
			}
			response = (HttpWebResponse)ex.Response;
		}
		catch (Exception)
		{
			if (response != null)
			{
				response.Close();
			}
			return false;
		}
		return true;
	}

	public bool Request_poshmark_com_for_captcha_post(out HttpWebResponse response, string token, string captcha_response, CookieContainer ck, string type)
	{
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		response = null;
		try
		{
			string text = "https://poshmark.com/captcha";
			string text2 = "https://poshmark.com";
			string text3 = "https://poshmark.com/feed";
			if (((CheckBox)Form1.pro_configuration_class.canadian_closet_metroCheckBox1).get_Checked())
			{
				text = text.Replace(".com", ".ca");
				text2 = text2.Replace(".com", ".ca");
				text3 = text3.Replace(".com", ".ca");
			}
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(text);
			httpWebRequest.KeepAlive = true;
			httpWebRequest.Headers.Add("Origin", text2);
			httpWebRequest.Headers.Add("X-CSRF-Token", token);
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.186 Safari/537.36";
			httpWebRequest.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
			httpWebRequest.Accept = "application/json, text/javascript, */*; q=0.01";
			httpWebRequest.Headers.Add("X-Requested-With", "XMLHttpRequest");
			httpWebRequest.Referer = text3;
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate, br");
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptLanguage, "en-US,en;q=0.9");
			httpWebRequest.CookieContainer = ck;
			httpWebRequest.Method = "POST";
			httpWebRequest.ServicePoint.Expect100Continue = false;
			string s = "authenticity_token=" + token.Replace("=", "%3D") + "&restricted_action=" + type + "&g-recaptcha-response=" + captcha_response;
			byte[] bytes = Encoding.UTF8.GetBytes(s);
			httpWebRequest.ContentLength = bytes.Length;
			Stream requestStream = httpWebRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			requestStream.Close();
			ServicePointManager.Expect100Continue = true;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
			response = (HttpWebResponse)httpWebRequest.GetResponse();
		}
		catch (WebException ex)
		{
			if (!Directory.Exists("logs"))
			{
				Directory.CreateDirectory("logs");
			}
			File.AppendAllText("logs//logs.jk", "4) " + ex.ToString() + "\r\n");
			if (ex.Message.Contains("The remote server returned an error: (407) Proxy Authentication Required"))
			{
				MessageBox.Show("The remote server returned an error: (407) Proxy Authentication Required");
			}
			if (ex.Status != WebExceptionStatus.ProtocolError)
			{
				return false;
			}
			response = (HttpWebResponse)ex.Response;
		}
		catch (Exception)
		{
			if (response != null)
			{
				response.Close();
			}
			return false;
		}
		return true;
	}

	public bool Request_poshmark_com_step2(out HttpWebResponse response, string csrf_token, string user_name, string password, string caprcha_response, string ibobb_id, CookieContainer ck)
	{
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		response = null;
		string text = "https://poshmark.com/login";
		string text2 = "https://poshmark.com";
		string text3 = "https://poshmark.com/login";
		if (((CheckBox)Form1.pro_configuration_class.canadian_closet_metroCheckBox1).get_Checked())
		{
			text = text.Replace(".com", ".ca");
			text2 = text2.Replace(".com", ".ca");
			text3 = text3.Replace(".com", ".ca");
		}
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(text);
			httpWebRequest.KeepAlive = true;
			httpWebRequest.Headers.Set(HttpRequestHeader.CacheControl, "max-age=0");
			httpWebRequest.Headers.Add("Origin", text2);
			httpWebRequest.Headers.Add("Upgrade-Insecure-Requests", "1");
			httpWebRequest.ContentType = "application/x-www-form-urlencoded";
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.186 Safari/537.36";
			httpWebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8";
			httpWebRequest.Referer = text3;
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate, br");
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptLanguage, "en-US,en;q=0.9");
			httpWebRequest.CookieContainer = ck;
			httpWebRequest.Method = "POST";
			httpWebRequest.ServicePoint.Expect100Continue = false;
			string s = "utf8=%E2%9C%93&authenticity_token=" + csrf_token + "&login_form%5Biobb%5D=" + ibobb_id + "&login_form%5Busername_email%5D=" + user_name + "&login_form%5Bpassword%5D=" + password + "&g-recaptcha-response=" + caprcha_response;
			byte[] bytes = Encoding.UTF8.GetBytes(s);
			httpWebRequest.ContentLength = bytes.Length;
			Stream requestStream = httpWebRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			requestStream.Close();
			ServicePointManager.Expect100Continue = true;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
			response = (HttpWebResponse)httpWebRequest.GetResponse();
		}
		catch (WebException ex)
		{
			if (!Directory.Exists("logs"))
			{
				Directory.CreateDirectory("logs");
			}
			File.AppendAllText("logs//logs.jk", "5) " + ex.ToString() + "\r\n");
			if (ex.Message.Contains("The remote server returned an error: (407) Proxy Authentication Required"))
			{
				MessageBox.Show("The remote server returned an error: (407) Proxy Authentication Required");
			}
			if (ex.Status != WebExceptionStatus.ProtocolError)
			{
				return false;
			}
			response = (HttpWebResponse)ex.Response;
		}
		catch (Exception)
		{
			if (response != null)
			{
				response.Close();
			}
			return false;
		}
		return true;
	}

	public bool Request_poshmark_com_share_listing(out HttpWebResponse response, string link, string csrf_token, CookieContainer ck)
	{
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		response = null;
		string text = link;
		string text2 = "https://poshmark.com";
		string text3 = "https://poshmark.com/feed";
		if (((CheckBox)Form1.pro_configuration_class.canadian_closet_metroCheckBox1).get_Checked())
		{
			text = text.Replace(".com", ".ca");
			text2 = text2.Replace(".com", ".ca");
			text3 = text3.Replace(".com", ".ca");
		}
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(text);
			httpWebRequest.Accept = "*/*";
			httpWebRequest.KeepAlive = true;
			httpWebRequest.Headers.Add("Origin", text2);
			httpWebRequest.Headers.Add("X-CSRF-Token", csrf_token);
			httpWebRequest.Headers.Add("X-Requested-With", "XMLHttpRequest");
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/61.0.3163.91 Safari/537.36";
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate, br");
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptLanguage, "en-US,en;q=0.8");
			httpWebRequest.Referer = text3;
			httpWebRequest.CookieContainer = ck;
			httpWebRequest.Method = "POST";
			httpWebRequest.ServicePoint.Expect100Continue = false;
			string s = "";
			byte[] bytes = Encoding.UTF8.GetBytes(s);
			httpWebRequest.ContentLength = bytes.Length;
			Stream requestStream = httpWebRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			requestStream.Close();
			ServicePointManager.Expect100Continue = true;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
			response = (HttpWebResponse)httpWebRequest.GetResponse();
		}
		catch (WebException ex)
		{
			if (!Directory.Exists("logs"))
			{
				Directory.CreateDirectory("logs");
			}
			File.AppendAllText("logs//logs.jk", "6) " + ex.ToString() + "\r\n");
			if (ex.Message.Contains("The remote server returned an error: (407) Proxy Authentication Required"))
			{
				MessageBox.Show("The remote server returned an error: (407) Proxy Authentication Required");
			}
			if (ex.Status != WebExceptionStatus.ProtocolError)
			{
				return false;
			}
			response = (HttpWebResponse)ex.Response;
		}
		catch (Exception)
		{
			if (response != null)
			{
				response.Close();
			}
			return false;
		}
		return true;
	}

	public bool Request_to_website_follow(out HttpWebResponse response, int a, string url, string csrf_token, CookieContainer ck, bool follow_unfollow)
	{
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		response = null;
		try
		{
			string text = url;
			string text2 = "https://poshmark.com";
			string text3 = "https://poshmark.com/feed";
			if (((CheckBox)Form1.pro_configuration_class.canadian_closet_metroCheckBox1).get_Checked())
			{
				text = text.Replace(".com", ".ca");
				text2 = text2.Replace(".com", ".ca");
				text3 = text3.Replace(".com", ".ca");
			}
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(text);
			httpWebRequest.KeepAlive = true;
			httpWebRequest.Headers.Add("Upgrade-Insecure-Requests", "1");
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.186 Safari/537.36";
			httpWebRequest.Accept = "application/json";
			httpWebRequest.Referer = text3;
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate, br");
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptLanguage, "en-US,en;q=0.9");
			httpWebRequest.CookieContainer = ck;
			if (follow_unfollow)
			{
				httpWebRequest.Method = "PUT";
			}
			else
			{
				httpWebRequest.Method = "DELETE";
			}
			string s = "{}";
			byte[] bytes = Encoding.UTF8.GetBytes(s);
			httpWebRequest.ContentLength = bytes.Length;
			Stream requestStream = httpWebRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			requestStream.Close();
			ServicePointManager.Expect100Continue = true;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
			response = (HttpWebResponse)httpWebRequest.GetResponse();
		}
		catch (WebException ex)
		{
			if (!Directory.Exists("logs"))
			{
				Directory.CreateDirectory("logs");
			}
			File.AppendAllText("logs//logs.jk", "7) " + ex.ToString() + "\r\n");
			if (ex.Message.Contains("The remote server returned an error: (407) Proxy Authentication Required"))
			{
				MessageBox.Show("The remote server returned an error: (407) Proxy Authentication Required");
			}
			if (ex.Status != WebExceptionStatus.ProtocolError)
			{
				return false;
			}
			response = (HttpWebResponse)ex.Response;
		}
		catch (Exception)
		{
			if (response != null)
			{
				response.Close();
			}
			return false;
		}
		return true;
	}

	public bool Request_poshmark_com_simple_request_feed(out HttpWebResponse response, string link, CookieContainer ck)
	{
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		response = null;
		string text = link;
		string text2 = "https://poshmark.com";
		string text3 = "https://poshmark.com/feed";
		if (((CheckBox)Form1.pro_configuration_class.canadian_closet_metroCheckBox1).get_Checked())
		{
			text = text.Replace(".com", ".ca");
			text2 = text2.Replace(".com", ".ca");
			text3 = text3.Replace(".com", ".ca");
		}
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(text);
			ServicePointManager.Expect100Continue = true;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
			httpWebRequest.KeepAlive = true;
			if (!link.Contains("Meet%20the%20Posher"))
			{
				httpWebRequest.Accept = "application/json, text/javascript, */*; q=0.01";
			}
			httpWebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9";
			httpWebRequest.Headers.Add("X-Requested-With", "XMLHttpRequest");
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/61.0.3163.91 Safari/537.36";
			httpWebRequest.Referer = text3;
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate, br");
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptLanguage, "en-US,en;q=0.8");
			httpWebRequest.CookieContainer = ck;
			response = (HttpWebResponse)httpWebRequest.GetResponse();
		}
		catch (WebException ex)
		{
			if (!Directory.Exists("logs"))
			{
				Directory.CreateDirectory("logs");
			}
			File.AppendAllText("logs//logs.jk", "8) " + ex.ToString() + "\r\n");
			if (ex.Message.Contains("The remote server returned an error: (407) Proxy Authentication Required"))
			{
				MessageBox.Show("The remote server returned an error: (407) Proxy Authentication Required");
			}
			if (ex.Status != WebExceptionStatus.ProtocolError)
			{
				return false;
			}
			response = (HttpWebResponse)ex.Response;
		}
		catch (Exception)
		{
			if (response != null)
			{
				response.Close();
			}
			return false;
		}
		return true;
	}

	public bool Request_poshmark_com_send_offer(out HttpWebResponse response, string link, CookieContainer ck, string body_cus, string csrf_token)
	{
		response = null;
		string text = link;
		string text2 = "https://poshmark.com";
		string text3 = "https://poshmark.com/feed";
		if (((CheckBox)Form1.pro_configuration_class.canadian_closet_metroCheckBox1).get_Checked())
		{
			text = text.Replace(".com", ".ca");
			text2 = text2.Replace(".com", ".ca");
			text3 = text3.Replace(".com", ".ca");
		}
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(text);
			httpWebRequest.KeepAlive = true;
			httpWebRequest.Headers.Add("sec-ch-ua", "\"Chromium\";v=\"88\", \"Google Chrome\";v=\"88\", \";Not A Brand\";v=\"99\"");
			httpWebRequest.Accept = "application/json";
			httpWebRequest.Headers.Add("X-CSRF-Token", csrf_token);
			httpWebRequest.Headers.Add("sec-ch-ua-mobile", "?0");
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/88.0.4324.150 Safari/537.36";
			httpWebRequest.ContentType = "application/json";
			httpWebRequest.Headers.Add("Origin", text2);
			httpWebRequest.Headers.Add("Sec-Fetch-Site", "same-origin");
			httpWebRequest.Headers.Add("Sec-Fetch-Mode", "cors");
			httpWebRequest.Headers.Add("Sec-Fetch-Dest", "empty");
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate, br");
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptLanguage, "en-US,en;q=0.9");
			httpWebRequest.CookieContainer = ck;
			httpWebRequest.Method = "POST";
			httpWebRequest.ServicePoint.Expect100Continue = false;
			byte[] bytes = Encoding.UTF8.GetBytes(body_cus);
			httpWebRequest.ContentLength = bytes.Length;
			Stream requestStream = httpWebRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			requestStream.Close();
			response = (HttpWebResponse)httpWebRequest.GetResponse();
		}
		catch (WebException ex)
		{
			if (ex.Status != WebExceptionStatus.ProtocolError)
			{
				return false;
			}
			response = (HttpWebResponse)ex.Response;
		}
		catch (Exception)
		{
			if (response != null)
			{
				response.Close();
			}
			return false;
		}
		return true;
	}
}
