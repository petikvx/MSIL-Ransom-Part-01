using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using NAudio.CoreAudioApi.Interfaces;

namespace NAudio.CoreAudioApi;

public sealed class AudioClockClient : IDisposable
{
	private IAudioClock audioClockClientInterface;

	public int Characteristics
	{
		get
		{
			Marshal.ThrowExceptionForHR(audioClockClientInterface.GetCharacteristics(out var characteristics));
			return (int)characteristics;
		}
	}

	public ulong Frequency
	{
		get
		{
			Marshal.ThrowExceptionForHR(audioClockClientInterface.GetFrequency(out var frequency));
			return frequency;
		}
	}

	public ulong AdjustedPosition
	{
		get
		{
			ulong num = 10000000uL / Frequency;
			int num2 = 0;
			ulong position;
			ulong qpcPosition;
			while (!GetPosition(out position, out qpcPosition) && ++num2 != 5)
			{
			}
			if (Stopwatch.IsHighResolution)
			{
				ulong num3 = ((ulong)((decimal)Stopwatch.GetTimestamp() * 10000000m / (decimal)Stopwatch.Frequency) - qpcPosition) / 100uL / num;
				return position + num3;
			}
			return position;
		}
	}

	public bool CanAdjustPosition => Stopwatch.IsHighResolution;

	internal AudioClockClient(IAudioClock audioClockClientInterface)
	{
		this.audioClockClientInterface = audioClockClientInterface;
	}

	public bool GetPosition(out ulong position, out ulong qpcPosition)
	{
		int position2 = audioClockClientInterface.GetPosition(out position, out qpcPosition);
		if (position2 == -1)
		{
			return false;
		}
		Marshal.ThrowExceptionForHR(position2);
		return true;
	}

	public void Dispose()
	{
		if (audioClockClientInterface != null)
		{
			Marshal.ReleaseComObject(audioClockClientInterface);
			audioClockClientInterface = null;
			GC.SuppressFinalize(this);
		}
	}
}
