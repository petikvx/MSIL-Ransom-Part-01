using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("7d65452e-c167-4cba-a0e3-ddc61bdde8c3")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIPluginInstanceOwner
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetInstance(IntPtr aInstance);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetInstance();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetWindow(IntPtr aWindow);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetModeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CreateWidget();

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetDocumentAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InvalidateRect(IntPtr aRect);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InvalidateRegion(IntPtr aRegion);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RedrawPlugin();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetNetscapeWindow(IntPtr aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetEventModel(int eventModel);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CallSetWindow();

	[MethodImpl(MethodImplOptions.InternalCall)]
	double GetContentsScaleFactor();
}
