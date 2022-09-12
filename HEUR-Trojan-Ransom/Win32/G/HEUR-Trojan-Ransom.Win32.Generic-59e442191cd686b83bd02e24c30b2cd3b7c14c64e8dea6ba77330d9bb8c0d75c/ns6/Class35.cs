using System;
using System.Management;

namespace ns6;

internal static class Class35
{
	public static ManagementObject smethod_0(ManagementObjectSearcher managementObjectSearcher_0)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		ManagementObject result = null;
		ManagementObjectEnumerator enumerator = managementObjectSearcher_0.Get().GetEnumerator();
		try
		{
			if (enumerator.MoveNext())
			{
				return (ManagementObject)enumerator.get_Current();
			}
			return result;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}
}
