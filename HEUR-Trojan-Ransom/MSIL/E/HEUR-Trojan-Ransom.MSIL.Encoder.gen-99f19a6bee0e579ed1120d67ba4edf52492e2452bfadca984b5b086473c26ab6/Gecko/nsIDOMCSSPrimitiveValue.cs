using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("f6df7293-2dc9-4cb9-9531-778caf4370e0")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDOMCSSPrimitiveValue : nsIDOMCSSValue
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetCssTextAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCssText);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetCssTextAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCssText);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new ushort GetCssValueTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	ushort GetPrimitiveTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetFloatValue(ushort unitType, float floatValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	float GetFloatValue(ushort unitType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetStringValue(ushort stringType, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase stringValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetStringValue([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMCounter GetCounterValue();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMRect GetRectValue();
}
