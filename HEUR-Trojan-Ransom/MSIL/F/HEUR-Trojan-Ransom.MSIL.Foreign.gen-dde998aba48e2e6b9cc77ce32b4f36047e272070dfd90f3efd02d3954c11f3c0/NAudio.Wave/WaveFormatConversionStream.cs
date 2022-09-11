using System;
using NAudio.Wave.Compression;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

public sealed class WaveFormatConversionStream : WaveStream
{
	private readonly WaveFormatConversionProvider conversionProvider;

	private readonly WaveFormat targetFormat;

	private readonly long length;

	private long position;

	private readonly WaveStream sourceStream;

	private bool isDisposed;

	[NonSerialized]
	internal static GetString _008A;

	public override long Position
	{
		get
		{
			return position;
		}
		set
		{
			value -= value % BlockAlign;
			long num = EstimateDestToSource(value);
			sourceStream.Position = num;
			position = EstimateSourceToDest(sourceStream.Position);
			conversionProvider.Reposition();
		}
	}

	public override long Length => length;

	public override WaveFormat WaveFormat => targetFormat;

	public WaveFormatConversionStream(WaveFormat targetFormat, WaveStream sourceStream)
	{
		this.sourceStream = sourceStream;
		this.targetFormat = targetFormat;
		conversionProvider = new WaveFormatConversionProvider(targetFormat, sourceStream);
		length = EstimateSourceToDest((int)sourceStream.Length);
		position = 0L;
	}

	public static WaveStream CreatePcmStream(WaveStream sourceStream)
	{
		if (sourceStream.WaveFormat.Encoding == WaveFormatEncoding.Pcm)
		{
			return sourceStream;
		}
		WaveFormat waveFormat = AcmStream.SuggestPcmFormat(sourceStream.WaveFormat);
		if (waveFormat.SampleRate < 8000)
		{
			if (sourceStream.WaveFormat.Encoding != WaveFormatEncoding.G723)
			{
				throw new InvalidOperationException(_008A(107384981));
			}
			waveFormat = new WaveFormat(8000, 16, 1);
		}
		return new WaveFormatConversionStream(waveFormat, sourceStream);
	}

	[Obsolete("can be unreliable, use of this method not encouraged")]
	public int SourceToDest(int source)
	{
		return (int)EstimateSourceToDest(source);
	}

	private long EstimateSourceToDest(long source)
	{
		long num = source * targetFormat.AverageBytesPerSecond / sourceStream.WaveFormat.AverageBytesPerSecond;
		return num - num % targetFormat.BlockAlign;
	}

	private long EstimateDestToSource(long dest)
	{
		long num = dest * sourceStream.WaveFormat.AverageBytesPerSecond / targetFormat.AverageBytesPerSecond;
		return (int)(num - num % sourceStream.WaveFormat.BlockAlign);
	}

	[Obsolete("can be unreliable, use of this method not encouraged")]
	public int DestToSource(int dest)
	{
		return (int)EstimateDestToSource(dest);
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		int num = conversionProvider.Read(buffer, offset, count);
		position += num;
		return num;
	}

	protected override void Dispose(bool disposing)
	{
		if (!isDisposed)
		{
			isDisposed = true;
			if (disposing)
			{
				sourceStream.Dispose();
				conversionProvider.Dispose();
			}
		}
		base.Dispose(disposing);
	}

	static WaveFormatConversionStream()
	{
		Strings.CreateGetStringDelegate(typeof(WaveFormatConversionStream));
	}
}
