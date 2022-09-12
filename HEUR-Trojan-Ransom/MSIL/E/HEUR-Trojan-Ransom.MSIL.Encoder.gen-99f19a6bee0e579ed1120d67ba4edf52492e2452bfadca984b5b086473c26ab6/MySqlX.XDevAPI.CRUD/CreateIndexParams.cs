using System;
using System.Collections.Generic;

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
	}

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
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] is Dictionary<string, object> dictionary)
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
				_fields.Add(indexField);
			}
		}
	}
}
