using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal sealed class InfoCardBinaryReader : BinaryReader
{
	private static readonly char[] s_singleChar = new char[1] { 'a' };

	private int m_charSize;

	public InfoCardBinaryReader(Stream stream, Encoding encoding)
		: base(stream, encoding)
	{
		m_charSize = encoding.GetByteCount(s_singleChar);
	}

	public InfoCardBinaryReader(Stream stream)
		: this(stream, Encoding.Unicode)
	{
	}

	public override int Read()
	{
		EnsureBufferBounds(1L);
		return base.Read();
	}

	public override int Read(byte[] buffer, int index, int count)
	{
		return base.Read(buffer, index, count);
	}

	public override int Read(char[] buffer, int index, int count)
	{
		return base.Read(buffer, index, count);
	}

	public override bool ReadBoolean()
	{
		EnsureBufferBounds(1L);
		return base.ReadBoolean();
	}

	public override byte ReadByte()
	{
		EnsureBufferBounds(1L);
		return base.ReadByte();
	}

	public override byte[] ReadBytes(int count)
	{
		EnsureBufferBounds(count);
		return base.ReadBytes(count);
	}

	public override char ReadChar()
	{
		EnsureBufferBounds(m_charSize);
		return base.ReadChar();
	}

	public override char[] ReadChars(int count)
	{
		EnsureBufferBounds(Convert.ToInt64(m_charSize * count));
		return base.ReadChars(count);
	}

	public override decimal ReadDecimal()
	{
		EnsureBufferBounds(Convert.ToInt64(Marshal.SizeOf(typeof(decimal))));
		return base.ReadDecimal();
	}

	public override double ReadDouble()
	{
		EnsureBufferBounds(8L);
		return base.ReadDouble();
	}

	public override short ReadInt16()
	{
		EnsureBufferBounds(2L);
		return base.ReadInt16();
	}

	public override int ReadInt32()
	{
		EnsureBufferBounds(4L);
		return base.ReadInt32();
	}

	public override long ReadInt64()
	{
		EnsureBufferBounds(8L);
		return base.ReadInt64();
	}

	public override sbyte ReadSByte()
	{
		EnsureBufferBounds(1L);
		return base.ReadSByte();
	}

	public override float ReadSingle()
	{
		EnsureBufferBounds(4L);
		return base.ReadSingle();
	}

	public override string ReadString()
	{
		EnsureBufferBounds(m_charSize * PeekChar() + 4);
		return base.ReadString();
	}

	public override ushort ReadUInt16()
	{
		EnsureBufferBounds(4L);
		return base.ReadUInt16();
	}

	public override uint ReadUInt32()
	{
		EnsureBufferBounds(4L);
		return base.ReadUInt32();
	}

	public override ulong ReadUInt64()
	{
		EnsureBufferBounds(8L);
		return base.ReadUInt64();
	}

	private void EnsureBufferBounds(long offset)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		if ((ulong)(BaseStream.Position + offset) > (ulong)BaseStream.Length)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new InfoCardArgumentException(SR.GetString("InvalidOrCorruptArgumentStream")));
		}
	}
}
