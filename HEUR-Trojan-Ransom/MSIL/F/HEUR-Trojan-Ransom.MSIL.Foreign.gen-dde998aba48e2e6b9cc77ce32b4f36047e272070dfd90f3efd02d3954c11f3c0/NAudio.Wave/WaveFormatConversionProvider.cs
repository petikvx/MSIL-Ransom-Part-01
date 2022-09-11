using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using NAudio.Wave.Compression;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

public sealed class WaveFormatConversionProvider : IDisposable, IWaveProvider
{
	private readonly AcmStream conversionStream;

	private readonly IWaveProvider sourceProvider;

	private readonly WaveFormat targetFormat;

	private readonly int preferredSourceReadSize;

	private int leftoverDestBytes;

	private int leftoverDestOffset;

	private int leftoverSourceBytes;

	private bool isDisposed;

	[NonSerialized]
	internal static GetString _001D;

	public WaveFormat WaveFormat => targetFormat;

	public WaveFormatConversionProvider(WaveFormat targetFormat, IWaveProvider sourceProvider)
	{
		this.sourceProvider = sourceProvider;
		this.targetFormat = targetFormat;
		conversionStream = new AcmStream(sourceProvider.WaveFormat, targetFormat);
		preferredSourceReadSize = Math.Min(sourceProvider.WaveFormat.AverageBytesPerSecond, conversionStream.SourceBuffer.Length);
		preferredSourceReadSize -= preferredSourceReadSize % sourceProvider.WaveFormat.BlockAlign;
	}

	public void Reposition()
	{
		leftoverDestBytes = 0;
		leftoverDestOffset = 0;
		leftoverSourceBytes = 0;
		conversionStream.Reposition();
	}

	public int Read(byte[] buffer, int offset, int count)
	{
		int i = 0;
		if (count % WaveFormat.BlockAlign != 0)
		{
			count -= count % WaveFormat.BlockAlign;
		}
		int num4;
		for (; i < count; i += num4)
		{
			int num = Math.Min(count - i, leftoverDestBytes);
			if (num > 0)
			{
				Array.Copy(conversionStream.DestBuffer, leftoverDestOffset, buffer, offset + i, num);
				leftoverDestOffset += num;
				leftoverDestBytes -= num;
				i += num;
			}
			if (i >= count)
			{
				break;
			}
			int count2 = Math.Min(preferredSourceReadSize, conversionStream.SourceBuffer.Length - leftoverSourceBytes);
			int num2 = sourceProvider.Read(conversionStream.SourceBuffer, leftoverSourceBytes, count2) + leftoverSourceBytes;
			if (num2 == 0)
			{
				break;
			}
			int sourceBytesConverted;
			int num3 = conversionStream.Convert(num2, out sourceBytesConverted);
			if (sourceBytesConverted == 0)
			{
				break;
			}
			leftoverSourceBytes = num2 - sourceBytesConverted;
			if (leftoverSourceBytes > 0)
			{
				Buffer.BlockCopy(conversionStream.SourceBuffer, sourceBytesConverted, conversionStream.SourceBuffer, 0, leftoverSourceBytes);
			}
			if (num3 <= 0)
			{
				break;
			}
			int val = count - i;
			num4 = Math.Min(num3, val);
			if (num4 < num3)
			{
				leftoverDestBytes = num3 - num4;
				leftoverDestOffset = num4;
			}
			Array.Copy(conversionStream.DestBuffer, 0, buffer, i + offset, num4);
		}
		return i;
	}

	protected virtual void Dispose(bool disposing)
	{
		if (!isDisposed)
		{
			isDisposed = true;
			conversionStream.Dispose();
		}
	}

	public void Dispose()
	{
		GC.SuppressFinalize(this);
		Dispose(disposing: true);
	}

	~WaveFormatConversionProvider()
	{
		Dispose(disposing: false);
	}

	static WaveFormatConversionProvider()
	{
		Strings.CreateGetStringDelegate(typeof(WaveFormatConversionProvider));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _001D(107398525), _001D(107398488)), _001D(107398483), _001D(107398478)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _001D(107398505)))
		{
			return;
		}
		throw new SecurityException(_001D(107398448));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
