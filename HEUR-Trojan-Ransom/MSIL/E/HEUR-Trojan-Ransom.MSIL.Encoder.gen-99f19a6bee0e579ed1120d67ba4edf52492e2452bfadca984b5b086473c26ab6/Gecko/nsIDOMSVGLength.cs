using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("2596325c-aed0-487e-96a1-0a6d589b9c6b")]
public interface nsIDOMSVGLength
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	ushort GetUnitTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	float GetValueAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetValueAttribute(float aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	float GetValueInSpecifiedUnitsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetValueInSpecifiedUnitsAttribute(float aValueInSpecifiedUnits);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetValueAsStringAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aValueAsString);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetValueAsStringAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aValueAsString);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void NewValueSpecifiedUnits(ushort unitType, float valueInSpecifiedUnits);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ConvertToSpecifiedUnits(ushort unitType);
}
