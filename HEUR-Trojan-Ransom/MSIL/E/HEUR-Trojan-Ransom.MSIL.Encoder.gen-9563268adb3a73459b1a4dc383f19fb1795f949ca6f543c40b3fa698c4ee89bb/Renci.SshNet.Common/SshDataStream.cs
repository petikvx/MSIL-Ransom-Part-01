using System;
using System.Globalization;
using System.IO;
using System.Text;

namespace Renci.SshNet.Common;

public class SshDataStream : MemoryStream
{
	public bool IsEndOfData => Position >= Length;

	public SshDataStream(int capacity)
		: base(capacity)
	{
	}

	public SshDataStream(byte[] buffer)
		: base(buffer)
	{
	}

	public SshDataStream(byte[] buffer, int offset, int count)
		: base(buffer, offset, count)
	{
	}

	public void Write(uint value)
	{
		byte[] array = Pack.UInt32ToBigEndian(value);
		Write(array, 0, array.Length);
	}

	public void Write(ulong value)
	{
		byte[] array = Pack.UInt64ToBigEndian(value);
		Write(array, 0, array.Length);
	}

	public void Write(BigInteger data)
	{
		byte[] array = data.ToByteArray().Reverse();
		WriteBinary(array, 0, array.Length);
	}

	public void Write(byte[] data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		Write(data, 0, data.Length);
	}

	public byte[] ReadBinary()
	{
		uint num = ReadUInt32();
		if (num > int.MaxValue)
		{
			throw new NotSupportedException(string.Format(CultureInfo.CurrentCulture, "Data longer than {0} is not supported.", new object[1] { int.MaxValue }));
		}
		return ReadBytes((int)num);
	}

	public void WriteBinary(byte[] buffer)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		WriteBinary(buffer, 0, buffer.Length);
	}

	public void WriteBinary(byte[] buffer, int offset, int count)
	{
		Write((uint)count);
		Write(buffer, offset, count);
	}

	public void Write(string s, Encoding encoding)
	{
		if (encoding == null)
		{
			throw new ArgumentNullException("encoding");
		}
		byte[] bytes = encoding.GetBytes(s);
		WriteBinary(bytes, 0, bytes.Length);
	}

	public BigInteger ReadBigInt()
	{
		uint length = ReadUInt32();
		return new BigInteger(ReadBytes((int)length).Reverse());
	}

	public uint ReadUInt32()
	{
		return Pack.BigEndianToUInt32(ReadBytes(4));
	}

	public ulong ReadUInt64()
	{
		return Pack.BigEndianToUInt64(ReadBytes(8));
	}

	public string ReadString(Encoding encoding)
	{
		uint num = ReadUInt32();
		if (num > int.MaxValue)
		{
			throw new NotSupportedException(string.Format(CultureInfo.CurrentCulture, "Strings longer than {0} is not supported.", new object[1] { int.MaxValue }));
		}
		byte[] array = ReadBytes((int)num);
		return encoding.GetString(array, 0, array.Length);
	}

	private byte[] ReadBytes(int length)
	{
		byte[] array = new byte[length];
		int num = Read(array, 0, length);
		if (num < length)
		{
			throw new ArgumentOutOfRangeException("length", string.Format(CultureInfo.InvariantCulture, "The requested length ({0}) is greater than the actual number of bytes read ({1}).", new object[2] { length, num }));
		}
		return array;
	}

	public override byte[] ToArray()
	{
		if (Capacity == Length)
		{
			return GetBuffer();
		}
		return base.ToArray();
	}
}
