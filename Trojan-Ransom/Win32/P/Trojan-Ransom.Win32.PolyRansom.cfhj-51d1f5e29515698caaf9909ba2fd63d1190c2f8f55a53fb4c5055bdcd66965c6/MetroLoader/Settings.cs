namespace MetroLoader;

public static class Settings
{
	public static string host { get; set; }

	public static string user_agent { get; set; }

	public static byte[] file { get; set; }

	static Settings()
	{
		host = "https://exlids.xyz/forum/";
		user_agent = "cihaningözü";
	}
}
