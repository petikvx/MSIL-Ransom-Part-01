using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("b81c33a6-1ce8-4695-856b-02b7f15cc114")]
public interface nsIToolkitProfileService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetStartWithLastProfileAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetStartWithLastProfileAttribute([MarshalAs(UnmanagedType.U1)] bool aStartWithLastProfile);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetStartOfflineAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetStartOfflineAttribute([MarshalAs(UnmanagedType.U1)] bool aStartOffline);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISimpleEnumerator GetProfilesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIToolkitProfile GetSelectedProfileAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSelectedProfileAttribute([MarshalAs(UnmanagedType.Interface)] nsIToolkitProfile aSelectedProfile);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIToolkitProfile GetDefaultProfileAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDefaultProfileAttribute([MarshalAs(UnmanagedType.Interface)] nsIToolkitProfile aDefaultProfile);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIToolkitProfile GetProfileByName([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIProfileLock LockProfilePath([MarshalAs(UnmanagedType.Interface)] nsIFile aDirectory, [MarshalAs(UnmanagedType.Interface)] nsIFile aTempDirectory);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIToolkitProfile CreateProfile([MarshalAs(UnmanagedType.Interface)] nsIFile aRootDir, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIToolkitProfile CreateDefaultProfileForApp([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aProfileName, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aAppName, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aVendorName, [MarshalAs(UnmanagedType.Interface)] nsIFile aProfileDefaultsDir);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetProfileCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Flush();
}
