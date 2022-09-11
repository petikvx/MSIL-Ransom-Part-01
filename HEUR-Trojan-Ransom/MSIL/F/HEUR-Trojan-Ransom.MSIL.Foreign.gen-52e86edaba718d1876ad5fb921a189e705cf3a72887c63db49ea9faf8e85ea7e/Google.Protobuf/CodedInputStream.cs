using System;
using System.Collections.Generic;
using System.IO;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace Google.Protobuf;

public sealed class CodedInputStream : IDisposable
{
	private readonly bool leaveOpen;

	private readonly byte[] buffer;

	private int bufferSize;

	private int bufferSizeAfterLimit;

	private int bufferPos;

	private readonly Stream input;

	private uint lastTag;

	private uint nextTag;

	private bool hasNextTag;

	internal const int DefaultRecursionLimit = 64;

	internal const int DefaultSizeLimit = 67108864;

	internal const int BufferSize = 4096;

	private int totalBytesRetired;

	private int currentLimit = int.MaxValue;

	private int recursionDepth;

	private readonly int recursionLimit;

	private readonly int sizeLimit;

	[NonSerialized]
	internal static GetString getString_0;

	public long Position
	{
		get
		{
			if (input != null)
			{
				return input.Position - (bufferSize + bufferSizeAfterLimit - bufferPos);
			}
			return bufferPos;
		}
	}

	internal uint LastTag => lastTag;

	public int SizeLimit => sizeLimit;

	public int RecursionLimit => recursionLimit;

	internal bool ReachedLimit
	{
		get
		{
			if (currentLimit == int.MaxValue)
			{
				return false;
			}
			return totalBytesRetired + bufferPos >= currentLimit;
		}
	}

	public bool IsAtEnd
	{
		get
		{
			if (bufferPos == bufferSize)
			{
				return !RefillBuffer(mustSucceed: false);
			}
			return false;
		}
	}

	public CodedInputStream(byte[] buffer)
		: this(null, ProtoPreconditions.CheckNotNull(buffer, getString_0(107355581)), 0, buffer.Length, leaveOpen: true)
	{
	}

	public CodedInputStream(byte[] buffer, int offset, int length)
		: this(null, ProtoPreconditions.CheckNotNull(buffer, getString_0(107355581)), offset, offset + length, leaveOpen: true)
	{
		if (offset >= 0 && offset <= buffer.Length)
		{
			if (length < 0 || offset + length > buffer.Length)
			{
				throw new ArgumentOutOfRangeException(getString_0(107360982), getString_0(107369812));
			}
			return;
		}
		throw new ArgumentOutOfRangeException(getString_0(107355572), getString_0(107369857));
	}

	public CodedInputStream(Stream input)
		: this(input, leaveOpen: false)
	{
	}

	public CodedInputStream(Stream input, bool leaveOpen)
		: this(ProtoPreconditions.CheckNotNull(input, getString_0(107370223)), new byte[4096], 0, 0, leaveOpen)
	{
	}

	internal CodedInputStream(Stream input, byte[] buffer, int bufferPos, int bufferSize, bool leaveOpen)
	{
		this.input = input;
		this.buffer = buffer;
		this.bufferPos = bufferPos;
		this.bufferSize = bufferSize;
		sizeLimit = 67108864;
		recursionLimit = 64;
		this.leaveOpen = leaveOpen;
	}

	internal CodedInputStream(Stream input, byte[] buffer, int bufferPos, int bufferSize, int sizeLimit, int recursionLimit, bool leaveOpen)
		: this(input, buffer, bufferPos, bufferSize, leaveOpen)
	{
		if (sizeLimit <= 0)
		{
			throw new ArgumentOutOfRangeException(getString_0(107370214), getString_0(107370233));
		}
		if (recursionLimit <= 0)
		{
			throw new ArgumentOutOfRangeException(getString_0(107370196), getString_0(107370175));
		}
		this.sizeLimit = sizeLimit;
		this.recursionLimit = recursionLimit;
	}

	public static CodedInputStream CreateWithLimits(Stream input, int sizeLimit, int recursionLimit)
	{
		return new CodedInputStream(input, new byte[4096], 0, 0, sizeLimit, recursionLimit, leaveOpen: false);
	}

	public void Dispose()
	{
		if (!leaveOpen)
		{
			input.Dispose();
		}
	}

	internal void CheckReadEndOfStreamTag()
	{
		if (lastTag != 0)
		{
			throw InvalidProtocolBufferException.MoreDataAvailable();
		}
	}

	public uint PeekTag()
	{
		if (hasNextTag)
		{
			return nextTag;
		}
		uint num = lastTag;
		nextTag = ReadTag();
		hasNextTag = true;
		lastTag = num;
		return nextTag;
	}

	public uint ReadTag()
	{
		if (hasNextTag)
		{
			lastTag = nextTag;
			hasNextTag = false;
			return lastTag;
		}
		if (bufferPos + 2 <= bufferSize)
		{
			int num = buffer[bufferPos++];
			if (num < 128)
			{
				lastTag = (uint)num;
			}
			else
			{
				int num2 = num & 0x7F;
				if ((num = buffer[bufferPos++]) < 128)
				{
					num2 = (int)(lastTag = (uint)(num2 | (num << 7)));
				}
				else
				{
					bufferPos -= 2;
					lastTag = ReadRawVarint32();
				}
			}
		}
		else
		{
			if (IsAtEnd)
			{
				lastTag = 0u;
				return 0u;
			}
			lastTag = ReadRawVarint32();
		}
		if (WireFormat.GetTagFieldNumber(lastTag) == 0)
		{
			throw InvalidProtocolBufferException.InvalidTag();
		}
		return lastTag;
	}

	public void SkipLastField()
	{
		if (lastTag == 0)
		{
			throw new InvalidOperationException(getString_0(107370130));
		}
		switch (WireFormat.GetTagWireType(lastTag))
		{
		case WireFormat.WireType.Varint:
			ReadRawVarint32();
			break;
		case WireFormat.WireType.Fixed64:
			ReadFixed64();
			break;
		case WireFormat.WireType.LengthDelimited:
		{
			int size = ReadLength();
			SkipRawBytes(size);
			break;
		}
		case WireFormat.WireType.StartGroup:
			SkipGroup(lastTag);
			break;
		case WireFormat.WireType.EndGroup:
			throw new InvalidProtocolBufferException(getString_0(107369513));
		case WireFormat.WireType.Fixed32:
			ReadFixed32();
			break;
		}
	}

	internal void SkipGroup(uint startGroupTag)
	{
		recursionDepth++;
		if (recursionDepth >= recursionLimit)
		{
			throw InvalidProtocolBufferException.RecursionLimitExceeded();
		}
		uint num;
		while (true)
		{
			num = ReadTag();
			if (num != 0)
			{
				if (WireFormat.GetTagWireType(num) == WireFormat.WireType.EndGroup)
				{
					break;
				}
				SkipLastField();
				continue;
			}
			throw InvalidProtocolBufferException.TruncatedMessage();
		}
		int tagFieldNumber = WireFormat.GetTagFieldNumber(startGroupTag);
		int tagFieldNumber2 = WireFormat.GetTagFieldNumber(num);
		if (tagFieldNumber != tagFieldNumber2)
		{
			throw new InvalidProtocolBufferException(string.Format(getString_0(107369379), tagFieldNumber, tagFieldNumber2));
		}
		recursionDepth--;
	}

	public double ReadDouble()
	{
		return BitConverter.Int64BitsToDouble((long)ReadRawLittleEndian64());
	}

	public float ReadFloat()
	{
		if (BitConverter.IsLittleEndian && 4 <= bufferSize - bufferPos)
		{
			float result = BitConverter.ToSingle(buffer, bufferPos);
			bufferPos += 4;
			return result;
		}
		byte[] array = ReadRawBytes(4);
		if (!BitConverter.IsLittleEndian)
		{
			ByteArray.Reverse(array);
		}
		return BitConverter.ToSingle(array, 0);
	}

	public ulong ReadUInt64()
	{
		return ReadRawVarint64();
	}

	public long ReadInt64()
	{
		return (long)ReadRawVarint64();
	}

	public int ReadInt32()
	{
		return (int)ReadRawVarint32();
	}

	public ulong ReadFixed64()
	{
		return ReadRawLittleEndian64();
	}

	public uint ReadFixed32()
	{
		return ReadRawLittleEndian32();
	}

	public bool ReadBool()
	{
		return ReadRawVarint32() != 0;
	}

	public string ReadString()
	{
		int num = ReadLength();
		if (num == 0)
		{
			return getString_0(107399493);
		}
		if (num <= bufferSize - bufferPos)
		{
			string @string = CodedOutputStream.Utf8Encoding.GetString(buffer, bufferPos, num);
			bufferPos += num;
			return @string;
		}
		return CodedOutputStream.Utf8Encoding.GetString(ReadRawBytes(num), 0, num);
	}

	public void ReadMessage(IMessage builder)
	{
		int byteLimit = ReadLength();
		if (recursionDepth >= recursionLimit)
		{
			throw InvalidProtocolBufferException.RecursionLimitExceeded();
		}
		int oldLimit = PushLimit(byteLimit);
		recursionDepth++;
		builder.MergeFrom(this);
		CheckReadEndOfStreamTag();
		if (!ReachedLimit)
		{
			throw InvalidProtocolBufferException.TruncatedMessage();
		}
		recursionDepth--;
		PopLimit(oldLimit);
	}

	public ByteString ReadBytes()
	{
		int num = ReadLength();
		if (num <= bufferSize - bufferPos && num > 0)
		{
			ByteString result = ByteString.CopyFrom(buffer, bufferPos, num);
			bufferPos += num;
			return result;
		}
		return ByteString.AttachBytes(ReadRawBytes(num));
	}

	public uint ReadUInt32()
	{
		return ReadRawVarint32();
	}

	public int ReadEnum()
	{
		return (int)ReadRawVarint32();
	}

	public int ReadSFixed32()
	{
		return (int)ReadRawLittleEndian32();
	}

	public long ReadSFixed64()
	{
		return (long)ReadRawLittleEndian64();
	}

	public int ReadSInt32()
	{
		return DecodeZigZag32(ReadRawVarint32());
	}

	public long ReadSInt64()
	{
		return DecodeZigZag64(ReadRawVarint64());
	}

	public int ReadLength()
	{
		return (int)ReadRawVarint32();
	}

	public bool MaybeConsumeTag(uint tag)
	{
		if (PeekTag() == tag)
		{
			hasNextTag = false;
			return true;
		}
		return false;
	}

	private uint SlowReadRawVarint32()
	{
		int num = ReadRawByte();
		if (num < 128)
		{
			return (uint)num;
		}
		int num2 = num & 0x7F;
		if ((num = ReadRawByte()) < 128)
		{
			num2 |= num << 7;
		}
		else
		{
			num2 |= (num & 0x7F) << 7;
			if ((num = ReadRawByte()) < 128)
			{
				num2 |= num << 14;
			}
			else
			{
				num2 |= (num & 0x7F) << 14;
				if ((num = ReadRawByte()) < 128)
				{
					num2 |= num << 21;
				}
				else
				{
					num2 |= (num & 0x7F) << 21;
					num2 |= (num = ReadRawByte()) << 28;
					if (num >= 128)
					{
						int num3 = 0;
						while (true)
						{
							if (num3 < 5)
							{
								if (ReadRawByte() < 128)
								{
									break;
								}
								num3++;
								continue;
							}
							throw InvalidProtocolBufferException.MalformedVarint();
						}
						return (uint)num2;
					}
				}
			}
		}
		return (uint)num2;
	}

	internal uint ReadRawVarint32()
	{
		if (bufferPos + 5 > bufferSize)
		{
			return SlowReadRawVarint32();
		}
		int num = buffer[bufferPos++];
		if (num < 128)
		{
			return (uint)num;
		}
		int num2 = num & 0x7F;
		if ((num = buffer[bufferPos++]) < 128)
		{
			num2 |= num << 7;
		}
		else
		{
			num2 |= (num & 0x7F) << 7;
			if ((num = buffer[bufferPos++]) < 128)
			{
				num2 |= num << 14;
			}
			else
			{
				num2 |= (num & 0x7F) << 14;
				if ((num = buffer[bufferPos++]) < 128)
				{
					num2 |= num << 21;
				}
				else
				{
					num2 |= (num & 0x7F) << 21;
					num2 |= (num = buffer[bufferPos++]) << 28;
					if (num >= 128)
					{
						int num3 = 0;
						while (true)
						{
							if (num3 < 5)
							{
								if (ReadRawByte() < 128)
								{
									break;
								}
								num3++;
								continue;
							}
							throw InvalidProtocolBufferException.MalformedVarint();
						}
						return (uint)num2;
					}
				}
			}
		}
		return (uint)num2;
	}

	internal static uint ReadRawVarint32(Stream input)
	{
		int num = 0;
		int num2 = 0;
		while (true)
		{
			if (num2 < 32)
			{
				int num3 = input.ReadByte();
				if (num3 != -1)
				{
					num |= (num3 & 0x7F) << num2;
					if ((num3 & 0x80) == 0)
					{
						break;
					}
					num2 += 7;
					continue;
				}
				throw InvalidProtocolBufferException.TruncatedMessage();
			}
			while (true)
			{
				if (num2 < 64)
				{
					int num4 = input.ReadByte();
					if (num4 != -1)
					{
						if ((num4 & 0x80) == 0)
						{
							break;
						}
						num2 += 7;
						continue;
					}
					throw InvalidProtocolBufferException.TruncatedMessage();
				}
				throw InvalidProtocolBufferException.MalformedVarint();
			}
			return (uint)num;
		}
		return (uint)num;
	}

	internal ulong ReadRawVarint64()
	{
		int num = 0;
		ulong num2 = 0uL;
		while (true)
		{
			if (num < 64)
			{
				byte b = ReadRawByte();
				num2 |= (ulong)((long)(b & 0x7F) << num);
				if ((b & 0x80) == 0)
				{
					break;
				}
				num += 7;
				continue;
			}
			throw InvalidProtocolBufferException.MalformedVarint();
		}
		return num2;
	}

	internal uint ReadRawLittleEndian32()
	{
		byte num = ReadRawByte();
		uint num2 = ReadRawByte();
		uint num3 = ReadRawByte();
		uint num4 = ReadRawByte();
		return num | (num2 << 8) | (num3 << 16) | (num4 << 24);
	}

	internal ulong ReadRawLittleEndian64()
	{
		long num = ReadRawByte();
		ulong num2 = ReadRawByte();
		ulong num3 = ReadRawByte();
		ulong num4 = ReadRawByte();
		ulong num5 = ReadRawByte();
		ulong num6 = ReadRawByte();
		ulong num7 = ReadRawByte();
		ulong num8 = ReadRawByte();
		return (ulong)num | (num2 << 8) | (num3 << 16) | (num4 << 24) | (num5 << 32) | (num6 << 40) | (num7 << 48) | (num8 << 56);
	}

	internal static int DecodeZigZag32(uint n)
	{
		return (int)((n >> 1) ^ (0 - (n & 1)));
	}

	internal static long DecodeZigZag64(ulong n)
	{
		return (long)((n >> 1) ^ (0L - (n & 1L)));
	}

	internal int PushLimit(int byteLimit)
	{
		if (byteLimit < 0)
		{
			throw InvalidProtocolBufferException.NegativeSize();
		}
		byteLimit += totalBytesRetired + bufferPos;
		int num = currentLimit;
		if (byteLimit > num)
		{
			throw InvalidProtocolBufferException.TruncatedMessage();
		}
		currentLimit = byteLimit;
		RecomputeBufferSizeAfterLimit();
		return num;
	}

	private void RecomputeBufferSizeAfterLimit()
	{
		bufferSize += bufferSizeAfterLimit;
		int num = totalBytesRetired + bufferSize;
		if (num > currentLimit)
		{
			bufferSizeAfterLimit = num - currentLimit;
			bufferSize -= bufferSizeAfterLimit;
		}
		else
		{
			bufferSizeAfterLimit = 0;
		}
	}

	internal void PopLimit(int oldLimit)
	{
		currentLimit = oldLimit;
		RecomputeBufferSizeAfterLimit();
	}

	private bool RefillBuffer(bool mustSucceed)
	{
		if (bufferPos < bufferSize)
		{
			throw new InvalidOperationException(getString_0(107369282));
		}
		if (totalBytesRetired + bufferSize == currentLimit)
		{
			if (mustSucceed)
			{
				throw InvalidProtocolBufferException.TruncatedMessage();
			}
			return false;
		}
		totalBytesRetired += bufferSize;
		bufferPos = 0;
		bufferSize = ((input != null) ? input.Read(buffer, 0, buffer.Length) : 0);
		if (bufferSize < 0)
		{
			throw new InvalidOperationException(getString_0(107369761));
		}
		if (bufferSize == 0)
		{
			if (mustSucceed)
			{
				throw InvalidProtocolBufferException.TruncatedMessage();
			}
			return false;
		}
		RecomputeBufferSizeAfterLimit();
		int num = totalBytesRetired + bufferSize + bufferSizeAfterLimit;
		if (num > sizeLimit || num < 0)
		{
			throw InvalidProtocolBufferException.SizeLimitExceeded();
		}
		return true;
	}

	internal byte ReadRawByte()
	{
		if (bufferPos == bufferSize)
		{
			RefillBuffer(mustSucceed: true);
		}
		return buffer[bufferPos++];
	}

	internal byte[] ReadRawBytes(int size)
	{
		if (size < 0)
		{
			throw InvalidProtocolBufferException.NegativeSize();
		}
		if (totalBytesRetired + bufferPos + size > currentLimit)
		{
			SkipRawBytes(currentLimit - totalBytesRetired - bufferPos);
			throw InvalidProtocolBufferException.TruncatedMessage();
		}
		if (size <= bufferSize - bufferPos)
		{
			byte[] array = new byte[size];
			ByteArray.Copy(buffer, bufferPos, array, 0, size);
			bufferPos += size;
			return array;
		}
		if (size < buffer.Length)
		{
			byte[] array2 = new byte[size];
			int num = bufferSize - bufferPos;
			ByteArray.Copy(buffer, bufferPos, array2, 0, num);
			bufferPos = bufferSize;
			RefillBuffer(mustSucceed: true);
			while (size - num > bufferSize)
			{
				Buffer.BlockCopy(buffer, 0, array2, num, bufferSize);
				num += bufferSize;
				bufferPos = bufferSize;
				RefillBuffer(mustSucceed: true);
			}
			ByteArray.Copy(buffer, 0, array2, num, size - num);
			bufferPos = size - num;
			return array2;
		}
		int num2 = bufferPos;
		int num3 = bufferSize;
		totalBytesRetired += bufferSize;
		bufferPos = 0;
		bufferSize = 0;
		int num4 = size - (num3 - num2);
		List<byte[]> list = new List<byte[]>();
		while (num4 > 0)
		{
			byte[] array3 = new byte[Math.Min(num4, buffer.Length)];
			int num5;
			for (int i = 0; i < array3.Length; i += num5)
			{
				num5 = ((input == null) ? (-1) : input.Read(array3, i, array3.Length - i));
				if (num5 > 0)
				{
					totalBytesRetired += num5;
					continue;
				}
				throw InvalidProtocolBufferException.TruncatedMessage();
			}
			num4 -= array3.Length;
			list.Add(array3);
		}
		byte[] array4 = new byte[size];
		int num6 = num3 - num2;
		ByteArray.Copy(buffer, num2, array4, 0, num6);
		foreach (byte[] item in list)
		{
			Buffer.BlockCopy(item, 0, array4, num6, item.Length);
			num6 += item.Length;
		}
		return array4;
	}

	private void SkipRawBytes(int size)
	{
		if (size < 0)
		{
			throw InvalidProtocolBufferException.NegativeSize();
		}
		if (totalBytesRetired + bufferPos + size > currentLimit)
		{
			SkipRawBytes(currentLimit - totalBytesRetired - bufferPos);
			throw InvalidProtocolBufferException.TruncatedMessage();
		}
		if (size <= bufferSize - bufferPos)
		{
			bufferPos += size;
			return;
		}
		int num = bufferSize - bufferPos;
		totalBytesRetired += bufferSize;
		bufferPos = 0;
		bufferSize = 0;
		if (num < size)
		{
			if (input == null)
			{
				throw InvalidProtocolBufferException.TruncatedMessage();
			}
			SkipImpl(size - num);
			totalBytesRetired += size - num;
		}
	}

	private void SkipImpl(int amountToSkip)
	{
		if (input.CanSeek)
		{
			long position = input.Position;
			input.Position += amountToSkip;
			if (input.Position != position + amountToSkip)
			{
				throw InvalidProtocolBufferException.TruncatedMessage();
			}
			return;
		}
		byte[] array = new byte[Math.Min(1024, amountToSkip)];
		while (true)
		{
			if (amountToSkip > 0)
			{
				int num = input.Read(array, 0, Math.Min(array.Length, amountToSkip));
				if (num <= 0)
				{
					break;
				}
				amountToSkip -= num;
				continue;
			}
			return;
		}
		throw InvalidProtocolBufferException.TruncatedMessage();
	}

	static CodedInputStream()
	{
		Strings.CreateGetStringDelegate(typeof(CodedInputStream));
	}
}
