using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("B31702D0-6DAC-4FA0-B93B-F043E71C8F9A")]
public interface nsIDOMGeoPositionCoords
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	double GetLatitudeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	double GetLongitudeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	double GetAltitudeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	double GetAccuracyAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	double GetAltitudeAccuracyAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	double GetHeadingAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	double GetSpeedAttribute();
}
