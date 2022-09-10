using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Threading;

namespace MSHelpServices;

internal sealed class IHxRegisterSessionEvents_EventProvider : IDisposable, IHxRegisterSessionEvents_Event
{
	private ArrayList m_aEventSinkHelpers;

	private UCOMIConnectionPoint m_ConnectionPoint;

	private UCOMIConnectionPointContainer m_ConnectionPointContainer;

	public event IHxRegisterSessionEvents_FiltersChangedEventHandler FiltersChanged
	{
		add
		{
			lock (this)
			{
				if (m_ConnectionPoint == null)
				{
					Init();
				}
				IHxRegisterSessionEvents_SinkHelper hxRegisterSessionEvents_SinkHelper = new IHxRegisterSessionEvents_SinkHelper();
				int dwCookie = 0;
				m_ConnectionPoint.Advise((object)hxRegisterSessionEvents_SinkHelper, ref dwCookie);
				hxRegisterSessionEvents_SinkHelper.m_dwCookie = dwCookie;
				hxRegisterSessionEvents_SinkHelper.m_FiltersChangedDelegate = value;
				m_aEventSinkHelpers.Add(hxRegisterSessionEvents_SinkHelper);
			}
		}
		remove
		{
			lock (this)
			{
				int count = m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 >= count)
				{
					return;
				}
				do
				{
					IHxRegisterSessionEvents_SinkHelper hxRegisterSessionEvents_SinkHelper = (IHxRegisterSessionEvents_SinkHelper)m_aEventSinkHelpers[num];
					if (hxRegisterSessionEvents_SinkHelper.m_FiltersChangedDelegate == null || !hxRegisterSessionEvents_SinkHelper.m_FiltersChangedDelegate.Equals(value))
					{
						num++;
						continue;
					}
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(hxRegisterSessionEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				while (num < count);
			}
		}
	}

	public IHxRegisterSessionEvents_EventProvider(object obj1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		m_ConnectionPointContainer = (UCOMIConnectionPointContainer)obj1;
	}

	public void Dispose()
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				IHxRegisterSessionEvents_SinkHelper hxRegisterSessionEvents_SinkHelper = (IHxRegisterSessionEvents_SinkHelper)m_aEventSinkHelpers[num];
				m_ConnectionPoint.Unadvise(hxRegisterSessionEvents_SinkHelper.m_dwCookie);
				num++;
			}
			while (num < count);
		}
		catch (Exception)
		{
			return;
		}
		finally
		{
			Monitor.Exit(this);
		}
		GC.SuppressFinalize(this);
	}

	~IHxRegisterSessionEvents_EventProvider()
	{
		Dispose();
	}

	private void Init()
	{
		UCOMIConnectionPoint connectionPoint = null;
		byte[] b = new byte[16]
		{
			35, 18, 65, 49, 2, 165, 210, 17, 187, 202,
			0, 192, 79, 142, 194, 148
		};
		Guid guid = new Guid(b);
		m_ConnectionPointContainer.FindConnectionPoint(ref guid, ref connectionPoint);
		m_ConnectionPoint = connectionPoint;
		m_aEventSinkHelpers = new ArrayList();
	}
}
