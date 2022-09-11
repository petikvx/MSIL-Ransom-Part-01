using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using AutoMapper;
using AutoMapper.Data;
using Business.Utils;
using LinqToDB;

namespace Business.Data;

public static class DataConnectionEx
{
	public static IDbCommand GetCommand(this IConnection connection, string commandText, IDbTransaction t = null, CommandType commandType = CommandType.Text, params DataParameter[] parameter)
	{
		IDbCommand dbCommand = connection.CreateCommand();
		dbCommand.CommandType = commandType;
		dbCommand.CommandText = commandText;
		if (parameter != null)
		{
			for (int i = 0; i < parameter.Length; i++)
			{
				DataParameter dataParameter = parameter[i];
				IDbDataParameter dbDataParameter = dbCommand.CreateParameter();
				dbDataParameter.ParameterName = dataParameter.Name;
				dbDataParameter.Value = dataParameter.Value ?? DBNull.Value;
				dbCommand.Parameters.Add(dbDataParameter);
			}
		}
		dbCommand.Transaction = t;
		return dbCommand;
	}

	public static int ExecuteNonQuery(this IConnection connection, string commandText, CommandType commandType = CommandType.Text, params DataParameter[] parameter)
	{
		return connection.ExecutePack(delegate
		{
			using IDbCommand dbCommand = connection.GetCommand(commandText, connection.Transaction, commandType, parameter);
			return dbCommand.ExecuteNonQuery();
		});
	}

	public static Result ExecuteScalar<Result>(this IConnection connection, string commandText, CommandType commandType = CommandType.Text, params DataParameter[] parameter)
	{
		return connection.ExecutePack(delegate
		{
			using IDbCommand dbCommand = connection.GetCommand(commandText, connection.Transaction, commandType, parameter);
			return (Result)dbCommand.ExecuteScalar();
		}, minusOneExcep: false);
	}

	public static IList<TEntity> Execute<TEntity>(this IConnection connection, string commandText, CommandType commandType = CommandType.Text, params DataParameter[] parameter)
	{
		return connection.ExecutePack(delegate
		{
			using IDbCommand dbCommand = connection.GetCommand(commandText, connection.Transaction, commandType, parameter);
			using IDataReader reader = dbCommand.ExecuteReader();
			return reader.ToEntity<TEntity>();
		}, minusOneExcep: false);
	}

	public static IList<TEntity> ToEntity<TEntity>(this IDataReader reader)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		return new MapperConfiguration((Action<IMapperConfigurationExpression>)delegate(IMapperConfigurationExpression cfg)
		{
			ConfigurationExtensions.AddDataReaderMapping(cfg);
			((IProfileExpression)cfg).CreateMap<IDataReader, TEntity>();
		}).CreateMapper().Map<IList<TEntity>>((object)reader);
	}

	internal static Result ExecutePack<Result>(this IConnection connection, Func<Result> func, bool minusOneExcep = true)
	{
		bool flag = false;
		if (connection.Transaction == null)
		{
			connection.BeginTransaction();
			flag = !flag;
		}
		try
		{
			Result val = func();
			if (minusOneExcep && (typeof(Result).Equals(typeof(int)) || typeof(Result).Equals(typeof(long))) && object.Equals(-1, val))
			{
				connection.Rollback();
				throw new Exception("Affected the number of records -1");
			}
			if (flag)
			{
				connection.Commit();
			}
			return val;
		}
		catch (Exception ex)
		{
			if (connection.Transaction != null)
			{
				connection.Rollback();
			}
			throw ex;
		}
		finally
		{
			if (flag && connection.Transaction != null)
			{
				connection.Transaction.Dispose();
			}
		}
	}

	public static IQueryable<T> SkipRandom<T>(this IQueryable<T> query, int take = 0)
	{
		query = ((0 >= take) ? query.Skip(Help2.Random(query.Count())) : query.Skip(Help2.Random(query.Count() - take)).Take(take));
		return query;
	}

	public static int InsertOrUpdate<T>(this IQueryable<T> target, Expression<Func<T>> insertSetter, Expression<Func<T, T>> onDuplicateKeyUpdateSetter, Expression<Func<T>> keySelector) where T : class
	{
		return LinqExtensions.InsertOrUpdate<T>(target as ITable<T>, insertSetter, onDuplicateKeyUpdateSetter, keySelector);
	}

	public static int InsertOrUpdate<T>(this IQueryable<T> target, Expression<Func<T>> insertSetter, Expression<Func<T>> keySelector) where T : class, new()
	{
		ITable<T> target2 = target as ITable<T>;
		ParameterExpression parameterExpression = Expression.Parameter(typeof(T), "c");
		return ((IQueryable<T>)target2).InsertOrUpdate(insertSetter, Expression.Lambda<Func<T, T>>(Expression.MemberInit(Expression.New(typeof(T))), new ParameterExpression[1] { parameterExpression }), keySelector);
	}

	public static ITable<T> AsTable<T>(this IQueryable<T> queryable)
	{
		return queryable as ITable<T>;
	}

	public static PagingInfo GetPaging(int count, int currentPage, int pageSize, int pageSizeMax = 50)
	{
		if (count == 0)
		{
			return default(PagingInfo);
		}
		int num = Math.Min(pageSize, pageSizeMax);
		double num2 = Convert.ToDouble(count) / Convert.ToDouble(num);
		int num3 = ((double.IsNaN(num2) || double.IsPositiveInfinity(num2) || double.IsNegativeInfinity(num2)) ? 1 : Convert.ToInt32(Math.Ceiling(num2)));
		currentPage = ((currentPage >= 0) ? ((currentPage > num3) ? num3 : currentPage) : 0);
		if (currentPage <= 0 && num3 > 0)
		{
			currentPage = 1;
		}
		PagingInfo result = default(PagingInfo);
		result.Skip = num * (currentPage - 1);
		result.Take = num;
		result.CurrentPage = currentPage;
		result.CountPage = num3;
		return result;
	}

	public static Paging<T> GetPaging<T>(this IQueryable<T> query, int currentPage, int pageSize, int pageSizeMax = 50)
	{
		if (query == null)
		{
			throw new ArgumentNullException("query");
		}
		int num = query.Count();
		Paging<T> result;
		if (num == 0)
		{
			result = default(Paging<T>);
			result.Data = new List<T>();
			return result;
		}
		PagingInfo paging = GetPaging(num, currentPage, pageSize, pageSizeMax);
		List<T> list = query.Skip(paging.Skip).Take(paging.Take).ToList();
		result = default(Paging<T>);
		result.Data = list;
		result.Length = list.Count;
		result.CurrentPage = paging.CurrentPage;
		result.Count = num;
		result.CountPage = paging.CountPage;
		return result;
	}

	public static Paging<T> GetPagingOrderBy<T, TKey>(this IQueryable<T> query, int currentPage, int pageSize, Expression<Func<T, TKey>> keySelector, Order order = Order.Ascending, int pageSizeMax = 50)
	{
		if (query == null)
		{
			throw new ArgumentNullException("query");
		}
		int num = query.Count();
		Paging<T> result;
		if (num == 0)
		{
			result = default(Paging<T>);
			result.Data = new List<T>();
			return result;
		}
		PagingInfo paging = GetPaging(num, currentPage, pageSize, pageSizeMax);
		List<T> list = null;
		if (order != Order.Ascending)
		{
			if (order == (Order)Convert.ToInt32(3.0 - Math.Floor(1.0)))
			{
				list = query.Skip(paging.Skip).Take(paging.Take).OrderByDescending(keySelector)
					.ToList();
			}
		}
		else
		{
			list = query.Skip(paging.Skip).Take(paging.Take).OrderBy(keySelector)
				.ToList();
		}
		result = default(Paging<T>);
		result.Data = list;
		result.Length = list.Count;
		result.CurrentPage = paging.CurrentPage;
		result.Count = num;
		result.CountPage = paging.CountPage;
		return result;
	}

	public static Paging<T> ToPaging<T>(this List<T> data, int currentPage = 0, int count = 0, int countPage = 0)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		Paging<T> result = default(Paging<T>);
		result.Data = data;
		result.Length = data.Count;
		result.CurrentPage = currentPage;
		result.Count = count;
		result.CountPage = countPage;
		return result;
	}

	public static Paging<T> ToPaging<T>(this List<T> data, IPaging pagingObj)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		Paging<T> result = default(Paging<T>);
		result.Data = data;
		result.Length = data.Count;
		result.CurrentPage = pagingObj.CurrentPage;
		result.Count = pagingObj.Count;
		result.CountPage = pagingObj.CountPage;
		return result;
	}

	public static Paging<T> ToPaging<T>(this IEnumerable<T> data, int currentPage = 0, int count = 0, int countPage = 0)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		List<T> list = data.ToList();
		Paging<T> result = default(Paging<T>);
		result.Data = list;
		result.Length = list.Count;
		result.CurrentPage = currentPage;
		result.Count = count;
		result.CountPage = countPage;
		return result;
	}

	public static Paging<T> ToPaging<T>(this IEnumerable<T> data, IPaging pagingObj)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		List<T> list = data.ToList();
		Paging<T> result = default(Paging<T>);
		result.Data = list.ToList();
		result.Length = list.Count;
		result.CurrentPage = pagingObj.CurrentPage;
		result.Count = pagingObj.Count;
		result.CountPage = pagingObj.CountPage;
		return result;
	}
}
