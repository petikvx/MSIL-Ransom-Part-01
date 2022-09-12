using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Transactions;

namespace MySql.Data.MySqlClient;

internal sealed class MySqlPromotableTransaction : IPromotableSinglePhaseNotification, ITransactionPromoter
{
	[ThreadStatic]
	private static Stack<MySqlTransactionScope> globalScopeStack;

	private MySqlConnection connection;

	private Transaction baseTransaction;

	private Stack<MySqlTransactionScope> scopeStack;

	public Transaction BaseTransaction
	{
		get
		{
			if (scopeStack.Count > 0)
			{
				return scopeStack.Peek().baseTransaction;
			}
			return null;
		}
	}

	public bool InRollback
	{
		get
		{
			if (scopeStack.Count > 0 && scopeStack.Peek().rollbackThreadId == Thread.CurrentThread.ManagedThreadId)
			{
				return true;
			}
			return false;
		}
	}

	public MySqlPromotableTransaction(MySqlConnection connection, Transaction baseTransaction)
	{
		this.connection = connection;
		this.baseTransaction = baseTransaction;
	}

	void IPromotableSinglePhaseNotification.Initialize()
	{
		string name = Enum.GetName(typeof(System.Transactions.IsolationLevel), baseTransaction.IsolationLevel);
		System.Data.IsolationLevel iso = (System.Data.IsolationLevel)Enum.Parse(typeof(System.Data.IsolationLevel), name);
		MySqlTransaction simpleTransaction = connection.BeginTransaction(iso, "SESSION");
		if (globalScopeStack == null)
		{
			globalScopeStack = new Stack<MySqlTransactionScope>();
		}
		scopeStack = globalScopeStack;
		scopeStack.Push(new MySqlTransactionScope(connection, baseTransaction, simpleTransaction));
	}

	void IPromotableSinglePhaseNotification.Rollback(SinglePhaseEnlistment singlePhaseEnlistment)
	{
		scopeStack.Peek().Rollback(singlePhaseEnlistment);
		scopeStack.Pop();
	}

	void IPromotableSinglePhaseNotification.SinglePhaseCommit(SinglePhaseEnlistment singlePhaseEnlistment)
	{
		scopeStack.Pop().SinglePhaseCommit(singlePhaseEnlistment);
	}

	byte[] ITransactionPromoter.Promote()
	{
		throw new NotSupportedException();
	}
}
