using System;
using System.IO;
using System.Text;

namespace VanillaStub.Helpers.Services.StreamLibrary.src;

public class PayloadWriter : IDisposable
{
	public Stream vStream { get; set; }

	public int Length => (int)vStream.Length;

	public PayloadWriter()
	{
		vStream = new MemoryStream();
	}

	public PayloadWriter(Stream stream)
	{
		vStream = stream;
	}

	public void Dispose()
	{
		vStream.Close();
		vStream.Dispose();
		vStream = null;
	}

	public void WriteBytes(byte[] value)
	{
		vStream.Write(value, 0, value.Length);
	}

	public void WriteBytes(byte[] value, int Offset, int Length)
	{
		vStream.Write(value, Offset, Length);
	}

	public void WriteInteger(int value)
	{
		WriteBytes(BitConverter.GetBytes(value));
	}

	public void WriteThreeByteInteger(int value)
	{
		WriteByte((byte)value);
		WriteByte((byte)(value >> 8));
		WriteByte((byte)(value >> 16));
	}

	public void WriteUInteger(uint value)
	{
		WriteBytes(BitConverter.GetBytes(value));
	}

	public void WriteShort(short value)
	{
		WriteBytes(BitConverter.GetBytes(value));
	}

	public void WriteUShort(ushort value)
	{
		WriteBytes(BitConverter.GetBytes(value));
	}

	public void WriteULong(ulong value)
	{
		WriteBytes(BitConverter.GetBytes(value));
	}

	public void WriteByte(byte value)
	{
		vStream.WriteByte(value);
	}

	public void WriteBool(bool value)
	{
		WriteByte((byte)(value ? 1 : 0));
	}

	public void WriteDouble(double value)
	{
		WriteBytes(BitConverter.GetBytes(value));
	}

	public void WriteLong(long value)
	{
		WriteBytes(BitConverter.GetBytes(value));
	}

	public void WriteFloat(float value)
	{
		WriteBytes(BitConverter.GetBytes(value));
	}

	public void WriteDecimal(decimal value)
	{
		new BinaryWriter(vStream).Write(value);
	}

	public void WriteString(string value)
	{
		if (value == null)
		{
			throw new NullReferenceException("value");
		}
		WriteBytes(Encoding.Unicode.GetBytes(value));
		vStream.WriteByte(0);
		vStream.WriteByte(0);
	}
}
