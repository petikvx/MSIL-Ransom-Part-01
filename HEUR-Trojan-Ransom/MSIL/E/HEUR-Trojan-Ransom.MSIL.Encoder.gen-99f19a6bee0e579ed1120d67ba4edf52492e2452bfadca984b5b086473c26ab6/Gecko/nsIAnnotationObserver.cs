using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("63fe98e0-6889-4c2c-ac9f-703e4bc25027")]
public interface nsIAnnotationObserver
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnPageAnnotationSet([MarshalAs(UnmanagedType.Interface)] nsIURI aPage, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnItemAnnotationSet(long aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnPageAnnotationRemoved([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnItemAnnotationRemoved(long aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);
}
