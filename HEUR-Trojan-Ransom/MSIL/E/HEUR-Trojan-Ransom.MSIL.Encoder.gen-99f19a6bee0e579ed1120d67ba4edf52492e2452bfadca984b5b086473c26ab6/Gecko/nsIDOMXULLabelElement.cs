using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("8b67286b-bf86-4808-8a68-ecdbc7d9877b")]
public interface nsIDOMXULLabelElement : nsIDOMXULDescriptionElement
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool GetDisabledAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetDisabledAttribute([MarshalAs(UnmanagedType.U1)] bool aDisabled);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool GetCropAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetCropAttribute([MarshalAs(UnmanagedType.U1)] bool aCrop);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetValueAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetValueAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAccessKeyAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAccessKey);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAccessKeyAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAccessKey);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetControlAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aControl);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetControlAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aControl);
}
