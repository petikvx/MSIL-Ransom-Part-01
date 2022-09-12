using System;
using System.Collections.Generic;
using MySql.Data;
using MySqlX.Protocol.X;
using Mysqlx.Crud;
using Mysqlx.Datatypes;
using Mysqlx.Expr;

namespace MySqlX.XDevAPI.Common;

internal class FilterParams
{
	public long Limit = -1L;

	public long Offset = -1L;

	public string Condition;

	public Dictionary<string, object> Parameters = new Dictionary<string, object>();

	public Dictionary<string, int> placeholderNameToPosition;

	public bool IsRelational;

	public string[] OrderBy;

	public bool hadLimit;

	public bool hadOffset;

	public bool HasLimit => Limit != -1L;

	public List<Order> GetOrderByExpressions(bool allowRelational)
	{
		return new ExprParser(ExprUtil.JoinString(OrderBy), allowRelational).ParseOrderSpec();
	}

	public Expr GetConditionExpression(bool allowRelational)
	{
		ExprParser exprParser = new ExprParser(Condition, allowRelational);
		Expr result = exprParser.Parse();
		if (exprParser.GetPositionalPlaceholderCount() > 0)
		{
			placeholderNameToPosition = exprParser.GetPlaceholderNameToPositionMap();
		}
		return result;
	}

	public IEnumerable<Scalar> GetArgsExpression(Dictionary<string, object> parameters)
	{
		if (placeholderNameToPosition != null && placeholderNameToPosition.Count != 0)
		{
			Scalar[] array = new Scalar[placeholderNameToPosition.Count];
			{
				foreach (KeyValuePair<string, object> parameter in parameters)
				{
					if (placeholderNameToPosition.ContainsKey(parameter.Key.ToLowerInvariant()))
					{
						array[placeholderNameToPosition[parameter.Key.ToLowerInvariant()]] = ExprUtil.ArgObjectToScalar(parameter.Value) ?? throw new ArgumentException(parameter.Key);
						continue;
					}
					throw new ArgumentNullException(string.Format(ResourcesX.UnknownPlaceholder, parameter.Key));
				}
				return array;
			}
		}
		throw new ArgumentException(ResourcesX.NoPlaceholders);
	}

	public FilterParams Clone()
	{
		return (FilterParams)MemberwiseClone();
	}
}
