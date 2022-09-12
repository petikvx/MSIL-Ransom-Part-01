using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("249f52a3-2599-4b00-ba40-0481364831a2")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIUTF8ConverterService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void ConvertStringToUTF8([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aString, [MarshalAs(UnmanagedType.LPStr)] string aCharset, [MarshalAs(UnmanagedType.U1)] bool aSkipCheck, [MarshalAs(UnmanagedType.U1)] bool aAllowSubstitution, int argc, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ConvertURISpecToUTF8([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aSpec, [MarshalAs(UnmanagedType.LPStr)] string aCharset, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);
}
