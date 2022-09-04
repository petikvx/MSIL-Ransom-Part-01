using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace SHDocVw;

internal sealed class DWebBrowserEvents_EventProvider : IDisposable, DWebBrowserEvents_Event
{
	private IConnectionPointContainer m_ConnectionPointContainer;

	private ArrayList m_aEventSinkHelpers;

	private IConnectionPoint m_ConnectionPoint;

	public override event DWebBrowserEvents_BeforeNavigateEventHandler BeforeNavigate
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
				DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper = new DWebBrowserEvents_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(dWebBrowserEvents_SinkHelper, out pdwCookie);
				dWebBrowserEvents_SinkHelper.m_dwCookie = pdwCookie;
				dWebBrowserEvents_SinkHelper.m_BeforeNavigateDelegate = value;
				m_aEventSinkHelpers.Add(dWebBrowserEvents_SinkHelper);
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
				DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper;
				while (true)
				{
					dWebBrowserEvents_SinkHelper = (DWebBrowserEvents_SinkHelper)m_aEventSinkHelpers[num];
					if (dWebBrowserEvents_SinkHelper.m_BeforeNavigateDelegate == null || ((dWebBrowserEvents_SinkHelper.m_BeforeNavigateDelegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
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
				m_ConnectionPoint.Unadvise(dWebBrowserEvents_SinkHelper.m_dwCookie);
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

	public override event DWebBrowserEvents_NavigateCompleteEventHandler NavigateComplete
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
				DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper = new DWebBrowserEvents_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(dWebBrowserEvents_SinkHelper, out pdwCookie);
				dWebBrowserEvents_SinkHelper.m_dwCookie = pdwCookie;
				dWebBrowserEvents_SinkHelper.m_NavigateCompleteDelegate = value;
				m_aEventSinkHelpers.Add(dWebBrowserEvents_SinkHelper);
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
				DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper;
				while (true)
				{
					dWebBrowserEvents_SinkHelper = (DWebBrowserEvents_SinkHelper)m_aEventSinkHelpers[num];
					if (dWebBrowserEvents_SinkHelper.m_NavigateCompleteDelegate == null || ((dWebBrowserEvents_SinkHelper.m_NavigateCompleteDelegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
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
				m_ConnectionPoint.Unadvise(dWebBrowserEvents_SinkHelper.m_dwCookie);
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

	public override event DWebBrowserEvents_StatusTextChangeEventHandler StatusTextChange
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
				DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper = new DWebBrowserEvents_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(dWebBrowserEvents_SinkHelper, out pdwCookie);
				dWebBrowserEvents_SinkHelper.m_dwCookie = pdwCookie;
				dWebBrowserEvents_SinkHelper.m_StatusTextChangeDelegate = value;
				m_aEventSinkHelpers.Add(dWebBrowserEvents_SinkHelper);
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
				DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper;
				while (true)
				{
					dWebBrowserEvents_SinkHelper = (DWebBrowserEvents_SinkHelper)m_aEventSinkHelpers[num];
					if (dWebBrowserEvents_SinkHelper.m_StatusTextChangeDelegate == null || ((dWebBrowserEvents_SinkHelper.m_StatusTextChangeDelegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
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
				m_ConnectionPoint.Unadvise(dWebBrowserEvents_SinkHelper.m_dwCookie);
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

	public override event DWebBrowserEvents_ProgressChangeEventHandler ProgressChange
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
				DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper = new DWebBrowserEvents_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(dWebBrowserEvents_SinkHelper, out pdwCookie);
				dWebBrowserEvents_SinkHelper.m_dwCookie = pdwCookie;
				dWebBrowserEvents_SinkHelper.m_ProgressChangeDelegate = value;
				m_aEventSinkHelpers.Add(dWebBrowserEvents_SinkHelper);
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
				DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper;
				while (true)
				{
					dWebBrowserEvents_SinkHelper = (DWebBrowserEvents_SinkHelper)m_aEventSinkHelpers[num];
					if (dWebBrowserEvents_SinkHelper.m_ProgressChangeDelegate == null || ((dWebBrowserEvents_SinkHelper.m_ProgressChangeDelegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
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
				m_ConnectionPoint.Unadvise(dWebBrowserEvents_SinkHelper.m_dwCookie);
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

	public override event DWebBrowserEvents_DownloadCompleteEventHandler DownloadComplete
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
				DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper = new DWebBrowserEvents_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(dWebBrowserEvents_SinkHelper, out pdwCookie);
				dWebBrowserEvents_SinkHelper.m_dwCookie = pdwCookie;
				dWebBrowserEvents_SinkHelper.m_DownloadCompleteDelegate = value;
				m_aEventSinkHelpers.Add(dWebBrowserEvents_SinkHelper);
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
				DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper;
				while (true)
				{
					dWebBrowserEvents_SinkHelper = (DWebBrowserEvents_SinkHelper)m_aEventSinkHelpers[num];
					if (dWebBrowserEvents_SinkHelper.m_DownloadCompleteDelegate == null || ((dWebBrowserEvents_SinkHelper.m_DownloadCompleteDelegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
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
				m_ConnectionPoint.Unadvise(dWebBrowserEvents_SinkHelper.m_dwCookie);
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

	public override event DWebBrowserEvents_CommandStateChangeEventHandler CommandStateChange
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
				DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper = new DWebBrowserEvents_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(dWebBrowserEvents_SinkHelper, out pdwCookie);
				dWebBrowserEvents_SinkHelper.m_dwCookie = pdwCookie;
				dWebBrowserEvents_SinkHelper.m_CommandStateChangeDelegate = value;
				m_aEventSinkHelpers.Add(dWebBrowserEvents_SinkHelper);
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
				DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper;
				while (true)
				{
					dWebBrowserEvents_SinkHelper = (DWebBrowserEvents_SinkHelper)m_aEventSinkHelpers[num];
					if (dWebBrowserEvents_SinkHelper.m_CommandStateChangeDelegate == null || ((dWebBrowserEvents_SinkHelper.m_CommandStateChangeDelegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
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
				m_ConnectionPoint.Unadvise(dWebBrowserEvents_SinkHelper.m_dwCookie);
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

	public override event DWebBrowserEvents_DownloadBeginEventHandler DownloadBegin
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
				DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper = new DWebBrowserEvents_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(dWebBrowserEvents_SinkHelper, out pdwCookie);
				dWebBrowserEvents_SinkHelper.m_dwCookie = pdwCookie;
				dWebBrowserEvents_SinkHelper.m_DownloadBeginDelegate = value;
				m_aEventSinkHelpers.Add(dWebBrowserEvents_SinkHelper);
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
				DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper;
				while (true)
				{
					dWebBrowserEvents_SinkHelper = (DWebBrowserEvents_SinkHelper)m_aEventSinkHelpers[num];
					if (dWebBrowserEvents_SinkHelper.m_DownloadBeginDelegate == null || ((dWebBrowserEvents_SinkHelper.m_DownloadBeginDelegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
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
				m_ConnectionPoint.Unadvise(dWebBrowserEvents_SinkHelper.m_dwCookie);
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

	public override event DWebBrowserEvents_NewWindowEventHandler NewWindow
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
				DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper = new DWebBrowserEvents_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(dWebBrowserEvents_SinkHelper, out pdwCookie);
				dWebBrowserEvents_SinkHelper.m_dwCookie = pdwCookie;
				dWebBrowserEvents_SinkHelper.m_NewWindowDelegate = value;
				m_aEventSinkHelpers.Add(dWebBrowserEvents_SinkHelper);
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
				DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper;
				while (true)
				{
					dWebBrowserEvents_SinkHelper = (DWebBrowserEvents_SinkHelper)m_aEventSinkHelpers[num];
					if (dWebBrowserEvents_SinkHelper.m_NewWindowDelegate == null || ((dWebBrowserEvents_SinkHelper.m_NewWindowDelegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
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
				m_ConnectionPoint.Unadvise(dWebBrowserEvents_SinkHelper.m_dwCookie);
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

	public override event DWebBrowserEvents_TitleChangeEventHandler TitleChange
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
				DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper = new DWebBrowserEvents_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(dWebBrowserEvents_SinkHelper, out pdwCookie);
				dWebBrowserEvents_SinkHelper.m_dwCookie = pdwCookie;
				dWebBrowserEvents_SinkHelper.m_TitleChangeDelegate = value;
				m_aEventSinkHelpers.Add(dWebBrowserEvents_SinkHelper);
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
				DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper;
				while (true)
				{
					dWebBrowserEvents_SinkHelper = (DWebBrowserEvents_SinkHelper)m_aEventSinkHelpers[num];
					if (dWebBrowserEvents_SinkHelper.m_TitleChangeDelegate == null || ((dWebBrowserEvents_SinkHelper.m_TitleChangeDelegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
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
				m_ConnectionPoint.Unadvise(dWebBrowserEvents_SinkHelper.m_dwCookie);
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

	public override event DWebBrowserEvents_FrameBeforeNavigateEventHandler FrameBeforeNavigate
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
				DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper = new DWebBrowserEvents_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(dWebBrowserEvents_SinkHelper, out pdwCookie);
				dWebBrowserEvents_SinkHelper.m_dwCookie = pdwCookie;
				dWebBrowserEvents_SinkHelper.m_FrameBeforeNavigateDelegate = value;
				m_aEventSinkHelpers.Add(dWebBrowserEvents_SinkHelper);
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
				DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper;
				while (true)
				{
					dWebBrowserEvents_SinkHelper = (DWebBrowserEvents_SinkHelper)m_aEventSinkHelpers[num];
					if (dWebBrowserEvents_SinkHelper.m_FrameBeforeNavigateDelegate == null || ((dWebBrowserEvents_SinkHelper.m_FrameBeforeNavigateDelegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
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
				m_ConnectionPoint.Unadvise(dWebBrowserEvents_SinkHelper.m_dwCookie);
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

	public override event DWebBrowserEvents_FrameNavigateCompleteEventHandler FrameNavigateComplete
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
				DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper = new DWebBrowserEvents_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(dWebBrowserEvents_SinkHelper, out pdwCookie);
				dWebBrowserEvents_SinkHelper.m_dwCookie = pdwCookie;
				dWebBrowserEvents_SinkHelper.m_FrameNavigateCompleteDelegate = value;
				m_aEventSinkHelpers.Add(dWebBrowserEvents_SinkHelper);
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
				DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper;
				while (true)
				{
					dWebBrowserEvents_SinkHelper = (DWebBrowserEvents_SinkHelper)m_aEventSinkHelpers[num];
					if (dWebBrowserEvents_SinkHelper.m_FrameNavigateCompleteDelegate == null || ((dWebBrowserEvents_SinkHelper.m_FrameNavigateCompleteDelegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
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
				m_ConnectionPoint.Unadvise(dWebBrowserEvents_SinkHelper.m_dwCookie);
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

	public override event DWebBrowserEvents_FrameNewWindowEventHandler FrameNewWindow
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
				DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper = new DWebBrowserEvents_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(dWebBrowserEvents_SinkHelper, out pdwCookie);
				dWebBrowserEvents_SinkHelper.m_dwCookie = pdwCookie;
				dWebBrowserEvents_SinkHelper.m_FrameNewWindowDelegate = value;
				m_aEventSinkHelpers.Add(dWebBrowserEvents_SinkHelper);
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
				DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper;
				while (true)
				{
					dWebBrowserEvents_SinkHelper = (DWebBrowserEvents_SinkHelper)m_aEventSinkHelpers[num];
					if (dWebBrowserEvents_SinkHelper.m_FrameNewWindowDelegate == null || ((dWebBrowserEvents_SinkHelper.m_FrameNewWindowDelegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
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
				m_ConnectionPoint.Unadvise(dWebBrowserEvents_SinkHelper.m_dwCookie);
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

	public override event DWebBrowserEvents_QuitEventHandler Quit
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
				DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper = new DWebBrowserEvents_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(dWebBrowserEvents_SinkHelper, out pdwCookie);
				dWebBrowserEvents_SinkHelper.m_dwCookie = pdwCookie;
				dWebBrowserEvents_SinkHelper.m_QuitDelegate = value;
				m_aEventSinkHelpers.Add(dWebBrowserEvents_SinkHelper);
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
				DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper;
				while (true)
				{
					dWebBrowserEvents_SinkHelper = (DWebBrowserEvents_SinkHelper)m_aEventSinkHelpers[num];
					if (dWebBrowserEvents_SinkHelper.m_QuitDelegate == null || ((dWebBrowserEvents_SinkHelper.m_QuitDelegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
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
				m_ConnectionPoint.Unadvise(dWebBrowserEvents_SinkHelper.m_dwCookie);
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

	public override event DWebBrowserEvents_WindowMoveEventHandler WindowMove
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
				DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper = new DWebBrowserEvents_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(dWebBrowserEvents_SinkHelper, out pdwCookie);
				dWebBrowserEvents_SinkHelper.m_dwCookie = pdwCookie;
				dWebBrowserEvents_SinkHelper.m_WindowMoveDelegate = value;
				m_aEventSinkHelpers.Add(dWebBrowserEvents_SinkHelper);
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
				DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper;
				while (true)
				{
					dWebBrowserEvents_SinkHelper = (DWebBrowserEvents_SinkHelper)m_aEventSinkHelpers[num];
					if (dWebBrowserEvents_SinkHelper.m_WindowMoveDelegate == null || ((dWebBrowserEvents_SinkHelper.m_WindowMoveDelegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
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
				m_ConnectionPoint.Unadvise(dWebBrowserEvents_SinkHelper.m_dwCookie);
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

	public override event DWebBrowserEvents_WindowResizeEventHandler WindowResize
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
				DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper = new DWebBrowserEvents_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(dWebBrowserEvents_SinkHelper, out pdwCookie);
				dWebBrowserEvents_SinkHelper.m_dwCookie = pdwCookie;
				dWebBrowserEvents_SinkHelper.m_WindowResizeDelegate = value;
				m_aEventSinkHelpers.Add(dWebBrowserEvents_SinkHelper);
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
				DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper;
				while (true)
				{
					dWebBrowserEvents_SinkHelper = (DWebBrowserEvents_SinkHelper)m_aEventSinkHelpers[num];
					if (dWebBrowserEvents_SinkHelper.m_WindowResizeDelegate == null || ((dWebBrowserEvents_SinkHelper.m_WindowResizeDelegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
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
				m_ConnectionPoint.Unadvise(dWebBrowserEvents_SinkHelper.m_dwCookie);
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

	public override event DWebBrowserEvents_WindowActivateEventHandler WindowActivate
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
				DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper = new DWebBrowserEvents_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(dWebBrowserEvents_SinkHelper, out pdwCookie);
				dWebBrowserEvents_SinkHelper.m_dwCookie = pdwCookie;
				dWebBrowserEvents_SinkHelper.m_WindowActivateDelegate = value;
				m_aEventSinkHelpers.Add(dWebBrowserEvents_SinkHelper);
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
				DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper;
				while (true)
				{
					dWebBrowserEvents_SinkHelper = (DWebBrowserEvents_SinkHelper)m_aEventSinkHelpers[num];
					if (dWebBrowserEvents_SinkHelper.m_WindowActivateDelegate == null || ((dWebBrowserEvents_SinkHelper.m_WindowActivateDelegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
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
				m_ConnectionPoint.Unadvise(dWebBrowserEvents_SinkHelper.m_dwCookie);
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

	public override event DWebBrowserEvents_PropertyChangeEventHandler PropertyChange
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
				DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper = new DWebBrowserEvents_SinkHelper();
				int pdwCookie = 0;
				m_ConnectionPoint.Advise(dWebBrowserEvents_SinkHelper, out pdwCookie);
				dWebBrowserEvents_SinkHelper.m_dwCookie = pdwCookie;
				dWebBrowserEvents_SinkHelper.m_PropertyChangeDelegate = value;
				m_aEventSinkHelpers.Add(dWebBrowserEvents_SinkHelper);
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
				DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper;
				while (true)
				{
					dWebBrowserEvents_SinkHelper = (DWebBrowserEvents_SinkHelper)m_aEventSinkHelpers[num];
					if (dWebBrowserEvents_SinkHelper.m_PropertyChangeDelegate == null || ((dWebBrowserEvents_SinkHelper.m_PropertyChangeDelegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
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
				m_ConnectionPoint.Unadvise(dWebBrowserEvents_SinkHelper.m_dwCookie);
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
			194, 42, 178, 234, 193, 48, 207, 17, 167, 235,
			0, 0, 192, 91, 174, 11
		});
		m_ConnectionPointContainer.FindConnectionPoint(ref riid, out ppCP);
		m_ConnectionPoint = ppCP;
		m_aEventSinkHelpers = new ArrayList();
	}

	public DWebBrowserEvents_EventProvider(object param0)
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
					DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper = (DWebBrowserEvents_SinkHelper)m_aEventSinkHelpers[num];
					m_ConnectionPoint.Unadvise(dWebBrowserEvents_SinkHelper.m_dwCookie);
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
