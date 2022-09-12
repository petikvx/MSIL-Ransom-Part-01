using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("1f84fd56-3956-40df-b86a-1ea01402ee96")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIPrefService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void ReadUserPrefs([MarshalAs(UnmanagedType.Interface)] nsIFile aFile);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ResetPrefs();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ResetUserPrefs();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SavePrefFile([MarshalAs(UnmanagedType.Interface)] nsIFile aFile);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIPrefBranch GetBranch([MarshalAs(UnmanagedType.LPStr)] string aPrefRoot);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIPrefBranch GetDefaultBranch([MarshalAs(UnmanagedType.LPStr)] string aPrefRoot);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetDirtyAttribute();
}
