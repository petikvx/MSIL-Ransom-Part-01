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
public class UpdateDetails : UserControl
{
	private IContainer components;

	private OleDbConnection myconnection;

	private int selectrow;

	private string mobile;

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
			EventHandler eventHandler_ = Button1_Click;
			Button searchBtn = default(Button);
			while (true)
			{
				int num = 106953010;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5A70D9E5u) % 8u)
					{
					case 7u:
					{
						searchBtn = _SearchBtn;
						int num5;
						int num6;
						if (searchBtn != null)
						{
							num5 = 1184648663;
							num6 = 1184648663;
						}
						else
						{
							num5 = 284479275;
							num6 = 284479275;
						}
						num = num5 ^ (int)(num2 * 1045936290);
						continue;
					}
					case 6u:
						searchBtn = _SearchBtn;
						num = (int)((num2 * 379950216) ^ 0x7BA0DADE);
						continue;
					case 5u:
						UpdateDetails.smethod_53((Control)(object)searchBtn, eventHandler_);
						num = ((int)num2 * -881899970) ^ 0x62A029BA;
						continue;
					case 4u:
						UpdateDetails.smethod_52((Control)(object)searchBtn, eventHandler_);
						num = (int)((num2 * 666459255) ^ 0x4A9058C1);
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (searchBtn == null)
						{
							num3 = 1873523145;
							num4 = 1873523145;
						}
						else
						{
							num3 = 130623357;
							num4 = 130623357;
						}
						num = num3 ^ (int)(num2 * 375630239);
						continue;
					}
					case 0u:
						_SearchBtn = value;
						num = 1942078595;
						continue;
					default:
						return;
					case 2u:
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
			DataGridViewCellMouseEventHandler dataGridViewCellMouseEventHandler_ = new DataGridViewCellMouseEventHandler(DataGridView1_CellMouseClick);
			DataGridView searchResultGrid = default(DataGridView);
			while (true)
			{
				int num = -533787154;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF225031Bu) % 7u)
					{
					case 5u:
						UpdateDetails.smethod_55(searchResultGrid, dataGridViewCellMouseEventHandler_);
						num = (int)(num2 * 1895399428) ^ -437658433;
						continue;
					case 3u:
						searchResultGrid = _SearchResultGrid;
						num = (int)((num2 * 1780350150) ^ 0x1AE9B7A2);
						continue;
					case 2u:
					{
						_SearchResultGrid = value;
						searchResultGrid = _SearchResultGrid;
						int num5;
						if (searchResultGrid == null)
						{
							num = -1720802909;
							num5 = -1720802909;
						}
						else
						{
							num = -1575994276;
							num5 = -1575994276;
						}
						continue;
					}
					case 1u:
						UpdateDetails.smethod_54(searchResultGrid, dataGridViewCellMouseEventHandler_);
						num = ((int)num2 * -354742567) ^ -67974467;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (searchResultGrid == null)
						{
							num3 = -1621391618;
							num4 = -1621391618;
						}
						else
						{
							num3 = -497386000;
							num4 = -497386000;
						}
						num = num3 ^ ((int)num2 * -2075741820);
						continue;
					}
					default:
						return;
					case 6u:
						break;
					case 4u:
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

	[field: AccessedThroughProperty("NameTxt")]
	internal virtual TextBox NameTxt
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
				int num = -1421585607;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD0B630ECu) % 7u)
					{
					case 6u:
						UpdateDetails.smethod_52((Control)(object)updateBtn, eventHandler_);
						num = ((int)num2 * -1354072633) ^ -1312450460;
						continue;
					case 5u:
					{
						updateBtn = _UpdateBtn;
						int num5;
						int num6;
						if (updateBtn == null)
						{
							num5 = -1016031719;
							num6 = -1016031719;
						}
						else
						{
							num5 = -1341246633;
							num6 = -1341246633;
						}
						num = num5 ^ ((int)num2 * -1041276078);
						continue;
					}
					case 4u:
						UpdateDetails.smethod_53((Control)(object)updateBtn, eventHandler_);
						num = ((int)num2 * -1373470366) ^ 0x7AB1C21B;
						continue;
					case 3u:
					{
						updateBtn = _UpdateBtn;
						int num3;
						int num4;
						if (updateBtn == null)
						{
							num3 = 1202579417;
							num4 = 1202579417;
						}
						else
						{
							num3 = 1007686323;
							num4 = 1007686323;
						}
						num = num3 ^ (int)(num2 * 1935021886);
						continue;
					}
					case 1u:
						_UpdateBtn = value;
						num = -794095030;
						continue;
					default:
						return;
					case 0u:
						break;
					case 2u:
						return;
					}
					break;
				}
			}
		}
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
			Button clearBtn = _ClearBtn;
			if (clearBtn != null)
			{
				goto IL_006c;
			}
			goto IL_009a;
			IL_009a:
			_ClearBtn = value;
			clearBtn = _ClearBtn;
			int num = 29353496;
			goto IL_0071;
			IL_0071:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7AB95638u) % 6u)
				{
				case 4u:
				{
					int num3;
					int num4;
					if (clearBtn != null)
					{
						num3 = 1237908500;
						num4 = 1237908500;
					}
					else
					{
						num3 = 786193941;
						num4 = 786193941;
					}
					num = num3 ^ (int)(num2 * 1918302821);
					continue;
				}
				case 3u:
					UpdateDetails.smethod_52((Control)(object)clearBtn, eventHandler_);
					num = ((int)num2 * -429279353) ^ -914037060;
					continue;
				case 2u:
					UpdateDetails.smethod_53((Control)(object)clearBtn, eventHandler_);
					num = (int)((num2 * 645353356) ^ 0x37C76A25);
					continue;
				case 0u:
					break;
				default:
					return;
				case 1u:
					goto IL_009a;
				case 5u:
					return;
				}
				break;
			}
			goto IL_006c;
			IL_006c:
			num = 64414245;
			goto IL_0071;
		}
	}

	public UpdateDetails()
	{
		while (true)
		{
			int num = 741717972;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5CE4D3D7u) % 5u)
				{
				case 4u:
					UpdateDetails.smethod_0((UserControl)(object)this, (EventHandler)UpdateDetails_Load);
					num = ((int)num2 * -1245900588) ^ 0xF28D185;
					continue;
				case 2u:
					myconnection = UpdateDetails.smethod_1();
					num = ((int)num2 * -1317667977) ^ -330643738;
					continue;
				case 1u:
					InitializeComponent();
					num = ((int)num2 * -1921412633) ^ 0x1F7FE92;
					continue;
				default:
					return;
				case 0u:
					break;
				case 3u:
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
			bool flag = default(bool);
			while (true)
			{
				int num = 197558691;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x50871F9Fu) % 7u)
					{
					case 6u:
						UpdateDetails.smethod_2((IDisposable)components);
						num = ((int)num2 * -653526099) ^ 0x223669D6;
						continue;
					case 3u:
						if (disposing)
						{
							num = (int)(num2 * 449944036) ^ -1901678154;
							continue;
						}
						num3 = 0;
						goto IL_0034;
					case 2u:
						num = (int)((num2 * 1271999112) ^ 0x2AD4D9C7);
						continue;
					case 1u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = 514139073;
							num5 = 514139073;
						}
						else
						{
							num4 = 106094895;
							num5 = 106094895;
						}
						num = num4 ^ ((int)num2 * -1160272210);
						continue;
					}
					case 0u:
						num3 = ((components != null) ? 1 : 0);
						goto IL_0034;
					default:
						return;
					case 5u:
						break;
					case 4u:
						return;
						IL_0034:
						flag = (byte)num3 != 0;
						num = 682296390;
						continue;
					}
					break;
				}
			}
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
			int num = 949318896;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x62ED8032u) % 259u)
				{
				case 258u:
					num = (int)((num2 * 505403838) ^ 0x2B89D2F5);
					continue;
				case 257u:
					UpdateDetails.smethod_14((Control)(object)ClearBtn, UpdateDetails.smethod_13("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1848345057) ^ -1870220747;
					continue;
				case 256u:
					UpdateDetails.smethod_15((Control)(object)Label3, new Point(37, 87));
					num = (int)((num2 * 1314487496) ^ 0x7FCCDA7E);
					continue;
				case 255u:
					UpdateDetails.smethod_18((Control)(object)Label1, 4);
					num = ((int)num2 * -811212857) ^ -643492141;
					continue;
				case 254u:
					UpdateDetails.smethod_28((ButtonBase)(object)SearchBtn, "Search");
					num = (int)(num2 * 151652988) ^ -10523693;
					continue;
				case 253u:
					UpdateDetails.smethod_17((Control)(object)Label2, new Size(77, 28));
					num = (int)(num2 * 1702867178) ^ -1734294110;
					continue;
				case 252u:
					UpdateDetails.smethod_24(GroupBox1, "Search Patient");
					UpdateDetails.smethod_25((ButtonBase)(object)SearchBtn, Color.MidnightBlue);
					num = (int)(num2 * 1977705136) ^ -1131726218;
					continue;
				case 251u:
					num = ((int)num2 * -983687935) ^ 0x385A01B2;
					continue;
				case 250u:
					num = ((int)num2 * -48552604) ^ 0x545D5375;
					continue;
				case 249u:
					UpdateDetails.smethod_22(UpdateDetails.smethod_44((Control)(object)this), (Control)(object)PictureBox1);
					num = (int)((num2 * 181851212) ^ 0xA0D56EA);
					continue;
				case 248u:
					num = (int)((num2 * 7793124) ^ 0x4D1B25E4);
					continue;
				case 247u:
					UpdateDetails.smethod_15((Control)(object)PictureBox1, new Point(260, 22));
					num = ((int)num2 * -1474711019) ^ 0x5A7D87F0;
					continue;
				case 246u:
					num = (int)(num2 * 1793138936) ^ -613606020;
					continue;
				case 245u:
					UpdateDetails.smethod_48((Control)(object)PatientInfoBox);
					num = (int)(num2 * 1748891816) ^ -564264600;
					continue;
				case 244u:
					UpdateDetails.smethod_17((Control)(object)ClearBtn, new Size(133, 37));
					UpdateDetails.smethod_18((Control)(object)ClearBtn, 10);
					num = ((int)num2 * -1143470961) ^ 0x50666999;
					continue;
				case 243u:
					num = ((int)num2 * -360799870) ^ -493654781;
					continue;
				case 242u:
					Label6 = UpdateDetails.smethod_3();
					num = ((int)num2 * -423943373) ^ -1926788111;
					continue;
				case 241u:
					UpdateDetails.smethod_14((Control)(object)UpdateBtn, UpdateDetails.smethod_13("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 768682732) ^ 0x9218825);
					continue;
				case 240u:
					UpdateDetails.smethod_17((Control)(object)DOBTxt, new Size(147, 28));
					UpdateDetails.smethod_18((Control)(object)DOBTxt, 5);
					num = (int)((num2 * 1853993052) ^ 0x13D0BE24);
					continue;
				case 239u:
					num = ((int)num2 * -46611240) ^ -1814758436;
					continue;
				case 238u:
					UpdateDetails.smethod_9((Control)(object)GroupBox1);
					UpdateDetails.smethod_10((ISupportInitialize)SearchResultGrid);
					num = (int)((num2 * 970870531) ^ 0x6B533301);
					continue;
				case 237u:
					num = ((int)num2 * -660515647) ^ 0x27CAFBDE;
					continue;
				case 236u:
					UpdateDetails.smethod_15((Control)(object)PIDTxt, new Point(124, 43));
					UpdateDetails.smethod_16((Control)(object)PIDTxt, "PIDTxt");
					num = (int)(num2 * 1687980232) ^ -1969354192;
					continue;
				case 235u:
					UpdateDetails.smethod_18((Control)(object)PIDTxt, 4);
					num = ((int)num2 * -1283458087) ^ 0x3583AE8F;
					continue;
				case 234u:
					num = ((int)num2 * -174771830) ^ 0x73644AC5;
					continue;
				case 233u:
					UpdateDetails.smethod_22(UpdateDetails.smethod_21((Control)(object)GroupBox1), (Control)(object)Label2);
					UpdateDetails.smethod_14((Control)(object)GroupBox1, UpdateDetails.smethod_13("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					UpdateDetails.smethod_15((Control)(object)GroupBox1, new Point(155, 150));
					num = (int)((num2 * 1534611048) ^ 0x4F5DF70C);
					continue;
				case 232u:
					UpdateDetails.smethod_17((Control)(object)Label1, new Size(250, 35));
					num = ((int)num2 * -786139316) ^ 0x3641ECBF;
					continue;
				case 231u:
					UpdateDetails.smethod_47((Control)(object)PatientInfoBox, bool_0: false);
					num = ((int)num2 * -1891080866) ^ 0x1AB8DDC;
					continue;
				case 230u:
					UpdateDetails.smethod_47((Control)(object)GroupBox1, bool_0: false);
					num = ((int)num2 * -471593326) ^ 0x15408BCB;
					continue;
				case 229u:
					num = (int)((num2 * 961614994) ^ 0x1D800CBB);
					continue;
				case 228u:
					num = (int)(num2 * 246324532) ^ -610430884;
					continue;
				case 226u:
					UpdateDetails.smethod_18((Control)(object)Label5, 1);
					num = ((int)num2 * -1393823659) ^ -1011749876;
					continue;
				case 225u:
					num = ((int)num2 * -1830350992) ^ -761857744;
					continue;
				case 224u:
					num = (int)((num2 * 1779149958) ^ 0x16FA0BD4);
					continue;
				case 223u:
					num = ((int)num2 * -1969753031) ^ 0x51F14A78;
					continue;
				case 222u:
					num = (int)(num2 * 1409042424) ^ -1793670868;
					continue;
				case 221u:
					GenderTxt = UpdateDetails.smethod_6();
					num = (int)((num2 * 1559565978) ^ 0x65CF6ACB);
					continue;
				case 220u:
					UpdateDetails.smethod_18((Control)(object)GroupBox1, 6);
					num = (int)(num2 * 1136474589) ^ -599212646;
					continue;
				case 219u:
					UpdateDetails.smethod_17((Control)(object)MobileSTxt, new Size(237, 28));
					num = ((int)num2 * -774846260) ^ -221916760;
					continue;
				case 218u:
					Label7 = UpdateDetails.smethod_3();
					num = (int)(num2 * 1314424502) ^ -1474435716;
					continue;
				case 217u:
					num = (int)((num2 * 34565887) ^ 0x40A28D82);
					continue;
				case 216u:
					num = (int)((num2 * 1950919281) ^ 0x49B44A4F);
					continue;
				case 215u:
					UpdateDetails.smethod_22(UpdateDetails.smethod_44((Control)(object)this), (Control)(object)SearchResultGrid);
					num = (int)((num2 * 1095469162) ^ 0x16D6F01F);
					continue;
				case 214u:
					UpdateDetails.smethod_46((Control)(object)this, new Size(977, 804));
					num = ((int)num2 * -1533950668) ^ -1777157878;
					continue;
				case 213u:
					num = ((int)num2 * -524821448) ^ 0x3697FA07;
					continue;
				case 212u:
					UpdateDetails.smethod_19(Label5, "DOB :");
					UpdateDetails.smethod_14((Control)(object)Label4, UpdateDetails.smethod_13("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 199803419) ^ 0x2F9BE0CD);
					continue;
				case 211u:
					num = (int)(num2 * 2098854449) ^ -2020741830;
					continue;
				case 210u:
					UpdateDetails.smethod_14((Control)(object)Label5, UpdateDetails.smethod_13("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1820532155) ^ 0xB7E7130);
					continue;
				case 209u:
					UpdateDetails.smethod_15((Control)(object)SearchResultGrid, new Point(59, 295));
					num = (int)((num2 * 334264073) ^ 0x1122BD76);
					continue;
				case 208u:
					UpdateDetails.smethod_17((Control)(object)PIDTxt, new Size(100, 28));
					num = ((int)num2 * -1152325171) ^ 0x1F9DFA0C;
					continue;
				case 207u:
					num = ((int)num2 * -1225171198) ^ -855227983;
					continue;
				case 206u:
					UpdateDetails.smethod_15((Control)(object)Label9, new Point(20, 132));
					num = ((int)num2 * -1156970900) ^ -157684593;
					continue;
				case 205u:
					UpdateDetails.smethod_22(UpdateDetails.smethod_21((Control)(object)PatientInfoBox), (Control)(object)MobileTxt);
					num = ((int)num2 * -1817920492) ^ 0x33265532;
					continue;
				case 204u:
					UpdateDetails.smethod_18((Control)(object)AddressTxt, 7);
					num = (int)((num2 * 1557947952) ^ 0x66F6FDF);
					continue;
				case 203u:
					UpdateDetails.smethod_17((Control)(object)Label4, new Size(68, 25));
					num = ((int)num2 * -1616681887) ^ -782369516;
					continue;
				case 202u:
					UpdateDetails.smethod_32(SearchResultGrid, bool_0: true);
					num = (int)((num2 * 1294599182) ^ 0x3BDF1699);
					continue;
				case 201u:
					num = ((int)num2 * -1447594327) ^ 0x6461B64F;
					continue;
				case 200u:
					num = (int)(num2 * 1215839910) ^ -1138374652;
					continue;
				case 199u:
					UpdateDetails.smethod_45((Control)(object)this, "UpdateDetails");
					num = (int)((num2 * 2124499983) ^ 0x2D52E856);
					continue;
				case 198u:
					num = (int)(num2 * 465551556) ^ -1328534874;
					continue;
				case 197u:
					num = ((int)num2 * -120037693) ^ -896787980;
					continue;
				case 196u:
					UpdateDetails.smethod_17((Control)(object)PatientInfoBox, new Size(623, 292));
					num = ((int)num2 * -929214947) ^ -592367989;
					continue;
				case 195u:
					Label8 = UpdateDetails.smethod_3();
					num = ((int)num2 * -178214134) ^ 0x48EB99E;
					continue;
				case 194u:
					num = ((int)num2 * -2020227005) ^ 0x411BF4DA;
					continue;
				case 193u:
					UpdateDetails.smethod_51((Control)(object)this);
					num = ((int)num2 * -1102567413) ^ -1360235479;
					continue;
				case 192u:
					num = (int)(num2 * 644212891) ^ -57677785;
					continue;
				case 191u:
					num = (int)((num2 * 214011019) ^ 0xBFD0F00);
					continue;
				case 190u:
					UpdateDetails.smethod_30(SearchResultGrid, Color.White);
					UpdateDetails.smethod_31(SearchResultGrid, (DataGridViewColumnHeadersHeightSizeMode)2);
					num = ((int)num2 * -670362332) ^ -1673549195;
					continue;
				case 189u:
					UpdateDetails.smethod_19(Label4, "PID :");
					num = ((int)num2 * -14935457) ^ -1935690905;
					continue;
				case 188u:
					UpdateDetails.smethod_14((Control)(object)SearchBtn, UpdateDetails.smethod_13("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1622789012) ^ -1065954610;
					continue;
				case 187u:
					UpdateDetails.smethod_22(UpdateDetails.smethod_21((Control)(object)PatientInfoBox), (Control)(object)Label9);
					num = (int)((num2 * 1877357467) ^ 0xA10343E);
					continue;
				case 186u:
					UpdateDetails.smethod_15((Control)(object)SearchBtn, new Point(468, 82));
					num = (int)((num2 * 452998604) ^ 0x3A66E0FC);
					continue;
				case 185u:
					UpdateDetails.smethod_22(UpdateDetails.smethod_21((Control)(object)PatientInfoBox), (Control)(object)GenderTxt);
					num = (int)((num2 * 1895211688) ^ 0x78342B38);
					continue;
				case 184u:
					Label1 = UpdateDetails.smethod_3();
					num = (int)(num2 * 1875060134) ^ -580902319;
					continue;
				case 183u:
					UpdateDetails.smethod_50((Control)(object)this, bool_0: false);
					num = (int)((num2 * 1730603642) ^ 0x2B9FFDD5);
					continue;
				case 182u:
					UpdateDetails.smethod_20(Label2, (ContentAlignment)32);
					num = ((int)num2 * -1743957750) ^ -1340577647;
					continue;
				case 181u:
					UpdateDetails.smethod_29((ButtonBase)(object)UpdateBtn, bool_0: false);
					num = (int)((num2 * 1831931567) ^ 0x307135F3);
					continue;
				case 180u:
					num = (int)(num2 * 202997502) ^ -1681339034;
					continue;
				case 179u:
					UpdateDetails.smethod_18((Control)(object)MobileSTxt, 2);
					num = (int)((num2 * 43362099) ^ 0x754B4710);
					continue;
				case 178u:
					UpdateDetails.smethod_18((Control)(object)GenderTxt, 6);
					num = (int)((num2 * 1021569867) ^ 0x5FA4F65A);
					continue;
				case 177u:
					UpdateDetails.smethod_22(UpdateDetails.smethod_21((Control)(object)PatientInfoBox), (Control)(object)NameTxt);
					num = ((int)num2 * -1945205181) ^ -1178935599;
					continue;
				case 176u:
					UpdateDetails.smethod_17((Control)(object)Label7, new Size(98, 26));
					num = (int)(num2 * 333233643) ^ -1139262968;
					continue;
				case 175u:
					UpdateDetails.smethod_17((Control)(object)PictureBox1, new Size(126, 122));
					num = ((int)num2 * -918720822) ^ -777539308;
					continue;
				case 174u:
					UpdateDetails.smethod_9((Control)(object)PatientInfoBox);
					UpdateDetails.smethod_10((ISupportInitialize)PictureBox1);
					num = (int)(num2 * 1960974749) ^ -631826826;
					continue;
				case 173u:
					UpdateDetails.smethod_15((Control)(object)GenderTxt, new Point(473, 125));
					num = ((int)num2 * -1606970714) ^ -1036634819;
					continue;
				case 172u:
					UpdateDetails.smethod_22(UpdateDetails.smethod_21((Control)(object)GroupBox1), (Control)(object)SearchBtn);
					num = (int)((num2 * 63856217) ^ 0x1B4FFFB4);
					continue;
				case 171u:
					num = ((int)num2 * -1302337957) ^ 0x5DF1F514;
					continue;
				case 170u:
					num = ((int)num2 * -581291295) ^ -1646581176;
					continue;
				case 169u:
					num = ((int)num2 * -1375892664) ^ 0x2D022AD8;
					continue;
				case 168u:
					UpdateDetails.smethod_16((Control)(object)AddressTxt, "AddressTxt");
					num = ((int)num2 * -464413186) ^ 0x1340F88;
					continue;
				case 167u:
					num = ((int)num2 * -58884861) ^ -451700443;
					continue;
				case 166u:
					UpdateDetails.smethod_16((Control)(object)MobileSTxt, "MobileSTxt");
					num = (int)(num2 * 1294908280) ^ -1044830044;
					continue;
				case 165u:
					UpdateDetails.smethod_16((Control)(object)GroupBox1, "GroupBox1");
					num = (int)(num2 * 1986001072) ^ -1527561689;
					continue;
				case 164u:
					num = ((int)num2 * -194051165) ^ -2114569946;
					continue;
				case 163u:
					UpdateDetails.smethod_14((Control)(object)Label1, UpdateDetails.smethod_13("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 422112183) ^ -811997218;
					continue;
				case 162u:
					UpdateDetails.smethod_22(UpdateDetails.smethod_44((Control)(object)this), (Control)(object)PatientInfoBox);
					num = ((int)num2 * -1853288013) ^ -728524724;
					continue;
				case 161u:
					UpdateDetails.smethod_18((Control)(object)Label6, 2);
					num = (int)((num2 * 2117555165) ^ 0x7DE52A37);
					continue;
				case 160u:
					UpdateDetails.smethod_15((Control)(object)Label2, new Point(37, 44));
					num = ((int)num2 * -95353899) ^ 0x39490084;
					continue;
				case 159u:
					num = (int)((num2 * 1073179662) ^ 0x7624455E);
					continue;
				case 158u:
					UpdateDetails.smethod_16((Control)(object)SearchResultGrid, "SearchResultGrid");
					num = ((int)num2 * -16419735) ^ -883458094;
					continue;
				case 157u:
					UpdateDetails.smethod_15((Control)(object)MobileSTxt, new Point(120, 94));
					num = ((int)num2 * -1444197793) ^ 0x6E4BC695;
					continue;
				case 156u:
					UpdateDetails.smethod_15((Control)(object)Label4, new Point(20, 46));
					UpdateDetails.smethod_16((Control)(object)Label4, "Label4");
					num = (int)(num2 * 1970642481) ^ -1250375357;
					continue;
				case 155u:
					UpdateDetails.smethod_18((Control)(object)PatientInfoBox, 8);
					num = ((int)num2 * -99795804) ^ -693755236;
					continue;
				case 154u:
					UpdateDetails.smethod_16((Control)(object)GenderTxt, "GenderTxt");
					num = (int)((num2 * 1247248849) ^ 0x4A6CCA27);
					continue;
				case 153u:
					UpdateDetails.smethod_22(UpdateDetails.smethod_21((Control)(object)PatientInfoBox), (Control)(object)Label8);
					num = ((int)num2 * -1631848454) ^ -762601273;
					continue;
				case 152u:
					num = ((int)num2 * -2036918894) ^ 0x7A7EE69E;
					continue;
				case 151u:
					UpdateDetails.smethod_19(Label7, "Address : ");
					num = ((int)num2 * -893436154) ^ 0x6DF8E1D6;
					continue;
				case 150u:
					UpdateDetails.smethod_18((Control)(object)Label4, 0);
					num = (int)(num2 * 634342320) ^ -483791704;
					continue;
				case 149u:
					UpdateDetails.smethod_20(Label3, (ContentAlignment)32);
					num = (int)(num2 * 1320842254) ^ -303207983;
					continue;
				case 148u:
					UpdateDetails.smethod_16((Control)(object)MobileTxt, "MobileTxt");
					num = ((int)num2 * -706122320) ^ 0x4FD239B5;
					continue;
				case 147u:
					UpdateDetails.smethod_17((Control)(object)Label9, new Size(77, 28));
					UpdateDetails.smethod_18((Control)(object)Label9, 11);
					UpdateDetails.smethod_19(Label9, "Phone : ");
					num = ((int)num2 * -400440374) ^ 0x46C040C7;
					continue;
				case 146u:
					UpdateDetails.smethod_22(UpdateDetails.smethod_44((Control)(object)this), (Control)(object)GroupBox1);
					num = ((int)num2 * -1045686715) ^ -1087530789;
					continue;
				case 145u:
					UpdateDetails.smethod_22(UpdateDetails.smethod_21((Control)(object)PatientInfoBox), (Control)(object)Label7);
					num = (int)((num2 * 1836002458) ^ 0x288DB473);
					continue;
				case 144u:
					UpdateDetails.smethod_16((Control)(object)Label6, "Label6");
					UpdateDetails.smethod_17((Control)(object)Label6, new Size(84, 26));
					num = (int)(num2 * 18347278) ^ -1137495812;
					continue;
				case 143u:
					Label3 = UpdateDetails.smethod_3();
					MobileSTxt = UpdateDetails.smethod_6();
					num = ((int)num2 * -1153988379) ^ -2078293914;
					continue;
				case 142u:
					UpdateDetails.smethod_28((ButtonBase)(object)ClearBtn, "Clear");
					num = (int)(num2 * 2053956578) ^ -70575950;
					continue;
				case 141u:
					UpdateDetails.smethod_15((Control)(object)Label1, new Point(392, 63));
					UpdateDetails.smethod_16((Control)(object)Label1, "Label1");
					num = ((int)num2 * -77191845) ^ -1086282079;
					continue;
				case 140u:
					UpdateDetails.smethod_22(UpdateDetails.smethod_21((Control)(object)PatientInfoBox), (Control)(object)DOBTxt);
					num = (int)((num2 * 1224893321) ^ 0x4AFD1873);
					continue;
				case 139u:
					UpdateDetails.smethod_16((Control)(object)DOBTxt, "DOBTxt");
					num = (int)((num2 * 178688567) ^ 0x14EF8D7E);
					continue;
				case 138u:
					UpdateDetails.smethod_15((Control)(object)Label5, new Point(383, 93));
					num = (int)(num2 * 1828565379) ^ -2104083225;
					continue;
				case 137u:
					UpdateDetails.smethod_14((Control)(object)Label3, UpdateDetails.smethod_13("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 685223869) ^ -1167549319;
					continue;
				case 136u:
					UpdateDetails.smethod_16((Control)(object)ClearBtn, "ClearBtn");
					num = ((int)num2 * -1704175342) ^ 0x69FBDD56;
					continue;
				case 135u:
					num = (int)((num2 * 1009894717) ^ 0x20D7B148);
					continue;
				case 134u:
					UpdateDetails.smethod_34(UpdateDetails.smethod_33(SearchResultGrid), 24);
					num = (int)(num2 * 1967849964) ^ -925048595;
					continue;
				case 133u:
					num = (int)(num2 * 1581935112) ^ -1170768692;
					continue;
				case 132u:
					SearchResultGrid = UpdateDetails.smethod_7();
					PatientInfoBox = UpdateDetails.smethod_4();
					MobileTxt = UpdateDetails.smethod_6();
					num = (int)(num2 * 511194121) ^ -63376568;
					continue;
				case 131u:
					UpdateDetails.smethod_22(UpdateDetails.smethod_21((Control)(object)PatientInfoBox), (Control)(object)Label5);
					num = ((int)num2 * -445049820) ^ 0x157A1D5B;
					continue;
				case 130u:
					UpdateDetails.smethod_22(UpdateDetails.smethod_21((Control)(object)GroupBox1), (Control)(object)MobileSTxt);
					num = ((int)num2 * -1075104881) ^ 0x6EE1190C;
					continue;
				case 129u:
					UpdateDetails.smethod_18((Control)(object)NameTxt, 10);
					UpdateDetails.smethod_14((Control)(object)Label8, UpdateDetails.smethod_13("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					UpdateDetails.smethod_15((Control)(object)Label8, new Point(20, 88));
					UpdateDetails.smethod_16((Control)(object)Label8, "Label8");
					num = ((int)num2 * -1424375992) ^ 0x4B39D93D;
					continue;
				case 128u:
					num = (int)((num2 * 1215350673) ^ 0x52F8B8F8);
					continue;
				case 127u:
					UpdateDetails.smethod_17((Control)(object)SearchResultGrid, new Size(853, 169));
					num = ((int)num2 * -640322928) ^ 0x3A582A7B;
					continue;
				case 126u:
					UpdateDetails.smethod_14((Control)(object)Label7, UpdateDetails.smethod_13("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1996565965) ^ -808873535;
					continue;
				case 125u:
					UpdateDetails.smethod_22(UpdateDetails.smethod_44((Control)(object)this), (Control)(object)UpdateBtn);
					num = (int)(num2 * 436452103) ^ -1224639093;
					continue;
				case 124u:
					num = (int)((num2 * 4782952) ^ 0x2BB96D20);
					continue;
				case 123u:
					UpdateDetails.smethod_40(PictureBox1, bool_0: false);
					num = (int)((num2 * 1631328337) ^ 0x1D385A59);
					continue;
				case 122u:
					num = (int)((num2 * 300707902) ^ 0x419E1BA7);
					continue;
				case 121u:
					num = (int)((num2 * 1832707004) ^ 0x705CBD42);
					continue;
				case 120u:
					UpdateDetails.smethod_17((Control)(object)NameSTxt, new Size(237, 28));
					num = (int)(num2 * 672801326) ^ -628280585;
					continue;
				case 119u:
					SearchBtn = UpdateDetails.smethod_5();
					num = ((int)num2 * -1427975856) ^ 0x79BB5900;
					continue;
				case 118u:
					num = ((int)num2 * -259471721) ^ 0x16E686DC;
					continue;
				case 117u:
					UpdateDetails.smethod_16((Control)(object)Label9, "Label9");
					num = (int)((num2 * 775745414) ^ 0x62686236);
					continue;
				case 116u:
					UpdateDetails.smethod_22(UpdateDetails.smethod_21((Control)(object)PatientInfoBox), (Control)(object)AddressTxt);
					num = ((int)num2 * -1805051524) ^ 0x15DDAD25;
					continue;
				case 115u:
					UpdateDetails.smethod_17((Control)(object)Label8, new Size(77, 28));
					UpdateDetails.smethod_18((Control)(object)Label8, 9);
					num = (int)(num2 * 1916549875) ^ -1334004356;
					continue;
				case 114u:
					UpdateDetails.smethod_19(Label6, "Gender : ");
					num = (int)((num2 * 453257457) ^ 0x226FDF5D);
					continue;
				case 113u:
					UpdateDetails.smethod_23(PatientInfoBox, bool_0: false);
					UpdateDetails.smethod_24(PatientInfoBox, "Patient Information");
					UpdateDetails.smethod_15((Control)(object)MobileTxt, new Point(124, 132));
					num = (int)((num2 * 1871386991) ^ 0x242E0C78);
					continue;
				case 112u:
					UpdateDetails.smethod_20(Label8, (ContentAlignment)32);
					num = (int)((num2 * 161029443) ^ 0x3E644B8F);
					continue;
				case 111u:
					UpdateDetails.smethod_18((Control)(object)NameSTxt, 1);
					num = ((int)num2 * -2008217683) ^ 0x6DA340F;
					continue;
				case 110u:
					num = (int)(num2 * 757855027) ^ -1863036825;
					continue;
				case 109u:
					UpdateDetails.smethod_20(Label9, (ContentAlignment)32);
					num = (int)((num2 * 1799935596) ^ 0x21C59F75);
					continue;
				case 108u:
					PictureBox1 = UpdateDetails.smethod_8();
					num = (int)(num2 * 333958946) ^ -1256448555;
					continue;
				case 107u:
					UpdateDetails.smethod_19(Label1, "Update Details ");
					UpdateDetails.smethod_20(Label1, (ContentAlignment)32);
					num = ((int)num2 * -1067586534) ^ 0x1DA08171;
					continue;
				case 106u:
					UpdateDetails.smethod_16((Control)(object)Label3, "Label3");
					num = (int)((num2 * 62501512) ^ 0x5BDC2B9);
					continue;
				case 105u:
					num = (int)(num2 * 1093089217) ^ -167599144;
					continue;
				case 104u:
					UpdateDetails.smethod_27((Control)(object)SearchBtn, UpdateDetails.smethod_26());
					num = ((int)num2 * -525562533) ^ -895223004;
					continue;
				case 103u:
					UpdateDetails.smethod_49((ISupportInitialize)PictureBox1);
					num = ((int)num2 * -487207420) ^ -1129314900;
					continue;
				case 102u:
					num = ((int)num2 * -1028444128) ^ -1813023161;
					continue;
				case 101u:
					UpdateDetails.smethod_14((Control)(object)Label2, UpdateDetails.smethod_13("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -685674416) ^ 0x65C17ADA;
					continue;
				case 100u:
					num = (int)((num2 * 1156783694) ^ 0x593C0526);
					continue;
				case 99u:
					UpdateDetails.smethod_49((ISupportInitialize)SearchResultGrid);
					num = (int)((num2 * 248203983) ^ 0x5904CC9D);
					continue;
				case 98u:
					num = ((int)num2 * -59758928) ^ -1299522493;
					continue;
				case 97u:
					UpdateDetails.smethod_18((Control)(object)Label3, 3);
					UpdateDetails.smethod_19(Label3, "Phone : ");
					num = ((int)num2 * -1236680733) ^ -1638891566;
					continue;
				case 96u:
					GroupBox1 = UpdateDetails.smethod_4();
					num = ((int)num2 * -1650216064) ^ -721086096;
					continue;
				case 95u:
					Label9 = UpdateDetails.smethod_3();
					NameTxt = UpdateDetails.smethod_6();
					num = ((int)num2 * -142698488) ^ -260562266;
					continue;
				case 94u:
					UpdateDetails.smethod_22(UpdateDetails.smethod_44((Control)(object)this), (Control)(object)ClearBtn);
					num = ((int)num2 * -1303541269) ^ 0xFF1F9D;
					continue;
				case 93u:
					UpdateDetails.smethod_37(PictureBox1, (Image)(object)Resources.useless_pic);
					num = (int)((num2 * 724323154) ^ 0x78E760DE);
					continue;
				case 92u:
					num = ((int)num2 * -1178819497) ^ 0x57DFF159;
					continue;
				case 91u:
					UpdateDetails.smethod_22(UpdateDetails.smethod_44((Control)(object)this), (Control)(object)Label1);
					num = (int)((num2 * 2095498986) ^ 0x555486B4);
					continue;
				case 90u:
					UpdateDetails.smethod_29((ButtonBase)(object)ClearBtn, bool_0: false);
					num = (int)((num2 * 1013666699) ^ 0xDFF4132);
					continue;
				case 89u:
					UpdateDetails.smethod_16((Control)(object)Label7, "Label7");
					num = (int)((num2 * 519763238) ^ 0x50CE87A7);
					continue;
				case 88u:
					num = (int)(num2 * 926979684) ^ -470954279;
					continue;
				case 87u:
					num = (int)((num2 * 2062101810) ^ 0x1F8E0831);
					continue;
				case 86u:
					UpdateDetails.smethod_22(UpdateDetails.smethod_21((Control)(object)GroupBox1), (Control)(object)NameSTxt);
					num = (int)(num2 * 2025743477) ^ -1511058073;
					continue;
				case 85u:
					UpdateDetails.smethod_18((Control)(object)Label7, 3);
					num = ((int)num2 * -2141672123) ^ -608075220;
					continue;
				case 84u:
					UpdateBtn = UpdateDetails.smethod_5();
					num = (int)((num2 * 471123919) ^ 0x4739FF09);
					continue;
				case 83u:
					UpdateDetails.smethod_15((Control)(object)AddressTxt, new Point(124, 182));
					UpdateDetails.smethod_36(AddressTxt, bool_0: true);
					num = ((int)num2 * -459963333) ^ -751694969;
					continue;
				case 82u:
					num = (int)(num2 * 1090867252) ^ -1585626256;
					continue;
				case 81u:
					num = (int)((num2 * 405718780) ^ 0x7732A281);
					continue;
				case 80u:
					UpdateDetails.smethod_42((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 1970802572) ^ -446139262;
					continue;
				case 79u:
					UpdateDetails.smethod_16((Control)(object)PatientInfoBox, "PatientInfoBox");
					num = ((int)num2 * -1204726164) ^ -1770396782;
					continue;
				case 78u:
					UpdateDetails.smethod_15((Control)(object)PatientInfoBox, new Point(108, 480));
					num = ((int)num2 * -1208161977) ^ 0x132F70E6;
					continue;
				case 77u:
					UpdateDetails.smethod_14((Control)(object)Label6, UpdateDetails.smethod_13("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 428560437) ^ -1163315564;
					continue;
				case 76u:
					UpdateDetails.smethod_19(Label8, "Name : ");
					num = (int)((num2 * 1790561514) ^ 0x710DCFD);
					continue;
				case 75u:
					Label5 = UpdateDetails.smethod_3();
					Label4 = UpdateDetails.smethod_3();
					num = (int)((num2 * 1400127139) ^ 0x1438B86E);
					continue;
				case 74u:
					num = (int)(num2 * 869820809) ^ -196618672;
					continue;
				case 73u:
					num = (int)(num2 * 1639279212) ^ -181364885;
					continue;
				case 72u:
					num = ((int)num2 * -686385195) ^ -1533386276;
					continue;
				case 71u:
					UpdateDetails.smethod_14((Control)(object)Label9, UpdateDetails.smethod_13("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1374823023) ^ 0x503CB76;
					continue;
				case 70u:
					num = (int)(num2 * 1167169216) ^ -2030391503;
					continue;
				case 69u:
					num = (int)(num2 * 1203669977) ^ -89070267;
					continue;
				case 68u:
					UpdateDetails.smethod_16((Control)(object)Label2, "Label2");
					num = (int)((num2 * 1465007340) ^ 0x677BCB70);
					continue;
				case 67u:
					UpdateDetails.smethod_17((Control)(object)GroupBox1, new Size(623, 128));
					num = ((int)num2 * -1578676055) ^ 0x31E13A04;
					continue;
				case 66u:
					UpdateDetails.smethod_16((Control)(object)Label5, "Label5");
					num = (int)(num2 * 2060677742) ^ -725183207;
					continue;
				case 65u:
					UpdateDetails.smethod_35((TextBoxBase)(object)NameTxt, bool_0: true);
					UpdateDetails.smethod_17((Control)(object)NameTxt, new Size(244, 28));
					num = ((int)num2 * -203078075) ^ 0x74A8A202;
					continue;
				case 64u:
					UpdateDetails.smethod_17((Control)(object)Label3, new Size(77, 28));
					num = ((int)num2 * -1425370123) ^ -931108079;
					continue;
				case 63u:
					UpdateDetails.smethod_27((Control)(object)UpdateBtn, UpdateDetails.smethod_26());
					UpdateDetails.smethod_15((Control)(object)UpdateBtn, new Point(779, 563));
					num = (int)(num2 * 1360907932) ^ -745358912;
					continue;
				case 62u:
					num = (int)((num2 * 615670756) ^ 0x1CC1E61F);
					continue;
				case 61u:
					UpdateDetails.smethod_17((Control)(object)GenderTxt, new Size(131, 28));
					num = ((int)num2 * -430441254) ^ -626621136;
					continue;
				case 60u:
					UpdateDetails.smethod_16((Control)(object)NameTxt, "NameTxt");
					num = (int)(num2 * 740832899) ^ -1619531587;
					continue;
				case 59u:
					UpdateDetails.smethod_18((Control)(object)UpdateBtn, 9);
					UpdateDetails.smethod_28((ButtonBase)(object)UpdateBtn, "Update ");
					num = ((int)num2 * -419800803) ^ 0x29DCCEAC;
					continue;
				case 58u:
					num = ((int)num2 * -181552399) ^ -1198947389;
					continue;
				case 57u:
					num = ((int)num2 * -658955661) ^ -1589503569;
					continue;
				case 56u:
					UpdateDetails.smethod_15((Control)(object)Label7, new Point(20, 182));
					num = ((int)num2 * -1703553909) ^ 0x681C4D59;
					continue;
				case 55u:
					num = (int)(num2 * 547375089) ^ -1797251745;
					continue;
				case 54u:
					UpdateDetails.smethod_15((Control)(object)NameSTxt, new Point(120, 44));
					num = (int)(num2 * 2093685016) ^ -266798078;
					continue;
				case 53u:
					num = ((int)num2 * -488406558) ^ -353569104;
					continue;
				case 52u:
					UpdateDetails.smethod_16((Control)(object)SearchBtn, "SearchBtn");
					UpdateDetails.smethod_17((Control)(object)SearchBtn, new Size(133, 37));
					UpdateDetails.smethod_18((Control)(object)SearchBtn, 4);
					num = ((int)num2 * -2004661005) ^ 0x4B911563;
					continue;
				case 51u:
					UpdateDetails.smethod_35((TextBoxBase)(object)GenderTxt, bool_0: true);
					num = (int)(num2 * 872274689) ^ -2105700785;
					continue;
				case 50u:
					num = ((int)num2 * -963194428) ^ 0x3950476E;
					continue;
				case 49u:
					UpdateDetails.smethod_18((Control)(object)Label2, 0);
					UpdateDetails.smethod_19(Label2, "Name : ");
					num = ((int)num2 * -676783720) ^ -679208906;
					continue;
				case 48u:
					ClearBtn = UpdateDetails.smethod_5();
					num = (int)((num2 * 399418412) ^ 0x604AA734);
					continue;
				case 47u:
					num = ((int)num2 * -1437462129) ^ 0x601649F8;
					continue;
				case 46u:
					num = ((int)num2 * -1705537462) ^ -1055654144;
					continue;
				case 45u:
					num = (int)(num2 * 852014205) ^ -1582216279;
					continue;
				case 44u:
					UpdateDetails.smethod_16((Control)(object)UpdateBtn, "UpdateBtn");
					UpdateDetails.smethod_17((Control)(object)UpdateBtn, new Size(133, 37));
					num = (int)(num2 * 1965362924) ^ -852967560;
					continue;
				case 43u:
					num = (int)((num2 * 775857930) ^ 0xB4468BE);
					continue;
				case 42u:
					UpdateDetails.smethod_15((Control)(object)Label6, new Point(383, 132));
					num = (int)((num2 * 183408572) ^ 0x3C93FC9A);
					continue;
				case 41u:
					UpdateDetails.smethod_41((ContainerControl)(object)this, new SizeF(8f, 16f));
					num = ((int)num2 * -1194957038) ^ -382633816;
					continue;
				case 40u:
					UpdateDetails.smethod_16((Control)(object)NameSTxt, "NameSTxt");
					num = (int)(num2 * 986409893) ^ -2126791611;
					continue;
				case 39u:
					UpdateDetails.smethod_23(GroupBox1, bool_0: false);
					num = (int)((num2 * 1723365765) ^ 0x67D801A3);
					continue;
				case 38u:
					UpdateDetails.smethod_15((Control)(object)DOBTxt, new Point(457, 88));
					num = (int)(num2 * 1665524982) ^ -1388926104;
					continue;
				case 37u:
					UpdateDetails.smethod_17((Control)(object)Label5, new Size(68, 26));
					num = (int)(num2 * 1505653920) ^ -265090243;
					continue;
				case 36u:
					Label2 = UpdateDetails.smethod_3();
					num = (int)((num2 * 1024411243) ^ 0x4D940FA);
					continue;
				case 35u:
					UpdateDetails.smethod_35((TextBoxBase)(object)DOBTxt, bool_0: true);
					num = ((int)num2 * -2090829555) ^ 0x56C84BE5;
					continue;
				case 34u:
					DOBTxt = UpdateDetails.smethod_6();
					num = ((int)num2 * -2019532996) ^ -2084026380;
					continue;
				case 33u:
					UpdateDetails.smethod_22(UpdateDetails.smethod_21((Control)(object)GroupBox1), (Control)(object)Label3);
					num = (int)((num2 * 1185912687) ^ 0x64158AB4);
					continue;
				case 32u:
					UpdateDetails.smethod_11((Control)(object)this);
					UpdateDetails.smethod_12(Label1, bool_0: true);
					num = (int)(num2 * 499328854) ^ -1944280773;
					continue;
				case 31u:
					UpdateDetails.smethod_22(UpdateDetails.smethod_21((Control)(object)PatientInfoBox), (Control)(object)Label4);
					UpdateDetails.smethod_14((Control)(object)PatientInfoBox, UpdateDetails.smethod_13("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 772163250) ^ -1496178043;
					continue;
				case 30u:
					num = (int)(num2 * 40980561) ^ -381597735;
					continue;
				case 29u:
					UpdateDetails.smethod_15((Control)(object)ClearBtn, new Point(779, 651));
					num = (int)((num2 * 468934828) ^ 0x2521352A);
					continue;
				case 28u:
					UpdateDetails.smethod_27((Control)(object)ClearBtn, UpdateDetails.smethod_26());
					num = (int)(num2 * 2122823154) ^ -2109656829;
					continue;
				case 27u:
					num = ((int)num2 * -185157011) ^ 0x494EF69A;
					continue;
				case 26u:
					UpdateDetails.smethod_25((ButtonBase)(object)UpdateBtn, Color.MidnightBlue);
					num = (int)((num2 * 312522256) ^ 0x372812E2);
					continue;
				case 25u:
					NameSTxt = UpdateDetails.smethod_6();
					num = ((int)num2 * -407573330) ^ 0x3BBA7C84;
					continue;
				case 24u:
					UpdateDetails.smethod_17((Control)(object)AddressTxt, new Size(480, 90));
					num = ((int)num2 * -53495032) ^ -1562320257;
					continue;
				case 23u:
					num = (int)(num2 * 410374001) ^ -1784275357;
					continue;
				case 22u:
					UpdateDetails.smethod_43((Control)(object)this, Color.White);
					num = (int)(num2 * 80107961) ^ -217018898;
					continue;
				case 21u:
					UpdateDetails.smethod_22(UpdateDetails.smethod_21((Control)(object)PatientInfoBox), (Control)(object)PIDTxt);
					num = ((int)num2 * -6711289) ^ -652229887;
					continue;
				case 20u:
					num = (int)((num2 * 1765390436) ^ 0x36D46E05);
					continue;
				case 18u:
					AddressTxt = UpdateDetails.smethod_6();
					num = ((int)num2 * -1233563179) ^ -1583039537;
					continue;
				case 17u:
					UpdateDetails.smethod_22(UpdateDetails.smethod_21((Control)(object)PatientInfoBox), (Control)(object)Label6);
					num = ((int)num2 * -1939671917) ^ -1371568739;
					continue;
				case 16u:
					UpdateDetails.smethod_17((Control)(object)MobileTxt, new Size(244, 28));
					num = ((int)num2 * -891895577) ^ 0x34738FAE;
					continue;
				case 15u:
					num = ((int)num2 * -1760149405) ^ 0x51AFAEC6;
					continue;
				case 14u:
					UpdateDetails.smethod_38(PictureBox1, (PictureBoxSizeMode)1);
					num = ((int)num2 * -1135103355) ^ -116433825;
					continue;
				case 13u:
					PIDTxt = UpdateDetails.smethod_6();
					num = (int)(num2 * 255113226) ^ -2135101858;
					continue;
				case 12u:
					UpdateDetails.smethod_39(PictureBox1, 3);
					num = (int)(num2 * 1366033800) ^ -1888878548;
					continue;
				case 11u:
					num = ((int)num2 * -1641635400) ^ 0x7B851B96;
					continue;
				case 10u:
					num = (int)((num2 * 1649992165) ^ 0x6636BCDC);
					continue;
				case 9u:
					UpdateDetails.smethod_16((Control)(object)PictureBox1, "PictureBox1");
					num = ((int)num2 * -1264293663) ^ -314358393;
					continue;
				case 8u:
					num = ((int)num2 * -900173537) ^ 0x40FD3312;
					continue;
				case 7u:
					UpdateDetails.smethod_15((Control)(object)NameTxt, new Point(124, 92));
					num = ((int)num2 * -375908862) ^ -32552375;
					continue;
				case 6u:
					num = (int)(num2 * 534524399) ^ -1689760601;
					continue;
				case 5u:
					UpdateDetails.smethod_18((Control)(object)MobileTxt, 12);
					num = ((int)num2 * -53144552) ^ -1542500135;
					continue;
				case 4u:
					UpdateDetails.smethod_29((ButtonBase)(object)SearchBtn, bool_0: false);
					num = (int)((num2 * 884435451) ^ 0x455E28C1);
					continue;
				case 3u:
					UpdateDetails.smethod_35((TextBoxBase)(object)PIDTxt, bool_0: true);
					num = ((int)num2 * -1534761071) ^ 0x1C001422;
					continue;
				case 2u:
					UpdateDetails.smethod_48((Control)(object)GroupBox1);
					num = (int)((num2 * 744132183) ^ 0x2CF86653);
					continue;
				case 1u:
					UpdateDetails.smethod_25((ButtonBase)(object)ClearBtn, Color.MidnightBlue);
					num = ((int)num2 * -1033753702) ^ 0x58C2693C;
					continue;
				case 0u:
					UpdateDetails.smethod_18((Control)(object)SearchResultGrid, 7);
					num = ((int)num2 * -157210561) ^ -114837219;
					continue;
				default:
					return;
				case 227u:
					break;
				case 19u:
					return;
				}
				break;
			}
		}
	}

	private void UpdateDetails_Load(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 283536912;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x462CBA34u) % 5u)
				{
				case 4u:
					num = ((int)num2 * -1511785752) ^ 0xF8851AB;
					continue;
				case 3u:
					Hidedata();
					num = ((int)num2 * -1441589998) ^ -2042973565;
					continue;
				case 1u:
					UpdateDetails.smethod_57(myconnection, UpdateDetails.smethod_56(MyProject.Forms.Form1.provider, MyProject.Forms.Form1.datafile));
					num = ((int)num2 * -115243099) ^ 0x34605F90;
					continue;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Expected I4, but got Unknown
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected I4, but got Unknown
		//IL_02fa: Incompatible stack heights: 0 vs 1
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Incompatible stack heights: 0 vs 1
		//IL_0335: Incompatible stack heights: 0 vs 1
		//IL_033c: Incompatible stack heights: 0 vs 1
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		bool flag2 = default(bool);
		OleDbDataAdapter dbDataAdapter_ = default(OleDbDataAdapter);
		bool flag = default(bool);
		while (true)
		{
			int num = -924853286;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC628E421u) % 6u)
				{
				case 5u:
					Hidedata();
					num = ((int)num2 * -1825651905) ^ 0x6BB608BE;
					continue;
				case 2u:
				{
					int num6;
					int num7;
					if (!flag2)
					{
						num6 = 238294668;
						num7 = 238294668;
					}
					else
					{
						num6 = 934993698;
						num7 = 934993698;
					}
					num = num6 ^ (int)(num2 * 2060732811);
					continue;
				}
				case 0u:
					flag2 = !MyProject.Forms.Form1.Name_Validation(UpdateDetails.smethod_59(UpdateDetails.smethod_58(NameSTxt))) | !MyProject.Forms.Form1.Mobile_Validator(UpdateDetails.smethod_59(UpdateDetails.smethod_58(MobileSTxt)));
					num = ((int)num2 * -1874545775) ^ -1606520577;
					continue;
				case 4u:
					break;
				default:
					try
					{
						DataTable dataTable_ = UpdateDetails.smethod_61();
						while (true)
						{
							int num3 = -727758304;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xC628E421u) % 13u)
								{
								case 12u:
									UpdateDetails.smethod_66((DbDataAdapter)(object)dbDataAdapter_, dataTable_);
									UpdateDetails.smethod_68(SearchResultGrid, (object)UpdateDetails.smethod_67(dataTable_));
									num3 = (int)(num2 * 1396214254) ^ -1729442262;
									continue;
								case 11u:
									UpdateDetails.smethod_70("Not Found.", "Result");
									num3 = (int)(num2 * 1866265991) ^ -64698300;
									continue;
								case 9u:
									UpdateDetails.smethod_63(myconnection);
									num3 = (int)(num2 * 14631672) ^ -295386046;
									continue;
								case 8u:
									UpdateDetails.smethod_71(myconnection);
									num3 = (int)(num2 * 323490001) ^ -214187392;
									continue;
								case 7u:
									dbDataAdapter_ = UpdateDetails.smethod_65(UpdateDetails.smethod_64(new string[5]
									{
										"Select * from Patient where Name like '%",
										UpdateDetails.smethod_58(NameSTxt),
										"%'  And   Mobile like '%",
										UpdateDetails.smethod_58(MobileSTxt),
										"%' "
									}), myconnection);
									num3 = ((int)num2 * -1296230683) ^ 0x65A3A1AA;
									continue;
								case 6u:
								{
									int num4;
									int num5;
									if (!flag)
									{
										num4 = 152421857;
										num5 = 152421857;
									}
									else
									{
										num4 = 792624169;
										num5 = 792624169;
									}
									num3 = num4 ^ ((int)num2 * -933564477);
									continue;
								}
								case 5u:
									flag = UpdateDetails.smethod_69(SearchResultGrid) == 1;
									num3 = (int)(num2 * 2142302743) ^ -1589281686;
									continue;
								case 4u:
									mobile = UpdateDetails.smethod_58(MobileSTxt);
									name_search = UpdateDetails.smethod_58(NameSTxt);
									num3 = ((int)num2 * -1051978692) ^ -1086388819;
									continue;
								case 2u:
									dbDataAdapter_ = UpdateDetails.smethod_62();
									num3 = ((int)num2 * -20518753) ^ 0x3F1C6C02;
									continue;
								case 0u:
									UpdateDetails.smethod_72((Control)(object)SearchResultGrid);
									UpdateDetails.smethod_71(myconnection);
									num3 = -1607016275;
									continue;
								default:
									return;
								case 3u:
									break;
								case 1u:
									return;
								case 10u:
									return;
								}
								break;
							}
						}
					}
					catch (Exception exception_)
					{
						UpdateDetails.smethod_73(exception_);
						while (true)
						{
							_ = -1538193556;
							while (true)
							{
								_003F val = /*Error near IL_02cc: Stack underflow*/^ -970398687;
								num2 = (uint)(int)val;
								switch (val % 5)
								{
								default:
									return;
								case 3:
									_ = (num2 * 694018884) ^ 0xC3A3720Au;
									continue;
								case 2:
									UpdateDetails.smethod_60("Incorrect Credentials");
									UpdateDetails.smethod_74();
									_ = (num2 * 2032674452) ^ 0x94201B42u;
									continue;
								case 1:
									UpdateDetails.smethod_71(myconnection);
									_ = ((int)num2 * -1664854904) ^ -1157887350;
									continue;
								case 0:
									break;
								case 4:
									return;
								}
								break;
							}
						}
					}
				case 3u:
					UpdateDetails.smethod_60("No Results Found");
					return;
				}
				break;
			}
		}
	}

	private void UpdateBtn_Click(object sender, EventArgs e)
	{
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected I4, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected I4, but got Unknown
		//IL_01fc: Incompatible stack heights: 0 vs 1
		//IL_0211: Incompatible stack heights: 0 vs 1
		//IL_0218: Incompatible stack heights: 0 vs 1
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		string string_ = UpdateDetails.smethod_64(new string[7]
		{
			"Update [Patient] set [Mobile]='",
			UpdateDetails.smethod_58(MobileTxt),
			"',[Address]='",
			UpdateDetails.smethod_58(AddressTxt),
			"'where [PID] = ",
			UpdateDetails.smethod_58(PIDTxt),
			" "
		});
		if (!(MyProject.Forms.Form1.Mobile_Validator(UpdateDetails.smethod_59(UpdateDetails.smethod_58(MobileTxt))) & (UpdateDetails.smethod_75(UpdateDetails.smethod_58(AddressTxt), "", bool_0: false) != 0)))
		{
			goto IL_00b1;
		}
		goto IL_00dc;
		IL_00dc:
		int num = 1620466484;
		goto IL_00b6;
		IL_00b6:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x59E49B78u) % 5u)
			{
			case 4u:
				UpdateDetails.smethod_63(myconnection);
				num = (int)((num2 * 388158847) ^ 0x6A3893C8);
				continue;
			case 0u:
				break;
			case 3u:
				goto IL_00dc;
			default:
			{
				OleDbCommand val = UpdateDetails.smethod_76(string_, myconnection);
				try
				{
					while (true)
					{
						int num3 = 341759233;
						while (true)
						{
							switch ((num2 = (uint)num3 ^ 0x59E49B78u) % 8u)
							{
							case 6u:
								updatedatagrid();
								num3 = (int)((num2 * 622954079) ^ 0x7874AE06);
								continue;
							case 5u:
								num3 = (int)((num2 * 846440912) ^ 0x8EBBC8);
								continue;
							case 4u:
								num3 = (int)((num2 * 27559499) ^ 0x59321696);
								continue;
							case 3u:
								num3 = (int)((num2 * 1506734094) ^ 0x65FA00CC);
								continue;
							case 2u:
								UpdateDetails.smethod_60("Updated Sucessfully");
								UpdateDetails.smethod_71(myconnection);
								num3 = (int)(num2 * 2141257650) ^ -443819511;
								continue;
							case 1u:
								UpdateDetails.smethod_77(val);
								UpdateDetails.smethod_78((Component)(object)val);
								num3 = ((int)num2 * -547720295) ^ 0x5FFFA1D2;
								continue;
							default:
								return;
							case 7u:
								break;
							case 0u:
								return;
							}
							break;
						}
					}
				}
				catch (Exception exception_)
				{
					UpdateDetails.smethod_73(exception_);
					UpdateDetails.smethod_71(myconnection);
					while (true)
					{
						_ = 1227387998;
						while (true)
						{
							_003F val2 = /*Error near IL_01d2: Stack underflow*/^ 0x59E49B78;
							num2 = (uint)(int)val2;
							switch (val2 % 4)
							{
							default:
								return;
							case 2:
								_ = (num2 * 295747769) ^ 0xBF4F98C7u;
								continue;
							case 1:
								UpdateDetails.smethod_74();
								_ = (num2 * 1722874408) ^ 0xFBD78CD3u;
								continue;
							case 0:
								break;
							case 3:
								return;
							}
							break;
						}
					}
				}
			}
			case 2u:
				UpdateDetails.smethod_60("Enter Valid Phone number");
				return;
			}
			break;
		}
		goto IL_00b1;
		IL_00b1:
		num = 2113272379;
		goto IL_00b6;
	}

	private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		if ((checked(UpdateDetails.smethod_79(e) + 1) == UpdateDetails.smethod_69(SearchResultGrid)) | (UpdateDetails.smethod_79(e) == -1))
		{
			goto IL_0021;
		}
		goto IL_0047;
		IL_0047:
		int num = -478739782;
		goto IL_0026;
		IL_0026:
		uint num2;
		switch ((num2 = (uint)num ^ 0xED3F31FDu) % 4u)
		{
		case 0u:
			break;
		case 2u:
			goto IL_0047;
		default:
			selectrow = UpdateDetails.smethod_79(e);
			try
			{
				DataGridViewRow dataGridViewRow_ = default(DataGridViewRow);
				while (true)
				{
					int num3 = -762109501;
					while (true)
					{
						switch ((num2 = (uint)num3 ^ 0xED3F31FDu) % 15u)
						{
						case 14u:
							UpdateDetails.smethod_88(AddressTxt, UpdateDetails.smethod_87(UpdateDetails.smethod_86(UpdateDetails.smethod_85(UpdateDetails.smethod_84(dataGridViewRow_), 5))));
							num3 = ((int)num2 * -833921527) ^ 0x41AF88FC;
							continue;
						case 13u:
							UpdateDetails.smethod_80((Control)(object)PatientInfoBox, bool_0: true);
							num3 = ((int)num2 * -1773049792) ^ -1502751357;
							continue;
						case 12u:
							num3 = ((int)num2 * -272985562) ^ -1528315086;
							continue;
						case 11u:
							UpdateDetails.smethod_88(MobileTxt, UpdateDetails.smethod_87(UpdateDetails.smethod_86(UpdateDetails.smethod_85(UpdateDetails.smethod_84(dataGridViewRow_), 4))));
							num3 = (int)((num2 * 1206207785) ^ 0x67C43472);
							continue;
						case 10u:
							num3 = (int)(num2 * 201520327) ^ -1046264398;
							continue;
						case 9u:
							num3 = (int)((num2 * 1630468296) ^ 0x1542B403);
							continue;
						case 7u:
							selectrow = UpdateDetails.smethod_79(e);
							num3 = ((int)num2 * -947022884) ^ 0x2903268;
							continue;
						case 6u:
							dataGridViewRow_ = UpdateDetails.smethod_81();
							dataGridViewRow_ = UpdateDetails.smethod_83(UpdateDetails.smethod_82(SearchResultGrid), selectrow);
							num3 = (int)((num2 * 1010179786) ^ 0x1D715149);
							continue;
						case 5u:
							UpdateDetails.smethod_88(DOBTxt, UpdateDetails.smethod_89(UpdateDetails.smethod_86(UpdateDetails.smethod_85(UpdateDetails.smethod_84(dataGridViewRow_), 2))));
							num3 = ((int)num2 * -385806380) ^ -1361103983;
							continue;
						case 4u:
							UpdateDetails.smethod_88(PIDTxt, UpdateDetails.smethod_87(UpdateDetails.smethod_86(UpdateDetails.smethod_85(UpdateDetails.smethod_84(dataGridViewRow_), 0))));
							UpdateDetails.smethod_88(NameTxt, UpdateDetails.smethod_87(UpdateDetails.smethod_86(UpdateDetails.smethod_85(UpdateDetails.smethod_84(dataGridViewRow_), 1))));
							num3 = ((int)num2 * -1525075508) ^ 0x672840DB;
							continue;
						case 3u:
							UpdateDetails.smethod_72((Control)(object)UpdateBtn);
							num3 = (int)((num2 * 723452361) ^ 0x5490E47);
							continue;
						case 2u:
							UpdateDetails.smethod_88(GenderTxt, UpdateDetails.smethod_87(UpdateDetails.smethod_86(UpdateDetails.smethod_85(UpdateDetails.smethod_84(dataGridViewRow_), 3))));
							num3 = (int)((num2 * 165178883) ^ 0x22DD2E5A);
							continue;
						case 0u:
							UpdateDetails.smethod_72((Control)(object)ClearBtn);
							num3 = (int)((num2 * 562153565) ^ 0x6DB2C64B);
							continue;
						default:
							return;
						case 8u:
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
				UpdateDetails.smethod_73(exception_);
				UpdateDetails.smethod_74();
				return;
			}
		case 1u:
			return;
		}
		goto IL_0021;
		IL_0021:
		num = -966442100;
		goto IL_0026;
	}

	private void Hidedata()
	{
		UpdateDetails.smethod_80((Control)(object)PatientInfoBox, bool_0: false);
		while (true)
		{
			int num = 911557227;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x693F98u) % 6u)
				{
				case 5u:
					UpdateDetails.smethod_90((Control)(object)SearchResultGrid);
					num = (int)(num2 * 1319737786) ^ -1326693712;
					continue;
				case 2u:
					num = ((int)num2 * -1442782627) ^ 0x733E87;
					continue;
				case 1u:
					UpdateDetails.smethod_90((Control)(object)ClearBtn);
					num = ((int)num2 * -1175263731) ^ 0x2CDE019;
					continue;
				case 0u:
					UpdateDetails.smethod_90((Control)(object)UpdateBtn);
					num = (int)((num2 * 941037649) ^ 0x532DC11A);
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

	private void updatedatagrid()
	{
		DataGridViewRow dataGridViewRow_ = default(DataGridViewRow);
		while (true)
		{
			int num = 1005117162;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2BC46DEBu) % 9u)
				{
				case 7u:
					num = (int)(num2 * 259438558) ^ -1321098216;
					continue;
				case 6u:
					dataGridViewRow_ = UpdateDetails.smethod_81();
					num = ((int)num2 * -1633223676) ^ -629283596;
					continue;
				case 5u:
					UpdateDetails.smethod_91(UpdateDetails.smethod_85(UpdateDetails.smethod_84(dataGridViewRow_), 2), (object)UpdateDetails.smethod_58(DOBTxt));
					num = (int)(num2 * 1428486202) ^ -94004145;
					continue;
				case 4u:
					UpdateDetails.smethod_91(UpdateDetails.smethod_85(UpdateDetails.smethod_84(dataGridViewRow_), 4), (object)UpdateDetails.smethod_58(MobileTxt));
					num = (int)(num2 * 1766269991) ^ -2133472095;
					continue;
				case 3u:
					dataGridViewRow_ = UpdateDetails.smethod_83(UpdateDetails.smethod_82(SearchResultGrid), selectrow);
					num = (int)((num2 * 1718694032) ^ 0x1831B26);
					continue;
				case 2u:
					num = (int)(num2 * 1408117856) ^ -892318785;
					continue;
				case 1u:
					UpdateDetails.smethod_91(UpdateDetails.smethod_85(UpdateDetails.smethod_84(dataGridViewRow_), 5), (object)UpdateDetails.smethod_58(AddressTxt));
					num = (int)(num2 * 1135223606) ^ -646980228;
					continue;
				default:
					return;
				case 8u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	private void ClearBtn_Click(object sender, EventArgs e)
	{
		UpdateDetails.smethod_92((TextBoxBase)(object)PIDTxt);
		UpdateDetails.smethod_92((TextBoxBase)(object)NameTxt);
		while (true)
		{
			int num = 771297471;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x42B2FD85u) % 9u)
				{
				case 7u:
					UpdateDetails.smethod_92((TextBoxBase)(object)MobileTxt);
					num = (int)(num2 * 1248548810) ^ -250396995;
					continue;
				case 6u:
					UpdateDetails.smethod_92((TextBoxBase)(object)GenderTxt);
					num = (int)((num2 * 1065157860) ^ 0x40137758);
					continue;
				case 5u:
					UpdateDetails.smethod_92((TextBoxBase)(object)AddressTxt);
					num = ((int)num2 * -943198118) ^ -869441849;
					continue;
				case 4u:
					UpdateDetails.smethod_92((TextBoxBase)(object)DOBTxt);
					num = ((int)num2 * -2133364061) ^ -801999330;
					continue;
				case 2u:
					num = ((int)num2 * -666857173) ^ -1234207118;
					continue;
				case 1u:
					num = (int)((num2 * 723310909) ^ 0x2E8CA8);
					continue;
				case 0u:
					num = (int)(num2 * 922251959) ^ -247771567;
					continue;
				default:
					return;
				case 3u:
					break;
				case 8u:
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

	static Label smethod_3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Label();
	}

	static GroupBox smethod_4()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new GroupBox();
	}

	static Button smethod_5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Button();
	}

	static TextBox smethod_6()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new TextBox();
	}

	static DataGridView smethod_7()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new DataGridView();
	}

	static PictureBox smethod_8()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new PictureBox();
	}

	static void smethod_9(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_10(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.BeginInit();
	}

	static void smethod_11(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_12(Label label_0, bool bool_0)
	{
		label_0.set_AutoSize(bool_0);
	}

	static Font smethod_13(string string_0, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_14(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static void smethod_15(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_16(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_17(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
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

	static void smethod_25(ButtonBase buttonBase_0, Color color_0)
	{
		buttonBase_0.set_BackColor(color_0);
	}

	static Color smethod_26()
	{
		return SystemColors.ButtonHighlight;
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

	static void smethod_30(DataGridView dataGridView_0, Color color_0)
	{
		dataGridView_0.set_BackgroundColor(color_0);
	}

	static void smethod_31(DataGridView dataGridView_0, DataGridViewColumnHeadersHeightSizeMode dataGridViewColumnHeadersHeightSizeMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		dataGridView_0.set_ColumnHeadersHeightSizeMode(dataGridViewColumnHeadersHeightSizeMode_0);
	}

	static void smethod_32(DataGridView dataGridView_0, bool bool_0)
	{
		dataGridView_0.set_ReadOnly(bool_0);
	}

	static DataGridViewRow smethod_33(DataGridView dataGridView_0)
	{
		return dataGridView_0.get_RowTemplate();
	}

	static void smethod_34(DataGridViewRow dataGridViewRow_0, int int_0)
	{
		dataGridViewRow_0.set_Height(int_0);
	}

	static void smethod_35(TextBoxBase textBoxBase_0, bool bool_0)
	{
		textBoxBase_0.set_ReadOnly(bool_0);
	}

	static void smethod_36(TextBox textBox_0, bool bool_0)
	{
		textBox_0.set_Multiline(bool_0);
	}

	static void smethod_37(PictureBox pictureBox_0, Image image_0)
	{
		pictureBox_0.set_Image(image_0);
	}

	static void smethod_38(PictureBox pictureBox_0, PictureBoxSizeMode pictureBoxSizeMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		pictureBox_0.set_SizeMode(pictureBoxSizeMode_0);
	}

	static void smethod_39(PictureBox pictureBox_0, int int_0)
	{
		pictureBox_0.set_TabIndex(int_0);
	}

	static void smethod_40(PictureBox pictureBox_0, bool bool_0)
	{
		pictureBox_0.set_TabStop(bool_0);
	}

	static void smethod_41(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_42(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_43(Control control_0, Color color_0)
	{
		control_0.set_BackColor(color_0);
	}

	static ControlCollection smethod_44(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_45(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_46(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_47(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_48(Control control_0)
	{
		control_0.PerformLayout();
	}

	static void smethod_49(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.EndInit();
	}

	static void smethod_50(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_51(Control control_0)
	{
		control_0.PerformLayout();
	}

	static void smethod_52(Control control_0, EventHandler eventHandler_0)
	{
		control_0.remove_Click(eventHandler_0);
	}

	static void smethod_53(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_Click(eventHandler_0);
	}

	static void smethod_54(DataGridView dataGridView_0, DataGridViewCellMouseEventHandler dataGridViewCellMouseEventHandler_0)
	{
		dataGridView_0.remove_CellMouseClick(dataGridViewCellMouseEventHandler_0);
	}

	static void smethod_55(DataGridView dataGridView_0, DataGridViewCellMouseEventHandler dataGridViewCellMouseEventHandler_0)
	{
		dataGridView_0.add_CellMouseClick(dataGridViewCellMouseEventHandler_0);
	}

	static string smethod_56(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static void smethod_57(OleDbConnection oleDbConnection_0, string string_0)
	{
		oleDbConnection_0.set_ConnectionString(string_0);
	}

	static string smethod_58(TextBox textBox_0)
	{
		return textBox_0.get_Text();
	}

	static string smethod_59(string string_0)
	{
		return string_0.ToLower();
	}

	static DialogResult smethod_60(string string_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0);
	}

	static DataTable smethod_61()
	{
		return new DataTable();
	}

	static OleDbDataAdapter smethod_62()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new OleDbDataAdapter();
	}

	static void smethod_63(OleDbConnection oleDbConnection_0)
	{
		oleDbConnection_0.Open();
	}

	static string smethod_64(string[] string_0)
	{
		return string.Concat(string_0);
	}

	static OleDbDataAdapter smethod_65(string string_0, OleDbConnection oleDbConnection_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new OleDbDataAdapter(string_0, oleDbConnection_0);
	}

	static int smethod_66(DbDataAdapter dbDataAdapter_0, DataTable dataTable_0)
	{
		return dbDataAdapter_0.Fill(dataTable_0);
	}

	static DataView smethod_67(DataTable dataTable_0)
	{
		return dataTable_0.DefaultView;
	}

	static void smethod_68(DataGridView dataGridView_0, object object_0)
	{
		dataGridView_0.set_DataSource(object_0);
	}

	static int smethod_69(DataGridView dataGridView_0)
	{
		return dataGridView_0.get_RowCount();
	}

	static DialogResult smethod_70(string string_0, string string_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0, string_1);
	}

	static void smethod_71(OleDbConnection oleDbConnection_0)
	{
		oleDbConnection_0.Close();
	}

	static void smethod_72(Control control_0)
	{
		control_0.Show();
	}

	static void smethod_73(Exception exception_0)
	{
		ProjectData.SetProjectError(exception_0);
	}

	static void smethod_74()
	{
		ProjectData.ClearProjectError();
	}

	static int smethod_75(string string_0, string string_1, bool bool_0)
	{
		return Operators.CompareString(string_0, string_1, bool_0);
	}

	static OleDbCommand smethod_76(string string_0, OleDbConnection oleDbConnection_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new OleDbCommand(string_0, oleDbConnection_0);
	}

	static int smethod_77(OleDbCommand oleDbCommand_0)
	{
		return oleDbCommand_0.ExecuteNonQuery();
	}

	static void smethod_78(Component component_0)
	{
		component_0.Dispose();
	}

	static int smethod_79(DataGridViewCellMouseEventArgs dataGridViewCellMouseEventArgs_0)
	{
		return dataGridViewCellMouseEventArgs_0.get_RowIndex();
	}

	static void smethod_80(Control control_0, bool bool_0)
	{
		control_0.set_Visible(bool_0);
	}

	static DataGridViewRow smethod_81()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new DataGridViewRow();
	}

	static DataGridViewRowCollection smethod_82(DataGridView dataGridView_0)
	{
		return dataGridView_0.get_Rows();
	}

	static DataGridViewRow smethod_83(DataGridViewRowCollection dataGridViewRowCollection_0, int int_0)
	{
		return dataGridViewRowCollection_0.get_Item(int_0);
	}

	static DataGridViewCellCollection smethod_84(DataGridViewRow dataGridViewRow_0)
	{
		return dataGridViewRow_0.get_Cells();
	}

	static DataGridViewCell smethod_85(DataGridViewCellCollection dataGridViewCellCollection_0, int int_0)
	{
		return dataGridViewCellCollection_0.get_Item(int_0);
	}

	static object smethod_86(DataGridViewCell dataGridViewCell_0)
	{
		return dataGridViewCell_0.get_Value();
	}

	static string smethod_87(object object_0)
	{
		return object_0.ToString();
	}

	static void smethod_88(TextBox textBox_0, string string_0)
	{
		textBox_0.set_Text(string_0);
	}

	static string smethod_89(object object_0)
	{
		return Conversions.ToString(object_0);
	}

	static void smethod_90(Control control_0)
	{
		control_0.Hide();
	}

	static void smethod_91(DataGridViewCell dataGridViewCell_0, object object_0)
	{
		dataGridViewCell_0.set_Value(object_0);
	}

	static void smethod_92(TextBoxBase textBoxBase_0)
	{
		textBoxBase_0.Clear();
	}
}
