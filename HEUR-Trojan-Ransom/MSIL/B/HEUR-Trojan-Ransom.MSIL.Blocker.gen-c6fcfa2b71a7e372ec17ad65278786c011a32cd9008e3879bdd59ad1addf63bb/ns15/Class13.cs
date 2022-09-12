using System;
using System.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ns1;
using ns13;
using ns3;
using ns5;
using ns9;

namespace ns15;

internal class Class13 : Class8
{
	public override void vmethod_0(Class37 class37_0, object? object_0, Class33 class33_0)
	{
		if (object_0 == null)
		{
			class37_0.vmethod_17();
			return;
		}
		DataSet obj = (DataSet)object_0;
		DefaultContractResolver defaultContractResolver = class33_0.ContractResolver as DefaultContractResolver;
		Class14 @class = new Class14();
		class37_0.vmethod_3();
		foreach (DataTable table in obj.Tables)
		{
			class37_0.vmethod_9((defaultContractResolver != null) ? defaultContractResolver.method_4(table.TableName) : table.TableName);
			@class.vmethod_0(class37_0, table, class33_0);
		}
		class37_0.vmethod_4();
	}

	public override object? vmethod_1(Class28 class28_0, Type type_0, object? object_0, Class33 class33_0)
	{
		if (class28_0.TokenType == JsonToken.Null)
		{
			return null;
		}
		DataSet dataSet = ((type_0 == typeof(DataSet)) ? new DataSet() : ((DataSet)Activator.CreateInstance(type_0)));
		Class14 @class = new Class14();
		Class131.smethod_167(class28_0);
		while (class28_0.TokenType == JsonToken.PropertyName)
		{
			DataTable dataTable = dataSet.Tables[(string)class28_0.Value];
			bool num = dataTable != null;
			dataTable = (DataTable)@class.vmethod_1(class28_0, typeof(DataTable), dataTable, class33_0);
			if (!num)
			{
				dataSet.Tables.Add(dataTable);
			}
			Class131.smethod_167(class28_0);
		}
		return dataSet;
	}

	public override bool vmethod_2(Type type_0)
	{
		return typeof(DataSet).IsAssignableFrom(type_0);
	}
}
