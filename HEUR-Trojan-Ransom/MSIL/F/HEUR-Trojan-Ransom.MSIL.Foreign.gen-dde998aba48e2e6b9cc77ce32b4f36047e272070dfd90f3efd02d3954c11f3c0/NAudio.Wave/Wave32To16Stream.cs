using System;
using NAudio.Utils;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

public sealed class Wave32To16Stream : WaveStream
{
	private WaveStream sourceStream;

	private readonly WaveFormat waveFormat;

	private readonly long length;

	private long position;

	private bool clip;

	private float volume;

	private readonly object lockObject = new object();

	private byte[] sourceBuffer;

	[NonSerialized]
	internal static GetString _0098;

	public float Volume
	{
		get
		{
			return volume;
		}
		set
		{
			volume = value;
		}
	}

	public override int BlockAlign => sourceStream.BlockAlign / 2;

	public override long Length => length;

	public override long Position
	{
		get
		{
			return position;
		}
		set
		{
			lock (lockObject)
			{
				value -= value % BlockAlign;
				sourceStream.Position = value * 2;
				position = value;
			}
		}
	}

	public override WaveFormat WaveFormat => waveFormat;

	public bool Clip
	{
		get
		{
			return clip;
		}
		set
		{
			clip = value;
		}
	}

	public Wave32To16Stream(WaveStream sourceStream)
	{
		if (sourceStream.WaveFormat.Encoding != WaveFormatEncoding.IeeeFloat)
		{
			throw new ArgumentException(_0098(107384627));
		}
		if (sourceStream.WaveFormat.BitsPerSample != 32)
		{
			throw new ArgumentException(_0098(107384627));
		}
		waveFormat = new WaveFormat(sourceStream.WaveFormat.SampleRate, 16, sourceStream.WaveFormat.Channels);
		volume = 1f;
		this.sourceStream = sourceStream;
		length = sourceStream.Length / 2;
		position = sourceStream.Position / 2;
	}

	public override int Read(byte[] destBuffer, int offset, int numBytes)
	{
		lock (lockObject)
		{
			int num = numBytes * 2;
			sourceBuffer = BufferHelpers.Ensure(sourceBuffer, num);
			int num2 = sourceStream.Read(sourceBuffer, 0, num);
			Convert32To16(destBuffer, offset, sourceBuffer, num2);
			position += num2 / 2;
			return num2 / 2;
		}
	}

	private unsafe void Convert32To16(byte[] destBuffer, int offset, byte[] sourceBuffer, int bytesRead)
	{
		fixed (byte* ptr = &destBuffer[offset])
		{
			fixed (byte* ptr3 = &sourceBuffer[0])
			{
				short* ptr2 = (short*)ptr;
				float* ptr4 = (float*)ptr3;
				int num = bytesRead / 4;
				for (int i = 0; i < num; i++)
				{
					float num2 = ptr4[i] * volume;
					if (num2 > 1f)
					{
						ptr2[i] = short.MaxValue;
						clip = true;
					}
					else if (num2 < -1f)
					{
						ptr2[i] = short.MinValue;
						clip = true;
					}
					else
					{
						ptr2[i] = (short)(num2 * 32767f);
					}
				}
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && sourceStream != null)
		{
			sourceStream.Dispose();
			sourceStream = null;
		}
		base.Dispose(disposing);
	}

	static Wave32To16Stream()
	{
		Strings.CreateGetStringDelegate(typeof(Wave32To16Stream));
	}
}
