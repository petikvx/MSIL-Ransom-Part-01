using System;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Globalization;
using System.Reflection;

namespace MySql.Data.MySqlClient;

internal class MySqlParameterConverter : TypeConverter
{
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
	{
		if (destinationType == typeof(InstanceDescriptor))
		{
			return true;
		}
		return base.CanConvertTo(context, destinationType);
	}

	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		if (destinationType == typeof(InstanceDescriptor))
		{
			ConstructorInfo? constructor = typeof(MySqlParameter).GetConstructor(new Type[9]
			{
				typeof(string),
				typeof(MySqlDbType),
				typeof(int),
				typeof(ParameterDirection),
				typeof(bool),
				typeof(byte),
				typeof(byte),
				typeof(string),
				typeof(object)
			});
			MySqlParameter mySqlParameter = (MySqlParameter)value;
			return new InstanceDescriptor(constructor, new object[9] { mySqlParameter.ParameterName, mySqlParameter.DbType, mySqlParameter.Size, mySqlParameter.Direction, mySqlParameter.IsNullable, mySqlParameter.Precision, mySqlParameter.Scale, mySqlParameter.SourceColumn, mySqlParameter.Value });
		}
		return base.ConvertTo(context, culture, value, destinationType);
	}
}
