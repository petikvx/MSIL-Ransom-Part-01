namespace CoreAudioApi;

public enum AudioSessionDisconnectReason
{
	DisconnectReasonDeviceRemoval,
	DisconnectReasonServerShutdown,
	DisconnectReasonFormatChanged,
	DisconnectReasonSessionLogoff,
	DisconnectReasonSessionDisconnected,
	DisconnectReasonExclusiveModeOverride
}
