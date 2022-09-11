using System;
using System.IO;
using System.Text;
using NAudio.Utils;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

public sealed class AiffFileWriter : Stream
{
	private Stream outStream;

	private BinaryWriter writer;

	private long dataSizePos;

	private long commSampleCountPos;

	private int dataChunkSize = 8;

	private WaveFormat format;

	private string filename;

	private byte[] value24 = new byte[3];

	[NonSerialized]
	internal static GetString _0084;

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
			throw new InvalidOperationException(_0084(107390074));
		}
	}

	public static void CreateAiffFile(string filename, WaveStream sourceProvider)
	{
		using AiffFileWriter aiffFileWriter = new AiffFileWriter(filename, sourceProvider.WaveFormat);
		byte[] array = new byte[16384];
		while (sourceProvider.Position < sourceProvider.Length)
		{
			int count = Math.Min((int)(sourceProvider.Length - sourceProvider.Position), array.Length);
			int num = sourceProvider.Read(array, 0, count);
			if (num == 0)
			{
				break;
			}
			aiffFileWriter.Write(array, 0, num);
		}
	}

	public AiffFileWriter(Stream outStream, WaveFormat format)
	{
		this.outStream = outStream;
		this.format = format;
		writer = new BinaryWriter(outStream, Encoding.UTF8);
		writer.Write(Encoding.UTF8.GetBytes(_0084(107390220)));
		writer.Write(0);
		writer.Write(Encoding.UTF8.GetBytes(_0084(107390243)));
		CreateCommChunk();
		WriteSsndChunkHeader();
	}

	public AiffFileWriter(string filename, WaveFormat format)
		: this(new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.Read), format)
	{
		this.filename = filename;
	}

	private void WriteSsndChunkHeader()
	{
		writer.Write(Encoding.UTF8.GetBytes(_0084(107390234)));
		dataSizePos = outStream.Position;
		writer.Write(0);
		writer.Write(0);
		writer.Write(SwapEndian(format.BlockAlign));
	}

	private byte[] SwapEndian(short n)
	{
		return new byte[2]
		{
			(byte)(n >> 8),
			(byte)((uint)n & 0xFFu)
		};
	}

	private byte[] SwapEndian(int n)
	{
		return new byte[4]
		{
			(byte)((uint)(n >> 24) & 0xFFu),
			(byte)((uint)(n >> 16) & 0xFFu),
			(byte)((uint)(n >> 8) & 0xFFu),
			(byte)((uint)n & 0xFFu)
		};
	}

	private void CreateCommChunk()
	{
		writer.Write(Encoding.UTF8.GetBytes(_0084(107391243)));
		writer.Write(SwapEndian(18));
		writer.Write(SwapEndian((short)format.Channels));
		commSampleCountPos = outStream.Position;
		writer.Write(0);
		writer.Write(SwapEndian((short)format.BitsPerSample));
		writer.Write(IEEE.ConvertToIeeeExtended(format.SampleRate));
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		throw new InvalidOperationException(_0084(107390193));
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		throw new InvalidOperationException(_0084(107390176));
	}

	public override void SetLength(long value)
	{
		throw new InvalidOperationException(_0084(107390095));
	}

	public override void Write(byte[] data, int offset, int count)
	{
		byte[] array = new byte[data.Length];
		int num = format.BitsPerSample / 8;
		for (int i = 0; i < data.Length; i++)
		{
			int num2 = (int)Math.Floor((double)i / (double)num) * num + (num - i % num - 1);
			array[i] = data[num2];
		}
		outStream.Write(array, offset, count);
		dataChunkSize += count;
	}

	public void WriteSample(float sample)
	{
		if (WaveFormat.BitsPerSample == 16)
		{
			writer.Write(SwapEndian((short)(32767f * sample)));
			dataChunkSize += 2;
		}
		else if (WaveFormat.BitsPerSample == 24)
		{
			byte[] bytes = BitConverter.GetBytes((int)(2.1474836E+09f * sample));
			value24[2] = bytes[1];
			value24[1] = bytes[2];
			value24[0] = bytes[3];
			writer.Write(value24);
			dataChunkSize += 3;
		}
		else
		{
			if (WaveFormat.BitsPerSample != 32 || WaveFormat.Encoding != WaveFormatEncoding.Extensible)
			{
				throw new InvalidOperationException(_0084(107389497));
			}
			writer.Write(SwapEndian(65535 * (int)sample));
			dataChunkSize += 4;
		}
	}

	public void WriteSamples(float[] samples, int offset, int count)
	{
		for (int i = 0; i < count; i++)
		{
			WriteSample(samples[offset + i]);
		}
	}

	public void WriteSamples(short[] samples, int offset, int count)
	{
		if (WaveFormat.BitsPerSample == 16)
		{
			for (int i = 0; i < count; i++)
			{
				writer.Write(SwapEndian(samples[i + offset]));
			}
			dataChunkSize += count * 2;
		}
		else if (WaveFormat.BitsPerSample == 24)
		{
			for (int j = 0; j < count; j++)
			{
				byte[] bytes = BitConverter.GetBytes(65535 * samples[j + offset]);
				value24[2] = bytes[1];
				value24[1] = bytes[2];
				value24[0] = bytes[3];
				writer.Write(value24);
			}
			dataChunkSize += count * 3;
		}
		else
		{
			if (WaveFormat.BitsPerSample != 32 || WaveFormat.Encoding != WaveFormatEncoding.Extensible)
			{
				throw new InvalidOperationException(_0084(107389384));
			}
			for (int k = 0; k < count; k++)
			{
				writer.Write(SwapEndian(65535 * samples[k + offset]));
			}
			dataChunkSize += count * 4;
		}
	}

	public override void Flush()
	{
		writer.Flush();
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
		Flush();
		writer.Seek(4, SeekOrigin.Begin);
		writer.Write(SwapEndian((int)(outStream.Length - 8)));
		UpdateCommChunk(writer);
		UpdateSsndChunk(writer);
	}

	private void UpdateCommChunk(BinaryWriter writer)
	{
		writer.Seek((int)commSampleCountPos, SeekOrigin.Begin);
		writer.Write(SwapEndian(dataChunkSize * 8 / format.BitsPerSample / format.Channels));
	}

	private void UpdateSsndChunk(BinaryWriter writer)
	{
		writer.Seek((int)dataSizePos, SeekOrigin.Begin);
		writer.Write(SwapEndian(dataChunkSize));
	}

	~AiffFileWriter()
	{
		Dispose(disposing: false);
	}

	static AiffFileWriter()
	{
		Strings.CreateGetStringDelegate(typeof(AiffFileWriter));
	}
}
