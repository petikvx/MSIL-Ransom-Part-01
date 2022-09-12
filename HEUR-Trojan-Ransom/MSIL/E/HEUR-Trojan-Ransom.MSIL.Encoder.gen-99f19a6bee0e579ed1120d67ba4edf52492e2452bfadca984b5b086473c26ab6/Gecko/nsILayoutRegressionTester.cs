using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("B249B2C0-EE11-11DA-8AD9-0800200C9A66")]
public interface nsILayoutRegressionTester
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	int DumpFrameModel([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindowToDump, [MarshalAs(UnmanagedType.Interface)] nsIFile aFile, uint aFlagsMask);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool CompareFrameModels([MarshalAs(UnmanagedType.Interface)] nsIFile aBaseFile, [MarshalAs(UnmanagedType.Interface)] nsIFile aVerFile, uint aFlags);
}
