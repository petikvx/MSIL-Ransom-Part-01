using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hospital_Management_System.My;
using Hospital_Management_System.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

namespace Hospital_Management_System;

[DesignerGenerated]
public class BloodAvailability : UserControl
{
	private IContainer components;

	private OleDbConnection myconnection;

	private string blood_group;

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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("BloodGrpTxt")]
	internal virtual ComboBox BloodGrpTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button SearchBtn
	{
		[CompilerGenerated]
		get
		{
			return _SearchBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = Button1_Click;
			Button searchBtn = _SearchBtn;
			if (searchBtn != null)
			{
				goto IL_0056;
			}
			goto IL_00b4;
			IL_00b4:
			_SearchBtn = value;
			int num = -1274816800;
			goto IL_0087;
			IL_0087:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC0942116u) % 7u)
				{
				case 6u:
					BloodAvailability.smethod_57((Control)(object)searchBtn, eventHandler_);
					num = (int)(num2 * 1462265776) ^ -380689987;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (searchBtn == null)
					{
						num3 = 1177095110;
						num4 = 1177095110;
					}
					else
					{
						num3 = 585731481;
						num4 = 585731481;
					}
					num = num3 ^ (int)(num2 * 1212727676);
					continue;
				}
				case 4u:
					break;
				case 3u:
					BloodAvailability.smethod_58((Control)(object)searchBtn, eventHandler_);
					num = (int)(num2 * 1918977211) ^ -339149837;
					continue;
				case 0u:
					searchBtn = _SearchBtn;
					num = ((int)num2 * -730914286) ^ 0x792A4E9E;
					continue;
				default:
					return;
				case 1u:
					goto IL_00b4;
				case 2u:
					return;
				}
				break;
			}
			goto IL_0056;
			IL_0056:
			num = -478477402;
			goto IL_0087;
		}
	}

	[field: AccessedThroughProperty("AmountLbl")]
	internal virtual Label AmountLbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ValueLbl")]
	internal virtual Label ValueLbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button DonorListBtn
	{
		[CompilerGenerated]
		get
		{
			return _DonorListBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = Button2_Click;
			Button donorListBtn = _DonorListBtn;
			if (donorListBtn != null)
			{
				goto IL_006c;
			}
			goto IL_009a;
			IL_009a:
			_DonorListBtn = value;
			donorListBtn = _DonorListBtn;
			int num = 491163332;
			goto IL_0071;
			IL_0071:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x40C54CC9u) % 6u)
				{
				case 5u:
				{
					int num3;
					int num4;
					if (donorListBtn != null)
					{
						num3 = 513378035;
						num4 = 513378035;
					}
					else
					{
						num3 = 732566543;
						num4 = 732566543;
					}
					num = num3 ^ ((int)num2 * -905148446);
					continue;
				}
				case 4u:
					BloodAvailability.smethod_58((Control)(object)donorListBtn, eventHandler_);
					num = (int)(num2 * 318935555) ^ -2060902731;
					continue;
				case 3u:
					BloodAvailability.smethod_57((Control)(object)donorListBtn, eventHandler_);
					num = (int)((num2 * 2075283127) ^ 0x454ECAC9);
					continue;
				case 0u:
					break;
				default:
					return;
				case 1u:
					goto IL_009a;
				case 2u:
					return;
				}
				break;
			}
			goto IL_006c;
			IL_006c:
			num = 1681043908;
			goto IL_0071;
		}
	}

	[field: AccessedThroughProperty("SearchResultGrid")]
	internal virtual DataGridView SearchResultGrid
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SuccessMsg")]
	internal virtual Label SuccessMsg
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Timer1")]
	internal virtual Timer Timer1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button UpdateBtn
	{
		[CompilerGenerated]
		get
		{
			return _UpdateBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = UpdateBtn_Click;
			Button updateBtn = default(Button);
			while (true)
			{
				int num = 754400911;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x73E0D39Au) % 8u)
					{
					case 6u:
						BloodAvailability.smethod_58((Control)(object)updateBtn, eventHandler_);
						num = ((int)num2 * -1173853334) ^ 0x410A71C1;
						continue;
					case 5u:
						updateBtn = _UpdateBtn;
						num = (int)(num2 * 205428203) ^ -682973914;
						continue;
					case 4u:
						_UpdateBtn = value;
						updateBtn = _UpdateBtn;
						num = 1240629664;
						continue;
					case 3u:
					{
						int num5;
						int num6;
						if (updateBtn != null)
						{
							num5 = -2107887602;
							num6 = -2107887602;
						}
						else
						{
							num5 = -1603867813;
							num6 = -1603867813;
						}
						num = num5 ^ ((int)num2 * -1420946049);
						continue;
					}
					case 2u:
					{
						int num3;
						int num4;
						if (updateBtn != null)
						{
							num3 = -933503186;
							num4 = -933503186;
						}
						else
						{
							num3 = -429004889;
							num4 = -429004889;
						}
						num = num3 ^ ((int)num2 * -1406480855);
						continue;
					}
					case 1u:
						BloodAvailability.smethod_57((Control)(object)updateBtn, eventHandler_);
						num = (int)(num2 * 233127767) ^ -178001383;
						continue;
					default:
						return;
					case 0u:
						break;
					case 7u:
						return;
					}
					break;
				}
			}
		}
	}

	public BloodAvailability()
	{
		BloodAvailability.smethod_0((UserControl)(object)this, (EventHandler)BloodAvailability_Load);
		myconnection = BloodAvailability.smethod_1();
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (!disposing)
			{
				goto IL_000a;
			}
			goto IL_001e;
			IL_001e:
			int num = -1036213541;
			goto IL_004c;
			IL_004c:
			int num3;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA744A31Cu) % 6u)
				{
				case 5u:
					num = -491737758;
					continue;
				case 4u:
					break;
				case 3u:
					num = ((int)num2 * -63145744) ^ -1716331563;
					continue;
				case 2u:
					BloodAvailability.smethod_2((IDisposable)components);
					num = (int)(num2 * 1608472154) ^ -888647373;
					continue;
				default:
					return;
				case 1u:
					goto IL_0075;
				case 0u:
					return;
				}
				break;
				IL_0075:
				if (components != null)
				{
					num = -558515988;
					num3 = -558515988;
					continue;
				}
				goto IL_000a;
			}
			goto IL_001e;
			IL_000a:
			num = -1405908539;
			num3 = -1405908539;
			goto IL_004c;
		}
		finally
		{
			((ContainerControl)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		while (true)
		{
			int num = -1488686003;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF2CC06B1u) % 176u)
				{
				case 175u:
					BloodAvailability.smethod_20(Label1, "Blood Availability");
					num = (int)(num2 * 1626153839) ^ -1208653763;
					continue;
				case 174u:
					BloodAvailability.smethod_55((Control)(object)this, bool_0: false);
					num = ((int)num2 * -258703690) ^ -82360295;
					continue;
				case 173u:
					BloodAvailability.smethod_23(BloodAvailability.smethod_50((Control)(object)this), (Control)(object)UpdateBtn);
					num = ((int)num2 * -909786059) ^ -1062272729;
					continue;
				case 172u:
					BloodAvailability.smethod_17((Control)(object)AmountLbl, "AmountLbl");
					BloodAvailability.smethod_18((Control)(object)AmountLbl, new Size(131, 35));
					BloodAvailability.smethod_19((Control)(object)AmountLbl, 13);
					num = (int)((num2 * 1019259049) ^ 0x605BAABE);
					continue;
				case 171u:
					num = ((int)num2 * -313041458) ^ 0x498B3DA5;
					continue;
				case 170u:
					num = (int)((num2 * 643694041) ^ 0x4D55E94F);
					continue;
				case 169u:
					BloodAvailability.smethod_18((Control)(object)SearchResultGrid, new Size(739, 296));
					num = ((int)num2 * -1241581624) ^ 0x50A809BE;
					continue;
				case 168u:
					SuccessMsg = BloodAvailability.smethod_4();
					Timer1 = BloodAvailability.smethod_9(components);
					num = (int)(num2 * 1369563894) ^ -1171497026;
					continue;
				case 167u:
					BloodAvailability.smethod_23(BloodAvailability.smethod_50((Control)(object)this), (Control)(object)ValueLbl);
					BloodAvailability.smethod_23(BloodAvailability.smethod_50((Control)(object)this), (Control)(object)AmountLbl);
					BloodAvailability.smethod_23(BloodAvailability.smethod_50((Control)(object)this), (Control)(object)GroupBox1);
					num = ((int)num2 * -1595241868) ^ -826123399;
					continue;
				case 166u:
					BloodAvailability.smethod_15((Control)(object)GroupBox1, BloodAvailability.smethod_14("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1394120565) ^ 0x6CD1AF64);
					continue;
				case 165u:
					BloodAvailability.smethod_15((Control)(object)Label1, BloodAvailability.smethod_14("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					BloodAvailability.smethod_16((Control)(object)Label1, new Point(392, 63));
					num = (int)((num2 * 2058671494) ^ 0x38A26DA7);
					continue;
				case 164u:
					num = ((int)num2 * -1116054597) ^ -1647839704;
					continue;
				case 163u:
					BloodAvailability.smethod_17((Control)(object)BloodGrpTxt, "BloodGrpTxt");
					BloodAvailability.smethod_18((Control)(object)BloodGrpTxt, new Size(108, 26));
					num = (int)(num2 * 267097187) ^ -1895393430;
					continue;
				case 162u:
					BloodAvailability.smethod_23(BloodAvailability.smethod_50((Control)(object)this), (Control)(object)DonorListBtn);
					num = (int)((num2 * 1772933771) ^ 0x119FF450);
					continue;
				case 161u:
					BloodAvailability.smethod_40(BloodAvailability.smethod_39(SearchResultGrid), 24);
					num = ((int)num2 * -812162151) ^ -165855775;
					continue;
				case 160u:
					num = (int)((num2 * 1808631700) ^ 0x49F9EC32);
					continue;
				case 159u:
					BloodAvailability.smethod_37(SearchResultGrid, (DataGridViewColumnHeadersHeightSizeMode)2);
					num = (int)(num2 * 1443265283) ^ -334888278;
					continue;
				case 158u:
					Label2 = BloodAvailability.smethod_4();
					num = ((int)num2 * -1155475739) ^ 0x4EB68356;
					continue;
				case 157u:
					num = ((int)num2 * -175757032) ^ -1442047417;
					continue;
				case 156u:
					BloodAvailability.smethod_35((Control)(object)ValueLbl, Color.FromArgb(0, 192, 0));
					num = ((int)num2 * -1752887109) ^ -1028577035;
					continue;
				case 155u:
					BloodAvailability.smethod_19((Control)(object)UpdateBtn, 29);
					num = ((int)num2 * -260896984) ^ -80370366;
					continue;
				case 154u:
					num = ((int)num2 * -1941389623) ^ -1974607004;
					continue;
				case 153u:
					num = (int)((num2 * 1749088409) ^ 0x3E4F28D6);
					continue;
				case 152u:
					num = ((int)num2 * -175290044) ^ 0x274F5E1B;
					continue;
				case 151u:
					num = ((int)num2 * -156794197) ^ -1782842698;
					continue;
				case 150u:
					num = (int)((num2 * 750725700) ^ 0x1431BF1F);
					continue;
				case 149u:
					BloodAvailability.smethod_18((Control)(object)Label2, new Size(135, 32));
					num = (int)((num2 * 1876525917) ^ 0xDD7F5A);
					continue;
				case 148u:
					num = ((int)num2 * -765690606) ^ 0x7E067389;
					continue;
				case 147u:
					num = (int)(num2 * 1320337811) ^ -406207912;
					continue;
				case 146u:
					BloodAvailability.smethod_49((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -1989549049) ^ 0x1EE82F6B;
					continue;
				case 145u:
					num = ((int)num2 * -1589927169) ^ 0x1A6F2B71;
					continue;
				case 144u:
					num = ((int)num2 * -1309489424) ^ -1310730230;
					continue;
				case 143u:
					BloodAvailability.smethod_19((Control)(object)Label1, 11);
					num = ((int)num2 * -2109416607) ^ -14171676;
					continue;
				case 142u:
					BloodAvailability.smethod_16((Control)(object)PictureBox1, new Point(272, 25));
					num = ((int)num2 * -1972416786) ^ -579986248;
					continue;
				case 141u:
					num = ((int)num2 * -1969520165) ^ 0x27F45AFE;
					continue;
				case 140u:
					BloodAvailability.smethod_21(SuccessMsg, (ContentAlignment)32);
					num = (int)(num2 * 1972031801) ^ -584787402;
					continue;
				case 139u:
					BloodAvailability.smethod_16((Control)(object)Label2, new Point(87, 36));
					BloodAvailability.smethod_17((Control)(object)Label2, "Label2");
					num = (int)(num2 * 1582128044) ^ -55053295;
					continue;
				case 138u:
					num = ((int)num2 * -888091906) ^ 0x54296692;
					continue;
				case 137u:
					BloodAvailability.smethod_26((ButtonBase)(object)UpdateBtn, Color.MidnightBlue);
					num = (int)((num2 * 411980109) ^ 0x410C8574);
					continue;
				case 136u:
					num = (int)(num2 * 1399569520) ^ -1664096647;
					continue;
				case 135u:
					BloodAvailability.smethod_27((Control)(object)SearchBtn, Color.White);
					num = (int)(num2 * 1194780434) ^ -738052164;
					continue;
				case 134u:
					num = ((int)num2 * -1387194920) ^ -719445687;
					continue;
				case 133u:
					num = ((int)num2 * -1332653880) ^ 0x3438B46E;
					continue;
				case 132u:
					BloodAvailability.smethod_29((ButtonBase)(object)SearchBtn, bool_0: false);
					num = (int)(num2 * 1579506859) ^ -741130175;
					continue;
				case 131u:
					BloodAvailability.smethod_16((Control)(object)SearchBtn, new Point(183, 91));
					num = (int)(num2 * 806586652) ^ -1445045963;
					continue;
				case 130u:
					BloodAvailability.smethod_15((Control)(object)SearchBtn, BloodAvailability.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -163513375) ^ -946609932;
					continue;
				case 129u:
					AmountLbl = BloodAvailability.smethod_4();
					num = ((int)num2 * -250686401) ^ -1141629156;
					continue;
				case 128u:
					BloodAvailability.smethod_15((Control)(object)ValueLbl, BloodAvailability.smethod_14("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1982806260) ^ -953341195;
					continue;
				case 127u:
					BloodAvailability.smethod_52((Control)(object)this, new Size(977, 804));
					BloodAvailability.smethod_53((Control)(object)GroupBox1, bool_0: false);
					BloodAvailability.smethod_54((ISupportInitialize)SearchResultGrid);
					num = ((int)num2 * -1204775538) ^ -1885965097;
					continue;
				case 126u:
					num = (int)(num2 * 2001185678) ^ -1346480391;
					continue;
				case 125u:
					BloodAvailability.smethod_21(Label1, (ContentAlignment)32);
					num = ((int)num2 * -1588945185) ^ -1706330039;
					continue;
				case 124u:
					BloodAvailability.smethod_15((Control)(object)DonorListBtn, BloodAvailability.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1131498580) ^ -1287190616;
					continue;
				case 123u:
					BloodAvailability.smethod_41((Control)(object)SuccessMsg, bool_0: false);
					BloodAvailability.smethod_43(Timer1, 1500);
					num = ((int)num2 * -1029446358) ^ -329035739;
					continue;
				case 122u:
					BloodAvailability.smethod_23(BloodAvailability.smethod_50((Control)(object)this), (Control)(object)SuccessMsg);
					num = ((int)num2 * -1244795266) ^ 0x1406DDA1;
					continue;
				case 121u:
					num = (int)((num2 * 346967044) ^ 0x6CA2238A);
					continue;
				case 120u:
					BloodAvailability.smethod_24(GroupBox1, bool_0: false);
					num = ((int)num2 * -219958450) ^ 0x1416C6AB;
					continue;
				case 119u:
					BloodAvailability.smethod_56((Control)(object)this);
					num = ((int)num2 * -1169612895) ^ -1310456133;
					continue;
				case 118u:
					PictureBox1 = BloodAvailability.smethod_10();
					num = (int)(num2 * 429270432) ^ -126826665;
					continue;
				case 117u:
					BloodAvailability.smethod_17((Control)(object)UpdateBtn, "UpdateBtn");
					num = ((int)num2 * -1718030713) ^ 0x4D59DF76;
					continue;
				case 116u:
					BloodAvailability.smethod_54((ISupportInitialize)PictureBox1);
					num = (int)(num2 * 925373882) ^ -1265660297;
					continue;
				case 115u:
					GroupBox1 = BloodAvailability.smethod_5();
					num = ((int)num2 * -1912914011) ^ 0x684C293F;
					continue;
				case 114u:
					num = (int)(num2 * 1611455709) ^ -475717723;
					continue;
				case 113u:
					BloodAvailability.smethod_19((Control)(object)SearchBtn, 22);
					num = ((int)num2 * -557677106) ^ 0x372821F6;
					continue;
				case 112u:
					BloodAvailability.smethod_35((Control)(object)this, Color.White);
					num = (int)(num2 * 1543162998) ^ -718316628;
					continue;
				case 111u:
					BloodAvailability.smethod_47(PictureBox1, bool_0: false);
					num = ((int)num2 * -1478254322) ^ 0x15EE171B;
					continue;
				case 109u:
					BloodAvailability.smethod_17((Control)(object)ValueLbl, "ValueLbl");
					BloodAvailability.smethod_18((Control)(object)ValueLbl, new Size(64, 24));
					num = ((int)num2 * -1506077484) ^ 0x29516796;
					continue;
				case 108u:
					num = (int)(num2 * 432888199) ^ -1468116638;
					continue;
				case 107u:
					BloodAvailability.smethod_16((Control)(object)GroupBox1, new Point(232, 214));
					num = ((int)num2 * -912063386) ^ -23392502;
					continue;
				case 106u:
					BloodAvailability.smethod_25(GroupBox1, "Search");
					num = (int)((num2 * 536051669) ^ 0x5B51FFC4);
					continue;
				case 105u:
					num = (int)(num2 * 1967948820) ^ -419444695;
					continue;
				case 104u:
					BloodAvailability.smethod_20(SuccessMsg, "Label5");
					num = ((int)num2 * -1758460644) ^ -358230321;
					continue;
				case 103u:
					BloodAvailability.smethod_17((Control)(object)SuccessMsg, "SuccessMsg");
					num = ((int)num2 * -718306267) ^ 0x22A0FF77;
					continue;
				case 102u:
					BloodAvailability.smethod_23(BloodAvailability.smethod_50((Control)(object)this), (Control)(object)PictureBox1);
					num = ((int)num2 * -463551606) ^ 0x46DABB15;
					continue;
				case 101u:
					num = ((int)num2 * -988312700) ^ 0x70B7B31;
					continue;
				case 100u:
					BloodAvailability.smethod_18((Control)(object)PictureBox1, new Size(114, 113));
					num = ((int)num2 * -711315278) ^ -1851144337;
					continue;
				case 99u:
					BloodGrpTxt = BloodAvailability.smethod_7();
					num = ((int)num2 * -236472304) ^ -2050841949;
					continue;
				case 98u:
					BloodAvailability.smethod_19((Control)(object)BloodGrpTxt, 21);
					num = ((int)num2 * -1801049123) ^ 0x52871C20;
					continue;
				case 97u:
					SearchBtn = BloodAvailability.smethod_6();
					num = ((int)num2 * -934487052) ^ -1855722999;
					continue;
				case 96u:
					BloodAvailability.smethod_17((Control)(object)PictureBox1, "PictureBox1");
					num = (int)((num2 * 1486194172) ^ 0x4E83003B);
					continue;
				case 95u:
					num = ((int)num2 * -1616662016) ^ -1771465389;
					continue;
				case 94u:
					BloodAvailability.smethod_19((Control)(object)SuccessMsg, 28);
					num = ((int)num2 * -125063229) ^ -1601294813;
					continue;
				case 93u:
					BloodAvailability.smethod_29((ButtonBase)(object)DonorListBtn, bool_0: false);
					num = (int)((num2 * 1964278826) ^ 0x1A8E778E);
					continue;
				case 92u:
					num = (int)(num2 * 1535327056) ^ -1736434389;
					continue;
				case 91u:
					num = ((int)num2 * -1838692251) ^ -448706144;
					continue;
				case 90u:
					BloodAvailability.smethod_15((Control)(object)AmountLbl, BloodAvailability.smethod_14("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					BloodAvailability.smethod_16((Control)(object)AmountLbl, new Point(299, 369));
					num = (int)(num2 * 1037540098) ^ -441288487;
					continue;
				case 89u:
					BloodAvailability.smethod_17((Control)(object)GroupBox1, "GroupBox1");
					num = ((int)num2 * -1299811185) ^ 0x1011E78F;
					continue;
				case 88u:
					BloodAvailability.smethod_51((Control)(object)this, "BloodAvailability");
					num = ((int)num2 * -274112298) ^ 0x3C7F29DB;
					continue;
				case 87u:
					num = (int)((num2 * 1400504088) ^ 0xA3DCE9E);
					continue;
				case 86u:
					BloodAvailability.smethod_46(PictureBox1, 10);
					num = ((int)num2 * -1971004202) ^ 0x4B14F194;
					continue;
				case 85u:
					num = (int)((num2 * 1907671624) ^ 0x5081877C);
					continue;
				case 84u:
					BloodAvailability.smethod_23(BloodAvailability.smethod_50((Control)(object)this), (Control)(object)SearchResultGrid);
					num = ((int)num2 * -831111306) ^ -1401381861;
					continue;
				case 83u:
					BloodAvailability.smethod_17((Control)(object)SearchBtn, "SearchBtn");
					num = ((int)num2 * -86374183) ^ 0x255892FA;
					continue;
				case 82u:
					num = ((int)num2 * -323279305) ^ -1395374559;
					continue;
				case 81u:
					num = (int)(num2 * 1186752975) ^ -240101660;
					continue;
				case 80u:
					BloodAvailability.smethod_12((ISupportInitialize)SearchResultGrid);
					num = ((int)num2 * -652413173) ^ 0x5A5FB824;
					continue;
				case 79u:
					SearchResultGrid = BloodAvailability.smethod_8();
					num = (int)((num2 * 1065425031) ^ 0x6C2CB870);
					continue;
				case 78u:
					BloodAvailability.smethod_41((Control)(object)SearchResultGrid, bool_0: false);
					num = (int)((num2 * 1615513424) ^ 0x6CAF63D0);
					continue;
				case 77u:
					BloodAvailability.smethod_31((ListControl)(object)BloodGrpTxt, bool_0: true);
					num = ((int)num2 * -737481036) ^ 0x39A134FB;
					continue;
				case 76u:
					components = BloodAvailability.smethod_3();
					Label1 = BloodAvailability.smethod_4();
					num = (int)((num2 * 881417141) ^ 0x5375502E);
					continue;
				case 75u:
					BloodAvailability.smethod_28((ButtonBase)(object)UpdateBtn, "Update Blood Amount");
					BloodAvailability.smethod_29((ButtonBase)(object)UpdateBtn, bool_0: false);
					num = (int)((num2 * 1001138326) ^ 0x69115296);
					continue;
				case 74u:
					BloodAvailability.smethod_17((Control)(object)Label1, "Label1");
					num = ((int)num2 * -965024413) ^ -1112569018;
					continue;
				case 73u:
					BloodAvailability.smethod_27((Control)(object)DonorListBtn, Color.White);
					num = (int)((num2 * 1228911775) ^ 0x2E98F77B);
					continue;
				case 72u:
					BloodAvailability.smethod_16((Control)(object)SuccessMsg, new Point(281, 141));
					num = ((int)num2 * -176418852) ^ 0x680D0CF6;
					continue;
				case 71u:
					BloodAvailability.smethod_26((ButtonBase)(object)SearchBtn, Color.MidnightBlue);
					num = ((int)num2 * -2137986176) ^ -1599281677;
					continue;
				case 70u:
					BloodAvailability.smethod_15((Control)(object)UpdateBtn, BloodAvailability.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1764308554) ^ 0x726E840;
					continue;
				case 69u:
					BloodAvailability.smethod_27((Control)(object)UpdateBtn, Color.White);
					num = ((int)num2 * -2076106826) ^ 0x56E92CBE;
					continue;
				case 68u:
					BloodAvailability.smethod_26((ButtonBase)(object)DonorListBtn, Color.MidnightBlue);
					num = ((int)num2 * -669847138) ^ 0x3BA576B5;
					continue;
				case 67u:
					BloodAvailability.smethod_17((Control)(object)SearchResultGrid, "SearchResultGrid");
					BloodAvailability.smethod_38(SearchResultGrid, bool_0: true);
					num = (int)(num2 * 1788466116) ^ -2013418942;
					continue;
				case 66u:
					BloodAvailability.smethod_28((ButtonBase)(object)SearchBtn, "Search");
					num = (int)(num2 * 1795697022) ^ -236075815;
					continue;
				case 65u:
					BloodAvailability.smethod_18((Control)(object)SuccessMsg, new Size(401, 44));
					num = ((int)num2 * -756412711) ^ 0x7ECD7BD3;
					continue;
				case 64u:
					BloodAvailability.smethod_23(BloodAvailability.smethod_22((Control)(object)GroupBox1), (Control)(object)SearchBtn);
					BloodAvailability.smethod_23(BloodAvailability.smethod_22((Control)(object)GroupBox1), (Control)(object)BloodGrpTxt);
					num = ((int)num2 * -729094145) ^ -922314979;
					continue;
				case 63u:
					BloodAvailability.smethod_16((Control)(object)ValueLbl, new Point(436, 380));
					num = (int)(num2 * 1356604991) ^ -1969136483;
					continue;
				case 62u:
					num = ((int)num2 * -361521177) ^ -2064009413;
					continue;
				case 61u:
					BloodAvailability.smethod_15((Control)(object)SuccessMsg, BloodAvailability.smethod_42("MS Reference Sans Serif", 10.8f, (FontStyle)1));
					num = (int)(num2 * 2066089419) ^ -451408602;
					continue;
				case 60u:
					BloodAvailability.smethod_20(ValueLbl, "litres");
					num = (int)((num2 * 2122808532) ^ 0x633A11D3);
					continue;
				case 58u:
					BloodAvailability.smethod_30(BloodGrpTxt, (ComboBoxStyle)2);
					num = ((int)num2 * -2078076922) ^ 0x17147AF2;
					continue;
				case 57u:
					BloodAvailability.smethod_18((Control)(object)GroupBox1, new Size(490, 137));
					num = (int)(num2 * 1037951927) ^ -309398516;
					continue;
				case 56u:
					BloodAvailability.smethod_48((ContainerControl)(object)this, new SizeF(8f, 16f));
					num = (int)((num2 * 1929274528) ^ 0x6A4252C3);
					continue;
				case 55u:
					num = ((int)num2 * -1969031877) ^ 0x4A73F115;
					continue;
				case 54u:
					num = ((int)num2 * -5687791) ^ 0x64DD4715;
					continue;
				case 53u:
					BloodAvailability.smethod_12((ISupportInitialize)PictureBox1);
					BloodAvailability.smethod_13((Control)(object)this);
					num = ((int)num2 * -598882418) ^ -1104183582;
					continue;
				case 52u:
					num = (int)(num2 * 1539087530) ^ -1167521098;
					continue;
				case 51u:
					BloodAvailability.smethod_19((Control)(object)ValueLbl, 14);
					num = ((int)num2 * -1016894926) ^ -601029685;
					continue;
				case 50u:
					num = ((int)num2 * -1664909952) ^ 0x418961C5;
					continue;
				case 49u:
					num = ((int)num2 * -342221426) ^ 0x6C581E01;
					continue;
				case 48u:
					num = ((int)num2 * -956530575) ^ -2011647593;
					continue;
				case 47u:
					num = (int)(num2 * 1900670549) ^ -1534245877;
					continue;
				case 46u:
					num = ((int)num2 * -1494995086) ^ 0x754465D5;
					continue;
				case 45u:
					BloodAvailability.smethod_16((Control)(object)DonorListBtn, new Point(323, 434));
					num = (int)((num2 * 1280788000) ^ 0x87D9824);
					continue;
				case 44u:
					num = ((int)num2 * -2068085817) ^ 0x33057B46;
					continue;
				case 43u:
					BloodAvailability.smethod_21(Label2, (ContentAlignment)32);
					num = ((int)num2 * -653356783) ^ 0x6914D95B;
					continue;
				case 42u:
					num = ((int)num2 * -887078153) ^ 0xF21A76E;
					continue;
				case 41u:
					BloodAvailability.smethod_19((Control)(object)SearchResultGrid, 24);
					num = ((int)num2 * -772026976) ^ 0x14CB7D70;
					continue;
				case 40u:
					num = ((int)num2 * -1032991739) ^ -1548770910;
					continue;
				case 39u:
					BloodAvailability.smethod_41((Control)(object)UpdateBtn, bool_0: false);
					num = (int)(num2 * 198737485) ^ -1240121837;
					continue;
				case 38u:
					BloodAvailability.smethod_18((Control)(object)UpdateBtn, new Size(180, 52));
					num = (int)((num2 * 978979072) ^ 0x14F55279);
					continue;
				case 37u:
					BloodAvailability.smethod_17((Control)(object)DonorListBtn, "DonorListBtn");
					num = ((int)num2 * -628141202) ^ 0x22812E80;
					continue;
				case 36u:
					BloodAvailability.smethod_23(BloodAvailability.smethod_50((Control)(object)this), (Control)(object)Label1);
					num = ((int)num2 * -1389911636) ^ 0x1D9E7267;
					continue;
				case 35u:
					num = ((int)num2 * -374636040) ^ 0x39D9F42A;
					continue;
				case 34u:
					BloodAvailability.smethod_19((Control)(object)GroupBox1, 12);
					num = ((int)num2 * -1074825032) ^ 0x530F916F;
					continue;
				case 33u:
					BloodAvailability.smethod_15((Control)(object)Label2, BloodAvailability.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -322230972) ^ -1751146955;
					continue;
				case 32u:
					BloodAvailability.smethod_18((Control)(object)SearchBtn, new Size(102, 36));
					num = (int)(num2 * 1451617092) ^ -1821024672;
					continue;
				case 31u:
					UpdateBtn = BloodAvailability.smethod_6();
					num = (int)((num2 * 154745069) ^ 0x1010BC64);
					continue;
				case 30u:
					num = (int)(num2 * 603478766) ^ -202864544;
					continue;
				case 29u:
					BloodAvailability.smethod_36(SearchResultGrid, Color.White);
					num = ((int)num2 * -74032296) ^ -1877172320;
					continue;
				case 28u:
					num = (int)(num2 * 2051408006) ^ -1517118515;
					continue;
				case 27u:
					num = ((int)num2 * -227776994) ^ 0x5AD7D14B;
					continue;
				case 26u:
					BloodAvailability.smethod_20(Label2, "Blood Group :");
					num = ((int)num2 * -238351318) ^ -150391570;
					continue;
				case 25u:
					num = ((int)num2 * -561028013) ^ -2110723016;
					continue;
				case 24u:
					BloodAvailability.smethod_21(AmountLbl, (ContentAlignment)32);
					num = (int)(num2 * 506879273) ^ -279031036;
					continue;
				case 23u:
					BloodAvailability.smethod_18((Control)(object)DonorListBtn, new Size(221, 36));
					BloodAvailability.smethod_19((Control)(object)DonorListBtn, 23);
					num = (int)(num2 * 2083907796) ^ -642721730;
					continue;
				case 22u:
					BloodAvailability.smethod_45(PictureBox1, (PictureBoxSizeMode)1);
					num = ((int)num2 * -582946082) ^ -833349581;
					continue;
				case 21u:
					BloodAvailability.smethod_33(BloodAvailability.smethod_32(BloodGrpTxt), new object[9] { "--Select--", "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
					num = (int)(num2 * 2016839155) ^ -1447179171;
					continue;
				case 20u:
					num = ((int)num2 * -751874908) ^ -495961177;
					continue;
				case 19u:
					BloodAvailability.smethod_20(AmountLbl, "Amount :");
					num = ((int)num2 * -1222572759) ^ -1418030380;
					continue;
				case 18u:
					BloodAvailability.smethod_16((Control)(object)SearchResultGrid, new Point(112, 494));
					num = ((int)num2 * -1113809456) ^ -840125902;
					continue;
				case 17u:
					BloodAvailability.smethod_16((Control)(object)UpdateBtn, new Point(735, 362));
					num = (int)((num2 * 470932243) ^ 0x7575C697);
					continue;
				case 16u:
					BloodAvailability.smethod_16((Control)(object)BloodGrpTxt, new Point(246, 40));
					num = (int)((num2 * 882184900) ^ 0x56EABEB2);
					continue;
				case 15u:
					DonorListBtn = BloodAvailability.smethod_6();
					num = ((int)num2 * -889419027) ^ -1835073043;
					continue;
				case 14u:
					BloodAvailability.smethod_21(ValueLbl, (ContentAlignment)32);
					num = (int)(num2 * 1584747356) ^ -156995924;
					continue;
				case 13u:
					BloodAvailability.smethod_34(ValueLbl, bool_0: true);
					num = (int)(num2 * 1235974708) ^ -1822781940;
					continue;
				case 12u:
					BloodAvailability.smethod_23(BloodAvailability.smethod_22((Control)(object)GroupBox1), (Control)(object)Label2);
					num = ((int)num2 * -1975140133) ^ 0x701984AE;
					continue;
				case 11u:
					num = (int)((num2 * 1523804077) ^ 0x7A1F7F7F);
					continue;
				case 10u:
					num = ((int)num2 * -153471697) ^ 0x5BF81D47;
					continue;
				case 9u:
					BloodAvailability.smethod_18((Control)(object)Label1, new Size(330, 47));
					num = (int)((num2 * 1240356548) ^ 0x24C5053A);
					continue;
				case 8u:
					BloodAvailability.smethod_11((Control)(object)GroupBox1);
					num = (int)(num2 * 1150923332) ^ -1254671;
					continue;
				case 7u:
					num = (int)((num2 * 1745410331) ^ 0x56AEDBFB);
					continue;
				case 6u:
					BloodAvailability.smethod_44(PictureBox1, (Image)(object)Resources.blood_goodpic);
					num = ((int)num2 * -1470333381) ^ 0x440BD12D;
					continue;
				case 5u:
					num = ((int)num2 * -340642433) ^ -2111908197;
					continue;
				case 4u:
					ValueLbl = BloodAvailability.smethod_4();
					num = ((int)num2 * -284925505) ^ 0xF078612;
					continue;
				case 3u:
					BloodAvailability.smethod_28((ButtonBase)(object)DonorListBtn, "See List of Donors");
					num = ((int)num2 * -360227019) ^ 0x6A377293;
					continue;
				case 2u:
					BloodAvailability.smethod_15((Control)(object)BloodGrpTxt, BloodAvailability.smethod_14("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1555202374) ^ 0xFBBA420);
					continue;
				case 1u:
					num = (int)(num2 * 1691063109) ^ -1363802647;
					continue;
				case 0u:
					BloodAvailability.smethod_19((Control)(object)Label2, 0);
					num = (int)((num2 * 1878598631) ^ 0x7CE1C34B);
					continue;
				default:
					return;
				case 59u:
					break;
				case 110u:
					return;
				}
				break;
			}
		}
	}

	private void BloodAvailability_Load(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -2001586712;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEF1A4277u) % 11u)
				{
				case 10u:
					num = (int)(num2 * 286840763) ^ -1214233774;
					continue;
				case 9u:
					num = ((int)num2 * -1476595666) ^ -108683134;
					continue;
				case 8u:
					BloodAvailability.smethod_41((Control)(object)ValueLbl, bool_0: false);
					num = (int)(num2 * 1047046725) ^ -613464963;
					continue;
				case 6u:
					BloodAvailability.smethod_41((Control)(object)DonorListBtn, bool_0: false);
					num = (int)((num2 * 1064302270) ^ 0x1C0193B7);
					continue;
				case 5u:
					BloodAvailability.smethod_20(AmountLbl, "Amount :");
					num = ((int)num2 * -1600402472) ^ 0x525837BC;
					continue;
				case 4u:
					num = ((int)num2 * -1347993549) ^ 0x4992BDEA;
					continue;
				case 2u:
					BloodAvailability.smethod_60(myconnection, BloodAvailability.smethod_59(MyProject.Forms.Form1.provider, MyProject.Forms.Form1.datafile));
					BloodAvailability.smethod_61(BloodGrpTxt, 0);
					num = ((int)num2 * -1174544004) ^ -378873083;
					continue;
				case 1u:
					num = (int)(num2 * 1404858963) ^ -1514173111;
					continue;
				case 0u:
					BloodAvailability.smethod_41((Control)(object)AmountLbl, bool_0: false);
					num = (int)(num2 * 1003126763) ^ -1212555375;
					continue;
				default:
					return;
				case 3u:
					break;
				case 7u:
					return;
				}
				break;
			}
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_0646: Unknown result type (might be due to invalid IL or missing references)
		//IL_0647: Unknown result type (might be due to invalid IL or missing references)
		//IL_064a: Expected I4, but got Unknown
		//IL_064b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0661: Expected I4, but got Unknown
		//IL_0671: Incompatible stack heights: 0 vs 1
		//IL_0686: Incompatible stack heights: 0 vs 1
		//IL_068d: Incompatible stack heights: 0 vs 1
		bool flag3 = default(bool);
		OleDbCommand oleDbCommand_ = default(OleDbCommand);
		string string_ = default(string);
		decimal num4 = default(decimal);
		bool flag = default(bool);
		bool flag2 = default(bool);
		OleDbDataReader oleDbDataReader_ = default(OleDbDataReader);
		while (true)
		{
			int num = -1959631328;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC7BC8177u) % 21u)
				{
				case 20u:
					BloodAvailability.smethod_41((Control)(object)SearchResultGrid, bool_0: false);
					num = (int)((num2 * 102705384) ^ 0x6F0C5D39);
					continue;
				case 19u:
					BloodAvailability.smethod_41((Control)(object)ValueLbl, bool_0: false);
					num = ((int)num2 * -423485532) ^ -20873049;
					continue;
				case 18u:
					BloodAvailability.smethod_67();
					num = (int)((num2 * 2024717419) ^ 0xA89946C);
					continue;
				case 17u:
					num = (int)((num2 * 1140289473) ^ 0x3EE1A0A1);
					continue;
				case 15u:
					BloodAvailability.smethod_41((Control)(object)AmountLbl, bool_0: false);
					num = ((int)num2 * -831734971) ^ 0x1237C40C;
					continue;
				case 14u:
					flag3 = BloodAvailability.smethod_62(BloodGrpTxt) == 0;
					num = (int)(num2 * 776809981) ^ -1483375891;
					continue;
				case 12u:
				{
					int num12;
					int num13;
					if (flag3)
					{
						num12 = 469920149;
						num13 = 469920149;
					}
					else
					{
						num12 = 1155660944;
						num13 = 1155660944;
					}
					num = num12 ^ ((int)num2 * -747379310);
					continue;
				}
				case 11u:
					BloodAvailability.smethod_41((Control)(object)SuccessMsg, bool_0: true);
					num = ((int)num2 * -998643144) ^ -1304963193;
					continue;
				case 10u:
					num = -729374282;
					continue;
				case 8u:
					oleDbCommand_ = BloodAvailability.smethod_64();
					string_ = BloodAvailability.smethod_66("Select * From [Blood_available] Where [Blood Group] Like '%", BloodAvailability.smethod_65(BloodGrpTxt), "%';");
					num = (int)((num2 * 847843232) ^ 0x7E23B729);
					continue;
				case 7u:
					num = (int)(num2 * 603614018) ^ -828991663;
					continue;
				case 6u:
					BloodAvailability.smethod_68(myconnection);
					num = (int)((num2 * 642061321) ^ 0x505D45A9);
					continue;
				case 5u:
					BloodAvailability.smethod_20(SuccessMsg, "Select Blood Group");
					num = (int)(num2 * 904355179) ^ -502403719;
					continue;
				case 4u:
					num = ((int)num2 * -240433932) ^ 0x112A3AEF;
					continue;
				case 3u:
					BloodAvailability.smethod_41((Control)(object)DonorListBtn, bool_0: false);
					BloodAvailability.smethod_41((Control)(object)UpdateBtn, bool_0: false);
					num = (int)((num2 * 2080023832) ^ 0x1A6BC967);
					continue;
				case 2u:
					BloodAvailability.smethod_63(Timer1);
					num = (int)(num2 * 729980786) ^ -762505766;
					continue;
				case 1u:
					num = ((int)num2 * -251716497) ^ -1567844001;
					continue;
				case 0u:
					BloodAvailability.smethod_35((Control)(object)SuccessMsg, Color.Red);
					num = (int)(num2 * 939644649) ^ -2061093314;
					continue;
				case 13u:
					break;
				default:
					try
					{
						while (true)
						{
							IL_061e:
							int num3 = -1250224291;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xC7BC8177u) % 28u)
								{
								case 27u:
									num3 = (int)(num2 * 1221285441) ^ -1159670933;
									continue;
								case 26u:
									num3 = ((int)num2 * -405165962) ^ -2078323131;
									continue;
								case 25u:
									BloodAvailability.smethod_41((Control)(object)DonorListBtn, bool_0: true);
									num3 = (int)((num2 * 435878902) ^ 0x2A478A7C);
									continue;
								case 24u:
									BloodAvailability.smethod_35((Control)(object)ValueLbl, Color.Red);
									num3 = ((int)num2 * -1039425666) ^ 0x285930AC;
									continue;
								case 22u:
									num3 = ((int)num2 * -1497011055) ^ 0x5A5EF6CD;
									continue;
								case 21u:
									BloodAvailability.smethod_41((Control)(object)ValueLbl, bool_0: true);
									num3 = (int)((num2 * 1471935169) ^ 0x7AA7C22F);
									continue;
								case 20u:
								{
									int num9;
									int num10;
									if (decimal.Compare(num4, 0m) == 0)
									{
										num9 = 1253247063;
										num10 = 1253247063;
									}
									else
									{
										num9 = 1688366630;
										num10 = 1688366630;
									}
									num3 = num9 ^ ((int)num2 * -398967864);
									continue;
								}
								case 19u:
								{
									int num7;
									int num8;
									if (!flag)
									{
										num7 = -1407488053;
										num8 = -1407488053;
									}
									else
									{
										num7 = -1164606687;
										num8 = -1164606687;
									}
									num3 = num7 ^ (int)(num2 * 779677100);
									continue;
								}
								case 18u:
									BloodAvailability.smethod_41((Control)(object)UpdateBtn, bool_0: true);
									num3 = ((int)num2 * -1153592326) ^ -1778587415;
									continue;
								case 16u:
									flag2 = BloodAvailability.smethod_75(oleDbDataReader_);
									num3 = -578113287;
									continue;
								case 15u:
									BloodAvailability.smethod_76(myconnection);
									num4 = BloodAvailability.smethod_79(BloodAvailability.smethod_78(BloodAvailability.smethod_77(ValueLbl), new char[1] { ' ' })[0]);
									num3 = ((int)num2 * -1545366518) ^ -1887046308;
									continue;
								case 14u:
									num3 = (int)((num2 * 1404217783) ^ 0x20EFB80D);
									continue;
								case 13u:
									oleDbDataReader_ = BloodAvailability.smethod_70(oleDbCommand_);
									num3 = ((int)num2 * -1648424859) ^ 0x1F9F192C;
									continue;
								case 12u:
									num3 = -1455394121;
									continue;
								case 11u:
									num3 = (int)(num2 * 518680241) ^ -591266189;
									continue;
								case 10u:
								{
									int num5;
									int num6;
									if (!flag2)
									{
										num5 = 775655592;
										num6 = 775655592;
									}
									else
									{
										num5 = 886917507;
										num6 = 886917507;
									}
									num3 = num5 ^ ((int)num2 * -2064419976);
									continue;
								}
								case 9u:
									flag = BloodAvailability.smethod_81(BloodAvailability.smethod_80(MyProject.Forms.Form1.login_type), "admin", bool_0: false) == 0;
									num3 = ((int)num2 * -1982972699) ^ 0x38A537A9;
									continue;
								case 8u:
									MyProject.Forms.Form1.blood_available_id = BloodAvailability.smethod_72(BloodAvailability.smethod_71(oleDbDataReader_, 0));
									BloodAvailability.smethod_20(ValueLbl, BloodAvailability.smethod_74(BloodAvailability.smethod_73(BloodAvailability.smethod_71(oleDbDataReader_, 2), (object)" litres")));
									num3 = -1930311395;
									continue;
								case 7u:
									BloodAvailability.smethod_41((Control)(object)AmountLbl, bool_0: true);
									num3 = -714902454;
									continue;
								case 6u:
									oleDbCommand_ = BloodAvailability.smethod_69(string_, myconnection);
									num3 = ((int)num2 * -612949693) ^ 0x54FE4630;
									continue;
								case 5u:
									MyProject.Forms.Form1.cur_blood_amount = num4;
									num3 = (int)(num2 * 536849787) ^ -434115544;
									continue;
								case 4u:
									num3 = ((int)num2 * -97721843) ^ -1765143988;
									continue;
								case 3u:
									BloodAvailability.smethod_35((Control)(object)ValueLbl, Color.Green);
									num3 = ((int)num2 * -1031663345) ^ 0x3A42D9C6;
									continue;
								case 2u:
									num3 = (int)(num2 * 628286398) ^ -2125643429;
									continue;
								case 1u:
									num3 = -113029376;
									continue;
								case 0u:
									blood_group = BloodAvailability.smethod_65(BloodGrpTxt);
									num3 = ((int)num2 * -259992121) ^ 0x7A8A981E;
									continue;
								default:
									goto end_IL_059b;
								case 23u:
									break;
								case 17u:
									goto end_IL_059b;
								}
								goto IL_061e;
								continue;
								end_IL_059b:
								break;
							}
							break;
						}
					}
					catch (Exception exception_)
					{
						BloodAvailability.smethod_82(exception_);
						BloodAvailability.smethod_76(myconnection);
						while (true)
						{
							IL_0688:
							_ = -1403825435;
							while (true)
							{
								_003F val = /*Error near IL_0647: Stack underflow*/^ -943947401;
								num2 = (uint)(int)val;
								switch (val % 4)
								{
								default:
									goto end_IL_0641;
								case 2:
									_ = (num2 * 683939386) ^ 0xC0A5D1E;
									continue;
								case 1:
									BloodAvailability.smethod_83();
									_ = (num2 * 294184356) ^ 0x6D4FE91F;
									continue;
								case 3:
									break;
								case 0:
									goto end_IL_0641;
								}
								goto IL_0688;
								continue;
								end_IL_0641:
								break;
							}
							break;
						}
					}
					while (true)
					{
						int num11 = -2037038946;
						while (true)
						{
							switch ((num2 = (uint)num11 ^ 0xC7BC8177u) % 3u)
							{
							case 1u:
								goto IL_0691;
							default:
								return;
							case 2u:
								break;
							case 0u:
								return;
							}
							break;
							IL_0691:
							num11 = (int)((num2 * 997157466) ^ 0x392628BC);
						}
					}
				case 16u:
					return;
				}
				break;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = default(DataTable);
		string string_ = default(string);
		bool flag = default(bool);
		OleDbDataAdapter dbDataAdapter_ = default(OleDbDataAdapter);
		while (true)
		{
			int num = -178569328;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCEC473D3u) % 16u)
				{
				case 15u:
					BloodAvailability.smethod_41((Control)(object)SuccessMsg, bool_0: true);
					num = (int)(num2 * 371048008) ^ -541360757;
					continue;
				case 14u:
					num = ((int)num2 * -1211021893) ^ -1994853691;
					continue;
				case 13u:
					BloodAvailability.smethod_35((Control)(object)SuccessMsg, Color.Red);
					BloodAvailability.smethod_63(Timer1);
					num = ((int)num2 * -548479735) ^ -286770116;
					continue;
				case 10u:
					num = (int)((num2 * 1033816543) ^ 0x4390EFBB);
					continue;
				case 9u:
					num = ((int)num2 * -197034696) ^ -293815338;
					continue;
				case 8u:
					BloodAvailability.smethod_20(SuccessMsg, "Select Blood Group");
					num = (int)(num2 * 370125146) ^ -1702383830;
					continue;
				case 6u:
					dataTable = BloodAvailability.smethod_67();
					BloodAvailability.smethod_68(myconnection);
					num = ((int)num2 * -137587584) ^ -955196696;
					continue;
				case 5u:
					string_ = BloodAvailability.smethod_66("Select * From [Donor] Where [Blood] Like '%", blood_group, "%';");
					num = (int)(num2 * 436206794) ^ -1243562729;
					continue;
				case 4u:
					BloodAvailability.smethod_64();
					num = (int)(num2 * 1067490649) ^ -1842645758;
					continue;
				case 3u:
					flag = BloodAvailability.smethod_62(BloodGrpTxt) == 0;
					num = ((int)num2 * -1567903271) ^ -46930966;
					continue;
				case 2u:
				{
					int num7;
					int num8;
					if (flag)
					{
						num7 = 858386102;
						num8 = 858386102;
					}
					else
					{
						num7 = 2065805576;
						num8 = 2065805576;
					}
					num = num7 ^ (int)(num2 * 19812229);
					continue;
				}
				case 1u:
					num = -160786041;
					continue;
				case 0u:
					num = (int)(num2 * 922032310) ^ -1955377221;
					continue;
				case 7u:
					break;
				default:
					try
					{
						while (true)
						{
							IL_0344:
							int num3 = -2096517415;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xCEC473D3u) % 14u)
								{
								case 13u:
									num3 = ((int)num2 * -757071655) ^ 0x24B53E37;
									continue;
								case 12u:
								{
									int num4;
									int num5;
									if (BloodAvailability.smethod_87(SearchResultGrid) == 1)
									{
										num4 = 249036743;
										num5 = 249036743;
									}
									else
									{
										num4 = 576617593;
										num5 = 576617593;
									}
									num3 = num4 ^ ((int)num2 * -1676296183);
									continue;
								}
								case 10u:
									num3 = -2057625968;
									continue;
								case 9u:
									BloodAvailability.smethod_76(myconnection);
									num3 = ((int)num2 * -1633652279) ^ 0x6B31E74F;
									continue;
								case 8u:
									num3 = (int)((num2 * 1749995794) ^ 0x6F9FE08D);
									continue;
								case 7u:
									HideUnusedColumns();
									BloodAvailability.smethod_41((Control)(object)SearchResultGrid, bool_0: true);
									num3 = ((int)num2 * -111127404) ^ -256605865;
									continue;
								case 6u:
									BloodAvailability.smethod_85((DbDataAdapter)(object)dbDataAdapter_, dataTable);
									BloodAvailability.smethod_86(SearchResultGrid, (object)dataTable);
									num3 = (int)((num2 * 526078356) ^ 0x6C4972CB);
									continue;
								case 4u:
									BloodAvailability.smethod_88("No Result Found");
									num3 = ((int)num2 * -712526126) ^ 0x57CD5E52;
									continue;
								case 3u:
									BloodAvailability.smethod_76(myconnection);
									num3 = (int)(num2 * 931609356) ^ -1904068700;
									continue;
								case 2u:
									dbDataAdapter_ = BloodAvailability.smethod_84(string_, myconnection);
									num3 = ((int)num2 * -977876833) ^ 0x4D7502D1;
									continue;
								case 0u:
									num3 = (int)(num2 * 1779594678) ^ -692040956;
									continue;
								default:
									goto end_IL_02f9;
								case 5u:
									break;
								case 1u:
									return;
								case 11u:
									goto end_IL_02f9;
								}
								goto IL_0344;
								continue;
								end_IL_02f9:
								break;
							}
							break;
						}
					}
					catch (Exception exception_)
					{
						BloodAvailability.smethod_82(exception_);
						BloodAvailability.smethod_76(myconnection);
						BloodAvailability.smethod_83();
					}
					while (true)
					{
						int num6 = -1934887734;
						while (true)
						{
							switch ((num2 = (uint)num6 ^ 0xCEC473D3u) % 3u)
							{
							case 1u:
								goto IL_0368;
							default:
								return;
							case 0u:
								break;
							case 2u:
								return;
							}
							break;
							IL_0368:
							num6 = (int)((num2 * 648134978) ^ 0x739D93E);
						}
					}
				case 12u:
					return;
				}
				break;
			}
		}
	}

	private bool HideUnusedColumns()
	{
		int num3 = default(int);
		bool result = default(bool);
		while (true)
		{
			int num = -1718860127;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x86601D18u) % 7u)
				{
				case 6u:
					BloodAvailability.smethod_91(BloodAvailability.smethod_90(BloodAvailability.smethod_89(SearchResultGrid), num3), bool_0: false);
					num3 = checked(num3 + 1);
					num = -997507992;
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (num3 <= 8)
					{
						num4 = 651365252;
						num5 = 651365252;
					}
					else
					{
						num4 = 1680963619;
						num5 = 1680963619;
					}
					num = num4 ^ (int)(num2 * 1405332148);
					continue;
				}
				case 2u:
					num3 = 3;
					num = (int)((num2 * 383754834) ^ 0x48E39A06);
					continue;
				case 1u:
					BloodAvailability.smethod_91(BloodAvailability.smethod_90(BloodAvailability.smethod_89(SearchResultGrid), 5), bool_0: true);
					num = (int)((num2 * 1507003421) ^ 0xF0098F6);
					continue;
				case 0u:
					result = true;
					num = ((int)num2 * -1145744633) ^ 0xE6497CC;
					continue;
				case 5u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	private void UpdateBtn_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -944786957;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE85F1DD7u) % 8u)
				{
				case 7u:
					num = (int)(num2 * 1272107384) ^ -1216649967;
					continue;
				case 6u:
					BloodAvailability.smethod_41((Control)(object)ValueLbl, bool_0: false);
					num = ((int)num2 * -2086531132) ^ -147259043;
					continue;
				case 5u:
					BloodAvailability.smethod_41((Control)(object)AmountLbl, bool_0: false);
					num = ((int)num2 * -2077673416) ^ -2041726888;
					continue;
				case 4u:
					BloodAvailability.smethod_92((Control)(object)MyProject.Forms.Form4);
					num = ((int)num2 * -2122415404) ^ 0x65203622;
					continue;
				case 3u:
					BloodAvailability.smethod_41((Control)(object)SearchResultGrid, bool_0: false);
					BloodAvailability.smethod_41((Control)(object)DonorListBtn, bool_0: false);
					num = (int)(num2 * 615246185) ^ -1822962571;
					continue;
				case 2u:
					BloodAvailability.smethod_41((Control)(object)UpdateBtn, bool_0: false);
					num = ((int)num2 * -155505140) ^ -1521772260;
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

	static void smethod_0(UserControl userControl_0, EventHandler eventHandler_0)
	{
		userControl_0.add_Load(eventHandler_0);
	}

	static OleDbConnection smethod_1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new OleDbConnection();
	}

	static void smethod_2(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Container smethod_3()
	{
		return new Container();
	}

	static Label smethod_4()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Label();
	}

	static GroupBox smethod_5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new GroupBox();
	}

	static Button smethod_6()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Button();
	}

	static ComboBox smethod_7()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new ComboBox();
	}

	static DataGridView smethod_8()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new DataGridView();
	}

	static Timer smethod_9(IContainer icontainer_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new Timer(icontainer_0);
	}

	static PictureBox smethod_10()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new PictureBox();
	}

	static void smethod_11(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_12(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.BeginInit();
	}

	static void smethod_13(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static Font smethod_14(string string_0, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_15(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static void smethod_16(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_17(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_18(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_19(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static void smethod_20(Label label_0, string string_0)
	{
		label_0.set_Text(string_0);
	}

	static void smethod_21(Label label_0, ContentAlignment contentAlignment_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		label_0.set_TextAlign(contentAlignment_0);
	}

	static ControlCollection smethod_22(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_23(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_24(GroupBox groupBox_0, bool bool_0)
	{
		groupBox_0.set_TabStop(bool_0);
	}

	static void smethod_25(GroupBox groupBox_0, string string_0)
	{
		groupBox_0.set_Text(string_0);
	}

	static void smethod_26(ButtonBase buttonBase_0, Color color_0)
	{
		buttonBase_0.set_BackColor(color_0);
	}

	static void smethod_27(Control control_0, Color color_0)
	{
		control_0.set_ForeColor(color_0);
	}

	static void smethod_28(ButtonBase buttonBase_0, string string_0)
	{
		buttonBase_0.set_Text(string_0);
	}

	static void smethod_29(ButtonBase buttonBase_0, bool bool_0)
	{
		buttonBase_0.set_UseVisualStyleBackColor(bool_0);
	}

	static void smethod_30(ComboBox comboBox_0, ComboBoxStyle comboBoxStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		comboBox_0.set_DropDownStyle(comboBoxStyle_0);
	}

	static void smethod_31(ListControl listControl_0, bool bool_0)
	{
		listControl_0.set_FormattingEnabled(bool_0);
	}

	static ObjectCollection smethod_32(ComboBox comboBox_0)
	{
		return comboBox_0.get_Items();
	}

	static void smethod_33(ObjectCollection objectCollection_0, object[] object_0)
	{
		objectCollection_0.AddRange(object_0);
	}

	static void smethod_34(Label label_0, bool bool_0)
	{
		label_0.set_AutoSize(bool_0);
	}

	static void smethod_35(Control control_0, Color color_0)
	{
		control_0.set_BackColor(color_0);
	}

	static void smethod_36(DataGridView dataGridView_0, Color color_0)
	{
		dataGridView_0.set_BackgroundColor(color_0);
	}

	static void smethod_37(DataGridView dataGridView_0, DataGridViewColumnHeadersHeightSizeMode dataGridViewColumnHeadersHeightSizeMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		dataGridView_0.set_ColumnHeadersHeightSizeMode(dataGridViewColumnHeadersHeightSizeMode_0);
	}

	static void smethod_38(DataGridView dataGridView_0, bool bool_0)
	{
		dataGridView_0.set_ReadOnly(bool_0);
	}

	static DataGridViewRow smethod_39(DataGridView dataGridView_0)
	{
		return dataGridView_0.get_RowTemplate();
	}

	static void smethod_40(DataGridViewRow dataGridViewRow_0, int int_0)
	{
		dataGridViewRow_0.set_Height(int_0);
	}

	static void smethod_41(Control control_0, bool bool_0)
	{
		control_0.set_Visible(bool_0);
	}

	static Font smethod_42(string string_0, float float_0, FontStyle fontStyle_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0);
	}

	static void smethod_43(Timer timer_0, int int_0)
	{
		timer_0.set_Interval(int_0);
	}

	static void smethod_44(PictureBox pictureBox_0, Image image_0)
	{
		pictureBox_0.set_Image(image_0);
	}

	static void smethod_45(PictureBox pictureBox_0, PictureBoxSizeMode pictureBoxSizeMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		pictureBox_0.set_SizeMode(pictureBoxSizeMode_0);
	}

	static void smethod_46(PictureBox pictureBox_0, int int_0)
	{
		pictureBox_0.set_TabIndex(int_0);
	}

	static void smethod_47(PictureBox pictureBox_0, bool bool_0)
	{
		pictureBox_0.set_TabStop(bool_0);
	}

	static void smethod_48(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_49(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static ControlCollection smethod_50(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_51(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_52(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_53(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_54(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.EndInit();
	}

	static void smethod_55(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_56(Control control_0)
	{
		control_0.PerformLayout();
	}

	static void smethod_57(Control control_0, EventHandler eventHandler_0)
	{
		control_0.remove_Click(eventHandler_0);
	}

	static void smethod_58(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_Click(eventHandler_0);
	}

	static string smethod_59(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static void smethod_60(OleDbConnection oleDbConnection_0, string string_0)
	{
		oleDbConnection_0.set_ConnectionString(string_0);
	}

	static void smethod_61(ComboBox comboBox_0, int int_0)
	{
		comboBox_0.set_SelectedIndex(int_0);
	}

	static int smethod_62(ComboBox comboBox_0)
	{
		return comboBox_0.get_SelectedIndex();
	}

	static void smethod_63(Timer timer_0)
	{
		timer_0.Start();
	}

	static OleDbCommand smethod_64()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new OleDbCommand();
	}

	static string smethod_65(ComboBox comboBox_0)
	{
		return comboBox_0.get_Text();
	}

	static string smethod_66(string string_0, string string_1, string string_2)
	{
		return string_0 + string_1 + string_2;
	}

	static DataTable smethod_67()
	{
		return new DataTable();
	}

	static void smethod_68(OleDbConnection oleDbConnection_0)
	{
		oleDbConnection_0.Open();
	}

	static OleDbCommand smethod_69(string string_0, OleDbConnection oleDbConnection_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new OleDbCommand(string_0, oleDbConnection_0);
	}

	static OleDbDataReader smethod_70(OleDbCommand oleDbCommand_0)
	{
		return oleDbCommand_0.ExecuteReader();
	}

	static object smethod_71(OleDbDataReader oleDbDataReader_0, int int_0)
	{
		return oleDbDataReader_0.get_Item(int_0);
	}

	static int smethod_72(object object_0)
	{
		return Conversions.ToInteger(object_0);
	}

	static object smethod_73(object object_0, object object_1)
	{
		return Operators.AddObject(object_0, object_1);
	}

	static string smethod_74(object object_0)
	{
		return Conversions.ToString(object_0);
	}

	static bool smethod_75(OleDbDataReader oleDbDataReader_0)
	{
		return oleDbDataReader_0.Read();
	}

	static void smethod_76(OleDbConnection oleDbConnection_0)
	{
		oleDbConnection_0.Close();
	}

	static string smethod_77(Label label_0)
	{
		return label_0.get_Text();
	}

	static string[] smethod_78(string string_0, char[] char_0)
	{
		return string_0.Split(char_0);
	}

	static decimal smethod_79(string string_0)
	{
		return Convert.ToDecimal(string_0);
	}

	static string smethod_80(string string_0)
	{
		return string_0.ToLower();
	}

	static int smethod_81(string string_0, string string_1, bool bool_0)
	{
		return Operators.CompareString(string_0, string_1, bool_0);
	}

	static void smethod_82(Exception exception_0)
	{
		ProjectData.SetProjectError(exception_0);
	}

	static void smethod_83()
	{
		ProjectData.ClearProjectError();
	}

	static OleDbDataAdapter smethod_84(string string_0, OleDbConnection oleDbConnection_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new OleDbDataAdapter(string_0, oleDbConnection_0);
	}

	static int smethod_85(DbDataAdapter dbDataAdapter_0, DataTable dataTable_0)
	{
		return dbDataAdapter_0.Fill(dataTable_0);
	}

	static void smethod_86(DataGridView dataGridView_0, object object_0)
	{
		dataGridView_0.set_DataSource(object_0);
	}

	static int smethod_87(DataGridView dataGridView_0)
	{
		return dataGridView_0.get_RowCount();
	}

	static DialogResult smethod_88(string string_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0);
	}

	static DataGridViewColumnCollection smethod_89(DataGridView dataGridView_0)
	{
		return dataGridView_0.get_Columns();
	}

	static DataGridViewColumn smethod_90(DataGridViewColumnCollection dataGridViewColumnCollection_0, int int_0)
	{
		return dataGridViewColumnCollection_0.get_Item(int_0);
	}

	static void smethod_91(DataGridViewColumn dataGridViewColumn_0, bool bool_0)
	{
		dataGridViewColumn_0.set_Visible(bool_0);
	}

	static void smethod_92(Control control_0)
	{
		control_0.Show();
	}
}
