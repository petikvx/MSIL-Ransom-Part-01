using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace Target;

public class Request
{
	private string _URL;

	private string _Verb;

	private Form1.SeoPanExtInfo _SeoPanExtInfo;

	private HttpWebRequest _HttpRequest;

	private HttpWebResponse _HttpResponse;

	public CookieContainer CookieContainer = new CookieContainer();

	public string URL
	{
		get
		{
			return _URL;
		}
		set
		{
			_URL = value;
		}
	}

	public string Verb
	{
		get
		{
			return _Verb;
		}
		set
		{
			_Verb = value;
		}
	}

	public string Content => "text/json";

	public Form1.SeoPanExtInfo SeoPanExtInfo
	{
		get
		{
			return _SeoPanExtInfo;
		}
		set
		{
			_SeoPanExtInfo = value;
		}
	}

	public HttpWebRequest HttpRequest
	{
		get
		{
			return _HttpRequest;
		}
		set
		{
			_HttpRequest = value;
		}
	}

	public HttpWebResponse HttpResponse
	{
		get
		{
			return _HttpResponse;
		}
		set
		{
			_HttpResponse = value;
		}
	}

	public Request(string url, string verb)
	{
		URL = url;
		Verb = verb;
	}

	public Request()
	{
		Verb = "GET";
	}

	public object Execute<TT>(string url, object obj, string verb)
	{
		if (url != null)
		{
			URL = url;
		}
		if (verb != null)
		{
			Verb = verb;
		}
		HttpRequest = CreateRequest();
		WriteStream(obj);
		try
		{
			HttpResponse = (HttpWebResponse)HttpRequest.GetResponse();
		}
		catch (WebException ex)
		{
			HttpResponse = (HttpWebResponse)ex.Response;
			return ReadResponseFromError(ex);
		}
		return JsonConvert.DeserializeObject<TT>(ReadResponse());
	}

	public object Execute<TT>(string url)
	{
		if (url != null)
		{
			URL = url;
		}
		HttpRequest = CreateRequest();
		try
		{
			HttpResponse = (HttpWebResponse)HttpRequest.GetResponse();
		}
		catch (WebException ex)
		{
			HttpResponse = (HttpWebResponse)ex.Response;
			return ReadResponseFromError(ex);
		}
		return JsonConvert.DeserializeObject<TT>(ReadResponse());
	}

	public object Execute<TT>()
	{
		if (URL == null)
		{
			throw new ArgumentException("URL cannot be null.");
		}
		HttpRequest = CreateRequest();
		try
		{
			HttpResponse = (HttpWebResponse)HttpRequest.GetResponse();
		}
		catch (WebException ex)
		{
			HttpResponse = (HttpWebResponse)ex.Response;
			return ReadResponseFromError(ex);
		}
		return JsonConvert.DeserializeObject<TT>(ReadResponse());
	}

	public object Execute(string url, object obj, string verb)
	{
		if (url != null)
		{
			URL = url;
		}
		if (verb != null)
		{
			Verb = verb;
		}
		HttpRequest = CreateRequest();
		WriteStream(obj);
		try
		{
			HttpResponse = (HttpWebResponse)HttpRequest.GetResponse();
		}
		catch (WebException ex)
		{
			HttpResponse = (HttpWebResponse)ex.Response;
			return ReadResponseFromError(ex);
		}
		return ReadResponse();
	}

	public object Execute(string url)
	{
		if (url != null)
		{
			URL = url;
		}
		try
		{
			string result = "";
			WebRequest webRequest = WebRequest.Create(url);
			webRequest.Method = "GET";
			using (StreamReader streamReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
			{
				result = streamReader.ReadToEnd();
			}
			return result;
		}
		catch
		{
			HttpRequest = CreateRequest();
			try
			{
				HttpResponse = (HttpWebResponse)HttpRequest.GetResponse();
			}
			catch (WebException ex)
			{
				HttpResponse = (HttpWebResponse)ex.Response;
				return ReadResponseFromError(ex);
			}
			return ReadResponse();
		}
	}

	public object Execute()
	{
		if (URL == null)
		{
			throw new ArgumentException("URL cannot be null.");
		}
		HttpRequest = CreateRequest();
		try
		{
			HttpResponse = (HttpWebResponse)HttpRequest.GetResponse();
		}
		catch (WebException ex)
		{
			HttpResponse = (HttpWebResponse)ex.Response;
			return ReadResponseFromError(ex);
		}
		return ReadResponse();
	}

	internal HttpWebRequest CreateRequest()
	{
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(URL);
		httpWebRequest.ContentType = Content;
		httpWebRequest.Method = Verb;
		httpWebRequest.CookieContainer = CookieContainer;
		return httpWebRequest;
	}

	internal void WriteStream(object obj)
	{
		if (obj == null)
		{
			return;
		}
		using StreamWriter streamWriter = new StreamWriter(HttpRequest.GetRequestStream());
		if (obj is string)
		{
			streamWriter.Write(obj);
		}
		else
		{
			streamWriter.Write(JsonConvert.SerializeObject(obj));
		}
	}

	internal string ReadResponse()
	{
		if (HttpResponse != null)
		{
			using (StreamReader streamReader = new StreamReader(HttpResponse.GetResponseStream()))
			{
				return streamReader.ReadToEnd();
			}
		}
		return string.Empty;
	}

	internal string ReadResponseFromError(WebException error)
	{
		using StreamReader streamReader = new StreamReader(error.Response!.GetResponseStream());
		return streamReader.ReadToEnd();
	}
}
