using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace TechTalk.SpecFlow.Tracing;

public static class CodeFormattingExtensions
{
	private static readonly Regex firstWordCharRe = new Regex("(?<pre>[^\\p{Ll}\\p{Lu}]+)(?<fc>[\\p{Ll}\\p{Lu}])");

	private static readonly Regex punctCharRe = new Regex("[\\n\\.-]+");

	private static Dictionary<string, string> accentReplacements = new Dictionary<string, string>
	{
		{ "À", "A" },
		{ "Á", "A" },
		{ "Â", "A" },
		{ "Ã", "A" },
		{ "Ä", "A" },
		{ "Å", "A" },
		{ "Æ", "AE" },
		{ "Ç", "C" },
		{ "È", "E" },
		{ "É", "E" },
		{ "Ê", "E" },
		{ "Ë", "E" },
		{ "Ì", "I" },
		{ "Í", "I" },
		{ "Î", "I" },
		{ "Ï", "I" },
		{ "Ð", "D" },
		{ "Ñ", "N" },
		{ "Ò", "O" },
		{ "Ó", "O" },
		{ "Ô", "O" },
		{ "Õ", "O" },
		{ "Ö", "O" },
		{ "Ø", "O" },
		{ "Ù", "U" },
		{ "Ú", "U" },
		{ "Û", "U" },
		{ "Ü", "U" },
		{ "Ý", "Y" },
		{ "ß", "B" },
		{ "à", "a" },
		{ "á", "a" },
		{ "â", "a" },
		{ "ã", "a" },
		{ "ä", "a" },
		{ "å", "a" },
		{ "æ", "ae" },
		{ "ç", "c" },
		{ "è", "e" },
		{ "é", "e" },
		{ "ê", "e" },
		{ "ë", "e" },
		{ "ì", "i" },
		{ "í", "i" },
		{ "î", "i" },
		{ "ï", "i" },
		{ "ñ", "n" },
		{ "ò", "o" },
		{ "ó", "o" },
		{ "ô", "o" },
		{ "õ", "o" },
		{ "ö", "o" },
		{ "ø", "o" },
		{ "ù", "u" },
		{ "ú", "u" },
		{ "û", "u" },
		{ "ü", "u" },
		{ "ý", "y" },
		{ "ÿ", "y" },
		{ "Ą", "A" },
		{ "Ł", "L" },
		{ "Ľ", "L" },
		{ "Ś", "S" },
		{ "Š", "S" },
		{ "Ş", "S" },
		{ "Ť", "T" },
		{ "Ź", "Z" },
		{ "Ž", "Z" },
		{ "Ż", "Z" },
		{ "ą", "a" },
		{ "ł", "l" },
		{ "ľ", "l" },
		{ "ś", "s" },
		{ "š", "s" },
		{ "ş", "s" },
		{ "ť", "t" },
		{ "ź", "z" },
		{ "ž", "z" },
		{ "ż", "z" },
		{ "Ŕ", "R" },
		{ "Ă", "A" },
		{ "Ĺ", "L" },
		{ "Ć", "C" },
		{ "Č", "C" },
		{ "Ę", "E" },
		{ "Ě", "E" },
		{ "Ď", "D" },
		{ "Đ", "D" },
		{ "Ń", "N" },
		{ "Ň", "N" },
		{ "Ő", "O" },
		{ "Ř", "R" },
		{ "Ů", "U" },
		{ "Ű", "U" },
		{ "Ţ", "T" },
		{ "ŕ", "r" },
		{ "ă", "a" },
		{ "ĺ", "l" },
		{ "ć", "c" },
		{ "č", "c" },
		{ "ę", "e" },
		{ "ě", "e" },
		{ "ď", "d" },
		{ "đ", "d" },
		{ "ń", "n" },
		{ "ň", "n" },
		{ "ő", "o" },
		{ "ř", "r" },
		{ "ů", "u" },
		{ "ű", "u" },
		{ "ţ", "t" }
	};

	private static readonly Regex nonIdentifierRe = new Regex("[^\\p{Ll}\\p{Lu}\\p{Lt}\\p{Lm}\\p{Lo}\\p{Nl}\\p{Nd}\\p{Pc}]");

	private static readonly Regex nonLatinRe = new Regex("[^a-zA-Z]");

	private static readonly Regex singleAndDoubleQuotes = new Regex("['\"]");

	public static string Indent(this string text, string indent)
	{
		if (text.EndsWith(Environment.NewLine))
		{
			return text.Remove(text.Length - Environment.NewLine.Length).Indent(indent) + Environment.NewLine;
		}
		return indent + text.Replace(Environment.NewLine, Environment.NewLine + indent);
	}

	public static string ToIdentifier(this string text)
	{
		string text2 = text.ToIdentifierPart();
		if (text2.Length > 0 && char.IsDigit(text2[0]))
		{
			text2 = "_" + text2;
		}
		return text2;
	}

	public static string ToIdentifierCamelCase(this string text)
	{
		string text2 = text.ToIdentifier();
		if (text2.Length > 0)
		{
			text2 = text2.Substring(0, 1).ToLower() + text2.Substring(1);
		}
		return text2;
	}

	public static string ToIdentifierPart(this string text)
	{
		text = RemoveQuotationCharacters(text);
		text = firstWordCharRe.Replace(text, (Match match) => match.Groups["pre"].Value + match.Groups["fc"].Value.ToUpper());
		text = punctCharRe.Replace(text, "_");
		text = RemoveAccentAndPunctuationChars(text);
		if (text.Length > 0)
		{
			text = text.Substring(0, 1).ToUpper() + text.Substring(1);
		}
		return text;
	}

	public static string TrimEllipse(this string text, int maxLength)
	{
		if (text != null && text.Length > maxLength)
		{
			return text.Substring(0, maxLength - "...".Length) + "...";
		}
		return text;
	}

	public static string RemoveAccentAndPunctuationChars(string text)
	{
		string input = nonIdentifierRe.Replace(text, string.Empty);
		string value;
		return nonLatinRe.Replace(input, (Match match) => accentReplacements.TryGetValue(match.Value, out value) ? value : match.Value);
	}

	public static string RemoveQuotationCharacters(string text)
	{
		return singleAndDoubleQuotes.Replace(text, string.Empty);
	}
}
