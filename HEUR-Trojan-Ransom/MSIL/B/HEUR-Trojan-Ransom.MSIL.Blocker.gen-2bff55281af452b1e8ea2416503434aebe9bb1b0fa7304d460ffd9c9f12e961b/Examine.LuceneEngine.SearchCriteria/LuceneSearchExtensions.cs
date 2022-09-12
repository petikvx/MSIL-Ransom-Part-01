using System;
using System.Linq;
using System.Security;
using Examine.SearchCriteria;
using Lucene.Net.QueryParsers;
using Lucene.Net.Search;

namespace Examine.LuceneEngine.SearchCriteria;

public static class LuceneSearchExtensions
{
	public static IBooleanOperation OrderBy(this IQuery qry, params SortableField[] fields)
	{
		return qry.OrderBy(fields.Select((SortableField x) => x.FieldName + "[Type=" + x.SortType.ToString().ToUpper() + "]").ToArray());
	}

	public static IBooleanOperation OrderByDescending(this IQuery qry, params SortableField[] fields)
	{
		return qry.OrderByDescending(fields.Select((SortableField x) => x.FieldName + "[Type=" + x.SortType.ToString().ToUpper() + "]").ToArray());
	}

	public static IExamineValue SingleCharacterWildcard(this string s)
	{
		if (string.IsNullOrEmpty(s))
		{
			throw new ArgumentException("Supplied string is null or empty.", "s");
		}
		return new ExamineValue(Examineness.SimpleWildcard, s + "?");
	}

	public static IExamineValue MultipleCharacterWildcard(this string s)
	{
		if (string.IsNullOrEmpty(s))
		{
			throw new ArgumentException("Supplied string is null or empty.", "s");
		}
		return new ExamineValue((Examineness)Convert.ToInt32(2.761594155955765 - Math.Tanh(1.0)), s + "*");
	}

	public static IExamineValue Fuzzy(this string s)
	{
		return s.Fuzzy(0.5f);
	}

	public static IExamineValue Fuzzy(this string s, float fuzzieness)
	{
		if (string.IsNullOrEmpty(s))
		{
			throw new ArgumentException("Supplied string is null or empty.", "s");
		}
		return new ExamineValue(Examineness.Fuzzy, s, fuzzieness);
	}

	public static IExamineValue Boost(this string s, float boost)
	{
		if (string.IsNullOrEmpty(s))
		{
			throw new ArgumentException("Supplied string is null or empty.", "s");
		}
		return new ExamineValue((Examineness)Convert.ToInt32(5.598472144103956 - Math.Sin(2.5)), s, boost);
	}

	public static IExamineValue Proximity(this string s, int proximity)
	{
		if (string.IsNullOrEmpty(s))
		{
			throw new ArgumentException("Supplied string is null or empty.", "s");
		}
		return new ExamineValue((Examineness)Convert.ToInt32(4.90138771133189 + Math.Log(3.0)), s, Convert.ToSingle(proximity));
	}

	[SecuritySafeCritical]
	public static IExamineValue Escape(this string s)
	{
		if (string.IsNullOrEmpty(s))
		{
			throw new ArgumentException("Supplied string is null or empty.", "s");
		}
		return new ExamineValue((Examineness)Convert.ToInt32(2.0 + Math.Abs(2.0)), QueryParser.Escape(s));
	}

	[SecuritySafeCritical]
	public static Occur ToLuceneOccurance(this BooleanOperation o)
	{
		return (Occur)(o switch
		{
			BooleanOperation.And => Occur.MUST, 
			BooleanOperation.Not => Occur.MUST_NOT, 
			_ => Occur.SHOULD, 
		});
	}

	[SecuritySafeCritical]
	public static BooleanOperation ToBooleanOperation(this Occur o)
	{
		if (o == Occur.MUST)
		{
			return BooleanOperation.And;
		}
		if (o == Occur.MUST_NOT)
		{
			return (BooleanOperation)Convert.ToInt32(0.4425922753450977 + Math.Tan(1.0));
		}
		return BooleanOperation.Or;
	}
}
