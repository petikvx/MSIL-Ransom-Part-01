using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("2a3f789e-0667-464f-a8d7-6f58513443d9")]
public interface nsIDOMHTMLMetaElement
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetContentAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aContent);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetContentAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aContent);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetHttpEquivAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aHttpEquiv);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetHttpEquivAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aHttpEquiv);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSchemeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aScheme);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSchemeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aScheme);
}
