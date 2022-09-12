using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("2f977d4b-5485-11d4-87e2-0010a4e75ef2")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDirectoryServiceProvider2 : nsIDirectoryServiceProvider
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIFile GetFile([MarshalAs(UnmanagedType.LPStr)] string prop, [MarshalAs(UnmanagedType.U1)] ref bool persistent);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISimpleEnumerator GetFiles([MarshalAs(UnmanagedType.LPStr)] string prop);
}
