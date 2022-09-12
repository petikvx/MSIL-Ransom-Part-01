using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("b3b8124f-0abb-460e-88ac-3cf1a0134b2d")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsISaveAsCharset
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetCharsetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aCharset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase charset, uint ignored, uint alsoIgnored);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Convert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase inString, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);
}
