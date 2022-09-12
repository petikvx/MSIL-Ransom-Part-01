using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("03b41c3d-0816-4134-8b2e-4f5afbdb1f06")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIApplicationCacheService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void BuildGroupID([MarshalAs(UnmanagedType.Interface)] nsIURI aManifestURL, [MarshalAs(UnmanagedType.Interface)] nsILoadContextInfo aLoadContextInfo, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void BuildGroupIDForApp([MarshalAs(UnmanagedType.Interface)] nsIURI aManifestURL, uint aAppID, [MarshalAs(UnmanagedType.U1)] bool aInBrowser, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIApplicationCache CreateApplicationCache([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase group);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIApplicationCache CreateCustomApplicationCache([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase group, [MarshalAs(UnmanagedType.Interface)] nsIFile profileDir, int quota);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIApplicationCache GetApplicationCache([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase clientID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIApplicationCache GetActiveCache([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase group);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeactivateGroup([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase group);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DiscardByAppId(int appID, [MarshalAs(UnmanagedType.U1)] bool discardOnlyBrowserEntries);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIApplicationCache ChooseApplicationCache([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase key, [MarshalAs(UnmanagedType.Interface)] nsILoadContextInfo aLoadContextInfo);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CacheOpportunistically([MarshalAs(UnmanagedType.Interface)] nsIApplicationCache cache, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase key);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetGroups(ref uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ref string[] groupIDs);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetGroupsTimeOrdered(ref uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ref string[] groupIDs);
}
