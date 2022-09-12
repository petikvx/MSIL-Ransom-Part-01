using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("3507fc93-313e-4a4c-8ca8-4d0ea0f97315")]
public interface nsIScrollable
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetDefaultScrollbarPreferences(int scrollOrientation);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDefaultScrollbarPreferences(int scrollOrientation, int scrollbarPref);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetScrollbarVisibility([MarshalAs(UnmanagedType.U1)] ref bool verticalVisible, [MarshalAs(UnmanagedType.U1)] ref bool horizontalVisible);
}
