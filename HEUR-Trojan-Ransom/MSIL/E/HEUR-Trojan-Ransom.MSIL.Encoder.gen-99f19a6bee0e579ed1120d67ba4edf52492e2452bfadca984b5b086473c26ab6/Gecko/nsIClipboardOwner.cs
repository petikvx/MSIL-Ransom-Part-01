using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("5A31C7A1-E122-11d2-9A57-000064657374")]
public interface nsIClipboardOwner
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void LosingOwnership([MarshalAs(UnmanagedType.Interface)] nsITransferable aTransferable);
}
