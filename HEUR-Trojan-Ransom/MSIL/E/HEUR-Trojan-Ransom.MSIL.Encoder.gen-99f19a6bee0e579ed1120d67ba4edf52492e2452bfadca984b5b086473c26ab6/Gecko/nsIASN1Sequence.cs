using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("b6b957e6-1dd1-11b2-89d7-e30624f50b00")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIASN1Sequence : nsIASN1Object
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint GetTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetTypeAttribute(uint aType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint GetTagAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetTagAttribute(uint aTag);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetDisplayNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDisplayName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetDisplayNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDisplayName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetDisplayValueAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDisplayValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetDisplayValueAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDisplayValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIMutableArray GetASN1ObjectsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetASN1ObjectsAttribute([MarshalAs(UnmanagedType.Interface)] nsIMutableArray aASN1Objects);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsValidContainerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetIsValidContainerAttribute([MarshalAs(UnmanagedType.U1)] bool aIsValidContainer);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsExpandedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetIsExpandedAttribute([MarshalAs(UnmanagedType.U1)] bool aIsExpanded);
}
