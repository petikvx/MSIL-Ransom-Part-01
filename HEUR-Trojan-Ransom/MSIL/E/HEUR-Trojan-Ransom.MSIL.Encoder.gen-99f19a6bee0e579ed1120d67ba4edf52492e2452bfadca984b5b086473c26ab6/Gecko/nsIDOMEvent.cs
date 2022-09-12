using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("f58daacf-4d1a-4002-8fd7-06b614dfbcf6")]
public interface nsIDOMEvent
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTypeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMEventTarget GetTargetAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMEventTarget GetCurrentTargetAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	ushort GetEventPhaseAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetBubblesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetCancelableAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetTimeStampAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void StopPropagation();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void PreventDefault();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InitEvent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase eventTypeArg, [MarshalAs(UnmanagedType.U1)] bool canBubbleArg, [MarshalAs(UnmanagedType.U1)] bool cancelableArg);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetDefaultPreventedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void StopImmediatePropagation();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMEventTarget GetOriginalTargetAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMEventTarget GetExplicitOriginalTargetAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetPreventDefault();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsTrustedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DuplicatePrivateData();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTarget([MarshalAs(UnmanagedType.Interface)] nsIDOMEventTarget aTarget);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsDispatchStopped();

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetInternalNSEvent();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTrusted([MarshalAs(UnmanagedType.U1)] bool aTrusted);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Serialize(IntPtr aMsg, [MarshalAs(UnmanagedType.U1)] bool aSerializeInterfaceType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool Deserialize(IntPtr aMsg, ref IntPtr aIter);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetOwner(nsIDOMEventTarget aOwner);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr InternalDOMEvent();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void StopCrossProcessForwarding();
}
