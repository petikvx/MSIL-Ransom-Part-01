using System;
using System.Collections.Generic;
using System.Data;
using LinqToDB.Common;

namespace Business.Data;

public abstract class DataBase<IConnection> : IData2, IData where IConnection : class, Business.Data.IConnection
{
	static DataBase()
	{
		Linq.AllowMultipleQuery = true;
	}

	public abstract IConnection GetConnection();

	Business.Data.IConnection IData.GetConnection()
	{
		return GetConnection();
	}

	private static Result UseConnection<Result>(Func<Business.Data.IConnection> getConnection, Func<Business.Data.IConnection, Result> func)
	{
		using Business.Data.IConnection arg = getConnection();
		return func(arg);
	}

	public int Save<T>(IEnumerable<T> obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		return UseConnection(GetConnection, (Business.Data.IConnection con) => con.Save(obj));
	}

	public int Save<T>(T obj)
	{
		return UseConnection(GetConnection, (Business.Data.IConnection con) => con.Save(obj));
	}

	public int SaveWithInt32Identity<T>(T obj)
	{
		return UseConnection(GetConnection, (Business.Data.IConnection con) => con.SaveWithInt32Identity(obj));
	}

	public long SaveWithInt64Identity<T>(T obj)
	{
		return UseConnection(GetConnection, (Business.Data.IConnection con) => con.SaveWithInt64Identity(obj));
	}

	public int SaveOrUpdate<T>(IEnumerable<T> obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		return UseConnection(GetConnection, (Business.Data.IConnection con) => con.SaveOrUpdate(obj));
	}

	public int SaveOrUpdate<T>(T obj)
	{
		return UseConnection(GetConnection, (Business.Data.IConnection con) => con.SaveOrUpdate(obj));
	}

	public int Update<T>(IEnumerable<T> obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		return UseConnection(GetConnection, (Business.Data.IConnection con) => con.Update(obj));
	}

	public int Update<T>(T obj)
	{
		return UseConnection(GetConnection, (Business.Data.IConnection con) => con.Update(obj));
	}

	public int Delete<T>(IEnumerable<T> obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		return UseConnection(GetConnection, (Business.Data.IConnection con) => con.Delete(obj));
	}

	public int Delete<T>(T obj)
	{
		return UseConnection(GetConnection, (Business.Data.IConnection con) => con.Delete(obj));
	}

	public int ExecuteNonQuery(string commandText, CommandType commandType = CommandType.Text, params DataParameter[] parameter)
	{
		return UseConnection(GetConnection, (Business.Data.IConnection con) => con.ExecuteNonQuery(commandText, commandType, parameter));
	}

	public Result ExecuteScalar<Result>(string commandText, CommandType commandType = CommandType.Text, params DataParameter[] parameter)
	{
		return UseConnection(GetConnection, (Business.Data.IConnection con) => con.ExecuteScalar<Result>(commandText, commandType, parameter));
	}
}
