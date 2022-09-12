using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("808585b6-7568-4b26-8c62-545221bf2b8c")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface fuelIBookmark
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetIdAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTitleAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTitle);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTitleAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTitle);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetUriAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetUriAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI aUri);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetDescriptionAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDescription);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDescriptionAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDescription);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetKeywordAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aKeyword);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetKeywordAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aKeyword);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTypeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	fuelIBookmarkFolder GetParentAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetParentAttribute(fuelIBookmarkFolder aParent);

	[MethodImpl(MethodImplOptions.InternalCall)]
	fuelIAnnotations GetAnnotationsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	extIEvents GetEventsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Remove();
}
