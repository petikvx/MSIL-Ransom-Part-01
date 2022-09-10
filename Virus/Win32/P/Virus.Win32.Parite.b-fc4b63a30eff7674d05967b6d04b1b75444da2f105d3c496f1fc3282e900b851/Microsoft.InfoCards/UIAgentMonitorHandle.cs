using System;
using System.Security.Principal;

namespace Microsoft.InfoCards;

internal class UIAgentMonitorHandle : IDisposable
{
	private InfoCardUIAgent m_agent;

	private string m_username;

	private int m_tsSessionId;

	public string UserName => m_username;

	public int TsSessionId => m_tsSessionId;

	public InfoCardUIAgent CreateAgent(int callerPid, WindowsIdentity callerIdentity, int tsSessionId)
	{
		m_username = callerIdentity.User!.ToString();
		m_tsSessionId = tsSessionId;
		UIAgentMonitor.Instance().AddNewClient(this);
		m_agent = InfoCardUIAgent.Create(callerPid, callerIdentity, tsSessionId);
		return m_agent;
	}

	void IDisposable.Dispose()
	{
		UIAgentMonitor.Instance().RemoveClient(this);
	}
}
