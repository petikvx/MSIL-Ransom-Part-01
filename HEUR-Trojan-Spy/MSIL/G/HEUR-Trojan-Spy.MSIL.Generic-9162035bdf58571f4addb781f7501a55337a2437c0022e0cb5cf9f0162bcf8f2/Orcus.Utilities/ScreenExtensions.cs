using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Orcus.Native;
using Orcus.Native.Display;

namespace Orcus.Utilities;

public static class ScreenExtensions
{
	public const int ERROR_SUCCESS = 0;

	private static string MonitorFriendlyName(LUID adapterId, uint targetId)
	{
		DISPLAYCONFIG_TARGET_DEVICE_NAME dISPLAYCONFIG_TARGET_DEVICE_NAME = default(DISPLAYCONFIG_TARGET_DEVICE_NAME);
		dISPLAYCONFIG_TARGET_DEVICE_NAME.header.size = (uint)Marshal.SizeOf(typeof(DISPLAYCONFIG_TARGET_DEVICE_NAME));
		dISPLAYCONFIG_TARGET_DEVICE_NAME.header.adapterId = adapterId;
		dISPLAYCONFIG_TARGET_DEVICE_NAME.header.id = targetId;
		dISPLAYCONFIG_TARGET_DEVICE_NAME.header.type = DISPLAYCONFIG_DEVICE_INFO_TYPE.DISPLAYCONFIG_DEVICE_INFO_GET_TARGET_NAME;
		DISPLAYCONFIG_TARGET_DEVICE_NAME deviceName = dISPLAYCONFIG_TARGET_DEVICE_NAME;
		int num = NativeMethods.DisplayConfigGetDeviceInfo(ref deviceName);
		if (num != 0)
		{
			throw new Win32Exception(num);
		}
		return deviceName.monitorFriendlyDeviceName;
	}

	public static string[] GetAllMonitorsFriendlyNames()
	{
		if (!CoreHelper.RunningOnVista && !CoreHelper.RunningOnXP)
		{
			if (NativeMethods.GetDisplayConfigBufferSizes(QUERY_DEVICE_CONFIG_FLAGS.QDC_ONLY_ACTIVE_PATHS, out var numPathArrayElements, out var numModeInfoArrayElements) != 0)
			{
				return GetDefaultScreenNames();
			}
			DISPLAYCONFIG_PATH_INFO[] pathInfoArray = new DISPLAYCONFIG_PATH_INFO[numPathArrayElements];
			DISPLAYCONFIG_MODE_INFO[] array = new DISPLAYCONFIG_MODE_INFO[numModeInfoArrayElements];
			if (NativeMethods.QueryDisplayConfig(QUERY_DEVICE_CONFIG_FLAGS.QDC_ONLY_ACTIVE_PATHS, ref numPathArrayElements, pathInfoArray, ref numModeInfoArrayElements, array, IntPtr.Zero) != 0)
			{
				return GetDefaultScreenNames();
			}
			List<string> list = new List<string>();
			for (int i = 0; i < numModeInfoArrayElements; i++)
			{
				if (array[i].infoType == DISPLAYCONFIG_MODE_INFO_TYPE.DISPLAYCONFIG_MODE_INFO_TYPE_TARGET)
				{
					list.Add(MonitorFriendlyName(array[i].adapterId, array[i].id));
				}
			}
			return list.ToArray();
		}
		return GetDefaultScreenNames();
	}

	private static string[] GetDefaultScreenNames()
	{
		return (from x in Screen.get_AllScreens()
			select x.get_DeviceName()).ToArray();
	}

	public static string GetDeviceFriendlyName(this Screen screen)
	{
		string[] allMonitorsFriendlyNames = GetAllMonitorsFriendlyNames();
		int num = 0;
		while (true)
		{
			if (num < Screen.get_AllScreens().Length)
			{
				if (object.Equals(screen, Screen.get_AllScreens()[num]))
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return allMonitorsFriendlyNames.ToArray()[num];
	}

	public static Dictionary<Screen, string> GetScreensWithName()
	{
		Dictionary<Screen, string> dictionary = new Dictionary<Screen, string>();
		Screen[] allScreens = Screen.get_AllScreens();
		string[] array = GetAllMonitorsFriendlyNames().ToArray();
		for (int i = 0; i < allScreens.Length; i++)
		{
			dictionary.Add(allScreens[i], (array.Length >= i) ? allScreens[i].get_DeviceName() : array[i]);
		}
		return dictionary;
	}
}
