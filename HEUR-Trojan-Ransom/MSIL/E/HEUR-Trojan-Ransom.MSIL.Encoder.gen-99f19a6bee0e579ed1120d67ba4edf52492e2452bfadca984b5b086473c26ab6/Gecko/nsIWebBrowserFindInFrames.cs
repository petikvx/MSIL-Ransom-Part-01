using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("e0f5d182-34bc-11d5-be5b-b760676c6ebc")]
public interface nsIWebBrowserFindInFrames
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMWindow GetCurrentSearchFrameAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCurrentSearchFrameAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aCurrentSearchFrame);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMWindow GetRootSearchFrameAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetRootSearchFrameAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aRootSearchFrame);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetSearchSubframesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSearchSubframesAttribute([MarshalAs(UnmanagedType.U1)] bool aSearchSubframes);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetSearchParentFramesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSearchParentFramesAttribute([MarshalAs(UnmanagedType.U1)] bool aSearchParentFrames);
}
