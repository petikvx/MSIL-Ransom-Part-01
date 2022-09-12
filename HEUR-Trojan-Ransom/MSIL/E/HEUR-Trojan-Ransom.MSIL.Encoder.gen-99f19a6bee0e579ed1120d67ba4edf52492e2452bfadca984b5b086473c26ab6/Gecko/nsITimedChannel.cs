using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("ca63784d-959c-4c3a-9a59-234a2a520de0")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsITimedChannel
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetTimingEnabledAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTimingEnabledAttribute([MarshalAs(UnmanagedType.U1)] bool aTimingEnabled);

	[MethodImpl(MethodImplOptions.InternalCall)]
	ushort GetRedirectCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetRedirectCountAttribute(ushort aRedirectCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	ulong GetChannelCreationAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	ulong GetAsyncOpenAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	ulong GetDomainLookupStartAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	ulong GetDomainLookupEndAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	ulong GetConnectStartAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	ulong GetConnectEndAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	ulong GetRequestStartAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	ulong GetResponseStartAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	ulong GetResponseEndAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	ulong GetRedirectStartAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetRedirectStartAttribute(ulong aRedirectStart);

	[MethodImpl(MethodImplOptions.InternalCall)]
	ulong GetRedirectEndAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetRedirectEndAttribute(ulong aRedirectEnd);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetInitiatorTypeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aInitiatorType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetInitiatorTypeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aInitiatorType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetAllRedirectsSameOriginAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAllRedirectsSameOriginAttribute([MarshalAs(UnmanagedType.U1)] bool aAllRedirectsSameOrigin);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetAllRedirectsPassTimingAllowCheckAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAllRedirectsPassTimingAllowCheckAttribute([MarshalAs(UnmanagedType.U1)] bool aAllRedirectsPassTimingAllowCheck);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool TimingAllowCheck([MarshalAs(UnmanagedType.Interface)] nsIPrincipal origin);

	[MethodImpl(MethodImplOptions.InternalCall)]
	ulong GetCacheReadStartAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	ulong GetCacheReadEndAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetChannelCreationTimeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetAsyncOpenTimeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetDomainLookupStartTimeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetDomainLookupEndTimeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetConnectStartTimeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetConnectEndTimeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetRequestStartTimeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetResponseStartTimeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetResponseEndTimeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetCacheReadStartTimeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetCacheReadEndTimeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetRedirectStartTimeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetRedirectEndTimeAttribute();
}
