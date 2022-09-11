namespace NAudio.CoreAudioApi.Interfaces;

public enum AudioSessionDisconnectReason
{
	DisconnectReasonDeviceRemoval,
	DisconnectReasonServerShutdown,
	DisconnectReasonFormatChanged,
	DisconnectReasonSessionLogoff,
	DisconnectReasonSessionDisconnected,
	DisconnectReasonExclusiveModeOverride
}
