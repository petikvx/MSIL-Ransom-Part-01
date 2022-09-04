using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FileiceRansomware;

[ComVisible(true)]
[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
public class eWebbrowser : WebBrowser
{
	public struct OLECMDTEXT
	{
		public uint cmdtextf;

		public uint cwActual;

		public uint cwBuf;

		public char rgwz;
	}

	public struct OLECMD
	{
		public long cmdID;

		public ulong cmdf;
	}

	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("b722bccb-4e68-101b-a2bc-00aa00404770")]
	public interface IOleCommandTarget
	{
		void QueryStatus(ref Guid pguidCmdGroup, uint cCmds, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] OLECMD prgCmds, ref OLECMDTEXT pCmdText);

		void Exec(ref Guid pguidCmdGroup, long nCmdId, long nCmdExecOpt, ref object pvaIn, ref object pvaOut);
	}

	public enum oCommands : long
	{
		Options = 0L,
		Find = 1L,
		ViewSource = 2L,
		ID_FILE_SAVEAS = 32771L,
		ID_FILE_PAGESETUP = 32772L,
		ID_FILE_IMPORTEXPORT = 32774L,
		ID_FILE_PRINTPREVIEW = 32776L,
		ID_FILE_NEWIE = 32779L,
		ID_FILE_NEWMAIL = 32780L,
		PID_FILE_NEWINTERNETCALL = 32781L,
		ID_FILE_ADDTRUST = 32782L,
		ID_FILE_ADDLOCAL = 32783L,
		DLCTL_BGSOUNDS = 64L,
		DLCTL_DLIMAGES = 16L,
		DLCTL_DOWNLOADONLY = 2048L,
		DLCTL_FORCEOFFLINE = 268435456L,
		DLCTL_NO_BEHAVIORS = 2048L,
		DLCTL_NO_CLIENTPULL = 536870912L,
		DLCTL_NO_DLACTIVEXCTLS = 1024L,
		DLCTL_NO_FRAMEDOWNLOAD = 4096L,
		DLCTL_NO_JAVA = 256L,
		DLCTL_NO_METACHARSET = 65536L,
		DLCTL_NO_RUNACTIVEXCTLS = 512L,
		DLCTL_NO_SCRIPTS = 128L,
		DLCTL_OFFLINEIFNOTCONNECTED = -2147483648L,
		DLCTL_PRAGMA_NO_CACHE = 16384L,
		DLCTL_RESYNCHRONIZE = 8192L,
		DLCTL_SILENT = 1073741824L,
		DLCTL_URL_ENCODING_DISABLE_UTF8 = 131072L,
		DLCTL_URL_ENCODING_ENABLE_UTF8 = 262144L,
		DLCTL_VIDEOS = 32L
	}

	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
	[TypeLibType(TypeLibTypeFlags.FHidden)]
	[Guid("34A715A0-6587-11D0-924A-0020AFC7AC4D")]
	public interface DWebBrowserEvents2
	{
		[DispId(250)]
		void BeforeNavigate2([In][MarshalAs(UnmanagedType.IDispatch)] object pDisp, [In][MarshalAs(UnmanagedType.BStr)] ref string URL, [In] ref object flags, [In][MarshalAs(UnmanagedType.BStr)] ref string targetFrameName, [In] ref object postdata, [In][MarshalAs(UnmanagedType.BStr)] ref string headers, [In][Out] ref bool cancel);

		[DispId(273)]
		void NewWindow3([In][MarshalAs(UnmanagedType.IDispatch)] object pDisp, [In][Out] ref bool cancel, [In] ref object Flags, [In][MarshalAs(UnmanagedType.BStr)] ref string UrlContext, [In][MarshalAs(UnmanagedType.BStr)] ref string Url);
	}

	public enum NWMF
	{
		NWMF_UNLOADING = 1,
		NWMF_USERINITED = 2,
		NWMF_FIRST_USERINITED = 4,
		NWMF_OVERRIDEKEY = 8,
		NWMF_SHOWHELP = 0x10,
		NWMF_HTMLDIALOG = 0x20,
		NWMF_FROMPROXY = 0x40
	}

	public delegate void WebBrowserNavigatingExtendedEventHandler(object sender, WebBrowserNavigatingExtendedEventArgs e);

	public delegate void WebBrowserNewWindowExtendedEventHandler(object sender, WebBrowserNewWindowExtendedEventArgs e);

	internal class WebBrowserExtendedEvents : StandardOleMarshalObject, DWebBrowserEvents2
	{
		private eWebbrowser m_Browser;

		public WebBrowserExtendedEvents(eWebbrowser browser)
		{
			m_Browser = browser;
		}

		public void BeforeNavigate2(object pDisp, ref string URL, ref object flags, ref string targetFrameName, ref object postData, ref string headers, ref bool cancel)
		{
			m_Browser.OnNavigatingExtended(URL, targetFrameName, (byte[])postData, headers, ref cancel);
		}

		public void NewWindow3(object pDisp, ref bool Cancel, ref object Flags, ref string UrlContext, ref string Url)
		{
			m_Browser.OnNewWindowExtended(Url, ref Cancel, (NWMF)Conversions.ToInteger(Flags), UrlContext);
		}
	}

	public class WebBrowserNewWindowExtendedEventArgs : CancelEventArgs
	{
		private string m_Url;

		private string m_UrlContext;

		private NWMF m_Flags;

		public string Url => m_Url;

		public string UrlContext => m_UrlContext;

		public NWMF Flags => m_Flags;

		public WebBrowserNewWindowExtendedEventArgs(string url, string urlcontext, NWMF flags)
		{
			m_Url = url;
			m_UrlContext = urlcontext;
			m_Flags = flags;
		}
	}

	public class WebBrowserNavigatingExtendedEventArgs : CancelEventArgs
	{
		private string m_Url;

		private string m_Frame;

		private byte[] m_Postdata;

		private string m_Headers;

		public string Url => m_Url;

		public string Frame => m_Frame;

		public string Headers => m_Headers;

		public string Postdata => PostdataToString(m_Postdata);

		public byte[] PostdataByte => m_Postdata;

		public WebBrowserNavigatingExtendedEventArgs(string url, string frame, byte[] postdata, string headers)
		{
			m_Url = url;
			m_Frame = frame;
			m_Postdata = postdata;
			m_Headers = headers;
		}

		private string PostdataToString(byte[] p)
		{
			string text = "";
			int num = 0;
			if (p != null && p.Length != 0)
			{
				int num2 = checked(p.Length - 1);
				for (num = 0; num <= num2; num = checked(num + 1))
				{
					text += Conversions.ToString(Strings.ChrW((int)p[num]));
				}
				text = Strings.Replace(text, "\r", "", 1, -1, (CompareMethod)0);
				text = Strings.Replace(text, "\n", "", 1, -1, (CompareMethod)0);
				text = Strings.Replace(text, "\0", "", 1, -1, (CompareMethod)0);
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					return "";
				}
				return text;
			}
			return "";
		}
	}

	[ComImport]
	[Guid("64AB4BB7-111E-11D1-8F79-00C04FC2FBE1")]
	public class ShellUIHelper
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern ShellUIHelper();
	}

	private Guid cmdGUID;

	private ConnectionPointCookie cookie;

	private WebBrowserExtendedEvents wevents;

	private WebBrowserNavigatingExtendedEventHandler NavigatingExtendedEvent;

	private WebBrowserNewWindowExtendedEventHandler NewWindowExtendedEvent;

	public string CurrentURL => ((WebBrowser)this).get_Document().get_Url().ToString();

	public event WebBrowserNavigatingExtendedEventHandler NavigatingExtended
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			NavigatingExtendedEvent = (WebBrowserNavigatingExtendedEventHandler)Delegate.Combine(NavigatingExtendedEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			NavigatingExtendedEvent = (WebBrowserNavigatingExtendedEventHandler)Delegate.Remove(NavigatingExtendedEvent, value);
		}
	}

	public event WebBrowserNewWindowExtendedEventHandler NewWindowExtended
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			NewWindowExtendedEvent = (WebBrowserNewWindowExtendedEventHandler)Delegate.Combine(NewWindowExtendedEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			NewWindowExtendedEvent = (WebBrowserNewWindowExtendedEventHandler)Delegate.Remove(NewWindowExtendedEvent, value);
		}
	}

	public eWebbrowser()
	{
		ref Guid reference = ref cmdGUID;
		reference = new Guid(-318674624, -17061, 4559, 186, 78, 0, 192, 79, 215, 8, 22);
	}

	public void ShowOpen()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		OpenFileDialog val = new OpenFileDialog();
		try
		{
			((FileDialog)val).set_Filter("HTML Files (*.htm)|*.htm|HTML Files (*.html)|*.html|TextFiles(*.txt)|*.txt|Gif Files (*.gif)|*.gif|JPEG Files (*.jpg)|*.jpeg|PNG Files (*.png)|*.png|Art Files (*.art)|*.art|AU Fles (*.au)|*.au|AIFF Files (*.aif|*.aiff|XBM Files (*.xbm)|*.xbm|All Files (*.*)|*.*");
			((FileDialog)val).set_Title(" Open File ");
			((CommonDialog)val).ShowDialog();
			if (Operators.CompareString(((FileDialog)val).get_FileName(), (string)null, false) > 0)
			{
				((WebBrowser)this).Navigate(((FileDialog)val).get_FileName());
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			throw new Exception(ex2.Message.ToString());
		}
	}

	public void ShowSource()
	{
		object pvaIn = null;
		try
		{
			IOleCommandTarget oleCommandTarget = (IOleCommandTarget)((WebBrowser)this).get_Document().get_DomDocument();
			oleCommandTarget.Exec(ref cmdGUID, 2L, 1L, ref pvaIn, ref pvaIn);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			throw new Exception(ex2.Message.ToString(), ex2.InnerException);
		}
		finally
		{
			IOleCommandTarget oleCommandTarget = null;
		}
	}

	public void ShowFindDialog()
	{
		object pvaIn = null;
		try
		{
			IOleCommandTarget oleCommandTarget = (IOleCommandTarget)((WebBrowser)this).get_Document().get_DomDocument();
			oleCommandTarget.Exec(ref cmdGUID, 1L, 0L, ref pvaIn, ref pvaIn);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			throw new Exception(ex2.Message.ToString(), ex2.InnerException);
		}
		finally
		{
			IOleCommandTarget oleCommandTarget = null;
		}
	}

	public void AddToFavorites(string strURL = "", string strTitle = "")
	{
		object obj = null;
		try
		{
			obj = new ShellUIHelper();
			NewLateBinding.LateCall(obj, (Type)null, "AddFavorite", new object[2]
			{
				((WebBrowser)this).get_Document().get_Url().ToString(),
				((WebBrowser)this).get_DocumentTitle().ToString()
			}, (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			throw new Exception(ex2.Message.ToString());
		}
		if (obj != null && Marshal.IsComObject(RuntimeHelpers.GetObjectValue(obj)))
		{
			Marshal.ReleaseComObject(RuntimeHelpers.GetObjectValue(obj));
		}
	}

	public void ShowOrganizeFavorites()
	{
		object obj = null;
		try
		{
			obj = new ShellUIHelper();
			NewLateBinding.LateCall(obj, (Type)null, "ShowBrowserUI", new object[2] { "OrganizeFavorites", 0 }, (string[])null, (Type[])null, (bool[])null, true);
		}
		finally
		{
			if (obj != null && Marshal.IsComObject(RuntimeHelpers.GetObjectValue(obj)))
			{
				Marshal.ReleaseComObject(RuntimeHelpers.GetObjectValue(obj));
			}
		}
	}

	public void SendToDesktop()
	{
		object obj = null;
		try
		{
			obj = new ShellUIHelper();
			NewLateBinding.LateCall(obj, (Type)null, "AddDesktopComponent", new object[2]
			{
				((WebBrowser)this).get_Document().get_Url().ToString(),
				"website"
			}, (string[])null, (Type[])null, (bool[])null, true);
		}
		finally
		{
			if (obj != null && Marshal.IsComObject(RuntimeHelpers.GetObjectValue(obj)))
			{
				Marshal.ReleaseComObject(RuntimeHelpers.GetObjectValue(obj));
			}
		}
	}

	public void ShowInternetOptions()
	{
		Interaction.Shell("rundll32.exe shell32.dll,Control_RunDLL inetcpl.cpl,,0", (AppWinStyle)1, false, -1);
	}

	public void ShowPrivacyReport()
	{
		Interaction.Shell("rundll32.exe shell32.dll,Control_RunDLL inetcpl.cpl,,2", (AppWinStyle)1, false, -1);
	}

	protected override void CreateSink()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		((WebBrowser)this).CreateSink();
		wevents = new WebBrowserExtendedEvents(this);
		cookie = new ConnectionPointCookie(RuntimeHelpers.GetObjectValue(((WebBrowserBase)this).get_ActiveXInstance()), (object)wevents, typeof(DWebBrowserEvents2));
	}

	protected override void DetachSink()
	{
		if (cookie != null)
		{
			cookie.Disconnect();
			cookie = null;
		}
		((WebBrowser)this).DetachSink();
	}

	protected internal void OnNavigatingExtended(string Url, string Frame, byte[] Postdata, string Headers, ref bool Cancel)
	{
		WebBrowserNavigatingExtendedEventArgs webBrowserNavigatingExtendedEventArgs = new WebBrowserNavigatingExtendedEventArgs(Url, Frame, Postdata, Headers);
		NavigatingExtendedEvent?.Invoke(this, webBrowserNavigatingExtendedEventArgs);
		Cancel = webBrowserNavigatingExtendedEventArgs.Cancel;
	}

	protected internal void OnNewWindowExtended(string Url, ref bool Cancel, NWMF Flags, string UrlContext)
	{
		WebBrowserNewWindowExtendedEventArgs webBrowserNewWindowExtendedEventArgs = new WebBrowserNewWindowExtendedEventArgs(Url, UrlContext, Flags);
		NewWindowExtendedEvent?.Invoke(this, webBrowserNewWindowExtendedEventArgs);
		Cancel = webBrowserNewWindowExtendedEventArgs.Cancel;
	}

	public void Navigate2(string URL)
	{
		((WebBrowser)this).Navigate(URL);
	}
}
