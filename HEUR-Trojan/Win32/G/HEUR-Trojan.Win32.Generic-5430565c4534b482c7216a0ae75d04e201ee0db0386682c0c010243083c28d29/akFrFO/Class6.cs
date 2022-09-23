using System;

namespace akFrFO;

internal sealed class Class6
{
	internal static bool jjgtgccvy(out AppDomain appDomain)
	{
		string value = null;
		if (string.IsNullOrEmpty(value))
		{
			appDomain = AppDomain.CurrentDomain;
			return true;
		}
		appDomain = null;
		return false;
	}
}
