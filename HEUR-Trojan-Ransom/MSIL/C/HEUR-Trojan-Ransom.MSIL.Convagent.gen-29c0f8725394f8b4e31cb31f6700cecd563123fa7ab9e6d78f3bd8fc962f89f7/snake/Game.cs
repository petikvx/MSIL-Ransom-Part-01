using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace snake;

public class Game : Form
{
	public struct SYSTEMTIME
	{
		public short Year;

		public short Month;

		public short DayOfWeek;

		public short Day;

		public short Hour;

		public short Minute;

		public short Second;

		public short Milliseconds;
	}

	private int posx = 0;

	private int posy = 0;

	private int direction;

	private Snake snake1;

	private Apple apple1;

	private int sizeElem;

	private Stopwatch timerD = new Stopwatch();

	private int test;

	private Random random = new Random();

	private int score;

	private int moved;

	public AllWall walls;

	private NetworkConnection f;

	private SetParameters SP;

	private Score_xml donneesJeuNous;

	private Score_xml donneesJeuAdv;

	private int scoreAdv;

	private Snake snakeAdv;

	private Apple appleAdv;

	private AllWall wallsAdv;

	private bool onePlayer;

	private bool alreadyReset;

	public SYSTEMTIME st;

	private IContainer components = null;

	private Timer timer1;

	private ToolStripMenuItem fichierToolStripMenuItem;

	private ToolStripMenuItem nouveauJeuToolStripMenuItem;

	private Label label1;

	private Label label2;

	private Label label3;

	private Panel panel1;

	private Panel panel3;

	private Label label4;

	private MenuStrip menuStrip1;

	private ToolStripMenuItem newGameToolStripMenuItem;

	private ToolStripMenuItem player1ToolStripMenuItem;

	private ToolStripMenuItem twoPlayersToolStripMenuItem;

	private ToolStripMenuItem exitToolStripMenuItem;

	private Timer timer2;

	private Panel panel2;

	private ToolStripMenuItem player1ToolStripMenuItem1;

	private ToolStripMenuItem player2ToolStripMenuItem;

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool GetSystemTime(out SYSTEMTIME systemTime);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool SetSystemTime(ref SYSTEMTIME systemTime);

	public Game()
	{
		InitializeComponent();
		alreadyReset = false;
		st = default(SYSTEMTIME);
	}

	private void initializeGame(int nbJoueur)
	{
		int nbElements = 10;
		sizeElem = 20;
		test = 0;
		score = 0;
		direction = 2;
		moved = 0;
		((Control)label3).set_Text(score.ToString());
		snake1 = new Snake(10, GameResource.img1, sizeElem, panel1);
		walls = new AllWall();
		apple1 = new Apple(40, 40, GameResource.apple1, sizeElem, panel1);
		apple1.changePosition(snake1, walls, ((Control)panel1).get_Width(), ((Control)panel1).get_Height());
		if (!onePlayer)
		{
			snakeAdv = new Snake(nbElements, GameResource.img2, sizeElem / 2, panel3);
			wallsAdv = new AllWall();
			appleAdv = new Apple(40, 40, GameResource.apple2, sizeElem / 2, panel3);
			donneesJeuNous = new Score_xml("SerializationTest.xml");
			donneesJeuAdv = new Score_xml("SerializationAdv.xml");
			scoreAdv = 0;
			SP = new SetParameters();
			if (!alreadyReset)
			{
				if (nbJoueur == 1)
				{
					f = new NetworkConnection(SP.AddressIPSender, SP.AddressIPReceiver);
				}
				else
				{
					f = new NetworkConnection(SP.AddressIPReceiver, SP.AddressIPSender);
				}
			}
			do
			{
				f.sendInfo("I'm here !");
			}
			while (f.xml != "I'm here !");
			((Control)panel3).set_Visible(true);
			((Control)label4).set_Visible(true);
			((Control)panel2).set_Visible(true);
			timer2.Start();
		}
		else
		{
			((Control)panel3).set_Visible(false);
			((Control)label4).set_Visible(false);
			((Control)panel2).set_Visible(false);
		}
		timerD.Start();
	}

	public void ResetGame()
	{
		for (int i = 0; i < walls.myWalls.Count; i++)
		{
		}
		walls = new AllWall();
		int nbElements = 10;
		sizeElem = 20;
		test = 0;
		score = 0;
		direction = 2;
		moved = 0;
		((Control)label3).set_Text(score.ToString());
		((Control)apple1.pictureBox1).set_Visible(false);
		for (int j = 0; j < snake1.myList.Count; j++)
		{
		}
		snake1 = new Snake(nbElements, GameResource.img1, sizeElem, panel1);
		for (int j = 0; j < snake1.myList.Count; j++)
		{
		}
		if (!onePlayer)
		{
			for (int k = 0; k < wallsAdv.myWalls.Count; k++)
			{
			}
			((Control)appleAdv.pictureBox1).set_Visible(false);
			for (int j = 0; j < snakeAdv.myList.Count; j++)
			{
			}
		}
		timerD.Reset();
	}

	private void Snake_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected I4, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Invalid comparison between Unknown and I4
		Keys keyCode = e.get_KeyCode();
		Keys val = keyCode;
		switch (val - 37)
		{
		default:
			if ((int)val != 65 && (int)val == 87)
			{
				walls.addWall(snake1, GameResource.wall, sizeElem, panel1);
			}
			break;
		case 0:
			if ((direction == 1 || direction == 2) && moved == 0)
			{
				posx = -20;
				posy = 0;
				test = 1;
				direction = 0;
				moved = 1;
			}
			break;
		case 1:
			if ((direction == 0 || direction == 2) && moved == 0)
			{
				posx = 0;
				posy = -20;
				test = 1;
				direction = 1;
				moved = 1;
			}
			break;
		case 2:
			if (direction == 1 && moved == 0)
			{
				posx = 20;
				posy = 0;
				test = 1;
				moved = 1;
				direction = 0;
			}
			break;
		case 3:
			if ((direction == 0 || direction == 2) && moved == 0)
			{
				posx = 0;
				posy = 20;
				test = 1;
				moved = 1;
				direction = 1;
			}
			break;
		}
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		if (GetSystemTime(out st))
		{
			((Control)label2).set_Text(st.Hour + 2 + ":" + st.Minute + ":" + st.Second);
		}
		if (test == 1)
		{
			for (int num = snake1.myList.Count - 1; num > 0; num--)
			{
			}
			moved = 0;
			if (snake1.detecteCorps() || walls.detecteWall(snake1))
			{
				test = 0;
				Form1 form = new Form1(t: false);
				((Control)form).Show();
				((Control)label1).set_Text("0:0:0");
				if (!onePlayer)
				{
					f.sendInfo("I'm dead");
					alreadyReset = true;
				}
			}
			apple1.changePosition(snake1, walls, ((Control)panel1).get_Width(), ((Control)panel1).get_Height());
			score++;
			((Control)label3).set_Text(score.ToString());
		}
		((Control)label1).set_Text(timerD.Elapsed.Hours + ":" + timerD.Elapsed.Minutes + ":" + timerD.Elapsed.Seconds);
		((Control)label1).set_Text("0:0:0");
		ResetGame();
	}

	private void updateAdv(Score_xml donneesJeuAdv)
	{
		if (donneesJeuAdv.obj.myList != null)
		{
			for (int i = 0; i < donneesJeuAdv.obj.myList.Count; i++)
			{
				if (i >= snakeAdv.myList.Count)
				{
				}
			}
		}
		if (donneesJeuAdv.obj.myWalls != null)
		{
			for (int j = 0; j < donneesJeuAdv.obj.myWalls.Count; j++)
			{
			}
		}
		if (donneesJeuAdv.obj.myApple != null)
		{
			((Control)appleAdv.pictureBox1).set_Left(donneesJeuAdv.obj.myApple.x / 2);
			((Control)appleAdv.pictureBox1).set_Top(donneesJeuAdv.obj.myApple.y / 2);
			Console.WriteLine("APPLE x " + donneesJeuAdv.obj.myApple.x / 2 + " y " + donneesJeuAdv.obj.myApple.y / 2);
		}
		if (donneesJeuAdv.obj.score > scoreAdv)
		{
			for (int k = 0; k < donneesJeuAdv.obj.score - scoreAdv; k++)
			{
				walls.addWall(snake1, GameResource.wall, sizeElem, panel1);
			}
		}
		scoreAdv = donneesJeuAdv.obj.score;
		((Control)label4).set_Text(scoreAdv.ToString());
	}

	private void player1ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		onePlayer = true;
		initializeGame(0);
		timer1.set_Interval(100);
	}

	private void exitToolStripMenuItem_Click(object sender, EventArgs e)
	{
		test = 0;
		Form1 form = new Form1(t: false);
		((Control)form).Show();
		((Control)label1).set_Text("0:0:0");
		if (!onePlayer)
		{
			alreadyReset = true;
			f.sendInfo("I'm dead");
		}
	}

	private void timer2_Tick(object sender, EventArgs e)
	{
		if (!onePlayer)
		{
			string info = donneesJeuNous.Serialize(score, snake1.myList, walls.myWalls, apple1);
			f.sendInfo(info);
			if (f.xml.Contains("<?xml version=\"1.0\" encoding=\"utf-16\"?>"))
			{
				donneesJeuAdv.Deserialize(f.xml);
			}
			else if (f.xml.Contains("I'm dead"))
			{
				test = 0;
				Form1 form = new Form1(t: true);
				((Control)form).Show();
				((Control)label1).set_Text("0:0:0");
				alreadyReset = true;
			}
			if (donneesJeuAdv != null)
			{
				updateAdv(donneesJeuAdv);
			}
		}
	}

	private void player1ToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		onePlayer = false;
		initializeGame(1);
		timer1.set_Interval(100);
		timer2.set_Interval(100);
	}

	private void player2ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		onePlayer = false;
		initializeGame(2);
		timer1.set_Interval(100);
		timer2.set_Interval(100);
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
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected O, but got Unknown
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected O, but got Unknown
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Expected O, but got Unknown
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Expected O, but got Unknown
		//IL_08f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0903: Expected O, but got Unknown
		components = new Container();
		panel1 = new Panel();
		timer1 = new Timer(components);
		fichierToolStripMenuItem = new ToolStripMenuItem();
		nouveauJeuToolStripMenuItem = new ToolStripMenuItem();
		label1 = new Label();
		label2 = new Label();
		label3 = new Label();
		panel3 = new Panel();
		label4 = new Label();
		menuStrip1 = new MenuStrip();
		newGameToolStripMenuItem = new ToolStripMenuItem();
		player1ToolStripMenuItem = new ToolStripMenuItem();
		twoPlayersToolStripMenuItem = new ToolStripMenuItem();
		player1ToolStripMenuItem1 = new ToolStripMenuItem();
		player2ToolStripMenuItem = new ToolStripMenuItem();
		exitToolStripMenuItem = new ToolStripMenuItem();
		timer2 = new Timer(components);
		panel2 = new Panel();
		((Control)menuStrip1).SuspendLayout();
		((Control)panel2).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)panel1).set_BackColor(Color.DarkRed);
		panel1.set_BorderStyle((BorderStyle)1);
		((Control)panel1).set_Location(new Point(40, 80));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(500, 400));
		((Control)panel1).set_TabIndex(4);
		timer1.set_Enabled(true);
		timer1.add_Tick((EventHandler)timer1_Tick);
		((ToolStripDropDownItem)fichierToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)nouveauJeuToolStripMenuItem });
		((ToolStripItem)fichierToolStripMenuItem).set_Name("fichierToolStripMenuItem");
		((ToolStripItem)fichierToolStripMenuItem).set_Size(new Size(54, 20));
		((ToolStripItem)fichierToolStripMenuItem).set_Text("Fichier");
		((ToolStripItem)nouveauJeuToolStripMenuItem).set_Name("nouveauJeuToolStripMenuItem");
		((ToolStripItem)nouveauJeuToolStripMenuItem).set_Size(new Size(141, 22));
		((ToolStripItem)nouveauJeuToolStripMenuItem).set_Text("Nouveau jeu");
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_BackColor(Color.Transparent);
		((Control)label1).set_Font(new Font("Arial", 20.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(SystemColors.ButtonHighlight);
		((Control)label1).set_Location(new Point(779, 126));
		((Control)label1).set_MaximumSize(new Size(200, 100));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(93, 32));
		((Control)label1).set_TabIndex(1);
		((Control)label1).set_Text("label1");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Segoe UI", 12f));
		((Control)label2).set_Location(new Point(797, 0));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(52, 21));
		((Control)label2).set_TabIndex(2);
		((Control)label2).set_Text("label2");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_BackColor(Color.Transparent);
		((Control)label3).set_Font(new Font("Arial", 20.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(SystemColors.ButtonHighlight);
		((Control)label3).set_Location(new Point(779, 216));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(30, 32));
		((Control)label3).set_TabIndex(3);
		((Control)label3).set_Text("0");
		((Control)panel3).set_BackColor(Color.DarkRed);
		((Control)panel3).set_Location(new Point(610, 340));
		((Control)panel3).set_Name("panel3");
		((Control)panel3).set_Size(new Size(250, 200));
		((Control)panel3).set_TabIndex(2);
		((Control)panel3).set_Visible(false);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_BackColor(Color.DarkRed);
		((Control)label4).set_Font(new Font("Arial", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_ForeColor(Color.White);
		((Control)label4).set_Location(new Point(60, 31));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(54, 19));
		((Control)label4).set_TabIndex(0);
		((Control)label4).set_Text("label4");
		((Control)label4).set_Visible(false);
		((ToolStrip)menuStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)newGameToolStripMenuItem,
			(ToolStripItem)exitToolStripMenuItem
		});
		((Control)menuStrip1).set_Location(new Point(0, 0));
		((Control)menuStrip1).set_Name("menuStrip1");
		((Control)menuStrip1).set_Size(new Size(903, 24));
		((Control)menuStrip1).set_TabIndex(5);
		((Control)menuStrip1).set_Text("menuStrip1");
		((ToolStripDropDownItem)newGameToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)player1ToolStripMenuItem,
			(ToolStripItem)twoPlayersToolStripMenuItem
		});
		((ToolStripItem)newGameToolStripMenuItem).set_Name("newGameToolStripMenuItem");
		((ToolStripItem)newGameToolStripMenuItem).set_Size(new Size(76, 20));
		((ToolStripItem)newGameToolStripMenuItem).set_Text("New game");
		((ToolStripItem)player1ToolStripMenuItem).set_Name("player1ToolStripMenuItem");
		((ToolStripItem)player1ToolStripMenuItem).set_Size(new Size(152, 22));
		((ToolStripItem)player1ToolStripMenuItem).set_Text("One player");
		((ToolStripItem)player1ToolStripMenuItem).add_Click((EventHandler)player1ToolStripMenuItem_Click);
		((ToolStripDropDownItem)twoPlayersToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)player1ToolStripMenuItem1,
			(ToolStripItem)player2ToolStripMenuItem
		});
		((ToolStripItem)twoPlayersToolStripMenuItem).set_Name("twoPlayersToolStripMenuItem");
		((ToolStripItem)twoPlayersToolStripMenuItem).set_Size(new Size(152, 22));
		((ToolStripItem)twoPlayersToolStripMenuItem).set_Text("Two players");
		((ToolStripItem)player1ToolStripMenuItem1).set_Name("player1ToolStripMenuItem1");
		((ToolStripItem)player1ToolStripMenuItem1).set_Size(new Size(152, 22));
		((ToolStripItem)player1ToolStripMenuItem1).set_Text("Player 1");
		((ToolStripItem)player1ToolStripMenuItem1).add_Click((EventHandler)player1ToolStripMenuItem1_Click);
		((ToolStripItem)player2ToolStripMenuItem).set_Name("player2ToolStripMenuItem");
		((ToolStripItem)player2ToolStripMenuItem).set_Size(new Size(152, 22));
		((ToolStripItem)player2ToolStripMenuItem).set_Text("Player 2");
		((ToolStripItem)player2ToolStripMenuItem).add_Click((EventHandler)player2ToolStripMenuItem_Click);
		((ToolStripItem)exitToolStripMenuItem).set_Name("exitToolStripMenuItem");
		((ToolStripItem)exitToolStripMenuItem).set_Size(new Size(37, 20));
		((ToolStripItem)exitToolStripMenuItem).set_Text("Exit");
		((ToolStripItem)exitToolStripMenuItem).add_Click((EventHandler)exitToolStripMenuItem_Click);
		timer2.add_Tick((EventHandler)timer2_Tick);
		((Control)panel2).set_BackColor(Color.DarkRed);
		((Control)panel2).set_BackgroundImage((Image)(object)GameResource.scoreAdv);
		((Control)panel2).get_Controls().Add((Control)(object)label4);
		((Control)panel2).set_Location(new Point(621, 266));
		((Control)panel2).set_Name("panel2");
		((Control)panel2).set_Size(new Size(172, 65));
		((Control)panel2).set_TabIndex(6);
		((Control)panel2).set_Visible(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)(object)GameResource.Fonds);
		((Form)this).set_ClientSize(new Size(903, 583));
		((Control)this).get_Controls().Add((Control)(object)panel3);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).get_Controls().Add((Control)(object)menuStrip1);
		((Control)this).get_Controls().Add((Control)(object)panel2);
		((Form)this).set_MainMenuStrip(menuStrip1);
		((Control)this).set_Name("Game");
		((Control)this).set_Text("Snake");
		((Form)this).add_Activated((EventHandler)timer1_Tick);
		((Control)this).add_KeyDown(new KeyEventHandler(Snake_KeyDown));
		((Control)menuStrip1).ResumeLayout(false);
		((Control)menuStrip1).PerformLayout();
		((Control)panel2).ResumeLayout(false);
		((Control)panel2).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
