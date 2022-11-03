using System.Runtime.InteropServices;

namespace AForge.Video.DirectShow.Internals;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("C6E13370-30AC-11d0-A18C-00A0C9118956")]
internal interface IAMCameraControl
{
	[PreserveSig]
	int GetRange([In] CameraControlProperty Property, out int pMin, out int pMax, out int pSteppingDelta, out int pDefault, out CameraControlFlags pCapsFlags);

	[PreserveSig]
	int Set([In] CameraControlProperty Property, [In] int lValue, [In] CameraControlFlags Flags);

	[PreserveSig]
	int Get([In] CameraControlProperty Property, out int lValue, out CameraControlFlags Flags);
}
