using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("20d8eb40-c494-497f-b2a6-aaa32f807ebd")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsILoginMetaInfo
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetGuidAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aGuid);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetGuidAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aGuid);

	[MethodImpl(MethodImplOptions.InternalCall)]
	ulong GetTimeCreatedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTimeCreatedAttribute(ulong aTimeCreated);

	[MethodImpl(MethodImplOptions.InternalCall)]
	ulong GetTimeLastUsedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTimeLastUsedAttribute(ulong aTimeLastUsed);

	[MethodImpl(MethodImplOptions.InternalCall)]
	ulong GetTimePasswordChangedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTimePasswordChangedAttribute(ulong aTimePasswordChanged);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetTimesUsedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTimesUsedAttribute(uint aTimesUsed);
}
