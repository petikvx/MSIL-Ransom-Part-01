using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace MsGac.Fusion.Native;

internal class FusionApi
{
	private const uint IASSEMBLYCACHE_INSTALL_FLAG_REFRESH = 1u;

	private const uint IASSEMBLYCACHE_INSTALL_FLAG_FORCE_REFRESH = 2u;

	private const uint IASSEMBLYCACHE_UNINSTALL_DISPOSITION_UNINSTALLED = 1u;

	private const uint IASSEMBLYCACHE_UNINSTALL_DISPOSITION_STILL_IN_USE = 2u;

	private const uint IASSEMBLYCACHE_UNINSTALL_DISPOSITION_ALREADY_UNINSTALLED = 3u;

	private const uint IASSEMBLYCACHE_UNINSTALL_DISPOSITION_DELETE_PENDING = 4u;

	private const uint IASSEMBLYCACHE_UNINSTALL_DISPOSITION_HAS_INSTALL_REFERENCES = 5u;

	private const uint IASSEMBLYCACHE_UNINSTALL_DISPOSITION_REFERENCE_NOT_FOUND = 6u;

	public static readonly Guid FUSION_REFCOUNT_UNINSTALL_SUBKEY_GUID = new Guid("8cedc215-ac4b-488b-93c0-a50a49cb2fb8");

	public static readonly Guid FUSION_REFCOUNT_FILEPATH_GUID = new Guid("b02f9d65-fb77-4f7a-afa5-b391309f11c9");

	public static readonly Guid FUSION_REFCOUNT_OPAQUE_STRING_GUID = new Guid("2ec93463-b0c3-45e1-8364-327e96aea856");

	public static readonly Guid FUSION_REFCOUNT_MSI_GUID = new Guid("25df0fc1-7f97-4070-add7-4b13bbfd7cb8");

	[DllImport("fusion.dll", CharSet = CharSet.Unicode, PreserveSig = false)]
	public static extern void GetCachePath(ASM_CACHE_FLAGS dwCacheFlags, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder pwzCachePath, ref uint pcchPath);

	[DllImport("fusion.dll", PreserveSig = false)]
	public static extern void CreateAssemblyCache(out IAssemblyCache ppAsmCache, uint dwReserved);

	[DllImport("fusion.dll", PreserveSig = false)]
	public static extern void CreateAssemblyEnum(out IAssemblyEnum ppEnum, IntPtr pUnkReserved, IAssemblyName pName, ASM_CACHE_FLAGS dwFlags, IntPtr pvReserved);

	[DllImport("fusion.dll", CharSet = CharSet.Unicode, PreserveSig = false)]
	public static extern void CreateAssemblyNameObject(out IAssemblyName ppName, string szAssemblyName, uint dwFlags, IntPtr pvReserved);

	[DllImport("fusion.dll", PreserveSig = false)]
	public static extern void CreateInstallReferenceEnum(out IInstallReferenceEnum ppRefEnum, IAssemblyName pName, uint dwFlags, IntPtr pvReserved);

	[DllImport("fusion.dll", CharSet = CharSet.Unicode, PreserveSig = false)]
	public static extern void CreateHistoryReader(string wzFilePath, out IHistoryReader ppHistReader);

	[DllImport("fusion.dll", CharSet = CharSet.Unicode, PreserveSig = false)]
	public static extern void GetHistoryFileDirectory([MarshalAs(UnmanagedType.LPWStr)] StringBuilder wzDir, ref uint pdwSize);

	[DllImport("fusion.dll", CharSet = CharSet.Unicode, PreserveSig = false)]
	public static extern void LookupHistoryAssembly(string pwzFilePath, ref FILETIME pftActivationDate, string pwzAsmName, string pwzPublicKeyToken, string wzCulture, string pwzVerRef, out IntPtr pHistAsm);

	[DllImport("fusion.dll", PreserveSig = false)]
	public static extern void NukeDownloadedCache();

	[DllImport("fusion.dll", PreserveSig = false)]
	public static extern void CreateApplicationContext(IAssemblyName pName, out IntPtr ppCtx);

	[DllImport("shfusion.dll", CharSet = CharSet.Unicode)]
	public static extern uint PolicyManager(IntPtr hWndParent, string pwzFullyQualifiedAppPath, string pwzAppName, int dwFlags);
}
