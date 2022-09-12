using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("ccae7ea5-1218-4b51-aecb-c2d8ecd46af9")]
public interface nsIINIParserFactory
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIINIParser CreateINIParser([MarshalAs(UnmanagedType.Interface)] nsIFile aINIFile);
}
