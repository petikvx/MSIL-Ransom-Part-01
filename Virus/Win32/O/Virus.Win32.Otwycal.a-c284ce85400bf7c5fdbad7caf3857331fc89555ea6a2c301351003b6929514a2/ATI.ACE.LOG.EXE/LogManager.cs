using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ATI.ACE.APM.Foundation;
using ATI.ACE.CLI.Foundation;
using ATI.ACE.LOG.Foundation;
using ATI.ACE.LOG.Foundation.Implementation.Private;
using ATI.ACE.LOG.Foundation.Private;
using Microsoft.Win32;

namespace ATI.ACE.LOG.EXE;

public class LogManager : Form, IObserveLanguageChanged, IObserveComponentUpdated, IObserveComponentExiting, IObserveComponentChanges, IObserveValueChanges, IObserveSkinMolting
{
	private delegate void AddToListViewDelegate(ListViewItem x);

	private const string ACE_LOG_FIlE_NAME = "ACELog.txt";

	private const string PAUSE_LOG = "Pause";

	private const string RESUME_LOG = "Resume";

	private MgrLog logger;

	private LogServer logServer;

	private bool loggingPaused;

	private ArrayList logMessages = new ArrayList();

	private ArrayList runProcesses = new ArrayList();

	private CLIProcess[] CLIComponents;

	private Process[] ACEApplications;

	private IComponent IComponentRT;

	private NotifyLanguage ComponentRT_L;

	private NotifyComponent ComponentRT_C;

	private NotifyComponentVoid ComponentRT_E;

	private NotifyComponent ComponentRT_U;

	private NotifySkin ComponentRT_S;

	private int LanguageCounter;

	private int LanguageChanges;

	private Tongue currentLanguage;

	private int SkinCounter;

	private int SkinChanges;

	private Flesh currentSkin;

	private ICaste ICasteRT;

	private NotifyCCAA CasteRT_C;

	private SCaste sCaste;

	private IAdapter IAdapterRT;

	private NotifyCCAA AdapterRT_C;

	private SAdapter sAdapter;

	private IAspect IAspectRT;

	private NotifyCCAA AspectRT_C;

	private SAspect sAspect;

	private Feature[] sFeatures;

	private IWriteable[] sWriteable;

	private IImmutable[] sImmutable;

	private int SetPropertyRepeats;

	private XManifest xManifest;

	private IProfileManager iPM;

	private LogServer.LogUpdateEventHandler logUpdateEventHandler;

	private LogServer.AppDomainRegisterHandler appDomainRegisterHandler;

	private LogServer.AppDomainUnregisterHandler appDomainUnregisterHandler;

	private LogServer.CccComponentsHandler cccComponentsHandler;

	private Dictionary<int, CCC> myCCCs = new Dictionary<int, CCC>();

	private GroupBox UI_GB_CasteInfo;

	private Button UI_B_GetSCaste;

	private ComboBox UI_CB_Caste;

	private GroupBox UI_GB_AdapterInfo;

	private Button UI_B_GetSAdapter;

	private TabControl UI_TAB_MainTab;

	private TabPage UI_TAB_Main_Runtime;

	private GroupBox UI_GB_FeatureInfo;

	private Button UI_B_GetSFeature;

	private ComboBox UI_CB_Feature;

	private GroupBox UI_GB_AspectInfo;

	private Button UI_B_GetSAspect;

	private ComboBox UI_CB_Aspect;

	private GroupBox UI_GB_PropertyInfo;

	private Button UI_B_GetSProperty;

	private ComboBox UI_CB_Property;

	private TabPage UI_TAB_Main_Components;

	private TabPage UI_TAB_Main_Messages;

	private TabPage UI_TAB_Main_Domains;

	private TabPage UI_TAB_Main_Logfile;

	private GroupBox UI_GB_ACE_LogFile;

	private TextBox UI_TB_ACE_LogFile;

	private Button UI_B_Open_ACE_LogFile;

	private Button UI_B_Delete_ACE_LogFile;

	private GroupBox UI_GB_Windows_EventLog;

	private Button UI_B_Open_Windows_EventLog;

	private Button UI_B_Clear_Windows_EventLog;

	private GroupBox UI_GB_AppDomains;

	private CheckBox UI_CM_DebugMessages;

	private ListBox UI_LB_AppDomains;

	private ListView UI_LV_LogInfo;

	private GroupBox UI_GB_Filters;

	private ComboBox UI_CB_AssemblyName;

	private ComboBox UI_CB_AppDomain;

	private TextBox UI_TB_NamespaceClass;

	private Button UI_B_PauseLogging;

	private Button UI_B_SaveTable;

	private Button UI_B_ClearAllLogMessages;

	private ColumnHeader UI_C_LogMessageTime;

	private ColumnHeader UI_C_LogMessage;

	private ColumnHeader UI_C_MethodName;

	private ColumnHeader UI_C_NamespaceClass;

	private ColumnHeader UI_C_AppDomain;

	private ColumnHeader UI_C_AssemblyName;

	private GroupBox UI_GB_ACE_LogMessages;

	private Button UI_B_SetSProperty;

	private TextBox UI_TB_SetSProperty;

	private CheckBox UI_CM_AutoScroll;

	private GroupBox UI_GB_MessageControl;

	private GroupBox UI_GB_MessageDetails;

	private TextBox UI_TB_AssemblyCurrent;

	private TextBox UI_TB_AppDomainCurrent;

	private TextBox UI_TB_ClassCurrent;

	private Button UI_B_CopyMessage;

	private Button UI_B_IComponentApply;

	private GroupBox UI_GB_IComponent;

	private Button UI_B_IComponentCancel;

	private Button UI_B_IComponentFactory;

	private Button UI_B_IComponentRefresh;

	private CheckBox UI_B_LogMessagesConfirmClear;

	private TextBox UI_TB_ChangeCounterCaste;

	private TextBox UI_TB_ChangeCounterAdapter;

	private TextBox UI_TB_ChangeCounterAspect;

	private TextBox UI_TB_SPropertyRepeats;

	private Button UI_B_SetSPropertyRepeat;

	private Button UI_B_StartCLI;

	private GroupBox UI_GB_CLI;

	private CheckBox UI_CM_CLIDebugging;

	private ListBox UI_LB_CLI;

	private GroupBox UI_GB_Runtime;

	private Button UI_B_RuntimeConnect;

	private TextBox UI_TB_SFeatureActive;

	private TextBox UI_TB_RuntimePID;

	private TextBox UI_TB_UnApplied;

	private GroupBox UI_GB_LOGMessageControls;

	private CheckBox UI_CM_ErrorMessages;

	private CheckBox UI_CM_ExceptionMessages;

	private TextBox UI_TB_Message;

	private TextBox UI_TB_MethodName;

	private Button UI_B_GetAppDomainAssemblies;

	private Button UI_B_CopyAppDomains;

	private ListBox UI_LB_AppDomainItems;

	private Button UI_B_GetPublished;

	private ColumnHeader UI_C_MessageType;

	private CheckBox UI_CM_LOG_Status_AutoScroll;

	private ListBox UI_LB_LOG_Status;

	private Button UI_B_DeleteProfile;

	private Button UI_B_Clear_LOG_Status;

	private CheckBox UI_CM_LogToLOG;

	private CheckBox UI_CM_AppDomainLogToLOG;

	private ComboBox UI_CB_Languages;

	private TextBox UI_TB_LanguageCounter;

	private TextBox UI_TB_LanguageCurrent;

	private GroupBox UI_GB_Language;

	private TextBox UI_TB_LanguageChanges;

	private Label UI_L_NumLanguageCalls;

	private Label UI_L_NumLanguageChanges;

	private TabPage UI_TAB_Profiles;

	private GroupBox UI_GB_Profiles;

	private TextBox UI_TB_IPM_PID;

	private GroupBox UI_GB_IPM;

	private Button UI_B_IPM_Connect;

	private ListBox UI_LB_Profiles;

	private Button UI_IPM_GetList;

	private Button UI_B_IPM_Load;

	private Button UI_B_StopCLI;

	private ColumnHeader UI_C_ProcessID;

	private ColumnHeader UI_C_ThreadName;

	private Label UI_L_CLI_Args;

	private TextBox UI_TB_CLI_Args;

	private GroupBox UI_GB_Skin;

	private ComboBox UI_CB_Skins;

	private TextBox UI_TB_SkinCurrent;

	private TextBox UI_TB_SkinCounter;

	private TextBox UI_TB_SkinChanges;

	private Label UI_L_NumSkinCalls;

	private Label label1;

	private Button UI_B_LanguageReset;

	private GroupBox UI_GB_CCC;

	private ListBox UI_LB_CCC;

	private ComboBox UI_CB_CCC;

	private TextBox UI_TB_PID;

	private Label UI_L_CCC;

	private Label UI_L_PID;

	private Button UI_B_StopCCC;

	private ComboBox UI_CB_Property_Immutable;

	private Button UI_B_GetSProperty_Immutable;

	private TextBox UI_TB_CCC_Args;

	private Label UI_L_CCC_Args;

	private ComboBox UI_CB_Adapter;

	private string DomainNameFilter => (string)UI_CB_AppDomain.get_SelectedItem();

	private string AssemblyNameFilter => (string)UI_CB_AssemblyName.get_SelectedItem();

	private string NamespaceFilter => ((Control)UI_TB_NamespaceClass).get_Text();

	private string MessageTextFilter => ((Control)UI_TB_Message).get_Text();

	static LogManager()
	{
		Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);
	}

	[STAThread]
	public static void Main(string[] args)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		Thread.CurrentThread.Name = "Main";
		try
		{
			Communications.Initialize(false, "LOG");
			Application.Run((Form)(object)new LogManager());
			Communications.Destroy();
		}
		catch (Exception ex)
		{
			MessageBox.Show("Failed to startup: " + ex.Message);
		}
	}

	public LogManager()
	{
		string text = "LOG";
		InitializeComponent();
		if (!Init())
		{
			((Form)this).Close();
		}
		((Control)this).set_Text(text);
		Display(text + " is at your service!");
	}

	private bool Init()
	{
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected O, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected O, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected O, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			logger = new MgrLog();
			logServer = new LogServer();
			logServer.LogUpdate += (logUpdateEventHandler = logger_LogUpdate);
			logServer.AppDomainRegister += (appDomainRegisterHandler = logger_AppDomainRegister);
			logServer.AppDomainUnregister += (appDomainUnregisterHandler = logger_AppDomainUnregister);
			logServer.CccComponents += (cccComponentsHandler = logger_CccComponentsHandler);
			Communications.PublishObject((IMBRO)(object)logServer, "LOG");
			InitializeComboBoxes();
			ComponentRT_U = new NotifyComponent(new ComponentUpdated((IObserveComponentUpdated)(object)this).NotifyComponentUpdated);
			ComponentRT_E = new NotifyComponentVoid(new ComponentExiting((IObserveComponentExiting)(object)this).NotifyComponentExiting);
			ComponentRT_C = new NotifyComponent(new ComponentChanges((IObserveComponentChanges)(object)this).NotifyComponentChanges);
			ComponentRT_L = new NotifyLanguage(new LanguageChanged((IObserveLanguageChanged)(object)this).NotifyLanguageChanged);
			ComponentRT_S = new NotifySkin(new SkinMolting((IObserveSkinMolting)(object)this).NotifySkinMolting);
			CasteRT_C = new NotifyCCAA(new ValueChanges((IObserveValueChanges)(object)this).NotifyValueChanges);
			AdapterRT_C = new NotifyCCAA(new ValueChanges((IObserveValueChanges)(object)this).NotifyValueChanges);
			AspectRT_C = new NotifyCCAA(new ValueChanges((IObserveValueChanges)(object)this).NotifyValueChanges);
			return ReadManifestDestiny();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
			return false;
		}
	}

	private void InitializeComboBoxes()
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			UI_CB_AssemblyName.get_Items().Add((object)"<Search by Assembly Name>");
			UI_CB_AppDomain.get_Items().Add((object)"<Search by AppDomain Name>");
			((ListControl)UI_CB_AssemblyName).set_SelectedIndex(0);
			((ListControl)UI_CB_AppDomain).set_SelectedIndex(0);
			((Control)UI_TB_ACE_LogFile).set_Text(logger.FullPathFileName);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			Communications.UnPublishObject("LOG");
		}
		((Form)this).Dispose(disposing);
	}

	private void Cleanup()
	{
	}

	private void UI_ACE_Closing(object sender, CancelEventArgs e)
	{
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		UI_TAB_MainTab.set_SelectedTab(UI_TAB_Main_Messages);
		if (CLIComponents != null)
		{
			int num = CLIComponents.Length;
			int num2 = num - 1;
			while (0 <= num2)
			{
				CLIProcess cLIProcess = CLIComponents[num2];
				if (cLIProcess != null)
				{
					XComponentBase c = cLIProcess.c;
					HComponent refComponent = c.RefComponent;
					if (refComponent != null)
					{
						c.RefComponent = null;
						Display("Releasing " + c);
						try
						{
							refComponent.PleaseExit();
							Display("Released");
						}
						catch
						{
							Display("Already exiting");
						}
					}
				}
				num2--;
			}
		}
		if (ACEApplications != null)
		{
			int num3 = ACEApplications.Length;
			for (int i = 0; i < num3; i++)
			{
				ACEApplications[i] = null;
			}
		}
		if (0 < UI_LB_AppDomains.get_Items().get_Count())
		{
			ThreadStart start = Cleanup;
			Thread thread = new Thread(start);
			thread.Name = "Log Manager Cleanup Thread";
			thread.Start();
			MessageBox.Show("Released CLI Components (may kill them if needed).\nPress OK when all CLI Components seems to have exited.");
		}
	}

	private void UI_TAB_MainTab_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (UI_TAB_MainTab.get_SelectedTab() == UI_TAB_Main_Messages && UI_CM_AutoScroll.get_Checked() && 0 < UI_LV_LogInfo.get_Items().get_Count())
		{
			UI_LV_LogInfo.EnsureVisible(UI_LV_LogInfo.get_Items().get_Count() - 1);
		}
	}

	private void Display(string s)
	{
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		UI_LB_LOG_Status.BeginUpdate();
		UI_LB_LOG_Status.get_Items().Add((object)s);
		if (1000 < UI_LB_LOG_Status.get_Items().get_Count())
		{
			for (int i = 0; i < 100; i++)
			{
				UI_LB_LOG_Status.get_Items().RemoveAt(0);
			}
		}
		if (UI_CM_LOG_Status_AutoScroll.get_Checked() && 0 < UI_LB_LOG_Status.get_Items().get_Count())
		{
			UI_LB_LOG_Status.SetSelected(UI_LB_LOG_Status.get_Items().get_Count() - 1, true);
		}
		UI_LB_LOG_Status.EndUpdate();
		SLog message = new SLog((MessageType)2, "Display: " + s, -2);
		AddMessage(message);
	}

	private void UI_CM_LOG_Status_AutoScroll_CheckedChanged(object sender, EventArgs e)
	{
		CheckBox val = (CheckBox)((sender is CheckBox) ? sender : null);
		if (val != null && UI_CM_LOG_Status_AutoScroll.get_Checked() && 0 < UI_LB_LOG_Status.get_Items().get_Count())
		{
			UI_LB_LOG_Status.set_SelectedItem(UI_LB_LOG_Status.get_Items().get_Item(UI_LB_LOG_Status.get_Items().get_Count() - 1));
		}
	}

	private void UI_B_Clear_LOG_Status_Click(object sender, EventArgs e)
	{
		UI_LB_LOG_Status.get_Items().Clear();
	}

	private void LogManager_Load(object sender, EventArgs e)
	{
	}

	private bool ReadManifestDestiny()
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		UI_LB_CLI.BeginUpdate();
		UI_LB_CLI.get_Items().Clear();
		xManifest = XManifest.NewXManifest();
		if (xManifest != null)
		{
			xManifest.ReadManifest();
			bool flag = false;
			if (xManifest.get_Components() == null)
			{
				MessageBox.Show("Found CLI but found no Components.");
				return false;
			}
			flag = true;
			int count = xManifest.get_Components().get_Count();
			CLIComponents = new CLIProcess[count];
			for (int i = 0; i < count; i++)
			{
				XComponentBase val = xManifest.get_Components().Get(i);
				if (val != null)
				{
					CLIProcess cLIProcess = new CLIProcess();
					cLIProcess.c = val;
					cLIProcess.l = false;
					cLIProcess.d = false;
					cLIProcess.args = "";
					CLIComponents[i] = cLIProcess;
					UI_LB_CLI.get_Items().Add((object)cLIProcess);
				}
			}
			if (0 < UI_LB_CLI.get_Items().get_Count())
			{
				((ListControl)UI_LB_CLI).set_SelectedIndex(0);
				if (!flag)
				{
					MessageBox.Show("No CLI Components in Manifest.");
					return false;
				}
				UI_LB_CLI.EndUpdate();
				return true;
			}
			MessageBox.Show("Found CLI and Components, but none were valid.");
			return false;
		}
		MessageBox.Show("Can't read Manifest");
		return false;
	}

	private void UI_LB_CLI_SelectedIndexChanged(object sender, EventArgs e)
	{
		UI_CM_CLIDebugging.set_CheckState((CheckState)2);
		UI_CM_LogToLOG.set_CheckState((CheckState)2);
		((Control)UI_CM_CLIDebugging).set_Enabled(true);
		((Control)UI_CM_LogToLOG).set_Enabled(true);
		object selectedItem = UI_LB_CLI.get_SelectedItem();
		if (selectedItem != null)
		{
			if (selectedItem is CLIProcess cLIProcess)
			{
				UI_CM_CLIDebugging.set_CheckState((CheckState)(cLIProcess.d ? 1 : 0));
				UI_CM_LogToLOG.set_CheckState((CheckState)((!cLIProcess.l) ? 1 : 0));
				((Control)UI_TB_CLI_Args).set_Text(cLIProcess.args);
			}
			else
			{
				Display("Internal error: Entry is NULL");
				UI_LB_CLI.set_SelectedItem((object)null);
			}
		}
	}

	private void UI_B_StartCLI_Click(object sender, EventArgs e)
	{
		object selectedItem = UI_LB_CLI.get_SelectedItem();
		if (selectedItem == null)
		{
			return;
		}
		if (selectedItem is CLIProcess cLIProcess)
		{
			cLIProcess.d = UI_CM_CLIDebugging.get_Checked();
			cLIProcess.l = !UI_CM_LogToLOG.get_Checked();
			cLIProcess.args = ((Control)UI_TB_CLI_Args).get_Text();
			try
			{
				string text = "Start " + cLIProcess.ToString();
				if (cLIProcess.args.Length > 0)
				{
					text = text + " " + cLIProcess.args;
				}
				string[] array = text.Split(new char[1] { ' ' });
				Communications.CallMOM(array);
				Display(string.Concat(cLIProcess, " started"));
				return;
			}
			catch (Exception ex)
			{
				Display(string.Concat("Failed to start ", cLIProcess, ": ", ex.Message));
				return;
			}
		}
		Display("Internal error: Entry is NULL");
		UI_LB_CLI.set_SelectedItem((object)null);
	}

	private void UI_B_StopCLI_Click(object sender, EventArgs e)
	{
		object selectedItem = UI_LB_CLI.get_SelectedItem();
		if (selectedItem != null)
		{
			CLIProcess cLIProcess = selectedItem as CLIProcess;
			cLIProcess.d = UI_CM_CLIDebugging.get_Checked();
			cLIProcess.l = !UI_CM_LogToLOG.get_Checked();
			cLIProcess.args = ((Control)UI_TB_CLI_Args).get_Text();
			try
			{
				string text = cLIProcess.ToString() + (("" != cLIProcess.args) ? (" " + cLIProcess.args) : "");
				string[] array = new string[2] { "Stop", text };
				Communications.CallMOM(array);
				Display(string.Concat(cLIProcess, " stopped"));
				return;
			}
			catch (Exception ex)
			{
				Display(string.Concat("Failed to stop ", cLIProcess, ": ", ex.Message));
				return;
			}
		}
		Display("Internal error: Entry is NULL");
		UI_LB_CLI.set_SelectedItem((object)null);
	}

	private void UI_B_DeleteProfile_Click(object sender, EventArgs e)
	{
		string text = Services.get_LocalAppDataPath() + "Profiles.XML";
		if (Utilities.LocalAppDataFileExists("Profiles.XML"))
		{
			Display("About to delete " + text);
			try
			{
				File.Delete(text);
				Display("Deleted");
				return;
			}
			catch (Exception ex)
			{
				Display("Delete failed: " + ex.Message);
				return;
			}
		}
		Display(text + " does not exist.");
	}

	private void UI_CB_CCC_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		object selectedItem = UI_CB_CCC.get_SelectedItem();
		if (selectedItem == null)
		{
			return;
		}
		CCC val = (CCC)selectedItem;
		List<CccComponent> components = val.components;
		((Control)this).SuspendLayout();
		((Control)UI_TB_PID).set_Text(val.ProcessId.ToString());
		UI_LB_CCC.get_Items().Clear();
		foreach (CccComponent item in components)
		{
			UI_LB_CCC.get_Items().Add((object)item);
		}
		((Control)this).ResumeLayout();
	}

	private void UI_LB_CCC_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		object selectedItem = UI_LB_CCC.get_SelectedItem();
		if (selectedItem == null)
		{
			return;
		}
		string[] args = ((CccComponent)selectedItem).Args;
		((Control)this).SuspendLayout();
		if (args != null)
		{
			string text = string.Empty;
			string[] array = args;
			foreach (string text2 in array)
			{
				text = text + text2 + " ";
			}
			((Control)UI_TB_CCC_Args).set_Text(text);
		}
		else
		{
			((Control)UI_TB_CCC_Args).set_Text(string.Empty);
		}
		((Control)this).ResumeLayout();
	}

	private void logger_CccComponentsHandler(CCC theCCC)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)this).get_InvokeRequired())
		{
			((Control)this).Invoke((Delegate)cccComponentsHandler, new object[1] { theCCC });
			return;
		}
		((Control)this).SuspendLayout();
		if (theCCC.components.Count == 0)
		{
			if (myCCCs.ContainsKey(theCCC.Id))
			{
				myCCCs.Remove(theCCC.Id);
			}
			UI_CB_CCC.get_Items().Remove((object)theCCC);
		}
		else
		{
			myCCCs[theCCC.Id] = theCCC;
		}
		UI_CB_CCC.get_Items().Clear();
		foreach (CCC value in myCCCs.Values)
		{
			UI_CB_CCC.get_Items().Add((object)value);
		}
		((Control)this).ResumeLayout();
	}

	public void NotifyeeComponentUpdated(SComponent newSComponent)
	{
		if (((Control)this).get_InvokeRequired())
		{
			((Control)this).Invoke((Delegate)(object)ComponentRT_U, new object[1] { newSComponent });
		}
		else
		{
			HideCaste();
			ShowComponent();
			((Control)this).Refresh();
		}
	}

	public void NotifyeeComponentExiting()
	{
		if (((Control)this).get_InvokeRequired())
		{
			((Control)this).Invoke((Delegate)(object)ComponentRT_E);
		}
		else
		{
			IComponentDisconnect();
		}
	}

	public void NotifyeeComponentChanges(SComponent newSComponent)
	{
		if (((Control)this).get_InvokeRequired())
		{
			((Control)this).Invoke((Delegate)(object)ComponentRT_C, new object[1] { newSComponent });
		}
	}

	public void NotifyeeLanguageChanged(Tongue t)
	{
		if (((Control)this).get_InvokeRequired())
		{
			((Control)this).Invoke((Delegate)(object)ComponentRT_L, new object[1] { t });
			return;
		}
		LanguageCounter++;
		if (t.Code != currentLanguage.Code)
		{
			currentLanguage = t;
			LanguageChanges++;
		}
		DisplayLanguage();
	}

	public void NotifyeeSkinMolting(Flesh f)
	{
		if (((Control)this).get_InvokeRequired())
		{
			((Control)this).Invoke((Delegate)(object)ComponentRT_S, new object[1] { f });
			return;
		}
		SkinCounter++;
		if (f.SkinName != currentSkin.SkinName)
		{
			currentSkin = f;
			SkinChanges++;
		}
		DisplaySkin();
	}

	public void NotifyeeValueChanges(SCCAA sCCAANew)
	{
		if ((object)typeof(SCaste) == ((object)sCCAANew).GetType())
		{
			NotifyeeCasteValueChanges((SCaste)(object)((sCCAANew is SCaste) ? sCCAANew : null));
		}
		else if ((object)typeof(SAdapter) == ((object)sCCAANew).GetType())
		{
			NotifyeeAdapterValueChanges((SAdapter)(object)((sCCAANew is SAdapter) ? sCCAANew : null));
		}
		else if ((object)typeof(SAspect) == ((object)sCCAANew).GetType())
		{
			NotifyeeAspectValueChanges((SAspect)(object)((sCCAANew is SAspect) ? sCCAANew : null));
		}
	}

	private void NotifyeeCasteValueChanges(SCaste sCasteNew)
	{
		if (((Control)this).get_InvokeRequired())
		{
			((Control)this).Invoke((Delegate)(object)CasteRT_C, new object[1] { sCasteNew });
			return;
		}
		if (((SCCAA)sCasteNew).IsNewerThan((SCCAA)(object)sCaste))
		{
			sCaste = sCasteNew;
			HideAdapter();
			ShowCaste();
		}
		((Control)this).Refresh();
	}

	private void NotifyeeAdapterValueChanges(SAdapter sAdapterNew)
	{
		if (((Control)this).get_InvokeRequired())
		{
			((Control)this).Invoke((Delegate)(object)AdapterRT_C, new object[1] { sAdapterNew });
			return;
		}
		if (((SCCAA)sAdapterNew).IsNewerThan((SCCAA)(object)sAdapter))
		{
			sAdapter = sAdapterNew;
			HideAspect();
			ShowAdapter();
		}
		((Control)this).Refresh();
	}

	private void NotifyeeAspectValueChanges(SAspect sAspectNew)
	{
		if (((Control)this).get_InvokeRequired())
		{
			((Control)this).Invoke((Delegate)(object)AspectRT_C, new object[1] { sAspectNew });
			return;
		}
		if (((SCCAA)sAspectNew).IsNewerThan((SCCAA)(object)sAspect))
		{
			sAspect = sAspectNew;
			HideFeature();
			ShowAspect();
		}
		((Control)this).Refresh();
	}

	private void DisplayLanguage()
	{
		((Control)UI_TB_LanguageCounter).set_Text(LanguageCounter.ToString());
		((Control)UI_TB_LanguageChanges).set_Text(LanguageChanges.ToString());
		((Control)UI_TB_LanguageCurrent).set_Text(currentLanguage.Code);
	}

	private void DisplaySkin()
	{
		((Control)UI_TB_SkinCounter).set_Text(SkinCounter.ToString());
		((Control)UI_TB_SkinChanges).set_Text(SkinChanges.ToString());
		((Control)UI_TB_SkinCurrent).set_Text(currentSkin.SkinName);
	}

	private void HideComponent()
	{
		HideCaste();
		((Control)UI_GB_IComponent).set_Enabled(false);
		((Control)UI_B_RuntimeConnect).set_Text("Connect");
		((Control)UI_TB_RuntimePID).set_Text("No PID");
		((Control)UI_TB_UnApplied).set_Text("UnApplied?");
	}

	private void ShowComponent()
	{
		((Control)UI_TB_UnApplied).set_Text("Unknown");
		try
		{
			bool flag = ((ICCAAFP)IComponentRT).UnApplied();
			((Control)UI_TB_UnApplied).set_Text(flag ? "Dirty" : "Clean");
		}
		catch
		{
			Display("Failed to call IComponent.UnApplied");
		}
		string[] sCasteNames = IComponentRT.GetSCasteNames();
		int num = sCasteNames.Length;
		if (0 >= num)
		{
			return;
		}
		UI_CB_Caste.BeginUpdate();
		UI_CB_Caste.get_Items().Clear();
		for (int i = 0; i < num; i++)
		{
			string text = sCasteNames[i];
			if (text != null && text.Length > 0)
			{
				UI_CB_Caste.get_Items().Add((object)text);
			}
		}
		UI_CB_Caste.EndUpdate();
		if (0 < UI_CB_Caste.get_Items().get_Count())
		{
			((ListControl)UI_CB_Caste).set_SelectedIndex(0);
			((Control)UI_GB_CasteInfo).set_Enabled(true);
		}
	}

	private void CancelCaste()
	{
		HideAdapter();
		((Control)UI_TB_ChangeCounterCaste).set_Text("Change Counter");
		((Control)UI_TB_ChangeCounterCaste).set_Enabled(false);
		if (ICasteRT != null)
		{
			try
			{
				((ICCAA)ICasteRT).remove_ValueChanges(CasteRT_C);
			}
			catch
			{
			}
			ICasteRT = null;
		}
	}

	private void HideCaste()
	{
		CancelCaste();
		((Control)UI_GB_CasteInfo).set_Enabled(false);
		UI_CB_Caste.get_Items().Clear();
	}

	private void ShowCaste()
	{
		if (ICasteRT == null)
		{
			return;
		}
		string text = (((ICCAAFP)ICasteRT).UnApplied() ? "Dirty: " : "Clean: ");
		((Control)UI_TB_ChangeCounterCaste).set_Text(text + ((SCCAA)sCaste).get_ChangeCount());
		((Control)UI_TB_ChangeCounterCaste).set_Enabled(true);
		int numberOfAdapters = ICasteRT.GetNumberOfAdapters();
		if (0 < numberOfAdapters)
		{
			UI_CB_Adapter.BeginUpdate();
			UI_CB_Adapter.get_Items().Clear();
			for (int i = 0; i < numberOfAdapters; i++)
			{
				UI_CB_Adapter.get_Items().Add((object)i.ToString());
			}
			UI_CB_Adapter.EndUpdate();
			if (0 < UI_CB_Adapter.get_Items().get_Count())
			{
				((ListControl)UI_CB_Adapter).set_SelectedIndex(0);
				((Control)UI_GB_AdapterInfo).set_Enabled(true);
				((Control)UI_CB_Adapter).set_Enabled(true);
			}
		}
		else
		{
			Display("GetSCaste returned no Adapters");
		}
	}

	private void CancelAdapter()
	{
		HideAspect();
		((Control)UI_TB_ChangeCounterAdapter).set_Text("Change Counter");
		((Control)UI_TB_ChangeCounterAdapter).set_Enabled(false);
		if (IAdapterRT != null)
		{
			try
			{
				((ICCAA)IAdapterRT).remove_ValueChanges(AdapterRT_C);
			}
			catch
			{
			}
			IAdapterRT = null;
		}
	}

	private void HideAdapter()
	{
		CancelAdapter();
		((Control)UI_GB_AdapterInfo).set_Enabled(false);
		UI_CB_Adapter.get_Items().Clear();
	}

	private void ShowAdapter()
	{
		if (IAdapterRT == null)
		{
			return;
		}
		string text = (((ICCAAFP)IAdapterRT).UnApplied() ? "Dirty: " : "Clean: ");
		((Control)UI_TB_ChangeCounterAdapter).set_Text(text + ((SCCAA)sAdapter).get_ChangeCount());
		((Control)UI_TB_ChangeCounterAdapter).set_Enabled(true);
		IAdapter iAdapterRT = IAdapterRT;
		HAdapter val = (HAdapter)(object)((iAdapterRT is HAdapter) ? iAdapterRT : null);
		string[] sAspectNames = val.GetSAspectNames();
		int num = sAspectNames.Length;
		if (0 < num)
		{
			UI_CB_Aspect.BeginUpdate();
			UI_CB_Aspect.get_Items().Clear();
			for (int i = 0; i < num; i++)
			{
				string text2 = sAspectNames[i];
				if (text2 != null && text2.Length > 0)
				{
					UI_CB_Aspect.get_Items().Add((object)text2);
				}
			}
			UI_CB_Aspect.EndUpdate();
			if (0 < UI_CB_Aspect.get_Items().get_Count())
			{
				((ListControl)UI_CB_Aspect).set_SelectedIndex(0);
				((Control)UI_GB_AspectInfo).set_Enabled(true);
				((Control)UI_CB_Aspect).set_Enabled(true);
			}
		}
		else
		{
			Display("GetSAdapter returned no Aspects");
		}
	}

	private void CancelAspect()
	{
		HideFeature();
		((Control)UI_TB_ChangeCounterAspect).set_Text("Change Counter");
		((Control)UI_TB_ChangeCounterAspect).set_Enabled(false);
		if (IAspectRT != null)
		{
			try
			{
				((ICCAA)IAspectRT).remove_ValueChanges(AspectRT_C);
			}
			catch
			{
			}
			IAspectRT = null;
		}
	}

	private void HideAspect()
	{
		CancelAspect();
		((Control)UI_GB_AspectInfo).set_Enabled(false);
		UI_CB_Aspect.get_Items().Clear();
	}

	private void ShowAspect()
	{
		if (IAspectRT == null)
		{
			return;
		}
		string text = (((ICCAAFP)IAspectRT).UnApplied() ? "Dirty: " : "Clean: ");
		((Control)UI_TB_ChangeCounterAspect).set_Text(text + ((SCCAA)sAspect).get_ChangeCount());
		((Control)UI_TB_ChangeCounterAspect).set_Enabled(true);
		sFeatures = ((SCCAA)sAspect).get_Features();
		int num = sFeatures.Length;
		if (0 < num)
		{
			UI_CB_Feature.BeginUpdate();
			UI_CB_Feature.get_Items().Clear();
			for (int i = 0; i < num; i++)
			{
				Feature val = sFeatures[i];
				string text2 = (val.UnApplied() ? "Dirty: " : "Clean: ");
				UI_CB_Feature.get_Items().Add((object)(text2 + ((NamedO)val).get_InstanceName()));
			}
			UI_CB_Feature.EndUpdate();
			((ListControl)UI_CB_Feature).set_SelectedIndex(0);
			((Control)UI_GB_FeatureInfo).set_Enabled(true);
			((Control)UI_CB_Feature).set_Enabled(true);
		}
		else
		{
			Display("Aspect has no Features");
		}
	}

	private void HideFeature()
	{
		HideProperty();
		((Control)UI_GB_FeatureInfo).set_Enabled(false);
		((Control)UI_TB_SFeatureActive).set_Text("Unknown");
		((Control)UI_TB_SFeatureActive).set_Enabled(false);
	}

	private void HideProperty()
	{
		((Control)UI_TB_SFeatureActive).set_Enabled(false);
		((Control)UI_GB_PropertyInfo).set_Enabled(false);
		((Control)UI_CB_Property_Immutable).set_Enabled(false);
		((Control)UI_CB_Property).set_Enabled(false);
		((Control)UI_TB_SPropertyRepeats).set_Text("Number times to set");
		((Control)UI_TB_SPropertyRepeats).set_Enabled(false);
		((TextBoxBase)UI_TB_SetSProperty).Clear();
		((Control)UI_TB_SetSProperty).set_Enabled(false);
		UI_CB_Property.get_Items().Clear();
		UI_CB_Property_Immutable.get_Items().Clear();
		((Control)UI_B_GetSProperty_Immutable).set_Enabled(false);
		((Control)UI_B_GetSProperty).set_Enabled(false);
	}

	private void IComponentDisconnect()
	{
		IPMDisconnect();
		((Control)UI_GB_IPM).set_Enabled(false);
		((Control)UI_GB_Language).set_Enabled(false);
		((Control)UI_GB_Skin).set_Enabled(false);
		HideComponent();
		if (IComponentRT != null)
		{
			try
			{
				IComponentRT.remove_SkinMolting(ComponentRT_S);
				IComponentRT.remove_ComponentUpdated(ComponentRT_U);
				IComponentRT.remove_ComponentExiting(ComponentRT_E);
				IComponentRT.remove_ComponentChanges(ComponentRT_C);
				IComponentRT.remove_LanguageChanged(ComponentRT_L);
			}
			catch
			{
			}
			IComponentRT = null;
		}
	}

	private void UI_B_RuntimeConnect_Click(object sender, EventArgs e)
	{
		if (IComponentRT != null)
		{
			IComponentDisconnect();
			return;
		}
		IMBRO val = Communications.ConnectToObject("Runtime");
		if (val != null)
		{
			IComponentRT = (IComponent)(object)((val is IComponent) ? val : null);
			if (IComponentRT != null)
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\ATI\\ACE");
				if (registryKey != null)
				{
					registryKey = registryKey.OpenSubKey("Runtime", writable: true);
				}
				if (registryKey != null)
				{
					object value = registryKey.GetValue("ProcessID");
					if (value != null)
					{
						int num = (int)value;
						((Control)UI_TB_RuntimePID).set_Text("PID= " + num);
					}
				}
				else
				{
					((Control)UI_TB_RuntimePID).set_Text("Missing PID");
				}
				((Control)UI_B_RuntimeConnect).set_Text("Disconnect");
				((Control)UI_GB_IComponent).set_Enabled(true);
				((Control)UI_GB_CasteInfo).set_Enabled(true);
				((Control)UI_GB_IPM).set_Enabled(true);
				LanguageStuff();
				SkinStuff();
				Display("Connected to Runtime");
				IComponentRT.add_ComponentUpdated(ComponentRT_U);
				IComponentRT.add_ComponentExiting(ComponentRT_E);
				IComponentRT.add_ComponentChanges(ComponentRT_C);
				IComponentRT.add_LanguageChanged(ComponentRT_L);
				IComponentRT.add_SkinMolting(ComponentRT_S);
				NotifyeeComponentUpdated(null);
			}
			else
			{
				Display("Runtime is not an IComponent");
			}
		}
		else
		{
			Display("Runtime is not (yet) available - try again.");
		}
	}

	private void LanguageStuff()
	{
		LanguageCounter = 0;
		LanguageChanges = 0;
		currentLanguage = IComponentRT.get_Language();
		DisplayLanguage();
		UI_CB_Languages.BeginUpdate();
		UI_CB_Languages.get_Items().Clear();
		UI_CB_Languages.get_Items().AddRange((object[])IComponentRT.get_Languages());
		UI_CB_Languages.EndUpdate();
		((Control)UI_GB_Language).set_Enabled(true);
	}

	private void SkinStuff()
	{
		SkinCounter = 0;
		SkinChanges = 0;
		currentSkin = IComponentRT.get_Skin();
		DisplaySkin();
		UI_CB_Skins.BeginUpdate();
		UI_CB_Skins.get_Items().Clear();
		UI_CB_Skins.get_Items().AddRange((object[])IComponentRT.get_Skins());
		UI_CB_Skins.EndUpdate();
		((Control)UI_GB_Skin).set_Enabled(true);
	}

	private void UI_CB_Languages_SelectedIndexChanged(object sender, EventArgs e)
	{
		object selectedItem = UI_CB_Languages.get_SelectedItem();
		if (selectedItem == null)
		{
			return;
		}
		Tongue val = (Tongue)((selectedItem is Tongue) ? selectedItem : null);
		if (val != null)
		{
			IComponentRT.set_Language(val);
			if (val.Code != IComponentRT.get_Language().Code)
			{
				Display("Requested Language not supported");
			}
		}
		else
		{
			Display("Languages ComboBox error");
		}
	}

	private void UI_CB_Skins_SelectedIndexChanged(object sender, EventArgs e)
	{
		object selectedItem = UI_CB_Skins.get_SelectedItem();
		if (selectedItem == null)
		{
			return;
		}
		Flesh val = (Flesh)((selectedItem is Flesh) ? selectedItem : null);
		if (val != null)
		{
			IComponentRT.set_Skin(val);
			if (val.SkinName != IComponentRT.get_Skin().SkinName)
			{
				Display("Requested Skin not supported");
			}
		}
		else
		{
			Display("Skins ComboBox error");
		}
	}

	private void UI_B_GetSCaste_Click(object sender, EventArgs e)
	{
		CancelCaste();
		try
		{
			IComponent iComponentRT = IComponentRT;
			sCaste = iComponentRT.GetSCaste(((Control)UI_CB_Caste).get_Text());
		}
		catch (Exception ex)
		{
			Display("GetSCaste failed : " + ex.Message);
		}
		if (sCaste != null)
		{
			((Control)UI_TB_ChangeCounterCaste).set_Enabled(true);
			Display("GetSCaste returned SCaste[" + ((NamedO)sCaste).get_InstanceName() + "]");
			ICasteRT = sCaste.ICaste;
			ShowCaste();
			((ICCAA)ICasteRT).add_ValueChanges(CasteRT_C);
		}
		else
		{
			Display("GetSCaste returned NULL");
		}
	}

	private void UI_B_GetSAdapter_Click(object sender, EventArgs e)
	{
		CancelAdapter();
		try
		{
			sAdapter = ICasteRT.GetSAdapter(((ListControl)UI_CB_Adapter).get_SelectedIndex());
		}
		catch (Exception ex)
		{
			Display("GetSAdapter failed : " + ex.Message);
		}
		if (sAdapter != null)
		{
			((Control)UI_TB_ChangeCounterAdapter).set_Enabled(true);
			((Control)UI_GB_AspectInfo).set_Text("Aspect Info for " + ((NamedO)sAdapter).get_InstanceName());
			Display("GetSAdapter returned SAdapter[" + ((NamedO)sAdapter).get_InstanceName() + "]");
			IAdapterRT = sAdapter.IAdapter;
			ShowAdapter();
			((ICCAA)IAdapterRT).add_ValueChanges(AdapterRT_C);
		}
		else
		{
			Display("GetSAdapter returned NULL");
		}
	}

	private void UI_B_GetSAspect_Click(object sender, EventArgs e)
	{
		CancelAspect();
		try
		{
			sAspect = IAdapterRT.GetSAspect(((Control)UI_CB_Aspect).get_Text());
		}
		catch (Exception ex)
		{
			Display("GetSAspect failed: " + ex.Message);
		}
		if (sAspect != null)
		{
			((Control)UI_TB_ChangeCounterAspect).set_Enabled(true);
			Display("GetSAspect returned SAspect[" + ((NamedO)sAspect).get_InstanceName() + "]");
			IAspectRT = sAspect.IAspect;
			ShowAspect();
			((ICCAA)IAspectRT).add_ValueChanges(AspectRT_C);
		}
		else
		{
			Display("GetSAspect returned NULL");
		}
	}

	private void UI_B_GetSFeature_Click(object sender, EventArgs e)
	{
		HideProperty();
		int selectedIndex = ((ListControl)UI_CB_Feature).get_SelectedIndex();
		try
		{
			Feature val = sFeatures[selectedIndex];
			sWriteable = val.get_Writeables();
			sImmutable = val.get_Immutables();
			if (val.get_VisibleToAnyone())
			{
				((Control)UI_TB_SFeatureActive).set_Text("VisibleToAnyone");
			}
			else
			{
				((Control)UI_TB_SFeatureActive).set_Text("Not Available");
			}
			((Control)UI_TB_SFeatureActive).set_Enabled(true);
		}
		catch (Exception ex)
		{
			Display("GetSFeature failed : " + ex.Message);
		}
		if (sWriteable != null && sImmutable != null)
		{
			Display("GetSFeature returned SFeature[" + ((NamedO)sFeatures[selectedIndex]).get_InstanceName() + "]");
			int num = sImmutable.Length;
			if (0 < num)
			{
				for (int i = 0; i < sImmutable.Length; i++)
				{
					IImmutable val2 = sImmutable[i];
					UI_CB_Property_Immutable.get_Items().Add((object)("Fixed: " + ((INamed)val2).get_InstanceName()));
				}
				((Control)UI_CB_Property_Immutable).set_Enabled(true);
				((Control)UI_B_GetSProperty_Immutable).set_Enabled(true);
			}
			else
			{
				Display("Feature has no Immutable Properties");
			}
			num = sWriteable.Length;
			if (0 < num)
			{
				for (int j = 0; j < sWriteable.Length; j++)
				{
					IWriteable val3 = sWriteable[j];
					string text = (val3.UnApplied() ? "Dirty: " : "Clean: ");
					UI_CB_Property.get_Items().Add((object)(text + ((INamed)val3).get_InstanceName()));
				}
				((Control)UI_CB_Property).set_Enabled(true);
				((ListControl)UI_CB_Property).set_SelectedIndex(0);
				((Control)UI_GB_PropertyInfo).set_Enabled(true);
				((Control)UI_B_SetSProperty).set_Enabled(false);
				((Control)UI_B_SetSPropertyRepeat).set_Enabled(false);
				((Control)UI_TB_SetSProperty).set_Enabled(false);
				((Control)UI_TB_SPropertyRepeats).set_Enabled(false);
				((Control)UI_B_GetSProperty).set_Enabled(true);
			}
			else
			{
				Display("Feature has no Writeable Properties");
			}
		}
		else
		{
			Display("GetSFeature detected invalid set of Properties (null)");
		}
	}

	private void UI_B_GetSProperty_Immutable_Click(object sender, EventArgs e)
	{
		try
		{
			IImmutable val = sImmutable[((ListControl)UI_CB_Property_Immutable).get_SelectedIndex()];
			Display("Get Immutable [" + ((INamed)val).get_InstanceName() + "] = [" + val.GetCurrentValue() + "]");
		}
		catch (Exception ex)
		{
			Display("GetSProperty_Immutable failed: " + ex.Message);
		}
	}

	private void UI_B_GetSProperty_Click(object sender, EventArgs e)
	{
		try
		{
			IWriteable val = sWriteable[((ListControl)UI_CB_Property).get_SelectedIndex()];
			Display("Get Writable [" + ((INamed)val).get_InstanceName() + "] = [" + ((IImmutable)val).GetCurrentValue() + "]");
		}
		catch (Exception ex)
		{
			Display("GetSProperty failed: " + ex.Message);
		}
		((TextBoxBase)UI_TB_SPropertyRepeats).Clear();
		((TextBoxBase)UI_TB_SetSProperty).Clear();
		((Control)UI_TB_SetSProperty).set_Enabled(true);
		((Control)UI_TB_SPropertyRepeats).set_Enabled(true);
	}

	private void UI_B_SetSProperty_Click(object sender, EventArgs e)
	{
		try
		{
			IWriteable val = sWriteable[((ListControl)UI_CB_Property).get_SelectedIndex()];
			string text = ((Control)UI_TB_SetSProperty).get_Text();
			Display("Set Property [" + ((INamed)val).get_InstanceName() + "] = [" + text + "]");
			val.SetRequestedValue(text);
			((ICCAA)sAspect.IAspect).Put((SCCAA)(object)sAspect);
		}
		catch (Exception ex)
		{
			Display("SetSProperty failed: " + ex.Message);
		}
	}

	private void UI_B_SetSPropertyRepeat_Click(object sender, EventArgs e)
	{
		IWriteable val = sWriteable[((ListControl)UI_CB_Property).get_SelectedIndex()];
		string text = ((Control)UI_TB_SetSProperty).get_Text();
		string currentValue = ((IImmutable)val).GetCurrentValue();
		try
		{
			string text2 = "Every half second, repeat SetProperty [" + ((INamed)val).get_InstanceName() + "] with [" + text + "] and [" + currentValue + "] for " + SetPropertyRepeats + " times each: Count ";
			for (int i = 0; i < SetPropertyRepeats; i++)
			{
				Display(text2 + i);
				((Control)this).Refresh();
				val.SetRequestedValue(text);
				Thread.Sleep(500);
				val.SetRequestedValue(currentValue);
				Thread.Sleep(500);
			}
			Display("Done " + SetPropertyRepeats + " times");
		}
		catch (Exception ex)
		{
			Display("SetSProperty failed: " + ex.Message);
		}
	}

	private void UI_CB_Caste_SelectedIndexChanged(object sender, EventArgs e)
	{
		CancelCaste();
		ShowCaste();
	}

	private void UI_CB_Adapter_SelectedIndexChanged(object sender, EventArgs e)
	{
		CancelAdapter();
		ShowAdapter();
	}

	private void UI_CB_Aspect_SelectedIndexChanged(object sender, EventArgs e)
	{
		CancelAspect();
		ShowAspect();
	}

	private void UI_CB_Feature_SelectedIndexChanged(object sender, EventArgs e)
	{
		HideProperty();
	}

	private void UI_TB_SetSProperty_KeyUp(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() != 13)
		{
			return;
		}
		if (((Control)UI_TB_SetSProperty).get_Text() != null && 0 < ((Control)UI_TB_SetSProperty).get_Text().Length)
		{
			Display("Will use this to Set SProperty: " + ((Control)UI_TB_SetSProperty).get_Text());
			((Control)UI_B_SetSProperty).set_Enabled(true);
			if (0 < SetPropertyRepeats)
			{
				((Control)UI_B_SetSPropertyRepeat).set_Enabled(true);
			}
		}
		else
		{
			((Control)UI_B_SetSProperty).set_Enabled(false);
			((Control)UI_B_SetSPropertyRepeat).set_Enabled(false);
		}
	}

	private void UI_TB_SPropertyRepeats_KeyUp(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() != 13)
		{
			return;
		}
		if (((Control)UI_TB_SPropertyRepeats).get_Text() != null && 0 < ((Control)UI_TB_SPropertyRepeats).get_Text().Length)
		{
			try
			{
				SetPropertyRepeats = int.Parse(((Control)UI_TB_SPropertyRepeats).get_Text());
				if (0 < SetPropertyRepeats)
				{
					Display("Repeat count of " + SetPropertyRepeats);
					if (((Control)UI_TB_SetSProperty).get_Text().Length > 0)
					{
						((Control)UI_B_SetSPropertyRepeat).set_Enabled(true);
					}
				}
				else
				{
					SetPropertyRepeats = 0;
					((TextBoxBase)UI_TB_SPropertyRepeats).Clear();
					((Control)UI_B_SetSPropertyRepeat).set_Enabled(false);
				}
				return;
			}
			catch
			{
				SetPropertyRepeats = 0;
				((TextBoxBase)UI_TB_SPropertyRepeats).Clear();
				((Control)UI_B_SetSPropertyRepeat).set_Enabled(false);
				return;
			}
		}
		SetPropertyRepeats = 0;
		((TextBoxBase)UI_TB_SPropertyRepeats).Clear();
		((Control)UI_B_SetSPropertyRepeat).set_Enabled(false);
	}

	private void UI_B_IComponentApply_Click(object sender, EventArgs e)
	{
		IComponent iComponentRT = IComponentRT;
		Display("Calling Apply");
		try
		{
			iComponentRT.Apply((ApplyType)0);
		}
		catch (Exception ex)
		{
			Display("Apply failed: " + ex.Message);
			IComponentDisconnect();
		}
	}

	private void UI_B_IComponentCancel_Click(object sender, EventArgs e)
	{
		IComponent iComponentRT = IComponentRT;
		Display("Calling Cancel");
		try
		{
			iComponentRT.Cancel();
		}
		catch (Exception ex)
		{
			Display("Cancel failed: " + ex.Message);
			IComponentDisconnect();
		}
	}

	private void UI_B_IComponentRefresh_Click(object sender, EventArgs e)
	{
		IComponent iComponentRT = IComponentRT;
		Display("Calling Refresh");
		try
		{
			iComponentRT.Refresh();
		}
		catch (Exception ex)
		{
			Display("Refresh failed: " + ex.Message);
			IComponentDisconnect();
		}
	}

	private void UI_B_IComponentFactory_Click(object sender, EventArgs e)
	{
		IComponent iComponentRT = IComponentRT;
		Display("Calling Factory");
		try
		{
			iComponentRT.Factory();
		}
		catch (Exception ex)
		{
			Display("Factory failed: " + ex.Message);
			IComponentDisconnect();
		}
	}

	private void UI_B_LanguageReset_Click(object sender, EventArgs e)
	{
		IComponent iComponentRT = IComponentRT;
		Display("Resetting Language");
		try
		{
			iComponentRT.set_Language((Tongue)null);
		}
		catch (Exception ex)
		{
			Display("Reset Language failed: " + ex.Message);
			IComponentDisconnect();
		}
	}

	private void logger_LogUpdate(LogEventArgs e)
	{
		if (((Control)this).get_InvokeRequired())
		{
			((Control)this).Invoke((Delegate)logUpdateEventHandler, new object[1] { e });
			return;
		}
		lock (UI_LV_LogInfo)
		{
			AddMessage(e.Message);
		}
	}

	private void AddMessage(SLog message)
	{
		if (logMessages.Count > 10000)
		{
			logMessages.RemoveRange(0, 500);
			UpdateListViewTable(DomainNameFilter, AssemblyNameFilter, NamespaceFilter, MessageTextFilter);
		}
		logMessages.Add(message);
		logger.SaveLogMessage(((object)message).ToString());
		if (!UI_CB_AppDomain.get_Items().Contains((object)message.DomainName))
		{
			UI_CB_AppDomain.get_Items().Add((object)message.DomainName);
		}
		if (!UI_CB_AssemblyName.get_Items().Contains((object)message.AssemblyName))
		{
			UI_CB_AssemblyName.get_Items().Add((object)message.AssemblyName);
		}
		if (MatchesCurrentFilter(message) && !loggingPaused)
		{
			lock (UI_LV_LogInfo)
			{
				UI_LV_LogInfo.BeginUpdate();
				AddLogToListView(message);
				MakeVisible();
				UI_LV_LogInfo.EndUpdate();
			}
		}
	}

	private bool MatchesCurrentFilter(SLog message)
	{
		return logger.MatchesFilter(message, DomainNameFilter, AssemblyNameFilter, NamespaceFilter, MessageTextFilter);
	}

	private void UpdateListViewTable(string domainName, string assemblyName, string namespc, string messageText)
	{
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		lock (UI_LV_LogInfo)
		{
			if (logMessages.Count == 0)
			{
				return;
			}
			UI_LV_LogInfo.BeginUpdate();
			UI_LV_LogInfo.get_Items().Clear();
			foreach (SLog logMessage in logMessages)
			{
				SLog val = logMessage;
				if (logger.MatchesFilter(val, domainName, assemblyName, namespc, messageText))
				{
					AddLogToListView(val);
				}
			}
			MakeVisible();
			UI_LV_LogInfo.EndUpdate();
		}
	}

	private void AddLogToListView(SLog message)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected I4, but got Unknown
		ListViewItem val = new ListViewItem(message.LogTime.ToString(), 0);
		val.get_SubItems().Add(message.Message);
		val.get_SubItems().Add(message.MethodName);
		val.get_SubItems().Add(message.ClassName);
		val.get_SubItems().Add(message.DomainName);
		val.get_SubItems().Add(message.AssemblyName);
		val.get_SubItems().Add(((object)message.MessageType).ToString());
		val.get_SubItems().Add(message.ProcessID.ToString());
		val.get_SubItems().Add(message.ThreadName);
		val.set_Tag((object)message);
		MessageType messageType = message.MessageType;
		switch ((int)messageType)
		{
		default:
			val.set_ForeColor(Color.Black);
			break;
		case 0:
			val.set_ForeColor(Color.Purple);
			break;
		case 1:
			val.set_ForeColor(Color.Red);
			break;
		case 2:
			val.set_ForeColor(Color.Green);
			break;
		}
		UI_LV_LogInfo.get_Items().Add(val);
	}

	private void MakeVisible()
	{
		if (UI_CM_AutoScroll.get_Checked() && 0 < UI_LV_LogInfo.get_Items().get_Count())
		{
			UI_LV_LogInfo.EnsureVisible(UI_LV_LogInfo.get_Items().get_Count() - 1);
		}
	}

	private void UI_B_PauseLogging_Click(object sender, EventArgs e)
	{
		loggingPaused = !loggingPaused;
		((Control)UI_B_PauseLogging).set_Text(loggingPaused ? "Resume" : "Pause");
		if (!loggingPaused)
		{
			UpdateListViewTable(DomainNameFilter, AssemblyNameFilter, NamespaceFilter, MessageTextFilter);
		}
	}

	private void UI_B_SaveTable_Click(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		loggingPaused = true;
		SaveFileDialog val = new SaveFileDialog();
		((FileDialog)val).set_Filter("txt files (*.txt)|*.txt");
		((CommonDialog)val).ShowDialog();
		string fileName = ((FileDialog)val).get_FileName();
		if (fileName == null || fileName.Equals(string.Empty))
		{
			return;
		}
		try
		{
			StreamWriter streamWriter = new StreamWriter(fileName);
			lock (UI_LV_LogInfo)
			{
				foreach (ListViewItem item in UI_LV_LogInfo.get_Items())
				{
					ListViewItem val2 = item;
					streamWriter.WriteLine(val2.get_Tag().ToString());
				}
			}
			streamWriter.Close();
			Process.Start("notepad.exe", fileName);
		}
		finally
		{
			loggingPaused = false;
			UpdateListViewTable(DomainNameFilter, AssemblyNameFilter, NamespaceFilter, MessageTextFilter);
		}
	}

	private void UI_B_ClearAllLogMessages_Click(object sender, EventArgs e)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Invalid comparison between Unknown and I4
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			bool flag;
			if (!(flag = !UI_B_LogMessagesConfirmClear.get_Checked()))
			{
				DialogResult val = MessageBox.Show("All the log messages that have been received so far will be deleted, continue?", "Log Manager", (MessageBoxButtons)4, (MessageBoxIcon)48);
				flag = (int)val == 6;
			}
			if (flag)
			{
				loggingPaused = false;
				((Control)UI_B_PauseLogging).set_Text("Pause");
				UpdateListViewTable(DomainNameFilter, AssemblyNameFilter, NamespaceFilter, MessageTextFilter);
				lock (UI_LV_LogInfo)
				{
					UI_LV_LogInfo.BeginUpdate();
					UI_LV_LogInfo.get_Items().Clear();
					UI_LV_LogInfo.EndUpdate();
				}
				logMessages.Clear();
				loggingPaused = false;
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void UI_CB_AssemblyName_SelectionChangeCommitted(object sender, EventArgs e)
	{
		UpdateListViewTable(DomainNameFilter, AssemblyNameFilter, NamespaceFilter, MessageTextFilter);
	}

	private void UI_TB_NamespaceClass_KeyUp(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() == 13)
		{
			UpdateListViewTable(DomainNameFilter, AssemblyNameFilter, NamespaceFilter, MessageTextFilter);
			if (((Control)UI_TB_NamespaceClass).get_Text().Length == 0)
			{
				((Control)UI_TB_NamespaceClass).set_Text("<Search by part of namespace+class name>");
			}
		}
	}

	private void UI_TB_Message_KeyUp(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() == 13)
		{
			UpdateListViewTable(DomainNameFilter, AssemblyNameFilter, NamespaceFilter, MessageTextFilter);
			if (((Control)UI_TB_Message).get_Text().Length == 0)
			{
				((Control)UI_TB_Message).set_Text("<Search by part of message text>");
			}
		}
	}

	private void UI_CM_AutoScroll_CheckedChanged(object sender, EventArgs e)
	{
		CheckBox val = (CheckBox)((sender is CheckBox) ? sender : null);
		if (val == null)
		{
			return;
		}
		lock (UI_LV_LogInfo)
		{
			if (UI_CM_AutoScroll.get_Checked() && 0 < UI_LV_LogInfo.get_Items().get_Count())
			{
				UI_LV_LogInfo.EnsureVisible(UI_LV_LogInfo.get_Items().get_Count() - 1);
			}
		}
	}

	private void UI_LV_LogInfo_SelectedIndexChanged(object sender, EventArgs e)
	{
		string text = "";
		string text2 = "";
		string text3 = "";
		string text4 = "";
		lock (UI_LV_LogInfo)
		{
			int count = UI_LV_LogInfo.get_SelectedItems().get_Count();
			if (0 < count)
			{
				ListViewItem val = UI_LV_LogInfo.get_SelectedItems().get_Item(0);
				text = val.get_SubItems().get_Item(5).get_Text();
				text2 = val.get_SubItems().get_Item(4).get_Text();
				text3 = val.get_SubItems().get_Item(3).get_Text();
				text4 = val.get_SubItems().get_Item(2).get_Text();
			}
		}
		((Control)UI_TB_AssemblyCurrent).set_Text(text);
		((Control)UI_TB_AppDomainCurrent).set_Text(text2);
		((Control)UI_TB_ClassCurrent).set_Text(text3);
		((Control)UI_TB_MethodName).set_Text(text4);
	}

	private void UI_B_CopyMessage_Click(object sender, EventArgs e)
	{
		lock (UI_LV_LogInfo)
		{
			int count = UI_LV_LogInfo.get_SelectedItems().get_Count();
			if (0 >= count)
			{
				return;
			}
			bool flag = false;
			StringBuilder stringBuilder = new StringBuilder(4096);
			for (int i = 0; i < count; i++)
			{
				string value = UI_LV_LogInfo.get_SelectedItems().get_Item(i).get_Tag()
					.ToString();
				if (flag)
				{
					stringBuilder.Append("\r\n");
				}
				stringBuilder.Append(value);
				flag = true;
			}
			Clipboard.SetDataObject((object)stringBuilder.ToString(), true);
		}
	}

	private void logger_AppDomainRegister(IServices s)
	{
		if (((Control)this).get_InvokeRequired())
		{
			((Control)this).Invoke((Delegate)appDomainRegisterHandler, new object[1] { s });
			return;
		}
		UI_LB_AppDomains.get_Items().Add((object)new ServicesWrapper(s));
		if (0 > ((ListControl)UI_LB_AppDomains).get_SelectedIndex())
		{
			((ListControl)UI_LB_AppDomains).set_SelectedIndex(0);
		}
		((Control)UI_GB_AppDomains).set_Enabled(true);
		UI_LB_AppDomains_SelectedIndexChanged(null, null);
	}

	private void logger_AppDomainUnregister(string s)
	{
		if (((Control)this).get_InvokeRequired())
		{
			((Control)this).Invoke((Delegate)appDomainUnregisterHandler, new object[1] { s });
			return;
		}
		foreach (object item in UI_LB_AppDomains.get_Items())
		{
			if (item != null && item is ServicesWrapper servicesWrapper && s == servicesWrapper.sn)
			{
				RemoveServices(servicesWrapper);
				break;
			}
		}
	}

	private IServices GetServices()
	{
		if (UI_LB_AppDomains.get_SelectedItem() is ServicesWrapper servicesWrapper)
		{
			try
			{
				IServices s = servicesWrapper.s;
				if (s == null)
				{
					RemoveServices(servicesWrapper);
				}
				return s;
			}
			catch
			{
				RemoveServices(servicesWrapper);
			}
		}
		return null;
	}

	private void RemoveServices(ServicesWrapper sW)
	{
		Display(sW.sn + " is no longer reachable - removing");
		UI_LB_AppDomains.get_Items().Remove((object)sW);
		if (0 < UI_LB_AppDomains.get_Items().get_Count())
		{
			((ListControl)UI_LB_AppDomains).set_SelectedIndex(0);
		}
		else
		{
			((Control)UI_GB_AppDomains).set_Enabled(false);
		}
		UI_LB_AppDomains_SelectedIndexChanged(null, null);
	}

	private void DoAppDomainList(string[] list)
	{
		Array.Sort(list);
		((Control)UI_B_CopyAppDomains).set_Enabled(false);
		UI_LB_AppDomainItems.BeginUpdate();
		UI_LB_AppDomainItems.get_Items().Clear();
		int num = list.Length;
		bool flag = false;
		if (0 < num)
		{
			for (int i = 0; i < num; i++)
			{
				if (list[i] != null)
				{
					UI_LB_AppDomainItems.get_Items().Add((object)list[i]);
					flag = true;
				}
			}
			if (flag)
			{
				((Control)UI_B_CopyAppDomains).set_Enabled(true);
			}
		}
		UI_LB_AppDomainItems.EndUpdate();
	}

	private void UI_LB_AppDomains_SelectedIndexChanged(object sender, EventArgs e)
	{
		bool @checked = false;
		bool checked2 = false;
		bool flag = false;
		UI_LB_AppDomainItems.get_Items().Clear();
		((Control)UI_B_CopyAppDomains).set_Enabled(false);
		IServices services = GetServices();
		if (services != null)
		{
			try
			{
				@checked = services.get_Errors();
				checked2 = services.get_Exceptions();
				flag = services.get_Locally();
			}
			catch
			{
				RemoveServices(UI_LB_AppDomains.get_SelectedItem() as ServicesWrapper);
			}
		}
		UI_CM_DebugMessages.set_Checked(false);
		UI_CM_ErrorMessages.set_Checked(@checked);
		UI_CM_ExceptionMessages.set_Checked(checked2);
		UI_CM_AppDomainLogToLOG.set_Checked(!flag);
		((Control)UI_GB_AppDomains).Refresh();
	}

	private void UI_CM_DebugMessages_CheckedChanged(object sender, EventArgs e)
	{
		GetServices();
	}

	private void UI_CM_ErrorMessages_CheckedChanged(object sender, EventArgs e)
	{
		IServices services = GetServices();
		if (services != null)
		{
			services.set_Errors(UI_CM_ErrorMessages.get_Checked());
		}
	}

	private void UI_CM_ExceptionMessages_CheckedChanged(object sender, EventArgs e)
	{
		IServices services = GetServices();
		if (services != null)
		{
			services.set_Exceptions(UI_CM_ExceptionMessages.get_Checked());
		}
	}

	private void UI_CM_AppDomainLogToLOG_CheckedChanged(object sender, EventArgs e)
	{
		IServices services = GetServices();
		if (services != null)
		{
			services.set_Locally(!UI_CM_AppDomainLogToLOG.get_Checked());
		}
	}

	private void UI_B_GetAppDomainAssemblies_Click(object sender, EventArgs e)
	{
		IServices services = GetServices();
		if (services != null)
		{
			string[] assemblies = services.GetAssemblies();
			if (assemblies != null && 0 < assemblies.Length)
			{
				DoAppDomainList(assemblies);
			}
			else
			{
				Display("Odd... No assemblies are loaded in the AppDomain.");
			}
		}
	}

	private void UI_B_GetPublished_Click(object sender, EventArgs e)
	{
		IServices services = GetServices();
		if (services != null)
		{
			string[] publishedObjects = services.GetPublishedObjects();
			if (publishedObjects != null && 0 < publishedObjects.Length)
			{
				DoAppDomainList(publishedObjects);
			}
			else
			{
				Display("No published objects in this particular AppDomain.");
			}
		}
	}

	private void UI_B_CopyAppDomains_Click(object sender, EventArgs e)
	{
		int count = UI_LB_AppDomainItems.get_Items().get_Count();
		if (0 < count)
		{
			string text = UI_LB_AppDomains.get_SelectedItem().ToString();
			for (int i = 0; i < count; i++)
			{
				text += "\r\n\t";
				text += UI_LB_AppDomainItems.get_Items().get_Item(i);
			}
			Clipboard.SetDataObject((object)text, true);
		}
	}

	private void UI_B_Delete_ACE_LogFile_Click(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		AddMessage(new SLog((MessageType)2, "Test Debug Message", 0));
		AddMessage(new SLog((MessageType)1, "Test Error Message", 0));
		AddMessage(new SLog((MessageType)0, "Test Exception Message", 0));
	}

	private void UI_B_Open_Windows_EventLog_Click(object sender, EventArgs e)
	{
		Process.Start(Environment.SystemDirectory + "\\eventvwr.msc");
	}

	private void UI_B_Clear_Windows_EventLog_Click(object sender, EventArgs e)
	{
		logger.ClearWndsEvtLog();
	}

	private void UI_B_Open_ACE_LogFile_Click(object sender, EventArgs e)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string fileName = Environment.SystemDirectory.ToString() + "\\notepad.exe";
			Process.Start(fileName, logger.FullPathFileName);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void UI_B_IPM_Connect_Click(object sender, EventArgs e)
	{
		if (iPM != null)
		{
			IPMDisconnect();
			return;
		}
		IMBRO val = Communications.ConnectToObject("ProfileManager");
		if (val != null)
		{
			iPM = (IProfileManager)(object)((val is IProfileManager) ? val : null);
			if (iPM != null)
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\ATI\\ACE");
				if (registryKey != null)
				{
					registryKey = registryKey.OpenSubKey("ProfileManager", writable: true);
				}
				if (registryKey != null)
				{
					object value = registryKey.GetValue("ProcessID");
					if (value != null)
					{
						int num = (int)value;
						((Control)UI_TB_IPM_PID).set_Text("PID= " + num);
					}
				}
				else
				{
					((Control)UI_TB_IPM_PID).set_Text("Missing PID");
				}
				((Control)UI_B_IPM_Connect).set_Text("Disconnect");
				UI_IPM_GetList_Click(null, null);
				((Control)UI_GB_Profiles).set_Enabled(true);
				Display("Connected to ProfileManager");
			}
			else
			{
				Display("ProfileManager is not an IPM");
			}
		}
		else
		{
			Display("ProfileManager is not (yet) available - try again.");
		}
	}

	private void IPMDisconnect()
	{
		((Control)UI_GB_Profiles).set_Enabled(false);
		UI_LB_Profiles.get_Items().Clear();
		((Control)UI_B_IPM_Connect).set_Text("Connect");
		((Control)UI_TB_IPM_PID).set_Text("No PID");
		if (iPM != null)
		{
			iPM = null;
		}
	}

	private void UI_IPM_GetList_Click(object sender, EventArgs e)
	{
		try
		{
			NamedProfileDescriptor[] namedProfiles = iPM.GetNamedProfiles();
			if (namedProfiles.Length > 0)
			{
				UI_LB_Profiles.BeginUpdate();
				UI_LB_Profiles.get_Items().Clear();
				NamedProfileDescriptor[] array = namedProfiles;
				foreach (NamedProfileDescriptor val in array)
				{
					UI_LB_Profiles.get_Items().Add((object)val);
				}
			}
			else
			{
				Display("Empty list from Profile Manager");
			}
		}
		catch (Exception ex)
		{
			Display("GetList Exception: " + ex.Message);
		}
		finally
		{
			UI_LB_Profiles.EndUpdate();
		}
	}

	private void UI_B_IPM_Load_Click(object sender, EventArgs e)
	{
		try
		{
			object selectedItem = UI_LB_Profiles.get_SelectedItem();
			if (selectedItem != null)
			{
				NamedProfileDescriptor val = (NamedProfileDescriptor)((selectedItem is NamedProfileDescriptor) ? selectedItem : null);
				if (val != null)
				{
					Display("Loading and Applying " + val.get_Name());
					iPM.ApplyNamedProfile(val.get_Name());
				}
				else
				{
					Display("Selected item is not a Profile");
				}
			}
			else
			{
				Display("No selected items to Load");
			}
		}
		catch (Exception ex)
		{
			Display("UI_B_IPM_Load_Click: " + ex.Message);
		}
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected O, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected O, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected O, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected O, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected O, but got Unknown
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected O, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected O, but got Unknown
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected O, but got Unknown
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected O, but got Unknown
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected O, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected O, but got Unknown
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected O, but got Unknown
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected O, but got Unknown
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected O, but got Unknown
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected O, but got Unknown
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected O, but got Unknown
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected O, but got Unknown
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected O, but got Unknown
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected O, but got Unknown
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected O, but got Unknown
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected O, but got Unknown
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected O, but got Unknown
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected O, but got Unknown
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected O, but got Unknown
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected O, but got Unknown
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected O, but got Unknown
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected O, but got Unknown
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Expected O, but got Unknown
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Expected O, but got Unknown
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Expected O, but got Unknown
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected O, but got Unknown
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Expected O, but got Unknown
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected O, but got Unknown
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Expected O, but got Unknown
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Expected O, but got Unknown
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Expected O, but got Unknown
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Expected O, but got Unknown
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Expected O, but got Unknown
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Expected O, but got Unknown
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Expected O, but got Unknown
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected O, but got Unknown
		//IL_0437: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Expected O, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Expected O, but got Unknown
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Expected O, but got Unknown
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Expected O, but got Unknown
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Expected O, but got Unknown
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Expected O, but got Unknown
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_0483: Expected O, but got Unknown
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Expected O, but got Unknown
		//IL_048f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0499: Expected O, but got Unknown
		//IL_049a: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a4: Expected O, but got Unknown
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Expected O, but got Unknown
		//IL_04b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Expected O, but got Unknown
		//IL_04bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Expected O, but got Unknown
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Expected O, but got Unknown
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04db: Expected O, but got Unknown
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Expected O, but got Unknown
		//IL_04e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f1: Expected O, but got Unknown
		//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fc: Expected O, but got Unknown
		//IL_04fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0507: Expected O, but got Unknown
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_0512: Expected O, but got Unknown
		//IL_0513: Unknown result type (might be due to invalid IL or missing references)
		//IL_051d: Expected O, but got Unknown
		//IL_051e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0528: Expected O, but got Unknown
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Expected O, but got Unknown
		//IL_0534: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Expected O, but got Unknown
		//IL_053f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0549: Expected O, but got Unknown
		//IL_054a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0554: Expected O, but got Unknown
		//IL_0555: Unknown result type (might be due to invalid IL or missing references)
		//IL_055f: Expected O, but got Unknown
		//IL_0560: Unknown result type (might be due to invalid IL or missing references)
		//IL_056a: Expected O, but got Unknown
		//IL_056b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0575: Expected O, but got Unknown
		//IL_0576: Unknown result type (might be due to invalid IL or missing references)
		//IL_0580: Expected O, but got Unknown
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_058b: Expected O, but got Unknown
		//IL_058c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0596: Expected O, but got Unknown
		//IL_0cc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccd: Expected O, but got Unknown
		//IL_0df9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e03: Expected O, but got Unknown
		//IL_0e85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8f: Expected O, but got Unknown
		//IL_0f02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0c: Expected O, but got Unknown
		//IL_0f73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f7d: Expected O, but got Unknown
		//IL_0fe0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fea: Expected O, but got Unknown
		//IL_1d58: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d62: Expected O, but got Unknown
		//IL_1dd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ddd: Expected O, but got Unknown
		//IL_3340: Unknown result type (might be due to invalid IL or missing references)
		//IL_334a: Expected O, but got Unknown
		//IL_33e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_33ee: Expected O, but got Unknown
		//IL_352e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3538: Expected O, but got Unknown
		//IL_3598: Unknown result type (might be due to invalid IL or missing references)
		//IL_35a2: Expected O, but got Unknown
		UI_B_Open_ACE_LogFile = new Button();
		UI_B_Delete_ACE_LogFile = new Button();
		UI_B_Open_Windows_EventLog = new Button();
		UI_GB_Windows_EventLog = new GroupBox();
		UI_B_Clear_Windows_EventLog = new Button();
		UI_GB_ACE_LogFile = new GroupBox();
		UI_TB_ACE_LogFile = new TextBox();
		UI_TAB_MainTab = new TabControl();
		UI_TAB_Main_Components = new TabPage();
		UI_GB_CCC = new GroupBox();
		UI_L_CCC_Args = new Label();
		UI_TB_CCC_Args = new TextBox();
		UI_B_StopCCC = new Button();
		UI_L_PID = new Label();
		UI_L_CCC = new Label();
		UI_TB_PID = new TextBox();
		UI_CB_CCC = new ComboBox();
		UI_LB_CCC = new ListBox();
		UI_GB_CLI = new GroupBox();
		UI_TB_CLI_Args = new TextBox();
		UI_L_CLI_Args = new Label();
		UI_B_StopCLI = new Button();
		UI_CM_LogToLOG = new CheckBox();
		UI_CM_CLIDebugging = new CheckBox();
		UI_B_StartCLI = new Button();
		UI_LB_CLI = new ListBox();
		UI_B_DeleteProfile = new Button();
		UI_TAB_Main_Messages = new TabPage();
		UI_GB_ACE_LogMessages = new GroupBox();
		UI_GB_MessageDetails = new GroupBox();
		UI_TB_MethodName = new TextBox();
		UI_TB_ClassCurrent = new TextBox();
		UI_TB_AppDomainCurrent = new TextBox();
		UI_TB_AssemblyCurrent = new TextBox();
		UI_GB_MessageControl = new GroupBox();
		UI_B_LogMessagesConfirmClear = new CheckBox();
		UI_B_CopyMessage = new Button();
		UI_B_SaveTable = new Button();
		UI_CM_AutoScroll = new CheckBox();
		UI_B_ClearAllLogMessages = new Button();
		UI_B_PauseLogging = new Button();
		UI_GB_Filters = new GroupBox();
		UI_TB_Message = new TextBox();
		UI_TB_NamespaceClass = new TextBox();
		UI_CB_AssemblyName = new ComboBox();
		UI_CB_AppDomain = new ComboBox();
		UI_LV_LogInfo = new ListView();
		UI_C_LogMessageTime = new ColumnHeader();
		UI_C_LogMessage = new ColumnHeader();
		UI_C_MethodName = new ColumnHeader();
		UI_C_NamespaceClass = new ColumnHeader();
		UI_C_AppDomain = new ColumnHeader();
		UI_C_AssemblyName = new ColumnHeader();
		UI_C_MessageType = new ColumnHeader();
		UI_C_ProcessID = new ColumnHeader();
		UI_C_ThreadName = new ColumnHeader();
		UI_TAB_Main_Runtime = new TabPage();
		UI_GB_Skin = new GroupBox();
		label1 = new Label();
		UI_L_NumSkinCalls = new Label();
		UI_TB_SkinChanges = new TextBox();
		UI_TB_SkinCounter = new TextBox();
		UI_TB_SkinCurrent = new TextBox();
		UI_CB_Skins = new ComboBox();
		UI_GB_Language = new GroupBox();
		UI_B_LanguageReset = new Button();
		UI_TB_LanguageChanges = new TextBox();
		UI_TB_LanguageCounter = new TextBox();
		UI_TB_LanguageCurrent = new TextBox();
		UI_CB_Languages = new ComboBox();
		UI_L_NumLanguageCalls = new Label();
		UI_L_NumLanguageChanges = new Label();
		UI_GB_Runtime = new GroupBox();
		UI_B_RuntimeConnect = new Button();
		UI_GB_CasteInfo = new GroupBox();
		UI_TB_ChangeCounterCaste = new TextBox();
		UI_B_GetSCaste = new Button();
		UI_CB_Caste = new ComboBox();
		UI_GB_AdapterInfo = new GroupBox();
		UI_TB_ChangeCounterAdapter = new TextBox();
		UI_B_GetSAdapter = new Button();
		UI_CB_Adapter = new ComboBox();
		UI_GB_FeatureInfo = new GroupBox();
		UI_TB_SFeatureActive = new TextBox();
		UI_B_GetSFeature = new Button();
		UI_CB_Feature = new ComboBox();
		UI_GB_AspectInfo = new GroupBox();
		UI_B_GetSAspect = new Button();
		UI_CB_Aspect = new ComboBox();
		UI_TB_ChangeCounterAspect = new TextBox();
		UI_GB_PropertyInfo = new GroupBox();
		UI_B_GetSProperty_Immutable = new Button();
		UI_CB_Property_Immutable = new ComboBox();
		UI_B_SetSPropertyRepeat = new Button();
		UI_TB_SPropertyRepeats = new TextBox();
		UI_TB_SetSProperty = new TextBox();
		UI_B_GetSProperty = new Button();
		UI_CB_Property = new ComboBox();
		UI_B_SetSProperty = new Button();
		UI_GB_IComponent = new GroupBox();
		UI_TB_UnApplied = new TextBox();
		UI_B_IComponentRefresh = new Button();
		UI_B_IComponentFactory = new Button();
		UI_B_IComponentCancel = new Button();
		UI_B_IComponentApply = new Button();
		UI_TB_RuntimePID = new TextBox();
		UI_TAB_Profiles = new TabPage();
		UI_GB_Profiles = new GroupBox();
		UI_B_IPM_Load = new Button();
		UI_IPM_GetList = new Button();
		UI_LB_Profiles = new ListBox();
		UI_TB_IPM_PID = new TextBox();
		UI_GB_IPM = new GroupBox();
		UI_B_IPM_Connect = new Button();
		UI_TAB_Main_Domains = new TabPage();
		UI_GB_AppDomains = new GroupBox();
		UI_GB_LOGMessageControls = new GroupBox();
		UI_CM_AppDomainLogToLOG = new CheckBox();
		UI_B_GetPublished = new Button();
		UI_B_CopyAppDomains = new Button();
		UI_B_GetAppDomainAssemblies = new Button();
		UI_CM_ExceptionMessages = new CheckBox();
		UI_CM_ErrorMessages = new CheckBox();
		UI_CM_DebugMessages = new CheckBox();
		UI_LB_AppDomains = new ListBox();
		UI_LB_AppDomainItems = new ListBox();
		UI_TAB_Main_Logfile = new TabPage();
		UI_CM_LOG_Status_AutoScroll = new CheckBox();
		UI_LB_LOG_Status = new ListBox();
		UI_B_Clear_LOG_Status = new Button();
		((Control)UI_GB_Windows_EventLog).SuspendLayout();
		((Control)UI_GB_ACE_LogFile).SuspendLayout();
		((Control)UI_TAB_MainTab).SuspendLayout();
		((Control)UI_TAB_Main_Components).SuspendLayout();
		((Control)UI_GB_CCC).SuspendLayout();
		((Control)UI_GB_CLI).SuspendLayout();
		((Control)UI_TAB_Main_Messages).SuspendLayout();
		((Control)UI_GB_ACE_LogMessages).SuspendLayout();
		((Control)UI_GB_MessageDetails).SuspendLayout();
		((Control)UI_GB_MessageControl).SuspendLayout();
		((Control)UI_GB_Filters).SuspendLayout();
		((Control)UI_TAB_Main_Runtime).SuspendLayout();
		((Control)UI_GB_Skin).SuspendLayout();
		((Control)UI_GB_Language).SuspendLayout();
		((Control)UI_GB_Runtime).SuspendLayout();
		((Control)UI_GB_CasteInfo).SuspendLayout();
		((Control)UI_GB_AdapterInfo).SuspendLayout();
		((Control)UI_GB_FeatureInfo).SuspendLayout();
		((Control)UI_GB_AspectInfo).SuspendLayout();
		((Control)UI_GB_PropertyInfo).SuspendLayout();
		((Control)UI_GB_IComponent).SuspendLayout();
		((Control)UI_TAB_Profiles).SuspendLayout();
		((Control)UI_GB_Profiles).SuspendLayout();
		((Control)UI_GB_IPM).SuspendLayout();
		((Control)UI_TAB_Main_Domains).SuspendLayout();
		((Control)UI_GB_AppDomains).SuspendLayout();
		((Control)UI_GB_LOGMessageControls).SuspendLayout();
		((Control)UI_TAB_Main_Logfile).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)UI_B_Open_ACE_LogFile).set_Anchor((AnchorStyles)9);
		((Control)UI_B_Open_ACE_LogFile).set_Location(new Point(751, 21));
		((Control)UI_B_Open_ACE_LogFile).set_Name("UI_B_Open_ACE_LogFile");
		((Control)UI_B_Open_ACE_LogFile).set_Size(new Size(71, 24));
		((Control)UI_B_Open_ACE_LogFile).set_TabIndex(4);
		((Control)UI_B_Open_ACE_LogFile).set_Text("Open");
		((Control)UI_B_Open_ACE_LogFile).add_Click((EventHandler)UI_B_Open_ACE_LogFile_Click);
		((Control)UI_B_Delete_ACE_LogFile).set_Anchor((AnchorStyles)9);
		((Control)UI_B_Delete_ACE_LogFile).set_Location(new Point(831, 21));
		((Control)UI_B_Delete_ACE_LogFile).set_Name("UI_B_Delete_ACE_LogFile");
		((Control)UI_B_Delete_ACE_LogFile).set_Size(new Size(71, 24));
		((Control)UI_B_Delete_ACE_LogFile).set_TabIndex(12);
		((Control)UI_B_Delete_ACE_LogFile).set_Text("Delete");
		((Control)UI_B_Delete_ACE_LogFile).add_Click((EventHandler)UI_B_Delete_ACE_LogFile_Click);
		((Control)UI_B_Open_Windows_EventLog).set_Location(new Point(8, 16));
		((Control)UI_B_Open_Windows_EventLog).set_Name("UI_B_Open_Windows_EventLog");
		((Control)UI_B_Open_Windows_EventLog).set_Size(new Size(72, 24));
		((Control)UI_B_Open_Windows_EventLog).set_TabIndex(14);
		((Control)UI_B_Open_Windows_EventLog).set_Text("Open");
		((Control)UI_B_Open_Windows_EventLog).add_Click((EventHandler)UI_B_Open_Windows_EventLog_Click);
		((Control)UI_GB_Windows_EventLog).set_Anchor((AnchorStyles)9);
		((Control)UI_GB_Windows_EventLog).get_Controls().Add((Control)(object)UI_B_Clear_Windows_EventLog);
		((Control)UI_GB_Windows_EventLog).get_Controls().Add((Control)(object)UI_B_Open_Windows_EventLog);
		((Control)UI_GB_Windows_EventLog).set_Location(new Point(751, 69));
		((Control)UI_GB_Windows_EventLog).set_Name("UI_GB_Windows_EventLog");
		((Control)UI_GB_Windows_EventLog).set_Size(new Size(167, 48));
		((Control)UI_GB_Windows_EventLog).set_TabIndex(15);
		UI_GB_Windows_EventLog.set_TabStop(false);
		((Control)UI_GB_Windows_EventLog).set_Text("Windows Event Log");
		((Control)UI_B_Clear_Windows_EventLog).set_Location(new Point(88, 16));
		((Control)UI_B_Clear_Windows_EventLog).set_Name("UI_B_Clear_Windows_EventLog");
		((Control)UI_B_Clear_Windows_EventLog).set_Size(new Size(72, 24));
		((Control)UI_B_Clear_Windows_EventLog).set_TabIndex(15);
		((Control)UI_B_Clear_Windows_EventLog).set_Text("Clear");
		((Control)UI_B_Clear_Windows_EventLog).add_Click((EventHandler)UI_B_Clear_Windows_EventLog_Click);
		((Control)UI_GB_ACE_LogFile).set_Anchor((AnchorStyles)13);
		((Control)UI_GB_ACE_LogFile).get_Controls().Add((Control)(object)UI_B_Delete_ACE_LogFile);
		((Control)UI_GB_ACE_LogFile).get_Controls().Add((Control)(object)UI_B_Open_ACE_LogFile);
		((Control)UI_GB_ACE_LogFile).get_Controls().Add((Control)(object)UI_TB_ACE_LogFile);
		((Control)UI_GB_ACE_LogFile).set_Location(new Point(8, 8));
		((Control)UI_GB_ACE_LogFile).set_Name("UI_GB_ACE_LogFile");
		((Control)UI_GB_ACE_LogFile).set_Size(new Size(909, 56));
		((Control)UI_GB_ACE_LogFile).set_TabIndex(17);
		UI_GB_ACE_LogFile.set_TabStop(false);
		((Control)UI_GB_ACE_LogFile).set_Text("ACE Log File");
		((Control)UI_TB_ACE_LogFile).set_Anchor((AnchorStyles)13);
		((Control)UI_TB_ACE_LogFile).set_Location(new Point(8, 24));
		((Control)UI_TB_ACE_LogFile).set_Name("UI_TB_ACE_LogFile");
		((TextBoxBase)UI_TB_ACE_LogFile).set_ReadOnly(true);
		((Control)UI_TB_ACE_LogFile).set_Size(new Size(736, 20));
		((Control)UI_TB_ACE_LogFile).set_TabIndex(14);
		((Control)UI_TAB_MainTab).set_Anchor((AnchorStyles)13);
		((Control)UI_TAB_MainTab).get_Controls().Add((Control)(object)UI_TAB_Main_Components);
		((Control)UI_TAB_MainTab).get_Controls().Add((Control)(object)UI_TAB_Main_Messages);
		((Control)UI_TAB_MainTab).get_Controls().Add((Control)(object)UI_TAB_Main_Runtime);
		((Control)UI_TAB_MainTab).get_Controls().Add((Control)(object)UI_TAB_Profiles);
		((Control)UI_TAB_MainTab).get_Controls().Add((Control)(object)UI_TAB_Main_Domains);
		((Control)UI_TAB_MainTab).get_Controls().Add((Control)(object)UI_TAB_Main_Logfile);
		((Control)UI_TAB_MainTab).set_Location(new Point(0, 7));
		((Control)UI_TAB_MainTab).set_Name("UI_TAB_MainTab");
		UI_TAB_MainTab.set_SelectedIndex(0);
		((Control)UI_TAB_MainTab).set_Size(new Size(940, 353));
		((Control)UI_TAB_MainTab).set_TabIndex(18);
		UI_TAB_MainTab.add_SelectedIndexChanged((EventHandler)UI_TAB_MainTab_SelectedIndexChanged);
		((Control)UI_TAB_Main_Components).get_Controls().Add((Control)(object)UI_GB_CCC);
		((Control)UI_TAB_Main_Components).get_Controls().Add((Control)(object)UI_GB_CLI);
		((Control)UI_TAB_Main_Components).get_Controls().Add((Control)(object)UI_B_DeleteProfile);
		UI_TAB_Main_Components.set_Location(new Point(4, 22));
		((Control)UI_TAB_Main_Components).set_Name("UI_TAB_Main_Components");
		((Control)UI_TAB_Main_Components).set_Size(new Size(932, 327));
		UI_TAB_Main_Components.set_TabIndex(3);
		((Control)UI_TAB_Main_Components).set_Text("Components");
		UI_TAB_Main_Components.set_UseVisualStyleBackColor(true);
		((Control)UI_GB_CCC).set_Anchor((AnchorStyles)13);
		((Control)UI_GB_CCC).get_Controls().Add((Control)(object)UI_L_CCC_Args);
		((Control)UI_GB_CCC).get_Controls().Add((Control)(object)UI_TB_CCC_Args);
		((Control)UI_GB_CCC).get_Controls().Add((Control)(object)UI_B_StopCCC);
		((Control)UI_GB_CCC).get_Controls().Add((Control)(object)UI_L_PID);
		((Control)UI_GB_CCC).get_Controls().Add((Control)(object)UI_L_CCC);
		((Control)UI_GB_CCC).get_Controls().Add((Control)(object)UI_TB_PID);
		((Control)UI_GB_CCC).get_Controls().Add((Control)(object)UI_CB_CCC);
		((Control)UI_GB_CCC).get_Controls().Add((Control)(object)UI_LB_CCC);
		((Control)UI_GB_CCC).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)UI_GB_CCC).set_Location(new Point(413, 8));
		((Control)UI_GB_CCC).set_Name("UI_GB_CCC");
		((Control)UI_GB_CCC).set_Size(new Size(371, 232));
		((Control)UI_GB_CCC).set_TabIndex(40);
		UI_GB_CCC.set_TabStop(false);
		((Control)UI_GB_CCC).set_Text("CCC Components");
		((Control)UI_L_CCC_Args).set_AutoSize(true);
		((Control)UI_L_CCC_Args).set_Location(new Point(37, 202));
		((Control)UI_L_CCC_Args).set_Name("UI_L_CCC_Args");
		((Control)UI_L_CCC_Args).set_Size(new Size(57, 13));
		((Control)UI_L_CCC_Args).set_TabIndex(7);
		((Control)UI_L_CCC_Args).set_Text("Arguments");
		((Control)UI_TB_CCC_Args).set_Location(new Point(128, 199));
		((Control)UI_TB_CCC_Args).set_Name("UI_TB_CCC_Args");
		((Control)UI_TB_CCC_Args).set_Size(new Size(229, 20));
		((Control)UI_TB_CCC_Args).set_TabIndex(6);
		((Control)UI_B_StopCCC).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)UI_B_StopCCC).set_Location(new Point(17, 153));
		((Control)UI_B_StopCCC).set_Name("UI_B_StopCCC");
		((Control)UI_B_StopCCC).set_Size(new Size(96, 23));
		((Control)UI_B_StopCCC).set_TabIndex(5);
		((Control)UI_B_StopCCC).set_Text("Stop");
		((ButtonBase)UI_B_StopCCC).set_UseVisualStyleBackColor(true);
		((Control)UI_L_PID).set_AutoSize(true);
		((Control)UI_L_PID).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)UI_L_PID).set_Location(new Point(17, 90));
		((Control)UI_L_PID).set_Name("UI_L_PID");
		((Control)UI_L_PID).set_Size(new Size(59, 13));
		((Control)UI_L_PID).set_TabIndex(4);
		((Control)UI_L_PID).set_Text("Process ID");
		((Control)UI_L_CCC).set_AutoSize(true);
		((Control)UI_L_CCC).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)UI_L_CCC).set_Location(new Point(17, 26));
		((Control)UI_L_CCC).set_Name("UI_L_CCC");
		((Control)UI_L_CCC).set_Size(new Size(28, 13));
		((Control)UI_L_CCC).set_TabIndex(3);
		((Control)UI_L_CCC).set_Text("CCC");
		((Control)UI_TB_PID).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)UI_TB_PID).set_Location(new Point(17, 118));
		((Control)UI_TB_PID).set_Name("UI_TB_PID");
		((TextBoxBase)UI_TB_PID).set_ReadOnly(true);
		((Control)UI_TB_PID).set_Size(new Size(96, 20));
		((Control)UI_TB_PID).set_TabIndex(2);
		((Control)UI_CB_CCC).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)UI_CB_CCC).set_FormattingEnabled(true);
		((Control)UI_CB_CCC).set_Location(new Point(17, 54));
		((Control)UI_CB_CCC).set_Name("UI_CB_CCC");
		((Control)UI_CB_CCC).set_Size(new Size(96, 21));
		((Control)UI_CB_CCC).set_TabIndex(1);
		UI_CB_CCC.add_SelectedIndexChanged((EventHandler)UI_CB_CCC_SelectedIndexChanged);
		((Control)UI_LB_CCC).set_Anchor((AnchorStyles)13);
		((ListControl)UI_LB_CCC).set_FormattingEnabled(true);
		((Control)UI_LB_CCC).set_Location(new Point(128, 19));
		((Control)UI_LB_CCC).set_Name("UI_LB_CCC");
		((Control)UI_LB_CCC).set_Size(new Size(229, 160));
		((Control)UI_LB_CCC).set_TabIndex(0);
		UI_LB_CCC.add_SelectedIndexChanged((EventHandler)UI_LB_CCC_SelectedIndexChanged);
		((Control)UI_GB_CLI).set_Anchor((AnchorStyles)13);
		((Control)UI_GB_CLI).get_Controls().Add((Control)(object)UI_TB_CLI_Args);
		((Control)UI_GB_CLI).get_Controls().Add((Control)(object)UI_L_CLI_Args);
		((Control)UI_GB_CLI).get_Controls().Add((Control)(object)UI_B_StopCLI);
		((Control)UI_GB_CLI).get_Controls().Add((Control)(object)UI_CM_LogToLOG);
		((Control)UI_GB_CLI).get_Controls().Add((Control)(object)UI_CM_CLIDebugging);
		((Control)UI_GB_CLI).get_Controls().Add((Control)(object)UI_B_StartCLI);
		((Control)UI_GB_CLI).get_Controls().Add((Control)(object)UI_LB_CLI);
		((Control)UI_GB_CLI).set_Location(new Point(8, 8));
		((Control)UI_GB_CLI).set_Name("UI_GB_CLI");
		((Control)UI_GB_CLI).set_Size(new Size(389, 232));
		((Control)UI_GB_CLI).set_TabIndex(0);
		UI_GB_CLI.set_TabStop(false);
		((Control)UI_GB_CLI).set_Text("CLI Components");
		((Control)UI_TB_CLI_Args).set_Anchor((AnchorStyles)13);
		((Control)UI_TB_CLI_Args).set_Location(new Point(120, 200));
		((Control)UI_TB_CLI_Args).set_Name("UI_TB_CLI_Args");
		((Control)UI_TB_CLI_Args).set_Size(new Size(250, 20));
		((Control)UI_TB_CLI_Args).set_TabIndex(44);
		((Control)UI_L_CLI_Args).set_Location(new Point(16, 200));
		((Control)UI_L_CLI_Args).set_Name("UI_L_CLI_Args");
		((Control)UI_L_CLI_Args).set_Size(new Size(96, 16));
		((Control)UI_L_CLI_Args).set_TabIndex(43);
		((Control)UI_L_CLI_Args).set_Text("Arguments");
		UI_L_CLI_Args.set_TextAlign((ContentAlignment)32);
		((Control)UI_B_StopCLI).set_Location(new Point(16, 48));
		((Control)UI_B_StopCLI).set_Name("UI_B_StopCLI");
		((Control)UI_B_StopCLI).set_Size(new Size(88, 23));
		((Control)UI_B_StopCLI).set_TabIndex(42);
		((Control)UI_B_StopCLI).set_Text("Stop");
		((Control)UI_B_StopCLI).add_Click((EventHandler)UI_B_StopCLI_Click);
		UI_CM_LogToLOG.set_Checked(true);
		UI_CM_LogToLOG.set_CheckState((CheckState)1);
		((Control)UI_CM_LogToLOG).set_Location(new Point(16, 144));
		((Control)UI_CM_LogToLOG).set_Name("UI_CM_LogToLOG");
		((Control)UI_CM_LogToLOG).set_Size(new Size(88, 24));
		((Control)UI_CM_LogToLOG).set_TabIndex(41);
		((Control)UI_CM_LogToLOG).set_Text("Log to LOG");
		UI_CM_CLIDebugging.set_Checked(true);
		UI_CM_CLIDebugging.set_CheckState((CheckState)1);
		((Control)UI_CM_CLIDebugging).set_Location(new Point(16, 168));
		((Control)UI_CM_CLIDebugging).set_Name("UI_CM_CLIDebugging");
		((Control)UI_CM_CLIDebugging).set_Size(new Size(88, 24));
		((Control)UI_CM_CLIDebugging).set_TabIndex(4);
		((Control)UI_CM_CLIDebugging).set_Text("Debugging");
		((Control)UI_B_StartCLI).set_Location(new Point(16, 16));
		((Control)UI_B_StartCLI).set_Name("UI_B_StartCLI");
		((Control)UI_B_StartCLI).set_Size(new Size(88, 23));
		((Control)UI_B_StartCLI).set_TabIndex(1);
		((Control)UI_B_StartCLI).set_Text("Start");
		((Control)UI_B_StartCLI).add_Click((EventHandler)UI_B_StartCLI_Click);
		((Control)UI_LB_CLI).set_Anchor((AnchorStyles)13);
		((Control)UI_LB_CLI).set_Location(new Point(120, 16));
		((Control)UI_LB_CLI).set_Name("UI_LB_CLI");
		((Control)UI_LB_CLI).set_Size(new Size(250, 173));
		((Control)UI_LB_CLI).set_TabIndex(0);
		UI_LB_CLI.add_SelectedIndexChanged((EventHandler)UI_LB_CLI_SelectedIndexChanged);
		((Control)UI_B_DeleteProfile).set_Location(new Point(16, 256));
		((Control)UI_B_DeleteProfile).set_Name("UI_B_DeleteProfile");
		((Control)UI_B_DeleteProfile).set_Size(new Size(88, 23));
		((Control)UI_B_DeleteProfile).set_TabIndex(39);
		((Control)UI_B_DeleteProfile).set_Text("Delete Profiles");
		((Control)UI_B_DeleteProfile).add_Click((EventHandler)UI_B_DeleteProfile_Click);
		((Control)UI_TAB_Main_Messages).get_Controls().Add((Control)(object)UI_GB_ACE_LogMessages);
		UI_TAB_Main_Messages.set_Location(new Point(4, 22));
		((Control)UI_TAB_Main_Messages).set_Name("UI_TAB_Main_Messages");
		((Control)UI_TAB_Main_Messages).set_Size(new Size(932, 327));
		UI_TAB_Main_Messages.set_TabIndex(0);
		((Control)UI_TAB_Main_Messages).set_Text("Messages");
		UI_TAB_Main_Messages.set_UseVisualStyleBackColor(true);
		((Control)UI_GB_ACE_LogMessages).set_Anchor((AnchorStyles)13);
		((Control)UI_GB_ACE_LogMessages).set_BackColor(SystemColors.Control);
		((Control)UI_GB_ACE_LogMessages).get_Controls().Add((Control)(object)UI_GB_MessageDetails);
		((Control)UI_GB_ACE_LogMessages).get_Controls().Add((Control)(object)UI_GB_MessageControl);
		((Control)UI_GB_ACE_LogMessages).get_Controls().Add((Control)(object)UI_GB_Filters);
		((Control)UI_GB_ACE_LogMessages).get_Controls().Add((Control)(object)UI_LV_LogInfo);
		((Control)UI_GB_ACE_LogMessages).set_Location(new Point(0, -16));
		((Control)UI_GB_ACE_LogMessages).set_Name("UI_GB_ACE_LogMessages");
		((Control)UI_GB_ACE_LogMessages).set_Size(new Size(928, 328));
		((Control)UI_GB_ACE_LogMessages).set_TabIndex(13);
		UI_GB_ACE_LogMessages.set_TabStop(false);
		((Control)UI_GB_ACE_LogMessages).set_Text("Received Log Messages");
		((Control)UI_GB_MessageDetails).set_Anchor((AnchorStyles)9);
		((Control)UI_GB_MessageDetails).get_Controls().Add((Control)(object)UI_TB_MethodName);
		((Control)UI_GB_MessageDetails).get_Controls().Add((Control)(object)UI_TB_ClassCurrent);
		((Control)UI_GB_MessageDetails).get_Controls().Add((Control)(object)UI_TB_AppDomainCurrent);
		((Control)UI_GB_MessageDetails).get_Controls().Add((Control)(object)UI_TB_AssemblyCurrent);
		((Control)UI_GB_MessageDetails).set_Location(new Point(312, 176));
		((Control)UI_GB_MessageDetails).set_Name("UI_GB_MessageDetails");
		((Control)UI_GB_MessageDetails).set_Size(new Size(408, 152));
		((Control)UI_GB_MessageDetails).set_TabIndex(23);
		UI_GB_MessageDetails.set_TabStop(false);
		((Control)UI_GB_MessageDetails).set_Text("Details");
		((Control)UI_TB_MethodName).set_Location(new Point(8, 112));
		((Control)UI_TB_MethodName).set_Name("UI_TB_MethodName");
		((TextBoxBase)UI_TB_MethodName).set_ReadOnly(true);
		((Control)UI_TB_MethodName).set_Size(new Size(392, 20));
		((Control)UI_TB_MethodName).set_TabIndex(3);
		((Control)UI_TB_ClassCurrent).set_Location(new Point(8, 80));
		((Control)UI_TB_ClassCurrent).set_Name("UI_TB_ClassCurrent");
		((TextBoxBase)UI_TB_ClassCurrent).set_ReadOnly(true);
		((Control)UI_TB_ClassCurrent).set_Size(new Size(392, 20));
		((Control)UI_TB_ClassCurrent).set_TabIndex(2);
		((Control)UI_TB_AppDomainCurrent).set_Location(new Point(8, 48));
		((Control)UI_TB_AppDomainCurrent).set_Name("UI_TB_AppDomainCurrent");
		((TextBoxBase)UI_TB_AppDomainCurrent).set_ReadOnly(true);
		((Control)UI_TB_AppDomainCurrent).set_Size(new Size(392, 20));
		((Control)UI_TB_AppDomainCurrent).set_TabIndex(1);
		((Control)UI_TB_AssemblyCurrent).set_Location(new Point(8, 16));
		((Control)UI_TB_AssemblyCurrent).set_Name("UI_TB_AssemblyCurrent");
		((TextBoxBase)UI_TB_AssemblyCurrent).set_ReadOnly(true);
		((Control)UI_TB_AssemblyCurrent).set_Size(new Size(392, 20));
		((Control)UI_TB_AssemblyCurrent).set_TabIndex(0);
		((Control)UI_GB_MessageControl).set_Anchor((AnchorStyles)9);
		((Control)UI_GB_MessageControl).get_Controls().Add((Control)(object)UI_B_LogMessagesConfirmClear);
		((Control)UI_GB_MessageControl).get_Controls().Add((Control)(object)UI_B_CopyMessage);
		((Control)UI_GB_MessageControl).get_Controls().Add((Control)(object)UI_B_SaveTable);
		((Control)UI_GB_MessageControl).get_Controls().Add((Control)(object)UI_CM_AutoScroll);
		((Control)UI_GB_MessageControl).get_Controls().Add((Control)(object)UI_B_ClearAllLogMessages);
		((Control)UI_GB_MessageControl).get_Controls().Add((Control)(object)UI_B_PauseLogging);
		((Control)UI_GB_MessageControl).set_Location(new Point(720, 176));
		((Control)UI_GB_MessageControl).set_Name("UI_GB_MessageControl");
		((Control)UI_GB_MessageControl).set_Size(new Size(200, 112));
		((Control)UI_GB_MessageControl).set_TabIndex(22);
		UI_GB_MessageControl.set_TabStop(false);
		((Control)UI_GB_MessageControl).set_Text("Controls");
		((Control)UI_B_LogMessagesConfirmClear).set_Location(new Point(8, 80));
		((Control)UI_B_LogMessagesConfirmClear).set_Name("UI_B_LogMessagesConfirmClear");
		((Control)UI_B_LogMessagesConfirmClear).set_Size(new Size(96, 24));
		((Control)UI_B_LogMessagesConfirmClear).set_TabIndex(29);
		((Control)UI_B_LogMessagesConfirmClear).set_Text("Confirm Clear");
		((Control)UI_B_CopyMessage).set_Location(new Point(8, 48));
		((Control)UI_B_CopyMessage).set_Name("UI_B_CopyMessage");
		((Control)UI_B_CopyMessage).set_Size(new Size(88, 23));
		((Control)UI_B_CopyMessage).set_TabIndex(28);
		((Control)UI_B_CopyMessage).set_Text("Copy Selected");
		((Control)UI_B_CopyMessage).add_Click((EventHandler)UI_B_CopyMessage_Click);
		((Control)UI_B_SaveTable).set_Location(new Point(112, 48));
		((Control)UI_B_SaveTable).set_Name("UI_B_SaveTable");
		((Control)UI_B_SaveTable).set_Size(new Size(64, 24));
		((Control)UI_B_SaveTable).set_TabIndex(22);
		((Control)UI_B_SaveTable).set_Text("Save");
		((Control)UI_B_SaveTable).add_Click((EventHandler)UI_B_SaveTable_Click);
		UI_CM_AutoScroll.set_Checked(true);
		UI_CM_AutoScroll.set_CheckState((CheckState)1);
		((Control)UI_CM_AutoScroll).set_Location(new Point(8, 16));
		((Control)UI_CM_AutoScroll).set_Name("UI_CM_AutoScroll");
		((Control)UI_CM_AutoScroll).set_Size(new Size(96, 24));
		((Control)UI_CM_AutoScroll).set_TabIndex(27);
		((Control)UI_CM_AutoScroll).set_Text("Auto-Scroll");
		UI_CM_AutoScroll.add_CheckedChanged((EventHandler)UI_CM_AutoScroll_CheckedChanged);
		((Control)UI_B_ClearAllLogMessages).set_Location(new Point(112, 80));
		((Control)UI_B_ClearAllLogMessages).set_Name("UI_B_ClearAllLogMessages");
		((Control)UI_B_ClearAllLogMessages).set_Size(new Size(64, 24));
		((Control)UI_B_ClearAllLogMessages).set_TabIndex(2);
		((Control)UI_B_ClearAllLogMessages).set_Text("Clear");
		((Control)UI_B_ClearAllLogMessages).add_Click((EventHandler)UI_B_ClearAllLogMessages_Click);
		((Control)UI_B_PauseLogging).set_Location(new Point(112, 16));
		((Control)UI_B_PauseLogging).set_Name("UI_B_PauseLogging");
		((Control)UI_B_PauseLogging).set_Size(new Size(64, 24));
		((Control)UI_B_PauseLogging).set_TabIndex(25);
		((Control)UI_B_PauseLogging).set_Text("Pause");
		((Control)UI_B_PauseLogging).add_Click((EventHandler)UI_B_PauseLogging_Click);
		((Control)UI_GB_Filters).set_Anchor((AnchorStyles)13);
		((Control)UI_GB_Filters).get_Controls().Add((Control)(object)UI_TB_Message);
		((Control)UI_GB_Filters).get_Controls().Add((Control)(object)UI_TB_NamespaceClass);
		((Control)UI_GB_Filters).get_Controls().Add((Control)(object)UI_CB_AssemblyName);
		((Control)UI_GB_Filters).get_Controls().Add((Control)(object)UI_CB_AppDomain);
		((Control)UI_GB_Filters).set_Location(new Point(0, 176));
		((Control)UI_GB_Filters).set_Name("UI_GB_Filters");
		((Control)UI_GB_Filters).set_Size(new Size(312, 152));
		((Control)UI_GB_Filters).set_TabIndex(21);
		UI_GB_Filters.set_TabStop(false);
		((Control)UI_GB_Filters).set_Text("Filters");
		((Control)UI_TB_Message).set_Anchor((AnchorStyles)13);
		((Control)UI_TB_Message).set_Location(new Point(8, 112));
		((Control)UI_TB_Message).set_Name("UI_TB_Message");
		((Control)UI_TB_Message).set_Size(new Size(296, 20));
		((Control)UI_TB_Message).set_TabIndex(23);
		((Control)UI_TB_Message).set_Text("<Search by part of message text>");
		((Control)UI_TB_Message).add_KeyUp(new KeyEventHandler(UI_TB_Message_KeyUp));
		((Control)UI_TB_NamespaceClass).set_Anchor((AnchorStyles)13);
		((Control)UI_TB_NamespaceClass).set_Location(new Point(8, 80));
		((Control)UI_TB_NamespaceClass).set_Name("UI_TB_NamespaceClass");
		((Control)UI_TB_NamespaceClass).set_Size(new Size(296, 20));
		((Control)UI_TB_NamespaceClass).set_TabIndex(22);
		((Control)UI_TB_NamespaceClass).set_Text("<Search by part of namespace+class name>");
		((Control)UI_TB_NamespaceClass).add_KeyUp(new KeyEventHandler(UI_TB_NamespaceClass_KeyUp));
		((Control)UI_CB_AssemblyName).set_Anchor((AnchorStyles)13);
		UI_CB_AssemblyName.set_ItemHeight(13);
		((Control)UI_CB_AssemblyName).set_Location(new Point(8, 16));
		((Control)UI_CB_AssemblyName).set_Name("UI_CB_AssemblyName");
		((Control)UI_CB_AssemblyName).set_Size(new Size(296, 21));
		((Control)UI_CB_AssemblyName).set_TabIndex(18);
		UI_CB_AssemblyName.add_SelectionChangeCommitted((EventHandler)UI_CB_AssemblyName_SelectionChangeCommitted);
		((Control)UI_CB_AppDomain).set_Anchor((AnchorStyles)13);
		UI_CB_AppDomain.set_ItemHeight(13);
		((Control)UI_CB_AppDomain).set_Location(new Point(8, 48));
		((Control)UI_CB_AppDomain).set_Name("UI_CB_AppDomain");
		((Control)UI_CB_AppDomain).set_Size(new Size(296, 21));
		((Control)UI_CB_AppDomain).set_TabIndex(17);
		UI_CB_AppDomain.add_SelectionChangeCommitted((EventHandler)UI_CB_AssemblyName_SelectionChangeCommitted);
		UI_LV_LogInfo.set_AllowColumnReorder(true);
		((Control)UI_LV_LogInfo).set_Anchor((AnchorStyles)13);
		((Control)UI_LV_LogInfo).set_BackColor(Color.Azure);
		UI_LV_LogInfo.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[9] { UI_C_LogMessageTime, UI_C_LogMessage, UI_C_MethodName, UI_C_NamespaceClass, UI_C_AppDomain, UI_C_AssemblyName, UI_C_MessageType, UI_C_ProcessID, UI_C_ThreadName });
		UI_LV_LogInfo.set_FullRowSelect(true);
		UI_LV_LogInfo.set_HideSelection(false);
		((Control)UI_LV_LogInfo).set_Location(new Point(0, 21));
		((Control)UI_LV_LogInfo).set_Name("UI_LV_LogInfo");
		((Control)UI_LV_LogInfo).set_Size(new Size(920, 155));
		UI_LV_LogInfo.set_Sorting((SortOrder)1);
		((Control)UI_LV_LogInfo).set_TabIndex(20);
		UI_LV_LogInfo.set_UseCompatibleStateImageBehavior(false);
		UI_LV_LogInfo.set_View((View)1);
		UI_LV_LogInfo.add_SelectedIndexChanged((EventHandler)UI_LV_LogInfo_SelectedIndexChanged);
		UI_C_LogMessageTime.set_Text("Sent Time");
		UI_C_LogMessageTime.set_Width(148);
		UI_C_LogMessage.set_Text("Error/Debug Message");
		UI_C_LogMessage.set_Width(544);
		UI_C_MethodName.set_Text("Method Name");
		UI_C_MethodName.set_Width(192);
		UI_C_NamespaceClass.set_Text("Namespace.Class Name");
		UI_C_NamespaceClass.set_Width(296);
		UI_C_AppDomain.set_Text("Domain Name");
		UI_C_AppDomain.set_Width(132);
		UI_C_AssemblyName.set_Text("Assembly Name");
		UI_C_AssemblyName.set_Width(496);
		UI_C_MessageType.set_Text("Message Type");
		UI_C_ProcessID.set_Text("Process ID");
		UI_C_ThreadName.set_Text("Thread Name");
		UI_C_ThreadName.set_Width(192);
		((Control)UI_TAB_Main_Runtime).get_Controls().Add((Control)(object)UI_GB_Skin);
		((Control)UI_TAB_Main_Runtime).get_Controls().Add((Control)(object)UI_GB_Language);
		((Control)UI_TAB_Main_Runtime).get_Controls().Add((Control)(object)UI_GB_Runtime);
		((Control)UI_TAB_Main_Runtime).get_Controls().Add((Control)(object)UI_GB_CasteInfo);
		((Control)UI_TAB_Main_Runtime).get_Controls().Add((Control)(object)UI_GB_AdapterInfo);
		((Control)UI_TAB_Main_Runtime).get_Controls().Add((Control)(object)UI_GB_FeatureInfo);
		((Control)UI_TAB_Main_Runtime).get_Controls().Add((Control)(object)UI_GB_AspectInfo);
		((Control)UI_TAB_Main_Runtime).get_Controls().Add((Control)(object)UI_GB_PropertyInfo);
		((Control)UI_TAB_Main_Runtime).get_Controls().Add((Control)(object)UI_GB_IComponent);
		UI_TAB_Main_Runtime.set_Location(new Point(4, 22));
		((Control)UI_TAB_Main_Runtime).set_Name("UI_TAB_Main_Runtime");
		((Control)UI_TAB_Main_Runtime).set_Size(new Size(932, 327));
		UI_TAB_Main_Runtime.set_TabIndex(2);
		((Control)UI_TAB_Main_Runtime).set_Text("Runtime");
		UI_TAB_Main_Runtime.set_UseVisualStyleBackColor(true);
		((Control)UI_GB_Skin).get_Controls().Add((Control)(object)label1);
		((Control)UI_GB_Skin).get_Controls().Add((Control)(object)UI_L_NumSkinCalls);
		((Control)UI_GB_Skin).get_Controls().Add((Control)(object)UI_TB_SkinChanges);
		((Control)UI_GB_Skin).get_Controls().Add((Control)(object)UI_TB_SkinCounter);
		((Control)UI_GB_Skin).get_Controls().Add((Control)(object)UI_TB_SkinCurrent);
		((Control)UI_GB_Skin).get_Controls().Add((Control)(object)UI_CB_Skins);
		((Control)UI_GB_Skin).set_Enabled(false);
		((Control)UI_GB_Skin).set_Location(new Point(144, 8));
		((Control)UI_GB_Skin).set_Name("UI_GB_Skin");
		((Control)UI_GB_Skin).set_Size(new Size(208, 144));
		((Control)UI_GB_Skin).set_TabIndex(42);
		UI_GB_Skin.set_TabStop(false);
		((Control)UI_GB_Skin).set_Text("Skin");
		((Control)label1).set_Location(new Point(112, 96));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(80, 16));
		((Control)label1).set_TabIndex(5);
		((Control)label1).set_Text("# of changes");
		((Control)UI_L_NumSkinCalls).set_Location(new Point(16, 96));
		((Control)UI_L_NumSkinCalls).set_Name("UI_L_NumSkinCalls");
		((Control)UI_L_NumSkinCalls).set_Size(new Size(80, 16));
		((Control)UI_L_NumSkinCalls).set_TabIndex(4);
		((Control)UI_L_NumSkinCalls).set_Text("# of calls");
		((Control)UI_TB_SkinChanges).set_Location(new Point(112, 112));
		((Control)UI_TB_SkinChanges).set_Name("UI_TB_SkinChanges");
		((TextBoxBase)UI_TB_SkinChanges).set_ReadOnly(true);
		((Control)UI_TB_SkinChanges).set_Size(new Size(80, 20));
		((Control)UI_TB_SkinChanges).set_TabIndex(3);
		((Control)UI_TB_SkinCounter).set_Location(new Point(16, 112));
		((Control)UI_TB_SkinCounter).set_Name("UI_TB_SkinCounter");
		((TextBoxBase)UI_TB_SkinCounter).set_ReadOnly(true);
		((Control)UI_TB_SkinCounter).set_Size(new Size(80, 20));
		((Control)UI_TB_SkinCounter).set_TabIndex(2);
		((Control)UI_TB_SkinCurrent).set_Location(new Point(16, 64));
		((Control)UI_TB_SkinCurrent).set_Name("UI_TB_SkinCurrent");
		((TextBoxBase)UI_TB_SkinCurrent).set_ReadOnly(true);
		((Control)UI_TB_SkinCurrent).set_Size(new Size(176, 20));
		((Control)UI_TB_SkinCurrent).set_TabIndex(1);
		((Control)UI_TB_SkinCurrent).set_Text("Current Skin");
		((Control)UI_CB_Skins).set_Location(new Point(16, 16));
		((Control)UI_CB_Skins).set_Name("UI_CB_Skins");
		((Control)UI_CB_Skins).set_Size(new Size(176, 21));
		((Control)UI_CB_Skins).set_TabIndex(0);
		UI_CB_Skins.add_SelectedIndexChanged((EventHandler)UI_CB_Skins_SelectedIndexChanged);
		((Control)UI_GB_Language).get_Controls().Add((Control)(object)UI_B_LanguageReset);
		((Control)UI_GB_Language).get_Controls().Add((Control)(object)UI_TB_LanguageChanges);
		((Control)UI_GB_Language).get_Controls().Add((Control)(object)UI_TB_LanguageCounter);
		((Control)UI_GB_Language).get_Controls().Add((Control)(object)UI_TB_LanguageCurrent);
		((Control)UI_GB_Language).get_Controls().Add((Control)(object)UI_CB_Languages);
		((Control)UI_GB_Language).get_Controls().Add((Control)(object)UI_L_NumLanguageCalls);
		((Control)UI_GB_Language).get_Controls().Add((Control)(object)UI_L_NumLanguageChanges);
		((Control)UI_GB_Language).set_Enabled(false);
		((Control)UI_GB_Language).set_Location(new Point(144, 152));
		((Control)UI_GB_Language).set_Name("UI_GB_Language");
		((Control)UI_GB_Language).set_Size(new Size(208, 136));
		((Control)UI_GB_Language).set_TabIndex(41);
		UI_GB_Language.set_TabStop(false);
		((Control)UI_GB_Language).set_Text("Language");
		((Control)UI_B_LanguageReset).set_Location(new Point(112, 24));
		((Control)UI_B_LanguageReset).set_Name("UI_B_LanguageReset");
		((Control)UI_B_LanguageReset).set_Size(new Size(75, 23));
		((Control)UI_B_LanguageReset).set_TabIndex(47);
		((Control)UI_B_LanguageReset).set_Text("Reset");
		((Control)UI_B_LanguageReset).add_Click((EventHandler)UI_B_LanguageReset_Click);
		((Control)UI_TB_LanguageChanges).set_Location(new Point(112, 104));
		((Control)UI_TB_LanguageChanges).set_Name("UI_TB_LanguageChanges");
		((TextBoxBase)UI_TB_LanguageChanges).set_ReadOnly(true);
		((Control)UI_TB_LanguageChanges).set_Size(new Size(80, 20));
		((Control)UI_TB_LanguageChanges).set_TabIndex(45);
		((Control)UI_TB_LanguageCounter).set_Location(new Point(16, 104));
		((Control)UI_TB_LanguageCounter).set_Name("UI_TB_LanguageCounter");
		((TextBoxBase)UI_TB_LanguageCounter).set_ReadOnly(true);
		((Control)UI_TB_LanguageCounter).set_Size(new Size(80, 20));
		((Control)UI_TB_LanguageCounter).set_TabIndex(43);
		((Control)UI_TB_LanguageCurrent).set_Location(new Point(16, 64));
		((Control)UI_TB_LanguageCurrent).set_Name("UI_TB_LanguageCurrent");
		((TextBoxBase)UI_TB_LanguageCurrent).set_ReadOnly(true);
		((Control)UI_TB_LanguageCurrent).set_Size(new Size(176, 20));
		((Control)UI_TB_LanguageCurrent).set_TabIndex(44);
		((Control)UI_TB_LanguageCurrent).set_Text("Current Language");
		((Control)UI_CB_Languages).set_Location(new Point(16, 24));
		((Control)UI_CB_Languages).set_Name("UI_CB_Languages");
		((Control)UI_CB_Languages).set_Size(new Size(80, 21));
		((Control)UI_CB_Languages).set_TabIndex(42);
		UI_CB_Languages.add_SelectedIndexChanged((EventHandler)UI_CB_Languages_SelectedIndexChanged);
		((Control)UI_L_NumLanguageCalls).set_Location(new Point(16, 88));
		((Control)UI_L_NumLanguageCalls).set_Name("UI_L_NumLanguageCalls");
		((Control)UI_L_NumLanguageCalls).set_Size(new Size(80, 16));
		((Control)UI_L_NumLanguageCalls).set_TabIndex(46);
		((Control)UI_L_NumLanguageCalls).set_Text("# of calls");
		((Control)UI_L_NumLanguageChanges).set_Location(new Point(112, 88));
		((Control)UI_L_NumLanguageChanges).set_Name("UI_L_NumLanguageChanges");
		((Control)UI_L_NumLanguageChanges).set_Size(new Size(80, 16));
		((Control)UI_L_NumLanguageChanges).set_TabIndex(42);
		((Control)UI_L_NumLanguageChanges).set_Text("# of changes");
		((Control)UI_GB_Runtime).get_Controls().Add((Control)(object)UI_B_RuntimeConnect);
		((Control)UI_GB_Runtime).set_Location(new Point(8, 8));
		((Control)UI_GB_Runtime).set_Name("UI_GB_Runtime");
		((Control)UI_GB_Runtime).set_Size(new Size(128, 48));
		((Control)UI_GB_Runtime).set_TabIndex(40);
		UI_GB_Runtime.set_TabStop(false);
		((Control)UI_GB_Runtime).set_Text("IComponent");
		((Control)UI_B_RuntimeConnect).set_Location(new Point(24, 16));
		((Control)UI_B_RuntimeConnect).set_Name("UI_B_RuntimeConnect");
		((Control)UI_B_RuntimeConnect).set_Size(new Size(80, 23));
		((Control)UI_B_RuntimeConnect).set_TabIndex(0);
		((Control)UI_B_RuntimeConnect).set_Text("Connect");
		((Control)UI_B_RuntimeConnect).add_Click((EventHandler)UI_B_RuntimeConnect_Click);
		((Control)UI_GB_CasteInfo).set_Anchor((AnchorStyles)13);
		((Control)UI_GB_CasteInfo).get_Controls().Add((Control)(object)UI_TB_ChangeCounterCaste);
		((Control)UI_GB_CasteInfo).get_Controls().Add((Control)(object)UI_B_GetSCaste);
		((Control)UI_GB_CasteInfo).get_Controls().Add((Control)(object)UI_CB_Caste);
		((Control)UI_GB_CasteInfo).set_Enabled(false);
		((Control)UI_GB_CasteInfo).set_Location(new Point(360, 7));
		((Control)UI_GB_CasteInfo).set_Name("UI_GB_CasteInfo");
		((Control)UI_GB_CasteInfo).set_Size(new Size(560, 48));
		((Control)UI_GB_CasteInfo).set_TabIndex(35);
		UI_GB_CasteInfo.set_TabStop(false);
		((Control)UI_GB_CasteInfo).set_Text("Caste Info");
		((Control)UI_TB_ChangeCounterCaste).set_Anchor((AnchorStyles)9);
		((Control)UI_TB_ChangeCounterCaste).set_Location(new Point(448, 16));
		((Control)UI_TB_ChangeCounterCaste).set_Name("UI_TB_ChangeCounterCaste");
		((TextBoxBase)UI_TB_ChangeCounterCaste).set_ReadOnly(true);
		((Control)UI_TB_ChangeCounterCaste).set_Size(new Size(104, 20));
		((Control)UI_TB_ChangeCounterCaste).set_TabIndex(26);
		((Control)UI_TB_ChangeCounterCaste).set_Text("Change Counter");
		((Control)UI_B_GetSCaste).set_Anchor((AnchorStyles)9);
		((Control)UI_B_GetSCaste).set_Location(new Point(344, 16));
		((Control)UI_B_GetSCaste).set_Name("UI_B_GetSCaste");
		((Control)UI_B_GetSCaste).set_Size(new Size(88, 23));
		((Control)UI_B_GetSCaste).set_TabIndex(23);
		((Control)UI_B_GetSCaste).set_Text("Get SCaste");
		((Control)UI_B_GetSCaste).add_Click((EventHandler)UI_B_GetSCaste_Click);
		((Control)UI_CB_Caste).set_Anchor((AnchorStyles)13);
		((Control)UI_CB_Caste).set_Location(new Point(8, 16));
		((Control)UI_CB_Caste).set_Name("UI_CB_Caste");
		((Control)UI_CB_Caste).set_Size(new Size(320, 21));
		((Control)UI_CB_Caste).set_TabIndex(25);
		UI_CB_Caste.add_SelectedIndexChanged((EventHandler)UI_CB_Caste_SelectedIndexChanged);
		((Control)UI_GB_AdapterInfo).set_Anchor((AnchorStyles)13);
		((Control)UI_GB_AdapterInfo).get_Controls().Add((Control)(object)UI_TB_ChangeCounterAdapter);
		((Control)UI_GB_AdapterInfo).get_Controls().Add((Control)(object)UI_B_GetSAdapter);
		((Control)UI_GB_AdapterInfo).get_Controls().Add((Control)(object)UI_CB_Adapter);
		((Control)UI_GB_AdapterInfo).set_Enabled(false);
		((Control)UI_GB_AdapterInfo).set_Location(new Point(360, 55));
		((Control)UI_GB_AdapterInfo).set_Name("UI_GB_AdapterInfo");
		((Control)UI_GB_AdapterInfo).set_Size(new Size(560, 48));
		((Control)UI_GB_AdapterInfo).set_TabIndex(26);
		UI_GB_AdapterInfo.set_TabStop(false);
		((Control)UI_GB_AdapterInfo).set_Text("Adapter Info");
		((Control)UI_TB_ChangeCounterAdapter).set_Anchor((AnchorStyles)9);
		((Control)UI_TB_ChangeCounterAdapter).set_Location(new Point(448, 16));
		((Control)UI_TB_ChangeCounterAdapter).set_Name("UI_TB_ChangeCounterAdapter");
		((TextBoxBase)UI_TB_ChangeCounterAdapter).set_ReadOnly(true);
		((Control)UI_TB_ChangeCounterAdapter).set_Size(new Size(104, 20));
		((Control)UI_TB_ChangeCounterAdapter).set_TabIndex(3);
		((Control)UI_TB_ChangeCounterAdapter).set_Text("Change Counter");
		((Control)UI_B_GetSAdapter).set_Anchor((AnchorStyles)9);
		((Control)UI_B_GetSAdapter).set_Location(new Point(344, 16));
		((Control)UI_B_GetSAdapter).set_Name("UI_B_GetSAdapter");
		((Control)UI_B_GetSAdapter).set_Size(new Size(88, 23));
		((Control)UI_B_GetSAdapter).set_TabIndex(2);
		((Control)UI_B_GetSAdapter).set_Text("Get SAdapter");
		((Control)UI_B_GetSAdapter).add_Click((EventHandler)UI_B_GetSAdapter_Click);
		((Control)UI_CB_Adapter).set_Anchor((AnchorStyles)13);
		((Control)UI_CB_Adapter).set_Location(new Point(8, 16));
		((Control)UI_CB_Adapter).set_Name("UI_CB_Adapter");
		((Control)UI_CB_Adapter).set_Size(new Size(320, 21));
		((Control)UI_CB_Adapter).set_TabIndex(0);
		UI_CB_Adapter.add_SelectedIndexChanged((EventHandler)UI_CB_Adapter_SelectedIndexChanged);
		((Control)UI_GB_FeatureInfo).set_Anchor((AnchorStyles)13);
		((Control)UI_GB_FeatureInfo).get_Controls().Add((Control)(object)UI_TB_SFeatureActive);
		((Control)UI_GB_FeatureInfo).get_Controls().Add((Control)(object)UI_B_GetSFeature);
		((Control)UI_GB_FeatureInfo).get_Controls().Add((Control)(object)UI_CB_Feature);
		((Control)UI_GB_FeatureInfo).set_Enabled(false);
		((Control)UI_GB_FeatureInfo).set_Location(new Point(360, 153));
		((Control)UI_GB_FeatureInfo).set_Name("UI_GB_FeatureInfo");
		((Control)UI_GB_FeatureInfo).set_Size(new Size(560, 48));
		((Control)UI_GB_FeatureInfo).set_TabIndex(28);
		UI_GB_FeatureInfo.set_TabStop(false);
		((Control)UI_GB_FeatureInfo).set_Text("Feature Info");
		((Control)UI_TB_SFeatureActive).set_Anchor((AnchorStyles)9);
		((Control)UI_TB_SFeatureActive).set_Location(new Point(448, 16));
		((Control)UI_TB_SFeatureActive).set_Name("UI_TB_SFeatureActive");
		((TextBoxBase)UI_TB_SFeatureActive).set_ReadOnly(true);
		((Control)UI_TB_SFeatureActive).set_Size(new Size(104, 20));
		((Control)UI_TB_SFeatureActive).set_TabIndex(5);
		((Control)UI_TB_SFeatureActive).set_Text("Unknown");
		((Control)UI_B_GetSFeature).set_Anchor((AnchorStyles)9);
		((Control)UI_B_GetSFeature).set_Location(new Point(344, 16));
		((Control)UI_B_GetSFeature).set_Name("UI_B_GetSFeature");
		((Control)UI_B_GetSFeature).set_Size(new Size(88, 23));
		((Control)UI_B_GetSFeature).set_TabIndex(4);
		((Control)UI_B_GetSFeature).set_Text("Get SFeature");
		((Control)UI_B_GetSFeature).add_Click((EventHandler)UI_B_GetSFeature_Click);
		((Control)UI_CB_Feature).set_Anchor((AnchorStyles)13);
		((Control)UI_CB_Feature).set_Location(new Point(8, 16));
		((Control)UI_CB_Feature).set_Name("UI_CB_Feature");
		((Control)UI_CB_Feature).set_Size(new Size(320, 21));
		((Control)UI_CB_Feature).set_TabIndex(3);
		UI_CB_Feature.add_SelectedIndexChanged((EventHandler)UI_CB_Feature_SelectedIndexChanged);
		((Control)UI_GB_AspectInfo).set_Anchor((AnchorStyles)13);
		((Control)UI_GB_AspectInfo).get_Controls().Add((Control)(object)UI_B_GetSAspect);
		((Control)UI_GB_AspectInfo).get_Controls().Add((Control)(object)UI_CB_Aspect);
		((Control)UI_GB_AspectInfo).get_Controls().Add((Control)(object)UI_TB_ChangeCounterAspect);
		((Control)UI_GB_AspectInfo).set_Enabled(false);
		((Control)UI_GB_AspectInfo).set_Location(new Point(360, 104));
		((Control)UI_GB_AspectInfo).set_Name("UI_GB_AspectInfo");
		((Control)UI_GB_AspectInfo).set_Size(new Size(560, 48));
		((Control)UI_GB_AspectInfo).set_TabIndex(27);
		UI_GB_AspectInfo.set_TabStop(false);
		((Control)UI_GB_AspectInfo).set_Text("Aspect Info");
		((Control)UI_B_GetSAspect).set_Anchor((AnchorStyles)9);
		((Control)UI_B_GetSAspect).set_Location(new Point(344, 16));
		((Control)UI_B_GetSAspect).set_Name("UI_B_GetSAspect");
		((Control)UI_B_GetSAspect).set_Size(new Size(88, 23));
		((Control)UI_B_GetSAspect).set_TabIndex(4);
		((Control)UI_B_GetSAspect).set_Text("Get SAspect");
		((Control)UI_B_GetSAspect).add_Click((EventHandler)UI_B_GetSAspect_Click);
		((Control)UI_CB_Aspect).set_Anchor((AnchorStyles)13);
		((Control)UI_CB_Aspect).set_Location(new Point(8, 16));
		((Control)UI_CB_Aspect).set_Name("UI_CB_Aspect");
		((Control)UI_CB_Aspect).set_Size(new Size(320, 21));
		((Control)UI_CB_Aspect).set_TabIndex(3);
		UI_CB_Aspect.add_SelectedIndexChanged((EventHandler)UI_CB_Aspect_SelectedIndexChanged);
		((Control)UI_TB_ChangeCounterAspect).set_Anchor((AnchorStyles)9);
		((Control)UI_TB_ChangeCounterAspect).set_Location(new Point(448, 16));
		((Control)UI_TB_ChangeCounterAspect).set_Name("UI_TB_ChangeCounterAspect");
		((TextBoxBase)UI_TB_ChangeCounterAspect).set_ReadOnly(true);
		((Control)UI_TB_ChangeCounterAspect).set_Size(new Size(104, 20));
		((Control)UI_TB_ChangeCounterAspect).set_TabIndex(27);
		((Control)UI_TB_ChangeCounterAspect).set_Text("Change Counter");
		((Control)UI_GB_PropertyInfo).set_Anchor((AnchorStyles)13);
		((Control)UI_GB_PropertyInfo).get_Controls().Add((Control)(object)UI_B_GetSProperty_Immutable);
		((Control)UI_GB_PropertyInfo).get_Controls().Add((Control)(object)UI_CB_Property_Immutable);
		((Control)UI_GB_PropertyInfo).get_Controls().Add((Control)(object)UI_B_SetSPropertyRepeat);
		((Control)UI_GB_PropertyInfo).get_Controls().Add((Control)(object)UI_TB_SPropertyRepeats);
		((Control)UI_GB_PropertyInfo).get_Controls().Add((Control)(object)UI_TB_SetSProperty);
		((Control)UI_GB_PropertyInfo).get_Controls().Add((Control)(object)UI_B_GetSProperty);
		((Control)UI_GB_PropertyInfo).get_Controls().Add((Control)(object)UI_CB_Property);
		((Control)UI_GB_PropertyInfo).get_Controls().Add((Control)(object)UI_B_SetSProperty);
		((Control)UI_GB_PropertyInfo).set_Enabled(false);
		((Control)UI_GB_PropertyInfo).set_Location(new Point(360, 200));
		((Control)UI_GB_PropertyInfo).set_Name("UI_GB_PropertyInfo");
		((Control)UI_GB_PropertyInfo).set_Size(new Size(560, 124));
		((Control)UI_GB_PropertyInfo).set_TabIndex(29);
		UI_GB_PropertyInfo.set_TabStop(false);
		((Control)UI_GB_PropertyInfo).set_Text("Property Info");
		((Control)UI_B_GetSProperty_Immutable).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)UI_B_GetSProperty_Immutable).set_Location(new Point(344, 19));
		((Control)UI_B_GetSProperty_Immutable).set_Name("UI_B_GetSProperty_Immutable");
		((Control)UI_B_GetSProperty_Immutable).set_Size(new Size(88, 23));
		((Control)UI_B_GetSProperty_Immutable).set_TabIndex(11);
		((Control)UI_B_GetSProperty_Immutable).set_Text("Get Immutable");
		((ButtonBase)UI_B_GetSProperty_Immutable).set_UseVisualStyleBackColor(true);
		((Control)UI_B_GetSProperty_Immutable).add_Click((EventHandler)UI_B_GetSProperty_Immutable_Click);
		UI_CB_Property_Immutable.set_DrawMode((DrawMode)1);
		((Control)UI_CB_Property_Immutable).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)UI_CB_Property_Immutable).set_FormattingEnabled(true);
		((Control)UI_CB_Property_Immutable).set_Location(new Point(8, 19));
		((Control)UI_CB_Property_Immutable).set_Name("UI_CB_Property_Immutable");
		((Control)UI_CB_Property_Immutable).set_Size(new Size(320, 21));
		((Control)UI_CB_Property_Immutable).set_TabIndex(10);
		((Control)UI_B_SetSPropertyRepeat).set_Anchor((AnchorStyles)9);
		((Control)UI_B_SetSPropertyRepeat).set_Location(new Point(448, 95));
		((Control)UI_B_SetSPropertyRepeat).set_Name("UI_B_SetSPropertyRepeat");
		((Control)UI_B_SetSPropertyRepeat).set_Size(new Size(104, 23));
		((Control)UI_B_SetSPropertyRepeat).set_TabIndex(9);
		((Control)UI_B_SetSPropertyRepeat).set_Text("Repeat");
		((Control)UI_B_SetSPropertyRepeat).add_Click((EventHandler)UI_B_SetSPropertyRepeat_Click);
		((Control)UI_TB_SPropertyRepeats).set_Anchor((AnchorStyles)9);
		((Control)UI_TB_SPropertyRepeats).set_Location(new Point(448, 56));
		((Control)UI_TB_SPropertyRepeats).set_Name("UI_TB_SPropertyRepeats");
		((Control)UI_TB_SPropertyRepeats).set_Size(new Size(104, 20));
		((Control)UI_TB_SPropertyRepeats).set_TabIndex(8);
		((Control)UI_TB_SPropertyRepeats).set_Text("Number times to set");
		((Control)UI_TB_SPropertyRepeats).add_KeyUp(new KeyEventHandler(UI_TB_SPropertyRepeats_KeyUp));
		((Control)UI_TB_SetSProperty).set_Anchor((AnchorStyles)13);
		((Control)UI_TB_SetSProperty).set_Location(new Point(8, 98));
		((Control)UI_TB_SetSProperty).set_Name("UI_TB_SetSProperty");
		((Control)UI_TB_SetSProperty).set_Size(new Size(320, 20));
		((Control)UI_TB_SetSProperty).set_TabIndex(6);
		((Control)UI_TB_SetSProperty).add_KeyUp(new KeyEventHandler(UI_TB_SetSProperty_KeyUp));
		((Control)UI_B_GetSProperty).set_Anchor((AnchorStyles)9);
		((Control)UI_B_GetSProperty).set_Location(new Point(344, 56));
		((Control)UI_B_GetSProperty).set_Name("UI_B_GetSProperty");
		((Control)UI_B_GetSProperty).set_Size(new Size(88, 23));
		((Control)UI_B_GetSProperty).set_TabIndex(4);
		((Control)UI_B_GetSProperty).set_Text("Get Writable");
		((Control)UI_B_GetSProperty).add_Click((EventHandler)UI_B_GetSProperty_Click);
		((Control)UI_CB_Property).set_Anchor((AnchorStyles)13);
		((Control)UI_CB_Property).set_Location(new Point(8, 56));
		((Control)UI_CB_Property).set_Name("UI_CB_Property");
		((Control)UI_CB_Property).set_Size(new Size(320, 21));
		((Control)UI_CB_Property).set_TabIndex(3);
		((Control)UI_B_SetSProperty).set_Anchor((AnchorStyles)9);
		((Control)UI_B_SetSProperty).set_Location(new Point(344, 95));
		((Control)UI_B_SetSProperty).set_Name("UI_B_SetSProperty");
		((Control)UI_B_SetSProperty).set_Size(new Size(88, 23));
		((Control)UI_B_SetSProperty).set_TabIndex(5);
		((Control)UI_B_SetSProperty).set_Text("Set Writable");
		((Control)UI_B_SetSProperty).add_Click((EventHandler)UI_B_SetSProperty_Click);
		((Control)UI_GB_IComponent).get_Controls().Add((Control)(object)UI_TB_UnApplied);
		((Control)UI_GB_IComponent).get_Controls().Add((Control)(object)UI_B_IComponentRefresh);
		((Control)UI_GB_IComponent).get_Controls().Add((Control)(object)UI_B_IComponentFactory);
		((Control)UI_GB_IComponent).get_Controls().Add((Control)(object)UI_B_IComponentCancel);
		((Control)UI_GB_IComponent).get_Controls().Add((Control)(object)UI_B_IComponentApply);
		((Control)UI_GB_IComponent).get_Controls().Add((Control)(object)UI_TB_RuntimePID);
		((Control)UI_GB_IComponent).set_Enabled(false);
		((Control)UI_GB_IComponent).set_Location(new Point(8, 64));
		((Control)UI_GB_IComponent).set_Name("UI_GB_IComponent");
		((Control)UI_GB_IComponent).set_Size(new Size(128, 224));
		((Control)UI_GB_IComponent).set_TabIndex(39);
		UI_GB_IComponent.set_TabStop(false);
		((Control)UI_GB_IComponent).set_Text("IComponent");
		((Control)UI_TB_UnApplied).set_Location(new Point(8, 192));
		((Control)UI_TB_UnApplied).set_Name("UI_TB_UnApplied");
		((TextBoxBase)UI_TB_UnApplied).set_ReadOnly(true);
		((Control)UI_TB_UnApplied).set_Size(new Size(112, 20));
		((Control)UI_TB_UnApplied).set_TabIndex(41);
		((Control)UI_TB_UnApplied).set_Text("UnApplied?");
		((Control)UI_B_IComponentRefresh).set_Location(new Point(24, 80));
		((Control)UI_B_IComponentRefresh).set_Name("UI_B_IComponentRefresh");
		((Control)UI_B_IComponentRefresh).set_Size(new Size(80, 23));
		((Control)UI_B_IComponentRefresh).set_TabIndex(38);
		((Control)UI_B_IComponentRefresh).set_Text("Refresh");
		((Control)UI_B_IComponentRefresh).add_Click((EventHandler)UI_B_IComponentRefresh_Click);
		((Control)UI_B_IComponentFactory).set_Location(new Point(24, 112));
		((Control)UI_B_IComponentFactory).set_Name("UI_B_IComponentFactory");
		((Control)UI_B_IComponentFactory).set_Size(new Size(80, 23));
		((Control)UI_B_IComponentFactory).set_TabIndex(37);
		((Control)UI_B_IComponentFactory).set_Text("Factory");
		((Control)UI_B_IComponentFactory).add_Click((EventHandler)UI_B_IComponentFactory_Click);
		((Control)UI_B_IComponentCancel).set_Location(new Point(24, 48));
		((Control)UI_B_IComponentCancel).set_Name("UI_B_IComponentCancel");
		((Control)UI_B_IComponentCancel).set_Size(new Size(80, 23));
		((Control)UI_B_IComponentCancel).set_TabIndex(36);
		((Control)UI_B_IComponentCancel).set_Text("Cancel");
		((Control)UI_B_IComponentCancel).add_Click((EventHandler)UI_B_IComponentCancel_Click);
		((Control)UI_B_IComponentApply).set_Location(new Point(24, 16));
		((Control)UI_B_IComponentApply).set_Name("UI_B_IComponentApply");
		((Control)UI_B_IComponentApply).set_Size(new Size(80, 23));
		((Control)UI_B_IComponentApply).set_TabIndex(35);
		((Control)UI_B_IComponentApply).set_Text("Apply");
		((Control)UI_B_IComponentApply).add_Click((EventHandler)UI_B_IComponentApply_Click);
		((Control)UI_TB_RuntimePID).set_Location(new Point(8, 152));
		((Control)UI_TB_RuntimePID).set_Name("UI_TB_RuntimePID");
		((TextBoxBase)UI_TB_RuntimePID).set_ReadOnly(true);
		((Control)UI_TB_RuntimePID).set_Size(new Size(112, 20));
		((Control)UI_TB_RuntimePID).set_TabIndex(40);
		((Control)UI_TB_RuntimePID).set_Text("No PID");
		((Control)UI_TAB_Profiles).get_Controls().Add((Control)(object)UI_GB_Profiles);
		((Control)UI_TAB_Profiles).get_Controls().Add((Control)(object)UI_GB_IPM);
		UI_TAB_Profiles.set_Location(new Point(4, 22));
		((Control)UI_TAB_Profiles).set_Name("UI_TAB_Profiles");
		((Control)UI_TAB_Profiles).set_Size(new Size(932, 327));
		UI_TAB_Profiles.set_TabIndex(5);
		((Control)UI_TAB_Profiles).set_Text("Profiles");
		UI_TAB_Profiles.set_UseVisualStyleBackColor(true);
		((Control)UI_GB_Profiles).set_Anchor((AnchorStyles)13);
		((Control)UI_GB_Profiles).get_Controls().Add((Control)(object)UI_B_IPM_Load);
		((Control)UI_GB_Profiles).get_Controls().Add((Control)(object)UI_IPM_GetList);
		((Control)UI_GB_Profiles).get_Controls().Add((Control)(object)UI_LB_Profiles);
		((Control)UI_GB_Profiles).get_Controls().Add((Control)(object)UI_TB_IPM_PID);
		((Control)UI_GB_Profiles).set_Enabled(false);
		((Control)UI_GB_Profiles).set_Location(new Point(152, 8));
		((Control)UI_GB_Profiles).set_Name("UI_GB_Profiles");
		((Control)UI_GB_Profiles).set_Size(new Size(768, 280));
		((Control)UI_GB_Profiles).set_TabIndex(1);
		UI_GB_Profiles.set_TabStop(false);
		((Control)UI_GB_Profiles).set_Text("Profiles");
		((Control)UI_B_IPM_Load).set_Location(new Point(16, 16));
		((Control)UI_B_IPM_Load).set_Name("UI_B_IPM_Load");
		((Control)UI_B_IPM_Load).set_Size(new Size(96, 23));
		((Control)UI_B_IPM_Load).set_TabIndex(3);
		((Control)UI_B_IPM_Load).set_Text("Apply Selected");
		((Control)UI_B_IPM_Load).add_Click((EventHandler)UI_B_IPM_Load_Click);
		((Control)UI_IPM_GetList).set_Location(new Point(16, 64));
		((Control)UI_IPM_GetList).set_Name("UI_IPM_GetList");
		((Control)UI_IPM_GetList).set_Size(new Size(96, 23));
		((Control)UI_IPM_GetList).set_TabIndex(2);
		((Control)UI_IPM_GetList).set_Text("Refresh List");
		((Control)UI_IPM_GetList).add_Click((EventHandler)UI_IPM_GetList_Click);
		((Control)UI_LB_Profiles).set_Anchor((AnchorStyles)13);
		((Control)UI_LB_Profiles).set_Location(new Point(136, 16));
		((Control)UI_LB_Profiles).set_Name("UI_LB_Profiles");
		((Control)UI_LB_Profiles).set_Size(new Size(616, 251));
		((Control)UI_LB_Profiles).set_TabIndex(1);
		((Control)UI_TB_IPM_PID).set_Location(new Point(32, 248));
		((Control)UI_TB_IPM_PID).set_Name("UI_TB_IPM_PID");
		((TextBoxBase)UI_TB_IPM_PID).set_ReadOnly(true);
		((Control)UI_TB_IPM_PID).set_Size(new Size(72, 20));
		((Control)UI_TB_IPM_PID).set_TabIndex(0);
		((Control)UI_TB_IPM_PID).set_Text("No PID");
		((Control)UI_GB_IPM).get_Controls().Add((Control)(object)UI_B_IPM_Connect);
		((Control)UI_GB_IPM).set_Enabled(false);
		((Control)UI_GB_IPM).set_Location(new Point(8, 8));
		((Control)UI_GB_IPM).set_Name("UI_GB_IPM");
		((Control)UI_GB_IPM).set_Size(new Size(128, 48));
		((Control)UI_GB_IPM).set_TabIndex(0);
		UI_GB_IPM.set_TabStop(false);
		((Control)UI_GB_IPM).set_Text("Profile Manager");
		((Control)UI_B_IPM_Connect).set_Location(new Point(16, 16));
		((Control)UI_B_IPM_Connect).set_Name("UI_B_IPM_Connect");
		((Control)UI_B_IPM_Connect).set_Size(new Size(96, 23));
		((Control)UI_B_IPM_Connect).set_TabIndex(0);
		((Control)UI_B_IPM_Connect).set_Text("Connect");
		((Control)UI_B_IPM_Connect).add_Click((EventHandler)UI_B_IPM_Connect_Click);
		((Control)UI_TAB_Main_Domains).get_Controls().Add((Control)(object)UI_GB_AppDomains);
		UI_TAB_Main_Domains.set_Location(new Point(4, 22));
		((Control)UI_TAB_Main_Domains).set_Name("UI_TAB_Main_Domains");
		((Control)UI_TAB_Main_Domains).set_Size(new Size(932, 327));
		UI_TAB_Main_Domains.set_TabIndex(1);
		((Control)UI_TAB_Main_Domains).set_Text("Domains");
		UI_TAB_Main_Domains.set_UseVisualStyleBackColor(true);
		((Control)UI_GB_AppDomains).set_Anchor((AnchorStyles)13);
		((Control)UI_GB_AppDomains).get_Controls().Add((Control)(object)UI_GB_LOGMessageControls);
		((Control)UI_GB_AppDomains).get_Controls().Add((Control)(object)UI_LB_AppDomains);
		((Control)UI_GB_AppDomains).get_Controls().Add((Control)(object)UI_LB_AppDomainItems);
		((Control)UI_GB_AppDomains).set_Enabled(false);
		((Control)UI_GB_AppDomains).set_Location(new Point(8, 8));
		((Control)UI_GB_AppDomains).set_Name("UI_GB_AppDomains");
		((Control)UI_GB_AppDomains).set_Size(new Size(912, 384));
		((Control)UI_GB_AppDomains).set_TabIndex(0);
		UI_GB_AppDomains.set_TabStop(false);
		((Control)UI_GB_AppDomains).set_Text("AppDomains");
		((Control)UI_GB_LOGMessageControls).set_Anchor((AnchorStyles)9);
		((Control)UI_GB_LOGMessageControls).get_Controls().Add((Control)(object)UI_CM_AppDomainLogToLOG);
		((Control)UI_GB_LOGMessageControls).get_Controls().Add((Control)(object)UI_B_GetPublished);
		((Control)UI_GB_LOGMessageControls).get_Controls().Add((Control)(object)UI_B_CopyAppDomains);
		((Control)UI_GB_LOGMessageControls).get_Controls().Add((Control)(object)UI_B_GetAppDomainAssemblies);
		((Control)UI_GB_LOGMessageControls).get_Controls().Add((Control)(object)UI_CM_ExceptionMessages);
		((Control)UI_GB_LOGMessageControls).get_Controls().Add((Control)(object)UI_CM_ErrorMessages);
		((Control)UI_GB_LOGMessageControls).get_Controls().Add((Control)(object)UI_CM_DebugMessages);
		((Control)UI_GB_LOGMessageControls).set_Location(new Point(456, 8));
		((Control)UI_GB_LOGMessageControls).set_Name("UI_GB_LOGMessageControls");
		((Control)UI_GB_LOGMessageControls).set_Size(new Size(448, 120));
		((Control)UI_GB_LOGMessageControls).set_TabIndex(2);
		UI_GB_LOGMessageControls.set_TabStop(false);
		((Control)UI_GB_LOGMessageControls).set_Text("LOG Message Controls");
		((Control)UI_CM_AppDomainLogToLOG).set_Location(new Point(16, 88));
		((Control)UI_CM_AppDomainLogToLOG).set_Name("UI_CM_AppDomainLogToLOG");
		((Control)UI_CM_AppDomainLogToLOG).set_Size(new Size(184, 24));
		((Control)UI_CM_AppDomainLogToLOG).set_TabIndex(7);
		((Control)UI_CM_AppDomainLogToLOG).set_Text("Log messsages to LOG Server");
		UI_CM_AppDomainLogToLOG.add_CheckedChanged((EventHandler)UI_CM_AppDomainLogToLOG_CheckedChanged);
		((Control)UI_B_GetPublished).set_Location(new Point(216, 80));
		((Control)UI_B_GetPublished).set_Name("UI_B_GetPublished");
		((Control)UI_B_GetPublished).set_Size(new Size(104, 23));
		((Control)UI_B_GetPublished).set_TabIndex(6);
		((Control)UI_B_GetPublished).set_Text("Get Published");
		((Control)UI_B_GetPublished).add_Click((EventHandler)UI_B_GetPublished_Click);
		((Control)UI_B_CopyAppDomains).set_Location(new Point(216, 48));
		((Control)UI_B_CopyAppDomains).set_Name("UI_B_CopyAppDomains");
		((Control)UI_B_CopyAppDomains).set_Size(new Size(104, 23));
		((Control)UI_B_CopyAppDomains).set_TabIndex(5);
		((Control)UI_B_CopyAppDomains).set_Text("Copy List View");
		((Control)UI_B_CopyAppDomains).add_Click((EventHandler)UI_B_CopyAppDomains_Click);
		((Control)UI_B_GetAppDomainAssemblies).set_Location(new Point(216, 16));
		((Control)UI_B_GetAppDomainAssemblies).set_Name("UI_B_GetAppDomainAssemblies");
		((Control)UI_B_GetAppDomainAssemblies).set_Size(new Size(104, 23));
		((Control)UI_B_GetAppDomainAssemblies).set_TabIndex(4);
		((Control)UI_B_GetAppDomainAssemblies).set_Text("Get Assemblies");
		((Control)UI_B_GetAppDomainAssemblies).add_Click((EventHandler)UI_B_GetAppDomainAssemblies_Click);
		((Control)UI_CM_ExceptionMessages).set_Location(new Point(16, 64));
		((Control)UI_CM_ExceptionMessages).set_Name("UI_CM_ExceptionMessages");
		((Control)UI_CM_ExceptionMessages).set_Size(new Size(184, 24));
		((Control)UI_CM_ExceptionMessages).set_TabIndex(3);
		((Control)UI_CM_ExceptionMessages).set_Text("Generate Exception Messages");
		UI_CM_ExceptionMessages.add_CheckedChanged((EventHandler)UI_CM_ExceptionMessages_CheckedChanged);
		((Control)UI_CM_ErrorMessages).set_Location(new Point(16, 40));
		((Control)UI_CM_ErrorMessages).set_Name("UI_CM_ErrorMessages");
		((Control)UI_CM_ErrorMessages).set_Size(new Size(184, 24));
		((Control)UI_CM_ErrorMessages).set_TabIndex(2);
		((Control)UI_CM_ErrorMessages).set_Text("Generate Error Messages");
		UI_CM_ErrorMessages.add_CheckedChanged((EventHandler)UI_CM_ErrorMessages_CheckedChanged);
		((Control)UI_CM_DebugMessages).set_Location(new Point(16, 16));
		((Control)UI_CM_DebugMessages).set_Name("UI_CM_DebugMessages");
		((Control)UI_CM_DebugMessages).set_Size(new Size(184, 24));
		((Control)UI_CM_DebugMessages).set_TabIndex(1);
		((Control)UI_CM_DebugMessages).set_Text("Generate Debug Messages");
		UI_CM_DebugMessages.add_CheckedChanged((EventHandler)UI_CM_DebugMessages_CheckedChanged);
		((Control)UI_LB_AppDomains).set_Anchor((AnchorStyles)13);
		((Control)UI_LB_AppDomains).set_Location(new Point(8, 16));
		((Control)UI_LB_AppDomains).set_Name("UI_LB_AppDomains");
		((Control)UI_LB_AppDomains).set_Size(new Size(440, 108));
		((Control)UI_LB_AppDomains).set_TabIndex(0);
		UI_LB_AppDomains.add_SelectedIndexChanged((EventHandler)UI_LB_AppDomains_SelectedIndexChanged);
		((Control)UI_LB_AppDomainItems).set_Anchor((AnchorStyles)13);
		((Control)UI_LB_AppDomainItems).set_Location(new Point(8, 144));
		((Control)UI_LB_AppDomainItems).set_Name("UI_LB_AppDomainItems");
		((Control)UI_LB_AppDomainItems).set_Size(new Size(896, 147));
		((Control)UI_LB_AppDomainItems).set_TabIndex(3);
		((Control)UI_TAB_Main_Logfile).get_Controls().Add((Control)(object)UI_GB_ACE_LogFile);
		((Control)UI_TAB_Main_Logfile).get_Controls().Add((Control)(object)UI_GB_Windows_EventLog);
		UI_TAB_Main_Logfile.set_Location(new Point(4, 22));
		((Control)UI_TAB_Main_Logfile).set_Name("UI_TAB_Main_Logfile");
		((Control)UI_TAB_Main_Logfile).set_Size(new Size(932, 327));
		UI_TAB_Main_Logfile.set_TabIndex(4);
		((Control)UI_TAB_Main_Logfile).set_Text("Logfile");
		UI_TAB_Main_Logfile.set_UseVisualStyleBackColor(true);
		((Control)UI_CM_LOG_Status_AutoScroll).set_Anchor((AnchorStyles)10);
		UI_CM_LOG_Status_AutoScroll.set_Checked(true);
		UI_CM_LOG_Status_AutoScroll.set_CheckState((CheckState)1);
		((Control)UI_CM_LOG_Status_AutoScroll).set_Location(new Point(832, 424));
		((Control)UI_CM_LOG_Status_AutoScroll).set_Name("UI_CM_LOG_Status_AutoScroll");
		((Control)UI_CM_LOG_Status_AutoScroll).set_Size(new Size(80, 16));
		((Control)UI_CM_LOG_Status_AutoScroll).set_TabIndex(20);
		((Control)UI_CM_LOG_Status_AutoScroll).set_Text("Auto-Scroll");
		UI_CM_LOG_Status_AutoScroll.add_CheckedChanged((EventHandler)UI_CM_LOG_Status_AutoScroll_CheckedChanged);
		((Control)UI_LB_LOG_Status).set_Anchor((AnchorStyles)15);
		((Control)UI_LB_LOG_Status).set_Location(new Point(0, 376));
		((Control)UI_LB_LOG_Status).set_Name("UI_LB_LOG_Status");
		((Control)UI_LB_LOG_Status).set_Size(new Size(788, 108));
		((Control)UI_LB_LOG_Status).set_TabIndex(21);
		((Control)UI_B_Clear_LOG_Status).set_Anchor((AnchorStyles)10);
		((Control)UI_B_Clear_LOG_Status).set_Location(new Point(832, 456));
		((Control)UI_B_Clear_LOG_Status).set_Name("UI_B_Clear_LOG_Status");
		((Control)UI_B_Clear_LOG_Status).set_Size(new Size(80, 20));
		((Control)UI_B_Clear_LOG_Status).set_TabIndex(22);
		((Control)UI_B_Clear_LOG_Status).set_Text("Clear");
		((Control)UI_B_Clear_LOG_Status).add_Click((EventHandler)UI_B_Clear_LOG_Status_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(96f, 96f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)2);
		((Control)this).set_BackColor(SystemColors.Control);
		((Form)this).set_ClientSize(new Size(944, 510));
		((Control)this).get_Controls().Add((Control)(object)UI_TAB_MainTab);
		((Control)this).get_Controls().Add((Control)(object)UI_LB_LOG_Status);
		((Control)this).get_Controls().Add((Control)(object)UI_CM_LOG_Status_AutoScroll);
		((Control)this).get_Controls().Add((Control)(object)UI_B_Clear_LOG_Status);
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("LogManager");
		((Form)this).set_StartPosition((FormStartPosition)0);
		((Control)this).set_Text("ACE LOG");
		((Form)this).add_Closing((CancelEventHandler)UI_ACE_Closing);
		((Form)this).add_Load((EventHandler)LogManager_Load);
		((Control)UI_GB_Windows_EventLog).ResumeLayout(false);
		((Control)UI_GB_ACE_LogFile).ResumeLayout(false);
		((Control)UI_GB_ACE_LogFile).PerformLayout();
		((Control)UI_TAB_MainTab).ResumeLayout(false);
		((Control)UI_TAB_Main_Components).ResumeLayout(false);
		((Control)UI_GB_CCC).ResumeLayout(false);
		((Control)UI_GB_CCC).PerformLayout();
		((Control)UI_GB_CLI).ResumeLayout(false);
		((Control)UI_GB_CLI).PerformLayout();
		((Control)UI_TAB_Main_Messages).ResumeLayout(false);
		((Control)UI_GB_ACE_LogMessages).ResumeLayout(false);
		((Control)UI_GB_MessageDetails).ResumeLayout(false);
		((Control)UI_GB_MessageDetails).PerformLayout();
		((Control)UI_GB_MessageControl).ResumeLayout(false);
		((Control)UI_GB_Filters).ResumeLayout(false);
		((Control)UI_GB_Filters).PerformLayout();
		((Control)UI_TAB_Main_Runtime).ResumeLayout(false);
		((Control)UI_GB_Skin).ResumeLayout(false);
		((Control)UI_GB_Skin).PerformLayout();
		((Control)UI_GB_Language).ResumeLayout(false);
		((Control)UI_GB_Language).PerformLayout();
		((Control)UI_GB_Runtime).ResumeLayout(false);
		((Control)UI_GB_CasteInfo).ResumeLayout(false);
		((Control)UI_GB_CasteInfo).PerformLayout();
		((Control)UI_GB_AdapterInfo).ResumeLayout(false);
		((Control)UI_GB_AdapterInfo).PerformLayout();
		((Control)UI_GB_FeatureInfo).ResumeLayout(false);
		((Control)UI_GB_FeatureInfo).PerformLayout();
		((Control)UI_GB_AspectInfo).ResumeLayout(false);
		((Control)UI_GB_AspectInfo).PerformLayout();
		((Control)UI_GB_PropertyInfo).ResumeLayout(false);
		((Control)UI_GB_PropertyInfo).PerformLayout();
		((Control)UI_GB_IComponent).ResumeLayout(false);
		((Control)UI_GB_IComponent).PerformLayout();
		((Control)UI_TAB_Profiles).ResumeLayout(false);
		((Control)UI_GB_Profiles).ResumeLayout(false);
		((Control)UI_GB_Profiles).PerformLayout();
		((Control)UI_GB_IPM).ResumeLayout(false);
		((Control)UI_TAB_Main_Domains).ResumeLayout(false);
		((Control)UI_GB_AppDomains).ResumeLayout(false);
		((Control)UI_GB_LOGMessageControls).ResumeLayout(false);
		((Control)UI_TAB_Main_Logfile).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}
}
