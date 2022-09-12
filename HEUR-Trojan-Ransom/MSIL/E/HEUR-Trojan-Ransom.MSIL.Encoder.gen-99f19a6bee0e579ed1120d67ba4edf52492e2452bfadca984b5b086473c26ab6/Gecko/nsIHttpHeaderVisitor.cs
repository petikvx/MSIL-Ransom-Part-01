using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("35412859-b9d9-423c-8866-2d4559fdd2be")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIHttpHeaderVisitor
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void VisitHeader([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aHeader, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aValue);
}
