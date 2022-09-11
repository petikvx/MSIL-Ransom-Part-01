using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using NAudio.Utils;
using NAudio.Wave.SampleProviders;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

public class WaveFileWriter : Stream
{
	private Stream outStream;

	private readonly BinaryWriter writer;

	private long dataSizePos;

	private long factSampleCountPos;

	private long dataChunkSize;

	private readonly WaveFormat format;

	private readonly string filename;

	private readonly byte[] value24 = new byte[3];

	[NonSerialized]
	internal static GetString _009C;

	public string Filename => filename;

	public override long Length => dataChunkSize;

	public WaveFormat WaveFormat => format;

	public override bool CanRead => false;

	public override bool CanWrite => true;

	public override bool CanSeek => false;

	public override long Position
	{
		get
		{
			return dataChunkSize;
		}
		set
		{
			throw new InvalidOperationException(_009C(107388081));
		}
	}

	public static void CreateWaveFile16(string filename, ISampleProvider sourceProvider)
	{
		CreateWaveFile(filename, new SampleToWaveProvider16(sourceProvider));
	}

	public static void CreateWaveFile(string filename, IWaveProvider sourceProvider)
	{
		using WaveFileWriter waveFileWriter = new WaveFileWriter(filename, sourceProvider.WaveFormat);
		byte[] array = new byte[sourceProvider.WaveFormat.AverageBytesPerSecond * 4];
		while (true)
		{
			int num = sourceProvider.Read(array, 0, array.Length);
			if (num == 0)
			{
				break;
			}
			waveFileWriter.Write(array, 0, num);
		}
	}

	public static void WriteWavFileToStream(Stream outStream, IWaveProvider sourceProvider)
	{
		using WaveFileWriter waveFileWriter = new WaveFileWriter(new IgnoreDisposeStream(outStream), sourceProvider.WaveFormat);
		byte[] array = new byte[sourceProvider.WaveFormat.AverageBytesPerSecond * 4];
		while (true)
		{
			int num = sourceProvider.Read(array, 0, array.Length);
			if (num == 0)
			{
				break;
			}
			waveFileWriter.Write(array, 0, num);
		}
		outStream.Flush();
	}

	public WaveFileWriter(Stream outStream, WaveFormat format)
	{
		this.outStream = outStream;
		this.format = format;
		writer = new BinaryWriter(outStream, Encoding.UTF8);
		writer.Write(Encoding.UTF8.GetBytes(_009C(107394180)));
		writer.Write(0);
		writer.Write(Encoding.UTF8.GetBytes(_009C(107388264)));
		writer.Write(Encoding.UTF8.GetBytes(_009C(107388287)));
		format.Serialize(writer);
		CreateFactChunk();
		WriteDataChunkHeader();
	}

	public WaveFileWriter(string filename, WaveFormat format)
		: this(new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.Read), format)
	{
		this.filename = filename;
	}

	private void WriteDataChunkHeader()
	{
		writer.Write(Encoding.UTF8.GetBytes(_009C(107388246)));
		dataSizePos = outStream.Position;
		writer.Write(0);
	}

	private void CreateFactChunk()
	{
		if (HasFactChunk())
		{
			writer.Write(Encoding.UTF8.GetBytes(_009C(107388237)));
			writer.Write(4);
			factSampleCountPos = outStream.Position;
			writer.Write(0);
		}
	}

	private bool HasFactChunk()
	{
		if (format.Encoding != WaveFormatEncoding.Pcm)
		{
			return format.BitsPerSample != 0;
		}
		return false;
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		throw new InvalidOperationException(_009C(107388260));
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		throw new InvalidOperationException(_009C(107388183));
	}

	public override void SetLength(long value)
	{
		throw new InvalidOperationException(_009C(107388166));
	}

	[Obsolete("Use Write instead")]
	public void WriteData(byte[] data, int offset, int count)
	{
		Write(data, offset, count);
	}

	public override void Write(byte[] data, int offset, int count)
	{
		if (outStream.Length + count > uint.MaxValue)
		{
			throw new ArgumentException(_009C(107387504), _009C(107387479));
		}
		outStream.Write(data, offset, count);
		dataChunkSize += count;
	}

	public void WriteSample(float sample)
	{
		if (WaveFormat.BitsPerSample == 16)
		{
			writer.Write((short)(32767f * sample));
			dataChunkSize += 2L;
		}
		else if (WaveFormat.BitsPerSample == 24)
		{
			byte[] bytes = BitConverter.GetBytes((int)(2.1474836E+09f * sample));
			value24[0] = bytes[1];
			value24[1] = bytes[2];
			value24[2] = bytes[3];
			writer.Write(value24);
			dataChunkSize += 3L;
		}
		else if (WaveFormat.BitsPerSample == 32 && WaveFormat.Encoding == WaveFormatEncoding.Extensible)
		{
			writer.Write(65535 * (int)sample);
			dataChunkSize += 4L;
		}
		else
		{
			if (WaveFormat.Encoding != WaveFormatEncoding.IeeeFloat)
			{
				throw new InvalidOperationException(_009C(107389533));
			}
			writer.Write(sample);
			dataChunkSize += 4L;
		}
	}

	public void WriteSamples(float[] samples, int offset, int count)
	{
		for (int i = 0; i < count; i++)
		{
			WriteSample(samples[offset + i]);
		}
	}

	[Obsolete("Use WriteSamples instead")]
	public void WriteData(short[] samples, int offset, int count)
	{
		WriteSamples(samples, offset, count);
	}

	public void WriteSamples(short[] samples, int offset, int count)
	{
		if (WaveFormat.BitsPerSample == 16)
		{
			for (int i = 0; i < count; i++)
			{
				writer.Write(samples[i + offset]);
			}
			dataChunkSize += count * 2;
		}
		else if (WaveFormat.BitsPerSample == 24)
		{
			for (int j = 0; j < count; j++)
			{
				byte[] bytes = BitConverter.GetBytes(65535 * samples[j + offset]);
				value24[0] = bytes[1];
				value24[1] = bytes[2];
				value24[2] = bytes[3];
				writer.Write(value24);
			}
			dataChunkSize += count * 3;
		}
		else if (WaveFormat.BitsPerSample == 32 && WaveFormat.Encoding == WaveFormatEncoding.Extensible)
		{
			for (int k = 0; k < count; k++)
			{
				writer.Write(65535 * samples[k + offset]);
			}
			dataChunkSize += count * 4;
		}
		else
		{
			if (WaveFormat.BitsPerSample != 32 || WaveFormat.Encoding != WaveFormatEncoding.IeeeFloat)
			{
				throw new InvalidOperationException(_009C(107389533));
			}
			for (int l = 0; l < count; l++)
			{
				writer.Write((float)samples[l + offset] / 32768f);
			}
			dataChunkSize += count * 4;
		}
	}

	public override void Flush()
	{
		long position = writer.BaseStream.Position;
		UpdateHeader(writer);
		writer.BaseStream.Position = position;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && outStream != null)
		{
			try
			{
				UpdateHeader(writer);
			}
			finally
			{
				outStream.Close();
				outStream = null;
			}
		}
	}

	protected virtual void UpdateHeader(BinaryWriter writer)
	{
		writer.Flush();
		UpdateRiffChunk(writer);
		UpdateFactChunk(writer);
		UpdateDataChunk(writer);
	}

	private void UpdateDataChunk(BinaryWriter writer)
	{
		writer.Seek((int)dataSizePos, SeekOrigin.Begin);
		writer.Write((uint)dataChunkSize);
	}

	private void UpdateRiffChunk(BinaryWriter writer)
	{
		writer.Seek(4, SeekOrigin.Begin);
		writer.Write((uint)(outStream.Length - 8));
	}

	private void UpdateFactChunk(BinaryWriter writer)
	{
		if (HasFactChunk())
		{
			int num = format.BitsPerSample * format.Channels;
			if (num != 0)
			{
				writer.Seek((int)factSampleCountPos, SeekOrigin.Begin);
				writer.Write((int)(dataChunkSize * 8 / num));
			}
		}
	}

	~WaveFileWriter()
	{
		Dispose(disposing: false);
	}

	static WaveFileWriter()
	{
		Strings.CreateGetStringDelegate(typeof(WaveFileWriter));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _009C(107398137), _009C(107398100)), _009C(107398095), _009C(107398090)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _009C(107398117)))
		{
			return;
		}
		throw new SecurityException(_009C(107398060));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
