using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Navigation;
using System.Windows.Threading;
using Microsoft.VisualBasic;
using Microsoft.Win32;
using Microsoft.Win32.TaskScheduler;
using com.poweriwb.PowerDesk.VirusTotalNET;
using mshtml;

namespace com.poweriwb.PowerDesk;

public class PowerDeskApp2014 : Window, IComponentConnector, IStyleConnector
{
	public struct Attribute2
	{
		public byte AttributeID;

		public ushort Flags;

		public byte Value;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public byte[] VendorData;
	}

	public struct UpdateSiteInfo
	{
		public bool isUse;

		public string siteUri;

		public string updaterApp;

		public string icon_resource;

		public string run_pgm;

		public string build_path;

		public UpdateSiteInfo(bool p, string p_2, string p_3, string p_4, string p_5, string p_6)
		{
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			isUse = p;
			siteUri = p_2;
			updaterApp = p_3;
			icon_resource = p_4;
			run_pgm = p_5;
			build_path = p_6;
			string text = build_path.Substring(build_path.Length - 1);
			if (text == Utils.SEPA)
			{
				string text2 = build_path + "의 마지막 값은 " + Utils.SEPA + "문자로는 안됩니다.";
				AutoClosingMessageBox.Show1(text2, "PowerHealthChecker", 3100, 0);
			}
		}

		public override string ToString()
		{
			return siteUri;
		}
	}

	[ComVisible(true)]
	public class MyScript
	{
		public void CallServerSideCode()
		{
			HtmlDocument document = ((PowerDeskApp2014)(object)Application.get_Current().get_MainWindow()).webF[webF_idx].get_Document();
			((object)document).ToString();
		}
	}

	public struct RECT
	{
		public int X;

		public int Y;

		public int Right;

		public int Bottom;

		public int Width => Right - X;

		public int Height => Bottom - Y;
	}

	public const int WM_USER = 1024;

	public const string POWERHEALTHCHECKER = "PowerHealthChecker";

	private const double CHUN = 1000.0;

	public const int VMM33 = 60;

	private const string MP_SCHEDULED_SCAN = "MP Scheduled Scan";

	private const string MPIDLETASK = "MpIdleTask";

	public const string PROGRAMX86B = "[ProgramX86]";

	public const string PROGRAMB = "[Program]";

	public const string APIKEY = "f56ab1f18e2759f47d14ba8bd08b48646658f7a4335909198a5f1d6e5356beb2";

	private const int nOneMinuAfterExecuteMaxCount = 60;

	public const string YMD = "yyyy-MM-dd";

	private string memStrAutoAllowPassword = "";

	private List<string> lst_msc = new List<string>();

	private List<string> lst_cpl = new List<string>();

	private List<string> lst_shell = new List<string>();

	private List<string> lst_cpl_msc = new List<string>();

	private static bool bSlideShowHook = false;

	internal IntPtr mainWindowPtr = IntPtr.Zero;

	private int nFirstSessionCount = 0;

	private Timer tmrToVolumeExec = null;

	private string strMsgInterface = null;

	private Process procRundll;

	private long t1;

	private long t2;

	private double t3;

	private MenuItem prevCPLmenu = null;

	private string m_SYS32 = null;

	private static Regex regexp_atnum = new Regex("at[0-9]+");

	public static bool staticIsLoaded = false;

	public static RegistryKey static_regKey3;

	public static Regex regexp_file = new Regex("(?:\\\"?)([a-zA-Z]{1}:[^\\\"]{1,}\\.[^ ]{1,})(?:\\\"?)", RegexOptions.IgnoreCase);

	public static Regex regexp_hash = new Regex("[A-Fa-f0-9]{64}");

	private bool bInitURLProtocol = false;

	private bool bInitAppOutBlock = false;

	private static List<ApprovalList> itmListViewApproval = new List<ApprovalList>();

	private static List<ApprovalList> itmListViewApproval_tmp = new List<ApprovalList>();

	private static List<URLProtocolList> itmListURLProtocol = new List<URLProtocolList>();

	private static List<URLProtocolList> itmListURLProtocol_tmp = new List<URLProtocolList>();

	private static List<AppOutBlockList> itmListAppOutBlock = new List<AppOutBlockList>();

	private static List<AppOutBlockList> itmListAppOutBlock_tmp = new List<AppOutBlockList>();

	private IntPtr m_HWND = IntPtr.Zero;

	private string strErrFilePath = "";

	public static PowerDeskApp2014 Instance = null;

	public WebBrowser[] webF = (WebBrowser[])(object)new WebBrowser[100];

	private static string EXECMDETC = ".exe |.cmd |.scr |.sct |.bat |.cmd |.pif |.vbs |.inf |.msi |.vbe |.js |.jse |.wsf |.wsh |.msp |.msu |.dll |.ocx |.json";

	private Dictionary<int, string> ApplyList = new Dictionary<int, string>();

	private Dictionary<int, Uri> Param1List = new Dictionary<int, Uri>();

	private Dictionary<int, string> Param2List = new Dictionary<int, string>();

	private Dictionary<int, string> Param3List = new Dictionary<int, string>();

	private Dictionary<int, string> DeployFilesList = new Dictionary<int, string>();

	private Dictionary<string, int> InnerDBStrCheckSum = new Dictionary<string, int>();

	private Dictionary<string, string> DictNewedModifedSHA = null;

	private Dictionary<string, string> dictApprovalList = new Dictionary<string, string>();

	private Dictionary<string, string> dictURLPtotocolList = new Dictionary<string, string>();

	private Dictionary<string, string> dictAppOutBlockList = new Dictionary<string, string>();

	private int idxFiles;

	private Dictionary<string, string> dictListOld = new Dictionary<string, string>();

	private Dictionary<string, string> dictListNew = new Dictionary<string, string>();

	private bool bHealthChecked = false;

	private string logPath;

	private string logFile;

	private string checkFile;

	private string logAnalysis;

	private bool completedHealthCheck = false;

	private string nowYYYYMMDD;

	private static string nowMMDD;

	private bool bTodayChecked;

	private List<string> ListBeforeModifiedSHA;

	private static string[] arr_exe_cmd_etc = null;

	public static bool IsNotCheckedConficence = false;

	private string prevSelTxt = "";

	private bool m_isErrorOccored = false;

	private KeyValuePair<string, string>[] arrDictList;

	private bool isCancelAnalysis;

	private DateTime dateDeep;

	private DateTime dateLatest;

	private DateTime dateDeepAnalysis365;

	private DateTime dateDeepAnalysis30;

	private bool isOldFlag;

	private bool isMutex = false;

	private bool deepCheckNeeded;

	private static SmtpClient gmailClient = null;

	private string strRndPassword = "";

	private string[] receives = new string[1];

	private string[] files = new string[1];

	private bool bUseAsynch = true;

	private DispatcherTimer AutoAllowTimer = null;

	private RECT outRECT = default(RECT);

	private bool bTimerKill;

	private int forceKillCnt = 0;

	private bool bInternetConnected;

	private string strWEBresult;

	private string serviceMsg = "";

	private static string m_strWindowsFolder = null;

	private int cntChildSample;

	private long cntParentSample = 0L;

	private long CntParentAbout = 0L;

	private bool bCancelHealthCheck;

	private bool dayFirst;

	private string processAccessErrorFileName;

	private int processAccessErrorID;

	private int cntOfApproval;

	private bool bFirstItemListViewApprovalCntZero;

	private FormOnWorking frmOnWorking = null;

	public static string SEPA;

	private string strLatestTabItemName;

	private string REGSVR32 = " regsvr32.exe ";

	private int sleepMilisec = 1;

	private static int webF_idx;

	private string[] pathes = null;

	private static string[] arrBadTaskList = null;

	private string[] arrBadServiceList = null;

	private RoutedEventHandler mnu_i_Click;

	private bool btnVolumeStoryboard_started = false;

	private bool btnVolumeStoryboard_stop = false;

	private static Timer tmrOneMinExec = null;

	private static int nOneMinuAfterExecuteInvokeCount = 0;

	private int DurDur_vol;

	private long DurDur_dur1;

	private long DurDur_dur2;

	private long DurDur_dur_chk_100;

	private double DurDur_dur_chk_delta;

	private double DurDur_delta_time_unit_volume;

	private int DurDur_vol_to;

	internal Grid LayoutRoot;

	internal TextBlock tBar;

	internal TextBox textBox1;

	internal ProgressBar progressBar1;

	internal MenuItem mnuAgreeCostFunctionUse;

	internal MenuItem mnuTest;

	internal MenuItem mnuUseHashCalc;

	internal MenuItem mnuUAC_chk;

	internal MenuItem mnuTimeSynch_chk;

	internal MenuItem mnuCheckUpdate;

	internal MenuItem mnuExit;

	internal MenuItem mnuVaccine;

	internal MenuItem mnuVacc0;

	internal MenuItem mnuVaccALL;

	internal MenuItem mnuVaccALLUInew;

	internal MenuItem mnuVacc30;

	internal MenuItem mnuVacc31;

	internal MenuItem mnuVacc32;

	internal MenuItem mnuVacc33;

	internal MenuItem mnuVacc1;

	internal MenuItem mnuVacc2;

	internal MenuItem mnuVacc3;

	internal MenuItem mnuVacc4;

	internal MenuItem mnuVacc5;

	internal MenuItem mnuVacc6;

	internal MenuItem mnuVacc7;

	internal MenuItem mnuVacc8;

	internal MenuItem mnuVacc9;

	internal MenuItem mnuVacc59;

	internal MenuItem mnuVacc10;

	internal MenuItem mnuVacc11;

	internal MenuItem mnuVacc49;

	internal MenuItem mnuVacc12;

	internal MenuItem mnuVacc13;

	internal MenuItem mnuVacc14;

	internal MenuItem mnuVacc15;

	internal MenuItem mnuVacc16;

	internal MenuItem mnuVacc17;

	internal MenuItem mnuVacc18;

	internal MenuItem mnuVacc19;

	internal MenuItem mnuVacc20;

	internal MenuItem mnuVacc21;

	internal MenuItem mnuVacc23;

	internal MenuItem mnuVacc24;

	internal MenuItem mnuVacc26;

	internal MenuItem mnuVacc27;

	internal MenuItem mnuVacc29;

	internal MenuItem mnuVacc34;

	internal MenuItem mnuVacc35;

	internal MenuItem mnuVacc36;

	internal MenuItem mnuVacc60;

	internal MenuItem mnuVacc41;

	internal MenuItem mnuVacc42;

	internal MenuItem mnuVacc43;

	internal MenuItem mnuVacc44;

	internal MenuItem mnuVacc45;

	internal MenuItem mnuVacc46;

	internal MenuItem mnuVacc47;

	internal MenuItem mnuVacc48;

	internal MenuItem mnuVacc50;

	internal MenuItem mnuVacc51;

	internal MenuItem mnuVacc52;

	internal MenuItem mnuVacc54;

	internal MenuItem mnuVacc55;

	internal MenuItem mnuVacc56;

	internal MenuItem mnuVacc57;

	internal MenuItem mnuVacc58;

	internal MenuItem mnuSecureUtil;

	internal MenuItem mnuSecureChuri;

	internal MenuItem mnuShowFileExt;

	internal MenuItem mnuServiceMng;

	internal MenuItem mnuPU36;

	internal MenuItem mnuPU37;

	internal MenuItem mnuPU38;

	internal MenuItem mnuPU39;

	internal MenuItem mnuPU13;

	internal MenuItem mnuPU17;

	internal MenuItem mnuPU18;

	internal MenuItem mnuPU18a;

	internal MenuItem mnuPU18b;

	internal MenuItem mnuPU18c;

	internal MenuItem mnuPU18d;

	internal MenuItem mnuPU18e;

	internal MenuItem mnuVacc22;

	internal MenuItem mnuPU18f;

	internal MenuItem mnuPU18g;

	internal MenuItem mnuPU18g1;

	internal MenuItem mnuPU18g2;

	internal MenuItem mnuPU18h;

	internal MenuItem mnuPU19;

	internal MenuItem mnuPU20;

	internal MenuItem mnuVacc25;

	internal MenuItem mnuPU117;

	internal MenuItem mnuPU118;

	internal MenuItem mnuSecureLogon;

	internal MenuItem mnuAdminNoActive;

	internal MenuItem mnuSecureDriverInstall;

	internal MenuItem mnuWMIC_User;

	internal MenuItem mnuTMP;

	internal MenuItem mnuRundll1;

	internal MenuItem mnuRundll2;

	internal MenuItem mnuMtuCheckSite;

	internal MenuItem mnuShowTrayIcon;

	internal MenuItem mnuDism;

	internal MenuItem mnuSFC;

	internal MenuItem mnuRecovoryInitTop;

	internal MenuItem mnuRecovoryInit;

	internal MenuItem mnuRecovorySettings;

	internal MenuItem mnuRecovoryJob;

	internal MenuItem mnuDoRecovory;

	internal MenuItem mnuPU25;

	internal MenuItem mnuPU26;

	internal MenuItem mnuPU27;

	internal MenuItem mnuPU28;

	internal MenuItem mnuPU29;

	internal MenuItem mnuPU30;

	internal MenuItem mnuPU31;

	internal MenuItem mnuPU32;

	internal MenuItem mnuWindowsDocs;

	internal MenuItem mnuWindowsSecurityEncyclopedia;

	internal MenuItem mnuWindowsOSDocEncyclopedia;

	internal MenuItem mnuUsableSite;

	internal MenuItem mnuMathSite;

	internal MenuItem mnuMathSite2;

	internal MenuItem mnuMathCalcSite;

	internal MenuItem mnuPocketQuiz;

	internal MenuItem mnuShellCommandSearch;

	internal MenuItem mnuShellCommandSearchResult;

	internal MenuItem mnuPU00;

	internal MenuItem mnuPU01;

	internal MenuItem mnuPU02;

	internal MenuItem mnuPU03;

	internal MenuItem mnuPU04;

	internal MenuItem mnuPU05;

	internal MenuItem mnuPU05A;

	internal MenuItem mnuPU07;

	internal MenuItem mnuPU07_1;

	internal MenuItem mnuPU07_2;

	internal MenuItem mnuPU08;

	internal MenuItem mnuPU09;

	internal MenuItem mnuPU10;

	internal MenuItem mnuPU11;

	internal MenuItem mnuPU11a;

	internal MenuItem mnuPU11b;

	internal MenuItem mnuPU12;

	internal MenuItem mnuPU14;

	internal MenuItem mnuPU15;

	internal MenuItem mnuPU16;

	internal MenuItem mnuPU21;

	internal MenuItem mnuPU22;

	internal MenuItem mnuPU24;

	internal MenuItem mnuPU23;

	internal MenuItem mnuPU33;

	internal MenuItem mnuPU34;

	internal MenuItem mnuPU42;

	internal MenuItem mnuPU40;

	internal MenuItem mnuPU41;

	internal MenuItem mnuPU43;

	internal MenuItem mnuPU44;

	internal MenuItem mnuPU45;

	internal MenuItem mnuPU50;

	internal MenuItem mnuPU36a;

	internal MenuItem mnuPU51;

	internal MenuItem mnuPU52;

	internal MenuItem mnuPU53;

	internal MenuItem mnuPU54;

	internal MenuItem mnuPU54A;

	internal MenuItem mnuPU55;

	internal MenuItem mnuPU56;

	internal MenuItem mnuPU57;

	internal MenuItem mnuPU58;

	internal MenuItem mnuPU59;

	internal MenuItem mnuPU60;

	internal MenuItem mnuPU61;

	internal MenuItem mnuPU62;

	internal MenuItem mnuPU63;

	internal MenuItem mnuPU64;

	internal MenuItem mnuPU65;

	internal MenuItem mnuPU65A;

	internal MenuItem mnuPU66;

	internal MenuItem mnuPU66A;

	internal MenuItem mnuPU68;

	internal MenuItem mnuPU68bb;

	internal MenuItem mnuPU68cc;

	internal MenuItem mnuPU68A;

	internal MenuItem mnuPU68B;

	internal MenuItem mnuPU68C;

	internal MenuItem mnuPU67;

	internal MenuItem mnuPU69;

	internal MenuItem mnuPU70;

	internal MenuItem mnuPU71;

	internal MenuItem mnuPU72;

	internal MenuItem mnuPU73;

	internal MenuItem mnuPU74;

	internal MenuItem mnuPU75;

	internal MenuItem mnuPU76;

	internal MenuItem mnuPU77;

	internal MenuItem mnuPU78;

	internal MenuItem mnuPU79;

	internal MenuItem mnuPU79A;

	internal MenuItem mnuPU79B;

	internal MenuItem mnuPU80;

	internal MenuItem mnuPU81;

	internal MenuItem mnuPU82;

	internal MenuItem mnuPU83;

	internal MenuItem mnuPU83A;

	internal MenuItem mnuPU84;

	internal MenuItem mnuPU85;

	internal MenuItem mnuPU86;

	internal MenuItem mnuPU87;

	internal MenuItem mnuPU88;

	internal MenuItem mnuPU89;

	internal MenuItem mnuPU90;

	internal MenuItem mnuPU91;

	internal MenuItem mnuPU92;

	internal MenuItem mnuPU93;

	internal MenuItem mnuPU94;

	internal MenuItem mnuPU95;

	internal MenuItem mnuPU96;

	internal MenuItem mnuPU97;

	internal MenuItem mnuPU98A;

	internal MenuItem mnuPU98;

	internal MenuItem mnuPU99;

	internal MenuItem mnuPU100;

	internal MenuItem mnuPU101;

	internal MenuItem mnuPU102;

	internal MenuItem mnuPU103;

	internal MenuItem mnuPU103A;

	internal MenuItem mnuPU104;

	internal MenuItem mnuPU105;

	internal MenuItem mnuPU106;

	internal MenuItem mnuPU106A;

	internal MenuItem mnuPU107;

	internal MenuItem mnuPU108;

	internal MenuItem mnuPU109;

	internal MenuItem mnuPU110A;

	internal MenuItem mnuPU110B;

	internal MenuItem mnuPU110C;

	internal MenuItem mnuPU110D;

	internal MenuItem mnuPU110E;

	internal MenuItem mnuPU110;

	internal MenuItem mnuPU111;

	internal MenuItem mnuPU112;

	internal MenuItem mnuPU112A;

	internal MenuItem mnuPU112B;

	internal MenuItem mnuPU113;

	internal MenuItem mnuPU114B;

	internal MenuItem mnuPU114A;

	internal MenuItem mnuPU114;

	internal MenuItem mnuPU115;

	internal MenuItem mnuPU116;

	internal MenuItem mnuSysMscs;

	internal MenuItem mnuSysCpls;

	internal MenuItem mnuAllShellCommand;

	internal MenuItem mnuShellCommandAB;

	internal MenuItem mnuShellCommandCDE;

	internal MenuItem mnuShellCommandFGHIJ;

	internal MenuItem mnuShellCommandKLMNO;

	internal MenuItem mnuShellCommandPQR;

	internal MenuItem mnuShellCommandST;

	internal MenuItem mnuShellCommandUVWXYZ;

	internal MenuItem mnuResolveToBlock;

	internal MenuItem mnuResolve01;

	internal MenuItem mnuResolve07;

	internal MenuItem mnuResolve03;

	internal MenuItem mnuResolve04;

	internal MenuItem mnuResolve05;

	internal MenuItem mnuResolve02;

	internal MenuItem mnuResolve06;

	internal MenuItem mnuResolve08;

	internal MenuItem mnuResolve10s;

	internal MenuItem mnuResolve10;

	internal MenuItem mnuResolve20s;

	internal MenuItem mnuResolve20;

	internal MenuItem mnuSleepMilisec;

	internal Button btnHealthCheck;

	internal WebBrowser webb;

	internal TabControl tabCtrl;

	internal TabItem tabItemMain;

	internal TextBox txtHealthReport;

	internal TabItem tabApproval;

	internal DataGrid lvApproval;

	internal MenuItem mnuPopFirewallOBlock;

	internal DataGridTextColumn columnAppSort;

	internal Button btnAllApproval;

	internal Button btnViewNewed;

	internal Button btnViewAll;

	internal TabItem tabItem2;

	internal TextBox txtFileName;

	internal Button btnCheckSumSHA256;

	internal Button btnCheckSumMD5;

	internal Button btnClear;

	internal Button btnCopy;

	internal Button btnRemoveSharp;

	internal TabItem tabItemMsra;

	internal Label label1;

	internal Label label2;

	internal CheckBox chkUsePrivMail;

	internal TextBox txtGmailID;

	internal PasswordBox txtGmailPass;

	internal Label label3;

	internal Label label4;

	internal TextBox txtReceiverMailAddress;

	internal Label lblAuthEmailGuide;

	internal CheckBox chkSave1;

	internal CheckBox chkSave2;

	internal CheckBox chkSave3;

	internal Button btnMsraRequest;

	internal CheckBox chkAutoAllow;

	internal Label label5;

	internal TextBox txtMailContent;

	internal Button btnSetAllow;

	internal Button btnGoogleMailSendAllow1;

	internal Button btnGoogleMailSendAllow2;

	internal ListBox cboSessions;

	internal TextBlock lblSessions;

	internal TabItem tabItemUtils;

	internal Button btnOpenLogFolder;

	internal Button button2;

	internal Button vTotalS;

	internal Button btnProcessExp;

	internal Image imgProcExp;

	internal Button btnAutoRun;

	internal Image imgAutoRuns;

	internal CheckBox chkEndReDiagnosis;

	internal Button btnStartProgramUser;

	internal Button btnService;

	internal Button btnRegistree;

	internal Button btnProgramWiz;

	internal Button btnStartProgramAll;

	internal Button btnMsconfig;

	internal Button btnCompmmc;

	internal Button btnAdminCmd;

	internal Button btnFileSelector;

	internal Button btnOptimizeReg;

	internal Button btnDeleteBHO;

	internal Button btnGoGlean;

	internal Image imgGoClean;

	internal Button btnFixUSB;

	internal Button btnFireWall;

	internal Label lblBHO_delete_guide;

	internal Label lblBHO_delete_guide2;

	internal Button btnMsSpell;

	internal Button btnOpenHosts;

	internal Button btnUninstall;

	internal Button btnFileOutBound;

	internal Button btnEverything;

	internal Image imgEverything;

	internal Button btnNowVolume;

	internal ComboBox cboVolumeNow;

	internal Button btnMuteSign;

	internal Label lblTarget;

	internal ComboBox cboVolumeTo;

	internal Label lblDuration;

	internal ComboBox cboVolumeDuration;

	internal Button btnVolumeStoryboard;

	internal Label lblVolState;

	internal Button btnVolToPresent;

	internal ComboBox cboVolumeSet1;

	internal Button btnVolumeSet1;

	internal ComboBox cboVolumeSet2;

	internal Button btnVolumeSet2;

	internal ComboBox cboVolumeSet3;

	internal Button btnVolumeSet3;

	internal Slider volumeSlider;

	internal Label lblBuildNO;

	internal Button btnOneMinuAfterExecute;

	internal TextBox txtFileNameOfExecute;

	internal TextBlock lblRemainSec;

	internal TabItem tabItemURLProtocol;

	internal DataGrid lvURLProtocol;

	internal DataGridTemplateColumn FileExists;

	internal Button btnRecommandURLProtocol;

	internal TabItem tabItemAppOutBlock;

	internal CheckBox chkAppApprovalBlock;

	internal DataGrid lvAppOutBlock;

	internal DataGridTemplateColumn AppFileExists;

	internal Button btnRefreshOutBlock;

	internal Button btnAppOutBlockRecommand;

	internal TabItem tabItemAuth;

	internal TextBox txtUserEmail;

	internal TextBox txtSerialNumber;

	internal Button btnLicenceAuth;

	internal Label lblHelp;

	internal CheckBox chkContinue;

	internal Button btnSaveLog;

	internal Button btnAnalysisDeep;

	internal ComboBox cboBaseLine;

	internal Button btnAnalysisQuick;

	internal Button btnAnalysisCancel;

	internal Button btnHealthListCopy;

	internal CheckBox chkAutoStart;

	internal CheckBox chkAutoNetCloseStart;

	internal DockPanel dpanVolume;

	internal ComboBox cboVolume;

	private bool _contentLoaded;

	private string SYS32
	{
		get
		{
			if (m_SYS32 == null)
			{
				m_SYS32 = replaceNormalizePath("%windir%\\system32");
			}
			return m_SYS32;
		}
	}

	internal IntPtr HWND
	{
		get
		{
			return m_HWND;
		}
		set
		{
			m_HWND = value;
		}
	}

	private bool isErrorOccored
	{
		get
		{
			return m_isErrorOccored;
		}
		set
		{
			m_isErrorOccored = value;
		}
	}

	public DateTime dtnow { get; set; }

	private static string strWindowsFolder
	{
		get
		{
			if (m_strWindowsFolder == null)
			{
				m_strWindowsFolder = Environment.GetEnvironmentVariable("windir");
				m_strWindowsFolder = removeLastSlash(m_strWindowsFolder);
			}
			return m_strWindowsFolder;
		}
	}

	[DllImport("kernel32.dll")]
	public static extern IntPtr OpenProcess(uint processAccess, bool bInheritHandle, int processId);

	[DllImport("psapi.dll")]
	private static extern uint GetModuleFileNameEx(IntPtr hProcess, IntPtr hModule, [Out] StringBuilder lpBaseName, [In][MarshalAs(UnmanagedType.U4)] int nSize);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool CloseHandle(IntPtr hObject);

	public PowerDeskApp2014()
	{
		InitializeComponent();
		loaded_sub();
		RegiHelperSrc.Instance.isAuthCheck();
		RegiHelperSrc.Instance.URLProtocolBackgroundBrush = ((Control)tabItemURLProtocol).get_Background();
		((HeaderedItemsControl)mnuSleepMilisec).set_Header((object)"");
		if (App.IsAdministrator() && RegiHelperSrc.Instance.AutoW32TimeSynchChecked && RegiHelperSrc.Instance.RecentTimeSynchDateTime.CompareTo(DateTime.Now.AddDays(-14.0).ToString("yyyy-MM-dd HH:mm:ss")) < 0)
		{
			RegiHelperSrc.Instance.SetW32timeEnable(bShowStartGuide: false);
		}
		List<TerminalSessionData> list = TermServicesManager.ListSessions("127.0.0.1");
		nFirstSessionCount = list.Count;
		lblSessions.set_Text("세션목록 " + list.Count);
		((ItemsControl)cboSessions).get_Items().Clear();
		for (int i = 0; i < list.Count; i++)
		{
			((ItemsControl)cboSessions).get_Items().Add((object)list[i].ToString());
		}
	}

	private void loaded_sub()
	{
		if (arr_exe_cmd_etc == null)
		{
			if (!RegiHelperSrc.Instance.IsJsonInstallerNoti)
			{
				EXECMDETC = EXECMDETC.Replace("|.json", "");
			}
			arr_exe_cmd_etc = EXECMDETC.Split(new char[1] { '|' });
		}
		if (Utils.GetComputerName().IndexOf("-") == -1)
		{
			doShowFileExt();
			((UIElement)mnuShowFileExt).set_IsEnabled(false);
			mnuShowFileExt.set_IsChecked(true);
			RegiHelperSrc.Instance.Del_DisableTaskmgr();
		}
		else
		{
			if (GetShowFileExt())
			{
				((UIElement)mnuShowFileExt).set_IsEnabled(false);
				mnuShowFileExt.set_IsChecked(true);
			}
			((Window)this).set_Title(((Window)this).get_Title() + "[" + Utils.GetComputerName() + "]");
		}
		if (App.AddHashCalcMenu(1))
		{
			mnuUseHashCalc.set_IsChecked(true);
		}
		else
		{
			mnuUseHashCalc.set_IsChecked(false);
		}
		doAutoStartAppOff();
		char directorySeparatorChar = Path.DirectorySeparatorChar;
		SEPA = directorySeparatorChar.ToString();
		App.LOGPATH = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + SEPA + "HealthChecker" + SEPA + "Log" + SEPA;
		App.WorkLog("start>>" + (App.isBackGroundRunning ? "bg" : ""));
		if (App.isBackGroundRunning && RegiHelperSrc.Instance.bAuth)
		{
			string virus_ip = "";
			if (Utils.CheckVirusIP(ref virus_ip))
			{
				Utils.alert(virus_ip);
			}
		}
		App.WorkLog2();
		readApprovalList(itmListViewApproval);
		if (App.isBackGroundRunning)
		{
			HealthCheckProcess(bAutoStartRun: true);
		}
		else
		{
			tBar.set_Text("[건강 진단]버튼을 먼저 클릭하세요.");
			tBar.set_Foreground((Brush)(object)Brushes.get_Red());
		}
		((ItemsControl)lvApproval).set_ItemsSource((IEnumerable)itmListViewApproval);
		if (App.IsAdministrator())
		{
			((Window)this).set_Title("[관리자]" + ((Window)this).get_Title());
		}
		((FrameworkElement)LayoutRoot).set_DataContext((object)RegiHelperSrc.Instance);
		if (CNativeWIN32.IsWindows8())
		{
			((ContentControl)btnMsconfig).set_Content((object)"TaskMgr>Startup");
		}
		Instance = this;
		if (!RegiHelperSrc.Instance.deleteRunOnce())
		{
		}
		VideoUI_deny();
		if (App.isSharePreventAndExit)
		{
			if (App.IsAdministrator())
			{
				PCALUA_task_disable();
				if (RegiHelperSrc.Instance.EnableAntigen15)
				{
					RegiHelperSrc.Instance.CheckedVaccine15 = true;
				}
				((Window)this).Close();
			}
			else
			{
				Utils.alert("관리자 권한으로 실행되어야 Net Share 중지를 자동으로 할 수 있습니다.");
			}
		}
		if (RegiHelperSrc.IsBootMenuStandard())
		{
			if (File.Exists("c:\\windows\\system32\\bcdedit2.exe"))
			{
				Utils.ExecuteCommandSync("bcdedit2.exe /set {default} bootmenupolicy legacy");
			}
			else
			{
				Utils.ExecuteCommandSync("bcdedit /set {default} bootmenupolicy legacy");
			}
		}
		staticIsLoaded = true;
		mnuUAC_chk.set_IsChecked(DoUacChkAutoStartCheck(1));
	}

	private void PCALUA_task_disable()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		if (!CNativeWIN32.IsWindows7() && !CNativeWIN32.IsWindows7OverFunction())
		{
			return;
		}
		TaskService val = new TaskService();
		try
		{
			Regex regex = new Regex("^[^$]*", RegexOptions.IgnoreCase);
			Task[] array = null;
			try
			{
				array = val.FindAllTasks(regex, true);
				for (int i = 0; i < array.Count(); i++)
				{
					Task val2 = array[i];
					try
					{
						if (((IEnumerable<Action>)val2.get_Definition().get_Actions()).First() is ExecAction)
						{
							string path = ((ExecAction)((IEnumerable<Action>)val2.get_Definition().get_Actions()).First()).get_Path();
							if ((-1 < path.IndexOf("PCALUA ", StringComparison.CurrentCultureIgnoreCase) || -1 < path.IndexOf("PCALUA.EXE", StringComparison.CurrentCultureIgnoreCase)) && val2.get_Enabled())
							{
								val2.set_Enabled(false);
							}
						}
					}
					catch (Exception ex)
					{
						Console.Error.WriteLine(ex.Message);
					}
				}
			}
			catch (Exception ex2)
			{
				Console.Error.WriteLine(ex2.Message);
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	private void doShowFileExt()
	{
		RegistryKey registryKey = null;
		if (Utils.Is64OS())
		{
			RegistryKey registryKey2 = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
			registryKey = registryKey2.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", RegistryKeyPermissionCheck.ReadWriteSubTree);
		}
		else
		{
			registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", RegistryKeyPermissionCheck.ReadWriteSubTree);
		}
		if (registryKey != null)
		{
			if ((int)registryKey.GetValue("HideFileExt", -1) != 0)
			{
				registryKey.SetValue("HideFileExt", 0);
			}
			registryKey.Close();
		}
		if (Utils.Is64OS())
		{
			RegistryKey registryKey2 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
			registryKey = registryKey2.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced\\Folder\\HideFileExt", RegistryKeyPermissionCheck.ReadWriteSubTree);
		}
		else
		{
			registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced\\Folder\\HideFileExt", RegistryKeyPermissionCheck.ReadWriteSubTree);
		}
		if (registryKey != null)
		{
			if ((int)registryKey.GetValue("UncheckedValue", -1) != 0)
			{
				registryKey.SetValue("UncheckedValue", 0);
			}
			registryKey.Close();
		}
	}

	private bool GetShowFileExt()
	{
		bool result = false;
		RegistryKey registryKey = null;
		if (Utils.Is64OS())
		{
			RegistryKey registryKey2 = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
			registryKey = registryKey2.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced");
		}
		else
		{
			registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced");
		}
		if (registryKey != null)
		{
			int num = (int)registryKey.GetValue("HideFileExt", -2);
			if (num != 1)
			{
				result = true;
			}
			registryKey.Close();
		}
		return result;
	}

	private void doShowFolderOption()
	{
		RegistryKey registryKey = null;
		if (Utils.Is64OS())
		{
			RegistryKey registryKey2 = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
			registryKey = registryKey2.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", RegistryKeyPermissionCheck.ReadWriteSubTree);
		}
		else
		{
			registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", RegistryKeyPermissionCheck.ReadWriteSubTree);
		}
		if (registryKey != null)
		{
			if ((int)registryKey.GetValue("HideFileExt", -1) != 0)
			{
				registryKey.SetValue("HideFileExt", 0);
			}
			registryKey.Close();
		}
		if (Utils.Is64OS())
		{
			RegistryKey registryKey2 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
			registryKey = registryKey2.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced\\Folder\\HideFileExt", RegistryKeyPermissionCheck.ReadWriteSubTree);
		}
		else
		{
			registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced\\Folder\\HideFileExt", RegistryKeyPermissionCheck.ReadWriteSubTree);
		}
		if (registryKey != null)
		{
			if ((int)registryKey.GetValue("UncheckedValue", -1) != 0)
			{
				registryKey.SetValue("UncheckedValue", 0);
			}
			registryKey.Close();
		}
	}

	private void doAutoStartAppOff()
	{
		RegistryKey registryKey = null;
		if (Utils.Is64OS())
		{
			RegistryKey registryKey2 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
			registryKey = registryKey2.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon\\UserARSO", RegistryKeyPermissionCheck.ReadWriteSubTree);
		}
		else
		{
			registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon\\UserARSO", RegistryKeyPermissionCheck.ReadWriteSubTree);
		}
		if (registryKey == null)
		{
			registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon\\UserARSO");
		}
		if (registryKey != null)
		{
			string text = WindowsIdentity.GetCurrent().User!.AccountDomainSid!.ToString();
			RegistryKey registryKey3 = null;
			registryKey3 = registryKey.OpenSubKey(text, RegistryKeyPermissionCheck.ReadWriteSubTree);
			if (registryKey3 == null)
			{
				registryKey3 = registryKey.CreateSubKey(text, RegistryKeyPermissionCheck.ReadWriteSubTree);
			}
			registryKey3.SetValue("OptOut", 1);
			registryKey3.Close();
			registryKey3.Dispose();
			registryKey.Close();
			registryKey.Dispose();
		}
	}

	private void readApprovalList(List<ApprovalList> lstApproval)
	{
		List<string> sections = App.iniApprovalList.GetSections();
		for (int i = 0; i < sections.Count; i++)
		{
			ApprovalList orCreate = ApprovalList.GetOrCreate(sections[i]);
			try
			{
				lstApproval.Add(orCreate);
			}
			catch (Exception ex)
			{
				Console.Error.WriteLine(ex.Message);
			}
			try
			{
				dictApprovalList.Add(orCreate.Section.Replace("|", SEPA).ToLower(), orCreate.CheckSum);
			}
			catch (Exception ex)
			{
				Console.Error.WriteLine(ex.Message);
			}
		}
	}

	private void readUrlProtocolList(List<URLProtocolList> lstUrlProtocol)
	{
		List<string> list = App.iniApprovalList.ReadURLProtocols();
		for (int i = 0; i < list.Count; i++)
		{
			URLProtocolList orCreate = URLProtocolList.GetOrCreate(list[i]);
			try
			{
				lstUrlProtocol.Add(orCreate);
			}
			catch (Exception ex)
			{
				Console.Error.WriteLine(ex.Message);
			}
			try
			{
				dictURLPtotocolList.Add(list[i], orCreate.CheckSum);
			}
			catch (Exception ex)
			{
				Console.Error.WriteLine(ex.Message);
			}
		}
	}

	private void readAppOutBlockList(List<AppOutBlockList> lstAppOutBlock)
	{
		List<string> list = App.iniAppOutBlockList.ReadAppOutBlockList();
		if (list == null)
		{
			return;
		}
		for (int i = 0; i < list.Count; i++)
		{
			AppOutBlockList orCreate = AppOutBlockList.GetOrCreate(list[i]);
			try
			{
				lstAppOutBlock.Add(orCreate);
			}
			catch (Exception ex)
			{
				Console.Error.WriteLine(ex.Message);
			}
			try
			{
				dictAppOutBlockList.Add(list[i], orCreate.CheckSum);
			}
			catch (Exception ex)
			{
				Console.Error.WriteLine(ex.Message);
			}
		}
	}

	protected override void OnContentRendered(EventArgs e)
	{
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Invalid comparison between Unknown and I4
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected O, but got Unknown
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected O, but got Unknown
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_046a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Expected O, but got Unknown
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0486: Expected O, but got Unknown
		//IL_05e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f0: Expected O, but got Unknown
		//IL_066c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0676: Expected O, but got Unknown
		//IL_0d5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d61: Expected O, but got Unknown
		//IL_0de7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df1: Expected O, but got Unknown
		//IL_0f98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f9f: Expected O, but got Unknown
		//IL_110b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1115: Expected O, but got Unknown
		//IL_113a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1144: Expected O, but got Unknown
		//IL_133c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1346: Expected O, but got Unknown
		//IL_1347: Unknown result type (might be due to invalid IL or missing references)
		//IL_134e: Expected O, but got Unknown
		//IL_1395: Unknown result type (might be due to invalid IL or missing references)
		//IL_139f: Expected O, but got Unknown
		//IL_13f3: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.IsKeyBoardStateCapsLockOn())
		{
			string strMsg = "Caps Lock이 켜 있습니다.\n이는 의도되지 않았을 수 있습니다.";
			MessageBoxTimerClose messageBoxTimerClose = new MessageBoxTimerClose(strMsg);
			((Window)messageBoxTimerClose).ShowDialog();
			((Window)messageBoxTimerClose).Close();
		}
		string virus_ip = "";
		if (Utils.CheckVirusIP(ref virus_ip))
		{
			Utils.alert(virus_ip);
		}
		if (!Debugger.IsAttached)
		{
			IniFile iniFile = new IniFile(RegiHelperSrc.DIR_PUBLIC_APP_CERTIFICATION_ENV_INI);
			string text = iniFile.ReadValue_UTF8(App.DEFAULT_CODE_SIGN, "v221014003");
			if (text == "")
			{
				iniFile.WriteValue_UTF8(App.DEFAULT_CODE_SIGN, "v221014003", getMyHash());
			}
			else if (text != getMyHash())
			{
				if ((int)Keyboard.get_Modifiers() != 4)
				{
					string strMsg = "프로그램 파일이 변조되었습니다. \n다시 설치하세요. \n프로그램을 종료합니다.";
					Utils.alert(strMsg);
					Application.get_Current().Shutdown();
					return;
				}
				iniFile.WriteValue_UTF8(App.DEFAULT_CODE_SIGN, "v221014003", getMyHash());
			}
		}
		((ContentControl)lblBuildNO).set_Content((object)"Build No: 221014003");
		if (Utils.lst_cmd_reserved != null)
		{
			for (int i = 0; i < Utils.lst_cmd_reserved.Count; i++)
			{
				Utils.ExecuteCommandSync(Utils.lst_cmd_reserved[0], showError: false);
			}
			Utils.lst_cmd_reserved.Clear();
		}
		((Window)this).OnContentRendered(e);
		bool? isChecked = ((ToggleButton)chkAutoStart).get_IsChecked();
		if (!isChecked.GetValueOrDefault() && isChecked.HasValue && ((ToggleButton)chkAutoNetCloseStart).get_IsChecked() == false)
		{
			RegiHelperSrc.Instance.Installed = true;
		}
		if (RegiHelperSrc.Instance.Installed)
		{
			bool flag = false;
			if (((ToggleButton)chkAutoStart).get_IsChecked() == false)
			{
				((Control)chkAutoStart).set_Foreground((Brush)(object)Brushes.get_OrangeRed());
				flag = true;
			}
			if (((ToggleButton)chkAutoNetCloseStart).get_IsChecked() == false)
			{
				((Control)chkAutoNetCloseStart).set_Foreground((Brush)(object)Brushes.get_OrangeRed());
				flag = true;
			}
			if (flag)
			{
				((Control)btnHealthCheck).set_Background((Brush)(object)Brushes.get_Orange());
			}
		}
		getRegValueForMsra();
		txtReceiverMailAddress.set_Text(RegiHelperSrc.Instance.SavedReceiverMail);
		((ToggleButton)chkSave3).set_IsChecked((bool?)RegiHelperSrc.Instance.Saved3);
		if (App.bDoFirstMsra)
		{
			((UIElement)tabItemMsra).Focus();
		}
		for (int i = 0; i < webF.Count(); i++)
		{
			webF[i] = new WebBrowser();
			webF[i].add_DocumentCompleted(new WebBrowserDocumentCompletedEventHandler(webF_DocumentCompleted));
			webF[i].set_ScriptErrorsSuppressed(true);
		}
		string text2 = App.iniFile.ReadValueDefault("AnalysisBaseLine", "5");
		App.iniFile.WriteValue_UTF8("AnalysisBaseLine", text2);
		bool flag2 = Convert.ToBoolean(App.iniFile.ReadValueDefault("AnalysisUSE", "True"));
		((UIElement)btnAnalysisCancel).set_IsEnabled(flag2);
		mnuAgreeCostFunctionUse.set_IsChecked(flag2);
		((ListBoxItem)(ComboBoxItem)((ItemsControl)cboBaseLine).get_Items().get_Item(((CollectionView)((ItemsControl)cboBaseLine).get_Items()).get_Count() - Convert.ToInt32(text2) + 1)).set_IsSelected(true);
		bool? flag3 = null;
		string text3 = ((RegiHelperSrc.iStartVolume != -3) ? string.Concat(RegiHelperSrc.iStartVolume) : ((flag3 != true) ? CNativeWIN32.GetVolume().ToString() : "-1"));
		flag3 = CNativeWIN32.IsMute();
		ComboBoxItem val = null;
		for (int i = 0; i < ((CollectionView)((ItemsControl)cboVolume).get_Items()).get_Count(); i++)
		{
			object obj = ((ItemsControl)cboVolume).get_Items().get_Item(i);
			val = (ComboBoxItem)((obj is ComboBoxItem) ? obj : null);
			if (text3.StartsWith("-"))
			{
				if (((ContentControl)val).get_Content().ToString()!.StartsWith(text3))
				{
					((ListBoxItem)val).set_IsSelected(true);
					break;
				}
			}
			else if (((ContentControl)val).get_Content().ToString() == text3)
			{
				((ListBoxItem)val).set_IsSelected(true);
				break;
			}
		}
		((Selector)cboVolume).add_SelectionChanged(new SelectionChangedEventHandler(cboVolume_SelectionChanged));
		mnu_i_Click = (RoutedEventHandler)delegate(object sender, RoutedEventArgs e)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			MenuItem val3 = (MenuItem)((sender is MenuItem) ? sender : null);
			if (val3 != null)
			{
				if (prevCPLmenu != null)
				{
					((Control)prevCPLmenu).set_FontWeight(FontWeights.get_Normal());
				}
				((Control)val3).set_FontWeight(FontWeights.get_Bold());
				prevCPLmenu = val3;
				string text13 = ((FrameworkElement)val3).get_Tag().ToString();
				if (text13.StartsWith("control", StringComparison.CurrentCultureIgnoreCase))
				{
					if (-1 < text13.IndexOf(".exe"))
					{
						int num = text13.IndexOf(".exe");
						string lpParameters = text13.Substring(num + 4).Trim();
						CNativeWIN32.ShellExecute(0, "open", "control.exe", lpParameters, SYS32, 1);
					}
					else
					{
						CNativeWIN32.ShellExecute(0, "open", text13, null, SYS32, 1);
					}
				}
				else if (text13.StartsWith("rundll32", StringComparison.CurrentCultureIgnoreCase))
				{
					if (-1 < text13.IndexOf(".exe"))
					{
						int num = text13.IndexOf(".exe");
						string lpParameters = text13.Substring(num + 4).Trim();
						CNativeWIN32.ShellExecute(0, "open", "rundll32.exe", lpParameters, SYS32, 1);
					}
					else
					{
						CNativeWIN32.ShellExecute(0, "open", text13, null, SYS32, 1);
					}
				}
				else if (text13.StartsWith("cmd", StringComparison.CurrentCultureIgnoreCase))
				{
					if (-1 < text13.IndexOf(".exe"))
					{
						int num = text13.IndexOf(".exe");
						string lpParameters = text13.Substring(num + 4).Trim();
						CNativeWIN32.ShellExecute(0, "open", "cmd.exe", lpParameters, SYS32, 1);
					}
					else
					{
						CNativeWIN32.ShellExecute(0, "open", text13, null, SYS32, 1);
					}
				}
				else
				{
					switch (Utils.getFileExt(text13).ToLower())
					{
					case ".{ed7ba470-8e54-465e-825c-99712043e01c}":
					{
						string text14 = RegiHelperSrc.AppRootPath + Utils.SEPA + text13;
						if (!Directory.Exists(text14))
						{
							Directory.CreateDirectory(text14);
						}
						CNativeWIN32.ShellExecute(0, "open", text14, null, SYS32, 1);
						break;
					}
					case ".cpl":
						if (-1 < text13.IndexOf("system32", StringComparison.CurrentCultureIgnoreCase))
						{
							CNativeWIN32.ShellExecute(0, "open", "control", text13, SYS32, 1);
						}
						else
						{
							CNativeWIN32.ShellExecute(0, "open", text13, null, SYS32, 1);
						}
						break;
					case ".exe":
					case ".msc":
						CNativeWIN32.ShellExecute(0, "open", text13, null, SYS32, 1);
						break;
					default:
						if (text13.StartsWith("{"))
						{
							CNativeWIN32.ShellExecute(0, "open", "explorer.exe", "shell:::" + text13, SYS32, 1);
						}
						else
						{
							CNativeWIN32.ShellExecute(0, "open", text13, null, SYS32, 1);
						}
						break;
					}
				}
				e.set_Handled(true);
			}
		};
		string text4 = Environment.GetEnvironmentVariable("windir") + Utils.SEPA + "system32" + Utils.SEPA;
		string text5 = Utils.FilesDosDir(text4 + "*.msc /b");
		string[] array = text5.Replace("\n", "\r").Replace("\r\r", "\r").Split(new char[1] { '\r' });
		for (int i = 0; i < array.Count(); i++)
		{
			if (0 < array[i].Length)
			{
				lst_msc.Add(text4 + array[i]);
			}
		}
		text5 = Utils.FilesDosDir(text4 + "*.cpl /b");
		if (-1 == text5.IndexOf("firewall.cpl", StringComparison.CurrentCultureIgnoreCase))
		{
			text5 = text5 + text4 + "firewall.cpl";
		}
		array = text5.Replace("\n", "\r").Replace("\r\r", "\r").Split(new char[1] { '\r' });
		for (int i = 0; i < array.Count(); i++)
		{
			if (0 < array[i].Length)
			{
				lst_cpl.Add(text4 + array[i]);
			}
		}
		MenuItem val2;
		for (int i = 0; i < lst_msc.Count; i++)
		{
			val2 = new MenuItem();
			((ItemsControl)mnuSysMscs).get_Items().Add((object)val2);
			((HeaderedItemsControl)val2).set_Header((object)Utils.mscDesc(Utils.onlyFileNameEx(lst_msc[i])));
			((FrameworkElement)val2).set_Tag((object)lst_msc[i]);
			lst_cpl_msc.Add(string.Concat(((HeaderedItemsControl)val2).get_Header(), "|", lst_msc[i]));
			val2.add_Click(new RoutedEventHandler(mnu_i_Click.Invoke));
		}
		lst_cpl_msc.Add("방화벽 설정(파일 체크 차단)|control.exe /name Microsoft.WindowsFirewall /page PageConfigureApps");
		lst_cpl_msc.Add("스냅인|mmc.exe");
		lst_cpl_msc.Add("사용자 계정|netplwiz.exe");
		lst_cpl_msc.Add("사용자 계정 컨트롤|UserAccountControlSettings.exe");
		if (Utils.IsNotServerMachine())
		{
			lst_cpl_msc.Add("윈도우즈 기능 추가/제거|OptionalFeatures.exe");
		}
		else
		{
			lst_cpl_msc.Add("서버 기능 추가/제거|ServerManager.exe");
		}
		lst_cpl_msc.Add("원격 설정|systempropertiesremote.exe");
		lst_cpl_msc.Add("원격 데스크톱 연결|mstsc.exe");
		lst_cpl_msc.Add("iSCSI 초기자|iSCSI.exe");
		lst_cpl_msc.Add("시스템 구성|msconfig.exe");
		lst_cpl_msc.Add("작업 관리자|taskmgr.exe");
		lst_cpl_msc.Add("전원 시스템 설정|control.exe /name Microsoft.PowerOptions /page pageGlobalSettings");
		lst_cpl_msc.Add("DirectX 진단 도구|dxdiag.exe");
		lst_cpl_msc.Add("윈도우 버전 정보|winver.exe");
		lst_cpl_msc.Add("디스크 정리|cleanmgr.exe");
		if (Utils.IsNotServerMachine())
		{
			lst_cpl_msc.Add("디스크 조각모음|cmd.exe /c defrag.exe -c -v -u&time /t&pause");
			if (Utils.FileExists(RegiHelperSrc.Instance.StrSecHealthUI_path))
			{
				lst_cpl_msc.Add("Windows Defender 보안|" + RegiHelperSrc.Instance.StrSecHealthUI_path);
			}
		}
		else
		{
			((UIElement)mnuPU36).set_Visibility((Visibility)2);
			((UIElement)mnuPU34).set_Visibility((Visibility)2);
			((UIElement)mnuPU36a).set_Visibility((Visibility)2);
		}
		lst_cpl_msc.Add("시스템 아이콘 켜기 끄기|{05d7b0f4-2121-4eff-bf6b-ed3f69b894d9} \\SystemIcons,,0");
		lst_cpl_msc.Add("동기화 설정|control.exe /NAME Microsoft.SyncCenter");
		lst_cpl_msc.Add("기본 프로그램 설정|control.exe /NAME Microsoft.DefaultPrograms /PAGE pageDefaultProgram");
		lst_cpl_msc.Add("연결 프로그램 설정|control.exe /NAME Microsoft.DefaultPrograms /PAGE pageFileAssoc");
		lst_cpl_msc.Add("이 컴퓨터에 연결된 기본 프로그램설정|rundll32.exe shell32.dll,Control_RunDLL appwiz.cpl,,3");
		lst_cpl_msc.Add("타블렛 설정|control.exe /NAME Microsoft.TabletPCSettings");
		lst_cpl_msc.Add("긋기 설정|rundll32.exe shell32.dll,Control_RunDLL tabletpc.cpl @0,flicks");
		lst_cpl_msc.Add("장치 추가 마법사|DevicePairingWizard.exe");
		lst_cpl_msc.Add("장치 설치 마법사|hdwwiz.exe");
		lst_cpl_msc.Add("바탕화면 아이콘 설정|rundll32.exe shell32.dll,Control_RunDLL desk.cpl,,0");
		lst_cpl_msc.Add("화면 보호기 설정|rundll32.exe shell32.dll,Control_RunDLL desk.cpl,,1");
		lst_cpl_msc.Add("바탕화면 테마 설정|rundll32.exe shell32.dll,Control_RunDLL desk.cpl,,2");
		lst_cpl_msc.Add("화면 해상도 설정|rundll32.exe shell32.dll,Control_RunDLL desk.cpl,,3");
		lst_cpl_msc.Add("해외 시간 설정|rundll32.exe shell32.dll,Control_RunDLL timedate.cpl,,1");
		lst_cpl_msc.Add("프린터 추가 마법사(약식)|rundll32.exe shell32.dll,SHHelpShortcuts_RunDLL AddPrinter");
		lst_cpl_msc.Add("창 색상|control.exe color");
		lst_cpl_msc.Add("문제 단계 레코더|psr.exe");
		lst_cpl_msc.Add("국가 및 언어|control.exe international");
		lst_cpl_msc.Add("국가 및 위치|control.exe /NAME Microsoft.RegionalAndLanguageOptions /PAGE /p:\"Location\"");
		lst_cpl_msc.Add("날짜 및 시간|rundll32.exe Shell32.dll,Control_RunDLL timedate.cpl,,0");
		lst_cpl_msc.Add("시계 추가|rundll32.exe Shell32.dll,Control_RunDLL timedate.cpl,,1");
		lst_cpl_msc.Add("언어|control.exe /NAME Microsoft.Language");
		lst_cpl_msc.Add("자판|control.exe /NAME Microsoft.Keyboard");
		lst_cpl_msc.Add("마우스|control.exe /NAME Microsoft.Mouse");
		lst_cpl_msc.Add("Administrative Tools|control.exe admintools");
		lst_cpl_msc.Add("AutoPlay|control.exe Microsoft.AutoPlay");
		lst_cpl_msc.Add("Backup and Restore (Windows 7)|control.exe /NAME Microsoft.BackupAndRestoreCenter");
		lst_cpl_msc.Add("BitLocker Drive Encryption|control.exe /NAME Microsoft.BitLockerDriveEncryption");
		lst_cpl_msc.Add("Color and Appearance|{ED834ED6-4B5A-4bfe-8F11-A626DCB6A921}");
		lst_cpl_msc.Add("Color Management|control.exe /NAME Microsoft.ColorManagement");
		lst_cpl_msc.Add("Credential Manager|control.exe /NAME Microsoft.CredentialManager");
		lst_cpl_msc.Add("Default Programs|control.exe /NAME Microsoft.DefaultPrograms");
		lst_cpl_msc.Add("Desktop Background|{ED834ED6-4B5A-4bfe-8F11-A626DCB6A921} -Microsoft.Personalization\\pageWallpaper");
		lst_cpl_msc.Add("Ease of Access Center|rundll32.exe Shell32.dll,Control_RunDLL \"C:\\Windows\\System32\\access.cpl\"");
		lst_cpl_msc.Add("File Explorer Options (General tab)|control.exe /NAME Microsoft.FolderOptions");
		lst_cpl_msc.Add("File Explorer Options (View tab)|rundll32.exe shell32.dll,Options_RunDLL 7");
		lst_cpl_msc.Add("File Explorer Options (Search tab)|rundll32.exe shell32.dll,Options_RunDLL 2");
		lst_cpl_msc.Add("File History|control.exe /NAME Microsoft.FileHistory");
		lst_cpl_msc.Add("Fonts|control.exe /NAME Microsoft.Fonts");
		lst_cpl_msc.Add("Game Controllers|control.exe /NAME Microsoft.GameControllers");
		lst_cpl_msc.Add("Get Programs|control.exe /NAME Microsoft.GetPrograms");
		lst_cpl_msc.Add("HomeGroup|control.exe /NAME Microsoft.HomeGroup");
		lst_cpl_msc.Add("Indexing Options|control.exe /NAME Microsoft.IndexingOptions");
		lst_cpl_msc.Add("Infrared|control.exe /NAME Microsoft.Infrared");
		lst_cpl_msc.Add("Internet Properties (General tab)|control.exe /NAME Microsoft.InternetOptions");
		lst_cpl_msc.Add("Network and Sharing Center|control.exe /NAME Microsoft.NetworkAndSharingCenter");
		lst_cpl_msc.Add("Notification Area Icons|{05d7b0f4-2121-4eff-bf6b-ed3f69b894d9}");
		lst_cpl_msc.Add("Offline Files|control.exe /NAME Microsoft.OfflineFiles");
		lst_cpl_msc.Add("Personalization|{ED834ED6-4B5A-4bfe-8F11-A626DCB6A921}");
		lst_cpl_msc.Add("Phone and Modem|control.exe /NAME Microsoft.PhoneAndModem");
		lst_cpl_msc.Add("Power Options|control.exe /NAME Microsoft.PowerOptions");
		lst_cpl_msc.Add("Presentation Settings|PresentationSettings.exe");
		lst_cpl_msc.Add("Programs and Features|control.exe /NAME Microsoft.ProgramsAndFeatures");
		lst_cpl_msc.Add("Recovery|control.exe /NAME Microsoft.Recovery");
		lst_cpl_msc.Add("Region (Administrative tab)|control.exe /NAME Microsoft.RegionalAndLanguageOptions /PAGE /p:\"Administrative\"");
		lst_cpl_msc.Add("RemoteApp and Desktop Connections|control.exe /NAME Microsoft.RemoteAppAndDesktopConnections");
		lst_cpl_msc.Add("Scanners and Cameras|control.exe /NAME Microsoft.ScannersAndCameras");
		lst_cpl_msc.Add("Set Associations|control.exe /NAME Microsoft.DefaultPrograms /PAGE pageFileAssoc");
		lst_cpl_msc.Add("Set Default Programs|control.exe /NAME Microsoft.DefaultPrograms /PAGE pageDefaultProgram");
		lst_cpl_msc.Add("Sound (Playback tab)|control.exe /NAME Microsoft.Sound");
		lst_cpl_msc.Add("Sound (Sounds tab)|rundll32.exe shell32.dll,Control_RunDLL mmsys.cpl,,2");
		lst_cpl_msc.Add("Speech Recognition|control.exe /NAME Microsoft.SpeechRecognition");
		lst_cpl_msc.Add("Storage Spaces|control.exe /NAME Microsoft.StorageSpaces");
		lst_cpl_msc.Add("Sync Center|control.exe /NAME Microsoft.SyncCenter");
		lst_cpl_msc.Add("System Properties (Advanced)|SystemPropertiesAdvanced.exe");
		lst_cpl_msc.Add("System Properties (Hardware)|SystemPropertiesHardware.exe");
		lst_cpl_msc.Add("System Properties (Computer Name)|SystemPropertiesComputerName.exe");
		lst_cpl_msc.Add("System Properties (System Protection)|SystemPropertiesProtection.exe");
		lst_cpl_msc.Add("System Properties (Remote)|SystemPropertiesRemote.exe");
		lst_cpl_msc.Add("System Infomation|control.exe /NAME Microsoft.System");
		lst_cpl_msc.Add("System Property|control.exe sysdm.cpl");
		lst_cpl_msc.Add("컴퓨터 이름 변경|control.exe sysdm.cpl");
		lst_cpl_msc.Add("System Icons|{05d7b0f4-2121-4eff-bf6b-ed3f69b894d9} \\SystemIcons,,0");
		lst_cpl_msc.Add("System Performance|SystemPropertiesPerformance.exe");
		lst_cpl_msc.Add("System DEP|SystemPropertiesDataExecutionPrevention.exe");
		lst_cpl_msc.Add("Troubleshooting|control.exe /name Microsoft.Troubleshooting");
		lst_cpl_msc.Add("Windows Defender|control.exe /name Microsoft.WindowsDefender");
		if (Utils.IsNotServerMachine())
		{
			lst_cpl_msc.Add("Windows Features|OptionalFeatures.exe");
		}
		else
		{
			lst_cpl_msc.Add("Windows Features|ServerManager.exe");
		}
		lst_cpl_msc.Add("Windows Mobility Center|control.exe /NAME Microsoft.MobilityCenter");
		lst_cpl_msc.Add("Windows To Go|pwcreator.exe");
		lst_cpl_msc.Add("Work Folders|WorkFolders.exe");
		string text6 = "";
		string text7 = "C:\\Windows\\System32\\Speech\\SpeechUX\\sapi.cpl";
		if (Utils.FileExists(text7))
		{
			lst_cpl.Add(text7);
		}
		for (int i = 0; i < lst_cpl.Count; i++)
		{
			val2 = new MenuItem();
			((ItemsControl)mnuSysCpls).get_Items().Add((object)val2);
			text6 = Utils.onlyFileName(lst_cpl[i]);
			text6 += Utils.cplDesc(text6);
			((HeaderedItemsControl)val2).set_Header((object)text6);
			((FrameworkElement)val2).set_Tag((object)lst_cpl[i]);
			lst_cpl_msc.Add(text6 + "|" + lst_cpl[i]);
			val2.add_Click(new RoutedEventHandler(mnu_i_Click.Invoke));
		}
		RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey("CLSID");
		string[] subKeyNames = registryKey.GetSubKeyNames();
		string text8 = null;
		string text9 = null;
		string text10 = null;
		for (int i = 0; i < subKeyNames.Count(); i++)
		{
			text8 = registryKey.OpenSubKey(subKeyNames[i])!.GetValue("LocalizedString", "") as string;
			text9 = registryKey.OpenSubKey(subKeyNames[i])!.GetValue("", "") as string;
			if (0 < text8.Length && 0 < text9.Length)
			{
				text10 = registryKey.OpenSubKey(subKeyNames[i])!.GetValue("AppID", null) as string;
				if (text10 == null && -1 < text8.IndexOf(Utils.SEPA) && -1 == text9.IndexOf("class", StringComparison.CurrentCultureIgnoreCase) && -1 == text9.IndexOf("mail", StringComparison.CurrentCultureIgnoreCase) && -1 == text9.IndexOf("player", StringComparison.CurrentCultureIgnoreCase) && -1 == text9.IndexOf("filter", StringComparison.CurrentCultureIgnoreCase) && -1 == text9.IndexOf("helper", StringComparison.CurrentCultureIgnoreCase) && -1 == text9.IndexOf("paint", StringComparison.CurrentCultureIgnoreCase) && -1 == text9.IndexOf("clsid", StringComparison.CurrentCultureIgnoreCase))
				{
					lst_shell.Add(text9 + "|" + subKeyNames[i]);
				}
			}
		}
		lst_shell.Sort();
		string[] array2 = null;
		string text11 = null;
		for (int i = 0; i < lst_shell.Count(); i++)
		{
			val2 = new MenuItem();
			array2 = lst_shell[i].Split(new char[1] { '|' });
			((HeaderedItemsControl)val2).set_Header((object)array2[0]);
			text11 = array2[0].Substring(0, 1).ToLower();
			if (text11.CompareTo("c") < 0)
			{
				((ItemsControl)mnuShellCommandAB).get_Items().Add((object)val2);
			}
			else if (text11.CompareTo("f") < 0)
			{
				((ItemsControl)mnuShellCommandCDE).get_Items().Add((object)val2);
			}
			else if (text11.CompareTo("k") < 0)
			{
				((ItemsControl)mnuShellCommandFGHIJ).get_Items().Add((object)val2);
			}
			else if (text11.CompareTo("p") < 0)
			{
				((ItemsControl)mnuShellCommandKLMNO).get_Items().Add((object)val2);
			}
			else if (text11.CompareTo("s") < 0)
			{
				((ItemsControl)mnuShellCommandPQR).get_Items().Add((object)val2);
			}
			else if (text11.CompareTo("u") < 0)
			{
				((ItemsControl)mnuShellCommandST).get_Items().Add((object)val2);
			}
			else
			{
				((ItemsControl)mnuShellCommandUVWXYZ).get_Items().Add((object)val2);
			}
			((FrameworkElement)val2).set_Tag((object)array2[1]);
			val2.add_Click(new RoutedEventHandler(mnu_i_Click.Invoke));
		}
		((ItemsControl)mnuSysCpls).get_Items().Add((object)new Separator());
		val2 = executeControl("control", "Control 제어판");
		val2 = executeControl("control.exe System", "System 정보");
		val2 = executeControl("control.exe Admintools", "Admintools 관리도구");
		val2 = executeControl("control.exe Desktop", "Desktop 개인설정");
		val2 = executeControl("control.exe Folders", "Folders 폴더옵션");
		val2 = executeControl("control.exe Fonts", "Fonts 폰트설정");
		val2 = executeControl("control.exe Color", "Color 창 색 및 모양");
		val2 = executeControl("control.exe Mouse", "Mouse 마우스 등록정보");
		val2 = executeControl("control.exe Keyboard", "Keyboard 키보드 등록정보");
		val2 = executeControl("control.exe Netconnections", "Netconnections 네트워크연결");
		val2 = executeControl("control.exe Printers", "Printers 장치 및 프린터");
		val2 = executeControl("control.exe Schedtasks", "Schedtasks 작업 스케줄러");
		val2 = executeControl("control.exe Userpasswords", "Userpasswords 사용자 계정변경");
		val2 = executeControl("control.exe Userpasswords2", "Userpasswords2 사용자 계정");
		val2 = executeControl("UserAccountControlSettings", "UserAccountControlSettings 사용자 계정 컨트롤");
		val2 = executeControl("God Mode.{ED7BA470-8E54-465E-825C-99712043E01C}", "God Mode");
		string text12 = null;
		string environmentVariable = Environment.GetEnvironmentVariable("JRE_HOME");
		if (environmentVariable == null)
		{
			string environmentVariable2 = Environment.GetEnvironmentVariable("JAVA_HOME");
			if (environmentVariable2 != null)
			{
				text12 = environmentVariable2 + Utils.SEPA + "jre" + Utils.SEPA + "bin" + Utils.SEPA + "javacpl.exe";
			}
		}
		else
		{
			text12 = environmentVariable + Utils.SEPA + "bin" + Utils.SEPA + "javacpl.exe";
		}
		if (text12 != null && File.Exists(text12))
		{
			((ItemsControl)mnuSysCpls).get_Items().Add((object)new Separator());
			val2 = new MenuItem();
			((ItemsControl)mnuSysCpls).get_Items().Add((object)val2);
			((HeaderedItemsControl)val2).set_Header((object)("[" + Utils.onlyFileName(text12) + "]"));
			((FrameworkElement)val2).set_Tag((object)text12);
			val2.add_Click(new RoutedEventHandler(mnu_i_Click.Invoke));
		}
		string prop = null;
		if (!RegiHelperSrc.Instance.bAuth && -1 < RegiHelperSrc.Instance.StringPropertyGet(ref prop, "UAuthEmail").IndexOf("@"))
		{
			AutoClosingMessageBox.Show("트라이얼 사용 기한이 지났습니다." + Environment.NewLine + "인증이 필요합니다.", "PowerHealthChecker", 3100, 0);
		}
		if (RegiHelperSrc.Instance.bAuth && !RegiHelperSrc.Instance.VaccAllUInewed && !RegiHelperSrc.Instance.IsStrVaccineAllEntered)
		{
			RegiHelperSrc.Instance.NotifyPropertyChanged("StrVaccineAll");
		}
		if (RegiHelperSrc.Instance.bAuth && !RegiHelperSrc.Instance.ExistsEventLogParameter())
		{
			RegiHelperSrc.Instance.fixEventLogParameters();
		}
		AddHookProcedure();
	}

	private MenuItem executeControl(string exec, string title)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		MenuItem val = new MenuItem();
		((ItemsControl)mnuSysCpls).get_Items().Add((object)val);
		((FrameworkElement)val).set_Tag((object)exec);
		((HeaderedItemsControl)val).set_Header((object)title);
		val.add_Click(new RoutedEventHandler(mnu_i_Click.Invoke));
		return val;
	}

	private string getMyHash()
	{
		string text = "";
		FileInfo file = new FileInfo(Assembly.GetEntryAssembly()!.Location);
		return GetMD5(file).ToLower();
	}

	public static string GetMD5(FileInfo file)
	{
		if (!file.Exists)
		{
			throw new FileNotFoundException("File not found.", file.FullName);
		}
		byte[] buffer = File.ReadAllBytes(file.FullName);
		return GetMD5(buffer);
	}

	public static string GetMD5(byte[] buffer)
	{
		using MD5 mD = MD5.Create();
		byte[] ba = mD.ComputeHash(buffer);
		return ByteArrayToString(ba);
	}

	public static string ByteArrayToString(byte[] ba)
	{
		StringBuilder stringBuilder = new StringBuilder(ba.Length * 2);
		foreach (byte b in ba)
		{
			stringBuilder.AppendFormat("{0:x2}", b);
		}
		return stringBuilder.ToString();
	}

	private void webF_Navigated(object sender, WebBrowserNavigatedEventArgs e)
	{
		strWEBresult = webF[webF_idx].get_Document().get_Body().get_InnerHtml();
		webF[webF_idx].Stop();
		if (strWEBresult == null)
		{
			strWEBresult = "";
		}
	}

	private void webF_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
		strWEBresult = webF[webF_idx].get_DocumentText();
		webF[webF_idx].Stop();
		if (strWEBresult == null)
		{
			strWEBresult = "";
		}
	}

	private void webb_LoadCompleted(object sender, NavigationEventArgs e)
	{
		strWEBresult = ((IHTMLDocument2)webb.get_Document()).body.innerHTML;
		if (strWEBresult == null)
		{
			strWEBresult = "";
		}
	}

	private void getRegValueForMsra()
	{
		if (((ToggleButton)chkUsePrivMail).get_IsChecked() == true)
		{
			txtGmailID.set_Text(RegiHelperSrc.Instance.SavedGmailID);
			if (RegiHelperSrc.Instance.SavedMailPasswd != "")
			{
				try
				{
					txtGmailPass.set_Password(UtilCrypto.DecryptStringAES(RegiHelperSrc.Instance.SavedMailPasswd, GetMACAddress() + DateTime.Now.ToString("yyyy")));
				}
				catch (Exception)
				{
					txtGmailPass.set_Password("");
				}
			}
			else
			{
				txtGmailPass.set_Password("");
			}
			((ToggleButton)chkSave1).set_IsChecked((bool?)RegiHelperSrc.Instance.Saved1);
			((ToggleButton)chkSave2).set_IsChecked((bool?)RegiHelperSrc.Instance.Saved2);
			((UIElement)chkSave1).set_Visibility((Visibility)0);
			((UIElement)chkSave2).set_Visibility((Visibility)0);
			((UIElement)txtGmailID).set_IsEnabled(true);
			((UIElement)txtGmailPass).set_IsEnabled(true);
		}
		else
		{
			txtGmailID.set_Text("PowerHealthChecker");
			txtGmailPass.set_Password("tpsrlfarqotkvuxi");
			((UIElement)chkSave1).set_Visibility((Visibility)1);
			((UIElement)chkSave2).set_Visibility((Visibility)1);
			((UIElement)txtGmailID).set_IsEnabled(false);
			((UIElement)txtGmailPass).set_IsEnabled(false);
		}
	}

	private int getAllSubFiles(string p)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		int result = 0;
		DirectoryInfo directoryInfo = new DirectoryInfo(p);
		FileInfo[] array = null;
		try
		{
			array = directoryInfo.GetFiles();
		}
		catch (Exception ex)
		{
			string text = ex.Message + "\n" + directoryInfo;
			AutoClosingMessageBox.Show1(text, "PowerHealthChecker", 3100, 0);
			return 1;
		}
		DirectoryInfo[] directories = directoryInfo.GetDirectories();
		for (int i = 0; i < array.Count(); i++)
		{
			DeployFilesList.Add(idxFiles++, array[i].FullName);
		}
		for (int i = 0; i < directories.Count(); i++)
		{
			if (getAllSubFiles(directories[i].FullName) == 1)
			{
				result = 1;
				break;
			}
		}
		return result;
	}

	private void btnHealthCheck_Click(object sender, RoutedEventArgs e)
	{
		if (completedHealthCheck && !Utils.question("건강진단을 또 하시겠습니까?"))
		{
			return;
		}
		if (App.gVolumeSettingError)
		{
			App.SetVolume(App.gSoundVolume);
		}
		if (!RegiHelperSrc.Instance.bAuth)
		{
			RegiHelperSrc.Instance.ShowTrialUseGuide();
			return;
		}
		RegiHelperSrc.Instance.deleteRunOnceMy();
		if (RegiHelperSrc.Instance.Installed)
		{
			if ((!RegiHelperSrc.Instance.CheckedWndStarted || !RegiHelperSrc.Instance.CheckedAutoNetCloseStarted) && Utils.question("'자동실행' 및 '자동 공유 중지'를 실행하는 보안 옵션을 적용하시겠습니까?"))
			{
				RegiHelperSrc.Instance.CheckedWndStarted = true;
				RegiHelperSrc.Instance.CheckedAutoNetCloseStarted = true;
			}
			RegiHelperSrc.Instance.Installed = false;
		}
		if (0 < RegiHelperSrc.Instance.RegserveMsg.Length)
		{
			Utils.alert(RegiHelperSrc.Instance.RegserveMsg);
			RegiHelperSrc.Instance.RegserveMsg = "";
		}
		((UIElement)btnSaveLog).set_IsEnabled(false);
		((ContentControl)btnHealthCheck).set_Content((object)"진단중...");
		tBar.set_Foreground((Brush)(object)Brushes.get_Black());
		HealthCheckProcess(bAutoStartRun: false);
	}

	public void HealthCheckProcess(bool bAutoStartRun)
	{
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Invalid comparison between Unknown and I4
		//IL_06c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ce: Invalid comparison between Unknown and I4
		//IL_06da: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dd: Invalid comparison between Unknown and I4
		//IL_087e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c42: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c49: Expected O, but got Unknown
		//IL_1c4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c52: Expected O, but got Unknown
		//IL_1c6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c74: Expected O, but got Unknown
		//IL_204e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2055: Expected O, but got Unknown
		//IL_2057: Unknown result type (might be due to invalid IL or missing references)
		//IL_205e: Expected O, but got Unknown
		//IL_2079: Unknown result type (might be due to invalid IL or missing references)
		//IL_2080: Expected O, but got Unknown
		//IL_4dd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_4de0: Expected O, but got Unknown
		//IL_4e15: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_4edd: Unknown result type (might be due to invalid IL or missing references)
		//IL_12195: Unknown result type (might be due to invalid IL or missing references)
		//IL_121ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_122e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_12887: Unknown result type (might be due to invalid IL or missing references)
		if (!RegiHelperSrc.Instance.bAuth)
		{
			Application.get_Current().Shutdown();
			return;
		}
		if (App.IsAdministrator() && RegiHelperSrc.Instance.AutoW32TimeSynchChecked && RegiHelperSrc.Instance.RecentTimeSynchDateTime.CompareTo(DateTime.Now.AddDays(-14.0).ToString("yyyy-MM-dd HH:mm:ss")) < 0)
		{
			RegiHelperSrc.Instance.SetW32timeEnable(bShowStartGuide: false);
		}
		if (bAutoStartRun)
		{
			RegistryKey registryKey = null;
			registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Terminal Server\\WinStations\\RDP-Tcp");
			if (registryKey != null && !Utils.IsNotServerMachine())
			{
				int num = (int)registryKey.GetValue("PortNumber", 3389);
				Utils.ExecuteCommandSync("netsh advfirewall firewall add rule name=\"TCP" + num + "\" dir=in action=allow protocol=tcp localport=" + num + "  enable=yes");
			}
			string text = Utils.ExecuteCommandSync("tasklist /fi \"IMAGENAME eq PowerHealthChecker.exe\"");
			string[] arrStr = text.Replace("\n", "\r").Replace("\r\r", "\r").Split(new char[1] { '\r' });
			if (Utils.CheckOtherSession(arrStr, "PowerHealthChecker.exe"))
			{
				Application.get_Current().Shutdown();
				return;
			}
		}
		completedHealthCheck = true;
		string text2 = "";
		int num2 = 0;
		if (App.DictFileCheckSum == null)
		{
			App.DictFileCheckSum = new Dictionary<string, string>();
		}
		else
		{
			App.DictFileCheckSum.Clear();
		}
		try
		{
			string[] commandLineArgs = Environment.GetCommandLineArgs();
			if (commandLineArgs.Length > 1 && commandLineArgs[1] == "bg" && !((UIElement)this).get_IsVisible())
			{
				ShowOnHealthCheck();
			}
			if (itmListViewApproval.Count == 0)
			{
				bFirstItemListViewApprovalCntZero = true;
			}
			else
			{
				bFirstItemListViewApprovalCntZero = false;
			}
			cntOfApproval = 0;
			((Control)txtHealthReport).set_Background((Brush)(object)Brushes.get_WhiteSmoke());
			ListBeforeModifiedSHA = new List<string>();
			DictNewedModifedSHA = new Dictionary<string, string>();
			dictListOld.Clear();
			dictListNew.Clear();
			StringBuilder sb = new StringBuilder();
			int cnt = 0;
			bool flag = true;
			bool flag2 = false;
			string path = logPath + "lastCheckDate.txt";
			string path2 = logPath + "lastDeepCheckDate.txt";
			dictListNew = new Dictionary<string, string>();
			dictListOld = new Dictionary<string, string>();
			isErrorOccored = false;
			bTodayChecked = false;
			nowYYYYMMDD = DateTime.Now.ToString("yyyyMMdd");
			nowMMDD = DateTime.Now.ToString("MMdd");
			dtnow = DateTime.Now;
			dateDeep = dtnow.AddDays(-365.0);
			dateDeepAnalysis365 = dtnow.AddDays(-365.0);
			dateDeepAnalysis30 = dtnow.AddDays(-30.0);
			dateLatest = DateTime.Now;
			if (isMutex)
			{
				if ((int)MessageBox.Show("건강진단을 수행하고 있습니다.\n\n진행중인 건강진단을 취소하시겠습니까?", ((Window)this).get_Title(), (MessageBoxButton)4, (MessageBoxImage)48) == 6)
				{
					bCancelHealthCheck = true;
					((UIElement)btnSaveLog).set_IsEnabled(false);
				}
				return;
			}
			try
			{
				isMutex = true;
				bCancelHealthCheck = false;
				cntChildSample = 0;
				cntParentSample = 0L;
				string text3 = App.iniFile.ReadValue("CntParentAbout");
				if (text3 == "")
				{
					text3 = "0";
				}
				CntParentAbout = Convert.ToInt32(text3);
				logPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Utils.SEPA + "HealthChecker" + Utils.SEPA + "Log" + Utils.SEPA;
				if (!Directory.Exists(logPath))
				{
					Directory.CreateDirectory(logPath);
				}
				logFile = logPath + "TrustList.txt";
				checkFile = logPath + "CheckList.txt";
				logAnalysis = logPath + "Analysis.txt";
				string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
				string text4 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
				if (text4 == folderPath)
				{
					text4 = "";
				}
				if (Utils.FileExists(path2))
				{
					dateDeep = DateTime.ParseExact(File.ReadAllText(path2), "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None);
					File.Delete(path2);
				}
				if (App.iniFile.ReadValue("DateDeep") != "")
				{
					dateDeep = DateTime.ParseExact(App.iniFile.ReadValue("DateDeep"), "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None);
				}
				else
				{
					App.iniFile.WriteValue_UTF8("DateDeep", dateDeep.ToString("yyyyMMdd"));
				}
				if (Utils.FileExists(path))
				{
					dateLatest = DateTime.ParseExact(File.ReadAllText(path), "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None);
					File.Delete(path);
				}
				if (App.iniFile.ReadValue("LogDate") != "")
				{
					dateLatest = DateTime.ParseExact(App.iniFile.ReadValue("LogDate"), "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None);
				}
				else
				{
					App.iniFile.WriteValue_UTF8("LogDate", dateDeep.ToString("yyyyMMdd"));
					dateLatest = dateDeep;
				}
				RegiHelperSrc.Instance.NotifyPropertyChanged("IsOldVaccine36");
				if (dtnow.ToString("yyyyMMdd") != dateLatest.ToString("yyyyMMdd"))
				{
					bTodayChecked = false;
					dayFirst = true;
				}
				else
				{
					bTodayChecked = true;
				}
				bool flag3 = false;
				if (bAutoStartRun && bTodayChecked && flag3)
				{
					if (commandLineArgs.Length <= 1 || !(commandLineArgs[1] == "bg"))
					{
						return;
					}
					MP_ScheduleTaskDelete();
					Environment.Exit(0);
				}
				if (dtnow.Subtract(dateDeep).Days >= 365)
				{
					flag = true;
					deepCheckNeeded = true;
				}
				else
				{
					flag = false;
					deepCheckNeeded = false;
				}
				if (flag && commandLineArgs.Count() == 1)
				{
					MessageBoxResult val = MessageBox.Show("정밀 건강진단을 실시합니다. 몇(십)분정도 소요됩니다.[처음실행시 또는 1년마다 정밀진단 합니다.]", ((Window)this).get_Title(), (MessageBoxButton)3, (MessageBoxImage)48);
					if ((int)val == 6)
					{
						flag = true;
					}
					else
					{
						if ((int)val != 7)
						{
							return;
						}
						flag = false;
					}
				}
				string text5 = "";
				string text6 = "";
				string[] array = null;
				string[] array2 = null;
				if (Utils.FileExists(logFile))
				{
					File.Copy(logFile, logFile + "." + DateTime.Now.ToString("MMdd") + ".bak", overwrite: true);
					array = File.ReadAllLines(logFile);
					try
					{
						for (int i = 0; i < array.Count(); i++)
						{
							if (array[i].Trim().Length <= 0)
							{
								continue;
							}
							array2 = array[i].Split(new char[1] { '|' });
							if (2 > array2.Length)
							{
								continue;
							}
							int num3 = array2.Length - 1;
							for (int j = 0; j < num3; j++)
							{
								text5 = ((j != 0) ? (text5 + array2[j]) : array2[j]);
								if (j < num3 - 1)
								{
									text5 += "|";
								}
							}
							text6 = array2[num3];
							try
							{
								dictListOld.Add(text5.ToLower(), text6);
							}
							catch (Exception)
							{
							}
						}
					}
					catch (Exception ex2)
					{
						MessageBox.Show(ex2.Message + "\n" + text2 + "{" + num2 + "}", ((Window)this).get_Title(), (MessageBoxButton)0, (MessageBoxImage)48);
					}
				}
				if (Utils.FileExists(checkFile))
				{
					File.Copy(checkFile, checkFile + "." + DateTime.Now.ToString("MMdd") + ".bak", overwrite: true);
				}
				string[] array3 = RegiHelperSrc.Instance.ReadAllSection_Reg();
				string content = ((ContentControl)btnHealthCheck).get_Content().ToString();
				((ContentControl)btnHealthCheck).set_Content((object)"...");
				RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Command Processor", RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey2 != null)
				{
					if (registryKey2.GetValue("AutoRun", null) is string value)
					{
						registryKey2.DeleteValue("AutoRun");
						registryKey2.SetValue("AutoRun_bak", value);
						sb.Append("HKLM\\...\\Command Processor\\AutoRun -> AutoRun_bak로 조치하였습니다.\\r\\n");
					}
					registryKey2.Close();
				}
				registryKey2 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Command Processor", RegistryKeyPermissionCheck.ReadWriteSubTree);
				if (registryKey2 != null)
				{
					if (registryKey2.GetValue("AutoRun", null) is string value2)
					{
						registryKey2.DeleteValue("AutoRun");
						registryKey2.SetValue("AutoRun_bak", value2);
						sb.Append("HKCU\\...\\Command Processor\\AutoRun -> AutoRun_bak로 조치하였습니다.\\r\\n");
					}
					registryKey2.Close();
				}
				registryKey2 = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\996E.exe", writable: false);
				if (registryKey2 != null)
				{
					registryKey2.Close();
					registryKey2 = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options", RegistryKeyPermissionCheck.ReadWriteSubTree);
					registryKey2.DeleteSubKeyTree("996E.exe", throwOnMissingSubKey: false);
					sb.Append("HKCU\\...\\Image File Execution Options\\996E.exe 키를 지웠습니다.\\r\\n");
					registryKey2.Close();
				}
				for (int i = 0; i < array3.Length; i++)
				{
					if (i % 100 == 0)
					{
						Application.DoEvents();
						if (i % 200 == 0)
						{
							((ContentControl)btnHealthCheck).set_Content((object)"◐◐◐ ");
						}
						else
						{
							((ContentControl)btnHealthCheck).set_Content((object)" ◑◑◑");
						}
					}
					string text7 = RegiHelperSrc.Instance.ReadValue_Reg(array3[i], "Date");
					if (!(text7 != ""))
					{
						continue;
					}
					string text8 = RegiHelperSrc.Instance.ReadValue_Reg(array3[i], "YN");
					if (text8 == "Y")
					{
						string[] array4 = array3[i].Split(new char[1] { ',' });
						try
						{
							dictListOld.Add(array4[1].Replace("|", SEPA).ToLower(), array4[2] + "," + text7.Replace("-", ""));
						}
						catch (Exception)
						{
						}
					}
				}
				((ContentControl)btnHealthCheck).set_Content((object)content);
				text2 = strWindowsFolder;
				num2 = 10;
				DirectoryInfo directoryInfo = new DirectoryInfo(text2);
				FileInfo[] array5 = directoryInfo.GetFiles();
				txtHealthReport.set_Text("");
				AddParentPart(array5.Count());
				if (!bCancelHealthCheck)
				{
					for (int i = 0; i < array5.Count(); i++)
					{
						if (bCancelHealthCheck)
						{
							break;
						}
						tBar.set_Text(AddChildPartOne());
						Application.DoEvents();
						try
						{
							Application.DoEvents();
							string text9 = array5[i].Extension.ToLower();
							switch (text9)
							{
							default:
								if (text9 == ".json")
								{
									break;
								}
								goto end_IL_0bab;
							case ".exe":
							case ".dll":
							case ".ocx":
							case ".com":
							case ".scr":
							case ".pif":
							case ".npc":
								break;
							}
							string text10;
							if (!dictListOld.ContainsKey(array5[i].FullName.ToLower()))
							{
								if (!dictListNew.ContainsKey(array5[i].FullName))
								{
									text10 = App.FileCheckSum(array5[i].FullName);
									dictListNew.Add(array5[i].FullName, text10 + "," + nowYYYYMMDD);
									sb.Append("신규: " + array5[i].FullName);
									sb.Append("\r\n");
									sb.Append(text10);
									sb.Append("\r\n");
									sb.Append("\r\n");
									cnt++;
								}
								continue;
							}
							text10 = getNowCheckSumFast(flag, isFileOk: true, array5[i].FullName);
							string checkSum = getCheckSum(dictListOld[array5[i].FullName.ToLower()]);
							if (checkSum != text10)
							{
								try
								{
									dictListNew.Add(array5[i].FullName, text10 + "," + nowYYYYMMDD);
									ListBeforeModifiedSHA_Add(checkSum);
									sb.Append("변조: " + array5[i].FullName);
									sb.Append("\r\n");
									sb.Append(text10);
									sb.Append("\r\n");
									sb.Append("\r\n");
									cnt++;
									DictNewedModifedSHA.Add(checkSum, text10);
								}
								catch (ArgumentException)
								{
								}
							}
							else
							{
								try
								{
									dictListNew.Add(array5[i].FullName, dictListOld[array5[i].FullName.ToLower()]);
								}
								catch (ArgumentException)
								{
								}
							}
							end_IL_0bab:;
						}
						catch (Exception ex5)
						{
							strErrFilePath = "[1]" + array5[i].FullName;
							App.LogPut(ex5);
							isErrorOccored = true;
							break;
						}
					}
				}
				text2 = strWindowsFolder + Utils.SEPA + "system32";
				num2 = 20;
				directoryInfo = new DirectoryInfo(text2);
				if (!bCancelHealthCheck && directoryInfo != null)
				{
					dictListOld.Add(directoryInfo.FullName.ToLower(), "");
					array5 = directoryInfo.GetFiles();
					AddParentPart(array5.Count());
					if (!bCancelHealthCheck)
					{
						for (int i = 0; i < array5.Count(); i++)
						{
							if (bCancelHealthCheck)
							{
								break;
							}
							tBar.set_Text(AddChildPartOne());
							Application.DoEvents();
							try
							{
								string text9 = array5[i].Extension.ToLower();
								switch (text9)
								{
								default:
									if (text9 == ".pif")
									{
										break;
									}
									goto end_IL_0efd;
								case ".exe":
								case ".dll":
								case ".ocx":
								case ".com":
								case ".scr":
									break;
								}
								string text10;
								if (!dictListOld.ContainsKey(array5[i].FullName.ToLower()))
								{
									if (!dictListNew.ContainsKey(array5[i].FullName))
									{
										text10 = App.FileCheckSum(array5[i].FullName);
										dictListNew.Add(array5[i].FullName, text10 + "," + nowYYYYMMDD);
										sb.Append("신규: " + array5[i].FullName);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cnt++;
									}
									continue;
								}
								text10 = getNowCheckSumFast(flag, isFileOk: true, array5[i].FullName);
								string checkSum = getCheckSum(dictListOld[array5[i].FullName.ToLower()]);
								if (checkSum != text10)
								{
									try
									{
										dictListNew.Add(array5[i].FullName, text10 + "," + nowYYYYMMDD);
										ListBeforeModifiedSHA_Add(checkSum);
										sb.Append("변조: " + array5[i].FullName);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cnt++;
										DictNewedModifedSHA.Add(checkSum, text10);
									}
									catch (ArgumentException)
									{
									}
								}
								else
								{
									try
									{
										dictListNew.Add(array5[i].FullName, dictListOld[array5[i].FullName.ToLower()]);
									}
									catch (ArgumentException)
									{
									}
								}
								end_IL_0efd:;
							}
							catch (Exception ex5)
							{
								strErrFilePath = "[2]" + array5[i].FullName;
								App.LogPut(ex5);
								isErrorOccored = true;
								break;
							}
						}
					}
				}
				text2 = strWindowsFolder + Utils.SEPA + "system32" + Utils.SEPA + "DriverStore" + Utils.SEPA + "FileRepository";
				num2 = 30;
				directoryInfo = new DirectoryInfo(text2);
				if (!bCancelHealthCheck && directoryInfo != null)
				{
					dictListOld.Add(directoryInfo.FullName.ToLower(), "");
					DirectoryInfo[] directories = directoryInfo.GetDirectories();
					AddParentPart(directories.Count());
					if (!bCancelHealthCheck)
					{
						for (int k = 0; k < directories.Count(); k++)
						{
							array5 = directories[k].GetFiles();
							for (int i = 0; i < array5.Count(); i++)
							{
								if (bCancelHealthCheck)
								{
									break;
								}
								tBar.set_Text(AddChildPartOne());
								Application.DoEvents();
								try
								{
									string text9 = array5[i].Extension.ToLower();
									if (!(text9 == ".inf") && !(text9 == ".sys") && !(text9 == ".exe"))
									{
										continue;
									}
									string text10;
									if (!dictListOld.ContainsKey(array5[i].FullName.ToLower()))
									{
										if (!dictListNew.ContainsKey(array5[i].FullName))
										{
											text10 = App.FileCheckSum(array5[i].FullName);
											dictListNew.Add(array5[i].FullName, text10 + "," + nowYYYYMMDD);
											sb.Append("신규: " + array5[i].FullName);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
										}
										continue;
									}
									text10 = getNowCheckSumFast(flag, isFileOk: true, array5[i].FullName);
									string checkSum = getCheckSum(dictListOld[array5[i].FullName.ToLower()]);
									if (checkSum != text10)
									{
										try
										{
											dictListNew.Add(array5[i].FullName, text10 + "," + nowYYYYMMDD);
											ListBeforeModifiedSHA_Add(checkSum);
											sb.Append("변조: " + array5[i].FullName);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
											DictNewedModifedSHA.Add(checkSum, text10);
										}
										catch (ArgumentException)
										{
										}
									}
									else
									{
										try
										{
											dictListNew.Add(array5[i].FullName, dictListOld[array5[i].FullName.ToLower()]);
										}
										catch (ArgumentException)
										{
										}
									}
								}
								catch (Exception ex5)
								{
									strErrFilePath = "[2.1]" + array5[i].FullName;
									App.LogPut(ex5);
									isErrorOccored = true;
									break;
								}
							}
							if (isErrorOccored)
							{
								break;
							}
						}
					}
				}
				text2 = "C:\\Windows.old\\Windows" + Utils.SEPA + "system32" + Utils.SEPA + "DriverStore" + Utils.SEPA + "FileRepository";
				num2 = 40;
				directoryInfo = new DirectoryInfo(text2);
				if (!bCancelHealthCheck && directoryInfo != null && directoryInfo.Exists)
				{
					dictListOld.Add(directoryInfo.FullName.ToLower(), "");
					DirectoryInfo[] directories;
					try
					{
						directories = directoryInfo.GetDirectories();
					}
					catch (Exception ex)
					{
						Console.Error.WriteLine(ex.Message);
						Utils.ExecuteCommandSync("takeown /F " + directoryInfo.FullName + " /A");
						Thread.Sleep(500);
						directories = directoryInfo.GetDirectories();
					}
					AddParentPart(directories.Count());
					if (!bCancelHealthCheck)
					{
						for (int k = 0; k < directories.Count(); k++)
						{
							array5 = directories[k].GetFiles();
							for (int i = 0; i < array5.Count(); i++)
							{
								if (bCancelHealthCheck)
								{
									break;
								}
								tBar.set_Text(AddChildPartOne());
								Application.DoEvents();
								try
								{
									string text9 = array5[i].Extension.ToLower();
									if (!(text9 == ".inf") && !(text9 == ".sys") && !(text9 == ".exe"))
									{
										continue;
									}
									string text10;
									if (!dictListOld.ContainsKey(array5[i].FullName.ToLower()))
									{
										if (!dictListNew.ContainsKey(array5[i].FullName))
										{
											text10 = App.FileCheckSum(array5[i].FullName);
											dictListNew.Add(array5[i].FullName, text10 + "," + nowYYYYMMDD);
											sb.Append("신규: " + array5[i].FullName);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
										}
										continue;
									}
									text10 = getNowCheckSumFast(flag, isFileOk: true, array5[i].FullName);
									string checkSum = getCheckSum(dictListOld[array5[i].FullName.ToLower()]);
									if (checkSum != text10)
									{
										try
										{
											dictListNew.Add(array5[i].FullName, text10 + "," + nowYYYYMMDD);
											ListBeforeModifiedSHA_Add(checkSum);
											sb.Append("변조: " + array5[i].FullName);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
											DictNewedModifedSHA.Add(checkSum, text10);
										}
										catch (ArgumentException)
										{
										}
									}
									else
									{
										try
										{
											dictListNew.Add(array5[i].FullName, dictListOld[array5[i].FullName.ToLower()]);
										}
										catch (ArgumentException)
										{
										}
									}
								}
								catch (Exception ex5)
								{
									strErrFilePath = "[2.2]" + array5[i].FullName;
									App.LogPut(ex5);
									isErrorOccored = true;
									break;
								}
							}
							if (isErrorOccored)
							{
								break;
							}
						}
					}
				}
				text2 = strWindowsFolder + Utils.SEPA + "inf";
				num2 = 50;
				directoryInfo = new DirectoryInfo(text2);
				if (!bCancelHealthCheck && directoryInfo != null)
				{
					dictListOld.Add(directoryInfo.FullName.ToLower(), "");
					DirectoryInfo[] directories = directoryInfo.GetDirectories();
					AddParentPart(directories.Count());
					if (!bCancelHealthCheck)
					{
						for (int k = 0; k < directories.Count(); k++)
						{
							array5 = directories[k].GetFiles();
							for (int i = 0; i < array5.Count(); i++)
							{
								if (bCancelHealthCheck)
								{
									break;
								}
								tBar.set_Text(AddChildPartOne());
								Application.DoEvents();
								try
								{
									string text9 = array5[i].Extension.ToLower();
									if (!(text9 == ".inf") && !(text9 == ".pnf"))
									{
										continue;
									}
									string text10;
									if (!dictListOld.ContainsKey(array5[i].FullName.ToLower()))
									{
										if (!dictListNew.ContainsKey(array5[i].FullName))
										{
											text10 = App.FileCheckSum(array5[i].FullName);
											dictListNew.Add(array5[i].FullName, text10 + "," + nowYYYYMMDD);
											sb.Append("신규: " + array5[i].FullName);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
										}
										continue;
									}
									text10 = getNowCheckSumFast(flag, isFileOk: true, array5[i].FullName);
									string checkSum = getCheckSum(dictListOld[array5[i].FullName.ToLower()]);
									if (checkSum != text10)
									{
										try
										{
											dictListNew.Add(array5[i].FullName, text10 + "," + nowYYYYMMDD);
											ListBeforeModifiedSHA_Add(checkSum);
											sb.Append("변조: " + array5[i].FullName);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
											DictNewedModifedSHA.Add(checkSum, text10);
										}
										catch (ArgumentException)
										{
										}
									}
									else
									{
										try
										{
											dictListNew.Add(array5[i].FullName, dictListOld[array5[i].FullName.ToLower()]);
										}
										catch (ArgumentException)
										{
										}
									}
								}
								catch (Exception ex5)
								{
									strErrFilePath = "[2.3]" + array5[i].FullName;
									App.LogPut(ex5);
									isErrorOccored = true;
									break;
								}
							}
							if (isErrorOccored)
							{
								break;
							}
						}
					}
				}
				if (!bCancelHealthCheck && directoryInfo != null)
				{
					string environmentVariable = Environment.GetEnvironmentVariable("USERPROFILE");
					text2 = environmentVariable;
					num2 = 60;
					DirectoryInfo directoryInfo2 = new DirectoryInfo(text2);
					string fullName = directoryInfo2.Parent!.FullName;
					SelectQuery val2 = new SelectQuery("Win32_UserAccount");
					ManagementObjectSearcher val3 = new ManagementObjectSearcher((ObjectQuery)(object)val2);
					ManagementObjectEnumerator enumerator = val3.Get().GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							ManagementObject val4 = (ManagementObject)enumerator.get_Current();
							string text11 = string.Concat(fullName, Utils.SEPA, ((ManagementBaseObject)val4).get_Item("Name"), Utils.SEPA, "downloads");
							text2 = text11;
							num2 = 70;
							directoryInfo = new DirectoryInfo(text11);
							if (!Directory.Exists(text11) || bCancelHealthCheck || directoryInfo == null)
							{
								continue;
							}
							dictListOld.Add(directoryInfo.FullName.ToLower(), "");
							array5 = directoryInfo.GetFiles();
							AddParentPart(array5.Count());
							if (bCancelHealthCheck)
							{
								continue;
							}
							for (int i = 0; i < array5.Count(); i++)
							{
								if (bCancelHealthCheck)
								{
									break;
								}
								tBar.set_Text(AddChildPartOne());
								Application.DoEvents();
								try
								{
									string text9 = array5[i].Extension.ToLower();
									switch (text9)
									{
									default:
										if (text9 == ".npc")
										{
											break;
										}
										goto end_IL_1d4e;
									case ".exe":
									case ".dll":
									case ".ocx":
									case ".com":
									case ".scr":
									case ".pif":
										break;
									}
									string text10;
									if (!dictListOld.ContainsKey(array5[i].FullName.ToLower()))
									{
										if (!dictListNew.ContainsKey(array5[i].FullName))
										{
											text10 = App.FileCheckSum(array5[i].FullName);
											dictListNew.Add(array5[i].FullName, text10 + "," + nowYYYYMMDD);
											sb.Append("신규: " + array5[i].FullName);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
										}
										continue;
									}
									text10 = getNowCheckSumFast(flag, isFileOk: true, array5[i].FullName);
									string checkSum = getCheckSum(dictListOld[array5[i].FullName.ToLower()]);
									if (checkSum != text10)
									{
										try
										{
											dictListNew.Add(array5[i].FullName, text10 + "," + nowYYYYMMDD);
											ListBeforeModifiedSHA_Add(checkSum);
											sb.Append("변조: " + array5[i].FullName);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
											DictNewedModifedSHA.Add(checkSum, text10);
										}
										catch (ArgumentException)
										{
										}
									}
									else
									{
										try
										{
											dictListNew.Add(array5[i].FullName, dictListOld[array5[i].FullName.ToLower()]);
										}
										catch (ArgumentException)
										{
										}
									}
									end_IL_1d4e:;
								}
								catch (Exception ex5)
								{
									strErrFilePath = "[3]" + array5[i].FullName;
									App.LogPut(ex5);
									isErrorOccored = true;
									break;
								}
							}
						}
					}
					finally
					{
						((IDisposable)enumerator)?.Dispose();
					}
				}
				if (!bCancelHealthCheck && directoryInfo != null)
				{
					string environmentVariable = Environment.GetEnvironmentVariable("USERPROFILE");
					text2 = environmentVariable;
					num2 = 80;
					DirectoryInfo directoryInfo2 = new DirectoryInfo(text2);
					string fullName = directoryInfo2.Parent!.FullName;
					SelectQuery val2 = new SelectQuery("Win32_UserAccount");
					ManagementObjectSearcher val3 = new ManagementObjectSearcher((ObjectQuery)(object)val2);
					ManagementObjectEnumerator enumerator = val3.Get().GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							ManagementObject val4 = (ManagementObject)enumerator.get_Current();
							string text11 = string.Concat(fullName, Utils.SEPA, ((ManagementBaseObject)val4).get_Item("Name"), Utils.SEPA, "desktop");
							text2 = text11;
							num2 = 81;
							directoryInfo = new DirectoryInfo(text2);
							if (!Directory.Exists(text11) || bCancelHealthCheck || directoryInfo == null)
							{
								continue;
							}
							dictListOld.Add(directoryInfo.FullName.ToLower(), "");
							array5 = directoryInfo.GetFiles();
							AddParentPart(array5.Count());
							if (bCancelHealthCheck)
							{
								continue;
							}
							for (int i = 0; i < array5.Count(); i++)
							{
								if (bCancelHealthCheck)
								{
									break;
								}
								tBar.set_Text(AddChildPartOne());
								Application.DoEvents();
								try
								{
									string text9 = array5[i].Extension.ToLower();
									switch (text9)
									{
									default:
										if (text9 == ".npc")
										{
											break;
										}
										goto end_IL_215a;
									case ".exe":
									case ".dll":
									case ".ocx":
									case ".com":
									case ".scr":
									case ".pif":
										break;
									}
									string text10;
									if (!dictListOld.ContainsKey(array5[i].FullName.ToLower()))
									{
										if (!dictListNew.ContainsKey(array5[i].FullName))
										{
											text10 = App.FileCheckSum(array5[i].FullName);
											dictListNew.Add(array5[i].FullName, text10 + "," + nowYYYYMMDD);
											sb.Append("신규: " + array5[i].FullName);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
										}
										continue;
									}
									text10 = getNowCheckSumFast(flag, isFileOk: true, array5[i].FullName);
									string checkSum = getCheckSum(dictListOld[array5[i].FullName.ToLower()]);
									if (checkSum != text10)
									{
										try
										{
											dictListNew.Add(array5[i].FullName, text10 + "," + nowYYYYMMDD);
											ListBeforeModifiedSHA_Add(checkSum);
											sb.Append("변조: " + array5[i].FullName);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
											DictNewedModifedSHA.Add(checkSum, text10);
										}
										catch (ArgumentException)
										{
										}
									}
									else
									{
										try
										{
											dictListNew.Add(array5[i].FullName, dictListOld[array5[i].FullName.ToLower()]);
										}
										catch (ArgumentException)
										{
										}
									}
									end_IL_215a:;
								}
								catch (Exception ex5)
								{
									strErrFilePath = "[3.1]" + array5[i].FullName;
									App.LogPut(ex5);
									isErrorOccored = true;
									break;
								}
							}
						}
					}
					finally
					{
						((IDisposable)enumerator)?.Dispose();
					}
				}
				text2 = strWindowsFolder + Utils.SEPA + "Downloaded Program Files";
				num2 = 90;
				directoryInfo = new DirectoryInfo(text2);
				if (!bCancelHealthCheck && directoryInfo != null)
				{
					dictListOld.Add(directoryInfo.FullName.ToLower(), "");
					array5 = directoryInfo.GetFiles();
					AddParentPart(array5.Count());
					if (!bCancelHealthCheck)
					{
						for (int i = 0; i < array5.Count(); i++)
						{
							if (bCancelHealthCheck)
							{
								break;
							}
							tBar.set_Text(AddChildPartOne());
							Application.DoEvents();
							try
							{
								string text9 = array5[i].Extension.ToLower();
								switch (text9)
								{
								default:
									if (text9 == ".npc")
									{
										break;
									}
									goto end_IL_24b6;
								case ".exe":
								case ".dll":
								case ".ocx":
								case ".com":
								case ".scr":
								case ".pif":
									break;
								}
								string text10;
								if (!dictListOld.ContainsKey(array5[i].FullName.ToLower()))
								{
									if (!dictListNew.ContainsKey(array5[i].FullName))
									{
										text10 = App.FileCheckSum(array5[i].FullName);
										dictListNew.Add(array5[i].FullName, text10 + "," + nowYYYYMMDD);
										sb.Append("신규: " + array5[i].FullName);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cnt++;
									}
									continue;
								}
								text10 = getNowCheckSumFast(flag, isFileOk: true, array5[i].FullName);
								string checkSum = getCheckSum(dictListOld[array5[i].FullName.ToLower()]);
								if (checkSum != text10)
								{
									try
									{
										dictListNew.Add(array5[i].FullName, text10 + "," + nowYYYYMMDD);
										ListBeforeModifiedSHA_Add(checkSum);
										sb.Append("변조: " + array5[i].FullName);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cnt++;
										DictNewedModifedSHA.Add(checkSum, text10);
									}
									catch (ArgumentException)
									{
									}
								}
								else
								{
									try
									{
										dictListNew.Add(array5[i].FullName, dictListOld[array5[i].FullName.ToLower()]);
									}
									catch (ArgumentException)
									{
									}
								}
								end_IL_24b6:;
							}
							catch (Exception ex5)
							{
								strErrFilePath = "[3]" + array5[i].FullName;
								App.LogPut(ex5);
								isErrorOccored = true;
								break;
							}
						}
					}
				}
				text2 = folderPath;
				num2 = 100;
				directoryInfo = new DirectoryInfo(text2);
				if (!bCancelHealthCheck && directoryInfo != null)
				{
					string text12 = "";
					try
					{
						DirectoryInfo[] directories2 = directoryInfo.GetDirectories();
						if (!bCancelHealthCheck)
						{
							for (int l = 0; l < directories2.Length; l++)
							{
								if (bCancelHealthCheck)
								{
									break;
								}
								Application.DoEvents();
								text12 = directories2[l].FullName;
								if (text12 != null && text12.IndexOf(":" + Utils.SEPA) > -1)
								{
									if (!dictListOld.ContainsKey(("[Program]" + text12).ToLower()))
									{
										sb.Append("신규[Program]: " + text12);
										sb.Append("\r\n");
										sb.Append("");
										sb.Append("\r\n");
										sb.Append("\r\n");
										dictListOld.Add(("[Program]" + text12).ToLower(), "");
									}
									int depthFolderLimit = 3;
									int depthExeFileLimit = 100;
									AddProgramFiles(text12, ref sb, ref depthFolderLimit, ref depthExeFileLimit, ref cnt, x86: false);
								}
							}
						}
					}
					catch (Exception ex5)
					{
						strErrFilePath = "[5...]" + text12;
						App.LogPut(ex5);
						isErrorOccored = true;
					}
				}
				text2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
				num2 = 110;
				directoryInfo = new DirectoryInfo(text2);
				if (!bCancelHealthCheck && directoryInfo != null)
				{
					string text12 = "";
					try
					{
						directoryInfo = directoryInfo.Parent;
						DirectoryInfo[] directories2 = directoryInfo.GetDirectories();
						if (!bCancelHealthCheck)
						{
							for (int l = 0; l < directories2.Length; l++)
							{
								if (bCancelHealthCheck)
								{
									break;
								}
								Application.DoEvents();
								text12 = directories2[l].FullName;
								if (text12 != null && text12.IndexOf(":" + Utils.SEPA) > -1)
								{
									if (!dictListOld.ContainsKey(("[Program]" + text12).ToLower()))
									{
										sb.Append("신규[Program]: " + text12);
										sb.Append("\r\n");
										sb.Append("");
										sb.Append("\r\n");
										sb.Append("\r\n");
										dictListOld.Add(("[Program]" + text12).ToLower(), "");
									}
									int depthFolderLimit = 4;
									int depthExeFileLimit = 1000;
									AddProgramFiles(text12, ref sb, ref depthFolderLimit, ref depthExeFileLimit, ref cnt, x86: false);
								}
							}
						}
					}
					catch (Exception ex5)
					{
						strErrFilePath = "[5.1...]" + text12;
						App.LogPut(ex5);
						isErrorOccored = true;
					}
				}
				string[] array6 = Environment.GetEnvironmentVariable("Path")!.Split(new char[1] { ';' });
				for (int i = 0; i < array6.Count(); i++)
				{
					text2 = array6[i];
					num2 = 120;
					if (text2 == "")
					{
						continue;
					}
					directoryInfo = new DirectoryInfo(text2);
					if (bCancelHealthCheck || directoryInfo == null)
					{
						continue;
					}
					string text12 = "";
					try
					{
						text12 = directoryInfo.FullName;
						if (!dictListOld.ContainsKey(("[Program]" + text12).ToLower()))
						{
							sb.Append("신규[Program]: " + text12);
							sb.Append("\r\n");
							sb.Append("");
							sb.Append("\r\n");
							sb.Append("\r\n");
							cnt++;
							dictListOld.Add(("[Program]" + text12).ToLower(), "");
						}
						int depthFolderLimit = 1;
						int depthExeFileLimit = 100;
						AddProgramFiles(text12, ref sb, ref depthFolderLimit, ref depthExeFileLimit, ref cnt, x86: false);
						string text13 = text12.ToLower();
						if (!dictListNew.ContainsKey("[Program]" + text13))
						{
							dictListNew.Add("[Program]" + text13, "");
						}
					}
					catch (Exception ex5)
					{
						strErrFilePath = "[5.2...]" + text12;
						App.LogPut(ex5);
						isErrorOccored = true;
					}
				}
				if (!bCancelHealthCheck && text4 != "")
				{
					text2 = text4;
					num2 = 130;
					directoryInfo = new DirectoryInfo(text2);
					if (directoryInfo != null && text4 != "")
					{
						string text12 = "";
						try
						{
							DirectoryInfo[] directories2 = directoryInfo.GetDirectories();
							for (int l = 0; l < directories2.Length; l++)
							{
								Application.DoEvents();
								text12 = directories2[l].FullName;
								if (text12 != null && text12.IndexOf(":" + Utils.SEPA) > -1)
								{
									if (!dictListOld.ContainsKey(("[ProgramX86]" + text12).ToLower()))
									{
										sb.Append("신규[ProgramX86]: " + text12);
										sb.Append("\r\n");
										sb.Append("");
										sb.Append("\r\n");
										sb.Append("\r\n");
										dictListOld.Add(("[ProgramX86]" + text12).ToLower(), "");
									}
									int depthFolderLimit = 3;
									int depthExeFileLimit = 100;
									AddProgramFiles(text12, ref sb, ref depthFolderLimit, ref depthExeFileLimit, ref cnt, x86: true);
								}
							}
						}
						catch (Exception ex5)
						{
							strErrFilePath = "[6...]" + text12;
							App.LogPut(ex5);
							isErrorOccored = true;
						}
					}
				}
				if (!bCancelHealthCheck)
				{
					string text12 = Environment.GetEnvironmentVariable("Path");
					if (!dictListOld.ContainsKey("[path]" + text12.ToLower()))
					{
						string text14 = printKeyStartsWith(dictListOld, "[path]");
						string text10 = App.StringCheckSum(text12.ToLower());
						string text15 = "[path]" + text12.ToLower();
						if (!dictListNew.ContainsKey(text15))
						{
							dictListNew.Add(text15, text10 + "," + nowYYYYMMDD);
							if (0 < text14.Length)
							{
								sb.Append("변조: " + text15);
								sb.Append("\r\n");
								sb.Append(text10);
								sb.Append("\r\n");
								sb.Append("# old_path:" + text14);
								sb.Append("\r\n");
								sb.Append("\r\n");
							}
							cnt++;
						}
					}
					pathes = null;
					pathes = text12.Split(new char[1] { ';' });
					bool flag4 = false;
					bool flag5 = false;
					if (Environment.Is64BitOperatingSystem)
					{
						flag5 = true;
					}
					AddParentPart(pathes.Count());
					for (int m = 0; m < pathes.Count() && !bCancelHealthCheck; m++)
					{
						tBar.set_Text(AddChildPartOne());
						Application.DoEvents();
						string text16;
						try
						{
							text2 = pathes[m];
							num2 = 140;
							if (text2 == "")
							{
								continue;
							}
							text16 = new DirectoryInfo(text2).FullName.ToLower();
							goto IL_2f37;
						}
						catch (ArgumentException)
						{
							serviceMsg = "#path환경변수의 경로의 형식이 잘못되었습니다. C:\\WINDOWS\\system32\\systempropertiesadvanced.exe > [환경변수]에서 확인가능\r\n";
							m++;
						}
						continue;
						IL_2f37:
						if (Environment.Is64BitOperatingSystem && !flag4 && text16 == (strWindowsFolder + Utils.SEPA + "SysWOW64").ToLower())
						{
							flag5 = false;
							flag4 = true;
						}
						if (text16 != strWindowsFolder.ToLower() && text16 != (strWindowsFolder + Utils.SEPA + "System32").ToLower() && text16 != (strWindowsFolder + Utils.SEPA + "Downloaded Program Files").ToLower())
						{
							text2 = pathes[m];
							num2 = 150;
							directoryInfo = new DirectoryInfo(text2);
							if (directoryInfo != null)
							{
								try
								{
									try
									{
										dictListOld.Add(pathes[m].ToLower(), getCheckSum(pathes[m].ToLower()));
									}
									catch (Exception)
									{
									}
									array5 = directoryInfo.GetFiles();
									if (!directoryInfo.Exists)
									{
										serviceMsg = serviceMsg + "#path환경변수의 경로에 존재하지 않는 경로가 있습니다.[" + pathes[m] + "]\r\n";
									}
									AddParentPart(array5.Count());
									for (int i = 0; i < array5.Count(); i++)
									{
										if (bCancelHealthCheck)
										{
											break;
										}
										tBar.set_Text(AddChildPartOne());
										Application.DoEvents();
										string text9 = array5[i].Extension.ToLower();
										try
										{
											if (array5[i].FullName == "C:\\Program Files\\Wizvera\\Delfino\\DelfinoUAC.exe")
											{
												strErrFilePath = "C:\\Program Files\\Wizvera\\Delfino\\DelfinoUAC.exe";
											}
											switch (text9)
											{
											default:
												if (text9 == ".npc")
												{
													break;
												}
												goto end_IL_30b4;
											case ".exe":
											case ".com":
											case ".scr":
											case ".pif":
												break;
											}
											string text10;
											if (!dictListOld.ContainsKey(array5[i].FullName.ToLower()))
											{
												if (!dictListNew.ContainsKey(array5[i].FullName))
												{
													text10 = App.FileCheckSum(array5[i].FullName);
													dictListNew.Add(array5[i].FullName, text10 + "," + nowYYYYMMDD);
													sb.Append("신규: " + array5[i].FullName);
													sb.Append("\r\n");
													sb.Append(text10);
													sb.Append("\r\n");
													sb.Append("\r\n");
													cnt++;
												}
												continue;
											}
											text10 = getNowCheckSumFast(flag, isFileOk: true, array5[i].FullName);
											string checkSum = getCheckSum(dictListOld[array5[i].FullName.ToLower()]);
											if (checkSum != text10)
											{
												try
												{
													dictListNew.Add(array5[i].FullName, text10 + "," + nowYYYYMMDD);
													ListBeforeModifiedSHA_Add(checkSum);
													sb.Append("변조: " + array5[i].FullName);
													sb.Append("\r\n");
													sb.Append(text10);
													sb.Append("\r\n");
													sb.Append("\r\n");
													cnt++;
													DictNewedModifedSHA.Add(checkSum, text10);
												}
												catch (ArgumentException)
												{
												}
											}
											else
											{
												try
												{
													dictListNew.Add(array5[i].FullName, dictListOld[array5[i].FullName.ToLower()]);
												}
												catch (ArgumentException)
												{
												}
											}
											end_IL_30b4:;
										}
										catch (Exception ex5)
										{
											strErrFilePath = "[7...]" + array5[i].FullName;
											App.LogPut(ex5);
											isErrorOccored = true;
											Utils.File_secure(array5[i].FullName, secure: true, byUser: false);
										}
									}
								}
								catch (Exception)
								{
									continue;
								}
							}
						}
						if (flag5 && m == pathes.Count() - 1)
						{
							pathes[pathes.Count() - 1] = strWindowsFolder + Utils.SEPA + "SysWOW64";
							m--;
						}
					}
				}
				if (!bCancelHealthCheck)
				{
					array5 = Utils.strToFileInfoes(Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Startup), "*.lnk"));
					AddParentPart(array5.Count());
					for (int i = 0; i < array5.Count(); i++)
					{
						if (bCancelHealthCheck)
						{
							break;
						}
						tBar.set_Text(AddChildPartOne());
						Application.DoEvents();
						try
						{
							string text9 = array5[i].Extension.ToLower();
							string text10;
							if (!dictListOld.ContainsKey(array5[i].FullName.ToLower()))
							{
								if (!dictListNew.ContainsKey(array5[i].FullName))
								{
									text10 = App.FileCheckSum(array5[i].FullName);
									dictListNew.Add(array5[i].FullName, text10 + "," + nowYYYYMMDD);
									sb.Append("신규: " + array5[i].FullName);
									sb.Append("\r\n");
									sb.Append(text10);
									sb.Append("\r\n");
									sb.Append("\r\n");
									cnt++;
								}
								try
								{
									text10 = App.FileCheckSum(array5[i].FullName);
									dictListNew.Add(array5[i].FullName, text10 + "," + nowYYYYMMDD);
									string text17 = "SU," + array5[i].FullName + "," + text10;
									if (!isApproval(text17).HasValue && !dictApprovalList.ContainsKey(text17.ToLower()))
									{
										sb.Append("미승인[StartUser]: " + array5[i].FullName);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cntOfApproval++;
										itmListViewApproval.Add(ApprovalList.GetOrCreate(text17));
										dictApprovalList.Add(text17.ToLower(), text10);
									}
								}
								catch (ArgumentException)
								{
								}
								continue;
							}
							text10 = getNowCheckSumFast(flag, isFileOk: true, array5[i].FullName);
							string checkSum = getCheckSum(dictListOld[array5[i].FullName.ToLower()]);
							if (checkSum != text10)
							{
								try
								{
									dictListNew.Add(array5[i].FullName, text10 + "," + nowYYYYMMDD);
									ListBeforeModifiedSHA_Add(checkSum);
									sb.Append("변조: " + array5[i].FullName);
									sb.Append("\r\n");
									sb.Append(text10);
									sb.Append("\r\n");
									sb.Append("\r\n");
									cnt++;
									DictNewedModifedSHA.Add(checkSum, text10);
								}
								catch (ArgumentException)
								{
								}
								continue;
							}
							try
							{
								dictListNew.Add(array5[i].FullName, dictListOld[array5[i].FullName.ToLower()]);
								text10 = App.FileCheckSum(array5[i].FullName);
								string text17 = "SU," + array5[i].FullName + "," + text10;
								if (!isApproval(text17).HasValue && !dictApprovalList.ContainsKey(text17.ToLower()))
								{
									sb.Append("미승인[StartUser]: " + array5[i].FullName);
									sb.Append("\r\n");
									sb.Append(text10);
									sb.Append("\r\n");
									sb.Append("\r\n");
									cntOfApproval++;
									itmListViewApproval.Add(ApprovalList.GetOrCreate(text17));
									dictApprovalList.Add(text17.ToLower(), text10);
								}
							}
							catch (ArgumentException)
							{
							}
						}
						catch (Exception ex5)
						{
							strErrFilePath = "[8]" + array5[i].FullName;
							App.LogPut(ex5);
							isErrorOccored = true;
							break;
						}
					}
				}
				if (!bCancelHealthCheck)
				{
					array5 = Utils.strToFileInfoes(Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup), "*.lnk"));
					AddParentPart(array5.Count());
					if (!bCancelHealthCheck)
					{
						for (int i = 0; i < array5.Count(); i++)
						{
							if (bCancelHealthCheck)
							{
								break;
							}
							tBar.set_Text(AddChildPartOne());
							Application.DoEvents();
							try
							{
								string text9 = array5[i].Extension.ToLower();
								string text10;
								if (!dictListOld.ContainsKey(array5[i].FullName.ToLower()))
								{
									if (!dictListNew.ContainsKey(array5[i].FullName))
									{
										text10 = App.FileCheckSum(array5[i].FullName);
										dictListNew.Add(array5[i].FullName, text10 + "," + nowYYYYMMDD);
										sb.Append("신규: " + array5[i].FullName);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cnt++;
									}
									try
									{
										text10 = App.FileCheckSum(array5[i].FullName);
										dictListNew.Add(array5[i].FullName, text10 + "," + nowYYYYMMDD);
										string text17 = "SC," + array5[i].FullName + "," + text10;
										if (!isApproval(text17).HasValue && !dictApprovalList.ContainsKey(text17.ToLower()))
										{
											sb.Append("미승인[StartCommon]: " + array5[i].FullName);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cntOfApproval++;
											itmListViewApproval.Add(ApprovalList.GetOrCreate(text17));
											dictApprovalList.Add(text17.ToLower(), text10);
										}
									}
									catch (ArgumentException)
									{
									}
									continue;
								}
								text10 = getNowCheckSumFast(flag, isFileOk: true, array5[i].FullName);
								string checkSum = getCheckSum(dictListOld[array5[i].FullName.ToLower()]);
								if (checkSum != text10)
								{
									try
									{
										dictListNew.Add(array5[i].FullName, text10 + "," + nowYYYYMMDD);
										ListBeforeModifiedSHA_Add(checkSum);
										sb.Append("변조: " + array5[i].FullName);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cnt++;
										DictNewedModifedSHA.Add(checkSum, text10);
									}
									catch (ArgumentException)
									{
									}
									continue;
								}
								try
								{
									dictListNew.Add(array5[i].FullName, dictListOld[array5[i].FullName.ToLower()]);
									text10 = App.FileCheckSum(array5[i].FullName);
									string text17 = "SC," + array5[i].FullName + "," + text10;
									if (!isApproval(text17).HasValue && !dictApprovalList.ContainsKey(text17.ToLower()))
									{
										sb.Append("미승인[StartCommon]: " + array5[i].FullName);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cntOfApproval++;
										itmListViewApproval.Add(ApprovalList.GetOrCreate(text17));
										dictApprovalList.Add(text17.ToLower(), text10);
									}
								}
								catch (ArgumentException)
								{
								}
							}
							catch (Exception ex5)
							{
								strErrFilePath = "[9]" + array5[i].FullName;
								App.LogPut(ex5);
								isErrorOccored = true;
								break;
							}
						}
					}
				}
				if (!bCancelHealthCheck)
				{
					text2 = Environment.GetEnvironmentVariable("temp");
					num2 = 160;
					directoryInfo = new DirectoryInfo(text2);
					string[] array7 = new string[6] { "*.com", "*.exe", "*.scr", "*.js", "*.vbs", "*.TMP" };
					for (int n = 0; n < array7.Count(); n++)
					{
						array5 = directoryInfo.GetFiles(array7[n]);
						AddParentPart(array5.Count());
						if (bCancelHealthCheck)
						{
							continue;
						}
						for (int i = 0; i < array5.Count(); i++)
						{
							if (bCancelHealthCheck)
							{
								break;
							}
							tBar.set_Text(AddChildPartOne());
							Application.DoEvents();
							try
							{
								string text9 = array5[i].Extension.ToLower();
								if (text9 == ".tmp")
								{
									try
									{
										if (-1 < array5[i].FullName.IndexOf("~DF"))
										{
											File.Delete(array5[i].FullName);
											Application.DoEvents();
											if (!File.Exists(array5[i].FullName))
											{
												sb.Append("임시 파일 삭제: " + array5[i].FullName);
												sb.Append("\r\n");
											}
										}
									}
									catch (Exception)
									{
									}
									continue;
								}
								string text10;
								if (!dictListOld.ContainsKey(array5[i].FullName.ToLower()))
								{
									if (!dictListNew.ContainsKey(array5[i].FullName))
									{
										text10 = App.FileCheckSum(array5[i].FullName);
										dictListNew.Add(array5[i].FullName, text10 + "," + nowYYYYMMDD);
										sb.Append("신규: " + array5[i].FullName);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cnt++;
									}
									continue;
								}
								text10 = getNowCheckSumFast(flag, isFileOk: true, array5[i].FullName);
								string checkSum = getCheckSum(dictListOld[array5[i].FullName.ToLower()]);
								if (checkSum != text10)
								{
									try
									{
										dictListNew.Add(array5[i].FullName, text10 + "," + nowYYYYMMDD);
										ListBeforeModifiedSHA_Add(checkSum);
										sb.Append("변조: " + array5[i].FullName);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cnt++;
										DictNewedModifedSHA.Add(checkSum, text10);
									}
									catch (ArgumentException)
									{
									}
								}
								else
								{
									try
									{
										dictListNew.Add(array5[i].FullName, dictListOld[array5[i].FullName.ToLower()]);
									}
									catch (ArgumentException)
									{
									}
								}
							}
							catch (Exception ex5)
							{
								strErrFilePath = "[10]" + array5[i].FullName;
								App.LogPut(ex5);
								isErrorOccored = true;
								break;
							}
						}
					}
				}
				if (!bCancelHealthCheck)
				{
					text2 = Environment.GetEnvironmentVariable("temp");
					num2 = 170;
					directoryInfo = new DirectoryInfo(text2);
					directoryInfo = directoryInfo.Parent;
					string[] array7 = new string[5] { "*.com", "*.exe", "*.scr", "*.js", "*.vbs" };
					for (int n = 0; n < array7.Count(); n++)
					{
						array5 = directoryInfo.GetFiles(array7[n]);
						AddParentPart(array5.Count());
						if (bCancelHealthCheck)
						{
							continue;
						}
						for (int i = 0; i < array5.Count(); i++)
						{
							if (bCancelHealthCheck)
							{
								break;
							}
							tBar.set_Text(AddChildPartOne());
							Application.DoEvents();
							try
							{
								string text9 = array5[i].Extension.ToLower();
								string text10;
								if (!dictListOld.ContainsKey(array5[i].FullName.ToLower()))
								{
									if (!dictListNew.ContainsKey(array5[i].FullName))
									{
										text10 = App.FileCheckSum(array5[i].FullName);
										dictListNew.Add(array5[i].FullName, text10 + "," + nowYYYYMMDD);
										sb.Append("신규: " + array5[i].FullName);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cnt++;
									}
									continue;
								}
								text10 = getNowCheckSumFast(flag, isFileOk: true, array5[i].FullName);
								string checkSum = getCheckSum(dictListOld[array5[i].FullName.ToLower()]);
								if (checkSum != text10)
								{
									try
									{
										dictListNew.Add(array5[i].FullName, text10 + "," + nowYYYYMMDD);
										ListBeforeModifiedSHA_Add(checkSum);
										sb.Append("변조: " + array5[i].FullName);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cnt++;
										DictNewedModifedSHA.Add(checkSum, text10);
									}
									catch (ArgumentException)
									{
									}
								}
								else
								{
									try
									{
										dictListNew.Add(array5[i].FullName, dictListOld[array5[i].FullName.ToLower()]);
									}
									catch (ArgumentException)
									{
									}
								}
							}
							catch (Exception ex5)
							{
								strErrFilePath = "[10.1]" + array5[i].FullName;
								App.LogPut(ex5);
								isErrorOccored = true;
								break;
							}
						}
					}
				}
				if (!bCancelHealthCheck)
				{
					text2 = replaceNormalizePath("%windir%\\temp");
					num2 = 180;
					directoryInfo = new DirectoryInfo(text2);
					string[] array7 = new string[7] { "*.com", "*.exe", "*.scr", "*.js", "*.dll", "*.ocx", "*.vbs" };
					for (int n = 0; n < array7.Count(); n++)
					{
						array5 = directoryInfo.GetFiles(array7[n]);
						AddParentPart(array5.Count());
						if (bCancelHealthCheck)
						{
							continue;
						}
						for (int i = 0; i < array5.Count(); i++)
						{
							if (bCancelHealthCheck)
							{
								break;
							}
							tBar.set_Text(AddChildPartOne());
							Application.DoEvents();
							try
							{
								string text9 = array5[i].Extension.ToLower();
								string text10;
								if (!dictListOld.ContainsKey(array5[i].FullName.ToLower()))
								{
									if (!dictListNew.ContainsKey(array5[i].FullName))
									{
										text10 = App.FileCheckSum(array5[i].FullName);
										dictListNew.Add(array5[i].FullName, text10 + "," + nowYYYYMMDD);
										sb.Append("신규: " + array5[i].FullName);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cnt++;
									}
									continue;
								}
								text10 = getNowCheckSumFast(flag, isFileOk: true, array5[i].FullName);
								string checkSum = getCheckSum(dictListOld[array5[i].FullName.ToLower()]);
								if (checkSum != text10)
								{
									try
									{
										dictListNew.Add(array5[i].FullName, text10 + "," + nowYYYYMMDD);
										ListBeforeModifiedSHA_Add(checkSum);
										sb.Append("변조: " + array5[i].FullName);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cnt++;
										DictNewedModifedSHA.Add(checkSum, text10);
									}
									catch (ArgumentException)
									{
									}
								}
								else
								{
									try
									{
										dictListNew.Add(array5[i].FullName, dictListOld[array5[i].FullName.ToLower()]);
									}
									catch (ArgumentException)
									{
									}
								}
							}
							catch (Exception ex5)
							{
								strErrFilePath = "[11]" + array5[i].FullName;
								App.LogPut(ex5);
								isErrorOccored = true;
								break;
							}
						}
					}
				}
				if (!bCancelHealthCheck)
				{
					Process[] processes = Process.GetProcesses();
					array5 = processToFileInfoes(processes);
					if (!bCancelHealthCheck)
					{
						for (int i = 0; i < array5.Count(); i++)
						{
							if (bCancelHealthCheck)
							{
								break;
							}
							tBar.set_Text(AddChildPartOne());
							Application.DoEvents();
							try
							{
								string text9 = array5[i].Extension.ToLower();
								string text10;
								if (!dictListOld.ContainsKey(array5[i].FullName.ToLower()))
								{
									if (!dictListNew.ContainsKey(array5[i].FullName))
									{
										text10 = App.FileCheckSum(array5[i].FullName);
										dictListNew.Add(array5[i].FullName, text10 + "," + nowYYYYMMDD);
										sb.Append("신규[Process]: " + array5[i].FullName);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cnt++;
									}
									try
									{
										text10 = App.FileCheckSum(array5[i].FullName);
										dictListNew.Add(array5[i].FullName, text10 + "," + nowYYYYMMDD);
										string text17 = "P," + array5[i].FullName + "," + text10;
										if (!isApproval(text17).HasValue && !dictApprovalList.ContainsKey(text17.ToLower()))
										{
											sb.Append("미승인[Process]: " + array5[i].FullName);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cntOfApproval++;
											itmListViewApproval.Add(ApprovalList.GetOrCreate(text17));
											dictApprovalList.Add(text17.ToLower(), text10);
										}
									}
									catch (ArgumentException)
									{
									}
									continue;
								}
								text10 = getNowCheckSumFast(flag, isFileOk: true, array5[i].FullName);
								string checkSum = getCheckSum(dictListOld[array5[i].FullName.ToLower()]);
								if (checkSum != text10)
								{
									try
									{
										dictListNew.Add(array5[i].FullName, text10 + "," + nowYYYYMMDD);
										ListBeforeModifiedSHA_Add(checkSum);
										sb.Append("변조[Process]: " + array5[i].FullName);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cnt++;
										DictNewedModifedSHA.Add(checkSum, text10);
									}
									catch (ArgumentException)
									{
									}
									continue;
								}
								try
								{
									dictListNew.Add(array5[i].FullName, dictListOld[array5[i].FullName.ToLower()]);
									text10 = App.FileCheckSum(array5[i].FullName);
									string text17 = "P," + array5[i].FullName + "," + text10;
									if (!isApproval(text17).HasValue && !dictApprovalList.ContainsKey(text17.ToLower()))
									{
										sb.Append("미승인[Process]: " + array5[i].FullName);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cntOfApproval++;
										itmListViewApproval.Add(ApprovalList.GetOrCreate(text17));
										dictApprovalList.Add(text17.ToLower(), text10);
									}
								}
								catch (ArgumentException)
								{
								}
							}
							catch (Exception ex5)
							{
								strErrFilePath = "[12]" + array5[i].FullName;
								App.LogPut(ex5);
								isErrorOccored = true;
								break;
							}
						}
					}
				}
				if (!bCancelHealthCheck)
				{
					text2 = strWindowsFolder + Utils.SEPA + "Tasks";
					num2 = 190;
					directoryInfo = new DirectoryInfo(text2);
					array5 = directoryInfo.GetFiles();
					AddParentPart(array5.Count());
					if (!bCancelHealthCheck)
					{
						for (int i = 0; i < array5.Count(); i++)
						{
							if (bCancelHealthCheck)
							{
								break;
							}
							tBar.set_Text(AddChildPartOne());
							Application.DoEvents();
							try
							{
								string text9 = array5[i].Extension.ToLower();
								if (!(text9 == ".job"))
								{
									continue;
								}
								string text10;
								if (!dictListOld.ContainsKey(array5[i].FullName.ToLower()))
								{
									if (!dictListNew.ContainsKey(array5[i].FullName))
									{
										text10 = App.FileCheckSum(array5[i].FullName);
										dictListNew.Add(array5[i].FullName, text10 + "," + nowYYYYMMDD);
										sb.Append("신규: " + array5[i].FullName);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cnt++;
									}
									continue;
								}
								text10 = getNowCheckSumFast(flag, isFileOk: true, array5[i].FullName);
								string checkSum = getCheckSum(dictListOld[array5[i].FullName.ToLower()]);
								if (checkSum != text10)
								{
									try
									{
										dictListNew.Add(array5[i].FullName, text10 + "," + nowYYYYMMDD);
										ListBeforeModifiedSHA_Add(checkSum);
										sb.Append("변조: " + array5[i].FullName);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cnt++;
										DictNewedModifedSHA.Add(checkSum, text10);
									}
									catch (ArgumentException)
									{
									}
								}
								else
								{
									try
									{
										dictListNew.Add(array5[i].FullName, dictListOld[array5[i].FullName.ToLower()]);
									}
									catch (ArgumentException)
									{
									}
								}
							}
							catch (Exception ex5)
							{
								strErrFilePath = "[13]" + array5[i].FullName;
								App.LogPut(ex5);
								isErrorOccored = true;
								break;
							}
						}
					}
				}
				if (!bCancelHealthCheck)
				{
					try
					{
						if (Utils.Is64OS())
						{
							RegistryKey registryKey3 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
							registryKey3.DeleteSubKeyTree("SYSTEM\\CurrentControlSet\\services\\eventlog\\Parameters");
						}
						else
						{
							Registry.LocalMachine.DeleteSubKeyTree("SYSTEM\\CurrentControlSet\\services\\eventlog\\Parameters");
						}
						flag2 = true;
					}
					catch (ArgumentException)
					{
					}
					TaskService val5 = new TaskService();
					try
					{
						Regex regex = new Regex("^[^$]*", RegexOptions.IgnoreCase);
						Task[] array8 = null;
						try
						{
							array8 = val5.FindAllTasks(regex, true);
						}
						catch (Exception)
						{
							if (flag2)
							{
								MessageBox.Show("[알림]\n작업스케줄이 중지 상태입니다. 시스템 재시작을 권장합니다.", ((Window)this).get_Title(), (MessageBoxButton)0, (MessageBoxImage)48);
							}
							else
							{
								MessageBox.Show("[알림]\n작업스케줄이 중지 상태입니다.", ((Window)this).get_Title(), (MessageBoxButton)0, (MessageBoxImage)48);
							}
						}
						AddParentPart(array8.Count());
						if (!bCancelHealthCheck)
						{
							Console.WriteLine("[TASK Start]");
						}
						int i = 0;
						while (array8 != null && i < array8.Count() && !bCancelHealthCheck)
						{
							tBar.set_Text(AddChildPartOne());
							Application.DoEvents();
							Task val6 = array8[i];
							try
							{
								if (val6.get_Enabled())
								{
									Console.WriteLine(val6.get_Name());
									string text12 = null;
									if (((IEnumerable<Action>)val6.get_Definition().get_Actions()).First() is ExecAction)
									{
										string path3 = ((ExecAction)((IEnumerable<Action>)val6.get_Definition().get_Actions()).First()).get_Path();
										text12 = replaceNormalizePath(path3);
										Console.WriteLine(" >" + text12);
										if (text12.IndexOf(Utils.SEPA) == -1)
										{
											text12 = replacePathesPath(text12);
										}
										if (text12.IndexOf(Utils.SEPA) > -1)
										{
											if (val6.get_Name() == "MP Scheduled Scan" || val6.get_Name() == "MpIdleTask")
											{
												val6.set_Enabled(false);
											}
											else if (!dictListOld.ContainsKey(("[JOB]" + val6.get_Path() + " " + ((object)val6.get_Definition().get_Actions()).ToString()).ToLower()))
											{
												string text18 = replaceNormalizePath(((object)val6.get_Definition().get_Actions()).ToString());
												string text10 = (Utils.FileExists(text18) ? App.FileCheckSum(text18) : ((!Utils.FileExists(text12)) ? App.StringCheckSum(("[JOB]" + val6.get_Path() + " " + ((object)val6.get_Definition().get_Actions()).ToString()).ToLower()) : App.FileCheckSum(text12)));
												string text15 = "[JOB]" + val6.get_Path() + " " + ((object)val6.get_Definition().get_Actions()).ToString();
												if (!dictListNew.ContainsKey(text15))
												{
													dictListNew.Add(text15, text10 + "," + nowYYYYMMDD);
													sb.Append("신규:[작업스케줄] " + val6.get_Path() + " " + ((object)val6.get_Definition().get_Actions()).ToString() + "[" + val6.get_Definition().get_RegistrationInfo().get_Author() + "]" + val6.get_Definition().get_RegistrationInfo().get_Description());
													sb.Append("\r\n");
													sb.Append(text10);
													sb.Append("\r\n");
													sb.Append("\r\n");
													cnt++;
													text12 = text12.Trim();
													if (text12.StartsWith("\"\""))
													{
														text12 = text12.Replace("\"\"", "\"");
													}
													string pureFileNameRemoveParam = getPureFileNameRemoveParam(text12);
													bool isFileOk;
													if (isFileOk = Utils.FileExists(pureFileNameRemoveParam))
													{
														text10 = getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam);
														if (!dictListOld.ContainsKey(pureFileNameRemoveParam.ToLower()))
														{
															if (!dictListNew.ContainsKey(pureFileNameRemoveParam))
															{
																dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
																sb.Append("신규: " + pureFileNameRemoveParam);
																sb.Append("\r\n");
																sb.Append(text10);
																sb.Append("\r\n");
																sb.Append("\r\n");
																cnt++;
															}
														}
														else
														{
															string checkSum = getCheckSum(dictListOld[pureFileNameRemoveParam.ToLower()]);
															if (text10 != checkSum)
															{
																try
																{
																	if (dictListNew.ContainsKey(pureFileNameRemoveParam))
																	{
																		dictListNew.Remove(pureFileNameRemoveParam);
																	}
																	dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
																	ListBeforeModifiedSHA_Add(checkSum);
																	sb.Append("변조: " + pureFileNameRemoveParam);
																	sb.Append("\r\n");
																	sb.Append(text10);
																	sb.Append("\r\n");
																	sb.Append("\r\n");
																	cnt++;
																	DictNewedModifedSHA.Add(checkSum, text10);
																}
																catch (ArgumentException)
																{
																}
															}
														}
														try
														{
															getPureFileNameRemoveParam(pureFileNameRemoveParam);
															text10 = App.FileCheckSum(pureFileNameRemoveParam);
															dictListNew.Add(pureFileNameRemoveParam, text10 + "," + text10);
															string text17 = "T," + pureFileNameRemoveParam + "," + text10;
															if (!isApproval(text17).HasValue && !dictApprovalList.ContainsKey(text17.ToLower()))
															{
																sb.Append("미승인[Task]: " + val6.get_Path() + " " + pureFileNameRemoveParam);
																sb.Append("\r\n");
																sb.Append(text10);
																sb.Append("\r\n");
																sb.Append("\r\n");
																cntOfApproval++;
																itmListViewApproval.Add(ApprovalList.GetOrCreate(text17));
																dictApprovalList.Add(text17.ToLower(), text10);
															}
														}
														catch (Exception)
														{
														}
													}
												}
											}
											else
											{
												string text10 = getCheckSum(dictListOld[("[JOB]" + val6.get_Path() + " " + ((object)val6.get_Definition().get_Actions()).ToString()).ToLower()]);
												string checkSum = getCheckSum(dictListOld[("[JOB]" + val6.get_Path() + " " + ((object)val6.get_Definition().get_Actions()).ToString()).ToLower()]);
												string pureFileNameRemoveParam = getPureFileNameRemoveParam(((object)val6.get_Definition().get_Actions()).ToString());
												bool isFileOk = Utils.FileExists(pureFileNameRemoveParam);
												if (checkSum != text10)
												{
													try
													{
														dictListNew.Add("[JOB]" + val6.get_Path() + " " + ((object)val6.get_Definition().get_Actions()).ToString(), text10 + "," + nowYYYYMMDD);
														ListBeforeModifiedSHA_Add(checkSum);
														sb.Append("변조:[작업스케줄] " + val6.get_Path() + " " + ((object)val6.get_Definition().get_Actions()).ToString() + "[" + val6.get_Definition().get_RegistrationInfo().get_Author() + "]" + val6.get_Definition().get_RegistrationInfo().get_Description());
														sb.Append("\r\n");
														sb.Append(text10);
														sb.Append("\r\n");
														sb.Append("\r\n");
														cnt++;
													}
													catch (ArgumentException)
													{
													}
												}
												else
												{
													string text15 = "[JOB]" + val6.get_Path() + " " + ((object)val6.get_Definition().get_Actions()).ToString();
													if (!dictListNew.ContainsKey(text15))
													{
														dictListNew.Add(text15, dictListOld[text15.ToLower()]);
														if (isFileOk)
														{
															try
															{
																getPureFileNameRemoveParam(pureFileNameRemoveParam);
																dictListNew.Add(pureFileNameRemoveParam, dictListOld[pureFileNameRemoveParam.ToLower()]);
																text10 = App.FileCheckSum(pureFileNameRemoveParam);
																string text17 = "T," + pureFileNameRemoveParam + "," + text10;
																if (!isApproval(text17).HasValue && !dictApprovalList.ContainsKey(text17.ToLower()))
																{
																	sb.Append("미승인[Task]: " + val6.get_Path() + " " + pureFileNameRemoveParam);
																	sb.Append("\r\n");
																	sb.Append(text10);
																	sb.Append("\r\n");
																	sb.Append("\r\n");
																	cntOfApproval++;
																	itmListViewApproval.Add(ApprovalList.GetOrCreate(text17));
																	dictApprovalList.Add(text17.ToLower(), text10);
																}
															}
															catch (Exception)
															{
															}
														}
													}
												}
												if (isFileOk)
												{
													text10 = getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam);
													if (!dictListOld.ContainsKey(pureFileNameRemoveParam.ToLower()))
													{
														if (!dictListNew.ContainsKey(pureFileNameRemoveParam))
														{
															dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
															sb.Append("신규: " + pureFileNameRemoveParam);
															sb.Append("\r\n");
															sb.Append(text10);
															sb.Append("\r\n");
															sb.Append("\r\n");
															cnt++;
														}
													}
													else
													{
														checkSum = getCheckSum(dictListOld[pureFileNameRemoveParam.ToLower()]);
														if (text10 != checkSum)
														{
															try
															{
																if (dictListNew.ContainsKey(pureFileNameRemoveParam))
																{
																	dictListNew.Remove(pureFileNameRemoveParam);
																}
																dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
																ListBeforeModifiedSHA_Add(checkSum);
																sb.Append("변조: " + pureFileNameRemoveParam);
																sb.Append("\r\n");
																sb.Append(text10);
																sb.Append("\r\n");
																sb.Append("\r\n");
																cnt++;
																DictNewedModifedSHA.Add(checkSum, text10);
															}
															catch (ArgumentException)
															{
															}
														}
													}
												}
											}
										}
									}
								}
							}
							catch (Exception ex5)
							{
								Console.WriteLine("[TASK Error]");
								strErrFilePath = "[14]" + val6.get_Path() + " netprofm서비스 Network List Service가 사용중지된 상태인경우 오류가 발생될 수 있습니다.(수동사용으로 권장)";
								App.LogPut(ex5);
								isErrorOccored = true;
								break;
							}
							i++;
						}
						Console.WriteLine("[TASK End]");
					}
					finally
					{
						((IDisposable)val5)?.Dispose();
					}
				}
				if (!bCancelHealthCheck)
				{
					if (Utils.Is64OS())
					{
						RegistryKey registryKey3 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
						registryKey2 = registryKey3.OpenSubKey("SYSTEM\\CurrentControlSet\\services");
					}
					else
					{
						registryKey2 = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\services");
					}
					if (registryKey2 != null)
					{
						string[] subKeyNames = registryKey2.GetSubKeyNames();
						string text12 = "";
						AddParentPart(subKeyNames.Length);
						if (!bCancelHealthCheck)
						{
							for (int i = 0; i < subKeyNames.Length; i++)
							{
								if (bCancelHealthCheck)
								{
									break;
								}
								tBar.set_Text(AddChildPartOne());
								Application.DoEvents();
								try
								{
									Application.DoEvents();
									if (Utils.Is64OS())
									{
										RegistryKey registryKey3 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
										registryKey2 = registryKey3.OpenSubKey("SYSTEM" + Utils.SEPA + "CurrentControlSet" + Utils.SEPA + "services" + Utils.SEPA + subKeyNames[i]);
									}
									else
									{
										registryKey2 = Registry.LocalMachine.OpenSubKey("SYSTEM" + Utils.SEPA + "CurrentControlSet" + Utils.SEPA + "services" + Utils.SEPA + subKeyNames[i]);
									}
									int num4 = (int)registryKey2.GetValue("Start", -1);
									string pureFileNameRemoveParam;
									if (num4 != 4)
									{
										text12 = (string)registryKey2.GetValue("ImagePath", "");
										text12 = text12.ToLower();
										if (0 < text12.Length)
										{
											int num5 = text12.IndexOf(".");
											if (-1 < num5)
											{
												string text19 = text12.Substring(0, num5);
												string text20 = text12.Substring(num5 + 1);
												text12 = text19.Replace("/", Utils.SEPA) + "." + text20;
											}
											string[] array9 = text12.Split(new char[1] { '"' });
											pureFileNameRemoveParam = "";
											if (array9.Count() <= 0)
											{
												goto IL_5b99;
											}
											pureFileNameRemoveParam = array9[0].Trim();
											if (!(pureFileNameRemoveParam == ""))
											{
												goto IL_5b99;
											}
											if (array9.Count() >= 2)
											{
												pureFileNameRemoveParam = array9[1].Trim();
												goto IL_5b99;
											}
										}
									}
									else
									{
										if (num4 != 4)
										{
											continue;
										}
										text12 = (string)registryKey2.GetValue("ImagePath", "");
										text12 = text12.ToLower();
										if (0 < text12.Length)
										{
											int num5 = text12.IndexOf(".");
											if (-1 < num5)
											{
												string text19 = text12.Substring(0, num5);
												string text20 = text12.Substring(num5 + 1);
												text12 = text19.Replace("/", Utils.SEPA) + "." + text20;
											}
											string[] array9 = text12.Split(new char[1] { '"' });
											pureFileNameRemoveParam = "";
											if (array9.Count() <= 0)
											{
												goto IL_664b;
											}
											pureFileNameRemoveParam = array9[0].Trim();
											if (!(pureFileNameRemoveParam == ""))
											{
												goto IL_664b;
											}
											if (array9.Count() >= 2)
											{
												pureFileNameRemoveParam = array9[1].Trim();
												goto IL_664b;
											}
										}
										continue;
									}
									goto end_IL_59b6;
									IL_664b:
									bool isFileOk = false;
									try
									{
										replaceStartsWithSpecialFolder(ref pureFileNameRemoveParam);
										isFileOk = Utils.FileExists(pureFileNameRemoveParam) || replaceFileNameWithParam(ref pureFileNameRemoveParam, allExt: true);
									}
									catch (Exception)
									{
									}
									if (isFileOk)
									{
										continue;
									}
									if (-1 == pureFileNameRemoveParam.IndexOf("."))
									{
										pureFileNameRemoveParam = pureFileNameRemoveParam.Trim() + ".exe";
										if (!File.Exists(pureFileNameRemoveParam))
										{
											pureFileNameRemoveParam = pureFileNameRemoveParam.Trim() + ".com";
											if (!File.Exists(pureFileNameRemoveParam))
											{
												pureFileNameRemoveParam = pureFileNameRemoveParam.Trim() + ".bat";
												if (!File.Exists(pureFileNameRemoveParam))
												{
													pureFileNameRemoveParam = pureFileNameRemoveParam.Trim() + ".cmd";
													if (!File.Exists(pureFileNameRemoveParam))
													{
														pureFileNameRemoveParam = pureFileNameRemoveParam.Trim() + ".???";
													}
													else
													{
														isFileOk = true;
													}
												}
												else
												{
													isFileOk = true;
												}
											}
											else
											{
												isFileOk = true;
											}
										}
										else
										{
											isFileOk = true;
										}
									}
									if (!isFileOk)
									{
										if (-1 < pureFileNameRemoveParam.IndexOf(' '))
										{
											sb.Append("# dir /a \"" + pureFileNameRemoveParam + "\"");
										}
										else
										{
											sb.Append("# dir /a " + pureFileNameRemoveParam);
										}
										if (-1 < subKeyNames[i].IndexOf(' '))
										{
											sb.Append("|| sc delete \"" + subKeyNames[i] + "\"");
										}
										else
										{
											sb.Append("|| sc delete " + subKeyNames[i]);
										}
									}
									sb.Append("\r\n");
									goto end_IL_59b6;
									IL_5b99:
									isFileOk = false;
									try
									{
										replaceStartsWithSpecialFolder(ref pureFileNameRemoveParam);
										isFileOk = Utils.FileExists(pureFileNameRemoveParam) || replaceFileNameWithParam(ref pureFileNameRemoveParam);
									}
									catch (Exception)
									{
									}
									if (pureFileNameRemoveParam.IndexOf('?') != -1)
									{
										continue;
									}
									replaceStartsWithSpecialFolder(ref text12);
									string text10;
									string checkSum;
									if (!dictListOld.ContainsKey(("[Service]" + subKeyNames[i] + " " + text12).ToLower()))
									{
										if (File.Exists(text12))
										{
											text10 = App.FileCheckSum(text12);
										}
										else
										{
											if (text12.IndexOf(".") == -1)
											{
												text12 += ".exe";
											}
											text10 = ((!File.Exists(text12)) ? App.StringCheckSum(("[Service]" + subKeyNames[i] + " " + text12).ToLower()) : App.FileCheckSum(text12));
										}
										string text15 = "[Service]" + subKeyNames[i] + " " + text12;
										if (dictListNew.ContainsKey(text15))
										{
											continue;
										}
										if (subKeyNames[i].IndexOf(" ") == -1 && (-1 < subKeyNames[i].IndexOf("svc_", StringComparison.OrdinalIgnoreCase) || -1 < subKeyNames[i].IndexOf("service_", StringComparison.OrdinalIgnoreCase)) && -1 < text12.IndexOf("svchost.exe -k", StringComparison.OrdinalIgnoreCase))
										{
											Utils.ExecuteCommandSync(Environment.GetEnvironmentVariable("windir") + Utils.SEPA + "system32\\sc stop " + subKeyNames[i], showError: false);
											continue;
										}
										dictListNew.Add(text15, text10 + "," + nowYYYYMMDD);
										sb.Append(string.Concat("신규:", text15, "[", registryKey2.GetValue("DisplayName", ""), "]", registryKey2.GetValue("Description", "")));
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cnt++;
										if (!isFileOk)
										{
											continue;
										}
										text10 = getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam);
										pureFileNameRemoveParam = pureFileNameRemoveParam.ToLower();
										if (!dictListOld.ContainsKey(pureFileNameRemoveParam))
										{
											if (!dictListNew.ContainsKey(pureFileNameRemoveParam))
											{
												dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
												sb.Append("신규: " + pureFileNameRemoveParam);
												sb.Append("\r\n");
												sb.Append(text10);
												sb.Append("\r\n");
												sb.Append("\r\n");
												cnt++;
											}
										}
										else
										{
											checkSum = getCheckSum(dictListOld[pureFileNameRemoveParam.ToLower()]);
											if (text10 != checkSum)
											{
												try
												{
													if (dictListNew.ContainsKey(pureFileNameRemoveParam))
													{
														dictListNew.Remove(pureFileNameRemoveParam);
													}
													dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
													ListBeforeModifiedSHA_Add(checkSum);
													sb.Append("변조: " + pureFileNameRemoveParam);
													sb.Append("\r\n");
													sb.Append(text10);
													sb.Append("\r\n");
													sb.Append("\r\n");
													cnt++;
													DictNewedModifedSHA.Add(checkSum, text10);
												}
												catch (ArgumentException)
												{
												}
											}
										}
										try
										{
											getPureFileNameRemoveParam(pureFileNameRemoveParam);
											text10 = App.FileCheckSum(pureFileNameRemoveParam);
											dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
											string text17 = "S," + pureFileNameRemoveParam + "," + text10;
											if (!isApproval(text17).HasValue && !dictApprovalList.ContainsKey(text17.ToLower()))
											{
												sb.Append(string.Concat("미승인[ServiceA]: ", registryKey2.GetValue("DisplayName", ""), "] ", pureFileNameRemoveParam));
												sb.Append("\r\n");
												sb.Append(text10);
												sb.Append("\r\n");
												sb.Append("\r\n");
												cntOfApproval++;
												itmListViewApproval.Add(ApprovalList.GetOrCreate(text17));
												dictApprovalList.Add(text17.ToLower(), text10);
											}
										}
										catch (Exception)
										{
										}
										continue;
									}
									if (File.Exists(text12))
									{
										text10 = App.FileCheckSum(text12);
									}
									else if (-1 == text12.IndexOf("."))
									{
										text12 += ".exe";
										text10 = ((!File.Exists(text12)) ? getCheckSum(dictListOld[("[Service]" + subKeyNames[i] + " " + text12).ToLower()]) : App.FileCheckSum(text12));
									}
									else
									{
										text10 = getCheckSum(dictListOld[("[Service]" + subKeyNames[i] + " " + text12).ToLower()]);
									}
									checkSum = getCheckSum(dictListOld[("[Service]" + subKeyNames[i] + " " + text12).ToLower()]);
									if (checkSum != text10)
									{
										try
										{
											dictListNew.Add("[Service]" + subKeyNames[i] + " " + text12, text10 + "," + nowYYYYMMDD);
											ListBeforeModifiedSHA_Add(checkSum);
											sb.Append(string.Concat("변조[서비스]: ", subKeyNames[i], " ", text12, "[", registryKey2.GetValue("DisplayName", ""), "]", registryKey2.GetValue("Description", "")));
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
										}
										catch (ArgumentException)
										{
										}
									}
									else
									{
										string text21 = "[Service]" + subKeyNames[i] + " " + text12;
										try
										{
											dictListNew.Add(text21, dictListOld[text21.ToLower()]);
										}
										catch (Exception)
										{
										}
										if (isFileOk)
										{
											try
											{
												getPureFileNameRemoveParam(pureFileNameRemoveParam);
												dictListNew.Add(pureFileNameRemoveParam, dictListOld[pureFileNameRemoveParam.ToLower()]);
												text10 = App.FileCheckSum(pureFileNameRemoveParam);
												string text17 = "S," + pureFileNameRemoveParam + "," + text10;
												if (!isApproval(text17).HasValue && !dictApprovalList.ContainsKey(text17.ToLower()))
												{
													sb.Append(string.Concat("미승인[ServiceB]: ", registryKey2.GetValue("DisplayName", ""), "] ", pureFileNameRemoveParam));
													sb.Append("\r\n");
													sb.Append(text10);
													sb.Append("\r\n");
													sb.Append("\r\n");
													cntOfApproval++;
													itmListViewApproval.Add(ApprovalList.GetOrCreate(text17));
													dictApprovalList.Add(text17.ToLower(), text10);
												}
											}
											catch (Exception)
											{
											}
										}
									}
									if (!isFileOk)
									{
										continue;
									}
									text10 = getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam);
									if (!dictListOld.ContainsKey(pureFileNameRemoveParam.ToLower()))
									{
										if (!dictListNew.ContainsKey(pureFileNameRemoveParam))
										{
											dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
											sb.Append("신규: " + pureFileNameRemoveParam);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
										}
										continue;
									}
									checkSum = getCheckSum(dictListOld[pureFileNameRemoveParam.ToLower()]);
									if (!(text10 != checkSum))
									{
										continue;
									}
									try
									{
										if (dictListNew.ContainsKey(pureFileNameRemoveParam))
										{
											dictListNew.Remove(pureFileNameRemoveParam);
										}
										dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
										ListBeforeModifiedSHA_Add(checkSum);
										sb.Append("변조: " + pureFileNameRemoveParam);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cnt++;
										DictNewedModifedSHA.Add(checkSum, text10);
									}
									catch (ArgumentException)
									{
									}
									end_IL_59b6:;
								}
								catch (Exception ex5)
								{
									if (-1 == text12.IndexOf("svchost.exe"))
									{
										App.LogPut(ex5);
										isErrorOccored = true;
										strErrFilePath = "[15]" + text12 + "[" + ex5.Message + "]";
										break;
									}
									strErrFilePath = "[15...]" + text12 + "[" + ex5.Message + "]";
								}
							}
						}
					}
				}
				if (!bCancelHealthCheck)
				{
					if (Utils.Is64OS())
					{
						RegistryKey registryKey3 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
						registryKey2 = registryKey3.OpenSubKey("SYSTEM\\CurrentControlSet\\services\\LanmanServer\\Shares");
					}
					else
					{
						registryKey2 = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\services\\LanmanServer\\Shares");
					}
					if (registryKey2 != null)
					{
						string[] valueNames = registryKey2.GetValueNames();
						string text12 = "";
						AddParentPart(valueNames.Length);
						if (!bCancelHealthCheck)
						{
							for (int i = 0; i < valueNames.Length; i++)
							{
								if (bCancelHealthCheck)
								{
									break;
								}
								tBar.set_Text(AddChildPartOne());
								Application.DoEvents();
								try
								{
									Application.DoEvents();
									string[] array10 = (string[])registryKey2.GetValue(valueNames[i]);
									for (int l = 0; l < array10.Length; l++)
									{
										if (array10[l].StartsWith("Path="))
										{
											text12 = array10[l].Substring(5);
											if (-1 < text12.IndexOf("%"))
											{
												text2 = text12;
												num2 = 200;
												text12 = new DirectoryInfo(text2).FullName;
											}
											break;
										}
									}
									if (text12 != null && text12.IndexOf(":" + Utils.SEPA) > -1)
									{
										if (!dictListOld.ContainsKey("[share]" + text12.ToLower()))
										{
											sb.Append("신규[공유]: " + text12);
											sb.Append("\r\n");
											sb.Append("");
											sb.Append("\r\n");
											sb.Append("\r\n");
										}
										int depthFolderLimit = 3;
										int depthExeFileLimit = 100;
										AddShareFiles(text12, ref sb, ref depthFolderLimit, ref depthExeFileLimit, ref cnt);
									}
								}
								catch (Exception ex5)
								{
									strErrFilePath = "[16]" + text12;
									App.LogPut(ex5);
									isErrorOccored = true;
									break;
								}
							}
						}
					}
				}
				if (!bCancelHealthCheck)
				{
					if (Utils.Is64OS())
					{
						RegistryKey registryKey3 = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
						registryKey2 = registryKey3.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
					}
					else
					{
						registryKey2 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
					}
					if (registryKey2 != null)
					{
						string[] valueNames = registryKey2.GetValueNames();
						string text12 = "";
						AddParentPart(valueNames.Length);
						if (!bCancelHealthCheck)
						{
							for (int i = 0; i < valueNames.Length; i++)
							{
								if (bCancelHealthCheck)
								{
									break;
								}
								tBar.set_Text(AddChildPartOne());
								Application.DoEvents();
								try
								{
									Application.DoEvents();
									text12 = (string)registryKey2.GetValue(valueNames[i], "");
									string pureFileNameRemoveParam = getPureFileNameRemoveParam(text12);
									bool isFileOk = false;
									try
									{
										isFileOk = Utils.FileExists(pureFileNameRemoveParam) || replaceFileNameWithParam(ref pureFileNameRemoveParam);
									}
									catch (Exception)
									{
									}
									if (pureFileNameRemoveParam.IndexOf('?') != -1)
									{
										continue;
									}
									string text10;
									string checkSum;
									if (!dictListOld.ContainsKey(("[Run]HKCU" + Utils.SEPA + "SOFTWARE" + Utils.SEPA + "Microsoft" + Utils.SEPA + "Windows" + Utils.SEPA + "CurrentVersion" + Utils.SEPA + "Run" + Utils.SEPA + valueNames[i] + " " + text12).ToLower()))
									{
										text10 = ((!isFileOk) ? App.StringCheckSum(("[Run]HKCU" + Utils.SEPA + "SOFTWARE" + Utils.SEPA + "Microsoft" + Utils.SEPA + "Windows" + Utils.SEPA + "CurrentVersion" + Utils.SEPA + "Run" + Utils.SEPA + valueNames[i] + " " + text12).ToLower()) : getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam));
										string text15 = "[Run]HKCU" + Utils.SEPA + "SOFTWARE" + Utils.SEPA + "Microsoft" + Utils.SEPA + "Windows" + Utils.SEPA + "CurrentVersion" + Utils.SEPA + "Run" + Utils.SEPA + valueNames[i] + " " + text12;
										if (dictListNew.ContainsKey(text15))
										{
											continue;
										}
										dictListNew.Add(text15, text10 + "," + nowYYYYMMDD);
										sb.Append("신규[userRun]: HKCU" + Utils.SEPA + "SOFTWARE" + Utils.SEPA + "Microsoft" + Utils.SEPA + "Windows" + Utils.SEPA + "CurrentVersion" + Utils.SEPA + "Run" + Utils.SEPA + valueNames[i] + " " + text12);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cnt++;
										if (!isFileOk)
										{
											continue;
										}
										text10 = getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam);
										if (!dictListOld.ContainsKey(pureFileNameRemoveParam.ToLower()))
										{
											if (!dictListNew.ContainsKey(pureFileNameRemoveParam))
											{
												dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
												sb.Append("신규: " + pureFileNameRemoveParam);
												sb.Append("\r\n");
												sb.Append(text10);
												sb.Append("\r\n");
												sb.Append("\r\n");
												cnt++;
											}
										}
										else
										{
											checkSum = getCheckSum(dictListOld[pureFileNameRemoveParam.ToLower()]);
											if (text10 != checkSum)
											{
												try
												{
													if (dictListNew.ContainsKey(pureFileNameRemoveParam))
													{
														dictListNew.Remove(pureFileNameRemoveParam);
													}
													dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
													ListBeforeModifiedSHA_Add(checkSum);
													sb.Append("변조: " + pureFileNameRemoveParam);
													sb.Append("\r\n");
													sb.Append(text10);
													sb.Append("\r\n");
													sb.Append("\r\n");
													cnt++;
													DictNewedModifedSHA.Add(checkSum, text10);
												}
												catch (ArgumentException)
												{
												}
											}
										}
										try
										{
											getPureFileNameRemoveParam(pureFileNameRemoveParam);
											text10 = App.FileCheckSum(pureFileNameRemoveParam);
											dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
											string text17 = "RU," + pureFileNameRemoveParam + "," + text10;
											if (!isApproval(text17).HasValue && !dictApprovalList.ContainsKey(text17.ToLower()))
											{
												sb.Append("미승인[UserRun]: " + pureFileNameRemoveParam);
												sb.Append("\r\n");
												sb.Append(text10);
												sb.Append("\r\n");
												sb.Append("\r\n");
												cntOfApproval++;
												itmListViewApproval.Add(ApprovalList.GetOrCreate(text17));
												dictApprovalList.Add(text17.ToLower(), text10);
											}
										}
										catch (Exception)
										{
										}
										continue;
									}
									text10 = getCheckSum(dictListOld[("[Run]HKCU" + Utils.SEPA + "SOFTWARE" + Utils.SEPA + "Microsoft" + Utils.SEPA + "Windows" + Utils.SEPA + "CurrentVersion" + Utils.SEPA + "Run" + Utils.SEPA + valueNames[i] + " " + text12).ToLower()]);
									checkSum = getCheckSum(dictListOld[("[Run]HKCU" + Utils.SEPA + "SOFTWARE" + Utils.SEPA + "Microsoft" + Utils.SEPA + "Windows" + Utils.SEPA + "CurrentVersion" + Utils.SEPA + "Run" + Utils.SEPA + valueNames[i] + " " + text12).ToLower()]);
									if (checkSum != text10)
									{
										try
										{
											dictListNew.Add("[Run]HKCU" + Utils.SEPA + "SOFTWARE" + Utils.SEPA + "Microsoft" + Utils.SEPA + "Windows" + Utils.SEPA + "CurrentVersion" + Utils.SEPA + "Run" + Utils.SEPA + valueNames[i] + " " + text12, text10 + "," + nowYYYYMMDD);
											ListBeforeModifiedSHA_Add(checkSum);
											sb.Append("변조[userRun]: HKCU" + Utils.SEPA + "SOFTWARE" + Utils.SEPA + "Microsoft" + Utils.SEPA + "Windows" + Utils.SEPA + "CurrentVersion" + Utils.SEPA + "Run" + Utils.SEPA + valueNames[i] + " " + text12);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
										}
										catch (ArgumentException)
										{
										}
									}
									else
									{
										dictListNew.Add("[Run]HKCU" + Utils.SEPA + "SOFTWARE" + Utils.SEPA + "Microsoft" + Utils.SEPA + "Windows" + Utils.SEPA + "CurrentVersion" + Utils.SEPA + "Run" + Utils.SEPA + valueNames[i] + " " + text12, dictListOld[("[Run]HKCU\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\" + valueNames[i] + " " + text12).ToLower()]);
										if (isFileOk)
										{
											try
											{
												getPureFileNameRemoveParam(pureFileNameRemoveParam);
												dictListNew.Add(pureFileNameRemoveParam, dictListOld[pureFileNameRemoveParam.ToLower()]);
												text10 = App.FileCheckSum(pureFileNameRemoveParam);
												string text17 = "RU," + pureFileNameRemoveParam + "," + text10;
												if (!isApproval(text17).HasValue && !dictApprovalList.ContainsKey(text17.ToLower()))
												{
													sb.Append("미승인[UserRun]: " + pureFileNameRemoveParam);
													sb.Append("\r\n");
													sb.Append(text10);
													sb.Append("\r\n");
													sb.Append("\r\n");
													cntOfApproval++;
													itmListViewApproval.Add(ApprovalList.GetOrCreate(text17));
													dictApprovalList.Add(text17.ToLower(), text10);
												}
											}
											catch (Exception)
											{
											}
										}
									}
									if (!isFileOk)
									{
										continue;
									}
									text10 = getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam);
									if (!dictListOld.ContainsKey(pureFileNameRemoveParam.ToLower()))
									{
										if (!dictListNew.ContainsKey(pureFileNameRemoveParam))
										{
											dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
											sb.Append("신규: " + pureFileNameRemoveParam);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
										}
										continue;
									}
									checkSum = getCheckSum(dictListOld[pureFileNameRemoveParam.ToLower()]);
									if (!(text10 != checkSum))
									{
										continue;
									}
									try
									{
										if (dictListNew.ContainsKey(pureFileNameRemoveParam))
										{
											dictListNew.Remove(pureFileNameRemoveParam);
										}
										dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
										ListBeforeModifiedSHA_Add(checkSum);
										sb.Append("변조: " + pureFileNameRemoveParam);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cnt++;
										DictNewedModifedSHA.Add(checkSum, text10);
									}
									catch (ArgumentException)
									{
									}
								}
								catch (Exception ex5)
								{
									strErrFilePath = "[17]" + text12;
									App.LogPut(ex5);
									isErrorOccored = true;
									break;
								}
							}
						}
					}
				}
				string oldValue = "?" + Utils.SEPA;
				string newValue = ":" + Utils.SEPA;
				if (!bCancelHealthCheck)
				{
					if (Utils.Is64OS())
					{
						RegistryKey registryKey3 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
						registryKey2 = registryKey3.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Installer\\UserData\\S-1-5-18\\Components");
					}
					else
					{
						registryKey2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Installer\\UserData\\S-1-5-18\\Components");
					}
					if (registryKey2 != null)
					{
						string[] valueNames = registryKey2.GetSubKeyNames();
						string text12 = "";
						AddParentPart(valueNames.Length);
						if (!bCancelHealthCheck)
						{
							for (int i = 0; i < valueNames.Length; i++)
							{
								if (bCancelHealthCheck)
								{
									break;
								}
								tBar.set_Text(AddChildPartOne());
								Application.DoEvents();
								try
								{
									Application.DoEvents();
									RegistryKey registryKey4;
									if (Utils.Is64OS())
									{
										RegistryKey registryKey3 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
										registryKey4 = registryKey3.OpenSubKey("SOFTWARE" + Utils.SEPA + "Microsoft" + Utils.SEPA + "Windows" + Utils.SEPA + "CurrentVersion" + Utils.SEPA + "Installer" + Utils.SEPA + "UserData" + Utils.SEPA + "S-1-5-18" + Utils.SEPA + "Components" + Utils.SEPA + valueNames[i]);
									}
									else
									{
										registryKey4 = Registry.LocalMachine.OpenSubKey("SOFTWARE" + Utils.SEPA + "Microsoft" + Utils.SEPA + "Windows" + Utils.SEPA + "CurrentVersion" + Utils.SEPA + "Installer" + Utils.SEPA + "UserData" + Utils.SEPA + "S-1-5-18" + Utils.SEPA + "Components" + Utils.SEPA + valueNames[i]);
									}
									string[] valueNames2 = registryKey4.GetValueNames();
									for (int m = 0; m < valueNames2.Length; m++)
									{
										text12 = (string)registryKey4.GetValue(valueNames2[m], "");
										text12 = text12.Replace(oldValue, newValue);
										string pureFileNameRemoveParam = getPureFileNameRemoveParam(text12);
										bool isFileOk = false;
										try
										{
											if (0 < pureFileNameRemoveParam.Trim().Length)
											{
												isFileOk = Utils.FileExists(pureFileNameRemoveParam) || replaceFileNameWithParam(ref pureFileNameRemoveParam);
											}
										}
										catch (Exception)
										{
										}
										if (pureFileNameRemoveParam.IndexOf('?') != -1 || !replaceFileNameWithParam(ref pureFileNameRemoveParam))
										{
											continue;
										}
										string text10;
										string checkSum;
										if (!dictListOld.ContainsKey(("[Installer]HKLM" + Utils.SEPA + "SOFTWARE" + Utils.SEPA + "Microsoft" + Utils.SEPA + "Windows" + Utils.SEPA + "CurrentVersion" + Utils.SEPA + "Installer" + Utils.SEPA + "UserData" + Utils.SEPA + "S-1-5-18" + Utils.SEPA + "Components" + Utils.SEPA + valueNames[i] + " " + text12).ToLower()))
										{
											text10 = App.StringCheckSum(("[Installer]HKLM" + Utils.SEPA + "SOFTWARE" + Utils.SEPA + "Microsoft" + Utils.SEPA + "Windows" + Utils.SEPA + "CurrentVersion" + Utils.SEPA + "Installer" + Utils.SEPA + "UserData" + Utils.SEPA + "S-1-5-18" + Utils.SEPA + "Components" + Utils.SEPA + valueNames[i] + " " + text12).ToLower());
											string text15 = "[Installer]HKLM" + Utils.SEPA + "SOFTWARE" + Utils.SEPA + "Microsoft" + Utils.SEPA + "Windows" + Utils.SEPA + "CurrentVersion" + Utils.SEPA + "Installer" + Utils.SEPA + "UserData" + Utils.SEPA + "S-1-5-18" + Utils.SEPA + "Components" + Utils.SEPA + valueNames[i] + " " + text12;
											if (dictListNew.ContainsKey(text15))
											{
												continue;
											}
											dictListNew.Add(text15, text10 + "," + nowYYYYMMDD);
											sb.Append("신규[Installer]: HKLM" + Utils.SEPA + "SOFTWARE" + Utils.SEPA + "Microsoft" + Utils.SEPA + "Windows" + Utils.SEPA + "CurrentVersion" + Utils.SEPA + "Installer" + Utils.SEPA + "UserData" + Utils.SEPA + "S-1-5-18" + Utils.SEPA + "Components" + Utils.SEPA + valueNames[i] + " " + text12);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
											if (!isFileOk)
											{
												continue;
											}
											text10 = getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam);
											if (!dictListOld.ContainsKey(pureFileNameRemoveParam.ToLower()))
											{
												if (!dictListNew.ContainsKey(pureFileNameRemoveParam))
												{
													dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
													sb.Append("신규: " + pureFileNameRemoveParam);
													sb.Append("\r\n");
													sb.Append(text10);
													sb.Append("\r\n");
													sb.Append("\r\n");
													cnt++;
												}
												continue;
											}
											checkSum = getCheckSum(dictListOld[pureFileNameRemoveParam.ToLower()]);
											if (!(text10 != checkSum))
											{
												continue;
											}
											try
											{
												if (dictListNew.ContainsKey(pureFileNameRemoveParam))
												{
													dictListNew.Remove(pureFileNameRemoveParam);
												}
												dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
												ListBeforeModifiedSHA_Add(checkSum);
												sb.Append("변조: " + pureFileNameRemoveParam);
												sb.Append("\r\n");
												sb.Append(text10);
												sb.Append("\r\n");
												sb.Append("\r\n");
												cnt++;
												DictNewedModifedSHA.Add(checkSum, text10);
											}
											catch (ArgumentException)
											{
											}
											continue;
										}
										text10 = getCheckSum(dictListOld[("[Installer]HKLM" + Utils.SEPA + "SOFTWARE" + Utils.SEPA + "Microsoft" + Utils.SEPA + "Windows" + Utils.SEPA + "CurrentVersion" + Utils.SEPA + "Installer" + Utils.SEPA + "UserData" + Utils.SEPA + "S-1-5-18" + Utils.SEPA + "Components" + Utils.SEPA + valueNames[i] + " " + text12).ToLower()]);
										checkSum = getCheckSum(dictListOld[("[Installer]HKLM" + Utils.SEPA + "SOFTWARE" + Utils.SEPA + "Microsoft" + Utils.SEPA + "Windows" + Utils.SEPA + "CurrentVersion" + Utils.SEPA + "Installer" + Utils.SEPA + "UserData" + Utils.SEPA + "S-1-5-18" + Utils.SEPA + "Components" + Utils.SEPA + valueNames[i] + " " + text12).ToLower()]);
										if (checkSum != text10)
										{
											try
											{
												dictListNew.Add("[Installer]HKLM" + Utils.SEPA + "SOFTWARE" + Utils.SEPA + "Microsoft" + Utils.SEPA + "Windows" + Utils.SEPA + "CurrentVersion" + Utils.SEPA + "Installer" + Utils.SEPA + "UserData" + Utils.SEPA + "S-1-5-18" + Utils.SEPA + "Components" + Utils.SEPA + valueNames[i] + " " + text12, text10 + "," + nowYYYYMMDD);
												ListBeforeModifiedSHA_Add(checkSum);
												sb.Append("변조[Installer]: HKLM" + Utils.SEPA + "SOFTWARE" + Utils.SEPA + "Microsoft" + Utils.SEPA + "Windows" + Utils.SEPA + "CurrentVersion" + Utils.SEPA + "Installer" + Utils.SEPA + "UserData" + Utils.SEPA + "S-1-5-18" + Utils.SEPA + "Components" + Utils.SEPA + valueNames[i] + " " + text12);
												sb.Append("\r\n");
												sb.Append(text10);
												sb.Append("\r\n");
												sb.Append("\r\n");
												cnt++;
											}
											catch (ArgumentException)
											{
											}
										}
										if (!isFileOk)
										{
											continue;
										}
										text10 = getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam);
										if (!dictListOld.ContainsKey(pureFileNameRemoveParam.ToLower()))
										{
											if (!dictListNew.ContainsKey(pureFileNameRemoveParam))
											{
												dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
												sb.Append("신규: " + pureFileNameRemoveParam);
												sb.Append("\r\n");
												sb.Append(text10);
												sb.Append("\r\n");
												sb.Append("\r\n");
												cnt++;
											}
											continue;
										}
										checkSum = getCheckSum(dictListOld[pureFileNameRemoveParam.ToLower()]);
										if (!(text10 != checkSum))
										{
											continue;
										}
										try
										{
											if (dictListNew.ContainsKey(pureFileNameRemoveParam))
											{
												dictListNew.Remove(pureFileNameRemoveParam);
											}
											dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
											ListBeforeModifiedSHA_Add(checkSum);
											sb.Append("변조: " + pureFileNameRemoveParam);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
											DictNewedModifedSHA.Add(checkSum, text10);
										}
										catch (ArgumentException)
										{
										}
									}
								}
								catch (Exception ex5)
								{
									strErrFilePath = "[17.5]" + text12;
									App.LogPut(ex5);
									isErrorOccored = true;
									break;
								}
							}
						}
					}
				}
				if (!bCancelHealthCheck)
				{
					if (Utils.Is64OS())
					{
						RegistryKey registryKey3 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
						registryKey2 = registryKey3.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
					}
					else
					{
						registryKey2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
					}
					if (registryKey2 != null)
					{
						string[] valueNames = registryKey2.GetValueNames();
						string text12 = "";
						AddParentPart(valueNames.Length);
						if (!bCancelHealthCheck)
						{
							for (int i = 0; i < valueNames.Length; i++)
							{
								if (bCancelHealthCheck)
								{
									break;
								}
								tBar.set_Text(AddChildPartOne());
								Application.DoEvents();
								try
								{
									Application.DoEvents();
									text12 = (string)registryKey2.GetValue(valueNames[i], "");
									string pureFileNameRemoveParam = getPureFileNameRemoveParam(text12);
									bool isFileOk = false;
									try
									{
										isFileOk = Utils.FileExists(pureFileNameRemoveParam) || replaceFileNameWithParam(ref pureFileNameRemoveParam);
									}
									catch (Exception)
									{
									}
									if (pureFileNameRemoveParam.IndexOf('?') != -1)
									{
										continue;
									}
									string text22 = "HKLM" + Utils.SEPA + "SOFTWARE" + Utils.SEPA + "Microsoft" + Utils.SEPA + "Windows" + Utils.SEPA + "CurrentVersion" + Utils.SEPA + "Run" + Utils.SEPA + valueNames[i] + " " + text12;
									string text15 = "[Run]" + text22;
									string text23 = text15.ToLower();
									string text10;
									string checkSum;
									if (!dictListOld.ContainsKey(text23))
									{
										text10 = ((!isFileOk) ? App.StringCheckSum(text23) : getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam));
										if (dictListNew.ContainsKey(text23))
										{
											continue;
										}
										dictListNew.Add(text15, text10 + "," + nowYYYYMMDD);
										sb.Append("신규[allRun]: " + text22);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cnt++;
										if (!isFileOk)
										{
											continue;
										}
										text10 = getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam);
										if (!dictListOld.ContainsKey(pureFileNameRemoveParam.ToLower()))
										{
											if (!dictListNew.ContainsKey(pureFileNameRemoveParam))
											{
												dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
												sb.Append("신규: " + pureFileNameRemoveParam);
												sb.Append("\r\n");
												sb.Append(text10);
												sb.Append("\r\n");
												sb.Append("\r\n");
												cnt++;
											}
										}
										else
										{
											checkSum = getCheckSum(dictListOld[pureFileNameRemoveParam.ToLower()]);
											if (text10 != checkSum)
											{
												try
												{
													if (dictListNew.ContainsKey(pureFileNameRemoveParam))
													{
														dictListNew.Remove(pureFileNameRemoveParam);
													}
													dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
													ListBeforeModifiedSHA_Add(checkSum);
													sb.Append("변조: " + pureFileNameRemoveParam);
													sb.Append("\r\n");
													sb.Append(text10);
													sb.Append("\r\n");
													sb.Append("\r\n");
													cnt++;
													DictNewedModifedSHA.Add(checkSum, text10);
												}
												catch (ArgumentException)
												{
												}
											}
										}
										try
										{
											getPureFileNameRemoveParam(pureFileNameRemoveParam);
											text10 = App.FileCheckSum(pureFileNameRemoveParam);
											dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
											string text17 = "RA," + pureFileNameRemoveParam + "," + text10;
											if (!isApproval(text17).HasValue && !dictApprovalList.ContainsKey(text17.ToLower()))
											{
												sb.Append("미승인[AllRun]: " + pureFileNameRemoveParam);
												sb.Append("\r\n");
												sb.Append(text10);
												sb.Append("\r\n");
												sb.Append("\r\n");
												cntOfApproval++;
												itmListViewApproval.Add(ApprovalList.GetOrCreate(text17));
												dictApprovalList.Add(text17.ToLower(), text10);
											}
										}
										catch (Exception)
										{
										}
										continue;
									}
									text10 = App.StringCheckSum(text15.ToLower());
									checkSum = getCheckSum(dictListOld[text15.ToLower()]);
									if (checkSum != text10)
									{
										try
										{
											dictListNew.Add(text15, text10 + "," + nowYYYYMMDD);
											ListBeforeModifiedSHA_Add(checkSum);
											sb.Append("변조[allRun]: HKLM" + Utils.SEPA + "SOFTWARE" + Utils.SEPA + "Microsoft" + Utils.SEPA + "Windows" + Utils.SEPA + "CurrentVersion" + Utils.SEPA + "Run" + Utils.SEPA + valueNames[i] + " " + text12);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
										}
										catch (ArgumentException)
										{
										}
									}
									else
									{
										dictListNew.Add(text15, dictListOld[text15.ToLower()]);
										if (isFileOk)
										{
											try
											{
												getPureFileNameRemoveParam(pureFileNameRemoveParam);
												dictListNew.Add(pureFileNameRemoveParam, dictListOld[pureFileNameRemoveParam.ToLower()]);
												text10 = App.FileCheckSum(pureFileNameRemoveParam);
												string text17 = "RA," + pureFileNameRemoveParam + "," + text10;
												if (!isApproval(text17).HasValue && !dictApprovalList.ContainsKey(text17.ToLower()))
												{
													sb.Append("미승인[AllRun]: " + pureFileNameRemoveParam);
													sb.Append("\r\n");
													sb.Append(text10);
													sb.Append("\r\n");
													sb.Append("\r\n");
													cntOfApproval++;
													itmListViewApproval.Add(ApprovalList.GetOrCreate(text17));
													dictApprovalList.Add(text17.ToLower(), text10);
												}
											}
											catch (Exception)
											{
											}
										}
									}
									if (!isFileOk)
									{
										continue;
									}
									text10 = getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam);
									if (!dictListOld.ContainsKey(pureFileNameRemoveParam.ToLower()))
									{
										if (!dictListNew.ContainsKey(pureFileNameRemoveParam))
										{
											dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
											sb.Append("신규: " + pureFileNameRemoveParam);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
										}
										continue;
									}
									checkSum = getCheckSum(dictListOld[pureFileNameRemoveParam.ToLower()]);
									if (!(text10 != checkSum))
									{
										continue;
									}
									try
									{
										if (dictListNew.ContainsKey(pureFileNameRemoveParam))
										{
											dictListNew.Remove(pureFileNameRemoveParam);
										}
										dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
										ListBeforeModifiedSHA_Add(checkSum);
										sb.Append("변조: " + pureFileNameRemoveParam);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cnt++;
										DictNewedModifedSHA.Add(checkSum, text10);
									}
									catch (ArgumentException)
									{
									}
								}
								catch (Exception ex5)
								{
									strErrFilePath = "[18]" + text12;
									App.LogPut(ex5);
									isErrorOccored = true;
									break;
								}
							}
						}
					}
				}
				if (!bCancelHealthCheck)
				{
					if (Utils.Is64OS())
					{
						RegistryKey registryKey3 = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
						registryKey2 = registryKey3.OpenSubKey("SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Run");
					}
					else
					{
						registryKey2 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Run");
					}
					if (registryKey2 != null)
					{
						string[] valueNames = registryKey2.GetValueNames();
						string text12 = "";
						AddParentPart(valueNames.Length);
						if (!bCancelHealthCheck)
						{
							for (int i = 0; i < valueNames.Length; i++)
							{
								if (bCancelHealthCheck)
								{
									break;
								}
								tBar.set_Text(AddChildPartOne());
								Application.DoEvents();
								try
								{
									Application.DoEvents();
									text12 = (string)registryKey2.GetValue(valueNames[i], "");
									string pureFileNameRemoveParam = getPureFileNameRemoveParam(text12);
									bool isFileOk = false;
									try
									{
										isFileOk = Utils.FileExists(pureFileNameRemoveParam) || replaceFileNameWithParam(ref pureFileNameRemoveParam);
									}
									catch (Exception)
									{
									}
									if (pureFileNameRemoveParam.IndexOf('?') != -1)
									{
										continue;
									}
									string text15 = "[Run]HKCU" + Utils.SEPA + "SOFTWARE" + Utils.SEPA + "Wow6432Node" + Utils.SEPA + "Microsoft" + Utils.SEPA + "Windows" + Utils.SEPA + "CurrentVersion" + Utils.SEPA + "Run" + Utils.SEPA + valueNames[i] + " " + text12;
									string text10;
									string checkSum;
									if (!dictListOld.ContainsKey(text15.ToLower()))
									{
										text10 = ((!isFileOk) ? App.StringCheckSum(text15.ToLower()) : getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam));
										if (dictListNew.ContainsKey(text15))
										{
											continue;
										}
										dictListNew.Add(text15, text10 + "," + nowYYYYMMDD);
										sb.Append("신규[userRun6432]: HKCU" + Utils.SEPA + "SOFTWARE" + Utils.SEPA + "Wow6432Node" + Utils.SEPA + "Microsoft" + Utils.SEPA + "Windows" + Utils.SEPA + "CurrentVersion" + Utils.SEPA + "Run" + Utils.SEPA + valueNames[i] + " " + text12);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cnt++;
										if (!isFileOk)
										{
											continue;
										}
										text10 = getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam);
										if (!dictListOld.ContainsKey(pureFileNameRemoveParam.ToLower()))
										{
											if (!dictListNew.ContainsKey(pureFileNameRemoveParam))
											{
												dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
												sb.Append("신규: " + pureFileNameRemoveParam);
												sb.Append("\r\n");
												sb.Append(text10);
												sb.Append("\r\n");
												sb.Append("\r\n");
												cnt++;
											}
											continue;
										}
										checkSum = getCheckSum(dictListOld[pureFileNameRemoveParam.ToLower()]);
										if (!(text10 != checkSum))
										{
											continue;
										}
										try
										{
											if (dictListNew.ContainsKey(pureFileNameRemoveParam))
											{
												dictListNew.Remove(pureFileNameRemoveParam);
											}
											dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
											ListBeforeModifiedSHA_Add(checkSum);
											sb.Append("변조: " + pureFileNameRemoveParam);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
											DictNewedModifedSHA.Add(checkSum, text10);
										}
										catch (ArgumentException)
										{
										}
										continue;
									}
									text10 = getCheckSum(dictListOld[text15.ToLower()]);
									checkSum = getCheckSum(dictListOld[text15.ToLower()]);
									if (checkSum != text10)
									{
										try
										{
											dictListNew.Add(text15, text10 + "," + nowYYYYMMDD);
											ListBeforeModifiedSHA_Add(checkSum);
											sb.Append("변조[userRun6432]: HKCU" + Utils.SEPA + "SOFTWARE" + Utils.SEPA + "Wow6432Node" + Utils.SEPA + "Microsoft" + Utils.SEPA + "Windows" + Utils.SEPA + "CurrentVersion" + Utils.SEPA + "Run" + Utils.SEPA + valueNames[i] + " " + text12);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
										}
										catch (ArgumentException)
										{
										}
									}
									else
									{
										dictListNew.Add(text15, dictListOld[text15.ToLower()]);
										if (isFileOk)
										{
											try
											{
												getPureFileNameRemoveParam(pureFileNameRemoveParam);
												dictListNew.Add(pureFileNameRemoveParam, dictListOld[pureFileNameRemoveParam.ToLower()]);
											}
											catch (Exception)
											{
											}
										}
									}
									if (!isFileOk)
									{
										continue;
									}
									text10 = getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam);
									if (!dictListOld.ContainsKey(pureFileNameRemoveParam.ToLower()))
									{
										if (!dictListNew.ContainsKey(pureFileNameRemoveParam))
										{
											dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
											sb.Append("신규: " + pureFileNameRemoveParam);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
										}
										continue;
									}
									checkSum = getCheckSum(dictListOld[pureFileNameRemoveParam.ToLower()]);
									if (!(text10 != checkSum))
									{
										continue;
									}
									try
									{
										if (dictListNew.ContainsKey(pureFileNameRemoveParam))
										{
											dictListNew.Remove(pureFileNameRemoveParam);
										}
										dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
										ListBeforeModifiedSHA_Add(checkSum);
										sb.Append("변조: " + pureFileNameRemoveParam);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cnt++;
										DictNewedModifedSHA.Add(checkSum, text10);
									}
									catch (ArgumentException)
									{
									}
								}
								catch (Exception ex5)
								{
									strErrFilePath = "[19]" + text12;
									App.LogPut(ex5);
									isErrorOccored = true;
									break;
								}
							}
						}
					}
				}
				if (!bCancelHealthCheck)
				{
					if (Utils.Is64OS())
					{
						RegistryKey registryKey3 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
						registryKey2 = registryKey3.OpenSubKey("SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Run");
					}
					else
					{
						registryKey2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Run");
					}
					if (registryKey2 != null)
					{
						string[] valueNames = registryKey2.GetValueNames();
						string text12 = "";
						AddParentPart(valueNames.Length);
						if (!bCancelHealthCheck)
						{
							for (int i = 0; i < valueNames.Length; i++)
							{
								if (bCancelHealthCheck)
								{
									break;
								}
								tBar.set_Text(AddChildPartOne());
								Application.DoEvents();
								try
								{
									Application.DoEvents();
									text12 = (string)registryKey2.GetValue(valueNames[i], "");
									string pureFileNameRemoveParam = getPureFileNameRemoveParam(text12);
									bool isFileOk = false;
									try
									{
										isFileOk = Utils.FileExists(pureFileNameRemoveParam) || replaceFileNameWithParam(ref pureFileNameRemoveParam);
									}
									catch (Exception)
									{
									}
									if (pureFileNameRemoveParam.IndexOf('?') != -1)
									{
										continue;
									}
									string text15 = "[Run]" + Utils.SepaString("HKLM\\SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Run\\") + valueNames[i] + " " + text12;
									string text10;
									string checkSum;
									if (!dictListOld.ContainsKey(text15.ToLower()))
									{
										text10 = ((!isFileOk) ? App.StringCheckSum(text15.ToLower()) : getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam));
										if (dictListNew.ContainsKey(text15))
										{
											continue;
										}
										dictListNew.Add(text15, text10 + "," + nowYYYYMMDD);
										sb.Append("신규[allRun6432]: " + Utils.SepaString("HKLM\\SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Run\\") + valueNames[i] + " " + text12);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cnt++;
										if (!isFileOk)
										{
											continue;
										}
										text10 = getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam);
										if (!dictListOld.ContainsKey(pureFileNameRemoveParam.ToLower()))
										{
											if (!dictListNew.ContainsKey(pureFileNameRemoveParam))
											{
												dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
												sb.Append("신규: " + pureFileNameRemoveParam);
												sb.Append("\r\n");
												sb.Append(text10);
												sb.Append("\r\n");
												sb.Append("\r\n");
												cnt++;
											}
											continue;
										}
										checkSum = getCheckSum(dictListOld[pureFileNameRemoveParam.ToLower()]);
										if (!(text10 != checkSum))
										{
											continue;
										}
										try
										{
											if (dictListNew.ContainsKey(pureFileNameRemoveParam))
											{
												dictListNew.Remove(pureFileNameRemoveParam);
											}
											dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
											ListBeforeModifiedSHA_Add(checkSum);
											sb.Append("변조: " + pureFileNameRemoveParam);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
											DictNewedModifedSHA.Add(checkSum, text10);
										}
										catch (ArgumentException)
										{
										}
										continue;
									}
									text10 = getCheckSum(dictListOld[text15.ToLower()]);
									checkSum = getCheckSum(dictListOld[text15.ToLower()]);
									if (checkSum != text10)
									{
										try
										{
											dictListNew.Add(text15, text10 + "," + nowYYYYMMDD);
											ListBeforeModifiedSHA_Add(checkSum);
											sb.Append("변조[allRun6432]: " + Utils.SepaString("HKLM\\SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Run\\") + valueNames[i] + " " + text12);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
										}
										catch (ArgumentException)
										{
										}
									}
									else
									{
										dictListNew.Add(text15, dictListOld[text15.ToLower()]);
										if (isFileOk)
										{
											try
											{
												getPureFileNameRemoveParam(pureFileNameRemoveParam);
												dictListNew.Add(pureFileNameRemoveParam, dictListOld[pureFileNameRemoveParam.ToLower()]);
											}
											catch (Exception)
											{
											}
										}
									}
									if (!isFileOk)
									{
										continue;
									}
									text10 = getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam);
									if (!dictListOld.ContainsKey(pureFileNameRemoveParam.ToLower()))
									{
										if (!dictListNew.ContainsKey(pureFileNameRemoveParam))
										{
											dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
											sb.Append("신규: " + pureFileNameRemoveParam);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
										}
										continue;
									}
									checkSum = getCheckSum(dictListOld[pureFileNameRemoveParam.ToLower()]);
									if (!(text10 != checkSum))
									{
										continue;
									}
									try
									{
										if (dictListNew.ContainsKey(pureFileNameRemoveParam))
										{
											dictListNew.Remove(pureFileNameRemoveParam);
										}
										dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
										ListBeforeModifiedSHA_Add(checkSum);
										sb.Append("변조: " + pureFileNameRemoveParam);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cnt++;
										DictNewedModifedSHA.Add(checkSum, text10);
									}
									catch (ArgumentException)
									{
									}
								}
								catch (Exception ex5)
								{
									strErrFilePath = "[20]" + text12;
									App.LogPut(ex5);
									isErrorOccored = true;
									break;
								}
							}
						}
					}
				}
				if (!bCancelHealthCheck)
				{
					if (Utils.Is64OS())
					{
						RegistryKey registryKey3 = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
						registryKey2 = registryKey3.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\policies\\Explorer\\Run");
					}
					else
					{
						registryKey2 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\policies\\Explorer\\Run");
					}
					if (registryKey2 != null)
					{
						string[] valueNames = registryKey2.GetValueNames();
						string text12 = "";
						AddParentPart(valueNames.Length);
						if (!bCancelHealthCheck)
						{
							for (int i = 0; i < valueNames.Length; i++)
							{
								if (bCancelHealthCheck)
								{
									break;
								}
								tBar.set_Text(AddChildPartOne());
								Application.DoEvents();
								try
								{
									Application.DoEvents();
									text12 = (string)registryKey2.GetValue(valueNames[i], "");
									string pureFileNameRemoveParam = getPureFileNameRemoveParam(text12);
									bool isFileOk = false;
									try
									{
										isFileOk = Utils.FileExists(pureFileNameRemoveParam) || replaceFileNameWithParam(ref pureFileNameRemoveParam);
									}
									catch (Exception)
									{
									}
									if (pureFileNameRemoveParam.IndexOf('?') != -1)
									{
										continue;
									}
									string text15 = "[Run]" + Utils.SepaString("HKCU\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\policies\\Explorer\\Run\\") + valueNames[i] + " " + text12;
									string text10;
									string checkSum;
									if (!dictListOld.ContainsKey(text15.ToLower()))
									{
										text10 = ((!isFileOk) ? App.StringCheckSum(text15.ToLower()) : getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam));
										if (dictListNew.ContainsKey(text15))
										{
											continue;
										}
										dictListNew.Add(text15, text10 + "," + nowYYYYMMDD);
										sb.Append("신규[userRunPolicies]: " + Utils.SepaString("HKCU\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\policies\\Explorer\\Run\\") + valueNames[i] + " " + text12);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cnt++;
										if (!isFileOk)
										{
											continue;
										}
										text10 = getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam);
										if (!dictListOld.ContainsKey(pureFileNameRemoveParam.ToLower()))
										{
											if (!dictListNew.ContainsKey(pureFileNameRemoveParam))
											{
												dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
												sb.Append("신규: " + pureFileNameRemoveParam);
												sb.Append("\r\n");
												sb.Append(text10);
												sb.Append("\r\n");
												sb.Append("\r\n");
												cnt++;
											}
											continue;
										}
										checkSum = getCheckSum(dictListOld[pureFileNameRemoveParam.ToLower()]);
										if (!(text10 != checkSum))
										{
											continue;
										}
										try
										{
											if (dictListNew.ContainsKey(pureFileNameRemoveParam))
											{
												dictListNew.Remove(pureFileNameRemoveParam);
											}
											dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
											ListBeforeModifiedSHA_Add(checkSum);
											sb.Append("변조: " + pureFileNameRemoveParam);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
											DictNewedModifedSHA.Add(checkSum, text10);
										}
										catch (ArgumentException)
										{
										}
										continue;
									}
									text10 = getCheckSum(dictListOld[text15.ToLower()]);
									checkSum = getCheckSum(dictListOld[text15.ToLower()]);
									if (checkSum != text10)
									{
										try
										{
											dictListNew.Add(text15, text10 + "," + nowYYYYMMDD);
											ListBeforeModifiedSHA_Add(checkSum);
											sb.Append("변조[userRunPolicies]: " + Utils.SepaString("HKCU\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\policies\\Explorer\\Run\\") + valueNames[i] + " " + text12);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
										}
										catch (ArgumentException)
										{
										}
									}
									else
									{
										dictListNew.Add(text15, dictListOld[text15.ToLower()]);
										if (isFileOk)
										{
											try
											{
												getPureFileNameRemoveParam(pureFileNameRemoveParam);
												dictListNew.Add(pureFileNameRemoveParam, dictListOld[pureFileNameRemoveParam.ToLower()]);
											}
											catch (Exception)
											{
											}
										}
									}
									if (!isFileOk)
									{
										continue;
									}
									text10 = getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam);
									if (!dictListOld.ContainsKey(pureFileNameRemoveParam.ToLower()))
									{
										if (!dictListNew.ContainsKey(pureFileNameRemoveParam))
										{
											dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
											sb.Append("신규: " + pureFileNameRemoveParam);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
										}
										continue;
									}
									checkSum = getCheckSum(dictListOld[pureFileNameRemoveParam.ToLower()]);
									if (!(text10 != checkSum))
									{
										continue;
									}
									try
									{
										if (dictListNew.ContainsKey(pureFileNameRemoveParam))
										{
											dictListNew.Remove(pureFileNameRemoveParam);
										}
										dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
										ListBeforeModifiedSHA_Add(checkSum);
										sb.Append("변조: " + pureFileNameRemoveParam);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cnt++;
										DictNewedModifedSHA.Add(checkSum, text10);
									}
									catch (ArgumentException)
									{
									}
								}
								catch (Exception ex5)
								{
									strErrFilePath = "[21]" + text12;
									App.LogPut(ex5);
									isErrorOccored = true;
									break;
								}
							}
						}
					}
				}
				if (!bCancelHealthCheck)
				{
					if (Utils.Is64OS())
					{
						RegistryKey registryKey3 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
						registryKey2 = registryKey3.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\policies\\Explorer\\Run");
					}
					else
					{
						registryKey2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\policies\\Explorer\\Run");
					}
					if (registryKey2 != null)
					{
						string[] valueNames = registryKey2.GetValueNames();
						string text12 = "";
						AddParentPart(valueNames.Length);
						if (!bCancelHealthCheck)
						{
							for (int i = 0; i < valueNames.Length; i++)
							{
								if (bCancelHealthCheck)
								{
									break;
								}
								tBar.set_Text(AddChildPartOne());
								Application.DoEvents();
								try
								{
									Application.DoEvents();
									text12 = (string)registryKey2.GetValue(valueNames[i], "");
									string pureFileNameRemoveParam = getPureFileNameRemoveParam(text12);
									bool isFileOk = false;
									try
									{
										isFileOk = Utils.FileExists(pureFileNameRemoveParam) || replaceFileNameWithParam(ref pureFileNameRemoveParam);
									}
									catch (Exception)
									{
									}
									if (pureFileNameRemoveParam.IndexOf('?') != -1)
									{
										continue;
									}
									string text15 = "[Run]" + Utils.SepaString("HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\policies\\Explorer\\Run\\") + valueNames[i] + " " + text12;
									string text10;
									string checkSum;
									if (!dictListOld.ContainsKey(text15.ToLower()))
									{
										text10 = ((!isFileOk) ? App.StringCheckSum(text15.ToLower()) : getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam));
										if (dictListNew.ContainsKey(text15))
										{
											continue;
										}
										dictListNew.Add(text15, text10 + "," + nowYYYYMMDD);
										sb.Append("신규[allRunPolices]: " + Utils.SepaString("HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\policies\\Explorer\\Run\\") + valueNames[i] + " " + text12);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cnt++;
										if (!isFileOk)
										{
											continue;
										}
										text10 = getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam);
										if (!dictListOld.ContainsKey(pureFileNameRemoveParam.ToLower()))
										{
											if (!dictListNew.ContainsKey(pureFileNameRemoveParam))
											{
												dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
												sb.Append("신규: " + pureFileNameRemoveParam);
												sb.Append("\r\n");
												sb.Append(text10);
												sb.Append("\r\n");
												sb.Append("\r\n");
												cnt++;
											}
											continue;
										}
										checkSum = getCheckSum(dictListOld[pureFileNameRemoveParam.ToLower()]);
										if (!(text10 != checkSum))
										{
											continue;
										}
										try
										{
											if (dictListNew.ContainsKey(pureFileNameRemoveParam))
											{
												dictListNew.Remove(pureFileNameRemoveParam);
											}
											dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
											ListBeforeModifiedSHA_Add(checkSum);
											sb.Append("변조: " + pureFileNameRemoveParam);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
											DictNewedModifedSHA.Add(checkSum, text10);
										}
										catch (ArgumentException)
										{
										}
										continue;
									}
									text10 = getCheckSum(dictListOld[("[Run]" + Utils.SepaString("HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\policies\\Explorer\\Run\\") + valueNames[i] + " " + text12).ToLower()]);
									checkSum = getCheckSum(dictListOld[("[Run]" + Utils.SepaString("HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\policies\\Explorer\\Run\\") + valueNames[i] + " " + text12).ToLower()]);
									if (checkSum != text10)
									{
										try
										{
											dictListNew.Add("[Run]" + Utils.SepaString("HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\policies\\Explorer\\Run\\") + valueNames[i] + " " + text12, text10 + "," + nowYYYYMMDD);
											ListBeforeModifiedSHA_Add(checkSum);
											sb.Append("변조[allRunPolices]: " + Utils.SepaString("HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\policies\\Explorer\\Run\\") + valueNames[i] + " " + text12);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
										}
										catch (ArgumentException)
										{
										}
									}
									else
									{
										dictListNew.Add("[Run]" + Utils.SepaString("HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\policies\\Explorer\\Run\\") + valueNames[i] + " " + text12, dictListOld[("[Run]" + Utils.SepaString("HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\policies\\Explorer\\Run\\") + valueNames[i] + " " + text12).ToLower()]);
										if (isFileOk)
										{
											try
											{
												getPureFileNameRemoveParam(pureFileNameRemoveParam);
												dictListNew.Add(pureFileNameRemoveParam, dictListOld[pureFileNameRemoveParam.ToLower()]);
											}
											catch (Exception)
											{
											}
										}
									}
									if (!isFileOk)
									{
										continue;
									}
									text10 = getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam);
									if (!dictListOld.ContainsKey(pureFileNameRemoveParam.ToLower()))
									{
										if (!dictListNew.ContainsKey(pureFileNameRemoveParam))
										{
											dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
											sb.Append("신규: " + pureFileNameRemoveParam);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
										}
										continue;
									}
									checkSum = getCheckSum(dictListOld[pureFileNameRemoveParam.ToLower()]);
									if (!(text10 != checkSum))
									{
										continue;
									}
									try
									{
										if (dictListNew.ContainsKey(pureFileNameRemoveParam))
										{
											dictListNew.Remove(pureFileNameRemoveParam);
										}
										dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
										ListBeforeModifiedSHA_Add(checkSum);
										sb.Append("변조: " + pureFileNameRemoveParam);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cnt++;
										DictNewedModifedSHA.Add(checkSum, text10);
									}
									catch (ArgumentException)
									{
									}
								}
								catch (Exception ex5)
								{
									strErrFilePath = "[22]" + text12;
									App.LogPut(ex5);
									isErrorOccored = true;
									break;
								}
							}
						}
					}
				}
				if (!bCancelHealthCheck)
				{
					if (Utils.Is64OS())
					{
						RegistryKey registryKey3 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
						registryKey2 = registryKey3.OpenSubKey("Software\\Classes");
					}
					else
					{
						registryKey2 = Registry.LocalMachine.OpenSubKey("Software\\Classes");
					}
					if (registryKey2 != null)
					{
						string[] subKeyNames2 = registryKey2.GetSubKeyNames();
						string text12 = "";
						AddParentPart(subKeyNames2.Length);
						string text24 = "";
						if (!bCancelHealthCheck)
						{
							for (int i = 0; i < subKeyNames2.Length; i++)
							{
								tBar.set_Text(AddChildPartOne());
								if (subKeyNames2[i].StartsWith(".") || registryKey2.OpenSubKey(subKeyNames2[i])!.GetValue("URL Protocol") == null)
								{
									continue;
								}
								if (bCancelHealthCheck)
								{
									break;
								}
								Application.DoEvents();
								try
								{
									text12 = "";
									try
									{
										text12 = registryKey2.OpenSubKey(subKeyNames2[i])!.OpenSubKey("shell")!.OpenSubKey("open")!.OpenSubKey("command")!.GetValue("")!.ToString()!.Replace("%1", "").Replace("\"", "").Trim();
									}
									catch (Exception ex92)
									{
										Console.Error.WriteLine(ex92.Message);
									}
									string pureFileNameRemoveParam = getPureFileNameRemoveParam(text12);
									bool isFileOk = false;
									try
									{
										isFileOk = Utils.FileExists(pureFileNameRemoveParam) || replaceFileNameWithParam(ref pureFileNameRemoveParam);
										text24 = ((!isFileOk) ? "無" : "有");
									}
									catch (Exception)
									{
									}
									if (pureFileNameRemoveParam.IndexOf('?') != -1)
									{
										continue;
									}
									string text10;
									string checkSum;
									if (!dictListOld.ContainsKey(("[URL Protocol(All)]" + text24 + subKeyNames2[i] + " " + text12).ToLower()))
									{
										text10 = App.StringCheckSum(("[URL Protocol(All)]" + text24 + subKeyNames2[i] + " " + text12).ToLower());
										string text15 = "[URL Protocol(All)]" + text24 + subKeyNames2[i] + " " + text12;
										if (dictListNew.ContainsKey(text15))
										{
											continue;
										}
										dictListNew.Add(text15, text10 + "," + nowYYYYMMDD);
										sb.Append("신규[URL Protocol(All)]: " + text24 + subKeyNames2[i] + " " + text12);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cnt++;
										if (!isFileOk)
										{
											continue;
										}
										text10 = getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam);
										if (!dictListOld.ContainsKey(pureFileNameRemoveParam.ToLower()))
										{
											if (!dictListNew.ContainsKey(pureFileNameRemoveParam))
											{
												dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
												sb.Append("신규: " + pureFileNameRemoveParam);
												sb.Append("\r\n");
												sb.Append(text10);
												sb.Append("\r\n");
												sb.Append("\r\n");
												cnt++;
											}
											continue;
										}
										checkSum = getCheckSum(dictListOld[pureFileNameRemoveParam.ToLower()]);
										if (!(text10 != checkSum))
										{
											continue;
										}
										try
										{
											if (dictListNew.ContainsKey(pureFileNameRemoveParam))
											{
												dictListNew.Remove(pureFileNameRemoveParam);
											}
											dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
											ListBeforeModifiedSHA_Add(checkSum);
											sb.Append("변조: " + pureFileNameRemoveParam);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
											DictNewedModifedSHA.Add(checkSum, text10);
										}
										catch (ArgumentException)
										{
										}
										continue;
									}
									text10 = getCheckSum(dictListOld[("[URL Protocol(All)]" + text24 + subKeyNames2[i] + " " + text12).ToLower()]);
									checkSum = getCheckSum(dictListOld[("[URL Protocol(All)]" + text24 + subKeyNames2[i] + " " + text12).ToLower()]);
									if (checkSum != text10)
									{
										try
										{
											dictListNew.Add("[URL Protocol(All)]" + text24 + subKeyNames2[i] + " " + text12, text10 + "," + nowYYYYMMDD);
											ListBeforeModifiedSHA_Add(checkSum);
											sb.Append("변조[URL Protocol(All)]: " + text24 + subKeyNames2[i] + " " + text12);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
										}
										catch (ArgumentException)
										{
										}
									}
									else
									{
										string key = "[URL Protocol(All)]" + text24 + subKeyNames2[i] + " " + text12;
										if (!dictListNew.ContainsKey(key))
										{
											dictListNew.Add(key, dictListOld[("[URL Protocol(All)]" + text24 + subKeyNames2[i] + " " + text12).ToLower()]);
											if (isFileOk)
											{
												try
												{
													getPureFileNameRemoveParam(pureFileNameRemoveParam);
													if (!dictListNew.ContainsKey(pureFileNameRemoveParam))
													{
														dictListNew.Add(pureFileNameRemoveParam, dictListOld[pureFileNameRemoveParam.ToLower()]);
													}
												}
												catch (Exception)
												{
												}
											}
										}
									}
									if (!isFileOk)
									{
										continue;
									}
									text10 = getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam);
									if (!dictListOld.ContainsKey(pureFileNameRemoveParam.ToLower()))
									{
										if (!dictListNew.ContainsKey(pureFileNameRemoveParam))
										{
											dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
											sb.Append("신규: " + pureFileNameRemoveParam);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
										}
										continue;
									}
									checkSum = getCheckSum(dictListOld[pureFileNameRemoveParam.ToLower()]);
									if (!(text10 != checkSum))
									{
										continue;
									}
									try
									{
										if (dictListNew.ContainsKey(pureFileNameRemoveParam))
										{
											dictListNew.Remove(pureFileNameRemoveParam);
										}
										dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
										ListBeforeModifiedSHA_Add(checkSum);
										sb.Append("변조: " + pureFileNameRemoveParam);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cnt++;
										DictNewedModifedSHA.Add(checkSum, text10);
									}
									catch (ArgumentException)
									{
									}
								}
								catch (Exception ex5)
								{
									strErrFilePath = "[22.5]" + text12;
									App.LogPut(ex5);
									isErrorOccored = true;
									break;
								}
							}
						}
					}
				}
				if (!bCancelHealthCheck)
				{
					if (Utils.Is64OS())
					{
						RegistryKey registryKey3 = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
						registryKey2 = registryKey3.OpenSubKey("Software\\Classes");
					}
					else
					{
						registryKey2 = Registry.CurrentUser.OpenSubKey("Software\\Classes");
					}
					if (registryKey2 != null)
					{
						string[] subKeyNames2 = registryKey2.GetSubKeyNames();
						string text12 = "";
						AddParentPart(subKeyNames2.Length);
						string text24 = "";
						if (!bCancelHealthCheck)
						{
							for (int i = 0; i < subKeyNames2.Length; i++)
							{
								tBar.set_Text(AddChildPartOne());
								if (subKeyNames2[i].StartsWith(".") || registryKey2.OpenSubKey(subKeyNames2[i])!.GetValue("URL Protocol") == null)
								{
									continue;
								}
								if (bCancelHealthCheck)
								{
									break;
								}
								Application.DoEvents();
								try
								{
									text12 = "";
									try
									{
										text12 = registryKey2.OpenSubKey(subKeyNames2[i])!.OpenSubKey("shell")!.OpenSubKey("open")!.OpenSubKey("command")!.GetValue("")!.ToString()!.Replace("%1", "").Replace("\"", "").Trim();
									}
									catch (Exception ex92)
									{
										Console.Error.WriteLine(ex92.Message);
									}
									string pureFileNameRemoveParam = getPureFileNameRemoveParam(text12);
									bool isFileOk = false;
									try
									{
										isFileOk = Utils.FileExists(pureFileNameRemoveParam) || replaceFileNameWithParam(ref pureFileNameRemoveParam);
										text24 = ((!isFileOk) ? "無" : "有");
									}
									catch (Exception)
									{
									}
									if (pureFileNameRemoveParam.IndexOf('?') != -1)
									{
										continue;
									}
									string text10;
									string checkSum;
									if (!dictListOld.ContainsKey(("[URL Protocol(USER)]" + text24 + subKeyNames2[i] + " " + text12).ToLower()))
									{
										text10 = App.StringCheckSum(("[URL Protocol(USER)]" + text24 + subKeyNames2[i] + " " + text12).ToLower());
										string text15 = "[URL Protocol(USER)]" + text24 + subKeyNames2[i] + " " + text12;
										if (dictListNew.ContainsKey(text15))
										{
											continue;
										}
										dictListNew.Add(text15, text10 + "," + nowYYYYMMDD);
										sb.Append("신규[URL Protocol(USER)]: " + text24 + subKeyNames2[i] + " " + text12);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cnt++;
										if (!isFileOk)
										{
											continue;
										}
										text10 = getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam);
										if (!dictListOld.ContainsKey(pureFileNameRemoveParam.ToLower()))
										{
											if (!dictListNew.ContainsKey(pureFileNameRemoveParam))
											{
												dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
												sb.Append("신규: " + pureFileNameRemoveParam);
												sb.Append("\r\n");
												sb.Append(text10);
												sb.Append("\r\n");
												sb.Append("\r\n");
												cnt++;
											}
											continue;
										}
										checkSum = getCheckSum(dictListOld[pureFileNameRemoveParam.ToLower()]);
										if (!(text10 != checkSum))
										{
											continue;
										}
										try
										{
											if (dictListNew.ContainsKey(pureFileNameRemoveParam))
											{
												dictListNew.Remove(pureFileNameRemoveParam);
											}
											dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
											ListBeforeModifiedSHA_Add(checkSum);
											sb.Append("변조: " + pureFileNameRemoveParam);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
											DictNewedModifedSHA.Add(checkSum, text10);
										}
										catch (ArgumentException)
										{
										}
										continue;
									}
									text10 = getCheckSum(dictListOld[("[URL Protocol(USER)]" + text24 + subKeyNames2[i] + " " + text12).ToLower()]);
									checkSum = getCheckSum(dictListOld[("[URL Protocol(USER)]" + text24 + subKeyNames2[i] + " " + text12).ToLower()]);
									if (checkSum != text10)
									{
										try
										{
											dictListNew.Add("[URL Protocol(USER)]" + text24 + subKeyNames2[i] + " " + text12, text10 + "," + nowYYYYMMDD);
											ListBeforeModifiedSHA_Add(checkSum);
											sb.Append("변조[URL Protocol(USER)]: " + text24 + subKeyNames2[i] + " " + text12);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
										}
										catch (ArgumentException)
										{
										}
									}
									else
									{
										string key = "[URL Protocol(USER)]" + text24 + subKeyNames2[i] + " " + text12;
										if (!dictListNew.ContainsKey(key))
										{
											dictListNew.Add(key, dictListOld[("[URL Protocol(USER)]" + text24 + subKeyNames2[i] + " " + text12).ToLower()]);
											if (isFileOk)
											{
												try
												{
													getPureFileNameRemoveParam(pureFileNameRemoveParam);
													if (!dictListNew.ContainsKey(pureFileNameRemoveParam))
													{
														dictListNew.Add(pureFileNameRemoveParam, dictListOld[pureFileNameRemoveParam.ToLower()]);
													}
												}
												catch (Exception)
												{
												}
											}
										}
									}
									if (!isFileOk)
									{
										continue;
									}
									text10 = getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam);
									if (!dictListOld.ContainsKey(pureFileNameRemoveParam.ToLower()))
									{
										if (!dictListNew.ContainsKey(pureFileNameRemoveParam))
										{
											dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
											sb.Append("신규: " + pureFileNameRemoveParam);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
										}
										continue;
									}
									checkSum = getCheckSum(dictListOld[pureFileNameRemoveParam.ToLower()]);
									if (!(text10 != checkSum))
									{
										continue;
									}
									try
									{
										if (dictListNew.ContainsKey(pureFileNameRemoveParam))
										{
											dictListNew.Remove(pureFileNameRemoveParam);
										}
										dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
										ListBeforeModifiedSHA_Add(checkSum);
										sb.Append("변조: " + pureFileNameRemoveParam);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cnt++;
										DictNewedModifedSHA.Add(checkSum, text10);
									}
									catch (ArgumentException)
									{
									}
								}
								catch (Exception ex5)
								{
									strErrFilePath = "[22.6]" + text12;
									App.LogPut(ex5);
									isErrorOccored = true;
									break;
								}
							}
						}
					}
					if (Utils.Is64OS())
					{
						RegistryKey registryKey3 = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
						registryKey2 = registryKey3.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnce");
					}
					else
					{
						registryKey2 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnce");
					}
					if (registryKey2 != null)
					{
						string[] valueNames = registryKey2.GetValueNames();
						string text12 = "";
						AddParentPart(valueNames.Length);
						if (!bCancelHealthCheck)
						{
							for (int i = 0; i < valueNames.Length; i++)
							{
								if (bCancelHealthCheck)
								{
									break;
								}
								tBar.set_Text(AddChildPartOne());
								Application.DoEvents();
								try
								{
									Application.DoEvents();
									text12 = (string)registryKey2.GetValue(valueNames[i], "");
									string pureFileNameRemoveParam = getPureFileNameRemoveParam(text12);
									bool isFileOk = false;
									try
									{
										isFileOk = Utils.FileExists(pureFileNameRemoveParam) || replaceFileNameWithParam(ref pureFileNameRemoveParam);
									}
									catch (Exception)
									{
									}
									if (pureFileNameRemoveParam.IndexOf('?') != -1)
									{
										continue;
									}
									string text15 = "[RunOnce]" + Utils.SepaString("HKCU\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnce\\") + valueNames[i] + " " + text12;
									string text10;
									string checkSum;
									if (!dictListOld.ContainsKey(text15.ToLower()))
									{
										text10 = ((!isFileOk) ? App.StringCheckSum(text15.ToLower()) : getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam));
										if (dictListNew.ContainsKey(text15))
										{
											continue;
										}
										dictListNew.Add(text15, text10 + "," + nowYYYYMMDD);
										sb.Append("신규[userRunOnce]: " + Utils.SepaString("HKCU\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnce\\") + valueNames[i] + " " + text12);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cnt++;
										if (!isFileOk)
										{
											continue;
										}
										text10 = getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam);
										if (!dictListOld.ContainsKey(pureFileNameRemoveParam.ToLower()))
										{
											if (!dictListNew.ContainsKey(pureFileNameRemoveParam))
											{
												dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
												sb.Append("신규: " + pureFileNameRemoveParam);
												sb.Append("\r\n");
												sb.Append(text10);
												sb.Append("\r\n");
												sb.Append("\r\n");
												cnt++;
												text10 = App.FileCheckSum(pureFileNameRemoveParam);
												string text17 = "URO," + pureFileNameRemoveParam + "," + text10;
												if (!isApproval(text17).HasValue && !dictApprovalList.ContainsKey(text17.ToLower()))
												{
													sb.Append("미승인[userRunOnce]: " + pureFileNameRemoveParam);
													sb.Append("\r\n");
													sb.Append(text10);
													sb.Append("\r\n");
													sb.Append("\r\n");
													cntOfApproval++;
													itmListViewApproval.Add(ApprovalList.GetOrCreate(text17));
													dictApprovalList.Add(text17.ToLower(), text10);
												}
											}
											continue;
										}
										checkSum = getCheckSum(dictListOld[pureFileNameRemoveParam.ToLower()]);
										if (!(text10 != checkSum))
										{
											continue;
										}
										try
										{
											if (dictListNew.ContainsKey(pureFileNameRemoveParam))
											{
												dictListNew.Remove(pureFileNameRemoveParam);
											}
											dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
											ListBeforeModifiedSHA_Add(checkSum);
											sb.Append("변조: " + pureFileNameRemoveParam);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
											DictNewedModifedSHA.Add(checkSum, text10);
										}
										catch (ArgumentException)
										{
										}
										continue;
									}
									text10 = getCheckSum(dictListOld[text15.ToLower()]);
									checkSum = getCheckSum(dictListOld[text15.ToLower()]);
									if (checkSum != text10)
									{
										try
										{
											dictListNew.Add(text15, text10 + "," + nowYYYYMMDD);
											ListBeforeModifiedSHA_Add(checkSum);
											sb.Append("변조[userRunOnce]: " + Utils.SepaString("HKCU\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnce\\") + valueNames[i] + " " + text12);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
										}
										catch (ArgumentException)
										{
										}
									}
									else
									{
										dictListNew.Add(text15, dictListOld[text15.ToLower()]);
										if (isFileOk)
										{
											try
											{
												getPureFileNameRemoveParam(pureFileNameRemoveParam);
												dictListNew.Add(pureFileNameRemoveParam, dictListOld[pureFileNameRemoveParam.ToLower()]);
											}
											catch (Exception)
											{
											}
										}
									}
									if (!isFileOk)
									{
										continue;
									}
									text10 = getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam);
									if (!dictListOld.ContainsKey(pureFileNameRemoveParam.ToLower()))
									{
										if (!dictListNew.ContainsKey(pureFileNameRemoveParam))
										{
											dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
											sb.Append("신규: " + pureFileNameRemoveParam);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
											text10 = App.FileCheckSum(pureFileNameRemoveParam);
											string text17 = "ARO," + pureFileNameRemoveParam + "," + text10;
											if (!isApproval(text17).HasValue && !dictApprovalList.ContainsKey(text17.ToLower()))
											{
												sb.Append("미승인[allRunOnce]: " + pureFileNameRemoveParam);
												sb.Append("\r\n");
												sb.Append(text10);
												sb.Append("\r\n");
												sb.Append("\r\n");
												cntOfApproval++;
												itmListViewApproval.Add(ApprovalList.GetOrCreate(text17));
												dictApprovalList.Add(text17.ToLower(), text10);
											}
										}
										continue;
									}
									checkSum = getCheckSum(dictListOld[pureFileNameRemoveParam.ToLower()]);
									if (!(text10 != checkSum))
									{
										continue;
									}
									try
									{
										if (dictListNew.ContainsKey(pureFileNameRemoveParam))
										{
											dictListNew.Remove(pureFileNameRemoveParam);
										}
										dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
										ListBeforeModifiedSHA_Add(checkSum);
										sb.Append("변조: " + pureFileNameRemoveParam);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cnt++;
										DictNewedModifedSHA.Add(checkSum, text10);
									}
									catch (ArgumentException)
									{
									}
								}
								catch (Exception ex5)
								{
									strErrFilePath = "[23]" + text12;
									App.LogPut(ex5);
									isErrorOccored = true;
									break;
								}
							}
						}
					}
					if (Utils.Is64OS())
					{
						RegistryKey registryKey3 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
						registryKey2 = registryKey3.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnce");
					}
					else
					{
						registryKey2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnce");
					}
					if (registryKey2 != null)
					{
						string[] valueNames = registryKey2.GetValueNames();
						string text12 = "";
						AddParentPart(valueNames.Length);
						if (!bCancelHealthCheck)
						{
							for (int i = 0; i < valueNames.Length; i++)
							{
								if (bCancelHealthCheck)
								{
									break;
								}
								tBar.set_Text(AddChildPartOne());
								Application.DoEvents();
								try
								{
									Application.DoEvents();
									text12 = (string)registryKey2.GetValue(valueNames[i], "");
									string pureFileNameRemoveParam = getPureFileNameRemoveParam(text12);
									bool isFileOk = false;
									try
									{
										isFileOk = Utils.FileExists(pureFileNameRemoveParam) || replaceFileNameWithParam(ref pureFileNameRemoveParam);
									}
									catch (Exception)
									{
									}
									if (pureFileNameRemoveParam.IndexOf('?') != -1)
									{
										continue;
									}
									string text10;
									string checkSum;
									if (!dictListOld.ContainsKey(("[RunOnce]" + Utils.SepaString("HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnce\\") + valueNames[i] + " " + text12).ToLower()))
									{
										text10 = ((!isFileOk) ? App.StringCheckSum(("[RunOnce]" + Utils.SepaString("HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnce\\") + valueNames[i] + " " + text12).ToLower()) : getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam));
										string text15 = "[RunOnce]" + Utils.SepaString("HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnce\\") + valueNames[i] + " " + text12;
										if (dictListNew.ContainsKey(text15))
										{
											continue;
										}
										dictListNew.Add(text15, text10 + "," + nowYYYYMMDD);
										sb.Append("신규[allRunOnce]: " + Utils.SepaString("HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnce\\") + valueNames[i] + " " + text12);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cnt++;
										if (!isFileOk)
										{
											continue;
										}
										text10 = getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam);
										if (!dictListOld.ContainsKey(pureFileNameRemoveParam.ToLower()))
										{
											if (!dictListNew.ContainsKey(pureFileNameRemoveParam))
											{
												dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
												sb.Append("신규: " + pureFileNameRemoveParam);
												sb.Append("\r\n");
												sb.Append(text10);
												sb.Append("\r\n");
												sb.Append("\r\n");
												cnt++;
											}
											continue;
										}
										checkSum = getCheckSum(dictListOld[pureFileNameRemoveParam.ToLower()]);
										if (!(text10 != checkSum))
										{
											continue;
										}
										try
										{
											if (dictListNew.ContainsKey(pureFileNameRemoveParam))
											{
												dictListNew.Remove(pureFileNameRemoveParam);
											}
											dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
											ListBeforeModifiedSHA_Add(checkSum);
											sb.Append("변조: " + pureFileNameRemoveParam);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
											DictNewedModifedSHA.Add(checkSum, text10);
										}
										catch (ArgumentException)
										{
										}
										continue;
									}
									text10 = getCheckSum(dictListOld[("[RunOnce]" + Utils.SepaString("HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnce\\") + valueNames[i] + " " + text12).ToLower()]);
									checkSum = getCheckSum(dictListOld[("[RunOnce]" + Utils.SepaString("HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnce\\") + valueNames[i] + " " + text12).ToLower()]);
									if (checkSum != text10)
									{
										try
										{
											dictListNew.Add("[RunOnce]" + Utils.SepaString("HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnce\\") + valueNames[i] + " " + text12, text10 + "," + nowYYYYMMDD);
											ListBeforeModifiedSHA_Add(checkSum);
											sb.Append("변조[allRunOnce]: " + Utils.SepaString("HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnce\\") + valueNames[i] + " " + text12);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
										}
										catch (ArgumentException)
										{
										}
									}
									else
									{
										dictListNew.Add("[RunOnce]" + Utils.SepaString("HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnce\\") + valueNames[i] + " " + text12, dictListOld[("[RunOnce]" + Utils.SepaString("HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnce\\") + valueNames[i] + " " + text12).ToLower()]);
										if (isFileOk)
										{
											try
											{
												getPureFileNameRemoveParam(pureFileNameRemoveParam);
												dictListNew.Add(pureFileNameRemoveParam, dictListOld[pureFileNameRemoveParam.ToLower()]);
											}
											catch (Exception)
											{
											}
										}
									}
									if (!isFileOk)
									{
										continue;
									}
									text10 = getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam);
									if (!dictListOld.ContainsKey(pureFileNameRemoveParam.ToLower()))
									{
										if (!dictListNew.ContainsKey(pureFileNameRemoveParam))
										{
											dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
											sb.Append("신규: " + pureFileNameRemoveParam);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
										}
										continue;
									}
									checkSum = getCheckSum(dictListOld[pureFileNameRemoveParam.ToLower()]);
									if (!(text10 != checkSum))
									{
										continue;
									}
									try
									{
										if (dictListNew.ContainsKey(pureFileNameRemoveParam))
										{
											dictListNew.Remove(pureFileNameRemoveParam);
										}
										dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
										ListBeforeModifiedSHA_Add(checkSum);
										sb.Append("변조: " + pureFileNameRemoveParam);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cnt++;
										DictNewedModifedSHA.Add(checkSum, text10);
									}
									catch (ArgumentException)
									{
									}
								}
								catch (Exception ex5)
								{
									strErrFilePath = "[24]" + text12;
									App.LogPut(ex5);
									isErrorOccored = true;
									break;
								}
							}
						}
					}
					if (Utils.Is64OS())
					{
						RegistryKey registryKey3 = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
						registryKey2 = registryKey3.OpenSubKey("SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnce");
					}
					else
					{
						registryKey2 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnce");
					}
					if (registryKey2 != null)
					{
						string[] valueNames = registryKey2.GetValueNames();
						string text12 = "";
						AddParentPart(valueNames.Length);
						if (!bCancelHealthCheck)
						{
							for (int i = 0; i < valueNames.Length; i++)
							{
								if (bCancelHealthCheck)
								{
									break;
								}
								tBar.set_Text(AddChildPartOne());
								Application.DoEvents();
								try
								{
									Application.DoEvents();
									text12 = (string)registryKey2.GetValue(valueNames[i], "");
									string pureFileNameRemoveParam = getPureFileNameRemoveParam(text12);
									bool isFileOk = false;
									try
									{
										isFileOk = Utils.FileExists(pureFileNameRemoveParam) || replaceFileNameWithParam(ref pureFileNameRemoveParam);
									}
									catch (Exception)
									{
									}
									if (pureFileNameRemoveParam.IndexOf('?') != -1)
									{
										continue;
									}
									string text10;
									string checkSum;
									if (!dictListOld.ContainsKey(("[RunOnce]" + Utils.SepaString("HKCU\\SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnce\\") + valueNames[i] + " " + text12).ToLower()))
									{
										text10 = ((!isFileOk) ? App.StringCheckSum(("[RunOnce]" + Utils.SepaString("HKCU\\SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnce\\") + valueNames[i] + " " + text12).ToLower()) : getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam));
										string text15 = "[RunOnce]" + Utils.SepaString("HKCU\\SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnce\\") + valueNames[i] + " " + text12;
										if (dictListNew.ContainsKey(text15))
										{
											continue;
										}
										dictListNew.Add(text15, text10 + "," + nowYYYYMMDD);
										sb.Append("신규[userRunOnce6432]: " + Utils.SepaString("HKCU\\SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnce\\") + valueNames[i] + " " + text12);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cnt++;
										if (!isFileOk)
										{
											continue;
										}
										text10 = getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam);
										if (!dictListOld.ContainsKey(pureFileNameRemoveParam.ToLower()))
										{
											if (!dictListNew.ContainsKey(pureFileNameRemoveParam))
											{
												dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
												sb.Append("신규: " + pureFileNameRemoveParam);
												sb.Append("\r\n");
												sb.Append(text10);
												sb.Append("\r\n");
												sb.Append("\r\n");
												cnt++;
											}
											continue;
										}
										checkSum = getCheckSum(dictListOld[pureFileNameRemoveParam.ToLower()]);
										if (!(text10 != checkSum))
										{
											continue;
										}
										try
										{
											if (dictListNew.ContainsKey(pureFileNameRemoveParam))
											{
												dictListNew.Remove(pureFileNameRemoveParam);
											}
											dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
											ListBeforeModifiedSHA_Add(checkSum);
											sb.Append("변조: " + pureFileNameRemoveParam);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
											DictNewedModifedSHA.Add(checkSum, text10);
										}
										catch (ArgumentException)
										{
										}
										continue;
									}
									text10 = getCheckSum(dictListOld[("[RunOnce]" + Utils.SepaString("HKCU\\SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnce\\") + valueNames[i] + " " + text12).ToLower()]);
									checkSum = getCheckSum(dictListOld[("[RunOnce]" + Utils.SepaString("HKCU\\SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnce\\") + valueNames[i] + " " + text12).ToLower()]);
									if (checkSum != text10)
									{
										try
										{
											dictListNew.Add("[RunOnce]" + Utils.SepaString("HKCU\\SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnce\\") + valueNames[i] + " " + text12, text10 + "," + nowYYYYMMDD);
											ListBeforeModifiedSHA_Add(checkSum);
											sb.Append("변조[userRunOnce6432]: " + Utils.SepaString("HKCU\\SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnce\\") + valueNames[i] + " " + text12);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
										}
										catch (ArgumentException)
										{
										}
									}
									else
									{
										dictListNew.Add("[RunOnce]" + Utils.SepaString("HKCU\\SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnce\\") + valueNames[i] + " " + text12, dictListOld[("[RunOnce]" + Utils.SepaString("HKCU\\SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnce\\") + valueNames[i] + " " + text12).ToLower()]);
										if (isFileOk)
										{
											try
											{
												getPureFileNameRemoveParam(pureFileNameRemoveParam);
												dictListNew.Add(pureFileNameRemoveParam, dictListOld[pureFileNameRemoveParam.ToLower()]);
											}
											catch (Exception)
											{
											}
										}
									}
									if (!isFileOk)
									{
										continue;
									}
									text10 = getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam);
									if (!dictListOld.ContainsKey(pureFileNameRemoveParam.ToLower()))
									{
										if (!dictListNew.ContainsKey(pureFileNameRemoveParam))
										{
											dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
											sb.Append("신규: " + pureFileNameRemoveParam);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
										}
										continue;
									}
									checkSum = getCheckSum(dictListOld[pureFileNameRemoveParam.ToLower()]);
									if (!(text10 != checkSum))
									{
										continue;
									}
									try
									{
										if (dictListNew.ContainsKey(pureFileNameRemoveParam))
										{
											dictListNew.Remove(pureFileNameRemoveParam);
										}
										dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
										ListBeforeModifiedSHA_Add(checkSum);
										sb.Append("변조: " + pureFileNameRemoveParam);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cnt++;
										DictNewedModifedSHA.Add(checkSum, text10);
									}
									catch (ArgumentException)
									{
									}
								}
								catch (Exception ex5)
								{
									strErrFilePath = "[25]" + text12;
									App.LogPut(ex5);
									isErrorOccored = true;
									break;
								}
							}
						}
					}
					if (Utils.Is64OS())
					{
						RegistryKey registryKey3 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
						registryKey2 = registryKey3.OpenSubKey("SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnce");
					}
					else
					{
						registryKey2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnce");
					}
					if (registryKey2 != null)
					{
						string[] valueNames = registryKey2.GetValueNames();
						string text12 = "";
						AddParentPart(valueNames.Length);
						if (!bCancelHealthCheck)
						{
							for (int i = 0; i < valueNames.Length; i++)
							{
								if (bCancelHealthCheck)
								{
									break;
								}
								tBar.set_Text(AddChildPartOne());
								Application.DoEvents();
								try
								{
									Application.DoEvents();
									text12 = (string)registryKey2.GetValue(valueNames[i], "");
									string pureFileNameRemoveParam = getPureFileNameRemoveParam(text12);
									bool isFileOk = false;
									try
									{
										isFileOk = Utils.FileExists(pureFileNameRemoveParam) || replaceFileNameWithParam(ref pureFileNameRemoveParam);
									}
									catch (Exception)
									{
									}
									if (pureFileNameRemoveParam.IndexOf('?') != -1)
									{
										continue;
									}
									string text10;
									string checkSum;
									if (!dictListOld.ContainsKey(("[RunOnce]" + Utils.SepaString("HKLM\\SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnce\\") + valueNames[i] + " " + text12).ToLower()))
									{
										text10 = ((!isFileOk) ? App.StringCheckSum(("[RunOnce]" + Utils.SepaString("HKLM\\SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnce\\") + valueNames[i] + " " + text12).ToLower()) : getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam));
										string text15 = "[RunOnce]" + Utils.SepaString("HKLM\\SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnce\\") + valueNames[i] + " " + text12;
										if (dictListNew.ContainsKey(text15))
										{
											continue;
										}
										dictListNew.Add(text15, text10 + "," + nowYYYYMMDD);
										sb.Append("신규[allRunOnce6432]: " + Utils.SepaString("HKLM\\SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnce\\") + valueNames[i] + " " + text12);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cnt++;
										if (!isFileOk)
										{
											continue;
										}
										text10 = getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam);
										if (!dictListOld.ContainsKey(pureFileNameRemoveParam.ToLower()))
										{
											if (!dictListNew.ContainsKey(pureFileNameRemoveParam))
											{
												dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
												sb.Append("신규: " + pureFileNameRemoveParam);
												sb.Append("\r\n");
												sb.Append(text10);
												sb.Append("\r\n");
												sb.Append("\r\n");
												cnt++;
											}
											continue;
										}
										checkSum = getCheckSum(dictListOld[pureFileNameRemoveParam.ToLower()]);
										if (!(text10 != checkSum))
										{
											continue;
										}
										try
										{
											if (dictListNew.ContainsKey(pureFileNameRemoveParam))
											{
												dictListNew.Remove(pureFileNameRemoveParam);
											}
											dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
											ListBeforeModifiedSHA_Add(checkSum);
											sb.Append("변조: " + pureFileNameRemoveParam);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
											DictNewedModifedSHA.Add(checkSum, text10);
										}
										catch (ArgumentException)
										{
										}
										continue;
									}
									text10 = getCheckSum(dictListOld[("[RunOnce]" + Utils.SepaString("HKLM\\SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnce\\") + valueNames[i] + " " + text12).ToLower()]);
									checkSum = getCheckSum(dictListOld[("[RunOnce]" + Utils.SepaString("HKLM\\SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnce\\") + valueNames[i] + " " + text12).ToLower()]);
									pureFileNameRemoveParam = getPureFileNameRemoveParam(text12);
									isFileOk = Utils.FileExists(pureFileNameRemoveParam);
									if (checkSum != text10)
									{
										try
										{
											dictListNew.Add("[RunOnce]" + Utils.SepaString("HKLM\\SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnce\\") + valueNames[i] + " " + text12, text10 + "," + nowYYYYMMDD);
											ListBeforeModifiedSHA_Add(checkSum);
											sb.Append("변조[allRunOnce6432]: " + Utils.SepaString("HKLM\\SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnce\\") + valueNames[i] + " " + text12);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
										}
										catch (ArgumentException)
										{
										}
										continue;
									}
									dictListNew.Add("[RunOnce]" + Utils.SepaString("HKLM\\SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnce\\") + valueNames[i] + " " + text12, dictListOld[("[RunOnce]" + Utils.SepaString("HKLM\\SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnce\\") + valueNames[i] + " " + text12).ToLower()]);
									if (isFileOk)
									{
										try
										{
											getPureFileNameRemoveParam(pureFileNameRemoveParam);
											dictListNew.Add(pureFileNameRemoveParam, dictListOld[pureFileNameRemoveParam.ToLower()]);
										}
										catch (Exception)
										{
										}
									}
								}
								catch (Exception ex5)
								{
									strErrFilePath = "[26]" + text12;
									App.LogPut(ex5);
									isErrorOccored = true;
									break;
								}
							}
						}
					}
					if (Utils.Is64OS())
					{
						RegistryKey registryKey3 = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
						registryKey2 = registryKey3.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnceEx");
					}
					else
					{
						registryKey2 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnceEx");
					}
					if (registryKey2 != null)
					{
						string[] valueNames = registryKey2.GetValueNames();
						string text12 = "";
						AddParentPart(valueNames.Length);
						if (!bCancelHealthCheck)
						{
							for (int i = 0; i < valueNames.Length; i++)
							{
								if (bCancelHealthCheck)
								{
									break;
								}
								tBar.set_Text(AddChildPartOne());
								Application.DoEvents();
								try
								{
									Application.DoEvents();
									text12 = (string)registryKey2.GetValue(valueNames[i], "");
									string pureFileNameRemoveParam = getPureFileNameRemoveParam(text12);
									bool isFileOk = false;
									try
									{
										isFileOk = Utils.FileExists(pureFileNameRemoveParam) || replaceFileNameWithParam(ref pureFileNameRemoveParam);
									}
									catch (Exception)
									{
									}
									if (pureFileNameRemoveParam.IndexOf('?') != -1)
									{
										continue;
									}
									string text10;
									string checkSum;
									if (!dictListOld.ContainsKey(("[RunOnceEx]" + Utils.SepaString("HKCU\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnceEx\\") + valueNames[i] + " " + text12).ToLower()))
									{
										text10 = ((!isFileOk) ? App.StringCheckSum(("[RunOnceEx]" + Utils.SepaString("HKCU\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnceEx\\") + valueNames[i] + " " + text12).ToLower()) : getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam));
										string text15 = "[RunOnceEx]" + Utils.SepaString("HKCU\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnceEx\\") + valueNames[i] + " " + text12;
										if (dictListNew.ContainsKey(text15))
										{
											continue;
										}
										dictListNew.Add(text15, text10 + "," + nowYYYYMMDD);
										sb.Append("신규[userRunOnceEx]: " + Utils.SepaString("HKCU\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnceEx\\") + valueNames[i] + " " + text12);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cnt++;
										if (!isFileOk)
										{
											continue;
										}
										text10 = getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam);
										if (!dictListOld.ContainsKey(pureFileNameRemoveParam.ToLower()))
										{
											if (!dictListNew.ContainsKey(pureFileNameRemoveParam))
											{
												dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
												sb.Append("신규: " + pureFileNameRemoveParam);
												sb.Append("\r\n");
												sb.Append(text10);
												sb.Append("\r\n");
												sb.Append("\r\n");
												cnt++;
											}
											continue;
										}
										checkSum = getCheckSum(dictListOld[pureFileNameRemoveParam.ToLower()]);
										if (!(text10 != checkSum))
										{
											continue;
										}
										try
										{
											if (dictListNew.ContainsKey(pureFileNameRemoveParam))
											{
												dictListNew.Remove(pureFileNameRemoveParam);
											}
											dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
											ListBeforeModifiedSHA_Add(checkSum);
											sb.Append("변조: " + pureFileNameRemoveParam);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
											DictNewedModifedSHA.Add(checkSum, text10);
										}
										catch (ArgumentException)
										{
										}
										continue;
									}
									text10 = getCheckSum(dictListOld[("[RunOnceEx]" + Utils.SepaString("HKCU\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnceEx\\") + valueNames[i] + " " + text12).ToLower()]);
									checkSum = getCheckSum(dictListOld[("[RunOnceEx]" + Utils.SepaString("HKCU\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnceEx\\") + valueNames[i] + " " + text12).ToLower()]);
									if (checkSum != text10)
									{
										try
										{
											dictListNew.Add("[RunOnceEx]" + Utils.SepaString("HKCU\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnceEx\\") + valueNames[i] + " " + text12, text10 + "," + nowYYYYMMDD);
											ListBeforeModifiedSHA_Add(checkSum);
											sb.Append("변조[userRunOnceEx]: " + Utils.SepaString("HKCU\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnceEx\\") + valueNames[i] + " " + text12);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
										}
										catch (ArgumentException)
										{
										}
									}
									else
									{
										dictListNew.Add("[RunOnceEx]" + Utils.SepaString("HKCU\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnceEx\\") + valueNames[i] + " " + text12, dictListOld[("[RunOnceEx]" + Utils.SepaString("HKCU\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnceEx\\") + valueNames[i] + " " + text12).ToLower()]);
										if (isFileOk)
										{
											try
											{
												getPureFileNameRemoveParam(pureFileNameRemoveParam);
												dictListNew.Add(pureFileNameRemoveParam, dictListOld[pureFileNameRemoveParam.ToLower()]);
											}
											catch (Exception)
											{
											}
										}
									}
									if (!isFileOk)
									{
										continue;
									}
									text10 = getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam);
									if (!dictListOld.ContainsKey(pureFileNameRemoveParam.ToLower()))
									{
										if (!dictListNew.ContainsKey(pureFileNameRemoveParam))
										{
											dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
											sb.Append("신규: " + pureFileNameRemoveParam);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
										}
										continue;
									}
									checkSum = getCheckSum(dictListOld[pureFileNameRemoveParam.ToLower()]);
									if (!(text10 != checkSum))
									{
										continue;
									}
									try
									{
										if (dictListNew.ContainsKey(pureFileNameRemoveParam))
										{
											dictListNew.Remove(pureFileNameRemoveParam);
										}
										dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
										ListBeforeModifiedSHA_Add(checkSum);
										sb.Append("변조: " + pureFileNameRemoveParam);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cnt++;
										DictNewedModifedSHA.Add(checkSum, text10);
									}
									catch (ArgumentException)
									{
									}
								}
								catch (Exception ex5)
								{
									strErrFilePath = "[27]" + text12;
									App.LogPut(ex5);
									isErrorOccored = true;
									break;
								}
							}
						}
					}
					if (Utils.Is64OS())
					{
						RegistryKey registryKey3 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
						registryKey2 = registryKey3.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnceEx");
					}
					else
					{
						registryKey2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnceEx");
					}
					if (registryKey2 != null)
					{
						string[] valueNames = registryKey2.GetValueNames();
						string text12 = "";
						AddParentPart(valueNames.Length);
						if (!bCancelHealthCheck)
						{
							for (int i = 0; i < valueNames.Length; i++)
							{
								if (bCancelHealthCheck)
								{
									break;
								}
								tBar.set_Text(AddChildPartOne());
								Application.DoEvents();
								try
								{
									Application.DoEvents();
									text12 = (string)registryKey2.GetValue(valueNames[i], "");
									string pureFileNameRemoveParam = getPureFileNameRemoveParam(text12);
									bool isFileOk = false;
									try
									{
										isFileOk = Utils.FileExists(pureFileNameRemoveParam) || replaceFileNameWithParam(ref pureFileNameRemoveParam);
									}
									catch (Exception)
									{
									}
									if (pureFileNameRemoveParam.IndexOf('?') != -1)
									{
										continue;
									}
									string text10;
									string checkSum;
									if (!dictListOld.ContainsKey(("[RunOnceEx]" + Utils.SepaString("HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnceEx\\") + valueNames[i] + " " + text12).ToLower()))
									{
										text10 = ((!isFileOk) ? App.StringCheckSum(("[RunOnceEx]" + Utils.SepaString("HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnceEx\\") + valueNames[i] + " " + text12).ToLower()) : getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam));
										string text15 = "[RunOnceEx]" + Utils.SepaString("HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnceEx\\") + valueNames[i] + " " + text12;
										if (dictListNew.ContainsKey(text15))
										{
											continue;
										}
										dictListNew.Add(text15, text10 + "," + nowYYYYMMDD);
										sb.Append("신규[allRunOnceEx]: " + Utils.SepaString("HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnceEx\\") + valueNames[i] + " " + text12);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cnt++;
										if (!isFileOk)
										{
											continue;
										}
										text10 = getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam);
										if (!dictListOld.ContainsKey(pureFileNameRemoveParam.ToLower()))
										{
											if (!dictListNew.ContainsKey(pureFileNameRemoveParam))
											{
												dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
												sb.Append("신규: " + pureFileNameRemoveParam);
												sb.Append("\r\n");
												sb.Append(text10);
												sb.Append("\r\n");
												sb.Append("\r\n");
												cnt++;
											}
											continue;
										}
										checkSum = getCheckSum(dictListOld[pureFileNameRemoveParam.ToLower()]);
										if (!(text10 != checkSum))
										{
											continue;
										}
										try
										{
											if (dictListNew.ContainsKey(pureFileNameRemoveParam))
											{
												dictListNew.Remove(pureFileNameRemoveParam);
											}
											dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
											ListBeforeModifiedSHA_Add(checkSum);
											sb.Append("변조: " + pureFileNameRemoveParam);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
											DictNewedModifedSHA.Add(checkSum, text10);
										}
										catch (ArgumentException)
										{
										}
										continue;
									}
									text10 = getCheckSum(dictListOld[("[RunOnceEx]" + Utils.SepaString("HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnceEx\\") + valueNames[i] + " " + text12).ToLower()]);
									checkSum = getCheckSum(dictListOld[("[RunOnceEx]" + Utils.SepaString("HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnceEx\\") + valueNames[i] + " " + text12).ToLower()]);
									if (checkSum != text10)
									{
										try
										{
											dictListNew.Add("[RunOnceEx]" + Utils.SepaString("HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnceEx\\") + valueNames[i] + " " + text12, text10 + "," + nowYYYYMMDD);
											ListBeforeModifiedSHA_Add(checkSum);
											sb.Append("변조[allRunOnceEx]: " + Utils.SepaString("HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnceEx\\") + valueNames[i] + " " + text12);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
										}
										catch (ArgumentException)
										{
										}
									}
									else
									{
										dictListNew.Add("[RunOnceEx]" + Utils.SepaString("HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnceEx\\") + valueNames[i] + " " + text12, dictListOld[("[RunOnceEx]" + Utils.SepaString("HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnceEx\\") + valueNames[i] + " " + text12).ToLower()]);
										if (isFileOk)
										{
											try
											{
												getPureFileNameRemoveParam(pureFileNameRemoveParam);
												dictListNew.Add(pureFileNameRemoveParam, dictListOld[pureFileNameRemoveParam.ToLower()]);
											}
											catch (Exception)
											{
											}
										}
									}
									if (!isFileOk)
									{
										continue;
									}
									text10 = getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam);
									if (!dictListOld.ContainsKey(pureFileNameRemoveParam.ToLower()))
									{
										if (!dictListNew.ContainsKey(pureFileNameRemoveParam))
										{
											dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
											sb.Append("신규: " + pureFileNameRemoveParam);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
										}
										continue;
									}
									checkSum = getCheckSum(dictListOld[pureFileNameRemoveParam.ToLower()]);
									if (!(text10 != checkSum))
									{
										continue;
									}
									try
									{
										if (dictListNew.ContainsKey(pureFileNameRemoveParam))
										{
											dictListNew.Remove(pureFileNameRemoveParam);
										}
										dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
										ListBeforeModifiedSHA_Add(checkSum);
										sb.Append("변조: " + pureFileNameRemoveParam);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cnt++;
										DictNewedModifedSHA.Add(checkSum, text10);
									}
									catch (ArgumentException)
									{
									}
								}
								catch (Exception ex5)
								{
									strErrFilePath = "[28]" + text12;
									App.LogPut(ex5);
									isErrorOccored = true;
									break;
								}
							}
						}
					}
					if (Utils.Is64OS())
					{
						RegistryKey registryKey3 = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
						registryKey2 = registryKey3.OpenSubKey("SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnceEx");
					}
					else
					{
						registryKey2 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnceEx");
					}
					if (registryKey2 != null)
					{
						string[] valueNames = registryKey2.GetValueNames();
						string text12 = "";
						AddParentPart(valueNames.Length);
						if (!bCancelHealthCheck)
						{
							for (int i = 0; i < valueNames.Length; i++)
							{
								if (bCancelHealthCheck)
								{
									break;
								}
								tBar.set_Text(AddChildPartOne());
								Application.DoEvents();
								try
								{
									Application.DoEvents();
									text12 = (string)registryKey2.GetValue(valueNames[i], "");
									string pureFileNameRemoveParam = getPureFileNameRemoveParam(text12);
									bool isFileOk = false;
									try
									{
										isFileOk = Utils.FileExists(pureFileNameRemoveParam) || replaceFileNameWithParam(ref pureFileNameRemoveParam);
									}
									catch (Exception)
									{
									}
									if (pureFileNameRemoveParam.IndexOf('?') != -1)
									{
										continue;
									}
									string text10;
									string checkSum;
									if (!dictListOld.ContainsKey(("[RunOnceEx]" + Utils.SepaString("HKCU\\SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnceEx\\") + valueNames[i] + " " + text12).ToLower()))
									{
										text10 = ((!isFileOk) ? App.StringCheckSum(("[RunOnceEx]" + Utils.SepaString("HKCU\\SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnceEx\\") + valueNames[i] + " " + text12).ToLower()) : getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam));
										string text15 = "[RunOnceEx]" + Utils.SepaString("HKCU\\SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnceEx\\") + valueNames[i] + " " + text12;
										if (dictListNew.ContainsKey(text15))
										{
											continue;
										}
										dictListNew.Add(text15, text10 + "," + nowYYYYMMDD);
										sb.Append("신규[userRunOnceEx6432]: " + Utils.SepaString("HKCU\\SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnceEx\\") + valueNames[i] + " " + text12);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cnt++;
										if (!isFileOk)
										{
											continue;
										}
										text10 = getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam);
										if (!dictListOld.ContainsKey(pureFileNameRemoveParam.ToLower()))
										{
											if (!dictListNew.ContainsKey(pureFileNameRemoveParam))
											{
												dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
												sb.Append("신규: " + pureFileNameRemoveParam);
												sb.Append("\r\n");
												sb.Append(text10);
												sb.Append("\r\n");
												sb.Append("\r\n");
												cnt++;
											}
											continue;
										}
										checkSum = getCheckSum(dictListOld[pureFileNameRemoveParam.ToLower()]);
										if (!(text10 != checkSum))
										{
											continue;
										}
										try
										{
											if (dictListNew.ContainsKey(pureFileNameRemoveParam))
											{
												dictListNew.Remove(pureFileNameRemoveParam);
											}
											dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
											ListBeforeModifiedSHA_Add(checkSum);
											sb.Append("변조: " + pureFileNameRemoveParam);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
											DictNewedModifedSHA.Add(checkSum, text10);
										}
										catch (ArgumentException)
										{
										}
										continue;
									}
									text10 = getCheckSum(dictListOld[("[RunOnceEx]" + Utils.SepaString("HKCU\\SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnceEx\\") + valueNames[i] + " " + text12).ToLower()]);
									checkSum = getCheckSum(dictListOld[("[RunOnceEx]" + Utils.SepaString("HKCU\\SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnceEx\\") + valueNames[i] + " " + text12).ToLower()]);
									if (checkSum != text10)
									{
										try
										{
											dictListNew.Add("[RunOnceEx]" + Utils.SepaString("HKCU\\SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnceEx\\") + valueNames[i] + " " + text12, text10 + "," + nowYYYYMMDD);
											ListBeforeModifiedSHA_Add(checkSum);
											sb.Append("변조[userRunOnceEx6432]: " + Utils.SepaString("HKCU\\SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnceEx\\") + valueNames[i] + " " + text12);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
										}
										catch (ArgumentException)
										{
										}
									}
									else
									{
										dictListNew.Add("[RunOnceEx]" + Utils.SepaString("HKCU\\SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnceEx\\") + valueNames[i] + " " + text12, dictListOld[("[RunOnceEx]" + Utils.SepaString("HKCU\\SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnceEx\\") + valueNames[i] + " " + text12).ToLower()]);
										if (isFileOk)
										{
											try
											{
												getPureFileNameRemoveParam(pureFileNameRemoveParam);
												dictListNew.Add(pureFileNameRemoveParam, dictListOld[pureFileNameRemoveParam.ToLower()]);
											}
											catch (Exception)
											{
											}
										}
									}
									if (!isFileOk)
									{
										continue;
									}
									text10 = getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam);
									if (!dictListOld.ContainsKey(pureFileNameRemoveParam.ToLower()))
									{
										if (!dictListNew.ContainsKey(pureFileNameRemoveParam))
										{
											dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
											sb.Append("신규: " + pureFileNameRemoveParam);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
										}
										continue;
									}
									checkSum = getCheckSum(dictListOld[pureFileNameRemoveParam.ToLower()]);
									if (!(text10 != checkSum))
									{
										continue;
									}
									try
									{
										if (dictListNew.ContainsKey(pureFileNameRemoveParam))
										{
											dictListNew.Remove(pureFileNameRemoveParam);
										}
										dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
										ListBeforeModifiedSHA_Add(checkSum);
										sb.Append("변조: " + pureFileNameRemoveParam);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cnt++;
										DictNewedModifedSHA.Add(checkSum, text10);
									}
									catch (ArgumentException)
									{
									}
								}
								catch (Exception ex5)
								{
									strErrFilePath = "[29]" + text12;
									App.LogPut(ex5);
									isErrorOccored = true;
									break;
								}
							}
						}
					}
					if (Utils.Is64OS())
					{
						RegistryKey registryKey3 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
						registryKey2 = registryKey3.OpenSubKey("SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnceEx");
					}
					else
					{
						registryKey2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnceEx");
					}
					if (registryKey2 != null)
					{
						string[] valueNames = registryKey2.GetValueNames();
						string text12 = "";
						AddParentPart(valueNames.Length);
						if (!bCancelHealthCheck)
						{
							for (int i = 0; i < valueNames.Length; i++)
							{
								if (bCancelHealthCheck)
								{
									break;
								}
								tBar.set_Text(AddChildPartOne());
								Application.DoEvents();
								try
								{
									Application.DoEvents();
									text12 = (string)registryKey2.GetValue(valueNames[i], "");
									string pureFileNameRemoveParam = getPureFileNameRemoveParam(text12);
									bool isFileOk = false;
									try
									{
										isFileOk = Utils.FileExists(pureFileNameRemoveParam) || replaceFileNameWithParam(ref pureFileNameRemoveParam);
									}
									catch (Exception)
									{
									}
									if (pureFileNameRemoveParam.IndexOf('?') != -1)
									{
										continue;
									}
									string text10;
									string checkSum;
									if (!dictListOld.ContainsKey(("[RunOnceEx]" + Utils.SepaString("HKLM\\SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnceEx\\") + valueNames[i] + " " + text12).ToLower()))
									{
										text10 = ((!isFileOk) ? App.StringCheckSum(("[RunOnceEx]" + Utils.SepaString("HKLM\\SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnceEx\\") + valueNames[i] + " " + text12).ToLower()) : getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam));
										string text15 = "[RunOnceEx]" + Utils.SepaString("HKLM\\SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnceEx\\") + valueNames[i] + " " + text12;
										if (dictListNew.ContainsKey(text15))
										{
											continue;
										}
										dictListNew.Add(text15, text10 + "," + nowYYYYMMDD);
										sb.Append("신규[allRunOnceEx6432]: " + Utils.SepaString("HKLM\\SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnceEx\\") + valueNames[i] + " " + text12);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cnt++;
										if (!isFileOk)
										{
											continue;
										}
										text10 = getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam);
										if (!dictListOld.ContainsKey(pureFileNameRemoveParam.ToLower()))
										{
											if (!dictListNew.ContainsKey(pureFileNameRemoveParam))
											{
												dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
												sb.Append("신규: " + pureFileNameRemoveParam);
												sb.Append("\r\n");
												sb.Append(text10);
												sb.Append("\r\n");
												sb.Append("\r\n");
												cnt++;
											}
											continue;
										}
										checkSum = getCheckSum(dictListOld[pureFileNameRemoveParam.ToLower()]);
										if (!(text10 != checkSum))
										{
											continue;
										}
										try
										{
											if (dictListNew.ContainsKey(pureFileNameRemoveParam))
											{
												dictListNew.Remove(pureFileNameRemoveParam);
											}
											dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
											ListBeforeModifiedSHA_Add(checkSum);
											sb.Append("변조: " + pureFileNameRemoveParam);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
											DictNewedModifedSHA.Add(checkSum, text10);
										}
										catch (ArgumentException)
										{
										}
										continue;
									}
									text10 = getCheckSum(dictListOld[("[RunOnceEx]" + Utils.SepaString("HKLM\\SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnceEx\\") + valueNames[i] + " " + text12).ToLower()]);
									checkSum = getCheckSum(dictListOld[("[RunOnceEx]" + Utils.SepaString("HKLM\\SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnceEx\\") + valueNames[i] + " " + text12).ToLower()]);
									if (checkSum != text10)
									{
										try
										{
											dictListNew.Add("[RunOnceEx]" + Utils.SepaString("HKLM\\SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnceEx\\") + valueNames[i] + " " + text12, text10 + "," + nowYYYYMMDD);
											ListBeforeModifiedSHA_Add(checkSum);
											sb.Append("변조[allRunOnceEx6432]: " + Utils.SepaString("HKLM\\SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnceEx\\") + valueNames[i] + " " + text12);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
										}
										catch (ArgumentException)
										{
										}
									}
									else
									{
										dictListNew.Add("[RunOnceEx]" + Utils.SepaString("HKLM\\SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnceEx\\") + valueNames[i] + " " + text12, dictListOld[("[RunOnceEx]" + Utils.SepaString("HKLM\\SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnceEx\\") + valueNames[i] + " " + text12).ToLower()]);
										if (isFileOk)
										{
											try
											{
												getPureFileNameRemoveParam(pureFileNameRemoveParam);
												dictListNew.Add(pureFileNameRemoveParam, dictListOld[pureFileNameRemoveParam.ToLower()]);
											}
											catch (Exception)
											{
											}
										}
									}
									if (!isFileOk)
									{
										continue;
									}
									text10 = getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam);
									if (!dictListOld.ContainsKey(pureFileNameRemoveParam.ToLower()))
									{
										if (!dictListNew.ContainsKey(pureFileNameRemoveParam))
										{
											dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
											sb.Append("신규: " + pureFileNameRemoveParam);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
										}
										continue;
									}
									checkSum = getCheckSum(dictListOld[pureFileNameRemoveParam.ToLower()]);
									if (!(text10 != checkSum))
									{
										continue;
									}
									try
									{
										if (dictListNew.ContainsKey(pureFileNameRemoveParam))
										{
											dictListNew.Remove(pureFileNameRemoveParam);
										}
										dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
										ListBeforeModifiedSHA_Add(checkSum);
										sb.Append("변조: " + pureFileNameRemoveParam);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cnt++;
										DictNewedModifedSHA.Add(checkSum, text10);
									}
									catch (ArgumentException)
									{
									}
								}
								catch (Exception ex5)
								{
									strErrFilePath = "[30]" + text12;
									App.LogPut(ex5);
									isErrorOccored = true;
									break;
								}
							}
						}
					}
				}
				if (!bCancelHealthCheck)
				{
					if (Utils.Is64OS())
					{
						RegistryKey registryKey3 = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
						registryKey2 = registryKey3.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Browser Helper Objects");
					}
					else
					{
						registryKey2 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Browser Helper Objects");
					}
					if (registryKey2 != null)
					{
						string[] subKeyNames = registryKey2.GetSubKeyNames();
						string text12 = "";
						AddParentPart(subKeyNames.Length);
						if (!bCancelHealthCheck)
						{
							for (int i = 0; i < subKeyNames.Length; i++)
							{
								if (bCancelHealthCheck)
								{
									break;
								}
								tBar.set_Text(AddChildPartOne());
								Application.DoEvents();
								try
								{
									Application.DoEvents();
									text12 = Utils.SepaString("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Browser Helper Objects\\") + subKeyNames[i];
									if (Utils.Is64OS())
									{
										RegistryKey registryKey3 = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
										registryKey2 = registryKey3.OpenSubKey(text12);
									}
									else
									{
										registryKey2 = Registry.CurrentUser.OpenSubKey(text12);
									}
									text12 = "HKCU" + Utils.SEPA + text12;
									object obj = text12;
									text12 = string.Concat(obj, "[", registryKey2.GetValue(""), "]");
									if (Utils.Is64OS())
									{
										RegistryKey registryKey3 = RegistryKey.OpenBaseKey(RegistryHive.ClassesRoot, RegistryView.Registry64);
										registryKey2 = registryKey3.OpenSubKey("CLSID" + Utils.SEPA + subKeyNames[i] + Utils.SEPA + "InprocServer32");
									}
									else
									{
										registryKey2 = Registry.ClassesRoot.OpenSubKey("CLSID" + Utils.SEPA + subKeyNames[i] + Utils.SEPA + "InprocServer32");
									}
									string pureFileNameRemoveParam = "";
									if (registryKey2 != null)
									{
										pureFileNameRemoveParam = (string)registryKey2.GetValue("");
									}
									bool isFileOk = false;
									try
									{
										replaceStartsWithSpecialFolder(ref pureFileNameRemoveParam);
										isFileOk = Utils.FileExists(pureFileNameRemoveParam) || replaceFileNameWithParam(ref pureFileNameRemoveParam);
									}
									catch (Exception)
									{
									}
									replaceStartsWithSpecialFolder(ref text12);
									text12 += pureFileNameRemoveParam;
									string text10;
									string checkSum;
									if (!dictListOld.ContainsKey(("[BHO]" + subKeyNames[i] + " " + text12).ToLower()))
									{
										text10 = App.StringCheckSum(("[BHO]" + subKeyNames[i] + " " + text12).ToLower());
										string text15 = "[BHO]" + subKeyNames[i] + " " + text12;
										if (dictListNew.ContainsKey(text15))
										{
											continue;
										}
										dictListNew.Add(text15, text10 + "," + nowYYYYMMDD);
										sb.Append("신규[userBHO]: " + text12);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cnt++;
										if (!isFileOk)
										{
											continue;
										}
										text10 = getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam);
										if (!dictListOld.ContainsKey(pureFileNameRemoveParam.ToLower()))
										{
											if (!dictListNew.ContainsKey(pureFileNameRemoveParam))
											{
												dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
												sb.Append("신규: " + pureFileNameRemoveParam);
												sb.Append("\r\n");
												sb.Append(text10);
												sb.Append("\r\n");
												sb.Append("\r\n");
												cnt++;
											}
										}
										else
										{
											checkSum = getCheckSum(dictListOld[pureFileNameRemoveParam.ToLower()]);
											if (text10 != checkSum)
											{
												try
												{
													if (dictListNew.ContainsKey(pureFileNameRemoveParam))
													{
														dictListNew.Remove(pureFileNameRemoveParam);
													}
													dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
													ListBeforeModifiedSHA_Add(checkSum);
													sb.Append("변조: " + pureFileNameRemoveParam);
													sb.Append("\r\n");
													sb.Append(text10);
													sb.Append("\r\n");
													sb.Append("\r\n");
													cnt++;
													DictNewedModifedSHA.Add(checkSum, text10);
												}
												catch (ArgumentException)
												{
												}
											}
										}
										try
										{
											getPureFileNameRemoveParam(pureFileNameRemoveParam);
											text10 = App.FileCheckSum(pureFileNameRemoveParam);
											dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
											string text17 = "BU," + pureFileNameRemoveParam + "," + text10;
											if (!isApproval(text17).HasValue && !dictApprovalList.ContainsKey(text17.ToLower()))
											{
												sb.Append("미승인[UserBHO]: " + pureFileNameRemoveParam);
												sb.Append("\r\n");
												sb.Append(text10);
												sb.Append("\r\n");
												sb.Append("\r\n");
												cntOfApproval++;
												itmListViewApproval.Add(ApprovalList.GetOrCreate(text17));
												dictApprovalList.Add(text17.ToLower(), text10);
											}
										}
										catch (Exception)
										{
										}
										continue;
									}
									text10 = getCheckSum(dictListOld[("[BHO]" + subKeyNames[i] + " " + text12).ToLower()]);
									checkSum = getCheckSum(dictListOld[("[BHO]" + subKeyNames[i] + " " + text12).ToLower()]);
									if (checkSum != text10)
									{
										try
										{
											dictListNew.Add("[BHO]" + subKeyNames[i] + " " + text12, text10 + "," + nowYYYYMMDD);
											ListBeforeModifiedSHA_Add(checkSum);
											sb.Append("변조[userBHO]:  " + text12);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
										}
										catch (ArgumentException)
										{
										}
									}
									else
									{
										dictListNew.Add("[BHO]" + subKeyNames[i] + " " + text12, dictListOld[("[BHO]" + subKeyNames[i] + " " + text12).ToLower()]);
										if (isFileOk)
										{
											try
											{
												getPureFileNameRemoveParam(pureFileNameRemoveParam);
												dictListNew.Add(pureFileNameRemoveParam, dictListOld[pureFileNameRemoveParam.ToLower()]);
												text10 = App.FileCheckSum(pureFileNameRemoveParam);
												string text17 = "BU," + pureFileNameRemoveParam + "," + text10;
												if (!isApproval(text17).HasValue && !dictApprovalList.ContainsKey(text17.ToLower()))
												{
													sb.Append("미승인[UserBHO]: " + pureFileNameRemoveParam);
													sb.Append("\r\n");
													sb.Append(text10);
													sb.Append("\r\n");
													sb.Append("\r\n");
													cntOfApproval++;
													itmListViewApproval.Add(ApprovalList.GetOrCreate(text17));
													dictApprovalList.Add(text17.ToLower(), text10);
												}
											}
											catch (Exception)
											{
											}
										}
									}
									if (!isFileOk)
									{
										continue;
									}
									text10 = getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam);
									if (!dictListOld.ContainsKey(pureFileNameRemoveParam.ToLower()))
									{
										if (!dictListNew.ContainsKey(pureFileNameRemoveParam))
										{
											dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
											sb.Append("신규: " + pureFileNameRemoveParam);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
										}
										continue;
									}
									checkSum = getCheckSum(dictListOld[pureFileNameRemoveParam.ToLower()]);
									if (!(text10 != checkSum))
									{
										continue;
									}
									try
									{
										if (dictListNew.ContainsKey(pureFileNameRemoveParam))
										{
											dictListNew.Remove(pureFileNameRemoveParam);
										}
										dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
										ListBeforeModifiedSHA_Add(checkSum);
										sb.Append("변조: " + pureFileNameRemoveParam);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cnt++;
										DictNewedModifedSHA.Add(checkSum, text10);
									}
									catch (ArgumentException)
									{
									}
								}
								catch (Exception ex5)
								{
									strErrFilePath = "[31]" + text12;
									App.LogPut(ex5);
									isErrorOccored = true;
									break;
								}
							}
						}
					}
				}
				if (!bCancelHealthCheck)
				{
					if (Utils.Is64OS())
					{
						RegistryKey registryKey3 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
						registryKey2 = registryKey3.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Browser Helper Objects");
					}
					else
					{
						registryKey2 = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Browser Helper Objects");
					}
					if (registryKey2 != null)
					{
						string[] subKeyNames = registryKey2.GetSubKeyNames();
						string text12 = "";
						AddParentPart(subKeyNames.Length);
						if (!bCancelHealthCheck)
						{
							for (int i = 0; i < subKeyNames.Length; i++)
							{
								if (bCancelHealthCheck)
								{
									break;
								}
								tBar.set_Text(AddChildPartOne());
								Application.DoEvents();
								try
								{
									Application.DoEvents();
									text12 = Utils.SepaString("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Browser Helper Objects\\") + subKeyNames[i];
									if (Utils.Is64OS())
									{
										RegistryKey registryKey3 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
										registryKey2 = registryKey3.OpenSubKey(text12);
									}
									else
									{
										registryKey2 = Registry.LocalMachine.OpenSubKey(text12);
									}
									text12 = "HKLM" + Utils.SEPA + text12;
									object obj = text12;
									text12 = string.Concat(obj, "[", registryKey2.GetValue(""), "]");
									if (Utils.Is64OS())
									{
										RegistryKey registryKey3 = RegistryKey.OpenBaseKey(RegistryHive.ClassesRoot, RegistryView.Registry64);
										registryKey2 = registryKey3.OpenSubKey("CLSID" + Utils.SEPA + subKeyNames[i] + Utils.SEPA + "InprocServer32");
									}
									else
									{
										registryKey2 = Registry.ClassesRoot.OpenSubKey("CLSID" + Utils.SEPA + subKeyNames[i] + Utils.SEPA + "InprocServer32");
									}
									string pureFileNameRemoveParam = "";
									if (registryKey2 != null)
									{
										pureFileNameRemoveParam = (string)registryKey2.GetValue("");
									}
									bool isFileOk = false;
									try
									{
										replaceStartsWithSpecialFolder(ref pureFileNameRemoveParam);
										isFileOk = Utils.FileExists(pureFileNameRemoveParam) || replaceFileNameWithParam(ref pureFileNameRemoveParam);
									}
									catch (Exception)
									{
									}
									replaceStartsWithSpecialFolder(ref text12);
									text12 += pureFileNameRemoveParam;
									string text10;
									string checkSum;
									if (!dictListOld.ContainsKey(("[BHO]" + subKeyNames[i] + " " + text12).ToLower()))
									{
										text10 = App.StringCheckSum(("[BHO]" + subKeyNames[i] + " " + text12).ToLower());
										string text15 = "[BHO]" + subKeyNames[i] + " " + text12;
										if (dictListNew.ContainsKey(text15))
										{
											continue;
										}
										dictListNew.Add(text15, text10 + "," + nowYYYYMMDD);
										sb.Append("신규[alluserBHO]: " + text12);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cnt++;
										if (!isFileOk)
										{
											continue;
										}
										text10 = getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam);
										if (!dictListOld.ContainsKey(pureFileNameRemoveParam.ToLower()))
										{
											if (!dictListNew.ContainsKey(pureFileNameRemoveParam))
											{
												dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
												sb.Append("신규: " + pureFileNameRemoveParam);
												sb.Append("\r\n");
												sb.Append(text10);
												sb.Append("\r\n");
												sb.Append("\r\n");
												cnt++;
											}
										}
										else
										{
											checkSum = getCheckSum(dictListOld[pureFileNameRemoveParam.ToLower()]);
											if (text10 != checkSum)
											{
												try
												{
													if (dictListNew.ContainsKey(pureFileNameRemoveParam))
													{
														dictListNew.Remove(pureFileNameRemoveParam);
													}
													dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
													ListBeforeModifiedSHA_Add(checkSum);
													sb.Append("변조: " + pureFileNameRemoveParam);
													sb.Append("\r\n");
													sb.Append(text10);
													sb.Append("\r\n");
													sb.Append("\r\n");
													cnt++;
													DictNewedModifedSHA.Add(checkSum, text10);
												}
												catch (ArgumentException)
												{
												}
											}
										}
										try
										{
											getPureFileNameRemoveParam(pureFileNameRemoveParam);
											text10 = App.FileCheckSum(pureFileNameRemoveParam);
											dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
											string text17 = "BA," + pureFileNameRemoveParam + "," + text10;
											if (!isApproval(text17).HasValue && !dictApprovalList.ContainsKey(text17.ToLower()))
											{
												sb.Append("미승인[AllBHO]: " + pureFileNameRemoveParam);
												sb.Append("\r\n");
												sb.Append(text10);
												sb.Append("\r\n");
												sb.Append("\r\n");
												cntOfApproval++;
												itmListViewApproval.Add(ApprovalList.GetOrCreate(text17));
												dictApprovalList.Add(text17.ToLower(), text10);
											}
										}
										catch (Exception)
										{
										}
										continue;
									}
									text10 = getCheckSum(dictListOld[("[BHO]" + subKeyNames[i] + " " + text12).ToLower()]);
									checkSum = getCheckSum(dictListOld[("[BHO]" + subKeyNames[i] + " " + text12).ToLower()]);
									if (checkSum != text10)
									{
										try
										{
											dictListNew.Add("[BHO]" + subKeyNames[i] + " " + text12, text10 + "," + nowYYYYMMDD);
											ListBeforeModifiedSHA_Add(checkSum);
											sb.Append("변조[alluserBHO]:  " + text12);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
										}
										catch (ArgumentException)
										{
										}
									}
									else
									{
										dictListNew.Add("[BHO]" + subKeyNames[i] + " " + text12, dictListOld[("[BHO]" + subKeyNames[i] + " " + text12).ToLower()]);
										if (isFileOk)
										{
											try
											{
												getPureFileNameRemoveParam(pureFileNameRemoveParam);
												dictListNew.Add(pureFileNameRemoveParam, dictListOld[pureFileNameRemoveParam.ToLower()]);
												text10 = App.FileCheckSum(pureFileNameRemoveParam);
												string text17 = "BA," + pureFileNameRemoveParam + "," + text10;
												if (!isApproval(text17).HasValue && !dictApprovalList.ContainsKey(text17.ToLower()))
												{
													sb.Append("미승인[AllBHO]: " + pureFileNameRemoveParam);
													sb.Append("\r\n");
													sb.Append(text10);
													sb.Append("\r\n");
													sb.Append("\r\n");
													cntOfApproval++;
													itmListViewApproval.Add(ApprovalList.GetOrCreate(text17));
													dictApprovalList.Add(text17.ToLower(), text10);
												}
											}
											catch (Exception)
											{
											}
										}
									}
									if (!isFileOk)
									{
										continue;
									}
									text10 = getNowCheckSumFast(flag, isFileOk, pureFileNameRemoveParam);
									if (!dictListOld.ContainsKey(pureFileNameRemoveParam.ToLower()))
									{
										if (!dictListNew.ContainsKey(pureFileNameRemoveParam))
										{
											dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
											sb.Append("신규: " + pureFileNameRemoveParam);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
										}
										continue;
									}
									checkSum = getCheckSum(dictListOld[pureFileNameRemoveParam.ToLower()]);
									if (!(text10 != checkSum))
									{
										continue;
									}
									try
									{
										if (dictListNew.ContainsKey(pureFileNameRemoveParam))
										{
											dictListNew.Remove(pureFileNameRemoveParam);
										}
										dictListNew.Add(pureFileNameRemoveParam, text10 + "," + nowYYYYMMDD);
										ListBeforeModifiedSHA_Add(checkSum);
										sb.Append("변조: " + pureFileNameRemoveParam);
										sb.Append("\r\n");
										sb.Append(text10);
										sb.Append("\r\n");
										sb.Append("\r\n");
										cnt++;
										DictNewedModifedSHA.Add(checkSum, text10);
									}
									catch (ArgumentException)
									{
									}
								}
								catch (Exception ex5)
								{
									strErrFilePath = "[32]" + text12;
									App.LogPut(ex5);
									isErrorOccored = true;
									break;
								}
							}
						}
					}
				}
				if (!bCancelHealthCheck)
				{
					if (Utils.Is64OS())
					{
						RegistryKey registryKey3 = RegistryKey.OpenBaseKey(RegistryHive.ClassesRoot, RegistryView.Registry64);
						registryKey2 = registryKey3.OpenSubKey("Installer\\Assemblies");
					}
					else
					{
						registryKey2 = Registry.ClassesRoot.OpenSubKey("Installer\\Assemblies");
					}
					if (registryKey2 != null)
					{
						string[] subKeyNames = registryKey2.GetSubKeyNames();
						string text12 = "";
						AddParentPart(subKeyNames.Length);
						if (!bCancelHealthCheck)
						{
							for (int i = 0; i < subKeyNames.Length; i++)
							{
								if (bCancelHealthCheck)
								{
									break;
								}
								tBar.set_Text(AddChildPartOne());
								Application.DoEvents();
								try
								{
									Application.DoEvents();
									text12 = subKeyNames[i].Replace("|", Utils.SEPA);
									if (-1 >= text12.IndexOf(":"))
									{
										continue;
									}
									FileInfo fileInfo = new FileInfo(text12);
									if (!fileInfo.Exists)
									{
										continue;
									}
									string text10;
									if (!dictListOld.ContainsKey(fileInfo.FullName.ToLower()))
									{
										if (!dictListNew.ContainsKey(fileInfo.FullName))
										{
											text10 = App.FileCheckSum(fileInfo.FullName);
											dictListNew.Add(fileInfo.FullName, text10 + "," + nowYYYYMMDD);
											sb.Append("신규: " + fileInfo.FullName);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
										}
										continue;
									}
									string maxFileSystemDate = getMaxFileSystemDate(fileInfo.FullName);
									bool flag6 = false;
									string checkDate = getCheckDate(dictListOld[fileInfo.FullName.ToLower()]);
									if (maxFileSystemDate.CompareTo(checkDate) >= 0)
									{
										flag6 = true;
									}
									text10 = ((!flag && !flag6 && !isSpecilThreatFile(fileInfo.FullName, strWindowsFolder)) ? getCheckSum(dictListOld[fileInfo.FullName.ToLower()]) : App.FileCheckSum(fileInfo.FullName));
									string checkSum = getCheckSum(dictListOld[fileInfo.FullName.ToLower()]);
									if (checkSum != text10)
									{
										try
										{
											dictListNew.Add(fileInfo.FullName, text10 + "," + nowYYYYMMDD);
											ListBeforeModifiedSHA_Add(checkSum);
											sb.Append("변조: " + fileInfo.FullName);
											sb.Append("\r\n");
											sb.Append(text10);
											sb.Append("\r\n");
											sb.Append("\r\n");
											cnt++;
											DictNewedModifedSHA.Add(checkSum, text10);
										}
										catch (ArgumentException)
										{
										}
									}
									else
									{
										try
										{
											dictListNew.Add(fileInfo.FullName, dictListOld[fileInfo.FullName.ToLower()]);
										}
										catch (ArgumentException)
										{
										}
									}
								}
								catch (Exception ex5)
								{
									strErrFilePath = "[33]" + text12;
									App.LogPut(ex5);
									isErrorOccored = true;
									break;
								}
							}
						}
					}
				}
				if (!bCancelHealthCheck)
				{
					if (Utils.Is64OS())
					{
						RegistryKey registryKey3 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
						registryKey2 = registryKey3.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths");
					}
					else
					{
						registryKey2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths");
					}
					if (registryKey2 != null)
					{
						string[] subKeyNames = registryKey2.GetSubKeyNames();
						string text12 = "";
						AddParentPart(subKeyNames.Length);
						if (!bCancelHealthCheck)
						{
							for (int i = 0; i < subKeyNames.Length; i++)
							{
								if (bCancelHealthCheck)
								{
									break;
								}
								tBar.set_Text(AddChildPartOne());
								Application.DoEvents();
								try
								{
									Application.DoEvents();
									RegistryKey registryKey5;
									if (Utils.Is64OS())
									{
										RegistryKey registryKey3 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
										registryKey5 = registryKey3.OpenSubKey(Utils.SepaString("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\") + subKeyNames[i]);
									}
									else
									{
										registryKey5 = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\") + subKeyNames[i]);
									}
									string[] valueNames3 = registryKey5.GetValueNames();
									for (int j = 0; j < valueNames3.Count() && j < 5; j++)
									{
										text12 = getPureFileNameRemoveParam(registryKey5.GetValue(valueNames3[j])!.ToString());
										if (-1 >= text12.IndexOf(":") || !Utils.FileExists(text12))
										{
											continue;
										}
										FileInfo fileInfo = new FileInfo(text12);
										if (!fileInfo.Exists)
										{
											continue;
										}
										string text10;
										if (!dictListOld.ContainsKey(fileInfo.FullName.ToLower()))
										{
											if (!dictListNew.ContainsKey(fileInfo.FullName))
											{
												text10 = App.FileCheckSum(fileInfo.FullName);
												dictListNew.Add(fileInfo.FullName, text10 + "," + nowYYYYMMDD);
												sb.Append("신규: " + fileInfo.FullName);
												sb.Append("\r\n");
												sb.Append(text10);
												sb.Append("\r\n");
												sb.Append("\r\n");
												cnt++;
											}
											continue;
										}
										string maxFileSystemDate = getMaxFileSystemDate(fileInfo.FullName);
										bool flag6 = false;
										string checkDate = getCheckDate(dictListOld[fileInfo.FullName.ToLower()]);
										if (maxFileSystemDate.CompareTo(checkDate) >= 0)
										{
											flag6 = true;
										}
										text10 = ((!flag && !flag6 && !isSpecilThreatFile(fileInfo.FullName, strWindowsFolder)) ? getCheckSum(dictListOld[fileInfo.FullName.ToLower()]) : App.FileCheckSum(fileInfo.FullName));
										string checkSum = getCheckSum(dictListOld[fileInfo.FullName.ToLower()]);
										if (checkSum != text10)
										{
											try
											{
												dictListNew.Add(fileInfo.FullName, text10 + "," + nowYYYYMMDD);
												ListBeforeModifiedSHA_Add(checkSum);
												sb.Append("변조: " + fileInfo.FullName);
												sb.Append("\r\n");
												sb.Append(text10);
												sb.Append("\r\n");
												sb.Append("\r\n");
												cnt++;
												DictNewedModifedSHA.Add(checkSum, text10);
											}
											catch (ArgumentException)
											{
											}
										}
										else
										{
											try
											{
												dictListNew.Add(fileInfo.FullName, dictListOld[fileInfo.FullName.ToLower()]);
											}
											catch (ArgumentException)
											{
											}
										}
									}
								}
								catch (Exception ex5)
								{
									strErrFilePath = "[34]" + text12;
									App.LogPut(ex5);
									isErrorOccored = true;
									break;
								}
							}
						}
					}
				}
				if (!bCancelHealthCheck)
				{
					if (Utils.Is64OS())
					{
						RegistryKey registryKey3 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
						registryKey2 = registryKey3.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall");
					}
					else
					{
						registryKey2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall");
					}
					if (registryKey2 != null)
					{
						string[] subKeyNames = registryKey2.GetSubKeyNames();
						string text12 = "";
						AddParentPart(subKeyNames.Length);
						if (!bCancelHealthCheck)
						{
							for (int i = 0; i < subKeyNames.Length; i++)
							{
								if (bCancelHealthCheck)
								{
									break;
								}
								tBar.set_Text(AddChildPartOne());
								Application.DoEvents();
								try
								{
									Application.DoEvents();
									RegistryKey registryKey5;
									if (Utils.Is64OS())
									{
										RegistryKey registryKey3 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
										registryKey5 = registryKey3.OpenSubKey(Utils.SepaString("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\") + subKeyNames[i]);
									}
									else
									{
										registryKey5 = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\") + subKeyNames[i]);
									}
									string text25 = (string)registryKey5.GetValue("InstallLocation");
									if (text25 == null || -1 >= text25.IndexOf(":") || !Directory.Exists(text25) || dictListOld.ContainsKey(text25.ToLower()))
									{
										continue;
									}
									dictListOld.Add(text25.ToLower(), "");
									text2 = text25;
									num2 = 210;
									DirectoryInfo directoryInfo3 = new DirectoryInfo(text2);
									FileInfo[] array11 = directoryInfo3.GetFiles();
									array11 = directoryInfo3.GetFiles();
									AddParentPart(array11.Count());
									if (bCancelHealthCheck)
									{
										continue;
									}
									for (int m = 0; m < array11.Count() && !bCancelHealthCheck; m++)
									{
										tBar.set_Text(AddChildPartOne());
										Application.DoEvents();
										string text9 = array11[m].Extension.ToLower();
										switch (text9)
										{
										default:
											if (!(text9 == ".npc"))
											{
												continue;
											}
											break;
										case ".exe":
										case ".dll":
										case ".ocx":
										case ".com":
										case ".scr":
										case ".pif":
											break;
										}
										string text10;
										if (!dictListOld.ContainsKey(array11[m].FullName.ToLower()))
										{
											if (!dictListNew.ContainsKey(array11[m].FullName))
											{
												text10 = App.FileCheckSum(array11[m].FullName);
												dictListNew.Add(array11[m].FullName, text10 + "," + nowYYYYMMDD);
												sb.Append("신규: " + array11[m].FullName);
												sb.Append("\r\n");
												sb.Append(text10);
												sb.Append("\r\n");
												sb.Append("\r\n");
												cnt++;
											}
											continue;
										}
										string maxFileSystemDate = getMaxFileSystemDate(array11[m].FullName);
										bool flag6 = false;
										string checkDate = getCheckDate(dictListOld[array11[m].FullName.ToLower()]);
										if (maxFileSystemDate.CompareTo(checkDate) >= 0)
										{
											flag6 = true;
										}
										text10 = ((!flag && !flag6 && !isSpecilThreatFile(array11[m].FullName, strWindowsFolder)) ? getCheckSum(dictListOld[array11[m].FullName.ToLower()]) : App.FileCheckSum(array11[m].FullName));
										string checkSum = getCheckSum(dictListOld[array11[m].FullName.ToLower()]);
										if (checkSum != text10)
										{
											try
											{
												dictListNew.Add(array11[m].FullName, text10 + "," + nowYYYYMMDD);
												ListBeforeModifiedSHA_Add(checkSum);
												sb.Append("변조: " + array11[m].FullName);
												sb.Append("\r\n");
												sb.Append(text10);
												sb.Append("\r\n");
												sb.Append("\r\n");
												cnt++;
												DictNewedModifedSHA.Add(checkSum, text10);
											}
											catch (ArgumentException)
											{
											}
										}
										else
										{
											try
											{
												dictListNew.Add(array11[m].FullName, dictListOld[array11[m].FullName.ToLower()]);
											}
											catch (ArgumentException)
											{
											}
										}
									}
								}
								catch (Exception ex5)
								{
									strErrFilePath = "[35]" + text12;
									App.LogPut(ex5);
									isErrorOccored = true;
									break;
								}
							}
						}
					}
				}
				if (bCancelHealthCheck)
				{
					return;
				}
				text2 = strWindowsFolder + Utils.SEPA + "System32" + Utils.SEPA + "drivers" + Utils.SEPA + "etc";
				num2 = 220;
				directoryInfo = new DirectoryInfo(text2);
				if (directoryInfo == null)
				{
					return;
				}
				array5 = directoryInfo.GetFiles();
				string text26 = "";
				AddParentPart(array5.Count());
				if (bCancelHealthCheck)
				{
					return;
				}
				for (int i = 0; i < array5.Count(); i++)
				{
					if (bCancelHealthCheck)
					{
						break;
					}
					tBar.set_Text(AddChildPartOne());
					Application.DoEvents();
					try
					{
						Application.DoEvents();
						string text9 = array5[i].Extension.ToLower();
						text26 = "[hosts]notepad " + array5[i].FullName;
						string text10;
						if (!dictListOld.ContainsKey(text26.ToLower()))
						{
							text10 = App.FileCheckSum(array5[i].FullName);
							if (!dictListNew.ContainsKey(text26))
							{
								dictListNew.Add(text26, text10 + "," + nowYYYYMMDD);
								sb.Append("신규Host: " + text26);
								sb.Append("\r\n");
								sb.Append(text10);
								sb.Append("\r\n");
								sb.Append("\r\n");
								cnt++;
							}
							continue;
						}
						bool flag6 = false;
						string maxFileSystemDate = getMaxFileSystemDate(array5[i].FullName);
						string checkDate = getCheckDate(dictListOld[text26.ToLower()]);
						if (maxFileSystemDate.CompareTo(checkDate) >= 0)
						{
							flag6 = true;
						}
						text10 = ((!flag && !flag6) ? getCheckSum(dictListOld[text26.ToLower()]) : App.FileCheckSum(array5[i].FullName));
						string checkSum = getCheckSum(dictListOld[text26.ToLower()]);
						if (checkSum != text10)
						{
							try
							{
								dictListNew.Add(text26, text10 + "," + nowYYYYMMDD);
								ListBeforeModifiedSHA_Add(checkSum);
								sb.Append("변조Host: " + text26);
								sb.Append("\r\n");
								sb.Append(text10);
								sb.Append("\r\n");
								sb.Append("\r\n");
								cnt++;
							}
							catch (ArgumentException)
							{
							}
						}
						else
						{
							dictListNew.Add(text26, dictListOld[text26.ToLower()]);
						}
					}
					catch (Exception ex5)
					{
						strErrFilePath = "[36]" + text26;
						App.LogPut(ex5);
						isErrorOccored = true;
						break;
					}
				}
			}
			catch (Exception ex161)
			{
				Console.WriteLine(ex161.StackTrace);
				if (commandLineArgs.Count() == 1)
				{
					MessageBox.Show(ex161.Message + "\n[" + text2 + "]\n{" + num2 + "}->clipboard", ((Window)this).get_Title(), (MessageBoxButton)0, (MessageBoxImage)48);
					MessageBox.Show(ex161.StackTrace, ((Window)this).get_Title(), (MessageBoxButton)0, (MessageBoxImage)48);
					Clipboard.SetText("[" + text2 + "]\n{" + num2 + "}");
				}
			}
			finally
			{
				if (isErrorOccored)
				{
					sb.Append("진단도중 도중 오류발생" + strErrFilePath);
					sb.Append("\r\n");
				}
				else if (0 < strErrFilePath.Length)
				{
					sb.Append("진단도중 도중 오류 아닌 경고" + strErrFilePath);
					sb.Append("\r\n");
				}
				if (dictListNew.Count > 0)
				{
					if (cnt == 0)
					{
						sb.Append("-컴퓨터 건강 진단 완료-\n");
						int cntOfMinoError = 0;
						if (RegiHelperSrc.IsOldVaccine)
						{
							((Control)txtHealthReport).set_Background((Brush)(object)Brushes.get_LightPink());
							((UIElement)lblHelp).set_Visibility((Visibility)2);
							((Control)txtHealthReport).set_Padding(new Thickness(2.0, 2.0, 2.0, 2.0));
							if (RegiHelperSrc.IsOldVaccine36)
							{
								sb.Append("  -▶ 디스크 조각모음이 권장됩니다.{ 메뉴 > 보안기능 > [성능 컨설팅]디스크 조각모음 }\n");
							}
							else
							{
								sb.Append("-▶백신 접종 기간이 오래되었습니다.-\n");
							}
							cntOfMinoError++;
						}
						GetHardDiskTemperatureInfo(sb, ref cnt, ref cntOfMinoError);
						GetHardDiskFreeSpaceInfo(sb, ref cnt, ref cntOfMinoError);
						string tempPath = getTempPath();
						if (tempPath != null)
						{
							text2 = tempPath;
							num2 = 230;
							DirectoryInfo directoryInfo4 = new DirectoryInfo(text2);
							int num6 = directoryInfo4.GetFiles().Count();
							if (500 < num6)
							{
								if (((Control)txtHealthReport).get_Background() == Brushes.get_WhiteSmoke())
								{
									((Control)txtHealthReport).set_Background((Brush)(object)Brushes.get_LightPink());
									((UIElement)lblHelp).set_Visibility((Visibility)2);
								}
								sb.Append("-▶임시파일이 너무 많습니다. ( " + num6 + " 개 )\n");
								sb.Append("  ▶[보안기능]메뉴에서 [비만 처방]을 클릭하면 임시폴더가 열립니다.-\n");
								cntOfMinoError++;
							}
						}
						double num7 = Convert.ToDouble(App.iniFile.ReadValueDefault("WarningRecycleGB", "10"));
						long num8 = GetRecycleSize() / 1024L / 1024L / 1024L;
						if (num7 < (double)num8)
						{
							if (((Control)txtHealthReport).get_Background() == Brushes.get_WhiteSmoke())
							{
								((Control)txtHealthReport).set_Background((Brush)(object)Brushes.get_LightPink());
								((UIElement)lblHelp).set_Visibility((Visibility)2);
							}
							sb.Append("-▶휴지통 사이즈 ( " + num8 + " GB ) <알림기준: " + num7 + "GB>\n");
							sb.Append("  ▶휴지통 사이즈가 기준치 보다 큽니다.(기준치 " + num7 + " GB)\n");
							cntOfMinoError++;
						}
						else
						{
							sb.Append("-휴지통 사이즈 ( " + num8 + " GB )\n");
						}
						string bHOCount = getBHOCount();
						if (bHOCount != "")
						{
							sb.Append("-▶ [기타기능]탭에서 [BHO삭제] 버튼 클릭이 권장됩니다." + bHOCount);
							cntOfMinoError++;
						}
						if (0 < cntOfApproval)
						{
							sb.Append("-▶[승인내역]을 확인하세요-\n");
							cntOfMinoError++;
						}
						if (isMsSpellcheckUse())
						{
							sb.Append("-▶IE Spell Check(사일런트웨어:MsSpellCheckingFacility.exe) 가 활성화 되어있습니다.[기타기능]에서 조치 가능합니다.\n");
							cntOfMinoError++;
						}
						if (cntOfMinoError == 0)
						{
							((Control)txtHealthReport).set_Background((Brush)(object)Brushes.get_WhiteSmoke());
							sb.Append("-특이사항 없음-\n");
						}
						IsNotCheckedConficence = false;
					}
					else
					{
						((Control)txtHealthReport).set_Background((Brush)(object)Brushes.get_Pink());
						IsNotCheckedConficence = true;
					}
					if (!bCancelHealthCheck)
					{
						if (!flag)
						{
							if (!flag2)
							{
								App.iniFile.WriteValue_UTF8("LogDate", nowYYYYMMDD);
							}
						}
						else if (!flag2)
						{
							App.iniFile.WriteValue_UTF8("LogDate", nowYYYYMMDD);
							App.iniFile.WriteValue_UTF8("DateDeep", nowYYYYMMDD);
						}
					}
				}
				if (cnt == 0 && bAutoStartRun && commandLineArgs.Count() == 2 && commandLineArgs[1] == "bg")
				{
					if (!bTodayChecked && dictListNew.Count > 0)
					{
						string text27 = "컴퓨터 건강진단 완료하였습니다.\n[건강상태: 양호합니다.]";
						MessageBoxTimerClose messageBoxTimerClose = new MessageBoxTimerClose("[" + Process.GetCurrentProcess().ProcessName + "] " + text27);
						((Window)messageBoxTimerClose).ShowDialog();
						((Window)messageBoxTimerClose).Close();
						if (deepCheckNeeded)
						{
							text27 = "1년이상 컴퓨터 건강진단을 정밀진단모드로 받지 않으셨습니다.\n정밀진단을 권장합니다.";
							messageBoxTimerClose = new MessageBoxTimerClose("[" + Process.GetCurrentProcess().ProcessName + "] " + text27);
							((Window)messageBoxTimerClose).ShowDialog();
							((Window)messageBoxTimerClose).Close();
						}
					}
					Environment.Exit(0);
				}
				else if (commandLineArgs.Count() == 2 && commandLineArgs[1] == "bg" && sb.ToString().Length == 0)
				{
					string text27 = "컴퓨터 건강진단 완료하였습니다.\n[건강상태: 양호합니다.]";
					MessageBoxTimerClose messageBoxTimerClose = new MessageBoxTimerClose("[" + Process.GetCurrentProcess().ProcessName + "] " + text27);
					((Window)messageBoxTimerClose).ShowDialog();
					((Window)messageBoxTimerClose).Close();
					Environment.Exit(0);
				}
				txtHealthReport.set_Text(sb.ToString());
				bHealthChecked = true;
				((UIElement)tabItemMain).Focus();
				isMutex = false;
				((ContentControl)btnHealthCheck).set_Content((object)"건강 진단");
				if (bCancelHealthCheck)
				{
					tBar.set_Text("건강 진단 도중 취소되었습니다.");
				}
				else
				{
					if (cnt == 0)
					{
						tBar.set_Text("건강 진단 완료!");
						if (((ToggleButton)chkContinue).get_IsChecked() == true)
						{
							button1_Click(this, null);
						}
					}
					else
					{
						tBar.set_Text("건강 진단 완료! [진단서 저장]버튼을 클릭하여 진단결과를 저장하세요.");
						if (((ToggleButton)chkContinue).get_IsChecked() == true)
						{
							button1_Click(this, null);
						}
					}
					App.iniFile.WriteValue_UTF8("CntParentAbout", string.Concat(cntParentSample));
				}
				if (bCancelHealthCheck)
				{
					((UIElement)btnAnalysisQuick).set_Visibility((Visibility)1);
				}
				else
				{
					((UIElement)btnAnalysisQuick).set_Visibility((Visibility)0);
					((UIElement)btnSaveLog).set_IsEnabled(true);
				}
			}
		}
		catch (Exception ex)
		{
			string text27 = ex.Message;
			MessageBox.Show(text27, "[오류]", (MessageBoxButton)0, (MessageBoxImage)48);
		}
	}

	private string replacePathesPath(string strPath)
	{
		string result = "";
		string text = "";
		for (int i = 0; i < pathes.Count(); i++)
		{
			text = Path.Combine(pathes[i], strPath);
			if (File.Exists(text))
			{
				result = text;
				break;
			}
		}
		return result;
	}

	private string printKeyStartsWith(Dictionary<string, string> p_dictListOld, string p)
	{
		string result = "";
		foreach (string key in p_dictListOld.Keys)
		{
			if (key.StartsWith(p))
			{
				result = key.Replace(p, "");
				break;
			}
		}
		return result;
	}

	private bool isMsSpellcheckUse()
	{
		return RegiHelperSrc.Instance.isMsSpellCheckUse();
	}

	private void ShowOnHealthCheck()
	{
		if (frmOnWorking == null)
		{
			frmOnWorking = new FormOnWorking();
		}
		((Control)frmOnWorking).Show();
		CNativeWIN32.SetWindowPos(((Control)frmOnWorking).get_Handle(), IntPtr.Zero, Screen.get_PrimaryScreen().get_WorkingArea().Width - ((Control)frmOnWorking).get_Width(), Screen.get_PrimaryScreen().get_WorkingArea().Height - ((Control)frmOnWorking).get_Height(), ((Control)frmOnWorking).get_Width(), ((Control)frmOnWorking).get_Height(), CNativeWIN32.SetWindowPosFlags.SWP_NOSIZE);
	}

	private bool? isApproval(string approvalSection)
	{
		string text = App.iniApprovalList.ReadValue_UTF8(approvalSection, "YN");
		if (text == "Y")
		{
			return true;
		}
		if (text == "")
		{
			return null;
		}
		return false;
	}

	private FileInfo[] processToFileInfoes(Process[] prces)
	{
		List<FileInfo> list = new List<FileInfo>();
		for (int i = 0; i < prces.Count(); i++)
		{
			if (1000 <= prces[i].Id)
			{
				try
				{
					processAccessErrorID = prces[i].Id;
					processAccessErrorFileName = Utils.GetMainModuleFilepath(prces[i].Id);
					list.Add(new FileInfo(processAccessErrorFileName));
					processAccessErrorFileName = "";
					processAccessErrorID = 0;
				}
				catch (Win32Exception ex)
				{
					Console.Error.WriteLine(ex.Message);
				}
				catch (Exception ex2)
				{
					Console.Error.WriteLine(ex2.Message);
				}
			}
		}
		return list.ToArray();
	}

	private FileInfo processToFileInfoes(Process prces)
	{
		FileInfo result = null;
		try
		{
			result = new FileInfo(prces.MainModule!.FileName);
		}
		catch (Win32Exception ex)
		{
			Console.Error.WriteLine(ex.Message);
		}
		catch (Exception ex2)
		{
			Console.Error.WriteLine(ex2.Message);
		}
		return result;
	}

	public static string GetProcessName(int pid)
	{
		IntPtr intPtr = OpenProcess(1040u, bInheritHandle: false, pid);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		StringBuilder stringBuilder = new StringBuilder(4000);
		string result = null;
		if (GetModuleFileNameEx(intPtr, IntPtr.Zero, stringBuilder, 4000) != 0)
		{
			result = stringBuilder.ToString();
		}
		CloseHandle(intPtr);
		return result;
	}

	private void MsgBox(string p)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AutoClosingMessageBox.Show1(p, "PowerHealthChecker", 3100, 0);
	}

	private string getNowCheckSumFast(bool bDeepScan, bool isFileOk, string fileName)
	{
		string text = "";
		bool flag = false;
		if (!bDeepScan && isFileOk)
		{
			string maxFileSystemDate = getMaxFileSystemDate(fileName);
			if (dictListOld.ContainsKey(fileName.ToLower()))
			{
				string checkDate = getCheckDate(dictListOld[fileName.ToLower()]);
				if (0 < checkDate.Length && maxFileSystemDate.CompareTo(checkDate) >= 0)
				{
					flag = true;
				}
			}
			else
			{
				flag = true;
			}
		}
		if (bDeepScan || flag)
		{
			if (isFileOk)
			{
				return App.FileCheckSum(fileName);
			}
			return App.StringCheckSum(fileName);
		}
		return getCheckSum(dictListOld[fileName.ToLower()]);
	}

	private string getMaxFileSystemDate(string strPath)
	{
		FileInfo fileInfo = new FileInfo(strPath);
		string text = fileInfo.CreationTime.ToString("yyyyMMdd");
		string text2 = fileInfo.LastWriteTime.ToString("yyyyMMdd");
		string text3 = ((Convert.ToInt32(text) > Convert.ToInt32(text2)) ? text : text2);
		if (dayFirst)
		{
			string parentFoldersModifiedTime = getParentFoldersModifiedTime(strPath);
			text3 = ((Convert.ToInt32(text3) > Convert.ToInt32(parentFoldersModifiedTime)) ? text3 : parentFoldersModifiedTime);
		}
		return text3;
	}

	private string getParentFoldersModifiedTime(string strPath)
	{
		string path = strPath[..strPath.LastIndexOf(Utils.SEPA)];
		DirectoryInfo directoryInfo = new DirectoryInfo(path);
		return directoryInfo.LastWriteTime.ToString("yyyyMMdd");
	}

	private void GetHardDiskFreeSpaceInfo(StringBuilder sb, ref int cnt, ref int cntOfMinoError)
	{
		long num = 0L;
		long num2 = 5L;
		string text = App.iniFile.ReadValue("WarningFreeSpaceLimit_GB");
		if (text == "")
		{
			App.iniFile.WriteValue_UTF8("WarningFreeSpaceLimit_GB", "5");
		}
		else
		{
			num2 = Convert.ToInt32(text);
		}
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if (!driveInfo.IsReady || driveInfo.DriveType != DriveType.Fixed)
			{
				continue;
			}
			num = driveInfo.TotalFreeSpace;
			if (num < num2 * 1024L * 1024L * 1024L && driveInfo.TotalSize > 10737418240L)
			{
				sb.Append("-▶" + driveInfo.Name + "여유공간 부족(잔여: " + Math.Round((double)num / 1024.0 / 1024.0 / 1024.0) + " GB < " + num2 + " GB)-\n");
				if (((Control)txtHealthReport).get_Background() == Brushes.get_WhiteSmoke())
				{
					((Control)txtHealthReport).set_Background((Brush)(object)Brushes.get_LightPink());
					((UIElement)lblHelp).set_Visibility((Visibility)2);
				}
				cntOfMinoError++;
				cnt = 1;
			}
			else
			{
				sb.Append("-" + driveInfo.Name + "(여유공간: " + Math.Round((double)num / 1024.0 / 1024.0 / 1024.0) + " GB)-\n");
			}
		}
	}

	private void GetHardDiskTemperatureInfo(StringBuilder sb, ref int cnt, ref int cntOfMinoError)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		try
		{
			if (!App.IsAdministrator())
			{
				return;
			}
			ManagementObjectSearcher val = new ManagementObjectSearcher("root\\WMI", "SELECT * FROM MSStorageDriver_ATAPISmartData");
			try
			{
				ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						ManagementObject val2 = (ManagementObject)enumerator.get_Current();
						byte[] array = (byte[])((ManagementBaseObject)val2).GetPropertyValue("VendorSpecific");
						int num = Array.IndexOf(array, (byte)194);
						int num2 = array[num + 5];
						if (60 <= num2)
						{
							((Control)txtHealthReport).set_Background((Brush)(object)Brushes.get_Pink());
							sb.Append("-▶▶" + getDriveLetter((string)((ManagementBaseObject)val2).GetPropertyValue("InstanceName"), num2) + " 온도가 너무 높습니다.[(백업 및 교체 필요)고온:55\u02daC 이상, 위험:60\u02daC 이상](" + num2 + "\u02daC)-\n");
							cntOfMinoError++;
							cnt = 1;
						}
						else if (54 <= num2)
						{
							((Control)txtHealthReport).set_Background((Brush)(object)Brushes.get_LightPink());
							((UIElement)lblHelp).set_Visibility((Visibility)2);
							sb.Append("-▶" + getDriveLetter((string)((ManagementBaseObject)val2).GetPropertyValue("InstanceName"), num2) + " 높은편입니다.[고온:54\u02daC 이상, 위험:60\u02daC 이상]-\n");
							cntOfMinoError++;
							cnt = 1;
						}
						else
						{
							sb.Append("-" + getDriveLetter((string)((ManagementBaseObject)val2).GetPropertyValue("InstanceName"), num2) + " 정상 [고온:55\u02daC 이상, 위험:60\u02daC 이상]-\n");
						}
						val2.Dispose();
					}
				}
				finally
				{
					((IDisposable)enumerator)?.Dispose();
				}
				((Component)(object)val).Dispose();
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (ManagementException)
		{
			sb.Append("-하드디스크 온도 측정 불가-\n");
		}
	}

	private string getDriveLetter(string p, int tempRa)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		string text = "";
		ManagementObjectSearcher val = new ManagementObjectSearcher("Select * From Win32_DiskDrive");
		try
		{
			ManagementObjectCollection val2 = val.Get();
			try
			{
				((Component)(object)val).Dispose();
				ManagementObjectEnumerator enumerator = val2.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						ManagementBaseObject current = enumerator.get_Current();
						if (text != "")
						{
							break;
						}
						string text2 = (string)current.GetPropertyValue("InterfaceType");
						if (!(text2 == "IDE"))
						{
							continue;
						}
						string text3 = (string)current.GetPropertyValue("PNPDeviceID");
						if (-1 >= p.ToLower().IndexOf(text3.ToLower()))
						{
							continue;
						}
						string text4 = string.Concat("ASSOCIATORS OF {Win32_DiskDrive.DeviceID='", current.GetPropertyValue("DeviceID"), "'} WHERE AssocClass = Win32_DiskDriveToDiskPartition");
						ManagementObjectSearcher val3 = new ManagementObjectSearcher(text4);
						try
						{
							ManagementObjectCollection val4 = val3.Get();
							try
							{
								ManagementObjectEnumerator enumerator2 = val4.GetEnumerator();
								try
								{
									while (enumerator2.MoveNext())
									{
										ManagementBaseObject current2 = enumerator2.get_Current();
										if (text != "")
										{
											break;
										}
										string text5 = string.Concat("ASSOCIATORS OF {Win32_DiskPartition.DeviceID='", current2.GetPropertyValue("DeviceID"), "'} WHERE AssocClass = Win32_LogicalDiskToPartition");
										ManagementObjectSearcher val5 = new ManagementObjectSearcher(text5);
										try
										{
											ManagementObjectCollection val6 = val5.Get();
											try
											{
												ManagementObjectEnumerator enumerator3 = val6.GetEnumerator();
												try
												{
													if (enumerator3.MoveNext())
													{
														ManagementBaseObject current3 = enumerator3.get_Current();
														text = (string)current3.GetPropertyValue("DeviceID") + "(" + tempRa + "\u02daC) <" + (string)current.GetPropertyValue("Model") + ">";
													}
												}
												finally
												{
													((IDisposable)enumerator3)?.Dispose();
												}
											}
											finally
											{
												((IDisposable)val6)?.Dispose();
											}
										}
										finally
										{
											((IDisposable)val5)?.Dispose();
										}
									}
								}
								finally
								{
									((IDisposable)enumerator2)?.Dispose();
								}
							}
							finally
							{
								((IDisposable)val4)?.Dispose();
							}
						}
						finally
						{
							((IDisposable)val3)?.Dispose();
						}
					}
				}
				finally
				{
					((IDisposable)enumerator)?.Dispose();
				}
				val2.Dispose();
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		return text;
	}

	private string AddChildPartOne()
	{
		if (CntParentAbout < cntChildSample)
		{
			CntParentAbout = cntChildSample;
		}
		return cntChildSample++ + "/" + Math.Max(CntParentAbout, cntParentSample) + " +";
	}

	private void AddParentPart(int cnt)
	{
		cntParentSample += cnt;
	}

	private void ListBeforeModifiedSHA_Add(string old_checksum)
	{
		ListBeforeModifiedSHA.Add(old_checksum);
	}

	public bool replaceFileNameWithParam(ref string fileName, bool allExt = false)
	{
		bool result = false;
		if (!allExt)
		{
			int num = -1;
			MatchCollection matchCollection = regexp_file.Matches(fileName);
			if (0 < matchCollection.Count)
			{
				int num2 = 0;
				fileName = matchCollection[0].Groups[matchCollection[0].Groups.Count - 1].ToString().ToLower();
			}
			for (int num2 = 0; num2 < arr_exe_cmd_etc.Length; num2++)
			{
				num = fileName.LastIndexOf(arr_exe_cmd_etc[num2]);
				if (num > -1 && Utils.FileExists(fileName))
				{
					result = true;
					break;
				}
			}
		}
		else
		{
			MatchCollection matchCollection = regexp_file.Matches(fileName);
			if (0 < matchCollection.Count)
			{
				int num2 = 0;
				fileName = matchCollection[0].Groups[matchCollection[0].Groups.Count - 1].ToString().ToLower();
				if (Utils.FileExists(fileName))
				{
					result = true;
				}
			}
		}
		return result;
	}

	private void AddShareFiles(string strPath, ref StringBuilder sb, ref int depthFolderLimit, ref int depthExeFileLimit, ref int cnt)
	{
		string text = strPath.ToLower();
		bool? flag = null;
		bool? flag2 = null;
		if (!dictListOld.ContainsKey(text))
		{
			flag = true;
		}
		else
		{
			flag = false;
		}
		if (!dictListNew.ContainsKey(text))
		{
			flag = true;
			flag2 = true;
			if (depthFolderLimit < 0 || depthExeFileLimit < 0)
			{
				return;
			}
			if (flag == true)
			{
				FileInfo[] array = null;
				try
				{
					array = new DirectoryInfo(strPath).GetFiles();
					for (int i = 0; i < array.Count(); i++)
					{
						Application.DoEvents();
						string text2 = array[i].Extension.ToLower();
						try
						{
							if (!(text2 == ".exe") && !(text2 == ".com") && !(text2 == ".scr"))
							{
								continue;
							}
							if (depthExeFileLimit-- < 0)
							{
								break;
							}
							string text3;
							if (!dictListOld.ContainsKey(array[i].FullName.ToLower()))
							{
								if (!dictListNew.ContainsKey(array[i].FullName))
								{
									text3 = App.FileCheckSum(array[i].FullName);
									dictListNew.Add(array[i].FullName, text3 + "," + nowYYYYMMDD);
									sb.Append("신규: " + array[i].FullName);
									sb.Append("\r\n");
									sb.Append(text3);
									sb.Append("\r\n");
									sb.Append("\r\n");
									cnt++;
								}
								continue;
							}
							FileInfo fileInfo = new FileInfo(array[i].FullName);
							bool flag3 = false;
							string strB = fileInfo.LastWriteTime.ToString("yyyyMMdd");
							if (getCheckDate(dictListOld[array[i].FullName.ToLower()]).CompareTo(strB) <= 0)
							{
								text3 = App.FileCheckSum(array[i].FullName);
								flag3 = true;
							}
							else
							{
								text3 = getCheckSum(dictListOld[array[i].FullName.ToLower()]);
								flag3 = false;
							}
							if (flag3)
							{
								if (!dictListNew.ContainsKey(array[i].FullName))
								{
									dictListNew.Add(array[i].FullName, text3 + "," + nowYYYYMMDD);
								}
							}
							else if (!dictListNew.ContainsKey(array[i].FullName))
							{
								dictListNew.Add(array[i].FullName, dictListOld[array[i].FullName.ToLower()]);
							}
							string checkSum = getCheckSum(dictListOld[array[i].FullName.ToLower()]);
							if (checkSum != text3)
							{
								try
								{
									ListBeforeModifiedSHA_Add(checkSum);
									sb.Append("변조: " + array[i].FullName);
									sb.Append("\r\n");
									sb.Append(text3);
									sb.Append("\r\n");
									sb.Append("\r\n");
									cnt++;
									DictNewedModifedSHA.Add(checkSum, text3);
								}
								catch (ArgumentException)
								{
								}
							}
						}
						catch (Exception ex2)
						{
							strErrFilePath = "[37]" + array[i].FullName;
							App.LogPut(ex2);
							isErrorOccored = true;
							break;
						}
					}
				}
				catch (Exception)
				{
				}
				if (!dictListOld.ContainsKey("[share]" + text.ToLower()))
				{
					dictListOld.Add("[share]" + text.ToLower(), "");
				}
			}
			bool? flag4 = flag2;
			if (!flag4.GetValueOrDefault() || !flag4.HasValue || depthFolderLimit-- < 0)
			{
				return;
			}
			DirectoryInfo[] array2 = null;
			try
			{
				array2 = new DirectoryInfo(strPath).GetDirectories();
				for (int j = 0; j < array2.Count(); j++)
				{
					Application.DoEvents();
					int depthFolderLimit2 = depthFolderLimit;
					AddShareFiles(array2[j].FullName, ref sb, ref depthFolderLimit2, ref depthExeFileLimit, ref cnt);
				}
			}
			catch (Exception)
			{
			}
			if (!dictListNew.ContainsKey("[share]" + text) && 2 <= depthFolderLimit)
			{
				dictListNew.Add("[share]" + text, "");
			}
		}
		else
		{
			flag2 = false;
			flag = false;
		}
	}

	private void AddProgramFiles(string strPath, ref StringBuilder sb, ref int depthFolderLimit, ref int depthExeFileLimit, ref int cnt, bool x86)
	{
		string text = strPath.ToLower();
		bool? flag = null;
		bool? flag2 = null;
		if (!dictListOld.ContainsKey(text))
		{
			flag = true;
		}
		else
		{
			flag = false;
		}
		if (!dictListNew.ContainsKey(text))
		{
			flag = true;
			flag2 = true;
			if (depthFolderLimit < 0 || depthExeFileLimit < 0)
			{
				return;
			}
			if (flag == true)
			{
				FileInfo[] array = null;
				try
				{
					array = new DirectoryInfo(strPath).GetFiles();
					AddParentPart(array.Count());
					for (int i = 0; i < array.Count(); i++)
					{
						tBar.set_Text(AddChildPartOne());
						Application.DoEvents();
						string text2 = array[i].Extension.ToLower();
						try
						{
							if (!(text2 == ".exe") && !(text2 == ".com") && !(text2 == ".scr"))
							{
								continue;
							}
							if (depthExeFileLimit-- < 0)
							{
								break;
							}
							string text3;
							if (!dictListOld.ContainsKey(array[i].FullName.ToLower()))
							{
								if (!dictListNew.ContainsKey(array[i].FullName))
								{
									text3 = App.FileCheckSum(array[i].FullName);
									dictListNew.Add(array[i].FullName, text3 + "," + nowYYYYMMDD);
									sb.Append("신규: " + array[i].FullName);
									sb.Append("\r\n");
									sb.Append(text3);
									sb.Append("\r\n");
									sb.Append("\r\n");
									cnt++;
								}
								continue;
							}
							FileInfo fileInfo = new FileInfo(array[i].FullName);
							bool flag3 = false;
							string strB = fileInfo.LastWriteTime.ToString("yyyyMMdd");
							if (getCheckDate(dictListOld[array[i].FullName.ToLower()]).CompareTo(strB) <= 0)
							{
								text3 = App.FileCheckSum(array[i].FullName);
								flag3 = true;
							}
							else
							{
								text3 = getCheckSum(dictListOld[array[i].FullName.ToLower()]);
								flag3 = false;
							}
							if (flag3)
							{
								if (!dictListNew.ContainsKey(array[i].FullName))
								{
									dictListNew.Add(array[i].FullName, text3 + "," + nowYYYYMMDD);
									goto IL_0302;
								}
								continue;
							}
							try
							{
								dictListNew.Add(array[i].FullName, dictListOld[array[i].FullName.ToLower()]);
							}
							catch (ArgumentException)
							{
							}
							goto IL_0302;
							IL_0302:
							string checkSum = getCheckSum(dictListOld[array[i].FullName.ToLower()]);
							if (checkSum != text3)
							{
								try
								{
									ListBeforeModifiedSHA_Add(checkSum);
									sb.Append("변조: " + array[i].FullName);
									sb.Append("\r\n");
									sb.Append(text3);
									sb.Append("\r\n");
									sb.Append("\r\n");
									cnt++;
									DictNewedModifedSHA.Add(checkSum, text3);
								}
								catch (ArgumentException)
								{
								}
							}
						}
						catch (Exception ex3)
						{
							strErrFilePath = "[38...]" + array[i].FullName + " " + ex3.Message.Replace("\r", " ").Replace("\n", " ");
							App.LogPut(ex3);
							isErrorOccored = true;
							Utils.File_secure(array[i].FullName, secure: false, byUser: false);
						}
					}
				}
				catch (Exception)
				{
				}
				if (x86)
				{
					if (!dictListOld.ContainsKey(("[ProgramX86]" + text).ToLower()))
					{
						dictListOld.Add(("[ProgramX86]" + text).ToLower(), "");
					}
				}
				else if (!dictListOld.ContainsKey(("[Program]" + text).ToLower()))
				{
					dictListOld.Add(("[Program]" + text).ToLower(), "");
				}
				if (4 <= depthFolderLimit)
				{
					if (x86)
					{
						if (!dictListNew.ContainsKey("[ProgramX86]" + text))
						{
							dictListNew.Add("[ProgramX86]" + text, "");
						}
					}
					else if (!dictListNew.ContainsKey("[Program]" + text))
					{
						dictListNew.Add("[Program]" + text, "");
					}
				}
			}
			bool? flag4 = flag2;
			if (!flag4.GetValueOrDefault() || !flag4.HasValue || depthFolderLimit-- < 0)
			{
				return;
			}
			DirectoryInfo[] array2 = null;
			try
			{
				array2 = new DirectoryInfo(strPath).GetDirectories();
				for (int j = 0; j < array2.Count(); j++)
				{
					Application.DoEvents();
					int depthFolderLimit2 = depthFolderLimit;
					AddProgramFiles(array2[j].FullName, ref sb, ref depthFolderLimit2, ref depthExeFileLimit, ref cnt, x86);
				}
			}
			catch (Exception)
			{
			}
			if (x86)
			{
				if (!dictListNew.ContainsKey("[ProgramX86]" + text) && 2 <= depthFolderLimit)
				{
					dictListNew.Add("[ProgramX86]" + text, "");
				}
			}
			else if (!dictListNew.ContainsKey("[Program]" + text) && 2 <= depthFolderLimit)
			{
				dictListNew.Add("[Program]" + text, "");
			}
		}
		else
		{
			flag2 = false;
			flag = false;
		}
	}

	private bool isRegistryLastModifiedSame(string strLogPath)
	{
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		bool result = true;
		try
		{
			RegistryKey registryKey2;
			if (Utils.Is64OS())
			{
				RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
				registryKey2 = registryKey.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Applets\\Regedit");
			}
			else
			{
				registryKey2 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Applets\\Regedit");
			}
			string text = (string)registryKey2.GetValue("LastKey", "");
			string path = Path.Combine(strLogPath, "LastKey.txt");
			string text2 = "?";
			if (Utils.FileExists(path))
			{
				text2 = File.ReadAllText(path);
				File.Delete(path);
				App.iniFile.WriteValue_UTF8("LastKey", text2);
			}
			else
			{
				text2 = App.iniFile.ReadValue("LastKey");
			}
			if (text != text2)
			{
				App.iniFile.WriteValue_UTF8("LastKey", text);
				return false;
			}
			return true;
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, ((Window)this).get_Title(), (MessageBoxButton)0, (MessageBoxImage)48);
		}
		return result;
	}

	private static string removeLastSlash(string p)
	{
		if (p.LastIndexOf('\\') == p.Length - 1)
		{
			return p.Substring(0, p.Length - 1);
		}
		return p;
	}

	private string getCheckSum(string p)
	{
		string[] array = p.Split(new char[1] { ',' });
		return array[0];
	}

	private string getCheckDate(string p)
	{
		string[] array = p.Split(new char[1] { ',' });
		if (0 < array.Count())
		{
			return array[1];
		}
		return "";
	}

	private bool isSpecilThreatFile(string p, string strWindowsFolder)
	{
		if (p.IndexOf("svchost.exe", StringComparison.OrdinalIgnoreCase) > -1)
		{
			return true;
		}
		if (p.IndexOf("rundll32.exe", StringComparison.OrdinalIgnoreCase) > -1)
		{
			return true;
		}
		return false;
	}

	private void replaceStartsWithSpecialFolder(ref string fileName)
	{
		if (-1 < fileName.IndexOf("%"))
		{
			fileName = replaceNormalizePath(fileName);
		}
		else if (fileName.StartsWith("system32" + Utils.SEPA, StringComparison.OrdinalIgnoreCase))
		{
			fileName = Replace(fileName, "system32" + Utils.SEPA, strWindowsFolder + Utils.SEPA + "System32" + Utils.SEPA);
		}
		else if (fileName.StartsWith(Utils.SEPA + "systemroot" + Utils.SEPA, StringComparison.OrdinalIgnoreCase))
		{
			fileName = Replace(fileName, Utils.SEPA + "systemroot" + Utils.SEPA, strWindowsFolder + Utils.SEPA);
		}
		else if (fileName.StartsWith(Utils.SEPA + "??" + Utils.SEPA))
		{
			fileName = Replace(fileName, Utils.SEPA + "??" + Utils.SEPA, "");
		}
	}

	private void button1_Click(object sender, RoutedEventArgs e)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		if (bHealthChecked)
		{
			saveLogList();
			if (((ToggleButton)chkContinue).get_IsChecked() == false)
			{
				string text = "컴퓨터 건강진단상태를 저장하였습니다.";
				AutoClosingMessageBox.Show1(text, "PowerHealthChecker", 3100, 0);
			}
			if (((UIElement)btnAnalysisQuick).get_IsEnabled())
			{
				tBar.set_Text("진단상태를 저장하였습니다. [분석]버튼을 클릭하세요.");
			}
			else
			{
				tBar.set_Text("진단상태를 저장하였습니다. [완료]");
			}
			bool? isChecked = ((ToggleButton)chkContinue).get_IsChecked();
			if (isChecked.GetValueOrDefault() && isChecked.HasValue && ((UIElement)btnAnalysisQuick).get_IsEnabled())
			{
				Analysis(isQuick: true);
			}
		}
		else
		{
			string text = "먼저 \"건강 진단\"버튼을 클릭 하세요.";
			AutoClosingMessageBox.Show1(text, "PowerHealthChecker", 3100, 0);
		}
		IsNotCheckedConficence = false;
	}

	private void saveLogList()
	{
		int num = 1;
		try
		{
			File.WriteAllText(checkFile, txtHealthReport.get_Text());
			num = 2;
			List<string> list = new List<string>();
			num = 3;
			foreach (string key in dictListNew.Keys)
			{
				num = 4;
				list.Add(key + "|" + dictListNew[key]);
				num = 5;
			}
			num = 6;
			list.Sort();
			num = 7;
			num = 8;
			string[] contents = list.ToArray();
			num = 9;
			File.WriteAllLines(logFile, contents);
			num = 10;
			if (0 < ListBeforeModifiedSHA.Count)
			{
				num = 11;
				if (Utils.FileExists(logAnalysis))
				{
					num = 12;
					string[] source = File.ReadAllLines(logAnalysis);
					num = 13;
					List<string> list2 = source.ToList();
					num = 14;
					for (int i = 0; i < list2.Count(); i++)
					{
						num = 15;
						for (int j = 0; j < ListBeforeModifiedSHA.Count; j++)
						{
							num = 16;
							if (-1 >= list2[i].IndexOf(ListBeforeModifiedSHA[j]))
							{
								num = 20;
								continue;
							}
							num = 17;
							list2.RemoveAt(i--);
							num = 18;
							break;
						}
						num = 21;
					}
					num = 22;
					File.WriteAllLines(logAnalysis, list2);
					num = 23;
				}
				num = 24;
				if (Utils.FileExists(logFile))
				{
					num = 25;
					num = 26;
					string[] source = File.ReadAllLines(logFile);
					num = 27;
					List<string> list3 = source.ToList();
					num = 28;
					for (int i = 0; i < list3.Count(); i++)
					{
						num = 29;
						for (int j = 0; j < ListBeforeModifiedSHA.Count; j++)
						{
							num = 30;
							if (-1 >= list3[i].IndexOf(ListBeforeModifiedSHA[j]))
							{
								num = 33;
								continue;
							}
							num = 31;
							list3[i] = list3[i].Replace(ListBeforeModifiedSHA[j], DictNewedModifedSHA[ListBeforeModifiedSHA[j]]);
							num = 32;
							break;
						}
						num = 34;
					}
					num = 35;
					File.WriteAllLines(logFile, list3);
					num = 36;
				}
				num = 37;
			}
			num = 38;
		}
		catch (Exception ex)
		{
			Console.Error.WriteLine("======================errorpos = " + num);
			Console.Error.WriteLine(ex.Message);
			Console.Error.WriteLine("----------------------");
			Console.Error.WriteLine(ex.StackTrace);
			Console.Error.WriteLine("======================");
		}
	}

	public static string Replace(string source, string oldString, string newString, StringComparison comp = StringComparison.OrdinalIgnoreCase)
	{
		int num = source.IndexOf(oldString, comp);
		if (num >= 0)
		{
			source = source.Remove(num, oldString.Length);
			source = source.Insert(num, newString);
		}
		return source;
	}

	private void button2_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "http://www.virustotal.com", null, null, 1);
	}

	private void Window_Closing(object sender, CancelEventArgs e)
	{
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Invalid comparison between Unknown and I4
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Invalid comparison between Unknown and I4
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Invalid comparison between Unknown and I4
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Invalid comparison between Unknown and I4
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Invalid comparison between Unknown and I4
		//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Invalid comparison between Unknown and I4
		string bootTime = Utils.GetBootTime();
		if (!bootTime.Equals(RegiHelperSrc.Instance.BootTime))
		{
			if (RegiHelperSrc.Instance.IsBlockMsTeams)
			{
				Utils.ExecuteCommandSync("taskkill.exe /IM msteams.exe /F");
			}
			if (RegiHelperSrc.Instance.IsBlockMsEdge)
			{
				Utils.ExecuteCommandSync("taskkill.exe /IM msedge.exe /F");
				Utils.ExecuteCommandSync(Environment.GetEnvironmentVariable("windir") + Utils.SEPA + "system32\\sc stop MicrosoftEdgeElevationService");
				Utils.ExecuteCommandSync(Environment.GetEnvironmentVariable("windir") + Utils.SEPA + "system32\\sc stop edgeupdate");
				Utils.ExecuteCommandSync(Environment.GetEnvironmentVariable("windir") + Utils.SEPA + "system32\\sc stop edgeupdatem");
				Utils.ExecuteCommandSync(Environment.GetEnvironmentVariable("windir") + Utils.SEPA + "system32\\sc config MicrosoftEdgeElevationService start= disabled");
				Utils.ExecuteCommandSync(Environment.GetEnvironmentVariable("windir") + Utils.SEPA + "system32\\sc config edgeupdate start= disabled");
				Utils.ExecuteCommandSync(Environment.GetEnvironmentVariable("windir") + Utils.SEPA + "system32\\sc config edgeupdatem start= disabled");
				if (RegiHelperSrc.Instance.IsBlockMsEdge)
				{
					Utils.DeleteEdgeBHO();
				}
			}
			if (RegiHelperSrc.Instance.IsBlockWizvera)
			{
				Utils.ExecuteCommandSync(Environment.GetEnvironmentVariable("windir") + Utils.SEPA + "system32\\sc stop WizveraPMSvc");
				Utils.ExecuteCommandSync(Environment.GetEnvironmentVariable("windir") + Utils.SEPA + "system32\\sc config WizveraPMSvc start= demand");
				Utils.ExecuteCommandSync(Environment.GetEnvironmentVariable("windir") + Utils.SEPA + "system32\\taskkill.exe /IM delfino.exe /F");
			}
			RegiHelperSrc.Instance.BootTime = bootTime;
		}
		long recycleSize = GetRecycleSize();
		if (Convert.ToDouble(App.iniFile.ReadValueDefault("WarningRecycleGB", "10")) < (double)recycleSize / 1024.0 / 1024.0 / 1024.0 && (int)MessageBox.Show("휴지통 사이즈가 [ " + Math.Round((double)(recycleSize / 1024L / 1024L) / 1024.0, 2) + " GB ]입니다.\n휴지통을 비우시겠습니까?", Process.GetCurrentProcess().ProcessName, (MessageBoxButton)4, (MessageBoxImage)48) == 6)
		{
			try
			{
				CNativeWIN32.SHEmptyRecycleBin(IntPtr.Zero, null, 4u);
				Console.WriteLine("Succeed! : ");
			}
			catch (Exception ex)
			{
				Console.WriteLine("Failed ! : " + ex.ToString());
			}
		}
		if (forceKillCnt++ < 3 && AutoAllowTimer != null)
		{
			bTimerKill = true;
			e.Cancel = true;
			return;
		}
		isCancelAnalysis = true;
		if (IsNotCheckedConficence)
		{
			if (!bCancelHealthCheck)
			{
				string text = "[진단서 저장]후 종료하시겠습니까?";
				MessageBoxResult val = AutoClosingMessageBox.Show(text, "PowerHealthChecker", 3100, 1);
				if ((int)val == 2)
				{
					e.Cancel = true;
					forceKillCnt = 0;
					return;
				}
				if ((int)val == 6)
				{
					button1_Click(null, null);
				}
			}
		}
		else if (bHealthChecked && dictListNew.Count != dictListOld.Count)
		{
			if ((int)((UIElement)this).get_Visibility() == 0)
			{
				if (RegiHelperSrc.Instance.IsEndReDiagnosis)
				{
					string text = "종료건강진단을 하시겠습니까?";
					MessageBoxResult val = AutoClosingMessageBox.Show(text, "PowerHealthChecker", 3100, 2);
					if ((int)val == 6)
					{
						((ContentControl)btnHealthCheck).set_Content((object)"진단중...");
						App.isSessionEndingCheck = true;
						HealthCheckProcess(bAutoStartRun: true);
						if (IsNotCheckedConficence)
						{
							e.Cancel = true;
							forceKillCnt = 0;
						}
					}
					else if ((int)val == 2)
					{
						e.Cancel = true;
						return;
					}
				}
			}
			else
			{
				string[] commandLineArgs = Environment.GetCommandLineArgs();
				if (commandLineArgs.Length > 1 && commandLineArgs[1] == "bg")
				{
					saveLogList();
				}
			}
		}
		MP_ScheduleTaskDelete();
		if (!e.Cancel)
		{
			RemoveHookProcedure();
			App.WorkLog("<<end");
		}
	}

	private long GetRecycleSize()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Invalid comparison between Unknown and I4
		long num = 0L;
		if ((int)((UIElement)this).get_Visibility() == 0)
		{
			string text = Utils.SepaString("D:\\$RECYCLE.BIN\\");
			DriveInfo[] drives = DriveInfo.GetDrives();
			for (int i = 0; i < drives.Count(); i++)
			{
				if (drives[i].IsReady && drives[i].DriveType == DriveType.Fixed)
				{
					text = drives[i].Name + Utils.SepaString("$RECYCLE.BIN\\");
					CNativeWIN32.SHQUERYRBINFO pSHQueryRBInfo = default(CNativeWIN32.SHQUERYRBINFO);
					pSHQueryRBInfo.cbSize = Marshal.SizeOf(typeof(CNativeWIN32.SHQUERYRBINFO));
					CNativeWIN32.SHQueryRecycleBin(text, ref pSHQueryRBInfo);
					num += pSHQueryRBInfo.i64Size;
				}
			}
		}
		return num;
	}

	private static void MP_ScheduleTaskDelete()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		TaskService val = new TaskService();
		try
		{
			Regex regex = new Regex("^[^$]*", RegexOptions.IgnoreCase);
			Task[] array = null;
			try
			{
				array = val.FindAllTasks(regex, true);
				int num = 0;
				while (array != null && num < array.Count())
				{
					Task val2 = array[num];
					if (val2.get_Enabled())
					{
						string text = null;
						if (((IEnumerable<Action>)val2.get_Definition().get_Actions()).First() is ExecAction)
						{
							string path = ((ExecAction)((IEnumerable<Action>)val2.get_Definition().get_Actions()).First()).get_Path();
							text = replaceNormalizePath(path);
							if (text.IndexOf(Utils.SEPA) > -1 && (val2.get_Name() == "MP Scheduled Scan" || val2.get_Name() == "MpIdleTask"))
							{
								val2.set_Enabled(false);
							}
						}
					}
					num++;
				}
			}
			catch (Exception)
			{
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	public static string replaceNormalizePath(string str_tmp)
	{
		return parsePathByEnvVal(str_tmp);
	}

	private void btnOpenLogFolder_Click(object sender, RoutedEventArgs e)
	{
		logPath = App.LOGPATH;
		Directory.CreateDirectory(logPath);
		CNativeWIN32.ShellExecute(0, "open", logPath, null, null, 1);
	}

	private void btnStartProgramUser_Click(object sender, RoutedEventArgs e)
	{
		logPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
		Directory.CreateDirectory(logPath);
		CNativeWIN32.ShellExecute(0, "open", logPath, null, null, 1);
	}

	private void btnStartProgramAll_Click(object sender, RoutedEventArgs e)
	{
		logPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup);
		Directory.CreateDirectory(logPath);
		CNativeWIN32.ShellExecute(0, "open", logPath, null, null, 1);
	}

	private void btnRegistree_Click(object sender, RoutedEventArgs e)
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		RegiHelperSrc.Instance.Del_DisableTaskmgr();
		bool flag = false;
		RegistryKey registryKey2;
		if (Utils.Is64OS())
		{
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
			registryKey2 = registryKey.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Applets\\Regedit\\Favorites", RegistryKeyPermissionCheck.ReadWriteSubTree);
		}
		else
		{
			registryKey2 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Applets\\Regedit\\Favorites", RegistryKeyPermissionCheck.ReadWriteSubTree);
		}
		if (registryKey2 == null)
		{
			registryKey2 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Applets\\Regedit\\Favorites", RegistryKeyPermissionCheck.ReadWriteSubTree);
			RegFaviGen(registryKey2);
			flag = true;
		}
		else if (registryKey2.ValueCount < 9 || ((string)registryKey2.GetValue("SERVICES_PHGEN", "")).Length == 0)
		{
			RegFaviGen(registryKey2);
			flag = true;
		}
		if (flag)
		{
			MessageBox.Show("[안내]\n레지스트리의 즐겨찾기 항목을 클릭하면 빠른 이동이 가능합니다.\n[메뉴>즐겨찾기>Run etc.]", ((Window)this).get_Title(), (MessageBoxButton)0, (MessageBoxImage)64);
		}
		CNativeWIN32.ShellExecute(0, "open", "regedit.exe", null, null, 1);
	}

	private static void RegFaviGen(RegistryKey regKey)
	{
		regKey.SetValue("BHO(user)_PHGEN", "컴퓨터\\HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Browser Helper Objects");
		regKey.SetValue("BHO(all)_PHGEN", "컴퓨터\\HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Browser Helper Objects");
		regKey.SetValue("Run(user)_PHGEN", "컴퓨터\\HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run");
		regKey.SetValue("Run(all)_PHGEN", "컴퓨터\\HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
		regKey.SetValue("Share_PHGEN", "컴퓨터\\HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\services\\LanmanServer\\Shares");
		regKey.SetValue("Run(PolicesUser)_PHGEN", "컴퓨터\\HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\policies\\Explorer\\Run");
		regKey.SetValue("Run(PolicesAll)_PHGEN", "컴퓨터\\HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows\\CurrentVersion\\policies\\Explorer\\Run");
		regKey.SetValue("UAC_PHGEN", "컴퓨터\\HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		regKey.SetValue("SERVICES_PHGEN", "컴퓨터\\HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\services");
		regKey.SetValue("HeapLeak_PHGEN", "컴퓨터\\HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\RADAR\\HeapLeakDetection");
		if (Environment.Is64BitOperatingSystem)
		{
			regKey.SetValue("Run(6432user)_PHGEN", "컴퓨터\\HKEY_CURRENT_USER\\SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Run");
			regKey.SetValue("Run(6432all)_PHGEN", "컴퓨터\\HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Run");
		}
	}

	private void btnMsconfig_Click(object sender, RoutedEventArgs e)
	{
		if (CNativeWIN32.IsWindows8())
		{
			CNativeWIN32.ShellExecute(0, "open", "taskmgr.exe", null, null, 1);
		}
		else
		{
			CNativeWIN32.ShellExecute(0, "open", "msconfig.exe", null, null, 1);
		}
	}

	private void btnService_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "services.msc", null, null, 1);
	}

	[STAThread]
	private void btnHealthListCopy_Click(object sender, RoutedEventArgs e)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Clipboard.SetText(txtHealthReport.get_Text());
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, ((Window)this).get_Title(), (MessageBoxButton)0, (MessageBoxImage)48);
		}
	}

	private void btnCompmmc_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "taskschd.msc", null, null, 1);
	}

	private void image1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "http://www.bskorea.or.kr", null, null, 1);
	}

	private void btnProgramWiz_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "control", "appwiz.cpl", null, 1);
	}

	private void chkAutoStart_Checked(object sender, RoutedEventArgs e)
	{
	}

	private static int customCompare(string x, string y)
	{
		int num;
		int num2;
		if (x.StartsWith("-"))
		{
			if (y.StartsWith("-"))
			{
				num = Convert.ToInt32(x.Substring(0, 3));
				num2 = Convert.ToInt32(y.Substring(0, 3));
				if (num < num2)
				{
					return 1;
				}
				if (num > num2)
				{
					return -1;
				}
				return x.CompareTo(y);
			}
			if (y.StartsWith("00"))
			{
				return -1;
			}
			return 1;
		}
		if (x.StartsWith("00"))
		{
			if (y.StartsWith("00"))
			{
				return x.CompareTo(y);
			}
			if (y.StartsWith("-"))
			{
				return 1;
			}
			num = Convert.ToInt32(x.Substring(0, 2));
			num2 = Convert.ToInt32(y.Substring(0, 2));
			if (num < num2)
			{
				return 1;
			}
			if (num > num2)
			{
				return -1;
			}
			return x.CompareTo(y);
		}
		if (y.StartsWith("-"))
		{
			return -1;
		}
		num = Convert.ToInt32(x.Substring(0, 2));
		num2 = Convert.ToInt32(y.Substring(0, 2));
		if (num < num2)
		{
			return 1;
		}
		if (num > num2)
		{
			return -1;
		}
		return x.CompareTo(y);
	}

	private void vTotalS_Click(object sender, RoutedEventArgs e)
	{
		object obj = ((FrameworkElement)vTotalS).get_ToolTip();
		string text = "";
		try
		{
			text = Clipboard.GetText();
		}
		catch (Exception ex)
		{
			Console.Error.WriteLine(ex.Message);
		}
		bool flag = false;
		text = text.Replace("\"", "");
		if (text != "" && -1 < text.IndexOf(":"))
		{
			if (Directory.Exists(text))
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(text);
				FileInfo[] array = directoryInfo.GetFiles();
				txtHealthReport.set_Text("");
				AddParentPart(array.Count());
				if (!bCancelHealthCheck)
				{
					for (int i = 0; i < array.Count(); i++)
					{
						if (i != 0)
						{
							CNativeWIN32.Sleep(200);
						}
						tBar.set_Text(AddChildPartOne());
						Application.DoEvents();
						try
						{
							Application.DoEvents();
							string text2 = array[i].Extension.ToLower();
							switch (text2)
							{
							default:
								if (text2 == ".npc")
								{
									break;
								}
								goto end_IL_00e7;
							case ".exe":
							case ".dll":
							case ".ocx":
							case ".com":
							case ".scr":
							case ".pif":
								break;
							}
							string text3 = App.FileCheckSum(array[i].FullName);
							CNativeWIN32.ShellExecute(0, "open", "https://www.virustotal.com/file/" + text3 + "/analysis/", null, null, 1);
							CNativeWIN32.Sleep(20);
							end_IL_00e7:;
						}
						catch (Exception ex)
						{
							Console.Error.WriteLine(ex.Message);
						}
					}
				}
				flag = true;
				obj = null;
			}
			else if (Utils.FileExists(text))
			{
				obj = App.FileCheckSum(text);
			}
			else if (text.Length == 64 && text.IndexOf(SEPA) == -1)
			{
				obj = text;
			}
		}
		if (obj != null && obj.ToString() != prevSelTxt)
		{
			CNativeWIN32.ShellExecute(0, "open", "https://www.virustotal.com/file/" + obj.ToString() + "/analysis/", null, null, 1);
			prevSelTxt = obj.ToString();
		}
		else if (!flag)
		{
			CNativeWIN32.ShellExecute(0, "open", "https://www.virustotal.com/#/home/search", null, null, 1);
		}
	}

	private void txtHealthReport_SelectionChanged(object sender, RoutedEventArgs e)
	{
		string text = txtHealthReport.get_SelectedText().Trim();
		if (text.Length == 64 && text.IndexOf(':') == -1 && text.IndexOf('\\') == -1 && text.IndexOf('\n') == -1 && text.IndexOf('\r') == -1 && text.IndexOf('.') == -1 && text.IndexOf(' ') == -1)
		{
			((FrameworkElement)vTotalS).set_ToolTip((object)text);
			CNativeWIN32.ShellExecute(0, "open", "https://www.virustotal.com/file/" + text + "/analysis/", null, null, 1);
		}
	}

	private void btnCheckSumMD5_Click(object sender, RoutedEventArgs e)
	{
		StringBuilder stringBuilder = new StringBuilder();
		string[] array = txtFileName.get_Text().Split('\r', '\n', '"', '|', '\t');
		for (int i = 0; i < array.Count(); i++)
		{
			string text = parsePathByEnvVal(array[i]);
			if (text.IndexOf(":") > -1)
			{
				stringBuilder.Append(array[i]);
				stringBuilder.Append("\r\n");
				stringBuilder.Append(App.FileCheckSumMD5(text));
				stringBuilder.Append("\r\n");
				stringBuilder.Append("\r\n");
			}
		}
		txtFileName.set_Text(stringBuilder.ToString());
	}

	private void btnCheckSumSHA256_Click(object sender, RoutedEventArgs e)
	{
		StringBuilder stringBuilder = new StringBuilder();
		string[] array = txtFileName.get_Text().Split('\r', '\n', '"', '|', '\t');
		for (int i = 0; i < array.Count(); i++)
		{
			string text = parsePathByEnvVal(array[i]);
			if (text.IndexOf(':') > -1)
			{
				stringBuilder.Append(array[i]);
				stringBuilder.Append("\r\n");
				stringBuilder.Append(App.FileCheckSum(text));
				stringBuilder.Append("\r\n");
				stringBuilder.Append("\r\n");
			}
		}
		txtFileName.set_Text(stringBuilder.ToString());
	}

	private void btnClear_Click(object sender, RoutedEventArgs e)
	{
		txtFileName.Clear();
	}

	[STAThread]
	private void btnCopy_Click(object sender, RoutedEventArgs e)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Clipboard.SetText(txtFileName.get_Text());
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, ((Window)this).get_Title(), (MessageBoxButton)0, (MessageBoxImage)48);
		}
	}

	private void txtFileNames_SelectionChanged(object sender, RoutedEventArgs e)
	{
		string text = txtFileName.get_SelectedText().Trim();
		if (text.Length == 64 && regexp_hash.IsMatch(text))
		{
			((FrameworkElement)vTotalS).set_ToolTip((object)text);
			CNativeWIN32.ShellExecute(0, "open", "https://www.virustotal.com/file/" + text + "/analysis", null, null, 1);
		}
	}

	private void btnAdminCmd_Click(object sender, RoutedEventArgs e)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.UseShellExecute = true;
		processStartInfo.FileName = Environment.GetFolderPath(Environment.SpecialFolder.System) + Utils.SEPA + "cmd.exe";
		processStartInfo.WorkingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.System).Substring(0, 3);
		processStartInfo.Verb = "runas";
		Process.Start(processStartInfo);
	}

	private void Analysis(bool isQuick)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0697: Unknown result type (might be due to invalid IL or missing references)
		//IL_069d: Invalid comparison between Unknown and I4
		//IL_08d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08da: Invalid comparison between Unknown and I4
		new VirusTotal("f56ab1f18e2759f47d14ba8bd08b48646658f7a4335909198a5f1d6e5356beb2");
		int num = Convert.ToInt32(((ContentControl)(ComboBoxItem)((Selector)cboBaseLine).get_SelectedItem()).get_Content());
		App.iniFile.WriteValue_UTF8("AnalysisBaseLine", num.ToString());
		if (isMutex)
		{
			MessageBox.Show("건강진단을 수행하고 있습니다. 잠시후 다시 시도 하세요.", ((Window)this).get_Title(), (MessageBoxButton)0, (MessageBoxImage)48);
			return;
		}
		string text = "";
		if (dictListNew.Count == 0)
		{
			MessageBox.Show("먼저 [건강 진단]버튼을 클릭 하세요", ((Window)this).get_Title(), (MessageBoxButton)0, (MessageBoxImage)48);
		}
		else
		{
			((UIElement)btnAnalysisCancel).set_Visibility((Visibility)0);
			((UIElement)btnAnalysisQuick).set_Visibility((Visibility)2);
			((UIElement)btnAnalysisCancel).InvalidateVisual();
			((UIElement)btnAnalysisQuick).InvalidateVisual();
			((UIElement)progressBar1).set_Visibility((Visibility)0);
			((UIElement)progressBar1).InvalidateVisual();
			new WebClient();
			int count = dictListNew.Count;
			((RangeBase)progressBar1).set_Maximum((double)count);
			arrDictList = dictListNew.ToArray();
			int num2 = -1;
			string[] array = null;
			Dictionary<string, int> dictionary = new Dictionary<string, int>();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			if (Utils.FileExists(logAnalysis))
			{
				File.Copy(logAnalysis, logAnalysis + nowMMDD + ".bak", overwrite: true);
			}
			if (isQuick)
			{
				if (Utils.FileExists(logAnalysis))
				{
					array = File.ReadAllLines(logAnalysis);
					string[] array2 = null;
					for (int i = 0; i < array.Count(); i++)
					{
						if (!array[i].StartsWith("#"))
						{
							array2 = array[i].Split(new char[1] { '|' });
							if (array2.Count() == 3)
							{
								int value = int.Parse(array2[0]);
								dictionary.Add(array2[1], value);
								dictionary2.Add(array2[1], array2[2]);
							}
						}
					}
				}
				else
				{
					isQuick = false;
				}
			}
			int num3 = 0;
			StringBuilder stringBuilder = new StringBuilder();
			isCancelAnalysis = false;
			string text2 = DateTime.Now.ToString("yyyyMMdd");
			List<string> list = new List<string>();
			string text3 = "";
			bInternetConnected = true;
			bool ref_b_skip = false;
			tBar.set_Text("분석중...");
			for (int i = 0; i < count; i++)
			{
				if (!ref_b_skip && (!bInternetConnected || isCancelAnalysis))
				{
					ref_b_skip = true;
				}
				try
				{
					Application.DoEvents();
				}
				catch (InvalidOperationException ex)
				{
					Console.Error.WriteLine(ex.Message);
				}
				((ContentControl)btnAnalysisCancel).set_Content((object)("분석취소 [ " + i + " / " + count + " ]"));
				((RangeBase)progressBar1).set_Value((double)i);
				string strCheckSum = getCheckSum(arrDictList[i].Value);
				try
				{
					if (strCheckSum != "")
					{
						text3 = "";
						if (ref_b_skip)
						{
							num2 = ((!dictionary.ContainsKey(arrDictList[i].Key)) ? (-2) : dictionary[arrDictList[i].Key]);
						}
						else if (isQuick)
						{
							bool flag = false;
							num2 = 0;
							bool flag2 = true;
							try
							{
								flag2 = Directory.Exists(arrDictList[i].Key);
							}
							catch (Exception)
							{
								num2 = -1;
							}
							if (flag2 && num2 == 0)
							{
								flag = true;
							}
							else if (dictionary.ContainsKey(arrDictList[i].Key))
							{
								flag = true;
								int num4 = dictionary[arrDictList[i].Key];
								DateTime dateDeepAnalysis365_or = ((num4 != -1 && num4 != 1) ? dateDeepAnalysis365 : dateDeepAnalysis30);
								bool flag3 = false;
								if (dictionary2.ContainsKey(arrDictList[i].Key) && isOldAnalysis(dictionary2[arrDictList[i].Key], dateDeepAnalysis365_or))
								{
									bool flag4;
									if (flag4 = InnerDBStrCheckSum.ContainsKey(strCheckSum))
									{
										num2 = InnerDBStrCheckSum[strCheckSum];
									}
									if (flag3 || (flag4 && num2 == -1) || !flag4)
									{
										text = wc_DownloadString("https://www.virustotal.com/file/" + strCheckSum + "/analysis/", ref ref_b_skip);
										num2 = parseVirusTotal(ref text, ref strCheckSum);
										if (num2 != -2 && !InnerDBStrCheckSum.ContainsKey(strCheckSum))
										{
											InnerDBStrCheckSum.Add(strCheckSum, num2);
										}
									}
									text3 = getCheckSum(arrDictList[i].Value) + "\t" + text2;
								}
								else
								{
									num2 = num4;
								}
								if (num2 < -1)
								{
									flag = false;
								}
							}
							if (!flag)
							{
								if (num2 == -2 || !InnerDBStrCheckSum.ContainsKey(strCheckSum))
								{
									if (InnerDBStrCheckSum.ContainsKey(strCheckSum))
									{
										num2 = InnerDBStrCheckSum[strCheckSum];
									}
									else
									{
										text = wc_DownloadString("https://www.virustotal.com/file/" + strCheckSum + "/analysis/", ref ref_b_skip);
										num2 = parseVirusTotal(ref text, ref strCheckSum);
										try
										{
											if (num2 != -2)
											{
												InnerDBStrCheckSum.Add(strCheckSum, num2);
											}
										}
										catch (ArgumentException)
										{
											InnerDBStrCheckSum.Remove(strCheckSum);
											InnerDBStrCheckSum.Add(strCheckSum, num2);
										}
									}
								}
								else
								{
									num2 = InnerDBStrCheckSum[strCheckSum];
								}
								text3 = getCheckSum(arrDictList[i].Value) + "\t" + text2;
							}
						}
						else
						{
							if (InnerDBStrCheckSum.ContainsKey(strCheckSum))
							{
								num2 = InnerDBStrCheckSum[strCheckSum];
							}
							else
							{
								text = wc_DownloadString("https://www.virustotal.com/file/" + strCheckSum + "/analysis/", ref ref_b_skip);
								num2 = parseVirusTotal(ref text, ref strCheckSum);
								if (num2 != -2)
								{
									InnerDBStrCheckSum.Add(strCheckSum, num2);
								}
							}
							text3 = getCheckSum(arrDictList[i].Value) + "\t" + text2;
						}
					}
				}
				catch (WebException ex4)
				{
					if (ex4.InnerException != null)
					{
						if (ex4.InnerException!.Message.ToString().IndexOf("System.Net.Sockets.SocketException") > -1)
						{
							bInternetConnected = false;
						}
					}
					else if (ex4.Message.ToString().IndexOf("'www.virustotal.com'") > -1)
					{
						bInternetConnected = false;
					}
					if (!bInternetConnected && (int)MessageBox.Show("네트워크 문제로 분석할 수 없습니다. 다시시도(Retry)하려면 취소(Cancel)버튼을 누르세요.", ((Window)this).get_Title(), (MessageBoxButton)1, (MessageBoxImage)48) == 2)
					{
						bInternetConnected = true;
						continue;
					}
					num2 = -2;
					text3 = getCheckSum(arrDictList[i].Value) + "\t" + text2;
				}
				if (text3 == "" && arrDictList[i].Value == "")
				{
					continue;
				}
				StringBuilder stringBuilder2 = new StringBuilder();
				stringBuilder2.Append($"{num2:D2}");
				stringBuilder2.Append("|");
				stringBuilder2.Append(arrDictList[i].Key);
				stringBuilder2.Append("|");
				if (text3 == "")
				{
					if (dictionary2.ContainsKey(arrDictList[i].Key))
					{
						stringBuilder2.Append(dictionary2[arrDictList[i].Key]);
					}
					else
					{
						string[] array3 = arrDictList[i].Value.Split(new char[1] { ',' });
						stringBuilder2.Append(array3[0]);
						stringBuilder2.Append("\t");
						stringBuilder2.Append(text2);
					}
				}
				else
				{
					stringBuilder2.Append(text3);
				}
				list.Add(stringBuilder2.ToString());
			}
			if (list.Count >= 2 || bInternetConnected)
			{
				bool flag5 = false;
				if (!bInternetConnected)
				{
					if ((int)MessageBox.Show("진단된 파일 모두를 분석하지 못하였습니다. 그래도 파일로 출력하여 열람하시겠습니까?", ((Window)this).get_Title(), (MessageBoxButton)4, (MessageBoxImage)32) == 6)
					{
						flag5 = true;
					}
				}
				else
				{
					flag5 = true;
				}
				bool flag6 = true;
				if (flag5)
				{
					list.Sort(customCompare);
					count = list.Count;
					StringBuilder stringBuilder3 = new StringBuilder();
					StringBuilder stringBuilder4 = new StringBuilder();
					StringBuilder stringBuilder5 = new StringBuilder();
					bool flag7 = false;
					Process[] processes = Process.GetProcesses();
					for (int i = 0; i < count; i++)
					{
						if (list[i].StartsWith("-02"))
						{
							num3++;
						}
						string[] array3 = list[i].Split(new char[1] { '|' });
						if (num <= Convert.ToInt32(array3[0]))
						{
							if (!Directory.Exists(array3[1]) && Utils.FileExists(array3[1]))
							{
								if (flag6)
								{
									stringBuilder4.Append("#위험기준선: ");
									stringBuilder4.Append(num);
									stringBuilder4.Append("이상\r\n");
									stringBuilder4.Append("#바이러스로 정의하는 스크립트 모델입니다.\r\n");
									stringBuilder5.Append("#");
									stringBuilder5.Append("바이러스로 정의된 파일을 원래대로 복구시키는 스크립트 모델입니다.\r\n");
									flag6 = false;
								}
								int num5 = array3[1].LastIndexOf(Path.DirectorySeparatorChar);
								string str_fname = array3[1].Substring(num5 + 1);
								stringBuilder4.Append("#");
								string pureFileNameRemoveParam = getPureFileNameRemoveParam(str_fname);
								if (findedProcess(processes, pureFileNameRemoveParam))
								{
									stringBuilder4.Append("taskkill /F /IM \"");
									stringBuilder4.Append(pureFileNameRemoveParam);
									stringBuilder4.Append("\"");
									stringBuilder4.Append("\r\n");
								}
								try
								{
									int num6 = array3[1].IndexOf(":");
									string fileName;
									if (-1 < num6)
									{
										fileName = array3[1].Substring(num6 - 1);
										replaceFileNameWithParam(ref fileName);
									}
									else
									{
										fileName = array3[1];
									}
									FileAttributes attributes = File.GetAttributes(fileName);
									if ((attributes & FileAttributes.System) == FileAttributes.System)
									{
										stringBuilder4.Append("#");
										stringBuilder4.Append("attrib -S \"");
										stringBuilder4.Append(fileName);
										stringBuilder4.Append("\"");
										stringBuilder4.Append("\r\n");
									}
									if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
									{
										stringBuilder4.Append("#");
										stringBuilder4.Append("attrib -R \"");
										stringBuilder4.Append(fileName);
										stringBuilder4.Append("\"");
										stringBuilder4.Append("\r\n");
									}
									if ((attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
									{
										stringBuilder4.Append("#");
										stringBuilder4.Append("attrib -H \"");
										stringBuilder4.Append(fileName);
										stringBuilder4.Append("\"");
										stringBuilder4.Append("\r\n");
									}
									if (!Directory.Exists(fileName))
									{
										stringBuilder4.Append("#");
										stringBuilder4.Append("copy \"");
										stringBuilder4.Append(fileName);
										stringBuilder4.Append("\" \"");
										stringBuilder4.Append(fileName);
										stringBuilder4.Append(".virus\" /Y");
										stringBuilder4.Append("\r\n");
										stringBuilder4.Append("#");
										stringBuilder4.Append("del \"");
										stringBuilder4.Append(fileName);
										stringBuilder4.Append("\"");
										stringBuilder4.Append("\r\n");
										stringBuilder4.Append("#\r\n");
										stringBuilder5.Append("#");
										stringBuilder5.Append("copy \"");
										stringBuilder5.Append(fileName);
										stringBuilder5.Append(".virus\" \"");
										stringBuilder5.Append(fileName);
										stringBuilder5.Append("\" /Y");
										stringBuilder5.Append("\r\n");
									}
								}
								catch (Exception ex2)
								{
									stringBuilder5.Append("#::");
									stringBuilder5.Append(array3[1]);
									Console.Error.WriteLine(ex2.Message);
								}
							}
						}
						else if (!flag6 && !flag7)
						{
							flag7 = true;
							stringBuilder3.Append("#---").Append(num).Append("(으)로 설정한 위험기준선입니다.---------------------------------------------------------------------------------\r\n");
						}
						stringBuilder3.Append(list[i]);
						stringBuilder3.Append("\r\n");
					}
					stringBuilder.Append("#-----------------------------------------------------------------------------------------------------\r\n");
					stringBuilder.Append("#                                PowerHealthChecker 분석 보고서\r\n");
					stringBuilder.Append(serviceMsg);
					stringBuilder.Append("#-----------------------------------------------------------------------------------------------------\r\n");
					stringBuilder.Append("# -01:진단정보없음, 00:안전, 2자리숫자:위험도<높을수록 위험> | 분석파일정보 | 체크섬<tab>분석일\r\n");
					stringBuilder.Append("#※유의: 01~02로 보고되는 것을 지우면 사운드장치 등 하드웨어 연결에 심각한 상태가 유발된 적이 있었음.\r\n");
					stringBuilder.Append("# -02:진단중 오류발생(" + num3 + ")건\r\n");
					stringBuilder.Append("#-----------------------------------------------------------------------------------------------------\r\n");
					if (!flag6)
					{
						stringBuilder.Append((object?)stringBuilder4);
						stringBuilder.Append("#-----------------------------------------------------------------------------------------------------\r\n");
						stringBuilder.Append((object?)stringBuilder5);
						stringBuilder.Append("#-----------------------------------------------------------------------------------------------------\r\n");
					}
					stringBuilder.Append((object?)stringBuilder3);
					File.WriteAllText(logAnalysis, stringBuilder.ToString());
					CNativeWIN32.ShellExecute(0, "open", logAnalysis, null, null, 1);
				}
			}
			if (isCancelAnalysis)
			{
				tBar.set_Text("분석 도중 취소되었습니다.");
			}
			else
			{
				tBar.set_Text("분석완료");
			}
			string[] array4 = ApprovalList.globalSection.Keys.ToArray();
			for (int i = 0; i < array4.Length; i++)
			{
				if (array4[i] == null)
				{
					continue;
				}
				string path = ApprovalList.globalSection[array4[i]].Path;
				char directorySeparatorChar = Path.DirectorySeparatorChar;
				string text4 = path.Replace("/", directorySeparatorChar.ToString());
				if (dictionary.ContainsKey(text4))
				{
					ApprovalList.globalSection[array4[i]].Danger = string.Concat(dictionary[text4]);
					continue;
				}
				text4 = text4.ToLower();
				if (dictionary.ContainsKey(text4))
				{
					ApprovalList.globalSection[array4[i]].Danger = string.Concat(dictionary[text4]);
				}
				else
				{
					ApprovalList.globalSection[array4[i]].Danger = "-2";
				}
			}
		}
		((UIElement)progressBar1).set_Visibility((Visibility)1);
		((UIElement)btnAnalysisCancel).set_Visibility((Visibility)2);
		((UIElement)btnAnalysisQuick).set_Visibility((Visibility)0);
		((UIElement)progressBar1).InvalidateVisual();
		((UIElement)btnAnalysisCancel).InvalidateVisual();
		((UIElement)btnAnalysisQuick).InvalidateVisual();
		((ContentControl)btnAnalysisCancel).set_Content((object)"분석취소");
	}

	public static string getHref(string strDown)
	{
		string result = "";
		string text = "href=\"";
		string value = "\"";
		int num = strDown.IndexOf(text);
		int num2 = strDown.IndexOf(value, num + 1);
		if (num < num2)
		{
			result = strDown.Substring(num + text.Length, num2 - num - text.Length);
		}
		return result;
	}

	private string wc_DownloadString(string p, ref bool ref_b_skip)
	{
		strWEBresult = null;
		try
		{
			webF_idx++;
			if (webF.Count() <= webF_idx)
			{
				webF_idx %= webF.Count();
			}
			webF[webF_idx].Navigate(p);
			long num = CNativeWIN32.CurrentTimeMillis() + 10000L;
			while (strWEBresult == null && !isCancelAnalysis)
			{
				Application.DoEvents();
				if (num < CNativeWIN32.CurrentTimeMillis())
				{
					strWEBresult = "";
					break;
				}
			}
		}
		catch (Exception)
		{
			isCancelAnalysis = true;
		}
		if (strWEBresult != null)
		{
			if (strWEBresult.IndexOf(" / ") == -1)
			{
				sleepMilisec += 1000;
				CNativeWIN32.Sleep(sleepMilisec);
				if (10000 < sleepMilisec)
				{
					ref_b_skip = true;
				}
			}
			else
			{
				sleepMilisec--;
				if (sleepMilisec <= 0)
				{
					sleepMilisec = 1;
				}
			}
			((HeaderedItemsControl)mnuSleepMilisec).set_Header((object)("SleepMiliSec: " + sleepMilisec));
			Application.DoEvents();
		}
		return strWEBresult;
	}

	private bool findedProcess(Process[] arrProcess, string strPureFileName)
	{
		bool result = false;
		string text = strPureFileName;
		int num = strPureFileName.LastIndexOf(".");
		if (-1 < num)
		{
			text = text.Substring(0, num);
		}
		for (int i = 0; i < arrProcess.Count(); i++)
		{
			if (1000 <= arrProcess[i].Id && text == arrProcess[i].ProcessName)
			{
				result = true;
				break;
			}
		}
		return result;
	}

	public static string getPureFileNameRemoveParam(string str_fname)
	{
		str_fname = parsePathByEnvVal(str_fname);
		if (str_fname.StartsWith("\""))
		{
			int num = str_fname.IndexOf("\"", 1);
			return str_fname.Substring(1, num - 1);
		}
		string text = str_fname;
		int num2 = str_fname.IndexOf(" -");
		int num3 = str_fname.IndexOf(" /");
		if (-1 < num2 || -1 < num3)
		{
			text = text[..((-1 < num2 && -1 < num3) ? Math.Min(num2, num3) : ((-1 >= num2) ? num3 : num2))];
		}
		return text.Trim();
	}

	private bool isOldAnalysis(string p, DateTime dateDeepAnalysis365_or30)
	{
		string[] array = p.Split('\t', ',');
		if (array.Length < 2)
		{
			return true;
		}
		DateTime dateTime = DateTime.ParseExact(array[1], "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None);
		if (dateDeepAnalysis365_or30 > dateTime)
		{
			isOldFlag = true;
			return isOldFlag;
		}
		return false;
	}

	private int parseVirusTotal(ref string strDown, ref string strCheckSum)
	{
		int num = 0;
		int num2 = -1;
		try
		{
			num = strDown.IndexOf(" / ");
			if (strDown.Length == 0)
			{
				num2 = -2;
			}
			if (num > -1)
			{
				num2 = int.Parse(strDown.Substring(num - 3, 3).Replace("\"", "").Replace(">", ""));
				if (num2 > 99)
				{
					num2 = 99;
				}
			}
			else
			{
				num2 = -3;
			}
		}
		catch (Exception)
		{
			num2 = -2;
		}
		return num2;
	}

	private int parseHerdProtect(ref string strDown, ref string strCheckSum)
	{
		int num = 0;
		int num2 = -1;
		try
		{
			num = strDown.IndexOf(" / ");
			if (strDown.Length == 0)
			{
				num2 = -2;
			}
			if (num > -1)
			{
				num2 = int.Parse(strDown.Substring(num - 3, 3).Replace("\"", "").Replace(">", ""));
				if (num2 > 99)
				{
					num2 = 99;
				}
			}
		}
		catch (Exception)
		{
			num2 = -2;
		}
		return num2;
	}

	private void btnAnalysisQuick_Click(object sender, RoutedEventArgs e)
	{
		if (((UIElement)btnAnalysisQuick).get_IsEnabled())
		{
			Analysis(isQuick: true);
		}
	}

	private void btnAnalysisDeep_Click(object sender, RoutedEventArgs e)
	{
		if (((UIElement)btnAnalysisDeep).get_IsEnabled())
		{
			Analysis(isQuick: false);
		}
	}

	private void btnAnalysisCancel_Click(object sender, RoutedEventArgs e)
	{
		isCancelAnalysis = true;
		tBar.set_Text("분석 취소중...");
	}

	private void txtHealthReport_GotFocus(object sender, RoutedEventArgs e)
	{
		((UIElement)lblHelp).set_Visibility((Visibility)1);
	}

	private bool? IsCabledLan(string p)
	{
		bool? result = null;
		RegistryKey registryKey2;
		if (Utils.Is64OS())
		{
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
			registryKey2 = registryKey.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\Control\\Class\\{4D36E972-E325-11CE-BFC1-08002BE10318}\\") + p.PadLeft(4, '0'));
		}
		else
		{
			registryKey2 = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\Control\\Class\\{4D36E972-E325-11CE-BFC1-08002BE10318}\\") + p.PadLeft(4, '0'));
		}
		int num = 0;
		if (registryKey2 != null)
		{
			switch (Convert.ToInt32(registryKey2.GetValue("*IfType", 0)))
			{
			case 6:
				result = true;
				break;
			case 71:
				result = false;
				break;
			}
		}
		return result;
	}

	public List<string> GetMACAddressList()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Expected O, but got Unknown
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Expected O, but got Unknown
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Expected O, but got Unknown
		ManagementClass val = new ManagementClass("Win32_NetworkAdapterConfiguration");
		ManagementObjectCollection val2 = null;
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		List<string> list3 = new List<string>();
		string empty = string.Empty;
		try
		{
			val2 = val.GetInstances();
			ManagementObjectEnumerator enumerator = val2.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val3 = (ManagementObject)enumerator.get_Current();
					try
					{
						if (((ManagementBaseObject)val3).get_Item("MacAddress") == null)
						{
							continue;
						}
						empty = ((ManagementBaseObject)val3).get_Item("MacAddress").ToString();
						empty = empty.Replace(":", "-");
						string text = ((ManagementBaseObject)val3).get_Item("Description").ToString()!.ToLower();
						if (text == "ras async adapter")
						{
							continue;
						}
						try
						{
							if (IsCabledLan(((ManagementBaseObject)val3).get_Item("Index").ToString()) == true)
							{
								list.Add(empty);
							}
							else
							{
								list2.Add(empty);
							}
						}
						catch (Exception)
						{
							if ((bool)((ManagementBaseObject)val3).get_Item("IPEnabled") && text.IndexOf("wireless") == -1 && text.IndexOf("wi-fi") == -1 && text.IndexOf("virtual") == -1 && text.IndexOf("vpn") == -1 && text.IndexOf("bluetooth") == -1 && text.IndexOf("wifi") == -1 && text.IndexOf("802") == -1)
							{
								list.Add(empty);
							}
							else if ((text.IndexOf("real") > -1 || text.IndexOf("marvell") > -1 || text.IndexOf("intel") > -1 || text.IndexOf("3com") > -1 || text.IndexOf("rtl") > -1 || text.IndexOf("gigabit") > -1 || text.IndexOf("nvidia") > -1 || text.IndexOf("via") > -1 || text.IndexOf("broadcom") > -1 || text.IndexOf("100") > -1 || text.IndexOf("ethernet") > -1) && text.IndexOf("wireless") == -1 && text.IndexOf("wi-fi") == -1 && text.IndexOf("virtual") == -1 && text.IndexOf("vpn") == -1 && text.IndexOf("bluetooth") == -1 && text.IndexOf("wifi") == -1 && text.IndexOf("802") == -1)
							{
								list2.Add(empty);
							}
							else
							{
								list3.Add(empty);
							}
							val3.Dispose();
						}
					}
					catch (Exception)
					{
					}
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			for (int i = 0; i < list3.Count; i++)
			{
				list2.Add(list3[i]);
			}
			for (int i = 0; i < list2.Count; i++)
			{
				list.Add(list2[i]);
			}
		}
		catch (Exception)
		{
			try
			{
				string text2 = "select * FROM Win32_NetworkAdapter";
				ObjectQuery val4 = new ObjectQuery(text2);
				ManagementObjectSearcher val5 = new ManagementObjectSearcher(val4);
				ManagementObjectEnumerator enumerator = val5.Get().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						ManagementObject val6 = (ManagementObject)enumerator.get_Current();
						try
						{
							if (((ManagementBaseObject)val6).get_Item("MacAddress") == null)
							{
								goto IL_0561;
							}
							empty = ((ManagementBaseObject)val6).get_Item("MacAddress").ToString();
							empty = empty.Replace(":", "-");
							try
							{
								string text = ((ManagementBaseObject)val6).get_Item("Description").ToString()!.ToLower();
								if (text == "ras async adapter")
								{
									continue;
								}
								try
								{
									if (IsCabledLan(((ManagementBaseObject)val6).get_Item("DeviceID").ToString()) == true)
									{
										list.Add(empty);
									}
									else
									{
										list2.Add(empty);
									}
								}
								catch (Exception)
								{
									if ((text.IndexOf("real") > -1 || text.IndexOf("marvell") > -1 || text.IndexOf("intel") > -1 || text.IndexOf("3com") > -1 || text.IndexOf("rtl") > -1 || text.IndexOf("gigabit") > -1 || text.IndexOf("nvidia") > -1 || text.IndexOf("via") > -1 || text.IndexOf("broadcom") > -1 || text.IndexOf("100") > -1 || text.IndexOf("ethernet") > -1) && text.IndexOf("wireless") == -1 && text.IndexOf("wi-fi") == -1 && text.IndexOf("virtual") == -1 && text.IndexOf("vpn") == -1 && text.IndexOf("bluetooth") == -1 && text.IndexOf("wifi") == -1 && text.IndexOf("802") == -1)
									{
										list.Add(empty);
									}
									else
									{
										list2.Add(empty);
									}
								}
								goto IL_0561;
							}
							catch (ManagementException)
							{
								list2.Add(empty);
								goto IL_0561;
							}
							IL_0561:
							val6.Dispose();
						}
						catch (Exception)
						{
						}
					}
				}
				finally
				{
					((IDisposable)enumerator)?.Dispose();
				}
				for (int i = 0; i < list2.Count; i++)
				{
					list.Add(list2[i]);
				}
			}
			catch (Exception)
			{
				string text3 = "";
				NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
				foreach (NetworkInterface networkInterface in allNetworkInterfaces)
				{
					if (networkInterface.NetworkInterfaceType == NetworkInterfaceType.Ethernet || networkInterface.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || networkInterface.NetworkInterfaceType == NetworkInterfaceType.Unknown)
					{
						text3 = networkInterface.GetPhysicalAddress().ToString();
						if (text3.IndexOf("-") == -1 && text3.Length >= 12 && networkInterface.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
						{
							text3 = text3.Substring(0, 2) + "-" + text3.Substring(2, 2) + "-" + text3.Substring(4, 2) + "-" + text3.Substring(6, 2) + "-" + text3.Substring(8, 2) + "-" + text3.Substring(10, 2);
							list.Add(text3);
						}
						else if (text3.IndexOf("-") == -1 && text3.Length >= 12)
						{
							text3 = text3.Substring(0, 2) + "-" + text3.Substring(2, 2) + "-" + text3.Substring(4, 2) + "-" + text3.Substring(6, 2) + "-" + text3.Substring(8, 2) + "-" + text3.Substring(10, 2);
							list2.Add(text3);
						}
					}
				}
				int i = 0;
				while (true)
				{
					if (i < list2.Count)
					{
						list.Add(list2[i]);
						i++;
						continue;
					}
					goto end_IL_05b4;
				}
				end_IL_05b4:;
			}
		}
		return list;
	}

	public string GetMACAddress()
	{
		List<string> mACAddressList = GetMACAddressList();
		if (mACAddressList == null || mACAddressList.Count == 0)
		{
			return string.Empty;
		}
		return mACAddressList[0];
	}

	private void btnMsraRequest_Click(object sender, RoutedEventArgs e)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Expected O, but got Unknown
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		string text = null;
		text = Environment.GetFolderPath(Environment.SpecialFolder.SystemX86) + Utils.SEPA + "msra.exe";
		if (!Utils.IsNotServerMachine() && !Utils.FileExists(text))
		{
			AutoClosingMessageBox.Show("서버는 해당 기능이 지원되지 않습니다.", "PowerHealthChecker", 3100, 0);
			return;
		}
		try
		{
			bTimerKill = false;
			if (((ToggleButton)chkUsePrivMail).get_IsChecked() == true)
			{
				if (((ToggleButton)chkSave1).get_IsChecked() == true)
				{
					RegiHelperSrc.Instance.SavedGmailID = txtGmailID.get_Text();
					RegiHelperSrc.Instance.Saved1 = true;
				}
				else
				{
					RegiHelperSrc.Instance.SavedGmailID = "";
					RegiHelperSrc.Instance.Saved1 = false;
				}
				if (((ToggleButton)chkSave2).get_IsChecked() == true)
				{
					RegiHelperSrc.Instance.SavedMailPasswd = UtilCrypto.EncryptStringAES(txtGmailPass.get_Password(), GetMACAddress() + DateTime.Now.ToString("yyyy"));
					RegiHelperSrc.Instance.Saved2 = true;
				}
				else
				{
					RegiHelperSrc.Instance.SavedMailPasswd = "";
					RegiHelperSrc.Instance.Saved2 = false;
				}
			}
			if (((ToggleButton)chkSave3).get_IsChecked() == true)
			{
				RegiHelperSrc.Instance.SavedReceiverMail = txtReceiverMailAddress.get_Text();
				RegiHelperSrc.Instance.Saved3 = true;
			}
			else
			{
				RegiHelperSrc.Instance.SavedReceiverMail = "";
				RegiHelperSrc.Instance.Saved3 = false;
			}
			if (!inputEmailValid())
			{
				return;
			}
			Random random = new Random();
			strRndPassword = string.Concat(Math.Ceiling(random.NextDouble() * 10000000000.0) + 100000.0);
			bUseAsynch = true;
			DirectoryInfo directoryInfo = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Utils.SEPA + "HealthChecker");
			if (!directoryInfo.Exists)
			{
				directoryInfo.Create();
			}
			files[0] = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Utils.SEPA + "HealthChecker" + Utils.SEPA + "ShareScreeenFile.msrcIncident";
			FileInfo fileInfo = new FileInfo(files[0]);
			try
			{
				if (fileInfo.Exists)
				{
					fileInfo.Delete();
				}
			}
			catch (Exception)
			{
			}
			Process[] processesByName = Process.GetProcessesByName("MSRA");
			if (processesByName.Count() > 0)
			{
				try
				{
					processesByName = Process.GetProcessesByName("MSRA");
					for (int i = 0; i < processesByName.Count(); i++)
					{
						processesByName[i].Kill();
					}
				}
				catch (Exception)
				{
				}
			}
			receives[0] = txtReceiverMailAddress.get_Text();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.UseShellExecute = true;
			processStartInfo.FileName = text;
			processStartInfo.WorkingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.SystemX86);
			string text2 = "/saveasfile \"" + files[0] + "\" " + strRndPassword;
			if (text2.IndexOf(" ") > -1 && text2.IndexOf("\"") == -1)
			{
				text2 = "\"" + text2 + "\"";
			}
			processStartInfo.Arguments = text2;
			processStartInfo.Verb = "runas";
			Process.Start(processStartInfo);
			DispatcherTimer val = new DispatcherTimer();
			val.set_Interval(TimeSpan.FromMilliseconds(1000.0));
			val.add_Tick((EventHandler)SendSMTPtimer_Tick);
			val.Start();
			btnSetAllow.PerformClick();
			if ("".Equals(memStrAutoAllowPassword))
			{
				((ToggleButton)chkAutoAllow).set_IsChecked((bool?)true);
				Random random2 = new Random();
				memStrAutoAllowPassword = string.Concat(Math.Ceiling(random2.NextDouble() * 9000.0) + 1000.0);
				AutoClosingMessageBox.Show("자동 수락 설정되었습니다.\n자동수락 임시 암호(숫자4자): [" + memStrAutoAllowPassword + "]\n메모지에 펜으로 기록하길 권장.", "PowerHealthChecker", 40000, 0);
			}
		}
		catch (Exception ex3)
		{
			MessageBox.Show(text + " " + ex3.Message, ((Window)this).get_Title(), (MessageBoxButton)0, (MessageBoxImage)48);
		}
	}

	private void SendSMTPtimer_Tick(object sender, EventArgs e)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.FileExists(files[0]))
		{
			CNativeWIN32.Sleep(100);
			((DispatcherTimer)sender).Stop();
			((DispatcherTimer)sender).remove_Tick((EventHandler)SendSMTPtimer_Tick);
			sender = null;
			string prop = null;
			SendSMTPmail("[Share Screen]" + txtMailContent.get_Text(), "Password is " + strRndPassword + "\n" + txtMailContent.get_Text() + strAutoAddedMailContent() + "\nFrom: " + RegiHelperSrc.Instance.StringPropertyGet(ref prop, "UAuthEmail"), receives, txtGmailID.get_Text() + "@gmail.com", txtGmailPass.get_Password(), files, useUTF8: true, useHTML: false, bUseAsynch);
		}
	}

	private string strAutoAddedMailContent()
	{
		if (((ToggleButton)chkUsePrivMail).get_IsChecked() == true)
		{
			return "";
		}
		return "\nDo not reply to this email. this email is auto generated.";
	}

	private bool inputEmailValid()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		bool result = true;
		if (txtGmailID.get_Text().IndexOf("@") > -1)
		{
			result = false;
			MessageBox.Show("보내는 메일계정에 '@'가 들어있으면 안됩니다.", ((Window)this).get_Title(), (MessageBoxButton)0, (MessageBoxImage)48);
			((UIElement)txtGmailID).Focus();
		}
		else if (txtGmailPass.get_Password().Trim() == "")
		{
			result = false;
			MessageBox.Show("메일 암호를 입력하세요.", ((Window)this).get_Title(), (MessageBoxButton)0, (MessageBoxImage)48);
			((UIElement)txtGmailPass).Focus();
		}
		else if (txtReceiverMailAddress.get_Text().IndexOf("@") == -1 || txtReceiverMailAddress.get_Text().IndexOf(".") == -1)
		{
			result = false;
			MessageBox.Show("받는 사람 메일주소가 잘못되었습니다.", ((Window)this).get_Title(), (MessageBoxButton)0, (MessageBoxImage)48);
			((UIElement)txtReceiverMailAddress).Focus();
		}
		else if (txtReceiverMailAddress.get_Text().Trim() == "")
		{
			result = false;
			MessageBox.Show("받는 사람 메일주소를 입력하세요.", ((Window)this).get_Title(), (MessageBoxButton)0, (MessageBoxImage)48);
			((UIElement)txtReceiverMailAddress).Focus();
		}
		return result;
	}

	private static string getMailIdPartFromEmail(string from)
	{
		int startIndex = 0;
		int num = 0;
		if (from.IndexOf("<") > -1)
		{
			startIndex = from.IndexOf("<") + 1;
			num = from.IndexOf("@", startIndex);
		}
		else
		{
			num = from.IndexOf("@");
		}
		return from.Substring(startIndex, num);
	}

	public static bool SendSMTPmail(string subject, string content, string[] recipients, string from, string strPasswd, string[] files, bool useUTF8, bool useHTML, bool useBackGroundSend)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		bool result;
		if (result = recipients != null && recipients.Length > 0)
		{
			if (gmailClient != null)
			{
				MessageBox.Show("You can not send new e-mail during sending on the mail. Please try again later.", Process.GetCurrentProcess().MainWindowTitle, (MessageBoxButton)0, (MessageBoxImage)48);
				return false;
			}
			SmtpClient smtpClient = new SmtpClient();
			smtpClient.Host = "smtp.gmail.com";
			smtpClient.Port = 587;
			smtpClient.EnableSsl = true;
			smtpClient.UseDefaultCredentials = false;
			smtpClient.Credentials = new NetworkCredential(getMailIdPartFromEmail(from), strPasswd);
			smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
			smtpClient.PickupDirectoryLocation = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\HealthChecker";
			smtpClient.Timeout = 20000;
			gmailClient = smtpClient;
			MailMessage gMessage = new MailMessage(from, recipients[0], subject, content);
			if (useUTF8)
			{
				gMessage.BodyEncoding = Encoding.UTF8;
				gMessage.SubjectEncoding = Encoding.UTF8;
			}
			for (int i = 1; i < recipients.Length; i++)
			{
				gMessage.To.Add(recipients[i]);
			}
			try
			{
				if (files != null)
				{
					for (int i = 0; i < files.Count(); i++)
					{
						string fileName = files[i];
						Attachment item = new Attachment(fileName, "application/octet-stream");
						gMessage.Attachments.Add(item);
					}
				}
				if (useBackGroundSend)
				{
					gmailClient.SendCompleted += delegate(object sender, AsyncCompletedEventArgs e)
					{
						//IL_0057: Unknown result type (might be due to invalid IL or missing references)
						//IL_0090: Unknown result type (might be due to invalid IL or missing references)
						try
						{
							string text2 = (string)e.UserState;
							gMessage.Dispose();
							gmailClient.Dispose();
							gMessage = null;
							gmailClient = null;
							if (e.Cancelled)
							{
								MessageBox.Show("[" + text2 + "] Send canceled.", Process.GetCurrentProcess().MainWindowTitle, (MessageBoxButton)0, (MessageBoxImage)48);
							}
							if (e.Error != null)
							{
								MessageBox.Show("[" + text2 + "] " + e.Error!.Message, Process.GetCurrentProcess().MainWindowTitle, (MessageBoxButton)0, (MessageBoxImage)48);
							}
							else if (!e.Cancelled)
							{
								string text3 = "\n메일을 성공적으로 보냈습니다.";
								MessageBoxTimerClose messageBoxTimerClose = new MessageBoxTimerClose("[" + Process.GetCurrentProcess().ProcessName + "] " + text3);
								((Window)messageBoxTimerClose).ShowDialog();
								((Window)messageBoxTimerClose).Close();
								if (((ToggleButton)Instance.chkAutoAllow).get_IsChecked() == true)
								{
									Instance.autoAllowCheckedTimerProcess();
								}
							}
						}
						finally
						{
						}
					};
					string userToken = from + " => " + recipients[0] + ((recipients.Length > 1) ? (" + (" + (recipients.Count() - 1) + ")") : "") + " Title:" + subject;
					gmailClient.SendAsync(gMessage, userToken);
				}
				else
				{
					Application.DoEvents();
					gmailClient.Send(gMessage);
					Application.DoEvents();
					gMessage.Dispose();
					gmailClient.Dispose();
					gMessage = null;
					gmailClient = null;
					string text = "메일을 성공적으로 보냈습니다.";
					AutoClosingMessageBox.Show1(text, "PowerHealthChecker", 3100, 0);
				}
				result = true;
			}
			catch (Exception ex)
			{
				gMessage = null;
				gmailClient = null;
				MessageBox.Show(ex.Message, Process.GetCurrentProcess().MainWindowTitle, (MessageBoxButton)0, (MessageBoxImage)48);
				result = false;
			}
		}
		return result;
	}

	[DllImport("user32.dll")]
	private static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll")]
	private static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

	[DllImport("user32.dll")]
	private static extern bool GetWindowRect(IntPtr hWnd, out RECT lprect);

	private string GetActiveWindowTitle()
	{
		StringBuilder stringBuilder = new StringBuilder(256);
		IntPtr foregroundWindow = GetForegroundWindow();
		if (GetWindowText(foregroundWindow, stringBuilder, 256) > 0)
		{
			return stringBuilder.ToString();
		}
		return "";
	}

	private void autoAllowCheckedTimerProcess()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		if (AutoAllowTimer == null)
		{
			AutoAllowTimer = new DispatcherTimer();
			AutoAllowTimer.add_Tick((EventHandler)AutoAllowTimer_Tick);
			AutoAllowTimer.set_Interval(TimeSpan.FromMilliseconds(10000.0));
			AutoAllowTimer.Start();
		}
		else
		{
			AutoAllowTimer.Start();
		}
	}

	private void AutoAllowTimer_Tick(object sender, EventArgs e)
	{
		IntPtr foregroundWindow = GetForegroundWindow();
		new StringBuilder();
		string activeWindowTitle = GetActiveWindowTitle();
		if (activeWindowTitle.StartsWith("Windows ") && -1 == activeWindowTitle.IndexOf("-") && ((ToggleButton)chkAutoAllow).get_IsChecked() == true)
		{
			GetWindowRect(foregroundWindow, out outRECT);
			if (outRECT.Width / outRECT.Height == 1)
			{
				SendKeys.SendWait("{LEFT}");
				CNativeWIN32.Sleep(300);
				SendKeys.SendWait("{ENTER}");
				CNativeWIN32.Sleep(400);
			}
		}
		if (bTimerKill || ((ToggleButton)chkAutoAllow).get_IsChecked() == false || Process.GetProcessesByName("MSRA").Count() == 0)
		{
			DispatcherTimer val = (DispatcherTimer)((sender is DispatcherTimer) ? sender : null);
			val.Stop();
			((ToggleButton)chkAutoAllow).set_IsChecked((bool?)false);
			if (bTimerKill)
			{
				val.remove_Tick((EventHandler)AutoAllowTimer_Tick);
				val = null;
				AutoAllowTimer = null;
				Application.get_Current().Shutdown();
			}
		}
	}

	private void chkAutoAllow_Checked(object sender, RoutedEventArgs e)
	{
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		if (!((FrameworkElement)this).get_IsLoaded() || Process.GetProcessesByName("MSRA").Count() <= 0)
		{
			return;
		}
		bool flag = false;
		if (memStrAutoAllowPassword.Length == 0)
		{
			flag = true;
		}
		else
		{
			string text = "";
			text = Interaction.InputBox("자동수락시 부여된 임시 암호(숫자4자)를 입력하세요.\n공유 일시 중지를 먼저 누른 후 입력하세요.\n그 후 계속을 누르세요.", ((Window)this).get_Title(), memStrAutoAllowPassword.Substring(0, 1) + "***", -1, -1);
			if (!text.Equals(memStrAutoAllowPassword))
			{
				AutoClosingMessageBox.Show("암호가 일치하지 않습니다.", "PowerHealthChecker", 3100, 0);
				((ToggleButton)chkAutoAllow).set_IsChecked((bool?)false);
				return;
			}
			flag = true;
		}
		if (flag)
		{
			autoAllowCheckedTimerProcess();
		}
	}

	private void chkUsePrivMail_Checked(object sender, RoutedEventArgs e)
	{
		if (((FrameworkElement)this).get_IsLoaded())
		{
			getRegValueForMsra();
		}
	}

	private void chkUsePrivMail_Unchecked(object sender, RoutedEventArgs e)
	{
		getRegValueForMsra();
	}

	private void btnRemoveSharp_Click(object sender, RoutedEventArgs e)
	{
		string text = txtFileName.get_Text().Replace("#", "");
		txtFileName.set_Text(text);
	}

	public void mnuVacc1_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine1)
		{
			Utils.ExecuteCommandSync(REGSVR32 + " " + replaceNormalizePath("%windir%\\system32\\WSHom.Ocx"));
			RegiHelperSrc.Instance.CheckedVaccine1 = false;
		}
		else
		{
			Utils.ExecuteCommandSync(REGSVR32 + " /u " + replaceNormalizePath("%windir%\\system32\\WSHom.Ocx"));
			RegiHelperSrc.Instance.CheckedVaccine1 = true;
		}
	}

	public void mnuVacc2_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine2)
		{
			Utils.ExecuteCommandSync(REGSVR32 + " " + replaceNormalizePath("%windir%\\system32\\scrrun.dll"));
			RegiHelperSrc.Instance.CheckedVaccine2 = false;
		}
		else
		{
			Utils.ExecuteCommandSync(REGSVR32 + " /u " + replaceNormalizePath("%windir%\\system32\\scrrun.dll"));
			RegiHelperSrc.Instance.CheckedVaccine2 = true;
		}
	}

	public void mnuVacc3_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine3)
		{
			Utils.ExecuteCommandSync(REGSVR32 + " \"" + replaceNormalizePath("C:\\Program Files\\Common Files\\System\\ado\\msado15.dll") + "\"");
			RegiHelperSrc.Instance.CheckedVaccine3 = false;
		}
		else
		{
			Utils.ExecuteCommandSync(REGSVR32 + " /u \"" + replaceNormalizePath("C:\\Program Files\\Common Files\\System\\ado\\msado15.dll") + "\"");
			RegiHelperSrc.Instance.CheckedVaccine3 = true;
		}
	}

	private void mnuSFC_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", replaceNormalizePath("%windir%\\system32\\cmd.exe"), "/c sfc /scannow & pause", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuAgreeCostFunctionUse_Click(object sender, RoutedEventArgs e)
	{
		if (!mnuAgreeCostFunctionUse.get_IsChecked())
		{
			((UIElement)btnAnalysisCancel).set_IsEnabled(true);
			App.iniFile.WriteValue_UTF8("AnalysisUSE", "True");
		}
		else
		{
			((UIElement)btnAnalysisQuick).set_IsEnabled(false);
			((UIElement)btnAnalysisCancel).set_IsEnabled(false);
			App.iniFile.WriteValue_UTF8("AnalysisUSE", "False");
		}
		mnuAgreeCostFunctionUse.set_IsChecked(!mnuAgreeCostFunctionUse.get_IsChecked());
	}

	private void mnuTMP_Click(object sender, RoutedEventArgs e)
	{
		string tempPath = getTempPath();
		if (tempPath != null)
		{
			CNativeWIN32.ShellExecute(0, "open", tempPath, "", "", 1);
		}
	}

	private string getTempPath()
	{
		bool flag = false;
		string text = Environment.GetEnvironmentVariable("temp");
		if (-1 < text.IndexOf(":") && Directory.Exists(text))
		{
			flag = true;
		}
		if (!flag)
		{
			text = Environment.GetEnvironmentVariable("tmp");
			if (-1 < text.IndexOf(":") && Directory.Exists(text))
			{
				flag = true;
			}
		}
		if (!flag)
		{
			text = null;
		}
		return text;
	}

	public static string parsePathByEnvVal(string str)
	{
		string text = str;
		int num = text.IndexOf("%");
		int num2 = -1;
		if (-1 < num)
		{
			num2 = text.IndexOf("%", num + 1);
		}
		if (0 < num2)
		{
			string text2 = text.Substring(0, num);
			string variable = text.Substring(num + 1, num2 - num - 1);
			string text3 = text.Substring(num2 + 1);
			text = text2 + Environment.GetEnvironmentVariable(variable) + text3;
			if (-1 < text.IndexOf("%"))
			{
				text = parsePathByEnvVal(text);
			}
		}
		return text;
	}

	private void mnuTest_Click(object sender, RoutedEventArgs e)
	{
		StringBuilder stringBuilder = new StringBuilder();
		int cnt = 0;
		int cntOfMinoError = 0;
		GetHardDiskFreeSpaceInfo(stringBuilder, ref cnt, ref cntOfMinoError);
		Console.WriteLine(stringBuilder.ToString());
	}

	internal void mnuReadRTF_Click(object sender, RoutedEventArgs e)
	{
		if (Utils.FileExists("com.rtf"))
		{
			string text = App.FileCheckSum("com.rtf");
			if ("8f5fc533381f5c7ec96bb3da16467ed6cf77ecf5f3419e07397f3a40b09ec915" != text)
			{
				Utils.alert("안내 파일이 변조된 것 같습니다." + Environment.NewLine + "프로그램을 다시 설치 한 후 열람하세요.(com.rtf)");
				return;
			}
			Utils.alert("안내 파일(com.rtf)은 변조 되지 않은 신뢰 할 수 있는 파일입니다.");
			CNativeWIN32.ShellExecute(0, "open", "com.rtf", "", null, 1);
		}
	}

	private void mnuExit_Click(object sender, RoutedEventArgs e)
	{
		Application.get_Current().get_MainWindow().Close();
		Application.get_Current().Shutdown();
	}

	public static void SortDataGrid(DataGrid dataGrid, int columnIndex = 0, ListSortDirection sortDirection = ListSortDirection.Ascending)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		DataGridColumn val = dataGrid.get_Columns()[columnIndex];
		((CollectionView)((ItemsControl)dataGrid).get_Items()).get_SortDescriptions();
		((Collection<SortDescription>)(object)((CollectionView)((ItemsControl)dataGrid).get_Items()).get_SortDescriptions()).Clear();
		((Collection<SortDescription>)(object)((CollectionView)((ItemsControl)dataGrid).get_Items()).get_SortDescriptions()).Add(new SortDescription(val.get_SortMemberPath(), sortDirection));
		foreach (DataGridColumn column in dataGrid.get_Columns())
		{
			column.set_SortDirection((ListSortDirection?)null);
		}
		val.set_SortDirection((ListSortDirection?)sortDirection);
		((CollectionView)((ItemsControl)dataGrid).get_Items()).Refresh();
	}

	private void ISY_Checked(object sender, RoutedEventArgs e)
	{
	}

	private void ISN_Checked(object sender, RoutedEventArgs e)
	{
	}

	private void btnAllApproval_Click(object sender, RoutedEventArgs e)
	{
		string[] array = ApprovalList.globalSection.Keys.ToArray();
		for (int i = 0; i < array.Length; i++)
		{
			if (!ApprovalList.globalSection[array[i]].IsY && !ApprovalList.globalSection[array[i]].IsN)
			{
				ApprovalList.globalSection[array[i]].IsYN = "Y";
			}
		}
	}

	private void btnViewNewed_Click(object sender, RoutedEventArgs e)
	{
		((UIElement)btnViewNewed).set_Visibility((Visibility)2);
		((UIElement)btnViewAll).set_Visibility((Visibility)0);
		for (int i = 0; i < itmListViewApproval.Count; i++)
		{
			if (itmListViewApproval[i].IsYN == "Y")
			{
				itmListViewApproval_tmp.Add(itmListViewApproval[i]);
				itmListViewApproval.RemoveAt(i--);
			}
		}
		lvApproval_refresh();
		if (0 < itmListViewApproval.Count)
		{
			SortDataGrid(lvApproval, 6);
		}
	}

	private void lvApproval_refresh()
	{
		((ItemsControl)lvApproval).set_ItemsSource((IEnumerable)null);
		((ItemsControl)lvApproval).set_ItemsSource((IEnumerable)itmListViewApproval);
	}

	private void btnViewAll_Click(object sender, RoutedEventArgs e)
	{
		((UIElement)btnViewNewed).set_Visibility((Visibility)0);
		((UIElement)btnViewAll).set_Visibility((Visibility)2);
		for (int i = 0; i < itmListViewApproval_tmp.Count; i++)
		{
			itmListViewApproval.Add(itmListViewApproval_tmp[i]);
		}
		itmListViewApproval_tmp.Clear();
		lvApproval_refresh();
		if (0 < itmListViewApproval.Count)
		{
			SortDataGrid(lvApproval, 6);
		}
	}

	private void lvApproval_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
	}

	private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
	{
		if (((UIElement)this).get_IsVisible() && frmOnWorking != null)
		{
			((Control)frmOnWorking).Hide();
		}
	}

	private void isY_Click(object sender, RoutedEventArgs e)
	{
		RadioButton val = (RadioButton)((sender is RadioButton) ? sender : null);
		if (e.get_OriginalSource() == val && val.get_GroupName() != "")
		{
			ApprovalList itemByGroupName = ApprovalList.getItemByGroupName(val.get_GroupName());
			itemByGroupName.IsYN = "Y";
		}
	}

	private void isN_Click(object sender, RoutedEventArgs e)
	{
		RadioButton val = (RadioButton)((sender is RadioButton) ? sender : null);
		if (e.get_OriginalSource() == val && val.get_GroupName() != "")
		{
			ApprovalList itemByGroupName = ApprovalList.getItemByGroupName(val.get_GroupName());
			itemByGroupName.IsYN = "N";
		}
	}

	[STAThread]
	private void mnuDataGridColumnCopy_Click(object sender, RoutedEventArgs e)
	{
		if (((MultiSelector)lvApproval).get_SelectedItems().Count == 0)
		{
			MsgBox("먼저 선택하세요.");
			return;
		}
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < ((MultiSelector)lvApproval).get_SelectedItems().Count; i++)
			{
				if (i != 0)
				{
					stringBuilder.Append("\r\n");
				}
				ApprovalList approvalList = ((MultiSelector)lvApproval).get_SelectedItems()[i] as ApprovalList;
				stringBuilder.Append(approvalList.Section);
			}
			Clipboard.SetText(stringBuilder.ToString());
		}
		catch (Exception ex)
		{
			Console.Error.WriteLine(ex.Message);
		}
	}

	private void btnFileSelector_Click(object sender, RoutedEventArgs e)
	{
		string ct = "";
		try
		{
			ct = Clipboard.GetText();
		}
		catch (Exception ex)
		{
			Console.Error.WriteLine(ex.Message);
		}
		ct = FindFileInExplorer(ct);
	}

	private string FindFileInExplorer(string ct)
	{
		ct = ct.Replace("\"", "");
		if (Utils.FileExists(ct))
		{
			new Random();
			string environmentVariable = Environment.GetEnvironmentVariable("tmp");
			if (environmentVariable != "" && Directory.Exists(environmentVariable))
			{
				CNativeWIN32.ShellExecute(0, "open", "explorer", "/select," + ct, null, 1);
			}
		}
		else
		{
			MsgBox("해당파일이 없습니다.");
		}
		return ct;
	}

	private void btnOptimizeReg_Click(object sender, RoutedEventArgs e)
	{
		int num = 0;
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		string[] array = RegiHelperSrc.Instance.ReadAllSection_Reg();
		for (int i = 0; i < array.Length; i++)
		{
			if (isGarbigeRegSection(array[i], dictionary))
			{
				RegiHelperSrc.Instance.RemoveSection_Reg(array[i]);
				num++;
			}
		}
		if (num == 0)
		{
			MsgBox("미승인 내역이 없습니다.");
		}
		else
		{
			MsgBox("불필요한 환경변수 " + num + "개를 지워 최적화 하였습니다.");
		}
		dictionary.Clear();
		dictionary = null;
		itmListViewApproval.Clear();
		readApprovalList(itmListViewApproval);
		lvApproval_refresh();
	}

	private bool isGarbigeRegSection(string p, Dictionary<string, string> di)
	{
		string text = RegiHelperSrc.Instance.ApprovalYN_Reg(p);
		if (text == null || text != "Y")
		{
			return true;
		}
		string[] array = p.Split(new char[1] { ',' });
		string text2 = array[1].Replace("|", SEPA);
		if (!Utils.FileExists(text2))
		{
			return true;
		}
		string text3 = "";
		if (di.ContainsKey(text2.ToLower()))
		{
			text3 = di[text2.ToLower()];
		}
		if (text3 == "")
		{
			text3 = App.FileCheckSum(text2);
			di.Add(text2.ToLower(), text3);
		}
		if (text3 != array[2])
		{
			return true;
		}
		return false;
	}

	private void btnDeleteBHO_Click(object sender, RoutedEventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I4
		if ((int)MessageBox.Show((Window)(object)this, "모든 BHO를 삭제하시겠습니까?\n복구되지 않습니다.\n대부분이 BHO는 보안에 위협적입니다.\nBHO개발자가 아니면 삭제를 권장합니다.", ((Window)this).get_Title(), (MessageBoxButton)4, (MessageBoxImage)32) != 6)
		{
			return;
		}
		RegistryKey registryKey2;
		if (Utils.Is64OS())
		{
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
			registryKey2 = registryKey.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Browser Helper Objects", RegistryKeyPermissionCheck.ReadWriteSubTree);
		}
		else
		{
			registryKey2 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Browser Helper Objects", RegistryKeyPermissionCheck.ReadWriteSubTree);
		}
		if (registryKey2 != null)
		{
			string[] subKeyNames = registryKey2.GetSubKeyNames();
			for (int i = 0; i < subKeyNames.Count(); i++)
			{
				registryKey2.DeleteSubKey(subKeyNames[i], throwOnMissingSubKey: false);
			}
		}
		if (Utils.Is64OS())
		{
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
			registryKey2 = registryKey.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Browser Helper Objects", RegistryKeyPermissionCheck.ReadWriteSubTree);
		}
		else
		{
			registryKey2 = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Browser Helper Objects", RegistryKeyPermissionCheck.ReadWriteSubTree);
		}
		if (registryKey2 != null)
		{
			string[] subKeyNames = registryKey2.GetSubKeyNames();
			for (int i = 0; i < subKeyNames.Count(); i++)
			{
				registryKey2.DeleteSubKey(subKeyNames[i], throwOnMissingSubKey: false);
			}
		}
		refreshBtnBHO_remove();
	}

	private void tabCtrl_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Invalid comparison between Unknown and I4
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		object obj = ((ItemsControl)tabCtrl).get_Items().get_Item(((Selector)tabCtrl).get_SelectedIndex());
		TabItem val = (TabItem)((obj is TabItem) ? obj : null);
		if (!(strLatestTabItemName != ((FrameworkElement)val).get_Name()))
		{
			return;
		}
		switch (((FrameworkElement)val).get_Name())
		{
		case "tabItemUtils":
			if (Utils.IsKeyBoardStateCapsLockOn())
			{
				((UIElement)btnGoGlean).set_Visibility((Visibility)0);
			}
			else if ((int)((UIElement)btnGoGlean).get_Visibility() == 0)
			{
				((UIElement)btnGoGlean).set_Visibility((Visibility)2);
			}
			refreshBtnBHO_remove();
			refreshMsSpellCheck();
			break;
		case "tabItem2":
			((UIElement)lblHelp).set_Visibility((Visibility)0);
			break;
		case "tabItemMain":
			if (txtHealthReport.get_Text().Length < 65)
			{
				((UIElement)lblHelp).set_Visibility((Visibility)0);
			}
			else
			{
				((UIElement)lblHelp).set_Visibility((Visibility)1);
			}
			break;
		case "tabItemMsra":
		{
			((UIElement)lblHelp).set_Visibility((Visibility)1);
			if (txtMailContent.get_Text().Length == 0)
			{
				string text = Utils.ExecuteCommandSync("whoami");
				text = text.Trim();
				int num = text.IndexOf("\\");
				if (-1 < num)
				{
					text = text.Substring(num + 1);
				}
				txtMailContent.set_Text("[원격요청: " + text + "]");
			}
			List<TerminalSessionData> list = TermServicesManager.ListSessions("127.0.0.1");
			if (nFirstSessionCount != list.Count)
			{
				AutoClosingMessageBox.Show("세션 수의 변동이 있습니다. " + nFirstSessionCount + "→" + list.Count, "PowerHealthChecker", 3100, 0);
			}
			nFirstSessionCount = list.Count;
			lblSessions.set_Text("세션목록 " + list.Count);
			((ItemsControl)cboSessions).get_Items().Clear();
			Application.DoEvents();
			for (int i = 0; i < list.Count; i++)
			{
				((ItemsControl)cboSessions).get_Items().Add((object)list[i].ToString());
			}
			break;
		}
		case "tabApproval":
			((UIElement)lblHelp).set_Visibility((Visibility)2);
			if (bFirstItemListViewApprovalCntZero && 0 < itmListViewApproval.Count)
			{
				MsgBox("Tip: [일괄 승인] 버튼을 클릭하시면 편리합니다.");
				bFirstItemListViewApprovalCntZero = false;
			}
			if (0 < itmListViewApproval.Count)
			{
				SortDataGrid(lvApproval, 6);
			}
			break;
		case "tabItemURLProtocol":
			((UIElement)lblHelp).set_Visibility((Visibility)1);
			if (!bInitURLProtocol)
			{
				bInitURLProtocol = true;
				readUrlProtocolList(itmListURLProtocol);
				((ItemsControl)lvURLProtocol).set_ItemsSource((IEnumerable)itmListURLProtocol);
			}
			break;
		case "tabItemAppOutBlock":
			((UIElement)lblHelp).set_Visibility((Visibility)1);
			AppOutBlockSubProc();
			RegiHelperSrc.Instance.AppApprovalColor = false;
			break;
		case "tabItemAuth":
			((UIElement)lblHelp).set_Visibility((Visibility)1);
			break;
		default:
			((UIElement)lblHelp).set_Visibility((Visibility)1);
			break;
		}
		strLatestTabItemName = ((FrameworkElement)val).get_Name();
	}

	private void AppOutBlockSubProc()
	{
		if (!bInitAppOutBlock)
		{
			bInitAppOutBlock = true;
			readAppOutBlockList(itmListAppOutBlock);
			if (((ItemsControl)lvAppOutBlock).get_ItemsSource() == null)
			{
				((ItemsControl)lvAppOutBlock).set_ItemsSource((IEnumerable)itmListAppOutBlock);
			}
		}
	}

	private void refreshMsSpellCheck()
	{
		if (isMsSpellcheckUse())
		{
			((UIElement)btnMsSpell).set_IsEnabled(true);
		}
		else
		{
			((UIElement)btnMsSpell).set_IsEnabled(false);
		}
	}

	private void refreshBtnBHO_remove()
	{
		string bHOCount = getBHOCount();
		((ContentControl)btnDeleteBHO).set_Content((object)("모든 BHO 삭제" + bHOCount));
		if (bHOCount.Length == 0)
		{
			((UIElement)lblBHO_delete_guide).set_Visibility((Visibility)2);
			((UIElement)lblBHO_delete_guide2).set_Visibility((Visibility)2);
		}
		else if (-1 < bHOCount.IndexOf("?"))
		{
			((UIElement)lblBHO_delete_guide).set_Visibility((Visibility)2);
			((UIElement)lblBHO_delete_guide2).set_Visibility((Visibility)0);
		}
		else
		{
			((UIElement)lblBHO_delete_guide).set_Visibility((Visibility)0);
			((UIElement)lblBHO_delete_guide2).set_Visibility((Visibility)2);
		}
	}

	private string getBHOCount()
	{
		int num = 0;
		string result = "";
		num = bhoCount_sub();
		if (0 < num)
		{
			result = " (" + num + ")개";
		}
		else if (num < 0)
		{
			result = " (?)개";
		}
		return result;
	}

	private int bhoCount_sub()
	{
		int num = 0;
		try
		{
			RegistryKey registryKey2;
			if (Utils.Is64OS())
			{
				RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
				registryKey2 = registryKey.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Browser Helper Objects");
			}
			else
			{
				registryKey2 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Browser Helper Objects");
			}
			if (registryKey2 != null)
			{
				num += registryKey2.GetSubKeyNames().Count();
				registryKey2.Dispose();
				registryKey2 = null;
			}
			if (Utils.Is64OS())
			{
				RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
				registryKey2 = registryKey.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Browser Helper Objects");
			}
			else
			{
				registryKey2 = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Browser Helper Objects");
			}
			if (registryKey2 != null)
			{
				num += registryKey2.GetSubKeyNames().Count();
				registryKey2.Dispose();
				registryKey2 = null;
			}
		}
		catch (Exception ex)
		{
			Console.Error.WriteLine(ex.Message);
			num = -1;
		}
		return num;
	}

	[STAThread]
	private void mnuDataGridFilePathCopy_Click(object sender, RoutedEventArgs e)
	{
		if (((MultiSelector)lvApproval).get_SelectedItems().Count == 0)
		{
			MsgBox("먼저 선택하세요.");
			return;
		}
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < ((MultiSelector)lvApproval).get_SelectedItems().Count; i++)
			{
				if (i != 0)
				{
					stringBuilder.Append("\r\n");
				}
				ApprovalList approvalList = ((MultiSelector)lvApproval).get_SelectedItems()[i] as ApprovalList;
				stringBuilder.Append(approvalList.Path.Replace("/", SEPA));
			}
			Clipboard.SetText(stringBuilder.ToString());
		}
		catch (Exception ex)
		{
			Console.Error.WriteLine(ex.Message);
		}
	}

	[STAThread]
	private void mnuDataCheckSumCopy_Click(object sender, RoutedEventArgs e)
	{
		if (((MultiSelector)lvApproval).get_SelectedItems().Count == 0)
		{
			MsgBox("먼저 선택하세요.");
			return;
		}
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < ((MultiSelector)lvApproval).get_SelectedItems().Count; i++)
			{
				if (i != 0)
				{
					stringBuilder.Append("\r\n");
				}
				ApprovalList approvalList = ((MultiSelector)lvApproval).get_SelectedItems()[i] as ApprovalList;
				stringBuilder.Append(approvalList.CheckSum);
			}
			Clipboard.SetText(stringBuilder.ToString());
		}
		catch (Exception ex)
		{
			Console.Error.WriteLine(ex.Message);
		}
	}

	private void mnuDataGridSearchFile_Click(object sender, RoutedEventArgs e)
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		if (((MultiSelector)lvApproval).get_SelectedItems().Count == 0)
		{
			MsgBox("먼저 선택하세요.");
			return;
		}
		int num = 10;
		if (10 < ((MultiSelector)lvApproval).get_SelectedItems().Count)
		{
			string text = ((MultiSelector)lvApproval).get_SelectedItems().Count + "개를 모두 여시겠습니까?\n[기본 최대 10개]";
			if ((int)MessageBox.Show(text, ((Window)this).get_Title(), (MessageBoxButton)4, (MessageBoxImage)48) == 6)
			{
				num = ((MultiSelector)lvApproval).get_SelectedItems().Count;
			}
		}
		for (int i = 0; i < ((MultiSelector)lvApproval).get_SelectedItems().Count && i < num; i++)
		{
			ApprovalList approvalList = ((MultiSelector)lvApproval).get_SelectedItems()[i] as ApprovalList;
			FindFileInExplorer(approvalList.Path.Replace("/", SEPA));
		}
	}

	private void mnuDataGridVirustotal_Click(object sender, RoutedEventArgs e)
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		if (((MultiSelector)lvApproval).get_SelectedItems().Count == 0)
		{
			MsgBox("먼저 선택하세요.");
			return;
		}
		int num = 10;
		if (10 < ((MultiSelector)lvApproval).get_SelectedItems().Count)
		{
			string text = ((MultiSelector)lvApproval).get_SelectedItems().Count + "개를 모두 여시겠습니까?\n[기본 최대 10개]";
			if ((int)MessageBox.Show(text, ((Window)this).get_Title(), (MessageBoxButton)4, (MessageBoxImage)48) == 6)
			{
				num = ((MultiSelector)lvApproval).get_SelectedItems().Count;
			}
		}
		for (int i = 0; i < ((MultiSelector)lvApproval).get_SelectedItems().Count && i < num; i++)
		{
			ApprovalList approvalList = ((MultiSelector)lvApproval).get_SelectedItems()[i] as ApprovalList;
			CNativeWIN32.ShellExecute(0, "open", "https://www.virustotal.com/file/" + approvalList.CheckSum + "/analysis/", null, null, 1);
			CNativeWIN32.Sleep(1000);
		}
	}

	private void lvApproval_ContextMenuOpening(object sender, ContextMenuEventArgs e)
	{
	}

	private void btnMsSpellDis_Click(object sender, RoutedEventArgs e)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Invalid comparison between Unknown and I4
		RegiHelperSrc.Instance.setMsSpellCheckUse(0);
		refreshMsSpellCheck();
		MsgBox("IE Spell Check가 비활성화 되었습니다.\n");
		Process[] processesByName = Process.GetProcessesByName("MsSpellCheckingFacility");
		if (processesByName.Count() == 0)
		{
			return;
		}
		string text = "IE Spell Check(MsSpellCheckingFacility.exe) 를 강제 종료하시겠습니까?";
		if ((int)MessageBox.Show(text, ((Window)this).get_Title(), (MessageBoxButton)4, (MessageBoxImage)48) == 6)
		{
			try
			{
				processesByName[0].Kill();
				text = "강제 종료하였습니다.";
				MsgBox(text);
			}
			catch (Exception ex)
			{
				MsgBox(ex.Message);
			}
		}
	}

	private void chkAutoStart_Click(object sender, RoutedEventArgs e)
	{
		if (!RegiHelperSrc.Instance.bAuth)
		{
			RegiHelperSrc.Instance.ShowTrialUseGuide();
		}
		else if (((UIElement)chkAutoStart).get_IsVisible())
		{
			if (((ToggleButton)chkAutoStart).get_IsChecked() == true)
			{
				RegiHelperSrc.Instance.CheckedWndStarted = true;
			}
			else
			{
				RegiHelperSrc.Instance.CheckedWndStarted = false;
			}
		}
	}

	public void mnuVacc4_Click(object sender, RoutedEventArgs e)
	{
		if (!RegiHelperSrc.Instance.CheckedVaccine4)
		{
			try
			{
				if (Utils.Is64OS())
				{
					RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
					registryKey.DeleteSubKeyTree("SOFTWARE\\Wow6432Node\\Microsoft\\Internet Explorer\\ProtocolExecute");
				}
				else
				{
					Registry.CurrentUser.DeleteSubKeyTree("Software\\Microsoft\\Internet Explorer\\ProtocolExecute");
				}
			}
			catch (Exception)
			{
			}
			try
			{
				if (Utils.Is64OS())
				{
					RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
					registryKey.DeleteSubKeyTree("SOFTWARE\\Wow6432Node\\Microsoft\\Internet Explorer\\ProtocolExecute");
				}
				else
				{
					Registry.LocalMachine.DeleteSubKeyTree("Software\\Microsoft\\Internet Explorer\\ProtocolExecute");
				}
			}
			catch (Exception)
			{
			}
			RegiHelperSrc.Instance.CheckedVaccine4 = true;
		}
		else
		{
			RegiHelperSrc.Instance.CheckedVaccine4 = false;
		}
	}

	public void mnuVacc5_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine5)
		{
			RegiHelperSrc.Instance.CheckedVaccine5 = false;
		}
		else
		{
			RegiHelperSrc.Instance.CheckedVaccine5 = true;
		}
	}

	public void mnuVacc6_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine6)
		{
			RegiHelperSrc.Instance.CheckedVaccine6 = false;
		}
		else
		{
			RegiHelperSrc.Instance.CheckedVaccine6 = true;
		}
	}

	public void mnuVacc7_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine7)
		{
			RegiHelperSrc.Instance.CheckedVaccine7 = false;
		}
		else
		{
			RegiHelperSrc.Instance.CheckedVaccine7 = true;
		}
	}

	public void mnuVacc8_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine8)
		{
			RegiHelperSrc.Instance.CheckedVaccine8 = false;
			Utils.alert("WindowMediaPlayer 자동업데이트 되도록 설정되었습니다. 자세한 사항은 [MediaPlayer > 메뉴 > 도구 > 옵션]에서 자동업데이트 주기를 확인하세요.", ((Window)this).get_Title());
		}
		else
		{
			Utils.alert("인터넷을 통해 바이러스가 포함된 WindowMediaPlayer가 배포되어 트로이목마 역할을 할 수 있는 취약점을 해결합니다.", ((Window)this).get_Title());
			RegiHelperSrc.Instance.CheckedVaccine8 = true;
		}
	}

	public void mnuVacc9_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine9)
		{
			RegiHelperSrc.Instance.CheckedVaccine9 = false;
			Utils.alert("널 세션 생성을 허용하였습니다. 보안 취약점이 있을 수 있습니다.", ((Window)this).get_Title());
		}
		else
		{
			Utils.alert("널 세션 생성이 차단 되었습니다.[재부팅 후 적용됩니다.]", ((Window)this).get_Title());
			RegiHelperSrc.Instance.CheckedVaccine9 = true;
		}
	}

	public void mnuVacc10_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine10)
		{
			RegiHelperSrc.Instance.CheckedVaccine10 = false;
			Utils.alert("드라이버에 의한 백그라운드 다운로드 및 설치가 가능한 보안 취약점이 있습니다.", ((Window)this).get_Title());
		}
		else
		{
			Utils.alert("드라이버에 의한 백그라운드 다운로드 및 설치 문제가 개선되었습니다. 재부팅 후 적용됩니다.", ((Window)this).get_Title());
			RegiHelperSrc.Instance.CheckedVaccine10 = true;
		}
	}

	public void mnuVacc11_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine11)
		{
			RegiHelperSrc.Instance.CheckedVaccine11 = false;
		}
		else
		{
			RegiHelperSrc.Instance.CheckedVaccine11 = true;
		}
	}

	private void mnuSecureLogon_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "netplwiz.exe", "", "", 1);
	}

	private void btnSetAllow_Click(object sender, RoutedEventArgs e)
	{
		if (Utils.FileExists(replaceNormalizePath("%windir%\\system32\\systempropertiesremote.exe")))
		{
			mnuPU11_Click(null, null);
		}
		else
		{
			CNativeWIN32.ShellExecute(0, "open", "systempropertiesadvanced.exe", "", "", 1);
		}
	}

	private void btnGoogleMailSendAllow1_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "https://g.co/allowaccess", "", "", 1);
	}

	private void btnGoogleMailSendAllow2_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "https://www.google.com/settings/security/lesssecureapps", "", "", 1);
	}

	private void mnuSecureDriverInstall_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "rundll32.exe", "newdev.dll,DeviceInternetSettingUi 3", "", 1);
	}

	private void btnRecommandURLProtocol_Click(object sender, RoutedEventArgs e)
	{
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		int num2 = 0;
		StringBuilder stringBuilder = new StringBuilder();
		((UIElement)btnRecommandURLProtocol).set_IsEnabled(false);
		foreach (KeyValuePair<string, URLProtocolList> item in URLProtocolList.globalSection)
		{
			if (item.Value.IsFileExist && item.Value.AllowY)
			{
				item.Value.AllowYN = "N";
				stringBuilder.Append(++num2 + ". [" + item.Value.ProtocolName + "] " + item.Value.StrCommand + "-> 미사용\n");
				num++;
			}
		}
		Clipboard.Clear();
		Clipboard.SetText(stringBuilder.ToString());
		if (num == 0)
		{
			AutoClosingMessageBox.Show("처리할 내역이 없습니다.", "PowerHealthChecker", 3100, 0);
		}
		else
		{
			AutoClosingMessageBox.Show("[ " + num + " ]건을 미사용으로 설정하였습니다.\n<상세 처리 내역은 클립보드에 있습니다.>", "PowerHealthChecker", 3100, 0);
		}
	}

	private void isURL_Y_Click(object sender, RoutedEventArgs e)
	{
		RadioButton val = (RadioButton)((sender is RadioButton) ? sender : null);
		if (e.get_OriginalSource() == val && val.get_GroupName() != "")
		{
			URLProtocolList itemByGroupName = URLProtocolList.getItemByGroupName(val.get_GroupName());
			itemByGroupName.AllowYN = "Y";
		}
	}

	private void isURL_N_Click(object sender, RoutedEventArgs e)
	{
		RadioButton val = (RadioButton)((sender is RadioButton) ? sender : null);
		if (e.get_OriginalSource() == val && val.get_GroupName() != "")
		{
			URLProtocolList itemByGroupName = URLProtocolList.getItemByGroupName(val.get_GroupName());
			itemByGroupName.AllowYN = "N";
		}
	}

	[STAThread]
	private void mnuAdminNoActive_Click(object sender, RoutedEventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string text = "net user administrator /active:no";
			Clipboard.SetText(text);
			MessageBox.Show(text, ((Window)this).get_Title(), (MessageBoxButton)0, (MessageBoxImage)48);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, ((Window)this).get_Title(), (MessageBoxButton)0, (MessageBoxImage)48);
		}
	}

	public void mnuVacc12_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine12)
		{
			RegiHelperSrc.Instance.CheckedVaccine12 = false;
		}
		else
		{
			RegiHelperSrc.Instance.CheckedVaccine12 = true;
		}
	}

	public void mnuVacc13_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine13)
		{
			RegiHelperSrc.Instance.CheckedVaccine13 = false;
		}
		else
		{
			RegiHelperSrc.Instance.CheckedVaccine13 = true;
		}
	}

	private void mnuWMIC_User_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", replaceNormalizePath("%windir%\\system32\\cmd.exe"), "/c echo %USERNAME% & @wmic.exe useraccount get name,disabled,sid & pause", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void btnProcessExp_Click(object sender, RoutedEventArgs e)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.UseShellExecute = true;
		string text = "";
		text = (processStartInfo.FileName = ((!Environment.Is64BitOperatingSystem) ? (Utils.AppRootPath() + "ext_lib\\procexp.exe") : (Utils.AppRootPath() + "ext_lib\\procexp64.exe")));
		if (File.Exists(text))
		{
			processStartInfo.FileName = text;
			processStartInfo.WorkingDirectory = Utils.AppRootPath() + "ext_lib";
			Process.Start(processStartInfo);
		}
		else
		{
			((UIElement)btnProcessExp).set_IsEnabled(false);
			((UIElement)imgProcExp).set_Opacity(0.3);
		}
	}

	private void btnAutoRun_Click(object sender, RoutedEventArgs e)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.UseShellExecute = true;
		string text = "";
		text = ((!Environment.Is64BitOperatingSystem) ? (Utils.AppRootPath() + "ext_lib\\Autoruns.exe") : (Utils.AppRootPath() + "ext_lib\\Autoruns64.exe"));
		if (File.Exists(text))
		{
			processStartInfo.FileName = text;
			processStartInfo.WorkingDirectory = Utils.AppRootPath() + "ext_lib";
			Process.Start(processStartInfo);
		}
		else
		{
			((UIElement)btnAutoRun).set_IsEnabled(false);
			((UIElement)imgAutoRuns).set_Opacity(0.3);
		}
	}

	private void btnGoClean_Click(object sender, RoutedEventArgs e)
	{
		bool flag = false;
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\GoClean");
		string text = "";
		if (registryKey != null)
		{
			text = registryKey.GetValue("DisplayIcon", "")!.ToString()!.Replace("\"", "");
			if (File.Exists(text))
			{
				ProcessStartInfo processStartInfo = new ProcessStartInfo();
				processStartInfo.FileName = text;
				int length = text.LastIndexOf(Utils.SEPA);
				processStartInfo.WorkingDirectory = text.SafeSubstring(0, length);
				Process.Start(processStartInfo);
				flag = true;
			}
		}
		if (!flag)
		{
			CNativeWIN32.ShellExecute(0, "open", "http://www.gobest.kr/goclean_app/index.htm", null, null, 1);
		}
	}

	private void mnuPU01_Click(object sender, RoutedEventArgs e)
	{
		((FrameworkElement)this).set_Cursor(Cursors.get_AppStarting());
		Utils.ExecuteCommandSync("SCHTASKS /Query /V >\"%temp%\\SCHTASKS.txt\"");
		((FrameworkElement)this).set_Cursor(Cursors.get_Arrow());
		CNativeWIN32.ShellExecute(0, "open", replaceNormalizePath("%temp%\\SCHTASKS.txt"), "", null, 1);
	}

	private void mnuPU02_Click(object sender, RoutedEventArgs e)
	{
		((FrameworkElement)this).set_Cursor(Cursors.get_AppStarting());
		Utils.ExecuteCommandSync("ipconfig > \"%temp%\\netstat.txt\" & netstat -ano|findstr /c:\"G\" >>\"%temp%\\netstat.txt\" & netstat -bon >>\"%temp%\\netstat.txt\" & tasklist /v >>\"%temp%\\netstat.txt\"");
		((FrameworkElement)this).set_Cursor(Cursors.get_Arrow());
		CNativeWIN32.ShellExecute(0, "open", replaceNormalizePath("%temp%\\netstat.txt"), "", null, 1);
	}

	private void mnuPU03_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "fsmgmt.msc", null, replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU04_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", replaceNormalizePath("%windir%\\system32\\rundll32.exe"), "shell32.dll,Control_RunDLL firewall.cpl", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU05_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "wf.msc", null, replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU07_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "mmc.exe", null, replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU08_Click(object sender, RoutedEventArgs e)
	{
		((FrameworkElement)this).set_Cursor(Cursors.get_AppStarting());
		CNativeWIN32.ShellExecute(0, "open", replaceNormalizePath("%windir%\\system32\\rundll32.exe"), "shell32.dll,Control_RunDLL inetcpl.cpl", replaceNormalizePath("%windir%\\system32"), 1);
		((FrameworkElement)this).set_Cursor(Cursors.get_Arrow());
	}

	private void mnuPU50_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", replaceNormalizePath("%windir%\\system32\\cleanmgr.exe"), null, replaceNormalizePath("%windir%\\system32"), 1);
	}

	public void mnuVacc14_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine14)
		{
			RegiHelperSrc.Instance.CheckedVaccine14 = false;
		}
		else
		{
			RegiHelperSrc.Instance.CheckedVaccine14 = true;
		}
	}

	public void mnuVacc15_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine15)
		{
			RegiHelperSrc.Instance.CheckedVaccine15 = false;
		}
		else
		{
			RegiHelperSrc.Instance.CheckedVaccine15 = true;
		}
	}

	public void mnuVacc16_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine16)
		{
			RegiHelperSrc.Instance.CheckedVaccine16 = false;
		}
		else
		{
			RegiHelperSrc.Instance.CheckedVaccine16 = true;
		}
	}

	public void mnuVacc17_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine17)
		{
			RegiHelperSrc.Instance.CheckedVaccine17 = false;
		}
		else
		{
			RegiHelperSrc.Instance.CheckedVaccine17 = true;
		}
	}

	private void chkAutoNetCloseStart_Click(object sender, RoutedEventArgs e)
	{
		if (((UIElement)chkAutoNetCloseStart).get_IsVisible())
		{
			if (((ToggleButton)chkAutoNetCloseStart).get_IsChecked() == true)
			{
				RegiHelperSrc.Instance.CheckedAutoNetCloseStarted = true;
			}
			else
			{
				RegiHelperSrc.Instance.CheckedAutoNetCloseStarted = false;
			}
		}
	}

	public void mnuVacc18_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine18)
		{
			RegiHelperSrc.Instance.CheckedVaccine18 = false;
		}
		else
		{
			RegiHelperSrc.Instance.CheckedVaccine18 = true;
		}
	}

	[STAThread]
	private void btnOpenHosts_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "notepad.exe", "c:\\windows\\system32\\drivers\\etc\\hosts", null, 1);
	}

	private void mnuPU09_Click(object sender, RoutedEventArgs e)
	{
		if (Utils.IsNotServerMachine())
		{
			CNativeWIN32.ShellExecute(0, "open", replaceNormalizePath("%windir%\\system32\\OptionalFeatures.exe"), null, replaceNormalizePath("%windir%\\system32"), 1);
		}
		else
		{
			CNativeWIN32.ShellExecute(0, "open", replaceNormalizePath("%windir%\\system32\\ServerManager.exe"), null, replaceNormalizePath("%windir%\\system32"), 1);
		}
	}

	public void mnuVacc19_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine19)
		{
			RegiHelperSrc.Instance.CheckedVaccine19 = false;
		}
		else
		{
			RegiHelperSrc.Instance.CheckedVaccine19 = true;
		}
		if (sender != null)
		{
			CNativeWIN32.ShellExecute(0, "open", replaceNormalizePath("%windir%\\system32\\rundll32.exe"), "shell32.dll,Control_RunDLL firewall.cpl", replaceNormalizePath("%windir%\\system32"), 1);
		}
	}

	public void mnuVacc20_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine20)
		{
			RegiHelperSrc.Instance.CheckedVaccine20 = false;
		}
		else
		{
			RegiHelperSrc.Instance.CheckedVaccine20 = true;
		}
	}

	public void mnuVacc21_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine21)
		{
			RegiHelperSrc.Instance.CheckedVaccine21 = false;
		}
		else
		{
			RegiHelperSrc.Instance.CheckedVaccine21 = true;
		}
	}

	private void mnuPU10_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "devmgmt.msc", null, replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuRundll1_Click(object sender, RoutedEventArgs e)
	{
		Utils.alert("[rundll32.exe javascript:\"\\..\\mshtml,RunHTMLApplication \";alert('foo');]를 실행하여 'foo'가 나오면 취약점이 있습니다.");
		CNativeWIN32.ShellExecute(0, "open", replaceNormalizePath("%windir%\\system32\\cmd.exe"), "/c rundll32.exe javascript:\"\\..\\mshtml,RunHTMLApplication \";alert('foo');", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuRundll2_Click(object sender, RoutedEventArgs e)
	{
		Utils.alert("'윈도우 버전 정보 창'이 나오면 취약점이 있습니다.");
		CNativeWIN32.ShellExecute(0, "open", replaceNormalizePath("%windir%\\system32\\cmd.exe"), "/c rundll32.exe javascript:\"\\..\\mshtml,RunHTMLApplication \";document.write();h=new%20ActiveXObject(\"WScript.Shell\").run(\"winver.exe\",0,true);try{h.Send();b=h.ResponseText;eval(b);}catch(e){new%20ActiveXObject(\"WScript.Shell\").Run(\"cmd /c taskkill /f /im rundll32.exe\",0,true);}", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU025_Click(object sender, RoutedEventArgs e)
	{
		Utils.ExecuteCommandSync("ipconfig > \"%temp%\\netstat2.txt\" & netstat -ano|findstr /c:G >>\"%temp%\\netstat2.txt\"");
		CNativeWIN32.ShellExecute(0, "open", replaceNormalizePath("%temp%\\netstat2.txt"), "", null, 1);
	}

	public void mnuVacc22_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine22)
		{
			RegiHelperSrc.Instance.CheckedVaccine22 = false;
			return;
		}
		int rdpPort = RegiHelperSrc.Instance.GetRdpPort();
		if (-1 < rdpPort)
		{
			RegiHelperSrc.Instance.EnableAntigen22 = false;
			string strMsg = "서버인 경우 지원되지 않는 기능입니다.";
			MessageBoxTimerClose messageBoxTimerClose = new MessageBoxTimerClose(strMsg);
			((Window)messageBoxTimerClose).ShowDialog();
			((Window)messageBoxTimerClose).Close();
		}
		else if (-1 == Utils.ExecuteCommandSync("netstat -ano").IndexOf("0.0.0.0:" + rdpPort))
		{
			RegiHelperSrc.Instance.CheckedVaccine22 = true;
		}
	}

	private void mnuPU11_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", replaceNormalizePath("%windir%\\system32\\systempropertiesremote.exe"), null, replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU11a_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", replaceNormalizePath("%windir%\\system32\\mstsc.exe"), null, replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU11b_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", replaceNormalizePath("%windir%\\system32\\iSCSI.exe"), null, replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU12_Click(object sender, RoutedEventArgs e)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo("NCPA.cpl");
		processStartInfo.UseShellExecute = true;
		Process.Start(processStartInfo);
	}

	public void mnuVacc23_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine23)
		{
			RegiHelperSrc.Instance.CheckedVaccine23 = false;
		}
		else
		{
			RegiHelperSrc.Instance.CheckedVaccine23 = true;
		}
	}

	public void mnuVacc24_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine24)
		{
			RegiHelperSrc.Instance.CheckedVaccine24 = false;
		}
		else
		{
			RegiHelperSrc.Instance.CheckedVaccine24 = true;
		}
	}

	public void mnuVacc25_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine25)
		{
			RegiHelperSrc.Instance.CheckedVaccine25 = false;
		}
		else
		{
			RegiHelperSrc.Instance.CheckedVaccine25 = true;
		}
	}

	private void btnProcessExp_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
	{
		string text = RegiHelperSrc.AppRootPath + Utils.SEPA + "ext_lib";
		if (Directory.Exists(text))
		{
			CNativeWIN32.ShellExecute(0, "open", text, null, null, 1);
		}
		else
		{
			CNativeWIN32.ShellExecute(0, "open", RegiHelperSrc.AppRootPath, null, null, 1);
		}
	}

	public void mnuVacc26_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine26)
		{
			RegiHelperSrc.Instance.CheckedVaccine26 = false;
		}
		else
		{
			RegiHelperSrc.Instance.CheckedVaccine26 = true;
		}
	}

	private void mnuMtuCheckSite_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "http://www.letmecheck.it/mtu-test.php", null, null, 1);
	}

	public void mnuVacc27_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine27)
		{
			RegiHelperSrc.Instance.CheckedVaccine27 = false;
		}
		else
		{
			RegiHelperSrc.Instance.CheckedVaccine27 = true;
		}
	}

	public void mnuVacc28_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine28)
		{
			RegiHelperSrc.Instance.CheckedVaccine28 = false;
		}
		else
		{
			RegiHelperSrc.Instance.CheckedVaccine28 = true;
		}
	}

	private void mnuPU13_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedFunction13)
		{
			RegiHelperSrc.Instance.CheckedFunction13 = false;
		}
		else
		{
			RegiHelperSrc.Instance.CheckedFunction13 = true;
		}
	}

	public void mnuVacc29_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine29)
		{
			RegiHelperSrc.Instance.CheckedVaccine29 = false;
		}
		else
		{
			RegiHelperSrc.Instance.CheckedVaccine29 = true;
		}
	}

	[STAThread]
	private void mnuServiceMng_Click(object sender, RoutedEventArgs e)
	{
		string text = Utils.ExecuteCommandSync("netstat -bon");
		string[] array = text.Replace("\n", "\r").Replace("\r\r", "\r").Split(new char[1] { '\r' });
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 1; i < array.Count(); i++)
		{
			if (-1 != array[i].IndexOf(":") || -1 != array[i].IndexOf("[") || 0 >= array[i].Trim().Length)
			{
				continue;
			}
			int num = array[i - 1].IndexOf("ESTABLISHED");
			if (-1 == num)
			{
				num = array[i - 1].IndexOf("CLOSE_WAIT");
			}
			if (-1 >= num)
			{
				continue;
			}
			int num2 = Convert.ToInt32(array[i - 1].Substring(num + 13).Trim());
			if (1024 < num2)
			{
				string text2 = array[i].Trim();
				if (-1 < text2.IndexOf(" "))
				{
					text2 = "\"" + text2 + "\"";
				}
				if (!RegiHelperSrc.dictSV.ContainsKey(text2))
				{
					RegiHelperSrc.dictSV.Add(text2, num2);
				}
			}
		}
		try
		{
			while (0 < RegiHelperSrc.dictSV.Count)
			{
				string text2 = RegiHelperSrc.dictSV.Keys.First();
				string text3 = text2;
				text3 = text3.Trim();
				if (-1 == text3.IndexOf("can not obtain", StringComparison.OrdinalIgnoreCase))
				{
					if (-1 < text3.IndexOf(" ") && !text3.StartsWith("\""))
					{
						text3 = "\"" + text3 + "\"";
					}
					serviceDemandOrDisabled(stringBuilder, text3);
					RegiHelperSrc.dictSV.Remove(text2);
				}
			}
			if (CNativeWIN32.IsWindows7() && Utils.isServiceUse("wuauserv"))
			{
				serviceDemandOrDisabled(stringBuilder, "wuauserv");
			}
			if (Utils.isServiceUse("iaLPSSi_GPIO"))
			{
				serviceDemandOrDisabled(stringBuilder, "iaLPSSi_GPIO");
			}
			if (Utils.isServiceUse("Intel PROSet Monitoring Service"))
			{
				serviceDemandOrDisabled(stringBuilder, "Intel PROSet Monitoring Service");
			}
			if (Utils.isServiceUse("LMS"))
			{
				serviceDemandOrDisabled(stringBuilder, "LMS");
			}
			if (Utils.isServiceUse("jhi_service"))
			{
				serviceDemandOrDisabled(stringBuilder, "jhi_service");
			}
			if (Utils.isServiceUse("CxUIUSvc"))
			{
				serviceDemandOrDisabled(stringBuilder, "CxUIUSvc");
			}
			if (Utils.isServiceUse("CxUtilSvc"))
			{
				serviceDemandOrDisabled(stringBuilder, "CxUtilSvc");
			}
			if (Utils.isServiceUse("SECOMNService"))
			{
				serviceDemandOrDisabled(stringBuilder, "SECOMNService");
			}
			if (Utils.isServiceUse("GoogleChromeElevationService"))
			{
				serviceDemandOrDisabled(stringBuilder, "GoogleChromeElevationService");
			}
			if (Utils.isServiceUse("SecurityHealthService"))
			{
				serviceDemandOrDisabled2(stringBuilder, "SecurityHealthService");
			}
			if (Utils.isServiceUse("SgrmBroker"))
			{
				serviceDemandOrDisabled2(stringBuilder, "SgrmBroker");
			}
			string[] taskNames = getTaskNames();
			for (int i = 0; i < taskNames.Length; i++)
			{
				ifBadTaskDisabled(stringBuilder, taskNames[i]);
			}
			string text4 = stringBuilder.ToString();
			if (0 < text4.Length)
			{
				Utils.saveToLog(text4, "ServiceMng");
				Clipboard.SetText(text4);
				txtFileName.set_Text(txtFileName.get_Text() + Environment.NewLine + "---" + Environment.NewLine + "[서비스 보안 컨설팅 적용 내용]" + Utils.Now() + Environment.NewLine + "---" + Environment.NewLine + text4 + Environment.NewLine + "---");
				Utils.alert(Environment.NewLine + "서비스 보안 컨설팅 실행 계획을 클립보드로 복사 하였습니다." + Environment.NewLine + "(클립보드로 복사한 내용은 파일체크섬 탭의 로그에 있습니다.)");
			}
			else
			{
				RegiHelperSrc.Instance.NotifyPropertyChanged("CheckedServiceSecure");
				Utils.alert("이미 서비스 보안이 적용된 상태입니다.");
			}
			mnuServiceMng.set_IsChecked(true);
		}
		catch (Exception ex)
		{
			Console.Error.WriteLine(ex.Message);
		}
	}

	private string[] getTaskNames()
	{
		List<string> list = new List<string>();
		string text = "";
		text = Utils.ExecuteCommandSync("schtasks.exe /query /FO CSV");
		string[] array = text.Replace("\n", "\r").Replace("\r\r", "\r").Split(new char[1] { '\r' });
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i].StartsWith("\"\\"))
			{
				string[] array2 = array[i].Substring(2).Split(new char[1] { '"' });
				list.Add(array2[0]);
			}
		}
		return Enumerable.ToArray(list);
	}

	private static bool isBadTask(string imgPathLowerCase)
	{
		bool flag = false;
		if (0 < imgPathLowerCase.Length)
		{
			if (arrBadTaskList == null)
			{
				arrBadTaskList = "PPTService[Connect[ConnectService[SAgent[ShowWindow[swenserver[USER_ESRV_SVC_QUEENCREEK[ceuueco*[TA-PRS Agent Schedule[SMARTPOINT[run_pcfilter[AMD Updater[MSI_Reminder[CCleaner Update[EPM Preload[CMPCUAC[WhaleUpdateL[Hewlett-Packard\\HP Support Assistant\\HP Support Solutions Framework Updater[ActiveMessenger-PrivacyGuardian[ClipDownScheduler[Hewlett-Packard\\HP Support Assistant\\HP Support Solutions Framework Report[BlockchainResearchToolsSvc[BlueStacksHelper[Driver Easy Scheduled Scan[Power Button[ATuning[SMARTBROWSER[FrontCloud[AlphaSecureZeroKeeper[gxx speed launcher[novaPDF 9 Telemetry[EPSON L220 Series Update[McInstruTrack[dhfed[Dell SupportAssistAgent AutoUpdate[Acer Collection Monitor Application[AVGPCTuneUp_Task_BkGndMaintenance[DentWebSvcCheck[McDiReg[EPSON L365 Series Update[Overwolf Updater Task[AcerCMUpdateTask2.1.16258[OC GURU II Auto Run[McAfee Remediation (Prepare)[McAfeeLogon[Dr.Capture[App Explorer[CacheCloud[HubConsole[MSI_Dragon Gaming Center[CacheConsole[Avast TUNEUP Update[HubCloud[AsGpuCheck[Avast Software\\Overseer[HMA! Pro VPN Update[HubService[Auslogics\\Disk Defrag\\Start Disk Defrag On TopGun Logon[OneDrive Standalone Update Task v2[dgeed[Hewlett-Packard\\HP Support Assistant\\WarrantyChecker[Software Update Application[Netrix Agent Task[HPCeeSchedul[RtkAudUService64_BG[SidebarExecute[ByteFence[ngplus[MSLoad[o2sch1[concache[CacheService[Wise Anti Malware Tray[fdgcb[ElrondUpdateTaskMachineCore[IdentityTheftShield_Popup3[Wise System Monitor[55f221ac-7238-4029-86b3-63d60f5d7f66-5[APO3[ASUS DIPAwayMode[ASUS Media Streamer DMR[ASUS Splendid ACMON[ASUS\\ASUS GIFTBOX[ASUS\\ASUS Product Register Service[ATK Package 36D18D69AFC3[ATK Package A22126881260[AmiUpdXp[AnToolUpdate 실행[AsrAPPShop[At1[At12[At15[At16[At20[At23[At24[At28[At4[At5[At6[At7[AutoKMSDaily[AutoPico Daily Restart[AvastUpdateTaskMachineCore[Avira\\Safe Shopping\\Update[CCAVPostInstall[CCleanerSkipUAC[CKBS FTP Server[CLVDLauncher[CleanMem Mini Monitor[CrystalDiskInfo[DAEMON Tools Lite[Dolby Selector[DropboxOEM[EOSNotify[EcoMode[Ez Update[FamilySafetyMonitor[FastDataX Task[FileCure Default[Ghost Resign Task[Gpu Boost Driver[GpuFanHelper[HP Health Check[HP Support Assistant Quick Start[HPCustParticipation[IPlusUpdate_ze[IQOptionUpdateTask[InputPersonalization[Intel PTT EK Recertification[JKIUpdateTask[Java Update Scheduler[KMSAutoNet[KeyCast[KeywordInfo[KeywordYac[LG Intelligent Update[LGUpdateCenter[LaunchPreSignup[Lenovo\\REACHit[LiveUpdate[MP Scheduled Scan[MSIGH_Host[MSISW_Host[MailRuUpdater[Malware Protection 360[McAfee DAT Built in test[Microsoft Antimalware Scheduled Scan[Microsoft_MKC_Logon_Task_ipoint.exe[MovieColorEnhancer[MpIdleTask[NAC[NCH Software\\PhotoStageSevenDays[NClient\\Logon Trigger[NI OPC Servers 2013[NIUpdateServiceCheckTask[NaverSoftware\\ToolsLog[OKSTART[One Click Privacy startups[One System Care Monitor[Opera scheduled Autoupdate 1414099808[Opera scheduled Autoupdate 4086469641[PC Health Analysis[PCDEventLauncherTask[PTPFilter[PXAVJGL[ProgramUpdateCheck[RC TweakIt Server Execute[RansomDefenderS[RealMSP[RealUpgradeLogonTaskS-1-5-21-1862212361-3175855856-119480347-500[RecoverATB[Red Giant Link[RegClean Pro_UPDATES[RegCure[RegCure Pro[Registry Optimizer[Reminders - minni[RtHDVBg_Dolby[RunAsStdUser[RunAsStdUser Task[SS2Svc64Run[STSTART[SWSTART[Samsung\\SamsungUpdate\\UserModeWorker[Searchlinenc[Sk11600Pl[Sk12968Pl[SmartShare[Sniper Antivirus_MiscSchedule[SpaceAgentTask[Start WinZip System Utilities Suite Schedule[StartCN[SystemToolsDailyTest[Task_ShellExecuteAs[TunnelBear[TurboVHelp[UMonitor Task[USB 3[UniCloud[UniConsole[Uninstall Windows Address Search Package[Uninstaller_SkipUac_Administrator[Virtual Disk Service Manager[WActivityUpdate_Win 7[WPA Host[WinExpandUpdate_s2dwm[WinPlus[Window SysCheck 실행[Windows Defender routine scan[Windows Update[Wise Care 365[Wise Turbo Checker[WizMouse[XblGameSaveTask[XblGameSaveTaskLogon[achcb[app[appuriverifierdaily[ba86e10e-7976-4f6f-8a16-6959d247e67e-3[bvsvbnmumsi[cdhj[ceuuecmlrmnms[efService 실행[eifed[ezlinkpluscfg[fggcb[fhded[gbjid[gesegssrrn[ggee[ghhj[hjdgc[idbjb[irssqsmnir[issosstthr[klcp_update[lonfg[mctcvwwvvrmain[n5tr[ntop[pfcheckmon[signtab[tesetvotv[whpcmjukxkmzevq[windd[wpmsc[wppwqowvqs[zcodec64[{0FDFBDA4-54B0-5F98-32E8-B206D47B16B1}[{63C5E022-B690-922B-2779-6D3069924A5C}[{E0477272-850C-4E8D-9C5C-A638D4800D1D}[{E733B082-6716-9D9E-415C-E6BD169A2A50}[별집업데이트 실행".Split(new char[1] { '[' });
			}
			int num = imgPathLowerCase.IndexOf("-");
			int num2 = imgPathLowerCase.LastIndexOf("-");
			if (-1 < num && -1 < num2 && num != num2)
			{
				int num3 = imgPathLowerCase.IndexOf("-", num + 1);
				if (-1 < num3 && num3 != num2)
				{
					flag = true;
				}
			}
			if (!flag)
			{
				if (imgPathLowerCase.StartsWith("microsoft\\office\\", StringComparison.OrdinalIgnoreCase))
				{
					if (-1 == imgPathLowerCase.IndexOf("office automatic updates", StringComparison.OrdinalIgnoreCase))
					{
						flag = true;
					}
				}
				else if (imgPathLowerCase.StartsWith("microsoft\\windows\\application experience\\", StringComparison.OrdinalIgnoreCase))
				{
					flag = true;
				}
			}
			if (!flag && regexp_atnum.IsMatch(imgPathLowerCase))
			{
				flag = true;
			}
			int posEndDot = -1;
			if (!flag)
			{
				for (int i = 0; i < arrBadTaskList.Count(); i++)
				{
					if (string.Compare(imgPathLowerCase, arrBadTaskList[i], StringComparison.OrdinalIgnoreCase) != 0)
					{
						if (isContainedLastDot(arrBadTaskList, i, ref posEndDot))
						{
							if (imgPathLowerCase.StartsWith(arrBadTaskList[i].Substring(0, posEndDot), StringComparison.OrdinalIgnoreCase))
							{
								flag = true;
								break;
							}
							posEndDot = -1;
						}
						continue;
					}
					flag = true;
					break;
				}
			}
		}
		return flag;
	}

	private static bool isContainedLastDot(string[] arrList, int i, ref int posEndDot)
	{
		posEndDot = arrList[i].IndexOf("*");
		return -1 < posEndDot;
	}

	private static void ifBadTaskDisabled(StringBuilder sb, string taskName)
	{
		if (!isBadTask(taskName))
		{
			return;
		}
		string text = Utils.ExecuteCommandSync("schtasks.exe /Query /XML ONE /tn \"" + taskName + "\"");
		if (-1 < text.IndexOf("<?xml"))
		{
			int num = text.LastIndexOf("<Enabled>false</Enabled>");
			int num2 = text.LastIndexOf("<Enabled>true</Enabled>");
			int num3 = text.LastIndexOf("<Hidden>");
			bool flag = false;
			if ((-1 == num || -1 < num2) && (-1 >= num2 || ((num3 - 33 < num2) ? true : false)))
			{
				sb.Append("schtasks.exe /Change /DISABLE /tn \"" + taskName + "\"\n");
				sb.Append("REM schtasks.exe /Delete /tn \"" + taskName + "\" /f\n\n");
			}
		}
	}

	private static void serviceDemandOrDisabled(StringBuilder sb, string skey_factory)
	{
		sb.Append(Environment.GetEnvironmentVariable("windir") + Utils.SEPA + "system32\\net stop \"" + skey_factory + "\"");
		sb.Append(Environment.NewLine);
		sb.Append(Environment.GetEnvironmentVariable("windir") + Utils.SEPA + "system32\\sc config \"" + skey_factory + "\" start= disabled");
		sb.Append(Environment.NewLine);
		sb.Append("REM sc config \"" + skey_factory + "\" start= demand");
		sb.Append(Environment.NewLine);
		sb.Append(Environment.NewLine);
	}

	private static void serviceDemandOrDisabled2(StringBuilder sb, string skey_factory)
	{
		sb.Append(Environment.GetEnvironmentVariable("windir") + Utils.SEPA + "system32\\net stop \"" + skey_factory + "\"");
		sb.Append(Environment.NewLine);
		sb.Append(Environment.GetEnvironmentVariable("windir") + Utils.SEPA + "system32\\sc config \"" + skey_factory + "\" start= disabled");
		sb.Append(Environment.NewLine);
		sb.Append(Environment.GetEnvironmentVariable("windir") + Utils.SEPA + "system32\\reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\" + skey_factory + "\" /v \"Start\" /t REG_DWORD /d 0x4 /f");
		sb.Append(Environment.NewLine);
		sb.Append(Environment.NewLine);
	}

	private void mnuPU14_Click(object sender, RoutedEventArgs e)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo("msconfig.exe");
		processStartInfo.UseShellExecute = true;
		Process.Start(processStartInfo);
	}

	private void mnuPU15_Click(object sender, RoutedEventArgs e)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo("taskmgr.exe");
		processStartInfo.UseShellExecute = true;
		Process.Start(processStartInfo);
	}

	public void mnuVacc30_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine30)
		{
			RegiHelperSrc.Instance.CheckedVaccine30 = false;
		}
		else
		{
			RegiHelperSrc.Instance.CheckedVaccine30 = true;
		}
	}

	public void mnuVacc31_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine31)
		{
			RegiHelperSrc.Instance.CheckedVaccine31 = false;
		}
		else
		{
			RegiHelperSrc.Instance.CheckedVaccine31 = true;
		}
	}

	public void mnuVacc0_Click(object sender, RoutedEventArgs e)
	{
		for (int i = 1; i <= 60; i++)
		{
			RegiHelperSrc.Instance.NotifyPropertyChanged("CheckedVaccine" + i);
		}
		RegiHelperSrc.Instance.NotifyPropertyChanged("StrVaccineAll");
	}

	private void mnuVaccALL_Click(object sender, RoutedEventArgs e)
	{
		RegiHelperSrc.Instance.bOnApplyAll = true;
		((FrameworkElement)Instance).set_Cursor(Cursors.get_AppStarting());
		bool vaccAllUInewed = RegiHelperSrc.Instance.VaccAllUInewed;
		RegiHelperSrc.Instance.VaccAllUInewed = false;
		if (!RegiHelperSrc.Instance.CheckedVaccine30)
		{
			mnuVacc30_Click(null, null);
		}
		if (!RegiHelperSrc.Instance.CheckedVaccine31)
		{
			mnuVacc31_Click(null, null);
		}
		if (!RegiHelperSrc.Instance.CheckedVaccine32)
		{
			mnuVacc32_Click(null, null);
		}
		if (!RegiHelperSrc.Instance.CheckedVaccine33)
		{
			mnuVacc33_Click(null, null);
		}
		if (!RegiHelperSrc.Instance.CheckedVaccine1)
		{
			mnuVacc1_Click(null, null);
		}
		if (!RegiHelperSrc.Instance.CheckedVaccine2)
		{
			mnuVacc2_Click(null, null);
		}
		if (!RegiHelperSrc.Instance.CheckedVaccine3)
		{
			mnuVacc3_Click(null, null);
		}
		if (!RegiHelperSrc.Instance.CheckedVaccine4)
		{
			mnuVacc4_Click(null, null);
		}
		if (!RegiHelperSrc.Instance.CheckedVaccine5)
		{
			mnuVacc5_Click(null, null);
		}
		if (!RegiHelperSrc.Instance.CheckedVaccine6)
		{
			mnuVacc6_Click(null, null);
		}
		if (!RegiHelperSrc.Instance.CheckedVaccine7)
		{
			mnuVacc7_Click(null, null);
		}
		if (!RegiHelperSrc.Instance.CheckedVaccine8)
		{
			mnuVacc8_Click(null, null);
		}
		if (!RegiHelperSrc.Instance.CheckedVaccine9)
		{
			mnuVacc9_Click(null, null);
		}
		if (!RegiHelperSrc.Instance.CheckedVaccine59)
		{
			mnuVacc59_Click(null, null);
		}
		if (!RegiHelperSrc.Instance.CheckedVaccine10)
		{
			mnuVacc10_Click(null, null);
		}
		if (!RegiHelperSrc.Instance.CheckedVaccine11)
		{
			mnuVacc11_Click(null, null);
		}
		if (!RegiHelperSrc.Instance.CheckedVaccine49)
		{
			mnuVacc49_Click(null, null);
		}
		if (!RegiHelperSrc.Instance.CheckedVaccine12)
		{
			mnuVacc12_Click(null, null);
		}
		if (!RegiHelperSrc.Instance.CheckedVaccine13)
		{
			mnuVacc13_Click(null, null);
		}
		if (!RegiHelperSrc.Instance.CheckedVaccine14)
		{
			mnuVacc14_Click(null, null);
		}
		if (!RegiHelperSrc.Instance.CheckedVaccine15)
		{
			mnuVacc15_Click(null, null);
		}
		if (!RegiHelperSrc.Instance.CheckedVaccine16)
		{
			mnuVacc16_Click(null, null);
		}
		if (!RegiHelperSrc.Instance.CheckedVaccine17)
		{
			mnuVacc17_Click(null, null);
		}
		if (!RegiHelperSrc.Instance.CheckedVaccine18)
		{
			mnuVacc18_Click(null, null);
		}
		if (!RegiHelperSrc.Instance.CheckedVaccine19)
		{
			mnuVacc19_Click(null, null);
		}
		if (!RegiHelperSrc.Instance.CheckedVaccine20)
		{
			mnuVacc20_Click(null, null);
		}
		if (!RegiHelperSrc.Instance.CheckedVaccine21)
		{
			mnuVacc21_Click(null, null);
		}
		if (!RegiHelperSrc.Instance.CheckedVaccine23)
		{
			mnuVacc23_Click(null, null);
		}
		if (!RegiHelperSrc.Instance.CheckedVaccine24)
		{
			mnuVacc24_Click(null, null);
		}
		if (!RegiHelperSrc.Instance.CheckedVaccine26)
		{
			mnuVacc26_Click(null, null);
		}
		if (!RegiHelperSrc.Instance.CheckedVaccine27)
		{
			mnuVacc27_Click(null, null);
		}
		if (!RegiHelperSrc.Instance.CheckedVaccine29)
		{
			mnuVacc29_Click(null, null);
		}
		if (!RegiHelperSrc.Instance.CheckedVaccine34)
		{
			mnuVacc34_Click(null, null);
		}
		if (!RegiHelperSrc.Instance.CheckedVaccine35)
		{
			mnuVacc35_Click(null, null);
		}
		if (!RegiHelperSrc.Instance.CheckedVaccine40)
		{
			mnuVacc40_Click(null, null);
		}
		if (!RegiHelperSrc.Instance.CheckedVaccine60)
		{
			mnuVacc60_Click(null, null);
		}
		if (!RegiHelperSrc.Instance.CheckedVaccine41)
		{
			mnuVacc41_Click(null, null);
		}
		if (!RegiHelperSrc.Instance.CheckedVaccine42)
		{
			mnuVacc42_Click(null, null);
		}
		if (!RegiHelperSrc.Instance.CheckedVaccine43)
		{
			mnuVacc43_Click(null, null);
		}
		if (!RegiHelperSrc.Instance.CheckedVaccine44)
		{
			mnuVacc44_Click(null, null);
		}
		if (!RegiHelperSrc.Instance.CheckedVaccine45)
		{
			mnuVacc45_Click(null, null);
		}
		if (!RegiHelperSrc.Instance.CheckedVaccine46)
		{
			mnuVacc46_Click(null, null);
		}
		if (!RegiHelperSrc.Instance.CheckedVaccine47)
		{
			mnuVacc47_Click(null, null);
		}
		if (!RegiHelperSrc.Instance.CheckedVaccine48)
		{
			mnuVacc48_Click(null, null);
		}
		if (!RegiHelperSrc.Instance.CheckedVaccine50)
		{
			mnuVacc50_Click(null, null);
		}
		if (!RegiHelperSrc.Instance.CheckedVaccine51)
		{
			mnuVacc51_Click(null, null);
		}
		if (!RegiHelperSrc.Instance.CheckedVaccine52)
		{
			mnuVacc52_Click(null, null);
		}
		if (!RegiHelperSrc.Instance.CheckedVaccine54)
		{
			mnuVacc54_Click(null, null);
		}
		if (!RegiHelperSrc.Instance.CheckedVaccine55)
		{
			mnuVacc55_Click(null, null);
		}
		if (!RegiHelperSrc.Instance.CheckedVaccine56)
		{
			mnuVacc56_Click(null, null);
		}
		if (!RegiHelperSrc.Instance.CheckedVaccine57)
		{
			mnuVacc57_Click(null, null);
		}
		if (!RegiHelperSrc.Instance.CheckedVaccine58)
		{
			mnuVacc58_Click(null, null);
		}
		RegiHelperSrc.Instance.VaccAllUInewed = vaccAllUInewed;
		((FrameworkElement)Instance).set_Cursor((Cursor)null);
		RegiHelperSrc.Instance.bOnApplyAll = false;
		RegiHelperSrc.Instance.NotifyPropertyChanged("StrVaccineAll");
	}

	public void mnuVacc32_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine32)
		{
			RegiHelperSrc.Instance.CheckedVaccine32 = false;
		}
		else
		{
			RegiHelperSrc.Instance.CheckedVaccine32 = true;
		}
	}

	public void mnuVacc33_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine33)
		{
			RegiHelperSrc.Instance.CheckedVaccine33 = false;
		}
		else
		{
			RegiHelperSrc.Instance.CheckedVaccine33 = true;
		}
	}

	private void mnuShowTrayIcon_Click(object sender, RoutedEventArgs e)
	{
		bool flag = false;
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", RegistryKeyPermissionCheck.ReadWriteSubTree);
		if (registryKey != null)
		{
			string[] valueNames = registryKey.GetValueNames();
			for (int i = 0; i < valueNames.Count(); i++)
			{
				if (valueNames[i] != "NoDriveTypeAutoRun" && valueNames[i] != "NoActiveDesktop" && valueNames[i] != "NoAddPrinter" && registryKey.GetValueKind(valueNames[i]) == RegistryValueKind.DWord && (-1 < valueNames[i].IndexOf("No", StringComparison.OrdinalIgnoreCase) || -1 < valueNames[i].IndexOf("Hide", StringComparison.OrdinalIgnoreCase)))
				{
					int num = Convert.ToInt32(registryKey.GetValue(valueNames[i], "0"));
					if (1 == num)
					{
						flag = true;
						registryKey.SetValue(valueNames[i], 0);
					}
				}
			}
		}
		if (flag)
		{
			Utils.alert("[트레이 보이기 설정 완료]" + Environment.NewLine + "탐색기 재시작 후 적용됩니다.");
		}
		else
		{
			Utils.alert("변경할 설정이 없습니다.");
		}
	}

	[STAThread]
	private void mnuSecureChuri_Click(object sender, RoutedEventArgs e)
	{
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected O, but got Unknown
		int cnt = 0;
		StringBuilder sb = new StringBuilder();
		if (!RegiHelperSrc.Instance.CheckedFunction18a)
		{
			mnuPU18a_Click(null, null);
			sb.Append(++cnt + ". [랜섬 차단]SMB Hosting 조치하였습니다." + Environment.NewLine);
		}
		if (!RegiHelperSrc.Instance.CheckedFunction18b)
		{
			mnuPU18b_Click(null, null);
			sb.Append(++cnt + ". [랜섬 차단]NBT Session 조치하였습니다." + Environment.NewLine);
		}
		if (!RegiHelperSrc.Instance.CheckedFunction18c)
		{
			mnuPU18c_Click(null, null);
			sb.Append(++cnt + ". [랜섬 차단]NBT Datagram 조치하였습니다." + Environment.NewLine);
		}
		if (!RegiHelperSrc.Instance.CheckedFunction18d)
		{
			mnuPU18d_Click(null, null);
			sb.Append(++cnt + ". [랜섬 차단]NBT Naming TCP 조치하였습니다." + Environment.NewLine);
		}
		if (!RegiHelperSrc.Instance.CheckedFunction18e)
		{
			mnuPU18e_Click(null, null);
			sb.Append(++cnt + ". [랜섬 차단]NBT Naming UDP 조치하였습니다." + Environment.NewLine);
		}
		TaskService val = new TaskService();
		try
		{
			Regex regex = new Regex("^[^$]*", RegexOptions.IgnoreCase);
			Regex regex2 = new Regex("\\-[A-Za-z0-9]+\\-", RegexOptions.IgnoreCase);
			Task[] array = null;
			try
			{
				array = val.FindAllTasks(regex, true);
				for (int i = 0; i < array.Count(); i++)
				{
					Task val2 = array[i];
					try
					{
						if (val2.get_Enabled())
						{
							string name = val2.get_Name();
							if (regex2.IsMatch(name) || -1 < name.IndexOf("{") || -1 < name.IndexOf("GoogleU", StringComparison.OrdinalIgnoreCase) || -1 < name.IndexOf("OneNote", StringComparison.OrdinalIgnoreCase) || -1 < name.IndexOf("OneDrive", StringComparison.OrdinalIgnoreCase) || -1 < name.IndexOf("Adobe", StringComparison.OrdinalIgnoreCase) || (name.Length <= 4 && name.StartsWith("A", StringComparison.OrdinalIgnoreCase)))
							{
								val2.set_Enabled(false);
								sb.Append(++cnt + ". [" + name + "](작업)을 미사용으로 조치하였습니다." + Environment.NewLine);
							}
						}
					}
					catch (Exception ex)
					{
						Console.Error.WriteLine(ex.Message);
					}
				}
			}
			catch (Exception ex2)
			{
				Console.Error.WriteLine(ex2.Message);
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		RegistryKey registryKey = null;
		if (Utils.Is64OS())
		{
			RegistryKey registryKey2 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
			try
			{
				registryKey = registryKey2.OpenSubKey("SYSTEM\\CurrentControlSet\\services");
			}
			catch (Exception ex)
			{
				Utils.alert("[ErrorPos20190107 16041]" + Environment.NewLine + ex.Message);
			}
		}
		else
		{
			try
			{
				registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\services");
			}
			catch (Exception ex)
			{
				Utils.alert("[ErrorPos20190107 16052]" + Environment.NewLine + ex.Message);
			}
		}
		Regex regex3 = new Regex("_[A-Fa-f0-9]{5,8}$", RegexOptions.IgnoreCase);
		Regex regex4 = new Regex("svchost\\.exe -k [0-9]+$", RegexOptions.IgnoreCase);
		if (registryKey != null)
		{
			string[] subKeyNames = registryKey.GetSubKeyNames();
			AddParentPart(subKeyNames.Length);
			registryKey.Close();
			registryKey.Dispose();
			registryKey = null;
			for (int i = 0; i < subKeyNames.Length; i++)
			{
				if (regex3.IsMatch(subKeyNames[i]))
				{
					if (registryKey != null)
					{
						registryKey.Close();
						registryKey.Dispose();
						registryKey = null;
					}
					if (Utils.Is64OS())
					{
						RegistryKey registryKey2 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
						try
						{
							registryKey = registryKey2.OpenSubKey("SYSTEM" + Utils.SEPA + "CurrentControlSet" + Utils.SEPA + "services" + Utils.SEPA + subKeyNames[i]);
						}
						catch (Exception ex)
						{
							Utils.alert("[ErrorPos20190107 16076]" + Environment.NewLine + ex.Message);
						}
					}
					else
					{
						try
						{
							registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM" + Utils.SEPA + "CurrentControlSet" + Utils.SEPA + "services" + Utils.SEPA + subKeyNames[i]);
						}
						catch (Exception ex)
						{
							Utils.alert("[ErrorPos20190107 16087]" + Environment.NewLine + ex.Message);
						}
					}
					if (registryKey == null)
					{
						continue;
					}
					int num = (int)registryKey.GetValue("Start", -1);
					if (num != 4)
					{
						if (-1 == subKeyNames[i].IndexOf(" "))
						{
							Utils.ExecuteCommandSync(Environment.GetEnvironmentVariable("windir") + Utils.SEPA + "system32\\sc stop " + subKeyNames[i]);
							Utils.ExecuteCommandSync(Environment.GetEnvironmentVariable("windir") + Utils.SEPA + "system32\\sc config " + subKeyNames[i] + " start= disabled");
						}
						else
						{
							Utils.ExecuteCommandSync(Environment.GetEnvironmentVariable("windir") + Utils.SEPA + "system32\\sc stop \"" + subKeyNames[i] + "\"");
							Utils.ExecuteCommandSync(Environment.GetEnvironmentVariable("windir") + Utils.SEPA + "system32\\sc config \"" + subKeyNames[i] + "\" start= disabled");
						}
						sb.Append(++cnt + ". [" + subKeyNames[i] + "](서비스)를 미사용으로 조치하였습니다.[기존: start= " + num + "]" + Environment.NewLine);
					}
					continue;
				}
				registryKey = null;
				try
				{
					registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM" + Utils.SEPA + "CurrentControlSet" + Utils.SEPA + "services" + Utils.SEPA + subKeyNames[i]);
				}
				catch (Exception ex)
				{
					Utils.alert("[ErrorPos20190107 16112]" + Environment.NewLine + ex.Message);
				}
				if (registryKey == null)
				{
					continue;
				}
				string text = registryKey.GetValue("PHS", "")!.ToString();
				if (text != "1")
				{
					string text2 = (string)registryKey.GetValue("ImagePath", "");
					if (regex4.IsMatch(text2))
					{
						int num = (int)registryKey.GetValue("Start", -1);
						disableServiceProcess(ref cnt, sb, num, subKeyNames, i);
					}
					else if (isBadService(subKeyNames[i].ToLower()) && -1 == text2.ToLower().IndexOf("svchost.exe"))
					{
						int num = (int)registryKey.GetValue("Start", -1);
						disableServiceProcess(ref cnt, sb, num, subKeyNames, i, text2);
					}
				}
				else
				{
					Utils.alert("[" + subKeyNames[i] + "] 서비스는 PHS = 1 입니다.");
				}
			}
		}
		string strDefault = "v2.10";
		strDefault = RegiHelperSrc.Instance.GetFireWallVersion(strDefault);
		string path = replaceNormalizePath("%SystemRoot%\\System32\\WindowsPowerShell\\v1.0\\powershell.exe");
		if (File.Exists(path))
		{
			bool flag = false;
			registryKey.Close();
			registryKey.Dispose();
			registryKey = null;
			try
			{
				registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\services\\SharedAccess\\Parameters\\FirewallPolicy\\FirewallRules", RegistryKeyPermissionCheck.ReadWriteSubTree);
			}
			catch (Exception ex)
			{
				Utils.alert("[ErrorPos20190107 16136]" + Environment.NewLine + ex.Message);
			}
			if (registryKey != null)
			{
				string text3 = registryKey.GetValue("{0E696030-09A9-40DF-8856-050F04FDD971}", "") as string;
				if (text3 == "")
				{
					registryKey.SetValue("{0E696030-09A9-40DF-8856-050F04FDD971}", strDefault + "|Action=Block|Active=TRUE|Dir=Out|App=%SystemRoot%\\System32\\WindowsPowerShell\\v1.0\\powershell.exe|Name=powershell out|");
					flag = true;
				}
				else if (-1 == text3.IndexOf("App=%SystemRoot%\\System32\\WindowsPowerShell\\v1.0\\powershell.exe", StringComparison.OrdinalIgnoreCase))
				{
					registryKey.SetValue("{0E696030-09A9-40DF-8856-050F04FDD971}", strDefault + "|Action=Block|Active=TRUE|Dir=Out|App=%SystemRoot%\\System32\\WindowsPowerShell\\v1.0\\powershell.exe|Name=powershell out|");
					flag = true;
				}
				else
				{
					if (-1 < text3.IndexOf("Action=Allow", StringComparison.OrdinalIgnoreCase))
					{
						text3 = text3.Replace("Action=Allow", "Action=Block");
						flag = true;
					}
					if (-1 < text3.IndexOf("Dir=In", StringComparison.OrdinalIgnoreCase))
					{
						text3 = text3.Replace("Dir=In", "Dir=Out");
						flag = true;
					}
					if (flag)
					{
						registryKey.SetValue("{0E696030-09A9-40DF-8856-050F04FDD971}", text3);
					}
				}
			}
		}
		path = replaceNormalizePath("%SystemRoot%\\SysWoW64\\WindowsPowerShell\\v1.0\\powershell.exe");
		if (File.Exists(path))
		{
			bool flag = false;
			registryKey.Close();
			registryKey.Dispose();
			registryKey = null;
			try
			{
				registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\services\\SharedAccess\\Parameters\\FirewallPolicy\\FirewallRules", RegistryKeyPermissionCheck.ReadWriteSubTree);
			}
			catch (Exception ex)
			{
				Utils.alert("[ErrorPos20190107 16180]" + Environment.NewLine + ex.Message);
			}
			if (registryKey != null)
			{
				string text3 = registryKey.GetValue("{0E696030-09A9-40DF-8856-050F04FDD972}", "") as string;
				if (text3 == "")
				{
					registryKey.SetValue("{0E696030-09A9-40DF-8856-050F04FDD972}", strDefault + "|Action=Block|Active=TRUE|Dir=Out|App=%SystemRoot%\\SysWOW64\\WindowsPowerShell\\v1.0\\powershell.exe|Name=powershell out|");
					flag = true;
				}
				else if (-1 == text3.IndexOf("App=%SystemRoot%\\SysWOW64\\WindowsPowerShell\\v1.0\\powershell.exe", StringComparison.OrdinalIgnoreCase))
				{
					registryKey.SetValue("{0E696030-09A9-40DF-8856-050F04FDD972}", strDefault + "|Action=Block|Active=TRUE|Dir=Out|App=%SystemRoot%\\SysWOW64\\WindowsPowerShell\\v1.0\\powershell.exe|Name=powershell out|");
					flag = true;
				}
				else
				{
					if (-1 < text3.IndexOf("Action=Allow", StringComparison.OrdinalIgnoreCase))
					{
						text3 = text3.Replace("Action=Allow", "Action=Block");
						flag = true;
					}
					if (-1 < text3.IndexOf("Dir=In", StringComparison.OrdinalIgnoreCase))
					{
						text3 = text3.Replace("Dir=In", "Dir=Out");
						flag = true;
					}
					if (flag)
					{
						registryKey.SetValue("{0E696030-09A9-40DF-8856-050F04FDD972}", text3);
					}
				}
			}
			if (flag)
			{
				sb.Append(++cnt + ". 보안 위협이 되는 [powershell.exe]의 웹접속 방화벽을 차단시켰습니다." + Environment.NewLine);
			}
		}
		string text4 = replaceNormalizePath("%windir%\\system32\\cscript.exe");
		if (File.Exists(text4))
		{
			string mD5string = Utils.GetMD5string(text4.ToLower() + "2**B");
			int num2 = Utils.SetFireWallOutBlock(mD5string, text4);
			if (0 < num2)
			{
				sb.Append(++cnt + ". 보안 위협이 되는 [cscript.exe]의 방화벽 Out 접속을 차단시켰습니다." + Environment.NewLine);
			}
		}
		text4 = replaceNormalizePath("%windir%\\system32\\wscript.exe");
		if (File.Exists(text4))
		{
			string mD5string = Utils.GetMD5string(text4.ToLower() + "2**B");
			int num2 = Utils.SetFireWallOutBlock(mD5string, text4);
			if (0 < num2)
			{
				sb.Append(++cnt + ". 보안 위협이 되는 [wscript.exe]의 방화벽 Out 접속을 차단시켰습니다." + Environment.NewLine);
			}
		}
		text4 = replaceNormalizePath("%windir%\\system32\\usoclient.exe");
		if (File.Exists(text4))
		{
			string mD5string = Utils.GetMD5string(text4.ToLower() + "2**B");
			int num2 = Utils.SetFireWallOutBlock(mD5string, text4);
			if (0 < num2)
			{
				sb.Append(++cnt + ". 보안 위협이 되는 [usoclient.exe]의 방화벽 Out 접속을 차단시켰습니다." + Environment.NewLine);
			}
		}
		text4 = replaceNormalizePath("%windir%\\system32\\Macromed\\Flash\\FlashUtil_ActiveX.exe");
		if (File.Exists(text4))
		{
			string mD5string = Utils.GetMD5string(text4.ToLower() + "2**B");
			int num2 = Utils.SetFireWallOutBlock(mD5string, text4);
			if (0 < num2)
			{
				sb.Append(++cnt + ". 보안 위협이 되는 [FlashUtil_ActiveX.exe]의 방화벽 Out 접속을 차단시켰습니다." + Environment.NewLine);
			}
		}
		text4 = replaceNormalizePath("%windir%\\system32\\SppExtComObj.Exe");
		if (File.Exists(text4))
		{
			string mD5string = Utils.GetMD5string(text4.ToLower() + "2**B");
			int num2 = Utils.SetFireWallOutBlock(mD5string, text4);
			if (0 < num2)
			{
				sb.Append(++cnt + ". 보안 위협이 되는 [SppExtComObj.Exe]의 방화벽 Out 접속을 차단시켰습니다." + Environment.NewLine);
			}
		}
		text4 = replaceNormalizePath("%windir%\\system32\\MpSigStub.exe");
		if (File.Exists(text4))
		{
			string mD5string = Utils.GetMD5string(text4.ToLower() + "2**B");
			int num2 = Utils.SetFireWallOutBlock(mD5string, text4);
			if (0 < num2)
			{
				sb.Append(++cnt + ". 보안 위협이 되는 [MpSigStub.exe]의 방화벽 Out 접속을 차단시켰습니다." + Environment.NewLine);
			}
		}
		text4 = replaceNormalizePath("%windir%\\system32\\dashost.exe");
		if (File.Exists(text4))
		{
			string mD5string = Utils.GetMD5string(text4.ToLower() + "2**B");
			int num2 = Utils.SetFireWallOutBlock(mD5string, text4);
			if (0 < num2)
			{
				sb.Append(++cnt + ". 보안 위협이 되는 [dashost.exe]의 방화벽 Out 접속을 차단시켰습니다." + Environment.NewLine);
			}
		}
		if (Utils.IsNotServerMachine())
		{
			text4 = replaceNormalizePath("%windir%\\system32\\svchost.exe");
			if (File.Exists(text4))
			{
				string mD5string = Utils.GetMD5string(text4.ToLower() + "1**B");
				int num2 = Utils.SetFireWallInBlock(mD5string, text4);
				if (0 < num2)
				{
					sb.Append(++cnt + ". 보안 위협이 되는 [svchost.exe]의 방화벽 In 접속을 차단시켰습니다." + Environment.NewLine);
				}
			}
		}
		text4 = replaceNormalizePath("%windir%\\system32\\lsm.exe");
		if (File.Exists(text4))
		{
			string mD5string = Utils.GetMD5string(text4.ToLower() + "1**B");
			int num2 = Utils.SetFireWallInBlock(mD5string, text4);
			if (0 < num2)
			{
				sb.Append(++cnt + ". 보안 위협이 되는 [lsm.exe]의 방화벽 In 접속을 차단시켰습니다." + Environment.NewLine);
			}
		}
		text4 = replaceNormalizePath("%windir%\\system32\\FlashPlayerApp.exe");
		if (File.Exists(text4))
		{
			string mD5string = Utils.GetMD5string(text4.ToLower() + "2**B");
			int num2 = Utils.SetFireWallOutBlock(mD5string, text4);
			if (0 < num2)
			{
				sb.Append(++cnt + ". 보안 위협이 되는 [FlashPlayerApp.exe]의 방화벽 Out 접속을 차단시켰습니다." + Environment.NewLine);
			}
		}
		text4 = replaceNormalizePath("%windir%\\SysWOW64\\FlashPlayerApp.exe");
		if (File.Exists(text4))
		{
			string mD5string = Utils.GetMD5string(text4.ToLower() + "2**B");
			int num2 = Utils.SetFireWallOutBlock(mD5string, text4);
			if (0 < num2)
			{
				sb.Append(++cnt + ". 보안 위협이 되는 [SysWOW64\\FlashPlayerApp.exe]의 방화벽 Out 접속을 차단시켰습니다." + Environment.NewLine);
			}
		}
		text4 = replaceNormalizePath("%windir%\\system32\\IFinst27.exe");
		if (File.Exists(text4))
		{
			string mD5string = Utils.GetMD5string(text4.ToLower() + "2**B");
			int num2 = Utils.SetFireWallOutBlock(mD5string, text4);
			if (0 < num2)
			{
				sb.Append(++cnt + ". 보안 위협이 되는 [IFinst27.exe]의 방화벽 Out 접속을 차단시켰습니다." + Environment.NewLine);
			}
		}
		text4 = replaceNormalizePath("%windir%\\system32\\SearchUI.exe");
		if (File.Exists(text4))
		{
			string mD5string = Utils.GetMD5string(text4.ToLower() + "2**B");
			int num2 = Utils.SetFireWallOutBlock(mD5string, text4);
			if (0 < num2)
			{
				sb.Append(++cnt + ". 보안 위협이 되는 [SearchUI.exe]의 방화벽 Out 접속을 차단시켰습니다." + Environment.NewLine);
			}
		}
		text4 = replaceNormalizePath("%windir%\\system32\\conhost.exe");
		if (File.Exists(text4))
		{
			string mD5string = Utils.GetMD5string(text4.ToLower() + "2**B");
			int num2 = Utils.SetFireWallOutBlock(mD5string, text4);
			if (0 < num2)
			{
				sb.Append(++cnt + ". 보안 위협이 되는 [conhost.exe]의 방화벽 Out 접속을 차단시켰습니다." + Environment.NewLine);
			}
		}
		if (Utils.Is64OS())
		{
			string file = "C:\\Program Files (x86)\\Naver\\NaverCommonUpdater\\1.0.0.43\\RemoveUpdater.exe";
			string silentWareName = "NaverCommonUpdater";
			ConfirmSilentWareRemove(SILENT_TYPE.file, file, silentWareName, directDel: false);
		}
		else
		{
			string file = "C:\\Program Files\\Naver\\NaverCommonUpdater\\1.0.0.43\\RemoveUpdater.exe";
			string silentWareName = "NaverCommonUpdater";
			ConfirmSilentWareRemove(SILENT_TYPE.file, file, silentWareName, directDel: false);
		}
		string file2 = Path.Combine(Environment.SystemDirectory, "CKAgent.exe");
		string silentWareName2 = "CKAgent.exe";
		ConfirmSilentWareRemove(SILENT_TYPE.file, file2, silentWareName2, directDel: true);
		ConfirmSilentWareRemove(SILENT_TYPE.hklm, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", "wizvera-delfino-pc", directDel: true);
		ConfirmSilentWareRemove(SILENT_TYPE.hklm, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", "wizvera-veraport", directDel: true);
		ConfirmSilentWareRemove(SILENT_TYPE.hkcu, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", "uTorrent", directDel: true);
		bool flag2 = false;
		string str_runValueName = "SecurityHealth";
		flag2 = BadRegRunChuri(isExistsIntelService: false, str_runValueName, ref sb);
		str_runValueName = "RPop";
		flag2 = BadRegRunChuri(flag2, str_runValueName, ref sb);
		str_runValueName = "SunJavaUpdateSched";
		if (flag2 = BadRegRunChuri(flag2, str_runValueName, ref sb))
		{
			cnt++;
		}
		PCALUA_task_disable();
		if (!RegiHelperSrc.Instance.Resolve01Checked)
		{
			mnuResolve01_Click(null, null);
			sb.Append(++cnt + ". " + strMsgInterface + Environment.NewLine);
		}
		if (!RegiHelperSrc.Instance.Resolve07Checked)
		{
			mnuResolve07_Click(null, null);
			sb.Append(++cnt + ". " + strMsgInterface + Environment.NewLine);
		}
		string text5 = sb.ToString();
		if (0 < cnt)
		{
			Utils.saveToLog(text5, "SecureChuri");
			Utils.alert(text5 + "(작업 내역은 클립보드로 복사되었습니다.)");
			mnuSecureChuri.set_IsChecked(true);
			try
			{
				Clipboard.SetText(text5);
				return;
			}
			catch (Exception ex)
			{
				Console.Error.WriteLine(ex.Message);
				return;
			}
		}
		Utils.alert("방화벽 관련하여 조치한 내용은 없습니다.");
		mnuSecureChuri.set_IsChecked(true);
	}

	private bool BadRegRunChuri(bool isExistsIntelService, string str_runValueName, ref StringBuilder sb)
	{
		if (isUserRunUse(str_runValueName))
		{
			string value = "UserRun [" + str_runValueName + "] disabled" + Environment.NewLine;
			sb.Append(value);
			Utils.userRunZisable2(str_runValueName);
			isExistsIntelService = true;
		}
		if (isAllRunUse(str_runValueName))
		{
			string value = "AllRun [" + str_runValueName + "] disabled" + Environment.NewLine;
			sb.Append(value);
			Utils.allRunZisable2(str_runValueName);
			isExistsIntelService = true;
		}
		return isExistsIntelService;
	}

	private bool isAllRunUse(string p)
	{
		return RegiHelperSrc.Instance.isAllRunUse(p);
	}

	private bool isUserRunUse(string p)
	{
		return RegiHelperSrc.Instance.isUserRunUse(p);
	}

	private static int disableServiceProcess(ref int cnt, StringBuilder sb, int iStart, string[] strRegKeys, int i, string imgPathLowercase = "")
	{
		if (0 < iStart && iStart != 4)
		{
			Utils.ExecuteCommandSync(Environment.GetEnvironmentVariable("windir") + Utils.SEPA + "system32\\sc stop " + strRegKeys[i]);
			Utils.ExecuteCommandSync(Environment.GetEnvironmentVariable("windir") + Utils.SEPA + "system32\\sc config " + strRegKeys[i] + " start= disabled");
			sb.Append(++cnt + ". [" + strRegKeys[i] + "](서비스)를 미사용으로 조치하였습니다.[기존: start= " + iStart + "]" + Environment.NewLine);
			string value = "v_service";
			string text = "v_member";
			if (-1 < imgPathLowercase.IndexOf(value))
			{
				try
				{
					Process[] processesByName = Process.GetProcessesByName(text);
					if (processesByName != null && 0 < processesByName.Count())
					{
						processesByName[0].Kill();
						sb.Append(++cnt + ". [" + text + "](프로세스)를 강제로 종료 조치하였습니다." + Environment.NewLine);
					}
				}
				catch (Exception ex)
				{
					Utils.alert(ex.Message);
				}
			}
		}
		return iStart;
	}

	private bool isBadService(string imgPathLowerCase)
	{
		bool result = false;
		if (0 < imgPathLowerCase.Length)
		{
			if (arrBadServiceList == null)
			{
				arrBadServiceList = "MFLocalService[Everything[WMPNetworkSvc[XblGameSave[TokenBroker[gupdate[gupdatem[Intel(R) Management and Security Application Local Management Service[Intel(R) Dynamic Application Loader Host Interface Service[Intel(R) TPM Provisioning Service[Intel(R) Capability Licensing Service TCP IP Interface[Net Driver HPZ12[Pml Driver HPZ12[ss_conn_service[jhi_service[GZNLSvc[iSASService[BNK_rxCert[aswProbeKey[aswbIDSAgent[llbunnyv[win atmgr[Fn service[ibtwo mgr[cplspcon[mrxsmb[HomeGroupProvider[ALMountService[ALUpdateService[AdobeARMService[mrxsmb10[WindosiVMDHCPI[stisvc[v_service[ByteFenceService[rtop[RexpertPrintService[srvwebwg[cplspcon[wmiApSrv[.Net CLR[Bonjour Service[AGMService[ALYac_RTSrv[ANSYS, Inc. License Manager[ASUSGiftBoxDekstop[AeLookupSvc[AfVpnService[Akamai[Alerter[AppHostSvc[AppReadiness[ArcGIS License Manager[AtherosSvc[AudioEndpointBuilder[AxInstSV[BASSVC[BOINC[BioStar Server[Bluetooth Media Service[BrYNSvc[CDPUserSvc_2e87c[CPService[ClipSrv[CodeMeter.exe[ComBack IR Pro Nmdeputy[ComBack6.0 IR Pro Service[ComVoySvcHost[Connectify[CrSSLService[Creative ALchemy AL1 Licensing Service[CscService[CtxSvc32[Cyberoam SSL VPN Helper[DICOMApp[DS License Server[DbSecuritySpt[DcomLaunch[DevActSvc[DevicesFlowUserSvc_2a7c0[Disc Soft Bus Service[DokanMounter[ESRV_SVC[Endpoint Protector[EpsonScanSvc[FDResPub[FVService[Flexlm Service 1[FontCache[FreeWebToon[GnPCInspectorSvc[GomHelper Update Services[Groupy[HP Support Assistant Service[HWTablet[HncUpdateService_NEO2[HomeGroupListener[HwRunS[IKeeper Update Services[IPBusEnum[Ias[Ibohonara[Image Protection[Innosvc[Intel(R) ME Service[Intel(R[IpOverUsbSvc[Jenkins[KMSEmulator[Killer Service V2[LMIGuardianSvc[LMSvc[LPlatSvc[MELCS[MEPOCS[MMCSS[MSC.Licensing_11.9[MSI_ActiveX_Service[MSMQ[MSUpdateAgentService[MapsBroker[MaximAudioService[MemoThisMonService[MicroCloudEngine[MoSo Anti-Malware Real-Time Monitor[N5Client Agent[NLViewerService[NS[NVWMI[Nalpeiron Licensing Service[Nationaldxy[Nationalfgi[Nationalhkg[Nationalhmc[Nationallmn[Nationallox[Nationalpbc[Nationalpkw[Nationalwtd[NaverComicService[NcaSvc[Nero BackItUp Scheduler 4.0[NetAccelerator[Netman[OlympusScanner[OpManager[OracleDBConsoleorcl[PAExec[PF_PService[PNRPsvc[POST[PcdrmSvc[PicaVNC[PinnacleUpdateSvc[PinpWebService[PlugPlay[Policy Agent PD Service[PowerManagerSvc[PremierOpinion[ProfSvc[RLM-GenArts[RalinkRegistryWriter[RansomDefenderS[RansomDefender[Razer Chroma SDK Server[RegAss[RelevantKnowledge[Remote View Agent[RpcSs[RtkAudioUniversalService[SDAgent[SDRSVC[SENS[SKARUTE[SLSvc[SSDPSRV[SSLPlusv2[SWUpdateService[Samsung Link Service[SamsungRecoveryService[Service KMSELDI[ServiceMt[ServiceNetMng[SessionEnv[SgrmBroker[Siemens PLM License Server[SmMgrDaemon[Smart NAC PClient State Check Service[SrvUpdater[Subsonic[Symantec AntiVirus[SysMain[SystemService[TBSecSvc[TENXW_Guard[THREADORDER[TPLSvc[TUCtlSystem[TapiSrv[TermService[TgateMonitorService[TgateSmartAgent[Themes[TlntSvr[Tomcat6[Tran_Process_Proc[UGS License Server (ugslmd)[UTSCSI[UnistoreSvc_49243a00[UserDataSvc_25aeba95[VDHost[VNC Server[VRLService[VideAceWindowsService[W32Print[WLMS[WMCLTSVC[WMDM PMSP Service[WPDBusEnum[WSService[WarpJITSvc[WbioSrvc[WebClient[WebPlayer9[WerSvc[WinHttpAutoProxySvc[Windows KonfigService[WindowsSecuService[WmRcSvr[WsAppService[WsDrvInst[XenSvc[YesfileService[Z!Stream 3.0 Service[ZenAnywhere[almservice[apmwinsrv[asComSvc[asas[aszjh[avgsvc[cdp[ceuuecrrqqmm[chromoting[clickvaccine Update Service[clsid63741[cssguard[defragsvc[dsNcService[ds_agent[eSafeSvc[eScan-eServ[f_AgentSvr[f_ncvaccincontrollor[fdPHost[gioqet[hAgentLogSvc[iaStorAfsService[igreensys[ipmpitrqvni[ixRealTimeSvc[jssvcmon[jvmpnq[jwmsvc[klvssbridge64_18.0.0[lfsvc[mcpack Update Service[mosquitto[mrmontquqrsp[mrmonzrsqrsp[napagent[netsvcs0[nvnrrssnv[ozserver[p2pimsvc[s2pmrnrpdsuc[scboot[smphost[snSession[spawner[ss_conn_service[ssrvc[svcxkcore[teclmd[tos85126[uToken[upuvnppds[uvnc_service[vToolbarUpdater15.3.0[vpnclient[w3logsvc[windows[wscsvc[wsdsvc32[wudfsvc[xbgm[xsherlock".Split(new char[1] { '[' });
			}
			for (int i = 0; i < arrBadServiceList.Count(); i++)
			{
				if (string.Compare(imgPathLowerCase, arrBadServiceList[i], StringComparison.OrdinalIgnoreCase) == 0)
				{
					result = true;
					break;
				}
			}
		}
		return result;
	}

	private void ConfirmSilentWareRemove(SILENT_TYPE silent_type, string file, string SilentWareName, bool directDel)
	{
		bool isFirst;
		switch (silent_type)
		{
		case SILENT_TYPE.file:
		{
			if (!File.Exists(file))
			{
				break;
			}
			DateTime silentWareChkDate = GetSilentWareChkDate(SilentWareName, out isFirst);
			if ((isFirst || silentWareChkDate < dateDeep) && Utils.question("사일런트웨어러 정의된 " + SilentWareName + " 를 제거하시겠습니까?"))
			{
				App.iniFile.DeleteKey_UTF8(IniFile.DEFAULT_SECTION, SilentWareName);
				if (directDel)
				{
					File.Delete(file);
				}
				else
				{
					CNativeWIN32.ShellExecute(0, "open", file, null, null, 1);
				}
			}
			break;
		}
		case SILENT_TYPE.hklm:
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(file, RegistryKeyPermissionCheck.ReadWriteSubTree);
			if (registryKey == null || !(registryKey.GetValue(SilentWareName, "")!.ToString() != ""))
			{
				break;
			}
			DateTime silentWareChkDate = GetSilentWareChkDate(SilentWareName, out isFirst);
			if ((isFirst || silentWareChkDate < dateDeep) && Utils.question("사일런트웨어로 정의된 " + SilentWareName + " 를 제거하시겠습니까?"))
			{
				App.iniFile.DeleteKey_UTF8(IniFile.DEFAULT_SECTION, SilentWareName);
				try
				{
					registryKey.DeleteValue(SilentWareName);
				}
				catch (Exception ex)
				{
					Console.Error.WriteLine(ex.Message);
				}
			}
			registryKey.Close();
			registryKey.Dispose();
			break;
		}
		case SILENT_TYPE.hkcu:
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(file, RegistryKeyPermissionCheck.ReadWriteSubTree);
			if (registryKey == null || !(registryKey.GetValue(SilentWareName, "")!.ToString() != ""))
			{
				break;
			}
			DateTime silentWareChkDate = GetSilentWareChkDate(SilentWareName, out isFirst);
			if ((isFirst || silentWareChkDate < dateDeep) && Utils.question("사일런트웨어로 정의된 " + SilentWareName + " 를 제거하시겠습니까?"))
			{
				App.iniFile.DeleteKey_UTF8(IniFile.DEFAULT_SECTION, SilentWareName);
				try
				{
					registryKey.DeleteValue(SilentWareName);
				}
				catch (Exception ex)
				{
					Console.Error.WriteLine(ex.Message);
				}
			}
			registryKey.Close();
			registryKey.Dispose();
			break;
		}
		}
	}

	private static DateTime GetSilentWareChkDate(string SilentWareName, out bool isFirst)
	{
		DateTime result = DateTime.MinValue;
		if (App.iniFile.ReadValue(SilentWareName) != "")
		{
			result = DateTime.ParseExact(App.iniFile.ReadValue(SilentWareName), "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None);
			isFirst = false;
		}
		else
		{
			App.iniFile.WriteValue_UTF8(SilentWareName, DateTime.Now.ToString("yyyyMMdd"));
			isFirst = true;
		}
		return result;
	}

	public static void VideoUI_deny()
	{
		int num = 0;
		try
		{
			string text = Utils.SepaString("C:\\Program Files\\WindowsApps");
			DirectoryInfo directoryInfo;
			DirectoryInfo[] directories;
			if (Directory.Exists(text))
			{
				Utils.Folder_secure(text, secure: true);
				directoryInfo = new DirectoryInfo(text);
				directories = directoryInfo.GetDirectories();
				for (int i = 0; i < directories.Count(); i++)
				{
					FileInfo[] array = directories[i].GetFiles("*.exe");
					for (int j = 0; j < array.Count(); j++)
					{
						string mD5string = Utils.GetMD5string(array[j].FullName + "2**B");
						num += Utils.SetFireWallOutBlock(mD5string, array[j].FullName);
					}
				}
			}
			text = Utils.SepaString("C:\\ProgramData\\Microsoft\\Windows Defender\\Platform");
			if (Directory.Exists(text))
			{
				directoryInfo = new DirectoryInfo(text);
				directories = directoryInfo.GetDirectories();
				for (int i = 0; i < directories.Count(); i++)
				{
					FileInfo[] array = directories[i].GetFiles("*.exe");
					for (int j = 0; j < array.Count(); j++)
					{
						string mD5string = Utils.GetMD5string(array[j].FullName + "2**B");
						num += Utils.SetFireWallOutBlock(mD5string, array[j].FullName);
					}
				}
			}
			text = Utils.SepaString("C:\\Windows\\SystemApp");
			if (Directory.Exists(text))
			{
				directoryInfo = new DirectoryInfo(text);
				directories = directoryInfo.GetDirectories();
				for (int i = 0; i < directories.Count(); i++)
				{
					FileInfo[] array = directories[i].GetFiles("*.exe");
					for (int j = 0; j < array.Count(); j++)
					{
						string mD5string = Utils.GetMD5string(array[j].FullName + "2**B");
						num += Utils.SetFireWallOutBlock(mD5string, array[j].FullName);
					}
				}
			}
			text = Utils.SepaString("C:\\Windows\\SystemApps");
			if (!Directory.Exists(text))
			{
				return;
			}
			directoryInfo = new DirectoryInfo(text);
			directories = directoryInfo.GetDirectories();
			for (int i = 0; i < directories.Count(); i++)
			{
				FileInfo[] array = directories[i].GetFiles("*.exe");
				for (int j = 0; j < array.Count(); j++)
				{
					string mD5string = Utils.GetMD5string(array[j].FullName + "2**B");
					num += Utils.SetFireWallOutBlock(mD5string, array[j].FullName);
				}
			}
		}
		catch (Exception ex)
		{
			string strMsg = "[Error 20190107 16691]" + ex.Message;
			MessageBoxTimerClose messageBoxTimerClose = new MessageBoxTimerClose(strMsg, 60);
			((Window)messageBoxTimerClose).ShowDialog();
			((Window)messageBoxTimerClose).Close();
		}
	}

	public void mnuVacc34_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine34)
		{
			RegiHelperSrc.Instance.CheckedVaccine34 = false;
		}
		else
		{
			RegiHelperSrc.Instance.CheckedVaccine34 = true;
		}
	}

	private void cboVolume_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (((UIElement)this).get_IsVisible())
		{
			string text = ((ContentControl)(ComboBoxItem)((ItemsControl)cboVolume).get_Items().get_Item(((Selector)cboVolume).get_SelectedIndex())).get_Content().ToString();
			int num = text.IndexOf("(");
			if (-1 < num)
			{
				text = text.Substring(0, num);
			}
			App.iniFile.WriteValue_UTF8("InitVolume", text);
			if (((ToggleButton)chkAutoNetCloseStart).get_IsChecked() == true)
			{
				RegiHelperSrc.Instance.CheckedAutoNetCloseStarted = false;
				RegiHelperSrc.Instance.CheckedAutoNetCloseStarted = true;
			}
		}
	}

	private void mnuPU16_Click(object sender, RoutedEventArgs e)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo("control.exe");
		processStartInfo.Arguments = "/name Microsoft.PowerOptions /page pageGlobalSettings";
		processStartInfo.UseShellExecute = true;
		Process.Start(processStartInfo);
	}

	private void mnuPU05A_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "control.exe", "/name Microsoft.WindowsFirewall /page PageConfigureApps", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU51_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "explorer.exe", "shell:::{05d7b0f4-2121-4eff-bf6b-ed3f69b894d9} \\SystemIcons,,0", replaceNormalizePath("%windir%"), 1);
	}

	private void mnuPU52_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "control.exe", "/NAME Microsoft.SyncCenter", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU53_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "control.exe", "/NAME Microsoft.DefaultPrograms /PAGE pageDefaultProgram", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU54_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "control.exe", "/NAME Microsoft.DefaultPrograms /PAGE pageFileAssoc", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU55_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "control.exe", "/NAME Microsoft.TabletPCSettings", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU56_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "rundll32.exe", "shell32.dll,Control_RunDLL tabletpc.cpl @0,flicks", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU57_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "DevicePairingWizard.exe", null, replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU58_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "hdwwiz.exe", null, replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU59_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "rundll32.exe", "shell32.dll,Control_RunDLL desk.cpl,,0", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU60_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "rundll32.exe", "shell32.dll,Control_RunDLL desk.cpl,,1", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU61_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "rundll32.exe", "shell32.dll,Control_RunDLL desk.cpl,,2", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU62_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "rundll32.exe", "shell32.dll,Control_RunDLL desk.cpl,,3", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU63_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "rundll32.exe", "shell32.dll,Control_RunDLL timedate.cpl,,1", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU64_Click(object sender, RoutedEventArgs e)
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", RegistryKeyPermissionCheck.ReadWriteSubTree);
		int num = -1;
		if (registryKey != null)
		{
			num = Convert.ToInt32(registryKey.GetValue("NoAddPrinter", "-1"));
			registryKey.SetValue("NoAddPrinter", 0);
			registryKey.Close();
			registryKey.Dispose();
		}
		if (RegiHelperSrc.Instance.IfSpooler4to3())
		{
			CNativeWIN32.ShellExecute(0, "open", "rundll32.exe", "shell32.dll,SHHelpShortcuts_RunDLL AddPrinter", replaceNormalizePath("%windir%\\system32"), 1);
		}
		else
		{
			Utils.alert("프린터 사용이 불가능한 설정입니다.");
		}
		if (num == 1)
		{
			Application.DoEvents();
			Application.DoEvents();
			Thread.Sleep(1000);
			registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", RegistryKeyPermissionCheck.ReadWriteSubTree);
			registryKey.SetValue("NoAddPrinter", 1);
			registryKey.Close();
			registryKey.Dispose();
		}
	}

	private void mnuPU65_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "control.exe", "color", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU66_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "control.exe", "international", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU67_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "control.exe", "admintools", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU68_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "rundll32.exe", "Shell32.dll,Control_RunDLL timedate.cpl,,0", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU69_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "control.exe", "Microsoft.AutoPlay", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU70_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "control.exe", "/NAME Microsoft.BackupAndRestoreCenter", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU71_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "control.exe", "/NAME Microsoft.BitLockerDriveEncryption", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU72_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "explorer.exe", "shell:::{ED834ED6-4B5A-4bfe-8F11-A626DCB6A921}", replaceNormalizePath("%windir%"), 1);
	}

	private void mnuPU73_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "control.exe", "/NAME Microsoft.ColorManagement", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU74_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "control.exe", "/NAME Microsoft.CredentialManager", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU75_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "control.exe", "/NAME Microsoft.DefaultPrograms", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU76_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "explorer.exe", "shell:::{ED834ED6-4B5A-4bfe-8F11-A626DCB6A921} -Microsoft.Personalization\\pageWallpaper", replaceNormalizePath("%windir%"), 1);
	}

	private void mnuPU77_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "devmgmt.msc", null, replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU78_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "rundll32.exe", "Shell32.dll,Control_RunDLL \"C:\\Windows\\System32\\access.cpl\"", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU79_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "control.exe", "/NAME Microsoft.FolderOptions", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU80_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "control.exe", "/NAME Microsoft.FileHistory", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU81_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "control.exe", "/NAME Microsoft.Fonts", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU82_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "control.exe", "/NAME Microsoft.GameControllers", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU83_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "control.exe", "/NAME Microsoft.GetPrograms", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU84_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "control.exe", "/NAME Microsoft.HomeGroup", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU85_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "control.exe", "/NAME Microsoft.IndexingOptions", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU86_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "control.exe", "/NAME Microsoft.Infrared", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU87_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "control.exe", "/NAME Microsoft.InternetOptions", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU88_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "control.exe", "/NAME Microsoft.iSCSIInitiator", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU68A_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "control.exe", "/NAME Microsoft.Language", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU68B_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "control.exe", "/NAME Microsoft.Keyboard", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU68C_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "control.exe", "/NAME Microsoft.Mouse", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU89_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "control.exe", "/NAME Microsoft.NetworkAndSharingCenter", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU90_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "control.exe", "ncpa.cpl", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU91_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "control.exe", "netsetup.cpl", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU92_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "explorer.exe", "shell:::{05d7b0f4-2121-4eff-bf6b-ed3f69b894d9}", replaceNormalizePath("%windir%"), 1);
	}

	private void mnuPU93_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "control.exe", "odbccp32.cpl", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU94_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "control.exe", "/NAME Microsoft.OfflineFiles", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU95_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "explorer.exe", "shell:::{ED834ED6-4B5A-4bfe-8F11-A626DCB6A921}", replaceNormalizePath("%windir%"), 1);
	}

	private void mnuPU96_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "control.exe", "/NAME Microsoft.PhoneAndModem", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU97_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "control.exe", "/NAME Microsoft.PowerOptions", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU98_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "control.exe", "/NAME Microsoft.ProgramsAndFeatures", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU99_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "control.exe", "/NAME Microsoft.Recovery", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU66A_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "control.exe", "/NAME Microsoft.RegionalAndLanguageOptions /PAGE /p:\"Location\"", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU101_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "control.exe", "/NAME Microsoft.RemoteAppAndDesktopConnections", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU102_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "control.exe", "/NAME Microsoft.ScannersAndCameras", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU103_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "control.exe", "/NAME Microsoft.ActionCenter", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU104_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "control.exe", "/NAME Microsoft.DefaultPrograms /PAGE pageFileAssoc", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU105_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "control.exe", "/NAME Microsoft.DefaultPrograms /PAGE pageDefaultProgram", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU106_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "control.exe", "/NAME Microsoft.Sound", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU107_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "control.exe", "/NAME Microsoft.SpeechRecognition", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU108_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "control.exe", "/NAME Microsoft.StorageSpaces", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU109_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "control.exe", "/NAME Microsoft.SyncCenter", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU110_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "control.exe", "/NAME Microsoft.System", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU111_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "control.exe", "sysdm.cpl", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU112_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "explorer.exe", "shell:::{05d7b0f4-2121-4eff-bf6b-ed3f69b894d9} \\SystemIcons,,0", replaceNormalizePath("%windir%"), 1);
	}

	private void mnuPU113_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "control.exe", "/name Microsoft.Troubleshooting", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU114_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "control.exe", "/NAME Microsoft.MobilityCenter", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU100_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "control.exe", "/NAME Microsoft.RegionalAndLanguageOptions /PAGE /p:\"Administrative\"", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU115_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "pwcreator.exe", null, replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU116_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "WorkFolders.exe", null, replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU112A_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "SystemPropertiesPerformance.exe", null, replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU112B_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "SystemPropertiesDataExecutionPrevention.exe", null, replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU117_Click(object sender, RoutedEventArgs e)
	{
		Utils.DoSolveMicAvailability();
	}

	private void mnuPU118_Click(object sender, RoutedEventArgs e)
	{
		Utils.DoSolveCamAvailability();
	}

	private void mnuPU98A_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "PresentationSettings.exe", null, replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU114A_Click(object sender, RoutedEventArgs e)
	{
		if (Utils.IsNotServerMachine())
		{
			CNativeWIN32.ShellExecute(0, "open", "OptionalFeatures.exe", null, replaceNormalizePath("%windir%\\system32"), 1);
		}
		else
		{
			CNativeWIN32.ShellExecute(0, "open", "ServerManager.exe", null, replaceNormalizePath("%windir%\\system32"), 1);
		}
	}

	private void mnuPU110A_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "SystemPropertiesAdvanced.exe", null, replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU110B_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "SystemPropertiesHardware.exe", null, replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU110C_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "SystemPropertiesComputerName.exe", null, replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU110D_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "SystemPropertiesProtection.exe", null, replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU110E_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "SystemPropertiesRemote.exe", null, replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU79A_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "rundll32.exe", "shell32.dll,Options_RunDLL 7", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU79B_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "rundll32.exe", "shell32.dll,Options_RunDLL 2", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU54A_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "rundll32.exe", "shell32.dll,Control_RunDLL appwiz.cpl,,3", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU106A_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "rundll32.exe", "shell32.dll,Control_RunDLL mmsys.cpl,,2", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU114B_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "control.exe", "/name Microsoft.WindowsDefender", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU65A_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "psr.exe", null, replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void chkAutoNetCloseStart_Checked(object sender, RoutedEventArgs e)
	{
		((UIElement)dpanVolume).set_Visibility((Visibility)0);
	}

	private void chkAutoNetCloseStart_Unchecked(object sender, RoutedEventArgs e)
	{
		((UIElement)dpanVolume).set_Visibility((Visibility)2);
	}

	private void btnFixUSB_Click(object sender, RoutedEventArgs e)
	{
		string text = "C:\\Windows\\inf\\usbstor.inf";
		string text2 = "C:\\Windows\\inf\\usbstor.pnf";
		if (File.Exists(text) && File.Exists(text2))
		{
			Utils.alert(text + Environment.NewLine + text2 + Environment.NewLine + "파일의 접근 권한을 변경하여 문제를 해결 할 수 있습니다.");
			FindFileInExplorer(text);
			return;
		}
		int uSBSTOR_Start = RegiHelperSrc.Instance.GetUSBSTOR_Start();
		if (uSBSTOR_Start == 4)
		{
			if (Utils.question("USB 저장장치 사용이 불가능한 상태입니다. 고치시겠습니까? <재시작 필요>"))
			{
				Utils.ExecuteCommandSync(Environment.GetEnvironmentVariable("windir") + Utils.SEPA + "system32\\sc config USBSTOR start= demand");
			}
		}
		else if (0 <= uSBSTOR_Start)
		{
			Utils.alert("이상 징후를 발견하지 못하였습니다." + Environment.NewLine + "재부팅했어도 USB 저장장치 인식불가 문제가 계속된 경우라면," + Environment.NewLine + " 드라이버 권한문제를 검토하세요.");
		}
		else if (uSBSTOR_Start == -100)
		{
			Utils.alert("USB 드라이버 설치가 가능하지 않습니다. " + Environment.NewLine + "드라이버를 설치하려면 USBSTOR 서비스 추가가 선행되어야 합니다." + Environment.NewLine + "관련 기술문서를 참고하세요.");
		}
		else
		{
			Utils.ExecuteCommandSync(Environment.GetEnvironmentVariable("windir") + Utils.SEPA + "system32\\sc config USBSTOR start= disabled");
		}
	}

	private void mnuShowFileExt_Click(object sender, RoutedEventArgs e)
	{
		doShowFileExt();
		((UIElement)mnuShowFileExt).set_IsEnabled(false);
		mnuShowFileExt.set_IsChecked(true);
	}

	private void mnuPU17_Click(object sender, RoutedEventArgs e)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		string text = Utils.ExecuteCommandSync("netstat -bon");
		string[] array = text.Replace("\n", "\r").Replace("\r\r", "\r").Split(new char[1] { '\r' });
		new StringBuilder();
		for (int i = 1; i < array.Count(); i++)
		{
			if (-1 != array[i].IndexOf(":") || -1 >= array[i].IndexOf("["))
			{
				continue;
			}
			int num = array[i - 1].IndexOf("ESTABLISHED");
			if (-1 == num)
			{
				num = array[i - 1].IndexOf("CLOSE_WAIT");
			}
			if (-1 >= num)
			{
				continue;
			}
			int processId = Convert.ToInt32(array[i - 1].Substring(num + 13).Trim());
			string mainModuleFilepath = Utils.GetMainModuleFilepath(processId);
			if (dictionary.ContainsKey(mainModuleFilepath.ToLower()))
			{
				continue;
			}
			string text2 = array[i].Replace("[", "").Replace("]", "").Trim();
			if (Utils.question("[" + text2 + "]" + Environment.NewLine + mainModuleFilepath + "를 방화벽에서 Out바운드 차단정책을 적용 하시겠습니까?" + Environment.NewLine + "<이 말이 무슨 말인지 모르겠으면 Yes를 누르지 마세요.>"))
			{
				if (mainModuleFilepath.ToLower() == Utils.GetCurrentProcessFileFullNameLowercase())
				{
					Utils.alert("[" + text2 + "]" + Environment.NewLine + mainModuleFilepath + "해당 파일의 방화벽 차단설정은 동일 인스턴스이므로 차단 설정 인터페이스를 지원하지 않습니다." + Environment.NewLine + "<차단 설정 실수 방지기능입니다.>");
					dictionary.Add(mainModuleFilepath.ToLower(), "");
				}
				else
				{
					string mD5string = Utils.GetMD5string(mainModuleFilepath + "2**B");
					Utils.SetFireWallOutBlock(mD5string, mainModuleFilepath);
					dictionary.Add(mainModuleFilepath.ToLower(), "");
				}
			}
			else
			{
				dictionary.Add(mainModuleFilepath.ToLower(), "");
			}
		}
		if (dictionary.Count == 0)
		{
			Utils.alert("방화벽 차단 조치할 내용이 없습니다.");
		}
		mnuPU17.set_IsChecked(true);
	}

	private void mnuPU18_Click(object sender, RoutedEventArgs e)
	{
		bool flag = false;
		string text = Utils.ExecuteCommandSync("netstat -ano");
		string[] array = text.Replace("\n", "\r").Replace("\r\r", "\r").Split(new char[1] { '\r' });
		for (int i = 1; i < array.Count(); i++)
		{
			if (Regex.IsMatch(array[i], "LISTENING\\s+4$"))
			{
				flag = true;
				break;
			}
		}
		if (flag)
		{
			if (Utils.question("Http서비스를 미사용으로 설정하시려면 도스에서 y를 누르세요."))
			{
				CNativeWIN32.ShellExecute(0, "open", "net.exe", "stop http", null, 1);
			}
		}
		else
		{
			Utils.alert("조치할 내용이 없습니다.");
		}
		RegiHelperSrc.Instance.NotifyPropertyChanged("CheckedFunction18");
	}

	private void mnuPU18a_Click(object sender, RoutedEventArgs e)
	{
		int num = 0;
		string text = "[Ransome SMB Block]TCP-445";
		num = RegiHelperSrc.GerFirewallRuleResult(text, "in", "TCP", "445");
		if (0 < num)
		{
			Utils.ExecuteCommandSync("netsh advfirewall firewall delete rule name=\"" + text + "\" dir=in");
		}
		else
		{
			Utils.ExecuteCommandSync("netsh advfirewall firewall add rule name=\"" + text + "\" dir=in action=block protocol=tcp localport=445 enable=yes");
		}
		RegiHelperSrc.Instance.NotifyPropertyChanged("CheckedFunction18a");
	}

	private void mnuPU18b_Click(object sender, RoutedEventArgs e)
	{
		string text = null;
		int num = 0;
		string text2 = "[Ransome NBT Session Block]TCP-139";
		num = RegiHelperSrc.GerFirewallRuleResult(text2, "in", "TCP", "139");
		text = ((0 >= num) ? Utils.ExecuteCommandSync("netsh advfirewall firewall add rule name=\"" + text2 + "\" dir=in action=block protocol=tcp localport=139 enable=yes") : Utils.ExecuteCommandSync("netsh advfirewall firewall delete rule name=\"" + text2 + "\" dir=in"));
		text.Replace("\n", "\r").Replace("\r\r", "\r").Split(new char[1] { '\r' });
		RegiHelperSrc.Instance.NotifyPropertyChanged("CheckedFunction18b");
	}

	private void mnuPU18c_Click(object sender, RoutedEventArgs e)
	{
		string text = null;
		int num = 0;
		string text2 = "[Ransome NBT Datagram Block]UDP-138";
		num = RegiHelperSrc.GerFirewallRuleResult(text2, "in", "UDP", "138");
		text = ((0 >= num) ? Utils.ExecuteCommandSync("netsh advfirewall firewall add rule name=\"" + text2 + "\" dir=in action=block protocol=udp localport=138 enable=yes") : Utils.ExecuteCommandSync("netsh advfirewall firewall delete rule name=\"" + text2 + "\" dir=in"));
		text.Replace("\n", "\r").Replace("\r\r", "\r").Split(new char[1] { '\r' });
		RegiHelperSrc.Instance.NotifyPropertyChanged("CheckedFunction18c");
	}

	private void mnuPU18d_Click(object sender, RoutedEventArgs e)
	{
		string text = null;
		string text2 = "[Ransome NBT Naming Block]TCP-137";
		int num = 0;
		num = RegiHelperSrc.GerFirewallRuleResult(text2, "in", "TCP", "137");
		text = ((0 >= num) ? Utils.ExecuteCommandSync("netsh advfirewall firewall add rule name=\"" + text2 + "\" dir=in action=block protocol=tcp localport=137 enable=yes") : Utils.ExecuteCommandSync("netsh advfirewall firewall delete rule name=\"" + text2 + "\" dir=in"));
		text.Replace("\n", "\r").Replace("\r\r", "\r").Split(new char[1] { '\r' });
		RegiHelperSrc.Instance.NotifyPropertyChanged("CheckedFunction18d");
	}

	private void mnuPU18e_Click(object sender, RoutedEventArgs e)
	{
		string text = null;
		int num = 0;
		num = RegiHelperSrc.GerFirewallRuleResult("[Ransome NBT Naming Block]UDP-137", "in", "UDP", "137");
		text = ((0 >= num) ? Utils.ExecuteCommandSync("netsh advfirewall firewall add rule name=\"[Ransome NBT Naming Block]UDP-137\" dir=in action=block protocol=udp localport=137 enable=yes") : Utils.ExecuteCommandSync("netsh advfirewall firewall delete rule name=\"[Ransome NBT Naming Block]UDP-137\" dir=in"));
		text.Replace("\n", "\r").Replace("\r\r", "\r").Split(new char[1] { '\r' });
		RegiHelperSrc.Instance.NotifyPropertyChanged("CheckedFunction18e");
	}

	private void mnuPU19_Click(object sender, RoutedEventArgs e)
	{
		bool flag = true;
		string text = Utils.ExecuteCommandSync("icacls C:\\WINDOWS\\servicing\\TrustedInstaller.exe");
		string[] array = text.Replace("\n", "\r").Replace("\r\r", "\r").Split(new char[1] { '\r' });
		for (int i = 0; i < array.Count(); i++)
		{
			if (-1 < array[i].IndexOf("SYSTEM:(DENY)"))
			{
				flag = false;
				break;
			}
		}
		if (flag)
		{
			if (Utils.question("리소스 보호를 실행합니다.\nsfc /scannow실행을 위해서는 체크를 해제해야 합니다."))
			{
				text = Utils.ExecuteCommandSync("TAKEOWN /F C:\\WINDOWS\\servicing\\TrustedInstaller.exe /A");
				text = Utils.ExecuteCommandSync("icacls C:\\WINDOWS\\servicing\\TrustedInstaller.exe /deny SYSTEM:(X)");
			}
		}
		else if (Utils.question("리소스 보호를 해제합니다."))
		{
			text = Utils.ExecuteCommandSync("TAKEOWN /F C:\\WINDOWS\\servicing\\TrustedInstaller.exe /A");
			text = Utils.ExecuteCommandSync("icacls C:\\WINDOWS\\servicing\\TrustedInstaller.exe /remove:d SYSTEM");
		}
		RegiHelperSrc.Instance.NotifyPropertyChanged("CheckedFunction19");
	}

	private void mnuPU20_Click(object sender, RoutedEventArgs e)
	{
		bool flag = false;
		Utils.ExecuteCommandSync(Environment.GetEnvironmentVariable("windir") + Utils.SEPA + "system32\\sc stop netprofm", showError: false);
		Utils.ExecuteCommandSync(Environment.GetEnvironmentVariable("windir") + Utils.SEPA + "system32\\sc stop NlaSvc", showError: false);
		Utils.ExecuteCommandSync(Environment.GetEnvironmentVariable("windir") + Utils.SEPA + "system32\\sc config netprofm start= disabled", showError: false);
		Utils.ExecuteCommandSync(Environment.GetEnvironmentVariable("windir") + Utils.SEPA + "system32\\sc config NlaSvc start= disabled", showError: false);
		string text = "";
		text = ((!CNativeWIN32.IsWindows7()) ? "SystemEventsBroker" : "EventLog");
		if (Utils.isServiceExists(text))
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Utils.SepaString("SYSTEM\\CurrentControlSet\\Services\\Schedule"), RegistryKeyPermissionCheck.ReadWriteSubTree);
			if (registryKey != null)
			{
				List<string> list = new List<string>();
				if (registryKey.GetValue("DependOnService") is string[] array)
				{
					for (int i = 0; i < array.Length; i++)
					{
						if (-1 == array[i].IndexOf(text, StringComparison.CurrentCultureIgnoreCase))
						{
							list.Add(array[i]);
						}
						else
						{
							flag = true;
						}
					}
				}
				if (flag)
				{
					registryKey.SetValue("DependOnService", list.ToArray());
				}
				else
				{
					list.Add(text);
					registryKey.SetValue("DependOnService", list.ToArray());
				}
				registryKey.Dispose();
				registryKey = null;
			}
		}
		RegiHelperSrc.Instance.NotifyPropertyChanged("CheckedFunction20");
	}

	public void mnuVacc35_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine35)
		{
			RegiHelperSrc.Instance.CheckedVaccine35 = false;
		}
		else
		{
			RegiHelperSrc.Instance.CheckedVaccine35 = true;
		}
	}

	private void mnuPU36_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine36)
		{
			RegiHelperSrc.Instance.CheckedVaccine36 = false;
		}
		else
		{
			RegiHelperSrc.Instance.CheckedVaccine36 = true;
		}
	}

	private void mnuPU37_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine37)
		{
			RegiHelperSrc.Instance.CheckedVaccine37 = false;
		}
		else
		{
			RegiHelperSrc.Instance.CheckedVaccine37 = true;
		}
	}

	private void mnuPU83A_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", Path.Combine(Environment.SystemDirectory, "gpedit.msc"), null, replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU38_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine38)
		{
			RegiHelperSrc.Instance.CheckedVaccine38 = false;
		}
		else
		{
			RegiHelperSrc.Instance.CheckedVaccine38 = true;
		}
	}

	private void mnuPU39_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine39)
		{
			RegiHelperSrc.Instance.CheckedVaccine39 = false;
		}
		else
		{
			RegiHelperSrc.Instance.CheckedVaccine39 = true;
		}
	}

	private void mnuPU103A_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", Path.Combine(Environment.SystemDirectory, "servermanager.msc"), null, replaceNormalizePath("%windir%\\system32"), 1);
	}

	public void mnuVacc40_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine40)
		{
			RegiHelperSrc.Instance.CheckedVaccine40 = false;
		}
		else
		{
			RegiHelperSrc.Instance.CheckedVaccine40 = true;
		}
	}

	public void mnuVacc41_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine41)
		{
			RegiHelperSrc.Instance.CheckedVaccine41 = false;
		}
		else
		{
			RegiHelperSrc.Instance.CheckedVaccine41 = true;
		}
	}

	public void mnuVacc42_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine42)
		{
			RegiHelperSrc.Instance.CheckedVaccine42 = false;
		}
		else
		{
			RegiHelperSrc.Instance.CheckedVaccine42 = true;
		}
	}

	public void mnuVacc43_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine43)
		{
			RegiHelperSrc.Instance.CheckedVaccine43 = false;
		}
		else
		{
			RegiHelperSrc.Instance.CheckedVaccine43 = true;
		}
	}

	private void mnuDataGridFireWallOutBlock_Click(object sender, RoutedEventArgs e)
	{
		if (((MultiSelector)lvApproval).get_SelectedItems().Count == 0)
		{
			MsgBox("먼저 선택하세요.");
			return;
		}
		try
		{
			string text = "";
			if (1 < ((MultiSelector)lvApproval).get_SelectedItems().Count)
			{
				MsgBox("하나만 선택하세요.");
			}
			else if (!mnuPopFirewallOBlock.get_IsChecked())
			{
				for (int i = 0; i < ((MultiSelector)lvApproval).get_SelectedItems().Count; i++)
				{
					ApprovalList approvalList = ((MultiSelector)lvApproval).get_SelectedItems()[i] as ApprovalList;
					string[] array = approvalList.Section.ToString().Split(new char[1] { ',' });
					text = array[1].Replace("|", Utils.SEPA);
				}
				string mD5string = Utils.GetMD5string(text + "2**B");
				Utils.SetFireWallOutBlock(mD5string, text);
			}
			else
			{
				for (int i = 0; i < ((MultiSelector)lvApproval).get_SelectedItems().Count; i++)
				{
					ApprovalList approvalList = ((MultiSelector)lvApproval).get_SelectedItems()[i] as ApprovalList;
					string[] array = approvalList.Section.ToString().Split(new char[1] { ',' });
					text = array[1].Replace("|", Utils.SEPA);
				}
				string mD5string = Utils.GetMD5string(text + "2**B");
				Utils.RemoveFireWallOutBlock(mD5string);
			}
		}
		catch (Exception ex)
		{
			Console.Error.WriteLine(ex.Message);
		}
	}

	private void ContextMenu_Opened(object sender, RoutedEventArgs e)
	{
		bool isChecked = false;
		try
		{
			string onlyFileName = "";
			if (1 == ((MultiSelector)lvApproval).get_SelectedItems().Count)
			{
				for (int i = 0; i < ((MultiSelector)lvApproval).get_SelectedItems().Count; i++)
				{
					ApprovalList approvalList = ((MultiSelector)lvApproval).get_SelectedItems()[i] as ApprovalList;
					string[] array = approvalList.Section.ToString().Split(new char[1] { ',' });
					onlyFileName = array[1].Replace("|", Utils.SEPA);
				}
				if (Utils.FindFireWallBlock(onlyFileName))
				{
					isChecked = true;
				}
			}
			mnuPopFirewallOBlock.set_IsChecked(isChecked);
		}
		catch (Exception ex)
		{
			Console.Error.WriteLine(ex.Message);
		}
	}

	private void mnuDataGridFileNet_Click(object sender, RoutedEventArgs e)
	{
		try
		{
			string text = "";
			if (1 == ((MultiSelector)lvApproval).get_SelectedItems().Count)
			{
				for (int i = 0; i < ((MultiSelector)lvApproval).get_SelectedItems().Count; i++)
				{
					ApprovalList approvalList = ((MultiSelector)lvApproval).get_SelectedItems()[i] as ApprovalList;
					string[] array = approvalList.Section.ToString().Split(new char[1] { ',' });
					text = array[1].Replace("|", Utils.SEPA).ToLower();
				}
				if (-1 < text.LastIndexOf(".exe"))
				{
					CNativeWIN32.ShellExecute(0, "open", "https://www.file.net/process/" + text + ".html", null, null, 1);
				}
				else
				{
					CNativeWIN32.ShellExecute(0, "open", "https://www.file.net/search.html?q=site:file.net+process+" + text.Replace('.', '+'), null, null, 1);
				}
			}
		}
		catch (Exception ex)
		{
			Console.Error.WriteLine(ex.Message);
		}
	}

	public void mnuVacc44_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine44)
		{
			RegiHelperSrc.Instance.CheckedVaccine44 = false;
		}
		else
		{
			RegiHelperSrc.Instance.CheckedVaccine44 = true;
		}
	}

	public void mnuVacc45_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine45)
		{
			RegiHelperSrc.Instance.CheckedVaccine45 = false;
		}
		else
		{
			RegiHelperSrc.Instance.CheckedVaccine45 = true;
		}
	}

	public void mnuVacc46_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine46)
		{
			RegiHelperSrc.Instance.CheckedVaccine46 = false;
		}
		else
		{
			RegiHelperSrc.Instance.CheckedVaccine46 = true;
		}
	}

	private void btnFileOutBound_Click(object sender, RoutedEventArgs e)
	{
		string text = "";
		try
		{
			text = Clipboard.GetText();
		}
		catch (Exception ex)
		{
			Console.Error.WriteLine(ex.Message);
		}
		string mD5string = Utils.GetMD5string(text.ToLower() + "2**B");
		Utils.SetFireWallOutBlock(mD5string, text);
	}

	private void btnEverything_Click(object sender, RoutedEventArgs e)
	{
		bool flag = false;
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\Everything");
		string text = "";
		if (registryKey != null)
		{
			text = registryKey.GetValue("DisplayIcon", "")!.ToString()!.Replace("\"", "");
			if (File.Exists(text))
			{
				ProcessStartInfo processStartInfo = new ProcessStartInfo();
				processStartInfo.FileName = text;
				int length = text.LastIndexOf(Utils.SEPA);
				processStartInfo.WorkingDirectory = text.SafeSubstring(0, length);
				Process.Start(processStartInfo);
				flag = true;
			}
		}
		if (!flag)
		{
			CNativeWIN32.ShellExecute(0, "open", "http://www.voidtools.com", null, null, 1);
		}
	}

	public void mnuVacc47_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine47)
		{
			RegiHelperSrc.Instance.CheckedVaccine47 = false;
		}
		else
		{
			RegiHelperSrc.Instance.CheckedVaccine47 = true;
		}
	}

	public void mnuVacc48_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine48)
		{
			RegiHelperSrc.Instance.CheckedVaccine48 = false;
		}
		else
		{
			RegiHelperSrc.Instance.CheckedVaccine48 = true;
		}
	}

	public void mnuVacc49_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine49)
		{
			RegiHelperSrc.Instance.CheckedVaccine49 = false;
		}
		else
		{
			RegiHelperSrc.Instance.CheckedVaccine49 = true;
		}
	}

	public void mnuVacc50_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine50)
		{
			RegiHelperSrc.Instance.CheckedVaccine50 = false;
		}
		else
		{
			RegiHelperSrc.Instance.CheckedVaccine50 = true;
		}
	}

	public void mnuVacc51_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine51)
		{
			RegiHelperSrc.Instance.CheckedVaccine51 = false;
		}
		else
		{
			RegiHelperSrc.Instance.CheckedVaccine51 = true;
		}
	}

	public void mnuVacc52_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine52)
		{
			RegiHelperSrc.Instance.CheckedVaccine52 = false;
		}
		else
		{
			RegiHelperSrc.Instance.CheckedVaccine52 = true;
		}
	}

	private void btnUninstall_Click(object sender, RoutedEventArgs e)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.UseShellExecute = true;
		string text = "";
		text = (processStartInfo.FileName = Utils.AppRootPath() + "ext_lib\\MicrosoftProgram_Install_and_Uninstall.meta.diagcab");
		if (File.Exists(text))
		{
			processStartInfo.FileName = text;
			processStartInfo.WorkingDirectory = Utils.AppRootPath() + "ext_lib";
			Process.Start(processStartInfo);
		}
		else
		{
			((UIElement)btnUninstall).set_IsEnabled(false);
		}
	}

	private void MenuItemHelp_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "https://docs.microsoft.com/ko-kr/windows-server/administration/windows-commands/windows-commands", null, null, 1);
	}

	private void btnNowVolume_Click(object sender, RoutedEventArgs e)
	{
		int num = 0;
		num = CNativeWIN32.GetVolume();
		if (-1 < num)
		{
			((Selector)cboVolumeNow).set_SelectedIndex(CNativeWIN32.GetVolume());
			bool? flag = CNativeWIN32.IsMute();
			if (flag.HasValue)
			{
				if (flag.Value)
				{
					((Control)btnMuteSign).set_Foreground((Brush)(object)Brushes.get_Red());
					((ContentControl)btnMuteSign).set_Content((object)"≠");
				}
				else
				{
					((Control)btnMuteSign).set_Foreground((Brush)(object)Brushes.get_Blue());
					((ContentControl)btnMuteSign).set_Content((object)"◀))");
				}
			}
			else
			{
				((ContentControl)btnMuteSign).set_Content((object)"?");
			}
			((UIElement)volumeSlider).set_Visibility((Visibility)0);
			((RangeBase)volumeSlider).set_Value((double)num);
			((FrameworkElement)volumeSlider).set_ToolTip((object)num);
			if (((Selector)cboVolumeTo).get_SelectedIndex() == -1)
			{
				((Selector)cboVolumeTo).set_SelectedIndex(0);
			}
			if (((Selector)cboVolumeDuration).get_SelectedIndex() == -1)
			{
				((Selector)cboVolumeDuration).set_SelectedIndex(20);
			}
			if (((Selector)cboVolumeSet3).get_SelectedIndex() == -1)
			{
				((Selector)cboVolumeSet3).set_SelectedIndex(num);
			}
		}
		else
		{
			string text = "사운드 장치가 없습니다.";
			MessageBoxTimerClose messageBoxTimerClose = new MessageBoxTimerClose("[" + Process.GetCurrentProcess().ProcessName + "] " + text);
			((Window)messageBoxTimerClose).ShowDialog();
			((Window)messageBoxTimerClose).Close();
		}
	}

	private void btnMuteSign_Click(object sender, RoutedEventArgs e)
	{
		bool? flag = CNativeWIN32.IsMute();
		if (flag.HasValue)
		{
			if (flag.Value)
			{
				CNativeWIN32.SetMute(bMute: false);
			}
			else
			{
				CNativeWIN32.SetMute(bMute: true);
			}
			btnNowVolume_Click(sender, e);
		}
	}

	private void btnVolumeStoryboard_Click(object sender, RoutedEventArgs e)
	{
		((Control)lblVolState).set_Foreground((Brush)(object)Brushes.get_Black());
		int volume = CNativeWIN32.GetVolume();
		if (-1 >= volume)
		{
			return;
		}
		btnNowVolume.PerformClick();
		Application.DoEvents();
		((Selector)cboVolumeNow).set_SelectedIndex(volume);
		int num = volume;
		int num2 = ((Selector)cboVolumeTo).get_SelectedIndex();
		if (num == -1)
		{
			num = 0;
		}
		if (num2 == -1)
		{
			num2 = 0;
		}
		if (num2 == num)
		{
			((ContentControl)lblVolState).set_Content((object)(volume + " (0초)"));
			return;
		}
		int num3 = ((Selector)cboVolumeDuration).get_SelectedIndex();
		if (num3 < 0)
		{
			num3 = 0;
		}
		num3 *= 1000;
		if (btnVolumeStoryboard_started)
		{
			btnVolumeStoryboard_started = false;
			btnVolumeStoryboard_stop = true;
			((ContentControl)btnVolumeStoryboard).set_Content((object)"실행");
			return;
		}
		((ContentControl)btnVolumeStoryboard).set_Content((object)"멈춤");
		btnVolumeStoryboard_stop = false;
		btnVolumeStoryboard_started = true;
		long num4 = CNativeWIN32.CurrentTimeMillis();
		long durDur_dur_chk_ = num4 + 100L;
		long num5 = num4 + num3;
		double durDur_delta_time_unit_volume = Convert.ToInt32((double)(num5 - num4) / (double)(num2 - num));
		double durDur_dur_chk_delta = num4;
		AutoResetEvent state = new AutoResetEvent(initialState: false);
		if (tmrToVolumeExec != null)
		{
			tmrToVolumeExec.Dispose();
			tmrToVolumeExec = null;
			((ContentControl)btnVolumeStoryboard).set_Content((object)"실행");
			btnVolumeStoryboard_stop = true;
			return;
		}
		tmrToVolumeExec = new Timer(subTimerProc, state, 100, 100);
		((ContentControl)btnVolumeStoryboard).set_Content((object)"멈춤");
		btnVolumeStoryboard_stop = false;
		DurDur_vol = volume;
		DurDur_dur1 = num4;
		DurDur_dur2 = num5;
		DurDur_dur_chk_100 = durDur_dur_chk_;
		DurDur_dur_chk_delta = durDur_dur_chk_delta;
		DurDur_delta_time_unit_volume = durDur_delta_time_unit_volume;
		DurDur_vol_to = num2;
	}

	internal void subTimerProc(object objtx)
	{
		Action action = delegate
		{
			DurDur_dur1 = CNativeWIN32.CurrentTimeMillis();
			if (DurDur_dur_chk_100 < DurDur_dur1)
			{
				if (DurDur_dur_chk_delta <= (double)DurDur_dur_chk_100)
				{
					DurDur_vol = CNativeWIN32.GetVolume();
					if (0.0 < DurDur_delta_time_unit_volume)
					{
						DurDur_dur_chk_delta += DurDur_delta_time_unit_volume;
						if (DurDur_vol < 99 && DurDur_vol != DurDur_vol_to)
						{
							CNativeWIN32.SetVolume(++DurDur_vol);
							((RangeBase)volumeSlider).set_Value((double)DurDur_vol);
							((FrameworkElement)volumeSlider).set_ToolTip((object)DurDur_vol);
						}
					}
					else
					{
						DurDur_dur_chk_delta -= DurDur_delta_time_unit_volume;
						if (0 < DurDur_vol && DurDur_vol != DurDur_vol_to)
						{
							CNativeWIN32.SetVolume(--DurDur_vol);
							((RangeBase)volumeSlider).set_Value((double)DurDur_vol);
							((FrameworkElement)volumeSlider).set_ToolTip((object)DurDur_vol);
						}
					}
				}
				DurDur_dur_chk_100 += 100L;
				((ContentControl)lblVolState).set_Content((object)(DurDur_vol + " (" + Convert.ToDouble((DurDur_dur2 - DurDur_dur1) / 100L) / 10.0 + "초)"));
			}
			if (DurDur_dur2 <= DurDur_dur1)
			{
				btnVolumeStoryboard_started = false;
				btnVolumeStoryboard_stop = true;
				((ContentControl)btnVolumeStoryboard).set_Content((object)"실행");
				DurDur_vol = CNativeWIN32.GetVolume();
				if (DurDur_vol != DurDur_vol_to)
				{
					((ContentControl)lblVolState).set_Content((object)(DurDur_vol_to + " (" + Convert.ToDouble((DurDur_dur2 - DurDur_dur1) / 100L) / 10.0 + "초)"));
					CNativeWIN32.SetVolume(DurDur_vol_to);
					((RangeBase)volumeSlider).set_Value((double)DurDur_vol_to);
					((FrameworkElement)volumeSlider).set_ToolTip((object)DurDur_vol_to);
				}
				else
				{
					((ContentControl)lblVolState).set_Content((object)(DurDur_vol + " (" + Convert.ToDouble((DurDur_dur2 - DurDur_dur1) / 100L) / 10.0 + "초)"));
				}
			}
			if (tmrToVolumeExec != null && btnVolumeStoryboard_stop)
			{
				tmrToVolumeExec.Dispose();
				tmrToVolumeExec = null;
				btnVolumeStoryboard_stop = true;
				btnVolumeStoryboard_started = false;
				((ContentControl)btnVolumeStoryboard).set_Content((object)"실행");
			}
		};
		((DispatcherObject)this).get_Dispatcher().Invoke((Delegate)action, new object[0]);
	}

	private void btnVolToPresent_Click(object sender, RoutedEventArgs e)
	{
		int selectedIndex = ((Selector)cboVolumeNow).get_SelectedIndex();
		if (selectedIndex != -1)
		{
			CNativeWIN32.SetVolume(selectedIndex);
			((ContentControl)lblVolState).set_Content((object)selectedIndex);
			((Control)lblVolState).set_Foreground((Brush)(object)Brushes.get_Blue());
			((RangeBase)volumeSlider).set_Value((double)selectedIndex);
			((FrameworkElement)volumeSlider).set_ToolTip((object)selectedIndex);
		}
	}

	private void btnVolumeSet1_Click(object sender, RoutedEventArgs e)
	{
		int selectedIndex = ((Selector)cboVolumeSet1).get_SelectedIndex();
		if (selectedIndex != -1)
		{
			CNativeWIN32.SetVolume(selectedIndex);
			((ContentControl)lblVolState).set_Content((object)selectedIndex);
			((Control)lblVolState).set_Foreground((Brush)(object)Brushes.get_Blue());
			((RangeBase)volumeSlider).set_Value((double)selectedIndex);
			((FrameworkElement)volumeSlider).set_ToolTip((object)selectedIndex);
		}
	}

	private void btnVolumeSet2_Click(object sender, RoutedEventArgs e)
	{
		int selectedIndex = ((Selector)cboVolumeSet2).get_SelectedIndex();
		if (selectedIndex != -1)
		{
			CNativeWIN32.SetVolume(selectedIndex);
			((ContentControl)lblVolState).set_Content((object)selectedIndex);
			((Control)lblVolState).set_Foreground((Brush)(object)Brushes.get_Blue());
			((RangeBase)volumeSlider).set_Value((double)selectedIndex);
			((FrameworkElement)volumeSlider).set_ToolTip((object)selectedIndex);
		}
	}

	private void btnVolumeSet3_Click(object sender, RoutedEventArgs e)
	{
		int selectedIndex = ((Selector)cboVolumeSet3).get_SelectedIndex();
		if (selectedIndex != -1)
		{
			CNativeWIN32.SetVolume(selectedIndex);
			((ContentControl)lblVolState).set_Content((object)selectedIndex);
			((Control)lblVolState).set_Foreground((Brush)(object)Brushes.get_Blue());
			((RangeBase)volumeSlider).set_Value((double)selectedIndex);
			((FrameworkElement)volumeSlider).set_ToolTip((object)selectedIndex);
		}
	}

	private void MenuMSERTDown_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "https://docs.microsoft.com/ko-kr/windows/security/threat-protection/intelligence/safety-scanner-download", null, null, 1);
	}

	public void mnuVacc53_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine53)
		{
			RegiHelperSrc.Instance.CheckedVaccine53 = false;
		}
		else
		{
			RegiHelperSrc.Instance.CheckedVaccine53 = true;
		}
	}

	private void MenuNetwrokMonitoringDown_Click(object sender, RoutedEventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Invalid comparison between Unknown and I4
		if ((int)Keyboard.get_Modifiers() == 2)
		{
			CNativeWIN32.ShellExecute(0, "open", "https://blog.naver.com/iq_up/222086452103", null, null, 1);
		}
		else
		{
			CNativeWIN32.ShellExecute(0, "open", "http://serial.powerpen.co.kr/download/NM34_x86.exe", null, null, 1);
		}
	}

	private void mnuDism_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", replaceNormalizePath("%windir%\\system32\\cmd.exe"), "/c Dism /online /cleanup-image /restorehealth", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU07_1_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "netplwiz.exe", null, replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU21_Click(object sender, RoutedEventArgs e)
	{
		Utils.ExecuteCommandSync("tasklist /V /FO CSV >\"%temp%\\TASKLIST.txt\"");
		((FrameworkElement)this).set_Cursor(Cursors.get_Arrow());
		CNativeWIN32.ShellExecute(0, "open", replaceNormalizePath("%temp%\\TASKLIST.txt"), "", null, 1);
	}

	private void mnuPU22_Click(object sender, RoutedEventArgs e)
	{
		string text = Interaction.InputBox("<pid | -p <processname(tlist.exe)>>", ((Window)this).get_Title(), "", -1, -1);
		if (0 >= text.Length)
		{
			return;
		}
		string text2 = replaceNormalizePath("%temp%");
		string text3 = App.Environment_AppFolder + "\\ext_lib\\tlist.exe";
		if (!File.Exists(text3))
		{
			return;
		}
		if (!Directory.Exists(text2))
		{
			Directory.CreateDirectory(text2);
		}
		if (File.Exists(text2 + "\\_TLIST.txt"))
		{
			File.Delete(text2 + "\\_TLIST.txt");
			Thread.Sleep(1000);
			Application.DoEvents();
		}
		string text4 = Utils.ExecuteCommandSync(text3 + " " + text + " >\"" + text2 + "\\_TLIST.txt\"");
		((FrameworkElement)this).set_Cursor(Cursors.get_Arrow());
		((ContentControl)btnHealthCheck).set_Content((object)"--5-- ");
		Thread.Sleep(1000);
		Application.DoEvents();
		((ContentControl)btnHealthCheck).set_Content((object)"--4-- ");
		Thread.Sleep(1000);
		Application.DoEvents();
		((ContentControl)btnHealthCheck).set_Content((object)"--3-- ");
		Thread.Sleep(1000);
		Application.DoEvents();
		((ContentControl)btnHealthCheck).set_Content((object)"--2-- ");
		Thread.Sleep(1000);
		Application.DoEvents();
		((ContentControl)btnHealthCheck).set_Content((object)"--1-- ");
		Thread.Sleep(1000);
		Application.DoEvents();
		string text5 = "";
		if (File.Exists(text2 + "\\_TLIST.txt"))
		{
			text5 = File.ReadAllText(replaceNormalizePath(text2 + "\\_TLIST.txt"));
		}
		if (text5.Trim().Length < 10)
		{
			text5 = text4;
		}
		if (text5.Trim().Length < 10)
		{
			text2 = "c:\\windows\\temp";
			if (!Directory.Exists(text2))
			{
				Directory.CreateDirectory(text2);
			}
			if (File.Exists(text2 + "\\_TLIST.txt"))
			{
				File.Delete(text2 + "\\_TLIST.txt");
				Thread.Sleep(1000);
				Application.DoEvents();
			}
			CNativeWIN32.ShellExecute(0, "open", "cmd.exe", "/k \"" + text3 + "\" " + text + " >\"" + text2 + "\\_TLIST.txt\"", replaceNormalizePath("%windir%") + "\\system32", 0);
			((ContentControl)btnHealthCheck).set_Content((object)"--5-- ");
			Thread.Sleep(1000);
			Application.DoEvents();
			((ContentControl)btnHealthCheck).set_Content((object)"--4-- ");
			Thread.Sleep(1000);
			Application.DoEvents();
			((ContentControl)btnHealthCheck).set_Content((object)"--3-- ");
			Thread.Sleep(1000);
			Application.DoEvents();
			((ContentControl)btnHealthCheck).set_Content((object)"--2-- ");
			Thread.Sleep(1000);
			Application.DoEvents();
			((ContentControl)btnHealthCheck).set_Content((object)"--1-- ");
			Thread.Sleep(1000);
			Application.DoEvents();
			if (File.Exists(text2 + "\\_TLIST.txt"))
			{
				text5 = File.ReadAllText(replaceNormalizePath(text2 + "\\_TLIST.txt"));
			}
		}
		int num = 0;
		while (text5.Trim().Length < 10 && num < 3)
		{
			try
			{
				string text6 = "\"" + text3 + "\" " + text + " >\"" + text2 + "\\_TLIST" + num + ".txt\"";
				if (Utils.question(text6))
				{
					Clipboard.SetText(text6);
				}
				else
				{
					CNativeWIN32.ShellExecute(0, "open", "echo " + text6 + "&&pause", "", SYS32, 1);
				}
			}
			catch (Exception ex)
			{
				Console.Error.WriteLine(ex.Message);
			}
			Utils.alert("[" + num + " / 2] Make NoLog Error. please Make file tlist PID Result into the [" + text2 + "] _TLIST[0|1].txt file.\n클립보드를 확인하여 붙여넣으세요.", ((Window)this).get_Title());
			if (File.Exists(text2 + "\\_TLIST" + num + ".txt"))
			{
				text5 = File.ReadAllText(replaceNormalizePath(text2 + "\\_TLIST" + num + ".txt"));
			}
			num++;
		}
		if (text5.Trim().Length < 10)
		{
			Utils.alert("File Blaked Error! [" + text2 + "]", ((Window)this).get_Title());
			return;
		}
		char[] separator = new char[2] { '\r', '\n' };
		string[] array = text5.Split(separator);
		bool flag = false;
		bool flag2 = false;
		string value = "CmdLine:";
		string value2 = "NumberOfThreads:";
		string text7 = text2 + Utils.SEPA + text + "_potable";
		((FrameworkElement)this).set_Cursor(Cursors.get_AppStarting());
		Application.DoEvents();
		string content = ((ContentControl)btnHealthCheck).get_Content().ToString();
		for (int i = 0; i < array.Length; i++)
		{
			((HeaderedItemsControl)mnuSleepMilisec).set_Header((object)("[" + (i + 1) + "/" + array.Length + "]"));
			if (i % 10 == 0)
			{
				Application.DoEvents();
				if (i % 20 == 0)
				{
					((ContentControl)btnHealthCheck).set_Content((object)"◐◐◐ ");
				}
				else
				{
					((ContentControl)btnHealthCheck).set_Content((object)" ◑◑◑");
				}
			}
			Application.DoEvents();
			if (!flag)
			{
				if (-1 < array[i].IndexOf(value))
				{
					flag = true;
				}
				continue;
			}
			if (!flag2)
			{
				if (-1 < array[i].IndexOf(value2))
				{
					flag2 = true;
				}
				continue;
			}
			int num2 = array[i].IndexOf(":" + Utils.SEPA);
			if (-1 < num2)
			{
				string text8 = array[i].Substring(num2 - 1);
				string text9 = text8.Replace(":" + Utils.SEPA, Utils.SEPA);
				Utils.ExecuteCommandSync("echo f|xcopy /y /s /a /h /c \"" + text8 + "\" \"" + text7 + Utils.SEPA + text9 + "\"");
			}
		}
		((ContentControl)btnHealthCheck).set_Content((object)content);
		((FrameworkElement)this).set_Cursor(Cursors.get_Arrow());
		Utils.ExecuteCommandSync("explorer /select,\"" + text7 + "\"");
		((ContentControl)btnHealthCheck).set_Content((object)"건강 진단");
		((HeaderedItemsControl)mnuSleepMilisec).set_Header((object)"");
	}

	private void mnuPU24_Click(object sender, RoutedEventArgs e)
	{
		string text = Interaction.InputBox("강제 종료를 원하시는 4글자 이상의 PID를 입력하세요.\n3글자프로세스인경우 6글자를 입력하세요(앞 3글자가 유효합니다.)", ((Window)this).get_Title(), "", -1, -1);
		if (3 < text.Length || 6 == text.Length)
		{
			string text2;
			if (text.Length == 6)
			{
				text2 = text.Substring(0, 3);
				if (Convert.ToInt32(text2) < 100)
				{
					Utils.alert("pid is small = " + text2, ((Window)this).get_Title());
					return;
				}
			}
			else
			{
				text2 = text;
				if (Convert.ToInt32(text2) < 1000)
				{
					Utils.alert("pid is small = " + text2, ((Window)this).get_Title());
					return;
				}
			}
			CNativeWIN32.ShellExecute(0, "open", "cmd.exe", "/k wmic process where processid=" + text2 + " call terminate", replaceNormalizePath("%windir%") + "\\system32", 0);
		}
		else
		{
			Utils.alert("pid is small = " + text, ((Window)this).get_Title());
		}
	}

	private void mnuPU23_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "dxdiag", "", null, 1);
	}

	private void mnuUseHash_Click(object sender, RoutedEventArgs e)
	{
		((UIElement)mnuUseHashCalc).set_IsEnabled(false);
		Application.DoEvents();
		if (!mnuUseHashCalc.get_IsChecked())
		{
			if (App.AddHashCalcMenu(2))
			{
				mnuUseHashCalc.set_IsChecked(true);
			}
			else if (App.IsAdministrator())
			{
				Utils.alert("파일이 없습니다. HashCalculator.exe");
			}
			else
			{
				Utils.alert("관리자 권한이 아닙니다.");
			}
		}
		else
		{
			App.RemoveHashCalcRegMenu();
			mnuUseHashCalc.set_IsChecked(false);
		}
		((UIElement)mnuUseHashCalc).set_IsEnabled(true);
	}

	private void mnuUAC_chk_Click(object sender, RoutedEventArgs e)
	{
		((UIElement)mnuUAC_chk).set_IsEnabled(false);
		Application.DoEvents();
		if (!mnuUAC_chk.get_IsChecked())
		{
			if (DoUacChkAutoStartCheck(2))
			{
				mnuUAC_chk.set_IsChecked(true);
			}
		}
		else
		{
			mnuUAC_chk.set_IsChecked(false);
			App.RemoveUacChkAutoStartCheck();
		}
		((UIElement)mnuUAC_chk).set_IsEnabled(true);
	}

	private bool DoUacChkAutoStartCheck(int get_set)
	{
		bool result = false;
		string environmentVariable = Environment.GetEnvironmentVariable("windir");
		string text = environmentVariable + "\\system32\\cmd.exe /d /k \"(reg query HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System /v PromptOnSecureDesktop|find /c /off \"0x0\"&&UserAccountControlSettings.exe&&exit)||exit\"&&exit";
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", RegistryKeyPermissionCheck.ReadWriteSubTree);
		if (registryKey == null)
		{
			registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
		}
		if (registryKey != null)
		{
			string text2 = null;
			if (get_set == 2)
			{
				registryKey.SetValue("UacChkPHGEN", text);
				text2 = text;
			}
			else
			{
				text2 = registryKey.GetValue("UacChkPHGEN") as string;
			}
			if (text2 != null)
			{
				if (get_set == 3)
				{
					registryKey.DeleteValue("UacChkPHGEN");
					result = true;
				}
				else if (text.ToLower() == text2.ToLower())
				{
					result = true;
				}
			}
		}
		return result;
	}

	private void mnuUseDos_Click(object sender, RoutedEventArgs e)
	{
	}

	private void DoUseDos(int p)
	{
		throw new NotImplementedException();
	}

	public void mnuVacc54_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine54)
		{
			RegiHelperSrc.Instance.CheckedVaccine54 = false;
		}
		else
		{
			RegiHelperSrc.Instance.CheckedVaccine54 = true;
		}
	}

	private void mnuComPowerPsolve_Click(object sender, RoutedEventArgs e)
	{
	}

	public void mnuVacc55_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine55)
		{
			RegiHelperSrc.Instance.CheckedVaccine55 = false;
		}
		else
		{
			RegiHelperSrc.Instance.CheckedVaccine55 = true;
		}
	}

	public void mnuVacc56_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine56)
		{
			RegiHelperSrc.Instance.CheckedVaccine56 = false;
		}
		else
		{
			RegiHelperSrc.Instance.CheckedVaccine56 = true;
		}
	}

	public void mnuVacc57_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine57)
		{
			RegiHelperSrc.Instance.CheckedVaccine57 = false;
		}
		else
		{
			RegiHelperSrc.Instance.CheckedVaccine57 = true;
		}
	}

	public void mnuVacc58_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine58)
		{
			RegiHelperSrc.Instance.CheckedVaccine58 = false;
		}
		else
		{
			RegiHelperSrc.Instance.CheckedVaccine58 = true;
		}
	}

	private void mnuRecovoryInit_Click(object sender, RoutedEventArgs e)
	{
		bool flag;
		if (flag = Utils.ExplorerExecuteSecurity("vssadmin.exe", 0))
		{
			Utils.ExplorerExecuteSecurity("vssadmin.exe", 2);
		}
		if (Utils.question("모든 시스템 복원지점을 삭제하시겠습니까? \n이후에 나오는 도스창에서 Y를 눌러 삭제 진행합니다.\n[실행: vssadmin.exe delete shadows /all]"))
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.UseShellExecute = true;
			processStartInfo.Arguments = "delete shadows /all";
			processStartInfo.FileName = SYS32 + Utils.SEPA + "vssadmin.exe";
			_ = SYS32;
			processStartInfo.WorkingDirectory = SYS32;
			processStartInfo.Verb = "runas";
			try
			{
				Process process = Process.Start(processStartInfo);
				process.WaitForExit();
				Utils.alert("시스템 복원지점을 모두 삭제하였습니다.");
			}
			catch (Exception ex)
			{
				Utils.alert(ex.Message + "\n" + processStartInfo.FileName + " " + processStartInfo.Arguments);
			}
		}
		if (flag)
		{
			Utils.ExplorerExecuteSecurity("vssadmin.exe", 1);
		}
	}

	private void mnuRecovorySettings_Click(object sender, RoutedEventArgs e)
	{
		string sYS = SYS32;
		if (Utils.question("시스템 드라이브는 [" + sYS.Substring(0, 2) + "]입니다.\nsystempropertiesprotection.exe 를 실행합니다."))
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.UseShellExecute = true;
			processStartInfo.FileName = SYS32 + Utils.SEPA + "systempropertiesprotection.exe";
			_ = SYS32;
			processStartInfo.WorkingDirectory = SYS32;
			processStartInfo.Verb = "runas";
			Process.Start(processStartInfo);
		}
	}

	private void mnuRecovoryJob_Click(object sender, RoutedEventArgs e)
	{
		string text = null;
		int num = 0;
		if (CNativeWIN32.IsWindows7())
		{
			text = "rundll32.exe /d srrstr.dll,ExecuteScheduledSPPCreation 를 실행하여 예약합니다.\n복원지점이 안만들어질 수 있기 때문에, 지체없이 만들기를 원하지면 No를 클릭하세요.";
			num = 1;
		}
		else if (Utils.FileExists("c:\\windows\\system32\\srtasks.exe"))
		{
			text = "srtasks.exe ExecuteScheduledSPPCreation 를 실행하여 예약합니다.\n복원지점이 안만들어질 수 있기 때문에, 지체없이 만들기를 원하지면 No를 클릭하세요.";
			num = 2;
		}
		else
		{
			text = "systempropertiesadvanced.exe 를 실행합니다. [시스템 보호]탭에서 [만들기]버튼을 클릭하세요.";
			num = 3;
		}
		if (num != 3 && Utils.question("복원지점을 만들기를 스케줄링합니다.\n" + text))
		{
			t1 = CNativeWIN32.GetTickCount64();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.UseShellExecute = true;
			if (CNativeWIN32.IsWindows7())
			{
				processStartInfo.FileName = SYS32 + Utils.SEPA + "rundll32.exe";
				processStartInfo.Arguments = "/d srrstr.dll,ExecuteScheduledSPPCreation";
			}
			else if (Utils.FileExists("c:\\windows\\system32\\srtasks.exe"))
			{
				processStartInfo.FileName = "srtasks.exe";
				processStartInfo.Arguments = "ExecuteScheduledSPPCreation";
			}
			_ = SYS32;
			processStartInfo.WorkingDirectory = SYS32;
			processStartInfo.Verb = "runas";
			procRundll = Process.Start(processStartInfo);
			procRundll.EnableRaisingEvents = true;
			procRundll.Exited += proc_Exited;
			((FrameworkElement)this).set_Cursor(Cursors.get_AppStarting());
		}
		else
		{
			CNativeWIN32.ShellExecute(0, "open", "systempropertiesadvanced.exe", "", "", 1);
		}
	}

	private void proc_Exited(object sender, EventArgs e)
	{
		Action action = delegate
		{
			((FrameworkElement)this).set_Cursor(Cursors.get_Arrow());
			procRundll = null;
			t2 = CNativeWIN32.GetTickCount64();
			t3 = Convert.ToInt32((double)(t2 - t1) / 1000.0);
			Utils.alert("복원지점을 만들기를 예약하였습니다. (유의: 시스템 정상 종료시 수행될 예정이며, 비정상 종료시 수행되지 않을 수 있습니다.) 소요시간 [" + t3 + "]초");
		};
		((DispatcherObject)this).get_Dispatcher().Invoke((Delegate)action, new object[0]);
	}

	private void mnuDoRecovory_Click(object sender, RoutedEventArgs e)
	{
		if (Utils.question("rstrui.exe 를 실행합니다."))
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.UseShellExecute = true;
			processStartInfo.FileName = SYS32 + Utils.SEPA + "rstrui.exe";
			_ = SYS32;
			processStartInfo.WorkingDirectory = SYS32;
			processStartInfo.Verb = "runas";
			Process.Start(processStartInfo);
		}
	}

	public void mnuVacc59_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine59)
		{
			RegiHelperSrc.Instance.CheckedVaccine59 = false;
			Utils.alert("WebDAV 공격에 취약점이 있을 수 있습니다.", ((Window)this).get_Title());
		}
		else
		{
			Utils.alert("WebDAV 취약 백신이 접종 되었습니다.[재부팅 후 적용됩니다.]", ((Window)this).get_Title());
			RegiHelperSrc.Instance.CheckedVaccine59 = true;
		}
	}

	public void mnuVacc60_Click(object sender, RoutedEventArgs e)
	{
		if (RegiHelperSrc.Instance.CheckedVaccine60)
		{
			RegiHelperSrc.Instance.CheckedVaccine60 = false;
		}
		else
		{
			RegiHelperSrc.Instance.CheckedVaccine60 = true;
		}
	}

	private void MenuItemWindowsISO_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "https://www.heidoc.net/joomla/technology-science/microsoft/67-microsoft-windows-and-office-iso-download-tool", null, null, 1);
	}

	private void mnuWindowsSecurityEncyclopedia_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "https://www.windows-security.org/content/microsoft-security-bulletins", null, null, 1);
	}

	private void mnuPU26_Click(object sender, RoutedEventArgs e)
	{
		Utils.ExecuteCommandSync("netsh int ip reset log.txt");
		mnuPU26.set_IsChecked(true);
	}

	private void mnuPU27_Click(object sender, RoutedEventArgs e)
	{
		Utils.ExecuteCommandSync("netsh winsock reset");
		mnuPU27.set_IsChecked(true);
	}

	private void mnuPU28_Click(object sender, RoutedEventArgs e)
	{
		Utils.ExecuteCommandSync("ipconfig /flushdns");
		mnuPU28.set_IsChecked(true);
	}

	private void mnuPU29_Click(object sender, RoutedEventArgs e)
	{
		Utils.ExecuteCommandSync("ipconfig /renew");
		mnuPU29.set_IsChecked(true);
	}

	private void mnuPU31_Click(object sender, RoutedEventArgs e)
	{
		if (File.Exists("c:\\windows\\system32\\bcdedit2.exe"))
		{
			Utils.ExecuteCommandSync("bcdedit2.exe /set {default} BootStatusPolicy DisplayAllFailures");
		}
		else
		{
			Utils.ExecuteCommandSync("bcdedit.exe /set {default} BootStatusPolicy DisplayAllFailures");
		}
		mnuPU31.set_IsChecked(true);
		if (mnuPU32.get_IsChecked())
		{
			mnuPU30.set_IsChecked(true);
		}
	}

	private void mnuPU32_Click(object sender, RoutedEventArgs e)
	{
		if (File.Exists("c:\\windows\\system32\\bcdedit2.exe"))
		{
			Utils.ExecuteCommandSync("bcdedit2.exe /set {default} recoveryenabled yes");
		}
		else
		{
			Utils.ExecuteCommandSync("bcdedit.exe /set {default} recoveryenabled yes");
		}
		mnuPU32.set_IsChecked(true);
		if (mnuPU31.get_IsChecked())
		{
			mnuPU30.set_IsChecked(true);
		}
	}

	private void mnuWindowsOSDocEncyclopedia_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "https://docs.microsoft.com/en-us/previous-versions/windows/", null, null, 1);
	}

	private void mnuMathSite_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "https://www.calculator.net/", null, null, 1);
	}

	private void mnuMathSite2_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "https://en.khanacademy.org/math/algebra/x2f8bb11595b61c86:foundation-algebra/x2f8bb11595b61c86:algebra-overview-history/v/origins-of-algebra?modal=1", null, null, 1);
	}

	private void mnuMathCalcSite_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "https://blog.naver.com/iq_up/222536578975", null, null, 1);
	}

	private void mnuPocketQuiz_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "https://cafe.naver.com/pocketquiz/3", null, null, 1);
	}

	private void mnuPU07_2_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "UserAccountControlSettings.exe", null, null, 1);
	}

	private void AppOutBlockDeleteItem_Click(object sender, RoutedEventArgs e)
	{
		string key = null;
		Button val = (Button)((sender is Button) ? sender : null);
		if (null != val)
		{
			key = ((FrameworkElement)val).get_Tag() as string;
		}
		AppOutBlockList appOutBlockList = null;
		appOutBlockList = AppOutBlockList.globalSection[key];
		if (appOutBlockList != null)
		{
			DelAppOutBlockNoFile(appOutBlockList);
		}
	}

	internal static bool DelAppOutBlockNoFile(AppOutBlockList obj)
	{
		bool flag = false;
		try
		{
			RegistryKey registryKey = null;
			registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\services\\SharedAccess\\Parameters\\FirewallPolicy\\FirewallRules", RegistryKeyPermissionCheck.ReadWriteSubTree);
			registryKey.DeleteValue(obj.KeyName);
			flag = true;
		}
		catch (Exception ex)
		{
			Console.Error.WriteLine(ex.Message);
		}
		finally
		{
			if (flag)
			{
				obj.VState = "VState2";
			}
		}
		return flag;
	}

	private void btnAppOutBlockRecommand_Click(object sender, RoutedEventArgs e)
	{
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		StringBuilder stringBuilder = new StringBuilder();
		((UIElement)btnAppOutBlockRecommand).set_IsEnabled(false);
		foreach (KeyValuePair<string, AppOutBlockList> item in AppOutBlockList.globalSection)
		{
			if (!item.Value.IsAppFileExist && !item.Value.VState.Equals("VState2"))
			{
				DelAppOutBlockNoFile(item.Value);
				num++;
				stringBuilder.Append(++num3 + ". [" + item.Value.AppName + "] " + item.Value.AppPath + " -> 삭제\n");
			}
			else if (!item.Value.Active && item.Value.ActionBlock)
			{
				item.Value.Active = true;
				num2++;
				stringBuilder.Append(++num3 + ". [" + item.Value.AppName + "] " + item.Value.AppPath + " -> 활성화\n");
			}
		}
		Clipboard.Clear();
		Clipboard.SetText(stringBuilder.ToString());
		if (num + num2 == 0)
		{
			AutoClosingMessageBox.Show("처리할 내역이 없습니다.", "PowerHealthChecker", 3100, 0);
			return;
		}
		AutoClosingMessageBox.Show("[ " + num + " ]건을 삭제 처리 및 [ " + num2 + " ]건을 활성화 설정하였습니다.\n<상세 처리 내역은 클립보드에 있습니다.>", "PowerHealthChecker", 3100, 0);
	}

	private void btnRefreshOutBlock_Click(object sender, RoutedEventArgs e)
	{
		((ItemsControl)lvAppOutBlock).set_ItemsSource((IEnumerable)null);
		itmListAppOutBlock.Clear();
		AppOutBlockList.Clear();
		bInitAppOutBlock = false;
		AppOutBlockSubProc();
	}

	private void mnuPU00_Click(object sender, RoutedEventArgs e)
	{
		RegiHelperSrc.Instance.CheckedVaccine23 = false;
		string text = replaceNormalizePath("%windir%\\system32\\svchost.exe");
		string mD5string = Utils.GetMD5string(text.ToLower() + "1**B");
		Utils.RemoveFireWallInBlock(mD5string);
		string text2 = Utils.ExecuteCommandSync("hostname.exe");
		text2 = text2.Trim();
		Clipboard.SetText(text2);
		Utils.alert("클립보드로 컴퓨터이름을 복사하였습니다.\n컴퓨터이름을 붙여넣기(Ctrl+V)로 추가하세요.");
		text2 = Utils.ExecuteCommandSync2("shutdown.exe", "/i");
	}

	private void txtReceiverMailAddress_MouseDoubleClick(object sender, MouseButtonEventArgs e)
	{
		if (txtReceiverMailAddress.get_Text().Length != 0)
		{
			return;
		}
		if (RegiHelperSrc.Instance.bAuth)
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(RegiHelperSrc.strKey, RegistryKeyPermissionCheck.ReadWriteSubTree);
			if (registryKey == null)
			{
				registryKey = Registry.CurrentUser.CreateSubKey(RegiHelperSrc.strKey);
			}
			if (registryKey.GetValue("UAuthEmail") is string text)
			{
				txtReceiverMailAddress.set_Text(text);
			}
		}
		else
		{
			txtReceiverMailAddress.set_Text("iquppark@gmail.com");
		}
	}

	private void label3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
	{
		if (txtReceiverMailAddress.get_Text().Length == 0)
		{
			txtReceiverMailAddress.set_Text("iquppark@gmail.com");
		}
	}

	private void mnuCheckUpdate_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "http://auth.vocalevel.com/healthchecker/ver?v=221014003", null, null, 1);
	}

	private void btnLicenceAuth_Click(object sender, RoutedEventArgs e)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Unknown result type (might be due to invalid IL or missing references)
		if (0 == txtUserEmail.get_Text().Length)
		{
			string text = "사용자 email을 입력하세요.";
			AutoClosingMessageBox.Show1(text, "PowerHealthChecker", 3100, 0);
			((UIElement)txtUserEmail).Focus();
			return;
		}
		if (-1 == txtUserEmail.get_Text().IndexOf("@"))
		{
			string text = "email 형식이 잘못되었습니다. @가 필요합니다.";
			AutoClosingMessageBox.Show1(text, "PowerHealthChecker", 3100, 0);
			((UIElement)txtUserEmail).Focus();
			return;
		}
		if (-1 == txtUserEmail.get_Text().IndexOf("."))
		{
			string text = "email 형식이 잘못되었습니다. 닷이 필요합니다.";
			AutoClosingMessageBox.Show1(text, "PowerHealthChecker", 3100, 0);
			((UIElement)txtUserEmail).Focus();
			return;
		}
		if (txtSerialNumber.get_Text().Length < 2)
		{
			string text = "시리얼번호를 입력하세요.";
			AutoClosingMessageBox.Show1(text, "PowerHealthChecker", 3100, 0);
			((UIElement)txtSerialNumber).Focus();
			return;
		}
		txtSerialNumber.set_Text(txtSerialNumber.get_Text().Replace("o", "0").Replace("O", "0"));
		txtSerialNumber.set_Text(txtSerialNumber.get_Text().Replace("ㅡ", "-"));
		string text2 = txtSerialNumber.get_Text().Substring(0, 2) + Utils.GetMD5string("10+" + txtUserEmail.get_Text().ToLower() + "uvw888uvw").Substring(0, 10);
		text2 += Utils.GetMD5string(text2.ToLower()).Substring(0, 4).ToLower();
		bool flag = false;
		if ((flag = txtSerialNumber.get_Text().Replace("-", "").ToLower()
			.Equals(text2.ToLower())) && Utils.AuthBiosDateCompare(txtUserEmail.get_Text(), text2.Substring(0, 1)))
		{
			string text = "인증되었습니다.";
			AutoClosingMessageBox.Show1(text, "PowerHealthChecker", 3100, 0);
			string sAuthCode = Utils.GetMD5string("PowerHealthChecker".ToLower() + "10+" + txtUserEmail.get_Text().ToLower() + RegiHelperSrc.ComputerName().ToLower() + RegiHelperSrc.BiosDate()).ToLower();
			RegiHelperSrc.Instance.doRegAuth(txtUserEmail.get_Text(), sAuthCode);
			RegiHelperSrc.Instance.bAuthSemi = false;
			RegiHelperSrc.Instance.bAuth = true;
		}
		else if ("802001-04-306613".Equals(txtSerialNumber.get_Text()) || "80200104306613".Equals(txtSerialNumber.get_Text().Replace("-", "")))
		{
			if (!RegiHelperSrc.Instance.bAuth)
			{
				RegiHelperSrc.Instance.MetaHanjaTAvalue = RegiHelperSrc.Instance.MetaHanjaTAvalue + 1;
				if (RegiHelperSrc.Instance.MetaHanjaTAvalue < 7)
				{
					string text = "임시 인증되었습니다.";
					string sAuthCode = Utils.GetMD5string("PowerHealthChecker".ToLower() + "1+" + txtUserEmail.get_Text().ToLower() + RegiHelperSrc.ComputerName().ToLower() + DateTime.Now.ToString("yyyy-MM-dd"));
					RegiHelperSrc.Instance.doRegAuth(txtUserEmail.get_Text(), sAuthCode);
					RegiHelperSrc.Instance.bAuthSemi = true;
					RegiHelperSrc.Instance.bAuth = true;
					AutoClosingMessageBox.Show1(text, "PowerHealthChecker", 3100, 0);
				}
				else
				{
					string text = "임시 인증을 더이상 이용 할 수 없습니다.\n정식 인증으로 이용 바랍니다.";
					AutoClosingMessageBox.Show1(text, "PowerHealthChecker", 3100, 0);
				}
			}
			else
			{
				string text = "이미 정식 인증 받은 사용자는 임시 인증을 받을 필요가 없습니다.";
				AutoClosingMessageBox.Show1(text, "PowerHealthChecker", 3100, 0);
			}
		}
		else
		{
			string text = ((!flag) ? "시리얼번호가 잘못되었습니다." : "사용된 시리얼 번호입니다. 기존에 설치했던 한 PC에서만 인증이 가능합니다.");
			AutoClosingMessageBox.Show1(text, "PowerHealthChecker", 3100, 0);
			if (flag)
			{
				text = "임시인증하시겠습니까?";
				if (Utils.question(text))
				{
					RegiHelperSrc.Instance.bAuthSemi = true;
					RegiHelperSrc.Instance.bAuth = true;
					text = "임시인증되었습니다.";
					AutoClosingMessageBox.Show1(text, "PowerHealthChecker", 3100, 0);
				}
			}
		}
		txtUserEmail.set_Text("");
		txtSerialNumber.set_Text("");
	}

	private void mnuPU36a_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "cmd.exe", "/c defrag.exe -c -v -u&time /t&pause", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void volumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		if (!((UIElement)volumeSlider).get_IsVisible())
		{
			return;
		}
		int num = (int)Math.Round(e.get_NewValue(), 0);
		if (num != CNativeWIN32.GetVolume())
		{
			CNativeWIN32.SetVolume(num);
			if (!btnVolumeStoryboard_started)
			{
				((ContentControl)lblVolState).set_Content((object)num);
			}
			((FrameworkElement)volumeSlider).set_ToolTip((object)num);
		}
	}

	private void mnuPU18f_Click(object sender, RoutedEventArgs e)
	{
		RegiHelperSrc.Instance.IsBlockMsTeams = !RegiHelperSrc.Instance.IsBlockMsTeams;
	}

	private void mnuPU18g_Click(object sender, RoutedEventArgs e)
	{
		RegiHelperSrc.Instance.IsBlockMsEdge = !RegiHelperSrc.Instance.IsBlockMsEdge;
	}

	private void mnuPU18h_Click(object sender, RoutedEventArgs e)
	{
		RegiHelperSrc.Instance.IsJsonInstallerNoti = !RegiHelperSrc.Instance.IsJsonInstallerNoti;
	}

	private void mnuPU18g1_Click(object sender, RoutedEventArgs e)
	{
		RegiHelperSrc.Instance.IsBlockWizvera = !RegiHelperSrc.Instance.IsBlockWizvera;
		if (!RegiHelperSrc.Instance.IsBlockWizvera)
		{
			Utils.ExecuteCommandSync(Environment.GetEnvironmentVariable("windir") + Utils.SEPA + "system32\\sc start WizveraPMSvc", showError: false);
		}
	}

	private void mnuPU33_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "winver.exe", null, SYS32, 1);
	}

	private void volumeSlider_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
	{
		if (btnVolumeStoryboard_started)
		{
			btnVolumeStoryboard.PerformClick();
			Application.DoEvents();
		}
	}

	private void chkAppApprovalBlock_Checked(object sender, RoutedEventArgs e)
	{
		RegiHelperSrc.Instance.IsBlockApps = true;
	}

	private void chkAppApprovalBlock_Unchecked(object sender, RoutedEventArgs e)
	{
		RegiHelperSrc.Instance.IsBlockApps = false;
	}

	private void btnOneMinuAfterExecute_Click(object sender, RoutedEventArgs e)
	{
		AutoResetEvent state = new AutoResetEvent(initialState: false);
		if (tmrOneMinExec != null)
		{
			tmrOneMinExec.Dispose();
			tmrOneMinExec = null;
			((ContentControl)btnOneMinuAfterExecute).set_Content((object)"1분 후 실행");
		}
		else
		{
			tmrOneMinExec = new Timer(callme, state, 500, 1000);
			double actualWidth = ((FrameworkElement)btnOneMinuAfterExecute).get_ActualWidth();
			((ContentControl)btnOneMinuAfterExecute).set_Content((object)"멈춤");
			((FrameworkElement)btnOneMinuAfterExecute).set_Width(actualWidth);
		}
	}

	internal void callme(object stateInfo)
	{
		AutoResetEvent autoResetEvent = (AutoResetEvent)stateInfo;
		if (nOneMinuAfterExecuteInvokeCount++ == 60)
		{
			tmrOneMinExec.Dispose();
			tmrOneMinExec = null;
			nOneMinuAfterExecuteInvokeCount = 0;
			autoResetEvent.Set();
			Action action = delegate
			{
				CNativeWIN32.ShellExecute(0, "open", RegiHelperSrc.Instance.FileNameOfOneMinExecute, null, null, 1);
				((ContentControl)btnOneMinuAfterExecute).set_Content((object)"1분 후 실행");
				Application.DoEvents();
			};
			((DispatcherObject)this).get_Dispatcher().Invoke((Delegate)action, new object[0]);
		}
		else
		{
			Action action = delegate
			{
				lblRemainSec.set_Text(string.Concat(60 - nOneMinuAfterExecuteInvokeCount));
				Application.DoEvents();
			};
			((DispatcherObject)this).get_Dispatcher().Invoke((Delegate)action, new object[0]);
		}
	}

	private void mnuPU18g2_Click(object sender, RoutedEventArgs e)
	{
		RegiHelperSrc.Instance.IsBlockApps = !RegiHelperSrc.Instance.IsBlockApps;
	}

	private void mnuResolve01_Click(object sender, RoutedEventArgs e)
	{
		bool showMsg = true;
		if (sender == null)
		{
			showMsg = false;
		}
		RegiHelperSrc.Instance.Resolve01Checked = !RegiHelperSrc.Instance.Resolve01Checked;
		List<string> list = new List<string>();
		list.Add("my-secure.org");
		list.Add("euznfvhqisabots.review");
		list.Add("101.livere.co.kr");
		list.Add("adv.mediaharbor.co.kr");
		list.Add("d1hn8mrtxasu7m.cloudfront.net");
		list.Add("dev.livere.co.kr");
		list.Add("js2.keywordsconnect.com");
		list.Add("log.2beon.co.kr");
		list.Add("m.joyinfo.com");
		list.Add("plugin.2beon.co.kr");
		list.Add("was.livere.me");
		list.Add("www.sunnyworks.co.kr");
		list.Add("cdn04.sndkorea.co.kr");
		list.Add("img.ypoll.mapps.kr");
		list.Add("www.care-health.co.kr");
		list.Add("adx.naonmedia.net");
		list.Add("m.yna.co.kr");
		list.Add("ww1.naonmedia.net");
		list.Add("mc.yandex.ru");
		list.Add("pusherism.com");
		list.Add("yesbet88.org");
		list.Add("rotumal.com");
		list.Add("newgensolution.co.kr");
		list.Add("www-guard.com");
		list.Add("api.favorite-icons.com");
		list.Add("manager.favorite-icons.com");
		list.Add("eazeeflo.warzonedns.com");
		list.Add("bit.ly");
		list.Add("vektorex.com");
		list.Add("gandigod.codns.com");
		list.Add("favids.com");
		list.Add("pushlinck.com");
		list.Add("datingin-siders.com");
		list.Add("eteenporn.com");
		list.Add("find-and-fuck.com");
		list.Add("jknlz.slutsnearby.com");
		list.Add("sexy18tube.com");
		list.Add("squirterstutuilans.online");
		list.Add("teenpornvideo.fun");
		list.Add("teensxxxtube.com");
		list.Add("www.18asiansex.com");
		list.Add("www.bananamall.co.kr");
		list.Add("www.indiansexvideo.xxx");
		list.Add("www.lover-date.com");
		list.Add("www.loversoge.com");
		list.Add("www.my18pussy.com");
		list.Add("www.teencliptube.com");
		list.Add("moz-secure.com");
		list.Add("www.r18.com");
		list.Add("yixun.com");
		list.Add("www.yixun.com");
		list.Add("www.bizographics.com");
		list.Add("px.ads.linkedin.com");
		list.Add("link.coupang.com");
		list.Add("px.ads.linkedin.com");
		list.Add("o.aolcdn.com");
		list.Add("web.vortex.data.microsoft.com.akadns.net");
		list.Add("at.atwola.com");
		list.Add("web.vortex.data.msn.com");
		list.Add("e1879.e7.akamaiedge.net");
		list.Add("c-bing-com.a-0001.a-msedge.net");
		list.Add("static.chartbeat.com");
		list.Add("dual-a-0001.a-msedge.net");
		list.Add("cs670.wpc.thetacdn.net");
		list.Add("a-0001.a-afdentry.net.trafficmanager.net");
		list.Add("prod.appnexus.map.fastly.net");
		list.Add("sb.scorecardresearch.com.edgekey.net");
		list.Add("adserver.adtech.advertising.com");
		list.Add("acdn.adnxs.com");
		list.Add("cs671.lb.wac.apr-1b09e.edgecastdns.net");
		list.Add("g.bing.com");
		list.Add("g-bing-com.a-0001.a-msedge.net");
		list.Add("bn2.vortex.data.microsoft.com.akadns.net");
		list.Add("cs671.wac.thetacdn.net");
		list.Add("c.msn.com");
		list.Add("cs926.wpc.thetacdn.net");
		list.Add("e11290.dspg.akamaiedge.net");
		list.Add("sb.scorecardresearch.com");
		list.Add("a1999.dscg2.akamai.net");
		list.Add("static-global-s-msn-com.akamaized.net");
		list.Add("confiant.msn.com");
		list.Add("www-msn-com.a-0003.a-msedge.net");
		list.Add("web.vortex.data.microsoft.com");
		list.Add("confiant.msn.com.edgekey.net");
		list.Add("c.bing.com");
		list.Add("go.microsoft.com.edgekey.net");
		list.Add("cs670.lb.wpc.apr-1b09e.edgecastdns.net");
		list.Add("geo.vortex.data.microsoft.com.akadns.net");
		list.Add("cs936.wpc.thetacdn.net");
		list.Add("cs629.wpc.lambdacdn.net");
		list.Add("e592.d.akamaiedge.net");
		list.Add("d3f7zc5bbfci5.cloudfront.net");
		list.Add("c-msn-com-nsatc.trafficmanager.net");
		list.Add("a-0003.a-msedge.net");
		list.Add("ping.chartbeat.net");
		list.Add("www.infor-med.com");
		list.Add("infor-med.com");
		list.Add("datesdatis.com");
		list.Add("frxgain.com");
		list.Add("me.frxgain.com");
		list.Add("lovinia.ru");
		list.Add("an.yandex.ru");
		list.Add("godatemetoday.com");
		list.Add("pastebin.com");
		list.Add("www.darkgamergeek.com");
		list.Add("leilamarsh.com");
		list.Add("galleries.jiangaophoto.com");
		list.Add("www.yukon-rewards.win");
		list.Add("flashservice.xvideos.com");
		list.Add("fuck18teen.com");
		list.Add("hot-teen.sexy");
		list.Add("landing.brazzersnetwork.com");
		list.Add("main.exoclick.com");
		list.Add("pornmoment.com");
		list.Add("pornopicshub.com");
		list.Add("rosetv.co.kr");
		list.Add("sexyteengirlfuck.com");
		list.Add("stripchat.com");
		list.Add("teenfaptube.com");
		list.Add("teenpornlist.com");
		list.Add("townofsins.com");
		list.Add("www.18teensex.me");
		list.Add("www.date2night.xyz");
		list.Add("www.flirt.com");
		list.Add("www.hrazens.com");
		list.Add("www.iwantu.com");
		list.Add("www.teenpornvideoz.com");
		list.Add("www.yesbet88.vip");
		list.Add("awptjmp.com");
		list.Add("www.modelwebcamgirls.com");
		list.Add("join.shoplyfter.com");
		list.Add("giawolff.com");
		list.Add("rijschool-automatiq.nl");
		list.Add("idx99.vgrid.co.kr");
		list.Add("v.p.vgrid.co.kr");
		list.Add("11st.com");
		list.Add("www.11st.com");
		list.Add("yadongmango.org");
		list.Add("d39f23jfph0ylk.cloudfront.net");
		list.Add("ko.aliexpress.com");
		list.Add("best.aliexpress.com");
		list.Add("tonsilyearling.com");
		list.Add("jkbin.wtf");
		list.Add("simpledatings.life");
		list.Add("mylocaldates1s.com");
		list.Add("click.greensmartmob.com");
		list.Add("yourabundancesurvey.top");
		list.Add("plarium.com");
		list.Add("one.next-pops.top");
		list.Add("plarium.com");
		list.Add("h5.g123.jp");
		list.Add("2912.shdeedel.live");
		strMsgInterface = doWorkHostsFile(RegiHelperSrc.Instance.Resolve01Checked, list, "바이러스 차단", showMsg);
	}

	private static string doWorkHostsFile(bool bChecked, List<string> lst_prevent, string strMnuName = "", bool showMsg = true)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		string result = "";
		StringBuilder stringBuilder = new StringBuilder();
		int num = 0;
		for (int i = 0; i < lst_prevent.Count; i++)
		{
			if (-1 == lst_prevent[i].IndexOf(".") || -1 < lst_prevent[i].IndexOf("/"))
			{
				AutoClosingMessageBox.Show(lst_prevent[i] + "는 처리되지 않습니다. '/'를 지우세요.", "PowerHealthChecker", 3100, 0);
			}
		}
		if (bChecked)
		{
			string text = File.ReadAllText("c:\\windows\\system32\\drivers\\etc\\hosts");
			for (int j = 0; j < lst_prevent.Count; j++)
			{
				if (text.IndexOf(lst_prevent[j]) == -1)
				{
					num++;
					stringBuilder.Append("\r\n127.0.0.1\t" + lst_prevent[j]);
				}
			}
			if (0 < num)
			{
				try
				{
					text = text + "\r\n" + stringBuilder.ToString();
					File.WriteAllText("c:\\windows\\system32\\drivers\\etc\\hosts", text);
				}
				catch (Exception ex)
				{
					Console.Error.WriteLine(ex.Message);
				}
				if (showMsg)
				{
					AutoClosingMessageBox.Show("[ " + num + " ]건 처리하였습니다. 재부팅 후 적용됩니다.", "PowerHealthChecker", 3100, 0);
				}
				else
				{
					result = "[ " + num + " ]건 다짐기 항목 Block 처리하였습니다. 재부팅 후 적용됩니다. (" + strMnuName + ")";
				}
			}
			else if (showMsg)
			{
				AutoClosingMessageBox.Show("조치할게 없습니다.", "PowerHealthChecker", 3100, 0);
			}
		}
		else
		{
			num = 0;
			string[] array = File.ReadAllLines("c:\\windows\\system32\\drivers\\etc\\hosts");
			List<string> list = new List<string>();
			for (int j = 0; j < array.Count(); j++)
			{
				list.Add(array[j]);
			}
			for (int j = 0; j < list.Count(); j++)
			{
				if (list[j].StartsWith("#"))
				{
					if (!list[j].StartsWith("# "))
					{
						list[j] = list[j].Replace("#", "# ");
					}
					for (int i = 0; i < lst_prevent.Count; i++)
					{
						if (-1 < list[j].IndexOf(lst_prevent[i]))
						{
							lst_prevent.RemoveAt(i--);
						}
					}
					continue;
				}
				for (int i = 0; i < lst_prevent.Count; i++)
				{
					if (-1 < list[j].IndexOf(lst_prevent[i]))
					{
						list.RemoveAt(j--);
						num++;
						lst_prevent.RemoveAt(i--);
						break;
					}
				}
			}
			StringBuilder stringBuilder2 = new StringBuilder();
			for (int j = 0; j < list.Count; j++)
			{
				if (j == 0)
				{
					stringBuilder2.Append(list[j]);
				}
				else
				{
					stringBuilder2.Append("\r\n" + list[j]);
				}
			}
			File.WriteAllText("c:\\windows\\system32\\drivers\\etc\\hosts", stringBuilder2.ToString());
			if (showMsg)
			{
				AutoClosingMessageBox.Show("[ " + num + " ]건에 대한 다짐기 항목 삭제 조치 하였습니다.\n재부팅 후 적용됩니다.", "PowerHealthChecker", 3100, 0);
			}
			else
			{
				result = "[ " + num + " ]건에 대한 다짐기 항목 삭제 조치 하였습니다.(" + strMnuName + ")";
			}
		}
		return result;
	}

	private void mnuResolve02_Click(object sender, RoutedEventArgs e)
	{
		bool showMsg = true;
		if (sender == null)
		{
			showMsg = false;
		}
		RegiHelperSrc.Instance.Resolve02Checked = !RegiHelperSrc.Instance.Resolve02Checked;
		List<string> list = new List<string>();
		list.Add("www.youtube.com");
		strMsgInterface = doWorkHostsFile(RegiHelperSrc.Instance.Resolve02Checked, list, "Youtube 차단", showMsg);
	}

	private void mnuResolve03_Click(object sender, RoutedEventArgs e)
	{
		bool showMsg = true;
		if (sender == null)
		{
			showMsg = false;
		}
		RegiHelperSrc.Instance.Resolve03Checked = !RegiHelperSrc.Instance.Resolve03Checked;
		List<string> list = new List<string>();
		list.Add("twitter.com");
		doWorkHostsFile(RegiHelperSrc.Instance.Resolve03Checked, list, "트위터 차단", showMsg);
	}

	private void mnuResolve04_Click(object sender, RoutedEventArgs e)
	{
		RegiHelperSrc.Instance.Resolve04Checked = !RegiHelperSrc.Instance.Resolve04Checked;
		List<string> list = new List<string>();
		list.Add("www.facebook.com");
		doWorkHostsFile(RegiHelperSrc.Instance.Resolve04Checked, list);
	}

	private void mnuResolve05_Click(object sender, RoutedEventArgs e)
	{
		RegiHelperSrc.Instance.Resolve05Checked = !RegiHelperSrc.Instance.Resolve05Checked;
		List<string> list = new List<string>();
		list.Add("www.afreecatv.com");
		list.Add("stimg.afreecatv.com");
		list.Add("v.afree.ca");
		list.Add("afreecatv.com");
		doWorkHostsFile(RegiHelperSrc.Instance.Resolve05Checked, list);
	}

	private void mnuResolve06_Click(object sender, RoutedEventArgs e)
	{
		RegiHelperSrc.Instance.Resolve06Checked = !RegiHelperSrc.Instance.Resolve06Checked;
		List<string> list = new List<string>();
		list.Add("section.blog.naver.com");
		list.Add("blog.naver.com");
		doWorkHostsFile(RegiHelperSrc.Instance.Resolve06Checked, list);
	}

	private void mnuResolve07_Click(object sender, RoutedEventArgs e)
	{
		bool showMsg = true;
		if (sender == null)
		{
			showMsg = false;
		}
		RegiHelperSrc.Instance.Resolve07Checked = !RegiHelperSrc.Instance.Resolve07Checked;
		List<string> list = new List<string>();
		list.Add("www.ohmynews.com");
		list.Add("adservice.google.co.kr");
		list.Add("adservice.google.com");
		list.Add("googleads.g.doubleclick.net");
		list.Add("pagead2.googlesyndication.com");
		list.Add("tpc.googlesyndication.com");
		list.Add("www.google-analytics.com");
		list.Add("imasdk.googleapis.com");
		list.Add("play.google.com");
		list.Add("ads.traffichunt.com");
		list.Add("dating4singlesonline2.com");
		list.Add("nrbgj.whoresnearby.com");
		list.Add("tdsdating.ru");
		list.Add("www.iamnaughty.com");
		list.Add("cdn8.ad4989.co.kr");
		list.Add("www.anytoon.co.kr");
		list.Add("www.anytoon.co.kr");
		list.Add("best2020-games-web1.com");
		list.Add("click.hooligapps.com");
		list.Add("thebestgame2020.com");
		list.Add("pornhubsurvey.com");
		list.Add("best.aliexpress.ru");
		list.Add("www.pornhubpremium.com");
		list.Add("www.jwplayer.com");
		list.Add("y-market.co.kr");
		list.Add("www.yukon-rewards.win");
		list.Add("main.realsrv.com");
		list.Add("up.vgrid.co.kr");
		list.Add("dietpillshub.com");
		strMsgInterface = doWorkHostsFile(RegiHelperSrc.Instance.Resolve07Checked, list, "광고 차단", showMsg);
	}

	private void mnuResolve10s_Click(object sender, RoutedEventArgs e)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		string resolve10s = RegiHelperSrc.Instance.Resolve10s;
		string text = "";
		text = Interaction.InputBox("사용자 정의 차단 도메인을 넣으세요, 여러개이면 ;로 구분하세요. (공백하나: 삭제)", "PowerHealthChecker", resolve10s, -1, -1);
		if (text.Length != 0)
		{
			RegiHelperSrc.Instance.Resolve10s = text.Trim();
		}
		else
		{
			AutoClosingMessageBox.Show("취소 되었습니다.", "PowerHealthChecker", 3100, 0);
		}
	}

	private void mnuResolve10_Click(object sender, RoutedEventArgs e)
	{
		string resolve10s = RegiHelperSrc.Instance.Resolve10s;
		string[] array = resolve10s.Split(new char[1] { ';' });
		RegiHelperSrc.Instance.Resolve10Checked = !RegiHelperSrc.Instance.Resolve10Checked;
		List<string> list = new List<string>();
		for (int i = 0; i < array.Count(); i++)
		{
			if (0 < array[i].Trim().Length)
			{
				list.Add(array[i].Trim());
			}
		}
		strMsgInterface = doWorkHostsFile(RegiHelperSrc.Instance.Resolve10Checked, list);
	}

	private void mnuResolve20s_Click(object sender, RoutedEventArgs e)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		string resolve20s = RegiHelperSrc.Instance.Resolve20s;
		string text = "";
		text = Interaction.InputBox("게임 차단용 도메인을 넣으세요, 여러개이면 ;로 구분하세요. (공백하나: 삭제)", "PowerHealthChecker", resolve20s, -1, -1);
		if (text.Length != 0)
		{
			RegiHelperSrc.Instance.Resolve20s = text.Trim();
		}
		else
		{
			AutoClosingMessageBox.Show("취소 되었습니다.", "PowerHealthChecker", 3100, 0);
		}
	}

	private void mnuResolve20_Click(object sender, RoutedEventArgs e)
	{
		string resolve20s = RegiHelperSrc.Instance.Resolve20s;
		string[] array = resolve20s.Split(new char[1] { ';' });
		RegiHelperSrc.Instance.Resolve20Checked = !RegiHelperSrc.Instance.Resolve20Checked;
		List<string> list = new List<string>();
		for (int i = 0; i < array.Count(); i++)
		{
			if (0 < array[i].Trim().Length)
			{
				list.Add(array[i].Trim());
			}
		}
		strMsgInterface = doWorkHostsFile(RegiHelperSrc.Instance.Resolve20Checked, list);
	}

	private void mnuResolve08_Click(object sender, RoutedEventArgs e)
	{
		RegiHelperSrc.Instance.Resolve08Checked = !RegiHelperSrc.Instance.Resolve08Checked;
		List<string> list = new List<string>();
		list.Add("www.instagram.com");
		doWorkHostsFile(RegiHelperSrc.Instance.Resolve08Checked, list);
	}

	private void mnuPU68BB_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", "rundll32.exe", "Shell32.dll,Control_RunDLL timedate.cpl,,1", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuPU68CC_Click(object sender, RoutedEventArgs e)
	{
		RegiHelperSrc.Instance.SetW32timeEnable();
	}

	private void mnuTimeSynch_chk_Click(object sender, RoutedEventArgs e)
	{
		RegiHelperSrc.Instance.AutoW32TimeSynchChecked = !RegiHelperSrc.Instance.AutoW32TimeSynchChecked;
	}

	internal void RemoveHookProcedure()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		if (mainWindowPtr != IntPtr.Zero)
		{
			HwndSource val = HwndSource.FromHwnd(mainWindowPtr);
			val.RemoveHook(new HwndSourceHook(WndProc));
			RegiHelperSrc.Instance.ProcessHWND = 0;
		}
		mainWindowPtr = IntPtr.Zero;
		bSlideShowHook = false;
	}

	internal void AddHookProcedure(bool p_slideshow = false)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		if (mainWindowPtr == IntPtr.Zero)
		{
			mainWindowPtr = new WindowInteropHelper((Window)(object)this).get_Handle();
			HwndSource val = HwndSource.FromHwnd(mainWindowPtr);
			val.AddHook(new HwndSourceHook(WndProc));
			HWND = val.get_Handle();
			RegiHelperSrc.Instance.ProcessHWND = (int)val.get_Handle();
		}
		bSlideShowHook = p_slideshow;
	}

	private IntPtr WndProc(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
	{
		if (msg == 1476)
		{
			if ((int)wParam == 160201)
			{
				Action action = delegate
				{
					//IL_0001: Unknown result type (might be due to invalid IL or missing references)
					//IL_0007: Invalid comparison between Unknown and I4
					if ((int)((Window)this).get_WindowState() == 1)
					{
						((Window)this).set_WindowState((WindowState)0);
					}
					CNativeWIN32.SetForegroundWindow(HWND);
				};
				((DispatcherObject)this).get_Dispatcher().BeginInvoke((Delegate)action, new object[0]);
			}
			handled = true;
		}
		return IntPtr.Zero;
	}

	private void btnFireWall_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", replaceNormalizePath("%windir%\\system32\\rundll32.exe"), "shell32.dll,Control_RunDLL firewall.cpl", replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void chkContinue_Click(object sender, RoutedEventArgs e)
	{
		RegiHelperSrc.Instance.AutoSaveMedicalReport = !RegiHelperSrc.Instance.AutoSaveMedicalReport;
	}

	private void mnuVaccALLUInew_Click(object sender, RoutedEventArgs e)
	{
		RegiHelperSrc.Instance.VaccAllUInewed = !RegiHelperSrc.Instance.VaccAllUInewed;
	}

	private void mnuPU34_Click(object sender, RoutedEventArgs e)
	{
		CNativeWIN32.ShellExecute(0, "open", RegiHelperSrc.Instance.StrSecHealthUI_path, null, replaceNormalizePath("%windir%\\system32"), 1);
	}

	private void mnuShellCommandSearch_Click(object sender, RoutedEventArgs e)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected O, but got Unknown
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected O, but got Unknown
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected O, but got Unknown
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected O, but got Unknown
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Expected O, but got Unknown
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Expected O, but got Unknown
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0466: Expected O, but got Unknown
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e8: Unknown result type (might be due to invalid IL or missing references)
		string resolve20s = RegiHelperSrc.Instance.Resolve20s;
		string text = "";
		text = Interaction.InputBox("검색어를 입력하세요.\n\n예1: 방화벽\n예2: security", "PowerHealthChecker", resolve20s, -1, -1).TrimStart(new char[0]);
		int num = 0;
		if (text.Length == 0)
		{
			return;
		}
		for (int i = 0; i < ((CollectionView)((ItemsControl)mnuShellCommandSearchResult).get_Items()).get_Count(); i++)
		{
			object obj = ((ItemsControl)mnuShellCommandSearchResult).get_Items().get_Item(i);
			MenuItem val = (MenuItem)((obj is MenuItem) ? obj : null);
			val.remove_Click(new RoutedEventHandler(mnu_i_Click.Invoke));
			val = null;
		}
		((ItemsControl)mnuShellCommandSearchResult).get_Items().Clear();
		string[] array = null;
		((HeaderedItemsControl)mnuShellCommandSearch).set_Header((object)("검색어: " + text));
		if (text.Length == 1)
		{
			for (int i = 0; i < lst_shell.Count(); i++)
			{
				if (-1 < lst_shell[i].IndexOf(" " + text, StringComparison.CurrentCultureIgnoreCase) || lst_shell[i].StartsWith(text))
				{
					MenuItem val = new MenuItem();
					array = lst_shell[i].Split(new char[1] { '|' });
					((HeaderedItemsControl)val).set_Header((object)("[" + (num + 1) + "] " + array[0]));
					((ItemsControl)mnuShellCommandSearchResult).get_Items().Add((object)val);
					((FrameworkElement)val).set_Tag((object)array[1]);
					val.add_Click(new RoutedEventHandler(mnu_i_Click.Invoke));
					num++;
				}
			}
			for (int i = 0; i < lst_cpl_msc.Count(); i++)
			{
				if (-1 < lst_cpl_msc[i].IndexOf(" " + text, StringComparison.CurrentCultureIgnoreCase) || lst_cpl_msc[i].StartsWith(text))
				{
					MenuItem val = new MenuItem();
					array = lst_cpl_msc[i].Split(new char[1] { '|' });
					((HeaderedItemsControl)val).set_Header((object)("[" + (num + 1) + "] " + array[0]));
					((ItemsControl)mnuShellCommandSearchResult).get_Items().Add((object)val);
					((FrameworkElement)val).set_Tag((object)array[1]);
					val.add_Click(new RoutedEventHandler(mnu_i_Click.Invoke));
					num++;
				}
			}
		}
		else
		{
			for (int i = 0; i < lst_shell.Count(); i++)
			{
				if (-1 < lst_shell[i].IndexOf(text, StringComparison.CurrentCultureIgnoreCase))
				{
					MenuItem val = new MenuItem();
					array = lst_shell[i].Split(new char[1] { '|' });
					((HeaderedItemsControl)val).set_Header((object)("[" + (num + 1) + "] " + array[0]));
					((ItemsControl)mnuShellCommandSearchResult).get_Items().Add((object)val);
					((FrameworkElement)val).set_Tag((object)array[1]);
					val.add_Click(new RoutedEventHandler(mnu_i_Click.Invoke));
					num++;
				}
			}
			for (int i = 0; i < lst_cpl_msc.Count(); i++)
			{
				if (-1 < lst_cpl_msc[i].IndexOf(text, StringComparison.CurrentCultureIgnoreCase))
				{
					MenuItem val = new MenuItem();
					array = lst_cpl_msc[i].Split(new char[1] { '|' });
					((HeaderedItemsControl)val).set_Header((object)("[" + (num + 1) + "] " + array[0]));
					((ItemsControl)mnuShellCommandSearchResult).get_Items().Add((object)val);
					((FrameworkElement)val).set_Tag((object)array[1]);
					val.add_Click(new RoutedEventHandler(mnu_i_Click.Invoke));
					num++;
				}
			}
		}
		if (0 < num)
		{
			((UIElement)mnuShellCommandSearchResult).set_IsEnabled(true);
		}
		else
		{
			((UIElement)mnuShellCommandSearchResult).set_IsEnabled(false);
		}
		if (num == 0)
		{
			AutoClosingMessageBox.Show("검색결과가 없습니다.", "PowerHealthChecker", 3100, 0);
		}
		else
		{
			AutoClosingMessageBox.Show("검색결과: " + num + "건", "PowerHealthChecker", 3100, 0);
		}
	}

	private void mnuPU40_Click(object sender, RoutedEventArgs e)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		RegiHelperSrc.Instance.Win11_RMB_Solve();
		AutoClosingMessageBox.Show("Win11 RMB Solve 실행하였습니다.\n재부팅이 필요합니다.", "PowerHealthChecker", 3100, 0);
	}

	private void mnuPU41_Click(object sender, RoutedEventArgs e)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		RegiHelperSrc.Instance.Win11_RMB_Restore();
		AutoClosingMessageBox.Show("Win11 RMB 복원하였습니다.\n재부팅이 필요합니다.", "PowerHealthChecker", 3100, 0);
	}

	private void mnuPU42_Click(object sender, RoutedEventArgs e)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		RegiHelperSrc.Instance.IsCopyPathActive = !RegiHelperSrc.Instance.IsCopyPathActive;
		AutoClosingMessageBox.Show("재부팅 후 탐색기 기능에 적용됩니다.", "PowerHealthChecker", 3100, 0);
	}

	private void mnuPU43_Click(object sender, RoutedEventArgs e)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		RegiHelperSrc.Instance.IsCopyToFolderActive = !RegiHelperSrc.Instance.IsCopyToFolderActive;
		AutoClosingMessageBox.Show("재부팅 후 탐색기 기능에 적용됩니다.", "PowerHealthChecker", 3100, 0);
	}

	private void mnuPU44_Click(object sender, RoutedEventArgs e)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		RegiHelperSrc.Instance.IsMoveToFolderActive = !RegiHelperSrc.Instance.IsMoveToFolderActive;
		AutoClosingMessageBox.Show("재부팅 후 탐색기 기능에 적용됩니다.", "PowerHealthChecker", 3100, 0);
	}

	private void chkEndReDiagnosis_Click(object sender, RoutedEventArgs e)
	{
		RegiHelperSrc.Instance.IsEndReDiagnosis = !RegiHelperSrc.Instance.IsEndReDiagnosis;
	}

	private void mnuPU45_Click(object sender, RoutedEventArgs e)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		RegiHelperSrc.Instance.IsBeforeVersionRecoverNotUse = !RegiHelperSrc.Instance.IsBeforeVersionRecoverNotUse;
		AutoClosingMessageBox.Show("재부팅 후 탐색기 기능에 적용됩니다.", "PowerHealthChecker", 3100, 0);
	}

	private void txtReceiverMailAddress_TextChanged(object sender, TextChangedEventArgs e)
	{
		if (txtReceiverMailAddress.get_Text().Length == 0)
		{
			((UIElement)lblAuthEmailGuide).set_Visibility((Visibility)0);
		}
		else
		{
			((UIElement)lblAuthEmailGuide).set_Visibility((Visibility)2);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri uri = new Uri("/PowerHealthChecker;component/mainhealthchecker.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_06a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ad: Expected O, but got Unknown
		//IL_06b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06be: Expected O, but got Unknown
		//IL_06c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cf: Expected O, but got Unknown
		//IL_06d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e0: Expected O, but got Unknown
		//IL_06e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f1: Expected O, but got Unknown
		//IL_06f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0702: Expected O, but got Unknown
		//IL_070f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0719: Expected O, but got Unknown
		//IL_0720: Unknown result type (might be due to invalid IL or missing references)
		//IL_072a: Expected O, but got Unknown
		//IL_0737: Unknown result type (might be due to invalid IL or missing references)
		//IL_0741: Expected O, but got Unknown
		//IL_0748: Unknown result type (might be due to invalid IL or missing references)
		//IL_0752: Expected O, but got Unknown
		//IL_075f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0769: Expected O, but got Unknown
		//IL_0770: Unknown result type (might be due to invalid IL or missing references)
		//IL_077a: Expected O, but got Unknown
		//IL_0787: Unknown result type (might be due to invalid IL or missing references)
		//IL_0791: Expected O, but got Unknown
		//IL_0798: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a2: Expected O, but got Unknown
		//IL_07af: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b9: Expected O, but got Unknown
		//IL_07c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ca: Expected O, but got Unknown
		//IL_07d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e1: Expected O, but got Unknown
		//IL_07e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f2: Expected O, but got Unknown
		//IL_07ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0809: Expected O, but got Unknown
		//IL_0810: Unknown result type (might be due to invalid IL or missing references)
		//IL_081a: Expected O, but got Unknown
		//IL_0821: Unknown result type (might be due to invalid IL or missing references)
		//IL_082b: Expected O, but got Unknown
		//IL_0838: Unknown result type (might be due to invalid IL or missing references)
		//IL_0842: Expected O, but got Unknown
		//IL_0849: Unknown result type (might be due to invalid IL or missing references)
		//IL_0853: Expected O, but got Unknown
		//IL_0860: Unknown result type (might be due to invalid IL or missing references)
		//IL_086a: Expected O, but got Unknown
		//IL_0871: Unknown result type (might be due to invalid IL or missing references)
		//IL_087b: Expected O, but got Unknown
		//IL_0888: Unknown result type (might be due to invalid IL or missing references)
		//IL_0892: Expected O, but got Unknown
		//IL_0899: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a3: Expected O, but got Unknown
		//IL_08b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ba: Expected O, but got Unknown
		//IL_08c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cb: Expected O, but got Unknown
		//IL_08d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e2: Expected O, but got Unknown
		//IL_08e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f3: Expected O, but got Unknown
		//IL_0900: Unknown result type (might be due to invalid IL or missing references)
		//IL_090a: Expected O, but got Unknown
		//IL_0911: Unknown result type (might be due to invalid IL or missing references)
		//IL_091b: Expected O, but got Unknown
		//IL_0928: Unknown result type (might be due to invalid IL or missing references)
		//IL_0932: Expected O, but got Unknown
		//IL_0939: Unknown result type (might be due to invalid IL or missing references)
		//IL_0943: Expected O, but got Unknown
		//IL_0950: Unknown result type (might be due to invalid IL or missing references)
		//IL_095a: Expected O, but got Unknown
		//IL_0961: Unknown result type (might be due to invalid IL or missing references)
		//IL_096b: Expected O, but got Unknown
		//IL_0978: Unknown result type (might be due to invalid IL or missing references)
		//IL_0982: Expected O, but got Unknown
		//IL_0989: Unknown result type (might be due to invalid IL or missing references)
		//IL_0993: Expected O, but got Unknown
		//IL_09a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09aa: Expected O, but got Unknown
		//IL_09b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bb: Expected O, but got Unknown
		//IL_09c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d2: Expected O, but got Unknown
		//IL_09d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e3: Expected O, but got Unknown
		//IL_09f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fa: Expected O, but got Unknown
		//IL_0a01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0b: Expected O, but got Unknown
		//IL_0a18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a22: Expected O, but got Unknown
		//IL_0a29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a33: Expected O, but got Unknown
		//IL_0a40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4a: Expected O, but got Unknown
		//IL_0a51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5b: Expected O, but got Unknown
		//IL_0a68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a72: Expected O, but got Unknown
		//IL_0a79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a83: Expected O, but got Unknown
		//IL_0a90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9a: Expected O, but got Unknown
		//IL_0aa1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aab: Expected O, but got Unknown
		//IL_0ab8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac2: Expected O, but got Unknown
		//IL_0ac9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad3: Expected O, but got Unknown
		//IL_0ae0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aea: Expected O, but got Unknown
		//IL_0af1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afb: Expected O, but got Unknown
		//IL_0b08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b12: Expected O, but got Unknown
		//IL_0b19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b23: Expected O, but got Unknown
		//IL_0b30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3a: Expected O, but got Unknown
		//IL_0b41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4b: Expected O, but got Unknown
		//IL_0b58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b62: Expected O, but got Unknown
		//IL_0b69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b73: Expected O, but got Unknown
		//IL_0b80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8a: Expected O, but got Unknown
		//IL_0b91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9b: Expected O, but got Unknown
		//IL_0ba8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb2: Expected O, but got Unknown
		//IL_0bb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc3: Expected O, but got Unknown
		//IL_0bd0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bda: Expected O, but got Unknown
		//IL_0be1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0beb: Expected O, but got Unknown
		//IL_0bf8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c02: Expected O, but got Unknown
		//IL_0c09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c13: Expected O, but got Unknown
		//IL_0c20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2a: Expected O, but got Unknown
		//IL_0c31: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3b: Expected O, but got Unknown
		//IL_0c48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c52: Expected O, but got Unknown
		//IL_0c59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c63: Expected O, but got Unknown
		//IL_0c70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7a: Expected O, but got Unknown
		//IL_0c81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8b: Expected O, but got Unknown
		//IL_0c98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca2: Expected O, but got Unknown
		//IL_0ca9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb3: Expected O, but got Unknown
		//IL_0cc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cca: Expected O, but got Unknown
		//IL_0cd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cdb: Expected O, but got Unknown
		//IL_0ce8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf2: Expected O, but got Unknown
		//IL_0cf9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d03: Expected O, but got Unknown
		//IL_0d10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1a: Expected O, but got Unknown
		//IL_0d21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2b: Expected O, but got Unknown
		//IL_0d38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d42: Expected O, but got Unknown
		//IL_0d49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d53: Expected O, but got Unknown
		//IL_0d60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6a: Expected O, but got Unknown
		//IL_0d71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7b: Expected O, but got Unknown
		//IL_0d88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d92: Expected O, but got Unknown
		//IL_0d99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da3: Expected O, but got Unknown
		//IL_0db0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dba: Expected O, but got Unknown
		//IL_0dc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dcb: Expected O, but got Unknown
		//IL_0dd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de2: Expected O, but got Unknown
		//IL_0de9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df3: Expected O, but got Unknown
		//IL_0e00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0a: Expected O, but got Unknown
		//IL_0e11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e1b: Expected O, but got Unknown
		//IL_0e28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e32: Expected O, but got Unknown
		//IL_0e39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e43: Expected O, but got Unknown
		//IL_0e50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e5a: Expected O, but got Unknown
		//IL_0e61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6b: Expected O, but got Unknown
		//IL_0e78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e82: Expected O, but got Unknown
		//IL_0e89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e93: Expected O, but got Unknown
		//IL_0ea0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eaa: Expected O, but got Unknown
		//IL_0eb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ebb: Expected O, but got Unknown
		//IL_0ec8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed2: Expected O, but got Unknown
		//IL_0ed9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee3: Expected O, but got Unknown
		//IL_0ef0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0efa: Expected O, but got Unknown
		//IL_0f01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0b: Expected O, but got Unknown
		//IL_0f18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f22: Expected O, but got Unknown
		//IL_0f29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f33: Expected O, but got Unknown
		//IL_0f40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f4a: Expected O, but got Unknown
		//IL_0f51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f5b: Expected O, but got Unknown
		//IL_0f68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f72: Expected O, but got Unknown
		//IL_0f79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f83: Expected O, but got Unknown
		//IL_0f90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f9a: Expected O, but got Unknown
		//IL_0fa1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fab: Expected O, but got Unknown
		//IL_0fb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc2: Expected O, but got Unknown
		//IL_0fc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd3: Expected O, but got Unknown
		//IL_0fe0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fea: Expected O, but got Unknown
		//IL_0ff1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ffb: Expected O, but got Unknown
		//IL_1008: Unknown result type (might be due to invalid IL or missing references)
		//IL_1012: Expected O, but got Unknown
		//IL_1019: Unknown result type (might be due to invalid IL or missing references)
		//IL_1023: Expected O, but got Unknown
		//IL_1030: Unknown result type (might be due to invalid IL or missing references)
		//IL_103a: Expected O, but got Unknown
		//IL_1041: Unknown result type (might be due to invalid IL or missing references)
		//IL_104b: Expected O, but got Unknown
		//IL_1058: Unknown result type (might be due to invalid IL or missing references)
		//IL_1062: Expected O, but got Unknown
		//IL_1069: Unknown result type (might be due to invalid IL or missing references)
		//IL_1073: Expected O, but got Unknown
		//IL_1080: Unknown result type (might be due to invalid IL or missing references)
		//IL_108a: Expected O, but got Unknown
		//IL_1091: Unknown result type (might be due to invalid IL or missing references)
		//IL_109b: Expected O, but got Unknown
		//IL_10a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b2: Expected O, but got Unknown
		//IL_10b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c3: Expected O, but got Unknown
		//IL_10ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d4: Expected O, but got Unknown
		//IL_10e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_10eb: Expected O, but got Unknown
		//IL_10f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_10fc: Expected O, but got Unknown
		//IL_1109: Unknown result type (might be due to invalid IL or missing references)
		//IL_1113: Expected O, but got Unknown
		//IL_111a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1124: Expected O, but got Unknown
		//IL_1131: Unknown result type (might be due to invalid IL or missing references)
		//IL_113b: Expected O, but got Unknown
		//IL_1142: Unknown result type (might be due to invalid IL or missing references)
		//IL_114c: Expected O, but got Unknown
		//IL_1159: Unknown result type (might be due to invalid IL or missing references)
		//IL_1163: Expected O, but got Unknown
		//IL_116a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1174: Expected O, but got Unknown
		//IL_1181: Unknown result type (might be due to invalid IL or missing references)
		//IL_118b: Expected O, but got Unknown
		//IL_1192: Unknown result type (might be due to invalid IL or missing references)
		//IL_119c: Expected O, but got Unknown
		//IL_11a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b3: Expected O, but got Unknown
		//IL_11ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c4: Expected O, but got Unknown
		//IL_11d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_11db: Expected O, but got Unknown
		//IL_11e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ec: Expected O, but got Unknown
		//IL_11f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1203: Expected O, but got Unknown
		//IL_120a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1214: Expected O, but got Unknown
		//IL_1221: Unknown result type (might be due to invalid IL or missing references)
		//IL_122b: Expected O, but got Unknown
		//IL_1232: Unknown result type (might be due to invalid IL or missing references)
		//IL_123c: Expected O, but got Unknown
		//IL_1249: Unknown result type (might be due to invalid IL or missing references)
		//IL_1253: Expected O, but got Unknown
		//IL_125a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1264: Expected O, but got Unknown
		//IL_1271: Unknown result type (might be due to invalid IL or missing references)
		//IL_127b: Expected O, but got Unknown
		//IL_1282: Unknown result type (might be due to invalid IL or missing references)
		//IL_128c: Expected O, but got Unknown
		//IL_1299: Unknown result type (might be due to invalid IL or missing references)
		//IL_12a3: Expected O, but got Unknown
		//IL_12aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b4: Expected O, but got Unknown
		//IL_12c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12cb: Expected O, but got Unknown
		//IL_12d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_12dc: Expected O, but got Unknown
		//IL_12e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f3: Expected O, but got Unknown
		//IL_12fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1304: Expected O, but got Unknown
		//IL_1311: Unknown result type (might be due to invalid IL or missing references)
		//IL_131b: Expected O, but got Unknown
		//IL_1322: Unknown result type (might be due to invalid IL or missing references)
		//IL_132c: Expected O, but got Unknown
		//IL_1339: Unknown result type (might be due to invalid IL or missing references)
		//IL_1343: Expected O, but got Unknown
		//IL_134a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1354: Expected O, but got Unknown
		//IL_1361: Unknown result type (might be due to invalid IL or missing references)
		//IL_136b: Expected O, but got Unknown
		//IL_1372: Unknown result type (might be due to invalid IL or missing references)
		//IL_137c: Expected O, but got Unknown
		//IL_1389: Unknown result type (might be due to invalid IL or missing references)
		//IL_1393: Expected O, but got Unknown
		//IL_139a: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a4: Expected O, but got Unknown
		//IL_13b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_13bb: Expected O, but got Unknown
		//IL_13c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_13cc: Expected O, but got Unknown
		//IL_13d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_13e3: Expected O, but got Unknown
		//IL_13ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f4: Expected O, but got Unknown
		//IL_1401: Unknown result type (might be due to invalid IL or missing references)
		//IL_140b: Expected O, but got Unknown
		//IL_1412: Unknown result type (might be due to invalid IL or missing references)
		//IL_141c: Expected O, but got Unknown
		//IL_1429: Unknown result type (might be due to invalid IL or missing references)
		//IL_1433: Expected O, but got Unknown
		//IL_143a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1444: Expected O, but got Unknown
		//IL_1451: Unknown result type (might be due to invalid IL or missing references)
		//IL_145b: Expected O, but got Unknown
		//IL_1462: Unknown result type (might be due to invalid IL or missing references)
		//IL_146c: Expected O, but got Unknown
		//IL_1479: Unknown result type (might be due to invalid IL or missing references)
		//IL_1483: Expected O, but got Unknown
		//IL_148a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1494: Expected O, but got Unknown
		//IL_14a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ab: Expected O, but got Unknown
		//IL_14b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_14bc: Expected O, but got Unknown
		//IL_14c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d3: Expected O, but got Unknown
		//IL_14da: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e4: Expected O, but got Unknown
		//IL_14f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_14fb: Expected O, but got Unknown
		//IL_1502: Unknown result type (might be due to invalid IL or missing references)
		//IL_150c: Expected O, but got Unknown
		//IL_1519: Unknown result type (might be due to invalid IL or missing references)
		//IL_1523: Expected O, but got Unknown
		//IL_152a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1534: Expected O, but got Unknown
		//IL_1541: Unknown result type (might be due to invalid IL or missing references)
		//IL_154b: Expected O, but got Unknown
		//IL_1552: Unknown result type (might be due to invalid IL or missing references)
		//IL_155c: Expected O, but got Unknown
		//IL_1569: Unknown result type (might be due to invalid IL or missing references)
		//IL_1573: Expected O, but got Unknown
		//IL_157a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1584: Expected O, but got Unknown
		//IL_1591: Unknown result type (might be due to invalid IL or missing references)
		//IL_159b: Expected O, but got Unknown
		//IL_15a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_15ac: Expected O, but got Unknown
		//IL_15b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_15c3: Expected O, but got Unknown
		//IL_15ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_15d4: Expected O, but got Unknown
		//IL_15e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_15eb: Expected O, but got Unknown
		//IL_15f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_15fc: Expected O, but got Unknown
		//IL_1609: Unknown result type (might be due to invalid IL or missing references)
		//IL_1613: Expected O, but got Unknown
		//IL_161a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1624: Expected O, but got Unknown
		//IL_1631: Unknown result type (might be due to invalid IL or missing references)
		//IL_163b: Expected O, but got Unknown
		//IL_1642: Unknown result type (might be due to invalid IL or missing references)
		//IL_164c: Expected O, but got Unknown
		//IL_1659: Unknown result type (might be due to invalid IL or missing references)
		//IL_1663: Expected O, but got Unknown
		//IL_166a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1674: Expected O, but got Unknown
		//IL_1681: Unknown result type (might be due to invalid IL or missing references)
		//IL_168b: Expected O, but got Unknown
		//IL_1692: Unknown result type (might be due to invalid IL or missing references)
		//IL_169c: Expected O, but got Unknown
		//IL_16a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ad: Expected O, but got Unknown
		//IL_16ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_16c4: Expected O, but got Unknown
		//IL_16cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_16d5: Expected O, but got Unknown
		//IL_16e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ec: Expected O, but got Unknown
		//IL_16f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_16fd: Expected O, but got Unknown
		//IL_170a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1714: Expected O, but got Unknown
		//IL_171b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1725: Expected O, but got Unknown
		//IL_1732: Unknown result type (might be due to invalid IL or missing references)
		//IL_173c: Expected O, but got Unknown
		//IL_1743: Unknown result type (might be due to invalid IL or missing references)
		//IL_174d: Expected O, but got Unknown
		//IL_1754: Unknown result type (might be due to invalid IL or missing references)
		//IL_175e: Expected O, but got Unknown
		//IL_176b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1775: Expected O, but got Unknown
		//IL_177c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1786: Expected O, but got Unknown
		//IL_1793: Unknown result type (might be due to invalid IL or missing references)
		//IL_179d: Expected O, but got Unknown
		//IL_17a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_17ae: Expected O, but got Unknown
		//IL_17bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_17c5: Expected O, but got Unknown
		//IL_17cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_17d6: Expected O, but got Unknown
		//IL_17e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_17ed: Expected O, but got Unknown
		//IL_17f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_17fe: Expected O, but got Unknown
		//IL_1805: Unknown result type (might be due to invalid IL or missing references)
		//IL_180f: Expected O, but got Unknown
		//IL_181c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1826: Expected O, but got Unknown
		//IL_182d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1837: Expected O, but got Unknown
		//IL_1844: Unknown result type (might be due to invalid IL or missing references)
		//IL_184e: Expected O, but got Unknown
		//IL_1855: Unknown result type (might be due to invalid IL or missing references)
		//IL_185f: Expected O, but got Unknown
		//IL_1866: Unknown result type (might be due to invalid IL or missing references)
		//IL_1870: Expected O, but got Unknown
		//IL_187d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1887: Expected O, but got Unknown
		//IL_188e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1898: Expected O, but got Unknown
		//IL_18a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_18af: Expected O, but got Unknown
		//IL_18b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_18c0: Expected O, but got Unknown
		//IL_18c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_18d1: Expected O, but got Unknown
		//IL_18de: Unknown result type (might be due to invalid IL or missing references)
		//IL_18e8: Expected O, but got Unknown
		//IL_18ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_18f9: Expected O, but got Unknown
		//IL_1906: Unknown result type (might be due to invalid IL or missing references)
		//IL_1910: Expected O, but got Unknown
		//IL_1917: Unknown result type (might be due to invalid IL or missing references)
		//IL_1921: Expected O, but got Unknown
		//IL_192e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1938: Expected O, but got Unknown
		//IL_193f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1949: Expected O, but got Unknown
		//IL_1956: Unknown result type (might be due to invalid IL or missing references)
		//IL_1960: Expected O, but got Unknown
		//IL_1967: Unknown result type (might be due to invalid IL or missing references)
		//IL_1971: Expected O, but got Unknown
		//IL_197e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1988: Expected O, but got Unknown
		//IL_198f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1999: Expected O, but got Unknown
		//IL_19a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_19aa: Expected O, but got Unknown
		//IL_19b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_19c1: Expected O, but got Unknown
		//IL_19c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_19d2: Expected O, but got Unknown
		//IL_19df: Unknown result type (might be due to invalid IL or missing references)
		//IL_19e9: Expected O, but got Unknown
		//IL_19f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_19fa: Expected O, but got Unknown
		//IL_1a07: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a11: Expected O, but got Unknown
		//IL_1a18: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a22: Expected O, but got Unknown
		//IL_1a2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a39: Expected O, but got Unknown
		//IL_1a40: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a4a: Expected O, but got Unknown
		//IL_1a57: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a61: Expected O, but got Unknown
		//IL_1a68: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a72: Expected O, but got Unknown
		//IL_1a7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a89: Expected O, but got Unknown
		//IL_1a90: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a9a: Expected O, but got Unknown
		//IL_1aa7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ab1: Expected O, but got Unknown
		//IL_1ab8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ac2: Expected O, but got Unknown
		//IL_1acf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ad9: Expected O, but got Unknown
		//IL_1ae0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aea: Expected O, but got Unknown
		//IL_1af7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b01: Expected O, but got Unknown
		//IL_1b08: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b12: Expected O, but got Unknown
		//IL_1b1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b29: Expected O, but got Unknown
		//IL_1b30: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b3a: Expected O, but got Unknown
		//IL_1b47: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b51: Expected O, but got Unknown
		//IL_1b58: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b62: Expected O, but got Unknown
		//IL_1b6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b79: Expected O, but got Unknown
		//IL_1b80: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b8a: Expected O, but got Unknown
		//IL_1b97: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ba1: Expected O, but got Unknown
		//IL_1ba8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bb2: Expected O, but got Unknown
		//IL_1bbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bc9: Expected O, but got Unknown
		//IL_1bd0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bda: Expected O, but got Unknown
		//IL_1be7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bf1: Expected O, but got Unknown
		//IL_1bf8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c02: Expected O, but got Unknown
		//IL_1c0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c19: Expected O, but got Unknown
		//IL_1c20: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c2a: Expected O, but got Unknown
		//IL_1c37: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c41: Expected O, but got Unknown
		//IL_1c48: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c52: Expected O, but got Unknown
		//IL_1c5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c69: Expected O, but got Unknown
		//IL_1c70: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c7a: Expected O, but got Unknown
		//IL_1c87: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c91: Expected O, but got Unknown
		//IL_1c98: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ca2: Expected O, but got Unknown
		//IL_1caf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cb9: Expected O, but got Unknown
		//IL_1cc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cca: Expected O, but got Unknown
		//IL_1cd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ce1: Expected O, but got Unknown
		//IL_1ce8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cf2: Expected O, but got Unknown
		//IL_1cff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d09: Expected O, but got Unknown
		//IL_1d10: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d1a: Expected O, but got Unknown
		//IL_1d27: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d31: Expected O, but got Unknown
		//IL_1d38: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d42: Expected O, but got Unknown
		//IL_1d4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d59: Expected O, but got Unknown
		//IL_1d60: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d6a: Expected O, but got Unknown
		//IL_1d77: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d81: Expected O, but got Unknown
		//IL_1d88: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d92: Expected O, but got Unknown
		//IL_1d9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1da9: Expected O, but got Unknown
		//IL_1db0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dba: Expected O, but got Unknown
		//IL_1dc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dd1: Expected O, but got Unknown
		//IL_1dd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1de2: Expected O, but got Unknown
		//IL_1def: Unknown result type (might be due to invalid IL or missing references)
		//IL_1df9: Expected O, but got Unknown
		//IL_1e00: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e0a: Expected O, but got Unknown
		//IL_1e17: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e21: Expected O, but got Unknown
		//IL_1e28: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e32: Expected O, but got Unknown
		//IL_1e3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e49: Expected O, but got Unknown
		//IL_1e50: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e5a: Expected O, but got Unknown
		//IL_1e67: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e71: Expected O, but got Unknown
		//IL_1e78: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e82: Expected O, but got Unknown
		//IL_1e8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e99: Expected O, but got Unknown
		//IL_1ea0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eaa: Expected O, but got Unknown
		//IL_1eb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ec1: Expected O, but got Unknown
		//IL_1ec8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ed2: Expected O, but got Unknown
		//IL_1edf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ee9: Expected O, but got Unknown
		//IL_1ef0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1efa: Expected O, but got Unknown
		//IL_1f07: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f11: Expected O, but got Unknown
		//IL_1f18: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f22: Expected O, but got Unknown
		//IL_1f2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f39: Expected O, but got Unknown
		//IL_1f40: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f4a: Expected O, but got Unknown
		//IL_1f57: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f61: Expected O, but got Unknown
		//IL_1f68: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f72: Expected O, but got Unknown
		//IL_1f7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f89: Expected O, but got Unknown
		//IL_1f90: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f9a: Expected O, but got Unknown
		//IL_1fa7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fb1: Expected O, but got Unknown
		//IL_1fb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fc2: Expected O, but got Unknown
		//IL_1fcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fd9: Expected O, but got Unknown
		//IL_1fe0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fea: Expected O, but got Unknown
		//IL_1ff7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2001: Expected O, but got Unknown
		//IL_2008: Unknown result type (might be due to invalid IL or missing references)
		//IL_2012: Expected O, but got Unknown
		//IL_201f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2029: Expected O, but got Unknown
		//IL_2030: Unknown result type (might be due to invalid IL or missing references)
		//IL_203a: Expected O, but got Unknown
		//IL_2047: Unknown result type (might be due to invalid IL or missing references)
		//IL_2051: Expected O, but got Unknown
		//IL_2058: Unknown result type (might be due to invalid IL or missing references)
		//IL_2062: Expected O, but got Unknown
		//IL_206f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2079: Expected O, but got Unknown
		//IL_2080: Unknown result type (might be due to invalid IL or missing references)
		//IL_208a: Expected O, but got Unknown
		//IL_2097: Unknown result type (might be due to invalid IL or missing references)
		//IL_20a1: Expected O, but got Unknown
		//IL_20a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_20b2: Expected O, but got Unknown
		//IL_20bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_20c9: Expected O, but got Unknown
		//IL_20d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_20da: Expected O, but got Unknown
		//IL_20e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_20f1: Expected O, but got Unknown
		//IL_20f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2102: Expected O, but got Unknown
		//IL_210f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2119: Expected O, but got Unknown
		//IL_2120: Unknown result type (might be due to invalid IL or missing references)
		//IL_212a: Expected O, but got Unknown
		//IL_2137: Unknown result type (might be due to invalid IL or missing references)
		//IL_2141: Expected O, but got Unknown
		//IL_2148: Unknown result type (might be due to invalid IL or missing references)
		//IL_2152: Expected O, but got Unknown
		//IL_215f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2169: Expected O, but got Unknown
		//IL_2170: Unknown result type (might be due to invalid IL or missing references)
		//IL_217a: Expected O, but got Unknown
		//IL_2187: Unknown result type (might be due to invalid IL or missing references)
		//IL_2191: Expected O, but got Unknown
		//IL_2198: Unknown result type (might be due to invalid IL or missing references)
		//IL_21a2: Expected O, but got Unknown
		//IL_21af: Unknown result type (might be due to invalid IL or missing references)
		//IL_21b9: Expected O, but got Unknown
		//IL_21c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_21ca: Expected O, but got Unknown
		//IL_21d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_21e1: Expected O, but got Unknown
		//IL_21e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_21f2: Expected O, but got Unknown
		//IL_21ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_2209: Expected O, but got Unknown
		//IL_2210: Unknown result type (might be due to invalid IL or missing references)
		//IL_221a: Expected O, but got Unknown
		//IL_2227: Unknown result type (might be due to invalid IL or missing references)
		//IL_2231: Expected O, but got Unknown
		//IL_2238: Unknown result type (might be due to invalid IL or missing references)
		//IL_2242: Expected O, but got Unknown
		//IL_224f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2259: Expected O, but got Unknown
		//IL_2260: Unknown result type (might be due to invalid IL or missing references)
		//IL_226a: Expected O, but got Unknown
		//IL_2277: Unknown result type (might be due to invalid IL or missing references)
		//IL_2281: Expected O, but got Unknown
		//IL_2288: Unknown result type (might be due to invalid IL or missing references)
		//IL_2292: Expected O, but got Unknown
		//IL_229f: Unknown result type (might be due to invalid IL or missing references)
		//IL_22a9: Expected O, but got Unknown
		//IL_22b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_22ba: Expected O, but got Unknown
		//IL_22c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_22d1: Expected O, but got Unknown
		//IL_22d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_22e2: Expected O, but got Unknown
		//IL_22ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_22f9: Expected O, but got Unknown
		//IL_2300: Unknown result type (might be due to invalid IL or missing references)
		//IL_230a: Expected O, but got Unknown
		//IL_2317: Unknown result type (might be due to invalid IL or missing references)
		//IL_2321: Expected O, but got Unknown
		//IL_2328: Unknown result type (might be due to invalid IL or missing references)
		//IL_2332: Expected O, but got Unknown
		//IL_233f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2349: Expected O, but got Unknown
		//IL_2350: Unknown result type (might be due to invalid IL or missing references)
		//IL_235a: Expected O, but got Unknown
		//IL_2367: Unknown result type (might be due to invalid IL or missing references)
		//IL_2371: Expected O, but got Unknown
		//IL_2378: Unknown result type (might be due to invalid IL or missing references)
		//IL_2382: Expected O, but got Unknown
		//IL_238f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2399: Expected O, but got Unknown
		//IL_23a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_23aa: Expected O, but got Unknown
		//IL_23b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_23c1: Expected O, but got Unknown
		//IL_23c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_23d2: Expected O, but got Unknown
		//IL_23df: Unknown result type (might be due to invalid IL or missing references)
		//IL_23e9: Expected O, but got Unknown
		//IL_23f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_23fa: Expected O, but got Unknown
		//IL_2407: Unknown result type (might be due to invalid IL or missing references)
		//IL_2411: Expected O, but got Unknown
		//IL_2418: Unknown result type (might be due to invalid IL or missing references)
		//IL_2422: Expected O, but got Unknown
		//IL_242f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2439: Expected O, but got Unknown
		//IL_2440: Unknown result type (might be due to invalid IL or missing references)
		//IL_244a: Expected O, but got Unknown
		//IL_2457: Unknown result type (might be due to invalid IL or missing references)
		//IL_2461: Expected O, but got Unknown
		//IL_2468: Unknown result type (might be due to invalid IL or missing references)
		//IL_2472: Expected O, but got Unknown
		//IL_247f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2489: Expected O, but got Unknown
		//IL_2490: Unknown result type (might be due to invalid IL or missing references)
		//IL_249a: Expected O, but got Unknown
		//IL_24a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_24b1: Expected O, but got Unknown
		//IL_24b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_24c2: Expected O, but got Unknown
		//IL_24cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_24d9: Expected O, but got Unknown
		//IL_24e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_24ea: Expected O, but got Unknown
		//IL_24f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2501: Expected O, but got Unknown
		//IL_2508: Unknown result type (might be due to invalid IL or missing references)
		//IL_2512: Expected O, but got Unknown
		//IL_251f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2529: Expected O, but got Unknown
		//IL_2530: Unknown result type (might be due to invalid IL or missing references)
		//IL_253a: Expected O, but got Unknown
		//IL_2547: Unknown result type (might be due to invalid IL or missing references)
		//IL_2551: Expected O, but got Unknown
		//IL_2558: Unknown result type (might be due to invalid IL or missing references)
		//IL_2562: Expected O, but got Unknown
		//IL_256f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2579: Expected O, but got Unknown
		//IL_2580: Unknown result type (might be due to invalid IL or missing references)
		//IL_258a: Expected O, but got Unknown
		//IL_2597: Unknown result type (might be due to invalid IL or missing references)
		//IL_25a1: Expected O, but got Unknown
		//IL_25a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_25b2: Expected O, but got Unknown
		//IL_25bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_25c9: Expected O, but got Unknown
		//IL_25d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_25da: Expected O, but got Unknown
		//IL_25e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_25f1: Expected O, but got Unknown
		//IL_25f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2602: Expected O, but got Unknown
		//IL_260f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2619: Expected O, but got Unknown
		//IL_2620: Unknown result type (might be due to invalid IL or missing references)
		//IL_262a: Expected O, but got Unknown
		//IL_2637: Unknown result type (might be due to invalid IL or missing references)
		//IL_2641: Expected O, but got Unknown
		//IL_2648: Unknown result type (might be due to invalid IL or missing references)
		//IL_2652: Expected O, but got Unknown
		//IL_265f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2669: Expected O, but got Unknown
		//IL_2670: Unknown result type (might be due to invalid IL or missing references)
		//IL_267a: Expected O, but got Unknown
		//IL_2687: Unknown result type (might be due to invalid IL or missing references)
		//IL_2691: Expected O, but got Unknown
		//IL_2698: Unknown result type (might be due to invalid IL or missing references)
		//IL_26a2: Expected O, but got Unknown
		//IL_26af: Unknown result type (might be due to invalid IL or missing references)
		//IL_26b9: Expected O, but got Unknown
		//IL_26c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_26ca: Expected O, but got Unknown
		//IL_26d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_26e1: Expected O, but got Unknown
		//IL_26e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_26f2: Expected O, but got Unknown
		//IL_26ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_2709: Expected O, but got Unknown
		//IL_2710: Unknown result type (might be due to invalid IL or missing references)
		//IL_271a: Expected O, but got Unknown
		//IL_2727: Unknown result type (might be due to invalid IL or missing references)
		//IL_2731: Expected O, but got Unknown
		//IL_2738: Unknown result type (might be due to invalid IL or missing references)
		//IL_2742: Expected O, but got Unknown
		//IL_274f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2759: Expected O, but got Unknown
		//IL_2760: Unknown result type (might be due to invalid IL or missing references)
		//IL_276a: Expected O, but got Unknown
		//IL_2777: Unknown result type (might be due to invalid IL or missing references)
		//IL_2781: Expected O, but got Unknown
		//IL_2788: Unknown result type (might be due to invalid IL or missing references)
		//IL_2792: Expected O, but got Unknown
		//IL_279f: Unknown result type (might be due to invalid IL or missing references)
		//IL_27a9: Expected O, but got Unknown
		//IL_27b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_27ba: Expected O, but got Unknown
		//IL_27c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_27d1: Expected O, but got Unknown
		//IL_27d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_27e2: Expected O, but got Unknown
		//IL_27ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_27f9: Expected O, but got Unknown
		//IL_2800: Unknown result type (might be due to invalid IL or missing references)
		//IL_280a: Expected O, but got Unknown
		//IL_2817: Unknown result type (might be due to invalid IL or missing references)
		//IL_2821: Expected O, but got Unknown
		//IL_2828: Unknown result type (might be due to invalid IL or missing references)
		//IL_2832: Expected O, but got Unknown
		//IL_283f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2849: Expected O, but got Unknown
		//IL_2850: Unknown result type (might be due to invalid IL or missing references)
		//IL_285a: Expected O, but got Unknown
		//IL_2867: Unknown result type (might be due to invalid IL or missing references)
		//IL_2871: Expected O, but got Unknown
		//IL_2878: Unknown result type (might be due to invalid IL or missing references)
		//IL_2882: Expected O, but got Unknown
		//IL_288f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2899: Expected O, but got Unknown
		//IL_28a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_28aa: Expected O, but got Unknown
		//IL_28b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_28c1: Expected O, but got Unknown
		//IL_28c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_28d2: Expected O, but got Unknown
		//IL_28df: Unknown result type (might be due to invalid IL or missing references)
		//IL_28e9: Expected O, but got Unknown
		//IL_28f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_28fa: Expected O, but got Unknown
		//IL_2907: Unknown result type (might be due to invalid IL or missing references)
		//IL_2911: Expected O, but got Unknown
		//IL_2918: Unknown result type (might be due to invalid IL or missing references)
		//IL_2922: Expected O, but got Unknown
		//IL_292f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2939: Expected O, but got Unknown
		//IL_2940: Unknown result type (might be due to invalid IL or missing references)
		//IL_294a: Expected O, but got Unknown
		//IL_2957: Unknown result type (might be due to invalid IL or missing references)
		//IL_2961: Expected O, but got Unknown
		//IL_2968: Unknown result type (might be due to invalid IL or missing references)
		//IL_2972: Expected O, but got Unknown
		//IL_297f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2989: Expected O, but got Unknown
		//IL_2990: Unknown result type (might be due to invalid IL or missing references)
		//IL_299a: Expected O, but got Unknown
		//IL_29a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_29b1: Expected O, but got Unknown
		//IL_29b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_29c2: Expected O, but got Unknown
		//IL_29cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_29d9: Expected O, but got Unknown
		//IL_29e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_29ea: Expected O, but got Unknown
		//IL_29f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a01: Expected O, but got Unknown
		//IL_2a08: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a12: Expected O, but got Unknown
		//IL_2a1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a29: Expected O, but got Unknown
		//IL_2a30: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a3a: Expected O, but got Unknown
		//IL_2a47: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a51: Expected O, but got Unknown
		//IL_2a58: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a62: Expected O, but got Unknown
		//IL_2a6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a79: Expected O, but got Unknown
		//IL_2a80: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a8a: Expected O, but got Unknown
		//IL_2a97: Unknown result type (might be due to invalid IL or missing references)
		//IL_2aa1: Expected O, but got Unknown
		//IL_2aa8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ab2: Expected O, but got Unknown
		//IL_2abf: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ac9: Expected O, but got Unknown
		//IL_2ad0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ada: Expected O, but got Unknown
		//IL_2ae7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2af1: Expected O, but got Unknown
		//IL_2af8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b02: Expected O, but got Unknown
		//IL_2b0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b19: Expected O, but got Unknown
		//IL_2b20: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b2a: Expected O, but got Unknown
		//IL_2b37: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b41: Expected O, but got Unknown
		//IL_2b48: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b52: Expected O, but got Unknown
		//IL_2b5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b69: Expected O, but got Unknown
		//IL_2b70: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b7a: Expected O, but got Unknown
		//IL_2b87: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b91: Expected O, but got Unknown
		//IL_2b98: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ba2: Expected O, but got Unknown
		//IL_2baf: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bb9: Expected O, but got Unknown
		//IL_2bc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bca: Expected O, but got Unknown
		//IL_2bd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2be1: Expected O, but got Unknown
		//IL_2be8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bf2: Expected O, but got Unknown
		//IL_2bff: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c09: Expected O, but got Unknown
		//IL_2c10: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c1a: Expected O, but got Unknown
		//IL_2c27: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c31: Expected O, but got Unknown
		//IL_2c38: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c42: Expected O, but got Unknown
		//IL_2c4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c59: Expected O, but got Unknown
		//IL_2c60: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c6a: Expected O, but got Unknown
		//IL_2c77: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c81: Expected O, but got Unknown
		//IL_2c88: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c92: Expected O, but got Unknown
		//IL_2c9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ca9: Expected O, but got Unknown
		//IL_2cb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cba: Expected O, but got Unknown
		//IL_2cc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cd1: Expected O, but got Unknown
		//IL_2cd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ce2: Expected O, but got Unknown
		//IL_2ce9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cf3: Expected O, but got Unknown
		//IL_2cfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d04: Expected O, but got Unknown
		//IL_2d0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d15: Expected O, but got Unknown
		//IL_2d1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d26: Expected O, but got Unknown
		//IL_2d2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d37: Expected O, but got Unknown
		//IL_2d3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d48: Expected O, but got Unknown
		//IL_2d4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d59: Expected O, but got Unknown
		//IL_2d60: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d6a: Expected O, but got Unknown
		//IL_2d71: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d7b: Expected O, but got Unknown
		//IL_2d81: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d97: Expected O, but got Unknown
		//IL_2d9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2da9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2db3: Expected O, but got Unknown
		//IL_2db9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dcf: Expected O, but got Unknown
		//IL_2dd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2de1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2deb: Expected O, but got Unknown
		//IL_2df2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dfc: Expected O, but got Unknown
		//IL_2e03: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e0d: Expected O, but got Unknown
		//IL_2e1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e24: Expected O, but got Unknown
		//IL_2e2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e35: Expected O, but got Unknown
		//IL_2e42: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e4c: Expected O, but got Unknown
		//IL_2e53: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e5d: Expected O, but got Unknown
		//IL_2e6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e74: Expected O, but got Unknown
		//IL_2e7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e85: Expected O, but got Unknown
		//IL_2e92: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e9c: Expected O, but got Unknown
		//IL_2ea3: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ead: Expected O, but got Unknown
		//IL_2eba: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ec4: Expected O, but got Unknown
		//IL_2ecb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ed5: Expected O, but got Unknown
		//IL_2ee2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2eec: Expected O, but got Unknown
		//IL_2ef3: Unknown result type (might be due to invalid IL or missing references)
		//IL_2efd: Expected O, but got Unknown
		//IL_2f0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f14: Expected O, but got Unknown
		//IL_2f1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f25: Expected O, but got Unknown
		//IL_2f32: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f3c: Expected O, but got Unknown
		//IL_2f43: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f4d: Expected O, but got Unknown
		//IL_2f5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f64: Expected O, but got Unknown
		//IL_2f6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f75: Expected O, but got Unknown
		//IL_2f82: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f8c: Expected O, but got Unknown
		//IL_2f93: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f9d: Expected O, but got Unknown
		//IL_2faa: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fb4: Expected O, but got Unknown
		//IL_2fbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fc5: Expected O, but got Unknown
		//IL_2fd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fdc: Expected O, but got Unknown
		//IL_2fe3: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fed: Expected O, but got Unknown
		//IL_2ff4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ffe: Expected O, but got Unknown
		//IL_300b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3015: Expected O, but got Unknown
		//IL_301c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3026: Expected O, but got Unknown
		//IL_302d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3037: Expected O, but got Unknown
		//IL_3044: Unknown result type (might be due to invalid IL or missing references)
		//IL_304e: Expected O, but got Unknown
		//IL_3055: Unknown result type (might be due to invalid IL or missing references)
		//IL_305f: Expected O, but got Unknown
		//IL_3066: Unknown result type (might be due to invalid IL or missing references)
		//IL_3070: Expected O, but got Unknown
		//IL_307d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3087: Expected O, but got Unknown
		//IL_3094: Unknown result type (might be due to invalid IL or missing references)
		//IL_309e: Expected O, but got Unknown
		//IL_30a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_30af: Expected O, but got Unknown
		//IL_30b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_30c0: Expected O, but got Unknown
		//IL_30cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_30d7: Expected O, but got Unknown
		//IL_30e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_30ee: Expected O, but got Unknown
		//IL_30f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_3100: Unknown result type (might be due to invalid IL or missing references)
		//IL_310a: Expected O, but got Unknown
		//IL_3110: Unknown result type (might be due to invalid IL or missing references)
		//IL_311c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3126: Expected O, but got Unknown
		//IL_312c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3138: Unknown result type (might be due to invalid IL or missing references)
		//IL_3142: Expected O, but got Unknown
		//IL_3148: Unknown result type (might be due to invalid IL or missing references)
		//IL_3154: Unknown result type (might be due to invalid IL or missing references)
		//IL_315e: Expected O, but got Unknown
		//IL_3164: Unknown result type (might be due to invalid IL or missing references)
		//IL_3170: Unknown result type (might be due to invalid IL or missing references)
		//IL_317a: Expected O, but got Unknown
		//IL_3180: Unknown result type (might be due to invalid IL or missing references)
		//IL_318c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3196: Expected O, but got Unknown
		//IL_319c: Unknown result type (might be due to invalid IL or missing references)
		//IL_31a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_31b2: Expected O, but got Unknown
		//IL_31b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_31c3: Expected O, but got Unknown
		//IL_31d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_31da: Expected O, but got Unknown
		//IL_31e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_31eb: Expected O, but got Unknown
		//IL_31f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_31fc: Expected O, but got Unknown
		//IL_3209: Unknown result type (might be due to invalid IL or missing references)
		//IL_3213: Expected O, but got Unknown
		//IL_321a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3224: Expected O, but got Unknown
		//IL_3231: Unknown result type (might be due to invalid IL or missing references)
		//IL_323b: Expected O, but got Unknown
		//IL_3242: Unknown result type (might be due to invalid IL or missing references)
		//IL_324c: Expected O, but got Unknown
		//IL_3259: Unknown result type (might be due to invalid IL or missing references)
		//IL_3263: Expected O, but got Unknown
		//IL_326a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3274: Expected O, but got Unknown
		//IL_327b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3285: Expected O, but got Unknown
		//IL_3292: Unknown result type (might be due to invalid IL or missing references)
		//IL_329c: Expected O, but got Unknown
		//IL_32a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_32ad: Expected O, but got Unknown
		//IL_32ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_32c4: Expected O, but got Unknown
		//IL_32cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_32d5: Expected O, but got Unknown
		//IL_32e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_32ec: Expected O, but got Unknown
		//IL_32f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_32fd: Expected O, but got Unknown
		//IL_330a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3314: Expected O, but got Unknown
		//IL_331b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3325: Expected O, but got Unknown
		//IL_3332: Unknown result type (might be due to invalid IL or missing references)
		//IL_333c: Expected O, but got Unknown
		//IL_3343: Unknown result type (might be due to invalid IL or missing references)
		//IL_334d: Expected O, but got Unknown
		//IL_335a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3364: Expected O, but got Unknown
		//IL_336b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3375: Expected O, but got Unknown
		//IL_337c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3386: Expected O, but got Unknown
		//IL_338d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3397: Expected O, but got Unknown
		//IL_339e: Unknown result type (might be due to invalid IL or missing references)
		//IL_33a8: Expected O, but got Unknown
		//IL_33b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_33bf: Expected O, but got Unknown
		//IL_33cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_33d6: Expected O, but got Unknown
		//IL_33dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_33e7: Expected O, but got Unknown
		//IL_33ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_33f8: Expected O, but got Unknown
		//IL_33ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_3409: Expected O, but got Unknown
		//IL_3416: Unknown result type (might be due to invalid IL or missing references)
		//IL_3420: Expected O, but got Unknown
		//IL_3427: Unknown result type (might be due to invalid IL or missing references)
		//IL_3431: Expected O, but got Unknown
		//IL_3438: Unknown result type (might be due to invalid IL or missing references)
		//IL_3442: Expected O, but got Unknown
		//IL_344f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3459: Expected O, but got Unknown
		//IL_3466: Unknown result type (might be due to invalid IL or missing references)
		//IL_3470: Expected O, but got Unknown
		//IL_3477: Unknown result type (might be due to invalid IL or missing references)
		//IL_3481: Expected O, but got Unknown
		//IL_3488: Unknown result type (might be due to invalid IL or missing references)
		//IL_3492: Expected O, but got Unknown
		//IL_3499: Unknown result type (might be due to invalid IL or missing references)
		//IL_34a3: Expected O, but got Unknown
		//IL_34aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_34b4: Expected O, but got Unknown
		//IL_34bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_34c5: Expected O, but got Unknown
		//IL_34d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_34dc: Expected O, but got Unknown
		//IL_34e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_34ed: Expected O, but got Unknown
		//IL_34fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_3504: Expected O, but got Unknown
		//IL_350b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3515: Expected O, but got Unknown
		//IL_351c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3526: Expected O, but got Unknown
		//IL_352d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3537: Expected O, but got Unknown
		//IL_3544: Unknown result type (might be due to invalid IL or missing references)
		//IL_354e: Expected O, but got Unknown
		//IL_3555: Unknown result type (might be due to invalid IL or missing references)
		//IL_355f: Expected O, but got Unknown
		//IL_356c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3576: Expected O, but got Unknown
		//IL_357d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3587: Expected O, but got Unknown
		//IL_3594: Unknown result type (might be due to invalid IL or missing references)
		//IL_359e: Expected O, but got Unknown
		//IL_35a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_35af: Expected O, but got Unknown
		//IL_35b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_35c0: Expected O, but got Unknown
		//IL_35c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_35d1: Expected O, but got Unknown
		//IL_35d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_35e2: Expected O, but got Unknown
		//IL_35ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_35f9: Expected O, but got Unknown
		//IL_3600: Unknown result type (might be due to invalid IL or missing references)
		//IL_360a: Expected O, but got Unknown
		//IL_3617: Unknown result type (might be due to invalid IL or missing references)
		//IL_3621: Expected O, but got Unknown
		//IL_3628: Unknown result type (might be due to invalid IL or missing references)
		//IL_3632: Expected O, but got Unknown
		//IL_363f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3649: Expected O, but got Unknown
		//IL_3650: Unknown result type (might be due to invalid IL or missing references)
		//IL_365a: Expected O, but got Unknown
		//IL_3667: Unknown result type (might be due to invalid IL or missing references)
		//IL_3671: Expected O, but got Unknown
		//IL_367e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3688: Expected O, but got Unknown
		//IL_368f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3699: Expected O, but got Unknown
		//IL_36a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_36aa: Expected O, but got Unknown
		//IL_36b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_36c1: Expected O, but got Unknown
		//IL_36c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_36d2: Expected O, but got Unknown
		//IL_36d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_36e3: Expected O, but got Unknown
		//IL_36f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_36fa: Expected O, but got Unknown
		//IL_3701: Unknown result type (might be due to invalid IL or missing references)
		//IL_370b: Expected O, but got Unknown
		//IL_3718: Unknown result type (might be due to invalid IL or missing references)
		//IL_3722: Expected O, but got Unknown
		//IL_3729: Unknown result type (might be due to invalid IL or missing references)
		//IL_3733: Expected O, but got Unknown
		//IL_3740: Unknown result type (might be due to invalid IL or missing references)
		//IL_374a: Expected O, but got Unknown
		//IL_3751: Unknown result type (might be due to invalid IL or missing references)
		//IL_375b: Expected O, but got Unknown
		//IL_3768: Unknown result type (might be due to invalid IL or missing references)
		//IL_3772: Expected O, but got Unknown
		//IL_3779: Unknown result type (might be due to invalid IL or missing references)
		//IL_3783: Expected O, but got Unknown
		//IL_3790: Unknown result type (might be due to invalid IL or missing references)
		//IL_379a: Expected O, but got Unknown
		//IL_37a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_37ab: Expected O, but got Unknown
		//IL_37b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_37c2: Expected O, but got Unknown
		//IL_37c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_37d3: Expected O, but got Unknown
		//IL_37e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_37ea: Expected O, but got Unknown
		//IL_37f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_37fb: Expected O, but got Unknown
		//IL_3808: Unknown result type (might be due to invalid IL or missing references)
		//IL_3812: Expected O, but got Unknown
		//IL_3819: Unknown result type (might be due to invalid IL or missing references)
		//IL_3823: Expected O, but got Unknown
		//IL_3830: Unknown result type (might be due to invalid IL or missing references)
		//IL_383a: Expected O, but got Unknown
		//IL_3841: Unknown result type (might be due to invalid IL or missing references)
		//IL_384b: Expected O, but got Unknown
		//IL_3858: Unknown result type (might be due to invalid IL or missing references)
		//IL_3862: Expected O, but got Unknown
		//IL_3869: Unknown result type (might be due to invalid IL or missing references)
		//IL_3873: Expected O, but got Unknown
		//IL_3880: Unknown result type (might be due to invalid IL or missing references)
		//IL_388a: Expected O, but got Unknown
		//IL_3891: Unknown result type (might be due to invalid IL or missing references)
		//IL_389b: Expected O, but got Unknown
		//IL_38a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_38b2: Expected O, but got Unknown
		//IL_38b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_38c3: Expected O, but got Unknown
		//IL_38d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_38da: Expected O, but got Unknown
		//IL_38e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_38eb: Expected O, but got Unknown
		//IL_38f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_38fc: Expected O, but got Unknown
		//IL_3909: Unknown result type (might be due to invalid IL or missing references)
		//IL_3913: Expected O, but got Unknown
		//IL_391a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3924: Expected O, but got Unknown
		//IL_3931: Unknown result type (might be due to invalid IL or missing references)
		//IL_393b: Expected O, but got Unknown
		//IL_3942: Unknown result type (might be due to invalid IL or missing references)
		//IL_394c: Expected O, but got Unknown
		//IL_3953: Unknown result type (might be due to invalid IL or missing references)
		//IL_395d: Expected O, but got Unknown
		//IL_3964: Unknown result type (might be due to invalid IL or missing references)
		//IL_396e: Expected O, but got Unknown
		//IL_397b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3985: Expected O, but got Unknown
		//IL_398c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3996: Expected O, but got Unknown
		//IL_39a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_39ad: Expected O, but got Unknown
		//IL_39b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_39be: Expected O, but got Unknown
		//IL_39cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_39d5: Expected O, but got Unknown
		//IL_39dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_39e6: Expected O, but got Unknown
		//IL_39f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_39fd: Expected O, but got Unknown
		//IL_3a04: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a0e: Expected O, but got Unknown
		//IL_3a1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a25: Expected O, but got Unknown
		//IL_3a2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a36: Expected O, but got Unknown
		//IL_3a3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a47: Expected O, but got Unknown
		//IL_3a54: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a5e: Expected O, but got Unknown
		//IL_3a65: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a6f: Expected O, but got Unknown
		//IL_3a76: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a80: Expected O, but got Unknown
		//IL_3a8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a97: Expected O, but got Unknown
		//IL_3a9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3aa8: Expected O, but got Unknown
		//IL_3aaf: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ab9: Expected O, but got Unknown
		//IL_3ac0: Unknown result type (might be due to invalid IL or missing references)
		//IL_3aca: Expected O, but got Unknown
		//IL_3ad1: Unknown result type (might be due to invalid IL or missing references)
		//IL_3adb: Expected O, but got Unknown
		//IL_3ae2: Unknown result type (might be due to invalid IL or missing references)
		//IL_3aec: Expected O, but got Unknown
		//IL_3af9: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b03: Expected O, but got Unknown
		//IL_3b0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b14: Expected O, but got Unknown
		//IL_3b1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b25: Expected O, but got Unknown
		//IL_3b32: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b3c: Expected O, but got Unknown
		//IL_3b43: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b4d: Expected O, but got Unknown
		//IL_3b54: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b5e: Expected O, but got Unknown
		//IL_3b6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b75: Expected O, but got Unknown
		//IL_3b7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b86: Expected O, but got Unknown
		//IL_3b8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b97: Expected O, but got Unknown
		//IL_3ba4: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bae: Expected O, but got Unknown
		//IL_3bb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bbf: Expected O, but got Unknown
		//IL_3bc6: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bd0: Expected O, but got Unknown
		//IL_3bdd: Unknown result type (might be due to invalid IL or missing references)
		//IL_3be7: Expected O, but got Unknown
		//IL_3bee: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bf8: Expected O, but got Unknown
		//IL_3c1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c26: Expected O, but got Unknown
		//IL_3c2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c37: Expected O, but got Unknown
		//IL_3c3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c48: Expected O, but got Unknown
		//IL_3c55: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c5f: Expected O, but got Unknown
		//IL_3c66: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c70: Expected O, but got Unknown
		//IL_3c77: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c81: Expected O, but got Unknown
		//IL_3c88: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c92: Expected O, but got Unknown
		//IL_3c99: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ca3: Expected O, but got Unknown
		//IL_3caa: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cb4: Expected O, but got Unknown
		//IL_3cbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cc5: Expected O, but got Unknown
		//IL_3cd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cdc: Expected O, but got Unknown
		//IL_3ce3: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ced: Expected O, but got Unknown
		//IL_3cf4: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cfe: Expected O, but got Unknown
		//IL_3d0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d15: Expected O, but got Unknown
		//IL_3d22: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d2c: Expected O, but got Unknown
		//IL_3d33: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d3d: Expected O, but got Unknown
		//IL_3d44: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d4e: Expected O, but got Unknown
		//IL_3d61: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d6b: Expected O, but got Unknown
		//IL_3d78: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d82: Expected O, but got Unknown
		//IL_3d89: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d93: Expected O, but got Unknown
		//IL_3da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_3daa: Expected O, but got Unknown
		//IL_3db1: Unknown result type (might be due to invalid IL or missing references)
		//IL_3dbb: Expected O, but got Unknown
		//IL_3dc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_3dcc: Expected O, but got Unknown
		//IL_3dd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ddd: Expected O, but got Unknown
		//IL_3de4: Unknown result type (might be due to invalid IL or missing references)
		//IL_3dee: Expected O, but got Unknown
		//IL_3dfb: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e05: Expected O, but got Unknown
		//IL_3e0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e16: Expected O, but got Unknown
		//IL_3e1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e27: Expected O, but got Unknown
		//IL_3e34: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e3e: Expected O, but got Unknown
		//IL_3e45: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e4f: Expected O, but got Unknown
		//IL_3e5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e66: Expected O, but got Unknown
		//IL_3e6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e77: Expected O, but got Unknown
		//IL_3e84: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e8e: Expected O, but got Unknown
		//IL_3e95: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e9f: Expected O, but got Unknown
		//IL_3ea6: Unknown result type (might be due to invalid IL or missing references)
		//IL_3eb0: Expected O, but got Unknown
		//IL_3ebd: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ec7: Expected O, but got Unknown
		//IL_3ece: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ed8: Expected O, but got Unknown
		//IL_3ee5: Unknown result type (might be due to invalid IL or missing references)
		//IL_3eef: Expected O, but got Unknown
		//IL_3ef6: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f00: Expected O, but got Unknown
		//IL_3f0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f17: Expected O, but got Unknown
		//IL_3f1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f28: Expected O, but got Unknown
		//IL_3f35: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f3f: Expected O, but got Unknown
		//IL_3f43: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f4d: Expected O, but got Unknown
		//IL_3f5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f64: Expected O, but got Unknown
		//IL_3f71: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f7b: Expected O, but got Unknown
		//IL_3f88: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f92: Expected O, but got Unknown
		//IL_3f96: Unknown result type (might be due to invalid IL or missing references)
		//IL_3fa0: Expected O, but got Unknown
		//IL_3fa4: Unknown result type (might be due to invalid IL or missing references)
		//IL_3fae: Expected O, but got Unknown
		switch (connectionId)
		{
		case 1:
			((Window)(PowerDeskApp2014)target).add_Closing((CancelEventHandler)Window_Closing);
			((UIElement)(PowerDeskApp2014)target).add_IsVisibleChanged(new DependencyPropertyChangedEventHandler(Window_IsVisibleChanged));
			break;
		case 2:
			LayoutRoot = (Grid)target;
			break;
		case 3:
			tBar = (TextBlock)target;
			break;
		case 4:
			textBox1 = (TextBox)target;
			break;
		case 5:
			progressBar1 = (ProgressBar)target;
			break;
		case 6:
			mnuAgreeCostFunctionUse = (MenuItem)target;
			mnuAgreeCostFunctionUse.add_Click(new RoutedEventHandler(mnuAgreeCostFunctionUse_Click));
			break;
		case 7:
			mnuTest = (MenuItem)target;
			mnuTest.add_Click(new RoutedEventHandler(mnuReadRTF_Click));
			break;
		case 8:
			mnuUseHashCalc = (MenuItem)target;
			mnuUseHashCalc.add_Click(new RoutedEventHandler(mnuUseHash_Click));
			break;
		case 9:
			mnuUAC_chk = (MenuItem)target;
			mnuUAC_chk.add_Click(new RoutedEventHandler(mnuUAC_chk_Click));
			break;
		case 10:
			mnuTimeSynch_chk = (MenuItem)target;
			mnuTimeSynch_chk.add_Click(new RoutedEventHandler(mnuTimeSynch_chk_Click));
			break;
		case 11:
			mnuCheckUpdate = (MenuItem)target;
			mnuCheckUpdate.add_Click(new RoutedEventHandler(mnuCheckUpdate_Click));
			break;
		case 12:
			mnuExit = (MenuItem)target;
			mnuExit.add_Click(new RoutedEventHandler(mnuExit_Click));
			break;
		case 13:
			mnuVaccine = (MenuItem)target;
			break;
		case 14:
			mnuVacc0 = (MenuItem)target;
			mnuVacc0.add_Click(new RoutedEventHandler(mnuVacc0_Click));
			break;
		case 15:
			mnuVaccALL = (MenuItem)target;
			mnuVaccALL.add_Click(new RoutedEventHandler(mnuVaccALL_Click));
			break;
		case 16:
			mnuVaccALLUInew = (MenuItem)target;
			mnuVaccALLUInew.add_Click(new RoutedEventHandler(mnuVaccALLUInew_Click));
			break;
		case 17:
			mnuVacc30 = (MenuItem)target;
			mnuVacc30.add_Click(new RoutedEventHandler(mnuVacc30_Click));
			break;
		case 18:
			mnuVacc31 = (MenuItem)target;
			mnuVacc31.add_Click(new RoutedEventHandler(mnuVacc31_Click));
			break;
		case 19:
			mnuVacc32 = (MenuItem)target;
			mnuVacc32.add_Click(new RoutedEventHandler(mnuVacc32_Click));
			break;
		case 20:
			mnuVacc33 = (MenuItem)target;
			mnuVacc33.add_Click(new RoutedEventHandler(mnuVacc33_Click));
			break;
		case 21:
			mnuVacc1 = (MenuItem)target;
			mnuVacc1.add_Click(new RoutedEventHandler(mnuVacc1_Click));
			break;
		case 22:
			mnuVacc2 = (MenuItem)target;
			mnuVacc2.add_Click(new RoutedEventHandler(mnuVacc2_Click));
			break;
		case 23:
			mnuVacc3 = (MenuItem)target;
			mnuVacc3.add_Click(new RoutedEventHandler(mnuVacc3_Click));
			break;
		case 24:
			mnuVacc4 = (MenuItem)target;
			mnuVacc4.add_Click(new RoutedEventHandler(mnuVacc4_Click));
			break;
		case 25:
			mnuVacc5 = (MenuItem)target;
			mnuVacc5.add_Click(new RoutedEventHandler(mnuVacc5_Click));
			break;
		case 26:
			mnuVacc6 = (MenuItem)target;
			mnuVacc6.add_Click(new RoutedEventHandler(mnuVacc6_Click));
			break;
		case 27:
			mnuVacc7 = (MenuItem)target;
			mnuVacc7.add_Click(new RoutedEventHandler(mnuVacc7_Click));
			break;
		case 28:
			mnuVacc8 = (MenuItem)target;
			mnuVacc8.add_Click(new RoutedEventHandler(mnuVacc8_Click));
			break;
		case 29:
			mnuVacc9 = (MenuItem)target;
			mnuVacc9.add_Click(new RoutedEventHandler(mnuVacc9_Click));
			break;
		case 30:
			mnuVacc59 = (MenuItem)target;
			mnuVacc59.add_Click(new RoutedEventHandler(mnuVacc59_Click));
			break;
		case 31:
			mnuVacc10 = (MenuItem)target;
			mnuVacc10.add_Click(new RoutedEventHandler(mnuVacc10_Click));
			break;
		case 32:
			mnuVacc11 = (MenuItem)target;
			mnuVacc11.add_Click(new RoutedEventHandler(mnuVacc11_Click));
			break;
		case 33:
			mnuVacc49 = (MenuItem)target;
			mnuVacc49.add_Click(new RoutedEventHandler(mnuVacc49_Click));
			break;
		case 34:
			mnuVacc12 = (MenuItem)target;
			mnuVacc12.add_Click(new RoutedEventHandler(mnuVacc12_Click));
			break;
		case 35:
			mnuVacc13 = (MenuItem)target;
			mnuVacc13.add_Click(new RoutedEventHandler(mnuVacc13_Click));
			break;
		case 36:
			mnuVacc14 = (MenuItem)target;
			mnuVacc14.add_Click(new RoutedEventHandler(mnuVacc14_Click));
			break;
		case 37:
			mnuVacc15 = (MenuItem)target;
			mnuVacc15.add_Click(new RoutedEventHandler(mnuVacc15_Click));
			break;
		case 38:
			mnuVacc16 = (MenuItem)target;
			mnuVacc16.add_Click(new RoutedEventHandler(mnuVacc16_Click));
			break;
		case 39:
			mnuVacc17 = (MenuItem)target;
			mnuVacc17.add_Click(new RoutedEventHandler(mnuVacc17_Click));
			break;
		case 40:
			mnuVacc18 = (MenuItem)target;
			mnuVacc18.add_Click(new RoutedEventHandler(mnuVacc18_Click));
			break;
		case 41:
			mnuVacc19 = (MenuItem)target;
			mnuVacc19.add_Click(new RoutedEventHandler(mnuVacc19_Click));
			break;
		case 42:
			mnuVacc20 = (MenuItem)target;
			mnuVacc20.add_Click(new RoutedEventHandler(mnuVacc20_Click));
			break;
		case 43:
			mnuVacc21 = (MenuItem)target;
			mnuVacc21.add_Click(new RoutedEventHandler(mnuVacc21_Click));
			break;
		case 44:
			mnuVacc23 = (MenuItem)target;
			mnuVacc23.add_Click(new RoutedEventHandler(mnuVacc23_Click));
			break;
		case 45:
			mnuVacc24 = (MenuItem)target;
			mnuVacc24.add_Click(new RoutedEventHandler(mnuVacc24_Click));
			break;
		case 46:
			mnuVacc26 = (MenuItem)target;
			mnuVacc26.add_Click(new RoutedEventHandler(mnuVacc26_Click));
			break;
		case 47:
			mnuVacc27 = (MenuItem)target;
			mnuVacc27.add_Click(new RoutedEventHandler(mnuVacc27_Click));
			break;
		case 48:
			mnuVacc29 = (MenuItem)target;
			mnuVacc29.add_Click(new RoutedEventHandler(mnuVacc29_Click));
			break;
		case 49:
			mnuVacc34 = (MenuItem)target;
			mnuVacc34.add_Click(new RoutedEventHandler(mnuVacc34_Click));
			break;
		case 50:
			mnuVacc35 = (MenuItem)target;
			mnuVacc35.add_Click(new RoutedEventHandler(mnuVacc35_Click));
			break;
		case 51:
			mnuVacc36 = (MenuItem)target;
			mnuVacc36.add_Click(new RoutedEventHandler(mnuVacc40_Click));
			break;
		case 52:
			mnuVacc60 = (MenuItem)target;
			mnuVacc60.add_Click(new RoutedEventHandler(mnuVacc60_Click));
			break;
		case 53:
			mnuVacc41 = (MenuItem)target;
			mnuVacc41.add_Click(new RoutedEventHandler(mnuVacc41_Click));
			break;
		case 54:
			mnuVacc42 = (MenuItem)target;
			mnuVacc42.add_Click(new RoutedEventHandler(mnuVacc42_Click));
			break;
		case 55:
			mnuVacc43 = (MenuItem)target;
			mnuVacc43.add_Click(new RoutedEventHandler(mnuVacc43_Click));
			break;
		case 56:
			mnuVacc44 = (MenuItem)target;
			mnuVacc44.add_Click(new RoutedEventHandler(mnuVacc44_Click));
			break;
		case 57:
			mnuVacc45 = (MenuItem)target;
			mnuVacc45.add_Click(new RoutedEventHandler(mnuVacc45_Click));
			break;
		case 58:
			mnuVacc46 = (MenuItem)target;
			mnuVacc46.add_Click(new RoutedEventHandler(mnuVacc46_Click));
			break;
		case 59:
			mnuVacc47 = (MenuItem)target;
			mnuVacc47.add_Click(new RoutedEventHandler(mnuVacc47_Click));
			break;
		case 60:
			mnuVacc48 = (MenuItem)target;
			mnuVacc48.add_Click(new RoutedEventHandler(mnuVacc48_Click));
			break;
		case 61:
			mnuVacc50 = (MenuItem)target;
			mnuVacc50.add_Click(new RoutedEventHandler(mnuVacc50_Click));
			break;
		case 62:
			mnuVacc51 = (MenuItem)target;
			mnuVacc51.add_Click(new RoutedEventHandler(mnuVacc51_Click));
			break;
		case 63:
			mnuVacc52 = (MenuItem)target;
			mnuVacc52.add_Click(new RoutedEventHandler(mnuVacc52_Click));
			break;
		case 64:
			mnuVacc54 = (MenuItem)target;
			mnuVacc54.add_Click(new RoutedEventHandler(mnuVacc54_Click));
			break;
		case 65:
			mnuVacc55 = (MenuItem)target;
			mnuVacc55.add_Click(new RoutedEventHandler(mnuVacc55_Click));
			break;
		case 66:
			mnuVacc56 = (MenuItem)target;
			mnuVacc56.add_Click(new RoutedEventHandler(mnuVacc56_Click));
			break;
		case 67:
			mnuVacc57 = (MenuItem)target;
			mnuVacc57.add_Click(new RoutedEventHandler(mnuVacc57_Click));
			break;
		case 68:
			mnuVacc58 = (MenuItem)target;
			mnuVacc58.add_Click(new RoutedEventHandler(mnuVacc58_Click));
			break;
		case 69:
			mnuSecureUtil = (MenuItem)target;
			break;
		case 70:
			mnuSecureChuri = (MenuItem)target;
			mnuSecureChuri.add_Click(new RoutedEventHandler(mnuSecureChuri_Click));
			break;
		case 71:
			mnuShowFileExt = (MenuItem)target;
			mnuShowFileExt.add_Click(new RoutedEventHandler(mnuShowFileExt_Click));
			break;
		case 72:
			mnuServiceMng = (MenuItem)target;
			mnuServiceMng.add_Click(new RoutedEventHandler(mnuServiceMng_Click));
			break;
		case 73:
			mnuPU36 = (MenuItem)target;
			mnuPU36.add_Click(new RoutedEventHandler(mnuPU36_Click));
			break;
		case 74:
			mnuPU37 = (MenuItem)target;
			mnuPU37.add_Click(new RoutedEventHandler(mnuPU37_Click));
			break;
		case 75:
			mnuPU38 = (MenuItem)target;
			mnuPU38.add_Click(new RoutedEventHandler(mnuPU38_Click));
			break;
		case 76:
			mnuPU39 = (MenuItem)target;
			mnuPU39.add_Click(new RoutedEventHandler(mnuPU39_Click));
			break;
		case 77:
			mnuPU13 = (MenuItem)target;
			mnuPU13.add_Click(new RoutedEventHandler(mnuPU13_Click));
			break;
		case 78:
			mnuPU17 = (MenuItem)target;
			mnuPU17.add_Click(new RoutedEventHandler(mnuPU17_Click));
			break;
		case 79:
			mnuPU18 = (MenuItem)target;
			mnuPU18.add_Click(new RoutedEventHandler(mnuPU18_Click));
			break;
		case 80:
			mnuPU18a = (MenuItem)target;
			mnuPU18a.add_Click(new RoutedEventHandler(mnuPU18a_Click));
			break;
		case 81:
			mnuPU18b = (MenuItem)target;
			mnuPU18b.add_Click(new RoutedEventHandler(mnuPU18b_Click));
			break;
		case 82:
			mnuPU18c = (MenuItem)target;
			mnuPU18c.add_Click(new RoutedEventHandler(mnuPU18c_Click));
			break;
		case 83:
			mnuPU18d = (MenuItem)target;
			mnuPU18d.add_Click(new RoutedEventHandler(mnuPU18d_Click));
			break;
		case 84:
			mnuPU18e = (MenuItem)target;
			mnuPU18e.add_Click(new RoutedEventHandler(mnuPU18e_Click));
			break;
		case 85:
			mnuVacc22 = (MenuItem)target;
			mnuVacc22.add_Click(new RoutedEventHandler(mnuVacc22_Click));
			break;
		case 86:
			mnuPU18f = (MenuItem)target;
			mnuPU18f.add_Click(new RoutedEventHandler(mnuPU18f_Click));
			break;
		case 87:
			mnuPU18g = (MenuItem)target;
			mnuPU18g.add_Click(new RoutedEventHandler(mnuPU18g_Click));
			break;
		case 88:
			mnuPU18g1 = (MenuItem)target;
			mnuPU18g1.add_Click(new RoutedEventHandler(mnuPU18g1_Click));
			break;
		case 89:
			mnuPU18g2 = (MenuItem)target;
			mnuPU18g2.add_Click(new RoutedEventHandler(mnuPU18g2_Click));
			break;
		case 90:
			mnuPU18h = (MenuItem)target;
			mnuPU18h.add_Click(new RoutedEventHandler(mnuPU18h_Click));
			break;
		case 91:
			mnuPU19 = (MenuItem)target;
			mnuPU19.add_Click(new RoutedEventHandler(mnuPU19_Click));
			break;
		case 92:
			mnuPU20 = (MenuItem)target;
			mnuPU20.add_Click(new RoutedEventHandler(mnuPU20_Click));
			break;
		case 93:
			mnuVacc25 = (MenuItem)target;
			mnuVacc25.add_Click(new RoutedEventHandler(mnuVacc25_Click));
			break;
		case 94:
			mnuPU117 = (MenuItem)target;
			mnuPU117.add_Click(new RoutedEventHandler(mnuPU117_Click));
			break;
		case 95:
			mnuPU118 = (MenuItem)target;
			mnuPU118.add_Click(new RoutedEventHandler(mnuPU118_Click));
			break;
		case 96:
			mnuSecureLogon = (MenuItem)target;
			mnuSecureLogon.add_Click(new RoutedEventHandler(mnuSecureLogon_Click));
			break;
		case 97:
			mnuAdminNoActive = (MenuItem)target;
			mnuAdminNoActive.add_Click(new RoutedEventHandler(mnuAdminNoActive_Click));
			break;
		case 98:
			mnuSecureDriverInstall = (MenuItem)target;
			mnuSecureDriverInstall.add_Click(new RoutedEventHandler(mnuSecureDriverInstall_Click));
			break;
		case 99:
			mnuWMIC_User = (MenuItem)target;
			mnuWMIC_User.add_Click(new RoutedEventHandler(mnuWMIC_User_Click));
			break;
		case 100:
			mnuTMP = (MenuItem)target;
			mnuTMP.add_Click(new RoutedEventHandler(mnuTMP_Click));
			break;
		case 101:
			mnuRundll1 = (MenuItem)target;
			mnuRundll1.add_Click(new RoutedEventHandler(mnuRundll1_Click));
			break;
		case 102:
			mnuRundll2 = (MenuItem)target;
			mnuRundll2.add_Click(new RoutedEventHandler(mnuRundll2_Click));
			break;
		case 103:
			mnuMtuCheckSite = (MenuItem)target;
			mnuMtuCheckSite.add_Click(new RoutedEventHandler(mnuMtuCheckSite_Click));
			break;
		case 104:
			mnuShowTrayIcon = (MenuItem)target;
			mnuShowTrayIcon.add_Click(new RoutedEventHandler(mnuShowTrayIcon_Click));
			break;
		case 105:
			mnuDism = (MenuItem)target;
			mnuDism.add_Click(new RoutedEventHandler(mnuDism_Click));
			break;
		case 106:
			mnuSFC = (MenuItem)target;
			mnuSFC.add_Click(new RoutedEventHandler(mnuSFC_Click));
			break;
		case 107:
			mnuRecovoryInitTop = (MenuItem)target;
			break;
		case 108:
			mnuRecovoryInit = (MenuItem)target;
			mnuRecovoryInit.add_Click(new RoutedEventHandler(mnuRecovoryInit_Click));
			break;
		case 109:
			mnuRecovorySettings = (MenuItem)target;
			mnuRecovorySettings.add_Click(new RoutedEventHandler(mnuRecovorySettings_Click));
			break;
		case 110:
			mnuRecovoryJob = (MenuItem)target;
			mnuRecovoryJob.add_Click(new RoutedEventHandler(mnuRecovoryJob_Click));
			break;
		case 111:
			mnuDoRecovory = (MenuItem)target;
			mnuDoRecovory.add_Click(new RoutedEventHandler(mnuDoRecovory_Click));
			break;
		case 112:
			mnuPU25 = (MenuItem)target;
			break;
		case 113:
			mnuPU26 = (MenuItem)target;
			mnuPU26.add_Click(new RoutedEventHandler(mnuPU26_Click));
			break;
		case 114:
			mnuPU27 = (MenuItem)target;
			mnuPU27.add_Click(new RoutedEventHandler(mnuPU27_Click));
			break;
		case 115:
			mnuPU28 = (MenuItem)target;
			mnuPU28.add_Click(new RoutedEventHandler(mnuPU28_Click));
			break;
		case 116:
			mnuPU29 = (MenuItem)target;
			mnuPU29.add_Click(new RoutedEventHandler(mnuPU29_Click));
			break;
		case 117:
			mnuPU30 = (MenuItem)target;
			break;
		case 118:
			mnuPU31 = (MenuItem)target;
			mnuPU31.add_Click(new RoutedEventHandler(mnuPU31_Click));
			break;
		case 119:
			mnuPU32 = (MenuItem)target;
			mnuPU32.add_Click(new RoutedEventHandler(mnuPU32_Click));
			break;
		case 120:
			mnuWindowsDocs = (MenuItem)target;
			break;
		case 121:
			mnuWindowsSecurityEncyclopedia = (MenuItem)target;
			mnuWindowsSecurityEncyclopedia.add_Click(new RoutedEventHandler(mnuWindowsSecurityEncyclopedia_Click));
			break;
		case 122:
			mnuWindowsOSDocEncyclopedia = (MenuItem)target;
			mnuWindowsOSDocEncyclopedia.add_Click(new RoutedEventHandler(mnuWindowsOSDocEncyclopedia_Click));
			break;
		case 123:
			mnuUsableSite = (MenuItem)target;
			break;
		case 124:
			mnuMathSite = (MenuItem)target;
			mnuMathSite.add_Click(new RoutedEventHandler(mnuMathSite_Click));
			break;
		case 125:
			mnuMathSite2 = (MenuItem)target;
			mnuMathSite2.add_Click(new RoutedEventHandler(mnuMathSite2_Click));
			break;
		case 126:
			mnuMathCalcSite = (MenuItem)target;
			mnuMathCalcSite.add_Click(new RoutedEventHandler(mnuMathCalcSite_Click));
			break;
		case 127:
			mnuPocketQuiz = (MenuItem)target;
			mnuPocketQuiz.add_Click(new RoutedEventHandler(mnuPocketQuiz_Click));
			break;
		case 128:
			mnuShellCommandSearch = (MenuItem)target;
			mnuShellCommandSearch.add_Click(new RoutedEventHandler(mnuShellCommandSearch_Click));
			break;
		case 129:
			mnuShellCommandSearchResult = (MenuItem)target;
			break;
		case 130:
			mnuPU00 = (MenuItem)target;
			mnuPU00.add_Click(new RoutedEventHandler(mnuPU00_Click));
			break;
		case 131:
			mnuPU01 = (MenuItem)target;
			mnuPU01.add_Click(new RoutedEventHandler(mnuPU01_Click));
			break;
		case 132:
			mnuPU02 = (MenuItem)target;
			mnuPU02.add_Click(new RoutedEventHandler(mnuPU02_Click));
			break;
		case 133:
			mnuPU03 = (MenuItem)target;
			mnuPU03.add_Click(new RoutedEventHandler(mnuPU03_Click));
			break;
		case 134:
			mnuPU04 = (MenuItem)target;
			mnuPU04.add_Click(new RoutedEventHandler(mnuPU04_Click));
			break;
		case 135:
			mnuPU05 = (MenuItem)target;
			mnuPU05.add_Click(new RoutedEventHandler(mnuPU05_Click));
			break;
		case 136:
			mnuPU05A = (MenuItem)target;
			mnuPU05A.add_Click(new RoutedEventHandler(mnuPU05A_Click));
			break;
		case 137:
			mnuPU07 = (MenuItem)target;
			mnuPU07.add_Click(new RoutedEventHandler(mnuPU07_Click));
			break;
		case 138:
			mnuPU07_1 = (MenuItem)target;
			mnuPU07_1.add_Click(new RoutedEventHandler(mnuPU07_1_Click));
			break;
		case 139:
			mnuPU07_2 = (MenuItem)target;
			mnuPU07_2.add_Click(new RoutedEventHandler(mnuPU07_2_Click));
			break;
		case 140:
			mnuPU08 = (MenuItem)target;
			mnuPU08.add_Click(new RoutedEventHandler(mnuPU08_Click));
			break;
		case 141:
			mnuPU09 = (MenuItem)target;
			mnuPU09.add_Click(new RoutedEventHandler(mnuPU09_Click));
			break;
		case 142:
			mnuPU10 = (MenuItem)target;
			mnuPU10.add_Click(new RoutedEventHandler(mnuPU10_Click));
			break;
		case 143:
			mnuPU11 = (MenuItem)target;
			mnuPU11.add_Click(new RoutedEventHandler(mnuPU11_Click));
			break;
		case 144:
			mnuPU11a = (MenuItem)target;
			mnuPU11a.add_Click(new RoutedEventHandler(mnuPU11a_Click));
			break;
		case 145:
			mnuPU11b = (MenuItem)target;
			mnuPU11b.add_Click(new RoutedEventHandler(mnuPU11b_Click));
			break;
		case 146:
			mnuPU12 = (MenuItem)target;
			mnuPU12.add_Click(new RoutedEventHandler(mnuPU12_Click));
			break;
		case 147:
			mnuPU14 = (MenuItem)target;
			mnuPU14.add_Click(new RoutedEventHandler(mnuPU14_Click));
			break;
		case 148:
			mnuPU15 = (MenuItem)target;
			mnuPU15.add_Click(new RoutedEventHandler(mnuPU15_Click));
			break;
		case 149:
			mnuPU16 = (MenuItem)target;
			mnuPU16.add_Click(new RoutedEventHandler(mnuPU16_Click));
			break;
		case 150:
			mnuPU21 = (MenuItem)target;
			mnuPU21.add_Click(new RoutedEventHandler(mnuPU21_Click));
			break;
		case 151:
			mnuPU22 = (MenuItem)target;
			mnuPU22.add_Click(new RoutedEventHandler(mnuPU22_Click));
			break;
		case 152:
			mnuPU24 = (MenuItem)target;
			mnuPU24.add_Click(new RoutedEventHandler(mnuPU24_Click));
			break;
		case 153:
			mnuPU23 = (MenuItem)target;
			mnuPU23.add_Click(new RoutedEventHandler(mnuPU23_Click));
			break;
		case 154:
			mnuPU33 = (MenuItem)target;
			mnuPU33.add_Click(new RoutedEventHandler(mnuPU33_Click));
			break;
		case 155:
			mnuPU34 = (MenuItem)target;
			mnuPU34.add_Click(new RoutedEventHandler(mnuPU34_Click));
			break;
		case 156:
			mnuPU42 = (MenuItem)target;
			mnuPU42.add_Click(new RoutedEventHandler(mnuPU42_Click));
			break;
		case 157:
			mnuPU40 = (MenuItem)target;
			mnuPU40.add_Click(new RoutedEventHandler(mnuPU40_Click));
			break;
		case 158:
			mnuPU41 = (MenuItem)target;
			mnuPU41.add_Click(new RoutedEventHandler(mnuPU41_Click));
			break;
		case 159:
			mnuPU43 = (MenuItem)target;
			mnuPU43.add_Click(new RoutedEventHandler(mnuPU43_Click));
			break;
		case 160:
			mnuPU44 = (MenuItem)target;
			mnuPU44.add_Click(new RoutedEventHandler(mnuPU44_Click));
			break;
		case 161:
			mnuPU45 = (MenuItem)target;
			mnuPU45.add_Click(new RoutedEventHandler(mnuPU45_Click));
			break;
		case 162:
			mnuPU50 = (MenuItem)target;
			mnuPU50.add_Click(new RoutedEventHandler(mnuPU50_Click));
			break;
		case 163:
			mnuPU36a = (MenuItem)target;
			mnuPU36a.add_Click(new RoutedEventHandler(mnuPU36a_Click));
			break;
		case 164:
			mnuPU51 = (MenuItem)target;
			mnuPU51.add_Click(new RoutedEventHandler(mnuPU51_Click));
			break;
		case 165:
			mnuPU52 = (MenuItem)target;
			mnuPU52.add_Click(new RoutedEventHandler(mnuPU52_Click));
			break;
		case 166:
			mnuPU53 = (MenuItem)target;
			mnuPU53.add_Click(new RoutedEventHandler(mnuPU53_Click));
			break;
		case 167:
			mnuPU54 = (MenuItem)target;
			mnuPU54.add_Click(new RoutedEventHandler(mnuPU54_Click));
			break;
		case 168:
			mnuPU54A = (MenuItem)target;
			mnuPU54A.add_Click(new RoutedEventHandler(mnuPU54A_Click));
			break;
		case 169:
			mnuPU55 = (MenuItem)target;
			mnuPU55.add_Click(new RoutedEventHandler(mnuPU55_Click));
			break;
		case 170:
			mnuPU56 = (MenuItem)target;
			mnuPU56.add_Click(new RoutedEventHandler(mnuPU56_Click));
			break;
		case 171:
			mnuPU57 = (MenuItem)target;
			mnuPU57.add_Click(new RoutedEventHandler(mnuPU57_Click));
			break;
		case 172:
			mnuPU58 = (MenuItem)target;
			mnuPU58.add_Click(new RoutedEventHandler(mnuPU58_Click));
			break;
		case 173:
			mnuPU59 = (MenuItem)target;
			mnuPU59.add_Click(new RoutedEventHandler(mnuPU59_Click));
			break;
		case 174:
			mnuPU60 = (MenuItem)target;
			mnuPU60.add_Click(new RoutedEventHandler(mnuPU60_Click));
			break;
		case 175:
			mnuPU61 = (MenuItem)target;
			mnuPU61.add_Click(new RoutedEventHandler(mnuPU61_Click));
			break;
		case 176:
			mnuPU62 = (MenuItem)target;
			mnuPU62.add_Click(new RoutedEventHandler(mnuPU62_Click));
			break;
		case 177:
			mnuPU63 = (MenuItem)target;
			mnuPU63.add_Click(new RoutedEventHandler(mnuPU63_Click));
			break;
		case 178:
			mnuPU64 = (MenuItem)target;
			mnuPU64.add_Click(new RoutedEventHandler(mnuPU64_Click));
			break;
		case 179:
			mnuPU65 = (MenuItem)target;
			mnuPU65.add_Click(new RoutedEventHandler(mnuPU65_Click));
			break;
		case 180:
			mnuPU65A = (MenuItem)target;
			mnuPU65A.add_Click(new RoutedEventHandler(mnuPU65A_Click));
			break;
		case 181:
			mnuPU66 = (MenuItem)target;
			mnuPU66.add_Click(new RoutedEventHandler(mnuPU66_Click));
			break;
		case 182:
			mnuPU66A = (MenuItem)target;
			mnuPU66A.add_Click(new RoutedEventHandler(mnuPU66A_Click));
			break;
		case 183:
			mnuPU68 = (MenuItem)target;
			mnuPU68.add_Click(new RoutedEventHandler(mnuPU68_Click));
			break;
		case 184:
			mnuPU68bb = (MenuItem)target;
			mnuPU68bb.add_Click(new RoutedEventHandler(mnuPU68BB_Click));
			break;
		case 185:
			mnuPU68cc = (MenuItem)target;
			mnuPU68cc.add_Click(new RoutedEventHandler(mnuPU68CC_Click));
			break;
		case 186:
			mnuPU68A = (MenuItem)target;
			mnuPU68A.add_Click(new RoutedEventHandler(mnuPU68A_Click));
			break;
		case 187:
			mnuPU68B = (MenuItem)target;
			mnuPU68B.add_Click(new RoutedEventHandler(mnuPU68B_Click));
			break;
		case 188:
			mnuPU68C = (MenuItem)target;
			mnuPU68C.add_Click(new RoutedEventHandler(mnuPU68C_Click));
			break;
		case 189:
			mnuPU67 = (MenuItem)target;
			mnuPU67.add_Click(new RoutedEventHandler(mnuPU67_Click));
			break;
		case 190:
			mnuPU69 = (MenuItem)target;
			mnuPU69.add_Click(new RoutedEventHandler(mnuPU69_Click));
			break;
		case 191:
			mnuPU70 = (MenuItem)target;
			mnuPU70.add_Click(new RoutedEventHandler(mnuPU70_Click));
			break;
		case 192:
			mnuPU71 = (MenuItem)target;
			mnuPU71.add_Click(new RoutedEventHandler(mnuPU71_Click));
			break;
		case 193:
			mnuPU72 = (MenuItem)target;
			mnuPU72.add_Click(new RoutedEventHandler(mnuPU72_Click));
			break;
		case 194:
			mnuPU73 = (MenuItem)target;
			mnuPU73.add_Click(new RoutedEventHandler(mnuPU73_Click));
			break;
		case 195:
			mnuPU74 = (MenuItem)target;
			mnuPU74.add_Click(new RoutedEventHandler(mnuPU74_Click));
			break;
		case 196:
			mnuPU75 = (MenuItem)target;
			mnuPU75.add_Click(new RoutedEventHandler(mnuPU75_Click));
			break;
		case 197:
			mnuPU76 = (MenuItem)target;
			mnuPU76.add_Click(new RoutedEventHandler(mnuPU76_Click));
			break;
		case 198:
			mnuPU77 = (MenuItem)target;
			mnuPU77.add_Click(new RoutedEventHandler(mnuPU77_Click));
			break;
		case 199:
			mnuPU78 = (MenuItem)target;
			mnuPU78.add_Click(new RoutedEventHandler(mnuPU78_Click));
			break;
		case 200:
			mnuPU79 = (MenuItem)target;
			mnuPU79.add_Click(new RoutedEventHandler(mnuPU79_Click));
			break;
		case 201:
			mnuPU79A = (MenuItem)target;
			mnuPU79A.add_Click(new RoutedEventHandler(mnuPU79A_Click));
			break;
		case 202:
			mnuPU79B = (MenuItem)target;
			mnuPU79B.add_Click(new RoutedEventHandler(mnuPU79B_Click));
			break;
		case 203:
			mnuPU80 = (MenuItem)target;
			mnuPU80.add_Click(new RoutedEventHandler(mnuPU80_Click));
			break;
		case 204:
			mnuPU81 = (MenuItem)target;
			mnuPU81.add_Click(new RoutedEventHandler(mnuPU81_Click));
			break;
		case 205:
			mnuPU82 = (MenuItem)target;
			mnuPU82.add_Click(new RoutedEventHandler(mnuPU82_Click));
			break;
		case 206:
			mnuPU83 = (MenuItem)target;
			mnuPU83.add_Click(new RoutedEventHandler(mnuPU83_Click));
			break;
		case 207:
			mnuPU83A = (MenuItem)target;
			mnuPU83A.add_Click(new RoutedEventHandler(mnuPU83A_Click));
			break;
		case 208:
			mnuPU84 = (MenuItem)target;
			mnuPU84.add_Click(new RoutedEventHandler(mnuPU84_Click));
			break;
		case 209:
			mnuPU85 = (MenuItem)target;
			mnuPU85.add_Click(new RoutedEventHandler(mnuPU85_Click));
			break;
		case 210:
			mnuPU86 = (MenuItem)target;
			mnuPU86.add_Click(new RoutedEventHandler(mnuPU86_Click));
			break;
		case 211:
			mnuPU87 = (MenuItem)target;
			mnuPU87.add_Click(new RoutedEventHandler(mnuPU87_Click));
			break;
		case 212:
			mnuPU88 = (MenuItem)target;
			mnuPU88.add_Click(new RoutedEventHandler(mnuPU88_Click));
			break;
		case 213:
			mnuPU89 = (MenuItem)target;
			mnuPU89.add_Click(new RoutedEventHandler(mnuPU89_Click));
			break;
		case 214:
			mnuPU90 = (MenuItem)target;
			mnuPU90.add_Click(new RoutedEventHandler(mnuPU90_Click));
			break;
		case 215:
			mnuPU91 = (MenuItem)target;
			mnuPU91.add_Click(new RoutedEventHandler(mnuPU91_Click));
			break;
		case 216:
			mnuPU92 = (MenuItem)target;
			mnuPU92.add_Click(new RoutedEventHandler(mnuPU92_Click));
			break;
		case 217:
			mnuPU93 = (MenuItem)target;
			mnuPU93.add_Click(new RoutedEventHandler(mnuPU93_Click));
			break;
		case 218:
			mnuPU94 = (MenuItem)target;
			mnuPU94.add_Click(new RoutedEventHandler(mnuPU94_Click));
			break;
		case 219:
			mnuPU95 = (MenuItem)target;
			mnuPU95.add_Click(new RoutedEventHandler(mnuPU95_Click));
			break;
		case 220:
			mnuPU96 = (MenuItem)target;
			mnuPU96.add_Click(new RoutedEventHandler(mnuPU96_Click));
			break;
		case 221:
			mnuPU97 = (MenuItem)target;
			mnuPU97.add_Click(new RoutedEventHandler(mnuPU97_Click));
			break;
		case 222:
			mnuPU98A = (MenuItem)target;
			mnuPU98A.add_Click(new RoutedEventHandler(mnuPU98A_Click));
			break;
		case 223:
			mnuPU98 = (MenuItem)target;
			mnuPU98.add_Click(new RoutedEventHandler(mnuPU98_Click));
			break;
		case 224:
			mnuPU99 = (MenuItem)target;
			mnuPU99.add_Click(new RoutedEventHandler(mnuPU99_Click));
			break;
		case 225:
			mnuPU100 = (MenuItem)target;
			mnuPU100.add_Click(new RoutedEventHandler(mnuPU100_Click));
			break;
		case 226:
			mnuPU101 = (MenuItem)target;
			mnuPU101.add_Click(new RoutedEventHandler(mnuPU101_Click));
			break;
		case 227:
			mnuPU102 = (MenuItem)target;
			mnuPU102.add_Click(new RoutedEventHandler(mnuPU102_Click));
			break;
		case 228:
			mnuPU103 = (MenuItem)target;
			mnuPU103.add_Click(new RoutedEventHandler(mnuPU103_Click));
			break;
		case 229:
			mnuPU103A = (MenuItem)target;
			mnuPU103A.add_Click(new RoutedEventHandler(mnuPU103A_Click));
			break;
		case 230:
			mnuPU104 = (MenuItem)target;
			mnuPU104.add_Click(new RoutedEventHandler(mnuPU104_Click));
			break;
		case 231:
			mnuPU105 = (MenuItem)target;
			mnuPU105.add_Click(new RoutedEventHandler(mnuPU105_Click));
			break;
		case 232:
			mnuPU106 = (MenuItem)target;
			mnuPU106.add_Click(new RoutedEventHandler(mnuPU106_Click));
			break;
		case 233:
			mnuPU106A = (MenuItem)target;
			mnuPU106A.add_Click(new RoutedEventHandler(mnuPU106A_Click));
			break;
		case 234:
			mnuPU107 = (MenuItem)target;
			mnuPU107.add_Click(new RoutedEventHandler(mnuPU107_Click));
			break;
		case 235:
			mnuPU108 = (MenuItem)target;
			mnuPU108.add_Click(new RoutedEventHandler(mnuPU108_Click));
			break;
		case 236:
			mnuPU109 = (MenuItem)target;
			mnuPU109.add_Click(new RoutedEventHandler(mnuPU109_Click));
			break;
		case 237:
			mnuPU110A = (MenuItem)target;
			mnuPU110A.add_Click(new RoutedEventHandler(mnuPU110A_Click));
			break;
		case 238:
			mnuPU110B = (MenuItem)target;
			mnuPU110B.add_Click(new RoutedEventHandler(mnuPU110B_Click));
			break;
		case 239:
			mnuPU110C = (MenuItem)target;
			mnuPU110C.add_Click(new RoutedEventHandler(mnuPU110C_Click));
			break;
		case 240:
			mnuPU110D = (MenuItem)target;
			mnuPU110D.add_Click(new RoutedEventHandler(mnuPU110D_Click));
			break;
		case 241:
			mnuPU110E = (MenuItem)target;
			mnuPU110E.add_Click(new RoutedEventHandler(mnuPU110E_Click));
			break;
		case 242:
			mnuPU110 = (MenuItem)target;
			mnuPU110.add_Click(new RoutedEventHandler(mnuPU110_Click));
			break;
		case 243:
			mnuPU111 = (MenuItem)target;
			mnuPU111.add_Click(new RoutedEventHandler(mnuPU111_Click));
			break;
		case 244:
			mnuPU112 = (MenuItem)target;
			mnuPU112.add_Click(new RoutedEventHandler(mnuPU112_Click));
			break;
		case 245:
			mnuPU112A = (MenuItem)target;
			mnuPU112A.add_Click(new RoutedEventHandler(mnuPU112A_Click));
			break;
		case 246:
			mnuPU112B = (MenuItem)target;
			mnuPU112B.add_Click(new RoutedEventHandler(mnuPU112B_Click));
			break;
		case 247:
			mnuPU113 = (MenuItem)target;
			mnuPU113.add_Click(new RoutedEventHandler(mnuPU113_Click));
			break;
		case 248:
			mnuPU114B = (MenuItem)target;
			mnuPU114B.add_Click(new RoutedEventHandler(mnuPU114B_Click));
			break;
		case 249:
			mnuPU114A = (MenuItem)target;
			mnuPU114A.add_Click(new RoutedEventHandler(mnuPU114A_Click));
			break;
		case 250:
			mnuPU114 = (MenuItem)target;
			mnuPU114.add_Click(new RoutedEventHandler(mnuPU114_Click));
			break;
		case 251:
			mnuPU115 = (MenuItem)target;
			mnuPU115.add_Click(new RoutedEventHandler(mnuPU115_Click));
			break;
		case 252:
			mnuPU116 = (MenuItem)target;
			mnuPU116.add_Click(new RoutedEventHandler(mnuPU116_Click));
			break;
		case 253:
			mnuSysMscs = (MenuItem)target;
			break;
		case 254:
			mnuSysCpls = (MenuItem)target;
			break;
		case 255:
			mnuAllShellCommand = (MenuItem)target;
			break;
		case 256:
			mnuShellCommandAB = (MenuItem)target;
			break;
		case 257:
			mnuShellCommandCDE = (MenuItem)target;
			break;
		case 258:
			mnuShellCommandFGHIJ = (MenuItem)target;
			break;
		case 259:
			mnuShellCommandKLMNO = (MenuItem)target;
			break;
		case 260:
			mnuShellCommandPQR = (MenuItem)target;
			break;
		case 261:
			mnuShellCommandST = (MenuItem)target;
			break;
		case 262:
			mnuShellCommandUVWXYZ = (MenuItem)target;
			break;
		case 263:
			((MenuItem)target).add_Click(new RoutedEventHandler(MenuMSERTDown_Click));
			break;
		case 264:
			((MenuItem)target).add_Click(new RoutedEventHandler(MenuNetwrokMonitoringDown_Click));
			break;
		case 265:
			((MenuItem)target).add_Click(new RoutedEventHandler(MenuItemHelp_Click));
			break;
		case 266:
			((MenuItem)target).add_Click(new RoutedEventHandler(MenuItemWindowsISO_Click));
			break;
		case 267:
			mnuResolveToBlock = (MenuItem)target;
			break;
		case 268:
			mnuResolve01 = (MenuItem)target;
			mnuResolve01.add_Click(new RoutedEventHandler(mnuResolve01_Click));
			break;
		case 269:
			mnuResolve07 = (MenuItem)target;
			mnuResolve07.add_Click(new RoutedEventHandler(mnuResolve07_Click));
			break;
		case 270:
			mnuResolve03 = (MenuItem)target;
			mnuResolve03.add_Click(new RoutedEventHandler(mnuResolve03_Click));
			break;
		case 271:
			mnuResolve04 = (MenuItem)target;
			mnuResolve04.add_Click(new RoutedEventHandler(mnuResolve04_Click));
			break;
		case 272:
			mnuResolve05 = (MenuItem)target;
			mnuResolve05.add_Click(new RoutedEventHandler(mnuResolve05_Click));
			break;
		case 273:
			mnuResolve02 = (MenuItem)target;
			mnuResolve02.add_Click(new RoutedEventHandler(mnuResolve02_Click));
			break;
		case 274:
			mnuResolve06 = (MenuItem)target;
			mnuResolve06.add_Click(new RoutedEventHandler(mnuResolve06_Click));
			break;
		case 275:
			mnuResolve08 = (MenuItem)target;
			mnuResolve08.add_Click(new RoutedEventHandler(mnuResolve08_Click));
			break;
		case 276:
			mnuResolve10s = (MenuItem)target;
			mnuResolve10s.add_Click(new RoutedEventHandler(mnuResolve10s_Click));
			break;
		case 277:
			mnuResolve10 = (MenuItem)target;
			mnuResolve10.add_Click(new RoutedEventHandler(mnuResolve10_Click));
			break;
		case 278:
			mnuResolve20s = (MenuItem)target;
			mnuResolve20s.add_Click(new RoutedEventHandler(mnuResolve20s_Click));
			break;
		case 279:
			mnuResolve20 = (MenuItem)target;
			mnuResolve20.add_Click(new RoutedEventHandler(mnuResolve20_Click));
			break;
		case 280:
			mnuSleepMilisec = (MenuItem)target;
			break;
		case 281:
			btnHealthCheck = (Button)target;
			((ButtonBase)btnHealthCheck).add_Click(new RoutedEventHandler(btnHealthCheck_Click));
			break;
		case 282:
			webb = (WebBrowser)target;
			break;
		case 283:
			tabCtrl = (TabControl)target;
			((Selector)tabCtrl).add_SelectionChanged(new SelectionChangedEventHandler(tabCtrl_SelectionChanged));
			break;
		case 284:
			tabItemMain = (TabItem)target;
			break;
		case 285:
			txtHealthReport = (TextBox)target;
			((TextBoxBase)txtHealthReport).add_SelectionChanged(new RoutedEventHandler(txtHealthReport_SelectionChanged));
			((UIElement)txtHealthReport).add_GotFocus(new RoutedEventHandler(txtHealthReport_GotFocus));
			break;
		case 286:
			tabApproval = (TabItem)target;
			break;
		case 287:
			lvApproval = (DataGrid)target;
			((Selector)lvApproval).add_SelectionChanged(new SelectionChangedEventHandler(lvApproval_SelectionChanged));
			((FrameworkElement)lvApproval).add_ContextMenuOpening(new ContextMenuEventHandler(lvApproval_ContextMenuOpening));
			break;
		case 288:
			((ContextMenu)target).add_Opened(new RoutedEventHandler(ContextMenu_Opened));
			break;
		case 289:
			((MenuItem)target).add_Click(new RoutedEventHandler(mnuDataGridColumnCopy_Click));
			break;
		case 290:
			((MenuItem)target).add_Click(new RoutedEventHandler(mnuDataGridFilePathCopy_Click));
			break;
		case 291:
			((MenuItem)target).add_Click(new RoutedEventHandler(mnuDataGridSearchFile_Click));
			break;
		case 292:
			((MenuItem)target).add_Click(new RoutedEventHandler(mnuDataCheckSumCopy_Click));
			break;
		case 293:
			((MenuItem)target).add_Click(new RoutedEventHandler(mnuDataGridVirustotal_Click));
			break;
		case 294:
			((MenuItem)target).add_Click(new RoutedEventHandler(mnuDataGridFileNet_Click));
			break;
		case 295:
			mnuPopFirewallOBlock = (MenuItem)target;
			mnuPopFirewallOBlock.add_Click(new RoutedEventHandler(mnuDataGridFireWallOutBlock_Click));
			break;
		case 298:
			columnAppSort = (DataGridTextColumn)target;
			break;
		case 299:
			btnAllApproval = (Button)target;
			((ButtonBase)btnAllApproval).add_Click(new RoutedEventHandler(btnAllApproval_Click));
			break;
		case 300:
			btnViewNewed = (Button)target;
			((ButtonBase)btnViewNewed).add_Click(new RoutedEventHandler(btnViewNewed_Click));
			break;
		case 301:
			btnViewAll = (Button)target;
			((ButtonBase)btnViewAll).add_Click(new RoutedEventHandler(btnViewAll_Click));
			break;
		case 302:
			tabItem2 = (TabItem)target;
			break;
		case 303:
			txtFileName = (TextBox)target;
			((TextBoxBase)txtFileName).add_SelectionChanged(new RoutedEventHandler(txtFileNames_SelectionChanged));
			break;
		case 304:
			btnCheckSumSHA256 = (Button)target;
			((ButtonBase)btnCheckSumSHA256).add_Click(new RoutedEventHandler(btnCheckSumSHA256_Click));
			break;
		case 305:
			btnCheckSumMD5 = (Button)target;
			((ButtonBase)btnCheckSumMD5).add_Click(new RoutedEventHandler(btnCheckSumMD5_Click));
			break;
		case 306:
			btnClear = (Button)target;
			((ButtonBase)btnClear).add_Click(new RoutedEventHandler(btnClear_Click));
			break;
		case 307:
			btnCopy = (Button)target;
			((ButtonBase)btnCopy).add_Click(new RoutedEventHandler(btnCopy_Click));
			break;
		case 308:
			btnRemoveSharp = (Button)target;
			((ButtonBase)btnRemoveSharp).add_Click(new RoutedEventHandler(btnRemoveSharp_Click));
			break;
		case 309:
			tabItemMsra = (TabItem)target;
			break;
		case 310:
			label1 = (Label)target;
			break;
		case 311:
			label2 = (Label)target;
			break;
		case 312:
			chkUsePrivMail = (CheckBox)target;
			((ToggleButton)chkUsePrivMail).add_Checked(new RoutedEventHandler(chkUsePrivMail_Checked));
			((ToggleButton)chkUsePrivMail).add_Unchecked(new RoutedEventHandler(chkUsePrivMail_Unchecked));
			break;
		case 313:
			txtGmailID = (TextBox)target;
			break;
		case 314:
			txtGmailPass = (PasswordBox)target;
			break;
		case 315:
			label3 = (Label)target;
			((UIElement)label3).add_MouseLeftButtonDown(new MouseButtonEventHandler(label3_MouseLeftButtonDown));
			break;
		case 316:
			label4 = (Label)target;
			break;
		case 317:
			txtReceiverMailAddress = (TextBox)target;
			((Control)txtReceiverMailAddress).add_MouseDoubleClick(new MouseButtonEventHandler(txtReceiverMailAddress_MouseDoubleClick));
			((TextBoxBase)txtReceiverMailAddress).add_TextChanged(new TextChangedEventHandler(txtReceiverMailAddress_TextChanged));
			break;
		case 318:
			lblAuthEmailGuide = (Label)target;
			break;
		case 319:
			chkSave1 = (CheckBox)target;
			break;
		case 320:
			chkSave2 = (CheckBox)target;
			break;
		case 321:
			chkSave3 = (CheckBox)target;
			break;
		case 322:
			btnMsraRequest = (Button)target;
			((ButtonBase)btnMsraRequest).add_Click(new RoutedEventHandler(btnMsraRequest_Click));
			break;
		case 323:
			chkAutoAllow = (CheckBox)target;
			((ToggleButton)chkAutoAllow).add_Checked(new RoutedEventHandler(chkAutoAllow_Checked));
			break;
		case 324:
			label5 = (Label)target;
			break;
		case 325:
			txtMailContent = (TextBox)target;
			break;
		case 326:
			btnSetAllow = (Button)target;
			((ButtonBase)btnSetAllow).add_Click(new RoutedEventHandler(btnSetAllow_Click));
			break;
		case 327:
			btnGoogleMailSendAllow1 = (Button)target;
			((ButtonBase)btnGoogleMailSendAllow1).add_Click(new RoutedEventHandler(btnGoogleMailSendAllow1_Click));
			break;
		case 328:
			btnGoogleMailSendAllow2 = (Button)target;
			((ButtonBase)btnGoogleMailSendAllow2).add_Click(new RoutedEventHandler(btnGoogleMailSendAllow2_Click));
			break;
		case 329:
			cboSessions = (ListBox)target;
			break;
		case 330:
			lblSessions = (TextBlock)target;
			break;
		case 331:
			tabItemUtils = (TabItem)target;
			break;
		case 332:
			btnOpenLogFolder = (Button)target;
			((ButtonBase)btnOpenLogFolder).add_Click(new RoutedEventHandler(btnOpenLogFolder_Click));
			break;
		case 333:
			button2 = (Button)target;
			((ButtonBase)button2).add_Click(new RoutedEventHandler(button2_Click));
			break;
		case 334:
			vTotalS = (Button)target;
			((ButtonBase)vTotalS).add_Click(new RoutedEventHandler(vTotalS_Click));
			break;
		case 335:
			btnProcessExp = (Button)target;
			((ButtonBase)btnProcessExp).add_Click(new RoutedEventHandler(btnProcessExp_Click));
			((UIElement)btnProcessExp).add_MouseRightButtonDown(new MouseButtonEventHandler(btnProcessExp_MouseRightButtonDown));
			break;
		case 336:
			imgProcExp = (Image)target;
			break;
		case 337:
			btnAutoRun = (Button)target;
			((ButtonBase)btnAutoRun).add_Click(new RoutedEventHandler(btnAutoRun_Click));
			break;
		case 338:
			imgAutoRuns = (Image)target;
			break;
		case 339:
			chkEndReDiagnosis = (CheckBox)target;
			((ButtonBase)chkEndReDiagnosis).add_Click(new RoutedEventHandler(chkEndReDiagnosis_Click));
			break;
		case 340:
			btnStartProgramUser = (Button)target;
			((ButtonBase)btnStartProgramUser).add_Click(new RoutedEventHandler(btnStartProgramUser_Click));
			break;
		case 341:
			btnService = (Button)target;
			((ButtonBase)btnService).add_Click(new RoutedEventHandler(btnService_Click));
			break;
		case 342:
			btnRegistree = (Button)target;
			((ButtonBase)btnRegistree).add_Click(new RoutedEventHandler(btnRegistree_Click));
			break;
		case 343:
			btnProgramWiz = (Button)target;
			((ButtonBase)btnProgramWiz).add_Click(new RoutedEventHandler(btnProgramWiz_Click));
			break;
		case 344:
			btnStartProgramAll = (Button)target;
			((ButtonBase)btnStartProgramAll).add_Click(new RoutedEventHandler(btnStartProgramAll_Click));
			break;
		case 345:
			btnMsconfig = (Button)target;
			((ButtonBase)btnMsconfig).add_Click(new RoutedEventHandler(btnMsconfig_Click));
			break;
		case 346:
			btnCompmmc = (Button)target;
			((ButtonBase)btnCompmmc).add_Click(new RoutedEventHandler(btnCompmmc_Click));
			break;
		case 347:
			btnAdminCmd = (Button)target;
			((ButtonBase)btnAdminCmd).add_Click(new RoutedEventHandler(btnAdminCmd_Click));
			break;
		case 348:
			btnFileSelector = (Button)target;
			((ButtonBase)btnFileSelector).add_Click(new RoutedEventHandler(btnFileSelector_Click));
			break;
		case 349:
			btnOptimizeReg = (Button)target;
			((ButtonBase)btnOptimizeReg).add_Click(new RoutedEventHandler(btnOptimizeReg_Click));
			break;
		case 350:
			btnDeleteBHO = (Button)target;
			((ButtonBase)btnDeleteBHO).add_Click(new RoutedEventHandler(btnDeleteBHO_Click));
			break;
		case 351:
			btnGoGlean = (Button)target;
			((ButtonBase)btnGoGlean).add_Click(new RoutedEventHandler(btnGoClean_Click));
			break;
		case 352:
			imgGoClean = (Image)target;
			break;
		case 353:
			btnFixUSB = (Button)target;
			((ButtonBase)btnFixUSB).add_Click(new RoutedEventHandler(btnFixUSB_Click));
			break;
		case 354:
			btnFireWall = (Button)target;
			((ButtonBase)btnFireWall).add_Click(new RoutedEventHandler(btnFireWall_Click));
			break;
		case 355:
			lblBHO_delete_guide = (Label)target;
			break;
		case 356:
			lblBHO_delete_guide2 = (Label)target;
			break;
		case 357:
			btnMsSpell = (Button)target;
			((ButtonBase)btnMsSpell).add_Click(new RoutedEventHandler(btnMsSpellDis_Click));
			break;
		case 358:
			btnOpenHosts = (Button)target;
			((ButtonBase)btnOpenHosts).add_Click(new RoutedEventHandler(btnOpenHosts_Click));
			break;
		case 359:
			btnUninstall = (Button)target;
			((ButtonBase)btnUninstall).add_Click(new RoutedEventHandler(btnUninstall_Click));
			break;
		case 360:
			btnFileOutBound = (Button)target;
			((ButtonBase)btnFileOutBound).add_Click(new RoutedEventHandler(btnFileOutBound_Click));
			break;
		case 361:
			btnEverything = (Button)target;
			((ButtonBase)btnEverything).add_Click(new RoutedEventHandler(btnEverything_Click));
			break;
		case 362:
			imgEverything = (Image)target;
			break;
		case 363:
			btnNowVolume = (Button)target;
			((ButtonBase)btnNowVolume).add_Click(new RoutedEventHandler(btnNowVolume_Click));
			break;
		case 364:
			cboVolumeNow = (ComboBox)target;
			break;
		case 365:
			btnMuteSign = (Button)target;
			((ButtonBase)btnMuteSign).add_Click(new RoutedEventHandler(btnMuteSign_Click));
			break;
		case 366:
			lblTarget = (Label)target;
			break;
		case 367:
			cboVolumeTo = (ComboBox)target;
			break;
		case 368:
			lblDuration = (Label)target;
			break;
		case 369:
			cboVolumeDuration = (ComboBox)target;
			break;
		case 370:
			btnVolumeStoryboard = (Button)target;
			((ButtonBase)btnVolumeStoryboard).add_Click(new RoutedEventHandler(btnVolumeStoryboard_Click));
			break;
		case 371:
			lblVolState = (Label)target;
			break;
		case 372:
			btnVolToPresent = (Button)target;
			((ButtonBase)btnVolToPresent).add_Click(new RoutedEventHandler(btnVolToPresent_Click));
			break;
		case 373:
			cboVolumeSet1 = (ComboBox)target;
			break;
		case 374:
			btnVolumeSet1 = (Button)target;
			((ButtonBase)btnVolumeSet1).add_Click(new RoutedEventHandler(btnVolumeSet1_Click));
			break;
		case 375:
			cboVolumeSet2 = (ComboBox)target;
			break;
		case 376:
			btnVolumeSet2 = (Button)target;
			((ButtonBase)btnVolumeSet2).add_Click(new RoutedEventHandler(btnVolumeSet2_Click));
			break;
		case 377:
			cboVolumeSet3 = (ComboBox)target;
			break;
		case 378:
			btnVolumeSet3 = (Button)target;
			((ButtonBase)btnVolumeSet3).add_Click(new RoutedEventHandler(btnVolumeSet3_Click));
			break;
		case 379:
			volumeSlider = (Slider)target;
			((RangeBase)volumeSlider).add_ValueChanged((RoutedPropertyChangedEventHandler<double>)volumeSlider_ValueChanged);
			((UIElement)volumeSlider).add_PreviewMouseLeftButtonDown(new MouseButtonEventHandler(volumeSlider_PreviewMouseLeftButtonDown));
			break;
		case 380:
			lblBuildNO = (Label)target;
			break;
		case 381:
			btnOneMinuAfterExecute = (Button)target;
			((ButtonBase)btnOneMinuAfterExecute).add_Click(new RoutedEventHandler(btnOneMinuAfterExecute_Click));
			break;
		case 382:
			txtFileNameOfExecute = (TextBox)target;
			break;
		case 383:
			lblRemainSec = (TextBlock)target;
			break;
		case 384:
			tabItemURLProtocol = (TabItem)target;
			break;
		case 385:
			lvURLProtocol = (DataGrid)target;
			break;
		case 386:
			FileExists = (DataGridTemplateColumn)target;
			break;
		case 389:
			btnRecommandURLProtocol = (Button)target;
			((ButtonBase)btnRecommandURLProtocol).add_Click(new RoutedEventHandler(btnRecommandURLProtocol_Click));
			break;
		case 390:
			tabItemAppOutBlock = (TabItem)target;
			break;
		case 391:
			chkAppApprovalBlock = (CheckBox)target;
			((ToggleButton)chkAppApprovalBlock).add_Checked(new RoutedEventHandler(chkAppApprovalBlock_Checked));
			((ToggleButton)chkAppApprovalBlock).add_Unchecked(new RoutedEventHandler(chkAppApprovalBlock_Unchecked));
			break;
		case 392:
			lvAppOutBlock = (DataGrid)target;
			break;
		case 393:
			AppFileExists = (DataGridTemplateColumn)target;
			break;
		default:
			_contentLoaded = true;
			break;
		case 395:
			btnRefreshOutBlock = (Button)target;
			((ButtonBase)btnRefreshOutBlock).add_Click(new RoutedEventHandler(btnRefreshOutBlock_Click));
			break;
		case 396:
			btnAppOutBlockRecommand = (Button)target;
			((ButtonBase)btnAppOutBlockRecommand).add_Click(new RoutedEventHandler(btnAppOutBlockRecommand_Click));
			break;
		case 397:
			tabItemAuth = (TabItem)target;
			break;
		case 398:
			txtUserEmail = (TextBox)target;
			break;
		case 399:
			txtSerialNumber = (TextBox)target;
			break;
		case 400:
			btnLicenceAuth = (Button)target;
			((ButtonBase)btnLicenceAuth).add_Click(new RoutedEventHandler(btnLicenceAuth_Click));
			break;
		case 401:
			lblHelp = (Label)target;
			break;
		case 402:
			chkContinue = (CheckBox)target;
			((ButtonBase)chkContinue).add_Click(new RoutedEventHandler(chkContinue_Click));
			break;
		case 403:
			btnSaveLog = (Button)target;
			((ButtonBase)btnSaveLog).add_Click(new RoutedEventHandler(button1_Click));
			break;
		case 404:
			btnAnalysisDeep = (Button)target;
			((ButtonBase)btnAnalysisDeep).add_Click(new RoutedEventHandler(btnAnalysisDeep_Click));
			break;
		case 405:
			cboBaseLine = (ComboBox)target;
			break;
		case 406:
			btnAnalysisQuick = (Button)target;
			((ButtonBase)btnAnalysisQuick).add_Click(new RoutedEventHandler(btnAnalysisQuick_Click));
			break;
		case 407:
			btnAnalysisCancel = (Button)target;
			((ButtonBase)btnAnalysisCancel).add_Click(new RoutedEventHandler(btnAnalysisCancel_Click));
			break;
		case 408:
			btnHealthListCopy = (Button)target;
			((ButtonBase)btnHealthListCopy).add_Click(new RoutedEventHandler(btnHealthListCopy_Click));
			break;
		case 409:
			chkAutoStart = (CheckBox)target;
			((ButtonBase)chkAutoStart).add_Click(new RoutedEventHandler(chkAutoStart_Click));
			break;
		case 410:
			chkAutoNetCloseStart = (CheckBox)target;
			((ButtonBase)chkAutoNetCloseStart).add_Click(new RoutedEventHandler(chkAutoNetCloseStart_Click));
			((ToggleButton)chkAutoNetCloseStart).add_Checked(new RoutedEventHandler(chkAutoNetCloseStart_Checked));
			((ToggleButton)chkAutoNetCloseStart).add_Unchecked(new RoutedEventHandler(chkAutoNetCloseStart_Unchecked));
			break;
		case 411:
			dpanVolume = (DockPanel)target;
			break;
		case 412:
			cboVolume = (ComboBox)target;
			break;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		switch (connectionId)
		{
		case 394:
			((ButtonBase)(Button)target).add_Click(new RoutedEventHandler(AppOutBlockDeleteItem_Click));
			break;
		case 387:
			((ButtonBase)(RadioButton)target).add_Click(new RoutedEventHandler(isURL_Y_Click));
			break;
		case 388:
			((ButtonBase)(RadioButton)target).add_Click(new RoutedEventHandler(isURL_N_Click));
			break;
		case 296:
			((ButtonBase)(RadioButton)target).add_Click(new RoutedEventHandler(isY_Click));
			break;
		case 297:
			((ButtonBase)(RadioButton)target).add_Click(new RoutedEventHandler(isN_Click));
			break;
		}
	}
}
