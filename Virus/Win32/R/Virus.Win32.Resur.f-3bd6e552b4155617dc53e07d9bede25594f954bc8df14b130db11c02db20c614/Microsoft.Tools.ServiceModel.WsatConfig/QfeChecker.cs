using System;

namespace Microsoft.Tools.ServiceModel.WsatConfig;

internal static class QfeChecker
{
	private const string CLSID_CGatewayProtocol = "{37de7045-5056-456f-8409-c871e0f8b0e0}";

	private const string IID_IClassFactory = "{00000001-0000-0000-C000-000000000046}";

	private const string RegKeyClassIdRoot = "SOFTWARE\\Classes\\CLSID\\";

	public static void CheckQfe()
	{
		bool flag = false;
		int num = SafeNativeMethods.CoInitializeEx(IntPtr.Zero, 2u);
		if (num >= 0)
		{
			try
			{
				SafeIUnknown ppv = null;
				num = SafeNativeMethods.CoGetClassObject(new Guid("{37de7045-5056-456f-8409-c871e0f8b0e0}"), SafeNativeMethods.CLSCTX.CLSCTX_INPROC_SERVER, IntPtr.Zero, new Guid("{00000001-0000-0000-C000-000000000046}"), out ppv);
				flag = (num >= 0 && ppv != null) || RegistryEntryExists();
			}
			finally
			{
				SafeNativeMethods.CoUninitialize();
			}
		}
		if (!flag)
		{
			throw new WsatAdminException(WsatAdminErrorCode.CANNOT_ENABLE_NETWORK_SUPPORT_WHEN_QFE_IS_NOT_INSTALLED, SR.GetString("ErrorNoQFE"));
		}
	}

	private static bool RegistryEntryExists()
	{
		bool result = false;
		using SafeRegistryKey hKey = new SafeRegistryKey(new IntPtr(-2147483646), ownsHandle: false);
		SafeRegistryKey phkResult = null;
		if (SafeNativeMethods.RegOpenKeyEx(hKey, "SOFTWARE\\Classes\\CLSID\\{37de7045-5056-456f-8409-c871e0f8b0e0}", 0u, 257, out phkResult) == 0)
		{
			if (phkResult != null)
			{
				if (!phkResult.IsInvalid)
				{
					result = true;
					phkResult.Close();
					return result;
				}
				return result;
			}
			return result;
		}
		return result;
	}
}
