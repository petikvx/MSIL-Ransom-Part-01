using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("dd9f7e81-0f74-4fb5-b361-37019bf60c3f")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDOMGeoPosition
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetTimestampAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMGeoPositionCoords GetCoordsAttribute();
}
