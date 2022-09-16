using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Security.Permissions;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using SandboxDotNet.ErrorHandler;
using SandboxDotNet.Helpers;
using SandboxDotNet.Perms;
using SandboxDotNet.Perms.Profiles;
using SandboxDotNet.UserInterface.Elements;

namespace SandboxDotNet.UserInterface;

public class SandboxDotNet : Form
{
	public enum UiState
	{
		Invalid,
		Valid
	}

	public enum SandboxRunningState
	{
		Stopped,
		Running
	}

	private readonly Sandbox _sandbox;

	private readonly DevConsole _devForm;

	private readonly HelpForm _aboutForm;

	private readonly bool _profileAutoLoad;

	private UiState _uiState = UiState.Invalid;

	private Permissions _sandboxPermissions;

	private Thread _sandboxThread;

	private SandboxRunningState _sandboxState = SandboxRunningState.Stopped;

	private IContainer components = null;

	private MenuStrip menuStrip;

	private ToolStripMenuItem fileToolStripMenuItem;

	private Button runSandbox;

	private OpenFileDialog openFileDialog;

	private Panel titlePanel;

	private Label title;

	private ToolStripMenuItem openToolStripMenuItem;

	private ToolStripSeparator toolStripMenuItem1;

	private ToolStripMenuItem exitToolStripMenuItem;

	private ToolTip toolTip;

	private ToolStripMenuItem editToolStripMenuItem;

	private ToolStripMenuItem permissionsToolStripMenuItem;

	private ToolStripMenuItem programOptionsToolStripMenuItem;

	private ToolStripMenuItem aboutToolStripMenuItem;

	private ToolStripMenuItem aboutSandboxToolStripMenuItem;

	private ToolStripMenuItem helpToolStripMenuItem;

	private ToolStripSeparator toolStripMenuItem2;

	private ToolStripMenuItem developerToolStripMenuItem;

	private ToolStripMenuItem devConsoleToolStripMenuItem;

	private Timer sandboxRunning;

	private ToolStripSeparator toolStripMenuItem3;

	private ToolStripMenuItem fileIOToolStripMenuItem;

	private ToolStripMenuItem clearFileListToolStripMenuItem;

	private TabPage permGlobalTabPage;

	private TabControl permissionsTabControl;

	private TabPage locMachinePermsTab;

	private TableLayoutPanel localPermsTable;

	private CheckBox ioPerm;

	private CheckBox uiPerm;

	private CheckBox printPerm;

	private CheckBox fileDialogPerm;

	private CheckBox princePerm;

	private CheckBox eventLogPerm;

	private CheckBox perfPerm;

	private CheckBox regPerm;

	private TabPage fileIoPermsTab;

	private TableLayoutPanel fileIoTableLayoutPanel;

	private TableLayoutPanel fileIoFolderButtonTableLayoutPanel;

	private Button addFolderAppendButton;

	private Button addFolderWriteButton;

	private Button addFolderReadButton;

	private Panel fileIoPermsTabPanel;

	private TableLayoutPanel listOfAllFilesTable;

	private TableLayoutPanel fileIoFileButtonTableLayoutPanel;

	private Button addFilesAppendButton;

	private Button addFilesWriteButton;

	private Button addFilesReadButton;

	private TableLayoutPanel tableLayoutPanel2;

	private CheckBox allFilesPerm;

	private Button clearFileIOListButton;

	private TabPage securityPermsTab;

	private TableLayoutPanel secPermsTable;

	private CheckBox executionPerm;

	private CheckBox assertPerm;

	private CheckBox bindRedirectPerm;

	private CheckBox controlAppDomainPerm;

	private CheckBox controlDomainPolicyPerm;

	private CheckBox controlEvidencePerm;

	private CheckBox controlPolicy;

	private CheckBox controlPrincipalPerm;

	private CheckBox controlThreadPerm;

	private CheckBox infrastructurePerm;

	private CheckBox remotingConfigurationPerm;

	private CheckBox serializationFormatterPerm;

	private CheckBox skipVerificationPerm;

	private CheckBox unmanagedCode;

	private TabPage refPermsTab;

	private TableLayoutPanel refPermsTable;

	private CheckBox gacPerm;

	private CheckBox reflectPerm;

	private CheckBox publishPerm;

	private CheckBox typePerm;

	private CheckBox strongNamePerm;

	private CheckBox isolatedPerm;

	private TabPage netPermsTab;

	private TableLayoutPanel netPermsTable;

	private CheckBox aspPerm;

	private CheckBox dnsPerm;

	private CheckBox urlPerm;

	private CheckBox netInfoPerm;

	private CheckBox smtpPerm;

	private CheckBox socketPerm;

	private CheckBox sitePerm;

	private CheckBox sqlPerm;

	private CheckBox webPerm;

	private CheckBox zonePerm;

	private TabPage otherPermsTab;

	private TableLayoutPanel otherPermsTable;

	private CheckBox keyPerm;

	private CheckBox storePerm;

	private CheckBox olePerm;

	private CheckBox odbcPerm;

	private TabPage programTab;

	private TableLayoutPanel progPanel;

	private Button clearArgsButton;

	private Label argsLabel;

	private TextBox argsTextBox;

	private Button selectFileButton;

	private TextBox pathTextBox;

	private Label pathLabel;

	private TableLayoutPanel consoleControlPanel;

	private TabControl sandboxTabControl;

	private ToolStripMenuItem localToolStripMenuItem;

	private ToolStripMenuItem securityToolStripMenuItem;

	private ToolStripMenuItem reflectionToolStripMenuItem;

	private ToolStripMenuItem networkToolStripMenuItem;

	private ToolStripMenuItem otherToolStripMenuItem;

	private ToolStripMenuItem checkAllLocalToolStripMenuItem;

	private ToolStripMenuItem uncheckAllLocalToolStripMenuItem;

	private ToolStripMenuItem checkAllSecToolStripMenuItem;

	private ToolStripMenuItem uncheckAllSecToolStripMenuItem;

	private ToolStripMenuItem checkAllRefToolStripMenuItem;

	private ToolStripMenuItem uncheckAllRefToolStripMenuItem;

	private ToolStripMenuItem checkAllNetToolStripMenuItem;

	private ToolStripMenuItem uncheckAllNetToolStripMenuItem;

	private ToolStripMenuItem checkAllOtherToolStripMenuItem;

	private ToolStripMenuItem uncheckAllOtherToolStripMenuItem;

	private ToolStripSeparator toolStripMenuItem4;

	private ToolStripMenuItem checkAllPermissionsToolStripMenuItem;

	private ToolStripMenuItem uncheckAllPermissionsToolStripMenuItem;

	private ToolStripMenuItem importPermissionsToolStripMenuItem;

	private ToolStripMenuItem exportPermissionsToolStripMenuItem;

	private ToolStripSeparator toolStripMenuItem6;

	private ToolStripMenuItem profilesToolStripMenuItem;

	private ToolStripMenuItem saveToAProfileToolStripMenuItem;

	private ToolStripSeparator toolStripMenuItem5;

	private ToolStripMenuItem checkAllFileToolStripMenuItem;

	private ToolStripMenuItem uncheckAllFileToolStripMenuItem;

	public Logging Logging { get; set; }

	private UiState UIState
	{
		get
		{
			return _uiState;
		}
		set
		{
			_uiState = value;
			switch (value)
			{
			case UiState.Valid:
				_sandbox.ProgramPath = ((Control)pathTextBox).get_Text();
				_sandbox.ProgramParameters = SandboxUtils.ConvertStringArgsWithQuotes(((Control)argsTextBox).get_Text());
				((Control)runSandbox).set_Enabled(true);
				((Control)title).set_Cursor(Cursors.get_Hand());
				((Control)title).set_Text(Path.GetFileName(_sandbox.ProgramPath));
				toolTip.SetToolTip((Control)(object)title, _sandbox.ProgramPath);
				break;
			case UiState.Invalid:
				_sandbox.ProgramPath = "";
				_sandbox.ProgramParameters = null;
				((Control)runSandbox).set_Enabled(false);
				((Control)title).set_Text("(No Program Selected)");
				((Control)title).set_Cursor(Cursors.get_Default());
				toolTip.SetToolTip((Control)(object)title, "No program pathTextBox provided");
				break;
			}
		}
	}

	public bool LockDefaultPermissions
	{
		get
		{
			return !((Control)executionPerm).get_Enabled();
		}
		set
		{
			CheckBox obj = executionPerm;
			CheckBox obj2 = uiPerm;
			bool flag;
			((Control)ioPerm).set_Enabled(flag = !value);
			bool enabled;
			((Control)obj2).set_Enabled(enabled = flag);
			((Control)obj).set_Enabled(enabled);
			Logging.Log($"Default Permissions Locked: {value}", Logging.Severity.DEBUG);
		}
	}

	public bool LockUserInterface
	{
		get
		{
			return !((Control)sandboxTabControl).get_Enabled();
		}
		set
		{
			((Control)sandboxTabControl).set_Enabled(!value);
			Logging.Log($"User Interface Locked: {value}", Logging.Severity.DEBUG);
		}
	}

	public SandboxDotNet(Logging logging, bool profileAutoLoad)
	{
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		_profileAutoLoad = profileAutoLoad;
		Logging = logging;
		if (DFHGUYV.IsDevModeEnabled())
		{
			_devForm = new DevConsole(this, Logging);
			((Control)_devForm).Show();
			((Control)_devForm).Hide();
			Logging.DeveloperConsole = _devForm;
		}
		Logging.Log("Running in UI mode!", Logging.Severity.DEBUG);
		_sandbox = new Sandbox
		{
			Logger = Logging
		};
		_aboutForm = new HelpForm();
		InitializeComponent();
		((Control)this).set_Text($"SandboxDotNet {DFHGUYV.GetVersion()}");
		((ToolStripItem)developerToolStripMenuItem).set_Visible(DFHGUYV.IsDevModeEnabled());
		if (!_profileAutoLoad)
		{
			((ToolStripItem)profilesToolStripMenuItem).set_Enabled(false);
			LoadAllProfiles();
		}
		int verticalScrollBarWidth = SystemInformation.get_VerticalScrollBarWidth();
		((Control)localPermsTable).set_Padding(new Padding(verticalScrollBarWidth, 0, verticalScrollBarWidth, 0));
		((Control)listOfAllFilesTable).set_Padding(new Padding(verticalScrollBarWidth, 0, verticalScrollBarWidth, 0));
		((Control)securityPermsTab).set_Padding(new Padding(verticalScrollBarWidth, 0, verticalScrollBarWidth, 0));
		((Control)refPermsTab).set_Padding(new Padding(verticalScrollBarWidth, 0, verticalScrollBarWidth, 0));
		((Control)netPermsTab).set_Padding(new Padding(verticalScrollBarWidth, 0, verticalScrollBarWidth, 0));
		((Control)otherPermsTab).set_Padding(new Padding(verticalScrollBarWidth, 0, verticalScrollBarWidth, 0));
	}

	public SandboxDotNet(string targetProgram, string[] targetProgramParams, Permissions sandboxPermissions, Logging logging, bool profileAutoLoad)
		: this(logging, profileAutoLoad)
	{
		((Control)pathTextBox).set_Text(targetProgram);
		foreach (string text in targetProgramParams)
		{
			if (text.Contains(" "))
			{
				((TextBoxBase)argsTextBox).AppendText($"\"{text}\" ");
			}
			else
			{
				((TextBoxBase)argsTextBox).AppendText(text + " ");
			}
		}
		((Control)argsTextBox).set_Text(((Control)argsTextBox).get_Text().TrimEnd(new char[1] { ' ' }));
		_sandboxPermissions = sandboxPermissions;
		LockDefaultPermissions = _sandboxPermissions.DefaultPermissions;
		InitPermissionTabs();
		if (!string.IsNullOrWhiteSpace(((Control)pathTextBox).get_Text()))
		{
			UIState = UiState.Valid;
		}
	}

	public void RunSandbox()
	{
		Log($"Sandbox valid: {ValidateSandbox()}", Logging.Severity.INFO);
		if (_uiState == UiState.Valid && _sandboxState == SandboxRunningState.Stopped)
		{
			if (_sandboxPermissions.DefaultPermissions)
			{
				if (!ioPerm.get_Checked() || !executionPerm.get_Checked() || !uiPerm.get_Checked())
				{
					_sandboxPermissions.DefaultPermissions = false;
				}
			}
			else if (LockDefaultPermissions)
			{
				_sandboxPermissions.DefaultPermissions = true;
			}
			UpdateSandboxPermissions();
			Log($"Enabled permissions: {_sandboxPermissions}", Logging.Severity.DEBUG);
			SecurityException ex2;
			Exception ex;
			_sandboxThread = new Thread((ThreadStart)delegate
			{
				//IL_006a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0074: Expected O, but got Unknown
				//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d4: Expected O, but got Unknown
				try
				{
					int num = _sandbox.ExecuteUntrustedExecutable();
					Log($"Program exited with exit code {num}", Logging.Severity.INFO);
				}
				catch (SecurityException ex3)
				{
					ex2 = ex3;
					_sandboxState = SandboxRunningState.Stopped;
					new PermissionSet(PermissionState.Unrestricted).Assert();
					Log(ex2.ToString(), Logging.Severity.ERROR);
					((Control)this).BeginInvoke((Delegate)(MethodInvoker)delegate
					{
						ShowError(ex2, "Sandbox Error");
					});
					CodeAccessPermission.RevertAssert();
				}
				catch (ThreadAbortException)
				{
					_sandboxState = SandboxRunningState.Stopped;
					Log("Thread was aborted!", Logging.Severity.WARN);
				}
				catch (Exception ex5)
				{
					ex = ex5;
					_sandboxState = SandboxRunningState.Stopped;
					Log(ex.ToString(), Logging.Severity.ERROR);
					((Control)this).BeginInvoke((Delegate)(MethodInvoker)delegate
					{
						ShowError(ex, "Unexpected Error");
					});
				}
			});
			_sandboxThread.Start();
			sandboxRunning.Start();
			Log($"Sandbox started!", Logging.Severity.INFO);
		}
		else if (_sandboxState == SandboxRunningState.Running)
		{
			AbortSandbox();
		}
		else
		{
			Log($"Sandbox state invalid!", Logging.Severity.WARN);
		}
	}

	public void AbortSandbox()
	{
		if (_sandboxThread != null && _sandboxThread.ThreadState == ThreadState.Running)
		{
			_sandboxThread.Abort();
			Log($"Sandbox aborted!", Logging.Severity.WARN);
		}
	}

	private void ShowError(Exception exception, string errorType)
	{
		SandboxUI_Errors sandboxUI_Errors = new SandboxUI_Errors(exception, errorType, DFHGUYV.IsDevModeEnabled());
		Point location = new Point(((Control)this).get_Left() + ((Control)this).get_Width() / 2 - ((Control)sandboxUI_Errors).get_Width() / 2, ((Control)this).get_Top() + ((Control)this).get_Height() / 2 - ((Control)sandboxUI_Errors).get_Height() / 2);
		((Form)sandboxUI_Errors).set_Location(location);
		((Control)sandboxUI_Errors).Show();
	}

	private bool ValidateSandbox()
	{
		if (SandboxUtils.IsFileValidExe(((Control)pathTextBox).get_Text()))
		{
			UIState = UiState.Valid;
		}
		else
		{
			UIState = UiState.Invalid;
		}
		if (UIState == UiState.Valid)
		{
			return true;
		}
		return false;
	}

	public void ClearFileList()
	{
		((ControlCollection)listOfAllFilesTable.get_Controls()).Clear();
		((TableLayoutStyleCollection)listOfAllFilesTable.get_RowStyles()).Clear();
		listOfAllFilesTable.set_RowCount(0);
	}

	private void ImportPermissions(string defaultFilePath)
	{
		Thread thread = new Thread((ThreadStart)delegate
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Expected O, but got Unknown
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Invalid comparison between Unknown and I4
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Expected O, but got Unknown
			OpenFileDialog openFileDialog = new OpenFileDialog();
			((FileDialog)openFileDialog).set_Title("Import a Permissions Profile");
			((FileDialog)openFileDialog).set_Filter("Permissions Profile (*.perms)|*.perms");
			if (!string.IsNullOrWhiteSpace(defaultFilePath) && Directory.Exists(defaultFilePath))
			{
				((FileDialog)openFileDialog).set_InitialDirectory(Path.GetFullPath(defaultFilePath));
			}
			DialogResult val = ((CommonDialog)openFileDialog).ShowDialog();
			if ((int)val == 1)
			{
				((Control)this).BeginInvoke((Delegate)(MethodInvoker)delegate
				{
					LoadPermissionsFromPath(((FileDialog)openFileDialog).get_FileName());
				});
			}
		});
		thread.SetApartmentState(ApartmentState.STA);
		thread.Start();
	}

	private void ExportPermissions(string defaultFilePath)
	{
		Thread thread = new Thread((ThreadStart)delegate
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Invalid comparison between Unknown and I4
			SaveFileDialog val = new SaveFileDialog();
			((FileDialog)val).set_Title("Export a Permissions Profile");
			((FileDialog)val).set_Filter("Permissions Profile (*.perms)|*.perms");
			if (!string.IsNullOrWhiteSpace(defaultFilePath) && Directory.Exists(defaultFilePath))
			{
				((FileDialog)val).set_InitialDirectory(Path.GetFullPath(defaultFilePath));
			}
			DialogResult val2 = ((CommonDialog)val).ShowDialog();
			if ((int)val2 == 1)
			{
				try
				{
					UpdateSandboxPermissions(ignoreCurrentExePath: true);
					new PermissionsXML(((FileDialog)val).get_FileName()).ExportPermissions(GetPermissions());
				}
				catch (Exception innerException)
				{
					Exception exception = new Exception($"Failed to save permissions to '{((FileDialog)val).get_FileName()}'. Do you have permission to write to this location?", innerException);
					ShowError(exception, "Failed to save permissions");
				}
				LoadAllProfiles();
			}
		});
		thread.SetApartmentState(ApartmentState.STA);
		thread.Start();
	}

	private bool LoadPermissionsFromPath(string path)
	{
		if (File.Exists(path))
		{
			try
			{
				UpdatePermissions(new PermissionsXML(path).ImportPermissions());
			}
			catch (Exception innerException)
			{
				Exception exception = new Exception($"Failed to load permissions from '{path}'. Are you sure this is a valid permissions profile?", innerException);
				ShowError(exception, "Failed to load permissions");
			}
			return true;
		}
		return false;
	}

	private void LoadAllProfiles()
	{
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		if (!_profileAutoLoad)
		{
			return;
		}
		string path = Path.Combine(Environment.CurrentDirectory, "Profiles");
		if (!Directory.Exists(path))
		{
			return;
		}
		if (((ArrangedElementCollection)((ToolStripDropDownItem)profilesToolStripMenuItem).get_DropDownItems()).get_Count() > 2)
		{
			for (int i = ((ArrangedElementCollection)((ToolStripDropDownItem)profilesToolStripMenuItem).get_DropDownItems()).get_Count() - 1; i > 2; i++)
			{
				((ToolStripDropDownItem)profilesToolStripMenuItem).get_DropDownItems().RemoveAt(i);
			}
		}
		string[] files = Directory.GetFiles(path);
		foreach (string text in files)
		{
			bool flag = false;
			for (int k = 2; k < ((ArrangedElementCollection)((ToolStripDropDownItem)profilesToolStripMenuItem).get_DropDownItems()).get_Count(); k++)
			{
				if ((string)((ToolStripDropDownItem)profilesToolStripMenuItem).get_DropDownItems().get_Item(k).get_Tag() == text)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				AddProfile(text);
			}
		}
		if (((ArrangedElementCollection)((ToolStripDropDownItem)profilesToolStripMenuItem).get_DropDownItems()).get_Count() == 2)
		{
			ToolStripMenuItem val = new ToolStripMenuItem();
			((ToolStripItem)val).set_Text("No profiles");
			((ToolStripItem)val).set_Tag((object)"NullProfile");
			((ToolStripItem)val).set_Enabled(false);
			((ToolStripDropDownItem)profilesToolStripMenuItem).get_DropDownItems().Add((ToolStripItem)(object)val);
		}
	}

	private void AddProfile(string profilePath)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		if (_profileAutoLoad)
		{
			if (((ArrangedElementCollection)((ToolStripDropDownItem)profilesToolStripMenuItem).get_DropDownItems()).get_Count() == 3 && (string)((ToolStripDropDownItem)profilesToolStripMenuItem).get_DropDownItems().get_Item(2).get_Tag() == "NullProfile")
			{
				((ToolStripDropDownItem)profilesToolStripMenuItem).get_DropDownItems().RemoveAt(2);
			}
			ToolStripMenuItem val = new ToolStripMenuItem();
			((ToolStripItem)val).set_Text("Load " + Path.GetFileNameWithoutExtension(profilePath));
			((ToolStripItem)val).set_Tag((object)profilePath);
			((ToolStripItem)val).add_Click((EventHandler)profileLoadEvent_Click);
			((ToolStripDropDownItem)profilesToolStripMenuItem).get_DropDownItems().Add((ToolStripItem)(object)val);
		}
	}

	private void Log(string message, Logging.Severity severity)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		try
		{
			((Control)this).BeginInvoke((Delegate)(MethodInvoker)delegate
			{
				Logging.Log(message, severity);
			});
		}
		catch (InvalidOperationException)
		{
		}
	}

	private void profileLoadEvent_Click(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		ToolStripMenuItem val = (ToolStripMenuItem)sender;
		if (!LoadPermissionsFromPath((string)((ToolStripItem)val).get_Tag()))
		{
			FileNotFoundException exception = new FileNotFoundException(string.Format("Could not find profile '{0}'. Are you sure this profile has not been removed?", ((ToolStripItem)val).get_Text().Replace("Load ", "")), (string)((ToolStripItem)val).get_Tag());
			ShowError(exception, "Profile Error");
			((ToolStripDropDownItem)profilesToolStripMenuItem).get_DropDownItems().Remove((ToolStripItem)(object)val);
			LoadAllProfiles();
		}
	}

	private void selectFileButton_Click(object sender, EventArgs e)
	{
		Thread thread = new Thread((ThreadStart)delegate
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Invalid comparison between Unknown and I4
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected O, but got Unknown
			((FileDialog)openFileDialog).set_FileName(((Control)pathTextBox).get_Text());
			DialogResult val = ((CommonDialog)openFileDialog).ShowDialog();
			if ((int)val == 1)
			{
				string fPath = ((FileDialog)openFileDialog).get_FileName();
				((Control)this).BeginInvoke((Delegate)(MethodInvoker)delegate
				{
					_sandbox.ProgramPath = fPath;
					((Control)pathTextBox).set_Text(fPath);
				});
			}
		});
		thread.SetApartmentState(ApartmentState.STA);
		thread.Start();
	}

	private void clearArgsButton_Click(object sender, EventArgs e)
	{
		((Control)argsTextBox).ResetText();
	}

	private void runSandbox_Click(object sender, EventArgs e)
	{
		RunSandbox();
	}

	private void sandboxRunning_Tick(object sender, EventArgs e)
	{
		if (_sandboxThread.ThreadState == ThreadState.Running && _sandboxState != SandboxRunningState.Running)
		{
			Log($"Sandbox Thread state: {_sandboxThread.ThreadState}", Logging.Severity.DEBUG);
			LockUserInterface = true;
			_sandboxState = SandboxRunningState.Running;
			if (((Control)runSandbox).get_Text() != "Abort")
			{
				((Control)runSandbox).set_Text("Abort");
			}
		}
		else if (_sandboxThread.ThreadState == ThreadState.Aborted || _sandboxThread.ThreadState == ThreadState.Stopped || (_sandboxThread.ThreadState == ThreadState.Suspended && _sandboxState != 0))
		{
			Log($"Sandbox Thread state: {_sandboxThread.ThreadState}", Logging.Severity.DEBUG);
			LockUserInterface = false;
			_sandboxState = SandboxRunningState.Stopped;
			if (((Control)runSandbox).get_Text() != "Run")
			{
				((Control)runSandbox).set_Text("Run");
			}
			sandboxRunning.Stop();
		}
	}

	private void path_TextChanged(object sender, EventArgs e)
	{
		ValidateSandbox();
	}

	private void title_Click(object sender, EventArgs e)
	{
		if (UIState == UiState.Valid)
		{
			SandboxUtils.OpenFileInExplorer(Path.GetDirectoryName(Path.GetFullPath(((Control)pathTextBox).get_Text())));
		}
	}

	private void exitToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void programOptionsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		sandboxTabControl.SelectTab(sandboxTabControl.get_TabPages().get_Item(0));
	}

	private void permissionsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		sandboxTabControl.SelectTab(sandboxTabControl.get_TabPages().get_Item(1));
	}

	private void clearFileListToolStripMenuItem_Click(object sender, EventArgs e)
	{
		ClearFileList();
	}

	private void aboutSandboxToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (!((Control)_aboutForm).get_Visible())
		{
			Point location = new Point(((Control)this).get_Left() + ((Control)this).get_Width() / 2 - ((Control)_aboutForm).get_Width() / 2, ((Control)this).get_Top() + ((Control)this).get_Height() / 2 - ((Control)_aboutForm).get_Height() / 2);
			((Form)_aboutForm).set_Location(location);
			((Control)_aboutForm).Show();
		}
		else
		{
			((Control)_aboutForm).BringToFront();
		}
	}

	private void devConsoleToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (!((Control)_devForm).get_Visible())
		{
			Point location = new Point(((Control)this).get_Left() + ((Control)this).get_Width() / 2 - ((Control)_devForm).get_Width() / 2, ((Control)this).get_Top() + ((Control)this).get_Height() / 2 - ((Control)_devForm).get_Height() / 2);
			((Form)_devForm).set_Location(location);
			_devForm.ConsoleVisibility(visible: true);
		}
		else
		{
			((Control)_devForm).BringToFront();
		}
	}

	private void clearFileIOListButton_Click(object sender, EventArgs e)
	{
		ClearFileList();
	}

	private void addFilesWriteButton_Click(object sender, EventArgs e)
	{
		AddFilesToList(read: true, write: true, append: false, "Add files with read and write permissions");
	}

	private void addFilesReadButton_Click(object sender, EventArgs e)
	{
		AddFilesToList(read: true, write: false, append: false, "Add files with read permissions");
	}

	private void addFilesAppendButton_Click(object sender, EventArgs e)
	{
		AddFilesToList(read: false, write: false, append: true, "Add files with read, write, and append permissions");
	}

	private void addFolderWriteButton_Click(object sender, EventArgs e)
	{
		AddFoldersToList(read: true, write: true, append: false, "Add folder with read and write permissions");
	}

	private void addFolderReadButton_Click(object sender, EventArgs e)
	{
		AddFoldersToList(read: true, write: false, append: false, "Add folder with read permissions");
	}

	private void addFolderAppendButton_Click(object sender, EventArgs e)
	{
		AddFoldersToList(read: false, write: false, append: true, "Add folder with read, write, and append permissions");
	}

	private void checkAllLocalToolStripMenuItem_Click(object sender, EventArgs e)
	{
		CheckBox obj = regPerm;
		CheckBox obj2 = printPerm;
		CheckBox obj3 = eventLogPerm;
		CheckBox obj4 = fileDialogPerm;
		CheckBox obj5 = princePerm;
		perfPerm.set_Checked(true);
		obj5.set_Checked(true);
		obj4.set_Checked(true);
		obj3.set_Checked(true);
		obj2.set_Checked(true);
		obj.set_Checked(true);
		if (!LockDefaultPermissions)
		{
			CheckBox obj6 = uiPerm;
			ioPerm.set_Checked(true);
			obj6.set_Checked(true);
		}
	}

	private void uncheckAllLocalToolStripMenuItem_Click(object sender, EventArgs e)
	{
		CheckBox obj = regPerm;
		CheckBox obj2 = printPerm;
		CheckBox obj3 = eventLogPerm;
		CheckBox obj4 = fileDialogPerm;
		CheckBox obj5 = princePerm;
		perfPerm.set_Checked(false);
		obj5.set_Checked(false);
		obj4.set_Checked(false);
		obj3.set_Checked(false);
		obj2.set_Checked(false);
		obj.set_Checked(false);
		if (!LockDefaultPermissions)
		{
			CheckBox obj6 = uiPerm;
			ioPerm.set_Checked(false);
			obj6.set_Checked(false);
		}
	}

	private void checkAllFileToolStripMenuItem_Click(object sender, EventArgs e)
	{
		allFilesPerm.set_Checked(true);
	}

	private void uncheckAllFileToolStripMenuItem_Click(object sender, EventArgs e)
	{
		allFilesPerm.set_Checked(false);
	}

	private void checkAllSecToolStripMenuItem_Click(object sender, EventArgs e)
	{
		CheckBox obj = assertPerm;
		CheckBox obj2 = bindRedirectPerm;
		CheckBox obj3 = controlAppDomainPerm;
		CheckBox obj4 = controlEvidencePerm;
		CheckBox obj5 = controlDomainPolicyPerm;
		CheckBox obj6 = controlPolicy;
		CheckBox obj7 = controlPrincipalPerm;
		CheckBox obj8 = controlThreadPerm;
		CheckBox obj9 = infrastructurePerm;
		CheckBox obj10 = remotingConfigurationPerm;
		CheckBox obj11 = serializationFormatterPerm;
		CheckBox obj12 = skipVerificationPerm;
		unmanagedCode.set_Checked(true);
		obj12.set_Checked(true);
		obj11.set_Checked(true);
		obj10.set_Checked(true);
		obj9.set_Checked(true);
		obj8.set_Checked(true);
		obj7.set_Checked(true);
		obj6.set_Checked(true);
		obj5.set_Checked(true);
		obj4.set_Checked(true);
		obj3.set_Checked(true);
		obj2.set_Checked(true);
		obj.set_Checked(true);
		if (!LockDefaultPermissions)
		{
			executionPerm.set_Checked(true);
		}
	}

	private void uncheckAllSecToolStripMenuItem_Click(object sender, EventArgs e)
	{
		CheckBox obj = assertPerm;
		CheckBox obj2 = bindRedirectPerm;
		CheckBox obj3 = controlAppDomainPerm;
		CheckBox obj4 = controlEvidencePerm;
		CheckBox obj5 = controlDomainPolicyPerm;
		CheckBox obj6 = controlPolicy;
		CheckBox obj7 = controlPrincipalPerm;
		CheckBox obj8 = controlThreadPerm;
		CheckBox obj9 = infrastructurePerm;
		CheckBox obj10 = remotingConfigurationPerm;
		CheckBox obj11 = serializationFormatterPerm;
		CheckBox obj12 = skipVerificationPerm;
		unmanagedCode.set_Checked(false);
		obj12.set_Checked(false);
		obj11.set_Checked(false);
		obj10.set_Checked(false);
		obj9.set_Checked(false);
		obj8.set_Checked(false);
		obj7.set_Checked(false);
		obj6.set_Checked(false);
		obj5.set_Checked(false);
		obj4.set_Checked(false);
		obj3.set_Checked(false);
		obj2.set_Checked(false);
		obj.set_Checked(false);
		if (!LockDefaultPermissions)
		{
			executionPerm.set_Checked(false);
		}
	}

	private void checkAllRefToolStripMenuItem_Click(object sender, EventArgs e)
	{
		CheckBox obj = gacPerm;
		CheckBox obj2 = reflectPerm;
		CheckBox obj3 = publishPerm;
		CheckBox obj4 = typePerm;
		CheckBox obj5 = strongNamePerm;
		isolatedPerm.set_Checked(true);
		obj5.set_Checked(true);
		obj4.set_Checked(true);
		obj3.set_Checked(true);
		obj2.set_Checked(true);
		obj.set_Checked(true);
	}

	private void uncheckAllRefToolStripMenuItem_Click(object sender, EventArgs e)
	{
		CheckBox obj = gacPerm;
		CheckBox obj2 = reflectPerm;
		CheckBox obj3 = publishPerm;
		CheckBox obj4 = typePerm;
		CheckBox obj5 = strongNamePerm;
		isolatedPerm.set_Checked(false);
		obj5.set_Checked(false);
		obj4.set_Checked(false);
		obj3.set_Checked(false);
		obj2.set_Checked(false);
		obj.set_Checked(false);
	}

	private void checkAllNetToolStripMenuItem_Click(object sender, EventArgs e)
	{
		CheckBox obj = aspPerm;
		CheckBox obj2 = dnsPerm;
		CheckBox obj3 = sitePerm;
		CheckBox obj4 = zonePerm;
		CheckBox obj5 = urlPerm;
		CheckBox obj6 = netInfoPerm;
		CheckBox obj7 = webPerm;
		CheckBox obj8 = smtpPerm;
		CheckBox obj9 = socketPerm;
		sqlPerm.set_Checked(true);
		obj9.set_Checked(true);
		obj8.set_Checked(true);
		obj7.set_Checked(true);
		obj6.set_Checked(true);
		obj5.set_Checked(true);
		obj4.set_Checked(true);
		obj3.set_Checked(true);
		obj2.set_Checked(true);
		obj.set_Checked(true);
	}

	private void uncheckAllNetToolStripMenuItem_Click(object sender, EventArgs e)
	{
		CheckBox obj = aspPerm;
		CheckBox obj2 = dnsPerm;
		CheckBox obj3 = sitePerm;
		CheckBox obj4 = zonePerm;
		CheckBox obj5 = urlPerm;
		CheckBox obj6 = netInfoPerm;
		CheckBox obj7 = webPerm;
		CheckBox obj8 = smtpPerm;
		CheckBox obj9 = socketPerm;
		sqlPerm.set_Checked(false);
		obj9.set_Checked(false);
		obj8.set_Checked(false);
		obj7.set_Checked(false);
		obj6.set_Checked(false);
		obj5.set_Checked(false);
		obj4.set_Checked(false);
		obj3.set_Checked(false);
		obj2.set_Checked(false);
		obj.set_Checked(false);
	}

	private void checkAllOtherToolStripMenuItem_Click(object sender, EventArgs e)
	{
		CheckBox obj = keyPerm;
		CheckBox obj2 = storePerm;
		CheckBox obj3 = olePerm;
		odbcPerm.set_Checked(true);
		obj3.set_Checked(true);
		obj2.set_Checked(true);
		obj.set_Checked(true);
	}

	private void uncheckAllOtherToolStripMenuItem_Click(object sender, EventArgs e)
	{
		CheckBox obj = keyPerm;
		CheckBox obj2 = storePerm;
		CheckBox obj3 = olePerm;
		odbcPerm.set_Checked(false);
		obj3.set_Checked(false);
		obj2.set_Checked(false);
		obj.set_Checked(false);
	}

	private void checkAllPermissionsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		checkAllLocalToolStripMenuItem_Click(sender, e);
		checkAllFileToolStripMenuItem_Click(sender, e);
		checkAllSecToolStripMenuItem_Click(sender, e);
		checkAllRefToolStripMenuItem_Click(sender, e);
		checkAllNetToolStripMenuItem_Click(sender, e);
		checkAllOtherToolStripMenuItem_Click(sender, e);
	}

	private void uncheckAllPermissionsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		uncheckAllLocalToolStripMenuItem_Click(sender, e);
		uncheckAllFileToolStripMenuItem_Click(sender, e);
		uncheckAllSecToolStripMenuItem_Click(sender, e);
		uncheckAllRefToolStripMenuItem_Click(sender, e);
		uncheckAllNetToolStripMenuItem_Click(sender, e);
		uncheckAllOtherToolStripMenuItem_Click(sender, e);
	}

	private void importPermissionsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		ImportPermissions(null);
	}

	private void exportPermissionsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		ExportPermissions(null);
	}

	private void saveToAProfileToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			string text = Path.Combine(Environment.CurrentDirectory, "Profiles");
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			ExportPermissions(text);
		}
		catch (Exception exception)
		{
			ShowError(exception, "Unexpected Error");
		}
	}

	protected override void OnFormClosing(FormClosingEventArgs e)
	{
		((Form)this).OnFormClosing(e);
		AbortSandbox();
	}

	private void InitPermissionTabs()
	{
		if (_sandboxPermissions.DefaultPermissions)
		{
			ioPerm.set_Checked(true);
			uiPerm.set_Checked(true);
		}
		else
		{
			ioPerm.set_Checked(_sandboxPermissions.DefaultIO);
			uiPerm.set_Checked(_sandboxPermissions.UI);
		}
		aspPerm.set_Checked(_sandboxPermissions.AspNetHosting);
		dnsPerm.set_Checked(_sandboxPermissions.Dns);
		eventLogPerm.set_Checked(_sandboxPermissions.EventLog);
		fileDialogPerm.set_Checked(_sandboxPermissions.FileDialog);
		gacPerm.set_Checked(_sandboxPermissions.GacIdentity);
		isolatedPerm.set_Checked(_sandboxPermissions.IsolatedStorage);
		keyPerm.set_Checked(_sandboxPermissions.KeyContainer);
		netInfoPerm.set_Checked(_sandboxPermissions.NetworkInformation);
		odbcPerm.set_Checked(_sandboxPermissions.Odbc);
		olePerm.set_Checked(_sandboxPermissions.OleDb);
		perfPerm.set_Checked(_sandboxPermissions.PerformanceCounter);
		princePerm.set_Checked(_sandboxPermissions.Principal);
		printPerm.set_Checked(_sandboxPermissions.Printing);
		publishPerm.set_Checked(_sandboxPermissions.PublisherIdentity);
		reflectPerm.set_Checked(_sandboxPermissions.Reflection);
		regPerm.set_Checked(_sandboxPermissions.Registry);
		smtpPerm.set_Checked(_sandboxPermissions.Smtp);
		sqlPerm.set_Checked(_sandboxPermissions.Sql);
		socketPerm.set_Checked(_sandboxPermissions.Socket);
		storePerm.set_Checked(_sandboxPermissions.Store);
		sitePerm.set_Checked(_sandboxPermissions.SiteIdentity);
		strongNamePerm.set_Checked(_sandboxPermissions.StrongNameIdentity);
		urlPerm.set_Checked(_sandboxPermissions.UrlIdentity);
		zonePerm.set_Checked(_sandboxPermissions.ZoneIdentity);
		webPerm.set_Checked(_sandboxPermissions.Web);
		typePerm.set_Checked(_sandboxPermissions.TypeDescriptor);
		InitFileIOPerms();
		InitSecurityPerms();
		Logging.Log("Permission tabs have been populated!", Logging.Severity.DEBUG);
	}

	private void UpdateSandboxPermissions(bool ignoreCurrentExePath = false)
	{
		_sandboxPermissions.DefaultIO = ioPerm.get_Checked();
		_sandboxPermissions.UI = uiPerm.get_Checked();
		_sandboxPermissions.AspNetHosting = aspPerm.get_Checked();
		_sandboxPermissions.Dns = dnsPerm.get_Checked();
		_sandboxPermissions.EventLog = eventLogPerm.get_Checked();
		_sandboxPermissions.FileDialog = fileDialogPerm.get_Checked();
		_sandboxPermissions.GacIdentity = gacPerm.get_Checked();
		_sandboxPermissions.IsolatedStorage = isolatedPerm.get_Checked();
		_sandboxPermissions.KeyContainer = keyPerm.get_Checked();
		_sandboxPermissions.NetworkInformation = netInfoPerm.get_Checked();
		_sandboxPermissions.Odbc = odbcPerm.get_Checked();
		_sandboxPermissions.OleDb = olePerm.get_Checked();
		_sandboxPermissions.PerformanceCounter = perfPerm.get_Checked();
		_sandboxPermissions.Principal = princePerm.get_Checked();
		_sandboxPermissions.Printing = printPerm.get_Checked();
		_sandboxPermissions.PublisherIdentity = publishPerm.get_Checked();
		_sandboxPermissions.Reflection = reflectPerm.get_Checked();
		_sandboxPermissions.Registry = regPerm.get_Checked();
		_sandboxPermissions.Smtp = smtpPerm.get_Checked();
		_sandboxPermissions.Sql = sqlPerm.get_Checked();
		_sandboxPermissions.Socket = socketPerm.get_Checked();
		_sandboxPermissions.Store = storePerm.get_Checked();
		_sandboxPermissions.SiteIdentity = sitePerm.get_Checked();
		_sandboxPermissions.StrongNameIdentity = strongNamePerm.get_Checked();
		_sandboxPermissions.UrlIdentity = urlPerm.get_Checked();
		_sandboxPermissions.ZoneIdentity = zonePerm.get_Checked();
		_sandboxPermissions.Web = webPerm.get_Checked();
		_sandboxPermissions.TypeDescriptor = typePerm.get_Checked();
		_sandboxPermissions.FileIOPerms = GetFilePerms();
		_sandboxPermissions.Security = GetSecPerms();
		_sandboxPermissions.SetExecutablePath(_sandbox.ProgramPath);
		_sandbox.Permissions = _sandboxPermissions.GeneratePermissionSet(ignoreCurrentExePath);
	}

	public Permissions GetPermissions()
	{
		return _sandboxPermissions;
	}

	public void UpdatePermissions(Permissions permissions)
	{
		_sandboxPermissions = permissions;
		InitPermissionTabs();
	}

	private void InitFileIOPerms()
	{
		allFilesPerm.set_Checked(_sandboxPermissions.AllFiles);
		ClearFileList();
		if (_sandboxPermissions.FileIOPerms != null && _sandboxPermissions.FileIOPerms.Length != 0)
		{
			FilePerms[] fileIOPerms = _sandboxPermissions.FileIOPerms;
			foreach (FilePerms filePerms in fileIOPerms)
			{
				AddPathToList(filePerms.Path, filePerms.Read, filePerms.Write, filePerms.Append);
			}
		}
	}

	private FilePerms[] GetFilePerms()
	{
		_sandboxPermissions.AllFiles = allFilesPerm.get_Checked();
		List<FilePerms> list = new List<FilePerms>();
		FileIO_File[] array = ((IEnumerable)listOfAllFilesTable.get_Controls()).OfType<FileIO_File>().ToArray();
		foreach (FileIO_File fileIO_File in array)
		{
			list.Add(new FilePerms(fileIO_File.FilePath, fileIO_File.Read, fileIO_File.Write, fileIO_File.Append));
		}
		if (list.Count > 0)
		{
			return list.ToArray();
		}
		return null;
	}

	public void AddPathToList(string path, bool read, bool write, bool append)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		if (((ArrangedElementCollection)listOfAllFilesTable.get_Controls()).get_Count() > 0)
		{
			TableLayoutHelper.RemoveArbitraryRow(listOfAllFilesTable, ((TableLayoutStyleCollection)listOfAllFilesTable.get_RowStyles()).get_Count() - 1);
		}
		int rowCount;
		if (listOfAllFilesTable.get_RowCount() == 0)
		{
			TableLayoutPanel obj = listOfAllFilesTable;
			rowCount = obj.get_RowCount();
			obj.set_RowCount(rowCount + 1);
			listOfAllFilesTable.get_RowStyles().Add(new RowStyle((SizeType)1, 50f));
		}
		int num = listOfAllFilesTable.get_RowCount() - 1;
		FileIO_File fileIO_File = new FileIO_File(path, read, write, append, this);
		((Control)fileIO_File).set_Dock((DockStyle)5);
		((Control)fileIO_File).set_Height(50);
		((Control)fileIO_File).set_Padding(new Padding(0));
		((Control)fileIO_File).set_Margin(new Padding(0));
		FileIO_File fileIO_File2 = fileIO_File;
		listOfAllFilesTable.get_Controls().Add((Control)(object)fileIO_File2, 0, num);
		((TableLayoutStyle)listOfAllFilesTable.get_RowStyles().get_Item(((TableLayoutStyleCollection)listOfAllFilesTable.get_RowStyles()).get_Count() - 1)).set_SizeType((SizeType)1);
		listOfAllFilesTable.get_RowStyles().get_Item(((TableLayoutStyleCollection)listOfAllFilesTable.get_RowStyles()).get_Count() - 1).set_Height(50f);
		listOfAllFilesTable.set_RowCount(((TableLayoutStyleCollection)listOfAllFilesTable.get_RowStyles()).get_Count() + 1);
		TableLayoutPanel obj2 = listOfAllFilesTable;
		rowCount = obj2.get_RowCount();
		obj2.set_RowCount(rowCount + 1);
		listOfAllFilesTable.get_RowStyles().Add(new RowStyle((SizeType)1, 50f));
		Logging.Log(string.Format("Added '{0}' to the File I/O list! ({1}{2}{3})", path, read ? "r" : "", write ? "w" : "", append ? "a" : ""), Logging.Severity.DEBUG);
	}

	public void RemovePathFromList(FileIO_File control)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		if (listOfAllFilesTable.get_RowCount() == 1)
		{
			TableLayoutPanel obj = listOfAllFilesTable;
			int rowCount = obj.get_RowCount();
			obj.set_RowCount(rowCount + 1);
			listOfAllFilesTable.get_RowStyles().Add(new RowStyle((SizeType)1, 50f));
		}
		TableLayoutHelper.RemoveArbitraryRow(listOfAllFilesTable, ((ControlCollection)listOfAllFilesTable.get_Controls()).IndexOf((Control)(object)control));
	}

	private void AddFilesToList(bool read, bool write, bool append, string title)
	{
		Thread thread = new Thread((ThreadStart)delegate
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Invalid comparison between Unknown and I4
			//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Expected O, but got Unknown
			OpenFileDialog val = new OpenFileDialog();
			((FileDialog)val).set_Title(title);
			val.set_Multiselect(true);
			DialogResult val2 = ((CommonDialog)val).ShowDialog();
			if ((int)val2 == 1)
			{
				List<string> list = new List<string>();
				string[] fileNames = ((FileDialog)val).get_FileNames();
				string[] array = fileNames;
				foreach (string text in array)
				{
					if (File.Exists(text))
					{
						list.Add(text);
					}
				}
				if (list.Count > 0)
				{
					foreach (string path in list)
					{
						((Control)this).BeginInvoke((Delegate)(MethodInvoker)delegate
						{
							AddPathToList(path, read, write, append);
						});
					}
				}
			}
		});
		thread.SetApartmentState(ApartmentState.STA);
		thread.Start();
	}

	private void AddFoldersToList(bool read, bool write, bool append, string description)
	{
		Thread thread = new Thread((ThreadStart)delegate
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Invalid comparison between Unknown and I4
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Expected O, but got Unknown
			FolderBrowserDialog val = new FolderBrowserDialog();
			val.set_Description(description);
			DialogResult val2 = ((CommonDialog)val).ShowDialog();
			if ((int)val2 == 1)
			{
				new List<string>();
				string fPath = val.get_SelectedPath();
				if (Directory.Exists(fPath))
				{
					((Control)this).BeginInvoke((Delegate)(MethodInvoker)delegate
					{
						AddPathToList(fPath, read, write, append);
					});
				}
			}
		});
		thread.SetApartmentState(ApartmentState.STA);
		thread.Start();
	}

	private void InitSecurityPerms()
	{
		if (_sandboxPermissions.DefaultPermissions)
		{
			executionPerm.set_Checked(true);
		}
		else
		{
			executionPerm.set_Checked(_sandboxPermissions.Security.ContainsFlag(SecurityPermissionFlag.Execution));
		}
		assertPerm.set_Checked(_sandboxPermissions.Security.ContainsFlag(SecurityPermissionFlag.Assertion));
		bindRedirectPerm.set_Checked(_sandboxPermissions.Security.ContainsFlag(SecurityPermissionFlag.BindingRedirects));
		controlAppDomainPerm.set_Checked(_sandboxPermissions.Security.ContainsFlag(SecurityPermissionFlag.ControlAppDomain));
		controlEvidencePerm.set_Checked(_sandboxPermissions.Security.ContainsFlag(SecurityPermissionFlag.ControlEvidence));
		controlDomainPolicyPerm.set_Checked(_sandboxPermissions.Security.ContainsFlag(SecurityPermissionFlag.ControlDomainPolicy));
		controlPolicy.set_Checked(_sandboxPermissions.Security.ContainsFlag(SecurityPermissionFlag.ControlPolicy));
		controlPrincipalPerm.set_Checked(_sandboxPermissions.Security.ContainsFlag(SecurityPermissionFlag.ControlPrincipal));
		controlThreadPerm.set_Checked(_sandboxPermissions.Security.ContainsFlag(SecurityPermissionFlag.ControlThread));
		infrastructurePerm.set_Checked(_sandboxPermissions.Security.ContainsFlag(SecurityPermissionFlag.Infrastructure));
		remotingConfigurationPerm.set_Checked(_sandboxPermissions.Security.ContainsFlag(SecurityPermissionFlag.RemotingConfiguration));
		serializationFormatterPerm.set_Checked(_sandboxPermissions.Security.ContainsFlag(SecurityPermissionFlag.SerializationFormatter));
		skipVerificationPerm.set_Checked(_sandboxPermissions.Security.ContainsFlag(SecurityPermissionFlag.SkipVerification));
		unmanagedCode.set_Checked(_sandboxPermissions.Security.ContainsFlag(SecurityPermissionFlag.UnmanagedCode));
	}

	private SecurityPerms GetSecPerms()
	{
		SecurityPerms securityPerms = new SecurityPerms(assertPerm.get_Checked(), bindRedirectPerm.get_Checked(), controlAppDomainPerm.get_Checked(), controlEvidencePerm.get_Checked(), controlDomainPolicyPerm.get_Checked(), controlPolicy.get_Checked(), controlPrincipalPerm.get_Checked(), controlThreadPerm.get_Checked(), executionPerm.get_Checked(), infrastructurePerm.get_Checked(), remotingConfigurationPerm.get_Checked(), serializationFormatterPerm.get_Checked(), skipVerificationPerm.get_Checked(), unmanagedCode.get_Checked());
		securityPerms.AddFlag(_sandboxPermissions.Security.GetSecurityPermissionFlag());
		return securityPerms;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected O, but got Unknown
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected O, but got Unknown
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
		//IL_0566: Unknown result type (might be due to invalid IL or missing references)
		//IL_0570: Expected O, but got Unknown
		//IL_0571: Unknown result type (might be due to invalid IL or missing references)
		//IL_057b: Expected O, but got Unknown
		//IL_057c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0586: Expected O, but got Unknown
		//IL_0587: Unknown result type (might be due to invalid IL or missing references)
		//IL_0591: Expected O, but got Unknown
		//IL_0592: Unknown result type (might be due to invalid IL or missing references)
		//IL_059c: Expected O, but got Unknown
		//IL_059d: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a7: Expected O, but got Unknown
		//IL_1617: Unknown result type (might be due to invalid IL or missing references)
		//IL_1621: Expected O, but got Unknown
		//IL_164a: Unknown result type (might be due to invalid IL or missing references)
		//IL_183d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1847: Expected O, but got Unknown
		//IL_1859: Unknown result type (might be due to invalid IL or missing references)
		//IL_1863: Expected O, but got Unknown
		//IL_1875: Unknown result type (might be due to invalid IL or missing references)
		//IL_187f: Expected O, but got Unknown
		//IL_198b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1995: Expected O, but got Unknown
		//IL_19a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_19b1: Expected O, but got Unknown
		//IL_19c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_19cd: Expected O, but got Unknown
		//IL_19df: Unknown result type (might be due to invalid IL or missing references)
		//IL_19e9: Expected O, but got Unknown
		//IL_19fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a05: Expected O, but got Unknown
		//IL_1a17: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a21: Expected O, but got Unknown
		//IL_1a33: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a3d: Expected O, but got Unknown
		//IL_1fab: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fb5: Expected O, but got Unknown
		//IL_203b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2072: Unknown result type (might be due to invalid IL or missing references)
		//IL_207c: Expected O, but got Unknown
		//IL_208e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2098: Expected O, but got Unknown
		//IL_20aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_20b4: Expected O, but got Unknown
		//IL_20c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_20d0: Expected O, but got Unknown
		//IL_2114: Unknown result type (might be due to invalid IL or missing references)
		//IL_211e: Expected O, but got Unknown
		//IL_2130: Unknown result type (might be due to invalid IL or missing references)
		//IL_213a: Expected O, but got Unknown
		//IL_214c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2156: Expected O, but got Unknown
		//IL_21c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_21ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_2209: Expected O, but got Unknown
		//IL_24ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_24c4: Expected O, but got Unknown
		//IL_24ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_2521: Unknown result type (might be due to invalid IL or missing references)
		//IL_252b: Expected O, but got Unknown
		//IL_256f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2579: Expected O, but got Unknown
		//IL_258b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2595: Expected O, but got Unknown
		//IL_25a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_25b1: Expected O, but got Unknown
		//IL_2623: Unknown result type (might be due to invalid IL or missing references)
		//IL_265a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2664: Expected O, but got Unknown
		//IL_289f: Unknown result type (might be due to invalid IL or missing references)
		//IL_28a9: Expected O, but got Unknown
		//IL_28bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_28c5: Expected O, but got Unknown
		//IL_291f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2956: Unknown result type (might be due to invalid IL or missing references)
		//IL_2960: Expected O, but got Unknown
		//IL_29c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b05: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b78: Expected O, but got Unknown
		//IL_2b8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b94: Expected O, but got Unknown
		//IL_2ba6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bb0: Expected O, but got Unknown
		//IL_2d4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d56: Expected O, but got Unknown
		//IL_2d68: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d72: Expected O, but got Unknown
		//IL_2d84: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d8e: Expected O, but got Unknown
		//IL_2da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2daa: Expected O, but got Unknown
		//IL_2dbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dc6: Expected O, but got Unknown
		//IL_2dd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2de2: Expected O, but got Unknown
		//IL_2df4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dfe: Expected O, but got Unknown
		//IL_3686: Unknown result type (might be due to invalid IL or missing references)
		//IL_36ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_36f9: Expected O, but got Unknown
		//IL_370b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3715: Expected O, but got Unknown
		//IL_3727: Unknown result type (might be due to invalid IL or missing references)
		//IL_3731: Expected O, but got Unknown
		//IL_380d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3817: Expected O, but got Unknown
		//IL_3829: Unknown result type (might be due to invalid IL or missing references)
		//IL_3833: Expected O, but got Unknown
		//IL_3845: Unknown result type (might be due to invalid IL or missing references)
		//IL_384f: Expected O, but got Unknown
		//IL_3861: Unknown result type (might be due to invalid IL or missing references)
		//IL_386b: Expected O, but got Unknown
		//IL_387d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3887: Expected O, but got Unknown
		//IL_3899: Unknown result type (might be due to invalid IL or missing references)
		//IL_38a3: Expected O, but got Unknown
		//IL_38b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_38bf: Expected O, but got Unknown
		//IL_3c99: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d02: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d0c: Expected O, but got Unknown
		//IL_3d1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d28: Expected O, but got Unknown
		//IL_3d3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d44: Expected O, but got Unknown
		//IL_3e80: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e8a: Expected O, but got Unknown
		//IL_3e9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ea6: Expected O, but got Unknown
		//IL_3eb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ec2: Expected O, but got Unknown
		//IL_3ed4: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ede: Expected O, but got Unknown
		//IL_3ef0: Unknown result type (might be due to invalid IL or missing references)
		//IL_3efa: Expected O, but got Unknown
		//IL_3f0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f16: Expected O, but got Unknown
		//IL_3f28: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f32: Expected O, but got Unknown
		//IL_3f44: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f4e: Expected O, but got Unknown
		//IL_4574: Unknown result type (might be due to invalid IL or missing references)
		//IL_45dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_45e7: Expected O, but got Unknown
		//IL_45f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_4603: Expected O, but got Unknown
		//IL_4615: Unknown result type (might be due to invalid IL or missing references)
		//IL_461f: Expected O, but got Unknown
		//IL_46cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_46d5: Expected O, but got Unknown
		//IL_46e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_46f1: Expected O, but got Unknown
		//IL_4703: Unknown result type (might be due to invalid IL or missing references)
		//IL_470d: Expected O, but got Unknown
		//IL_471f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4729: Expected O, but got Unknown
		//IL_473b: Unknown result type (might be due to invalid IL or missing references)
		//IL_4745: Expected O, but got Unknown
		//IL_4757: Unknown result type (might be due to invalid IL or missing references)
		//IL_4761: Expected O, but got Unknown
		//IL_4773: Unknown result type (might be due to invalid IL or missing references)
		//IL_477d: Expected O, but got Unknown
		//IL_4d72: Unknown result type (might be due to invalid IL or missing references)
		//IL_4dfe: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e67: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e71: Expected O, but got Unknown
		//IL_4e83: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e8d: Expected O, but got Unknown
		//IL_4e9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4ea9: Expected O, but got Unknown
		//IL_4fa9: Unknown result type (might be due to invalid IL or missing references)
		//IL_4fb3: Expected O, but got Unknown
		//IL_4fc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_4fcf: Expected O, but got Unknown
		//IL_4fe1: Unknown result type (might be due to invalid IL or missing references)
		//IL_4feb: Expected O, but got Unknown
		//IL_4ffd: Unknown result type (might be due to invalid IL or missing references)
		//IL_5007: Expected O, but got Unknown
		//IL_504c: Unknown result type (might be due to invalid IL or missing references)
		//IL_5056: Expected O, but got Unknown
		//IL_5068: Unknown result type (might be due to invalid IL or missing references)
		//IL_5072: Expected O, but got Unknown
		//IL_50c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_50ca: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(SandboxDotNet));
		menuStrip = new MenuStrip();
		fileToolStripMenuItem = new ToolStripMenuItem();
		openToolStripMenuItem = new ToolStripMenuItem();
		toolStripMenuItem1 = new ToolStripSeparator();
		importPermissionsToolStripMenuItem = new ToolStripMenuItem();
		exportPermissionsToolStripMenuItem = new ToolStripMenuItem();
		toolStripMenuItem6 = new ToolStripSeparator();
		exitToolStripMenuItem = new ToolStripMenuItem();
		editToolStripMenuItem = new ToolStripMenuItem();
		programOptionsToolStripMenuItem = new ToolStripMenuItem();
		permissionsToolStripMenuItem = new ToolStripMenuItem();
		toolStripMenuItem3 = new ToolStripSeparator();
		localToolStripMenuItem = new ToolStripMenuItem();
		checkAllLocalToolStripMenuItem = new ToolStripMenuItem();
		uncheckAllLocalToolStripMenuItem = new ToolStripMenuItem();
		fileIOToolStripMenuItem = new ToolStripMenuItem();
		checkAllFileToolStripMenuItem = new ToolStripMenuItem();
		uncheckAllFileToolStripMenuItem = new ToolStripMenuItem();
		clearFileListToolStripMenuItem = new ToolStripMenuItem();
		securityToolStripMenuItem = new ToolStripMenuItem();
		checkAllSecToolStripMenuItem = new ToolStripMenuItem();
		uncheckAllSecToolStripMenuItem = new ToolStripMenuItem();
		reflectionToolStripMenuItem = new ToolStripMenuItem();
		checkAllRefToolStripMenuItem = new ToolStripMenuItem();
		uncheckAllRefToolStripMenuItem = new ToolStripMenuItem();
		networkToolStripMenuItem = new ToolStripMenuItem();
		checkAllNetToolStripMenuItem = new ToolStripMenuItem();
		uncheckAllNetToolStripMenuItem = new ToolStripMenuItem();
		otherToolStripMenuItem = new ToolStripMenuItem();
		checkAllOtherToolStripMenuItem = new ToolStripMenuItem();
		uncheckAllOtherToolStripMenuItem = new ToolStripMenuItem();
		toolStripMenuItem4 = new ToolStripSeparator();
		checkAllPermissionsToolStripMenuItem = new ToolStripMenuItem();
		uncheckAllPermissionsToolStripMenuItem = new ToolStripMenuItem();
		profilesToolStripMenuItem = new ToolStripMenuItem();
		saveToAProfileToolStripMenuItem = new ToolStripMenuItem();
		toolStripMenuItem5 = new ToolStripSeparator();
		aboutToolStripMenuItem = new ToolStripMenuItem();
		helpToolStripMenuItem = new ToolStripMenuItem();
		toolStripMenuItem2 = new ToolStripSeparator();
		aboutSandboxToolStripMenuItem = new ToolStripMenuItem();
		developerToolStripMenuItem = new ToolStripMenuItem();
		devConsoleToolStripMenuItem = new ToolStripMenuItem();
		runSandbox = new Button();
		openFileDialog = new OpenFileDialog();
		titlePanel = new Panel();
		title = new Label();
		toolTip = new ToolTip(components);
		permissionsTabControl = new TabControl();
		locMachinePermsTab = new TabPage();
		localPermsTable = new TableLayoutPanel();
		ioPerm = new CheckBox();
		uiPerm = new CheckBox();
		printPerm = new CheckBox();
		fileDialogPerm = new CheckBox();
		princePerm = new CheckBox();
		eventLogPerm = new CheckBox();
		perfPerm = new CheckBox();
		regPerm = new CheckBox();
		fileIoPermsTab = new TabPage();
		fileIoTableLayoutPanel = new TableLayoutPanel();
		fileIoFolderButtonTableLayoutPanel = new TableLayoutPanel();
		addFolderAppendButton = new Button();
		addFolderWriteButton = new Button();
		addFolderReadButton = new Button();
		fileIoPermsTabPanel = new Panel();
		listOfAllFilesTable = new TableLayoutPanel();
		fileIoFileButtonTableLayoutPanel = new TableLayoutPanel();
		addFilesAppendButton = new Button();
		addFilesWriteButton = new Button();
		addFilesReadButton = new Button();
		tableLayoutPanel2 = new TableLayoutPanel();
		allFilesPerm = new CheckBox();
		clearFileIOListButton = new Button();
		securityPermsTab = new TabPage();
		secPermsTable = new TableLayoutPanel();
		executionPerm = new CheckBox();
		assertPerm = new CheckBox();
		bindRedirectPerm = new CheckBox();
		controlAppDomainPerm = new CheckBox();
		controlDomainPolicyPerm = new CheckBox();
		controlEvidencePerm = new CheckBox();
		controlPolicy = new CheckBox();
		controlPrincipalPerm = new CheckBox();
		controlThreadPerm = new CheckBox();
		infrastructurePerm = new CheckBox();
		remotingConfigurationPerm = new CheckBox();
		serializationFormatterPerm = new CheckBox();
		skipVerificationPerm = new CheckBox();
		unmanagedCode = new CheckBox();
		refPermsTab = new TabPage();
		refPermsTable = new TableLayoutPanel();
		gacPerm = new CheckBox();
		reflectPerm = new CheckBox();
		publishPerm = new CheckBox();
		typePerm = new CheckBox();
		strongNamePerm = new CheckBox();
		isolatedPerm = new CheckBox();
		netPermsTab = new TabPage();
		netPermsTable = new TableLayoutPanel();
		aspPerm = new CheckBox();
		dnsPerm = new CheckBox();
		urlPerm = new CheckBox();
		netInfoPerm = new CheckBox();
		smtpPerm = new CheckBox();
		socketPerm = new CheckBox();
		sitePerm = new CheckBox();
		sqlPerm = new CheckBox();
		webPerm = new CheckBox();
		zonePerm = new CheckBox();
		otherPermsTab = new TabPage();
		otherPermsTable = new TableLayoutPanel();
		keyPerm = new CheckBox();
		storePerm = new CheckBox();
		olePerm = new CheckBox();
		odbcPerm = new CheckBox();
		pathLabel = new Label();
		pathTextBox = new TextBox();
		selectFileButton = new Button();
		argsTextBox = new TextBox();
		argsLabel = new Label();
		clearArgsButton = new Button();
		sandboxRunning = new Timer(components);
		permGlobalTabPage = new TabPage();
		programTab = new TabPage();
		progPanel = new TableLayoutPanel();
		consoleControlPanel = new TableLayoutPanel();
		sandboxTabControl = new TabControl();
		((Control)menuStrip).SuspendLayout();
		((Control)titlePanel).SuspendLayout();
		((Control)permissionsTabControl).SuspendLayout();
		((Control)locMachinePermsTab).SuspendLayout();
		((Control)localPermsTable).SuspendLayout();
		((Control)fileIoPermsTab).SuspendLayout();
		((Control)fileIoTableLayoutPanel).SuspendLayout();
		((Control)fileIoFolderButtonTableLayoutPanel).SuspendLayout();
		((Control)fileIoPermsTabPanel).SuspendLayout();
		((Control)fileIoFileButtonTableLayoutPanel).SuspendLayout();
		((Control)tableLayoutPanel2).SuspendLayout();
		((Control)securityPermsTab).SuspendLayout();
		((Control)secPermsTable).SuspendLayout();
		((Control)refPermsTab).SuspendLayout();
		((Control)refPermsTable).SuspendLayout();
		((Control)netPermsTab).SuspendLayout();
		((Control)netPermsTable).SuspendLayout();
		((Control)otherPermsTab).SuspendLayout();
		((Control)otherPermsTable).SuspendLayout();
		((Control)permGlobalTabPage).SuspendLayout();
		((Control)programTab).SuspendLayout();
		((Control)progPanel).SuspendLayout();
		((Control)sandboxTabControl).SuspendLayout();
		((Control)this).SuspendLayout();
		((ToolStrip)menuStrip).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)fileToolStripMenuItem,
			(ToolStripItem)editToolStripMenuItem,
			(ToolStripItem)profilesToolStripMenuItem,
			(ToolStripItem)aboutToolStripMenuItem,
			(ToolStripItem)developerToolStripMenuItem
		});
		((Control)menuStrip).set_Location(new Point(0, 0));
		((Control)menuStrip).set_Name("menuStrip");
		((Control)menuStrip).set_Size(new Size(559, 24));
		((Control)menuStrip).set_TabIndex(1);
		((Control)menuStrip).set_Text("Menu Strip");
		((ToolStripItem)fileToolStripMenuItem).set_DisplayStyle((ToolStripItemDisplayStyle)1);
		((ToolStripDropDownItem)fileToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)openToolStripMenuItem,
			(ToolStripItem)toolStripMenuItem1,
			(ToolStripItem)importPermissionsToolStripMenuItem,
			(ToolStripItem)exportPermissionsToolStripMenuItem,
			(ToolStripItem)toolStripMenuItem6,
			(ToolStripItem)exitToolStripMenuItem
		});
		((ToolStripItem)fileToolStripMenuItem).set_Name("fileToolStripMenuItem");
		((ToolStripItem)fileToolStripMenuItem).set_Size(new Size(37, 20));
		((ToolStripItem)fileToolStripMenuItem).set_Text("File");
		((ToolStripItem)openToolStripMenuItem).set_Name("openToolStripMenuItem");
		openToolStripMenuItem.set_ShortcutKeys((Keys)131151);
		((ToolStripItem)openToolStripMenuItem).set_Size(new Size(185, 22));
		((ToolStripItem)openToolStripMenuItem).set_Text("Open...");
		((ToolStripItem)openToolStripMenuItem).add_Click((EventHandler)selectFileButton_Click);
		((ToolStripItem)toolStripMenuItem1).set_Name("toolStripMenuItem1");
		((ToolStripItem)toolStripMenuItem1).set_Size(new Size(182, 6));
		((ToolStripItem)importPermissionsToolStripMenuItem).set_Name("importPermissionsToolStripMenuItem");
		((ToolStripItem)importPermissionsToolStripMenuItem).set_Size(new Size(185, 22));
		((ToolStripItem)importPermissionsToolStripMenuItem).set_Text("Import Permissions...");
		((ToolStripItem)importPermissionsToolStripMenuItem).add_Click((EventHandler)importPermissionsToolStripMenuItem_Click);
		((ToolStripItem)exportPermissionsToolStripMenuItem).set_Name("exportPermissionsToolStripMenuItem");
		((ToolStripItem)exportPermissionsToolStripMenuItem).set_Size(new Size(185, 22));
		((ToolStripItem)exportPermissionsToolStripMenuItem).set_Text("Export Permissions...");
		((ToolStripItem)exportPermissionsToolStripMenuItem).add_Click((EventHandler)exportPermissionsToolStripMenuItem_Click);
		((ToolStripItem)toolStripMenuItem6).set_Name("toolStripMenuItem6");
		((ToolStripItem)toolStripMenuItem6).set_Size(new Size(182, 6));
		((ToolStripItem)exitToolStripMenuItem).set_Name("exitToolStripMenuItem");
		exitToolStripMenuItem.set_ShortcutKeys((Keys)262259);
		((ToolStripItem)exitToolStripMenuItem).set_Size(new Size(185, 22));
		((ToolStripItem)exitToolStripMenuItem).set_Text("Exit");
		((ToolStripItem)exitToolStripMenuItem).add_Click((EventHandler)exitToolStripMenuItem_Click);
		((ToolStripItem)editToolStripMenuItem).set_DisplayStyle((ToolStripItemDisplayStyle)1);
		((ToolStripDropDownItem)editToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[12]
		{
			(ToolStripItem)programOptionsToolStripMenuItem,
			(ToolStripItem)permissionsToolStripMenuItem,
			(ToolStripItem)toolStripMenuItem3,
			(ToolStripItem)localToolStripMenuItem,
			(ToolStripItem)fileIOToolStripMenuItem,
			(ToolStripItem)securityToolStripMenuItem,
			(ToolStripItem)reflectionToolStripMenuItem,
			(ToolStripItem)networkToolStripMenuItem,
			(ToolStripItem)otherToolStripMenuItem,
			(ToolStripItem)toolStripMenuItem4,
			(ToolStripItem)checkAllPermissionsToolStripMenuItem,
			(ToolStripItem)uncheckAllPermissionsToolStripMenuItem
		});
		((ToolStripItem)editToolStripMenuItem).set_Name("editToolStripMenuItem");
		((ToolStripItem)editToolStripMenuItem).set_Size(new Size(39, 20));
		((ToolStripItem)editToolStripMenuItem).set_Text("Edit");
		((ToolStripItem)programOptionsToolStripMenuItem).set_Name("programOptionsToolStripMenuItem");
		programOptionsToolStripMenuItem.set_ShortcutKeys((Keys)262223);
		((ToolStripItem)programOptionsToolStripMenuItem).set_Size(new Size(204, 22));
		((ToolStripItem)programOptionsToolStripMenuItem).set_Text("Program Options");
		((ToolStripItem)programOptionsToolStripMenuItem).add_Click((EventHandler)programOptionsToolStripMenuItem_Click);
		((ToolStripItem)permissionsToolStripMenuItem).set_Name("permissionsToolStripMenuItem");
		permissionsToolStripMenuItem.set_ShortcutKeys((Keys)262224);
		((ToolStripItem)permissionsToolStripMenuItem).set_Size(new Size(204, 22));
		((ToolStripItem)permissionsToolStripMenuItem).set_Text("Permissions");
		((ToolStripItem)permissionsToolStripMenuItem).add_Click((EventHandler)permissionsToolStripMenuItem_Click);
		((ToolStripItem)toolStripMenuItem3).set_Name("toolStripMenuItem3");
		((ToolStripItem)toolStripMenuItem3).set_Size(new Size(201, 6));
		((ToolStripDropDownItem)localToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)checkAllLocalToolStripMenuItem,
			(ToolStripItem)uncheckAllLocalToolStripMenuItem
		});
		((ToolStripItem)localToolStripMenuItem).set_Name("localToolStripMenuItem");
		((ToolStripItem)localToolStripMenuItem).set_Size(new Size(204, 22));
		((ToolStripItem)localToolStripMenuItem).set_Text("Local");
		((ToolStripItem)checkAllLocalToolStripMenuItem).set_Name("checkAllLocalToolStripMenuItem");
		((ToolStripItem)checkAllLocalToolStripMenuItem).set_Size(new Size(137, 22));
		((ToolStripItem)checkAllLocalToolStripMenuItem).set_Text("Check All");
		((ToolStripItem)checkAllLocalToolStripMenuItem).add_Click((EventHandler)checkAllLocalToolStripMenuItem_Click);
		((ToolStripItem)uncheckAllLocalToolStripMenuItem).set_Name("uncheckAllLocalToolStripMenuItem");
		((ToolStripItem)uncheckAllLocalToolStripMenuItem).set_Size(new Size(137, 22));
		((ToolStripItem)uncheckAllLocalToolStripMenuItem).set_Text("Uncheck All");
		((ToolStripItem)uncheckAllLocalToolStripMenuItem).add_Click((EventHandler)uncheckAllLocalToolStripMenuItem_Click);
		((ToolStripDropDownItem)fileIOToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)checkAllFileToolStripMenuItem,
			(ToolStripItem)uncheckAllFileToolStripMenuItem,
			(ToolStripItem)clearFileListToolStripMenuItem
		});
		((ToolStripItem)fileIOToolStripMenuItem).set_Name("fileIOToolStripMenuItem");
		((ToolStripItem)fileIOToolStripMenuItem).set_Size(new Size(204, 22));
		((ToolStripItem)fileIOToolStripMenuItem).set_Text("File I/O");
		((ToolStripItem)checkAllFileToolStripMenuItem).set_Name("checkAllFileToolStripMenuItem");
		((ToolStripItem)checkAllFileToolStripMenuItem).set_Size(new Size(143, 22));
		((ToolStripItem)checkAllFileToolStripMenuItem).set_Text("Check All");
		((ToolStripItem)checkAllFileToolStripMenuItem).add_Click((EventHandler)checkAllFileToolStripMenuItem_Click);
		((ToolStripItem)uncheckAllFileToolStripMenuItem).set_Name("uncheckAllFileToolStripMenuItem");
		((ToolStripItem)uncheckAllFileToolStripMenuItem).set_Size(new Size(143, 22));
		((ToolStripItem)uncheckAllFileToolStripMenuItem).set_Text("Uncheck All");
		((ToolStripItem)uncheckAllFileToolStripMenuItem).add_Click((EventHandler)uncheckAllFileToolStripMenuItem_Click);
		((ToolStripItem)clearFileListToolStripMenuItem).set_Name("clearFileListToolStripMenuItem");
		((ToolStripItem)clearFileListToolStripMenuItem).set_Size(new Size(143, 22));
		((ToolStripItem)clearFileListToolStripMenuItem).set_Text("Clear File List");
		((ToolStripItem)clearFileListToolStripMenuItem).add_Click((EventHandler)clearFileListToolStripMenuItem_Click);
		((ToolStripDropDownItem)securityToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)checkAllSecToolStripMenuItem,
			(ToolStripItem)uncheckAllSecToolStripMenuItem
		});
		((ToolStripItem)securityToolStripMenuItem).set_Name("securityToolStripMenuItem");
		((ToolStripItem)securityToolStripMenuItem).set_Size(new Size(204, 22));
		((ToolStripItem)securityToolStripMenuItem).set_Text("Security");
		((ToolStripItem)checkAllSecToolStripMenuItem).set_Name("checkAllSecToolStripMenuItem");
		((ToolStripItem)checkAllSecToolStripMenuItem).set_Size(new Size(137, 22));
		((ToolStripItem)checkAllSecToolStripMenuItem).set_Text("Check All");
		((ToolStripItem)checkAllSecToolStripMenuItem).add_Click((EventHandler)checkAllSecToolStripMenuItem_Click);
		((ToolStripItem)uncheckAllSecToolStripMenuItem).set_Name("uncheckAllSecToolStripMenuItem");
		((ToolStripItem)uncheckAllSecToolStripMenuItem).set_Size(new Size(137, 22));
		((ToolStripItem)uncheckAllSecToolStripMenuItem).set_Text("Uncheck All");
		((ToolStripItem)uncheckAllSecToolStripMenuItem).add_Click((EventHandler)uncheckAllSecToolStripMenuItem_Click);
		((ToolStripDropDownItem)reflectionToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)checkAllRefToolStripMenuItem,
			(ToolStripItem)uncheckAllRefToolStripMenuItem
		});
		((ToolStripItem)reflectionToolStripMenuItem).set_Name("reflectionToolStripMenuItem");
		((ToolStripItem)reflectionToolStripMenuItem).set_Size(new Size(204, 22));
		((ToolStripItem)reflectionToolStripMenuItem).set_Text("Reflection");
		((ToolStripItem)checkAllRefToolStripMenuItem).set_Name("checkAllRefToolStripMenuItem");
		((ToolStripItem)checkAllRefToolStripMenuItem).set_Size(new Size(137, 22));
		((ToolStripItem)checkAllRefToolStripMenuItem).set_Text("Check All");
		((ToolStripItem)checkAllRefToolStripMenuItem).add_Click((EventHandler)checkAllRefToolStripMenuItem_Click);
		((ToolStripItem)uncheckAllRefToolStripMenuItem).set_Name("uncheckAllRefToolStripMenuItem");
		((ToolStripItem)uncheckAllRefToolStripMenuItem).set_Size(new Size(137, 22));
		((ToolStripItem)uncheckAllRefToolStripMenuItem).set_Text("Uncheck All");
		((ToolStripItem)uncheckAllRefToolStripMenuItem).add_Click((EventHandler)uncheckAllRefToolStripMenuItem_Click);
		((ToolStripDropDownItem)networkToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)checkAllNetToolStripMenuItem,
			(ToolStripItem)uncheckAllNetToolStripMenuItem
		});
		((ToolStripItem)networkToolStripMenuItem).set_Name("networkToolStripMenuItem");
		((ToolStripItem)networkToolStripMenuItem).set_Size(new Size(204, 22));
		((ToolStripItem)networkToolStripMenuItem).set_Text("Network");
		((ToolStripItem)checkAllNetToolStripMenuItem).set_Name("checkAllNetToolStripMenuItem");
		((ToolStripItem)checkAllNetToolStripMenuItem).set_Size(new Size(137, 22));
		((ToolStripItem)checkAllNetToolStripMenuItem).set_Text("Check All");
		((ToolStripItem)checkAllNetToolStripMenuItem).add_Click((EventHandler)checkAllNetToolStripMenuItem_Click);
		((ToolStripItem)uncheckAllNetToolStripMenuItem).set_Name("uncheckAllNetToolStripMenuItem");
		((ToolStripItem)uncheckAllNetToolStripMenuItem).set_Size(new Size(137, 22));
		((ToolStripItem)uncheckAllNetToolStripMenuItem).set_Text("Uncheck All");
		((ToolStripItem)uncheckAllNetToolStripMenuItem).add_Click((EventHandler)uncheckAllNetToolStripMenuItem_Click);
		((ToolStripDropDownItem)otherToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)checkAllOtherToolStripMenuItem,
			(ToolStripItem)uncheckAllOtherToolStripMenuItem
		});
		((ToolStripItem)otherToolStripMenuItem).set_Name("otherToolStripMenuItem");
		((ToolStripItem)otherToolStripMenuItem).set_Size(new Size(204, 22));
		((ToolStripItem)otherToolStripMenuItem).set_Text("Other");
		((ToolStripItem)checkAllOtherToolStripMenuItem).set_Name("checkAllOtherToolStripMenuItem");
		((ToolStripItem)checkAllOtherToolStripMenuItem).set_Size(new Size(137, 22));
		((ToolStripItem)checkAllOtherToolStripMenuItem).set_Text("Check All");
		((ToolStripItem)checkAllOtherToolStripMenuItem).add_Click((EventHandler)checkAllOtherToolStripMenuItem_Click);
		((ToolStripItem)uncheckAllOtherToolStripMenuItem).set_Name("uncheckAllOtherToolStripMenuItem");
		((ToolStripItem)uncheckAllOtherToolStripMenuItem).set_Size(new Size(137, 22));
		((ToolStripItem)uncheckAllOtherToolStripMenuItem).set_Text("Uncheck All");
		((ToolStripItem)uncheckAllOtherToolStripMenuItem).add_Click((EventHandler)uncheckAllOtherToolStripMenuItem_Click);
		((ToolStripItem)toolStripMenuItem4).set_Name("toolStripMenuItem4");
		((ToolStripItem)toolStripMenuItem4).set_Size(new Size(201, 6));
		((ToolStripItem)checkAllPermissionsToolStripMenuItem).set_Name("checkAllPermissionsToolStripMenuItem");
		((ToolStripItem)checkAllPermissionsToolStripMenuItem).set_Size(new Size(204, 22));
		((ToolStripItem)checkAllPermissionsToolStripMenuItem).set_Text("Check All Permissions");
		((ToolStripItem)checkAllPermissionsToolStripMenuItem).add_Click((EventHandler)checkAllPermissionsToolStripMenuItem_Click);
		((ToolStripItem)uncheckAllPermissionsToolStripMenuItem).set_Name("uncheckAllPermissionsToolStripMenuItem");
		((ToolStripItem)uncheckAllPermissionsToolStripMenuItem).set_Size(new Size(204, 22));
		((ToolStripItem)uncheckAllPermissionsToolStripMenuItem).set_Text("Uncheck All Permissions");
		((ToolStripItem)uncheckAllPermissionsToolStripMenuItem).add_Click((EventHandler)uncheckAllPermissionsToolStripMenuItem_Click);
		((ToolStripDropDownItem)profilesToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)saveToAProfileToolStripMenuItem,
			(ToolStripItem)toolStripMenuItem5
		});
		((ToolStripItem)profilesToolStripMenuItem).set_Name("profilesToolStripMenuItem");
		((ToolStripItem)profilesToolStripMenuItem).set_Size(new Size(58, 20));
		((ToolStripItem)profilesToolStripMenuItem).set_Text("Profiles");
		((ToolStripItem)saveToAProfileToolStripMenuItem).set_Name("saveToAProfileToolStripMenuItem");
		((ToolStripItem)saveToAProfileToolStripMenuItem).set_Size(new Size(177, 22));
		((ToolStripItem)saveToAProfileToolStripMenuItem).set_Text("Export as a profile...");
		((ToolStripItem)saveToAProfileToolStripMenuItem).add_Click((EventHandler)saveToAProfileToolStripMenuItem_Click);
		((ToolStripItem)toolStripMenuItem5).set_Name("toolStripMenuItem5");
		((ToolStripItem)toolStripMenuItem5).set_Size(new Size(174, 6));
		((ToolStripItem)aboutToolStripMenuItem).set_DisplayStyle((ToolStripItemDisplayStyle)1);
		((ToolStripDropDownItem)aboutToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)helpToolStripMenuItem,
			(ToolStripItem)toolStripMenuItem2,
			(ToolStripItem)aboutSandboxToolStripMenuItem
		});
		((ToolStripItem)aboutToolStripMenuItem).set_Name("aboutToolStripMenuItem");
		((ToolStripItem)aboutToolStripMenuItem).set_Size(new Size(52, 20));
		((ToolStripItem)aboutToolStripMenuItem).set_Text("About");
		((ToolStripItem)helpToolStripMenuItem).set_Name("helpToolStripMenuItem");
		helpToolStripMenuItem.set_ShortcutKeys((Keys)131144);
		((ToolStripItem)helpToolStripMenuItem).set_Size(new Size(142, 22));
		((ToolStripItem)helpToolStripMenuItem).set_Text("Help");
		((ToolStripItem)helpToolStripMenuItem).add_Click((EventHandler)aboutSandboxToolStripMenuItem_Click);
		((ToolStripItem)toolStripMenuItem2).set_Name("toolStripMenuItem2");
		((ToolStripItem)toolStripMenuItem2).set_Size(new Size(139, 6));
		((ToolStripItem)aboutSandboxToolStripMenuItem).set_Name("aboutSandboxToolStripMenuItem");
		((ToolStripItem)aboutSandboxToolStripMenuItem).set_Size(new Size(142, 22));
		((ToolStripItem)aboutSandboxToolStripMenuItem).set_Text("About SbDN");
		((ToolStripItem)aboutSandboxToolStripMenuItem).add_Click((EventHandler)aboutSandboxToolStripMenuItem_Click);
		((ToolStripDropDownItem)developerToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)devConsoleToolStripMenuItem });
		((ToolStripItem)developerToolStripMenuItem).set_Name("developerToolStripMenuItem");
		((ToolStripItem)developerToolStripMenuItem).set_Size(new Size(72, 20));
		((ToolStripItem)developerToolStripMenuItem).set_Text("Developer");
		((ToolStripItem)developerToolStripMenuItem).set_Visible(false);
		((ToolStripItem)devConsoleToolStripMenuItem).set_Name("devConsoleToolStripMenuItem");
		((ToolStripItem)devConsoleToolStripMenuItem).set_Size(new Size(117, 22));
		((ToolStripItem)devConsoleToolStripMenuItem).set_Text("Console");
		((ToolStripItem)devConsoleToolStripMenuItem).add_Click((EventHandler)devConsoleToolStripMenuItem_Click);
		((Control)runSandbox).set_Dock((DockStyle)2);
		((Control)runSandbox).set_Location(new Point(0, 418));
		((Control)runSandbox).set_Name("runSandbox");
		((Control)runSandbox).set_Size(new Size(559, 43));
		((Control)runSandbox).set_TabIndex(5);
		((Control)runSandbox).set_Text("Run");
		toolTip.SetToolTip((Control)(object)runSandbox, "Run the target program in a sandbox");
		((ButtonBase)runSandbox).set_UseVisualStyleBackColor(true);
		((Control)runSandbox).add_Click((EventHandler)runSandbox_Click);
		((FileDialog)openFileDialog).set_Filter("Executable files|*.exe");
		((FileDialog)openFileDialog).set_Title("Select the file to run in a sandbox");
		((Control)titlePanel).get_Controls().Add((Control)(object)title);
		((Control)titlePanel).set_Dock((DockStyle)1);
		((Control)titlePanel).set_Location(new Point(0, 24));
		((Control)titlePanel).set_Name("titlePanel");
		((Control)titlePanel).set_Size(new Size(559, 48));
		((Control)titlePanel).set_TabIndex(8);
		((Control)title).set_Dock((DockStyle)5);
		((Control)title).set_Font(new Font("Microsoft Sans Serif", 14f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)title).set_Location(new Point(0, 0));
		((Control)title).set_Name("title");
		((Control)title).set_Padding(new Padding(5));
		((Control)title).set_Size(new Size(559, 48));
		((Control)title).set_TabIndex(0);
		((Control)title).set_Text("(No Program Selected)");
		title.set_TextAlign((ContentAlignment)32);
		((Control)title).add_Click((EventHandler)title_Click);
		((Control)permissionsTabControl).get_Controls().Add((Control)(object)locMachinePermsTab);
		((Control)permissionsTabControl).get_Controls().Add((Control)(object)fileIoPermsTab);
		((Control)permissionsTabControl).get_Controls().Add((Control)(object)securityPermsTab);
		((Control)permissionsTabControl).get_Controls().Add((Control)(object)refPermsTab);
		((Control)permissionsTabControl).get_Controls().Add((Control)(object)netPermsTab);
		((Control)permissionsTabControl).get_Controls().Add((Control)(object)otherPermsTab);
		((Control)permissionsTabControl).set_Dock((DockStyle)5);
		((Control)permissionsTabControl).set_Location(new Point(3, 3));
		((Control)permissionsTabControl).set_Name("permissionsTabControl");
		permissionsTabControl.set_SelectedIndex(0);
		((Control)permissionsTabControl).set_Size(new Size(545, 314));
		((Control)permissionsTabControl).set_TabIndex(0);
		toolTip.SetToolTip((Control)(object)permissionsTabControl, "Control the permissions for the sandboxed application will have");
		((Control)locMachinePermsTab).get_Controls().Add((Control)(object)localPermsTable);
		locMachinePermsTab.set_Location(new Point(4, 22));
		((Control)locMachinePermsTab).set_Name("locMachinePermsTab");
		((Control)locMachinePermsTab).set_Size(new Size(537, 288));
		locMachinePermsTab.set_TabIndex(3);
		((Control)locMachinePermsTab).set_Text("Local");
		locMachinePermsTab.set_UseVisualStyleBackColor(true);
		localPermsTable.set_ColumnCount(3);
		localPermsTable.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 33.33333f));
		localPermsTable.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 33.33333f));
		localPermsTable.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 33.33333f));
		localPermsTable.get_Controls().Add((Control)(object)ioPerm, 0, 0);
		localPermsTable.get_Controls().Add((Control)(object)uiPerm, 0, 1);
		localPermsTable.get_Controls().Add((Control)(object)printPerm, 1, 0);
		localPermsTable.get_Controls().Add((Control)(object)fileDialogPerm, 1, 2);
		localPermsTable.get_Controls().Add((Control)(object)princePerm, 2, 0);
		localPermsTable.get_Controls().Add((Control)(object)eventLogPerm, 1, 1);
		localPermsTable.get_Controls().Add((Control)(object)perfPerm, 2, 1);
		localPermsTable.get_Controls().Add((Control)(object)regPerm, 0, 2);
		((Control)localPermsTable).set_Dock((DockStyle)5);
		((Control)localPermsTable).set_Location(new Point(0, 0));
		((Control)localPermsTable).set_Name("localPermsTable");
		localPermsTable.set_RowCount(7);
		localPermsTable.get_RowStyles().Add(new RowStyle((SizeType)1, 40f));
		localPermsTable.get_RowStyles().Add(new RowStyle((SizeType)1, 40f));
		localPermsTable.get_RowStyles().Add(new RowStyle((SizeType)1, 40f));
		localPermsTable.get_RowStyles().Add(new RowStyle((SizeType)1, 40f));
		localPermsTable.get_RowStyles().Add(new RowStyle((SizeType)1, 40f));
		localPermsTable.get_RowStyles().Add(new RowStyle((SizeType)1, 40f));
		localPermsTable.get_RowStyles().Add(new RowStyle((SizeType)1, 20f));
		((Control)localPermsTable).set_Size(new Size(537, 288));
		((Control)localPermsTable).set_TabIndex(0);
		((Control)ioPerm).set_AutoSize(true);
		((Control)ioPerm).set_Dock((DockStyle)5);
		((Control)ioPerm).set_Enabled(false);
		((Control)ioPerm).set_Location(new Point(3, 3));
		((Control)ioPerm).set_Name("ioPerm");
		((Control)ioPerm).set_Size(new Size(173, 34));
		((Control)ioPerm).set_TabIndex(3);
		((Control)ioPerm).set_Text("Executable File I/O");
		toolTip.SetToolTip((Control)(object)ioPerm, "Executable File I/O permission is required to run the desired program in the sandbox\r\n");
		((ButtonBase)ioPerm).set_UseVisualStyleBackColor(true);
		((Control)uiPerm).set_AutoSize(true);
		((Control)uiPerm).set_Dock((DockStyle)5);
		((Control)uiPerm).set_Enabled(false);
		((Control)uiPerm).set_Location(new Point(3, 43));
		((Control)uiPerm).set_Name("uiPerm");
		((Control)uiPerm).set_Size(new Size(173, 34));
		((Control)uiPerm).set_TabIndex(4);
		((Control)uiPerm).set_Text("User Interface");
		toolTip.SetToolTip((Control)(object)uiPerm, "User Interface permission is required to run the desired program in the sandbox\r\n\r\n");
		((ButtonBase)uiPerm).set_UseVisualStyleBackColor(true);
		((Control)printPerm).set_AutoSize(true);
		((Control)printPerm).set_Dock((DockStyle)5);
		((Control)printPerm).set_Location(new Point(182, 3));
		((Control)printPerm).set_Name("printPerm");
		((Control)printPerm).set_Size(new Size(173, 34));
		((Control)printPerm).set_TabIndex(26);
		((Control)printPerm).set_Text("Printing");
		toolTip.SetToolTip((Control)(object)printPerm, "Grant Printing permission");
		((ButtonBase)printPerm).set_UseVisualStyleBackColor(true);
		((Control)fileDialogPerm).set_AutoSize(true);
		((Control)fileDialogPerm).set_Dock((DockStyle)5);
		((Control)fileDialogPerm).set_Location(new Point(182, 83));
		((Control)fileDialogPerm).set_Name("fileDialogPerm");
		((Control)fileDialogPerm).set_Size(new Size(173, 34));
		((Control)fileDialogPerm).set_TabIndex(23);
		((Control)fileDialogPerm).set_Text("File Dialog");
		toolTip.SetToolTip((Control)(object)fileDialogPerm, "Grant FileDialog permission");
		((ButtonBase)fileDialogPerm).set_UseVisualStyleBackColor(true);
		((Control)princePerm).set_AutoSize(true);
		((Control)princePerm).set_Dock((DockStyle)5);
		((Control)princePerm).set_Location(new Point(361, 3));
		((Control)princePerm).set_Name("princePerm");
		((Control)princePerm).set_Size(new Size(173, 34));
		((Control)princePerm).set_TabIndex(25);
		((Control)princePerm).set_Text("Principal");
		toolTip.SetToolTip((Control)(object)princePerm, "Grant Principal permission");
		((ButtonBase)princePerm).set_UseVisualStyleBackColor(true);
		((Control)eventLogPerm).set_AutoSize(true);
		((Control)eventLogPerm).set_Dock((DockStyle)5);
		((Control)eventLogPerm).set_Location(new Point(182, 43));
		((Control)eventLogPerm).set_Name("eventLogPerm");
		((Control)eventLogPerm).set_Size(new Size(173, 34));
		((Control)eventLogPerm).set_TabIndex(22);
		((Control)eventLogPerm).set_Text("Event Log");
		toolTip.SetToolTip((Control)(object)eventLogPerm, "Grant EventLog permission");
		((ButtonBase)eventLogPerm).set_UseVisualStyleBackColor(true);
		((Control)perfPerm).set_AutoSize(true);
		((Control)perfPerm).set_Dock((DockStyle)5);
		((Control)perfPerm).set_Location(new Point(361, 43));
		((Control)perfPerm).set_Name("perfPerm");
		((Control)perfPerm).set_Size(new Size(173, 34));
		((Control)perfPerm).set_TabIndex(24);
		((Control)perfPerm).set_Text("Perf. Counter");
		toolTip.SetToolTip((Control)(object)perfPerm, "Grant PerformanceCounter permission");
		((ButtonBase)perfPerm).set_UseVisualStyleBackColor(true);
		((Control)regPerm).set_AutoSize(true);
		((Control)regPerm).set_Dock((DockStyle)5);
		((Control)regPerm).set_Location(new Point(3, 83));
		((Control)regPerm).set_Name("regPerm");
		((Control)regPerm).set_Size(new Size(173, 34));
		((Control)regPerm).set_TabIndex(28);
		((Control)regPerm).set_Text("Registry");
		toolTip.SetToolTip((Control)(object)regPerm, "Grant Registry permission");
		((ButtonBase)regPerm).set_UseVisualStyleBackColor(true);
		((Control)fileIoPermsTab).get_Controls().Add((Control)(object)fileIoTableLayoutPanel);
		fileIoPermsTab.set_Location(new Point(4, 22));
		((Control)fileIoPermsTab).set_Name("fileIoPermsTab");
		((Control)fileIoPermsTab).set_Size(new Size(537, 288));
		fileIoPermsTab.set_TabIndex(0);
		((Control)fileIoPermsTab).set_Text("File I/O");
		fileIoPermsTab.set_UseVisualStyleBackColor(true);
		fileIoTableLayoutPanel.set_ColumnCount(1);
		fileIoTableLayoutPanel.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 100f));
		fileIoTableLayoutPanel.get_Controls().Add((Control)(object)fileIoFolderButtonTableLayoutPanel, 0, 3);
		fileIoTableLayoutPanel.get_Controls().Add((Control)(object)fileIoPermsTabPanel, 0, 0);
		fileIoTableLayoutPanel.get_Controls().Add((Control)(object)fileIoFileButtonTableLayoutPanel, 0, 2);
		fileIoTableLayoutPanel.get_Controls().Add((Control)(object)tableLayoutPanel2, 0, 1);
		((Control)fileIoTableLayoutPanel).set_Dock((DockStyle)5);
		((Control)fileIoTableLayoutPanel).set_Location(new Point(0, 0));
		((Control)fileIoTableLayoutPanel).set_Margin(new Padding(0));
		((Control)fileIoTableLayoutPanel).set_Name("fileIoTableLayoutPanel");
		fileIoTableLayoutPanel.set_RowCount(4);
		fileIoTableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		fileIoTableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)1, 30f));
		fileIoTableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)1, 30f));
		fileIoTableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)1, 30f));
		((Control)fileIoTableLayoutPanel).set_Size(new Size(537, 288));
		((Control)fileIoTableLayoutPanel).set_TabIndex(1);
		fileIoFolderButtonTableLayoutPanel.set_ColumnCount(3);
		fileIoFolderButtonTableLayoutPanel.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 33.33333f));
		fileIoFolderButtonTableLayoutPanel.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 33.33333f));
		fileIoFolderButtonTableLayoutPanel.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 33.33333f));
		fileIoFolderButtonTableLayoutPanel.get_Controls().Add((Control)(object)addFolderAppendButton, 2, 0);
		fileIoFolderButtonTableLayoutPanel.get_Controls().Add((Control)(object)addFolderWriteButton, 0, 0);
		fileIoFolderButtonTableLayoutPanel.get_Controls().Add((Control)(object)addFolderReadButton, 1, 0);
		((Control)fileIoFolderButtonTableLayoutPanel).set_Dock((DockStyle)5);
		((Control)fileIoFolderButtonTableLayoutPanel).set_Location(new Point(0, 258));
		((Control)fileIoFolderButtonTableLayoutPanel).set_Margin(new Padding(0));
		((Control)fileIoFolderButtonTableLayoutPanel).set_Name("fileIoFolderButtonTableLayoutPanel");
		fileIoFolderButtonTableLayoutPanel.set_RowCount(1);
		fileIoFolderButtonTableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		((Control)fileIoFolderButtonTableLayoutPanel).set_Size(new Size(537, 30));
		((Control)fileIoFolderButtonTableLayoutPanel).set_TabIndex(3);
		((Control)addFolderAppendButton).set_AutoSize(true);
		((Control)addFolderAppendButton).set_Dock((DockStyle)5);
		((Control)addFolderAppendButton).set_Location(new Point(361, 3));
		((Control)addFolderAppendButton).set_Name("addFolderAppendButton");
		((Control)addFolderAppendButton).set_Size(new Size(173, 24));
		((Control)addFolderAppendButton).set_TabIndex(2);
		((Control)addFolderAppendButton).set_Text("Folder with Append Permissions");
		toolTip.SetToolTip((Control)(object)addFolderAppendButton, "Add folders that the sandboxed application will have permissions to see and append to");
		((ButtonBase)addFolderAppendButton).set_UseVisualStyleBackColor(true);
		((Control)addFolderAppendButton).add_Click((EventHandler)addFolderAppendButton_Click);
		((Control)addFolderWriteButton).set_AutoSize(true);
		((Control)addFolderWriteButton).set_Dock((DockStyle)5);
		((Control)addFolderWriteButton).set_Location(new Point(3, 3));
		((Control)addFolderWriteButton).set_Name("addFolderWriteButton");
		((Control)addFolderWriteButton).set_Size(new Size(173, 24));
		((Control)addFolderWriteButton).set_TabIndex(0);
		((Control)addFolderWriteButton).set_Text("Folder with Write Permissions");
		toolTip.SetToolTip((Control)(object)addFolderWriteButton, "Add folders that the sandboxed application will have permissions to see, read, and write to\r\n");
		((ButtonBase)addFolderWriteButton).set_UseVisualStyleBackColor(true);
		((Control)addFolderWriteButton).add_Click((EventHandler)addFolderWriteButton_Click);
		((Control)addFolderReadButton).set_AutoSize(true);
		((Control)addFolderReadButton).set_Dock((DockStyle)5);
		((Control)addFolderReadButton).set_Location(new Point(182, 3));
		((Control)addFolderReadButton).set_Name("addFolderReadButton");
		((Control)addFolderReadButton).set_Size(new Size(173, 24));
		((Control)addFolderReadButton).set_TabIndex(1);
		((Control)addFolderReadButton).set_Text("Folder with Read Permissions");
		toolTip.SetToolTip((Control)(object)addFolderReadButton, "Add folders that the sandboxed application will have permissions to see and read\r\n\r\n");
		((ButtonBase)addFolderReadButton).set_UseVisualStyleBackColor(true);
		((Control)addFolderReadButton).add_Click((EventHandler)addFolderReadButton_Click);
		((Control)fileIoPermsTabPanel).get_Controls().Add((Control)(object)listOfAllFilesTable);
		((Control)fileIoPermsTabPanel).set_Dock((DockStyle)5);
		((Control)fileIoPermsTabPanel).set_Location(new Point(3, 3));
		((Control)fileIoPermsTabPanel).set_Name("fileIoPermsTabPanel");
		((Control)fileIoPermsTabPanel).set_Size(new Size(531, 192));
		((Control)fileIoPermsTabPanel).set_TabIndex(0);
		((ScrollableControl)listOfAllFilesTable).set_AutoScroll(true);
		listOfAllFilesTable.set_ColumnCount(1);
		listOfAllFilesTable.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 100f));
		((Control)listOfAllFilesTable).set_Dock((DockStyle)5);
		((Control)listOfAllFilesTable).set_Location(new Point(0, 0));
		((Control)listOfAllFilesTable).set_Margin(new Padding(0));
		((Control)listOfAllFilesTable).set_Name("listOfAllFilesTable");
		listOfAllFilesTable.set_RowCount(1);
		listOfAllFilesTable.get_RowStyles().Add(new RowStyle((SizeType)1, 192f));
		((Control)listOfAllFilesTable).set_Size(new Size(531, 192));
		((Control)listOfAllFilesTable).set_TabIndex(0);
		fileIoFileButtonTableLayoutPanel.set_ColumnCount(3);
		fileIoFileButtonTableLayoutPanel.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 33.33333f));
		fileIoFileButtonTableLayoutPanel.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 33.33333f));
		fileIoFileButtonTableLayoutPanel.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 33.33333f));
		fileIoFileButtonTableLayoutPanel.get_Controls().Add((Control)(object)addFilesAppendButton, 2, 0);
		fileIoFileButtonTableLayoutPanel.get_Controls().Add((Control)(object)addFilesWriteButton, 0, 0);
		fileIoFileButtonTableLayoutPanel.get_Controls().Add((Control)(object)addFilesReadButton, 1, 0);
		((Control)fileIoFileButtonTableLayoutPanel).set_Dock((DockStyle)5);
		((Control)fileIoFileButtonTableLayoutPanel).set_Location(new Point(0, 228));
		((Control)fileIoFileButtonTableLayoutPanel).set_Margin(new Padding(0));
		((Control)fileIoFileButtonTableLayoutPanel).set_Name("fileIoFileButtonTableLayoutPanel");
		fileIoFileButtonTableLayoutPanel.set_RowCount(1);
		fileIoFileButtonTableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		((Control)fileIoFileButtonTableLayoutPanel).set_Size(new Size(537, 30));
		((Control)fileIoFileButtonTableLayoutPanel).set_TabIndex(1);
		((Control)addFilesAppendButton).set_AutoSize(true);
		((Control)addFilesAppendButton).set_Dock((DockStyle)5);
		((Control)addFilesAppendButton).set_Location(new Point(361, 3));
		((Control)addFilesAppendButton).set_Name("addFilesAppendButton");
		((Control)addFilesAppendButton).set_Size(new Size(173, 24));
		((Control)addFilesAppendButton).set_TabIndex(2);
		((Control)addFilesAppendButton).set_Text("File with Append Permissions");
		toolTip.SetToolTip((Control)(object)addFilesAppendButton, "Add files that the sandboxed application will have permissions to see and append to\r\n\r\n");
		((ButtonBase)addFilesAppendButton).set_UseVisualStyleBackColor(true);
		((Control)addFilesAppendButton).add_Click((EventHandler)addFilesAppendButton_Click);
		((Control)addFilesWriteButton).set_AutoSize(true);
		((Control)addFilesWriteButton).set_Dock((DockStyle)5);
		((Control)addFilesWriteButton).set_Location(new Point(3, 3));
		((Control)addFilesWriteButton).set_Name("addFilesWriteButton");
		((Control)addFilesWriteButton).set_Size(new Size(173, 24));
		((Control)addFilesWriteButton).set_TabIndex(0);
		((Control)addFilesWriteButton).set_Text("File with Write Permissions");
		toolTip.SetToolTip((Control)(object)addFilesWriteButton, "Add files that the sandboxed application will have permissions to see, read, and write to");
		((ButtonBase)addFilesWriteButton).set_UseVisualStyleBackColor(true);
		((Control)addFilesWriteButton).add_Click((EventHandler)addFilesWriteButton_Click);
		((Control)addFilesReadButton).set_AutoSize(true);
		((Control)addFilesReadButton).set_Dock((DockStyle)5);
		((Control)addFilesReadButton).set_Location(new Point(182, 3));
		((Control)addFilesReadButton).set_Name("addFilesReadButton");
		((Control)addFilesReadButton).set_Size(new Size(173, 24));
		((Control)addFilesReadButton).set_TabIndex(1);
		((Control)addFilesReadButton).set_Text("File with Read Permissions");
		toolTip.SetToolTip((Control)(object)addFilesReadButton, "Add files that the sandboxed application will have permissions to see and read\r\n");
		((ButtonBase)addFilesReadButton).set_UseVisualStyleBackColor(true);
		((Control)addFilesReadButton).add_Click((EventHandler)addFilesReadButton_Click);
		tableLayoutPanel2.set_ColumnCount(2);
		tableLayoutPanel2.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 50f));
		tableLayoutPanel2.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 50f));
		tableLayoutPanel2.get_Controls().Add((Control)(object)allFilesPerm, 0, 0);
		tableLayoutPanel2.get_Controls().Add((Control)(object)clearFileIOListButton, 1, 0);
		((Control)tableLayoutPanel2).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel2).set_Location(new Point(0, 198));
		((Control)tableLayoutPanel2).set_Margin(new Padding(0));
		((Control)tableLayoutPanel2).set_Name("tableLayoutPanel2");
		tableLayoutPanel2.set_RowCount(1);
		tableLayoutPanel2.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		((Control)tableLayoutPanel2).set_Size(new Size(537, 30));
		((Control)tableLayoutPanel2).set_TabIndex(4);
		((Control)allFilesPerm).set_AutoSize(true);
		((Control)allFilesPerm).set_Dock((DockStyle)5);
		((Control)allFilesPerm).set_Location(new Point(3, 3));
		((Control)allFilesPerm).set_Name("allFilesPerm");
		((Control)allFilesPerm).set_Padding(new Padding(1, 0, 0, 0));
		((Control)allFilesPerm).set_Size(new Size(262, 24));
		((Control)allFilesPerm).set_TabIndex(0);
		((Control)allFilesPerm).set_Text("Allow access to entire filesystem");
		toolTip.SetToolTip((Control)(object)allFilesPerm, "Allow the sandboxed application entire access to the filesystem");
		((ButtonBase)allFilesPerm).set_UseVisualStyleBackColor(true);
		((Control)clearFileIOListButton).set_Dock((DockStyle)5);
		((Control)clearFileIOListButton).set_Location(new Point(271, 3));
		((Control)clearFileIOListButton).set_Name("clearFileIOListButton");
		((Control)clearFileIOListButton).set_Size(new Size(263, 24));
		((Control)clearFileIOListButton).set_TabIndex(1);
		((Control)clearFileIOListButton).set_Text("Clear File List");
		toolTip.SetToolTip((Control)(object)clearFileIOListButton, "Clear all files/folders from the File I/O list");
		((ButtonBase)clearFileIOListButton).set_UseVisualStyleBackColor(true);
		((Control)clearFileIOListButton).add_Click((EventHandler)clearFileIOListButton_Click);
		((Control)securityPermsTab).get_Controls().Add((Control)(object)secPermsTable);
		securityPermsTab.set_Location(new Point(4, 22));
		((Control)securityPermsTab).set_Name("securityPermsTab");
		((Control)securityPermsTab).set_Padding(new Padding(3));
		((Control)securityPermsTab).set_Size(new Size(537, 288));
		securityPermsTab.set_TabIndex(1);
		((Control)securityPermsTab).set_Text("Security");
		securityPermsTab.set_UseVisualStyleBackColor(true);
		secPermsTable.set_ColumnCount(3);
		secPermsTable.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 33.33333f));
		secPermsTable.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 33.33334f));
		secPermsTable.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 33.33334f));
		secPermsTable.get_Controls().Add((Control)(object)executionPerm, 0, 0);
		secPermsTable.get_Controls().Add((Control)(object)assertPerm, 1, 0);
		secPermsTable.get_Controls().Add((Control)(object)bindRedirectPerm, 2, 0);
		secPermsTable.get_Controls().Add((Control)(object)controlAppDomainPerm, 0, 1);
		secPermsTable.get_Controls().Add((Control)(object)controlDomainPolicyPerm, 1, 1);
		secPermsTable.get_Controls().Add((Control)(object)controlEvidencePerm, 2, 1);
		secPermsTable.get_Controls().Add((Control)(object)controlPolicy, 0, 2);
		secPermsTable.get_Controls().Add((Control)(object)controlPrincipalPerm, 1, 2);
		secPermsTable.get_Controls().Add((Control)(object)controlThreadPerm, 2, 2);
		secPermsTable.get_Controls().Add((Control)(object)infrastructurePerm, 0, 3);
		secPermsTable.get_Controls().Add((Control)(object)remotingConfigurationPerm, 1, 3);
		secPermsTable.get_Controls().Add((Control)(object)serializationFormatterPerm, 2, 3);
		secPermsTable.get_Controls().Add((Control)(object)skipVerificationPerm, 0, 4);
		secPermsTable.get_Controls().Add((Control)(object)unmanagedCode, 1, 4);
		((Control)secPermsTable).set_Dock((DockStyle)5);
		((Control)secPermsTable).set_Location(new Point(3, 3));
		((Control)secPermsTable).set_Name("secPermsTable");
		secPermsTable.set_RowCount(7);
		secPermsTable.get_RowStyles().Add(new RowStyle((SizeType)1, 40f));
		secPermsTable.get_RowStyles().Add(new RowStyle((SizeType)1, 40f));
		secPermsTable.get_RowStyles().Add(new RowStyle((SizeType)1, 40f));
		secPermsTable.get_RowStyles().Add(new RowStyle((SizeType)1, 40f));
		secPermsTable.get_RowStyles().Add(new RowStyle((SizeType)1, 40f));
		secPermsTable.get_RowStyles().Add(new RowStyle((SizeType)1, 40f));
		secPermsTable.get_RowStyles().Add(new RowStyle((SizeType)1, 20f));
		((Control)secPermsTable).set_Size(new Size(531, 282));
		((Control)secPermsTable).set_TabIndex(0);
		((Control)executionPerm).set_AutoSize(true);
		((Control)executionPerm).set_Dock((DockStyle)5);
		((Control)executionPerm).set_Enabled(false);
		((Control)executionPerm).set_Location(new Point(3, 3));
		((Control)executionPerm).set_Name("executionPerm");
		((Control)executionPerm).set_Size(new Size(170, 34));
		((Control)executionPerm).set_TabIndex(3);
		((Control)executionPerm).set_Text("Execution");
		toolTip.SetToolTip((Control)(object)executionPerm, "Execution permission is required to run the desired program in the sandbox");
		((ButtonBase)executionPerm).set_UseVisualStyleBackColor(true);
		((Control)assertPerm).set_AutoSize(true);
		((Control)assertPerm).set_Dock((DockStyle)5);
		((Control)assertPerm).set_Location(new Point(179, 3));
		((Control)assertPerm).set_Name("assertPerm");
		((Control)assertPerm).set_Size(new Size(171, 34));
		((Control)assertPerm).set_TabIndex(4);
		((Control)assertPerm).set_Text("Assertion");
		toolTip.SetToolTip((Control)(object)assertPerm, "Ability to assert that all this code's callers have the requisite permission for the operation");
		((ButtonBase)assertPerm).set_UseVisualStyleBackColor(true);
		((Control)bindRedirectPerm).set_AutoSize(true);
		((Control)bindRedirectPerm).set_Dock((DockStyle)5);
		((Control)bindRedirectPerm).set_Location(new Point(356, 3));
		((Control)bindRedirectPerm).set_Name("bindRedirectPerm");
		((Control)bindRedirectPerm).set_Size(new Size(172, 34));
		((Control)bindRedirectPerm).set_TabIndex(5);
		((Control)bindRedirectPerm).set_Text("Binding Redirects");
		toolTip.SetToolTip((Control)(object)bindRedirectPerm, componentResourceManager.GetString("bindRedirectPerm.ToolTip"));
		((ButtonBase)bindRedirectPerm).set_UseVisualStyleBackColor(true);
		((Control)controlAppDomainPerm).set_AutoSize(true);
		((Control)controlAppDomainPerm).set_Dock((DockStyle)5);
		((Control)controlAppDomainPerm).set_Location(new Point(3, 43));
		((Control)controlAppDomainPerm).set_Name("controlAppDomainPerm");
		((Control)controlAppDomainPerm).set_Size(new Size(170, 34));
		((Control)controlAppDomainPerm).set_TabIndex(7);
		((Control)controlAppDomainPerm).set_Text("Control App Domain");
		toolTip.SetToolTip((Control)(object)controlAppDomainPerm, "Ability to create and manipulate an AppDomain");
		((ButtonBase)controlAppDomainPerm).set_UseVisualStyleBackColor(true);
		((Control)controlDomainPolicyPerm).set_AutoSize(true);
		((Control)controlDomainPolicyPerm).set_Dock((DockStyle)5);
		((Control)controlDomainPolicyPerm).set_Location(new Point(179, 43));
		((Control)controlDomainPolicyPerm).set_Name("controlDomainPolicyPerm");
		((Control)controlDomainPolicyPerm).set_Size(new Size(171, 34));
		((Control)controlDomainPolicyPerm).set_TabIndex(8);
		((Control)controlDomainPolicyPerm).set_Text("Control Domain Policy");
		toolTip.SetToolTip((Control)(object)controlDomainPolicyPerm, "Ability to specify domain policy.");
		((ButtonBase)controlDomainPolicyPerm).set_UseVisualStyleBackColor(true);
		((Control)controlEvidencePerm).set_AutoSize(true);
		((Control)controlEvidencePerm).set_Dock((DockStyle)5);
		((Control)controlEvidencePerm).set_Location(new Point(356, 43));
		((Control)controlEvidencePerm).set_Name("controlEvidencePerm");
		((Control)controlEvidencePerm).set_Size(new Size(172, 34));
		((Control)controlEvidencePerm).set_TabIndex(6);
		((Control)controlEvidencePerm).set_Text("Control Evidence");
		toolTip.SetToolTip((Control)(object)controlEvidencePerm, "Ability to provide evidence, including the ability to alter the evidence provided by the common language runtime");
		((ButtonBase)controlEvidencePerm).set_UseVisualStyleBackColor(true);
		((Control)controlPolicy).set_AutoSize(true);
		((Control)controlPolicy).set_Dock((DockStyle)5);
		((Control)controlPolicy).set_Location(new Point(3, 83));
		((Control)controlPolicy).set_Name("controlPolicy");
		((Control)controlPolicy).set_Size(new Size(170, 34));
		((Control)controlPolicy).set_TabIndex(9);
		((Control)controlPolicy).set_Text("Control Policy");
		toolTip.SetToolTip((Control)(object)controlPolicy, "Ability to view and modify policy");
		((ButtonBase)controlPolicy).set_UseVisualStyleBackColor(true);
		((Control)controlPrincipalPerm).set_AutoSize(true);
		((Control)controlPrincipalPerm).set_Dock((DockStyle)5);
		((Control)controlPrincipalPerm).set_Location(new Point(179, 83));
		((Control)controlPrincipalPerm).set_Name("controlPrincipalPerm");
		((Control)controlPrincipalPerm).set_Size(new Size(171, 34));
		((Control)controlPrincipalPerm).set_TabIndex(10);
		((Control)controlPrincipalPerm).set_Text("Control Principal");
		toolTip.SetToolTip((Control)(object)controlPrincipalPerm, "Ability to manipulate the principal object");
		((ButtonBase)controlPrincipalPerm).set_UseVisualStyleBackColor(true);
		((Control)controlThreadPerm).set_AutoSize(true);
		((Control)controlThreadPerm).set_Dock((DockStyle)5);
		((Control)controlThreadPerm).set_Location(new Point(356, 83));
		((Control)controlThreadPerm).set_Name("controlThreadPerm");
		((Control)controlThreadPerm).set_Size(new Size(172, 34));
		((Control)controlThreadPerm).set_TabIndex(11);
		((Control)controlThreadPerm).set_Text("Control Thread");
		toolTip.SetToolTip((Control)(object)controlThreadPerm, "Ability to use certain advanced operations on threads");
		((ButtonBase)controlThreadPerm).set_UseVisualStyleBackColor(true);
		((Control)infrastructurePerm).set_AutoSize(true);
		((Control)infrastructurePerm).set_Dock((DockStyle)5);
		((Control)infrastructurePerm).set_Location(new Point(3, 123));
		((Control)infrastructurePerm).set_Name("infrastructurePerm");
		((Control)infrastructurePerm).set_Size(new Size(170, 34));
		((Control)infrastructurePerm).set_TabIndex(12);
		((Control)infrastructurePerm).set_Text("Infrastructure");
		toolTip.SetToolTip((Control)(object)infrastructurePerm, "Permission to plug code into the common language runtime infrastructure, such as adding Remoting Context Sinks, Envoy Sinks and Dynamic Sinks");
		((ButtonBase)infrastructurePerm).set_UseVisualStyleBackColor(true);
		((Control)remotingConfigurationPerm).set_AutoSize(true);
		((Control)remotingConfigurationPerm).set_Dock((DockStyle)5);
		((Control)remotingConfigurationPerm).set_Location(new Point(179, 123));
		((Control)remotingConfigurationPerm).set_Name("remotingConfigurationPerm");
		((Control)remotingConfigurationPerm).set_Size(new Size(171, 34));
		((Control)remotingConfigurationPerm).set_TabIndex(13);
		((Control)remotingConfigurationPerm).set_Text("Remoting Configuration");
		toolTip.SetToolTip((Control)(object)remotingConfigurationPerm, "Permission to configure Remoting types and channels");
		((ButtonBase)remotingConfigurationPerm).set_UseVisualStyleBackColor(true);
		((Control)serializationFormatterPerm).set_AutoSize(true);
		((Control)serializationFormatterPerm).set_Dock((DockStyle)5);
		((Control)serializationFormatterPerm).set_Location(new Point(356, 123));
		((Control)serializationFormatterPerm).set_Name("serializationFormatterPerm");
		((Control)serializationFormatterPerm).set_Size(new Size(172, 34));
		((Control)serializationFormatterPerm).set_TabIndex(14);
		((Control)serializationFormatterPerm).set_Text("Serialization Formatter");
		toolTip.SetToolTip((Control)(object)serializationFormatterPerm, "Ability to provide serialization services. Used by serialization formatters");
		((ButtonBase)serializationFormatterPerm).set_UseVisualStyleBackColor(true);
		((Control)skipVerificationPerm).set_AutoSize(true);
		((Control)skipVerificationPerm).set_Dock((DockStyle)5);
		((Control)skipVerificationPerm).set_Location(new Point(3, 163));
		((Control)skipVerificationPerm).set_Name("skipVerificationPerm");
		((Control)skipVerificationPerm).set_Size(new Size(170, 34));
		((Control)skipVerificationPerm).set_TabIndex(15);
		((Control)skipVerificationPerm).set_Text("Skip Verification");
		toolTip.SetToolTip((Control)(object)skipVerificationPerm, "Ability to skip verification of code in this assembly. Code that is unverifiable can be run if this permission is granted");
		((ButtonBase)skipVerificationPerm).set_UseVisualStyleBackColor(true);
		((Control)unmanagedCode).set_AutoSize(true);
		((Control)unmanagedCode).set_Dock((DockStyle)5);
		((Control)unmanagedCode).set_Location(new Point(179, 163));
		((Control)unmanagedCode).set_Name("unmanagedCode");
		((Control)unmanagedCode).set_Size(new Size(171, 34));
		((Control)unmanagedCode).set_TabIndex(16);
		((Control)unmanagedCode).set_Text("Unmanaged Code");
		toolTip.SetToolTip((Control)(object)unmanagedCode, "Ability to call unmanaged code");
		((ButtonBase)unmanagedCode).set_UseVisualStyleBackColor(true);
		((Control)refPermsTab).get_Controls().Add((Control)(object)refPermsTable);
		refPermsTab.set_Location(new Point(4, 22));
		((Control)refPermsTab).set_Name("refPermsTab");
		((Control)refPermsTab).set_Padding(new Padding(3));
		((Control)refPermsTab).set_Size(new Size(537, 288));
		refPermsTab.set_TabIndex(5);
		((Control)refPermsTab).set_Text("Reflection");
		refPermsTab.set_UseVisualStyleBackColor(true);
		refPermsTable.set_ColumnCount(3);
		refPermsTable.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 25f));
		refPermsTable.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 25f));
		refPermsTable.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 25f));
		refPermsTable.get_Controls().Add((Control)(object)gacPerm, 0, 0);
		refPermsTable.get_Controls().Add((Control)(object)reflectPerm, 1, 0);
		refPermsTable.get_Controls().Add((Control)(object)publishPerm, 2, 0);
		refPermsTable.get_Controls().Add((Control)(object)typePerm, 0, 1);
		refPermsTable.get_Controls().Add((Control)(object)strongNamePerm, 1, 1);
		refPermsTable.get_Controls().Add((Control)(object)isolatedPerm, 2, 1);
		((Control)refPermsTable).set_Dock((DockStyle)5);
		((Control)refPermsTable).set_Location(new Point(3, 3));
		((Control)refPermsTable).set_Name("refPermsTable");
		refPermsTable.set_RowCount(7);
		refPermsTable.get_RowStyles().Add(new RowStyle((SizeType)1, 40f));
		refPermsTable.get_RowStyles().Add(new RowStyle((SizeType)1, 40f));
		refPermsTable.get_RowStyles().Add(new RowStyle((SizeType)1, 40f));
		refPermsTable.get_RowStyles().Add(new RowStyle((SizeType)1, 40f));
		refPermsTable.get_RowStyles().Add(new RowStyle((SizeType)1, 40f));
		refPermsTable.get_RowStyles().Add(new RowStyle((SizeType)1, 40f));
		refPermsTable.get_RowStyles().Add(new RowStyle((SizeType)1, 20f));
		((Control)refPermsTable).set_Size(new Size(531, 282));
		((Control)refPermsTable).set_TabIndex(2);
		((Control)gacPerm).set_AutoSize(true);
		((Control)gacPerm).set_Dock((DockStyle)5);
		((Control)gacPerm).set_Location(new Point(3, 3));
		((Control)gacPerm).set_Name("gacPerm");
		((Control)gacPerm).set_Size(new Size(171, 34));
		((Control)gacPerm).set_TabIndex(30);
		((Control)gacPerm).set_Text("GAC");
		toolTip.SetToolTip((Control)(object)gacPerm, "Grant GacIdentity permission");
		((ButtonBase)gacPerm).set_UseVisualStyleBackColor(true);
		((Control)reflectPerm).set_AutoSize(true);
		((Control)reflectPerm).set_Dock((DockStyle)5);
		((Control)reflectPerm).set_Location(new Point(180, 3));
		((Control)reflectPerm).set_Name("reflectPerm");
		((Control)reflectPerm).set_Size(new Size(171, 34));
		((Control)reflectPerm).set_TabIndex(32);
		((Control)reflectPerm).set_Text("Reflection");
		toolTip.SetToolTip((Control)(object)reflectPerm, "Grant Reflection permission");
		((ButtonBase)reflectPerm).set_UseVisualStyleBackColor(true);
		((Control)publishPerm).set_AutoSize(true);
		((Control)publishPerm).set_Dock((DockStyle)5);
		((Control)publishPerm).set_Location(new Point(357, 3));
		((Control)publishPerm).set_Name("publishPerm");
		((Control)publishPerm).set_Size(new Size(171, 34));
		((Control)publishPerm).set_TabIndex(31);
		((Control)publishPerm).set_Text("Publisher Identity");
		toolTip.SetToolTip((Control)(object)publishPerm, "Grant PublisherIdentity permission");
		((ButtonBase)publishPerm).set_UseVisualStyleBackColor(true);
		((Control)typePerm).set_AutoSize(true);
		((Control)typePerm).set_Dock((DockStyle)5);
		((Control)typePerm).set_Location(new Point(3, 43));
		((Control)typePerm).set_Name("typePerm");
		((Control)typePerm).set_Size(new Size(171, 34));
		((Control)typePerm).set_TabIndex(34);
		((Control)typePerm).set_Text("Type Descriptor");
		toolTip.SetToolTip((Control)(object)typePerm, "Grant Type Descriptor permission");
		((ButtonBase)typePerm).set_UseVisualStyleBackColor(true);
		((Control)strongNamePerm).set_AutoSize(true);
		((Control)strongNamePerm).set_Dock((DockStyle)5);
		((Control)strongNamePerm).set_Location(new Point(180, 43));
		((Control)strongNamePerm).set_Name("strongNamePerm");
		((Control)strongNamePerm).set_Size(new Size(171, 34));
		((Control)strongNamePerm).set_TabIndex(33);
		((Control)strongNamePerm).set_Text("Strong Name");
		toolTip.SetToolTip((Control)(object)strongNamePerm, "Grant Strong Name permission");
		((ButtonBase)strongNamePerm).set_UseVisualStyleBackColor(true);
		((Control)isolatedPerm).set_AutoSize(true);
		((Control)isolatedPerm).set_Dock((DockStyle)5);
		((Control)isolatedPerm).set_Location(new Point(357, 43));
		((Control)isolatedPerm).set_Name("isolatedPerm");
		((Control)isolatedPerm).set_Size(new Size(171, 34));
		((Control)isolatedPerm).set_TabIndex(35);
		((Control)isolatedPerm).set_Text("Isolated Storage");
		toolTip.SetToolTip((Control)(object)isolatedPerm, "Grant IsolatedStorage permission");
		((ButtonBase)isolatedPerm).set_UseVisualStyleBackColor(true);
		((Control)netPermsTab).get_Controls().Add((Control)(object)netPermsTable);
		netPermsTab.set_Location(new Point(4, 22));
		((Control)netPermsTab).set_Name("netPermsTab");
		((Control)netPermsTab).set_Padding(new Padding(3));
		((Control)netPermsTab).set_Size(new Size(537, 288));
		netPermsTab.set_TabIndex(2);
		((Control)netPermsTab).set_Text("Network");
		netPermsTab.set_UseVisualStyleBackColor(true);
		netPermsTable.set_ColumnCount(3);
		netPermsTable.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 25f));
		netPermsTable.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 25f));
		netPermsTable.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 25f));
		netPermsTable.get_Controls().Add((Control)(object)aspPerm, 0, 0);
		netPermsTable.get_Controls().Add((Control)(object)dnsPerm, 0, 1);
		netPermsTable.get_Controls().Add((Control)(object)urlPerm, 1, 0);
		netPermsTable.get_Controls().Add((Control)(object)netInfoPerm, 1, 1);
		netPermsTable.get_Controls().Add((Control)(object)smtpPerm, 2, 0);
		netPermsTable.get_Controls().Add((Control)(object)socketPerm, 2, 1);
		netPermsTable.get_Controls().Add((Control)(object)sitePerm, 0, 2);
		netPermsTable.get_Controls().Add((Control)(object)sqlPerm, 2, 2);
		netPermsTable.get_Controls().Add((Control)(object)webPerm, 1, 2);
		netPermsTable.get_Controls().Add((Control)(object)zonePerm, 0, 3);
		((Control)netPermsTable).set_Dock((DockStyle)5);
		((Control)netPermsTable).set_Location(new Point(3, 3));
		((Control)netPermsTable).set_Name("netPermsTable");
		netPermsTable.set_RowCount(7);
		netPermsTable.get_RowStyles().Add(new RowStyle((SizeType)1, 40f));
		netPermsTable.get_RowStyles().Add(new RowStyle((SizeType)1, 40f));
		netPermsTable.get_RowStyles().Add(new RowStyle((SizeType)1, 40f));
		netPermsTable.get_RowStyles().Add(new RowStyle((SizeType)1, 40f));
		netPermsTable.get_RowStyles().Add(new RowStyle((SizeType)1, 40f));
		netPermsTable.get_RowStyles().Add(new RowStyle((SizeType)1, 40f));
		netPermsTable.get_RowStyles().Add(new RowStyle((SizeType)1, 20f));
		netPermsTable.get_RowStyles().Add(new RowStyle((SizeType)1, 20f));
		((Control)netPermsTable).set_Size(new Size(531, 282));
		((Control)netPermsTable).set_TabIndex(1);
		((Control)aspPerm).set_AutoSize(true);
		((Control)aspPerm).set_Dock((DockStyle)5);
		((Control)aspPerm).set_Location(new Point(3, 3));
		((Control)aspPerm).set_Name("aspPerm");
		((Control)aspPerm).set_Size(new Size(171, 34));
		((Control)aspPerm).set_TabIndex(29);
		((Control)aspPerm).set_Text("ASP Hosting");
		toolTip.SetToolTip((Control)(object)aspPerm, "Grant AspNetHosting permission");
		((ButtonBase)aspPerm).set_UseVisualStyleBackColor(true);
		((Control)dnsPerm).set_AutoSize(true);
		((Control)dnsPerm).set_Dock((DockStyle)5);
		((Control)dnsPerm).set_Location(new Point(3, 43));
		((Control)dnsPerm).set_Name("dnsPerm");
		((Control)dnsPerm).set_Size(new Size(171, 34));
		((Control)dnsPerm).set_TabIndex(30);
		((Control)dnsPerm).set_Text("DNS");
		toolTip.SetToolTip((Control)(object)dnsPerm, "Grant DNS permission");
		((ButtonBase)dnsPerm).set_UseVisualStyleBackColor(true);
		((Control)urlPerm).set_AutoSize(true);
		((Control)urlPerm).set_Dock((DockStyle)5);
		((Control)urlPerm).set_Location(new Point(180, 3));
		((Control)urlPerm).set_Name("urlPerm");
		((Control)urlPerm).set_Size(new Size(171, 34));
		((Control)urlPerm).set_TabIndex(34);
		((Control)urlPerm).set_Text("URL Identity");
		toolTip.SetToolTip((Control)(object)urlPerm, "Grant URL Identity permission");
		((ButtonBase)urlPerm).set_UseVisualStyleBackColor(true);
		((Control)netInfoPerm).set_AutoSize(true);
		((Control)netInfoPerm).set_Dock((DockStyle)5);
		((Control)netInfoPerm).set_Location(new Point(180, 43));
		((Control)netInfoPerm).set_Name("netInfoPerm");
		((Control)netInfoPerm).set_Size(new Size(171, 34));
		((Control)netInfoPerm).set_TabIndex(31);
		((Control)netInfoPerm).set_Text("Network Info");
		toolTip.SetToolTip((Control)(object)netInfoPerm, "Grant NetworkInformation permission");
		((ButtonBase)netInfoPerm).set_UseVisualStyleBackColor(true);
		((Control)smtpPerm).set_AutoSize(true);
		((Control)smtpPerm).set_Dock((DockStyle)5);
		((Control)smtpPerm).set_Location(new Point(357, 3));
		((Control)smtpPerm).set_Name("smtpPerm");
		((Control)smtpPerm).set_Size(new Size(171, 34));
		((Control)smtpPerm).set_TabIndex(32);
		((Control)smtpPerm).set_Text("SMTP");
		toolTip.SetToolTip((Control)(object)smtpPerm, "Grant SMTP permission");
		((ButtonBase)smtpPerm).set_UseVisualStyleBackColor(true);
		((Control)socketPerm).set_AutoSize(true);
		((Control)socketPerm).set_Dock((DockStyle)5);
		((Control)socketPerm).set_Location(new Point(357, 43));
		((Control)socketPerm).set_Name("socketPerm");
		((Control)socketPerm).set_Size(new Size(171, 34));
		((Control)socketPerm).set_TabIndex(33);
		((Control)socketPerm).set_Text("Socket");
		toolTip.SetToolTip((Control)(object)socketPerm, "Grant Socket permission");
		((ButtonBase)socketPerm).set_UseVisualStyleBackColor(true);
		((Control)sitePerm).set_AutoSize(true);
		((Control)sitePerm).set_Dock((DockStyle)5);
		((Control)sitePerm).set_Location(new Point(3, 83));
		((Control)sitePerm).set_Name("sitePerm");
		((Control)sitePerm).set_Size(new Size(171, 34));
		((Control)sitePerm).set_TabIndex(37);
		((Control)sitePerm).set_Text("Site Identity");
		toolTip.SetToolTip((Control)(object)sitePerm, "Grant Site Identity permission");
		((ButtonBase)sitePerm).set_UseVisualStyleBackColor(true);
		((Control)sqlPerm).set_AutoSize(true);
		((Control)sqlPerm).set_Dock((DockStyle)5);
		((Control)sqlPerm).set_Location(new Point(357, 83));
		((Control)sqlPerm).set_Name("sqlPerm");
		((Control)sqlPerm).set_Size(new Size(171, 34));
		((Control)sqlPerm).set_TabIndex(38);
		((Control)sqlPerm).set_Text("SQL Client");
		toolTip.SetToolTip((Control)(object)sqlPerm, "Grant SQL Client permission");
		((ButtonBase)sqlPerm).set_UseVisualStyleBackColor(true);
		((Control)webPerm).set_AutoSize(true);
		((Control)webPerm).set_Dock((DockStyle)5);
		((Control)webPerm).set_Location(new Point(180, 83));
		((Control)webPerm).set_Name("webPerm");
		((Control)webPerm).set_Size(new Size(171, 34));
		((Control)webPerm).set_TabIndex(36);
		((Control)webPerm).set_Text("Web");
		toolTip.SetToolTip((Control)(object)webPerm, "Grant Web permission");
		((ButtonBase)webPerm).set_UseVisualStyleBackColor(true);
		((Control)zonePerm).set_AutoSize(true);
		((Control)zonePerm).set_Dock((DockStyle)5);
		((Control)zonePerm).set_Location(new Point(3, 123));
		((Control)zonePerm).set_Name("zonePerm");
		((Control)zonePerm).set_Size(new Size(171, 34));
		((Control)zonePerm).set_TabIndex(35);
		((Control)zonePerm).set_Text("Zone Identity");
		toolTip.SetToolTip((Control)(object)zonePerm, "Grant Zone Identity permission");
		((ButtonBase)zonePerm).set_UseVisualStyleBackColor(true);
		((Control)otherPermsTab).get_Controls().Add((Control)(object)otherPermsTable);
		otherPermsTab.set_Location(new Point(4, 22));
		((Control)otherPermsTab).set_Name("otherPermsTab");
		((Control)otherPermsTab).set_Padding(new Padding(3));
		((Control)otherPermsTab).set_Size(new Size(537, 288));
		otherPermsTab.set_TabIndex(4);
		((Control)otherPermsTab).set_Text("Other");
		otherPermsTab.set_UseVisualStyleBackColor(true);
		otherPermsTable.set_ColumnCount(3);
		otherPermsTable.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 25f));
		otherPermsTable.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 25f));
		otherPermsTable.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 25f));
		otherPermsTable.get_Controls().Add((Control)(object)keyPerm, 0, 0);
		otherPermsTable.get_Controls().Add((Control)(object)storePerm, 0, 1);
		otherPermsTable.get_Controls().Add((Control)(object)olePerm, 1, 0);
		otherPermsTable.get_Controls().Add((Control)(object)odbcPerm, 2, 0);
		((Control)otherPermsTable).set_Dock((DockStyle)5);
		((Control)otherPermsTable).set_Location(new Point(3, 3));
		((Control)otherPermsTable).set_Name("otherPermsTable");
		otherPermsTable.set_RowCount(7);
		otherPermsTable.get_RowStyles().Add(new RowStyle((SizeType)1, 40f));
		otherPermsTable.get_RowStyles().Add(new RowStyle((SizeType)1, 40f));
		otherPermsTable.get_RowStyles().Add(new RowStyle((SizeType)1, 40f));
		otherPermsTable.get_RowStyles().Add(new RowStyle((SizeType)1, 40f));
		otherPermsTable.get_RowStyles().Add(new RowStyle((SizeType)1, 40f));
		otherPermsTable.get_RowStyles().Add(new RowStyle((SizeType)1, 40f));
		otherPermsTable.get_RowStyles().Add(new RowStyle((SizeType)1, 20f));
		((Control)otherPermsTable).set_Size(new Size(531, 282));
		((Control)otherPermsTable).set_TabIndex(1);
		((Control)keyPerm).set_AutoSize(true);
		((Control)keyPerm).set_Dock((DockStyle)5);
		((Control)keyPerm).set_Location(new Point(3, 3));
		((Control)keyPerm).set_Name("keyPerm");
		((Control)keyPerm).set_Size(new Size(171, 34));
		((Control)keyPerm).set_TabIndex(24);
		((Control)keyPerm).set_Text("Key Container");
		toolTip.SetToolTip((Control)(object)keyPerm, "Grant KeyContainer permission");
		((ButtonBase)keyPerm).set_UseVisualStyleBackColor(true);
		((Control)storePerm).set_AutoSize(true);
		((Control)storePerm).set_Dock((DockStyle)5);
		((Control)storePerm).set_Location(new Point(3, 43));
		((Control)storePerm).set_Name("storePerm");
		((Control)storePerm).set_Size(new Size(171, 34));
		((Control)storePerm).set_TabIndex(27);
		((Control)storePerm).set_Text("Store");
		toolTip.SetToolTip((Control)(object)storePerm, "Grant Store permission");
		((ButtonBase)storePerm).set_UseVisualStyleBackColor(true);
		((Control)olePerm).set_AutoSize(true);
		((Control)olePerm).set_Dock((DockStyle)5);
		((Control)olePerm).set_Location(new Point(180, 3));
		((Control)olePerm).set_Name("olePerm");
		((Control)olePerm).set_Size(new Size(171, 34));
		((Control)olePerm).set_TabIndex(26);
		((Control)olePerm).set_Text("OLE DB");
		toolTip.SetToolTip((Control)(object)olePerm, "Grant OLE DB permission");
		((ButtonBase)olePerm).set_UseVisualStyleBackColor(true);
		((Control)odbcPerm).set_AutoSize(true);
		((Control)odbcPerm).set_Dock((DockStyle)5);
		((Control)odbcPerm).set_Location(new Point(357, 3));
		((Control)odbcPerm).set_Name("odbcPerm");
		((Control)odbcPerm).set_Size(new Size(171, 34));
		((Control)odbcPerm).set_TabIndex(25);
		((Control)odbcPerm).set_Text("ODBC");
		toolTip.SetToolTip((Control)(object)odbcPerm, "Grant ODBC permission");
		((ButtonBase)odbcPerm).set_UseVisualStyleBackColor(true);
		((Control)pathLabel).set_Dock((DockStyle)5);
		((Control)pathLabel).set_Location(new Point(3, 0));
		((Control)pathLabel).set_Name("pathLabel");
		((Control)pathLabel).set_Size(new Size(69, 25));
		((Control)pathLabel).set_TabIndex(0);
		((Control)pathLabel).set_Text("Path:");
		pathLabel.set_TextAlign((ContentAlignment)32);
		toolTip.SetToolTip((Control)(object)pathLabel, "Target program to run in the sandbox");
		((Control)pathTextBox).set_Dock((DockStyle)1);
		((Control)pathTextBox).set_Location(new Point(78, 3));
		((Control)pathTextBox).set_Name("pathTextBox");
		((Control)pathTextBox).set_Size(new Size(389, 20));
		((Control)pathTextBox).set_TabIndex(2);
		toolTip.SetToolTip((Control)(object)pathTextBox, "Target program to run in the sandbox");
		((Control)pathTextBox).add_TextChanged((EventHandler)path_TextChanged);
		((Control)selectFileButton).set_Dock((DockStyle)5);
		((Control)selectFileButton).set_Location(new Point(473, 3));
		((Control)selectFileButton).set_Name("selectFileButton");
		((Control)selectFileButton).set_Size(new Size(69, 19));
		((Control)selectFileButton).set_TabIndex(7);
		((Control)selectFileButton).set_Text("...");
		toolTip.SetToolTip((Control)(object)selectFileButton, "Select target program");
		((ButtonBase)selectFileButton).set_UseVisualStyleBackColor(true);
		((Control)selectFileButton).add_Click((EventHandler)selectFileButton_Click);
		((Control)argsTextBox).set_Dock((DockStyle)5);
		((Control)argsTextBox).set_Location(new Point(78, 28));
		((TextBoxBase)argsTextBox).set_Multiline(true);
		((Control)argsTextBox).set_Name("argsTextBox");
		((Control)argsTextBox).set_Size(new Size(389, 44));
		((Control)argsTextBox).set_TabIndex(3);
		toolTip.SetToolTip((Control)(object)argsTextBox, "Arguments to be passed-through to the target program");
		((Control)argsLabel).set_Dock((DockStyle)5);
		((Control)argsLabel).set_Location(new Point(3, 25));
		((Control)argsLabel).set_Name("argsLabel");
		((Control)argsLabel).set_Size(new Size(69, 50));
		((Control)argsLabel).set_TabIndex(1);
		((Control)argsLabel).set_Text("Arguments:");
		argsLabel.set_TextAlign((ContentAlignment)32);
		toolTip.SetToolTip((Control)(object)argsLabel, "Arguments to be passed-through to the target program");
		((Control)clearArgsButton).set_Dock((DockStyle)5);
		((Control)clearArgsButton).set_Location(new Point(473, 28));
		((Control)clearArgsButton).set_Name("clearArgsButton");
		((Control)clearArgsButton).set_Size(new Size(69, 44));
		((Control)clearArgsButton).set_TabIndex(8);
		((Control)clearArgsButton).set_Text("Clear");
		toolTip.SetToolTip((Control)(object)clearArgsButton, "Clear all arguments");
		((ButtonBase)clearArgsButton).set_UseVisualStyleBackColor(true);
		((Control)clearArgsButton).add_Click((EventHandler)clearArgsButton_Click);
		sandboxRunning.add_Tick((EventHandler)sandboxRunning_Tick);
		((Control)permGlobalTabPage).get_Controls().Add((Control)(object)permissionsTabControl);
		permGlobalTabPage.set_Location(new Point(4, 22));
		((Control)permGlobalTabPage).set_Name("permGlobalTabPage");
		((Control)permGlobalTabPage).set_Padding(new Padding(3));
		((Control)permGlobalTabPage).set_Size(new Size(551, 320));
		permGlobalTabPage.set_TabIndex(3);
		((Control)permGlobalTabPage).set_Text("Permissions");
		permGlobalTabPage.set_UseVisualStyleBackColor(true);
		((Control)programTab).get_Controls().Add((Control)(object)progPanel);
		programTab.set_Location(new Point(4, 22));
		((Control)programTab).set_Name("programTab");
		((Control)programTab).set_Padding(new Padding(3));
		((Control)programTab).set_Size(new Size(551, 320));
		programTab.set_TabIndex(0);
		((Control)programTab).set_Text("Program");
		programTab.set_UseVisualStyleBackColor(true);
		progPanel.set_ColumnCount(3);
		progPanel.get_ColumnStyles().Add(new ColumnStyle((SizeType)1, 75f));
		progPanel.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 100f));
		progPanel.get_ColumnStyles().Add(new ColumnStyle((SizeType)1, 75f));
		progPanel.get_Controls().Add((Control)(object)clearArgsButton, 2, 1);
		progPanel.get_Controls().Add((Control)(object)argsLabel, 0, 1);
		progPanel.get_Controls().Add((Control)(object)argsTextBox, 1, 1);
		progPanel.get_Controls().Add((Control)(object)selectFileButton, 2, 0);
		progPanel.get_Controls().Add((Control)(object)pathTextBox, 1, 0);
		progPanel.get_Controls().Add((Control)(object)pathLabel, 0, 0);
		progPanel.get_Controls().Add((Control)(object)consoleControlPanel, 1, 2);
		((Control)progPanel).set_Dock((DockStyle)5);
		progPanel.set_GrowStyle((TableLayoutPanelGrowStyle)0);
		((Control)progPanel).set_Location(new Point(3, 3));
		((Control)progPanel).set_Name("progPanel");
		progPanel.set_RowCount(4);
		progPanel.get_RowStyles().Add(new RowStyle((SizeType)1, 25f));
		progPanel.get_RowStyles().Add(new RowStyle((SizeType)1, 50f));
		progPanel.get_RowStyles().Add(new RowStyle((SizeType)1, 50f));
		progPanel.get_RowStyles().Add(new RowStyle((SizeType)1, 50f));
		((Control)progPanel).set_Size(new Size(545, 314));
		((Control)progPanel).set_TabIndex(10);
		consoleControlPanel.set_ColumnCount(2);
		consoleControlPanel.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 50f));
		consoleControlPanel.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 50f));
		((Control)consoleControlPanel).set_Dock((DockStyle)5);
		((Control)consoleControlPanel).set_Location(new Point(78, 78));
		((Control)consoleControlPanel).set_Name("consoleControlPanel");
		consoleControlPanel.set_RowCount(1);
		consoleControlPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 50f));
		((Control)consoleControlPanel).set_Size(new Size(389, 44));
		((Control)consoleControlPanel).set_TabIndex(10);
		((Control)sandboxTabControl).get_Controls().Add((Control)(object)programTab);
		((Control)sandboxTabControl).get_Controls().Add((Control)(object)permGlobalTabPage);
		((Control)sandboxTabControl).set_Dock((DockStyle)5);
		((Control)sandboxTabControl).set_Location(new Point(0, 72));
		((Control)sandboxTabControl).set_Name("sandboxTabControl");
		sandboxTabControl.set_SelectedIndex(0);
		((Control)sandboxTabControl).set_Size(new Size(559, 346));
		((Control)sandboxTabControl).set_TabIndex(8);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(559, 461));
		((Control)this).get_Controls().Add((Control)(object)sandboxTabControl);
		((Control)this).get_Controls().Add((Control)(object)titlePanel);
		((Control)this).get_Controls().Add((Control)(object)runSandbox);
		((Control)this).get_Controls().Add((Control)(object)menuStrip);
		((Form)this).set_MainMenuStrip(menuStrip);
		((Control)this).set_MinimumSize(new Size(555, 460));
		((Control)this).set_Name("SandboxDotNet");
		((Control)this).set_Text("SandboxDotNet");
		((Control)menuStrip).ResumeLayout(false);
		((Control)menuStrip).PerformLayout();
		((Control)titlePanel).ResumeLayout(false);
		((Control)permissionsTabControl).ResumeLayout(false);
		((Control)locMachinePermsTab).ResumeLayout(false);
		((Control)localPermsTable).ResumeLayout(false);
		((Control)localPermsTable).PerformLayout();
		((Control)fileIoPermsTab).ResumeLayout(false);
		((Control)fileIoTableLayoutPanel).ResumeLayout(false);
		((Control)fileIoFolderButtonTableLayoutPanel).ResumeLayout(false);
		((Control)fileIoFolderButtonTableLayoutPanel).PerformLayout();
		((Control)fileIoPermsTabPanel).ResumeLayout(false);
		((Control)fileIoFileButtonTableLayoutPanel).ResumeLayout(false);
		((Control)fileIoFileButtonTableLayoutPanel).PerformLayout();
		((Control)tableLayoutPanel2).ResumeLayout(false);
		((Control)tableLayoutPanel2).PerformLayout();
		((Control)securityPermsTab).ResumeLayout(false);
		((Control)secPermsTable).ResumeLayout(false);
		((Control)secPermsTable).PerformLayout();
		((Control)refPermsTab).ResumeLayout(false);
		((Control)refPermsTable).ResumeLayout(false);
		((Control)refPermsTable).PerformLayout();
		((Control)netPermsTab).ResumeLayout(false);
		((Control)netPermsTable).ResumeLayout(false);
		((Control)netPermsTable).PerformLayout();
		((Control)otherPermsTab).ResumeLayout(false);
		((Control)otherPermsTable).ResumeLayout(false);
		((Control)otherPermsTable).PerformLayout();
		((Control)permGlobalTabPage).ResumeLayout(false);
		((Control)programTab).ResumeLayout(false);
		((Control)progPanel).ResumeLayout(false);
		((Control)progPanel).PerformLayout();
		((Control)sandboxTabControl).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
