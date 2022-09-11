using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Transactions;
using ns0;
using ns11;
using ns9;

namespace ns22;

internal sealed class Class153 : IPromotableSinglePhaseNotification, ITransactionPromoter
{
	[ThreadStatic]
	private static Stack<Class152> stack_0;

	private Class139 class139_0;

	private Transaction transaction_0;

	private Stack<Class152> stack_1;

	public Transaction BaseTransaction
	{
		get
		{
			if (stack_1.Count > 0)
			{
				return stack_1.Peek().transaction_0;
			}
			return null;
		}
	}

	public bool InRollback
	{
		get
		{
			if (stack_1.Count > 0 && stack_1.Peek().int_0 == Thread.CurrentThread.ManagedThreadId)
			{
				return true;
			}
			return false;
		}
	}

	public Class153(Class139 class139_1, Transaction transaction_1)
	{
		class139_0 = class139_1;
		transaction_0 = transaction_1;
	}

	void IPromotableSinglePhaseNotification.Initialize()
	{
		string name = Enum.GetName(typeof(System.Transactions.IsolationLevel), transaction_0.IsolationLevel);
		System.Data.IsolationLevel isolationLevel_ = (System.Data.IsolationLevel)Enum.Parse(typeof(System.Data.IsolationLevel), name);
		Class181 class181_ = class139_0.method_2(isolationLevel_);
		if (stack_0 == null)
		{
			stack_0 = new Stack<Class152>();
		}
		stack_1 = stack_0;
		stack_1.Push(new Class152(class139_0, transaction_0, class181_));
	}

	void IPromotableSinglePhaseNotification.Rollback(SinglePhaseEnlistment singlePhaseEnlistment)
	{
		stack_1.Peek().method_0(singlePhaseEnlistment);
		stack_1.Pop();
	}

	void IPromotableSinglePhaseNotification.SinglePhaseCommit(SinglePhaseEnlistment singlePhaseEnlistment)
	{
		stack_1.Pop().method_1(singlePhaseEnlistment);
	}

	byte[] ITransactionPromoter.Promote()
	{
		throw new NotSupportedException();
	}
}
