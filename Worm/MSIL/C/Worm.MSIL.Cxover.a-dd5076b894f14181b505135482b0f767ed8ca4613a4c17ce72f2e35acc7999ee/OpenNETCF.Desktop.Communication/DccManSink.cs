using System;
using System.Runtime.InteropServices;

namespace OpenNETCF.Desktop.Communication;

[Guid("C6659361-1625-4746-931C-36014B146679")]
internal class DccManSink : IDccManSink
{
	public event ActiveHandler Active;

	public event AnswerHandler Answer;

	public event DisconnectHandler Disconnect;

	public event ErrorHandler Error;

	public event InactiveHandler Inactive;

	public event IPAddrHandler IPChange;

	public event ListenHandler Listen;

	public event TerminatedHandler Terminated;

	public int OnLogActive()
	{
		Delegate[] invocationList = this.Active.GetInvocationList();
		for (int i = 0; i < invocationList.Length; i++)
		{
			ActiveHandler activeHandler = (ActiveHandler)invocationList[i];
			activeHandler();
		}
		return 0;
	}

	public int OnLogAnswered()
	{
		Delegate[] invocationList = this.Answer.GetInvocationList();
		for (int i = 0; i < invocationList.Length; i++)
		{
			AnswerHandler answerHandler = (AnswerHandler)invocationList[i];
			answerHandler();
		}
		return 0;
	}

	public int OnLogDisconnection()
	{
		Delegate[] invocationList = this.Disconnect.GetInvocationList();
		for (int i = 0; i < invocationList.Length; i++)
		{
			DisconnectHandler disconnectHandler = (DisconnectHandler)invocationList[i];
			disconnectHandler();
		}
		return 0;
	}

	public int OnLogError()
	{
		Delegate[] invocationList = this.Error.GetInvocationList();
		for (int i = 0; i < invocationList.Length; i++)
		{
			ErrorHandler errorHandler = (ErrorHandler)invocationList[i];
			errorHandler();
		}
		return 0;
	}

	public int OnLogInactive()
	{
		Delegate[] invocationList = this.Inactive.GetInvocationList();
		for (int i = 0; i < invocationList.Length; i++)
		{
			InactiveHandler inactiveHandler = (InactiveHandler)invocationList[i];
			inactiveHandler();
		}
		return 0;
	}

	public int OnLogIpAddr(int dwIpAddr)
	{
		Delegate[] invocationList = this.IPChange.GetInvocationList();
		for (int i = 0; i < invocationList.Length; i++)
		{
			IPAddrHandler iPAddrHandler = (IPAddrHandler)invocationList[i];
			iPAddrHandler(dwIpAddr);
		}
		return 0;
	}

	public int OnLogListen()
	{
		Delegate[] invocationList = this.Listen.GetInvocationList();
		for (int i = 0; i < invocationList.Length; i++)
		{
			ListenHandler listenHandler = (ListenHandler)invocationList[i];
			listenHandler();
		}
		return 0;
	}

	public int OnLogTerminated()
	{
		Delegate[] invocationList = this.Terminated.GetInvocationList();
		for (int i = 0; i < invocationList.Length; i++)
		{
			TerminatedHandler terminatedHandler = (TerminatedHandler)invocationList[i];
			terminatedHandler();
		}
		return 0;
	}
}
