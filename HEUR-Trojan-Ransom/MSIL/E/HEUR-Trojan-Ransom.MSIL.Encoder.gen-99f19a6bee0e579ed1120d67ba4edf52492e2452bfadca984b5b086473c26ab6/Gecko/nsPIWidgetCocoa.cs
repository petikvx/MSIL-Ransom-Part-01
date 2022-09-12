using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("f75ff69e-3a51-419e-bd29-042f804bc2ed")]
public interface nsPIWidgetCocoa
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void SendSetZLevelEvent();

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetChildSheet([MarshalAs(UnmanagedType.U1)] bool aShown);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetRealParent();

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetSheetWindowParentAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsSheetAttribute();
}
