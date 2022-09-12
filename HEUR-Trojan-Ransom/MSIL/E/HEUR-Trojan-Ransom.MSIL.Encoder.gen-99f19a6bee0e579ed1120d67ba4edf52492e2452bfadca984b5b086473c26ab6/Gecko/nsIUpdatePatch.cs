using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("dc8fb8a9-3a53-4031-9469-2a5197ea30e7")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIUpdatePatch
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTypeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTypeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetURLAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aURL);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetURLAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aURL);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetFinalURLAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aFinalURL);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetFinalURLAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aFinalURL);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetHashFunctionAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aHashFunction);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetHashFunctionAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aHashFunction);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetHashValueAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aHashValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetHashValueAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aHashValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetSizeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSizeAttribute(uint aSize);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetStateAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aState);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetStateAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aState);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetSelectedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSelectedAttribute([MarshalAs(UnmanagedType.U1)] bool aSelected);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMElement Serialize([MarshalAs(UnmanagedType.Interface)] nsIDOMDocument updates);
}
