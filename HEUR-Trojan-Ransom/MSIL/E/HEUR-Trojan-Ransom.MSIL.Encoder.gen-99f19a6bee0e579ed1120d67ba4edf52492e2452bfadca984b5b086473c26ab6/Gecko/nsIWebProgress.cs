using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("bd0efb3b-1c81-4fb0-b16d-576a2be48a95")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIWebProgress
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddProgressListener([MarshalAs(UnmanagedType.Interface)] nsIWebProgressListener aListener, uint aNotifyMask);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveProgressListener([MarshalAs(UnmanagedType.Interface)] nsIWebProgressListener aListener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMWindow GetDOMWindowAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	ulong GetDOMWindowIDAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsTopLevelAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsLoadingDocumentAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetLoadTypeAttribute();
}
