using System;
using System.Collections.Generic;

namespace Examine.SearchCriteria;

public interface IQuery
{
	BooleanOperation BooleanOperation { get; }

	IBooleanOperation Id(int id);

	IBooleanOperation NodeName(string nodeName);

	IBooleanOperation NodeName(IExamineValue nodeName);

	IBooleanOperation NodeTypeAlias(string nodeTypeAlias);

	IBooleanOperation NodeTypeAlias(IExamineValue nodeTypeAlias);

	IBooleanOperation ParentId(int id);

	IBooleanOperation Field(string fieldName, string fieldValue);

	IBooleanOperation Field(string fieldName, IExamineValue fieldValue);

	IBooleanOperation Range(string fieldName, DateTime lower, DateTime upper);

	IBooleanOperation Range(string fieldName, DateTime lower, DateTime upper, bool includeLower, bool includeUpper);

	IBooleanOperation Range(string fieldName, DateTime lower, DateTime upper, bool includeLower, bool includeUpper, DateResolution resolution);

	IBooleanOperation Range(string fieldName, int lower, int upper);

	IBooleanOperation Range(string fieldName, int lower, int upper, bool includeLower, bool includeUpper);

	IBooleanOperation Range(string fieldName, double lower, double upper);

	IBooleanOperation Range(string fieldName, double lower, double upper, bool includeLower, bool includeUpper);

	IBooleanOperation Range(string fieldName, float lower, float upper);

	IBooleanOperation Range(string fieldName, float lower, float upper, bool includeLower, bool includeUpper);

	IBooleanOperation Range(string fieldName, long lower, long upper);

	IBooleanOperation Range(string fieldName, long lower, long upper, bool includeLower, bool includeUpper);

	IBooleanOperation Range(string fieldName, string lower, string upper);

	IBooleanOperation Range(string fieldName, string lower, string upper, bool includeLower, bool includeUpper);

	IBooleanOperation GroupedAnd(IEnumerable<string> fields, params string[] query);

	IBooleanOperation GroupedAnd(IEnumerable<string> fields, params IExamineValue[] query);

	IBooleanOperation GroupedOr(IEnumerable<string> fields, params string[] query);

	IBooleanOperation GroupedOr(IEnumerable<string> fields, params IExamineValue[] query);

	IBooleanOperation GroupedNot(IEnumerable<string> fields, params string[] query);

	IBooleanOperation GroupedNot(IEnumerable<string> fields, params IExamineValue[] query);

	IBooleanOperation GroupedFlexible(IEnumerable<string> fields, IEnumerable<BooleanOperation> operations, params string[] query);

	IBooleanOperation GroupedFlexible(IEnumerable<string> fields, IEnumerable<BooleanOperation> operations, params IExamineValue[] query);

	IBooleanOperation OrderBy(params string[] fieldNames);

	IBooleanOperation OrderByDescending(params string[] fieldNames);
}
