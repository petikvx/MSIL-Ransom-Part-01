using System;
using System.ServiceProcess;
using System.Timers;
using Microsoft.InfoCards.Diagnostics;
using Microsoft.Win32;

namespace Microsoft.InfoCards;

internal class LifeTimeMonitor
{
	private const int DefaultShutdownInterval = 3600000;

	private const int MinimumShutdownInterval = 60000;

	private const string ServiceIdleTimeValue = "ServiceIdleTime";

	private int m_activeCount;

	private bool m_isShuttingDown;

	private Timer m_shutdownTimer;

	private object m_syncRoot = new object();

	public LifeTimeMonitor()
	{
		int num = 3600000;
		using (new SystemIdentity(throwIfAlreadySystem: false))
		{
			using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(InfoCardConstants.RegistryKey, writable: false);
			if (registryKey != null)
			{
				object value = registryKey.GetValue("ServiceIdleTime", 3600000);
				if (value is int && (int)value >= 60000)
				{
					num = (int)value;
				}
			}
		}
		m_activeCount = 0;
		m_shutdownTimer = new Timer(num);
		m_shutdownTimer.Elapsed += OnShutdown;
		m_shutdownTimer.AutoReset = false;
		m_isShuttingDown = false;
		StartShutdownTimer();
	}

	public void AddClient()
	{
		lock (m_syncRoot)
		{
			InfoCardTrace.Assert(m_activeCount >= 0, "incorrect active count", new object[0]);
			if (m_isShuttingDown)
			{
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new ServiceBusyException());
			}
			m_activeCount++;
			if (1 == m_activeCount)
			{
				StopShutdownTimer();
			}
		}
	}

	public void RemoveClient()
	{
		lock (m_syncRoot)
		{
			InfoCardTrace.Assert(m_activeCount > 0, "invalid active count", new object[0]);
			m_activeCount--;
			if (m_activeCount == 0)
			{
				StartShutdownTimer();
			}
		}
	}

	private void OnShutdown(object sender, ElapsedEventArgs e)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		lock (m_syncRoot)
		{
			if (m_activeCount > 0)
			{
				return;
			}
			m_shutdownTimer.Enabled = false;
			m_isShuttingDown = true;
			InfoCardTrace.Audit((EventCode)1074070022);
		}
		using (new SystemIdentity(throwIfAlreadySystem: false))
		{
			new ServiceController("idsvc").Stop();
		}
	}

	private void StartShutdownTimer()
	{
		m_shutdownTimer.Start();
	}

	private void StopShutdownTimer()
	{
		m_shutdownTimer.Stop();
	}
}
