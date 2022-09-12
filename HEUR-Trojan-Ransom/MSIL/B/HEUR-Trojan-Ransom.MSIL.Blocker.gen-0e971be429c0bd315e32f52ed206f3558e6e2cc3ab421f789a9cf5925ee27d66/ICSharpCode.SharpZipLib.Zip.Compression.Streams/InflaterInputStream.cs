using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Zip.Compression.Streams;

public class InflaterInputStream : Stream
{
	protected Stream baseInputStream;

	protected long csize;

	protected Inflater inflater_0;

	protected InflaterInputBuffer inputBuffer;

	private bool eCrgOAEcrYoIgGnXLSKmndNqqRbE;

	private bool tTMSyxFlQfXCQfFhbrPnqimGRjzK;

	public virtual int ICSharpCode_002ESharpZipLib_002EZip_002ECompression_002EStreams_002EInflaterInputStream_002EAvailable
	{
		get
		{
			if (!inflater_0.IsFinished)
			{
				return 1;
			}
			return 0;
		}
	}

	public override bool CanRead => baseInputStream.CanRead;

	public override bool CanSeek => false;

	public override bool CanWrite => false;

	public bool IsStreamOwner
	{
		get
		{
			return tTMSyxFlQfXCQfFhbrPnqimGRjzK;
		}
		set
		{
			tTMSyxFlQfXCQfFhbrPnqimGRjzK = value;
		}
	}

	public override long Length => inputBuffer.RawLength;

	public override long Position
	{
		get
		{
			return baseInputStream.Position;
		}
		set
		{
			throw new NotSupportedException("InflaterInputStream Position not supported");
		}
	}

	public InflaterInputStream(Stream baseInputStream)
		: this(baseInputStream, new Inflater(), 4096)
	{
	}

	public InflaterInputStream(Stream baseInputStream, Inflater inflater_1)
		: this(baseInputStream, inflater_1, 4096)
	{
	}

	public InflaterInputStream(Stream baseInputStream, Inflater inflater, int bufferSize)
	{
		tTMSyxFlQfXCQfFhbrPnqimGRjzK = true;
		if (baseInputStream == null)
		{
			throw new ArgumentNullException("baseInputStream");
		}
		if (inflater != null)
		{
			if (bufferSize <= 0)
			{
				throw new ArgumentOutOfRangeException("bufferSize");
			}
			this.baseInputStream = baseInputStream;
			inflater_0 = inflater;
			inputBuffer = new InflaterInputBuffer(baseInputStream, bufferSize);
			return;
		}
		throw new ArgumentNullException("inflater");
	}

	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		throw new NotSupportedException("InflaterInputStream BeginWrite not supported");
	}

	public override void Close()
	{
		if (!eCrgOAEcrYoIgGnXLSKmndNqqRbE)
		{
			eCrgOAEcrYoIgGnXLSKmndNqqRbE = true;
			if (tTMSyxFlQfXCQfFhbrPnqimGRjzK)
			{
				baseInputStream.Close();
			}
		}
	}

	protected void Fill()
	{
		inputBuffer.Fill();
		inputBuffer.SetInflaterInput(inflater_0);
	}

	public override void Flush()
	{
		baseInputStream.Flush();
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		if (inflater_0.IsNeedingDictionary)
		{
			throw new SharpZipBaseException("Need a dictionary");
		}
		int num = count;
		while (true)
		{
			int num2 = inflater_0.Inflate(buffer, offset, num);
			offset += num2;
			num -= num2;
			if (num == 0 || inflater_0.IsFinished)
			{
				break;
			}
			if (inflater_0.IsNeedingInput)
			{
				Fill();
			}
			else if (num2 == 0)
			{
				throw new ZipException("Dont know what to do");
			}
		}
		return count - num;
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		throw new NotSupportedException("Seek not supported");
	}

	public override void SetLength(long value)
	{
		throw new NotSupportedException("InflaterInputStream SetLength not supported");
	}

	public long Skip(long count)
	{
		if (count <= 0L)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		if (!baseInputStream.CanSeek)
		{
			int num = 2048;
			if (count < 2048L)
			{
				num = (int)count;
			}
			byte[] buffer = new byte[num];
			int num2 = 1;
			long num3 = count;
			while (num3 > 0L && num2 > 0)
			{
				if (num3 < num)
				{
					num = (int)num3;
				}
				num2 = baseInputStream.Read(buffer, 0, num);
				num3 -= num2;
			}
			return count - num3;
		}
		baseInputStream.Seek(count, SeekOrigin.Current);
		return count;
	}

	protected void StopDecrypting()
	{
		inputBuffer.CryptoTransform = null;
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		throw new NotSupportedException("InflaterInputStream Write not supported");
	}

	public override void WriteByte(byte value)
	{
		throw new NotSupportedException("InflaterInputStream WriteByte not supported");
	}
}
