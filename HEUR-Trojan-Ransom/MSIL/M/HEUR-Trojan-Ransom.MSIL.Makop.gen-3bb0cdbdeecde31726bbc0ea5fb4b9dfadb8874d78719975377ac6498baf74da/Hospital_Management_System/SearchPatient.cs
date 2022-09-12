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
			bool flag = default(bool);
			while (true)
			{
				int num = -1706023917;
				while (true)
				{
					uint num2;
					int num5;
					switch ((num2 = (uint)num ^ 0xA3F19BADu) % 8u)
					{
					case 7u:
						SearchPatient.smethod_0((IDisposable)components);
						num = (int)((num2 * 969984195) ^ 0x227450D2);
						continue;
					case 6u:
						if (disposing)
						{
							num = ((int)num2 * -1624205825) ^ 0x1452DD42;
							continue;
						}
						num5 = 0;
						goto IL_0034;
					case 5u:
						num5 = ((components != null) ? 1 : 0);
						goto IL_0034;
					case 4u:
						num = -1460546940;
						continue;
					case 2u:
						num = (int)(num2 * 712106105) ^ -2060233709;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 1901024057;
							num4 = 1901024057;
						}
						else
						{
							num3 = 1570888634;
							num4 = 1570888634;
						}
						num = num3 ^ (int)(num2 * 1031675021);
						continue;
					}
					default:
						return;
					case 3u:
						break;
					case 1u:
						return;
						IL_0034:
						flag = (byte)num5 != 0;
						num = -1916520339;
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
				IL_0100:
				int num6 = -1056545061;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num6 ^ 0xA3F19BADu) % 4u)
					{
					case 3u:
						num6 = ((int)num2 * -53520802) ^ -705643266;
						continue;
					case 2u:
						((ContainerControl)this).Dispose(disposing);
						num6 = (int)((num2 * 28968540) ^ 0x16090F0A);
						continue;
					default:
						goto end_IL_00df;
					case 0u:
						break;
					case 1u:
						goto end_IL_00df;
					}
					goto IL_0100;
					continue;
					end_IL_00df:
					break;
				}
				break;
			}
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		PictureBox1 = SearchPatient.smethod_1();
		Label1 = SearchPatient.smethod_2();
		while (true)
		{
			int num = -221248228;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCFBD247Fu) % 266u)
				{
				case 265u:
					Button1 = SearchPatient.smethod_4();
					num = (int)(num2 * 761367016) ^ -1080543730;
					continue;
				case 264u:
					num = (int)((num2 * 488700) ^ 0x3E93B62C);
					continue;
				case 263u:
					SearchPatient.smethod_10((Control)(object)TextBox7, new Point(124, 92));
					num = (int)(num2 * 1206020877) ^ -281162974;
					continue;
				case 262u:
					SearchPatient.smethod_10((Control)(object)Button4, new Point(779, 612));
					num = (int)(num2 * 658593373) ^ -90185265;
					continue;
				case 261u:
					num = ((int)num2 * -900197603) ^ -1337660034;
					continue;
				case 260u:
					num = ((int)num2 * -837710653) ^ 0x241C0631;
					continue;
				case 259u:
					Label9 = SearchPatient.smethod_2();
					num = ((int)num2 * -1881091083) ^ -1865816643;
					continue;
				case 258u:
					SearchPatient.smethod_22(SearchPatient.smethod_21((Control)(object)GroupBox2), (Control)(object)Label8);
					num = ((int)num2 * -288320630) ^ 0x73638026;
					continue;
				case 257u:
					SearchPatient.smethod_12((Control)(object)TextBox4, new Size(100, 28));
					num = ((int)num2 * -472648879) ^ -1184617110;
					continue;
				case 256u:
					SearchPatient.smethod_12((Control)(object)Button1, new Size(133, 37));
					SearchPatient.smethod_18((Control)(object)Button1, 4);
					SearchPatient.smethod_25((ButtonBase)(object)Button1, "Search");
					num = ((int)num2 * -954364276) ^ -1369244783;
					continue;
				case 255u:
					SearchPatient.smethod_18((Control)(object)Label2, 0);
					num = (int)(num2 * 80232248) ^ -2028628193;
					continue;
				case 254u:
					SearchPatient.smethod_23(GroupBox1, bool_0: false);
					num = ((int)num2 * -524627749) ^ -1288629562;
					continue;
				case 253u:
					SearchPatient.smethod_12((Control)(object)Button4, new Size(133, 37));
					num = ((int)num2 * -1260556070) ^ -1214194764;
					continue;
				case 252u:
					num = ((int)num2 * -950917206) ^ -430358529;
					continue;
				case 251u:
					SearchPatient.smethod_22(SearchPatient.smethod_21((Control)(object)GroupBox1), (Control)(object)TextBox1);
					SearchPatient.smethod_22(SearchPatient.smethod_21((Control)(object)GroupBox1), (Control)(object)Label2);
					num = (int)((num2 * 608532517) ^ 0x2A9C3BAD);
					continue;
				case 250u:
					SearchPatient.smethod_19(Label7, "Address : ");
					SearchPatient.smethod_17((Control)(object)Label6, SearchPatient.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 261643737) ^ -307180223;
					continue;
				case 249u:
					num = ((int)num2 * -1117874985) ^ -570805091;
					continue;
				case 248u:
					num = (int)((num2 * 234667690) ^ 0x57FBA2A7);
					continue;
				case 247u:
					num = ((int)num2 * -1255833335) ^ -550200959;
					continue;
				case 246u:
					SearchPatient.smethod_18((Control)(object)TextBox4, 5);
					num = ((int)num2 * -1542901891) ^ 0x44EB044E;
					continue;
				case 245u:
					SearchPatient.smethod_17((Control)(object)Button1, SearchPatient.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1437615929) ^ -2062760779;
					continue;
				case 244u:
					SearchPatient.smethod_19(Label9, "Phone : ");
					num = ((int)num2 * -92611363) ^ 0x54F4625E;
					continue;
				case 243u:
					SearchPatient.smethod_22(SearchPatient.smethod_21((Control)(object)GroupBox2), (Control)(object)Label4);
					num = ((int)num2 * -1612830561) ^ 0x7F243CD5;
					continue;
				case 242u:
					num = (int)(num2 * 1211914509) ^ -285059522;
					continue;
				case 241u:
					SearchPatient.smethod_11((Control)(object)Button3, "Button3");
					num = ((int)num2 * -1176235140) ^ 0x16498D16;
					continue;
				case 240u:
					SearchPatient.smethod_24(GroupBox2, "Patient Information");
					num = ((int)num2 * -1601977690) ^ -1789880923;
					continue;
				case 239u:
					SearchPatient.smethod_18((Control)(object)Label7, 3);
					num = ((int)num2 * -1724783094) ^ -293810183;
					continue;
				case 238u:
					SearchPatient.smethod_11((Control)(object)Label1, "Label1");
					num = ((int)num2 * -1837959711) ^ 0x6F7B8991;
					continue;
				case 237u:
					SearchPatient.smethod_12((Control)(object)Button3, new Size(133, 37));
					num = ((int)num2 * -1021157900) ^ -1622645951;
					continue;
				case 236u:
					SearchPatient.smethod_26((ButtonBase)(object)Button3, bool_0: true);
					num = ((int)num2 * -1544676765) ^ -289565116;
					continue;
				case 235u:
					SearchPatient.smethod_38((Control)(object)GroupBox2, bool_0: false);
					num = (int)(num2 * 1104146744) ^ -1949412993;
					continue;
				case 234u:
					SearchPatient.smethod_19(Label8, "Name : ");
					num = (int)((num2 * 1735746174) ^ 0xF2CD423);
					continue;
				case 233u:
					SearchPatient.smethod_33((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 1573620865) ^ 0x66378183);
					continue;
				case 232u:
					num = ((int)num2 * -1175554916) ^ 0x72A8DE8A;
					continue;
				case 231u:
					SearchPatient.smethod_10((Control)(object)Label7, new Point(20, 182));
					num = ((int)num2 * -1571626746) ^ -1107604646;
					continue;
				case 230u:
					SearchPatient.smethod_17((Control)(object)Label3, SearchPatient.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1562778327) ^ -288403483;
					continue;
				case 229u:
					SearchPatient.smethod_22(SearchPatient.smethod_21((Control)(object)GroupBox2), (Control)(object)Label7);
					num = (int)(num2 * 893216958) ^ -1045164273;
					continue;
				case 228u:
					SearchPatient.smethod_12((Control)(object)Label2, new Size(77, 28));
					num = (int)(num2 * 285508114) ^ -1725116987;
					continue;
				case 227u:
					num = ((int)num2 * -1794403737) ^ -138692136;
					continue;
				case 226u:
					num = ((int)num2 * -415917364) ^ -816143681;
					continue;
				case 225u:
					num = (int)((num2 * 1045568624) ^ 0x5DB8F52C);
					continue;
				case 224u:
					num = (int)((num2 * 832621507) ^ 0x1286F0BB);
					continue;
				case 223u:
					num = (int)(num2 * 2143212833) ^ -1662126560;
					continue;
				case 222u:
					SearchPatient.smethod_19(Label2, "Name : ");
					SearchPatient.smethod_20(Label2, (ContentAlignment)32);
					num = (int)((num2 * 809843801) ^ 0x229D9C08);
					continue;
				case 221u:
					SearchPatient.smethod_22(SearchPatient.smethod_34((Control)(object)this), (Control)(object)Button4);
					num = (int)(num2 * 945904826) ^ -1364456072;
					continue;
				case 220u:
					num = (int)(num2 * 1833020925) ^ -1275545563;
					continue;
				case 219u:
					SearchPatient.smethod_11((Control)(object)Label3, "Label3");
					num = (int)((num2 * 666485182) ^ 0x54109462);
					continue;
				case 218u:
					SearchPatient.smethod_22(SearchPatient.smethod_21((Control)(object)GroupBox2), (Control)(object)TextBox4);
					SearchPatient.smethod_22(SearchPatient.smethod_21((Control)(object)GroupBox2), (Control)(object)TextBox3);
					num = ((int)num2 * -1994433625) ^ -1004834754;
					continue;
				case 217u:
					num = ((int)num2 * -1318801461) ^ -631576654;
					continue;
				case 216u:
					SearchPatient.smethod_19(Label1, "Search Patient");
					num = ((int)num2 * -1880522641) ^ -1358394937;
					continue;
				case 215u:
					SearchPatient.smethod_18((Control)(object)Button4, 16);
					num = (int)(num2 * 140660189) ^ -1501457136;
					continue;
				case 214u:
					TextBox8 = SearchPatient.smethod_5();
					num = ((int)num2 * -1844626919) ^ -104122221;
					continue;
				case 213u:
					SearchPatient.smethod_29(SearchPatient.smethod_28(DataGridView1), 24);
					num = (int)(num2 * 1963418331) ^ -1025518409;
					continue;
				case 212u:
					SearchPatient.smethod_11((Control)(object)TextBox7, "TextBox7");
					num = ((int)num2 * -1685342142) ^ 0x32D6E07C;
					continue;
				case 211u:
					SearchPatient.smethod_19(Label5, "Age :");
					num = ((int)num2 * -1361932248) ^ -2093156215;
					continue;
				case 210u:
					SearchPatient.smethod_10((Control)(object)Label8, new Point(20, 88));
					num = (int)(num2 * 2000813638) ^ -487206095;
					continue;
				case 209u:
					num = (int)((num2 * 470001005) ^ 0x4B110A4D);
					continue;
				case 208u:
					Label8 = SearchPatient.smethod_2();
					num = ((int)num2 * -1661132844) ^ -26536026;
					continue;
				case 207u:
					Label5 = SearchPatient.smethod_2();
					num = (int)(num2 * 694418094) ^ -1224393579;
					continue;
				case 206u:
					SearchPatient.smethod_35((Control)(object)this, "SearchPatient");
					num = ((int)num2 * -1608122638) ^ 0x64DD9D05;
					continue;
				case 205u:
					SearchPatient.smethod_18((Control)(object)Label8, 9);
					num = (int)((num2 * 1599043147) ^ 0x4BD53E92);
					continue;
				case 204u:
					SearchPatient.smethod_31(TextBox6, bool_0: true);
					num = (int)(num2 * 415641221) ^ -1773650478;
					continue;
				case 203u:
					SearchPatient.smethod_22(SearchPatient.smethod_34((Control)(object)this), (Control)(object)Button3);
					SearchPatient.smethod_22(SearchPatient.smethod_34((Control)(object)this), (Control)(object)Button2);
					num = ((int)num2 * -1291941010) ^ 0x16C18EAC;
					continue;
				case 201u:
					SearchPatient.smethod_11((Control)(object)Label9, "Label9");
					num = (int)((num2 * 1539977753) ^ 0x54FBE65D);
					continue;
				case 200u:
					SearchPatient.smethod_36((Control)(object)this, new Size(977, 804));
					num = ((int)num2 * -1917781965) ^ -131236343;
					continue;
				case 199u:
					num = (int)(num2 * 2077269905) ^ -1914680877;
					continue;
				case 198u:
					SearchPatient.smethod_19(Label3, "Phone : ");
					num = (int)((num2 * 1521249790) ^ 0x62D5D052);
					continue;
				case 197u:
					SearchPatient.smethod_12((Control)(object)TextBox7, new Size(271, 28));
					num = ((int)num2 * -723662389) ^ 0x62506991;
					continue;
				case 196u:
					num = (int)((num2 * 1724152935) ^ 0xB40DA80);
					continue;
				case 195u:
					num = (int)((num2 * 730454146) ^ 0x3B65CEA9);
					continue;
				case 194u:
					num = ((int)num2 * -1870452336) ^ -254188556;
					continue;
				case 193u:
					SearchPatient.smethod_22(SearchPatient.smethod_34((Control)(object)this), (Control)(object)GroupBox1);
					SearchPatient.smethod_22(SearchPatient.smethod_34((Control)(object)this), (Control)(object)Label1);
					num = ((int)num2 * -755022524) ^ -617883608;
					continue;
				case 192u:
					num = ((int)num2 * -1688123141) ^ 0x13F829D7;
					continue;
				case 191u:
					SearchPatient.smethod_10((Control)(object)Label3, new Point(37, 87));
					num = (int)((num2 * 301445827) ^ 0x37EF17AF);
					continue;
				case 190u:
					SearchPatient.smethod_26((ButtonBase)(object)Button1, bool_0: true);
					num = (int)(num2 * 366034613) ^ -1888565234;
					continue;
				case 189u:
					SearchPatient.smethod_12((Control)(object)TextBox6, new Size(480, 90));
					num = (int)((num2 * 413348219) ^ 0x5E10BD31);
					continue;
				case 188u:
					num = (int)((num2 * 1969898961) ^ 0x41E33AB6);
					continue;
				case 187u:
					num = (int)((num2 * 769691096) ^ 0x1AE3849C);
					continue;
				case 186u:
					Label4 = SearchPatient.smethod_2();
					num = (int)(num2 * 313083150) ^ -389689846;
					continue;
				case 185u:
					SearchPatient.smethod_18((Control)(object)TextBox1, 1);
					num = ((int)num2 * -884733042) ^ -875461367;
					continue;
				case 184u:
					SearchPatient.smethod_30((TextBoxBase)(object)TextBox7, bool_0: true);
					num = ((int)num2 * -320808522) ^ 0x7521436;
					continue;
				case 183u:
					num = ((int)num2 * -353425644) ^ 0x2D961491;
					continue;
				case 182u:
					SearchPatient.smethod_12((Control)(object)Label6, new Size(84, 26));
					num = ((int)num2 * -2037627664) ^ -740475945;
					continue;
				case 181u:
					num = ((int)num2 * -836700296) ^ -204298480;
					continue;
				case 180u:
					num = ((int)num2 * -1172258744) ^ 0x3000F5BB;
					continue;
				case 179u:
					SearchPatient.smethod_10((Control)(object)DataGridView1, new Point(59, 295));
					num = ((int)num2 * -1671580384) ^ -1345463233;
					continue;
				case 178u:
					SearchPatient.smethod_11((Control)(object)Label6, "Label6");
					num = ((int)num2 * -195919234) ^ 0x20C88AE7;
					continue;
				case 177u:
					SearchPatient.smethod_12((Control)(object)TextBox2, new Size(237, 28));
					num = (int)((num2 * 854828506) ^ 0x5124D3CC);
					continue;
				case 176u:
					SearchPatient.smethod_18((Control)(object)GroupBox2, 13);
					num = ((int)num2 * -1000926895) ^ 0x42BC253A;
					continue;
				case 175u:
					num = (int)((num2 * 1535258226) ^ 0x613D6F6C);
					continue;
				case 174u:
					SearchPatient.smethod_17((Control)(object)Label9, SearchPatient.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -397487781) ^ 0x6BB5F289;
					continue;
				case 173u:
					Button2 = SearchPatient.smethod_4();
					num = ((int)num2 * -258019415) ^ -1310517891;
					continue;
				case 172u:
					SearchPatient.smethod_10((Control)(object)TextBox8, new Point(124, 131));
					num = ((int)num2 * -1891774686) ^ 0x3136E46B;
					continue;
				case 171u:
					SearchPatient.smethod_12((Control)(object)GroupBox2, new Size(623, 292));
					num = ((int)num2 * -2022285463) ^ -2123779544;
					continue;
				case 170u:
					num = (int)(num2 * 1812823553) ^ -1455191084;
					continue;
				case 169u:
					SearchPatient.smethod_11((Control)(object)TextBox3, "TextBox3");
					num = (int)(num2 * 281332036) ^ -844502633;
					continue;
				case 168u:
					num = (int)(num2 * 1131966536) ^ -52722322;
					continue;
				case 167u:
					SearchPatient.smethod_18((Control)(object)DataGridView1, 12);
					SearchPatient.smethod_22(SearchPatient.smethod_21((Control)(object)GroupBox2), (Control)(object)TextBox8);
					num = (int)(num2 * 652744691) ^ -568998532;
					continue;
				case 166u:
					SearchPatient.smethod_39((Control)(object)GroupBox2);
					num = ((int)num2 * -243228535) ^ -1526942583;
					continue;
				case 165u:
					SearchPatient.smethod_10((Control)(object)TextBox6, new Point(124, 182));
					num = (int)(num2 * 819912793) ^ -32597122;
					continue;
				case 164u:
					SearchPatient.smethod_8((Control)(object)GroupBox2);
					num = (int)((num2 * 412982643) ^ 0xC3A8294);
					continue;
				case 163u:
					TextBox2 = SearchPatient.smethod_5();
					num = ((int)num2 * -416362116) ^ -1520702419;
					continue;
				case 162u:
					num = (int)(num2 * 1830215433) ^ -1420152383;
					continue;
				case 161u:
					SearchPatient.smethod_11((Control)(object)GroupBox1, "GroupBox1");
					num = ((int)num2 * -1948034198) ^ -260758928;
					continue;
				case 160u:
					SearchPatient.smethod_7((ISupportInitialize)DataGridView1);
					num = (int)((num2 * 360536229) ^ 0x3E15730E);
					continue;
				case 159u:
					SearchPatient.smethod_12((Control)(object)Label5, new Size(68, 26));
					num = (int)((num2 * 634557610) ^ 0x1C642802);
					continue;
				case 158u:
					Label7 = SearchPatient.smethod_2();
					Label6 = SearchPatient.smethod_2();
					num = ((int)num2 * -1764723148) ^ -692197701;
					continue;
				case 157u:
					num = (int)((num2 * 2119617009) ^ 0x52DD5769);
					continue;
				case 156u:
					num = (int)(num2 * 87921925) ^ -577515987;
					continue;
				case 155u:
					SearchPatient.smethod_18((Control)(object)TextBox7, 10);
					SearchPatient.smethod_17((Control)(object)Label8, SearchPatient.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 96166833) ^ 0x385DB080);
					continue;
				case 154u:
					SearchPatient.smethod_11((Control)(object)Label4, "Label4");
					num = (int)(num2 * 1059060738) ^ -1862959931;
					continue;
				case 153u:
					SearchPatient.smethod_11((Control)(object)Button1, "Button1");
					num = (int)((num2 * 489574940) ^ 0x68A2AC31);
					continue;
				case 152u:
					SearchPatient.smethod_12((Control)(object)TextBox5, new Size(100, 28));
					num = (int)(num2 * 1510763617) ^ -1972280916;
					continue;
				case 151u:
					SearchPatient.smethod_22(SearchPatient.smethod_34((Control)(object)this), (Control)(object)GroupBox2);
					num = (int)((num2 * 366343014) ^ 0x62BB3786);
					continue;
				case 150u:
					SearchPatient.smethod_18((Control)(object)Label4, 0);
					num = ((int)num2 * -1916119133) ^ -2023640406;
					continue;
				case 149u:
					num = ((int)num2 * -1551448143) ^ -1223708076;
					continue;
				case 148u:
					SearchPatient.smethod_12((Control)(object)Button2, new Size(133, 37));
					SearchPatient.smethod_18((Control)(object)Button2, 14);
					num = (int)((num2 * 925634903) ^ 0x3BF6F487);
					continue;
				case 147u:
					Label2 = SearchPatient.smethod_2();
					num = ((int)num2 * -978509297) ^ -456269029;
					continue;
				case 146u:
					num = (int)((num2 * 1675866707) ^ 0x6747C58F);
					continue;
				case 145u:
					num = (int)(num2 * 1927047117) ^ -407221151;
					continue;
				case 144u:
					SearchPatient.smethod_17((Control)(object)Label2, SearchPatient.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					SearchPatient.smethod_10((Control)(object)Label2, new Point(37, 44));
					num = (int)(num2 * 508208517) ^ -1381568157;
					continue;
				case 143u:
					num = (int)(num2 * 1617923026) ^ -743477975;
					continue;
				case 142u:
					SearchPatient.smethod_10((Control)(object)Button1, new Point(468, 82));
					num = (int)((num2 * 1941526038) ^ 0x7F36C580);
					continue;
				case 141u:
					SearchPatient.smethod_11((Control)(object)TextBox6, "TextBox6");
					num = (int)(num2 * 1518413604) ^ -176705234;
					continue;
				case 140u:
					num = ((int)num2 * -861873923) ^ -132979872;
					continue;
				case 139u:
					SearchPatient.smethod_12((Control)(object)Label7, new Size(98, 26));
					num = ((int)num2 * -361933458) ^ -1612418552;
					continue;
				case 138u:
					SearchPatient.smethod_18((Control)(object)GroupBox1, 11);
					num = ((int)num2 * -2087495153) ^ -412594354;
					continue;
				case 137u:
					SearchPatient.smethod_17((Control)(object)GroupBox1, SearchPatient.smethod_16("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					SearchPatient.smethod_10((Control)(object)GroupBox1, new Point(155, 150));
					num = (int)((num2 * 2056135978) ^ 0x6E16D71C);
					continue;
				case 136u:
					SearchPatient.smethod_11((Control)(object)Label2, "Label2");
					num = (int)(num2 * 489564281) ^ -590253453;
					continue;
				case 135u:
					num = (int)((num2 * 2136922638) ^ 0x224EB926);
					continue;
				case 134u:
					SearchPatient.smethod_11((Control)(object)TextBox8, "TextBox8");
					SearchPatient.smethod_12((Control)(object)TextBox8, new Size(271, 28));
					num = ((int)num2 * -237560905) ^ 0x3FC69A47;
					continue;
				case 133u:
					SearchPatient.smethod_9((Control)(object)this);
					SearchPatient.smethod_10((Control)(object)PictureBox1, new Point(295, 43));
					num = ((int)num2 * -1662209741) ^ -2011761603;
					continue;
				case 132u:
					SearchPatient.smethod_39((Control)(object)GroupBox1);
					num = (int)(num2 * 992913540) ^ -256425019;
					continue;
				case 131u:
					SearchPatient.smethod_12((Control)(object)PictureBox1, new Size(91, 82));
					SearchPatient.smethod_13(PictureBox1, (PictureBoxSizeMode)1);
					num = ((int)num2 * -1039369062) ^ 0x43B41C13;
					continue;
				case 130u:
					SearchPatient.smethod_18((Control)(object)Button3, 15);
					num = ((int)num2 * -832687713) ^ 0x1DA52EFE;
					continue;
				case 129u:
					SearchPatient.smethod_25((ButtonBase)(object)Button4, "Delete");
					num = (int)((num2 * 1014269928) ^ 0x3D6799BE);
					continue;
				case 128u:
					SearchPatient.smethod_17((Control)(object)Label5, SearchPatient.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1342978284) ^ -1948122776;
					continue;
				case 127u:
					SearchPatient.smethod_18((Control)(object)TextBox3, 4);
					num = ((int)num2 * -1607728967) ^ -521136670;
					continue;
				case 126u:
					num = ((int)num2 * -1211126778) ^ -96468804;
					continue;
				case 125u:
					num = ((int)num2 * -795803684) ^ -726879543;
					continue;
				case 124u:
					SearchPatient.smethod_22(SearchPatient.smethod_21((Control)(object)GroupBox2), (Control)(object)Label6);
					SearchPatient.smethod_22(SearchPatient.smethod_21((Control)(object)GroupBox2), (Control)(object)Label5);
					num = ((int)num2 * -1631131896) ^ -1307645634;
					continue;
				case 123u:
					num = (int)(num2 * 1767922327) ^ -1548361476;
					continue;
				case 122u:
					num = ((int)num2 * -1018611012) ^ -1686154429;
					continue;
				case 121u:
					num = ((int)num2 * -1694830907) ^ 0x328B9F37;
					continue;
				case 120u:
					SearchPatient.smethod_11((Control)(object)TextBox2, "TextBox2");
					num = ((int)num2 * -203245554) ^ 0x72677706;
					continue;
				case 119u:
					SearchPatient.smethod_10((Control)(object)GroupBox2, new Point(108, 480));
					SearchPatient.smethod_11((Control)(object)GroupBox2, "GroupBox2");
					num = (int)((num2 * 347750929) ^ 0x5F8331E1);
					continue;
				case 118u:
					num = (int)((num2 * 307760650) ^ 0x303C6E3E);
					continue;
				case 117u:
					SearchPatient.smethod_12((Control)(object)DataGridView1, new Size(853, 169));
					num = ((int)num2 * -422692302) ^ -1067025908;
					continue;
				case 116u:
					num = (int)(num2 * 1077573841) ^ -1445816572;
					continue;
				case 115u:
					num = ((int)num2 * -584102643) ^ -1906198463;
					continue;
				case 114u:
					SearchPatient.smethod_18((Control)(object)Label9, 11);
					num = (int)((num2 * 62604287) ^ 0x15BE356D);
					continue;
				case 113u:
					SearchPatient.smethod_12((Control)(object)Label3, new Size(77, 28));
					num = ((int)num2 * -925919266) ^ 0x798DD86F;
					continue;
				case 112u:
					DataGridView1 = SearchPatient.smethod_6();
					num = (int)(num2 * 205099724) ^ -348363778;
					continue;
				case 111u:
					TextBox6 = SearchPatient.smethod_5();
					TextBox5 = SearchPatient.smethod_5();
					num = ((int)num2 * -1981749091) ^ 0x6ED9664;
					continue;
				case 110u:
					SearchPatient.smethod_22(SearchPatient.smethod_21((Control)(object)GroupBox2), (Control)(object)TextBox5);
					num = (int)(num2 * 1784359095) ^ -1329528055;
					continue;
				case 109u:
					num = ((int)num2 * -980294066) ^ 0x54D22F1D;
					continue;
				case 108u:
					SearchPatient.smethod_10((Control)(object)Label6, new Point(414, 131));
					num = ((int)num2 * -1018320827) ^ 0x1FABE9FB;
					continue;
				case 107u:
					SearchPatient.smethod_20(Label9, (ContentAlignment)32);
					num = ((int)num2 * -46710204) ^ -1457646050;
					continue;
				case 106u:
					SearchPatient.smethod_17((Control)(object)Button3, SearchPatient.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					SearchPatient.smethod_10((Control)(object)Button3, new Point(779, 697));
					num = ((int)num2 * -674785573) ^ -559615184;
					continue;
				case 105u:
					TextBox7 = SearchPatient.smethod_5();
					num = (int)(num2 * 158521405) ^ -566745855;
					continue;
				case 104u:
					SearchPatient.smethod_22(SearchPatient.smethod_34((Control)(object)this), (Control)(object)DataGridView1);
					num = (int)((num2 * 1242900474) ^ 0x44B35617);
					continue;
				case 103u:
					num = ((int)num2 * -444080235) ^ 0x72939F64;
					continue;
				case 102u:
					SearchPatient.smethod_10((Control)(object)Label9, new Point(20, 132));
					num = (int)(num2 * 836363606) ^ -1442160714;
					continue;
				case 101u:
					num = (int)((num2 * 578993863) ^ 0x797B1903);
					continue;
				case 100u:
					SearchPatient.smethod_11((Control)(object)TextBox1, "TextBox1");
					num = ((int)num2 * -885378172) ^ -1586150397;
					continue;
				case 99u:
					num = (int)((num2 * 1210874297) ^ 0x2D9DD0E8);
					continue;
				case 98u:
					SearchPatient.smethod_20(Label8, (ContentAlignment)32);
					num = (int)((num2 * 726953794) ^ 0x66EA4275);
					continue;
				case 97u:
					SearchPatient.smethod_10((Control)(object)Label1, new Point(392, 63));
					num = ((int)num2 * -721045344) ^ -1106421923;
					continue;
				case 96u:
					num = (int)(num2 * 1811027862) ^ -1921631306;
					continue;
				case 95u:
					SearchPatient.smethod_18((Control)(object)TextBox8, 12);
					num = ((int)num2 * -1323245670) ^ -1861731991;
					continue;
				case 94u:
					num = (int)(num2 * 1725904296) ^ -936865013;
					continue;
				case 93u:
					Label3 = SearchPatient.smethod_2();
					num = (int)((num2 * 974084982) ^ 0x40F08078);
					continue;
				case 92u:
					SearchPatient.smethod_22(SearchPatient.smethod_21((Control)(object)GroupBox2), (Control)(object)TextBox6);
					num = ((int)num2 * -1512571449) ^ 0x4A159511;
					continue;
				case 91u:
					GroupBox2 = SearchPatient.smethod_3();
					num = ((int)num2 * -1548141324) ^ -1271427193;
					continue;
				case 90u:
					SearchPatient.smethod_8((Control)(object)GroupBox1);
					num = (int)(num2 * 881605775) ^ -981843485;
					continue;
				case 89u:
					SearchPatient.smethod_12((Control)(object)TextBox3, new Size(100, 28));
					num = (int)(num2 * 1431428599) ^ -1430257337;
					continue;
				case 88u:
					num = (int)(num2 * 1752510610) ^ -1347727699;
					continue;
				case 87u:
					num = ((int)num2 * -2059544076) ^ 0x2C07EC3B;
					continue;
				case 86u:
					SearchPatient.smethod_10((Control)(object)Label5, new Point(417, 94));
					num = ((int)num2 * -1834998473) ^ 0xFBA9E08;
					continue;
				case 85u:
					num = ((int)num2 * -1196041757) ^ -738609900;
					continue;
				case 84u:
					SearchPatient.smethod_17((Control)(object)Button4, SearchPatient.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1162858348) ^ 0x3ADA85E3);
					continue;
				case 83u:
					SearchPatient.smethod_11((Control)(object)Button4, "Button4");
					num = (int)(num2 * 571295290) ^ -252933533;
					continue;
				case 81u:
					num = (int)(num2 * 329436255) ^ -604831351;
					continue;
				case 80u:
					SearchPatient.smethod_18((Control)(object)Label6, 2);
					num = (int)((num2 * 1517608095) ^ 0x1D9452E6);
					continue;
				case 79u:
					SearchPatient.smethod_12((Control)(object)TextBox1, new Size(237, 28));
					num = ((int)num2 * -501450305) ^ 0x6AFE1BFD;
					continue;
				case 78u:
					SearchPatient.smethod_12((Control)(object)Label4, new Size(68, 25));
					num = (int)((num2 * 1716557926) ^ 0xB2D5AC5);
					continue;
				case 77u:
					TextBox4 = SearchPatient.smethod_5();
					TextBox3 = SearchPatient.smethod_5();
					num = (int)(num2 * 1352066112) ^ -1951272179;
					continue;
				case 76u:
					num = (int)((num2 * 1857882889) ^ 0x4A71108);
					continue;
				case 75u:
					SearchPatient.smethod_12((Control)(object)GroupBox1, new Size(623, 128));
					num = ((int)num2 * -1407803056) ^ 0x456223EF;
					continue;
				case 74u:
					SearchPatient.smethod_32((ContainerControl)(object)this, new SizeF(8f, 16f));
					num = ((int)num2 * -689260384) ^ -268216418;
					continue;
				case 73u:
					SearchPatient.smethod_12((Control)(object)Label8, new Size(77, 28));
					num = (int)((num2 * 627074133) ^ 0x4F279E9A);
					continue;
				case 72u:
					num = ((int)num2 * -1911518787) ^ -1209224548;
					continue;
				case 71u:
					SearchPatient.smethod_10((Control)(object)TextBox3, new Point(124, 43));
					num = ((int)num2 * -991436822) ^ 0x459C081F;
					continue;
				case 70u:
					num = (int)((num2 * 1965922917) ^ 0x3E26190C);
					continue;
				case 69u:
					SearchPatient.smethod_23(GroupBox2, bool_0: false);
					num = (int)((num2 * 1173191471) ^ 0x3791BEF8);
					continue;
				case 68u:
					SearchPatient.smethod_17((Control)(object)Button2, SearchPatient.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					SearchPatient.smethod_10((Control)(object)Button2, new Point(779, 526));
					num = ((int)num2 * -46836715) ^ 0x262B6370;
					continue;
				case 67u:
					SearchPatient.smethod_25((ButtonBase)(object)Button2, "Update ");
					num = (int)((num2 * 1731328294) ^ 0x2AF91A6B);
					continue;
				case 66u:
					num = ((int)num2 * -33285623) ^ 0x20EEA32E;
					continue;
				case 65u:
					SearchPatient.smethod_12((Control)(object)Label9, new Size(77, 28));
					num = (int)(num2 * 886792185) ^ -1012444478;
					continue;
				case 64u:
					num = (int)(num2 * 2130534102) ^ -1314808708;
					continue;
				case 63u:
					SearchPatient.smethod_18((Control)(object)Label5, 1);
					num = ((int)num2 * -881307305) ^ 0x5BCF738A;
					continue;
				case 62u:
					num = (int)(num2 * 2036397271) ^ -1143602165;
					continue;
				case 61u:
					SearchPatient.smethod_18((Control)(object)Label1, 10);
					num = ((int)num2 * -994298629) ^ 0x4C8357F8;
					continue;
				case 60u:
					SearchPatient.smethod_40((Control)(object)this, bool_0: false);
					num = ((int)num2 * -1537683607) ^ -1437356561;
					continue;
				case 59u:
					SearchPatient.smethod_19(Label6, "Gender : ");
					num = (int)(num2 * 1844253761) ^ -1071144814;
					continue;
				case 58u:
					num = (int)((num2 * 954599788) ^ 0x1DDD482D);
					continue;
				case 57u:
					SearchPatient.smethod_10((Control)(object)Label4, new Point(20, 46));
					num = ((int)num2 * -1800032698) ^ 0x4B4C294B;
					continue;
				case 56u:
					SearchPatient.smethod_11((Control)(object)DataGridView1, "DataGridView1");
					num = (int)(num2 * 2144691312) ^ -1699082944;
					continue;
				case 55u:
					SearchPatient.smethod_11((Control)(object)Label7, "Label7");
					num = ((int)num2 * -1955418617) ^ 0x1A32A6FD;
					continue;
				case 54u:
					SearchPatient.smethod_37((ISupportInitialize)PictureBox1);
					num = ((int)num2 * -130484468) ^ 0x8DD474D;
					continue;
				case 53u:
					SearchPatient.smethod_10((Control)(object)TextBox5, new Point(504, 125));
					SearchPatient.smethod_11((Control)(object)TextBox5, "TextBox5");
					SearchPatient.smethod_30((TextBoxBase)(object)TextBox5, bool_0: true);
					num = (int)(num2 * 1872365986) ^ -751272168;
					continue;
				case 52u:
					num = ((int)num2 * -1937713446) ^ -1735806794;
					continue;
				case 51u:
					SearchPatient.smethod_27(DataGridView1, (DataGridViewColumnHeadersHeightSizeMode)2);
					num = (int)(num2 * 187073941) ^ -1698693058;
					continue;
				case 50u:
					SearchPatient.smethod_20(Label3, (ContentAlignment)32);
					num = (int)((num2 * 1916168418) ^ 0x5CC37247);
					continue;
				case 49u:
					num = ((int)num2 * -1354279298) ^ -664696856;
					continue;
				case 48u:
					num = ((int)num2 * -390234522) ^ -1658947199;
					continue;
				case 47u:
					SearchPatient.smethod_25((ButtonBase)(object)Button3, "Clear");
					num = (int)(num2 * 498840775) ^ -19524466;
					continue;
				case 46u:
					num = (int)(num2 * 557527649) ^ -1585015059;
					continue;
				case 45u:
					num = (int)((num2 * 274348327) ^ 0x7B0E0A6);
					continue;
				case 44u:
					num = ((int)num2 * -1148604642) ^ -517558837;
					continue;
				case 43u:
					num = ((int)num2 * -992548587) ^ -88073585;
					continue;
				case 42u:
					SearchPatient.smethod_17((Control)(object)Label7, SearchPatient.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 2114201021) ^ 0x5D566A14);
					continue;
				case 41u:
					SearchPatient.smethod_18((Control)(object)TextBox2, 2);
					SearchPatient.smethod_10((Control)(object)TextBox1, new Point(120, 44));
					num = ((int)num2 * -976634187) ^ -1424133878;
					continue;
				case 40u:
					SearchPatient.smethod_12((Control)(object)Label1, new Size(330, 47));
					num = (int)(num2 * 174972693) ^ -719019114;
					continue;
				case 39u:
					num = (int)((num2 * 731041028) ^ 0x28A9C308);
					continue;
				case 38u:
					SearchPatient.smethod_22(SearchPatient.smethod_34((Control)(object)this), (Control)(object)PictureBox1);
					num = ((int)num2 * -976284578) ^ -443984609;
					continue;
				case 37u:
					SearchPatient.smethod_18((Control)(object)TextBox6, 7);
					num = ((int)num2 * -783986678) ^ -739216480;
					continue;
				case 36u:
					num = (int)(num2 * 1254648811) ^ -1208132658;
					continue;
				case 35u:
					SearchPatient.smethod_11((Control)(object)Button2, "Button2");
					num = ((int)num2 * -1316355850) ^ 0x179816ED;
					continue;
				case 34u:
					SearchPatient.smethod_11((Control)(object)Label8, "Label8");
					num = (int)(num2 * 1985819715) ^ -1285656080;
					continue;
				case 33u:
					Button3 = SearchPatient.smethod_4();
					Button4 = SearchPatient.smethod_4();
					SearchPatient.smethod_7((ISupportInitialize)PictureBox1);
					num = (int)(num2 * 1189060094) ^ -1941212075;
					continue;
				case 32u:
					num = ((int)num2 * -1812092362) ^ -1923149801;
					continue;
				case 31u:
					num = (int)((num2 * 528022939) ^ 0x26F9716E);
					continue;
				case 30u:
					num = (int)((num2 * 695832806) ^ 0x23411618);
					continue;
				case 29u:
					GroupBox1 = SearchPatient.smethod_3();
					num = ((int)num2 * -1875760623) ^ -45410602;
					continue;
				case 28u:
					TextBox1 = SearchPatient.smethod_5();
					num = (int)(num2 * 36471773) ^ -145488452;
					continue;
				case 27u:
					SearchPatient.smethod_24(GroupBox1, "Search Patient");
					num = ((int)num2 * -967180261) ^ 0x3B963863;
					continue;
				case 26u:
					num = (int)((num2 * 328826297) ^ 0x433D6A09);
					continue;
				case 25u:
					SearchPatient.smethod_18((Control)(object)TextBox5, 6);
					SearchPatient.smethod_10((Control)(object)TextBox4, new Point(504, 88));
					SearchPatient.smethod_11((Control)(object)TextBox4, "TextBox4");
					num = ((int)num2 * -1791686290) ^ 0x78DC7D2E;
					continue;
				case 24u:
					SearchPatient.smethod_11((Control)(object)Label5, "Label5");
					num = (int)(num2 * 124450497) ^ -1242024413;
					continue;
				case 23u:
					SearchPatient.smethod_17((Control)(object)GroupBox2, SearchPatient.smethod_16("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -820540889) ^ -2042330843;
					continue;
				case 22u:
					num = (int)(num2 * 1628435995) ^ -1415422402;
					continue;
				case 21u:
					SearchPatient.smethod_18((Control)(object)Label3, 3);
					num = ((int)num2 * -268034433) ^ 0x711EA380;
					continue;
				case 20u:
					SearchPatient.smethod_17((Control)(object)Label4, SearchPatient.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -915495652) ^ 0x386C9DBF;
					continue;
				case 19u:
					SearchPatient.smethod_11((Control)(object)PictureBox1, "PictureBox1");
					num = ((int)num2 * -1958463109) ^ 0x72F88173;
					continue;
				case 18u:
					SearchPatient.smethod_15(PictureBox1, bool_0: false);
					SearchPatient.smethod_17((Control)(object)Label1, SearchPatient.smethod_16("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 365513608) ^ 0x763CBCBA);
					continue;
				case 17u:
					SearchPatient.smethod_10((Control)(object)TextBox2, new Point(120, 94));
					num = ((int)num2 * -53162806) ^ 0x7060773F;
					continue;
				case 16u:
					SearchPatient.smethod_37((ISupportInitialize)DataGridView1);
					num = (int)((num2 * 2061341611) ^ 0x1234C4);
					continue;
				case 15u:
					SearchPatient.smethod_26((ButtonBase)(object)Button4, bool_0: true);
					num = (int)((num2 * 1377204695) ^ 0x79D988B4);
					continue;
				case 14u:
					SearchPatient.smethod_20(Label1, (ContentAlignment)32);
					num = ((int)num2 * -227801951) ^ -307815002;
					continue;
				case 13u:
					num = ((int)num2 * -868295345) ^ -1855472543;
					continue;
				case 12u:
					SearchPatient.smethod_30((TextBoxBase)(object)TextBox3, bool_0: true);
					num = ((int)num2 * -1125365518) ^ -1660789018;
					continue;
				case 11u:
					SearchPatient.smethod_14(PictureBox1, 9);
					num = ((int)num2 * -578085208) ^ -187404753;
					continue;
				case 10u:
					SearchPatient.smethod_22(SearchPatient.smethod_21((Control)(object)GroupBox1), (Control)(object)Button1);
					SearchPatient.smethod_22(SearchPatient.smethod_21((Control)(object)GroupBox1), (Control)(object)Label3);
					num = ((int)num2 * -1334537527) ^ 0xED3EE5B;
					continue;
				case 9u:
					num = ((int)num2 * -517136254) ^ -1306279168;
					continue;
				case 8u:
					num = (int)((num2 * 2060865965) ^ 0x596767A6);
					continue;
				case 7u:
					SearchPatient.smethod_19(Label4, "PID :");
					num = ((int)num2 * -310292299) ^ -2145728506;
					continue;
				case 6u:
					SearchPatient.smethod_22(SearchPatient.smethod_21((Control)(object)GroupBox2), (Control)(object)Label9);
					SearchPatient.smethod_22(SearchPatient.smethod_21((Control)(object)GroupBox2), (Control)(object)TextBox7);
					num = ((int)num2 * -1244738367) ^ -1018767038;
					continue;
				case 5u:
					num = (int)((num2 * 806370524) ^ 0x59F0868C);
					continue;
				case 4u:
					SearchPatient.smethod_22(SearchPatient.smethod_21((Control)(object)GroupBox1), (Control)(object)TextBox2);
					num = ((int)num2 * -746263578) ^ -922477842;
					continue;
				case 3u:
					num = ((int)num2 * -423215138) ^ -1921774414;
					continue;
				case 2u:
					SearchPatient.smethod_26((ButtonBase)(object)Button2, bool_0: true);
					num = (int)(num2 * 1205069575) ^ -513551061;
					continue;
				case 1u:
					num = ((int)num2 * -1036956284) ^ 0x1D5AB17;
					continue;
				case 0u:
					SearchPatient.smethod_38((Control)(object)GroupBox1, bool_0: false);
					num = (int)(num2 * 1333054496) ^ -203745672;
					continue;
				default:
					return;
				case 82u:
					break;
				case 202u:
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
