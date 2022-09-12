using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("745518ad-3163-41f0-b358-c81fb5a587bc")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDOMXULCheckboxElement : nsIDOMXULLabeledControlElement, nsIDOMXULControlElement
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool GetDisabledAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetDisabledAttribute([MarshalAs(UnmanagedType.U1)] bool aDisabled);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new int GetTabIndexAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetTabIndexAttribute(int aTabIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetCropAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCrop);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetCropAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCrop);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetImageAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aImage);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetImageAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aImage);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetLabelAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aLabel);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetLabelAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aLabel);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetAccessKeyAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAccessKey);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetAccessKeyAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAccessKey);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetCommandAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCommand);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetCommandAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCommand);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetCheckedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCheckedAttribute([MarshalAs(UnmanagedType.U1)] bool aChecked);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetCheckStateAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCheckStateAttribute(int aCheckState);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetAutoCheckAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAutoCheckAttribute([MarshalAs(UnmanagedType.U1)] bool aAutoCheck);
}
