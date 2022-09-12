using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("baf443d2-da5d-40c9-be3c-c65a69a25250")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDOMHTMLObjectElement
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMHTMLFormElement GetFormAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetCodeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCodeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAlignAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAlign);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAlignAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAlign);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetArchiveAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aArchive);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetArchiveAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aArchive);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetBorderAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aBorder);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetBorderAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aBorder);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetCodeBaseAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCodeBase);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCodeBaseAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCodeBase);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetCodeTypeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCodeType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCodeTypeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCodeType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetDataAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aData);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDataAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aData);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetDeclareAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDeclareAttribute([MarshalAs(UnmanagedType.U1)] bool aDeclare);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetHeightAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aHeight);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetHeightAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aHeight);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetHspaceAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetHspaceAttribute(int aHspace);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetStandbyAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aStandby);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetStandbyAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aStandby);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTypeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTypeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetUseMapAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aUseMap);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetUseMapAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aUseMap);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetVspaceAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetVspaceAttribute(int aVspace);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetWidthAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aWidth);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetWidthAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aWidth);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMDocument GetContentDocumentAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetWillValidateAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMValidityState GetValidityAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetValidationMessageAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aValidationMessage);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool CheckValidity();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCustomValidity([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase error);
}
