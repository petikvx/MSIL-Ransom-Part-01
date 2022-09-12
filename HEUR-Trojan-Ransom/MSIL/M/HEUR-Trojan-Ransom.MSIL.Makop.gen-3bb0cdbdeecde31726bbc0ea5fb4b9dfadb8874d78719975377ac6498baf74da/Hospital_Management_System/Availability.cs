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
				int num = -733180086;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBE2E5A58u) % 9u)
					{
					case 8u:
						Availability.smethod_56((Control)(object)searchBtn, eventHandler_);
						num = ((int)num2 * -59564088) ^ 0x5C48EA8B;
						continue;
					case 6u:
						searchBtn = _SearchBtn;
						num = (int)(num2 * 1446715281) ^ -810315465;
						continue;
					case 5u:
						Availability.smethod_55((Control)(object)searchBtn, eventHandler_);
						num = ((int)num2 * -492003989) ^ -1050357076;
						continue;
					case 4u:
						_SearchBtn = value;
						num = -1494378694;
						continue;
					case 3u:
						searchBtn = _SearchBtn;
						num = ((int)num2 * -1576455954) ^ 0x1D72B265;
						continue;
					case 2u:
					{
						int num5;
						int num6;
						if (searchBtn == null)
						{
							num5 = 228426836;
							num6 = 228426836;
						}
						else
						{
							num5 = 1272513512;
							num6 = 1272513512;
						}
						num = num5 ^ (int)(num2 * 2016677959);
						continue;
					}
					case 1u:
					{
						int num3;
						int num4;
						if (searchBtn != null)
						{
							num3 = 1229992049;
							num4 = 1229992049;
						}
						else
						{
							num3 = 165413999;
							num4 = 165413999;
						}
						num = num3 ^ (int)(num2 * 1002272582);
						continue;
					}
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
			RadioButton nurseBtn = default(RadioButton);
			while (true)
			{
				int num = 1916773641;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4FB0670Fu) % 8u)
					{
					case 6u:
					{
						nurseBtn = _NurseBtn;
						int num5;
						int num6;
						if (nurseBtn == null)
						{
							num5 = -251037079;
							num6 = -251037079;
						}
						else
						{
							num5 = -291943922;
							num6 = -291943922;
						}
						num = num5 ^ (int)(num2 * 1129265367);
						continue;
					}
					case 4u:
						_NurseBtn = value;
						num = 1869707566;
						continue;
					case 3u:
						Availability.smethod_57(nurseBtn, eventHandler_);
						num = (int)(num2 * 1120878069) ^ -209529116;
						continue;
					case 2u:
						Availability.smethod_58(nurseBtn, eventHandler_);
						num = (int)(num2 * 1195603313) ^ -93766734;
						continue;
					case 1u:
						nurseBtn = _NurseBtn;
						num = (int)((num2 * 264809214) ^ 0x31833EE9);
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (nurseBtn == null)
						{
							num3 = -418828672;
							num4 = -418828672;
						}
						else
						{
							num3 = -1409294691;
							num4 = -1409294691;
						}
						num = num3 ^ ((int)num2 * -2013356017);
						continue;
					}
					default:
						return;
					case 5u:
						break;
					case 7u:
						return;
					}
					break;
				}
			}
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
			RadioButton doctorBtn = _DoctorBtn;
			while (true)
			{
				int num = 1470442405;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFED15A8u) % 6u)
					{
					case 5u:
					{
						_DoctorBtn = value;
						doctorBtn = _DoctorBtn;
						int num5;
						if (doctorBtn != null)
						{
							num = 2122608614;
							num5 = 2122608614;
						}
						else
						{
							num = 2034989178;
							num5 = 2034989178;
						}
						continue;
					}
					case 4u:
						Availability.smethod_58(doctorBtn, eventHandler_);
						num = ((int)num2 * -1782256547) ^ 0x822E2C;
						continue;
					case 2u:
						Availability.smethod_57(doctorBtn, eventHandler_);
						num = (int)(num2 * 605843697) ^ -1229192875;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (doctorBtn != null)
						{
							num3 = -1193888257;
							num4 = -1193888257;
						}
						else
						{
							num3 = -117073694;
							num4 = -117073694;
						}
						num = num3 ^ ((int)num2 * -404193383);
						continue;
					}
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
			RadioButton receptionistBtn = _ReceptionistBtn;
			while (true)
			{
				int num = -1509900577;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBD992556u) % 8u)
					{
					case 6u:
						_ReceptionistBtn = value;
						num = -557517996;
						continue;
					case 5u:
						Availability.smethod_58(receptionistBtn, eventHandler_);
						num = (int)(num2 * 672022234) ^ -35241860;
						continue;
					case 4u:
						Availability.smethod_57(receptionistBtn, eventHandler_);
						num = ((int)num2 * -1161351398) ^ -1782282120;
						continue;
					case 3u:
					{
						int num5;
						int num6;
						if (receptionistBtn == null)
						{
							num5 = 580457103;
							num6 = 580457103;
						}
						else
						{
							num5 = 1002182154;
							num6 = 1002182154;
						}
						num = num5 ^ ((int)num2 * -1589060277);
						continue;
					}
					case 2u:
						receptionistBtn = _ReceptionistBtn;
						num = ((int)num2 * -199888759) ^ 0x62C36967;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (receptionistBtn != null)
						{
							num3 = -117927650;
							num4 = -117927650;
						}
						else
						{
							num3 = -695908388;
							num4 = -695908388;
						}
						num = num3 ^ ((int)num2 * -857000596);
						continue;
					}
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
			DataGridView searchResultGrid = _SearchResultGrid;
			while (true)
			{
				int num = 1436877933;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x12C529F1u) % 6u)
					{
					case 3u:
						Availability.smethod_60(searchResultGrid, dataGridViewCellMouseEventHandler_);
						num = ((int)num2 * -1326781139) ^ 0x49CC39B8;
						continue;
					case 2u:
					{
						int num4;
						int num5;
						if (searchResultGrid == null)
						{
							num4 = -2118091741;
							num5 = -2118091741;
						}
						else
						{
							num4 = -557683492;
							num5 = -557683492;
						}
						num = num4 ^ (int)(num2 * 343552483);
						continue;
					}
					case 1u:
						Availability.smethod_59(searchResultGrid, dataGridViewCellMouseEventHandler_);
						num = ((int)num2 * -518633935) ^ 0x2CCF845E;
						continue;
					case 0u:
					{
						_SearchResultGrid = value;
						searchResultGrid = _SearchResultGrid;
						int num3;
						if (searchResultGrid == null)
						{
							num = 314084753;
							num3 = 314084753;
						}
						else
						{
							num = 287486364;
							num3 = 287486364;
						}
						continue;
					}
					default:
						return;
					case 5u:
						break;
					case 4u:
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
			Button clearBtn = _ClearBtn;
			while (true)
			{
				int num = 1691876234;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x218577EBu) % 7u)
					{
					case 4u:
						Availability.smethod_56((Control)(object)clearBtn, eventHandler_);
						num = (int)((num2 * 106877807) ^ 0x68C76EB3);
						continue;
					case 3u:
					{
						int num5;
						int num6;
						if (clearBtn != null)
						{
							num5 = -1250090886;
							num6 = -1250090886;
						}
						else
						{
							num5 = -209993940;
							num6 = -209993940;
						}
						num = num5 ^ (int)(num2 * 1205149499);
						continue;
					}
					case 2u:
						Availability.smethod_55((Control)(object)clearBtn, eventHandler_);
						num = (int)(num2 * 847450381) ^ -745490896;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (clearBtn == null)
						{
							num3 = -1250115471;
							num4 = -1250115471;
						}
						else
						{
							num3 = -1533363926;
							num4 = -1533363926;
						}
						num = num3 ^ (int)(num2 * 435988993);
						continue;
					}
					case 0u:
						_ClearBtn = value;
						clearBtn = _ClearBtn;
						num = 1165141003;
						continue;
					default:
						return;
					case 6u:
						break;
					case 5u:
						return;
					}
					break;
				}
			}
		}
	}

	public Availability()
	{
		while (true)
		{
			int num = 1683952829;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8880C7Fu) % 7u)
				{
				case 5u:
					myconnection = Availability.smethod_1();
					num = (int)(num2 * 1376286305) ^ -1983515418;
					continue;
				case 4u:
					num = ((int)num2 * -628402948) ^ 0x7B0CAEEB;
					continue;
				case 3u:
					day = Availability.smethod_2(DateTime.Now.ToString("HH"));
					InitializeComponent();
					num = ((int)num2 * -1131442731) ^ -2074868946;
					continue;
				case 2u:
					num = ((int)num2 * -1697150688) ^ 0x6E135D5C;
					continue;
				case 1u:
					Availability.smethod_0((UserControl)(object)this, (EventHandler)Availability_Load);
					num = (int)(num2 * 307844934) ^ -1332846205;
					continue;
				default:
					return;
				case 6u:
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
				goto IL_004c;
			}
			int num = 0;
			goto IL_0083;
			IL_0083:
			bool flag = (byte)num != 0;
			int num2 = 1614019328;
			goto IL_0051;
			IL_004c:
			num2 = 1037357935;
			goto IL_0051;
			IL_0051:
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x70976B0Eu) % 6u)
				{
				case 3u:
					Availability.smethod_3((IDisposable)components);
					num2 = (int)((num3 * 2005607910) ^ 0x5B40B3C3);
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 566251573;
						num5 = 566251573;
					}
					else
					{
						num4 = 200881935;
						num5 = 200881935;
					}
					num2 = num4 ^ (int)(num3 * 694833011);
					continue;
				}
				case 1u:
					num2 = 1760918522;
					continue;
				case 0u:
					break;
				default:
					return;
				case 5u:
					goto IL_007a;
				case 4u:
					return;
				}
				break;
			}
			goto IL_004c;
			IL_007a:
			num = ((components != null) ? 1 : 0);
			goto IL_0083;
		}
		finally
		{
			((ContainerControl)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		Label1 = Availability.smethod_4();
		while (true)
		{
			int num = 1553061625;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6C3015A8u) % 288u)
				{
				case 287u:
					Availability.smethod_21(Label7, "Address : ");
					num = (int)(num2 * 959069627) ^ -620410137;
					continue;
				case 286u:
					Availability.smethod_52((ISupportInitialize)PictureBox1);
					num = (int)((num2 * 1397416730) ^ 0x19C8A661);
					continue;
				case 285u:
					Availability.smethod_16((Control)(object)DoctorBtn, Availability.smethod_15("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					Availability.smethod_17((Control)(object)DoctorBtn, new Point(65, 84));
					Availability.smethod_18((Control)(object)DoctorBtn, "DoctorBtn");
					num = ((int)num2 * -1367999196) ^ -1233939924;
					continue;
				case 284u:
					Availability.smethod_19((Control)(object)NurseBtn, new Size(78, 23));
					num = (int)((num2 * 1017967625) ^ 0x2B49FCA0);
					continue;
				case 283u:
					num = (int)((num2 * 1451827242) ^ 0x7A09862B);
					continue;
				case 282u:
					num = (int)((num2 * 1203472463) ^ 0x7BFDE597);
					continue;
				case 281u:
					Availability.smethod_19((Control)(object)GroupBox1, new Size(623, 127));
					num = (int)((num2 * 733001170) ^ 0x360C7751);
					continue;
				case 280u:
					num = (int)((num2 * 1083563490) ^ 0x4D5169C7);
					continue;
				case 279u:
					num = ((int)num2 * -708163091) ^ -1050506023;
					continue;
				case 278u:
					Availability.smethod_32(NurseBtn, bool_0: true);
					num = ((int)num2 * -1606835375) ^ 0x4D23321A;
					continue;
				case 277u:
					num = ((int)num2 * -28817556) ^ -1344194999;
					continue;
				case 276u:
					Availability.smethod_20((Control)(object)Label7, 3);
					num = (int)(num2 * 1578044464) ^ -816522736;
					continue;
				case 275u:
					num = (int)(num2 * 789166693) ^ -1074972734;
					continue;
				case 274u:
					Availability.smethod_18((Control)(object)Label4, "Label4");
					num = (int)((num2 * 795849524) ^ 0x636264DE);
					continue;
				case 273u:
					NameSTxt = Availability.smethod_8();
					num = (int)(num2 * 971020487) ^ -1254619515;
					continue;
				case 272u:
					Availability.smethod_16((Control)(object)DetailsBox, Availability.smethod_15("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					Availability.smethod_17((Control)(object)DetailsBox, new Point(155, 470));
					num = ((int)num2 * -817241344) ^ 0x2728DAB5;
					continue;
				case 271u:
					Availability.smethod_12((ISupportInitialize)SearchResultGrid);
					num = ((int)num2 * -402789071) ^ 0x3E039CC5;
					continue;
				case 270u:
					Availability.smethod_18((Control)(object)GroupBox1, "GroupBox1");
					num = ((int)num2 * -1347372900) ^ 0x3AECE339;
					continue;
				case 269u:
					Label5 = Availability.smethod_4();
					Label4 = Availability.smethod_4();
					num = (int)(num2 * 1105502956) ^ -1633381004;
					continue;
				case 268u:
					Availability.smethod_38((Control)(object)ShowAvailability, Color.Red);
					num = (int)(num2 * 927031970) ^ -1708469424;
					continue;
				case 267u:
					Availability.smethod_18((Control)(object)DOBTxt, "DOBTxt");
					Availability.smethod_39((TextBoxBase)(object)DOBTxt, bool_0: true);
					num = (int)(num2 * 131891744) ^ -712178842;
					continue;
				case 266u:
					num = ((int)num2 * -1137549142) ^ 0x7847C5CB;
					continue;
				case 265u:
					Availability.smethod_18((Control)(object)Label8, "Label8");
					num = ((int)num2 * -757241632) ^ -253574382;
					continue;
				case 264u:
					Availability.smethod_18((Control)(object)DesignationTxt, "DesignationTxt");
					num = ((int)num2 * -824629061) ^ 0x3BAB8C5B;
					continue;
				case 263u:
					Availability.smethod_21(Label1, "Staff Availability");
					Availability.smethod_22(Label1, (ContentAlignment)32);
					Availability.smethod_24(Availability.smethod_23((Control)(object)GroupBox1), (Control)(object)ClearBtn);
					num = ((int)num2 * -835276454) ^ -762393758;
					continue;
				case 262u:
					Availability.smethod_16((Control)(object)Label5, Availability.smethod_15("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1978822316) ^ 0x2321E28C);
					continue;
				case 261u:
					SearchResultGrid = Availability.smethod_9();
					num = (int)((num2 * 2107449015) ^ 0x7B0AF252);
					continue;
				case 260u:
					num = ((int)num2 * -2058989834) ^ 0x4041A40D;
					continue;
				case 259u:
					Availability.smethod_17((Control)(object)Label2, new Point(37, 44));
					num = (int)(num2 * 1091450580) ^ -2117698466;
					continue;
				case 258u:
					num = ((int)num2 * -1604505646) ^ -110241054;
					continue;
				case 257u:
					Availability.smethod_44(PictureBox1, bool_0: false);
					num = (int)((num2 * 1181465861) ^ 0x381F4962);
					continue;
				case 256u:
					num = (int)((num2 * 1685615825) ^ 0x13894936);
					continue;
				case 255u:
					ClearBtn = Availability.smethod_6();
					num = (int)(num2 * 1009521247) ^ -687675260;
					continue;
				case 254u:
					Availability.smethod_18((Control)(object)Label9, "Label9");
					num = (int)((num2 * 681382097) ^ 0x30E76A19);
					continue;
				case 253u:
					Availability.smethod_20((Control)(object)ReceptionistBtn, 7);
					num = ((int)num2 * -1911244759) ^ -780745786;
					continue;
				case 252u:
					Availability.smethod_19((Control)(object)MobileTxt, new Size(241, 28));
					num = ((int)num2 * -111940011) ^ -1869099721;
					continue;
				case 251u:
					num = (int)(num2 * 903828788) ^ -878431796;
					continue;
				case 250u:
					Availability.smethod_19((Control)(object)Label2, new Size(77, 28));
					num = ((int)num2 * -578136098) ^ 0x20D34456;
					continue;
				case 249u:
					num = (int)(num2 * 617159149) ^ -1432299011;
					continue;
				case 248u:
					Availability.smethod_19((Control)(object)GenderTxt, new Size(128, 28));
					Availability.smethod_20((Control)(object)GenderTxt, 6);
					num = (int)((num2 * 922146788) ^ 0x576EEB83);
					continue;
				case 247u:
					num = ((int)num2 * -2004509772) ^ 0x7C2B11FC;
					continue;
				case 246u:
					Availability.smethod_17((Control)(object)ShowAvailability, new Point(389, 24));
					num = (int)(num2 * 2053995662) ^ -72071681;
					continue;
				case 245u:
					num = ((int)num2 * -1753150977) ^ -785356809;
					continue;
				case 244u:
					Availability.smethod_20((Control)(object)NurseBtn, 6);
					num = ((int)num2 * -1294962614) ^ -234581610;
					continue;
				case 243u:
					Availability.smethod_24(Availability.smethod_23((Control)(object)DetailsBox), (Control)(object)Label5);
					num = (int)(num2 * 195673583) ^ -1318423007;
					continue;
				case 242u:
					Availability.smethod_14(Label1, bool_0: true);
					num = (int)(num2 * 1444311367) ^ -607788762;
					continue;
				case 241u:
					num = (int)((num2 * 343848351) ^ 0x19C1F393);
					continue;
				case 240u:
					Availability.smethod_19((Control)(object)DoctorBtn, new Size(87, 23));
					Availability.smethod_20((Control)(object)DoctorBtn, 5);
					num = ((int)num2 * -1133972133) ^ -1800942133;
					continue;
				case 239u:
					Availability.smethod_29((ButtonBase)(object)ReceptionistBtn, "Receptionist");
					num = (int)(num2 * 1944337119) ^ -1305062969;
					continue;
				case 238u:
					Availability.smethod_20((Control)(object)ShowAvailability, 15);
					num = ((int)num2 * -909001563) ^ -896436629;
					continue;
				case 237u:
					Availability.smethod_24(Availability.smethod_23((Control)(object)DetailsBox), (Control)(object)DOBTxt);
					Availability.smethod_24(Availability.smethod_23((Control)(object)DetailsBox), (Control)(object)SIDTxt);
					num = (int)(num2 * 1370242229) ^ -705584434;
					continue;
				case 236u:
					Availability.smethod_49((Control)(object)this, new Size(977, 804));
					num = ((int)num2 * -1474484847) ^ 0xE0A948A;
					continue;
				case 235u:
					num = (int)((num2 * 718718050) ^ 0x7233651A);
					continue;
				case 234u:
					Availability.smethod_31((ButtonBase)(object)ReceptionistBtn, bool_0: true);
					num = (int)(num2 * 527384498) ^ -335549179;
					continue;
				case 233u:
					num = (int)(num2 * 647533446) ^ -575608725;
					continue;
				case 232u:
					Availability.smethod_21(ShowAvailability, "UnAvailable");
					num = ((int)num2 * -323998544) ^ 0x665FAA57;
					continue;
				case 231u:
					Availability.smethod_33(SearchResultGrid, Color.White);
					Availability.smethod_34(SearchResultGrid, (DataGridViewColumnHeadersHeightSizeMode)2);
					num = ((int)num2 * -1490544678) ^ -1609016213;
					continue;
				case 230u:
					Availability.smethod_17((Control)(object)Label4, new Point(25, 77));
					num = (int)(num2 * 1480142249) ^ -2070975972;
					continue;
				case 229u:
					num = ((int)num2 * -961862069) ^ 0x12BEAB9D;
					continue;
				case 228u:
					num = ((int)num2 * -877783089) ^ -1644628642;
					continue;
				case 227u:
					num = ((int)num2 * -989225791) ^ -1368893015;
					continue;
				case 226u:
					Availability.smethod_16((Control)(object)ClearBtn, Availability.smethod_15("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1772165801) ^ 0x5FE09DC);
					continue;
				case 225u:
					Availability.smethod_18((Control)(object)ReceptionistBtn, "ReceptionistBtn");
					num = ((int)num2 * -730574102) ^ 0x6A32C7F8;
					continue;
				case 224u:
					Availability.smethod_28((Control)(object)SearchBtn, Color.White);
					num = (int)(num2 * 777369167) ^ -759094905;
					continue;
				case 223u:
					Availability.smethod_20((Control)(object)MobileTxt, 12);
					num = (int)((num2 * 1200752841) ^ 0x33A0DF3D);
					continue;
				case 222u:
					Availability.smethod_30((ButtonBase)(object)ReceptionistBtn, bool_0: true);
					num = (int)((num2 * 1597351757) ^ 0x69D6CC0D);
					continue;
				case 220u:
					Availability.smethod_17((Control)(object)Label1, new Point(392, 63));
					Availability.smethod_18((Control)(object)Label1, "Label1");
					Availability.smethod_19((Control)(object)Label1, new Size(270, 35));
					Availability.smethod_20((Control)(object)Label1, 5);
					num = (int)((num2 * 1548413323) ^ 0x66C5542);
					continue;
				case 219u:
					PictureBox1 = Availability.smethod_10();
					Availability.smethod_11((Control)(object)GroupBox1);
					num = (int)((num2 * 461926182) ^ 0x166DB505);
					continue;
				case 218u:
					num = (int)(num2 * 1063775479) ^ -1089682001;
					continue;
				case 217u:
					Availability.smethod_16((Control)(object)ReceptionistBtn, Availability.smethod_15("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1179632189) ^ 0x36159788;
					continue;
				case 216u:
					Availability.smethod_18((Control)(object)Label7, "Label7");
					num = ((int)num2 * -631456638) ^ -706075447;
					continue;
				case 215u:
					Availability.smethod_26(DetailsBox, "Staff Member Detail");
					num = (int)((num2 * 1067827966) ^ 0x6EC92316);
					continue;
				case 214u:
					Availability.smethod_22(Label2, (ContentAlignment)32);
					num = ((int)num2 * -1182967389) ^ -1364121299;
					continue;
				case 213u:
					NurseBtn = Availability.smethod_7();
					DoctorBtn = Availability.smethod_7();
					num = (int)((num2 * 621910473) ^ 0x37F9234C);
					continue;
				case 212u:
					SIDTxt = Availability.smethod_8();
					num = ((int)num2 * -2095330769) ^ -218991834;
					continue;
				case 211u:
					Availability.smethod_24(Availability.smethod_23((Control)(object)DetailsBox), (Control)(object)Label6);
					num = (int)((num2 * 1311795182) ^ 0x5170A811);
					continue;
				case 210u:
					Availability.smethod_24(Availability.smethod_23((Control)(object)GroupBox1), (Control)(object)Label2);
					num = (int)((num2 * 1927687576) ^ 0x6BF080CC);
					continue;
				case 209u:
					GroupBox1 = Availability.smethod_5();
					num = (int)((num2 * 1387707331) ^ 0x6AE92464);
					continue;
				case 208u:
					Availability.smethod_45((ContainerControl)(object)this, new SizeF(8f, 16f));
					num = (int)((num2 * 633189513) ^ 0x4F27C711);
					continue;
				case 207u:
					num = ((int)num2 * -568624633) ^ -1592319865;
					continue;
				case 206u:
					Label7 = Availability.smethod_4();
					num = (int)(num2 * 1867964524) ^ -224764531;
					continue;
				case 205u:
					Availability.smethod_24(Availability.smethod_47((Control)(object)this), (Control)(object)Label1);
					num = ((int)num2 * -704868925) ^ -1905081337;
					continue;
				case 204u:
					Availability.smethod_17((Control)(object)Label7, new Point(16, 217));
					num = ((int)num2 * -1346914607) ^ -87581197;
					continue;
				case 203u:
					Availability.smethod_30((ButtonBase)(object)SearchBtn, bool_0: false);
					num = ((int)num2 * -785045413) ^ 0x44D73128;
					continue;
				case 202u:
					Availability.smethod_18((Control)(object)Label2, "Label2");
					num = (int)(num2 * 710129909) ^ -1907410611;
					continue;
				case 201u:
					Availability.smethod_20((Control)(object)ClearBtn, 8);
					Availability.smethod_29((ButtonBase)(object)ClearBtn, "Clear");
					Availability.smethod_30((ButtonBase)(object)ClearBtn, bool_0: false);
					num = (int)(num2 * 1176363070) ^ -154649391;
					continue;
				case 200u:
					Availability.smethod_21(Label6, "Gender : ");
					num = ((int)num2 * -914682393) ^ 0x79651176;
					continue;
				case 199u:
					Availability.smethod_24(Availability.smethod_23((Control)(object)DetailsBox), (Control)(object)Label9);
					num = ((int)num2 * -735995972) ^ 0x205D8932;
					continue;
				case 198u:
					Availability.smethod_18((Control)(object)MobileTxt, "MobileTxt");
					num = (int)(num2 * 442117370) ^ -69693889;
					continue;
				case 197u:
					Availability.smethod_18((Control)(object)DetailsBox, "DetailsBox");
					num = (int)(num2 * 1724168598) ^ -982801194;
					continue;
				case 196u:
					num = (int)(num2 * 1991634396) ^ -1885387367;
					continue;
				case 195u:
					Availability.smethod_17((Control)(object)ReceptionistBtn, new Point(280, 84));
					num = (int)((num2 * 363724377) ^ 0x475597C2);
					continue;
				case 194u:
					num = ((int)num2 * -42876067) ^ 0x449F2587;
					continue;
				case 193u:
					num = ((int)num2 * -184927879) ^ -853179674;
					continue;
				case 192u:
					num = ((int)num2 * -768376814) ^ -54789593;
					continue;
				case 191u:
					Availability.smethod_20((Control)(object)Label5, 1);
					num = (int)((num2 * 1367721088) ^ 0x289308DE);
					continue;
				case 190u:
					Availability.smethod_24(Availability.smethod_23((Control)(object)DetailsBox), (Control)(object)NameTxt);
					num = (int)(num2 * 2135793143) ^ -1968624068;
					continue;
				case 189u:
					num = ((int)num2 * -2045318755) ^ -196283292;
					continue;
				case 188u:
					Availability.smethod_20((Control)(object)Label8, 9);
					num = ((int)num2 * -1380530809) ^ -1854207002;
					continue;
				case 187u:
					Availability.smethod_18((Control)(object)Label3, "Label3");
					num = (int)(num2 * 371315319) ^ -1525299332;
					continue;
				case 186u:
					Availability.smethod_50((Control)(object)DetailsBox, bool_0: false);
					num = ((int)num2 * -73262114) ^ -638550964;
					continue;
				case 185u:
					Availability.smethod_24(Availability.smethod_23((Control)(object)GroupBox1), (Control)(object)SearchBtn);
					Availability.smethod_24(Availability.smethod_23((Control)(object)GroupBox1), (Control)(object)NameSTxt);
					num = (int)(num2 * 1428262468) ^ -1685844770;
					continue;
				case 184u:
					Availability.smethod_24(Availability.smethod_23((Control)(object)GroupBox1), (Control)(object)NurseBtn);
					Availability.smethod_24(Availability.smethod_23((Control)(object)GroupBox1), (Control)(object)DoctorBtn);
					num = (int)((num2 * 975686773) ^ 0x56B2E21);
					continue;
				case 183u:
					num = (int)(num2 * 1108702058) ^ -300502908;
					continue;
				case 182u:
					Availability.smethod_20((Control)(object)Label6, 2);
					num = (int)((num2 * 1201029139) ^ 0x4C8FBDE2);
					continue;
				case 181u:
					Availability.smethod_18((Control)(object)NameTxt, "NameTxt");
					Availability.smethod_39((TextBoxBase)(object)NameTxt, bool_0: true);
					num = ((int)num2 * -1063787614) ^ 0x522291D4;
					continue;
				case 180u:
					Availability.smethod_18((Control)(object)Label5, "Label5");
					num = (int)(num2 * 16379768) ^ -201593118;
					continue;
				case 179u:
					Availability.smethod_24(Availability.smethod_23((Control)(object)DetailsBox), (Control)(object)Label3);
					num = (int)(num2 * 504824028) ^ -340663567;
					continue;
				case 178u:
					Availability.smethod_20((Control)(object)Label2, 0);
					num = (int)(num2 * 2145825119) ^ -437554821;
					continue;
				case 177u:
					num = ((int)num2 * -1298588723) ^ -1403374244;
					continue;
				case 176u:
					num = ((int)num2 * -671177615) ^ -1692349031;
					continue;
				case 175u:
					Availability.smethod_20((Control)(object)SearchBtn, 4);
					Availability.smethod_29((ButtonBase)(object)SearchBtn, "Search");
					num = (int)((num2 * 147700402) ^ 0x2CBA792D);
					continue;
				case 174u:
					Availability.smethod_50((Control)(object)GroupBox1, bool_0: false);
					num = ((int)num2 * -617383178) ^ 0x1AD5B40D;
					continue;
				case 173u:
					Availability.smethod_24(Availability.smethod_23((Control)(object)DetailsBox), (Control)(object)MobileTxt);
					num = ((int)num2 * -1474017495) ^ -1451986694;
					continue;
				case 172u:
					Availability.smethod_20((Control)(object)AddressTxt, 7);
					num = (int)(num2 * 631659469) ^ -707953154;
					continue;
				case 171u:
					num = ((int)num2 * -1128191046) ^ -594903525;
					continue;
				case 170u:
					Availability.smethod_19((Control)(object)Label5, new Size(84, 26));
					num = ((int)num2 * -799347561) ^ -1302626991;
					continue;
				case 169u:
					DetailsBox = Availability.smethod_5();
					num = (int)(num2 * 160907830) ^ -1773722491;
					continue;
				case 168u:
					num = (int)((num2 * 1411134828) ^ 0x4E985616);
					continue;
				case 167u:
					Availability.smethod_24(Availability.smethod_47((Control)(object)this), (Control)(object)SearchResultGrid);
					num = ((int)num2 * -1398099333) ^ 0x3CD218FA;
					continue;
				case 166u:
					num = (int)((num2 * 71687846) ^ 0x1ED88D4E);
					continue;
				case 165u:
					Availability.smethod_53((Control)(object)this, bool_0: false);
					Availability.smethod_54((Control)(object)this);
					num = ((int)num2 * -56759245) ^ 0x20C66093;
					continue;
				case 164u:
					Availability.smethod_37(Availability.smethod_36(SearchResultGrid), 24);
					num = (int)((num2 * 2038153744) ^ 0x23332C93);
					continue;
				case 163u:
					Availability.smethod_18((Control)(object)ShowAvailability, "ShowAvailability");
					num = ((int)num2 * -1139005743) ^ 0x6538F1F5;
					continue;
				case 162u:
					num = (int)((num2 * 818519651) ^ 0x78F9A75C);
					continue;
				case 161u:
					Availability.smethod_22(Label9, (ContentAlignment)32);
					Availability.smethod_17((Control)(object)NameTxt, new Point(124, 123));
					num = (int)(num2 * 1129803813) ^ -1588058128;
					continue;
				case 160u:
					num = (int)(num2 * 1833964786) ^ -2090899010;
					continue;
				case 159u:
					num = (int)((num2 * 1990458917) ^ 0x4B771620);
					continue;
				case 158u:
					AddressTxt = Availability.smethod_8();
					num = (int)(num2 * 237279261) ^ -692220734;
					continue;
				case 157u:
					Availability.smethod_21(Label2, "Name : ");
					num = (int)((num2 * 180037524) ^ 0x6A3A51A);
					continue;
				case 156u:
					Availability.smethod_17((Control)(object)Label9, new Point(16, 169));
					num = ((int)num2 * -1720363553) ^ -1394025470;
					continue;
				case 155u:
					Availability.smethod_21(Label9, "Phone : ");
					num = ((int)num2 * -1946231191) ^ -212672742;
					continue;
				case 154u:
					Label2 = Availability.smethod_4();
					num = (int)(num2 * 489521390) ^ -1264313727;
					continue;
				case 153u:
					SearchBtn = Availability.smethod_6();
					num = (int)((num2 * 1343306082) ^ 0x4263B4CB);
					continue;
				case 152u:
					Availability.smethod_24(Availability.smethod_23((Control)(object)DetailsBox), (Control)(object)DesignationTxt);
					num = ((int)num2 * -1326588558) ^ -1277070837;
					continue;
				case 151u:
					Availability.smethod_24(Availability.smethod_23((Control)(object)DetailsBox), (Control)(object)Label7);
					num = ((int)num2 * -1887131223) ^ 0x3FAEB3B8;
					continue;
				case 150u:
					Availability.smethod_17((Control)(object)Label5, new Point(389, 123));
					num = (int)((num2 * 698378154) ^ 0x683AB005);
					continue;
				case 149u:
					Availability.smethod_17((Control)(object)SearchResultGrid, new Point(59, 295));
					num = ((int)num2 * -984323093) ^ 0x7454D8EE;
					continue;
				case 148u:
					Availability.smethod_26(GroupBox1, "Search Staff Member");
					num = ((int)num2 * -387316369) ^ 0x3F400F44;
					continue;
				case 147u:
					num = ((int)num2 * -847581801) ^ -895461694;
					continue;
				case 146u:
					Availability.smethod_24(Availability.smethod_47((Control)(object)this), (Control)(object)PictureBox1);
					Availability.smethod_48((Control)(object)this, "Availability");
					num = ((int)num2 * -1962674055) ^ -2075543610;
					continue;
				case 145u:
					Availability.smethod_17((Control)(object)MobileTxt, new Point(124, 169));
					num = ((int)num2 * -2023047324) ^ 0x1400610A;
					continue;
				case 144u:
					Availability.smethod_13((Control)(object)this);
					num = ((int)num2 * -202485015) ^ -1053141686;
					continue;
				case 143u:
					Availability.smethod_19((Control)(object)Label9, new Size(77, 28));
					num = ((int)num2 * -543595579) ^ 0x665CAEA4;
					continue;
				case 142u:
					num = ((int)num2 * -1013122862) ^ 0x38A5EDC7;
					continue;
				case 141u:
					ReceptionistBtn = Availability.smethod_7();
					num = ((int)num2 * -217726471) ^ 0x6677DC3E;
					continue;
				case 140u:
					num = (int)((num2 * 1099084791) ^ 0x6766376A);
					continue;
				case 139u:
					num = ((int)num2 * -1375366710) ^ 0x354C3565;
					continue;
				case 138u:
					Availability.smethod_24(Availability.smethod_47((Control)(object)this), (Control)(object)DetailsBox);
					num = (int)((num2 * 1964218281) ^ 0xEC64CF5);
					continue;
				case 137u:
					Availability.smethod_19((Control)(object)Label7, new Size(98, 26));
					num = ((int)num2 * -1850715475) ^ -226756343;
					continue;
				case 136u:
					num = (int)(num2 * 381545995) ^ -1161819776;
					continue;
				case 135u:
					NameTxt = Availability.smethod_8();
					num = (int)(num2 * 1471504101) ^ -1311027497;
					continue;
				case 134u:
					Availability.smethod_51((Control)(object)GroupBox1);
					num = ((int)num2 * -1286962899) ^ -1454071855;
					continue;
				case 133u:
					Availability.smethod_25(DetailsBox, bool_0: false);
					num = (int)((num2 * 650075029) ^ 0x6F8E3A40);
					continue;
				case 132u:
					Availability.smethod_41(PictureBox1, (Image)(object)Resources.images);
					num = (int)(num2 * 1790327217) ^ -442397637;
					continue;
				case 131u:
					Availability.smethod_20((Control)(object)DetailsBox, 9);
					num = ((int)num2 * -231358221) ^ -1198704701;
					continue;
				case 130u:
					Availability.smethod_17((Control)(object)Label8, new Point(20, 124));
					num = (int)((num2 * 1626601435) ^ 0x7D955B77);
					continue;
				case 129u:
					Availability.smethod_17((Control)(object)Label3, new Point(291, 72));
					num = ((int)num2 * -397246212) ^ -1044631697;
					continue;
				case 128u:
					num = ((int)num2 * -211119131) ^ 0x5758D453;
					continue;
				case 127u:
					Availability.smethod_38((Control)(object)this, Color.White);
					num = (int)(num2 * 218807241) ^ -816950629;
					continue;
				case 126u:
					num = ((int)num2 * -1568472423) ^ 0x77DB5481;
					continue;
				case 125u:
					num = ((int)num2 * -2043311921) ^ -1271496370;
					continue;
				case 124u:
					Availability.smethod_24(Availability.smethod_23((Control)(object)GroupBox1), (Control)(object)ReceptionistBtn);
					num = (int)((num2 * 1744804428) ^ 0x11604A0);
					continue;
				case 123u:
					Availability.smethod_19((Control)(object)ClearBtn, new Size(133, 37));
					num = ((int)num2 * -1717721707) ^ 0x34684A36;
					continue;
				case 122u:
					Availability.smethod_19((Control)(object)ReceptionistBtn, new Size(132, 23));
					num = (int)(num2 * 412423210) ^ -746400431;
					continue;
				case 121u:
					Availability.smethod_16((Control)(object)Label7, Availability.smethod_15("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -45865719) ^ 0x2FA87085;
					continue;
				case 120u:
					num = (int)((num2 * 2015953237) ^ 0x2D604E48);
					continue;
				case 119u:
					num = ((int)num2 * -1678245595) ^ 0x5D2480BA;
					continue;
				case 118u:
					Availability.smethod_19((Control)(object)Label3, new Size(121, 28));
					num = ((int)num2 * -1397501034) ^ 0x2271B660;
					continue;
				case 117u:
					num = (int)(num2 * 1075163697) ^ -1001406988;
					continue;
				case 116u:
					Availability.smethod_16((Control)(object)Label2, Availability.smethod_15("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -751976596) ^ 0x7ABDFD3B;
					continue;
				case 115u:
					Availability.smethod_32(DoctorBtn, bool_0: true);
					num = (int)((num2 * 721329586) ^ 0x5098F310);
					continue;
				case 114u:
					Availability.smethod_16((Control)(object)SearchBtn, Availability.smethod_15("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -529798451) ^ 0x1BCAC48A;
					continue;
				case 113u:
					Availability.smethod_12((ISupportInitialize)PictureBox1);
					num = (int)(num2 * 1438439892) ^ -795802804;
					continue;
				case 112u:
					Availability.smethod_19((Control)(object)DetailsBox, new Size(623, 313));
					num = (int)((num2 * 977108388) ^ 0x1A2E762B);
					continue;
				case 111u:
					Availability.smethod_17((Control)(object)SIDTxt, new Point(124, 77));
					num = ((int)num2 * -1720741743) ^ -908415727;
					continue;
				case 110u:
					Availability.smethod_19((Control)(object)DOBTxt, new Size(128, 28));
					Availability.smethod_20((Control)(object)DOBTxt, 5);
					num = (int)(num2 * 1591305890) ^ -390721635;
					continue;
				case 109u:
					GenderTxt = Availability.smethod_8();
					num = (int)(num2 * 393220701) ^ -1614047182;
					continue;
				case 108u:
					Availability.smethod_42(PictureBox1, (PictureBoxSizeMode)1);
					num = (int)((num2 * 349487490) ^ 0x7296D9A4);
					continue;
				case 107u:
					Availability.smethod_19((Control)(object)PictureBox1, new Size(126, 122));
					num = (int)(num2 * 819936379) ^ -541769491;
					continue;
				case 106u:
					Availability.smethod_16((Control)(object)Label6, Availability.smethod_15("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1589902449) ^ -369590220;
					continue;
				case 105u:
					Availability.smethod_46((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 1846375586) ^ 0x33C5F8E5);
					continue;
				case 104u:
					Availability.smethod_19((Control)(object)ShowAvailability, new Size(218, 23));
					num = ((int)num2 * -1304574569) ^ -14732034;
					continue;
				case 103u:
					Availability.smethod_16((Control)(object)Label3, Availability.smethod_15("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 342363891) ^ 0x5ADCED9A);
					continue;
				case 102u:
					Availability.smethod_18((Control)(object)GenderTxt, "GenderTxt");
					Availability.smethod_39((TextBoxBase)(object)GenderTxt, bool_0: true);
					num = ((int)num2 * -777319152) ^ -628008909;
					continue;
				case 101u:
					num = ((int)num2 * -1606634349) ^ 0x710DADDF;
					continue;
				case 99u:
					Availability.smethod_17((Control)(object)GroupBox1, new Point(155, 150));
					num = (int)(num2 * 2092108933) ^ -314609367;
					continue;
				case 98u:
					Availability.smethod_24(Availability.smethod_23((Control)(object)DetailsBox), (Control)(object)Label8);
					num = ((int)num2 * -304070826) ^ 0x67E71872;
					continue;
				case 97u:
					Availability.smethod_39((TextBoxBase)(object)SIDTxt, bool_0: true);
					num = (int)(num2 * 287547697) ^ -184592859;
					continue;
				case 96u:
					Availability.smethod_27((ButtonBase)(object)ClearBtn, Color.MidnightBlue);
					num = ((int)num2 * -1159736995) ^ -1022793237;
					continue;
				case 95u:
					Availability.smethod_20((Control)(object)NameTxt, 10);
					num = (int)((num2 * 425280101) ^ 0x6FC14CDD);
					continue;
				case 94u:
					Availability.smethod_19((Control)(object)Label4, new Size(68, 25));
					num = ((int)num2 * -551366598) ^ -1530420363;
					continue;
				case 93u:
					Availability.smethod_20((Control)(object)DesignationTxt, 14);
					num = ((int)num2 * -121759991) ^ -2021587830;
					continue;
				case 92u:
					Availability.smethod_17((Control)(object)ClearBtn, new Point(467, 30));
					Availability.smethod_18((Control)(object)ClearBtn, "ClearBtn");
					num = ((int)num2 * -1587957542) ^ -1069097941;
					continue;
				case 91u:
					Availability.smethod_16((Control)(object)NurseBtn, Availability.smethod_15("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 313180167) ^ -1863351835;
					continue;
				case 90u:
					num = ((int)num2 * -1907998586) ^ -1766890928;
					continue;
				case 89u:
					num = ((int)num2 * -780541026) ^ -490214800;
					continue;
				case 88u:
					num = (int)(num2 * 1405294416) ^ -1801142157;
					continue;
				case 87u:
					Availability.smethod_18((Control)(object)PictureBox1, "PictureBox1");
					num = ((int)num2 * -1805421051) ^ 0x62114350;
					continue;
				case 86u:
					Availability.smethod_19((Control)(object)NameTxt, new Size(241, 28));
					num = ((int)num2 * -1696387864) ^ 0x31C974E7;
					continue;
				case 85u:
					Availability.smethod_30((ButtonBase)(object)NurseBtn, bool_0: true);
					num = (int)(num2 * 383638598) ^ -877394066;
					continue;
				case 84u:
					Availability.smethod_16((Control)(object)GroupBox1, Availability.smethod_15("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1844250669) ^ 0x3A369AAF);
					continue;
				case 83u:
					Availability.smethod_20((Control)(object)SIDTxt, 4);
					num = ((int)num2 * -117769185) ^ -28928740;
					continue;
				case 82u:
					Availability.smethod_11((Control)(object)DetailsBox);
					num = (int)(num2 * 213825566) ^ -1167179547;
					continue;
				case 81u:
					num = ((int)num2 * -525137258) ^ -1056207880;
					continue;
				case 80u:
					Availability.smethod_18((Control)(object)AddressTxt, "AddressTxt");
					Availability.smethod_39((TextBoxBase)(object)AddressTxt, bool_0: true);
					num = (int)((num2 * 1224294319) ^ 0x1E3081A6);
					continue;
				case 79u:
					num = ((int)num2 * -1235453932) ^ 0x2C4F4734;
					continue;
				case 78u:
					num = ((int)num2 * -123549702) ^ 0x4F2EBD6C;
					continue;
				case 77u:
					num = (int)((num2 * 2071683054) ^ 0x441324BD);
					continue;
				case 76u:
					num = ((int)num2 * -516624846) ^ -1288956489;
					continue;
				case 75u:
					Availability.smethod_39((TextBoxBase)(object)DesignationTxt, bool_0: true);
					Availability.smethod_19((Control)(object)DesignationTxt, new Size(179, 28));
					num = ((int)num2 * -1389882019) ^ 0x1BF91F4A;
					continue;
				case 74u:
					num = ((int)num2 * -1559714607) ^ 0x5758D4A;
					continue;
				case 73u:
					Availability.smethod_17((Control)(object)NameSTxt, new Point(120, 44));
					Availability.smethod_18((Control)(object)NameSTxt, "NameSTxt");
					num = ((int)num2 * -1248832240) ^ -648324219;
					continue;
				case 72u:
					num = (int)(num2 * 532438668) ^ -1858858296;
					continue;
				case 71u:
					Availability.smethod_20((Control)(object)Label3, 13);
					num = ((int)num2 * -1554149576) ^ -561011565;
					continue;
				case 70u:
					Availability.smethod_18((Control)(object)SIDTxt, "SIDTxt");
					num = (int)((num2 * 1078587823) ^ 0x756D08B3);
					continue;
				case 69u:
					num = ((int)num2 * -1325032401) ^ 0x36B1C138;
					continue;
				case 68u:
					Availability.smethod_29((ButtonBase)(object)NurseBtn, "Nurse");
					num = (int)(num2 * 121460591) ^ -349671039;
					continue;
				case 67u:
					num = ((int)num2 * -818601815) ^ -1668704370;
					continue;
				case 66u:
					num = ((int)num2 * -384592467) ^ 0x26051C1E;
					continue;
				case 65u:
					Availability.smethod_18((Control)(object)SearchResultGrid, "SearchResultGrid");
					Availability.smethod_35(SearchResultGrid, bool_0: true);
					num = (int)(num2 * 145082475) ^ -1114112455;
					continue;
				case 64u:
					num = (int)((num2 * 443780707) ^ 0x7033C80F);
					continue;
				case 63u:
					Availability.smethod_24(Availability.smethod_23((Control)(object)DetailsBox), (Control)(object)GenderTxt);
					num = ((int)num2 * -439894130) ^ 0x42BBA35A;
					continue;
				case 62u:
					Availability.smethod_17((Control)(object)AddressTxt, new Point(124, 217));
					num = (int)(num2 * 535353707) ^ -2027582169;
					continue;
				case 61u:
					Availability.smethod_19((Control)(object)NameSTxt, new Size(292, 28));
					num = (int)((num2 * 2126716073) ^ 0x5547DAC0);
					continue;
				case 60u:
					Availability.smethod_19((Control)(object)SIDTxt, new Size(100, 28));
					num = ((int)num2 * -317552308) ^ 0x6BA46078;
					continue;
				case 59u:
					num = ((int)num2 * -1683614256) ^ -2083735331;
					continue;
				case 58u:
					Availability.smethod_25(GroupBox1, bool_0: false);
					num = (int)((num2 * 1719710646) ^ 0x4DF2DA01);
					continue;
				case 57u:
					Availability.smethod_19((Control)(object)Label8, new Size(77, 28));
					num = (int)((num2 * 841499635) ^ 0x22CAAEF);
					continue;
				case 56u:
					Availability.smethod_31((ButtonBase)(object)DoctorBtn, bool_0: true);
					num = (int)((num2 * 1782452651) ^ 0x6CD46775);
					continue;
				case 55u:
					Availability.smethod_52((ISupportInitialize)SearchResultGrid);
					num = ((int)num2 * -1241288342) ^ -1871112076;
					continue;
				case 54u:
					Availability.smethod_21(Label5, "D.O.B. :");
					Availability.smethod_16((Control)(object)Label4, Availability.smethod_15("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1501889834) ^ 0x4AD5E412);
					continue;
				case 53u:
					Availability.smethod_19((Control)(object)SearchBtn, new Size(133, 37));
					num = ((int)num2 * -353577239) ^ 0x54CC2DFA;
					continue;
				case 52u:
					Availability.smethod_24(Availability.smethod_23((Control)(object)DetailsBox), (Control)(object)Label4);
					num = ((int)num2 * -1582913203) ^ -648320868;
					continue;
				case 51u:
					Availability.smethod_29((ButtonBase)(object)DoctorBtn, "Doctor");
					Availability.smethod_30((ButtonBase)(object)DoctorBtn, bool_0: true);
					num = (int)((num2 * 1395502084) ^ 0x4C962C00);
					continue;
				case 50u:
					num = (int)(num2 * 99990889) ^ -1859277073;
					continue;
				case 49u:
					num = ((int)num2 * -1745614363) ^ 0x2EADD734;
					continue;
				case 48u:
					Availability.smethod_17((Control)(object)NurseBtn, new Point(174, 84));
					num = (int)((num2 * 803094975) ^ 0x4DEE780);
					continue;
				case 47u:
					num = ((int)num2 * -1587593705) ^ -2035815315;
					continue;
				case 46u:
					Availability.smethod_16((Control)(object)Label8, Availability.smethod_15("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1496614634) ^ 0x36B744FE;
					continue;
				case 45u:
					Availability.smethod_17((Control)(object)DOBTxt, new Point(479, 121));
					num = (int)((num2 * 1574874179) ^ 0x574FB9A4);
					continue;
				case 44u:
					num = ((int)num2 * -2076645096) ^ 0x39054285;
					continue;
				case 43u:
					ShowAvailability = Availability.smethod_4();
					num = (int)(num2 * 854661746) ^ -623674878;
					continue;
				case 42u:
					Availability.smethod_17((Control)(object)GenderTxt, new Point(479, 163));
					num = (int)(num2 * 1860238213) ^ -1316301284;
					continue;
				case 41u:
					num = (int)(num2 * 807220579) ^ -2014776132;
					continue;
				case 40u:
					num = (int)(num2 * 443507626) ^ -1642816150;
					continue;
				case 39u:
					Availability.smethod_17((Control)(object)Label6, new Point(389, 169));
					Availability.smethod_18((Control)(object)Label6, "Label6");
					num = ((int)num2 * -1518108523) ^ -193051086;
					continue;
				case 38u:
					Availability.smethod_28((Control)(object)ClearBtn, Color.White);
					num = ((int)num2 * -382738243) ^ -276611910;
					continue;
				case 37u:
					Availability.smethod_20((Control)(object)GroupBox1, 7);
					num = ((int)num2 * -1319611309) ^ -263706067;
					continue;
				case 36u:
					Availability.smethod_32(ReceptionistBtn, bool_0: true);
					num = ((int)num2 * -1368756049) ^ -482029292;
					continue;
				case 35u:
					Label6 = Availability.smethod_4();
					num = ((int)num2 * -1774830562) ^ 0x385EA2C9;
					continue;
				case 34u:
					Availability.smethod_16((Control)(object)Label9, Availability.smethod_15("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -551470709) ^ 0x579CEA42;
					continue;
				case 33u:
					Availability.smethod_16((Control)(object)Label1, Availability.smethod_15("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -950389704) ^ 0xEF74BEC;
					continue;
				case 32u:
					num = (int)(num2 * 742517162) ^ -1299703355;
					continue;
				case 31u:
					Availability.smethod_22(ShowAvailability, (ContentAlignment)32);
					Availability.smethod_17((Control)(object)DesignationTxt, new Point(428, 71));
					num = (int)(num2 * 1986382743) ^ -1522878965;
					continue;
				case 30u:
					num = ((int)num2 * -1410166404) ^ 0x36CA1752;
					continue;
				case 29u:
					DOBTxt = Availability.smethod_8();
					num = ((int)num2 * -1519650061) ^ 0x393379B;
					continue;
				case 28u:
					Label8 = Availability.smethod_4();
					num = (int)(num2 * 817453791) ^ -634034574;
					continue;
				case 27u:
					Availability.smethod_19((Control)(object)SearchResultGrid, new Size(853, 169));
					Availability.smethod_20((Control)(object)SearchResultGrid, 8);
					num = ((int)num2 * -1057315058) ^ 0x6E0D7717;
					continue;
				case 26u:
					Availability.smethod_21(Label4, "SID :");
					num = (int)((num2 * 1020770044) ^ 0x699C2534);
					continue;
				case 25u:
					Label9 = Availability.smethod_4();
					num = ((int)num2 * -1529492460) ^ 0x2DED3F9C;
					continue;
				case 24u:
					Availability.smethod_18((Control)(object)NurseBtn, "NurseBtn");
					num = ((int)num2 * -1715878221) ^ -871168580;
					continue;
				case 23u:
					num = ((int)num2 * -2083385532) ^ 0x3F0BACBC;
					continue;
				case 22u:
					Availability.smethod_24(Availability.smethod_23((Control)(object)DetailsBox), (Control)(object)AddressTxt);
					num = ((int)num2 * -2070486157) ^ -552012011;
					continue;
				case 21u:
					Availability.smethod_19((Control)(object)Label6, new Size(84, 26));
					num = ((int)num2 * -1383466334) ^ 0x7535D474;
					continue;
				case 20u:
					Availability.smethod_43(PictureBox1, 4);
					num = ((int)num2 * -521982716) ^ 0x7DE15F1C;
					continue;
				case 19u:
					Availability.smethod_21(Label3, "Designation : ");
					Availability.smethod_22(Label3, (ContentAlignment)32);
					num = ((int)num2 * -1199421596) ^ 0x3EA2B1BE;
					continue;
				case 18u:
					Availability.smethod_19((Control)(object)AddressTxt, new Size(483, 90));
					num = (int)((num2 * 1757049638) ^ 0x1AA830E6);
					continue;
				case 17u:
					num = (int)(num2 * 1061226146) ^ -509387885;
					continue;
				case 16u:
					Availability.smethod_51((Control)(object)DetailsBox);
					num = ((int)num2 * -348995266) ^ -957344544;
					continue;
				case 15u:
					Availability.smethod_24(Availability.smethod_47((Control)(object)this), (Control)(object)GroupBox1);
					num = ((int)num2 * -645890579) ^ -730218874;
					continue;
				case 14u:
					num = (int)(num2 * 1323618903) ^ -1004537964;
					continue;
				case 13u:
					Availability.smethod_20((Control)(object)NameSTxt, 1);
					num = ((int)num2 * -111875869) ^ 0xC423B;
					continue;
				case 12u:
					DesignationTxt = Availability.smethod_8();
					Label3 = Availability.smethod_4();
					MobileTxt = Availability.smethod_8();
					num = (int)((num2 * 1068756400) ^ 0x19B83D1D);
					continue;
				case 11u:
					Availability.smethod_39((TextBoxBase)(object)MobileTxt, bool_0: true);
					num = (int)(num2 * 158702429) ^ -1152508904;
					continue;
				case 10u:
					Availability.smethod_21(Label8, "Name : ");
					Availability.smethod_22(Label8, (ContentAlignment)32);
					num = (int)((num2 * 1536939035) ^ 0x6D221586);
					continue;
				case 9u:
					Availability.smethod_20((Control)(object)Label4, 0);
					num = (int)(num2 * 1818108827) ^ -1165343263;
					continue;
				case 8u:
					Availability.smethod_17((Control)(object)PictureBox1, new Point(260, 22));
					num = (int)(num2 * 1437085280) ^ -291774529;
					continue;
				case 7u:
					Availability.smethod_20((Control)(object)Label9, 11);
					num = (int)((num2 * 826058797) ^ 0x68E3B236);
					continue;
				case 6u:
					Availability.smethod_17((Control)(object)SearchBtn, new Point(467, 73));
					Availability.smethod_18((Control)(object)SearchBtn, "SearchBtn");
					num = ((int)num2 * -491018925) ^ -564733320;
					continue;
				case 5u:
					Availability.smethod_24(Availability.smethod_23((Control)(object)DetailsBox), (Control)(object)ShowAvailability);
					num = (int)((num2 * 479018531) ^ 0x132B787F);
					continue;
				case 4u:
					num = ((int)num2 * -1042825014) ^ -1182474975;
					continue;
				case 3u:
					Availability.smethod_31((ButtonBase)(object)NurseBtn, bool_0: true);
					num = (int)(num2 * 648304477) ^ -1131584377;
					continue;
				case 2u:
					Availability.smethod_40(AddressTxt, bool_0: true);
					num = (int)((num2 * 815049655) ^ 0x3B1B45F);
					continue;
				case 1u:
					Availability.smethod_27((ButtonBase)(object)SearchBtn, Color.MidnightBlue);
					num = ((int)num2 * -2012530889) ^ -1762831763;
					continue;
				case 0u:
					num = ((int)num2 * -492087987) ^ -1651729701;
					continue;
				default:
					return;
				case 100u:
					break;
				case 221u:
					return;
				}
				break;
			}
		}
	}

	private void Availability_Load(object sender, EventArgs e)
	{
		Availability.smethod_62(myconnection, Availability.smethod_61(MyProject.Forms.Form1.provider, MyProject.Forms.Form1.datafile));
		Designation = "";
		while (true)
		{
			int num = 122490771;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2A23F248u) % 4u)
				{
				case 3u:
					close();
					num = ((int)num2 * -1442793887) ^ -1024129347;
					continue;
				case 2u:
					num = (int)((num2 * 657120893) ^ 0x1189502F);
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
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected I4, but got Unknown
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected I4, but got Unknown
		//IL_02fc: Incompatible stack heights: 0 vs 1
		//IL_0317: Incompatible stack heights: 0 vs 1
		//IL_0327: Incompatible stack heights: 0 vs 1
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Incompatible stack heights: 0 vs 1
		//IL_035a: Incompatible stack heights: 0 vs 1
		//IL_0364: Incompatible stack heights: 0 vs 1
		bool flag2 = default(bool);
		DataTable dataTable_ = default(DataTable);
		OleDbDataAdapter dbDataAdapter_ = default(OleDbDataAdapter);
		bool flag = default(bool);
		while (true)
		{
			int num = -173058022;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x974CF48Eu) % 7u)
				{
				case 4u:
					flag2 = Availability.smethod_63(Designation, "", bool_0: false) == 0;
					num = ((int)num2 * -2146200690) ^ -1786641347;
					continue;
				case 3u:
				{
					int num6;
					int num7;
					if (flag2)
					{
						num6 = -544775157;
						num7 = -544775157;
					}
					else
					{
						num6 = -288694068;
						num7 = -288694068;
					}
					num = num6 ^ ((int)num2 * -957134251);
					continue;
				}
				case 2u:
					close();
					num = (int)(num2 * 1815142545) ^ -163735586;
					continue;
				case 1u:
					Availability.smethod_64("click designation");
					num = (int)(num2 * 547661793) ^ -404382884;
					continue;
				case 5u:
					break;
				default:
					try
					{
						while (true)
						{
							int num3 = -512330500;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x974CF48Eu) % 15u)
								{
								case 14u:
									num3 = ((int)num2 * -1419087265) ^ -345611600;
									continue;
								case 13u:
									dataTable_ = Availability.smethod_65();
									dbDataAdapter_ = Availability.smethod_66();
									Availability.smethod_67(myconnection);
									num3 = ((int)num2 * -1084391944) ^ 0x75217803;
									continue;
								case 12u:
									Availability.smethod_77((Control)(object)SearchResultGrid);
									Availability.smethod_76(myconnection);
									num3 = ((int)num2 * -821959344) ^ 0x1B279D80;
									continue;
								case 11u:
									dbDataAdapter_ = Availability.smethod_70(Availability.smethod_69(new string[5]
									{
										"Select * from Staff where Name like '%",
										Availability.smethod_68(NameSTxt),
										"%'  And   Designation = '",
										Designation,
										"'"
									}), myconnection);
									num3 = ((int)num2 * -1637944062) ^ 0x19798585;
									continue;
								case 10u:
									HideunusedColumns();
									num3 = (int)(num2 * 1338658866) ^ -502217366;
									continue;
								case 9u:
								{
									int num4;
									int num5;
									if (!flag)
									{
										num4 = -2130638986;
										num5 = -2130638986;
									}
									else
									{
										num4 = -1893985261;
										num5 = -1893985261;
									}
									num3 = num4 ^ ((int)num2 * -65452928);
									continue;
								}
								case 6u:
									Availability.smethod_76(myconnection);
									num3 = (int)(num2 * 535970560) ^ -1928327279;
									continue;
								case 5u:
									Availability.smethod_71((DbDataAdapter)(object)dbDataAdapter_, dataTable_);
									Availability.smethod_73(SearchResultGrid, (object)Availability.smethod_72(dataTable_));
									flag = Availability.smethod_74(SearchResultGrid) == 1;
									num3 = ((int)num2 * -527518453) ^ -1978216801;
									continue;
								case 4u:
									Availability.smethod_75("Not Found.", "Result");
									num3 = (int)(num2 * 452303925) ^ -154853259;
									continue;
								case 3u:
									num3 = (int)(num2 * 1917105647) ^ -1113200534;
									continue;
								case 2u:
									num3 = -1004883223;
									continue;
								case 1u:
									num3 = ((int)num2 * -394030126) ^ 0x47DFCA91;
									continue;
								default:
									return;
								case 0u:
									break;
								case 7u:
									return;
								case 8u:
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
							_ = -1315065330;
							while (true)
							{
								_003F val = /*Error near IL_02c6: Stack underflow*/^ -1756564338;
								num2 = (uint)(int)val;
								switch (val % 7)
								{
								default:
									return;
								case 6:
									_ = ((int)num2 * -726670012) ^ -1310879422;
									continue;
								case 4:
									Availability.smethod_76(myconnection);
									_ = ((int)num2 * -1085370480) ^ -1393387122;
									continue;
								case 3:
									_ = (num2 * 1528534878) ^ 0x28A72D4;
									continue;
								case 1:
									Availability.smethod_64("Incorrect Credentials");
									_ = ((int)num2 * -453913453) ^ 0x5F0B62AF;
									continue;
								case 0:
									Availability.smethod_79();
									_ = ((int)num2 * -709898010) ^ -1770535970;
									continue;
								case 5:
									break;
								case 2:
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
		Availability.smethod_82(Availability.smethod_81(Availability.smethod_80(SearchResultGrid), 7), bool_0: false);
		bool result = default(bool);
		while (true)
		{
			int num = -620832056;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8F5A1489u) % 4u)
				{
				case 2u:
					num = (int)((num2 * 1352790300) ^ 0xA3F1151);
					continue;
				case 1u:
					Availability.smethod_82(Availability.smethod_81(Availability.smethod_80(SearchResultGrid), 9), bool_0: false);
					result = false;
					num = (int)((num2 * 2100559122) ^ 0x62A59FC5);
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

	private void RadioButton1_CheckedChanged(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 1542229535;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4AAD8D9Au) % 3u)
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
				Designation = "Doctor";
				num = ((int)num2 * -640096520) ^ -1445336872;
			}
		}
	}

	private void RadioButton2_CheckedChanged(object sender, EventArgs e)
	{
		Designation = "Nurse";
	}

	private void RadioButton3_CheckedChanged(object sender, EventArgs e)
	{
		Designation = "Receptionist";
	}

	private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected I4, but got Unknown
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Expected I4, but got Unknown
		//IL_03ae: Incompatible stack heights: 0 vs 1
		//IL_03b5: Incompatible stack heights: 0 vs 1
		int int_ = default(int);
		while (true)
		{
			int num = 1568292458;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x606FA696u) % 5u)
				{
				case 3u:
					int_ = Availability.smethod_83(e);
					num = 1527601954;
					continue;
				case 1u:
				{
					int num6;
					int num7;
					if ((checked(Availability.smethod_83(e) + 1) == Availability.smethod_74(SearchResultGrid)) | (Availability.smethod_83(e) == -1))
					{
						num6 = 406812889;
						num7 = 406812889;
					}
					else
					{
						num6 = 1909132115;
						num7 = 1909132115;
					}
					num = num6 ^ (int)(num2 * 1908275926);
					continue;
				}
				case 2u:
					break;
				default:
					Availability.smethod_84((Control)(object)DetailsBox, bool_0: true);
					try
					{
						DataGridViewRow dataGridViewRow_ = Availability.smethod_85();
						while (true)
						{
							int num3 = 1660530411;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x606FA696u) % 20u)
								{
								case 19u:
									num3 = ((int)num2 * -468343999) ^ -1480544774;
									continue;
								case 18u:
									num3 = ((int)num2 * -68347168) ^ 0x1BF8903E;
									continue;
								case 17u:
									colourgreen();
									num3 = (int)((num2 * 2091247376) ^ 0x1EADC2CD);
									continue;
								case 16u:
									num3 = (int)(num2 * 1977813058) ^ -1981587579;
									continue;
								case 15u:
									num3 = (int)((num2 * 1864435640) ^ 0x47D9BC7D);
									continue;
								case 14u:
									Availability.smethod_92(DesignationTxt, Availability.smethod_91(Availability.smethod_90(Availability.smethod_89(Availability.smethod_88(dataGridViewRow_), 2))));
									num3 = (int)((num2 * 308577896) ^ 0x65D2763A);
									continue;
								case 13u:
									Availability.smethod_92(NameTxt, Availability.smethod_91(Availability.smethod_90(Availability.smethod_89(Availability.smethod_88(dataGridViewRow_), 1))));
									Availability.smethod_92(MobileTxt, Availability.smethod_91(Availability.smethod_90(Availability.smethod_89(Availability.smethod_88(dataGridViewRow_), 5))));
									num3 = (int)(num2 * 1144119245) ^ -1923581822;
									continue;
								case 12u:
									Availability.smethod_92(GenderTxt, Availability.smethod_91(Availability.smethod_90(Availability.smethod_89(Availability.smethod_88(dataGridViewRow_), 4))));
									num3 = (int)((num2 * 1581666233) ^ 0x5EE620AC);
									continue;
								case 11u:
									num3 = (int)((num2 * 287983557) ^ 0x593D706D);
									continue;
								case 10u:
									num3 = 108022079;
									continue;
								case 9u:
									Availability.smethod_92(AddressTxt, Availability.smethod_91(Availability.smethod_90(Availability.smethod_89(Availability.smethod_88(dataGridViewRow_), 6))));
									num3 = ((int)num2 * -291184995) ^ 0x1398FAB9;
									continue;
								case 8u:
									Availability.smethod_92(DOBTxt, Availability.smethod_93(Availability.smethod_90(Availability.smethod_89(Availability.smethod_88(dataGridViewRow_), 3))));
									num3 = ((int)num2 * -349090415) ^ 0xB61556C;
									continue;
								case 6u:
								{
									int num4;
									int num5;
									if (Availability.smethod_94((object)Shift(), Availability.smethod_90(Availability.smethod_89(Availability.smethod_88(dataGridViewRow_), 8)), bool_0: false))
									{
										num4 = -306997961;
										num5 = -306997961;
									}
									else
									{
										num4 = -1130434724;
										num5 = -1130434724;
									}
									num3 = num4 ^ ((int)num2 * -740274088);
									continue;
								}
								case 5u:
									dataGridViewRow_ = Availability.smethod_87(Availability.smethod_86(SearchResultGrid), int_);
									num3 = (int)((num2 * 673490646) ^ 0x66442C5F);
									continue;
								case 4u:
									num3 = ((int)num2 * -1210124668) ^ -139630606;
									continue;
								case 3u:
									Availability.smethod_92(SIDTxt, Availability.smethod_91(Availability.smethod_90(Availability.smethod_89(Availability.smethod_88(dataGridViewRow_), 0))));
									num3 = ((int)num2 * -1089305768) ^ 0x192FEE7B;
									continue;
								case 2u:
									num3 = ((int)num2 * -2016018365) ^ -1042791986;
									continue;
								case 1u:
									colourred();
									num3 = (int)((num2 * 1258332272) ^ 0x57ED0191);
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
					catch (Exception exception_)
					{
						Availability.smethod_78(exception_);
						while (true)
						{
							_ = 2029012461;
							while (true)
							{
								_003F val = /*Error near IL_0383: Stack underflow*/^ 0x606FA696;
								num2 = (uint)(int)val;
								switch (val % 3)
								{
								default:
									return;
								case 2:
									Availability.smethod_79();
									_ = ((int)num2 * -1015677785) ^ 0x6EBC2D95;
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

	private void close()
	{
		while (true)
		{
			int num = 25054395;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x200E77E3u) % 5u)
				{
				case 2u:
					Availability.smethod_84((Control)(object)DetailsBox, bool_0: false);
					num = (int)((num2 * 157809939) ^ 0xF430574);
					continue;
				case 1u:
					num = ((int)num2 * -1645285745) ^ 0x4F3AC4C6;
					continue;
				case 0u:
					Availability.smethod_95((Control)(object)SearchResultGrid);
					num = ((int)num2 * -1298211327) ^ -2078454948;
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

	private void Button2_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 664911101;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBA88D2u) % 10u)
				{
				case 8u:
					num = (int)(num2 * 276398825) ^ -1132026528;
					continue;
				case 7u:
					num = (int)((num2 * 1753717397) ^ 0x3A160B5F);
					continue;
				case 6u:
					num = (int)(num2 * 603353289) ^ -801221763;
					continue;
				case 5u:
					Availability.smethod_96((TextBoxBase)(object)NameSTxt);
					num = (int)(num2 * 1562757867) ^ -1066386339;
					continue;
				case 4u:
					Availability.smethod_95((Control)(object)SearchResultGrid);
					num = ((int)num2 * -1328326404) ^ -1030814627;
					continue;
				case 2u:
					Availability.smethod_97(DoctorBtn, bool_0: false);
					num = ((int)num2 * -322379254) ^ 0x5BC50096;
					continue;
				case 1u:
					Availability.smethod_84((Control)(object)DetailsBox, bool_0: false);
					Designation = "";
					num = (int)((num2 * 880476590) ^ 0x38E28C11);
					continue;
				case 0u:
					Availability.smethod_97(NurseBtn, bool_0: false);
					Availability.smethod_97(ReceptionistBtn, bool_0: false);
					num = (int)(num2 * 202000159) ^ -542172660;
					continue;
				default:
					return;
				case 9u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	private string Shift()
	{
		bool flag = (day >= 7) & (day <= 19);
		string result = default(string);
		while (true)
		{
			int num = -2131483191;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDF9E08C1u) % 5u)
				{
				case 4u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 2134311449;
						num4 = 2134311449;
					}
					else
					{
						num3 = 206847226;
						num4 = 206847226;
					}
					num = num3 ^ (int)(num2 * 689542511);
					continue;
				}
				case 3u:
					result = "Night";
					num = -457407316;
					continue;
				case 1u:
					result = "Day";
					num = ((int)num2 * -1283117225) ^ -558147892;
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

	private void colourgreen()
	{
		Availability.smethod_38((Control)(object)ShowAvailability, Color.Green);
		Availability.smethod_21(ShowAvailability, "Available");
	}

	private void colourred()
	{
		Availability.smethod_38((Control)(object)ShowAvailability, Color.Red);
		while (true)
		{
			int num = -1644063550;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF0C3A777u) % 3u)
				{
				case 2u:
					goto IL_0012;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0012:
				Availability.smethod_21(ShowAvailability, "Unavailable");
				num = (int)((num2 * 960743517) ^ 0xC6D8107);
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
