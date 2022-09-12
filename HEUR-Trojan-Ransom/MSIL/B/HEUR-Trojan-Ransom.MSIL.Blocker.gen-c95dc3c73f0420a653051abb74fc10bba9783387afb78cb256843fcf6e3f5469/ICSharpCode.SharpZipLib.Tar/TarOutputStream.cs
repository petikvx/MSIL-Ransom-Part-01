using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Tar;

public class TarOutputStream : Stream
{
	protected byte[] assemblyBuffer;

	private int jvmbBOqPCnovVMhDXGgvAULxLwcm;

	protected byte[] blockBuffer;

	protected TarBuffer buffer;

	private long kWlbFWOHWwEBQdRDpIcSKExBsexIA;

	protected long currSize;

	private bool nPtTMnqMwxYAgpAIMHLDgHmnGJgIb;

	protected Stream outputStream;

	public override bool CanRead => outputStream.CanRead;

	public override bool CanSeek => outputStream.CanSeek;

	public override bool CanWrite => outputStream.CanWrite;

	private bool hInRYTNKEyBTTgwuyafDgLNAWKgb => kWlbFWOHWwEBQdRDpIcSKExBsexIA < currSize;

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
		if (!nPtTMnqMwxYAgpAIMHLDgHmnGJgIb)
		{
			nPtTMnqMwxYAgpAIMHLDgHmnGJgIb = true;
			Finish();
			buffer.Close();
		}
	}

	public void CloseEntry()
	{
		if (jvmbBOqPCnovVMhDXGgvAULxLwcm > 0)
		{
			Array.Clear(assemblyBuffer, jvmbBOqPCnovVMhDXGgvAULxLwcm, assemblyBuffer.Length - jvmbBOqPCnovVMhDXGgvAULxLwcm);
			buffer.WriteBlock(assemblyBuffer);
			kWlbFWOHWwEBQdRDpIcSKExBsexIA += jvmbBOqPCnovVMhDXGgvAULxLwcm;
			jvmbBOqPCnovVMhDXGgvAULxLwcm = 0;
		}
		if (kWlbFWOHWwEBQdRDpIcSKExBsexIA < currSize)
		{
			throw new TarException($"Entry closed at '{kWlbFWOHWwEBQdRDpIcSKExBsexIA}' before the '{currSize}' bytes specified in the header were written");
		}
	}

	public void Finish()
	{
		if (hInRYTNKEyBTTgwuyafDgLNAWKgb)
		{
			CloseEntry();
		}
		vxIkSJEVWJFOWbbriTgCsUUgfRVn();
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
			TarHeader obj = new TarHeader
			{
				TypeFlag = 76
			};
			obj.Name += "././@LongLink";
			obj.UserId = 0;
			obj.GroupId = 0;
			obj.GroupName = "";
			obj.UserName = "";
			obj.LinkName = "";
			obj.Size = entry.TarHeader.Name.Length;
			obj.WriteHeader(blockBuffer);
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
		kWlbFWOHWwEBQdRDpIcSKExBsexIA = 0L;
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
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset", "Cannot be negative");
		}
		if (buffer.Length - offset < count)
		{
			throw new ArgumentException("offset and count combination is invalid");
		}
		if (count >= 0)
		{
			if (kWlbFWOHWwEBQdRDpIcSKExBsexIA + count > currSize)
			{
				string message = $"request to write '{count}' bytes exceeds size in header of '{currSize}' bytes";
				throw new ArgumentOutOfRangeException("count", message);
			}
			if (jvmbBOqPCnovVMhDXGgvAULxLwcm > 0)
			{
				if (jvmbBOqPCnovVMhDXGgvAULxLwcm + count < blockBuffer.Length)
				{
					Array.Copy(buffer, offset, assemblyBuffer, jvmbBOqPCnovVMhDXGgvAULxLwcm, count);
					offset += count;
					jvmbBOqPCnovVMhDXGgvAULxLwcm += count;
					count -= count;
				}
				else
				{
					int num = blockBuffer.Length - jvmbBOqPCnovVMhDXGgvAULxLwcm;
					Array.Copy(assemblyBuffer, 0, blockBuffer, 0, jvmbBOqPCnovVMhDXGgvAULxLwcm);
					Array.Copy(buffer, offset, blockBuffer, jvmbBOqPCnovVMhDXGgvAULxLwcm, num);
					this.buffer.WriteBlock(blockBuffer);
					kWlbFWOHWwEBQdRDpIcSKExBsexIA += blockBuffer.Length;
					offset += num;
					count -= num;
					jvmbBOqPCnovVMhDXGgvAULxLwcm = 0;
				}
			}
			while (true)
			{
				if (count > 0)
				{
					if (count < blockBuffer.Length)
					{
						break;
					}
					this.buffer.WriteBlock(buffer, offset);
					int num2 = blockBuffer.Length;
					kWlbFWOHWwEBQdRDpIcSKExBsexIA += num2;
					count -= num2;
					offset += num2;
					continue;
				}
				return;
			}
			Array.Copy(buffer, offset, assemblyBuffer, jvmbBOqPCnovVMhDXGgvAULxLwcm, count);
			jvmbBOqPCnovVMhDXGgvAULxLwcm += count;
			return;
		}
		throw new ArgumentOutOfRangeException("count", "Cannot be negative");
	}

	public override void WriteByte(byte value)
	{
		Write(new byte[1] { value }, 0, 1);
	}

	private void vxIkSJEVWJFOWbbriTgCsUUgfRVn()
	{
		Array.Clear(blockBuffer, 0, blockBuffer.Length);
		buffer.WriteBlock(blockBuffer);
	}
}
