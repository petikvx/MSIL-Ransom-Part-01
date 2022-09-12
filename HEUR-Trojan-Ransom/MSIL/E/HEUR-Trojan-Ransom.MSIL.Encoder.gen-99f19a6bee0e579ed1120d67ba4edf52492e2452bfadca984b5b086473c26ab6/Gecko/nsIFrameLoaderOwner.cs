using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("c4abebcf-55f3-47d4-af15-151311971255")]
public interface nsIFrameLoaderOwner
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetFrameLoaderAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetFrameLoader();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetIsPrerendered();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SwapFrameLoaders(IntPtr aOtherOwner);
}
