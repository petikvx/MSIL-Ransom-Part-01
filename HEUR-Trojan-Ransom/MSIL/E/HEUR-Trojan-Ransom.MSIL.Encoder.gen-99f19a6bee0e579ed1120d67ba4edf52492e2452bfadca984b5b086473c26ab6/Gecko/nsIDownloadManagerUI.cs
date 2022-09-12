using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("0c76d4cf-0b06-4c1a-9bea-520c7bbdba99")]
public interface nsIDownloadManagerUI
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Show([MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor aWindowContext, [MarshalAs(UnmanagedType.Interface)] nsIDownload aDownload, short aReason, [MarshalAs(UnmanagedType.U1)] bool aUsePrivateUI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetVisibleAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAttention();
}
