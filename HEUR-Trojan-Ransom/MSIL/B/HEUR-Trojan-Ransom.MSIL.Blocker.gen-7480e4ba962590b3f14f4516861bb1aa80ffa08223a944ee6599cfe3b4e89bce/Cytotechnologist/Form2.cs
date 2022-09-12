using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Cytotechnologist;

public class Form2 : Form
{
	private Random rnd = Form2.smethod_0();

	private bool flag = true;

	private IContainer components = null;

	private Label label1;

	private Label label2;

	private TextBox textBox1;

	private Button button1;

	private Label label3;

	public Form2()
	{
		InitializeComponent();
		Form2.smethod_1((Control)(object)label1, "Введите любое число от 0 до 9 включительно.\nВаш соперник уже загадал число (N) из этого\nже диапазона. Если сумма ваших чисел будет\nчетным числом, то первым ход делаете Вы,\nиначе - ваш соперник Компьютер!");
	}

	private void Form2_FormClosed(object sender, FormClosedEventArgs e)
	{
		Form2.smethod_3((Control)(object)Form2.smethod_2((Form)(object)this), bool_0: true);
		while (true)
		{
			int num = 288453125;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1AC3F4D6u) % 3u)
				{
				case 1u:
					goto IL_000e;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_000e:
				num = ((int)num2 * -1203544280) ^ -1941712943;
			}
		}
	}

	private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
	{
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 1108263540;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x538E9275u) % 11u)
				{
				case 10u:
					Form2.smethod_5(e, bool_0: true);
					num = (int)((num2 * 1904739531) ^ 0x343D3861);
					continue;
				case 9u:
					Form2.smethod_1((Control)(object)textBox1, "");
					num = 259354532;
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = -9027210;
						num6 = -9027210;
					}
					else
					{
						num5 = -1697887329;
						num6 = -1697887329;
					}
					num = num5 ^ ((int)num2 * -851434008);
					continue;
				}
				case 5u:
					Button1_Click(this, Form2.smethod_6());
					num = (int)(num2 * 1515749732) ^ -719766036;
					continue;
				case 4u:
					flag2 = !char.IsDigit(Form2.smethod_4(e));
					num = ((int)num2 * -1997635592) ^ -2116489187;
					continue;
				case 3u:
					num = ((int)num2 * -1644233051) ^ -1425355856;
					continue;
				case 2u:
					flag = Form2.smethod_4(e) == '\r';
					num = 1910364010;
					continue;
				case 1u:
					num = (int)(num2 * 1821486233) ^ -694508087;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1797749019;
						num4 = -1797749019;
					}
					else
					{
						num3 = -179243629;
						num4 = -179243629;
					}
					num = num3 ^ ((int)num2 * -558420208);
					continue;
				}
				default:
					return;
				case 8u:
					break;
				case 6u:
					return;
				}
				break;
			}
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		bool flag2 = default(bool);
		int num5 = default(int);
		bool flag = default(bool);
		int num4 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = -412241284;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCA00B13Du) % 36u)
				{
				case 35u:
					this.flag = false;
					num = -895572663;
					continue;
				case 34u:
					flag2 = num5 > 1;
					num = (int)(num2 * 416030133) ^ -1240741745;
					continue;
				case 33u:
				{
					int num12;
					int num13;
					if (!flag)
					{
						num12 = 84379198;
						num13 = 84379198;
					}
					else
					{
						num12 = 815737239;
						num13 = 815737239;
					}
					num = num12 ^ (int)(num2 * 1167307376);
					continue;
				}
				case 32u:
					num = ((int)num2 * -131240266) ^ -473579813;
					continue;
				case 31u:
					num = ((int)num2 * -1665358733) ^ 0x804CBBF;
					continue;
				case 30u:
					(Form2.smethod_2((Form)(object)this) as Form3).Button_Continue();
					num = ((int)num2 * -1991541648) ^ -553438820;
					continue;
				case 29u:
					Form2.smethod_1((Control)(object)label3, "Первым ход делает Компьютер.");
					num = (int)(num2 * 2029242516) ^ -646647094;
					continue;
				case 28u:
					num = -410012530;
					continue;
				case 27u:
					num = (int)((num2 * 398850302) ^ 0x7E47C515);
					continue;
				case 26u:
				{
					int num10;
					int num11;
					if (this.flag)
					{
						num10 = 712072139;
						num11 = 712072139;
					}
					else
					{
						num10 = 2102096167;
						num11 = 2102096167;
					}
					num = num10 ^ (int)(num2 * 165750936);
					continue;
				}
				case 25u:
				{
					Form control_2 = Form2.smethod_2((Form)(object)this);
					num5 = Form2.smethod_12((Control)(object)control_2) - 1;
					Form2.smethod_13((Control)(object)control_2, num5);
					num = -312600095;
					continue;
				}
				case 24u:
					num = (int)((num2 * 111681143) ^ 0x39CB9EDD);
					continue;
				case 22u:
					num = -590247580;
					continue;
				case 21u:
				{
					int num8;
					int num9;
					if (Form2.smethod_8(Form2.smethod_7((Control)(object)textBox1), ""))
					{
						num8 = 215105335;
						num9 = 215105335;
					}
					else
					{
						num8 = 54361271;
						num9 = 54361271;
					}
					num = num8 ^ (int)(num2 * 1376329465);
					continue;
				}
				case 20u:
					num = ((int)num2 * -1968544100) ^ 0x750E4519;
					continue;
				case 19u:
					num = (int)((num2 * 975718942) ^ 0x1FD2D04F);
					continue;
				case 18u:
					num = ((int)num2 * -583998590) ^ -332856253;
					continue;
				case 17u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = true;
					num = (int)((num2 * 320715909) ^ 0x1B89D09B);
					continue;
				case 16u:
				{
					int num6;
					int num7;
					if (flag2)
					{
						num6 = -2106721650;
						num7 = -2106721650;
					}
					else
					{
						num6 = -1152223229;
						num7 = -1152223229;
					}
					num = num6 ^ (int)(num2 * 1864619686);
					continue;
				}
				case 15u:
					num = -562464060;
					continue;
				case 14u:
					num = (int)((num2 * 465017782) ^ 0x9B4B3C8);
					continue;
				case 13u:
					num = ((int)num2 * -2002619464) ^ -655019419;
					continue;
				case 12u:
					Form2.smethod_14(Form2.smethod_11(Form2.smethod_2((Form)(object)this)));
					num = (int)((num2 * 128827893) ^ 0x2F683080);
					continue;
				case 11u:
					num = ((int)num2 * -493926358) ^ 0x527ACDB1;
					continue;
				case 10u:
					num4 = int.Parse(Form2.smethod_7((Control)(object)textBox1));
					num = ((int)num2 * -1873744686) ^ 0x614DBD18;
					continue;
				case 9u:
					num3 = Form2.smethod_9(rnd, 10);
					num = ((int)num2 * -698035959) ^ 0x68026C30;
					continue;
				case 8u:
					flag = (num4 + num3) % 2 == 0;
					num = ((int)num2 * -1515954071) ^ -1327364504;
					continue;
				case 7u:
					num = -590247580;
					continue;
				case 6u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = false;
					num = ((int)num2 * -1209782524) ^ -516882322;
					continue;
				case 5u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).StartGame();
					num = (int)((num2 * 322712023) ^ 0x1B6C26BC);
					continue;
				case 4u:
					num = (int)((num2 * 454835438) ^ 0x12374EA9);
					continue;
				case 2u:
					Form2.smethod_15((Form)(object)this);
					num = ((int)num2 * -1198683288) ^ 0xEA99B92;
					continue;
				case 1u:
					Form2.smethod_1((Control)(object)label3, "Поздравляем! Ваш ход первый.");
					num = (int)(num2 * 1852830718) ^ -285077838;
					continue;
				case 0u:
				{
					Label control_ = label2;
					string string_ = num3.ToString();
					num5 = num4 + num3;
					Form2.smethod_1((Control)(object)control_, Form2.smethod_10("+", string_, "=", num5.ToString()));
					num = ((int)num2 * -937212211) ^ -1164445779;
					continue;
				}
				default:
					return;
				case 23u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			goto IL_0047;
		}
		int num = 0;
		goto IL_008d;
		IL_0084:
		num = ((components != null) ? 1 : 0);
		goto IL_008d;
		IL_0047:
		int num2 = 1295351200;
		goto IL_005b;
		IL_005b:
		bool flag = default(bool);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x3216FB23u) % 6u)
			{
			case 5u:
				Form2.smethod_16((IDisposable)components);
				num2 = ((int)num3 * -1165999212) ^ -550099460;
				continue;
			case 4u:
			{
				int num4;
				int num5;
				if (!flag)
				{
					num4 = -1388369140;
					num5 = -1388369140;
				}
				else
				{
					num4 = -536501045;
					num5 = -536501045;
				}
				num2 = num4 ^ ((int)num3 * -1837892379);
				continue;
			}
			case 2u:
				break;
			case 0u:
				num2 = ((int)num3 * -1771336625) ^ 0x3C8B14BC;
				continue;
			case 1u:
				goto IL_0084;
			default:
				((Form)this).Dispose(disposing);
				return;
			}
			break;
		}
		goto IL_0047;
		IL_008d:
		flag = (byte)num != 0;
		num2 = 1134092671;
		goto IL_005b;
	}

	private void InitializeComponent()
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0641: Unknown result type (might be due to invalid IL or missing references)
		//IL_064b: Expected O, but got Unknown
		label1 = Form2.smethod_17();
		while (true)
		{
			int num = -1662241852;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x89B87E44u) % 58u)
				{
				case 57u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label3);
					num = (int)((num2 * 671633089) ^ 0x36F09842);
					continue;
				case 56u:
					num = ((int)num2 * -1795868394) ^ 0xE243331;
					continue;
				case 55u:
					Form2.smethod_41((Form)(object)this, new FormClosedEventHandler(Form2_FormClosed));
					num = ((int)num2 * -1831296773) ^ 0x6BFC3FEA;
					continue;
				case 54u:
					Form2.smethod_21((Control)(object)label3, bool_0: true);
					Form2.smethod_22((Control)(object)label3, new Point(47, 177));
					Form2.smethod_23((Control)(object)label3, "label3");
					num = ((int)num2 * -233319210) ^ 0x6987D5F5;
					continue;
				case 53u:
					num = (int)((num2 * 1425621677) ^ 0x1B45BFAE);
					continue;
				case 52u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label2);
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label1);
					num = ((int)num2 * -1347530278) ^ 0xF03461A;
					continue;
				case 51u:
					Form2.smethod_23((Control)(object)button1, "button1");
					num = (int)(num2 * 775718433) ^ -537645995;
					continue;
				case 50u:
					label2 = Form2.smethod_17();
					num = (int)(num2 * 573062780) ^ -404373596;
					continue;
				case 49u:
					Form2.smethod_1((Control)(object)label2, "+N=?");
					Form2.smethod_22((Control)(object)button1, new Point(86, 193));
					num = ((int)num2 * -119257294) ^ -1755982533;
					continue;
				case 48u:
					num = ((int)num2 * -1325958128) ^ -385525164;
					continue;
				case 47u:
					Form2.smethod_25((Control)(object)label3, 4);
					Form2.smethod_31((ContainerControl)(object)this, new SizeF(6f, 13f));
					Form2.smethod_32((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -85548339) ^ -920527647;
					continue;
				case 46u:
					num = (int)(num2 * 1254811507) ^ -476456594;
					continue;
				case 45u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)button1);
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)textBox1);
					num = ((int)num2 * -1555249596) ^ 0x44356768;
					continue;
				case 44u:
					num = (int)(num2 * 653986735) ^ -994627330;
					continue;
				case 43u:
					num = (int)(num2 * 1998138638) ^ -1499277335;
					continue;
				case 42u:
					num = (int)(num2 * 945593122) ^ -421279687;
					continue;
				case 41u:
					Form2.smethod_24((Control)(object)label3, new Size(0, 13));
					num = (int)((num2 * 1990191182) ^ 0x1DD8E82A);
					continue;
				case 40u:
					Form2.smethod_23((Control)(object)textBox1, "textBox1");
					num = (int)(num2 * 442148175) ^ -315030917;
					continue;
				case 39u:
					num = ((int)num2 * -85046134) ^ -1083423259;
					continue;
				case 38u:
					num = ((int)num2 * -312846475) ^ 0x79A940F6;
					continue;
				case 37u:
					num = ((int)num2 * -573491245) ^ -1668751059;
					continue;
				case 36u:
					Form2.smethod_37((Form)(object)this, bool_0: false);
					Form2.smethod_38((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1845025456) ^ 0x4DD45CA8;
					continue;
				case 35u:
					num = (int)((num2 * 1070529742) ^ 0x316F0948);
					continue;
				case 34u:
					Form2.smethod_39((Control)(object)this, "Form2");
					Form2.smethod_40((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1169081222) ^ 0xBE2954D;
					continue;
				case 33u:
					Form2.smethod_42((Control)(object)this, bool_0: false);
					num = (int)((num2 * 1738853985) ^ 0x6153CCC1);
					continue;
				case 32u:
					Form2.smethod_24((Control)(object)label1, new Size(35, 13));
					num = ((int)num2 * -1114388212) ^ 0x706F76BB;
					continue;
				case 31u:
					Form2.smethod_27((Control)(object)label2, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1156681623) ^ -449405205;
					continue;
				case 30u:
					textBox1 = Form2.smethod_18();
					num = (int)((num2 * 544386202) ^ 0x6F610526);
					continue;
				case 29u:
					Form2.smethod_1((Control)(object)button1, "OK");
					num = (int)(num2 * 768956084) ^ -515730605;
					continue;
				case 28u:
					Form2.smethod_24((Control)(object)button1, new Size(73, 23));
					num = (int)(num2 * 1381583525) ^ -2105065221;
					continue;
				case 27u:
					Form2.smethod_25((Control)(object)label1, 0);
					Form2.smethod_1((Control)(object)label1, "label1");
					num = (int)((num2 * 1866327826) ^ 0x7BF2A545);
					continue;
				case 26u:
					Form2.smethod_22((Control)(object)label2, new Point(53, 89));
					num = (int)((num2 * 1653865226) ^ 0x3CFA9F3F);
					continue;
				case 25u:
					Form2.smethod_25((Control)(object)button1, 3);
					num = (int)(num2 * 1161268470) ^ -453948877;
					continue;
				case 24u:
					button1 = Form2.smethod_19();
					label3 = Form2.smethod_17();
					num = (int)(num2 * 864311098) ^ -1146483352;
					continue;
				case 23u:
					Form2.smethod_22((Control)(object)label1, new Point(10, 10));
					num = (int)((num2 * 1725444636) ^ 0x35725CE1);
					continue;
				case 22u:
					Form2.smethod_33((Form)(object)this, new Size(255, 224));
					num = (int)((num2 * 783112438) ^ 0x4C4D1A53);
					continue;
				case 21u:
					Form2.smethod_21((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -764373240) ^ -1167217766;
					continue;
				case 20u:
					Form2.smethod_43((Control)(object)this);
					num = (int)(num2 * 260402046) ^ -1623453444;
					continue;
				case 19u:
					Form2.smethod_24((Control)(object)label2, new Size(188, 73));
					num = (int)(num2 * 1937337285) ^ -191363331;
					continue;
				case 17u:
					num = ((int)num2 * -1174182871) ^ 0x3BF5A0BC;
					continue;
				case 16u:
					Form2.smethod_20((Control)(object)this);
					num = (int)(num2 * 1990197) ^ -1372350814;
					continue;
				case 15u:
					Form2.smethod_1((Control)(object)this, "Жеребьёвка");
					num = (int)((num2 * 797074244) ^ 0x1ECF275D);
					continue;
				case 14u:
					num = ((int)num2 * -1951495984) ^ -627997440;
					continue;
				case 13u:
					num = (int)(num2 * 1719217847) ^ -1102627292;
					continue;
				case 12u:
					Form2.smethod_30((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)(num2 * 559785873) ^ -284861984;
					continue;
				case 11u:
					Form2.smethod_29((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -1712823363) ^ 0xDFFA271;
					continue;
				case 10u:
					Form2.smethod_23((Control)(object)label1, "label1");
					num = (int)((num2 * 856870859) ^ 0x7DE31ED0);
					continue;
				case 8u:
					num = (int)(num2 * 1425164514) ^ -75927705;
					continue;
				case 7u:
					Form2.smethod_21((Control)(object)label2, bool_0: true);
					num = (int)(num2 * 1011064828) ^ -1269593713;
					continue;
				case 6u:
					Form2.smethod_25((Control)(object)textBox1, 1);
					Form2.smethod_28((Control)(object)textBox1, new KeyPressEventHandler(TextBox1_KeyPress));
					num = ((int)num2 * -1058385777) ^ 0x2B1C7A05;
					continue;
				case 5u:
					Form2.smethod_24((Control)(object)textBox1, new Size(42, 80));
					num = (int)(num2 * 1002507613) ^ -754036977;
					continue;
				case 4u:
					Form2.smethod_23((Control)(object)label2, "label2");
					num = ((int)num2 * -1463898170) ^ 0x62F7344B;
					continue;
				case 3u:
					Form2.smethod_27((Control)(object)textBox1, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form2.smethod_22((Control)(object)textBox1, new Point(24, 86));
					num = ((int)num2 * -1742033745) ^ -799954662;
					continue;
				case 2u:
					Form2.smethod_36((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -341131262) ^ -1360250966;
					continue;
				case 1u:
					num = ((int)num2 * -1907563208) ^ 0x725681CA;
					continue;
				case 0u:
					Form2.smethod_25((Control)(object)label2, 2);
					num = ((int)num2 * -178304338) ^ -166601847;
					continue;
				default:
					return;
				case 9u:
					break;
				case 18u:
					return;
				}
				break;
			}
		}
	}

	static Random smethod_0()
	{
		return new Random();
	}

	static void smethod_1(Control control_0, string string_0)
	{
		control_0.set_Text(string_0);
	}

	static Form smethod_2(Form form_0)
	{
		return form_0.get_Owner();
	}

	static void smethod_3(Control control_0, bool bool_0)
	{
		control_0.set_Enabled(bool_0);
	}

	static char smethod_4(KeyPressEventArgs keyPressEventArgs_0)
	{
		return keyPressEventArgs_0.get_KeyChar();
	}

	static void smethod_5(KeyPressEventArgs keyPressEventArgs_0, bool bool_0)
	{
		keyPressEventArgs_0.set_Handled(bool_0);
	}

	static EventArgs smethod_6()
	{
		return new EventArgs();
	}

	static string smethod_7(Control control_0)
	{
		return control_0.get_Text();
	}

	static bool smethod_8(string string_0, string string_1)
	{
		return string_0 != string_1;
	}

	static int smethod_9(Random random_0, int int_0)
	{
		return random_0.Next(int_0);
	}

	static string smethod_10(string string_0, string string_1, string string_2, string string_3)
	{
		return string_0 + string_1 + string_2 + string_3;
	}

	static Form smethod_11(Form form_0)
	{
		return form_0.get_Owner();
	}

	static int smethod_12(Control control_0)
	{
		return control_0.get_Height();
	}

	static void smethod_13(Control control_0, int int_0)
	{
		control_0.set_Height(int_0);
	}

	static void smethod_14(Form form_0)
	{
		form_0.Activate();
	}

	static void smethod_15(Form form_0)
	{
		form_0.Close();
	}

	static void smethod_16(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Label smethod_17()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Label();
	}

	static TextBox smethod_18()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new TextBox();
	}

	static Button smethod_19()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Button();
	}

	static void smethod_20(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_21(Control control_0, bool bool_0)
	{
		control_0.set_AutoSize(bool_0);
	}

	static void smethod_22(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_23(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_24(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_25(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static Font smethod_26(string string_0, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_27(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static void smethod_28(Control control_0, KeyPressEventHandler keyPressEventHandler_0)
	{
		control_0.add_KeyPress(keyPressEventHandler_0);
	}

	static void smethod_29(ButtonBase buttonBase_0, bool bool_0)
	{
		buttonBase_0.set_UseVisualStyleBackColor(bool_0);
	}

	static void smethod_30(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_Click(eventHandler_0);
	}

	static void smethod_31(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_32(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_33(Form form_0, Size size_0)
	{
		form_0.set_ClientSize(size_0);
	}

	static ControlCollection smethod_34(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_35(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_36(Form form_0, FormBorderStyle formBorderStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_FormBorderStyle(formBorderStyle_0);
	}

	static void smethod_37(Form form_0, bool bool_0)
	{
		form_0.set_MaximizeBox(bool_0);
	}

	static void smethod_38(Form form_0, bool bool_0)
	{
		form_0.set_MinimizeBox(bool_0);
	}

	static void smethod_39(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_40(Form form_0, bool bool_0)
	{
		form_0.set_ShowIcon(bool_0);
	}

	static void smethod_41(Form form_0, FormClosedEventHandler formClosedEventHandler_0)
	{
		form_0.add_FormClosed(formClosedEventHandler_0);
	}

	static void smethod_42(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_43(Control control_0)
	{
		control_0.PerformLayout();
	}
}
