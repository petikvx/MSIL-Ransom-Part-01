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
public class Availability : UserControl
{
	private IContainer components;

	private string Designation;

	private OleDbConnection myconnection;

	private int day;

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
			EventHandler eventHandler_ = SearchBtn_Click;
			Button searchBtn = default(Button);
			while (true)
			{
				int num = -1703129580;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x98189263u) % 8u)
					{
					case 7u:
					{
						searchBtn = _SearchBtn;
						int num5;
						int num6;
						if (searchBtn == null)
						{
							num5 = 2043454965;
							num6 = 2043454965;
						}
						else
						{
							num5 = 923028519;
							num6 = 923028519;
						}
						num = num5 ^ ((int)num2 * -1212472172);
						continue;
					}
					case 5u:
					{
						int num3;
						int num4;
						if (searchBtn == null)
						{
							num3 = -2104436231;
							num4 = -2104436231;
						}
						else
						{
							num3 = -1318426514;
							num4 = -1318426514;
						}
						num = num3 ^ (int)(num2 * 1467945868);
						continue;
					}
					case 3u:
						searchBtn = _SearchBtn;
						num = (int)(num2 * 1340601434) ^ -58929280;
						continue;
					case 2u:
						_SearchBtn = value;
						num = -1533394896;
						continue;
					case 1u:
						Availability.smethod_56((Control)(object)searchBtn, eventHandler_);
						num = ((int)num2 * -499169984) ^ -453154907;
						continue;
					case 0u:
						Availability.smethod_55((Control)(object)searchBtn, eventHandler_);
						num = ((int)num2 * -2013243827) ^ -1633158191;
						continue;
					default:
						return;
					case 4u:
						break;
					case 6u:
						return;
					}
					break;
				}
			}
		}
	}

	[field: AccessedThroughProperty("NameSTxt")]
	internal virtual TextBox NameSTxt
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

	internal virtual RadioButton NurseBtn
	{
		[CompilerGenerated]
		get
		{
			return _NurseBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = RadioButton2_CheckedChanged;
			RadioButton nurseBtn = _NurseBtn;
			if (nurseBtn != null)
			{
				goto IL_0032;
			}
			goto IL_00a1;
			IL_00a1:
			_NurseBtn = value;
			int num = 1334160499;
			goto IL_0078;
			IL_0078:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBB766D5u) % 6u)
				{
				case 5u:
					Availability.smethod_57(nurseBtn, eventHandler_);
					num = ((int)num2 * -1822944279) ^ -1491147158;
					continue;
				case 4u:
					break;
				case 3u:
					Availability.smethod_58(nurseBtn, eventHandler_);
					num = ((int)num2 * -2024148390) ^ -1419715082;
					continue;
				case 0u:
				{
					nurseBtn = _NurseBtn;
					int num3;
					int num4;
					if (nurseBtn != null)
					{
						num3 = -1555187758;
						num4 = -1555187758;
					}
					else
					{
						num3 = -1738847840;
						num4 = -1738847840;
					}
					num = num3 ^ (int)(num2 * 658480400);
					continue;
				}
				default:
					return;
				case 2u:
					goto IL_00a1;
				case 1u:
					return;
				}
				break;
			}
			goto IL_0032;
			IL_0032:
			num = 562289086;
			goto IL_0078;
		}
	}

	internal virtual RadioButton DoctorBtn
	{
		[CompilerGenerated]
		get
		{
			return _DoctorBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = RadioButton1_CheckedChanged;
			RadioButton doctorBtn = default(RadioButton);
			while (true)
			{
				int num = 1786684617;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x94EFFE7u) % 8u)
					{
					case 7u:
						Availability.smethod_58(doctorBtn, eventHandler_);
						num = ((int)num2 * -1321792047) ^ 0x6DFEB20D;
						continue;
					case 6u:
					{
						doctorBtn = _DoctorBtn;
						int num5;
						int num6;
						if (doctorBtn != null)
						{
							num5 = -655667211;
							num6 = -655667211;
						}
						else
						{
							num5 = -1866677471;
							num6 = -1866677471;
						}
						num = num5 ^ (int)(num2 * 1561509649);
						continue;
					}
					case 4u:
						Availability.smethod_57(doctorBtn, eventHandler_);
						num = (int)(num2 * 1828588156) ^ -1357363521;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (doctorBtn == null)
						{
							num3 = 1244353616;
							num4 = 1244353616;
						}
						else
						{
							num3 = 579656042;
							num4 = 579656042;
						}
						num = num3 ^ (int)(num2 * 901344441);
						continue;
					}
					case 1u:
						doctorBtn = _DoctorBtn;
						num = ((int)num2 * -619289897) ^ -351522670;
						continue;
					case 0u:
						_DoctorBtn = value;
						num = 1555104638;
						continue;
					default:
						return;
					case 3u:
						break;
					case 5u:
						return;
					}
					break;
				}
			}
		}
	}

	internal virtual RadioButton ReceptionistBtn
	{
		[CompilerGenerated]
		get
		{
			return _ReceptionistBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = RadioButton3_CheckedChanged;
			RadioButton receptionistBtn = default(RadioButton);
			while (true)
			{
				int num = 1283419172;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x360C177Du) % 8u)
					{
					case 7u:
						_ReceptionistBtn = value;
						num = 828891481;
						continue;
					case 6u:
						Availability.smethod_57(receptionistBtn, eventHandler_);
						num = ((int)num2 * -1256275999) ^ 0x218546A4;
						continue;
					case 5u:
						Availability.smethod_58(receptionistBtn, eventHandler_);
						num = ((int)num2 * -1169948042) ^ -619958717;
						continue;
					case 4u:
					{
						receptionistBtn = _ReceptionistBtn;
						int num5;
						int num6;
						if (receptionistBtn != null)
						{
							num5 = 750910844;
							num6 = 750910844;
						}
						else
						{
							num5 = 1081440569;
							num6 = 1081440569;
						}
						num = num5 ^ ((int)num2 * -1403510099);
						continue;
					}
					case 2u:
					{
						int num3;
						int num4;
						if (receptionistBtn == null)
						{
							num3 = -77842068;
							num4 = -77842068;
						}
						else
						{
							num3 = -321116811;
							num4 = -321116811;
						}
						num = num3 ^ ((int)num2 * -1239488453);
						continue;
					}
					case 1u:
						receptionistBtn = _ReceptionistBtn;
						num = ((int)num2 * -364652180) ^ 0xB8E10CB;
						continue;
					default:
						return;
					case 3u:
						break;
					case 0u:
						return;
					}
					break;
				}
			}
		}
	}

	internal virtual DataGridView SearchResultGrid
	{
		[CompilerGenerated]
		get
		{
			return _SearchResultGrid;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			DataGridViewCellMouseEventHandler dataGridViewCellMouseEventHandler_ = new DataGridViewCellMouseEventHandler(DataGridView1_CellMouseClick);
			DataGridView searchResultGrid = default(DataGridView);
			while (true)
			{
				int num = -1323725528;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC174AE72u) % 9u)
					{
					case 8u:
						Availability.smethod_60(searchResultGrid, dataGridViewCellMouseEventHandler_);
						num = ((int)num2 * -1522329969) ^ 0xDB19042;
						continue;
					case 7u:
						searchResultGrid = _SearchResultGrid;
						num = ((int)num2 * -1605490982) ^ 0x2196BA7E;
						continue;
					case 6u:
					{
						int num5;
						int num6;
						if (searchResultGrid != null)
						{
							num5 = -653760706;
							num6 = -653760706;
						}
						else
						{
							num5 = -367928546;
							num6 = -367928546;
						}
						num = num5 ^ (int)(num2 * 1477230993);
						continue;
					}
					case 5u:
						_SearchResultGrid = value;
						num = -1688578735;
						continue;
					case 2u:
						searchResultGrid = _SearchResultGrid;
						num = (int)(num2 * 12524722) ^ -297718827;
						continue;
					case 1u:
						Availability.smethod_59(searchResultGrid, dataGridViewCellMouseEventHandler_);
						num = ((int)num2 * -1785386572) ^ 0x3E851866;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (searchResultGrid == null)
						{
							num3 = 1348375650;
							num4 = 1348375650;
						}
						else
						{
							num3 = 536807202;
							num4 = 536807202;
						}
						num = num3 ^ (int)(num2 * 439588040);
						continue;
					}
					default:
						return;
					case 4u:
						break;
					case 3u:
						return;
					}
					break;
				}
			}
		}
	}

	[field: AccessedThroughProperty("DetailsBox")]
	internal virtual GroupBox DetailsBox
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MobileTxt")]
	internal virtual TextBox MobileTxt
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

	[field: AccessedThroughProperty("NameTxt")]
	internal virtual TextBox NameTxt
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

	[field: AccessedThroughProperty("AddressTxt")]
	internal virtual TextBox AddressTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GenderTxt")]
	internal virtual TextBox GenderTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DOBTxt")]
	internal virtual TextBox DOBTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SIDTxt")]
	internal virtual TextBox SIDTxt
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DesignationTxt")]
	internal virtual TextBox DesignationTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ShowAvailability")]
	internal virtual Label ShowAvailability
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button ClearBtn
	{
		[CompilerGenerated]
		get
		{
			return _ClearBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = Button2_Click;
			Button clearBtn = default(Button);
			while (true)
			{
				int num = 1582788177;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x57198A0Cu) % 8u)
					{
					case 7u:
						Availability.smethod_56((Control)(object)clearBtn, eventHandler_);
						num = ((int)num2 * -352854595) ^ 0x3FB1DEF4;
						continue;
					case 6u:
					{
						int num5;
						int num6;
						if (clearBtn != null)
						{
							num5 = 765536921;
							num6 = 765536921;
						}
						else
						{
							num5 = 588656845;
							num6 = 588656845;
						}
						num = num5 ^ (int)(num2 * 1232227239);
						continue;
					}
					case 5u:
					{
						clearBtn = _ClearBtn;
						int num3;
						int num4;
						if (clearBtn != null)
						{
							num3 = -1881929772;
							num4 = -1881929772;
						}
						else
						{
							num3 = -353469713;
							num4 = -353469713;
						}
						num = num3 ^ (int)(num2 * 1993725906);
						continue;
					}
					case 2u:
						Availability.smethod_55((Control)(object)clearBtn, eventHandler_);
						num = (int)(num2 * 1403605068) ^ -664078595;
						continue;
					case 1u:
						_ClearBtn = value;
						num = 885790252;
						continue;
					case 0u:
						clearBtn = _ClearBtn;
						num = ((int)num2 * -1403184794) ^ -1688543870;
						continue;
					default:
						return;
					case 4u:
						break;
					case 3u:
						return;
					}
					break;
				}
			}
		}
	}

	public Availability()
	{
		Availability.smethod_0((UserControl)(object)this, (EventHandler)Availability_Load);
		myconnection = Availability.smethod_1();
		day = Availability.smethod_2(DateTime.Now.ToString("HH"));
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
				int num = -2140004822;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0xCC441D13u) % 7u)
					{
					case 5u:
						num = (int)(num2 * 1235404286) ^ -852989791;
						continue;
					case 4u:
						Availability.smethod_3((IDisposable)components);
						num = (int)((num2 * 1508270991) ^ 0x31ED55D1);
						continue;
					case 3u:
						num3 = ((components != null) ? 1 : 0);
						goto IL_0039;
					case 2u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = -1799027654;
							num5 = -1799027654;
						}
						else
						{
							num4 = -1451959857;
							num5 = -1451959857;
						}
						num = num4 ^ ((int)num2 * -1236238127);
						continue;
					}
					case 1u:
						if (disposing)
						{
							num = ((int)num2 * -247892286) ^ -2138682619;
							continue;
						}
						num3 = 0;
						goto IL_0039;
					default:
						return;
					case 0u:
						break;
					case 6u:
						return;
						IL_0039:
						flag = (byte)num3 != 0;
						num = -1816790210;
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
				IL_00f7:
				int num6 = -462582300;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num6 ^ 0xCC441D13u) % 4u)
					{
					case 3u:
						((ContainerControl)this).Dispose(disposing);
						num6 = ((int)num2 * -682786513) ^ -640256357;
						continue;
					case 1u:
						num6 = (int)(num2 * 874757195) ^ -1038214726;
						continue;
					default:
						goto end_IL_00d6;
					case 0u:
						break;
					case 2u:
						goto end_IL_00d6;
					}
					goto IL_00f7;
					continue;
					end_IL_00d6:
					break;
				}
				break;
			}
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		Label1 = Availability.smethod_4();
		while (true)
		{
			int num = 703517572;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x128D1C00u) % 299u)
				{
				case 298u:
					Availability.smethod_22(Label1, (ContentAlignment)32);
					num = ((int)num2 * -1672080300) ^ 0x6DD431B;
					continue;
				case 297u:
					Availability.smethod_20((Control)(object)DetailsBox, 9);
					num = (int)((num2 * 2115783699) ^ 0x90C5501);
					continue;
				case 296u:
					Availability.smethod_19((Control)(object)DoctorBtn, new Size(87, 23));
					num = ((int)num2 * -198808981) ^ 0x2E7491F5;
					continue;
				case 295u:
					num = (int)((num2 * 58642516) ^ 0xD773D39);
					continue;
				case 294u:
					Availability.smethod_24(Availability.smethod_23((Control)(object)GroupBox1), (Control)(object)Label2);
					num = (int)((num2 * 850775254) ^ 0x1FD4D0A1);
					continue;
				case 293u:
					num = (int)(num2 * 1791276648) ^ -765152087;
					continue;
				case 292u:
					Availability.smethod_21(ShowAvailability, "UnAvailable");
					num = (int)(num2 * 607647441) ^ -806804208;
					continue;
				case 291u:
					Availability.smethod_29((ButtonBase)(object)NurseBtn, "Nurse");
					num = (int)((num2 * 515111684) ^ 0x4E5527F1);
					continue;
				case 290u:
					DoctorBtn = Availability.smethod_7();
					num = ((int)num2 * -1502996017) ^ -753852642;
					continue;
				case 289u:
					AddressTxt = Availability.smethod_8();
					num = (int)(num2 * 1776216563) ^ -650725105;
					continue;
				case 288u:
					num = (int)((num2 * 752618528) ^ 0x1989E190);
					continue;
				case 287u:
					num = ((int)num2 * -719309077) ^ -1739827512;
					continue;
				case 286u:
					Availability.smethod_17((Control)(object)MobileTxt, new Point(124, 169));
					num = ((int)num2 * -825914715) ^ -45508624;
					continue;
				case 285u:
					num = (int)((num2 * 1802983293) ^ 0x71311A33);
					continue;
				case 284u:
					Availability.smethod_17((Control)(object)ReceptionistBtn, new Point(280, 84));
					Availability.smethod_18((Control)(object)ReceptionistBtn, "ReceptionistBtn");
					num = ((int)num2 * -1573181472) ^ -1837018137;
					continue;
				case 283u:
					num = (int)(num2 * 324020009) ^ -1585395235;
					continue;
				case 282u:
					num = (int)((num2 * 137779899) ^ 0x18575CDD);
					continue;
				case 281u:
					Availability.smethod_20((Control)(object)Label3, 13);
					Availability.smethod_21(Label3, "Designation : ");
					num = (int)((num2 * 1628746968) ^ 0x4AF84900);
					continue;
				case 280u:
					num = ((int)num2 * -438808865) ^ -319240052;
					continue;
				case 279u:
					num = (int)(num2 * 62669900) ^ -1903903379;
					continue;
				case 278u:
					Availability.smethod_18((Control)(object)NameTxt, "NameTxt");
					Availability.smethod_39((TextBoxBase)(object)NameTxt, bool_0: true);
					num = ((int)num2 * -1119682835) ^ 0x2A9AC605;
					continue;
				case 277u:
					ShowAvailability = Availability.smethod_4();
					num = (int)((num2 * 447811482) ^ 0x305143FF);
					continue;
				case 276u:
					Availability.smethod_25(GroupBox1, bool_0: false);
					num = ((int)num2 * -662832447) ^ -1508057764;
					continue;
				case 275u:
					Availability.smethod_19((Control)(object)Label5, new Size(84, 26));
					num = (int)((num2 * 125328233) ^ 0x695E5F16);
					continue;
				case 274u:
					Availability.smethod_17((Control)(object)Label8, new Point(20, 124));
					num = ((int)num2 * -1354391856) ^ 0x5CFDDBC9;
					continue;
				case 273u:
					Availability.smethod_24(Availability.smethod_23((Control)(object)DetailsBox), (Control)(object)AddressTxt);
					num = ((int)num2 * -1278518347) ^ 0x799CAF3A;
					continue;
				case 272u:
					Availability.smethod_16((Control)(object)Label8, Availability.smethod_15("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 2044249729) ^ -377086418;
					continue;
				case 271u:
					Availability.smethod_25(DetailsBox, bool_0: false);
					num = (int)(num2 * 95825441) ^ -327102348;
					continue;
				case 270u:
					num = (int)(num2 * 1818291595) ^ -101861592;
					continue;
				case 269u:
					GenderTxt = Availability.smethod_8();
					num = ((int)num2 * -524874296) ^ -1885987522;
					continue;
				case 268u:
					num = ((int)num2 * -1088114686) ^ 0x86F7475;
					continue;
				case 267u:
					Label8 = Availability.smethod_4();
					num = ((int)num2 * -1081732876) ^ 0x4D0A26D1;
					continue;
				case 266u:
					Availability.smethod_21(Label1, "Staff Availability");
					num = (int)(num2 * 1092995668) ^ -1245320655;
					continue;
				case 265u:
					Availability.smethod_18((Control)(object)DOBTxt, "DOBTxt");
					num = (int)((num2 * 887500329) ^ 0x490C6155);
					continue;
				case 264u:
					Availability.smethod_24(Availability.smethod_23((Control)(object)DetailsBox), (Control)(object)Label5);
					Availability.smethod_24(Availability.smethod_23((Control)(object)DetailsBox), (Control)(object)Label4);
					num = (int)(num2 * 997399441) ^ -846448298;
					continue;
				case 263u:
					num = (int)(num2 * 251659288) ^ -42911538;
					continue;
				case 262u:
					Availability.smethod_19((Control)(object)Label8, new Size(77, 28));
					Availability.smethod_20((Control)(object)Label8, 9);
					num = (int)(num2 * 204069003) ^ -1333345195;
					continue;
				case 261u:
					NameSTxt = Availability.smethod_8();
					num = ((int)num2 * -505149957) ^ -1583658313;
					continue;
				case 260u:
					Availability.smethod_17((Control)(object)SearchBtn, new Point(467, 73));
					num = ((int)num2 * -314339554) ^ -1884097752;
					continue;
				case 259u:
					num = (int)(num2 * 621240617) ^ -2106943589;
					continue;
				case 258u:
					num = (int)((num2 * 878317992) ^ 0x4D16738A);
					continue;
				case 257u:
					Availability.smethod_20((Control)(object)ReceptionistBtn, 7);
					num = ((int)num2 * -1559947048) ^ -1495866467;
					continue;
				case 256u:
					Availability.smethod_20((Control)(object)ShowAvailability, 15);
					num = (int)(num2 * 1719375307) ^ -1507247541;
					continue;
				case 255u:
					Availability.smethod_19((Control)(object)ReceptionistBtn, new Size(132, 23));
					num = ((int)num2 * -1496631775) ^ 0x601AE98C;
					continue;
				case 254u:
					Availability.smethod_19((Control)(object)MobileTxt, new Size(241, 28));
					num = ((int)num2 * -1652604444) ^ -353165397;
					continue;
				case 253u:
					NameTxt = Availability.smethod_8();
					num = (int)((num2 * 1098578634) ^ 0x264EFA9A);
					continue;
				case 252u:
					Availability.smethod_11((Control)(object)DetailsBox);
					num = (int)((num2 * 1042307748) ^ 0x726FE8E2);
					continue;
				case 251u:
					num = (int)((num2 * 321130897) ^ 0x3C2A3C6A);
					continue;
				case 250u:
					SIDTxt = Availability.smethod_8();
					num = ((int)num2 * -875068690) ^ -1183751744;
					continue;
				case 249u:
					Availability.smethod_28((Control)(object)ClearBtn, Color.White);
					num = ((int)num2 * -1142777468) ^ -1503146260;
					continue;
				case 248u:
					Availability.smethod_24(Availability.smethod_47((Control)(object)this), (Control)(object)SearchResultGrid);
					Availability.smethod_24(Availability.smethod_47((Control)(object)this), (Control)(object)GroupBox1);
					Availability.smethod_24(Availability.smethod_47((Control)(object)this), (Control)(object)Label1);
					num = (int)(num2 * 1926990265) ^ -1138655461;
					continue;
				case 247u:
					Availability.smethod_17((Control)(object)DoctorBtn, new Point(65, 84));
					num = ((int)num2 * -1410113105) ^ 0x10D3C875;
					continue;
				case 246u:
					Availability.smethod_16((Control)(object)Label5, Availability.smethod_15("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1870926480) ^ -1069955348;
					continue;
				case 245u:
					Availability.smethod_24(Availability.smethod_23((Control)(object)DetailsBox), (Control)(object)GenderTxt);
					num = (int)(num2 * 386548595) ^ -1457265562;
					continue;
				case 244u:
					num = ((int)num2 * -204864477) ^ 0x571CF614;
					continue;
				case 243u:
					Availability.smethod_19((Control)(object)Label1, new Size(270, 35));
					Availability.smethod_20((Control)(object)Label1, 5);
					num = ((int)num2 * -1392096196) ^ -92371652;
					continue;
				case 242u:
					Availability.smethod_28((Control)(object)SearchBtn, Color.White);
					num = (int)(num2 * 1628652034) ^ -741149902;
					continue;
				case 241u:
					Availability.smethod_18((Control)(object)ClearBtn, "ClearBtn");
					num = ((int)num2 * -1929547888) ^ 0x12DBFB97;
					continue;
				case 240u:
					Label3 = Availability.smethod_4();
					num = ((int)num2 * -1187606622) ^ -126995639;
					continue;
				case 239u:
					Availability.smethod_18((Control)(object)GroupBox1, "GroupBox1");
					num = ((int)num2 * -1492476101) ^ 0x339BF3F2;
					continue;
				case 238u:
					num = (int)((num2 * 162382165) ^ 0x65E052E7);
					continue;
				case 237u:
					Availability.smethod_49((Control)(object)this, new Size(977, 804));
					num = ((int)num2 * -1122448107) ^ -1624667423;
					continue;
				case 236u:
					Availability.smethod_33(SearchResultGrid, Color.White);
					Availability.smethod_34(SearchResultGrid, (DataGridViewColumnHeadersHeightSizeMode)2);
					num = (int)((num2 * 967300318) ^ 0x34245EF4);
					continue;
				case 235u:
					Availability.smethod_21(Label9, "Phone : ");
					num = ((int)num2 * -313437793) ^ -1754222429;
					continue;
				case 234u:
					Availability.smethod_27((ButtonBase)(object)SearchBtn, Color.MidnightBlue);
					num = ((int)num2 * -604739917) ^ -171705945;
					continue;
				case 233u:
					Availability.smethod_26(DetailsBox, "Staff Member Detail");
					num = (int)(num2 * 1488412642) ^ -897941782;
					continue;
				case 232u:
					Availability.smethod_38((Control)(object)ShowAvailability, Color.Red);
					num = (int)(num2 * 1234982971) ^ -1374758711;
					continue;
				case 231u:
					Availability.smethod_42(PictureBox1, (PictureBoxSizeMode)1);
					Availability.smethod_43(PictureBox1, 4);
					num = ((int)num2 * -910331789) ^ 0x574059C9;
					continue;
				case 230u:
					num = (int)((num2 * 1272727192) ^ 0x709596C4);
					continue;
				case 229u:
					Availability.smethod_50((Control)(object)DetailsBox, bool_0: false);
					num = ((int)num2 * -403073590) ^ 0x6114A87B;
					continue;
				case 228u:
					num = ((int)num2 * -2102999834) ^ 0x30ED6962;
					continue;
				case 227u:
					DetailsBox = Availability.smethod_5();
					num = (int)((num2 * 1245938364) ^ 0x15BB2054);
					continue;
				case 226u:
					Label5 = Availability.smethod_4();
					num = ((int)num2 * -330882364) ^ 0x1AFC259F;
					continue;
				case 225u:
					Availability.smethod_20((Control)(object)DoctorBtn, 5);
					num = ((int)num2 * -1729540979) ^ -545248110;
					continue;
				case 224u:
					Availability.smethod_19((Control)(object)GenderTxt, new Size(128, 28));
					num = (int)((num2 * 1605417557) ^ 0x50A03E8);
					continue;
				case 223u:
					Availability.smethod_16((Control)(object)Label2, Availability.smethod_15("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 85001095) ^ -156675055;
					continue;
				case 222u:
					num = (int)((num2 * 1700782275) ^ 0x11A7890D);
					continue;
				case 221u:
					num = ((int)num2 * -1781083027) ^ 0x7B76490;
					continue;
				case 220u:
					Availability.smethod_20((Control)(object)Label6, 2);
					Availability.smethod_21(Label6, "Gender : ");
					num = (int)(num2 * 803098665) ^ -1691165163;
					continue;
				case 219u:
					Availability.smethod_16((Control)(object)Label4, Availability.smethod_15("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -758529738) ^ -1542359164;
					continue;
				case 218u:
					Availability.smethod_24(Availability.smethod_23((Control)(object)GroupBox1), (Control)(object)DoctorBtn);
					Availability.smethod_24(Availability.smethod_23((Control)(object)GroupBox1), (Control)(object)SearchBtn);
					num = (int)((num2 * 1008849311) ^ 0x71E5C6FB);
					continue;
				case 217u:
					num = (int)((num2 * 517865527) ^ 0x3BF999E);
					continue;
				case 216u:
					num = (int)((num2 * 530467881) ^ 0x8D122B8);
					continue;
				case 215u:
					Availability.smethod_22(Label3, (ContentAlignment)32);
					num = (int)((num2 * 2024874925) ^ 0x65DE4C72);
					continue;
				case 213u:
					Availability.smethod_39((TextBoxBase)(object)DesignationTxt, bool_0: true);
					num = ((int)num2 * -1295300288) ^ 0x4F79E0C3;
					continue;
				case 212u:
					SearchResultGrid = Availability.smethod_9();
					num = (int)((num2 * 1994468205) ^ 0x6B9E9701);
					continue;
				case 211u:
					Availability.smethod_30((ButtonBase)(object)NurseBtn, bool_0: true);
					num = (int)((num2 * 1751367908) ^ 0x4818DF0D);
					continue;
				case 210u:
					Availability.smethod_24(Availability.smethod_23((Control)(object)DetailsBox), (Control)(object)Label7);
					num = ((int)num2 * -1240237839) ^ -1924376966;
					continue;
				case 209u:
					PictureBox1 = Availability.smethod_10();
					Availability.smethod_11((Control)(object)GroupBox1);
					Availability.smethod_12((ISupportInitialize)SearchResultGrid);
					num = (int)(num2 * 1303812651) ^ -115430450;
					continue;
				case 208u:
					num = (int)(num2 * 1348606069) ^ -1849695406;
					continue;
				case 207u:
					DOBTxt = Availability.smethod_8();
					num = ((int)num2 * -1920362176) ^ 0x1DE64E4B;
					continue;
				case 206u:
					Availability.smethod_20((Control)(object)Label9, 11);
					num = ((int)num2 * -202596013) ^ 0xA4021AA;
					continue;
				case 205u:
					Availability.smethod_24(Availability.smethod_23((Control)(object)DetailsBox), (Control)(object)DOBTxt);
					num = ((int)num2 * -1073428080) ^ 0x8E16714;
					continue;
				case 203u:
					Availability.smethod_29((ButtonBase)(object)DoctorBtn, "Doctor");
					num = (int)((num2 * 40734108) ^ 0x52CB4AD);
					continue;
				case 202u:
					num = (int)((num2 * 1420796009) ^ 0x384EA655);
					continue;
				case 201u:
					Availability.smethod_19((Control)(object)DetailsBox, new Size(623, 313));
					num = (int)((num2 * 693783062) ^ 0x67489CCC);
					continue;
				case 200u:
					num = ((int)num2 * -454625901) ^ -675774586;
					continue;
				case 199u:
					num = (int)((num2 * 2127564931) ^ 0x2CE08000);
					continue;
				case 198u:
					Availability.smethod_19((Control)(object)SIDTxt, new Size(100, 28));
					Availability.smethod_20((Control)(object)SIDTxt, 4);
					num = ((int)num2 * -687980639) ^ -581183045;
					continue;
				case 197u:
					num = ((int)num2 * -11990185) ^ 0x1D613B70;
					continue;
				case 196u:
					num = (int)((num2 * 1702199155) ^ 0x63092263);
					continue;
				case 195u:
					Availability.smethod_16((Control)(object)Label6, Availability.smethod_15("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					Availability.smethod_17((Control)(object)Label6, new Point(389, 169));
					num = (int)((num2 * 1382523195) ^ 0x988E57);
					continue;
				case 194u:
					Availability.smethod_20((Control)(object)AddressTxt, 7);
					Availability.smethod_17((Control)(object)GenderTxt, new Point(479, 163));
					Availability.smethod_18((Control)(object)GenderTxt, "GenderTxt");
					num = (int)((num2 * 2114460314) ^ 0x402EFE9D);
					continue;
				case 193u:
					Availability.smethod_19((Control)(object)DesignationTxt, new Size(179, 28));
					num = (int)(num2 * 2110004176) ^ -828528750;
					continue;
				case 192u:
					num = (int)((num2 * 650802504) ^ 0x2D4FE038);
					continue;
				case 191u:
					Availability.smethod_20((Control)(object)DesignationTxt, 14);
					num = ((int)num2 * -1915810163) ^ 0x4E1C7024;
					continue;
				case 190u:
					Availability.smethod_21(Label7, "Address : ");
					num = (int)(num2 * 1446617950) ^ -566078388;
					continue;
				case 189u:
					Availability.smethod_18((Control)(object)Label6, "Label6");
					num = ((int)num2 * -1071838785) ^ -515605403;
					continue;
				case 188u:
					num = ((int)num2 * -1365444702) ^ 0x31A565B5;
					continue;
				case 187u:
					Availability.smethod_20((Control)(object)Label7, 3);
					num = (int)((num2 * 291178420) ^ 0x379E98A);
					continue;
				case 186u:
					Label7 = Availability.smethod_4();
					num = (int)(num2 * 1356122978) ^ -919569090;
					continue;
				case 185u:
					num = (int)((num2 * 2134005822) ^ 0x1456232B);
					continue;
				case 184u:
					num = ((int)num2 * -161935749) ^ 0x1CBAAD30;
					continue;
				case 183u:
					Availability.smethod_24(Availability.smethod_23((Control)(object)DetailsBox), (Control)(object)SIDTxt);
					num = (int)((num2 * 1131862756) ^ 0xF09E854);
					continue;
				case 182u:
					Availability.smethod_27((ButtonBase)(object)ClearBtn, Color.MidnightBlue);
					Availability.smethod_16((Control)(object)ClearBtn, Availability.smethod_15("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -831586393) ^ -1406328663;
					continue;
				case 181u:
					num = ((int)num2 * -573319843) ^ -1483042870;
					continue;
				case 180u:
					Availability.smethod_38((Control)(object)this, Color.White);
					num = ((int)num2 * -786853171) ^ 0xE299CC1;
					continue;
				case 179u:
					Availability.smethod_24(Availability.smethod_23((Control)(object)DetailsBox), (Control)(object)MobileTxt);
					Availability.smethod_24(Availability.smethod_23((Control)(object)DetailsBox), (Control)(object)Label9);
					num = (int)((num2 * 737517784) ^ 0x5E38F4A2);
					continue;
				case 178u:
					Availability.smethod_21(Label2, "Name : ");
					Availability.smethod_22(Label2, (ContentAlignment)32);
					num = (int)(num2 * 1453559921) ^ -1861636652;
					continue;
				case 177u:
					Availability.smethod_20((Control)(object)NurseBtn, 6);
					num = ((int)num2 * -1451501) ^ -378060061;
					continue;
				case 176u:
					Availability.smethod_32(ReceptionistBtn, bool_0: true);
					num = ((int)num2 * -832846775) ^ 0x1D995834;
					continue;
				case 175u:
					Availability.smethod_20((Control)(object)NameTxt, 10);
					num = (int)(num2 * 92443369) ^ -1014420209;
					continue;
				case 174u:
					Availability.smethod_22(Label9, (ContentAlignment)32);
					num = ((int)num2 * -175755268) ^ 0x259A0BC3;
					continue;
				case 173u:
					Availability.smethod_52((ISupportInitialize)PictureBox1);
					num = (int)(num2 * 96675814) ^ -1554147585;
					continue;
				case 172u:
					num = ((int)num2 * -1675321008) ^ -832130482;
					continue;
				case 171u:
					Availability.smethod_16((Control)(object)DoctorBtn, Availability.smethod_15("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 731301040) ^ 0x4F82D4F4);
					continue;
				case 170u:
					GroupBox1 = Availability.smethod_5();
					num = ((int)num2 * -247500963) ^ 0x1DFA8251;
					continue;
				case 169u:
					num = ((int)num2 * -555597579) ^ 0xDC23105;
					continue;
				case 168u:
					Availability.smethod_18((Control)(object)Label8, "Label8");
					num = (int)(num2 * 1758806627) ^ -1671618252;
					continue;
				case 167u:
					Availability.smethod_17((Control)(object)PictureBox1, new Point(260, 22));
					Availability.smethod_18((Control)(object)PictureBox1, "PictureBox1");
					num = ((int)num2 * -338316279) ^ 0x56AD6245;
					continue;
				case 166u:
					Availability.smethod_18((Control)(object)NurseBtn, "NurseBtn");
					Availability.smethod_19((Control)(object)NurseBtn, new Size(78, 23));
					num = (int)(num2 * 330036167) ^ -1690081090;
					continue;
				case 165u:
					num = ((int)num2 * -756483223) ^ -674104990;
					continue;
				case 164u:
					num = ((int)num2 * -867086270) ^ -236941849;
					continue;
				case 163u:
					Availability.smethod_19((Control)(object)Label7, new Size(98, 26));
					num = (int)((num2 * 48170053) ^ 0x47477EB1);
					continue;
				case 162u:
					Availability.smethod_21(Label4, "SID :");
					num = ((int)num2 * -576336926) ^ 0x3B590974;
					continue;
				case 161u:
					Availability.smethod_18((Control)(object)DoctorBtn, "DoctorBtn");
					num = ((int)num2 * -1777779032) ^ -755862364;
					continue;
				case 160u:
					num = (int)((num2 * 1225604292) ^ 0x14E2B7B9);
					continue;
				case 159u:
					Availability.smethod_39((TextBoxBase)(object)GenderTxt, bool_0: true);
					num = (int)(num2 * 2123924041) ^ -1203610725;
					continue;
				case 158u:
					Availability.smethod_19((Control)(object)DOBTxt, new Size(128, 28));
					num = ((int)num2 * -252706048) ^ 0x47007A12;
					continue;
				case 157u:
					Availability.smethod_18((Control)(object)DetailsBox, "DetailsBox");
					num = (int)((num2 * 2082078874) ^ 0x1E2250BA);
					continue;
				case 156u:
					Availability.smethod_30((ButtonBase)(object)ReceptionistBtn, bool_0: true);
					num = (int)((num2 * 41844964) ^ 0x490633BC);
					continue;
				case 155u:
					Availability.smethod_20((Control)(object)GroupBox1, 7);
					num = ((int)num2 * -293980693) ^ 0x4568A61D;
					continue;
				case 154u:
					Availability.smethod_19((Control)(object)GroupBox1, new Size(623, 127));
					num = (int)((num2 * 1263109829) ^ 0x18EDCB3C);
					continue;
				case 153u:
					Availability.smethod_18((Control)(object)Label7, "Label7");
					num = (int)((num2 * 2119864986) ^ 0x1C271E5E);
					continue;
				case 152u:
					Availability.smethod_17((Control)(object)SearchResultGrid, new Point(59, 295));
					num = ((int)num2 * -1427365420) ^ 0x51D6E418;
					continue;
				case 151u:
					Availability.smethod_16((Control)(object)SearchBtn, Availability.smethod_15("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 748765537) ^ 0x5AA271F);
					continue;
				case 150u:
					Availability.smethod_17((Control)(object)NameSTxt, new Point(120, 44));
					num = (int)(num2 * 1744957466) ^ -504277356;
					continue;
				case 149u:
					Availability.smethod_51((Control)(object)GroupBox1);
					Availability.smethod_52((ISupportInitialize)SearchResultGrid);
					num = ((int)num2 * -680562031) ^ -1402048772;
					continue;
				case 148u:
					num = ((int)num2 * -2111985721) ^ -1744794126;
					continue;
				case 147u:
					num = (int)((num2 * 814365661) ^ 0x3A12AAE8);
					continue;
				case 146u:
					NurseBtn = Availability.smethod_7();
					num = ((int)num2 * -280120747) ^ -2069015919;
					continue;
				case 145u:
					Availability.smethod_31((ButtonBase)(object)ReceptionistBtn, bool_0: true);
					Availability.smethod_16((Control)(object)ReceptionistBtn, Availability.smethod_15("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 242331092) ^ -2144660693;
					continue;
				case 144u:
					num = (int)(num2 * 191359069) ^ -1526432878;
					continue;
				case 143u:
					num = (int)(num2 * 1443449648) ^ -404226001;
					continue;
				case 142u:
					Availability.smethod_16((Control)(object)NurseBtn, Availability.smethod_15("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1901778525) ^ -113346916;
					continue;
				case 141u:
					num = (int)((num2 * 1987635214) ^ 0x3A183727);
					continue;
				case 140u:
					num = (int)(num2 * 1439561099) ^ -605360789;
					continue;
				case 139u:
					Availability.smethod_24(Availability.smethod_23((Control)(object)GroupBox1), (Control)(object)NameSTxt);
					num = (int)(num2 * 10479453) ^ -1964980731;
					continue;
				case 138u:
					num = (int)((num2 * 571743289) ^ 0x14C4D3F7);
					continue;
				case 137u:
					ReceptionistBtn = Availability.smethod_7();
					num = ((int)num2 * -560213467) ^ -1561262550;
					continue;
				case 136u:
					num = ((int)num2 * -1834853990) ^ 0x4F2EC83A;
					continue;
				case 135u:
					Availability.smethod_17((Control)(object)Label2, new Point(37, 44));
					num = (int)((num2 * 1636708843) ^ 0x9DED598);
					continue;
				case 134u:
					Availability.smethod_18((Control)(object)SearchBtn, "SearchBtn");
					num = ((int)num2 * -1914846963) ^ 0x22E6F7C2;
					continue;
				case 133u:
					Availability.smethod_39((TextBoxBase)(object)AddressTxt, bool_0: true);
					num = (int)((num2 * 1201716629) ^ 0x729E027D);
					continue;
				case 132u:
					Label4 = Availability.smethod_4();
					num = ((int)num2 * -1235772018) ^ 0x19BCCC10;
					continue;
				case 131u:
					num = ((int)num2 * -1576323549) ^ 0x3C338F8A;
					continue;
				case 130u:
					num = (int)(num2 * 921988063) ^ -1889509278;
					continue;
				case 129u:
					Availability.smethod_18((Control)(object)Label9, "Label9");
					Availability.smethod_19((Control)(object)Label9, new Size(77, 28));
					num = (int)(num2 * 1065310253) ^ -316703865;
					continue;
				case 128u:
					Availability.smethod_16((Control)(object)Label3, Availability.smethod_15("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					Availability.smethod_17((Control)(object)Label3, new Point(291, 72));
					num = (int)(num2 * 1032818297) ^ -1473146102;
					continue;
				case 127u:
					num = ((int)num2 * -1104395951) ^ 0x13D5E404;
					continue;
				case 126u:
					Availability.smethod_17((Control)(object)ShowAvailability, new Point(389, 24));
					Availability.smethod_18((Control)(object)ShowAvailability, "ShowAvailability");
					num = (int)(num2 * 188648158) ^ -1574912707;
					continue;
				case 125u:
					SearchBtn = Availability.smethod_6();
					num = ((int)num2 * -1559328617) ^ -1295999979;
					continue;
				case 124u:
					num = ((int)num2 * -1891128821) ^ -1398670202;
					continue;
				case 123u:
					Availability.smethod_24(Availability.smethod_23((Control)(object)DetailsBox), (Control)(object)NameTxt);
					num = (int)((num2 * 706406302) ^ 0x3A4C0F82);
					continue;
				case 122u:
					Availability.smethod_16((Control)(object)Label9, Availability.smethod_15("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1161508868) ^ -2065431304;
					continue;
				case 121u:
					num = (int)((num2 * 1058875906) ^ 0x628EDEF7);
					continue;
				case 120u:
					num = (int)((num2 * 1496573231) ^ 0x2C1CA122);
					continue;
				case 119u:
					Availability.smethod_20((Control)(object)MobileTxt, 12);
					num = ((int)num2 * -355229379) ^ -2098643946;
					continue;
				case 118u:
					num = (int)(num2 * 1884419633) ^ -757813821;
					continue;
				case 117u:
					num = ((int)num2 * -1133425381) ^ 0x953007D;
					continue;
				case 116u:
					Availability.smethod_20((Control)(object)NameSTxt, 1);
					num = (int)(num2 * 1497333325) ^ -2107676142;
					continue;
				case 115u:
					Availability.smethod_19((Control)(object)AddressTxt, new Size(483, 90));
					num = ((int)num2 * -1761249023) ^ 0x2DC5656D;
					continue;
				case 114u:
					Availability.smethod_21(Label8, "Name : ");
					num = ((int)num2 * -1393885531) ^ 0x178B1562;
					continue;
				case 113u:
					Availability.smethod_53((Control)(object)this, bool_0: false);
					Availability.smethod_54((Control)(object)this);
					num = (int)((num2 * 530467164) ^ 0x2396B857);
					continue;
				case 112u:
					Availability.smethod_17((Control)(object)DOBTxt, new Point(479, 121));
					num = (int)((num2 * 1423630469) ^ 0x43C38641);
					continue;
				case 111u:
					Availability.smethod_17((Control)(object)GroupBox1, new Point(155, 150));
					num = ((int)num2 * -1072107033) ^ -1988595503;
					continue;
				case 110u:
					Availability.smethod_22(Label8, (ContentAlignment)32);
					Availability.smethod_17((Control)(object)AddressTxt, new Point(124, 217));
					Availability.smethod_40(AddressTxt, bool_0: true);
					num = (int)(num2 * 212873714) ^ -1275564861;
					continue;
				case 109u:
					Availability.smethod_50((Control)(object)GroupBox1, bool_0: false);
					num = (int)((num2 * 1215821561) ^ 0x3D2CAC2);
					continue;
				case 108u:
					num = (int)((num2 * 373686496) ^ 0x74A5E165);
					continue;
				case 107u:
					Availability.smethod_16((Control)(object)Label1, Availability.smethod_15("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1010375369) ^ -900832709;
					continue;
				case 106u:
					Availability.smethod_18((Control)(object)SearchResultGrid, "SearchResultGrid");
					num = ((int)num2 * -1736346253) ^ 0x2B81339B;
					continue;
				case 105u:
					Availability.smethod_14(Label1, bool_0: true);
					num = (int)((num2 * 1188158884) ^ 0x2CFDCA0C);
					continue;
				case 104u:
					Availability.smethod_17((Control)(object)Label1, new Point(392, 63));
					Availability.smethod_18((Control)(object)Label1, "Label1");
					num = (int)(num2 * 631687250) ^ -928316233;
					continue;
				case 103u:
					Availability.smethod_39((TextBoxBase)(object)SIDTxt, bool_0: true);
					num = ((int)num2 * -1341820157) ^ 0x7C899B98;
					continue;
				case 102u:
					Availability.smethod_18((Control)(object)DesignationTxt, "DesignationTxt");
					num = ((int)num2 * -533727565) ^ 0x38CBFBC8;
					continue;
				case 101u:
					Availability.smethod_19((Control)(object)Label2, new Size(77, 28));
					num = (int)((num2 * 1287743589) ^ 0x68502859);
					continue;
				case 100u:
					Availability.smethod_19((Control)(object)SearchBtn, new Size(133, 37));
					Availability.smethod_20((Control)(object)SearchBtn, 4);
					Availability.smethod_29((ButtonBase)(object)SearchBtn, "Search");
					Availability.smethod_30((ButtonBase)(object)SearchBtn, bool_0: false);
					num = ((int)num2 * -142834023) ^ -1555900138;
					continue;
				case 99u:
					Availability.smethod_17((Control)(object)Label4, new Point(25, 77));
					num = ((int)num2 * -221468624) ^ 0x1B0BB173;
					continue;
				case 98u:
					Availability.smethod_24(Availability.smethod_23((Control)(object)GroupBox1), (Control)(object)ClearBtn);
					num = ((int)num2 * -621070755) ^ 0x452C6779;
					continue;
				case 97u:
					num = ((int)num2 * -1493161510) ^ 0x6847965;
					continue;
				case 96u:
					num = (int)((num2 * 597202068) ^ 0x2B9FA67D);
					continue;
				case 95u:
					num = (int)((num2 * 144184466) ^ 0x4DAA3E6A);
					continue;
				case 94u:
					num = ((int)num2 * -2078390520) ^ 0x2D3BD5B;
					continue;
				case 93u:
					num = ((int)num2 * -1852876502) ^ -1237881110;
					continue;
				case 92u:
					num = (int)((num2 * 1681308674) ^ 0x1BC8BE8);
					continue;
				case 91u:
					Availability.smethod_18((Control)(object)SIDTxt, "SIDTxt");
					num = ((int)num2 * -2058803065) ^ 0x1CA7C3D2;
					continue;
				case 90u:
					Availability.smethod_24(Availability.smethod_47((Control)(object)this), (Control)(object)PictureBox1);
					Availability.smethod_48((Control)(object)this, "Availability");
					num = ((int)num2 * -1782762113) ^ 0x288A2962;
					continue;
				case 89u:
					Availability.smethod_18((Control)(object)AddressTxt, "AddressTxt");
					num = (int)(num2 * 1583064821) ^ -2141641438;
					continue;
				case 88u:
					Availability.smethod_18((Control)(object)Label3, "Label3");
					num = (int)(num2 * 1404258711) ^ -1193322092;
					continue;
				case 87u:
					num = ((int)num2 * -520921677) ^ 0x38A95C7E;
					continue;
				case 86u:
					Availability.smethod_20((Control)(object)GenderTxt, 6);
					num = ((int)num2 * -1383096806) ^ 0x169F64A5;
					continue;
				case 85u:
					ClearBtn = Availability.smethod_6();
					num = ((int)num2 * -1233214481) ^ 0x24277734;
					continue;
				case 84u:
					Availability.smethod_30((ButtonBase)(object)DoctorBtn, bool_0: true);
					num = ((int)num2 * -27773886) ^ -378434769;
					continue;
				case 83u:
					Availability.smethod_18((Control)(object)NameSTxt, "NameSTxt");
					Availability.smethod_19((Control)(object)NameSTxt, new Size(292, 28));
					num = (int)(num2 * 124875153) ^ -1735922441;
					continue;
				case 82u:
					num = ((int)num2 * -1769506961) ^ -656577926;
					continue;
				case 81u:
					Availability.smethod_17((Control)(object)Label7, new Point(16, 217));
					num = (int)(num2 * 1203508179) ^ -1810836023;
					continue;
				case 80u:
					num = ((int)num2 * -1750323212) ^ 0x2C92F5E4;
					continue;
				case 79u:
					Availability.smethod_18((Control)(object)MobileTxt, "MobileTxt");
					Availability.smethod_39((TextBoxBase)(object)MobileTxt, bool_0: true);
					num = ((int)num2 * -1091832253) ^ -131886020;
					continue;
				case 78u:
					num = ((int)num2 * -1346986579) ^ -984567646;
					continue;
				case 77u:
					num = ((int)num2 * -698299395) ^ -199368837;
					continue;
				case 76u:
					Availability.smethod_19((Control)(object)ClearBtn, new Size(133, 37));
					num = (int)((num2 * 583234223) ^ 0x4C67D254);
					continue;
				case 75u:
					Availability.smethod_19((Control)(object)Label3, new Size(121, 28));
					num = ((int)num2 * -1049886506) ^ -947820060;
					continue;
				case 74u:
					Availability.smethod_16((Control)(object)GroupBox1, Availability.smethod_15("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -122928722) ^ 0x17DE2865;
					continue;
				case 73u:
					Availability.smethod_31((ButtonBase)(object)NurseBtn, bool_0: true);
					num = (int)(num2 * 1931717186) ^ -2050486589;
					continue;
				case 72u:
					Availability.smethod_17((Control)(object)Label5, new Point(389, 123));
					num = (int)((num2 * 1719543656) ^ 0x4A228FBF);
					continue;
				case 71u:
					Availability.smethod_17((Control)(object)NurseBtn, new Point(174, 84));
					num = ((int)num2 * -891823674) ^ -1941437849;
					continue;
				case 70u:
					Availability.smethod_32(NurseBtn, bool_0: true);
					num = ((int)num2 * -631049772) ^ 0xAD37A1E;
					continue;
				case 69u:
					Availability.smethod_19((Control)(object)SearchResultGrid, new Size(853, 169));
					num = ((int)num2 * -603909353) ^ -1552938976;
					continue;
				case 68u:
					DesignationTxt = Availability.smethod_8();
					num = ((int)num2 * -598280297) ^ -222370269;
					continue;
				case 67u:
					Availability.smethod_22(ShowAvailability, (ContentAlignment)32);
					Availability.smethod_17((Control)(object)DesignationTxt, new Point(428, 71));
					num = ((int)num2 * -358255573) ^ -578411270;
					continue;
				case 66u:
					Availability.smethod_37(Availability.smethod_36(SearchResultGrid), 24);
					num = (int)(num2 * 566071734) ^ -610727428;
					continue;
				case 65u:
					num = (int)(num2 * 139573284) ^ -229635958;
					continue;
				case 64u:
					Availability.smethod_16((Control)(object)Label7, Availability.smethod_15("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1966397305) ^ 0x21FEEF30;
					continue;
				case 63u:
					num = (int)((num2 * 1852411436) ^ 0x77FE2600);
					continue;
				case 62u:
					num = (int)(num2 * 1997474765) ^ -1518801886;
					continue;
				case 61u:
					Availability.smethod_35(SearchResultGrid, bool_0: true);
					num = (int)((num2 * 1503526435) ^ 0x75DC4D29);
					continue;
				case 60u:
					Availability.smethod_21(Label5, "D.O.B. :");
					num = (int)((num2 * 848382430) ^ 0x37134F82);
					continue;
				case 59u:
					num = ((int)num2 * -452065154) ^ 0x3632E936;
					continue;
				case 58u:
					num = (int)((num2 * 1745906775) ^ 0x20DF137A);
					continue;
				case 57u:
					Availability.smethod_18((Control)(object)Label2, "Label2");
					num = (int)(num2 * 142097420) ^ -1068980484;
					continue;
				case 56u:
					Availability.smethod_20((Control)(object)SearchResultGrid, 8);
					Availability.smethod_24(Availability.smethod_23((Control)(object)DetailsBox), (Control)(object)ShowAvailability);
					Availability.smethod_24(Availability.smethod_23((Control)(object)DetailsBox), (Control)(object)DesignationTxt);
					num = ((int)num2 * -1300633005) ^ 0x10BA820C;
					continue;
				case 55u:
					num = (int)(num2 * 1142563528) ^ -904745775;
					continue;
				case 54u:
					Availability.smethod_19((Control)(object)Label6, new Size(84, 26));
					num = ((int)num2 * -1090626577) ^ -1139842725;
					continue;
				case 53u:
					Availability.smethod_32(DoctorBtn, bool_0: true);
					num = (int)(num2 * 234929968) ^ -1529708001;
					continue;
				case 52u:
					Label6 = Availability.smethod_4();
					num = ((int)num2 * -1297075901) ^ -194948844;
					continue;
				case 51u:
					num = ((int)num2 * -2037838353) ^ 0x5A0EA0A0;
					continue;
				case 50u:
					Availability.smethod_20((Control)(object)ClearBtn, 8);
					Availability.smethod_29((ButtonBase)(object)ClearBtn, "Clear");
					Availability.smethod_30((ButtonBase)(object)ClearBtn, bool_0: false);
					num = ((int)num2 * -95609173) ^ -1482217057;
					continue;
				case 49u:
					num = ((int)num2 * -1269682021) ^ 0x48E6BE4A;
					continue;
				case 48u:
					Availability.smethod_12((ISupportInitialize)PictureBox1);
					num = ((int)num2 * -2028189738) ^ -1848208826;
					continue;
				case 47u:
					num = ((int)num2 * -782650799) ^ 0x3A84FFBF;
					continue;
				case 46u:
					Availability.smethod_19((Control)(object)ShowAvailability, new Size(218, 23));
					num = ((int)num2 * -512820408) ^ 0x345DAA81;
					continue;
				case 45u:
					Availability.smethod_24(Availability.smethod_23((Control)(object)GroupBox1), (Control)(object)ReceptionistBtn);
					Availability.smethod_24(Availability.smethod_23((Control)(object)GroupBox1), (Control)(object)NurseBtn);
					num = (int)((num2 * 1082064454) ^ 0x103CA00);
					continue;
				case 44u:
					Availability.smethod_19((Control)(object)NameTxt, new Size(241, 28));
					num = (int)((num2 * 889391304) ^ 0x57547C84);
					continue;
				case 43u:
					Availability.smethod_41(PictureBox1, (Image)(object)Resources.images);
					num = (int)(num2 * 1252496630) ^ -38932616;
					continue;
				case 42u:
					num = ((int)num2 * -2111517677) ^ -514611800;
					continue;
				case 41u:
					Availability.smethod_17((Control)(object)Label9, new Point(16, 169));
					num = ((int)num2 * -679504440) ^ -14317551;
					continue;
				case 40u:
					num = (int)(num2 * 125362600) ^ -589241736;
					continue;
				case 39u:
					Availability.smethod_20((Control)(object)Label4, 0);
					num = ((int)num2 * -388522627) ^ 0x320F2164;
					continue;
				case 38u:
					Availability.smethod_31((ButtonBase)(object)DoctorBtn, bool_0: true);
					num = (int)(num2 * 293604315) ^ -1961000484;
					continue;
				case 37u:
					Availability.smethod_13((Control)(object)this);
					num = ((int)num2 * -1594171840) ^ -760994109;
					continue;
				case 36u:
					Availability.smethod_39((TextBoxBase)(object)DOBTxt, bool_0: true);
					num = (int)(num2 * 1707286417) ^ -289333244;
					continue;
				case 35u:
					Availability.smethod_17((Control)(object)SIDTxt, new Point(124, 77));
					num = (int)((num2 * 2119316108) ^ 0x7C1C159F);
					continue;
				case 34u:
					Availability.smethod_18((Control)(object)Label5, "Label5");
					num = ((int)num2 * -1408361229) ^ 0x4A1AA26D;
					continue;
				case 33u:
					Availability.smethod_29((ButtonBase)(object)ReceptionistBtn, "Receptionist");
					num = (int)(num2 * 1761942153) ^ -133569188;
					continue;
				case 32u:
					Availability.smethod_51((Control)(object)DetailsBox);
					num = (int)((num2 * 2081350563) ^ 0x4750C657);
					continue;
				case 31u:
					Availability.smethod_19((Control)(object)Label4, new Size(68, 25));
					num = ((int)num2 * -1358850704) ^ -1631370613;
					continue;
				case 30u:
					Availability.smethod_20((Control)(object)Label5, 1);
					num = ((int)num2 * -1423243045) ^ 0x57B34094;
					continue;
				case 29u:
					Availability.smethod_44(PictureBox1, bool_0: false);
					num = (int)(num2 * 358556285) ^ -730601969;
					continue;
				case 28u:
					Availability.smethod_20((Control)(object)Label2, 0);
					num = (int)(num2 * 338183337) ^ -165829140;
					continue;
				case 27u:
					Availability.smethod_26(GroupBox1, "Search Staff Member");
					num = (int)((num2 * 1478212165) ^ 0x33745208);
					continue;
				case 26u:
					num = ((int)num2 * -1974012139) ^ -201358999;
					continue;
				case 25u:
					Availability.smethod_17((Control)(object)ClearBtn, new Point(467, 30));
					num = (int)((num2 * 166172834) ^ 0x380947E2);
					continue;
				case 24u:
					Availability.smethod_19((Control)(object)PictureBox1, new Size(126, 122));
					num = (int)(num2 * 139630089) ^ -684250989;
					continue;
				case 23u:
					num = (int)((num2 * 264434128) ^ 0x52224A97);
					continue;
				case 22u:
					num = ((int)num2 * -449472203) ^ -1639516822;
					continue;
				case 21u:
					num = ((int)num2 * -497959746) ^ 0x5F6B2333;
					continue;
				case 20u:
					Availability.smethod_17((Control)(object)NameTxt, new Point(124, 123));
					num = (int)(num2 * 597532429) ^ -227093697;
					continue;
				case 19u:
					Availability.smethod_24(Availability.smethod_23((Control)(object)DetailsBox), (Control)(object)Label3);
					num = (int)((num2 * 856059633) ^ 0x9EB8F3E);
					continue;
				case 18u:
					num = (int)((num2 * 1887981575) ^ 0x3BEA1DA8);
					continue;
				case 17u:
					num = (int)((num2 * 1943609221) ^ 0x2C22858F);
					continue;
				case 16u:
					MobileTxt = Availability.smethod_8();
					Label9 = Availability.smethod_4();
					num = ((int)num2 * -781227866) ^ 0x63AAD44C;
					continue;
				case 15u:
					Availability.smethod_46((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 965793166) ^ -856437539;
					continue;
				case 14u:
					Availability.smethod_45((ContainerControl)(object)this, new SizeF(8f, 16f));
					num = ((int)num2 * -1628225503) ^ -1256847433;
					continue;
				case 13u:
					Availability.smethod_24(Availability.smethod_23((Control)(object)DetailsBox), (Control)(object)Label8);
					num = (int)((num2 * 1055240480) ^ 0x6C16E44F);
					continue;
				case 12u:
					num = ((int)num2 * -20586535) ^ -1501319229;
					continue;
				case 11u:
					num = ((int)num2 * -1848256463) ^ -1110397642;
					continue;
				case 10u:
					Label2 = Availability.smethod_4();
					num = ((int)num2 * -1099267836) ^ -1682511515;
					continue;
				case 9u:
					Availability.smethod_20((Control)(object)DOBTxt, 5);
					num = ((int)num2 * -1139130871) ^ 0x24078AC3;
					continue;
				case 8u:
					num = ((int)num2 * -606970343) ^ 0x630B6B51;
					continue;
				case 7u:
					num = ((int)num2 * -114386831) ^ -1463025231;
					continue;
				case 6u:
					Availability.smethod_16((Control)(object)DetailsBox, Availability.smethod_15("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					Availability.smethod_17((Control)(object)DetailsBox, new Point(155, 470));
					num = ((int)num2 * -1507126466) ^ 0x76CF7C18;
					continue;
				case 5u:
					Availability.smethod_24(Availability.smethod_23((Control)(object)DetailsBox), (Control)(object)Label6);
					num = (int)((num2 * 1507094100) ^ 0x761F6474);
					continue;
				case 4u:
					num = (int)(num2 * 576340654) ^ -1809435729;
					continue;
				case 3u:
					Availability.smethod_18((Control)(object)Label4, "Label4");
					num = (int)((num2 * 1470471014) ^ 0x4A4C55A6);
					continue;
				case 2u:
					num = ((int)num2 * -1314215009) ^ -1031791083;
					continue;
				case 1u:
					num = ((int)num2 * -1627767242) ^ 0x15B85418;
					continue;
				case 0u:
					Availability.smethod_24(Availability.smethod_47((Control)(object)this), (Control)(object)DetailsBox);
					num = ((int)num2 * -524201084) ^ 0x48543853;
					continue;
				default:
					return;
				case 214u:
					break;
				case 204u:
					return;
				}
				break;
			}
		}
	}

	private void Availability_Load(object sender, EventArgs e)
	{
		Availability.smethod_62(myconnection, Availability.smethod_61(MyProject.Forms.Form1.provider, MyProject.Forms.Form1.datafile));
		while (true)
		{
			int num = 1650888596;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x762DD32Fu) % 4u)
				{
				case 3u:
					Designation = "";
					close();
					num = ((int)num2 * -775112956) ^ -2093225719;
					continue;
				case 2u:
					num = ((int)num2 * -1658721653) ^ -430790588;
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

	private void SearchBtn_Click(object sender, EventArgs e)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Expected I4, but got Unknown
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected I4, but got Unknown
		//IL_02fa: Incompatible stack heights: 0 vs 1
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Incompatible stack heights: 0 vs 1
		//IL_0330: Incompatible stack heights: 0 vs 1
		//IL_0337: Incompatible stack heights: 0 vs 1
		bool flag2 = default(bool);
		DataTable dataTable_ = default(DataTable);
		OleDbDataAdapter dbDataAdapter_ = default(OleDbDataAdapter);
		bool flag = default(bool);
		while (true)
		{
			int num = -1970071083;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB95B6089u) % 7u)
				{
				case 5u:
					close();
					num = ((int)num2 * -1868312263) ^ -1126725882;
					continue;
				case 3u:
					flag2 = Availability.smethod_63(Designation, "", bool_0: false) == 0;
					num = (int)(num2 * 20731527) ^ -350103162;
					continue;
				case 2u:
					Availability.smethod_64("click designation");
					num = ((int)num2 * -2049284064) ^ 0x3B59ECAF;
					continue;
				case 0u:
				{
					int num6;
					int num7;
					if (flag2)
					{
						num6 = 528750009;
						num7 = 528750009;
					}
					else
					{
						num6 = 1227273532;
						num7 = 1227273532;
					}
					num = num6 ^ ((int)num2 * -1771132128);
					continue;
				}
				case 4u:
					break;
				default:
					try
					{
						while (true)
						{
							int num3 = -216507775;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xB95B6089u) % 15u)
								{
								case 14u:
									Availability.smethod_77((Control)(object)SearchResultGrid);
									num3 = ((int)num2 * -1543108561) ^ 0x2B253795;
									continue;
								case 13u:
									num3 = (int)((num2 * 953234238) ^ 0x29620E2E);
									continue;
								case 12u:
									dataTable_ = Availability.smethod_65();
									dbDataAdapter_ = Availability.smethod_66();
									Availability.smethod_67(myconnection);
									num3 = (int)((num2 * 724196647) ^ 0x792F3E11);
									continue;
								case 10u:
									num3 = ((int)num2 * -2069280375) ^ -1617962123;
									continue;
								case 8u:
									Availability.smethod_71((DbDataAdapter)(object)dbDataAdapter_, dataTable_);
									num3 = (int)(num2 * 1062004617) ^ -1991954977;
									continue;
								case 7u:
									num3 = ((int)num2 * -1414993588) ^ 0x2E0CA109;
									continue;
								case 5u:
									flag = Availability.smethod_74(SearchResultGrid) == 1;
									num3 = (int)((num2 * 1941898705) ^ 0x2ADD7C41);
									continue;
								case 4u:
									num3 = -1525980123;
									continue;
								case 3u:
									Availability.smethod_73(SearchResultGrid, (object)Availability.smethod_72(dataTable_));
									num3 = (int)(num2 * 2008451766) ^ -492028136;
									continue;
								case 2u:
									Availability.smethod_76(myconnection);
									num3 = ((int)num2 * -884126216) ^ 0x73A0F04B;
									continue;
								case 1u:
								{
									int num4;
									int num5;
									if (!flag)
									{
										num4 = 920819884;
										num5 = 920819884;
									}
									else
									{
										num4 = 406021805;
										num5 = 406021805;
									}
									num3 = num4 ^ ((int)num2 * -1861386608);
									continue;
								}
								case 0u:
									dbDataAdapter_ = Availability.smethod_70(Availability.smethod_69(new string[5]
									{
										"Select * from Staff where Name like '%",
										Availability.smethod_68(NameSTxt),
										"%'  And   Designation = '",
										Designation,
										"'"
									}), myconnection);
									num3 = ((int)num2 * -878975551) ^ 0xA46736B;
									continue;
								case 9u:
									break;
								case 6u:
									Availability.smethod_75("Not Found.", "Result");
									Availability.smethod_76(myconnection);
									return;
								default:
									HideunusedColumns();
									return;
								}
								break;
							}
						}
					}
					catch (Exception exception_)
					{
						Availability.smethod_78(exception_);
						while (true)
						{
							_ = -1960398814;
							while (true)
							{
								_003F val = /*Error near IL_02cc: Stack underflow*/^ -1185193847;
								num2 = (uint)(int)val;
								switch (val % 5)
								{
								case 4:
									_ = (num2 * 1642843255) ^ 0x8831295Bu;
									continue;
								case 3:
									Availability.smethod_64("Incorrect Credentials");
									_ = ((int)num2 * -1523595194) ^ 0x7A60F210;
									continue;
								case 0:
									Availability.smethod_76(myconnection);
									_ = (num2 * 1776728244) ^ 0xF3AEA9D5u;
									continue;
								case 2:
									break;
								default:
									Availability.smethod_79();
									return;
								}
								break;
							}
						}
					}
				case 6u:
					return;
				}
				break;
			}
		}
	}

	private bool HideunusedColumns()
	{
		bool result = default(bool);
		while (true)
		{
			int num = 773446328;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x725CF53Bu) % 6u)
				{
				case 4u:
					num = (int)((num2 * 1543937196) ^ 0x22BFB0C4);
					continue;
				case 3u:
					Availability.smethod_82(Availability.smethod_81(Availability.smethod_80(SearchResultGrid), 7), bool_0: false);
					num = ((int)num2 * -71132919) ^ 0x3D52BBA2;
					continue;
				case 2u:
					Availability.smethod_82(Availability.smethod_81(Availability.smethod_80(SearchResultGrid), 9), bool_0: false);
					num = (int)(num2 * 1250757672) ^ -1606900956;
					continue;
				case 1u:
					result = false;
					num = ((int)num2 * -1838044885) ^ 0x21FF9058;
					continue;
				case 0u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	private void RadioButton1_CheckedChanged(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -228322865;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE113AD1Bu) % 3u)
				{
				case 1u:
					goto IL_0003;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0003:
				Designation = "Doctor";
				num = ((int)num2 * -1185007209) ^ 0x21768DE0;
			}
		}
	}

	private void RadioButton2_CheckedChanged(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -888621522;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB68DA7F9u) % 3u)
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
				Designation = "Nurse";
				num = ((int)num2 * -520732373) ^ -994656924;
			}
		}
	}

	private void RadioButton3_CheckedChanged(object sender, EventArgs e)
	{
		Designation = "Receptionist";
	}

	private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Expected I4, but got Unknown
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Expected I4, but got Unknown
		//IL_03b6: Incompatible stack heights: 0 vs 1
		//IL_03bd: Incompatible stack heights: 0 vs 1
		int int_ = default(int);
		DataGridViewRow dataGridViewRow_ = default(DataGridViewRow);
		bool flag = default(bool);
		while (true)
		{
			int num = 1372673069;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4325CD08u) % 5u)
				{
				case 2u:
				{
					int num6;
					int num7;
					if ((checked(Availability.smethod_83(e) + 1) == Availability.smethod_74(SearchResultGrid)) | (Availability.smethod_83(e) == -1))
					{
						num6 = 577585787;
						num7 = 577585787;
					}
					else
					{
						num6 = 1799005694;
						num7 = 1799005694;
					}
					num = num6 ^ (int)(num2 * 1525444134);
					continue;
				}
				case 1u:
					int_ = Availability.smethod_83(e);
					Availability.smethod_84((Control)(object)DetailsBox, bool_0: true);
					num = 1508099089;
					continue;
				case 0u:
					break;
				default:
					try
					{
						while (true)
						{
							int num3 = 1206480041;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x4325CD08u) % 20u)
								{
								case 19u:
									Availability.smethod_92(DesignationTxt, Availability.smethod_91(Availability.smethod_90(Availability.smethod_89(Availability.smethod_88(dataGridViewRow_), 2))));
									num3 = (int)((num2 * 395533896) ^ 0x1395D92C);
									continue;
								case 18u:
									Availability.smethod_92(DOBTxt, Availability.smethod_93(Availability.smethod_90(Availability.smethod_89(Availability.smethod_88(dataGridViewRow_), 3))));
									num3 = (int)((num2 * 1807013462) ^ 0x32E6B734);
									continue;
								case 17u:
									num3 = (int)(num2 * 1577082119) ^ -1747822416;
									continue;
								case 16u:
									num3 = (int)(num2 * 276846101) ^ -997631318;
									continue;
								case 15u:
									Availability.smethod_92(NameTxt, Availability.smethod_91(Availability.smethod_90(Availability.smethod_89(Availability.smethod_88(dataGridViewRow_), 1))));
									num3 = ((int)num2 * -1312019108) ^ -1442963937;
									continue;
								case 14u:
									colourgreen();
									num3 = (int)((num2 * 1483591898) ^ 0x3476FD53);
									continue;
								case 13u:
									num3 = ((int)num2 * -1732126888) ^ 0x6B3E61ED;
									continue;
								case 12u:
									num3 = (int)(num2 * 100610696) ^ -2124080906;
									continue;
								case 11u:
									Availability.smethod_92(AddressTxt, Availability.smethod_91(Availability.smethod_90(Availability.smethod_89(Availability.smethod_88(dataGridViewRow_), 6))));
									num3 = (int)((num2 * 1737378078) ^ 0x7A429969);
									continue;
								case 10u:
									Availability.smethod_92(GenderTxt, Availability.smethod_91(Availability.smethod_90(Availability.smethod_89(Availability.smethod_88(dataGridViewRow_), 4))));
									num3 = ((int)num2 * -1213873081) ^ 0x4748F68;
									continue;
								case 8u:
									colourred();
									num3 = 469682086;
									continue;
								case 7u:
									num3 = ((int)num2 * -1477543631) ^ 0x78109762;
									continue;
								case 6u:
									num3 = ((int)num2 * -1549294506) ^ -1555822211;
									continue;
								case 5u:
									dataGridViewRow_ = Availability.smethod_85();
									dataGridViewRow_ = Availability.smethod_87(Availability.smethod_86(SearchResultGrid), int_);
									num3 = (int)(num2 * 1118315110) ^ -859456414;
									continue;
								case 4u:
									Availability.smethod_92(SIDTxt, Availability.smethod_91(Availability.smethod_90(Availability.smethod_89(Availability.smethod_88(dataGridViewRow_), 0))));
									num3 = (int)(num2 * 333106005) ^ -659747549;
									continue;
								case 3u:
									Availability.smethod_92(MobileTxt, Availability.smethod_91(Availability.smethod_90(Availability.smethod_89(Availability.smethod_88(dataGridViewRow_), 5))));
									num3 = (int)((num2 * 1268054136) ^ 0xB31AF21);
									continue;
								case 2u:
									flag = Availability.smethod_94((object)Shift(), Availability.smethod_90(Availability.smethod_89(Availability.smethod_88(dataGridViewRow_), 8)), bool_0: false);
									num3 = (int)(num2 * 907257666) ^ -316632812;
									continue;
								case 0u:
								{
									int num4;
									int num5;
									if (flag)
									{
										num4 = -1707041810;
										num5 = -1707041810;
									}
									else
									{
										num4 = -802902444;
										num5 = -802902444;
									}
									num3 = num4 ^ (int)(num2 * 2008932320);
									continue;
								}
								default:
									return;
								case 9u:
									break;
								case 1u:
									return;
								}
								break;
							}
						}
					}
					catch (Exception exception_)
					{
						Availability.smethod_78(exception_);
						while (true)
						{
							_ = 803059607;
							while (true)
							{
								_003F val = /*Error near IL_0390: Stack underflow*/^ 0x4325CD08;
								num2 = (uint)(int)val;
								switch (val % 3)
								{
								case 1:
									_ = (num2 * 616377970) ^ 0x37019618;
									continue;
								case 2:
									break;
								default:
									Availability.smethod_79();
									return;
								}
								break;
							}
						}
					}
				case 4u:
					return;
				}
				break;
			}
		}
	}

	private void close()
	{
		while (true)
		{
			int num = -1875848734;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA8C953D7u) % 3u)
				{
				case 2u:
					goto IL_0003;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0003:
				Availability.smethod_84((Control)(object)DetailsBox, bool_0: false);
				Availability.smethod_95((Control)(object)SearchResultGrid);
				num = ((int)num2 * -1995732860) ^ 0x50C45515;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		Availability.smethod_96((TextBoxBase)(object)NameSTxt);
		while (true)
		{
			int num = -1615907786;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9EF0E505u) % 10u)
				{
				case 9u:
					Availability.smethod_97(NurseBtn, bool_0: false);
					num = ((int)num2 * -1435881522) ^ -491414981;
					continue;
				case 8u:
					Availability.smethod_97(ReceptionistBtn, bool_0: false);
					num = (int)((num2 * 795574427) ^ 0x2B62010C);
					continue;
				case 7u:
					Designation = "";
					num = (int)(num2 * 1396113296) ^ -1574958737;
					continue;
				case 6u:
					num = ((int)num2 * -929017991) ^ -795937712;
					continue;
				case 5u:
					Availability.smethod_97(DoctorBtn, bool_0: false);
					num = (int)((num2 * 1450605373) ^ 0x14DCAAA1);
					continue;
				case 3u:
					Availability.smethod_84((Control)(object)DetailsBox, bool_0: false);
					num = ((int)num2 * -349873077) ^ -1336110011;
					continue;
				case 2u:
					Availability.smethod_95((Control)(object)SearchResultGrid);
					num = ((int)num2 * -273516046) ^ 0x29CBDE01;
					continue;
				case 1u:
					num = (int)(num2 * 1513803052) ^ -1762601673;
					continue;
				default:
					return;
				case 4u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	private string Shift()
	{
		if ((day >= 7) & (day <= 19))
		{
			goto IL_0033;
		}
		goto IL_0085;
		IL_0085:
		int num = -2041743472;
		goto IL_005c;
		IL_005c:
		string result = default(string);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x932348E7u) % 6u)
			{
			case 5u:
				result = "Day";
				num = ((int)num2 * -15930038) ^ 0x58A9E25D;
				continue;
			case 2u:
				break;
			case 1u:
				result = "Night";
				num = (int)((num2 * 1457390388) ^ 0x788AA0E9);
				continue;
			case 0u:
				num = (int)((num2 * 1688022041) ^ 0x1EE1CA3D);
				continue;
			case 3u:
				goto IL_0085;
			default:
				return result;
			}
			break;
		}
		goto IL_0033;
		IL_0033:
		num = -1955942966;
		goto IL_005c;
	}

	private void colourgreen()
	{
		while (true)
		{
			int num = 714497784;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x45350429u) % 4u)
				{
				case 1u:
					Availability.smethod_38((Control)(object)ShowAvailability, Color.Green);
					num = (int)(num2 * 1067185500) ^ -801779731;
					continue;
				case 0u:
					Availability.smethod_21(ShowAvailability, "Available");
					num = (int)(num2 * 502989882) ^ -1354885046;
					continue;
				default:
					return;
				case 2u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	private void colourred()
	{
		while (true)
		{
			int num = -1010130872;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB3E65AC4u) % 5u)
				{
				case 2u:
					num = (int)((num2 * 1061841900) ^ 0x1B5E7B04);
					continue;
				case 1u:
					Availability.smethod_38((Control)(object)ShowAvailability, Color.Red);
					num = (int)(num2 * 1392295598) ^ -439275892;
					continue;
				case 0u:
					Availability.smethod_21(ShowAvailability, "Unavailable");
					num = (int)((num2 * 1710660105) ^ 0x52A1FFB4);
					continue;
				default:
					return;
				case 3u:
					break;
				case 4u:
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

	static int smethod_2(string string_0)
	{
		return Conversions.ToInteger(string_0);
	}

	static void smethod_3(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
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

	static DataGridView smethod_9()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new DataGridView();
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

	static void smethod_14(Label label_0, bool bool_0)
	{
		label_0.set_AutoSize(bool_0);
	}

	static Font smethod_15(string string_0, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_16(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static void smethod_17(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_18(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_19(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_20(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static void smethod_21(Label label_0, string string_0)
	{
		label_0.set_Text(string_0);
	}

	static void smethod_22(Label label_0, ContentAlignment contentAlignment_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		label_0.set_TextAlign(contentAlignment_0);
	}

	static ControlCollection smethod_23(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_24(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_25(GroupBox groupBox_0, bool bool_0)
	{
		groupBox_0.set_TabStop(bool_0);
	}

	static void smethod_26(GroupBox groupBox_0, string string_0)
	{
		groupBox_0.set_Text(string_0);
	}

	static void smethod_27(ButtonBase buttonBase_0, Color color_0)
	{
		buttonBase_0.set_BackColor(color_0);
	}

	static void smethod_28(Control control_0, Color color_0)
	{
		control_0.set_ForeColor(color_0);
	}

	static void smethod_29(ButtonBase buttonBase_0, string string_0)
	{
		buttonBase_0.set_Text(string_0);
	}

	static void smethod_30(ButtonBase buttonBase_0, bool bool_0)
	{
		buttonBase_0.set_UseVisualStyleBackColor(bool_0);
	}

	static void smethod_31(ButtonBase buttonBase_0, bool bool_0)
	{
		buttonBase_0.set_AutoSize(bool_0);
	}

	static void smethod_32(RadioButton radioButton_0, bool bool_0)
	{
		radioButton_0.set_TabStop(bool_0);
	}

	static void smethod_33(DataGridView dataGridView_0, Color color_0)
	{
		dataGridView_0.set_BackgroundColor(color_0);
	}

	static void smethod_34(DataGridView dataGridView_0, DataGridViewColumnHeadersHeightSizeMode dataGridViewColumnHeadersHeightSizeMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		dataGridView_0.set_ColumnHeadersHeightSizeMode(dataGridViewColumnHeadersHeightSizeMode_0);
	}

	static void smethod_35(DataGridView dataGridView_0, bool bool_0)
	{
		dataGridView_0.set_ReadOnly(bool_0);
	}

	static DataGridViewRow smethod_36(DataGridView dataGridView_0)
	{
		return dataGridView_0.get_RowTemplate();
	}

	static void smethod_37(DataGridViewRow dataGridViewRow_0, int int_0)
	{
		dataGridViewRow_0.set_Height(int_0);
	}

	static void smethod_38(Control control_0, Color color_0)
	{
		control_0.set_BackColor(color_0);
	}

	static void smethod_39(TextBoxBase textBoxBase_0, bool bool_0)
	{
		textBoxBase_0.set_ReadOnly(bool_0);
	}

	static void smethod_40(TextBox textBox_0, bool bool_0)
	{
		textBox_0.set_Multiline(bool_0);
	}

	static void smethod_41(PictureBox pictureBox_0, Image image_0)
	{
		pictureBox_0.set_Image(image_0);
	}

	static void smethod_42(PictureBox pictureBox_0, PictureBoxSizeMode pictureBoxSizeMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		pictureBox_0.set_SizeMode(pictureBoxSizeMode_0);
	}

	static void smethod_43(PictureBox pictureBox_0, int int_0)
	{
		pictureBox_0.set_TabIndex(int_0);
	}

	static void smethod_44(PictureBox pictureBox_0, bool bool_0)
	{
		pictureBox_0.set_TabStop(bool_0);
	}

	static void smethod_45(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_46(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static ControlCollection smethod_47(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_48(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_49(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_50(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_51(Control control_0)
	{
		control_0.PerformLayout();
	}

	static void smethod_52(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.EndInit();
	}

	static void smethod_53(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_54(Control control_0)
	{
		control_0.PerformLayout();
	}

	static void smethod_55(Control control_0, EventHandler eventHandler_0)
	{
		control_0.remove_Click(eventHandler_0);
	}

	static void smethod_56(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_Click(eventHandler_0);
	}

	static void smethod_57(RadioButton radioButton_0, EventHandler eventHandler_0)
	{
		radioButton_0.remove_CheckedChanged(eventHandler_0);
	}

	static void smethod_58(RadioButton radioButton_0, EventHandler eventHandler_0)
	{
		radioButton_0.add_CheckedChanged(eventHandler_0);
	}

	static void smethod_59(DataGridView dataGridView_0, DataGridViewCellMouseEventHandler dataGridViewCellMouseEventHandler_0)
	{
		dataGridView_0.remove_CellMouseClick(dataGridViewCellMouseEventHandler_0);
	}

	static void smethod_60(DataGridView dataGridView_0, DataGridViewCellMouseEventHandler dataGridViewCellMouseEventHandler_0)
	{
		dataGridView_0.add_CellMouseClick(dataGridViewCellMouseEventHandler_0);
	}

	static string smethod_61(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static void smethod_62(OleDbConnection oleDbConnection_0, string string_0)
	{
		oleDbConnection_0.set_ConnectionString(string_0);
	}

	static int smethod_63(string string_0, string string_1, bool bool_0)
	{
		return Operators.CompareString(string_0, string_1, bool_0);
	}

	static DialogResult smethod_64(string string_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0);
	}

	static DataTable smethod_65()
	{
		return new DataTable();
	}

	static OleDbDataAdapter smethod_66()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new OleDbDataAdapter();
	}

	static void smethod_67(OleDbConnection oleDbConnection_0)
	{
		oleDbConnection_0.Open();
	}

	static string smethod_68(TextBox textBox_0)
	{
		return textBox_0.get_Text();
	}

	static string smethod_69(string[] string_0)
	{
		return string.Concat(string_0);
	}

	static OleDbDataAdapter smethod_70(string string_0, OleDbConnection oleDbConnection_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new OleDbDataAdapter(string_0, oleDbConnection_0);
	}

	static int smethod_71(DbDataAdapter dbDataAdapter_0, DataTable dataTable_0)
	{
		return dbDataAdapter_0.Fill(dataTable_0);
	}

	static DataView smethod_72(DataTable dataTable_0)
	{
		return dataTable_0.DefaultView;
	}

	static void smethod_73(DataGridView dataGridView_0, object object_0)
	{
		dataGridView_0.set_DataSource(object_0);
	}

	static int smethod_74(DataGridView dataGridView_0)
	{
		return dataGridView_0.get_RowCount();
	}

	static DialogResult smethod_75(string string_0, string string_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0, string_1);
	}

	static void smethod_76(OleDbConnection oleDbConnection_0)
	{
		oleDbConnection_0.Close();
	}

	static void smethod_77(Control control_0)
	{
		control_0.Show();
	}

	static void smethod_78(Exception exception_0)
	{
		ProjectData.SetProjectError(exception_0);
	}

	static void smethod_79()
	{
		ProjectData.ClearProjectError();
	}

	static DataGridViewColumnCollection smethod_80(DataGridView dataGridView_0)
	{
		return dataGridView_0.get_Columns();
	}

	static DataGridViewColumn smethod_81(DataGridViewColumnCollection dataGridViewColumnCollection_0, int int_0)
	{
		return dataGridViewColumnCollection_0.get_Item(int_0);
	}

	static void smethod_82(DataGridViewColumn dataGridViewColumn_0, bool bool_0)
	{
		dataGridViewColumn_0.set_Visible(bool_0);
	}

	static int smethod_83(DataGridViewCellMouseEventArgs dataGridViewCellMouseEventArgs_0)
	{
		return dataGridViewCellMouseEventArgs_0.get_RowIndex();
	}

	static void smethod_84(Control control_0, bool bool_0)
	{
		control_0.set_Visible(bool_0);
	}

	static DataGridViewRow smethod_85()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new DataGridViewRow();
	}

	static DataGridViewRowCollection smethod_86(DataGridView dataGridView_0)
	{
		return dataGridView_0.get_Rows();
	}

	static DataGridViewRow smethod_87(DataGridViewRowCollection dataGridViewRowCollection_0, int int_0)
	{
		return dataGridViewRowCollection_0.get_Item(int_0);
	}

	static DataGridViewCellCollection smethod_88(DataGridViewRow dataGridViewRow_0)
	{
		return dataGridViewRow_0.get_Cells();
	}

	static DataGridViewCell smethod_89(DataGridViewCellCollection dataGridViewCellCollection_0, int int_0)
	{
		return dataGridViewCellCollection_0.get_Item(int_0);
	}

	static object smethod_90(DataGridViewCell dataGridViewCell_0)
	{
		return dataGridViewCell_0.get_Value();
	}

	static string smethod_91(object object_0)
	{
		return object_0.ToString();
	}

	static void smethod_92(TextBox textBox_0, string string_0)
	{
		textBox_0.set_Text(string_0);
	}

	static string smethod_93(object object_0)
	{
		return Conversions.ToString(object_0);
	}

	static bool smethod_94(object object_0, object object_1, bool bool_0)
	{
		return Operators.ConditionalCompareObjectEqual(object_0, object_1, bool_0);
	}

	static void smethod_95(Control control_0)
	{
		control_0.Hide();
	}

	static void smethod_96(TextBoxBase textBoxBase_0)
	{
		textBoxBase_0.Clear();
	}

	static void smethod_97(RadioButton radioButton_0, bool bool_0)
	{
		radioButton_0.set_Checked(bool_0);
	}
}
