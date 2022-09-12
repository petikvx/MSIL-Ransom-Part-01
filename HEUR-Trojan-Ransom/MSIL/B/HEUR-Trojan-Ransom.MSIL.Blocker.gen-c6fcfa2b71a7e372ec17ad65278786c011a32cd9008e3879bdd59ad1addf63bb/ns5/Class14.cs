using System;
using System.Data;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ns1;
using ns13;
using ns17;
using ns3;
using ns9;

namespace ns5;

internal class Class14 : Class8
{
	public override void vmethod_0(Class37 class37_0, object? object_0, Class33 class33_0)
	{
		if (object_0 == null)
		{
			class37_0.vmethod_17();
			return;
		}
		DataTable obj = (DataTable)object_0;
		DefaultContractResolver defaultContractResolver = class33_0.ContractResolver as DefaultContractResolver;
		class37_0.vmethod_5();
		foreach (DataRow row in obj.Rows)
		{
			class37_0.vmethod_3();
			foreach (DataColumn column in row.Table.Columns)
			{
				object obj2 = row[column];
				if (class33_0.NullValueHandling != Enum12.const_1 || (obj2 != null && obj2 != DBNull.Value))
				{
					class37_0.vmethod_9((defaultContractResolver != null) ? defaultContractResolver.method_4(column.ColumnName) : column.ColumnName);
					Class131.smethod_436(class33_0, class37_0, obj2);
				}
			}
			class37_0.vmethod_4();
		}
		class37_0.vmethod_6();
	}

	public override object? vmethod_1(Class28 class28_0, Type type_0, object? object_0, Class33 class33_0)
	{
		if (class28_0.TokenType == JsonToken.Null)
		{
			return null;
		}
		DataTable dataTable = object_0 as DataTable;
		if (dataTable == null)
		{
			dataTable = ((type_0 == typeof(DataTable)) ? new DataTable() : ((DataTable)Activator.CreateInstance(type_0)));
		}
		if (class28_0.TokenType == JsonToken.PropertyName)
		{
			dataTable.TableName = (string)class28_0.Value;
			Class131.smethod_167(class28_0);
			if (class28_0.TokenType == JsonToken.Null)
			{
				return dataTable;
			}
		}
		if (class28_0.TokenType != JsonToken.StartArray)
		{
			throw Class131.smethod_38(class28_0, "Unexpected JSON token when reading DataTable. Expected StartArray, got {0}.".smethod_1(CultureInfo.InvariantCulture, class28_0.TokenType));
		}
		Class131.smethod_167(class28_0);
		while (class28_0.TokenType != JsonToken.EndArray)
		{
			Class131.smethod_70(class28_0, dataTable, class33_0);
			Class131.smethod_167(class28_0);
		}
		return dataTable;
	}

	public override bool vmethod_2(Type type_0)
	{
		return typeof(DataTable).IsAssignableFrom(type_0);
	}
}
