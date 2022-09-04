using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace SHDocVw;

internal sealed class DShellNameSpaceEvents_EventProvider : IDisposable, DShellNameSpaceEvents_Event
{
	private IConnectionPointContainer m_ConnectionPointContainer;

	private ArrayList m_aEventSinkHelpers;

	private IConnectionPoint m_ConnectionPoint;

	public override event DShellNameSpaceEvents_FavoritesSelectionChangeEventHandler FavoritesSelectionChange
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
				DShellNameSpaceEvents_SinkHelper dShellNameSpaceEvents_SinkHelper = new DShellNameSpaceEvents_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(dShellNameSpaceEvents_SinkHelper, out pdwCookie);
				dShellNameSpaceEvents_SinkHelper.m_dwCookie = pdwCookie;
				dShellNameSpaceEvents_SinkHelper.m_FavoritesSelectionChangeDelegate = value;
				m_aEventSinkHelpers.Add(dShellNameSpaceEvents_SinkHelper);
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
				DShellNameSpaceEvents_SinkHelper dShellNameSpaceEvents_SinkHelper;
				while (true)
				{
					dShellNameSpaceEvents_SinkHelper = (DShellNameSpaceEvents_SinkHelper)m_aEventSinkHelpers[num];
					if (dShellNameSpaceEvents_SinkHelper.m_FavoritesSelectionChangeDelegate == null || ((dShellNameSpaceEvents_SinkHelper.m_FavoritesSelectionChangeDelegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
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
				m_ConnectionPoint.Unadvise(dShellNameSpaceEvents_SinkHelper.m_dwCookie);
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

	public override event DShellNameSpaceEvents_SelectionChangeEventHandler SelectionChange
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
				DShellNameSpaceEvents_SinkHelper dShellNameSpaceEvents_SinkHelper = new DShellNameSpaceEvents_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(dShellNameSpaceEvents_SinkHelper, out pdwCookie);
				dShellNameSpaceEvents_SinkHelper.m_dwCookie = pdwCookie;
				dShellNameSpaceEvents_SinkHelper.m_SelectionChangeDelegate = value;
				m_aEventSinkHelpers.Add(dShellNameSpaceEvents_SinkHelper);
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
				DShellNameSpaceEvents_SinkHelper dShellNameSpaceEvents_SinkHelper;
				while (true)
				{
					dShellNameSpaceEvents_SinkHelper = (DShellNameSpaceEvents_SinkHelper)m_aEventSinkHelpers[num];
					if (dShellNameSpaceEvents_SinkHelper.m_SelectionChangeDelegate == null || ((dShellNameSpaceEvents_SinkHelper.m_SelectionChangeDelegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
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
				m_ConnectionPoint.Unadvise(dShellNameSpaceEvents_SinkHelper.m_dwCookie);
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

	public override event DShellNameSpaceEvents_DoubleClickEventHandler DoubleClick
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
				DShellNameSpaceEvents_SinkHelper dShellNameSpaceEvents_SinkHelper = new DShellNameSpaceEvents_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(dShellNameSpaceEvents_SinkHelper, out pdwCookie);
				dShellNameSpaceEvents_SinkHelper.m_dwCookie = pdwCookie;
				dShellNameSpaceEvents_SinkHelper.m_DoubleClickDelegate = value;
				m_aEventSinkHelpers.Add(dShellNameSpaceEvents_SinkHelper);
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
				DShellNameSpaceEvents_SinkHelper dShellNameSpaceEvents_SinkHelper;
				while (true)
				{
					dShellNameSpaceEvents_SinkHelper = (DShellNameSpaceEvents_SinkHelper)m_aEventSinkHelpers[num];
					if (dShellNameSpaceEvents_SinkHelper.m_DoubleClickDelegate == null || ((dShellNameSpaceEvents_SinkHelper.m_DoubleClickDelegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
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
				m_ConnectionPoint.Unadvise(dShellNameSpaceEvents_SinkHelper.m_dwCookie);
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

	public override event DShellNameSpaceEvents_InitializedEventHandler Initialized
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
				DShellNameSpaceEvents_SinkHelper dShellNameSpaceEvents_SinkHelper = new DShellNameSpaceEvents_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(dShellNameSpaceEvents_SinkHelper, out pdwCookie);
				dShellNameSpaceEvents_SinkHelper.m_dwCookie = pdwCookie;
				dShellNameSpaceEvents_SinkHelper.m_InitializedDelegate = value;
				m_aEventSinkHelpers.Add(dShellNameSpaceEvents_SinkHelper);
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
				DShellNameSpaceEvents_SinkHelper dShellNameSpaceEvents_SinkHelper;
				while (true)
				{
					dShellNameSpaceEvents_SinkHelper = (DShellNameSpaceEvents_SinkHelper)m_aEventSinkHelpers[num];
					if (dShellNameSpaceEvents_SinkHelper.m_InitializedDelegate == null || ((dShellNameSpaceEvents_SinkHelper.m_InitializedDelegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
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
				m_ConnectionPoint.Unadvise(dShellNameSpaceEvents_SinkHelper.m_dwCookie);
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
			6, 104, 19, 85, 222, 178, 209, 17, 185, 242,
			0, 160, 201, 139, 197, 71
		});
		m_ConnectionPointContainer.FindConnectionPoint(ref riid, out ppCP);
		m_ConnectionPoint = ppCP;
		m_aEventSinkHelpers = new ArrayList();
	}

	public DShellNameSpaceEvents_EventProvider(object param0)
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
					DShellNameSpaceEvents_SinkHelper dShellNameSpaceEvents_SinkHelper = (DShellNameSpaceEvents_SinkHelper)m_aEventSinkHelpers[num];
					m_ConnectionPoint.Unadvise(dShellNameSpaceEvents_SinkHelper.m_dwCookie);
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
