using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Tar;

public class TarOutputStream : Stream
{
	protected byte[] assemblyBuffer;

	private int ymykzhSYIQRPXlgwYfbIcOOoAghS;

	protected byte[] blockBuffer;

	protected TarBuffer buffer;

	private long vnxkjjaBAHDnWfAiuotrdamFKXeRb;

	protected long currSize;

	private bool eCrgOAEcrYoIgGnXLSKmndNqqRbE;

	protected Stream outputStream;

	public override bool CanRead => outputStream.CanRead;

	public override bool CanSeek => outputStream.CanSeek;

	public override bool CanWrite => outputStream.CanWrite;

	private bool uoGBbzGfMpSrLTXFnbvUCXWSehZkA => vnxkjjaBAHDnWfAiuotrdamFKXeRb < currSize;

	public override long Length => outputStream.Length;

	public override long Position
	{
		get
		{
			return outputStream.Position;
		}
		set
		{
			outputStream.Position = value;
		}
	}

	public int RecordSize => buffer.RecordSize;

	public TarOutputStream(Stream outputStream)
		: this(outputStream, 20)
	{
	}

	public TarOutputStream(Stream outputStream, int blockFactor)
	{
		if (outputStream == null)
		{
			throw new ArgumentNullException("outputStream");
		}
		this.outputStream = outputStream;
		buffer = TarBuffer.CreateOutputTarBuffer(outputStream, blockFactor);
		assemblyBuffer = new byte[512];
		blockBuffer = new byte[512];
	}

	public override void Close()
	{
		if (!eCrgOAEcrYoIgGnXLSKmndNqqRbE)
		{
			eCrgOAEcrYoIgGnXLSKmndNqqRbE = true;
			Finish();
			buffer.Close();
		}
	}

	public void CloseEntry()
	{
		if (ymykzhSYIQRPXlgwYfbIcOOoAghS > 0)
		{
			Array.Clear(assemblyBuffer, ymykzhSYIQRPXlgwYfbIcOOoAghS, assemblyBuffer.Length - ymykzhSYIQRPXlgwYfbIcOOoAghS);
			buffer.WriteBlock(assemblyBuffer);
			vnxkjjaBAHDnWfAiuotrdamFKXeRb += ymykzhSYIQRPXlgwYfbIcOOoAghS;
			ymykzhSYIQRPXlgwYfbIcOOoAghS = 0;
		}
		if (vnxkjjaBAHDnWfAiuotrdamFKXeRb < currSize)
		{
			throw new TarException($"Entry closed at '{vnxkjjaBAHDnWfAiuotrdamFKXeRb}' before the '{currSize}' bytes specified in the header were written");
		}
	}

	public void Finish()
	{
		if (uoGBbzGfMpSrLTXFnbvUCXWSehZkA)
		{
			CloseEntry();
		}
		kMIcgsgWAccaSUKOxhlfcILjNeOxA();
	}

	public override void Flush()
	{
		outputStream.Flush();
	}

	[Obsolete("Use RecordSize property instead")]
	public int GetRecordSize()
	{
		return buffer.RecordSize;
	}

	public void PutNextEntry(TarEntry entry)
	{
		if (entry == null)
		{
			throw new ArgumentNullException("entry");
		}
		if (entry.TarHeader.Name.Length >= 100)
		{
			TarHeader tarHeader = new TarHeader();
			tarHeader.TypeFlag = 76;
			tarHeader.Name += "././@LongLink";
			tarHeader.UserId = 0;
			tarHeader.GroupId = 0;
			tarHeader.GroupName = "";
			tarHeader.UserName = "";
			tarHeader.LinkName = "";
			tarHeader.Size = entry.TarHeader.Name.Length;
			tarHeader.WriteHeader(blockBuffer);
			buffer.WriteBlock(blockBuffer);
			int num = 0;
			while (num < entry.TarHeader.Name.Length)
			{
				Array.Clear(blockBuffer, 0, blockBuffer.Length);
				TarHeader.GetAsciiBytes(entry.TarHeader.Name, num, blockBuffer, 0, 512);
				num += 512;
				buffer.WriteBlock(blockBuffer);
			}
		}
		entry.WriteEntryHeader(blockBuffer);
		buffer.WriteBlock(blockBuffer);
		vnxkjjaBAHDnWfAiuotrdamFKXeRb = 0L;
		currSize = (entry.IsDirectory ? 0L : entry.Size);
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		return outputStream.Read(buffer, offset, count);
	}

	public override int ReadByte()
	{
		return outputStream.ReadByte();
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		return outputStream.Seek(offset, origin);
	}

	public override void SetLength(long value)
	{
		outputStream.SetLength(value);
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		if (buffer != null)
		{
			if (offset >= 0)
			{
				if (buffer.Length - offset >= count)
				{
					if (count < 0)
					{
						throw new ArgumentOutOfRangeException("count", "Cannot be negative");
					}
					if (vnxkjjaBAHDnWfAiuotrdamFKXeRb + count > currSize)
					{
						string message = $"request to write '{count}' bytes exceeds size in header of '{currSize}' bytes";
						throw new ArgumentOutOfRangeException("count", message);
					}
					if (ymykzhSYIQRPXlgwYfbIcOOoAghS > 0)
					{
						if (ymykzhSYIQRPXlgwYfbIcOOoAghS + count >= blockBuffer.Length)
						{
							int num = blockBuffer.Length - ymykzhSYIQRPXlgwYfbIcOOoAghS;
							Array.Copy(assemblyBuffer, 0, blockBuffer, 0, ymykzhSYIQRPXlgwYfbIcOOoAghS);
							Array.Copy(buffer, offset, blockBuffer, ymykzhSYIQRPXlgwYfbIcOOoAghS, num);
							this.buffer.WriteBlock(blockBuffer);
							vnxkjjaBAHDnWfAiuotrdamFKXeRb += blockBuffer.Length;
							offset += num;
							count -= num;
							ymykzhSYIQRPXlgwYfbIcOOoAghS = 0;
						}
						else
						{
							Array.Copy(buffer, offset, assemblyBuffer, ymykzhSYIQRPXlgwYfbIcOOoAghS, count);
							offset += count;
							ymykzhSYIQRPXlgwYfbIcOOoAghS += count;
							count -= count;
						}
					}
					while (count > 0)
					{
						if (count >= blockBuffer.Length)
						{
							this.buffer.WriteBlock(buffer, offset);
							int num2 = blockBuffer.Length;
							vnxkjjaBAHDnWfAiuotrdamFKXeRb += num2;
							count -= num2;
							offset += num2;
							continue;
						}
						Array.Copy(buffer, offset, assemblyBuffer, ymykzhSYIQRPXlgwYfbIcOOoAghS, count);
						ymykzhSYIQRPXlgwYfbIcOOoAghS += count;
						break;
					}
					return;
				}
				throw new ArgumentException("offset and count combination is invalid");
			}
			throw new ArgumentOutOfRangeException("offset", "Cannot be negative");
		}
		throw new ArgumentNullException("buffer");
	}

	public override void WriteByte(byte value)
	{
		Write(new byte[1] { value }, 0, 1);
	}

	private void kMIcgsgWAccaSUKOxhlfcILjNeOxA()
	{
		Array.Clear(blockBuffer, 0, blockBuffer.Length);
		buffer.WriteBlock(blockBuffer);
	}
}
