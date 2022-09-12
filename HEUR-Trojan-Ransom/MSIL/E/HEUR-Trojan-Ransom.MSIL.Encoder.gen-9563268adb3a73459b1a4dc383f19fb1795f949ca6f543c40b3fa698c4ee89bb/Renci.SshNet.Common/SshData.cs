using System;
using System.Collections.Generic;
using System.Text;

namespace Renci.SshNet.Common;

public abstract class SshData
{
	internal const int DefaultCapacity = 64;

	internal static readonly Encoding Ascii = Encoding.ASCII;

	internal static readonly Encoding Utf8 = Encoding.UTF8;

	private SshDataStream _stream;

	protected SshDataStream DataStream => _stream;

	protected bool IsEndOfData => _stream.Position >= _stream.Length;

	protected virtual int BufferCapacity => 0;

	public byte[] GetBytes()
	{
		int bufferCapacity = BufferCapacity;
		SshDataStream sshDataStream = new SshDataStream((bufferCapacity != -1) ? bufferCapacity : 64);
		WriteBytes(sshDataStream);
		return sshDataStream.ToArray();
	}

	protected virtual void WriteBytes(SshDataStream stream)
	{
		_stream = stream;
		SaveData();
	}

	public void Load(byte[] data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		LoadInternal(data, 0, data.Length);
	}

	public void Load(byte[] data, int offset, int count)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		LoadInternal(data, offset, count);
	}

	private void LoadInternal(byte[] value, int offset, int count)
	{
		_stream = new SshDataStream(value, offset, count);
		LoadData();
	}

	protected abstract void LoadData();

	protected abstract void SaveData();

	protected byte[] ReadBytes()
	{
		int num = (int)(_stream.Length - _stream.Position);
		byte[] array = new byte[num];
		_stream.Read(array, 0, num);
		return array;
	}

	protected byte[] ReadBytes(int length)
	{
		byte[] array = new byte[length];
		if (_stream.Read(array, 0, length) < length)
		{
			throw new ArgumentOutOfRangeException("length");
		}
		return array;
	}

	protected byte ReadByte()
	{
		int num = _stream.ReadByte();
		if (num == -1)
		{
			throw new InvalidOperationException("Attempt to read past the end of the SSH data stream.");
		}
		return (byte)num;
	}

	protected bool ReadBoolean()
	{
		return ReadByte() != 0;
	}

	protected ushort ReadUInt16()
	{
		return Pack.BigEndianToUInt16(ReadBytes(2));
	}

	protected uint ReadUInt32()
	{
		return Pack.BigEndianToUInt32(ReadBytes(4));
	}

	protected ulong ReadUInt64()
	{
		return Pack.BigEndianToUInt64(ReadBytes(8));
	}

	protected string ReadString(Encoding encoding)
	{
		return _stream.ReadString(encoding);
	}

	protected byte[] ReadBinary()
	{
		return _stream.ReadBinary();
	}

	protected string[] ReadNamesList()
	{
		return ReadString(Ascii).Split(new char[1] { ',' });
	}

	protected IDictionary<string, string> ReadExtensionPair()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		while (!IsEndOfData)
		{
			string key = ReadString(Ascii);
			string value = ReadString(Ascii);
			dictionary.Add(key, value);
		}
		return dictionary;
	}

	protected void Write(byte[] data)
	{
		_stream.Write(data);
	}

	protected void Write(byte[] buffer, int offset, int count)
	{
		_stream.Write(buffer, offset, count);
	}

	protected void Write(byte data)
	{
		_stream.WriteByte(data);
	}

	protected void Write(bool data)
	{
		Write((byte)(data ? 1 : 0));
	}

	protected void Write(uint data)
	{
		_stream.Write(data);
	}

	protected void Write(ulong data)
	{
		_stream.Write(data);
	}

	protected void Write(string data)
	{
		Write(data, Utf8);
	}

	protected void Write(string data, Encoding encoding)
	{
		_stream.Write(data, encoding);
	}

	protected void WriteBinaryString(byte[] buffer)
	{
		_stream.WriteBinary(buffer);
	}

	protected void WriteBinary(byte[] buffer, int offset, int count)
	{
		_stream.WriteBinary(buffer, offset, count);
	}

	protected void Write(BigInteger data)
	{
		_stream.Write(data);
	}

	protected void Write(string[] data)
	{
		Write(string.Join(",", data), Ascii);
	}

	protected void Write(IDictionary<string, string> data)
	{
		foreach (KeyValuePair<string, string> datum in data)
		{
			Write(datum.Key, Ascii);
			Write(datum.Value, Ascii);
		}
	}
}
