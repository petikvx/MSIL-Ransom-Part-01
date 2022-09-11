using System;
using System.Globalization;
using System.Runtime.InteropServices;
using NAudio.CoreAudioApi.Interfaces;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.CoreAudioApi;

public sealed class AudioStreamVolume : IDisposable
{
	private IAudioStreamVolume audioStreamVolumeInterface;

	[NonSerialized]
	internal static GetString _008F;

	public int ChannelCount
	{
		get
		{
			Marshal.ThrowExceptionForHR(audioStreamVolumeInterface.GetChannelCount(out var dwCount));
			return (int)dwCount;
		}
	}

	internal AudioStreamVolume(IAudioStreamVolume audioStreamVolumeInterface)
	{
		this.audioStreamVolumeInterface = audioStreamVolumeInterface;
	}

	private void CheckChannelIndex(int channelIndex, string parameter)
	{
		int channelCount = ChannelCount;
		if (channelIndex >= channelCount)
		{
			throw new ArgumentOutOfRangeException(parameter, _008F(107404445) + channelCount);
		}
	}

	public float[] GetAllVolumes()
	{
		Marshal.ThrowExceptionForHR(audioStreamVolumeInterface.GetChannelCount(out var dwCount));
		float[] array = new float[dwCount];
		Marshal.ThrowExceptionForHR(audioStreamVolumeInterface.GetAllVolumes(dwCount, array));
		return array;
	}

	public float GetChannelVolume(int channelIndex)
	{
		CheckChannelIndex(channelIndex, _008F(107403840));
		Marshal.ThrowExceptionForHR(audioStreamVolumeInterface.GetChannelVolume((uint)channelIndex, out var fLevel));
		return fLevel;
	}

	public void SetAllVolumes(float[] levels)
	{
		int channelCount = ChannelCount;
		if (levels == null)
		{
			throw new ArgumentNullException(_008F(107403791));
		}
		if (levels.Length != channelCount)
		{
			throw new ArgumentOutOfRangeException(_008F(107403791), string.Format(CultureInfo.InvariantCulture, _008F(107403782), new object[2] { channelCount, levels.Length }));
		}
		for (int i = 0; i < levels.Length; i++)
		{
			float num = levels[i];
			if (num < 0f)
			{
				throw new ArgumentOutOfRangeException(_008F(107403791), _008F(107403636) + i);
			}
			if (num > 1f)
			{
				throw new ArgumentOutOfRangeException(_008F(107403791), _008F(107403636) + i);
			}
		}
		Marshal.ThrowExceptionForHR(audioStreamVolumeInterface.SetAllVoumes((uint)channelCount, levels));
	}

	public void SetChannelVolume(int index, float level)
	{
		CheckChannelIndex(index, _008F(107404059));
		if (level < 0f)
		{
			throw new ArgumentOutOfRangeException(_008F(107404050), _008F(107390639));
		}
		if (level > 1f)
		{
			throw new ArgumentOutOfRangeException(_008F(107404050), _008F(107390639));
		}
		Marshal.ThrowExceptionForHR(audioStreamVolumeInterface.SetChannelVolume((uint)index, level));
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposing && audioStreamVolumeInterface != null)
		{
			Marshal.ReleaseComObject(audioStreamVolumeInterface);
			audioStreamVolumeInterface = null;
		}
	}

	static AudioStreamVolume()
	{
		Strings.CreateGetStringDelegate(typeof(AudioStreamVolume));
	}
}
