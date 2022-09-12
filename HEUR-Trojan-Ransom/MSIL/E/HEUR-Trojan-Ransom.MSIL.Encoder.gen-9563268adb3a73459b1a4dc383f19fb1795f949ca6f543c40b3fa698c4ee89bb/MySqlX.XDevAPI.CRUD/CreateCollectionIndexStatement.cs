using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data;
using MySqlX.XDevAPI.Common;

namespace MySqlX.XDevAPI.CRUD;

public class CreateCollectionIndexStatement : CrudStatement<Result>
{
	internal CreateIndexParams createIndexParams;

	internal CreateCollectionIndexStatement(Collection collection, string indexName, DbDoc indexDefinition)
		: base(collection)
	{
		string[] array = new string[2] { "fields", "type" };
		string[] array2 = new string[6] { "field", "type", "required", "options", "srid", "array" };
		if (!indexDefinition.values.ContainsKey(array[0]))
		{
			throw new FormatException(string.Format(ResourcesX.MandatoryFieldNotFound, array[0]));
		}
		foreach (KeyValuePair<string, object> value in indexDefinition.values)
		{
			if (!array.Contains(value.Key))
			{
				throw new FormatException(string.Format(ResourcesX.UnexpectedField, value.Key));
			}
		}
		object[] array3 = indexDefinition.values[array[0]] as object[];
		for (int i = 0; i < array3.Length; i++)
		{
			Dictionary<string, object> obj = array3[i] as Dictionary<string, object>;
			if (obj.ContainsKey(array2[0]))
			{
				if (obj.ContainsKey(array2[1]))
				{
					foreach (KeyValuePair<string, object> item in obj)
					{
						if (!array2.Contains(item.Key))
						{
							throw new FormatException(string.Format(ResourcesX.UnexpectedField, item.Key));
						}
					}
					continue;
				}
				throw new FormatException(string.Format(ResourcesX.MandatoryFieldNotFound, array2[1]));
			}
			throw new FormatException(string.Format(ResourcesX.MandatoryFieldNotFound, array2[0]));
		}
		createIndexParams = new CreateIndexParams(indexName, indexDefinition);
	}

	public override Result Execute()
	{
		ValidateOpenSession();
		return base.Session.XSession.CreateCollectionIndex(this);
	}
}
