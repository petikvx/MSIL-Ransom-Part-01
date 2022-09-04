using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace SHDocVw;

internal sealed class _SearchAssistantEvents_EventProvider : IDisposable, _SearchAssistantEvents_Event
{
	private IConnectionPointContainer m_ConnectionPointContainer;

	private ArrayList m_aEventSinkHelpers;

	private IConnectionPoint m_ConnectionPoint;

	public override event _SearchAssistantEvents_OnNextMenuSelectEventHandler OnNextMenuSelect
	{
		add
		{
			Monitor.Enter(this);
			try
			{
				if (m_ConnectionPoint == null)
				{
					Init();
				}
				_SearchAssistantEvents_SinkHelper searchAssistantEvents_SinkHelper = new _SearchAssistantEvents_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(searchAssistantEvents_SinkHelper, out pdwCookie);
				searchAssistantEvents_SinkHelper.m_dwCookie = pdwCookie;
				searchAssistantEvents_SinkHelper.m_OnNextMenuSelectDelegate = value;
				m_aEventSinkHelpers.Add(searchAssistantEvents_SinkHelper);
			}
			finally
			{
				Monitor.Exit(this);
			}
		}
		remove
		{
			Monitor.Enter(this);
			try
			{
				if (m_aEventSinkHelpers == null)
				{
					return;
				}
				int count = m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 >= count)
				{
					return;
				}
				_SearchAssistantEvents_SinkHelper searchAssistantEvents_SinkHelper;
				while (true)
				{
					searchAssistantEvents_SinkHelper = (_SearchAssistantEvents_SinkHelper)m_aEventSinkHelpers[num];
					if (searchAssistantEvents_SinkHelper.m_OnNextMenuSelectDelegate == null || ((searchAssistantEvents_SinkHelper.m_OnNextMenuSelectDelegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
					{
						num++;
						if (num >= count)
						{
							return;
						}
						continue;
					}
					break;
				}
				m_aEventSinkHelpers.RemoveAt(num);
				m_ConnectionPoint.Unadvise(searchAssistantEvents_SinkHelper.m_dwCookie);
				if (count <= 1)
				{
					Marshal.ReleaseComObject(m_ConnectionPoint);
					m_ConnectionPoint = null;
					m_aEventSinkHelpers = null;
				}
			}
			finally
			{
				Monitor.Exit(this);
			}
		}
	}

	public override event _SearchAssistantEvents_OnNewSearchEventHandler OnNewSearch
	{
		add
		{
			Monitor.Enter(this);
			try
			{
				if (m_ConnectionPoint == null)
				{
					Init();
				}
				_SearchAssistantEvents_SinkHelper searchAssistantEvents_SinkHelper = new _SearchAssistantEvents_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(searchAssistantEvents_SinkHelper, out pdwCookie);
				searchAssistantEvents_SinkHelper.m_dwCookie = pdwCookie;
				searchAssistantEvents_SinkHelper.m_OnNewSearchDelegate = value;
				m_aEventSinkHelpers.Add(searchAssistantEvents_SinkHelper);
			}
			finally
			{
				Monitor.Exit(this);
			}
		}
		remove
		{
			Monitor.Enter(this);
			try
			{
				if (m_aEventSinkHelpers == null)
				{
					return;
				}
				int count = m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 >= count)
				{
					return;
				}
				_SearchAssistantEvents_SinkHelper searchAssistantEvents_SinkHelper;
				while (true)
				{
					searchAssistantEvents_SinkHelper = (_SearchAssistantEvents_SinkHelper)m_aEventSinkHelpers[num];
					if (searchAssistantEvents_SinkHelper.m_OnNewSearchDelegate == null || ((searchAssistantEvents_SinkHelper.m_OnNewSearchDelegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
					{
						num++;
						if (num >= count)
						{
							return;
						}
						continue;
					}
					break;
				}
				m_aEventSinkHelpers.RemoveAt(num);
				m_ConnectionPoint.Unadvise(searchAssistantEvents_SinkHelper.m_dwCookie);
				if (count <= 1)
				{
					Marshal.ReleaseComObject(m_ConnectionPoint);
					m_ConnectionPoint = null;
					m_aEventSinkHelpers = null;
				}
			}
			finally
			{
				Monitor.Exit(this);
			}
		}
	}

	private void Init()
	{
		IConnectionPoint ppCP = null;
		Guid riid = new Guid(new byte[16]
		{
			218, 253, 17, 22, 91, 68, 210, 17, 133, 222,
			0, 192, 79, 163, 92, 137
		});
		m_ConnectionPointContainer.FindConnectionPoint(ref riid, out ppCP);
		m_ConnectionPoint = ppCP;
		m_aEventSinkHelpers = new ArrayList();
	}

	public _SearchAssistantEvents_EventProvider(object param0)
	{
		m_ConnectionPointContainer = (IConnectionPointContainer)param0;
	}

	public override void Finalize()
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
			if (0 < count)
			{
				do
				{
					_SearchAssistantEvents_SinkHelper searchAssistantEvents_SinkHelper = (_SearchAssistantEvents_SinkHelper)m_aEventSinkHelpers[num];
					m_ConnectionPoint.Unadvise(searchAssistantEvents_SinkHelper.m_dwCookie);
					num++;
				}
				while (num < count);
			}
			Marshal.ReleaseComObject(m_ConnectionPoint);
		}
		catch (Exception)
		{
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public override void Dispose()
	{
		Finalize();
		GC.SuppressFinalize(this);
	}
}
