using System;
using System.Runtime.InteropServices;
using Gecko.Interop;

namespace Gecko.Plugins;

public static class PluginHost
{
	private static ComPtr<nsIPluginHost> _pluginHost;

	static PluginHost()
	{
		_pluginHost = Xpcom.GetService2<nsIPluginHost>("@mozilla.org/plugin/host;1");
	}

	public static void ReloadPlugins()
	{
		_pluginHost.Instance.ReloadPlugins();
	}

	public static PluginTag[] GetPluginTags()
	{
		IntPtr intPtr = IntPtr.Zero;
		PluginTag[] array2;
		try
		{
			uint aPluginCount = 0u;
			intPtr = _pluginHost.Instance.GetPluginTags(ref aPluginCount);
			int num = (int)aPluginCount;
			IntPtr[] array = new IntPtr[num];
			array2 = new PluginTag[num];
			Marshal.Copy(intPtr, array, 0, array.Length);
			for (int i = 0; i < num; i++)
			{
				object obj = null;
				try
				{
					obj = Xpcom.GetObjectForIUnknown(array[i]);
					array2[i] = new PluginTag(Xpcom.QueryInterface<nsIPluginTag>(obj));
				}
				finally
				{
					if (obj != null)
					{
						Marshal.ReleaseComObject(obj);
					}
				}
			}
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Xpcom.free(intPtr);
			}
		}
		return array2;
	}

	public static bool SiteHasData(PluginTag tag, string domain)
	{
		return nsString.Pass(_pluginHost.Instance.SiteHasData, tag._pluginTag, domain);
	}

	public static void ClearSiteData(PluginTag tag, string domain, ulong flags, long maxAge)
	{
		nsString.Set(delegate(nsAUTF8String x)
		{
			_pluginHost.Instance.ClearSiteData(tag._pluginTag, x, flags, maxAge, null);
		}, domain);
	}
}
