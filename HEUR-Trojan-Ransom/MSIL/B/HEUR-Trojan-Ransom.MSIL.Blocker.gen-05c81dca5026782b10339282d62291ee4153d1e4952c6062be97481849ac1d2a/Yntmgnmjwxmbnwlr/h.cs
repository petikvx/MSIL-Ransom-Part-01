using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Yntmgnmjwxmbnwlr;

public static class h
{
	private static readonly HashSet<string> m_a = new HashSet<string>
	{
		"__arglist", "__makeref", "__reftype", "__refvalue", "abstract", "as", "base", "bool", "break", "byte",
		"case", "catch", "char", "checked", "class", "const", "continue", "decimal", "default", "delegate",
		"do", "double", "else", "enum", "event", "explicit", "extern", "false", "finally", "fixed",
		"float", "for", "foreach", "goto", "if", "implicit", "in", "int", "interface", "internal",
		"is", "lock", "long", "namespace", "new", "null", "object", "operator", "out", "override",
		"params", "private", "protected", "public", "readonly", "ref", "return", "sbyte", "sealed", "short",
		"sizeof", "stackalloc", "static", "string", "struct", "switch", "this", "throw", "true", "try",
		"typeof", "uint", "ulong", "unchecked", "unsafe", "ushort", "using", "virtual", "volatile", "void",
		"while"
	};

	private static readonly Regex b = new Regex("^(\\p{Lu}|\\p{Ll}|\\p{Lt}|\\p{Lm}|\\p{Lo}|\\p{Nl}|_)((\\p{Lu}|\\p{Ll}|\\p{Lt}|\\p{Lm}|\\p{Lo}|\\p{Nl}|\\p{Nd}|\\p{Pc}|\\p{Mn}|\\p{Mc}|\\p{Cf})+)*$", RegexOptions.Compiled);

	public static bool a(this string a)
	{
		if (string.IsNullOrWhiteSpace(a))
		{
			return false;
		}
		string text = a.Normalize();
		if (b.IsMatch(text) && !h.m_a.Contains(text))
		{
			return true;
		}
		if (text.StartsWith("@") && b.IsMatch(text.Substring(1)))
		{
			return true;
		}
		return false;
	}
}
