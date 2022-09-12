using System.Net;
using System.Runtime.CompilerServices;

namespace SteamAuth;

public class SessionData
{
	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private string string_1;

	[CompilerGenerated]
	private string string_2;

	[CompilerGenerated]
	private string string_3;

	[CompilerGenerated]
	private string string_4;

	[CompilerGenerated]
	private ulong ulong_0;

	public string SessionID
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		set
		{
			string_0 = value;
		}
	}

	public string SteamLogin
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
		[CompilerGenerated]
		set
		{
			string_1 = value;
		}
	}

	public string SteamLoginSecure
	{
		[CompilerGenerated]
		get
		{
			return string_2;
		}
		[CompilerGenerated]
		set
		{
			string_2 = value;
		}
	}

	public string WebCookie
	{
		[CompilerGenerated]
		get
		{
			return string_3;
		}
		[CompilerGenerated]
		set
		{
			string_3 = value;
		}
	}

	public string String_0
	{
		[CompilerGenerated]
		get
		{
			return string_4;
		}
		[CompilerGenerated]
		set
		{
			string_4 = value;
		}
	}

	public ulong SteamID
	{
		[CompilerGenerated]
		get
		{
			return ulong_0;
		}
		[CompilerGenerated]
		set
		{
			ulong_0 = value;
		}
	}

	public void AddCookies(CookieContainer cookies)
	{
		cookies.Add(new Cookie("mobileClientVersion", "0 (2.1.3)", "/", ".steamcommunity.com"));
		cookies.Add(new Cookie("mobileClient", "android", "/", ".steamcommunity.com"));
		cookies.Add(new Cookie("steamid", SteamID.ToString(), "/", ".steamcommunity.com"));
		cookies.Add(new Cookie("steamLogin", SteamLogin, "/", ".steamcommunity.com")
		{
			HttpOnly = true
		});
		cookies.Add(new Cookie("steamLoginSecure", SteamLoginSecure, "/", ".steamcommunity.com")
		{
			HttpOnly = true,
			Secure = true
		});
		cookies.Add(new Cookie("Steam_Language", "english", "/", ".steamcommunity.com"));
		cookies.Add(new Cookie("dob", "", "/", ".steamcommunity.com"));
		cookies.Add(new Cookie("sessionid", SessionID, "/", ".steamcommunity.com"));
	}

	public SessionData()
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
	}
}
