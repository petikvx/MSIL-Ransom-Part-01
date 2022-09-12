using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace InstagramApiSharp.Helpers;

internal static class DictionaryExtensions
{
	public static string AsQueryString(this Dictionary<string, string> parameters)
	{
		if (!parameters.Any())
		{
			return "";
		}
		StringBuilder stringBuilder = new StringBuilder("?");
		string arg = "";
		foreach (KeyValuePair<string, string> item in parameters.Where((KeyValuePair<string, string> kvp) => kvp.Value != null))
		{
			stringBuilder.AppendFormat("{0}{1}={2}", arg, WebUtility.UrlEncode(item.Key), WebUtility.UrlEncode(item.Value));
			arg = "&";
		}
		return stringBuilder.ToString();
	}
}
