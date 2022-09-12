using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("ad9b2ad0-9d29-43f6-b1a2-a1fd24627e6b")]
public interface nsIDOMHTMLFormElement
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAcceptCharsetAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAcceptCharset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAcceptCharsetAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAcceptCharset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetActionAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAction);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetActionAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAction);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAutocompleteAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAutocomplete);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAutocompleteAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAutocomplete);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetEnctypeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aEnctype);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetEnctypeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aEnctype);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetEncodingAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aEncoding);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetEncodingAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aEncoding);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetMethodAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aMethod);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetMethodAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aMethod);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetNoValidateAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetNoValidateAttribute([MarshalAs(UnmanagedType.U1)] bool aNoValidate);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTargetAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTarget);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTargetAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTarget);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMHTMLCollection GetElementsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetLengthAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Submit();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Reset();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool CheckValidity();
}
