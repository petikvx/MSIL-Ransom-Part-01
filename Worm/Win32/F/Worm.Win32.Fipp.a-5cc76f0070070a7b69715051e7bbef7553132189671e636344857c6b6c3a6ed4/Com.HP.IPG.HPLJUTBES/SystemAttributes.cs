using System;

namespace Com.HP.IPG.HPLJUTBES;

internal class SystemAttributes
{
	private string GetOSVersionInfo()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		switch (oSVersion.Platform)
		{
		case PlatformID.Win32Windows:
			switch (oSVersion.Version.Minor)
			{
			case 10:
				if (!(oSVersion.Version.Revision.ToString() == "2222A"))
				{
				}
				break;
			}
			break;
		case PlatformID.Win32NT:
			switch (oSVersion.Version.Major)
			{
			case 5:
				_ = oSVersion.Version.Minor;
				break;
			}
			break;
		}
		return "";
	}
}
