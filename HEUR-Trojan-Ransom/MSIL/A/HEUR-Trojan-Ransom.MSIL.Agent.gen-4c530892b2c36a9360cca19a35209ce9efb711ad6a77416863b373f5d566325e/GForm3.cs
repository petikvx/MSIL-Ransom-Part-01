using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

public class GForm3 : Form
{
	public class GClass0 : Panel
	{
		public GClass0()
		{
			((Control)this).SetStyle((ControlStyles)139266, true);
		}
	}

	private class Class2
	{
		public List<Class3> list_0;

		public Enum0 enum0_0;

		public Random random_0;

		private int int_0;

		private int int_1;

		private const int int_2 = 4;

		private const int int_3 = 10;

		private const int int_4 = 1;

		private const int int_5 = 20;

		private const int int_6 = 2;

		private const int int_7 = 1;

		public Class2()
		{
			list_0 = new List<Class3>();
			random_0 = Class2.smethod_0();
			int_0 = Class2.smethod_1(random_0, 4, 10) * 25;
			int_1 = Class2.smethod_1(random_0, 1, 20) * 25;
			list_0.Add(new Class3(int_0, int_1));
			list_0.Add(new Class3(int_0 - 25 * list_0.Count, int_1));
			list_0.Add(new Class3(int_0 - 25 * list_0.Count, int_1));
			list_0.Add(new Class3(int_0 - 25 * list_0.Count, int_1));
			list_0.Add(new Class3(int_0 - 25 * list_0.Count, int_1));
			enum0_0 = Enum0.Right;
		}

		public void method_0(Graphics graphics_0, Pen pen_0)
		{
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Expected O, but got Unknown
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Expected O, but got Unknown
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Expected O, but got Unknown
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Expected O, but got Unknown
			Bitmap image_ = null;
			switch (enum0_0)
			{
			case Enum0.Right:
				image_ = (Bitmap)Class2.smethod_2("вправо.jpg");
				break;
			case Enum0.Left:
				image_ = (Bitmap)Class2.smethod_2("влево.jpg");
				break;
			case Enum0.Up:
				image_ = (Bitmap)Class2.smethod_2("вверх.jpg");
				break;
			case Enum0.Down:
				image_ = (Bitmap)Class2.smethod_2("вниз.jpg");
				break;
			}
			TextureBrush brush_ = Class2.smethod_3((Image)(object)image_);
			Class2.smethod_4(graphics_0, pen_0, list_0[0].int_0, list_0[0].int_1, 25, 25);
			Class2.smethod_5(graphics_0, (Brush)(object)brush_, list_0[0].int_0 + 1, list_0[0].int_1 + 1, 23, 23);
			for (int i = 1; i < list_0.Count; i++)
			{
				Class2.smethod_4(graphics_0, pen_0, list_0[i].int_0, list_0[i].int_1, 25, 25);
				SolidBrush brush_2 = Class2.smethod_6(Color.FromArgb(0, 0, 0, 0));
				Class2.smethod_5(graphics_0, (Brush)(object)brush_2, list_0[i].int_0, list_0[i].int_1, 25, 25);
			}
		}

		public void method_1()
		{
			for (int num = list_0.Count - 1; num >= 0; num--)
			{
				if (num != 0)
				{
					list_0[num].int_0 = list_0[num - 1].int_0;
					list_0[num].int_1 = list_0[num - 1].int_1;
				}
				else
				{
					switch (enum0_0)
					{
					case Enum0.Right:
						list_0[num].int_0 += 25;
						break;
					case Enum0.Left:
						list_0[num].int_0 -= 25;
						break;
					case Enum0.Up:
						list_0[num].int_1 -= 25;
						break;
					case Enum0.Down:
						list_0[num].int_1 += 25;
						break;
					}
				}
			}
		}

		static Random smethod_0()
		{
			return new Random();
		}

		static int smethod_1(Random random_1, int int_8, int int_9)
		{
			return random_1.Next(int_8, int_9);
		}

		static Image smethod_2(string string_0)
		{
			return Image.FromFile(string_0);
		}

		static TextureBrush smethod_3(Image image_0)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Expected O, but got Unknown
			return new TextureBrush(image_0);
		}

		static void smethod_4(Graphics graphics_0, Pen pen_0, int int_8, int int_9, int int_10, int int_11)
		{
			graphics_0.DrawRectangle(pen_0, int_8, int_9, int_10, int_11);
		}

		static void smethod_5(Graphics graphics_0, Brush brush_0, int int_8, int int_9, int int_10, int int_11)
		{
			graphics_0.FillRectangle(brush_0, int_8, int_9, int_10, int_11);
		}

		static SolidBrush smethod_6(Color color_0)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Expected O, but got Unknown
			return new SolidBrush(color_0);
		}
	}

	private class Class3
	{
		public int int_0;

		public int int_1;

		public Class3(int int_2, int int_3)
		{
			int_0 = int_2;
			int_1 = int_3;
		}
	}

	private enum Enum0
	{
		Right,
		Left,
		Up,
		Down
	}

	private class Class4
	{
		public int int_0;

		public int int_1;

		public Random random_0;

		public Class4()
		{
			random_0 = Class4.smethod_0();
			int_0 = Class4.smethod_1(random_0, 0, 19) * 25;
			int_1 = Class4.smethod_1(random_0, 1, 20) * 25;
		}

		public void method_0(Graphics graphics_0, Pen pen_0, int int_2, int int_3)
		{
			Class4.smethod_2(graphics_0, pen_0, int_2, int_3, 25, 25);
			SolidBrush brush_ = Class4.smethod_3(Color.FromArgb(0, 0, 0, 0));
			Class4.smethod_4(graphics_0, (Brush)(object)brush_, int_2, int_3, 25, 25);
		}

		static Random smethod_0()
		{
			return new Random();
		}

		static int smethod_1(Random random_1, int int_2, int int_3)
		{
			return random_1.Next(int_2, int_3);
		}

		static void smethod_2(Graphics graphics_0, Pen pen_0, int int_2, int int_3, int int_4, int int_5)
		{
			graphics_0.DrawRectangle(pen_0, int_2, int_3, int_4, int_5);
		}

		static SolidBrush smethod_3(Color color_0)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Expected O, but got Unknown
			return new SolidBrush(color_0);
		}

		static void smethod_4(Graphics graphics_0, Brush brush_0, int int_2, int int_3, int int_4, int int_5)
		{
			graphics_0.FillRectangle(brush_0, int_2, int_3, int_4, int_5);
		}
	}

	private bool bool_0 = true;

	private bool bool_1 = true;

	private bool bool_2 = true;

	private bool bool_3 = true;

	private int int_0 = 400;

	private int int_1 = 0;

	private int int_2;

	private int int_3;

	private const int int_4 = 1;

	private const int int_5 = 400;

	private const int int_6 = 250;

	private const int int_7 = 100;

	private const int int_8 = 100;

	private const int int_9 = 200;

	private const int int_10 = 400;

	private const int int_11 = 502;

	private const int int_12 = 25;

	private const int int_13 = 0;

	private const int int_14 = 19;

	private const int int_15 = 1;

	private const int int_16 = 20;

	private Class2 class2_0;

	private Class4 class4_0;

	private Bitmap bitmap_0;

	private SoundPlayer soundPlayer_0 = GForm3.smethod_0("C:\\Users\\Владимир\\source\\repos\\Snake\\Snake\\bin\\Debug\\фон.wav");

	private IContainer icontainer_0 = null;

	private Panel panel_0;

	private Timer timer_0;

	private Button button_0;

	private TextBox textBox_0;

	private Button button_1;

	private Button button_2;

	private Button button_3;

	private Button button_4;

	private Button button_5;

	private Button button_6;

	private Label label_0;

	private Label label_1;

	private Label label_2;

	private TextBox textBox_1;

	private Button button_7;

	public GForm3()
	{
		method_14();
	}

	private void method_0(object sender, EventArgs e)
	{
		bitmap_0 = GForm3.smethod_1(502, 502);
		GForm3.smethod_2((Control)(object)panel_0, (Image)(object)bitmap_0);
		int_0 = 250;
	}

	private void method_1(object sender, EventArgs e)
	{
		GForm3.smethod_3((Control)(object)textBox_0, bool_4: false);
		GForm3.smethod_3((Control)(object)label_2, bool_4: false);
		GForm3.smethod_3((Control)(object)button_1, bool_4: true);
		GForm3.smethod_3((Control)(object)label_1, bool_4: false);
		GForm3.smethod_3((Control)(object)button_3, bool_4: true);
		GForm3.smethod_3((Control)(object)button_0, bool_4: true);
		GForm3.smethod_3((Control)(object)textBox_1, bool_4: false);
		GForm3.smethod_3((Control)(object)button_2, bool_4: true);
		GForm3.smethod_3((Control)(object)button_7, bool_4: false);
		GForm3.smethod_3((Control)(object)label_0, bool_4: false);
		bitmap_0 = GForm3.smethod_1(502, 502);
		GForm3.smethod_2((Control)(object)panel_0, (Image)(object)bitmap_0);
		string string_ = "Data Source = ВЛАДИМИР-ПК\\SQLEXPRESS; Initial Catalog = SnakeBase; Trusted_Connection = True";
		SqlConnection val = GForm3.smethod_4(string_);
		GForm3.smethod_5((DbConnection)(object)val);
		SqlCommand dbCommand_ = GForm3.smethod_9(GForm3.smethod_8(new string[5]
		{
			"insert into leaderboard (nickname, score) values ('",
			GForm3.smethod_6((Control)(object)textBox_1),
			"', ",
			GForm3.smethod_7(GForm3.smethod_6((Control)(object)label_1)).ToString(),
			")"
		}), val);
		GForm3.smethod_10((DbCommand)(object)dbCommand_);
		GForm3.smethod_11((DbConnection)(object)val);
		GForm3.smethod_12((TextBoxBase)(object)textBox_1);
	}

	private void method_2(object sender, KeyPressEventArgs e)
	{
		if (GForm3.smethod_13(e) == 'D' || GForm3.smethod_13(e) == 'd' || GForm3.smethod_13(e) == 'В' || GForm3.smethod_13(e) == 'в')
		{
			GForm3.smethod_14(e, bool_4: true);
			switch (class2_0.enum0_0)
			{
			case Enum0.Right:
				class2_0.enum0_0 = Enum0.Down;
				break;
			case Enum0.Left:
				class2_0.enum0_0 = Enum0.Up;
				break;
			case Enum0.Up:
				class2_0.enum0_0 = Enum0.Right;
				break;
			case Enum0.Down:
				class2_0.enum0_0 = Enum0.Left;
				break;
			}
		}
		if (GForm3.smethod_13(e) == 'A' || GForm3.smethod_13(e) == 'a' || GForm3.smethod_13(e) == 'Ф' || GForm3.smethod_13(e) == 'ф')
		{
			GForm3.smethod_14(e, bool_4: true);
			switch (class2_0.enum0_0)
			{
			case Enum0.Right:
				class2_0.enum0_0 = Enum0.Up;
				break;
			case Enum0.Left:
				class2_0.enum0_0 = Enum0.Down;
				break;
			case Enum0.Up:
				class2_0.enum0_0 = Enum0.Left;
				break;
			case Enum0.Down:
				class2_0.enum0_0 = Enum0.Right;
				break;
			}
		}
		if (GForm3.smethod_13(e) == 'P' || GForm3.smethod_13(e) == 'p' || GForm3.smethod_13(e) == 'З' || GForm3.smethod_13(e) == 'з')
		{
			GForm3.smethod_14(e, bool_4: true);
			if (!bool_3)
			{
				bool_3 = true;
				GForm3.smethod_17(timer_0);
				GForm3.smethod_16((Control)(object)textBox_0, "Игра окончена");
				GForm3.smethod_3((Control)(object)textBox_0, bool_4: false);
			}
			else
			{
				bool_3 = false;
				GForm3.smethod_15(timer_0);
				GForm3.smethod_16((Control)(object)textBox_0, "Пауза");
				GForm3.smethod_3((Control)(object)textBox_0, bool_4: true);
			}
		}
		if (GForm3.smethod_13(e) == 'M' || GForm3.smethod_13(e) == 'm' || GForm3.smethod_13(e) == 'Ь' || GForm3.smethod_13(e) == 'ь')
		{
			GForm3.smethod_14(e, bool_4: true);
			if (!bool_2)
			{
				bool_2 = true;
				GForm3.smethod_19(soundPlayer_0);
			}
			else
			{
				bool_2 = false;
				GForm3.smethod_18(soundPlayer_0);
			}
		}
	}

	private void method_3(object sender, EventArgs e)
	{
		GForm1 control_ = new GForm1();
		GForm3.smethod_20((Control)(object)control_);
	}

	private void method_4(object sender, EventArgs e)
	{
		GForm3.smethod_19(soundPlayer_0);
		int_1 = 0;
		GForm3.smethod_16((Control)(object)label_1, "0");
		Graphics graphics_ = GForm3.smethod_21((Image)(object)bitmap_0);
		Pen pen_ = GForm3.smethod_22(Color.FromArgb(255, 0, 0, 255), 1f);
		Pen pen_2 = GForm3.smethod_22(Color.FromArgb(255, 255, 0, 0), 1f);
		Random random_ = GForm3.smethod_23();
		class2_0 = new Class2();
		class4_0 = new Class4();
		do
		{
			for (int i = 0; i < class2_0.list_0.Count; i++)
			{
				if (class2_0.list_0[i].int_0 != class4_0.int_0 || class2_0.list_0[i].int_1 != class4_0.int_1)
				{
					bool_0 = true;
					continue;
				}
				bool_0 = false;
				class4_0.int_0 = GForm3.smethod_24(random_, 0, 19) * 25;
				class4_0.int_1 = GForm3.smethod_24(random_, 1, 20) * 25;
				break;
			}
		}
		while (!bool_0);
		class2_0.method_0(graphics_, pen_);
		class4_0.method_0(graphics_, pen_2, class4_0.int_0, class4_0.int_1);
		GForm3.smethod_3((Control)(object)textBox_0, bool_4: false);
		GForm3.smethod_3((Control)(object)button_1, bool_4: false);
		GForm3.smethod_3((Control)(object)label_1, bool_4: true);
		GForm3.smethod_3((Control)(object)button_4, bool_4: false);
		GForm3.smethod_3((Control)(object)button_3, bool_4: false);
		GForm3.smethod_3((Control)(object)button_0, bool_4: false);
		GForm3.smethod_3((Control)(object)button_6, bool_4: false);
		GForm3.smethod_3((Control)(object)button_2, bool_4: false);
		GForm3.smethod_3((Control)(object)button_5, bool_4: false);
		GForm3.smethod_3((Control)(object)label_0, bool_4: true);
		GForm3.smethod_17(timer_0);
	}

	private void method_5(object sender, EventArgs e)
	{
		GForm2 control_ = new GForm2();
		GForm3.smethod_20((Control)(object)control_);
	}

	private void method_6()
	{
		GForm3.smethod_3((Control)(object)button_4, bool_4: true);
		GForm3.smethod_3((Control)(object)button_5, bool_4: true);
		GForm3.smethod_3((Control)(object)button_6, bool_4: true);
	}

	private void method_7()
	{
		bool_1 = true;
		GForm3.smethod_3((Control)(object)button_4, bool_4: false);
		GForm3.smethod_3((Control)(object)button_5, bool_4: false);
		GForm3.smethod_3((Control)(object)button_6, bool_4: false);
	}

	private void method_8(object sender, EventArgs e)
	{
		if (bool_1)
		{
			bool_1 = false;
			method_6();
		}
		else
		{
			method_7();
		}
	}

	private void method_9(object sender, EventArgs e)
	{
		int_0 = 400;
		method_7();
	}

	private void method_10(object sender, EventArgs e)
	{
		int_0 = 250;
		method_7();
	}

	private void method_11(object sender, EventArgs e)
	{
		int_0 = 100;
		method_7();
	}

	private void method_12()
	{
		GForm3.smethod_3((Control)(object)label_2, bool_4: true);
		GForm3.smethod_3((Control)(object)textBox_1, bool_4: true);
		GForm3.smethod_3((Control)(object)button_7, bool_4: true);
	}

	private void method_13(object sender, EventArgs e)
	{
		GForm3.smethod_25(timer_0, int_0);
		Bitmap image_ = GForm3.smethod_1(502, 502);
		GForm3.smethod_2((Control)(object)panel_0, (Image)(object)image_);
		Graphics graphics_ = GForm3.smethod_21((Image)(object)image_);
		Pen pen_ = GForm3.smethod_22(Color.FromArgb(255, 0, 0, 255), 1f);
		Pen pen_2 = GForm3.smethod_22(Color.FromArgb(255, 255, 0, 0), 1f);
		Random random_ = GForm3.smethod_23();
		class2_0.method_1();
		for (int i = 1; i < class2_0.list_0.Count; i++)
		{
			if ((class2_0.list_0[0].int_0 == class2_0.list_0[i].int_0 && class2_0.list_0[0].int_1 == class2_0.list_0[i].int_1) || class2_0.list_0[0].int_0 > 477 || class2_0.list_0[0].int_0 < 0 || class2_0.list_0[0].int_1 > 477 || class2_0.list_0[0].int_1 < 0)
			{
				GForm3.smethod_15(timer_0);
				GForm3.smethod_18(soundPlayer_0);
				string string_ = "Data Source = ВЛАДИМИР-ПК\\SQLEXPRESS; Initial Catalog = SnakeBase; Trusted_Connection = True";
				SqlConnection val = GForm3.smethod_4(string_);
				GForm3.smethod_5((DbConnection)(object)val);
				SqlCommand dbCommand_ = GForm3.smethod_9("select count(*) from leaderboard", val);
				int_2 = (int)GForm3.smethod_26((DbCommand)(object)dbCommand_);
				if (int_2 > 0)
				{
					SqlCommand dbCommand_2 = GForm3.smethod_9("select (score) from leaderboard order by score", val);
					int_3 = (int)GForm3.smethod_26((DbCommand)(object)dbCommand_2);
				}
				if (int_2 < 10)
				{
					method_12();
				}
				else if (GForm3.smethod_7(GForm3.smethod_6((Control)(object)label_1)) <= int_3)
				{
					GForm3.smethod_3((Control)(object)button_0, bool_4: true);
					GForm3.smethod_3((Control)(object)button_1, bool_4: true);
					GForm3.smethod_3((Control)(object)button_3, bool_4: true);
					GForm3.smethod_3((Control)(object)button_2, bool_4: true);
				}
				else
				{
					SqlCommand dbCommand_3 = GForm3.smethod_9(GForm3.smethod_27("delete from leaderboard where score = ", int_3.ToString()), val);
					GForm3.smethod_10((DbCommand)(object)dbCommand_3);
					method_12();
				}
				GForm3.smethod_11((DbConnection)(object)val);
				GForm3.smethod_3((Control)(object)textBox_0, bool_4: true);
			}
		}
		if (class2_0.list_0[0].int_0 == class4_0.int_0 && class2_0.list_0[0].int_1 == class4_0.int_1)
		{
			int_1++;
			if (int_0 == 400)
			{
				GForm3.smethod_16((Control)(object)label_1, GForm3.smethod_28(100 * int_1));
			}
			if (int_0 == 250)
			{
				GForm3.smethod_16((Control)(object)label_1, GForm3.smethod_28(200 * int_1));
			}
			if (int_0 == 100)
			{
				GForm3.smethod_16((Control)(object)label_1, GForm3.smethod_28(400 * int_1));
			}
			class4_0 = new Class4();
			do
			{
				for (int j = 0; j < class2_0.list_0.Count; j++)
				{
					if (class2_0.list_0[j].int_0 != class4_0.int_0 || class2_0.list_0[j].int_1 != class4_0.int_1)
					{
						bool_0 = true;
						continue;
					}
					bool_0 = false;
					class4_0.int_0 = GForm3.smethod_24(random_, 0, 19) * 25;
					class4_0.int_1 = GForm3.smethod_24(random_, 1, 20) * 25;
					break;
				}
			}
			while (!bool_0);
			class2_0.list_0.Add(new Class3(class4_0.int_0, class4_0.int_1));
			class2_0.method_0(graphics_, pen_);
			class4_0.method_0(graphics_, pen_2, class4_0.int_0, class4_0.int_1);
		}
		else
		{
			class4_0.method_0(graphics_, pen_2, class4_0.int_0, class4_0.int_1);
			class2_0.method_0(graphics_, pen_);
		}
		GForm3.smethod_29((Control)(object)panel_0);
	}

	void Form.Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			GForm3.smethod_30((IDisposable)icontainer_0);
		}
		((Form)this).Dispose(disposing);
	}

	private void method_14()
	{
		//IL_0a37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a41: Expected O, but got Unknown
		icontainer_0 = GForm3.smethod_31();
		panel_0 = (Panel)(object)new GClass0();
		button_7 = GForm3.smethod_32();
		textBox_1 = GForm3.smethod_33();
		label_2 = GForm3.smethod_34();
		textBox_0 = GForm3.smethod_33();
		timer_0 = GForm3.smethod_35(icontainer_0);
		button_0 = GForm3.smethod_32();
		button_1 = GForm3.smethod_32();
		button_2 = GForm3.smethod_32();
		button_3 = GForm3.smethod_32();
		button_4 = GForm3.smethod_32();
		button_5 = GForm3.smethod_32();
		button_6 = GForm3.smethod_32();
		label_0 = GForm3.smethod_34();
		label_1 = GForm3.smethod_34();
		GForm3.smethod_36((Control)(object)panel_0);
		GForm3.smethod_37((Control)(object)this);
		GForm3.smethod_39((Control)(object)panel_0, GForm3.smethod_38());
		GForm3.smethod_41(GForm3.smethod_40((Control)(object)panel_0), (Control)(object)button_7);
		GForm3.smethod_41(GForm3.smethod_40((Control)(object)panel_0), (Control)(object)textBox_1);
		GForm3.smethod_41(GForm3.smethod_40((Control)(object)panel_0), (Control)(object)label_2);
		GForm3.smethod_41(GForm3.smethod_40((Control)(object)panel_0), (Control)(object)textBox_0);
		GForm3.smethod_42((Control)(object)panel_0, new Point(12, 12));
		GForm3.smethod_43((Control)(object)panel_0, "gameFieldPanel");
		GForm3.smethod_44((Control)(object)panel_0, new Size(502, 502));
		GForm3.smethod_45((Control)(object)panel_0, 0);
		GForm3.smethod_42((Control)(object)button_7, new Point(226, 373));
		GForm3.smethod_43((Control)(object)button_7, "saveNicknameButton");
		GForm3.smethod_44((Control)(object)button_7, new Size(75, 23));
		GForm3.smethod_45((Control)(object)button_7, 3);
		GForm3.smethod_16((Control)(object)button_7, "Сохранить");
		GForm3.smethod_46((ButtonBase)(object)button_7, bool_4: true);
		GForm3.smethod_3((Control)(object)button_7, bool_4: false);
		GForm3.smethod_47((Control)(object)button_7, (EventHandler)method_1);
		GForm3.smethod_42((Control)(object)textBox_1, new Point(185, 333));
		GForm3.smethod_43((Control)(object)textBox_1, "inputNicknameTextBox");
		GForm3.smethod_44((Control)(object)textBox_1, new Size(156, 20));
		GForm3.smethod_45((Control)(object)textBox_1, 2);
		GForm3.smethod_48(textBox_1, (HorizontalAlignment)2);
		GForm3.smethod_3((Control)(object)textBox_1, bool_4: false);
		GForm3.smethod_49((Control)(object)label_2, bool_4: true);
		GForm3.smethod_51((Control)(object)label_2, GForm3.smethod_50("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		GForm3.smethod_42((Control)(object)label_2, new Point(121, 275));
		GForm3.smethod_43((Control)(object)label_2, "congratulationsLabel");
		GForm3.smethod_44((Control)(object)label_2, new Size(296, 36));
		GForm3.smethod_45((Control)(object)label_2, 1);
		GForm3.smethod_16((Control)(object)label_2, "Вы попали в топ-10 лучших игроков.\r\nВведите Ваш никнейм:");
		GForm3.smethod_52(label_2, (ContentAlignment)2);
		GForm3.smethod_3((Control)(object)label_2, bool_4: false);
		GForm3.smethod_51((Control)(object)textBox_0, GForm3.smethod_50("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		GForm3.smethod_42((Control)(object)textBox_0, new Point(185, 225));
		GForm3.smethod_43((Control)(object)textBox_0, "alertTextBox");
		GForm3.smethod_53((TextBoxBase)(object)textBox_0, bool_4: true);
		GForm3.smethod_44((Control)(object)textBox_0, new Size(156, 29));
		GForm3.smethod_45((Control)(object)textBox_0, 4);
		GForm3.smethod_16((Control)(object)textBox_0, "Игра окончена");
		GForm3.smethod_48(textBox_0, (HorizontalAlignment)2);
		GForm3.smethod_3((Control)(object)textBox_0, bool_4: false);
		GForm3.smethod_25(timer_0, 400);
		GForm3.smethod_54(timer_0, (EventHandler)method_13);
		GForm3.smethod_51((Control)(object)button_0, GForm3.smethod_50("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		GForm3.smethod_42((Control)(object)button_0, new Point(536, 12));
		GForm3.smethod_43((Control)(object)button_0, "gameStartButton");
		GForm3.smethod_44((Control)(object)button_0, new Size(150, 65));
		GForm3.smethod_45((Control)(object)button_0, 0);
		GForm3.smethod_16((Control)(object)button_0, "Новая игра");
		GForm3.smethod_46((ButtonBase)(object)button_0, bool_4: true);
		GForm3.smethod_47((Control)(object)button_0, (EventHandler)method_4);
		GForm3.smethod_51((Control)(object)button_1, GForm3.smethod_50("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		GForm3.smethod_42((Control)(object)button_1, new Point(536, 154));
		GForm3.smethod_43((Control)(object)button_1, "controlButton");
		GForm3.smethod_44((Control)(object)button_1, new Size(150, 65));
		GForm3.smethod_45((Control)(object)button_1, 7);
		GForm3.smethod_16((Control)(object)button_1, "Управление");
		GForm3.smethod_46((ButtonBase)(object)button_1, bool_4: true);
		GForm3.smethod_47((Control)(object)button_1, (EventHandler)method_3);
		GForm3.smethod_51((Control)(object)button_2, GForm3.smethod_50("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		GForm3.smethod_42((Control)(object)button_2, new Point(536, 225));
		GForm3.smethod_43((Control)(object)button_2, "leaderboardButton");
		GForm3.smethod_44((Control)(object)button_2, new Size(150, 65));
		GForm3.smethod_45((Control)(object)button_2, 6);
		GForm3.smethod_16((Control)(object)button_2, "Таблица лидеров");
		GForm3.smethod_46((ButtonBase)(object)button_2, bool_4: true);
		GForm3.smethod_47((Control)(object)button_2, (EventHandler)method_5);
		GForm3.smethod_51((Control)(object)button_3, GForm3.smethod_50("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		GForm3.smethod_42((Control)(object)button_3, new Point(536, 83));
		GForm3.smethod_43((Control)(object)button_3, "gameDifficultChangeButton");
		GForm3.smethod_44((Control)(object)button_3, new Size(150, 65));
		GForm3.smethod_45((Control)(object)button_3, 5);
		GForm3.smethod_16((Control)(object)button_3, "Уровень сложности");
		GForm3.smethod_46((ButtonBase)(object)button_3, bool_4: true);
		GForm3.smethod_47((Control)(object)button_3, (EventHandler)method_8);
		GForm3.smethod_42((Control)(object)button_4, new Point(692, 83));
		GForm3.smethod_43((Control)(object)button_4, "easyDiffButton");
		GForm3.smethod_44((Control)(object)button_4, new Size(75, 20));
		GForm3.smethod_45((Control)(object)button_4, 8);
		GForm3.smethod_16((Control)(object)button_4, "Easy");
		GForm3.smethod_46((ButtonBase)(object)button_4, bool_4: true);
		GForm3.smethod_3((Control)(object)button_4, bool_4: false);
		GForm3.smethod_47((Control)(object)button_4, (EventHandler)method_9);
		GForm3.smethod_42((Control)(object)button_5, new Point(692, 105));
		GForm3.smethod_43((Control)(object)button_5, "normalDiffButton");
		GForm3.smethod_44((Control)(object)button_5, new Size(75, 20));
		GForm3.smethod_45((Control)(object)button_5, 9);
		GForm3.smethod_16((Control)(object)button_5, "Normal");
		GForm3.smethod_46((ButtonBase)(object)button_5, bool_4: true);
		GForm3.smethod_3((Control)(object)button_5, bool_4: false);
		GForm3.smethod_47((Control)(object)button_5, (EventHandler)method_10);
		GForm3.smethod_42((Control)(object)button_6, new Point(692, 128));
		GForm3.smethod_43((Control)(object)button_6, "hardDiffButton");
		GForm3.smethod_44((Control)(object)button_6, new Size(75, 20));
		GForm3.smethod_45((Control)(object)button_6, 10);
		GForm3.smethod_16((Control)(object)button_6, "Hard");
		GForm3.smethod_46((ButtonBase)(object)button_6, bool_4: true);
		GForm3.smethod_3((Control)(object)button_6, bool_4: false);
		GForm3.smethod_47((Control)(object)button_6, (EventHandler)method_11);
		GForm3.smethod_49((Control)(object)label_0, bool_4: true);
		GForm3.smethod_51((Control)(object)label_0, GForm3.smethod_50("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		GForm3.smethod_42((Control)(object)label_0, new Point(12, 528));
		GForm3.smethod_43((Control)(object)label_0, "scoreTitleLabel");
		GForm3.smethod_44((Control)(object)label_0, new Size(51, 18));
		GForm3.smethod_45((Control)(object)label_0, 11);
		GForm3.smethod_16((Control)(object)label_0, "Счет:");
		GForm3.smethod_52(label_0, (ContentAlignment)2);
		GForm3.smethod_3((Control)(object)label_0, bool_4: false);
		GForm3.smethod_49((Control)(object)label_1, bool_4: true);
		GForm3.smethod_51((Control)(object)label_1, GForm3.smethod_50("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		GForm3.smethod_42((Control)(object)label_1, new Point(59, 528));
		GForm3.smethod_43((Control)(object)label_1, "currentScoreLabel");
		GForm3.smethod_44((Control)(object)label_1, new Size(17, 18));
		GForm3.smethod_45((Control)(object)label_1, 12);
		GForm3.smethod_16((Control)(object)label_1, "0");
		GForm3.smethod_52(label_1, (ContentAlignment)2);
		GForm3.smethod_3((Control)(object)label_1, bool_4: false);
		GForm3.smethod_55((ContainerControl)(object)this, new SizeF(6f, 13f));
		GForm3.smethod_56((ContainerControl)(object)this, (AutoScaleMode)1);
		GForm3.smethod_57((Form)(object)this, new Size(774, 562));
		GForm3.smethod_41(GForm3.smethod_58((Control)(object)this), (Control)(object)label_1);
		GForm3.smethod_41(GForm3.smethod_58((Control)(object)this), (Control)(object)label_0);
		GForm3.smethod_41(GForm3.smethod_58((Control)(object)this), (Control)(object)button_6);
		GForm3.smethod_41(GForm3.smethod_58((Control)(object)this), (Control)(object)button_5);
		GForm3.smethod_41(GForm3.smethod_58((Control)(object)this), (Control)(object)button_4);
		GForm3.smethod_41(GForm3.smethod_58((Control)(object)this), (Control)(object)button_1);
		GForm3.smethod_41(GForm3.smethod_58((Control)(object)this), (Control)(object)button_2);
		GForm3.smethod_41(GForm3.smethod_58((Control)(object)this), (Control)(object)button_3);
		GForm3.smethod_41(GForm3.smethod_58((Control)(object)this), (Control)(object)button_0);
		GForm3.smethod_41(GForm3.smethod_58((Control)(object)this), (Control)(object)panel_0);
		((Control)this).set_DoubleBuffered(true);
		GForm3.smethod_59((Form)(object)this, bool_4: true);
		GForm3.smethod_60((Control)(object)this, "snakeApplication");
		GForm3.smethod_16((Control)(object)this, "Змейка");
		GForm3.smethod_61((Form)(object)this, (EventHandler)method_0);
		GForm3.smethod_62((Control)(object)this, new KeyPressEventHandler(method_2));
		GForm3.smethod_63((Control)(object)panel_0, bool_4: false);
		GForm3.smethod_64((Control)(object)panel_0);
		GForm3.smethod_65((Control)(object)this, bool_4: false);
		GForm3.smethod_66((Control)(object)this);
	}

	static SoundPlayer smethod_0(string string_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new SoundPlayer(string_0);
	}

	static Bitmap smethod_1(int int_17, int int_18)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new Bitmap(int_17, int_18);
	}

	static void smethod_2(Control control_0, Image image_0)
	{
		control_0.set_BackgroundImage(image_0);
	}

	static void smethod_3(Control control_0, bool bool_4)
	{
		control_0.set_Visible(bool_4);
	}

	static SqlConnection smethod_4(string string_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new SqlConnection(string_0);
	}

	static void smethod_5(DbConnection dbConnection_0)
	{
		dbConnection_0.Open();
	}

	static string smethod_6(Control control_0)
	{
		return control_0.get_Text();
	}

	static int smethod_7(string string_0)
	{
		return Convert.ToInt32(string_0);
	}

	static string smethod_8(string[] string_0)
	{
		return string.Concat(string_0);
	}

	static SqlCommand smethod_9(string string_0, SqlConnection sqlConnection_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new SqlCommand(string_0, sqlConnection_0);
	}

	static int smethod_10(DbCommand dbCommand_0)
	{
		return dbCommand_0.ExecuteNonQuery();
	}

	static void smethod_11(DbConnection dbConnection_0)
	{
		dbConnection_0.Close();
	}

	static void smethod_12(TextBoxBase textBoxBase_0)
	{
		textBoxBase_0.Clear();
	}

	static char smethod_13(KeyPressEventArgs keyPressEventArgs_0)
	{
		return keyPressEventArgs_0.get_KeyChar();
	}

	static void smethod_14(KeyPressEventArgs keyPressEventArgs_0, bool bool_4)
	{
		keyPressEventArgs_0.set_Handled(bool_4);
	}

	static void smethod_15(Timer timer_1)
	{
		timer_1.Stop();
	}

	static void smethod_16(Control control_0, string string_0)
	{
		control_0.set_Text(string_0);
	}

	static void smethod_17(Timer timer_1)
	{
		timer_1.Start();
	}

	static void smethod_18(SoundPlayer soundPlayer_1)
	{
		soundPlayer_1.Stop();
	}

	static void smethod_19(SoundPlayer soundPlayer_1)
	{
		soundPlayer_1.Play();
	}

	static void smethod_20(Control control_0)
	{
		control_0.Show();
	}

	static Graphics smethod_21(Image image_0)
	{
		return Graphics.FromImage(image_0);
	}

	static Pen smethod_22(Color color_0, float float_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new Pen(color_0, float_0);
	}

	static Random smethod_23()
	{
		return new Random();
	}

	static int smethod_24(Random random_0, int int_17, int int_18)
	{
		return random_0.Next(int_17, int_18);
	}

	static void smethod_25(Timer timer_1, int int_17)
	{
		timer_1.set_Interval(int_17);
	}

	static object smethod_26(DbCommand dbCommand_0)
	{
		return dbCommand_0.ExecuteScalar();
	}

	static string smethod_27(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static string smethod_28(int int_17)
	{
		return Convert.ToString(int_17);
	}

	static void smethod_29(Control control_0)
	{
		control_0.Refresh();
	}

	static void smethod_30(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Container smethod_31()
	{
		return new Container();
	}

	static Button smethod_32()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Button();
	}

	static TextBox smethod_33()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new TextBox();
	}

	static Label smethod_34()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Label();
	}

	static Timer smethod_35(IContainer icontainer_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new Timer(icontainer_1);
	}

	static void smethod_36(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_37(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static Color smethod_38()
	{
		return SystemColors.Info;
	}

	static void smethod_39(Control control_0, Color color_0)
	{
		control_0.set_BackColor(color_0);
	}

	static ControlCollection smethod_40(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_41(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_42(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_43(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_44(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_45(Control control_0, int int_17)
	{
		control_0.set_TabIndex(int_17);
	}

	static void smethod_46(ButtonBase buttonBase_0, bool bool_4)
	{
		buttonBase_0.set_UseVisualStyleBackColor(bool_4);
	}

	static void smethod_47(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_Click(eventHandler_0);
	}

	static void smethod_48(TextBox textBox_2, HorizontalAlignment horizontalAlignment_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		textBox_2.set_TextAlign(horizontalAlignment_0);
	}

	static void smethod_49(Control control_0, bool bool_4)
	{
		control_0.set_AutoSize(bool_4);
	}

	static Font smethod_50(string string_0, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_51(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static void smethod_52(Label label_3, ContentAlignment contentAlignment_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		label_3.set_TextAlign(contentAlignment_0);
	}

	static void smethod_53(TextBoxBase textBoxBase_0, bool bool_4)
	{
		textBoxBase_0.set_ReadOnly(bool_4);
	}

	static void smethod_54(Timer timer_1, EventHandler eventHandler_0)
	{
		timer_1.add_Tick(eventHandler_0);
	}

	static void smethod_55(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_56(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_57(Form form_0, Size size_0)
	{
		form_0.set_ClientSize(size_0);
	}

	static ControlCollection smethod_58(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_59(Form form_0, bool bool_4)
	{
		form_0.set_KeyPreview(bool_4);
	}

	static void smethod_60(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_61(Form form_0, EventHandler eventHandler_0)
	{
		form_0.add_Load(eventHandler_0);
	}

	static void smethod_62(Control control_0, KeyPressEventHandler keyPressEventHandler_0)
	{
		control_0.add_KeyPress(keyPressEventHandler_0);
	}

	static void smethod_63(Control control_0, bool bool_4)
	{
		control_0.ResumeLayout(bool_4);
	}

	static void smethod_64(Control control_0)
	{
		control_0.PerformLayout();
	}

	static void smethod_65(Control control_0, bool bool_4)
	{
		control_0.ResumeLayout(bool_4);
	}

	static void smethod_66(Control control_0)
	{
		control_0.PerformLayout();
	}
}
