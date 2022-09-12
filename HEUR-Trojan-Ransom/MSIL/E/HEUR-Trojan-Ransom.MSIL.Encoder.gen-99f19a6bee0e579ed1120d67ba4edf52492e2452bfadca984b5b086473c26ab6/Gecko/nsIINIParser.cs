using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("7eb955f6-3e78-4d39-b72f-c1bf12a94bce")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIINIParser
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIUTF8StringEnumerator GetSections();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIUTF8StringEnumerator GetKeys([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aSection);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetString([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aSection, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aKey, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);
}
