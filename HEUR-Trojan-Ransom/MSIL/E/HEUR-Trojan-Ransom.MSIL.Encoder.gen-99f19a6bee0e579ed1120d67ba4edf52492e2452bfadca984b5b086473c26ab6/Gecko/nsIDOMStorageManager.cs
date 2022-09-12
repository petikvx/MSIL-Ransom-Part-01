using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("a15f7ebd-4f35-4e73-a2d8-255d27fd14ee")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDOMStorageManager
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void PrecacheStorage([MarshalAs(UnmanagedType.Interface)] nsIPrincipal aPrincipal);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMStorage CreateStorage([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal aPrincipal, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDocumentURI, [MarshalAs(UnmanagedType.U1)] bool aPrivate);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMStorage GetStorage([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal aPrincipal, [MarshalAs(UnmanagedType.U1)] bool aPrivate);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CloneStorage([MarshalAs(UnmanagedType.Interface)] nsIDOMStorage aStorageToCloneFrom);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool CheckStorage([MarshalAs(UnmanagedType.Interface)] nsIPrincipal aPrincipal, [MarshalAs(UnmanagedType.Interface)] nsIDOMStorage aStorage);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMStorage GetLocalStorageForPrincipal([MarshalAs(UnmanagedType.Interface)] nsIPrincipal aPrincipal, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDocumentURI, [MarshalAs(UnmanagedType.U1)] bool aPrivate);
}
