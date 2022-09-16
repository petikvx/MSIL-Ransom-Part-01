using System;
using System.Globalization;
using System.Linq;
using Microsoft.Win32;
using _0xHInex5erts;
using _0xHLinn3;
using _0xHMor2hometries;

namespace _0xH2odel;

internal static class _0xHOvertrum5
{
	internal static IAzureLibrariesVersionInfo[] _0xH8rinkling()
	{
		return new IAzureLibrariesVersionInfo[9]
		{
			_0xHFatw33ds._0xHFo4ficate,
			_0xHFatw33ds._0xH2harif,
			_0xHFatw33ds._0xHRacke5,
			_0xHFatw33ds._0xHDiarrh0as,
			_0xHFatw33ds._0xH5alons,
			_0xHFatw33ds._0xHS3us3ges,
			_0xHFatw33ds._0xHMateria5istic,
			_0xHFatw33ds._0xHS7a7doms,
			_0xHFatw33ds._0xHI5ward5esses
		};
	}

	internal static IAzureLibrariesVersionInfo _0xHLuc4ies(Version _0xHHic1ie)
	{
		if (_0xHHic1ie == null)
		{
			return null;
		}
		IAzureLibrariesVersionInfo azureLibrariesVersionInfo = _0xH8rinkling().FirstOrDefault((IAzureLibrariesVersionInfo LibrariesVersionInfo) => LibrariesVersionInfo.ProductVersion == _0xHHic1ie);
		if (azureLibrariesVersionInfo == null)
		{
			azureLibrariesVersionInfo = new _0xHCa2aclysms(_0xHHic1ie, string.Format(CultureInfo.InvariantCulture, "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Microsoft SDKs\\Windows Azure Libraries for .NET\\v{0}", _0xHHic1ie.ToString()), "InstallLocation", string.Empty);
		}
		return azureLibrariesVersionInfo;
	}

	internal static string _0xHMave4icks(Version _0xH3ranscendencies)
	{
		return (string)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows Azure Tools for Microsoft Visual Studio\\16.0\\v" + _0xH3ranscendencies.ToString(), "ActiveWindowsAzureLibrariesVersion", null);
	}
}
