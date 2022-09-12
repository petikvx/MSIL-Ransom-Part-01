using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("8C39EF62-F7C9-11d4-98F5-001083010E9B")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsISearchableInputStream
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Search([MarshalAs(UnmanagedType.LPStr)] string forString, [MarshalAs(UnmanagedType.U1)] bool ignoreCase, [MarshalAs(UnmanagedType.U1)] ref bool found, ref uint offsetSearchedTo);
}
