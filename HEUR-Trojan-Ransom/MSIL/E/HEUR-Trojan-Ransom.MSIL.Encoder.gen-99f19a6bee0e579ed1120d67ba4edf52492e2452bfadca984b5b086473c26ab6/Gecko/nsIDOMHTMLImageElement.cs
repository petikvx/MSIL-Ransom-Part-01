using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("ec18e71c-4f5c-4cc3-aa36-5273168644dc")]
public interface nsIDOMHTMLImageElement
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAltAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAlt);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAltAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAlt);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSrcAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSrc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSrcAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSrc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSrcsetAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSrcset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSrcsetAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSrcset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSizesAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSizes);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSizesAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSizes);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetUseMapAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aUseMap);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetUseMapAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aUseMap);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsMapAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetIsMapAttribute([MarshalAs(UnmanagedType.U1)] bool aIsMap);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetWidthAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetWidthAttribute(uint aWidth);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetHeightAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetHeightAttribute(uint aHeight);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetNaturalWidthAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetNaturalHeightAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetCompleteAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAlignAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAlign);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAlignAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAlign);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetBorderAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aBorder);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetBorderAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aBorder);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetHspaceAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetHspaceAttribute(int aHspace);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetLongDescAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aLongDesc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetLongDescAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aLongDesc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetVspaceAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetVspaceAttribute(int aVspace);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetLowsrcAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aLowsrc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetLowsrcAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aLowsrc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetCurrentSrcAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCurrentSrc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetXAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetYAttribute();
}
