using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Hospital_Management_System;

[DesignerGenerated]
public class SearchPatient : UserControl
{
	private IContainer components;

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button1")]
	internal virtual Button Button1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox2")]
	internal virtual TextBox TextBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridView1")]
	internal virtual DataGridView DataGridView1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox2")]
	internal virtual GroupBox GroupBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox8")]
	internal virtual TextBox TextBox8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox7")]
	internal virtual TextBox TextBox7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox6")]
	internal virtual TextBox TextBox6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox5")]
	internal virtual TextBox TextBox5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox4")]
	internal virtual TextBox TextBox4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox3")]
	internal virtual TextBox TextBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label7")]
	internal virtual Label Label7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button2")]
	internal virtual Button Button2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button3")]
	internal virtual Button Button3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button4")]
	internal virtual Button Button4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public SearchPatient()
	{
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			while (true)
			{
				int num = -611541347;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0xCC1EFEC6u) % 6u)
					{
					case 5u:
						if (disposing)
						{
							num = ((int)num2 * -739427524) ^ -137956580;
							continue;
						}
						goto IL_001c;
					case 4u:
						SearchPatient.smethod_0((IDisposable)components);
						num = ((int)num2 * -189332308) ^ -1993942950;
						continue;
					case 2u:
						num = (int)(num2 * 397770133) ^ -1365677241;
						continue;
					case 0u:
						if (components != null)
						{
							num = -1839412540;
							num3 = -1839412540;
							continue;
						}
						goto IL_001c;
					default:
						return;
					case 3u:
						break;
					case 1u:
						return;
						IL_001c:
						num = -1572758957;
						num3 = -1572758957;
						continue;
					}
					break;
				}
			}
		}
		finally
		{
			while (true)
			{
				IL_00cf:
				int num4 = -145988992;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num4 ^ 0xCC1EFEC6u) % 3u)
					{
					case 1u:
						goto IL_009e;
					default:
						goto end_IL_00b2;
					case 2u:
						break;
					case 0u:
						goto end_IL_00b2;
					}
					goto IL_00cf;
					IL_009e:
					((ContainerControl)this).Dispose(disposing);
					num4 = (int)((num2 * 1690683265) ^ 0x52896CD9);
					continue;
					end_IL_00b2:
					break;
				}
				break;
			}
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		while (true)
		{
			int num = -1079368853;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9285C13Au) % 258u)
				{
				case 257u:
					SearchPatient.smethod_25((ButtonBase)(object)Button3, "Clear");
					SearchPatient.smethod_26((ButtonBase)(object)Button3, bool_0: true);
					num = ((int)num2 * -201421601) ^ 0x7C87E37C;
					continue;
				case 256u:
					SearchPatient.smethod_11((Control)(object)TextBox3, "TextBox3");
					num = ((int)num2 * -95594537) ^ 0x1027B752;
					continue;
				case 255u:
					num = ((int)num2 * -536889037) ^ -740235785;
					continue;
				case 254u:
					SearchPatient.smethod_7((ISupportInitialize)DataGridView1);
					num = (int)(num2 * 602137241) ^ -1105345968;
					continue;
				case 253u:
					num = (int)((num2 * 2140926773) ^ 0x9EF7941);
					continue;
				case 252u:
					Label8 = SearchPatient.smethod_2();
					num = ((int)num2 * -365861907) ^ -181482281;
					continue;
				case 251u:
					SearchPatient.smethod_12((Control)(object)Label6, new Size(84, 26));
					num = ((int)num2 * -670355532) ^ -379196476;
					continue;
				case 250u:
					num = ((int)num2 * -1695268559) ^ -437233209;
					continue;
				case 249u:
					SearchPatient.smethod_10((Control)(object)DataGridView1, new Point(59, 295));
					num = (int)((num2 * 1453070644) ^ 0x63D3E211);
					continue;
				case 248u:
					SearchPatient.smethod_12((Control)(object)Button4, new Size(133, 37));
					num = ((int)num2 * -1991002017) ^ 0x90999B9;
					continue;
				case 247u:
					num = (int)((num2 * 1173245240) ^ 0x1039DF7D);
					continue;
				case 246u:
					SearchPatient.smethod_20(Label2, (ContentAlignment)32);
					num = (int)((num2 * 2033293743) ^ 0x764E0D35);
					continue;
				case 245u:
					num = ((int)num2 * -151058273) ^ 0x4FB3DB2E;
					continue;
				case 244u:
					num = (int)(num2 * 1792830360) ^ -89446562;
					continue;
				case 243u:
					num = ((int)num2 * -742255216) ^ -494500100;
					continue;
				case 242u:
					SearchPatient.smethod_22(SearchPatient.smethod_34((Control)(object)this), (Control)(object)GroupBox2);
					num = ((int)num2 * -1372758288) ^ -622919364;
					continue;
				case 241u:
					SearchPatient.smethod_10((Control)(object)Label2, new Point(37, 44));
					SearchPatient.smethod_11((Control)(object)Label2, "Label2");
					num = ((int)num2 * -1979937962) ^ 0x524F0996;
					continue;
				case 240u:
					num = (int)(num2 * 1763903068) ^ -437663008;
					continue;
				case 239u:
					SearchPatient.smethod_19(Label5, "Age :");
					SearchPatient.smethod_17((Control)(object)Label4, SearchPatient.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 522770011) ^ 0x75AE6DF2);
					continue;
				case 238u:
					SearchPatient.smethod_20(Label1, (ContentAlignment)32);
					num = ((int)num2 * -635097255) ^ -1720240238;
					continue;
				case 237u:
					SearchPatient.smethod_22(SearchPatient.smethod_21((Control)(object)GroupBox2), (Control)(object)TextBox4);
					SearchPatient.smethod_22(SearchPatient.smethod_21((Control)(object)GroupBox2), (Control)(object)TextBox3);
					num = ((int)num2 * -312488564) ^ -149022412;
					continue;
				case 236u:
					num = (int)(num2 * 1714346831) ^ -1030290199;
					continue;
				case 235u:
					SearchPatient.smethod_18((Control)(object)TextBox1, 1);
					SearchPatient.smethod_17((Control)(object)Label2, SearchPatient.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1906200070) ^ -796597395;
					continue;
				case 234u:
					SearchPatient.smethod_11((Control)(object)TextBox5, "TextBox5");
					num = ((int)num2 * -1938198156) ^ 0x3280AC22;
					continue;
				case 233u:
					SearchPatient.smethod_22(SearchPatient.smethod_34((Control)(object)this), (Control)(object)GroupBox1);
					num = (int)((num2 * 1895027837) ^ 0xC476FC5);
					continue;
				case 232u:
					SearchPatient.smethod_12((Control)(object)Label2, new Size(77, 28));
					SearchPatient.smethod_18((Control)(object)Label2, 0);
					num = (int)(num2 * 868592672) ^ -1494772894;
					continue;
				case 231u:
					PictureBox1 = SearchPatient.smethod_1();
					num = (int)((num2 * 1266940407) ^ 0x138C841F);
					continue;
				case 230u:
					SearchPatient.smethod_23(GroupBox1, bool_0: false);
					num = (int)((num2 * 1030026926) ^ 0x5E166FC4);
					continue;
				case 229u:
					SearchPatient.smethod_17((Control)(object)Button4, SearchPatient.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1505409610) ^ -268090504;
					continue;
				case 228u:
					SearchPatient.smethod_18((Control)(object)Label7, 3);
					num = (int)(num2 * 736762877) ^ -1085348772;
					continue;
				case 227u:
					num = (int)((num2 * 508145547) ^ 0x38DB6DE9);
					continue;
				case 226u:
					num = ((int)num2 * -1216528412) ^ -1947111411;
					continue;
				case 225u:
					num = ((int)num2 * -571418380) ^ -103593009;
					continue;
				case 224u:
					SearchPatient.smethod_22(SearchPatient.smethod_34((Control)(object)this), (Control)(object)Button2);
					num = ((int)num2 * -380784133) ^ 0x25F95F80;
					continue;
				case 223u:
					Button3 = SearchPatient.smethod_4();
					num = (int)((num2 * 1619812783) ^ 0x682934B8);
					continue;
				case 222u:
					SearchPatient.smethod_11((Control)(object)Label8, "Label8");
					num = ((int)num2 * -1606439911) ^ 0x292BBBA6;
					continue;
				case 221u:
					SearchPatient.smethod_31(TextBox6, bool_0: true);
					num = ((int)num2 * -2014142003) ^ 0x70336C3E;
					continue;
				case 220u:
					SearchPatient.smethod_20(Label8, (ContentAlignment)32);
					num = (int)(num2 * 1023253011) ^ -1409583881;
					continue;
				case 219u:
					num = ((int)num2 * -979430579) ^ -1798151927;
					continue;
				case 218u:
					SearchPatient.smethod_19(Label2, "Name : ");
					num = (int)((num2 * 1385002198) ^ 0x202B3F60);
					continue;
				case 217u:
					num = ((int)num2 * -1745297555) ^ -571533072;
					continue;
				case 216u:
					SearchPatient.smethod_17((Control)(object)Label5, SearchPatient.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1688440804) ^ 0x14D0126F;
					continue;
				case 215u:
					SearchPatient.smethod_10((Control)(object)Button4, new Point(779, 612));
					num = (int)(num2 * 790165898) ^ -1938324977;
					continue;
				case 214u:
					SearchPatient.smethod_10((Control)(object)Label3, new Point(37, 87));
					num = (int)((num2 * 854363162) ^ 0x65B62ADE);
					continue;
				case 213u:
					SearchPatient.smethod_10((Control)(object)Label6, new Point(414, 131));
					SearchPatient.smethod_11((Control)(object)Label6, "Label6");
					num = ((int)num2 * -1380338585) ^ -1073269990;
					continue;
				case 212u:
					SearchPatient.smethod_17((Control)(object)Label6, SearchPatient.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -109097868) ^ -1625595437;
					continue;
				case 211u:
					SearchPatient.smethod_11((Control)(object)Button4, "Button4");
					num = ((int)num2 * -367139272) ^ 0x33EBA70A;
					continue;
				case 210u:
					num = ((int)num2 * -1718489432) ^ 0x18050032;
					continue;
				case 209u:
					SearchPatient.smethod_12((Control)(object)TextBox5, new Size(100, 28));
					num = (int)((num2 * 1919804203) ^ 0x738B3903);
					continue;
				case 208u:
					TextBox2 = SearchPatient.smethod_5();
					num = (int)(num2 * 407982215) ^ -1622173729;
					continue;
				case 206u:
					SearchPatient.smethod_22(SearchPatient.smethod_34((Control)(object)this), (Control)(object)Button3);
					num = ((int)num2 * -1193911105) ^ 0xB2048F0;
					continue;
				case 205u:
					SearchPatient.smethod_23(GroupBox2, bool_0: false);
					num = ((int)num2 * -1945994130) ^ 0x4134D425;
					continue;
				case 204u:
					SearchPatient.smethod_20(Label3, (ContentAlignment)32);
					SearchPatient.smethod_10((Control)(object)TextBox2, new Point(120, 94));
					num = ((int)num2 * -2115100313) ^ -1504043819;
					continue;
				case 203u:
					num = ((int)num2 * -467396087) ^ -932583678;
					continue;
				case 202u:
					num = ((int)num2 * -355724488) ^ 0x55C17613;
					continue;
				case 201u:
					Label5 = SearchPatient.smethod_2();
					num = (int)((num2 * 1704616778) ^ 0x2B6F3CAD);
					continue;
				case 200u:
					num = ((int)num2 * -1700029896) ^ -978896483;
					continue;
				case 199u:
					Button2 = SearchPatient.smethod_4();
					num = (int)(num2 * 340176660) ^ -824847617;
					continue;
				case 198u:
					num = (int)((num2 * 250545637) ^ 0x5E49ECDF);
					continue;
				case 197u:
					num = (int)((num2 * 673437268) ^ 0xB2B7EA6);
					continue;
				case 196u:
					num = (int)((num2 * 1226430607) ^ 0x79191FEC);
					continue;
				case 195u:
					SearchPatient.smethod_18((Control)(object)TextBox4, 5);
					num = ((int)num2 * -418461257) ^ 0x63CCDAA4;
					continue;
				case 194u:
					Label1 = SearchPatient.smethod_2();
					GroupBox1 = SearchPatient.smethod_3();
					Button1 = SearchPatient.smethod_4();
					num = ((int)num2 * -1944250585) ^ -550198830;
					continue;
				case 193u:
					SearchPatient.smethod_19(Label1, "Search Patient");
					num = (int)(num2 * 215652717) ^ -312970013;
					continue;
				case 192u:
					SearchPatient.smethod_38((Control)(object)GroupBox1, bool_0: false);
					num = ((int)num2 * -1426733999) ^ 0x2F1C63F7;
					continue;
				case 191u:
					num = ((int)num2 * -1083005844) ^ 0xCCFD13B;
					continue;
				case 190u:
					num = (int)(num2 * 2008688564) ^ -804599310;
					continue;
				case 189u:
					SearchPatient.smethod_26((ButtonBase)(object)Button1, bool_0: true);
					SearchPatient.smethod_17((Control)(object)Label3, SearchPatient.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1454470475) ^ 0x236F4944;
					continue;
				case 188u:
					SearchPatient.smethod_11((Control)(object)TextBox1, "TextBox1");
					num = (int)(num2 * 1656011625) ^ -298192553;
					continue;
				case 187u:
					SearchPatient.smethod_37((ISupportInitialize)DataGridView1);
					SearchPatient.smethod_38((Control)(object)GroupBox2, bool_0: false);
					num = (int)(num2 * 2039405566) ^ -885134299;
					continue;
				case 186u:
					num = ((int)num2 * -233995617) ^ 0x31CB78E7;
					continue;
				case 185u:
					SearchPatient.smethod_18((Control)(object)Button3, 15);
					num = ((int)num2 * -737186687) ^ 0x11FAE7A4;
					continue;
				case 184u:
					SearchPatient.smethod_18((Control)(object)TextBox6, 7);
					SearchPatient.smethod_10((Control)(object)TextBox5, new Point(504, 125));
					num = (int)(num2 * 1535407404) ^ -1562948308;
					continue;
				case 183u:
					SearchPatient.smethod_11((Control)(object)TextBox6, "TextBox6");
					num = (int)(num2 * 1902394132) ^ -1447726011;
					continue;
				case 182u:
					num = (int)((num2 * 1309045517) ^ 0x323C8F18);
					continue;
				case 181u:
					num = ((int)num2 * -262689944) ^ -1609381569;
					continue;
				case 180u:
					SearchPatient.smethod_11((Control)(object)Label3, "Label3");
					SearchPatient.smethod_12((Control)(object)Label3, new Size(77, 28));
					num = (int)((num2 * 1569410099) ^ 0x6198DC98);
					continue;
				case 179u:
					SearchPatient.smethod_10((Control)(object)TextBox1, new Point(120, 44));
					num = ((int)num2 * -1376459539) ^ 0x3CD6F3A3;
					continue;
				case 178u:
					num = (int)((num2 * 1562941804) ^ 0x5A85F044);
					continue;
				case 177u:
					num = ((int)num2 * -964680778) ^ -1394899288;
					continue;
				case 176u:
					SearchPatient.smethod_10((Control)(object)GroupBox2, new Point(108, 480));
					num = ((int)num2 * -1872432135) ^ 0x41B5E354;
					continue;
				case 175u:
					num = (int)((num2 * 1720532229) ^ 0xC4F54AE);
					continue;
				case 174u:
					SearchPatient.smethod_10((Control)(object)PictureBox1, new Point(295, 43));
					SearchPatient.smethod_11((Control)(object)PictureBox1, "PictureBox1");
					SearchPatient.smethod_12((Control)(object)PictureBox1, new Size(91, 82));
					num = (int)(num2 * 474209983) ^ -1419489692;
					continue;
				case 173u:
					SearchPatient.smethod_10((Control)(object)Label5, new Point(417, 94));
					SearchPatient.smethod_11((Control)(object)Label5, "Label5");
					num = ((int)num2 * -2120762889) ^ 0x396350E2;
					continue;
				case 172u:
					num = (int)((num2 * 2053458680) ^ 0x4C6300A1);
					continue;
				case 171u:
					num = (int)((num2 * 77680454) ^ 0x474E298B);
					continue;
				case 170u:
					SearchPatient.smethod_22(SearchPatient.smethod_21((Control)(object)GroupBox2), (Control)(object)Label8);
					num = ((int)num2 * -820555225) ^ 0xD415A67;
					continue;
				case 169u:
					SearchPatient.smethod_18((Control)(object)Button2, 14);
					num = ((int)num2 * -1007586165) ^ -809245695;
					continue;
				case 168u:
					num = (int)((num2 * 1432635615) ^ 0xE8AABA2);
					continue;
				case 167u:
					SearchPatient.smethod_22(SearchPatient.smethod_21((Control)(object)GroupBox1), (Control)(object)TextBox2);
					num = ((int)num2 * -1600988742) ^ 0x6745A1E1;
					continue;
				case 166u:
					SearchPatient.smethod_22(SearchPatient.smethod_34((Control)(object)this), (Control)(object)Label1);
					SearchPatient.smethod_22(SearchPatient.smethod_34((Control)(object)this), (Control)(object)PictureBox1);
					num = ((int)num2 * -2071936405) ^ 0x1FCD34C9;
					continue;
				case 165u:
					num = ((int)num2 * -366834636) ^ -2068658208;
					continue;
				case 164u:
					TextBox8 = SearchPatient.smethod_5();
					num = (int)(num2 * 688551737) ^ -351575265;
					continue;
				case 163u:
					num = ((int)num2 * -956565984) ^ 0x43380436;
					continue;
				case 162u:
					SearchPatient.smethod_22(SearchPatient.smethod_21((Control)(object)GroupBox1), (Control)(object)Button1);
					num = ((int)num2 * -501705749) ^ -279003148;
					continue;
				case 161u:
					num = ((int)num2 * -1920737235) ^ -1519728856;
					continue;
				case 160u:
					num = ((int)num2 * -888046411) ^ -1994526912;
					continue;
				case 159u:
					SearchPatient.smethod_15(PictureBox1, bool_0: false);
					SearchPatient.smethod_17((Control)(object)Label1, SearchPatient.smethod_16("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1953211867) ^ 0x2C8D214);
					continue;
				case 158u:
					num = (int)((num2 * 819417713) ^ 0x2787035B);
					continue;
				case 157u:
					num = ((int)num2 * -127733679) ^ -273308071;
					continue;
				case 156u:
					SearchPatient.smethod_7((ISupportInitialize)PictureBox1);
					num = ((int)num2 * -1288168571) ^ 0x3B5B8425;
					continue;
				case 155u:
					num = (int)((num2 * 829394611) ^ 0x6B5FB646);
					continue;
				case 154u:
					SearchPatient.smethod_18((Control)(object)TextBox8, 12);
					num = ((int)num2 * -1898440935) ^ -585407021;
					continue;
				case 153u:
					SearchPatient.smethod_18((Control)(object)TextBox7, 10);
					SearchPatient.smethod_17((Control)(object)Label8, SearchPatient.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 281627010) ^ 0x25EC19FE);
					continue;
				case 152u:
					SearchPatient.smethod_12((Control)(object)TextBox4, new Size(100, 28));
					num = ((int)num2 * -26683108) ^ -1052328461;
					continue;
				case 151u:
					num = (int)(num2 * 1791685252) ^ -233135364;
					continue;
				case 150u:
					num = ((int)num2 * -909721108) ^ 0x15627B65;
					continue;
				case 149u:
					SearchPatient.smethod_12((Control)(object)Button2, new Size(133, 37));
					num = (int)(num2 * 1734771793) ^ -1353845772;
					continue;
				case 148u:
					SearchPatient.smethod_30((TextBoxBase)(object)TextBox3, bool_0: true);
					num = ((int)num2 * -684747308) ^ -2105149874;
					continue;
				case 147u:
					SearchPatient.smethod_19(Label3, "Phone : ");
					num = ((int)num2 * -2122068823) ^ 0x31E7C846;
					continue;
				case 146u:
					SearchPatient.smethod_19(Label8, "Name : ");
					num = (int)((num2 * 936039234) ^ 0x3227B106);
					continue;
				case 145u:
					SearchPatient.smethod_12((Control)(object)GroupBox2, new Size(623, 292));
					num = (int)((num2 * 1324855745) ^ 0x22C873EB);
					continue;
				case 144u:
					SearchPatient.smethod_11((Control)(object)Label4, "Label4");
					num = (int)(num2 * 1992876792) ^ -375338550;
					continue;
				case 143u:
					num = ((int)num2 * -1360622592) ^ -1004994374;
					continue;
				case 142u:
					TextBox7 = SearchPatient.smethod_5();
					num = (int)((num2 * 1364710398) ^ 0x53DFE6FE);
					continue;
				case 141u:
					SearchPatient.smethod_12((Control)(object)Label5, new Size(68, 26));
					num = ((int)num2 * -611461091) ^ -754197815;
					continue;
				case 140u:
					SearchPatient.smethod_8((Control)(object)GroupBox2);
					num = (int)(num2 * 996105773) ^ -1534185961;
					continue;
				case 139u:
					TextBox5 = SearchPatient.smethod_5();
					num = ((int)num2 * -866607677) ^ 0x72C2D418;
					continue;
				case 138u:
					num = ((int)num2 * -88276920) ^ 0x2E033679;
					continue;
				case 137u:
					num = ((int)num2 * -1459457446) ^ -523000624;
					continue;
				case 136u:
					SearchPatient.smethod_17((Control)(object)Label7, SearchPatient.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1891647872) ^ 0x6936E19B;
					continue;
				case 135u:
					SearchPatient.smethod_12((Control)(object)Button1, new Size(133, 37));
					num = ((int)num2 * -443103654) ^ 0x443D776D;
					continue;
				case 134u:
					TextBox1 = SearchPatient.smethod_5();
					Label2 = SearchPatient.smethod_2();
					num = ((int)num2 * -464236099) ^ -2060788541;
					continue;
				case 133u:
					SearchPatient.smethod_12((Control)(object)Label8, new Size(77, 28));
					num = ((int)num2 * -1391269563) ^ 0x404F3941;
					continue;
				case 132u:
					SearchPatient.smethod_10((Control)(object)GroupBox1, new Point(155, 150));
					num = (int)((num2 * 1050103255) ^ 0x65CA5F0D);
					continue;
				case 131u:
					SearchPatient.smethod_27(DataGridView1, (DataGridViewColumnHeadersHeightSizeMode)2);
					num = ((int)num2 * -1823757200) ^ 0x5ED6CB5F;
					continue;
				case 130u:
					SearchPatient.smethod_32((ContainerControl)(object)this, new SizeF(8f, 16f));
					SearchPatient.smethod_33((ContainerControl)(object)this, (AutoScaleMode)1);
					SearchPatient.smethod_22(SearchPatient.smethod_34((Control)(object)this), (Control)(object)Button4);
					num = ((int)num2 * -1200299206) ^ -1153779788;
					continue;
				case 129u:
					SearchPatient.smethod_18((Control)(object)Label1, 10);
					num = ((int)num2 * -434763712) ^ 0x66AD89E8;
					continue;
				case 128u:
					SearchPatient.smethod_22(SearchPatient.smethod_21((Control)(object)GroupBox2), (Control)(object)TextBox5);
					num = ((int)num2 * -1128342447) ^ -910050699;
					continue;
				case 127u:
					TextBox4 = SearchPatient.smethod_5();
					TextBox3 = SearchPatient.smethod_5();
					num = (int)((num2 * 146752196) ^ 0x4E496730);
					continue;
				case 126u:
					SearchPatient.smethod_22(SearchPatient.smethod_21((Control)(object)GroupBox2), (Control)(object)Label7);
					SearchPatient.smethod_22(SearchPatient.smethod_21((Control)(object)GroupBox2), (Control)(object)Label6);
					num = (int)(num2 * 1298484342) ^ -646717841;
					continue;
				case 125u:
					num = (int)(num2 * 929931602) ^ -2100634373;
					continue;
				case 124u:
					SearchPatient.smethod_18((Control)(object)GroupBox2, 13);
					num = ((int)num2 * -1506915692) ^ 0x67E340AA;
					continue;
				case 123u:
					TextBox6 = SearchPatient.smethod_5();
					num = (int)((num2 * 1694809437) ^ 0x2C8C51EA);
					continue;
				case 122u:
					num = (int)(num2 * 615996756) ^ -1698711942;
					continue;
				case 121u:
					SearchPatient.smethod_22(SearchPatient.smethod_21((Control)(object)GroupBox2), (Control)(object)TextBox6);
					num = ((int)num2 * -1184885814) ^ -177382782;
					continue;
				case 120u:
					SearchPatient.smethod_18((Control)(object)Label6, 2);
					num = (int)((num2 * 1233511510) ^ 0x2EAA1F13);
					continue;
				case 119u:
					SearchPatient.smethod_39((Control)(object)GroupBox1);
					num = ((int)num2 * -1044399920) ^ 0x77998127;
					continue;
				case 118u:
					SearchPatient.smethod_10((Control)(object)Label4, new Point(20, 46));
					num = ((int)num2 * -836599647) ^ 0x3B100572;
					continue;
				case 117u:
					SearchPatient.smethod_12((Control)(object)TextBox1, new Size(237, 28));
					num = (int)((num2 * 44718371) ^ 0x2437A59C);
					continue;
				case 116u:
					SearchPatient.smethod_30((TextBoxBase)(object)TextBox7, bool_0: true);
					num = ((int)num2 * -1534293425) ^ 0x719EAB2F;
					continue;
				case 115u:
					num = ((int)num2 * -1624534494) ^ -873645033;
					continue;
				case 114u:
					SearchPatient.smethod_12((Control)(object)GroupBox1, new Size(623, 128));
					SearchPatient.smethod_18((Control)(object)GroupBox1, 11);
					num = (int)(num2 * 605442186) ^ -842010574;
					continue;
				case 113u:
					SearchPatient.smethod_18((Control)(object)Label3, 3);
					num = ((int)num2 * -119080750) ^ -2067257463;
					continue;
				case 112u:
					num = ((int)num2 * -1690058463) ^ 0x1B33C516;
					continue;
				case 111u:
					SearchPatient.smethod_17((Control)(object)Label9, SearchPatient.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1284349711) ^ -1083960938;
					continue;
				case 110u:
					SearchPatient.smethod_18((Control)(object)Label5, 1);
					num = ((int)num2 * -847104809) ^ -1606203149;
					continue;
				case 109u:
					SearchPatient.smethod_10((Control)(object)TextBox6, new Point(124, 182));
					num = (int)((num2 * 496474525) ^ 0x1BC5CEAC);
					continue;
				case 108u:
					SearchPatient.smethod_13(PictureBox1, (PictureBoxSizeMode)1);
					num = ((int)num2 * -2079466958) ^ 0x3B438FB4;
					continue;
				case 107u:
					num = ((int)num2 * -1978672377) ^ -648486730;
					continue;
				case 106u:
					SearchPatient.smethod_25((ButtonBase)(object)Button4, "Delete");
					num = (int)((num2 * 844835430) ^ 0x41138C6C);
					continue;
				case 105u:
					SearchPatient.smethod_11((Control)(object)Button2, "Button2");
					num = ((int)num2 * -1577909282) ^ 0x46F895F9;
					continue;
				case 104u:
					SearchPatient.smethod_12((Control)(object)TextBox3, new Size(100, 28));
					num = ((int)num2 * -1840920728) ^ -653875211;
					continue;
				case 103u:
					SearchPatient.smethod_11((Control)(object)DataGridView1, "DataGridView1");
					num = ((int)num2 * -1089059253) ^ 0x5C33C725;
					continue;
				case 102u:
					num = ((int)num2 * -1503306003) ^ -754572007;
					continue;
				case 101u:
					num = (int)(num2 * 463057299) ^ -884290974;
					continue;
				case 100u:
					num = (int)((num2 * 1414083488) ^ 0x54DAE26C);
					continue;
				case 99u:
					SearchPatient.smethod_10((Control)(object)Label7, new Point(20, 182));
					num = (int)(num2 * 2017251212) ^ -471122867;
					continue;
				case 98u:
					num = ((int)num2 * -1470830618) ^ -1468706244;
					continue;
				case 97u:
					num = ((int)num2 * -1738763100) ^ -639584735;
					continue;
				case 96u:
					SearchPatient.smethod_12((Control)(object)Label1, new Size(330, 47));
					num = ((int)num2 * -1043698498) ^ 0x5A2FBE8E;
					continue;
				case 95u:
					SearchPatient.smethod_12((Control)(object)Label9, new Size(77, 28));
					num = (int)((num2 * 965576900) ^ 0x69FD3853);
					continue;
				case 94u:
					num = (int)((num2 * 887756458) ^ 0xD63477);
					continue;
				case 93u:
					Button4 = SearchPatient.smethod_4();
					num = ((int)num2 * -1617266828) ^ -172148016;
					continue;
				case 92u:
					Label6 = SearchPatient.smethod_2();
					num = (int)(num2 * 436367783) ^ -957943986;
					continue;
				case 91u:
					DataGridView1 = SearchPatient.smethod_6();
					num = ((int)num2 * -1784787512) ^ 0x2504DB7D;
					continue;
				case 90u:
					SearchPatient.smethod_12((Control)(object)TextBox2, new Size(237, 28));
					num = ((int)num2 * -1457756961) ^ -447739441;
					continue;
				case 89u:
					SearchPatient.smethod_22(SearchPatient.smethod_21((Control)(object)GroupBox2), (Control)(object)Label5);
					num = ((int)num2 * -50874484) ^ 0x1DA99AA7;
					continue;
				case 88u:
					SearchPatient.smethod_22(SearchPatient.smethod_21((Control)(object)GroupBox1), (Control)(object)Label3);
					num = ((int)num2 * -1830384599) ^ -188900919;
					continue;
				case 87u:
					SearchPatient.smethod_18((Control)(object)TextBox2, 2);
					num = (int)((num2 * 1901598531) ^ 0x40EA2381);
					continue;
				case 86u:
					SearchPatient.smethod_26((ButtonBase)(object)Button4, bool_0: true);
					num = (int)(num2 * 367840847) ^ -2133439666;
					continue;
				case 85u:
					GroupBox2 = SearchPatient.smethod_3();
					num = ((int)num2 * -237359309) ^ -1873743335;
					continue;
				case 84u:
					Label7 = SearchPatient.smethod_2();
					num = (int)((num2 * 1816705621) ^ 0x597032B);
					continue;
				case 83u:
					SearchPatient.smethod_18((Control)(object)Button1, 4);
					num = ((int)num2 * -183660788) ^ 0x13A34D50;
					continue;
				case 82u:
					SearchPatient.smethod_22(SearchPatient.smethod_21((Control)(object)GroupBox1), (Control)(object)Label2);
					SearchPatient.smethod_17((Control)(object)GroupBox1, SearchPatient.smethod_16("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1187050368) ^ 0x26A63BA6;
					continue;
				case 81u:
					num = ((int)num2 * -1360502875) ^ -1078261178;
					continue;
				case 80u:
					SearchPatient.smethod_18((Control)(object)Label8, 9);
					num = ((int)num2 * -1489885530) ^ 0x476337A0;
					continue;
				case 79u:
					num = ((int)num2 * -502449778) ^ -539142642;
					continue;
				case 78u:
					SearchPatient.smethod_22(SearchPatient.smethod_21((Control)(object)GroupBox1), (Control)(object)TextBox1);
					num = (int)((num2 * 1929765124) ^ 0x5BFE4818);
					continue;
				case 77u:
					SearchPatient.smethod_12((Control)(object)DataGridView1, new Size(853, 169));
					num = ((int)num2 * -615906859) ^ -585816263;
					continue;
				case 76u:
					SearchPatient.smethod_18((Control)(object)Label4, 0);
					num = (int)(num2 * 1235697827) ^ -1086446734;
					continue;
				case 75u:
					SearchPatient.smethod_24(GroupBox2, "Patient Information");
					num = (int)((num2 * 1944728144) ^ 0x103BB54C);
					continue;
				case 74u:
					SearchPatient.smethod_11((Control)(object)Label9, "Label9");
					num = ((int)num2 * -1361137725) ^ -459558839;
					continue;
				case 73u:
					num = ((int)num2 * -2074051648) ^ -1585794276;
					continue;
				case 72u:
					num = ((int)num2 * -2135248267) ^ -1043537157;
					continue;
				case 71u:
					SearchPatient.smethod_20(Label9, (ContentAlignment)32);
					SearchPatient.smethod_10((Control)(object)TextBox7, new Point(124, 92));
					num = (int)(num2 * 1784615606) ^ -840342647;
					continue;
				case 70u:
					num = ((int)num2 * -177503078) ^ -1709536872;
					continue;
				case 69u:
					num = ((int)num2 * -1232806348) ^ 0x4E7B39BB;
					continue;
				case 68u:
					SearchPatient.smethod_10((Control)(object)Button3, new Point(779, 697));
					num = (int)((num2 * 904172502) ^ 0x16E3AD6F);
					continue;
				case 67u:
					Label9 = SearchPatient.smethod_2();
					num = ((int)num2 * -661202353) ^ -704264880;
					continue;
				case 66u:
					SearchPatient.smethod_19(Label4, "PID :");
					num = (int)((num2 * 728791508) ^ 0x5D27E216);
					continue;
				case 65u:
					num = (int)(num2 * 395700168) ^ -822350513;
					continue;
				case 64u:
					SearchPatient.smethod_24(GroupBox1, "Search Patient");
					num = ((int)num2 * -1362115887) ^ 0x77A4C160;
					continue;
				case 63u:
					num = ((int)num2 * -359401701) ^ 0x36A9875F;
					continue;
				case 62u:
					SearchPatient.smethod_30((TextBoxBase)(object)TextBox5, bool_0: true);
					num = (int)((num2 * 381989293) ^ 0x57DDF0B0);
					continue;
				case 61u:
					SearchPatient.smethod_11((Control)(object)Label7, "Label7");
					SearchPatient.smethod_12((Control)(object)Label7, new Size(98, 26));
					num = (int)(num2 * 1547180190) ^ -1092674980;
					continue;
				case 60u:
					num = ((int)num2 * -444749149) ^ -245058363;
					continue;
				case 59u:
					SearchPatient.smethod_18((Control)(object)Button4, 16);
					num = ((int)num2 * -245427176) ^ 0x55BC98E4;
					continue;
				case 58u:
					SearchPatient.smethod_11((Control)(object)Button1, "Button1");
					num = (int)((num2 * 192528447) ^ 0x25CA2459);
					continue;
				case 57u:
					SearchPatient.smethod_11((Control)(object)TextBox4, "TextBox4");
					num = (int)((num2 * 1588237929) ^ 0x7D34D95);
					continue;
				case 56u:
					SearchPatient.smethod_11((Control)(object)GroupBox2, "GroupBox2");
					num = ((int)num2 * -1328614864) ^ 0x1110833F;
					continue;
				case 55u:
					num = (int)(num2 * 1088628792) ^ -1685037621;
					continue;
				case 54u:
					SearchPatient.smethod_17((Control)(object)Button1, SearchPatient.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					SearchPatient.smethod_10((Control)(object)Button1, new Point(468, 82));
					num = ((int)num2 * -1050116400) ^ -1941287550;
					continue;
				case 53u:
					num = (int)(num2 * 402199024) ^ -61043799;
					continue;
				case 52u:
					SearchPatient.smethod_26((ButtonBase)(object)Button2, bool_0: true);
					SearchPatient.smethod_17((Control)(object)Button3, SearchPatient.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1266536149) ^ -2143781846;
					continue;
				case 51u:
					num = (int)((num2 * 2046885799) ^ 0x39A6B376);
					continue;
				case 50u:
					SearchPatient.smethod_9((Control)(object)this);
					num = ((int)num2 * -2073189823) ^ 0x2B42183B;
					continue;
				case 49u:
					SearchPatient.smethod_18((Control)(object)Label9, 11);
					num = (int)((num2 * 117934191) ^ 0x61C8813F);
					continue;
				case 48u:
					SearchPatient.smethod_18((Control)(object)DataGridView1, 12);
					SearchPatient.smethod_22(SearchPatient.smethod_21((Control)(object)GroupBox2), (Control)(object)TextBox8);
					num = (int)(num2 * 1341440233) ^ -752054988;
					continue;
				case 47u:
					Label3 = SearchPatient.smethod_2();
					num = ((int)num2 * -647731979) ^ 0x5E3C77D9;
					continue;
				case 46u:
					SearchPatient.smethod_8((Control)(object)GroupBox1);
					num = ((int)num2 * -335589726) ^ -17682698;
					continue;
				case 45u:
					num = ((int)num2 * -356485748) ^ 0x280495D3;
					continue;
				case 44u:
					SearchPatient.smethod_36((Control)(object)this, new Size(977, 804));
					SearchPatient.smethod_37((ISupportInitialize)PictureBox1);
					num = (int)((num2 * 1550618764) ^ 0x3F15B10E);
					continue;
				case 43u:
					num = (int)(num2 * 746579693) ^ -1142739732;
					continue;
				case 42u:
					SearchPatient.smethod_12((Control)(object)Label4, new Size(68, 25));
					num = (int)(num2 * 1143916822) ^ -1517351494;
					continue;
				case 41u:
					num = (int)(num2 * 1626469008) ^ -472397931;
					continue;
				case 40u:
					SearchPatient.smethod_14(PictureBox1, 9);
					num = ((int)num2 * -862906280) ^ 0x399ED66E;
					continue;
				case 39u:
					SearchPatient.smethod_12((Control)(object)TextBox6, new Size(480, 90));
					num = ((int)num2 * -1614795618) ^ -224746543;
					continue;
				case 38u:
					SearchPatient.smethod_19(Label7, "Address : ");
					num = ((int)num2 * -666205621) ^ 0x54C33830;
					continue;
				case 37u:
					num = (int)(num2 * 773637547) ^ -105137312;
					continue;
				case 36u:
					num = ((int)num2 * -897236450) ^ 0x4F59A9F2;
					continue;
				case 35u:
					SearchPatient.smethod_22(SearchPatient.smethod_21((Control)(object)GroupBox2), (Control)(object)Label4);
					SearchPatient.smethod_17((Control)(object)GroupBox2, SearchPatient.smethod_16("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -314553454) ^ -2096007615;
					continue;
				case 34u:
					SearchPatient.smethod_10((Control)(object)TextBox3, new Point(124, 43));
					num = (int)(num2 * 1049749423) ^ -679284186;
					continue;
				case 32u:
					SearchPatient.smethod_11((Control)(object)TextBox8, "TextBox8");
					num = ((int)num2 * -1767756029) ^ 0x3C4A9F2B;
					continue;
				case 31u:
					SearchPatient.smethod_11((Control)(object)TextBox7, "TextBox7");
					num = (int)(num2 * 599325520) ^ -435787682;
					continue;
				case 30u:
					Label4 = SearchPatient.smethod_2();
					num = ((int)num2 * -375786298) ^ 0x230E57D6;
					continue;
				case 29u:
					SearchPatient.smethod_25((ButtonBase)(object)Button2, "Update ");
					num = (int)(num2 * 1945703602) ^ -779157781;
					continue;
				case 28u:
					num = ((int)num2 * -1468534912) ^ -1823856956;
					continue;
				case 27u:
					SearchPatient.smethod_12((Control)(object)TextBox7, new Size(271, 28));
					num = ((int)num2 * -1665704808) ^ 0x6FC3DC1B;
					continue;
				case 26u:
					SearchPatient.smethod_11((Control)(object)TextBox2, "TextBox2");
					num = (int)((num2 * 1016783971) ^ 0x74EC150);
					continue;
				case 25u:
					SearchPatient.smethod_10((Control)(object)Label1, new Point(392, 63));
					num = (int)((num2 * 524627201) ^ 0x3FF33AE0);
					continue;
				case 24u:
					SearchPatient.smethod_29(SearchPatient.smethod_28(DataGridView1), 24);
					num = (int)(num2 * 12977299) ^ -1462969325;
					continue;
				case 23u:
					num = ((int)num2 * -1658256396) ^ 0x6120B132;
					continue;
				case 22u:
					SearchPatient.smethod_10((Control)(object)TextBox8, new Point(124, 131));
					num = (int)(num2 * 487731040) ^ -2087614178;
					continue;
				case 21u:
					SearchPatient.smethod_11((Control)(object)Button3, "Button3");
					SearchPatient.smethod_12((Control)(object)Button3, new Size(133, 37));
					num = (int)((num2 * 1113486521) ^ 0x28398D4E);
					continue;
				case 20u:
					SearchPatient.smethod_18((Control)(object)TextBox3, 4);
					num = ((int)num2 * -1793075263) ^ -1822162261;
					continue;
				case 19u:
					num = ((int)num2 * -467419604) ^ -314730017;
					continue;
				case 18u:
					SearchPatient.smethod_25((ButtonBase)(object)Button1, "Search");
					num = ((int)num2 * -996667529) ^ -1400686332;
					continue;
				case 17u:
					SearchPatient.smethod_11((Control)(object)Label1, "Label1");
					num = (int)(num2 * 1464216342) ^ -1438559524;
					continue;
				case 16u:
					SearchPatient.smethod_10((Control)(object)Button2, new Point(779, 526));
					num = (int)(num2 * 1124829550) ^ -1962717273;
					continue;
				case 15u:
					num = ((int)num2 * -1010447969) ^ -1282895703;
					continue;
				case 14u:
					SearchPatient.smethod_22(SearchPatient.smethod_34((Control)(object)this), (Control)(object)DataGridView1);
					num = ((int)num2 * -183396590) ^ 0x27A34353;
					continue;
				case 13u:
					SearchPatient.smethod_11((Control)(object)GroupBox1, "GroupBox1");
					num = (int)((num2 * 1904253721) ^ 0x5379A9B3);
					continue;
				case 12u:
					SearchPatient.smethod_17((Control)(object)Button2, SearchPatient.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 226820055) ^ 0x4B211850);
					continue;
				case 11u:
					num = ((int)num2 * -1804776740) ^ -1353718216;
					continue;
				case 10u:
					SearchPatient.smethod_39((Control)(object)GroupBox2);
					SearchPatient.smethod_40((Control)(object)this, bool_0: false);
					num = (int)((num2 * 509625410) ^ 0x711CEC4F);
					continue;
				case 9u:
					SearchPatient.smethod_10((Control)(object)Label9, new Point(20, 132));
					num = (int)(num2 * 1332448143) ^ -1361934837;
					continue;
				case 8u:
					num = ((int)num2 * -642350238) ^ 0x6DAE8813;
					continue;
				case 7u:
					SearchPatient.smethod_12((Control)(object)TextBox8, new Size(271, 28));
					num = ((int)num2 * -367781949) ^ 0x7E35A7F7;
					continue;
				case 6u:
					num = ((int)num2 * -237924433) ^ -1408538710;
					continue;
				case 5u:
					SearchPatient.smethod_18((Control)(object)TextBox5, 6);
					SearchPatient.smethod_10((Control)(object)TextBox4, new Point(504, 88));
					num = (int)((num2 * 976685821) ^ 0x6B8E0F41);
					continue;
				case 4u:
					SearchPatient.smethod_19(Label9, "Phone : ");
					num = (int)((num2 * 841483118) ^ 0x4223F81B);
					continue;
				case 3u:
					SearchPatient.smethod_19(Label6, "Gender : ");
					num = ((int)num2 * -1303198482) ^ -1492715834;
					continue;
				case 2u:
					SearchPatient.smethod_10((Control)(object)Label8, new Point(20, 88));
					num = ((int)num2 * -285455245) ^ 0x73C544BC;
					continue;
				case 1u:
					SearchPatient.smethod_35((Control)(object)this, "SearchPatient");
					num = (int)((num2 * 1253748612) ^ 0x24D32764);
					continue;
				case 0u:
					SearchPatient.smethod_22(SearchPatient.smethod_21((Control)(object)GroupBox2), (Control)(object)Label9);
					SearchPatient.smethod_22(SearchPatient.smethod_21((Control)(object)GroupBox2), (Control)(object)TextBox7);
					num = ((int)num2 * -1806271011) ^ -1862067446;
					continue;
				default:
					return;
				case 207u:
					break;
				case 33u:
					return;
				}
				break;
			}
		}
	}

	static void smethod_0(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static PictureBox smethod_1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new PictureBox();
	}

	static Label smethod_2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Label();
	}

	static GroupBox smethod_3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new GroupBox();
	}

	static Button smethod_4()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Button();
	}

	static TextBox smethod_5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new TextBox();
	}

	static DataGridView smethod_6()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new DataGridView();
	}

	static void smethod_7(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.BeginInit();
	}

	static void smethod_8(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_9(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_10(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_11(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_12(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_13(PictureBox pictureBox_0, PictureBoxSizeMode pictureBoxSizeMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		pictureBox_0.set_SizeMode(pictureBoxSizeMode_0);
	}

	static void smethod_14(PictureBox pictureBox_0, int int_0)
	{
		pictureBox_0.set_TabIndex(int_0);
	}

	static void smethod_15(PictureBox pictureBox_0, bool bool_0)
	{
		pictureBox_0.set_TabStop(bool_0);
	}

	static Font smethod_16(string string_0, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_17(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static void smethod_18(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static void smethod_19(Label label_0, string string_0)
	{
		label_0.set_Text(string_0);
	}

	static void smethod_20(Label label_0, ContentAlignment contentAlignment_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		label_0.set_TextAlign(contentAlignment_0);
	}

	static ControlCollection smethod_21(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_22(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_23(GroupBox groupBox_0, bool bool_0)
	{
		groupBox_0.set_TabStop(bool_0);
	}

	static void smethod_24(GroupBox groupBox_0, string string_0)
	{
		groupBox_0.set_Text(string_0);
	}

	static void smethod_25(ButtonBase buttonBase_0, string string_0)
	{
		buttonBase_0.set_Text(string_0);
	}

	static void smethod_26(ButtonBase buttonBase_0, bool bool_0)
	{
		buttonBase_0.set_UseVisualStyleBackColor(bool_0);
	}

	static void smethod_27(DataGridView dataGridView_0, DataGridViewColumnHeadersHeightSizeMode dataGridViewColumnHeadersHeightSizeMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		dataGridView_0.set_ColumnHeadersHeightSizeMode(dataGridViewColumnHeadersHeightSizeMode_0);
	}

	static DataGridViewRow smethod_28(DataGridView dataGridView_0)
	{
		return dataGridView_0.get_RowTemplate();
	}

	static void smethod_29(DataGridViewRow dataGridViewRow_0, int int_0)
	{
		dataGridViewRow_0.set_Height(int_0);
	}

	static void smethod_30(TextBoxBase textBoxBase_0, bool bool_0)
	{
		textBoxBase_0.set_ReadOnly(bool_0);
	}

	static void smethod_31(TextBox textBox_0, bool bool_0)
	{
		textBox_0.set_Multiline(bool_0);
	}

	static void smethod_32(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_33(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static ControlCollection smethod_34(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_35(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_36(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_37(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.EndInit();
	}

	static void smethod_38(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_39(Control control_0)
	{
		control_0.PerformLayout();
	}

	static void smethod_40(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}
}
