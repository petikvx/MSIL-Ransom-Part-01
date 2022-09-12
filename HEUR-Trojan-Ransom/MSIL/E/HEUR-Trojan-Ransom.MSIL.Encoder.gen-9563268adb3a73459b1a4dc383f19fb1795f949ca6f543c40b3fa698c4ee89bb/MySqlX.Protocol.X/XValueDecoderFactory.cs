using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Mysqlx.Resultset;

namespace MySqlX.Protocol.X;

internal class XValueDecoderFactory
{
	public static ValueDecoder GetValueDecoder(Column c, ColumnMetaData.Types.FieldType type)
	{
		return type switch
		{
			ColumnMetaData.Types.FieldType.Sint => new IntegerDecoder(signed: true), 
			ColumnMetaData.Types.FieldType.Uint => new IntegerDecoder(signed: false), 
			ColumnMetaData.Types.FieldType.Double => new FloatDecoder(isFloat: false), 
			ColumnMetaData.Types.FieldType.Float => new FloatDecoder(isFloat: true), 
			ColumnMetaData.Types.FieldType.Bytes => new ByteDecoder(isEnum: false), 
			ColumnMetaData.Types.FieldType.Time => new XTimeDecoder(), 
			ColumnMetaData.Types.FieldType.Datetime => new XDateTimeDecoder(), 
			ColumnMetaData.Types.FieldType.Set => new SetDecoder(), 
			ColumnMetaData.Types.FieldType.Enum => new ByteDecoder(isEnum: true), 
			ColumnMetaData.Types.FieldType.Bit => new BitDecoder(), 
			ColumnMetaData.Types.FieldType.Decimal => new DecimalDecoder(), 
			_ => throw new MySqlException("Unknown field type " + type), 
		};
	}
}
