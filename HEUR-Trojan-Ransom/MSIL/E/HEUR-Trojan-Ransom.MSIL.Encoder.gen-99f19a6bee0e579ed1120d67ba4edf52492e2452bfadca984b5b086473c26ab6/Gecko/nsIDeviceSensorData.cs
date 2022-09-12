using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("1B406E32-CF42-471E-A470-6FD600BF4C7B")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDeviceSensorData
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	double GetXAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	double GetYAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	double GetZAttribute();
}
