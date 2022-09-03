using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UPNPLib;

[ComImport]
[Guid("E7772804-3287-418E-9072-CF2B47238981")]
[InterfaceType(1)]
public interface IUPnPDeviceDocumentAccess
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	string GetDocumentURL();
}
