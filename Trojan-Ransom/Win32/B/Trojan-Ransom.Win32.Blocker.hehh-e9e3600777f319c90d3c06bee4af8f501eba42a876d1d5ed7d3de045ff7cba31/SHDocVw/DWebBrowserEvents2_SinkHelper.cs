using System.Runtime.InteropServices;

namespace SHDocVw;

[ClassInterface(ClassInterfaceType.None)]
[TypeLibType(TypeLibTypeFlags.FHidden)]
public sealed class DWebBrowserEvents2_SinkHelper : DWebBrowserEvents2
{
	public DWebBrowserEvents2_NewWindow3EventHandler m_NewWindow3Delegate;

	public DWebBrowserEvents2_StatusTextChangeEventHandler m_StatusTextChangeDelegate;

	public DWebBrowserEvents2_ProgressChangeEventHandler m_ProgressChangeDelegate;

	public DWebBrowserEvents2_CommandStateChangeEventHandler m_CommandStateChangeDelegate;

	public DWebBrowserEvents2_DownloadBeginEventHandler m_DownloadBeginDelegate;

	public DWebBrowserEvents2_DownloadCompleteEventHandler m_DownloadCompleteDelegate;

	public DWebBrowserEvents2_TitleChangeEventHandler m_TitleChangeDelegate;

	public DWebBrowserEvents2_PropertyChangeEventHandler m_PropertyChangeDelegate;

	public DWebBrowserEvents2_BeforeNavigate2EventHandler m_BeforeNavigate2Delegate;

	public DWebBrowserEvents2_NewWindow2EventHandler m_NewWindow2Delegate;

	public DWebBrowserEvents2_NavigateComplete2EventHandler m_NavigateComplete2Delegate;

	public DWebBrowserEvents2_DocumentCompleteEventHandler m_DocumentCompleteDelegate;

	public DWebBrowserEvents2_OnQuitEventHandler m_OnQuitDelegate;

	public DWebBrowserEvents2_OnVisibleEventHandler m_OnVisibleDelegate;

	public DWebBrowserEvents2_OnToolBarEventHandler m_OnToolBarDelegate;

	public DWebBrowserEvents2_OnMenuBarEventHandler m_OnMenuBarDelegate;

	public DWebBrowserEvents2_OnStatusBarEventHandler m_OnStatusBarDelegate;

	public DWebBrowserEvents2_OnFullScreenEventHandler m_OnFullScreenDelegate;

	public DWebBrowserEvents2_OnTheaterModeEventHandler m_OnTheaterModeDelegate;

	public DWebBrowserEvents2_WindowSetResizableEventHandler m_WindowSetResizableDelegate;

	public DWebBrowserEvents2_WindowSetLeftEventHandler m_WindowSetLeftDelegate;

	public DWebBrowserEvents2_WindowSetTopEventHandler m_WindowSetTopDelegate;

	public DWebBrowserEvents2_WindowSetWidthEventHandler m_WindowSetWidthDelegate;

	public DWebBrowserEvents2_WindowSetHeightEventHandler m_WindowSetHeightDelegate;

	public DWebBrowserEvents2_WindowClosingEventHandler m_WindowClosingDelegate;

	public DWebBrowserEvents2_ClientToHostWindowEventHandler m_ClientToHostWindowDelegate;

	public DWebBrowserEvents2_SetSecureLockIconEventHandler m_SetSecureLockIconDelegate;

	public DWebBrowserEvents2_FileDownloadEventHandler m_FileDownloadDelegate;

	public DWebBrowserEvents2_NavigateErrorEventHandler m_NavigateErrorDelegate;

	public DWebBrowserEvents2_PrintTemplateInstantiationEventHandler m_PrintTemplateInstantiationDelegate;

	public DWebBrowserEvents2_PrintTemplateTeardownEventHandler m_PrintTemplateTeardownDelegate;

	public DWebBrowserEvents2_UpdatePageStatusEventHandler m_UpdatePageStatusDelegate;

	public DWebBrowserEvents2_PrivacyImpactedStateChangeEventHandler m_PrivacyImpactedStateChangeDelegate;

	public int m_dwCookie;

	public override void NewWindow3(ref object param0, ref bool param1, uint param2, string param3, string param4)
	{
		if (m_NewWindow3Delegate != null)
		{
			m_NewWindow3Delegate(ref param0, ref param1, param2, param3, param4);
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

	public override void DownloadComplete()
	{
		if (m_DownloadCompleteDelegate != null)
		{
			m_DownloadCompleteDelegate();
		}
	}

	public override void TitleChange(string param0)
	{
		if (m_TitleChangeDelegate != null)
		{
			m_TitleChangeDelegate(param0);
		}
	}

	public override void PropertyChange(string param0)
	{
		if (m_PropertyChangeDelegate != null)
		{
			m_PropertyChangeDelegate(param0);
		}
	}

	public override void BeforeNavigate2(object param0, ref object param1, ref object param2, ref object param3, ref object param4, ref object param5, ref bool param6)
	{
		if (m_BeforeNavigate2Delegate != null)
		{
			m_BeforeNavigate2Delegate(param0, ref param1, ref param2, ref param3, ref param4, ref param5, ref param6);
		}
	}

	public override void NewWindow2(ref object param0, ref bool param1)
	{
		if (m_NewWindow2Delegate != null)
		{
			m_NewWindow2Delegate(ref param0, ref param1);
		}
	}

	public override void NavigateComplete2(object param0, ref object param1)
	{
		if (m_NavigateComplete2Delegate != null)
		{
			m_NavigateComplete2Delegate(param0, ref param1);
		}
	}

	public override void DocumentComplete(object param0, ref object param1)
	{
		if (m_DocumentCompleteDelegate != null)
		{
			m_DocumentCompleteDelegate(param0, ref param1);
		}
	}

	public override void OnQuit()
	{
		if (m_OnQuitDelegate != null)
		{
			m_OnQuitDelegate();
		}
	}

	public override void OnVisible(bool param0)
	{
		if (m_OnVisibleDelegate != null)
		{
			m_OnVisibleDelegate(param0);
		}
	}

	public override void OnToolBar(bool param0)
	{
		if (m_OnToolBarDelegate != null)
		{
			m_OnToolBarDelegate(param0);
		}
	}

	public override void OnMenuBar(bool param0)
	{
		if (m_OnMenuBarDelegate != null)
		{
			m_OnMenuBarDelegate(param0);
		}
	}

	public override void OnStatusBar(bool param0)
	{
		if (m_OnStatusBarDelegate != null)
		{
			m_OnStatusBarDelegate(param0);
		}
	}

	public override void OnFullScreen(bool param0)
	{
		if (m_OnFullScreenDelegate != null)
		{
			m_OnFullScreenDelegate(param0);
		}
	}

	public override void OnTheaterMode(bool param0)
	{
		if (m_OnTheaterModeDelegate != null)
		{
			m_OnTheaterModeDelegate(param0);
		}
	}

	public override void WindowSetResizable(bool param0)
	{
		if (m_WindowSetResizableDelegate != null)
		{
			m_WindowSetResizableDelegate(param0);
		}
	}

	public override void WindowSetLeft(int param0)
	{
		if (m_WindowSetLeftDelegate != null)
		{
			m_WindowSetLeftDelegate(param0);
		}
	}

	public override void WindowSetTop(int param0)
	{
		if (m_WindowSetTopDelegate != null)
		{
			m_WindowSetTopDelegate(param0);
		}
	}

	public override void WindowSetWidth(int param0)
	{
		if (m_WindowSetWidthDelegate != null)
		{
			m_WindowSetWidthDelegate(param0);
		}
	}

	public override void WindowSetHeight(int param0)
	{
		if (m_WindowSetHeightDelegate != null)
		{
			m_WindowSetHeightDelegate(param0);
		}
	}

	public override void WindowClosing(bool param0, ref bool param1)
	{
		if (m_WindowClosingDelegate != null)
		{
			m_WindowClosingDelegate(param0, ref param1);
		}
	}

	public override void ClientToHostWindow(ref int param0, ref int param1)
	{
		if (m_ClientToHostWindowDelegate != null)
		{
			m_ClientToHostWindowDelegate(ref param0, ref param1);
		}
	}

	public override void SetSecureLockIcon(int param0)
	{
		if (m_SetSecureLockIconDelegate != null)
		{
			m_SetSecureLockIconDelegate(param0);
		}
	}

	public override void FileDownload(ref bool param0)
	{
		if (m_FileDownloadDelegate != null)
		{
			m_FileDownloadDelegate(ref param0);
		}
	}

	public override void NavigateError(object param0, ref object param1, ref object param2, ref object param3, ref bool param4)
	{
		if (m_NavigateErrorDelegate != null)
		{
			m_NavigateErrorDelegate(param0, ref param1, ref param2, ref param3, ref param4);
		}
	}

	public override void PrintTemplateInstantiation(object param0)
	{
		if (m_PrintTemplateInstantiationDelegate != null)
		{
			m_PrintTemplateInstantiationDelegate(param0);
		}
	}

	public override void PrintTemplateTeardown(object param0)
	{
		if (m_PrintTemplateTeardownDelegate != null)
		{
			m_PrintTemplateTeardownDelegate(param0);
		}
	}

	public override void UpdatePageStatus(object param0, ref object param1, ref object param2)
	{
		if (m_UpdatePageStatusDelegate != null)
		{
			m_UpdatePageStatusDelegate(param0, ref param1, ref param2);
		}
	}

	public override void PrivacyImpactedStateChange(bool param0)
	{
		if (m_PrivacyImpactedStateChangeDelegate != null)
		{
			m_PrivacyImpactedStateChangeDelegate(param0);
		}
	}

	internal DWebBrowserEvents2_SinkHelper()
	{
		m_dwCookie = 0;
		m_NewWindow3Delegate = null;
		m_StatusTextChangeDelegate = null;
		m_ProgressChangeDelegate = null;
		m_CommandStateChangeDelegate = null;
		m_DownloadBeginDelegate = null;
		m_DownloadCompleteDelegate = null;
		m_TitleChangeDelegate = null;
		m_PropertyChangeDelegate = null;
		m_BeforeNavigate2Delegate = null;
		m_NewWindow2Delegate = null;
		m_NavigateComplete2Delegate = null;
		m_DocumentCompleteDelegate = null;
		m_OnQuitDelegate = null;
		m_OnVisibleDelegate = null;
		m_OnToolBarDelegate = null;
		m_OnMenuBarDelegate = null;
		m_OnStatusBarDelegate = null;
		m_OnFullScreenDelegate = null;
		m_OnTheaterModeDelegate = null;
		m_WindowSetResizableDelegate = null;
		m_WindowSetLeftDelegate = null;
		m_WindowSetTopDelegate = null;
		m_WindowSetWidthDelegate = null;
		m_WindowSetHeightDelegate = null;
		m_WindowClosingDelegate = null;
		m_ClientToHostWindowDelegate = null;
		m_SetSecureLockIconDelegate = null;
		m_FileDownloadDelegate = null;
		m_NavigateErrorDelegate = null;
		m_PrintTemplateInstantiationDelegate = null;
		m_PrintTemplateTeardownDelegate = null;
		m_UpdatePageStatusDelegate = null;
		m_PrivacyImpactedStateChangeDelegate = null;
	}
}
