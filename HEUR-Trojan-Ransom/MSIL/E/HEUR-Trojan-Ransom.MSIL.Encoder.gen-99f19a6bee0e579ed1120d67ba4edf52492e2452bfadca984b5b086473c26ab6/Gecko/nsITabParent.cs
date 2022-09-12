using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("7615408c-1fb3-4128-8dd5-a3e2f3fa8842")]
public interface nsITabParent
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void InjectTouchEvent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aType, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 8)] uint[] aIdentifiers, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 8)] int[] aXs, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 8)] int[] aYs, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 8)] uint[] aRxs, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 8)] uint[] aRys, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 8)] float[] aRotationAngles, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 8)] float[] aForces, uint count, int aModifiers);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetChildProcessOffset(ref int aCssX, ref int aCssY);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetUseAsyncPanZoomAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetDocShellIsActiveAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDocShellIsActiveAttribute([MarshalAs(UnmanagedType.U1)] bool aDocShellIsActive);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDocShellIsActiveAndForeground([MarshalAs(UnmanagedType.U1)] bool aIsActive);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SuppressDisplayport([MarshalAs(UnmanagedType.U1)] bool aEnabled);

	[MethodImpl(MethodImplOptions.InternalCall)]
	ulong GetTabIdAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void NavigateByKey([MarshalAs(UnmanagedType.U1)] bool aForward, [MarshalAs(UnmanagedType.U1)] bool aForDocumentNavigation);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetHasContentOpenerAttribute();
}
