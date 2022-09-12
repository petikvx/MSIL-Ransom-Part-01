using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("438307fd-0c68-4d79-922a-f6cc9550cd02")]
public interface nsIClipboardHelper
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void CopyStringToClipboard([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aString, int aClipboardID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CopyString([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aString);
}
