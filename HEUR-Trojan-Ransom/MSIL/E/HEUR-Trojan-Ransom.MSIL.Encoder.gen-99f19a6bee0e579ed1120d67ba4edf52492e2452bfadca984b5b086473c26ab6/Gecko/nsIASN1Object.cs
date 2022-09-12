using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("ba8bf582-1dd1-11b2-898c-f40246bc9a63")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIASN1Object
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTypeAttribute(uint aType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetTagAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTagAttribute(uint aTag);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetDisplayNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDisplayName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDisplayNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDisplayName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetDisplayValueAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDisplayValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDisplayValueAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDisplayValue);
}
