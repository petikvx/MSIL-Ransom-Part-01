using System.Runtime.InteropServices;

namespace NAudio.CoreAudioApi.Interfaces;

[Guid("641DD20B-4D41-49CC-ABA3-174B9477BB08")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IAudioSessionNotification
{
	[PreserveSig]
	int OnSessionCreated(IAudioSessionControl newSession);
}
