using System.Runtime.InteropServices;
using CoreAudioApi.Interfaces;

namespace CoreAudioApi;

public class SessionCollection
{
	private IAudioSessionEnumerator _AudioSessionEnumerator;

	public AudioSessionControl this[int index]
	{
		get
		{
			Marshal.ThrowExceptionForHR(_AudioSessionEnumerator.GetSession(index, out var Session));
			return new AudioSessionControl(Session);
		}
	}

	public int Count
	{
		get
		{
			Marshal.ThrowExceptionForHR(_AudioSessionEnumerator.GetCount(out var SessionCount));
			return SessionCount;
		}
	}

	internal SessionCollection(IAudioSessionEnumerator realEnumerator)
	{
		_AudioSessionEnumerator = realEnumerator;
	}
}
