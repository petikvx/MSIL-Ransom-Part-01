using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace projectChess;

public class mainmenu : Form
{
	private IContainer components = null;

	private Button game;

	private Button button1;

	private Button button2;

	private Label chey_hod;

	private Label label3;

	private PictureBox selected;

	private Label label2;

	private Label label1;

	private Button button3;

	private Button button4;

	private PictureBox p85;

	private Button exit;

	private PictureBox p_81;

	private PictureBox p71;

	private PictureBox p61;

	private PictureBox p51;

	private PictureBox p41;

	private PictureBox p31;

	private PictureBox p21;

	private PictureBox p11;

	private PictureBox p82;

	private PictureBox p72;

	private PictureBox p62;

	private PictureBox p52;

	private PictureBox p42;

	private PictureBox p32;

	private PictureBox p22;

	private PictureBox p12;

	private PictureBox p83;

	private PictureBox p73;

	private PictureBox p63;

	private PictureBox p53;

	private PictureBox p43;

	private PictureBox p33;

	private PictureBox p23;

	private PictureBox p13;

	private PictureBox p84;

	private PictureBox p74;

	private PictureBox p64;

	private PictureBox p54;

	private PictureBox p44;

	private Timer timer2;

	private Timer timer1;

	private PictureBox p34;

	private PictureBox p24;

	private PictureBox p14;

	private PictureBox p18;

	private PictureBox p75;

	private PictureBox p65;

	private PictureBox p55;

	private PictureBox p45;

	private PictureBox p35;

	private PictureBox p25;

	private PictureBox p15;

	private PictureBox p86;

	private PictureBox p76;

	private PictureBox p66;

	private PictureBox p56;

	private PictureBox p46;

	private PictureBox p36;

	private PictureBox p26;

	private PictureBox p16;

	private PictureBox p87;

	private PictureBox p77;

	private PictureBox p67;

	private PictureBox p57;

	private PictureBox p47;

	private PictureBox p37;

	private PictureBox p27;

	private PictureBox p17;

	private PictureBox p88;

	private PictureBox p78;

	private PictureBox p68;

	private PictureBox p58;

	private PictureBox p48;

	private PictureBox p38;

	private PictureBox p28;

	private PictureBox p81;

	private PictureBox board;

	private Label label4;

	private Label label5;

	private PictureBox pictureBox1;

	private Label label6;

	private Label label7;

	private Button button5;

	private Button button6;

	private PictureBox pictureBox2;

	private Button button7;

	private PictureBox pictureBox3;

	private PictureBox pictureBox4;

	private PictureBox pictureBox5;

	private PictureBox pictureBox6;

	private PictureBox pictureBox7;

	private PictureBox pictureBox8;

	private PictureBox pictureBox9;

	private PictureBox pictureBox10;

	private PictureBox pictureBox11;

	private PictureBox pictureBox12;

	private PictureBox pictureBox13;

	private PictureBox pictureBox14;

	private PictureBox pictureBox15;

	private PictureBox pictureBox16;

	private PictureBox pictureBox17;

	private PictureBox pictureBox18;

	private PictureBox pictureBox19;

	private PictureBox pictureBox20;

	private PictureBox pictureBox21;

	private PictureBox pictureBox22;

	private PictureBox pictureBox23;

	private PictureBox pictureBox24;

	private PictureBox pictureBox25;

	private PictureBox pictureBox26;

	private PictureBox pictureBox27;

	private PictureBox pictureBox28;

	private PictureBox pictureBox29;

	private PictureBox pictureBox30;

	private PictureBox pictureBox31;

	private Timer timer3;

	private Timer timer4;

	private PictureBox pictureBox32;

	private PictureBox pictureBox33;

	private PictureBox pictureBox34;

	private PictureBox pictureBox35;

	private PictureBox pictureBox36;

	private PictureBox pictureBox37;

	private PictureBox pictureBox38;

	private PictureBox pictureBox39;

	private PictureBox pictureBox40;

	private PictureBox pictureBox41;

	private PictureBox pictureBox42;

	private PictureBox pictureBox43;

	private PictureBox pictureBox44;

	private PictureBox pictureBox45;

	private PictureBox pictureBox46;

	private PictureBox pictureBox47;

	private PictureBox pictureBox48;

	private PictureBox pictureBox49;

	private PictureBox pictureBox50;

	private PictureBox pictureBox51;

	private PictureBox pictureBox52;

	private PictureBox pictureBox53;

	private PictureBox pictureBox54;

	private PictureBox pictureBox55;

	private PictureBox pictureBox56;

	private PictureBox pictureBox57;

	private PictureBox pictureBox58;

	private PictureBox pictureBox59;

	private PictureBox pictureBox60;

	private PictureBox pictureBox61;

	private PictureBox pictureBox62;

	private PictureBox pictureBox63;

	private PictureBox pictureBox64;

	private PictureBox pictureBox65;

	private PictureBox pictureBox66;

	private PictureBox pictureBox67;

	public mainmenu()
	{
		InitializeComponent();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		settings control_ = new settings();
		mainmenu.smethod_0((Control)(object)control_);
		mainmenu.smethod_1((Control)(object)this, bool_0: false);
	}

	private void button2_Click(object sender, EventArgs e)
	{
		mainmenu.smethod_2();
	}

	private void game_Click(object sender, EventArgs e)
	{
		game control_ = new game();
		mainmenu.smethod_0((Control)(object)control_);
		mainmenu.smethod_1((Control)(object)this, bool_0: false);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			mainmenu.smethod_3((IDisposable)components);
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_1228: Unknown result type (might be due to invalid IL or missing references)
		//IL_1333: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_1441: Unknown result type (might be due to invalid IL or missing references)
		//IL_14c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_154c: Unknown result type (might be due to invalid IL or missing references)
		//IL_15cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1653: Unknown result type (might be due to invalid IL or missing references)
		//IL_16da: Unknown result type (might be due to invalid IL or missing references)
		//IL_1761: Unknown result type (might be due to invalid IL or missing references)
		//IL_17e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_186f: Unknown result type (might be due to invalid IL or missing references)
		//IL_18f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1977: Unknown result type (might be due to invalid IL or missing references)
		//IL_19f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a78: Unknown result type (might be due to invalid IL or missing references)
		//IL_1afc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b80: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c04: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c88: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f12: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f96: Unknown result type (might be due to invalid IL or missing references)
		//IL_201a: Unknown result type (might be due to invalid IL or missing references)
		//IL_209e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2122: Unknown result type (might be due to invalid IL or missing references)
		//IL_21a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_2223: Unknown result type (might be due to invalid IL or missing references)
		//IL_22a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2328: Unknown result type (might be due to invalid IL or missing references)
		//IL_23a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_242d: Unknown result type (might be due to invalid IL or missing references)
		//IL_24b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2535: Unknown result type (might be due to invalid IL or missing references)
		//IL_25b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2636: Unknown result type (might be due to invalid IL or missing references)
		//IL_26b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_273b: Unknown result type (might be due to invalid IL or missing references)
		//IL_27bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_2843: Unknown result type (might be due to invalid IL or missing references)
		//IL_28c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_294b: Unknown result type (might be due to invalid IL or missing references)
		//IL_29cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2acd: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b51: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c53: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d55: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e50: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ece: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fd0: Unknown result type (might be due to invalid IL or missing references)
		//IL_3051: Unknown result type (might be due to invalid IL or missing references)
		//IL_30d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_3153: Unknown result type (might be due to invalid IL or missing references)
		//IL_31d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_324e: Unknown result type (might be due to invalid IL or missing references)
		//IL_32cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_379a: Unknown result type (might be due to invalid IL or missing references)
		//IL_38a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_392b: Unknown result type (might be due to invalid IL or missing references)
		//IL_39b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a39: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ac0: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b47: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bcb: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3de4: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ef2: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f79: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ffd: Unknown result type (might be due to invalid IL or missing references)
		//IL_4081: Unknown result type (might be due to invalid IL or missing references)
		//IL_4108: Unknown result type (might be due to invalid IL or missing references)
		//IL_418f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4216: Unknown result type (might be due to invalid IL or missing references)
		//IL_429d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4324: Unknown result type (might be due to invalid IL or missing references)
		//IL_43ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_442f: Unknown result type (might be due to invalid IL or missing references)
		//IL_44b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_453a: Unknown result type (might be due to invalid IL or missing references)
		//IL_45c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_4648: Unknown result type (might be due to invalid IL or missing references)
		//IL_46cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_4756: Unknown result type (might be due to invalid IL or missing references)
		//IL_47dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_4861: Unknown result type (might be due to invalid IL or missing references)
		//IL_48e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_4966: Unknown result type (might be due to invalid IL or missing references)
		//IL_49ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a74: Unknown result type (might be due to invalid IL or missing references)
		//IL_4afb: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b82: Unknown result type (might be due to invalid IL or missing references)
		//IL_4c09: Unknown result type (might be due to invalid IL or missing references)
		//IL_4c8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d11: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d98: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4ea6: Unknown result type (might be due to invalid IL or missing references)
		//IL_4f2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4fb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_503b: Unknown result type (might be due to invalid IL or missing references)
		//IL_50bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_5143: Unknown result type (might be due to invalid IL or missing references)
		//IL_51ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_5251: Unknown result type (might be due to invalid IL or missing references)
		//IL_52d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_535f: Unknown result type (might be due to invalid IL or missing references)
		//IL_53e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_546d: Unknown result type (might be due to invalid IL or missing references)
		//IL_54f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_5575: Unknown result type (might be due to invalid IL or missing references)
		//IL_55f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_567d: Unknown result type (might be due to invalid IL or missing references)
		//IL_5701: Unknown result type (might be due to invalid IL or missing references)
		//IL_5785: Unknown result type (might be due to invalid IL or missing references)
		//IL_5809: Unknown result type (might be due to invalid IL or missing references)
		//IL_588d: Unknown result type (might be due to invalid IL or missing references)
		//IL_590e: Unknown result type (might be due to invalid IL or missing references)
		components = mainmenu.smethod_4();
		game = mainmenu.smethod_5();
		button1 = mainmenu.smethod_5();
		button2 = mainmenu.smethod_5();
		chey_hod = mainmenu.smethod_6();
		label3 = mainmenu.smethod_6();
		selected = mainmenu.smethod_7();
		label2 = mainmenu.smethod_6();
		label1 = mainmenu.smethod_6();
		button3 = mainmenu.smethod_5();
		button4 = mainmenu.smethod_5();
		p85 = mainmenu.smethod_7();
		exit = mainmenu.smethod_5();
		p_81 = mainmenu.smethod_7();
		p71 = mainmenu.smethod_7();
		p61 = mainmenu.smethod_7();
		p51 = mainmenu.smethod_7();
		p41 = mainmenu.smethod_7();
		p31 = mainmenu.smethod_7();
		p21 = mainmenu.smethod_7();
		p11 = mainmenu.smethod_7();
		p82 = mainmenu.smethod_7();
		p72 = mainmenu.smethod_7();
		p62 = mainmenu.smethod_7();
		p52 = mainmenu.smethod_7();
		p42 = mainmenu.smethod_7();
		p32 = mainmenu.smethod_7();
		p22 = mainmenu.smethod_7();
		p12 = mainmenu.smethod_7();
		p83 = mainmenu.smethod_7();
		p73 = mainmenu.smethod_7();
		p63 = mainmenu.smethod_7();
		p53 = mainmenu.smethod_7();
		p43 = mainmenu.smethod_7();
		p33 = mainmenu.smethod_7();
		p23 = mainmenu.smethod_7();
		p13 = mainmenu.smethod_7();
		p84 = mainmenu.smethod_7();
		p74 = mainmenu.smethod_7();
		p64 = mainmenu.smethod_7();
		p54 = mainmenu.smethod_7();
		p44 = mainmenu.smethod_7();
		timer2 = mainmenu.smethod_8(components);
		timer1 = mainmenu.smethod_8(components);
		p34 = mainmenu.smethod_7();
		p24 = mainmenu.smethod_7();
		p14 = mainmenu.smethod_7();
		p18 = mainmenu.smethod_7();
		p75 = mainmenu.smethod_7();
		p65 = mainmenu.smethod_7();
		p55 = mainmenu.smethod_7();
		p45 = mainmenu.smethod_7();
		p35 = mainmenu.smethod_7();
		p25 = mainmenu.smethod_7();
		p15 = mainmenu.smethod_7();
		p86 = mainmenu.smethod_7();
		p76 = mainmenu.smethod_7();
		p66 = mainmenu.smethod_7();
		p56 = mainmenu.smethod_7();
		p46 = mainmenu.smethod_7();
		p36 = mainmenu.smethod_7();
		p26 = mainmenu.smethod_7();
		p16 = mainmenu.smethod_7();
		p87 = mainmenu.smethod_7();
		p77 = mainmenu.smethod_7();
		p67 = mainmenu.smethod_7();
		p57 = mainmenu.smethod_7();
		p47 = mainmenu.smethod_7();
		p37 = mainmenu.smethod_7();
		p27 = mainmenu.smethod_7();
		p17 = mainmenu.smethod_7();
		p88 = mainmenu.smethod_7();
		p78 = mainmenu.smethod_7();
		p68 = mainmenu.smethod_7();
		p58 = mainmenu.smethod_7();
		p48 = mainmenu.smethod_7();
		p38 = mainmenu.smethod_7();
		p28 = mainmenu.smethod_7();
		p81 = mainmenu.smethod_7();
		board = mainmenu.smethod_7();
		label4 = mainmenu.smethod_6();
		label5 = mainmenu.smethod_6();
		pictureBox1 = mainmenu.smethod_7();
		label6 = mainmenu.smethod_6();
		label7 = mainmenu.smethod_6();
		button5 = mainmenu.smethod_5();
		button6 = mainmenu.smethod_5();
		pictureBox2 = mainmenu.smethod_7();
		button7 = mainmenu.smethod_5();
		pictureBox3 = mainmenu.smethod_7();
		pictureBox4 = mainmenu.smethod_7();
		pictureBox5 = mainmenu.smethod_7();
		pictureBox6 = mainmenu.smethod_7();
		pictureBox7 = mainmenu.smethod_7();
		pictureBox8 = mainmenu.smethod_7();
		pictureBox9 = mainmenu.smethod_7();
		pictureBox10 = mainmenu.smethod_7();
		pictureBox11 = mainmenu.smethod_7();
		pictureBox12 = mainmenu.smethod_7();
		pictureBox13 = mainmenu.smethod_7();
		pictureBox14 = mainmenu.smethod_7();
		pictureBox15 = mainmenu.smethod_7();
		pictureBox16 = mainmenu.smethod_7();
		pictureBox17 = mainmenu.smethod_7();
		pictureBox18 = mainmenu.smethod_7();
		pictureBox19 = mainmenu.smethod_7();
		pictureBox20 = mainmenu.smethod_7();
		pictureBox21 = mainmenu.smethod_7();
		pictureBox22 = mainmenu.smethod_7();
		pictureBox23 = mainmenu.smethod_7();
		pictureBox24 = mainmenu.smethod_7();
		pictureBox25 = mainmenu.smethod_7();
		pictureBox26 = mainmenu.smethod_7();
		pictureBox27 = mainmenu.smethod_7();
		pictureBox28 = mainmenu.smethod_7();
		pictureBox29 = mainmenu.smethod_7();
		pictureBox30 = mainmenu.smethod_7();
		pictureBox31 = mainmenu.smethod_7();
		timer3 = mainmenu.smethod_8(components);
		timer4 = mainmenu.smethod_8(components);
		pictureBox32 = mainmenu.smethod_7();
		pictureBox33 = mainmenu.smethod_7();
		pictureBox34 = mainmenu.smethod_7();
		pictureBox35 = mainmenu.smethod_7();
		pictureBox36 = mainmenu.smethod_7();
		pictureBox37 = mainmenu.smethod_7();
		pictureBox38 = mainmenu.smethod_7();
		pictureBox39 = mainmenu.smethod_7();
		pictureBox40 = mainmenu.smethod_7();
		pictureBox41 = mainmenu.smethod_7();
		pictureBox42 = mainmenu.smethod_7();
		pictureBox43 = mainmenu.smethod_7();
		pictureBox44 = mainmenu.smethod_7();
		pictureBox45 = mainmenu.smethod_7();
		pictureBox46 = mainmenu.smethod_7();
		pictureBox47 = mainmenu.smethod_7();
		pictureBox48 = mainmenu.smethod_7();
		pictureBox49 = mainmenu.smethod_7();
		pictureBox50 = mainmenu.smethod_7();
		pictureBox51 = mainmenu.smethod_7();
		pictureBox52 = mainmenu.smethod_7();
		pictureBox53 = mainmenu.smethod_7();
		pictureBox54 = mainmenu.smethod_7();
		pictureBox55 = mainmenu.smethod_7();
		pictureBox56 = mainmenu.smethod_7();
		pictureBox57 = mainmenu.smethod_7();
		pictureBox58 = mainmenu.smethod_7();
		pictureBox59 = mainmenu.smethod_7();
		pictureBox60 = mainmenu.smethod_7();
		pictureBox61 = mainmenu.smethod_7();
		pictureBox62 = mainmenu.smethod_7();
		pictureBox63 = mainmenu.smethod_7();
		pictureBox64 = mainmenu.smethod_7();
		pictureBox65 = mainmenu.smethod_7();
		pictureBox66 = mainmenu.smethod_7();
		pictureBox67 = mainmenu.smethod_7();
		mainmenu.smethod_9((ISupportInitialize)selected);
		mainmenu.smethod_9((ISupportInitialize)p85);
		mainmenu.smethod_9((ISupportInitialize)p_81);
		mainmenu.smethod_9((ISupportInitialize)p71);
		mainmenu.smethod_9((ISupportInitialize)p61);
		mainmenu.smethod_9((ISupportInitialize)p51);
		mainmenu.smethod_9((ISupportInitialize)p41);
		mainmenu.smethod_9((ISupportInitialize)p31);
		mainmenu.smethod_9((ISupportInitialize)p21);
		mainmenu.smethod_9((ISupportInitialize)p11);
		mainmenu.smethod_9((ISupportInitialize)p82);
		mainmenu.smethod_9((ISupportInitialize)p72);
		mainmenu.smethod_9((ISupportInitialize)p62);
		mainmenu.smethod_9((ISupportInitialize)p52);
		mainmenu.smethod_9((ISupportInitialize)p42);
		mainmenu.smethod_9((ISupportInitialize)p32);
		mainmenu.smethod_9((ISupportInitialize)p22);
		mainmenu.smethod_9((ISupportInitialize)p12);
		mainmenu.smethod_9((ISupportInitialize)p83);
		mainmenu.smethod_9((ISupportInitialize)p73);
		mainmenu.smethod_9((ISupportInitialize)p63);
		mainmenu.smethod_9((ISupportInitialize)p53);
		mainmenu.smethod_9((ISupportInitialize)p43);
		mainmenu.smethod_9((ISupportInitialize)p33);
		mainmenu.smethod_9((ISupportInitialize)p23);
		mainmenu.smethod_9((ISupportInitialize)p13);
		mainmenu.smethod_9((ISupportInitialize)p84);
		mainmenu.smethod_9((ISupportInitialize)p74);
		mainmenu.smethod_9((ISupportInitialize)p64);
		mainmenu.smethod_9((ISupportInitialize)p54);
		mainmenu.smethod_9((ISupportInitialize)p44);
		mainmenu.smethod_9((ISupportInitialize)p34);
		mainmenu.smethod_9((ISupportInitialize)p24);
		mainmenu.smethod_9((ISupportInitialize)p14);
		mainmenu.smethod_9((ISupportInitialize)p18);
		mainmenu.smethod_9((ISupportInitialize)p75);
		mainmenu.smethod_9((ISupportInitialize)p65);
		mainmenu.smethod_9((ISupportInitialize)p55);
		mainmenu.smethod_9((ISupportInitialize)p45);
		mainmenu.smethod_9((ISupportInitialize)p35);
		mainmenu.smethod_9((ISupportInitialize)p25);
		mainmenu.smethod_9((ISupportInitialize)p15);
		mainmenu.smethod_9((ISupportInitialize)p86);
		mainmenu.smethod_9((ISupportInitialize)p76);
		mainmenu.smethod_9((ISupportInitialize)p66);
		mainmenu.smethod_9((ISupportInitialize)p56);
		mainmenu.smethod_9((ISupportInitialize)p46);
		mainmenu.smethod_9((ISupportInitialize)p36);
		mainmenu.smethod_9((ISupportInitialize)p26);
		mainmenu.smethod_9((ISupportInitialize)p16);
		mainmenu.smethod_9((ISupportInitialize)p87);
		mainmenu.smethod_9((ISupportInitialize)p77);
		mainmenu.smethod_9((ISupportInitialize)p67);
		mainmenu.smethod_9((ISupportInitialize)p57);
		mainmenu.smethod_9((ISupportInitialize)p47);
		mainmenu.smethod_9((ISupportInitialize)p37);
		mainmenu.smethod_9((ISupportInitialize)p27);
		mainmenu.smethod_9((ISupportInitialize)p17);
		mainmenu.smethod_9((ISupportInitialize)p88);
		mainmenu.smethod_9((ISupportInitialize)p78);
		mainmenu.smethod_9((ISupportInitialize)p68);
		mainmenu.smethod_9((ISupportInitialize)p58);
		mainmenu.smethod_9((ISupportInitialize)p48);
		mainmenu.smethod_9((ISupportInitialize)p38);
		mainmenu.smethod_9((ISupportInitialize)p28);
		mainmenu.smethod_9((ISupportInitialize)p81);
		mainmenu.smethod_9((ISupportInitialize)board);
		mainmenu.smethod_9((ISupportInitialize)pictureBox1);
		mainmenu.smethod_9((ISupportInitialize)pictureBox2);
		mainmenu.smethod_9((ISupportInitialize)pictureBox3);
		mainmenu.smethod_9((ISupportInitialize)pictureBox4);
		mainmenu.smethod_9((ISupportInitialize)pictureBox5);
		mainmenu.smethod_9((ISupportInitialize)pictureBox6);
		mainmenu.smethod_9((ISupportInitialize)pictureBox7);
		mainmenu.smethod_9((ISupportInitialize)pictureBox8);
		mainmenu.smethod_9((ISupportInitialize)pictureBox9);
		mainmenu.smethod_9((ISupportInitialize)pictureBox10);
		mainmenu.smethod_9((ISupportInitialize)pictureBox11);
		mainmenu.smethod_9((ISupportInitialize)pictureBox12);
		mainmenu.smethod_9((ISupportInitialize)pictureBox13);
		mainmenu.smethod_9((ISupportInitialize)pictureBox14);
		mainmenu.smethod_9((ISupportInitialize)pictureBox15);
		mainmenu.smethod_9((ISupportInitialize)pictureBox16);
		mainmenu.smethod_9((ISupportInitialize)pictureBox17);
		mainmenu.smethod_9((ISupportInitialize)pictureBox18);
		mainmenu.smethod_9((ISupportInitialize)pictureBox19);
		mainmenu.smethod_9((ISupportInitialize)pictureBox20);
		mainmenu.smethod_9((ISupportInitialize)pictureBox21);
		mainmenu.smethod_9((ISupportInitialize)pictureBox22);
		mainmenu.smethod_9((ISupportInitialize)pictureBox23);
		mainmenu.smethod_9((ISupportInitialize)pictureBox24);
		mainmenu.smethod_9((ISupportInitialize)pictureBox25);
		mainmenu.smethod_9((ISupportInitialize)pictureBox26);
		mainmenu.smethod_9((ISupportInitialize)pictureBox27);
		mainmenu.smethod_9((ISupportInitialize)pictureBox28);
		mainmenu.smethod_9((ISupportInitialize)pictureBox29);
		mainmenu.smethod_9((ISupportInitialize)pictureBox30);
		mainmenu.smethod_9((ISupportInitialize)pictureBox31);
		mainmenu.smethod_9((ISupportInitialize)pictureBox32);
		mainmenu.smethod_9((ISupportInitialize)pictureBox33);
		mainmenu.smethod_9((ISupportInitialize)pictureBox34);
		mainmenu.smethod_9((ISupportInitialize)pictureBox35);
		mainmenu.smethod_9((ISupportInitialize)pictureBox36);
		mainmenu.smethod_9((ISupportInitialize)pictureBox37);
		mainmenu.smethod_9((ISupportInitialize)pictureBox38);
		mainmenu.smethod_9((ISupportInitialize)pictureBox39);
		mainmenu.smethod_9((ISupportInitialize)pictureBox40);
		mainmenu.smethod_9((ISupportInitialize)pictureBox41);
		mainmenu.smethod_9((ISupportInitialize)pictureBox42);
		mainmenu.smethod_9((ISupportInitialize)pictureBox43);
		mainmenu.smethod_9((ISupportInitialize)pictureBox44);
		mainmenu.smethod_9((ISupportInitialize)pictureBox45);
		mainmenu.smethod_9((ISupportInitialize)pictureBox46);
		mainmenu.smethod_9((ISupportInitialize)pictureBox47);
		mainmenu.smethod_9((ISupportInitialize)pictureBox48);
		mainmenu.smethod_9((ISupportInitialize)pictureBox49);
		mainmenu.smethod_9((ISupportInitialize)pictureBox50);
		mainmenu.smethod_9((ISupportInitialize)pictureBox51);
		mainmenu.smethod_9((ISupportInitialize)pictureBox52);
		mainmenu.smethod_9((ISupportInitialize)pictureBox53);
		mainmenu.smethod_9((ISupportInitialize)pictureBox54);
		mainmenu.smethod_9((ISupportInitialize)pictureBox55);
		mainmenu.smethod_9((ISupportInitialize)pictureBox56);
		mainmenu.smethod_9((ISupportInitialize)pictureBox57);
		mainmenu.smethod_9((ISupportInitialize)pictureBox58);
		mainmenu.smethod_9((ISupportInitialize)pictureBox59);
		mainmenu.smethod_9((ISupportInitialize)pictureBox60);
		mainmenu.smethod_9((ISupportInitialize)pictureBox61);
		mainmenu.smethod_9((ISupportInitialize)pictureBox62);
		mainmenu.smethod_9((ISupportInitialize)pictureBox63);
		mainmenu.smethod_9((ISupportInitialize)pictureBox64);
		mainmenu.smethod_9((ISupportInitialize)pictureBox65);
		mainmenu.smethod_9((ISupportInitialize)pictureBox66);
		mainmenu.smethod_9((ISupportInitialize)pictureBox67);
		mainmenu.smethod_10((Control)(object)this);
		mainmenu.smethod_12((Control)(object)game, mainmenu.smethod_11("Microsoft Sans Serif", 38.25f));
		mainmenu.smethod_13((Control)(object)game, new Point(182, 48));
		mainmenu.smethod_14((Control)(object)game, "game");
		mainmenu.smethod_15((Control)(object)game, new Size(555, 130));
		mainmenu.smethod_16((Control)(object)game, 0);
		mainmenu.smethod_17((Control)(object)game, "Играть");
		mainmenu.smethod_18((ButtonBase)(object)game, bool_0: true);
		mainmenu.smethod_19((Control)(object)game, (EventHandler)game_Click);
		mainmenu.smethod_12((Control)(object)button1, mainmenu.smethod_11("Microsoft Sans Serif", 38.25f));
		mainmenu.smethod_13((Control)(object)button1, new Point(182, 225));
		mainmenu.smethod_14((Control)(object)button1, "button1");
		mainmenu.smethod_15((Control)(object)button1, new Size(555, 130));
		mainmenu.smethod_16((Control)(object)button1, 1);
		mainmenu.smethod_17((Control)(object)button1, "Настройки");
		mainmenu.smethod_18((ButtonBase)(object)button1, bool_0: true);
		mainmenu.smethod_19((Control)(object)button1, (EventHandler)button1_Click);
		mainmenu.smethod_12((Control)(object)button2, mainmenu.smethod_11("Microsoft Sans Serif", 38.25f));
		mainmenu.smethod_13((Control)(object)button2, new Point(182, 396));
		mainmenu.smethod_14((Control)(object)button2, "button2");
		mainmenu.smethod_15((Control)(object)button2, new Size(555, 130));
		mainmenu.smethod_16((Control)(object)button2, 2);
		mainmenu.smethod_17((Control)(object)button2, "Выход");
		mainmenu.smethod_18((ButtonBase)(object)button2, bool_0: true);
		mainmenu.smethod_19((Control)(object)button2, (EventHandler)button2_Click);
		mainmenu.smethod_20((Control)(object)chey_hod, bool_0: true);
		mainmenu.smethod_12((Control)(object)chey_hod, mainmenu.smethod_11("Microsoft Sans Serif", 28.25f));
		mainmenu.smethod_13((Control)(object)chey_hod, new Point(784, 240));
		mainmenu.smethod_14((Control)(object)chey_hod, "chey_hod");
		mainmenu.smethod_15((Control)(object)chey_hod, new Size(272, 44));
		mainmenu.smethod_16((Control)(object)chey_hod, 147);
		mainmenu.smethod_17((Control)(object)chey_hod, "Ходят - белые");
		mainmenu.smethod_20((Control)(object)label3, bool_0: true);
		mainmenu.smethod_12((Control)(object)label3, mainmenu.smethod_11("Microsoft Sans Serif", 18.25f));
		mainmenu.smethod_13((Control)(object)label3, new Point(801, 415));
		mainmenu.smethod_14((Control)(object)label3, "label3");
		mainmenu.smethod_15((Control)(object)label3, new Size(235, 29));
		mainmenu.smethod_16((Control)(object)label3, 146);
		mainmenu.smethod_17((Control)(object)label3, "выбранная фигура");
		mainmenu.smethod_21((Control)(object)selected, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)selected, new Point(853, 470));
		mainmenu.smethod_14((Control)(object)selected, "selected");
		mainmenu.smethod_15((Control)(object)selected, new Size(130, 130));
		mainmenu.smethod_22(selected, 145);
		mainmenu.smethod_23(selected, bool_0: false);
		mainmenu.smethod_20((Control)(object)label2, bool_0: true);
		mainmenu.smethod_12((Control)(object)label2, mainmenu.smethod_11("Microsoft Sans Serif", 38.25f));
		mainmenu.smethod_13((Control)(object)label2, new Point(569, 174));
		mainmenu.smethod_14((Control)(object)label2, "label2");
		mainmenu.smethod_15((Control)(object)label2, new Size(95, 59));
		mainmenu.smethod_16((Control)(object)label2, 144);
		mainmenu.smethod_17((Control)(object)label2, "0:0");
		mainmenu.smethod_24((Control)(object)label2, bool_0: false);
		mainmenu.smethod_20((Control)(object)label1, bool_0: true);
		mainmenu.smethod_12((Control)(object)label1, mainmenu.smethod_11("Microsoft Sans Serif", 38.25f));
		mainmenu.smethod_13((Control)(object)label1, new Point(569, 290));
		mainmenu.smethod_14((Control)(object)label1, "label1");
		mainmenu.smethod_15((Control)(object)label1, new Size(95, 59));
		mainmenu.smethod_16((Control)(object)label1, 143);
		mainmenu.smethod_17((Control)(object)label1, "0:0");
		mainmenu.smethod_24((Control)(object)label1, bool_0: false);
		mainmenu.smethod_26((Control)(object)button3, mainmenu.smethod_25());
		mainmenu.smethod_13((Control)(object)button3, new Point(560, 67));
		mainmenu.smethod_14((Control)(object)button3, "button3");
		mainmenu.smethod_15((Control)(object)button3, new Size(120, 78));
		mainmenu.smethod_16((Control)(object)button3, 142);
		mainmenu.smethod_18((ButtonBase)(object)button3, bool_0: false);
		mainmenu.smethod_24((Control)(object)button3, bool_0: false);
		mainmenu.smethod_26((Control)(object)button4, mainmenu.smethod_25());
		mainmenu.smethod_13((Control)(object)button4, new Point(560, 394));
		mainmenu.smethod_14((Control)(object)button4, "button4");
		mainmenu.smethod_15((Control)(object)button4, new Size(120, 78));
		mainmenu.smethod_16((Control)(object)button4, 141);
		mainmenu.smethod_18((ButtonBase)(object)button4, bool_0: false);
		mainmenu.smethod_24((Control)(object)button4, bool_0: false);
		mainmenu.smethod_26((Control)(object)p85, Color.White);
		mainmenu.smethod_21((Control)(object)p85, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p85, new Point(352, 229));
		mainmenu.smethod_27((Control)(object)p85, new Padding(0));
		mainmenu.smethod_14((Control)(object)p85, "p85");
		mainmenu.smethod_15((Control)(object)p85, new Size(70, 70));
		mainmenu.smethod_22(p85, 140);
		mainmenu.smethod_23(p85, bool_0: false);
		mainmenu.smethod_12((Control)(object)exit, mainmenu.smethod_11("Microsoft Sans Serif", 28.25f));
		mainmenu.smethod_13((Control)(object)exit, new Point(782, -39));
		mainmenu.smethod_14((Control)(object)exit, "exit");
		mainmenu.smethod_15((Control)(object)exit, new Size(188, 47));
		mainmenu.smethod_16((Control)(object)exit, 139);
		mainmenu.smethod_17((Control)(object)exit, "ВЫХОД");
		mainmenu.smethod_18((ButtonBase)(object)exit, bool_0: true);
		mainmenu.smethod_26((Control)(object)p_81, Color.White);
		mainmenu.smethod_21((Control)(object)p_81, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p_81, new Point(352, 509));
		mainmenu.smethod_27((Control)(object)p_81, new Padding(0));
		mainmenu.smethod_14((Control)(object)p_81, "p_81");
		mainmenu.smethod_15((Control)(object)p_81, new Size(70, 70));
		mainmenu.smethod_22(p_81, 138);
		mainmenu.smethod_23(p_81, bool_0: false);
		mainmenu.smethod_26((Control)(object)p71, Color.DimGray);
		mainmenu.smethod_21((Control)(object)p71, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p71, new Point(282, 509));
		mainmenu.smethod_27((Control)(object)p71, new Padding(0));
		mainmenu.smethod_14((Control)(object)p71, "p71");
		mainmenu.smethod_15((Control)(object)p71, new Size(70, 70));
		mainmenu.smethod_22(p71, 137);
		mainmenu.smethod_23(p71, bool_0: false);
		mainmenu.smethod_26((Control)(object)p61, Color.White);
		mainmenu.smethod_21((Control)(object)p61, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p61, new Point(212, 509));
		mainmenu.smethod_27((Control)(object)p61, new Padding(0));
		mainmenu.smethod_14((Control)(object)p61, "p61");
		mainmenu.smethod_15((Control)(object)p61, new Size(70, 70));
		mainmenu.smethod_22(p61, 136);
		mainmenu.smethod_23(p61, bool_0: false);
		mainmenu.smethod_26((Control)(object)p51, Color.DimGray);
		mainmenu.smethod_21((Control)(object)p51, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p51, new Point(142, 509));
		mainmenu.smethod_27((Control)(object)p51, new Padding(0));
		mainmenu.smethod_14((Control)(object)p51, "p51");
		mainmenu.smethod_15((Control)(object)p51, new Size(70, 70));
		mainmenu.smethod_22(p51, 135);
		mainmenu.smethod_23(p51, bool_0: false);
		mainmenu.smethod_26((Control)(object)p41, Color.White);
		mainmenu.smethod_21((Control)(object)p41, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p41, new Point(72, 509));
		mainmenu.smethod_27((Control)(object)p41, new Padding(0));
		mainmenu.smethod_14((Control)(object)p41, "p41");
		mainmenu.smethod_15((Control)(object)p41, new Size(70, 70));
		mainmenu.smethod_22(p41, 134);
		mainmenu.smethod_23(p41, bool_0: false);
		mainmenu.smethod_26((Control)(object)p31, Color.DimGray);
		mainmenu.smethod_21((Control)(object)p31, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p31, new Point(2, 509));
		mainmenu.smethod_27((Control)(object)p31, new Padding(0));
		mainmenu.smethod_14((Control)(object)p31, "p31");
		mainmenu.smethod_15((Control)(object)p31, new Size(70, 70));
		mainmenu.smethod_22(p31, 133);
		mainmenu.smethod_23(p31, bool_0: false);
		mainmenu.smethod_26((Control)(object)p21, Color.White);
		mainmenu.smethod_21((Control)(object)p21, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p21, new Point(-68, 509));
		mainmenu.smethod_27((Control)(object)p21, new Padding(0));
		mainmenu.smethod_14((Control)(object)p21, "p21");
		mainmenu.smethod_15((Control)(object)p21, new Size(70, 70));
		mainmenu.smethod_22(p21, 132);
		mainmenu.smethod_23(p21, bool_0: false);
		mainmenu.smethod_26((Control)(object)p11, Color.DimGray);
		mainmenu.smethod_21((Control)(object)p11, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p11, new Point(-138, 509));
		mainmenu.smethod_27((Control)(object)p11, new Padding(0));
		mainmenu.smethod_14((Control)(object)p11, "p11");
		mainmenu.smethod_15((Control)(object)p11, new Size(70, 70));
		mainmenu.smethod_22(p11, 131);
		mainmenu.smethod_23(p11, bool_0: false);
		mainmenu.smethod_26((Control)(object)p82, Color.DimGray);
		mainmenu.smethod_21((Control)(object)p82, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p82, new Point(352, 439));
		mainmenu.smethod_27((Control)(object)p82, new Padding(0));
		mainmenu.smethod_14((Control)(object)p82, "p82");
		mainmenu.smethod_15((Control)(object)p82, new Size(70, 70));
		mainmenu.smethod_22(p82, 130);
		mainmenu.smethod_23(p82, bool_0: false);
		mainmenu.smethod_26((Control)(object)p72, Color.White);
		mainmenu.smethod_21((Control)(object)p72, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p72, new Point(282, 439));
		mainmenu.smethod_27((Control)(object)p72, new Padding(0));
		mainmenu.smethod_14((Control)(object)p72, "p72");
		mainmenu.smethod_15((Control)(object)p72, new Size(70, 70));
		mainmenu.smethod_22(p72, 129);
		mainmenu.smethod_23(p72, bool_0: false);
		mainmenu.smethod_26((Control)(object)p62, Color.DimGray);
		mainmenu.smethod_21((Control)(object)p62, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p62, new Point(212, 439));
		mainmenu.smethod_27((Control)(object)p62, new Padding(0));
		mainmenu.smethod_14((Control)(object)p62, "p62");
		mainmenu.smethod_15((Control)(object)p62, new Size(70, 70));
		mainmenu.smethod_22(p62, 128);
		mainmenu.smethod_23(p62, bool_0: false);
		mainmenu.smethod_26((Control)(object)p52, Color.White);
		mainmenu.smethod_21((Control)(object)p52, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p52, new Point(142, 439));
		mainmenu.smethod_27((Control)(object)p52, new Padding(0));
		mainmenu.smethod_14((Control)(object)p52, "p52");
		mainmenu.smethod_15((Control)(object)p52, new Size(70, 70));
		mainmenu.smethod_22(p52, 127);
		mainmenu.smethod_23(p52, bool_0: false);
		mainmenu.smethod_26((Control)(object)p42, Color.DimGray);
		mainmenu.smethod_21((Control)(object)p42, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p42, new Point(72, 439));
		mainmenu.smethod_27((Control)(object)p42, new Padding(0));
		mainmenu.smethod_14((Control)(object)p42, "p42");
		mainmenu.smethod_15((Control)(object)p42, new Size(70, 70));
		mainmenu.smethod_22(p42, 126);
		mainmenu.smethod_23(p42, bool_0: false);
		mainmenu.smethod_26((Control)(object)p32, Color.White);
		mainmenu.smethod_21((Control)(object)p32, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p32, new Point(2, 439));
		mainmenu.smethod_27((Control)(object)p32, new Padding(0));
		mainmenu.smethod_14((Control)(object)p32, "p32");
		mainmenu.smethod_15((Control)(object)p32, new Size(70, 70));
		mainmenu.smethod_22(p32, 125);
		mainmenu.smethod_23(p32, bool_0: false);
		mainmenu.smethod_26((Control)(object)p22, Color.DimGray);
		mainmenu.smethod_21((Control)(object)p22, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p22, new Point(-68, 439));
		mainmenu.smethod_27((Control)(object)p22, new Padding(0));
		mainmenu.smethod_14((Control)(object)p22, "p22");
		mainmenu.smethod_15((Control)(object)p22, new Size(70, 70));
		mainmenu.smethod_22(p22, 124);
		mainmenu.smethod_23(p22, bool_0: false);
		mainmenu.smethod_26((Control)(object)p12, Color.White);
		mainmenu.smethod_21((Control)(object)p12, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p12, new Point(-138, 439));
		mainmenu.smethod_27((Control)(object)p12, new Padding(0));
		mainmenu.smethod_14((Control)(object)p12, "p12");
		mainmenu.smethod_15((Control)(object)p12, new Size(70, 70));
		mainmenu.smethod_22(p12, 123);
		mainmenu.smethod_23(p12, bool_0: false);
		mainmenu.smethod_26((Control)(object)p83, Color.White);
		mainmenu.smethod_21((Control)(object)p83, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p83, new Point(352, 369));
		mainmenu.smethod_27((Control)(object)p83, new Padding(0));
		mainmenu.smethod_14((Control)(object)p83, "p83");
		mainmenu.smethod_15((Control)(object)p83, new Size(70, 70));
		mainmenu.smethod_22(p83, 122);
		mainmenu.smethod_23(p83, bool_0: false);
		mainmenu.smethod_26((Control)(object)p73, Color.DimGray);
		mainmenu.smethod_21((Control)(object)p73, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p73, new Point(282, 369));
		mainmenu.smethod_27((Control)(object)p73, new Padding(0));
		mainmenu.smethod_14((Control)(object)p73, "p73");
		mainmenu.smethod_15((Control)(object)p73, new Size(70, 70));
		mainmenu.smethod_22(p73, 121);
		mainmenu.smethod_23(p73, bool_0: false);
		mainmenu.smethod_26((Control)(object)p63, Color.White);
		mainmenu.smethod_21((Control)(object)p63, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p63, new Point(212, 369));
		mainmenu.smethod_27((Control)(object)p63, new Padding(0));
		mainmenu.smethod_14((Control)(object)p63, "p63");
		mainmenu.smethod_15((Control)(object)p63, new Size(70, 70));
		mainmenu.smethod_22(p63, 120);
		mainmenu.smethod_23(p63, bool_0: false);
		mainmenu.smethod_26((Control)(object)p53, Color.DimGray);
		mainmenu.smethod_21((Control)(object)p53, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p53, new Point(142, 369));
		mainmenu.smethod_27((Control)(object)p53, new Padding(0));
		mainmenu.smethod_14((Control)(object)p53, "p53");
		mainmenu.smethod_15((Control)(object)p53, new Size(70, 70));
		mainmenu.smethod_22(p53, 119);
		mainmenu.smethod_23(p53, bool_0: false);
		mainmenu.smethod_26((Control)(object)p43, Color.White);
		mainmenu.smethod_21((Control)(object)p43, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p43, new Point(72, 369));
		mainmenu.smethod_27((Control)(object)p43, new Padding(0));
		mainmenu.smethod_14((Control)(object)p43, "p43");
		mainmenu.smethod_15((Control)(object)p43, new Size(70, 70));
		mainmenu.smethod_22(p43, 118);
		mainmenu.smethod_23(p43, bool_0: false);
		mainmenu.smethod_26((Control)(object)p33, Color.DimGray);
		mainmenu.smethod_21((Control)(object)p33, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p33, new Point(2, 369));
		mainmenu.smethod_27((Control)(object)p33, new Padding(0));
		mainmenu.smethod_14((Control)(object)p33, "p33");
		mainmenu.smethod_15((Control)(object)p33, new Size(70, 70));
		mainmenu.smethod_22(p33, 117);
		mainmenu.smethod_23(p33, bool_0: false);
		mainmenu.smethod_26((Control)(object)p23, Color.White);
		mainmenu.smethod_21((Control)(object)p23, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p23, new Point(-68, 369));
		mainmenu.smethod_27((Control)(object)p23, new Padding(0));
		mainmenu.smethod_14((Control)(object)p23, "p23");
		mainmenu.smethod_15((Control)(object)p23, new Size(70, 70));
		mainmenu.smethod_22(p23, 116);
		mainmenu.smethod_23(p23, bool_0: false);
		mainmenu.smethod_26((Control)(object)p13, Color.DimGray);
		mainmenu.smethod_21((Control)(object)p13, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p13, new Point(-138, 369));
		mainmenu.smethod_27((Control)(object)p13, new Padding(0));
		mainmenu.smethod_14((Control)(object)p13, "p13");
		mainmenu.smethod_15((Control)(object)p13, new Size(70, 70));
		mainmenu.smethod_22(p13, 115);
		mainmenu.smethod_23(p13, bool_0: false);
		mainmenu.smethod_26((Control)(object)p84, Color.DimGray);
		mainmenu.smethod_21((Control)(object)p84, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p84, new Point(352, 299));
		mainmenu.smethod_27((Control)(object)p84, new Padding(0));
		mainmenu.smethod_14((Control)(object)p84, "p84");
		mainmenu.smethod_15((Control)(object)p84, new Size(70, 70));
		mainmenu.smethod_22(p84, 114);
		mainmenu.smethod_23(p84, bool_0: false);
		mainmenu.smethod_26((Control)(object)p74, Color.White);
		mainmenu.smethod_21((Control)(object)p74, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p74, new Point(282, 299));
		mainmenu.smethod_27((Control)(object)p74, new Padding(0));
		mainmenu.smethod_14((Control)(object)p74, "p74");
		mainmenu.smethod_15((Control)(object)p74, new Size(70, 70));
		mainmenu.smethod_22(p74, 113);
		mainmenu.smethod_23(p74, bool_0: false);
		mainmenu.smethod_26((Control)(object)p64, Color.DimGray);
		mainmenu.smethod_21((Control)(object)p64, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p64, new Point(212, 299));
		mainmenu.smethod_27((Control)(object)p64, new Padding(0));
		mainmenu.smethod_14((Control)(object)p64, "p64");
		mainmenu.smethod_15((Control)(object)p64, new Size(70, 70));
		mainmenu.smethod_22(p64, 112);
		mainmenu.smethod_23(p64, bool_0: false);
		mainmenu.smethod_26((Control)(object)p54, Color.White);
		mainmenu.smethod_21((Control)(object)p54, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p54, new Point(142, 299));
		mainmenu.smethod_27((Control)(object)p54, new Padding(0));
		mainmenu.smethod_14((Control)(object)p54, "p54");
		mainmenu.smethod_15((Control)(object)p54, new Size(70, 70));
		mainmenu.smethod_22(p54, 111);
		mainmenu.smethod_23(p54, bool_0: false);
		mainmenu.smethod_26((Control)(object)p44, Color.DimGray);
		mainmenu.smethod_21((Control)(object)p44, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p44, new Point(72, 299));
		mainmenu.smethod_27((Control)(object)p44, new Padding(0));
		mainmenu.smethod_14((Control)(object)p44, "p44");
		mainmenu.smethod_15((Control)(object)p44, new Size(70, 70));
		mainmenu.smethod_22(p44, 110);
		mainmenu.smethod_23(p44, bool_0: false);
		mainmenu.smethod_26((Control)(object)p34, Color.White);
		mainmenu.smethod_21((Control)(object)p34, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p34, new Point(2, 299));
		mainmenu.smethod_27((Control)(object)p34, new Padding(0));
		mainmenu.smethod_14((Control)(object)p34, "p34");
		mainmenu.smethod_15((Control)(object)p34, new Size(70, 70));
		mainmenu.smethod_22(p34, 109);
		mainmenu.smethod_23(p34, bool_0: false);
		mainmenu.smethod_26((Control)(object)p24, Color.DimGray);
		mainmenu.smethod_21((Control)(object)p24, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p24, new Point(-68, 299));
		mainmenu.smethod_27((Control)(object)p24, new Padding(0));
		mainmenu.smethod_14((Control)(object)p24, "p24");
		mainmenu.smethod_15((Control)(object)p24, new Size(70, 70));
		mainmenu.smethod_22(p24, 108);
		mainmenu.smethod_23(p24, bool_0: false);
		mainmenu.smethod_26((Control)(object)p14, Color.White);
		mainmenu.smethod_21((Control)(object)p14, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p14, new Point(-138, 299));
		mainmenu.smethod_27((Control)(object)p14, new Padding(0));
		mainmenu.smethod_14((Control)(object)p14, "p14");
		mainmenu.smethod_15((Control)(object)p14, new Size(70, 70));
		mainmenu.smethod_22(p14, 107);
		mainmenu.smethod_23(p14, bool_0: false);
		mainmenu.smethod_26((Control)(object)p18, Color.White);
		mainmenu.smethod_21((Control)(object)p18, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p18, new Point(-138, 19));
		mainmenu.smethod_27((Control)(object)p18, new Padding(0));
		mainmenu.smethod_14((Control)(object)p18, "p18");
		mainmenu.smethod_15((Control)(object)p18, new Size(70, 70));
		mainmenu.smethod_22(p18, 106);
		mainmenu.smethod_23(p18, bool_0: false);
		mainmenu.smethod_26((Control)(object)p75, Color.DimGray);
		mainmenu.smethod_21((Control)(object)p75, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p75, new Point(282, 229));
		mainmenu.smethod_27((Control)(object)p75, new Padding(0));
		mainmenu.smethod_14((Control)(object)p75, "p75");
		mainmenu.smethod_15((Control)(object)p75, new Size(70, 70));
		mainmenu.smethod_22(p75, 105);
		mainmenu.smethod_23(p75, bool_0: false);
		mainmenu.smethod_26((Control)(object)p65, Color.White);
		mainmenu.smethod_21((Control)(object)p65, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p65, new Point(212, 229));
		mainmenu.smethod_27((Control)(object)p65, new Padding(0));
		mainmenu.smethod_14((Control)(object)p65, "p65");
		mainmenu.smethod_15((Control)(object)p65, new Size(70, 70));
		mainmenu.smethod_22(p65, 104);
		mainmenu.smethod_23(p65, bool_0: false);
		mainmenu.smethod_26((Control)(object)p55, Color.DimGray);
		mainmenu.smethod_21((Control)(object)p55, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p55, new Point(142, 229));
		mainmenu.smethod_27((Control)(object)p55, new Padding(0));
		mainmenu.smethod_14((Control)(object)p55, "p55");
		mainmenu.smethod_15((Control)(object)p55, new Size(70, 70));
		mainmenu.smethod_22(p55, 103);
		mainmenu.smethod_23(p55, bool_0: false);
		mainmenu.smethod_26((Control)(object)p45, Color.White);
		mainmenu.smethod_21((Control)(object)p45, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p45, new Point(72, 229));
		mainmenu.smethod_27((Control)(object)p45, new Padding(0));
		mainmenu.smethod_14((Control)(object)p45, "p45");
		mainmenu.smethod_15((Control)(object)p45, new Size(70, 70));
		mainmenu.smethod_22(p45, 102);
		mainmenu.smethod_23(p45, bool_0: false);
		mainmenu.smethod_26((Control)(object)p35, Color.DimGray);
		mainmenu.smethod_21((Control)(object)p35, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p35, new Point(2, 229));
		mainmenu.smethod_27((Control)(object)p35, new Padding(0));
		mainmenu.smethod_14((Control)(object)p35, "p35");
		mainmenu.smethod_15((Control)(object)p35, new Size(70, 70));
		mainmenu.smethod_22(p35, 101);
		mainmenu.smethod_23(p35, bool_0: false);
		mainmenu.smethod_26((Control)(object)p25, Color.White);
		mainmenu.smethod_21((Control)(object)p25, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p25, new Point(-68, 229));
		mainmenu.smethod_27((Control)(object)p25, new Padding(0));
		mainmenu.smethod_14((Control)(object)p25, "p25");
		mainmenu.smethod_15((Control)(object)p25, new Size(70, 70));
		mainmenu.smethod_22(p25, 100);
		mainmenu.smethod_23(p25, bool_0: false);
		mainmenu.smethod_26((Control)(object)p15, Color.DimGray);
		mainmenu.smethod_21((Control)(object)p15, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p15, new Point(-138, 229));
		mainmenu.smethod_27((Control)(object)p15, new Padding(0));
		mainmenu.smethod_14((Control)(object)p15, "p15");
		mainmenu.smethod_15((Control)(object)p15, new Size(70, 70));
		mainmenu.smethod_22(p15, 99);
		mainmenu.smethod_23(p15, bool_0: false);
		mainmenu.smethod_26((Control)(object)p86, Color.DimGray);
		mainmenu.smethod_21((Control)(object)p86, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p86, new Point(352, 159));
		mainmenu.smethod_27((Control)(object)p86, new Padding(0));
		mainmenu.smethod_14((Control)(object)p86, "p86");
		mainmenu.smethod_15((Control)(object)p86, new Size(70, 70));
		mainmenu.smethod_22(p86, 98);
		mainmenu.smethod_23(p86, bool_0: false);
		mainmenu.smethod_26((Control)(object)p76, Color.White);
		mainmenu.smethod_21((Control)(object)p76, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p76, new Point(282, 159));
		mainmenu.smethod_27((Control)(object)p76, new Padding(0));
		mainmenu.smethod_14((Control)(object)p76, "p76");
		mainmenu.smethod_15((Control)(object)p76, new Size(70, 70));
		mainmenu.smethod_22(p76, 97);
		mainmenu.smethod_23(p76, bool_0: false);
		mainmenu.smethod_26((Control)(object)p66, Color.DimGray);
		mainmenu.smethod_21((Control)(object)p66, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p66, new Point(212, 159));
		mainmenu.smethod_27((Control)(object)p66, new Padding(0));
		mainmenu.smethod_14((Control)(object)p66, "p66");
		mainmenu.smethod_15((Control)(object)p66, new Size(70, 70));
		mainmenu.smethod_22(p66, 96);
		mainmenu.smethod_23(p66, bool_0: false);
		mainmenu.smethod_26((Control)(object)p56, Color.White);
		mainmenu.smethod_21((Control)(object)p56, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p56, new Point(142, 159));
		mainmenu.smethod_27((Control)(object)p56, new Padding(0));
		mainmenu.smethod_14((Control)(object)p56, "p56");
		mainmenu.smethod_15((Control)(object)p56, new Size(70, 70));
		mainmenu.smethod_22(p56, 95);
		mainmenu.smethod_23(p56, bool_0: false);
		mainmenu.smethod_26((Control)(object)p46, Color.DimGray);
		mainmenu.smethod_21((Control)(object)p46, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p46, new Point(72, 159));
		mainmenu.smethod_27((Control)(object)p46, new Padding(0));
		mainmenu.smethod_14((Control)(object)p46, "p46");
		mainmenu.smethod_15((Control)(object)p46, new Size(70, 70));
		mainmenu.smethod_22(p46, 94);
		mainmenu.smethod_23(p46, bool_0: false);
		mainmenu.smethod_26((Control)(object)p36, Color.White);
		mainmenu.smethod_21((Control)(object)p36, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p36, new Point(2, 159));
		mainmenu.smethod_27((Control)(object)p36, new Padding(0));
		mainmenu.smethod_14((Control)(object)p36, "p36");
		mainmenu.smethod_15((Control)(object)p36, new Size(70, 70));
		mainmenu.smethod_22(p36, 93);
		mainmenu.smethod_23(p36, bool_0: false);
		mainmenu.smethod_26((Control)(object)p26, Color.DimGray);
		mainmenu.smethod_21((Control)(object)p26, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p26, new Point(-68, 159));
		mainmenu.smethod_27((Control)(object)p26, new Padding(0));
		mainmenu.smethod_14((Control)(object)p26, "p26");
		mainmenu.smethod_15((Control)(object)p26, new Size(70, 70));
		mainmenu.smethod_22(p26, 92);
		mainmenu.smethod_23(p26, bool_0: false);
		mainmenu.smethod_26((Control)(object)p16, Color.White);
		mainmenu.smethod_21((Control)(object)p16, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p16, new Point(-138, 159));
		mainmenu.smethod_27((Control)(object)p16, new Padding(0));
		mainmenu.smethod_14((Control)(object)p16, "p16");
		mainmenu.smethod_15((Control)(object)p16, new Size(70, 70));
		mainmenu.smethod_22(p16, 91);
		mainmenu.smethod_23(p16, bool_0: false);
		mainmenu.smethod_26((Control)(object)p87, Color.White);
		mainmenu.smethod_21((Control)(object)p87, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p87, new Point(352, 89));
		mainmenu.smethod_27((Control)(object)p87, new Padding(0));
		mainmenu.smethod_14((Control)(object)p87, "p87");
		mainmenu.smethod_15((Control)(object)p87, new Size(70, 70));
		mainmenu.smethod_22(p87, 90);
		mainmenu.smethod_23(p87, bool_0: false);
		mainmenu.smethod_26((Control)(object)p77, Color.DimGray);
		mainmenu.smethod_21((Control)(object)p77, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p77, new Point(282, 89));
		mainmenu.smethod_27((Control)(object)p77, new Padding(0));
		mainmenu.smethod_14((Control)(object)p77, "p77");
		mainmenu.smethod_15((Control)(object)p77, new Size(70, 70));
		mainmenu.smethod_22(p77, 89);
		mainmenu.smethod_23(p77, bool_0: false);
		mainmenu.smethod_26((Control)(object)p67, Color.White);
		mainmenu.smethod_21((Control)(object)p67, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p67, new Point(212, 89));
		mainmenu.smethod_27((Control)(object)p67, new Padding(0));
		mainmenu.smethod_14((Control)(object)p67, "p67");
		mainmenu.smethod_15((Control)(object)p67, new Size(70, 70));
		mainmenu.smethod_22(p67, 88);
		mainmenu.smethod_23(p67, bool_0: false);
		mainmenu.smethod_26((Control)(object)p57, Color.DimGray);
		mainmenu.smethod_21((Control)(object)p57, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p57, new Point(142, 89));
		mainmenu.smethod_27((Control)(object)p57, new Padding(0));
		mainmenu.smethod_14((Control)(object)p57, "p57");
		mainmenu.smethod_15((Control)(object)p57, new Size(70, 70));
		mainmenu.smethod_22(p57, 87);
		mainmenu.smethod_23(p57, bool_0: false);
		mainmenu.smethod_26((Control)(object)p47, Color.White);
		mainmenu.smethod_21((Control)(object)p47, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p47, new Point(72, 89));
		mainmenu.smethod_27((Control)(object)p47, new Padding(0));
		mainmenu.smethod_14((Control)(object)p47, "p47");
		mainmenu.smethod_15((Control)(object)p47, new Size(70, 70));
		mainmenu.smethod_22(p47, 86);
		mainmenu.smethod_23(p47, bool_0: false);
		mainmenu.smethod_26((Control)(object)p37, Color.DimGray);
		mainmenu.smethod_21((Control)(object)p37, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p37, new Point(2, 89));
		mainmenu.smethod_27((Control)(object)p37, new Padding(0));
		mainmenu.smethod_14((Control)(object)p37, "p37");
		mainmenu.smethod_15((Control)(object)p37, new Size(70, 70));
		mainmenu.smethod_22(p37, 85);
		mainmenu.smethod_23(p37, bool_0: false);
		mainmenu.smethod_26((Control)(object)p27, Color.White);
		mainmenu.smethod_21((Control)(object)p27, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p27, new Point(-68, 89));
		mainmenu.smethod_27((Control)(object)p27, new Padding(0));
		mainmenu.smethod_14((Control)(object)p27, "p27");
		mainmenu.smethod_15((Control)(object)p27, new Size(70, 70));
		mainmenu.smethod_22(p27, 84);
		mainmenu.smethod_23(p27, bool_0: false);
		mainmenu.smethod_26((Control)(object)p17, Color.DimGray);
		mainmenu.smethod_21((Control)(object)p17, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p17, new Point(-138, 89));
		mainmenu.smethod_27((Control)(object)p17, new Padding(0));
		mainmenu.smethod_14((Control)(object)p17, "p17");
		mainmenu.smethod_15((Control)(object)p17, new Size(70, 70));
		mainmenu.smethod_22(p17, 83);
		mainmenu.smethod_23(p17, bool_0: false);
		mainmenu.smethod_26((Control)(object)p88, Color.DimGray);
		mainmenu.smethod_21((Control)(object)p88, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p88, new Point(352, 19));
		mainmenu.smethod_27((Control)(object)p88, new Padding(0));
		mainmenu.smethod_14((Control)(object)p88, "p88");
		mainmenu.smethod_15((Control)(object)p88, new Size(70, 70));
		mainmenu.smethod_22(p88, 82);
		mainmenu.smethod_23(p88, bool_0: false);
		mainmenu.smethod_26((Control)(object)p78, Color.White);
		mainmenu.smethod_21((Control)(object)p78, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p78, new Point(282, 19));
		mainmenu.smethod_27((Control)(object)p78, new Padding(0));
		mainmenu.smethod_14((Control)(object)p78, "p78");
		mainmenu.smethod_15((Control)(object)p78, new Size(70, 70));
		mainmenu.smethod_22(p78, 81);
		mainmenu.smethod_23(p78, bool_0: false);
		mainmenu.smethod_26((Control)(object)p68, Color.DimGray);
		mainmenu.smethod_21((Control)(object)p68, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p68, new Point(212, 19));
		mainmenu.smethod_27((Control)(object)p68, new Padding(0));
		mainmenu.smethod_14((Control)(object)p68, "p68");
		mainmenu.smethod_15((Control)(object)p68, new Size(70, 70));
		mainmenu.smethod_22(p68, 80);
		mainmenu.smethod_23(p68, bool_0: false);
		mainmenu.smethod_26((Control)(object)p58, Color.White);
		mainmenu.smethod_21((Control)(object)p58, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p58, new Point(142, 19));
		mainmenu.smethod_27((Control)(object)p58, new Padding(0));
		mainmenu.smethod_14((Control)(object)p58, "p58");
		mainmenu.smethod_15((Control)(object)p58, new Size(70, 70));
		mainmenu.smethod_22(p58, 79);
		mainmenu.smethod_23(p58, bool_0: false);
		mainmenu.smethod_26((Control)(object)p48, Color.DimGray);
		mainmenu.smethod_21((Control)(object)p48, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p48, new Point(72, 19));
		mainmenu.smethod_27((Control)(object)p48, new Padding(0));
		mainmenu.smethod_14((Control)(object)p48, "p48");
		mainmenu.smethod_15((Control)(object)p48, new Size(70, 70));
		mainmenu.smethod_22(p48, 78);
		mainmenu.smethod_23(p48, bool_0: false);
		mainmenu.smethod_26((Control)(object)p38, Color.White);
		mainmenu.smethod_21((Control)(object)p38, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p38, new Point(2, 19));
		mainmenu.smethod_27((Control)(object)p38, new Padding(0));
		mainmenu.smethod_14((Control)(object)p38, "p38");
		mainmenu.smethod_15((Control)(object)p38, new Size(70, 70));
		mainmenu.smethod_22(p38, 77);
		mainmenu.smethod_23(p38, bool_0: false);
		mainmenu.smethod_26((Control)(object)p28, Color.DimGray);
		mainmenu.smethod_21((Control)(object)p28, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)p28, new Point(-68, 19));
		mainmenu.smethod_27((Control)(object)p28, new Padding(0));
		mainmenu.smethod_14((Control)(object)p28, "p28");
		mainmenu.smethod_15((Control)(object)p28, new Size(70, 70));
		mainmenu.smethod_22(p28, 76);
		mainmenu.smethod_23(p28, bool_0: false);
		mainmenu.smethod_26((Control)(object)p81, Color.White);
		mainmenu.smethod_13((Control)(object)p81, new Point(-118, 34));
		mainmenu.smethod_14((Control)(object)p81, "p81");
		mainmenu.smethod_15((Control)(object)p81, new Size(70, 70));
		mainmenu.smethod_22(p81, 75);
		mainmenu.smethod_23(p81, bool_0: false);
		mainmenu.smethod_21((Control)(object)board, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)board, new Point(-180, -23));
		mainmenu.smethod_14((Control)(object)board, "board");
		mainmenu.smethod_15((Control)(object)board, new Size(654, 647));
		mainmenu.smethod_22(board, 74);
		mainmenu.smethod_23(board, bool_0: false);
		mainmenu.smethod_20((Control)(object)label4, bool_0: true);
		mainmenu.smethod_12((Control)(object)label4, mainmenu.smethod_11("Microsoft Sans Serif", 28.25f));
		mainmenu.smethod_13((Control)(object)label4, new Point(964, 279));
		mainmenu.smethod_14((Control)(object)label4, "label4");
		mainmenu.smethod_15((Control)(object)label4, new Size(272, 44));
		mainmenu.smethod_16((Control)(object)label4, 221);
		mainmenu.smethod_17((Control)(object)label4, "Ходят - белые");
		mainmenu.smethod_20((Control)(object)label5, bool_0: true);
		mainmenu.smethod_12((Control)(object)label5, mainmenu.smethod_11("Microsoft Sans Serif", 18.25f));
		mainmenu.smethod_13((Control)(object)label5, new Point(981, 454));
		mainmenu.smethod_14((Control)(object)label5, "label5");
		mainmenu.smethod_15((Control)(object)label5, new Size(235, 29));
		mainmenu.smethod_16((Control)(object)label5, 220);
		mainmenu.smethod_17((Control)(object)label5, "выбранная фигура");
		mainmenu.smethod_21((Control)(object)pictureBox1, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox1, new Point(1033, 509));
		mainmenu.smethod_14((Control)(object)pictureBox1, "pictureBox1");
		mainmenu.smethod_15((Control)(object)pictureBox1, new Size(130, 130));
		mainmenu.smethod_22(pictureBox1, 219);
		mainmenu.smethod_23(pictureBox1, bool_0: false);
		mainmenu.smethod_20((Control)(object)label6, bool_0: true);
		mainmenu.smethod_12((Control)(object)label6, mainmenu.smethod_11("Microsoft Sans Serif", 38.25f));
		mainmenu.smethod_13((Control)(object)label6, new Point(749, 213));
		mainmenu.smethod_14((Control)(object)label6, "label6");
		mainmenu.smethod_15((Control)(object)label6, new Size(95, 59));
		mainmenu.smethod_16((Control)(object)label6, 218);
		mainmenu.smethod_17((Control)(object)label6, "0:0");
		mainmenu.smethod_24((Control)(object)label6, bool_0: false);
		mainmenu.smethod_20((Control)(object)label7, bool_0: true);
		mainmenu.smethod_12((Control)(object)label7, mainmenu.smethod_11("Microsoft Sans Serif", 38.25f));
		mainmenu.smethod_13((Control)(object)label7, new Point(749, 329));
		mainmenu.smethod_14((Control)(object)label7, "label7");
		mainmenu.smethod_15((Control)(object)label7, new Size(95, 59));
		mainmenu.smethod_16((Control)(object)label7, 217);
		mainmenu.smethod_17((Control)(object)label7, "0:0");
		mainmenu.smethod_24((Control)(object)label7, bool_0: false);
		mainmenu.smethod_26((Control)(object)button5, mainmenu.smethod_25());
		mainmenu.smethod_13((Control)(object)button5, new Point(740, 106));
		mainmenu.smethod_14((Control)(object)button5, "button5");
		mainmenu.smethod_15((Control)(object)button5, new Size(120, 78));
		mainmenu.smethod_16((Control)(object)button5, 216);
		mainmenu.smethod_18((ButtonBase)(object)button5, bool_0: false);
		mainmenu.smethod_24((Control)(object)button5, bool_0: false);
		mainmenu.smethod_26((Control)(object)button6, mainmenu.smethod_25());
		mainmenu.smethod_13((Control)(object)button6, new Point(740, 433));
		mainmenu.smethod_14((Control)(object)button6, "button6");
		mainmenu.smethod_15((Control)(object)button6, new Size(120, 78));
		mainmenu.smethod_16((Control)(object)button6, 215);
		mainmenu.smethod_18((ButtonBase)(object)button6, bool_0: false);
		mainmenu.smethod_24((Control)(object)button6, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox2, Color.White);
		mainmenu.smethod_21((Control)(object)pictureBox2, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox2, new Point(532, 268));
		mainmenu.smethod_27((Control)(object)pictureBox2, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox2, "pictureBox2");
		mainmenu.smethod_15((Control)(object)pictureBox2, new Size(70, 70));
		mainmenu.smethod_22(pictureBox2, 214);
		mainmenu.smethod_23(pictureBox2, bool_0: false);
		mainmenu.smethod_12((Control)(object)button7, mainmenu.smethod_11("Microsoft Sans Serif", 28.25f));
		mainmenu.smethod_13((Control)(object)button7, new Point(962, 0));
		mainmenu.smethod_14((Control)(object)button7, "button7");
		mainmenu.smethod_15((Control)(object)button7, new Size(188, 47));
		mainmenu.smethod_16((Control)(object)button7, 213);
		mainmenu.smethod_17((Control)(object)button7, "ВЫХОД");
		mainmenu.smethod_18((ButtonBase)(object)button7, bool_0: true);
		mainmenu.smethod_26((Control)(object)pictureBox3, Color.White);
		mainmenu.smethod_21((Control)(object)pictureBox3, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox3, new Point(532, 548));
		mainmenu.smethod_27((Control)(object)pictureBox3, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox3, "pictureBox3");
		mainmenu.smethod_15((Control)(object)pictureBox3, new Size(70, 70));
		mainmenu.smethod_22(pictureBox3, 212);
		mainmenu.smethod_23(pictureBox3, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox4, Color.DimGray);
		mainmenu.smethod_21((Control)(object)pictureBox4, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox4, new Point(462, 548));
		mainmenu.smethod_27((Control)(object)pictureBox4, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox4, "pictureBox4");
		mainmenu.smethod_15((Control)(object)pictureBox4, new Size(70, 70));
		mainmenu.smethod_22(pictureBox4, 211);
		mainmenu.smethod_23(pictureBox4, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox5, Color.White);
		mainmenu.smethod_21((Control)(object)pictureBox5, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox5, new Point(392, 548));
		mainmenu.smethod_27((Control)(object)pictureBox5, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox5, "pictureBox5");
		mainmenu.smethod_15((Control)(object)pictureBox5, new Size(70, 70));
		mainmenu.smethod_22(pictureBox5, 210);
		mainmenu.smethod_23(pictureBox5, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox6, Color.DimGray);
		mainmenu.smethod_21((Control)(object)pictureBox6, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox6, new Point(322, 548));
		mainmenu.smethod_27((Control)(object)pictureBox6, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox6, "pictureBox6");
		mainmenu.smethod_15((Control)(object)pictureBox6, new Size(70, 70));
		mainmenu.smethod_22(pictureBox6, 209);
		mainmenu.smethod_23(pictureBox6, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox7, Color.White);
		mainmenu.smethod_21((Control)(object)pictureBox7, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox7, new Point(252, 548));
		mainmenu.smethod_27((Control)(object)pictureBox7, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox7, "pictureBox7");
		mainmenu.smethod_15((Control)(object)pictureBox7, new Size(70, 70));
		mainmenu.smethod_22(pictureBox7, 208);
		mainmenu.smethod_23(pictureBox7, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox8, Color.DimGray);
		mainmenu.smethod_21((Control)(object)pictureBox8, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox8, new Point(182, 548));
		mainmenu.smethod_27((Control)(object)pictureBox8, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox8, "pictureBox8");
		mainmenu.smethod_15((Control)(object)pictureBox8, new Size(70, 70));
		mainmenu.smethod_22(pictureBox8, 207);
		mainmenu.smethod_23(pictureBox8, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox9, Color.White);
		mainmenu.smethod_21((Control)(object)pictureBox9, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox9, new Point(112, 548));
		mainmenu.smethod_27((Control)(object)pictureBox9, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox9, "pictureBox9");
		mainmenu.smethod_15((Control)(object)pictureBox9, new Size(70, 70));
		mainmenu.smethod_22(pictureBox9, 206);
		mainmenu.smethod_23(pictureBox9, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox10, Color.DimGray);
		mainmenu.smethod_21((Control)(object)pictureBox10, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox10, new Point(42, 548));
		mainmenu.smethod_27((Control)(object)pictureBox10, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox10, "pictureBox10");
		mainmenu.smethod_15((Control)(object)pictureBox10, new Size(70, 70));
		mainmenu.smethod_22(pictureBox10, 205);
		mainmenu.smethod_23(pictureBox10, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox11, Color.DimGray);
		mainmenu.smethod_21((Control)(object)pictureBox11, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox11, new Point(532, 478));
		mainmenu.smethod_27((Control)(object)pictureBox11, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox11, "pictureBox11");
		mainmenu.smethod_15((Control)(object)pictureBox11, new Size(70, 70));
		mainmenu.smethod_22(pictureBox11, 204);
		mainmenu.smethod_23(pictureBox11, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox12, Color.White);
		mainmenu.smethod_21((Control)(object)pictureBox12, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox12, new Point(462, 478));
		mainmenu.smethod_27((Control)(object)pictureBox12, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox12, "pictureBox12");
		mainmenu.smethod_15((Control)(object)pictureBox12, new Size(70, 70));
		mainmenu.smethod_22(pictureBox12, 203);
		mainmenu.smethod_23(pictureBox12, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox13, Color.DimGray);
		mainmenu.smethod_21((Control)(object)pictureBox13, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox13, new Point(392, 478));
		mainmenu.smethod_27((Control)(object)pictureBox13, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox13, "pictureBox13");
		mainmenu.smethod_15((Control)(object)pictureBox13, new Size(70, 70));
		mainmenu.smethod_22(pictureBox13, 202);
		mainmenu.smethod_23(pictureBox13, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox14, Color.White);
		mainmenu.smethod_21((Control)(object)pictureBox14, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox14, new Point(322, 478));
		mainmenu.smethod_27((Control)(object)pictureBox14, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox14, "pictureBox14");
		mainmenu.smethod_15((Control)(object)pictureBox14, new Size(70, 70));
		mainmenu.smethod_22(pictureBox14, 201);
		mainmenu.smethod_23(pictureBox14, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox15, Color.DimGray);
		mainmenu.smethod_21((Control)(object)pictureBox15, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox15, new Point(252, 478));
		mainmenu.smethod_27((Control)(object)pictureBox15, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox15, "pictureBox15");
		mainmenu.smethod_15((Control)(object)pictureBox15, new Size(70, 70));
		mainmenu.smethod_22(pictureBox15, 200);
		mainmenu.smethod_23(pictureBox15, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox16, Color.White);
		mainmenu.smethod_21((Control)(object)pictureBox16, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox16, new Point(182, 478));
		mainmenu.smethod_27((Control)(object)pictureBox16, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox16, "pictureBox16");
		mainmenu.smethod_15((Control)(object)pictureBox16, new Size(70, 70));
		mainmenu.smethod_22(pictureBox16, 199);
		mainmenu.smethod_23(pictureBox16, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox17, Color.DimGray);
		mainmenu.smethod_21((Control)(object)pictureBox17, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox17, new Point(112, 478));
		mainmenu.smethod_27((Control)(object)pictureBox17, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox17, "pictureBox17");
		mainmenu.smethod_15((Control)(object)pictureBox17, new Size(70, 70));
		mainmenu.smethod_22(pictureBox17, 198);
		mainmenu.smethod_23(pictureBox17, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox18, Color.White);
		mainmenu.smethod_21((Control)(object)pictureBox18, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox18, new Point(42, 478));
		mainmenu.smethod_27((Control)(object)pictureBox18, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox18, "pictureBox18");
		mainmenu.smethod_15((Control)(object)pictureBox18, new Size(70, 70));
		mainmenu.smethod_22(pictureBox18, 197);
		mainmenu.smethod_23(pictureBox18, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox19, Color.White);
		mainmenu.smethod_21((Control)(object)pictureBox19, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox19, new Point(532, 408));
		mainmenu.smethod_27((Control)(object)pictureBox19, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox19, "pictureBox19");
		mainmenu.smethod_15((Control)(object)pictureBox19, new Size(70, 70));
		mainmenu.smethod_22(pictureBox19, 196);
		mainmenu.smethod_23(pictureBox19, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox20, Color.DimGray);
		mainmenu.smethod_21((Control)(object)pictureBox20, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox20, new Point(462, 408));
		mainmenu.smethod_27((Control)(object)pictureBox20, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox20, "pictureBox20");
		mainmenu.smethod_15((Control)(object)pictureBox20, new Size(70, 70));
		mainmenu.smethod_22(pictureBox20, 195);
		mainmenu.smethod_23(pictureBox20, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox21, Color.White);
		mainmenu.smethod_21((Control)(object)pictureBox21, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox21, new Point(392, 408));
		mainmenu.smethod_27((Control)(object)pictureBox21, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox21, "pictureBox21");
		mainmenu.smethod_15((Control)(object)pictureBox21, new Size(70, 70));
		mainmenu.smethod_22(pictureBox21, 194);
		mainmenu.smethod_23(pictureBox21, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox22, Color.DimGray);
		mainmenu.smethod_21((Control)(object)pictureBox22, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox22, new Point(322, 408));
		mainmenu.smethod_27((Control)(object)pictureBox22, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox22, "pictureBox22");
		mainmenu.smethod_15((Control)(object)pictureBox22, new Size(70, 70));
		mainmenu.smethod_22(pictureBox22, 193);
		mainmenu.smethod_23(pictureBox22, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox23, Color.White);
		mainmenu.smethod_21((Control)(object)pictureBox23, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox23, new Point(252, 408));
		mainmenu.smethod_27((Control)(object)pictureBox23, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox23, "pictureBox23");
		mainmenu.smethod_15((Control)(object)pictureBox23, new Size(70, 70));
		mainmenu.smethod_22(pictureBox23, 192);
		mainmenu.smethod_23(pictureBox23, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox24, Color.DimGray);
		mainmenu.smethod_21((Control)(object)pictureBox24, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox24, new Point(182, 408));
		mainmenu.smethod_27((Control)(object)pictureBox24, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox24, "pictureBox24");
		mainmenu.smethod_15((Control)(object)pictureBox24, new Size(70, 70));
		mainmenu.smethod_22(pictureBox24, 191);
		mainmenu.smethod_23(pictureBox24, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox25, Color.White);
		mainmenu.smethod_21((Control)(object)pictureBox25, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox25, new Point(112, 408));
		mainmenu.smethod_27((Control)(object)pictureBox25, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox25, "pictureBox25");
		mainmenu.smethod_15((Control)(object)pictureBox25, new Size(70, 70));
		mainmenu.smethod_22(pictureBox25, 190);
		mainmenu.smethod_23(pictureBox25, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox26, Color.DimGray);
		mainmenu.smethod_21((Control)(object)pictureBox26, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox26, new Point(42, 408));
		mainmenu.smethod_27((Control)(object)pictureBox26, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox26, "pictureBox26");
		mainmenu.smethod_15((Control)(object)pictureBox26, new Size(70, 70));
		mainmenu.smethod_22(pictureBox26, 189);
		mainmenu.smethod_23(pictureBox26, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox27, Color.DimGray);
		mainmenu.smethod_21((Control)(object)pictureBox27, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox27, new Point(532, 338));
		mainmenu.smethod_27((Control)(object)pictureBox27, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox27, "pictureBox27");
		mainmenu.smethod_15((Control)(object)pictureBox27, new Size(70, 70));
		mainmenu.smethod_22(pictureBox27, 188);
		mainmenu.smethod_23(pictureBox27, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox28, Color.White);
		mainmenu.smethod_21((Control)(object)pictureBox28, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox28, new Point(462, 338));
		mainmenu.smethod_27((Control)(object)pictureBox28, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox28, "pictureBox28");
		mainmenu.smethod_15((Control)(object)pictureBox28, new Size(70, 70));
		mainmenu.smethod_22(pictureBox28, 187);
		mainmenu.smethod_23(pictureBox28, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox29, Color.DimGray);
		mainmenu.smethod_21((Control)(object)pictureBox29, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox29, new Point(392, 338));
		mainmenu.smethod_27((Control)(object)pictureBox29, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox29, "pictureBox29");
		mainmenu.smethod_15((Control)(object)pictureBox29, new Size(70, 70));
		mainmenu.smethod_22(pictureBox29, 186);
		mainmenu.smethod_23(pictureBox29, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox30, Color.White);
		mainmenu.smethod_21((Control)(object)pictureBox30, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox30, new Point(322, 338));
		mainmenu.smethod_27((Control)(object)pictureBox30, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox30, "pictureBox30");
		mainmenu.smethod_15((Control)(object)pictureBox30, new Size(70, 70));
		mainmenu.smethod_22(pictureBox30, 185);
		mainmenu.smethod_23(pictureBox30, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox31, Color.DimGray);
		mainmenu.smethod_21((Control)(object)pictureBox31, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox31, new Point(252, 338));
		mainmenu.smethod_27((Control)(object)pictureBox31, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox31, "pictureBox31");
		mainmenu.smethod_15((Control)(object)pictureBox31, new Size(70, 70));
		mainmenu.smethod_22(pictureBox31, 184);
		mainmenu.smethod_23(pictureBox31, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox32, Color.White);
		mainmenu.smethod_21((Control)(object)pictureBox32, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox32, new Point(182, 338));
		mainmenu.smethod_27((Control)(object)pictureBox32, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox32, "pictureBox32");
		mainmenu.smethod_15((Control)(object)pictureBox32, new Size(70, 70));
		mainmenu.smethod_22(pictureBox32, 183);
		mainmenu.smethod_23(pictureBox32, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox33, Color.DimGray);
		mainmenu.smethod_21((Control)(object)pictureBox33, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox33, new Point(112, 338));
		mainmenu.smethod_27((Control)(object)pictureBox33, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox33, "pictureBox33");
		mainmenu.smethod_15((Control)(object)pictureBox33, new Size(70, 70));
		mainmenu.smethod_22(pictureBox33, 182);
		mainmenu.smethod_23(pictureBox33, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox34, Color.White);
		mainmenu.smethod_21((Control)(object)pictureBox34, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox34, new Point(42, 338));
		mainmenu.smethod_27((Control)(object)pictureBox34, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox34, "pictureBox34");
		mainmenu.smethod_15((Control)(object)pictureBox34, new Size(70, 70));
		mainmenu.smethod_22(pictureBox34, 181);
		mainmenu.smethod_23(pictureBox34, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox35, Color.White);
		mainmenu.smethod_21((Control)(object)pictureBox35, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox35, new Point(42, 58));
		mainmenu.smethod_27((Control)(object)pictureBox35, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox35, "pictureBox35");
		mainmenu.smethod_15((Control)(object)pictureBox35, new Size(70, 70));
		mainmenu.smethod_22(pictureBox35, 180);
		mainmenu.smethod_23(pictureBox35, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox36, Color.DimGray);
		mainmenu.smethod_21((Control)(object)pictureBox36, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox36, new Point(462, 268));
		mainmenu.smethod_27((Control)(object)pictureBox36, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox36, "pictureBox36");
		mainmenu.smethod_15((Control)(object)pictureBox36, new Size(70, 70));
		mainmenu.smethod_22(pictureBox36, 179);
		mainmenu.smethod_23(pictureBox36, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox37, Color.White);
		mainmenu.smethod_21((Control)(object)pictureBox37, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox37, new Point(392, 268));
		mainmenu.smethod_27((Control)(object)pictureBox37, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox37, "pictureBox37");
		mainmenu.smethod_15((Control)(object)pictureBox37, new Size(70, 70));
		mainmenu.smethod_22(pictureBox37, 178);
		mainmenu.smethod_23(pictureBox37, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox38, Color.DimGray);
		mainmenu.smethod_21((Control)(object)pictureBox38, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox38, new Point(322, 268));
		mainmenu.smethod_27((Control)(object)pictureBox38, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox38, "pictureBox38");
		mainmenu.smethod_15((Control)(object)pictureBox38, new Size(70, 70));
		mainmenu.smethod_22(pictureBox38, 177);
		mainmenu.smethod_23(pictureBox38, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox39, Color.White);
		mainmenu.smethod_21((Control)(object)pictureBox39, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox39, new Point(252, 268));
		mainmenu.smethod_27((Control)(object)pictureBox39, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox39, "pictureBox39");
		mainmenu.smethod_15((Control)(object)pictureBox39, new Size(70, 70));
		mainmenu.smethod_22(pictureBox39, 176);
		mainmenu.smethod_23(pictureBox39, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox40, Color.DimGray);
		mainmenu.smethod_21((Control)(object)pictureBox40, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox40, new Point(182, 268));
		mainmenu.smethod_27((Control)(object)pictureBox40, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox40, "pictureBox40");
		mainmenu.smethod_15((Control)(object)pictureBox40, new Size(70, 70));
		mainmenu.smethod_22(pictureBox40, 175);
		mainmenu.smethod_23(pictureBox40, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox41, Color.White);
		mainmenu.smethod_21((Control)(object)pictureBox41, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox41, new Point(112, 268));
		mainmenu.smethod_27((Control)(object)pictureBox41, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox41, "pictureBox41");
		mainmenu.smethod_15((Control)(object)pictureBox41, new Size(70, 70));
		mainmenu.smethod_22(pictureBox41, 174);
		mainmenu.smethod_23(pictureBox41, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox42, Color.DimGray);
		mainmenu.smethod_21((Control)(object)pictureBox42, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox42, new Point(42, 268));
		mainmenu.smethod_27((Control)(object)pictureBox42, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox42, "pictureBox42");
		mainmenu.smethod_15((Control)(object)pictureBox42, new Size(70, 70));
		mainmenu.smethod_22(pictureBox42, 173);
		mainmenu.smethod_23(pictureBox42, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox43, Color.DimGray);
		mainmenu.smethod_21((Control)(object)pictureBox43, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox43, new Point(532, 198));
		mainmenu.smethod_27((Control)(object)pictureBox43, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox43, "pictureBox43");
		mainmenu.smethod_15((Control)(object)pictureBox43, new Size(70, 70));
		mainmenu.smethod_22(pictureBox43, 172);
		mainmenu.smethod_23(pictureBox43, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox44, Color.White);
		mainmenu.smethod_21((Control)(object)pictureBox44, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox44, new Point(462, 198));
		mainmenu.smethod_27((Control)(object)pictureBox44, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox44, "pictureBox44");
		mainmenu.smethod_15((Control)(object)pictureBox44, new Size(70, 70));
		mainmenu.smethod_22(pictureBox44, 171);
		mainmenu.smethod_23(pictureBox44, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox45, Color.DimGray);
		mainmenu.smethod_21((Control)(object)pictureBox45, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox45, new Point(392, 198));
		mainmenu.smethod_27((Control)(object)pictureBox45, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox45, "pictureBox45");
		mainmenu.smethod_15((Control)(object)pictureBox45, new Size(70, 70));
		mainmenu.smethod_22(pictureBox45, 170);
		mainmenu.smethod_23(pictureBox45, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox46, Color.White);
		mainmenu.smethod_21((Control)(object)pictureBox46, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox46, new Point(322, 198));
		mainmenu.smethod_27((Control)(object)pictureBox46, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox46, "pictureBox46");
		mainmenu.smethod_15((Control)(object)pictureBox46, new Size(70, 70));
		mainmenu.smethod_22(pictureBox46, 169);
		mainmenu.smethod_23(pictureBox46, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox47, Color.DimGray);
		mainmenu.smethod_21((Control)(object)pictureBox47, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox47, new Point(252, 198));
		mainmenu.smethod_27((Control)(object)pictureBox47, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox47, "pictureBox47");
		mainmenu.smethod_15((Control)(object)pictureBox47, new Size(70, 70));
		mainmenu.smethod_22(pictureBox47, 168);
		mainmenu.smethod_23(pictureBox47, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox48, Color.White);
		mainmenu.smethod_21((Control)(object)pictureBox48, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox48, new Point(182, 198));
		mainmenu.smethod_27((Control)(object)pictureBox48, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox48, "pictureBox48");
		mainmenu.smethod_15((Control)(object)pictureBox48, new Size(70, 70));
		mainmenu.smethod_22(pictureBox48, 167);
		mainmenu.smethod_23(pictureBox48, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox49, Color.DimGray);
		mainmenu.smethod_21((Control)(object)pictureBox49, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox49, new Point(112, 198));
		mainmenu.smethod_27((Control)(object)pictureBox49, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox49, "pictureBox49");
		mainmenu.smethod_15((Control)(object)pictureBox49, new Size(70, 70));
		mainmenu.smethod_22(pictureBox49, 166);
		mainmenu.smethod_23(pictureBox49, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox50, Color.White);
		mainmenu.smethod_21((Control)(object)pictureBox50, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox50, new Point(42, 198));
		mainmenu.smethod_27((Control)(object)pictureBox50, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox50, "pictureBox50");
		mainmenu.smethod_15((Control)(object)pictureBox50, new Size(70, 70));
		mainmenu.smethod_22(pictureBox50, 165);
		mainmenu.smethod_23(pictureBox50, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox51, Color.White);
		mainmenu.smethod_21((Control)(object)pictureBox51, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox51, new Point(532, 128));
		mainmenu.smethod_27((Control)(object)pictureBox51, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox51, "pictureBox51");
		mainmenu.smethod_15((Control)(object)pictureBox51, new Size(70, 70));
		mainmenu.smethod_22(pictureBox51, 164);
		mainmenu.smethod_23(pictureBox51, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox52, Color.DimGray);
		mainmenu.smethod_21((Control)(object)pictureBox52, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox52, new Point(462, 128));
		mainmenu.smethod_27((Control)(object)pictureBox52, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox52, "pictureBox52");
		mainmenu.smethod_15((Control)(object)pictureBox52, new Size(70, 70));
		mainmenu.smethod_22(pictureBox52, 163);
		mainmenu.smethod_23(pictureBox52, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox53, Color.White);
		mainmenu.smethod_21((Control)(object)pictureBox53, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox53, new Point(392, 128));
		mainmenu.smethod_27((Control)(object)pictureBox53, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox53, "pictureBox53");
		mainmenu.smethod_15((Control)(object)pictureBox53, new Size(70, 70));
		mainmenu.smethod_22(pictureBox53, 162);
		mainmenu.smethod_23(pictureBox53, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox54, Color.DimGray);
		mainmenu.smethod_21((Control)(object)pictureBox54, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox54, new Point(322, 128));
		mainmenu.smethod_27((Control)(object)pictureBox54, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox54, "pictureBox54");
		mainmenu.smethod_15((Control)(object)pictureBox54, new Size(70, 70));
		mainmenu.smethod_22(pictureBox54, 161);
		mainmenu.smethod_23(pictureBox54, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox55, Color.White);
		mainmenu.smethod_21((Control)(object)pictureBox55, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox55, new Point(252, 128));
		mainmenu.smethod_27((Control)(object)pictureBox55, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox55, "pictureBox55");
		mainmenu.smethod_15((Control)(object)pictureBox55, new Size(70, 70));
		mainmenu.smethod_22(pictureBox55, 160);
		mainmenu.smethod_23(pictureBox55, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox56, Color.DimGray);
		mainmenu.smethod_21((Control)(object)pictureBox56, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox56, new Point(182, 128));
		mainmenu.smethod_27((Control)(object)pictureBox56, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox56, "pictureBox56");
		mainmenu.smethod_15((Control)(object)pictureBox56, new Size(70, 70));
		mainmenu.smethod_22(pictureBox56, 159);
		mainmenu.smethod_23(pictureBox56, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox57, Color.White);
		mainmenu.smethod_21((Control)(object)pictureBox57, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox57, new Point(112, 128));
		mainmenu.smethod_27((Control)(object)pictureBox57, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox57, "pictureBox57");
		mainmenu.smethod_15((Control)(object)pictureBox57, new Size(70, 70));
		mainmenu.smethod_22(pictureBox57, 158);
		mainmenu.smethod_23(pictureBox57, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox58, Color.DimGray);
		mainmenu.smethod_21((Control)(object)pictureBox58, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox58, new Point(42, 128));
		mainmenu.smethod_27((Control)(object)pictureBox58, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox58, "pictureBox58");
		mainmenu.smethod_15((Control)(object)pictureBox58, new Size(70, 70));
		mainmenu.smethod_22(pictureBox58, 157);
		mainmenu.smethod_23(pictureBox58, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox59, Color.DimGray);
		mainmenu.smethod_21((Control)(object)pictureBox59, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox59, new Point(532, 58));
		mainmenu.smethod_27((Control)(object)pictureBox59, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox59, "pictureBox59");
		mainmenu.smethod_15((Control)(object)pictureBox59, new Size(70, 70));
		mainmenu.smethod_22(pictureBox59, 156);
		mainmenu.smethod_23(pictureBox59, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox60, Color.White);
		mainmenu.smethod_21((Control)(object)pictureBox60, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox60, new Point(462, 58));
		mainmenu.smethod_27((Control)(object)pictureBox60, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox60, "pictureBox60");
		mainmenu.smethod_15((Control)(object)pictureBox60, new Size(70, 70));
		mainmenu.smethod_22(pictureBox60, 155);
		mainmenu.smethod_23(pictureBox60, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox61, Color.DimGray);
		mainmenu.smethod_21((Control)(object)pictureBox61, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox61, new Point(392, 58));
		mainmenu.smethod_27((Control)(object)pictureBox61, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox61, "pictureBox61");
		mainmenu.smethod_15((Control)(object)pictureBox61, new Size(70, 70));
		mainmenu.smethod_22(pictureBox61, 154);
		mainmenu.smethod_23(pictureBox61, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox62, Color.White);
		mainmenu.smethod_21((Control)(object)pictureBox62, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox62, new Point(322, 58));
		mainmenu.smethod_27((Control)(object)pictureBox62, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox62, "pictureBox62");
		mainmenu.smethod_15((Control)(object)pictureBox62, new Size(70, 70));
		mainmenu.smethod_22(pictureBox62, 153);
		mainmenu.smethod_23(pictureBox62, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox63, Color.DimGray);
		mainmenu.smethod_21((Control)(object)pictureBox63, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox63, new Point(252, 58));
		mainmenu.smethod_27((Control)(object)pictureBox63, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox63, "pictureBox63");
		mainmenu.smethod_15((Control)(object)pictureBox63, new Size(70, 70));
		mainmenu.smethod_22(pictureBox63, 152);
		mainmenu.smethod_23(pictureBox63, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox64, Color.White);
		mainmenu.smethod_21((Control)(object)pictureBox64, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox64, new Point(182, 58));
		mainmenu.smethod_27((Control)(object)pictureBox64, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox64, "pictureBox64");
		mainmenu.smethod_15((Control)(object)pictureBox64, new Size(70, 70));
		mainmenu.smethod_22(pictureBox64, 151);
		mainmenu.smethod_23(pictureBox64, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox65, Color.DimGray);
		mainmenu.smethod_21((Control)(object)pictureBox65, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox65, new Point(112, 58));
		mainmenu.smethod_27((Control)(object)pictureBox65, new Padding(0));
		mainmenu.smethod_14((Control)(object)pictureBox65, "pictureBox65");
		mainmenu.smethod_15((Control)(object)pictureBox65, new Size(70, 70));
		mainmenu.smethod_22(pictureBox65, 150);
		mainmenu.smethod_23(pictureBox65, bool_0: false);
		mainmenu.smethod_26((Control)(object)pictureBox66, Color.White);
		mainmenu.smethod_13((Control)(object)pictureBox66, new Point(62, 73));
		mainmenu.smethod_14((Control)(object)pictureBox66, "pictureBox66");
		mainmenu.smethod_15((Control)(object)pictureBox66, new Size(70, 70));
		mainmenu.smethod_22(pictureBox66, 149);
		mainmenu.smethod_23(pictureBox66, bool_0: false);
		mainmenu.smethod_21((Control)(object)pictureBox67, (ImageLayout)4);
		mainmenu.smethod_13((Control)(object)pictureBox67, new Point(0, 16));
		mainmenu.smethod_14((Control)(object)pictureBox67, "pictureBox67");
		mainmenu.smethod_15((Control)(object)pictureBox67, new Size(654, 647));
		mainmenu.smethod_22(pictureBox67, 148);
		mainmenu.smethod_23(pictureBox67, bool_0: false);
		mainmenu.smethod_28((ContainerControl)(object)this, new SizeF(6f, 13f));
		mainmenu.smethod_29((ContainerControl)(object)this, (AutoScaleMode)1);
		mainmenu.smethod_21((Control)(object)this, (ImageLayout)4);
		mainmenu.smethod_30((Form)(object)this, new Size(876, 584));
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)label4);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)label5);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox1);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)label6);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)label7);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)button5);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)button6);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox2);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)button7);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox3);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox4);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox5);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox6);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox7);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox8);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox9);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox10);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox11);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox12);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox13);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox14);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox15);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox16);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox17);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox18);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox19);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox20);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox21);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox22);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox23);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox24);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox25);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox26);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox27);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox28);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox29);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox30);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox31);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox32);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox33);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox34);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox35);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox36);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox37);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox38);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox39);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox40);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox41);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox42);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox43);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox44);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox45);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox46);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox47);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox48);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox49);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox50);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox51);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox52);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox53);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox54);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox55);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox56);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox57);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox58);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox59);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox60);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox61);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox62);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox63);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox64);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox65);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox66);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)pictureBox67);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)chey_hod);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)label3);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)selected);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)label2);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)label1);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)button3);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)button4);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p85);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)exit);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p_81);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p71);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p61);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p51);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p41);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p31);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p21);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p11);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p82);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p72);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p62);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p52);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p42);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p32);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p22);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p12);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p83);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p73);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p63);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p53);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p43);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p33);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p23);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p13);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p84);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p74);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p64);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p54);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p44);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p34);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p24);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p14);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p18);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p75);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p65);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p55);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p45);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p35);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p25);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p15);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p86);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p76);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p66);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p56);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p46);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p36);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p26);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p16);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p87);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p77);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p67);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p57);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p47);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p37);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p27);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p17);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p88);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p78);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p68);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p58);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p48);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p38);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p28);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)p81);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)board);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)button2);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)button1);
		mainmenu.smethod_32(mainmenu.smethod_31((Control)(object)this), (Control)(object)game);
		mainmenu.smethod_33((Control)(object)this, "mainmenu");
		mainmenu.smethod_34((Form)(object)this, (FormStartPosition)1);
		mainmenu.smethod_17((Control)(object)this, "MainMenu");
		mainmenu.smethod_35((ISupportInitialize)selected);
		mainmenu.smethod_35((ISupportInitialize)p85);
		mainmenu.smethod_35((ISupportInitialize)p_81);
		mainmenu.smethod_35((ISupportInitialize)p71);
		mainmenu.smethod_35((ISupportInitialize)p61);
		mainmenu.smethod_35((ISupportInitialize)p51);
		mainmenu.smethod_35((ISupportInitialize)p41);
		mainmenu.smethod_35((ISupportInitialize)p31);
		mainmenu.smethod_35((ISupportInitialize)p21);
		mainmenu.smethod_35((ISupportInitialize)p11);
		mainmenu.smethod_35((ISupportInitialize)p82);
		mainmenu.smethod_35((ISupportInitialize)p72);
		mainmenu.smethod_35((ISupportInitialize)p62);
		mainmenu.smethod_35((ISupportInitialize)p52);
		mainmenu.smethod_35((ISupportInitialize)p42);
		mainmenu.smethod_35((ISupportInitialize)p32);
		mainmenu.smethod_35((ISupportInitialize)p22);
		mainmenu.smethod_35((ISupportInitialize)p12);
		mainmenu.smethod_35((ISupportInitialize)p83);
		mainmenu.smethod_35((ISupportInitialize)p73);
		mainmenu.smethod_35((ISupportInitialize)p63);
		mainmenu.smethod_35((ISupportInitialize)p53);
		mainmenu.smethod_35((ISupportInitialize)p43);
		mainmenu.smethod_35((ISupportInitialize)p33);
		mainmenu.smethod_35((ISupportInitialize)p23);
		mainmenu.smethod_35((ISupportInitialize)p13);
		mainmenu.smethod_35((ISupportInitialize)p84);
		mainmenu.smethod_35((ISupportInitialize)p74);
		mainmenu.smethod_35((ISupportInitialize)p64);
		mainmenu.smethod_35((ISupportInitialize)p54);
		mainmenu.smethod_35((ISupportInitialize)p44);
		mainmenu.smethod_35((ISupportInitialize)p34);
		mainmenu.smethod_35((ISupportInitialize)p24);
		mainmenu.smethod_35((ISupportInitialize)p14);
		mainmenu.smethod_35((ISupportInitialize)p18);
		mainmenu.smethod_35((ISupportInitialize)p75);
		mainmenu.smethod_35((ISupportInitialize)p65);
		mainmenu.smethod_35((ISupportInitialize)p55);
		mainmenu.smethod_35((ISupportInitialize)p45);
		mainmenu.smethod_35((ISupportInitialize)p35);
		mainmenu.smethod_35((ISupportInitialize)p25);
		mainmenu.smethod_35((ISupportInitialize)p15);
		mainmenu.smethod_35((ISupportInitialize)p86);
		mainmenu.smethod_35((ISupportInitialize)p76);
		mainmenu.smethod_35((ISupportInitialize)p66);
		mainmenu.smethod_35((ISupportInitialize)p56);
		mainmenu.smethod_35((ISupportInitialize)p46);
		mainmenu.smethod_35((ISupportInitialize)p36);
		mainmenu.smethod_35((ISupportInitialize)p26);
		mainmenu.smethod_35((ISupportInitialize)p16);
		mainmenu.smethod_35((ISupportInitialize)p87);
		mainmenu.smethod_35((ISupportInitialize)p77);
		mainmenu.smethod_35((ISupportInitialize)p67);
		mainmenu.smethod_35((ISupportInitialize)p57);
		mainmenu.smethod_35((ISupportInitialize)p47);
		mainmenu.smethod_35((ISupportInitialize)p37);
		mainmenu.smethod_35((ISupportInitialize)p27);
		mainmenu.smethod_35((ISupportInitialize)p17);
		mainmenu.smethod_35((ISupportInitialize)p88);
		mainmenu.smethod_35((ISupportInitialize)p78);
		mainmenu.smethod_35((ISupportInitialize)p68);
		mainmenu.smethod_35((ISupportInitialize)p58);
		mainmenu.smethod_35((ISupportInitialize)p48);
		mainmenu.smethod_35((ISupportInitialize)p38);
		mainmenu.smethod_35((ISupportInitialize)p28);
		mainmenu.smethod_35((ISupportInitialize)p81);
		mainmenu.smethod_35((ISupportInitialize)board);
		mainmenu.smethod_35((ISupportInitialize)pictureBox1);
		mainmenu.smethod_35((ISupportInitialize)pictureBox2);
		mainmenu.smethod_35((ISupportInitialize)pictureBox3);
		mainmenu.smethod_35((ISupportInitialize)pictureBox4);
		mainmenu.smethod_35((ISupportInitialize)pictureBox5);
		mainmenu.smethod_35((ISupportInitialize)pictureBox6);
		mainmenu.smethod_35((ISupportInitialize)pictureBox7);
		mainmenu.smethod_35((ISupportInitialize)pictureBox8);
		mainmenu.smethod_35((ISupportInitialize)pictureBox9);
		mainmenu.smethod_35((ISupportInitialize)pictureBox10);
		mainmenu.smethod_35((ISupportInitialize)pictureBox11);
		mainmenu.smethod_35((ISupportInitialize)pictureBox12);
		mainmenu.smethod_35((ISupportInitialize)pictureBox13);
		mainmenu.smethod_35((ISupportInitialize)pictureBox14);
		mainmenu.smethod_35((ISupportInitialize)pictureBox15);
		mainmenu.smethod_35((ISupportInitialize)pictureBox16);
		mainmenu.smethod_35((ISupportInitialize)pictureBox17);
		mainmenu.smethod_35((ISupportInitialize)pictureBox18);
		mainmenu.smethod_35((ISupportInitialize)pictureBox19);
		mainmenu.smethod_35((ISupportInitialize)pictureBox20);
		mainmenu.smethod_35((ISupportInitialize)pictureBox21);
		mainmenu.smethod_35((ISupportInitialize)pictureBox22);
		mainmenu.smethod_35((ISupportInitialize)pictureBox23);
		mainmenu.smethod_35((ISupportInitialize)pictureBox24);
		mainmenu.smethod_35((ISupportInitialize)pictureBox25);
		mainmenu.smethod_35((ISupportInitialize)pictureBox26);
		mainmenu.smethod_35((ISupportInitialize)pictureBox27);
		mainmenu.smethod_35((ISupportInitialize)pictureBox28);
		mainmenu.smethod_35((ISupportInitialize)pictureBox29);
		mainmenu.smethod_35((ISupportInitialize)pictureBox30);
		mainmenu.smethod_35((ISupportInitialize)pictureBox31);
		mainmenu.smethod_35((ISupportInitialize)pictureBox32);
		mainmenu.smethod_35((ISupportInitialize)pictureBox33);
		mainmenu.smethod_35((ISupportInitialize)pictureBox34);
		mainmenu.smethod_35((ISupportInitialize)pictureBox35);
		mainmenu.smethod_35((ISupportInitialize)pictureBox36);
		mainmenu.smethod_35((ISupportInitialize)pictureBox37);
		mainmenu.smethod_35((ISupportInitialize)pictureBox38);
		mainmenu.smethod_35((ISupportInitialize)pictureBox39);
		mainmenu.smethod_35((ISupportInitialize)pictureBox40);
		mainmenu.smethod_35((ISupportInitialize)pictureBox41);
		mainmenu.smethod_35((ISupportInitialize)pictureBox42);
		mainmenu.smethod_35((ISupportInitialize)pictureBox43);
		mainmenu.smethod_35((ISupportInitialize)pictureBox44);
		mainmenu.smethod_35((ISupportInitialize)pictureBox45);
		mainmenu.smethod_35((ISupportInitialize)pictureBox46);
		mainmenu.smethod_35((ISupportInitialize)pictureBox47);
		mainmenu.smethod_35((ISupportInitialize)pictureBox48);
		mainmenu.smethod_35((ISupportInitialize)pictureBox49);
		mainmenu.smethod_35((ISupportInitialize)pictureBox50);
		mainmenu.smethod_35((ISupportInitialize)pictureBox51);
		mainmenu.smethod_35((ISupportInitialize)pictureBox52);
		mainmenu.smethod_35((ISupportInitialize)pictureBox53);
		mainmenu.smethod_35((ISupportInitialize)pictureBox54);
		mainmenu.smethod_35((ISupportInitialize)pictureBox55);
		mainmenu.smethod_35((ISupportInitialize)pictureBox56);
		mainmenu.smethod_35((ISupportInitialize)pictureBox57);
		mainmenu.smethod_35((ISupportInitialize)pictureBox58);
		mainmenu.smethod_35((ISupportInitialize)pictureBox59);
		mainmenu.smethod_35((ISupportInitialize)pictureBox60);
		mainmenu.smethod_35((ISupportInitialize)pictureBox61);
		mainmenu.smethod_35((ISupportInitialize)pictureBox62);
		mainmenu.smethod_35((ISupportInitialize)pictureBox63);
		mainmenu.smethod_35((ISupportInitialize)pictureBox64);
		mainmenu.smethod_35((ISupportInitialize)pictureBox65);
		mainmenu.smethod_35((ISupportInitialize)pictureBox66);
		mainmenu.smethod_35((ISupportInitialize)pictureBox67);
		mainmenu.smethod_36((Control)(object)this, bool_0: false);
		mainmenu.smethod_37((Control)(object)this);
	}

	static void smethod_0(Control control_0)
	{
		control_0.Show();
	}

	static void smethod_1(Control control_0, bool bool_0)
	{
		control_0.set_Visible(bool_0);
	}

	static void smethod_2()
	{
		Application.Exit();
	}

	static void smethod_3(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Container smethod_4()
	{
		return new Container();
	}

	static Button smethod_5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Button();
	}

	static Label smethod_6()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Label();
	}

	static PictureBox smethod_7()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new PictureBox();
	}

	static Timer smethod_8(IContainer icontainer_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new Timer(icontainer_0);
	}

	static void smethod_9(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.BeginInit();
	}

	static void smethod_10(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static Font smethod_11(string string_0, float float_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new Font(string_0, float_0);
	}

	static void smethod_12(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static void smethod_13(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_14(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_15(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_16(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static void smethod_17(Control control_0, string string_0)
	{
		control_0.set_Text(string_0);
	}

	static void smethod_18(ButtonBase buttonBase_0, bool bool_0)
	{
		buttonBase_0.set_UseVisualStyleBackColor(bool_0);
	}

	static void smethod_19(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_Click(eventHandler_0);
	}

	static void smethod_20(Control control_0, bool bool_0)
	{
		control_0.set_AutoSize(bool_0);
	}

	static void smethod_21(Control control_0, ImageLayout imageLayout_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_BackgroundImageLayout(imageLayout_0);
	}

	static void smethod_22(PictureBox pictureBox_0, int int_0)
	{
		pictureBox_0.set_TabIndex(int_0);
	}

	static void smethod_23(PictureBox pictureBox_0, bool bool_0)
	{
		pictureBox_0.set_TabStop(bool_0);
	}

	static void smethod_24(Control control_0, bool bool_0)
	{
		control_0.set_Visible(bool_0);
	}

	static Color smethod_25()
	{
		return SystemColors.ActiveCaptionText;
	}

	static void smethod_26(Control control_0, Color color_0)
	{
		control_0.set_BackColor(color_0);
	}

	static void smethod_27(Control control_0, Padding padding_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_Margin(padding_0);
	}

	static void smethod_28(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_29(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_30(Form form_0, Size size_0)
	{
		form_0.set_ClientSize(size_0);
	}

	static ControlCollection smethod_31(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_32(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_33(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_34(Form form_0, FormStartPosition formStartPosition_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_StartPosition(formStartPosition_0);
	}

	static void smethod_35(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.EndInit();
	}

	static void smethod_36(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_37(Control control_0)
	{
		control_0.PerformLayout();
	}
}
