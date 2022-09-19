using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DnD5eSpellSorter;

public class MazeDesignerForm : Form
{
	private const int MAX_COLUMNS = 12;

	private const int MAX_ROWS = 11;

	private const int LEFT_OFFSET = 200;

	private Grid gameGrid;

	private int selectedTileType = -1;

	private IContainer components = null;

	private MenuStrip menuStripFile;

	private ToolStripMenuItem fileToolStripMenuItem;

	private ToolStripMenuItem saveToolStripMenuItem;

	private ToolStripMenuItem loadToolStripMenuItem;

	private ToolStripMenuItem exitToolStripMenuItem;

	private Panel panelGenerateGrid;

	private Button buttonGenerate;

	private TextBox textBoxNbrRows;

	private Label labelNbrRows;

	private TextBox textBoxNbrColumns;

	private Label labelNbrColumns;

	private GroupBox groupBoxToolbox;

	private Button buttonYellowBall;

	private Button buttonWall;

	private Button buttonGreenBall;

	private Button buttonYellowDoor;

	private Button buttonBlueBalls;

	private Button buttonRedBall;

	private Button buttonGreenDoor;

	private Button buttonBlueDoor;

	private Button buttonRedDoor;

	private Button buttonNone;

	private ImageList imageListToolbox;

	private SaveFileDialog dlgSave;

	private OpenFileDialog dlgLoad;

	public MazeDesignerForm()
	{
		InitializeComponent();
	}

	private void menuItemExit_Click(object sender, EventArgs e)
	{
		Form val = (Form)(object)new ControlPanelForm();
		((Control)val).Show();
		((Form)this).Close();
	}

	private void menuItemSave_Click(object sender, EventArgs e)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected I4, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		((FileDialog)dlgSave).set_InitialDirectory(Path.GetFullPath(Path.Combine(Application.get_StartupPath(), "..\\..\\..\\Savegame")));
		DialogResult val = ((CommonDialog)dlgSave).ShowDialog();
		DialogResult val2 = val;
		DialogResult val3 = val2;
		switch ((int)val3)
		{
		case 1:
			try
			{
				if (gameGrid == null)
				{
					throw new Exception("the game layout does not exists");
				}
				string fileName = ((FileDialog)dlgSave).get_FileName();
				SaveFile(fileName);
				MessageBox.Show("File successfully saved", "QGame");
				break;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error in file save: " + ex.Message);
				break;
			}
		case 0:
		case 2:
			break;
		}
	}

	private void SaveFile(string fileName)
	{
		string text = gameGrid.GetLength(0) + ":" + gameGrid.GetLength(1);
		for (int i = 0; i < gameGrid.GetLength(0); i++)
		{
			for (int j = 0; j < gameGrid.GetLength(1); j++)
			{
				text = text + ":" + gameGrid[i, j].TileType;
			}
		}
		using StreamWriter streamWriter = new StreamWriter(fileName);
		streamWriter.Write(text);
	}

	private void menuItemLoad_Click(object sender, EventArgs e)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected I4, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		((FileDialog)dlgLoad).set_InitialDirectory(Path.GetFullPath(Path.Combine(Application.get_StartupPath(), "..\\..\\..\\Savegame")));
		DialogResult val = ((CommonDialog)dlgLoad).ShowDialog();
		DialogResult val2 = val;
		DialogResult val3 = val2;
		switch ((int)val3)
		{
		case 1:
			try
			{
				string fileName = ((FileDialog)dlgLoad).get_FileName();
				if (fileName == "")
				{
					throw new Exception("You need to choose a fileto open!");
				}
				if (!File.Exists(fileName))
				{
					throw new Exception("The file dos not exist!");
				}
				LoadFile(fileName);
				break;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error in file load: " + ex.Message);
				break;
			}
		case 0:
		case 2:
			break;
		}
	}

	private void LoadFile(string fileName)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		string text;
		using (StreamReader streamReader = new StreamReader(fileName))
		{
			if (streamReader.EndOfStream)
			{
				MessageBox.Show("The file is empty");
				return;
			}
			text = streamReader.ReadLine();
		}
		try
		{
			int num = text.IndexOf(":");
			int nbrColumns = int.Parse(text.Substring(0, num));
			int nbrRows = int.Parse(text.Substring(num + 1, text.IndexOf(":", num + 1) - num - 1));
			string[] tileTypesSaved = text.Substring(text.IndexOf(":", num + 1) + 1).Split(new char[1] { ':' });
			if (gameGrid != null)
			{
				gameGrid.DeleteGrid((Form)(object)this);
			}
			gameGrid = new Grid((Form)(object)this, nbrColumns, nbrRows, tileTypesSaved, 200);
			for (int i = 0; i < gameGrid.GetLength(0); i++)
			{
				for (int j = 0; j < gameGrid.GetLength(1); j++)
				{
					((Control)gameGrid[i, j]).add_Click((EventHandler)BuildLayout_Click);
				}
			}
		}
		catch (Exception)
		{
			MessageBox.Show("Reading file error");
		}
	}

	private void buttonGenerate_Click(object sender, EventArgs e)
	{
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		int result = 0;
		int result2 = 0;
		try
		{
			if (((Control)textBoxNbrColumns).get_Text() == "" || ((Control)textBoxNbrRows).get_Text() == "")
			{
				throw new Exception("please indicate both number of columns and number of rows");
			}
			if (!int.TryParse(((Control)textBoxNbrColumns).get_Text(), out result) || !int.TryParse(((Control)textBoxNbrRows).get_Text(), out result2))
			{
				throw new Exception("number of columns and number of rows must be integer numbers");
			}
			if (result > 12 || result2 > 11)
			{
				throw new Exception("You went over indicated dimension limits");
			}
			if (gameGrid != null)
			{
				gameGrid.DeleteGrid((Form)(object)this);
			}
			gameGrid = new Grid((Form)(object)this, result, result2, null, 200);
			for (int i = 0; i < gameGrid.GetLength(0); i++)
			{
				for (int j = 0; j < gameGrid.GetLength(1); j++)
				{
					((Control)gameGrid[i, j]).add_Click((EventHandler)BuildLayout_Click);
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show("Error: " + ex.Message);
		}
	}

	private void TileSelect_Click(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		Button val = (Button)sender;
		selectedTileType = ((ButtonBase)val).get_ImageIndex();
	}

	public void BuildLayout_Click(object sender, EventArgs e)
	{
		Tile tile = (Tile)sender;
		tile.AssignTyleType(selectedTileType);
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
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got Unknown
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Unknown result type (might be due to invalid IL or missing references)
		//IL_044d: Expected O, but got Unknown
		//IL_04d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e3: Expected O, but got Unknown
		//IL_0548: Unknown result type (might be due to invalid IL or missing references)
		//IL_0552: Expected O, but got Unknown
		//IL_05bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c9: Expected O, but got Unknown
		//IL_062e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0638: Expected O, but got Unknown
		//IL_077e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0788: Expected O, but got Unknown
		//IL_0801: Unknown result type (might be due to invalid IL or missing references)
		//IL_080b: Expected O, but got Unknown
		//IL_08d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08dd: Expected O, but got Unknown
		//IL_09a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ab: Expected O, but got Unknown
		//IL_0a73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7d: Expected O, but got Unknown
		//IL_0b44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4e: Expected O, but got Unknown
		//IL_0c16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c20: Expected O, but got Unknown
		//IL_0ce8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf2: Expected O, but got Unknown
		//IL_0db9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc3: Expected O, but got Unknown
		//IL_0e8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e94: Expected O, but got Unknown
		//IL_0f5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f65: Expected O, but got Unknown
		//IL_0ffd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1007: Expected O, but got Unknown
		//IL_116f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1179: Expected O, but got Unknown
		//IL_118a: Unknown result type (might be due to invalid IL or missing references)
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(MazeDesignerForm));
		menuStripFile = new MenuStrip();
		fileToolStripMenuItem = new ToolStripMenuItem();
		saveToolStripMenuItem = new ToolStripMenuItem();
		loadToolStripMenuItem = new ToolStripMenuItem();
		exitToolStripMenuItem = new ToolStripMenuItem();
		panelGenerateGrid = new Panel();
		buttonGenerate = new Button();
		textBoxNbrRows = new TextBox();
		labelNbrRows = new Label();
		textBoxNbrColumns = new TextBox();
		labelNbrColumns = new Label();
		groupBoxToolbox = new GroupBox();
		buttonYellowBall = new Button();
		buttonWall = new Button();
		buttonGreenBall = new Button();
		buttonYellowDoor = new Button();
		buttonBlueBalls = new Button();
		buttonRedBall = new Button();
		buttonGreenDoor = new Button();
		buttonBlueDoor = new Button();
		buttonRedDoor = new Button();
		buttonNone = new Button();
		imageListToolbox = new ImageList(components);
		dlgSave = new SaveFileDialog();
		dlgLoad = new OpenFileDialog();
		((Control)menuStripFile).SuspendLayout();
		((Control)panelGenerateGrid).SuspendLayout();
		((Control)groupBoxToolbox).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)menuStripFile).set_Font(new Font("Segoe UI", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ToolStrip)menuStripFile).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)fileToolStripMenuItem });
		((Control)menuStripFile).set_Location(new Point(0, 0));
		((Control)menuStripFile).set_Name("menuStripFile");
		((Control)menuStripFile).set_Padding(new Padding(7, 3, 0, 3));
		((Control)menuStripFile).set_Size(new Size(814, 27));
		((Control)menuStripFile).set_TabIndex(0);
		((Control)menuStripFile).set_Text("menuStrip1");
		((ToolStripDropDownItem)fileToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)saveToolStripMenuItem,
			(ToolStripItem)loadToolStripMenuItem,
			(ToolStripItem)exitToolStripMenuItem
		});
		((ToolStripItem)fileToolStripMenuItem).set_Name("fileToolStripMenuItem");
		((ToolStripItem)fileToolStripMenuItem).set_Size(new Size(39, 21));
		((ToolStripItem)fileToolStripMenuItem).set_Text("File");
		((ToolStripItem)saveToolStripMenuItem).set_Name("saveToolStripMenuItem");
		((ToolStripItem)saveToolStripMenuItem).set_Size(new Size(180, 22));
		((ToolStripItem)saveToolStripMenuItem).set_Text("Save");
		((ToolStripItem)saveToolStripMenuItem).add_Click((EventHandler)menuItemSave_Click);
		((ToolStripItem)loadToolStripMenuItem).set_Name("loadToolStripMenuItem");
		((ToolStripItem)loadToolStripMenuItem).set_Size(new Size(180, 22));
		((ToolStripItem)loadToolStripMenuItem).set_Text("Load");
		((ToolStripItem)loadToolStripMenuItem).add_Click((EventHandler)menuItemLoad_Click);
		((ToolStripItem)exitToolStripMenuItem).set_Name("exitToolStripMenuItem");
		((ToolStripItem)exitToolStripMenuItem).set_Size(new Size(180, 22));
		((ToolStripItem)exitToolStripMenuItem).set_Text("Exit");
		((ToolStripItem)exitToolStripMenuItem).add_Click((EventHandler)menuItemExit_Click);
		((Control)panelGenerateGrid).set_BackColor(SystemColors.ControlLight);
		panelGenerateGrid.set_BorderStyle((BorderStyle)1);
		((Control)panelGenerateGrid).get_Controls().Add((Control)(object)buttonGenerate);
		((Control)panelGenerateGrid).get_Controls().Add((Control)(object)textBoxNbrRows);
		((Control)panelGenerateGrid).get_Controls().Add((Control)(object)labelNbrRows);
		((Control)panelGenerateGrid).get_Controls().Add((Control)(object)textBoxNbrColumns);
		((Control)panelGenerateGrid).get_Controls().Add((Control)(object)labelNbrColumns);
		((Control)panelGenerateGrid).set_Location(new Point(1, 30));
		((Control)panelGenerateGrid).set_Name("panelGenerateGrid");
		((Control)panelGenerateGrid).set_Size(new Size(800, 42));
		((Control)panelGenerateGrid).set_TabIndex(17);
		((Control)buttonGenerate).set_BackColor(SystemColors.Control);
		((Control)buttonGenerate).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)buttonGenerate).set_Location(new Point(626, 5));
		((Control)buttonGenerate).set_Name("buttonGenerate");
		((Control)buttonGenerate).set_Size(new Size(90, 30));
		((Control)buttonGenerate).set_TabIndex(5);
		((Control)buttonGenerate).set_Text("Generate");
		((ButtonBase)buttonGenerate).set_UseVisualStyleBackColor(false);
		((Control)buttonGenerate).add_Click((EventHandler)buttonGenerate_Click);
		((Control)textBoxNbrRows).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBoxNbrRows).set_Location(new Point(501, 8));
		((Control)textBoxNbrRows).set_Name("textBoxNbrRows");
		((Control)textBoxNbrRows).set_Size(new Size(58, 22));
		((Control)textBoxNbrRows).set_TabIndex(4);
		((Control)labelNbrRows).set_AutoSize(true);
		((Control)labelNbrRows).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)labelNbrRows).set_Location(new Point(311, 12));
		((Control)labelNbrRows).set_Name("labelNbrRows");
		((Control)labelNbrRows).set_Size(new Size(184, 16));
		((Control)labelNbrRows).set_TabIndex(3);
		((Control)labelNbrRows).set_Text("Enter number of rows (1 to 11):");
		((Control)textBoxNbrColumns).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBoxNbrColumns).set_Location(new Point(223, 8));
		((Control)textBoxNbrColumns).set_Name("textBoxNbrColumns");
		((Control)textBoxNbrColumns).set_Size(new Size(58, 22));
		((Control)textBoxNbrColumns).set_TabIndex(2);
		((Control)labelNbrColumns).set_AutoSize(true);
		((Control)labelNbrColumns).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)labelNbrColumns).set_Location(new Point(11, 11));
		((Control)labelNbrColumns).set_Name("labelNbrColumns");
		((Control)labelNbrColumns).set_Size(new Size(206, 16));
		((Control)labelNbrColumns).set_TabIndex(1);
		((Control)labelNbrColumns).set_Text("Enter number of columns (1 to 12):");
		((Control)groupBoxToolbox).get_Controls().Add((Control)(object)buttonYellowBall);
		((Control)groupBoxToolbox).get_Controls().Add((Control)(object)buttonWall);
		((Control)groupBoxToolbox).get_Controls().Add((Control)(object)buttonGreenBall);
		((Control)groupBoxToolbox).get_Controls().Add((Control)(object)buttonYellowDoor);
		((Control)groupBoxToolbox).get_Controls().Add((Control)(object)buttonBlueBalls);
		((Control)groupBoxToolbox).get_Controls().Add((Control)(object)buttonRedBall);
		((Control)groupBoxToolbox).get_Controls().Add((Control)(object)buttonGreenDoor);
		((Control)groupBoxToolbox).get_Controls().Add((Control)(object)buttonBlueDoor);
		((Control)groupBoxToolbox).get_Controls().Add((Control)(object)buttonRedDoor);
		((Control)groupBoxToolbox).get_Controls().Add((Control)(object)buttonNone);
		((Control)groupBoxToolbox).set_Font(new Font("Bernard MT Condensed", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)groupBoxToolbox).set_Location(new Point(3, 78));
		((Control)groupBoxToolbox).set_Name("groupBoxToolbox");
		((Control)groupBoxToolbox).set_Size(new Size(164, 535));
		((Control)groupBoxToolbox).set_TabIndex(18);
		groupBoxToolbox.set_TabStop(false);
		((Control)groupBoxToolbox).set_Text("Your Toolbox");
		((Control)buttonYellowBall).set_Font(new Font("MS Reference Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ButtonBase)buttonYellowBall).set_ImageAlign((ContentAlignment)16);
		((ButtonBase)buttonYellowBall).set_ImageIndex(8);
		((ButtonBase)buttonYellowBall).set_ImageList(imageListToolbox);
		((Control)buttonYellowBall).set_Location(new Point(10, 480));
		((Control)buttonYellowBall).set_Name("buttonYellowBall");
		((Control)buttonYellowBall).set_Size(new Size(130, 40));
		((Control)buttonYellowBall).set_TabIndex(16);
		((Control)buttonYellowBall).set_Text("Yellow Ball");
		((ButtonBase)buttonYellowBall).set_TextAlign((ContentAlignment)64);
		((ButtonBase)buttonYellowBall).set_UseVisualStyleBackColor(true);
		((Control)buttonYellowBall).add_Click((EventHandler)TileSelect_Click);
		((Control)buttonWall).set_Font(new Font("MS Reference Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ButtonBase)buttonWall).set_ImageAlign((ContentAlignment)16);
		((ButtonBase)buttonWall).set_ImageIndex(0);
		((ButtonBase)buttonWall).set_ImageList(imageListToolbox);
		((Control)buttonWall).set_Location(new Point(10, 80));
		((Control)buttonWall).set_Name("buttonWall");
		((Control)buttonWall).set_Size(new Size(130, 40));
		((Control)buttonWall).set_TabIndex(5);
		((Control)buttonWall).set_Text("Wall");
		((ButtonBase)buttonWall).set_TextAlign((ContentAlignment)64);
		((ButtonBase)buttonWall).set_UseVisualStyleBackColor(true);
		((Control)buttonWall).add_Click((EventHandler)TileSelect_Click);
		((Control)buttonGreenBall).set_Font(new Font("MS Reference Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ButtonBase)buttonGreenBall).set_ImageAlign((ContentAlignment)16);
		((ButtonBase)buttonGreenBall).set_ImageIndex(7);
		((ButtonBase)buttonGreenBall).set_ImageList(imageListToolbox);
		((Control)buttonGreenBall).set_Location(new Point(10, 430));
		((Control)buttonGreenBall).set_Name("buttonGreenBall");
		((Control)buttonGreenBall).set_Size(new Size(130, 40));
		((Control)buttonGreenBall).set_TabIndex(15);
		((Control)buttonGreenBall).set_Text("Green Ball");
		((ButtonBase)buttonGreenBall).set_TextAlign((ContentAlignment)64);
		((ButtonBase)buttonGreenBall).set_UseVisualStyleBackColor(true);
		((Control)buttonGreenBall).add_Click((EventHandler)TileSelect_Click);
		((Control)buttonYellowDoor).set_Font(new Font("MS Reference Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ButtonBase)buttonYellowDoor).set_ImageAlign((ContentAlignment)16);
		((ButtonBase)buttonYellowDoor).set_ImageIndex(4);
		((ButtonBase)buttonYellowDoor).set_ImageList(imageListToolbox);
		((Control)buttonYellowDoor).set_Location(new Point(10, 280));
		((Control)buttonYellowDoor).set_Name("buttonYellowDoor");
		((Control)buttonYellowDoor).set_Size(new Size(130, 40));
		((Control)buttonYellowDoor).set_TabIndex(4);
		((Control)buttonYellowDoor).set_Text("Yellow Door");
		((ButtonBase)buttonYellowDoor).set_TextAlign((ContentAlignment)64);
		((ButtonBase)buttonYellowDoor).set_UseVisualStyleBackColor(true);
		((Control)buttonYellowDoor).add_Click((EventHandler)TileSelect_Click);
		((Control)buttonBlueBalls).set_Font(new Font("MS Reference Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ButtonBase)buttonBlueBalls).set_ImageAlign((ContentAlignment)16);
		((ButtonBase)buttonBlueBalls).set_ImageIndex(6);
		((ButtonBase)buttonBlueBalls).set_ImageList(imageListToolbox);
		((Control)buttonBlueBalls).set_Location(new Point(10, 380));
		((Control)buttonBlueBalls).set_Name("buttonBlueBalls");
		((Control)buttonBlueBalls).set_Size(new Size(130, 40));
		((Control)buttonBlueBalls).set_TabIndex(14);
		((Control)buttonBlueBalls).set_Text("Blue Ball");
		((ButtonBase)buttonBlueBalls).set_TextAlign((ContentAlignment)64);
		((ButtonBase)buttonBlueBalls).set_UseVisualStyleBackColor(true);
		((Control)buttonBlueBalls).add_Click((EventHandler)TileSelect_Click);
		((Control)buttonRedBall).set_Font(new Font("MS Reference Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ButtonBase)buttonRedBall).set_ImageAlign((ContentAlignment)16);
		((ButtonBase)buttonRedBall).set_ImageIndex(5);
		((ButtonBase)buttonRedBall).set_ImageList(imageListToolbox);
		((Control)buttonRedBall).set_Location(new Point(10, 330));
		((Control)buttonRedBall).set_Name("buttonRedBall");
		((Control)buttonRedBall).set_Size(new Size(130, 40));
		((Control)buttonRedBall).set_TabIndex(13);
		((Control)buttonRedBall).set_Text("Red Ball");
		((ButtonBase)buttonRedBall).set_TextAlign((ContentAlignment)64);
		((ButtonBase)buttonRedBall).set_UseVisualStyleBackColor(true);
		((Control)buttonRedBall).add_Click((EventHandler)TileSelect_Click);
		((Control)buttonGreenDoor).set_Font(new Font("MS Reference Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ButtonBase)buttonGreenDoor).set_ImageAlign((ContentAlignment)16);
		((ButtonBase)buttonGreenDoor).set_ImageIndex(3);
		((ButtonBase)buttonGreenDoor).set_ImageList(imageListToolbox);
		((Control)buttonGreenDoor).set_Location(new Point(10, 230));
		((Control)buttonGreenDoor).set_Name("buttonGreenDoor");
		((Control)buttonGreenDoor).set_Size(new Size(130, 40));
		((Control)buttonGreenDoor).set_TabIndex(3);
		((Control)buttonGreenDoor).set_Text("Green Door");
		((ButtonBase)buttonGreenDoor).set_TextAlign((ContentAlignment)64);
		((ButtonBase)buttonGreenDoor).set_UseVisualStyleBackColor(true);
		((Control)buttonGreenDoor).add_Click((EventHandler)TileSelect_Click);
		((Control)buttonBlueDoor).set_Font(new Font("MS Reference Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ButtonBase)buttonBlueDoor).set_ImageAlign((ContentAlignment)16);
		((ButtonBase)buttonBlueDoor).set_ImageIndex(2);
		((ButtonBase)buttonBlueDoor).set_ImageList(imageListToolbox);
		((Control)buttonBlueDoor).set_Location(new Point(10, 180));
		((Control)buttonBlueDoor).set_Name("buttonBlueDoor");
		((Control)buttonBlueDoor).set_Size(new Size(130, 40));
		((Control)buttonBlueDoor).set_TabIndex(2);
		((Control)buttonBlueDoor).set_Text("Blue Door");
		((ButtonBase)buttonBlueDoor).set_TextAlign((ContentAlignment)64);
		((ButtonBase)buttonBlueDoor).set_UseVisualStyleBackColor(true);
		((Control)buttonBlueDoor).add_Click((EventHandler)TileSelect_Click);
		((Control)buttonRedDoor).set_Font(new Font("MS Reference Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ButtonBase)buttonRedDoor).set_ImageAlign((ContentAlignment)16);
		((ButtonBase)buttonRedDoor).set_ImageIndex(1);
		((ButtonBase)buttonRedDoor).set_ImageList(imageListToolbox);
		((Control)buttonRedDoor).set_Location(new Point(10, 130));
		((Control)buttonRedDoor).set_Name("buttonRedDoor");
		((Control)buttonRedDoor).set_Size(new Size(130, 40));
		((Control)buttonRedDoor).set_TabIndex(1);
		((Control)buttonRedDoor).set_Text("Red Door");
		((ButtonBase)buttonRedDoor).set_TextAlign((ContentAlignment)64);
		((ButtonBase)buttonRedDoor).set_UseVisualStyleBackColor(true);
		((Control)buttonRedDoor).add_Click((EventHandler)TileSelect_Click);
		((Control)buttonNone).set_Font(new Font("MS Reference Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)buttonNone).set_Location(new Point(10, 30));
		((Control)buttonNone).set_Name("buttonNone");
		((Control)buttonNone).set_Size(new Size(130, 40));
		((Control)buttonNone).set_TabIndex(0);
		((Control)buttonNone).set_Text("None");
		((ButtonBase)buttonNone).set_TextAlign((ContentAlignment)64);
		((ButtonBase)buttonNone).set_UseVisualStyleBackColor(true);
		((Control)buttonNone).add_Click((EventHandler)TileSelect_Click);
		imageListToolbox.set_ImageStream((ImageListStreamer)componentResourceManager.GetObject("imageListToolbox.ImageStream"));
		imageListToolbox.set_TransparentColor(Color.Transparent);
		imageListToolbox.get_Images().SetKeyName(0, "Wall.png");
		imageListToolbox.get_Images().SetKeyName(1, "RedDoor.png");
		imageListToolbox.get_Images().SetKeyName(2, "BlueDoor.png");
		imageListToolbox.get_Images().SetKeyName(3, "GreenDoor.png");
		imageListToolbox.get_Images().SetKeyName(4, "YellowDoor.png");
		imageListToolbox.get_Images().SetKeyName(5, "RedBall.png");
		imageListToolbox.get_Images().SetKeyName(6, "BlueBall.png");
		imageListToolbox.get_Images().SetKeyName(7, "GreenBall.png");
		imageListToolbox.get_Images().SetKeyName(8, "YellowBall.png");
		((FileDialog)dlgSave).set_Filter("Savegame files (*.qgame) | *.qgame");
		((FileDialog)dlgLoad).set_Filter("Savegame files (*.qgame) | *.qgame");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(7f, 17f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(814, 616));
		((Control)this).get_Controls().Add((Control)(object)panelGenerateGrid);
		((Control)this).get_Controls().Add((Control)(object)groupBoxToolbox);
		((Control)this).get_Controls().Add((Control)(object)menuStripFile);
		((Control)this).set_Font(new Font("Segoe UI", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Form)this).set_MainMenuStrip(menuStripFile);
		((Form)this).set_Margin(new Padding(3, 4, 3, 4));
		((Control)this).set_Name("MazeDesignerForm");
		((Control)this).set_Text("Design Form");
		((Control)menuStripFile).ResumeLayout(false);
		((Control)menuStripFile).PerformLayout();
		((Control)panelGenerateGrid).ResumeLayout(false);
		((Control)panelGenerateGrid).PerformLayout();
		((Control)groupBoxToolbox).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
