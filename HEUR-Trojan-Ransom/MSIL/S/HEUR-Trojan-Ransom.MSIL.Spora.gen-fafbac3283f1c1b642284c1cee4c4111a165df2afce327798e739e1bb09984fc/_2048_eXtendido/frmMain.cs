using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace _2048_eXtendido;

public class frmMain : Form
{
	private enum Movement
	{
		Right,
		Left,
		Down,
		Up
	}

	private bool juegoGanado = false;

	private int level = 0;

	private int boardSize = 4;

	private int InitialValues = 2;

	private IContainer components = null;

	private PictureBox pbxBoard;

	private GroupBox gboxScore;

	private Label lblScore;

	private Label lblBest;

	private Label lblStep;

	private MenuStrip menuFile;

	private ToolStripMenuItem fileToolStripMenuItem;

	private ToolStripMenuItem newGameF2ToolStripMenuItem;

	private ToolStripMenuItem loadGameToolStripMenuItem;

	private ToolStripMenuItem saveGameCtrlGToolStripMenuItem;

	private ToolStripMenuItem undoCtrlzToolStripMenuItem;

	private ToolStripMenuItem helpToolStripMenuItem;

	private ToolStripMenuItem viewHelpToolStripMenuItem;

	private ToolStripMenuItem aboutToolStripMenuItem;

	private GroupBox gboxBoardSetting;

	private Button btnUndo;

	private Button btnNewGame;

	private ComboBox cboxLevel;

	private NumericUpDown nudSize;

	private Label lblLevel;

	private Label lblSize;

	private ComboBox cboxInitialValues;

	private Label lblInitialsValues;

	public frmMain()
	{
		frmHelp.a();
		InitializeComponent();
		((Form)this).set_KeyPreview(true);
		((ListControl)cboxLevel).set_SelectedIndex(0);
		((ListControl)cboxInitialValues).set_SelectedIndex(1);
		Restart_Board();
		Load_Game();
	}

	private void pbxBoard_Paint(object sender, PaintEventArgs e)
	{
		_ = new float[10] { 0f, 280f, 190f, 160f, 128f, 104f, 88f, 76f, 64f, 60f };
		((Control)pbxBoard).Focus();
	}

	private void btnNewGame_Click(object sender, EventArgs e)
	{
		Restart_Board();
	}

	private void Restart_Board()
	{
		boardSize = int.Parse(nudSize.get_Value().ToString());
		level = ((ListControl)cboxLevel).get_SelectedIndex();
		InitialValues = int.Parse(cboxInitialValues.get_SelectedItem().ToString());
	}

	private void pbxBoard_MouseClick(object sender, MouseEventArgs e)
	{
	}

	private void btnSaveGame_Click(object sender, EventArgs e)
	{
	}

	private void btnLoadGame_Click(object sender, EventArgs e)
	{
		Load_Game();
	}

	private bool Load_Game()
	{
		return true;
	}

	private void btnUndo_Click(object sender, EventArgs e)
	{
		((Control)pbxBoard).Refresh();
	}

	private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
	{
		frmHelp frmHelp2 = new frmHelp();
		((Control)frmHelp2).Show();
	}

	private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
	{
		btnSaveGame_Click(sender, (EventArgs)(object)e);
	}

	private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
	{
		frmAbout frmAbout2 = new frmAbout();
		((Control)frmAbout2).Show();
	}

	private void frmMain_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		e.get_KeyCode();
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
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected O, but got Unknown
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Expected O, but got Unknown
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Expected O, but got Unknown
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected O, but got Unknown
		//IL_07ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f8: Expected O, but got Unknown
		//IL_0cfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d04: Expected O, but got Unknown
		//IL_0d3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d46: Expected O, but got Unknown
		//IL_0d4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d58: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMain));
		pbxBoard = new PictureBox();
		gboxScore = new GroupBox();
		lblStep = new Label();
		lblBest = new Label();
		lblScore = new Label();
		menuFile = new MenuStrip();
		fileToolStripMenuItem = new ToolStripMenuItem();
		newGameF2ToolStripMenuItem = new ToolStripMenuItem();
		loadGameToolStripMenuItem = new ToolStripMenuItem();
		saveGameCtrlGToolStripMenuItem = new ToolStripMenuItem();
		undoCtrlzToolStripMenuItem = new ToolStripMenuItem();
		helpToolStripMenuItem = new ToolStripMenuItem();
		viewHelpToolStripMenuItem = new ToolStripMenuItem();
		aboutToolStripMenuItem = new ToolStripMenuItem();
		gboxBoardSetting = new GroupBox();
		cboxInitialValues = new ComboBox();
		lblInitialsValues = new Label();
		btnUndo = new Button();
		btnNewGame = new Button();
		cboxLevel = new ComboBox();
		nudSize = new NumericUpDown();
		lblLevel = new Label();
		lblSize = new Label();
		((ISupportInitialize)pbxBoard).BeginInit();
		((Control)gboxScore).SuspendLayout();
		((Control)menuFile).SuspendLayout();
		((Control)gboxBoardSetting).SuspendLayout();
		((ISupportInitialize)nudSize).BeginInit();
		((Control)this).SuspendLayout();
		((Control)pbxBoard).set_BackColor(SystemColors.ActiveBorder);
		pbxBoard.set_BorderStyle((BorderStyle)1);
		((Control)pbxBoard).set_Location(new Point(23, 27));
		((Control)pbxBoard).set_Name("pbxBoard");
		((Control)pbxBoard).set_Size(new Size(500, 500));
		pbxBoard.set_TabIndex(0);
		pbxBoard.set_TabStop(false);
		((Control)pbxBoard).add_Paint(new PaintEventHandler(pbxBoard_Paint));
		((Control)pbxBoard).add_MouseClick(new MouseEventHandler(pbxBoard_MouseClick));
		((Control)gboxScore).get_Controls().Add((Control)(object)lblStep);
		((Control)gboxScore).get_Controls().Add((Control)(object)lblBest);
		((Control)gboxScore).get_Controls().Add((Control)(object)lblScore);
		((Control)gboxScore).set_Location(new Point(538, 36));
		((Control)gboxScore).set_Name("gboxScore");
		((Control)gboxScore).set_Size(new Size(178, 105));
		((Control)gboxScore).set_TabIndex(1);
		gboxScore.set_TabStop(false);
		((Control)lblStep).set_AutoSize(true);
		((Control)lblStep).set_Font(new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblStep).set_Location(new Point(22, 79));
		((Control)lblStep).set_Name("lblStep");
		((Control)lblStep).set_Size(new Size(0, 18));
		((Control)lblStep).set_TabIndex(2);
		((Control)lblBest).set_AutoSize(true);
		((Control)lblBest).set_Font(new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblBest).set_Location(new Point(21, 50));
		((Control)lblBest).set_Name("lblBest");
		((Control)lblBest).set_Size(new Size(0, 18));
		((Control)lblBest).set_TabIndex(2);
		((Control)lblScore).set_AutoSize(true);
		((Control)lblScore).set_Font(new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblScore).set_Location(new Point(21, 19));
		((Control)lblScore).set_Name("lblScore");
		((Control)lblScore).set_Size(new Size(0, 18));
		((Control)lblScore).set_TabIndex(2);
		((ToolStrip)menuFile).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)fileToolStripMenuItem,
			(ToolStripItem)helpToolStripMenuItem
		});
		((Control)menuFile).set_Location(new Point(0, 0));
		((Control)menuFile).set_Name("menuFile");
		((Control)menuFile).set_Size(new Size(728, 24));
		((Control)menuFile).set_TabIndex(4);
		((Control)menuFile).set_Text("File");
		((ToolStripDropDownItem)fileToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[4]
		{
			(ToolStripItem)newGameF2ToolStripMenuItem,
			(ToolStripItem)loadGameToolStripMenuItem,
			(ToolStripItem)saveGameCtrlGToolStripMenuItem,
			(ToolStripItem)undoCtrlzToolStripMenuItem
		});
		((ToolStripItem)fileToolStripMenuItem).set_Name("fileToolStripMenuItem");
		((ToolStripItem)fileToolStripMenuItem).set_Size(new Size(37, 20));
		((ToolStripItem)fileToolStripMenuItem).set_Text("File");
		((ToolStripItem)newGameF2ToolStripMenuItem).set_Name("newGameF2ToolStripMenuItem");
		newGameF2ToolStripMenuItem.set_ShortcutKeys((Keys)113);
		((ToolStripItem)newGameF2ToolStripMenuItem).set_Size(new Size(177, 22));
		((ToolStripItem)newGameF2ToolStripMenuItem).set_Text("New Game");
		((ToolStripItem)newGameF2ToolStripMenuItem).add_Click((EventHandler)btnNewGame_Click);
		((ToolStripItem)loadGameToolStripMenuItem).set_Name("loadGameToolStripMenuItem");
		loadGameToolStripMenuItem.set_ShortcutKeys((Keys)131151);
		((ToolStripItem)loadGameToolStripMenuItem).set_Size(new Size(177, 22));
		((ToolStripItem)loadGameToolStripMenuItem).set_Text("Load Game");
		((ToolStripItem)loadGameToolStripMenuItem).add_Click((EventHandler)btnLoadGame_Click);
		((ToolStripItem)saveGameCtrlGToolStripMenuItem).set_Name("saveGameCtrlGToolStripMenuItem");
		saveGameCtrlGToolStripMenuItem.set_ShortcutKeys((Keys)131155);
		((ToolStripItem)saveGameCtrlGToolStripMenuItem).set_Size(new Size(177, 22));
		((ToolStripItem)saveGameCtrlGToolStripMenuItem).set_Text("Save Game");
		((ToolStripItem)saveGameCtrlGToolStripMenuItem).add_Click((EventHandler)btnSaveGame_Click);
		((ToolStripItem)undoCtrlzToolStripMenuItem).set_Name("undoCtrlzToolStripMenuItem");
		undoCtrlzToolStripMenuItem.set_ShortcutKeys((Keys)131162);
		((ToolStripItem)undoCtrlzToolStripMenuItem).set_Size(new Size(177, 22));
		((ToolStripItem)undoCtrlzToolStripMenuItem).set_Text("Undo");
		((ToolStripItem)undoCtrlzToolStripMenuItem).add_Click((EventHandler)btnUndo_Click);
		((ToolStripDropDownItem)helpToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)viewHelpToolStripMenuItem,
			(ToolStripItem)aboutToolStripMenuItem
		});
		((ToolStripItem)helpToolStripMenuItem).set_Name("helpToolStripMenuItem");
		((ToolStripItem)helpToolStripMenuItem).set_Size(new Size(44, 20));
		((ToolStripItem)helpToolStripMenuItem).set_Text("Help");
		((ToolStripItem)viewHelpToolStripMenuItem).set_Name("viewHelpToolStripMenuItem");
		viewHelpToolStripMenuItem.set_ShortcutKeys((Keys)112);
		((ToolStripItem)viewHelpToolStripMenuItem).set_Size(new Size(152, 22));
		((ToolStripItem)viewHelpToolStripMenuItem).set_Text("View Help");
		((ToolStripItem)viewHelpToolStripMenuItem).add_Click((EventHandler)viewHelpToolStripMenuItem_Click);
		((ToolStripItem)aboutToolStripMenuItem).set_Name("aboutToolStripMenuItem");
		((ToolStripItem)aboutToolStripMenuItem).set_Size(new Size(152, 22));
		((ToolStripItem)aboutToolStripMenuItem).set_Text("About");
		((ToolStripItem)aboutToolStripMenuItem).add_Click((EventHandler)aboutToolStripMenuItem_Click);
		((Control)gboxBoardSetting).get_Controls().Add((Control)(object)cboxInitialValues);
		((Control)gboxBoardSetting).get_Controls().Add((Control)(object)lblInitialsValues);
		((Control)gboxBoardSetting).get_Controls().Add((Control)(object)btnUndo);
		((Control)gboxBoardSetting).get_Controls().Add((Control)(object)btnNewGame);
		((Control)gboxBoardSetting).get_Controls().Add((Control)(object)cboxLevel);
		((Control)gboxBoardSetting).get_Controls().Add((Control)(object)nudSize);
		((Control)gboxBoardSetting).get_Controls().Add((Control)(object)lblLevel);
		((Control)gboxBoardSetting).get_Controls().Add((Control)(object)lblSize);
		((Control)gboxBoardSetting).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)gboxBoardSetting).set_Location(new Point(532, 164));
		((Control)gboxBoardSetting).set_Name("gboxBoardSetting");
		((Control)gboxBoardSetting).set_Size(new Size(190, 243));
		((Control)gboxBoardSetting).set_TabIndex(5);
		gboxBoardSetting.set_TabStop(false);
		((Control)gboxBoardSetting).set_Text("Board Setting");
		((Control)cboxInitialValues).set_Cursor(Cursors.get_Hand());
		cboxInitialValues.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)cboxInitialValues).set_FormattingEnabled(true);
		cboxInitialValues.get_Items().AddRange(new object[3] { "1", "2", "3" });
		((Control)cboxInitialValues).set_Location(new Point(128, 101));
		((Control)cboxInitialValues).set_Name("cboxInitialValues");
		((Control)cboxInitialValues).set_Size(new Size(51, 24));
		((Control)cboxInitialValues).set_TabIndex(5);
		((Control)lblInitialsValues).set_AutoSize(true);
		((Control)lblInitialsValues).set_Location(new Point(13, 104));
		((Control)lblInitialsValues).set_Name("lblInitialsValues");
		((Control)lblInitialsValues).set_Size(new Size(105, 16));
		((Control)lblInitialsValues).set_TabIndex(4);
		((Control)lblInitialsValues).set_Text("Initials Values");
		((Control)btnUndo).set_Location(new Point(47, 195));
		((Control)btnUndo).set_Name("btnUndo");
		((Control)btnUndo).set_Size(new Size(97, 23));
		((Control)btnUndo).set_TabIndex(3);
		((Control)btnUndo).set_Text("Undo");
		((ButtonBase)btnUndo).set_UseVisualStyleBackColor(true);
		((Control)btnUndo).add_Click((EventHandler)btnUndo_Click);
		((Control)btnNewGame).set_Location(new Point(47, 146));
		((Control)btnNewGame).set_Name("btnNewGame");
		((Control)btnNewGame).set_Size(new Size(97, 23));
		((Control)btnNewGame).set_TabIndex(3);
		((Control)btnNewGame).set_Text("New Game");
		((ButtonBase)btnNewGame).set_UseVisualStyleBackColor(true);
		((Control)btnNewGame).add_Click((EventHandler)btnNewGame_Click);
		((Control)cboxLevel).set_Cursor(Cursors.get_Hand());
		cboxLevel.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)cboxLevel).set_FormattingEnabled(true);
		cboxLevel.get_Items().AddRange(new object[4] { "0", "1", "2", "3" });
		((Control)cboxLevel).set_Location(new Point(128, 57));
		((Control)cboxLevel).set_Name("cboxLevel");
		((Control)cboxLevel).set_Size(new Size(51, 24));
		((Control)cboxLevel).set_TabIndex(2);
		((Control)nudSize).set_Cursor(Cursors.get_Hand());
		((Control)nudSize).set_Location(new Point(128, 23));
		nudSize.set_Maximum(new decimal(new int[4] { 16, 0, 0, 0 }));
		nudSize.set_Minimum(new decimal(new int[4] { 4, 0, 0, 0 }));
		((Control)nudSize).set_Name("nudSize");
		((Control)nudSize).set_Size(new Size(51, 22));
		((Control)nudSize).set_TabIndex(1);
		nudSize.set_Value(new decimal(new int[4] { 4, 0, 0, 0 }));
		((Control)lblLevel).set_AutoSize(true);
		((Control)lblLevel).set_Location(new Point(13, 65));
		((Control)lblLevel).set_Name("lblLevel");
		((Control)lblLevel).set_Size(new Size(46, 16));
		((Control)lblLevel).set_TabIndex(0);
		((Control)lblLevel).set_Text("Level");
		((Control)lblSize).set_AutoSize(true);
		((Control)lblSize).set_Location(new Point(13, 29));
		((Control)lblSize).set_Name("lblSize");
		((Control)lblSize).set_Size(new Size(38, 16));
		((Control)lblSize).set_TabIndex(0);
		((Control)lblSize).set_Text("Size");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(SystemColors.ActiveCaption);
		((Form)this).set_ClientSize(new Size(728, 540));
		((Control)this).get_Controls().Add((Control)(object)gboxBoardSetting);
		((Control)this).get_Controls().Add((Control)(object)gboxScore);
		((Control)this).get_Controls().Add((Control)(object)pbxBoard);
		((Control)this).get_Controls().Add((Control)(object)menuFile);
		((Control)this).set_DoubleBuffered(true);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MainMenuStrip(menuFile);
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("frmMain");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("2048_eXtendido");
		((Form)this).add_FormClosed(new FormClosedEventHandler(frmMain_FormClosed));
		((Control)this).add_KeyDown(new KeyEventHandler(frmMain_KeyDown));
		((ISupportInitialize)pbxBoard).EndInit();
		((Control)gboxScore).ResumeLayout(false);
		((Control)gboxScore).PerformLayout();
		((Control)menuFile).ResumeLayout(false);
		((Control)menuFile).PerformLayout();
		((Control)gboxBoardSetting).ResumeLayout(false);
		((Control)gboxBoardSetting).PerformLayout();
		((ISupportInitialize)nudSize).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
