using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using ns10;
using ns3;

namespace ns9;

[DesignerGenerated]
public class Form1 : Form
{
	public GClass1 gclass1_0;

	private bool bool_0;

	private IContainer icontainer_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("tMovement")]
	private Timer timer_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("tAnimation")]
	private Timer timer_1;

	[CompilerGenerated]
	[AccessedThroughProperty("Blinking")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Timer timer_2;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("LaserEye")]
	[CompilerGenerated]
	private Timer timer_3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("JokerFaceTransition")]
	private Timer timer_4;

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

	internal virtual PictureBox pbMysterion
	{
		[CompilerGenerated]
		get
		{
			return _pbMysterion;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = pbMysterion_Click;
			EventHandler eventHandler2 = pbMysterion_MouseHover;
			EventHandler eventHandler3 = pbMysterion_MouseLeave;
			PictureBox val = _pbMysterion;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
				((Control)val).remove_MouseHover(eventHandler2);
				((Control)val).remove_MouseLeave(eventHandler3);
			}
			_pbMysterion = value;
			val = _pbMysterion;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
				((Control)val).add_MouseHover(eventHandler2);
				((Control)val).add_MouseLeave(eventHandler3);
			}
		}
	}

	internal virtual Timer Blinking
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
			EventHandler eventHandler = Blinking_Tick;
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

	[field: AccessedThroughProperty("lblTitle")]
	internal virtual Label lblTitle
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
			EventHandler eventHandler = PictureBox3_Click;
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

	[field: AccessedThroughProperty("pbIndicator1")]
	internal virtual PictureBox pbIndicator1
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

	[field: AccessedThroughProperty("pbLaser")]
	internal virtual PictureBox pbLaser
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblChances")]
	internal virtual Label lblChances
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Timer LaserEye
	{
		[CompilerGenerated]
		get
		{
			return timer_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = LaserEye_Tick;
			Timer val = timer_3;
			if (val != null)
			{
				val.remove_Tick(eventHandler);
			}
			timer_3 = value;
			val = timer_3;
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
			return timer_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = JokerFaceTransition_Tick;
			Timer val = timer_4;
			if (val != null)
			{
				val.remove_Tick(eventHandler);
			}
			timer_4 = value;
			val = timer_4;
			if (val != null)
			{
				val.add_Tick(eventHandler);
			}
		}
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

	[field: AccessedThroughProperty("pbCylinder")]
	internal virtual PictureBox pbCylinder
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

	[field: AccessedThroughProperty("cbSongSelection")]
	internal virtual ComboBox cbSongSelection
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

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

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		gclass1_0 = new GClass1();
		bool_0 = true;
		InitializeComponent();
	}

	private void tMovement_Tick(object sender, EventArgs e)
	{
		gclass1_0.pictureBox_0 = pbJoker;
		if (!gclass1_0.bool_0)
		{
			gclass1_0.MovementForward();
		}
		if (gclass1_0.bool_0)
		{
			gclass1_0.MovementBackwards();
		}
	}

	private void tAnimation_Tick(object sender, EventArgs e)
	{
		gclass1_0.pictureBox_0 = pbJoker;
		gclass1_0.Animation();
	}

	private void Blinking_Tick(object sender, EventArgs e)
	{
		gclass1_0.Blink();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		Blinking.Start();
		cbSongSelection.set_Text("SouthPark Intro");
		bool_0 = false;
	}

	private void pbMysterion_Click(object sender, EventArgs e)
	{
		tMovement.Start();
		tAnimation.Start();
	}

	private void PictureBox3_Click(object sender, EventArgs e)
	{
		((Control)lblAnswer).set_Visible(true);
		lblAnswer.set_Text(Conversions.ToString(gclass1_0.int_4));
	}

	private void pbJoker_Click(object sender, EventArgs e)
	{
		gclass1_0.ShootMyself();
	}

	private void pbJoker_MouseHover(object sender, EventArgs e)
	{
		((Control)pbIndicator1).set_Visible(true);
	}

	private void pbJoker_MouseLeave(object sender, EventArgs e)
	{
		((Control)pbIndicator1).set_Visible(false);
	}

	private void pbMysterion_MouseHover(object sender, EventArgs e)
	{
		((Control)PictureBox1).set_Visible(true);
	}

	private void pbMysterion_MouseLeave(object sender, EventArgs e)
	{
		((Control)PictureBox1).set_Visible(false);
	}

	private void LaserEye_Tick(object sender, EventArgs e)
	{
		gclass1_0.LaserHit();
	}

	private void JokerFaceTransition_Tick(object sender, EventArgs e)
	{
		gclass1_0.BulletMiss_MySelf();
	}

	private void btnSpin_Click(object sender, EventArgs e)
	{
		gclass1_0.BulletRandomLocation();
		gclass1_0.int_5 = 1;
		gclass1_0.int_6 = 2;
		lblChances.set_Text("Chances: 2");
		lblAnswer.set_Text(Conversions.ToString(gclass1_0.int_4));
		gclass1_0.CylinderImage();
	}

	private void btnQuit_Click(object sender, EventArgs e)
	{
		((Control)Class2.Forms.QuitForm).Show();
	}

	private void btnMusic_Click(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			((Computer)Class2.Computer).get_Audio().Stop();
			bool_0 = true;
		}
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
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected O, but got Unknown
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected O, but got Unknown
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected O, but got Unknown
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Expected O, but got Unknown
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0465: Expected O, but got Unknown
		//IL_04f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fe: Expected O, but got Unknown
		//IL_0619: Unknown result type (might be due to invalid IL or missing references)
		//IL_0623: Expected O, but got Unknown
		//IL_06be: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c8: Expected O, but got Unknown
		//IL_0763: Unknown result type (might be due to invalid IL or missing references)
		//IL_076d: Expected O, but got Unknown
		//IL_07f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0800: Expected O, but got Unknown
		//IL_099e: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a8: Expected O, but got Unknown
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		tMovement = new Timer(icontainer_0);
		tAnimation = new Timer(icontainer_0);
		Blinking = new Timer(icontainer_0);
		pbMysterion = new PictureBox();
		pbJoker = new PictureBox();
		lblTitle = new Label();
		pbCheat = new PictureBox();
		lblAnswer = new Label();
		pbIndicator1 = new PictureBox();
		PictureBox1 = new PictureBox();
		pbLaser = new PictureBox();
		lblChances = new Label();
		LaserEye = new Timer(icontainer_0);
		JokerFaceTransition = new Timer(icontainer_0);
		btnSpin = new Button();
		pbCylinder = new PictureBox();
		btnQuit = new Button();
		cbSongSelection = new ComboBox();
		btnMusic = new Button();
		((ISupportInitialize)pbMysterion).BeginInit();
		((ISupportInitialize)pbJoker).BeginInit();
		((ISupportInitialize)pbCheat).BeginInit();
		((ISupportInitialize)pbIndicator1).BeginInit();
		((ISupportInitialize)PictureBox1).BeginInit();
		((ISupportInitialize)pbLaser).BeginInit();
		((ISupportInitialize)pbCylinder).BeginInit();
		((Control)this).SuspendLayout();
		tMovement.set_Interval(80);
		tAnimation.set_Interval(1);
		Blinking.set_Interval(488);
		((Control)pbMysterion).set_BackColor(Color.Transparent);
		pbMysterion.set_Image((Image)componentResourceManager.GetObject("pbMysterion.Image"));
		((Control)pbMysterion).set_Location(new Point(615, 256));
		((Control)pbMysterion).set_Name("pbMysterion");
		((Control)pbMysterion).set_Size(new Size(137, 187));
		pbMysterion.set_SizeMode((PictureBoxSizeMode)4);
		pbMysterion.set_TabIndex(2);
		pbMysterion.set_TabStop(false);
		((Control)pbJoker).set_BackColor(Color.Transparent);
		pbJoker.set_Image((Image)componentResourceManager.GetObject("pbJoker.Image"));
		((Control)pbJoker).set_Location(new Point(191, 256));
		((Control)pbJoker).set_Name("pbJoker");
		((Control)pbJoker).set_Size(new Size(144, 187));
		pbJoker.set_SizeMode((PictureBoxSizeMode)4);
		pbJoker.set_TabIndex(1);
		pbJoker.set_TabStop(false);
		lblTitle.set_AutoSize(true);
		((Control)lblTitle).set_BackColor(Color.Transparent);
		((Control)lblTitle).set_Font(new Font("Comic Sans MS", 40f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblTitle).set_Location(new Point(72, 9));
		((Control)lblTitle).set_Name("lblTitle");
		((Control)lblTitle).set_Size(new Size(0, 74));
		((Control)lblTitle).set_TabIndex(3);
		((Control)pbCheat).set_BackColor(Color.Transparent);
		((Control)pbCheat).set_Location(new Point(57, 228));
		((Control)pbCheat).set_Name("pbCheat");
		((Control)pbCheat).set_Size(new Size(100, 101));
		pbCheat.set_TabIndex(4);
		pbCheat.set_TabStop(false);
		lblAnswer.set_AutoSize(true);
		((Control)lblAnswer).set_BackColor(Color.Transparent);
		((Control)lblAnswer).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblAnswer).set_ForeColor(SystemColors.ControlLightLight);
		((Control)lblAnswer).set_Location(new Point(611, 470));
		((Control)lblAnswer).set_Name("lblAnswer");
		((Control)lblAnswer).set_Size(new Size(62, 20));
		((Control)lblAnswer).set_TabIndex(5);
		lblAnswer.set_Text("Answer");
		((Control)lblAnswer).set_Visible(false);
		((Control)pbIndicator1).set_BackColor(Color.Transparent);
		pbIndicator1.set_Image((Image)componentResourceManager.GetObject("pbIndicator1.Image"));
		((Control)pbIndicator1).set_Location(new Point(222, 163));
		((Control)pbIndicator1).set_Name("pbIndicator1");
		((Control)pbIndicator1).set_Size(new Size(70, 87));
		pbIndicator1.set_SizeMode((PictureBoxSizeMode)4);
		pbIndicator1.set_TabIndex(6);
		pbIndicator1.set_TabStop(false);
		((Control)pbIndicator1).set_Visible(false);
		((Control)PictureBox1).set_BackColor(Color.Transparent);
		PictureBox1.set_Image((Image)componentResourceManager.GetObject("PictureBox1.Image"));
		((Control)PictureBox1).set_Location(new Point(652, 163));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(70, 87));
		PictureBox1.set_SizeMode((PictureBoxSizeMode)4);
		PictureBox1.set_TabIndex(7);
		PictureBox1.set_TabStop(false);
		((Control)PictureBox1).set_Visible(false);
		((Control)pbLaser).set_BackColor(Color.Transparent);
		((Control)pbLaser).set_Location(new Point(615, 342));
		((Control)pbLaser).set_Name("pbLaser");
		((Control)pbLaser).set_Size(new Size(61, 16));
		pbLaser.set_SizeMode((PictureBoxSizeMode)4);
		pbLaser.set_TabIndex(8);
		pbLaser.set_TabStop(false);
		((Control)pbLaser).set_Visible(false);
		lblChances.set_AutoSize(true);
		((Control)lblChances).set_BackColor(Color.Transparent);
		((Control)lblChances).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblChances).set_ForeColor(SystemColors.ControlLightLight);
		((Control)lblChances).set_Location(new Point(757, 470));
		((Control)lblChances).set_Name("lblChances");
		((Control)lblChances).set_Size(new Size(89, 20));
		((Control)lblChances).set_TabIndex(9);
		lblChances.set_Text("Chances: 2");
		LaserEye.set_Interval(50);
		((ButtonBase)btnSpin).set_BackColor(SystemColors.ControlDarkDark);
		((Control)btnSpin).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)btnSpin).set_ForeColor(SystemColors.ButtonFace);
		((Control)btnSpin).set_Location(new Point(307, 465));
		((Control)btnSpin).set_Name("btnSpin");
		((Control)btnSpin).set_Size(new Size(133, 31));
		((Control)btnSpin).set_TabIndex(10);
		((ButtonBase)btnSpin).set_Text("Spin Chamber");
		((ButtonBase)btnSpin).set_UseVisualStyleBackColor(false);
		((Control)pbCylinder).set_BackColor(Color.Transparent);
		pbCylinder.set_Image((Image)componentResourceManager.GetObject("pbCylinder.Image"));
		((Control)pbCylinder).set_Location(new Point(737, 139));
		((Control)pbCylinder).set_Name("pbCylinder");
		((Control)pbCylinder).set_Size(new Size(129, 111));
		pbCylinder.set_SizeMode((PictureBoxSizeMode)4);
		pbCylinder.set_TabIndex(11);
		pbCylinder.set_TabStop(false);
		((ButtonBase)btnQuit).set_BackColor(SystemColors.ControlDarkDark);
		((Control)btnQuit).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)btnQuit).set_ForeColor(SystemColors.ButtonFace);
		((Control)btnQuit).set_Location(new Point(459, 465));
		((Control)btnQuit).set_Name("btnQuit");
		((Control)btnQuit).set_Size(new Size(133, 31));
		((Control)btnQuit).set_TabIndex(12);
		((ButtonBase)btnQuit).set_Text("Quit");
		((ButtonBase)btnQuit).set_UseVisualStyleBackColor(false);
		((ListControl)cbSongSelection).set_FormattingEnabled(true);
		cbSongSelection.get_Items().AddRange(new object[2] { "SouthPark Intro", "What_Would_Brian_Boitano_Do" });
		((Control)cbSongSelection).set_Location(new Point(12, 469));
		((Control)cbSongSelection).set_Name("cbSongSelection");
		((Control)cbSongSelection).set_Size(new Size(142, 21));
		((Control)cbSongSelection).set_TabIndex(14);
		((Control)cbSongSelection).set_Visible(false);
		((Control)btnMusic).set_Location(new Point(170, 469));
		((Control)btnMusic).set_Name("btnMusic");
		((Control)btnMusic).set_Size(new Size(75, 23));
		((Control)btnMusic).set_TabIndex(15);
		((ButtonBase)btnMusic).set_Text("Play / Stop");
		((ButtonBase)btnMusic).set_UseVisualStyleBackColor(true);
		((Control)btnMusic).set_Visible(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Form)this).set_ClientSize(new Size(869, 501));
		((Control)this).get_Controls().Add((Control)(object)btnMusic);
		((Control)this).get_Controls().Add((Control)(object)cbSongSelection);
		((Control)this).get_Controls().Add((Control)(object)btnQuit);
		((Control)this).get_Controls().Add((Control)(object)pbCylinder);
		((Control)this).get_Controls().Add((Control)(object)btnSpin);
		((Control)this).get_Controls().Add((Control)(object)lblChances);
		((Control)this).get_Controls().Add((Control)(object)pbLaser);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)(object)pbIndicator1);
		((Control)this).get_Controls().Add((Control)(object)lblAnswer);
		((Control)this).get_Controls().Add((Control)(object)pbCheat);
		((Control)this).get_Controls().Add((Control)(object)lblTitle);
		((Control)this).get_Controls().Add((Control)(object)pbMysterion);
		((Control)this).get_Controls().Add((Control)(object)pbJoker);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Form1");
		((ISupportInitialize)pbMysterion).EndInit();
		((ISupportInitialize)pbJoker).EndInit();
		((ISupportInitialize)pbCheat).EndInit();
		((ISupportInitialize)pbIndicator1).EndInit();
		((ISupportInitialize)PictureBox1).EndInit();
		((ISupportInitialize)pbLaser).EndInit();
		((ISupportInitialize)pbCylinder).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
