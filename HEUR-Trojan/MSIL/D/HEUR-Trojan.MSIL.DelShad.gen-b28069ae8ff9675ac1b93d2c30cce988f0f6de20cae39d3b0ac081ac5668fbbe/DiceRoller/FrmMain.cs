using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using DiceRoller.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace DiceRoller;

[DesignerGenerated]
public class FrmMain : Form
{
	private IContainer components;

	private object[] DiceArray;

	private ArrayList RandomsList;

	private object[] PbxArray;

	private object[] DicePic;

	private object[] DiceLock;

	private int ScoreAces;

	private int ScoreTwos;

	private int ScoreThrees;

	private int ScoreFours;

	private int ScoreFives;

	private int ScoreSixes;

	private int Score3OAK;

	private int Score4OAK;

	private int ScoreFullhouse;

	private int ScoreYahtzee;

	private object[] UpperScores;

	private object[] LowerScores;

	private int TotalScore;

	private int intRoundCount;

	private int RerollCount;

	private bool DiceOneLocked;

	private bool DiceTwoLocked;

	private bool DiceThreeLocked;

	private bool DiceFourLocked;

	private bool DiceFiveLocked;

	[SpecialName]
	private Random _0024STATIC_0024GetRandom_00242008_0024Generator;

	[SpecialName]
	private StaticLocalInitFlag _0024STATIC_0024GetRandom_00242008_0024Generator_0024Init;

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtScoreAces")]
	internal virtual TextBox txtScoreAces
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnAces
	{
		[CompilerGenerated]
		get
		{
			return _btnAces;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = BtnAces_Click;
			Button val = _btnAces;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnAces = value;
			val = _btnAces;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("PictureBox2")]
	internal virtual PictureBox PictureBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox2")]
	internal virtual GroupBox GroupBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtScoreTwos")]
	internal virtual TextBox txtScoreTwos
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnTwos
	{
		[CompilerGenerated]
		get
		{
			return _btnTwos;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = BtnTwos_Click;
			Button val = _btnTwos;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnTwos = value;
			val = _btnTwos;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("PictureBox3")]
	internal virtual PictureBox PictureBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox3")]
	internal virtual GroupBox GroupBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtScoreThrees")]
	internal virtual TextBox txtScoreThrees
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnThrees
	{
		[CompilerGenerated]
		get
		{
			return _btnThrees;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = BtnThrees_Click;
			Button val = _btnThrees;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnThrees = value;
			val = _btnThrees;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("PictureBox4")]
	internal virtual PictureBox PictureBox4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox4")]
	internal virtual GroupBox GroupBox4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtScoreFours")]
	internal virtual TextBox txtScoreFours
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnFours
	{
		[CompilerGenerated]
		get
		{
			return _btnFours;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = BtnFours_Click;
			Button val = _btnFours;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnFours = value;
			val = _btnFours;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("PictureBox5")]
	internal virtual PictureBox PictureBox5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox5")]
	internal virtual GroupBox GroupBox5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtScoreFives")]
	internal virtual TextBox txtScoreFives
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnFives
	{
		[CompilerGenerated]
		get
		{
			return _btnFives;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = BtnFives_Click;
			Button val = _btnFives;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnFives = value;
			val = _btnFives;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("PictureBox6")]
	internal virtual PictureBox PictureBox6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox10")]
	internal virtual GroupBox GroupBox10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtScoreSixes")]
	internal virtual TextBox txtScoreSixes
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnSixes
	{
		[CompilerGenerated]
		get
		{
			return _btnSixes;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = BtnSixes_Click;
			Button val = _btnSixes;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnSixes = value;
			val = _btnSixes;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("GroupBox6")]
	internal virtual GroupBox GroupBox6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtScore3OAK")]
	internal virtual TextBox txtScore3OAK
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btn3OAK
	{
		[CompilerGenerated]
		get
		{
			return _btn3OAK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Btn3OAK_Click;
			Button val = _btn3OAK;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btn3OAK = value;
			val = _btn3OAK;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("PictureBox8")]
	internal virtual PictureBox PictureBox8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox7")]
	internal virtual GroupBox GroupBox7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtScore4OAK")]
	internal virtual TextBox txtScore4OAK
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btn4OAK
	{
		[CompilerGenerated]
		get
		{
			return _btn4OAK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Btn4OAK_Click;
			Button val = _btn4OAK;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btn4OAK = value;
			val = _btn4OAK;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("PictureBox9")]
	internal virtual PictureBox PictureBox9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox8")]
	internal virtual GroupBox GroupBox8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtScoreFullHouse")]
	internal virtual TextBox txtScoreFullHouse
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnFullHouse
	{
		[CompilerGenerated]
		get
		{
			return _btnFullHouse;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = BtnFullHouse_Click;
			Button val = _btnFullHouse;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnFullHouse = value;
			val = _btnFullHouse;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("PictureBox10")]
	internal virtual PictureBox PictureBox10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox9")]
	internal virtual GroupBox GroupBox9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtScoreYahtzee")]
	internal virtual TextBox txtScoreYahtzee
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnYahtzee
	{
		[CompilerGenerated]
		get
		{
			return _btnYahtzee;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = BtnYahtzee_Click;
			Button val = _btnYahtzee;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnYahtzee = value;
			val = _btnYahtzee;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("PictureBox11")]
	internal virtual PictureBox PictureBox11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MenuStrip1")]
	internal virtual MenuStrip MenuStrip1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem NewGameToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _NewGameToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = NewGameToolStripMenuItem_Click;
			ToolStripMenuItem newGameToolStripMenuItem = _NewGameToolStripMenuItem;
			if (newGameToolStripMenuItem != null)
			{
				((ToolStripItem)newGameToolStripMenuItem).remove_Click(eventHandler);
			}
			_NewGameToolStripMenuItem = value;
			newGameToolStripMenuItem = _NewGameToolStripMenuItem;
			if (newGameToolStripMenuItem != null)
			{
				((ToolStripItem)newGameToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem HelpToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _HelpToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = HelpToolStripMenuItem_Click;
			ToolStripMenuItem helpToolStripMenuItem = _HelpToolStripMenuItem;
			if (helpToolStripMenuItem != null)
			{
				((ToolStripItem)helpToolStripMenuItem).remove_Click(eventHandler);
			}
			_HelpToolStripMenuItem = value;
			helpToolStripMenuItem = _HelpToolStripMenuItem;
			if (helpToolStripMenuItem != null)
			{
				((ToolStripItem)helpToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem AboutToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _AboutToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = AboutToolStripMenuItem_Click;
			ToolStripMenuItem aboutToolStripMenuItem = _AboutToolStripMenuItem;
			if (aboutToolStripMenuItem != null)
			{
				((ToolStripItem)aboutToolStripMenuItem).remove_Click(eventHandler);
			}
			_AboutToolStripMenuItem = value;
			aboutToolStripMenuItem = _AboutToolStripMenuItem;
			if (aboutToolStripMenuItem != null)
			{
				((ToolStripItem)aboutToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual PictureBox pbxResult5
	{
		[CompilerGenerated]
		get
		{
			return _pbxResult5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = PbxResult5_Click;
			PictureBox val = _pbxResult5;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_pbxResult5 = value;
			val = _pbxResult5;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual PictureBox pbxResult4
	{
		[CompilerGenerated]
		get
		{
			return _pbxResult4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = PbxResult4_Click;
			PictureBox val = _pbxResult4;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_pbxResult4 = value;
			val = _pbxResult4;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual PictureBox pbxResult3
	{
		[CompilerGenerated]
		get
		{
			return _pbxResult3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = PbxResult3_Click;
			PictureBox val = _pbxResult3;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_pbxResult3 = value;
			val = _pbxResult3;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual PictureBox pbxResult2
	{
		[CompilerGenerated]
		get
		{
			return _pbxResult2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = PbxResult2_Click;
			PictureBox val = _pbxResult2;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_pbxResult2 = value;
			val = _pbxResult2;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual PictureBox pbxResult1
	{
		[CompilerGenerated]
		get
		{
			return _pbxResult1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = PbxResult1_Click;
			PictureBox val = _pbxResult1;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_pbxResult1 = value;
			val = _pbxResult1;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button btnRoll
	{
		[CompilerGenerated]
		get
		{
			return _btnRoll;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = BtnRoll_Click;
			Button val = _btnRoll;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnRoll = value;
			val = _btnRoll;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("lblTotalScore")]
	internal virtual Label lblTotalScore
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtTotalScore")]
	internal virtual TextBox txtTotalScore
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblRoundCounter")]
	internal virtual Label lblRoundCounter
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnEndTurn
	{
		[CompilerGenerated]
		get
		{
			return _btnEndTurn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = BtnEndTurn_Click;
			Button val = _btnEndTurn;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnEndTurn = value;
			val = _btnEndTurn;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button btnReroll
	{
		[CompilerGenerated]
		get
		{
			return _btnReroll;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = BtnReroll_Click;
			Button val = _btnReroll;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnReroll = value;
			val = _btnReroll;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("PbxDiceLock1")]
	internal virtual PictureBox PbxDiceLock1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PbxDiceLock5")]
	internal virtual PictureBox PbxDiceLock5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PbxDiceLock4")]
	internal virtual PictureBox PbxDiceLock4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PbxDiceLock3")]
	internal virtual PictureBox PbxDiceLock3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PbxDiceLock2")]
	internal virtual PictureBox PbxDiceLock2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public FrmMain()
	{
		((Form)this).add_Load((EventHandler)delegate
		{
			OnStart();
		});
		DiceArray = new object[5];
		RandomsList = new ArrayList();
		PbxArray = new object[5] { pbxResult1, pbxResult2, pbxResult3, pbxResult4, pbxResult5 };
		DiceLock = new object[5] { DiceOneLocked, DiceTwoLocked, DiceThreeLocked, DiceFourLocked, DiceFiveLocked };
		ScoreAces = 0;
		ScoreTwos = 0;
		ScoreThrees = 0;
		ScoreFours = 0;
		ScoreFives = 0;
		ScoreSixes = 0;
		Score3OAK = 0;
		Score4OAK = 0;
		ScoreFullhouse = 0;
		ScoreYahtzee = 0;
		UpperScores = new object[6] { ScoreAces, ScoreTwos, ScoreThrees, ScoreFours, ScoreFives, ScoreSixes };
		LowerScores = new object[4] { Score3OAK, Score4OAK, ScoreFullhouse, ScoreYahtzee };
		TotalScore = 0;
		intRoundCount = 1;
		RerollCount = 0;
		DiceOneLocked = false;
		DiceTwoLocked = false;
		DiceThreeLocked = false;
		DiceFourLocked = false;
		DiceFiveLocked = false;
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
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
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected O, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected O, but got Unknown
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected O, but got Unknown
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected O, but got Unknown
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected O, but got Unknown
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected O, but got Unknown
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected O, but got Unknown
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected O, but got Unknown
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected O, but got Unknown
		//IL_0583: Unknown result type (might be due to invalid IL or missing references)
		//IL_058d: Expected O, but got Unknown
		//IL_059e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a8: Expected O, but got Unknown
		//IL_0775: Unknown result type (might be due to invalid IL or missing references)
		//IL_077f: Expected O, but got Unknown
		//IL_0958: Unknown result type (might be due to invalid IL or missing references)
		//IL_0962: Expected O, but got Unknown
		//IL_0b2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b39: Expected O, but got Unknown
		//IL_0d06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d10: Expected O, but got Unknown
		//IL_0edd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee7: Expected O, but got Unknown
		//IL_1deb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1df5: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FrmMain));
		GroupBox1 = new GroupBox();
		txtScoreAces = new TextBox();
		btnAces = new Button();
		PictureBox1 = new PictureBox();
		GroupBox2 = new GroupBox();
		txtScoreTwos = new TextBox();
		btnTwos = new Button();
		PictureBox2 = new PictureBox();
		GroupBox3 = new GroupBox();
		txtScoreThrees = new TextBox();
		btnThrees = new Button();
		PictureBox3 = new PictureBox();
		GroupBox4 = new GroupBox();
		txtScoreFours = new TextBox();
		btnFours = new Button();
		PictureBox4 = new PictureBox();
		GroupBox5 = new GroupBox();
		txtScoreFives = new TextBox();
		btnFives = new Button();
		PictureBox5 = new PictureBox();
		GroupBox10 = new GroupBox();
		txtScoreSixes = new TextBox();
		btnSixes = new Button();
		PictureBox6 = new PictureBox();
		GroupBox6 = new GroupBox();
		txtScore3OAK = new TextBox();
		btn3OAK = new Button();
		PictureBox8 = new PictureBox();
		GroupBox7 = new GroupBox();
		txtScore4OAK = new TextBox();
		btn4OAK = new Button();
		PictureBox9 = new PictureBox();
		GroupBox8 = new GroupBox();
		txtScoreFullHouse = new TextBox();
		btnFullHouse = new Button();
		PictureBox10 = new PictureBox();
		GroupBox9 = new GroupBox();
		txtScoreYahtzee = new TextBox();
		btnYahtzee = new Button();
		PictureBox11 = new PictureBox();
		MenuStrip1 = new MenuStrip();
		NewGameToolStripMenuItem = new ToolStripMenuItem();
		HelpToolStripMenuItem = new ToolStripMenuItem();
		AboutToolStripMenuItem = new ToolStripMenuItem();
		Panel1 = new Panel();
		PbxDiceLock5 = new PictureBox();
		PbxDiceLock4 = new PictureBox();
		PbxDiceLock3 = new PictureBox();
		PbxDiceLock2 = new PictureBox();
		PbxDiceLock1 = new PictureBox();
		pbxResult5 = new PictureBox();
		pbxResult4 = new PictureBox();
		pbxResult3 = new PictureBox();
		pbxResult2 = new PictureBox();
		pbxResult1 = new PictureBox();
		btnRoll = new Button();
		lblTotalScore = new Label();
		txtTotalScore = new TextBox();
		lblRoundCounter = new Label();
		btnEndTurn = new Button();
		btnReroll = new Button();
		((Control)GroupBox1).SuspendLayout();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)GroupBox2).SuspendLayout();
		((ISupportInitialize)PictureBox2).BeginInit();
		((Control)GroupBox3).SuspendLayout();
		((ISupportInitialize)PictureBox3).BeginInit();
		((Control)GroupBox4).SuspendLayout();
		((ISupportInitialize)PictureBox4).BeginInit();
		((Control)GroupBox5).SuspendLayout();
		((ISupportInitialize)PictureBox5).BeginInit();
		((Control)GroupBox10).SuspendLayout();
		((ISupportInitialize)PictureBox6).BeginInit();
		((Control)GroupBox6).SuspendLayout();
		((ISupportInitialize)PictureBox8).BeginInit();
		((Control)GroupBox7).SuspendLayout();
		((ISupportInitialize)PictureBox9).BeginInit();
		((Control)GroupBox8).SuspendLayout();
		((ISupportInitialize)PictureBox10).BeginInit();
		((Control)GroupBox9).SuspendLayout();
		((ISupportInitialize)PictureBox11).BeginInit();
		((Control)MenuStrip1).SuspendLayout();
		((Control)Panel1).SuspendLayout();
		((ISupportInitialize)PbxDiceLock5).BeginInit();
		((ISupportInitialize)PbxDiceLock4).BeginInit();
		((ISupportInitialize)PbxDiceLock3).BeginInit();
		((ISupportInitialize)PbxDiceLock2).BeginInit();
		((ISupportInitialize)PbxDiceLock1).BeginInit();
		((ISupportInitialize)pbxResult5).BeginInit();
		((ISupportInitialize)pbxResult4).BeginInit();
		((ISupportInitialize)pbxResult3).BeginInit();
		((ISupportInitialize)pbxResult2).BeginInit();
		((ISupportInitialize)pbxResult1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)GroupBox1).get_Controls().Add((Control)(object)txtScoreAces);
		((Control)GroupBox1).get_Controls().Add((Control)(object)btnAces);
		((Control)GroupBox1).get_Controls().Add((Control)(object)PictureBox1);
		((Control)GroupBox1).set_Location(new Point(12, 27));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Size(new Size(132, 116));
		((Control)GroupBox1).set_TabIndex(0);
		GroupBox1.set_TabStop(false);
		((Control)txtScoreAces).set_Location(new Point(27, 67));
		((Control)txtScoreAces).set_Name("txtScoreAces");
		((TextBoxBase)txtScoreAces).set_ReadOnly(true);
		((Control)txtScoreAces).set_Size(new Size(75, 20));
		((Control)txtScoreAces).set_TabIndex(3);
		txtScoreAces.set_TextAlign((HorizontalAlignment)2);
		((Control)btnAces).set_Location(new Point(27, 87));
		((Control)btnAces).set_Name("btnAces");
		((Control)btnAces).set_Size(new Size(75, 23));
		((Control)btnAces).set_TabIndex(2);
		((ButtonBase)btnAces).set_Text("Set");
		((ButtonBase)btnAces).set_UseVisualStyleBackColor(true);
		((Control)btnAces).set_Visible(false);
		PictureBox1.set_Image((Image)componentResourceManager.GetObject("PictureBox1.Image"));
		PictureBox1.set_InitialImage((Image)componentResourceManager.GetObject("PictureBox1.InitialImage"));
		((Control)PictureBox1).set_Location(new Point(37, 11));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(50, 50));
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(1);
		PictureBox1.set_TabStop(false);
		((Control)GroupBox2).get_Controls().Add((Control)(object)txtScoreTwos);
		((Control)GroupBox2).get_Controls().Add((Control)(object)btnTwos);
		((Control)GroupBox2).get_Controls().Add((Control)(object)PictureBox2);
		((Control)GroupBox2).set_Location(new Point(150, 27));
		((Control)GroupBox2).set_Name("GroupBox2");
		((Control)GroupBox2).set_Size(new Size(132, 116));
		((Control)GroupBox2).set_TabIndex(4);
		GroupBox2.set_TabStop(false);
		((Control)txtScoreTwos).set_Location(new Point(27, 67));
		((Control)txtScoreTwos).set_Name("txtScoreTwos");
		((TextBoxBase)txtScoreTwos).set_ReadOnly(true);
		((Control)txtScoreTwos).set_Size(new Size(75, 20));
		((Control)txtScoreTwos).set_TabIndex(3);
		txtScoreTwos.set_TextAlign((HorizontalAlignment)2);
		((Control)btnTwos).set_Location(new Point(27, 87));
		((Control)btnTwos).set_Name("btnTwos");
		((Control)btnTwos).set_Size(new Size(75, 23));
		((Control)btnTwos).set_TabIndex(2);
		((ButtonBase)btnTwos).set_Text("Set");
		((ButtonBase)btnTwos).set_UseVisualStyleBackColor(true);
		((Control)btnTwos).set_Visible(false);
		PictureBox2.set_Image((Image)componentResourceManager.GetObject("PictureBox2.Image"));
		PictureBox2.set_InitialImage((Image)null);
		((Control)PictureBox2).set_Location(new Point(38, 11));
		((Control)PictureBox2).set_Name("PictureBox2");
		((Control)PictureBox2).set_Size(new Size(50, 50));
		PictureBox2.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox2.set_TabIndex(1);
		PictureBox2.set_TabStop(false);
		((Control)GroupBox3).get_Controls().Add((Control)(object)txtScoreThrees);
		((Control)GroupBox3).get_Controls().Add((Control)(object)btnThrees);
		((Control)GroupBox3).get_Controls().Add((Control)(object)PictureBox3);
		((Control)GroupBox3).set_Location(new Point(288, 27));
		((Control)GroupBox3).set_Name("GroupBox3");
		((Control)GroupBox3).set_Size(new Size(132, 116));
		((Control)GroupBox3).set_TabIndex(5);
		GroupBox3.set_TabStop(false);
		((Control)txtScoreThrees).set_Location(new Point(27, 67));
		((Control)txtScoreThrees).set_Name("txtScoreThrees");
		((TextBoxBase)txtScoreThrees).set_ReadOnly(true);
		((Control)txtScoreThrees).set_Size(new Size(75, 20));
		((Control)txtScoreThrees).set_TabIndex(3);
		txtScoreThrees.set_TextAlign((HorizontalAlignment)2);
		((Control)btnThrees).set_Location(new Point(27, 87));
		((Control)btnThrees).set_Name("btnThrees");
		((Control)btnThrees).set_Size(new Size(75, 23));
		((Control)btnThrees).set_TabIndex(2);
		((ButtonBase)btnThrees).set_Text("Set");
		((ButtonBase)btnThrees).set_UseVisualStyleBackColor(true);
		((Control)btnThrees).set_Visible(false);
		PictureBox3.set_Image((Image)componentResourceManager.GetObject("PictureBox3.Image"));
		((Control)PictureBox3).set_Location(new Point(38, 11));
		((Control)PictureBox3).set_Name("PictureBox3");
		((Control)PictureBox3).set_Size(new Size(50, 50));
		PictureBox3.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox3.set_TabIndex(1);
		PictureBox3.set_TabStop(false);
		((Control)GroupBox4).get_Controls().Add((Control)(object)txtScoreFours);
		((Control)GroupBox4).get_Controls().Add((Control)(object)btnFours);
		((Control)GroupBox4).get_Controls().Add((Control)(object)PictureBox4);
		((Control)GroupBox4).set_Location(new Point(426, 27));
		((Control)GroupBox4).set_Name("GroupBox4");
		((Control)GroupBox4).set_Size(new Size(132, 116));
		((Control)GroupBox4).set_TabIndex(6);
		GroupBox4.set_TabStop(false);
		((Control)txtScoreFours).set_Location(new Point(27, 67));
		((Control)txtScoreFours).set_Name("txtScoreFours");
		((TextBoxBase)txtScoreFours).set_ReadOnly(true);
		((Control)txtScoreFours).set_Size(new Size(75, 20));
		((Control)txtScoreFours).set_TabIndex(3);
		txtScoreFours.set_TextAlign((HorizontalAlignment)2);
		((Control)btnFours).set_Location(new Point(27, 87));
		((Control)btnFours).set_Name("btnFours");
		((Control)btnFours).set_Size(new Size(75, 23));
		((Control)btnFours).set_TabIndex(2);
		((ButtonBase)btnFours).set_Text("Set");
		((ButtonBase)btnFours).set_UseVisualStyleBackColor(true);
		((Control)btnFours).set_Visible(false);
		PictureBox4.set_Image((Image)componentResourceManager.GetObject("PictureBox4.Image"));
		((Control)PictureBox4).set_Location(new Point(38, 11));
		((Control)PictureBox4).set_Name("PictureBox4");
		((Control)PictureBox4).set_Size(new Size(50, 50));
		PictureBox4.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox4.set_TabIndex(1);
		PictureBox4.set_TabStop(false);
		((Control)GroupBox5).get_Controls().Add((Control)(object)txtScoreFives);
		((Control)GroupBox5).get_Controls().Add((Control)(object)btnFives);
		((Control)GroupBox5).get_Controls().Add((Control)(object)PictureBox5);
		((Control)GroupBox5).set_Location(new Point(564, 27));
		((Control)GroupBox5).set_Name("GroupBox5");
		((Control)GroupBox5).set_Size(new Size(132, 116));
		((Control)GroupBox5).set_TabIndex(7);
		GroupBox5.set_TabStop(false);
		((Control)txtScoreFives).set_Location(new Point(27, 67));
		((Control)txtScoreFives).set_Name("txtScoreFives");
		((TextBoxBase)txtScoreFives).set_ReadOnly(true);
		((Control)txtScoreFives).set_Size(new Size(75, 20));
		((Control)txtScoreFives).set_TabIndex(3);
		txtScoreFives.set_TextAlign((HorizontalAlignment)2);
		((Control)btnFives).set_Location(new Point(27, 87));
		((Control)btnFives).set_Name("btnFives");
		((Control)btnFives).set_Size(new Size(75, 23));
		((Control)btnFives).set_TabIndex(2);
		((ButtonBase)btnFives).set_Text("Set");
		((ButtonBase)btnFives).set_UseVisualStyleBackColor(true);
		((Control)btnFives).set_Visible(false);
		PictureBox5.set_Image((Image)componentResourceManager.GetObject("PictureBox5.Image"));
		((Control)PictureBox5).set_Location(new Point(38, 11));
		((Control)PictureBox5).set_Name("PictureBox5");
		((Control)PictureBox5).set_Size(new Size(50, 50));
		PictureBox5.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox5.set_TabIndex(1);
		PictureBox5.set_TabStop(false);
		((Control)GroupBox10).get_Controls().Add((Control)(object)txtScoreSixes);
		((Control)GroupBox10).get_Controls().Add((Control)(object)btnSixes);
		((Control)GroupBox10).get_Controls().Add((Control)(object)PictureBox6);
		((Control)GroupBox10).set_Location(new Point(702, 27));
		((Control)GroupBox10).set_Name("GroupBox10");
		((Control)GroupBox10).set_Size(new Size(132, 116));
		((Control)GroupBox10).set_TabIndex(8);
		GroupBox10.set_TabStop(false);
		((Control)txtScoreSixes).set_Location(new Point(27, 67));
		((Control)txtScoreSixes).set_Name("txtScoreSixes");
		((TextBoxBase)txtScoreSixes).set_ReadOnly(true);
		((Control)txtScoreSixes).set_Size(new Size(75, 20));
		((Control)txtScoreSixes).set_TabIndex(3);
		txtScoreSixes.set_TextAlign((HorizontalAlignment)2);
		((Control)btnSixes).set_Location(new Point(27, 87));
		((Control)btnSixes).set_Name("btnSixes");
		((Control)btnSixes).set_Size(new Size(75, 23));
		((Control)btnSixes).set_TabIndex(2);
		((ButtonBase)btnSixes).set_Text("Set");
		((ButtonBase)btnSixes).set_UseVisualStyleBackColor(true);
		((Control)btnSixes).set_Visible(false);
		PictureBox6.set_Image((Image)componentResourceManager.GetObject("PictureBox6.Image"));
		((Control)PictureBox6).set_Location(new Point(39, 11));
		((Control)PictureBox6).set_Name("PictureBox6");
		((Control)PictureBox6).set_Size(new Size(50, 50));
		PictureBox6.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox6.set_TabIndex(1);
		PictureBox6.set_TabStop(false);
		((Control)GroupBox6).get_Controls().Add((Control)(object)txtScore3OAK);
		((Control)GroupBox6).get_Controls().Add((Control)(object)btn3OAK);
		((Control)GroupBox6).get_Controls().Add((Control)(object)PictureBox8);
		((Control)GroupBox6).set_Location(new Point(150, 149));
		((Control)GroupBox6).set_Name("GroupBox6");
		((Control)GroupBox6).set_Size(new Size(132, 116));
		((Control)GroupBox6).set_TabIndex(9);
		GroupBox6.set_TabStop(false);
		((Control)txtScore3OAK).set_Location(new Point(27, 67));
		((Control)txtScore3OAK).set_Name("txtScore3OAK");
		((TextBoxBase)txtScore3OAK).set_ReadOnly(true);
		((Control)txtScore3OAK).set_Size(new Size(75, 20));
		((Control)txtScore3OAK).set_TabIndex(3);
		txtScore3OAK.set_TextAlign((HorizontalAlignment)2);
		((Control)btn3OAK).set_Location(new Point(27, 87));
		((Control)btn3OAK).set_Name("btn3OAK");
		((Control)btn3OAK).set_Size(new Size(75, 23));
		((Control)btn3OAK).set_TabIndex(2);
		((ButtonBase)btn3OAK).set_Text("Set");
		((ButtonBase)btn3OAK).set_UseVisualStyleBackColor(true);
		((Control)btn3OAK).set_Visible(false);
		((Control)PictureBox8).set_Location(new Point(38, 11));
		((Control)PictureBox8).set_Name("PictureBox8");
		((Control)PictureBox8).set_Size(new Size(50, 50));
		PictureBox8.set_TabIndex(1);
		PictureBox8.set_TabStop(false);
		((Control)GroupBox7).get_Controls().Add((Control)(object)txtScore4OAK);
		((Control)GroupBox7).get_Controls().Add((Control)(object)btn4OAK);
		((Control)GroupBox7).get_Controls().Add((Control)(object)PictureBox9);
		((Control)GroupBox7).set_Location(new Point(288, 149));
		((Control)GroupBox7).set_Name("GroupBox7");
		((Control)GroupBox7).set_Size(new Size(132, 116));
		((Control)GroupBox7).set_TabIndex(10);
		GroupBox7.set_TabStop(false);
		((Control)txtScore4OAK).set_Location(new Point(27, 67));
		((Control)txtScore4OAK).set_Name("txtScore4OAK");
		((TextBoxBase)txtScore4OAK).set_ReadOnly(true);
		((Control)txtScore4OAK).set_Size(new Size(75, 20));
		((Control)txtScore4OAK).set_TabIndex(3);
		txtScore4OAK.set_TextAlign((HorizontalAlignment)2);
		((Control)btn4OAK).set_Location(new Point(27, 87));
		((Control)btn4OAK).set_Name("btn4OAK");
		((Control)btn4OAK).set_Size(new Size(75, 23));
		((Control)btn4OAK).set_TabIndex(2);
		((ButtonBase)btn4OAK).set_Text("Set");
		((ButtonBase)btn4OAK).set_UseVisualStyleBackColor(true);
		((Control)btn4OAK).set_Visible(false);
		((Control)PictureBox9).set_Location(new Point(38, 11));
		((Control)PictureBox9).set_Name("PictureBox9");
		((Control)PictureBox9).set_Size(new Size(50, 50));
		PictureBox9.set_TabIndex(1);
		PictureBox9.set_TabStop(false);
		((Control)GroupBox8).get_Controls().Add((Control)(object)txtScoreFullHouse);
		((Control)GroupBox8).get_Controls().Add((Control)(object)btnFullHouse);
		((Control)GroupBox8).get_Controls().Add((Control)(object)PictureBox10);
		((Control)GroupBox8).set_Location(new Point(426, 149));
		((Control)GroupBox8).set_Name("GroupBox8");
		((Control)GroupBox8).set_Size(new Size(132, 116));
		((Control)GroupBox8).set_TabIndex(11);
		GroupBox8.set_TabStop(false);
		((Control)txtScoreFullHouse).set_Location(new Point(27, 67));
		((Control)txtScoreFullHouse).set_Name("txtScoreFullHouse");
		((TextBoxBase)txtScoreFullHouse).set_ReadOnly(true);
		((Control)txtScoreFullHouse).set_Size(new Size(75, 20));
		((Control)txtScoreFullHouse).set_TabIndex(3);
		txtScoreFullHouse.set_TextAlign((HorizontalAlignment)2);
		((Control)btnFullHouse).set_Location(new Point(27, 87));
		((Control)btnFullHouse).set_Name("btnFullHouse");
		((Control)btnFullHouse).set_Size(new Size(75, 23));
		((Control)btnFullHouse).set_TabIndex(2);
		((ButtonBase)btnFullHouse).set_Text("Set");
		((ButtonBase)btnFullHouse).set_UseVisualStyleBackColor(true);
		((Control)btnFullHouse).set_Visible(false);
		((Control)PictureBox10).set_Location(new Point(38, 11));
		((Control)PictureBox10).set_Name("PictureBox10");
		((Control)PictureBox10).set_Size(new Size(50, 50));
		PictureBox10.set_TabIndex(1);
		PictureBox10.set_TabStop(false);
		((Control)GroupBox9).get_Controls().Add((Control)(object)txtScoreYahtzee);
		((Control)GroupBox9).get_Controls().Add((Control)(object)btnYahtzee);
		((Control)GroupBox9).get_Controls().Add((Control)(object)PictureBox11);
		((Control)GroupBox9).set_Location(new Point(564, 149));
		((Control)GroupBox9).set_Name("GroupBox9");
		((Control)GroupBox9).set_Size(new Size(132, 116));
		((Control)GroupBox9).set_TabIndex(12);
		GroupBox9.set_TabStop(false);
		((Control)txtScoreYahtzee).set_Location(new Point(27, 67));
		((Control)txtScoreYahtzee).set_Name("txtScoreYahtzee");
		((TextBoxBase)txtScoreYahtzee).set_ReadOnly(true);
		((Control)txtScoreYahtzee).set_Size(new Size(75, 20));
		((Control)txtScoreYahtzee).set_TabIndex(3);
		txtScoreYahtzee.set_TextAlign((HorizontalAlignment)2);
		((Control)btnYahtzee).set_Location(new Point(27, 87));
		((Control)btnYahtzee).set_Name("btnYahtzee");
		((Control)btnYahtzee).set_Size(new Size(75, 23));
		((Control)btnYahtzee).set_TabIndex(2);
		((ButtonBase)btnYahtzee).set_Text("Set");
		((ButtonBase)btnYahtzee).set_UseVisualStyleBackColor(true);
		((Control)btnYahtzee).set_Visible(false);
		((Control)PictureBox11).set_Location(new Point(38, 11));
		((Control)PictureBox11).set_Name("PictureBox11");
		((Control)PictureBox11).set_Size(new Size(50, 50));
		PictureBox11.set_TabIndex(1);
		PictureBox11.set_TabStop(false);
		((ToolStrip)MenuStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)NewGameToolStripMenuItem,
			(ToolStripItem)HelpToolStripMenuItem,
			(ToolStripItem)AboutToolStripMenuItem
		});
		((Control)MenuStrip1).set_Location(new Point(0, 0));
		((Control)MenuStrip1).set_Name("MenuStrip1");
		((Control)MenuStrip1).set_Size(new Size(844, 24));
		((Control)MenuStrip1).set_TabIndex(13);
		((Control)MenuStrip1).set_Text("MenuStrip1");
		((ToolStripItem)NewGameToolStripMenuItem).set_Name("NewGameToolStripMenuItem");
		NewGameToolStripMenuItem.set_ShortcutKeys((Keys)131150);
		((ToolStripItem)NewGameToolStripMenuItem).set_Size(new Size(77, 20));
		((ToolStripItem)NewGameToolStripMenuItem).set_Text("New Game");
		((ToolStripItem)HelpToolStripMenuItem).set_Name("HelpToolStripMenuItem");
		HelpToolStripMenuItem.set_ShortcutKeys((Keys)112);
		((ToolStripItem)HelpToolStripMenuItem).set_Size(new Size(44, 20));
		((ToolStripItem)HelpToolStripMenuItem).set_Text("Help");
		((ToolStripItem)AboutToolStripMenuItem).set_Name("AboutToolStripMenuItem");
		AboutToolStripMenuItem.set_ShortcutKeys((Keys)113);
		((ToolStripItem)AboutToolStripMenuItem).set_Size(new Size(52, 20));
		((ToolStripItem)AboutToolStripMenuItem).set_Text("About");
		((Control)Panel1).get_Controls().Add((Control)(object)PbxDiceLock5);
		((Control)Panel1).get_Controls().Add((Control)(object)PbxDiceLock4);
		((Control)Panel1).get_Controls().Add((Control)(object)PbxDiceLock3);
		((Control)Panel1).get_Controls().Add((Control)(object)PbxDiceLock2);
		((Control)Panel1).get_Controls().Add((Control)(object)PbxDiceLock1);
		((Control)Panel1).get_Controls().Add((Control)(object)pbxResult5);
		((Control)Panel1).get_Controls().Add((Control)(object)pbxResult4);
		((Control)Panel1).get_Controls().Add((Control)(object)pbxResult3);
		((Control)Panel1).get_Controls().Add((Control)(object)pbxResult2);
		((Control)Panel1).get_Controls().Add((Control)(object)pbxResult1);
		((Control)Panel1).set_Location(new Point(150, 326));
		((Control)Panel1).set_Name("Panel1");
		((Control)Panel1).set_Size(new Size(546, 113));
		((Control)Panel1).set_TabIndex(14);
		((Control)PbxDiceLock5).set_Location(new Point(488, 80));
		((Control)PbxDiceLock5).set_Name("PbxDiceLock5");
		((Control)PbxDiceLock5).set_Size(new Size(20, 20));
		PbxDiceLock5.set_SizeMode((PictureBoxSizeMode)1);
		PbxDiceLock5.set_TabIndex(14);
		PbxDiceLock5.set_TabStop(false);
		((Control)PbxDiceLock5).set_Visible(false);
		((Control)PbxDiceLock4).set_Location(new Point(378, 80));
		((Control)PbxDiceLock4).set_Name("PbxDiceLock4");
		((Control)PbxDiceLock4).set_Size(new Size(20, 20));
		PbxDiceLock4.set_SizeMode((PictureBoxSizeMode)1);
		PbxDiceLock4.set_TabIndex(13);
		PbxDiceLock4.set_TabStop(false);
		((Control)PbxDiceLock4).set_Visible(false);
		((Control)PbxDiceLock3).set_Location(new Point(265, 80));
		((Control)PbxDiceLock3).set_Name("PbxDiceLock3");
		((Control)PbxDiceLock3).set_Size(new Size(20, 20));
		PbxDiceLock3.set_SizeMode((PictureBoxSizeMode)1);
		PbxDiceLock3.set_TabIndex(12);
		PbxDiceLock3.set_TabStop(false);
		((Control)PbxDiceLock3).set_Visible(false);
		((Control)PbxDiceLock2).set_Location(new Point(152, 80));
		((Control)PbxDiceLock2).set_Name("PbxDiceLock2");
		((Control)PbxDiceLock2).set_Size(new Size(20, 20));
		PbxDiceLock2.set_SizeMode((PictureBoxSizeMode)1);
		PbxDiceLock2.set_TabIndex(11);
		PbxDiceLock2.set_TabStop(false);
		((Control)PbxDiceLock2).set_Visible(false);
		((Control)PbxDiceLock1).set_Location(new Point(40, 80));
		((Control)PbxDiceLock1).set_Name("PbxDiceLock1");
		((Control)PbxDiceLock1).set_Size(new Size(20, 20));
		PbxDiceLock1.set_SizeMode((PictureBoxSizeMode)1);
		PbxDiceLock1.set_TabIndex(10);
		PbxDiceLock1.set_TabStop(false);
		((Control)PbxDiceLock1).set_Visible(false);
		((Control)pbxResult5).set_Location(new Point(474, 10));
		((Control)pbxResult5).set_Name("pbxResult5");
		((Control)pbxResult5).set_Size(new Size(50, 50));
		pbxResult5.set_SizeMode((PictureBoxSizeMode)1);
		pbxResult5.set_TabIndex(9);
		pbxResult5.set_TabStop(false);
		((Control)pbxResult4).set_Location(new Point(362, 10));
		((Control)pbxResult4).set_Name("pbxResult4");
		((Control)pbxResult4).set_Size(new Size(50, 50));
		pbxResult4.set_SizeMode((PictureBoxSizeMode)1);
		pbxResult4.set_TabIndex(8);
		pbxResult4.set_TabStop(false);
		((Control)pbxResult3).set_Location(new Point(250, 10));
		((Control)pbxResult3).set_Name("pbxResult3");
		((Control)pbxResult3).set_Size(new Size(50, 50));
		pbxResult3.set_SizeMode((PictureBoxSizeMode)1);
		pbxResult3.set_TabIndex(7);
		pbxResult3.set_TabStop(false);
		pbxResult2.set_InitialImage((Image)null);
		((Control)pbxResult2).set_Location(new Point(138, 10));
		((Control)pbxResult2).set_Name("pbxResult2");
		((Control)pbxResult2).set_Size(new Size(50, 50));
		pbxResult2.set_SizeMode((PictureBoxSizeMode)1);
		pbxResult2.set_TabIndex(5);
		pbxResult2.set_TabStop(false);
		pbxResult1.set_InitialImage((Image)null);
		((Control)pbxResult1).set_Location(new Point(27, 10));
		((Control)pbxResult1).set_Name("pbxResult1");
		((Control)pbxResult1).set_Size(new Size(50, 50));
		pbxResult1.set_SizeMode((PictureBoxSizeMode)1);
		pbxResult1.set_TabIndex(4);
		pbxResult1.set_TabStop(false);
		((Control)btnRoll).set_Location(new Point(387, 445));
		((Control)btnRoll).set_Name("btnRoll");
		((Control)btnRoll).set_Size(new Size(75, 23));
		((Control)btnRoll).set_TabIndex(15);
		((ButtonBase)btnRoll).set_Text("Roll");
		((ButtonBase)btnRoll).set_UseVisualStyleBackColor(true);
		lblTotalScore.set_AutoSize(true);
		((Control)lblTotalScore).set_Location(new Point(46, 197));
		((Control)lblTotalScore).set_Name("lblTotalScore");
		((Control)lblTotalScore).set_Size(new Size(62, 13));
		((Control)lblTotalScore).set_TabIndex(18);
		lblTotalScore.set_Text("Total Score");
		lblTotalScore.set_TextAlign((ContentAlignment)32);
		((Control)txtTotalScore).set_Location(new Point(49, 213));
		((Control)txtTotalScore).set_Name("txtTotalScore");
		((TextBoxBase)txtTotalScore).set_ReadOnly(true);
		((Control)txtTotalScore).set_Size(new Size(59, 20));
		((Control)txtTotalScore).set_TabIndex(19);
		txtTotalScore.set_TextAlign((HorizontalAlignment)2);
		lblRoundCounter.set_AutoSize(true);
		((Control)lblRoundCounter).set_Font(new Font("Microsoft Sans Serif", 20f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblRoundCounter).set_Location(new Point(362, 283));
		((Control)lblRoundCounter).set_Name("lblRoundCounter");
		((Control)lblRoundCounter).set_Size(new Size(124, 31));
		((Control)lblRoundCounter).set_TabIndex(20);
		lblRoundCounter.set_Text("Round: 1");
		((Control)btnEndTurn).set_Location(new Point(387, 445));
		((Control)btnEndTurn).set_Name("btnEndTurn");
		((Control)btnEndTurn).set_Size(new Size(75, 23));
		((Control)btnEndTurn).set_TabIndex(21);
		((ButtonBase)btnEndTurn).set_Text("End Turn");
		((ButtonBase)btnEndTurn).set_UseVisualStyleBackColor(true);
		((Control)btnEndTurn).set_Visible(false);
		((Control)btnReroll).set_Location(new Point(716, 445));
		((Control)btnReroll).set_Name("btnReroll");
		((Control)btnReroll).set_Size(new Size(75, 23));
		((Control)btnReroll).set_TabIndex(22);
		((ButtonBase)btnReroll).set_Text("Re-Roll");
		((ButtonBase)btnReroll).set_UseVisualStyleBackColor(true);
		((Control)btnReroll).set_Visible(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(844, 491));
		((Control)this).get_Controls().Add((Control)(object)btnReroll);
		((Control)this).get_Controls().Add((Control)(object)btnEndTurn);
		((Control)this).get_Controls().Add((Control)(object)lblRoundCounter);
		((Control)this).get_Controls().Add((Control)(object)txtTotalScore);
		((Control)this).get_Controls().Add((Control)(object)lblTotalScore);
		((Control)this).get_Controls().Add((Control)(object)btnRoll);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Control)this).get_Controls().Add((Control)(object)GroupBox9);
		((Control)this).get_Controls().Add((Control)(object)GroupBox8);
		((Control)this).get_Controls().Add((Control)(object)GroupBox7);
		((Control)this).get_Controls().Add((Control)(object)GroupBox6);
		((Control)this).get_Controls().Add((Control)(object)GroupBox10);
		((Control)this).get_Controls().Add((Control)(object)GroupBox5);
		((Control)this).get_Controls().Add((Control)(object)GroupBox4);
		((Control)this).get_Controls().Add((Control)(object)GroupBox3);
		((Control)this).get_Controls().Add((Control)(object)GroupBox2);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)MenuStrip1);
		((Form)this).set_MainMenuStrip(MenuStrip1);
		((Form)this).set_MaximumSize(new Size(860, 530));
		((Form)this).set_MinimumSize(new Size(860, 530));
		((Control)this).set_Name("FrmMain");
		((Form)this).set_Text("Not Yahtzee");
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)GroupBox2).ResumeLayout(false);
		((Control)GroupBox2).PerformLayout();
		((ISupportInitialize)PictureBox2).EndInit();
		((Control)GroupBox3).ResumeLayout(false);
		((Control)GroupBox3).PerformLayout();
		((ISupportInitialize)PictureBox3).EndInit();
		((Control)GroupBox4).ResumeLayout(false);
		((Control)GroupBox4).PerformLayout();
		((ISupportInitialize)PictureBox4).EndInit();
		((Control)GroupBox5).ResumeLayout(false);
		((Control)GroupBox5).PerformLayout();
		((ISupportInitialize)PictureBox5).EndInit();
		((Control)GroupBox10).ResumeLayout(false);
		((Control)GroupBox10).PerformLayout();
		((ISupportInitialize)PictureBox6).EndInit();
		((Control)GroupBox6).ResumeLayout(false);
		((Control)GroupBox6).PerformLayout();
		((ISupportInitialize)PictureBox8).EndInit();
		((Control)GroupBox7).ResumeLayout(false);
		((Control)GroupBox7).PerformLayout();
		((ISupportInitialize)PictureBox9).EndInit();
		((Control)GroupBox8).ResumeLayout(false);
		((Control)GroupBox8).PerformLayout();
		((ISupportInitialize)PictureBox10).EndInit();
		((Control)GroupBox9).ResumeLayout(false);
		((Control)GroupBox9).PerformLayout();
		((ISupportInitialize)PictureBox11).EndInit();
		((Control)MenuStrip1).ResumeLayout(false);
		((Control)MenuStrip1).PerformLayout();
		((Control)Panel1).ResumeLayout(false);
		((ISupportInitialize)PbxDiceLock5).EndInit();
		((ISupportInitialize)PbxDiceLock4).EndInit();
		((ISupportInitialize)PbxDiceLock3).EndInit();
		((ISupportInitialize)PbxDiceLock2).EndInit();
		((ISupportInitialize)PbxDiceLock1).EndInit();
		((ISupportInitialize)pbxResult5).EndInit();
		((ISupportInitialize)pbxResult4).EndInit();
		((ISupportInitialize)pbxResult3).EndInit();
		((ISupportInitialize)pbxResult2).EndInit();
		((ISupportInitialize)pbxResult1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public void OnStart()
	{
		((Control)btnRoll).Select();
	}

	public int GetRandom()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		if (_0024STATIC_0024GetRandom_00242008_0024Generator_0024Init == null)
		{
			Interlocked.CompareExchange(ref _0024STATIC_0024GetRandom_00242008_0024Generator_0024Init, new StaticLocalInitFlag(), null);
		}
		bool lockTaken = false;
		try
		{
			Monitor.Enter(_0024STATIC_0024GetRandom_00242008_0024Generator_0024Init, ref lockTaken);
			if (_0024STATIC_0024GetRandom_00242008_0024Generator_0024Init.State == 0)
			{
				_0024STATIC_0024GetRandom_00242008_0024Generator_0024Init.State = 2;
				_0024STATIC_0024GetRandom_00242008_0024Generator = new Random();
			}
			else if (_0024STATIC_0024GetRandom_00242008_0024Generator_0024Init.State == 2)
			{
				throw new IncompleteInitialization();
			}
		}
		finally
		{
			_0024STATIC_0024GetRandom_00242008_0024Generator_0024Init.State = 1;
			if (lockTaken)
			{
				Monitor.Exit(_0024STATIC_0024GetRandom_00242008_0024Generator_0024Init);
			}
		}
		return _0024STATIC_0024GetRandom_00242008_0024Generator.Next(1, 7);
	}

	public void DiceRoller()
	{
		RandomsList.Clear();
		checked
		{
			int num = DiceArray.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				if ((i == 0) & !DiceOneLocked)
				{
					DiceArray[0] = GetRandom();
				}
				else if ((i == 1) & !DiceTwoLocked)
				{
					DiceArray[1] = GetRandom();
				}
				else if ((i == 2) & !DiceThreeLocked)
				{
					DiceArray[2] = GetRandom();
				}
				else if ((i == 3) & !DiceFourLocked)
				{
					DiceArray[3] = GetRandom();
				}
				else if ((i == 4) & !DiceFiveLocked)
				{
					DiceArray[4] = GetRandom();
				}
			}
		}
	}

	public void ShowDice(int i, int e)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		checked
		{
			switch (i)
			{
			case 0:
				pbxResult1.set_Image((Image)DicePic[e - 1]);
				break;
			case 1:
				pbxResult2.set_Image((Image)DicePic[e - 1]);
				break;
			case 2:
				pbxResult3.set_Image((Image)DicePic[e - 1]);
				break;
			case 3:
				pbxResult4.set_Image((Image)DicePic[e - 1]);
				break;
			case 4:
				pbxResult5.set_Image((Image)DicePic[e - 1]);
				break;
			}
		}
	}

	public void DiceCombo()
	{
	}

	public void DiceComboMatcher(int i, int b)
	{
		checked
		{
			switch (i)
			{
			case 1:
				if ((object)txtScoreAces.get_Text() == "")
				{
					((Control)btnAces).set_Visible(true);
					UpperScores[0] = 1 * b;
				}
				break;
			case 2:
				if ((object)txtScoreTwos.get_Text() == "")
				{
					((Control)btnTwos).set_Visible(true);
					UpperScores[1] = 2 * b;
				}
				break;
			case 3:
				if ((object)txtScoreThrees.get_Text() == "")
				{
					((Control)btnThrees).set_Visible(true);
					UpperScores[2] = 3 * b;
				}
				break;
			case 4:
				if ((object)txtScoreFours.get_Text() == "")
				{
					((Control)btnFours).set_Visible(true);
					UpperScores[3] = 4 * b;
				}
				break;
			case 5:
				if ((object)txtScoreFives.get_Text() == "")
				{
					((Control)btnFives).set_Visible(true);
					UpperScores[4] = 5 * b;
				}
				break;
			case 6:
				if ((object)txtScoreSixes.get_Text() == "")
				{
					((Control)btnSixes).set_Visible(true);
					UpperScores[5] = 6 * b;
				}
				break;
			}
		}
	}

	private void BtnRoll_Click(object sender, EventArgs e)
	{
		DiceRoller();
		DiceCombo();
		((Control)pbxResult1).set_Visible(true);
		((Control)pbxResult2).set_Visible(true);
		((Control)pbxResult3).set_Visible(true);
		((Control)pbxResult4).set_Visible(true);
		((Control)pbxResult5).set_Visible(true);
		((Control)btnRoll).set_Visible(false);
		((Control)btnEndTurn).set_Visible(true);
		((Control)btnReroll).set_Visible(true);
		((Control)btnReroll).Select();
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public void EndTurn()
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Invalid comparison between Unknown and I4
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Invalid comparison between Unknown and I4
		checked
		{
			intRoundCount++;
		}
		if (intRoundCount < 11)
		{
			lblRoundCounter.set_Text("Round: " + Conversions.ToString(intRoundCount));
			((ButtonBase)btnEndTurn).set_Text("End Turn");
		}
		else if (intRoundCount >= 10)
		{
			((ButtonBase)btnEndTurn).set_Text("End Game");
			Interaction.MsgBox((object)("Game Over\r\nTotal Score: " + Conversions.ToString(TotalScore)), (MsgBoxStyle)0, (object)null);
			MsgBoxResult val = Interaction.MsgBox((object)"Do you wish to play again?", (MsgBoxStyle)4, (object)null);
			if ((int)val == 6)
			{
				Application.Restart();
			}
			else if ((int)val == 7)
			{
				ProjectData.EndApp();
			}
		}
		RerollCount = 0;
		((Control)btnRoll).set_Visible(true);
		((Control)btnRoll).Select();
		((Control)btnReroll).set_Visible(false);
		((Control)btnEndTurn).set_Visible(false);
		((Control)pbxResult1).set_Visible(false);
		((Control)pbxResult2).set_Visible(false);
		((Control)pbxResult3).set_Visible(false);
		((Control)pbxResult4).set_Visible(false);
		((Control)pbxResult5).set_Visible(false);
		HideScoreBoxes();
		HideDiceLock();
	}

	public void HideScoreBoxes()
	{
		((Control)btnAces).set_Visible(false);
		((Control)btnTwos).set_Visible(false);
		((Control)btnThrees).set_Visible(false);
		((Control)btnFours).set_Visible(false);
		((Control)btnFives).set_Visible(false);
		((Control)btnSixes).set_Visible(false);
		((Control)btn3OAK).set_Visible(false);
		((Control)btn4OAK).set_Visible(false);
		((Control)btnFullHouse).set_Visible(false);
		((Control)btnYahtzee).set_Visible(false);
	}

	public void HideDiceLock()
	{
		((Control)PbxDiceLock1).set_Visible(false);
		((Control)PbxDiceLock2).set_Visible(false);
		((Control)PbxDiceLock3).set_Visible(false);
		((Control)PbxDiceLock4).set_Visible(false);
		((Control)PbxDiceLock5).set_Visible(false);
		DiceOneLocked = false;
		DiceTwoLocked = false;
		DiceThreeLocked = false;
		DiceFourLocked = false;
		DiceFiveLocked = false;
	}

	public void AddToTotal(int i)
	{
		checked
		{
			TotalScore += i;
			txtTotalScore.set_Text(Conversions.ToString(TotalScore));
			((Control)btnEndTurn).set_Visible(true);
		}
	}

	private void BtnAces_Click(object sender, EventArgs e)
	{
		txtScoreAces.set_Text(Conversions.ToString(UpperScores[0]));
		AddToTotal(Conversions.ToInteger(UpperScores[0]));
		((Control)btnAces).set_Visible(false);
		EndTurn();
	}

	private void BtnTwos_Click(object sender, EventArgs e)
	{
		txtScoreTwos.set_Text(Conversions.ToString(UpperScores[1]));
		AddToTotal(Conversions.ToInteger(UpperScores[1]));
		((Control)btnTwos).set_Visible(false);
		EndTurn();
	}

	private void BtnThrees_Click(object sender, EventArgs e)
	{
		txtScoreThrees.set_Text(Conversions.ToString(UpperScores[2]));
		AddToTotal(Conversions.ToInteger(UpperScores[2]));
		((Control)btnThrees).set_Visible(false);
		EndTurn();
	}

	private void BtnFours_Click(object sender, EventArgs e)
	{
		txtScoreFours.set_Text(Conversions.ToString(UpperScores[3]));
		AddToTotal(Conversions.ToInteger(UpperScores[3]));
		((Control)btnFours).set_Visible(false);
		EndTurn();
	}

	private void BtnFives_Click(object sender, EventArgs e)
	{
		txtScoreFives.set_Text(Conversions.ToString(UpperScores[4]));
		AddToTotal(Conversions.ToInteger(UpperScores[4]));
		((Control)btnFives).set_Visible(false);
		EndTurn();
	}

	private void BtnSixes_Click(object sender, EventArgs e)
	{
		txtScoreSixes.set_Text(Conversions.ToString(UpperScores[5]));
		AddToTotal(Conversions.ToInteger(UpperScores[5]));
		((Control)btnFives).set_Visible(false);
		EndTurn();
	}

	private void Btn3OAK_Click(object sender, EventArgs e)
	{
		txtScore3OAK.set_Text(Conversions.ToString(LowerScores[0]));
		AddToTotal(Conversions.ToInteger(LowerScores[0]));
		((Control)btn3OAK).set_Visible(false);
		EndTurn();
	}

	private void Btn4OAK_Click(object sender, EventArgs e)
	{
		txtScore4OAK.set_Text(Conversions.ToString(LowerScores[1]));
		AddToTotal(Conversions.ToInteger(LowerScores[1]));
		((Control)btn4OAK).set_Visible(false);
		EndTurn();
	}

	private void BtnFullHouse_Click(object sender, EventArgs e)
	{
		txtScoreFullHouse.set_Text(Conversions.ToString(LowerScores[2]));
		AddToTotal(Conversions.ToInteger(LowerScores[2]));
		((Control)btnFullHouse).set_Visible(false);
		EndTurn();
	}

	private void BtnYahtzee_Click(object sender, EventArgs e)
	{
		txtScoreYahtzee.set_Text(Conversions.ToString(LowerScores[3]));
		AddToTotal(Conversions.ToInteger(LowerScores[3]));
		((Control)btnYahtzee).set_Visible(false);
		EndTurn();
	}

	private void BtnEndTurn_Click(object sender, EventArgs e)
	{
		EndTurn();
	}

	private void BtnReroll_Click(object sender, EventArgs e)
	{
		checked
		{
			RerollCount++;
			int rerollCount = RerollCount;
			if (rerollCount < 3)
			{
				DiceRoller();
				HideScoreBoxes();
				DiceCombo();
			}
			if (RerollCount > 1)
			{
				((Control)btnReroll).set_Visible(false);
				((Control)btnEndTurn).Select();
			}
		}
	}

	private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Invalid comparison between Unknown and I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Invalid comparison between Unknown and I4
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		MsgBoxResult val = Interaction.MsgBox((object)"Do you want to start a new game?", (MsgBoxStyle)4, (object)null);
		if ((int)val != 6)
		{
			if ((int)val == 7)
			{
			}
			return;
		}
		Application.Restart();
		if (TotalScore > 0)
		{
			Interaction.MsgBox((object)("Game Over\r\nTotal Score: " + Conversions.ToString(TotalScore)), (MsgBoxStyle)0, (object)null);
		}
	}

	private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		Help help = MyProject.Forms.Help;
		try
		{
			((Form)MyProject.Forms.Help).ShowDialog();
		}
		finally
		{
			((IDisposable)help)?.Dispose();
		}
	}

	private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		FrmAbout frmAbout = MyProject.Forms.FrmAbout;
		try
		{
			((Form)MyProject.Forms.FrmAbout).ShowDialog();
		}
		finally
		{
			((IDisposable)frmAbout)?.Dispose();
		}
	}

	private void PbxResult1_Click(object sender, EventArgs e)
	{
		bool diceOneLocked;
		if (diceOneLocked = DiceOneLocked)
		{
			if (diceOneLocked)
			{
			}
		}
		else
		{
			((Control)PbxDiceLock1).Show();
			DiceOneLocked = true;
		}
	}

	private void PbxResult2_Click(object sender, EventArgs e)
	{
		bool diceTwoLocked;
		if (diceTwoLocked = DiceTwoLocked)
		{
			if (diceTwoLocked)
			{
			}
		}
		else
		{
			((Control)PbxDiceLock2).Show();
			DiceTwoLocked = true;
		}
	}

	private void PbxResult3_Click(object sender, EventArgs e)
	{
		bool visible;
		if (visible = ((Control)PbxDiceLock3).get_Visible())
		{
			if (visible)
			{
			}
		}
		else
		{
			((Control)PbxDiceLock3).Show();
			DiceThreeLocked = true;
		}
	}

	private void PbxResult4_Click(object sender, EventArgs e)
	{
		bool visible;
		if (visible = ((Control)PbxDiceLock4).get_Visible())
		{
			if (visible)
			{
			}
		}
		else
		{
			((Control)PbxDiceLock4).Show();
			DiceFourLocked = true;
		}
	}

	private void PbxResult5_Click(object sender, EventArgs e)
	{
		bool visible;
		if (visible = ((Control)PbxDiceLock5).get_Visible())
		{
			if (visible)
			{
			}
		}
		else
		{
			((Control)PbxDiceLock5).Show();
			DiceFiveLocked = true;
		}
	}
}
