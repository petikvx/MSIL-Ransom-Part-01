using System;
using System.Runtime.InteropServices;

namespace MsGac.Fusion.Native;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("21B8916C-F28E-11D2-A473-00C04F8EF448")]
internal interface IAssemblyEnum
{
	[PreserveSig]
	int GetNextAssembly(IntPtr pvReserved, out IAssemblyName ppName, uint dwFlags);

	[PreserveSig]
	int Reset();

	[PreserveSig]
	int Clone(out IAssemblyEnum ppEnum);
}
