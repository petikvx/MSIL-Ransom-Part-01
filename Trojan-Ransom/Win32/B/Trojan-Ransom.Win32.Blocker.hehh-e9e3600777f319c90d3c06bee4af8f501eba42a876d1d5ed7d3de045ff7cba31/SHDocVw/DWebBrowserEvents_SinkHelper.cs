using System.Runtime.InteropServices;

namespace SHDocVw;

[TypeLibType(TypeLibTypeFlags.FHidden)]
[ClassInterface(ClassInterfaceType.None)]
public sealed class DWebBrowserEvents_SinkHelper : DWebBrowserEvents
{
	public DWebBrowserEvents_BeforeNavigateEventHandler m_BeforeNavigateDelegate;

	public DWebBrowserEvents_NavigateCompleteEventHandler m_NavigateCompleteDelegate;

	public DWebBrowserEvents_StatusTextChangeEventHandler m_StatusTextChangeDelegate;

	public DWebBrowserEvents_ProgressChangeEventHandler m_ProgressChangeDelegate;

	public DWebBrowserEvents_DownloadCompleteEventHandler m_DownloadCompleteDelegate;

	public DWebBrowserEvents_CommandStateChangeEventHandler m_CommandStateChangeDelegate;

	public DWebBrowserEvents_DownloadBeginEventHandler m_DownloadBeginDelegate;

	public DWebBrowserEvents_NewWindowEventHandler m_NewWindowDelegate;

	public DWebBrowserEvents_TitleChangeEventHandler m_TitleChangeDelegate;

	public DWebBrowserEvents_FrameBeforeNavigateEventHandler m_FrameBeforeNavigateDelegate;

	public DWebBrowserEvents_FrameNavigateCompleteEventHandler m_FrameNavigateCompleteDelegate;

	public DWebBrowserEvents_FrameNewWindowEventHandler m_FrameNewWindowDelegate;

	public DWebBrowserEvents_QuitEventHandler m_QuitDelegate;

	public DWebBrowserEvents_WindowMoveEventHandler m_WindowMoveDelegate;

	public DWebBrowserEvents_WindowResizeEventHandler m_WindowResizeDelegate;

	public DWebBrowserEvents_WindowActivateEventHandler m_WindowActivateDelegate;

	public DWebBrowserEvents_PropertyChangeEventHandler m_PropertyChangeDelegate;

	public int m_dwCookie;

	public override void BeforeNavigate(string param0, int param1, string param2, ref object param3, string param4, ref bool param5)
	{
		if (m_BeforeNavigateDelegate != null)
		{
			m_BeforeNavigateDelegate(param0, param1, param2, ref param3, param4, ref param5);
		}
	}

	public override void NavigateComplete(string param0)
	{
		if (m_NavigateCompleteDelegate != null)
		{
			m_NavigateCompleteDelegate(param0);
		}
	}

	public override void StatusTextChange(string param0)
	{
		if (m_StatusTextChangeDelegate != null)
		{
			m_StatusTextChangeDelegate(param0);
		}
	}

	public override void ProgressChange(int param0, int param1)
	{
		if (m_ProgressChangeDelegate != null)
		{
			m_ProgressChangeDelegate(param0, param1);
		}
	}

	public override void DownloadComplete()
	{
		if (m_DownloadCompleteDelegate != null)
		{
			m_DownloadCompleteDelegate();
		}
	}

	public override void CommandStateChange(int param0, bool param1)
	{
		if (m_CommandStateChangeDelegate != null)
		{
			m_CommandStateChangeDelegate(param0, param1);
		}
	}

	public override void DownloadBegin()
	{
		if (m_DownloadBeginDelegate != null)
		{
			m_DownloadBeginDelegate();
		}
	}

	public override void NewWindow(string param0, int param1, string param2, ref object param3, string param4, ref bool param5)
	{
		if (m_NewWindowDelegate != null)
		{
			m_NewWindowDelegate(param0, param1, param2, ref param3, param4, ref param5);
		}
	}

	public override void TitleChange(string param0)
	{
		if (m_TitleChangeDelegate != null)
		{
			m_TitleChangeDelegate(param0);
		}
	}

	public override void FrameBeforeNavigate(string param0, int param1, string param2, ref object param3, string param4, ref bool param5)
	{
		if (m_FrameBeforeNavigateDelegate != null)
		{
			m_FrameBeforeNavigateDelegate(param0, param1, param2, ref param3, param4, ref param5);
		}
	}

	public override void FrameNavigateComplete(string param0)
	{
		if (m_FrameNavigateCompleteDelegate != null)
		{
			m_FrameNavigateCompleteDelegate(param0);
		}
	}

	public override void FrameNewWindow(string param0, int param1, string param2, ref object param3, string param4, ref bool param5)
	{
		if (m_FrameNewWindowDelegate != null)
		{
			m_FrameNewWindowDelegate(param0, param1, param2, ref param3, param4, ref param5);
		}
	}

	public override void Quit(ref bool param0)
	{
		if (m_QuitDelegate != null)
		{
			m_QuitDelegate(ref param0);
		}
	}

	public override void WindowMove()
	{
		if (m_WindowMoveDelegate != null)
		{
			m_WindowMoveDelegate();
		}
	}

	public override void WindowResize()
	{
		if (m_WindowResizeDelegate != null)
		{
			m_WindowResizeDelegate();
		}
	}

	public override void WindowActivate()
	{
		if (m_WindowActivateDelegate != null)
		{
			m_WindowActivateDelegate();
		}
	}

	public override void PropertyChange(string param0)
	{
		if (m_PropertyChangeDelegate != null)
		{
			m_PropertyChangeDelegate(param0);
		}
	}

	internal DWebBrowserEvents_SinkHelper()
	{
		m_dwCookie = 0;
		m_BeforeNavigateDelegate = null;
		m_NavigateCompleteDelegate = null;
		m_StatusTextChangeDelegate = null;
		m_ProgressChangeDelegate = null;
		m_DownloadCompleteDelegate = null;
		m_CommandStateChangeDelegate = null;
		m_DownloadBeginDelegate = null;
		m_NewWindowDelegate = null;
		m_TitleChangeDelegate = null;
		m_FrameBeforeNavigateDelegate = null;
		m_FrameNavigateCompleteDelegate = null;
		m_FrameNewWindowDelegate = null;
		m_QuitDelegate = null;
		m_WindowMoveDelegate = null;
		m_WindowResizeDelegate = null;
		m_WindowActivateDelegate = null;
		m_PropertyChangeDelegate = null;
	}
}
