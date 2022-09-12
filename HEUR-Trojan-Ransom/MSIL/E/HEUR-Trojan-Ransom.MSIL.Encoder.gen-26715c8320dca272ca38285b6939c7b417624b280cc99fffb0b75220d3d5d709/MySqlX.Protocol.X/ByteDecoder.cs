using System;
using System.Text;
using MySql.Data.Common;
using MySql.Data.MySqlClient;
using MySql.Data.MySqlClient.X.XDevAPI.Common;

namespace MySqlX.Protocol.X;

internal class ByteDecoder : ValueDecoder
{
	private Encoding _encoding;

	private bool _isEnum;

	public ByteDecoder(bool isEnum)
	{
		_isEnum = isEnum;
	}

	public override void SetMetadata()
	{
		base.Column.Type = GetDbType();
		base.Column.ClrType = GetClrType(base.Column.Type);
		base.Column.IsPadded = (base.Flags & 1) != 0;
		ClrValueDecoder = GetClrValueDecoder();
	}

	private ColumnType GetDbType()
	{
		if (_isEnum)
		{
			return ColumnType.Enum;
		}
		if (base.ContentType == 1)
		{
			return ColumnType.Geometry;
		}
		if (base.ContentType == 2)
		{
			return ColumnType.Json;
		}
		if ((base.Column.CollationName ?? "").Equals("binary", StringComparison.OrdinalIgnoreCase))
		{
			return ColumnType.Bytes;
		}
		return ColumnType.String;
	}

	private Type GetClrType(ColumnType dbType)
	{
		if (dbType != ColumnType.String && dbType != ColumnType.Json && dbType != ColumnType.Enum)
		{
			return typeof(byte[]);
		}
		return typeof(string);
	}

	private ClrDecoderDelegate GetClrValueDecoder()
	{
		if (base.Column.ClrType == typeof(string))
		{
			return StringValueDecoder;
		}
		return ByteValueDecoder;
	}

	private object StringValueDecoder(byte[] bytes)
	{
		if (bytes.Length == 0)
		{
			return null;
		}
		if (_encoding == null)
		{
			string charSetName = base.Column.CharacterSetName ?? string.Empty;
			_encoding = CharSetMap.GetEncoding(default(DBVersion), charSetName);
		}
		return _encoding.GetString(bytes, 0, bytes.Length - 1);
	}

	private object ByteValueDecoder(byte[] bytes)
	{
		byte[] array = new byte[bytes.Length - 1];
		Array.Copy(bytes, array, array.Length);
		return array;
	}
}
