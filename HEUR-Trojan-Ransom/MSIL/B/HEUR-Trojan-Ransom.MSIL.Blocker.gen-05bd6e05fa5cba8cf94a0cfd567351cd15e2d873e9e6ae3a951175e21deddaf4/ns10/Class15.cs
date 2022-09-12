using System;
using System.Data;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ns17;
using ns18;
using ns2;
using ns5;
using ns7;
using ns9;

namespace ns10;

internal class Class15 : Class9
{
	public override void vmethod_0(Class38 class38_0, object? object_0, Class34 class34_0)
	{
		if (object_0 == null)
		{
			class38_0.vmethod_17();
			return;
		}
		DataTable obj = (DataTable)object_0;
		DefaultContractResolver defaultContractResolver = class34_0.ContractResolver as DefaultContractResolver;
		class38_0.vmethod_5();
		foreach (DataRow row in obj.Rows)
		{
			class38_0.vmethod_3();
			foreach (DataColumn column in row.Table.Columns)
			{
				object obj2 = row[column];
				if (class34_0.NullValueHandling != Enum12.const_1 || (obj2 != null && obj2 != DBNull.Value))
				{
					class38_0.vmethod_9((defaultContractResolver != null) ? defaultContractResolver.method_4(column.ColumnName) : column.ColumnName);
					Class4.smethod_223(class34_0, class38_0, obj2);
				}
			}
			class38_0.vmethod_4();
		}
		class38_0.vmethod_6();
	}

	public override object? vmethod_1(Class29 class29_0, Type type_0, object? object_0, Class34 class34_0)
	{
		if (class29_0.TokenType == JsonToken.Null)
		{
			return null;
		}
		DataTable dataTable = object_0 as DataTable;
		if (dataTable == null)
		{
			dataTable = ((type_0 == typeof(DataTable)) ? new DataTable() : ((DataTable)Activator.CreateInstance(type_0)));
		}
		if (class29_0.TokenType == JsonToken.PropertyName)
		{
			dataTable.TableName = (string)class29_0.Value;
			Class4.smethod_414(class29_0);
			if (class29_0.TokenType == JsonToken.Null)
			{
				return dataTable;
			}
		}
		if (class29_0.TokenType != JsonToken.StartArray)
		{
			throw Class4.smethod_777(class29_0, "Unexpected JSON token when reading DataTable. Expected StartArray, got {0}.".smethod_1(CultureInfo.InvariantCulture, class29_0.TokenType));
		}
		Class4.smethod_414(class29_0);
		while (class29_0.TokenType != JsonToken.EndArray)
		{
			Class4.smethod_643(class29_0, dataTable, class34_0);
			Class4.smethod_414(class29_0);
		}
		return dataTable;
	}

	public override bool vmethod_2(Type type_0)
	{
		return typeof(DataTable).IsAssignableFrom(type_0);
	}
}
