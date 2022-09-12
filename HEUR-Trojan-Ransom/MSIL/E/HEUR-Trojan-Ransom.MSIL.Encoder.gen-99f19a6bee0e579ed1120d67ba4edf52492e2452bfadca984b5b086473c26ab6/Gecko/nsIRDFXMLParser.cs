using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("1831dd2e-1dd2-11b2-bdb3-86b7b50b70b5")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIRDFXMLParser
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIStreamListener ParseAsync([MarshalAs(UnmanagedType.Interface)] nsIRDFDataSource aSink, [MarshalAs(UnmanagedType.Interface)] nsIURI aBaseURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ParseString([MarshalAs(UnmanagedType.Interface)] nsIRDFDataSource aSink, [MarshalAs(UnmanagedType.Interface)] nsIURI aBaseURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aSource);
}
