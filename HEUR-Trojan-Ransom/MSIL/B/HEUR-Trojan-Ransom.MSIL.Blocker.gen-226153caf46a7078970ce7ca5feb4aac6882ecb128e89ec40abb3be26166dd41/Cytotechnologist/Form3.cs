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
		Form3.smethod_0((Control)(object)NullButton);
		Form3.smethod_1(errorProvider1);
		Form4 form = new Form4();
		Form3.smethod_2((Form)(object)form, bool_0: true);
		Form3.smethod_3((Form)(object)form, (Form)(object)this);
		Form val = (Form)(object)form;
		while (true)
		{
			int num = -540506920;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE3BE8319u) % 6u)
				{
				case 4u:
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = ((int)num2 * -969487464) ^ -1463307011;
					continue;
				case 3u:
					Form3.smethod_4((Control)(object)val);
					num = ((int)num2 * -1569283194) ^ 0x5FB8DBD;
					continue;
				case 2u:
					Form3.smethod_10(val, new Point(Form3.smethod_5((Form)(object)this).X + (Form3.smethod_6((Control)(object)this) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_5((Form)(object)this).Y + (Form3.smethod_8((Control)(object)this) - Form3.smethod_9((Control)(object)val)) / 2 + 70));
					num = (int)((num2 * 1317852873) ^ 0xEEF3F88);
					continue;
				case 1u:
					num = ((int)num2 * -1910544937) ^ 0x1DD6988A;
					continue;
				default:
					return;
				case 5u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		Form3.smethod_0((Control)(object)NullButton);
		Form2 form = new Form2();
		Form3.smethod_2((Form)(object)form, bool_0: true);
		Form3.smethod_3((Form)(object)form, (Form)(object)this);
		Form val = (Form)(object)form;
		while (true)
		{
			int num = -1315587669;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9464E9A6u) % 6u)
				{
				case 5u:
					Form3.smethod_4((Control)(object)val);
					num = (int)(num2 * 1155932158) ^ -566348596;
					continue;
				case 4u:
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = (int)(num2 * 639931355) ^ -3999209;
					continue;
				case 3u:
					Form3.smethod_10(val, new Point(Form3.smethod_13(Form3.smethod_12((Form)(object)this)).X + (Form3.smethod_7((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_13(Form3.smethod_12((Form)(object)this)).Y + (Form3.smethod_9((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_9((Control)(object)val)) / 2));
					num = ((int)num2 * -213061116) ^ -1766258718;
					continue;
				case 2u:
					num = ((int)num2 * -344774188) ^ -427336179;
					continue;
				default:
					return;
				case 0u:
					break;
				case 1u:
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
			int num = 1618828607;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3F5AC90Bu) % 3u)
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
				num = (int)((num2 * 335077812) ^ 0x2943B00E);
			}
		}
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -1946266958;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x96EAD77Au) % 9u)
				{
				case 8u:
				{
					int num5 = Form3.smethod_8((Control)(object)this) - 1;
					Form3.smethod_15((Control)(object)this, num5);
					flag = num5 > 1;
					num = -1604138701;
					continue;
				}
				case 7u:
					Form3.smethod_17((Form3.smethod_12((Form)(object)this) as Form1).timer1);
					num = (int)(num2 * 169889038) ^ -1367641018;
					continue;
				case 5u:
					num = -428674047;
					continue;
				case 4u:
					Form3.smethod_16(Form3.smethod_12((Form)(object)this));
					num = ((int)num2 * -1231743840) ^ 0x325C2E7B;
					continue;
				case 3u:
					num = ((int)num2 * -991515454) ^ -2027678448;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1116125111;
						num4 = -1116125111;
					}
					else
					{
						num3 = -1324568698;
						num4 = -1324568698;
					}
					num = num3 ^ ((int)num2 * -934544823);
					continue;
				}
				case 1u:
					num = (int)((num2 * 1941860878) ^ 0x3B5094F1);
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

	private void Button1_Click(object sender, EventArgs e)
	{
	}

	private void TextBox_TextChanged(object sender, EventArgs e)
	{
		Form3.smethod_1(errorProvider1);
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
		Form3.smethod_0((Control)(object)NullButton);
		while (true)
		{
			int num = 1336826051;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1EBDCA98u) % 3u)
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
				Form3.smethod_14((Control)(object)button7, bool_0: false);
				num = ((int)num2 * -419606317) ^ 0x263214D0;
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -1427134061;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xA1DC41D0u) % 10u)
				{
				case 9u:
					((Form)this).Dispose(disposing);
					num = -668311956;
					continue;
				case 7u:
					num3 = ((components != null) ? 1 : 0);
					goto IL_0020;
				case 6u:
					num = ((int)num2 * -708444182) ^ -763881128;
					continue;
				case 5u:
					num = (int)((num2 * 831542491) ^ 0x90F7C0);
					continue;
				case 4u:
					num = (int)((num2 * 1817174634) ^ 0x67F3DB8E);
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 355372977;
						num5 = 355372977;
					}
					else
					{
						num4 = 1550135504;
						num5 = 1550135504;
					}
					num = num4 ^ ((int)num2 * -776531697);
					continue;
				}
				case 1u:
					if (disposing)
					{
						num = (int)(num2 * 240628882) ^ -1192826335;
						continue;
					}
					num3 = 0;
					goto IL_0020;
				case 0u:
					Form3.smethod_18((IDisposable)components);
					num = (int)((num2 * 1064435873) ^ 0x4F72FA0D);
					continue;
				default:
					return;
				case 3u:
					break;
				case 8u:
					return;
					IL_0020:
					flag = (byte)num3 != 0;
					num = -1896487568;
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
			int num = -1917384008;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF5B34008u) % 131u)
				{
				case 130u:
					Form3.smethod_35((Control)(object)button5, "Продолжить");
					num = (int)(num2 * 62877986) ^ -1554433645;
					continue;
				case 129u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button2);
					num = (int)((num2 * 1787532008) ^ 0x5413A97D);
					continue;
				case 128u:
					label1 = Form3.smethod_22();
					num = ((int)num2 * -512648677) ^ 0x5994D13C;
					continue;
				case 127u:
					Form3.smethod_35((Control)(object)label1, "QUARTO");
					num = (int)(num2 * 284003695) ^ -269473423;
					continue;
				case 126u:
					num = (int)((num2 * 1521477650) ^ 0x6D4FE36C);
					continue;
				case 125u:
					num = (int)(num2 * 2132294416) ^ -734333613;
					continue;
				case 124u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox1);
					num = (int)((num2 * 1942491275) ^ 0x28C2D7A8);
					continue;
				case 123u:
					textBox2 = Form3.smethod_21();
					num = ((int)num2 * -1322357597) ^ 0x1FBFF789;
					continue;
				case 122u:
					num = ((int)num2 * -192120786) ^ -2065187938;
					continue;
				case 121u:
					Form3.smethod_31((Control)(object)NullButton, "NullButton");
					Form3.smethod_32((Control)(object)NullButton, new Size(1, 1));
					num = (int)((num2 * 2031262479) ^ 0x3E360796);
					continue;
				case 120u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button7), 0);
					num = ((int)num2 * -479536957) ^ 0x5DE12BB6;
					continue;
				case 119u:
					Form3.smethod_32((Control)(object)button7, new Size(140, 50));
					num = ((int)num2 * -349149638) ^ -750242355;
					continue;
				case 118u:
					num = (int)((num2 * 1764096638) ^ 0x3EA3B6BC);
					continue;
				case 117u:
					Form3.smethod_33((Control)(object)label1, 7);
					num = ((int)num2 * -418065390) ^ 0x1531565B;
					continue;
				case 116u:
					Form3.smethod_33((Control)(object)textBox2, 8);
					num = ((int)num2 * -841620309) ^ 0x1B201059;
					continue;
				case 115u:
					num = ((int)num2 * -2048139759) ^ -1829099768;
					continue;
				case 114u:
					Form3.smethod_32((Control)(object)textBox2, new Size(140, 20));
					num = (int)(num2 * 1402966811) ^ -2119435443;
					continue;
				case 113u:
					num = ((int)num2 * -189079049) ^ 0x6D7D0E63;
					continue;
				case 112u:
					Form3.smethod_32((Control)(object)button1, new Size(49, 21));
					num = (int)((num2 * 902309392) ^ 0x1309D25B);
					continue;
				case 111u:
					Form3.smethod_34((ButtonBase)(object)button2, bool_0: true);
					num = ((int)num2 * -785412115) ^ -548631981;
					continue;
				case 110u:
					errorProvider1 = Form3.smethod_23(components);
					num = ((int)num2 * -1603031067) ^ -1940626104;
					continue;
				case 109u:
					num = ((int)num2 * -2007831532) ^ -757223072;
					continue;
				case 108u:
					Form3.smethod_44((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 936992146) ^ -1038816471;
					continue;
				case 107u:
					Form3.smethod_24((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -484686078) ^ 0x2F5632B3;
					continue;
				case 105u:
					Form3.smethod_31((Control)(object)button2, "button2");
					Form3.smethod_32((Control)(object)button2, new Size(85, 21));
					num = ((int)num2 * -700001596) ^ 0x56D14696;
					continue;
				case 104u:
					Form3.smethod_43((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -2104145176) ^ 0x406431AC;
					continue;
				case 103u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -537851135) ^ -1541822398;
					continue;
				case 102u:
					Form3.smethod_38((Control)(object)button4, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 210903671) ^ 0x44AFBCC3);
					continue;
				case 101u:
					Form3.smethod_38((Control)(object)label1, Form3.smethod_37("Mistral", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 1024119575) ^ -1911004509;
					continue;
				case 100u:
					Form3.smethod_34((ButtonBase)(object)button4, bool_0: true);
					num = ((int)num2 * -2031887058) ^ 0x727A2BC9;
					continue;
				case 99u:
					num = ((int)num2 * -1333765959) ^ 0x76F58679;
					continue;
				case 98u:
					Form3.smethod_30((Control)(object)button1, new Point(265, 49));
					num = (int)(num2 * 1467693323) ^ -1913888049;
					continue;
				case 97u:
					Form3.smethod_35((Control)(object)button7, "Достижения");
					Form3.smethod_34((ButtonBase)(object)button7, bool_0: true);
					num = (int)(num2 * 728884621) ^ -1490378331;
					continue;
				case 96u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)NullButton);
					num = (int)((num2 * 1876867803) ^ 0x18280839);
					continue;
				case 95u:
					Form3.smethod_31((Control)(object)textBox1, "textBox1");
					num = (int)((num2 * 700714992) ^ 0x6966983);
					continue;
				case 94u:
					Form3.smethod_32((Control)(object)button4, new Size(140, 50));
					num = (int)((num2 * 1579168378) ^ 0x3BA80194);
					continue;
				case 93u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button4);
					num = ((int)num2 * -1853401161) ^ -1079616671;
					continue;
				case 92u:
					Form3.smethod_14((Control)(object)button5, bool_0: false);
					num = (int)((num2 * 204663703) ^ 0x3AF70769);
					continue;
				case 91u:
					num = (int)(num2 * 1994315752) ^ -1589434373;
					continue;
				case 90u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)label1);
					num = (int)(num2 * 1912393445) ^ -558222694;
					continue;
				case 89u:
					num = (int)(num2 * 1247787789) ^ -284040422;
					continue;
				case 88u:
					num = ((int)num2 * -238822751) ^ -1083160151;
					continue;
				case 87u:
					num = ((int)num2 * -1867185436) ^ 0x46D36B65;
					continue;
				case 86u:
					Form3.smethod_45((Form)(object)this, new Size(486, 296));
					num = (int)(num2 * 800793511) ^ -1911354220;
					continue;
				case 85u:
					Form3.smethod_35((Control)(object)button1, "Вход");
					num = (int)(num2 * 253756845) ^ -845968464;
					continue;
				case 84u:
					Form3.smethod_36((Control)(object)button4, (EventHandler)Button4_Click);
					num = (int)(num2 * 1672153128) ^ -613913851;
					continue;
				case 83u:
					Form3.smethod_29((ButtonBase)(object)button4, (FlatStyle)0);
					num = (int)((num2 * 1217317530) ^ 0x65D3C7BB);
					continue;
				case 82u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox2);
					num = (int)((num2 * 735056513) ^ 0x532123B9);
					continue;
				case 81u:
					num = (int)(num2 * 1389522839) ^ -303586533;
					continue;
				case 80u:
					Form3.smethod_30((Control)(object)button2, new Point(174, 49));
					num = ((int)num2 * -1994125522) ^ -2113053742;
					continue;
				case 79u:
					Form3.smethod_38((Control)(object)button7, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1368580147) ^ 0xB69B315;
					continue;
				case 78u:
					Form3.smethod_33((Control)(object)button1, 0);
					num = (int)((num2 * 198695398) ^ 0xB008EA8);
					continue;
				case 77u:
					Form3.smethod_49((Form)(object)this, bool_0: false);
					num = ((int)num2 * -861110241) ^ 0x5684E66;
					continue;
				case 76u:
					Form3.smethod_42(errorProvider1, (ContainerControl)(object)this);
					num = (int)((num2 * 12640956) ^ 0x62E1B109);
					continue;
				case 75u:
					num = ((int)num2 * -2033137839) ^ -1197093492;
					continue;
				case 74u:
					Form3.smethod_31((Control)(object)button5, "button5");
					num = (int)((num2 * 1649762806) ^ 0x7463AE69);
					continue;
				case 73u:
					Form3.smethod_31((Control)(object)button7, "button7");
					num = ((int)num2 * -1527252338) ^ -2017224744;
					continue;
				case 72u:
					num = ((int)num2 * -645973953) ^ 0x5C41404C;
					continue;
				case 71u:
					num = (int)(num2 * 470250058) ^ -61551638;
					continue;
				case 70u:
					num = ((int)num2 * -1084904564) ^ 0x354709D9;
					continue;
				case 69u:
					Form3.smethod_39((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -795429369) ^ -72330823;
					continue;
				case 68u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button7);
					num = (int)(num2 * 953626372) ^ -1431816468;
					continue;
				case 67u:
					Form3.smethod_33((Control)(object)button2, 1);
					num = ((int)num2 * -819216565) ^ -2002786263;
					continue;
				case 66u:
					Form3.smethod_36((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -1949517350) ^ -1885945101;
					continue;
				case 65u:
					button5 = Form3.smethod_20();
					button7 = Form3.smethod_20();
					textBox1 = Form3.smethod_21();
					num = (int)(num2 * 1912245215) ^ -1557296546;
					continue;
				case 64u:
					Form3.smethod_57((Control)(object)this);
					num = ((int)num2 * -277953373) ^ 0x587A7139;
					continue;
				case 63u:
					Form3.smethod_39((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = (int)(num2 * 2137047997) ^ -589760030;
					continue;
				case 62u:
					Form3.smethod_36((Control)(object)button2, (EventHandler)Button2_Click);
					num = (int)((num2 * 1331090105) ^ 0xF1C7138);
					continue;
				case 61u:
					Form3.smethod_36((Control)(object)button5, (EventHandler)Button5_Click);
					num = (int)(num2 * 261664849) ^ -1510695288;
					continue;
				case 60u:
					Form3.smethod_38((Control)(object)button5, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form3.smethod_30((Control)(object)button5, new Point(174, 190));
					num = (int)(num2 * 1552839407) ^ -1750189421;
					continue;
				case 59u:
					Form3.smethod_34((ButtonBase)(object)button5, bool_0: true);
					num = ((int)num2 * -1301484959) ^ -1770081678;
					continue;
				case 58u:
					Form3.smethod_32((Control)(object)textBox1, new Size(140, 20));
					num = (int)(num2 * 1285808464) ^ -1505445413;
					continue;
				case 57u:
					Form3.smethod_30((Control)(object)textBox1, new Point(174, 2));
					num = ((int)num2 * -701665954) ^ -1138217304;
					continue;
				case 56u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)NullButton), 0);
					Form3.smethod_29((ButtonBase)(object)NullButton, (FlatStyle)0);
					Form3.smethod_30((Control)(object)NullButton, new Point(-1, -1));
					num = ((int)num2 * -1185481615) ^ 0x5EB04796;
					continue;
				case 55u:
					Form3.smethod_25((Control)(object)this);
					num = ((int)num2 * -681292702) ^ -1404280797;
					continue;
				case 54u:
					num = ((int)num2 * -1676888485) ^ 0x168C9269;
					continue;
				case 53u:
					Form3.smethod_33((Control)(object)button4, 4);
					num = ((int)num2 * -1917900384) ^ 0x4A1FD43B;
					continue;
				case 52u:
					num = (int)((num2 * 386136655) ^ 0x32880E8A);
					continue;
				case 51u:
					num = ((int)num2 * -760367839) ^ 0x600D0750;
					continue;
				case 50u:
					num = (int)(num2 * 613831733) ^ -171341218;
					continue;
				case 49u:
					Form3.smethod_33((Control)(object)NullButton, 3);
					num = ((int)num2 * -1100869446) ^ 0x5115FBF6;
					continue;
				case 48u:
					Form3.smethod_31((Control)(object)button1, "button1");
					num = (int)(num2 * 1441860754) ^ -840676460;
					continue;
				case 47u:
					num = ((int)num2 * -1101561731) ^ -1295253671;
					continue;
				case 46u:
					Form3.smethod_35((Control)(object)button2, "Регистрация");
					num = (int)((num2 * 185227733) ^ 0x40985E5D);
					continue;
				case 45u:
					Form3.smethod_30((Control)(object)button7, new Point(174, 243));
					num = ((int)num2 * -1504114905) ^ 0x617E2EF5;
					continue;
				case 44u:
					Form3.smethod_40((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -36130952) ^ -626757345;
					continue;
				case 43u:
					num = ((int)num2 * -1140471298) ^ -573770602;
					continue;
				case 42u:
					Form3.smethod_35((Control)(object)button4, "Начало игры");
					num = (int)((num2 * 158778474) ^ 0x77DAD94D);
					continue;
				case 41u:
					num = ((int)num2 * -1439521143) ^ 0x1A791817;
					continue;
				case 40u:
					num = ((int)num2 * -1022918063) ^ 0x3F3DC160;
					continue;
				case 39u:
					Form3.smethod_50((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1852291060) ^ -530828649;
					continue;
				case 38u:
					num = (int)((num2 * 419933180) ^ 0x38433D32);
					continue;
				case 37u:
					Form3.smethod_29((ButtonBase)(object)button7, (FlatStyle)0);
					num = ((int)num2 * -1076918238) ^ -1313831769;
					continue;
				case 36u:
					num = (int)(num2 * 1172598590) ^ -1840557740;
					continue;
				case 35u:
					Form3.smethod_26((Control)(object)NullButton, Color.Transparent);
					num = ((int)num2 * -646837530) ^ -956879977;
					continue;
				case 34u:
					num = ((int)num2 * -428583836) ^ 0x151DB07B;
					continue;
				case 33u:
					Form3.smethod_56((Control)(object)this, bool_0: false);
					num = (int)(num2 * 1965902744) ^ -800743733;
					continue;
				case 32u:
					num = (int)((num2 * 2065354000) ^ 0x560CD78B);
					continue;
				case 31u:
					Form3.smethod_26((Control)(object)this, Color.White);
					num = (int)((num2 * 1916702723) ^ 0x6F41F024);
					continue;
				case 30u:
					Form3.smethod_53((Form)(object)this, bool_0: false);
					Form3.smethod_54((Form)(object)this, bool_0: true);
					num = ((int)num2 * -2129565974) ^ -817383502;
					continue;
				case 29u:
					Form3.smethod_31((Control)(object)textBox2, "textBox2");
					num = (int)((num2 * 1319704467) ^ 0x27D234B0);
					continue;
				case 28u:
					num = (int)(num2 * 1440911340) ^ -1399986839;
					continue;
				case 26u:
					Form3.smethod_14((Control)(object)button4, bool_0: false);
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button4), 0);
					num = (int)(num2 * 1475816985) ^ -1714369474;
					continue;
				case 25u:
					components = Form3.smethod_19();
					num = (int)(num2 * 1080796154) ^ -563987228;
					continue;
				case 24u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button5);
					num = ((int)num2 * -684008852) ^ -498977329;
					continue;
				case 23u:
					Form3.smethod_26((Control)(object)label1, Color.Transparent);
					num = ((int)num2 * -736003860) ^ -1802775089;
					continue;
				case 22u:
					num = (int)((num2 * 1287077717) ^ 0x4352D938);
					continue;
				case 21u:
					Form3.smethod_34((ButtonBase)(object)NullButton, bool_0: false);
					num = ((int)num2 * -204121364) ^ -146046238;
					continue;
				case 20u:
					Form3.smethod_33((Control)(object)button7, 6);
					num = ((int)num2 * -1334305848) ^ 0x6F1AD7D2;
					continue;
				case 19u:
					Form3.smethod_48((Form)(object)this, (FormBorderStyle)0);
					num = (int)((num2 * 269808279) ^ 0x163CB0E3);
					continue;
				case 18u:
					Form3.smethod_55((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -1493178142) ^ -1765852251;
					continue;
				case 17u:
					num = ((int)num2 * -152936269) ^ 0x7EAB659E;
					continue;
				case 16u:
					num = ((int)num2 * -1145655201) ^ 0xA929C40;
					continue;
				case 15u:
					Form3.smethod_32((Control)(object)button5, new Size(140, 50));
					Form3.smethod_33((Control)(object)button5, 5);
					num = (int)(num2 * 1478493476) ^ -1601228232;
					continue;
				case 14u:
					Form3.smethod_32((Control)(object)label1, new Size(207, 76));
					num = (int)((num2 * 244901966) ^ 0x693AC2BF);
					continue;
				case 13u:
					Form3.smethod_30((Control)(object)label1, new Point(140, 70));
					Form3.smethod_31((Control)(object)label1, "label1");
					num = ((int)num2 * -412746933) ^ -1426186587;
					continue;
				case 12u:
					Form3.smethod_34((ButtonBase)(object)button1, bool_0: true);
					num = (int)(num2 * 456528483) ^ -1490085987;
					continue;
				case 11u:
					Form3.smethod_29((ButtonBase)(object)button5, (FlatStyle)0);
					num = ((int)num2 * -2103919902) ^ 0x5F55753F;
					continue;
				case 10u:
					Form3.smethod_41(textBox2, bool_0: true);
					num = ((int)num2 * -1006909841) ^ 0x21FDFFA0;
					continue;
				case 9u:
					num = ((int)num2 * -1079293429) ^ 0x3EEDE720;
					continue;
				case 8u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button5), 0);
					num = ((int)num2 * -1932567967) ^ 0x21B4C770;
					continue;
				case 7u:
					Form3.smethod_36((Control)(object)button7, (EventHandler)Button7_Click);
					num = (int)((num2 * 1741076447) ^ 0x749AB6F);
					continue;
				case 6u:
					Form3.smethod_33((Control)(object)textBox1, 7);
					num = ((int)num2 * -1601553923) ^ 0x2400CA27;
					continue;
				case 5u:
					Form3.smethod_30((Control)(object)button4, new Point(174, 137));
					num = (int)((num2 * 1881375070) ^ 0x7513F266);
					continue;
				case 4u:
					Form3.smethod_52((Form)(object)this, bool_0: false);
					num = (int)((num2 * 2093471681) ^ 0x15365FB3);
					continue;
				case 3u:
					Form3.smethod_31((Control)(object)button4, "button4");
					num = (int)(num2 * 1284615863) ^ -1337223614;
					continue;
				case 2u:
					Form3.smethod_51((Control)(object)this, "Form3");
					num = ((int)num2 * -2095288649) ^ -1022939481;
					continue;
				case 1u:
					Form3.smethod_30((Control)(object)textBox2, new Point(174, 26));
					num = (int)((num2 * 1727838236) ^ 0xBFF8B75);
					continue;
				case 0u:
					NullButton = Form3.smethod_20();
					button1 = Form3.smethod_20();
					button2 = Form3.smethod_20();
					button4 = Form3.smethod_20();
					num = (int)(num2 * 1949036591) ^ -986436074;
					continue;
				default:
					return;
				case 106u:
					break;
				case 27u:
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
