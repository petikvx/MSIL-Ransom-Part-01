using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Web;

namespace DevDefined.OAuth.Framework;

public static class UriUtility
{
	private const string OAuthAuthorizationHeaderStart = "OAuth";

	private static readonly string[] HexEscapedUriRfc3986CharsToEscape;

	private static readonly string[] QuoteCharacters;

	private static readonly string[] UriRfc3986CharsToEscape;

	static UriUtility()
	{
		QuoteCharacters = new string[2] { "\"", "'" };
		UriRfc3986CharsToEscape = new string[5] { "!", "*", "'", "(", ")" };
		HexEscapedUriRfc3986CharsToEscape = UriRfc3986CharsToEscape.Select((string c) => Uri.HexEscape(c[0])).ToArray();
	}

	private static string EscapeUriDataStringRfc3986(string value)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i <= value.Length; i += 32766)
		{
			string stringToEscape = value.Substring(i, Math.Min(value.Length - i, 32766));
			stringBuilder.Append(Uri.EscapeDataString(stringToEscape));
		}
		for (int j = 0; j < UriRfc3986CharsToEscape.Length; j++)
		{
			stringBuilder.Replace(UriRfc3986CharsToEscape[j], HexEscapedUriRfc3986CharsToEscape[j]);
		}
		return stringBuilder.ToString();
	}

	public static List<KeyValuePair<string, string>> GetQueryParameters(string parameters)
	{
		if (parameters.StartsWith("?"))
		{
			parameters = parameters.Remove(0, 1);
		}
		List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
		if (!string.IsNullOrEmpty(parameters))
		{
			string[] array = parameters.Split(new char[1] { '&' });
			string[] array2 = array;
			foreach (string text in array2)
			{
				if (!string.IsNullOrEmpty(text) && !text.StartsWith("oauth_") && !text.StartsWith("x_auth_"))
				{
					if (text.IndexOf('=') > -1)
					{
						string[] array3 = text.Split(new char[1] { '=' });
						list.Add(new KeyValuePair<string, string>(array3[0], array3[1]));
					}
					else
					{
						list.Add(new KeyValuePair<string, string>(text, string.Empty));
					}
				}
			}
		}
		return list;
	}

	public static List<KeyValuePair<string, string>> GetHeaderParameters(string parameters)
	{
		parameters = parameters.Trim();
		List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
		if (!parameters.StartsWith("OAuth", StringComparison.InvariantCultureIgnoreCase))
		{
			return list;
		}
		parameters = parameters.Substring("OAuth".Length).Trim();
		if (!string.IsNullOrEmpty(parameters))
		{
			string[] array = parameters.Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries);
			string[] array2 = array;
			foreach (string text in array2)
			{
				if (!string.IsNullOrEmpty(text))
				{
					KeyValuePair<string, string> item = ParseAuthorizationHeaderKeyValuePair(text);
					list.Add(item);
				}
			}
		}
		return list;
	}

	public static KeyValuePair<string, string> ParseAuthorizationHeaderKeyValuePair(string keyEqualValuePair)
	{
		int num = keyEqualValuePair.IndexOf('=');
		if (num > 0)
		{
			string key = keyEqualValuePair.Substring(0, num).Trim();
			string quotedValue = keyEqualValuePair.Substring(num + 1);
			string str = StripQuotes(quotedValue);
			str = HttpUtility.UrlDecode(str);
			return new KeyValuePair<string, string>(key, str);
		}
		return new KeyValuePair<string, string>(keyEqualValuePair.Trim(), string.Empty);
	}

	private static string StripQuotes(string quotedValue)
	{
		string[] quoteCharacters = QuoteCharacters;
		int num = 0;
		while (true)
		{
			if (num < quoteCharacters.Length)
			{
				string value = quoteCharacters[num];
				if (quotedValue.StartsWith(value) && quotedValue.EndsWith(value) && quotedValue.Length > 1)
				{
					break;
				}
				num++;
				continue;
			}
			return quotedValue;
		}
		return quotedValue.Substring(1, quotedValue.Length - 2);
	}

	public static string UrlEncode(string value)
	{
		return EscapeUriDataStringRfc3986(value);
	}

	public static string FormatQueryString(IEnumerable<KeyValuePair<string, string>> parameters)
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (parameters != null)
		{
			foreach (KeyValuePair<string, string> parameter in parameters)
			{
				if (stringBuilder.Length > 0)
				{
					stringBuilder.Append("&");
				}
				stringBuilder.Append(parameter.Key).Append("=");
				stringBuilder.Append(UrlEncode(parameter.Value));
			}
		}
		return stringBuilder.ToString();
	}

	public static string FormatQueryString(NameValueCollection parameters)
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (parameters != null)
		{
			foreach (string key in parameters.Keys)
			{
				if (stringBuilder.Length > 0)
				{
					stringBuilder.Append("&");
				}
				stringBuilder.Append(key).Append("=");
				stringBuilder.Append(UrlEncode(parameters[key]));
			}
		}
		return stringBuilder.ToString();
	}

	public static string FormatParameters(string httpMethod, Uri url, List<KeyValuePair<string, string>> parameters)
	{
		string value = NormalizeRequestParameters(parameters);
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendFormat("{0}&", httpMethod.ToUpper());
		stringBuilder.AppendFormat("{0}&", UrlEncode(NormalizeUri(url)));
		stringBuilder.AppendFormat("{0}", UrlEncode(value));
		return stringBuilder.ToString();
	}

	public static string NormalizeRequestParameters(IEnumerable<KeyValuePair<string, string>> parameters)
	{
		IEnumerable<KeyValuePair<string, string>> enumerable = from x in parameters.OrderBy<KeyValuePair<string, string>, string>((KeyValuePair<string, string> x) => x.Key, StringComparer.Ordinal).ThenBy((KeyValuePair<string, string> x) => x.Value)
			select new KeyValuePair<string, string>(x.Key, UrlEncode(x.Value));
		StringBuilder stringBuilder = new StringBuilder();
		foreach (KeyValuePair<string, string> item in enumerable)
		{
			if (stringBuilder.Length > 0)
			{
				stringBuilder.Append("&");
			}
			stringBuilder.Append(item.Key).Append("=").Append(item.Value);
		}
		return stringBuilder.ToString();
	}

	public static string NormalizeUri(Uri uri)
	{
		string text = $"{uri.Scheme}://{uri.Host}";
		if ((!(uri.Scheme == "http") || uri.Port != 80) && (!(uri.Scheme == "https") || uri.Port != 443))
		{
			text = text + ":" + uri.Port;
		}
		return text + ((uri.AbsolutePath == "/") ? "" : uri.AbsolutePath);
	}

	public static IEnumerable<KeyValuePair<string, string>> ToQueryParameters(this NameValueCollection source)
	{
		try
		{
			string[] allKeys = source.AllKeys;
			foreach (string key in allKeys)
			{
				yield return new KeyValuePair<string, string>(key, source[key]);
			}
		}
		finally
		{
		}
	}

	public static IEnumerable<KeyValuePair<string, string>> ToQueryParametersExcludingTokenSecret(this NameValueCollection source)
	{
		try
		{
			string[] allKeys = source.AllKeys;
			foreach (string key in allKeys)
			{
				if (key != "oauth_token_secret")
				{
					yield return new KeyValuePair<string, string>(key, source[key]);
				}
			}
		}
		finally
		{
		}
	}

	public static NameValueCollection ToNameValueCollection(this IEnumerable<KeyValuePair<string, string>> source)
	{
		NameValueCollection nameValueCollection = new NameValueCollection();
		foreach (KeyValuePair<string, string> item in source)
		{
			nameValueCollection[item.Key] = item.Value;
		}
		return nameValueCollection;
	}

	public static string FormatTokenForResponse(IToken token)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("oauth_token").Append("=").Append(UrlEncode(token.Token))
			.Append("&")
			.Append("oauth_token_secret")
			.Append("=")
			.Append(UrlEncode(token.TokenSecret));
		return stringBuilder.ToString();
	}
}
