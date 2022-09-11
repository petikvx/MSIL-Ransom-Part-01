using System;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Web;
using System.Xml.Linq;
using DevDefined.OAuth.Framework;
using DevDefined.OAuth.Utility;

namespace DevDefined.OAuth.Consumer;

public class ConsumerRequest : IConsumerRequest
{
	private readonly IOAuthConsumerContext _consumerContext;

	private readonly IOAuthContext _context;

	private readonly IToken _token;

	private string ResponseBody { get; set; }

	public IOAuthConsumerContext ConsumerContext => _consumerContext;

	public IOAuthContext Context => _context;

	public Uri ProxyServerUri { get; set; }

	public Action<string> ResponseBodyAction { get; set; }

	public string AcceptsType { get; set; }

	public int? Timeout { get; set; }

	public string RequestBody { get; set; }

	public ConsumerRequest(IOAuthContext context, IOAuthConsumerContext consumerContext, IToken token)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		if (consumerContext == null)
		{
			throw new ArgumentNullException("consumerContext");
		}
		_context = context;
		_consumerContext = consumerContext;
		_token = token;
	}

	public XDocument ToDocument()
	{
		return XDocument.Parse(ToString());
	}

	public byte[] ToBytes()
	{
		return Convert.FromBase64String(ToString());
	}

	public RequestDescription GetRequestDescription()
	{
		if (string.IsNullOrEmpty(_context.Signature))
		{
			if (_token != null)
			{
				_consumerContext.SignContextWithToken(_context, _token);
			}
			else
			{
				_consumerContext.SignContext(_context);
			}
		}
		Uri url = _context.GenerateUri();
		RequestDescription requestDescription = new RequestDescription();
		requestDescription.Url = url;
		requestDescription.Method = _context.RequestMethod;
		RequestDescription requestDescription2 = requestDescription;
		if (_context.FormEncodedParameters != null && _context.FormEncodedParameters.Count > 0)
		{
			requestDescription2.ContentType = "application/x-www-form-urlencoded; charset=utf-8";
			requestDescription2.Body = UriUtility.FormatQueryString(_context.FormEncodedParameters.ToQueryParametersExcludingTokenSecret());
		}
		else if (!string.IsNullOrEmpty(RequestBody))
		{
			requestDescription2.Body = UriUtility.UrlEncode(RequestBody);
		}
		else if (_context.RawContent != null)
		{
			requestDescription2.ContentType = _context.RawContentType;
			requestDescription2.RawBody = _context.RawContent;
		}
		if (_context.Headers != null)
		{
			requestDescription2.Headers.Add(_context.Headers);
		}
		if (_consumerContext.UseHeaderForOAuthParameters)
		{
			requestDescription2.Headers["Authorization"] = _context.GenerateOAuthParametersForHeader();
		}
		return requestDescription2;
	}

	public HttpWebResponse ToWebResponse()
	{
		try
		{
			HttpWebRequest httpWebRequest = ToWebRequest();
			return (HttpWebResponse)httpWebRequest.GetResponse();
		}
		catch (WebException webEx)
		{
			if (WebExceptionHelper.TryWrapException(Context, webEx, out var authException, ResponseBodyAction))
			{
				throw authException;
			}
			throw;
		}
	}

	public NameValueCollection ToBodyParameters()
	{
		try
		{
			string text = ToString();
			if (ResponseBodyAction != null)
			{
				ResponseBodyAction(text);
			}
			try
			{
				return HttpUtility.ParseQueryString(text);
			}
			catch (ArgumentNullException)
			{
				throw Error.FailedToParseResponse(text);
			}
		}
		catch (WebException innerException)
		{
			throw Error.RequestFailed(innerException);
		}
	}

	public IConsumerRequest SignWithoutToken()
	{
		EnsureRequestHasNotBeenSignedYet();
		_consumerContext.SignContext(_context);
		return this;
	}

	public IConsumerRequest SignWithToken()
	{
		return SignWithToken(_token);
	}

	public IConsumerRequest SignWithToken(IToken token)
	{
		EnsureRequestHasNotBeenSignedYet();
		ConsumerContext.SignContextWithToken(_context, token);
		return this;
	}

	public virtual HttpWebRequest ToWebRequest()
	{
		RequestDescription requestDescription = GetRequestDescription();
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestDescription.Url);
		httpWebRequest.Method = requestDescription.Method;
		httpWebRequest.UserAgent = _consumerContext.UserAgent;
		if (Timeout.HasValue)
		{
			httpWebRequest.Timeout = Timeout.Value;
		}
		if (!string.IsNullOrEmpty(AcceptsType))
		{
			httpWebRequest.Accept = AcceptsType;
		}
		try
		{
			if (Context.Headers["If-Modified-Since"] != null)
			{
				string s = Context.Headers["If-Modified-Since"];
				httpWebRequest.IfModifiedSince = DateTime.Parse(s);
			}
		}
		catch (Exception innerException)
		{
			throw new ApplicationException("If-Modified-Since header could not be parsed as a datetime", innerException);
		}
		if (ProxyServerUri != null)
		{
			httpWebRequest.Proxy = new WebProxy(ProxyServerUri, BypassOnLocal: false);
		}
		if (!string.IsNullOrEmpty(requestDescription.Body))
		{
			httpWebRequest.ContentType = requestDescription.ContentType;
			using StreamWriter streamWriter = new StreamWriter(httpWebRequest.GetRequestStream());
			streamWriter.Write(requestDescription.Body);
		}
		else if (requestDescription.RawBody != null && requestDescription.RawBody.Length > 0)
		{
			httpWebRequest.ContentType = requestDescription.ContentType;
			using BinaryWriter binaryWriter = new BinaryWriter(httpWebRequest.GetRequestStream());
			binaryWriter.Write(requestDescription.RawBody);
		}
		if (requestDescription.Headers.Count > 0)
		{
			string[] allKeys = requestDescription.Headers.AllKeys;
			foreach (string name in allKeys)
			{
				httpWebRequest.Headers[name] = requestDescription.Headers[name];
			}
		}
		return httpWebRequest;
	}

	public override string ToString()
	{
		if (string.IsNullOrEmpty(ResponseBody))
		{
			ResponseBody = ToWebResponse().ReadToEnd();
		}
		return ResponseBody;
	}

	private void EnsureRequestHasNotBeenSignedYet()
	{
		if (!string.IsNullOrEmpty(_context.Signature))
		{
			throw Error.ThisConsumerRequestHasAlreadyBeenSigned();
		}
	}
}
