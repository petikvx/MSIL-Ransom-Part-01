using System;
using Google.Protobuf;
using MySql.Data.MySqlClient.X.XDevAPI.Common;

namespace MySqlX.Protocol.X;

internal class IntegerDecoder : ValueDecoder
{
	private bool _signed;

	public IntegerDecoder(bool signed)
	{
		_signed = signed;
	}

	public override void SetMetadata()
	{
		base.Column.Type = GetDbType();
		base.Column.IsNumberSigned = _signed;
		base.Column.ClrType = (_signed ? GetSignedClrType() : GetUnsignedClrType());
		ClrValueDecoder = (_signed ? GetSignedValueDecoder() : GetUnsignedValueDecoder());
		base.Column.IsPadded = !_signed && (base.Flags & 1) != 0;
	}

	private ColumnType GetDbType()
	{
		switch ((int)base.Column.Length + ((!_signed) ? 1 : 0))
		{
		case 0:
		case 1:
		case 2:
		case 3:
		case 4:
			return ColumnType.Tinyint;
		case 5:
		case 6:
			return ColumnType.Smallint;
		case 7:
		case 8:
		case 9:
			return ColumnType.Mediumint;
		case 10:
		case 11:
			return ColumnType.Int;
		default:
			return ColumnType.Bigint;
		}
	}

	private Type GetSignedClrType()
	{
		switch (base.Column.Length)
		{
		case 0u:
		case 1u:
		case 2u:
		case 3u:
		case 4u:
			return typeof(sbyte);
		case 5u:
		case 6u:
			return typeof(short);
		case 7u:
		case 8u:
		case 9u:
			return typeof(int);
		case 10u:
		case 11u:
			return typeof(int);
		default:
			return typeof(long);
		}
	}

	private Type GetUnsignedClrType()
	{
		switch (base.Column.Length)
		{
		case 0u:
		case 1u:
		case 2u:
		case 3u:
			return typeof(byte);
		case 4u:
		case 5u:
			return typeof(ushort);
		case 6u:
		case 7u:
		case 8u:
			return typeof(uint);
		case 9u:
		case 10u:
			return typeof(uint);
		default:
			return typeof(ulong);
		}
	}

	private ClrDecoderDelegate GetSignedValueDecoder()
	{
		switch (base.Column.Length)
		{
		case 0u:
		case 1u:
		case 2u:
		case 3u:
		case 4u:
			return SByteValueDecoder;
		case 5u:
		case 6u:
			return Int16ValueDecoder;
		case 7u:
		case 8u:
		case 9u:
			return Int32ValueDecoder;
		case 10u:
		case 11u:
			return Int32ValueDecoder;
		default:
			return Int64ValueDecoder;
		}
	}

	private ClrDecoderDelegate GetUnsignedValueDecoder()
	{
		switch (base.Column.Length)
		{
		case 0u:
		case 1u:
		case 2u:
		case 3u:
			return ByteValueDecoder;
		case 4u:
		case 5u:
			return UInt16ValueDecoder;
		case 6u:
		case 7u:
		case 8u:
			return UInt32ValueDecoder;
		case 9u:
		case 10u:
			return UInt32ValueDecoder;
		default:
			return UInt64ValueDecoder;
		}
	}

	private long ReadInt(byte[] bytes)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return new CodedInputStream(bytes).ReadSInt64();
	}

	private ulong ReadUInt(byte[] bytes)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return new CodedInputStream(bytes).ReadUInt64();
	}

	public object SByteValueDecoder(byte[] bytes)
	{
		return (sbyte)ReadInt(bytes);
	}

	public object Int16ValueDecoder(byte[] bytes)
	{
		return (short)ReadInt(bytes);
	}

	public object Int32ValueDecoder(byte[] bytes)
	{
		return (int)ReadInt(bytes);
	}

	public object Int64ValueDecoder(byte[] bytes)
	{
		return ReadInt(bytes);
	}

	public object ByteValueDecoder(byte[] bytes)
	{
		return (byte)ReadUInt(bytes);
	}

	public object UInt16ValueDecoder(byte[] bytes)
	{
		return (ushort)ReadUInt(bytes);
	}

	public object UInt32ValueDecoder(byte[] bytes)
	{
		return (uint)ReadUInt(bytes);
	}

	public object UInt64ValueDecoder(byte[] bytes)
	{
		return ReadUInt(bytes);
	}
}
