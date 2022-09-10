using System;
using System.Runtime.InteropServices;

namespace MsGac.Fusion.Native;

[ComImport]
[Guid("582dac66-e678-449f-aba6-6faaec8a9394")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface IInstallReferenceItem
{
	[PreserveSig]
	int GetReference(out IntPtr ppRefData, uint dwFlags, IntPtr pvReserved);
}
