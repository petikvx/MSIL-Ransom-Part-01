using System.Runtime.InteropServices;
using CoreAudioApi.Interfaces;

namespace CoreAudioApi;

public class AudioSessionManager
{
	private IAudioSessionManager2 _AudioSessionManager;

	private SessionCollection _Sessions;

	public SessionCollection Sessions => _Sessions;

	internal AudioSessionManager(IAudioSessionManager2 realAudioSessionManager)
	{
		_AudioSessionManager = realAudioSessionManager;
		Marshal.ThrowExceptionForHR(_AudioSessionManager.GetSessionEnumerator(out var SessionEnum));
		_Sessions = new SessionCollection(SessionEnum);
	}
}
