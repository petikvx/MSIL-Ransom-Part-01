using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using NAudio.Wave.SampleProviders;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

public sealed class AudioFileReader : WaveStream, ISampleProvider
{
	private string fileName;

	private WaveStream readerStream;

	private readonly SampleChannel sampleChannel;

	private readonly int destBytesPerSample;

	private readonly int sourceBytesPerSample;

	private readonly long length;

	private readonly object lockObject;

	[NonSerialized]
	internal static GetString _0003;

	public override WaveFormat WaveFormat => sampleChannel.WaveFormat;

	public override long Length => length;

	public override long Position
	{
		get
		{
			return SourceToDest(readerStream.Position);
		}
		set
		{
			lock (lockObject)
			{
				readerStream.Position = DestToSource(value);
			}
		}
	}

	public float Volume
	{
		get
		{
			return sampleChannel.Volume;
		}
		set
		{
			sampleChannel.Volume = value;
		}
	}

	public AudioFileReader(string fileName)
	{
		lockObject = new object();
		this.fileName = fileName;
		CreateReaderStream(fileName);
		sourceBytesPerSample = readerStream.WaveFormat.BitsPerSample / 8 * readerStream.WaveFormat.Channels;
		sampleChannel = new SampleChannel(readerStream, forceStereo: false);
		destBytesPerSample = 4 * sampleChannel.WaveFormat.Channels;
		length = SourceToDest(readerStream.Length);
	}

	private void CreateReaderStream(string fileName)
	{
		if (fileName.EndsWith(_0003(107385577), StringComparison.OrdinalIgnoreCase))
		{
			readerStream = new WaveFileReader(fileName);
			if (readerStream.WaveFormat.Encoding != WaveFormatEncoding.Pcm && readerStream.WaveFormat.Encoding != WaveFormatEncoding.IeeeFloat)
			{
				readerStream = WaveFormatConversionStream.CreatePcmStream(readerStream);
				readerStream = new BlockAlignReductionStream(readerStream);
			}
		}
		else if (fileName.EndsWith(_0003(107385568), StringComparison.OrdinalIgnoreCase))
		{
			readerStream = new Mp3FileReader(fileName);
		}
		else if (fileName.EndsWith(_0003(107385527)))
		{
			readerStream = new AiffFileReader(fileName);
		}
		else
		{
			readerStream = new MediaFoundationReader(fileName);
		}
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		WaveBuffer waveBuffer = new WaveBuffer(buffer);
		int count2 = count / 4;
		return Read(waveBuffer.FloatBuffer, offset / 4, count2) * 4;
	}

	public int Read(float[] buffer, int offset, int count)
	{
		lock (lockObject)
		{
			return sampleChannel.Read(buffer, offset, count);
		}
	}

	private long SourceToDest(long sourceBytes)
	{
		return destBytesPerSample * (sourceBytes / sourceBytesPerSample);
	}

	private long DestToSource(long destBytes)
	{
		return sourceBytesPerSample * (destBytes / destBytesPerSample);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && readerStream != null)
		{
			readerStream.Dispose();
			readerStream = null;
		}
		base.Dispose(disposing);
	}

	static AudioFileReader()
	{
		Strings.CreateGetStringDelegate(typeof(AudioFileReader));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0003(107398400), _0003(107398363)), _0003(107398358), _0003(107398353)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0003(107398380)))
		{
			return;
		}
		throw new SecurityException(_0003(107398323));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
