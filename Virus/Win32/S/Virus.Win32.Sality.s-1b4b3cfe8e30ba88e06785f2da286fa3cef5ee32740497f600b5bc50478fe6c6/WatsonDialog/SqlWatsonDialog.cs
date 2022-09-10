using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Windows.Forms;
using Microsoft.NetEnterpriseServers;
using Microsoft.SqlServer.Management.Diagnostics;
using Microsoft.SqlServer.Management.UI;
using Microsoft.SqlServer.Management.UI.Grid;
using Microsoft.Win32;

namespace WatsonDialog;

internal class SqlWatsonDialog : Form
{
	private bool m_showGrid;

	private SqlWatsonGridStorage m_gridStorage;

	private bool m_sortInstanceDescending;

	private bool m_sortComponentDescending;

	private int m_expandedHeight;

	private string m_helpFilePath;

	private IContainer components;

	private CheckBox featureCheckBox;

	private CheckBox errorCheckBox;

	private Button optionsButton;

	private Panel gridPanel;

	private Label labelAboveGrid;

	private Label labelBelowGrid;

	private Button okButton;

	private Button cancelButton;

	private Button helpButton;

	private Separator separator1;

	private Panel panelUpper;

	private Panel panelTopControls;

	private Panel panelOptionsButton;

	private SqlWatsonGridControl instanceGrid;

	private SqlWatsonLinkLabel privacyLinkLabel;

	internal static void LaunchDialog()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		if (!IsCurrentUserAdmin())
		{
			ErrorHandler.Error(Constants.USER_IS_NOT_ADMIN);
			return;
		}
		if (!CheckRegistry())
		{
			ErrorHandler.Error(Constants.CORRUPT_REGISTRY);
			return;
		}
		SqlWatsonDialog sqlWatsonDialog = new SqlWatsonDialog();
		((Form)sqlWatsonDialog).ShowDialog();
	}

	private static bool IsCurrentUserAdmin()
	{
		WindowsPrincipal windowsPrincipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
		return windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
	}

	private static bool CheckRegistry()
	{
		if (!RegistryInteractor.KeyExists(Constants.BASE_REGKEY, "SOFTWARE\\Microsoft\\Microsoft SQL Server\\90") && !RegistryInteractor.KeyExists(Constants.BASE_REGKEY, "SOFTWARE\\Wow6432Node\\Microsoft\\Microsoft SQL Server\\90"))
		{
			return false;
		}
		return true;
	}

	internal SqlWatsonDialog()
	{
		InitializeState();
		InitializeComponent();
		InitializeGrid();
		InitializeHelpFilePath();
		InitializePrivacyLink();
		UpdateGridLayout();
		UpdateMainCheckBoxes();
	}

	private void InitializeState()
	{
		m_showGrid = false;
		m_sortInstanceDescending = true;
		m_sortComponentDescending = true;
		m_expandedHeight = 528;
	}

	private void InitializeGrid()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected O, but got Unknown
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected O, but got Unknown
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected O, but got Unknown
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Expected O, but got Unknown
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Expected O, but got Unknown
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Expected O, but got Unknown
		GridColumnInfo val = null;
		val = new GridColumnInfo();
		val.IsUserResizable = true;
		val.IsWithRightGridLine = true;
		val.IsHeaderMergedWithRight = false;
		val.IsHeaderClickable = true;
		val.ColumnAlignment = (HorizontalAlignment)0;
		val.ColumnWidth = 100;
		val.WidthType = (GridColumnWidthType)0;
		val.ColumnType = 1;
		val.HeaderType = (GridColumnHeaderType)0;
		((GridControl)instanceGrid).AddColumn(val);
		val = new GridColumnInfo();
		val.IsUserResizable = true;
		val.IsWithRightGridLine = true;
		val.IsHeaderMergedWithRight = false;
		val.IsHeaderClickable = true;
		val.ColumnAlignment = (HorizontalAlignment)0;
		val.ColumnWidth = 100;
		val.WidthType = (GridColumnWidthType)0;
		val.ColumnType = 1;
		val.HeaderType = (GridColumnHeaderType)0;
		((GridControl)instanceGrid).AddColumn(val);
		val = new GridColumnInfo();
		val.IsUserResizable = true;
		val.IsWithRightGridLine = true;
		val.IsHeaderMergedWithRight = false;
		val.IsHeaderClickable = false;
		val.ColumnAlignment = (HorizontalAlignment)2;
		val.ColumnWidth = 80;
		val.WidthType = (GridColumnWidthType)0;
		val.ColumnType = 4;
		val.IsWithSelectionBackground = false;
		val.HeaderType = (GridColumnHeaderType)0;
		((GridControl)instanceGrid).AddColumn(val);
		val = new GridColumnInfo();
		val.IsUserResizable = true;
		val.IsWithRightGridLine = true;
		val.IsHeaderMergedWithRight = false;
		val.IsHeaderClickable = false;
		val.ColumnAlignment = (HorizontalAlignment)2;
		val.ColumnWidth = 80;
		val.WidthType = (GridColumnWidthType)0;
		val.ColumnType = 4;
		val.IsWithSelectionBackground = false;
		val.HeaderType = (GridColumnHeaderType)0;
		((GridControl)instanceGrid).AddColumn(val);
		val = new GridColumnInfo();
		val.IsUserResizable = false;
		val.IsWithRightGridLine = true;
		val.IsHeaderMergedWithRight = true;
		val.IsHeaderClickable = false;
		val.ColumnAlignment = (HorizontalAlignment)0;
		val.ColumnWidth = 146;
		val.WidthType = (GridColumnWidthType)0;
		val.ColumnType = 1;
		val.HeaderType = (GridColumnHeaderType)0;
		((GridControl)instanceGrid).AddColumn(val);
		val = new GridColumnInfo();
		val.IsUserResizable = false;
		val.IsWithRightGridLine = true;
		val.IsHeaderMergedWithRight = false;
		val.IsHeaderClickable = false;
		val.ColumnAlignment = (HorizontalAlignment)0;
		val.ColumnWidth = 18;
		val.WidthType = (GridColumnWidthType)0;
		val.ColumnType = 2;
		val.HeaderType = (GridColumnHeaderType)0;
		((GridControl)instanceGrid).AddColumn(val);
		((GridControl)instanceGrid).SetHeaderInfo(0, Constants.INSTANCE_COLUMN_HEADER, (Bitmap)null);
		((GridControl)instanceGrid).SetHeaderInfo(1, Constants.COMPONENT_COLUMN_HEADER, (Bitmap)null);
		((GridControl)instanceGrid).SetHeaderInfo(2, Constants.USAGE_CHECKBOX_COLUMN_HEADER, (Bitmap)null);
		((GridControl)instanceGrid).SetHeaderInfo(3, Constants.ERROR_CHECKBOX_COLUMN_HEADER, (Bitmap)null);
		((GridControl)instanceGrid).SetHeaderInfo(5, Constants.ERROR_REPORTS_COLUMN_HEADER, (Bitmap)null);
		m_gridStorage = new SqlWatsonGridStorage();
		((GridControl)instanceGrid).set_GridStorage((IGridStorage)(object)m_gridStorage);
		((GridControl)instanceGrid).add_MouseButtonClicked(new MouseButtonClickedEventHandler(instanceGrid_CellClicked));
		((GridControl)instanceGrid).add_HeaderButtonClicked(new HeaderButtonClickedEventHandler(instanceGrid_HeaderButtonClicked));
		((Control)this).add_Resize((EventHandler)SqlWatsonDialog_Resize);
		((GridControl)instanceGrid).add_ColumnWidthChanged(new ColumnWidthChangedEventHandler(instanceGrid_ColumnWidthChanged));
		((Control)instanceGrid).add_GotFocus((EventHandler)instanceGrid_GotFocus);
		((GridControl)instanceGrid).add_StandardKeyProcessing(new StandardKeyProcessingEventHandler(instanceGrid_StandardKeyProcessing));
		((GridControl)instanceGrid).add_EmbeddedControlContentsChanged(new EmbeddedControlContentsChangedEventHandler(instanceGrid_EmbeddedControlContentsChanged));
		((Control)instanceGrid).set_AccessibleName(Constants.GRID_ACCESSIBLE_NAME);
	}

	private void InitializeHelpFilePath()
	{
		object regKeyValue = RegistryInteractor.GetRegKeyValue(Constants.BASE_REGKEY, "SOFTWARE\\Microsoft\\Microsoft SQL Server\\90\\Bootstrap", "BootstrapDir");
		if (regKeyValue == null)
		{
			regKeyValue = RegistryInteractor.GetRegKeyValue(Constants.BASE_REGKEY, "SOFTWARE\\Wow6432Node\\Microsoft\\Microsoft SQL Server\\90\\Bootstrap", "BootstrapDir", Constants.CORRUPT_REGISTRY_BOOTSTRAP);
			if (regKeyValue == null)
			{
				return;
			}
		}
		m_helpFilePath = string.Format(CultureInfo.InvariantCulture, "{0}\\{1}\\{2}\\{3}", regKeyValue, Constants.HELP_DIR_SUFFIX, CultureInfo.CurrentCulture.LCID, Constants.HELP_FILE_NAME);
	}

	private void InitializePrivacyLink()
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		((Control)privacyLinkLabel).set_Text(string.Format(CultureInfo.CurrentCulture, "{0}{1}", new object[2]
		{
			((Control)privacyLinkLabel).get_Text(),
			Constants.PRIVACY_LINK
		}));
		((LinkLabel)privacyLinkLabel).set_LinkArea(new LinkArea(((Control)privacyLinkLabel).get_Text().IndexOf(Constants.PRIVACY_LINK), Constants.PRIVACY_LINK.Length));
		((LinkLabel)privacyLinkLabel).get_Links().get_Item(0).set_LinkData((object)Constants.PRIVACY_POLICY_LINK);
	}

	private void privacyLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start(e.get_Link().get_LinkData().ToString());
	}

	private void optionsButton_Click(object sender, EventArgs e)
	{
		m_showGrid = !m_showGrid;
		UpdateGridLayout();
	}

	private void cancelButton_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void okButton_Click(object sender, EventArgs e)
	{
		if (SaveValues())
		{
			((Form)this).Close();
		}
	}

	private void helpButton_Click(object sender, EventArgs e)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		if (m_helpFilePath == null)
		{
			InitializeHelpFilePath();
			if (m_helpFilePath == null)
			{
				return;
			}
		}
		try
		{
			Help.ShowHelp((Control)(object)this, m_helpFilePath, (HelpNavigator)(-2147483647), (object)"html\\e72c43b6-a2bd-4545-9aff-79c83b21180d.htm");
		}
		catch (ArgumentException ex)
		{
			STrace.LogExCatch((Exception)ex);
			ErrorHandler.Error(ex.Message);
		}
	}

	protected override void OnKeyDown(KeyEventArgs kea)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Invalid comparison between Unknown and I4
		if ((int)kea.get_KeyData() == 131142)
		{
			featureCheckBox.set_Checked(!featureCheckBox.get_Checked());
		}
		if ((int)kea.get_KeyData() == 131141)
		{
			errorCheckBox.set_Checked(!errorCheckBox.get_Checked());
		}
	}

	private void instanceGrid_GotFocus(object sender, EventArgs e)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		long num = default(long);
		int num2 = default(int);
		((GridControl)instanceGrid).GetCurrentCell(ref num, ref num2);
		if (num == -1L || num2 == -1)
		{
			BlockOfCells[] array = (BlockOfCells[])(object)new BlockOfCells[1]
			{
				new BlockOfCells(0L, 0)
			};
			((GridControl)instanceGrid).set_SelectedCells(new BlockOfCellsCollection(array));
		}
	}

	private void instanceGrid_StandardKeyProcessing(object sender, StandardKeyProcessingEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.get_Key() == 32)
		{
			long rowIndex = default(long);
			int num = default(int);
			((GridControl)instanceGrid).GetCurrentCell(ref rowIndex, ref num);
			if (num == 3 || num == 2)
			{
				HandleClickOnCheckBoxCell(rowIndex, num);
				((GridControl)instanceGrid).UpdateGrid();
			}
		}
	}

	private void instanceGrid_EmbeddedControlContentsChanged(object sender, EmbeddedControlContentsChangedEventArgs e)
	{
		IGridEmbeddedControl embeddedControl = e.get_EmbeddedControl();
		string curSelectionAsString = embeddedControl.GetCurSelectionAsString();
		if (curSelectionAsString != null && curSelectionAsString.Length > 247)
		{
			embeddedControl.SetCurSelectionAsString(curSelectionAsString.Substring(0, 247));
		}
	}

	private void instanceGrid_HeaderButtonClicked(object sender, HeaderButtonClickedEventArgs e)
	{
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		((GridControl)instanceGrid).StopCellEdit(true);
		long num = default(long);
		int num2 = default(int);
		((GridControl)instanceGrid).GetCurrentCell(ref num, ref num2);
		Instance inst = null;
		if (num != -1L)
		{
			inst = m_gridStorage.GetInstance(num);
		}
		if (e.get_ColumnIndex() == 0)
		{
			m_gridStorage.SortByColumn(e.get_ColumnIndex(), m_sortInstanceDescending);
			m_sortInstanceDescending = !m_sortInstanceDescending;
		}
		else if (e.get_ColumnIndex() == 1)
		{
			m_gridStorage.SortByColumn(e.get_ColumnIndex(), m_sortComponentDescending);
			m_sortComponentDescending = !m_sortComponentDescending;
		}
		if (num != -1L)
		{
			((GridControl)instanceGrid).set_SelectedCells(new BlockOfCellsCollection((BlockOfCells[])(object)new BlockOfCells[1]
			{
				new BlockOfCells(m_gridStorage.GetRow(inst), num2)
			}));
		}
		((GridControl)instanceGrid).UpdateGrid();
	}

	private void instanceGrid_CellClicked(object sender, MouseButtonClickedEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() != 1048576 || e.get_ColumnIndex() == 0 || e.get_ColumnIndex() == 1)
		{
			return;
		}
		Instance instance = m_gridStorage.GetInstance(e.get_RowIndex());
		if (!instance.canWrite)
		{
			string text = "";
			switch (e.get_ColumnIndex())
			{
			case 2:
				text = Constants.USAGE_CHECKBOX_COLUMN_HEADER;
				break;
			case 3:
				text = Constants.ERROR_CHECKBOX_COLUMN_HEADER;
				break;
			case 4:
			case 5:
				text = Constants.ERROR_REPORTS_COLUMN_HEADER;
				break;
			}
			ErrorHandler.Error(string.Format(CultureInfo.InvariantCulture, Constants.CANNOT_UPDATE_NON_ACTIVE_NODE, new object[2] { text, instance.DisplayName }));
			return;
		}
		if (e.get_ColumnIndex() == 2 || e.get_ColumnIndex() == 3)
		{
			HandleClickOnCheckBoxCell(e.get_RowIndex(), e.get_ColumnIndex());
		}
		if (e.get_ColumnIndex() == 5)
		{
			((GridControl)instanceGrid).StopCellEdit(true);
			FolderBrowserDialog val = new FolderBrowserDialog();
			val.set_Description(Constants.BROWSE_DESCRIPTION);
			string selectedPath = m_gridStorage.GetInstanceData(e.get_RowIndex(), e.get_ColumnIndex() - 1) as string;
			val.set_SelectedPath(selectedPath);
			if ((int)((CommonDialog)val).ShowDialog() == 1)
			{
				m_gridStorage.SetInstanceData(e.get_RowIndex(), e.get_ColumnIndex() - 1, val.get_SelectedPath());
			}
		}
	}

	private void featureCheckBox_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Invalid comparison between Unknown and I4
		if ((int)featureCheckBox.get_CheckState() != 2)
		{
			m_gridStorage.SelectAllCheckBoxes(2, (int)featureCheckBox.get_CheckState() == 1);
			((GridControl)instanceGrid).UpdateGrid();
		}
	}

	private void errorCheckBox_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Invalid comparison between Unknown and I4
		if ((int)errorCheckBox.get_CheckState() != 2)
		{
			m_gridStorage.SelectAllCheckBoxes(3, (int)errorCheckBox.get_CheckState() == 1);
			((GridControl)instanceGrid).UpdateGrid();
		}
	}

	private void SqlWatsonDialog_Resize(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		if ((int)((Form)this).get_WindowState() != 1)
		{
			StretchErrorDirColumn();
		}
		if (instanceGrid != null)
		{
			if (labelAboveGrid != null)
			{
				((Control)labelAboveGrid).set_MaximumSize(new Size(((Control)instanceGrid).get_Width() - 5, 0));
			}
			if (labelBelowGrid != null)
			{
				((Control)labelBelowGrid).set_MaximumSize(new Size(((Control)instanceGrid).get_Width() - 5, 0));
			}
		}
		if (panelUpper != null && privacyLinkLabel != null)
		{
			((Control)privacyLinkLabel).set_MaximumSize(new Size(((Control)panelUpper).get_Width() - 5, 0));
		}
	}

	private void instanceGrid_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
	{
		if (e.get_ColumnIndex() != 4)
		{
			StretchErrorDirColumn();
		}
	}

	private void UpdateGridLayout()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Invalid comparison between Unknown and I4
		if (m_showGrid)
		{
			((Control)this).set_Height(m_expandedHeight);
			((Control)gridPanel).set_Visible(true);
			((Control)optionsButton).set_Text(Constants.OPTIONS_BUTTON_TEXT_HIDE);
			return;
		}
		if ((int)((Form)this).get_WindowState() != 2)
		{
			m_expandedHeight = ((Control)this).get_Height();
			if (m_expandedHeight < 528)
			{
				m_expandedHeight = 528;
			}
		}
		((Control)this).set_Height(324);
		((Control)gridPanel).set_Visible(false);
		((Control)optionsButton).set_Text(Constants.OPTIONS_BUTTON_TEXT_SHOW);
	}

	private void UpdateMainCheckBoxes()
	{
		CheckBox val = featureCheckBox;
		int nColIndex = 2;
		if (m_gridStorage.AreAllCheckBoxesChecked(2))
		{
			val.set_CheckState((CheckState)1);
		}
		else if (m_gridStorage.AreAllCheckBoxesUnchecked(nColIndex))
		{
			val.set_CheckState((CheckState)0);
		}
		else
		{
			val.set_CheckState((CheckState)2);
		}
		val = errorCheckBox;
		nColIndex = 3;
		if (m_gridStorage.AreAllCheckBoxesChecked(3))
		{
			val.set_CheckState((CheckState)1);
		}
		else if (m_gridStorage.AreAllCheckBoxesUnchecked(nColIndex))
		{
			val.set_CheckState((CheckState)0);
		}
		else
		{
			val.set_CheckState((CheckState)2);
		}
	}

	private void HandleClickOnCheckBoxCell(long rowIndex, int colIndex)
	{
		m_gridStorage.ToggleCheckBox(rowIndex, colIndex);
		UpdateMainCheckBoxes();
	}

	private void StretchErrorDirColumn()
	{
		if (!m_showGrid)
		{
			return;
		}
		int num = ((Control)instanceGrid).get_Width();
		for (int i = 0; i < 6; i++)
		{
			if (i != 4)
			{
				num -= ((GridControl)instanceGrid).GetColumnWidth(i);
			}
		}
		num -= 11;
		int visibleRowsNum = ((GridControl)instanceGrid).get_VisibleRowsNum();
		long num2 = ((GridControl)instanceGrid).get_GridStorage().NumRows();
		if (visibleRowsNum < num2)
		{
			num -= 16;
		}
		if (num > 0)
		{
			((GridControl)instanceGrid).SetColumnWidth(4, (GridColumnWidthType)0, num);
		}
	}

	private bool VerifyDirectory(string path, Instance inst)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Invalid comparison between Unknown and I4
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Invalid comparison between Unknown and I4
		if (string.IsNullOrEmpty(path))
		{
			ErrorHandler.Error(Constants.INVALID_BLANK_DIRECTORY);
			return false;
		}
		if (Directory.Exists(path))
		{
			return SetDirectoryAcls(path, inst);
		}
		DialogResult val = ErrorHandler.Error(string.Format(CultureInfo.InvariantCulture, Constants.CONFIRM_FOLDER_CREATE, new object[1] { path }), Constants.CREATE_FOLDER_CAPTION, (ExceptionMessageBoxButtons)3, (ExceptionMessageBoxSymbol)6);
		if ((int)val == 7)
		{
			return false;
		}
		val = (DialogResult)0;
		do
		{
			try
			{
				DirectoryInfo directoryInfo = Directory.CreateDirectory(path);
				string fullName = directoryInfo.FullName;
				if (fullName != path)
				{
					inst.errorDir = fullName;
				}
				return SetDirectoryAcls(path, inst);
			}
			catch (Exception ex)
			{
				STrace.LogExCatch(ex);
				val = ErrorHandler.Error(string.Format(CultureInfo.InvariantCulture, Constants.INVALID_DIRECTORY, new object[1] { path }), (ExceptionMessageBoxButtons)5, ex);
			}
		}
		while ((int)val == 4);
		return false;
	}

	private bool SetDirectoryAcls(string path, Instance inst)
	{
		DirectorySecurity directorySecurity = new DirectorySecurity();
		if (inst.IsAgnostic)
		{
			for (long num = 0L; num < m_gridStorage.NumRows(); num++)
			{
				Instance instance = m_gridStorage.GetInstance(num);
				if (inst.isWow == instance.isWow)
				{
					if (instance.instanceType == Constants.COMPONENT_SQL_SERVER_STRING)
					{
						AddAccessRuleToDirectorySecurity("SQLServer2005MSSQLUser" + instance.UserGroupSuffix, FileSystemRights.Write | FileSystemRights.Read, AccessControlType.Allow, directorySecurity);
						AddAccessRuleToDirectorySecurity("SQLServer2005SQLAgentUser" + instance.UserGroupSuffix, FileSystemRights.Write | FileSystemRights.Read, AccessControlType.Allow, directorySecurity);
					}
					else if (instance.instanceType == Constants.COMPONENT_ANALYSIS_SERVER_STRING)
					{
						AddAccessRuleToDirectorySecurity("SQLServer2005MSOLAPUser" + instance.UserGroupSuffix, FileSystemRights.Write | FileSystemRights.Read, AccessControlType.Allow, directorySecurity);
					}
					else if (instance.instanceType == Constants.COMPONENT_REPORT_SERVER_STRING)
					{
						AddAccessRuleToDirectorySecurity("SQLServer2005ReportServerUser" + instance.UserGroupSuffix, FileSystemRights.Write | FileSystemRights.Read, AccessControlType.Allow, directorySecurity);
					}
				}
			}
			if (IsNSInstalled(inst.isWow))
			{
				AddAccessRuleToDirectorySecurity("SQLServer2005NotificationServicesUser", FileSystemRights.Write | FileSystemRights.Read, AccessControlType.Allow, directorySecurity);
			}
			if (IsDtsInstalled(inst.isWow))
			{
				AddAccessRuleToDirectorySecurity("SQLServer2005DTSUser", FileSystemRights.Write | FileSystemRights.Read, AccessControlType.Allow, directorySecurity);
			}
			if (IsSqlBrowserInstalled(inst.isWow))
			{
				AddAccessRuleToDirectorySecurity("SQLServer2005SQLBrowserUser", FileSystemRights.Write | FileSystemRights.Read, AccessControlType.Allow, directorySecurity);
			}
		}
		else if (Constants.COMPONENT_SQL_SERVER_STRING == inst.instanceType)
		{
			AddAccessRuleToDirectorySecurity("SQLServer2005MSSQLUser" + inst.UserGroupSuffix, FileSystemRights.FullControl, AccessControlType.Allow, directorySecurity);
			AddAccessRuleToDirectorySecurity("SQLServer2005SQLAgentUser" + inst.UserGroupSuffix, FileSystemRights.FullControl, AccessControlType.Allow, directorySecurity);
		}
		else if (Constants.COMPONENT_ANALYSIS_SERVER_STRING == inst.instanceType)
		{
			AddAccessRuleToDirectorySecurity("SQLServer2005MSOLAPUser" + inst.UserGroupSuffix, FileSystemRights.Write | FileSystemRights.Read, AccessControlType.Allow, directorySecurity);
		}
		else if (Constants.COMPONENT_REPORT_SERVER_STRING == inst.instanceType)
		{
			AddAccessRuleToDirectorySecurity("SQLServer2005ReportServerUser" + inst.UserGroupSuffix, FileSystemRights.Write | FileSystemRights.Read | FileSystemRights.Delete, AccessControlType.Allow, directorySecurity);
			AddAccessRuleToDirectorySecurity("SQLServer2005ReportingServicesWebServiceUser" + inst.UserGroupSuffix, FileSystemRights.Write | FileSystemRights.Read | FileSystemRights.Delete, AccessControlType.Allow, directorySecurity);
		}
		Directory.SetAccessControl(path, directorySecurity);
		return true;
	}

	private static bool AddAccessRuleToDirectorySecurity(string identity, FileSystemRights rights, AccessControlType type, DirectorySecurity ds)
	{
		try
		{
			ds.AddAccessRule(new FileSystemAccessRule(identity, rights, type));
		}
		catch (IdentityNotMappedException ex)
		{
			STrace.LogExCatch((Exception)ex);
			return false;
		}
		catch (SystemException ex2)
		{
			STrace.LogExCatch((Exception)ex2);
			return false;
		}
		return true;
	}

	private static bool IsNSInstalled(bool wow)
	{
		string keyName = (wow ? "SOFTWARE\\Wow6432Node\\Microsoft\\Microsoft SQL Server\\90\\NS" : "SOFTWARE\\Microsoft\\Microsoft SQL Server\\90\\NS");
		return RegistryInteractor.KeyExists(Registry.LocalMachine, keyName);
	}

	private static bool IsDtsInstalled(bool wow)
	{
		string keyName = (wow ? "SOFTWARE\\Wow6432Node\\Microsoft\\Microsoft SQL Server\\90\\DTS" : "SOFTWARE\\Microsoft\\Microsoft SQL Server\\90\\DTS");
		return RegistryInteractor.KeyExists(Registry.LocalMachine, keyName);
	}

	private static bool IsSqlBrowserInstalled(bool wow)
	{
		string keyName = (wow ? "SOFTWARE\\Wow6432Node\\Microsoft\\Microsoft SQL Server\\90\\SQL Browser" : "SOFTWARE\\Microsoft\\Microsoft SQL Server\\90\\SQL Browser");
		return RegistryInteractor.KeyExists(Registry.LocalMachine, keyName);
	}

	private bool SaveValues()
	{
		int num = 0;
		while (true)
		{
			if (num < m_gridStorage.NumRows())
			{
				Instance instance = m_gridStorage.GetInstance(num);
				if (instance.canWrite)
				{
					string text = ((instance.errorDir == null) ? "" : instance.errorDir);
					if (!VerifyDirectory(text.ToString(), instance))
					{
						break;
					}
				}
				num++;
				continue;
			}
			int num2 = 0;
			while (true)
			{
				if (num2 < m_gridStorage.NumRows())
				{
					Instance instance2 = m_gridStorage.GetInstance(num2);
					if (!instance2.SaveData())
					{
						break;
					}
					num2++;
					continue;
				}
				return true;
			}
			return false;
		}
		return false;
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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
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
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0583: Unknown result type (might be due to invalid IL or missing references)
		//IL_058d: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(SqlWatsonDialog));
		featureCheckBox = new CheckBox();
		errorCheckBox = new CheckBox();
		optionsButton = new Button();
		gridPanel = new Panel();
		instanceGrid = new SqlWatsonGridControl();
		labelAboveGrid = new Label();
		labelBelowGrid = new Label();
		okButton = new Button();
		cancelButton = new Button();
		helpButton = new Button();
		separator1 = new Separator();
		panelUpper = new Panel();
		panelTopControls = new Panel();
		panelOptionsButton = new Panel();
		privacyLinkLabel = new SqlWatsonLinkLabel();
		((Control)gridPanel).SuspendLayout();
		((ISupportInitialize)instanceGrid).BeginInit();
		((Control)panelUpper).SuspendLayout();
		((Control)panelTopControls).SuspendLayout();
		((Control)panelOptionsButton).SuspendLayout();
		((Control)this).SuspendLayout();
		componentResourceManager.ApplyResources(featureCheckBox, "featureCheckBox");
		((Control)featureCheckBox).set_Name("featureCheckBox");
		((Control)featureCheckBox).set_Padding(new Padding(0, 20, 0, 0));
		featureCheckBox.add_CheckedChanged((EventHandler)featureCheckBox_CheckedChanged);
		componentResourceManager.ApplyResources(errorCheckBox, "errorCheckBox");
		((Control)errorCheckBox).set_Name("errorCheckBox");
		errorCheckBox.add_CheckedChanged((EventHandler)errorCheckBox_CheckedChanged);
		componentResourceManager.ApplyResources(optionsButton, "optionsButton");
		((Control)optionsButton).set_Name("optionsButton");
		((Control)optionsButton).add_Click((EventHandler)optionsButton_Click);
		componentResourceManager.ApplyResources(gridPanel, "gridPanel");
		((Control)gridPanel).get_Controls().Add((Control)(object)instanceGrid);
		((Control)gridPanel).get_Controls().Add((Control)(object)labelAboveGrid);
		((Control)gridPanel).get_Controls().Add((Control)(object)labelBelowGrid);
		((Control)gridPanel).set_Name("gridPanel");
		componentResourceManager.ApplyResources(instanceGrid, "instanceGrid");
		((Control)instanceGrid).set_AccessibleRole((AccessibleRole)24);
		((Control)instanceGrid).set_BackColor(SystemColors.Window);
		((Control)instanceGrid).set_Name("instanceGrid");
		componentResourceManager.ApplyResources(labelAboveGrid, "labelAboveGrid");
		((Control)labelAboveGrid).set_MaximumSize(new Size(535, 0));
		((Control)labelAboveGrid).set_Name("labelAboveGrid");
		((Control)labelAboveGrid).set_Padding(new Padding(0, 5, 0, 8));
		componentResourceManager.ApplyResources(labelBelowGrid, "labelBelowGrid");
		((Control)labelBelowGrid).set_MaximumSize(new Size(490, 0));
		((Control)labelBelowGrid).set_MinimumSize(new Size(0, 30));
		((Control)labelBelowGrid).set_Name("labelBelowGrid");
		((Control)labelBelowGrid).set_Padding(new Padding(0, 5, 0, 0));
		componentResourceManager.ApplyResources(okButton, "okButton");
		((Control)okButton).set_Name("okButton");
		((Control)okButton).add_Click((EventHandler)okButton_Click);
		componentResourceManager.ApplyResources(cancelButton, "cancelButton");
		cancelButton.set_DialogResult((DialogResult)2);
		((Control)cancelButton).set_Name("cancelButton");
		((Control)cancelButton).add_Click((EventHandler)cancelButton_Click);
		componentResourceManager.ApplyResources(helpButton, "helpButton");
		((Control)helpButton).set_Name("helpButton");
		((Control)helpButton).add_Click((EventHandler)helpButton_Click);
		componentResourceManager.ApplyResources(separator1, "separator1");
		((Control)separator1).set_Name("separator1");
		componentResourceManager.ApplyResources(panelUpper, "panelUpper");
		((Control)panelUpper).get_Controls().Add((Control)(object)panelTopControls);
		((Control)panelUpper).get_Controls().Add((Control)(object)privacyLinkLabel);
		((Control)panelUpper).set_MinimumSize(new Size(0, 224));
		((Control)panelUpper).set_Name("panelUpper");
		((Control)panelTopControls).set_BackColor(SystemColors.Control);
		((Control)panelTopControls).get_Controls().Add((Control)(object)panelOptionsButton);
		((Control)panelTopControls).get_Controls().Add((Control)(object)featureCheckBox);
		((Control)panelTopControls).get_Controls().Add((Control)(object)errorCheckBox);
		componentResourceManager.ApplyResources(panelTopControls, "panelTopControls");
		((Control)panelTopControls).set_MinimumSize(new Size(540, 0));
		((Control)panelTopControls).set_Name("panelTopControls");
		panelOptionsButton.set_AutoSizeMode((AutoSizeMode)0);
		((Control)panelOptionsButton).get_Controls().Add((Control)(object)optionsButton);
		componentResourceManager.ApplyResources(panelOptionsButton, "panelOptionsButton");
		((Control)panelOptionsButton).set_MinimumSize(new Size(0, 29));
		((Control)panelOptionsButton).set_Name("panelOptionsButton");
		componentResourceManager.ApplyResources(privacyLinkLabel, "privacyLinkLabel");
		((Control)privacyLinkLabel).set_MaximumSize(new Size(535, 0));
		((Control)privacyLinkLabel).set_MinimumSize(new Size(0, 67));
		((Control)privacyLinkLabel).set_Name("privacyLinkLabel");
		((Control)privacyLinkLabel).set_Tag((object)"");
		((LinkLabel)privacyLinkLabel).set_UseCompatibleTextRendering(true);
		((LinkLabel)privacyLinkLabel).add_LinkClicked(new LinkLabelLinkClickedEventHandler(privacyLinkLabel_LinkClicked));
		componentResourceManager.ApplyResources(this, "$this");
		((Control)this).get_Controls().Add((Control)(object)panelUpper);
		((Control)this).get_Controls().Add((Control)(object)separator1);
		((Control)this).get_Controls().Add((Control)(object)okButton);
		((Control)this).get_Controls().Add((Control)(object)cancelButton);
		((Control)this).get_Controls().Add((Control)(object)helpButton);
		((Control)this).get_Controls().Add((Control)(object)gridPanel);
		((Form)this).set_KeyPreview(true);
		((Control)this).set_Name("SqlWatsonDialog");
		((Form)this).set_SizeGripStyle((SizeGripStyle)1);
		((Control)gridPanel).ResumeLayout(false);
		((Control)gridPanel).PerformLayout();
		((ISupportInitialize)instanceGrid).EndInit();
		((Control)panelUpper).ResumeLayout(false);
		((Control)panelUpper).PerformLayout();
		((Control)panelTopControls).ResumeLayout(false);
		((Control)panelOptionsButton).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}
}
