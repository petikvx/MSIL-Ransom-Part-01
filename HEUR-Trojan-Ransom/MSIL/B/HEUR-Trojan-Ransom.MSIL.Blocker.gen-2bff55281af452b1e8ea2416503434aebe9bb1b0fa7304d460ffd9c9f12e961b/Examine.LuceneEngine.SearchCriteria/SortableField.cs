using System;

namespace Examine.LuceneEngine.SearchCriteria;

public class SortableField
{
	public string FieldName { get; private set; }

	public SortType SortType { get; private set; }

	public SortableField(string fieldName)
	{
		FieldName = fieldName;
		SortType = (SortType)Convert.ToInt32(2.0);
	}

	public SortableField(string fieldName, SortType sortType)
	{
		FieldName = fieldName;
		SortType = sortType;
	}
}
