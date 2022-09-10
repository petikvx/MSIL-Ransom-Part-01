using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Resources;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using Microsoft.Win32;

namespace Sony.Vegas.NetRender;

public class VegSrv : Form
{
	private class BooleanOption
	{
		private bool myDefaultValue = false;

		private bool myValue = false;

		public string Text = null;

		public int ListBoxIndex = -1;

		public bool Value
		{
			get
			{
				return myValue;
			}
			set
			{
				if (myValue != value)
				{
					myValue = value;
					OnValueChanged(EventArgs.Empty);
				}
			}
		}

		public event EventHandler ValueChanged;

		public BooleanOption(bool defaultValue)
		{
			myDefaultValue = defaultValue;
			myValue = defaultValue;
		}

		public void RestoreDefaultValue()
		{
			Value = myDefaultValue;
		}

		protected void OnValueChanged(EventArgs args)
		{
			if (null != this.ValueChanged)
			{
				this.ValueChanged(this, args);
			}
		}

		public override string ToString()
		{
			return Text;
		}

		public void AddToListBox(CheckedListBox listBox)
		{
			ListBoxIndex = listBox.get_Items().Add((object)this, myValue);
		}
	}

	private class AgeToken
	{
		public string Display = null;

		public TimeSpan Span = TimeSpan.Zero;

		public AgeToken(string display, long ticks)
		{
			Display = display;
			Span = new TimeSpan(ticks);
		}

		public override string ToString()
		{
			return Display;
		}
	}

	private delegate NetRenderServiceState AsyncUpdatePeerStatus(NetRenderServiceURL url);

	private class PeerStatusAsyncState
	{
		public DataRow Row;

		public int Cookie;

		public PeerStatusAsyncState(DataRow row, int cookie)
		{
			Row = row;
			Cookie = cookie;
		}
	}

	private delegate void PeerStatusUpdateHandler(PeerStatusAsyncState asyncState, NetRenderServiceState status);

	private const decimal theMinDefaultFramesPerSegment = 5m;

	private const decimal theMaxDefaultFramesPerSegment = 1800m;

	private NetRenderSettings mySettings = null;

	private NetRenderServiceURL myURL = null;

	private NetRenderService myService = null;

	private static int theMaxLogMsgCount = 400;

	private static int thePruneLogMsgCount = 100;

	private int myNextLogMsgIndex = 0;

	private string[] myLogMsgs = new string[theMaxLogMsgCount];

	private DataSet myDataSet = null;

	private DataTable myPeerData = null;

	private DataTable myFileMappings = null;

	private bool myVerboseLogging = false;

	protected bool EnforceConstraintsOnJobDataRelations = true;

	protected DataRelation myJobStatsRelation = null;

	protected DataRelation myJobSegmentsRelation = null;

	protected DataRelation myJobSummaryRelation = null;

	protected DataRelation myJobErrorsRelation = null;

	private long myLastJournalMsgID = -1L;

	private bool myFinishedLoading = false;

	private bool WasCloseButtonClicked = false;

	private string myAppPath = null;

	private string ConfigFile = null;

	private string SettingsFile = null;

	private bool SaveSettingsSwitch = true;

	private ResourceManager myDefaultResourceManager = null;

	private ResourceManager myStringResourceManager = null;

	private string myWindowTitleString = null;

	private Icon myWindowIcon = null;

	private Icon myTrayIcon = null;

	private static Size minSize = new Size(440, 240);

	private Rectangle mySavedBounds;

	private BooleanOption AutoRun = new BooleanOption(defaultValue: false);

	private BooleanOption HideWhenMinimized = new BooleanOption(defaultValue: false);

	private BooleanOption ExitOnClose = new BooleanOption(defaultValue: true);

	private BooleanOption ExitVegasOnIdle = new BooleanOption(defaultValue: true);

	private BooleanOption RenderingEnabled = new BooleanOption(defaultValue: true);

	private decimal DefaultFramesPerSegment = 150m;

	private int SelectedTabPageIndex = 0;

	private Timer myRefreshTimer = new Timer();

	private ContextMenu myTrayMenu = null;

	private MenuItem myShowWindowTrayMenuItem = null;

	private MenuItem myRenderingEnabledTrayMenuItem = null;

	private MenuItem myExitServiceTrayMenuItem = null;

	private bool UseFlatStyle = false;

	private TabControl myTabControl = null;

	private TabPage myPeersPage = null;

	private Label myPeerDataChooserLabel = null;

	private ComboBox myPeerDataChooser = null;

	private DataGrid myPeerDataGrid = null;

	private TabPage myProgressPage = null;

	private Label myJobDataChooserLabel = null;

	private ComboBox myJobDataChooser = null;

	private DataGrid myJobDataGrid = null;

	private MainMenu myMainMenu = null;

	private MenuItem myActionMenu = null;

	private MenuItem myHelpMenu = null;

	private MenuItem myRenderingEnabledMainMenuItem = null;

	private MenuItem myCancelJobMainMenuItem = null;

	private MenuItem myAutoFillFileMappings = null;

	private ContextMenu myMainContextMenu = null;

	private ContextMenu myPeerDataContextMenu = null;

	private ContextMenu myJobDataContextMenu = null;

	private MenuItem myJobDataContextCancelJobMenuItem = null;

	private ContextMenu myFileMappingsContextMenu = null;

	private MenuItem myFileMappingsContextAutoFillMappingsMenuItem = null;

	private MenuItem myFileMappingsContextDeleteMappingMenuItem = null;

	private MenuItem myFileMappingsContextDeleteAllMappingsMenuItem = null;

	private Label myProgressLabel = null;

	private Label myLocalServiceHostNameLabel = null;

	private Label myLocalServicePortLabel = null;

	private Label myLocalServiceStateLabel = null;

	private TabPage myFileMappingsPage = null;

	private DataGrid myFileMappingsDataGrid = null;

	private TabPage myOptionsPage = null;

	private CheckedListBox myBooleanOptionListBox = null;

	private Label myAgeOfStaleJobsLabel = null;

	private DomainUpDown myAgeOfStaleJobsControl = null;

	private Label myDefaultFramesPerSegmentLabel = null;

	private NumericUpDown myDefaultFramesPerSegmentControl = null;

	private TabPage myLogPage = null;

	private TextBox myLogTextBox = null;

	private string LogFileDirectory = null;

	private Container ComponentContainer = null;

	private NotifyIcon NotifyIcon = null;

	private bool IsTrayIconCreated = false;

	private int myProgressLabelDecay = 0;

	private int NumberOfRefreshesBeforeClearingProgressLabel = 5;

	private TimeSpan AgeOfStaleJobs = new TimeSpan(36000000000L);

	private FormWindowState myWindowStateBeforeMinimize = (FormWindowState)0;

	private bool IsHandlingPeerDataChange = false;

	private Form myAboutBox = null;

	private string myHelpFile = null;

	private Process myHelpProcess = null;

	private string myUserSpecifiedSerialCode = null;

	private TextBox mySerialTextBox = null;

	private Form mySerialNumberEntryForm = null;

	private string AppPath
	{
		get
		{
			if (null == myAppPath)
			{
				myAppPath = Assembly.GetExecutingAssembly().Location;
			}
			return myAppPath;
		}
	}

	private string AppName => Path.GetFileName(AppPath);

	private string AppShortName => Path.GetFileNameWithoutExtension(AppPath);

	private string AppDir => Path.GetDirectoryName(AppPath);

	private DataTable JobData => myDataSet.Tables["Jobs"];

	private DataTable StatData => myDataSet.Tables["Stats"];

	private DataTable SegmentData => myDataSet.Tables["Segments"];

	private DataTable SummaryData => myDataSet.Tables["Summary"];

	private DataTable ErrorData => myDataSet.Tables["Errors"];

	private string HelpFile
	{
		get
		{
			if (null == myHelpFile)
			{
				RegistryKey localMachine = Registry.LocalMachine;
				RegistryKey registryKey = localMachine.OpenSubKey("SOFTWARE\\Sony Media Software\\Shared Information");
				if (null == registryKey)
				{
					throw new ApplicationException(LRZ("OpenRegKeyError"));
				}
				string text = registryKey.GetValue("HelpFolder") as string;
				string threeLetterWindowsLanguageName = RC.theCultureInfo.ThreeLetterWindowsLanguageName;
				threeLetterWindowsLanguageName = ((!("ENU" == threeLetterWindowsLanguageName)) ? ("_" + threeLetterWindowsLanguageName) : "");
				if (null != text)
				{
					myHelpFile = Path.Combine(text, AppShortName + threeLetterWindowsLanguageName + ".chm");
				}
				else
				{
					myHelpFile = Path.Combine(AppDir, AppShortName + threeLetterWindowsLanguageName + ".chm");
				}
			}
			return myHelpFile;
		}
	}

	[STAThread]
	public static void Main(string[] args)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		VegSrv vegSrv = null;
		try
		{
			Application.EnableVisualStyles();
			vegSrv = new VegSrv(args);
			Application.Run((Form)(object)vegSrv);
		}
		catch (Exception ex)
		{
			string text = $"An error has occured:\n\n{ex.Message}\n\nThe application must quit.";
			string text2 = "Critical Error";
			MessageBox.Show((IWin32Window)null, text, text2, (MessageBoxButtons)0, (MessageBoxIcon)16, (MessageBoxDefaultButton)0);
		}
	}

	public VegSrv(string[] args)
	{
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected O, but got Unknown
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		LoadResources();
		LoadSettings();
		Log((LogWhat)1042, Environment.OSVersion.ToString());
		Log((LogWhat)1042, Environment.CommandLine);
		if (0 < args.Length)
		{
			HandleArgs(args);
		}
		((Form)this).set_FormBorderStyle((FormBorderStyle)4);
		((Form)this).set_SizeGripStyle((SizeGripStyle)0);
		((Control)this).set_Text(myWindowTitleString);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && IsTrayIconCreated)
		{
			ComponentContainer.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	protected override void OnLoad(EventArgs e)
	{
		((Form)this).OnLoad(e);
		ShowTrayIcon();
		InitDataModel();
		StartRemoting();
		InitBounds();
		InitControls();
		InitRefreshTimer();
		myFinishedLoading = true;
	}

	protected override void OnClosing(CancelEventArgs args)
	{
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Invalid comparison between I4 and Unknown
		if (WasCloseButtonClicked)
		{
			WasCloseButtonClicked = false;
			if (!ExitOnClose.Value)
			{
				args.Cancel = true;
				((Control)this).set_Visible(false);
				return;
			}
		}
		if (null != myService)
		{
			bool flag = false;
			try
			{
				flag = myService.HasActiveJobs();
			}
			catch
			{
			}
			if (flag)
			{
				string text = LRZ("PendingOperations");
				string text2 = myWindowTitleString;
				if (7 == (int)MessageBox.Show((IWin32Window)(object)this, text, text2, (MessageBoxButtons)4, (MessageBoxIcon)48, (MessageBoxDefaultButton)256))
				{
					args.Cancel = true;
				}
			}
			if (!args.Cancel)
			{
				((Control)this).set_Cursor(Cursors.get_WaitCursor());
				SaveSettings();
				StopRemoting();
			}
		}
		((Form)this).OnClosing(args);
	}

	protected override void OnClosed(EventArgs e)
	{
		((Form)this).OnClosed(e);
	}

	protected override void WndProc(ref Message msg)
	{
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		switch (((Message)(ref msg)).get_Msg())
		{
		default:
			((Form)this).WndProc(ref msg);
			break;
		case 274:
			if (61472 == (int)((Message)(ref msg)).get_WParam())
			{
				if (HideWhenMinimized.Value)
				{
					((Control)this).set_Visible(false);
					break;
				}
				myWindowStateBeforeMinimize = ((Form)this).get_WindowState();
			}
			else if (61536 == (int)((Message)(ref msg)).get_WParam())
			{
				WasCloseButtonClicked = true;
			}
			((Form)this).WndProc(ref msg);
			break;
		case 74:
			HandleCopyData(ref msg);
			break;
		}
	}

	private void HandleArgs(string[] args)
	{
		if (null == args)
		{
			return;
		}
		IEnumerator enumerator = args.GetEnumerator();
		while (enumerator.MoveNext())
		{
			string text = ((string)enumerator.Current).ToLower();
			switch (text)
			{
			case "-nosave":
				SaveSettingsSwitch = false;
				break;
			case "-settings":
				if (enumerator.MoveNext())
				{
					SettingsFile = StripQuotes((string)enumerator.Current);
					if (!File.Exists(SettingsFile))
					{
						throw new ApplicationException("Settings file does not exist: " + SettingsFile);
					}
					break;
				}
				throw new ApplicationException("Settings file not specified");
			case "-config":
				if (enumerator.MoveNext())
				{
					ConfigFile = StripQuotes((string)enumerator.Current);
					if (!File.Exists(ConfigFile))
					{
						throw new ApplicationException("Configuration file does not exist: " + ConfigFile);
					}
					break;
				}
				throw new ApplicationException("Settings file not specified");
			case "-autorun":
				break;
			default:
			{
				string message = string.Format(LRZ("BadCommandLine"), text, AppName);
				throw new ApplicationException(message);
			}
			}
		}
	}

	private string StripQuotes(string s)
	{
		if (s.StartsWith("\"") && s.EndsWith("\""))
		{
			char[] trimChars = new char[1] { '"' };
			return s.TrimStart(trimChars).TrimEnd(trimChars);
		}
		return s;
	}

	private void LoadSettings()
	{
		if (null == SettingsFile)
		{
			mySettings = new NetRenderSettings();
		}
		else
		{
			mySettings = new NetRenderSettings(SettingsFile);
		}
		Log((LogWhat)1038, string.Format(LRZ("LogSettingsFileLoaded"), mySettings.FilePath));
		InitAutoRun();
		InitHideWhenMinimized();
		InitExitOnClose();
		InitExitVegasOnIdle();
		InitAgeOfStaleJobs();
		InitRenderingEnabled();
		InitDefaultFramesPerSegment();
		InitSelectedTabPageIndex();
		InitUserSpecifiedSerialCode();
	}

	private void SaveSettings()
	{
		if (myFinishedLoading && SaveSettingsSwitch)
		{
			SaveRoster();
			SaveFileMappings();
			SaveRecentTempFileDirectories();
			SaveBounds();
			SaveAutoRun();
			SaveHideWhenMinimized();
			SaveExitOnClose();
			SaveExitVegasOnIdle();
			SaveAgeOfStaleJobs();
			SaveRenderingEnabled();
			SaveDefaultFramesPerSegment();
			SaveSelectedTabPageIndex();
			SaveUserSpecifiedSerialCode();
			mySettings.Save();
		}
	}

	private string GetSetting(string settingName)
	{
		XmlElement elt = mySettings.GetElt("/settings/" + settingName);
		if (null == elt)
		{
			return null;
		}
		return elt.InnerText;
	}

	private void SaveSetting(string settingName, string value)
	{
		XmlElement xmlElement = mySettings.GetElt("/settings/" + settingName);
		if (null == xmlElement)
		{
			xmlElement = mySettings.Doc.CreateElement(settingName);
			mySettings.Root.AppendChild(xmlElement);
		}
		xmlElement.InnerText = value;
	}

	private void CreateResourceManagers()
	{
		if (null == myDefaultResourceManager)
		{
			Log((LogWhat)1042, "Culture: " + Thread.CurrentThread.CurrentUICulture);
			myDefaultResourceManager = new ResourceManager("VegSrv", Assembly.GetExecutingAssembly());
			myStringResourceManager = new ResourceManager("VegSrvStrings", Assembly.GetExecutingAssembly());
		}
	}

	private object LoadRez(string rezName)
	{
		object @object = myDefaultResourceManager.GetObject(rezName, Thread.CurrentThread.CurrentCulture);
		if (null == @object)
		{
			string message = $"Failed to find resource: '{rezName}'";
			throw new ApplicationException(message);
		}
		return @object;
	}

	private string LRZ(string rezName)
	{
		string text = myStringResourceManager.GetString(rezName, Thread.CurrentThread.CurrentCulture);
		if (null == text)
		{
			text = $"Resource string not found: '{rezName}'";
		}
		return text;
	}

	private void LoadResources()
	{
		CreateResourceManagers();
		myWindowTitleString = LRZ("WindowTitleString");
		ref Icon reference = ref myWindowIcon;
		object obj = LoadRez("TrayIconDefault");
		reference = (Icon)((obj is Icon) ? obj : null);
		if (null != myWindowIcon)
		{
			((Form)this).set_Icon(myWindowIcon);
		}
		myTrayIcon = myWindowIcon;
	}

	private void InitBounds()
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).set_MinimumSize(minSize);
		try
		{
			XmlElement elt = mySettings.GetElt("/settings/Bounds");
			int num = int.Parse(elt.GetAttribute("Left"));
			int num2 = int.Parse(elt.GetAttribute("Top"));
			int num3 = int.Parse(elt.GetAttribute("Width"));
			int num4 = int.Parse(elt.GetAttribute("Height"));
			if (num3 < minSize.Width)
			{
				num3 = minSize.Width;
			}
			if (num4 < minSize.Height)
			{
				num4 = minSize.Height;
			}
			bool flag = false;
			IEnumerator enumerator = Screen.get_AllScreens().GetEnumerator();
			while (enumerator.MoveNext())
			{
				Rectangle workingArea = ((Screen)enumerator.Current).get_WorkingArea();
				if (workingArea.Contains(num, num2) || workingArea.Contains(num + num3, num2))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				((Form)this).set_StartPosition((FormStartPosition)2);
				num = 0;
				num2 = 0;
			}
			else
			{
				((Form)this).set_StartPosition((FormStartPosition)0);
			}
			((Form)this).SetDesktopBounds(num, num2, num3, num4);
		}
		catch
		{
			((Form)this).set_StartPosition((FormStartPosition)2);
			((Form)this).SetDesktopBounds(0, 0, minSize.Width, minSize.Height);
		}
		mySavedBounds = ((Form)this).get_DesktopBounds();
		((Control)this).add_LocationChanged((EventHandler)HandleBoundsChanged);
		((Control)this).add_SizeChanged((EventHandler)HandleBoundsChanged);
	}

	private void SaveBounds()
	{
		XmlElement xmlElement = mySettings.GetElt("/settings/Bounds");
		if (null == xmlElement)
		{
			xmlElement = mySettings.Doc.CreateElement("Bounds");
			mySettings.Root.AppendChild(xmlElement);
		}
		Rectangle rectangle = mySavedBounds;
		xmlElement.SetAttribute("Left", rectangle.Left.ToString());
		xmlElement.SetAttribute("Top", rectangle.Top.ToString());
		xmlElement.SetAttribute("Width", rectangle.Width.ToString());
		xmlElement.SetAttribute("Height", rectangle.Height.ToString());
	}

	private void HandleBoundsChanged(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		if ((int)((Form)this).get_WindowState() == 0)
		{
			mySavedBounds = ((Form)this).get_DesktopBounds();
		}
	}

	private void InitAutoRun()
	{
		AutoRun.Text = LRZ("AutoRunCheckBox");
		AutoRun.ValueChanged += HandleAutoRunChanged;
		try
		{
			AutoRun.Value = bool.Parse(GetSetting("AutoRun"));
		}
		catch
		{
		}
	}

	private void SaveAutoRun()
	{
		SaveSetting("AutoRun", AutoRun.Value.ToString());
	}

	public void HandleAutoRunChanged(object sender, EventArgs e)
	{
		RegistryKey currentUser = Registry.CurrentUser;
		RegistryKey registryKey = null;
		try
		{
			registryKey = currentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
			if (null == registryKey)
			{
				throw new ApplicationException(LRZ("OpenRegKeyError"));
			}
			string appName = AppName;
			if (AutoRun.Value)
			{
				string text = $"\"{AppPath}\" -AutoRun";
				string[] valueNames = registryKey.GetValueNames();
				bool flag = false;
				string[] array = valueNames;
				foreach (string text2 in array)
				{
					if (text2 == appName)
					{
						string text3 = registryKey.GetValue(appName) as string;
						if (text3 == text)
						{
							flag = true;
						}
						break;
					}
				}
				if (!flag)
				{
					registryKey.SetValue(appName, text);
				}
			}
			else
			{
				registryKey.DeleteValue(appName, throwOnMissingValue: false);
			}
		}
		finally
		{
			if (null != registryKey)
			{
				registryKey.Close();
			}
		}
	}

	private void InitHideWhenMinimized()
	{
		HideWhenMinimized.Text = LRZ("HideWhenMinimizedCheckBox");
		HideWhenMinimized.ValueChanged += HandleHideWhenMinimizedChanged;
		try
		{
			HideWhenMinimized.Value = bool.Parse(GetSetting("HideWhenMinimized"));
		}
		catch
		{
		}
	}

	private void SaveHideWhenMinimized()
	{
		SaveSetting("HideWhenMinimized", HideWhenMinimized.Value.ToString());
	}

	public void HandleHideWhenMinimizedChanged(object sender, EventArgs e)
	{
	}

	private void InitExitOnClose()
	{
		ExitOnClose.Text = LRZ("ExitOnCloseCheckBox");
		ExitOnClose.ValueChanged += HandleExitOnCloseChanged;
		try
		{
			ExitOnClose.Value = bool.Parse(GetSetting("ExitOnClose"));
		}
		catch
		{
		}
	}

	private void SaveExitOnClose()
	{
		SaveSetting("ExitOnClose", ExitOnClose.Value.ToString());
	}

	public void HandleExitOnCloseChanged(object sender, EventArgs e)
	{
	}

	private void InitExitVegasOnIdle()
	{
		ExitVegasOnIdle.Text = LRZ("ExitVegasOnIdleCheckBox");
		ExitVegasOnIdle.ValueChanged += HandleExitVegasOnIdleChanged;
		try
		{
			ExitVegasOnIdle.Value = bool.Parse(GetSetting("ExitVegasOnIdle"));
		}
		catch
		{
		}
	}

	private void SaveExitVegasOnIdle()
	{
		SaveSetting("ExitVegasOnIdle", ExitVegasOnIdle.Value.ToString());
	}

	public void HandleExitVegasOnIdleChanged(object sender, EventArgs e)
	{
		if (null != myService)
		{
			myService.set_ExitVegasOnIdle(ExitVegasOnIdle.Value);
		}
	}

	private void InitRenderingEnabled()
	{
		RenderingEnabled.Text = LRZ("RenderingEnabledCheckBox");
		RenderingEnabled.ValueChanged += HandleRenderingEnabledChanged;
		try
		{
			RenderingEnabled.Value = bool.Parse(GetSetting("RenderingEnabled"));
		}
		catch
		{
		}
	}

	private void SaveRenderingEnabled()
	{
		SaveSetting("RenderingEnabled", RenderingEnabled.Value.ToString());
	}

	public void HandleRenderingEnabledChanged(object sender, EventArgs e)
	{
		if (null != myService)
		{
			myService.set_RenderingEnabled(RenderingEnabled.Value);
		}
		if (myBooleanOptionListBox != null && 0 <= RenderingEnabled.ListBoxIndex)
		{
			myBooleanOptionListBox.SetItemChecked(RenderingEnabled.ListBoxIndex, RenderingEnabled.Value);
		}
	}

	public void ToggleRenderingEnabled(object sender, EventArgs e)
	{
		RenderingEnabled.Value = !RenderingEnabled.Value;
	}

	private void ResetRenderingEnabledMenuItem(MenuItem item)
	{
		item.set_Checked(RenderingEnabled.Value);
	}

	private void InitDefaultFramesPerSegment()
	{
		try
		{
			DefaultFramesPerSegment = decimal.Parse(GetSetting("DefaultFramesPerSegment"));
			if (5m > DefaultFramesPerSegment)
			{
				DefaultFramesPerSegment = 5m;
			}
			if (1800m < DefaultFramesPerSegment)
			{
				DefaultFramesPerSegment = 1800m;
			}
		}
		catch
		{
		}
	}

	private void SaveDefaultFramesPerSegment()
	{
		SaveSetting("DefaultFramesPerSegment", DefaultFramesPerSegment.ToString());
	}

	private bool SetDefaultFramesPerSegment(decimal value)
	{
		if (5m > value)
		{
			value = 5m;
		}
		else if (1800m < value)
		{
			value = 1800m;
		}
		if (DefaultFramesPerSegment != value)
		{
			myService.set_DefaultFramesPerSegment((long)value);
			DefaultFramesPerSegment = value;
			myDefaultFramesPerSegmentControl.set_Value(value);
			return true;
		}
		return false;
	}

	private void HandleDefaultFramesPerSegmentChanged(object sender, EventArgs e)
	{
		if (SetDefaultFramesPerSegment(myDefaultFramesPerSegmentControl.get_Value()))
		{
			((UpDownBase)myDefaultFramesPerSegmentControl).Select(0, ((Control)myDefaultFramesPerSegmentControl).get_Text().Length);
		}
	}

	private void HandleDefaultFramesPerSegmentLeave(object sender, EventArgs e)
	{
		SetDefaultFramesPerSegment(myDefaultFramesPerSegmentControl.get_Value());
	}

	private void InitSelectedTabPageIndex()
	{
		try
		{
			SelectedTabPageIndex = int.Parse(GetSetting("SelectedTabPageIndex"));
		}
		catch
		{
		}
	}

	private void SaveSelectedTabPageIndex()
	{
		SaveSetting("SelectedTabPageIndex", SelectedTabPageIndex.ToString());
	}

	private void HandleSelectedTabIndexChanged(object sender, EventArgs e)
	{
		SelectedTabPageIndex = myTabControl.get_SelectedIndex();
	}

	private void InitRefreshTimer()
	{
		TimeToRefresh(null, null);
		myRefreshTimer.add_Tick((EventHandler)TimeToRefresh);
		myRefreshTimer.set_Interval(2000);
		myRefreshTimer.Start();
	}

	private void InitDataModel()
	{
		Type typeFromHandle = typeof(int);
		Type typeFromHandle2 = typeof(string);
		_ = typeof(bool);
		myPeerData = new DataTable("NetRender Peers");
		myPeerData.Columns.Add("Host", typeFromHandle2);
		myPeerData.Columns.Add("URL", typeFromHandle2);
		myPeerData.Columns.Add("ServiceState", typeFromHandle2);
		myPeerData.Columns.Add("URLObj", typeof(NetRenderServiceURL));
		myPeerData.Columns.Add("Cookie", typeFromHandle);
		myFileMappings = new DataTable("NetRender Peers");
		myFileMappings.Columns.Add("Local", typeFromHandle2);
		myFileMappings.Columns.Add("Universal", typeFromHandle2);
		myFileMappings.RowChanging += HandleFileMappingRowChanging;
		myFileMappings.RowChanged += HandleFileMappingRowChanged;
		myFileMappings.RowDeleted += HandleFileMappingRowDeleted;
		myDataSet = new DataSet("Render Jobs");
		DataTable dataTable = myDataSet.Tables.Add("Jobs");
		DataColumn dataColumn = dataTable.Columns.Add("Owner", typeFromHandle2);
		DataColumn dataColumn2 = dataTable.Columns.Add("Port", typeFromHandle);
		DataColumn dataColumn3 = dataTable.Columns.Add("JobID", typeFromHandle);
		dataTable.Columns.Add("Project", typeFromHandle2);
		dataTable.Columns.Add("OutputFile", typeFromHandle2);
		dataTable.PrimaryKey = new DataColumn[3] { dataColumn, dataColumn2, dataColumn3 };
		DataTable dataTable2 = myDataSet.Tables.Add("Stats");
		dataColumn = dataTable2.Columns.Add("Owner", typeFromHandle2);
		dataColumn2 = dataTable2.Columns.Add("Port", typeFromHandle);
		dataColumn3 = dataTable2.Columns.Add("JobID", typeFromHandle);
		dataTable2.Columns.Add("RenderStatus", typeof(RenderStatus));
		dataTable2.Columns.Add("RenderStartTime", typeFromHandle2);
		dataTable2.Columns.Add("RenderDuration", typeFromHandle2);
		dataTable2.Columns.Add("RenderEndTime", typeof(DateTime));
		dataTable2.Columns.Add("Completed", typeFromHandle2);
		dataTable2.PrimaryKey = new DataColumn[3] { dataColumn, dataColumn2, dataColumn3 };
		myJobStatsRelation = myDataSet.Relations.Add("JobStats", dataTable.PrimaryKey, dataTable2.PrimaryKey, EnforceConstraintsOnJobDataRelations);
		DataTable dataTable3 = myDataSet.Tables.Add("Segments");
		dataColumn = dataTable3.Columns.Add("Owner", typeFromHandle2);
		dataColumn2 = dataTable3.Columns.Add("Port", typeFromHandle);
		dataColumn3 = dataTable3.Columns.Add("JobID", typeFromHandle);
		DataColumn dataColumn4 = dataTable3.Columns.Add("SegID", typeFromHandle);
		dataTable3.Columns.Add("Segment", typeFromHandle2);
		dataTable3.Columns.Add("Worker", typeFromHandle2);
		dataTable3.Columns.Add("RenderStatus", typeof(RenderStatus));
		dataTable3.PrimaryKey = new DataColumn[4] { dataColumn, dataColumn2, dataColumn3, dataColumn4 };
		myJobSegmentsRelation = myDataSet.Relations.Add("JobSegments", dataTable.PrimaryKey, new DataColumn[3] { dataColumn, dataColumn2, dataColumn3 }, EnforceConstraintsOnJobDataRelations);
		DataTable dataTable4 = myDataSet.Tables.Add("Summary");
		dataColumn = dataTable4.Columns.Add("Owner", typeFromHandle2);
		dataColumn2 = dataTable4.Columns.Add("Port", typeFromHandle);
		dataColumn3 = dataTable4.Columns.Add("JobID", typeFromHandle);
		dataTable4.Columns.Add("Output", typeFromHandle2);
		dataTable4.Columns.Add("Project", typeFromHandle2);
		dataTable4.Columns.Add("RenderStatus", typeof(RenderStatus));
		dataTable4.Columns.Add("Completed", typeFromHandle2);
		dataTable4.Columns.Add("RenderDuration", typeFromHandle2);
		dataTable4.PrimaryKey = new DataColumn[3] { dataColumn, dataColumn2, dataColumn3 };
		myJobSummaryRelation = myDataSet.Relations.Add("JobSummary", dataTable.PrimaryKey, dataTable4.PrimaryKey, EnforceConstraintsOnJobDataRelations);
		DataTable dataTable5 = myDataSet.Tables.Add("Errors");
		dataColumn = dataTable5.Columns.Add("Owner", typeFromHandle2);
		dataColumn2 = dataTable5.Columns.Add("Port", typeFromHandle);
		dataColumn3 = dataTable5.Columns.Add("JobID", typeFromHandle);
		DataColumn dataColumn5 = dataTable5.Columns.Add("ErrorID", typeFromHandle);
		dataTable5.Columns.Add("Source", typeFromHandle2);
		dataTable5.Columns.Add("Error", typeFromHandle2);
		dataTable5.PrimaryKey = new DataColumn[4] { dataColumn, dataColumn2, dataColumn3, dataColumn5 };
		myJobErrorsRelation = myDataSet.Relations.Add("JobErrors", dataTable.PrimaryKey, new DataColumn[3] { dataColumn, dataColumn2, dataColumn3 }, EnforceConstraintsOnJobDataRelations);
	}

	private void InitTrayMenu()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		myTrayMenu = new ContextMenu();
		myShowWindowTrayMenuItem = new MenuItem();
		myShowWindowTrayMenuItem.set_Text(LRZ("ShowWindowTrayMenuItem"));
		myShowWindowTrayMenuItem.add_Click((EventHandler)HandleShowWindow);
		myShowWindowTrayMenuItem.set_DefaultItem(true);
		((Menu)myTrayMenu).get_MenuItems().Add(myShowWindowTrayMenuItem);
		((Menu)myTrayMenu).get_MenuItems().Add(new MenuItem("-"));
		myRenderingEnabledTrayMenuItem = new MenuItem();
		myRenderingEnabledTrayMenuItem.set_Text(LRZ("RenderingEnabledMenuItem"));
		ResetRenderingEnabledMenuItem(myRenderingEnabledTrayMenuItem);
		myRenderingEnabledTrayMenuItem.add_Click((EventHandler)ToggleRenderingEnabled);
		((Menu)myTrayMenu).get_MenuItems().Add(myRenderingEnabledTrayMenuItem);
		((Menu)myTrayMenu).get_MenuItems().Add(new MenuItem("-"));
		myExitServiceTrayMenuItem = new MenuItem();
		myExitServiceTrayMenuItem.set_Text(LRZ("ExitServiceMenuItem"));
		myExitServiceTrayMenuItem.add_Click((EventHandler)HandleExitApp);
		((Menu)myTrayMenu).get_MenuItems().Add(myExitServiceTrayMenuItem);
		myTrayMenu.add_Popup((EventHandler)HandleTrayMenuPopup);
	}

	private void HandleTrayMenuPopup(object sender, EventArgs e)
	{
		ResetRenderingEnabledMenuItem(myRenderingEnabledTrayMenuItem);
	}

	private void InitControls()
	{
		Graphics val = ((Control)this).CreateGraphics();
		((Control)this).SuspendLayout();
		try
		{
			InitControlsInternal(val);
		}
		finally
		{
			((Control)this).ResumeLayout();
			val.Dispose();
		}
	}

	private void InitControlsInternal(Graphics graphics)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		InitMainMenu();
		Rectangle clientRectangle = ((Control)this).get_ClientRectangle();
		GroupBox val = new GroupBox();
		((Control)val).SetBounds(2, clientRectangle.Top, clientRectangle.Width - 4, 2);
		((Control)val).set_Anchor((AnchorStyles)13);
		((Control)val).set_Enabled(false);
		((Control)this).get_Controls().Add((Control)(object)val);
		myTabControl = new TabControl();
		if (UseFlatStyle)
		{
			myTabControl.set_Appearance((TabAppearance)2);
		}
		else
		{
			myTabControl.set_Appearance((TabAppearance)0);
		}
		Rectangle bounds = Rectangle.Inflate(clientRectangle, -4, -14);
		bounds.Offset(0, -10);
		((Control)myTabControl).set_Bounds(bounds);
		((Control)myTabControl).set_Anchor((AnchorStyles)15);
		myTabControl.add_SelectedIndexChanged((EventHandler)HandleSelectedTabIndexChanged);
		((Control)this).get_Controls().Add((Control)(object)myTabControl);
		InitProgressPage(graphics);
		InitPeersPage(graphics);
		InitFileMappingsPage(graphics);
		InitOptionsPage(graphics);
		InitLogPage(graphics);
		myTabControl.set_SelectedTab(myTabControl.get_TabPages().get_Item(SelectedTabPageIndex));
		InitStatusBar();
		InitMainContextMenu();
		InitJobDataContextMenu();
		InitPeerDataContextMenu();
		InitFileMappingsContextMenu();
	}

	private void InitPeersPage(Graphics graphics)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected O, but got Unknown
		myPeersPage = new TabPage(LRZ("PeersPageTitle"));
		((Control)myTabControl).get_Controls().Add((Control)(object)myPeersPage);
		Rectangle clientRectangle = ((Control)myPeersPage).get_ClientRectangle();
		myPeerDataChooserLabel = new Label();
		if (UseFlatStyle)
		{
			myPeerDataChooserLabel.set_FlatStyle((FlatStyle)3);
		}
		else
		{
			myPeerDataChooserLabel.set_FlatStyle((FlatStyle)2);
		}
		((Control)myPeerDataChooserLabel).set_Text(LRZ("PeerDataChooserLabel"));
		((Control)myPeerDataChooserLabel).set_AutoSize(true);
		((Control)myPeerDataChooserLabel).set_Location(new Point(clientRectangle.Left + 6, clientRectangle.Top + 6));
		((Control)myPeersPage).get_Controls().Add((Control)(object)myPeerDataChooserLabel);
		myPeerDataChooser = new ComboBox();
		myPeerDataChooser.set_DropDownStyle((ComboBoxStyle)2);
		myPeerDataChooser.get_Items().Add((object)LRZ("PeerDataChoiceBasic"));
		myPeerDataChooser.get_Items().Add((object)LRZ("PeerDataChoiceAdvanced"));
		((ListControl)myPeerDataChooser).set_SelectedIndex(0);
		int num = DynaSizeControl(graphics, myPeerDataChooser);
		((Control)myPeerDataChooser).SetBounds(((Control)myPeerDataChooserLabel).get_Right() + 6, clientRectangle.Top + 2, num, myPeerDataChooser.get_PreferredHeight());
		((ListControl)myPeerDataChooser).add_SelectedValueChanged((EventHandler)HandleChoosePeerDataBinding);
		((Control)myPeersPage).get_Controls().Add((Control)(object)myPeerDataChooser);
		myPeerDataGrid = new DataGrid();
		if (UseFlatStyle)
		{
			myPeerDataGrid.set_FlatMode(true);
		}
		else
		{
			myPeerDataGrid.set_FlatMode(false);
		}
		myPeerDataGrid.set_AllowSorting(false);
		myPeerDataGrid.set_CaptionVisible(true);
		myPeerDataGrid.set_CaptionText(LRZ("PeersPageTitle"));
		((Control)myPeerDataGrid).SetBounds(0, 0, ((Control)myPeersPage).get_ClientRectangle().Width, ((Control)myPeersPage).get_ClientRectangle().Height);
		((Control)myPeerDataGrid).SetBounds(clientRectangle.Left + 2, ((Control)myPeerDataChooser).get_Bottom() + 4, clientRectangle.Width - 4, clientRectangle.Height - ((Control)myPeerDataChooser).get_Bottom() - 8);
		((Control)myPeerDataGrid).set_Anchor((AnchorStyles)15);
		((Control)myPeerDataGrid).add_VisibleChanged((EventHandler)HandleDataGridVisibleChanged);
		((Control)myPeersPage).get_Controls().Add((Control)(object)myPeerDataGrid);
		myPeerDataGrid.SetDataBinding((object)myPeerData, (string)null);
		InitBasicPeerDataGridStyle();
		myPeerData.RowChanged += HandlePeerDataRowChanged;
		myPeerData.ColumnChanged += HandlePeerDataColumnChanged;
		myPeerData.RowDeleted += HandlePeerDataRowDeleted;
	}

	private void InitProgressPage(Graphics graphics)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected O, but got Unknown
		myProgressPage = new TabPage(LRZ("ProgressPageTitle"));
		((Control)myTabControl).get_Controls().Add((Control)(object)myProgressPage);
		Rectangle clientRectangle = ((Control)myProgressPage).get_ClientRectangle();
		myJobDataChooserLabel = new Label();
		if (UseFlatStyle)
		{
			myJobDataChooserLabel.set_FlatStyle((FlatStyle)3);
		}
		else
		{
			myJobDataChooserLabel.set_FlatStyle((FlatStyle)2);
		}
		((Control)myJobDataChooserLabel).set_Text(LRZ("ProgressDataChooserLabel"));
		((Control)myJobDataChooserLabel).set_AutoSize(true);
		((Control)myJobDataChooserLabel).set_Location(new Point(clientRectangle.Left + 6, clientRectangle.Top + 6));
		((Control)myProgressPage).get_Controls().Add((Control)(object)myJobDataChooserLabel);
		myJobDataChooser = new ComboBox();
		myJobDataChooser.set_DropDownStyle((ComboBoxStyle)2);
		myJobDataChooser.get_Items().Add((object)LRZ("JobDataChoiceSummary"));
		myJobDataChooser.get_Items().Add((object)LRZ("JobDataChoiceDetails"));
		((ListControl)myJobDataChooser).set_SelectedIndex(0);
		int num = DynaSizeControl(graphics, myJobDataChooser);
		((Control)myJobDataChooser).SetBounds(((Control)myJobDataChooserLabel).get_Right() + 6, clientRectangle.Top + 2, num, myJobDataChooser.get_PreferredHeight());
		((ListControl)myJobDataChooser).add_SelectedValueChanged((EventHandler)HandleChooseJobDataBinding);
		((Control)myProgressPage).get_Controls().Add((Control)(object)myJobDataChooser);
		myJobDataGrid = new DataGrid();
		if (UseFlatStyle)
		{
			myJobDataGrid.set_FlatMode(true);
		}
		else
		{
			myJobDataGrid.set_FlatMode(false);
		}
		myJobDataGrid.set_AllowSorting(false);
		myJobDataGrid.set_CaptionVisible(true);
		myJobDataGrid.set_CaptionText(LRZ("JobDataGridCaptionTextSummary"));
		((Control)myJobDataGrid).SetBounds(clientRectangle.Left + 2, ((Control)myJobDataChooser).get_Bottom() + 4, clientRectangle.Width - 4, clientRectangle.Height - ((Control)myJobDataChooser).get_Bottom() - 8);
		((Control)myJobDataGrid).set_Anchor((AnchorStyles)15);
		myJobDataGrid.set_ReadOnly(true);
		myJobDataGrid.set_AllowNavigation(true);
		myJobDataGrid.add_CurrentCellChanged((EventHandler)HandleJobDataCurrentCellChanged);
		((Control)myJobDataGrid).add_VisibleChanged((EventHandler)HandleDataGridVisibleChanged);
		((Control)myProgressPage).get_Controls().Add((Control)(object)myJobDataGrid);
		myJobDataGrid.SetDataBinding((object)myDataSet, "Summary");
		InitJobDataGridStyles();
		InitStatDataGridStyles();
		InitSegmentDataGridStyles();
		InitSummaryDataGridStyles();
		InitErrorDataGridStyles();
	}

	private int DynaSizeControl(Graphics graphics, ComboBox control)
	{
		int num = 0;
		Font font = ((Control)control).get_Font();
		foreach (string item in control.get_Items())
		{
			int num2 = (int)graphics.MeasureString(item, font).Width;
			if (num2 > num)
			{
				num = num2;
			}
		}
		return num + 30;
	}

	private void InitMainMenu()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected O, but got Unknown
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected O, but got Unknown
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected O, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected O, but got Unknown
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected O, but got Unknown
		myMainMenu = new MainMenu();
		myActionMenu = new MenuItem(LRZ("ActionMenuItem"));
		myActionMenu.add_Popup((EventHandler)HandleActionMenuPopup);
		((Menu)myMainMenu).get_MenuItems().Add(myActionMenu);
		((Menu)myActionMenu).get_MenuItems().Add(new MenuItem(LRZ("HideWindowMenuItem"), (EventHandler)HandleHide));
		((Menu)myActionMenu).get_MenuItems().Add(new MenuItem("-"));
		myRenderingEnabledMainMenuItem = new MenuItem();
		myRenderingEnabledMainMenuItem.set_Text(LRZ("RenderingEnabledMenuItem"));
		ResetRenderingEnabledMenuItem(myRenderingEnabledMainMenuItem);
		myRenderingEnabledMainMenuItem.add_Click((EventHandler)ToggleRenderingEnabled);
		((Menu)myActionMenu).get_MenuItems().Add(myRenderingEnabledMainMenuItem);
		myCancelJobMainMenuItem = new MenuItem();
		myCancelJobMainMenuItem.set_Text(LRZ("CancelJobMenuItemDefault"));
		myCancelJobMainMenuItem.add_Click((EventHandler)HandleCancelJob);
		((Menu)myActionMenu).get_MenuItems().Add(myCancelJobMainMenuItem);
		myAutoFillFileMappings = new MenuItem();
		myAutoFillFileMappings.set_Text(LRZ("AutoFillFileMappingsMenuItem"));
		myAutoFillFileMappings.add_Click((EventHandler)AutoFillFileMappings);
		((Menu)myActionMenu).get_MenuItems().Add(myAutoFillFileMappings);
		((Menu)myActionMenu).get_MenuItems().Add(new MenuItem("-"));
		((Menu)myActionMenu).get_MenuItems().Add(new MenuItem(LRZ("ExitServiceMenuItem"), (EventHandler)HandleExitApp));
		myHelpMenu = new MenuItem(LRZ("HelpMenuItem"));
		((Menu)myMainMenu).get_MenuItems().Add(myHelpMenu);
		((Menu)myHelpMenu).get_MenuItems().Add(new MenuItem(LRZ("ShowAboutBoxMenuItem"), (EventHandler)ShowAboutBox));
		((Menu)myHelpMenu).get_MenuItems().Add(new MenuItem(LRZ("ShowHelpContents"), (EventHandler)ShowHelp));
		((Menu)myHelpMenu).get_MenuItems().Add(new MenuItem(LRZ("EnterSerialNumberMenuItem"), (EventHandler)EnterSerialNumber));
		((Form)this).set_Menu(myMainMenu);
	}

	private void HandleActionMenuPopup(object sender, EventArgs e)
	{
		myTabControl.get_SelectedTab();
		ResetCancelJobMenuItem(myCancelJobMainMenuItem);
		ResetRenderingEnabledMenuItem(myRenderingEnabledMainMenuItem);
	}

	private void InitMainContextMenu()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		myMainContextMenu = new ContextMenu();
		myMainContextMenu.add_Popup((EventHandler)HandleContextMenuPopup);
		((Control)this).set_ContextMenu(myMainContextMenu);
	}

	private void HandleContextMenuPopup(object sender, EventArgs e)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		((Menu)myMainContextMenu).get_MenuItems().Clear();
		((Menu)myMainContextMenu).get_MenuItems().Add(new MenuItem(LRZ("HideWindowMenuItem"), (EventHandler)HandleHide));
		((Menu)myMainContextMenu).get_MenuItems().Add(new MenuItem(LRZ("ExitServiceMenuItem"), (EventHandler)HandleExitApp));
	}

	private void InitPeerDataContextMenu()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		myPeerDataContextMenu = new ContextMenu();
		myPeerDataContextMenu.add_Popup((EventHandler)HandlePeerDataContextMenuPopup);
		((Control)myPeerDataGrid).set_ContextMenu(myPeerDataContextMenu);
	}

	private void HandlePeerDataContextMenuPopup(object sender, EventArgs e)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		((Menu)myPeerDataContextMenu).get_MenuItems().Clear();
		MenuItem val = null;
		string text = null;
		DataRow dataRow = null;
		try
		{
			dataRow = GetSelectedPeerData();
		}
		catch
		{
		}
		val = new MenuItem(LRZ("RefreshAllPeersMenuItem"), (EventHandler)HandleUpdateAllPeerDataStatus);
		((Menu)myPeerDataContextMenu).get_MenuItems().Add(val);
		if (0 == myPeerData.Rows.Count)
		{
			val.set_Enabled(false);
		}
		if (null != dataRow)
		{
			text = string.Format(LRZ("RefreshPeerMenuItem"), dataRow["Host"]);
			val = new MenuItem(text, (EventHandler)HandleUpdateSelectedPeerDataStatus);
			((Menu)myPeerDataContextMenu).get_MenuItems().Add(val);
		}
		val = new MenuItem("-");
		((Menu)myPeerDataContextMenu).get_MenuItems().Add(val);
		val = new MenuItem(LRZ("DeleteAllPeersMenuItem"), (EventHandler)HandleDeleteAllPeers);
		((Menu)myPeerDataContextMenu).get_MenuItems().Add(val);
		if (0 == myPeerData.Rows.Count)
		{
			val.set_Enabled(false);
		}
		if (null != dataRow)
		{
			text = string.Format(LRZ("DeletePeerMenuItem"), dataRow["Host"]);
			val = new MenuItem(text, (EventHandler)HandleDeleteSelectedPeer);
			((Menu)myPeerDataContextMenu).get_MenuItems().Add(val);
		}
	}

	private void InitJobDataContextMenu()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		myJobDataContextMenu = new ContextMenu();
		myJobDataContextCancelJobMenuItem = new MenuItem(LRZ("CancelJobMenuItemDefault"), (EventHandler)HandleCancelJob);
		((Menu)myJobDataContextMenu).get_MenuItems().Add(myJobDataContextCancelJobMenuItem);
		myJobDataContextMenu.add_Popup((EventHandler)HandleJobDataContextMenuPopup);
		((Control)myJobDataGrid).set_ContextMenu(myJobDataContextMenu);
	}

	private void HandleJobDataContextMenuPopup(object sender, EventArgs e)
	{
		ResetCancelJobMenuItem(myJobDataContextCancelJobMenuItem);
	}

	private void ResetCancelJobMenuItem(MenuItem menuItem)
	{
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Invalid comparison between Unknown and I4
		if (null == menuItem)
		{
			return;
		}
		string text = LRZ("CancelJobMenuItemDefault");
		bool enabled = false;
		try
		{
			DataRow selectedJobRow = GetSelectedJobRow();
			if (null == selectedJobRow)
			{
				return;
			}
			DataRow jobStats = GetJobStats(selectedJobRow);
			if (null != jobStats)
			{
				text = string.Format(LRZ("CancelJobMenuItemFormat"), Path.GetFileName((string)selectedJobRow["OutputFile"]));
				RenderStatus val = (RenderStatus)jobStats["RenderStatus"];
				if ((int)val < 4)
				{
					enabled = true;
				}
			}
		}
		catch
		{
		}
		finally
		{
			menuItem.set_Text(text);
			menuItem.set_Enabled(enabled);
		}
	}

	private void InitFileMappingsContextMenu()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		myFileMappingsContextMenu = new ContextMenu();
		myFileMappingsContextAutoFillMappingsMenuItem = new MenuItem(LRZ("AutoFillFileMappingsMenuItem"), (EventHandler)AutoFillFileMappings);
		((Menu)myFileMappingsContextMenu).get_MenuItems().Add(myFileMappingsContextAutoFillMappingsMenuItem);
		((Menu)myFileMappingsContextMenu).get_MenuItems().Add(new MenuItem("-"));
		myFileMappingsContextDeleteMappingMenuItem = new MenuItem(LRZ("DeleteMappingMenuItemDefault"), (EventHandler)HandleDeleteMapping);
		((Menu)myFileMappingsContextMenu).get_MenuItems().Add(myFileMappingsContextDeleteMappingMenuItem);
		myFileMappingsContextDeleteAllMappingsMenuItem = new MenuItem(LRZ("DeleteAllMappingsMenuItem"), (EventHandler)HandleDeleteAllMappings);
		((Menu)myFileMappingsContextMenu).get_MenuItems().Add(myFileMappingsContextDeleteAllMappingsMenuItem);
		myFileMappingsContextMenu.add_Popup((EventHandler)HandleFileMappingsContextMenuPopup);
		((Control)myFileMappingsDataGrid).set_ContextMenu(myFileMappingsContextMenu);
	}

	private void HandleFileMappingsContextMenuPopup(object sender, EventArgs e)
	{
		ResetDeleteFileMappingMenuItem(myFileMappingsContextDeleteMappingMenuItem);
		myFileMappingsContextDeleteAllMappingsMenuItem.set_Enabled(false);
		foreach (DataRow row in myFileMappings.Rows)
		{
			switch (row.RowState)
			{
			case DataRowState.Unchanged:
			case DataRowState.Added:
			case DataRowState.Modified:
				myFileMappingsContextDeleteAllMappingsMenuItem.set_Enabled(true);
				return;
			}
		}
	}

	private void ResetDeleteFileMappingMenuItem(MenuItem menuItem)
	{
		if (null == menuItem)
		{
			return;
		}
		string text = LRZ("DeleteMappingMenuItemDefault");
		bool enabled = false;
		try
		{
			DataRow dataRow = myFileMappings.Rows[myFileMappingsDataGrid.get_CurrentRowIndex()];
			if (null != dataRow)
			{
				string text2 = dataRow["Local"] as string;
				string text3 = dataRow["Universal"] as string;
				if (null != text2)
				{
					text = string.Format(LRZ("DeleteMappingMenuItemFormat"), text2);
				}
				else if (null != text3)
				{
					text = string.Format(LRZ("DeleteMappingMenuItemFormat"), text3);
				}
				enabled = true;
			}
		}
		catch
		{
		}
		finally
		{
			menuItem.set_Text(text);
			menuItem.set_Enabled(enabled);
		}
	}

	private void HandleDeleteMapping(object sender, EventArgs e)
	{
		try
		{
			DataRow dataRow = myFileMappings.Rows[myFileMappingsDataGrid.get_CurrentRowIndex()];
			if (null != dataRow)
			{
				dataRow.Delete();
			}
		}
		catch
		{
		}
	}

	private void HandleDeleteAllMappings(object sender, EventArgs e)
	{
		if (null == myFileMappings)
		{
			return;
		}
		int count = myFileMappings.Rows.Count;
		if (0 >= count)
		{
			return;
		}
		DataRow[] array = new DataRow[count];
		myFileMappings.Rows.CopyTo(array, 0);
		DataRow[] array2 = array;
		foreach (DataRow dataRow in array2)
		{
			try
			{
				dataRow.Delete();
			}
			catch
			{
			}
		}
	}

	private void InitStatusBar()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected O, but got Unknown
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected O, but got Unknown
		Rectangle clientRectangle = ((Control)this).get_ClientRectangle();
		myLocalServiceStateLabel = new Label();
		if (UseFlatStyle)
		{
			myLocalServiceStateLabel.set_FlatStyle((FlatStyle)3);
		}
		else
		{
			myLocalServiceStateLabel.set_FlatStyle((FlatStyle)2);
		}
		((Control)myLocalServiceStateLabel).set_Text(string.Format(LRZ("LocalServiceStateLabel"), "XXXXXXXXXXXX"));
		int preferredHeight = myLocalServiceStateLabel.get_PreferredHeight();
		int num = myLocalServiceStateLabel.get_PreferredWidth() + 8;
		myLocalServiceStateLabel.set_BorderStyle((BorderStyle)2);
		myLocalServiceStateLabel.set_TextAlign((ContentAlignment)16);
		((Control)myLocalServiceStateLabel).SetBounds(clientRectangle.Right - 120 - 2, clientRectangle.Bottom - preferredHeight - 2, 120, preferredHeight);
		((Control)myLocalServiceStateLabel).set_Anchor((AnchorStyles)10);
		((Control)this).get_Controls().Add((Control)(object)myLocalServiceStateLabel);
		myLocalServicePortLabel = new Label();
		if (UseFlatStyle)
		{
			myLocalServicePortLabel.set_FlatStyle((FlatStyle)3);
		}
		else
		{
			myLocalServicePortLabel.set_FlatStyle((FlatStyle)2);
		}
		((Control)myLocalServicePortLabel).set_Text(string.Format(LRZ("LocalPortLabel"), myURL.get_Port()));
		preferredHeight = myLocalServicePortLabel.get_PreferredHeight();
		num = myLocalServicePortLabel.get_PreferredWidth() + 8;
		myLocalServicePortLabel.set_BorderStyle((BorderStyle)2);
		myLocalServicePortLabel.set_TextAlign((ContentAlignment)16);
		((Control)myLocalServicePortLabel).SetBounds(((Control)myLocalServiceStateLabel).get_Left() - num - 2, clientRectangle.Bottom - preferredHeight - 2, num, preferredHeight);
		((Control)myLocalServicePortLabel).set_Anchor((AnchorStyles)10);
		((Control)this).get_Controls().Add((Control)(object)myLocalServicePortLabel);
		myLocalServiceHostNameLabel = new Label();
		if (UseFlatStyle)
		{
			myLocalServiceHostNameLabel.set_FlatStyle((FlatStyle)3);
		}
		else
		{
			myLocalServiceHostNameLabel.set_FlatStyle((FlatStyle)2);
		}
		((Control)myLocalServiceHostNameLabel).set_Text(string.Format(LRZ("LocalHostLabel"), myURL.get_HostName()));
		preferredHeight = myLocalServiceHostNameLabel.get_PreferredHeight();
		num = myLocalServiceHostNameLabel.get_PreferredWidth() + 8;
		myLocalServiceHostNameLabel.set_BorderStyle((BorderStyle)2);
		myLocalServiceHostNameLabel.set_TextAlign((ContentAlignment)16);
		((Control)myLocalServiceHostNameLabel).SetBounds(((Control)myLocalServicePortLabel).get_Left() - num - 2, clientRectangle.Bottom - preferredHeight - 2, num, preferredHeight);
		((Control)myLocalServiceHostNameLabel).set_Anchor((AnchorStyles)10);
		((Control)this).get_Controls().Add((Control)(object)myLocalServiceHostNameLabel);
		myProgressLabel = new Label();
		if (UseFlatStyle)
		{
			myProgressLabel.set_FlatStyle((FlatStyle)3);
		}
		else
		{
			myProgressLabel.set_FlatStyle((FlatStyle)2);
		}
		myProgressLabel.set_BorderStyle((BorderStyle)2);
		((Control)myProgressLabel).SetBounds(clientRectangle.Left + 2, clientRectangle.Bottom - preferredHeight - 2, ((Control)myLocalServiceHostNameLabel).get_Left() - clientRectangle.Left - 4, preferredHeight);
		myProgressLabel.set_TextAlign((ContentAlignment)16);
		((Control)myProgressLabel).set_Anchor((AnchorStyles)14);
		((Control)this).get_Controls().Add((Control)(object)myProgressLabel);
	}

	private void InitFileMappingsPage(Graphics graphics)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		myFileMappingsPage = new TabPage(LRZ("MappingsPageTitle"));
		((Control)myTabControl).get_Controls().Add((Control)(object)myFileMappingsPage);
		Rectangle clientRectangle = ((Control)myFileMappingsPage).get_ClientRectangle();
		myFileMappingsDataGrid = new DataGrid();
		if (UseFlatStyle)
		{
			myFileMappingsDataGrid.set_FlatMode(true);
		}
		else
		{
			myFileMappingsDataGrid.set_FlatMode(false);
		}
		myFileMappingsDataGrid.set_AllowSorting(false);
		myFileMappingsDataGrid.set_CaptionVisible(true);
		myFileMappingsDataGrid.set_CaptionText(LRZ("MappingsPageTitle"));
		myFileMappingsDataGrid.set_PreferredColumnWidth(260);
		((Control)myFileMappingsDataGrid).SetBounds(6, clientRectangle.Top + 6, clientRectangle.Width - 20, clientRectangle.Height - 16);
		((Control)myFileMappingsDataGrid).set_Anchor((AnchorStyles)15);
		((Control)myFileMappingsDataGrid).add_VisibleChanged((EventHandler)HandleDataGridVisibleChanged);
		((Control)myFileMappingsPage).get_Controls().Add((Control)(object)myFileMappingsDataGrid);
		myFileMappingsDataGrid.SetDataBinding((object)myFileMappings, (string)null);
	}

	private void InitOptionsPage(Graphics graphics)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Expected O, but got Unknown
		//IL_046b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0475: Expected O, but got Unknown
		myOptionsPage = new TabPage(LRZ("OptionsPageTitle"));
		((Control)myTabControl).get_Controls().Add((Control)(object)myOptionsPage);
		Rectangle clientRectangle = ((Control)myOptionsPage).get_ClientRectangle();
		myBooleanOptionListBox = new CheckedListBox();
		if (UseFlatStyle)
		{
			myBooleanOptionListBox.set_ThreeDCheckBoxes(false);
		}
		else
		{
			myBooleanOptionListBox.set_ThreeDCheckBoxes(true);
		}
		myBooleanOptionListBox.set_CheckOnClick(true);
		((Control)myBooleanOptionListBox).SetBounds(clientRectangle.Left + 4, clientRectangle.Top + 10, clientRectangle.Width - 8, clientRectangle.Height - 60);
		((Control)myBooleanOptionListBox).set_Anchor((AnchorStyles)15);
		myBooleanOptionListBox.add_ItemCheck(new ItemCheckEventHandler(HandleBooleanOptionItemCheck));
		RenderingEnabled.AddToListBox(myBooleanOptionListBox);
		AutoRun.AddToListBox(myBooleanOptionListBox);
		HideWhenMinimized.AddToListBox(myBooleanOptionListBox);
		ExitOnClose.AddToListBox(myBooleanOptionListBox);
		ExitVegasOnIdle.AddToListBox(myBooleanOptionListBox);
		((Control)myOptionsPage).get_Controls().Add((Control)(object)myBooleanOptionListBox);
		int num = 88;
		myAgeOfStaleJobsLabel = new Label();
		if (UseFlatStyle)
		{
			myAgeOfStaleJobsLabel.set_FlatStyle((FlatStyle)3);
		}
		else
		{
			myAgeOfStaleJobsLabel.set_FlatStyle((FlatStyle)2);
		}
		((Control)myAgeOfStaleJobsLabel).set_Text(LRZ("AgeOfStaleJobsLabel"));
		((Control)myAgeOfStaleJobsLabel).set_AutoSize(true);
		((Control)myAgeOfStaleJobsLabel).SetBounds(10, ((Control)myBooleanOptionListBox).get_Bottom() + 8, 0, 0, (BoundsSpecified)3);
		((Control)myAgeOfStaleJobsLabel).set_Anchor((AnchorStyles)6);
		((Control)myOptionsPage).get_Controls().Add((Control)(object)myAgeOfStaleJobsLabel);
		myAgeOfStaleJobsControl = new DomainUpDown();
		((UpDownBase)myAgeOfStaleJobsControl).set_ReadOnly(true);
		myAgeOfStaleJobsControl.set_Wrap(false);
		myAgeOfStaleJobsControl.set_Sorted(false);
		((Control)myAgeOfStaleJobsControl).SetBounds(((Control)myAgeOfStaleJobsLabel).get_Right() + 10, ((Control)myAgeOfStaleJobsLabel).get_Top() - 4, num, 20);
		((Control)myAgeOfStaleJobsControl).set_Anchor((AnchorStyles)6);
		((ArrayList)(object)myAgeOfStaleJobsControl.get_Items()).Add((object?)new AgeToken(LRZ("AgeToken1Min"), 600000000L));
		((ArrayList)(object)myAgeOfStaleJobsControl.get_Items()).Add((object?)new AgeToken(LRZ("AgeToken5Min"), 1800000000L));
		((ArrayList)(object)myAgeOfStaleJobsControl.get_Items()).Add((object?)new AgeToken(LRZ("AgeToken10Min"), 6000000000L));
		((ArrayList)(object)myAgeOfStaleJobsControl.get_Items()).Add((object?)new AgeToken(LRZ("AgeToken30Min"), 18000000000L));
		((ArrayList)(object)myAgeOfStaleJobsControl.get_Items()).Add((object?)new AgeToken(LRZ("AgeToken1Hour"), 36000000000L));
		((ArrayList)(object)myAgeOfStaleJobsControl.get_Items()).Add((object?)new AgeToken(LRZ("AgeToken3Hour"), 108000000000L));
		((ArrayList)(object)myAgeOfStaleJobsControl.get_Items()).Add((object?)new AgeToken(LRZ("AgeToken6Hour"), 216000000000L));
		((ArrayList)(object)myAgeOfStaleJobsControl.get_Items()).Add((object?)new AgeToken(LRZ("AgeToken12Hour"), 432000000000L));
		((ArrayList)(object)myAgeOfStaleJobsControl.get_Items()).Add((object?)new AgeToken(LRZ("AgeToken1Day"), 864000000000L));
		InitAgeOfStaleJobsControlItem();
		myAgeOfStaleJobsControl.add_SelectedItemChanged((EventHandler)HandleAgeOfStaleJobsChanged);
		((Control)myOptionsPage).get_Controls().Add((Control)(object)myAgeOfStaleJobsControl);
		myDefaultFramesPerSegmentLabel = new Label();
		if (UseFlatStyle)
		{
			myDefaultFramesPerSegmentLabel.set_FlatStyle((FlatStyle)3);
		}
		else
		{
			myDefaultFramesPerSegmentLabel.set_FlatStyle((FlatStyle)2);
		}
		((Control)myDefaultFramesPerSegmentLabel).set_Text(LRZ("DefaultFramesPerSegmentLabel"));
		((Control)myDefaultFramesPerSegmentLabel).set_AutoSize(true);
		((Control)myDefaultFramesPerSegmentLabel).SetBounds(10, ((Control)myAgeOfStaleJobsControl).get_Bottom() + 8, 0, 0, (BoundsSpecified)3);
		((Control)myDefaultFramesPerSegmentLabel).set_Anchor((AnchorStyles)6);
		((Control)myOptionsPage).get_Controls().Add((Control)(object)myDefaultFramesPerSegmentLabel);
		myDefaultFramesPerSegmentControl = new NumericUpDown();
		myDefaultFramesPerSegmentControl.set_Maximum(1800m);
		myDefaultFramesPerSegmentControl.set_Minimum(5m);
		myDefaultFramesPerSegmentControl.set_Value(DefaultFramesPerSegment);
		myDefaultFramesPerSegmentControl.set_Value(DefaultFramesPerSegment);
		((UpDownBase)myDefaultFramesPerSegmentControl).set_ReadOnly(false);
		((Control)myDefaultFramesPerSegmentControl).SetBounds(((Control)myAgeOfStaleJobsControl).get_Left(), ((Control)myDefaultFramesPerSegmentLabel).get_Top() - 4, num, 20);
		((Control)myDefaultFramesPerSegmentControl).set_Anchor((AnchorStyles)6);
		myDefaultFramesPerSegmentControl.add_ValueChanged((EventHandler)HandleDefaultFramesPerSegmentChanged);
		((Control)myDefaultFramesPerSegmentControl).add_Leave((EventHandler)HandleDefaultFramesPerSegmentLeave);
		((Control)myOptionsPage).get_Controls().Add((Control)(object)myDefaultFramesPerSegmentControl);
	}

	private void InitLogPage(Graphics graphics)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		myLogPage = new TabPage(LRZ("LogPageTitle"));
		((Control)myTabControl).get_Controls().Add((Control)(object)myLogPage);
		myLogTextBox = new TextBox();
		((TextBoxBase)myLogTextBox).set_ReadOnly(true);
		myLogTextBox.set_ScrollBars((ScrollBars)3);
		((Control)myLogTextBox).set_AutoSize(true);
		((TextBoxBase)myLogTextBox).set_Multiline(true);
		((TextBoxBase)myLogTextBox).set_WordWrap(false);
		((Control)myLogTextBox).SetBounds(0, 0, ((Control)myLogPage).get_ClientRectangle().Width, ((Control)myLogPage).get_ClientRectangle().Height);
		((Control)myLogTextBox).set_Anchor((AnchorStyles)15);
		((Control)myLogPage).get_Controls().Add((Control)(object)myLogTextBox);
		RefillLogTextBox();
	}

	private void HandleBooleanOptionItemCheck(object sender, ItemCheckEventArgs e)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between I4 and Unknown
		BooleanOption booleanOption = (BooleanOption)((ObjectCollection)myBooleanOptionListBox.get_Items()).get_Item(e.get_Index());
		booleanOption.Value = 1 == (int)e.get_NewValue();
	}

	private void HandleDataGridVisibleChanged(object sender, EventArgs e)
	{
		DataGrid val = (DataGrid)((sender is DataGrid) ? sender : null);
		if (val != null && ((Control)val).get_Visible())
		{
			((Control)val).PerformLayout();
		}
	}

	private void InitBasicPeerDataGridStyle()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		DataGridTableStyle val = new DataGridTableStyle();
		val.set_MappingName(myPeerData.TableName);
		val.set_PreferredColumnWidth(80);
		val.set_RowHeadersVisible(true);
		val.set_AllowSorting(false);
		DataGridColumnStyle val2 = (DataGridColumnStyle)new DataGridTextBoxColumn();
		val2.set_MappingName("Host");
		val2.set_HeaderText(LRZ("ColHeaderHost"));
		val2.set_NullText(LRZ("UnknownHost"));
		val2.set_Width(120);
		val2.set_ReadOnly(false);
		val.get_GridColumnStyles().Add(val2);
		val2 = (DataGridColumnStyle)new DataGridTextBoxColumn();
		val2.set_MappingName("ServiceState");
		val2.set_HeaderText(LRZ("ColHeaderStatus"));
		val2.set_NullText(LRZ("UnknownValue"));
		val2.set_Width(120);
		val2.set_ReadOnly(true);
		val.get_GridColumnStyles().Add(val2);
		myPeerDataGrid.get_TableStyles().Clear();
		myPeerDataGrid.get_TableStyles().Add(val);
	}

	private void InitAdvancedPeerDataGridStyle()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		DataGridTableStyle val = new DataGridTableStyle();
		val.set_MappingName(myPeerData.TableName);
		val.set_PreferredColumnWidth(80);
		val.set_RowHeadersVisible(true);
		val.set_AllowSorting(false);
		DataGridColumnStyle val2 = (DataGridColumnStyle)new DataGridTextBoxColumn();
		val2.set_MappingName("URL");
		val2.set_HeaderText(LRZ("ColHeaderURL"));
		val2.set_NullText(LRZ("UnknownValue"));
		val2.set_Width(240);
		val2.set_ReadOnly(false);
		val.get_GridColumnStyles().Add(val2);
		val2 = (DataGridColumnStyle)new DataGridTextBoxColumn();
		val2.set_MappingName("ServiceState");
		val2.set_HeaderText(LRZ("ColHeaderStatus"));
		val2.set_NullText(LRZ("UnknownValue"));
		val2.set_Width(120);
		val2.set_ReadOnly(true);
		val.get_GridColumnStyles().Add(val2);
		myPeerDataGrid.get_TableStyles().Clear();
		myPeerDataGrid.get_TableStyles().Add(val);
	}

	private void InitJobDataGridStyles()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		DataGridTableStyle val = new DataGridTableStyle();
		val.set_MappingName("Jobs");
		val.set_PreferredColumnWidth(80);
		val.set_RowHeadersVisible(true);
		val.set_AllowSorting(false);
		val.set_ReadOnly(true);
		DataGridColumnStyle val2 = (DataGridColumnStyle)new DataGridTextBoxColumn();
		val2.set_MappingName("Owner");
		val2.set_HeaderText(LRZ("ColHeaderOwner"));
		val2.set_Width(120);
		val.get_GridColumnStyles().Add(val2);
		val2 = (DataGridColumnStyle)new DataGridTextBoxColumn();
		val2.set_MappingName("Port");
		val2.set_HeaderText(LRZ("ColHeaderPort"));
		val2.set_Width(60);
		val.get_GridColumnStyles().Add(val2);
		val2 = (DataGridColumnStyle)new DataGridTextBoxColumn();
		val2.set_MappingName("JobID");
		val2.set_HeaderText(LRZ("ColHeaderJobID"));
		val2.set_Width(60);
		val.get_GridColumnStyles().Add(val2);
		val2 = (DataGridColumnStyle)new DataGridTextBoxColumn();
		val2.set_MappingName("Project");
		val2.set_HeaderText(LRZ("ColHeaderProjectFile"));
		val2.set_Width(240);
		val.get_GridColumnStyles().Add(val2);
		val2 = (DataGridColumnStyle)new DataGridTextBoxColumn();
		val2.set_MappingName("OutputFile");
		val2.set_HeaderText(LRZ("ColHeaderOutputFile"));
		val2.set_Width(240);
		val.get_GridColumnStyles().Add(val2);
		myJobDataGrid.get_TableStyles().Add(val);
	}

	private void InitStatDataGridStyles()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		DataGridTableStyle val = new DataGridTableStyle();
		val.set_MappingName("Stats");
		val.set_PreferredColumnWidth(80);
		val.set_RowHeadersVisible(false);
		val.set_AllowSorting(false);
		val.set_ReadOnly(true);
		DataGridColumnStyle val2 = (DataGridColumnStyle)new DataGridTextBoxColumn();
		val2.set_MappingName("RenderStatus");
		val2.set_HeaderText(LRZ("ColHeaderStatus"));
		val2.set_Width(80);
		val.get_GridColumnStyles().Add(val2);
		val2 = (DataGridColumnStyle)new DataGridTextBoxColumn();
		val2.set_MappingName("RenderStartTime");
		val2.set_HeaderText(LRZ("ColHeaderStartTime"));
		val2.set_Width(120);
		val.get_GridColumnStyles().Add(val2);
		val2 = (DataGridColumnStyle)new DataGridTextBoxColumn();
		val2.set_MappingName("RenderDuration");
		val2.set_HeaderText(LRZ("ColHeaderRenderDuration"));
		val2.set_Width(120);
		val.get_GridColumnStyles().Add(val2);
		val2 = (DataGridColumnStyle)new DataGridTextBoxColumn();
		val2.set_MappingName("Completed");
		val2.set_HeaderText(LRZ("ColHeaderCompleted"));
		val2.set_Width(80);
		val.get_GridColumnStyles().Add(val2);
		myJobDataGrid.get_TableStyles().Add(val);
	}

	private void InitSegmentDataGridStyles()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		DataGridTableStyle val = new DataGridTableStyle();
		val.set_MappingName("Segments");
		val.set_PreferredColumnWidth(80);
		val.set_RowHeadersVisible(true);
		val.set_AllowSorting(false);
		val.set_ReadOnly(true);
		DataGridColumnStyle val2 = (DataGridColumnStyle)new DataGridTextBoxColumn();
		val2.set_MappingName("Segment");
		val2.set_HeaderText(LRZ("ColHeaderSegment"));
		val2.set_Width(260);
		val.get_GridColumnStyles().Add(val2);
		val2 = (DataGridColumnStyle)new DataGridTextBoxColumn();
		val2.set_MappingName("Worker");
		val2.set_HeaderText(LRZ("ColHeaderWorker"));
		val2.set_Width(120);
		val.get_GridColumnStyles().Add(val2);
		val2 = (DataGridColumnStyle)new DataGridTextBoxColumn();
		val2.set_MappingName("RenderStatus");
		val2.set_HeaderText(LRZ("ColHeaderStatus"));
		val2.set_Width(120);
		val.get_GridColumnStyles().Add(val2);
		myJobDataGrid.get_TableStyles().Add(val);
	}

	private void InitSummaryDataGridStyles()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		DataGridTableStyle val = new DataGridTableStyle();
		val.set_MappingName("Summary");
		val.set_PreferredColumnWidth(80);
		val.set_RowHeadersVisible(true);
		val.set_AllowSorting(false);
		val.set_ReadOnly(true);
		DataGridColumnStyle val2 = (DataGridColumnStyle)new DataGridTextBoxColumn();
		val2.set_MappingName("Owner");
		val2.set_HeaderText(LRZ("ColHeaderOwner"));
		val2.set_Width(140);
		val.get_GridColumnStyles().Add(val2);
		val2 = (DataGridColumnStyle)new DataGridTextBoxColumn();
		val2.set_MappingName("RenderStatus");
		val2.set_HeaderText(LRZ("ColHeaderStatus"));
		val2.set_Width(80);
		val.get_GridColumnStyles().Add(val2);
		val2 = (DataGridColumnStyle)new DataGridTextBoxColumn();
		val2.set_MappingName("Output");
		val2.set_HeaderText(LRZ("ColHeaderOutput"));
		val2.set_Width(120);
		val.get_GridColumnStyles().Add(val2);
		val2 = (DataGridColumnStyle)new DataGridTextBoxColumn();
		val2.set_MappingName("Project");
		val2.set_HeaderText(LRZ("ColHeaderProject"));
		val2.set_Width(120);
		val.get_GridColumnStyles().Add(val2);
		val2 = (DataGridColumnStyle)new DataGridTextBoxColumn();
		val2.set_MappingName("RenderDuration");
		val2.set_HeaderText(LRZ("ColHeaderDuration"));
		val2.set_Width(80);
		val.get_GridColumnStyles().Add(val2);
		val2 = (DataGridColumnStyle)new DataGridTextBoxColumn();
		val2.set_MappingName("Completed");
		val2.set_HeaderText(LRZ("ColHeaderCompleted"));
		val2.set_Width(80);
		val.get_GridColumnStyles().Add(val2);
		myJobDataGrid.get_TableStyles().Add(val);
	}

	private void InitErrorDataGridStyles()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		DataGridTableStyle val = new DataGridTableStyle();
		val.set_MappingName("Errors");
		val.set_RowHeadersVisible(true);
		val.set_AllowSorting(false);
		val.set_ReadOnly(true);
		DataGridColumnStyle val2 = (DataGridColumnStyle)new DataGridTextBoxColumn();
		val2.set_MappingName("Source");
		val2.set_HeaderText(LRZ("ColHeaderErrorSource"));
		val2.set_Width(140);
		val.get_GridColumnStyles().Add(val2);
		val2 = (DataGridColumnStyle)new DataGridTextBoxColumn();
		val2.set_MappingName("Error");
		val2.set_HeaderText(LRZ("ColHeaderError"));
		val2.set_Width(640);
		val.get_GridColumnStyles().Add(val2);
		myJobDataGrid.get_TableStyles().Add(val);
	}

	private void StartRemoting()
	{
		try
		{
			if (null == ConfigFile)
			{
				ConfigFile = Path.Combine(AppDir, "NetRenderService.config");
			}
			try
			{
				RemotingConfiguration.Configure(ConfigFile, false);
			}
			catch (RemotingException)
			{
				throw new ApplicationException(LRZ("RemotingConfigurationError"));
			}
			myURL = GetURLForService();
			myService = myURL.GetService();
			InitLogFileDirectory();
			myService.BeginService(myURL, LogFileDirectory);
			myService.set_RenderingEnabled(RenderingEnabled.Value);
			myService.set_ExitVegasOnIdle(ExitVegasOnIdle.Value);
			myService.set_DefaultFramesPerSegment((long)DefaultFramesPerSegment);
			LoadRoster();
			LoadFileMappings();
			LoadRecentTempFileDirectories();
			myService.InitializationComplete();
		}
		catch (Exception err)
		{
			string errMsg = LRZ("ServiceInitError");
			Bail(errMsg, err);
		}
	}

	private NetRenderServiceURL GetURLForService()
	{
		WellKnownServiceTypeEntry val = null;
		WellKnownServiceTypeEntry[] registeredWellKnownServiceTypes = RemotingConfiguration.GetRegisteredWellKnownServiceTypes();
		foreach (WellKnownServiceTypeEntry val2 in registeredWellKnownServiceTypes)
		{
			if ((object)val2.get_ObjectType() == typeof(NetRenderService))
			{
				val = val2;
				break;
			}
		}
		if (null == val)
		{
			throw new ApplicationException(LRZ("FindConfigEntryError"));
		}
		Log((LogWhat)1042, "Render Service URI: " + val.get_ObjectUri());
		IChannel val3 = null;
		IChannel[] registeredChannels = ChannelServices.get_RegisteredChannels();
		foreach (IChannel val4 in registeredChannels)
		{
			if (val4.get_ChannelName() == "NetRenderService")
			{
				val3 = val4;
				break;
			}
		}
		if (null == val3)
		{
			throw new ApplicationException(LRZ("FindChannelError"));
		}
		Log((LogWhat)1042, "Channel Type: " + ((object)val3).GetType().ToString());
		string[] array = null;
		TcpChannel val5 = (TcpChannel)(object)((val3 is TcpChannel) ? val3 : null);
		if (null != val5)
		{
			array = val5.GetUrlsForUri(val.get_ObjectUri());
		}
		else
		{
			HttpChannel val6 = (HttpChannel)(object)((val3 is HttpChannel) ? val3 : null);
			if (null != val6)
			{
				array = val6.GetUrlsForUri(val.get_ObjectUri());
			}
		}
		if (array == null || 0 == array.Length)
		{
			throw new ApplicationException(LRZ("FindURLError"));
		}
		UriBuilder uriBuilder = new UriBuilder(array[0]);
		IPAddress address = IPAddress.None;
		try
		{
			address = IPAddress.Parse(uriBuilder.Host);
			IPHostEntry hostEntry = Dns.GetHostEntry(address);
			if (1 == hostEntry.AddressList.Length)
			{
				uriBuilder.Host = hostEntry.HostName;
			}
		}
		catch
		{
		}
		NetRenderServiceURL val7 = NetRenderServiceURL.FromString(uriBuilder.ToString(), uriBuilder.Port);
		val7.set_Address(address);
		Log((LogWhat)1042, "Network Render Service url: " + ((object)val7).ToString());
		return val7;
	}

	private NetRenderServiceURL MakeURLFromHostName(string host)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		if (host == null || string.Empty == host)
		{
			throw new ApplicationException(LRZ("InvalidHostNameError"));
		}
		NetRenderServiceURL val = new NetRenderServiceURL();
		val.set_Method(myURL.get_Method());
		val.set_HostName(host);
		val.set_Port(myURL.get_Port());
		val.set_URI(myURL.get_URI());
		return val;
	}

	private NetRenderServiceURL MakeURL(string url)
	{
		if (url == null || string.Empty == url)
		{
			throw new ApplicationException(LRZ("InvalidURLError"));
		}
		return NetRenderServiceURL.FromString(url, myURL.get_Port());
	}

	private void ShowError(string header, Exception err, string footer)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		string arg = string.Empty;
		if (null != err)
		{
			arg = err.Message;
		}
		string text = $"{header}\n\n{arg}\n\n{footer}";
		string text2 = myWindowTitleString;
		MessageBox.Show((IWin32Window)(object)this, text, text2, (MessageBoxButtons)0, (MessageBoxIcon)16, (MessageBoxDefaultButton)0);
	}

	private void Bail(string errMsg, Exception err)
	{
		string footer = LRZ("BailMessageFooter");
		ShowError(errMsg, err, footer);
		((Form)this).Close();
	}

	private void StopRemoting()
	{
		if (null != myService)
		{
			if (myRefreshTimer.get_Enabled())
			{
				myRefreshTimer.Stop();
			}
			Log((LogWhat)1039, LRZ("ShuttingDownService"));
			myService.EndService();
			myService = null;
		}
	}

	public void InitLogFileDirectory()
	{
		LogFileDirectory = GetSetting("LogFileDirectory");
		if (LogFileDirectory == null || string.Empty == LogFileDirectory)
		{
			LogFileDirectory = Path.Combine(AppPathHelpers.get_ApplicationDataPath(), $"VegSrvLogs\\{myURL.get_HostName()}.{myURL.get_Port()}");
		}
		Log((LogWhat)1042, "Log File Directory: " + LogFileDirectory);
	}

	private void LoadRoster()
	{
		foreach (XmlElement item in mySettings.Doc.SelectNodes("/settings/peers/peer")!)
		{
			try
			{
				NetRenderServiceURL val = MakeURL(item.GetAttribute("url"));
				myService.AddPeer(val);
				DataRow dataRow = myPeerData.NewRow();
				dataRow["Host"] = val.get_HostName();
				dataRow["URL"] = ((object)val).ToString();
				dataRow["ServiceState"] = (object)(NetRenderServiceState)0;
				dataRow["URLObj"] = val;
				dataRow["Cookie"] = 0;
				myPeerData.Rows.Add(dataRow);
				dataRow.AcceptChanges();
				UpdatePeerStatus(dataRow);
			}
			catch (Exception ex)
			{
				Log((LogWhat)1041, "Failed to add peer: " + ex.Message);
			}
		}
	}

	private void SaveRoster()
	{
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		XmlElement xmlElement = mySettings.GetElt("/settings/peers");
		if (null == xmlElement)
		{
			xmlElement = mySettings.Doc.CreateElement("peers");
			mySettings.Root.AppendChild(xmlElement);
		}
		else
		{
			xmlElement.RemoveAll();
		}
		foreach (DataRow row in myPeerData.Rows)
		{
			if (row.RowState == DataRowState.Unchanged)
			{
				NetRenderServiceURL val = (NetRenderServiceURL)row["URLObj"];
				XmlElement xmlElement2 = null;
				xmlElement2 = mySettings.Doc.CreateElement("peer");
				xmlElement2.SetAttribute("url", ((object)val).ToString());
				xmlElement.AppendChild(xmlElement2);
			}
		}
	}

	private void LoadFileMappings()
	{
		foreach (XmlElement item in mySettings.Doc.SelectNodes("/settings/mappings/mapping")!)
		{
			try
			{
				string attribute = item.GetAttribute("local");
				string attribute2 = item.GetAttribute("universal");
				DataRow dataRow = myFileMappings.NewRow();
				dataRow["Local"] = attribute;
				dataRow["Universal"] = attribute2;
				myFileMappings.Rows.Add(dataRow);
			}
			catch (Exception ex)
			{
				Log((LogWhat)1041, "Failed to add media mapping: " + ex.Message);
			}
		}
	}

	private void SaveFileMappings()
	{
		XmlElement xmlElement = mySettings.GetElt("/settings/mappings");
		if (null == xmlElement)
		{
			xmlElement = mySettings.Doc.CreateElement("mappings");
			mySettings.Root.AppendChild(xmlElement);
		}
		else
		{
			xmlElement.RemoveAll();
		}
		foreach (DataRow row in myFileMappings.Rows)
		{
			if (row.RowState != DataRowState.Deleted && row.RowState != DataRowState.Detached)
			{
				string value = row["Local", DataRowVersion.Default] as string;
				string value2 = row["Universal", DataRowVersion.Default] as string;
				XmlElement xmlElement2 = null;
				xmlElement2 = mySettings.Doc.CreateElement("mapping");
				xmlElement2.SetAttribute("local", value);
				xmlElement2.SetAttribute("universal", value2);
				xmlElement.AppendChild(xmlElement2);
			}
		}
	}

	private void AutoFillFileMappings(object sender, EventArgs e)
	{
		if (null == myTabControl || null == myFileMappingsPage)
		{
			return;
		}
		ShareCollection shareCollection = null;
		try
		{
			shareCollection = ShareCollection.LocalShares;
		}
		catch (Exception err)
		{
			ShowError(LRZ("FailedToGetLocalShares"), err, string.Empty);
		}
		if (null == shareCollection)
		{
			return;
		}
		if (myTabControl.get_SelectedTab() != myFileMappingsPage)
		{
			myTabControl.set_SelectedTab(myFileMappingsPage);
		}
		foreach (Share item in shareCollection)
		{
			if (item.ShareType == ShareType.Disk)
			{
				try
				{
					string path = item.Path;
					string text = item.ToString();
					VerifyFileMapping(path, text);
					DataRow dataRow = myFileMappings.NewRow();
					dataRow["Local"] = path;
					dataRow["Universal"] = text;
					myFileMappings.Rows.Add(dataRow);
				}
				catch
				{
				}
			}
		}
	}

	private void LoadRecentTempFileDirectories()
	{
		foreach (XmlElement item in mySettings.Doc.SelectNodes("/settings/RecentTempFileDirs/Directory")!)
		{
			string innerText = item.InnerText;
			if (null != innerText && !(string.Empty == innerText))
			{
				if (!Directory.Exists(innerText))
				{
					Log((LogWhat)1041, "Failed to add recent temp file directory: " + innerText);
				}
				else
				{
					myService.AddRecentTempFileDirectory(innerText);
				}
			}
		}
	}

	private void SaveRecentTempFileDirectories()
	{
		string[] array = null;
		try
		{
			array = myService.get_RecentTempFileDirectories();
		}
		catch
		{
			return;
		}
		if (null != array)
		{
			XmlElement xmlElement = mySettings.GetElt("/settings/RecentTempFileDirs");
			if (null == xmlElement)
			{
				xmlElement = mySettings.Doc.CreateElement("RecentTempFileDirs");
				mySettings.Root.AppendChild(xmlElement);
			}
			else
			{
				xmlElement.RemoveAll();
			}
			string[] array2 = array;
			foreach (string innerText in array2)
			{
				XmlElement xmlElement2 = mySettings.Doc.CreateElement("Directory");
				xmlElement2.InnerText = innerText;
				xmlElement.AppendChild(xmlElement2);
			}
		}
	}

	private void ShowTrayIcon()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		try
		{
			if (null != myTrayIcon)
			{
				ComponentContainer = new Container();
				NotifyIcon = new NotifyIcon((IContainer)ComponentContainer);
				NotifyIcon.set_Icon(myTrayIcon);
				InitTrayMenu();
				NotifyIcon.set_ContextMenu(myTrayMenu);
				NotifyIcon.set_Text(myWindowTitleString);
				NotifyIcon.set_Visible(true);
				NotifyIcon.add_DoubleClick((EventHandler)HandleShowWindow);
				IsTrayIconCreated = true;
			}
		}
		catch (Exception ex)
		{
			IsTrayIconCreated = false;
			throw ex;
		}
	}

	private void TimeToRefresh(object sender, EventArgs e)
	{
		if (null == myService)
		{
			return;
		}
		LogMessage[] array = myService.PullLogMessages(myLastJournalMsgID + 1L);
		if (null != array)
		{
			LogMessage[] array2 = array;
			foreach (LogMessage msg in array2)
			{
				HandleLogMessage(msg);
			}
		}
		RemoveStaleJobData();
		if (0 < myProgressLabelDecay)
		{
			myProgressLabelDecay--;
			if (0 == myProgressLabelDecay)
			{
				((Control)myProgressLabel).set_Text(string.Empty);
			}
		}
	}

	private void HandleLogMessage(LogMessage msg)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected I4, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		myLastJournalMsgID = msg.id;
		LogWhat what = msg.what;
		switch (what - 1026)
		{
		case 0:
			HandleLocalServiceStateChanged(((StringLogMessage)msg).text);
			break;
		case 1:
			HandleJobQueued((ArrayLogMessage)msg);
			break;
		case 2:
			UpdateStatDataRow((ArrayLogMessage)msg);
			break;
		case 3:
			HandleJobFinished((ArrayLogMessage)msg);
			break;
		case 4:
			HandleSegmentQueued((ArrayLogMessage)msg);
			break;
		case 5:
			HandleSegmentStarted((ArrayLogMessage)msg);
			break;
		case 6:
			UpdateSegDataRow((ArrayLogMessage)msg);
			break;
		case 7:
			HandleSegmentFinished((ArrayLogMessage)msg);
			break;
		case 8:
			HandleStitchStarted((ArrayLogMessage)msg);
			break;
		case 9:
			UpdateStatDataRow((ArrayLogMessage)msg);
			break;
		case 10:
			HandleStitchFinished((ArrayLogMessage)msg);
			break;
		case 11:
			UpdateErrorDataRow((ArrayLogMessage)msg);
			break;
		}
		Log(msg);
	}

	private void HandleLocalServiceStateChanged(string status)
	{
		((Control)myLocalServiceStateLabel).set_Text(string.Format(LRZ("LocalServiceStateLabel"), status));
	}

	private DataRow GetJobStats(DataRow job)
	{
		DataRow[] childRows = job.GetChildRows(myJobStatsRelation);
		if (0 < childRows.Length)
		{
			return childRows[0];
		}
		return null;
	}

	private string MakeJobIDString(DataRow job)
	{
		return string.Format("{0}:{1}/{2}", job["Owner"], job["Port"], job["JobID"]);
	}

	private DataRow UpdateJobDataRow(ArrayLogMessage msg)
	{
		DataTable jobData = JobData;
		DataRow dataRow = null;
		try
		{
			jobData.BeginLoadData();
			dataRow = jobData.LoadDataRow(msg.data, fAcceptChanges: true);
			jobData.EndLoadData();
		}
		catch
		{
			Log((LogWhat)1041, string.Format(LRZ("LoadJobDataError"), ((object)msg).ToString()));
		}
		UpdateSummaryDataRow(dataRow, null);
		return dataRow;
	}

	private DataRow UpdateStatDataRow(ArrayLogMessage msg)
	{
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		object[] data = msg.data;
		DateTime dateTime = (DateTime)data[4];
		string text = dateTime.ToString("g");
		TimeSpan timeSpan = (TimeSpan)data[5];
		DateTime dateTime2 = dateTime + timeSpan;
		string text2 = ((0 != timeSpan.Days) ? $"{timeSpan.Days}.{timeSpan.Hours:D2}:{timeSpan.Minutes:D2}:{timeSpan.Seconds:D2}" : $"{timeSpan.Hours:D2}:{timeSpan.Minutes:D2}:{timeSpan.Seconds:D2}");
		string text3 = StatsToCompletedString((RenderStatus)data[3], (int)data[6], (int)data[7], (int)data[8]);
		object[] values = new object[8]
		{
			data[0],
			data[1],
			data[2],
			data[3],
			text,
			text2,
			dateTime2,
			text3
		};
		DataTable statData = StatData;
		DataRow dataRow = null;
		try
		{
			statData.BeginLoadData();
			dataRow = statData.LoadDataRow(values, fAcceptChanges: true);
			statData.EndLoadData();
		}
		catch
		{
			Log((LogWhat)1041, string.Format(LRZ("LoadStatDataError"), ((object)msg).ToString()));
		}
		UpdateSummaryDataRow(null, dataRow);
		return dataRow;
	}

	private string StatsToCompletedString(RenderStatus renderStatus, int percentComplete, int completedSegs, int totalSegs)
	{
		if (totalSegs <= 0)
		{
			return $"{percentComplete}%";
		}
		if (0 != percentComplete)
		{
			return $"{percentComplete}%";
		}
		return $"{completedSegs} of {totalSegs} seg.";
	}

	private DataRow UpdateSegDataRow(ArrayLogMessage msg)
	{
		DataRow result = null;
		object[] data = msg.data;
		DataTable segmentData = SegmentData;
		try
		{
			segmentData.BeginLoadData();
			result = segmentData.LoadDataRow(data, fAcceptChanges: true);
			segmentData.EndLoadData();
		}
		catch
		{
			Log((LogWhat)1041, string.Format(LRZ("LoadSegmentDataError"), ((object)msg).ToString()));
		}
		return result;
	}

	private DataRow UpdateSummaryDataRow(DataRow job, DataRow stat)
	{
		if (stat == null && null == job)
		{
			return null;
		}
		if (null == stat)
		{
			stat = GetJobStats(job);
		}
		if (null == job)
		{
			job = stat.GetParentRow(myJobStatsRelation);
		}
		if (stat == null || null == job)
		{
			return null;
		}
		object[] values = new object[8]
		{
			job["Owner"],
			job["Port"],
			job["JobID"],
			Path.GetFileName((string)job["OutputFile"]),
			Path.GetFileName((string)job["Project"]),
			stat["RenderStatus"],
			stat["Completed"],
			stat["RenderDuration"]
		};
		DataTable summaryData = SummaryData;
		DataRow result = null;
		try
		{
			summaryData.BeginLoadData();
			result = summaryData.LoadDataRow(values, fAcceptChanges: true);
			summaryData.EndLoadData();
		}
		catch (Exception ex)
		{
			Log((LogWhat)1041, string.Format(LRZ("LoadSummaryDataError"), ex.ToString()));
		}
		return result;
	}

	private DataRow UpdateErrorDataRow(ArrayLogMessage msg)
	{
		DataTable errorData = ErrorData;
		DataRow result = null;
		try
		{
			errorData.BeginLoadData();
			result = errorData.LoadDataRow(msg.data, fAcceptChanges: true);
			errorData.EndLoadData();
		}
		catch
		{
			Log((LogWhat)1041, string.Format(LRZ("LoadJobErrorError"), ((object)msg).ToString()));
		}
		return result;
	}

	private void RemoveStaleJobData()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected I4, but got Unknown
		ArrayList arrayList = new ArrayList();
		DateTime now = DateTime.Now;
		foreach (DataRow row in StatData.Rows)
		{
			RenderStatus val = (RenderStatus)row["RenderStatus"];
			RenderStatus val2 = val;
			switch (val2 - 4)
			{
			case 0:
			case 1:
			case 2:
			case 3:
			{
				DateTime dateTime = (DateTime)row["RenderEndTime"];
				TimeSpan timeSpan = now - dateTime;
				if (timeSpan > AgeOfStaleJobs)
				{
					arrayList.Add(row.GetParentRow(myJobStatsRelation));
				}
				break;
			}
			}
		}
		foreach (DataRow item in arrayList)
		{
			Log((LogWhat)1042, "removing stale job data: " + (string)item["OutputFile"]);
			JobData.Rows.Remove(item);
		}
		if (0 < arrayList.Count)
		{
			StatData.AcceptChanges();
			SummaryData.AcceptChanges();
			SegmentData.AcceptChanges();
			ErrorData.AcceptChanges();
		}
	}

	public void HandleAgeOfStaleJobsChanged(object sender, EventArgs e)
	{
		AgeToken ageToken = (AgeToken)myAgeOfStaleJobsControl.get_SelectedItem();
		if (null != ageToken)
		{
			AgeOfStaleJobs = ageToken.Span;
		}
	}

	private void InitAgeOfStaleJobs()
	{
		try
		{
			string setting = GetSetting("AgeOfStaleJobs");
			if (string.Empty != setting)
			{
				AgeOfStaleJobs = new TimeSpan(long.Parse(setting));
			}
		}
		catch
		{
		}
	}

	private void SaveAgeOfStaleJobs()
	{
		SaveSetting("AgeOfStaleJobs", AgeOfStaleJobs.Ticks.ToString());
	}

	private void InitAgeOfStaleJobsControlItem()
	{
		int num = 0;
		foreach (AgeToken item in (ArrayList)(object)myAgeOfStaleJobsControl.get_Items())
		{
			if (!(item.Span == AgeOfStaleJobs))
			{
				num++;
				continue;
			}
			myAgeOfStaleJobsControl.set_SelectedIndex(num);
			break;
		}
	}

	private void HandleJobQueued(ArrayLogMessage msg)
	{
		UpdateJobDataRow(msg);
	}

	private void HandleJobFinished(ArrayLogMessage msg)
	{
		UpdateStatDataRow(msg);
	}

	private void HandleSegmentQueued(ArrayLogMessage msg)
	{
		UpdateSegDataRow(msg);
	}

	private void HandleSegmentStarted(ArrayLogMessage msg)
	{
		UpdateSegDataRow(msg);
	}

	private void HandleSegmentFinished(ArrayLogMessage msg)
	{
		UpdateSegDataRow(msg);
	}

	private void HandleStitchStarted(ArrayLogMessage msg)
	{
		UpdateStatDataRow(msg);
	}

	private void HandleStitchFinished(ArrayLogMessage msg)
	{
		UpdateStatDataRow(msg);
	}

	private void HandleChoosePeerDataBinding(object sender, EventArgs e)
	{
		switch (((ListControl)myPeerDataChooser).get_SelectedIndex())
		{
		case 0:
			InitBasicPeerDataGridStyle();
			break;
		case 1:
			InitAdvancedPeerDataGridStyle();
			break;
		}
	}

	private void HandleChooseJobDataBinding(object sender, EventArgs e)
	{
		switch (((ListControl)myJobDataChooser).get_SelectedIndex())
		{
		default:
			myJobDataGrid.set_CaptionText("Render Job Summary");
			myJobDataGrid.SetDataBinding((object)myDataSet, "Summary");
			break;
		case 1:
			myJobDataGrid.set_CaptionText("Render Job Details");
			myJobDataGrid.SetDataBinding((object)myDataSet, "Jobs");
			break;
		}
	}

	private void HandleJobDataCurrentCellChanged(object sender, EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		DataGridCell currentCell = myJobDataGrid.get_CurrentCell();
		myJobDataGrid.Select(((DataGridCell)(ref currentCell)).get_RowNumber());
	}

	private void HandleCopyData(ref Message msg)
	{
	}

	public void HandleShowWindow(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between I4 and Unknown
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		if (1 == (int)((Form)this).get_WindowState())
		{
			((Form)this).set_WindowState(myWindowStateBeforeMinimize);
		}
		else
		{
			((Control)this).Show();
		}
		((Form)this).Activate();
	}

	public void HandleExitApp(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	public void HandleHide(object sender, EventArgs e)
	{
		((Control)this).set_Visible(false);
	}

	private DataRow GetSelectedJobRow()
	{
		if (null == myJobDataGrid)
		{
			return null;
		}
		int currentRowIndex = myJobDataGrid.get_CurrentRowIndex();
		if (0 > currentRowIndex)
		{
			return null;
		}
		if (JobData.Rows.Count - 1 < currentRowIndex)
		{
			return null;
		}
		return JobData.Rows[currentRowIndex];
	}

	private void HandleCancelJob(object sender, EventArgs e)
	{
		DataRow selectedJobRow = GetSelectedJobRow();
		if (null != selectedJobRow)
		{
			myService.CancelJob(MakeJobIDString(selectedJobRow));
		}
	}

	private void HandleUpdateAllPeerDataStatus(object sender, EventArgs e)
	{
		foreach (DataRow row in myPeerData.Rows)
		{
			UpdatePeerStatus(row);
		}
	}

	private void HandleUpdateSelectedPeerDataStatus(object sender, EventArgs e)
	{
		try
		{
			DataRow selectedPeerData = GetSelectedPeerData();
			UpdatePeerStatus(selectedPeerData);
		}
		catch
		{
		}
	}

	private void HandleDeleteAllPeers(object sender, EventArgs e)
	{
		while (0 < myPeerData.Rows.Count)
		{
			myPeerData.Rows.RemoveAt(0);
		}
	}

	private void HandleDeleteSelectedPeer(object sender, EventArgs e)
	{
		try
		{
			int currentRowIndex = myPeerDataGrid.get_CurrentRowIndex();
			DataRow row = myPeerData.Rows[currentRowIndex];
			myPeerData.Rows.Remove(row);
		}
		catch
		{
		}
	}

	public void Log(LogMessage msg)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected I4, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		bool flag2 = false;
		LogWhat what = msg.what;
		switch (what - 1038)
		{
		case 1:
			flag2 = true;
			flag = true;
			break;
		case 0:
		case 2:
		case 3:
			flag2 = true;
			break;
		default:
			if (myVerboseLogging)
			{
				flag2 = true;
			}
			break;
		case 4:
			break;
		}
		if (flag && null != myProgressLabel)
		{
			((Control)myProgressLabel).set_Text(((StringLogMessage)msg).text);
			myProgressLabelDecay = NumberOfRefreshesBeforeClearingProgressLabel;
		}
		if (flag2)
		{
			AddLogMsg(msg);
		}
	}

	public void Log(LogWhat what, string text)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		Log((LogMessage)new StringLogMessage(what, text));
	}

	private void AddLogMsg(LogMessage msg)
	{
		if (myNextLogMsgIndex >= theMaxLogMsgCount)
		{
			myNextLogMsgIndex = 0;
			for (int i = thePruneLogMsgCount - 1; i < theMaxLogMsgCount; i++)
			{
				myLogMsgs[myNextLogMsgIndex] = myLogMsgs[i];
				myNextLogMsgIndex++;
			}
			RefillLogTextBox();
		}
		string text = $"{((object)msg).ToString()}\r\n";
		myLogMsgs[myNextLogMsgIndex++] = text;
		if (null != myLogTextBox)
		{
			((TextBoxBase)myLogTextBox).AppendText(text);
		}
	}

	private void RefillLogTextBox()
	{
		if (null != myLogTextBox)
		{
			((TextBoxBase)myLogTextBox).Clear();
			for (int i = 0; i < myNextLogMsgIndex; i++)
			{
				((TextBoxBase)myLogTextBox).AppendText(myLogMsgs[i]);
			}
		}
	}

	public void HandlePeerDataRowChanged(object sender, DataRowChangeEventArgs e)
	{
		if (IsHandlingPeerDataChange || null == e)
		{
			return;
		}
		DataRow row = e.Row;
		if (null == row)
		{
			return;
		}
		DataRowAction action = e.Action;
		if (action != DataRowAction.Add)
		{
			return;
		}
		try
		{
			NetRenderServiceURL val = ((0 != ((ListControl)myPeerDataChooser).get_SelectedIndex()) ? MakeURL(row["URL"] as string) : MakeURLFromHostName(row["Host"] as string));
			if (((object)val).Equals((object?)myURL))
			{
				throw new ApplicationException(LRZ("AddLocalServiceAsPeerError"));
			}
			myService.AddPeer(val);
			row["Cookie"] = 0;
			UpdatePeerDataRow(row, val);
		}
		catch (Exception err)
		{
			string header = LRZ("AddPeerErrorHeader");
			string empty = string.Empty;
			ShowError(header, err, empty);
			row.RejectChanges();
		}
	}

	public void HandlePeerDataColumnChanged(object sender, DataColumnChangeEventArgs e)
	{
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		if (IsHandlingPeerDataChange || null == e)
		{
			return;
		}
		DataRow row = e.Row;
		if (null == row)
		{
			return;
		}
		switch (row.RowState)
		{
		case DataRowState.Unchanged:
		case DataRowState.Modified:
			try
			{
				NetRenderServiceURL val;
				NetRenderServiceURL val2;
				switch (e.Column!.ColumnName)
				{
				case "URL":
					val = MakeURL(row["URL"] as string);
					goto IL_00d6;
				case "Host":
					val = MakeURLFromHostName(row["Host"] as string);
					goto IL_00d6;
				case "ServiceState":
					row.AcceptChanges();
					break;
				default:
					{
						Log((LogWhat)1042, "unhandled column change: " + e.Column!.ColumnName);
						break;
					}
					IL_00d6:
					if (((object)val).Equals((object?)myURL))
					{
						throw new ApplicationException(LRZ("AddLocalServiceAsPeerError"));
					}
					val2 = (NetRenderServiceURL)row["URLObj"];
					myService.RemovePeer(val2);
					myService.AddPeer(val);
					UpdatePeerDataRow(row, val);
					break;
				}
				break;
			}
			catch (Exception err)
			{
				string header = LRZ("ChangePeerErrorHeader");
				string footer = LRZ("ChangePeerErrorFooter");
				ShowError(header, err, footer);
				row.RejectChanges();
				break;
			}
		}
	}

	public void HandlePeerDataRowDeleted(object sender, DataRowChangeEventArgs e)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		DataRowAction action = e.Action;
		if (action != DataRowAction.Delete)
		{
			return;
		}
		try
		{
			NetRenderServiceURL val = (NetRenderServiceURL)e.Row["URLObj", DataRowVersion.Original];
			myService.RemovePeer(val);
			e.Row.AcceptChanges();
		}
		catch (Exception err)
		{
			string header = LRZ("RemovePeerErrorHeader");
			string empty = string.Empty;
			ShowError(header, err, empty);
			e.Row.RejectChanges();
		}
	}

	private DataRow GetSelectedPeerData()
	{
		int currentRowIndex = myPeerDataGrid.get_CurrentRowIndex();
		if (0 > currentRowIndex)
		{
			return null;
		}
		if (myPeerData.Rows.Count - 1 < currentRowIndex)
		{
			return null;
		}
		DataRow dataRow = myPeerData.Rows[currentRowIndex];
		return dataRow.RowState switch
		{
			DataRowState.Unchanged => dataRow, 
			_ => null, 
		};
	}

	private void UpdatePeerDataRow(DataRow peerRow, NetRenderServiceURL peerURL)
	{
		IsHandlingPeerDataChange = true;
		try
		{
			peerRow["Host"] = peerURL.get_HostName();
			peerRow["URL"] = ((object)peerURL).ToString();
			peerRow["URLObj"] = peerURL;
			peerRow.AcceptChanges();
			UpdatePeerStatus(peerRow);
		}
		finally
		{
			IsHandlingPeerDataChange = false;
		}
	}

	public void UpdatePeerStatus(DataRow peerRow)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		if (null == peerRow || peerRow.HasErrors)
		{
			return;
		}
		switch (peerRow.RowState)
		{
		case DataRowState.Unchanged:
		{
			NetRenderServiceURL peerURL = (NetRenderServiceURL)peerRow["URLObj"];
			IsHandlingPeerDataChange = true;
			try
			{
				UpdatePeerStatus(peerRow, peerURL);
				break;
			}
			finally
			{
				IsHandlingPeerDataChange = false;
			}
		}
		}
	}

	public void UpdatePeerStatus(DataRow peerRow, NetRenderServiceURL peerURL)
	{
		int num = (int)peerRow["Cookie"];
		num++;
		peerRow["Cookie"] = num;
		peerRow["ServiceState"] = "connecting...";
		peerRow.AcceptChanges();
		AsyncUpdatePeerStatus asyncUpdatePeerStatus = GetPeerStatus;
		AsyncCallback callback = StatusRequestComplete;
		asyncUpdatePeerStatus.BeginInvoke(peerURL, callback, new PeerStatusAsyncState(peerRow, num));
	}

	private NetRenderServiceState GetPeerStatus(NetRenderServiceURL peerURL)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			NetRenderService service = peerURL.GetService();
			return service.get_CurrentState();
		}
		catch
		{
			return (NetRenderServiceState)1;
		}
	}

	[OneWay]
	private void StatusRequestComplete(IAsyncResult result)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		AsyncUpdatePeerStatus asyncUpdatePeerStatus = (AsyncUpdatePeerStatus)((AsyncResult)result).get_AsyncDelegate();
		PeerStatusAsyncState peerStatusAsyncState = (PeerStatusAsyncState)result.AsyncState;
		NetRenderServiceState val = asyncUpdatePeerStatus.EndInvoke(result);
		((Control)this).Invoke((Delegate)new PeerStatusUpdateHandler(PeerStatusReceived), new object[2] { peerStatusAsyncState, val });
	}

	private void PeerStatusReceived(PeerStatusAsyncState asyncState, NetRenderServiceState status)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		switch (asyncState.Row.RowState)
		{
		case DataRowState.Added:
		case DataRowState.Modified:
			throw new ApplicationException(LRZ("DataManagementError"));
		case DataRowState.Detached:
		case DataRowState.Deleted:
			return;
		}
		int num = (int)asyncState.Row["Cookie"];
		if (asyncState.Cookie == num)
		{
			asyncState.Row["ServiceState"] = ((object)status).ToString();
		}
	}

	public void HandleFileMappingRowChanging(object sender, DataRowChangeEventArgs e)
	{
		DataRow row = e.Row;
		try
		{
			switch (e.Action)
			{
			case DataRowAction.Add:
			{
				string localPath = row["Local", DataRowVersion.Proposed] as string;
				string universalPath = row["Universal", DataRowVersion.Proposed] as string;
				VerifyFileMapping(localPath, universalPath);
				row.ClearErrors();
				break;
			}
			case DataRowAction.Change:
			{
				if (!row.HasErrors && row["Local", DataRowVersion.Current] is string text)
				{
					myService.RemoveMediaMapping(text);
				}
				string localPath = row["Local", DataRowVersion.Proposed] as string;
				string universalPath = row["Universal", DataRowVersion.Proposed] as string;
				VerifyFileMapping(localPath, universalPath);
				row.ClearErrors();
				break;
			}
			}
		}
		catch (Exception ex)
		{
			row.RowError = ex.Message;
		}
	}

	public void HandleFileMappingRowChanged(object sender, DataRowChangeEventArgs e)
	{
		DataRow row = e.Row;
		if (row.HasErrors)
		{
			return;
		}
		try
		{
			switch (e.Action)
			{
			case DataRowAction.Add:
			{
				string text = row["Local", DataRowVersion.Current] as string;
				string text2 = row["Universal", DataRowVersion.Current] as string;
				myService.AddMediaMapping(text, text2);
				row.AcceptChanges();
				break;
			}
			case DataRowAction.Change:
			{
				string text = row["Local", DataRowVersion.Current] as string;
				string text2 = row["Universal", DataRowVersion.Current] as string;
				myService.AddMediaMapping(text, text2);
				row.AcceptChanges();
				break;
			}
			}
		}
		catch (Exception err)
		{
			string header = LRZ("AddMappingErrorHeader");
			string empty = string.Empty;
			ShowError(header, err, empty);
			row.RejectChanges();
		}
	}

	public void HandleFileMappingRowDeleted(object sender, DataRowChangeEventArgs e)
	{
		DataRow row = e.Row;
		DataRowAction action = e.Action;
		if (action != DataRowAction.Delete)
		{
			return;
		}
		try
		{
			if (!row.HasErrors)
			{
				string text = (string)row["Local", DataRowVersion.Original];
				myService.RemoveMediaMapping(text);
			}
			if (row.RowState != DataRowState.Detached)
			{
				row.AcceptChanges();
			}
		}
		catch (Exception err)
		{
			string header = LRZ("RemoveMappingErrorHeader");
			string empty = string.Empty;
			ShowError(header, err, empty);
			row.RejectChanges();
		}
	}

	private void VerifyFileMapping(string localPath, string universalPath)
	{
		if (localPath == null || string.Empty == localPath)
		{
			throw new ApplicationException(LRZ("NullLocalPathError"));
		}
		if (universalPath == null || string.Empty == universalPath)
		{
			throw new ApplicationException(LRZ("NullUniversalPathError"));
		}
		if (!Directory.Exists(localPath))
		{
			throw new ApplicationException(LRZ("InvalidLocalPathError"));
		}
		if (!Directory.Exists(universalPath))
		{
			throw new ApplicationException(LRZ("InvalidUniversalPathError"));
		}
		if (myService.HasMediaMapping(localPath))
		{
			throw new ApplicationException(string.Format(LRZ("MappingExistsError"), localPath));
		}
	}

	private void ShowAboutBox(object sender, EventArgs e)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		string text = LRZ("AboutBoxCaption");
		string text2 = string.Format(LRZ("AboutContents"), Assembly.GetExecutingAssembly().GetName().Version);
		myAboutBox = new Form();
		myAboutBox.set_ShowInTaskbar(false);
		myAboutBox.set_FormBorderStyle((FormBorderStyle)3);
		myAboutBox.set_MaximizeBox(false);
		myAboutBox.set_MinimizeBox(false);
		myAboutBox.set_StartPosition((FormStartPosition)4);
		((Control)myAboutBox).set_Width(320);
		((Control)myAboutBox).set_Height(220);
		((Control)myAboutBox).set_Text(text);
		Rectangle clientRectangle = ((Control)myAboutBox).get_ClientRectangle();
		Rectangle bounds = Rectangle.Inflate(clientRectangle, -10, -15);
		bounds.Offset(0, -10);
		Label val = new Label();
		((Control)val).set_Bounds(bounds);
		((Control)val).set_Text(text2);
		((Control)myAboutBox).get_Controls().Add((Control)(object)val);
		Button val2 = new Button();
		((Control)val2).set_Text("OK");
		((Control)val2).SetBounds(clientRectangle.Right - 100, clientRectangle.Bottom - 25, 80, 22);
		((Control)val2).add_Click((EventHandler)CloseAboutBox);
		((Control)myAboutBox).get_Controls().Add((Control)(object)val2);
		myAboutBox.set_AcceptButton((IButtonControl)(object)val2);
		myAboutBox.ShowDialog((IWin32Window)(object)this);
	}

	private void ShowHelp(object sender, EventArgs e)
	{
		if (myHelpProcess == null || myHelpProcess.HasExited)
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.FileName = HelpFile;
			processStartInfo.UseShellExecute = true;
			myHelpProcess = Process.Start(processStartInfo);
			return;
		}
		IntPtr mainWindowHandle = myHelpProcess.MainWindowHandle;
		if (IntPtr.Zero != mainWindowHandle)
		{
			MS.OpenIcon(mainWindowHandle);
			MS.SetForegroundWindow(mainWindowHandle);
		}
	}

	private void CloseAboutBox(object sender, EventArgs e)
	{
		myAboutBox.Close();
	}

	private void InitUserSpecifiedSerialCode()
	{
		try
		{
			myUserSpecifiedSerialCode = GetSetting("UserSpecifiedSerialCode");
		}
		catch
		{
		}
	}

	private void SaveUserSpecifiedSerialCode()
	{
		if (null != myUserSpecifiedSerialCode)
		{
			SaveSetting("UserSpecifiedSerialCode", myUserSpecifiedSerialCode);
		}
	}

	private void EnterSerialNumber(object sender, EventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected O, but got Unknown
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		string text = LRZ("SerialEntryCaption");
		mySerialNumberEntryForm = new Form();
		mySerialNumberEntryForm.set_ShowInTaskbar(false);
		mySerialNumberEntryForm.set_FormBorderStyle((FormBorderStyle)3);
		mySerialNumberEntryForm.set_MaximizeBox(false);
		mySerialNumberEntryForm.set_MinimizeBox(false);
		mySerialNumberEntryForm.set_StartPosition((FormStartPosition)4);
		((Control)mySerialNumberEntryForm).set_Width(360);
		((Control)mySerialNumberEntryForm).set_Height(220);
		((Control)mySerialNumberEntryForm).set_Text(text);
		Rectangle clientRectangle = ((Control)mySerialNumberEntryForm).get_ClientRectangle();
		Rectangle bounds = Rectangle.Inflate(clientRectangle, -10, -40);
		bounds.Offset(0, -26);
		Label val = new Label();
		((Control)val).set_Bounds(bounds);
		((Control)val).set_Text(LRZ("SerialEntryInfo"));
		((Control)mySerialNumberEntryForm).get_Controls().Add((Control)(object)val);
		Label val2 = new Label();
		((Control)val2).set_Text(LRZ("SerialTextBoxLabel"));
		((Control)val2).set_AutoSize(true);
		((Control)val2).set_Location(new Point(10, ((Control)val).get_Bottom() + 10));
		((Control)mySerialNumberEntryForm).get_Controls().Add((Control)(object)val2);
		mySerialTextBox = new TextBox();
		if (null != myUserSpecifiedSerialCode)
		{
			((Control)mySerialTextBox).set_Text(myUserSpecifiedSerialCode);
		}
		((Control)mySerialTextBox).SetBounds(((Control)val2).get_Right() + 4, ((Control)val).get_Bottom() + 8, clientRectangle.Width - ((Control)val2).get_Right() - 18, ((TextBoxBase)mySerialTextBox).get_PreferredHeight());
		((Control)mySerialNumberEntryForm).get_Controls().Add((Control)(object)mySerialTextBox);
		Button val3 = new Button();
		((Control)val3).set_Text("Cancel");
		((Control)val3).SetBounds(clientRectangle.Right - 190, clientRectangle.Bottom - 25, 80, 22);
		((Control)mySerialNumberEntryForm).get_Controls().Add((Control)(object)val3);
		mySerialNumberEntryForm.set_CancelButton((IButtonControl)(object)val3);
		Button val4 = new Button();
		((Control)val4).set_Text("OK");
		((Control)val4).SetBounds(clientRectangle.Right - 100, clientRectangle.Bottom - 25, 80, 22);
		((Control)val4).add_Click((EventHandler)AcceptSerialEntry);
		((Control)mySerialNumberEntryForm).get_Controls().Add((Control)(object)val4);
		mySerialNumberEntryForm.set_AcceptButton((IButtonControl)(object)val4);
		mySerialNumberEntryForm.ShowDialog((IWin32Window)(object)this);
	}

	private void AcceptSerialEntry(object sender, EventArgs e)
	{
		myUserSpecifiedSerialCode = ((Control)mySerialTextBox).get_Text();
		try
		{
			myService.set_UserSpecifiedSerialCode(myUserSpecifiedSerialCode);
		}
		catch
		{
		}
		mySerialNumberEntryForm.Close();
	}
}
