using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("e701dfd8-1dd1-11b2-a172-ffa6cc6156ad")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIX509CertValidity
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetNotBeforeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetNotBeforeLocalTimeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aNotBeforeLocalTime);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetNotBeforeLocalDayAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aNotBeforeLocalDay);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetNotBeforeGMTAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aNotBeforeGMT);

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetNotAfterAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetNotAfterLocalTimeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aNotAfterLocalTime);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetNotAfterLocalDayAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aNotAfterLocalDay);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetNotAfterGMTAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aNotAfterGMT);
}
