using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("1645af04-1bc7-4363-8f2c-eb9679220ab1")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIFrameLoader
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDocShell GetDocShellAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsITabParent GetTabParentAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsILoadContext GetLoadContextAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void LoadFrame();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void LoadURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SwitchProcessAndLoadURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aPackageId);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetIsPrerendered();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Destroy();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetDepthTooGreatAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UpdatePositionAndSize(IntPtr aIFrame);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ActivateRemoteFrame();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeactivateRemoteFrame();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SendCrossProcessMouseEvent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aType, float aX, float aY, int aButton, int aClickCount, int aModifiers, [MarshalAs(UnmanagedType.U1)] bool aIgnoreRootScrollFrame);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ActivateFrameEvent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aType, [MarshalAs(UnmanagedType.U1)] bool capture);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIMessageSender GetMessageManagerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SendCrossProcessKeyEvent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aType, int aKeyCode, int aCharCode, int aModifiers, [MarshalAs(UnmanagedType.U1)] bool aPreventDefault);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RequestNotifyAfterRemotePaint();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RequestNotifyLayerTreeReady();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RequestNotifyLayerTreeCleared();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetEventModeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetEventModeAttribute(uint aEventMode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetClipSubdocumentAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetClipSubdocumentAttribute([MarshalAs(UnmanagedType.U1)] bool aClipSubdocument);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetClampScrollPositionAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetClampScrollPositionAttribute([MarshalAs(UnmanagedType.U1)] bool aClampScrollPosition);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMElement GetOwnerElementAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	ulong GetChildIDAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetVisibleAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetVisibleAttribute([MarshalAs(UnmanagedType.U1)] bool aVisible);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetOwnerIsBrowserOrAppFrameAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetOwnerIsWidgetAttribute();
}
