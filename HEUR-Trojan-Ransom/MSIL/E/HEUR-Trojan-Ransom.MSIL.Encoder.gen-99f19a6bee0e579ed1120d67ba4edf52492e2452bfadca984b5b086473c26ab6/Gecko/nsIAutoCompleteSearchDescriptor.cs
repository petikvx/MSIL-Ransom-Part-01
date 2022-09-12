using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("4c3e7462-fbfb-4310-8f4b-239238392b75")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIAutoCompleteSearchDescriptor
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	ushort GetSearchTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetClearingAutoFillSearchesAgainAttribute();
}
