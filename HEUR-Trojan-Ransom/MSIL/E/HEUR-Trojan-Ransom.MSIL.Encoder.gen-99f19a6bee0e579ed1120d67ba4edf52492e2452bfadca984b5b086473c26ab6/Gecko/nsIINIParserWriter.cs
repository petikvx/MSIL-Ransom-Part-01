using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("b67bb24b-31a3-4a6a-a5d9-0485c9af5a04")]
public interface nsIINIParserWriter
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetString([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aSection, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aKey, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WriteFile([MarshalAs(UnmanagedType.Interface)] nsIFile aINIFile, uint aFlags);
}
