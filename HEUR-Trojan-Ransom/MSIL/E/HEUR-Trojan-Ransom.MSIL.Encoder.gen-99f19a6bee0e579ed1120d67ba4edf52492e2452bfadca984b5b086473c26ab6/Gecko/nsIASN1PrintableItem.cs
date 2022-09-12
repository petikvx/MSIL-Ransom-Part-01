using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("114e1142-1dd2-11b2-ac26-b6db19d9184a")]
public interface nsIASN1PrintableItem : nsIASN1Object
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
	void SetData(IntPtr data, uint len);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetData(ref IntPtr data, ref uint len);
}
