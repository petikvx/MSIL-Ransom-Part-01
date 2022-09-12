using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("951700F0-FED0-11D2-BDD9-00104BDE6048")]
public interface nsIRDFPurgeableDataSource
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool Mark([MarshalAs(UnmanagedType.Interface)] nsIRDFResource aSource, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aProperty, [MarshalAs(UnmanagedType.Interface)] nsIRDFNode aTarget, [MarshalAs(UnmanagedType.U1)] bool aTruthValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Sweep();
}
