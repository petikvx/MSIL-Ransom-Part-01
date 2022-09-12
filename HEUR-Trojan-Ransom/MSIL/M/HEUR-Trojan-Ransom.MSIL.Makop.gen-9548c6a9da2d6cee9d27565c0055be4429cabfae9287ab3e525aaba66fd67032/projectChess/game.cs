using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace projectChess;

public class game : Form
{
	public static bool select = false;

	public static bool go = false;

	public static PictureBox copy = game.smethod_23();

	public static PictureBox copy2 = game.smethod_23();

	public static string color1;

	public static string color2;

	public static int min1 = settings.time;

	public static int min2 = settings.time;

	public static int sec1 = 0;

	public static int sec2 = 0;

	public static int x1;

	public static int y1;

	public static int x2;

	public static int y2;

	public static int hod = 1;

	public static int square1;

	public static int square2;

	public static int[,] table;

	private IContainer components = null;

	private PictureBox board;

	private Timer timer1;

	private Timer timer2;

	private PictureBox p81;

	private PictureBox p28;

	private PictureBox p48;

	private PictureBox p38;

	private PictureBox p68;

	private PictureBox p58;

	private PictureBox p88;

	private PictureBox p78;

	private PictureBox p17;

	private PictureBox p27;

	private PictureBox p47;

	private PictureBox p37;

	private PictureBox p87;

	private PictureBox p77;

	private PictureBox p67;

	private PictureBox p57;

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

	private PictureBox p34;

	private PictureBox p24;

	private PictureBox p14;

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

	private Button exit;

	private PictureBox p85;

	private Button button1;

	private Button button2;

	private Label label1;

	private Label label2;

	private PictureBox selected;

	private Label label3;

	private Label chey_hod;

	private Label label4;

	private Label label5;

	private PictureBox pictureBox1;

	private Label label6;

	private Label label7;

	private Button button3;

	private Button button4;

	private PictureBox pictureBox2;

	private Button button5;

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

	public game()
	{
		InitializeComponent();
	}

	private void game_Load(object sender, EventArgs e)
	{
		int[,] array_ = new int[8, 8];
		game.smethod_0((Array)array_, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		table = array_;
		if (settings.timer)
		{
			game.smethod_1((Control)(object)label1, bool_0: true);
			game.smethod_1((Control)(object)label2, bool_0: true);
			game.smethod_3((Control)(object)label1, game.smethod_2(settings.time.ToString(), ":00"));
			game.smethod_3((Control)(object)label2, game.smethod_2(settings.time.ToString(), ":00"));
			game.smethod_1((Control)(object)button1, bool_0: true);
			game.smethod_1((Control)(object)button2, bool_0: true);
			game.smethod_4((Control)(object)button2, bool_0: false);
			game.smethod_5((Control)(object)button2, Color.Gray);
			game.smethod_6(timer1, bool_0: true);
			game.smethod_6(timer2, bool_0: false);
			game.smethod_7(timer1, 1000);
			game.smethod_7(timer2, 1000);
		}
	}

	private static void win()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		if (square2 == 16)
		{
			game.smethod_8("Черные победили!", "Черные победили!", (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0, (MessageBoxOptions)131072);
			game.smethod_9();
		}
		if (square2 == 6)
		{
			game.smethod_8("Белые победили!", "Белые победили!", (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0, (MessageBoxOptions)131072);
			game.smethod_9();
		}
	}

	private static void img(int sq)
	{
		if (sq / 10 != 1)
		{
		}
	}

	private static void piece(int sq, int x1, int y1, int x2, int y2)
	{
		if (x1 != x2 || y1 != y2)
		{
			if (sq % 10 != 1)
			{
				if (sq % 10 != 2)
				{
					if (sq % 10 == 3)
					{
						knight(x1, y1, x2, y2);
					}
					else if (sq % 10 != 4)
					{
						if (sq % 10 != 5)
						{
							if (sq % 10 == 6)
							{
								king(x1, y1, x2, y2);
							}
						}
						else
						{
							queen(x1, y1, x2, y2);
						}
					}
					else
					{
						bishop(x1, y1, x2, y2);
					}
				}
				else
				{
					rook(x1, y1, x2, y2);
				}
			}
			else
			{
				pawn(sq, x1, y1, x2, y2);
			}
		}
		else
		{
			go = true;
		}
	}

	private static void pawn(int sq, int x1, int y1, int x2, int y2)
	{
		if (sq / 10 != 1)
		{
			if (y1 != y2 || x1 != x2)
			{
				if (y1 == y2 && x1 == 2 && x2 == 4 && square2 == 0)
				{
					go = true;
				}
				else if (y1 == y2 && x2 == x1 + 1 && square2 == 0)
				{
					go = true;
				}
				else if (x2 == x1 + 1 && (y2 == y1 + 1 || y2 == y1 - 1) && square2 != 0)
				{
					go = true;
				}
				else
				{
					go = false;
				}
			}
			else
			{
				go = true;
			}
		}
		else if (y1 == y2 && x1 == x2)
		{
			go = true;
		}
		else if (y1 != y2 || x1 != 7 || x2 != 5 || square2 != 0)
		{
			if (y1 != y2 || x2 != x1 - 1 || square2 != 0)
			{
				if (x2 != x1 - 1 || (y2 != y1 - 1 && y2 != y1 + 1) || square2 == 0)
				{
					go = false;
				}
				else
				{
					go = true;
				}
			}
			else
			{
				go = true;
			}
		}
		else
		{
			go = true;
		}
	}

	private static void rook(int x1, int y1, int x2, int y2)
	{
		if (x1 != x2 && y1 != y2)
		{
			go = false;
		}
		else
		{
			go = true;
		}
	}

	private static void king(int x1, int y1, int x2, int y2)
	{
		if (game.smethod_10(x1 - x2) > 1 || game.smethod_10(y1 - y2) > 1)
		{
			go = false;
		}
		else
		{
			go = true;
		}
	}

	private static void knight(int x1, int y1, int x2, int y2)
	{
		int num = game.smethod_10(x1 - x2);
		int num2 = game.smethod_10(y1 - y2);
		if ((num == 1 && num2 == 2) || (num == 2 && num2 == 1))
		{
			go = true;
		}
		else
		{
			go = false;
		}
	}

	private static void bishop(int x1, int y1, int x2, int y2)
	{
		if (game.smethod_10(x1 - x2) == game.smethod_10(y1 - y2))
		{
			go = true;
		}
		else
		{
			go = false;
		}
	}

	private static void queen(int x1, int y1, int x2, int y2)
	{
		if (game.smethod_10(x1 - x2) != game.smethod_10(y1 - y2) && x1 != x2 && y1 != y2)
		{
			go = false;
		}
		else
		{
			go = true;
		}
	}

	private static void color(int sq)
	{
		if (sq == square1)
		{
			if (square1 / 10 != 1)
			{
				if (square1 != 0)
				{
					color1 = "B";
				}
				else
				{
					color1 = "null";
				}
			}
			else
			{
				color1 = "W";
			}
		}
		else if (square2 / 10 == 1)
		{
			color2 = "W";
		}
		else if (square2 != 0)
		{
			color2 = "B";
		}
		else
		{
			color2 = "null";
		}
	}

	private void exit_Click(object sender, EventArgs e)
	{
		game.smethod_9();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		game.smethod_6(timer1, bool_0: false);
		game.smethod_6(timer2, bool_0: true);
		game.smethod_4((Control)(object)button1, bool_0: false);
		game.smethod_4((Control)(object)button2, bool_0: true);
		game.smethod_5((Control)(object)button2, Color.Black);
		game.smethod_5((Control)(object)button1, Color.Gray);
	}

	private void button2_Click(object sender, EventArgs e)
	{
		game.smethod_6(timer1, bool_0: true);
		game.smethod_6(timer2, bool_0: false);
		game.smethod_4((Control)(object)button1, bool_0: true);
		game.smethod_4((Control)(object)button2, bool_0: false);
		game.smethod_5((Control)(object)button1, Color.Black);
		game.smethod_5((Control)(object)button2, Color.Gray);
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if (sec1 != 0)
		{
			sec1--;
			game.smethod_3((Control)(object)label1, game.smethod_11(min1.ToString(), ":", sec1.ToString()));
		}
		else if (min1 == 0)
		{
			game.smethod_8("Черные победили!", "Черные победили!", (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0, (MessageBoxOptions)131072);
			game.smethod_9();
		}
		else
		{
			min1--;
			sec1 = 59;
			game.smethod_3((Control)(object)label1, game.smethod_11(min1.ToString(), ":", sec1.ToString()));
		}
	}

	private void p11_Click(object sender, EventArgs e)
	{
		if (select)
		{
			if (hod % 2 != 1)
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
			}
			else
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
			}
			copy2 = p11;
			x2 = game.smethod_12((Control)(object)copy2) / 70;
			y2 = game.smethod_13((Control)(object)copy2) / 70;
			square2 = table[x2 - 1, y2 - 1];
			color(square2);
			piece(square1, x1, y1, x2, y2);
			if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
			{
				img(square1);
				table[x2 - 1, y2 - 1] = square1;
				game.smethod_17((Control)(object)p11, game.smethod_16((Control)(object)copy));
				select = false;
				game.smethod_17((Control)(object)selected, (Image)null);
				game.smethod_17((Control)(object)copy, (Image)null);
				hod++;
				win();
			}
		}
		else
		{
			copy = p11;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p11, (Image)null);
		}
	}

	private void p21_Click(object sender, EventArgs e)
	{
		if (!select)
		{
			copy = p21;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p21, (Image)null);
			return;
		}
		if (hod % 2 != 1)
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
		}
		else
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
		}
		copy2 = p21;
		x2 = game.smethod_12((Control)(object)copy2) / 70;
		y2 = game.smethod_13((Control)(object)copy2) / 70;
		square2 = table[x2 - 1, y2 - 1];
		color(square2);
		piece(square1, x1, y1, x2, y2);
		if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
		{
			img(square1);
			table[x2 - 1, y2 - 1] = square1;
			game.smethod_17((Control)(object)p21, game.smethod_16((Control)(object)copy));
			select = false;
			game.smethod_17((Control)(object)selected, (Image)null);
			game.smethod_17((Control)(object)copy, (Image)null);
			hod++;
			win();
		}
	}

	private void p31_Click(object sender, EventArgs e)
	{
		if (select)
		{
			if (hod % 2 != 1)
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
			}
			else
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
			}
			copy2 = p31;
			x2 = game.smethod_12((Control)(object)copy2) / 70;
			y2 = game.smethod_13((Control)(object)copy2) / 70;
			square2 = table[x2 - 1, y2 - 1];
			color(square2);
			piece(square1, x1, y1, x2, y2);
			if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
			{
				img(square1);
				table[x2 - 1, y2 - 1] = square1;
				game.smethod_17((Control)(object)p31, game.smethod_16((Control)(object)copy));
				select = false;
				game.smethod_17((Control)(object)selected, (Image)null);
				game.smethod_17((Control)(object)copy, (Image)null);
				hod++;
				win();
			}
		}
		else
		{
			copy = p31;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p31, (Image)null);
		}
	}

	private void p41_Click(object sender, EventArgs e)
	{
		if (select)
		{
			if (hod % 2 != 1)
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
			}
			else
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
			}
			copy2 = p41;
			x2 = game.smethod_12((Control)(object)copy2) / 70;
			y2 = game.smethod_13((Control)(object)copy2) / 70;
			square2 = table[x2 - 1, y2 - 1];
			color(square2);
			piece(square1, x1, y1, x2, y2);
			if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
			{
				img(square1);
				table[x2 - 1, y2 - 1] = square1;
				game.smethod_17((Control)(object)p41, game.smethod_16((Control)(object)copy));
				select = false;
				game.smethod_17((Control)(object)selected, (Image)null);
				game.smethod_17((Control)(object)copy, (Image)null);
				hod++;
				win();
			}
		}
		else
		{
			copy = p41;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p41, (Image)null);
		}
	}

	private void p51_Click(object sender, EventArgs e)
	{
		if (!select)
		{
			copy = p51;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p51, (Image)null);
			return;
		}
		if (hod % 2 == 1)
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
		}
		else
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
		}
		copy2 = p51;
		x2 = game.smethod_12((Control)(object)copy2) / 70;
		y2 = game.smethod_13((Control)(object)copy2) / 70;
		square2 = table[x2 - 1, y2 - 1];
		color(square2);
		piece(square1, x1, y1, x2, y2);
		if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
		{
			img(square1);
			table[x2 - 1, y2 - 1] = square1;
			game.smethod_17((Control)(object)p51, game.smethod_16((Control)(object)copy));
			select = false;
			game.smethod_17((Control)(object)selected, (Image)null);
			game.smethod_17((Control)(object)copy, (Image)null);
			hod++;
			win();
		}
	}

	private void p61_Click(object sender, EventArgs e)
	{
		if (!select)
		{
			copy = p61;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p61, (Image)null);
			return;
		}
		if (hod % 2 != 1)
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
		}
		else
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
		}
		copy2 = p61;
		x2 = game.smethod_12((Control)(object)copy2) / 70;
		y2 = game.smethod_13((Control)(object)copy2) / 70;
		square2 = table[x2 - 1, y2 - 1];
		color(square2);
		piece(square1, x1, y1, x2, y2);
		if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
		{
			img(square1);
			table[x2 - 1, y2 - 1] = square1;
			game.smethod_17((Control)(object)p61, game.smethod_16((Control)(object)copy));
			select = false;
			game.smethod_17((Control)(object)selected, (Image)null);
			game.smethod_17((Control)(object)copy, (Image)null);
			hod++;
			win();
		}
	}

	private void p71_Click(object sender, EventArgs e)
	{
		if (!select)
		{
			copy = p71;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p71, (Image)null);
			return;
		}
		if (hod % 2 != 1)
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
		}
		else
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
		}
		copy2 = p71;
		x2 = game.smethod_12((Control)(object)copy2) / 70;
		y2 = game.smethod_13((Control)(object)copy2) / 70;
		square2 = table[x2 - 1, y2 - 1];
		color(square2);
		piece(square1, x1, y1, x2, y2);
		if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
		{
			img(square1);
			table[x2 - 1, y2 - 1] = square1;
			game.smethod_17((Control)(object)p71, game.smethod_16((Control)(object)copy));
			select = false;
			game.smethod_17((Control)(object)selected, (Image)null);
			game.smethod_17((Control)(object)copy, (Image)null);
			hod++;
			win();
		}
	}

	private void p_81_Click(object sender, EventArgs e)
	{
		if (!select)
		{
			copy = p_81;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p_81, (Image)null);
			return;
		}
		if (hod % 2 == 1)
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
		}
		else
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
		}
		copy2 = p_81;
		x2 = game.smethod_12((Control)(object)copy2) / 70;
		y2 = game.smethod_13((Control)(object)copy2) / 70;
		square2 = table[x2 - 1, y2 - 1];
		color(square2);
		piece(square1, x1, y1, x2, y2);
		if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
		{
			img(square1);
			table[x2 - 1, y2 - 1] = square1;
			game.smethod_17((Control)(object)p_81, game.smethod_16((Control)(object)copy));
			select = false;
			game.smethod_17((Control)(object)selected, (Image)null);
			game.smethod_17((Control)(object)copy, (Image)null);
			hod++;
			win();
		}
	}

	private void p12_Click(object sender, EventArgs e)
	{
		if (!select)
		{
			copy = p12;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p12, (Image)null);
			return;
		}
		if (hod % 2 == 1)
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
		}
		else
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
		}
		copy2 = p12;
		x2 = game.smethod_12((Control)(object)copy2) / 70;
		y2 = game.smethod_13((Control)(object)copy2) / 70;
		square2 = table[x2 - 1, y2 - 1];
		color(square2);
		piece(square1, x1, y1, x2, y2);
		if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
		{
			img(square1);
			table[x2 - 1, y2 - 1] = square1;
			game.smethod_17((Control)(object)p12, game.smethod_16((Control)(object)copy));
			select = false;
			game.smethod_17((Control)(object)selected, (Image)null);
			game.smethod_17((Control)(object)copy, (Image)null);
			hod++;
			win();
		}
	}

	private void p22_Click(object sender, EventArgs e)
	{
		if (select)
		{
			if (hod % 2 == 1)
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
			}
			else
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
			}
			copy2 = p22;
			x2 = game.smethod_12((Control)(object)copy2) / 70;
			y2 = game.smethod_13((Control)(object)copy2) / 70;
			square2 = table[x2 - 1, y2 - 1];
			color(square2);
			piece(square1, x1, y1, x2, y2);
			if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
			{
				img(square1);
				table[x2 - 1, y2 - 1] = square1;
				game.smethod_17((Control)(object)p22, game.smethod_16((Control)(object)copy));
				select = false;
				game.smethod_17((Control)(object)selected, (Image)null);
				game.smethod_17((Control)(object)copy, (Image)null);
				hod++;
				win();
			}
		}
		else
		{
			copy = p22;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p22, (Image)null);
		}
	}

	private void p32_Click(object sender, EventArgs e)
	{
		if (!select)
		{
			copy = p32;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p32, (Image)null);
			return;
		}
		if (hod % 2 != 1)
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
		}
		else
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
		}
		copy2 = p32;
		x2 = game.smethod_12((Control)(object)copy2) / 70;
		y2 = game.smethod_13((Control)(object)copy2) / 70;
		square2 = table[x2 - 1, y2 - 1];
		color(square2);
		piece(square1, x1, y1, x2, y2);
		if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
		{
			img(square1);
			table[x2 - 1, y2 - 1] = square1;
			game.smethod_17((Control)(object)p32, game.smethod_16((Control)(object)copy));
			select = false;
			game.smethod_17((Control)(object)selected, (Image)null);
			game.smethod_17((Control)(object)copy, (Image)null);
			hod++;
			win();
		}
	}

	private void p42_Click(object sender, EventArgs e)
	{
		if (select)
		{
			if (hod % 2 == 1)
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
			}
			else
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
			}
			copy2 = p42;
			x2 = game.smethod_12((Control)(object)copy2) / 70;
			y2 = game.smethod_13((Control)(object)copy2) / 70;
			square2 = table[x2 - 1, y2 - 1];
			color(square2);
			piece(square1, x1, y1, x2, y2);
			if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
			{
				img(square1);
				table[x2 - 1, y2 - 1] = square1;
				game.smethod_17((Control)(object)p42, game.smethod_16((Control)(object)copy));
				select = false;
				game.smethod_17((Control)(object)selected, (Image)null);
				game.smethod_17((Control)(object)copy, (Image)null);
				hod++;
				win();
			}
		}
		else
		{
			copy = p42;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p42, (Image)null);
		}
	}

	private void p52_Click(object sender, EventArgs e)
	{
		if (select)
		{
			if (hod % 2 == 1)
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
			}
			else
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
			}
			copy2 = p52;
			x2 = game.smethod_12((Control)(object)copy2) / 70;
			y2 = game.smethod_13((Control)(object)copy2) / 70;
			square2 = table[x2 - 1, y2 - 1];
			color(square2);
			piece(square1, x1, y1, x2, y2);
			if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
			{
				img(square1);
				table[x2 - 1, y2 - 1] = square1;
				game.smethod_17((Control)(object)p52, game.smethod_16((Control)(object)copy));
				select = false;
				game.smethod_17((Control)(object)selected, (Image)null);
				game.smethod_17((Control)(object)copy, (Image)null);
				hod++;
				win();
			}
		}
		else
		{
			copy = p52;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p52, (Image)null);
		}
	}

	private void p62_Click(object sender, EventArgs e)
	{
		if (!select)
		{
			copy = p62;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p62, (Image)null);
			return;
		}
		if (hod % 2 == 1)
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
		}
		else
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
		}
		copy2 = p62;
		x2 = game.smethod_12((Control)(object)copy2) / 70;
		y2 = game.smethod_13((Control)(object)copy2) / 70;
		square2 = table[x2 - 1, y2 - 1];
		color(square2);
		piece(square1, x1, y1, x2, y2);
		if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
		{
			img(square1);
			table[x2 - 1, y2 - 1] = square1;
			game.smethod_17((Control)(object)p62, game.smethod_16((Control)(object)copy));
			select = false;
			game.smethod_17((Control)(object)selected, (Image)null);
			game.smethod_17((Control)(object)copy, (Image)null);
			hod++;
			win();
		}
	}

	private void p72_Click(object sender, EventArgs e)
	{
		if (select)
		{
			if (hod % 2 != 1)
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
			}
			else
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
			}
			copy2 = p72;
			x2 = game.smethod_12((Control)(object)copy2) / 70;
			y2 = game.smethod_13((Control)(object)copy2) / 70;
			square2 = table[x2 - 1, y2 - 1];
			color(square2);
			piece(square1, x1, y1, x2, y2);
			if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
			{
				img(square1);
				table[x2 - 1, y2 - 1] = square1;
				game.smethod_17((Control)(object)p72, game.smethod_16((Control)(object)copy));
				select = false;
				game.smethod_17((Control)(object)selected, (Image)null);
				game.smethod_17((Control)(object)copy, (Image)null);
				hod++;
				win();
			}
		}
		else
		{
			copy = p72;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p72, (Image)null);
		}
	}

	private void p82_Click_1(object sender, EventArgs e)
	{
		if (select)
		{
			if (hod % 2 != 1)
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
			}
			else
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
			}
			copy2 = p82;
			x2 = game.smethod_12((Control)(object)copy2) / 70;
			y2 = game.smethod_13((Control)(object)copy2) / 70;
			square2 = table[x2 - 1, y2 - 1];
			color(square2);
			piece(square1, x1, y1, x2, y2);
			if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
			{
				img(square1);
				table[x2 - 1, y2 - 1] = square1;
				game.smethod_17((Control)(object)p82, game.smethod_16((Control)(object)copy));
				select = false;
				game.smethod_17((Control)(object)selected, (Image)null);
				game.smethod_17((Control)(object)copy, (Image)null);
				hod++;
				win();
			}
		}
		else
		{
			copy = p82;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p82, (Image)null);
		}
	}

	private void p83_Click(object sender, EventArgs e)
	{
		if (!select)
		{
			copy = p83;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p83, (Image)null);
			return;
		}
		if (hod % 2 != 1)
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
		}
		else
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
		}
		copy2 = p83;
		x2 = game.smethod_12((Control)(object)copy2) / 70;
		y2 = game.smethod_13((Control)(object)copy2) / 70;
		square2 = table[x2 - 1, y2 - 1];
		color(square2);
		piece(square1, x1, y1, x2, y2);
		if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
		{
			img(square1);
			table[x2 - 1, y2 - 1] = square1;
			game.smethod_17((Control)(object)p83, game.smethod_16((Control)(object)copy));
			select = false;
			game.smethod_17((Control)(object)selected, (Image)null);
			game.smethod_17((Control)(object)copy, (Image)null);
			hod++;
			win();
		}
	}

	private void p73_Click(object sender, EventArgs e)
	{
		if (select)
		{
			if (hod % 2 != 1)
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
			}
			else
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
			}
			copy2 = p73;
			x2 = game.smethod_12((Control)(object)copy2) / 70;
			y2 = game.smethod_13((Control)(object)copy2) / 70;
			square2 = table[x2 - 1, y2 - 1];
			color(square2);
			piece(square1, x1, y1, x2, y2);
			if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
			{
				img(square1);
				table[x2 - 1, y2 - 1] = square1;
				game.smethod_17((Control)(object)p73, game.smethod_16((Control)(object)copy));
				select = false;
				game.smethod_17((Control)(object)selected, (Image)null);
				game.smethod_17((Control)(object)copy, (Image)null);
				hod++;
				win();
			}
		}
		else
		{
			copy = p73;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p73, (Image)null);
		}
	}

	private void p63_Click(object sender, EventArgs e)
	{
		if (select)
		{
			if (hod % 2 == 1)
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
			}
			else
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
			}
			copy2 = p63;
			x2 = game.smethod_12((Control)(object)copy2) / 70;
			y2 = game.smethod_13((Control)(object)copy2) / 70;
			square2 = table[x2 - 1, y2 - 1];
			color(square2);
			piece(square1, x1, y1, x2, y2);
			if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
			{
				img(square1);
				table[x2 - 1, y2 - 1] = square1;
				game.smethod_17((Control)(object)p63, game.smethod_16((Control)(object)copy));
				select = false;
				game.smethod_17((Control)(object)selected, (Image)null);
				game.smethod_17((Control)(object)copy, (Image)null);
				hod++;
				win();
			}
		}
		else
		{
			copy = p63;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p63, (Image)null);
		}
	}

	private void p84_Click(object sender, EventArgs e)
	{
		if (!select)
		{
			copy = p84;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p84, (Image)null);
			return;
		}
		if (hod % 2 != 1)
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
		}
		else
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
		}
		copy2 = p84;
		x2 = game.smethod_12((Control)(object)copy2) / 70;
		y2 = game.smethod_13((Control)(object)copy2) / 70;
		square2 = table[x2 - 1, y2 - 1];
		color(square2);
		piece(square1, x1, y1, x2, y2);
		if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
		{
			img(square1);
			table[x2 - 1, y2 - 1] = square1;
			game.smethod_17((Control)(object)p84, game.smethod_16((Control)(object)copy));
			select = false;
			game.smethod_17((Control)(object)selected, (Image)null);
			game.smethod_17((Control)(object)copy, (Image)null);
			hod++;
			win();
		}
	}

	private void p85_Click(object sender, EventArgs e)
	{
		if (!select)
		{
			copy = p85;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p85, (Image)null);
			return;
		}
		if (hod % 2 == 1)
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
		}
		else
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
		}
		copy2 = p85;
		x2 = game.smethod_12((Control)(object)copy2) / 70;
		y2 = game.smethod_13((Control)(object)copy2) / 70;
		square2 = table[x2 - 1, y2 - 1];
		color(square2);
		piece(square1, x1, y1, x2, y2);
		if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
		{
			img(square1);
			table[x2 - 1, y2 - 1] = square1;
			game.smethod_17((Control)(object)p85, game.smethod_16((Control)(object)copy));
			select = false;
			game.smethod_17((Control)(object)selected, (Image)null);
			game.smethod_17((Control)(object)copy, (Image)null);
			hod++;
			win();
		}
	}

	private void p86_Click(object sender, EventArgs e)
	{
		if (!select)
		{
			copy = p86;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p86, (Image)null);
			return;
		}
		if (hod % 2 != 1)
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
		}
		else
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
		}
		copy2 = p86;
		x2 = game.smethod_12((Control)(object)copy2) / 70;
		y2 = game.smethod_13((Control)(object)copy2) / 70;
		square2 = table[x2 - 1, y2 - 1];
		color(square2);
		piece(square1, x1, y1, x2, y2);
		if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
		{
			img(square1);
			table[x2 - 1, y2 - 1] = square1;
			game.smethod_17((Control)(object)p86, game.smethod_16((Control)(object)copy));
			select = false;
			game.smethod_17((Control)(object)selected, (Image)null);
			game.smethod_17((Control)(object)copy, (Image)null);
			hod++;
			win();
		}
	}

	private void p87_Click(object sender, EventArgs e)
	{
		if (select)
		{
			if (hod % 2 == 1)
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
			}
			else
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
			}
			copy2 = p87;
			x2 = game.smethod_12((Control)(object)copy2) / 70;
			y2 = game.smethod_13((Control)(object)copy2) / 70;
			square2 = table[x2 - 1, y2 - 1];
			color(square2);
			piece(square1, x1, y1, x2, y2);
			if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
			{
				img(square1);
				table[x2 - 1, y2 - 1] = square1;
				game.smethod_17((Control)(object)p87, game.smethod_16((Control)(object)copy));
				select = false;
				game.smethod_17((Control)(object)selected, (Image)null);
				game.smethod_17((Control)(object)copy, (Image)null);
				hod++;
				win();
			}
		}
		else
		{
			copy = p87;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p87, (Image)null);
		}
	}

	private void p88_Click(object sender, EventArgs e)
	{
		if (!select)
		{
			copy = p88;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p88, (Image)null);
			return;
		}
		if (hod % 2 != 1)
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
		}
		else
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
		}
		copy2 = p88;
		x2 = game.smethod_12((Control)(object)copy2) / 70;
		y2 = game.smethod_13((Control)(object)copy2) / 70;
		square2 = table[x2 - 1, y2 - 1];
		color(square2);
		piece(square1, x1, y1, x2, y2);
		if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
		{
			img(square1);
			table[x2 - 1, y2 - 1] = square1;
			game.smethod_17((Control)(object)p88, game.smethod_16((Control)(object)copy));
			select = false;
			game.smethod_17((Control)(object)selected, (Image)null);
			game.smethod_17((Control)(object)copy, (Image)null);
			hod++;
			win();
		}
	}

	private void p74_Click(object sender, EventArgs e)
	{
		if (select)
		{
			if (hod % 2 != 1)
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
			}
			else
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
			}
			copy2 = p74;
			x2 = game.smethod_12((Control)(object)copy2) / 70;
			y2 = game.smethod_13((Control)(object)copy2) / 70;
			square2 = table[x2 - 1, y2 - 1];
			color(square2);
			piece(square1, x1, y1, x2, y2);
			if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
			{
				img(square1);
				table[x2 - 1, y2 - 1] = square1;
				game.smethod_17((Control)(object)p74, game.smethod_16((Control)(object)copy));
				select = false;
				game.smethod_17((Control)(object)selected, (Image)null);
				game.smethod_17((Control)(object)copy, (Image)null);
				hod++;
				win();
			}
		}
		else
		{
			copy = p74;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p74, (Image)null);
		}
	}

	private void p75_Click(object sender, EventArgs e)
	{
		if (select)
		{
			if (hod % 2 == 1)
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
			}
			else
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
			}
			copy2 = p75;
			x2 = game.smethod_12((Control)(object)copy2) / 70;
			y2 = game.smethod_13((Control)(object)copy2) / 70;
			square2 = table[x2 - 1, y2 - 1];
			color(square2);
			piece(square1, x1, y1, x2, y2);
			if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
			{
				img(square1);
				table[x2 - 1, y2 - 1] = square1;
				game.smethod_17((Control)(object)p75, game.smethod_16((Control)(object)copy));
				select = false;
				game.smethod_17((Control)(object)selected, (Image)null);
				game.smethod_17((Control)(object)copy, (Image)null);
				hod++;
				win();
			}
		}
		else
		{
			copy = p75;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p75, (Image)null);
		}
	}

	private void p76_Click(object sender, EventArgs e)
	{
		if (select)
		{
			if (hod % 2 == 1)
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
			}
			else
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
			}
			copy2 = p76;
			x2 = game.smethod_12((Control)(object)copy2) / 70;
			y2 = game.smethod_13((Control)(object)copy2) / 70;
			square2 = table[x2 - 1, y2 - 1];
			color(square2);
			piece(square1, x1, y1, x2, y2);
			if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
			{
				img(square1);
				table[x2 - 1, y2 - 1] = square1;
				game.smethod_17((Control)(object)p76, game.smethod_16((Control)(object)copy));
				select = false;
				game.smethod_17((Control)(object)selected, (Image)null);
				game.smethod_17((Control)(object)copy, (Image)null);
				hod++;
				win();
			}
		}
		else
		{
			copy = p76;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p71, (Image)null);
		}
	}

	private void p66_Click(object sender, EventArgs e)
	{
		if (!select)
		{
			copy = p66;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p66, (Image)null);
			return;
		}
		if (hod % 2 != 1)
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
		}
		else
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
		}
		copy2 = p66;
		x2 = game.smethod_12((Control)(object)copy2) / 70;
		y2 = game.smethod_13((Control)(object)copy2) / 70;
		square2 = table[x2 - 1, y2 - 1];
		color(square2);
		piece(square1, x1, y1, x2, y2);
		if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
		{
			img(square1);
			table[x2 - 1, y2 - 1] = square1;
			game.smethod_17((Control)(object)p66, game.smethod_16((Control)(object)copy));
			select = false;
			game.smethod_17((Control)(object)selected, (Image)null);
			game.smethod_17((Control)(object)copy, (Image)null);
			hod++;
			win();
		}
	}

	private void p77_Click(object sender, EventArgs e)
	{
		if (select)
		{
			if (hod % 2 != 1)
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
			}
			else
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
			}
			copy2 = p77;
			x2 = game.smethod_12((Control)(object)copy2) / 70;
			y2 = game.smethod_13((Control)(object)copy2) / 70;
			square2 = table[x2 - 1, y2 - 1];
			color(square2);
			piece(square1, x1, y1, x2, y2);
			if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
			{
				img(square1);
				table[x2 - 1, y2 - 1] = square1;
				game.smethod_17((Control)(object)p77, game.smethod_16((Control)(object)copy));
				select = false;
				game.smethod_17((Control)(object)selected, (Image)null);
				game.smethod_17((Control)(object)copy, (Image)null);
				hod++;
				win();
			}
		}
		else
		{
			copy = p77;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p77, (Image)null);
		}
	}

	private void p78_Click(object sender, EventArgs e)
	{
		if (!select)
		{
			copy = p78;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p78, (Image)null);
			return;
		}
		if (hod % 2 != 1)
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
		}
		else
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
		}
		copy2 = p78;
		x2 = game.smethod_12((Control)(object)copy2) / 70;
		y2 = game.smethod_13((Control)(object)copy2) / 70;
		square2 = table[x2 - 1, y2 - 1];
		color(square2);
		piece(square1, x1, y1, x2, y2);
		if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
		{
			img(square1);
			table[x2 - 1, y2 - 1] = square1;
			game.smethod_17((Control)(object)p78, game.smethod_16((Control)(object)copy));
			select = false;
			game.smethod_17((Control)(object)selected, (Image)null);
			game.smethod_17((Control)(object)copy, (Image)null);
			hod++;
			win();
		}
	}

	private void p64_Click(object sender, EventArgs e)
	{
		if (select)
		{
			if (hod % 2 == 1)
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
			}
			else
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
			}
			copy2 = p64;
			x2 = game.smethod_12((Control)(object)copy2) / 70;
			y2 = game.smethod_13((Control)(object)copy2) / 70;
			square2 = table[x2 - 1, y2 - 1];
			color(square2);
			piece(square1, x1, y1, x2, y2);
			if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
			{
				img(square1);
				table[x2 - 1, y2 - 1] = square1;
				game.smethod_17((Control)(object)p64, game.smethod_16((Control)(object)copy));
				select = false;
				game.smethod_17((Control)(object)selected, (Image)null);
				game.smethod_17((Control)(object)copy, (Image)null);
				hod++;
				win();
			}
		}
		else
		{
			copy = p64;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p64, (Image)null);
		}
	}

	private void p65_Click(object sender, EventArgs e)
	{
		if (select)
		{
			if (hod % 2 == 1)
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
			}
			else
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
			}
			copy2 = p65;
			x2 = game.smethod_12((Control)(object)copy2) / 70;
			y2 = game.smethod_13((Control)(object)copy2) / 70;
			square2 = table[x2 - 1, y2 - 1];
			color(square2);
			piece(square1, x1, y1, x2, y2);
			if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
			{
				img(square1);
				table[x2 - 1, y2 - 1] = square1;
				game.smethod_17((Control)(object)p65, game.smethod_16((Control)(object)copy));
				select = false;
				game.smethod_17((Control)(object)selected, (Image)null);
				game.smethod_17((Control)(object)copy, (Image)null);
				hod++;
				win();
			}
		}
		else
		{
			copy = p65;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p65, (Image)null);
		}
	}

	private void p67_Click(object sender, EventArgs e)
	{
		if (!select)
		{
			copy = p67;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p67, (Image)null);
			return;
		}
		if (hod % 2 != 1)
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
		}
		else
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
		}
		copy2 = p67;
		x2 = game.smethod_12((Control)(object)copy2) / 70;
		y2 = game.smethod_13((Control)(object)copy2) / 70;
		square2 = table[x2 - 1, y2 - 1];
		color(square2);
		piece(square1, x1, y1, x2, y2);
		if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
		{
			img(square1);
			table[x2 - 1, y2 - 1] = square1;
			game.smethod_17((Control)(object)p67, game.smethod_16((Control)(object)copy));
			select = false;
			game.smethod_17((Control)(object)selected, (Image)null);
			game.smethod_17((Control)(object)copy, (Image)null);
			hod++;
			win();
		}
	}

	private void p68_Click(object sender, EventArgs e)
	{
		if (!select)
		{
			copy = p68;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p68, (Image)null);
			return;
		}
		if (hod % 2 != 1)
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
		}
		else
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
		}
		copy2 = p68;
		x2 = game.smethod_12((Control)(object)copy2) / 70;
		y2 = game.smethod_13((Control)(object)copy2) / 70;
		square2 = table[x2 - 1, y2 - 1];
		color(square2);
		piece(square1, x1, y1, x2, y2);
		if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
		{
			img(square1);
			table[x2 - 1, y2 - 1] = square1;
			game.smethod_17((Control)(object)p68, game.smethod_16((Control)(object)copy));
			select = false;
			game.smethod_17((Control)(object)selected, (Image)null);
			game.smethod_17((Control)(object)copy, (Image)null);
			hod++;
			win();
		}
	}

	private void p43_Click(object sender, EventArgs e)
	{
		if (!select)
		{
			copy = p43;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p43, (Image)null);
			return;
		}
		if (hod % 2 != 1)
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
		}
		else
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
		}
		copy2 = p43;
		x2 = game.smethod_12((Control)(object)copy2) / 70;
		y2 = game.smethod_13((Control)(object)copy2) / 70;
		square2 = table[x2 - 1, y2 - 1];
		color(square2);
		piece(square1, x1, y1, x2, y2);
		if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
		{
			img(square1);
			table[x2 - 1, y2 - 1] = square1;
			game.smethod_17((Control)(object)p43, game.smethod_16((Control)(object)copy));
			select = false;
			game.smethod_17((Control)(object)selected, (Image)null);
			game.smethod_17((Control)(object)copy, (Image)null);
			hod++;
			win();
		}
	}

	private void p53_Click(object sender, EventArgs e)
	{
		if (select)
		{
			if (hod % 2 != 1)
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
			}
			else
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
			}
			copy2 = p53;
			x2 = game.smethod_12((Control)(object)copy2) / 70;
			y2 = game.smethod_13((Control)(object)copy2) / 70;
			square2 = table[x2 - 1, y2 - 1];
			color(square2);
			piece(square1, x1, y1, x2, y2);
			if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
			{
				img(square1);
				table[x2 - 1, y2 - 1] = square1;
				game.smethod_17((Control)(object)p53, game.smethod_16((Control)(object)copy));
				select = false;
				game.smethod_17((Control)(object)selected, (Image)null);
				game.smethod_17((Control)(object)copy, (Image)null);
				hod++;
				win();
			}
		}
		else
		{
			copy = p53;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p53, (Image)null);
		}
	}

	private void p54_Click(object sender, EventArgs e)
	{
		if (select)
		{
			if (hod % 2 == 1)
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
			}
			else
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
			}
			copy2 = p54;
			x2 = game.smethod_12((Control)(object)copy2) / 70;
			y2 = game.smethod_13((Control)(object)copy2) / 70;
			square2 = table[x2 - 1, y2 - 1];
			color(square2);
			piece(square1, x1, y1, x2, y2);
			if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
			{
				img(square1);
				table[x2 - 1, y2 - 1] = square1;
				game.smethod_17((Control)(object)p54, game.smethod_16((Control)(object)copy));
				select = false;
				game.smethod_17((Control)(object)selected, (Image)null);
				game.smethod_17((Control)(object)copy, (Image)null);
				hod++;
				win();
			}
		}
		else
		{
			copy = p54;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p54, (Image)null);
		}
	}

	private void p55_Click(object sender, EventArgs e)
	{
		if (!select)
		{
			copy = p55;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p55, (Image)null);
			return;
		}
		if (hod % 2 != 1)
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
		}
		else
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
		}
		copy2 = p55;
		x2 = game.smethod_12((Control)(object)copy2) / 70;
		y2 = game.smethod_13((Control)(object)copy2) / 70;
		square2 = table[x2 - 1, y2 - 1];
		color(square2);
		piece(square1, x1, y1, x2, y2);
		if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
		{
			img(square1);
			table[x2 - 1, y2 - 1] = square1;
			game.smethod_17((Control)(object)p55, game.smethod_16((Control)(object)copy));
			select = false;
			game.smethod_17((Control)(object)selected, (Image)null);
			game.smethod_17((Control)(object)copy, (Image)null);
			hod++;
			win();
		}
	}

	private void p56_Click(object sender, EventArgs e)
	{
		if (select)
		{
			if (hod % 2 == 1)
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
			}
			else
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
			}
			copy2 = p56;
			x2 = game.smethod_12((Control)(object)copy2) / 70;
			y2 = game.smethod_13((Control)(object)copy2) / 70;
			square2 = table[x2 - 1, y2 - 1];
			color(square2);
			piece(square1, x1, y1, x2, y2);
			if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
			{
				img(square1);
				table[x2 - 1, y2 - 1] = square1;
				game.smethod_17((Control)(object)p56, game.smethod_16((Control)(object)copy));
				select = false;
				game.smethod_17((Control)(object)selected, (Image)null);
				game.smethod_17((Control)(object)copy, (Image)null);
				hod++;
				win();
			}
		}
		else
		{
			copy = p56;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p56, (Image)null);
		}
	}

	private void p57_Click(object sender, EventArgs e)
	{
		if (select)
		{
			if (hod % 2 != 1)
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
			}
			else
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
			}
			copy2 = p57;
			x2 = game.smethod_12((Control)(object)copy2) / 70;
			y2 = game.smethod_13((Control)(object)copy2) / 70;
			square2 = table[x2 - 1, y2 - 1];
			color(square2);
			piece(square1, x1, y1, x2, y2);
			if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
			{
				img(square1);
				table[x2 - 1, y2 - 1] = square1;
				game.smethod_17((Control)(object)p57, game.smethod_16((Control)(object)copy));
				select = false;
				game.smethod_17((Control)(object)selected, (Image)null);
				game.smethod_17((Control)(object)copy, (Image)null);
				hod++;
				win();
			}
		}
		else
		{
			copy = p57;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p57, (Image)null);
		}
	}

	private void p58_Click(object sender, EventArgs e)
	{
		if (!select)
		{
			copy = p58;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p58, (Image)null);
			return;
		}
		if (hod % 2 == 1)
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
		}
		else
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
		}
		copy2 = p58;
		x2 = game.smethod_12((Control)(object)copy2) / 70;
		y2 = game.smethod_13((Control)(object)copy2) / 70;
		square2 = table[x2 - 1, y2 - 1];
		color(square2);
		piece(square1, x1, y1, x2, y2);
		if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
		{
			img(square1);
			table[x2 - 1, y2 - 1] = square1;
			game.smethod_17((Control)(object)p58, game.smethod_16((Control)(object)copy));
			select = false;
			game.smethod_17((Control)(object)selected, (Image)null);
			game.smethod_17((Control)(object)copy, (Image)null);
			hod++;
			win();
		}
	}

	private void p44_Click(object sender, EventArgs e)
	{
		if (select)
		{
			if (hod % 2 != 1)
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
			}
			else
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
			}
			copy2 = p44;
			x2 = game.smethod_12((Control)(object)copy2) / 70;
			y2 = game.smethod_13((Control)(object)copy2) / 70;
			square2 = table[x2 - 1, y2 - 1];
			color(square2);
			piece(square1, x1, y1, x2, y2);
			if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
			{
				img(square1);
				table[x2 - 1, y2 - 1] = square1;
				game.smethod_17((Control)(object)p44, game.smethod_16((Control)(object)copy));
				select = false;
				game.smethod_17((Control)(object)selected, (Image)null);
				game.smethod_17((Control)(object)copy, (Image)null);
				hod++;
				win();
			}
		}
		else
		{
			copy = p44;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p44, (Image)null);
		}
	}

	private void p45_Click(object sender, EventArgs e)
	{
		if (!select)
		{
			copy = p45;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p45, (Image)null);
			return;
		}
		if (hod % 2 == 1)
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
		}
		else
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
		}
		copy2 = p45;
		x2 = game.smethod_12((Control)(object)copy2) / 70;
		y2 = game.smethod_13((Control)(object)copy2) / 70;
		square2 = table[x2 - 1, y2 - 1];
		color(square2);
		piece(square1, x1, y1, x2, y2);
		if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
		{
			img(square1);
			table[x2 - 1, y2 - 1] = square1;
			game.smethod_17((Control)(object)p45, game.smethod_16((Control)(object)copy));
			select = false;
			game.smethod_17((Control)(object)selected, (Image)null);
			game.smethod_17((Control)(object)copy, (Image)null);
			hod++;
			win();
		}
	}

	private void p46_Click(object sender, EventArgs e)
	{
		if (select)
		{
			if (hod % 2 == 1)
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
			}
			else
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
			}
			copy2 = p46;
			x2 = game.smethod_12((Control)(object)copy2) / 70;
			y2 = game.smethod_13((Control)(object)copy2) / 70;
			square2 = table[x2 - 1, y2 - 1];
			color(square2);
			piece(square1, x1, y1, x2, y2);
			if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
			{
				img(square1);
				table[x2 - 1, y2 - 1] = square1;
				game.smethod_17((Control)(object)p46, game.smethod_16((Control)(object)copy));
				select = false;
				game.smethod_17((Control)(object)selected, (Image)null);
				game.smethod_17((Control)(object)copy, (Image)null);
				hod++;
				win();
			}
		}
		else
		{
			copy = p46;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p46, (Image)null);
		}
	}

	private void p47_Click(object sender, EventArgs e)
	{
		if (!select)
		{
			copy = p47;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p47, (Image)null);
			return;
		}
		if (hod % 2 == 1)
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
		}
		else
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
		}
		copy2 = p47;
		x2 = game.smethod_12((Control)(object)copy2) / 70;
		y2 = game.smethod_13((Control)(object)copy2) / 70;
		square2 = table[x2 - 1, y2 - 1];
		color(square2);
		piece(square1, x1, y1, x2, y2);
		if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
		{
			img(square1);
			table[x2 - 1, y2 - 1] = square1;
			game.smethod_17((Control)(object)p47, game.smethod_16((Control)(object)copy));
			select = false;
			game.smethod_17((Control)(object)selected, (Image)null);
			game.smethod_17((Control)(object)copy, (Image)null);
			hod++;
			win();
		}
	}

	private void p48_Click(object sender, EventArgs e)
	{
		if (!select)
		{
			copy = p48;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p48, (Image)null);
			return;
		}
		if (hod % 2 != 1)
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
		}
		else
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
		}
		copy2 = p48;
		x2 = game.smethod_12((Control)(object)copy2) / 70;
		y2 = game.smethod_13((Control)(object)copy2) / 70;
		square2 = table[x2 - 1, y2 - 1];
		color(square2);
		piece(square1, x1, y1, x2, y2);
		if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
		{
			img(square1);
			table[x2 - 1, y2 - 1] = square1;
			game.smethod_17((Control)(object)p48, game.smethod_16((Control)(object)copy));
			select = false;
			game.smethod_17((Control)(object)selected, (Image)null);
			game.smethod_17((Control)(object)copy, (Image)null);
			hod++;
			win();
		}
	}

	private void p33_Click(object sender, EventArgs e)
	{
		if (!select)
		{
			copy = p33;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p33, (Image)null);
			return;
		}
		if (hod % 2 == 1)
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
		}
		else
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
		}
		copy2 = p33;
		x2 = game.smethod_12((Control)(object)copy2) / 70;
		y2 = game.smethod_13((Control)(object)copy2) / 70;
		square2 = table[x2 - 1, y2 - 1];
		color(square2);
		piece(square1, x1, y1, x2, y2);
		if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
		{
			img(square1);
			table[x2 - 1, y2 - 1] = square1;
			game.smethod_17((Control)(object)p33, game.smethod_16((Control)(object)copy));
			select = false;
			game.smethod_17((Control)(object)selected, (Image)null);
			game.smethod_17((Control)(object)copy, (Image)null);
			hod++;
			win();
		}
	}

	private void p34_Click(object sender, EventArgs e)
	{
		if (!select)
		{
			copy = p34;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p34, (Image)null);
			return;
		}
		if (hod % 2 == 1)
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
		}
		else
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
		}
		copy2 = p34;
		x2 = game.smethod_12((Control)(object)copy2) / 70;
		y2 = game.smethod_13((Control)(object)copy2) / 70;
		square2 = table[x2 - 1, y2 - 1];
		color(square2);
		piece(square1, x1, y1, x2, y2);
		if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
		{
			img(square1);
			table[x2 - 1, y2 - 1] = square1;
			game.smethod_17((Control)(object)p34, game.smethod_16((Control)(object)copy));
			select = false;
			game.smethod_17((Control)(object)selected, (Image)null);
			game.smethod_17((Control)(object)copy, (Image)null);
			hod++;
			win();
		}
	}

	private void p35_Click(object sender, EventArgs e)
	{
		if (!select)
		{
			copy = p35;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p35, (Image)null);
			return;
		}
		if (hod % 2 != 1)
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
		}
		else
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
		}
		copy2 = p35;
		x2 = game.smethod_12((Control)(object)copy2) / 70;
		y2 = game.smethod_13((Control)(object)copy2) / 70;
		square2 = table[x2 - 1, y2 - 1];
		color(square2);
		piece(square1, x1, y1, x2, y2);
		if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
		{
			img(square1);
			table[x2 - 1, y2 - 1] = square1;
			game.smethod_17((Control)(object)p35, game.smethod_16((Control)(object)copy));
			select = false;
			game.smethod_17((Control)(object)selected, (Image)null);
			game.smethod_17((Control)(object)copy, (Image)null);
			hod++;
			win();
		}
	}

	private void p36_Click(object sender, EventArgs e)
	{
		if (select)
		{
			if (hod % 2 != 1)
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
			}
			else
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
			}
			copy2 = p36;
			x2 = game.smethod_12((Control)(object)copy2) / 70;
			y2 = game.smethod_13((Control)(object)copy2) / 70;
			square2 = table[x2 - 1, y2 - 1];
			color(square2);
			piece(square1, x1, y1, x2, y2);
			if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
			{
				img(square1);
				table[x2 - 1, y2 - 1] = square1;
				game.smethod_17((Control)(object)p36, game.smethod_16((Control)(object)copy));
				select = false;
				game.smethod_17((Control)(object)selected, (Image)null);
				game.smethod_17((Control)(object)copy, (Image)null);
				hod++;
				win();
			}
		}
		else
		{
			copy = p36;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p36, (Image)null);
		}
	}

	private void p37_Click(object sender, EventArgs e)
	{
		if (!select)
		{
			copy = p37;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p37, (Image)null);
			return;
		}
		if (hod % 2 != 1)
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
		}
		else
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
		}
		copy2 = p37;
		x2 = game.smethod_12((Control)(object)copy2) / 70;
		y2 = game.smethod_13((Control)(object)copy2) / 70;
		square2 = table[x2 - 1, y2 - 1];
		color(square2);
		piece(square1, x1, y1, x2, y2);
		if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
		{
			img(square1);
			table[x2 - 1, y2 - 1] = square1;
			game.smethod_17((Control)(object)p37, game.smethod_16((Control)(object)copy));
			select = false;
			game.smethod_17((Control)(object)selected, (Image)null);
			game.smethod_17((Control)(object)copy, (Image)null);
			hod++;
			win();
		}
	}

	private void p38_Click(object sender, EventArgs e)
	{
		if (!select)
		{
			copy = p38;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p38, (Image)null);
			return;
		}
		if (hod % 2 == 1)
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
		}
		else
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
		}
		copy2 = p38;
		x2 = game.smethod_12((Control)(object)copy2) / 70;
		y2 = game.smethod_13((Control)(object)copy2) / 70;
		square2 = table[x2 - 1, y2 - 1];
		color(square2);
		piece(square1, x1, y1, x2, y2);
		if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
		{
			img(square1);
			table[x2 - 1, y2 - 1] = square1;
			game.smethod_17((Control)(object)p38, game.smethod_16((Control)(object)copy));
			select = false;
			game.smethod_17((Control)(object)selected, (Image)null);
			game.smethod_17((Control)(object)copy, (Image)null);
			hod++;
			win();
		}
	}

	private void p23_Click(object sender, EventArgs e)
	{
		if (select)
		{
			if (hod % 2 != 1)
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
			}
			else
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
			}
			copy2 = p23;
			x2 = game.smethod_12((Control)(object)copy2) / 70;
			y2 = game.smethod_13((Control)(object)copy2) / 70;
			square2 = table[x2 - 1, y2 - 1];
			color(square2);
			piece(square1, x1, y1, x2, y2);
			if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
			{
				img(square1);
				table[x2 - 1, y2 - 1] = square1;
				game.smethod_17((Control)(object)p23, game.smethod_16((Control)(object)copy));
				select = false;
				game.smethod_17((Control)(object)selected, (Image)null);
				game.smethod_17((Control)(object)copy, (Image)null);
				hod++;
				win();
			}
		}
		else
		{
			copy = p23;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p23, (Image)null);
		}
	}

	private void p24_Click(object sender, EventArgs e)
	{
		if (!select)
		{
			copy = p24;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p24, (Image)null);
			return;
		}
		if (hod % 2 != 1)
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
		}
		else
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
		}
		copy2 = p24;
		x2 = game.smethod_12((Control)(object)copy2) / 70;
		y2 = game.smethod_13((Control)(object)copy2) / 70;
		square2 = table[x2 - 1, y2 - 1];
		color(square2);
		piece(square1, x1, y1, x2, y2);
		if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
		{
			img(square1);
			table[x2 - 1, y2 - 1] = square1;
			game.smethod_17((Control)(object)p24, game.smethod_16((Control)(object)copy));
			select = false;
			game.smethod_17((Control)(object)selected, (Image)null);
			game.smethod_17((Control)(object)copy, (Image)null);
			hod++;
			win();
		}
	}

	private void p25_Click(object sender, EventArgs e)
	{
		if (!select)
		{
			copy = p25;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p25, (Image)null);
			return;
		}
		if (hod % 2 != 1)
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
		}
		else
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
		}
		copy2 = p25;
		x2 = game.smethod_12((Control)(object)copy2) / 70;
		y2 = game.smethod_13((Control)(object)copy2) / 70;
		square2 = table[x2 - 1, y2 - 1];
		color(square2);
		piece(square1, x1, y1, x2, y2);
		if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
		{
			img(square1);
			table[x2 - 1, y2 - 1] = square1;
			game.smethod_17((Control)(object)p25, game.smethod_16((Control)(object)copy));
			select = false;
			game.smethod_17((Control)(object)selected, (Image)null);
			game.smethod_17((Control)(object)copy, (Image)null);
			hod++;
			win();
		}
	}

	private void p26_Click(object sender, EventArgs e)
	{
		if (!select)
		{
			copy = p26;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p26, (Image)null);
			return;
		}
		if (hod % 2 == 1)
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
		}
		else
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
		}
		copy2 = p26;
		x2 = game.smethod_12((Control)(object)copy2) / 70;
		y2 = game.smethod_13((Control)(object)copy2) / 70;
		square2 = table[x2 - 1, y2 - 1];
		color(square2);
		piece(square1, x1, y1, x2, y2);
		if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
		{
			img(square1);
			table[x2 - 1, y2 - 1] = square1;
			game.smethod_17((Control)(object)p26, game.smethod_16((Control)(object)copy));
			select = false;
			game.smethod_17((Control)(object)selected, (Image)null);
			game.smethod_17((Control)(object)copy, (Image)null);
			hod++;
			win();
		}
	}

	private void p27_Click(object sender, EventArgs e)
	{
		if (select)
		{
			if (hod % 2 == 1)
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
			}
			else
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
			}
			copy2 = p27;
			x2 = game.smethod_12((Control)(object)copy2) / 70;
			y2 = game.smethod_13((Control)(object)copy2) / 70;
			square2 = table[x2 - 1, y2 - 1];
			color(square2);
			piece(square1, x1, y1, x2, y2);
			if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
			{
				img(square1);
				table[x2 - 1, y2 - 1] = square1;
				game.smethod_17((Control)(object)p27, game.smethod_16((Control)(object)copy));
				select = false;
				game.smethod_17((Control)(object)selected, (Image)null);
				game.smethod_17((Control)(object)copy, (Image)null);
				hod++;
				win();
			}
		}
		else
		{
			copy = p27;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p27, (Image)null);
		}
	}

	private void p28_Click(object sender, EventArgs e)
	{
		if (!select)
		{
			copy = p28;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p28, (Image)null);
			return;
		}
		if (hod % 2 != 1)
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
		}
		else
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
		}
		copy2 = p28;
		x2 = game.smethod_12((Control)(object)copy2) / 70;
		y2 = game.smethod_13((Control)(object)copy2) / 70;
		square2 = table[x2 - 1, y2 - 1];
		color(square2);
		piece(square1, x1, y1, x2, y2);
		if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
		{
			img(square1);
			table[x2 - 1, y2 - 1] = square1;
			game.smethod_17((Control)(object)p28, game.smethod_16((Control)(object)copy));
			select = false;
			game.smethod_17((Control)(object)selected, (Image)null);
			game.smethod_17((Control)(object)copy, (Image)null);
			hod++;
			win();
		}
	}

	private void p13_Click(object sender, EventArgs e)
	{
		if (select)
		{
			if (hod % 2 != 1)
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
			}
			else
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
			}
			copy2 = p13;
			x2 = game.smethod_12((Control)(object)copy2) / 70;
			y2 = game.smethod_13((Control)(object)copy2) / 70;
			square2 = table[x2 - 1, y2 - 1];
			color(square2);
			piece(square1, x1, y1, x2, y2);
			if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
			{
				img(square1);
				table[x2 - 1, y2 - 1] = square1;
				game.smethod_17((Control)(object)p13, game.smethod_16((Control)(object)copy));
				select = false;
				game.smethod_17((Control)(object)selected, (Image)null);
				hod++;
				game.smethod_17((Control)(object)copy, (Image)null);
				win();
			}
		}
		else
		{
			copy = p13;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p13, (Image)null);
		}
	}

	private void p14_Click(object sender, EventArgs e)
	{
		if (!select)
		{
			copy = p14;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p14, (Image)null);
			return;
		}
		if (hod % 2 == 1)
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
		}
		else
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
		}
		copy2 = p14;
		x2 = game.smethod_12((Control)(object)copy2) / 70;
		y2 = game.smethod_13((Control)(object)copy2) / 70;
		square2 = table[x2 - 1, y2 - 1];
		color(square2);
		piece(square1, x1, y1, x2, y2);
		if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
		{
			img(square1);
			table[x2 - 1, y2 - 1] = square1;
			game.smethod_17((Control)(object)p14, game.smethod_16((Control)(object)copy));
			select = false;
			game.smethod_17((Control)(object)selected, (Image)null);
			game.smethod_17((Control)(object)copy, (Image)null);
			hod++;
			win();
		}
	}

	private void p15_Click(object sender, EventArgs e)
	{
		if (select)
		{
			if (hod % 2 == 1)
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
			}
			else
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
			}
			copy2 = p15;
			x2 = game.smethod_12((Control)(object)copy2) / 70;
			y2 = game.smethod_13((Control)(object)copy2) / 70;
			square2 = table[x2 - 1, y2 - 1];
			color(square2);
			piece(square1, x1, y1, x2, y2);
			if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
			{
				img(square1);
				table[x2 - 1, y2 - 1] = square1;
				game.smethod_17((Control)(object)p15, game.smethod_16((Control)(object)copy));
				select = false;
				game.smethod_17((Control)(object)selected, (Image)null);
				game.smethod_17((Control)(object)copy, (Image)null);
				hod++;
				win();
			}
		}
		else
		{
			copy = p15;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p15, (Image)null);
		}
	}

	private void label2_Click(object sender, EventArgs e)
	{
	}

	private void timer2_Tick(object sender, EventArgs e)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if (sec2 == 0)
		{
			if (min2 == 0)
			{
				game.smethod_8("Белые победили!", "Белые победили!", (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0, (MessageBoxOptions)131072);
				game.smethod_9();
			}
			else
			{
				min2--;
				sec2 = 59;
				game.smethod_3((Control)(object)label1, game.smethod_11(min2.ToString(), ":", sec2.ToString()));
			}
		}
		else
		{
			sec2--;
			game.smethod_3((Control)(object)label2, game.smethod_11(min2.ToString(), ":", sec2.ToString()));
		}
	}

	private void p16_Click(object sender, EventArgs e)
	{
		if (!select)
		{
			copy = p16;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p16, (Image)null);
			return;
		}
		if (hod % 2 == 1)
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
		}
		else
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
		}
		copy2 = p16;
		x2 = game.smethod_12((Control)(object)copy2) / 70;
		y2 = game.smethod_13((Control)(object)copy2) / 70;
		square2 = table[x2 - 1, y2 - 1];
		color(square2);
		piece(square1, x1, y1, x2, y2);
		if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
		{
			img(square1);
			table[x2 - 1, y2 - 1] = square1;
			game.smethod_17((Control)(object)p16, game.smethod_16((Control)(object)copy));
			select = false;
			game.smethod_17((Control)(object)selected, (Image)null);
			game.smethod_17((Control)(object)copy, (Image)null);
			hod++;
			win();
		}
	}

	private void p17_Click(object sender, EventArgs e)
	{
		if (select)
		{
			if (hod % 2 == 1)
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
			}
			else
			{
				game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
			}
			copy2 = p17;
			x2 = game.smethod_12((Control)(object)copy2) / 70;
			y2 = game.smethod_13((Control)(object)copy2) / 70;
			square2 = table[x2 - 1, y2 - 1];
			color(square2);
			piece(square1, x1, y1, x2, y2);
			if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
			{
				img(square1);
				table[x2 - 1, y2 - 1] = square1;
				game.smethod_17((Control)(object)p17, game.smethod_16((Control)(object)copy));
				select = false;
				game.smethod_17((Control)(object)selected, (Image)null);
				game.smethod_17((Control)(object)copy, (Image)null);
				hod++;
				win();
			}
		}
		else
		{
			copy = p17;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p17, (Image)null);
		}
	}

	private void p18_Click(object sender, EventArgs e)
	{
		if (!select)
		{
			copy = p18;
			x1 = game.smethod_12((Control)(object)copy) / 70;
			y1 = game.smethod_13((Control)(object)copy) / 70;
			square1 = table[x1 - 1, y1 - 1];
			color(square1);
			table[x1 - 1, y1 - 1] = 0;
			game.smethod_17((Control)(object)selected, game.smethod_16((Control)(object)copy));
			select = true;
			game.smethod_17((Control)(object)p18, (Image)null);
			return;
		}
		if (hod % 2 == 1)
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - черные");
		}
		else
		{
			game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
		}
		copy2 = p18;
		x2 = game.smethod_12((Control)(object)copy2) / 70;
		y2 = game.smethod_13((Control)(object)copy2) / 70;
		square2 = table[x2 - 1, y2 - 1];
		color(square2);
		piece(square1, x1, y1, x2, y2);
		if (game.smethod_14(color1, color2) && go && ((game.smethod_15(color1, "W") && hod % 2 == 1) || (game.smethod_15(color1, "B") && hod % 2 == 0)))
		{
			img(square1);
			table[x2 - 1, y2 - 1] = square1;
			game.smethod_17((Control)(object)p18, game.smethod_16((Control)(object)copy));
			select = false;
			game.smethod_17((Control)(object)selected, (Image)null);
			game.smethod_17((Control)(object)copy, (Image)null);
			hod++;
			win();
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			game.smethod_18((IDisposable)components);
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_1021: Unknown result type (might be due to invalid IL or missing references)
		//IL_10bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1157: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_128d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1328: Unknown result type (might be due to invalid IL or missing references)
		//IL_13c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_145e: Unknown result type (might be due to invalid IL or missing references)
		//IL_14f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1591: Unknown result type (might be due to invalid IL or missing references)
		//IL_162c: Unknown result type (might be due to invalid IL or missing references)
		//IL_16c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1762: Unknown result type (might be due to invalid IL or missing references)
		//IL_17fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1898: Unknown result type (might be due to invalid IL or missing references)
		//IL_1933: Unknown result type (might be due to invalid IL or missing references)
		//IL_19cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a66: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b01: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c37: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e08: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ea0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2071: Unknown result type (might be due to invalid IL or missing references)
		//IL_210c: Unknown result type (might be due to invalid IL or missing references)
		//IL_21a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2242: Unknown result type (might be due to invalid IL or missing references)
		//IL_22dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_2375: Unknown result type (might be due to invalid IL or missing references)
		//IL_240a: Unknown result type (might be due to invalid IL or missing references)
		//IL_24a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2540: Unknown result type (might be due to invalid IL or missing references)
		//IL_25db: Unknown result type (might be due to invalid IL or missing references)
		//IL_2676: Unknown result type (might be due to invalid IL or missing references)
		//IL_2711: Unknown result type (might be due to invalid IL or missing references)
		//IL_27ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_2844: Unknown result type (might be due to invalid IL or missing references)
		//IL_28df: Unknown result type (might be due to invalid IL or missing references)
		//IL_297a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a15: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ab0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2be6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c81: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d19: Unknown result type (might be due to invalid IL or missing references)
		//IL_2db4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2eea: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f85: Unknown result type (might be due to invalid IL or missing references)
		//IL_3020: Unknown result type (might be due to invalid IL or missing references)
		//IL_30bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_3156: Unknown result type (might be due to invalid IL or missing references)
		//IL_31ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_3286: Unknown result type (might be due to invalid IL or missing references)
		//IL_331d: Unknown result type (might be due to invalid IL or missing references)
		//IL_33b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_344b: Unknown result type (might be due to invalid IL or missing references)
		//IL_34e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_3579: Unknown result type (might be due to invalid IL or missing references)
		//IL_3610: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d05: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e13: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f21: Unknown result type (might be due to invalid IL or missing references)
		//IL_3fa8: Unknown result type (might be due to invalid IL or missing references)
		//IL_402f: Unknown result type (might be due to invalid IL or missing references)
		//IL_40b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_413a: Unknown result type (might be due to invalid IL or missing references)
		//IL_41c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_4248: Unknown result type (might be due to invalid IL or missing references)
		//IL_42cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_4353: Unknown result type (might be due to invalid IL or missing references)
		//IL_43d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_445b: Unknown result type (might be due to invalid IL or missing references)
		//IL_44dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_4560: Unknown result type (might be due to invalid IL or missing references)
		//IL_45e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_4668: Unknown result type (might be due to invalid IL or missing references)
		//IL_46ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_4770: Unknown result type (might be due to invalid IL or missing references)
		//IL_47f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_4878: Unknown result type (might be due to invalid IL or missing references)
		//IL_48f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_497d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a01: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a85: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b09: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4c11: Unknown result type (might be due to invalid IL or missing references)
		//IL_4c95: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d16: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d94: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e18: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_4f20: Unknown result type (might be due to invalid IL or missing references)
		//IL_4fa4: Unknown result type (might be due to invalid IL or missing references)
		//IL_5028: Unknown result type (might be due to invalid IL or missing references)
		//IL_50ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_512d: Unknown result type (might be due to invalid IL or missing references)
		//IL_51b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_5235: Unknown result type (might be due to invalid IL or missing references)
		//IL_52b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_533d: Unknown result type (might be due to invalid IL or missing references)
		//IL_53c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_5445: Unknown result type (might be due to invalid IL or missing references)
		//IL_54c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_554a: Unknown result type (might be due to invalid IL or missing references)
		//IL_55ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_5652: Unknown result type (might be due to invalid IL or missing references)
		//IL_56d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_575a: Unknown result type (might be due to invalid IL or missing references)
		//IL_57de: Unknown result type (might be due to invalid IL or missing references)
		//IL_5862: Unknown result type (might be due to invalid IL or missing references)
		//IL_58e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_5967: Unknown result type (might be due to invalid IL or missing references)
		//IL_59e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_5a69: Unknown result type (might be due to invalid IL or missing references)
		//IL_5aea: Unknown result type (might be due to invalid IL or missing references)
		//IL_5b6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_5bec: Unknown result type (might be due to invalid IL or missing references)
		//IL_5c6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_5cee: Unknown result type (might be due to invalid IL or missing references)
		components = game.smethod_19();
		timer1 = game.smethod_20(components);
		timer2 = game.smethod_20(components);
		exit = game.smethod_21();
		button1 = game.smethod_21();
		button2 = game.smethod_21();
		label1 = game.smethod_22();
		label2 = game.smethod_22();
		selected = game.smethod_23();
		p85 = game.smethod_23();
		p_81 = game.smethod_23();
		p71 = game.smethod_23();
		p61 = game.smethod_23();
		p51 = game.smethod_23();
		p41 = game.smethod_23();
		p31 = game.smethod_23();
		p21 = game.smethod_23();
		p11 = game.smethod_23();
		p82 = game.smethod_23();
		p72 = game.smethod_23();
		p62 = game.smethod_23();
		p52 = game.smethod_23();
		p42 = game.smethod_23();
		p32 = game.smethod_23();
		p22 = game.smethod_23();
		p12 = game.smethod_23();
		p83 = game.smethod_23();
		p73 = game.smethod_23();
		p63 = game.smethod_23();
		p53 = game.smethod_23();
		p43 = game.smethod_23();
		p33 = game.smethod_23();
		p23 = game.smethod_23();
		p13 = game.smethod_23();
		p84 = game.smethod_23();
		p74 = game.smethod_23();
		p64 = game.smethod_23();
		p54 = game.smethod_23();
		p44 = game.smethod_23();
		p34 = game.smethod_23();
		p24 = game.smethod_23();
		p14 = game.smethod_23();
		p18 = game.smethod_23();
		p75 = game.smethod_23();
		p65 = game.smethod_23();
		p55 = game.smethod_23();
		p45 = game.smethod_23();
		p35 = game.smethod_23();
		p25 = game.smethod_23();
		p15 = game.smethod_23();
		p86 = game.smethod_23();
		p76 = game.smethod_23();
		p66 = game.smethod_23();
		p56 = game.smethod_23();
		p46 = game.smethod_23();
		p36 = game.smethod_23();
		p26 = game.smethod_23();
		p16 = game.smethod_23();
		p87 = game.smethod_23();
		p77 = game.smethod_23();
		p67 = game.smethod_23();
		p57 = game.smethod_23();
		p47 = game.smethod_23();
		p37 = game.smethod_23();
		p27 = game.smethod_23();
		p17 = game.smethod_23();
		p88 = game.smethod_23();
		p78 = game.smethod_23();
		p68 = game.smethod_23();
		p58 = game.smethod_23();
		p48 = game.smethod_23();
		p38 = game.smethod_23();
		p28 = game.smethod_23();
		p81 = game.smethod_23();
		board = game.smethod_23();
		label3 = game.smethod_22();
		chey_hod = game.smethod_22();
		label4 = game.smethod_22();
		label5 = game.smethod_22();
		pictureBox1 = game.smethod_23();
		label6 = game.smethod_22();
		label7 = game.smethod_22();
		button3 = game.smethod_21();
		button4 = game.smethod_21();
		pictureBox2 = game.smethod_23();
		button5 = game.smethod_21();
		pictureBox3 = game.smethod_23();
		pictureBox4 = game.smethod_23();
		pictureBox5 = game.smethod_23();
		pictureBox6 = game.smethod_23();
		pictureBox7 = game.smethod_23();
		pictureBox8 = game.smethod_23();
		pictureBox9 = game.smethod_23();
		pictureBox10 = game.smethod_23();
		pictureBox11 = game.smethod_23();
		pictureBox12 = game.smethod_23();
		pictureBox13 = game.smethod_23();
		pictureBox14 = game.smethod_23();
		pictureBox15 = game.smethod_23();
		pictureBox16 = game.smethod_23();
		pictureBox17 = game.smethod_23();
		pictureBox18 = game.smethod_23();
		pictureBox19 = game.smethod_23();
		pictureBox20 = game.smethod_23();
		pictureBox21 = game.smethod_23();
		pictureBox22 = game.smethod_23();
		pictureBox23 = game.smethod_23();
		pictureBox24 = game.smethod_23();
		pictureBox25 = game.smethod_23();
		pictureBox26 = game.smethod_23();
		pictureBox27 = game.smethod_23();
		pictureBox28 = game.smethod_23();
		pictureBox29 = game.smethod_23();
		pictureBox30 = game.smethod_23();
		pictureBox31 = game.smethod_23();
		timer3 = game.smethod_20(components);
		timer4 = game.smethod_20(components);
		pictureBox32 = game.smethod_23();
		pictureBox33 = game.smethod_23();
		pictureBox34 = game.smethod_23();
		pictureBox35 = game.smethod_23();
		pictureBox36 = game.smethod_23();
		pictureBox37 = game.smethod_23();
		pictureBox38 = game.smethod_23();
		pictureBox39 = game.smethod_23();
		pictureBox40 = game.smethod_23();
		pictureBox41 = game.smethod_23();
		pictureBox42 = game.smethod_23();
		pictureBox43 = game.smethod_23();
		pictureBox44 = game.smethod_23();
		pictureBox45 = game.smethod_23();
		pictureBox46 = game.smethod_23();
		pictureBox47 = game.smethod_23();
		pictureBox48 = game.smethod_23();
		pictureBox49 = game.smethod_23();
		pictureBox50 = game.smethod_23();
		pictureBox51 = game.smethod_23();
		pictureBox52 = game.smethod_23();
		pictureBox53 = game.smethod_23();
		pictureBox54 = game.smethod_23();
		pictureBox55 = game.smethod_23();
		pictureBox56 = game.smethod_23();
		pictureBox57 = game.smethod_23();
		pictureBox58 = game.smethod_23();
		pictureBox59 = game.smethod_23();
		pictureBox60 = game.smethod_23();
		pictureBox61 = game.smethod_23();
		pictureBox62 = game.smethod_23();
		pictureBox63 = game.smethod_23();
		pictureBox64 = game.smethod_23();
		pictureBox65 = game.smethod_23();
		pictureBox66 = game.smethod_23();
		pictureBox67 = game.smethod_23();
		game.smethod_24((ISupportInitialize)selected);
		game.smethod_24((ISupportInitialize)p85);
		game.smethod_24((ISupportInitialize)p_81);
		game.smethod_24((ISupportInitialize)p71);
		game.smethod_24((ISupportInitialize)p61);
		game.smethod_24((ISupportInitialize)p51);
		game.smethod_24((ISupportInitialize)p41);
		game.smethod_24((ISupportInitialize)p31);
		game.smethod_24((ISupportInitialize)p21);
		game.smethod_24((ISupportInitialize)p11);
		game.smethod_24((ISupportInitialize)p82);
		game.smethod_24((ISupportInitialize)p72);
		game.smethod_24((ISupportInitialize)p62);
		game.smethod_24((ISupportInitialize)p52);
		game.smethod_24((ISupportInitialize)p42);
		game.smethod_24((ISupportInitialize)p32);
		game.smethod_24((ISupportInitialize)p22);
		game.smethod_24((ISupportInitialize)p12);
		game.smethod_24((ISupportInitialize)p83);
		game.smethod_24((ISupportInitialize)p73);
		game.smethod_24((ISupportInitialize)p63);
		game.smethod_24((ISupportInitialize)p53);
		game.smethod_24((ISupportInitialize)p43);
		game.smethod_24((ISupportInitialize)p33);
		game.smethod_24((ISupportInitialize)p23);
		game.smethod_24((ISupportInitialize)p13);
		game.smethod_24((ISupportInitialize)p84);
		game.smethod_24((ISupportInitialize)p74);
		game.smethod_24((ISupportInitialize)p64);
		game.smethod_24((ISupportInitialize)p54);
		game.smethod_24((ISupportInitialize)p44);
		game.smethod_24((ISupportInitialize)p34);
		game.smethod_24((ISupportInitialize)p24);
		game.smethod_24((ISupportInitialize)p14);
		game.smethod_24((ISupportInitialize)p18);
		game.smethod_24((ISupportInitialize)p75);
		game.smethod_24((ISupportInitialize)p65);
		game.smethod_24((ISupportInitialize)p55);
		game.smethod_24((ISupportInitialize)p45);
		game.smethod_24((ISupportInitialize)p35);
		game.smethod_24((ISupportInitialize)p25);
		game.smethod_24((ISupportInitialize)p15);
		game.smethod_24((ISupportInitialize)p86);
		game.smethod_24((ISupportInitialize)p76);
		game.smethod_24((ISupportInitialize)p66);
		game.smethod_24((ISupportInitialize)p56);
		game.smethod_24((ISupportInitialize)p46);
		game.smethod_24((ISupportInitialize)p36);
		game.smethod_24((ISupportInitialize)p26);
		game.smethod_24((ISupportInitialize)p16);
		game.smethod_24((ISupportInitialize)p87);
		game.smethod_24((ISupportInitialize)p77);
		game.smethod_24((ISupportInitialize)p67);
		game.smethod_24((ISupportInitialize)p57);
		game.smethod_24((ISupportInitialize)p47);
		game.smethod_24((ISupportInitialize)p37);
		game.smethod_24((ISupportInitialize)p27);
		game.smethod_24((ISupportInitialize)p17);
		game.smethod_24((ISupportInitialize)p88);
		game.smethod_24((ISupportInitialize)p78);
		game.smethod_24((ISupportInitialize)p68);
		game.smethod_24((ISupportInitialize)p58);
		game.smethod_24((ISupportInitialize)p48);
		game.smethod_24((ISupportInitialize)p38);
		game.smethod_24((ISupportInitialize)p28);
		game.smethod_24((ISupportInitialize)p81);
		game.smethod_24((ISupportInitialize)board);
		game.smethod_24((ISupportInitialize)pictureBox1);
		game.smethod_24((ISupportInitialize)pictureBox2);
		game.smethod_24((ISupportInitialize)pictureBox3);
		game.smethod_24((ISupportInitialize)pictureBox4);
		game.smethod_24((ISupportInitialize)pictureBox5);
		game.smethod_24((ISupportInitialize)pictureBox6);
		game.smethod_24((ISupportInitialize)pictureBox7);
		game.smethod_24((ISupportInitialize)pictureBox8);
		game.smethod_24((ISupportInitialize)pictureBox9);
		game.smethod_24((ISupportInitialize)pictureBox10);
		game.smethod_24((ISupportInitialize)pictureBox11);
		game.smethod_24((ISupportInitialize)pictureBox12);
		game.smethod_24((ISupportInitialize)pictureBox13);
		game.smethod_24((ISupportInitialize)pictureBox14);
		game.smethod_24((ISupportInitialize)pictureBox15);
		game.smethod_24((ISupportInitialize)pictureBox16);
		game.smethod_24((ISupportInitialize)pictureBox17);
		game.smethod_24((ISupportInitialize)pictureBox18);
		game.smethod_24((ISupportInitialize)pictureBox19);
		game.smethod_24((ISupportInitialize)pictureBox20);
		game.smethod_24((ISupportInitialize)pictureBox21);
		game.smethod_24((ISupportInitialize)pictureBox22);
		game.smethod_24((ISupportInitialize)pictureBox23);
		game.smethod_24((ISupportInitialize)pictureBox24);
		game.smethod_24((ISupportInitialize)pictureBox25);
		game.smethod_24((ISupportInitialize)pictureBox26);
		game.smethod_24((ISupportInitialize)pictureBox27);
		game.smethod_24((ISupportInitialize)pictureBox28);
		game.smethod_24((ISupportInitialize)pictureBox29);
		game.smethod_24((ISupportInitialize)pictureBox30);
		game.smethod_24((ISupportInitialize)pictureBox31);
		game.smethod_24((ISupportInitialize)pictureBox32);
		game.smethod_24((ISupportInitialize)pictureBox33);
		game.smethod_24((ISupportInitialize)pictureBox34);
		game.smethod_24((ISupportInitialize)pictureBox35);
		game.smethod_24((ISupportInitialize)pictureBox36);
		game.smethod_24((ISupportInitialize)pictureBox37);
		game.smethod_24((ISupportInitialize)pictureBox38);
		game.smethod_24((ISupportInitialize)pictureBox39);
		game.smethod_24((ISupportInitialize)pictureBox40);
		game.smethod_24((ISupportInitialize)pictureBox41);
		game.smethod_24((ISupportInitialize)pictureBox42);
		game.smethod_24((ISupportInitialize)pictureBox43);
		game.smethod_24((ISupportInitialize)pictureBox44);
		game.smethod_24((ISupportInitialize)pictureBox45);
		game.smethod_24((ISupportInitialize)pictureBox46);
		game.smethod_24((ISupportInitialize)pictureBox47);
		game.smethod_24((ISupportInitialize)pictureBox48);
		game.smethod_24((ISupportInitialize)pictureBox49);
		game.smethod_24((ISupportInitialize)pictureBox50);
		game.smethod_24((ISupportInitialize)pictureBox51);
		game.smethod_24((ISupportInitialize)pictureBox52);
		game.smethod_24((ISupportInitialize)pictureBox53);
		game.smethod_24((ISupportInitialize)pictureBox54);
		game.smethod_24((ISupportInitialize)pictureBox55);
		game.smethod_24((ISupportInitialize)pictureBox56);
		game.smethod_24((ISupportInitialize)pictureBox57);
		game.smethod_24((ISupportInitialize)pictureBox58);
		game.smethod_24((ISupportInitialize)pictureBox59);
		game.smethod_24((ISupportInitialize)pictureBox60);
		game.smethod_24((ISupportInitialize)pictureBox61);
		game.smethod_24((ISupportInitialize)pictureBox62);
		game.smethod_24((ISupportInitialize)pictureBox63);
		game.smethod_24((ISupportInitialize)pictureBox64);
		game.smethod_24((ISupportInitialize)pictureBox65);
		game.smethod_24((ISupportInitialize)pictureBox66);
		game.smethod_24((ISupportInitialize)pictureBox67);
		game.smethod_25((Control)(object)this);
		game.smethod_26(timer1, (EventHandler)timer1_Tick);
		game.smethod_26(timer2, (EventHandler)timer2_Tick);
		game.smethod_28((Control)(object)exit, game.smethod_27("Microsoft Sans Serif", 28.25f));
		game.smethod_29((Control)(object)exit, new Point(990, 12));
		game.smethod_30((Control)(object)exit, "exit");
		game.smethod_31((Control)(object)exit, new Size(188, 47));
		game.smethod_32((Control)(object)exit, 65);
		game.smethod_3((Control)(object)exit, "ВЫХОД");
		game.smethod_33((ButtonBase)(object)exit, bool_0: true);
		game.smethod_34((Control)(object)exit, (EventHandler)exit_Click);
		game.smethod_5((Control)(object)button1, game.smethod_35());
		game.smethod_29((Control)(object)button1, new Point(768, 445));
		game.smethod_30((Control)(object)button1, "button1");
		game.smethod_31((Control)(object)button1, new Size(120, 78));
		game.smethod_32((Control)(object)button1, 67);
		game.smethod_33((ButtonBase)(object)button1, bool_0: false);
		game.smethod_1((Control)(object)button1, bool_0: false);
		game.smethod_34((Control)(object)button1, (EventHandler)button1_Click);
		game.smethod_5((Control)(object)button2, game.smethod_35());
		game.smethod_29((Control)(object)button2, new Point(768, 118));
		game.smethod_30((Control)(object)button2, "button2");
		game.smethod_31((Control)(object)button2, new Size(120, 78));
		game.smethod_32((Control)(object)button2, 68);
		game.smethod_33((ButtonBase)(object)button2, bool_0: false);
		game.smethod_1((Control)(object)button2, bool_0: false);
		game.smethod_34((Control)(object)button2, (EventHandler)button2_Click);
		game.smethod_36((Control)(object)label1, bool_0: true);
		game.smethod_28((Control)(object)label1, game.smethod_27("Microsoft Sans Serif", 38.25f));
		game.smethod_29((Control)(object)label1, new Point(777, 341));
		game.smethod_30((Control)(object)label1, "label1");
		game.smethod_31((Control)(object)label1, new Size(95, 59));
		game.smethod_32((Control)(object)label1, 69);
		game.smethod_3((Control)(object)label1, "0:0");
		game.smethod_1((Control)(object)label1, bool_0: false);
		game.smethod_36((Control)(object)label2, bool_0: true);
		game.smethod_28((Control)(object)label2, game.smethod_27("Microsoft Sans Serif", 38.25f));
		game.smethod_29((Control)(object)label2, new Point(777, 225));
		game.smethod_30((Control)(object)label2, "label2");
		game.smethod_31((Control)(object)label2, new Size(95, 59));
		game.smethod_32((Control)(object)label2, 70);
		game.smethod_3((Control)(object)label2, "0:0");
		game.smethod_1((Control)(object)label2, bool_0: false);
		game.smethod_34((Control)(object)label2, (EventHandler)label2_Click);
		game.smethod_37((Control)(object)selected, (ImageLayout)4);
		game.smethod_29((Control)(object)selected, new Point(1061, 521));
		game.smethod_30((Control)(object)selected, "selected");
		game.smethod_31((Control)(object)selected, new Size(130, 130));
		game.smethod_38(selected, 71);
		game.smethod_39(selected, bool_0: false);
		game.smethod_5((Control)(object)p85, Color.White);
		game.smethod_37((Control)(object)p85, (ImageLayout)4);
		game.smethod_29((Control)(object)p85, new Point(560, 280));
		game.smethod_40((Control)(object)p85, new Padding(0));
		game.smethod_30((Control)(object)p85, "p85");
		game.smethod_31((Control)(object)p85, new Size(70, 70));
		game.smethod_38(p85, 66);
		game.smethod_39(p85, bool_0: false);
		game.smethod_34((Control)(object)p85, (EventHandler)p85_Click);
		game.smethod_5((Control)(object)p_81, Color.White);
		game.smethod_37((Control)(object)p_81, (ImageLayout)4);
		game.smethod_29((Control)(object)p_81, new Point(560, 560));
		game.smethod_40((Control)(object)p_81, new Padding(0));
		game.smethod_30((Control)(object)p_81, "p_81");
		game.smethod_31((Control)(object)p_81, new Size(70, 70));
		game.smethod_38(p_81, 64);
		game.smethod_39(p_81, bool_0: false);
		game.smethod_34((Control)(object)p_81, (EventHandler)p_81_Click);
		game.smethod_5((Control)(object)p71, Color.DimGray);
		game.smethod_37((Control)(object)p71, (ImageLayout)4);
		game.smethod_29((Control)(object)p71, new Point(490, 560));
		game.smethod_40((Control)(object)p71, new Padding(0));
		game.smethod_30((Control)(object)p71, "p71");
		game.smethod_31((Control)(object)p71, new Size(70, 70));
		game.smethod_38(p71, 63);
		game.smethod_39(p71, bool_0: false);
		game.smethod_34((Control)(object)p71, (EventHandler)p71_Click);
		game.smethod_5((Control)(object)p61, Color.White);
		game.smethod_37((Control)(object)p61, (ImageLayout)4);
		game.smethod_29((Control)(object)p61, new Point(420, 560));
		game.smethod_40((Control)(object)p61, new Padding(0));
		game.smethod_30((Control)(object)p61, "p61");
		game.smethod_31((Control)(object)p61, new Size(70, 70));
		game.smethod_38(p61, 62);
		game.smethod_39(p61, bool_0: false);
		game.smethod_34((Control)(object)p61, (EventHandler)p61_Click);
		game.smethod_5((Control)(object)p51, Color.DimGray);
		game.smethod_37((Control)(object)p51, (ImageLayout)4);
		game.smethod_29((Control)(object)p51, new Point(350, 560));
		game.smethod_40((Control)(object)p51, new Padding(0));
		game.smethod_30((Control)(object)p51, "p51");
		game.smethod_31((Control)(object)p51, new Size(70, 70));
		game.smethod_38(p51, 61);
		game.smethod_39(p51, bool_0: false);
		game.smethod_34((Control)(object)p51, (EventHandler)p51_Click);
		game.smethod_5((Control)(object)p41, Color.White);
		game.smethod_37((Control)(object)p41, (ImageLayout)4);
		game.smethod_29((Control)(object)p41, new Point(280, 560));
		game.smethod_40((Control)(object)p41, new Padding(0));
		game.smethod_30((Control)(object)p41, "p41");
		game.smethod_31((Control)(object)p41, new Size(70, 70));
		game.smethod_38(p41, 60);
		game.smethod_39(p41, bool_0: false);
		game.smethod_34((Control)(object)p41, (EventHandler)p41_Click);
		game.smethod_5((Control)(object)p31, Color.DimGray);
		game.smethod_37((Control)(object)p31, (ImageLayout)4);
		game.smethod_29((Control)(object)p31, new Point(210, 560));
		game.smethod_40((Control)(object)p31, new Padding(0));
		game.smethod_30((Control)(object)p31, "p31");
		game.smethod_31((Control)(object)p31, new Size(70, 70));
		game.smethod_38(p31, 59);
		game.smethod_39(p31, bool_0: false);
		game.smethod_34((Control)(object)p31, (EventHandler)p31_Click);
		game.smethod_5((Control)(object)p21, Color.White);
		game.smethod_37((Control)(object)p21, (ImageLayout)4);
		game.smethod_29((Control)(object)p21, new Point(140, 560));
		game.smethod_40((Control)(object)p21, new Padding(0));
		game.smethod_30((Control)(object)p21, "p21");
		game.smethod_31((Control)(object)p21, new Size(70, 70));
		game.smethod_38(p21, 58);
		game.smethod_39(p21, bool_0: false);
		game.smethod_34((Control)(object)p21, (EventHandler)p21_Click);
		game.smethod_5((Control)(object)p11, Color.DimGray);
		game.smethod_37((Control)(object)p11, (ImageLayout)4);
		game.smethod_29((Control)(object)p11, new Point(70, 560));
		game.smethod_40((Control)(object)p11, new Padding(0));
		game.smethod_30((Control)(object)p11, "p11");
		game.smethod_31((Control)(object)p11, new Size(70, 70));
		game.smethod_38(p11, 57);
		game.smethod_39(p11, bool_0: false);
		game.smethod_34((Control)(object)p11, (EventHandler)p11_Click);
		game.smethod_5((Control)(object)p82, Color.DimGray);
		game.smethod_37((Control)(object)p82, (ImageLayout)4);
		game.smethod_29((Control)(object)p82, new Point(560, 490));
		game.smethod_40((Control)(object)p82, new Padding(0));
		game.smethod_30((Control)(object)p82, "p82");
		game.smethod_31((Control)(object)p82, new Size(70, 70));
		game.smethod_38(p82, 56);
		game.smethod_39(p82, bool_0: false);
		game.smethod_34((Control)(object)p82, (EventHandler)p82_Click_1);
		game.smethod_5((Control)(object)p72, Color.White);
		game.smethod_37((Control)(object)p72, (ImageLayout)4);
		game.smethod_29((Control)(object)p72, new Point(490, 490));
		game.smethod_40((Control)(object)p72, new Padding(0));
		game.smethod_30((Control)(object)p72, "p72");
		game.smethod_31((Control)(object)p72, new Size(70, 70));
		game.smethod_38(p72, 55);
		game.smethod_39(p72, bool_0: false);
		game.smethod_34((Control)(object)p72, (EventHandler)p72_Click);
		game.smethod_5((Control)(object)p62, Color.DimGray);
		game.smethod_37((Control)(object)p62, (ImageLayout)4);
		game.smethod_29((Control)(object)p62, new Point(420, 490));
		game.smethod_40((Control)(object)p62, new Padding(0));
		game.smethod_30((Control)(object)p62, "p62");
		game.smethod_31((Control)(object)p62, new Size(70, 70));
		game.smethod_38(p62, 54);
		game.smethod_39(p62, bool_0: false);
		game.smethod_34((Control)(object)p62, (EventHandler)p62_Click);
		game.smethod_5((Control)(object)p52, Color.White);
		game.smethod_37((Control)(object)p52, (ImageLayout)4);
		game.smethod_29((Control)(object)p52, new Point(350, 490));
		game.smethod_40((Control)(object)p52, new Padding(0));
		game.smethod_30((Control)(object)p52, "p52");
		game.smethod_31((Control)(object)p52, new Size(70, 70));
		game.smethod_38(p52, 53);
		game.smethod_39(p52, bool_0: false);
		game.smethod_34((Control)(object)p52, (EventHandler)p52_Click);
		game.smethod_5((Control)(object)p42, Color.DimGray);
		game.smethod_37((Control)(object)p42, (ImageLayout)4);
		game.smethod_29((Control)(object)p42, new Point(280, 490));
		game.smethod_40((Control)(object)p42, new Padding(0));
		game.smethod_30((Control)(object)p42, "p42");
		game.smethod_31((Control)(object)p42, new Size(70, 70));
		game.smethod_38(p42, 52);
		game.smethod_39(p42, bool_0: false);
		game.smethod_34((Control)(object)p42, (EventHandler)p42_Click);
		game.smethod_5((Control)(object)p32, Color.White);
		game.smethod_37((Control)(object)p32, (ImageLayout)4);
		game.smethod_29((Control)(object)p32, new Point(210, 490));
		game.smethod_40((Control)(object)p32, new Padding(0));
		game.smethod_30((Control)(object)p32, "p32");
		game.smethod_31((Control)(object)p32, new Size(70, 70));
		game.smethod_38(p32, 51);
		game.smethod_39(p32, bool_0: false);
		game.smethod_34((Control)(object)p32, (EventHandler)p32_Click);
		game.smethod_5((Control)(object)p22, Color.DimGray);
		game.smethod_37((Control)(object)p22, (ImageLayout)4);
		game.smethod_29((Control)(object)p22, new Point(140, 490));
		game.smethod_40((Control)(object)p22, new Padding(0));
		game.smethod_30((Control)(object)p22, "p22");
		game.smethod_31((Control)(object)p22, new Size(70, 70));
		game.smethod_38(p22, 50);
		game.smethod_39(p22, bool_0: false);
		game.smethod_34((Control)(object)p22, (EventHandler)p22_Click);
		game.smethod_5((Control)(object)p12, Color.White);
		game.smethod_37((Control)(object)p12, (ImageLayout)4);
		game.smethod_29((Control)(object)p12, new Point(70, 490));
		game.smethod_40((Control)(object)p12, new Padding(0));
		game.smethod_30((Control)(object)p12, "p12");
		game.smethod_31((Control)(object)p12, new Size(70, 70));
		game.smethod_38(p12, 49);
		game.smethod_39(p12, bool_0: false);
		game.smethod_34((Control)(object)p12, (EventHandler)p12_Click);
		game.smethod_5((Control)(object)p83, Color.White);
		game.smethod_37((Control)(object)p83, (ImageLayout)4);
		game.smethod_29((Control)(object)p83, new Point(560, 420));
		game.smethod_40((Control)(object)p83, new Padding(0));
		game.smethod_30((Control)(object)p83, "p83");
		game.smethod_31((Control)(object)p83, new Size(70, 70));
		game.smethod_38(p83, 48);
		game.smethod_39(p83, bool_0: false);
		game.smethod_34((Control)(object)p83, (EventHandler)p83_Click);
		game.smethod_5((Control)(object)p73, Color.DimGray);
		game.smethod_37((Control)(object)p73, (ImageLayout)4);
		game.smethod_29((Control)(object)p73, new Point(490, 420));
		game.smethod_40((Control)(object)p73, new Padding(0));
		game.smethod_30((Control)(object)p73, "p73");
		game.smethod_31((Control)(object)p73, new Size(70, 70));
		game.smethod_38(p73, 47);
		game.smethod_39(p73, bool_0: false);
		game.smethod_34((Control)(object)p73, (EventHandler)p73_Click);
		game.smethod_5((Control)(object)p63, Color.White);
		game.smethod_37((Control)(object)p63, (ImageLayout)4);
		game.smethod_29((Control)(object)p63, new Point(420, 420));
		game.smethod_40((Control)(object)p63, new Padding(0));
		game.smethod_30((Control)(object)p63, "p63");
		game.smethod_31((Control)(object)p63, new Size(70, 70));
		game.smethod_38(p63, 46);
		game.smethod_39(p63, bool_0: false);
		game.smethod_34((Control)(object)p63, (EventHandler)p63_Click);
		game.smethod_5((Control)(object)p53, Color.DimGray);
		game.smethod_37((Control)(object)p53, (ImageLayout)4);
		game.smethod_29((Control)(object)p53, new Point(350, 420));
		game.smethod_40((Control)(object)p53, new Padding(0));
		game.smethod_30((Control)(object)p53, "p53");
		game.smethod_31((Control)(object)p53, new Size(70, 70));
		game.smethod_38(p53, 45);
		game.smethod_39(p53, bool_0: false);
		game.smethod_34((Control)(object)p53, (EventHandler)p53_Click);
		game.smethod_5((Control)(object)p43, Color.White);
		game.smethod_37((Control)(object)p43, (ImageLayout)4);
		game.smethod_29((Control)(object)p43, new Point(280, 420));
		game.smethod_40((Control)(object)p43, new Padding(0));
		game.smethod_30((Control)(object)p43, "p43");
		game.smethod_31((Control)(object)p43, new Size(70, 70));
		game.smethod_38(p43, 44);
		game.smethod_39(p43, bool_0: false);
		game.smethod_34((Control)(object)p43, (EventHandler)p43_Click);
		game.smethod_5((Control)(object)p33, Color.DimGray);
		game.smethod_37((Control)(object)p33, (ImageLayout)4);
		game.smethod_29((Control)(object)p33, new Point(210, 420));
		game.smethod_40((Control)(object)p33, new Padding(0));
		game.smethod_30((Control)(object)p33, "p33");
		game.smethod_31((Control)(object)p33, new Size(70, 70));
		game.smethod_38(p33, 43);
		game.smethod_39(p33, bool_0: false);
		game.smethod_34((Control)(object)p33, (EventHandler)p33_Click);
		game.smethod_5((Control)(object)p23, Color.White);
		game.smethod_37((Control)(object)p23, (ImageLayout)4);
		game.smethod_29((Control)(object)p23, new Point(140, 420));
		game.smethod_40((Control)(object)p23, new Padding(0));
		game.smethod_30((Control)(object)p23, "p23");
		game.smethod_31((Control)(object)p23, new Size(70, 70));
		game.smethod_38(p23, 42);
		game.smethod_39(p23, bool_0: false);
		game.smethod_34((Control)(object)p23, (EventHandler)p23_Click);
		game.smethod_5((Control)(object)p13, Color.DimGray);
		game.smethod_37((Control)(object)p13, (ImageLayout)4);
		game.smethod_29((Control)(object)p13, new Point(70, 420));
		game.smethod_40((Control)(object)p13, new Padding(0));
		game.smethod_30((Control)(object)p13, "p13");
		game.smethod_31((Control)(object)p13, new Size(70, 70));
		game.smethod_38(p13, 41);
		game.smethod_39(p13, bool_0: false);
		game.smethod_34((Control)(object)p13, (EventHandler)p13_Click);
		game.smethod_5((Control)(object)p84, Color.DimGray);
		game.smethod_37((Control)(object)p84, (ImageLayout)4);
		game.smethod_29((Control)(object)p84, new Point(560, 350));
		game.smethod_40((Control)(object)p84, new Padding(0));
		game.smethod_30((Control)(object)p84, "p84");
		game.smethod_31((Control)(object)p84, new Size(70, 70));
		game.smethod_38(p84, 40);
		game.smethod_39(p84, bool_0: false);
		game.smethod_34((Control)(object)p84, (EventHandler)p84_Click);
		game.smethod_5((Control)(object)p74, Color.White);
		game.smethod_37((Control)(object)p74, (ImageLayout)4);
		game.smethod_29((Control)(object)p74, new Point(490, 350));
		game.smethod_40((Control)(object)p74, new Padding(0));
		game.smethod_30((Control)(object)p74, "p74");
		game.smethod_31((Control)(object)p74, new Size(70, 70));
		game.smethod_38(p74, 39);
		game.smethod_39(p74, bool_0: false);
		game.smethod_34((Control)(object)p74, (EventHandler)p74_Click);
		game.smethod_5((Control)(object)p64, Color.DimGray);
		game.smethod_37((Control)(object)p64, (ImageLayout)4);
		game.smethod_29((Control)(object)p64, new Point(420, 350));
		game.smethod_40((Control)(object)p64, new Padding(0));
		game.smethod_30((Control)(object)p64, "p64");
		game.smethod_31((Control)(object)p64, new Size(70, 70));
		game.smethod_38(p64, 38);
		game.smethod_39(p64, bool_0: false);
		game.smethod_34((Control)(object)p64, (EventHandler)p64_Click);
		game.smethod_5((Control)(object)p54, Color.White);
		game.smethod_37((Control)(object)p54, (ImageLayout)4);
		game.smethod_29((Control)(object)p54, new Point(350, 350));
		game.smethod_40((Control)(object)p54, new Padding(0));
		game.smethod_30((Control)(object)p54, "p54");
		game.smethod_31((Control)(object)p54, new Size(70, 70));
		game.smethod_38(p54, 37);
		game.smethod_39(p54, bool_0: false);
		game.smethod_34((Control)(object)p54, (EventHandler)p54_Click);
		game.smethod_5((Control)(object)p44, Color.DimGray);
		game.smethod_37((Control)(object)p44, (ImageLayout)4);
		game.smethod_29((Control)(object)p44, new Point(280, 350));
		game.smethod_40((Control)(object)p44, new Padding(0));
		game.smethod_30((Control)(object)p44, "p44");
		game.smethod_31((Control)(object)p44, new Size(70, 70));
		game.smethod_38(p44, 36);
		game.smethod_39(p44, bool_0: false);
		game.smethod_34((Control)(object)p44, (EventHandler)p44_Click);
		game.smethod_5((Control)(object)p34, Color.White);
		game.smethod_37((Control)(object)p34, (ImageLayout)4);
		game.smethod_29((Control)(object)p34, new Point(210, 350));
		game.smethod_40((Control)(object)p34, new Padding(0));
		game.smethod_30((Control)(object)p34, "p34");
		game.smethod_31((Control)(object)p34, new Size(70, 70));
		game.smethod_38(p34, 35);
		game.smethod_39(p34, bool_0: false);
		game.smethod_34((Control)(object)p34, (EventHandler)p34_Click);
		game.smethod_5((Control)(object)p24, Color.DimGray);
		game.smethod_37((Control)(object)p24, (ImageLayout)4);
		game.smethod_29((Control)(object)p24, new Point(140, 350));
		game.smethod_40((Control)(object)p24, new Padding(0));
		game.smethod_30((Control)(object)p24, "p24");
		game.smethod_31((Control)(object)p24, new Size(70, 70));
		game.smethod_38(p24, 34);
		game.smethod_39(p24, bool_0: false);
		game.smethod_34((Control)(object)p24, (EventHandler)p24_Click);
		game.smethod_5((Control)(object)p14, Color.White);
		game.smethod_37((Control)(object)p14, (ImageLayout)4);
		game.smethod_29((Control)(object)p14, new Point(70, 350));
		game.smethod_40((Control)(object)p14, new Padding(0));
		game.smethod_30((Control)(object)p14, "p14");
		game.smethod_31((Control)(object)p14, new Size(70, 70));
		game.smethod_38(p14, 33);
		game.smethod_39(p14, bool_0: false);
		game.smethod_34((Control)(object)p14, (EventHandler)p14_Click);
		game.smethod_5((Control)(object)p18, Color.White);
		game.smethod_37((Control)(object)p18, (ImageLayout)4);
		game.smethod_29((Control)(object)p18, new Point(70, 70));
		game.smethod_40((Control)(object)p18, new Padding(0));
		game.smethod_30((Control)(object)p18, "p18");
		game.smethod_31((Control)(object)p18, new Size(70, 70));
		game.smethod_38(p18, 32);
		game.smethod_39(p18, bool_0: false);
		game.smethod_34((Control)(object)p18, (EventHandler)p18_Click);
		game.smethod_5((Control)(object)p75, Color.DimGray);
		game.smethod_37((Control)(object)p75, (ImageLayout)4);
		game.smethod_29((Control)(object)p75, new Point(490, 280));
		game.smethod_40((Control)(object)p75, new Padding(0));
		game.smethod_30((Control)(object)p75, "p75");
		game.smethod_31((Control)(object)p75, new Size(70, 70));
		game.smethod_38(p75, 31);
		game.smethod_39(p75, bool_0: false);
		game.smethod_34((Control)(object)p75, (EventHandler)p75_Click);
		game.smethod_5((Control)(object)p65, Color.White);
		game.smethod_37((Control)(object)p65, (ImageLayout)4);
		game.smethod_29((Control)(object)p65, new Point(420, 280));
		game.smethod_40((Control)(object)p65, new Padding(0));
		game.smethod_30((Control)(object)p65, "p65");
		game.smethod_31((Control)(object)p65, new Size(70, 70));
		game.smethod_38(p65, 30);
		game.smethod_39(p65, bool_0: false);
		game.smethod_34((Control)(object)p65, (EventHandler)p65_Click);
		game.smethod_5((Control)(object)p55, Color.DimGray);
		game.smethod_37((Control)(object)p55, (ImageLayout)4);
		game.smethod_29((Control)(object)p55, new Point(350, 280));
		game.smethod_40((Control)(object)p55, new Padding(0));
		game.smethod_30((Control)(object)p55, "p55");
		game.smethod_31((Control)(object)p55, new Size(70, 70));
		game.smethod_38(p55, 29);
		game.smethod_39(p55, bool_0: false);
		game.smethod_34((Control)(object)p55, (EventHandler)p55_Click);
		game.smethod_5((Control)(object)p45, Color.White);
		game.smethod_37((Control)(object)p45, (ImageLayout)4);
		game.smethod_29((Control)(object)p45, new Point(280, 280));
		game.smethod_40((Control)(object)p45, new Padding(0));
		game.smethod_30((Control)(object)p45, "p45");
		game.smethod_31((Control)(object)p45, new Size(70, 70));
		game.smethod_38(p45, 28);
		game.smethod_39(p45, bool_0: false);
		game.smethod_34((Control)(object)p45, (EventHandler)p45_Click);
		game.smethod_5((Control)(object)p35, Color.DimGray);
		game.smethod_37((Control)(object)p35, (ImageLayout)4);
		game.smethod_29((Control)(object)p35, new Point(210, 280));
		game.smethod_40((Control)(object)p35, new Padding(0));
		game.smethod_30((Control)(object)p35, "p35");
		game.smethod_31((Control)(object)p35, new Size(70, 70));
		game.smethod_38(p35, 27);
		game.smethod_39(p35, bool_0: false);
		game.smethod_34((Control)(object)p35, (EventHandler)p35_Click);
		game.smethod_5((Control)(object)p25, Color.White);
		game.smethod_37((Control)(object)p25, (ImageLayout)4);
		game.smethod_29((Control)(object)p25, new Point(140, 280));
		game.smethod_40((Control)(object)p25, new Padding(0));
		game.smethod_30((Control)(object)p25, "p25");
		game.smethod_31((Control)(object)p25, new Size(70, 70));
		game.smethod_38(p25, 26);
		game.smethod_39(p25, bool_0: false);
		game.smethod_34((Control)(object)p25, (EventHandler)p25_Click);
		game.smethod_5((Control)(object)p15, Color.DimGray);
		game.smethod_37((Control)(object)p15, (ImageLayout)4);
		game.smethod_29((Control)(object)p15, new Point(70, 280));
		game.smethod_40((Control)(object)p15, new Padding(0));
		game.smethod_30((Control)(object)p15, "p15");
		game.smethod_31((Control)(object)p15, new Size(70, 70));
		game.smethod_38(p15, 25);
		game.smethod_39(p15, bool_0: false);
		game.smethod_34((Control)(object)p15, (EventHandler)p15_Click);
		game.smethod_5((Control)(object)p86, Color.DimGray);
		game.smethod_37((Control)(object)p86, (ImageLayout)4);
		game.smethod_29((Control)(object)p86, new Point(560, 210));
		game.smethod_40((Control)(object)p86, new Padding(0));
		game.smethod_30((Control)(object)p86, "p86");
		game.smethod_31((Control)(object)p86, new Size(70, 70));
		game.smethod_38(p86, 24);
		game.smethod_39(p86, bool_0: false);
		game.smethod_34((Control)(object)p86, (EventHandler)p86_Click);
		game.smethod_5((Control)(object)p76, Color.White);
		game.smethod_37((Control)(object)p76, (ImageLayout)4);
		game.smethod_29((Control)(object)p76, new Point(490, 210));
		game.smethod_40((Control)(object)p76, new Padding(0));
		game.smethod_30((Control)(object)p76, "p76");
		game.smethod_31((Control)(object)p76, new Size(70, 70));
		game.smethod_38(p76, 23);
		game.smethod_39(p76, bool_0: false);
		game.smethod_34((Control)(object)p76, (EventHandler)p76_Click);
		game.smethod_5((Control)(object)p66, Color.DimGray);
		game.smethod_37((Control)(object)p66, (ImageLayout)4);
		game.smethod_29((Control)(object)p66, new Point(420, 210));
		game.smethod_40((Control)(object)p66, new Padding(0));
		game.smethod_30((Control)(object)p66, "p66");
		game.smethod_31((Control)(object)p66, new Size(70, 70));
		game.smethod_38(p66, 22);
		game.smethod_39(p66, bool_0: false);
		game.smethod_34((Control)(object)p66, (EventHandler)p66_Click);
		game.smethod_5((Control)(object)p56, Color.White);
		game.smethod_37((Control)(object)p56, (ImageLayout)4);
		game.smethod_29((Control)(object)p56, new Point(350, 210));
		game.smethod_40((Control)(object)p56, new Padding(0));
		game.smethod_30((Control)(object)p56, "p56");
		game.smethod_31((Control)(object)p56, new Size(70, 70));
		game.smethod_38(p56, 21);
		game.smethod_39(p56, bool_0: false);
		game.smethod_34((Control)(object)p56, (EventHandler)p56_Click);
		game.smethod_5((Control)(object)p46, Color.DimGray);
		game.smethod_37((Control)(object)p46, (ImageLayout)4);
		game.smethod_29((Control)(object)p46, new Point(280, 210));
		game.smethod_40((Control)(object)p46, new Padding(0));
		game.smethod_30((Control)(object)p46, "p46");
		game.smethod_31((Control)(object)p46, new Size(70, 70));
		game.smethod_38(p46, 20);
		game.smethod_39(p46, bool_0: false);
		game.smethod_34((Control)(object)p46, (EventHandler)p46_Click);
		game.smethod_5((Control)(object)p36, Color.White);
		game.smethod_37((Control)(object)p36, (ImageLayout)4);
		game.smethod_29((Control)(object)p36, new Point(210, 210));
		game.smethod_40((Control)(object)p36, new Padding(0));
		game.smethod_30((Control)(object)p36, "p36");
		game.smethod_31((Control)(object)p36, new Size(70, 70));
		game.smethod_38(p36, 19);
		game.smethod_39(p36, bool_0: false);
		game.smethod_34((Control)(object)p36, (EventHandler)p36_Click);
		game.smethod_5((Control)(object)p26, Color.DimGray);
		game.smethod_37((Control)(object)p26, (ImageLayout)4);
		game.smethod_29((Control)(object)p26, new Point(140, 210));
		game.smethod_40((Control)(object)p26, new Padding(0));
		game.smethod_30((Control)(object)p26, "p26");
		game.smethod_31((Control)(object)p26, new Size(70, 70));
		game.smethod_38(p26, 18);
		game.smethod_39(p26, bool_0: false);
		game.smethod_34((Control)(object)p26, (EventHandler)p26_Click);
		game.smethod_5((Control)(object)p16, Color.White);
		game.smethod_37((Control)(object)p16, (ImageLayout)4);
		game.smethod_29((Control)(object)p16, new Point(70, 210));
		game.smethod_40((Control)(object)p16, new Padding(0));
		game.smethod_30((Control)(object)p16, "p16");
		game.smethod_31((Control)(object)p16, new Size(70, 70));
		game.smethod_38(p16, 17);
		game.smethod_39(p16, bool_0: false);
		game.smethod_34((Control)(object)p16, (EventHandler)p16_Click);
		game.smethod_5((Control)(object)p87, Color.White);
		game.smethod_37((Control)(object)p87, (ImageLayout)4);
		game.smethod_29((Control)(object)p87, new Point(560, 140));
		game.smethod_40((Control)(object)p87, new Padding(0));
		game.smethod_30((Control)(object)p87, "p87");
		game.smethod_31((Control)(object)p87, new Size(70, 70));
		game.smethod_38(p87, 16);
		game.smethod_39(p87, bool_0: false);
		game.smethod_34((Control)(object)p87, (EventHandler)p87_Click);
		game.smethod_5((Control)(object)p77, Color.DimGray);
		game.smethod_37((Control)(object)p77, (ImageLayout)4);
		game.smethod_29((Control)(object)p77, new Point(490, 140));
		game.smethod_40((Control)(object)p77, new Padding(0));
		game.smethod_30((Control)(object)p77, "p77");
		game.smethod_31((Control)(object)p77, new Size(70, 70));
		game.smethod_38(p77, 15);
		game.smethod_39(p77, bool_0: false);
		game.smethod_34((Control)(object)p77, (EventHandler)p77_Click);
		game.smethod_5((Control)(object)p67, Color.White);
		game.smethod_37((Control)(object)p67, (ImageLayout)4);
		game.smethod_29((Control)(object)p67, new Point(420, 140));
		game.smethod_40((Control)(object)p67, new Padding(0));
		game.smethod_30((Control)(object)p67, "p67");
		game.smethod_31((Control)(object)p67, new Size(70, 70));
		game.smethod_38(p67, 14);
		game.smethod_39(p67, bool_0: false);
		game.smethod_34((Control)(object)p67, (EventHandler)p67_Click);
		game.smethod_5((Control)(object)p57, Color.DimGray);
		game.smethod_37((Control)(object)p57, (ImageLayout)4);
		game.smethod_29((Control)(object)p57, new Point(350, 140));
		game.smethod_40((Control)(object)p57, new Padding(0));
		game.smethod_30((Control)(object)p57, "p57");
		game.smethod_31((Control)(object)p57, new Size(70, 70));
		game.smethod_38(p57, 13);
		game.smethod_39(p57, bool_0: false);
		game.smethod_34((Control)(object)p57, (EventHandler)p57_Click);
		game.smethod_5((Control)(object)p47, Color.White);
		game.smethod_37((Control)(object)p47, (ImageLayout)4);
		game.smethod_29((Control)(object)p47, new Point(280, 140));
		game.smethod_40((Control)(object)p47, new Padding(0));
		game.smethod_30((Control)(object)p47, "p47");
		game.smethod_31((Control)(object)p47, new Size(70, 70));
		game.smethod_38(p47, 12);
		game.smethod_39(p47, bool_0: false);
		game.smethod_34((Control)(object)p47, (EventHandler)p47_Click);
		game.smethod_5((Control)(object)p37, Color.DimGray);
		game.smethod_37((Control)(object)p37, (ImageLayout)4);
		game.smethod_29((Control)(object)p37, new Point(210, 140));
		game.smethod_40((Control)(object)p37, new Padding(0));
		game.smethod_30((Control)(object)p37, "p37");
		game.smethod_31((Control)(object)p37, new Size(70, 70));
		game.smethod_38(p37, 11);
		game.smethod_39(p37, bool_0: false);
		game.smethod_34((Control)(object)p37, (EventHandler)p37_Click);
		game.smethod_5((Control)(object)p27, Color.White);
		game.smethod_37((Control)(object)p27, (ImageLayout)4);
		game.smethod_29((Control)(object)p27, new Point(140, 140));
		game.smethod_40((Control)(object)p27, new Padding(0));
		game.smethod_30((Control)(object)p27, "p27");
		game.smethod_31((Control)(object)p27, new Size(70, 70));
		game.smethod_38(p27, 10);
		game.smethod_39(p27, bool_0: false);
		game.smethod_34((Control)(object)p27, (EventHandler)p27_Click);
		game.smethod_5((Control)(object)p17, Color.DimGray);
		game.smethod_37((Control)(object)p17, (ImageLayout)4);
		game.smethod_29((Control)(object)p17, new Point(70, 140));
		game.smethod_40((Control)(object)p17, new Padding(0));
		game.smethod_30((Control)(object)p17, "p17");
		game.smethod_31((Control)(object)p17, new Size(70, 70));
		game.smethod_38(p17, 9);
		game.smethod_39(p17, bool_0: false);
		game.smethod_34((Control)(object)p17, (EventHandler)p17_Click);
		game.smethod_5((Control)(object)p88, Color.DimGray);
		game.smethod_37((Control)(object)p88, (ImageLayout)4);
		game.smethod_29((Control)(object)p88, new Point(560, 70));
		game.smethod_40((Control)(object)p88, new Padding(0));
		game.smethod_30((Control)(object)p88, "p88");
		game.smethod_31((Control)(object)p88, new Size(70, 70));
		game.smethod_38(p88, 8);
		game.smethod_39(p88, bool_0: false);
		game.smethod_34((Control)(object)p88, (EventHandler)p88_Click);
		game.smethod_5((Control)(object)p78, Color.White);
		game.smethod_37((Control)(object)p78, (ImageLayout)4);
		game.smethod_29((Control)(object)p78, new Point(490, 70));
		game.smethod_40((Control)(object)p78, new Padding(0));
		game.smethod_30((Control)(object)p78, "p78");
		game.smethod_31((Control)(object)p78, new Size(70, 70));
		game.smethod_38(p78, 7);
		game.smethod_39(p78, bool_0: false);
		game.smethod_34((Control)(object)p78, (EventHandler)p78_Click);
		game.smethod_5((Control)(object)p68, Color.DimGray);
		game.smethod_37((Control)(object)p68, (ImageLayout)4);
		game.smethod_29((Control)(object)p68, new Point(420, 70));
		game.smethod_40((Control)(object)p68, new Padding(0));
		game.smethod_30((Control)(object)p68, "p68");
		game.smethod_31((Control)(object)p68, new Size(70, 70));
		game.smethod_38(p68, 6);
		game.smethod_39(p68, bool_0: false);
		game.smethod_34((Control)(object)p68, (EventHandler)p68_Click);
		game.smethod_5((Control)(object)p58, Color.White);
		game.smethod_37((Control)(object)p58, (ImageLayout)4);
		game.smethod_29((Control)(object)p58, new Point(350, 70));
		game.smethod_40((Control)(object)p58, new Padding(0));
		game.smethod_30((Control)(object)p58, "p58");
		game.smethod_31((Control)(object)p58, new Size(70, 70));
		game.smethod_38(p58, 5);
		game.smethod_39(p58, bool_0: false);
		game.smethod_34((Control)(object)p58, (EventHandler)p58_Click);
		game.smethod_5((Control)(object)p48, Color.DimGray);
		game.smethod_37((Control)(object)p48, (ImageLayout)4);
		game.smethod_29((Control)(object)p48, new Point(280, 70));
		game.smethod_40((Control)(object)p48, new Padding(0));
		game.smethod_30((Control)(object)p48, "p48");
		game.smethod_31((Control)(object)p48, new Size(70, 70));
		game.smethod_38(p48, 4);
		game.smethod_39(p48, bool_0: false);
		game.smethod_34((Control)(object)p48, (EventHandler)p48_Click);
		game.smethod_5((Control)(object)p38, Color.White);
		game.smethod_37((Control)(object)p38, (ImageLayout)4);
		game.smethod_29((Control)(object)p38, new Point(210, 70));
		game.smethod_40((Control)(object)p38, new Padding(0));
		game.smethod_30((Control)(object)p38, "p38");
		game.smethod_31((Control)(object)p38, new Size(70, 70));
		game.smethod_38(p38, 3);
		game.smethod_39(p38, bool_0: false);
		game.smethod_34((Control)(object)p38, (EventHandler)p38_Click);
		game.smethod_5((Control)(object)p28, Color.DimGray);
		game.smethod_37((Control)(object)p28, (ImageLayout)4);
		game.smethod_29((Control)(object)p28, new Point(140, 70));
		game.smethod_40((Control)(object)p28, new Padding(0));
		game.smethod_30((Control)(object)p28, "p28");
		game.smethod_31((Control)(object)p28, new Size(70, 70));
		game.smethod_38(p28, 2);
		game.smethod_39(p28, bool_0: false);
		game.smethod_34((Control)(object)p28, (EventHandler)p28_Click);
		game.smethod_5((Control)(object)p81, Color.White);
		game.smethod_29((Control)(object)p81, new Point(90, 85));
		game.smethod_30((Control)(object)p81, "p81");
		game.smethod_31((Control)(object)p81, new Size(70, 70));
		game.smethod_38(p81, 1);
		game.smethod_39(p81, bool_0: false);
		game.smethod_37((Control)(object)board, (ImageLayout)4);
		game.smethod_29((Control)(object)board, new Point(28, 28));
		game.smethod_30((Control)(object)board, "board");
		game.smethod_31((Control)(object)board, new Size(654, 647));
		game.smethod_38(board, 0);
		game.smethod_39(board, bool_0: false);
		game.smethod_36((Control)(object)label3, bool_0: true);
		game.smethod_28((Control)(object)label3, game.smethod_27("Microsoft Sans Serif", 18.25f));
		game.smethod_29((Control)(object)label3, new Point(1009, 466));
		game.smethod_30((Control)(object)label3, "label3");
		game.smethod_31((Control)(object)label3, new Size(235, 29));
		game.smethod_32((Control)(object)label3, 72);
		game.smethod_3((Control)(object)label3, "выбранная фигура");
		game.smethod_36((Control)(object)chey_hod, bool_0: true);
		game.smethod_28((Control)(object)chey_hod, game.smethod_27("Microsoft Sans Serif", 28.25f));
		game.smethod_29((Control)(object)chey_hod, new Point(992, 291));
		game.smethod_30((Control)(object)chey_hod, "chey_hod");
		game.smethod_31((Control)(object)chey_hod, new Size(272, 44));
		game.smethod_32((Control)(object)chey_hod, 73);
		game.smethod_3((Control)(object)chey_hod, "Ходят - белые");
		game.smethod_36((Control)(object)label4, bool_0: true);
		game.smethod_28((Control)(object)label4, game.smethod_27("Microsoft Sans Serif", 28.25f));
		game.smethod_29((Control)(object)label4, new Point(1000, 327));
		game.smethod_30((Control)(object)label4, "label4");
		game.smethod_31((Control)(object)label4, new Size(272, 44));
		game.smethod_32((Control)(object)label4, 147);
		game.smethod_3((Control)(object)label4, "Ходят - белые");
		game.smethod_36((Control)(object)label5, bool_0: true);
		game.smethod_28((Control)(object)label5, game.smethod_27("Microsoft Sans Serif", 18.25f));
		game.smethod_29((Control)(object)label5, new Point(1017, 502));
		game.smethod_30((Control)(object)label5, "label5");
		game.smethod_31((Control)(object)label5, new Size(235, 29));
		game.smethod_32((Control)(object)label5, 146);
		game.smethod_3((Control)(object)label5, "выбранная фигура");
		game.smethod_37((Control)(object)pictureBox1, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox1, new Point(1069, 557));
		game.smethod_30((Control)(object)pictureBox1, "pictureBox1");
		game.smethod_31((Control)(object)pictureBox1, new Size(130, 130));
		game.smethod_38(pictureBox1, 145);
		game.smethod_39(pictureBox1, bool_0: false);
		game.smethod_36((Control)(object)label6, bool_0: true);
		game.smethod_28((Control)(object)label6, game.smethod_27("Microsoft Sans Serif", 38.25f));
		game.smethod_29((Control)(object)label6, new Point(785, 261));
		game.smethod_30((Control)(object)label6, "label6");
		game.smethod_31((Control)(object)label6, new Size(95, 59));
		game.smethod_32((Control)(object)label6, 144);
		game.smethod_3((Control)(object)label6, "0:0");
		game.smethod_1((Control)(object)label6, bool_0: false);
		game.smethod_36((Control)(object)label7, bool_0: true);
		game.smethod_28((Control)(object)label7, game.smethod_27("Microsoft Sans Serif", 38.25f));
		game.smethod_29((Control)(object)label7, new Point(785, 377));
		game.smethod_30((Control)(object)label7, "label7");
		game.smethod_31((Control)(object)label7, new Size(95, 59));
		game.smethod_32((Control)(object)label7, 143);
		game.smethod_3((Control)(object)label7, "0:0");
		game.smethod_1((Control)(object)label7, bool_0: false);
		game.smethod_5((Control)(object)button3, game.smethod_35());
		game.smethod_29((Control)(object)button3, new Point(776, 154));
		game.smethod_30((Control)(object)button3, "button3");
		game.smethod_31((Control)(object)button3, new Size(120, 78));
		game.smethod_32((Control)(object)button3, 142);
		game.smethod_33((ButtonBase)(object)button3, bool_0: false);
		game.smethod_1((Control)(object)button3, bool_0: false);
		game.smethod_5((Control)(object)button4, game.smethod_35());
		game.smethod_29((Control)(object)button4, new Point(776, 481));
		game.smethod_30((Control)(object)button4, "button4");
		game.smethod_31((Control)(object)button4, new Size(120, 78));
		game.smethod_32((Control)(object)button4, 141);
		game.smethod_33((ButtonBase)(object)button4, bool_0: false);
		game.smethod_1((Control)(object)button4, bool_0: false);
		game.smethod_5((Control)(object)pictureBox2, Color.White);
		game.smethod_37((Control)(object)pictureBox2, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox2, new Point(568, 316));
		game.smethod_40((Control)(object)pictureBox2, new Padding(0));
		game.smethod_30((Control)(object)pictureBox2, "pictureBox2");
		game.smethod_31((Control)(object)pictureBox2, new Size(70, 70));
		game.smethod_38(pictureBox2, 140);
		game.smethod_39(pictureBox2, bool_0: false);
		game.smethod_28((Control)(object)button5, game.smethod_27("Microsoft Sans Serif", 28.25f));
		game.smethod_29((Control)(object)button5, new Point(998, 48));
		game.smethod_30((Control)(object)button5, "button5");
		game.smethod_31((Control)(object)button5, new Size(188, 47));
		game.smethod_32((Control)(object)button5, 139);
		game.smethod_3((Control)(object)button5, "ВЫХОД");
		game.smethod_33((ButtonBase)(object)button5, bool_0: true);
		game.smethod_5((Control)(object)pictureBox3, Color.White);
		game.smethod_37((Control)(object)pictureBox3, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox3, new Point(568, 596));
		game.smethod_40((Control)(object)pictureBox3, new Padding(0));
		game.smethod_30((Control)(object)pictureBox3, "pictureBox3");
		game.smethod_31((Control)(object)pictureBox3, new Size(70, 70));
		game.smethod_38(pictureBox3, 138);
		game.smethod_39(pictureBox3, bool_0: false);
		game.smethod_5((Control)(object)pictureBox4, Color.DimGray);
		game.smethod_37((Control)(object)pictureBox4, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox4, new Point(498, 596));
		game.smethod_40((Control)(object)pictureBox4, new Padding(0));
		game.smethod_30((Control)(object)pictureBox4, "pictureBox4");
		game.smethod_31((Control)(object)pictureBox4, new Size(70, 70));
		game.smethod_38(pictureBox4, 137);
		game.smethod_39(pictureBox4, bool_0: false);
		game.smethod_5((Control)(object)pictureBox5, Color.White);
		game.smethod_37((Control)(object)pictureBox5, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox5, new Point(428, 596));
		game.smethod_40((Control)(object)pictureBox5, new Padding(0));
		game.smethod_30((Control)(object)pictureBox5, "pictureBox5");
		game.smethod_31((Control)(object)pictureBox5, new Size(70, 70));
		game.smethod_38(pictureBox5, 136);
		game.smethod_39(pictureBox5, bool_0: false);
		game.smethod_5((Control)(object)pictureBox6, Color.DimGray);
		game.smethod_37((Control)(object)pictureBox6, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox6, new Point(358, 596));
		game.smethod_40((Control)(object)pictureBox6, new Padding(0));
		game.smethod_30((Control)(object)pictureBox6, "pictureBox6");
		game.smethod_31((Control)(object)pictureBox6, new Size(70, 70));
		game.smethod_38(pictureBox6, 135);
		game.smethod_39(pictureBox6, bool_0: false);
		game.smethod_5((Control)(object)pictureBox7, Color.White);
		game.smethod_37((Control)(object)pictureBox7, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox7, new Point(288, 596));
		game.smethod_40((Control)(object)pictureBox7, new Padding(0));
		game.smethod_30((Control)(object)pictureBox7, "pictureBox7");
		game.smethod_31((Control)(object)pictureBox7, new Size(70, 70));
		game.smethod_38(pictureBox7, 134);
		game.smethod_39(pictureBox7, bool_0: false);
		game.smethod_5((Control)(object)pictureBox8, Color.DimGray);
		game.smethod_37((Control)(object)pictureBox8, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox8, new Point(218, 596));
		game.smethod_40((Control)(object)pictureBox8, new Padding(0));
		game.smethod_30((Control)(object)pictureBox8, "pictureBox8");
		game.smethod_31((Control)(object)pictureBox8, new Size(70, 70));
		game.smethod_38(pictureBox8, 133);
		game.smethod_39(pictureBox8, bool_0: false);
		game.smethod_5((Control)(object)pictureBox9, Color.White);
		game.smethod_37((Control)(object)pictureBox9, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox9, new Point(148, 596));
		game.smethod_40((Control)(object)pictureBox9, new Padding(0));
		game.smethod_30((Control)(object)pictureBox9, "pictureBox9");
		game.smethod_31((Control)(object)pictureBox9, new Size(70, 70));
		game.smethod_38(pictureBox9, 132);
		game.smethod_39(pictureBox9, bool_0: false);
		game.smethod_5((Control)(object)pictureBox10, Color.DimGray);
		game.smethod_37((Control)(object)pictureBox10, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox10, new Point(78, 596));
		game.smethod_40((Control)(object)pictureBox10, new Padding(0));
		game.smethod_30((Control)(object)pictureBox10, "pictureBox10");
		game.smethod_31((Control)(object)pictureBox10, new Size(70, 70));
		game.smethod_38(pictureBox10, 131);
		game.smethod_39(pictureBox10, bool_0: false);
		game.smethod_5((Control)(object)pictureBox11, Color.DimGray);
		game.smethod_37((Control)(object)pictureBox11, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox11, new Point(568, 526));
		game.smethod_40((Control)(object)pictureBox11, new Padding(0));
		game.smethod_30((Control)(object)pictureBox11, "pictureBox11");
		game.smethod_31((Control)(object)pictureBox11, new Size(70, 70));
		game.smethod_38(pictureBox11, 130);
		game.smethod_39(pictureBox11, bool_0: false);
		game.smethod_5((Control)(object)pictureBox12, Color.White);
		game.smethod_37((Control)(object)pictureBox12, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox12, new Point(498, 526));
		game.smethod_40((Control)(object)pictureBox12, new Padding(0));
		game.smethod_30((Control)(object)pictureBox12, "pictureBox12");
		game.smethod_31((Control)(object)pictureBox12, new Size(70, 70));
		game.smethod_38(pictureBox12, 129);
		game.smethod_39(pictureBox12, bool_0: false);
		game.smethod_5((Control)(object)pictureBox13, Color.DimGray);
		game.smethod_37((Control)(object)pictureBox13, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox13, new Point(428, 526));
		game.smethod_40((Control)(object)pictureBox13, new Padding(0));
		game.smethod_30((Control)(object)pictureBox13, "pictureBox13");
		game.smethod_31((Control)(object)pictureBox13, new Size(70, 70));
		game.smethod_38(pictureBox13, 128);
		game.smethod_39(pictureBox13, bool_0: false);
		game.smethod_5((Control)(object)pictureBox14, Color.White);
		game.smethod_37((Control)(object)pictureBox14, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox14, new Point(358, 526));
		game.smethod_40((Control)(object)pictureBox14, new Padding(0));
		game.smethod_30((Control)(object)pictureBox14, "pictureBox14");
		game.smethod_31((Control)(object)pictureBox14, new Size(70, 70));
		game.smethod_38(pictureBox14, 127);
		game.smethod_39(pictureBox14, bool_0: false);
		game.smethod_5((Control)(object)pictureBox15, Color.DimGray);
		game.smethod_37((Control)(object)pictureBox15, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox15, new Point(288, 526));
		game.smethod_40((Control)(object)pictureBox15, new Padding(0));
		game.smethod_30((Control)(object)pictureBox15, "pictureBox15");
		game.smethod_31((Control)(object)pictureBox15, new Size(70, 70));
		game.smethod_38(pictureBox15, 126);
		game.smethod_39(pictureBox15, bool_0: false);
		game.smethod_5((Control)(object)pictureBox16, Color.White);
		game.smethod_37((Control)(object)pictureBox16, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox16, new Point(218, 526));
		game.smethod_40((Control)(object)pictureBox16, new Padding(0));
		game.smethod_30((Control)(object)pictureBox16, "pictureBox16");
		game.smethod_31((Control)(object)pictureBox16, new Size(70, 70));
		game.smethod_38(pictureBox16, 125);
		game.smethod_39(pictureBox16, bool_0: false);
		game.smethod_5((Control)(object)pictureBox17, Color.DimGray);
		game.smethod_37((Control)(object)pictureBox17, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox17, new Point(148, 526));
		game.smethod_40((Control)(object)pictureBox17, new Padding(0));
		game.smethod_30((Control)(object)pictureBox17, "pictureBox17");
		game.smethod_31((Control)(object)pictureBox17, new Size(70, 70));
		game.smethod_38(pictureBox17, 124);
		game.smethod_39(pictureBox17, bool_0: false);
		game.smethod_5((Control)(object)pictureBox18, Color.White);
		game.smethod_37((Control)(object)pictureBox18, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox18, new Point(78, 526));
		game.smethod_40((Control)(object)pictureBox18, new Padding(0));
		game.smethod_30((Control)(object)pictureBox18, "pictureBox18");
		game.smethod_31((Control)(object)pictureBox18, new Size(70, 70));
		game.smethod_38(pictureBox18, 123);
		game.smethod_39(pictureBox18, bool_0: false);
		game.smethod_5((Control)(object)pictureBox19, Color.White);
		game.smethod_37((Control)(object)pictureBox19, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox19, new Point(568, 456));
		game.smethod_40((Control)(object)pictureBox19, new Padding(0));
		game.smethod_30((Control)(object)pictureBox19, "pictureBox19");
		game.smethod_31((Control)(object)pictureBox19, new Size(70, 70));
		game.smethod_38(pictureBox19, 122);
		game.smethod_39(pictureBox19, bool_0: false);
		game.smethod_5((Control)(object)pictureBox20, Color.DimGray);
		game.smethod_37((Control)(object)pictureBox20, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox20, new Point(498, 456));
		game.smethod_40((Control)(object)pictureBox20, new Padding(0));
		game.smethod_30((Control)(object)pictureBox20, "pictureBox20");
		game.smethod_31((Control)(object)pictureBox20, new Size(70, 70));
		game.smethod_38(pictureBox20, 121);
		game.smethod_39(pictureBox20, bool_0: false);
		game.smethod_5((Control)(object)pictureBox21, Color.White);
		game.smethod_37((Control)(object)pictureBox21, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox21, new Point(428, 456));
		game.smethod_40((Control)(object)pictureBox21, new Padding(0));
		game.smethod_30((Control)(object)pictureBox21, "pictureBox21");
		game.smethod_31((Control)(object)pictureBox21, new Size(70, 70));
		game.smethod_38(pictureBox21, 120);
		game.smethod_39(pictureBox21, bool_0: false);
		game.smethod_5((Control)(object)pictureBox22, Color.DimGray);
		game.smethod_37((Control)(object)pictureBox22, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox22, new Point(358, 456));
		game.smethod_40((Control)(object)pictureBox22, new Padding(0));
		game.smethod_30((Control)(object)pictureBox22, "pictureBox22");
		game.smethod_31((Control)(object)pictureBox22, new Size(70, 70));
		game.smethod_38(pictureBox22, 119);
		game.smethod_39(pictureBox22, bool_0: false);
		game.smethod_5((Control)(object)pictureBox23, Color.White);
		game.smethod_37((Control)(object)pictureBox23, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox23, new Point(288, 456));
		game.smethod_40((Control)(object)pictureBox23, new Padding(0));
		game.smethod_30((Control)(object)pictureBox23, "pictureBox23");
		game.smethod_31((Control)(object)pictureBox23, new Size(70, 70));
		game.smethod_38(pictureBox23, 118);
		game.smethod_39(pictureBox23, bool_0: false);
		game.smethod_5((Control)(object)pictureBox24, Color.DimGray);
		game.smethod_37((Control)(object)pictureBox24, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox24, new Point(218, 456));
		game.smethod_40((Control)(object)pictureBox24, new Padding(0));
		game.smethod_30((Control)(object)pictureBox24, "pictureBox24");
		game.smethod_31((Control)(object)pictureBox24, new Size(70, 70));
		game.smethod_38(pictureBox24, 117);
		game.smethod_39(pictureBox24, bool_0: false);
		game.smethod_5((Control)(object)pictureBox25, Color.White);
		game.smethod_37((Control)(object)pictureBox25, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox25, new Point(148, 456));
		game.smethod_40((Control)(object)pictureBox25, new Padding(0));
		game.smethod_30((Control)(object)pictureBox25, "pictureBox25");
		game.smethod_31((Control)(object)pictureBox25, new Size(70, 70));
		game.smethod_38(pictureBox25, 116);
		game.smethod_39(pictureBox25, bool_0: false);
		game.smethod_5((Control)(object)pictureBox26, Color.DimGray);
		game.smethod_37((Control)(object)pictureBox26, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox26, new Point(78, 456));
		game.smethod_40((Control)(object)pictureBox26, new Padding(0));
		game.smethod_30((Control)(object)pictureBox26, "pictureBox26");
		game.smethod_31((Control)(object)pictureBox26, new Size(70, 70));
		game.smethod_38(pictureBox26, 115);
		game.smethod_39(pictureBox26, bool_0: false);
		game.smethod_5((Control)(object)pictureBox27, Color.DimGray);
		game.smethod_37((Control)(object)pictureBox27, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox27, new Point(568, 386));
		game.smethod_40((Control)(object)pictureBox27, new Padding(0));
		game.smethod_30((Control)(object)pictureBox27, "pictureBox27");
		game.smethod_31((Control)(object)pictureBox27, new Size(70, 70));
		game.smethod_38(pictureBox27, 114);
		game.smethod_39(pictureBox27, bool_0: false);
		game.smethod_5((Control)(object)pictureBox28, Color.White);
		game.smethod_37((Control)(object)pictureBox28, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox28, new Point(498, 386));
		game.smethod_40((Control)(object)pictureBox28, new Padding(0));
		game.smethod_30((Control)(object)pictureBox28, "pictureBox28");
		game.smethod_31((Control)(object)pictureBox28, new Size(70, 70));
		game.smethod_38(pictureBox28, 113);
		game.smethod_39(pictureBox28, bool_0: false);
		game.smethod_5((Control)(object)pictureBox29, Color.DimGray);
		game.smethod_37((Control)(object)pictureBox29, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox29, new Point(428, 386));
		game.smethod_40((Control)(object)pictureBox29, new Padding(0));
		game.smethod_30((Control)(object)pictureBox29, "pictureBox29");
		game.smethod_31((Control)(object)pictureBox29, new Size(70, 70));
		game.smethod_38(pictureBox29, 112);
		game.smethod_39(pictureBox29, bool_0: false);
		game.smethod_5((Control)(object)pictureBox30, Color.White);
		game.smethod_37((Control)(object)pictureBox30, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox30, new Point(358, 386));
		game.smethod_40((Control)(object)pictureBox30, new Padding(0));
		game.smethod_30((Control)(object)pictureBox30, "pictureBox30");
		game.smethod_31((Control)(object)pictureBox30, new Size(70, 70));
		game.smethod_38(pictureBox30, 111);
		game.smethod_39(pictureBox30, bool_0: false);
		game.smethod_5((Control)(object)pictureBox31, Color.DimGray);
		game.smethod_37((Control)(object)pictureBox31, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox31, new Point(288, 386));
		game.smethod_40((Control)(object)pictureBox31, new Padding(0));
		game.smethod_30((Control)(object)pictureBox31, "pictureBox31");
		game.smethod_31((Control)(object)pictureBox31, new Size(70, 70));
		game.smethod_38(pictureBox31, 110);
		game.smethod_39(pictureBox31, bool_0: false);
		game.smethod_5((Control)(object)pictureBox32, Color.White);
		game.smethod_37((Control)(object)pictureBox32, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox32, new Point(218, 386));
		game.smethod_40((Control)(object)pictureBox32, new Padding(0));
		game.smethod_30((Control)(object)pictureBox32, "pictureBox32");
		game.smethod_31((Control)(object)pictureBox32, new Size(70, 70));
		game.smethod_38(pictureBox32, 109);
		game.smethod_39(pictureBox32, bool_0: false);
		game.smethod_5((Control)(object)pictureBox33, Color.DimGray);
		game.smethod_37((Control)(object)pictureBox33, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox33, new Point(148, 386));
		game.smethod_40((Control)(object)pictureBox33, new Padding(0));
		game.smethod_30((Control)(object)pictureBox33, "pictureBox33");
		game.smethod_31((Control)(object)pictureBox33, new Size(70, 70));
		game.smethod_38(pictureBox33, 108);
		game.smethod_39(pictureBox33, bool_0: false);
		game.smethod_5((Control)(object)pictureBox34, Color.White);
		game.smethod_37((Control)(object)pictureBox34, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox34, new Point(78, 386));
		game.smethod_40((Control)(object)pictureBox34, new Padding(0));
		game.smethod_30((Control)(object)pictureBox34, "pictureBox34");
		game.smethod_31((Control)(object)pictureBox34, new Size(70, 70));
		game.smethod_38(pictureBox34, 107);
		game.smethod_39(pictureBox34, bool_0: false);
		game.smethod_5((Control)(object)pictureBox35, Color.White);
		game.smethod_37((Control)(object)pictureBox35, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox35, new Point(78, 106));
		game.smethod_40((Control)(object)pictureBox35, new Padding(0));
		game.smethod_30((Control)(object)pictureBox35, "pictureBox35");
		game.smethod_31((Control)(object)pictureBox35, new Size(70, 70));
		game.smethod_38(pictureBox35, 106);
		game.smethod_39(pictureBox35, bool_0: false);
		game.smethod_5((Control)(object)pictureBox36, Color.DimGray);
		game.smethod_37((Control)(object)pictureBox36, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox36, new Point(498, 316));
		game.smethod_40((Control)(object)pictureBox36, new Padding(0));
		game.smethod_30((Control)(object)pictureBox36, "pictureBox36");
		game.smethod_31((Control)(object)pictureBox36, new Size(70, 70));
		game.smethod_38(pictureBox36, 105);
		game.smethod_39(pictureBox36, bool_0: false);
		game.smethod_5((Control)(object)pictureBox37, Color.White);
		game.smethod_37((Control)(object)pictureBox37, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox37, new Point(428, 316));
		game.smethod_40((Control)(object)pictureBox37, new Padding(0));
		game.smethod_30((Control)(object)pictureBox37, "pictureBox37");
		game.smethod_31((Control)(object)pictureBox37, new Size(70, 70));
		game.smethod_38(pictureBox37, 104);
		game.smethod_39(pictureBox37, bool_0: false);
		game.smethod_5((Control)(object)pictureBox38, Color.DimGray);
		game.smethod_37((Control)(object)pictureBox38, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox38, new Point(358, 316));
		game.smethod_40((Control)(object)pictureBox38, new Padding(0));
		game.smethod_30((Control)(object)pictureBox38, "pictureBox38");
		game.smethod_31((Control)(object)pictureBox38, new Size(70, 70));
		game.smethod_38(pictureBox38, 103);
		game.smethod_39(pictureBox38, bool_0: false);
		game.smethod_5((Control)(object)pictureBox39, Color.White);
		game.smethod_37((Control)(object)pictureBox39, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox39, new Point(288, 316));
		game.smethod_40((Control)(object)pictureBox39, new Padding(0));
		game.smethod_30((Control)(object)pictureBox39, "pictureBox39");
		game.smethod_31((Control)(object)pictureBox39, new Size(70, 70));
		game.smethod_38(pictureBox39, 102);
		game.smethod_39(pictureBox39, bool_0: false);
		game.smethod_5((Control)(object)pictureBox40, Color.DimGray);
		game.smethod_37((Control)(object)pictureBox40, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox40, new Point(218, 316));
		game.smethod_40((Control)(object)pictureBox40, new Padding(0));
		game.smethod_30((Control)(object)pictureBox40, "pictureBox40");
		game.smethod_31((Control)(object)pictureBox40, new Size(70, 70));
		game.smethod_38(pictureBox40, 101);
		game.smethod_39(pictureBox40, bool_0: false);
		game.smethod_5((Control)(object)pictureBox41, Color.White);
		game.smethod_37((Control)(object)pictureBox41, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox41, new Point(148, 316));
		game.smethod_40((Control)(object)pictureBox41, new Padding(0));
		game.smethod_30((Control)(object)pictureBox41, "pictureBox41");
		game.smethod_31((Control)(object)pictureBox41, new Size(70, 70));
		game.smethod_38(pictureBox41, 100);
		game.smethod_39(pictureBox41, bool_0: false);
		game.smethod_5((Control)(object)pictureBox42, Color.DimGray);
		game.smethod_37((Control)(object)pictureBox42, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox42, new Point(78, 316));
		game.smethod_40((Control)(object)pictureBox42, new Padding(0));
		game.smethod_30((Control)(object)pictureBox42, "pictureBox42");
		game.smethod_31((Control)(object)pictureBox42, new Size(70, 70));
		game.smethod_38(pictureBox42, 99);
		game.smethod_39(pictureBox42, bool_0: false);
		game.smethod_5((Control)(object)pictureBox43, Color.DimGray);
		game.smethod_37((Control)(object)pictureBox43, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox43, new Point(568, 246));
		game.smethod_40((Control)(object)pictureBox43, new Padding(0));
		game.smethod_30((Control)(object)pictureBox43, "pictureBox43");
		game.smethod_31((Control)(object)pictureBox43, new Size(70, 70));
		game.smethod_38(pictureBox43, 98);
		game.smethod_39(pictureBox43, bool_0: false);
		game.smethod_5((Control)(object)pictureBox44, Color.White);
		game.smethod_37((Control)(object)pictureBox44, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox44, new Point(498, 246));
		game.smethod_40((Control)(object)pictureBox44, new Padding(0));
		game.smethod_30((Control)(object)pictureBox44, "pictureBox44");
		game.smethod_31((Control)(object)pictureBox44, new Size(70, 70));
		game.smethod_38(pictureBox44, 97);
		game.smethod_39(pictureBox44, bool_0: false);
		game.smethod_5((Control)(object)pictureBox45, Color.DimGray);
		game.smethod_37((Control)(object)pictureBox45, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox45, new Point(428, 246));
		game.smethod_40((Control)(object)pictureBox45, new Padding(0));
		game.smethod_30((Control)(object)pictureBox45, "pictureBox45");
		game.smethod_31((Control)(object)pictureBox45, new Size(70, 70));
		game.smethod_38(pictureBox45, 96);
		game.smethod_39(pictureBox45, bool_0: false);
		game.smethod_5((Control)(object)pictureBox46, Color.White);
		game.smethod_37((Control)(object)pictureBox46, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox46, new Point(358, 246));
		game.smethod_40((Control)(object)pictureBox46, new Padding(0));
		game.smethod_30((Control)(object)pictureBox46, "pictureBox46");
		game.smethod_31((Control)(object)pictureBox46, new Size(70, 70));
		game.smethod_38(pictureBox46, 95);
		game.smethod_39(pictureBox46, bool_0: false);
		game.smethod_5((Control)(object)pictureBox47, Color.DimGray);
		game.smethod_37((Control)(object)pictureBox47, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox47, new Point(288, 246));
		game.smethod_40((Control)(object)pictureBox47, new Padding(0));
		game.smethod_30((Control)(object)pictureBox47, "pictureBox47");
		game.smethod_31((Control)(object)pictureBox47, new Size(70, 70));
		game.smethod_38(pictureBox47, 94);
		game.smethod_39(pictureBox47, bool_0: false);
		game.smethod_5((Control)(object)pictureBox48, Color.White);
		game.smethod_37((Control)(object)pictureBox48, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox48, new Point(218, 246));
		game.smethod_40((Control)(object)pictureBox48, new Padding(0));
		game.smethod_30((Control)(object)pictureBox48, "pictureBox48");
		game.smethod_31((Control)(object)pictureBox48, new Size(70, 70));
		game.smethod_38(pictureBox48, 93);
		game.smethod_39(pictureBox48, bool_0: false);
		game.smethod_5((Control)(object)pictureBox49, Color.DimGray);
		game.smethod_37((Control)(object)pictureBox49, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox49, new Point(148, 246));
		game.smethod_40((Control)(object)pictureBox49, new Padding(0));
		game.smethod_30((Control)(object)pictureBox49, "pictureBox49");
		game.smethod_31((Control)(object)pictureBox49, new Size(70, 70));
		game.smethod_38(pictureBox49, 92);
		game.smethod_39(pictureBox49, bool_0: false);
		game.smethod_5((Control)(object)pictureBox50, Color.White);
		game.smethod_37((Control)(object)pictureBox50, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox50, new Point(78, 246));
		game.smethod_40((Control)(object)pictureBox50, new Padding(0));
		game.smethod_30((Control)(object)pictureBox50, "pictureBox50");
		game.smethod_31((Control)(object)pictureBox50, new Size(70, 70));
		game.smethod_38(pictureBox50, 91);
		game.smethod_39(pictureBox50, bool_0: false);
		game.smethod_5((Control)(object)pictureBox51, Color.White);
		game.smethod_37((Control)(object)pictureBox51, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox51, new Point(568, 176));
		game.smethod_40((Control)(object)pictureBox51, new Padding(0));
		game.smethod_30((Control)(object)pictureBox51, "pictureBox51");
		game.smethod_31((Control)(object)pictureBox51, new Size(70, 70));
		game.smethod_38(pictureBox51, 90);
		game.smethod_39(pictureBox51, bool_0: false);
		game.smethod_5((Control)(object)pictureBox52, Color.DimGray);
		game.smethod_37((Control)(object)pictureBox52, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox52, new Point(498, 176));
		game.smethod_40((Control)(object)pictureBox52, new Padding(0));
		game.smethod_30((Control)(object)pictureBox52, "pictureBox52");
		game.smethod_31((Control)(object)pictureBox52, new Size(70, 70));
		game.smethod_38(pictureBox52, 89);
		game.smethod_39(pictureBox52, bool_0: false);
		game.smethod_5((Control)(object)pictureBox53, Color.White);
		game.smethod_37((Control)(object)pictureBox53, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox53, new Point(428, 176));
		game.smethod_40((Control)(object)pictureBox53, new Padding(0));
		game.smethod_30((Control)(object)pictureBox53, "pictureBox53");
		game.smethod_31((Control)(object)pictureBox53, new Size(70, 70));
		game.smethod_38(pictureBox53, 88);
		game.smethod_39(pictureBox53, bool_0: false);
		game.smethod_5((Control)(object)pictureBox54, Color.DimGray);
		game.smethod_37((Control)(object)pictureBox54, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox54, new Point(358, 176));
		game.smethod_40((Control)(object)pictureBox54, new Padding(0));
		game.smethod_30((Control)(object)pictureBox54, "pictureBox54");
		game.smethod_31((Control)(object)pictureBox54, new Size(70, 70));
		game.smethod_38(pictureBox54, 87);
		game.smethod_39(pictureBox54, bool_0: false);
		game.smethod_5((Control)(object)pictureBox55, Color.White);
		game.smethod_37((Control)(object)pictureBox55, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox55, new Point(288, 176));
		game.smethod_40((Control)(object)pictureBox55, new Padding(0));
		game.smethod_30((Control)(object)pictureBox55, "pictureBox55");
		game.smethod_31((Control)(object)pictureBox55, new Size(70, 70));
		game.smethod_38(pictureBox55, 86);
		game.smethod_39(pictureBox55, bool_0: false);
		game.smethod_5((Control)(object)pictureBox56, Color.DimGray);
		game.smethod_37((Control)(object)pictureBox56, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox56, new Point(218, 176));
		game.smethod_40((Control)(object)pictureBox56, new Padding(0));
		game.smethod_30((Control)(object)pictureBox56, "pictureBox56");
		game.smethod_31((Control)(object)pictureBox56, new Size(70, 70));
		game.smethod_38(pictureBox56, 85);
		game.smethod_39(pictureBox56, bool_0: false);
		game.smethod_5((Control)(object)pictureBox57, Color.White);
		game.smethod_37((Control)(object)pictureBox57, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox57, new Point(148, 176));
		game.smethod_40((Control)(object)pictureBox57, new Padding(0));
		game.smethod_30((Control)(object)pictureBox57, "pictureBox57");
		game.smethod_31((Control)(object)pictureBox57, new Size(70, 70));
		game.smethod_38(pictureBox57, 84);
		game.smethod_39(pictureBox57, bool_0: false);
		game.smethod_5((Control)(object)pictureBox58, Color.DimGray);
		game.smethod_37((Control)(object)pictureBox58, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox58, new Point(78, 176));
		game.smethod_40((Control)(object)pictureBox58, new Padding(0));
		game.smethod_30((Control)(object)pictureBox58, "pictureBox58");
		game.smethod_31((Control)(object)pictureBox58, new Size(70, 70));
		game.smethod_38(pictureBox58, 83);
		game.smethod_39(pictureBox58, bool_0: false);
		game.smethod_5((Control)(object)pictureBox59, Color.DimGray);
		game.smethod_37((Control)(object)pictureBox59, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox59, new Point(568, 106));
		game.smethod_40((Control)(object)pictureBox59, new Padding(0));
		game.smethod_30((Control)(object)pictureBox59, "pictureBox59");
		game.smethod_31((Control)(object)pictureBox59, new Size(70, 70));
		game.smethod_38(pictureBox59, 82);
		game.smethod_39(pictureBox59, bool_0: false);
		game.smethod_5((Control)(object)pictureBox60, Color.White);
		game.smethod_37((Control)(object)pictureBox60, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox60, new Point(498, 106));
		game.smethod_40((Control)(object)pictureBox60, new Padding(0));
		game.smethod_30((Control)(object)pictureBox60, "pictureBox60");
		game.smethod_31((Control)(object)pictureBox60, new Size(70, 70));
		game.smethod_38(pictureBox60, 81);
		game.smethod_39(pictureBox60, bool_0: false);
		game.smethod_5((Control)(object)pictureBox61, Color.DimGray);
		game.smethod_37((Control)(object)pictureBox61, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox61, new Point(428, 106));
		game.smethod_40((Control)(object)pictureBox61, new Padding(0));
		game.smethod_30((Control)(object)pictureBox61, "pictureBox61");
		game.smethod_31((Control)(object)pictureBox61, new Size(70, 70));
		game.smethod_38(pictureBox61, 80);
		game.smethod_39(pictureBox61, bool_0: false);
		game.smethod_5((Control)(object)pictureBox62, Color.White);
		game.smethod_37((Control)(object)pictureBox62, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox62, new Point(358, 106));
		game.smethod_40((Control)(object)pictureBox62, new Padding(0));
		game.smethod_30((Control)(object)pictureBox62, "pictureBox62");
		game.smethod_31((Control)(object)pictureBox62, new Size(70, 70));
		game.smethod_38(pictureBox62, 79);
		game.smethod_39(pictureBox62, bool_0: false);
		game.smethod_5((Control)(object)pictureBox63, Color.DimGray);
		game.smethod_37((Control)(object)pictureBox63, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox63, new Point(288, 106));
		game.smethod_40((Control)(object)pictureBox63, new Padding(0));
		game.smethod_30((Control)(object)pictureBox63, "pictureBox63");
		game.smethod_31((Control)(object)pictureBox63, new Size(70, 70));
		game.smethod_38(pictureBox63, 78);
		game.smethod_39(pictureBox63, bool_0: false);
		game.smethod_5((Control)(object)pictureBox64, Color.White);
		game.smethod_37((Control)(object)pictureBox64, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox64, new Point(218, 106));
		game.smethod_40((Control)(object)pictureBox64, new Padding(0));
		game.smethod_30((Control)(object)pictureBox64, "pictureBox64");
		game.smethod_31((Control)(object)pictureBox64, new Size(70, 70));
		game.smethod_38(pictureBox64, 77);
		game.smethod_39(pictureBox64, bool_0: false);
		game.smethod_5((Control)(object)pictureBox65, Color.DimGray);
		game.smethod_37((Control)(object)pictureBox65, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox65, new Point(148, 106));
		game.smethod_40((Control)(object)pictureBox65, new Padding(0));
		game.smethod_30((Control)(object)pictureBox65, "pictureBox65");
		game.smethod_31((Control)(object)pictureBox65, new Size(70, 70));
		game.smethod_38(pictureBox65, 76);
		game.smethod_39(pictureBox65, bool_0: false);
		game.smethod_5((Control)(object)pictureBox66, Color.White);
		game.smethod_29((Control)(object)pictureBox66, new Point(98, 121));
		game.smethod_30((Control)(object)pictureBox66, "pictureBox66");
		game.smethod_31((Control)(object)pictureBox66, new Size(70, 70));
		game.smethod_38(pictureBox66, 75);
		game.smethod_39(pictureBox66, bool_0: false);
		game.smethod_37((Control)(object)pictureBox67, (ImageLayout)4);
		game.smethod_29((Control)(object)pictureBox67, new Point(36, 64));
		game.smethod_30((Control)(object)pictureBox67, "pictureBox67");
		game.smethod_31((Control)(object)pictureBox67, new Size(654, 647));
		game.smethod_38(pictureBox67, 74);
		game.smethod_39(pictureBox67, bool_0: false);
		game.smethod_41((ContainerControl)(object)this, new SizeF(6f, 13f));
		game.smethod_42((ContainerControl)(object)this, (AutoScaleMode)1);
		game.smethod_43((Form)(object)this, new Size(1309, 758));
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)label4);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)label5);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox1);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)label6);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)label7);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)button3);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)button4);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox2);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)button5);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox3);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox4);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox5);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox6);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox7);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox8);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox9);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox10);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox11);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox12);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox13);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox14);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox15);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox16);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox17);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox18);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox19);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox20);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox21);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox22);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox23);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox24);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox25);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox26);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox27);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox28);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox29);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox30);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox31);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox32);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox33);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox34);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox35);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox36);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox37);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox38);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox39);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox40);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox41);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox42);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox43);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox44);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox45);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox46);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox47);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox48);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox49);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox50);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox51);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox52);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox53);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox54);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox55);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox56);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox57);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox58);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox59);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox60);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox61);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox62);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox63);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox64);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox65);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox66);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)pictureBox67);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)chey_hod);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)label3);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)selected);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)label2);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)label1);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)button2);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)button1);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p85);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)exit);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p_81);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p71);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p61);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p51);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p41);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p31);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p21);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p11);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p82);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p72);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p62);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p52);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p42);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p32);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p22);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p12);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p83);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p73);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p63);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p53);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p43);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p33);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p23);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p13);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p84);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p74);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p64);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p54);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p44);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p34);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p24);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p14);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p18);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p75);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p65);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p55);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p45);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p35);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p25);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p15);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p86);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p76);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p66);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p56);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p46);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p36);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p26);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p16);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p87);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p77);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p67);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p57);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p47);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p37);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p27);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p17);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p88);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p78);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p68);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p58);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p48);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p38);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p28);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)p81);
		game.smethod_45(game.smethod_44((Control)(object)this), (Control)(object)board);
		game.smethod_46((Control)(object)this, "game");
		game.smethod_3((Control)(object)this, "Game");
		game.smethod_47((Form)(object)this, (EventHandler)game_Load);
		game.smethod_48((ISupportInitialize)selected);
		game.smethod_48((ISupportInitialize)p85);
		game.smethod_48((ISupportInitialize)p_81);
		game.smethod_48((ISupportInitialize)p71);
		game.smethod_48((ISupportInitialize)p61);
		game.smethod_48((ISupportInitialize)p51);
		game.smethod_48((ISupportInitialize)p41);
		game.smethod_48((ISupportInitialize)p31);
		game.smethod_48((ISupportInitialize)p21);
		game.smethod_48((ISupportInitialize)p11);
		game.smethod_48((ISupportInitialize)p82);
		game.smethod_48((ISupportInitialize)p72);
		game.smethod_48((ISupportInitialize)p62);
		game.smethod_48((ISupportInitialize)p52);
		game.smethod_48((ISupportInitialize)p42);
		game.smethod_48((ISupportInitialize)p32);
		game.smethod_48((ISupportInitialize)p22);
		game.smethod_48((ISupportInitialize)p12);
		game.smethod_48((ISupportInitialize)p83);
		game.smethod_48((ISupportInitialize)p73);
		game.smethod_48((ISupportInitialize)p63);
		game.smethod_48((ISupportInitialize)p53);
		game.smethod_48((ISupportInitialize)p43);
		game.smethod_48((ISupportInitialize)p33);
		game.smethod_48((ISupportInitialize)p23);
		game.smethod_48((ISupportInitialize)p13);
		game.smethod_48((ISupportInitialize)p84);
		game.smethod_48((ISupportInitialize)p74);
		game.smethod_48((ISupportInitialize)p64);
		game.smethod_48((ISupportInitialize)p54);
		game.smethod_48((ISupportInitialize)p44);
		game.smethod_48((ISupportInitialize)p34);
		game.smethod_48((ISupportInitialize)p24);
		game.smethod_48((ISupportInitialize)p14);
		game.smethod_48((ISupportInitialize)p18);
		game.smethod_48((ISupportInitialize)p75);
		game.smethod_48((ISupportInitialize)p65);
		game.smethod_48((ISupportInitialize)p55);
		game.smethod_48((ISupportInitialize)p45);
		game.smethod_48((ISupportInitialize)p35);
		game.smethod_48((ISupportInitialize)p25);
		game.smethod_48((ISupportInitialize)p15);
		game.smethod_48((ISupportInitialize)p86);
		game.smethod_48((ISupportInitialize)p76);
		game.smethod_48((ISupportInitialize)p66);
		game.smethod_48((ISupportInitialize)p56);
		game.smethod_48((ISupportInitialize)p46);
		game.smethod_48((ISupportInitialize)p36);
		game.smethod_48((ISupportInitialize)p26);
		game.smethod_48((ISupportInitialize)p16);
		game.smethod_48((ISupportInitialize)p87);
		game.smethod_48((ISupportInitialize)p77);
		game.smethod_48((ISupportInitialize)p67);
		game.smethod_48((ISupportInitialize)p57);
		game.smethod_48((ISupportInitialize)p47);
		game.smethod_48((ISupportInitialize)p37);
		game.smethod_48((ISupportInitialize)p27);
		game.smethod_48((ISupportInitialize)p17);
		game.smethod_48((ISupportInitialize)p88);
		game.smethod_48((ISupportInitialize)p78);
		game.smethod_48((ISupportInitialize)p68);
		game.smethod_48((ISupportInitialize)p58);
		game.smethod_48((ISupportInitialize)p48);
		game.smethod_48((ISupportInitialize)p38);
		game.smethod_48((ISupportInitialize)p28);
		game.smethod_48((ISupportInitialize)p81);
		game.smethod_48((ISupportInitialize)board);
		game.smethod_48((ISupportInitialize)pictureBox1);
		game.smethod_48((ISupportInitialize)pictureBox2);
		game.smethod_48((ISupportInitialize)pictureBox3);
		game.smethod_48((ISupportInitialize)pictureBox4);
		game.smethod_48((ISupportInitialize)pictureBox5);
		game.smethod_48((ISupportInitialize)pictureBox6);
		game.smethod_48((ISupportInitialize)pictureBox7);
		game.smethod_48((ISupportInitialize)pictureBox8);
		game.smethod_48((ISupportInitialize)pictureBox9);
		game.smethod_48((ISupportInitialize)pictureBox10);
		game.smethod_48((ISupportInitialize)pictureBox11);
		game.smethod_48((ISupportInitialize)pictureBox12);
		game.smethod_48((ISupportInitialize)pictureBox13);
		game.smethod_48((ISupportInitialize)pictureBox14);
		game.smethod_48((ISupportInitialize)pictureBox15);
		game.smethod_48((ISupportInitialize)pictureBox16);
		game.smethod_48((ISupportInitialize)pictureBox17);
		game.smethod_48((ISupportInitialize)pictureBox18);
		game.smethod_48((ISupportInitialize)pictureBox19);
		game.smethod_48((ISupportInitialize)pictureBox20);
		game.smethod_48((ISupportInitialize)pictureBox21);
		game.smethod_48((ISupportInitialize)pictureBox22);
		game.smethod_48((ISupportInitialize)pictureBox23);
		game.smethod_48((ISupportInitialize)pictureBox24);
		game.smethod_48((ISupportInitialize)pictureBox25);
		game.smethod_48((ISupportInitialize)pictureBox26);
		game.smethod_48((ISupportInitialize)pictureBox27);
		game.smethod_48((ISupportInitialize)pictureBox28);
		game.smethod_48((ISupportInitialize)pictureBox29);
		game.smethod_48((ISupportInitialize)pictureBox30);
		game.smethod_48((ISupportInitialize)pictureBox31);
		game.smethod_48((ISupportInitialize)pictureBox32);
		game.smethod_48((ISupportInitialize)pictureBox33);
		game.smethod_48((ISupportInitialize)pictureBox34);
		game.smethod_48((ISupportInitialize)pictureBox35);
		game.smethod_48((ISupportInitialize)pictureBox36);
		game.smethod_48((ISupportInitialize)pictureBox37);
		game.smethod_48((ISupportInitialize)pictureBox38);
		game.smethod_48((ISupportInitialize)pictureBox39);
		game.smethod_48((ISupportInitialize)pictureBox40);
		game.smethod_48((ISupportInitialize)pictureBox41);
		game.smethod_48((ISupportInitialize)pictureBox42);
		game.smethod_48((ISupportInitialize)pictureBox43);
		game.smethod_48((ISupportInitialize)pictureBox44);
		game.smethod_48((ISupportInitialize)pictureBox45);
		game.smethod_48((ISupportInitialize)pictureBox46);
		game.smethod_48((ISupportInitialize)pictureBox47);
		game.smethod_48((ISupportInitialize)pictureBox48);
		game.smethod_48((ISupportInitialize)pictureBox49);
		game.smethod_48((ISupportInitialize)pictureBox50);
		game.smethod_48((ISupportInitialize)pictureBox51);
		game.smethod_48((ISupportInitialize)pictureBox52);
		game.smethod_48((ISupportInitialize)pictureBox53);
		game.smethod_48((ISupportInitialize)pictureBox54);
		game.smethod_48((ISupportInitialize)pictureBox55);
		game.smethod_48((ISupportInitialize)pictureBox56);
		game.smethod_48((ISupportInitialize)pictureBox57);
		game.smethod_48((ISupportInitialize)pictureBox58);
		game.smethod_48((ISupportInitialize)pictureBox59);
		game.smethod_48((ISupportInitialize)pictureBox60);
		game.smethod_48((ISupportInitialize)pictureBox61);
		game.smethod_48((ISupportInitialize)pictureBox62);
		game.smethod_48((ISupportInitialize)pictureBox63);
		game.smethod_48((ISupportInitialize)pictureBox64);
		game.smethod_48((ISupportInitialize)pictureBox65);
		game.smethod_48((ISupportInitialize)pictureBox66);
		game.smethod_48((ISupportInitialize)pictureBox67);
		game.smethod_49((Control)(object)this, bool_0: false);
		game.smethod_50((Control)(object)this);
	}

	static void smethod_0(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
	{
		RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
	}

	static void smethod_1(Control control_0, bool bool_0)
	{
		control_0.set_Visible(bool_0);
	}

	static string smethod_2(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static void smethod_3(Control control_0, string string_0)
	{
		control_0.set_Text(string_0);
	}

	static void smethod_4(Control control_0, bool bool_0)
	{
		control_0.set_Enabled(bool_0);
	}

	static void smethod_5(Control control_0, Color color_0)
	{
		control_0.set_BackColor(color_0);
	}

	static void smethod_6(Timer timer_0, bool bool_0)
	{
		timer_0.set_Enabled(bool_0);
	}

	static void smethod_7(Timer timer_0, int int_0)
	{
		timer_0.set_Interval(int_0);
	}

	static DialogResult smethod_8(string string_0, string string_1, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0, MessageBoxDefaultButton messageBoxDefaultButton_0, MessageBoxOptions messageBoxOptions_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0, string_1, messageBoxButtons_0, messageBoxIcon_0, messageBoxDefaultButton_0, messageBoxOptions_0);
	}

	static void smethod_9()
	{
		Application.Exit();
	}

	static int smethod_10(int int_0)
	{
		return Math.Abs(int_0);
	}

	static string smethod_11(string string_0, string string_1, string string_2)
	{
		return string_0 + string_1 + string_2;
	}

	static int smethod_12(Control control_0)
	{
		return control_0.get_Top();
	}

	static int smethod_13(Control control_0)
	{
		return control_0.get_Left();
	}

	static bool smethod_14(string string_0, string string_1)
	{
		return string_0 != string_1;
	}

	static bool smethod_15(string string_0, string string_1)
	{
		return string_0 == string_1;
	}

	static Image smethod_16(Control control_0)
	{
		return control_0.get_BackgroundImage();
	}

	static void smethod_17(Control control_0, Image image_0)
	{
		control_0.set_BackgroundImage(image_0);
	}

	static void smethod_18(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Container smethod_19()
	{
		return new Container();
	}

	static Timer smethod_20(IContainer icontainer_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new Timer(icontainer_0);
	}

	static Button smethod_21()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Button();
	}

	static Label smethod_22()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Label();
	}

	static PictureBox smethod_23()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new PictureBox();
	}

	static void smethod_24(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.BeginInit();
	}

	static void smethod_25(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_26(Timer timer_0, EventHandler eventHandler_0)
	{
		timer_0.add_Tick(eventHandler_0);
	}

	static Font smethod_27(string string_0, float float_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new Font(string_0, float_0);
	}

	static void smethod_28(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static void smethod_29(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_30(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_31(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_32(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static void smethod_33(ButtonBase buttonBase_0, bool bool_0)
	{
		buttonBase_0.set_UseVisualStyleBackColor(bool_0);
	}

	static void smethod_34(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_Click(eventHandler_0);
	}

	static Color smethod_35()
	{
		return SystemColors.ActiveCaptionText;
	}

	static void smethod_36(Control control_0, bool bool_0)
	{
		control_0.set_AutoSize(bool_0);
	}

	static void smethod_37(Control control_0, ImageLayout imageLayout_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_BackgroundImageLayout(imageLayout_0);
	}

	static void smethod_38(PictureBox pictureBox_0, int int_0)
	{
		pictureBox_0.set_TabIndex(int_0);
	}

	static void smethod_39(PictureBox pictureBox_0, bool bool_0)
	{
		pictureBox_0.set_TabStop(bool_0);
	}

	static void smethod_40(Control control_0, Padding padding_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_Margin(padding_0);
	}

	static void smethod_41(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_42(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_43(Form form_0, Size size_0)
	{
		form_0.set_ClientSize(size_0);
	}

	static ControlCollection smethod_44(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_45(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_46(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_47(Form form_0, EventHandler eventHandler_0)
	{
		form_0.add_Load(eventHandler_0);
	}

	static void smethod_48(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.EndInit();
	}

	static void smethod_49(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_50(Control control_0)
	{
		control_0.PerformLayout();
	}
}
