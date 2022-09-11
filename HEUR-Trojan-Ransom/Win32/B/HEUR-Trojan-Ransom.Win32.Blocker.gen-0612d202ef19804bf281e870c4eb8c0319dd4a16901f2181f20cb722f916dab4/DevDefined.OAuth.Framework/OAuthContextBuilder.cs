using System;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Web;

namespace DevDefined.OAuth.Framework;

public class OAuthContextBuilder : IOAuthContextBuilder
{
	private readonly Func<Uri, Uri> _uriAdjuster;

	private readonly Func<Uri, Uri> _emptyUriAdjuster = (Uri uri) => uri;

	public OAuthContextBuilder(Func<Uri, Uri> uriAdjuster)
	{
		_uriAdjuster = uriAdjuster ?? _emptyUriAdjuster;
	}

	public OAuthContextBuilder()
		: this(null)
	{
	}

	public virtual IOAuthContext FromUrl(string httpMethod, string url)
	{
		if (string.IsNullOrEmpty(url))
		{
			throw new ArgumentNullException("url");
		}
		if (!Uri.TryCreate(url, UriKind.RelativeOrAbsolute, out var result))
		{
			throw new ArgumentException($"Failed to parse url: {url} into a valid Uri instance");
		}
		return FromUri(httpMethod, result);
	}

	public virtual IOAuthContext FromUri(string httpMethod, Uri uri)
	{
		uri = CleanUri(uri);
		if (httpMethod == null)
		{
			throw new ArgumentNullException("httpMethod");
		}
		if (uri == null)
		{
			throw new ArgumentNullException("uri");
		}
		OAuthContext oAuthContext = new OAuthContext();
		oAuthContext.RawUri = CleanUri(uri);
		oAuthContext.RequestMethod = httpMethod;
		return oAuthContext;
	}

	public virtual IOAuthContext FromHttpRequest(HttpRequest request)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return FromHttpRequest((HttpRequestBase)new HttpRequestWrapper(request));
	}

	public virtual IOAuthContext FromHttpRequest(HttpRequestBase request)
	{
		OAuthContext oAuthContext = new OAuthContext();
		oAuthContext.RawUri = CleanUri(request.get_Url());
		oAuthContext.Cookies = CollectCookies(request);
		oAuthContext.Headers = GetCleanedNameValueCollection(request.get_Headers());
		oAuthContext.RequestMethod = request.get_HttpMethod();
		oAuthContext.FormEncodedParameters = GetCleanedNameValueCollection(request.get_Form());
		oAuthContext.QueryParameters = GetCleanedNameValueCollection(request.get_QueryString());
		OAuthContext oAuthContext2 = oAuthContext;
		if (request.get_InputStream().Length > 0L)
		{
			oAuthContext2.RawContent = new byte[request.get_InputStream().Length];
			request.get_InputStream().Read(oAuthContext2.RawContent, 0, oAuthContext2.RawContent.Length);
			request.get_InputStream().Position = 0L;
		}
		ParseAuthorizationHeader(request.get_Headers(), oAuthContext2);
		return oAuthContext2;
	}

	public virtual IOAuthContext FromWebRequest(HttpWebRequest request, Stream rawBody)
	{
		using StreamReader streamReader = new StreamReader(rawBody);
		return FromWebRequest(request, streamReader.ReadToEnd());
	}

	public virtual IOAuthContext FromWebRequest(HttpWebRequest request, string body)
	{
		OAuthContext oAuthContext = new OAuthContext();
		oAuthContext.RawUri = CleanUri(request.RequestUri);
		oAuthContext.Cookies = CollectCookies((WebRequest)request);
		oAuthContext.Headers = request.Headers;
		oAuthContext.RequestMethod = request.Method;
		OAuthContext oAuthContext2 = oAuthContext;
		string text = request.Headers[HttpRequestHeader.ContentType] ?? string.Empty;
		if (text.ToLower().Contains("application/x-www-form-urlencoded"))
		{
			oAuthContext2.FormEncodedParameters = HttpUtility.ParseQueryString(body);
		}
		ParseAuthorizationHeader(request.Headers, oAuthContext2);
		return oAuthContext2;
	}

	protected virtual NameValueCollection GetCleanedNameValueCollection(NameValueCollection requestQueryString)
	{
		NameValueCollection nameValueCollection = new NameValueCollection(requestQueryString);
		if (nameValueCollection.HasKeys())
		{
			nameValueCollection.Remove(null);
		}
		return nameValueCollection;
	}

	protected virtual Uri CleanUri(Uri uri)
	{
		Uri adjustedUri = _uriAdjuster(uri);
		return RemoveEmptyQueryStringParameterIntroducedBySomeOpenSocialPlatformImplementations(adjustedUri);
	}

	private static Uri RemoveEmptyQueryStringParameterIntroducedBySomeOpenSocialPlatformImplementations(Uri adjustedUri)
	{
		string originalString = adjustedUri.OriginalString;
		if (!originalString.EndsWith("&"))
		{
			return adjustedUri;
		}
		return new Uri(originalString.Substring(0, originalString.Length - 1));
	}

	protected virtual NameValueCollection CollectCookies(WebRequest request)
	{
		return CollectCookiesFromHeaderString(request.Headers[HttpRequestHeader.Cookie]);
	}

	protected virtual NameValueCollection CollectCookies(HttpRequestBase request)
	{
		return CollectCookiesFromHeaderString(request.get_Headers()["Set-Cookie"]);
	}

	protected virtual NameValueCollection CollectCookiesFromHeaderString(string cookieHeader)
	{
		NameValueCollection nameValueCollection = new NameValueCollection();
		if (!string.IsNullOrEmpty(cookieHeader))
		{
			string[] array = cookieHeader.Split(new char[1] { ';' });
			string[] array2 = array;
			foreach (string text in array2)
			{
				string input = text.Trim();
				Regex regex = new Regex("^(\\S*)=(\\S*)$");
				if (regex.IsMatch(input))
				{
					Match match = regex.Match(input);
					if (match.Groups.Count > 2)
					{
						nameValueCollection.Add(match.Groups[1].Value, HttpUtility.UrlDecode(match.Groups[2].Value)!.Replace(' ', '+'));
					}
				}
			}
		}
		return nameValueCollection;
	}

	protected virtual void ParseAuthorizationHeader(NameValueCollection headers, OAuthContext context)
	{
		if (headers.AllKeys.Contains<string>("Authorization"))
		{
			context.AuthorizationHeaderParameters = UriUtility.GetHeaderParameters(headers["Authorization"]).ToNameValueCollection();
			context.UseAuthorizationHeader = true;
		}
	}
}
