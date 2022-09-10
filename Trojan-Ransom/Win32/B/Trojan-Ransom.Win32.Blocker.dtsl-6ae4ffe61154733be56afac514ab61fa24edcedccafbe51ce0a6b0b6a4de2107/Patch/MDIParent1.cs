using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Patch;

public class MDIParent1 : Form
{
	private int int_0 = 0;

	private IContainer icontainer_0 = null;

	private MenuStrip menuStrip;

	private ToolStrip toolStrip;

	private StatusStrip statusStrip;

	private ToolStripSeparator toolStripSeparator1;

	private ToolStripSeparator toolStripSeparator2;

	private ToolStripSeparator toolStripSeparator3;

	private ToolStripSeparator toolStripSeparator4;

	private ToolStripSeparator toolStripSeparator5;

	private ToolStripSeparator toolStripSeparator6;

	private ToolStripMenuItem printSetupToolStripMenuItem;

	private ToolStripSeparator toolStripSeparator7;

	private ToolStripSeparator toolStripSeparator8;

	private ToolStripStatusLabel toolStripStatusLabel;

	private ToolStripMenuItem aboutToolStripMenuItem;

	private ToolStripMenuItem tileHorizontalToolStripMenuItem;

	private ToolStripMenuItem fileMenu;

	private ToolStripMenuItem newToolStripMenuItem;

	private ToolStripMenuItem openToolStripMenuItem;

	private ToolStripMenuItem saveToolStripMenuItem;

	private ToolStripMenuItem saveAsToolStripMenuItem;

	private ToolStripMenuItem printToolStripMenuItem;

	private ToolStripMenuItem printPreviewToolStripMenuItem;

	private ToolStripMenuItem exitToolStripMenuItem;

	private ToolStripMenuItem editMenu;

	private ToolStripMenuItem undoToolStripMenuItem;

	private ToolStripMenuItem redoToolStripMenuItem;

	private ToolStripMenuItem cutToolStripMenuItem;

	private ToolStripMenuItem copyToolStripMenuItem;

	private ToolStripMenuItem pasteToolStripMenuItem;

	private ToolStripMenuItem selectAllToolStripMenuItem;

	private ToolStripMenuItem viewMenu;

	private ToolStripMenuItem toolBarToolStripMenuItem;

	private ToolStripMenuItem statusBarToolStripMenuItem;

	private ToolStripMenuItem toolsMenu;

	private ToolStripMenuItem optionsToolStripMenuItem;

	private ToolStripMenuItem windowsMenu;

	private ToolStripMenuItem newWindowToolStripMenuItem;

	private ToolStripMenuItem cascadeToolStripMenuItem;

	private ToolStripMenuItem tileVerticalToolStripMenuItem;

	private ToolStripMenuItem closeAllToolStripMenuItem;

	private ToolStripMenuItem arrangeIconsToolStripMenuItem;

	private ToolStripMenuItem helpMenu;

	private ToolStripMenuItem contentsToolStripMenuItem;

	private ToolStripMenuItem indexToolStripMenuItem;

	private ToolStripMenuItem searchToolStripMenuItem;

	private ToolStripButton newToolStripButton;

	private ToolStripButton openToolStripButton;

	private ToolStripButton saveToolStripButton;

	private ToolStripButton printToolStripButton;

	private ToolStripButton printPreviewToolStripButton;

	private ToolStripButton helpToolStripButton;

	private ToolTip toolTip_0;

	public MDIParent1()
	{
		InitializeComponent();
	}

	private void newToolStripButton_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		Form val = new Form();
		val.set_MdiParent((Form)(object)this);
		((Control)val).set_Text("Window " + int_0++);
		((Control)val).Show();
	}

	private void openToolStripButton_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		OpenFileDialog val = new OpenFileDialog();
		((FileDialog)val).set_InitialDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Personal));
		((FileDialog)val).set_Filter("Text Files (*.txt)|*.txt|All Files (*.*)|*.*");
		if ((int)((CommonDialog)val).ShowDialog((IWin32Window)(object)this) == 1)
		{
			((FileDialog)val).get_FileName();
		}
	}

	private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		SaveFileDialog val = new SaveFileDialog();
		((FileDialog)val).set_InitialDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Personal));
		((FileDialog)val).set_Filter("Text Files (*.txt)|*.txt|All Files (*.*)|*.*");
		if ((int)((CommonDialog)val).ShowDialog((IWin32Window)(object)this) == 1)
		{
			((FileDialog)val).get_FileName();
		}
	}

	private void exitToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void cutToolStripMenuItem_Click(object sender, EventArgs e)
	{
	}

	private void copyToolStripMenuItem_Click(object sender, EventArgs e)
	{
	}

	private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
	{
	}

	private void toolBarToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Control)toolStrip).set_Visible(toolBarToolStripMenuItem.get_Checked());
	}

	private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Control)statusStrip).set_Visible(statusBarToolStripMenuItem.get_Checked());
	}

	private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Form)this).LayoutMdi((MdiLayout)0);
	}

	private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Form)this).LayoutMdi((MdiLayout)2);
	}

	private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Form)this).LayoutMdi((MdiLayout)1);
	}

	private void arrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Form)this).LayoutMdi((MdiLayout)3);
	}

	private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Form[] mdiChildren = ((Form)this).get_MdiChildren();
		foreach (Form val in mdiChildren)
		{
			val.Close();
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
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
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected O, but got Unknown
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected O, but got Unknown
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected O, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected O, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_03f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Expected O, but got Unknown
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Expected O, but got Unknown
		//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f5: Expected O, but got Unknown
		//IL_058d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Expected O, but got Unknown
		//IL_05e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f2: Expected O, but got Unknown
		//IL_071a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0724: Expected O, but got Unknown
		//IL_0775: Unknown result type (might be due to invalid IL or missing references)
		//IL_077f: Expected O, but got Unknown
		//IL_07e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ea: Expected O, but got Unknown
		//IL_0852: Unknown result type (might be due to invalid IL or missing references)
		//IL_085c: Expected O, but got Unknown
		//IL_08c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ce: Expected O, but got Unknown
		//IL_0d24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2e: Expected O, but got Unknown
		//IL_0d6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d79: Expected O, but got Unknown
		//IL_0eac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb6: Expected O, but got Unknown
		//IL_0f1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f24: Expected O, but got Unknown
		//IL_0f88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f92: Expected O, but got Unknown
		//IL_0fef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff9: Expected O, but got Unknown
		//IL_1046: Unknown result type (might be due to invalid IL or missing references)
		//IL_1050: Expected O, but got Unknown
		//IL_10ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b7: Expected O, but got Unknown
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(MDIParent1));
		menuStrip = new MenuStrip();
		fileMenu = new ToolStripMenuItem();
		newToolStripMenuItem = new ToolStripMenuItem();
		openToolStripMenuItem = new ToolStripMenuItem();
		toolStripSeparator3 = new ToolStripSeparator();
		saveToolStripMenuItem = new ToolStripMenuItem();
		saveAsToolStripMenuItem = new ToolStripMenuItem();
		toolStripSeparator4 = new ToolStripSeparator();
		printToolStripMenuItem = new ToolStripMenuItem();
		printPreviewToolStripMenuItem = new ToolStripMenuItem();
		printSetupToolStripMenuItem = new ToolStripMenuItem();
		toolStripSeparator5 = new ToolStripSeparator();
		exitToolStripMenuItem = new ToolStripMenuItem();
		editMenu = new ToolStripMenuItem();
		undoToolStripMenuItem = new ToolStripMenuItem();
		redoToolStripMenuItem = new ToolStripMenuItem();
		toolStripSeparator6 = new ToolStripSeparator();
		cutToolStripMenuItem = new ToolStripMenuItem();
		copyToolStripMenuItem = new ToolStripMenuItem();
		pasteToolStripMenuItem = new ToolStripMenuItem();
		toolStripSeparator7 = new ToolStripSeparator();
		selectAllToolStripMenuItem = new ToolStripMenuItem();
		viewMenu = new ToolStripMenuItem();
		toolBarToolStripMenuItem = new ToolStripMenuItem();
		statusBarToolStripMenuItem = new ToolStripMenuItem();
		toolsMenu = new ToolStripMenuItem();
		optionsToolStripMenuItem = new ToolStripMenuItem();
		windowsMenu = new ToolStripMenuItem();
		newWindowToolStripMenuItem = new ToolStripMenuItem();
		cascadeToolStripMenuItem = new ToolStripMenuItem();
		tileVerticalToolStripMenuItem = new ToolStripMenuItem();
		tileHorizontalToolStripMenuItem = new ToolStripMenuItem();
		closeAllToolStripMenuItem = new ToolStripMenuItem();
		arrangeIconsToolStripMenuItem = new ToolStripMenuItem();
		helpMenu = new ToolStripMenuItem();
		contentsToolStripMenuItem = new ToolStripMenuItem();
		indexToolStripMenuItem = new ToolStripMenuItem();
		searchToolStripMenuItem = new ToolStripMenuItem();
		toolStripSeparator8 = new ToolStripSeparator();
		aboutToolStripMenuItem = new ToolStripMenuItem();
		toolStrip = new ToolStrip();
		newToolStripButton = new ToolStripButton();
		openToolStripButton = new ToolStripButton();
		saveToolStripButton = new ToolStripButton();
		toolStripSeparator1 = new ToolStripSeparator();
		printToolStripButton = new ToolStripButton();
		printPreviewToolStripButton = new ToolStripButton();
		toolStripSeparator2 = new ToolStripSeparator();
		helpToolStripButton = new ToolStripButton();
		statusStrip = new StatusStrip();
		toolStripStatusLabel = new ToolStripStatusLabel();
		toolTip_0 = new ToolTip(icontainer_0);
		((Control)menuStrip).SuspendLayout();
		((Control)toolStrip).SuspendLayout();
		((Control)statusStrip).SuspendLayout();
		((Control)this).SuspendLayout();
		((ToolStrip)menuStrip).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)fileMenu,
			(ToolStripItem)editMenu,
			(ToolStripItem)viewMenu,
			(ToolStripItem)toolsMenu,
			(ToolStripItem)windowsMenu,
			(ToolStripItem)helpMenu
		});
		((Control)menuStrip).set_Location(new Point(0, 0));
		menuStrip.set_MdiWindowListItem(windowsMenu);
		((Control)menuStrip).set_Name("menuStrip");
		((Control)menuStrip).set_Size(new Size(632, 24));
		((Control)menuStrip).set_TabIndex(0);
		((Control)menuStrip).set_Text("MenuStrip");
		((ToolStripDropDownItem)fileMenu).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[11]
		{
			(ToolStripItem)newToolStripMenuItem,
			(ToolStripItem)openToolStripMenuItem,
			(ToolStripItem)toolStripSeparator3,
			(ToolStripItem)saveToolStripMenuItem,
			(ToolStripItem)saveAsToolStripMenuItem,
			(ToolStripItem)toolStripSeparator4,
			(ToolStripItem)printToolStripMenuItem,
			(ToolStripItem)printPreviewToolStripMenuItem,
			(ToolStripItem)printSetupToolStripMenuItem,
			(ToolStripItem)toolStripSeparator5,
			(ToolStripItem)exitToolStripMenuItem
		});
		((ToolStripItem)fileMenu).set_ImageTransparentColor(SystemColors.ActiveBorder);
		((ToolStripItem)fileMenu).set_Name("fileMenu");
		((ToolStripItem)fileMenu).set_Text("&File");
		((ToolStripItem)newToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("newToolStripMenuItem.Image"));
		((ToolStripItem)newToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)newToolStripMenuItem).set_Name("newToolStripMenuItem");
		newToolStripMenuItem.set_ShortcutKeys((Keys)131150);
		((ToolStripItem)newToolStripMenuItem).set_Text("&New");
		((ToolStripItem)newToolStripMenuItem).add_Click((EventHandler)newToolStripButton_Click);
		((ToolStripItem)openToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("openToolStripMenuItem.Image"));
		((ToolStripItem)openToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)openToolStripMenuItem).set_Name("openToolStripMenuItem");
		openToolStripMenuItem.set_ShortcutKeys((Keys)131151);
		((ToolStripItem)openToolStripMenuItem).set_Text("&Open");
		((ToolStripItem)openToolStripMenuItem).add_Click((EventHandler)openToolStripButton_Click);
		((ToolStripItem)toolStripSeparator3).set_Name("toolStripSeparator3");
		((ToolStripItem)saveToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("saveToolStripMenuItem.Image"));
		((ToolStripItem)saveToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)saveToolStripMenuItem).set_Name("saveToolStripMenuItem");
		saveToolStripMenuItem.set_ShortcutKeys((Keys)131155);
		((ToolStripItem)saveToolStripMenuItem).set_Text("&Save");
		((ToolStripItem)saveAsToolStripMenuItem).set_Name("saveAsToolStripMenuItem");
		((ToolStripItem)saveAsToolStripMenuItem).set_Text("Save &As");
		((ToolStripItem)saveAsToolStripMenuItem).add_Click((EventHandler)saveAsToolStripMenuItem_Click);
		((ToolStripItem)toolStripSeparator4).set_Name("toolStripSeparator4");
		((ToolStripItem)printToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("printToolStripMenuItem.Image"));
		((ToolStripItem)printToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)printToolStripMenuItem).set_Name("printToolStripMenuItem");
		printToolStripMenuItem.set_ShortcutKeys((Keys)131152);
		((ToolStripItem)printToolStripMenuItem).set_Text("&Print");
		((ToolStripItem)printPreviewToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("printPreviewToolStripMenuItem.Image"));
		((ToolStripItem)printPreviewToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)printPreviewToolStripMenuItem).set_Name("printPreviewToolStripMenuItem");
		((ToolStripItem)printPreviewToolStripMenuItem).set_Text("Print Pre&view");
		((ToolStripItem)printSetupToolStripMenuItem).set_Name("printSetupToolStripMenuItem");
		((ToolStripItem)printSetupToolStripMenuItem).set_Text("Print Setup");
		((ToolStripItem)toolStripSeparator5).set_Name("toolStripSeparator5");
		((ToolStripItem)exitToolStripMenuItem).set_Name("exitToolStripMenuItem");
		((ToolStripItem)exitToolStripMenuItem).set_Text("E&xit");
		((ToolStripItem)exitToolStripMenuItem).add_Click((EventHandler)exitToolStripMenuItem_Click);
		((ToolStripDropDownItem)editMenu).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)undoToolStripMenuItem,
			(ToolStripItem)redoToolStripMenuItem,
			(ToolStripItem)toolStripSeparator6,
			(ToolStripItem)cutToolStripMenuItem,
			(ToolStripItem)copyToolStripMenuItem,
			(ToolStripItem)pasteToolStripMenuItem,
			(ToolStripItem)toolStripSeparator7,
			(ToolStripItem)selectAllToolStripMenuItem
		});
		((ToolStripItem)editMenu).set_Name("editMenu");
		((ToolStripItem)editMenu).set_Text("&Edit");
		((ToolStripItem)undoToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("undoToolStripMenuItem.Image"));
		((ToolStripItem)undoToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)undoToolStripMenuItem).set_Name("undoToolStripMenuItem");
		undoToolStripMenuItem.set_ShortcutKeys((Keys)131162);
		((ToolStripItem)undoToolStripMenuItem).set_Text("&Undo");
		((ToolStripItem)redoToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("redoToolStripMenuItem.Image"));
		((ToolStripItem)redoToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)redoToolStripMenuItem).set_Name("redoToolStripMenuItem");
		redoToolStripMenuItem.set_ShortcutKeys((Keys)131161);
		((ToolStripItem)redoToolStripMenuItem).set_Text("&Redo");
		((ToolStripItem)toolStripSeparator6).set_Name("toolStripSeparator6");
		((ToolStripItem)cutToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("cutToolStripMenuItem.Image"));
		((ToolStripItem)cutToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)cutToolStripMenuItem).set_Name("cutToolStripMenuItem");
		cutToolStripMenuItem.set_ShortcutKeys((Keys)131160);
		((ToolStripItem)cutToolStripMenuItem).set_Text("Cu&t");
		((ToolStripItem)cutToolStripMenuItem).add_Click((EventHandler)cutToolStripMenuItem_Click);
		((ToolStripItem)copyToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("copyToolStripMenuItem.Image"));
		((ToolStripItem)copyToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)copyToolStripMenuItem).set_Name("copyToolStripMenuItem");
		copyToolStripMenuItem.set_ShortcutKeys((Keys)131139);
		((ToolStripItem)copyToolStripMenuItem).set_Text("&Copy");
		((ToolStripItem)copyToolStripMenuItem).add_Click((EventHandler)copyToolStripMenuItem_Click);
		((ToolStripItem)pasteToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("pasteToolStripMenuItem.Image"));
		((ToolStripItem)pasteToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)pasteToolStripMenuItem).set_Name("pasteToolStripMenuItem");
		pasteToolStripMenuItem.set_ShortcutKeys((Keys)131158);
		((ToolStripItem)pasteToolStripMenuItem).set_Text("&Paste");
		((ToolStripItem)pasteToolStripMenuItem).add_Click((EventHandler)pasteToolStripMenuItem_Click);
		((ToolStripItem)toolStripSeparator7).set_Name("toolStripSeparator7");
		((ToolStripItem)selectAllToolStripMenuItem).set_Name("selectAllToolStripMenuItem");
		selectAllToolStripMenuItem.set_ShortcutKeys((Keys)131137);
		((ToolStripItem)selectAllToolStripMenuItem).set_Text("Select &All");
		((ToolStripDropDownItem)viewMenu).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)toolBarToolStripMenuItem,
			(ToolStripItem)statusBarToolStripMenuItem
		});
		((ToolStripItem)viewMenu).set_Name("viewMenu");
		((ToolStripItem)viewMenu).set_Text("&View");
		toolBarToolStripMenuItem.set_Checked(true);
		toolBarToolStripMenuItem.set_CheckOnClick(true);
		toolBarToolStripMenuItem.set_CheckState((CheckState)1);
		((ToolStripItem)toolBarToolStripMenuItem).set_Name("toolBarToolStripMenuItem");
		((ToolStripItem)toolBarToolStripMenuItem).set_Text("&Toolbar");
		((ToolStripItem)toolBarToolStripMenuItem).add_Click((EventHandler)toolBarToolStripMenuItem_Click);
		statusBarToolStripMenuItem.set_Checked(true);
		statusBarToolStripMenuItem.set_CheckOnClick(true);
		statusBarToolStripMenuItem.set_CheckState((CheckState)1);
		((ToolStripItem)statusBarToolStripMenuItem).set_Name("statusBarToolStripMenuItem");
		((ToolStripItem)statusBarToolStripMenuItem).set_Text("&Status Bar");
		((ToolStripItem)statusBarToolStripMenuItem).add_Click((EventHandler)statusBarToolStripMenuItem_Click);
		((ToolStripDropDownItem)toolsMenu).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)optionsToolStripMenuItem });
		((ToolStripItem)toolsMenu).set_Name("toolsMenu");
		((ToolStripItem)toolsMenu).set_Text("&Tools");
		((ToolStripItem)optionsToolStripMenuItem).set_Name("optionsToolStripMenuItem");
		((ToolStripItem)optionsToolStripMenuItem).set_Text("&Options");
		((ToolStripDropDownItem)windowsMenu).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)newWindowToolStripMenuItem,
			(ToolStripItem)cascadeToolStripMenuItem,
			(ToolStripItem)tileVerticalToolStripMenuItem,
			(ToolStripItem)tileHorizontalToolStripMenuItem,
			(ToolStripItem)closeAllToolStripMenuItem,
			(ToolStripItem)arrangeIconsToolStripMenuItem
		});
		((ToolStripItem)windowsMenu).set_Name("windowsMenu");
		((ToolStripItem)windowsMenu).set_Text("&Windows");
		((ToolStripItem)newWindowToolStripMenuItem).set_Name("newWindowToolStripMenuItem");
		((ToolStripItem)newWindowToolStripMenuItem).set_Text("&New Window");
		((ToolStripItem)newWindowToolStripMenuItem).add_Click((EventHandler)newToolStripButton_Click);
		((ToolStripItem)cascadeToolStripMenuItem).set_Name("cascadeToolStripMenuItem");
		((ToolStripItem)cascadeToolStripMenuItem).set_Text("&Cascade");
		((ToolStripItem)cascadeToolStripMenuItem).add_Click((EventHandler)cascadeToolStripMenuItem_Click);
		((ToolStripItem)tileVerticalToolStripMenuItem).set_Name("tileVerticalToolStripMenuItem");
		((ToolStripItem)tileVerticalToolStripMenuItem).set_Text("Tile &Vertical");
		((ToolStripItem)tileVerticalToolStripMenuItem).add_Click((EventHandler)tileVerticalToolStripMenuItem_Click);
		((ToolStripItem)tileHorizontalToolStripMenuItem).set_Name("tileHorizontalToolStripMenuItem");
		((ToolStripItem)tileHorizontalToolStripMenuItem).set_Text("Tile &Horizontal");
		((ToolStripItem)tileHorizontalToolStripMenuItem).add_Click((EventHandler)tileHorizontalToolStripMenuItem_Click);
		((ToolStripItem)closeAllToolStripMenuItem).set_Name("closeAllToolStripMenuItem");
		((ToolStripItem)closeAllToolStripMenuItem).set_Text("C&lose All");
		((ToolStripItem)closeAllToolStripMenuItem).add_Click((EventHandler)closeAllToolStripMenuItem_Click);
		((ToolStripItem)arrangeIconsToolStripMenuItem).set_Name("arrangeIconsToolStripMenuItem");
		((ToolStripItem)arrangeIconsToolStripMenuItem).set_Text("&Arrange Icons");
		((ToolStripItem)arrangeIconsToolStripMenuItem).add_Click((EventHandler)arrangeIconsToolStripMenuItem_Click);
		((ToolStripDropDownItem)helpMenu).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)contentsToolStripMenuItem,
			(ToolStripItem)indexToolStripMenuItem,
			(ToolStripItem)searchToolStripMenuItem,
			(ToolStripItem)toolStripSeparator8,
			(ToolStripItem)aboutToolStripMenuItem
		});
		((ToolStripItem)helpMenu).set_Name("helpMenu");
		((ToolStripItem)helpMenu).set_Text("&Help");
		((ToolStripItem)contentsToolStripMenuItem).set_Name("contentsToolStripMenuItem");
		contentsToolStripMenuItem.set_ShortcutKeys((Keys)131184);
		((ToolStripItem)contentsToolStripMenuItem).set_Text("&Contents");
		((ToolStripItem)indexToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("indexToolStripMenuItem.Image"));
		((ToolStripItem)indexToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)indexToolStripMenuItem).set_Name("indexToolStripMenuItem");
		((ToolStripItem)indexToolStripMenuItem).set_Text("&Index");
		((ToolStripItem)searchToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("searchToolStripMenuItem.Image"));
		((ToolStripItem)searchToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)searchToolStripMenuItem).set_Name("searchToolStripMenuItem");
		((ToolStripItem)searchToolStripMenuItem).set_Text("&Search");
		((ToolStripItem)toolStripSeparator8).set_Name("toolStripSeparator8");
		((ToolStripItem)aboutToolStripMenuItem).set_Name("aboutToolStripMenuItem");
		((ToolStripItem)aboutToolStripMenuItem).set_Text("&About ... ...");
		toolStrip.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)newToolStripButton,
			(ToolStripItem)openToolStripButton,
			(ToolStripItem)saveToolStripButton,
			(ToolStripItem)toolStripSeparator1,
			(ToolStripItem)printToolStripButton,
			(ToolStripItem)printPreviewToolStripButton,
			(ToolStripItem)toolStripSeparator2,
			(ToolStripItem)helpToolStripButton
		});
		((Control)toolStrip).set_Location(new Point(0, 24));
		((Control)toolStrip).set_Name("toolStrip");
		((Control)toolStrip).set_Size(new Size(632, 25));
		((Control)toolStrip).set_TabIndex(1);
		((Control)toolStrip).set_Text("ToolStrip");
		((ToolStripItem)newToolStripButton).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)newToolStripButton).set_Image((Image)componentResourceManager.GetObject("newToolStripButton.Image"));
		((ToolStripItem)newToolStripButton).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)newToolStripButton).set_Name("newToolStripButton");
		((ToolStripItem)newToolStripButton).set_Text("New");
		((ToolStripItem)newToolStripButton).add_Click((EventHandler)newToolStripButton_Click);
		((ToolStripItem)openToolStripButton).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)openToolStripButton).set_Image((Image)componentResourceManager.GetObject("openToolStripButton.Image"));
		((ToolStripItem)openToolStripButton).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)openToolStripButton).set_Name("openToolStripButton");
		((ToolStripItem)openToolStripButton).set_Text("Open");
		((ToolStripItem)openToolStripButton).add_Click((EventHandler)openToolStripButton_Click);
		((ToolStripItem)saveToolStripButton).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)saveToolStripButton).set_Image((Image)componentResourceManager.GetObject("saveToolStripButton.Image"));
		((ToolStripItem)saveToolStripButton).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)saveToolStripButton).set_Name("saveToolStripButton");
		((ToolStripItem)saveToolStripButton).set_Text("Save");
		((ToolStripItem)toolStripSeparator1).set_Name("toolStripSeparator1");
		((ToolStripItem)printToolStripButton).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)printToolStripButton).set_Image((Image)componentResourceManager.GetObject("printToolStripButton.Image"));
		((ToolStripItem)printToolStripButton).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)printToolStripButton).set_Name("printToolStripButton");
		((ToolStripItem)printToolStripButton).set_Text("Print");
		((ToolStripItem)printPreviewToolStripButton).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)printPreviewToolStripButton).set_Image((Image)componentResourceManager.GetObject("printPreviewToolStripButton.Image"));
		((ToolStripItem)printPreviewToolStripButton).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)printPreviewToolStripButton).set_Name("printPreviewToolStripButton");
		((ToolStripItem)printPreviewToolStripButton).set_Text("Print Preview");
		((ToolStripItem)toolStripSeparator2).set_Name("toolStripSeparator2");
		((ToolStripItem)helpToolStripButton).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)helpToolStripButton).set_Image((Image)componentResourceManager.GetObject("helpToolStripButton.Image"));
		((ToolStripItem)helpToolStripButton).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)helpToolStripButton).set_Name("helpToolStripButton");
		((ToolStripItem)helpToolStripButton).set_Text("Help");
		((ToolStrip)statusStrip).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)toolStripStatusLabel });
		statusStrip.set_LayoutStyle((ToolStripLayoutStyle)4);
		((Control)statusStrip).set_Location(new Point(0, 433));
		((Control)statusStrip).set_Name("statusStrip");
		((Control)statusStrip).set_Size(new Size(632, 20));
		((Control)statusStrip).set_TabIndex(2);
		((Control)statusStrip).set_Text("StatusStrip");
		((ToolStripItem)toolStripStatusLabel).set_Name("toolStripStatusLabel");
		((ToolStripItem)toolStripStatusLabel).set_Text("Status");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(632, 453));
		((Control)this).get_Controls().Add((Control)(object)statusStrip);
		((Control)this).get_Controls().Add((Control)(object)toolStrip);
		((Control)this).get_Controls().Add((Control)(object)menuStrip);
		((Form)this).set_IsMdiContainer(true);
		((Form)this).set_MainMenuStrip(menuStrip);
		((Control)this).set_Name("MDIParent1");
		((Control)this).set_Text("MDIParent1");
		((Control)menuStrip).ResumeLayout(false);
		((Control)toolStrip).ResumeLayout(false);
		((Control)statusStrip).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
