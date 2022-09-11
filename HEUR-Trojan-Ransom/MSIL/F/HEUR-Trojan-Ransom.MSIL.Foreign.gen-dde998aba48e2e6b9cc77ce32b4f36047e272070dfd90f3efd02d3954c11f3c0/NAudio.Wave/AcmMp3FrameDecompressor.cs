using System;
using NAudio.Wave.Compression;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

public sealed class AcmMp3FrameDecompressor : IDisposable, IMp3FrameDecompressor
{
	private readonly AcmStream conversionStream;

	private readonly WaveFormat pcmFormat;

	private bool disposed;

	[NonSerialized]
	internal static GetString _0003;

	public WaveFormat OutputFormat => pcmFormat;

	public AcmMp3FrameDecompressor(WaveFormat sourceFormat)
	{
		pcmFormat = AcmStream.SuggestPcmFormat(sourceFormat);
		try
		{
			conversionStream = new AcmStream(sourceFormat, pcmFormat);
		}
		catch (Exception)
		{
			disposed = true;
			GC.SuppressFinalize(this);
			throw;
		}
	}

	public int DecompressFrame(Mp3Frame frame, byte[] dest, int destOffset)
	{
		if (frame == null)
		{
			throw new ArgumentNullException(_0003(107390767), _0003(107390758));
		}
		Array.Copy(frame.RawData, conversionStream.SourceBuffer, frame.FrameLength);
		int sourceBytesConverted = 0;
		int num = conversionStream.Convert(frame.FrameLength, out sourceBytesConverted);
		if (sourceBytesConverted != frame.FrameLength)
		{
			throw new InvalidOperationException(string.Format(_0003(107390689), sourceBytesConverted, frame.FrameLength));
		}
		Array.Copy(conversionStream.DestBuffer, 0, dest, destOffset, num);
		return num;
	}

	public void Reset()
	{
		conversionStream.Reposition();
	}

	public void Dispose()
	{
		if (!disposed)
		{
			disposed = true;
			if (conversionStream != null)
			{
				conversionStream.Dispose();
			}
			GC.SuppressFinalize(this);
		}
	}

	~AcmMp3FrameDecompressor()
	{
		Dispose();
	}

	static AcmMp3FrameDecompressor()
	{
		Strings.CreateGetStringDelegate(typeof(AcmMp3FrameDecompressor));
	}
}
