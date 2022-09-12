using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using ns11;
using ns3;

namespace ns16;

[DesignerGenerated]
public class MultiPlayer : Form
{
	private IContainer icontainer_0;

	[AccessedThroughProperty("tMovement")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Timer timer_0;

	[CompilerGenerated]
	[AccessedThroughProperty("tAnimation")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Timer timer_1;

	[AccessedThroughProperty("JokerFaceTransition")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Timer timer_2;

	public GClass2 gclass2_0;

	private bool bool_0;

	internal virtual Button btnMusic
	{
		[CompilerGenerated]
		get
		{
			return _btnMusic;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnMusic_Click;
			Button val = _btnMusic;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnMusic = value;
			val = _btnMusic;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("cbSongSelection")]
	internal virtual ComboBox cbSongSelection
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnQuit
	{
		[CompilerGenerated]
		get
		{
			return _btnQuit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnQuit_Click;
			Button val = _btnQuit;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnQuit = value;
			val = _btnQuit;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("pbCylinder")]
	internal virtual PictureBox pbCylinder
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnSpin
	{
		[CompilerGenerated]
		get
		{
			return _btnSpin;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnSpin_Click;
			Button val = _btnSpin;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnSpin = value;
			val = _btnSpin;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pbIndicator1")]
	internal virtual PictureBox pbIndicator1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual PictureBox pbJoker
	{
		[CompilerGenerated]
		get
		{
			return _pbJoker;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = pbJoker_Click;
			EventHandler eventHandler2 = pbJoker_MouseHover;
			EventHandler eventHandler3 = pbJoker_MouseLeave;
			PictureBox val = _pbJoker;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
				((Control)val).remove_MouseHover(eventHandler2);
				((Control)val).remove_MouseLeave(eventHandler3);
			}
			_pbJoker = value;
			val = _pbJoker;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
				((Control)val).add_MouseHover(eventHandler2);
				((Control)val).add_MouseLeave(eventHandler3);
			}
		}
	}

	internal virtual PictureBox pbSecondPlayer
	{
		[CompilerGenerated]
		get
		{
			return _pbSecondPlayer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = pbSecondPlayer_Click;
			EventHandler eventHandler2 = pbSecondPlayer_MouseHover;
			EventHandler eventHandler3 = pbSecondPlayer_MouseLeave;
			PictureBox val = _pbSecondPlayer;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
				((Control)val).remove_MouseHover(eventHandler2);
				((Control)val).remove_MouseLeave(eventHandler3);
			}
			_pbSecondPlayer = value;
			val = _pbSecondPlayer;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
				((Control)val).add_MouseHover(eventHandler2);
				((Control)val).add_MouseLeave(eventHandler3);
			}
		}
	}

	internal virtual Timer tMovement
	{
		[CompilerGenerated]
		get
		{
			return timer_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = tMovement_Tick;
			Timer val = timer_0;
			if (val != null)
			{
				val.remove_Tick(eventHandler);
			}
			timer_0 = value;
			val = timer_0;
			if (val != null)
			{
				val.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer tAnimation
	{
		[CompilerGenerated]
		get
		{
			return timer_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = tAnimation_Tick;
			Timer val = timer_1;
			if (val != null)
			{
				val.remove_Tick(eventHandler);
			}
			timer_1 = value;
			val = timer_1;
			if (val != null)
			{
				val.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer JokerFaceTransition
	{
		[CompilerGenerated]
		get
		{
			return timer_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = JokerFaceTransition_Tick;
			Timer val = timer_2;
			if (val != null)
			{
				val.remove_Tick(eventHandler);
			}
			timer_2 = value;
			val = timer_2;
			if (val != null)
			{
				val.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Button btnPlayer1
	{
		[CompilerGenerated]
		get
		{
			return _btnPlayer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnPlayer1_Click;
			Button val = _btnPlayer1;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnPlayer1 = value;
			val = _btnPlayer1;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button btnPlayer2
	{
		[CompilerGenerated]
		get
		{
			return _btnPlayer2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnPlayer2_Click;
			Button val = _btnPlayer2;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnPlayer2 = value;
			val = _btnPlayer2;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button btnRandom
	{
		[CompilerGenerated]
		get
		{
			return _btnRandom;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnRandom_Click;
			Button val = _btnRandom;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnRandom = value;
			val = _btnRandom;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("lblWhosTurn")]
	internal virtual Label lblWhosTurn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual PictureBox pbCheat
	{
		[CompilerGenerated]
		get
		{
			return _pbCheat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = pbCheat_Click;
			PictureBox val = _pbCheat;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_pbCheat = value;
			val = _pbCheat;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("lblAnswer")]
	internal virtual Label lblAnswer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblSubHeader")]
	internal virtual Label lblSubHeader
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public MultiPlayer()
	{
		((Form)this).add_Load((EventHandler)MultiPlayer_Load);
		gclass2_0 = new GClass2();
		bool_0 = true;
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && icontainer_0 != null)
			{
				icontainer_0.Dispose();
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
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Expected O, but got Unknown
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0395: Expected O, but got Unknown
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Expected O, but got Unknown
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Expected O, but got Unknown
		//IL_0564: Unknown result type (might be due to invalid IL or missing references)
		//IL_056e: Expected O, but got Unknown
		//IL_067f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0689: Expected O, but got Unknown
		//IL_073e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0748: Expected O, but got Unknown
		//IL_0801: Unknown result type (might be due to invalid IL or missing references)
		//IL_080b: Expected O, but got Unknown
		//IL_09af: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b9: Expected O, but got Unknown
		//IL_0a5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a69: Expected O, but got Unknown
		//IL_0af0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afa: Expected O, but got Unknown
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(MultiPlayer));
		btnMusic = new Button();
		cbSongSelection = new ComboBox();
		btnQuit = new Button();
		pbCylinder = new PictureBox();
		btnSpin = new Button();
		PictureBox1 = new PictureBox();
		pbIndicator1 = new PictureBox();
		pbJoker = new PictureBox();
		pbSecondPlayer = new PictureBox();
		tMovement = new Timer(icontainer_0);
		tAnimation = new Timer(icontainer_0);
		JokerFaceTransition = new Timer(icontainer_0);
		btnPlayer1 = new Button();
		btnPlayer2 = new Button();
		btnRandom = new Button();
		lblWhosTurn = new Label();
		pbCheat = new PictureBox();
		lblAnswer = new Label();
		lblSubHeader = new Label();
		Label1 = new Label();
		((ISupportInitialize)pbCylinder).BeginInit();
		((ISupportInitialize)PictureBox1).BeginInit();
		((ISupportInitialize)pbIndicator1).BeginInit();
		((ISupportInitialize)pbJoker).BeginInit();
		((ISupportInitialize)pbSecondPlayer).BeginInit();
		((ISupportInitialize)pbCheat).BeginInit();
		((Control)this).SuspendLayout();
		((Control)btnMusic).set_Location(new Point(165, 471));
		((Control)btnMusic).set_Name("btnMusic");
		((Control)btnMusic).set_Size(new Size(75, 23));
		((Control)btnMusic).set_TabIndex(29);
		((ButtonBase)btnMusic).set_Text("Play / Stop");
		((ButtonBase)btnMusic).set_UseVisualStyleBackColor(true);
		((ListControl)cbSongSelection).set_FormattingEnabled(true);
		cbSongSelection.get_Items().AddRange(new object[2] { "SouthPark Intro", "What_Would_Brian_Boitano_Do" });
		((Control)cbSongSelection).set_Location(new Point(7, 471));
		((Control)cbSongSelection).set_Name("cbSongSelection");
		((Control)cbSongSelection).set_Size(new Size(142, 21));
		((Control)cbSongSelection).set_TabIndex(28);
		((ButtonBase)btnQuit).set_BackColor(SystemColors.ControlDarkDark);
		((Control)btnQuit).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)btnQuit).set_ForeColor(SystemColors.ButtonFace);
		((Control)btnQuit).set_Location(new Point(454, 467));
		((Control)btnQuit).set_Name("btnQuit");
		((Control)btnQuit).set_Size(new Size(133, 31));
		((Control)btnQuit).set_TabIndex(27);
		((ButtonBase)btnQuit).set_Text("Quit");
		((ButtonBase)btnQuit).set_UseVisualStyleBackColor(false);
		((Control)pbCylinder).set_BackColor(Color.Transparent);
		pbCylinder.set_Image((Image)componentResourceManager.GetObject("pbCylinder.Image"));
		((Control)pbCylinder).set_Location(new Point(728, 5));
		((Control)pbCylinder).set_Name("pbCylinder");
		((Control)pbCylinder).set_Size(new Size(129, 111));
		pbCylinder.set_SizeMode((PictureBoxSizeMode)4);
		pbCylinder.set_TabIndex(26);
		pbCylinder.set_TabStop(false);
		((ButtonBase)btnSpin).set_BackColor(SystemColors.ControlDarkDark);
		((Control)btnSpin).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)btnSpin).set_ForeColor(SystemColors.ButtonFace);
		((Control)btnSpin).set_Location(new Point(302, 467));
		((Control)btnSpin).set_Name("btnSpin");
		((Control)btnSpin).set_Size(new Size(133, 31));
		((Control)btnSpin).set_TabIndex(25);
		((ButtonBase)btnSpin).set_Text("Spin Chamber");
		((ButtonBase)btnSpin).set_UseVisualStyleBackColor(false);
		((Control)PictureBox1).set_BackColor(Color.Transparent);
		PictureBox1.set_Image((Image)componentResourceManager.GetObject("PictureBox1.Image"));
		((Control)PictureBox1).set_Location(new Point(647, 150));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(70, 87));
		PictureBox1.set_SizeMode((PictureBoxSizeMode)4);
		PictureBox1.set_TabIndex(22);
		PictureBox1.set_TabStop(false);
		((Control)PictureBox1).set_Visible(false);
		((Control)pbIndicator1).set_BackColor(Color.Transparent);
		pbIndicator1.set_Image((Image)componentResourceManager.GetObject("pbIndicator1.Image"));
		((Control)pbIndicator1).set_Location(new Point(217, 150));
		((Control)pbIndicator1).set_Name("pbIndicator1");
		((Control)pbIndicator1).set_Size(new Size(70, 87));
		pbIndicator1.set_SizeMode((PictureBoxSizeMode)4);
		pbIndicator1.set_TabIndex(21);
		pbIndicator1.set_TabStop(false);
		((Control)pbIndicator1).set_Visible(false);
		((Control)pbJoker).set_BackColor(Color.Transparent);
		pbJoker.set_Image((Image)componentResourceManager.GetObject("pbJoker.Image"));
		((Control)pbJoker).set_Location(new Point(186, 242));
		((Control)pbJoker).set_Name("pbJoker");
		((Control)pbJoker).set_Size(new Size(144, 187));
		pbJoker.set_SizeMode((PictureBoxSizeMode)4);
		pbJoker.set_TabIndex(16);
		pbJoker.set_TabStop(false);
		((Control)pbSecondPlayer).set_BackColor(Color.Transparent);
		((Control)pbSecondPlayer).set_Location(new Point(611, 242));
		((Control)pbSecondPlayer).set_Name("pbSecondPlayer");
		((Control)pbSecondPlayer).set_Size(new Size(144, 187));
		pbSecondPlayer.set_SizeMode((PictureBoxSizeMode)4);
		pbSecondPlayer.set_TabIndex(30);
		pbSecondPlayer.set_TabStop(false);
		((ButtonBase)btnPlayer1).set_BackColor(Color.Orange);
		((Control)btnPlayer1).set_BackgroundImageLayout((ImageLayout)0);
		((Control)btnPlayer1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)btnPlayer1).set_ForeColor(SystemColors.ControlLight);
		((Control)btnPlayer1).set_Location(new Point(7, 23));
		((Control)btnPlayer1).set_Name("btnPlayer1");
		((Control)btnPlayer1).set_Size(new Size(290, 406));
		((Control)btnPlayer1).set_TabIndex(31);
		((ButtonBase)btnPlayer1).set_Text("Player 1 Starts");
		((ButtonBase)btnPlayer1).set_TextAlign((ContentAlignment)512);
		((ButtonBase)btnPlayer1).set_UseVisualStyleBackColor(false);
		((ButtonBase)btnPlayer2).set_BackColor(Color.Orange);
		((Control)btnPlayer2).set_BackgroundImageLayout((ImageLayout)4);
		((Control)btnPlayer2).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)btnPlayer2).set_ForeColor(SystemColors.ControlLight);
		((Control)btnPlayer2).set_Location(new Point(578, 23));
		((Control)btnPlayer2).set_Name("btnPlayer2");
		((Control)btnPlayer2).set_Size(new Size(279, 406));
		((Control)btnPlayer2).set_TabIndex(32);
		((ButtonBase)btnPlayer2).set_Text("Player 2 Starts");
		((ButtonBase)btnPlayer2).set_TextAlign((ContentAlignment)512);
		((ButtonBase)btnPlayer2).set_UseVisualStyleBackColor(false);
		((ButtonBase)btnRandom).set_BackColor(Color.Orange);
		((Control)btnRandom).set_BackgroundImageLayout((ImageLayout)4);
		((Control)btnRandom).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)btnRandom).set_ForeColor(SystemColors.ControlLight);
		((Control)btnRandom).set_Location(new Point(293, 23));
		((Control)btnRandom).set_Name("btnRandom");
		((Control)btnRandom).set_Size(new Size(291, 406));
		((Control)btnRandom).set_TabIndex(33);
		((ButtonBase)btnRandom).set_Text("Random");
		((ButtonBase)btnRandom).set_TextAlign((ContentAlignment)512);
		((ButtonBase)btnRandom).set_UseVisualStyleBackColor(false);
		lblWhosTurn.set_AutoSize(true);
		((Control)lblWhosTurn).set_BackColor(Color.Transparent);
		((Control)lblWhosTurn).set_ForeColor(SystemColors.ControlLight);
		((Control)lblWhosTurn).set_Location(new Point(608, 476));
		((Control)lblWhosTurn).set_Name("lblWhosTurn");
		((Control)lblWhosTurn).set_Size(new Size(93, 13));
		((Control)lblWhosTurn).set_TabIndex(34);
		lblWhosTurn.set_Text("Select Who Starts");
		((Control)pbCheat).set_BackColor(Color.Transparent);
		((Control)pbCheat).set_Location(new Point(59, 225));
		((Control)pbCheat).set_Name("pbCheat");
		((Control)pbCheat).set_Size(new Size(100, 101));
		pbCheat.set_TabIndex(35);
		pbCheat.set_TabStop(false);
		lblAnswer.set_AutoSize(true);
		((Control)lblAnswer).set_BackColor(Color.Transparent);
		((Control)lblAnswer).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblAnswer).set_ForeColor(SystemColors.ControlLightLight);
		((Control)lblAnswer).set_Location(new Point(800, 469));
		((Control)lblAnswer).set_Name("lblAnswer");
		((Control)lblAnswer).set_Size(new Size(62, 20));
		((Control)lblAnswer).set_TabIndex(36);
		lblAnswer.set_Text("Answer");
		((Control)lblAnswer).set_Visible(false);
		lblSubHeader.set_AutoSize(true);
		((Control)lblSubHeader).set_BackColor(Color.Transparent);
		((Control)lblSubHeader).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblSubHeader).set_Location(new Point(21, 77));
		((Control)lblSubHeader).set_Name("lblSubHeader");
		((Control)lblSubHeader).set_Size(new Size(696, 17));
		((Control)lblSubHeader).set_TabIndex(37);
		lblSubHeader.set_Text("Be careful not to miss when shooting the opponent or else you have to wait until they miss to regain your shot");
		Label1.set_AutoSize(true);
		((Control)Label1).set_BackColor(Color.Transparent);
		((Control)Label1).set_Font(new Font("Comic Sans MS", 39f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_Location(new Point(12, 5));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(715, 72));
		((Control)Label1).set_TabIndex(38);
		Label1.set_Text("Click a Character to Shoot");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(869, 501));
		((Control)this).get_Controls().Add((Control)(object)btnPlayer2);
		((Control)this).get_Controls().Add((Control)(object)btnRandom);
		((Control)this).get_Controls().Add((Control)(object)btnPlayer1);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)lblSubHeader);
		((Control)this).get_Controls().Add((Control)(object)lblAnswer);
		((Control)this).get_Controls().Add((Control)(object)pbCheat);
		((Control)this).get_Controls().Add((Control)(object)lblWhosTurn);
		((Control)this).get_Controls().Add((Control)(object)pbSecondPlayer);
		((Control)this).get_Controls().Add((Control)(object)btnMusic);
		((Control)this).get_Controls().Add((Control)(object)cbSongSelection);
		((Control)this).get_Controls().Add((Control)(object)btnQuit);
		((Control)this).get_Controls().Add((Control)(object)pbCylinder);
		((Control)this).get_Controls().Add((Control)(object)btnSpin);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)(object)pbIndicator1);
		((Control)this).get_Controls().Add((Control)(object)pbJoker);
		((Control)this).set_Name("MultiPlayer");
		((Form)this).set_Text("MultiPlayer");
		((ISupportInitialize)pbCylinder).EndInit();
		((ISupportInitialize)PictureBox1).EndInit();
		((ISupportInitialize)pbIndicator1).EndInit();
		((ISupportInitialize)pbJoker).EndInit();
		((ISupportInitialize)pbSecondPlayer).EndInit();
		((ISupportInitialize)pbCheat).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void btnMusic_Click(object sender, EventArgs e)
	{
		if (bool_0)
		{
			if (Operators.CompareString(cbSongSelection.get_Text(), "SouthPark Intro", false) != 0)
			{
			}
		}
		else
		{
			((Computer)Class2.Computer).get_Audio().Stop();
			bool_0 = true;
		}
	}

	private void btnQuit_Click(object sender, EventArgs e)
	{
		((Control)Class2.Forms.QuitForm).Show();
	}

	private void pbJoker_Click(object sender, EventArgs e)
	{
		if (gclass2_0.bool_1)
		{
			gclass2_0.ShootMyselfPlayer1();
			return;
		}
		tMovement.Start();
		tAnimation.Start();
	}

	private void pbSecondPlayer_Click(object sender, EventArgs e)
	{
		if (!gclass2_0.bool_1)
		{
			gclass2_0.ShootMyselfPlayer2();
			return;
		}
		tMovement.Start();
		tAnimation.Start();
	}

	private void tMovement_Tick(object sender, EventArgs e)
	{
		if (gclass2_0.bool_1)
		{
			gclass2_0.pictureBox_0 = pbJoker;
			if (!gclass2_0.bool_0)
			{
				gclass2_0.MovementForwardPlayer1();
			}
			if (gclass2_0.bool_0)
			{
				gclass2_0.MovementBackwardsPlayer1();
			}
		}
		else
		{
			gclass2_0.pictureBox_0 = pbSecondPlayer;
			if (!gclass2_0.bool_0)
			{
				gclass2_0.MovementForwardPlayer2();
			}
			if (gclass2_0.bool_0)
			{
				gclass2_0.MovementBackwardsPlayer2();
			}
		}
	}

	private void JokerFaceTransition_Tick(object sender, EventArgs e)
	{
		if (gclass2_0.bool_1)
		{
			gclass2_0.BulletMiss_MySelfPlayer1();
		}
		else
		{
			gclass2_0.BulletMiss_MySelfPlayer2();
		}
	}

	private void tAnimation_Tick(object sender, EventArgs e)
	{
		if (gclass2_0.bool_1)
		{
			gclass2_0.pictureBox_0 = pbJoker;
			gclass2_0.Animation();
		}
		else
		{
			gclass2_0.pictureBox_0 = pbSecondPlayer;
			gclass2_0.Animation2();
		}
	}

	private void pbJoker_MouseHover(object sender, EventArgs e)
	{
		((Control)pbIndicator1).set_Visible(true);
	}

	private void pbJoker_MouseLeave(object sender, EventArgs e)
	{
		((Control)pbIndicator1).set_Visible(false);
	}

	private void pbSecondPlayer_MouseHover(object sender, EventArgs e)
	{
		((Control)PictureBox1).set_Visible(true);
	}

	private void pbSecondPlayer_MouseLeave(object sender, EventArgs e)
	{
		((Control)PictureBox1).set_Visible(false);
	}

	private void btnPlayer1_Click(object sender, EventArgs e)
	{
		gclass2_0.bool_1 = true;
		((Control)btnPlayer1).set_Visible(false);
		((Control)btnPlayer2).set_Visible(false);
		((Control)btnRandom).set_Visible(false);
		if (gclass2_0.bool_1)
		{
			lblWhosTurn.set_Text("Player 1's Turn");
		}
	}

	private void btnPlayer2_Click(object sender, EventArgs e)
	{
		gclass2_0.bool_1 = false;
		((Control)btnPlayer1).set_Visible(false);
		((Control)btnPlayer2).set_Visible(false);
		((Control)btnRandom).set_Visible(false);
		if (!gclass2_0.bool_1)
		{
			lblWhosTurn.set_Text("Player 2's Turn");
		}
	}

	private void btnRandom_Click(object sender, EventArgs e)
	{
		if (gclass2_0.int_8 == 1)
		{
			gclass2_0.bool_1 = true;
		}
		else
		{
			gclass2_0.bool_1 = false;
		}
		((Control)btnPlayer1).set_Visible(false);
		((Control)btnPlayer2).set_Visible(false);
		((Control)btnRandom).set_Visible(false);
		lblWhosTurn.set_Text("Player" + Conversions.ToString(gclass2_0.int_8) + "'s Turn");
	}

	private void pbCheat_Click(object sender, EventArgs e)
	{
		((Control)lblAnswer).set_Visible(true);
		lblAnswer.set_Text(Conversions.ToString(gclass2_0.int_4));
	}

	private void MultiPlayer_Load(object sender, EventArgs e)
	{
		cbSongSelection.set_Text("SouthPark Intro");
		bool_0 = false;
	}

	private void btnSpin_Click(object sender, EventArgs e)
	{
		gclass2_0.BulletRandomLocation();
		gclass2_0.int_5 = 1;
		lblAnswer.set_Text(Conversions.ToString(gclass2_0.int_4));
		((Control)pbCylinder).Refresh();
	}
}
