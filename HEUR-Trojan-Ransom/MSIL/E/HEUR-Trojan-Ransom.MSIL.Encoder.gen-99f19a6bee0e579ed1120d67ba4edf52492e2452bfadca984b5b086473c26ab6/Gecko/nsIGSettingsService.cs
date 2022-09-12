using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("849c088b-57d1-4f24-b7b2-3dc4acb04c0a")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIGSettingsService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIGSettingsCollection GetCollectionForSchema([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase schema);
}
