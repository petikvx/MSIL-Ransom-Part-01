using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("979d6e44-5930-4232-b405-873939655c19")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDOMHTMLMenuItemElement
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTypeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTypeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetLabelAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aLabel);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetLabelAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aLabel);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetIconAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aIcon);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetIconAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aIcon);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetDisabledAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDisabledAttribute([MarshalAs(UnmanagedType.U1)] bool aDisabled);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetDefaultCheckedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDefaultCheckedAttribute([MarshalAs(UnmanagedType.U1)] bool aDefaultChecked);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetCheckedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCheckedAttribute([MarshalAs(UnmanagedType.U1)] bool aChecked);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetRadiogroupAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aRadiogroup);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetRadiogroupAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aRadiogroup);
}
