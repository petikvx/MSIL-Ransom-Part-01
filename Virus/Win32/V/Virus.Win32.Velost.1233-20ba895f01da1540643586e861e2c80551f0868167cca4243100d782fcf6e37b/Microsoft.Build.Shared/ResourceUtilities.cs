using System.Globalization;
using System.Text.RegularExpressions;

namespace Microsoft.Build.Shared;

internal static class ResourceUtilities
{
	private static readonly Regex msbuildMessageCodePattern = new Regex("^\\s*(?<CODE>MSB\\d\\d\\d\\d):\\s*(?<MESSAGE>.*)$", RegexOptions.Singleline);

	internal static string ExtractMessageCode(Regex messageCodePattern, string messageWithCode, out string code)
	{
		code = null;
		string result = messageWithCode;
		if (messageCodePattern == null)
		{
			messageCodePattern = msbuildMessageCodePattern;
		}
		Match match = messageCodePattern.Match(messageWithCode);
		if (match.Success)
		{
			code = match.Groups["CODE"].Value;
			result = match.Groups["MESSAGE"].Value;
		}
		return result;
	}

	private static string GetHelpKeyword(string resourceName)
	{
		return "MSBuild." + resourceName;
	}

	internal static string FormatResourceString(out string code, out string helpKeyword, string resourceName, params object[] args)
	{
		helpKeyword = GetHelpKeyword(resourceName);
		return ExtractMessageCode(null, FormatString(AssemblyResources.GetString(resourceName), args), out code);
	}

	internal static string FormatResourceString(string resourceName, params object[] args)
	{
		string code;
		string helpKeyword;
		return FormatResourceString(out code, out helpKeyword, resourceName, args);
	}

	internal static string FormatString(string unformatted, params object[] args)
	{
		string result = unformatted;
		if (args != null && args.Length > 0)
		{
			result = string.Format(CultureInfo.CurrentCulture, unformatted, args);
		}
		return result;
	}
}
