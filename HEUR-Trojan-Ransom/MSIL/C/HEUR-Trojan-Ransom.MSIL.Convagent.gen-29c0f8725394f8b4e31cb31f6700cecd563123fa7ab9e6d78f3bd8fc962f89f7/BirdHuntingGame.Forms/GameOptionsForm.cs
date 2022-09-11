using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using BirdHuntingGame.Code;

namespace BirdHuntingGame.Forms;

public class GameOptionsForm : Form
{
	private static GameOptionsForm _Instance;

	private IContainer components = null;

	private Label label2;

	private PictureBox pbBird;

	private Label label3;

	private PictureBox pbGun;

	private Label label1;

	private Button btnStartGame;

	private ComboBox cmbBird;

	private ComboBox cmbGun;

	private Button btnClose;

	public static GameOptionsForm Instance
	{
		get
		{
			if (_Instance == null)
			{
				_Instance = new GameOptionsForm();
			}
			return _Instance;
		}
	}

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((Form)this).get_CreateParams();
			createParams.set_ExStyle(createParams.get_ExStyle() | 0x2000000);
			return createParams;
		}
	}

	private GameOptionsForm()
	{
		InitializeComponent();
	}

	private void GameOptionsForm_Load(object sender, EventArgs e)
	{
		((ListControl)cmbGun).set_SelectedIndex(0);
		((ListControl)cmbBird).set_SelectedIndex(0);
	}

	private void cmbGun_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!(cmbGun.get_SelectedItem().ToString() == "9mm Glock 17") && !(cmbGun.get_SelectedItem().ToString() == "M1 Garand Single") && cmbGun.get_SelectedItem().ToString() == "ShotGun")
		{
		}
	}

	private void cmbBird_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!(cmbBird.get_SelectedItem().ToString() == "Parrot") && !(cmbBird.get_SelectedItem().ToString() == "Stork") && cmbBird.get_SelectedItem().ToString() == "Crow")
		{
		}
	}

	private void btnStartGame_Click(object sender, EventArgs e)
	{
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		Guns gun = Guns.Shotgun;
		Birds bird = Birds.Parrot;
		if (cmbGun.get_SelectedItem().ToString() == "9mm Glock 17")
		{
			gun = Guns.Glock;
		}
		else if (cmbGun.get_SelectedItem().ToString() == "M1 Garand Single")
		{
			gun = Guns.M1Grand;
		}
		else if (cmbGun.get_SelectedItem().ToString() == "ShotGun")
		{
			gun = Guns.Shotgun;
		}
		if (cmbBird.get_SelectedItem().ToString() == "Parrot")
		{
			bird = Birds.Parrot;
		}
		else if (cmbBird.get_SelectedItem().ToString() == "Stork")
		{
			bird = Birds.Stork;
		}
		else if (cmbBird.get_SelectedItem().ToString() == "Crow")
		{
			bird = Birds.Crow;
		}
		PlayGameForm playGameForm = new PlayGameForm(gun, bird);
		((Control)this).Hide();
		((Form)playGameForm).ShowDialog();
	}

	private void btnClose_Click(object sender, EventArgs e)
	{
		Application.Exit();
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
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_076b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0775: Expected O, but got Unknown
		label2 = new Label();
		pbBird = new PictureBox();
		label3 = new Label();
		cmbBird = new ComboBox();
		pbGun = new PictureBox();
		label1 = new Label();
		cmbGun = new ComboBox();
		btnStartGame = new Button();
		btnClose = new Button();
		((ISupportInitialize)pbBird).BeginInit();
		((ISupportInitialize)pbGun).BeginInit();
		((Control)this).SuspendLayout();
		((Control)label2).set_Anchor((AnchorStyles)12);
		((Control)label2).set_BackColor(Color.Transparent);
		((Control)label2).set_Font(new Font("Segoe UI", 36f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(SystemColors.ControlLight);
		((Control)label2).set_Location(new Point(12, 62));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(626, 65));
		((Control)label2).set_TabIndex(2);
		((Control)label2).set_Text("Bird Hunting Game");
		label2.set_TextAlign((ContentAlignment)32);
		((Control)pbBird).set_Anchor((AnchorStyles)0);
		((Control)pbBird).set_BackColor(Color.Transparent);
		((Control)pbBird).set_Location(new Point(187, 408));
		((Control)pbBird).set_Name("pbBird");
		((Control)pbBird).set_Padding(new Padding(20));
		((Control)pbBird).set_Size(new Size(262, 89));
		pbBird.set_SizeMode((PictureBoxSizeMode)4);
		pbBird.set_TabIndex(11);
		pbBird.set_TabStop(false);
		((Control)label3).set_Anchor((AnchorStyles)0);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_BackColor(Color.Transparent);
		((Control)label3).set_ForeColor(SystemColors.ControlLight);
		((Control)label3).set_Location(new Point(263, 341));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(106, 25));
		((Control)label3).set_TabIndex(9);
		((Control)label3).set_Text("Select Bird");
		((Control)cmbBird).set_Anchor((AnchorStyles)0);
		((Control)cmbBird).set_Cursor(Cursors.get_Hand());
		cmbBird.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)cmbBird).set_FormattingEnabled(true);
		cmbBird.get_Items().AddRange(new object[3] { "Parrot", "Stork", "Crow" });
		((Control)cmbBird).set_Location(new Point(187, 369));
		((Control)cmbBird).set_Name("cmbBird");
		((Control)cmbBird).set_Size(new Size(262, 33));
		((Control)cmbBird).set_TabIndex(10);
		cmbBird.add_SelectedIndexChanged((EventHandler)cmbBird_SelectedIndexChanged);
		((Control)pbGun).set_Anchor((AnchorStyles)0);
		((Control)pbGun).set_BackColor(Color.Transparent);
		((Control)pbGun).set_Location(new Point(187, 231));
		((Control)pbGun).set_Name("pbGun");
		((Control)pbGun).set_Padding(new Padding(20));
		((Control)pbGun).set_Size(new Size(262, 89));
		pbGun.set_SizeMode((PictureBoxSizeMode)4);
		pbGun.set_TabIndex(8);
		pbGun.set_TabStop(false);
		((Control)label1).set_Anchor((AnchorStyles)0);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_BackColor(Color.Transparent);
		((Control)label1).set_ForeColor(SystemColors.ControlLight);
		((Control)label1).set_Location(new Point(263, 164));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(107, 25));
		((Control)label1).set_TabIndex(6);
		((Control)label1).set_Text("Select Gun");
		((Control)cmbGun).set_Anchor((AnchorStyles)0);
		((Control)cmbGun).set_Cursor(Cursors.get_Hand());
		cmbGun.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)cmbGun).set_FormattingEnabled(true);
		cmbGun.get_Items().AddRange(new object[3] { "9mm Glock 17", "M1 Garand Single", "ShotGun" });
		((Control)cmbGun).set_Location(new Point(187, 192));
		((Control)cmbGun).set_Name("cmbGun");
		((Control)cmbGun).set_Size(new Size(262, 33));
		((Control)cmbGun).set_TabIndex(7);
		cmbGun.add_SelectedIndexChanged((EventHandler)cmbGun_SelectedIndexChanged);
		((Control)btnStartGame).set_Anchor((AnchorStyles)0);
		((Control)btnStartGame).set_Cursor(Cursors.get_Hand());
		((ButtonBase)btnStartGame).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)btnStartGame).set_FlatStyle((FlatStyle)0);
		((Control)btnStartGame).set_Location(new Point(144, 503));
		((Control)btnStartGame).set_Name("btnStartGame");
		((Control)btnStartGame).set_Size(new Size(343, 84));
		((Control)btnStartGame).set_TabIndex(12);
		((Control)btnStartGame).set_Text("Start Game");
		((ButtonBase)btnStartGame).set_UseVisualStyleBackColor(true);
		((Control)btnStartGame).add_Click((EventHandler)btnStartGame_Click);
		((Control)btnClose).set_Anchor((AnchorStyles)9);
		((Control)btnClose).set_BackColor(Color.Transparent);
		((Control)btnClose).set_BackgroundImageLayout((ImageLayout)3);
		((Control)btnClose).set_Cursor(Cursors.get_Hand());
		((ButtonBase)btnClose).get_FlatAppearance().set_MouseDownBackColor(Color.Transparent);
		((ButtonBase)btnClose).get_FlatAppearance().set_MouseOverBackColor(Color.Transparent);
		((ButtonBase)btnClose).set_FlatStyle((FlatStyle)0);
		((Control)btnClose).set_Location(new Point(588, 9));
		((Control)btnClose).set_Name("btnClose");
		((Control)btnClose).set_Size(new Size(50, 50));
		((Control)btnClose).set_TabIndex(13);
		((ButtonBase)btnClose).set_UseVisualStyleBackColor(false);
		((Control)btnClose).add_Click((EventHandler)btnClose_Click);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(650, 606));
		((Control)this).get_Controls().Add((Control)(object)btnClose);
		((Control)this).get_Controls().Add((Control)(object)btnStartGame);
		((Control)this).get_Controls().Add((Control)(object)pbBird);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)cmbBird);
		((Control)this).get_Controls().Add((Control)(object)pbGun);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)cmbGun);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).set_DoubleBuffered(true);
		((Control)this).set_Font(new Font("Segoe UI", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("GameOptionsForm");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("GameOptionsForm");
		((Form)this).set_WindowState((FormWindowState)2);
		((Form)this).add_Load((EventHandler)GameOptionsForm_Load);
		((ISupportInitialize)pbBird).EndInit();
		((ISupportInitialize)pbGun).EndInit();
		((Control)this).ResumeLayout(false);
		PerformLayout();
	}

	private void PerformLayout()
	{
		new AMINOCORE();
	}
}
