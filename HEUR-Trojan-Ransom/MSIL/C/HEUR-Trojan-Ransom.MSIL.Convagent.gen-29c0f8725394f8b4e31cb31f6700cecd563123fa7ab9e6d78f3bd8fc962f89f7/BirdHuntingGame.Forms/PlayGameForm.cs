using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using BirdHuntingGame.Code;

namespace BirdHuntingGame.Forms;

public class PlayGameForm : Form
{
	private GameStatus GameStatus;

	private Guns SelectedGun;

	private Birds SelectedBird;

	private List<BirdTimer> FlyingBirds = new List<BirdTimer>();

	private const int MM_MCINOTIFY = 953;

	private const int MCI_NOTIFY_SUCCESS = 1;

	private IContainer components = null;

	private Button btnClose;

	private Button btnPause;

	private Button btnBack;

	private PictureBox pictureBox1;

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((Form)this).get_CreateParams();
			createParams.set_ExStyle(createParams.get_ExStyle() | 0x2000000);
			return createParams;
		}
	}

	public PlayGameForm(Guns gun, Birds bird)
	{
		InitializeComponent();
		GameStatus = GameStatus.Continue;
		SelectedGun = gun;
		SelectedBird = bird;
		SetupCrossHair();
		((Control)this).SetStyle((ControlStyles)8192, true);
	}

	private void SetupCrossHair()
	{
		if (SelectedGun != Guns.Shotgun && SelectedGun != Guns.M1Grand && SelectedGun == Guns.Glock)
		{
		}
	}

	[DllImport("winmm.dll")]
	private static extern int mciSendString(string command, StringBuilder buffer, int bufferSize, IntPtr hwndCallback);

	protected override void WndProc(ref Message m)
	{
		if (((Message)(ref m)).get_Msg() == 953)
		{
			int num = ((Message)(ref m)).get_WParam().ToInt32();
			int num2 = num;
			if (num2 == 1)
			{
				mciSendString("close forest-and-birds", null, 0, ((Control)this).get_Handle());
				mciSendString("stop forest-and-birds", null, 0, ((Control)this).get_Handle());
				PlayForestBirdsSound();
			}
		}
		((Form)this).WndProc(ref m);
	}

	public void KnowSounds()
	{
		mciSendString("open Sounds/forest-and-birds.wav type waveaudio alias forest-and-birds", null, 0, IntPtr.Zero);
		mciSendString("open Sounds/Glock-Gun-Fire.wav type waveaudio alias Glock-Gun-Fire", null, 0, IntPtr.Zero);
		mciSendString("open Sounds/Shotgun-Fire.wav type waveaudio alias Shotgun-Fire", null, 0, IntPtr.Zero);
		mciSendString("open Sounds/M1Garand-Fire.wav type waveaudio alias M1Garand-Fire", null, 0, IntPtr.Zero);
	}

	public void PlayGunSound()
	{
		new Thread((ThreadStart)delegate
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			if (SelectedGun == Guns.Shotgun)
			{
				FileStream fileStream = new FileStream("Sounds/Shotgun-Fire.wav", FileMode.Open, FileAccess.Read);
				new SoundPlayer((Stream)fileStream).Play();
			}
			else if (SelectedGun == Guns.M1Grand)
			{
				FileStream fileStream2 = new FileStream("Sounds/M1Garand-Fire.wav", FileMode.Open, FileAccess.Read);
				new SoundPlayer((Stream)fileStream2).Play();
			}
			else if (SelectedGun == Guns.Glock)
			{
				FileStream fileStream3 = new FileStream("Sounds/Glock-Gun-Fire.wav", FileMode.Open, FileAccess.Read);
				new SoundPlayer((Stream)fileStream3).Play();
			}
		}).Start();
	}

	public void PlayBirdHitSound()
	{
		new Thread((ThreadStart)delegate
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			FileStream fileStream = new FileStream("Sounds/bird-hit.wav", FileMode.Open, FileAccess.Read);
			new SoundPlayer((Stream)fileStream).Play();
		}).Start();
	}

	public void PlayForestBirdsSound()
	{
		mciSendString("play forest-and-birds notify", null, 0, IntPtr.Zero);
	}

	private void PlayGameForm_Load(object sender, EventArgs e)
	{
		AddNewBird("", "");
		AddNewBird("", "");
		AddNewBird("", "");
		KnowSounds();
		PlayForestBirdsSound();
	}

	public void AddNewBird(string Direction, string Bird)
	{
		BirdTimer birdTimer = new BirdTimer();
		birdTimer.BirdBox = NewBirdBox(Direction, Bird);
		((Timer)birdTimer).set_Interval(Extensions.GetRandomInterval());
		((Timer)birdTimer).add_Tick((EventHandler)BirdTimer_Tick);
		((Control)this).get_Controls().Add((Control)(object)birdTimer.BirdBox);
		FlyingBirds.Add(birdTimer);
		((Timer)birdTimer).Start();
	}

	private void BirdTimer_Tick(object sender, EventArgs e)
	{
		BirdTimer birdTimer = (BirdTimer)sender;
		if (birdTimer == null)
		{
			return;
		}
		int num = 0;
		int num2 = 0;
		if (birdTimer.BirdBox.Status == "Alive")
		{
			if (((Control)birdTimer.BirdBox).get_Location().X + ((Control)birdTimer.BirdBox).get_Size().Width < 0)
			{
				num = ((Control)birdTimer.BirdBox).get_Location().X - Extensions.GetRandomNumber();
				birdTimer.BirdBox.Status = "Downed";
			}
			else
			{
				num = ((Control)birdTimer.BirdBox).get_Location().X - Extensions.GetRandomNumber();
			}
			if (((Control)birdTimer.BirdBox).get_Location().Y + ((Control)birdTimer.BirdBox).get_Size().Height > ((Control)this).get_Height() - 50)
			{
				birdTimer.BirdBox.Status = "Downed";
				return;
			}
			if (((Control)birdTimer.BirdBox).get_Location().Y + ((Control)birdTimer.BirdBox).get_Size().Height - 50 < 0)
			{
				birdTimer.BirdBox.Status = "Downed";
				return;
			}
			num2 = ((Control)birdTimer.BirdBox).get_Location().Y + Extensions.GetLimitedRandomNumber(-8, 8);
			((Control)birdTimer.BirdBox).set_Location(new Point(num, num2));
		}
		else if (birdTimer.BirdBox.Status == "Dead")
		{
			if (((Control)birdTimer.BirdBox).get_Location().X + ((Control)birdTimer.BirdBox).get_Size().Width < 0)
			{
				birdTimer.BirdBox.Status = "Downed";
				return;
			}
			num = ((Control)birdTimer.BirdBox).get_Location().X - Extensions.GetLimitedRandomNumber(5, 10);
			if (((Control)birdTimer.BirdBox).get_Location().Y + ((Control)birdTimer.BirdBox).get_Size().Height > ((Control)this).get_Height())
			{
				birdTimer.BirdBox.Status = "Downed";
				return;
			}
			num2 = ((Control)birdTimer.BirdBox).get_Location().Y + Extensions.GetLimitedRandomNumber(10, 15);
			((Control)birdTimer.BirdBox).set_Location(new Point(num, num2));
		}
		else if (birdTimer.BirdBox.Status == "Downed")
		{
			RemoveBird(birdTimer);
			AddNewBird("", "");
		}
	}

	public BirdBox NewBirdBox(string Direction, string Bird)
	{
		BirdBox birdBox = new BirdBox();
		int limitedRandomNumber = Extensions.GetLimitedRandomNumber(50, 120);
		((Control)birdBox).set_Size(new Size(limitedRandomNumber, limitedRandomNumber));
		((PictureBox)birdBox).set_SizeMode((PictureBoxSizeMode)1);
		birdBox.Direction = Direction;
		if (SelectedBird == Birds.Parrot || SelectedBird == Birds.Stork || SelectedBird != Birds.Crow)
		{
		}
		((Control)birdBox).set_BackColor(Color.Transparent);
		((Control)birdBox).set_Location(new Point(((Control)this).get_Width(), Extensions.GetLimitedRandomNumber(200, ((Control)this).get_Height() - 200)));
		((Control)birdBox).add_Click((EventHandler)birdBox_Click);
		((Control)birdBox).add_DoubleClick((EventHandler)birdBox_Click);
		return birdBox;
	}

	private void birdBox_Click(object sender, EventArgs e)
	{
		if (GameStatus == GameStatus.Continue)
		{
			BirdBox birdBox = (BirdBox)sender;
			if (birdBox != null && birdBox.Status != "Dead")
			{
				PlayBirdHitSound();
				birdBox.Status = "Dead";
				((PictureBox)birdBox).get_Image().RotateFlip((RotateFlipType)3);
			}
			else
			{
				PlayGunSound();
			}
		}
	}

	private void PlayGameForm_Click(object sender, EventArgs e)
	{
		if (GameStatus == GameStatus.Continue)
		{
			PlayGunSound();
		}
	}

	private void RemoveBird(BirdTimer BirdTimer)
	{
		if (BirdTimer != null)
		{
			FlyingBirds.Remove(BirdTimer);
			((Timer)BirdTimer).Stop();
			((Component)(object)BirdTimer.BirdBox).Dispose();
			((Component)(object)BirdTimer).Dispose();
		}
	}

	private void btnClose_Click(object sender, EventArgs e)
	{
		Application.Exit();
	}

	private void btnPause_Click(object sender, EventArgs e)
	{
		if (GameStatus == GameStatus.Continue)
		{
			GameStatus = GameStatus.Pause;
			{
				foreach (BirdTimer flyingBird in FlyingBirds)
				{
					if (flyingBird != null)
					{
						((Timer)flyingBird).Stop();
					}
				}
				return;
			}
		}
		GameStatus = GameStatus.Continue;
		foreach (BirdTimer flyingBird2 in FlyingBirds)
		{
			if (flyingBird2 != null)
			{
				((Timer)flyingBird2).Start();
			}
		}
	}

	private void btnBack_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
		((Control)GameOptionsForm.Instance).Show();
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
		btnClose = new Button();
		btnPause = new Button();
		btnBack = new Button();
		pictureBox1 = new PictureBox();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)btnClose).set_Anchor((AnchorStyles)9);
		((Control)btnClose).set_BackColor(Color.Transparent);
		((Control)btnClose).set_BackgroundImageLayout((ImageLayout)3);
		((Control)btnClose).set_Cursor(Cursors.get_Hand());
		((ButtonBase)btnClose).get_FlatAppearance().set_MouseDownBackColor(Color.Transparent);
		((ButtonBase)btnClose).get_FlatAppearance().set_MouseOverBackColor(Color.Transparent);
		((ButtonBase)btnClose).set_FlatStyle((FlatStyle)0);
		((Control)btnClose).set_Location(new Point(498, 12));
		((Control)btnClose).set_Name("btnClose");
		((Control)btnClose).set_Size(new Size(50, 50));
		((Control)btnClose).set_TabIndex(14);
		((ButtonBase)btnClose).set_UseVisualStyleBackColor(false);
		((Control)btnClose).add_Click((EventHandler)btnClose_Click);
		((Control)btnPause).set_Anchor((AnchorStyles)9);
		((Control)btnPause).set_BackColor(Color.Transparent);
		((Control)btnPause).set_BackgroundImageLayout((ImageLayout)3);
		((Control)btnPause).set_Cursor(Cursors.get_Hand());
		((ButtonBase)btnPause).get_FlatAppearance().set_MouseDownBackColor(Color.Transparent);
		((ButtonBase)btnPause).get_FlatAppearance().set_MouseOverBackColor(Color.Transparent);
		((ButtonBase)btnPause).set_FlatStyle((FlatStyle)0);
		((Control)btnPause).set_Location(new Point(442, 12));
		((Control)btnPause).set_Name("btnPause");
		((Control)btnPause).set_Size(new Size(50, 50));
		((Control)btnPause).set_TabIndex(15);
		((ButtonBase)btnPause).set_UseVisualStyleBackColor(false);
		((Control)btnPause).add_Click((EventHandler)btnPause_Click);
		((Control)btnBack).set_Anchor((AnchorStyles)9);
		((Control)btnBack).set_BackColor(Color.Transparent);
		((Control)btnBack).set_BackgroundImageLayout((ImageLayout)3);
		((Control)btnBack).set_Cursor(Cursors.get_Hand());
		((ButtonBase)btnBack).get_FlatAppearance().set_MouseDownBackColor(Color.Transparent);
		((ButtonBase)btnBack).get_FlatAppearance().set_MouseOverBackColor(Color.Transparent);
		((ButtonBase)btnBack).set_FlatStyle((FlatStyle)0);
		((Control)btnBack).set_Location(new Point(386, 12));
		((Control)btnBack).set_Name("btnBack");
		((Control)btnBack).set_Size(new Size(50, 50));
		((Control)btnBack).set_TabIndex(16);
		((ButtonBase)btnBack).set_UseVisualStyleBackColor(false);
		((Control)btnBack).add_Click((EventHandler)btnBack_Click);
		((Control)pictureBox1).set_Anchor((AnchorStyles)0);
		((Control)pictureBox1).set_BackColor(Color.Transparent);
		((Control)pictureBox1).set_Location(new Point(371, 414));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(53, 63));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)4);
		pictureBox1.set_TabIndex(17);
		pictureBox1.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(560, 476));
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).get_Controls().Add((Control)(object)btnBack);
		((Control)this).get_Controls().Add((Control)(object)btnPause);
		((Control)this).get_Controls().Add((Control)(object)btnClose);
		((Control)this).set_DoubleBuffered(true);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("PlayGameForm");
		((Control)this).set_Text("PlayGameForm");
		((Form)this).set_WindowState((FormWindowState)2);
		((Form)this).add_Load((EventHandler)PlayGameForm_Load);
		((Control)this).add_Click((EventHandler)PlayGameForm_Click);
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
