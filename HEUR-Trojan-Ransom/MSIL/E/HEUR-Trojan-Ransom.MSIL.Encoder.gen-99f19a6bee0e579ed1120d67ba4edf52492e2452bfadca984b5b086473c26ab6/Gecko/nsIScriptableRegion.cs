using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("a5f44cc7-2820-489b-b817-ae8a08506ff6")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIScriptableRegion
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetToRegion([MarshalAs(UnmanagedType.Interface)] nsIScriptableRegion aRegion);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetToRect(int aX, int aY, int aWidth, int aHeight);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void IntersectRegion([MarshalAs(UnmanagedType.Interface)] nsIScriptableRegion aRegion);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void IntersectRect(int aX, int aY, int aWidth, int aHeight);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UnionRegion([MarshalAs(UnmanagedType.Interface)] nsIScriptableRegion aRegion);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UnionRect(int aX, int aY, int aWidth, int aHeight);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SubtractRegion([MarshalAs(UnmanagedType.Interface)] nsIScriptableRegion aRegion);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SubtractRect(int aX, int aY, int aWidth, int aHeight);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsEmpty();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsEqualRegion([MarshalAs(UnmanagedType.Interface)] nsIScriptableRegion aRegion);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetBoundingBox(ref int aX, ref int aY, ref int aWidth, ref int aHeight);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Offset(int aXOffset, int aYOffset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetRects(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool ContainsRect(int aX, int aY, int aWidth, int aHeight);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetRegionAttribute();
}
