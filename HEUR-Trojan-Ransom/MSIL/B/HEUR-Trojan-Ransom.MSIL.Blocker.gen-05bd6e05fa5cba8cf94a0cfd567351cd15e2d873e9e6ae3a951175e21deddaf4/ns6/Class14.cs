using System;
using System.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ns10;
using ns18;
using ns2;
using ns5;
using ns7;

namespace ns6;

internal class Class14 : Class9
{
	public override void vmethod_0(Class38 class38_0, object? object_0, Class34 class34_0)
	{
		if (object_0 == null)
		{
			class38_0.vmethod_17();
			return;
		}
		DataSet obj = (DataSet)object_0;
		DefaultContractResolver defaultContractResolver = class34_0.ContractResolver as DefaultContractResolver;
		Class15 @class = new Class15();
		class38_0.vmethod_3();
		foreach (DataTable table in obj.Tables)
		{
			class38_0.vmethod_9((defaultContractResolver != null) ? defaultContractResolver.method_4(table.TableName) : table.TableName);
			@class.vmethod_0(class38_0, table, class34_0);
		}
		class38_0.vmethod_4();
	}

	public override object? vmethod_1(Class29 class29_0, Type type_0, object? object_0, Class34 class34_0)
	{
		if (class29_0.TokenType == JsonToken.Null)
		{
			return null;
		}
		DataSet dataSet = ((type_0 == typeof(DataSet)) ? new DataSet() : ((DataSet)Activator.CreateInstance(type_0)));
		Class15 @class = new Class15();
		Class4.smethod_414(class29_0);
		while (class29_0.TokenType == JsonToken.PropertyName)
		{
			DataTable dataTable = dataSet.Tables[(string)class29_0.Value];
			bool num = dataTable != null;
			dataTable = (DataTable)@class.vmethod_1(class29_0, typeof(DataTable), dataTable, class34_0);
			if (!num)
			{
				dataSet.Tables.Add(dataTable);
			}
			Class4.smethod_414(class29_0);
		}
		return dataSet;
	}

	public override bool vmethod_2(Type type_0)
	{
		return typeof(DataSet).IsAssignableFrom(type_0);
	}
}
