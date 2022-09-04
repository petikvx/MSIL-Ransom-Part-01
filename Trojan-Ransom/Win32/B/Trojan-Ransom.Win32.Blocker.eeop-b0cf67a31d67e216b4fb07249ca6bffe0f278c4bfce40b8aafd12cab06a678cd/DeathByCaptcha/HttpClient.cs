using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Web;
using SimpleJson;
using e9a0jRW7WM0ZtAYBQW;

namespace DeathByCaptcha;

public class HttpClient : Client
{
	public const string ServerUrl = "http://api.dbcapi.me/api";

	public const string ResponseContentType = "application/json";

	protected byte[] _payload;

	protected HttpWebResponse _response;

	protected ManualResetEvent _ready;

	public WebProxy Proxy;

	[CompilerGenerated]
	private static RemoteCertificateValidationCallback eVWGumt6p;

	protected void OnTimeout(object state, bool timedOut)
	{
		if (timedOut)
		{
			try
			{
				((HttpWebRequest)state).Abort();
			}
			catch (System.Exception)
			{
			}
		}
	}

	protected void OnReadyToSend(IAsyncResult ar)
	{
		HttpWebRequest httpWebRequest = (HttpWebRequest)ar.AsyncState;
		using (Stream stream = httpWebRequest.EndGetRequestStream(ar))
		{
			stream.Write(_payload, 0, _payload.Length);
		}
		_ready.Set();
	}

	protected void OnReadyToReceive(IAsyncResult ar)
	{
		HttpWebRequest httpWebRequest = (HttpWebRequest)ar.AsyncState;
		try
		{
			_response = (HttpWebResponse)httpWebRequest.EndGetResponse(ar);
		}
		catch (WebException ex)
		{
			_response = (HttpWebResponse)ex.Response;
		}
		catch (System.Exception)
		{
			_response = null;
		}
		_ready.Set();
	}

	protected string SendReceive(string cmd, byte[] payload, string contentType)
	{
		AutoResetEvent waitObject = new AutoResetEvent(initialState: false);
		string text = null;
		DateTime dateTime = DateTime.Now.AddSeconds(60.0);
		string text2 = "http://api.dbcapi.me/api/" + cmd;
		while (dateTime > DateTime.Now && text2 != null)
		{
			Log("SEND", text2.ToString());
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(text2);
			_response = null;
			RegisteredWaitHandle registeredWaitHandle = ThreadPool.RegisterWaitForSingleObject(waitObject, OnTimeout, httpWebRequest, (int)(dateTime - DateTime.Now).TotalMilliseconds, executeOnlyOnce: true);
			httpWebRequest.AllowAutoRedirect = false;
			httpWebRequest.Proxy = Proxy;
			httpWebRequest.Accept = "application/json";
			httpWebRequest.UserAgent = "DBC/.NET v4.1.2";
			httpWebRequest.KeepAlive = false;
			_payload = payload;
			if (0 < _payload.Length)
			{
				httpWebRequest.Expect = string.Empty;
				httpWebRequest.Method = "POST";
				httpWebRequest.ContentType = contentType;
				httpWebRequest.ContentLength = _payload.Length;
				_ready.Reset();
				try
				{
					httpWebRequest.BeginGetRequestStream(OnReadyToSend, httpWebRequest);
				}
				catch (System.Exception innerException)
				{
					throw new IOException("API connection failed", innerException);
				}
				_ready.WaitOne();
			}
			else
			{
				httpWebRequest.Method = "GET";
			}
			text2 = null;
			payload = new byte[0];
			_ready.Reset();
			try
			{
				httpWebRequest.BeginGetResponse(OnReadyToReceive, httpWebRequest);
			}
			catch (System.Exception innerException2)
			{
				throw new IOException("API connection failed", innerException2);
			}
			_ready.WaitOne();
			if (_response != null)
			{
				if (HttpStatusCode.Forbidden == _response.StatusCode)
				{
					throw new AccessDeniedException("Access denied, check your credentials and/or balance");
				}
				if (HttpStatusCode.BadRequest == _response.StatusCode)
				{
					throw new InvalidCaptchaException("CAPTCHA was rejected, please check if it's a valid image");
				}
				if (HttpStatusCode.ServiceUnavailable == _response.StatusCode)
				{
					throw new ServiceOverloadException("CAPTCHA was rejected due to service overload, try again later");
				}
				if (HttpStatusCode.SeeOther == _response.StatusCode)
				{
					try
					{
						text2 = _response.Headers["Location"];
					}
					catch (System.Exception)
					{
					}
				}
				else
				{
					using (StreamReader streamReader = new StreamReader(_response.GetResponseStream(), Encoding.UTF8))
					{
						text = streamReader.ReadToEnd();
					}
					Log("RECV", text);
				}
				try
				{
					_response.Close();
				}
				catch (System.Exception)
				{
				}
			}
			registeredWaitHandle.Unregister(waitObject);
		}
		return text;
	}

	protected Hashtable Call(string cmd, byte[] payload, string contentType)
	{
		if (contentType.Equals(string.Empty))
		{
			contentType = "application/x-www-form-urlencoded";
		}
		string text = null;
		lock (_callLock)
		{
			text = SendReceive(cmd, payload, contentType);
		}
		if (text != null)
		{
			try
			{
				return (Hashtable)Reader.Read(text);
			}
			catch (FormatException)
			{
				return new Hashtable();
			}
		}
		return null;
	}

	protected Hashtable Call(string cmd, Hashtable args)
	{
		string[] array = new string[args.Count];
		int num = 0;
		foreach (DictionaryEntry arg in args)
		{
			array[num] = HttpUtility.UrlEncode((string)arg.Key) + "=" + HttpUtility.UrlEncode((string)arg.Value);
			num++;
		}
		return Call(cmd, Encoding.ASCII.GetBytes(string.Join("&", array)), string.Empty);
	}

	protected Hashtable Call(string cmd)
	{
		return Call(cmd, new Hashtable());
	}

	public HttpClient(string username, string password)
	{
		eZTsNS9ebAJySZpK7R.eLHe04W3E();
		_ready = new ManualResetEvent(initialState: false);
		base._002Ector(username, password);
		ServicePointManager.Expect100Continue = false;
		ServicePointManager.ServerCertificateValidationCallback = (object object_0, X509Certificate x509Certificate_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0) => true;
	}

	public override void Close()
	{
	}

	public override User GetUser()
	{
		return new User(Call("user", base.Credentials));
	}

	public override Captcha GetCaptcha(int id)
	{
		return new Captcha(Call("captcha/" + id));
	}

	public override Captcha Upload(byte[] img)
	{
		string text = BitConverter.ToString(new SHA1CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(DateTime.Now.ToString("G")))).Replace("-", string.Empty);
		Hashtable credentials = base.Credentials;
		credentials["swid"] = Convert.ToString(0);
		string[] array = new string[credentials.Count + 2];
		int num = 0;
		foreach (DictionaryEntry item in credentials)
		{
			string text2 = (string)item.Value;
			array[num++] = string.Join("\r\n", "--" + text, "Content-Disposition: form-data; name=\"" + (string)item.Key + "\"", "Content-Length: " + text2.Length, "", text2);
		}
		array[num++] = string.Join("\r\n", "--" + text, "Content-Disposition: form-data; name=\"captchafile\"; filename=\"captcha.jpeg\"", "Content-Type: application/octet-stream", "Content-Length: " + img.Length, "");
		byte[] bytes = Encoding.ASCII.GetBytes(string.Join("\r\n", array));
		byte[] bytes2 = Encoding.ASCII.GetBytes("\r\n--" + text + "--\r\n");
		byte[] array2 = new byte[bytes.Length + img.Length + bytes2.Length];
		bytes.CopyTo(array2, 0);
		img.CopyTo(array2, bytes.Length);
		bytes2.CopyTo(array2, bytes.Length + img.Length);
		Captcha captcha = new Captcha(Call("captcha", array2, "multipart/form-data; boundary=" + text));
		if (!captcha.Uploaded)
		{
			return null;
		}
		return captcha;
	}

	public override bool Report(int id)
	{
		if (0 < id)
		{
			return !new Captcha(Call("captcha/" + id + "/report", base.Credentials)).Correct;
		}
		return false;
	}

	[CompilerGenerated]
	private static bool eEjF9NMA4(object object_0, X509Certificate x509Certificate_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0)
	{
		return true;
	}
}
