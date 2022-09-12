using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("17C4E0AA-1DD2-11B2-8029-BF6F668DE500")]
public interface nsIRDFInMemoryDataSource
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void EnsureFastContainment([MarshalAs(UnmanagedType.Interface)] nsIRDFResource aSource);
}
