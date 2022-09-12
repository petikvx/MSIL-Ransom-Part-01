using System;
using System.Collections.Generic;

namespace InstagramApiSharp.Helpers;

public static class HttpExtensions
{
	public static Uri AddQueryParameter(this Uri uri, string name, string value)
	{
		switch (value)
		{
		default:
		{
			Dictionary<string, string> dictionary = HttpUtility.ParseQueryString(uri);
			dictionary.Remove(name);
			dictionary.Add(name, value);
			UriBuilder uriBuilder = new UriBuilder(uri);
			string text = "";
			foreach (KeyValuePair<string, string> item in dictionary)
			{
				text = ((!(text == "")) ? (text + "&" + item.Key + "=" + item.Value) : (text + item.Key + "=" + item.Value));
			}
			uriBuilder.Query = text;
			return uriBuilder.Uri;
		}
		case null:
		case "":
		case "[]":
			return uri;
		}
	}

	public static Uri AddQueryParameterIfNotEmpty(this Uri uri, string name, string value)
	{
		switch (value)
		{
		default:
		{
			Dictionary<string, string> dictionary = HttpUtility.ParseQueryString(uri);
			dictionary.Remove(name);
			dictionary.Add(name, value);
			UriBuilder uriBuilder = new UriBuilder(uri);
			string text = "";
			foreach (KeyValuePair<string, string> item in dictionary)
			{
				text = ((!(text == "")) ? (text + "&" + item.Key + "=" + item.Value) : (text + item.Key + "=" + item.Value));
			}
			uriBuilder.Query = text;
			return uriBuilder.Uri;
		}
		case null:
		case "":
		case "[]":
			return uri;
		}
	}
}
