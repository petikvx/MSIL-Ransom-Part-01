using System;
using System.Globalization;
using System.Linq;
using Microsoft.Win32;
using _0xH4azabos;
using _0xHHalf6eartedness;
using _0xHO0a;
using _0xHPilf2rag2s;

namespace _0xHTur1hall;

internal static class _0xH4table
{
	internal static IAzureSDKVersionInfo[] _0xHConstellat0ng()
	{
		return new IAzureSDKVersionInfo[13]
		{
			_0xHQuixoti5m5._0xHB2ush,
			_0xHQuixoti5m5._0xHLogja55ed,
			_0xHQuixoti5m5._0xHSavori1y,
			_0xHQuixoti5m5._0xHRassl1s,
			_0xHQuixoti5m5._0xHEgre33ion3,
			_0xHQuixoti5m5._0xHA2onali2ies,
			_0xHQuixoti5m5._0xHTinke8ed,
			_0xHQuixoti5m5._0xH5leum,
			_0xHQuixoti5m5._0xHTraumatize7,
			_0xHQuixoti5m5._0xHCircularne55e5,
			_0xHQuixoti5m5._0xHG5amicidin,
			_0xHQuixoti5m5._0xHSh0b00ns,
			_0xHQuixoti5m5._0xH2ecular
		};
	}

	internal static IAzureSDKVersionInfo _0xHBe8ails(Version _0xHPa4amaed)
	{
		if (_0xHPa4amaed == null)
		{
			return null;
		}
		IAzureSDKVersionInfo azureSDKVersionInfo = _0xHConstellat0ng().FirstOrDefault((IAzureSDKVersionInfo SDKVersionInfo) => SDKVersionInfo.ProductVersion == _0xHPa4amaed);
		if (azureSDKVersionInfo == null)
		{
			azureSDKVersionInfo = new _0xHNo77le7(_0xHPa4amaed, string.Format(CultureInfo.InvariantCulture, "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Microsoft SDKs\\ServiceHosting\\v{0}", _0xHPa4amaed.ToString()), "InstallPath", _0xHQuixoti5m5._0xH7ringers, _0xHAnticoloni3l(_0xHPa4amaed));
		}
		return azureSDKVersionInfo;
	}

	internal static string _0xHReemphas8ze(Version _0xHHarp44ned)
	{
		return (string)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows Azure Tools for Microsoft Visual Studio\\16.0\\v" + _0xHHarp44ned.ToString(), "ActiveWindowsAzureVersion", null);
	}

	private static string _0xHAnticoloni3l(Version _0xHPolyamid4s)
	{
		string _0xH1ojos = _0xHCa2kings._0xHHy2ervelocities._0xH1ojos;
		if (!string.IsNullOrEmpty(_0xH1ojos))
		{
			return _0xH1ojos;
		}
		return _0xHQuixoti5m5._0xHLaundr7men;
	}
}
