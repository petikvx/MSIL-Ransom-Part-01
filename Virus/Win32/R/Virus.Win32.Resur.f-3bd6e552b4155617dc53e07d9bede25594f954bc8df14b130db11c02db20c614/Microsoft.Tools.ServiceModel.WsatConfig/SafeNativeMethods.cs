using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.AccessControl;
using System.Text;
using Microsoft.Win32;

namespace Microsoft.Tools.ServiceModel.WsatConfig;

internal static class SafeNativeMethods
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct OLE_TM_CONFIG_PARAMS_V2
	{
		internal uint dwVersion;

		internal uint dwcConcurrencyHint;

		[MarshalAs(UnmanagedType.LPWStr)]
		internal string pwszClusterResourceName;
	}

	internal struct WKSTA_INFO_100
	{
		public int id;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string computername;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string langroup;

		public int ver_major;

		public int ver_minor;
	}

	[Flags]
	internal enum CLSCTX : uint
	{
		CLSCTX_INPROC_SERVER = 1u,
		CLSCTX_INPROC_HANDLER = 2u,
		CLSCTX_LOCAL_SERVER = 4u,
		CLSCTX_INPROC_SERVER16 = 8u,
		CLSCTX_REMOTE_SERVER = 0x10u,
		CLSCTX_INPROC_HANDLER16 = 0x20u,
		CLSCTX_RESERVED1 = 0x40u,
		CLSCTX_RESERVED2 = 0x80u,
		CLSCTX_RESERVED3 = 0x100u,
		CLSCTX_RESERVED4 = 0x200u,
		CLSCTX_NO_CODE_DOWNLOAD = 0x400u,
		CLSCTX_RESERVED5 = 0x800u,
		CLSCTX_NO_CUSTOM_MARSHAL = 0x1000u,
		CLSCTX_ENABLE_CODE_DOWNLOAD = 0x2000u,
		CLSCTX_NO_FAILURE_LOG = 0x4000u,
		CLSCTX_DISABLE_AAA = 0x8000u,
		CLSCTX_ENABLE_AAA = 0x10000u,
		CLSCTX_FROM_DEFAULT_CONTEXT = 0x20000u,
		CLSCTX_INPROC = 3u,
		CLSCTX_SERVER = 0x15u,
		CLSCTX_ALL = 0x17u
	}

	internal const int X509_ASN_ENCODING = 1;

	internal const int CERT_FIND_ANY = 0;

	internal const int CERT_REGISTRY_STORE_REMOTE_FLAG = 65536;

	internal const int CERT_STORE_OPEN_EXISTING_FLAG = 16384;

	internal const int CERT_STORE_READONLY_FLAG = 32768;

	internal const int CERT_STORE_PROV_REG = 4;

	internal const int CRYPTUI_SELECT_LOCATION_COLUMN = 16;

	internal const int GMEM_SHARE = 8192;

	internal const int LMEM_ZEROINIT = 64;

	internal const int WM_USER = 1024;

	internal const int TCM_FIRST = 4864;

	internal const int PSM_GETCURRENTPAGEHWND = 1142;

	internal const int PSM_INDEXTOHWND = 1154;

	internal const int PSM_GETTABCONTROL = 1140;

	internal const int TCM_GETITEMCOUNT = 4868;

	internal const int ErrorAlreadyExists = 183;

	internal const int NoError = 0;

	internal const int FileNotFound = 2;

	internal const int ErrorInvalidParameter = 87;

	internal const int HTTP_INITIALIZE_CONFIG = 2;

	internal const int HTTP_SERVICE_CONFIG_SSL_FLAG_NEGOTIATE_CLIENT_CERT = 2;

	internal const int OLE_TM_FLAG_NONE = 0;

	internal const int DWL_MSGRESULT = 0;

	internal const int NERR_Success = 0;

	internal const int KEY_WOW64_64KEY = 256;

	internal const int KEY_QUERY_VALUE = 1;

	internal const int KEY_READ = 131097;

	internal const string XOleHlp = "xolehlp.dll";

	internal const string HttpApi = "httpapi.dll";

	internal const string CryptUI = "Cryptui.dll";

	internal const string Crypt32 = "Crypt32.dll";

	internal const string User32 = "User32.dll";

	internal const string Kernel32 = "Kernel32.dll";

	internal const string AdvApi32 = "Advapi32.DLL";

	internal const string NetApi32 = "netapi32.dll";

	internal const uint OLE_TM_CONFIG_VERSION_2 = 2u;

	internal const uint COINIT_APARTMENTTHREADED = 2u;

	internal const string Ole32 = "ole32.dll";

	internal const string ClusApi = "clusapi.dll";

	internal const uint ERROR_SUCCESS = 0u;

	internal const uint ERROR_FILE_NOT_FOUND = 2u;

	internal const uint ERROR_INSUFFICIENT_BUFFER = 122u;

	internal const uint ERROR_MORE_DATA = 234u;

	internal const uint ERROR_NO_MORE_ITEMS = 259u;

	internal const uint REG_OPTION_NON_VOLATILE = 0u;

	[DllImport("xolehlp.dll", CharSet = CharSet.Unicode)]
	internal static extern int DtcGetTransactionManagerEx([In][MarshalAs(UnmanagedType.LPWStr)] string hostName, [In][MarshalAs(UnmanagedType.LPWStr)] string tmName, [In] ref Guid riid, [In] uint grfOptions, [In] IntPtr pvConfigParams, [MarshalAs(UnmanagedType.Interface)] out IDtcNetworkAccessConfig idtcnac);

	[DllImport("xolehlp.dll", CharSet = CharSet.Unicode, EntryPoint = "DtcGetTransactionManagerEx")]
	internal static extern int DtcGetTransactionManagerEx_1([In][MarshalAs(UnmanagedType.LPWStr)] string hostName, [In][MarshalAs(UnmanagedType.LPWStr)] string tmName, [In] ref Guid riid, [In] uint grfOptions, [In] ref OLE_TM_CONFIG_PARAMS_V2 pvConfigParams, [MarshalAs(UnmanagedType.Interface)] out IDtcNetworkAccessConfig idtcnac);

	[DllImport("httpapi.dll")]
	internal static extern int HttpDeleteServiceConfiguration([In] IntPtr serviceIntPtr, [In] HttpServiceConfigId configId, [In] ref HttpServiceConfigUrlAclSet configInformation, [In] int configInformationLength, [In] IntPtr pOverlapped);

	[DllImport("httpapi.dll", EntryPoint = "HttpDeleteServiceConfiguration")]
	internal static extern int HttpDeleteServiceConfiguration_1([In] IntPtr serviceIntPtr, [In] HttpServiceConfigId configId, [In] ref HttpServiceConfigSslSet configInformation, [In] int configInformationLength, [In] IntPtr pOverlapped);

	[DllImport("httpapi.dll")]
	internal static extern int HttpInitialize([In] HttpApiVersion version, [In] int flags, [In] IntPtr pReserved);

	[DllImport("httpapi.dll")]
	internal static extern int HttpSetServiceConfiguration([In] IntPtr serviceIntPtr, [In] HttpServiceConfigId configId, [In] ref HttpServiceConfigUrlAclSet configInformation, [In] int configInformationLength, [In] IntPtr pOverlapped);

	[DllImport("httpapi.dll", EntryPoint = "HttpSetServiceConfiguration")]
	internal static extern int HttpSetServiceConfiguration_1([In] IntPtr serviceIntPtr, [In] HttpServiceConfigId configId, [In] ref HttpServiceConfigSslSet configInformation, [In] int configInformationLength, [In] IntPtr pOverlapped);

	[DllImport("httpapi.dll")]
	internal static extern uint HttpTerminate([In] int Flags, [In] IntPtr pReserved);

	[DllImport("Crypt32.dll", SetLastError = true)]
	internal static extern SafeCertificateStore CertOpenStore([In] int lpszStoreProvider, [In] int dwMsgAndCertEncodingType, [In] int hCryptProvider, [In] int dwFlags, [In] SafeRegistryKey pvPara);

	[DllImport("Crypt32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool CertCloseStore([In] IntPtr hCertStore, [In] int dwFlags);

	[DllImport("Crypt32.dll", SetLastError = true)]
	internal static extern SafeCertificateContext CertFindCertificateInStore([In] SafeCertificateStore hCertStore, [In] int dwCertEncodingType, [In] int dwFindFlags, [In] int dwFindType, [In] IntPtr pvFindPara, [In] SafeCertificateContext pPrevCertContext);

	[DllImport("Crypt32.dll", CallingConvention = CallingConvention.StdCall)]
	[SuppressUnmanagedCodeSecurity]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal static extern int CertFreeCertificateContext([In] IntPtr pCertContext);

	[DllImport("Advapi32.DLL", CharSet = CharSet.Unicode)]
	internal static extern int RegOpenKeyEx([In] SafeRegistryKey hKey, [In][MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, [In] uint options, [In] int sam, out SafeRegistryKey phkResult);

	[DllImport("Advapi32.DLL", CallingConvention = CallingConvention.StdCall)]
	[SuppressUnmanagedCodeSecurity]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal static extern int RegCloseKey([In] IntPtr hKey);

	[DllImport("Kernel32.dll", SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal static extern IntPtr LocalFree([In] IntPtr handle);

	[DllImport("Kernel32.dll", SetLastError = true)]
	internal static extern IntPtr LocalAlloc([In] int uFlags, [In] int uBytes);

	[DllImport("Kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern IntPtr LoadLibrary([In] string lpFileName);

	[DllImport("Kernel32.dll", SetLastError = true)]
	internal static extern bool FreeLibrary(IntPtr hModule);

	[DllImport("User32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern int LoadString(IntPtr hInstance, uint uID, StringBuilder lpBuffer, int nBufferMax);

	[DllImport("netapi32.dll", CharSet = CharSet.Unicode)]
	internal static extern int NetWkstaGetInfo(string servername, int level, out IntPtr bufptr);

	[DllImport("netapi32.dll", SetLastError = true)]
	internal static extern int NetApiBufferFree(IntPtr bufptr);

	[DllImport("ole32.dll")]
	internal static extern int CoInitializeEx([In] IntPtr pvReserved, [In] uint dwCoInit);

	[DllImport("ole32.dll", CharSet = CharSet.Unicode)]
	internal static extern int CoGetClassObject([In][MarshalAs(UnmanagedType.LPStruct)] Guid rclsid, [In] CLSCTX dwClsContext, [In] IntPtr pServerInfo, [In][MarshalAs(UnmanagedType.LPStruct)] Guid riid, out SafeIUnknown ppv);

	[DllImport("ole32.dll")]
	internal static extern void CoUninitialize();

	[DllImport("clusapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern SafeHCluster OpenCluster([In][MarshalAs(UnmanagedType.LPWStr)] string lpszClusterName);

	[DllImport("clusapi.dll", CharSet = CharSet.Unicode)]
	internal static extern int GetClusterInformation([In] SafeHCluster hCluster, [Out] StringBuilder lpszClusterName, [In][Out] ref uint lpcchClusterName, [In][Out] IntPtr lpClusterInfo);

	[DllImport("clusapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern SafeHClusEnum ClusterOpenEnum([In] SafeHCluster hCluster, [In] ClusterEnum dwType);

	[DllImport("clusapi.dll", CharSet = CharSet.Unicode)]
	internal static extern uint ClusterEnum([In] SafeHClusEnum hEnum, [In] uint dwIndex, out uint lpdwType, [Out] StringBuilder lpszName, [In][Out] ref uint lpcchName);

	[DllImport("clusapi.dll", CharSet = CharSet.Unicode)]
	internal static extern uint ClusterResourceControl([In] SafeHResource hResource, [In] IntPtr hHostNode, [In] ClusterResourceControlCode dwControlCode, [In] IntPtr lpInBuffer, [In] uint cbInBufferSize, [In][Out][MarshalAs(UnmanagedType.LPArray)] byte[] buffer, [In] uint cbOutBufferSize, [In][Out] ref uint lpcbBytesReturned);

	[DllImport("clusapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern SafeHResource OpenClusterResource([In] SafeHCluster hCluster, [In][MarshalAs(UnmanagedType.LPWStr)] string lpszResourceName);

	[DllImport("clusapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern bool GetClusterResourceNetworkName([In] SafeHResource hResource, [Out] StringBuilder lpBuffer, [In][Out] ref uint nSize);

	[DllImport("clusapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern SafeHKey GetClusterResourceKey([In] SafeHResource hResource, [In] RegistryRights samDesired);

	[DllImport("clusapi.dll", CharSet = CharSet.Unicode)]
	internal static extern int ClusterRegCreateKey([In] SafeHKey hKey, [In][MarshalAs(UnmanagedType.LPWStr)] string lpszSubKey, [In] uint dwOption, [In] RegistryRights samDesired, [In] IntPtr lpSecurityAttributes, out SafeHKey phkResult, out int lpdwDisposition);

	[DllImport("clusapi.dll", CharSet = CharSet.Unicode)]
	internal static extern int ClusterRegQueryValue([In] SafeHKey hKey, [In][MarshalAs(UnmanagedType.LPWStr)] string lpszValueName, out RegistryValueKind lpdwValueType, [Out][MarshalAs(UnmanagedType.LPArray)] byte[] lpbData, [In][Out] ref uint lpcbData);

	[DllImport("clusapi.dll", CharSet = CharSet.Unicode)]
	internal static extern int ClusterRegSetValue([In] SafeHKey hKey, [In][MarshalAs(UnmanagedType.LPWStr)] string lpszValueName, [In] RegistryValueKind lpdwValueType, [In][MarshalAs(UnmanagedType.LPArray)] byte[] lpbData, [In] uint lpcbData);

	[DllImport("clusapi.dll", CharSet = CharSet.Unicode)]
	internal static extern int ClusterRegGetKeySecurity([In] SafeHKey hKey, [In] SecurityInfos securityInformation, [In][Out] byte[] securityDescriptor, [In][Out] ref uint lpcbSecurityDescriptor);

	[DllImport("clusapi.dll", CharSet = CharSet.Unicode)]
	internal static extern int ClusterRegSetKeySecurity([In] SafeHKey hKey, [In] SecurityInfos securityInformation, [In] byte[] securityDescriptor);
}
