using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("dbebc4be-75c9-47ca-aee8-0a8b4ae14a87")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDOMMouseEvent : nsIDOMEvent, nsIDOMUIEvent
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
	new nsIDOMWindow GetViewAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new int GetDetailAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void InitUIEvent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase typeArg, [MarshalAs(UnmanagedType.U1)] bool canBubbleArg, [MarshalAs(UnmanagedType.U1)] bool cancelableArg, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow viewArg, int detailArg);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new int GetLayerXAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new int GetLayerYAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new int GetPageXAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new int GetPageYAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint GetWhichAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIDOMNode GetRangeParentAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new int GetRangeOffsetAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool GetCancelBubbleAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetCancelBubbleAttribute([MarshalAs(UnmanagedType.U1)] bool aCancelBubble);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool GetIsCharAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetScreenXAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetScreenYAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetMozMovementXAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetMozMovementYAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetClientXAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetClientYAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetCtrlKeyAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetShiftKeyAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetAltKeyAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetMetaKeyAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	short GetButtonAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	ushort GetButtonsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMEventTarget GetRelatedTargetAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InitMouseEvent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase typeArg, [MarshalAs(UnmanagedType.U1)] bool canBubbleArg, [MarshalAs(UnmanagedType.U1)] bool cancelableArg, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow viewArg, int detailArg, int screenXArg, int screenYArg, int clientXArg, int clientYArg, [MarshalAs(UnmanagedType.U1)] bool ctrlKeyArg, [MarshalAs(UnmanagedType.U1)] bool altKeyArg, [MarshalAs(UnmanagedType.U1)] bool shiftKeyArg, [MarshalAs(UnmanagedType.U1)] bool metaKeyArg, ushort buttonArg, [MarshalAs(UnmanagedType.Interface)] nsIDOMEventTarget relatedTargetArg);

	[MethodImpl(MethodImplOptions.InternalCall)]
	float GetMozPressureAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	ushort GetMozInputSourceAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InitNSMouseEvent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase typeArg, [MarshalAs(UnmanagedType.U1)] bool canBubbleArg, [MarshalAs(UnmanagedType.U1)] bool cancelableArg, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow viewArg, int detailArg, int screenXArg, int screenYArg, int clientXArg, int clientYArg, [MarshalAs(UnmanagedType.U1)] bool ctrlKeyArg, [MarshalAs(UnmanagedType.U1)] bool altKeyArg, [MarshalAs(UnmanagedType.U1)] bool shiftKeyArg, [MarshalAs(UnmanagedType.U1)] bool metaKeyArg, ushort buttonArg, [MarshalAs(UnmanagedType.Interface)] nsIDOMEventTarget relatedTargetArg, float pressure, ushort inputSourceArg);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetModifierState([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase keyArg);
}
