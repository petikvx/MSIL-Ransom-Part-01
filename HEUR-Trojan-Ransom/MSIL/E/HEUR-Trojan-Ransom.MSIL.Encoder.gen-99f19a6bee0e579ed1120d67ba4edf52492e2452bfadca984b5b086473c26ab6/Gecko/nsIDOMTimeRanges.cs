using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("c43448db-0bab-461d-b648-1ca14a967f7e")]
public interface nsIDOMTimeRanges
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetLengthAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	double Start(uint index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	double End(uint index);
}
