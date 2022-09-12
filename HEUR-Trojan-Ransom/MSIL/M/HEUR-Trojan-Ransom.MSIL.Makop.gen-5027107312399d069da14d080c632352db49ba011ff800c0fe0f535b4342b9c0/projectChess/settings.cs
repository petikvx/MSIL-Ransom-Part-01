using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace projectChess;

public class settings : Form
{
	public static bool timer;

	public static int time;

	private IContainer components = null;

	private Button back;

	private GroupBox groupBox1;

	private RadioButton time2;

	private RadioButton time1;

	private TextBox textBox1;

	private TextBox textBox2;

	private GroupBox groupBox2;

	private RadioButton radioButton1;

	private RadioButton radioButton2;

	private Button button1;

	private TextBox textBox3;

	private GroupBox groupBox3;

	private RadioButton radioButton3;

	private RadioButton radioButton4;

	private Button button2;

	private TextBox textBox4;

	private GroupBox groupBox4;

	private RadioButton radioButton5;

	private RadioButton radioButton6;

	private Button button3;

	private TextBox textBox5;

	private GroupBox groupBox5;

	private RadioButton radioButton7;

	private RadioButton radioButton8;

	private Button button4;

	private TextBox textBox6;

	private GroupBox groupBox6;

	private RadioButton radioButton9;

	private RadioButton radioButton10;

	private Button button5;

	private TextBox textBox7;

	private GroupBox groupBox7;

	private RadioButton radioButton11;

	private RadioButton radioButton12;

	private Button button6;

	private TextBox textBox8;

	private GroupBox groupBox8;

	private RadioButton radioButton13;

	private RadioButton radioButton14;

	private Button button7;

	private TextBox textBox9;

	private GroupBox groupBox9;

	private RadioButton radioButton15;

	private RadioButton radioButton16;

	private Button button8;

	private TextBox textBox10;

	private GroupBox groupBox10;

	private RadioButton radioButton17;

	private RadioButton radioButton18;

	private Button button9;

	private TextBox textBox11;

	private GroupBox groupBox11;

	private RadioButton radioButton19;

	private RadioButton radioButton20;

	private Button button10;

	private TextBox textBox12;

	private GroupBox groupBox12;

	private RadioButton radioButton21;

	private RadioButton radioButton22;

	private Button button11;

	private TextBox textBox13;

	private GroupBox groupBox13;

	private RadioButton radioButton23;

	private RadioButton radioButton24;

	private Button button12;

	private TextBox textBox14;

	private GroupBox groupBox14;

	private RadioButton radioButton25;

	private RadioButton radioButton26;

	private Button button13;

	private TextBox textBox15;

	private GroupBox groupBox15;

	private RadioButton radioButton27;

	private RadioButton radioButton28;

	private Button button14;

	private TextBox textBox16;

	private GroupBox groupBox16;

	private RadioButton radioButton29;

	private RadioButton radioButton30;

	private Button button15;

	private TextBox textBox17;

	private GroupBox groupBox17;

	private RadioButton radioButton31;

	private RadioButton radioButton32;

	private Button button16;

	private TextBox textBox18;

	private GroupBox groupBox18;

	private RadioButton radioButton33;

	private RadioButton radioButton34;

	private Button button17;

	private TextBox textBox19;

	private GroupBox groupBox19;

	private RadioButton radioButton35;

	private RadioButton radioButton36;

	private Button button18;

	private TextBox textBox20;

	private GroupBox groupBox20;

	private RadioButton radioButton37;

	private RadioButton radioButton38;

	private Button button19;

	private TextBox textBox21;

	private GroupBox groupBox21;

	private RadioButton radioButton39;

	private RadioButton radioButton40;

	private Button button20;

	public settings()
	{
		InitializeComponent();
	}

	private void back_Click(object sender, EventArgs e)
	{
		mainmenu control_ = new mainmenu();
		settings.smethod_0((Control)(object)control_);
		settings.smethod_1((Control)(object)this, bool_0: false);
	}

	private void settings_Load(object sender, EventArgs e)
	{
	}

	private void radioButton1_CheckedChanged(object sender, EventArgs e)
	{
		timer = false;
		settings.smethod_2((Control)(object)textBox1, bool_0: false);
		time = 0;
	}

	private void radioButton2_CheckedChanged(object sender, EventArgs e)
	{
		timer = true;
		settings.smethod_2((Control)(object)textBox1, bool_0: true);
	}

	private void textBox1_TextChanged(object sender, EventArgs e)
	{
		time = int.Parse(settings.smethod_3((Control)(object)textBox1));
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			settings.smethod_4((IDisposable)components);
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		back = settings.smethod_5();
		groupBox1 = settings.smethod_6();
		time2 = settings.smethod_7();
		time1 = settings.smethod_7();
		textBox1 = settings.smethod_8();
		textBox2 = settings.smethod_8();
		groupBox2 = settings.smethod_6();
		radioButton1 = settings.smethod_7();
		radioButton2 = settings.smethod_7();
		button1 = settings.smethod_5();
		textBox3 = settings.smethod_8();
		groupBox3 = settings.smethod_6();
		radioButton3 = settings.smethod_7();
		radioButton4 = settings.smethod_7();
		button2 = settings.smethod_5();
		textBox4 = settings.smethod_8();
		groupBox4 = settings.smethod_6();
		radioButton5 = settings.smethod_7();
		radioButton6 = settings.smethod_7();
		button3 = settings.smethod_5();
		textBox5 = settings.smethod_8();
		groupBox5 = settings.smethod_6();
		radioButton7 = settings.smethod_7();
		radioButton8 = settings.smethod_7();
		button4 = settings.smethod_5();
		textBox6 = settings.smethod_8();
		groupBox6 = settings.smethod_6();
		radioButton9 = settings.smethod_7();
		radioButton10 = settings.smethod_7();
		button5 = settings.smethod_5();
		textBox7 = settings.smethod_8();
		groupBox7 = settings.smethod_6();
		radioButton11 = settings.smethod_7();
		radioButton12 = settings.smethod_7();
		button6 = settings.smethod_5();
		textBox8 = settings.smethod_8();
		groupBox8 = settings.smethod_6();
		radioButton13 = settings.smethod_7();
		radioButton14 = settings.smethod_7();
		button7 = settings.smethod_5();
		textBox9 = settings.smethod_8();
		groupBox9 = settings.smethod_6();
		radioButton15 = settings.smethod_7();
		radioButton16 = settings.smethod_7();
		button8 = settings.smethod_5();
		textBox10 = settings.smethod_8();
		groupBox10 = settings.smethod_6();
		radioButton17 = settings.smethod_7();
		radioButton18 = settings.smethod_7();
		button9 = settings.smethod_5();
		textBox11 = settings.smethod_8();
		groupBox11 = settings.smethod_6();
		radioButton19 = settings.smethod_7();
		radioButton20 = settings.smethod_7();
		button10 = settings.smethod_5();
		textBox12 = settings.smethod_8();
		groupBox12 = settings.smethod_6();
		radioButton21 = settings.smethod_7();
		radioButton22 = settings.smethod_7();
		button11 = settings.smethod_5();
		textBox13 = settings.smethod_8();
		groupBox13 = settings.smethod_6();
		radioButton23 = settings.smethod_7();
		radioButton24 = settings.smethod_7();
		button12 = settings.smethod_5();
		textBox14 = settings.smethod_8();
		groupBox14 = settings.smethod_6();
		radioButton25 = settings.smethod_7();
		radioButton26 = settings.smethod_7();
		button13 = settings.smethod_5();
		textBox15 = settings.smethod_8();
		groupBox15 = settings.smethod_6();
		radioButton27 = settings.smethod_7();
		radioButton28 = settings.smethod_7();
		button14 = settings.smethod_5();
		textBox16 = settings.smethod_8();
		groupBox16 = settings.smethod_6();
		radioButton29 = settings.smethod_7();
		radioButton30 = settings.smethod_7();
		button15 = settings.smethod_5();
		textBox17 = settings.smethod_8();
		groupBox17 = settings.smethod_6();
		radioButton31 = settings.smethod_7();
		radioButton32 = settings.smethod_7();
		button16 = settings.smethod_5();
		textBox18 = settings.smethod_8();
		groupBox18 = settings.smethod_6();
		radioButton33 = settings.smethod_7();
		radioButton34 = settings.smethod_7();
		button17 = settings.smethod_5();
		textBox19 = settings.smethod_8();
		groupBox19 = settings.smethod_6();
		radioButton35 = settings.smethod_7();
		radioButton36 = settings.smethod_7();
		button18 = settings.smethod_5();
		textBox20 = settings.smethod_8();
		groupBox20 = settings.smethod_6();
		radioButton37 = settings.smethod_7();
		radioButton38 = settings.smethod_7();
		button19 = settings.smethod_5();
		textBox21 = settings.smethod_8();
		groupBox21 = settings.smethod_6();
		radioButton39 = settings.smethod_7();
		radioButton40 = settings.smethod_7();
		button20 = settings.smethod_5();
		settings.smethod_9((Control)(object)groupBox1);
		settings.smethod_9((Control)(object)groupBox2);
		settings.smethod_9((Control)(object)groupBox3);
		settings.smethod_9((Control)(object)groupBox4);
		settings.smethod_9((Control)(object)groupBox5);
		settings.smethod_9((Control)(object)groupBox6);
		settings.smethod_9((Control)(object)groupBox7);
		settings.smethod_9((Control)(object)groupBox8);
		settings.smethod_9((Control)(object)groupBox9);
		settings.smethod_9((Control)(object)groupBox10);
		settings.smethod_9((Control)(object)groupBox11);
		settings.smethod_9((Control)(object)groupBox12);
		settings.smethod_9((Control)(object)groupBox13);
		settings.smethod_9((Control)(object)groupBox14);
		settings.smethod_9((Control)(object)groupBox15);
		settings.smethod_9((Control)(object)groupBox16);
		settings.smethod_9((Control)(object)groupBox17);
		settings.smethod_9((Control)(object)groupBox18);
		settings.smethod_9((Control)(object)groupBox19);
		settings.smethod_9((Control)(object)groupBox20);
		settings.smethod_9((Control)(object)groupBox21);
		settings.smethod_10((Control)(object)this);
		settings.smethod_12((Control)(object)back, settings.smethod_11("Microsoft Sans Serif", 38.25f));
		settings.smethod_13((Control)(object)back, new Point(186, 309));
		settings.smethod_14((Control)(object)back, "back");
		settings.smethod_15((Control)(object)back, new Size(249, 62));
		settings.smethod_16((Control)(object)back, 0);
		settings.smethod_17((Control)(object)back, "назад");
		settings.smethod_18((ButtonBase)(object)back, bool_0: true);
		settings.smethod_19((Control)(object)back, (EventHandler)back_Click);
		settings.smethod_21(settings.smethod_20((Control)(object)groupBox1), (Control)(object)time2);
		settings.smethod_21(settings.smethod_20((Control)(object)groupBox1), (Control)(object)time1);
		settings.smethod_12((Control)(object)groupBox1, settings.smethod_11("Microsoft Sans Serif", 38.25f));
		settings.smethod_13((Control)(object)groupBox1, new Point(166, 23));
		settings.smethod_14((Control)(object)groupBox1, "groupBox1");
		settings.smethod_15((Control)(object)groupBox1, new Size(306, 199));
		settings.smethod_16((Control)(object)groupBox1, 1);
		settings.smethod_22(groupBox1, bool_0: false);
		settings.smethod_17((Control)(object)groupBox1, "Вемя игры");
		settings.smethod_23((Control)(object)time2, bool_0: true);
		settings.smethod_12((Control)(object)time2, settings.smethod_11("Microsoft Sans Serif", 28.25f));
		settings.smethod_13((Control)(object)time2, new Point(20, 141));
		settings.smethod_14((Control)(object)time2, "time2");
		settings.smethod_15((Control)(object)time2, new Size(275, 48));
		settings.smethod_16((Control)(object)time2, 1);
		settings.smethod_24(time2, bool_0: true);
		settings.smethod_17((Control)(object)time2, "Со временем");
		settings.smethod_18((ButtonBase)(object)time2, bool_0: true);
		settings.smethod_25(time2, (EventHandler)radioButton2_CheckedChanged);
		settings.smethod_23((Control)(object)time1, bool_0: true);
		settings.smethod_12((Control)(object)time1, settings.smethod_11("Microsoft Sans Serif", 28.25f));
		settings.smethod_13((Control)(object)time1, new Point(20, 75));
		settings.smethod_14((Control)(object)time1, "time1");
		settings.smethod_15((Control)(object)time1, new Size(226, 48));
		settings.smethod_16((Control)(object)time1, 0);
		settings.smethod_24(time1, bool_0: true);
		settings.smethod_17((Control)(object)time1, "Бессрочно");
		settings.smethod_18((ButtonBase)(object)time1, bool_0: true);
		settings.smethod_25(time1, (EventHandler)radioButton1_CheckedChanged);
		settings.smethod_12((Control)(object)textBox1, settings.smethod_11("Microsoft Sans Serif", 18.25f));
		settings.smethod_13((Control)(object)textBox1, new Point(157, 252));
		settings.smethod_14((Control)(object)textBox1, "textBox1");
		settings.smethod_15((Control)(object)textBox1, new Size(315, 35));
		settings.smethod_16((Control)(object)textBox1, 2);
		settings.smethod_17((Control)(object)textBox1, "Введите_время_в_минутах");
		settings.smethod_2((Control)(object)textBox1, bool_0: false);
		settings.smethod_26((Control)(object)textBox1, (EventHandler)textBox1_TextChanged);
		settings.smethod_12((Control)(object)textBox2, settings.smethod_11("Microsoft Sans Serif", 18.25f));
		settings.smethod_13((Control)(object)textBox2, new Point(144, 257));
		settings.smethod_14((Control)(object)textBox2, "textBox2");
		settings.smethod_15((Control)(object)textBox2, new Size(315, 35));
		settings.smethod_16((Control)(object)textBox2, 5);
		settings.smethod_17((Control)(object)textBox2, "Введите_время_в_минутах");
		settings.smethod_2((Control)(object)textBox2, bool_0: false);
		settings.smethod_21(settings.smethod_20((Control)(object)groupBox2), (Control)(object)radioButton1);
		settings.smethod_21(settings.smethod_20((Control)(object)groupBox2), (Control)(object)radioButton2);
		settings.smethod_12((Control)(object)groupBox2, settings.smethod_11("Microsoft Sans Serif", 38.25f));
		settings.smethod_13((Control)(object)groupBox2, new Point(153, 28));
		settings.smethod_14((Control)(object)groupBox2, "groupBox2");
		settings.smethod_15((Control)(object)groupBox2, new Size(306, 199));
		settings.smethod_16((Control)(object)groupBox2, 4);
		settings.smethod_22(groupBox2, bool_0: false);
		settings.smethod_17((Control)(object)groupBox2, "Вемя игры");
		settings.smethod_23((Control)(object)radioButton1, bool_0: true);
		settings.smethod_12((Control)(object)radioButton1, settings.smethod_11("Microsoft Sans Serif", 28.25f));
		settings.smethod_13((Control)(object)radioButton1, new Point(20, 141));
		settings.smethod_14((Control)(object)radioButton1, "radioButton1");
		settings.smethod_15((Control)(object)radioButton1, new Size(275, 48));
		settings.smethod_16((Control)(object)radioButton1, 1);
		settings.smethod_24(radioButton1, bool_0: true);
		settings.smethod_17((Control)(object)radioButton1, "Со временем");
		settings.smethod_18((ButtonBase)(object)radioButton1, bool_0: true);
		settings.smethod_23((Control)(object)radioButton2, bool_0: true);
		settings.smethod_12((Control)(object)radioButton2, settings.smethod_11("Microsoft Sans Serif", 28.25f));
		settings.smethod_13((Control)(object)radioButton2, new Point(20, 75));
		settings.smethod_14((Control)(object)radioButton2, "radioButton2");
		settings.smethod_15((Control)(object)radioButton2, new Size(226, 48));
		settings.smethod_16((Control)(object)radioButton2, 0);
		settings.smethod_24(radioButton2, bool_0: true);
		settings.smethod_17((Control)(object)radioButton2, "Бессрочно");
		settings.smethod_18((ButtonBase)(object)radioButton2, bool_0: true);
		settings.smethod_12((Control)(object)button1, settings.smethod_11("Microsoft Sans Serif", 38.25f));
		settings.smethod_13((Control)(object)button1, new Point(173, 314));
		settings.smethod_14((Control)(object)button1, "button1");
		settings.smethod_15((Control)(object)button1, new Size(249, 62));
		settings.smethod_16((Control)(object)button1, 3);
		settings.smethod_17((Control)(object)button1, "назад");
		settings.smethod_18((ButtonBase)(object)button1, bool_0: true);
		settings.smethod_12((Control)(object)textBox3, settings.smethod_11("Microsoft Sans Serif", 18.25f));
		settings.smethod_13((Control)(object)textBox3, new Point(152, 265));
		settings.smethod_14((Control)(object)textBox3, "textBox3");
		settings.smethod_15((Control)(object)textBox3, new Size(315, 35));
		settings.smethod_16((Control)(object)textBox3, 8);
		settings.smethod_17((Control)(object)textBox3, "Введите_время_в_минутах");
		settings.smethod_2((Control)(object)textBox3, bool_0: false);
		settings.smethod_21(settings.smethod_20((Control)(object)groupBox3), (Control)(object)radioButton3);
		settings.smethod_21(settings.smethod_20((Control)(object)groupBox3), (Control)(object)radioButton4);
		settings.smethod_12((Control)(object)groupBox3, settings.smethod_11("Microsoft Sans Serif", 38.25f));
		settings.smethod_13((Control)(object)groupBox3, new Point(161, 36));
		settings.smethod_14((Control)(object)groupBox3, "groupBox3");
		settings.smethod_15((Control)(object)groupBox3, new Size(306, 199));
		settings.smethod_16((Control)(object)groupBox3, 7);
		settings.smethod_22(groupBox3, bool_0: false);
		settings.smethod_17((Control)(object)groupBox3, "Вемя игры");
		settings.smethod_23((Control)(object)radioButton3, bool_0: true);
		settings.smethod_12((Control)(object)radioButton3, settings.smethod_11("Microsoft Sans Serif", 28.25f));
		settings.smethod_13((Control)(object)radioButton3, new Point(20, 141));
		settings.smethod_14((Control)(object)radioButton3, "radioButton3");
		settings.smethod_15((Control)(object)radioButton3, new Size(275, 48));
		settings.smethod_16((Control)(object)radioButton3, 1);
		settings.smethod_24(radioButton3, bool_0: true);
		settings.smethod_17((Control)(object)radioButton3, "Со временем");
		settings.smethod_18((ButtonBase)(object)radioButton3, bool_0: true);
		settings.smethod_23((Control)(object)radioButton4, bool_0: true);
		settings.smethod_12((Control)(object)radioButton4, settings.smethod_11("Microsoft Sans Serif", 28.25f));
		settings.smethod_13((Control)(object)radioButton4, new Point(20, 75));
		settings.smethod_14((Control)(object)radioButton4, "radioButton4");
		settings.smethod_15((Control)(object)radioButton4, new Size(226, 48));
		settings.smethod_16((Control)(object)radioButton4, 0);
		settings.smethod_24(radioButton4, bool_0: true);
		settings.smethod_17((Control)(object)radioButton4, "Бессрочно");
		settings.smethod_18((ButtonBase)(object)radioButton4, bool_0: true);
		settings.smethod_12((Control)(object)button2, settings.smethod_11("Microsoft Sans Serif", 38.25f));
		settings.smethod_13((Control)(object)button2, new Point(181, 322));
		settings.smethod_14((Control)(object)button2, "button2");
		settings.smethod_15((Control)(object)button2, new Size(249, 62));
		settings.smethod_16((Control)(object)button2, 6);
		settings.smethod_17((Control)(object)button2, "назад");
		settings.smethod_18((ButtonBase)(object)button2, bool_0: true);
		settings.smethod_12((Control)(object)textBox4, settings.smethod_11("Microsoft Sans Serif", 18.25f));
		settings.smethod_13((Control)(object)textBox4, new Point(160, 273));
		settings.smethod_14((Control)(object)textBox4, "textBox4");
		settings.smethod_15((Control)(object)textBox4, new Size(315, 35));
		settings.smethod_16((Control)(object)textBox4, 11);
		settings.smethod_17((Control)(object)textBox4, "Введите_время_в_минутах");
		settings.smethod_2((Control)(object)textBox4, bool_0: false);
		settings.smethod_21(settings.smethod_20((Control)(object)groupBox4), (Control)(object)radioButton5);
		settings.smethod_21(settings.smethod_20((Control)(object)groupBox4), (Control)(object)radioButton6);
		settings.smethod_12((Control)(object)groupBox4, settings.smethod_11("Microsoft Sans Serif", 38.25f));
		settings.smethod_13((Control)(object)groupBox4, new Point(169, 44));
		settings.smethod_14((Control)(object)groupBox4, "groupBox4");
		settings.smethod_15((Control)(object)groupBox4, new Size(306, 199));
		settings.smethod_16((Control)(object)groupBox4, 10);
		settings.smethod_22(groupBox4, bool_0: false);
		settings.smethod_17((Control)(object)groupBox4, "Вемя игры");
		settings.smethod_23((Control)(object)radioButton5, bool_0: true);
		settings.smethod_12((Control)(object)radioButton5, settings.smethod_11("Microsoft Sans Serif", 28.25f));
		settings.smethod_13((Control)(object)radioButton5, new Point(20, 141));
		settings.smethod_14((Control)(object)radioButton5, "radioButton5");
		settings.smethod_15((Control)(object)radioButton5, new Size(275, 48));
		settings.smethod_16((Control)(object)radioButton5, 1);
		settings.smethod_24(radioButton5, bool_0: true);
		settings.smethod_17((Control)(object)radioButton5, "Со временем");
		settings.smethod_18((ButtonBase)(object)radioButton5, bool_0: true);
		settings.smethod_23((Control)(object)radioButton6, bool_0: true);
		settings.smethod_12((Control)(object)radioButton6, settings.smethod_11("Microsoft Sans Serif", 28.25f));
		settings.smethod_13((Control)(object)radioButton6, new Point(20, 75));
		settings.smethod_14((Control)(object)radioButton6, "radioButton6");
		settings.smethod_15((Control)(object)radioButton6, new Size(226, 48));
		settings.smethod_16((Control)(object)radioButton6, 0);
		settings.smethod_24(radioButton6, bool_0: true);
		settings.smethod_17((Control)(object)radioButton6, "Бессрочно");
		settings.smethod_18((ButtonBase)(object)radioButton6, bool_0: true);
		settings.smethod_12((Control)(object)button3, settings.smethod_11("Microsoft Sans Serif", 38.25f));
		settings.smethod_13((Control)(object)button3, new Point(189, 330));
		settings.smethod_14((Control)(object)button3, "button3");
		settings.smethod_15((Control)(object)button3, new Size(249, 62));
		settings.smethod_16((Control)(object)button3, 9);
		settings.smethod_17((Control)(object)button3, "назад");
		settings.smethod_18((ButtonBase)(object)button3, bool_0: true);
		settings.smethod_12((Control)(object)textBox5, settings.smethod_11("Microsoft Sans Serif", 18.25f));
		settings.smethod_13((Control)(object)textBox5, new Point(168, 281));
		settings.smethod_14((Control)(object)textBox5, "textBox5");
		settings.smethod_15((Control)(object)textBox5, new Size(315, 35));
		settings.smethod_16((Control)(object)textBox5, 14);
		settings.smethod_17((Control)(object)textBox5, "Введите_время_в_минутах");
		settings.smethod_2((Control)(object)textBox5, bool_0: false);
		settings.smethod_21(settings.smethod_20((Control)(object)groupBox5), (Control)(object)radioButton7);
		settings.smethod_21(settings.smethod_20((Control)(object)groupBox5), (Control)(object)radioButton8);
		settings.smethod_12((Control)(object)groupBox5, settings.smethod_11("Microsoft Sans Serif", 38.25f));
		settings.smethod_13((Control)(object)groupBox5, new Point(177, 52));
		settings.smethod_14((Control)(object)groupBox5, "groupBox5");
		settings.smethod_15((Control)(object)groupBox5, new Size(306, 199));
		settings.smethod_16((Control)(object)groupBox5, 13);
		settings.smethod_22(groupBox5, bool_0: false);
		settings.smethod_17((Control)(object)groupBox5, "Вемя игры");
		settings.smethod_23((Control)(object)radioButton7, bool_0: true);
		settings.smethod_12((Control)(object)radioButton7, settings.smethod_11("Microsoft Sans Serif", 28.25f));
		settings.smethod_13((Control)(object)radioButton7, new Point(20, 141));
		settings.smethod_14((Control)(object)radioButton7, "radioButton7");
		settings.smethod_15((Control)(object)radioButton7, new Size(275, 48));
		settings.smethod_16((Control)(object)radioButton7, 1);
		settings.smethod_24(radioButton7, bool_0: true);
		settings.smethod_17((Control)(object)radioButton7, "Со временем");
		settings.smethod_18((ButtonBase)(object)radioButton7, bool_0: true);
		settings.smethod_23((Control)(object)radioButton8, bool_0: true);
		settings.smethod_12((Control)(object)radioButton8, settings.smethod_11("Microsoft Sans Serif", 28.25f));
		settings.smethod_13((Control)(object)radioButton8, new Point(20, 75));
		settings.smethod_14((Control)(object)radioButton8, "radioButton8");
		settings.smethod_15((Control)(object)radioButton8, new Size(226, 48));
		settings.smethod_16((Control)(object)radioButton8, 0);
		settings.smethod_24(radioButton8, bool_0: true);
		settings.smethod_17((Control)(object)radioButton8, "Бессрочно");
		settings.smethod_18((ButtonBase)(object)radioButton8, bool_0: true);
		settings.smethod_12((Control)(object)button4, settings.smethod_11("Microsoft Sans Serif", 38.25f));
		settings.smethod_13((Control)(object)button4, new Point(197, 338));
		settings.smethod_14((Control)(object)button4, "button4");
		settings.smethod_15((Control)(object)button4, new Size(249, 62));
		settings.smethod_16((Control)(object)button4, 12);
		settings.smethod_17((Control)(object)button4, "назад");
		settings.smethod_18((ButtonBase)(object)button4, bool_0: true);
		settings.smethod_12((Control)(object)textBox6, settings.smethod_11("Microsoft Sans Serif", 18.25f));
		settings.smethod_13((Control)(object)textBox6, new Point(0, 229));
		settings.smethod_14((Control)(object)textBox6, "textBox6");
		settings.smethod_15((Control)(object)textBox6, new Size(315, 35));
		settings.smethod_16((Control)(object)textBox6, 17);
		settings.smethod_17((Control)(object)textBox6, "Введите_время_в_минутах");
		settings.smethod_2((Control)(object)textBox6, bool_0: false);
		settings.smethod_21(settings.smethod_20((Control)(object)groupBox6), (Control)(object)radioButton9);
		settings.smethod_21(settings.smethod_20((Control)(object)groupBox6), (Control)(object)radioButton10);
		settings.smethod_12((Control)(object)groupBox6, settings.smethod_11("Microsoft Sans Serif", 38.25f));
		settings.smethod_13((Control)(object)groupBox6, new Point(9, 0));
		settings.smethod_14((Control)(object)groupBox6, "groupBox6");
		settings.smethod_15((Control)(object)groupBox6, new Size(306, 199));
		settings.smethod_16((Control)(object)groupBox6, 16);
		settings.smethod_22(groupBox6, bool_0: false);
		settings.smethod_17((Control)(object)groupBox6, "Вемя игры");
		settings.smethod_23((Control)(object)radioButton9, bool_0: true);
		settings.smethod_12((Control)(object)radioButton9, settings.smethod_11("Microsoft Sans Serif", 28.25f));
		settings.smethod_13((Control)(object)radioButton9, new Point(20, 141));
		settings.smethod_14((Control)(object)radioButton9, "radioButton9");
		settings.smethod_15((Control)(object)radioButton9, new Size(275, 48));
		settings.smethod_16((Control)(object)radioButton9, 1);
		settings.smethod_24(radioButton9, bool_0: true);
		settings.smethod_17((Control)(object)radioButton9, "Со временем");
		settings.smethod_18((ButtonBase)(object)radioButton9, bool_0: true);
		settings.smethod_23((Control)(object)radioButton10, bool_0: true);
		settings.smethod_12((Control)(object)radioButton10, settings.smethod_11("Microsoft Sans Serif", 28.25f));
		settings.smethod_13((Control)(object)radioButton10, new Point(20, 75));
		settings.smethod_14((Control)(object)radioButton10, "radioButton10");
		settings.smethod_15((Control)(object)radioButton10, new Size(226, 48));
		settings.smethod_16((Control)(object)radioButton10, 0);
		settings.smethod_24(radioButton10, bool_0: true);
		settings.smethod_17((Control)(object)radioButton10, "Бессрочно");
		settings.smethod_18((ButtonBase)(object)radioButton10, bool_0: true);
		settings.smethod_12((Control)(object)button5, settings.smethod_11("Microsoft Sans Serif", 38.25f));
		settings.smethod_13((Control)(object)button5, new Point(29, 286));
		settings.smethod_14((Control)(object)button5, "button5");
		settings.smethod_15((Control)(object)button5, new Size(249, 62));
		settings.smethod_16((Control)(object)button5, 15);
		settings.smethod_17((Control)(object)button5, "назад");
		settings.smethod_18((ButtonBase)(object)button5, bool_0: true);
		settings.smethod_12((Control)(object)textBox7, settings.smethod_11("Microsoft Sans Serif", 18.25f));
		settings.smethod_13((Control)(object)textBox7, new Point(8, 237));
		settings.smethod_14((Control)(object)textBox7, "textBox7");
		settings.smethod_15((Control)(object)textBox7, new Size(315, 35));
		settings.smethod_16((Control)(object)textBox7, 20);
		settings.smethod_17((Control)(object)textBox7, "Введите_время_в_минутах");
		settings.smethod_2((Control)(object)textBox7, bool_0: false);
		settings.smethod_21(settings.smethod_20((Control)(object)groupBox7), (Control)(object)radioButton11);
		settings.smethod_21(settings.smethod_20((Control)(object)groupBox7), (Control)(object)radioButton12);
		settings.smethod_12((Control)(object)groupBox7, settings.smethod_11("Microsoft Sans Serif", 38.25f));
		settings.smethod_13((Control)(object)groupBox7, new Point(17, 8));
		settings.smethod_14((Control)(object)groupBox7, "groupBox7");
		settings.smethod_15((Control)(object)groupBox7, new Size(306, 199));
		settings.smethod_16((Control)(object)groupBox7, 19);
		settings.smethod_22(groupBox7, bool_0: false);
		settings.smethod_17((Control)(object)groupBox7, "Вемя игры");
		settings.smethod_23((Control)(object)radioButton11, bool_0: true);
		settings.smethod_12((Control)(object)radioButton11, settings.smethod_11("Microsoft Sans Serif", 28.25f));
		settings.smethod_13((Control)(object)radioButton11, new Point(20, 141));
		settings.smethod_14((Control)(object)radioButton11, "radioButton11");
		settings.smethod_15((Control)(object)radioButton11, new Size(275, 48));
		settings.smethod_16((Control)(object)radioButton11, 1);
		settings.smethod_24(radioButton11, bool_0: true);
		settings.smethod_17((Control)(object)radioButton11, "Со временем");
		settings.smethod_18((ButtonBase)(object)radioButton11, bool_0: true);
		settings.smethod_23((Control)(object)radioButton12, bool_0: true);
		settings.smethod_12((Control)(object)radioButton12, settings.smethod_11("Microsoft Sans Serif", 28.25f));
		settings.smethod_13((Control)(object)radioButton12, new Point(20, 75));
		settings.smethod_14((Control)(object)radioButton12, "radioButton12");
		settings.smethod_15((Control)(object)radioButton12, new Size(226, 48));
		settings.smethod_16((Control)(object)radioButton12, 0);
		settings.smethod_24(radioButton12, bool_0: true);
		settings.smethod_17((Control)(object)radioButton12, "Бессрочно");
		settings.smethod_18((ButtonBase)(object)radioButton12, bool_0: true);
		settings.smethod_12((Control)(object)button6, settings.smethod_11("Microsoft Sans Serif", 38.25f));
		settings.smethod_13((Control)(object)button6, new Point(37, 294));
		settings.smethod_14((Control)(object)button6, "button6");
		settings.smethod_15((Control)(object)button6, new Size(249, 62));
		settings.smethod_16((Control)(object)button6, 18);
		settings.smethod_17((Control)(object)button6, "назад");
		settings.smethod_18((ButtonBase)(object)button6, bool_0: true);
		settings.smethod_12((Control)(object)textBox8, settings.smethod_11("Microsoft Sans Serif", 18.25f));
		settings.smethod_13((Control)(object)textBox8, new Point(16, 245));
		settings.smethod_14((Control)(object)textBox8, "textBox8");
		settings.smethod_15((Control)(object)textBox8, new Size(315, 35));
		settings.smethod_16((Control)(object)textBox8, 23);
		settings.smethod_17((Control)(object)textBox8, "Введите_время_в_минутах");
		settings.smethod_2((Control)(object)textBox8, bool_0: false);
		settings.smethod_21(settings.smethod_20((Control)(object)groupBox8), (Control)(object)radioButton13);
		settings.smethod_21(settings.smethod_20((Control)(object)groupBox8), (Control)(object)radioButton14);
		settings.smethod_12((Control)(object)groupBox8, settings.smethod_11("Microsoft Sans Serif", 38.25f));
		settings.smethod_13((Control)(object)groupBox8, new Point(25, 16));
		settings.smethod_14((Control)(object)groupBox8, "groupBox8");
		settings.smethod_15((Control)(object)groupBox8, new Size(306, 199));
		settings.smethod_16((Control)(object)groupBox8, 22);
		settings.smethod_22(groupBox8, bool_0: false);
		settings.smethod_17((Control)(object)groupBox8, "Вемя игры");
		settings.smethod_23((Control)(object)radioButton13, bool_0: true);
		settings.smethod_12((Control)(object)radioButton13, settings.smethod_11("Microsoft Sans Serif", 28.25f));
		settings.smethod_13((Control)(object)radioButton13, new Point(20, 141));
		settings.smethod_14((Control)(object)radioButton13, "radioButton13");
		settings.smethod_15((Control)(object)radioButton13, new Size(275, 48));
		settings.smethod_16((Control)(object)radioButton13, 1);
		settings.smethod_24(radioButton13, bool_0: true);
		settings.smethod_17((Control)(object)radioButton13, "Со временем");
		settings.smethod_18((ButtonBase)(object)radioButton13, bool_0: true);
		settings.smethod_23((Control)(object)radioButton14, bool_0: true);
		settings.smethod_12((Control)(object)radioButton14, settings.smethod_11("Microsoft Sans Serif", 28.25f));
		settings.smethod_13((Control)(object)radioButton14, new Point(20, 75));
		settings.smethod_14((Control)(object)radioButton14, "radioButton14");
		settings.smethod_15((Control)(object)radioButton14, new Size(226, 48));
		settings.smethod_16((Control)(object)radioButton14, 0);
		settings.smethod_24(radioButton14, bool_0: true);
		settings.smethod_17((Control)(object)radioButton14, "Бессрочно");
		settings.smethod_18((ButtonBase)(object)radioButton14, bool_0: true);
		settings.smethod_12((Control)(object)button7, settings.smethod_11("Microsoft Sans Serif", 38.25f));
		settings.smethod_13((Control)(object)button7, new Point(45, 302));
		settings.smethod_14((Control)(object)button7, "button7");
		settings.smethod_15((Control)(object)button7, new Size(249, 62));
		settings.smethod_16((Control)(object)button7, 21);
		settings.smethod_17((Control)(object)button7, "назад");
		settings.smethod_18((ButtonBase)(object)button7, bool_0: true);
		settings.smethod_12((Control)(object)textBox9, settings.smethod_11("Microsoft Sans Serif", 18.25f));
		settings.smethod_13((Control)(object)textBox9, new Point(24, 253));
		settings.smethod_14((Control)(object)textBox9, "textBox9");
		settings.smethod_15((Control)(object)textBox9, new Size(315, 35));
		settings.smethod_16((Control)(object)textBox9, 26);
		settings.smethod_17((Control)(object)textBox9, "Введите_время_в_минутах");
		settings.smethod_2((Control)(object)textBox9, bool_0: false);
		settings.smethod_21(settings.smethod_20((Control)(object)groupBox9), (Control)(object)radioButton15);
		settings.smethod_21(settings.smethod_20((Control)(object)groupBox9), (Control)(object)radioButton16);
		settings.smethod_12((Control)(object)groupBox9, settings.smethod_11("Microsoft Sans Serif", 38.25f));
		settings.smethod_13((Control)(object)groupBox9, new Point(33, 24));
		settings.smethod_14((Control)(object)groupBox9, "groupBox9");
		settings.smethod_15((Control)(object)groupBox9, new Size(306, 199));
		settings.smethod_16((Control)(object)groupBox9, 25);
		settings.smethod_22(groupBox9, bool_0: false);
		settings.smethod_17((Control)(object)groupBox9, "Вемя игры");
		settings.smethod_23((Control)(object)radioButton15, bool_0: true);
		settings.smethod_12((Control)(object)radioButton15, settings.smethod_11("Microsoft Sans Serif", 28.25f));
		settings.smethod_13((Control)(object)radioButton15, new Point(20, 141));
		settings.smethod_14((Control)(object)radioButton15, "radioButton15");
		settings.smethod_15((Control)(object)radioButton15, new Size(275, 48));
		settings.smethod_16((Control)(object)radioButton15, 1);
		settings.smethod_24(radioButton15, bool_0: true);
		settings.smethod_17((Control)(object)radioButton15, "Со временем");
		settings.smethod_18((ButtonBase)(object)radioButton15, bool_0: true);
		settings.smethod_23((Control)(object)radioButton16, bool_0: true);
		settings.smethod_12((Control)(object)radioButton16, settings.smethod_11("Microsoft Sans Serif", 28.25f));
		settings.smethod_13((Control)(object)radioButton16, new Point(20, 75));
		settings.smethod_14((Control)(object)radioButton16, "radioButton16");
		settings.smethod_15((Control)(object)radioButton16, new Size(226, 48));
		settings.smethod_16((Control)(object)radioButton16, 0);
		settings.smethod_24(radioButton16, bool_0: true);
		settings.smethod_17((Control)(object)radioButton16, "Бессрочно");
		settings.smethod_18((ButtonBase)(object)radioButton16, bool_0: true);
		settings.smethod_12((Control)(object)button8, settings.smethod_11("Microsoft Sans Serif", 38.25f));
		settings.smethod_13((Control)(object)button8, new Point(53, 310));
		settings.smethod_14((Control)(object)button8, "button8");
		settings.smethod_15((Control)(object)button8, new Size(249, 62));
		settings.smethod_16((Control)(object)button8, 24);
		settings.smethod_17((Control)(object)button8, "назад");
		settings.smethod_18((ButtonBase)(object)button8, bool_0: true);
		settings.smethod_12((Control)(object)textBox10, settings.smethod_11("Microsoft Sans Serif", 18.25f));
		settings.smethod_13((Control)(object)textBox10, new Point(32, 261));
		settings.smethod_14((Control)(object)textBox10, "textBox10");
		settings.smethod_15((Control)(object)textBox10, new Size(315, 35));
		settings.smethod_16((Control)(object)textBox10, 29);
		settings.smethod_17((Control)(object)textBox10, "Введите_время_в_минутах");
		settings.smethod_2((Control)(object)textBox10, bool_0: false);
		settings.smethod_21(settings.smethod_20((Control)(object)groupBox10), (Control)(object)radioButton17);
		settings.smethod_21(settings.smethod_20((Control)(object)groupBox10), (Control)(object)radioButton18);
		settings.smethod_12((Control)(object)groupBox10, settings.smethod_11("Microsoft Sans Serif", 38.25f));
		settings.smethod_13((Control)(object)groupBox10, new Point(41, 32));
		settings.smethod_14((Control)(object)groupBox10, "groupBox10");
		settings.smethod_15((Control)(object)groupBox10, new Size(306, 199));
		settings.smethod_16((Control)(object)groupBox10, 28);
		settings.smethod_22(groupBox10, bool_0: false);
		settings.smethod_17((Control)(object)groupBox10, "Вемя игры");
		settings.smethod_23((Control)(object)radioButton17, bool_0: true);
		settings.smethod_12((Control)(object)radioButton17, settings.smethod_11("Microsoft Sans Serif", 28.25f));
		settings.smethod_13((Control)(object)radioButton17, new Point(20, 141));
		settings.smethod_14((Control)(object)radioButton17, "radioButton17");
		settings.smethod_15((Control)(object)radioButton17, new Size(275, 48));
		settings.smethod_16((Control)(object)radioButton17, 1);
		settings.smethod_24(radioButton17, bool_0: true);
		settings.smethod_17((Control)(object)radioButton17, "Со временем");
		settings.smethod_18((ButtonBase)(object)radioButton17, bool_0: true);
		settings.smethod_23((Control)(object)radioButton18, bool_0: true);
		settings.smethod_12((Control)(object)radioButton18, settings.smethod_11("Microsoft Sans Serif", 28.25f));
		settings.smethod_13((Control)(object)radioButton18, new Point(20, 75));
		settings.smethod_14((Control)(object)radioButton18, "radioButton18");
		settings.smethod_15((Control)(object)radioButton18, new Size(226, 48));
		settings.smethod_16((Control)(object)radioButton18, 0);
		settings.smethod_24(radioButton18, bool_0: true);
		settings.smethod_17((Control)(object)radioButton18, "Бессрочно");
		settings.smethod_18((ButtonBase)(object)radioButton18, bool_0: true);
		settings.smethod_12((Control)(object)button9, settings.smethod_11("Microsoft Sans Serif", 38.25f));
		settings.smethod_13((Control)(object)button9, new Point(61, 318));
		settings.smethod_14((Control)(object)button9, "button9");
		settings.smethod_15((Control)(object)button9, new Size(249, 62));
		settings.smethod_16((Control)(object)button9, 27);
		settings.smethod_17((Control)(object)button9, "назад");
		settings.smethod_18((ButtonBase)(object)button9, bool_0: true);
		settings.smethod_12((Control)(object)textBox11, settings.smethod_11("Microsoft Sans Serif", 18.25f));
		settings.smethod_13((Control)(object)textBox11, new Point(40, 269));
		settings.smethod_14((Control)(object)textBox11, "textBox11");
		settings.smethod_15((Control)(object)textBox11, new Size(315, 35));
		settings.smethod_16((Control)(object)textBox11, 32);
		settings.smethod_17((Control)(object)textBox11, "Введите_время_в_минутах");
		settings.smethod_2((Control)(object)textBox11, bool_0: false);
		settings.smethod_21(settings.smethod_20((Control)(object)groupBox11), (Control)(object)radioButton19);
		settings.smethod_21(settings.smethod_20((Control)(object)groupBox11), (Control)(object)radioButton20);
		settings.smethod_12((Control)(object)groupBox11, settings.smethod_11("Microsoft Sans Serif", 38.25f));
		settings.smethod_13((Control)(object)groupBox11, new Point(49, 40));
		settings.smethod_14((Control)(object)groupBox11, "groupBox11");
		settings.smethod_15((Control)(object)groupBox11, new Size(306, 199));
		settings.smethod_16((Control)(object)groupBox11, 31);
		settings.smethod_22(groupBox11, bool_0: false);
		settings.smethod_17((Control)(object)groupBox11, "Вемя игры");
		settings.smethod_23((Control)(object)radioButton19, bool_0: true);
		settings.smethod_12((Control)(object)radioButton19, settings.smethod_11("Microsoft Sans Serif", 28.25f));
		settings.smethod_13((Control)(object)radioButton19, new Point(20, 141));
		settings.smethod_14((Control)(object)radioButton19, "radioButton19");
		settings.smethod_15((Control)(object)radioButton19, new Size(275, 48));
		settings.smethod_16((Control)(object)radioButton19, 1);
		settings.smethod_24(radioButton19, bool_0: true);
		settings.smethod_17((Control)(object)radioButton19, "Со временем");
		settings.smethod_18((ButtonBase)(object)radioButton19, bool_0: true);
		settings.smethod_23((Control)(object)radioButton20, bool_0: true);
		settings.smethod_12((Control)(object)radioButton20, settings.smethod_11("Microsoft Sans Serif", 28.25f));
		settings.smethod_13((Control)(object)radioButton20, new Point(20, 75));
		settings.smethod_14((Control)(object)radioButton20, "radioButton20");
		settings.smethod_15((Control)(object)radioButton20, new Size(226, 48));
		settings.smethod_16((Control)(object)radioButton20, 0);
		settings.smethod_24(radioButton20, bool_0: true);
		settings.smethod_17((Control)(object)radioButton20, "Бессрочно");
		settings.smethod_18((ButtonBase)(object)radioButton20, bool_0: true);
		settings.smethod_12((Control)(object)button10, settings.smethod_11("Microsoft Sans Serif", 38.25f));
		settings.smethod_13((Control)(object)button10, new Point(69, 326));
		settings.smethod_14((Control)(object)button10, "button10");
		settings.smethod_15((Control)(object)button10, new Size(249, 62));
		settings.smethod_16((Control)(object)button10, 30);
		settings.smethod_17((Control)(object)button10, "назад");
		settings.smethod_18((ButtonBase)(object)button10, bool_0: true);
		settings.smethod_12((Control)(object)textBox12, settings.smethod_11("Microsoft Sans Serif", 18.25f));
		settings.smethod_13((Control)(object)textBox12, new Point(48, 277));
		settings.smethod_14((Control)(object)textBox12, "textBox12");
		settings.smethod_15((Control)(object)textBox12, new Size(315, 35));
		settings.smethod_16((Control)(object)textBox12, 35);
		settings.smethod_17((Control)(object)textBox12, "Введите_время_в_минутах");
		settings.smethod_2((Control)(object)textBox12, bool_0: false);
		settings.smethod_21(settings.smethod_20((Control)(object)groupBox12), (Control)(object)radioButton21);
		settings.smethod_21(settings.smethod_20((Control)(object)groupBox12), (Control)(object)radioButton22);
		settings.smethod_12((Control)(object)groupBox12, settings.smethod_11("Microsoft Sans Serif", 38.25f));
		settings.smethod_13((Control)(object)groupBox12, new Point(57, 48));
		settings.smethod_14((Control)(object)groupBox12, "groupBox12");
		settings.smethod_15((Control)(object)groupBox12, new Size(306, 199));
		settings.smethod_16((Control)(object)groupBox12, 34);
		settings.smethod_22(groupBox12, bool_0: false);
		settings.smethod_17((Control)(object)groupBox12, "Вемя игры");
		settings.smethod_23((Control)(object)radioButton21, bool_0: true);
		settings.smethod_12((Control)(object)radioButton21, settings.smethod_11("Microsoft Sans Serif", 28.25f));
		settings.smethod_13((Control)(object)radioButton21, new Point(20, 141));
		settings.smethod_14((Control)(object)radioButton21, "radioButton21");
		settings.smethod_15((Control)(object)radioButton21, new Size(275, 48));
		settings.smethod_16((Control)(object)radioButton21, 1);
		settings.smethod_24(radioButton21, bool_0: true);
		settings.smethod_17((Control)(object)radioButton21, "Со временем");
		settings.smethod_18((ButtonBase)(object)radioButton21, bool_0: true);
		settings.smethod_23((Control)(object)radioButton22, bool_0: true);
		settings.smethod_12((Control)(object)radioButton22, settings.smethod_11("Microsoft Sans Serif", 28.25f));
		settings.smethod_13((Control)(object)radioButton22, new Point(20, 75));
		settings.smethod_14((Control)(object)radioButton22, "radioButton22");
		settings.smethod_15((Control)(object)radioButton22, new Size(226, 48));
		settings.smethod_16((Control)(object)radioButton22, 0);
		settings.smethod_24(radioButton22, bool_0: true);
		settings.smethod_17((Control)(object)radioButton22, "Бессрочно");
		settings.smethod_18((ButtonBase)(object)radioButton22, bool_0: true);
		settings.smethod_12((Control)(object)button11, settings.smethod_11("Microsoft Sans Serif", 38.25f));
		settings.smethod_13((Control)(object)button11, new Point(77, 334));
		settings.smethod_14((Control)(object)button11, "button11");
		settings.smethod_15((Control)(object)button11, new Size(249, 62));
		settings.smethod_16((Control)(object)button11, 33);
		settings.smethod_17((Control)(object)button11, "назад");
		settings.smethod_18((ButtonBase)(object)button11, bool_0: true);
		settings.smethod_12((Control)(object)textBox13, settings.smethod_11("Microsoft Sans Serif", 18.25f));
		settings.smethod_13((Control)(object)textBox13, new Point(56, 285));
		settings.smethod_14((Control)(object)textBox13, "textBox13");
		settings.smethod_15((Control)(object)textBox13, new Size(315, 35));
		settings.smethod_16((Control)(object)textBox13, 38);
		settings.smethod_17((Control)(object)textBox13, "Введите_время_в_минутах");
		settings.smethod_2((Control)(object)textBox13, bool_0: false);
		settings.smethod_21(settings.smethod_20((Control)(object)groupBox13), (Control)(object)radioButton23);
		settings.smethod_21(settings.smethod_20((Control)(object)groupBox13), (Control)(object)radioButton24);
		settings.smethod_12((Control)(object)groupBox13, settings.smethod_11("Microsoft Sans Serif", 38.25f));
		settings.smethod_13((Control)(object)groupBox13, new Point(65, 56));
		settings.smethod_14((Control)(object)groupBox13, "groupBox13");
		settings.smethod_15((Control)(object)groupBox13, new Size(306, 199));
		settings.smethod_16((Control)(object)groupBox13, 37);
		settings.smethod_22(groupBox13, bool_0: false);
		settings.smethod_17((Control)(object)groupBox13, "Вемя игры");
		settings.smethod_23((Control)(object)radioButton23, bool_0: true);
		settings.smethod_12((Control)(object)radioButton23, settings.smethod_11("Microsoft Sans Serif", 28.25f));
		settings.smethod_13((Control)(object)radioButton23, new Point(20, 141));
		settings.smethod_14((Control)(object)radioButton23, "radioButton23");
		settings.smethod_15((Control)(object)radioButton23, new Size(275, 48));
		settings.smethod_16((Control)(object)radioButton23, 1);
		settings.smethod_24(radioButton23, bool_0: true);
		settings.smethod_17((Control)(object)radioButton23, "Со временем");
		settings.smethod_18((ButtonBase)(object)radioButton23, bool_0: true);
		settings.smethod_23((Control)(object)radioButton24, bool_0: true);
		settings.smethod_12((Control)(object)radioButton24, settings.smethod_11("Microsoft Sans Serif", 28.25f));
		settings.smethod_13((Control)(object)radioButton24, new Point(20, 75));
		settings.smethod_14((Control)(object)radioButton24, "radioButton24");
		settings.smethod_15((Control)(object)radioButton24, new Size(226, 48));
		settings.smethod_16((Control)(object)radioButton24, 0);
		settings.smethod_24(radioButton24, bool_0: true);
		settings.smethod_17((Control)(object)radioButton24, "Бессрочно");
		settings.smethod_18((ButtonBase)(object)radioButton24, bool_0: true);
		settings.smethod_12((Control)(object)button12, settings.smethod_11("Microsoft Sans Serif", 38.25f));
		settings.smethod_13((Control)(object)button12, new Point(85, 342));
		settings.smethod_14((Control)(object)button12, "button12");
		settings.smethod_15((Control)(object)button12, new Size(249, 62));
		settings.smethod_16((Control)(object)button12, 36);
		settings.smethod_17((Control)(object)button12, "назад");
		settings.smethod_18((ButtonBase)(object)button12, bool_0: true);
		settings.smethod_12((Control)(object)textBox14, settings.smethod_11("Microsoft Sans Serif", 18.25f));
		settings.smethod_13((Control)(object)textBox14, new Point(0, 229));
		settings.smethod_14((Control)(object)textBox14, "textBox14");
		settings.smethod_15((Control)(object)textBox14, new Size(315, 35));
		settings.smethod_16((Control)(object)textBox14, 41);
		settings.smethod_17((Control)(object)textBox14, "Введите_время_в_минутах");
		settings.smethod_2((Control)(object)textBox14, bool_0: false);
		settings.smethod_21(settings.smethod_20((Control)(object)groupBox14), (Control)(object)radioButton25);
		settings.smethod_21(settings.smethod_20((Control)(object)groupBox14), (Control)(object)radioButton26);
		settings.smethod_12((Control)(object)groupBox14, settings.smethod_11("Microsoft Sans Serif", 38.25f));
		settings.smethod_13((Control)(object)groupBox14, new Point(9, 0));
		settings.smethod_14((Control)(object)groupBox14, "groupBox14");
		settings.smethod_15((Control)(object)groupBox14, new Size(306, 199));
		settings.smethod_16((Control)(object)groupBox14, 40);
		settings.smethod_22(groupBox14, bool_0: false);
		settings.smethod_17((Control)(object)groupBox14, "Вемя игры");
		settings.smethod_23((Control)(object)radioButton25, bool_0: true);
		settings.smethod_12((Control)(object)radioButton25, settings.smethod_11("Microsoft Sans Serif", 28.25f));
		settings.smethod_13((Control)(object)radioButton25, new Point(20, 141));
		settings.smethod_14((Control)(object)radioButton25, "radioButton25");
		settings.smethod_15((Control)(object)radioButton25, new Size(275, 48));
		settings.smethod_16((Control)(object)radioButton25, 1);
		settings.smethod_24(radioButton25, bool_0: true);
		settings.smethod_17((Control)(object)radioButton25, "Со временем");
		settings.smethod_18((ButtonBase)(object)radioButton25, bool_0: true);
		settings.smethod_23((Control)(object)radioButton26, bool_0: true);
		settings.smethod_12((Control)(object)radioButton26, settings.smethod_11("Microsoft Sans Serif", 28.25f));
		settings.smethod_13((Control)(object)radioButton26, new Point(20, 75));
		settings.smethod_14((Control)(object)radioButton26, "radioButton26");
		settings.smethod_15((Control)(object)radioButton26, new Size(226, 48));
		settings.smethod_16((Control)(object)radioButton26, 0);
		settings.smethod_24(radioButton26, bool_0: true);
		settings.smethod_17((Control)(object)radioButton26, "Бессрочно");
		settings.smethod_18((ButtonBase)(object)radioButton26, bool_0: true);
		settings.smethod_12((Control)(object)button13, settings.smethod_11("Microsoft Sans Serif", 38.25f));
		settings.smethod_13((Control)(object)button13, new Point(29, 286));
		settings.smethod_14((Control)(object)button13, "button13");
		settings.smethod_15((Control)(object)button13, new Size(249, 62));
		settings.smethod_16((Control)(object)button13, 39);
		settings.smethod_17((Control)(object)button13, "назад");
		settings.smethod_18((ButtonBase)(object)button13, bool_0: true);
		settings.smethod_12((Control)(object)textBox15, settings.smethod_11("Microsoft Sans Serif", 18.25f));
		settings.smethod_13((Control)(object)textBox15, new Point(0, 229));
		settings.smethod_14((Control)(object)textBox15, "textBox15");
		settings.smethod_15((Control)(object)textBox15, new Size(315, 35));
		settings.smethod_16((Control)(object)textBox15, 44);
		settings.smethod_17((Control)(object)textBox15, "Введите_время_в_минутах");
		settings.smethod_2((Control)(object)textBox15, bool_0: false);
		settings.smethod_21(settings.smethod_20((Control)(object)groupBox15), (Control)(object)radioButton27);
		settings.smethod_21(settings.smethod_20((Control)(object)groupBox15), (Control)(object)radioButton28);
		settings.smethod_12((Control)(object)groupBox15, settings.smethod_11("Microsoft Sans Serif", 38.25f));
		settings.smethod_13((Control)(object)groupBox15, new Point(9, 0));
		settings.smethod_14((Control)(object)groupBox15, "groupBox15");
		settings.smethod_15((Control)(object)groupBox15, new Size(306, 199));
		settings.smethod_16((Control)(object)groupBox15, 43);
		settings.smethod_22(groupBox15, bool_0: false);
		settings.smethod_17((Control)(object)groupBox15, "Вемя игры");
		settings.smethod_23((Control)(object)radioButton27, bool_0: true);
		settings.smethod_12((Control)(object)radioButton27, settings.smethod_11("Microsoft Sans Serif", 28.25f));
		settings.smethod_13((Control)(object)radioButton27, new Point(20, 141));
		settings.smethod_14((Control)(object)radioButton27, "radioButton27");
		settings.smethod_15((Control)(object)radioButton27, new Size(275, 48));
		settings.smethod_16((Control)(object)radioButton27, 1);
		settings.smethod_24(radioButton27, bool_0: true);
		settings.smethod_17((Control)(object)radioButton27, "Со временем");
		settings.smethod_18((ButtonBase)(object)radioButton27, bool_0: true);
		settings.smethod_23((Control)(object)radioButton28, bool_0: true);
		settings.smethod_12((Control)(object)radioButton28, settings.smethod_11("Microsoft Sans Serif", 28.25f));
		settings.smethod_13((Control)(object)radioButton28, new Point(20, 75));
		settings.smethod_14((Control)(object)radioButton28, "radioButton28");
		settings.smethod_15((Control)(object)radioButton28, new Size(226, 48));
		settings.smethod_16((Control)(object)radioButton28, 0);
		settings.smethod_24(radioButton28, bool_0: true);
		settings.smethod_17((Control)(object)radioButton28, "Бессрочно");
		settings.smethod_18((ButtonBase)(object)radioButton28, bool_0: true);
		settings.smethod_12((Control)(object)button14, settings.smethod_11("Microsoft Sans Serif", 38.25f));
		settings.smethod_13((Control)(object)button14, new Point(29, 286));
		settings.smethod_14((Control)(object)button14, "button14");
		settings.smethod_15((Control)(object)button14, new Size(249, 62));
		settings.smethod_16((Control)(object)button14, 42);
		settings.smethod_17((Control)(object)button14, "назад");
		settings.smethod_18((ButtonBase)(object)button14, bool_0: true);
		settings.smethod_12((Control)(object)textBox16, settings.smethod_11("Microsoft Sans Serif", 18.25f));
		settings.smethod_13((Control)(object)textBox16, new Point(0, 229));
		settings.smethod_14((Control)(object)textBox16, "textBox16");
		settings.smethod_15((Control)(object)textBox16, new Size(315, 35));
		settings.smethod_16((Control)(object)textBox16, 47);
		settings.smethod_17((Control)(object)textBox16, "Введите_время_в_минутах");
		settings.smethod_2((Control)(object)textBox16, bool_0: false);
		settings.smethod_21(settings.smethod_20((Control)(object)groupBox16), (Control)(object)radioButton29);
		settings.smethod_21(settings.smethod_20((Control)(object)groupBox16), (Control)(object)radioButton30);
		settings.smethod_12((Control)(object)groupBox16, settings.smethod_11("Microsoft Sans Serif", 38.25f));
		settings.smethod_13((Control)(object)groupBox16, new Point(9, 0));
		settings.smethod_14((Control)(object)groupBox16, "groupBox16");
		settings.smethod_15((Control)(object)groupBox16, new Size(306, 199));
		settings.smethod_16((Control)(object)groupBox16, 46);
		settings.smethod_22(groupBox16, bool_0: false);
		settings.smethod_17((Control)(object)groupBox16, "Вемя игры");
		settings.smethod_23((Control)(object)radioButton29, bool_0: true);
		settings.smethod_12((Control)(object)radioButton29, settings.smethod_11("Microsoft Sans Serif", 28.25f));
		settings.smethod_13((Control)(object)radioButton29, new Point(20, 141));
		settings.smethod_14((Control)(object)radioButton29, "radioButton29");
		settings.smethod_15((Control)(object)radioButton29, new Size(275, 48));
		settings.smethod_16((Control)(object)radioButton29, 1);
		settings.smethod_24(radioButton29, bool_0: true);
		settings.smethod_17((Control)(object)radioButton29, "Со временем");
		settings.smethod_18((ButtonBase)(object)radioButton29, bool_0: true);
		settings.smethod_23((Control)(object)radioButton30, bool_0: true);
		settings.smethod_12((Control)(object)radioButton30, settings.smethod_11("Microsoft Sans Serif", 28.25f));
		settings.smethod_13((Control)(object)radioButton30, new Point(20, 75));
		settings.smethod_14((Control)(object)radioButton30, "radioButton30");
		settings.smethod_15((Control)(object)radioButton30, new Size(226, 48));
		settings.smethod_16((Control)(object)radioButton30, 0);
		settings.smethod_24(radioButton30, bool_0: true);
		settings.smethod_17((Control)(object)radioButton30, "Бессрочно");
		settings.smethod_18((ButtonBase)(object)radioButton30, bool_0: true);
		settings.smethod_12((Control)(object)button15, settings.smethod_11("Microsoft Sans Serif", 38.25f));
		settings.smethod_13((Control)(object)button15, new Point(29, 286));
		settings.smethod_14((Control)(object)button15, "button15");
		settings.smethod_15((Control)(object)button15, new Size(249, 62));
		settings.smethod_16((Control)(object)button15, 45);
		settings.smethod_17((Control)(object)button15, "назад");
		settings.smethod_18((ButtonBase)(object)button15, bool_0: true);
		settings.smethod_12((Control)(object)textBox17, settings.smethod_11("Microsoft Sans Serif", 18.25f));
		settings.smethod_13((Control)(object)textBox17, new Point(0, 229));
		settings.smethod_14((Control)(object)textBox17, "textBox17");
		settings.smethod_15((Control)(object)textBox17, new Size(315, 35));
		settings.smethod_16((Control)(object)textBox17, 50);
		settings.smethod_17((Control)(object)textBox17, "Введите_время_в_минутах");
		settings.smethod_2((Control)(object)textBox17, bool_0: false);
		settings.smethod_21(settings.smethod_20((Control)(object)groupBox17), (Control)(object)radioButton31);
		settings.smethod_21(settings.smethod_20((Control)(object)groupBox17), (Control)(object)radioButton32);
		settings.smethod_12((Control)(object)groupBox17, settings.smethod_11("Microsoft Sans Serif", 38.25f));
		settings.smethod_13((Control)(object)groupBox17, new Point(9, 0));
		settings.smethod_14((Control)(object)groupBox17, "groupBox17");
		settings.smethod_15((Control)(object)groupBox17, new Size(306, 199));
		settings.smethod_16((Control)(object)groupBox17, 49);
		settings.smethod_22(groupBox17, bool_0: false);
		settings.smethod_17((Control)(object)groupBox17, "Вемя игры");
		settings.smethod_23((Control)(object)radioButton31, bool_0: true);
		settings.smethod_12((Control)(object)radioButton31, settings.smethod_11("Microsoft Sans Serif", 28.25f));
		settings.smethod_13((Control)(object)radioButton31, new Point(20, 141));
		settings.smethod_14((Control)(object)radioButton31, "radioButton31");
		settings.smethod_15((Control)(object)radioButton31, new Size(275, 48));
		settings.smethod_16((Control)(object)radioButton31, 1);
		settings.smethod_24(radioButton31, bool_0: true);
		settings.smethod_17((Control)(object)radioButton31, "Со временем");
		settings.smethod_18((ButtonBase)(object)radioButton31, bool_0: true);
		settings.smethod_23((Control)(object)radioButton32, bool_0: true);
		settings.smethod_12((Control)(object)radioButton32, settings.smethod_11("Microsoft Sans Serif", 28.25f));
		settings.smethod_13((Control)(object)radioButton32, new Point(20, 75));
		settings.smethod_14((Control)(object)radioButton32, "radioButton32");
		settings.smethod_15((Control)(object)radioButton32, new Size(226, 48));
		settings.smethod_16((Control)(object)radioButton32, 0);
		settings.smethod_24(radioButton32, bool_0: true);
		settings.smethod_17((Control)(object)radioButton32, "Бессрочно");
		settings.smethod_18((ButtonBase)(object)radioButton32, bool_0: true);
		settings.smethod_12((Control)(object)button16, settings.smethod_11("Microsoft Sans Serif", 38.25f));
		settings.smethod_13((Control)(object)button16, new Point(29, 286));
		settings.smethod_14((Control)(object)button16, "button16");
		settings.smethod_15((Control)(object)button16, new Size(249, 62));
		settings.smethod_16((Control)(object)button16, 48);
		settings.smethod_17((Control)(object)button16, "назад");
		settings.smethod_18((ButtonBase)(object)button16, bool_0: true);
		settings.smethod_12((Control)(object)textBox18, settings.smethod_11("Microsoft Sans Serif", 18.25f));
		settings.smethod_13((Control)(object)textBox18, new Point(0, 229));
		settings.smethod_14((Control)(object)textBox18, "textBox18");
		settings.smethod_15((Control)(object)textBox18, new Size(315, 35));
		settings.smethod_16((Control)(object)textBox18, 53);
		settings.smethod_17((Control)(object)textBox18, "Введите_время_в_минутах");
		settings.smethod_2((Control)(object)textBox18, bool_0: false);
		settings.smethod_21(settings.smethod_20((Control)(object)groupBox18), (Control)(object)radioButton33);
		settings.smethod_21(settings.smethod_20((Control)(object)groupBox18), (Control)(object)radioButton34);
		settings.smethod_12((Control)(object)groupBox18, settings.smethod_11("Microsoft Sans Serif", 38.25f));
		settings.smethod_13((Control)(object)groupBox18, new Point(9, 0));
		settings.smethod_14((Control)(object)groupBox18, "groupBox18");
		settings.smethod_15((Control)(object)groupBox18, new Size(306, 199));
		settings.smethod_16((Control)(object)groupBox18, 52);
		settings.smethod_22(groupBox18, bool_0: false);
		settings.smethod_17((Control)(object)groupBox18, "Вемя игры");
		settings.smethod_23((Control)(object)radioButton33, bool_0: true);
		settings.smethod_12((Control)(object)radioButton33, settings.smethod_11("Microsoft Sans Serif", 28.25f));
		settings.smethod_13((Control)(object)radioButton33, new Point(20, 141));
		settings.smethod_14((Control)(object)radioButton33, "radioButton33");
		settings.smethod_15((Control)(object)radioButton33, new Size(275, 48));
		settings.smethod_16((Control)(object)radioButton33, 1);
		settings.smethod_24(radioButton33, bool_0: true);
		settings.smethod_17((Control)(object)radioButton33, "Со временем");
		settings.smethod_18((ButtonBase)(object)radioButton33, bool_0: true);
		settings.smethod_23((Control)(object)radioButton34, bool_0: true);
		settings.smethod_12((Control)(object)radioButton34, settings.smethod_11("Microsoft Sans Serif", 28.25f));
		settings.smethod_13((Control)(object)radioButton34, new Point(20, 75));
		settings.smethod_14((Control)(object)radioButton34, "radioButton34");
		settings.smethod_15((Control)(object)radioButton34, new Size(226, 48));
		settings.smethod_16((Control)(object)radioButton34, 0);
		settings.smethod_24(radioButton34, bool_0: true);
		settings.smethod_17((Control)(object)radioButton34, "Бессрочно");
		settings.smethod_18((ButtonBase)(object)radioButton34, bool_0: true);
		settings.smethod_12((Control)(object)button17, settings.smethod_11("Microsoft Sans Serif", 38.25f));
		settings.smethod_13((Control)(object)button17, new Point(29, 286));
		settings.smethod_14((Control)(object)button17, "button17");
		settings.smethod_15((Control)(object)button17, new Size(249, 62));
		settings.smethod_16((Control)(object)button17, 51);
		settings.smethod_17((Control)(object)button17, "назад");
		settings.smethod_18((ButtonBase)(object)button17, bool_0: true);
		settings.smethod_12((Control)(object)textBox19, settings.smethod_11("Microsoft Sans Serif", 18.25f));
		settings.smethod_13((Control)(object)textBox19, new Point(0, 229));
		settings.smethod_14((Control)(object)textBox19, "textBox19");
		settings.smethod_15((Control)(object)textBox19, new Size(315, 35));
		settings.smethod_16((Control)(object)textBox19, 56);
		settings.smethod_17((Control)(object)textBox19, "Введите_время_в_минутах");
		settings.smethod_2((Control)(object)textBox19, bool_0: false);
		settings.smethod_21(settings.smethod_20((Control)(object)groupBox19), (Control)(object)radioButton35);
		settings.smethod_21(settings.smethod_20((Control)(object)groupBox19), (Control)(object)radioButton36);
		settings.smethod_12((Control)(object)groupBox19, settings.smethod_11("Microsoft Sans Serif", 38.25f));
		settings.smethod_13((Control)(object)groupBox19, new Point(9, 0));
		settings.smethod_14((Control)(object)groupBox19, "groupBox19");
		settings.smethod_15((Control)(object)groupBox19, new Size(306, 199));
		settings.smethod_16((Control)(object)groupBox19, 55);
		settings.smethod_22(groupBox19, bool_0: false);
		settings.smethod_17((Control)(object)groupBox19, "Вемя игры");
		settings.smethod_23((Control)(object)radioButton35, bool_0: true);
		settings.smethod_12((Control)(object)radioButton35, settings.smethod_11("Microsoft Sans Serif", 28.25f));
		settings.smethod_13((Control)(object)radioButton35, new Point(20, 141));
		settings.smethod_14((Control)(object)radioButton35, "radioButton35");
		settings.smethod_15((Control)(object)radioButton35, new Size(275, 48));
		settings.smethod_16((Control)(object)radioButton35, 1);
		settings.smethod_24(radioButton35, bool_0: true);
		settings.smethod_17((Control)(object)radioButton35, "Со временем");
		settings.smethod_18((ButtonBase)(object)radioButton35, bool_0: true);
		settings.smethod_23((Control)(object)radioButton36, bool_0: true);
		settings.smethod_12((Control)(object)radioButton36, settings.smethod_11("Microsoft Sans Serif", 28.25f));
		settings.smethod_13((Control)(object)radioButton36, new Point(20, 75));
		settings.smethod_14((Control)(object)radioButton36, "radioButton36");
		settings.smethod_15((Control)(object)radioButton36, new Size(226, 48));
		settings.smethod_16((Control)(object)radioButton36, 0);
		settings.smethod_24(radioButton36, bool_0: true);
		settings.smethod_17((Control)(object)radioButton36, "Бессрочно");
		settings.smethod_18((ButtonBase)(object)radioButton36, bool_0: true);
		settings.smethod_12((Control)(object)button18, settings.smethod_11("Microsoft Sans Serif", 38.25f));
		settings.smethod_13((Control)(object)button18, new Point(29, 286));
		settings.smethod_14((Control)(object)button18, "button18");
		settings.smethod_15((Control)(object)button18, new Size(249, 62));
		settings.smethod_16((Control)(object)button18, 54);
		settings.smethod_17((Control)(object)button18, "назад");
		settings.smethod_18((ButtonBase)(object)button18, bool_0: true);
		settings.smethod_12((Control)(object)textBox20, settings.smethod_11("Microsoft Sans Serif", 18.25f));
		settings.smethod_13((Control)(object)textBox20, new Point(0, 229));
		settings.smethod_14((Control)(object)textBox20, "textBox20");
		settings.smethod_15((Control)(object)textBox20, new Size(315, 35));
		settings.smethod_16((Control)(object)textBox20, 59);
		settings.smethod_17((Control)(object)textBox20, "Введите_время_в_минутах");
		settings.smethod_2((Control)(object)textBox20, bool_0: false);
		settings.smethod_21(settings.smethod_20((Control)(object)groupBox20), (Control)(object)radioButton37);
		settings.smethod_21(settings.smethod_20((Control)(object)groupBox20), (Control)(object)radioButton38);
		settings.smethod_12((Control)(object)groupBox20, settings.smethod_11("Microsoft Sans Serif", 38.25f));
		settings.smethod_13((Control)(object)groupBox20, new Point(9, 0));
		settings.smethod_14((Control)(object)groupBox20, "groupBox20");
		settings.smethod_15((Control)(object)groupBox20, new Size(306, 199));
		settings.smethod_16((Control)(object)groupBox20, 58);
		settings.smethod_22(groupBox20, bool_0: false);
		settings.smethod_17((Control)(object)groupBox20, "Вемя игры");
		settings.smethod_23((Control)(object)radioButton37, bool_0: true);
		settings.smethod_12((Control)(object)radioButton37, settings.smethod_11("Microsoft Sans Serif", 28.25f));
		settings.smethod_13((Control)(object)radioButton37, new Point(20, 141));
		settings.smethod_14((Control)(object)radioButton37, "radioButton37");
		settings.smethod_15((Control)(object)radioButton37, new Size(275, 48));
		settings.smethod_16((Control)(object)radioButton37, 1);
		settings.smethod_24(radioButton37, bool_0: true);
		settings.smethod_17((Control)(object)radioButton37, "Со временем");
		settings.smethod_18((ButtonBase)(object)radioButton37, bool_0: true);
		settings.smethod_23((Control)(object)radioButton38, bool_0: true);
		settings.smethod_12((Control)(object)radioButton38, settings.smethod_11("Microsoft Sans Serif", 28.25f));
		settings.smethod_13((Control)(object)radioButton38, new Point(20, 75));
		settings.smethod_14((Control)(object)radioButton38, "radioButton38");
		settings.smethod_15((Control)(object)radioButton38, new Size(226, 48));
		settings.smethod_16((Control)(object)radioButton38, 0);
		settings.smethod_24(radioButton38, bool_0: true);
		settings.smethod_17((Control)(object)radioButton38, "Бессрочно");
		settings.smethod_18((ButtonBase)(object)radioButton38, bool_0: true);
		settings.smethod_12((Control)(object)button19, settings.smethod_11("Microsoft Sans Serif", 38.25f));
		settings.smethod_13((Control)(object)button19, new Point(29, 286));
		settings.smethod_14((Control)(object)button19, "button19");
		settings.smethod_15((Control)(object)button19, new Size(249, 62));
		settings.smethod_16((Control)(object)button19, 57);
		settings.smethod_17((Control)(object)button19, "назад");
		settings.smethod_18((ButtonBase)(object)button19, bool_0: true);
		settings.smethod_12((Control)(object)textBox21, settings.smethod_11("Microsoft Sans Serif", 18.25f));
		settings.smethod_13((Control)(object)textBox21, new Point(0, 229));
		settings.smethod_14((Control)(object)textBox21, "textBox21");
		settings.smethod_15((Control)(object)textBox21, new Size(315, 35));
		settings.smethod_16((Control)(object)textBox21, 62);
		settings.smethod_17((Control)(object)textBox21, "Введите_время_в_минутах");
		settings.smethod_2((Control)(object)textBox21, bool_0: false);
		settings.smethod_21(settings.smethod_20((Control)(object)groupBox21), (Control)(object)radioButton39);
		settings.smethod_21(settings.smethod_20((Control)(object)groupBox21), (Control)(object)radioButton40);
		settings.smethod_12((Control)(object)groupBox21, settings.smethod_11("Microsoft Sans Serif", 38.25f));
		settings.smethod_13((Control)(object)groupBox21, new Point(9, 0));
		settings.smethod_14((Control)(object)groupBox21, "groupBox21");
		settings.smethod_15((Control)(object)groupBox21, new Size(306, 199));
		settings.smethod_16((Control)(object)groupBox21, 61);
		settings.smethod_22(groupBox21, bool_0: false);
		settings.smethod_17((Control)(object)groupBox21, "Вемя игры");
		settings.smethod_23((Control)(object)radioButton39, bool_0: true);
		settings.smethod_12((Control)(object)radioButton39, settings.smethod_11("Microsoft Sans Serif", 28.25f));
		settings.smethod_13((Control)(object)radioButton39, new Point(20, 141));
		settings.smethod_14((Control)(object)radioButton39, "radioButton39");
		settings.smethod_15((Control)(object)radioButton39, new Size(275, 48));
		settings.smethod_16((Control)(object)radioButton39, 1);
		settings.smethod_24(radioButton39, bool_0: true);
		settings.smethod_17((Control)(object)radioButton39, "Со временем");
		settings.smethod_18((ButtonBase)(object)radioButton39, bool_0: true);
		settings.smethod_23((Control)(object)radioButton40, bool_0: true);
		settings.smethod_12((Control)(object)radioButton40, settings.smethod_11("Microsoft Sans Serif", 28.25f));
		settings.smethod_13((Control)(object)radioButton40, new Point(20, 75));
		settings.smethod_14((Control)(object)radioButton40, "radioButton40");
		settings.smethod_15((Control)(object)radioButton40, new Size(226, 48));
		settings.smethod_16((Control)(object)radioButton40, 0);
		settings.smethod_24(radioButton40, bool_0: true);
		settings.smethod_17((Control)(object)radioButton40, "Бессрочно");
		settings.smethod_18((ButtonBase)(object)radioButton40, bool_0: true);
		settings.smethod_12((Control)(object)button20, settings.smethod_11("Microsoft Sans Serif", 38.25f));
		settings.smethod_13((Control)(object)button20, new Point(29, 286));
		settings.smethod_14((Control)(object)button20, "button20");
		settings.smethod_15((Control)(object)button20, new Size(249, 62));
		settings.smethod_16((Control)(object)button20, 60);
		settings.smethod_17((Control)(object)button20, "назад");
		settings.smethod_18((ButtonBase)(object)button20, bool_0: true);
		settings.smethod_27((ContainerControl)(object)this, new SizeF(6f, 13f));
		settings.smethod_28((ContainerControl)(object)this, (AutoScaleMode)1);
		settings.smethod_29((Control)(object)this, (ImageLayout)4);
		settings.smethod_30((Form)(object)this, new Size(602, 404));
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)textBox21);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)groupBox21);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)button20);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)textBox20);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)groupBox20);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)button19);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)textBox19);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)groupBox19);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)button18);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)textBox18);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)groupBox18);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)button17);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)textBox17);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)groupBox17);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)button16);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)textBox16);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)groupBox16);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)button15);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)textBox15);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)groupBox15);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)button14);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)textBox14);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)groupBox14);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)button13);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)textBox13);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)groupBox13);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)button12);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)textBox12);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)groupBox12);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)button11);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)textBox11);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)groupBox11);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)button10);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)textBox10);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)groupBox10);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)button9);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)textBox9);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)groupBox9);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)button8);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)textBox8);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)groupBox8);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)button7);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)textBox7);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)groupBox7);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)button6);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)textBox6);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)groupBox6);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)button5);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)textBox5);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)groupBox5);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)button4);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)textBox4);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)groupBox4);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)button3);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)textBox3);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)groupBox3);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)button2);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)textBox2);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)groupBox2);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)button1);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)textBox1);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)groupBox1);
		settings.smethod_21(settings.smethod_31((Control)(object)this), (Control)(object)back);
		settings.smethod_32((Control)(object)this, "settings");
		settings.smethod_33((Form)(object)this, (FormStartPosition)1);
		settings.smethod_17((Control)(object)this, "Settings");
		settings.smethod_34((Form)(object)this, (EventHandler)settings_Load);
		settings.smethod_35((Control)(object)groupBox1, bool_0: false);
		settings.smethod_36((Control)(object)groupBox1);
		settings.smethod_35((Control)(object)groupBox2, bool_0: false);
		settings.smethod_36((Control)(object)groupBox2);
		settings.smethod_35((Control)(object)groupBox3, bool_0: false);
		settings.smethod_36((Control)(object)groupBox3);
		settings.smethod_35((Control)(object)groupBox4, bool_0: false);
		settings.smethod_36((Control)(object)groupBox4);
		settings.smethod_35((Control)(object)groupBox5, bool_0: false);
		settings.smethod_36((Control)(object)groupBox5);
		settings.smethod_35((Control)(object)groupBox6, bool_0: false);
		settings.smethod_36((Control)(object)groupBox6);
		settings.smethod_35((Control)(object)groupBox7, bool_0: false);
		settings.smethod_36((Control)(object)groupBox7);
		settings.smethod_35((Control)(object)groupBox8, bool_0: false);
		settings.smethod_36((Control)(object)groupBox8);
		settings.smethod_35((Control)(object)groupBox9, bool_0: false);
		settings.smethod_36((Control)(object)groupBox9);
		settings.smethod_35((Control)(object)groupBox10, bool_0: false);
		settings.smethod_36((Control)(object)groupBox10);
		settings.smethod_35((Control)(object)groupBox11, bool_0: false);
		settings.smethod_36((Control)(object)groupBox11);
		settings.smethod_35((Control)(object)groupBox12, bool_0: false);
		settings.smethod_36((Control)(object)groupBox12);
		settings.smethod_35((Control)(object)groupBox13, bool_0: false);
		settings.smethod_36((Control)(object)groupBox13);
		settings.smethod_35((Control)(object)groupBox14, bool_0: false);
		settings.smethod_36((Control)(object)groupBox14);
		settings.smethod_35((Control)(object)groupBox15, bool_0: false);
		settings.smethod_36((Control)(object)groupBox15);
		settings.smethod_35((Control)(object)groupBox16, bool_0: false);
		settings.smethod_36((Control)(object)groupBox16);
		settings.smethod_35((Control)(object)groupBox17, bool_0: false);
		settings.smethod_36((Control)(object)groupBox17);
		settings.smethod_35((Control)(object)groupBox18, bool_0: false);
		settings.smethod_36((Control)(object)groupBox18);
		settings.smethod_35((Control)(object)groupBox19, bool_0: false);
		settings.smethod_36((Control)(object)groupBox19);
		settings.smethod_35((Control)(object)groupBox20, bool_0: false);
		settings.smethod_36((Control)(object)groupBox20);
		settings.smethod_35((Control)(object)groupBox21, bool_0: false);
		settings.smethod_36((Control)(object)groupBox21);
		settings.smethod_37((Control)(object)this, bool_0: false);
		settings.smethod_38((Control)(object)this);
	}

	static void smethod_0(Control control_0)
	{
		control_0.Show();
	}

	static void smethod_1(Control control_0, bool bool_0)
	{
		control_0.set_Visible(bool_0);
	}

	static void smethod_2(Control control_0, bool bool_0)
	{
		control_0.set_Visible(bool_0);
	}

	static string smethod_3(Control control_0)
	{
		return control_0.get_Text();
	}

	static void smethod_4(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Button smethod_5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Button();
	}

	static GroupBox smethod_6()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new GroupBox();
	}

	static RadioButton smethod_7()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new RadioButton();
	}

	static TextBox smethod_8()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new TextBox();
	}

	static void smethod_9(Control control_0)
	{
		control_0.SuspendLayout();
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

	static ControlCollection smethod_20(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_21(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_22(GroupBox groupBox_0, bool bool_0)
	{
		groupBox_0.set_TabStop(bool_0);
	}

	static void smethod_23(Control control_0, bool bool_0)
	{
		control_0.set_AutoSize(bool_0);
	}

	static void smethod_24(RadioButton radioButton_0, bool bool_0)
	{
		radioButton_0.set_TabStop(bool_0);
	}

	static void smethod_25(RadioButton radioButton_0, EventHandler eventHandler_0)
	{
		radioButton_0.add_CheckedChanged(eventHandler_0);
	}

	static void smethod_26(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_TextChanged(eventHandler_0);
	}

	static void smethod_27(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_28(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_29(Control control_0, ImageLayout imageLayout_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_BackgroundImageLayout(imageLayout_0);
	}

	static void smethod_30(Form form_0, Size size_0)
	{
		form_0.set_ClientSize(size_0);
	}

	static ControlCollection smethod_31(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_32(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_33(Form form_0, FormStartPosition formStartPosition_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_StartPosition(formStartPosition_0);
	}

	static void smethod_34(Form form_0, EventHandler eventHandler_0)
	{
		form_0.add_Load(eventHandler_0);
	}

	static void smethod_35(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_36(Control control_0)
	{
		control_0.PerformLayout();
	}

	static void smethod_37(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_38(Control control_0)
	{
		control_0.PerformLayout();
	}
}
