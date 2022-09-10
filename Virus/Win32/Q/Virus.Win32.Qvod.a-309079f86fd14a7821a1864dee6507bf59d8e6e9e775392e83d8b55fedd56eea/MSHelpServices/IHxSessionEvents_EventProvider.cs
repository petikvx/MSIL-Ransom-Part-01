using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Threading;

namespace MSHelpServices;

internal sealed class IHxSessionEvents_EventProvider : IDisposable, IHxSessionEvents_Event
{
	private ArrayList m_aEventSinkHelpers;

	private UCOMIConnectionPoint m_ConnectionPoint;

	private UCOMIConnectionPointContainer m_ConnectionPointContainer;

	public event IHxSessionEvents_IndexMergeStatusEventHandler IndexMergeStatus
	{
		add
		{
			lock (this)
			{
				if (m_ConnectionPoint == null)
				{
					Init();
				}
				IHxSessionEvents_SinkHelper hxSessionEvents_SinkHelper = new IHxSessionEvents_SinkHelper();
				int dwCookie = 0;
				m_ConnectionPoint.Advise((object)hxSessionEvents_SinkHelper, ref dwCookie);
				hxSessionEvents_SinkHelper.m_dwCookie = dwCookie;
				hxSessionEvents_SinkHelper.m_IndexMergeStatusDelegate = value;
				m_aEventSinkHelpers.Add(hxSessionEvents_SinkHelper);
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
					IHxSessionEvents_SinkHelper hxSessionEvents_SinkHelper = (IHxSessionEvents_SinkHelper)m_aEventSinkHelpers[num];
					if (hxSessionEvents_SinkHelper.m_IndexMergeStatusDelegate == null || !hxSessionEvents_SinkHelper.m_IndexMergeStatusDelegate.Equals(value))
					{
						num++;
						continue;
					}
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(hxSessionEvents_SinkHelper.m_dwCookie);
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

	public event IHxSessionEvents_MergeIndexFileNameEventHandler MergeIndexFileName
	{
		add
		{
			lock (this)
			{
				if (m_ConnectionPoint == null)
				{
					Init();
				}
				IHxSessionEvents_SinkHelper hxSessionEvents_SinkHelper = new IHxSessionEvents_SinkHelper();
				int dwCookie = 0;
				m_ConnectionPoint.Advise((object)hxSessionEvents_SinkHelper, ref dwCookie);
				hxSessionEvents_SinkHelper.m_dwCookie = dwCookie;
				hxSessionEvents_SinkHelper.m_MergeIndexFileNameDelegate = value;
				m_aEventSinkHelpers.Add(hxSessionEvents_SinkHelper);
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
					IHxSessionEvents_SinkHelper hxSessionEvents_SinkHelper = (IHxSessionEvents_SinkHelper)m_aEventSinkHelpers[num];
					if (hxSessionEvents_SinkHelper.m_MergeIndexFileNameDelegate == null || !hxSessionEvents_SinkHelper.m_MergeIndexFileNameDelegate.Equals(value))
					{
						num++;
						continue;
					}
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(hxSessionEvents_SinkHelper.m_dwCookie);
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

	public event IHxSessionEvents_PrintMergeStatusEventHandler PrintMergeStatus
	{
		add
		{
			lock (this)
			{
				if (m_ConnectionPoint == null)
				{
					Init();
				}
				IHxSessionEvents_SinkHelper hxSessionEvents_SinkHelper = new IHxSessionEvents_SinkHelper();
				int dwCookie = 0;
				m_ConnectionPoint.Advise((object)hxSessionEvents_SinkHelper, ref dwCookie);
				hxSessionEvents_SinkHelper.m_dwCookie = dwCookie;
				hxSessionEvents_SinkHelper.m_PrintMergeStatusDelegate = value;
				m_aEventSinkHelpers.Add(hxSessionEvents_SinkHelper);
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
					IHxSessionEvents_SinkHelper hxSessionEvents_SinkHelper = (IHxSessionEvents_SinkHelper)m_aEventSinkHelpers[num];
					if (hxSessionEvents_SinkHelper.m_PrintMergeStatusDelegate == null || !hxSessionEvents_SinkHelper.m_PrintMergeStatusDelegate.Equals(value))
					{
						num++;
						continue;
					}
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(hxSessionEvents_SinkHelper.m_dwCookie);
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

	public event IHxSessionEvents_QueryCancelEventHandler QueryCancel
	{
		add
		{
			lock (this)
			{
				if (m_ConnectionPoint == null)
				{
					Init();
				}
				IHxSessionEvents_SinkHelper hxSessionEvents_SinkHelper = new IHxSessionEvents_SinkHelper();
				int dwCookie = 0;
				m_ConnectionPoint.Advise((object)hxSessionEvents_SinkHelper, ref dwCookie);
				hxSessionEvents_SinkHelper.m_dwCookie = dwCookie;
				hxSessionEvents_SinkHelper.m_QueryCancelDelegate = value;
				m_aEventSinkHelpers.Add(hxSessionEvents_SinkHelper);
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
					IHxSessionEvents_SinkHelper hxSessionEvents_SinkHelper = (IHxSessionEvents_SinkHelper)m_aEventSinkHelpers[num];
					if (hxSessionEvents_SinkHelper.m_QueryCancelDelegate == null || !hxSessionEvents_SinkHelper.m_QueryCancelDelegate.Equals(value))
					{
						num++;
						continue;
					}
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(hxSessionEvents_SinkHelper.m_dwCookie);
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

	public IHxSessionEvents_EventProvider(object obj1)
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
				IHxSessionEvents_SinkHelper hxSessionEvents_SinkHelper = (IHxSessionEvents_SinkHelper)m_aEventSinkHelpers[num];
				m_ConnectionPoint.Unadvise(hxSessionEvents_SinkHelper.m_dwCookie);
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

	~IHxSessionEvents_EventProvider()
	{
		Dispose();
	}

	private void Init()
	{
		UCOMIConnectionPoint connectionPoint = null;
		byte[] b = new byte[16]
		{
			237, 17, 65, 49, 2, 165, 210, 17, 187, 202,
			0, 192, 79, 142, 194, 148
		};
		Guid guid = new Guid(b);
		m_ConnectionPointContainer.FindConnectionPoint(ref guid, ref connectionPoint);
		m_ConnectionPoint = connectionPoint;
		m_aEventSinkHelpers = new ArrayList();
	}
}
