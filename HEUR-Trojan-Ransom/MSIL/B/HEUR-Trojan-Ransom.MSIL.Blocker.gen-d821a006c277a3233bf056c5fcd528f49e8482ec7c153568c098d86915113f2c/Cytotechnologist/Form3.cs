using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Cytotechnologist;

public class Form3 : Form
{
	private IContainer components = null;

	private Button button1;

	private Button button2;

	private Button button4;

	private Button button5;

	private Button button7;

	private TextBox textBox1;

	private Label label1;

	private TextBox textBox2;

	private Button NullButton;

	private ErrorProvider errorProvider1;

	public Form3()
	{
		InitializeComponent();
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		Form val = default(Form);
		while (true)
		{
			int num = -668826762;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x911B86BDu) % 8u)
				{
				case 7u:
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = (int)((num2 * 762481111) ^ 0x7287A52D);
					continue;
				case 5u:
					Form3.smethod_4((Control)(object)val);
					Form3.smethod_10(val, new Point(Form3.smethod_5((Form)(object)this).X + (Form3.smethod_6((Control)(object)this) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_5((Form)(object)this).Y + (Form3.smethod_8((Control)(object)this) - Form3.smethod_9((Control)(object)val)) / 2 + 70));
					num = ((int)num2 * -1968981267) ^ 0x6D346978;
					continue;
				case 4u:
					num = ((int)num2 * -1434301202) ^ 0x41765B12;
					continue;
				case 3u:
					Form3.smethod_0((Control)(object)NullButton);
					Form3.smethod_1(errorProvider1);
					num = (int)(num2 * 613526469) ^ -521836912;
					continue;
				case 2u:
				{
					Form4 form = new Form4();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					num = (int)(num2 * 1232856570) ^ -2041058172;
					continue;
				}
				case 1u:
					num = (int)(num2 * 461966637) ^ -151658458;
					continue;
				default:
					return;
				case 0u:
					break;
				case 6u:
					return;
				}
				break;
			}
		}
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		Form val = default(Form);
		while (true)
		{
			int num = -1948175211;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8A10564Cu) % 6u)
				{
				case 5u:
					Form3.smethod_0((Control)(object)NullButton);
					num = (int)((num2 * 778899777) ^ 0x1584BDCF);
					continue;
				case 3u:
					num = (int)((num2 * 779249894) ^ 0x7B45BC20);
					continue;
				case 2u:
					Form3.smethod_10(val, new Point(Form3.smethod_13(Form3.smethod_12((Form)(object)this)).X + (Form3.smethod_7((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_13(Form3.smethod_12((Form)(object)this)).Y + (Form3.smethod_9((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_9((Control)(object)val)) / 2));
					num = (int)(num2 * 1606064627) ^ -1190896145;
					continue;
				case 0u:
				{
					Form2 form = new Form2();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					Form3.smethod_4((Control)(object)val);
					num = (int)(num2 * 770327279) ^ -1609338327;
					continue;
				}
				case 4u:
					break;
				default:
					Form3.smethod_11((Control)(object)this, bool_0: false);
					return;
				}
				break;
			}
		}
	}

	public void Button_Continue()
	{
		Form3.smethod_14((Control)(object)button5, bool_0: true);
		while (true)
		{
			int num = -306137226;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCADC749Du) % 3u)
				{
				case 2u:
					goto IL_000e;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_000e:
				num = ((int)num2 * -2065310717) ^ 0x7DE5B90F;
			}
		}
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		int num5 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 873770308;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1997ABB9u) % 9u)
				{
				case 7u:
					num5 = Form3.smethod_8((Control)(object)this) - 1;
					Form3.smethod_15((Control)(object)this, num5);
					num = 161276879;
					continue;
				case 6u:
					num = ((int)num2 * -1177259360) ^ 0x770BA6DB;
					continue;
				case 4u:
					num = (int)(num2 * 1573894404) ^ -1803325901;
					continue;
				case 3u:
					flag = num5 > 1;
					num = (int)(num2 * 425479286) ^ -375438719;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -227721816;
						num4 = -227721816;
					}
					else
					{
						num3 = -1196492897;
						num4 = -1196492897;
					}
					num = num3 ^ ((int)num2 * -54728075);
					continue;
				}
				case 1u:
					num = 512667387;
					continue;
				case 0u:
					Form3.smethod_16(Form3.smethod_12((Form)(object)this));
					num = ((int)num2 * -1611912328) ^ -600833663;
					continue;
				case 8u:
					break;
				default:
					Form3.smethod_17((Form3.smethod_12((Form)(object)this) as Form1).timer1);
					return;
				}
				break;
			}
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
	}

	private void TextBox_TextChanged(object sender, EventArgs e)
	{
		Form3.smethod_1(errorProvider1);
		while (true)
		{
			int num = 1610539015;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5FE069E7u) % 3u)
				{
				case 1u:
					goto IL_000d;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_000d:
				num = (int)((num2 * 295928774) ^ 0x7525184C);
			}
		}
	}

	public void ContinueLock()
	{
		Form3.smethod_14((Control)(object)button5, bool_0: false);
	}

	public void AchivUnlock()
	{
		Form3.smethod_14((Control)(object)button7, bool_0: true);
	}

	private void Button7_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -1250949622;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF6525C64u) % 3u)
				{
				case 1u:
					goto IL_0003;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0003:
				Form3.smethod_0((Control)(object)NullButton);
				Form3.smethod_14((Control)(object)button7, bool_0: false);
				num = ((int)num2 * -2057207099) ^ 0x7EA8AD92;
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		while (true)
		{
			int num = 1539054278;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xAFB05B4u) % 8u)
				{
				case 7u:
					if (components != null)
					{
						num = 201302352;
						num3 = 201302352;
						continue;
					}
					goto IL_0011;
				case 6u:
					num = (int)((num2 * 1265456653) ^ 0xC83FF13);
					continue;
				case 5u:
					((Form)this).Dispose(disposing);
					num = 53701346;
					continue;
				case 4u:
					Form3.smethod_18((IDisposable)components);
					num = (int)(num2 * 1442564507) ^ -1799757373;
					continue;
				case 3u:
					num = ((int)num2 * -560425720) ^ -386713815;
					continue;
				case 2u:
					if (disposing)
					{
						num = (int)((num2 * 1560803353) ^ 0x6F6F5EC1);
						continue;
					}
					goto IL_0011;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
					IL_0011:
					num = 1930739185;
					num3 = 1930739185;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		while (true)
		{
			int num = -1704026621;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC5EE5189u) % 121u)
				{
				case 120u:
					Form3.smethod_33((Control)(object)button2, 1);
					num = ((int)num2 * -205132762) ^ 0x7A198895;
					continue;
				case 119u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox1);
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button7);
					num = (int)((num2 * 1503676428) ^ 0x1DB75F63);
					continue;
				case 118u:
					Form3.smethod_29((ButtonBase)(object)button5, (FlatStyle)0);
					num = ((int)num2 * -1917635937) ^ 0x4570D5FA;
					continue;
				case 117u:
					Form3.smethod_31((Control)(object)button7, "button7");
					num = (int)(num2 * 21873620) ^ -1666846217;
					continue;
				case 116u:
					textBox1 = Form3.smethod_21();
					num = ((int)num2 * -1570695530) ^ -983742255;
					continue;
				case 115u:
					num = (int)((num2 * 731497303) ^ 0x42797F60);
					continue;
				case 114u:
					Form3.smethod_26((Control)(object)label1, Color.Transparent);
					num = ((int)num2 * -1974976301) ^ -1286714021;
					continue;
				case 113u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button2);
					num = (int)((num2 * 1014949831) ^ 0x5E75A372);
					continue;
				case 112u:
					num = ((int)num2 * -1862724743) ^ -2064866884;
					continue;
				case 111u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button5), 0);
					num = (int)((num2 * 9022729) ^ 0x20B6C31E);
					continue;
				case 110u:
					Form3.smethod_32((Control)(object)label1, new Size(207, 76));
					Form3.smethod_33((Control)(object)label1, 7);
					num = (int)((num2 * 185853101) ^ 0x7A1CA662);
					continue;
				case 108u:
					Form3.smethod_31((Control)(object)button5, "button5");
					num = ((int)num2 * -1805348817) ^ -1972883525;
					continue;
				case 107u:
					Form3.smethod_34((ButtonBase)(object)button5, bool_0: true);
					num = ((int)num2 * -224687856) ^ -688998894;
					continue;
				case 106u:
					Form3.smethod_34((ButtonBase)(object)button4, bool_0: true);
					Form3.smethod_36((Control)(object)button4, (EventHandler)Button4_Click);
					num = (int)((num2 * 330667780) ^ 0x127847D7);
					continue;
				case 105u:
					Form3.smethod_34((ButtonBase)(object)button1, bool_0: true);
					num = (int)(num2 * 213635618) ^ -1470204385;
					continue;
				case 104u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button5);
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button4);
					num = (int)((num2 * 1916217474) ^ 0x4CE13EE6);
					continue;
				case 103u:
					Form3.smethod_29((ButtonBase)(object)button7, (FlatStyle)0);
					Form3.smethod_38((Control)(object)button7, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form3.smethod_30((Control)(object)button7, new Point(174, 243));
					num = (int)((num2 * 1012366245) ^ 0x7C3A2334);
					continue;
				case 102u:
					Form3.smethod_38((Control)(object)button4, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 671633769) ^ 0x6140A93E);
					continue;
				case 101u:
					num = ((int)num2 * -227223935) ^ -2083011764;
					continue;
				case 100u:
					num = ((int)num2 * -638865862) ^ -1535157224;
					continue;
				case 99u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)label1);
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)NullButton);
					num = (int)(num2 * 1981349169) ^ -410916340;
					continue;
				case 98u:
					components = Form3.smethod_19();
					num = (int)((num2 * 1310521781) ^ 0x3198413F);
					continue;
				case 97u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -644635626) ^ -1993393979;
					continue;
				case 96u:
					button4 = Form3.smethod_20();
					num = ((int)num2 * -826635984) ^ -1009804690;
					continue;
				case 95u:
					Form3.smethod_50((Form)(object)this, bool_0: false);
					num = (int)((num2 * 2008532688) ^ 0x23FB94BE);
					continue;
				case 94u:
					Form3.smethod_29((ButtonBase)(object)button4, (FlatStyle)0);
					num = (int)((num2 * 1872553906) ^ 0x1DF2A50);
					continue;
				case 93u:
					num = (int)((num2 * 1590664641) ^ 0x1FDE603B);
					continue;
				case 92u:
					num = ((int)num2 * -3542951) ^ -1336776768;
					continue;
				case 91u:
					num = (int)((num2 * 736802672) ^ 0x7AD69DD);
					continue;
				case 90u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button7), 0);
					num = (int)((num2 * 1776545321) ^ 0x132FCA29);
					continue;
				case 89u:
					num = ((int)num2 * -787930636) ^ 0xD0B445F;
					continue;
				case 88u:
					Form3.smethod_34((ButtonBase)(object)NullButton, bool_0: false);
					num = (int)((num2 * 992436044) ^ 0x2A908673);
					continue;
				case 87u:
					label1 = Form3.smethod_22();
					textBox2 = Form3.smethod_21();
					errorProvider1 = Form3.smethod_23(components);
					num = (int)(num2 * 1449879463) ^ -2032902812;
					continue;
				case 86u:
					num = (int)((num2 * 477996839) ^ 0xE05DDE5);
					continue;
				case 85u:
					num = ((int)num2 * -304470110) ^ 0x67F156AE;
					continue;
				case 84u:
					button2 = Form3.smethod_20();
					num = ((int)num2 * -1141315680) ^ 0x299BD65B;
					continue;
				case 83u:
					Form3.smethod_33((Control)(object)NullButton, 3);
					num = ((int)num2 * -814318961) ^ -1360144578;
					continue;
				case 82u:
					Form3.smethod_33((Control)(object)textBox2, 8);
					Form3.smethod_41(textBox2, bool_0: true);
					num = ((int)num2 * -331029006) ^ 0x3D3206EE;
					continue;
				case 81u:
					num = (int)((num2 * 1308172731) ^ 0x7C248877);
					continue;
				case 80u:
					num = ((int)num2 * -683200483) ^ -123015022;
					continue;
				case 79u:
					num = ((int)num2 * -1007457845) ^ 0x162EB69A;
					continue;
				case 78u:
					num = (int)((num2 * 1432904457) ^ 0x260BF511);
					continue;
				case 77u:
					Form3.smethod_35((Control)(object)button1, "Вход");
					num = (int)((num2 * 1436199729) ^ 0x2ACE5043);
					continue;
				case 75u:
					Form3.smethod_45((Form)(object)this, new Size(486, 296));
					num = ((int)num2 * -1488225382) ^ 0x435750C;
					continue;
				case 74u:
					Form3.smethod_14((Control)(object)button4, bool_0: false);
					num = ((int)num2 * -1174416995) ^ 0x2598D42D;
					continue;
				case 73u:
					Form3.smethod_32((Control)(object)button5, new Size(140, 50));
					num = (int)((num2 * 702486261) ^ 0x78452E08);
					continue;
				case 72u:
					Form3.smethod_32((Control)(object)button4, new Size(140, 50));
					num = (int)((num2 * 107545563) ^ 0x2D1BD430);
					continue;
				case 71u:
					Form3.smethod_32((Control)(object)button2, new Size(85, 21));
					num = ((int)num2 * -1948697199) ^ 0x65727F78;
					continue;
				case 70u:
					num = ((int)num2 * -476403515) ^ 0x4AE8D0FF;
					continue;
				case 69u:
					Form3.smethod_32((Control)(object)button7, new Size(140, 50));
					Form3.smethod_33((Control)(object)button7, 6);
					num = ((int)num2 * -1248335527) ^ -1547232432;
					continue;
				case 68u:
					button5 = Form3.smethod_20();
					button7 = Form3.smethod_20();
					num = (int)((num2 * 489315268) ^ 0x57EB04CF);
					continue;
				case 67u:
					num = (int)((num2 * 1086555487) ^ 0x2771BDAD);
					continue;
				case 66u:
					Form3.smethod_35((Control)(object)button2, "Регистрация");
					num = (int)((num2 * 610379453) ^ 0x2E9CA537);
					continue;
				case 65u:
					Form3.smethod_32((Control)(object)textBox1, new Size(140, 20));
					Form3.smethod_33((Control)(object)textBox1, 7);
					num = ((int)num2 * -224417750) ^ -1668185075;
					continue;
				case 64u:
					num = ((int)num2 * -1995936224) ^ 0x7600BED1;
					continue;
				case 63u:
					Form3.smethod_35((Control)(object)label1, "QUARTO");
					num = ((int)num2 * -1814898776) ^ -1744776562;
					continue;
				case 62u:
					Form3.smethod_36((Control)(object)button5, (EventHandler)Button5_Click);
					num = (int)(num2 * 1706424657) ^ -1394419187;
					continue;
				case 61u:
					num = ((int)num2 * -1613962910) ^ -1135720669;
					continue;
				case 60u:
					Form3.smethod_31((Control)(object)button2, "button2");
					num = ((int)num2 * -1318890982) ^ -223673435;
					continue;
				case 59u:
					Form3.smethod_30((Control)(object)textBox2, new Point(174, 26));
					Form3.smethod_31((Control)(object)textBox2, "textBox2");
					num = ((int)num2 * -1137131745) ^ -848932599;
					continue;
				case 58u:
					Form3.smethod_53((Form)(object)this, bool_0: false);
					num = (int)((num2 * 144921698) ^ 0x4260DFD0);
					continue;
				case 57u:
					Form3.smethod_32((Control)(object)NullButton, new Size(1, 1));
					num = ((int)num2 * -1219816019) ^ -1940169285;
					continue;
				case 56u:
					num = (int)((num2 * 71411620) ^ 0x4DB1A549);
					continue;
				case 55u:
					Form3.smethod_31((Control)(object)textBox1, "textBox1");
					num = (int)(num2 * 1853894859) ^ -926236940;
					continue;
				case 54u:
					Form3.smethod_30((Control)(object)button4, new Point(174, 137));
					num = ((int)num2 * -1878152174) ^ 0x661AD6E;
					continue;
				case 53u:
					Form3.smethod_35((Control)(object)button5, "Продолжить");
					num = (int)((num2 * 1368206452) ^ 0x5365177);
					continue;
				case 52u:
					num = (int)((num2 * 650893757) ^ 0x33355B1B);
					continue;
				case 51u:
					Form3.smethod_14((Control)(object)button5, bool_0: false);
					num = (int)(num2 * 201989855) ^ -505207689;
					continue;
				case 50u:
					Form3.smethod_31((Control)(object)label1, "label1");
					num = ((int)num2 * -1507575566) ^ -891168216;
					continue;
				case 49u:
					Form3.smethod_29((ButtonBase)(object)NullButton, (FlatStyle)0);
					Form3.smethod_30((Control)(object)NullButton, new Point(-1, -1));
					num = ((int)num2 * -117776321) ^ -475066860;
					continue;
				case 48u:
					num = (int)(num2 * 1476202810) ^ -186875363;
					continue;
				case 47u:
					num = (int)(num2 * 1203822679) ^ -198887575;
					continue;
				case 46u:
					Form3.smethod_33((Control)(object)button1, 0);
					num = ((int)num2 * -632786805) ^ -205810773;
					continue;
				case 45u:
					Form3.smethod_32((Control)(object)textBox2, new Size(140, 20));
					num = ((int)num2 * -777486184) ^ 0x7EB4C98;
					continue;
				case 44u:
					Form3.smethod_26((Control)(object)this, Color.White);
					num = ((int)num2 * -870993711) ^ -119698506;
					continue;
				case 43u:
					Form3.smethod_38((Control)(object)label1, Form3.smethod_37("Mistral", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form3.smethod_30((Control)(object)label1, new Point(140, 70));
					num = (int)(num2 * 134882104) ^ -1769563874;
					continue;
				case 42u:
					Form3.smethod_30((Control)(object)button1, new Point(265, 49));
					num = ((int)num2 * -338194478) ^ -1768038054;
					continue;
				case 41u:
					Form3.smethod_51((Control)(object)this, "Form3");
					num = (int)(num2 * 505791523) ^ -624101440;
					continue;
				case 40u:
					Form3.smethod_39((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = (int)((num2 * 1086064458) ^ 0x56CC30FA);
					continue;
				case 39u:
					Form3.smethod_31((Control)(object)NullButton, "NullButton");
					num = (int)((num2 * 1993142163) ^ 0xF418A14);
					continue;
				case 38u:
					Form3.smethod_55((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -2108808637) ^ -1929306205;
					continue;
				case 37u:
					NullButton = Form3.smethod_20();
					button1 = Form3.smethod_20();
					num = (int)(num2 * 1259948706) ^ -414959463;
					continue;
				case 36u:
					Form3.smethod_38((Control)(object)button5, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 920087202) ^ -700376540;
					continue;
				case 35u:
					Form3.smethod_48((Form)(object)this, (FormBorderStyle)0);
					num = (int)((num2 * 93652971) ^ 0x5F42CD27);
					continue;
				case 34u:
					num = ((int)num2 * -751869191) ^ -292370000;
					continue;
				case 33u:
					Form3.smethod_35((Control)(object)button4, "Начало игры");
					num = ((int)num2 * -1284656407) ^ 0x6C296FE1;
					continue;
				case 32u:
					num = ((int)num2 * -1197980932) ^ -785216634;
					continue;
				case 31u:
					num = (int)((num2 * 7264473) ^ 0x1D1FDD43);
					continue;
				case 30u:
					Form3.smethod_42(errorProvider1, (ContainerControl)(object)this);
					num = ((int)num2 * -1930189931) ^ -1655383884;
					continue;
				case 29u:
					Form3.smethod_40((Control)(object)label1, bool_0: true);
					num = (int)(num2 * 491354122) ^ -1560818893;
					continue;
				case 28u:
					Form3.smethod_30((Control)(object)button5, new Point(174, 190));
					num = (int)((num2 * 1341014826) ^ 0xFA7B4E1);
					continue;
				case 27u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button4), 0);
					num = ((int)num2 * -739360989) ^ 0x3C690166;
					continue;
				case 26u:
					Form3.smethod_52((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1373268042) ^ -1879750255;
					continue;
				case 25u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)NullButton), 0);
					num = ((int)num2 * -605034359) ^ -1764177971;
					continue;
				case 24u:
					Form3.smethod_31((Control)(object)button1, "button1");
					Form3.smethod_32((Control)(object)button1, new Size(49, 21));
					num = (int)(num2 * 143439733) ^ -1706568977;
					continue;
				case 23u:
					Form3.smethod_39((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = (int)((num2 * 272228910) ^ 0x5D98CC0F);
					continue;
				case 22u:
					num = (int)((num2 * 1193446357) ^ 0x13C76557);
					continue;
				case 21u:
					Form3.smethod_34((ButtonBase)(object)button7, bool_0: true);
					num = ((int)num2 * -182678141) ^ 0x3FA1A18B;
					continue;
				case 20u:
					Form3.smethod_24((ISupportInitialize)errorProvider1);
					Form3.smethod_25((Control)(object)this);
					num = ((int)num2 * -1875762185) ^ 0x45483A92;
					continue;
				case 19u:
					num = (int)(num2 * 1523987928) ^ -661122030;
					continue;
				case 18u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox2);
					num = (int)((num2 * 1589811092) ^ 0x529503A8);
					continue;
				case 17u:
					Form3.smethod_36((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -1152441002) ^ -203353679;
					continue;
				case 16u:
					Form3.smethod_49((Form)(object)this, bool_0: false);
					num = (int)((num2 * 944566538) ^ 0x1B46C7E2);
					continue;
				case 15u:
					Form3.smethod_33((Control)(object)button5, 5);
					num = (int)((num2 * 771569579) ^ 0x5A1E64D2);
					continue;
				case 14u:
					Form3.smethod_54((Form)(object)this, bool_0: true);
					num = (int)(num2 * 1938859782) ^ -546769895;
					continue;
				case 13u:
					Form3.smethod_31((Control)(object)button4, "button4");
					num = (int)((num2 * 1976689075) ^ 0xB133CC5);
					continue;
				case 12u:
					Form3.smethod_34((ButtonBase)(object)button2, bool_0: true);
					Form3.smethod_36((Control)(object)button2, (EventHandler)Button2_Click);
					num = ((int)num2 * -1315709491) ^ 0xAB0DAD5;
					continue;
				case 11u:
					Form3.smethod_43((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -1093308524) ^ 0x76F6C9B3;
					continue;
				case 10u:
					num = ((int)num2 * -1580123903) ^ 0x5EA72FBD;
					continue;
				case 9u:
					Form3.smethod_33((Control)(object)button4, 4);
					num = (int)((num2 * 1706753040) ^ 0x13F0F1D0);
					continue;
				case 8u:
					Form3.smethod_30((Control)(object)button2, new Point(174, 49));
					num = ((int)num2 * -1513516902) ^ 0x312DA5CE;
					continue;
				case 7u:
					Form3.smethod_35((Control)(object)button7, "Достижения");
					num = (int)((num2 * 1525428797) ^ 0x2F022595);
					continue;
				case 6u:
					num = ((int)num2 * -1951549823) ^ -858233745;
					continue;
				case 5u:
					Form3.smethod_44((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -1011891605) ^ 0x7CD1258E;
					continue;
				case 4u:
					Form3.smethod_26((Control)(object)NullButton, Color.Transparent);
					num = (int)((num2 * 874462493) ^ 0x36339D17);
					continue;
				case 3u:
					Form3.smethod_56((Control)(object)this, bool_0: false);
					Form3.smethod_57((Control)(object)this);
					num = ((int)num2 * -1943977882) ^ -1768066619;
					continue;
				case 2u:
					num = ((int)num2 * -1824861824) ^ 0x26EC7383;
					continue;
				case 1u:
					Form3.smethod_36((Control)(object)button7, (EventHandler)Button7_Click);
					Form3.smethod_30((Control)(object)textBox1, new Point(174, 2));
					num = ((int)num2 * -758356187) ^ 0x7DB32A3B;
					continue;
				case 0u:
					num = (int)(num2 * 1404559171) ^ -1341484860;
					continue;
				default:
					return;
				case 109u:
					break;
				case 76u:
					return;
				}
				break;
			}
		}
	}

	static bool smethod_0(Control control_0)
	{
		return control_0.Focus();
	}

	static void smethod_1(ErrorProvider errorProvider_0)
	{
		errorProvider_0.Clear();
	}

	static void smethod_2(Form form_0, bool bool_0)
	{
		form_0.set_TopMost(bool_0);
	}

	static void smethod_3(Form form_0, Form form_1)
	{
		form_0.set_Owner(form_1);
	}

	static void smethod_4(Control control_0)
	{
		control_0.Show();
	}

	static Point smethod_5(Form form_0)
	{
		return form_0.get_Location();
	}

	static int smethod_6(Control control_0)
	{
		return control_0.get_Width();
	}

	static int smethod_7(Control control_0)
	{
		return control_0.get_Width();
	}

	static int smethod_8(Control control_0)
	{
		return control_0.get_Height();
	}

	static int smethod_9(Control control_0)
	{
		return control_0.get_Height();
	}

	static void smethod_10(Form form_0, Point point_0)
	{
		form_0.set_Location(point_0);
	}

	static void smethod_11(Control control_0, bool bool_0)
	{
		control_0.set_Enabled(bool_0);
	}

	static Form smethod_12(Form form_0)
	{
		return form_0.get_Owner();
	}

	static Point smethod_13(Form form_0)
	{
		return form_0.get_Location();
	}

	static void smethod_14(Control control_0, bool bool_0)
	{
		control_0.set_Enabled(bool_0);
	}

	static void smethod_15(Control control_0, int int_0)
	{
		control_0.set_Height(int_0);
	}

	static void smethod_16(Form form_0)
	{
		form_0.Activate();
	}

	static void smethod_17(Timer timer_0)
	{
		timer_0.Start();
	}

	static void smethod_18(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Container smethod_19()
	{
		return new Container();
	}

	static Button smethod_20()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Button();
	}

	static TextBox smethod_21()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new TextBox();
	}

	static Label smethod_22()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Label();
	}

	static ErrorProvider smethod_23(IContainer icontainer_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new ErrorProvider(icontainer_0);
	}

	static void smethod_24(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.BeginInit();
	}

	static void smethod_25(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_26(Control control_0, Color color_0)
	{
		control_0.set_BackColor(color_0);
	}

	static FlatButtonAppearance smethod_27(ButtonBase buttonBase_0)
	{
		return buttonBase_0.get_FlatAppearance();
	}

	static void smethod_28(FlatButtonAppearance flatButtonAppearance_0, int int_0)
	{
		flatButtonAppearance_0.set_BorderSize(int_0);
	}

	static void smethod_29(ButtonBase buttonBase_0, FlatStyle flatStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		buttonBase_0.set_FlatStyle(flatStyle_0);
	}

	static void smethod_30(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_31(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_32(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_33(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static void smethod_34(ButtonBase buttonBase_0, bool bool_0)
	{
		buttonBase_0.set_UseVisualStyleBackColor(bool_0);
	}

	static void smethod_35(Control control_0, string string_0)
	{
		control_0.set_Text(string_0);
	}

	static void smethod_36(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_Click(eventHandler_0);
	}

	static Font smethod_37(string string_0, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_38(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static void smethod_39(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_TextChanged(eventHandler_0);
	}

	static void smethod_40(Control control_0, bool bool_0)
	{
		control_0.set_AutoSize(bool_0);
	}

	static void smethod_41(TextBox textBox_0, bool bool_0)
	{
		textBox_0.set_UseSystemPasswordChar(bool_0);
	}

	static void smethod_42(ErrorProvider errorProvider_0, ContainerControl containerControl_0)
	{
		errorProvider_0.set_ContainerControl(containerControl_0);
	}

	static void smethod_43(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_44(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_45(Form form_0, Size size_0)
	{
		form_0.set_ClientSize(size_0);
	}

	static ControlCollection smethod_46(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_47(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_48(Form form_0, FormBorderStyle formBorderStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_FormBorderStyle(formBorderStyle_0);
	}

	static void smethod_49(Form form_0, bool bool_0)
	{
		form_0.set_MaximizeBox(bool_0);
	}

	static void smethod_50(Form form_0, bool bool_0)
	{
		form_0.set_MinimizeBox(bool_0);
	}

	static void smethod_51(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_52(Form form_0, bool bool_0)
	{
		form_0.set_ShowIcon(bool_0);
	}

	static void smethod_53(Form form_0, bool bool_0)
	{
		form_0.set_ShowInTaskbar(bool_0);
	}

	static void smethod_54(Form form_0, bool bool_0)
	{
		form_0.set_TopMost(bool_0);
	}

	static void smethod_55(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.EndInit();
	}

	static void smethod_56(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_57(Control control_0)
	{
		control_0.PerformLayout();
	}
}
