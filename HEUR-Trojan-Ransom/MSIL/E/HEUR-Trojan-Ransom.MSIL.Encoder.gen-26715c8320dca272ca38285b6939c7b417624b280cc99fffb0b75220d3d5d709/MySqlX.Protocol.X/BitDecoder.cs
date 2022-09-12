using Google.Protobuf;
using MySql.Data.MySqlClient.X.XDevAPI.Common;

namespace MySqlX.Protocol.X;

internal class BitDecoder : ValueDecoder
{
	public override void SetMetadata()
	{
		base.Column.Type = ColumnType.Bit;
		base.Column.ClrType = typeof(ulong);
		ClrValueDecoder = BitValueDecoder;
	}

	private ulong ReadUInt(byte[] bytes)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return new CodedInputStream(bytes).ReadUInt64();
	}

	private object BitValueDecoder(byte[] bytes)
	{
		return ReadUInt(bytes);
	}
}
