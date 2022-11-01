using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace xClient.Core.Recovery.Browsers;

public struct STATURL
{
	public int cbSize;

	[MarshalAs(UnmanagedType.LPWStr)]
	public string pwcsUrl;

	[MarshalAs(UnmanagedType.LPWStr)]
	public string pwcsTitle;

	public FILETIME ftLastVisited;

	public FILETIME ftLastUpdated;

	public FILETIME ftExpires;

	public STATURLFLAGS dwFlags;

	public string URL => pwcsUrl;

	public string UrlString
	{
		get
		{
			int num = pwcsUrl.IndexOf('?');
			if (num >= 0)
			{
				return pwcsUrl.Substring(0, num);
			}
			return pwcsUrl;
		}
	}

	public string Title
	{
		get
		{
			if (pwcsUrl.StartsWith("file:"))
			{
				return Win32api.CannonializeURL(pwcsUrl, Win32api.shlwapi_URL.URL_UNESCAPE).Substring(8).Replace('/', '\\');
			}
			return pwcsTitle;
		}
	}

	public DateTime LastVisited => Win32api.FileTimeToDateTime(ftLastVisited).ToLocalTime();

	public DateTime LastUpdated => Win32api.FileTimeToDateTime(ftLastUpdated).ToLocalTime();

	public DateTime Expires
	{
		get
		{
			try
			{
				return Win32api.FileTimeToDateTime(ftExpires).ToLocalTime();
			}
			catch (Exception)
			{
				return DateTime.Now;
			}
		}
	}

	public override string ToString()
	{
		return pwcsUrl;
	}
}
