using System;
using System.Collections.Generic;
using MySql.Data;
using MySqlX.Serialization;

namespace MySqlX.XDevAPI.Common;

public abstract class FilterableStatement<T, TTarget, TResult> : TargetedBaseStatement<TTarget, TResult> where T : FilterableStatement<T, TTarget, TResult> where TTarget : DatabaseObject where TResult : BaseResult
{
	private FilterParams filter = new FilterParams();

	internal FilterParams FilterData => filter;

	public FilterableStatement(TTarget target, string condition = null)
		: base(target)
	{
		if (condition != null)
		{
			Where(condition);
		}
	}

	public T Where(string condition)
	{
		filter.Condition = condition;
		SetChanged();
		return (T)this;
	}

	public T Limit(long rows)
	{
		if (rows <= 0L)
		{
			throw new ArgumentOutOfRangeException("rows", string.Format(ResourcesX.NumberNotGreaterThanZero, "rows"));
		}
		filter.Limit = rows;
		return (T)this;
	}

	public T Offset(long rows)
	{
		filter.Offset = rows;
		return (T)this;
	}

	public T Bind(string parameterName, object value)
	{
		FilterData.Parameters[parameterName.ToLowerInvariant()] = ((value is string) ? QuoteString((string)value) : value);
		return (T)this;
	}

	public T Bind(DbDoc dbDocParams)
	{
		return Bind(dbDocParams.ToString());
	}

	public T Bind(string jsonParams)
	{
		foreach (KeyValuePair<string, object> item in JsonParser.Parse(jsonParams))
		{
			Bind(item.Key, item.Value);
		}
		return (T)this;
	}

	public T Bind(object jsonParams)
	{
		return Bind(new DbDoc(jsonParams));
	}

	protected virtual TResult Execute(Func<T, TResult> executeFunc, T t)
	{
		try
		{
			ValidateOpenSession();
			List<object> list = new List<object>(FilterData.Parameters.Values);
			if (_isPrepared && FilterData.hadLimit != FilterData.HasLimit)
			{
				SetChanged();
			}
			if (!_hasChanged && FilterData.HasLimit)
			{
				list.Add(FilterData.Limit);
				list.Add((FilterData.Offset == -1L) ? 0L : FilterData.Offset);
			}
			TResult result = ConvertToPreparedStatement(executeFunc, t, list);
			_hasChanged = false;
			return result;
		}
		finally
		{
			FilterData.hadLimit = FilterData.HasLimit;
			FilterData.hadOffset = FilterData.Offset != -1L;
		}
	}

	public virtual T Clone()
	{
		T val = (T)MemberwiseClone();
		val.filter = val.FilterData.Clone();
		return val;
	}

	private static string QuoteString(string value)
	{
		return "'" + value.Trim().Replace("'", "\\'") + "'";
	}
}
