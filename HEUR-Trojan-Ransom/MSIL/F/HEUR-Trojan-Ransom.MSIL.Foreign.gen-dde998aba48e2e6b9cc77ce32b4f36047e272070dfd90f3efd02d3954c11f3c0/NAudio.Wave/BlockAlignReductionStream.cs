using System;
using NAudio.Utils;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

public sealed class BlockAlignReductionStream : WaveStream
{
	private WaveStream sourceStream;

	private long position;

	private readonly CircularBuffer circularBuffer;

	private long bufferStartPosition;

	private byte[] sourceBuffer;

	private readonly object lockObject = new object();

	[NonSerialized]
	internal static GetString _0011;

	public override int BlockAlign => WaveFormat.BitsPerSample / 8 * WaveFormat.Channels;

	public override WaveFormat WaveFormat => sourceStream.WaveFormat;

	public override long Length => sourceStream.Length;

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
				if (position != value)
				{
					if (position % BlockAlign != 0L)
					{
						throw new ArgumentException(_0011(107385557));
					}
					long num = value - value % sourceStream.BlockAlign;
					if (sourceStream.Position != num)
					{
						sourceStream.Position = num;
						circularBuffer.Reset();
						bufferStartPosition = sourceStream.Position;
					}
					position = value;
				}
			}
		}
	}

	private long BufferEndPosition => bufferStartPosition + circularBuffer.Count;

	public BlockAlignReductionStream(WaveStream sourceStream)
	{
		this.sourceStream = sourceStream;
		circularBuffer = new CircularBuffer(sourceStream.WaveFormat.AverageBytesPerSecond * 4);
	}

	private byte[] GetSourceBuffer(int size)
	{
		if (sourceBuffer == null || sourceBuffer.Length < size)
		{
			sourceBuffer = new byte[size * 2];
		}
		return sourceBuffer;
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

	public override int Read(byte[] buffer, int offset, int count)
	{
		lock (lockObject)
		{
			while (BufferEndPosition < position + count)
			{
				int num = count;
				if (num % sourceStream.BlockAlign != 0)
				{
					num = count + sourceStream.BlockAlign - count % sourceStream.BlockAlign;
				}
				int num2 = sourceStream.Read(GetSourceBuffer(num), 0, num);
				circularBuffer.Write(GetSourceBuffer(num), 0, num2);
				if (num2 == 0)
				{
					break;
				}
			}
			if (bufferStartPosition < position)
			{
				circularBuffer.Advance((int)(position - bufferStartPosition));
				bufferStartPosition = position;
			}
			int num3 = circularBuffer.Read(buffer, offset, count);
			position += num3;
			bufferStartPosition = position;
			return num3;
		}
	}

	static BlockAlignReductionStream()
	{
		Strings.CreateGetStringDelegate(typeof(BlockAlignReductionStream));
	}
}
