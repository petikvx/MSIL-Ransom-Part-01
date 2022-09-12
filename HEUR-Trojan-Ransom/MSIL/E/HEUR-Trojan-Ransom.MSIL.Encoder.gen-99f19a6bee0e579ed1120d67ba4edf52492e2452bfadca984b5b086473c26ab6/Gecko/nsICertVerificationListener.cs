using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("6684bce9-50db-48e1-81b7-98102bf81357")]
public interface nsICertVerificationListener
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Notify([MarshalAs(UnmanagedType.Interface)] nsIX509Cert verifiedCert, [MarshalAs(UnmanagedType.Interface)] nsICertVerificationResult result);
}
