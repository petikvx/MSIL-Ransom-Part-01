using System;
using System.Runtime.InteropServices;
using Orcus.Native;
using Orcus.Native.Display;

namespace Orcus.Utilities;

public class Display
{
	public enum Orientations
	{
		DEGREES_CW_0 = 0,
		DEGREES_CW_90 = 3,
		DEGREES_CW_180 = 2,
		DEGREES_CW_270 = 1
	}

	private const int DMDO_DEFAULT = 0;

	private const int DMDO_90 = 1;

	private const int DMDO_180 = 2;

	private const int DMDO_270 = 3;

	private const int ENUM_CURRENT_SETTINGS = -1;

	public static DISP_CHANGE Rotate(uint displayNumber, Orientations orientation)
	{
		if (displayNumber == 0)
		{
			throw new ArgumentOutOfRangeException("displayNumber", displayNumber, "First display is 1.");
		}
		DISP_CHANGE result = DISP_CHANGE.Failed;
		DISPLAY_DEVICE lpDisplayDevice = default(DISPLAY_DEVICE);
		DEVMODE devMode = default(DEVMODE);
		lpDisplayDevice.cb = Marshal.SizeOf((object)lpDisplayDevice);
		if (!NativeMethods.EnumDisplayDevices(null, displayNumber - 1, ref lpDisplayDevice, 0u))
		{
			throw new ArgumentOutOfRangeException("displayNumber", displayNumber, "Number is greater than connected displays.");
		}
		if (NativeMethods.EnumDisplaySettings(lpDisplayDevice.DeviceName, -1, ref devMode) != 0)
		{
			if ((int)(devMode.dmDisplayOrientation + orientation) % 2 == 1)
			{
				int dmPelsHeight = devMode.dmPelsHeight;
				devMode.dmPelsHeight = devMode.dmPelsWidth;
				devMode.dmPelsWidth = dmPelsHeight;
			}
			switch (orientation)
			{
			case Orientations.DEGREES_CW_0:
				devMode.dmDisplayOrientation = 0;
				break;
			case Orientations.DEGREES_CW_270:
				devMode.dmDisplayOrientation = 1;
				break;
			case Orientations.DEGREES_CW_180:
				devMode.dmDisplayOrientation = 2;
				break;
			case Orientations.DEGREES_CW_90:
				devMode.dmDisplayOrientation = 3;
				break;
			}
			result = NativeMethods.ChangeDisplaySettingsEx(lpDisplayDevice.DeviceName, ref devMode, IntPtr.Zero, DisplaySettingsFlags.CDS_UPDATEREGISTRY, IntPtr.Zero);
		}
		return result;
	}

	public static DISP_CHANGE RotateAllScreens(Orientations orientation)
	{
		DISP_CHANGE result = DISP_CHANGE.Successful;
		try
		{
			uint num = 0u;
			while (++num <= 64)
			{
				DISP_CHANGE dISP_CHANGE = Rotate(num, orientation);
				if (dISP_CHANGE != 0)
				{
					result = dISP_CHANGE;
				}
			}
			return result;
		}
		catch (ArgumentOutOfRangeException)
		{
			return result;
		}
	}

	public static void ResetAllRotations()
	{
		try
		{
			uint num = 0u;
			while (++num <= 64)
			{
				Rotate(num, Orientations.DEGREES_CW_0);
			}
		}
		catch (ArgumentOutOfRangeException)
		{
		}
	}
}
