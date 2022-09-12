using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("df31c280-1ef1-11e5-867f-0800200c9a66")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIAudioManager
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetMicrophoneMutedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetMicrophoneMutedAttribute([MarshalAs(UnmanagedType.U1)] bool aMicrophoneMuted);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetFmRadioAudioEnabledAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetFmRadioAudioEnabledAttribute([MarshalAs(UnmanagedType.U1)] bool aFmRadioAudioEnabled);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetPhoneStateAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPhoneStateAttribute(int aPhoneState);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetForceForUse(int usage, int force);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetForceForUse(int usage);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAudioChannelVolume(uint channel, uint index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetAudioChannelVolume(uint channel);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetMaxAudioChannelVolume(uint channel);
}
