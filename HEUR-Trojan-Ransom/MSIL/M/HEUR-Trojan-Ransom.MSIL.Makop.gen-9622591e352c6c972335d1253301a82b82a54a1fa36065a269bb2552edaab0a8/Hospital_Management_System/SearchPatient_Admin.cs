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
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Hospital_Management_System;

[DesignerGenerated]
public class SearchPatient_Admin : UserControl
{
	private IContainer components;

	private OleDbConnection myconnection;

	private string mobile_search;

	private string name_search;

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
				int num = 133792791;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x494C2601u) % 8u)
					{
					case 7u:
						SearchPatient_Admin.smethod_56((Control)(object)searchBtn, eventHandler_);
						num = (int)((num2 * 1955148073) ^ 0x518423E7);
						continue;
					case 6u:
						searchBtn = _SearchBtn;
						num = ((int)num2 * -1475742063) ^ 0x463613DF;
						continue;
					case 4u:
						_SearchBtn = value;
						searchBtn = _SearchBtn;
						num = 50134434;
						continue;
					case 3u:
					{
						int num5;
						int num6;
						if (searchBtn != null)
						{
							num5 = -1920516906;
							num6 = -1920516906;
						}
						else
						{
							num5 = -490174168;
							num6 = -490174168;
						}
						num = num5 ^ (int)(num2 * 1391718384);
						continue;
					}
					case 2u:
						SearchPatient_Admin.smethod_55((Control)(object)searchBtn, eventHandler_);
						num = (int)(num2 * 1118943755) ^ -1926083885;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (searchBtn == null)
						{
							num3 = 1633931941;
							num4 = 1633931941;
						}
						else
						{
							num3 = 1580931123;
							num4 = 1580931123;
						}
						num = num3 ^ (int)(num2 * 1377877021);
						continue;
					}
					default:
						return;
					case 5u:
						break;
					case 1u:
						return;
					}
					break;
				}
			}
		}
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MobileSTxt")]
	internal virtual TextBox MobileSTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
			DataGridViewCellMouseEventHandler dataGridViewCellMouseEventHandler_ = new DataGridViewCellMouseEventHandler(SearchResultGrid_CellMouseClick);
			DataGridView searchResultGrid = _SearchResultGrid;
			while (true)
			{
				int num = -2132343795;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD47CCE03u) % 8u)
					{
					case 7u:
						SearchPatient_Admin.smethod_57(searchResultGrid, dataGridViewCellMouseEventHandler_);
						num = (int)((num2 * 736292118) ^ 0x1C411898);
						continue;
					case 6u:
					{
						int num5;
						int num6;
						if (searchResultGrid == null)
						{
							num5 = 1023652576;
							num6 = 1023652576;
						}
						else
						{
							num5 = 425728414;
							num6 = 425728414;
						}
						num = num5 ^ ((int)num2 * -1125081985);
						continue;
					}
					case 4u:
					{
						int num3;
						int num4;
						if (searchResultGrid != null)
						{
							num3 = 2134545353;
							num4 = 2134545353;
						}
						else
						{
							num3 = 2054264822;
							num4 = 2054264822;
						}
						num = num3 ^ ((int)num2 * -854983192);
						continue;
					}
					case 3u:
						searchResultGrid = _SearchResultGrid;
						num = (int)((num2 * 2080752049) ^ 0x520CF33C);
						continue;
					case 2u:
						SearchPatient_Admin.smethod_58(searchResultGrid, dataGridViewCellMouseEventHandler_);
						num = ((int)num2 * -511392864) ^ -1696456938;
						continue;
					case 1u:
						_SearchResultGrid = value;
						num = -1968171768;
						continue;
					default:
						return;
					case 0u:
						break;
					case 5u:
						return;
					}
					break;
				}
			}
		}
	}

	[field: AccessedThroughProperty("PatientInfoBox")]
	internal virtual GroupBox PatientInfoBox
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

	[field: AccessedThroughProperty("Label14")]
	internal virtual Label Label14
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

	[field: AccessedThroughProperty("PIDTxt")]
	internal virtual TextBox PIDTxt
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
			EventHandler eventHandler_ = ClearBtn_Click;
			Button clearBtn = default(Button);
			while (true)
			{
				int num = 1445462327;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7725088Du) % 9u)
					{
					case 7u:
						clearBtn = _ClearBtn;
						num = (int)(num2 * 1441067353) ^ -918360360;
						continue;
					case 6u:
					{
						int num5;
						int num6;
						if (clearBtn == null)
						{
							num5 = 153368051;
							num6 = 153368051;
						}
						else
						{
							num5 = 1614838909;
							num6 = 1614838909;
						}
						num = num5 ^ ((int)num2 * -233548672);
						continue;
					}
					case 5u:
					{
						int num3;
						int num4;
						if (clearBtn != null)
						{
							num3 = 1872438572;
							num4 = 1872438572;
						}
						else
						{
							num3 = 864312249;
							num4 = 864312249;
						}
						num = num3 ^ ((int)num2 * -1357050826);
						continue;
					}
					case 4u:
						clearBtn = _ClearBtn;
						num = ((int)num2 * -176380258) ^ -898201067;
						continue;
					case 3u:
						_ClearBtn = value;
						num = 175693174;
						continue;
					case 1u:
						SearchPatient_Admin.smethod_55((Control)(object)clearBtn, eventHandler_);
						num = ((int)num2 * -1691617030) ^ -1803776405;
						continue;
					case 0u:
						SearchPatient_Admin.smethod_56((Control)(object)clearBtn, eventHandler_);
						num = (int)(num2 * 332972391) ^ -169867421;
						continue;
					default:
						return;
					case 8u:
						break;
					case 2u:
						return;
					}
					break;
				}
			}
		}
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
				int num = 76552111;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x28637FC6u) % 7u)
					{
					case 6u:
						SearchPatient_Admin.smethod_56((Control)(object)updateBtn, eventHandler_);
						num = (int)(num2 * 1229848630) ^ -1767599203;
						continue;
					case 5u:
						_UpdateBtn = value;
						updateBtn = _UpdateBtn;
						num = 996743254;
						continue;
					case 4u:
						SearchPatient_Admin.smethod_55((Control)(object)updateBtn, eventHandler_);
						num = ((int)num2 * -912961476) ^ -1285336796;
						continue;
					case 1u:
					{
						updateBtn = _UpdateBtn;
						int num5;
						int num6;
						if (updateBtn != null)
						{
							num5 = -1423053140;
							num6 = -1423053140;
						}
						else
						{
							num5 = -2095405497;
							num6 = -2095405497;
						}
						num = num5 ^ ((int)num2 * -1517219465);
						continue;
					}
					case 0u:
					{
						int num3;
						int num4;
						if (updateBtn != null)
						{
							num3 = 855518574;
							num4 = 855518574;
						}
						else
						{
							num3 = 1341688765;
							num4 = 1341688765;
						}
						num = num3 ^ ((int)num2 * -1872434149);
						continue;
					}
					default:
						return;
					case 3u:
						break;
					case 2u:
						return;
					}
					break;
				}
			}
		}
	}

	internal virtual Button DeleteBtn
	{
		[CompilerGenerated]
		get
		{
			return _DeleteBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = DeleteBtn_Click;
			Button deleteBtn = default(Button);
			while (true)
			{
				int num = 1907757620;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x311F0482u) % 8u)
					{
					case 6u:
						deleteBtn = _DeleteBtn;
						num = ((int)num2 * -1157911982) ^ 0x109BFC3D;
						continue;
					case 5u:
					{
						deleteBtn = _DeleteBtn;
						int num5;
						int num6;
						if (deleteBtn != null)
						{
							num5 = 376421974;
							num6 = 376421974;
						}
						else
						{
							num5 = 1595069653;
							num6 = 1595069653;
						}
						num = num5 ^ (int)(num2 * 1570143088);
						continue;
					}
					case 4u:
						SearchPatient_Admin.smethod_56((Control)(object)deleteBtn, eventHandler_);
						num = ((int)num2 * -911451365) ^ -1669617431;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (deleteBtn != null)
						{
							num3 = 1804510999;
							num4 = 1804510999;
						}
						else
						{
							num3 = 1617269596;
							num4 = 1617269596;
						}
						num = num3 ^ ((int)num2 * -1668520428);
						continue;
					}
					case 2u:
						_DeleteBtn = value;
						num = 535388999;
						continue;
					case 1u:
						SearchPatient_Admin.smethod_55((Control)(object)deleteBtn, eventHandler_);
						num = ((int)num2 * -419388127) ^ 0x1F2C9629;
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

	[field: AccessedThroughProperty("Label10")]
	internal virtual Label Label10
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

	[field: AccessedThroughProperty("DOBTxt")]
	internal virtual DateTimePicker DOBTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public SearchPatient_Admin()
	{
		while (true)
		{
			int num = 660564055;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x18E9DB1Au) % 5u)
				{
				case 4u:
					InitializeComponent();
					num = (int)(num2 * 1141997804) ^ -1041419101;
					continue;
				case 2u:
					myconnection = SearchPatient_Admin.smethod_1();
					num = (int)((num2 * 1153133010) ^ 0x4F0131CA);
					continue;
				case 1u:
					SearchPatient_Admin.smethod_0((UserControl)(object)this, (EventHandler)SearchPatient_Admin_Load);
					num = ((int)num2 * -1781329046) ^ -1044278990;
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

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing)
			{
				goto IL_0056;
			}
			goto IL_0093;
			IL_0056:
			int num = 1196321630;
			goto IL_005b;
			IL_005b:
			int num3;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6A3886B1u) % 7u)
				{
				case 6u:
					SearchPatient_Admin.smethod_2((IDisposable)components);
					num = ((int)num2 * -887624291) ^ -2123150050;
					continue;
				case 3u:
					num = 1569423397;
					continue;
				case 2u:
					num = ((int)num2 * -1601777376) ^ 0x778B8C4E;
					continue;
				case 1u:
					num = (int)(num2 * 1429425795) ^ -683530868;
					continue;
				case 0u:
					break;
				default:
					return;
				case 5u:
					goto IL_0088;
				case 4u:
					return;
				}
				break;
				IL_0088:
				if (components != null)
				{
					num = 285062382;
					num3 = 285062382;
					continue;
				}
				goto IL_0093;
			}
			goto IL_0056;
			IL_0093:
			num = 1933624430;
			num3 = 1933624430;
			goto IL_005b;
		}
		finally
		{
			while (true)
			{
				IL_00f2:
				int num4 = 1879617976;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num4 ^ 0x6A3886B1u) % 4u)
					{
					case 3u:
						num4 = (int)(num2 * 1883458751) ^ -33853296;
						continue;
					case 1u:
						((ContainerControl)this).Dispose(disposing);
						num4 = (int)(num2 * 58601401) ^ -587993821;
						continue;
					default:
						goto end_IL_00d1;
					case 2u:
						break;
					case 0u:
						goto end_IL_00d1;
					}
					goto IL_00f2;
					continue;
					end_IL_00d1:
					break;
				}
				break;
			}
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		PictureBox1 = SearchPatient_Admin.smethod_3();
		while (true)
		{
			int num = 1025991123;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x24DC3FECu) % 278u)
				{
				case 277u:
					num = ((int)num2 * -1773733401) ^ -1942182369;
					continue;
				case 276u:
					num = ((int)num2 * -387057732) ^ -211644307;
					continue;
				case 275u:
					SearchPatient_Admin.smethod_14((Control)(object)GenderTxt, new Point(124, 178));
					num = ((int)num2 * -1302485347) ^ 0x68AA9D4F;
					continue;
				case 274u:
					SearchPatient_Admin.smethod_30((Control)(object)SearchBtn, Color.White);
					num = (int)(num2 * 2067883678) ^ -228764423;
					continue;
				case 273u:
					num = (int)((num2 * 87852076) ^ 0x43C874D7);
					continue;
				case 272u:
					num = ((int)num2 * -969122940) ^ 0x2DA88738;
					continue;
				case 271u:
					SearchPatient_Admin.smethod_22((Control)(object)UpdateBtn, 16);
					SearchPatient_Admin.smethod_31((ButtonBase)(object)UpdateBtn, "Update");
					num = ((int)num2 * -1161909080) ^ 0x76BAB432;
					continue;
				case 270u:
					num = (int)((num2 * 486006662) ^ 0x606ADF23);
					continue;
				case 269u:
					num = ((int)num2 * -1457243747) ^ 0x5034631E;
					continue;
				case 268u:
					SearchPatient_Admin.smethod_51((ISupportInitialize)PictureBox1);
					num = (int)((num2 * 211428364) ^ 0x29BA6DC2);
					continue;
				case 267u:
					num = (int)(num2 * 1213152577) ^ -2129248084;
					continue;
				case 266u:
					num = ((int)num2 * -1480739948) ^ -176369088;
					continue;
				case 265u:
					SearchPatient_Admin.smethod_16((Control)(object)MobileTxt, new Size(258, 28));
					SearchPatient_Admin.smethod_22((Control)(object)MobileTxt, 11);
					num = (int)((num2 * 1046519937) ^ 0x247D0202);
					continue;
				case 264u:
					num = (int)((num2 * 2086343332) ^ 0x7D3698F7);
					continue;
				case 263u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_48((Control)(object)this), (Control)(object)Label1);
					num = ((int)num2 * -199693304) ^ 0x601AF3AD;
					continue;
				case 262u:
					num = ((int)num2 * -88482541) ^ 0x45EB42E6;
					continue;
				case 261u:
					num = (int)(num2 * 1100603195) ^ -1089750419;
					continue;
				case 260u:
					num = (int)(num2 * 866429173) ^ -765663794;
					continue;
				case 259u:
					num = (int)(num2 * 1559901809) ^ -1032295557;
					continue;
				case 258u:
					num = ((int)num2 * -1695408883) ^ 0x68AFC5A9;
					continue;
				case 257u:
					SearchPatient_Admin.smethod_16((Control)(object)PictureBox1, new Size(130, 125));
					num = ((int)num2 * -29700876) ^ 0x58DE3768;
					continue;
				case 256u:
					SearchPatient_Admin.smethod_49((Control)(object)this, "SearchPatient_Admin");
					num = ((int)num2 * -881984867) ^ 0x329005C7;
					continue;
				case 255u:
					SearchPatient_Admin.smethod_21((Control)(object)Label2, SearchPatient_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -682547) ^ -444942167;
					continue;
				case 254u:
					SearchPatient_Admin.smethod_15((Control)(object)Label3, "Label3");
					num = (int)((num2 * 2138523080) ^ 0x59AE8E42);
					continue;
				case 253u:
					SearchPatient_Admin.smethod_13(PictureBox1, (Image)(object)Resources.patient_pic);
					num = (int)(num2 * 392101850) ^ -126333636;
					continue;
				case 252u:
					SearchPatient_Admin.smethod_16((Control)(object)PatientInfoBox, new Size(860, 231));
					num = ((int)num2 * -1512479476) ^ 0x36F006ED;
					continue;
				case 251u:
					SearchPatient_Admin.smethod_30((Control)(object)UpdateBtn, Color.White);
					num = (int)((num2 * 1316933855) ^ 0x186A65AA);
					continue;
				case 250u:
					SearchPatient_Admin.smethod_14((Control)(object)Label3, new Point(37, 87));
					num = ((int)num2 * -1534173365) ^ 0x24F57AC0;
					continue;
				case 249u:
					SearchPatient_Admin.smethod_22((Control)(object)Label6, 2);
					num = ((int)num2 * -397995285) ^ 0x1F8D8CB5;
					continue;
				case 248u:
					num = ((int)num2 * -584497914) ^ -1298505697;
					continue;
				case 247u:
					num = ((int)num2 * -1307638309) ^ 0x6EC93718;
					continue;
				case 246u:
					SearchPatient_Admin.smethod_29((ButtonBase)(object)SearchBtn, Color.MidnightBlue);
					num = ((int)num2 * -446434890) ^ -4510204;
					continue;
				case 245u:
					SearchPatient_Admin.smethod_14((Control)(object)PatientInfoBox, new Point(59, 486));
					num = (int)(num2 * 508919619) ^ -912760409;
					continue;
				case 244u:
					SearchPatient_Admin.smethod_38((Control)(object)DeleteBtn, bool_0: false);
					num = (int)(num2 * 1873577641) ^ -1569241461;
					continue;
				case 243u:
					SearchPatient_Admin.smethod_38((Control)(object)UpdateBtn, bool_0: false);
					num = (int)((num2 * 967869932) ^ 0x2F7054BD);
					continue;
				case 242u:
					num = ((int)num2 * -1206554573) ^ -807247580;
					continue;
				case 241u:
					SearchPatient_Admin.smethod_22((Control)(object)SearchBtn, 4);
					SearchPatient_Admin.smethod_31((ButtonBase)(object)SearchBtn, "Search");
					SearchPatient_Admin.smethod_32((ButtonBase)(object)SearchBtn, bool_0: false);
					num = ((int)num2 * -1158339233) ^ 0x2B213780;
					continue;
				case 240u:
					SearchPatient_Admin.smethod_15((Control)(object)ClearBtn, "ClearBtn");
					num = ((int)num2 * -1073181552) ^ 0xF7E8603;
					continue;
				case 239u:
					SearchPatient_Admin.smethod_16((Control)(object)PIDTxt, new Size(116, 28));
					num = (int)(num2 * 983406118) ^ -260731392;
					continue;
				case 238u:
					SearchPatient_Admin.smethod_16((Control)(object)Label3, new Size(77, 28));
					num = ((int)num2 * -1811256489) ^ -829284396;
					continue;
				case 237u:
					num = ((int)num2 * -1295191941) ^ -1972553240;
					continue;
				case 236u:
					num = ((int)num2 * -484890876) ^ 0x4BE9E6C4;
					continue;
				case 235u:
					SearchPatient_Admin.smethod_14((Control)(object)DeleteBtn, new Point(815, 747));
					num = (int)(num2 * 1119906478) ^ -262065880;
					continue;
				case 234u:
					num = (int)(num2 * 294890876) ^ -1413801207;
					continue;
				case 233u:
					num = (int)((num2 * 112316017) ^ 0xEF8E58C);
					continue;
				case 232u:
					SearchPatient_Admin.smethod_14((Control)(object)MobileTxt, new Point(554, 83));
					num = (int)((num2 * 1607971565) ^ 0x6EDCC5EC);
					continue;
				case 231u:
					Label5 = SearchPatient_Admin.smethod_4();
					num = ((int)num2 * -2079420561) ^ -765510230;
					continue;
				case 230u:
					SearchPatient_Admin.smethod_16((Control)(object)DOBTxt, new Size(166, 28));
					num = (int)((num2 * 1269110886) ^ 0x3D35F1D0);
					continue;
				case 229u:
					SearchPatient_Admin.smethod_11((Control)(object)PatientInfoBox);
					num = (int)((num2 * 1501744911) ^ 0x2E86B275);
					continue;
				case 228u:
					num = ((int)num2 * -1413795233) ^ 0x5AD7CDA7;
					continue;
				case 227u:
					SearchPatient_Admin.smethod_38((Control)(object)SearchResultGrid, bool_0: false);
					num = (int)(num2 * 904805709) ^ -768401451;
					continue;
				case 226u:
					UpdateBtn = SearchPatient_Admin.smethod_6();
					num = (int)(num2 * 1886896290) ^ -639684342;
					continue;
				case 224u:
					SearchPatient_Admin.smethod_15((Control)(object)SearchBtn, "SearchBtn");
					num = (int)(num2 * 411675317) ^ -2113682286;
					continue;
				case 223u:
					SearchPatient_Admin.smethod_16((Control)(object)Label5, new Size(68, 26));
					SearchPatient_Admin.smethod_22((Control)(object)Label5, 1);
					SearchPatient_Admin.smethod_23(Label5, "DOB :");
					num = ((int)num2 * -546531636) ^ 0x1CF97580;
					continue;
				case 222u:
					SearchPatient_Admin.smethod_14((Control)(object)NameTxt, new Point(124, 89));
					SearchPatient_Admin.smethod_15((Control)(object)NameTxt, "NameTxt");
					num = (int)(num2 * 371803420) ^ -1387721566;
					continue;
				case 221u:
					num = (int)(num2 * 2021072388) ^ -1666170138;
					continue;
				case 220u:
					SearchPatient_Admin.smethod_16((Control)(object)GroupBox1, new Size(623, 128));
					SearchPatient_Admin.smethod_22((Control)(object)GroupBox1, 11);
					SearchPatient_Admin.smethod_27(GroupBox1, bool_0: false);
					num = ((int)num2 * -180414965) ^ -982798262;
					continue;
				case 219u:
					PIDTxt = SearchPatient_Admin.smethod_7();
					num = ((int)num2 * -51375440) ^ -1144538422;
					continue;
				case 218u:
					SearchPatient_Admin.smethod_34(SearchResultGrid, (DataGridViewColumnHeadersHeightSizeMode)2);
					num = ((int)num2 * -722410212) ^ 0x601A001D;
					continue;
				case 217u:
					SearchPatient_Admin.smethod_29((ButtonBase)(object)DeleteBtn, Color.MidnightBlue);
					num = ((int)num2 * -1271864047) ^ -862862781;
					continue;
				case 216u:
					num = ((int)num2 * -1252909962) ^ -1808814575;
					continue;
				case 215u:
					SearchPatient_Admin.smethod_15((Control)(object)MobileSTxt, "MobileSTxt");
					SearchPatient_Admin.smethod_16((Control)(object)MobileSTxt, new Size(237, 28));
					num = ((int)num2 * -1570762788) ^ 0x6725E8CB;
					continue;
				case 214u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_25((Control)(object)PatientInfoBox), (Control)(object)PIDTxt);
					num = ((int)num2 * -1231522726) ^ 0x3ECB2C2E;
					continue;
				case 213u:
					SearchPatient_Admin.smethod_15((Control)(object)UpdateBtn, "UpdateBtn");
					num = ((int)num2 * -549898920) ^ 0x2B7C9CA8;
					continue;
				case 212u:
					SearchPatient_Admin.smethod_22((Control)(object)DeleteBtn, 17);
					num = (int)(num2 * 173581345) ^ -168810941;
					continue;
				case 211u:
					num = ((int)num2 * -1153402498) ^ 0x1A1243E4;
					continue;
				case 210u:
					SearchPatient_Admin.smethod_15((Control)(object)Label6, "Label6");
					SearchPatient_Admin.smethod_16((Control)(object)Label6, new Size(84, 26));
					num = ((int)num2 * -247901557) ^ -1390898179;
					continue;
				case 209u:
					num = ((int)num2 * -1924704843) ^ 0x52E51237;
					continue;
				case 208u:
					SearchPatient_Admin.smethod_16((Control)(object)Label1, new Size(330, 47));
					num = (int)((num2 * 2051161777) ^ 0x44C01434);
					continue;
				case 207u:
					SearchPatient_Admin.smethod_21((Control)(object)PatientInfoBox, SearchPatient_Admin.smethod_20("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1521704258) ^ 0x3F97E8FB);
					continue;
				case 206u:
					SearchPatient_Admin.smethod_15((Control)(object)MobileTxt, "MobileTxt");
					num = ((int)num2 * -433065447) ^ -553967628;
					continue;
				case 205u:
					num = (int)(num2 * 282723647) ^ -1740693406;
					continue;
				case 204u:
					SearchPatient_Admin.smethod_32((ButtonBase)(object)DeleteBtn, bool_0: false);
					num = ((int)num2 * -946340586) ^ 0x733ADFF8;
					continue;
				case 203u:
					SearchPatient_Admin.smethod_43(AddressTxt, bool_0: true);
					num = ((int)num2 * -1507483978) ^ -1073241812;
					continue;
				case 202u:
					SearchPatient_Admin.smethod_22((Control)(object)MobileSTxt, 2);
					num = ((int)num2 * -1885503232) ^ 0x4AE99660;
					continue;
				case 201u:
					SearchPatient_Admin.smethod_24(Label2, (ContentAlignment)32);
					num = (int)((num2 * 267108539) ^ 0x64487527);
					continue;
				case 200u:
					num = (int)((num2 * 373852001) ^ 0x2C357F95);
					continue;
				case 199u:
					Label6 = SearchPatient_Admin.smethod_4();
					num = ((int)num2 * -149729984) ^ -1082348689;
					continue;
				case 198u:
					SearchPatient_Admin.smethod_16((Control)(object)SearchResultGrid, new Size(853, 169));
					num = ((int)num2 * -821838352) ^ -1252589189;
					continue;
				case 197u:
					SearchPatient_Admin.smethod_23(Label1, "Search Patient");
					num = ((int)num2 * -493445644) ^ 0x10694564;
					continue;
				case 196u:
					SearchPatient_Admin.smethod_16((Control)(object)GenderTxt, new Size(166, 28));
					num = ((int)num2 * -1706462403) ^ 0x2C836744;
					continue;
				case 195u:
					SearchPatient_Admin.smethod_28(GroupBox1, "Search Patient");
					num = ((int)num2 * -21027731) ^ 0x4D80817D;
					continue;
				case 194u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_25((Control)(object)PatientInfoBox), (Control)(object)Label7);
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_25((Control)(object)PatientInfoBox), (Control)(object)Label6);
					num = ((int)num2 * -573726475) ^ 0x3DE56876;
					continue;
				case 193u:
					SearchPatient_Admin.smethod_21((Control)(object)Label6, SearchPatient_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -597986123) ^ 0x2893BD87;
					continue;
				case 192u:
					SearchPatient_Admin.smethod_16((Control)(object)UpdateBtn, new Size(97, 37));
					num = ((int)num2 * -1090951514) ^ 0x3948CF9E;
					continue;
				case 191u:
					num = (int)(num2 * 1343439496) ^ -1431407769;
					continue;
				case 190u:
					num = (int)(num2 * 1341338643) ^ -1180126708;
					continue;
				case 189u:
					num = ((int)num2 * -259562622) ^ 0x3F85DDB8;
					continue;
				case 188u:
					SearchPatient_Admin.smethod_47((Control)(object)this, Color.White);
					num = ((int)num2 * -2040187441) ^ 0x1989A133;
					continue;
				case 187u:
					num = ((int)num2 * -1750707840) ^ -217554100;
					continue;
				case 186u:
					num = ((int)num2 * -1376526760) ^ 0x3046514B;
					continue;
				case 185u:
					MobileTxt = SearchPatient_Admin.smethod_7();
					num = ((int)num2 * -1915277797) ^ 0x42B09F8;
					continue;
				case 184u:
					SearchPatient_Admin.smethod_15((Control)(object)Label5, "Label5");
					num = ((int)num2 * -1942823019) ^ -99366236;
					continue;
				case 183u:
					SearchPatient_Admin.smethod_14((Control)(object)PictureBox1, new Point(256, 19));
					num = (int)(num2 * 1729986512) ^ -404969133;
					continue;
				case 182u:
					SearchPatient_Admin.smethod_14((Control)(object)Label6, new Point(13, 180));
					num = (int)((num2 * 824660519) ^ 0x2712FDC);
					continue;
				case 181u:
					num = ((int)num2 * -2124244171) ^ -720809994;
					continue;
				case 180u:
					num = (int)(num2 * 1188735753) ^ -852537119;
					continue;
				case 179u:
					num = ((int)num2 * -22937132) ^ 0x1604C0BD;
					continue;
				case 177u:
					SearchPatient_Admin.smethod_15((Control)(object)Label7, "Label7");
					num = (int)(num2 * 1300872660) ^ -839057432;
					continue;
				case 176u:
					SearchPatient_Admin.smethod_23(Label10, "Mobile :");
					num = (int)((num2 * 1299057380) ^ 0x7149530);
					continue;
				case 175u:
					num = ((int)num2 * -945102926) ^ -1217796702;
					continue;
				case 174u:
					num = ((int)num2 * -362037972) ^ 0x4AED8D2B;
					continue;
				case 173u:
					SearchPatient_Admin.smethod_15((Control)(object)PIDTxt, "PIDTxt");
					num = ((int)num2 * -2000383930) ^ -1930644707;
					continue;
				case 172u:
					SearchPatient_Admin.smethod_51((ISupportInitialize)SearchResultGrid);
					SearchPatient_Admin.smethod_52((Control)(object)PatientInfoBox, bool_0: false);
					SearchPatient_Admin.smethod_53((Control)(object)PatientInfoBox);
					SearchPatient_Admin.smethod_54((Control)(object)this, bool_0: false);
					num = (int)(num2 * 1292011084) ^ -1959799886;
					continue;
				case 171u:
					SearchPatient_Admin.smethod_21((Control)(object)Label3, SearchPatient_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1350490147) ^ -535974088;
					continue;
				case 170u:
					SearchPatient_Admin.smethod_32((ButtonBase)(object)UpdateBtn, bool_0: false);
					num = (int)(num2 * 998605051) ^ -2064007635;
					continue;
				case 169u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_48((Control)(object)this), (Control)(object)GroupBox1);
					num = ((int)num2 * -580433424) ^ -440277217;
					continue;
				case 168u:
					SearchPatient_Admin.smethod_15((Control)(object)Label10, "Label10");
					num = ((int)num2 * -271735677) ^ -298178187;
					continue;
				case 167u:
					Label1 = SearchPatient_Admin.smethod_4();
					num = ((int)num2 * -949774361) ^ 0x4CE91A03;
					continue;
				case 166u:
					SearchPatient_Admin.smethod_33(SearchResultGrid, Color.White);
					num = (int)(num2 * 621181931) ^ -1767630880;
					continue;
				case 165u:
					num = ((int)num2 * -1169977471) ^ 0xC7544F2;
					continue;
				case 164u:
					num = ((int)num2 * -387355587) ^ 0x2BABD838;
					continue;
				case 163u:
					SearchPatient_Admin.smethod_21((Control)(object)Label7, SearchPatient_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -715397685) ^ 0x775B2607;
					continue;
				case 162u:
					SearchPatient_Admin.smethod_53((Control)(object)GroupBox1);
					num = ((int)num2 * -936998884) ^ -1951215820;
					continue;
				case 161u:
					num = (int)(num2 * 547920292) ^ -2046496588;
					continue;
				case 160u:
					SearchPatient_Admin.smethod_39(DOBTxt, (DateTimePickerFormat)2);
					num = ((int)num2 * -189718932) ^ -873798422;
					continue;
				case 159u:
					SearchPatient_Admin.smethod_42(DOBTxt, new DateTime(2019, 2, 11, 0, 0, 0, 0));
					num = (int)(num2 * 1043664) ^ -529800947;
					continue;
				case 158u:
					num = (int)(num2 * 868738924) ^ -1166782175;
					continue;
				case 157u:
					Label10 = SearchPatient_Admin.smethod_4();
					num = (int)((num2 * 1162446373) ^ 0x515C802C);
					continue;
				case 156u:
					SearchPatient_Admin.smethod_15((Control)(object)GroupBox1, "GroupBox1");
					num = ((int)num2 * -2031502623) ^ -1306428339;
					continue;
				case 155u:
					SearchPatient_Admin.smethod_16((Control)(object)Label4, new Size(68, 25));
					SearchPatient_Admin.smethod_22((Control)(object)Label4, 0);
					num = ((int)num2 * -1857570468) ^ -776929897;
					continue;
				case 154u:
					SearchPatient_Admin.smethod_14((Control)(object)UpdateBtn, new Point(681, 747));
					num = ((int)num2 * -1155025587) ^ 0x16CB0ECD;
					continue;
				case 153u:
					SearchPatient_Admin.smethod_50((Control)(object)this, new Size(977, 804));
					num = ((int)num2 * -1909105086) ^ -1011761396;
					continue;
				case 152u:
					SearchBtn = SearchPatient_Admin.smethod_6();
					num = (int)(num2 * 827731785) ^ -1486339946;
					continue;
				case 151u:
					num = ((int)num2 * -1418465535) ^ -1683039025;
					continue;
				case 150u:
					SearchPatient_Admin.smethod_16((Control)(object)DeleteBtn, new Size(97, 37));
					num = (int)((num2 * 1712450736) ^ 0x4EDF0CEB);
					continue;
				case 149u:
					NameSTxt = SearchPatient_Admin.smethod_7();
					num = ((int)num2 * -1430453047) ^ -508236363;
					continue;
				case 148u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_48((Control)(object)this), (Control)(object)PictureBox1);
					num = ((int)num2 * -640357381) ^ -2047218356;
					continue;
				case 147u:
					SearchPatient_Admin.smethod_16((Control)(object)AddressTxt, new Size(258, 90));
					SearchPatient_Admin.smethod_22((Control)(object)AddressTxt, 7);
					num = ((int)num2 * -1306637052) ^ 0x23CEEA7D;
					continue;
				case 146u:
					SearchPatient_Admin.smethod_21((Control)(object)Label4, SearchPatient_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					SearchPatient_Admin.smethod_14((Control)(object)Label4, new Point(13, 43));
					num = ((int)num2 * -350352266) ^ 0x34F89D1E;
					continue;
				case 145u:
					SearchPatient_Admin.smethod_22((Control)(object)PatientInfoBox, 13);
					num = ((int)num2 * -196619953) ^ 0x7EE10BEE;
					continue;
				case 144u:
					SearchPatient_Admin.smethod_14((Control)(object)DOBTxt, new Point(124, 132));
					num = (int)(num2 * 653077370) ^ -1602110337;
					continue;
				case 143u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_25((Control)(object)PatientInfoBox), (Control)(object)Label4);
					num = (int)(num2 * 939790983) ^ -1606866124;
					continue;
				case 142u:
					SearchPatient_Admin.smethod_29((ButtonBase)(object)ClearBtn, Color.MidnightBlue);
					SearchPatient_Admin.smethod_21((Control)(object)ClearBtn, SearchPatient_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					SearchPatient_Admin.smethod_30((Control)(object)ClearBtn, Color.White);
					num = (int)(num2 * 615387654) ^ -465553671;
					continue;
				case 141u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_25((Control)(object)GroupBox1), (Control)(object)Label2);
					num = ((int)num2 * -312178652) ^ 0x2ED864F3;
					continue;
				case 140u:
					SearchPatient_Admin.smethod_22((Control)(object)Label1, 10);
					num = (int)(num2 * 2112829997) ^ -1753012015;
					continue;
				case 139u:
					num = (int)((num2 * 14839568) ^ 0x44959053);
					continue;
				case 138u:
					SearchPatient_Admin.smethod_14((Control)(object)NameSTxt, new Point(120, 44));
					num = ((int)num2 * -1794143387) ^ 0x1C6BF14;
					continue;
				case 137u:
					num = ((int)num2 * -1547520871) ^ 0x5EA85721;
					continue;
				case 136u:
					SearchPatient_Admin.smethod_52((Control)(object)GroupBox1, bool_0: false);
					num = ((int)num2 * -1492097330) ^ 0x4B749810;
					continue;
				case 135u:
					num = (int)((num2 * 1567467009) ^ 0x541DAF8D);
					continue;
				case 134u:
					num = (int)(num2 * 1787822360) ^ -1556252269;
					continue;
				case 133u:
					SearchPatient_Admin.smethod_14((Control)(object)PIDTxt, new Point(124, 43));
					num = ((int)num2 * -281565885) ^ 0x7F5A5AA;
					continue;
				case 132u:
					num = (int)((num2 * 1497161803) ^ 0x2492E0E7);
					continue;
				case 131u:
					SearchPatient_Admin.smethod_31((ButtonBase)(object)DeleteBtn, "Delete");
					num = ((int)num2 * -498743822) ^ -35735061;
					continue;
				case 130u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_25((Control)(object)PatientInfoBox), (Control)(object)MobileTxt);
					num = (int)((num2 * 1666205585) ^ 0x6CBF115F);
					continue;
				case 129u:
					GenderTxt = SearchPatient_Admin.smethod_7();
					num = ((int)num2 * -1183492505) ^ -1049500104;
					continue;
				case 128u:
					num = ((int)num2 * -1632641610) ^ -1423728326;
					continue;
				case 127u:
					SearchPatient_Admin.smethod_46((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 1526658380) ^ -1361286994;
					continue;
				case 126u:
					num = ((int)num2 * -101712366) ^ -2012418321;
					continue;
				case 125u:
					SearchPatient_Admin.smethod_38((Control)(object)PatientInfoBox, bool_0: false);
					num = ((int)num2 * -1652566135) ^ -1334875108;
					continue;
				case 124u:
					SearchPatient_Admin.smethod_15((Control)(object)DOBTxt, "DOBTxt");
					num = (int)((num2 * 155538891) ^ 0x59FB9ACC);
					continue;
				case 123u:
					num = (int)((num2 * 828647170) ^ 0x45B9AD3);
					continue;
				case 122u:
					PatientInfoBox = SearchPatient_Admin.smethod_5();
					num = ((int)num2 * -1775678027) ^ 0x2A0EEA7B;
					continue;
				case 121u:
					SearchPatient_Admin.smethod_28(PatientInfoBox, "Patient Information");
					num = ((int)num2 * -1736630703) ^ 0x46D7EA89;
					continue;
				case 120u:
					num = ((int)num2 * -293317786) ^ 0x48B1C078;
					continue;
				case 119u:
					DOBTxt = SearchPatient_Admin.smethod_9();
					num = ((int)num2 * -168669111) ^ -1103585046;
					continue;
				case 118u:
					SearchPatient_Admin.smethod_22((Control)(object)Label2, 0);
					num = ((int)num2 * -1927801523) ^ -2004676762;
					continue;
				case 117u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_25((Control)(object)GroupBox1), (Control)(object)Label3);
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_25((Control)(object)GroupBox1), (Control)(object)MobileSTxt);
					num = ((int)num2 * -596637061) ^ 0xB9A2982;
					continue;
				case 116u:
					SearchPatient_Admin.smethod_22((Control)(object)Label7, 3);
					SearchPatient_Admin.smethod_23(Label7, "Address : ");
					num = (int)((num2 * 1970470735) ^ 0x565CB37A);
					continue;
				case 115u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_48((Control)(object)this), (Control)(object)PatientInfoBox);
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_48((Control)(object)this), (Control)(object)SearchResultGrid);
					num = ((int)num2 * -311505164) ^ -1397133265;
					continue;
				case 114u:
					num = (int)((num2 * 2060252851) ^ 0x24AF8184);
					continue;
				case 113u:
					num = ((int)num2 * -1295229356) ^ 0x5EFB1ECE;
					continue;
				case 112u:
					SearchPatient_Admin.smethod_14((Control)(object)AddressTxt, new Point(554, 128));
					num = (int)((num2 * 2089015083) ^ 0x7168A44C);
					continue;
				case 111u:
					SearchPatient_Admin.smethod_16((Control)(object)ClearBtn, new Size(97, 37));
					num = ((int)num2 * -1360123581) ^ -1602366789;
					continue;
				case 110u:
					num = ((int)num2 * -584061368) ^ 0x8EF1715;
					continue;
				case 109u:
					SearchPatient_Admin.smethod_22((Control)(object)SearchResultGrid, 12);
					num = ((int)num2 * -313339767) ^ 0x6098C38E;
					continue;
				case 108u:
					SearchPatient_Admin.smethod_37(SearchPatient_Admin.smethod_36(SearchResultGrid), 24);
					num = (int)((num2 * 291027660) ^ 0x10652C);
					continue;
				case 107u:
					SearchPatient_Admin.smethod_27(PatientInfoBox, bool_0: false);
					num = ((int)num2 * -1585936292) ^ -1698159505;
					continue;
				case 106u:
					Label2 = SearchPatient_Admin.smethod_4();
					SearchResultGrid = SearchPatient_Admin.smethod_8();
					num = (int)(num2 * 1860832725) ^ -1712972533;
					continue;
				case 105u:
					num = ((int)num2 * -240582868) ^ 0x137E2157;
					continue;
				case 104u:
					SearchPatient_Admin.smethod_14((Control)(object)Label10, new Point(472, 86));
					num = (int)((num2 * 1540997495) ^ 0x37C4DB71);
					continue;
				case 103u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_25((Control)(object)GroupBox1), (Control)(object)NameSTxt);
					num = (int)(num2 * 1241491102) ^ -178315740;
					continue;
				case 102u:
					SearchPatient_Admin.smethod_15((Control)(object)NameSTxt, "NameSTxt");
					num = ((int)num2 * -1217830475) ^ 0x1EA2B053;
					continue;
				case 101u:
					SearchPatient_Admin.smethod_10((ISupportInitialize)SearchResultGrid);
					num = ((int)num2 * -814196075) ^ 0x42D2B87C;
					continue;
				case 100u:
					num = ((int)num2 * -1075520900) ^ -1008107570;
					continue;
				case 99u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_25((Control)(object)PatientInfoBox), (Control)(object)Label10);
					num = ((int)num2 * -1389444473) ^ -266365245;
					continue;
				case 98u:
					SearchPatient_Admin.smethod_14((Control)(object)SearchResultGrid, new Point(59, 295));
					SearchPatient_Admin.smethod_15((Control)(object)SearchResultGrid, "SearchResultGrid");
					num = (int)(num2 * 2012806397) ^ -568014073;
					continue;
				case 97u:
					SearchPatient_Admin.smethod_30((Control)(object)DeleteBtn, Color.White);
					num = (int)(num2 * 1704250693) ^ -1168765631;
					continue;
				case 96u:
					SearchPatient_Admin.smethod_23(Label2, "Name : ");
					num = (int)(num2 * 1130930038) ^ -1247513261;
					continue;
				case 95u:
					DeleteBtn = SearchPatient_Admin.smethod_6();
					SearchPatient_Admin.smethod_10((ISupportInitialize)PictureBox1);
					SearchPatient_Admin.smethod_11((Control)(object)GroupBox1);
					num = ((int)num2 * -249578089) ^ -955478272;
					continue;
				case 94u:
					SearchPatient_Admin.smethod_22((Control)(object)Label10, 10);
					num = (int)((num2 * 1450993051) ^ 0x627E8DFC);
					continue;
				case 93u:
					SearchPatient_Admin.smethod_21((Control)(object)GroupBox1, SearchPatient_Admin.smethod_20("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -941054194) ^ -5648854;
					continue;
				case 92u:
					SearchPatient_Admin.smethod_15((Control)(object)PatientInfoBox, "PatientInfoBox");
					num = (int)(num2 * 1908920745) ^ -369180272;
					continue;
				case 91u:
					SearchPatient_Admin.smethod_21((Control)(object)Label10, SearchPatient_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1204253948) ^ -2115447997;
					continue;
				case 90u:
					SearchPatient_Admin.smethod_21((Control)(object)Label1, SearchPatient_Admin.smethod_20("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 956344569) ^ 0x51FC3145);
					continue;
				case 89u:
					SearchPatient_Admin.smethod_23(Label4, "PID :");
					num = ((int)num2 * -195965954) ^ -680389590;
					continue;
				case 88u:
					SearchPatient_Admin.smethod_17(PictureBox1, (PictureBoxSizeMode)1);
					num = ((int)num2 * -807040317) ^ 0x70F4AEEB;
					continue;
				case 87u:
					SearchPatient_Admin.smethod_16((Control)(object)NameSTxt, new Size(237, 28));
					num = (int)(num2 * 2033926053) ^ -991231347;
					continue;
				case 86u:
					SearchPatient_Admin.smethod_22((Control)(object)PIDTxt, 4);
					num = ((int)num2 * -102023659) ^ -266124275;
					continue;
				case 85u:
					num = ((int)num2 * -1237306687) ^ -1879998064;
					continue;
				case 84u:
					GroupBox1 = SearchPatient_Admin.smethod_5();
					num = ((int)num2 * -100526738) ^ 0x728E8D70;
					continue;
				case 83u:
					SearchPatient_Admin.smethod_15((Control)(object)AddressTxt, "AddressTxt");
					num = ((int)num2 * -1730622493) ^ -1951230560;
					continue;
				case 82u:
					SearchPatient_Admin.smethod_12((Control)(object)this);
					num = ((int)num2 * -856193083) ^ 0x16A7963D;
					continue;
				case 81u:
					num = ((int)num2 * -915282078) ^ 0x2939FD3E;
					continue;
				case 80u:
					SearchPatient_Admin.smethod_23(Label14, "Name :");
					num = ((int)num2 * -1726020178) ^ 0x38341D9D;
					continue;
				case 79u:
					num = (int)(num2 * 1475850659) ^ -375421147;
					continue;
				case 78u:
					SearchPatient_Admin.smethod_14((Control)(object)GroupBox1, new Point(155, 150));
					num = ((int)num2 * -1299940392) ^ 0x517C1FAE;
					continue;
				case 77u:
					num = ((int)num2 * -2005447603) ^ -1975019026;
					continue;
				case 76u:
					SearchPatient_Admin.smethod_19(PictureBox1, bool_0: false);
					num = (int)(num2 * 1915613235) ^ -629474961;
					continue;
				case 75u:
					num = (int)((num2 * 2098949608) ^ 0x422D1992);
					continue;
				case 74u:
					SearchPatient_Admin.smethod_16((Control)(object)SearchBtn, new Size(133, 37));
					num = (int)((num2 * 2000401752) ^ 0x61DB31A5);
					continue;
				case 73u:
					num = (int)((num2 * 2017581698) ^ 0x2AA03538);
					continue;
				case 72u:
					SearchPatient_Admin.smethod_38((Control)(object)ClearBtn, bool_0: false);
					num = ((int)num2 * -1818419518) ^ -132129750;
					continue;
				case 71u:
					SearchPatient_Admin.smethod_41(DOBTxt, new DateTime(1900, 1, 1, 0, 0, 0, 0));
					num = ((int)num2 * -2073175456) ^ -1653852611;
					continue;
				case 70u:
					SearchPatient_Admin.smethod_14((Control)(object)ClearBtn, new Point(546, 747));
					num = (int)((num2 * 1188535656) ^ 0xF0CCFEF);
					continue;
				case 69u:
					NameTxt = SearchPatient_Admin.smethod_7();
					Label14 = SearchPatient_Admin.smethod_4();
					num = ((int)num2 * -1620522252) ^ 0x6276A266;
					continue;
				case 68u:
					Label3 = SearchPatient_Admin.smethod_4();
					MobileSTxt = SearchPatient_Admin.smethod_7();
					num = ((int)num2 * -1041183379) ^ -1392050253;
					continue;
				case 67u:
					SearchPatient_Admin.smethod_21((Control)(object)Label5, SearchPatient_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					SearchPatient_Admin.smethod_14((Control)(object)Label5, new Point(13, 134));
					num = ((int)num2 * -23046612) ^ -1482913631;
					continue;
				case 66u:
					num = (int)((num2 * 837915829) ^ 0x6682D478);
					continue;
				case 65u:
					SearchPatient_Admin.smethod_21((Control)(object)Label14, SearchPatient_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1915005835) ^ 0x6591C74D;
					continue;
				case 64u:
					num = (int)((num2 * 545179690) ^ 0x21E876C2);
					continue;
				case 63u:
					num = ((int)num2 * -163029170) ^ 0x36056CB5;
					continue;
				case 62u:
					SearchPatient_Admin.smethod_15((Control)(object)Label4, "Label4");
					num = (int)((num2 * 1965370776) ^ 0x554F54B4);
					continue;
				case 61u:
					Label7 = SearchPatient_Admin.smethod_4();
					num = (int)(num2 * 98154818) ^ -1281877561;
					continue;
				case 60u:
					SearchPatient_Admin.smethod_14((Control)(object)SearchBtn, new Point(468, 82));
					num = ((int)num2 * -1277816304) ^ 0x2D5154F4;
					continue;
				case 59u:
					SearchPatient_Admin.smethod_31((ButtonBase)(object)ClearBtn, "Clear");
					SearchPatient_Admin.smethod_32((ButtonBase)(object)ClearBtn, bool_0: false);
					num = ((int)num2 * -1475091370) ^ -173839192;
					continue;
				case 58u:
					SearchPatient_Admin.smethod_14((Control)(object)Label14, new Point(13, 89));
					num = ((int)num2 * -828415478) ^ 0x2517C986;
					continue;
				case 57u:
					num = ((int)num2 * -267014376) ^ -1709218224;
					continue;
				case 56u:
					SearchPatient_Admin.smethod_22((Control)(object)ClearBtn, 15);
					num = ((int)num2 * -1616086728) ^ -61676430;
					continue;
				case 55u:
					num = (int)((num2 * 1992501108) ^ 0x612FE4C0);
					continue;
				case 54u:
					num = ((int)num2 * -338832200) ^ 0x116BF07C;
					continue;
				case 53u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_25((Control)(object)PatientInfoBox), (Control)(object)Label5);
					num = ((int)num2 * -657844863) ^ -1152724213;
					continue;
				case 52u:
					SearchPatient_Admin.smethod_21((Control)(object)SearchBtn, SearchPatient_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1750522774) ^ 0x6C691BF8;
					continue;
				case 51u:
					AddressTxt = SearchPatient_Admin.smethod_7();
					num = (int)(num2 * 1134716930) ^ -1003343181;
					continue;
				case 50u:
					SearchPatient_Admin.smethod_29((ButtonBase)(object)UpdateBtn, Color.MidnightBlue);
					num = ((int)num2 * -2031252354) ^ -1091871176;
					continue;
				case 49u:
					SearchPatient_Admin.smethod_15((Control)(object)PictureBox1, "PictureBox1");
					num = (int)((num2 * 2028915192) ^ 0x31F58BA9);
					continue;
				case 48u:
					SearchPatient_Admin.smethod_15((Control)(object)GenderTxt, "GenderTxt");
					num = ((int)num2 * -1811715462) ^ 0x6BD4CD90;
					continue;
				case 47u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_25((Control)(object)PatientInfoBox), (Control)(object)GenderTxt);
					num = ((int)num2 * -1602685999) ^ 0x79941A31;
					continue;
				case 46u:
					num = (int)(num2 * 931545897) ^ -1874952178;
					continue;
				case 45u:
					SearchPatient_Admin.smethod_24(Label1, (ContentAlignment)32);
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_25((Control)(object)GroupBox1), (Control)(object)SearchBtn);
					num = ((int)num2 * -60800248) ^ -138689549;
					continue;
				case 44u:
					num = (int)((num2 * 1619543840) ^ 0x77D15BC3);
					continue;
				case 43u:
					SearchPatient_Admin.smethod_35(SearchResultGrid, bool_0: true);
					num = (int)(num2 * 219575436) ^ -1731965802;
					continue;
				case 42u:
					num = ((int)num2 * -1130937201) ^ -1802220935;
					continue;
				case 41u:
					num = ((int)num2 * -1627492436) ^ 0x218526E4;
					continue;
				case 40u:
					SearchPatient_Admin.smethod_22((Control)(object)GenderTxt, 6);
					num = (int)((num2 * 1698960957) ^ 0x4C9A04DD);
					continue;
				case 39u:
					num = ((int)num2 * -2070485194) ^ -1935419902;
					continue;
				case 38u:
					SearchPatient_Admin.smethod_16((Control)(object)Label10, new Size(76, 28));
					num = ((int)num2 * -1054013133) ^ 0x49D4D705;
					continue;
				case 37u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_48((Control)(object)this), (Control)(object)DeleteBtn);
					num = ((int)num2 * -1137990832) ^ -1845880799;
					continue;
				case 36u:
					SearchPatient_Admin.smethod_40(DOBTxt, new DateTime(2019, 2, 11, 0, 0, 0, 0));
					num = (int)((num2 * 1128201621) ^ 0x8BBC345);
					continue;
				case 35u:
					num = ((int)num2 * -407968285) ^ -760238201;
					continue;
				case 34u:
					SearchPatient_Admin.smethod_23(Label6, "Gender : ");
					num = (int)(num2 * 1933072875) ^ -456732357;
					continue;
				case 33u:
					SearchPatient_Admin.smethod_22((Control)(object)Label14, 8);
					num = ((int)num2 * -1067968045) ^ 0x5B952F87;
					continue;
				case 32u:
					SearchPatient_Admin.smethod_15((Control)(object)Label14, "Label14");
					SearchPatient_Admin.smethod_16((Control)(object)Label14, new Size(80, 25));
					num = (int)((num2 * 2050283641) ^ 0x617972A3);
					continue;
				case 31u:
					SearchPatient_Admin.smethod_24(Label10, (ContentAlignment)32);
					num = (int)(num2 * 1431979648) ^ -1723229192;
					continue;
				case 30u:
					ClearBtn = SearchPatient_Admin.smethod_6();
					num = (int)((num2 * 867423506) ^ 0xD892C9D);
					continue;
				case 29u:
					SearchPatient_Admin.smethod_21((Control)(object)UpdateBtn, SearchPatient_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1731278564) ^ -1414022683;
					continue;
				case 28u:
					SearchPatient_Admin.smethod_15((Control)(object)DeleteBtn, "DeleteBtn");
					num = (int)((num2 * 1804272371) ^ 0x731CFBB6);
					continue;
				case 27u:
					SearchPatient_Admin.smethod_45((ContainerControl)(object)this, new SizeF(8f, 16f));
					num = (int)((num2 * 306171924) ^ 0x4F42C0ED);
					continue;
				case 26u:
					num = ((int)num2 * -681813) ^ -68674667;
					continue;
				case 25u:
					Label4 = SearchPatient_Admin.smethod_4();
					num = ((int)num2 * -1449102287) ^ 0x4320457E;
					continue;
				case 24u:
					SearchPatient_Admin.smethod_22((Control)(object)DOBTxt, 12);
					num = (int)(num2 * 812174089) ^ -96440549;
					continue;
				case 23u:
					SearchPatient_Admin.smethod_23(Label3, "Mobile : ");
					num = ((int)num2 * -762323784) ^ 0x70629903;
					continue;
				case 22u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_25((Control)(object)PatientInfoBox), (Control)(object)DOBTxt);
					num = (int)(num2 * 1224423426) ^ -1977589296;
					continue;
				case 21u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_48((Control)(object)this), (Control)(object)UpdateBtn);
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_48((Control)(object)this), (Control)(object)ClearBtn);
					num = (int)((num2 * 1589261294) ^ 0x35ACA8FB);
					continue;
				case 20u:
					num = (int)((num2 * 1525718983) ^ 0x52AEAFE0);
					continue;
				case 19u:
					num = ((int)num2 * -655975922) ^ 0x62FB1D51;
					continue;
				case 18u:
					SearchPatient_Admin.smethod_14((Control)(object)Label2, new Point(37, 44));
					SearchPatient_Admin.smethod_15((Control)(object)Label2, "Label2");
					SearchPatient_Admin.smethod_16((Control)(object)Label2, new Size(77, 28));
					num = (int)(num2 * 1535588101) ^ -489101390;
					continue;
				case 17u:
					SearchPatient_Admin.smethod_18(PictureBox1, 9);
					num = (int)((num2 * 1265214340) ^ 0x674A3368);
					continue;
				case 16u:
					num = (int)((num2 * 1245130428) ^ 0x37A6556E);
					continue;
				case 15u:
					SearchPatient_Admin.smethod_44((TextBoxBase)(object)PIDTxt, bool_0: true);
					num = (int)(num2 * 372260195) ^ -791513006;
					continue;
				case 14u:
					SearchPatient_Admin.smethod_16((Control)(object)Label7, new Size(96, 26));
					num = ((int)num2 * -2009455534) ^ -150189416;
					continue;
				case 13u:
					num = (int)((num2 * 1887916044) ^ 0x3B80186C);
					continue;
				case 12u:
					SearchPatient_Admin.smethod_21((Control)(object)DeleteBtn, SearchPatient_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -2052258943) ^ 0x1E5F88C7;
					continue;
				case 11u:
					SearchPatient_Admin.smethod_24(Label3, (ContentAlignment)32);
					num = (int)(num2 * 1643045343) ^ -79361882;
					continue;
				case 10u:
					SearchPatient_Admin.smethod_16((Control)(object)NameTxt, new Size(315, 28));
					SearchPatient_Admin.smethod_22((Control)(object)NameTxt, 9);
					num = (int)((num2 * 1054850534) ^ 0x5F2D0EB1);
					continue;
				case 9u:
					num = ((int)num2 * -1582622280) ^ 0x39F6013;
					continue;
				case 8u:
					num = (int)((num2 * 1964885739) ^ 0xB43AD0B);
					continue;
				case 7u:
					num = ((int)num2 * -1217676883) ^ 0x2ECA5B69;
					continue;
				case 6u:
					SearchPatient_Admin.smethod_14((Control)(object)Label7, new Point(452, 132));
					num = (int)((num2 * 376621369) ^ 0x6CE8DFF3);
					continue;
				case 5u:
					SearchPatient_Admin.smethod_14((Control)(object)MobileSTxt, new Point(120, 86));
					num = (int)((num2 * 699220599) ^ 0x1A9DF358);
					continue;
				case 4u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_25((Control)(object)PatientInfoBox), (Control)(object)NameTxt);
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_25((Control)(object)PatientInfoBox), (Control)(object)Label14);
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_25((Control)(object)PatientInfoBox), (Control)(object)AddressTxt);
					num = (int)(num2 * 917338910) ^ -861225389;
					continue;
				case 3u:
					SearchPatient_Admin.smethod_14((Control)(object)Label1, new Point(392, 63));
					SearchPatient_Admin.smethod_15((Control)(object)Label1, "Label1");
					num = (int)((num2 * 1990346733) ^ 0x1E6F726A);
					continue;
				case 2u:
					SearchPatient_Admin.smethod_22((Control)(object)NameSTxt, 1);
					num = (int)((num2 * 944355037) ^ 0x5337D01F);
					continue;
				case 1u:
					num = (int)(num2 * 2076439974) ^ -1806520420;
					continue;
				case 0u:
					SearchPatient_Admin.smethod_22((Control)(object)Label3, 3);
					num = (int)(num2 * 41428298) ^ -1733692261;
					continue;
				default:
					return;
				case 225u:
					break;
				case 178u:
					return;
				}
				break;
			}
		}
	}

	private void SearchPatient_Admin_Load(object sender, EventArgs e)
	{
		SearchPatient_Admin.smethod_60(myconnection, SearchPatient_Admin.smethod_59(MyProject.Forms.Form1.provider, MyProject.Forms.Form1.datafile));
		while (true)
		{
			int num = 1291638052;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7AC7683Bu) % 4u)
				{
				case 3u:
					num = ((int)num2 * -607720455) ^ 0x15E20128;
					continue;
				case 0u:
					HideItemsOnForm();
					num = (int)((num2 * 680029264) ^ 0x22BFF752);
					continue;
				case 2u:
					break;
				default:
					SearchPatient_Admin.smethod_40(DOBTxt, SearchPatient_Admin.smethod_62(SearchPatient_Admin.smethod_61((object)DateTime.Now, "dd-MM-yyyy")));
					return;
				}
				break;
			}
		}
	}

	private void SearchBtn_Click(object sender, EventArgs e)
	{
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Expected I4, but got Unknown
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Expected I4, but got Unknown
		//IL_0372: Incompatible stack heights: 0 vs 1
		//IL_038d: Incompatible stack heights: 0 vs 1
		//IL_039d: Incompatible stack heights: 0 vs 1
		//IL_03a4: Incompatible stack heights: 0 vs 1
		string string_ = default(string);
		DataTable dataTable = default(DataTable);
		bool flag = default(bool);
		while (true)
		{
			int num = -22027792;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAA70E3E6u) % 9u)
				{
				case 7u:
					SearchPatient_Admin.smethod_66();
					num = ((int)num2 * -545557123) ^ 0x4AB10E92;
					continue;
				case 6u:
					string_ = SearchPatient_Admin.smethod_67(new string[5]
					{
						"Select * From [Patient] Where [Name] Like '%",
						SearchPatient_Admin.smethod_64(SearchPatient_Admin.smethod_63(NameSTxt)),
						"%' And [Mobile] Like '%",
						SearchPatient_Admin.smethod_63(MobileSTxt),
						"%';"
					});
					num = ((int)num2 * -128274973) ^ 0x44253772;
					continue;
				case 5u:
					dataTable = SearchPatient_Admin.smethod_68();
					num = (int)((num2 * 61714893) ^ 0x3427ABD6);
					continue;
				case 4u:
					HideItemsOnForm();
					num = (int)((num2 * 1612776460) ^ 0x113B2874);
					continue;
				case 1u:
				{
					int num6;
					int num7;
					if (!MyProject.Forms.Form1.Name_Validation(SearchPatient_Admin.smethod_64(SearchPatient_Admin.smethod_63(NameSTxt))) | !MyProject.Forms.Form1.Mobile_Validator(SearchPatient_Admin.smethod_64(SearchPatient_Admin.smethod_63(MobileSTxt))))
					{
						num6 = 688343929;
						num7 = 688343929;
					}
					else
					{
						num6 = 1773169883;
						num7 = 1773169883;
					}
					num = num6 ^ (int)(num2 * 76595474);
					continue;
				}
				case 0u:
					num = -1754467914;
					continue;
				case 3u:
					break;
				case 2u:
					SearchPatient_Admin.smethod_65("No Results Found");
					return;
				default:
					SearchPatient_Admin.smethod_69(myconnection);
					try
					{
						while (true)
						{
							int num3 = -1353417665;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xAA70E3E6u) % 15u)
								{
								case 14u:
									num3 = ((int)num2 * -1122448842) ^ -1175773998;
									continue;
								case 13u:
									num3 = ((int)num2 * -1563080728) ^ 0x65C03D52;
									continue;
								case 12u:
								{
									OleDbDataAdapter dbDataAdapter_ = SearchPatient_Admin.smethod_70(string_, myconnection);
									SearchPatient_Admin.smethod_71((DbDataAdapter)(object)dbDataAdapter_, dataTable);
									num3 = (int)((num2 * 1416433525) ^ 0x6F6DDE1);
									continue;
								}
								case 10u:
									name_search = SearchPatient_Admin.smethod_64(SearchPatient_Admin.smethod_63(NameSTxt));
									mobile_search = SearchPatient_Admin.smethod_63(MobileSTxt);
									num3 = (int)((num2 * 2088026614) ^ 0x6718386C);
									continue;
								case 9u:
								{
									int num4;
									int num5;
									if (!flag)
									{
										num4 = -1300061213;
										num5 = -1300061213;
									}
									else
									{
										num4 = -1915219482;
										num5 = -1915219482;
									}
									num3 = num4 ^ ((int)num2 * -542231755);
									continue;
								}
								case 8u:
									SearchPatient_Admin.smethod_74(myconnection);
									num3 = ((int)num2 * -173068737) ^ -907135825;
									continue;
								case 7u:
									SearchPatient_Admin.smethod_72(SearchResultGrid, (object)dataTable);
									num3 = ((int)num2 * -150687576) ^ -1091028536;
									continue;
								case 6u:
									flag = SearchPatient_Admin.smethod_73(SearchResultGrid) == 1;
									num3 = ((int)num2 * -185690491) ^ 0x3C835564;
									continue;
								case 5u:
									num3 = (int)((num2 * 1917108558) ^ 0xF08F870);
									continue;
								case 4u:
									SearchPatient_Admin.smethod_65("No Result Found");
									num3 = ((int)num2 * -34863412) ^ -1202843245;
									continue;
								case 3u:
									SearchPatient_Admin.smethod_74(myconnection);
									num3 = (int)((num2 * 1862998939) ^ 0x73F303DE);
									continue;
								case 2u:
									SearchPatient_Admin.smethod_38((Control)(object)SearchResultGrid, bool_0: true);
									num3 = -997388537;
									continue;
								default:
									return;
								case 0u:
									break;
								case 1u:
									return;
								case 11u:
									return;
								}
								break;
							}
						}
					}
					catch (Exception exception_)
					{
						SearchPatient_Admin.smethod_75(exception_);
						while (true)
						{
							_ = -1259686436;
							while (true)
							{
								_003F val = /*Error near IL_033f: Stack underflow*/^ -1435442202;
								num2 = (uint)(int)val;
								switch (val % 5)
								{
								default:
									return;
								case 4:
									SearchPatient_Admin.smethod_76();
									_ = (num2 * 1951932082) ^ 0x1EB57C7E;
									continue;
								case 3:
									SearchPatient_Admin.smethod_74(myconnection);
									_ = ((int)num2 * -325138373) ^ -2013659185;
									continue;
								case 0:
									_ = ((int)num2 * -282581647) ^ 0x1C0B5C13;
									continue;
								case 2:
									break;
								case 1:
									return;
								}
								break;
							}
						}
					}
				}
				break;
			}
		}
	}

	private bool HideItemsOnForm()
	{
		bool result = default(bool);
		while (true)
		{
			int num = -1640879844;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCBC6E5E1u) % 12u)
				{
				case 11u:
					SearchPatient_Admin.smethod_38((Control)(object)UpdateBtn, bool_0: false);
					num = (int)((num2 * 1024996496) ^ 0x11737274);
					continue;
				case 10u:
					num = ((int)num2 * -2005441662) ^ 0x6190C64D;
					continue;
				case 9u:
					SearchPatient_Admin.smethod_38((Control)(object)SearchResultGrid, bool_0: false);
					num = ((int)num2 * -177859921) ^ 0x3B77A25C;
					continue;
				case 7u:
					SearchPatient_Admin.smethod_38((Control)(object)ClearBtn, bool_0: false);
					num = (int)(num2 * 1171799857) ^ -1479618905;
					continue;
				case 6u:
					result = true;
					num = ((int)num2 * -821687449) ^ 0x10964E99;
					continue;
				case 5u:
					num = (int)(num2 * 1597895142) ^ -685494432;
					continue;
				case 4u:
					num = (int)(num2 * 696182928) ^ -1545812669;
					continue;
				case 2u:
					num = ((int)num2 * -1351897470) ^ -300718867;
					continue;
				case 1u:
					SearchPatient_Admin.smethod_38((Control)(object)DeleteBtn, bool_0: false);
					num = ((int)num2 * -1159567019) ^ -862377572;
					continue;
				case 0u:
					SearchPatient_Admin.smethod_38((Control)(object)PatientInfoBox, bool_0: false);
					num = ((int)num2 * -2017142646) ^ 0x257B5832;
					continue;
				case 3u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	private void DeleteBtn_Click(object sender, EventArgs e)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected I4, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected I4, but got Unknown
		//IL_01c5: Incompatible stack heights: 0 vs 1
		//IL_01e0: Incompatible stack heights: 0 vs 1
		//IL_01e7: Incompatible stack heights: 0 vs 1
		bool flag = SearchPatient_Admin.smethod_77(SearchPatient_Admin.smethod_63(PIDTxt), "", bool_0: false) == 0;
		string string_ = default(string);
		while (true)
		{
			int num = 92795927;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x794BB8A5u) % 8u)
				{
				case 6u:
					SearchPatient_Admin.smethod_69(myconnection);
					num = (int)(num2 * 523603231) ^ -793097008;
					continue;
				case 3u:
					SearchPatient_Admin.smethod_65("Nothing To Delete");
					num = ((int)num2 * -408147167) ^ -1832009174;
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1224131510;
						num5 = -1224131510;
					}
					else
					{
						num4 = -1308499928;
						num5 = -1308499928;
					}
					num = num4 ^ (int)(num2 * 376398994);
					continue;
				}
				case 1u:
				{
					OleDbCommand val = SearchPatient_Admin.smethod_66();
					num = 272663461;
					continue;
				}
				case 0u:
					string_ = SearchPatient_Admin.smethod_78("Delete From [Patient] Where [PID] = ", SearchPatient_Admin.smethod_63(PIDTxt), ";");
					num = ((int)num2 * -1173104380) ^ -1085159261;
					continue;
				case 5u:
					break;
				default:
					try
					{
						OleDbCommand val = SearchPatient_Admin.smethod_79(string_, myconnection);
						SearchPatient_Admin.smethod_80(val);
						while (true)
						{
							int num3 = 479547246;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x794BB8A5u) % 5u)
								{
								case 4u:
									UpdateTable();
									ClearPatientInfo();
									num3 = (int)((num2 * 35101487) ^ 0x49E36A9C);
									continue;
								case 3u:
									SearchPatient_Admin.smethod_81((Component)(object)val);
									num3 = ((int)num2 * -1783093895) ^ -825535732;
									continue;
								case 0u:
									SearchPatient_Admin.smethod_74(myconnection);
									num3 = (int)(num2 * 126757004) ^ -760696235;
									continue;
								case 2u:
									break;
								default:
									SearchPatient_Admin.smethod_65("Successfully Deleted Entry");
									return;
								}
								break;
							}
						}
					}
					catch (Exception exception_)
					{
						SearchPatient_Admin.smethod_75(exception_);
						while (true)
						{
							_ = 607107615;
							while (true)
							{
								_003F val2 = /*Error near IL_0196: Stack underflow*/^ 0x794BB8A5;
								num2 = (uint)(int)val2;
								switch (val2 % 4)
								{
								default:
									return;
								case 3:
									SearchPatient_Admin.smethod_76();
									_ = ((int)num2 * -1550784753) ^ -1150781939;
									continue;
								case 2:
									SearchPatient_Admin.smethod_74(myconnection);
									_ = ((int)num2 * -1131460567) ^ 0x729B24EC;
									continue;
								case 0:
									break;
								case 1:
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

	private void UpdateBtn_Click(object sender, EventArgs e)
	{
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		bool flag = (SearchPatient_Admin.smethod_77(SearchPatient_Admin.smethod_63(NameTxt), "", bool_0: false) == 0) | (SearchPatient_Admin.smethod_77(SearchPatient_Admin.smethod_63(MobileSTxt), "", bool_0: false) == 0) | (SearchPatient_Admin.smethod_77(SearchPatient_Admin.smethod_63(GenderTxt), "", bool_0: false) == 0) | (SearchPatient_Admin.smethod_77(SearchPatient_Admin.smethod_63(AddressTxt), "", bool_0: false) == 0);
		string string_ = default(string);
		DateTime dateTime_ = default(DateTime);
		while (true)
		{
			int num = 1525797586;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x58CC25F7u) % 14u)
				{
				case 12u:
					SearchPatient_Admin.smethod_65("Empty Fields Not Allowed");
					num = (int)((num2 * 407883367) ^ 0x32B430F8);
					continue;
				case 11u:
				{
					int num6;
					int num7;
					if (!(MyProject.Forms.Form1.Name_Validation(SearchPatient_Admin.smethod_64(SearchPatient_Admin.smethod_63(NameTxt))) & MyProject.Forms.Form1.Mobile_Validator(SearchPatient_Admin.smethod_63(MobileSTxt)) & MyProject.Forms.Form1.Gender_Validator(SearchPatient_Admin.smethod_64(SearchPatient_Admin.smethod_63(GenderTxt)))))
					{
						num6 = -725911087;
						num7 = -725911087;
					}
					else
					{
						num6 = -112315750;
						num7 = -112315750;
					}
					num = num6 ^ ((int)num2 * -1615766354);
					continue;
				}
				case 10u:
					string_ = SearchPatient_Admin.smethod_67(new string[13]
					{
						"Update [Patient] Set [Name] = '",
						SearchPatient_Admin.smethod_63(NameTxt),
						"', [DOB] = #",
						SearchPatient_Admin.smethod_83(dateTime_),
						"#, [Mobile] = '",
						SearchPatient_Admin.smethod_63(MobileTxt),
						"', [Gender] = '",
						SearchPatient_Admin.smethod_63(GenderTxt),
						"', [Address] = '",
						SearchPatient_Admin.smethod_63(AddressTxt),
						"' Where [PID] = ",
						SearchPatient_Admin.smethod_63(PIDTxt),
						";"
					});
					num = (int)((num2 * 746504696) ^ 0x49EF44DB);
					continue;
				case 9u:
					num = 1500780770;
					continue;
				case 8u:
				{
					OleDbCommand val = SearchPatient_Admin.smethod_66();
					num = ((int)num2 * -22121708) ^ 0x70E86BB;
					continue;
				}
				case 6u:
					dateTime_ = SearchPatient_Admin.smethod_62(SearchPatient_Admin.smethod_61((object)SearchPatient_Admin.smethod_82(DOBTxt), "dd-MM-yyyy"));
					num = (int)((num2 * 2128275021) ^ 0xBF240F);
					continue;
				case 5u:
					num = 1607469197;
					continue;
				case 4u:
					SearchPatient_Admin.smethod_65("Invalid Credentials");
					num = (int)(num2 * 1604561400) ^ -686768762;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -67037689;
						num5 = -67037689;
					}
					else
					{
						num4 = -338745342;
						num5 = -338745342;
					}
					num = num4 ^ (int)(num2 * 931768194);
					continue;
				}
				case 0u:
					SearchPatient_Admin.smethod_69(myconnection);
					num = (int)(num2 * 813670874) ^ -1361807966;
					continue;
				case 2u:
					break;
				default:
					try
					{
						OleDbCommand val = SearchPatient_Admin.smethod_79(string_, myconnection);
						while (true)
						{
							int num3 = 622423159;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x58CC25F7u) % 6u)
								{
								case 5u:
									SearchPatient_Admin.smethod_74(myconnection);
									num3 = (int)((num2 * 989432133) ^ 0x6E0BDA9C);
									continue;
								case 2u:
									SearchPatient_Admin.smethod_80(val);
									SearchPatient_Admin.smethod_81((Component)(object)val);
									num3 = (int)((num2 * 1971775490) ^ 0x5676DA30);
									continue;
								case 1u:
									ClearPatientInfo();
									num3 = ((int)num2 * -1750651596) ^ -1011175893;
									continue;
								case 0u:
									SearchPatient_Admin.smethod_65("Successfully Updated Details");
									num3 = ((int)num2 * -1276353227) ^ -1875450902;
									continue;
								case 3u:
									break;
								default:
									UpdateTable();
									return;
								}
								break;
							}
						}
					}
					catch (Exception exception_)
					{
						SearchPatient_Admin.smethod_75(exception_);
						SearchPatient_Admin.smethod_74(myconnection);
						SearchPatient_Admin.smethod_76();
						return;
					}
				case 7u:
				case 13u:
					return;
				}
				break;
			}
		}
	}

	private void ClearBtn_Click(object sender, EventArgs e)
	{
		ClearPatientInfo();
	}

	private bool UpdateTable()
	{
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected I4, but got Unknown
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected I4, but got Unknown
		//IL_01ae: Incompatible stack heights: 0 vs 1
		//IL_01c3: Incompatible stack heights: 0 vs 1
		//IL_01d3: Incompatible stack heights: 0 vs 1
		//IL_01ee: Incompatible stack heights: 0 vs 1
		//IL_01f5: Incompatible stack heights: 0 vs 1
		string string_ = default(string);
		bool result = default(bool);
		while (true)
		{
			int num = -528175994;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBE625AB3u) % 4u)
				{
				case 3u:
					string_ = SearchPatient_Admin.smethod_67(new string[5]
					{
						"Select * From [Patient] Where [Name] Like '%",
						SearchPatient_Admin.smethod_64(name_search),
						"%' And [Mobile] Like '%",
						mobile_search,
						"%';"
					});
					num = (int)(num2 * 967052150) ^ -827023463;
					continue;
				case 1u:
					SearchPatient_Admin.smethod_66();
					num = ((int)num2 * -618897559) ^ 0x7CAD3B31;
					continue;
				case 2u:
					break;
				default:
				{
					DataTable dataTable = SearchPatient_Admin.smethod_68();
					SearchPatient_Admin.smethod_69(myconnection);
					try
					{
						OleDbDataAdapter dbDataAdapter_ = SearchPatient_Admin.smethod_70(string_, myconnection);
						SearchPatient_Admin.smethod_71((DbDataAdapter)(object)dbDataAdapter_, dataTable);
						while (true)
						{
							IL_0151:
							int num3 = -1810324282;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xBE625AB3u) % 6u)
								{
								case 5u:
									SearchPatient_Admin.smethod_38((Control)(object)SearchResultGrid, bool_0: true);
									num3 = -211336063;
									continue;
								case 2u:
									SearchPatient_Admin.smethod_74(myconnection);
									result = false;
									num3 = ((int)num2 * -491712225) ^ 0x10B605A6;
									continue;
								case 1u:
								{
									SearchPatient_Admin.smethod_72(SearchResultGrid, (object)dataTable);
									int num4;
									int num5;
									if (SearchPatient_Admin.smethod_73(SearchResultGrid) == 1)
									{
										num4 = 689568960;
										num5 = 689568960;
									}
									else
									{
										num4 = 126938485;
										num5 = 126938485;
									}
									num3 = num4 ^ (int)(num2 * 1778674601);
									continue;
								}
								case 4u:
									break;
								default:
									SearchPatient_Admin.smethod_74(myconnection);
									goto end_IL_0127;
								case 3u:
									return result;
								}
								goto IL_0151;
								continue;
								end_IL_0127:
								break;
							}
							break;
						}
					}
					catch (Exception exception_)
					{
						SearchPatient_Admin.smethod_75(exception_);
						while (true)
						{
							IL_01f0:
							_ = -1474492207;
							while (true)
							{
								_003F val = /*Error near IL_017c: Stack underflow*/^ -1100850509;
								num2 = (uint)(int)val;
								switch (val % 6)
								{
								default:
									goto end_IL_0176;
								case 5:
									_ = ((int)num2 * -523834076) ^ 0x132C1E72;
									continue;
								case 3:
									SearchPatient_Admin.smethod_76();
									_ = ((int)num2 * -794600978) ^ -1306769111;
									continue;
								case 2:
									_ = (num2 * 949655067) ^ 0x10C9788A;
									continue;
								case 1:
									SearchPatient_Admin.smethod_74(myconnection);
									_ = ((int)num2 * -1901038733) ^ 0x15E70971;
									continue;
								case 4:
									break;
								case 0:
									goto end_IL_0176;
								}
								goto IL_01f0;
								continue;
								end_IL_0176:
								break;
							}
							break;
						}
					}
					result = false;
					while (true)
					{
						int num6 = -1422337108;
						while (true)
						{
							switch ((num2 = (uint)num6 ^ 0xBE625AB3u) % 3u)
							{
							case 1u:
								goto IL_0200;
							case 2u:
								break;
							default:
								return result;
							}
							break;
							IL_0200:
							num6 = ((int)num2 * -736433847) ^ -763112401;
						}
					}
				}
				}
				break;
			}
		}
	}

	private void SearchResultGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected I4, but got Unknown
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected I4, but got Unknown
		//IL_028d: Incompatible stack heights: 0 vs 1
		//IL_0294: Incompatible stack heights: 0 vs 1
		try
		{
			SearchPatient_Admin.smethod_91(PIDTxt, SearchPatient_Admin.smethod_90(SearchPatient_Admin.smethod_89(SearchPatient_Admin.smethod_88(SearchPatient_Admin.smethod_87(SearchPatient_Admin.smethod_86(SearchPatient_Admin.smethod_84(SearchResultGrid), SearchPatient_Admin.smethod_85(e))), 0))));
			while (true)
			{
				int num = -1581756547;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD47A73F6u) % 11u)
					{
					case 10u:
						num = (int)((num2 * 1302766493) ^ 0x3A9DB02B);
						continue;
					case 9u:
						num = ((int)num2 * -1642828659) ^ -692388648;
						continue;
					case 7u:
						SearchPatient_Admin.smethod_91(NameTxt, SearchPatient_Admin.smethod_90(SearchPatient_Admin.smethod_89(SearchPatient_Admin.smethod_88(SearchPatient_Admin.smethod_87(SearchPatient_Admin.smethod_86(SearchPatient_Admin.smethod_84(SearchResultGrid), SearchPatient_Admin.smethod_85(e))), 1))));
						SearchPatient_Admin.smethod_92(DOBTxt, SearchPatient_Admin.smethod_90(SearchPatient_Admin.smethod_89(SearchPatient_Admin.smethod_88(SearchPatient_Admin.smethod_87(SearchPatient_Admin.smethod_86(SearchPatient_Admin.smethod_84(SearchResultGrid), SearchPatient_Admin.smethod_85(e))), 2))));
						num = (int)(num2 * 1354969635) ^ -116027525;
						continue;
					case 5u:
						SearchPatient_Admin.smethod_91(MobileTxt, SearchPatient_Admin.smethod_90(SearchPatient_Admin.smethod_89(SearchPatient_Admin.smethod_88(SearchPatient_Admin.smethod_87(SearchPatient_Admin.smethod_86(SearchPatient_Admin.smethod_84(SearchResultGrid), SearchPatient_Admin.smethod_85(e))), 4))));
						num = ((int)num2 * -1331590257) ^ -192194945;
						continue;
					case 4u:
						SearchPatient_Admin.smethod_38((Control)(object)ClearBtn, bool_0: true);
						SearchPatient_Admin.smethod_38((Control)(object)UpdateBtn, bool_0: true);
						num = (int)((num2 * 624142598) ^ 0x4B330CD6);
						continue;
					case 3u:
						SearchPatient_Admin.smethod_91(GenderTxt, SearchPatient_Admin.smethod_90(SearchPatient_Admin.smethod_89(SearchPatient_Admin.smethod_88(SearchPatient_Admin.smethod_87(SearchPatient_Admin.smethod_86(SearchPatient_Admin.smethod_84(SearchResultGrid), SearchPatient_Admin.smethod_85(e))), 3))));
						num = (int)(num2 * 1429055651) ^ -1676309082;
						continue;
					case 2u:
						SearchPatient_Admin.smethod_38((Control)(object)DeleteBtn, bool_0: true);
						num = ((int)num2 * -1565443491) ^ 0xAF1F9D6;
						continue;
					case 1u:
						SearchPatient_Admin.smethod_38((Control)(object)PatientInfoBox, bool_0: true);
						num = (int)(num2 * 959188401) ^ -1083781161;
						continue;
					case 0u:
						SearchPatient_Admin.smethod_91(AddressTxt, SearchPatient_Admin.smethod_90(SearchPatient_Admin.smethod_89(SearchPatient_Admin.smethod_88(SearchPatient_Admin.smethod_87(SearchPatient_Admin.smethod_86(SearchPatient_Admin.smethod_84(SearchResultGrid), SearchPatient_Admin.smethod_85(e))), 5))));
						num = ((int)num2 * -1313388559) ^ -689202161;
						continue;
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
		catch (Exception exception_)
		{
			SearchPatient_Admin.smethod_75(exception_);
			while (true)
			{
				_ = -1892462362;
				while (true)
				{
					_003F val = /*Error near IL_0264: Stack underflow*/^ -730172426;
					uint num2 = (uint)(int)val;
					switch (val % 3)
					{
					default:
						return;
					case 2:
						SearchPatient_Admin.smethod_76();
						_ = (num2 * 2135132779) ^ 0x7DA9EBB6;
						continue;
					case 0:
						break;
					case 1:
						return;
					}
					break;
				}
			}
		}
	}

	private bool ClearPatientInfo()
	{
		SearchPatient_Admin.smethod_93((TextBoxBase)(object)PIDTxt);
		bool result = default(bool);
		while (true)
		{
			int num = 2016521064;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x450323BAu) % 9u)
				{
				case 8u:
					num = ((int)num2 * -36485200) ^ 0x7F287E74;
					continue;
				case 7u:
					SearchPatient_Admin.smethod_93((TextBoxBase)(object)MobileTxt);
					num = ((int)num2 * -1390221093) ^ 0x2CC645FB;
					continue;
				case 6u:
					SearchPatient_Admin.smethod_42(DOBTxt, SearchPatient_Admin.smethod_62(SearchPatient_Admin.smethod_61((object)SearchPatient_Admin.smethod_94(), "dd-MM-yyyy")));
					num = ((int)num2 * -1714102509) ^ 0x576B420D;
					continue;
				case 4u:
					SearchPatient_Admin.smethod_93((TextBoxBase)(object)NameTxt);
					num = (int)(num2 * 572486624) ^ -1607795761;
					continue;
				case 3u:
					num = (int)((num2 * 1388733194) ^ 0x1D8DDD5D);
					continue;
				case 2u:
					SearchPatient_Admin.smethod_93((TextBoxBase)(object)AddressTxt);
					num = ((int)num2 * -783307948) ^ 0x60E87670;
					continue;
				case 1u:
					SearchPatient_Admin.smethod_93((TextBoxBase)(object)GenderTxt);
					result = true;
					num = ((int)num2 * -927570236) ^ -972312891;
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

	static PictureBox smethod_3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new PictureBox();
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

	static TextBox smethod_7()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new TextBox();
	}

	static DataGridView smethod_8()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new DataGridView();
	}

	static DateTimePicker smethod_9()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new DateTimePicker();
	}

	static void smethod_10(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.BeginInit();
	}

	static void smethod_11(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_12(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_13(PictureBox pictureBox_0, Image image_0)
	{
		pictureBox_0.set_Image(image_0);
	}

	static void smethod_14(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_15(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_16(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_17(PictureBox pictureBox_0, PictureBoxSizeMode pictureBoxSizeMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		pictureBox_0.set_SizeMode(pictureBoxSizeMode_0);
	}

	static void smethod_18(PictureBox pictureBox_0, int int_0)
	{
		pictureBox_0.set_TabIndex(int_0);
	}

	static void smethod_19(PictureBox pictureBox_0, bool bool_0)
	{
		pictureBox_0.set_TabStop(bool_0);
	}

	static Font smethod_20(string string_0, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_21(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static void smethod_22(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static void smethod_23(Label label_0, string string_0)
	{
		label_0.set_Text(string_0);
	}

	static void smethod_24(Label label_0, ContentAlignment contentAlignment_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		label_0.set_TextAlign(contentAlignment_0);
	}

	static ControlCollection smethod_25(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_26(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_27(GroupBox groupBox_0, bool bool_0)
	{
		groupBox_0.set_TabStop(bool_0);
	}

	static void smethod_28(GroupBox groupBox_0, string string_0)
	{
		groupBox_0.set_Text(string_0);
	}

	static void smethod_29(ButtonBase buttonBase_0, Color color_0)
	{
		buttonBase_0.set_BackColor(color_0);
	}

	static void smethod_30(Control control_0, Color color_0)
	{
		control_0.set_ForeColor(color_0);
	}

	static void smethod_31(ButtonBase buttonBase_0, string string_0)
	{
		buttonBase_0.set_Text(string_0);
	}

	static void smethod_32(ButtonBase buttonBase_0, bool bool_0)
	{
		buttonBase_0.set_UseVisualStyleBackColor(bool_0);
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

	static void smethod_38(Control control_0, bool bool_0)
	{
		control_0.set_Visible(bool_0);
	}

	static void smethod_39(DateTimePicker dateTimePicker_0, DateTimePickerFormat dateTimePickerFormat_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		dateTimePicker_0.set_Format(dateTimePickerFormat_0);
	}

	static void smethod_40(DateTimePicker dateTimePicker_0, DateTime dateTime_0)
	{
		dateTimePicker_0.set_MaxDate(dateTime_0);
	}

	static void smethod_41(DateTimePicker dateTimePicker_0, DateTime dateTime_0)
	{
		dateTimePicker_0.set_MinDate(dateTime_0);
	}

	static void smethod_42(DateTimePicker dateTimePicker_0, DateTime dateTime_0)
	{
		dateTimePicker_0.set_Value(dateTime_0);
	}

	static void smethod_43(TextBox textBox_0, bool bool_0)
	{
		textBox_0.set_Multiline(bool_0);
	}

	static void smethod_44(TextBoxBase textBoxBase_0, bool bool_0)
	{
		textBoxBase_0.set_ReadOnly(bool_0);
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

	static void smethod_47(Control control_0, Color color_0)
	{
		control_0.set_BackColor(color_0);
	}

	static ControlCollection smethod_48(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_49(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_50(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_51(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.EndInit();
	}

	static void smethod_52(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_53(Control control_0)
	{
		control_0.PerformLayout();
	}

	static void smethod_54(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_55(Control control_0, EventHandler eventHandler_0)
	{
		control_0.remove_Click(eventHandler_0);
	}

	static void smethod_56(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_Click(eventHandler_0);
	}

	static void smethod_57(DataGridView dataGridView_0, DataGridViewCellMouseEventHandler dataGridViewCellMouseEventHandler_0)
	{
		dataGridView_0.remove_CellMouseClick(dataGridViewCellMouseEventHandler_0);
	}

	static void smethod_58(DataGridView dataGridView_0, DataGridViewCellMouseEventHandler dataGridViewCellMouseEventHandler_0)
	{
		dataGridView_0.add_CellMouseClick(dataGridViewCellMouseEventHandler_0);
	}

	static string smethod_59(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static void smethod_60(OleDbConnection oleDbConnection_0, string string_0)
	{
		oleDbConnection_0.set_ConnectionString(string_0);
	}

	static string smethod_61(object object_0, string string_0)
	{
		return Strings.Format(object_0, string_0);
	}

	static DateTime smethod_62(string string_0)
	{
		return Conversions.ToDate(string_0);
	}

	static string smethod_63(TextBox textBox_0)
	{
		return textBox_0.get_Text();
	}

	static string smethod_64(string string_0)
	{
		return string_0.ToLower();
	}

	static DialogResult smethod_65(string string_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0);
	}

	static OleDbCommand smethod_66()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new OleDbCommand();
	}

	static string smethod_67(string[] string_0)
	{
		return string.Concat(string_0);
	}

	static DataTable smethod_68()
	{
		return new DataTable();
	}

	static void smethod_69(OleDbConnection oleDbConnection_0)
	{
		oleDbConnection_0.Open();
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

	static void smethod_72(DataGridView dataGridView_0, object object_0)
	{
		dataGridView_0.set_DataSource(object_0);
	}

	static int smethod_73(DataGridView dataGridView_0)
	{
		return dataGridView_0.get_RowCount();
	}

	static void smethod_74(OleDbConnection oleDbConnection_0)
	{
		oleDbConnection_0.Close();
	}

	static void smethod_75(Exception exception_0)
	{
		ProjectData.SetProjectError(exception_0);
	}

	static void smethod_76()
	{
		ProjectData.ClearProjectError();
	}

	static int smethod_77(string string_0, string string_1, bool bool_0)
	{
		return Operators.CompareString(string_0, string_1, bool_0);
	}

	static string smethod_78(string string_0, string string_1, string string_2)
	{
		return string_0 + string_1 + string_2;
	}

	static OleDbCommand smethod_79(string string_0, OleDbConnection oleDbConnection_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new OleDbCommand(string_0, oleDbConnection_0);
	}

	static int smethod_80(OleDbCommand oleDbCommand_0)
	{
		return oleDbCommand_0.ExecuteNonQuery();
	}

	static void smethod_81(Component component_0)
	{
		component_0.Dispose();
	}

	static DateTime smethod_82(DateTimePicker dateTimePicker_0)
	{
		return dateTimePicker_0.get_Value();
	}

	static string smethod_83(DateTime dateTime_0)
	{
		return Conversions.ToString(dateTime_0);
	}

	static DataGridViewRowCollection smethod_84(DataGridView dataGridView_0)
	{
		return dataGridView_0.get_Rows();
	}

	static int smethod_85(DataGridViewCellMouseEventArgs dataGridViewCellMouseEventArgs_0)
	{
		return dataGridViewCellMouseEventArgs_0.get_RowIndex();
	}

	static DataGridViewRow smethod_86(DataGridViewRowCollection dataGridViewRowCollection_0, int int_0)
	{
		return dataGridViewRowCollection_0.get_Item(int_0);
	}

	static DataGridViewCellCollection smethod_87(DataGridViewRow dataGridViewRow_0)
	{
		return dataGridViewRow_0.get_Cells();
	}

	static DataGridViewCell smethod_88(DataGridViewCellCollection dataGridViewCellCollection_0, int int_0)
	{
		return dataGridViewCellCollection_0.get_Item(int_0);
	}

	static object smethod_89(DataGridViewCell dataGridViewCell_0)
	{
		return dataGridViewCell_0.get_Value();
	}

	static string smethod_90(object object_0)
	{
		return Conversions.ToString(object_0);
	}

	static void smethod_91(TextBox textBox_0, string string_0)
	{
		textBox_0.set_Text(string_0);
	}

	static void smethod_92(DateTimePicker dateTimePicker_0, string string_0)
	{
		dateTimePicker_0.set_Text(string_0);
	}

	static void smethod_93(TextBoxBase textBoxBase_0)
	{
		textBoxBase_0.Clear();
	}

	static DateTime smethod_94()
	{
		return DateAndTime.get_Today();
	}
}
