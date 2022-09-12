using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("050cdc00-3b8e-11d3-9ce4-a458f454fcbc")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDocumentStateListener
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void NotifyDocumentCreated();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void NotifyDocumentWillBeDestroyed();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void NotifyDocumentStateChanged([MarshalAs(UnmanagedType.U1)] bool nowDirty);
}
