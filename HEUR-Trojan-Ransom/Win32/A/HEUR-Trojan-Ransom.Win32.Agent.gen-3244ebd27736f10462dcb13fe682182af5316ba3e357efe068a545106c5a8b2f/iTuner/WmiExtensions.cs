using System;
using System.Management;

namespace iTuner;

public static class WmiExtensions
{
	public static ManagementObject First(ManagementObjectSearcher searcher)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		ManagementObject result = null;
		ManagementObjectEnumerator enumerator = searcher.Get().GetEnumerator();
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
