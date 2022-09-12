using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Snake;

public class Snake : UserControl, IMessageFilter
{
	private SnakePlayer Player1;

	private FoodManager FoodMngr;

	private Random r = new Random();

	private int score = 0;

	private IContainer components = null;

	private PictureBox GameCanvas;

	private Timer GameTimer;

	private Button Start_Btn;

	private Button DareBtn;

	private TextBox ScoreTxtBox;

	private Label ScoreLbl;

	private Button btn_Home;

	private Label lbl_Game;

	public mainForm homeForm { get; set; }

	public Snake()
	{
		InitializeComponent();
		Application.AddMessageFilter((IMessageFilter)(object)this);
		Player1 = new SnakePlayer(this);
		FoodMngr = new FoodManager(((Control)GameCanvas).get_Width(), ((Control)GameCanvas).get_Height());
		FoodMngr.AddRandomFood(10);
		((Control)ScoreTxtBox).set_Text(score.ToString());
	}

	public void ToggleTimer()
	{
		GameTimer.set_Enabled(!GameTimer.get_Enabled());
	}

	public void ResetGame()
	{
		((Control)homeForm).Show();
		homeForm.GameOver();
		Player1 = new SnakePlayer(this);
		FoodMngr = new FoodManager(((Control)GameCanvas).get_Width(), ((Control)GameCanvas).get_Height());
		FoodMngr.AddRandomFood(10);
		score = 0;
	}

	public bool PreFilterMessage(ref Message msg)
	{
		if (((Message)(ref msg)).get_Msg() == 257)
		{
			Input.SetKey((Keys)(int)((Message)(ref msg)).get_WParam(), IsDown: false);
		}
		return false;
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		if (((Message)(ref msg)).get_Msg() == 256)
		{
			Input.SetKey((Keys)(int)((Message)(ref msg)).get_WParam(), IsDown: true);
		}
		return ((ContainerControl)this).ProcessCmdKey(ref msg, keyData);
	}

	private void GameCanvas_Paint(object sender, PaintEventArgs e)
	{
		Graphics graphics = e.get_Graphics();
		Player1.Draw(graphics);
		FoodMngr.Draw(graphics);
	}

	private void CheckForCollisions()
	{
		if (Player1.IsIntersectingRect(new Rectangle(-100, 0, 100, ((Control)GameCanvas).get_Height())))
		{
			Player1.OnHitWall(Direction.left);
		}
		if (Player1.IsIntersectingRect(new Rectangle(0, -100, ((Control)GameCanvas).get_Width(), 100)))
		{
			Player1.OnHitWall(Direction.up);
		}
		if (Player1.IsIntersectingRect(new Rectangle(((Control)GameCanvas).get_Width(), 0, 100, ((Control)GameCanvas).get_Height())))
		{
			Player1.OnHitWall(Direction.right);
		}
		if (Player1.IsIntersectingRect(new Rectangle(0, ((Control)GameCanvas).get_Height(), ((Control)GameCanvas).get_Width(), 100)))
		{
			Player1.OnHitWall(Direction.down);
		}
		List<Rectangle> rects = Player1.GetRects();
		foreach (Rectangle item in rects)
		{
			if (FoodMngr.IsIntersectingRect(item, RemoveFood: true))
			{
				FoodMngr.AddRandomFood();
				Player1.AddBodySegments(1);
				score++;
				((Control)ScoreTxtBox).set_Text(score.ToString());
			}
		}
	}

	private void SetPlayerMovement()
	{
		if (Input.IsKeyDown((Keys)37) || Input.IsKeyDown((Keys)65))
		{
			Player1.SetDirection(Direction.left);
		}
		else if (Input.IsKeyDown((Keys)39) || Input.IsKeyDown((Keys)68))
		{
			Player1.SetDirection(Direction.right);
		}
		else if (Input.IsKeyDown((Keys)38) || Input.IsKeyDown((Keys)87))
		{
			Player1.SetDirection(Direction.up);
		}
		else if (Input.IsKeyDown((Keys)40) || Input.IsKeyDown((Keys)83))
		{
			Player1.SetDirection(Direction.down);
		}
		Player1.MovePlayer();
	}

	private void GameTimer_Tick(object sender, EventArgs e)
	{
		SetPlayerMovement();
		CheckForCollisions();
		((Control)GameCanvas).Invalidate();
	}

	private void Start_Btn_Click(object sender, EventArgs e)
	{
		ToggleTimer();
	}

	private void DareBtn_Click(object sender, EventArgs e)
	{
		switch (r.Next(4))
		{
		case 0:
			((Control)lbl_Game).set_Text("How dare you listen!");
			break;
		case 1:
			((Control)lbl_Game).set_Text("This is a dark path you are on!");
			break;
		case 2:
			((Control)lbl_Game).set_Text("I knew you wouldn't listen!");
			break;
		case 3:
			((Control)lbl_Game).set_Text("Have some food!!!!!!!!!!  :)");
			FoodMngr.AddRandomFood(20);
			((Control)GameCanvas).Invalidate();
			break;
		}
	}

	private void GameCanvas_Click(object sender, EventArgs e)
	{
	}

	private void btn_Home_Click(object sender, EventArgs e)
	{
		((Control)homeForm).Show();
		homeForm.Home();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((ContainerControl)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected O, but got Unknown
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Expected O, but got Unknown
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Expected O, but got Unknown
		//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
		components = new Container();
		GameCanvas = new PictureBox();
		GameTimer = new Timer(components);
		Start_Btn = new Button();
		DareBtn = new Button();
		ScoreTxtBox = new TextBox();
		ScoreLbl = new Label();
		btn_Home = new Button();
		lbl_Game = new Label();
		((ISupportInitialize)GameCanvas).BeginInit();
		((Control)this).SuspendLayout();
		((Control)GameCanvas).set_BackColor(Color.FromArgb(64, 64, 64));
		GameCanvas.set_BorderStyle((BorderStyle)1);
		((Control)GameCanvas).set_Location(new System.Drawing.Point(9, 16));
		((Control)GameCanvas).set_Margin(new Padding(7));
		((Control)GameCanvas).set_Name("GameCanvas");
		((Control)GameCanvas).set_Size(new Size(1375, 969));
		GameCanvas.set_TabIndex(0);
		GameCanvas.set_TabStop(false);
		((Control)GameCanvas).add_Paint(new PaintEventHandler(GameCanvas_Paint));
		GameTimer.add_Tick((EventHandler)GameTimer_Tick);
		((Control)Start_Btn).set_BackColor(Color.Firebrick);
		((Control)Start_Btn).set_Font(new Font("Microsoft Sans Serif", 8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Start_Btn).set_Location(new System.Drawing.Point(1401, 73));
		((Control)Start_Btn).set_Margin(new Padding(7));
		((Control)Start_Btn).set_Name("Start_Btn");
		((Control)Start_Btn).set_Size(new Size(478, 51));
		((Control)Start_Btn).set_TabIndex(1);
		((Control)Start_Btn).set_Text("Start/Pause");
		((ButtonBase)Start_Btn).set_UseVisualStyleBackColor(false);
		((Control)Start_Btn).add_Click((EventHandler)Start_Btn_Click);
		((Control)DareBtn).set_BackColor(Color.Firebrick);
		((Control)DareBtn).set_Font(new Font("Microsoft Sans Serif", 8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)DareBtn).set_Location(new System.Drawing.Point(1398, 934));
		((Control)DareBtn).set_Margin(new Padding(7));
		((Control)DareBtn).set_Name("DareBtn");
		((Control)DareBtn).set_Size(new Size(481, 51));
		((Control)DareBtn).set_TabIndex(2);
		((Control)DareBtn).set_Text("I Dare You To Press Me");
		((ButtonBase)DareBtn).set_UseVisualStyleBackColor(false);
		((Control)DareBtn).add_Click((EventHandler)DareBtn_Click);
		((Control)ScoreTxtBox).set_Enabled(false);
		((Control)ScoreTxtBox).set_Location(new System.Drawing.Point(1503, 138));
		((Control)ScoreTxtBox).set_Margin(new Padding(7));
		((Control)ScoreTxtBox).set_Name("ScoreTxtBox");
		((TextBoxBase)ScoreTxtBox).set_ReadOnly(true);
		((Control)ScoreTxtBox).set_Size(new Size(370, 35));
		((Control)ScoreTxtBox).set_TabIndex(3);
		((Control)ScoreLbl).set_AutoSize(true);
		((Control)ScoreLbl).set_ForeColor(SystemColors.ButtonHighlight);
		((Control)ScoreLbl).set_Location(new System.Drawing.Point(1401, 141));
		((Control)ScoreLbl).set_Margin(new Padding(7, 0, 7, 0));
		((Control)ScoreLbl).set_Name("ScoreLbl");
		((Control)ScoreLbl).set_Size(new Size(83, 29));
		((Control)ScoreLbl).set_TabIndex(4);
		((Control)ScoreLbl).set_Text("Score:");
		((Control)btn_Home).set_BackColor(Color.Firebrick);
		((Control)btn_Home).set_Font(new Font("Microsoft Sans Serif", 8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btn_Home).set_Location(new System.Drawing.Point(1401, 16));
		((Control)btn_Home).set_Margin(new Padding(7));
		((Control)btn_Home).set_Name("btn_Home");
		((Control)btn_Home).set_Size(new Size(478, 51));
		((Control)btn_Home).set_TabIndex(5);
		((Control)btn_Home).set_Text("Home");
		((ButtonBase)btn_Home).set_UseVisualStyleBackColor(false);
		((Control)btn_Home).add_Click((EventHandler)btn_Home_Click);
		((Control)lbl_Game).set_AutoSize(true);
		((Control)lbl_Game).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lbl_Game).set_ForeColor(Color.White);
		((Control)lbl_Game).set_Location(new System.Drawing.Point(1405, 206));
		((Control)lbl_Game).set_MaximumSize(new Size(425, 425));
		((Control)lbl_Game).set_Name("lbl_Game");
		((Control)lbl_Game).set_Size(new Size(0, 40));
		((Control)lbl_Game).set_TabIndex(6);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(14f, 29f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_AutoSize(true);
		((Control)this).set_BackColor(Color.Black);
		((Control)this).get_Controls().Add((Control)(object)lbl_Game);
		((Control)this).get_Controls().Add((Control)(object)btn_Home);
		((Control)this).get_Controls().Add((Control)(object)ScoreLbl);
		((Control)this).get_Controls().Add((Control)(object)ScoreTxtBox);
		((Control)this).get_Controls().Add((Control)(object)DareBtn);
		((Control)this).get_Controls().Add((Control)(object)Start_Btn);
		((Control)this).get_Controls().Add((Control)(object)GameCanvas);
		((Control)this).set_Margin(new Padding(7));
		((Control)this).set_Name("Snake");
		((Control)this).set_Size(new Size(1892, 1001));
		((ISupportInitialize)GameCanvas).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
