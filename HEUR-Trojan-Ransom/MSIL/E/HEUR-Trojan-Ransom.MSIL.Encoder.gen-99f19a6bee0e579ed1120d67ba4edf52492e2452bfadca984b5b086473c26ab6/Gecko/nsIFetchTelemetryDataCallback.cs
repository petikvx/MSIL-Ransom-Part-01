using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("3d3b9075-5549-4244-9c08-b64fefa1dd60")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIFetchTelemetryDataCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Complete();
}
