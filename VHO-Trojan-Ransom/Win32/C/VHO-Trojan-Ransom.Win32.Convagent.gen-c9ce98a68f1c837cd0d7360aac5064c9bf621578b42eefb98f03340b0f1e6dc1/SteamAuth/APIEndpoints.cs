namespace SteamAuth;

public static class APIEndpoints
{
	public const string STEAMAPI_BASE = "https://api.steampowered.com";

	public const string COMMUNITY_BASE = "https://steamcommunity.com";

	public const string MOBILEAUTH_BASE = "https://api.steampowered.com/IMobileAuthService/%s/v0001";

	public static string MOBILEAUTH_GETWGTOKEN;

	public const string TWO_FACTOR_BASE = "https://api.steampowered.com/ITwoFactorService/%s/v0001";

	public static string TWO_FACTOR_TIME_QUERY;

	static APIEndpoints()
	{
		Class24.nhQmSIPz7n4eU();
		MOBILEAUTH_GETWGTOKEN = "https://api.steampowered.com/IMobileAuthService/%s/v0001".Replace("%s", "GetWGToken");
		TWO_FACTOR_TIME_QUERY = "https://api.steampowered.com/ITwoFactorService/%s/v0001".Replace("%s", "QueryTime");
	}
}
