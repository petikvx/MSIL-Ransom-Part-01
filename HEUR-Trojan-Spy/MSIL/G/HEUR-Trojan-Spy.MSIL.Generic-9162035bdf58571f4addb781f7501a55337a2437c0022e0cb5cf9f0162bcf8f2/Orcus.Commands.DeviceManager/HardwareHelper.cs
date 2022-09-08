using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text;
using Orcus.Native;

namespace Orcus.Commands.DeviceManager;

public static class HardwareHelper
{
	private enum SetupApiError
	{
		NoAssociatedClass = -536870400,
		NotDisableable = -536870351,
		OnlyValidateViaAuthenticode = -536870331
	}

	public class TemporaryDeviceInfo
	{
		private SP_DEVINFO_DATA _devinfoData;

		public SP_DEVINFO_DATA DeviceData => _devinfoData;

		public IntPtr HDevInfo { get; }

		public TemporaryDeviceInfo(IntPtr hDevInfo, SP_DEVINFO_DATA deviceData)
		{
			HDevInfo = hDevInfo;
			_devinfoData = deviceData;
		}

		public string GetProperty(SPDRP property)
		{
			StringBuilder stringBuilder = new StringBuilder(1024);
			if (!NativeMethods.SetupDiGetDeviceRegistryProperty(HDevInfo, ref _devinfoData, SPDRP.SPDRP_HARDWAREID, out var _, stringBuilder, (uint)stringBuilder.Capacity, out var _))
			{
				return null;
			}
			return stringBuilder.ToString();
		}
	}

	public static IEnumerable<TemporaryDeviceInfo> EnumerateDevices()
	{
		Guid ClassGuid = Guid.Empty;
		IntPtr hDevInfo = NativeMethods.SetupDiGetClassDevs(ref ClassGuid, IntPtr.Zero, IntPtr.Zero, DiGetClassFlags.DIGCF_PRESENT | DiGetClassFlags.DIGCF_ALLCLASSES);
		if (hDevInfo == new IntPtr(-1))
		{
			throw new Win32Exception("INVALID_HANDLE_VALUE");
		}
		SP_DEVINFO_DATA deviceInfoData = default(SP_DEVINFO_DATA);
		deviceInfoData.Size = Marshal.SizeOf((object)deviceInfoData);
		try
		{
			for (uint i = 0u; NativeMethods.SetupDiEnumDeviceInfo(hDevInfo, i, ref deviceInfoData); i++)
			{
				yield return new TemporaryDeviceInfo(hDevInfo, deviceInfoData);
			}
		}
		finally
		{
			if (!NativeMethods.SetupDiDestroyDeviceInfoList(hDevInfo))
			{
				throw new Exception("Failed to destroy device list");
			}
		}
	}

	public static void EnableDevice(IntPtr handle, SP_DEVINFO_DATA diData, bool enable)
	{
		PropertyChangeParameters classInstallParams = default(PropertyChangeParameters);
		classInstallParams.Size = 8;
		classInstallParams.DiFunction = DiFunction.PropertyChange;
		classInstallParams.Scope = Scopes.Global;
		classInstallParams.StateChange = (enable ? StateChangeAction.Enable : StateChangeAction.Disable);
		if (!NativeMethods.SetupDiSetClassInstallParams(handle, ref diData, ref classInstallParams, Marshal.SizeOf((object)classInstallParams)))
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		if (!NativeMethods.SetupDiCallClassInstaller(DiFunction.PropertyChange, handle, ref diData))
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			switch (lastWin32Error)
			{
			case -536870351:
				throw new ArgumentException("Device can't be disabled (programmatically or in Device Manager).");
			case -536870400:
			case -536870399:
			case -536870398:
			case -536870397:
			case -536870396:
			case -536870395:
			case -536870394:
			case -536870393:
			case -536870392:
			case -536870391:
			case -536870390:
			case -536870389:
			case -536870388:
			case -536870387:
			case -536870386:
			case -536870385:
			case -536870384:
			case -536870383:
			case -536870382:
			case -536870381:
			case -536870380:
			case -536870379:
			case -536870378:
			case -536870377:
			case -536870376:
			case -536870375:
			case -536870374:
			case -536870373:
			case -536870372:
			case -536870371:
			case -536870370:
			case -536870369:
			case -536870368:
			case -536870367:
			case -536870366:
			case -536870365:
			case -536870364:
			case -536870363:
			case -536870362:
			case -536870361:
			case -536870360:
			case -536870359:
			case -536870358:
			case -536870357:
			case -536870356:
			case -536870355:
			case -536870354:
			case -536870353:
			case -536870352:
			case -536870350:
			case -536870349:
			case -536870348:
			case -536870347:
			case -536870346:
			case -536870345:
			case -536870344:
			case -536870343:
			case -536870342:
			case -536870341:
			case -536870340:
			case -536870339:
			case -536870338:
			case -536870337:
			case -536870336:
			case -536870335:
			case -536870334:
			case -536870333:
			case -536870332:
			case -536870331:
				throw new Win32Exception("SetupAPI error: " + (SetupApiError)lastWin32Error);
			default:
				throw new Win32Exception(lastWin32Error);
			}
		}
	}
}
