using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("80DB54AE-13F2-11d5-BE44-00108335A220")]
public interface nsIAutoConfig
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.LPStr)]
	string GetConfigURLAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetConfigURLAttribute([MarshalAs(UnmanagedType.LPStr)] string aConfigURL);
}
