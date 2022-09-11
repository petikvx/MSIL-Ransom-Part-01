using System.Runtime.InteropServices;
using NAudio.CoreAudioApi.Interfaces;

namespace NAudio.CoreAudioApi;

public sealed class SessionCollection
{
	private readonly IAudioSessionEnumerator audioSessionEnumerator;

	public AudioSessionControl this[int index]
	{
		get
		{
			Marshal.ThrowExceptionForHR(audioSessionEnumerator.GetSession(index, out var session));
			return new AudioSessionControl(session);
		}
	}

	public int Count
	{
		get
		{
			Marshal.ThrowExceptionForHR(audioSessionEnumerator.GetCount(out var sessionCount));
			return sessionCount;
		}
	}

	internal SessionCollection(IAudioSessionEnumerator realEnumerator)
	{
		audioSessionEnumerator = realEnumerator;
	}
}
