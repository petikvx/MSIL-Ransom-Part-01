using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UPNPLib;

[ComImport]
[InterfaceType(1)]
[Guid("C4BC4050-6178-4BD1-A4B8-6398321F3247")]
public interface IUPnPDeviceDocumentAccessEx
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	string GetDocument();
}
