using System;
using NAudio.Utils;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

public sealed class BufferedWaveProvider : IWaveProvider
{
	private CircularBuffer circularBuffer;

	private readonly WaveFormat waveFormat;

	[NonSerialized]
	internal static GetString _001F;

	public bool ReadFully { get; set; }

	public int BufferLength { get; set; }

	public TimeSpan BufferDuration
	{
		get
		{
			return TimeSpan.FromSeconds((double)BufferLength / (double)WaveFormat.AverageBytesPerSecond);
		}
		set
		{
			BufferLength = (int)(value.TotalSeconds * (double)WaveFormat.AverageBytesPerSecond);
		}
	}

	public bool DiscardOnBufferOverflow { get; set; }

	public int BufferedBytes
	{
		get
		{
			if (circularBuffer != null)
			{
				return circularBuffer.Count;
			}
			return 0;
		}
	}

	public TimeSpan BufferedDuration => TimeSpan.FromSeconds((double)BufferedBytes / (double)WaveFormat.AverageBytesPerSecond);

	public WaveFormat WaveFormat => waveFormat;

	public BufferedWaveProvider(WaveFormat waveFormat)
	{
		this.waveFormat = waveFormat;
		BufferLength = waveFormat.AverageBytesPerSecond * 5;
		ReadFully = true;
	}

	public void AddSamples(byte[] buffer, int offset, int count)
	{
		if (circularBuffer == null)
		{
			circularBuffer = new CircularBuffer(BufferLength);
		}
		if (circularBuffer.Write(buffer, offset, count) < count && !DiscardOnBufferOverflow)
		{
			throw new InvalidOperationException(_001F(107387803));
		}
	}

	public int Read(byte[] buffer, int offset, int count)
	{
		int num = 0;
		if (circularBuffer != null)
		{
			num = circularBuffer.Read(buffer, offset, count);
		}
		if (ReadFully && num < count)
		{
			Array.Clear(buffer, offset + num, count - num);
			num = count;
		}
		return num;
	}

	public void ClearBuffer()
	{
		if (circularBuffer != null)
		{
			circularBuffer.Reset();
		}
	}

	static BufferedWaveProvider()
	{
		Strings.CreateGetStringDelegate(typeof(BufferedWaveProvider));
	}
}
