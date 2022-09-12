using Google.Protobuf;
using MySql.Data.MySqlClient.X.XDevAPI.Common;

namespace MySqlX.Protocol.X;

internal class FloatDecoder : ValueDecoder
{
	private bool _float;

	public FloatDecoder(bool isFloat)
	{
		_float = isFloat;
	}

	public override void SetMetadata()
	{
		base.Column.Type = (_float ? ColumnType.Float : ColumnType.Double);
		base.Column.ClrType = (_float ? typeof(float) : typeof(double));
		ClrValueDecoder = FloatValueDecoder;
		if (!_float)
		{
			ClrValueDecoder = DoubleValueDecoder;
		}
	}

	private object FloatValueDecoder(byte[] bytes)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return new CodedInputStream(bytes).ReadFloat();
	}

	private object DoubleValueDecoder(byte[] bytes)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return new CodedInputStream(bytes).ReadDouble();
	}
}
