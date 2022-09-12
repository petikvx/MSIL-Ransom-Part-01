using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("db058d10-1db9-4cf9-bb4c-483c304a137f")]
public interface nsIDOMUIEvent : nsIDOMEvent
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetTypeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIDOMEventTarget GetTargetAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIDOMEventTarget GetCurrentTargetAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new ushort GetEventPhaseAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool GetBubblesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool GetCancelableAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new long GetTimeStampAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void StopPropagation();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void PreventDefault();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void InitEvent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase eventTypeArg, [MarshalAs(UnmanagedType.U1)] bool canBubbleArg, [MarshalAs(UnmanagedType.U1)] bool cancelableArg);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool GetDefaultPreventedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void StopImmediatePropagation();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIDOMEventTarget GetOriginalTargetAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIDOMEventTarget GetExplicitOriginalTargetAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool GetPreventDefault();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool GetIsTrustedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void DuplicatePrivateData();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetTarget([MarshalAs(UnmanagedType.Interface)] nsIDOMEventTarget aTarget);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool IsDispatchStopped();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new IntPtr GetInternalNSEvent();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetTrusted([MarshalAs(UnmanagedType.U1)] bool aTrusted);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Serialize(IntPtr aMsg, [MarshalAs(UnmanagedType.U1)] bool aSerializeInterfaceType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool Deserialize(IntPtr aMsg, ref IntPtr aIter);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetOwner(nsIDOMEventTarget aOwner);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new IntPtr InternalDOMEvent();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void StopCrossProcessForwarding();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMWindow GetViewAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetDetailAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InitUIEvent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase typeArg, [MarshalAs(UnmanagedType.U1)] bool canBubbleArg, [MarshalAs(UnmanagedType.U1)] bool cancelableArg, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow viewArg, int detailArg);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetLayerXAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetLayerYAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetPageXAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetPageYAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetWhichAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMNode GetRangeParentAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetRangeOffsetAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetCancelBubbleAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCancelBubbleAttribute([MarshalAs(UnmanagedType.U1)] bool aCancelBubble);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsCharAttribute();
}
