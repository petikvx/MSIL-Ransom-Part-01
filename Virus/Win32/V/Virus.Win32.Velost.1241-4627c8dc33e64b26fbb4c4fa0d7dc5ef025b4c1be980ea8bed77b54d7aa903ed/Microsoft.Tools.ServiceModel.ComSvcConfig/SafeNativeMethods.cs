using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Microsoft.Tools.ServiceModel.ComSvcConfig;

internal static class SafeNativeMethods
{
	internal const int ERROR_MORE_DATA = 234;

	internal const int ERROR_SUCCESS = 0;

	internal const int READ_CONTROL = 131072;

	internal const int SYNCHRONIZE = 1048576;

	internal const int STANDARD_RIGHTS_READ = 131072;

	internal const int STANDARD_RIGHTS_WRITE = 131072;

	internal const int KEY_QUERY_VALUE = 1;

	internal const int KEY_SET_VALUE = 2;

	internal const int KEY_CREATE_SUB_KEY = 4;

	internal const int KEY_ENUMERATE_SUB_KEYS = 8;

	internal const int KEY_NOTIFY = 16;

	internal const int KEY_CREATE_LINK = 32;

	internal const int KEY_READ = 131097;

	internal const int KEY_WRITE = 131078;

	internal const int REG_NONE = 0;

	internal const int REG_SZ = 1;

	internal const int REG_EXPAND_SZ = 2;

	internal const int KEY_WOW64_32KEY = 512;

	internal const int KEY_WOW64_64KEY = 256;

	internal const int REG_BINARY = 3;

	internal const int REG_DWORD = 4;

	internal const int REG_DWORD_LITTLE_ENDIAN = 4;

	internal const int REG_DWORD_BIG_ENDIAN = 5;

	internal const int REG_LINK = 6;

	internal const int REG_MULTI_SZ = 7;

	internal const int REG_RESOURCE_LIST = 8;

	internal const int REG_FULL_RESOURCE_DESCRIPTOR = 9;

	internal const int REG_RESOURCE_REQUIREMENTS_LIST = 10;

	internal const int REG_QWORD = 11;

	internal const int HWND_BROADCAST = 65535;

	internal const int WM_SETTINGCHANGE = 26;

	internal const string KERNEL32 = "kernel32.dll";

	internal const string USER32 = "user32.dll";

	internal const string ADVAPI32 = "advapi32.dll";

	internal const string OLE32 = "ole32.dll";

	internal const string OLEAUT32 = "oleaut32.dll";

	internal const string SHFOLDER = "shfolder.dll";

	internal const string SHIM = "mscoree.dll";

	internal const string CRYPT32 = "crypt32.dll";

	internal const string SECUR32 = "secur32.dll";

	internal const string MSCORWKS = "mscorwks.dll";

	[DllImport("ole32.dll", ExactSpelling = true, PreserveSig = false)]
	[return: MarshalAs(UnmanagedType.Interface)]
	internal static extern object DllGetClassObject([In][MarshalAs(UnmanagedType.LPStruct)] Guid rclsid, [In][MarshalAs(UnmanagedType.LPStruct)] Guid riid);

	[DllImport("advapi32.dll", BestFitMapping = false, CharSet = CharSet.Unicode)]
	internal static extern int RegOpenKeyEx(RegistryHandle hKey, string lpSubKey, int ulOptions, int samDesired, out RegistryHandle hkResult);

	[DllImport("advapi32.dll", BestFitMapping = false, CharSet = CharSet.Unicode)]
	internal static extern int RegSetValueEx(RegistryHandle hKey, string lpValueName, int Reserved, int dwType, string val, int cbData);

	[DllImport("advapi32.dll", BestFitMapping = false, CharSet = CharSet.Unicode)]
	internal static extern int RegCreateKeyEx(RegistryHandle hKey, string lpSubKey, int Reserved, string lpClass, int dwOptions, int samDesigner, IntPtr lpSecurityAttributes, out RegistryHandle hkResult, out int lpdwDisposition);

	[DllImport("advapi32.dll")]
	internal static extern int RegCloseKey(IntPtr handle);

	[DllImport("advapi32.dll", BestFitMapping = false, CharSet = CharSet.Unicode)]
	internal static extern int RegQueryValueEx(RegistryHandle hKey, string lpValueName, int[] lpReserved, ref int lpType, [Out] byte[] lpData, ref int lpcbData);

	[DllImport("advapi32.dll", BestFitMapping = false, CharSet = CharSet.Unicode)]
	internal static extern int RegDeleteKey(RegistryHandle hKey, string lpValueName);

	[DllImport("oleaut32.dll", BestFitMapping = false, CharSet = CharSet.Unicode)]
	internal static extern int CreateTypeLib2(SYSKIND sysKind, string szFile, out ICreateTypeLib ppctlib);

	[DllImport("mscoree.dll", CharSet = CharSet.Unicode)]
	internal static extern int GetRequestedRuntimeVersionForCLSID([In][MarshalAs(UnmanagedType.LPStruct)] Guid rclsid, [Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder pVersion, [In] int cchBuffer, ref int dwLength, [In] int dwResolutionFlags);

	[DllImport("mscoree.dll", CharSet = CharSet.Unicode)]
	internal static extern int CLRCreateInstance([In][MarshalAs(UnmanagedType.LPStruct)] Guid rclsid, [In][MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.Interface)] out object pMetaHost);

	internal static ICreateTypeLib CreateTypeLib(string file)
	{
		ICreateTypeLib ppctlib;
		int num = CreateTypeLib2(SYSKIND.SYS_WIN32, file, out ppctlib);
		if (num == 0)
		{
			return ppctlib;
		}
		Marshal.ThrowExceptionForHR(num);
		return null;
	}
}
