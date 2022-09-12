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
public class UpdateStaff_Admin : UserControl
{
	private IContainer components;

	private string Designation;

	private OleDbConnection myconnection;

	private int day;

	private int selectrow;

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
				int num = 1373251611;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x689F3841u) % 8u)
					{
					case 7u:
					{
						int num5;
						int num6;
						if (clearBtn != null)
						{
							num5 = 712985839;
							num6 = 712985839;
						}
						else
						{
							num5 = 964162310;
							num6 = 964162310;
						}
						num = num5 ^ ((int)num2 * -1344453595);
						continue;
					}
					case 5u:
						UpdateStaff_Admin.smethod_63((Control)(object)clearBtn, eventHandler_);
						num = ((int)num2 * -1636562305) ^ -1331282730;
						continue;
					case 3u:
						_ClearBtn = value;
						num = 1859712969;
						continue;
					case 2u:
					{
						clearBtn = _ClearBtn;
						int num3;
						int num4;
						if (clearBtn == null)
						{
							num3 = -976620640;
							num4 = -976620640;
						}
						else
						{
							num3 = -186497606;
							num4 = -186497606;
						}
						num = num3 ^ (int)(num2 * 80299625);
						continue;
					}
					case 1u:
						UpdateStaff_Admin.smethod_62((Control)(object)clearBtn, eventHandler_);
						num = ((int)num2 * -860201455) ^ -602169493;
						continue;
					case 0u:
						clearBtn = _ClearBtn;
						num = ((int)num2 * -212011160) ^ -288243346;
						continue;
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

	internal virtual RadioButton Receptionistbtn
	{
		[CompilerGenerated]
		get
		{
			return _Receptionistbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = RadioButton3_CheckedChanged;
			RadioButton receptionistbtn = _Receptionistbtn;
			if (receptionistbtn != null)
			{
				goto IL_006c;
			}
			goto IL_009a;
			IL_009a:
			_Receptionistbtn = value;
			receptionistbtn = _Receptionistbtn;
			int num = -1337472804;
			goto IL_0071;
			IL_0071:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x97758AA4u) % 6u)
				{
				case 5u:
					UpdateStaff_Admin.smethod_64(receptionistbtn, eventHandler_);
					num = ((int)num2 * -748003679) ^ 0x7FB69402;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (receptionistbtn != null)
					{
						num3 = 145529349;
						num4 = 145529349;
					}
					else
					{
						num3 = 2038743132;
						num4 = 2038743132;
					}
					num = num3 ^ (int)(num2 * 2103387615);
					continue;
				}
				case 1u:
					UpdateStaff_Admin.smethod_65(receptionistbtn, eventHandler_);
					num = (int)((num2 * 279994025) ^ 0x42C79C5);
					continue;
				case 0u:
					break;
				default:
					return;
				case 3u:
					goto IL_009a;
				case 4u:
					return;
				}
				break;
			}
			goto IL_006c;
			IL_006c:
			num = -386941517;
			goto IL_0071;
		}
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
			while (true)
			{
				int num = 350771313;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2F8FACF7u) % 8u)
					{
					case 7u:
						nurseBtn = _NurseBtn;
						num = ((int)num2 * -1694660878) ^ -721094934;
						continue;
					case 6u:
					{
						int num5;
						int num6;
						if (nurseBtn == null)
						{
							num5 = -1122239237;
							num6 = -1122239237;
						}
						else
						{
							num5 = -2067643763;
							num6 = -2067643763;
						}
						num = num5 ^ ((int)num2 * -871599959);
						continue;
					}
					case 4u:
						UpdateStaff_Admin.smethod_64(nurseBtn, eventHandler_);
						num = (int)(num2 * 1512205445) ^ -349671247;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (nurseBtn == null)
						{
							num3 = 45744975;
							num4 = 45744975;
						}
						else
						{
							num3 = 577125814;
							num4 = 577125814;
						}
						num = num3 ^ ((int)num2 * -1973218440);
						continue;
					}
					case 2u:
						_NurseBtn = value;
						num = 891415960;
						continue;
					case 1u:
						UpdateStaff_Admin.smethod_65(nurseBtn, eventHandler_);
						num = (int)((num2 * 751109650) ^ 0x51DCEE45);
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
				int num = -934222738;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFA7F4450u) % 7u)
					{
					case 6u:
					{
						doctorBtn = _DoctorBtn;
						int num5;
						int num6;
						if (doctorBtn == null)
						{
							num5 = -433555941;
							num6 = -433555941;
						}
						else
						{
							num5 = -1358395213;
							num6 = -1358395213;
						}
						num = num5 ^ ((int)num2 * -1110642059);
						continue;
					}
					case 5u:
						_DoctorBtn = value;
						num = -1647524825;
						continue;
					case 2u:
						UpdateStaff_Admin.smethod_65(doctorBtn, eventHandler_);
						num = ((int)num2 * -368261429) ^ 0x6FB8B2F8;
						continue;
					case 1u:
						UpdateStaff_Admin.smethod_64(doctorBtn, eventHandler_);
						num = (int)(num2 * 382732967) ^ -909297058;
						continue;
					case 0u:
					{
						doctorBtn = _DoctorBtn;
						int num3;
						int num4;
						if (doctorBtn == null)
						{
							num3 = -1369213005;
							num4 = -1369213005;
						}
						else
						{
							num3 = -636689389;
							num4 = -636689389;
						}
						num = num3 ^ (int)(num2 * 2119033257);
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
			Button searchBtn = _SearchBtn;
			while (true)
			{
				int num = 728655273;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5BBDCEu) % 7u)
					{
					case 5u:
						_SearchBtn = value;
						searchBtn = _SearchBtn;
						num = 653558828;
						continue;
					case 4u:
						UpdateStaff_Admin.smethod_63((Control)(object)searchBtn, eventHandler_);
						num = (int)(num2 * 194805640) ^ -902178544;
						continue;
					case 3u:
					{
						int num5;
						int num6;
						if (searchBtn == null)
						{
							num5 = -706595927;
							num6 = -706595927;
						}
						else
						{
							num5 = -1212278730;
							num6 = -1212278730;
						}
						num = num5 ^ ((int)num2 * -943874016);
						continue;
					}
					case 2u:
					{
						int num3;
						int num4;
						if (searchBtn != null)
						{
							num3 = -1513226611;
							num4 = -1513226611;
						}
						else
						{
							num3 = -1121658876;
							num4 = -1121658876;
						}
						num = num3 ^ (int)(num2 * 313512406);
						continue;
					}
					case 1u:
						UpdateStaff_Admin.smethod_62((Control)(object)searchBtn, eventHandler_);
						num = (int)((num2 * 1758870998) ^ 0x21808D59);
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
				int num = 1090412368;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1463FAD5u) % 7u)
					{
					case 6u:
						_SearchResultGrid = value;
						num = 199879851;
						continue;
					case 5u:
						UpdateStaff_Admin.smethod_67(searchResultGrid, dataGridViewCellMouseEventHandler_);
						num = ((int)num2 * -1508476012) ^ -221287008;
						continue;
					case 4u:
						UpdateStaff_Admin.smethod_66(searchResultGrid, dataGridViewCellMouseEventHandler_);
						num = (int)((num2 * 2030918069) ^ 0x7AB7FB14);
						continue;
					case 3u:
					{
						searchResultGrid = _SearchResultGrid;
						int num5;
						int num6;
						if (searchResultGrid == null)
						{
							num5 = 426333452;
							num6 = 426333452;
						}
						else
						{
							num5 = 1414135326;
							num6 = 1414135326;
						}
						num = num5 ^ ((int)num2 * -2043433560);
						continue;
					}
					case 1u:
					{
						searchResultGrid = _SearchResultGrid;
						int num3;
						int num4;
						if (searchResultGrid != null)
						{
							num3 = 1418976906;
							num4 = 1418976906;
						}
						else
						{
							num3 = 933169675;
							num4 = 933169675;
						}
						num = num3 ^ ((int)num2 * -1962851293);
						continue;
					}
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
	}

	[field: AccessedThroughProperty("DetailsBox")]
	internal virtual GroupBox DetailsBox
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
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

	[field: AccessedThroughProperty("EmailTxt")]
	internal virtual TextBox EmailTxt
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

	[field: AccessedThroughProperty("NameTxt")]
	internal virtual TextBox NameTxt
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

	[field: AccessedThroughProperty("SIDTxt")]
	internal virtual TextBox SIDTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label11")]
	internal virtual Label Label11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label12")]
	internal virtual Label Label12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("WorkShiftTxt")]
	internal virtual ComboBox WorkShiftTxt
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
			EventHandler eventHandler_ = UpadateBtn_Click;
			Button updateBtn = _UpdateBtn;
			while (true)
			{
				int num = -1488198469;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA4993362u) % 8u)
					{
					case 7u:
						UpdateStaff_Admin.smethod_62((Control)(object)updateBtn, eventHandler_);
						num = ((int)num2 * -1484901895) ^ 0x4441B741;
						continue;
					case 6u:
						updateBtn = _UpdateBtn;
						num = (int)(num2 * 1532953897) ^ -1970749385;
						continue;
					case 4u:
						_UpdateBtn = value;
						num = -1413485564;
						continue;
					case 3u:
					{
						int num5;
						int num6;
						if (updateBtn == null)
						{
							num5 = 1992933252;
							num6 = 1992933252;
						}
						else
						{
							num5 = 1810229419;
							num6 = 1810229419;
						}
						num = num5 ^ ((int)num2 * -1103064415);
						continue;
					}
					case 2u:
						UpdateStaff_Admin.smethod_63((Control)(object)updateBtn, eventHandler_);
						num = (int)(num2 * 1937670679) ^ -596450399;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (updateBtn != null)
						{
							num3 = 1813315768;
							num4 = 1813315768;
						}
						else
						{
							num3 = 646977107;
							num4 = 646977107;
						}
						num = num3 ^ (int)(num2 * 1328945397);
						continue;
					}
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
				int num = -1766191202;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB4006DFBu) % 9u)
					{
					case 8u:
						UpdateStaff_Admin.smethod_63((Control)(object)deleteBtn, eventHandler_);
						num = ((int)num2 * -1891104065) ^ 0x261010B7;
						continue;
					case 7u:
						deleteBtn = _DeleteBtn;
						num = (int)(num2 * 557283732) ^ -479260862;
						continue;
					case 6u:
						UpdateStaff_Admin.smethod_62((Control)(object)deleteBtn, eventHandler_);
						num = ((int)num2 * -1175343361) ^ 0x504741E2;
						continue;
					case 5u:
					{
						int num5;
						int num6;
						if (deleteBtn == null)
						{
							num5 = -1621240258;
							num6 = -1621240258;
						}
						else
						{
							num5 = -1621584679;
							num6 = -1621584679;
						}
						num = num5 ^ ((int)num2 * -1253998729);
						continue;
					}
					case 2u:
						deleteBtn = _DeleteBtn;
						num = ((int)num2 * -801951729) ^ 0x7AD5403B;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (deleteBtn == null)
						{
							num3 = -1027612980;
							num4 = -1027612980;
						}
						else
						{
							num3 = -794021570;
							num4 = -794021570;
						}
						num = num3 ^ ((int)num2 * -576628164);
						continue;
					}
					case 0u:
						_DeleteBtn = value;
						num = -189453925;
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

	[field: AccessedThroughProperty("DOBTxt")]
	internal virtual DateTimePicker DOBTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DesignationTxt")]
	internal virtual ComboBox DesignationTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GenderTxt")]
	internal virtual ComboBox GenderTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public UpdateStaff_Admin()
	{
		while (true)
		{
			int num = -682796401;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCB3E2D6Eu) % 8u)
				{
				case 6u:
					myconnection = UpdateStaff_Admin.smethod_1();
					day = UpdateStaff_Admin.smethod_2(DateTime.Now.ToString("HH"));
					num = ((int)num2 * -181136088) ^ 0x47868E04;
					continue;
				case 5u:
					UpdateStaff_Admin.smethod_0((UserControl)(object)this, (EventHandler)UpdateStaff_Admin_Load);
					num = (int)((num2 * 1629031586) ^ 0x5C436BF0);
					continue;
				case 4u:
					num = (int)((num2 * 856778934) ^ 0x62692B70);
					continue;
				case 2u:
					InitializeComponent();
					num = (int)((num2 * 958848985) ^ 0x7C958274);
					continue;
				case 1u:
					num = (int)((num2 * 2071719563) ^ 0x38128530);
					continue;
				case 0u:
					num = (int)((num2 * 1769418072) ^ 0x40EDCDD5);
					continue;
				default:
					return;
				case 7u:
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
			while (true)
			{
				int num = -747858198;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0xBCF67F96u) % 7u)
					{
					case 6u:
						num = -1140602631;
						continue;
					case 5u:
						if (disposing)
						{
							num = ((int)num2 * -366303348) ^ 0x29D78802;
							continue;
						}
						goto IL_002f;
					case 4u:
						if (components != null)
						{
							num = -1858162597;
							num3 = -1858162597;
							continue;
						}
						goto IL_002f;
					case 2u:
						num = ((int)num2 * -522010669) ^ 0x15C72930;
						continue;
					case 1u:
						UpdateStaff_Admin.smethod_3((IDisposable)components);
						num = ((int)num2 * -482938357) ^ -1862712148;
						continue;
					default:
						return;
					case 0u:
						break;
					case 3u:
						return;
						IL_002f:
						num = -272838177;
						num3 = -272838177;
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
		PictureBox1 = UpdateStaff_Admin.smethod_4();
		while (true)
		{
			int num = -1360446873;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x860005FDu) % 371u)
				{
				case 370u:
					UpdateStaff_Admin.smethod_18((Control)(object)NurseBtn, "NurseBtn");
					num = ((int)num2 * -547175177) ^ -1537507184;
					continue;
				case 369u:
					UpdateStaff_Admin.smethod_35((ButtonBase)(object)DeleteBtn, bool_0: false);
					num = (int)((num2 * 342199653) ^ 0x2B892CC1);
					continue;
				case 368u:
					num = (int)(num2 * 1250459779) ^ -1696721843;
					continue;
				case 367u:
					UpdateStaff_Admin.smethod_17((Control)(object)Label8, new Point(16, 78));
					num = (int)(num2 * 743345600) ^ -1820766835;
					continue;
				case 366u:
					UpdateStaff_Admin.smethod_34((ButtonBase)(object)UpdateBtn, "Update");
					UpdateStaff_Admin.smethod_35((ButtonBase)(object)UpdateBtn, bool_0: false);
					num = (int)(num2 * 356582044) ^ -1970861905;
					continue;
				case 365u:
					UpdateStaff_Admin.smethod_17((Control)(object)SearchResultGrid, new Point(59, 295));
					num = (int)((num2 * 631733287) ^ 0x7E243DC8);
					continue;
				case 364u:
					UpdateStaff_Admin.smethod_19((Control)(object)UpdateBtn, new Size(122, 33));
					num = (int)(num2 * 471257176) ^ -1592939522;
					continue;
				case 363u:
					num = ((int)num2 * -1675474562) ^ -524230023;
					continue;
				case 362u:
					UpdateStaff_Admin.smethod_17((Control)(object)SearchBtn, new Point(467, 73));
					num = (int)(num2 * 1147182627) ^ -1522795518;
					continue;
				case 361u:
					UpdateStaff_Admin.smethod_26(Label5, "D.O.B. :");
					num = ((int)num2 * -200828992) ^ 0x5D9ACFE7;
					continue;
				case 360u:
					num = ((int)num2 * -244072211) ^ -201769460;
					continue;
				case 359u:
					Label11 = UpdateStaff_Admin.smethod_5();
					num = (int)((num2 * 1705104161) ^ 0x60D0798A);
					continue;
				case 358u:
					UpdateStaff_Admin.smethod_18((Control)(object)WorkShiftTxt, "WorkShiftTxt");
					num = (int)((num2 * 1502423061) ^ 0x66978115);
					continue;
				case 357u:
					UpdateStaff_Admin.smethod_18((Control)(object)Label7, "Label7");
					num = ((int)num2 * -79383024) ^ -1181647797;
					continue;
				case 356u:
					UpdateStaff_Admin.smethod_18((Control)(object)MobileTxt, "MobileTxt");
					num = (int)((num2 * 1503617310) ^ 0x45748684);
					continue;
				case 355u:
					num = (int)(num2 * 1297111477) ^ -2004860659;
					continue;
				case 354u:
					num = ((int)num2 * -936505772) ^ -1326136238;
					continue;
				case 353u:
					UpdateStaff_Admin.smethod_17((Control)(object)MobileTxt, new Point(124, 169));
					num = (int)(num2 * 1935644791) ^ -1030034113;
					continue;
				case 352u:
					num = ((int)num2 * -1478200997) ^ 0x1B205412;
					continue;
				case 351u:
					UpdateStaff_Admin.smethod_25((Control)(object)GenderTxt, 21);
					num = ((int)num2 * -720581124) ^ -634595990;
					continue;
				case 350u:
					UpdateStaff_Admin.smethod_25((Control)(object)Label5, 1);
					num = ((int)num2 * -597168499) ^ -59283557;
					continue;
				case 349u:
					num = (int)((num2 * 923020051) ^ 0x2CFEAD6);
					continue;
				case 348u:
					num = (int)((num2 * 1856651804) ^ 0x1E67AAE7);
					continue;
				case 347u:
					num = (int)((num2 * 404337804) ^ 0x4C387D02);
					continue;
				case 346u:
					UpdateStaff_Admin.smethod_18((Control)(object)NameTxt, "NameTxt");
					num = ((int)num2 * -1903650422) ^ -1041948072;
					continue;
				case 345u:
					UpdateStaff_Admin.smethod_19((Control)(object)MobileTxt, new Size(271, 28));
					UpdateStaff_Admin.smethod_25((Control)(object)MobileTxt, 12);
					UpdateStaff_Admin.smethod_24((Control)(object)Label9, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1821789238) ^ -114548030;
					continue;
				case 344u:
					UpdateStaff_Admin.smethod_25((Control)(object)DoctorBtn, 5);
					num = ((int)num2 * -807282781) ^ -304791468;
					continue;
				case 343u:
					UpdateStaff_Admin.smethod_24((Control)(object)Label3, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					UpdateStaff_Admin.smethod_17((Control)(object)Label3, new Point(367, 72));
					num = (int)((num2 * 1425632141) ^ 0x4B4A89C3);
					continue;
				case 342u:
					Label6 = UpdateStaff_Admin.smethod_5();
					num = ((int)num2 * -1182052749) ^ -387375676;
					continue;
				case 341u:
					UpdateStaff_Admin.smethod_46(WorkShiftTxt, (ComboBoxStyle)2);
					num = (int)(num2 * 569953438) ^ -2133393108;
					continue;
				case 340u:
					UpdateStaff_Admin.smethod_18((Control)(object)Label9, "Label9");
					num = ((int)num2 * -1006780274) ^ 0x13F9C3C;
					continue;
				case 339u:
					num = (int)(num2 * 611968888) ^ -1027353706;
					continue;
				case 338u:
					NameSTxt = UpdateStaff_Admin.smethod_9();
					num = ((int)num2 * -276253126) ^ 0x3AD72CB;
					continue;
				case 337u:
					num = ((int)num2 * -763712629) ^ 0x3F1F32A6;
					continue;
				case 336u:
					UpdateStaff_Admin.smethod_25((Control)(object)DOBTxt, 18);
					num = (int)(num2 * 1222007202) ^ -675570770;
					continue;
				case 335u:
					UpdateStaff_Admin.smethod_24((Control)(object)NurseBtn, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1826339587) ^ -1511173568;
					continue;
				case 334u:
					UpdateStaff_Admin.smethod_25((Control)(object)UpdateBtn, 16);
					num = ((int)num2 * -625475142) ^ 0xF1E6B57;
					continue;
				case 333u:
					num = ((int)num2 * -656277299) ^ -727080441;
					continue;
				case 332u:
					UpdateStaff_Admin.smethod_35((ButtonBase)(object)SearchBtn, bool_0: false);
					num = (int)((num2 * 990011904) ^ 0x7474457B);
					continue;
				case 331u:
					num = ((int)num2 * -1406270442) ^ 0x4EF37CF2;
					continue;
				case 330u:
					UpdateStaff_Admin.smethod_24((Control)(object)Label6, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1486402917) ^ -907076382;
					continue;
				case 329u:
					UpdateStaff_Admin.smethod_46(DesignationTxt, (ComboBoxStyle)2);
					num = (int)((num2 * 228634641) ^ 0x7937A611);
					continue;
				case 328u:
					UpdateStaff_Admin.smethod_25((Control)(object)ClearBtn, 8);
					UpdateStaff_Admin.smethod_34((ButtonBase)(object)ClearBtn, "Clear");
					num = ((int)num2 * -2065665923) ^ 0x7E49B29D;
					continue;
				case 327u:
					UpdateBtn = UpdateStaff_Admin.smethod_7();
					num = (int)((num2 * 530662849) ^ 0x564F15B5);
					continue;
				case 326u:
					UpdateStaff_Admin.smethod_46(GenderTxt, (ComboBoxStyle)2);
					num = ((int)num2 * -1489476586) ^ -37331509;
					continue;
				case 325u:
					UpdateStaff_Admin.smethod_18((Control)(object)Label1, "Label1");
					num = (int)((num2 * 331251352) ^ 0x46ED869);
					continue;
				case 324u:
					num = (int)(num2 * 1393014063) ^ -1255734987;
					continue;
				case 323u:
					UpdateStaff_Admin.smethod_18((Control)(object)GroupBox1, "GroupBox1");
					num = ((int)num2 * -651324896) ^ 0x50EF03FF;
					continue;
				case 322u:
					UpdateStaff_Admin.smethod_25((Control)(object)NameTxt, 4);
					num = ((int)num2 * -1478693984) ^ -2050822276;
					continue;
				case 321u:
					UpdateStaff_Admin.smethod_19((Control)(object)NameTxt, new Size(237, 28));
					num = (int)(num2 * 375292475) ^ -1024213063;
					continue;
				case 320u:
					Label5 = UpdateStaff_Admin.smethod_5();
					Label4 = UpdateStaff_Admin.smethod_5();
					num = (int)(num2 * 138557516) ^ -227433124;
					continue;
				case 319u:
					UpdateStaff_Admin.smethod_17((Control)(object)Label6, new Point(417, 169));
					UpdateStaff_Admin.smethod_18((Control)(object)Label6, "Label6");
					num = (int)(num2 * 2051260948) ^ -799560503;
					continue;
				case 318u:
					UpdateStaff_Admin.smethod_18((Control)(object)DoctorBtn, "DoctorBtn");
					num = ((int)num2 * -854217095) ^ 0x5D2E159C;
					continue;
				case 317u:
					UpdateStaff_Admin.smethod_49(UpdateStaff_Admin.smethod_48(DesignationTxt), new object[4] { "Doctor", "Nurse", "Receptionist", "Admin" });
					num = ((int)num2 * -788070007) ^ -1462362121;
					continue;
				case 316u:
					UpdateStaff_Admin.smethod_17((Control)(object)GroupBox1, new Point(155, 150));
					num = ((int)num2 * -1067486994) ^ -885906792;
					continue;
				case 315u:
					num = (int)(num2 * 1811798047) ^ -1974557434;
					continue;
				case 314u:
					UpdateStaff_Admin.smethod_61((Control)(object)this, bool_0: false);
					num = ((int)num2 * -2123909237) ^ -2077942820;
					continue;
				case 313u:
					UpdateStaff_Admin.smethod_25((Control)(object)ShowAvailability, 15);
					num = (int)((num2 * 1890894129) ^ 0x5FBB82B0);
					continue;
				case 312u:
					num = ((int)num2 * -328157396) ^ -1431061216;
					continue;
				case 311u:
					UpdateStaff_Admin.smethod_25((Control)(object)Label8, 9);
					num = (int)((num2 * 944426282) ^ 0x354281BA);
					continue;
				case 310u:
					UpdateStaff_Admin.smethod_17((Control)(object)Label11, new Point(16, 36));
					num = ((int)num2 * -1443765786) ^ 0x6F41BC9A;
					continue;
				case 309u:
					UpdateStaff_Admin.smethod_19((Control)(object)DOBTxt, new Size(171, 28));
					num = ((int)num2 * -2083386664) ^ -2023495792;
					continue;
				case 308u:
					UpdateStaff_Admin.smethod_18((Control)(object)Label8, "Label8");
					num = ((int)num2 * -459103648) ^ 0x550A353C;
					continue;
				case 307u:
					UpdateStaff_Admin.smethod_19((Control)(object)Label5, new Size(84, 26));
					num = (int)(num2 * 1437716857) ^ -961172937;
					continue;
				case 306u:
					Label3 = UpdateStaff_Admin.smethod_5();
					num = ((int)num2 * -448294213) ^ -1639277630;
					continue;
				case 305u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)Label11);
					num = ((int)num2 * -362027277) ^ -1290420647;
					continue;
				case 304u:
					num = (int)(num2 * 466523052) ^ -1339701188;
					continue;
				case 303u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)Label7);
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)Label6);
					num = ((int)num2 * -1671217564) ^ -1903410564;
					continue;
				case 302u:
					NurseBtn = UpdateStaff_Admin.smethod_8();
					num = ((int)num2 * -617448788) ^ 0x5199A6F7;
					continue;
				case 301u:
					UpdateStaff_Admin.smethod_17((Control)(object)Label7, new Point(16, 217));
					num = (int)((num2 * 1579378772) ^ 0x5955FCF3);
					continue;
				case 300u:
					num = (int)(num2 * 359482975) ^ -330607080;
					continue;
				case 299u:
					UpdateStaff_Admin.smethod_19((Control)(object)ShowAvailability, new Size(204, 23));
					num = (int)(num2 * 501153366) ^ -1117269170;
					continue;
				case 298u:
					UpdateStaff_Admin.smethod_25((Control)(object)Label3, 13);
					num = (int)((num2 * 1385493297) ^ 0xABBA1E7);
					continue;
				case 297u:
					num = (int)((num2 * 193836017) ^ 0x211B48AB);
					continue;
				case 296u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)EmailTxt);
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)Label8);
					num = ((int)num2 * -1323601396) ^ -1713462338;
					continue;
				case 295u:
					UpdateStaff_Admin.smethod_27(Label2, (ContentAlignment)32);
					UpdateStaff_Admin.smethod_38(SearchResultGrid, Color.White);
					num = (int)(num2 * 289268435) ^ -835839374;
					continue;
				case 294u:
					num = (int)((num2 * 436731969) ^ 0x48ED6DC7);
					continue;
				case 293u:
					num = (int)(num2 * 893480547) ^ -404039438;
					continue;
				case 292u:
					UpdateStaff_Admin.smethod_19((Control)(object)DeleteBtn, new Size(122, 33));
					num = (int)(num2 * 150311172) ^ -640967730;
					continue;
				case 291u:
					num = ((int)num2 * -1182849790) ^ 0x17E1E8FB;
					continue;
				case 290u:
					UpdateStaff_Admin.smethod_26(Label3, "Designation : ");
					num = ((int)num2 * -899928539) ^ -7680952;
					continue;
				case 289u:
					UpdateStaff_Admin.smethod_17((Control)(object)ShowAvailability, new Point(450, 24));
					num = (int)(num2 * 443298961) ^ -1015739458;
					continue;
				case 288u:
					num = (int)(num2 * 818405097) ^ -835160109;
					continue;
				case 287u:
					UpdateStaff_Admin.smethod_18((Control)(object)Label4, "Label4");
					num = (int)(num2 * 424909790) ^ -59430736;
					continue;
				case 286u:
					UpdateStaff_Admin.smethod_25((Control)(object)SearchResultGrid, 9);
					num = ((int)num2 * -1700489302) ^ -1982519979;
					continue;
				case 285u:
					UpdateStaff_Admin.smethod_24((Control)(object)Label7, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 446982494) ^ -1049782570;
					continue;
				case 284u:
					UpdateStaff_Admin.smethod_17((Control)(object)DeleteBtn, new Point(790, 680));
					num = (int)((num2 * 2119186575) ^ 0x57C24756);
					continue;
				case 283u:
					UpdateStaff_Admin.smethod_25((Control)(object)EmailTxt, 10);
					num = (int)(num2 * 1611574561) ^ -560036444;
					continue;
				case 282u:
					UpdateStaff_Admin.smethod_18((Control)(object)ShowAvailability, "ShowAvailability");
					num = ((int)num2 * -839546934) ^ -1486993291;
					continue;
				case 281u:
					UpdateStaff_Admin.smethod_26(Label12, "Work Shift : ");
					num = (int)((num2 * 1812885751) ^ 0x41B1982E);
					continue;
				case 280u:
					num = (int)(num2 * 716588544) ^ -1241639975;
					continue;
				case 279u:
					UpdateStaff_Admin.smethod_60((Control)(object)GroupBox1);
					num = (int)(num2 * 1304506740) ^ -798910004;
					continue;
				case 278u:
					num = (int)((num2 * 401401477) ^ 0xD5FC19F);
					continue;
				case 277u:
					DetailsBox = UpdateStaff_Admin.smethod_6();
					num = ((int)num2 * -1569589439) ^ 0x50525FE2;
					continue;
				case 276u:
					UpdateStaff_Admin.smethod_19((Control)(object)GroupBox1, new Size(623, 127));
					num = (int)((num2 * 302682709) ^ 0x75725041);
					continue;
				case 275u:
					num = ((int)num2 * -1607853992) ^ -36382936;
					continue;
				case 274u:
					num = ((int)num2 * -1043942120) ^ -492030595;
					continue;
				case 273u:
					num = ((int)num2 * -1232050226) ^ 0x578F0424;
					continue;
				case 272u:
					UpdateStaff_Admin.smethod_47((ListControl)(object)GenderTxt, bool_0: true);
					num = (int)(num2 * 1025263638) ^ -1224142469;
					continue;
				case 271u:
					UpdateStaff_Admin.smethod_32((ButtonBase)(object)DeleteBtn, Color.MidnightBlue);
					num = (int)(num2 * 394305738) ^ -1150640226;
					continue;
				case 270u:
					num = (int)((num2 * 1612666728) ^ 0xB0CF3A4);
					continue;
				case 269u:
					UpdateStaff_Admin.smethod_17((Control)(object)UpdateBtn, new Point(790, 608));
					num = (int)(num2 * 477904036) ^ -816073725;
					continue;
				case 268u:
					UpdateStaff_Admin.smethod_44(DOBTxt, new DateTime(1900, 1, 1, 0, 0, 0, 0));
					num = (int)(num2 * 796291665) ^ -1231118413;
					continue;
				case 267u:
					num = (int)((num2 * 375207049) ^ 0x2DE93A3);
					continue;
				case 266u:
					UpdateStaff_Admin.smethod_25((Control)(object)NameSTxt, 1);
					num = ((int)num2 * -1525215659) ^ -516030875;
					continue;
				case 265u:
					ClearBtn = UpdateStaff_Admin.smethod_7();
					num = ((int)num2 * -1290286740) ^ 0x4D81FEB8;
					continue;
				case 264u:
					num = (int)(num2 * 2099094649) ^ -599415223;
					continue;
				case 263u:
					UpdateStaff_Admin.smethod_17((Control)(object)NameSTxt, new Point(120, 44));
					num = (int)((num2 * 366411797) ^ 0x26C39A04);
					continue;
				case 262u:
					UpdateStaff_Admin.smethod_25((Control)(object)Label9, 11);
					num = (int)(num2 * 1359365397) ^ -1208982162;
					continue;
				case 261u:
					UpdateStaff_Admin.smethod_18((Control)(object)DetailsBox, "DetailsBox");
					num = (int)((num2 * 1669666832) ^ 0xCAF1883);
					continue;
				case 260u:
					UpdateStaff_Admin.smethod_47((ListControl)(object)WorkShiftTxt, bool_0: true);
					num = (int)(num2 * 1401757407) ^ -1252821038;
					continue;
				case 259u:
					UpdateStaff_Admin.smethod_27(Label8, (ContentAlignment)32);
					num = (int)((num2 * 37606350) ^ 0x4E407187);
					continue;
				case 258u:
					num = ((int)num2 * -1704885931) ^ -1178150704;
					continue;
				case 257u:
					UpdateStaff_Admin.smethod_19((Control)(object)SIDTxt, new Size(204, 28));
					num = ((int)num2 * -2138014424) ^ 0x143A19CF;
					continue;
				case 256u:
					num = ((int)num2 * -1949173327) ^ -2097961820;
					continue;
				case 255u:
					UpdateStaff_Admin.smethod_26(Label7, "Address : ");
					num = ((int)num2 * -1491494166) ^ -858780496;
					continue;
				case 254u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_55((Control)(object)this), (Control)(object)DetailsBox);
					num = ((int)num2 * -1704928979) ^ 0x3E20545E;
					continue;
				case 253u:
					UpdateStaff_Admin.smethod_30(DetailsBox, bool_0: false);
					UpdateStaff_Admin.smethod_31(DetailsBox, "Staff Member Detail");
					num = ((int)num2 * -248256967) ^ 0x74224A09;
					continue;
				case 252u:
					UpdateStaff_Admin.smethod_24((Control)(object)DeleteBtn, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					UpdateStaff_Admin.smethod_33((Control)(object)DeleteBtn, Color.White);
					num = ((int)num2 * -1659315139) ^ 0x68DF7874;
					continue;
				case 251u:
					num = ((int)num2 * -847656716) ^ -474644672;
					continue;
				case 250u:
					num = (int)((num2 * 875861119) ^ 0x2E722EF9);
					continue;
				case 249u:
					num = (int)((num2 * 1651094164) ^ 0x76E3AED4);
					continue;
				case 248u:
					UpdateStaff_Admin.smethod_25((Control)(object)Label1, 6);
					UpdateStaff_Admin.smethod_26(Label1, "Update Staff");
					num = (int)(num2 * 1768221385) ^ -1427644774;
					continue;
				case 247u:
					UpdateStaff_Admin.smethod_17((Control)(object)ClearBtn, new Point(467, 30));
					num = ((int)num2 * -1962982987) ^ -82615799;
					continue;
				case 246u:
					UpdateStaff_Admin.smethod_18((Control)(object)ClearBtn, "ClearBtn");
					num = (int)((num2 * 2049811416) ^ 0x91A22D3);
					continue;
				case 245u:
					UpdateStaff_Admin.smethod_58((ISupportInitialize)PictureBox1);
					num = ((int)num2 * -1460285162) ^ -1955576716;
					continue;
				case 244u:
					UpdateStaff_Admin.smethod_18((Control)(object)SearchResultGrid, "SearchResultGrid");
					UpdateStaff_Admin.smethod_41(UpdateStaff_Admin.smethod_40(SearchResultGrid), 24);
					num = ((int)num2 * -1286183280) ^ -1463136346;
					continue;
				case 243u:
					UpdateStaff_Admin.smethod_32((ButtonBase)(object)ClearBtn, Color.MidnightBlue);
					num = (int)((num2 * 829463348) ^ 0x49FA27B5);
					continue;
				case 242u:
					num = ((int)num2 * -1069404461) ^ -1181753755;
					continue;
				case 241u:
					UpdateStaff_Admin.smethod_50((TextBoxBase)(object)SIDTxt, bool_0: true);
					num = ((int)num2 * -506640856) ^ 0x34961C70;
					continue;
				case 240u:
					num = ((int)num2 * -1875134206) ^ -759075397;
					continue;
				case 239u:
					num = ((int)num2 * -948617930) ^ 0x727360EB;
					continue;
				case 238u:
					UpdateStaff_Admin.smethod_18((Control)(object)DesignationTxt, "DesignationTxt");
					num = ((int)num2 * -495926314) ^ 0xF9A58BC;
					continue;
				case 237u:
					UpdateStaff_Admin.smethod_27(Label1, (ContentAlignment)32);
					num = (int)((num2 * 1034509616) ^ 0x41E03C42);
					continue;
				case 236u:
					UpdateStaff_Admin.smethod_24((Control)(object)Label8, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1369633919) ^ 0x3204F08C;
					continue;
				case 235u:
					num = (int)(num2 * 1153549638) ^ -1532874027;
					continue;
				case 234u:
					UpdateStaff_Admin.smethod_17((Control)(object)DesignationTxt, new Point(505, 72));
					num = ((int)num2 * -1255524981) ^ 0x47C41031;
					continue;
				case 233u:
					UpdateStaff_Admin.smethod_33((Control)(object)ClearBtn, Color.White);
					num = ((int)num2 * -972628978) ^ -1788138091;
					continue;
				case 232u:
					UpdateStaff_Admin.smethod_19((Control)(object)Receptionistbtn, new Size(132, 23));
					num = (int)((num2 * 169165586) ^ 0x33323923);
					continue;
				case 231u:
					num = (int)((num2 * 1471090016) ^ 0x5B78B056);
					continue;
				case 230u:
					UpdateStaff_Admin.smethod_24((Control)(object)Label2, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					UpdateStaff_Admin.smethod_17((Control)(object)Label2, new Point(37, 44));
					num = (int)((num2 * 1747537494) ^ 0x4D4D99FC);
					continue;
				case 229u:
					UpdateStaff_Admin.smethod_52(AddressTxt, bool_0: true);
					UpdateStaff_Admin.smethod_18((Control)(object)AddressTxt, "AddressTxt");
					num = (int)((num2 * 152431007) ^ 0x40636F9C);
					continue;
				case 228u:
					UpdateStaff_Admin.smethod_24((Control)(object)Label4, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -746132856) ^ -298645284;
					continue;
				case 227u:
					UpdateStaff_Admin.smethod_26(Label6, "Gender : ");
					num = ((int)num2 * -1528008496) ^ -127265466;
					continue;
				case 226u:
					num = (int)((num2 * 877086) ^ 0x2A1948B0);
					continue;
				case 225u:
					UpdateStaff_Admin.smethod_27(Label9, (ContentAlignment)32);
					num = (int)(num2 * 613252527) ^ -1580380946;
					continue;
				case 224u:
					Label1 = UpdateStaff_Admin.smethod_5();
					num = (int)((num2 * 1659067240) ^ 0x38A05CF3);
					continue;
				case 223u:
					num = ((int)num2 * -345546198) ^ 0x346DB0CE;
					continue;
				case 222u:
					num = ((int)num2 * -552206109) ^ 0x4EB0DC95;
					continue;
				case 221u:
					UpdateStaff_Admin.smethod_24((Control)(object)UpdateBtn, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					UpdateStaff_Admin.smethod_33((Control)(object)UpdateBtn, Color.White);
					num = (int)(num2 * 1779422895) ^ -738419182;
					continue;
				case 220u:
					num = (int)(num2 * 1965177169) ^ -654478432;
					continue;
				case 219u:
					UpdateStaff_Admin.smethod_35((ButtonBase)(object)Receptionistbtn, bool_0: true);
					num = (int)((num2 * 1822582468) ^ 0x56C4691E);
					continue;
				case 218u:
					UpdateStaff_Admin.smethod_39(SearchResultGrid, (DataGridViewColumnHeadersHeightSizeMode)2);
					num = (int)((num2 * 169012915) ^ 0x5780109A);
					continue;
				case 217u:
					UpdateStaff_Admin.smethod_17((Control)(object)AddressTxt, new Point(124, 217));
					num = (int)((num2 * 1171165256) ^ 0x50F79763);
					continue;
				case 216u:
					num = (int)((num2 * 478278289) ^ 0x17E4284C);
					continue;
				case 215u:
					num = ((int)num2 * -101260627) ^ -1794789159;
					continue;
				case 214u:
					UpdateStaff_Admin.smethod_17((Control)(object)NameTxt, new Point(124, 77));
					num = ((int)num2 * -248179393) ^ 0x2AC5F896;
					continue;
				case 213u:
					UpdateStaff_Admin.smethod_25((Control)(object)Label2, 0);
					num = (int)(num2 * 640400267) ^ -1268858408;
					continue;
				case 212u:
					UpdateStaff_Admin.smethod_19((Control)(object)EmailTxt, new Size(271, 28));
					num = (int)(num2 * 1980854497) ^ -1000827144;
					continue;
				case 211u:
					num = (int)((num2 * 1865396795) ^ 0x602385E);
					continue;
				case 210u:
					UpdateStaff_Admin.smethod_25((Control)(object)Label7, 3);
					num = (int)((num2 * 2055505249) ^ 0x50220696);
					continue;
				case 209u:
					UpdateStaff_Admin.smethod_17((Control)(object)DoctorBtn, new Point(65, 84));
					num = (int)(num2 * 219369506) ^ -938181714;
					continue;
				case 208u:
					num = ((int)num2 * -208750492) ^ -561167791;
					continue;
				case 207u:
					num = (int)(num2 * 1820193617) ^ -226980440;
					continue;
				case 206u:
					num = ((int)num2 * -2055768727) ^ 0xAEA8F99;
					continue;
				case 205u:
					UpdateStaff_Admin.smethod_49(UpdateStaff_Admin.smethod_48(WorkShiftTxt), new object[2] { "Day", "Night" });
					num = ((int)num2 * -1389194224) ^ 0x634944D3;
					continue;
				case 204u:
					UpdateStaff_Admin.smethod_19((Control)(object)ClearBtn, new Size(133, 37));
					num = (int)(num2 * 2137854606) ^ -1195652890;
					continue;
				case 203u:
					UpdateStaff_Admin.smethod_17((Control)(object)DOBTxt, new Point(505, 118));
					num = ((int)num2 * -766425629) ^ 0x57A8EAAB;
					continue;
				case 202u:
					UpdateStaff_Admin.smethod_58((ISupportInitialize)SearchResultGrid);
					num = (int)((num2 * 2088644570) ^ 0x94C2D6B);
					continue;
				case 201u:
					UpdateStaff_Admin.smethod_19((Control)(object)Label6, new Size(84, 26));
					num = ((int)num2 * -2123401905) ^ 0x3E5CE20C;
					continue;
				case 200u:
					UpdateStaff_Admin.smethod_17((Control)(object)Label12, new Point(417, 223));
					num = ((int)num2 * -1565062623) ^ 0x22D3A048;
					continue;
				case 199u:
					UpdateStaff_Admin.smethod_18((Control)(object)UpdateBtn, "UpdateBtn");
					num = ((int)num2 * -872535890) ^ 0x5F41884D;
					continue;
				case 198u:
					num = ((int)num2 * -1815725354) ^ 0x68D9BC35;
					continue;
				case 197u:
					num = ((int)num2 * -72284982) ^ -742971124;
					continue;
				case 195u:
					UpdateStaff_Admin.smethod_14((Control)(object)DetailsBox);
					UpdateStaff_Admin.smethod_15((Control)(object)this);
					UpdateStaff_Admin.smethod_16(PictureBox1, (Image)(object)Resources.doc_Pic);
					num = ((int)num2 * -1829029646) ^ 0x6A1F90E3;
					continue;
				case 194u:
					num = (int)(num2 * 1878978709) ^ -1730518571;
					continue;
				case 193u:
					UpdateStaff_Admin.smethod_37(DoctorBtn, bool_0: true);
					num = (int)((num2 * 610969474) ^ 0x76D56DBF);
					continue;
				case 191u:
					UpdateStaff_Admin.smethod_25((Control)(object)DetailsBox, 10);
					num = ((int)num2 * -1354650052) ^ 0x45E29C76;
					continue;
				case 190u:
					UpdateStaff_Admin.smethod_25((Control)(object)Receptionistbtn, 7);
					num = (int)((num2 * 253031458) ^ 0x2B478BBE);
					continue;
				case 189u:
					num = ((int)num2 * -1374625351) ^ -1026893260;
					continue;
				case 188u:
					num = (int)((num2 * 1266545492) ^ 0x74FB5815);
					continue;
				case 187u:
					UpdateStaff_Admin.smethod_34((ButtonBase)(object)DeleteBtn, "Delete");
					num = ((int)num2 * -2001537862) ^ -1869294003;
					continue;
				case 186u:
					UpdateStaff_Admin.smethod_24((Control)(object)DoctorBtn, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -806170490) ^ -1757199745;
					continue;
				case 185u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)GroupBox1), (Control)(object)Receptionistbtn);
					num = (int)((num2 * 235612274) ^ 0x6A1F3527);
					continue;
				case 184u:
					UpdateStaff_Admin.smethod_36((ButtonBase)(object)DoctorBtn, bool_0: true);
					num = (int)((num2 * 1560101814) ^ 0x56B8B89E);
					continue;
				case 183u:
					UpdateStaff_Admin.smethod_24((Control)(object)Label12, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1786936727) ^ 0x224BAF45;
					continue;
				case 182u:
					UpdateStaff_Admin.smethod_27(Label3, (ContentAlignment)32);
					num = (int)(num2 * 923389316) ^ -180213755;
					continue;
				case 181u:
					UpdateStaff_Admin.smethod_37(Receptionistbtn, bool_0: true);
					num = ((int)num2 * -203039505) ^ -337466695;
					continue;
				case 180u:
					num = (int)((num2 * 1917374737) ^ 0x5EA3D7D9);
					continue;
				case 179u:
					DOBTxt = UpdateStaff_Admin.smethod_11();
					num = ((int)num2 * -1404178984) ^ 0x16D49A8;
					continue;
				case 178u:
					UpdateStaff_Admin.smethod_43(DOBTxt, new DateTime(2019, 2, 12, 0, 0, 0, 0));
					num = ((int)num2 * -1111734275) ^ 0x3D3BBEA;
					continue;
				case 177u:
					UpdateStaff_Admin.smethod_18((Control)(object)DOBTxt, "DOBTxt");
					num = ((int)num2 * -2025354643) ^ -1900041775;
					continue;
				case 176u:
					UpdateStaff_Admin.smethod_18((Control)(object)Label2, "Label2");
					UpdateStaff_Admin.smethod_19((Control)(object)Label2, new Size(77, 28));
					num = (int)((num2 * 1534473651) ^ 0x6EE79C24);
					continue;
				case 175u:
					UpdateStaff_Admin.smethod_24((Control)(object)Label11, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1748856687) ^ -1362535110;
					continue;
				case 174u:
					UpdateStaff_Admin.smethod_47((ListControl)(object)DesignationTxt, bool_0: true);
					num = ((int)num2 * -1044991211) ^ 0x131E3733;
					continue;
				case 173u:
					num = ((int)num2 * -426576835) ^ -608281546;
					continue;
				case 172u:
					num = (int)(num2 * 2128753557) ^ -1664965725;
					continue;
				case 171u:
					UpdateStaff_Admin.smethod_56((Control)(object)this, "UpdateStaff_Admin");
					num = ((int)num2 * -1351892603) ^ -396006506;
					continue;
				case 170u:
					UpdateStaff_Admin.smethod_25((Control)(object)SIDTxt, 17);
					num = (int)(num2 * 2055154681) ^ -694266528;
					continue;
				case 169u:
					UpdateStaff_Admin.smethod_19((Control)(object)Label4, new Size(68, 25));
					num = (int)((num2 * 1010217923) ^ 0x387644B0);
					continue;
				case 168u:
					num = (int)(num2 * 1126267487) ^ -1262337330;
					continue;
				case 167u:
					num = ((int)num2 * -889441410) ^ 0x4DD6CEA9;
					continue;
				case 166u:
					UpdateStaff_Admin.smethod_13((ISupportInitialize)SearchResultGrid);
					num = ((int)num2 * -315674029) ^ -1144439942;
					continue;
				case 165u:
					UpdateStaff_Admin.smethod_17((Control)(object)NurseBtn, new Point(174, 84));
					num = ((int)num2 * -178358984) ^ -154816218;
					continue;
				case 164u:
					UpdateStaff_Admin.smethod_36((ButtonBase)(object)NurseBtn, bool_0: true);
					num = ((int)num2 * -1221716496) ^ -812619514;
					continue;
				case 163u:
					UpdateStaff_Admin.smethod_35((ButtonBase)(object)ClearBtn, bool_0: false);
					num = (int)(num2 * 19031348) ^ -636620641;
					continue;
				case 162u:
					UpdateStaff_Admin.smethod_26(Label8, "Name : ");
					num = (int)((num2 * 199075489) ^ 0x76D9702E);
					continue;
				case 161u:
					UpdateStaff_Admin.smethod_20(PictureBox1, (PictureBoxSizeMode)1);
					UpdateStaff_Admin.smethod_21(PictureBox1, 5);
					num = ((int)num2 * -660422826) ^ -1472419946;
					continue;
				case 160u:
					UpdateStaff_Admin.smethod_17((Control)(object)WorkShiftTxt, new Point(542, 217));
					num = ((int)num2 * -189574187) ^ 0x7875D2B9;
					continue;
				case 159u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_55((Control)(object)this), (Control)(object)Label1);
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_55((Control)(object)this), (Control)(object)PictureBox1);
					num = ((int)num2 * -1284386425) ^ 0xD86B753;
					continue;
				case 158u:
					UpdateStaff_Admin.smethod_25((Control)(object)Label4, 0);
					UpdateStaff_Admin.smethod_26(Label4, "Email :");
					num = (int)(num2 * 1944784628) ^ -382171617;
					continue;
				case 157u:
					UpdateStaff_Admin.smethod_18((Control)(object)NameSTxt, "NameSTxt");
					num = ((int)num2 * -2007295274) ^ 0x54F08724;
					continue;
				case 156u:
					UpdateStaff_Admin.smethod_24((Control)(object)DetailsBox, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 647564422) ^ -172703508;
					continue;
				case 155u:
					UpdateStaff_Admin.smethod_18((Control)(object)Label3, "Label3");
					num = (int)((num2 * 1517474544) ^ 0x194ECC6B);
					continue;
				case 154u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)GroupBox1), (Control)(object)NameSTxt);
					num = (int)((num2 * 23306942) ^ 0x15CBAB79);
					continue;
				case 153u:
					num = ((int)num2 * -335159620) ^ -1668882674;
					continue;
				case 152u:
					UpdateStaff_Admin.smethod_26(Label11, "SID :");
					num = (int)(num2 * 398518327) ^ -2023925274;
					continue;
				case 151u:
					UpdateStaff_Admin.smethod_60((Control)(object)DetailsBox);
					num = (int)(num2 * 530029463) ^ -1184073012;
					continue;
				case 150u:
					num = (int)(num2 * 686075497) ^ -2026768489;
					continue;
				case 149u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)SIDTxt);
					num = (int)((num2 * 1333963499) ^ 0x30288FF0);
					continue;
				case 148u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)Label5);
					num = ((int)num2 * -1782517169) ^ -1656265827;
					continue;
				case 147u:
					UpdateStaff_Admin.smethod_34((ButtonBase)(object)Receptionistbtn, "Receptionist");
					num = ((int)num2 * -154346416) ^ 0xCE91CA1;
					continue;
				case 146u:
					num = ((int)num2 * -132227834) ^ 0x26050B9;
					continue;
				case 145u:
					UpdateStaff_Admin.smethod_18((Control)(object)SearchBtn, "SearchBtn");
					num = (int)((num2 * 1922175020) ^ 0xE37282B);
					continue;
				case 144u:
					num = ((int)num2 * -2051403498) ^ -1220075563;
					continue;
				case 143u:
					UpdateStaff_Admin.smethod_24((Control)(object)Label1, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					UpdateStaff_Admin.smethod_17((Control)(object)Label1, new Point(392, 63));
					num = (int)(num2 * 1588131300) ^ -125424080;
					continue;
				case 142u:
					num = (int)(num2 * 1639795705) ^ -1734003298;
					continue;
				case 141u:
					num = (int)(num2 * 315997490) ^ -1049657125;
					continue;
				case 140u:
					num = ((int)num2 * -2012892628) ^ 0x6DB82586;
					continue;
				case 139u:
					UpdateStaff_Admin.smethod_17((Control)(object)EmailTxt, new Point(124, 123));
					num = (int)(num2 * 1714698519) ^ -301939001;
					continue;
				case 138u:
					num = (int)(num2 * 988293472) ^ -1668862002;
					continue;
				case 137u:
					UpdateStaff_Admin.smethod_30(GroupBox1, bool_0: false);
					num = ((int)num2 * -65503370) ^ -45999047;
					continue;
				case 136u:
					UpdateStaff_Admin.smethod_19((Control)(object)SearchBtn, new Size(133, 37));
					num = ((int)num2 * -573673388) ^ -23718315;
					continue;
				case 135u:
					UpdateStaff_Admin.smethod_19((Control)(object)SearchResultGrid, new Size(853, 169));
					num = ((int)num2 * -1551435423) ^ 0x73680ABD;
					continue;
				case 134u:
					UpdateStaff_Admin.smethod_31(GroupBox1, "Search Staff Member");
					num = (int)((num2 * 129842636) ^ 0x68C8AB69);
					continue;
				case 133u:
					UpdateStaff_Admin.smethod_19((Control)(object)NurseBtn, new Size(78, 23));
					num = ((int)num2 * -1739944765) ^ 0x25280C82;
					continue;
				case 132u:
					UpdateStaff_Admin.smethod_19((Control)(object)Label7, new Size(98, 26));
					num = (int)(num2 * 1100101602) ^ -1940780584;
					continue;
				case 131u:
					UpdateStaff_Admin.smethod_19((Control)(object)WorkShiftTxt, new Size(134, 30));
					num = ((int)num2 * -1736516953) ^ -182496214;
					continue;
				case 130u:
					num = ((int)num2 * -1983143273) ^ -2083677306;
					continue;
				case 129u:
					UpdateStaff_Admin.smethod_17((Control)(object)Receptionistbtn, new Point(280, 84));
					UpdateStaff_Admin.smethod_18((Control)(object)Receptionistbtn, "Receptionistbtn");
					num = ((int)num2 * -2128358049) ^ 0xB9A03B2;
					continue;
				case 128u:
					num = (int)((num2 * 1683852475) ^ 0x33C1D678);
					continue;
				case 127u:
					DoctorBtn = UpdateStaff_Admin.smethod_8();
					num = ((int)num2 * -782488288) ^ -1527619575;
					continue;
				case 126u:
					UpdateStaff_Admin.smethod_51((Control)(object)this, Color.White);
					num = (int)((num2 * 1031246112) ^ 0x43FBF007);
					continue;
				case 125u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_55((Control)(object)this), (Control)(object)GroupBox1);
					num = ((int)num2 * -1916779813) ^ -1282822279;
					continue;
				case 124u:
					GenderTxt = UpdateStaff_Admin.smethod_12();
					num = (int)((num2 * 730137685) ^ 0x66F37536);
					continue;
				case 123u:
					num = (int)((num2 * 253395830) ^ 0x691FDAA4);
					continue;
				case 122u:
					num = ((int)num2 * -1944642865) ^ 0x3E5C1833;
					continue;
				case 121u:
					UpdateStaff_Admin.smethod_19((Control)(object)PictureBox1, new Size(144, 141));
					num = (int)(num2 * 108496370) ^ -1828333026;
					continue;
				case 120u:
					UpdateStaff_Admin.smethod_57((Control)(object)this, new Size(977, 804));
					num = (int)((num2 * 620970937) ^ 0x4AD0A539);
					continue;
				case 119u:
					Label9 = UpdateStaff_Admin.smethod_5();
					num = (int)((num2 * 1423445831) ^ 0x977B309);
					continue;
				case 118u:
					UpdateStaff_Admin.smethod_45(DOBTxt, new DateTime(2019, 2, 12, 0, 0, 0, 0));
					num = (int)(num2 * 14782049) ^ -1877472809;
					continue;
				case 117u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_55((Control)(object)this), (Control)(object)DeleteBtn);
					num = ((int)num2 * -861819057) ^ 0x48A9B77;
					continue;
				case 116u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)GroupBox1), (Control)(object)ClearBtn);
					num = (int)(num2 * 1518423633) ^ -1274049865;
					continue;
				case 115u:
					num = ((int)num2 * -397633659) ^ -1915950358;
					continue;
				case 114u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)Label9);
					num = ((int)num2 * -47842563) ^ 0x51D6890;
					continue;
				case 113u:
					UpdateStaff_Admin.smethod_17((Control)(object)GenderTxt, new Point(521, 163));
					num = ((int)num2 * -852060779) ^ 0x676B636B;
					continue;
				case 112u:
					SearchBtn = UpdateStaff_Admin.smethod_7();
					num = ((int)num2 * -1270183880) ^ -811451860;
					continue;
				case 111u:
					num = ((int)num2 * -1791796452) ^ -2025653331;
					continue;
				case 110u:
					Label2 = UpdateStaff_Admin.smethod_5();
					num = (int)((num2 * 271255963) ^ 0x1D801487);
					continue;
				case 109u:
					DeleteBtn = UpdateStaff_Admin.smethod_7();
					DesignationTxt = UpdateStaff_Admin.smethod_12();
					num = ((int)num2 * -660172682) ^ -116154785;
					continue;
				case 108u:
					UpdateStaff_Admin.smethod_25((Control)(object)Label11, 16);
					num = (int)(num2 * 2142768912) ^ -463436404;
					continue;
				case 107u:
					AddressTxt = UpdateStaff_Admin.smethod_9();
					NameTxt = UpdateStaff_Admin.smethod_9();
					num = ((int)num2 * -1320880942) ^ -176696245;
					continue;
				case 106u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_55((Control)(object)this), (Control)(object)SearchResultGrid);
					num = (int)(num2 * 1531486689) ^ -686470591;
					continue;
				case 105u:
					UpdateStaff_Admin.smethod_14((Control)(object)GroupBox1);
					num = ((int)num2 * -1879314019) ^ -1611968007;
					continue;
				case 104u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)ShowAvailability);
					num = (int)((num2 * 1427822592) ^ 0x502BC49D);
					continue;
				case 103u:
					num = ((int)num2 * -1770200524) ^ 0xC2C3D2D;
					continue;
				case 102u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)GenderTxt);
					num = (int)(num2 * 307202425) ^ -920486704;
					continue;
				case 101u:
					num = ((int)num2 * -332665904) ^ 0x1B8FFD20;
					continue;
				case 100u:
					num = (int)(num2 * 1721229584) ^ -893728478;
					continue;
				case 99u:
					num = (int)(num2 * 846797164) ^ -2053346058;
					continue;
				case 98u:
					MobileTxt = UpdateStaff_Admin.smethod_9();
					num = ((int)num2 * -252916290) ^ -838049625;
					continue;
				case 97u:
					num = ((int)num2 * -1277443598) ^ 0x71AAC23C;
					continue;
				case 96u:
					UpdateStaff_Admin.smethod_25((Control)(object)Label12, 18);
					num = ((int)num2 * -913922556) ^ -830068679;
					continue;
				case 95u:
					UpdateStaff_Admin.smethod_49(UpdateStaff_Admin.smethod_48(GenderTxt), new object[3] { "Male", "Female", "Others" });
					num = (int)(num2 * 1877376659) ^ -1186585825;
					continue;
				case 94u:
					UpdateStaff_Admin.smethod_17((Control)(object)SIDTxt, new Point(124, 36));
					UpdateStaff_Admin.smethod_18((Control)(object)SIDTxt, "SIDTxt");
					num = (int)((num2 * 463971107) ^ 0x7164BC9A);
					continue;
				case 93u:
					num = (int)((num2 * 1735404101) ^ 0x1434A507);
					continue;
				case 92u:
					UpdateStaff_Admin.smethod_25((Control)(object)DeleteBtn, 17);
					num = (int)(num2 * 416455540) ^ -600224707;
					continue;
				case 91u:
					UpdateStaff_Admin.smethod_24((Control)(object)SearchBtn, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					UpdateStaff_Admin.smethod_33((Control)(object)SearchBtn, Color.White);
					num = (int)(num2 * 1928250847) ^ -1748633583;
					continue;
				case 90u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)Label4);
					num = (int)(num2 * 2119858279) ^ -1412012626;
					continue;
				case 89u:
					num = ((int)num2 * -657388291) ^ -748790166;
					continue;
				case 88u:
					UpdateStaff_Admin.smethod_53((ContainerControl)(object)this, new SizeF(8f, 16f));
					UpdateStaff_Admin.smethod_54((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 575938618) ^ -152628469;
					continue;
				case 87u:
					UpdateStaff_Admin.smethod_22(PictureBox1, bool_0: false);
					num = ((int)num2 * -1864095891) ^ -1709799039;
					continue;
				case 86u:
					num = (int)(num2 * 736668510) ^ -339271980;
					continue;
				case 85u:
					UpdateStaff_Admin.smethod_26(Label2, "Name : ");
					num = (int)((num2 * 1031270118) ^ 0x460E43B5);
					continue;
				case 84u:
					UpdateStaff_Admin.smethod_13((ISupportInitialize)PictureBox1);
					num = ((int)num2 * -1218185184) ^ -708380227;
					continue;
				case 83u:
					UpdateStaff_Admin.smethod_25((Control)(object)SearchBtn, 4);
					UpdateStaff_Admin.smethod_34((ButtonBase)(object)SearchBtn, "Search");
					num = (int)(num2 * 1661686962) ^ -600873872;
					continue;
				case 82u:
					SearchResultGrid = UpdateStaff_Admin.smethod_10();
					num = (int)((num2 * 1688640899) ^ 0x2ADA6DCE);
					continue;
				case 81u:
					UpdateStaff_Admin.smethod_25((Control)(object)GroupBox1, 8);
					num = (int)((num2 * 1593859662) ^ 0xE10E732);
					continue;
				case 80u:
					UpdateStaff_Admin.smethod_18((Control)(object)Label12, "Label12");
					UpdateStaff_Admin.smethod_19((Control)(object)Label12, new Size(118, 26));
					num = ((int)num2 * -1935061716) ^ -720789328;
					continue;
				case 79u:
					num = ((int)num2 * -981940553) ^ -477645836;
					continue;
				case 78u:
					UpdateStaff_Admin.smethod_19((Control)(object)NameSTxt, new Size(292, 28));
					num = (int)((num2 * 2071159897) ^ 0x646EAF72);
					continue;
				case 77u:
					UpdateStaff_Admin.smethod_34((ButtonBase)(object)DoctorBtn, "Doctor");
					UpdateStaff_Admin.smethod_35((ButtonBase)(object)DoctorBtn, bool_0: true);
					num = (int)((num2 * 1179052679) ^ 0x1F571B22);
					continue;
				case 76u:
					GroupBox1 = UpdateStaff_Admin.smethod_6();
					num = ((int)num2 * -1427379487) ^ 0x5A64E3E5;
					continue;
				case 75u:
					UpdateStaff_Admin.smethod_17((Control)(object)DetailsBox, new Point(79, 470));
					num = (int)((num2 * 214572356) ^ 0x624C8D51);
					continue;
				case 74u:
					UpdateStaff_Admin.smethod_19((Control)(object)DetailsBox, new Size(699, 313));
					num = ((int)num2 * -1521360507) ^ 0x4F9BE4;
					continue;
				case 73u:
					num = ((int)num2 * -1009414543) ^ -415134118;
					continue;
				case 72u:
					UpdateStaff_Admin.smethod_19((Control)(object)Label9, new Size(77, 28));
					num = ((int)num2 * -54358742) ^ 0x6D95D8C0;
					continue;
				case 71u:
					UpdateStaff_Admin.smethod_59((Control)(object)GroupBox1, bool_0: false);
					num = (int)((num2 * 1456122560) ^ 0x5790A2EB);
					continue;
				case 70u:
					UpdateStaff_Admin.smethod_19((Control)(object)DesignationTxt, new Size(170, 30));
					num = ((int)num2 * -1707838001) ^ -1390524841;
					continue;
				case 69u:
					UpdateStaff_Admin.smethod_18((Control)(object)Label11, "Label11");
					num = ((int)num2 * -1212049535) ^ -1084934166;
					continue;
				case 68u:
					UpdateStaff_Admin.smethod_25((Control)(object)WorkShiftTxt, 19);
					num = (int)((num2 * 822868535) ^ 0x3F21911D);
					continue;
				case 67u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)AddressTxt);
					num = ((int)num2 * -1616263770) ^ 0x1A8F8FD9;
					continue;
				case 66u:
					SIDTxt = UpdateStaff_Admin.smethod_9();
					num = ((int)num2 * -1840520955) ^ -1996606067;
					continue;
				case 65u:
					num = ((int)num2 * -927720409) ^ 0x517B723C;
					continue;
				case 64u:
					UpdateStaff_Admin.smethod_19((Control)(object)Label3, new Size(134, 28));
					num = ((int)num2 * -825655022) ^ 0x5F34F6E7;
					continue;
				case 63u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)DesignationTxt);
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)DOBTxt);
					num = ((int)num2 * -1574502312) ^ -661393774;
					continue;
				case 62u:
					UpdateStaff_Admin.smethod_25((Control)(object)Label6, 2);
					num = ((int)num2 * -462672256) ^ 0x648C780E;
					continue;
				case 61u:
					num = (int)((num2 * 1883805169) ^ 0x168BA512);
					continue;
				case 60u:
					Label7 = UpdateStaff_Admin.smethod_5();
					num = (int)((num2 * 1800285700) ^ 0x801F93B);
					continue;
				case 59u:
					UpdateStaff_Admin.smethod_19((Control)(object)AddressTxt, new Size(271, 90));
					UpdateStaff_Admin.smethod_25((Control)(object)AddressTxt, 7);
					num = ((int)num2 * -918046264) ^ -1851393840;
					continue;
				case 58u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)WorkShiftTxt);
					num = ((int)num2 * -1332462820) ^ -45101459;
					continue;
				case 57u:
					UpdateStaff_Admin.smethod_17((Control)(object)Label9, new Point(16, 169));
					num = (int)(num2 * 1605077765) ^ -1434680999;
					continue;
				case 56u:
					UpdateStaff_Admin.smethod_26(ShowAvailability, "UnAvailable");
					num = ((int)num2 * -1840215215) ^ -1729425082;
					continue;
				case 55u:
					UpdateStaff_Admin.smethod_51((Control)(object)ShowAvailability, Color.Red);
					num = (int)(num2 * 549258205) ^ -1342850371;
					continue;
				case 54u:
					WorkShiftTxt = UpdateStaff_Admin.smethod_12();
					Label12 = UpdateStaff_Admin.smethod_5();
					num = (int)((num2 * 825586115) ^ 0xB5CD9B6);
					continue;
				case 53u:
					num = ((int)num2 * -31634774) ^ 0xB8C66F4;
					continue;
				case 52u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)GroupBox1), (Control)(object)Label2);
					UpdateStaff_Admin.smethod_24((Control)(object)GroupBox1, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1524222804) ^ -745044303;
					continue;
				case 51u:
					UpdateStaff_Admin.smethod_34((ButtonBase)(object)NurseBtn, "Nurse");
					UpdateStaff_Admin.smethod_35((ButtonBase)(object)NurseBtn, bool_0: true);
					num = (int)((num2 * 805794472) ^ 0x469E556);
					continue;
				case 50u:
					EmailTxt = UpdateStaff_Admin.smethod_9();
					Label8 = UpdateStaff_Admin.smethod_5();
					num = ((int)num2 * -1578932991) ^ 0x59A3EE2A;
					continue;
				case 49u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)GroupBox1), (Control)(object)NurseBtn);
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)GroupBox1), (Control)(object)DoctorBtn);
					num = (int)((num2 * 1137190516) ^ 0x32F39A29);
					continue;
				case 48u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)GroupBox1), (Control)(object)SearchBtn);
					num = (int)((num2 * 497148453) ^ 0x98339FC);
					continue;
				case 47u:
					num = (int)((num2 * 1492195892) ^ 0x82F720D);
					continue;
				case 46u:
					UpdateStaff_Admin.smethod_18((Control)(object)EmailTxt, "EmailTxt");
					num = ((int)num2 * -1060135344) ^ -1900870338;
					continue;
				case 45u:
					num = ((int)num2 * -1649393633) ^ 0x3D798212;
					continue;
				case 44u:
					UpdateStaff_Admin.smethod_59((Control)(object)DetailsBox, bool_0: false);
					num = ((int)num2 * -59562749) ^ 0x621FCDB9;
					continue;
				case 43u:
					UpdateStaff_Admin.smethod_25((Control)(object)DesignationTxt, 20);
					num = ((int)num2 * -694832852) ^ -1847928154;
					continue;
				case 42u:
					UpdateStaff_Admin.smethod_36((ButtonBase)(object)Receptionistbtn, bool_0: true);
					UpdateStaff_Admin.smethod_24((Control)(object)Receptionistbtn, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1531137460) ^ 0x2B18553B;
					continue;
				case 41u:
					num = ((int)num2 * -613558611) ^ -43864419;
					continue;
				case 40u:
					UpdateStaff_Admin.smethod_32((ButtonBase)(object)SearchBtn, Color.MidnightBlue);
					num = ((int)num2 * -995509818) ^ -524848919;
					continue;
				case 39u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)MobileTxt);
					num = (int)(num2 * 889227587) ^ -1181995811;
					continue;
				case 38u:
					UpdateStaff_Admin.smethod_19((Control)(object)Label8, new Size(77, 28));
					num = (int)(num2 * 1494118506) ^ -502512684;
					continue;
				case 37u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_55((Control)(object)this), (Control)(object)UpdateBtn);
					num = ((int)num2 * -1873287915) ^ -1991467418;
					continue;
				case 36u:
					num = ((int)num2 * -142471479) ^ 0xB84393E;
					continue;
				case 35u:
					UpdateStaff_Admin.smethod_19((Control)(object)DoctorBtn, new Size(87, 23));
					num = ((int)num2 * -989753625) ^ -940712501;
					continue;
				case 34u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)Label3);
					num = (int)(num2 * 571471262) ^ -762327625;
					continue;
				case 33u:
					num = (int)((num2 * 1690598539) ^ 0x20A6A19);
					continue;
				case 32u:
					num = (int)((num2 * 1355464665) ^ 0x183B2FCB);
					continue;
				case 31u:
					num = (int)((num2 * 402383487) ^ 0x7F9B78A4);
					continue;
				case 30u:
					num = ((int)num2 * -1120515863) ^ -1525284780;
					continue;
				case 29u:
					UpdateStaff_Admin.smethod_26(Label9, "Phone : ");
					num = (int)((num2 * 1409444717) ^ 0x1EBCF81D);
					continue;
				case 28u:
					UpdateStaff_Admin.smethod_24((Control)(object)ClearBtn, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 960268000) ^ 0x12E25E99);
					continue;
				case 27u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)Label12);
					num = ((int)num2 * -1279396313) ^ -279305348;
					continue;
				case 26u:
					UpdateStaff_Admin.smethod_17((Control)(object)Label4, new Point(16, 126));
					num = (int)((num2 * 30560595) ^ 0x67C15940);
					continue;
				case 25u:
					num = ((int)num2 * -1932733547) ^ 0x4AFC36A3;
					continue;
				case 24u:
					num = ((int)num2 * -130876165) ^ -166596640;
					continue;
				case 23u:
					UpdateStaff_Admin.smethod_24((Control)(object)Label5, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					UpdateStaff_Admin.smethod_17((Control)(object)Label5, new Point(417, 123));
					UpdateStaff_Admin.smethod_18((Control)(object)Label5, "Label5");
					num = ((int)num2 * -259230368) ^ -1459844220;
					continue;
				case 22u:
					UpdateStaff_Admin.smethod_18((Control)(object)DeleteBtn, "DeleteBtn");
					num = (int)(num2 * 1017623886) ^ -1174717494;
					continue;
				case 21u:
					num = ((int)num2 * -791470450) ^ -817401402;
					continue;
				case 20u:
					UpdateStaff_Admin.smethod_18((Control)(object)PictureBox1, "PictureBox1");
					num = ((int)num2 * -1072450131) ^ 0x484E6158;
					continue;
				case 19u:
					UpdateStaff_Admin.smethod_27(ShowAvailability, (ContentAlignment)32);
					num = ((int)num2 * -1835494148) ^ 0x11F51C1A;
					continue;
				case 18u:
					UpdateStaff_Admin.smethod_19((Control)(object)Label11, new Size(68, 25));
					num = (int)((num2 * 1346540934) ^ 0x1154A633);
					continue;
				case 17u:
					num = ((int)num2 * -815406604) ^ -612241339;
					continue;
				case 16u:
					UpdateStaff_Admin.smethod_42(DOBTxt, (DateTimePickerFormat)2);
					num = (int)((num2 * 801158676) ^ 0x760511F8);
					continue;
				case 15u:
					ShowAvailability = UpdateStaff_Admin.smethod_5();
					num = ((int)num2 * -595449800) ^ 0x4C708241;
					continue;
				case 14u:
					num = (int)(num2 * 1518453599) ^ -579799584;
					continue;
				case 13u:
					Receptionistbtn = UpdateStaff_Admin.smethod_8();
					num = (int)((num2 * 1165911922) ^ 0x1AD17232);
					continue;
				case 12u:
					UpdateStaff_Admin.smethod_25((Control)(object)NurseBtn, 6);
					num = ((int)num2 * -2055721205) ^ 0x652D2795;
					continue;
				case 11u:
					num = ((int)num2 * -705950763) ^ -1664346685;
					continue;
				case 10u:
					UpdateStaff_Admin.smethod_18((Control)(object)GenderTxt, "GenderTxt");
					num = (int)(num2 * 1456808335) ^ -1812162954;
					continue;
				case 9u:
					UpdateStaff_Admin.smethod_32((ButtonBase)(object)UpdateBtn, Color.MidnightBlue);
					num = (int)((num2 * 861764817) ^ 0x2F5FFCA);
					continue;
				case 8u:
					num = ((int)num2 * -1453409668) ^ -474767490;
					continue;
				case 7u:
					num = ((int)num2 * -2019638429) ^ 0x7B362981;
					continue;
				case 6u:
					UpdateStaff_Admin.smethod_19((Control)(object)Label1, new Size(330, 47));
					num = (int)(num2 * 720990690) ^ -505284155;
					continue;
				case 5u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)NameTxt);
					num = (int)(num2 * 363178689) ^ -1463297363;
					continue;
				case 4u:
					UpdateStaff_Admin.smethod_37(NurseBtn, bool_0: true);
					num = ((int)num2 * -107510469) ^ 0x2E0B509;
					continue;
				case 3u:
					UpdateStaff_Admin.smethod_17((Control)(object)PictureBox1, new Point(242, 3));
					num = (int)(num2 * 173170084) ^ -1453275254;
					continue;
				case 2u:
					num = ((int)num2 * -265894744) ^ -1080090763;
					continue;
				case 1u:
					num = (int)(num2 * 812053738) ^ -844592271;
					continue;
				case 0u:
					UpdateStaff_Admin.smethod_19((Control)(object)GenderTxt, new Size(156, 30));
					num = (int)(num2 * 1153648512) ^ -134702870;
					continue;
				default:
					return;
				case 192u:
					break;
				case 196u:
					return;
				}
				break;
			}
		}
	}

	private void UpdateStaff_Admin_Load(object sender, EventArgs e)
	{
		UpdateStaff_Admin.smethod_69(myconnection, UpdateStaff_Admin.smethod_68(MyProject.Forms.Form1.provider, MyProject.Forms.Form1.datafile));
		while (true)
		{
			int num = -1787041991;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8481A59Fu) % 5u)
				{
				case 4u:
					Designation = "";
					num = (int)((num2 * 622792081) ^ 0x991C46A);
					continue;
				case 2u:
					UpdateStaff_Admin.smethod_43(DOBTxt, UpdateStaff_Admin.smethod_71(UpdateStaff_Admin.smethod_70((object)DateTime.Now, "dd-MM-yyyy")));
					num = ((int)num2 * -1424360796) ^ -2007885103;
					continue;
				case 0u:
					Hidedata();
					num = (int)((num2 * 1013358896) ^ 0x32463165);
					continue;
				default:
					return;
				case 3u:
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
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Expected I4, but got Unknown
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Expected I4, but got Unknown
		//IL_034c: Incompatible stack heights: 0 vs 1
		//IL_035c: Incompatible stack heights: 0 vs 1
		//IL_0363: Incompatible stack heights: 0 vs 1
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		Hidedata();
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		DataTable dataTable_ = default(DataTable);
		bool flag = default(bool);
		OleDbDataAdapter dbDataAdapter_ = default(OleDbDataAdapter);
		while (true)
		{
			int num = -58907773;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBF94AA5Fu) % 10u)
				{
				case 9u:
					flag2 = UpdateStaff_Admin.smethod_75(Designation, "", bool_0: false) == 0;
					num = -817994799;
					continue;
				case 6u:
					UpdateStaff_Admin.smethod_74("Enter Valid Name");
					num = ((int)num2 * -464150364) ^ -1786994599;
					continue;
				case 4u:
				{
					int num8;
					int num9;
					if (flag3)
					{
						num8 = -972268335;
						num9 = -972268335;
					}
					else
					{
						num8 = -647477626;
						num9 = -647477626;
					}
					num = num8 ^ ((int)num2 * -263162607);
					continue;
				}
				case 3u:
					UpdateStaff_Admin.smethod_74("click designation");
					num = ((int)num2 * -903356404) ^ 0x8B9FE5C;
					continue;
				case 2u:
					flag3 = !MyProject.Forms.Form1.Name_Validation(UpdateStaff_Admin.smethod_73(UpdateStaff_Admin.smethod_72(NameSTxt)));
					num = (int)((num2 * 385598769) ^ 0x53047BB7);
					continue;
				case 0u:
				{
					int num6;
					int num7;
					if (!flag2)
					{
						num6 = 754377216;
						num7 = 754377216;
					}
					else
					{
						num6 = 1879814376;
						num7 = 1879814376;
					}
					num = num6 ^ (int)(num2 * 1525567793);
					continue;
				}
				case 5u:
					break;
				default:
					try
					{
						while (true)
						{
							int num3 = -1236415758;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xBF94AA5Fu) % 14u)
								{
								case 13u:
									dataTable_ = UpdateStaff_Admin.smethod_76();
									num3 = (int)(num2 * 793224365) ^ -2021879243;
									continue;
								case 12u:
								{
									int num4;
									int num5;
									if (flag)
									{
										num4 = -1003913212;
										num5 = -1003913212;
									}
									else
									{
										num4 = -1105034741;
										num5 = -1105034741;
									}
									num3 = num4 ^ (int)(num2 * 258927017);
									continue;
								}
								case 11u:
									dbDataAdapter_ = UpdateStaff_Admin.smethod_77();
									UpdateStaff_Admin.smethod_78(myconnection);
									num3 = (int)((num2 * 1783844708) ^ 0x1D93401F);
									continue;
								case 10u:
									UpdateStaff_Admin.smethod_86(myconnection);
									num3 = (int)((num2 * 1750248608) ^ 0x70986279);
									continue;
								case 9u:
									flag = UpdateStaff_Admin.smethod_84(SearchResultGrid) == 1;
									num3 = (int)(num2 * 769260470) ^ -1288051883;
									continue;
								case 8u:
									dbDataAdapter_ = UpdateStaff_Admin.smethod_80(UpdateStaff_Admin.smethod_79(new string[5]
									{
										"Select * from Staff where Name like '%",
										UpdateStaff_Admin.smethod_72(NameSTxt),
										"%'  And   Designation = '",
										Designation,
										"'"
									}), myconnection);
									num3 = ((int)num2 * -227909183) ^ -775883939;
									continue;
								case 7u:
									UpdateStaff_Admin.smethod_85("Not Found.", "Result");
									UpdateStaff_Admin.smethod_86(myconnection);
									num3 = (int)(num2 * 1228041523) ^ -474949287;
									continue;
								case 4u:
									UpdateStaff_Admin.smethod_87((Control)(object)SearchResultGrid);
									num3 = -829255062;
									continue;
								case 3u:
									num3 = ((int)num2 * -770302145) ^ 0xB16633A;
									continue;
								case 2u:
									UpdateStaff_Admin.smethod_81((DbDataAdapter)(object)dbDataAdapter_, dataTable_);
									UpdateStaff_Admin.smethod_83(SearchResultGrid, (object)UpdateStaff_Admin.smethod_82(dataTable_));
									num3 = ((int)num2 * -57039540) ^ 0x1554E91C;
									continue;
								case 0u:
									num3 = (int)((num2 * 832445053) ^ 0x26A9138B);
									continue;
								case 5u:
									break;
								case 1u:
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
						UpdateStaff_Admin.smethod_88(exception_);
						while (true)
						{
							_ = -2088724342;
							while (true)
							{
								_003F val = /*Error near IL_0317: Stack underflow*/^ -1080776097;
								num2 = (uint)(int)val;
								switch (val % 4)
								{
								case 2:
									UpdateStaff_Admin.smethod_86(myconnection);
									_ = (num2 * 113068791) ^ 0x4540FC4A;
									continue;
								case 1:
									_ = ((int)num2 * -127878060) ^ 0x728BD0F9;
									continue;
								case 0:
									break;
								default:
									UpdateStaff_Admin.smethod_74("Incorrect Credentials");
									UpdateStaff_Admin.smethod_89();
									return;
								}
								break;
							}
						}
					}
				case 1u:
				case 8u:
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
			int num = 1694711281;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4549FD64u) % 4u)
				{
				case 2u:
					result = false;
					num = (int)(num2 * 1917367880) ^ -414837032;
					continue;
				case 1u:
					UpdateStaff_Admin.smethod_92(UpdateStaff_Admin.smethod_91(UpdateStaff_Admin.smethod_90(SearchResultGrid), 7), bool_0: false);
					UpdateStaff_Admin.smethod_92(UpdateStaff_Admin.smethod_91(UpdateStaff_Admin.smethod_90(SearchResultGrid), 9), bool_0: false);
					num = (int)(num2 * 430046464) ^ -12623714;
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
			int num = -1521681382;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFF2ED14Au) % 3u)
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
				num = (int)(num2 * 1657361475) ^ -1925828986;
			}
		}
	}

	private void RadioButton2_CheckedChanged(object sender, EventArgs e)
	{
		Designation = "Nurse";
	}

	private void RadioButton3_CheckedChanged(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -181964678;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFAFDE0ABu) % 3u)
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
				Designation = "Receptionist";
				num = (int)((num2 * 1326998777) ^ 0x57E8A840);
			}
		}
	}

	private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		if ((checked(UpdateStaff_Admin.smethod_93(e) + 1) == UpdateStaff_Admin.smethod_84(SearchResultGrid)) | (UpdateStaff_Admin.smethod_93(e) == -1))
		{
			goto IL_0081;
		}
		goto IL_00b3;
		IL_00b3:
		int num = -1122889947;
		goto IL_0086;
		IL_0086:
		DataGridViewRow dataGridViewRow_ = default(DataGridViewRow);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x80B6B44Bu) % 7u)
			{
			case 4u:
				UpdateStaff_Admin.smethod_87((Control)(object)UpdateBtn);
				UpdateStaff_Admin.smethod_87((Control)(object)DeleteBtn);
				num = (int)(num2 * 325623116) ^ -1236337271;
				continue;
			case 3u:
				UpdateStaff_Admin.smethod_94((Control)(object)DetailsBox, bool_0: true);
				num = (int)(num2 * 286177790) ^ -1307672331;
				continue;
			case 1u:
				selectrow = UpdateStaff_Admin.smethod_93(e);
				num = (int)((num2 * 818762021) ^ 0x706033FD);
				continue;
			case 0u:
				break;
			case 2u:
				goto IL_00b3;
			default:
				try
				{
					while (true)
					{
						int num3 = -1711100499;
						while (true)
						{
							switch ((num2 = (uint)num3 ^ 0x80B6B44Bu) % 11u)
							{
							case 10u:
								UpdateStaff_Admin.smethod_103(WorkShiftTxt, UpdateStaff_Admin.smethod_101(UpdateStaff_Admin.smethod_100(UpdateStaff_Admin.smethod_99(UpdateStaff_Admin.smethod_98(dataGridViewRow_), 8))));
								num3 = ((int)num2 * -2006711119) ^ -368881528;
								continue;
							case 9u:
								dataGridViewRow_ = UpdateStaff_Admin.smethod_95();
								dataGridViewRow_ = UpdateStaff_Admin.smethod_97(UpdateStaff_Admin.smethod_96(SearchResultGrid), selectrow);
								UpdateStaff_Admin.smethod_102(SIDTxt, UpdateStaff_Admin.smethod_101(UpdateStaff_Admin.smethod_100(UpdateStaff_Admin.smethod_99(UpdateStaff_Admin.smethod_98(dataGridViewRow_), 0))));
								num3 = ((int)num2 * -1149125492) ^ 0x69EA8258;
								continue;
							case 8u:
								UpdateStaff_Admin.smethod_102(AddressTxt, UpdateStaff_Admin.smethod_101(UpdateStaff_Admin.smethod_100(UpdateStaff_Admin.smethod_99(UpdateStaff_Admin.smethod_98(dataGridViewRow_), 6))));
								num3 = ((int)num2 * -369473006) ^ 0x4164BC65;
								continue;
							case 6u:
								UpdateStaff_Admin.smethod_105(DOBTxt, UpdateStaff_Admin.smethod_104(UpdateStaff_Admin.smethod_100(UpdateStaff_Admin.smethod_99(UpdateStaff_Admin.smethod_98(dataGridViewRow_), 3))));
								UpdateStaff_Admin.smethod_103(GenderTxt, UpdateStaff_Admin.smethod_101(UpdateStaff_Admin.smethod_100(UpdateStaff_Admin.smethod_99(UpdateStaff_Admin.smethod_98(dataGridViewRow_), 4))));
								num3 = (int)((num2 * 1835560454) ^ 0x362584A1);
								continue;
							case 5u:
								num3 = ((int)num2 * -1206853216) ^ -510283801;
								continue;
							case 3u:
								UpdateStaff_Admin.smethod_102(NameTxt, UpdateStaff_Admin.smethod_101(UpdateStaff_Admin.smethod_100(UpdateStaff_Admin.smethod_99(UpdateStaff_Admin.smethod_98(dataGridViewRow_), 1))));
								UpdateStaff_Admin.smethod_103(DesignationTxt, UpdateStaff_Admin.smethod_101(UpdateStaff_Admin.smethod_100(UpdateStaff_Admin.smethod_99(UpdateStaff_Admin.smethod_98(dataGridViewRow_), 2))));
								num3 = ((int)num2 * -1534014676) ^ -1103642585;
								continue;
							case 2u:
								num3 = (int)(num2 * 1752612612) ^ -2008655987;
								continue;
							case 1u:
								UpdateStaff_Admin.smethod_102(MobileTxt, UpdateStaff_Admin.smethod_101(UpdateStaff_Admin.smethod_100(UpdateStaff_Admin.smethod_99(UpdateStaff_Admin.smethod_98(dataGridViewRow_), 5))));
								num3 = ((int)num2 * -970485544) ^ -1224903561;
								continue;
							case 0u:
								putcolor(UpdateStaff_Admin.smethod_104(UpdateStaff_Admin.smethod_100(UpdateStaff_Admin.smethod_99(UpdateStaff_Admin.smethod_98(dataGridViewRow_), 8))));
								num3 = (int)((num2 * 1110309374) ^ 0x1219DD8F);
								continue;
							default:
								return;
							case 4u:
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
					UpdateStaff_Admin.smethod_88(exception_);
					UpdateStaff_Admin.smethod_89();
					return;
				}
			case 5u:
				return;
			}
			break;
		}
		goto IL_0081;
		IL_0081:
		num = -1632820754;
		goto IL_0086;
	}

	private void Hidedata()
	{
		UpdateStaff_Admin.smethod_94((Control)(object)DetailsBox, bool_0: false);
		while (true)
		{
			int num = -1588933551;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF58A52D3u) % 7u)
				{
				case 5u:
					num = (int)(num2 * 1001529293) ^ -977233252;
					continue;
				case 3u:
					UpdateStaff_Admin.smethod_106((Control)(object)UpdateBtn);
					num = (int)((num2 * 98580546) ^ 0x5F4990FF);
					continue;
				case 2u:
					num = (int)(num2 * 1061578202) ^ -1640271618;
					continue;
				case 1u:
					UpdateStaff_Admin.smethod_106((Control)(object)DeleteBtn);
					num = ((int)num2 * -1719825227) ^ -1893403275;
					continue;
				case 0u:
					UpdateStaff_Admin.smethod_106((Control)(object)SearchResultGrid);
					num = (int)((num2 * 2054109261) ^ 0x34D8021A);
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

	private void Button2_Click(object sender, EventArgs e)
	{
		UpdateStaff_Admin.smethod_107((TextBoxBase)(object)NameSTxt);
		while (true)
		{
			int num = -151870080;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA0BF4ECEu) % 13u)
				{
				case 12u:
					UpdateStaff_Admin.smethod_108(DoctorBtn, bool_0: false);
					num = (int)(num2 * 761870997) ^ -133418978;
					continue;
				case 11u:
					UpdateStaff_Admin.smethod_106((Control)(object)DeleteBtn);
					num = ((int)num2 * -147529534) ^ -1154835484;
					continue;
				case 10u:
					num = (int)((num2 * 1166595318) ^ 0x51150A9C);
					continue;
				case 8u:
					UpdateStaff_Admin.smethod_106((Control)(object)UpdateBtn);
					num = (int)((num2 * 947185233) ^ 0x78B41BE1);
					continue;
				case 7u:
					UpdateStaff_Admin.smethod_94((Control)(object)DetailsBox, bool_0: false);
					num = (int)((num2 * 537945106) ^ 0x13A5E320);
					continue;
				case 5u:
					UpdateStaff_Admin.smethod_108(NurseBtn, bool_0: false);
					num = (int)((num2 * 2027483472) ^ 0x6E55E28C);
					continue;
				case 4u:
					UpdateStaff_Admin.smethod_108(Receptionistbtn, bool_0: false);
					num = (int)(num2 * 336264370) ^ -1102985615;
					continue;
				case 3u:
					UpdateStaff_Admin.smethod_106((Control)(object)SearchResultGrid);
					num = ((int)num2 * -105588832) ^ 0x73472B08;
					continue;
				case 2u:
					num = (int)((num2 * 1730136650) ^ 0x2A75728C);
					continue;
				case 1u:
					num = (int)((num2 * 1923726071) ^ 0x7DF0CEA0);
					continue;
				case 0u:
					Designation = "";
					num = ((int)num2 * -1886679556) ^ -1300523571;
					continue;
				default:
					return;
				case 6u:
					break;
				case 9u:
					return;
				}
				break;
			}
		}
	}

	private void putcolor(string WorkShift)
	{
		bool flag = UpdateStaff_Admin.smethod_75(Shift(), WorkShift, bool_0: false) == 0;
		while (true)
		{
			int num = 611962261;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2F5BBDEBu) % 7u)
				{
				case 5u:
					colourgreen();
					num = (int)((num2 * 1994706388) ^ 0x8F1B50);
					continue;
				case 4u:
					num = ((int)num2 * -425184213) ^ 0x4C01A6B5;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -2103298902;
						num4 = -2103298902;
					}
					else
					{
						num3 = -8358287;
						num4 = -8358287;
					}
					num = num3 ^ (int)(num2 * 631744912);
					continue;
				}
				case 1u:
					colourred();
					num = ((int)num2 * -145052739) ^ -1760497123;
					continue;
				case 0u:
					num = 2016313594;
					continue;
				default:
					return;
				case 3u:
					break;
				case 6u:
					return;
				}
				break;
			}
		}
	}

	private string Shift()
	{
		string result = default(string);
		bool flag = default(bool);
		while (true)
		{
			int num = 1247417508;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1ED19C11u) % 8u)
				{
				case 7u:
					num = ((int)num2 * -532467143) ^ -295272334;
					continue;
				case 6u:
					result = "Day";
					num = ((int)num2 * -1123596141) ^ 0x4A57BCEC;
					continue;
				case 5u:
					flag = (day >= 7) & (day <= 19);
					num = ((int)num2 * -2002288044) ^ -1512156444;
					continue;
				case 3u:
					result = "Night";
					num = 1863913283;
					continue;
				case 2u:
					num = (int)((num2 * 202848920) ^ 0x77ED63A5);
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1579009507;
						num4 = -1579009507;
					}
					else
					{
						num3 = -344890896;
						num4 = -344890896;
					}
					num = num3 ^ (int)(num2 * 1603270087);
					continue;
				}
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
		while (true)
		{
			int num = 1851788065;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7994F4CBu) % 5u)
				{
				case 3u:
					num = (int)((num2 * 498878393) ^ 0x1E99412B);
					continue;
				case 1u:
					UpdateStaff_Admin.smethod_51((Control)(object)ShowAvailability, Color.Green);
					num = ((int)num2 * -960210814) ^ 0x661B4ED6;
					continue;
				case 0u:
					UpdateStaff_Admin.smethod_26(ShowAvailability, "Available");
					num = (int)(num2 * 414311489) ^ -422841916;
					continue;
				default:
					return;
				case 2u:
					break;
				case 4u:
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
			int num = -1137990496;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCDCC2D47u) % 3u)
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
				UpdateStaff_Admin.smethod_51((Control)(object)ShowAvailability, Color.Red);
				UpdateStaff_Admin.smethod_26(ShowAvailability, "Unavilable");
				num = ((int)num2 * -1514317424) ^ -27859842;
			}
		}
	}

	private void UpadateBtn_Click(object sender, EventArgs e)
	{
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Expected I4, but got Unknown
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e2: Expected I4, but got Unknown
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Incompatible stack heights: 0 vs 1
		//IL_041f: Incompatible stack heights: 0 vs 1
		//IL_042f: Incompatible stack heights: 0 vs 1
		//IL_0436: Incompatible stack heights: 0 vs 1
		bool flag = (UpdateStaff_Admin.smethod_75(UpdateStaff_Admin.smethod_72(NameTxt), "", bool_0: false) == 0) | (UpdateStaff_Admin.smethod_75(UpdateStaff_Admin.smethod_72(MobileTxt), "", bool_0: false) == 0) | (UpdateStaff_Admin.smethod_75(UpdateStaff_Admin.smethod_109(GenderTxt), "", bool_0: false) == 0) | (UpdateStaff_Admin.smethod_75(UpdateStaff_Admin.smethod_110(DOBTxt), "", bool_0: false) == 0) | (UpdateStaff_Admin.smethod_75(UpdateStaff_Admin.smethod_109(DesignationTxt), "", bool_0: false) == 0) | (UpdateStaff_Admin.smethod_75(UpdateStaff_Admin.smethod_72(AddressTxt), "", bool_0: false) == 0) | (UpdateStaff_Admin.smethod_75(UpdateStaff_Admin.smethod_109(WorkShiftTxt), "", bool_0: false) == 0);
		bool flag2 = default(bool);
		string string_ = default(string);
		DateTime dateTime_ = default(DateTime);
		while (true)
		{
			int num = -1497473789;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC42E2CADu) % 12u)
				{
				case 11u:
					flag2 = !(MyProject.Forms.Form1.Mobile_Validator(UpdateStaff_Admin.smethod_73(UpdateStaff_Admin.smethod_72(MobileTxt))) & MyProject.Forms.Form1.Name_Validation(UpdateStaff_Admin.smethod_73(UpdateStaff_Admin.smethod_72(NameTxt))) & MyProject.Forms.Form1.Gender_Validator(UpdateStaff_Admin.smethod_73(UpdateStaff_Admin.smethod_109(GenderTxt))));
					num = ((int)num2 * -394869539) ^ -1000515768;
					continue;
				case 10u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = -621144599;
						num7 = -621144599;
					}
					else
					{
						num6 = -1981666482;
						num7 = -1981666482;
					}
					num = num6 ^ ((int)num2 * -1207211410);
					continue;
				}
				case 9u:
					UpdateStaff_Admin.smethod_74("Invalid Credentials");
					num = (int)((num2 * 1097997770) ^ 0x387AC796);
					continue;
				case 8u:
					UpdateStaff_Admin.smethod_78(myconnection);
					num = -1642711424;
					continue;
				case 6u:
				{
					int num4;
					int num5;
					if (!flag2)
					{
						num4 = -1445366271;
						num5 = -1445366271;
					}
					else
					{
						num4 = -1096835924;
						num5 = -1096835924;
					}
					num = num4 ^ ((int)num2 * -263115704);
					continue;
				}
				case 4u:
					string_ = UpdateStaff_Admin.smethod_79(new string[11]
					{
						"Update [Staff] set [Date Of Birth] = #",
						UpdateStaff_Admin.smethod_112(dateTime_),
						"#, [Mobile]='",
						UpdateStaff_Admin.smethod_72(MobileTxt),
						"',[Work Shift]='",
						UpdateStaff_Admin.smethod_109(WorkShiftTxt),
						"',[Address]='",
						UpdateStaff_Admin.smethod_72(AddressTxt),
						"'where [SID] = ",
						UpdateStaff_Admin.smethod_72(SIDTxt),
						" "
					});
					num = ((int)num2 * -1029904321) ^ 0x249E3252;
					continue;
				case 3u:
					dateTime_ = UpdateStaff_Admin.smethod_71(UpdateStaff_Admin.smethod_70((object)UpdateStaff_Admin.smethod_111(DOBTxt), "dd-MM-yyyy"));
					num = -953214251;
					continue;
				case 1u:
					num = ((int)num2 * -2007532967) ^ 0xECC0C46;
					continue;
				case 7u:
					break;
				case 0u:
					UpdateStaff_Admin.smethod_74("Fields Cannot be empty");
					return;
				default:
				{
					OleDbCommand val = UpdateStaff_Admin.smethod_113(string_, myconnection);
					try
					{
						while (true)
						{
							int num3 = -393856560;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xC42E2CADu) % 8u)
								{
								case 7u:
									ClearDetailsBox();
									UpdateStaff_Admin.smethod_74("Updated Sucessfully");
									num3 = ((int)num2 * -1393375715) ^ 0x8EAF894;
									continue;
								case 6u:
									UpdateTable();
									num3 = (int)((num2 * 1813700340) ^ 0x621CB521);
									continue;
								case 5u:
									UpdateStaff_Admin.smethod_114(val);
									num3 = (int)(num2 * 1556751353) ^ -138360832;
									continue;
								case 2u:
									UpdateStaff_Admin.smethod_86(myconnection);
									num3 = (int)(num2 * 1993308747) ^ -138143526;
									continue;
								case 1u:
									num3 = (int)((num2 * 1669210080) ^ 0x7C4AF3EB);
									continue;
								case 0u:
									UpdateStaff_Admin.smethod_115((Component)(object)val);
									num3 = (int)(num2 * 1407490130) ^ -1238941006;
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
					catch (Exception exception_)
					{
						UpdateStaff_Admin.smethod_88(exception_);
						while (true)
						{
							_ = -1953478914;
							while (true)
							{
								_003F val2 = /*Error near IL_03c4: Stack underflow*/^ -1003606867;
								num2 = (uint)(int)val2;
								switch (val2 % 5)
								{
								default:
									return;
								case 3:
									UpdateStaff_Admin.smethod_116((object)"Invalid Credentials", (MsgBoxStyle)0, (object)null);
									UpdateStaff_Admin.smethod_86(myconnection);
									_ = (num2 * 2070834976) ^ 0xC42E2FBAu;
									continue;
								case 2:
									UpdateStaff_Admin.smethod_89();
									_ = ((int)num2 * -1479419470) ^ -1112018803;
									continue;
								case 1:
									_ = ((int)num2 * -150264645) ^ -600998289;
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
				}
				case 5u:
					return;
				}
				break;
			}
		}
	}

	private void DeleteBtn_Click(object sender, EventArgs e)
	{
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected I4, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected I4, but got Unknown
		//IL_01e9: Incompatible stack heights: 0 vs 1
		//IL_01f0: Incompatible stack heights: 0 vs 1
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		UpdateStaff_Admin.smethod_95();
		UpdateStaff_Admin.smethod_97(UpdateStaff_Admin.smethod_96(SearchResultGrid), selectrow);
		string string_ = default(string);
		bool flag = default(bool);
		while (true)
		{
			int num = -931128708;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCBD7023Cu) % 7u)
				{
				case 5u:
					string_ = UpdateStaff_Admin.smethod_117("Delete from [Staff] where [SID] = ", UpdateStaff_Admin.smethod_72(SIDTxt), " ");
					UpdateStaff_Admin.smethod_78(myconnection);
					num = ((int)num2 * -1557826324) ^ 0x6F02FE12;
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 454204089;
						num5 = 454204089;
					}
					else
					{
						num4 = 1290479364;
						num5 = 1290479364;
					}
					num = num4 ^ ((int)num2 * -1734488417);
					continue;
				}
				case 3u:
					num = -1390472999;
					continue;
				case 1u:
					flag = UpdateStaff_Admin.smethod_75(UpdateStaff_Admin.smethod_72(SIDTxt), "", bool_0: false) == 0;
					num = (int)((num2 * 1199667748) ^ 0x4E3AE2B3);
					continue;
				case 0u:
					break;
				default:
				{
					OleDbCommand val = UpdateStaff_Admin.smethod_113(string_, myconnection);
					try
					{
						UpdateStaff_Admin.smethod_114(val);
						UpdateStaff_Admin.smethod_115((Component)(object)val);
						while (true)
						{
							int num3 = -1480787518;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xCBD7023Cu) % 7u)
								{
								case 5u:
									UpdateStaff_Admin.smethod_86(myconnection);
									num3 = (int)((num2 * 413990472) ^ 0x219896AB);
									continue;
								case 3u:
									UpdateStaff_Admin.smethod_74("Deleted  Sucessfully");
									num3 = ((int)num2 * -554522293) ^ 0x75B13C23;
									continue;
								case 2u:
									num3 = ((int)num2 * -888573670) ^ 0x27830744;
									continue;
								case 1u:
									ClearDetailsBox();
									num3 = (int)((num2 * 1861650307) ^ 0x27E5953B);
									continue;
								case 0u:
									UpdateTable();
									num3 = (int)(num2 * 1014936324) ^ -385643116;
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
					catch (Exception exception_)
					{
						UpdateStaff_Admin.smethod_88(exception_);
						while (true)
						{
							_ = -1459922344;
							while (true)
							{
								_003F val2 = /*Error near IL_01b8: Stack underflow*/^ -875101636;
								num2 = (uint)(int)val2;
								switch (val2 % 3)
								{
								case 1:
									UpdateStaff_Admin.smethod_86(myconnection);
									_ = (num2 * 1621349076) ^ 0x8749D9ECu;
									continue;
								case 0:
									break;
								default:
									UpdateStaff_Admin.smethod_89();
									return;
								}
								break;
							}
						}
					}
				}
				case 6u:
					UpdateStaff_Admin.smethod_74("No Data To Delete");
					return;
				}
				break;
			}
		}
	}

	private bool UpdateTable()
	{
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected I4, but got Unknown
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected I4, but got Unknown
		//IL_01fa: Incompatible stack heights: 0 vs 1
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Incompatible stack heights: 0 vs 1
		//IL_0235: Incompatible stack heights: 0 vs 1
		//IL_0245: Incompatible stack heights: 0 vs 1
		//IL_024f: Incompatible stack heights: 0 vs 1
		UpdateStaff_Admin.smethod_118();
		string string_ = UpdateStaff_Admin.smethod_79(new string[5]
		{
			"Select * From [Staff] Where [Name] Like '%",
			UpdateStaff_Admin.smethod_73(UpdateStaff_Admin.smethod_72(NameSTxt)),
			"%' And [Designation] Like '%",
			Designation,
			"%';"
		});
		DataTable dataTable = UpdateStaff_Admin.smethod_76();
		UpdateStaff_Admin.smethod_78(myconnection);
		bool result = default(bool);
		try
		{
			bool flag = default(bool);
			while (true)
			{
				IL_019e:
				int num = -815239490;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF39952ABu) % 12u)
					{
					case 10u:
						UpdateStaff_Admin.smethod_94((Control)(object)SearchResultGrid, bool_0: true);
						num = -1282480861;
						continue;
					case 9u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -2052540475;
							num4 = -2052540475;
						}
						else
						{
							num3 = -812192217;
							num4 = -812192217;
						}
						num = num3 ^ (int)(num2 * 1074753098);
						continue;
					}
					case 8u:
						UpdateStaff_Admin.smethod_86(myconnection);
						num = (int)(num2 * 1659468377) ^ -1382295183;
						continue;
					case 6u:
						num = ((int)num2 * -1509207801) ^ 0x2CF0FDD9;
						continue;
					case 5u:
						flag = UpdateStaff_Admin.smethod_84(SearchResultGrid) == 1;
						num = (int)((num2 * 1414452655) ^ 0x71B2A889);
						continue;
					case 4u:
						num = ((int)num2 * -1351945510) ^ 0x4486B91C;
						continue;
					case 3u:
						UpdateStaff_Admin.smethod_86(myconnection);
						num = (int)(num2 * 1998527090) ^ -461623394;
						continue;
					case 1u:
					{
						OleDbDataAdapter dbDataAdapter_ = UpdateStaff_Admin.smethod_80(string_, myconnection);
						UpdateStaff_Admin.smethod_81((DbDataAdapter)(object)dbDataAdapter_, dataTable);
						UpdateStaff_Admin.smethod_83(SearchResultGrid, (object)dataTable);
						num = ((int)num2 * -2095489730) ^ -1677075332;
						continue;
					}
					case 0u:
						result = false;
						num = ((int)num2 * -212804918) ^ 0x3D81E7A8;
						continue;
					case 2u:
						break;
					default:
						HideunusedColumns();
						goto end_IL_015b;
					case 7u:
						return result;
					}
					goto IL_019e;
					continue;
					end_IL_015b:
					break;
				}
				break;
			}
		}
		catch (Exception exception_)
		{
			UpdateStaff_Admin.smethod_88(exception_);
			while (true)
			{
				IL_024a:
				_ = -1078205936;
				while (true)
				{
					_003F val = /*Error near IL_01c8: Stack underflow*/^ -208055637;
					uint num2 = (uint)(int)val;
					switch (val % 6)
					{
					default:
						goto end_IL_01c2;
					case 5:
						_ = ((int)num2 * -1070872944) ^ 0x622072FF;
						continue;
					case 2:
						UpdateStaff_Admin.smethod_74("Error updating table");
						UpdateStaff_Admin.smethod_86(myconnection);
						_ = ((int)num2 * -639888084) ^ -718472937;
						continue;
					case 1:
						UpdateStaff_Admin.smethod_89();
						_ = (num2 * 963142968) ^ 0x23C2AFD5;
						continue;
					case 0:
						_ = (num2 * 665303275) ^ 0x50B3A3BE;
						continue;
					case 3:
						break;
					case 4:
						goto end_IL_01c2;
					}
					goto IL_024a;
					continue;
					end_IL_01c2:
					break;
				}
				break;
			}
		}
		while (true)
		{
			int num5 = -475462732;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num5 ^ 0xF39952ABu) % 3u)
				{
				case 2u:
					goto IL_0256;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0256:
				result = true;
				num5 = (int)(num2 * 1012808958) ^ -765473581;
			}
		}
	}

	private bool ClearDetailsBox()
	{
		bool result = default(bool);
		while (true)
		{
			int num = -1350359055;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8D10A711u) % 15u)
				{
				case 14u:
					UpdateStaff_Admin.smethod_107((TextBoxBase)(object)AddressTxt);
					num = ((int)num2 * -390397974) ^ -1337550123;
					continue;
				case 12u:
					UpdateStaff_Admin.smethod_107((TextBoxBase)(object)EmailTxt);
					UpdateStaff_Admin.smethod_119(DesignationTxt, -1);
					num = (int)(num2 * 747075220) ^ -1701335201;
					continue;
				case 11u:
					UpdateStaff_Admin.smethod_119(GenderTxt, -1);
					num = (int)((num2 * 1515624178) ^ 0x37268532);
					continue;
				case 10u:
					UpdateStaff_Admin.smethod_107((TextBoxBase)(object)MobileTxt);
					num = (int)((num2 * 122825979) ^ 0xDE39F23);
					continue;
				case 9u:
					UpdateStaff_Admin.smethod_119(WorkShiftTxt, -1);
					num = ((int)num2 * -1705497723) ^ -1129127331;
					continue;
				case 8u:
					UpdateStaff_Admin.smethod_107((TextBoxBase)(object)SIDTxt);
					num = (int)(num2 * 1636222701) ^ -1119245114;
					continue;
				case 7u:
					UpdateStaff_Admin.smethod_107((TextBoxBase)(object)NameTxt);
					num = ((int)num2 * -393547230) ^ -1916363526;
					continue;
				case 6u:
					num = ((int)num2 * -2023186693) ^ -1716379639;
					continue;
				case 5u:
					num = (int)((num2 * 1689724157) ^ 0x73AEC8CE);
					continue;
				case 4u:
					num = ((int)num2 * -2056981697) ^ 0x316FABF2;
					continue;
				case 3u:
					UpdateStaff_Admin.smethod_45(DOBTxt, UpdateStaff_Admin.smethod_71(UpdateStaff_Admin.smethod_70((object)DateTime.Now, "dd-MM-yyyy")));
					num = ((int)num2 * -1518577746) ^ -1507284753;
					continue;
				case 2u:
					result = true;
					num = (int)(num2 * 959032513) ^ -312888662;
					continue;
				case 1u:
					num = (int)(num2 * 1854423467) ^ -794481758;
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

	static int smethod_2(string string_0)
	{
		return Conversions.ToInteger(string_0);
	}

	static void smethod_3(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static PictureBox smethod_4()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new PictureBox();
	}

	static Label smethod_5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Label();
	}

	static GroupBox smethod_6()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new GroupBox();
	}

	static Button smethod_7()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Button();
	}

	static RadioButton smethod_8()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new RadioButton();
	}

	static TextBox smethod_9()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new TextBox();
	}

	static DataGridView smethod_10()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new DataGridView();
	}

	static DateTimePicker smethod_11()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new DateTimePicker();
	}

	static ComboBox smethod_12()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new ComboBox();
	}

	static void smethod_13(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.BeginInit();
	}

	static void smethod_14(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_15(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_16(PictureBox pictureBox_0, Image image_0)
	{
		pictureBox_0.set_Image(image_0);
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

	static void smethod_20(PictureBox pictureBox_0, PictureBoxSizeMode pictureBoxSizeMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		pictureBox_0.set_SizeMode(pictureBoxSizeMode_0);
	}

	static void smethod_21(PictureBox pictureBox_0, int int_0)
	{
		pictureBox_0.set_TabIndex(int_0);
	}

	static void smethod_22(PictureBox pictureBox_0, bool bool_0)
	{
		pictureBox_0.set_TabStop(bool_0);
	}

	static Font smethod_23(string string_0, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_24(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static void smethod_25(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static void smethod_26(Label label_0, string string_0)
	{
		label_0.set_Text(string_0);
	}

	static void smethod_27(Label label_0, ContentAlignment contentAlignment_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		label_0.set_TextAlign(contentAlignment_0);
	}

	static ControlCollection smethod_28(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_29(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_30(GroupBox groupBox_0, bool bool_0)
	{
		groupBox_0.set_TabStop(bool_0);
	}

	static void smethod_31(GroupBox groupBox_0, string string_0)
	{
		groupBox_0.set_Text(string_0);
	}

	static void smethod_32(ButtonBase buttonBase_0, Color color_0)
	{
		buttonBase_0.set_BackColor(color_0);
	}

	static void smethod_33(Control control_0, Color color_0)
	{
		control_0.set_ForeColor(color_0);
	}

	static void smethod_34(ButtonBase buttonBase_0, string string_0)
	{
		buttonBase_0.set_Text(string_0);
	}

	static void smethod_35(ButtonBase buttonBase_0, bool bool_0)
	{
		buttonBase_0.set_UseVisualStyleBackColor(bool_0);
	}

	static void smethod_36(ButtonBase buttonBase_0, bool bool_0)
	{
		buttonBase_0.set_AutoSize(bool_0);
	}

	static void smethod_37(RadioButton radioButton_0, bool bool_0)
	{
		radioButton_0.set_TabStop(bool_0);
	}

	static void smethod_38(DataGridView dataGridView_0, Color color_0)
	{
		dataGridView_0.set_BackgroundColor(color_0);
	}

	static void smethod_39(DataGridView dataGridView_0, DataGridViewColumnHeadersHeightSizeMode dataGridViewColumnHeadersHeightSizeMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		dataGridView_0.set_ColumnHeadersHeightSizeMode(dataGridViewColumnHeadersHeightSizeMode_0);
	}

	static DataGridViewRow smethod_40(DataGridView dataGridView_0)
	{
		return dataGridView_0.get_RowTemplate();
	}

	static void smethod_41(DataGridViewRow dataGridViewRow_0, int int_0)
	{
		dataGridViewRow_0.set_Height(int_0);
	}

	static void smethod_42(DateTimePicker dateTimePicker_0, DateTimePickerFormat dateTimePickerFormat_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		dateTimePicker_0.set_Format(dateTimePickerFormat_0);
	}

	static void smethod_43(DateTimePicker dateTimePicker_0, DateTime dateTime_0)
	{
		dateTimePicker_0.set_MaxDate(dateTime_0);
	}

	static void smethod_44(DateTimePicker dateTimePicker_0, DateTime dateTime_0)
	{
		dateTimePicker_0.set_MinDate(dateTime_0);
	}

	static void smethod_45(DateTimePicker dateTimePicker_0, DateTime dateTime_0)
	{
		dateTimePicker_0.set_Value(dateTime_0);
	}

	static void smethod_46(ComboBox comboBox_0, ComboBoxStyle comboBoxStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		comboBox_0.set_DropDownStyle(comboBoxStyle_0);
	}

	static void smethod_47(ListControl listControl_0, bool bool_0)
	{
		listControl_0.set_FormattingEnabled(bool_0);
	}

	static ObjectCollection smethod_48(ComboBox comboBox_0)
	{
		return comboBox_0.get_Items();
	}

	static void smethod_49(ObjectCollection objectCollection_0, object[] object_0)
	{
		objectCollection_0.AddRange(object_0);
	}

	static void smethod_50(TextBoxBase textBoxBase_0, bool bool_0)
	{
		textBoxBase_0.set_ReadOnly(bool_0);
	}

	static void smethod_51(Control control_0, Color color_0)
	{
		control_0.set_BackColor(color_0);
	}

	static void smethod_52(TextBox textBox_0, bool bool_0)
	{
		textBox_0.set_Multiline(bool_0);
	}

	static void smethod_53(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_54(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static ControlCollection smethod_55(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_56(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_57(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_58(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.EndInit();
	}

	static void smethod_59(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_60(Control control_0)
	{
		control_0.PerformLayout();
	}

	static void smethod_61(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_62(Control control_0, EventHandler eventHandler_0)
	{
		control_0.remove_Click(eventHandler_0);
	}

	static void smethod_63(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_Click(eventHandler_0);
	}

	static void smethod_64(RadioButton radioButton_0, EventHandler eventHandler_0)
	{
		radioButton_0.remove_CheckedChanged(eventHandler_0);
	}

	static void smethod_65(RadioButton radioButton_0, EventHandler eventHandler_0)
	{
		radioButton_0.add_CheckedChanged(eventHandler_0);
	}

	static void smethod_66(DataGridView dataGridView_0, DataGridViewCellMouseEventHandler dataGridViewCellMouseEventHandler_0)
	{
		dataGridView_0.remove_CellMouseClick(dataGridViewCellMouseEventHandler_0);
	}

	static void smethod_67(DataGridView dataGridView_0, DataGridViewCellMouseEventHandler dataGridViewCellMouseEventHandler_0)
	{
		dataGridView_0.add_CellMouseClick(dataGridViewCellMouseEventHandler_0);
	}

	static string smethod_68(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static void smethod_69(OleDbConnection oleDbConnection_0, string string_0)
	{
		oleDbConnection_0.set_ConnectionString(string_0);
	}

	static string smethod_70(object object_0, string string_0)
	{
		return Strings.Format(object_0, string_0);
	}

	static DateTime smethod_71(string string_0)
	{
		return Conversions.ToDate(string_0);
	}

	static string smethod_72(TextBox textBox_0)
	{
		return textBox_0.get_Text();
	}

	static string smethod_73(string string_0)
	{
		return string_0.ToLower();
	}

	static DialogResult smethod_74(string string_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0);
	}

	static int smethod_75(string string_0, string string_1, bool bool_0)
	{
		return Operators.CompareString(string_0, string_1, bool_0);
	}

	static DataTable smethod_76()
	{
		return new DataTable();
	}

	static OleDbDataAdapter smethod_77()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new OleDbDataAdapter();
	}

	static void smethod_78(OleDbConnection oleDbConnection_0)
	{
		oleDbConnection_0.Open();
	}

	static string smethod_79(string[] string_0)
	{
		return string.Concat(string_0);
	}

	static OleDbDataAdapter smethod_80(string string_0, OleDbConnection oleDbConnection_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new OleDbDataAdapter(string_0, oleDbConnection_0);
	}

	static int smethod_81(DbDataAdapter dbDataAdapter_0, DataTable dataTable_0)
	{
		return dbDataAdapter_0.Fill(dataTable_0);
	}

	static DataView smethod_82(DataTable dataTable_0)
	{
		return dataTable_0.DefaultView;
	}

	static void smethod_83(DataGridView dataGridView_0, object object_0)
	{
		dataGridView_0.set_DataSource(object_0);
	}

	static int smethod_84(DataGridView dataGridView_0)
	{
		return dataGridView_0.get_RowCount();
	}

	static DialogResult smethod_85(string string_0, string string_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0, string_1);
	}

	static void smethod_86(OleDbConnection oleDbConnection_0)
	{
		oleDbConnection_0.Close();
	}

	static void smethod_87(Control control_0)
	{
		control_0.Show();
	}

	static void smethod_88(Exception exception_0)
	{
		ProjectData.SetProjectError(exception_0);
	}

	static void smethod_89()
	{
		ProjectData.ClearProjectError();
	}

	static DataGridViewColumnCollection smethod_90(DataGridView dataGridView_0)
	{
		return dataGridView_0.get_Columns();
	}

	static DataGridViewColumn smethod_91(DataGridViewColumnCollection dataGridViewColumnCollection_0, int int_0)
	{
		return dataGridViewColumnCollection_0.get_Item(int_0);
	}

	static void smethod_92(DataGridViewColumn dataGridViewColumn_0, bool bool_0)
	{
		dataGridViewColumn_0.set_Visible(bool_0);
	}

	static int smethod_93(DataGridViewCellMouseEventArgs dataGridViewCellMouseEventArgs_0)
	{
		return dataGridViewCellMouseEventArgs_0.get_RowIndex();
	}

	static void smethod_94(Control control_0, bool bool_0)
	{
		control_0.set_Visible(bool_0);
	}

	static DataGridViewRow smethod_95()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new DataGridViewRow();
	}

	static DataGridViewRowCollection smethod_96(DataGridView dataGridView_0)
	{
		return dataGridView_0.get_Rows();
	}

	static DataGridViewRow smethod_97(DataGridViewRowCollection dataGridViewRowCollection_0, int int_0)
	{
		return dataGridViewRowCollection_0.get_Item(int_0);
	}

	static DataGridViewCellCollection smethod_98(DataGridViewRow dataGridViewRow_0)
	{
		return dataGridViewRow_0.get_Cells();
	}

	static DataGridViewCell smethod_99(DataGridViewCellCollection dataGridViewCellCollection_0, int int_0)
	{
		return dataGridViewCellCollection_0.get_Item(int_0);
	}

	static object smethod_100(DataGridViewCell dataGridViewCell_0)
	{
		return dataGridViewCell_0.get_Value();
	}

	static string smethod_101(object object_0)
	{
		return object_0.ToString();
	}

	static void smethod_102(TextBox textBox_0, string string_0)
	{
		textBox_0.set_Text(string_0);
	}

	static void smethod_103(ComboBox comboBox_0, string string_0)
	{
		comboBox_0.set_Text(string_0);
	}

	static string smethod_104(object object_0)
	{
		return Conversions.ToString(object_0);
	}

	static void smethod_105(DateTimePicker dateTimePicker_0, string string_0)
	{
		dateTimePicker_0.set_Text(string_0);
	}

	static void smethod_106(Control control_0)
	{
		control_0.Hide();
	}

	static void smethod_107(TextBoxBase textBoxBase_0)
	{
		textBoxBase_0.Clear();
	}

	static void smethod_108(RadioButton radioButton_0, bool bool_0)
	{
		radioButton_0.set_Checked(bool_0);
	}

	static string smethod_109(ComboBox comboBox_0)
	{
		return comboBox_0.get_Text();
	}

	static string smethod_110(DateTimePicker dateTimePicker_0)
	{
		return dateTimePicker_0.get_Text();
	}

	static DateTime smethod_111(DateTimePicker dateTimePicker_0)
	{
		return dateTimePicker_0.get_Value();
	}

	static string smethod_112(DateTime dateTime_0)
	{
		return Conversions.ToString(dateTime_0);
	}

	static OleDbCommand smethod_113(string string_0, OleDbConnection oleDbConnection_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new OleDbCommand(string_0, oleDbConnection_0);
	}

	static int smethod_114(OleDbCommand oleDbCommand_0)
	{
		return oleDbCommand_0.ExecuteNonQuery();
	}

	static void smethod_115(Component component_0)
	{
		component_0.Dispose();
	}

	static MsgBoxResult smethod_116(object object_0, MsgBoxStyle msgBoxStyle_0, object object_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		return Interaction.MsgBox(object_0, msgBoxStyle_0, object_1);
	}

	static string smethod_117(string string_0, string string_1, string string_2)
	{
		return string_0 + string_1 + string_2;
	}

	static OleDbCommand smethod_118()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new OleDbCommand();
	}

	static void smethod_119(ComboBox comboBox_0, int int_0)
	{
		comboBox_0.set_SelectedIndex(int_0);
	}
}
