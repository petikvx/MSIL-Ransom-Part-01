using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;
using PinBot;
using SBLogic.LogicLayer;

namespace BookMarkingSites;

public class PinterestClient : IWebSite
{
	private CHelperFunctions cHelper = new CHelperFunctions();

	private bool isFollowMaxReached = false;

	private IWebProxy proxy;

	private CookieContainer cJar;

	private string postTokenAuthentication = string.Empty;

	private string cookie = string.Empty;

	private string referrer = string.Empty;

	private string captchaType = string.Empty;

	private string DBCUser = string.Empty;

	private string DBCPass = string.Empty;

	private DateTime nextPostTime = DateTime.MinValue;

	private string userAgent = string.Empty;

	private string bitlyToken = string.Empty;

	private string webName = "PInterest";

	private string feedUrl = "";

	private string profilePage = "";

	private bool IsLoginSuccess = false;

	private int downloadStep = 16384;

	public CookieContainer cjarCookie = new CookieContainer();

	private string Origin = string.Empty;

	private string Referer = string.Empty;

	private string Accept = string.Empty;

	private string m_Token;

	private string appVersion = string.Empty;

	public User User = new User();

	private bool IsLogin = false;

	public string clickThroughLink = string.Empty;

	public bool IsFollowMaxReached => isFollowMaxReached;

	public IWebProxy ProxyWeb
	{
		set
		{
			proxy = value;
		}
	}

	public string CaptchaType
	{
		set
		{
			captchaType = value;
		}
	}

	public string DBCUserName
	{
		set
		{
			DBCUser = value;
		}
	}

	public string DBCPassword
	{
		set
		{
			DBCPass = value;
		}
	}

	public DateTime NextPostTime
	{
		set
		{
			nextPostTime = value;
		}
	}

	public string UserAgent
	{
		get
		{
			return userAgent;
		}
		set
		{
			userAgent = value;
		}
	}

	public string BitlyToken
	{
		get
		{
			return bitlyToken;
		}
		set
		{
			bitlyToken = value;
		}
	}

	public string WebName => webName;

	public string WebID => "61";

	public string FeedUrl => feedUrl;

	public string ProfileLike => profilePage;

	public PinterestClient()
	{
		IsLogin = false;
		cjarCookie = new CookieContainer();
		userAgent = HtmlUserAgent.userAgent;
		string text = "c_dpr=1; prompt_views=1; __utma=229774877.310499562.1395036256.1401100932.1404494814.7; __utmb=229774877.26.9.1404496756432; __utmc=229774877; __utmz=229774877.1395036256.1.1.utmcsr=google|utmccn=(organic)|utmcmd=organic|utmctr=(not%20provided);";
		string[] array = text.Split(new char[1] { ';' });
		foreach (string text2 in array)
		{
			if (text2.Contains("="))
			{
				cjarCookie.Add(new Uri("http://www.pinterest.com/"), new Cookie(text2.Split(new char[1] { '=' })[0].Trim(), text2.Split(new char[1] { '=' })[1].Trim()));
			}
		}
	}

	public PinterestClient(CookieContainer ck)
	{
		cjarCookie = ck;
	}

	public string GetGeneralResponse(string url)
	{
		return GetUrl(url, IsCache: false, IsXmlHttp: false, "http://www.pinterest.com/");
	}

	public List<string> GetAllPinsDescriptins(string keyword)
	{
		List<string> result = new List<string>();
		try
		{
			string stringBetween = cHelper.GetStringBetween(HttpUtility.UrlDecode(keyword) + "<thd>", "www.pinterest.com/", "<thd>");
			stringBetween = stringBetween.Replace("/", string.Empty);
			HttpWebResponse httpWebResponse = null;
			string text = "";
			text = keyword;
			if (stringBetween == "")
			{
				stringBetween = cHelper.GetStringBetween(HttpUtility.UrlDecode(keyword) + "<thd>", "www.pinterest", "/");
				if (stringBetween != "")
				{
					stringBetween = cHelper.GetStringBetween(HttpUtility.UrlDecode(keyword) + "<thd>", "www.pinterest" + stringBetween + "/", "<thd>");
				}
			}
			if (stringBetween == "")
			{
				stringBetween = keyword;
			}
			HttpWebRequest httpWebRequest;
			if (!keyword.Contains("https://"))
			{
				text = "https://www.pinterest.com/resource/UserPinsResource/get/?source_url=%2F" + stringBetween + "%2Fpins%2F&data=%7B%22options%22%3A%7B%22is_own_profile_pins%22%3Afalse%2C%22username%22%3A%22" + stringBetween + "%22%2C%22field_set_key%22%3A%22grid_item%22%2C%22pin_filter%22%3Anull%7D%2C%22context%22%3A%7B%7D%7D";
				httpWebRequest = (HttpWebRequest)WebRequest.Create(text);
			}
			else
			{
				httpWebRequest = (HttpWebRequest)WebRequest.Create(keyword);
			}
			if (User.ProxyIp != "" && User.ProxyPort != "")
			{
				httpWebRequest.Proxy = new WebProxy("http://" + User.ProxyIp + ":" + User.ProxyPort);
				if (User.ProxyUsername != "" && User.ProxyPasswords != null)
				{
					httpWebRequest.Proxy!.Credentials = new NetworkCredential(User.ProxyUsername, User.ProxyPasswords);
				}
				else
				{
					httpWebRequest.Proxy!.Credentials = CredentialCache.DefaultCredentials;
				}
			}
			httpWebRequest.Accept = "application/json, text/javascript, */*, q=0.01";
			httpWebRequest.Headers.Add("X-Pinterest-AppState", "active");
			httpWebRequest.Headers.Add("X-Requested-With", "XMLHttpRequest");
			httpWebRequest.Referer = "https://www.pinterest.com/";
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate, br");
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptLanguage, "en-US,en;q=0.9,ur;q=0.8,tr;q=0.7");
			httpWebRequest.UserAgent = userAgent;
			httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			new List<string>();
			string strCont = cHelper.ReadResponse(httpWebResponse);
			httpWebResponse.Close();
			return cHelper.GetListFromString(strCont, "},\"id\":\"", "\"comments\"");
		}
		catch (Exception)
		{
		}
		return result;
	}

	public ResponseType IsLogined()
	{
		string text = Get_General_Request("https://www.pinterest.com/");
		User.Username = cHelper.GetStringBetween(text, "\"isAuth\"", "\"country\"");
		User.Username = cHelper.GetStringBetween(User.Username, "\"username\":\"", "\"");
		if (User.Username == "")
		{
			User.Username = cHelper.GetStringBetween(text, "\"isAuth\"", "\"country\"");
			User.Username = cHelper.GetStringBetween(User.Username, "\"username\": \"", "\"");
		}
		if (text.Contains("Your account is in read-only mode to protect your pins from suspicious activity"))
		{
			return ResponseType.LoginFailed;
		}
		if (!User.Username.Trim().Equals(""))
		{
			IsLoginSuccess = true;
			appVersion = cHelper.GetStringBetween(text, "\"app_version\": \"", "\"");
			if (appVersion == "")
			{
				appVersion = cHelper.GetStringBetween(text, "\"app_version\":\"", "\"");
			}
			Hashtable hashtable = (Hashtable)cjarCookie.GetType().InvokeMember("m_domainTable", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField, null, cjarCookie, new object[0]);
			foreach (object key in hashtable.Keys)
			{
				if (key.ToString()!.Contains("www"))
				{
					foreach (Cookie cookie3 in cjarCookie.GetCookies(new Uri($"https://{key}/")))
					{
						if (cookie3.Name.ToString().Equals("csrftoken"))
						{
							User.Token = cookie3.Value;
						}
					}
					continue;
				}
				foreach (Cookie cookie4 in cjarCookie.GetCookies(new Uri($"https://www{key}/")))
				{
					if (cookie4.Name.ToString().Equals("csrftoken"))
					{
						User.Token = cookie4.Value;
					}
				}
			}
			return ResponseType.LoginSuccess;
		}
		return ResponseType.LoginFailed;
	}

	private string ue(string s)
	{
		return HttpUtility.UrlEncode(s);
	}

	public ResponseType Login(string username, string password)
	{
		if (IsLoginSuccess)
		{
			return ResponseType.LoginSuccess;
		}
		User.Login = username;
		User.Pass = password;
		cjarCookie = new CookieContainer();
		Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
		try
		{
			Referer = "https://www.pinterest.com/";
			GetUrl("https://www.pinterest.com/", IsCache: false, IsXmlHttp: false, string.Empty);
			string url = GetUrl("https://www.pinterest.com/login/", IsCache: false, IsXmlHttp: false, string.Empty);
			if (url.Contains("app_version"))
			{
				appVersion = url.Substring(url.IndexOf("app_version"));
				appVersion = appVersion.Substring(appVersion.IndexOf(":") + 1);
				appVersion = appVersion.Substring(appVersion.IndexOf("\"") + 1);
				appVersion = appVersion.Substring(0, appVersion.IndexOf("\""));
			}
			Referer = "https://www.pinterest.com/login/";
			Origin = "https://www.pinterest.com";
			Accept = "application/json, text/javascript, */*; q=0.01";
			CookieCollection cookies = cjarCookie.GetCookies(new Uri("https://www.pinterest.com/"));
			foreach (Cookie item in cookies)
			{
				if (item.Name.Equals("csrftoken"))
				{
					User.Token = item.Value;
				}
			}
			GetUrl("https://www.pinterest.com/resource/EmailExistsResource/get/?source_url=%2F&data=%7B%22options%22%3A%7B%22email%22%3A%22" + username + "%22%7D%2C%22context%22%3A%7B%7D%7D", IsCache: false, IsXmlHttp: false, string.Empty);
			string body = "source_url=%2F&data=%7B%22options%22%3A%7B%22add_to_experiment%22%3Afalse%2C%22experiment_name%22%3A%22home_guess_name_with_email%22%7D%2C%22context%22%3A%7B%7D%7D";
			string text = PostUrl("https://www.pinterest.com/resource/UserSessionResource/create/", body, IsCache: false, IsXmlHttp: true, string.Empty);
			string body2 = "data=%7B%22options%22%3A%7B%22username_or_email%22%3A%22" + ue(User.Login) + "%22%2C%22password%22%3A%22" + ue(User.Pass) + "%22%7D%2C%22context%22%3A%7B%7D%7D";
			text = PostUrl("https://www.pinterest.com/resource/UserSessionResource/create/", body2, IsCache: false, IsXmlHttp: true, string.Empty);
			body2 = "source_url=%2F&data=%7B%22options%22%3A%7B%22actions%22%3A%5B%7B%22name%22%3A%22login.referrer.unauth_home_react_page.email%22%7D%2C%7B%22name%22%3A%22login.container.home_page.email%22%7D%2C%7B%22name%22%3A%22login.type.email%22%7D%5D%7D%2C%22context%22%3A%7B%7D%7D";
			text = PostUrl("https://www.pinterest.com/resource/UserRegisterTrackActionResource/update/", body2, IsCache: false, IsXmlHttp: true, string.Empty);
			AdjustCookies("https://www.pinterest.com/");
			text = GetUrl("https://www.pinterest.com/", IsCache: false, IsXmlHttp: false, "http://www.pinterest.com/");
			User.Username = cHelper.GetStringBetween(text, "\"isAuth\"", "\"country\"");
			if (User.Username != "")
			{
				User.Username = cHelper.GetStringBetween(User.Username, "\"username\": \"", "\"");
			}
			if (text.Contains("Your account is in read-only mode to protect your pins from suspicious activity"))
			{
				return ResponseType.LoginFailed;
			}
			if (!User.Username.Trim().Equals(""))
			{
				cookies = cjarCookie.GetCookies(new Uri("https://www.pinterest.com/"));
				foreach (Cookie item2 in cookies)
				{
					if (item2.Name.Equals("csrftoken"))
					{
						User.Token = item2.Value;
					}
				}
				feedUrl = "http://www.pinterest.com/" + User.Username + "/feed.rss";
				if (text.Contains("app_version"))
				{
					appVersion = text.Substring(text.IndexOf("app_version"));
					appVersion = appVersion.Substring(appVersion.IndexOf(":") + 1);
					appVersion = appVersion.Substring(appVersion.IndexOf("\"") + 1);
					appVersion = appVersion.Substring(0, appVersion.IndexOf("\""));
				}
				Origin = "http://www.pinterest.com";
				Referer = "http://www.pinterest.com/";
				Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
				IsLoginSuccess = true;
				return ResponseType.LoginSuccess;
			}
			return ResponseType.LoginFailed;
		}
		catch (Exception)
		{
			return ResponseType.LoginFailed;
		}
		finally
		{
		}
	}

	public void StreamToStream(Stream srcStream, Stream destStream)
	{
		long length = srcStream.Length;
		byte[] array = new byte[downloadStep];
		int num = 0;
		while (num < length)
		{
			int num2 = srcStream.Read(array, 0, (int)Math.Min(array.Length, length - num));
			if (num2 != 0)
			{
				num += num2;
				destStream.Write(array, 0, num2);
				_ = srcStream.CanRead;
				_ = destStream.CanWrite;
				continue;
			}
			break;
		}
	}

	public ResponseType BookMark(string url, string title, string desc, string tags, ref string msg, string captchaUser, string captchaPass)
	{
		return ResponseType.Others;
	}

	private string GetUrl(string url, bool IsCache, bool IsXmlHttp, string xreferer)
	{
		try
		{
			HttpWebRequest webRequest = HTMLReader.GetWebRequest(url);
			webRequest.AllowAutoRedirect = true;
			if (User.ProxyIp != "" && User.ProxyPort != "")
			{
				webRequest.Proxy = new WebProxy("http://" + User.ProxyIp + ":" + User.ProxyPort);
				if (User.ProxyUsername != "" && User.ProxyPasswords != null)
				{
					webRequest.Proxy!.Credentials = new NetworkCredential(User.ProxyUsername, User.ProxyPasswords);
				}
				else
				{
					webRequest.Proxy!.Credentials = CredentialCache.DefaultCredentials;
				}
			}
			webRequest.CookieContainer = cjarCookie;
			webRequest.UserAgent = UserAgent;
			if (Accept.Trim().Equals(""))
			{
				Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
			}
			webRequest.Accept = Accept;
			if (!Referer.Trim().Equals(""))
			{
				webRequest.Referer = Referer;
			}
			webRequest.ServicePoint.Expect100Continue = false;
			if (IsCache)
			{
				webRequest.Headers.Add("Cache-Control", "max-age=0");
			}
			if (!Origin.Trim().Equals(""))
			{
				webRequest.Headers.Add("Origin", Origin);
			}
			if (IsXmlHttp)
			{
				webRequest.Headers.Add("X-CSRFToken", User.Token);
				webRequest.Headers.Add("X-Requested-With", "XMLHttpRequest");
				webRequest.Headers.Add("X-NEW-APP", "1");
				webRequest.Headers.Add("X-Pinterest-Referrer", xreferer);
			}
			webRequest.Method = "GET";
			WebResponse response = webRequest.GetResponse();
			string result = string.Empty;
			try
			{
				result = HTMLReader.GetHTML(response);
			}
			finally
			{
				response.Close();
				response.Close();
			}
			return result;
		}
		catch
		{
			return string.Empty;
		}
	}

	private string Get_General_Request(string url)
	{
		HttpWebResponse httpWebResponse = null;
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
			if (User.ProxyIp != "" && User.ProxyPort != "")
			{
				httpWebRequest.Proxy = new WebProxy("http://" + User.ProxyIp + ":" + User.ProxyPort);
				if (User.ProxyUsername != "" && User.ProxyPasswords != null)
				{
					httpWebRequest.Proxy!.Credentials = new NetworkCredential(User.ProxyUsername, User.ProxyPasswords);
				}
				else
				{
					httpWebRequest.Proxy!.Credentials = CredentialCache.DefaultCredentials;
				}
			}
			httpWebRequest.KeepAlive = true;
			httpWebRequest.UserAgent = UserAgent;
			httpWebRequest.Headers.Add("Upgrade-Insecure-Requests", "1");
			httpWebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8";
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate, br");
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptLanguage, "en-US,en;q=0.9,ur;q=0.8,tr;q=0.7");
			httpWebRequest.CookieContainer = cjarCookie;
			httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			string result = cHelper.ReadResponse(httpWebResponse);
			httpWebResponse.Close();
			return result;
		}
		catch (WebException ex)
		{
			if (ex.Status != WebExceptionStatus.ProtocolError)
			{
				return "";
			}
			httpWebResponse = (HttpWebResponse)ex.Response;
		}
		catch (Exception)
		{
			httpWebResponse?.Close();
			return "";
		}
		return "";
	}

	private string GetPinterestUrl(string url, bool IsCache, bool IsXmlHttp, string xreferer)
	{
		try
		{
			HttpWebRequest webRequest = HTMLReader.GetWebRequest(url);
			webRequest.AllowAutoRedirect = true;
			if (User.ProxyIp != "" && User.ProxyPort != "")
			{
				webRequest.Proxy = new WebProxy("http://" + User.ProxyIp + ":" + User.ProxyPort);
				if (User.ProxyUsername != "" && User.ProxyPasswords != null)
				{
					webRequest.Proxy!.Credentials = new NetworkCredential(User.ProxyUsername, User.ProxyPasswords);
				}
				else
				{
					webRequest.Proxy!.Credentials = CredentialCache.DefaultCredentials;
				}
			}
			webRequest.CookieContainer = cjarCookie;
			webRequest.UserAgent = UserAgent;
			if (Accept.Trim().Equals(""))
			{
				Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
			}
			webRequest.Accept = Accept;
			if (!Referer.Trim().Equals(""))
			{
				webRequest.Referer = Referer;
			}
			webRequest.ServicePoint.Expect100Continue = false;
			if (IsCache)
			{
				webRequest.Headers.Add("Cache-Control", "max-age=0");
			}
			if (!Origin.Trim().Equals(""))
			{
				webRequest.Headers.Add("Origin", Origin);
			}
			if (IsXmlHttp)
			{
				webRequest.Headers.Add("X-CSRFToken", User.Token);
				webRequest.Headers.Add("X-Requested-With", "XMLHttpRequest");
				webRequest.Headers.Add("X-NEW-APP", "1");
				webRequest.Headers.Add("X-Pinterest-Referrer", xreferer);
			}
			webRequest.Method = "GET";
			WebResponse response = webRequest.GetResponse();
			string result = string.Empty;
			try
			{
				result = HTMLReader.GetHTML(response);
			}
			finally
			{
				response.Close();
				response.Close();
			}
			return result;
		}
		catch
		{
			return string.Empty;
		}
	}

	private string PostUrl(string url, string body, bool IsCache, bool IsXmlHttp, string xreferer)
	{
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
			if (User.ProxyIp != "" && User.ProxyPort != "")
			{
				httpWebRequest.Proxy = new WebProxy("http://" + User.ProxyIp + ":" + User.ProxyPort);
				if (User.ProxyUsername != "" && User.ProxyPasswords != null)
				{
					httpWebRequest.Proxy!.Credentials = new NetworkCredential(User.ProxyUsername, User.ProxyPasswords);
				}
				else
				{
					httpWebRequest.Proxy!.Credentials = CredentialCache.DefaultCredentials;
				}
			}
			httpWebRequest.KeepAlive = false;
			httpWebRequest.Headers.Add("Origin", "https://www.pinterest.com");
			httpWebRequest.Headers.Add("X-APP-VERSION", appVersion);
			httpWebRequest.Headers.Add("X-Pinterest-AppState", "active");
			httpWebRequest.UserAgent = UserAgent;
			httpWebRequest.ContentType = "application/x-www-form-urlencoded";
			httpWebRequest.Accept = "application/json, text/javascript, */*, q=0.01";
			httpWebRequest.Headers.Add("X-Requested-With", "XMLHttpRequest");
			httpWebRequest.Headers.Add("X-CSRFToken", User.Token);
			httpWebRequest.Referer = "https://www.pinterest.com/";
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate, br");
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptLanguage, "en-US,en;q=0.8,ur;q=0.6,tr;q=0.4");
			httpWebRequest.CookieContainer = cjarCookie;
			httpWebRequest.Method = "POST";
			httpWebRequest.ServicePoint.Expect100Continue = false;
			byte[] bytes = Encoding.UTF8.GetBytes(body);
			httpWebRequest.ContentLength = bytes.Length;
			Stream requestStream = httpWebRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			requestStream.Close();
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			httpWebResponse.Close();
		}
		catch (WebException ex)
		{
			return HTMLReader.GetHTML(ex.Response);
		}
		return "";
	}

	public bool CreateBoard(string category)
	{
		try
		{
			string empty = string.Empty;
			if (GetAllBoardIds(out var response, User.Username))
			{
				empty = cHelper.ReadResponse(response);
				response.Close();
				List<string> listFromString = cHelper.GetListFromString(empty, "type\":\"board\",\"id\":\"", "\"}");
				foreach (string item in listFromString)
				{
					int num = empty.IndexOf("type\":\"board\",\"id\":\"" + item + "\"}");
					string text = empty;
					empty = empty.Substring(0, num + ("type\":\"board\",\"id\":\"" + item + "\"}").Length) + "<thd>";
					empty += text.Substring(num + ("type\":\"board\",\"id\":\"" + item + "\"}").Length + 1, text.Length - (num + ("type\":\"board\",\"id\":\"" + item + "\"}").Length) - 1);
				}
				string stringBetween = cHelper.GetStringBetween(empty, "resource_response\":{", "\"error\"");
				List<string> listFromString2 = cHelper.GetListFromString(stringBetween, "\"name\":\"", "\"");
				listFromString2 = listFromString2.Distinct().ToList();
				_ = listFromString2.Count;
			}
			string str = category;
			Origin = string.Empty;
			Accept = "text/html, */*; q=0.01";
			Referer = "https://www.pinterest.com/" + User.Username + "/";
			string strText = Get_General_Request("https://www.pinterest.com/" + User.Username + "/boards/");
			Accept = "application/json, text/javascript, */*; q=0.01";
			Referer = "https://www.pinterest.com/" + User.Username + "/boards/";
			cHelper.GetStringBetween(strText, "_=", "\"");
			string body = "source_url=%2F" + User.Username + "%2Fboards%2F&data=%7B%22options%22%3A%7B%22name%22%3A%22" + HttpUtility.UrlEncode(str) + "%22%2C%22description%22%3A%22%22%2C%22category%22%3A%22other%22%2C%22privacy%22%3A%22public%22%2C%22collab_board_email%22%3Atrue%2C%22collaborator_invites_enabled%22%3Atrue%7D%2C%22context%22%3A%7B%7D%7D";
			_ = "source_url=%" + User.Username + "%2F&data=%7B%22options%22%3A%7B%22name%22%3A%22" + HttpUtility.UrlEncode(str) + "%22%2C%22description%22%3A%22%22%2C%22category%22%3A%22other%22%2C%22privacy%22%3A%22public%22%2C%22collab_board_email%22%3Atrue%2C%22collaborator_invites_enabled%22%3Atrue%7D%2C%22context%22%3A%7B%7D%7D";
			PostUrl("https://www.pinterest.com/resource/BoardResource/create/", body, IsCache: false, IsXmlHttp: true, Referer);
			Thread.Sleep(2000);
			if (GetAllBoardIds(out response, User.Username))
			{
				empty = cHelper.ReadResponse(response);
				response.Close();
				List<string> listFromString3 = cHelper.GetListFromString(empty, "type\":\"board\",\"id\":\"", "\"}");
				foreach (string item2 in listFromString3)
				{
					int num2 = empty.IndexOf("type\":\"board\",\"id\":\"" + item2 + "\"}");
					string text2 = empty;
					empty = empty.Substring(0, num2 + ("type\":\"board\",\"id\":\"" + item2 + "\"}").Length) + "<thd>";
					empty += text2.Substring(num2 + ("type\":\"board\",\"id\":\"" + item2 + "\"}").Length + 1, text2.Length - (num2 + ("type\":\"board\",\"id\":\"" + item2 + "\"}").Length) - 1);
				}
				string stringBetween2 = cHelper.GetStringBetween(empty, "resource_response\":{", "\"error\"");
				List<string> listFromString4 = cHelper.GetListFromString(stringBetween2, "\"name\":\"", "\"");
				listFromString4 = listFromString4.Distinct().ToList();
				return listFromString4.Any((string x) => x.ToLower().TrimStart(new char[0]).TrimEnd(new char[0]) == category.ToLower().TrimStart(new char[0]).TrimEnd(new char[0]));
			}
		}
		catch (Exception)
		{
			IsLoginSuccess = false;
		}
		finally
		{
		}
		return false;
	}

	private void AdjustCookies(string url)
	{
		try
		{
			CookieCollection cookies = cjarCookie.GetCookies(new Uri("https://www.pinterest.com/"));
			foreach (Cookie item in cookies)
			{
				cjarCookie.Add(new Uri(url), new Cookie(item.Name, item.Value));
			}
		}
		catch
		{
		}
	}

	private string ReadPage(string reff, string url)
	{
		try
		{
			HttpWebRequest webRequest = HTMLReader.GetWebRequest(url);
			webRequest.AllowAutoRedirect = true;
			webRequest.Proxy = proxy;
			webRequest.ServicePoint.Expect100Continue = false;
			if (!string.IsNullOrEmpty(reff))
			{
				webRequest.Referer = reff;
			}
			webRequest.CookieContainer = cjarCookie;
			webRequest.UserAgent = UserAgent;
			webRequest.Method = "GET";
			WebResponse response = webRequest.GetResponse();
			string result = string.Empty;
			try
			{
				result = HTMLReader.GetHTML(response);
			}
			catch
			{
			}
			finally
			{
				response.Close();
				response.Close();
			}
			return result;
		}
		catch (WebException)
		{
		}
		return string.Empty;
	}

	public List<string> GetBoardNames()
	{
		List<string> result = new List<string>();
		if (GetAllBoardIds(out var response, User.Username))
		{
			string text = cHelper.ReadResponse(response);
			response.Close();
			List<string> listFromString = cHelper.GetListFromString(text, "type\":\"board\",\"id\":\"", "\"}");
			foreach (string item in listFromString)
			{
				int num = text.IndexOf("type\":\"board\",\"id\":\"" + item + "\"}");
				string text2 = text;
				text = text.Substring(0, num + ("type\":\"board\",\"id\":\"" + item + "\"}").Length) + "<thd>";
				text += text2.Substring(num + ("type\":\"board\",\"id\":\"" + item + "\"}").Length + 1, text2.Length - (num + ("type\":\"board\",\"id\":\"" + item + "\"}").Length) - 1);
			}
			cHelper.GetStringBetween(text, "resource_response\":{", "\"error\"");
			result = cHelper.GetListFromString(text, "\"name\":\"", "<thd>");
			result = result.Distinct().ToList();
		}
		return result;
	}

	public string GetBoardIdsOfNames(string boardNames, string mainUrl)
	{
		string text = "";
		if (GetAllBoardIds(out var response, User.Username))
		{
			string text2 = cHelper.ReadResponse(response);
			response.Close();
			List<string> listFromString = cHelper.GetListFromString(text2, "type\":\"board\",\"id\":\"", "\"}");
			foreach (string item in listFromString)
			{
				int num = text2.IndexOf("type\":\"board\",\"id\":\"" + item + "\"}");
				string text3 = text2;
				text2 = text2.Substring(0, num + ("type\":\"board\",\"id\":\"" + item + "\"}").Length) + "<thd>";
				text2 += text3.Substring(num + ("type\":\"board\",\"id\":\"" + item + "\"}").Length + 1, text3.Length - (num + ("type\":\"board\",\"id\":\"" + item + "\"}").Length) - 1);
			}
			string stringBetween = cHelper.GetStringBetween(text2, "resource_response\":{", "\"error\"");
			List<string> listFromString2 = cHelper.GetListFromString(stringBetween, "\"name\":\"", "<thd>");
			listFromString2 = listFromString2.Distinct().ToList();
			string[] array = boardNames.Split(new char[1] { ',' });
			text = "";
			string[] array2 = array;
			foreach (string text4 in array2)
			{
				string text5 = text4.TrimStart(new char[0]).TrimEnd(new char[0]).ToLower();
				foreach (string item2 in listFromString2)
				{
					string stringBetween2 = cHelper.GetStringBetween("<" + item2, "<", "\"");
					stringBetween2 = stringBetween2.TrimStart(new char[0]).TrimEnd(new char[0]).ToLower();
					if (text5 == stringBetween2)
					{
						text = text + cHelper.GetStringBetween("<" + item2, "board\",\"id\":\"", "\"") + ",";
					}
				}
			}
		}
		return text;
	}

	public string UploadPin(string username, string imageLocalPath, string caption, string sourceUrl, string boardNames)
	{
		string text = "";
		string text2 = string.Empty;
		string result = "";
		try
		{
			if (Request_www_pinterest_com(out var response, imageLocalPath))
			{
				string strText = cHelper.ReadResponse(response);
				response.Close();
				text = cHelper.GetStringBetween(strText, "\"image_url\": \"", "\"");
			}
			if (text == "")
			{
				return result;
			}
			if (Request_www_pinterest_com_1(out response, text, username))
			{
				string strText = cHelper.ReadResponse(response);
				text2 = cHelper.GetStringBetween(strText, "source_url", "\"");
				text2 = "source_url" + text2;
				response.Close();
			}
			if (caption.Contains("~~"))
			{
				string[] array = caption.Split(new string[1] { "~~" }, StringSplitOptions.None);
				string text3 = array[1];
				caption = array[0];
				if (text3 != "")
				{
					boardNames = text3.Split(new char[1] { '#' })[0];
				}
			}
			if (caption.Contains("^^"))
			{
				string[] array2 = caption.Split(new string[1] { "^^" }, StringSplitOptions.None);
				string text4 = array2[1];
				caption = array2[0];
				if (text4 != "")
				{
					sourceUrl = text4;
				}
			}
			caption = caption.Replace("##", Environment.NewLine);
			string text5 = "";
			if (GetAllBoardIds(out response, User.Username))
			{
				string strText = cHelper.ReadResponse(response);
				response.Close();
				List<string> listFromString = cHelper.GetListFromString(strText, "type\":\"board\",\"id\":\"", "\"}");
				foreach (string item in listFromString)
				{
					int num = strText.IndexOf("type\":\"board\",\"id\":\"" + item + "\"}");
					string text6 = strText;
					strText = strText.Substring(0, num + ("type\":\"board\",\"id\":\"" + item + "\"}").Length) + "<thd>";
					strText += text6.Substring(num + ("type\":\"board\",\"id\":\"" + item + "\"}").Length + 1, text6.Length - (num + ("type\":\"board\",\"id\":\"" + item + "\"}").Length) - 1);
				}
				cHelper.GetStringBetween(strText, "resource_response\":{", "\"error\"");
				List<string> listFromString2 = cHelper.GetListFromString(strText, "\"name\":\"", "<thd>");
				listFromString2 = listFromString2.Distinct().ToList();
				string[] array3 = boardNames.Split(new char[1] { ',' });
				text5 = "";
				string[] array4 = array3;
				foreach (string text7 in array4)
				{
					string text8 = text7.TrimStart(new char[0]).TrimEnd(new char[0]).ToLower();
					foreach (string item2 in listFromString2)
					{
						string stringBetween = cHelper.GetStringBetween("<" + item2, "<", "\"");
						stringBetween = stringBetween.TrimStart(new char[0]).TrimEnd(new char[0]).ToLower();
						if (text8 == stringBetween)
						{
							text5 = text5 + cHelper.GetStringBetween("<" + item2, "board\",\"id\":\"", "\"") + ",";
						}
					}
				}
				if (boardNames != "" && array3.Length != 0 && text5 == "")
				{
					string[] array5 = array3;
					foreach (string category in array5)
					{
						CreateBoard(category);
					}
					text5 = GetBoardIdsOfNames(boardNames, text2);
				}
				if (text5 == "" && listFromString2.Count > 0)
				{
					text5 = listFromString2.ElementAt(new Random().Next(0, listFromString2.Count));
					text5 = cHelper.GetStringBetween("<" + text5, "board\",\"id\":\"", "\"") + ",";
				}
				else if (text5 == "" && listFromString2.Count == 0)
				{
					CreateBoard("Collection");
					if (GetAllBoardIds(out response, User.Username))
					{
						strText = cHelper.ReadResponse(response);
						response.Close();
						listFromString2 = cHelper.GetListFromString(strText, "\"type\":\"board\",\"id\":\"", "\"");
						if (listFromString2.Count > 0)
						{
							text5 = listFromString2.ElementAt(new Random().Next(0, listFromString2.Count));
						}
					}
				}
			}
			if (text5 != "")
			{
				string text9 = text5.TrimEnd(new char[1] { ',' });
				string[] array6 = text9.Split(new char[1] { ',' });
				string[] array7 = array6;
				foreach (string boardId in array7)
				{
					if (caption.Length > 300)
					{
						caption = caption.Substring(0, 300);
					}
					caption = caption.Replace(".", "");
					if (CreatePinResource(out response, text2, username, text, caption, sourceUrl, boardId))
					{
						string strText = cHelper.ReadResponse(response);
						response.Close();
						result = cHelper.GetStringBetween(strText, "\"section\":null,\"id\":\"", "\"");
					}
				}
			}
		}
		catch (Exception)
		{
		}
		return result;
	}

	private static void WriteMultipartBodyToRequest(HttpWebRequest request, string body)
	{
		string[] array = Regex.Split(body, "<!>");
		using MemoryStream memoryStream = new MemoryStream();
		string[] array2 = array;
		foreach (string text in array2)
		{
			byte[] array3 = ((!File.Exists(text)) ? Encoding.UTF8.GetBytes(text.Replace("\r\n", "\n").Replace("\r", "\n").Replace("\n", "\r\n")) : File.ReadAllBytes(text));
			memoryStream.Write(array3, 0, array3.Length);
		}
		request.ContentLength = memoryStream.Length;
		using Stream stream = request.GetRequestStream();
		memoryStream.WriteTo(stream);
	}

	private bool Request_www_pinterest_com(out HttpWebResponse response, string imagePath)
	{
		response = null;
		try
		{
			string text = "";
			if (imagePath.ToLower().Contains(".png"))
			{
				text = "png";
			}
			text = ((!imagePath.ToLower().Contains(".jpg")) ? imagePath.Substring(imagePath.LastIndexOf('.') + 1, imagePath.Length - imagePath.LastIndexOf('.') - 1) : "jpeg");
			FileInfo fileInfo = new FileInfo(imagePath);
			string text2 = fileInfo.Length.ToString();
			DateTime.Now.Ticks.ToString("x");
			string text3 = string.Format("{0:N}", DateTime.Now.Ticks.ToString("x"));
			string text4 = imagePath.Split(new char[1] { '\\' })[imagePath.Split(new char[1] { '\\' }).Length - 1];
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://www.pinterest.com/upload-image/");
			if (User.ProxyIp != "" && User.ProxyPort != "")
			{
				httpWebRequest.Proxy = new WebProxy("http://" + User.ProxyIp + ":" + User.ProxyPort);
				if (User.ProxyUsername != "" && User.ProxyPasswords != null)
				{
					httpWebRequest.Proxy!.Credentials = new NetworkCredential(User.ProxyUsername, User.ProxyPasswords);
				}
				else
				{
					httpWebRequest.Proxy!.Credentials = CredentialCache.DefaultCredentials;
				}
			}
			httpWebRequest.Headers.Add("Origin", "https://www.pinterest.com");
			httpWebRequest.UserAgent = UserAgent;
			httpWebRequest.ContentType = "multipart/form-data; boundary=----WebKitFormBoundary" + text3;
			httpWebRequest.Accept = "application/json";
			httpWebRequest.Headers.Set(HttpRequestHeader.CacheControl, "no-cache");
			httpWebRequest.Headers.Add("X-CSRFToken", User.Token);
			httpWebRequest.Headers.Add("X-Requested-With", "XMLHttpRequest");
			httpWebRequest.Headers.Add("X-UPLOAD-SOURCE", "pinner_uploader");
			httpWebRequest.Referer = "https://www.pinterest.com/";
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate, br");
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptLanguage, "en-US,en;q=0.8,ur;q=0.6,tr;q=0.4");
			httpWebRequest.CookieContainer = cjarCookie;
			httpWebRequest.Method = "POST";
			httpWebRequest.ServicePoint.Expect100Continue = false;
			string body = string.Concat(string.Concat(string.Concat(string.Concat("------WebKitFormBoundary" + text3 + Environment.NewLine + "Content-Disposition: form-data; name=\"qquuid\"\r\n\r\ne89055fd-7344-45af-b7d2-709f251d7586\r\n------WebKitFormBoundary" + text3 + "Content-Disposition: form-data; name=\"qqfilename\"\r\n\r\n" + text4, Environment.NewLine, "------WebKitFormBoundary", text3), Environment.NewLine, "Content-Disposition: form-data; name=\"qqtotalfilesize\"\r\n\r\n", text2, "------WebKitFormBoundary", text3), Environment.NewLine, "Content-Disposition: form-data; name=\"img\"; filename=\"", text4, "\" \r\nContent-Type: image/", text, " ", Environment.NewLine), Environment.NewLine, "<!>", imagePath, "<!>", Environment.NewLine, "    ------WebKitFormBoundary", text3, "--;");
			WriteMultipartBodyToRequest(httpWebRequest, body);
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

	private bool Request_www_pinterest_com_1(out HttpWebResponse response, string imageUrl, string username)
	{
		response = null;
		string text = DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds.ToString();
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://www.pinterest.com/resource/FakePinResource/get/?source_url=%" + username + "%2Fpins%2F&data=%7B%22options%22%3A%7B%22description%22%3A%22%22%2C%22image_url%22%3A%22" + imageUrl + "%22%2C%22upload_metric%22%3A%7B%22source%22%3A%22pinner_upload_standalone%22%7D%7D%2C%22context%22%3A%7B%7D%7D&_=" + text);
			if (User.ProxyIp != "" && User.ProxyPort != "")
			{
				httpWebRequest.Proxy = new WebProxy("http://" + User.ProxyIp + ":" + User.ProxyPort);
				if (User.ProxyUsername != "" && User.ProxyPasswords != null)
				{
					httpWebRequest.Proxy!.Credentials = new NetworkCredential(User.ProxyUsername, User.ProxyPasswords);
				}
				else
				{
					httpWebRequest.Proxy!.Credentials = CredentialCache.DefaultCredentials;
				}
			}
			httpWebRequest.Accept = "application/json, text/javascript, */*, q=0.01";
			httpWebRequest.Headers.Add("X-Pinterest-AppState", "background");
			httpWebRequest.Headers.Add("X-APP-VERSION", appVersion);
			httpWebRequest.Headers.Add("X-Requested-With", "XMLHttpRequest");
			httpWebRequest.UserAgent = UserAgent;
			httpWebRequest.Referer = "https://www.pinterest.com/";
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate, br");
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptLanguage, "en-US,en;q=0.8,ur;q=0.6,tr;q=0.4");
			httpWebRequest.CookieContainer = cjarCookie;
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

	private bool CreatePinResource(out HttpWebResponse response, string url, string username, string imageUrl, string description, string link, string boardId)
	{
		response = null;
		description = description + "\",\"link\":\"" + link;
		description = HttpUtility.UrlEncode(description);
		if (boardId == "")
		{
			return false;
		}
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://www.pinterest.com/resource/PinResource/create/");
			if (User.ProxyIp != "" && User.ProxyPort != "")
			{
				httpWebRequest.Proxy = new WebProxy("http://" + User.ProxyIp + ":" + User.ProxyPort);
				if (User.ProxyUsername != "" && User.ProxyPasswords != null)
				{
					httpWebRequest.Proxy!.Credentials = new NetworkCredential(User.ProxyUsername, User.ProxyPasswords);
				}
				else
				{
					httpWebRequest.Proxy!.Credentials = CredentialCache.DefaultCredentials;
				}
			}
			httpWebRequest.Headers.Add("Origin", "https://www.pinterest.com");
			httpWebRequest.Headers.Add("X-APP-VERSION", appVersion);
			httpWebRequest.Headers.Add("X-Pinterest-AppState", "active");
			httpWebRequest.UserAgent = UserAgent;
			httpWebRequest.ContentType = "application/x-www-form-urlencoded";
			httpWebRequest.Accept = "application/json, text/javascript, */*, q=0.01";
			httpWebRequest.Headers.Add("X-Requested-With", "XMLHttpRequest");
			httpWebRequest.Headers.Add("X-CSRFToken", User.Token);
			httpWebRequest.Referer = "https://www.pinterest.com/";
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate, br");
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptLanguage, "en-US,en;q=0.8,ur;q=0.6,tr;q=0.4");
			httpWebRequest.CookieContainer = cjarCookie;
			httpWebRequest.Method = "POST";
			httpWebRequest.ServicePoint.Expect100Continue = false;
			string s = "source_url=%2F" + username + "%2Fpins%2F&data=%7B%22options%22%3A%7B%22description%22%3A%22" + description + "%22%2C%22upload_metric%22%3A%7B%22source%22%3A%22pinner_upload_standalone%22%7D%2C%22board_id%22%3A%22" + boardId + "%22%2C%22method%22%3A%22uploaded%22%2C%22image_url%22%3A%22" + imageUrl + "%22%2C%22share_facebook%22%3Afalse%2C%22share_twitter%22%3Afalse%7D%2C%22context%22%3A%7B%7D%7D";
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

	private bool GetAllBoardIds(out HttpWebResponse response, string sourceUrl)
	{
		response = null;
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://www.pinterest.com/resource/BoardsResource/get/?source_url=%2F" + sourceUrl + "%2Fboards%2F&data=%7B%22options%22%3A%7B%22username%22%3A%22" + sourceUrl + "%22%2C%22field_set_key%22%3A%22board_picker_react%22%7D%2C%22context%22%3A%7B%7D%7D");
			if (User.ProxyIp != "" && User.ProxyPort != "")
			{
				httpWebRequest.Proxy = new WebProxy("http://" + User.ProxyIp + ":" + User.ProxyPort);
				if (User.ProxyUsername != "" && User.ProxyPasswords != null)
				{
					httpWebRequest.Proxy!.Credentials = new NetworkCredential(User.ProxyUsername, User.ProxyPasswords);
				}
				else
				{
					httpWebRequest.Proxy!.Credentials = CredentialCache.DefaultCredentials;
				}
			}
			httpWebRequest.KeepAlive = true;
			httpWebRequest.Accept = "application/json, text/javascript, */*, q=0.01";
			httpWebRequest.Headers.Add("X-Pinterest-AppState", "active");
			httpWebRequest.Headers.Add("X-APP-VERSION", appVersion);
			httpWebRequest.Headers.Add("X-Requested-With", "XMLHttpRequest");
			httpWebRequest.UserAgent = UserAgent;
			httpWebRequest.Referer = "https://www.pinterest.com/";
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptLanguage, "en-US,en;q=0.8,ur;q=0.6,tr;q=0.4");
			httpWebRequest.CookieContainer = cjarCookie;
			httpWebRequest.Timeout = 8000;
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

	public CookieContainer GetCookies()
	{
		return cjarCookie;
	}

	public string GetProxyTest(string site)
	{
		HttpWebResponse httpWebResponse = null;
		int i = 0;
		string result = "";
		for (; i < 3; i++)
		{
			try
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(site);
				httpWebRequest.Proxy = proxy;
				httpWebRequest.KeepAlive = true;
				httpWebRequest.Headers.Add("Upgrade-Insecure-Requests", "1");
				httpWebRequest.UserAgent = UserAgent;
				httpWebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
				httpWebRequest.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate, sdch, br");
				httpWebRequest.Headers.Set(HttpRequestHeader.AcceptLanguage, "en-US,en;q=0.8");
				httpWebRequest.CookieContainer = cjarCookie;
				httpWebRequest.Timeout = 30000;
				httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				result = cHelper.ReadResponse(httpWebResponse);
				httpWebResponse.Close();
			}
			catch (WebException ex)
			{
				if (ex.Status == WebExceptionStatus.ProtocolError)
				{
					httpWebResponse = (HttpWebResponse)ex.Response;
				}
				continue;
			}
			catch (Exception)
			{
				httpWebResponse?.Close();
				continue;
			}
			break;
		}
		return result;
	}

	private bool GetGeneralResponse(out HttpWebResponse response, string url)
	{
		response = null;
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
			httpWebRequest.UserAgent = UserAgent;
			httpWebRequest.Headers.Add("Upgrade-Insecure-Requests", "1");
			httpWebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8";
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate, br");
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptLanguage, "en-US,en;q=0.9");
			httpWebRequest.CookieContainer = cjarCookie;
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
