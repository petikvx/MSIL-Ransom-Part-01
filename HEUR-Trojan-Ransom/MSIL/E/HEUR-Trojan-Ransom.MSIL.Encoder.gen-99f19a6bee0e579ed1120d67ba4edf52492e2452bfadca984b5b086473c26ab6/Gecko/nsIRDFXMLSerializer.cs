using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("8ae1fbf8-1dd2-11b2-bd21-d728069cca92")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIRDFXMLSerializer
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init([MarshalAs(UnmanagedType.Interface)] nsIRDFDataSource aDataSource);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddNameSpace([MarshalAs(UnmanagedType.Interface)] nsIAtom aPrefix, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aURI);
}
