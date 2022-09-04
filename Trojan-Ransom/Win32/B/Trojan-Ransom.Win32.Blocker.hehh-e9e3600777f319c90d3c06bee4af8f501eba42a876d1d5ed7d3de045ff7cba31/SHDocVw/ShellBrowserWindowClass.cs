using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw;

[ComImport]
[DefaultMember("Name")]
[Guid("C08AFD90-F2A1-11D1-8455-00A0C91F3880")]
[ComSourceInterfaces("SHDocVw.DWebBrowserEvents2\0SHDocVw.DWebBrowserEvents\0")]
[ClassInterface(0)]
[TypeLibType(18)]
public class ShellBrowserWindowClass : IWebBrowserApp, IWebBrowser2, DWebBrowserEvents2_Event, DWebBrowserEvents_Event, ShellBrowserWindow
{
	[DispId(200)]
	public virtual extern object Application
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(200)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		get;
	}

	[DispId(201)]
	public virtual extern object Parent
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(201)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		get;
	}

	[DispId(202)]
	public virtual extern object Container
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(202)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		get;
	}

	[DispId(203)]
	public virtual extern object Document
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(203)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		get;
	}

	[DispId(204)]
	public virtual extern bool TopLevelContainer
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(204)]
		get;
	}

	[DispId(205)]
	public virtual extern string Type
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(205)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(206)]
	public virtual extern int Left
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(206)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(206)]
		[param: In]
		set;
	}

	[DispId(207)]
	public virtual extern int Top
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(207)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(207)]
		[param: In]
		set;
	}

	[DispId(208)]
	public virtual extern int Width
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(208)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(208)]
		[param: In]
		set;
	}

	[DispId(209)]
	public virtual extern int Height
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(209)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(209)]
		[param: In]
		set;
	}

	[DispId(210)]
	public virtual extern string LocationName
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(210)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(211)]
	public virtual extern string LocationURL
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(211)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(212)]
	public virtual extern bool Busy
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(212)]
		get;
	}

	[DispId(0)]
	public virtual extern string Name
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(-515)]
	public virtual extern int HWND
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(-515)]
		get;
	}

	[DispId(400)]
	public virtual extern string FullName
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(400)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(401)]
	public virtual extern string Path
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(401)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(402)]
	public virtual extern bool Visible
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(402)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(402)]
		[param: In]
		set;
	}

	[DispId(403)]
	public virtual extern bool StatusBar
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(403)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(403)]
		[param: In]
		set;
	}

	[DispId(404)]
	public virtual extern string StatusText
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(404)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(404)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(405)]
	public virtual extern int ToolBar
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(405)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(405)]
		[param: In]
		set;
	}

	[DispId(406)]
	public virtual extern bool MenuBar
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(406)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(406)]
		[param: In]
		set;
	}

	[DispId(407)]
	public virtual extern bool FullScreen
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(407)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(407)]
		[param: In]
		set;
	}

	[DispId(-525)]
	public virtual extern tagREADYSTATE ReadyState
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(-525)]
		[TypeLibFunc(4)]
		get;
	}

	[DispId(550)]
	public virtual extern bool Offline
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(550)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(550)]
		[param: In]
		set;
	}

	[DispId(551)]
	public virtual extern bool Silent
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(551)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(551)]
		[param: In]
		set;
	}

	[DispId(552)]
	public virtual extern bool RegisterAsBrowser
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(552)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(552)]
		[param: In]
		set;
	}

	[DispId(553)]
	public virtual extern bool RegisterAsDropTarget
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(553)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(553)]
		[param: In]
		set;
	}

	[DispId(554)]
	public virtual extern bool TheaterMode
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(554)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(554)]
		[param: In]
		set;
	}

	[DispId(555)]
	public virtual extern bool AddressBar
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(555)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(555)]
		[param: In]
		set;
	}

	[DispId(556)]
	public virtual extern bool Resizable
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(556)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(556)]
		[param: In]
		set;
	}

	virtual extern object IWebBrowserApp.Application
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		get;
	}

	virtual extern object IWebBrowserApp.Parent
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		get;
	}

	virtual extern object IWebBrowserApp.Container
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		get;
	}

	virtual extern object IWebBrowserApp.Document
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		get;
	}

	virtual extern bool IWebBrowserApp.TopLevelContainer
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		get;
	}

	virtual extern string IWebBrowserApp.Type
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	virtual extern int IWebBrowserApp.Left
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[param: In]
		set;
	}

	virtual extern int IWebBrowserApp.Top
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[param: In]
		set;
	}

	virtual extern int IWebBrowserApp.Width
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[param: In]
		set;
	}

	virtual extern int IWebBrowserApp.Height
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[param: In]
		set;
	}

	virtual extern string IWebBrowserApp.LocationName
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	virtual extern string IWebBrowserApp.LocationURL
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	virtual extern bool IWebBrowserApp.Busy
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		get;
	}

	virtual extern string IWebBrowserApp.Name
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	virtual extern int IWebBrowserApp.HWND
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		get;
	}

	virtual extern string IWebBrowserApp.FullName
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	virtual extern string IWebBrowserApp.Path
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	virtual extern bool IWebBrowserApp.Visible
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[param: In]
		set;
	}

	virtual extern bool IWebBrowserApp.StatusBar
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[param: In]
		set;
	}

	virtual extern string IWebBrowserApp.StatusText
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	virtual extern int IWebBrowserApp.ToolBar
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[param: In]
		set;
	}

	virtual extern bool IWebBrowserApp.MenuBar
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[param: In]
		set;
	}

	virtual extern bool IWebBrowserApp.FullScreen
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[param: In]
		set;
	}

	public virtual extern event DWebBrowserEvents2_StatusTextChangeEventHandler StatusTextChange;

	public virtual extern event DWebBrowserEvents2_ProgressChangeEventHandler ProgressChange;

	public virtual extern event DWebBrowserEvents2_CommandStateChangeEventHandler CommandStateChange;

	public virtual extern event DWebBrowserEvents2_DownloadBeginEventHandler DownloadBegin;

	public virtual extern event DWebBrowserEvents2_DownloadCompleteEventHandler DownloadComplete;

	public virtual extern event DWebBrowserEvents2_TitleChangeEventHandler TitleChange;

	public virtual extern event DWebBrowserEvents2_PropertyChangeEventHandler PropertyChange;

	public virtual extern event DWebBrowserEvents2_BeforeNavigate2EventHandler BeforeNavigate2;

	public virtual extern event DWebBrowserEvents2_NewWindow2EventHandler NewWindow2;

	public virtual extern event DWebBrowserEvents2_NavigateComplete2EventHandler NavigateComplete2;

	public virtual extern event DWebBrowserEvents2_DocumentCompleteEventHandler DocumentComplete;

	public virtual extern event DWebBrowserEvents2_OnQuitEventHandler OnQuit;

	public virtual extern event DWebBrowserEvents2_OnVisibleEventHandler OnVisible;

	public virtual extern event DWebBrowserEvents2_OnToolBarEventHandler OnToolBar;

	public virtual extern event DWebBrowserEvents2_OnMenuBarEventHandler OnMenuBar;

	public virtual extern event DWebBrowserEvents2_OnStatusBarEventHandler OnStatusBar;

	public virtual extern event DWebBrowserEvents2_OnFullScreenEventHandler OnFullScreen;

	public virtual extern event DWebBrowserEvents2_OnTheaterModeEventHandler OnTheaterMode;

	public virtual extern event DWebBrowserEvents2_WindowSetResizableEventHandler WindowSetResizable;

	public virtual extern event DWebBrowserEvents2_WindowSetLeftEventHandler WindowSetLeft;

	public virtual extern event DWebBrowserEvents2_WindowSetTopEventHandler WindowSetTop;

	public virtual extern event DWebBrowserEvents2_WindowSetWidthEventHandler WindowSetWidth;

	public virtual extern event DWebBrowserEvents2_WindowSetHeightEventHandler WindowSetHeight;

	public virtual extern event DWebBrowserEvents2_WindowClosingEventHandler WindowClosing;

	public virtual extern event DWebBrowserEvents2_ClientToHostWindowEventHandler ClientToHostWindow;

	public virtual extern event DWebBrowserEvents2_SetSecureLockIconEventHandler SetSecureLockIcon;

	public virtual extern event DWebBrowserEvents2_FileDownloadEventHandler FileDownload;

	public virtual extern event DWebBrowserEvents2_NavigateErrorEventHandler NavigateError;

	public virtual extern event DWebBrowserEvents2_PrintTemplateInstantiationEventHandler PrintTemplateInstantiation;

	public virtual extern event DWebBrowserEvents2_PrintTemplateTeardownEventHandler PrintTemplateTeardown;

	public virtual extern event DWebBrowserEvents2_UpdatePageStatusEventHandler UpdatePageStatus;

	public virtual extern event DWebBrowserEvents2_PrivacyImpactedStateChangeEventHandler PrivacyImpactedStateChange;

	public virtual extern event DWebBrowserEvents2_NewWindow3EventHandler NewWindow3;

	public virtual extern event DWebBrowserEvents_BeforeNavigateEventHandler BeforeNavigate;

	public virtual extern event DWebBrowserEvents_NavigateCompleteEventHandler NavigateComplete;

	virtual extern event DWebBrowserEvents_StatusTextChangeEventHandler DWebBrowserEvents_Event.StatusTextChange
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		add;
		[MethodImpl(MethodImplOptions.InternalCall)]
		remove;
	}

	virtual extern event DWebBrowserEvents_ProgressChangeEventHandler DWebBrowserEvents_Event.ProgressChange
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		add;
		[MethodImpl(MethodImplOptions.InternalCall)]
		remove;
	}

	virtual extern event DWebBrowserEvents_DownloadCompleteEventHandler DWebBrowserEvents_Event.DownloadComplete
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		add;
		[MethodImpl(MethodImplOptions.InternalCall)]
		remove;
	}

	virtual extern event DWebBrowserEvents_CommandStateChangeEventHandler DWebBrowserEvents_Event.CommandStateChange
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		add;
		[MethodImpl(MethodImplOptions.InternalCall)]
		remove;
	}

	virtual extern event DWebBrowserEvents_DownloadBeginEventHandler DWebBrowserEvents_Event.DownloadBegin
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		add;
		[MethodImpl(MethodImplOptions.InternalCall)]
		remove;
	}

	public virtual extern event DWebBrowserEvents_NewWindowEventHandler NewWindow;

	virtual extern event DWebBrowserEvents_TitleChangeEventHandler DWebBrowserEvents_Event.TitleChange
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		add;
		[MethodImpl(MethodImplOptions.InternalCall)]
		remove;
	}

	public virtual extern event DWebBrowserEvents_FrameBeforeNavigateEventHandler FrameBeforeNavigate;

	public virtual extern event DWebBrowserEvents_FrameNavigateCompleteEventHandler FrameNavigateComplete;

	public virtual extern event DWebBrowserEvents_FrameNewWindowEventHandler FrameNewWindow;

	public virtual extern event DWebBrowserEvents_QuitEventHandler Quit;

	public virtual extern event DWebBrowserEvents_WindowMoveEventHandler WindowMove;

	public virtual extern event DWebBrowserEvents_WindowResizeEventHandler WindowResize;

	public virtual extern event DWebBrowserEvents_WindowActivateEventHandler WindowActivate;

	virtual extern event DWebBrowserEvents_PropertyChangeEventHandler DWebBrowserEvents_Event.PropertyChange
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		add;
		[MethodImpl(MethodImplOptions.InternalCall)]
		remove;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	public extern ShellBrowserWindowClass();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(100)]
	public virtual extern void GoBack();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(101)]
	public virtual extern void GoForward();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(102)]
	public virtual extern void GoHome();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(103)]
	public virtual extern void GoSearch();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(104)]
	public virtual extern void Navigate([In][MarshalAs(UnmanagedType.BStr)] string URL, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Flags, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object TargetFrameName, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object PostData, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Headers);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(-550)]
	public virtual extern void Refresh();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(105)]
	public virtual extern void Refresh2([Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Level);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(106)]
	public virtual extern void Stop();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(300)]
	public virtual extern void Quit();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(301)]
	public virtual extern void ClientToWindow([In][Out] ref int pcx, [In][Out] ref int pcy);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(302)]
	public virtual extern void PutProperty([In][MarshalAs(UnmanagedType.BStr)] string Property, [In][MarshalAs(UnmanagedType.Struct)] object vtValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(303)]
	[return: MarshalAs(UnmanagedType.Struct)]
	public virtual extern object GetProperty([In][MarshalAs(UnmanagedType.BStr)] string Property);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(500)]
	public virtual extern void Navigate2([In][MarshalAs(UnmanagedType.Struct)] ref object URL, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Flags, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object TargetFrameName, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object PostData, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Headers);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(501)]
	public virtual extern OLECMDF QueryStatusWB([In] OLECMDID cmdID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(502)]
	public virtual extern void ExecWB([In] OLECMDID cmdID, [In] OLECMDEXECOPT cmdexecopt, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object pvaIn, [Optional][In][Out][MarshalAs(UnmanagedType.Struct)] ref object pvaOut);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(503)]
	public virtual extern void ShowBrowserBar([In][MarshalAs(UnmanagedType.Struct)] ref object pvaClsid, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object pvarShow, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object pvarSize);

	[MethodImpl(MethodImplOptions.InternalCall)]
	public virtual extern void IWebBrowserApp_GoBack();

	void IWebBrowserApp.GoBack()
	{
		//ILSpy generated this explicit interface implementation from .override directive in IWebBrowserApp_GoBack
		this.IWebBrowserApp_GoBack();
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	public virtual extern void IWebBrowserApp_GoForward();

	void IWebBrowserApp.GoForward()
	{
		//ILSpy generated this explicit interface implementation from .override directive in IWebBrowserApp_GoForward
		this.IWebBrowserApp_GoForward();
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	public virtual extern void IWebBrowserApp_GoHome();

	void IWebBrowserApp.GoHome()
	{
		//ILSpy generated this explicit interface implementation from .override directive in IWebBrowserApp_GoHome
		this.IWebBrowserApp_GoHome();
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	public virtual extern void IWebBrowserApp_GoSearch();

	void IWebBrowserApp.GoSearch()
	{
		//ILSpy generated this explicit interface implementation from .override directive in IWebBrowserApp_GoSearch
		this.IWebBrowserApp_GoSearch();
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	public virtual extern void IWebBrowserApp_Navigate([In][MarshalAs(UnmanagedType.BStr)] string URL, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Flags, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object TargetFrameName, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object PostData, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Headers);

	void IWebBrowserApp.Navigate([In][MarshalAs(UnmanagedType.BStr)] string URL, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Flags, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object TargetFrameName, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object PostData, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Headers)
	{
		//ILSpy generated this explicit interface implementation from .override directive in IWebBrowserApp_Navigate
		this.IWebBrowserApp_Navigate(URL, ref Flags, ref TargetFrameName, ref PostData, ref Headers);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	public virtual extern void IWebBrowserApp_Refresh();

	void IWebBrowserApp.Refresh()
	{
		//ILSpy generated this explicit interface implementation from .override directive in IWebBrowserApp_Refresh
		this.IWebBrowserApp_Refresh();
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	public virtual extern void IWebBrowserApp_Refresh2([Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Level);

	void IWebBrowserApp.Refresh2([Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Level)
	{
		//ILSpy generated this explicit interface implementation from .override directive in IWebBrowserApp_Refresh2
		this.IWebBrowserApp_Refresh2(ref Level);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	public virtual extern void IWebBrowserApp_Stop();

	void IWebBrowserApp.Stop()
	{
		//ILSpy generated this explicit interface implementation from .override directive in IWebBrowserApp_Stop
		this.IWebBrowserApp_Stop();
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	public virtual extern void IWebBrowserApp_Quit();

	void IWebBrowserApp.Quit()
	{
		//ILSpy generated this explicit interface implementation from .override directive in IWebBrowserApp_Quit
		this.IWebBrowserApp_Quit();
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	public virtual extern void IWebBrowserApp_ClientToWindow([In][Out] ref int pcx, [In][Out] ref int pcy);

	void IWebBrowserApp.ClientToWindow([In][Out] ref int pcx, [In][Out] ref int pcy)
	{
		//ILSpy generated this explicit interface implementation from .override directive in IWebBrowserApp_ClientToWindow
		this.IWebBrowserApp_ClientToWindow(ref pcx, ref pcy);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	public virtual extern void IWebBrowserApp_PutProperty([In][MarshalAs(UnmanagedType.BStr)] string Property, [In][MarshalAs(UnmanagedType.Struct)] object vtValue);

	void IWebBrowserApp.PutProperty([In][MarshalAs(UnmanagedType.BStr)] string Property, [In][MarshalAs(UnmanagedType.Struct)] object vtValue)
	{
		//ILSpy generated this explicit interface implementation from .override directive in IWebBrowserApp_PutProperty
		this.IWebBrowserApp_PutProperty(Property, vtValue);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Struct)]
	public virtual extern object IWebBrowserApp_GetProperty([In][MarshalAs(UnmanagedType.BStr)] string Property);

	object IWebBrowserApp.GetProperty([In][MarshalAs(UnmanagedType.BStr)] string Property)
	{
		//ILSpy generated this explicit interface implementation from .override directive in IWebBrowserApp_GetProperty
		return this.IWebBrowserApp_GetProperty(Property);
	}
}
