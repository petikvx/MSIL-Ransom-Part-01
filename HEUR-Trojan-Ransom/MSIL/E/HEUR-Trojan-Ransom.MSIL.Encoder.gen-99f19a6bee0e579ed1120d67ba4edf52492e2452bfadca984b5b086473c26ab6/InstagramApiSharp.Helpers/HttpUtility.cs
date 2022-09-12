using System;
using System.Collections.Generic;
using System.Linq;

namespace InstagramApiSharp.Helpers;

public class HttpUtility
{
	public static Dictionary<string, string> ParseQueryString(Uri uri)
	{
		if (uri == null)
		{
			throw new ArgumentNullException("uri");
		}
		if (uri.Query.Length == 0)
		{
			return new Dictionary<string, string>();
		}
		return (from parameter in uri.Query.TrimStart(new char[1] { '?' }).Split(new char[2] { '&', ';' }, StringSplitOptions.RemoveEmptyEntries)
			select parameter.Split(new char[1] { '=' }, StringSplitOptions.RemoveEmptyEntries) into parts
			group (parts.Length <= 2) ? ((parts.Length <= 1) ? "" : parts[1]) : string.Join("=", parts, 1, parts.Length - 1) by parts[0]).ToDictionary((IGrouping<string, string> grouping) => grouping.Key, (IGrouping<string, string> grouping) => string.Join(",", grouping));
	}
}
