using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security;
using System.Text.RegularExpressions;
using Examine.SearchCriteria;
using Lucene.Net.Analysis;
using Lucene.Net.Documents;
using Lucene.Net.QueryParsers;
using Lucene.Net.Search;
using Lucene.Net.Util;

namespace Examine.LuceneEngine.SearchCriteria;

[DebuggerDisplay("SearchIndexType: {SearchIndexType}, LuceneQuery: {Query}")]
public class LuceneSearchCriteria : IQuery, ISearchCriteria
{
	internal static Regex SortMatchExpression = new Regex("(\\[Type=(?<type>\\w+?)\\])", (RegexOptions)Convert.ToInt32(12.0 - Math.Floor(4.0)));

	internal List<SortField> SortFields = new List<SortField>();

	private readonly Occur _occurance;

	private readonly Version _luceneVersion = Version.LUCENE_29;

	public MultiFieldQueryParser QueryParser
	{
		[SecuritySafeCritical]
		get;
		[SecuritySafeCritical]
		private set;
	}

	public BooleanQuery Query
	{
		[SecuritySafeCritical]
		get;
		[SecuritySafeCritical]
		internal set;
	}

	public string NodeTypeAliasField { get; set; } = "nodeTypeAlias";


	public string NodeNameField { get; set; } = "nodeName";


	public string ParentIdField { get; set; } = "parentID";


	public BooleanOperation BooleanOperation { get; protected set; }

	public string SearchIndexType { get; protected set; }

	public bool IncludeHitCount { get; set; }

	public int TotalHits { get; protected internal set; }

	[SecuritySafeCritical]
	internal LuceneSearchCriteria(string type, Analyzer analyzer, string[] fields, bool allowLeadingWildcards, BooleanOperation occurance)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		Enforcer.ArgumentNotNull(fields, "fields");
		SearchIndexType = type;
		Query = new BooleanQuery();
		BooleanOperation = occurance;
		QueryParser = new MultiFieldQueryParser(_luceneVersion, fields, analyzer);
		((QueryParser)QueryParser).SetAllowLeadingWildcard(allowLeadingWildcards);
		_occurance = occurance.ToLuceneOccurance();
	}

	[SecuritySafeCritical]
	public override string ToString()
	{
		return $"{{ SearchIndexType: {SearchIndexType}, LuceneQuery: {Query} }}";
	}

	private static void ValidateIExamineValue(IExamineValue v)
	{
		if (!(v is ExamineValue))
		{
			throw new ArgumentException("IExamineValue was not created from this provider. Ensure that it is created from the ISearchCriteria this provider exposes");
		}
	}

	[SecuritySafeCritical]
	public IBooleanOperation Id(int id)
	{
		return IdInternal(id, _occurance);
	}

	[SecuritySafeCritical]
	protected internal IBooleanOperation IdInternal(int id, Occur occurance)
	{
		Query.Add(((QueryParser)QueryParser).GetFieldQuery("__NodeId", id.ToString()), occurance);
		return new LuceneBooleanOperation(this);
	}

	public IBooleanOperation NodeName(string nodeName)
	{
		Enforcer.ArgumentNotNull(nodeName, "nodeName");
		return NodeName(new ExamineValue((Examineness)Convert.ToInt32(3.0), nodeName));
	}

	[SecuritySafeCritical]
	public IBooleanOperation NodeName(IExamineValue nodeName)
	{
		Enforcer.ArgumentNotNull(nodeName, "nodeName");
		return NodeNameInternal(nodeName, _occurance);
	}

	[SecuritySafeCritical]
	protected internal IBooleanOperation NodeNameInternal(IExamineValue examineValue, Occur occurance)
	{
		return FieldInternal(NodeNameField, examineValue, occurance);
	}

	public IBooleanOperation NodeTypeAlias(string nodeTypeAlias)
	{
		Enforcer.ArgumentNotNull(nodeTypeAlias, "nodeTypeAlias");
		return NodeTypeAlias(new ExamineValue((Examineness)Convert.ToInt32(3.0), nodeTypeAlias));
	}

	[SecuritySafeCritical]
	public IBooleanOperation NodeTypeAlias(IExamineValue nodeTypeAlias)
	{
		Enforcer.ArgumentNotNull(nodeTypeAlias, "nodeTypeAlias");
		return NodeTypeAliasInternal(nodeTypeAlias, _occurance);
	}

	[SecuritySafeCritical]
	protected internal IBooleanOperation NodeTypeAliasInternal(IExamineValue examineValue, Occur occurance)
	{
		ExamineValue fieldValue = new ExamineValue(examineValue.Examineness, examineValue.Value.ToLower(), examineValue.Level);
		return FieldInternal(NodeTypeAliasField, fieldValue, occurance, useQueryParser: false);
	}

	[SecuritySafeCritical]
	public IBooleanOperation ParentId(int id)
	{
		return ParentIdInternal(id, _occurance);
	}

	[SecuritySafeCritical]
	protected internal IBooleanOperation ParentIdInternal(int id, Occur occurance)
	{
		Query.Add(((QueryParser)QueryParser).GetFieldQuery(ParentIdField, id.ToString()), occurance);
		return new LuceneBooleanOperation(this);
	}

	[SecuritySafeCritical]
	public IBooleanOperation Field(string fieldName, string fieldValue)
	{
		Enforcer.ArgumentNotNull(fieldName, "fieldName");
		Enforcer.ArgumentNotNull(fieldValue, "fieldValue");
		return FieldInternal(fieldName, new ExamineValue((Examineness)Convert.ToInt32(-11.101419947171719 + Math.Tan(1.5)), fieldValue), _occurance);
	}

	[SecuritySafeCritical]
	public IBooleanOperation Field(string fieldName, IExamineValue fieldValue)
	{
		Enforcer.ArgumentNotNull(fieldName, "fieldName");
		Enforcer.ArgumentNotNull(fieldValue, "fieldValue");
		return FieldInternal(fieldName, fieldValue, _occurance);
	}

	[SecuritySafeCritical]
	protected internal Query GetFieldInternalQuery(string fieldName, IExamineValue fieldValue, bool useQueryParser)
	{
		Query val;
		switch (fieldValue.Examineness)
		{
		case Examineness.Fuzzy:
		{
			if (useQueryParser)
			{
				val = ((QueryParser)QueryParser).GetFuzzyQuery(fieldName, fieldValue.Value, fieldValue.Level);
				break;
			}
			string[] array3 = new string[Convert.ToInt32(5.0)];
			array3[0] = fieldName;
			array3[1] = ":";
			array3[Convert.ToInt32(1.4596976941318602 + Math.Cos(1.0))] = fieldValue.Value;
			array3[Convert.ToInt32(3.0)] = "~";
			array3[Convert.ToInt32(4.693147180559945 - Math.Log(2.0))] = Convert.ToInt32(fieldValue.Level).ToString();
			string rawQuery5 = string.Concat(array3);
			val = ParseRawQuery(rawQuery5);
			break;
		}
		case Examineness.SimpleWildcard:
		case Examineness.ComplexWildcard:
		{
			if (useQueryParser)
			{
				val = ((QueryParser)QueryParser).GetWildcardQuery(fieldName, fieldValue.Value);
				break;
			}
			string rawQuery4 = fieldName + ":" + fieldValue.Value;
			val = ParseRawQuery(rawQuery4);
			break;
		}
		default:
		{
			if (useQueryParser)
			{
				val = ((QueryParser)QueryParser).GetFieldQuery(fieldName, fieldValue.Value);
				break;
			}
			string rawQuery2 = fieldName + ":" + fieldValue.Value;
			val = ParseRawQuery(rawQuery2);
			break;
		}
		case Examineness.Escaped:
		{
			string rawQuery = fieldName + ":" + fieldValue.Value;
			val = ParseRawQuery(rawQuery);
			break;
		}
		case Examineness.Boosted:
		{
			if (useQueryParser)
			{
				val = ((QueryParser)QueryParser).GetFieldQuery(fieldName, fieldValue.Value);
				val.SetBoost(fieldValue.Level);
				break;
			}
			string[] array2 = new string[Convert.ToInt32(3.41886116991581 + Math.Sqrt(2.5))];
			array2[0] = fieldName;
			array2[1] = ":\"";
			array2[Convert.ToInt32(2.0)] = fieldValue.Value;
			array2[Convert.ToInt32(5.0 - Math.Round(1.5))] = "\"^";
			array2[Convert.ToInt32(3.090702573174318 + Math.Sin(2.0))] = Convert.ToInt32(fieldValue.Level).ToString();
			string rawQuery3 = string.Concat(array2);
			val = ParseRawQuery(rawQuery3);
			break;
		}
		case Examineness.Proximity:
		{
			string[] array = new string[Convert.ToInt32(5.0)];
			array[0] = fieldName;
			array[1] = ":\"";
			array[Convert.ToInt32(2.8414709848078967 - Math.Sin(1.0))] = fieldValue.Value;
			array[Convert.ToInt32(4.0 - Math.Truncate(1.5))] = "\"~";
			array[Convert.ToInt32(4.0)] = Convert.ToInt32(fieldValue.Level).ToString();
			string text = string.Concat(array);
			val = ((!useQueryParser) ? ParseRawQuery(text) : ((QueryParser)QueryParser).Parse(text));
			break;
		}
		}
		return val;
	}

	[SecuritySafeCritical]
	protected internal Query ParseRawQuery(string rawQuery)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		return new QueryParser(_luceneVersion, "", (Analyzer)new KeywordAnalyzer()).Parse(rawQuery);
	}

	[SecuritySafeCritical]
	protected internal IBooleanOperation FieldInternal(string fieldName, IExamineValue fieldValue, Occur occurance)
	{
		return FieldInternal(fieldName, fieldValue, occurance, useQueryParser: true);
	}

	[SecuritySafeCritical]
	protected internal IBooleanOperation FieldInternal(string fieldName, IExamineValue fieldValue, Occur occurance, bool useQueryParser)
	{
		Query fieldInternalQuery = GetFieldInternalQuery(fieldName, fieldValue, useQueryParser);
		if (fieldInternalQuery != null)
		{
			Query.Add(fieldInternalQuery, occurance);
		}
		return new LuceneBooleanOperation(this);
	}

	public IBooleanOperation Range(string fieldName, DateTime start, DateTime end)
	{
		return Range(fieldName, start, end, includeLower: true, includeUpper: true);
	}

	public IBooleanOperation Range(string fieldName, DateTime start, DateTime end, bool includeLower, bool includeUpper)
	{
		return Range(fieldName, start, end, includeLower: true, includeUpper: true, (DateResolution)Convert.ToInt32(6.0));
	}

	[SecuritySafeCritical]
	public IBooleanOperation Range(string fieldName, DateTime start, DateTime end, bool includeLower, bool includeUpper, DateResolution resolution)
	{
		Resolution val = (Resolution)(resolution switch
		{
			DateResolution.Year => Resolution.YEAR, 
			DateResolution.Month => Resolution.MONTH, 
			DateResolution.Day => Resolution.DAY, 
			DateResolution.Hour => Resolution.HOUR, 
			DateResolution.Minute => Resolution.MINUTE, 
			DateResolution.Second => Resolution.SECOND, 
			_ => Resolution.MILLISECOND, 
		});
		return RangeInternal(fieldName, DateTools.DateToString(start, val), DateTools.DateToString(end, val), includeLower, includeUpper, _occurance);
	}

	public IBooleanOperation Range(string fieldName, int start, int end)
	{
		Enforcer.ArgumentNotNull(fieldName, "fieldName");
		return Range(fieldName, start, end, includeLower: true, includeUpper: true);
	}

	[SecuritySafeCritical]
	public IBooleanOperation Range(string fieldName, int start, int end, bool includeLower, bool includeUpper)
	{
		return RangeInternal(fieldName, start, end, includeLower, includeUpper, _occurance);
	}

	[SecuritySafeCritical]
	protected internal IBooleanOperation RangeInternal(string fieldName, int start, int end, bool includeLower, bool includeUpper, Occur occurance)
	{
		Query.Add((Query)(object)NumericRangeQuery.NewIntRange(fieldName, (ValueType)start, (ValueType)end, includeLower, includeUpper), occurance);
		return new LuceneBooleanOperation(this);
	}

	public IBooleanOperation Range(string fieldName, double lower, double upper)
	{
		return Range(fieldName, lower, upper, includeLower: true, includeUpper: true);
	}

	[SecuritySafeCritical]
	public IBooleanOperation Range(string fieldName, double lower, double upper, bool includeLower, bool includeUpper)
	{
		return RangeInternal(fieldName, lower, upper, includeLower, includeUpper, _occurance);
	}

	[SecuritySafeCritical]
	protected internal IBooleanOperation RangeInternal(string fieldName, double lower, double upper, bool includeLower, bool includeUpper, Occur occurance)
	{
		Query.Add((Query)(object)NumericRangeQuery.NewDoubleRange(fieldName, lower, upper, includeLower, includeUpper), occurance);
		return new LuceneBooleanOperation(this);
	}

	public IBooleanOperation Range(string fieldName, float lower, float upper)
	{
		return Range(fieldName, lower, upper, includeLower: true, includeUpper: true);
	}

	[SecuritySafeCritical]
	public IBooleanOperation Range(string fieldName, float lower, float upper, bool includeLower, bool includeUpper)
	{
		return RangeInternal(fieldName, lower, upper, includeLower, includeUpper, _occurance);
	}

	[SecuritySafeCritical]
	protected internal IBooleanOperation RangeInternal(string fieldName, float lower, float upper, bool includeLower, bool includeUpper, Occur occurance)
	{
		Query.Add((Query)(object)NumericRangeQuery.NewFloatRange(fieldName, lower, upper, includeLower, includeUpper), occurance);
		return new LuceneBooleanOperation(this);
	}

	public IBooleanOperation Range(string fieldName, long lower, long upper)
	{
		return Range(fieldName, lower, upper, includeLower: true, includeUpper: true);
	}

	[SecuritySafeCritical]
	public IBooleanOperation Range(string fieldName, long lower, long upper, bool includeLower, bool includeUpper)
	{
		return RangeInternal(fieldName, lower, upper, includeLower, includeUpper, _occurance);
	}

	[SecuritySafeCritical]
	protected internal IBooleanOperation RangeInternal(string fieldName, long lower, long upper, bool includeLower, bool includeUpper, Occur occurance)
	{
		Query.Add((Query)(object)NumericRangeQuery.NewLongRange(fieldName, (ValueType)lower, (ValueType)upper, includeLower, includeUpper), occurance);
		return new LuceneBooleanOperation(this);
	}

	public IBooleanOperation Range(string fieldName, string start, string end)
	{
		Enforcer.ArgumentNotNull(fieldName, "fieldName");
		Enforcer.ArgumentNotNull(start, "start");
		Enforcer.ArgumentNotNull(end, "end");
		return Range(fieldName, start, end, includeLower: true, includeUpper: true);
	}

	[SecuritySafeCritical]
	public IBooleanOperation Range(string fieldName, string start, string end, bool includeLower, bool includeUpper)
	{
		Enforcer.ArgumentNotNull(fieldName, "fieldName");
		Enforcer.ArgumentNotNull(start, "start");
		Enforcer.ArgumentNotNull(end, "end");
		return RangeInternal(fieldName, start, end, includeLower, includeUpper, _occurance);
	}

	[SecuritySafeCritical]
	protected internal IBooleanOperation RangeInternal(string fieldName, string start, string end, bool includeLower, bool includeUpper, Occur occurance)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		Query.Add((Query)new TermRangeQuery(fieldName, start, end, includeLower, includeUpper), occurance);
		return new LuceneBooleanOperation(this);
	}

	public IBooleanOperation GroupedAnd(IEnumerable<string> fields, params string[] query)
	{
		Enforcer.ArgumentNotNull(fields, "fields");
		Enforcer.ArgumentNotNull(query, "query");
		List<IExamineValue> list = new List<IExamineValue>();
		foreach (string value in query)
		{
			list.Add(new ExamineValue((Examineness)Convert.ToInt32(3.0), value));
		}
		return GroupedAnd(fields.ToArray(), list.ToArray());
	}

	[SecuritySafeCritical]
	public IBooleanOperation GroupedAnd(IEnumerable<string> fields, IExamineValue[] fieldVals)
	{
		Enforcer.ArgumentNotNull(fields, "fields");
		Enforcer.ArgumentNotNull<BooleanQuery>(Query, "fieldVals");
		return GroupedAndInternal(fields.ToArray(), fieldVals.ToArray(), _occurance);
	}

	[SecuritySafeCritical]
	protected internal IBooleanOperation GroupedAndInternal(string[] fields, IExamineValue[] fieldVals, Occur occurance)
	{
		Query.Add((Query)(object)GetMultiFieldQuery(fields, fieldVals, Occur.MUST), occurance);
		return new LuceneBooleanOperation(this);
	}

	public IBooleanOperation GroupedOr(IEnumerable<string> fields, params string[] query)
	{
		Enforcer.ArgumentNotNull(fields, "fields");
		Enforcer.ArgumentNotNull(query, "query");
		List<IExamineValue> list = new List<IExamineValue>();
		foreach (string value in query)
		{
			list.Add(new ExamineValue((Examineness)Convert.ToInt32(4.0 - Math.Floor(1.5)), value));
		}
		return GroupedOr(fields.ToArray(), list.ToArray());
	}

	[SecuritySafeCritical]
	public IBooleanOperation GroupedOr(IEnumerable<string> fields, params IExamineValue[] fieldVals)
	{
		Enforcer.ArgumentNotNull(fields, "fields");
		Enforcer.ArgumentNotNull<BooleanQuery>(Query, "query");
		return GroupedOrInternal(fields.ToArray(), fieldVals, _occurance);
	}

	[SecuritySafeCritical]
	protected internal IBooleanOperation GroupedOrInternal(string[] fields, IExamineValue[] fieldVals, Occur occurance)
	{
		Query.Add((Query)(object)GetMultiFieldQuery(fields, fieldVals, Occur.SHOULD, matchAllCombinations: true), occurance);
		return new LuceneBooleanOperation(this);
	}

	public IBooleanOperation GroupedNot(IEnumerable<string> fields, params string[] query)
	{
		Enforcer.ArgumentNotNull(fields, "fields");
		Enforcer.ArgumentNotNull(query, "query");
		List<IExamineValue> list = new List<IExamineValue>();
		foreach (string value in query)
		{
			list.Add(new ExamineValue((Examineness)Convert.ToInt32(4.0 - Math.Floor(1.5)), value));
		}
		return GroupedNot(fields.ToArray(), list.ToArray());
	}

	[SecuritySafeCritical]
	public IBooleanOperation GroupedNot(IEnumerable<string> fields, params IExamineValue[] query)
	{
		Enforcer.ArgumentNotNull(fields, "fields");
		Enforcer.ArgumentNotNull(query, "query");
		return GroupedNotInternal(fields.ToArray(), query);
	}

	[SecuritySafeCritical]
	protected internal IBooleanOperation GroupedNotInternal(string[] fields, IExamineValue[] fieldVals)
	{
		Query.Add((Query)(object)GetMultiFieldQuery(fields, fieldVals, Occur.MUST_NOT, matchAllCombinations: true), Occur.SHOULD);
		return new LuceneBooleanOperation(this);
	}

	[SecuritySafeCritical]
	protected internal BooleanQuery GetMultiFieldQuery(string[] fields, IExamineValue[] fieldVals, Occur occurance, bool matchAllCombinations = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		BooleanQuery val = new BooleanQuery();
		if (matchAllCombinations)
		{
			foreach (string fieldName in fields)
			{
				foreach (IExamineValue fieldValue in fieldVals)
				{
					Query fieldInternalQuery = GetFieldInternalQuery(fieldName, fieldValue, useQueryParser: true);
					if (fieldInternalQuery != null)
					{
						val.Add(fieldInternalQuery, occurance);
					}
				}
			}
		}
		else
		{
			IExamineValue[] array = new IExamineValue[fields.Length];
			if (fieldVals.Length == 1)
			{
				for (int k = 0; k < array.Length; k++)
				{
					array[k] = fieldVals[0];
				}
			}
			else
			{
				array = fieldVals;
			}
			for (int l = 0; l < fields.Length; l++)
			{
				Query fieldInternalQuery2 = GetFieldInternalQuery(fields[l], array[l], useQueryParser: true);
				if (fieldInternalQuery2 != null)
				{
					val.Add(fieldInternalQuery2, occurance);
				}
			}
		}
		return val;
	}

	public IBooleanOperation GroupedFlexible(IEnumerable<string> fields, IEnumerable<BooleanOperation> operations, params string[] query)
	{
		Enforcer.ArgumentNotNull(fields, "fields");
		Enforcer.ArgumentNotNull(query, "query");
		Enforcer.ArgumentNotNull(operations, "operations");
		List<IExamineValue> list = new List<IExamineValue>();
		foreach (string value in query)
		{
			list.Add(new ExamineValue((Examineness)Convert.ToInt32(5.0 - Math.Ceiling(1.5)), value));
		}
		return GroupedFlexible(fields.ToArray(), operations.ToArray(), list.ToArray());
	}

	[SecuritySafeCritical]
	public IBooleanOperation GroupedFlexible(IEnumerable<string> fields, IEnumerable<BooleanOperation> operations, params IExamineValue[] fieldVals)
	{
		Enforcer.ArgumentNotNull(fields, "fields");
		Enforcer.ArgumentNotNull<BooleanQuery>(Query, "query");
		Enforcer.ArgumentNotNull(operations, "operations");
		return GroupedFlexibleInternal(fields.ToArray(), operations.ToArray(), fieldVals, _occurance);
	}

	[SecuritySafeCritical]
	protected internal IBooleanOperation GroupedFlexibleInternal(string[] fields, BooleanOperation[] operations, IExamineValue[] fieldVals, Occur occurance)
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		Occur[] array = (Occur[])(object)new Occur[operations.Count()];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = operations.ElementAt(i).ToLuceneOccurance();
		}
		IExamineValue[] array2 = new IExamineValue[fields.Length];
		if (fieldVals.Length == 1)
		{
			for (int j = 0; j < array2.Length; j++)
			{
				array2[j] = fieldVals[0];
			}
		}
		else
		{
			array2 = fieldVals;
		}
		BooleanQuery val = new BooleanQuery();
		for (int k = 0; k < fields.Length; k++)
		{
			Query fieldInternalQuery = GetFieldInternalQuery(fields[k], array2[k], useQueryParser: true);
			if (fieldInternalQuery != null)
			{
				val.Add(fieldInternalQuery, array[k]);
			}
		}
		Query.Add((Query)(object)val, occurance);
		return new LuceneBooleanOperation(this);
	}

	[SecuritySafeCritical]
	public ISearchCriteria RawQuery(string query)
	{
		Query.Add(((QueryParser)QueryParser).Parse(query), _occurance);
		return this;
	}

	[SecuritySafeCritical]
	public IBooleanOperation LuceneQuery(Query query)
	{
		Query.Add(query, _occurance);
		return new LuceneBooleanOperation(this);
	}

	public IBooleanOperation OrderBy(params string[] fieldNames)
	{
		Enforcer.ArgumentNotNull(fieldNames, "fieldNames");
		return OrderByInternal(descending: false, fieldNames);
	}

	public IBooleanOperation OrderByDescending(params string[] fieldNames)
	{
		Enforcer.ArgumentNotNull(fieldNames, "fieldNames");
		return OrderByInternal(descending: true, fieldNames);
	}

	[SecuritySafeCritical]
	protected internal IBooleanOperation OrderByInternal(bool descending, params string[] fieldNames)
	{
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected O, but got Unknown
		string text;
		int num;
		for (int i = 0; i < fieldNames.Length; SortFields.Add(new SortField("__Sort_" + text, num, descending)), i++)
		{
			text = fieldNames[i];
			num = Convert.ToInt32(4.224744871391589 - Math.Sqrt(1.5));
			Match match = SortMatchExpression.Match(text);
			if (!match.Success || match.Groups["type"] == null)
			{
				continue;
			}
			string text2 = match.Groups["type"].Value.ToUpper();
			uint num2 = _003CPrivateImplementationDetails_003E.ComputeStringHash(text2);
			if (num2 > 2203911150u)
			{
			}
			if (num2 <= (uint)Convert.ToInt32(790486984.7950126 - Math.Log(395243482.5)))
			{
				if (num2 == 225828767)
				{
					goto IL_017b;
				}
				if (num2 == (uint)Convert.ToInt32(853698319.0 - Math.Round(284566106.5)))
				{
					if (text2 == "SHORT")
					{
					}
					goto IL_016d;
				}
				if (num2 == (uint)Convert.ToInt32(790486965.0) && text2 == "DOC")
				{
					goto IL_0199;
				}
			}
			else if (num2 != (uint)Convert.ToInt32(1420283389.2660902 + Math.Sqrt(710155019.0)))
			{
				if (num2 != (uint)Convert.ToInt32(1971559926.74507 + Math.Tan(985779962.5)))
				{
				}
				if (num2 == (uint)Convert.ToInt32(-2091056146.0))
				{
					goto IL_016d;
				}
			}
			else if (text2 == "AUTO")
			{
				goto IL_01ae;
			}
			goto IL_024f;
			IL_017b:
			if (text2 == "BYTE")
			{
			}
			if (text2 == "STRING_VAL")
			{
			}
			num = 0;
			goto IL_0199;
			IL_024f:
			text = text.Substring(0, match.Index);
			continue;
			IL_01ae:
			num = Convert.ToInt32(1.0 + Math.Round(1.0));
			num = Convert.ToInt32(2.0025050133959454 + Math.Sin(1.5));
			num = Convert.ToInt32(3.090702573174318 + Math.Sin(2.0));
			num = Convert.ToInt32(5.0);
			num = Convert.ToInt32(6.989992496600445 + Math.Cos(3.0));
			num = Convert.ToInt32(6.001822102388801 + Math.Tanh(3.5));
			goto IL_024f;
			IL_0199:
			num = 1;
			goto IL_01ae;
			IL_016d:
			if (!(text2 == "CUSTOM"))
			{
			}
			goto IL_017b;
		}
		return new LuceneBooleanOperation(this);
	}
}
