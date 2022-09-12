using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Gecko.Interop;

namespace Gecko.Net;

public class HttpChannel : Channel
{
	private sealed class HttpHeaderVisitor : nsIHttpHeaderVisitor
	{
		private Action<string, string> _func;

		public HttpHeaderVisitor(Action<string, string> func)
		{
			_func = func;
		}

		void nsIHttpHeaderVisitor.VisitHeader(nsACStringBase aHeader, nsACStringBase aValue)
		{
			_func(aHeader.ToString(), aValue.ToString());
		}
	}

	private nsIHttpChannel _httpChannel;

	public nsIHttpChannel Instance => _httpChannel;

	public string RequestMethod
	{
		get
		{
			return nsString.Get(_httpChannel.GetRequestMethodAttribute);
		}
		set
		{
			nsString.Set(_httpChannel.SetRequestMethodAttribute, value);
		}
	}

	public Uri Referrer
	{
		get
		{
			return Xpcom.TranslateUriAttribute(_httpChannel.GetReferrerAttribute);
		}
		set
		{
			_httpChannel.SetReferrerAttribute(IOService.CreateNsIUri(value.ToString()));
		}
	}

	public bool AllowPipelining
	{
		get
		{
			return _httpChannel.GetAllowPipeliningAttribute();
		}
		set
		{
			_httpChannel.SetAllowPipeliningAttribute(value);
		}
	}

	public uint RedirectionLimit
	{
		get
		{
			return _httpChannel.GetRedirectionLimitAttribute();
		}
		set
		{
			_httpChannel.SetRedirectionLimitAttribute(value);
		}
	}

	public uint ResponseStatus => _httpChannel.GetResponseStatusAttribute();

	public string ResponseStatusText => nsString.Get(_httpChannel.GetResponseStatusTextAttribute);

	public bool RequestSucceeded => _httpChannel.GetRequestSucceededAttribute();

	public bool IsNoStoreResponse => _httpChannel.IsNoStoreResponse();

	public bool IsNoCacheResponse => _httpChannel.IsNoCacheResponse();

	public HttpChannel(nsIHttpChannel httpChannel)
		: base(httpChannel)
	{
		_httpChannel = httpChannel;
	}

	public static HttpChannel Create(nsIHttpChannel httpChannel)
	{
		return new HttpChannel(httpChannel);
	}

	public string GetRequestHeader(string header)
	{
		string result = null;
		try
		{
			result = nsString.Get(_httpChannel.GetRequestHeader, header);
		}
		catch (Exception)
		{
		}
		return result;
	}

	public void SetRequestHeader(string header, string value, bool merge)
	{
		nsString.Set(delegate(nsACString x, nsACString y)
		{
			_httpChannel.SetRequestHeader(x, y, merge);
		}, header, value);
	}

	[Obsolete("use GetRequestHeaders<T>", false)]
	public List<KeyValuePair<string, string>> GetRequestHeaders()
	{
		List<KeyValuePair<string, string>> ret = new List<KeyValuePair<string, string>>();
		HttpHeaderVisitor aVisitor = new HttpHeaderVisitor(delegate(string x, string y)
		{
			ret.Add(new KeyValuePair<string, string>(x, y));
		});
		_httpChannel.VisitRequestHeaders(aVisitor);
		return ret;
	}

	public void GetRequestHeaders<T>(T accumulator, Action<T, string, string> func)
	{
		HttpHeaderVisitor aVisitor = new HttpHeaderVisitor(delegate(string x, string y)
		{
			func(accumulator, x, y);
		});
		_httpChannel.VisitRequestHeaders(aVisitor);
	}

	public Dictionary<string, List<string>> GetRequestHeadersDict()
	{
		Dictionary<string, List<string>> ret = new Dictionary<string, List<string>>();
		HttpHeaderVisitor aVisitor = new HttpHeaderVisitor(delegate(string x, string y)
		{
			List<string> value = null;
			if (ret.TryGetValue(x, out value))
			{
				value.Add(y);
			}
			else
			{
				ret.Add(x, new List<string> { y });
			}
		});
		_httpChannel.VisitRequestHeaders(aVisitor);
		return ret;
	}

	public string GetResponseHeader(string header)
	{
		return nsString.Get(_httpChannel.GetResponseHeader, header);
	}

	public void SetResponseHeader(string header, string value, bool merge)
	{
		nsString.Set(delegate(nsACString x, nsACString y)
		{
			_httpChannel.SetResponseHeader(x, y, merge);
		}, header, value);
	}

	[Obsolete("use GetResponseHeaders<T>", false)]
	public List<KeyValuePair<string, string>> GetResponseHeaders()
	{
		List<KeyValuePair<string, string>> ret = new List<KeyValuePair<string, string>>();
		HttpHeaderVisitor aVisitor = new HttpHeaderVisitor(delegate(string x, string y)
		{
			ret.Add(new KeyValuePair<string, string>(x, y));
		});
		_httpChannel.VisitResponseHeaders(aVisitor);
		return ret;
	}

	public void GetResponseHeaders<T>(T accumulator, Action<T, string, string> func)
	{
		HttpHeaderVisitor aVisitor = new HttpHeaderVisitor(delegate(string x, string y)
		{
			func(accumulator, x, y);
		});
		_httpChannel.VisitResponseHeaders(aVisitor);
	}

	public Dictionary<string, List<string>> GetResponseHeadersDict()
	{
		Dictionary<string, List<string>> ret = new Dictionary<string, List<string>>();
		HttpHeaderVisitor aVisitor = new HttpHeaderVisitor(delegate(string x, string y)
		{
			List<string> value = null;
			if (ret.TryGetValue(x, out value))
			{
				value.Add(y);
			}
			else
			{
				ret.Add(x, new List<string> { y });
			}
		});
		_httpChannel.VisitResponseHeaders(aVisitor);
		return ret;
	}

	public UploadChannel CastToUploadChannel()
	{
		nsIUploadChannel obj = Xpcom.QueryInterface<nsIUploadChannel>(_httpChannel);
		return obj.Wrap((nsIUploadChannel x) => new UploadChannel(x));
	}

	public TraceableChannel CastToTraceableChannel()
	{
		nsITraceableChannel nsITraceableChannel = Xpcom.QueryInterface<nsITraceableChannel>(_httpChannel);
		return (nsITraceableChannel == null) ? null : new TraceableChannel(nsITraceableChannel);
	}

	public static HttpChannel Create(nsISupports supports)
	{
		nsIHttpChannel nsIHttpChannel = Xpcom.QueryInterface<nsIHttpChannel>(supports);
		if (nsIHttpChannel == null)
		{
			return null;
		}
		Marshal.ReleaseComObject(nsIHttpChannel);
		return new HttpChannel((nsIHttpChannel)supports);
	}
}
