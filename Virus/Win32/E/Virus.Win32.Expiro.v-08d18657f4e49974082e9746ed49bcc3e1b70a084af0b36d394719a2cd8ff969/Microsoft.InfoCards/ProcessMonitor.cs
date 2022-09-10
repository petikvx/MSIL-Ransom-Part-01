using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Microsoft.InfoCards;

internal class ProcessMonitor
{
	private static ProcessMonitor s_current = new ProcessMonitor();

	private Dictionary<int, Process> m_cache;

	private object m_sync;

	private ProcessMonitor()
	{
		m_sync = new object();
		m_cache = new Dictionary<int, Process>();
	}

	public static Process GetProcessById(int id)
	{
		return s_current.InnerGetProcessById(id);
	}

	private Process InnerGetProcessById(int id)
	{
		Process value = null;
		lock (m_sync)
		{
			if (!m_cache.TryGetValue(id, out value))
			{
				value = Process.GetProcessById(id);
				if (!value.HasExited)
				{
					InitializeProcessObject(value);
					m_cache.Add(value.Id, value);
					return value;
				}
				return value;
			}
			return value;
		}
	}

	private void InitializeProcessObject(Process process)
	{
		process.EnableRaisingEvents = true;
		process.Exited += Process_Exited;
	}

	private void Process_Exited(object sender, EventArgs e)
	{
		Process process = (Process)sender;
		lock (m_sync)
		{
			m_cache.Remove(process.Id);
		}
		process.Exited -= Process_Exited;
	}
}
