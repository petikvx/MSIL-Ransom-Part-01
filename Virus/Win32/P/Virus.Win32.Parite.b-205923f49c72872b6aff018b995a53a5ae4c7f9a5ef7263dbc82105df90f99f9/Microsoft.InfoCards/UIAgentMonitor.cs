using System;
using System.Collections.Generic;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class UIAgentMonitor
{
	private static UIAgentMonitor s_singleton = null;

	private static object s_syncRoot = new object();

	private Dictionary<string, UIAgentMonitorHandle> m_currentCallingUsers;

	private Dictionary<int, UIAgentMonitorHandle> m_currentTSSessions;

	private UIAgentMonitor()
	{
		m_currentCallingUsers = new Dictionary<string, UIAgentMonitorHandle>();
		m_currentTSSessions = new Dictionary<int, UIAgentMonitorHandle>();
	}

	public static UIAgentMonitor Instance()
	{
		if (s_singleton == null)
		{
			lock (s_syncRoot)
			{
				if (s_singleton == null)
				{
					s_singleton = new UIAgentMonitor();
				}
			}
		}
		return s_singleton;
	}

	public void AddNewClient(UIAgentMonitorHandle handle)
	{
		lock (s_syncRoot)
		{
			string userName = handle.UserName;
			int tsSessionId = handle.TsSessionId;
			if (m_currentCallingUsers.ContainsKey(userName))
			{
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new ServiceBusyException(SR.GetString("ServiceInUseOnAnotherSession")));
			}
			if (m_currentTSSessions.ContainsKey(tsSessionId))
			{
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new ServiceBusyException(SR.GetString("ServiceInUseOnAnotherSession")));
			}
			m_currentCallingUsers.Add(userName, handle);
			try
			{
				m_currentTSSessions.Add(tsSessionId, handle);
			}
			catch (Exception)
			{
				m_currentCallingUsers.Remove(userName);
				throw;
			}
		}
	}

	public void RemoveClient(UIAgentMonitorHandle handle)
	{
		lock (s_syncRoot)
		{
			string userName = handle.UserName;
			int tsSessionId = handle.TsSessionId;
			if (!string.IsNullOrEmpty(userName) && m_currentCallingUsers.ContainsKey(userName) && handle == m_currentCallingUsers[userName])
			{
				m_currentCallingUsers.Remove(userName);
			}
			if (m_currentTSSessions.ContainsKey(tsSessionId) && handle == m_currentTSSessions[tsSessionId])
			{
				m_currentTSSessions.Remove(tsSessionId);
			}
		}
	}
}
