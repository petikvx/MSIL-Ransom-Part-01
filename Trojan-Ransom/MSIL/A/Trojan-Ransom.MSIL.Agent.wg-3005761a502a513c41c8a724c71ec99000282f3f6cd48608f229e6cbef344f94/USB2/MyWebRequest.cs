using System;
using System.IO;
using System.Net;
using ns0;

namespace USB2;

public class MyWebRequest
{
	private WebRequest webRequest_0;

	private Stream stream_0;

	private string string_0;

	public string Status
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = value;
		}
	}

	public MyWebRequest(string url)
	{
		webRequest_0 = Delegate157.smethod_0(url);
	}

	public MyWebRequest(string url, string method)
		: this(url)
	{
		if (!Delegate170.smethod_0(method, "GET") && !Delegate170.smethod_0(method, "POST"))
		{
			throw new Exception("Invalid Method Type");
		}
		Delegate212.smethod_0(webRequest_0, method);
	}

	public MyWebRequest(string url, string method, string data)
		: this(url, method)
	{
		byte[] array = Delegate227.smethod_0(Delegate279.smethod_0(), data);
		Delegate318.smethod_0(webRequest_0, "application/x-www-form-urlencoded");
		Delegate130.smethod_0(webRequest_0, array.Length);
		stream_0 = Delegate10.smethod_0(webRequest_0);
		Delegate143.smethod_0(stream_0, array, 0, array.Length);
		Delegate41.smethod_0(stream_0);
	}

	public string GetResponse()
	{
		WebResponse webResponse = Delegate24.smethod_0(webRequest_0);
		Delegate305.smethod_0(this, Delegate104.smethod_0((HttpWebResponse)webResponse));
		stream_0 = Delegate239.smethod_0(webResponse);
		StreamReader object_ = Delegate117.smethod_0(stream_0);
		string result = Delegate226.smethod_0(object_);
		Delegate171.smethod_0(object_);
		Delegate41.smethod_0(stream_0);
		Delegate292.smethod_0(webResponse);
		return result;
	}
}
