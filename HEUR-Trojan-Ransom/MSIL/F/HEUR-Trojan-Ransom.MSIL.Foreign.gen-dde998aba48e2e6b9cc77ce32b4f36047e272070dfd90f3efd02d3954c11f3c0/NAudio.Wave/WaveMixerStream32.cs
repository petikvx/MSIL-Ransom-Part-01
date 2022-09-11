using System;
using System.Collections.Generic;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

public sealed class WaveMixerStream32 : WaveStream
{
	private readonly List<WaveStream> inputStreams;

	private readonly object inputsLock;

	private WaveFormat waveFormat;

	private long length;

	private long position;

	private readonly int bytesPerSample;

	[NonSerialized]
	internal static GetString _0094;

	public int InputCount => inputStreams.Count;

	public bool AutoStop { get; set; }

	public override int BlockAlign => waveFormat.BlockAlign;

	public override long Length => length;

	public override long Position
	{
		get
		{
			return position;
		}
		set
		{
			lock (inputsLock)
			{
				value = Math.Min(value, Length);
				foreach (WaveStream inputStream in inputStreams)
				{
					inputStream.Position = Math.Min(value, inputStream.Length);
				}
				position = value;
			}
		}
	}

	public override WaveFormat WaveFormat => waveFormat;

	public WaveMixerStream32()
	{
		AutoStop = true;
		waveFormat = WaveFormat.CreateIeeeFloatWaveFormat(44100, 2);
		bytesPerSample = 4;
		inputStreams = new List<WaveStream>();
		inputsLock = new object();
	}

	public WaveMixerStream32(IEnumerable<WaveStream> inputStreams, bool autoStop)
		: this()
	{
		AutoStop = autoStop;
		foreach (WaveStream inputStream in inputStreams)
		{
			AddInputStream(inputStream);
		}
	}

	public void AddInputStream(WaveStream waveStream)
	{
		if (waveStream.WaveFormat.Encoding != WaveFormatEncoding.IeeeFloat)
		{
			throw new ArgumentException(_0094(107387652), _0094(107384305));
		}
		if (waveStream.WaveFormat.BitsPerSample != 32)
		{
			throw new ArgumentException(_0094(107387614), _0094(107384305));
		}
		if (inputStreams.Count == 0)
		{
			int sampleRate = waveStream.WaveFormat.SampleRate;
			int channels = waveStream.WaveFormat.Channels;
			waveFormat = WaveFormat.CreateIeeeFloatWaveFormat(sampleRate, channels);
		}
		else if (!waveStream.WaveFormat.Equals(waveFormat))
		{
			throw new ArgumentException(_0094(107387529), _0094(107384305));
		}
		lock (inputsLock)
		{
			inputStreams.Add(waveStream);
			length = Math.Max(length, waveStream.Length);
			waveStream.Position = Position;
		}
	}

	public void RemoveInputStream(WaveStream waveStream)
	{
		lock (inputsLock)
		{
			if (!inputStreams.Remove(waveStream))
			{
				return;
			}
			long val = 0L;
			foreach (WaveStream inputStream in inputStreams)
			{
				val = Math.Max(val, inputStream.Length);
			}
			length = val;
		}
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		if (AutoStop && position + count > length)
		{
			count = (int)(length - position);
		}
		if (count % bytesPerSample != 0)
		{
			throw new ArgumentException(_0094(107387464), _0094(107387890));
		}
		Array.Clear(buffer, offset, count);
		int val = 0;
		byte[] array = new byte[count];
		lock (inputsLock)
		{
			foreach (WaveStream inputStream in inputStreams)
			{
				if (inputStream.HasData(count))
				{
					int num = inputStream.Read(array, 0, count);
					val = Math.Max(val, num);
					if (num > 0)
					{
						Sum32BitAudio(buffer, offset, array, num);
					}
				}
				else
				{
					val = Math.Max(val, count);
					inputStream.Position += count;
				}
			}
		}
		position += count;
		return count;
	}

	private unsafe static void Sum32BitAudio(byte[] destBuffer, int offset, byte[] sourceBuffer, int bytesRead)
	{
		fixed (byte* ptr = &destBuffer[offset])
		{
			fixed (byte* ptr3 = &sourceBuffer[0])
			{
				float* ptr2 = (float*)ptr;
				float* ptr4 = (float*)ptr3;
				int num = bytesRead / 4;
				for (int i = 0; i < num; i++)
				{
					ptr2[i] += ptr4[i];
				}
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			lock (inputsLock)
			{
				foreach (WaveStream inputStream in inputStreams)
				{
					inputStream.Dispose();
				}
			}
		}
		base.Dispose(disposing);
	}

	static WaveMixerStream32()
	{
		Strings.CreateGetStringDelegate(typeof(WaveMixerStream32));
	}
}
