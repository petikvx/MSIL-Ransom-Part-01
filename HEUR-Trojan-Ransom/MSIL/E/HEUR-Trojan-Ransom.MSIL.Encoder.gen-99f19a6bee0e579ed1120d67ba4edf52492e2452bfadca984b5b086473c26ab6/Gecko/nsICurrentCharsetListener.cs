using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("CF9428C1-DF50-11d3-9D0C-0050040007B2")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsICurrentCharsetListener
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCurrentCharset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string charset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCurrentMailCharset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string charset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCurrentComposerCharset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string charset);
}
