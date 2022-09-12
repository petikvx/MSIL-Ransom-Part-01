using System.Text;
using MySql.Data;
using MySql.Data.Common;
using MySql.Data.MySqlClient;
using MySql.Data.MySqlClient.X.XDevAPI.Common;

namespace MySqlX.Protocol.X;

internal class SetDecoder : ValueDecoder
{
	private Encoding _encoding;

	public override void SetMetadata()
	{
		base.Column.Type = ColumnType.Set;
		base.Column.ClrType = typeof(string);
		ClrValueDecoder = DecodeValue;
		string charSetName = base.Column.CollationName.Split(new char[1] { '_' })[0];
		_encoding = CharSetMap.GetEncoding(default(DBVersion), charSetName);
	}

	private object DecodeValue(byte[] bytes)
	{
		if (bytes != null && bytes.Length != 0)
		{
			if (bytes.Length == 1 && bytes[0] == 0)
			{
				return string.Empty;
			}
			if (bytes.Length == 1 && bytes[0] == 1)
			{
				return string.Empty;
			}
			StringBuilder stringBuilder = new StringBuilder();
			string value = "";
			int num = bytes.Length;
			int num2 = 0;
			while (true)
			{
				if (num2 < num - 1)
				{
					stringBuilder.Append(value);
					int num3 = bytes[num2++];
					if (num2 + num3 > bytes.Length)
					{
						break;
					}
					stringBuilder.Append(_encoding.GetString(bytes, num2, num3));
					num2 += num3;
					value = ",";
					continue;
				}
				return stringBuilder.ToString();
			}
			throw new MySqlException(ResourcesX.UnexpectedEndOfPacketFound);
		}
		return null;
	}
}
