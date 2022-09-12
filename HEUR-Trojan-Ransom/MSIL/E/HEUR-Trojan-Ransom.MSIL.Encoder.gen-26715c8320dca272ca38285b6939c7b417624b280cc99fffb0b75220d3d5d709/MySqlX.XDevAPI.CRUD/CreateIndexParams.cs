using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace MySqlX.XDevAPI.CRUD;

internal class CreateIndexParams
{
	internal class IndexField
	{
		internal string Field { get; set; }

		internal string Type { get; set; }

		internal bool? Required { get; set; }

		internal uint? Options { get; set; }

		internal uint? Srid { get; set; }

		internal bool? Array { get; set; }
	}

	private const string FIELDS = "fields";

	private const string FIELD = "field";

	private const string TYPE = "type";

	private const string REQUIRED = "required";

	private const string OPTIONS = "options";

	private const string SRID = "srid";

	private const string ARRAY = "array";

	private string _indexName;

	private string _type;

	private List<IndexField> _fields = new List<IndexField>();

	public string IndexName => _indexName;

	public string Type => _type;

	public List<IndexField> Fields => _fields;

	public CreateIndexParams(string indexName, DbDoc indexDefinition)
	{
		_indexName = indexName;
		if (indexDefinition.values.ContainsKey("type"))
		{
			_type = indexDefinition.values["type"].ToString();
		}
		object[] array = indexDefinition.values["fields"] as object[];
		int num = 0;
		while (true)
		{
			if (num >= array.Length)
			{
				return;
			}
			if (array[num] is Dictionary<string, object> dictionary)
			{
				string field = ((dictionary["field"] is MySqlExpression) ? ((MySqlExpression)dictionary["field"]).value : dictionary["field"].ToString());
				IndexField indexField = new IndexField
				{
					Field = field
				};
				if (dictionary.ContainsKey("type"))
				{
					indexField.Type = dictionary["type"].ToString();
				}
				if (dictionary.ContainsKey("required"))
				{
					indexField.Required = Convert.ToBoolean(dictionary["required"]);
				}
				if (dictionary.ContainsKey("options"))
				{
					indexField.Options = Convert.ToUInt32(dictionary["options"]);
				}
				if (dictionary.ContainsKey("srid"))
				{
					indexField.Srid = Convert.ToUInt32(dictionary["srid"]);
				}
				if (dictionary.ContainsKey("array"))
				{
					if (dictionary["array"] is MySqlExpression || dictionary["array"] == null)
					{
						break;
					}
					indexField.Array = Convert.ToBoolean(dictionary["array"]);
				}
				_fields.Add(indexField);
			}
			num++;
		}
		throw new MySqlException("Index field 'array' member must be boolean.");
	}
}
