using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("c041d76c-15ce-47ad-b61d-e8755a6db638")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDOMHTMLMediaElement
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMMediaError GetErrorAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSrcAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSrc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSrcAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSrc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetCurrentSrcAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCurrentSrc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	ushort GetNetworkStateAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPreloadAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPreload);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPreloadAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPreload);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMTimeRanges GetBufferedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Load();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CanPlayType([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	ushort GetReadyStateAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetSeekingAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	double GetCurrentTimeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCurrentTimeAttribute(double aCurrentTime);

	[MethodImpl(MethodImplOptions.InternalCall)]
	double GetDurationAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetPausedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	double GetDefaultPlaybackRateAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDefaultPlaybackRateAttribute(double aDefaultPlaybackRate);

	[MethodImpl(MethodImplOptions.InternalCall)]
	double GetPlaybackRateAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPlaybackRateAttribute(double aPlaybackRate);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetMozPreservesPitchAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetMozPreservesPitchAttribute([MarshalAs(UnmanagedType.U1)] bool aMozPreservesPitch);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMTimeRanges GetPlayedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMTimeRanges GetSeekableAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetEndedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetMozAutoplayEnabledAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetAutoplayAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAutoplayAttribute([MarshalAs(UnmanagedType.U1)] bool aAutoplay);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetLoopAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetLoopAttribute([MarshalAs(UnmanagedType.U1)] bool aLoop);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Play();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Pause();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetControlsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetControlsAttribute([MarshalAs(UnmanagedType.U1)] bool aControls);

	[MethodImpl(MethodImplOptions.InternalCall)]
	double GetVolumeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetVolumeAttribute(double aVolume);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetMutedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetMutedAttribute([MarshalAs(UnmanagedType.U1)] bool aMuted);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetDefaultMutedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDefaultMutedAttribute([MarshalAs(UnmanagedType.U1)] bool aDefaultMuted);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetMozAudioCapturedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal MozGetMetadata(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	double GetMozFragmentEndAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetMozAudioChannelTypeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aMozAudioChannelType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetMozAudioChannelTypeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aMozAudioChannelType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsVideo();
}
