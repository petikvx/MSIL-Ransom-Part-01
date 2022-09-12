using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("4DA56F10-99FE-11d2-8EBB-00805F29F370")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIRDFXMLSource
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Serialize([MarshalAs(UnmanagedType.Interface)] nsIOutputStream aStream);
}
