using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("4de68896-e8eb-41de-8237-a797b570ac4a")]
public interface nsIStyleSheetService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void LoadAndRegisterSheet([MarshalAs(UnmanagedType.Interface)] nsIURI sheetURI, uint type);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool SheetRegistered([MarshalAs(UnmanagedType.Interface)] nsIURI sheetURI, uint type);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMStyleSheet PreloadSheet([MarshalAs(UnmanagedType.Interface)] nsIURI sheetURI, uint type);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UnregisterSheet([MarshalAs(UnmanagedType.Interface)] nsIURI sheetURI, uint type);
}
