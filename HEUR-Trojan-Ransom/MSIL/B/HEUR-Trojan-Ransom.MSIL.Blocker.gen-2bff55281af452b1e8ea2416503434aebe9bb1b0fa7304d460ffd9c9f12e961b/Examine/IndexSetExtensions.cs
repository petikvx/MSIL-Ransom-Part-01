using System;
using System.Web;
using Examine.LuceneEngine.Config;

namespace Examine;

internal static class IndexSetExtensions
{
	internal static void ReplaceTokensInIndexPath(this IndexSet indexSet)
	{
		if (indexSet != null)
		{
			indexSet.IndexPath = indexSet.IndexPath.Replace("{machinename}", NetworkHelper.FileSafeMachineName).Replace("{appdomainappid}", (HttpRuntime.get_AppDomainAppId() ?? string.Empty).ReplaceNonAlphanumericChars("")).EnsureEndsWith((char)Convert.ToInt32(47.0));
		}
	}
}
