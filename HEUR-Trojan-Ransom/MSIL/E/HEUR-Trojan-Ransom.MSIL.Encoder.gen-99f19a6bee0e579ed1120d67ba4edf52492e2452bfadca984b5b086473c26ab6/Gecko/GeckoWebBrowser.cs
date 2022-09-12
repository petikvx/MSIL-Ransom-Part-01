#define DEBUG
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Gecko.DOM;
using Gecko.Events;
using Gecko.IO;
using Gecko.Interop;
using Gecko.Net;
using Gecko.Services;
using Gecko.WebIDL;
using Gecko.Windows;

namespace Gecko;

public class GeckoWebBrowser : Control, IGeckoWebBrowser, nsIWebProgressListener, nsIWebProgressListener2, nsISupportsWeakReference, nsIContextMenuListener2, nsIDOMEventListener, nsIEmbeddingSiteWindow, nsIHttpActivityObserver, nsIInterfaceRequestor, nsIObserver, nsISHistoryListener, nsITooltipListener, nsIWebBrowserChrome, nsIXULWindow
{
	private class WindowCreator : nsIWindowCreator, nsIWindowCreator2
	{
		static WindowCreator()
		{
			WindowWatcher.WindowCreator = new WindowCreator();
		}

		public static void Register()
		{
		}

		private nsIWebBrowserChrome DoCreateChromeWindow(nsIWebBrowserChrome parent, uint chromeFlags, uint contextFlags, nsIURI uri, ref bool cancel)
		{
			string text = "";
			text = ((uri == null) ? "about:blank" : nsString.Get(uri.GetSpecAttribute).ToString());
			if ((chromeFlags & 0x80000000u) != 0)
			{
				nsIXULWindow obj = AppShellService.CreateTopLevelWindow(null, null, chromeFlags, -1, -1);
				if (parent is GeckoWebBrowser && (chromeFlags & 0x40000000u) != 0)
				{
					EventHandler gotFocus = null;
					gotFocus = delegate(object sender, EventArgs e)
					{
						GeckoWebBrowser geckoWebBrowser2 = (GeckoWebBrowser)sender;
						((Control)geckoWebBrowser2).remove_GotFocus(gotFocus);
						if (geckoWebBrowser2.WebBrowserFocus != null)
						{
							geckoWebBrowser2.WebBrowserFocus.Activate();
						}
					};
					((Control)(parent as GeckoWebBrowser)).add_GotFocus(gotFocus);
				}
				return Xpcom.QueryInterface<nsIWebBrowserChrome>(obj);
			}
			if (parent is GeckoWebBrowser geckoWebBrowser)
			{
				GeckoCreateWindow2EventArgs geckoCreateWindow2EventArgs = new GeckoCreateWindow2EventArgs((GeckoWindowFlags)chromeFlags, text);
				if (uri != null)
				{
					geckoWebBrowser.OnCreateWindow2(geckoCreateWindow2EventArgs);
				}
				geckoWebBrowser.OnCreateWindow(geckoCreateWindow2EventArgs);
				if (geckoCreateWindow2EventArgs.Cancel)
				{
					cancel = true;
					return null;
				}
				if (geckoCreateWindow2EventArgs.WebBrowser != null)
				{
					((nsIWebBrowserChrome)geckoCreateWindow2EventArgs.WebBrowser).SetChromeFlagsAttribute(chromeFlags);
					return geckoCreateWindow2EventArgs.WebBrowser;
				}
				nsIXULWindow obj2 = AppShellService.CreateTopLevelWindow(null, null, chromeFlags, geckoCreateWindow2EventArgs.InitialWidth, geckoCreateWindow2EventArgs.InitialHeight);
				return Xpcom.QueryInterface<nsIWebBrowserChrome>(obj2);
			}
			return null;
		}

		public nsIWebBrowserChrome CreateChromeWindow(nsIWebBrowserChrome parent, uint chromeFlags)
		{
			bool cancel = false;
			return DoCreateChromeWindow(parent, chromeFlags, 0u, null, ref cancel);
		}

		public nsIWebBrowserChrome CreateChromeWindow2(nsIWebBrowserChrome parent, uint chromeFlags, uint contextFlags, nsIURI uri, nsITabParent aOpeningTab, ref bool cancel)
		{
			return DoCreateChromeWindow(parent, chromeFlags, contextFlags, uri, ref cancel);
		}

		public void SetScreenId(uint aScreenId)
		{
			Debug.WriteLine("SetScreenId called");
		}
	}

	private delegate bool CanPerformMethod();

	public sealed class ConsoleListener : nsIConsoleListener
	{
		private GeckoWebBrowser m_browser;

		public ConsoleListener(GeckoWebBrowser browser)
		{
			m_browser = browser;
		}

		public void Observe(nsIConsoleMessage aMessage)
		{
			if (!((Control)m_browser).get_IsDisposed())
			{
				ConsoleMessageEventArgs e = new ConsoleMessageEventArgs(aMessage.GetMessageAttribute());
				m_browser.OnConsoleMessage(e);
			}
		}
	}

	private class ToolTipWindow : ToolTip
	{
	}

	private Dictionary<string, KeyValuePair<Action<string>, bool>> _messageEventListeners = new Dictionary<string, KeyValuePair<Action<string>, bool>>();

	private nsIWebBrowser WebBrowser;

	private nsIBaseWindow BaseWindow;

	private nsIWebNavigation WebNav;

	private nsICommandParams CommandParams;

	private uint ChromeFlags;

	private bool m_javascriptDebuggingEnabled;

	private GeckoWindow _Window;

	private GeckoDomDocument _Document;

	[Obsolete]
	public NavigateFinishedNotifier NavigateFinishedNotifier;

	private bool _NoDefaultContextMenu;

	private string _StatusText;

	private string _DocumentTitle;

	private bool _CanGoBack;

	private bool _CanGoForward;

	private nsIClipboardCommands _ClipboardCommands;

	private nsICommandManager _CommandManager;

	private bool _IsBusy;

	private GeckoSessionHistory _History;

	private bool _IsWindowModal;

	private ContextMenu menu = null;

	private GeckoSecurityState _SecurityState;

	private static object SecurityStateChangedEvent = new object();

	private ToolTipWindow ToolTip;

	public Dictionary<nsIHttpChannel, GeckoJavaScriptHttpChannelWrapper> origJavaScriptHttpChannels = new Dictionary<nsIHttpChannel, GeckoJavaScriptHttpChannelWrapper>();

	private uint activeNetworkChannels = 0u;

	private List<string> activeNetworkChannelUrls = new List<string>();

	private GeckoWebBrowserWeakRef _weakRef;

	private static readonly object NavigatingEvent = new object();

	private static readonly object NavigatedEvent = new object();

	private static readonly object NavigationErrorEvent = new object();

	private static readonly object FrameNavigatingEvent = new object();

	private static readonly object DocumentCompletedEvent = new object();

	private static readonly object RedirectingEvent = new object();

	private static readonly object RetargetedEvent = new object();

	private static readonly object CanGoBackChangedEvent = new object();

	private static readonly object CanGoForwardChangedEvent = new object();

	private static readonly object RequestProgressChangedEvent = new object();

	private static readonly object ProgressChangedEvent = new object();

	private static readonly object HistoryNewEntryEvent = new object();

	private static readonly object HistoryGoBackEvent = new object();

	private static readonly object HistoryGoForwardEvent = new object();

	private static readonly object HistoryReloadEvent = new object();

	private static readonly object HistoryGotoIndexEvent = new object();

	private static readonly object HistoryPurgeEvent = new object();

	private static readonly object HistoryReplaceEntryEvent = new object();

	private static readonly object CreateWindowEvent = new object();

	private static readonly object CreateWindow2Event = new object();

	private static readonly object WindowSetBoundsEvent = new object();

	private static readonly object WindowClosedEvent = new object();

	private static readonly object StatusTextChangedEvent = new object();

	private static readonly object DocumentTitleChangedEvent = new object();

	private static readonly object ShowContextMenuEvent = new object();

	private static readonly object ObserveHttpModifyRequestEvent = new object();

	private static readonly object NSSErrorEvent = new object();

	private static readonly object DomKeyDownEvent = new object();

	private static readonly object DomKeyUpEvent = new object();

	private static readonly object DomKeyPressEvent = new object();

	private static readonly object DomMouseDownEvent = new object();

	private static readonly object DomMouseUpEvent = new object();

	private static readonly object DomMouseOverEvent = new object();

	private static readonly object DomMouseOutEvent = new object();

	private static readonly object DomMouseMoveEvent = new object();

	private static readonly object DomContextMenuEvent = new object();

	private static readonly object DomMouseScrollEvent = new object();

	private static readonly object DomSubmitEvent = new object();

	private static readonly object DomCompositionStartEvent = new object();

	private static readonly object DomCompositionEndEvent = new object();

	private static readonly object DomFocusEvent = new object();

	private static readonly object DomBlurEvent = new object();

	private static readonly object LoadEvent = new object();

	private static readonly object DOMContentLoadedEvent = new object();

	private static readonly object ReadyStateChangeEvent = new object();

	private static readonly object HashChangeEvent = new object();

	private static readonly object DomContentChangedEvent = new object();

	private static readonly object DomClickEvent = new object();

	private static readonly object DomDoubleClickEvent = new object();

	private static readonly object DomDragStartEvent = new object();

	private static readonly object DomDragEnterEvent = new object();

	private static readonly object DomDragOverEvent = new object();

	private static readonly object DomDragLeaveEvent = new object();

	private static readonly object DomDragEvent = new object();

	private static readonly object DomDropEvent = new object();

	private static readonly object DomDragEndEvent = new object();

	private static readonly object FullscreenChangeEvent = new object();

	private static readonly object InputEvent = new object();

	private EventHandler<ConsoleMessageEventArgs> _ConsoleMessage;

	private bool InOnHandleCreate;

	private bool _eventsAttached;

	public nsIWebBrowserFocus WebBrowserFocus { get; protected set; }

	public nsIEditor Editor
	{
		get
		{
			nsIEditingSession nsIEditingSession2 = Xpcom.CreateInstance<nsIEditingSession>("@mozilla.org/editor/editingsession;1");
			nsIEditor editorForWindow = nsIEditingSession2.GetEditorForWindow(Window.DomWindow);
			Marshal.ReleaseComObject(nsIEditingSession2);
			return editorForWindow;
		}
	}

	public bool UseHttpActivityObserver { get; set; }

	public bool FrameEventsPropagateToMainWindow { get; set; }

	[Description("Removes default items from the standard context menu.  The ShowContextMenu event is still raised to add custom items.")]
	[DefaultValue(false)]
	public bool NoDefaultContextMenu
	{
		get
		{
			return _NoDefaultContextMenu;
		}
		set
		{
			_NoDefaultContextMenu = value;
		}
	}

	[Browsable(false)]
	[DefaultValue("")]
	public string StatusText
	{
		get
		{
			return _StatusText ?? "";
		}
		set
		{
			if (StatusText != value)
			{
				_StatusText = value;
				OnStatusTextChanged(EventArgs.Empty);
			}
		}
	}

	[Browsable(false)]
	[DefaultValue("")]
	public string DocumentTitle
	{
		get
		{
			return _DocumentTitle ?? "";
		}
		private set
		{
			if (!(DocumentTitle == value))
			{
				_DocumentTitle = value;
				OnDocumentTitleChanged(EventArgs.Empty);
			}
		}
	}

	[Browsable(false)]
	public bool CanGoBack => _CanGoBack;

	[Browsable(false)]
	public bool CanGoForward => _CanGoForward;

	private nsIClipboardCommands ClipboardCommands => _ClipboardCommands ?? (_ClipboardCommands = Xpcom.QueryInterface<nsIClipboardCommands>(WebBrowser));

	[Browsable(false)]
	public bool CanCopyImageContents => CanPerform(ClipboardCommands.CanCopyImageContents);

	[Browsable(false)]
	public bool CanCopyImageLocation => CanPerform(ClipboardCommands.CanCopyImageLocation);

	[Browsable(false)]
	public bool CanCopyLinkLocation => CanPerform(ClipboardCommands.CanCopyLinkLocation);

	[Browsable(false)]
	public bool CanCopySelection => CanPerform(ClipboardCommands.CanCopySelection);

	[Browsable(false)]
	public bool CanCutSelection => CanPerform(ClipboardCommands.CanCutSelection);

	[Browsable(false)]
	public bool CanPaste => CanPerform(ClipboardCommands.CanPaste);

	private nsICommandManager CommandManager => _CommandManager ?? (_CommandManager = Xpcom.QueryInterface<nsICommandManager>(WebBrowser));

	[Browsable(false)]
	public bool CanUndo => CommandManager.IsCommandEnabled("cmd_undo", null);

	[Browsable(false)]
	public bool CanRedo => CommandManager.IsCommandEnabled("cmd_redo", null);

	[Browsable(false)]
	public Uri Url
	{
		get
		{
			if (WebNav == null)
			{
				return null;
			}
			nsIURI obj = WebNav.GetCurrentURIAttribute();
			Uri uri = obj.ToUri();
			Xpcom.FreeComObject(ref obj);
			return uri ?? new Uri("about:blank");
		}
	}

	[Browsable(false)]
	public Uri ReferrerUrl
	{
		get
		{
			if (WebNav == null)
			{
				return null;
			}
			nsIURI obj = WebNav.GetReferringURIAttribute();
			Uri uri = obj.ToUri();
			Xpcom.FreeComObject(ref obj);
			return uri ?? new Uri("about:blank");
		}
	}

	[Browsable(false)]
	public GeckoWindow Window
	{
		get
		{
			if (WebBrowser == null)
			{
				return null;
			}
			if (_Window != null)
			{
				nsIDOMWindow contentDOMWindowAttribute = WebBrowser.GetContentDOMWindowAttribute();
				if (_Window.DomWindow == contentDOMWindowAttribute)
				{
					return _Window;
				}
				_Window.Dispose();
			}
			_Window = WebBrowser.GetContentDOMWindowAttribute().Wrap((nsIDOMWindow x) => new GeckoWindow(x));
			return _Window;
		}
	}

	[Browsable(false)]
	public GeckoDomDocument DomDocument
	{
		get
		{
			if (WebBrowser == null)
			{
				return null;
			}
			ComPtr<nsIDOMDocument> comPtr = new Window(Window.DomWindow, (nsISupports)Window.DomWindow).Document.AsComPtr();
			if (_Document != null)
			{
				if (_Document.NativeDomDocument == comPtr.Instance)
				{
					return _Document;
				}
				_Document.Dispose();
			}
			_Document = GeckoDomDocument.CreateDomDocumentWraper(comPtr.Instance);
			return _Document;
		}
	}

	public GeckoDocument Document => DomDocument as GeckoDocument;

	[Browsable(false)]
	public bool IsBusy
	{
		get
		{
			return _IsBusy;
		}
		private set
		{
			_IsBusy = value;
		}
	}

	[Browsable(false)]
	public GeckoSessionHistory History
	{
		get
		{
			if (WebNav == null)
			{
				return null;
			}
			return _History ?? (_History = new GeckoSessionHistory(WebNav));
		}
	}

	[Browsable(false)]
	public GeckoSecurityState SecurityState
	{
		get
		{
			return _SecurityState;
		}
		private set
		{
			if (_SecurityState != value)
			{
				_SecurityState = value;
				OnSecurityStateChanged(EventArgs.Empty);
			}
		}
	}

	public bool IsAjaxBusy => origJavaScriptHttpChannels.Count > 0;

	public int ActiveAjaxHttpChannels => origJavaScriptHttpChannels.Count;

	public uint ActiveNetworkChannels => activeNetworkChannels;

	public List<string> ActiveNetworkChannelUrls => activeNetworkChannelUrls;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public override Color BackColor
	{
		get
		{
			return ((Control)this).get_BackColor();
		}
		set
		{
			((Control)this).set_BackColor(value);
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public override Image BackgroundImage
	{
		get
		{
			return ((Control)this).get_BackgroundImage();
		}
		set
		{
			((Control)this).set_BackgroundImage(value);
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public override ImageLayout BackgroundImageLayout
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return ((Control)this).get_BackgroundImageLayout();
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			((Control)this).set_BackgroundImageLayout(value);
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public override Color ForeColor
	{
		get
		{
			return ((Control)this).get_ForeColor();
		}
		set
		{
			((Control)this).set_ForeColor(value);
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public override Font Font
	{
		get
		{
			return ((Control)this).get_Font();
		}
		set
		{
			((Control)this).set_Font(value);
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public override string Text
	{
		get
		{
			return ((Control)this).get_Text();
		}
		set
		{
			((Control)this).set_Text(value);
		}
	}

	protected virtual IEnumerable<string> DefaultEvents
	{
		get
		{
			yield return "submit";
			yield return "keydown";
			yield return "keyup";
			yield return "keypress";
			yield return "mousemove";
			yield return "mouseover";
			yield return "mouseout";
			yield return "mousedown";
			yield return "mouseup";
			yield return "click";
			yield return "dblclick";
			yield return "compositionstart";
			yield return "compositionend";
			yield return "contextmenu";
			yield return "DOMMouseScroll";
			yield return "focus";
			yield return "blur";
			yield return "load";
			yield return "DOMContentLoaded";
			yield return "readystatechange";
			yield return "change";
			yield return "hashchange";
			yield return "dragstart";
			yield return "dragleave";
			yield return "drag";
			yield return "drop";
			yield return "dragend";
			yield return "mozfullscreenchange";
			yield return "input";
		}
	}

	protected ComPtr<nsIDOMEventTarget> EventTarget { get; private set; }

	bool IGeckoWebBrowser.IsDisposed => ((Control)this).get_IsDisposed();

	[Category("Property Changed")]
	[Description("Occurs when the value of the SecurityState property is changed.")]
	public event EventHandler SecurityStateChanged
	{
		add
		{
			((Component)this).Events.AddHandler(SecurityStateChangedEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(SecurityStateChangedEvent, value);
		}
	}

	[Category("Navigation")]
	[Description("Occurs before the browser navigates to a new page.")]
	public event EventHandler<GeckoNavigatingEventArgs> Navigating
	{
		add
		{
			((Component)this).Events.AddHandler(NavigatingEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(NavigatingEvent, value);
		}
	}

	[Description("Occurs after the navigation is retargeted.")]
	[Category("Navigation")]
	public event EventHandler<GeckoRetargetedEventArgs> Retargeted
	{
		add
		{
			((Component)this).Events.AddHandler(RetargetedEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(RetargetedEvent, value);
		}
	}

	[Description("Occurs after the browser has navigated to a new page.")]
	[Category("Navigation")]
	public event EventHandler<GeckoNavigatedEventArgs> Navigated
	{
		add
		{
			((Component)this).Events.AddHandler(NavigatedEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(NavigatedEvent, value);
		}
	}

	[Category("Navigation")]
	[Description("Occurs when navigation to a new page has failed or has been aborted by user.")]
	public event EventHandler<GeckoNavigationErrorEventArgs> NavigationError
	{
		add
		{
			((Component)this).Events.AddHandler(NavigationErrorEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(NavigationErrorEvent, value);
		}
	}

	[Description("Occurs before the browser redirects to a new page.")]
	[Category("Navigation")]
	public event EventHandler<GeckoRedirectingEventArgs> Redirecting
	{
		add
		{
			((Component)this).Events.AddHandler(RedirectingEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(RedirectingEvent, value);
		}
	}

	[Category("Navigation")]
	[Description("Occurs before the browser navigates to a new frame.")]
	public event EventHandler<GeckoNavigatingEventArgs> FrameNavigating
	{
		add
		{
			((Component)this).Events.AddHandler(FrameNavigatingEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(FrameNavigatingEvent, value);
		}
	}

	[Category("Navigation")]
	[Description("Occurs after the browser has finished parsing a new page and updated the Document property.")]
	public event EventHandler<GeckoDocumentCompletedEventArgs> DocumentCompleted
	{
		add
		{
			((Component)this).Events.AddHandler(DocumentCompletedEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(DocumentCompletedEvent, value);
		}
	}

	[Category("Property Changed")]
	[Description("Occurs when the value of the CanGoBack property is changed.")]
	public event EventHandler CanGoBackChanged
	{
		add
		{
			((Component)this).Events.AddHandler(CanGoBackChangedEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(CanGoBackChangedEvent, value);
		}
	}

	[Description("Occurs when the value of the CanGoForward property is changed.")]
	[Category("Property Changed")]
	public event EventHandler CanGoForwardChanged
	{
		add
		{
			((Component)this).Events.AddHandler(CanGoForwardChangedEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(CanGoForwardChangedEvent, value);
		}
	}

	[Category("History")]
	public event EventHandler<GeckoHistoryEventArgs> HistoryNewEntry
	{
		add
		{
			((Component)this).Events.AddHandler(HistoryNewEntryEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(HistoryNewEntryEvent, value);
		}
	}

	[Category("History")]
	public event EventHandler<GeckoHistoryEventArgs> HistoryGoBack
	{
		add
		{
			((Component)this).Events.AddHandler(HistoryGoBackEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(HistoryGoBackEvent, value);
		}
	}

	[Category("History")]
	public event EventHandler<GeckoHistoryEventArgs> HistoryGoForward
	{
		add
		{
			((Component)this).Events.AddHandler(HistoryGoForwardEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(HistoryGoForwardEvent, value);
		}
	}

	[Category("History")]
	public event EventHandler<GeckoHistoryEventArgs> HistoryReload
	{
		add
		{
			((Component)this).Events.AddHandler(HistoryReloadEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(HistoryReloadEvent, value);
		}
	}

	[Category("History")]
	public event EventHandler<GeckoHistoryGotoIndexEventArgs> HistoryGotoIndex
	{
		add
		{
			((Component)this).Events.AddHandler(HistoryGotoIndexEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(HistoryGotoIndexEvent, value);
		}
	}

	[Category("History")]
	public event EventHandler<GeckoHistoryPurgeEventArgs> HistoryPurge
	{
		add
		{
			((Component)this).Events.AddHandler(HistoryPurgeEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(HistoryPurgeEvent, value);
		}
	}

	[Category("History")]
	public event EventHandler<GeckoHistoryRepalaceEntryEventArgs> HistoryReplaceEntry
	{
		add
		{
			((Component)this).Events.AddHandler(HistoryReplaceEntryEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(HistoryReplaceEntryEvent, value);
		}
	}

	[Description("Occurs when the Request has updated progress information.")]
	[Category("Navigation")]
	public event EventHandler<GeckoRequestProgressEventArgs> RequestProgressChanged
	{
		add
		{
			((Component)this).Events.AddHandler(RequestProgressChangedEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(RequestProgressChangedEvent, value);
		}
	}

	[Description("Occurs when the control has updated progress information.")]
	[Category("Navigation")]
	public event EventHandler<GeckoProgressEventArgs> ProgressChanged
	{
		add
		{
			((Component)this).Events.AddHandler(ProgressChangedEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(ProgressChangedEvent, value);
		}
	}

	public event EventHandler<GeckoCreateWindowEventArgs> CreateWindow
	{
		add
		{
			((Component)this).Events.AddHandler(CreateWindowEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(CreateWindowEvent, value);
		}
	}

	[Obsolete("Merged to CreateWindow event, just use it")]
	public event EventHandler<GeckoCreateWindow2EventArgs> CreateWindow2
	{
		add
		{
			((Component)this).Events.AddHandler(CreateWindow2Event, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(CreateWindow2Event, value);
		}
	}

	public event EventHandler<GeckoWindowSetBoundsEventArgs> WindowSetBounds
	{
		add
		{
			((Component)this).Events.AddHandler(WindowSetBoundsEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(WindowSetBoundsEvent, value);
		}
	}

	public event EventHandler WindowClosed
	{
		add
		{
			((Component)this).Events.AddHandler(WindowClosedEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(WindowClosedEvent, value);
		}
	}

	[Category("Property Changed")]
	[Description("Occurs when the value of the StatusText property is changed.")]
	public event EventHandler StatusTextChanged
	{
		add
		{
			((Component)this).Events.AddHandler(StatusTextChangedEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(StatusTextChangedEvent, value);
		}
	}

	[Category("Property Changed")]
	[Description("Occurs when the value of the DocumentTitle property is changed.")]
	public event EventHandler DocumentTitleChanged
	{
		add
		{
			((Component)this).Events.AddHandler(DocumentTitleChangedEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(DocumentTitleChangedEvent, value);
		}
	}

	public event EventHandler<GeckoContextMenuEventArgs> ShowContextMenu
	{
		add
		{
			((Component)this).Events.AddHandler(ShowContextMenuEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(ShowContextMenuEvent, value);
		}
	}

	[Category("Observe")]
	[Description("Occurs after the browser has navigated to a new page.")]
	public event EventHandler<GeckoObserveHttpModifyRequestEventArgs> ObserveHttpModifyRequest
	{
		add
		{
			((Component)this).Events.AddHandler(ObserveHttpModifyRequestEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(ObserveHttpModifyRequestEvent, value);
		}
	}

	[Category("DOM Events")]
	public event EventHandler<DomKeyEventArgs> DomKeyDown
	{
		add
		{
			((Component)this).Events.AddHandler(DomKeyDownEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(DomKeyDownEvent, value);
		}
	}

	[Category("DOM Events")]
	public event EventHandler<DomKeyEventArgs> DomKeyUp
	{
		add
		{
			((Component)this).Events.AddHandler(DomKeyUpEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(DomKeyUpEvent, value);
		}
	}

	[Category("DOM Events")]
	public event EventHandler<DomKeyEventArgs> DomKeyPress
	{
		add
		{
			((Component)this).Events.AddHandler(DomKeyPressEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(DomKeyPressEvent, value);
		}
	}

	[Category("DOM Events")]
	public event EventHandler<DomMouseEventArgs> DomMouseDown
	{
		add
		{
			((Component)this).Events.AddHandler(DomMouseDownEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(DomMouseDownEvent, value);
		}
	}

	[Category("DOM Events")]
	public event EventHandler<DomMouseEventArgs> DomMouseUp
	{
		add
		{
			((Component)this).Events.AddHandler(DomMouseUpEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(DomMouseUpEvent, value);
		}
	}

	[Category("DOM Events")]
	public event EventHandler<DomMouseEventArgs> DomMouseOver
	{
		add
		{
			((Component)this).Events.AddHandler(DomMouseOverEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(DomMouseOverEvent, value);
		}
	}

	[Category("DOM Events")]
	public event EventHandler<DomMouseEventArgs> DomMouseOut
	{
		add
		{
			((Component)this).Events.AddHandler(DomMouseOutEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(DomMouseOutEvent, value);
		}
	}

	[Category("DOM Events")]
	public event EventHandler<DomMouseEventArgs> DomMouseMove
	{
		add
		{
			((Component)this).Events.AddHandler(DomMouseMoveEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(DomMouseMoveEvent, value);
		}
	}

	[Category("DOM Events")]
	public event EventHandler<DomMouseEventArgs> DomContextMenu
	{
		add
		{
			((Component)this).Events.AddHandler(DomContextMenuEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(DomContextMenuEvent, value);
		}
	}

	[Category("DOM Events")]
	public event EventHandler<DomMouseEventArgs> DomMouseScroll
	{
		add
		{
			((Component)this).Events.AddHandler(DomMouseScrollEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(DomMouseScrollEvent, value);
		}
	}

	[Category("DOM Events")]
	public event EventHandler<DomEventArgs> DomSubmit
	{
		add
		{
			((Component)this).Events.AddHandler(DomSubmitEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(DomSubmitEvent, value);
		}
	}

	[Category("DOM Events")]
	public event EventHandler<DomEventArgs> DomCompositionStart
	{
		add
		{
			((Component)this).Events.AddHandler(DomCompositionStartEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(DomCompositionStartEvent, value);
		}
	}

	[Category("DOM Events")]
	public event EventHandler<DomEventArgs> DomCompositionEnd
	{
		add
		{
			((Component)this).Events.AddHandler(DomCompositionEndEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(DomCompositionEndEvent, value);
		}
	}

	[Category("DOM Events")]
	public event EventHandler<DomEventArgs> DomFocus
	{
		add
		{
			((Component)this).Events.AddHandler(DomFocusEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(DomFocusEvent, value);
		}
	}

	[Category("DOM Events")]
	public event EventHandler<DomEventArgs> DomBlur
	{
		add
		{
			((Component)this).Events.AddHandler(DomBlurEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(DomBlurEvent, value);
		}
	}

	[Category("DOM Events")]
	public event EventHandler<DomEventArgs> Load
	{
		add
		{
			((Component)this).Events.AddHandler(LoadEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(LoadEvent, value);
		}
	}

	[Category("DOM Events")]
	public event EventHandler<DomEventArgs> DOMContentLoaded
	{
		add
		{
			((Component)this).Events.AddHandler(DOMContentLoadedEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(DOMContentLoadedEvent, value);
		}
	}

	[Category("DOM Events")]
	public event EventHandler<DomEventArgs> ReadyStateChange
	{
		add
		{
			((Component)this).Events.AddHandler(ReadyStateChangeEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(ReadyStateChangeEvent, value);
		}
	}

	public event EventHandler<DomDragEventArgs> DomDragStart
	{
		add
		{
			((Component)this).Events.AddHandler(DomDragStartEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(DomDragStartEvent, value);
		}
	}

	public event EventHandler<DomDragEventArgs> DomDragEnter
	{
		add
		{
			((Component)this).Events.AddHandler(DomDragEnterEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(DomDragEnterEvent, value);
		}
	}

	public event EventHandler<DomDragEventArgs> DomDragOver
	{
		add
		{
			((Component)this).Events.AddHandler(DomDragOverEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(DomDragOverEvent, value);
		}
	}

	public event EventHandler<DomDragEventArgs> DomDragLeave
	{
		add
		{
			((Component)this).Events.AddHandler(DomDragLeaveEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(DomDragLeaveEvent, value);
		}
	}

	public event EventHandler<DomDragEventArgs> DomDrag
	{
		add
		{
			((Component)this).Events.AddHandler(DomDragEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(DomDragEvent, value);
		}
	}

	public event EventHandler<DomDragEventArgs> DomDrop
	{
		add
		{
			((Component)this).Events.AddHandler(DomDropEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(DomDropEvent, value);
		}
	}

	public event EventHandler<DomDragEventArgs> DomDragEnd
	{
		add
		{
			((Component)this).Events.AddHandler(DomDragEndEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(DomDragEndEvent, value);
		}
	}

	[Category("DOM Events")]
	public event EventHandler<DomEventArgs> DomContentChanged
	{
		add
		{
			((Component)this).Events.AddHandler(DomContentChangedEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(DomContentChangedEvent, value);
		}
	}

	[Category("DOM Events")]
	public event EventHandler<DomMouseEventArgs> DomClick
	{
		add
		{
			((Component)this).Events.AddHandler(DomClickEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(DomClickEvent, value);
		}
	}

	[Category("DOM Events")]
	public event EventHandler<DomMouseEventArgs> DomDoubleClick
	{
		add
		{
			((Component)this).Events.AddHandler(DomDoubleClickEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(DomDoubleClickEvent, value);
		}
	}

	[Category("DOM Events")]
	public event EventHandler<DomEventArgs> FullscreenChange
	{
		add
		{
			((Component)this).Events.AddHandler(FullscreenChangeEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(FullscreenChangeEvent, value);
		}
	}

	[Category("DOM Events")]
	public event EventHandler<DomEventArgs> DomInput
	{
		add
		{
			((Component)this).Events.AddHandler(InputEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(InputEvent, value);
		}
	}

	public event EventHandler<ConsoleMessageEventArgs> ConsoleMessage
	{
		add
		{
			EnableConsoleMessageNotfication();
			_ConsoleMessage = (EventHandler<ConsoleMessageEventArgs>)Delegate.Combine(_ConsoleMessage, value);
		}
		remove
		{
			_ConsoleMessage = (EventHandler<ConsoleMessageEventArgs>)Delegate.Remove(_ConsoleMessage, value);
		}
	}

	[Category("Security")]
	public event EventHandler<GeckoNSSErrorEventArgs> NSSError
	{
		add
		{
			((Component)this).Events.AddHandler(NSSErrorEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(NSSErrorEvent, value);
		}
	}

	public event EventHandler GeckoHandleCreated = delegate
	{
	};

	[Obsolete("Just provide custom PromptFactory.PromptServiceCreator", false)]
	public static void UseCustomPrompt()
	{
	}

	public GeckoWebBrowser()
	{
		NavigateFinishedNotifier = new NavigateFinishedNotifier(this);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			origJavaScriptHttpChannels = null;
			_messageEventListeners = null;
			if (NavigateFinishedNotifier != null)
			{
				NavigateFinishedNotifier.Dispose();
			}
			if (_Window != null)
			{
				_Window.Dispose();
			}
			_Window = null;
			if (_Document != null)
			{
				_Document.Dispose();
			}
			_Document = null;
		}
		((Control)this).Dispose(disposing);
	}

	protected virtual bool HasShutdownStarted()
	{
		return Environment.HasShutdownStarted || AppDomain.CurrentDomain.IsFinalizingForUnload();
	}

	public void Navigate(string url)
	{
		Navigate(url, GeckoLoadFlags.None, null, null, null);
	}

	public bool Navigate(string url, GeckoLoadFlags loadFlags)
	{
		return Navigate(url, loadFlags, null, null, null);
	}

	public bool Navigate(string url, GeckoLoadFlags loadFlags, string referrer, MimeInputStream postData)
	{
		return Navigate(url, loadFlags, referrer, postData, null);
	}

	public bool Navigate(string url, GeckoLoadFlags loadFlags, string referrer, MimeInputStream postData, MimeInputStream headers)
	{
		if (string.IsNullOrEmpty(url))
		{
			return false;
		}
		if (!((Control)this).get_IsHandleCreated())
		{
			((Control)this).CreateHandle();
		}
		if (IsBusy)
		{
			Stop();
		}
		if (!((Control)this).get_IsHandleCreated())
		{
			throw new InvalidOperationException("Cannot call Navigate() before the window handle is created.");
		}
		nsIURI referrerUri = null;
		if (!string.IsNullOrEmpty(referrer))
		{
			referrerUri = IOService.CreateNsIUri(referrer);
		}
		((Control)this).BeginInvoke((Delegate)(Action)delegate
		{
			if (!((Control)this).get_IsDisposed())
			{
				try
				{
					WebNav.LoadURI(url, (uint)loadFlags, referrerUri, (postData != null) ? postData._inputStream : null, (headers != null) ? headers._inputStream : null);
				}
				catch (COMException ex)
				{
					OnNavigationError(new GeckoNavigationErrorEventArgs(url, Window, ex.ErrorCode));
				}
				catch (Exception)
				{
					OnNavigationError(new GeckoNavigationErrorEventArgs(url, Window, -2147418113));
				}
			}
		});
		return true;
	}

	[Obsolete("LoadHtml(string) isn't intended to load complex Html Documents. Use LoadHtml(string,string) instead")]
	public void LoadHtml(string htmlDocument)
	{
		LoadBase64EncodedData("text/html", htmlDocument);
	}

	public void LoadBase64EncodedData(string type, string data)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(data);
		Navigate("data:" + type + ";base64," + Convert.ToBase64String(bytes));
	}

	public void LoadHtml(string content, string url)
	{
		if (url == null)
		{
			url = "file://somepage.com";
		}
		LoadContent(content, url, "text/html");
	}

	public void LoadContent(string content, string url, string contentType)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (CouldFindOrCreateHandle())
		{
			InternalLoadContent(content, url, contentType);
			return;
		}
		GeckoHandleCreated += delegate
		{
			InternalLoadContent(content, url, contentType);
		};
	}

	private void InternalLoadContent(string content, string url, string contentType)
	{
		using nsACString aContentType = new nsACString(contentType);
		using nsACString aContentCharset = new nsACString("UTF8");
		ByteArrayInputStream byteArrayInputStream = null;
		try
		{
			byteArrayInputStream = ByteArrayInputStream.Create(Encoding.UTF8.GetBytes((content != null) ? content : string.Empty));
			nsIDocShell nsIDocShell2 = Xpcom.QueryInterface<nsIDocShell>(WebBrowser);
			nsIDocShell2.LoadStream(byteArrayInputStream, IOService.CreateNsIUri(url), aContentType, aContentCharset, null);
			Marshal.ReleaseComObject(nsIDocShell2);
		}
		finally
		{
			byteArrayInputStream?.Close();
		}
	}

	private bool CouldFindOrCreateHandle()
	{
		if (((Control)this).get_IsDisposed())
		{
			return false;
		}
		if (InOnHandleCreate)
		{
			return false;
		}
		if (!((Control)this).get_IsHandleCreated())
		{
			((Control)this).CreateHandle();
		}
		return ((Control)this).get_IsHandleCreated();
	}

	private void UpdateCommandStatus()
	{
		bool flag = false;
		bool flag2 = false;
		if (WebNav != null)
		{
			flag = WebNav.GetCanGoBackAttribute();
			flag2 = WebNav.GetCanGoForwardAttribute();
		}
		if (_CanGoBack != flag)
		{
			_CanGoBack = flag;
			OnCanGoBackChanged(EventArgs.Empty);
		}
		if (_CanGoForward != flag2)
		{
			_CanGoForward = flag2;
			OnCanGoForwardChanged(EventArgs.Empty);
		}
	}

	public bool GoBack()
	{
		if (!CanGoBack)
		{
			return false;
		}
		((Control)this).BeginInvoke((Delegate)(Action)delegate
		{
			try
			{
				WebNav.GoBack();
			}
			catch (COMException ex)
			{
				int index = History.Index;
				string uri = ((index > 0) ? History[index - 1].Url.ToString() : "");
				OnNavigationError(new GeckoNavigationErrorEventArgs(uri, Window, ex.ErrorCode));
			}
		});
		return true;
	}

	public bool GoForward()
	{
		if (!CanGoForward)
		{
			return false;
		}
		((Control)this).BeginInvoke((Delegate)(Action)delegate
		{
			try
			{
				WebNav.GoForward();
			}
			catch (COMException ex)
			{
				int index = History.Index;
				string uri = ((index < History.Count - 1) ? History[index + 1].Url.ToString() : "");
				OnNavigationError(new GeckoNavigationErrorEventArgs(uri, Window, ex.ErrorCode));
			}
		});
		return true;
	}

	public void Stop()
	{
		Action action = delegate
		{
			if (WebNav != null)
			{
				try
				{
					WebNav.Stop(3u);
				}
				catch (COMException ex)
				{
					if (ex.ErrorCode != -2147418113)
					{
						throw;
					}
				}
			}
		};
		if (((Control)this).get_IsHandleCreated())
		{
			((Control)this).BeginInvoke((Delegate)action);
		}
		else
		{
			action();
		}
	}

	public bool Reload()
	{
		return Reload(GeckoLoadFlags.None);
	}

	public bool Reload(GeckoLoadFlags flags)
	{
		((Control)this).BeginInvoke((Delegate)(Action)delegate
		{
			try
			{
				WebNav.Reload((uint)flags);
			}
			catch (COMException ex)
			{
				OnNavigationError(new GeckoNavigationErrorEventArgs(Url.ToString(), Window, ex.ErrorCode));
			}
		});
		return true;
	}

	private bool CanPerform(CanPerformMethod method)
	{
		try
		{
			return method();
		}
		catch (COMException ex)
		{
			if ((ex.ErrorCode & 0xFFFFFFFFL) != 2147500037L)
			{
				throw ex;
			}
			return false;
		}
	}

	public bool CopyImageContents()
	{
		if (CanCopyImageContents)
		{
			ClipboardCommands.CopyImageContents();
			return true;
		}
		return false;
	}

	public bool CopyImageLocation()
	{
		if (CanCopyImageLocation)
		{
			try
			{
				ClipboardCommands.CopyImageLocation();
			}
			catch (COMException ex)
			{
				if ((ex.ErrorCode & 0xFFFFFFFFL) != 2147500037L)
				{
					throw ex;
				}
			}
			return true;
		}
		return false;
	}

	public bool CopyLinkLocation()
	{
		if (CanCopyLinkLocation)
		{
			ClipboardCommands.CopyLinkLocation();
			return true;
		}
		return false;
	}

	public bool CopySelection()
	{
		if (CanCopySelection)
		{
			ClipboardCommands.CopySelection();
			return true;
		}
		return false;
	}

	public bool CutSelection()
	{
		if (CanCutSelection)
		{
			ClipboardCommands.CutSelection();
			return true;
		}
		return false;
	}

	public bool Paste()
	{
		if (CanPaste)
		{
			ClipboardCommands.Paste();
			return true;
		}
		return false;
	}

	public void SelectAll()
	{
		ClipboardCommands.SelectAll();
	}

	public void SelectNone()
	{
		ClipboardCommands.SelectNone();
	}

	public bool Undo()
	{
		if (CanUndo)
		{
			CommandManager.DoCommand("cmd_undo", null, null);
			return true;
		}
		return false;
	}

	public bool Redo()
	{
		if (CanRedo)
		{
			CommandManager.DoCommand("cmd_redo", null, null);
			return true;
		}
		return false;
	}

	public void ExecuteCommand(string name)
	{
		if (string.IsNullOrEmpty(name))
		{
			throw new ArgumentException("name");
		}
		CommandManager.DoCommand(name, null, null);
	}

	public void ExecuteCommand(string name, string pname, string pvalue)
	{
		CommandParams = Xpcom.CreateInstance<nsICommandParams>("@mozilla.org/embedcomp/command-params;1");
		if (string.IsNullOrEmpty(name))
		{
			throw new ArgumentException("name");
		}
		CommandParams.SetCStringValue(pname, pvalue);
		if (CommandManager.IsCommandEnabled(name, null))
		{
			CommandManager.DoCommand(name, CommandParams, null);
		}
	}

	public void SetInputFocus()
	{
	}

	public void RemoveInputFocus()
	{
	}

	public bool HasInputFocus()
	{
		return false;
	}

	public void SaveDocument(string path)
	{
		SaveDocument(path, null);
	}

	public void SaveDocument(string path, string outputMimeType)
	{
		if (!System.IO.Directory.Exists(Path.GetDirectoryName(path)))
		{
			throw new DirectoryNotFoundException();
		}
		if (Document == null)
		{
			throw new InvalidOperationException("No document has been loaded into the web browser.");
		}
		if (System.IO.File.Exists(path))
		{
			System.IO.File.Delete(path);
		}
		nsIWebBrowserPersist nsIWebBrowserPersist2 = Xpcom.QueryInterface<nsIWebBrowserPersist>(WebBrowser);
		if (nsIWebBrowserPersist2 == null)
		{
			throw new InvalidOperationException();
		}
		nsIWebBrowserPersist2.SaveDocument((nsISupports)DomDocument._domDocument, (nsISupports)Xpcom.NewNativeLocalFile(path), null, outputMimeType, 0u, 0u);
	}

	void nsIWebBrowserChrome.SetStatus(uint statusType, string status)
	{
		StatusText = status;
	}

	nsIWebBrowser nsIWebBrowserChrome.GetWebBrowserAttribute()
	{
		return WebBrowser;
	}

	void nsIWebBrowserChrome.SetWebBrowserAttribute(nsIWebBrowser webBrowser)
	{
		WebBrowser = webBrowser;
	}

	uint nsIWebBrowserChrome.GetChromeFlagsAttribute()
	{
		return ChromeFlags;
	}

	void nsIWebBrowserChrome.SetChromeFlagsAttribute(uint flags)
	{
		ChromeFlags = flags;
	}

	public nsIXULWindow CreateNewWindow(int aChromeFlags, nsITabParent aOpeningTab)
	{
		throw new NotImplementedException();
	}

	void nsIWebBrowserChrome.DestroyBrowserWindow()
	{
		OnWindowClosed(EventArgs.Empty);
	}

	void nsIWebBrowserChrome.SizeBrowserTo(int cx, int cy)
	{
		OnWindowSetBounds(new GeckoWindowSetBoundsEventArgs(new Rectangle(0, 0, cx, cy), (BoundsSpecified)12));
	}

	void nsIWebBrowserChrome.ShowAsModal()
	{
		Debug.WriteLine("ShowAsModal");
		_IsWindowModal = true;
	}

	bool nsIWebBrowserChrome.IsWindowModal()
	{
		Debug.WriteLine("IsWindowModal");
		return _IsWindowModal;
	}

	void nsIWebBrowserChrome.ExitModalEventLoop(int status)
	{
		Debug.WriteLine("ExitModalEventLoop");
		_IsWindowModal = false;
	}

	void nsIContextMenuListener2.OnShowContextMenu(uint aContextFlags, nsIContextMenuInfo info)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected O, but got Unknown
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected O, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected O, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected O, but got Unknown
		if (info.GetTargetNodeAttribute() == null)
		{
			return;
		}
		if (menu == null)
		{
			menu = new ContextMenu();
		}
		((Menu)menu).get_MenuItems().Clear();
		if (!NoDefaultContextMenu)
		{
			List<MenuItem> list = new List<MenuItem>();
			if (CanUndo || CanRedo)
			{
				list.Add(new MenuItem("Undo", (EventHandler)delegate
				{
					Undo();
				}));
				list.Add(new MenuItem("Redo", (EventHandler)delegate
				{
					Redo();
				}));
				list[0].set_Enabled(CanUndo);
				list[1].set_Enabled(CanRedo);
			}
			else
			{
				list.Add(new MenuItem("Back", (EventHandler)delegate
				{
					GoBack();
				}));
				list.Add(new MenuItem("Forward", (EventHandler)delegate
				{
					GoForward();
				}));
				list[0].set_Enabled(CanGoBack);
				list[1].set_Enabled(CanGoForward);
			}
			list.Add(new MenuItem("-"));
			if (((ulong)aContextFlags & 2uL) > 0L)
			{
				if (CanCopyImageContents)
				{
					list.Add(new MenuItem("Copy Image Contents", (EventHandler)delegate
					{
						CopyImageContents();
					}));
				}
				if (CanCopyImageLocation)
				{
					list.Add(new MenuItem("Copy Image Location", (EventHandler)delegate
					{
						CopyImageLocation();
					}));
				}
			}
			if (((ulong)aContextFlags & 1uL) > 0L && CanCopyLinkLocation)
			{
				list.Add(new MenuItem("Copy Link Location", (EventHandler)delegate
				{
					CopyLinkLocation();
				}));
			}
			if (CanCopySelection)
			{
				list.Add(new MenuItem("Copy Selection", (EventHandler)delegate
				{
					CopySelection();
				}));
			}
			MenuItem val = new MenuItem("Select All");
			val.add_Click((EventHandler)delegate
			{
				SelectAll();
			});
			GeckoDomDocument doc = GeckoDomDocument.CreateDomDocumentWraper(info.GetTargetNodeAttribute().GetOwnerDocumentAttribute());
			string viewSourceUrl = ((doc == null) ? null : Convert.ToString(doc.Uri));
			MenuItem val2 = new MenuItem("View Source");
			val2.set_Enabled(!string.IsNullOrEmpty(viewSourceUrl));
			val2.add_Click((EventHandler)delegate
			{
				ViewSource(viewSourceUrl);
			});
			MenuItem val3 = new MenuItem("View In System Browser");
			val3.set_Enabled(!string.IsNullOrEmpty(viewSourceUrl));
			val3.add_Click((EventHandler)delegate
			{
				ViewInSystemBrowser(viewSourceUrl);
			});
			string text = ((doc == null || !(doc.Uri == Document.Uri)) ? "IFRAME Properties" : "Page Properties");
			MenuItem val4 = new MenuItem(text);
			val4.set_Enabled(doc != null);
			val4.add_Click((EventHandler)delegate
			{
				ShowPageProperties(doc);
			});
			((Menu)menu).get_MenuItems().AddRange(list.ToArray());
			((Menu)menu).get_MenuItems().Add(val);
			((Menu)menu).get_MenuItems().Add("-");
			((Menu)menu).get_MenuItems().Add(val2);
			((Menu)menu).get_MenuItems().Add(val3);
			((Menu)menu).get_MenuItems().Add(val4);
		}
		Uri backgroundImageSrc = null;
		Uri imageSrc = null;
		if (((ulong)aContextFlags & 0x20uL) > 0L)
		{
			nsIURI backgroundImageSrcAttribute = info.GetBackgroundImageSrcAttribute();
			if (backgroundImageSrcAttribute != null)
			{
				backgroundImageSrc = backgroundImageSrcAttribute.ToUri();
				Marshal.ReleaseComObject(backgroundImageSrcAttribute);
			}
		}
		if (((ulong)aContextFlags & 2uL) > 0L)
		{
			nsIURI backgroundImageSrcAttribute = info.GetImageSrcAttribute();
			if (backgroundImageSrcAttribute != null)
			{
				imageSrc = backgroundImageSrcAttribute.ToUri();
				Marshal.ReleaseComObject(backgroundImageSrcAttribute);
			}
		}
		string associatedLink = null;
		if (((ulong)aContextFlags & 1uL) > 0L)
		{
			using nsAString nsAString2 = new nsAString();
			info.GetAssociatedLinkAttribute(nsAString2);
			associatedLink = nsAString2.ToString();
		}
		using GeckoNode targetNode = GeckoNode.Create(Xpcom.QueryInterface<nsIDOMNode>(info.GetTargetNodeAttribute()));
		GeckoContextMenuEventArgs geckoContextMenuEventArgs = new GeckoContextMenuEventArgs(((Control)this).PointToClient(Control.get_MousePosition()), menu, associatedLink, backgroundImageSrc, imageSrc, targetNode);
		OnShowContextMenu(geckoContextMenuEventArgs);
		if (geckoContextMenuEventArgs.ContextMenu != null && ((Menu)geckoContextMenuEventArgs.ContextMenu).get_MenuItems().get_Count() > 0)
		{
			geckoContextMenuEventArgs.ContextMenu.Show((Control)(object)this, geckoContextMenuEventArgs.Location);
		}
	}

	private void ViewInSystemBrowser(string url)
	{
		Process.Start(url);
	}

	public void ViewSource()
	{
		ViewSource(Url.ToString());
	}

	public void ViewSource(string url)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		Form val = new Form();
		((Control)val).set_Text("View Source");
		GeckoWebBrowser browser = new GeckoWebBrowser();
		((Control)browser).set_Dock((DockStyle)5);
		((Control)val).get_Controls().Add((Control)(object)browser);
		val.add_Load((EventHandler)delegate
		{
			browser.Navigate("view-source:" + url);
		});
		try
		{
			Form val2 = ((Control)this).FindForm();
			if (val2 != null)
			{
				val.set_Icon(val2.get_Icon());
			}
		}
		catch (Exception)
		{
		}
		val.set_ClientSize(((Control)this).get_ClientSize());
		val.set_StartPosition((FormStartPosition)4);
		((Control)val).Show();
	}

	public void ShowPageProperties()
	{
		ShowPageProperties(Document);
	}

	public void ShowPageProperties(GeckoDomDocument document)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (document == null)
		{
			throw new ArgumentNullException("document");
		}
		((Form)new PropertiesDialog((nsIDOMDocument)document.DomObject)).ShowDialog((IWin32Window)(object)this);
	}

	IntPtr nsIInterfaceRequestor.GetInterface(ref Guid uuid)
	{
		object o = this;
		if (WebBrowser != null)
		{
			if (uuid == typeof(nsIDOMWindow).GUID)
			{
				o = WebBrowser.GetContentDOMWindowAttribute();
			}
			else if (uuid == typeof(nsIDOMDocument).GUID)
			{
				o = new Window(WebBrowser.GetContentDOMWindowAttribute(), (nsISupports)WebBrowser.GetContentDOMWindowAttribute()).Document;
			}
		}
		IntPtr iUnknownForObject = Marshal.GetIUnknownForObject(o);
		Marshal.QueryInterface(iUnknownForObject, ref uuid, out var ppv);
		Marshal.Release(iUnknownForObject);
		return ppv;
	}

	void nsIEmbeddingSiteWindow.SetDimensions(uint flags, int x, int y, int cx, int cy)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		BoundsSpecified val = (BoundsSpecified)0;
		if ((flags & (true ? 1u : 0u)) != 0)
		{
			val = (BoundsSpecified)(val | 3);
		}
		if ((flags & 2u) != 0 || (flags & 4u) != 0)
		{
			val = (BoundsSpecified)(val | 0xC);
		}
		OnWindowSetBounds(new GeckoWindowSetBoundsEventArgs(new Rectangle(x, y, cx, cy), val));
	}

	unsafe void nsIEmbeddingSiteWindow.GetDimensions(uint flags, int* x, int* y, int* cx, int* cy)
	{
		int num = ((x != null) ? (*x) : 0);
		int num2 = ((y != null) ? (*y) : 0);
		int cx2 = 0;
		int cy2 = 0;
		if (!((Control)this).get_IsDisposed())
		{
			if ((flags & (true ? 1u : 0u)) != 0)
			{
				Point point = ((Control)this).PointToScreen(Point.Empty);
				num = point.X;
				num2 = point.Y;
			}
			cx2 = ((Control)this).get_ClientSize().Width;
			cy2 = ((Control)this).get_ClientSize().Height;
			if ((ulong)(ChromeFlags & -2147483648L) > 0uL)
			{
				BaseWindow.GetSize(ref cx2, ref cy2);
			}
			if ((flags & 2) == 0)
			{
				Control topLevelControl = ((Control)this).get_TopLevelControl();
				if (topLevelControl != null)
				{
					Size size = new Size(topLevelControl.get_Width() - ((Control)this).get_ClientSize().Width, topLevelControl.get_Height() - ((Control)this).get_ClientSize().Height);
					cx2 += size.Width;
					cy2 += size.Height;
				}
			}
		}
		if (x != null)
		{
			*x = num;
		}
		if (y != null)
		{
			*y = num2;
		}
		if (cx != null)
		{
			*cx = cx2;
		}
		if (cy != null)
		{
			*cy = cy2;
		}
	}

	void nsIEmbeddingSiteWindow.SetFocus()
	{
		((Control)this).Focus();
		if (BaseWindow != null)
		{
			BaseWindow.SetFocus();
		}
	}

	bool nsIEmbeddingSiteWindow.GetVisibilityAttribute()
	{
		return ((Control)this).get_Visible();
	}

	void nsIEmbeddingSiteWindow.SetVisibilityAttribute(bool aVisibility)
	{
		((Control)this).set_Visible(aVisibility);
	}

	string nsIEmbeddingSiteWindow.GetTitleAttribute()
	{
		return DocumentTitle;
	}

	void nsIEmbeddingSiteWindow.SetTitleAttribute(string aTitle)
	{
		DocumentTitle = aTitle;
	}

	void nsIEmbeddingSiteWindow.Blur()
	{
	}

	void nsIWebProgressListener.OnStateChange(nsIWebProgress aWebProgress, nsIRequest aRequest, uint aStateFlags, int aStatus)
	{
		if (aRequest == null)
		{
			return;
		}
		nsIViewSourceChannel nsIViewSourceChannel2 = Xpcom.QueryInterface<nsIViewSourceChannel>(aRequest);
		if (nsIViewSourceChannel2 != null)
		{
			Marshal.ReleaseComObject(nsIViewSourceChannel2);
			return;
		}
		using Gecko.Net.Request request = Gecko.Net.Request.CreateRequest(aRequest);
		Uri result = null;
		Uri.TryCreate(request.Name, UriKind.Absolute, out result);
		GeckoWindow geckoWindow = aWebProgress.GetDOMWindowAttribute().Wrap((nsIDOMWindow x) => new GeckoWindow(x));
		bool flag = ((ulong)aStateFlags & 0x10000uL) > 0L;
		bool flag2 = ((ulong)aStateFlags & 0x20000uL) > 0L;
		bool flag3 = ((ulong)aStateFlags & 0x40000uL) > 0L;
		if (((ulong)aStateFlags & 1uL) > 0L)
		{
			if (flag3 && aWebProgress.GetIsTopLevelAttribute())
			{
				IsBusy = true;
				GeckoNavigatingEventArgs geckoNavigatingEventArgs = new GeckoNavigatingEventArgs(result, geckoWindow);
				OnNavigating(geckoNavigatingEventArgs);
				if (geckoNavigatingEventArgs.Cancel)
				{
					aRequest.Cancel(-2142568446);
					IsBusy = false;
					OnProgressChanged(new GeckoProgressEventArgs(100L, 100L));
					StatusText = "";
				}
			}
			else if (flag2)
			{
				GeckoNavigatingEventArgs geckoNavigatingEventArgs2 = new GeckoNavigatingEventArgs(result, geckoWindow);
				OnFrameNavigating(geckoNavigatingEventArgs2);
				if (geckoNavigatingEventArgs2.Cancel && !Xpcom.IsLinux)
				{
					aRequest.Cancel(-2142568446);
				}
			}
		}
		else if (((ulong)aStateFlags & 2uL) > 0L)
		{
			GeckoRedirectingEventArgs geckoRedirectingEventArgs = new GeckoRedirectingEventArgs(result, geckoWindow);
			OnRedirecting(geckoRedirectingEventArgs);
			if (geckoRedirectingEventArgs.Cancel)
			{
				aRequest.Cancel(-2142568446);
			}
		}
		else if (((ulong)aStateFlags & 4uL) <= 0L && ((ulong)aStateFlags & 0x10uL) > 0L)
		{
			if (flag3)
			{
				IsBusy = false;
				if (aStatus == 0)
				{
					if (!request.IsPending)
					{
						OnDocumentCompleted(new GeckoDocumentCompletedEventArgs(result, geckoWindow));
						OnProgressChanged(new GeckoProgressEventArgs(100L, 100L));
					}
				}
				else
				{
					OnNavigationError(new GeckoNavigationErrorEventArgs(request.Name, geckoWindow, aStatus));
				}
				StatusText = "";
			}
			if (flag)
			{
				if ((aStatus & 0xFF0000) == 5898240)
				{
					SSLStatus sslStatus = null;
					nsIChannel obj = null;
					nsISupports obj2 = null;
					nsISSLStatusProvider obj3 = null;
					try
					{
						obj = Xpcom.QueryInterface<nsIChannel>(aRequest);
						if (obj != null)
						{
							obj2 = obj.GetSecurityInfoAttribute();
							if (obj2 != null)
							{
								obj3 = Xpcom.QueryInterface<nsISSLStatusProvider>(obj2);
								if (obj3 != null)
								{
									sslStatus = obj3.GetSSLStatusAttribute().Wrap(SSLStatus.Create);
								}
							}
						}
					}
					finally
					{
						Xpcom.FreeComObject(ref obj);
						Xpcom.FreeComObject(ref obj2);
						Xpcom.FreeComObject(ref obj3);
					}
					GeckoNSSErrorEventArgs geckoNSSErrorEventArgs = new GeckoNSSErrorEventArgs(result, aStatus, sslStatus);
					OnNSSError(geckoNSSErrorEventArgs);
					if (geckoNSSErrorEventArgs.Handled)
					{
						aRequest.Cancel(-2142568446);
					}
				}
				if (aStatus == -2142568444)
				{
					GeckoRetargetedEventArgs e = new GeckoRetargetedEventArgs(result, geckoWindow, request);
					OnRetargeted(e);
				}
			}
		}
		geckoWindow?.Dispose();
	}

	void nsIWebProgressListener.OnProgressChange(nsIWebProgress aWebProgress, nsIRequest aRequest, int aCurSelfProgress, int aMaxSelfProgress, int aCurTotalProgress, int aMaxTotalProgress)
	{
		using (Gecko.Net.Request.CreateRequest(aRequest))
		{
			if (aCurSelfProgress != -1 && aMaxSelfProgress != -1)
			{
				OnRequestProgressChanged(new GeckoRequestProgressEventArgs(aCurTotalProgress, aMaxTotalProgress, aRequest));
			}
			if (aCurTotalProgress != -1 && aMaxTotalProgress != -1)
			{
				OnProgressChanged(new GeckoProgressEventArgs(aCurTotalProgress, aMaxTotalProgress));
			}
		}
	}

	void nsIWebProgressListener.OnLocationChange(nsIWebProgress aWebProgress, nsIRequest aRequest, nsIURI aLocation, uint flags)
	{
		if (!((Control)this).get_IsDisposed())
		{
			Uri value = new Uri(nsString.Get(aLocation.GetSpecAttribute));
			using (GeckoWindow domWind = aWebProgress.GetDOMWindowAttribute().Wrap((nsIDOMWindow x) => new GeckoWindow(x)))
			{
				bool sameDocument = ((ulong)flags & 1uL) > 0L;
				bool errorPage = ((ulong)flags & 2uL) > 0L;
				GeckoNavigatedEventArgs e = new GeckoNavigatedEventArgs(value, aRequest, domWind, sameDocument, errorPage);
				OnNavigated(e);
			}
			UpdateCommandStatus();
		}
	}

	void nsIWebProgressListener.OnStatusChange(nsIWebProgress aWebProgress, nsIRequest aRequest, int aStatus, string aMessage)
	{
		if (aWebProgress.GetIsLoadingDocumentAttribute())
		{
			StatusText = aMessage;
			UpdateCommandStatus();
		}
	}

	void nsIWebProgressListener.OnSecurityChange(nsIWebProgress aWebProgress, nsIRequest aRequest, uint aState)
	{
		SecurityState = (GeckoSecurityState)aState;
	}

	protected virtual void OnSecurityStateChanged(EventArgs e)
	{
		if ((EventHandler)((Component)this).Events[SecurityStateChangedEvent] != null)
		{
			((EventHandler)((Component)this).Events[SecurityStateChangedEvent])(this, e);
		}
	}

	void nsIWebProgressListener2.OnStateChange(nsIWebProgress aWebProgress, nsIRequest aRequest, uint aStateFlags, int aStatus)
	{
		throw new NotImplementedException("implemented in nsIWebProgressListener");
	}

	void nsIWebProgressListener2.OnProgressChange(nsIWebProgress aWebProgress, nsIRequest aRequest, int aCurSelfProgress, int aMaxSelfProgress, int aCurTotalProgress, int aMaxTotalProgress)
	{
		throw new NotImplementedException("implemented in nsIWebProgressListener");
	}

	void nsIWebProgressListener2.OnLocationChange(nsIWebProgress aWebProgress, nsIRequest aRequest, nsIURI aLocation, uint aFlags)
	{
		throw new NotImplementedException("implemented in nsIWebProgressListener");
	}

	void nsIWebProgressListener2.OnStatusChange(nsIWebProgress aWebProgress, nsIRequest aRequest, int aStatus, string aMessage)
	{
		throw new NotImplementedException("implemented in nsIWebProgressListener");
	}

	void nsIWebProgressListener2.OnSecurityChange(nsIWebProgress aWebProgress, nsIRequest aRequest, uint aState)
	{
		throw new NotImplementedException("implemented in nsIWebProgressListener");
	}

	void nsIWebProgressListener2.OnProgressChange64(nsIWebProgress aWebProgress, nsIRequest aRequest, long aCurSelfProgress, long aMaxSelfProgress, long aCurTotalProgress, long aMaxTotalProgress)
	{
		if (aCurSelfProgress != -1L && aMaxSelfProgress != -1L)
		{
			OnRequestProgressChanged(new GeckoRequestProgressEventArgs(aCurTotalProgress, aMaxSelfProgress, aRequest));
		}
		if (aCurTotalProgress != -1L && aMaxTotalProgress != -1L)
		{
			OnProgressChanged(new GeckoProgressEventArgs(aCurTotalProgress, aMaxTotalProgress));
		}
	}

	bool nsIWebProgressListener2.OnRefreshAttempted(nsIWebProgress aWebProgress, nsIURI aRefreshURI, int aMillis, bool aSameURI)
	{
		Uri value = new Uri(nsString.Get(aRefreshURI.GetSpecAttribute));
		bool flag = false;
		using (GeckoWindow domWind = aWebProgress.GetDOMWindowAttribute().Wrap((nsIDOMWindow x) => new GeckoWindow(x)))
		{
			GeckoNavigatingEventArgs geckoNavigatingEventArgs = new GeckoNavigatingEventArgs(value, domWind);
			flag = geckoNavigatingEventArgs.Cancel;
		}
		return !flag;
	}

	void nsIDOMEventListener.HandleEvent(nsIDOMEvent e)
	{
		if (e != null)
		{
			OnHandleDomEvent(DomEventArgs.Create(e));
		}
	}

	protected virtual void OnHandleDomEvent(DomEventArgs e)
	{
		switch (e.Type)
		{
		case "mousedown":
			OnDomMouseDown((DomMouseEventArgs)e);
			break;
		case "focus":
			OnDomFocus(e);
			break;
		case "compositionend":
			OnDomCompositionEnd(e);
			break;
		case "DOMMouseScroll":
			OnDomMouseScroll((DomMouseEventArgs)e);
			break;
		case "keyup":
			OnDomKeyUp((DomKeyEventArgs)e);
			break;
		case "dragend":
			OnDomDragEnd((DomDragEventArgs)e);
			break;
		case "keydown":
			OnDomKeyDown((DomKeyEventArgs)e);
			break;
		case "dragleave":
			OnDomDragLeave((DomDragEventArgs)e);
			break;
		case "click":
			OnDomClick((DomMouseEventArgs)e);
			break;
		case "change":
			OnDomContentChanged(e);
			break;
		case "blur":
			OnDomBlur(e);
			break;
		case "mouseout":
			OnDomMouseOut((DomMouseEventArgs)e);
			break;
		case "dblclick":
			OnDomDoubleClick((DomMouseEventArgs)e);
			break;
		case "readystatechange":
			OnReadyStateChange(e);
			break;
		case "mozfullscreenchange":
			OnFullscreenChange(e);
			break;
		case "drop":
			OnDomDrop((DomDragEventArgs)e);
			break;
		case "dragenter":
			OnDomDragEnter((DomDragEventArgs)e);
			break;
		case "compositionstart":
			OnDomCompositionStart(e);
			break;
		case "drag":
			OnDomDrag((DomDragEventArgs)e);
			break;
		case "DOMContentLoaded":
			OnDOMContentLoaded(e);
			break;
		case "dragover":
			OnDomDragOver((DomDragEventArgs)e);
			break;
		case "contextmenu":
			OnDomContextMenu((DomMouseEventArgs)e);
			break;
		case "keypress":
			OnDomKeyPress((DomKeyEventArgs)e);
			break;
		case "mouseover":
			OnDomMouseOver((DomMouseEventArgs)e);
			break;
		case "mousemove":
			OnDomMouseMove((DomMouseEventArgs)e);
			break;
		case "load":
			OnLoad(e);
			break;
		case "submit":
			OnDomSubmit(e);
			break;
		case "mouseup":
			OnDomMouseUp((DomMouseEventArgs)e);
			break;
		case "dragstart":
			OnDomDragStart((DomDragEventArgs)e);
			break;
		case "input":
			OnDomInput(e);
			break;
		}
		if (e is DomMessageEventArgs)
		{
			DomMessageEventArgs domMessageEventArgs = (DomMessageEventArgs)e;
			if (_messageEventListeners.TryGetValue(e.Type, out var value))
			{
				value.Key(domMessageEventArgs.Message);
			}
		}
		if (e != null && e.Cancelable && e.Handled)
		{
			e.PreventDefault();
		}
	}

	void nsISHistoryListener.OnHistoryNewEntry(nsIURI aNewURI)
	{
		OnHistoryNewEntry(new GeckoHistoryEventArgs(new Uri(nsString.Get(aNewURI.GetSpecAttribute))));
	}

	bool nsISHistoryListener.OnHistoryGoBack(nsIURI aBackURI)
	{
		GeckoHistoryEventArgs geckoHistoryEventArgs = new GeckoHistoryEventArgs(new Uri(nsString.Get(aBackURI.GetSpecAttribute)));
		OnHistoryGoBack(geckoHistoryEventArgs);
		return !geckoHistoryEventArgs.Cancel;
	}

	bool nsISHistoryListener.OnHistoryGoForward(nsIURI aForwardURI)
	{
		GeckoHistoryEventArgs geckoHistoryEventArgs = new GeckoHistoryEventArgs(new Uri(nsString.Get(aForwardURI.GetSpecAttribute)));
		OnHistoryGoForward(geckoHistoryEventArgs);
		return !geckoHistoryEventArgs.Cancel;
	}

	bool nsISHistoryListener.OnHistoryReload(nsIURI aReloadURI, uint aReloadFlags)
	{
		GeckoHistoryEventArgs geckoHistoryEventArgs = new GeckoHistoryEventArgs(new Uri(nsString.Get(aReloadURI.GetSpecAttribute)));
		OnHistoryReload(geckoHistoryEventArgs);
		return !geckoHistoryEventArgs.Cancel;
	}

	bool nsISHistoryListener.OnHistoryGotoIndex(int aIndex, nsIURI aGotoURI)
	{
		GeckoHistoryGotoIndexEventArgs geckoHistoryGotoIndexEventArgs = new GeckoHistoryGotoIndexEventArgs(new Uri(nsString.Get(aGotoURI.GetSpecAttribute)), aIndex);
		OnHistoryGotoIndex(geckoHistoryGotoIndexEventArgs);
		return !geckoHistoryGotoIndexEventArgs.Cancel;
	}

	bool nsISHistoryListener.OnHistoryPurge(int aNumEntries)
	{
		GeckoHistoryPurgeEventArgs geckoHistoryPurgeEventArgs = new GeckoHistoryPurgeEventArgs(aNumEntries);
		OnHistoryPurge(geckoHistoryPurgeEventArgs);
		return !geckoHistoryPurgeEventArgs.Cancel;
	}

	void nsISHistoryListener.OnHistoryReplaceEntry(int aIndex)
	{
		OnHistoryReplaceEntry(new GeckoHistoryRepalaceEntryEventArgs(aIndex));
	}

	void nsITooltipListener.OnShowTooltip(int aXCoords, int aYCoords, string aTipText)
	{
		if (true.Equals(GeckoPreferences.User["browser.chrome.toolbar_tips"]))
		{
			ToolTip = new ToolTipWindow();
			((ToolTip)ToolTip).Show(aTipText, (IWin32Window)(object)this, new Point(aXCoords, aYCoords + 24));
		}
	}

	void nsITooltipListener.OnHideTooltip()
	{
		if (ToolTip != null)
		{
			((ToolTip)ToolTip).Hide((IWin32Window)(object)this);
			((Component)(object)ToolTip).Dispose();
			ToolTip = null;
		}
	}

	public void AddMessageEventListener(string eventName, Action<string> action)
	{
		AddMessageEventListener(eventName, action, useCapture: true);
	}

	public void AddMessageEventListener(string eventName, Action<string> action, bool useCapture)
	{
		nsIDOMEventTarget nsIDOMEventTarget2 = Xpcom.QueryInterface<nsIDOMEventTarget>(Window.DomWindow);
		if (nsIDOMEventTarget2 != null)
		{
			nsIDOMEventTarget2.AddEventListener(new nsAString(eventName), this, useCapture, wantsUntrusted: true, 2);
			if (_messageEventListeners.ContainsKey(eventName))
			{
				_messageEventListeners[eventName] = new KeyValuePair<Action<string>, bool>(action, useCapture);
			}
			else
			{
				_messageEventListeners.Add(eventName, new KeyValuePair<Action<string>, bool>(action, useCapture));
			}
		}
	}

	public void RemoveMessageEventListener(string eventName)
	{
		RemoveMessageEventListener(eventName, useCapture: true);
	}

	public void RemoveMessageEventListener(string eventName, bool useCapture)
	{
		nsIDOMEventTarget nsIDOMEventTarget2 = Xpcom.QueryInterface<nsIDOMEventTarget>(Window.DomWindow);
		if (nsIDOMEventTarget2 != null && _messageEventListeners.ContainsKey(eventName))
		{
			nsIDOMEventTarget2.RemoveEventListener(new nsAString(eventName), this, useCapture);
			_messageEventListeners.Remove(eventName);
		}
	}

	public void Observe(nsISupports aSubject, string aTopic, string aData)
	{
		if (!aTopic.Equals("http-on-modify-request"))
		{
			return;
		}
		using HttpChannel httpChannel = HttpChannel.Create(aSubject);
		_ = httpChannel.OriginalUri;
		Uri uri = httpChannel.Uri;
		Uri referrer = httpChannel.Referrer;
		string requestMethod = httpChannel.RequestMethod;
		List<KeyValuePair<string, string>> requestHeaders = httpChannel.GetRequestHeaders();
		byte[] reqBody = null;
		bool? bodyContainsHeaders = null;
		nsIUploadChannel nsIUploadChannel3 = Xpcom.QueryInterface<nsIUploadChannel>(aSubject);
		nsIUploadChannel2 nsIUploadChannel4 = Xpcom.QueryInterface<nsIUploadChannel2>(aSubject);
		if (nsIUploadChannel3 != null)
		{
			UploadChannel uploadChannel = new UploadChannel(nsIUploadChannel3);
			Gecko.IO.InputStream uploadStream = uploadChannel.UploadStream;
			if (uploadStream != null && uploadStream.CanSeek)
			{
				BinaryReader binaryReader = new BinaryReader(uploadStream);
				MemoryStream memoryStream = new MemoryStream();
				try
				{
					reqBody = new byte[0];
					int num = 0;
					while ((num = (int)uploadStream.Available) > 0)
					{
						memoryStream.Write(binaryReader.ReadBytes(num), 0, num);
					}
					reqBody = memoryStream.ToArray();
					if (nsIUploadChannel4 != null)
					{
						bodyContainsHeaders = nsIUploadChannel4.GetUploadStreamHasHeadersAttribute();
					}
				}
				catch (IOException)
				{
				}
				uploadStream.Seek(0L, SeekOrigin.Begin);
			}
		}
		GeckoObserveHttpModifyRequestEventArgs geckoObserveHttpModifyRequestEventArgs = new GeckoObserveHttpModifyRequestEventArgs(uri, referrer, requestMethod, reqBody, requestHeaders, httpChannel, bodyContainsHeaders);
		OnObserveHttpModifyRequest(geckoObserveHttpModifyRequestEventArgs);
		if (geckoObserveHttpModifyRequestEventArgs.Cancel)
		{
			httpChannel.Cancel(-2142568446);
		}
	}

	public void ObserveActivity(nsISupports aHttpChannel, uint aActivityType, uint aActivitySubtype, long aTimestamp, ulong aExtraSizeData, nsACStringBase aExtraStringData)
	{
		nsIHttpChannel nsIHttpChannel2 = Xpcom.QueryInterface<nsIHttpChannel>(aHttpChannel);
		if (nsIHttpChannel2 == null)
		{
			return;
		}
		switch (aActivityType)
		{
		case 2u:
			switch (aActivitySubtype)
			{
			case 20481u:
			{
				activeNetworkChannels++;
				ActiveNetworkChannelUrls.Add(nsString.Get(nsIHttpChannel2.GetURIAttribute().GetSpecAttribute));
				nsIInterfaceRequestor notificationCallbacksAttribute = nsIHttpChannel2.GetNotificationCallbacksAttribute();
				if (notificationCallbacksAttribute == null)
				{
					break;
				}
				nsIXMLHttpRequest nsIXMLHttpRequest2 = Xpcom.QueryInterface<nsIXMLHttpRequest>(notificationCallbacksAttribute);
				if (nsIXMLHttpRequest2 != null)
				{
					nsIXMLHttpRequestEventTarget nsIXMLHttpRequestEventTarget2 = Xpcom.QueryInterface<nsIXMLHttpRequestEventTarget>(nsIXMLHttpRequest2);
					if (nsIXMLHttpRequestEventTarget2 != null)
					{
						GeckoJavaScriptHttpChannelWrapper geckoJavaScriptHttpChannelWrapper = new GeckoJavaScriptHttpChannelWrapper(this, nsIHttpChannel2);
						origJavaScriptHttpChannels.Add(nsIHttpChannel2, geckoJavaScriptHttpChannelWrapper);
						using (nsAString type = new nsAString("load"))
						{
							nsIXMLHttpRequestEventTarget2.AddEventListener(type, geckoJavaScriptHttpChannelWrapper, useCapture: true, wantsUntrusted: false, 0);
						}
						using (nsAString type2 = new nsAString("abort"))
						{
							nsIXMLHttpRequestEventTarget2.AddEventListener(type2, geckoJavaScriptHttpChannelWrapper, useCapture: true, wantsUntrusted: false, 0);
						}
						using (nsAString type3 = new nsAString("error"))
						{
							nsIXMLHttpRequestEventTarget2.AddEventListener(type3, geckoJavaScriptHttpChannelWrapper, useCapture: true, wantsUntrusted: false, 0);
						}
						Marshal.ReleaseComObject(nsIXMLHttpRequestEventTarget2);
					}
					Marshal.ReleaseComObject(nsIXMLHttpRequest2);
				}
				Marshal.ReleaseComObject(notificationCallbacksAttribute);
				break;
			}
			case 20486u:
				activeNetworkChannels--;
				ActiveNetworkChannelUrls.Remove(nsString.Get(nsIHttpChannel2.GetURIAttribute().GetSpecAttribute));
				break;
			case 20482u:
			case 20483u:
			case 20484u:
			case 20485u:
				break;
			}
			break;
		case 1u:
			switch (aActivitySubtype)
			{
			}
			break;
		}
	}

	public bool GetIsActiveAttribute()
	{
		return true;
	}

	public nsIWeakReference GetWeakReference()
	{
		if (_weakRef == null)
		{
			return _weakRef = new GeckoWebBrowserWeakRef(this);
		}
		return _weakRef;
	}

	protected virtual void OnNavigating(GeckoNavigatingEventArgs e)
	{
		((EventHandler<GeckoNavigatingEventArgs>)((Component)this).Events[NavigatingEvent])?.Invoke(this, e);
	}

	protected virtual void OnRetargeted(GeckoRetargetedEventArgs e)
	{
		((EventHandler<GeckoRetargetedEventArgs>)((Component)this).Events[RetargetedEvent])?.Invoke(this, e);
	}

	protected virtual void OnNavigated(GeckoNavigatedEventArgs e)
	{
		DetachEvents(lazy: true);
		AttachEvents();
		ReattachMessageEventListerns();
		((EventHandler<GeckoNavigatedEventArgs>)((Component)this).Events[NavigatedEvent])?.Invoke(this, e);
	}

	protected virtual void OnNavigationError(GeckoNavigationErrorEventArgs e)
	{
		((EventHandler<GeckoNavigationErrorEventArgs>)((Component)this).Events[NavigationErrorEvent])?.Invoke(this, e);
	}

	protected virtual void OnRedirecting(GeckoRedirectingEventArgs e)
	{
		((EventHandler<GeckoRedirectingEventArgs>)((Component)this).Events[RedirectingEvent])?.Invoke(this, e);
	}

	protected virtual void OnFrameNavigating(GeckoNavigatingEventArgs e)
	{
		((EventHandler<GeckoNavigatingEventArgs>)((Component)this).Events[FrameNavigatingEvent])?.Invoke(this, e);
	}

	protected virtual void OnDocumentCompleted(GeckoDocumentCompletedEventArgs e)
	{
		AttachFrameEvents();
		((EventHandler<GeckoDocumentCompletedEventArgs>)((Component)this).Events[DocumentCompletedEvent])?.Invoke(this, e);
	}

	protected virtual void OnCanGoBackChanged(EventArgs e)
	{
		((EventHandler)((Component)this).Events[CanGoBackChangedEvent])?.Invoke(this, e);
	}

	protected virtual void OnCanGoForwardChanged(EventArgs e)
	{
		((EventHandler)((Component)this).Events[CanGoForwardChangedEvent])?.Invoke(this, e);
	}

	protected virtual void OnHistoryNewEntry(GeckoHistoryEventArgs e)
	{
		((EventHandler<GeckoHistoryEventArgs>)((Component)this).Events[HistoryNewEntryEvent])?.Invoke(this, e);
	}

	protected virtual void OnHistoryGoBack(GeckoHistoryEventArgs e)
	{
		((EventHandler<GeckoHistoryEventArgs>)((Component)this).Events[HistoryGoBackEvent])?.Invoke(this, e);
	}

	protected virtual void OnHistoryGoForward(GeckoHistoryEventArgs e)
	{
		((EventHandler<GeckoHistoryEventArgs>)((Component)this).Events[HistoryGoForwardEvent])?.Invoke(this, e);
	}

	protected virtual void OnHistoryReload(GeckoHistoryEventArgs e)
	{
		((EventHandler<GeckoHistoryEventArgs>)((Component)this).Events[HistoryReloadEvent])?.Invoke(this, e);
	}

	protected virtual void OnHistoryGotoIndex(GeckoHistoryGotoIndexEventArgs e)
	{
		((EventHandler<GeckoHistoryGotoIndexEventArgs>)((Component)this).Events[HistoryGotoIndexEvent])?.Invoke(this, e);
	}

	protected virtual void OnHistoryPurge(GeckoHistoryPurgeEventArgs e)
	{
		((EventHandler<GeckoHistoryPurgeEventArgs>)((Component)this).Events[HistoryPurgeEvent])?.Invoke(this, e);
	}

	protected virtual void OnHistoryReplaceEntry(GeckoHistoryRepalaceEntryEventArgs e)
	{
		((EventHandler<GeckoHistoryRepalaceEntryEventArgs>)((Component)this).Events[HistoryReplaceEntryEvent])?.Invoke(this, e);
	}

	protected virtual void OnRequestProgressChanged(GeckoRequestProgressEventArgs e)
	{
		((EventHandler<GeckoRequestProgressEventArgs>)((Component)this).Events[RequestProgressChangedEvent])?.Invoke(this, e);
	}

	protected virtual void OnProgressChanged(GeckoProgressEventArgs e)
	{
		((EventHandler<GeckoProgressEventArgs>)((Component)this).Events[ProgressChangedEvent])?.Invoke(this, e);
	}

	protected virtual void OnCreateWindow(GeckoCreateWindowEventArgs e)
	{
		((EventHandler<GeckoCreateWindowEventArgs>)((Component)this).Events[CreateWindowEvent])?.Invoke(this, e);
	}

	protected virtual void OnCreateWindow2(GeckoCreateWindow2EventArgs e)
	{
		((EventHandler<GeckoCreateWindow2EventArgs>)((Component)this).Events[CreateWindow2Event])?.Invoke(this, e);
	}

	protected virtual void OnWindowSetBounds(GeckoWindowSetBoundsEventArgs e)
	{
		((EventHandler<GeckoWindowSetBoundsEventArgs>)((Component)this).Events[WindowSetBoundsEvent])?.Invoke(this, e);
	}

	protected virtual void OnWindowClosed(EventArgs e)
	{
		((EventHandler)((Component)this).Events[WindowClosedEvent])?.Invoke(this, e);
	}

	protected virtual void OnStatusTextChanged(EventArgs e)
	{
		((EventHandler)((Component)this).Events[StatusTextChangedEvent])?.Invoke(this, e);
	}

	protected virtual void OnDocumentTitleChanged(EventArgs e)
	{
		((EventHandler)((Component)this).Events[DocumentTitleChangedEvent])?.Invoke(this, e);
	}

	protected virtual void OnShowContextMenu(GeckoContextMenuEventArgs e)
	{
		((EventHandler<GeckoContextMenuEventArgs>)((Component)this).Events[ShowContextMenuEvent])?.Invoke(this, e);
	}

	protected virtual void OnObserveHttpModifyRequest(GeckoObserveHttpModifyRequestEventArgs e)
	{
		((EventHandler<GeckoObserveHttpModifyRequestEventArgs>)((Component)this).Events[ObserveHttpModifyRequestEvent])?.Invoke(this, e);
	}

	protected virtual void OnDomKeyDown(DomKeyEventArgs e)
	{
		((EventHandler<DomKeyEventArgs>)((Component)this).Events[DomKeyDownEvent])?.Invoke(this, e);
	}

	protected virtual void OnDomKeyUp(DomKeyEventArgs e)
	{
		((EventHandler<DomKeyEventArgs>)((Component)this).Events[DomKeyUpEvent])?.Invoke(this, e);
	}

	protected virtual void OnDomKeyPress(DomKeyEventArgs e)
	{
		((EventHandler<DomKeyEventArgs>)((Component)this).Events[DomKeyPressEvent])?.Invoke(this, e);
	}

	protected virtual void OnDomMouseDown(DomMouseEventArgs e)
	{
		((EventHandler<DomMouseEventArgs>)((Component)this).Events[DomMouseDownEvent])?.Invoke(this, e);
	}

	protected virtual void OnDomMouseUp(DomMouseEventArgs e)
	{
		((EventHandler<DomMouseEventArgs>)((Component)this).Events[DomMouseUpEvent])?.Invoke(this, e);
	}

	protected virtual void OnDomMouseOver(DomMouseEventArgs e)
	{
		((EventHandler<DomMouseEventArgs>)((Component)this).Events[DomMouseOverEvent])?.Invoke(this, e);
	}

	protected virtual void OnDomMouseOut(DomMouseEventArgs e)
	{
		((EventHandler<DomMouseEventArgs>)((Component)this).Events[DomMouseOutEvent])?.Invoke(this, e);
	}

	protected virtual void OnDomMouseMove(DomMouseEventArgs e)
	{
		((EventHandler<DomMouseEventArgs>)((Component)this).Events[DomMouseMoveEvent])?.Invoke(this, e);
	}

	protected virtual void OnDomContextMenu(DomMouseEventArgs e)
	{
		((EventHandler<DomMouseEventArgs>)((Component)this).Events[DomContextMenuEvent])?.Invoke(this, e);
	}

	protected virtual void OnDomMouseScroll(DomMouseEventArgs e)
	{
		((EventHandler<DomMouseEventArgs>)((Component)this).Events[DomMouseScrollEvent])?.Invoke(this, e);
	}

	protected virtual void OnDomSubmit(DomEventArgs e)
	{
		((EventHandler<DomEventArgs>)((Component)this).Events[DomSubmitEvent])?.Invoke(this, e);
	}

	protected virtual void OnDomCompositionStart(DomEventArgs e)
	{
		((EventHandler<DomEventArgs>)((Component)this).Events[DomCompositionStartEvent])?.Invoke(this, e);
	}

	protected virtual void OnDomCompositionEnd(DomEventArgs e)
	{
		((EventHandler<DomEventArgs>)((Component)this).Events[DomCompositionEndEvent])?.Invoke(this, e);
	}

	protected virtual void OnDomFocus(DomEventArgs e)
	{
		((EventHandler<DomEventArgs>)((Component)this).Events[DomFocusEvent])?.Invoke(this, e);
	}

	protected virtual void OnDomBlur(DomEventArgs e)
	{
		((EventHandler<DomEventArgs>)((Component)this).Events[DomBlurEvent])?.Invoke(this, e);
	}

	protected virtual void OnLoad(DomEventArgs e)
	{
		((EventHandler<DomEventArgs>)((Component)this).Events[LoadEvent])?.Invoke(this, e);
	}

	protected virtual void OnDOMContentLoaded(DomEventArgs e)
	{
		((EventHandler<DomEventArgs>)((Component)this).Events[DOMContentLoadedEvent])?.Invoke(this, e);
	}

	protected virtual void OnReadyStateChange(DomEventArgs e)
	{
		((EventHandler<DomEventArgs>)((Component)this).Events[ReadyStateChangeEvent])?.Invoke(this, e);
	}

	protected virtual void OnDomDragStart(DomDragEventArgs e)
	{
		((EventHandler<DomDragEventArgs>)((Component)this).Events[DomDragStartEvent])?.Invoke(this, e);
	}

	protected virtual void OnDomDragEnter(DomDragEventArgs e)
	{
		((EventHandler<DomDragEventArgs>)((Component)this).Events[DomDragEnterEvent])?.Invoke(this, e);
	}

	protected virtual void OnDomDragOver(DomDragEventArgs e)
	{
		((EventHandler<DomDragEventArgs>)((Component)this).Events[DomDragOverEvent])?.Invoke(this, e);
	}

	protected virtual void OnDomDragLeave(DomDragEventArgs e)
	{
		((EventHandler<DomDragEventArgs>)((Component)this).Events[DomDragLeaveEvent])?.Invoke(this, e);
	}

	protected virtual void OnDomDrag(DomDragEventArgs e)
	{
		((EventHandler<DomDragEventArgs>)((Component)this).Events[DomDragEvent])?.Invoke(this, e);
	}

	protected virtual void OnDomDrop(DomDragEventArgs e)
	{
		((EventHandler<DomDragEventArgs>)((Component)this).Events[DomDropEvent])?.Invoke(this, e);
	}

	protected virtual void OnDomDragEnd(DomDragEventArgs e)
	{
		((EventHandler<DomDragEventArgs>)((Component)this).Events[DomDragEndEvent])?.Invoke(this, e);
	}

	protected virtual void OnDomContentChanged(DomEventArgs e)
	{
		((EventHandler<DomEventArgs>)((Component)this).Events[DomContentChangedEvent])?.Invoke(this, e);
	}

	protected virtual void OnDomClick(DomMouseEventArgs e)
	{
		((EventHandler<DomMouseEventArgs>)((Component)this).Events[DomClickEvent])?.Invoke(this, e);
	}

	protected virtual void OnDomDoubleClick(DomMouseEventArgs e)
	{
		((EventHandler<DomMouseEventArgs>)((Component)this).Events[DomDoubleClickEvent])?.Invoke(this, e);
	}

	protected virtual void OnFullscreenChange(DomEventArgs e)
	{
		((EventHandler<DomEventArgs>)((Component)this).Events[FullscreenChangeEvent])?.Invoke(this, e);
	}

	protected virtual void OnDomInput(DomEventArgs e)
	{
		((EventHandler<DomEventArgs>)((Component)this).Events[InputEvent])?.Invoke(this, e);
	}

	public void EnableConsoleMessageNotfication()
	{
		using ComPtr<nsIConsoleService> comPtr = Xpcom.GetService2<nsIConsoleService>("@mozilla.org/consoleservice;1");
		comPtr.Instance.RegisterListener(new ConsoleListener(this));
	}

	protected virtual void OnConsoleMessage(ConsoleMessageEventArgs e)
	{
		if (_ConsoleMessage != null)
		{
			_ConsoleMessage(this, e);
		}
	}

	protected virtual void OnNSSError(GeckoNSSErrorEventArgs e)
	{
		((EventHandler<GeckoNSSErrorEventArgs>)((Component)this).Events[NSSErrorEvent])?.Invoke(this, e);
	}

	public nsIDocShell GetDocShellAttribute()
	{
		return Xpcom.QueryInterface<nsIDocShell>(WebBrowser);
	}

	public bool GetIntrinsicallySizedAttribute()
	{
		Debug.WriteLine("GetIntrinsicallySizedAttribute called");
		return false;
	}

	public void SetIntrinsicallySizedAttribute(bool aIntrinsicallySized)
	{
		Debug.WriteLine("SetIntrinsicallySizedAttribute called");
	}

	public nsIDocShellTreeItem GetPrimaryContentShellAttribute()
	{
		Debug.WriteLine("GetPrimaryContentShellAttribute called");
		return null;
	}

	public nsITabParent GetPrimaryTabParentAttribute()
	{
		Debug.WriteLine("GetPrimaryTabParentAttribute called");
		return null;
	}

	public void TabParentAdded(nsITabParent aTab, bool aPrimary)
	{
		Debug.WriteLine("TabParentAdded called");
	}

	public void TabParentRemoved(nsITabParent aTab)
	{
		Debug.WriteLine("TabParentRemoved called");
	}

	public nsIDocShellTreeItem GetContentShellById(string ID)
	{
		Debug.WriteLine("GetContentShellById called");
		return null;
	}

	public void AddChildWindow(nsIXULWindow aChild)
	{
		Debug.WriteLine("AddChildWindow called");
	}

	public void RemoveChildWindow(nsIXULWindow aChild)
	{
		Debug.WriteLine("RemoveChildWindow called");
	}

	public void Center(nsIXULWindow aRelative, bool aScreen, bool aAlert)
	{
		Debug.WriteLine("Center called");
	}

	public void ShowModal()
	{
		Debug.WriteLine("ShowModal called");
	}

	public uint GetZLevelAttribute()
	{
		Debug.WriteLine("GetZLevelAttribute called");
		return 0u;
	}

	public void SetZLevelAttribute(uint aZLevel)
	{
		Debug.WriteLine("SetZLevelAttribute called");
	}

	public uint GetContextFlagsAttribute()
	{
		Debug.WriteLine("GetContextFlagsAttribute called");
		return 0u;
	}

	public void SetContextFlagsAttribute(uint aContextFlags)
	{
		Debug.WriteLine("SetContextFlagsAttribute called");
	}

	uint nsIXULWindow.GetChromeFlagsAttribute()
	{
		Debug.WriteLine("GetChromeFlagsAttribute called");
		return ChromeFlags;
	}

	void nsIXULWindow.SetChromeFlagsAttribute(uint aChromeFlags)
	{
		Debug.WriteLine("SetChromeFlagsAttribute called");
		ChromeFlags = aChromeFlags;
	}

	public void AssumeChromeFlagsAreFrozen()
	{
		Debug.WriteLine("AssumeChromeFlagsAreFrozen called");
	}

	public nsIXULWindow CreateNewWindow(int aChromeFlags)
	{
		Debug.WriteLine("CreateNewWindow called");
		return null;
	}

	public nsIXULBrowserWindow GetXULBrowserWindowAttribute()
	{
		Debug.WriteLine("GetXULBrowserWindowAttribute called");
		return null;
	}

	public void SetXULBrowserWindowAttribute(nsIXULBrowserWindow aXULBrowserWindow)
	{
		Debug.WriteLine("SetXULBrowserWindowAttribute called");
	}

	public void ApplyChromeFlags()
	{
		Debug.WriteLine("ApplyChromeFlags called");
	}

	protected override void OnHandleCreated(EventArgs e)
	{
		try
		{
			InOnHandleCreate = true;
			if (!((Component)this).DesignMode)
			{
				Xpcom.Initialize();
				WindowCreator.Register();
				BaseNsFactory<LauncherDialogFactory>.Register();
				WebBrowser = Xpcom.CreateInstance<nsIWebBrowser>("@mozilla.org/embedding/browser/nsWebBrowser;1");
				WebBrowserFocus = (nsIWebBrowserFocus)WebBrowser;
				BaseWindow = (nsIBaseWindow)WebBrowser;
				WebNav = (nsIWebNavigation)WebBrowser;
				WebBrowser.SetContainerWindowAttribute(this);
				BaseWindow.InitWindow(((Control)this).get_Handle(), IntPtr.Zero, 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
				BaseWindow.Create();
				nsIDocShell obj = Xpcom.QueryInterface<nsIDocShell>(BaseWindow);
				obj.CreateAboutBlankContentViewer(null);
				Xpcom.FreeComObject(ref obj);
				BaseWindow.SetVisibilityAttribute(aVisibility: true);
				Guid aIID = typeof(nsIWebProgressListener).GUID;
				Guid aIID2 = typeof(nsIWebProgressListener2).GUID;
				WebBrowser.AddWebBrowserListener(GetWeakReference(), ref aIID);
				WebBrowser.AddWebBrowserListener(GetWeakReference(), ref aIID2);
				if (UseHttpActivityObserver)
				{
					ObserverService.AddObserver(this, "http-on-modify-request", ownsWeak: false);
					HttpActivityDistributor.AddObserver(this);
				}
				nsIDOMWindow contentDOMWindowAttribute = WebBrowser.GetContentDOMWindowAttribute();
				EventTarget = ((nsIDOMEventTarget)contentDOMWindowAttribute).AsComPtr();
				using (nsAString type = new nsAString("somedummyevent"))
				{
					EventTarget.Instance.AddEventListener(type, this, useCapture: true, wantsUntrusted: true, 2);
					EventTarget.Instance.RemoveEventListener(type, this, useCapture: true);
				}
				WebNav.GetSessionHistoryAttribute()?.AddSHistoryListener(this);
				WindowMediator.RegisterWindow(this);
			}
			((Control)this).OnHandleCreated(e);
		}
		finally
		{
			InOnHandleCreate = false;
			this.GeckoHandleCreated(this, EventArgs.Empty);
		}
	}

	private void AttachEvents()
	{
		if (_eventsAttached)
		{
			return;
		}
		nsIDOMWindow contentDOMWindowAttribute = WebBrowser.GetContentDOMWindowAttribute();
		EventTarget = ((nsIDOMEventTarget)new Window(contentDOMWindowAttribute, (nsISupports)contentDOMWindowAttribute).PrivateRoot).AsComPtr();
		Marshal.ReleaseComObject(contentDOMWindowAttribute);
		foreach (string defaultEvent in DefaultEvents)
		{
			using nsAString type = new nsAString(defaultEvent);
			EventTarget.Instance.AddEventListener(type, this, useCapture: true, wantsUntrusted: true, 2);
		}
		_eventsAttached = true;
	}

	private void DetachEvents(bool lazy = false)
	{
		if (!_eventsAttached)
		{
			return;
		}
		_eventsAttached = false;
		if (lazy)
		{
			return;
		}
		foreach (string defaultEvent in DefaultEvents)
		{
			using nsAString type = new nsAString(defaultEvent);
			EventTarget.Instance.RemoveEventListener(type, this, useCapture: true);
		}
	}

	private void AttachFrameEvents()
	{
		if (!FrameEventsPropagateToMainWindow)
		{
			return;
		}
		IEnumerable<GeckoWindow> first = from GeckoIFrameElement x in Document.GetElementsByTagName("iframe")
			select x.ContentWindow;
		IEnumerable<GeckoWindow> second = from GeckoFrameElement x in Document.GetElementsByTagName("frame")
			select x.ContentWindow;
		foreach (GeckoWindow item in first.Concat(second))
		{
			nsIDOMEventTarget nsIDOMEventTarget2 = (nsIDOMEventTarget)item.DomWindow;
			foreach (string defaultEvent in DefaultEvents)
			{
				using nsAString type = new nsAString(defaultEvent);
				nsIDOMEventTarget2.AddEventListener(type, this, useCapture: true, wantsUntrusted: true, 2);
			}
		}
	}

	private void RemoveFrameEvents()
	{
		if (!FrameEventsPropagateToMainWindow)
		{
			return;
		}
		foreach (GeckoIFrameElement item in Document.GetElementsByTagName("iframe").Cast<GeckoIFrameElement>())
		{
			GeckoWindow contentWindow = item.ContentWindow;
			nsIDOMEventTarget nsIDOMEventTarget2 = (nsIDOMEventTarget)contentWindow.DomWindow;
			foreach (string defaultEvent in DefaultEvents)
			{
				using nsAString type = new nsAString(defaultEvent);
				nsIDOMEventTarget2.RemoveEventListener(type, this, useCapture: true);
			}
		}
	}

	private void ReattachMessageEventListerns()
	{
		var list = _messageEventListeners.Select((KeyValuePair<string, KeyValuePair<Action<string>, bool>> kvp) => new
		{
			EventName = kvp.Key,
			Action = kvp.Value.Key,
			UseCapture = kvp.Value.Value
		}).ToList();
		foreach (var item in list)
		{
			RemoveMessageEventListener(item.EventName, item.UseCapture);
			AddMessageEventListener(item.EventName, item.Action, item.UseCapture);
		}
	}

	protected override void OnHandleDestroyed(EventArgs e)
	{
		if (BaseWindow != null)
		{
			Stop();
			WindowMediator.UnregisterWindow(this);
			if (_weakRef != null)
			{
				_weakRef.Dispose();
				_weakRef = null;
			}
			nsIDocShell obj = Xpcom.QueryInterface<nsIDocShell>(BaseWindow);
			if (obj != null && !obj.IsBeingDestroyed())
			{
				try
				{
					nsIDOMWindow obj2 = Xpcom.QueryInterface<nsIDOMWindow>(obj);
					if (obj2 != null)
					{
						try
						{
							Window window = new Window(obj2, (nsISupports)obj2);
							if (!window.Closed)
							{
								window.Close();
							}
						}
						finally
						{
							Xpcom.FreeComObject(ref obj2);
						}
					}
				}
				finally
				{
					Xpcom.FreeComObject(ref obj);
				}
			}
			if (EventTarget != null)
			{
				RemoveFrameEvents();
				DetachEvents();
				EventTarget.Dispose();
				EventTarget = null;
			}
			BaseWindow.Destroy();
			Xpcom.FreeComObject(ref CommandParams);
			nsIWebBrowserFocus obj3 = WebBrowserFocus;
			WebBrowserFocus = null;
			Xpcom.FreeComObject(ref obj3);
			Xpcom.FreeComObject(ref WebNav);
			Xpcom.FreeComObject(ref BaseWindow);
			Xpcom.FreeComObject(ref WebBrowser);
			if (menu != null)
			{
				((Menu)menu).get_MenuItems().Clear();
				((Component)(object)menu).Dispose();
				menu = null;
			}
		}
		((Control)this).OnHandleDestroyed(e);
	}

	protected override void OnEnter(EventArgs e)
	{
		if (WebBrowserFocus != null)
		{
			WebBrowserFocus.Activate();
		}
		((Control)this).OnEnter(e);
	}

	protected override void OnLeave(EventArgs e)
	{
		if (WebBrowserFocus != null && !IsBusy)
		{
			WebBrowserFocus.Deactivate();
		}
		((Control)this).OnLeave(e);
	}

	protected override void OnSizeChanged(EventArgs e)
	{
		if (BaseWindow != null)
		{
			try
			{
				BaseWindow.SetPositionAndSize(0, 0, (((Control)this).get_ClientSize().Width == 0) ? 1 : ((Control)this).get_ClientSize().Width, (((Control)this).get_ClientSize().Height == 0) ? 1 : ((Control)this).get_ClientSize().Height, fRepaint: true);
			}
			catch
			{
			}
		}
		((Control)this).OnSizeChanged(e);
	}

	protected override void WndProc(ref Message m)
	{
		if (!((Component)this).DesignMode)
		{
			switch (((Message)(ref m)).get_Msg())
			{
			case 641:
			{
				IntPtr focus = User32.GetFocus();
				if (!User32.IsChild(((Control)this).get_Handle(), focus) && WebBrowserFocus != null)
				{
					long num = ((Message)(ref m)).get_LParam().ToInt64();
					if ((ulong)(num & -2147483648L) <= 0uL)
					{
					}
					if (((Message)(ref m)).get_WParam() == IntPtr.Zero)
					{
						RemoveInputFocus();
						WebBrowserFocus.Deactivate();
					}
					else
					{
						WebBrowserFocus.Activate();
						SetInputFocus();
					}
					return;
				}
				break;
			}
			case 135:
				((Message)(ref m)).set_Result((IntPtr)4);
				return;
			case 33:
			{
				if (!Xpcom.IsWindows)
				{
					return;
				}
				((Message)(ref m)).set_Result((IntPtr)1);
				IntPtr focus = User32.GetFocus();
				if (!IsSubWindow(((Control)this).get_Handle(), focus))
				{
					System.Console.WriteLine("Activating");
					if (WebBrowserFocus != null)
					{
						WebBrowserFocus.Activate();
					}
					if (Window != null)
					{
						WindowWatcher.ActiveWindow = Window;
					}
				}
				if (Window != null && !Window.Equals(WindowWatcher.ActiveWindow))
				{
					if (WebBrowserFocus != null)
					{
						WebBrowserFocus.Activate();
					}
					if (Window != null)
					{
						WindowWatcher.ActiveWindow = Window;
					}
				}
				return;
			}
			}
		}
		if (((Message)(ref m)).get_Msg() != 296)
		{
			((Control)this).WndProc(ref m);
		}
	}

	private bool IsSubWindow(IntPtr window, IntPtr candidate)
	{
		do
		{
			if (candidate != IntPtr.Zero)
			{
				candidate = User32.GetParent(candidate);
				continue;
			}
			return false;
		}
		while (!(window == candidate));
		return true;
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		if (((Component)this).DesignMode)
		{
			string version = ((AssemblyFileVersionAttribute)Attribute.GetCustomAttribute(((object)this).GetType().Assembly, typeof(AssemblyFileVersionAttribute))).Version;
			Brush val = (Brush)new HatchBrush((HatchStyle)52, Color.FromArgb(240, 240, 240), Color.White);
			try
			{
				e.get_Graphics().FillRectangle(val, ((Control)this).get_ClientRectangle());
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
			e.get_Graphics().DrawString($"GeckoFX v{version}\r\nhttp://bitbucket.org/geckofx/", SystemFonts.get_MessageBoxFont(), Brushes.get_Black(), new RectangleF(2f, 2f, ((Control)this).get_Width() - 4, ((Control)this).get_Height() - 4));
			e.get_Graphics().DrawRectangle(SystemPens.get_ControlDark(), 0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
		}
		((Control)this).OnPaint(e);
	}

	protected override void OnPrint(PaintEventArgs e)
	{
		((Control)this).OnPrint(e);
		if (!((Component)this).DesignMode)
		{
			ImageCreator imageCreator = new ImageCreator(this);
			byte[] buffer = imageCreator.CanvasGetPngImage(0u, 0u, (uint)((Control)this).get_Width(), (uint)((Control)this).get_Height());
			Image val = Image.FromStream((Stream)new MemoryStream(buffer));
			try
			{
				e.get_Graphics().DrawImage(val, 0f, 0f);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
	}

	public void EnableDefaultFullscreen()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		Control browserParent = ((Control)this).get_Parent();
		int browserIndex = ((Control)this).get_Parent().get_Controls().IndexOf((Control)(object)this);
		DockStyle browserDock = ((Control)this).get_Dock();
		Form fullscreenWindow = null;
		FormClosingEventHandler val = default(FormClosingEventHandler);
		FullscreenChange += delegate
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected O, but got Unknown
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Expected O, but got Unknown
			//IL_00a3: Expected O, but got Unknown
			if (Document.MozFullScreen && fullscreenWindow == null)
			{
				fullscreenWindow = new Form();
				((Control)this).set_Dock((DockStyle)5);
				((Control)fullscreenWindow).get_Controls().Add((Control)(object)this);
				fullscreenWindow.set_WindowState((FormWindowState)2);
				fullscreenWindow.set_TopMost(true);
				fullscreenWindow.set_FormBorderStyle((FormBorderStyle)0);
				((Control)fullscreenWindow).Show();
				Form obj = fullscreenWindow;
				FormClosingEventHandler obj2 = val;
				if (obj2 == null)
				{
					FormClosingEventHandler val2 = delegate
					{
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						((Control)this).set_Dock(browserDock);
						browserParent.get_Controls().Add((Control)(object)this);
						browserParent.get_Controls().SetChildIndex((Control)(object)this, browserIndex);
					};
					FormClosingEventHandler val3 = val2;
					val = val2;
					obj2 = val3;
				}
				obj.add_FormClosing(obj2);
			}
			else if (!Document.MozFullScreen && fullscreenWindow != null)
			{
				fullscreenWindow.Close();
				fullscreenWindow = null;
			}
		};
	}

	IntPtr nsIEmbeddingSiteWindow.GetSiteWindowAttribute()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		Control temp = ((Control)this).get_Controls().get_Item("TempSubWindow");
		if (temp == null)
		{
			Control val = new Control();
			val.set_Top(-10);
			val.set_Left(-10);
			val.set_Width(1);
			val.set_Height(1);
			val.set_Name("TempSubWindow");
			temp = val;
			temp.add_HandleDestroyed((EventHandler)delegate
			{
				((Control)this).get_Controls().Remove(temp);
			});
			((Control)this).get_Controls().Add(temp);
		}
		return temp.get_Handle();
	}

	public void ForceRedraw()
	{
		BaseWindow.Repaint(force: true);
	}

	public void UserInterfaceThreadInvoke(Action action)
	{
		if (((Control)this).get_InvokeRequired())
		{
			((Control)this).Invoke((Delegate)(Action)delegate
			{
				SafeAction(action);
			});
		}
		else
		{
			SafeAction(action);
		}
	}

	private void SafeAction(Action action)
	{
		try
		{
			action();
		}
		catch (Exception)
		{
			Debug.WriteLine($"Invoking exception");
		}
	}

	public T UserInterfaceThreadInvoke<T>(Func<T> func)
	{
		if (((Control)this).get_InvokeRequired())
		{
			return (T)((Control)this).Invoke((Delegate)(Func<T>)(() => SafeFunc(func)));
		}
		return SafeFunc(func);
	}

	private T SafeFunc<T>(Func<T> func)
	{
		T result = default(T);
		try
		{
			result = func();
			return result;
		}
		catch (Exception)
		{
			Debug.WriteLine($"Invoking exception");
		}
		return result;
	}
}
