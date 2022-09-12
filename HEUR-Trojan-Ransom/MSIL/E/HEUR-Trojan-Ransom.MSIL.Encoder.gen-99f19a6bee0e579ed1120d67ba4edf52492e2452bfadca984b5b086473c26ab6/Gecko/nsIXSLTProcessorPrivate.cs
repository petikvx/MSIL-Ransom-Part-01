using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("75d14f5d-293d-4872-8a26-e79268de592f")]
public interface nsIXSLTProcessorPrivate
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init([MarshalAs(UnmanagedType.Interface)] nsISupports global);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetFlagsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetFlagsAttribute(uint aFlags);
}
