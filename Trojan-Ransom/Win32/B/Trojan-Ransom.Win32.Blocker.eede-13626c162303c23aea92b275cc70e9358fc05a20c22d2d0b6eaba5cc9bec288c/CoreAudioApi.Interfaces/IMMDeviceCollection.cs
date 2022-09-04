using System.Runtime.InteropServices;

namespace CoreAudioApi.Interfaces;

[Guid("0BD7A1BE-7A1A-44DB-8397-CC5392387B5E")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface IMMDeviceCollection
{
	[PreserveSig]
	int GetCount(out uint pcDevices);

	[PreserveSig]
	int Item(uint nDevice, out IMMDevice Device);
}
