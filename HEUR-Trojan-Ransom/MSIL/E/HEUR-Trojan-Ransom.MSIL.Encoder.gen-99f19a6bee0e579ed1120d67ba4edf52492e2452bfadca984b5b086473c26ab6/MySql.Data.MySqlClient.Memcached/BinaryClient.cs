using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MySql.Data.MySqlClient.Memcached;

public class BinaryClient : Client
{
	private enum OpCodes : byte
	{
		Get = 0,
		Set = 1,
		Add = 2,
		Replace = 3,
		Delete = 4,
		Increment = 5,
		Decrement = 6,
		Quit = 7,
		Flush = 8,
		GetK = 12,
		GetKQ = 13,
		Append = 14,
		Prepend = 15,
		SASL_list_mechs = 32,
		SASL_Auth = 33,
		SASL_Step = 34
	}

	private enum MagicByte : byte
	{
		Request = 128,
		Response
	}

	private enum ResponseStatus : ushort
	{
		NoError = 0,
		KeyNotFound = 1,
		KeyExists = 2,
		ValueTooLarge = 3,
		InvalidArguments = 4,
		ItemNotStored = 5,
		IncrDecrOnNonNumericValue = 6,
		VbucketBelongsToAnotherServer = 7,
		AuthenticationError = 8,
		AuthenticationContinue = 9,
		UnknownCommand = 129,
		OutOfMemory = 130,
		NotSupported = 131,
		InternalError = 132,
		Busy = 133,
		TemporaryFailure = 134
	}

	private readonly Encoding _encoding;

	public BinaryClient(string server, uint port)
		: base(server, port)
	{
		_encoding = Encoding.UTF8;
	}

	public override void Add(string key, object data, TimeSpan expiration)
	{
		SendCommand(128, 2, key, data, expiration, hasExtra: true);
	}

	public override void Append(string key, object data)
	{
		SendCommand(128, 14, key, data, TimeSpan.Zero, hasExtra: false);
	}

	public override void Cas(string key, object data, TimeSpan expiration, ulong casUnique)
	{
		throw new NotImplementedException("Not available in binary protocol");
	}

	public override void Decrement(string key, int amount)
	{
		SendCommand(128, 6, key, amount);
	}

	public override void Delete(string key)
	{
		SendCommand(128, 4, key);
	}

	public override void FlushAll(TimeSpan delay)
	{
		SendCommand(128, 8, delay);
	}

	public override KeyValuePair<string, object> Get(string key)
	{
		SendCommand(128, 0, key, out var value);
		return new KeyValuePair<string, object>(key, value);
	}

	public override void Increment(string key, int amount)
	{
		SendCommand(128, 5, key, amount);
	}

	public override void Prepend(string key, object data)
	{
		SendCommand(128, 15, key, data, TimeSpan.Zero, hasExtra: false);
	}

	public override void Replace(string key, object data, TimeSpan expiration)
	{
		SendCommand(128, 3, key, data, expiration, hasExtra: true);
	}

	public override void Set(string key, object data, TimeSpan expiration)
	{
		SendCommand(128, 1, key, data, expiration, hasExtra: true);
	}

	private void SendCommand(byte magic, byte opcode, string key, object data, TimeSpan expiration, bool hasExtra)
	{
		byte[] array = EncodeStoreCommand(magic, opcode, key, data, expiration, hasExtra);
		stream.Write(array, 0, array.Length);
		GetResponse();
	}

	private void SendCommand(byte magic, byte opcode, string key, out string value)
	{
		byte[] array = EncodeGetCommand(magic, opcode, key);
		stream.Write(array, 0, array.Length);
		byte[] response = GetResponse();
		byte[] array2 = new byte[response[4] - 4];
		Array.Copy(response, 28, array2, 0, response[4] - 4);
		value = _encoding.GetString(array2, 0, array2.Length);
	}

	private void SendCommand(byte magic, byte opcode, string key)
	{
		byte[] array = EncodeGetCommand(magic, opcode, key);
		stream.Write(array, 0, array.Length);
		GetResponse();
	}

	private void SendCommand(byte magic, byte opcode, TimeSpan expiration)
	{
		byte[] array = EncodeFlushCommand(magic, opcode, expiration);
		stream.Write(array, 0, array.Length);
		GetResponse();
	}

	private void SendCommand(byte magic, byte opcode, string key, int amount)
	{
		byte[] array = EncodeIncrCommand(magic, opcode, key, amount);
		stream.Write(array, 0, array.Length);
		GetResponse();
	}

	private byte[] GetResponse()
	{
		byte[] array = new byte[24];
		stream.Read(array, 0, array.Length);
		ValidateResponse(array);
		return array;
	}

	private void ValidateResponse(byte[] res)
	{
		ushort num = (ushort)((res[6] << 8) | res[7]);
		if (num != 0)
		{
			ResponseStatus responseStatus = (ResponseStatus)num;
			throw new MemcachedException(responseStatus.ToString());
		}
	}

	private byte[] EncodeStoreCommand(byte magic, byte opcode, string key, object data, TimeSpan expiration, bool hasExtra)
	{
		byte[] bytes = _encoding.GetBytes(key);
		byte[] bytes2 = _encoding.GetBytes(data.ToString());
		MemoryStream memoryStream = new MemoryStream();
		memoryStream.WriteByte(magic);
		memoryStream.WriteByte(opcode);
		WriteToMemoryStream(BitConverter.GetBytes((ushort)bytes.Length), memoryStream);
		memoryStream.WriteByte(8);
		memoryStream.WriteByte(0);
		memoryStream.WriteByte(0);
		memoryStream.WriteByte(0);
		WriteToMemoryStream(BitConverter.GetBytes((uint)(bytes.Length + bytes2.Length + (hasExtra ? 8 : 0))), memoryStream);
		WriteToMemoryStream(BitConverter.GetBytes(0u), memoryStream);
		WriteToMemoryStream(BitConverter.GetBytes((ushort)0), memoryStream);
		if (hasExtra)
		{
			memoryStream.Write(new byte[4], 0, 4);
			WriteToMemoryStream(BitConverter.GetBytes((uint)expiration.TotalSeconds), memoryStream);
		}
		memoryStream.Write(bytes, 0, bytes.Length);
		memoryStream.Write(bytes2, 0, bytes2.Length);
		return memoryStream.ToArray();
	}

	private byte[] EncodeGetCommand(byte magic, byte opcode, string key)
	{
		byte[] bytes = _encoding.GetBytes(key);
		MemoryStream memoryStream = new MemoryStream();
		memoryStream.WriteByte(magic);
		memoryStream.WriteByte(opcode);
		WriteToMemoryStream(BitConverter.GetBytes((ushort)bytes.Length), memoryStream);
		memoryStream.WriteByte(8);
		memoryStream.WriteByte(0);
		memoryStream.WriteByte(0);
		memoryStream.WriteByte(0);
		WriteToMemoryStream(BitConverter.GetBytes((ushort)bytes.Length), memoryStream);
		WriteToMemoryStream(BitConverter.GetBytes(0u), memoryStream);
		WriteToMemoryStream(BitConverter.GetBytes(0u), memoryStream);
		memoryStream.Write(bytes, 0, bytes.Length);
		return memoryStream.ToArray();
	}

	private byte[] EncodeFlushCommand(byte magic, byte opcode, TimeSpan expiration)
	{
		MemoryStream memoryStream = new MemoryStream();
		memoryStream.WriteByte(magic);
		memoryStream.WriteByte(opcode);
		memoryStream.WriteByte(0);
		memoryStream.WriteByte(0);
		memoryStream.WriteByte(4);
		memoryStream.WriteByte(0);
		memoryStream.WriteByte(0);
		memoryStream.WriteByte(0);
		WriteToMemoryStream(BitConverter.GetBytes((ushort)4), memoryStream);
		WriteToMemoryStream(BitConverter.GetBytes(0u), memoryStream);
		WriteToMemoryStream(BitConverter.GetBytes(0u), memoryStream);
		WriteToMemoryStream(BitConverter.GetBytes((uint)expiration.TotalSeconds), memoryStream);
		return memoryStream.ToArray();
	}

	private byte[] EncodeIncrCommand(byte magic, byte opcode, string key, int amount)
	{
		byte[] bytes = _encoding.GetBytes(key);
		MemoryStream memoryStream = new MemoryStream();
		memoryStream.WriteByte(magic);
		memoryStream.WriteByte(opcode);
		WriteToMemoryStream(BitConverter.GetBytes((ushort)bytes.Length), memoryStream);
		memoryStream.WriteByte(20);
		memoryStream.WriteByte(0);
		memoryStream.WriteByte(0);
		memoryStream.WriteByte(0);
		WriteToMemoryStream(BitConverter.GetBytes((ushort)(bytes.Length + 20)), memoryStream);
		WriteToMemoryStream(BitConverter.GetBytes(0u), memoryStream);
		WriteToMemoryStream(BitConverter.GetBytes(0u), memoryStream);
		long num = amount;
		if (opcode == 6)
		{
			num *= -1L;
		}
		WriteToMemoryStream(BitConverter.GetBytes(0L), memoryStream);
		TimeSpan zero = TimeSpan.Zero;
		WriteToMemoryStream(BitConverter.GetBytes((uint)zero.TotalSeconds), memoryStream);
		memoryStream.Write(bytes, 0, bytes.Length);
		return memoryStream.ToArray();
	}

	private void WriteToMemoryStream(byte[] data, MemoryStream ms)
	{
		Array.Reverse((Array)data);
		ms.Write(data, 0, data.Length);
	}
}
