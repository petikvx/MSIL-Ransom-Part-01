using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DnD5eSpellSorter;

public class PlayForm : Form
{
	private const int LEFT_OFFSET = 250;

	private Grid gameGrid;

	private Tile selectedTile;

	private int numberBalls = 0;

	private bool ballMoved = false;

	private string movementDirection = "";

	private IContainer components = null;

	private MenuStrip menuStripFile;

	private ToolStripMenuItem fileToolStripMenuItem;

	private ToolStripMenuItem loadToolStripMenuItem;

	private ToolStripMenuItem exitToolStripMenuItem;

	private Panel panelGenerateGrid;

	private TextBox textBoxNumberBalls;

	private Label labelNumberBalls;

	private TextBox textBoxNbrMoves;

	private Label labelNbrMoves;

	private GroupBox groupBoxAnimation;

	private CheckBox checkBoxAnimation;

	private GroupBox groupBoxSelection;

	private GroupBox groupBoxControls;

	private Button buttonRight;

	private Button buttonLeft;

	private Button buttonDown;

	private Button buttonUp;

	private OpenFileDialog dlgLoad;

	public PlayForm()
	{
		InitializeComponent();
		selectedTile = new Tile();
		((Control)selectedTile).set_Location(new Point(70, 55));
		((Control)selectedTile).BringToFront();
		((Control)groupBoxSelection).get_Controls().Add((Control)(object)selectedTile);
		((Control)textBoxNbrMoves).set_Text("0");
		((Control)textBoxNumberBalls).set_Text("0");
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
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
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
				selectedTile.AssignTyleType(-1);
				gameGrid.DeleteGrid((Form)(object)this);
				((Control)textBoxNbrMoves).set_Text("0");
				numberBalls = 0;
			}
			gameGrid = new Grid((Form)(object)this, nbrColumns, nbrRows, tileTypesSaved, 250);
			for (int i = 0; i < gameGrid.GetLength(0); i++)
			{
				for (int j = 0; j < gameGrid.GetLength(1); j++)
				{
					((Control)gameGrid[i, j]).add_Click((EventHandler)SelectBall_Click);
					if (gameGrid[i, j].TileType > 4 && gameGrid[i, j].TileType <= 8)
					{
						numberBalls++;
					}
				}
			}
			gameGrid.Timer.add_Tick((EventHandler)Timer_Tick);
			((Control)textBoxNumberBalls).set_Text(numberBalls.ToString());
		}
		catch (Exception)
		{
			MessageBox.Show("Reading file error");
		}
	}

	private void menuItemExit_Click(object sender, EventArgs e)
	{
		Form val = (Form)(object)new ControlPanelForm();
		((Control)val).Show();
		((Form)this).Close();
	}

	private void SelectBall_Click(object sender, EventArgs e)
	{
		Tile tile = (Tile)sender;
		if (tile.TileType > 4 && tile.TileType <= 8)
		{
			selectedTile.AssignTyleType(tile.TileType);
			selectedTile.Column = tile.Column;
			selectedTile.Row = tile.Row;
		}
	}

	private void ControlButton_Click(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		Button val = (Button)sender;
		if (selectedTile.TileType == -1)
		{
			MessageBox.Show("You need to select a ball first!");
		}
		else if (!checkBoxAnimation.get_Checked())
		{
			switch (((Control)val).get_Text())
			{
			default:
				throw new Exception("Something went wrong");
			case "Right":
				MoveHorizontally(1);
				break;
			case "Left":
				MoveHorizontally(-1);
				break;
			case "Down":
				MoveVertically(1);
				break;
			case "Up":
				MoveVertically(-1);
				break;
			}
			((Control)textBoxNumberBalls).set_Text(numberBalls.ToString());
			CheckIfWon();
		}
		else
		{
			movementDirection = ((Control)val).get_Text();
			if (!gameGrid.IsMoving)
			{
				gameGrid.IsMoving = true;
			}
		}
	}

	private void MoveVertically(int direction)
	{
		int i;
		for (i = selectedTile.Row; gameGrid[selectedTile.Column, i + direction].TileType == -1; i += direction)
		{
		}
		if (gameGrid[selectedTile.Column, i + direction].TileType == selectedTile.TileType - 4)
		{
			numberBalls--;
			gameGrid[selectedTile.Column, selectedTile.Row].AssignTyleType(-1);
			selectedTile.AssignTyleType(-1);
			((Control)textBoxNbrMoves).set_Text((int.Parse(((Control)textBoxNbrMoves).get_Text()) + 1).ToString());
		}
		else if (i != selectedTile.Row)
		{
			gameGrid[selectedTile.Column, selectedTile.Row].AssignTyleType(-1);
			gameGrid[selectedTile.Column, i].AssignTyleType(selectedTile.TileType);
			selectedTile.Row = i;
			((Control)textBoxNbrMoves).set_Text((int.Parse(((Control)textBoxNbrMoves).get_Text()) + 1).ToString());
		}
	}

	private void MoveHorizontally(int direction)
	{
		int i;
		for (i = selectedTile.Column; gameGrid[i + direction, selectedTile.Row].TileType == -1; i += direction)
		{
		}
		if (gameGrid[i + direction, selectedTile.Row].TileType == selectedTile.TileType - 4)
		{
			numberBalls--;
			gameGrid[selectedTile.Column, selectedTile.Row].AssignTyleType(-1);
			selectedTile.AssignTyleType(-1);
			((Control)textBoxNbrMoves).set_Text((int.Parse(((Control)textBoxNbrMoves).get_Text()) + 1).ToString());
		}
		else if (i != selectedTile.Column)
		{
			gameGrid[selectedTile.Column, selectedTile.Row].AssignTyleType(-1);
			gameGrid[i, selectedTile.Row].AssignTyleType(selectedTile.TileType);
			selectedTile.Column = i;
			((Control)textBoxNbrMoves).set_Text((int.Parse(((Control)textBoxNbrMoves).get_Text()) + 1).ToString());
		}
	}

	private void Timer_Tick(object sender, EventArgs e)
	{
		switch (movementDirection)
		{
		default:
			throw new Exception("Something went wrong");
		case "Right":
			if (gameGrid[selectedTile.Column + 1, selectedTile.Row].TileType == -1)
			{
				gameGrid[selectedTile.Column, selectedTile.Row].AssignTyleType(-1);
				gameGrid[selectedTile.Column + 1, selectedTile.Row].AssignTyleType(selectedTile.TileType);
				ballMoved = true;
				selectedTile.Column++;
			}
			else if (gameGrid[selectedTile.Column + 1, selectedTile.Row].TileType == selectedTile.TileType - 4)
			{
				gameGrid[selectedTile.Column, selectedTile.Row].AssignTyleType(-1);
				selectedTile.AssignTyleType(-1);
				numberBalls--;
				((Control)textBoxNbrMoves).set_Text((int.Parse(((Control)textBoxNbrMoves).get_Text()) + 1).ToString());
				ballMoved = false;
				gameGrid.IsMoving = false;
				CheckIfWon();
			}
			else
			{
				if (ballMoved)
				{
					((Control)textBoxNbrMoves).set_Text((int.Parse(((Control)textBoxNbrMoves).get_Text()) + 1).ToString());
					ballMoved = false;
				}
				gameGrid.IsMoving = false;
			}
			break;
		case "Left":
			if (gameGrid[selectedTile.Column - 1, selectedTile.Row].TileType == -1)
			{
				gameGrid[selectedTile.Column, selectedTile.Row].AssignTyleType(-1);
				gameGrid[selectedTile.Column - 1, selectedTile.Row].AssignTyleType(selectedTile.TileType);
				ballMoved = true;
				selectedTile.Column--;
			}
			else if (gameGrid[selectedTile.Column - 1, selectedTile.Row].TileType == selectedTile.TileType - 4)
			{
				gameGrid[selectedTile.Column, selectedTile.Row].AssignTyleType(-1);
				selectedTile.AssignTyleType(-1);
				numberBalls--;
				((Control)textBoxNbrMoves).set_Text((int.Parse(((Control)textBoxNbrMoves).get_Text()) + 1).ToString());
				ballMoved = false;
				gameGrid.IsMoving = false;
				CheckIfWon();
			}
			else
			{
				if (ballMoved)
				{
					((Control)textBoxNbrMoves).set_Text((int.Parse(((Control)textBoxNbrMoves).get_Text()) + 1).ToString());
					ballMoved = false;
				}
				gameGrid.IsMoving = false;
			}
			break;
		case "Down":
			if (gameGrid[selectedTile.Column, selectedTile.Row + 1].TileType == -1)
			{
				gameGrid[selectedTile.Column, selectedTile.Row].AssignTyleType(-1);
				gameGrid[selectedTile.Column, selectedTile.Row + 1].AssignTyleType(selectedTile.TileType);
				ballMoved = true;
				selectedTile.Row++;
			}
			else if (gameGrid[selectedTile.Column, selectedTile.Row + 1].TileType == selectedTile.TileType - 4)
			{
				gameGrid[selectedTile.Column, selectedTile.Row].AssignTyleType(-1);
				selectedTile.AssignTyleType(-1);
				numberBalls--;
				((Control)textBoxNbrMoves).set_Text((int.Parse(((Control)textBoxNbrMoves).get_Text()) + 1).ToString());
				ballMoved = false;
				gameGrid.IsMoving = false;
				CheckIfWon();
			}
			else
			{
				if (ballMoved)
				{
					((Control)textBoxNbrMoves).set_Text((int.Parse(((Control)textBoxNbrMoves).get_Text()) + 1).ToString());
					ballMoved = false;
				}
				gameGrid.IsMoving = false;
			}
			break;
		case "Up":
			if (gameGrid[selectedTile.Column, selectedTile.Row - 1].TileType == -1)
			{
				gameGrid[selectedTile.Column, selectedTile.Row].AssignTyleType(-1);
				gameGrid[selectedTile.Column, selectedTile.Row - 1].AssignTyleType(selectedTile.TileType);
				ballMoved = true;
				selectedTile.Row--;
			}
			else if (gameGrid[selectedTile.Column, selectedTile.Row - 1].TileType == selectedTile.TileType - 4)
			{
				gameGrid[selectedTile.Column, selectedTile.Row].AssignTyleType(-1);
				selectedTile.AssignTyleType(-1);
				numberBalls--;
				((Control)textBoxNbrMoves).set_Text((int.Parse(((Control)textBoxNbrMoves).get_Text()) + 1).ToString());
				ballMoved = false;
				gameGrid.IsMoving = false;
				CheckIfWon();
			}
			else
			{
				if (ballMoved)
				{
					((Control)textBoxNbrMoves).set_Text((int.Parse(((Control)textBoxNbrMoves).get_Text()) + 1).ToString());
					ballMoved = false;
				}
				gameGrid.IsMoving = false;
			}
			break;
		}
		((Control)textBoxNumberBalls).set_Text(numberBalls.ToString());
	}

	private void CheckIfWon()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		if (numberBalls == 0)
		{
			MessageBox.Show("Congratulations! You won in just " + ((Control)textBoxNbrMoves).get_Text() + " moves!\nIf you want to continue playing, load a new game.");
			gameGrid.DeleteGrid((Form)(object)this);
			((Control)textBoxNbrMoves).set_Text("0");
		}
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
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected O, but got Unknown
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Expected O, but got Unknown
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Expected O, but got Unknown
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0466: Expected O, but got Unknown
		//IL_04d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e2: Expected O, but got Unknown
		//IL_0562: Unknown result type (might be due to invalid IL or missing references)
		//IL_056c: Expected O, but got Unknown
		//IL_05f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fc: Expected O, but got Unknown
		//IL_0672: Unknown result type (might be due to invalid IL or missing references)
		//IL_067c: Expected O, but got Unknown
		//IL_074e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0758: Expected O, but got Unknown
		//IL_07d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07df: Expected O, but got Unknown
		//IL_086c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0876: Expected O, but got Unknown
		//IL_0900: Unknown result type (might be due to invalid IL or missing references)
		//IL_090a: Expected O, but got Unknown
		//IL_0994: Unknown result type (might be due to invalid IL or missing references)
		//IL_099e: Expected O, but got Unknown
		menuStripFile = new MenuStrip();
		fileToolStripMenuItem = new ToolStripMenuItem();
		loadToolStripMenuItem = new ToolStripMenuItem();
		exitToolStripMenuItem = new ToolStripMenuItem();
		panelGenerateGrid = new Panel();
		textBoxNumberBalls = new TextBox();
		labelNumberBalls = new Label();
		textBoxNbrMoves = new TextBox();
		labelNbrMoves = new Label();
		groupBoxAnimation = new GroupBox();
		checkBoxAnimation = new CheckBox();
		groupBoxSelection = new GroupBox();
		groupBoxControls = new GroupBox();
		buttonRight = new Button();
		buttonLeft = new Button();
		buttonDown = new Button();
		buttonUp = new Button();
		dlgLoad = new OpenFileDialog();
		((Control)menuStripFile).SuspendLayout();
		((Control)panelGenerateGrid).SuspendLayout();
		((Control)groupBoxAnimation).SuspendLayout();
		((Control)groupBoxControls).SuspendLayout();
		((Control)this).SuspendLayout();
		((ToolStrip)menuStripFile).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)fileToolStripMenuItem });
		((Control)menuStripFile).set_Location(new Point(0, 0));
		((Control)menuStripFile).set_Name("menuStripFile");
		((Control)menuStripFile).set_Size(new Size(809, 25));
		((Control)menuStripFile).set_TabIndex(0);
		((Control)menuStripFile).set_Text("menuStrip1");
		((ToolStripDropDownItem)fileToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)loadToolStripMenuItem,
			(ToolStripItem)exitToolStripMenuItem
		});
		((ToolStripItem)fileToolStripMenuItem).set_Font(new Font("Segoe UI", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ToolStripItem)fileToolStripMenuItem).set_Name("fileToolStripMenuItem");
		((ToolStripItem)fileToolStripMenuItem).set_Size(new Size(39, 21));
		((ToolStripItem)fileToolStripMenuItem).set_Text("File");
		((ToolStripItem)loadToolStripMenuItem).set_Name("loadToolStripMenuItem");
		((ToolStripItem)loadToolStripMenuItem).set_Size(new Size(108, 22));
		((ToolStripItem)loadToolStripMenuItem).set_Text("Load");
		((ToolStripItem)loadToolStripMenuItem).add_Click((EventHandler)menuItemLoad_Click);
		((ToolStripItem)exitToolStripMenuItem).set_Name("exitToolStripMenuItem");
		((ToolStripItem)exitToolStripMenuItem).set_Size(new Size(108, 22));
		((ToolStripItem)exitToolStripMenuItem).set_Text("Close");
		((ToolStripItem)exitToolStripMenuItem).add_Click((EventHandler)menuItemExit_Click);
		((Control)panelGenerateGrid).set_BackColor(SystemColors.ControlLight);
		panelGenerateGrid.set_BorderStyle((BorderStyle)1);
		((Control)panelGenerateGrid).get_Controls().Add((Control)(object)textBoxNumberBalls);
		((Control)panelGenerateGrid).get_Controls().Add((Control)(object)labelNumberBalls);
		((Control)panelGenerateGrid).get_Controls().Add((Control)(object)textBoxNbrMoves);
		((Control)panelGenerateGrid).get_Controls().Add((Control)(object)labelNbrMoves);
		((Control)panelGenerateGrid).set_Location(new Point(0, 29));
		((Control)panelGenerateGrid).set_Name("panelGenerateGrid");
		((Control)panelGenerateGrid).set_Size(new Size(809, 42));
		((Control)panelGenerateGrid).set_TabIndex(22);
		((Control)textBoxNumberBalls).set_Cursor(Cursors.get_IBeam());
		((Control)textBoxNumberBalls).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBoxNumberBalls).set_Location(new Point(462, 9));
		((Control)textBoxNumberBalls).set_Name("textBoxNumberBalls");
		((TextBoxBase)textBoxNumberBalls).set_ReadOnly(true);
		((Control)textBoxNumberBalls).set_Size(new Size(58, 22));
		((Control)textBoxNumberBalls).set_TabIndex(4);
		((Control)labelNumberBalls).set_AutoSize(true);
		((Control)labelNumberBalls).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)labelNumberBalls).set_Location(new Point(293, 11));
		((Control)labelNumberBalls).set_Name("labelNumberBalls");
		((Control)labelNumberBalls).set_Size(new Size(149, 16));
		((Control)labelNumberBalls).set_TabIndex(3);
		((Control)labelNumberBalls).set_Text("The number of balls left:");
		((Control)textBoxNbrMoves).set_Cursor(Cursors.get_IBeam());
		((Control)textBoxNbrMoves).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBoxNbrMoves).set_Location(new Point(181, 11));
		((Control)textBoxNbrMoves).set_Name("textBoxNbrMoves");
		((TextBoxBase)textBoxNbrMoves).set_ReadOnly(true);
		((Control)textBoxNbrMoves).set_Size(new Size(58, 22));
		((Control)textBoxNbrMoves).set_TabIndex(2);
		((Control)labelNbrMoves).set_AutoSize(true);
		((Control)labelNbrMoves).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)labelNbrMoves).set_Location(new Point(11, 11));
		((Control)labelNbrMoves).set_Name("labelNbrMoves");
		((Control)labelNbrMoves).set_Size(new Size(141, 16));
		((Control)labelNbrMoves).set_TabIndex(1);
		((Control)labelNbrMoves).set_Text("The number of moves:");
		((Control)groupBoxAnimation).get_Controls().Add((Control)(object)checkBoxAnimation);
		((Control)groupBoxAnimation).set_Font(new Font("Bernard MT Condensed", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)groupBoxAnimation).set_Location(new Point(12, 434));
		((Control)groupBoxAnimation).set_Name("groupBoxAnimation");
		((Control)groupBoxAnimation).set_Size(new Size(204, 86));
		((Control)groupBoxAnimation).set_TabIndex(25);
		groupBoxAnimation.set_TabStop(false);
		((Control)groupBoxAnimation).set_Text("Animation");
		((Control)checkBoxAnimation).set_AutoSize(true);
		((Control)checkBoxAnimation).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)checkBoxAnimation).set_Location(new Point(9, 46));
		((Control)checkBoxAnimation).set_Name("checkBoxAnimation");
		((Control)checkBoxAnimation).set_Size(new Size(169, 24));
		((Control)checkBoxAnimation).set_TabIndex(0);
		((Control)checkBoxAnimation).set_Text("Select for animation");
		((ButtonBase)checkBoxAnimation).set_UseVisualStyleBackColor(true);
		((Control)groupBoxSelection).set_Font(new Font("Bernard MT Condensed", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)groupBoxSelection).set_Location(new Point(12, 77));
		((Control)groupBoxSelection).set_Name("groupBoxSelection");
		((Control)groupBoxSelection).set_Size(new Size(204, 145));
		((Control)groupBoxSelection).set_TabIndex(24);
		groupBoxSelection.set_TabStop(false);
		((Control)groupBoxSelection).set_Text("Ball Selected");
		((Control)groupBoxControls).get_Controls().Add((Control)(object)buttonRight);
		((Control)groupBoxControls).get_Controls().Add((Control)(object)buttonLeft);
		((Control)groupBoxControls).get_Controls().Add((Control)(object)buttonDown);
		((Control)groupBoxControls).get_Controls().Add((Control)(object)buttonUp);
		((Control)groupBoxControls).set_Font(new Font("Bernard MT Condensed", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)groupBoxControls).set_Location(new Point(12, 239));
		((Control)groupBoxControls).set_Name("groupBoxControls");
		((Control)groupBoxControls).set_Size(new Size(204, 169));
		((Control)groupBoxControls).set_TabIndex(23);
		groupBoxControls.set_TabStop(false);
		((Control)groupBoxControls).set_Text("Your Controls");
		((Control)buttonRight).set_Font(new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)buttonRight).set_Location(new Point(132, 87));
		((Control)buttonRight).set_Name("buttonRight");
		((Control)buttonRight).set_Size(new Size(55, 55));
		((Control)buttonRight).set_TabIndex(3);
		((Control)buttonRight).set_Text("Right");
		((ButtonBase)buttonRight).set_UseVisualStyleBackColor(true);
		((Control)buttonRight).add_Click((EventHandler)ControlButton_Click);
		((Control)buttonLeft).set_Font(new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)buttonLeft).set_Location(new Point(9, 87));
		((Control)buttonLeft).set_Name("buttonLeft");
		((Control)buttonLeft).set_Size(new Size(55, 55));
		((Control)buttonLeft).set_TabIndex(2);
		((Control)buttonLeft).set_Text("Left");
		((ButtonBase)buttonLeft).set_UseVisualStyleBackColor(true);
		((Control)buttonLeft).add_Click((EventHandler)ControlButton_Click);
		((Control)buttonDown).set_Font(new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)buttonDown).set_Location(new Point(70, 87));
		((Control)buttonDown).set_Name("buttonDown");
		((Control)buttonDown).set_Size(new Size(55, 55));
		((Control)buttonDown).set_TabIndex(1);
		((Control)buttonDown).set_Text("Down");
		((ButtonBase)buttonDown).set_UseVisualStyleBackColor(true);
		((Control)buttonDown).add_Click((EventHandler)ControlButton_Click);
		((Control)buttonUp).set_Font(new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)buttonUp).set_Location(new Point(70, 28));
		((Control)buttonUp).set_Name("buttonUp");
		((Control)buttonUp).set_Size(new Size(55, 55));
		((Control)buttonUp).set_TabIndex(0);
		((Control)buttonUp).set_Text("Up");
		((ButtonBase)buttonUp).set_UseVisualStyleBackColor(true);
		((Control)buttonUp).add_Click((EventHandler)ControlButton_Click);
		((FileDialog)dlgLoad).set_Filter("Savegame files (*.qgame) | *.qgame");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(809, 561));
		((Control)this).get_Controls().Add((Control)(object)panelGenerateGrid);
		((Control)this).get_Controls().Add((Control)(object)groupBoxAnimation);
		((Control)this).get_Controls().Add((Control)(object)groupBoxSelection);
		((Control)this).get_Controls().Add((Control)(object)groupBoxControls);
		((Control)this).get_Controls().Add((Control)(object)menuStripFile);
		((Form)this).set_MainMenuStrip(menuStripFile);
		((Control)this).set_Name("PlayForm");
		((Control)this).set_Text("Play Form");
		((Control)menuStripFile).ResumeLayout(false);
		((Control)menuStripFile).PerformLayout();
		((Control)panelGenerateGrid).ResumeLayout(false);
		((Control)panelGenerateGrid).PerformLayout();
		((Control)groupBoxAnimation).ResumeLayout(false);
		((Control)groupBoxAnimation).PerformLayout();
		((Control)groupBoxControls).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
