using System;
using System.Text;
using Microsoft.Win32.SafeHandles;

namespace Microsoft.Tools.ServiceModel.ComSvcConfig;

internal class RegistryHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	internal static readonly RegistryHandle HKEY_CLASSES_ROOT = new RegistryHandle(new IntPtr(int.MinValue), ownHandle: false);

	internal static readonly RegistryHandle HKEY_CURRENT_USER = new RegistryHandle(new IntPtr(-2147483647), ownHandle: false);

	internal static readonly RegistryHandle HKEY_LOCAL_MACHINE = new RegistryHandle(new IntPtr(-2147483646), ownHandle: false);

	internal static readonly RegistryHandle HKEY_USERS = new RegistryHandle(new IntPtr(-2147483645), ownHandle: false);

	internal static readonly RegistryHandle HKEY_PERFORMANCE_DATA = new RegistryHandle(new IntPtr(-2147483644), ownHandle: false);

	internal static readonly RegistryHandle HKEY_CURRENT_CONFIG = new RegistryHandle(new IntPtr(-2147483643), ownHandle: false);

	internal static readonly RegistryHandle HKEY_DYN_DATA = new RegistryHandle(new IntPtr(-2147483642), ownHandle: false);

	private static RegistryHandle GetHKCR()
	{
		RegistryHandle hkResult = null;
		if (SafeNativeMethods.RegOpenKeyEx(HKEY_LOCAL_MACHINE, "Software\\Classes", 0, 131103, out hkResult) != 0 || hkResult == null || hkResult.IsInvalid)
		{
			throw Tool.CreateException(SR.GetString("FailedToOpenRegistryKey", ""), null);
		}
		return hkResult;
	}

	private static RegistryHandle Get64bitHKCR()
	{
		RegistryHandle hkResult = null;
		if (SafeNativeMethods.RegOpenKeyEx(HKEY_LOCAL_MACHINE, "Software\\Classes", 0, 131359, out hkResult) != 0 || hkResult == null || hkResult.IsInvalid)
		{
			throw Tool.CreateException(SR.GetString("FailedToOpenRegistryKey", ""), null);
		}
		return hkResult;
	}

	private static RegistryHandle Get32bitHKCR()
	{
		RegistryHandle hkResult = null;
		if (SafeNativeMethods.RegOpenKeyEx(HKEY_LOCAL_MACHINE, "Software\\Classes", 0, 131615, out hkResult) != 0 || hkResult == null || hkResult.IsInvalid)
		{
			throw Tool.CreateException(SR.GetString("FailedToOpenRegistryKey", ""), null);
		}
		return hkResult;
	}

	private static RegistryHandle GetCorrectBitnessHive(bool is64bit)
	{
		if (is64bit && IntPtr.Size == 8)
		{
			return GetHKCR();
		}
		if (is64bit && IntPtr.Size == 4)
		{
			return Get64bitHKCR();
		}
		if (!is64bit && IntPtr.Size == 8)
		{
			return Get32bitHKCR();
		}
		if (is64bit || IntPtr.Size != 4)
		{
			throw Tool.CreateException(SR.GetString("UnableToDetermineHiveBitness"), null);
		}
		return GetHKCR();
	}

	public static RegistryHandle GetBitnessHKCR(bool is64bit)
	{
		return GetCorrectBitnessHive(is64bit);
	}

	public static RegistryHandle GetCorrectBitnessHKLMSubkey(bool is64bit, string key)
	{
		if (is64bit && IntPtr.Size == 8)
		{
			return GetHKLMSubkey(key);
		}
		if (is64bit && IntPtr.Size == 4)
		{
			return Get64bitHKLMSubkey(key);
		}
		if (!is64bit && IntPtr.Size == 8)
		{
			return Get32bitHKLMSubkey(key);
		}
		if (is64bit || IntPtr.Size != 4)
		{
			throw Tool.CreateException(SR.GetString("UnableToDetermineHiveBitness"), null);
		}
		return GetHKLMSubkey(key);
	}

	public static int TryGetCorrectBitnessHKLMSubkey(bool is64bit, string key, out RegistryHandle regHandle)
	{
		if (is64bit && IntPtr.Size == 8)
		{
			return SafeNativeMethods.RegOpenKeyEx(HKEY_LOCAL_MACHINE, key, 0, 131103, out regHandle);
		}
		if (is64bit && IntPtr.Size == 4)
		{
			return SafeNativeMethods.RegOpenKeyEx(HKEY_LOCAL_MACHINE, key, 0, 131359, out regHandle);
		}
		if (!is64bit && IntPtr.Size == 8)
		{
			return SafeNativeMethods.RegOpenKeyEx(HKEY_LOCAL_MACHINE, key, 0, 131615, out regHandle);
		}
		if (is64bit || IntPtr.Size != 4)
		{
			throw Tool.CreateException(SR.GetString("UnableToDetermineHiveBitness"), null);
		}
		return SafeNativeMethods.RegOpenKeyEx(HKEY_LOCAL_MACHINE, key, 0, 131103, out regHandle);
	}

	private static RegistryHandle GetHKLMSubkey(string key)
	{
		RegistryHandle hkResult = null;
		if (SafeNativeMethods.RegOpenKeyEx(HKEY_LOCAL_MACHINE, key, 0, 131103, out hkResult) != 0 || hkResult == null || hkResult.IsInvalid)
		{
			throw Tool.CreateException(SR.GetString("FailedToOpenRegistryKey", ""), null);
		}
		return hkResult;
	}

	private static RegistryHandle Get64bitHKLMSubkey(string key)
	{
		RegistryHandle hkResult = null;
		if (SafeNativeMethods.RegOpenKeyEx(HKEY_LOCAL_MACHINE, key, 0, 131359, out hkResult) != 0 || hkResult == null || hkResult.IsInvalid)
		{
			throw Tool.CreateException(SR.GetString("FailedToOpenRegistryKey", ""), null);
		}
		return hkResult;
	}

	private static RegistryHandle Get32bitHKLMSubkey(string key)
	{
		RegistryHandle hkResult = null;
		if (SafeNativeMethods.RegOpenKeyEx(HKEY_LOCAL_MACHINE, key, 0, 131615, out hkResult) != 0 || hkResult == null || hkResult.IsInvalid)
		{
			throw Tool.CreateException(SR.GetString("FailedToOpenRegistryKey", ""), null);
		}
		return hkResult;
	}

	public RegistryHandle(IntPtr hKey, bool ownHandle)
		: base(ownHandle)
	{
		handle = hKey;
	}

	public RegistryHandle()
		: base(ownsHandle: true)
	{
	}

	public bool DeleteKey(string key)
	{
		if (SafeNativeMethods.RegDeleteKey(this, key) == 0)
		{
			return true;
		}
		return false;
	}

	public RegistryHandle CreateSubKey(string subKey)
	{
		RegistryHandle hkResult = null;
		if (SafeNativeMethods.RegCreateKeyEx(this, subKey, 0, null, 0, 131103, IntPtr.Zero, out hkResult, out var _) != 0 || hkResult == null || hkResult.IsInvalid)
		{
			Tool.CreateException(SR.GetString("FailedToCreateSubKey", subKey), null);
		}
		return hkResult;
	}

	public void SetValue(string valName, string value)
	{
		if (SafeNativeMethods.RegSetValueEx(this, valName, 0, 1, value, value.Length * 2 + 2) != 0)
		{
			Tool.CreateException(SR.GetString("FailedToSetValue", valName), null);
		}
	}

	public string GetStringValue(string valName)
	{
		int lpType = 0;
		int lpcbData = 0;
		if (SafeNativeMethods.RegQueryValueEx(this, valName, null, ref lpType, null, ref lpcbData) == 0 && lpType == 1)
		{
			byte[] array = new byte[lpcbData];
			int num = SafeNativeMethods.RegQueryValueEx(this, valName, null, ref lpType, array, ref lpcbData);
			UnicodeEncoding unicodeEncoding = new UnicodeEncoding();
			return unicodeEncoding.GetString(array);
		}
		return null;
	}

	protected override bool ReleaseHandle()
	{
		if (SafeNativeMethods.RegCloseKey(handle) == 0)
		{
			return true;
		}
		return false;
	}
}
