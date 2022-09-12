using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("f0edfcdd-8bca-4d32-9226-7421001396a4")]
public interface rdfISerializer
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Serialize(rdfIDataSource aDataSource, [MarshalAs(UnmanagedType.Interface)] nsIOutputStream aOut);
}
