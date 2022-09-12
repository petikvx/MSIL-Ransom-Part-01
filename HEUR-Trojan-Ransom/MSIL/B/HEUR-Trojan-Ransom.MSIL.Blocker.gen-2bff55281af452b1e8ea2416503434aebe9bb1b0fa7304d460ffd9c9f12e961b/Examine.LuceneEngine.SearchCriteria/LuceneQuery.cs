using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using Examine.SearchCriteria;
using Lucene.Net.Search;

namespace Examine.LuceneEngine.SearchCriteria;

public class LuceneQuery : IQuery
{
	private LuceneSearchCriteria search;

	private Occur occurance;

	public BooleanOperation BooleanOperation
	{
		[SecuritySafeCritical]
		get
		{
			return occurance.ToBooleanOperation();
		}
	}

	[SecuritySafeCritical]
	internal LuceneQuery(LuceneSearchCriteria search, Occur occurance)
	{
		this.search = search;
		this.occurance = occurance;
	}

	[SecuritySafeCritical]
	public IBooleanOperation Id(int id)
	{
		return search.IdInternal(id, occurance);
	}

	[SecuritySafeCritical]
	public IBooleanOperation NodeName(string nodeName)
	{
		return search.NodeNameInternal(new ExamineValue((Examineness)Convert.ToInt32(2.0948517463551335 + Math.Tanh(1.5)), nodeName), occurance);
	}

	[SecuritySafeCritical]
	public IBooleanOperation NodeTypeAlias(string nodeTypeAlias)
	{
		return search.NodeTypeAliasInternal(new ExamineValue((Examineness)Convert.ToInt32(2.929262798332297 + Math.Cos(1.5)), nodeTypeAlias), occurance);
	}

	[SecuritySafeCritical]
	public IBooleanOperation ParentId(int id)
	{
		return search.ParentIdInternal(id, occurance);
	}

	[SecuritySafeCritical]
	public IBooleanOperation Field(string fieldName, string fieldValue)
	{
		return search.FieldInternal(fieldName, new ExamineValue((Examineness)Convert.ToInt32(2.5945348918918354 + Math.Log(1.5)), fieldValue), occurance);
	}

	public IBooleanOperation Range(string fieldName, DateTime start, DateTime end)
	{
		return Range(fieldName, start, end, includeLower: true, includeUpper: true);
	}

	public IBooleanOperation Range(string fieldName, DateTime start, DateTime end, bool includeLower, bool includeUpper)
	{
		return Range(fieldName, start, end, includeLower, includeUpper, (DateResolution)Convert.ToInt32(6.141120008059867 - Math.Sin(3.0)));
	}

	public IBooleanOperation Range(string fieldName, DateTime start, DateTime end, bool includeLower, bool includeUpper, DateResolution resolution)
	{
		return search.Range(fieldName, start, end, includeLower, includeUpper);
	}

	public IBooleanOperation Range(string fieldName, int start, int end)
	{
		return Range(fieldName, start, end, includeLower: true, includeUpper: true);
	}

	[SecuritySafeCritical]
	public IBooleanOperation Range(string fieldName, int start, int end, bool includeLower, bool includeUpper)
	{
		return search.RangeInternal(fieldName, start, end, includeLower, includeUpper, occurance);
	}

	public IBooleanOperation Range(string fieldName, double start, double end)
	{
		return Range(fieldName, start, end, includeLower: true, includeUpper: true);
	}

	[SecuritySafeCritical]
	public IBooleanOperation Range(string fieldName, double start, double end, bool includeLower, bool includeUpper)
	{
		return search.RangeInternal(fieldName, start, end, includeLower, includeUpper, occurance);
	}

	public IBooleanOperation Range(string fieldName, float start, float end)
	{
		return Range(fieldName, start, end, includeLower: true, includeUpper: true);
	}

	[SecuritySafeCritical]
	public IBooleanOperation Range(string fieldName, float start, float end, bool includeLower, bool includeUpper)
	{
		return search.RangeInternal(fieldName, start, end, includeLower, includeUpper, occurance);
	}

	public IBooleanOperation Range(string fieldName, long start, long end)
	{
		return Range(fieldName, start, end, includeLower: true, includeUpper: true);
	}

	[SecuritySafeCritical]
	public IBooleanOperation Range(string fieldName, long start, long end, bool includeLower, bool includeUpper)
	{
		return search.RangeInternal(fieldName, start, end, includeLower, includeUpper, occurance);
	}

	public IBooleanOperation Range(string fieldName, string start, string end)
	{
		return Range(fieldName, start, end, includeLower: true, includeUpper: true);
	}

	[SecuritySafeCritical]
	public IBooleanOperation Range(string fieldName, string start, string end, bool includeLower, bool includeUpper)
	{
		return search.RangeInternal(fieldName, start, end, includeLower, includeUpper, occurance);
	}

	[SecuritySafeCritical]
	public IBooleanOperation NodeName(IExamineValue nodeName)
	{
		return search.NodeNameInternal(nodeName, occurance);
	}

	[SecuritySafeCritical]
	public IBooleanOperation NodeTypeAlias(IExamineValue nodeTypeAlias)
	{
		return search.NodeTypeAliasInternal(nodeTypeAlias, occurance);
	}

	[SecuritySafeCritical]
	public IBooleanOperation Field(string fieldName, IExamineValue fieldValue)
	{
		return search.FieldInternal(fieldName, fieldValue, occurance);
	}

	[SecuritySafeCritical]
	public IBooleanOperation GroupedAnd(IEnumerable<string> fields, params string[] query)
	{
		List<IExamineValue> list = new List<IExamineValue>();
		foreach (string value in query)
		{
			list.Add(new ExamineValue((Examineness)Convert.ToInt32(3.4054651081081646 - Math.Log(1.5)), value));
		}
		return search.GroupedAndInternal(fields.ToArray(), list.ToArray(), occurance);
	}

	[SecuritySafeCritical]
	public IBooleanOperation GroupedAnd(IEnumerable<string> fields, params IExamineValue[] query)
	{
		return search.GroupedAndInternal(fields.ToArray(), query, occurance);
	}

	[SecuritySafeCritical]
	public IBooleanOperation GroupedOr(IEnumerable<string> fields, params string[] query)
	{
		List<IExamineValue> list = new List<IExamineValue>();
		foreach (string value in query)
		{
			list.Add(new ExamineValue((Examineness)Convert.ToInt32(4.0 - Math.Floor(1.5)), value));
		}
		return search.GroupedOrInternal(fields.ToArray(), list.ToArray(), occurance);
	}

	[SecuritySafeCritical]
	public IBooleanOperation GroupedOr(IEnumerable<string> fields, params IExamineValue[] query)
	{
		return search.GroupedOrInternal(fields.ToArray(), query, occurance);
	}

	[SecuritySafeCritical]
	public IBooleanOperation GroupedNot(IEnumerable<string> fields, params string[] query)
	{
		List<IExamineValue> list = new List<IExamineValue>();
		foreach (string value in query)
		{
			list.Add(new ExamineValue((Examineness)Convert.ToInt32(5.0 - Math.Ceiling(1.5)), value));
		}
		return search.GroupedNotInternal(fields.ToArray(), list.ToArray());
	}

	[SecuritySafeCritical]
	public IBooleanOperation GroupedNot(IEnumerable<string> fields, params IExamineValue[] query)
	{
		return search.GroupedNotInternal(fields.ToArray(), query);
	}

	[SecuritySafeCritical]
	public IBooleanOperation GroupedFlexible(IEnumerable<string> fields, IEnumerable<BooleanOperation> operations, params string[] query)
	{
		List<IExamineValue> list = new List<IExamineValue>();
		foreach (string value in query)
		{
			list.Add(new ExamineValue((Examineness)Convert.ToInt32(2.0 + Math.Floor(1.5)), value));
		}
		return search.GroupedFlexibleInternal(fields.ToArray(), operations.ToArray(), list.ToArray(), occurance);
	}

	[SecuritySafeCritical]
	public IBooleanOperation GroupedFlexible(IEnumerable<string> fields, IEnumerable<BooleanOperation> operations, params IExamineValue[] query)
	{
		return search.GroupedFlexibleInternal(fields.ToArray(), operations.ToArray(), query, occurance);
	}

	public IBooleanOperation OrderBy(params string[] fieldNames)
	{
		return search.OrderBy(fieldNames);
	}

	public IBooleanOperation OrderByDescending(params string[] fieldNames)
	{
		return search.OrderByDescending(fieldNames);
	}
}
