using System;
using System.IO;
using System.Text;

namespace ICSharpCode.SharpZipLib.Tar;

public class TarInputStream : Stream
{
	public class EntryFactoryAdapter : IEntryFactory
	{
		public TarEntry CreateEntry(string name)
		{
			return TarEntry.CreateTarEntry(name);
		}

		public TarEntry CreateEntry(byte[] headerBuffer)
		{
			return new TarEntry(headerBuffer);
		}

		public TarEntry CreateEntryFromFile(string fileName)
		{
			return TarEntry.CreateEntryFromFile(fileName);
		}
	}

	public interface IEntryFactory
	{
		TarEntry CreateEntry(string name);

		TarEntry CreateEntry(byte[] headerBuffer);

		TarEntry CreateEntryFromFile(string fileName);
	}

	protected TarBuffer buffer;

	private TarEntry mucCjYhJqSWewbEcOkmILOpnsydY;

	protected IEntryFactory entryFactory;

	protected long entryOffset;

	protected long entrySize;

	protected bool hasHitEOF;

	private Stream viTxStDvqASejgqgxHTMyORUexkB;

	protected byte[] readBuffer;

	public long Available => entrySize - entryOffset;

	public override bool CanRead => viTxStDvqASejgqgxHTMyORUexkB.CanRead;

	public override bool CanSeek => false;

	public override bool CanWrite => false;

	public bool IsMarkSupported => false;

	public override long Length => viTxStDvqASejgqgxHTMyORUexkB.Length;

	public override long Position
	{
		get
		{
			return viTxStDvqASejgqgxHTMyORUexkB.Position;
		}
		set
		{
			throw new NotSupportedException("TarInputStream Seek not supported");
		}
	}

	public int RecordSize => buffer.RecordSize;

	public TarInputStream(Stream inputStream)
		: this(inputStream, 20)
	{
	}

	public TarInputStream(Stream inputStream, int blockFactor)
	{
		viTxStDvqASejgqgxHTMyORUexkB = inputStream;
		buffer = TarBuffer.CreateInputTarBuffer(inputStream, blockFactor);
	}

	public override void Close()
	{
		buffer.Close();
	}

	public void CopyEntryContents(Stream outputStream)
	{
		byte[] array = new byte[32768];
		while (true)
		{
			int num = Read(array, 0, array.Length);
			if (num > 0)
			{
				outputStream.Write(array, 0, num);
				continue;
			}
			break;
		}
	}

	public override void Flush()
	{
		viTxStDvqASejgqgxHTMyORUexkB.Flush();
	}

	public TarEntry GetNextEntry()
	{
		if (hasHitEOF)
		{
			return null;
		}
		if (mucCjYhJqSWewbEcOkmILOpnsydY != null)
		{
			uVpBSuFoGoSCIKptTDKJyQnqKGMYA();
		}
		byte[] array = buffer.ReadBlock();
		if (array == null)
		{
			hasHitEOF = true;
		}
		else if (TarBuffer.IsEndOfArchiveBlock(array))
		{
			hasHitEOF = true;
		}
		if (hasHitEOF)
		{
			mucCjYhJqSWewbEcOkmILOpnsydY = null;
		}
		else
		{
			try
			{
				TarHeader tarHeader = new TarHeader();
				tarHeader.ParseBuffer(array);
				if (!tarHeader.IsChecksumValid)
				{
					throw new TarException("Header checksum is invalid");
				}
				entryOffset = 0L;
				entrySize = tarHeader.Size;
				StringBuilder stringBuilder = null;
				if (tarHeader.TypeFlag == 76)
				{
					byte[] array2 = new byte[512];
					long num = entrySize;
					stringBuilder = new StringBuilder();
					while (num > 0L)
					{
						int num2 = Read(array2, 0, (int)((num > array2.Length) ? array2.Length : num));
						if (num2 != -1)
						{
							stringBuilder.Append(TarHeader.ParseName(array2, 0, num2).ToString());
							num -= num2;
							continue;
						}
						throw new InvalidHeaderException("Failed to read long name entry");
					}
					uVpBSuFoGoSCIKptTDKJyQnqKGMYA();
					array = buffer.ReadBlock();
				}
				else if (tarHeader.TypeFlag == 103)
				{
					uVpBSuFoGoSCIKptTDKJyQnqKGMYA();
					array = buffer.ReadBlock();
				}
				else if (tarHeader.TypeFlag == 120)
				{
					uVpBSuFoGoSCIKptTDKJyQnqKGMYA();
					array = buffer.ReadBlock();
				}
				else if (tarHeader.TypeFlag == 86)
				{
					uVpBSuFoGoSCIKptTDKJyQnqKGMYA();
					array = buffer.ReadBlock();
				}
				else if (tarHeader.TypeFlag != 48 && tarHeader.TypeFlag != 0 && tarHeader.TypeFlag != 53)
				{
					uVpBSuFoGoSCIKptTDKJyQnqKGMYA();
					array = buffer.ReadBlock();
				}
				if (entryFactory == null)
				{
					mucCjYhJqSWewbEcOkmILOpnsydY = new TarEntry(array);
					if (stringBuilder != null)
					{
						mucCjYhJqSWewbEcOkmILOpnsydY.Name = stringBuilder.ToString();
					}
				}
				else
				{
					mucCjYhJqSWewbEcOkmILOpnsydY = entryFactory.CreateEntry(array);
				}
				entryOffset = 0L;
				entrySize = mucCjYhJqSWewbEcOkmILOpnsydY.Size;
			}
			catch (InvalidHeaderException ex)
			{
				entrySize = 0L;
				entryOffset = 0L;
				mucCjYhJqSWewbEcOkmILOpnsydY = null;
				throw new InvalidHeaderException($"Bad header in record {buffer.CurrentRecord} block {buffer.CurrentBlock} {ex.Message}");
			}
		}
		return mucCjYhJqSWewbEcOkmILOpnsydY;
	}

	[Obsolete("Use RecordSize property instead")]
	public int GetRecordSize()
	{
		return buffer.RecordSize;
	}

	public void Mark(int markLimit)
	{
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		int num = 0;
		if (entryOffset < entrySize)
		{
			long num2 = count;
			if (num2 + entryOffset > entrySize)
			{
				num2 = entrySize - entryOffset;
			}
			if (readBuffer != null)
			{
				int num3 = (int)((num2 > readBuffer.Length) ? readBuffer.Length : num2);
				Array.Copy(readBuffer, 0, buffer, offset, num3);
				if (num3 < readBuffer.Length)
				{
					int num4 = readBuffer.Length - num3;
					byte[] destinationArray = new byte[num4];
					Array.Copy(readBuffer, num3, destinationArray, 0, num4);
					readBuffer = destinationArray;
				}
				else
				{
					readBuffer = null;
				}
				num += num3;
				num2 -= num3;
				offset += num3;
			}
			while (num2 > 0L)
			{
				byte[] array = this.buffer.ReadBlock();
				if (array != null)
				{
					int num5 = (int)num2;
					int num6 = array.Length;
					if (num6 > num5)
					{
						Array.Copy(array, 0, buffer, offset, num5);
						readBuffer = new byte[num6 - num5];
						Array.Copy(array, num5, readBuffer, 0, num6 - num5);
					}
					else
					{
						num5 = num6;
						Array.Copy(array, 0, buffer, offset, num6);
					}
					num += num5;
					num2 -= num5;
					offset += num5;
					continue;
				}
				throw new TarException("unexpected EOF with " + num2 + " bytes unread");
			}
			entryOffset += num;
			return num;
		}
		return 0;
	}

	public override int ReadByte()
	{
		byte[] array = new byte[1];
		if (Read(array, 0, 1) <= 0)
		{
			return -1;
		}
		return array[0];
	}

	public void Reset()
	{
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		throw new NotSupportedException("TarInputStream Seek not supported");
	}

	public void SetEntryFactory(IEntryFactory factory)
	{
		entryFactory = factory;
	}

	public override void SetLength(long value)
	{
		throw new NotSupportedException("TarInputStream SetLength not supported");
	}

	public void Skip(long skipCount)
	{
		byte[] array = new byte[8192];
		long num = skipCount;
		while (num > 0L)
		{
			int count = (int)((num > array.Length) ? array.Length : num);
			int num2 = Read(array, 0, count);
			if (num2 != -1)
			{
				num -= num2;
				continue;
			}
			break;
		}
	}

	private void uVpBSuFoGoSCIKptTDKJyQnqKGMYA()
	{
		long num = entrySize - entryOffset;
		if (num > 0L)
		{
			Skip(num);
		}
		readBuffer = null;
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		throw new NotSupportedException("TarInputStream Write not supported");
	}

	public override void WriteByte(byte value)
	{
		throw new NotSupportedException("TarInputStream WriteByte not supported");
	}
}
