using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace SHDocVw;

internal sealed class DWebBrowserEvents2_EventProvider : IDisposable, DWebBrowserEvents2_Event
{
	private IConnectionPointContainer m_ConnectionPointContainer;

	private ArrayList m_aEventSinkHelpers;

	private IConnectionPoint m_ConnectionPoint;

	public override event DWebBrowserEvents2_StatusTextChangeEventHandler StatusTextChange
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
				dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
				dWebBrowserEvents2_SinkHelper.m_StatusTextChangeDelegate = value;
				m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper;
				while (true)
				{
					dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
					if (dWebBrowserEvents2_SinkHelper.m_StatusTextChangeDelegate == null || ((dWebBrowserEvents2_SinkHelper.m_StatusTextChangeDelegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
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
				m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public override event DWebBrowserEvents2_ProgressChangeEventHandler ProgressChange
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
				dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
				dWebBrowserEvents2_SinkHelper.m_ProgressChangeDelegate = value;
				m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper;
				while (true)
				{
					dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
					if (dWebBrowserEvents2_SinkHelper.m_ProgressChangeDelegate == null || ((dWebBrowserEvents2_SinkHelper.m_ProgressChangeDelegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
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
				m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public override event DWebBrowserEvents2_CommandStateChangeEventHandler CommandStateChange
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
				dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
				dWebBrowserEvents2_SinkHelper.m_CommandStateChangeDelegate = value;
				m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper;
				while (true)
				{
					dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
					if (dWebBrowserEvents2_SinkHelper.m_CommandStateChangeDelegate == null || ((dWebBrowserEvents2_SinkHelper.m_CommandStateChangeDelegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
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
				m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public override event DWebBrowserEvents2_DownloadBeginEventHandler DownloadBegin
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
				dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
				dWebBrowserEvents2_SinkHelper.m_DownloadBeginDelegate = value;
				m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper;
				while (true)
				{
					dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
					if (dWebBrowserEvents2_SinkHelper.m_DownloadBeginDelegate == null || ((dWebBrowserEvents2_SinkHelper.m_DownloadBeginDelegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
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
				m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public override event DWebBrowserEvents2_DownloadCompleteEventHandler DownloadComplete
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
				dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
				dWebBrowserEvents2_SinkHelper.m_DownloadCompleteDelegate = value;
				m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper;
				while (true)
				{
					dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
					if (dWebBrowserEvents2_SinkHelper.m_DownloadCompleteDelegate == null || ((dWebBrowserEvents2_SinkHelper.m_DownloadCompleteDelegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
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
				m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public override event DWebBrowserEvents2_TitleChangeEventHandler TitleChange
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
				dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
				dWebBrowserEvents2_SinkHelper.m_TitleChangeDelegate = value;
				m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper;
				while (true)
				{
					dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
					if (dWebBrowserEvents2_SinkHelper.m_TitleChangeDelegate == null || ((dWebBrowserEvents2_SinkHelper.m_TitleChangeDelegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
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
				m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public override event DWebBrowserEvents2_PropertyChangeEventHandler PropertyChange
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
				dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
				dWebBrowserEvents2_SinkHelper.m_PropertyChangeDelegate = value;
				m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper;
				while (true)
				{
					dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
					if (dWebBrowserEvents2_SinkHelper.m_PropertyChangeDelegate == null || ((dWebBrowserEvents2_SinkHelper.m_PropertyChangeDelegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
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
				m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public override event DWebBrowserEvents2_BeforeNavigate2EventHandler BeforeNavigate2
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
				dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
				dWebBrowserEvents2_SinkHelper.m_BeforeNavigate2Delegate = value;
				m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper;
				while (true)
				{
					dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
					if (dWebBrowserEvents2_SinkHelper.m_BeforeNavigate2Delegate == null || ((dWebBrowserEvents2_SinkHelper.m_BeforeNavigate2Delegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
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
				m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public override event DWebBrowserEvents2_NewWindow2EventHandler NewWindow2
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
				dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
				dWebBrowserEvents2_SinkHelper.m_NewWindow2Delegate = value;
				m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper;
				while (true)
				{
					dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
					if (dWebBrowserEvents2_SinkHelper.m_NewWindow2Delegate == null || ((dWebBrowserEvents2_SinkHelper.m_NewWindow2Delegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
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
				m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public override event DWebBrowserEvents2_NavigateComplete2EventHandler NavigateComplete2
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
				dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
				dWebBrowserEvents2_SinkHelper.m_NavigateComplete2Delegate = value;
				m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper;
				while (true)
				{
					dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
					if (dWebBrowserEvents2_SinkHelper.m_NavigateComplete2Delegate == null || ((dWebBrowserEvents2_SinkHelper.m_NavigateComplete2Delegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
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
				m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public override event DWebBrowserEvents2_DocumentCompleteEventHandler DocumentComplete
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
				dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
				dWebBrowserEvents2_SinkHelper.m_DocumentCompleteDelegate = value;
				m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper;
				while (true)
				{
					dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
					if (dWebBrowserEvents2_SinkHelper.m_DocumentCompleteDelegate == null || ((dWebBrowserEvents2_SinkHelper.m_DocumentCompleteDelegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
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
				m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public override event DWebBrowserEvents2_OnQuitEventHandler OnQuit
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
				dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
				dWebBrowserEvents2_SinkHelper.m_OnQuitDelegate = value;
				m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper;
				while (true)
				{
					dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
					if (dWebBrowserEvents2_SinkHelper.m_OnQuitDelegate == null || ((dWebBrowserEvents2_SinkHelper.m_OnQuitDelegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
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
				m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public override event DWebBrowserEvents2_OnVisibleEventHandler OnVisible
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
				dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
				dWebBrowserEvents2_SinkHelper.m_OnVisibleDelegate = value;
				m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper;
				while (true)
				{
					dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
					if (dWebBrowserEvents2_SinkHelper.m_OnVisibleDelegate == null || ((dWebBrowserEvents2_SinkHelper.m_OnVisibleDelegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
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
				m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public override event DWebBrowserEvents2_OnToolBarEventHandler OnToolBar
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
				dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
				dWebBrowserEvents2_SinkHelper.m_OnToolBarDelegate = value;
				m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper;
				while (true)
				{
					dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
					if (dWebBrowserEvents2_SinkHelper.m_OnToolBarDelegate == null || ((dWebBrowserEvents2_SinkHelper.m_OnToolBarDelegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
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
				m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public override event DWebBrowserEvents2_OnMenuBarEventHandler OnMenuBar
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
				dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
				dWebBrowserEvents2_SinkHelper.m_OnMenuBarDelegate = value;
				m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper;
				while (true)
				{
					dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
					if (dWebBrowserEvents2_SinkHelper.m_OnMenuBarDelegate == null || ((dWebBrowserEvents2_SinkHelper.m_OnMenuBarDelegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
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
				m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public override event DWebBrowserEvents2_OnStatusBarEventHandler OnStatusBar
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
				dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
				dWebBrowserEvents2_SinkHelper.m_OnStatusBarDelegate = value;
				m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper;
				while (true)
				{
					dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
					if (dWebBrowserEvents2_SinkHelper.m_OnStatusBarDelegate == null || ((dWebBrowserEvents2_SinkHelper.m_OnStatusBarDelegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
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
				m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public override event DWebBrowserEvents2_OnFullScreenEventHandler OnFullScreen
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
				dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
				dWebBrowserEvents2_SinkHelper.m_OnFullScreenDelegate = value;
				m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper;
				while (true)
				{
					dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
					if (dWebBrowserEvents2_SinkHelper.m_OnFullScreenDelegate == null || ((dWebBrowserEvents2_SinkHelper.m_OnFullScreenDelegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
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
				m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public override event DWebBrowserEvents2_OnTheaterModeEventHandler OnTheaterMode
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
				dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
				dWebBrowserEvents2_SinkHelper.m_OnTheaterModeDelegate = value;
				m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper;
				while (true)
				{
					dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
					if (dWebBrowserEvents2_SinkHelper.m_OnTheaterModeDelegate == null || ((dWebBrowserEvents2_SinkHelper.m_OnTheaterModeDelegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
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
				m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public override event DWebBrowserEvents2_WindowSetResizableEventHandler WindowSetResizable
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
				dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
				dWebBrowserEvents2_SinkHelper.m_WindowSetResizableDelegate = value;
				m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper;
				while (true)
				{
					dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
					if (dWebBrowserEvents2_SinkHelper.m_WindowSetResizableDelegate == null || ((dWebBrowserEvents2_SinkHelper.m_WindowSetResizableDelegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
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
				m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public override event DWebBrowserEvents2_WindowSetLeftEventHandler WindowSetLeft
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
				dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
				dWebBrowserEvents2_SinkHelper.m_WindowSetLeftDelegate = value;
				m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper;
				while (true)
				{
					dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
					if (dWebBrowserEvents2_SinkHelper.m_WindowSetLeftDelegate == null || ((dWebBrowserEvents2_SinkHelper.m_WindowSetLeftDelegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
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
				m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public override event DWebBrowserEvents2_WindowSetTopEventHandler WindowSetTop
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
				dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
				dWebBrowserEvents2_SinkHelper.m_WindowSetTopDelegate = value;
				m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper;
				while (true)
				{
					dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
					if (dWebBrowserEvents2_SinkHelper.m_WindowSetTopDelegate == null || ((dWebBrowserEvents2_SinkHelper.m_WindowSetTopDelegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
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
				m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public override event DWebBrowserEvents2_WindowSetWidthEventHandler WindowSetWidth
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
				dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
				dWebBrowserEvents2_SinkHelper.m_WindowSetWidthDelegate = value;
				m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper;
				while (true)
				{
					dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
					if (dWebBrowserEvents2_SinkHelper.m_WindowSetWidthDelegate == null || ((dWebBrowserEvents2_SinkHelper.m_WindowSetWidthDelegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
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
				m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public override event DWebBrowserEvents2_WindowSetHeightEventHandler WindowSetHeight
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
				dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
				dWebBrowserEvents2_SinkHelper.m_WindowSetHeightDelegate = value;
				m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper;
				while (true)
				{
					dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
					if (dWebBrowserEvents2_SinkHelper.m_WindowSetHeightDelegate == null || ((dWebBrowserEvents2_SinkHelper.m_WindowSetHeightDelegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
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
				m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public override event DWebBrowserEvents2_WindowClosingEventHandler WindowClosing
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
				dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
				dWebBrowserEvents2_SinkHelper.m_WindowClosingDelegate = value;
				m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper;
				while (true)
				{
					dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
					if (dWebBrowserEvents2_SinkHelper.m_WindowClosingDelegate == null || ((dWebBrowserEvents2_SinkHelper.m_WindowClosingDelegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
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
				m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public override event DWebBrowserEvents2_ClientToHostWindowEventHandler ClientToHostWindow
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
				dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
				dWebBrowserEvents2_SinkHelper.m_ClientToHostWindowDelegate = value;
				m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper;
				while (true)
				{
					dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
					if (dWebBrowserEvents2_SinkHelper.m_ClientToHostWindowDelegate == null || ((dWebBrowserEvents2_SinkHelper.m_ClientToHostWindowDelegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
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
				m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public override event DWebBrowserEvents2_SetSecureLockIconEventHandler SetSecureLockIcon
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
				dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
				dWebBrowserEvents2_SinkHelper.m_SetSecureLockIconDelegate = value;
				m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper;
				while (true)
				{
					dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
					if (dWebBrowserEvents2_SinkHelper.m_SetSecureLockIconDelegate == null || ((dWebBrowserEvents2_SinkHelper.m_SetSecureLockIconDelegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
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
				m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public override event DWebBrowserEvents2_FileDownloadEventHandler FileDownload
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
				dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
				dWebBrowserEvents2_SinkHelper.m_FileDownloadDelegate = value;
				m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper;
				while (true)
				{
					dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
					if (dWebBrowserEvents2_SinkHelper.m_FileDownloadDelegate == null || ((dWebBrowserEvents2_SinkHelper.m_FileDownloadDelegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
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
				m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public override event DWebBrowserEvents2_NavigateErrorEventHandler NavigateError
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
				dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
				dWebBrowserEvents2_SinkHelper.m_NavigateErrorDelegate = value;
				m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper;
				while (true)
				{
					dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
					if (dWebBrowserEvents2_SinkHelper.m_NavigateErrorDelegate == null || ((dWebBrowserEvents2_SinkHelper.m_NavigateErrorDelegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
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
				m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public override event DWebBrowserEvents2_PrintTemplateInstantiationEventHandler PrintTemplateInstantiation
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
				dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
				dWebBrowserEvents2_SinkHelper.m_PrintTemplateInstantiationDelegate = value;
				m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper;
				while (true)
				{
					dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
					if (dWebBrowserEvents2_SinkHelper.m_PrintTemplateInstantiationDelegate == null || ((dWebBrowserEvents2_SinkHelper.m_PrintTemplateInstantiationDelegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
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
				m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public override event DWebBrowserEvents2_PrintTemplateTeardownEventHandler PrintTemplateTeardown
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
				dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
				dWebBrowserEvents2_SinkHelper.m_PrintTemplateTeardownDelegate = value;
				m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper;
				while (true)
				{
					dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
					if (dWebBrowserEvents2_SinkHelper.m_PrintTemplateTeardownDelegate == null || ((dWebBrowserEvents2_SinkHelper.m_PrintTemplateTeardownDelegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
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
				m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public override event DWebBrowserEvents2_UpdatePageStatusEventHandler UpdatePageStatus
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
				dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
				dWebBrowserEvents2_SinkHelper.m_UpdatePageStatusDelegate = value;
				m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper;
				while (true)
				{
					dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
					if (dWebBrowserEvents2_SinkHelper.m_UpdatePageStatusDelegate == null || ((dWebBrowserEvents2_SinkHelper.m_UpdatePageStatusDelegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
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
				m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public override event DWebBrowserEvents2_PrivacyImpactedStateChangeEventHandler PrivacyImpactedStateChange
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
				dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
				dWebBrowserEvents2_SinkHelper.m_PrivacyImpactedStateChangeDelegate = value;
				m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper;
				while (true)
				{
					dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
					if (dWebBrowserEvents2_SinkHelper.m_PrivacyImpactedStateChangeDelegate == null || ((dWebBrowserEvents2_SinkHelper.m_PrivacyImpactedStateChangeDelegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
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
				m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public override event DWebBrowserEvents2_NewWindow3EventHandler NewWindow3
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
				dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
				dWebBrowserEvents2_SinkHelper.m_NewWindow3Delegate = value;
				m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper;
				while (true)
				{
					dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
					if (dWebBrowserEvents2_SinkHelper.m_NewWindow3Delegate == null || ((dWebBrowserEvents2_SinkHelper.m_NewWindow3Delegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
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
				m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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
			160, 21, 167, 52, 135, 101, 208, 17, 146, 74,
			0, 32, 175, 199, 172, 77
		});
		m_ConnectionPointContainer.FindConnectionPoint(ref riid, out ppCP);
		m_ConnectionPoint = ppCP;
		m_aEventSinkHelpers = new ArrayList();
	}

	public DWebBrowserEvents2_EventProvider(object param0)
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
					DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
					m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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
