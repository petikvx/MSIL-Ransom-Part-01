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
			Button clearBtn = _ClearBtn;
			while (true)
			{
				int num = -697735474;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF9AF489Bu) % 8u)
					{
					case 7u:
						_ClearBtn = value;
						num = -1337844496;
						continue;
					case 6u:
						UpdateStaff_Admin.smethod_63((Control)(object)clearBtn, eventHandler_);
						num = (int)(num2 * 1659402848) ^ -427419838;
						continue;
					case 5u:
					{
						int num5;
						int num6;
						if (clearBtn != null)
						{
							num5 = -541110054;
							num6 = -541110054;
						}
						else
						{
							num5 = -883255105;
							num6 = -883255105;
						}
						num = num5 ^ ((int)num2 * -332951881);
						continue;
					}
					case 4u:
					{
						int num3;
						int num4;
						if (clearBtn != null)
						{
							num3 = 713850609;
							num4 = 713850609;
						}
						else
						{
							num3 = 1808174814;
							num4 = 1808174814;
						}
						num = num3 ^ ((int)num2 * -1232239139);
						continue;
					}
					case 3u:
						clearBtn = _ClearBtn;
						num = ((int)num2 * -852075473) ^ -1667173710;
						continue;
					case 2u:
						UpdateStaff_Admin.smethod_62((Control)(object)clearBtn, eventHandler_);
						num = ((int)num2 * -1423606169) ^ -40507342;
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
				goto IL_001a;
			}
			goto IL_00b2;
			IL_00b2:
			_Receptionistbtn = value;
			int num = 1156409994;
			goto IL_0085;
			IL_0085:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x69BF73DFu) % 7u)
				{
				case 5u:
					break;
				case 4u:
					UpdateStaff_Admin.smethod_65(receptionistbtn, eventHandler_);
					num = ((int)num2 * -1435746524) ^ -1064840091;
					continue;
				case 3u:
					UpdateStaff_Admin.smethod_64(receptionistbtn, eventHandler_);
					num = ((int)num2 * -2013329651) ^ 0x1E2C1D2;
					continue;
				case 2u:
					receptionistbtn = _Receptionistbtn;
					num = (int)((num2 * 1121942791) ^ 0x26E8ACDD);
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (receptionistbtn == null)
					{
						num3 = -598152792;
						num4 = -598152792;
					}
					else
					{
						num3 = -1187742749;
						num4 = -1187742749;
					}
					num = num3 ^ ((int)num2 * -895857751);
					continue;
				}
				default:
					return;
				case 1u:
					goto IL_00b2;
				case 6u:
					return;
				}
				break;
			}
			goto IL_001a;
			IL_001a:
			num = 21811997;
			goto IL_0085;
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
			RadioButton nurseBtn = default(RadioButton);
			while (true)
			{
				int num = -866401566;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC89BA40Du) % 8u)
					{
					case 7u:
						nurseBtn = _NurseBtn;
						num = (int)(num2 * 1064289856) ^ -1655019761;
						continue;
					case 6u:
						UpdateStaff_Admin.smethod_64(nurseBtn, eventHandler_);
						num = (int)((num2 * 1844661043) ^ 0x5E4CBDFC);
						continue;
					case 3u:
						_NurseBtn = value;
						nurseBtn = _NurseBtn;
						num = -1641166356;
						continue;
					case 2u:
					{
						int num5;
						int num6;
						if (nurseBtn != null)
						{
							num5 = 2075633831;
							num6 = 2075633831;
						}
						else
						{
							num5 = 2057156962;
							num6 = 2057156962;
						}
						num = num5 ^ (int)(num2 * 963748566);
						continue;
					}
					case 1u:
					{
						int num3;
						int num4;
						if (nurseBtn == null)
						{
							num3 = 35293712;
							num4 = 35293712;
						}
						else
						{
							num3 = 1887323477;
							num4 = 1887323477;
						}
						num = num3 ^ (int)(num2 * 57789272);
						continue;
					}
					case 0u:
						UpdateStaff_Admin.smethod_65(nurseBtn, eventHandler_);
						num = ((int)num2 * -1610717312) ^ -1966261688;
						continue;
					default:
						return;
					case 4u:
						break;
					case 5u:
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
				int num = 867036906;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6A1EB518u) % 8u)
					{
					case 7u:
						_DoctorBtn = value;
						num = 870763910;
						continue;
					case 6u:
						doctorBtn = _DoctorBtn;
						num = ((int)num2 * -581093649) ^ -497573737;
						continue;
					case 5u:
					{
						int num5;
						int num6;
						if (doctorBtn != null)
						{
							num5 = 1107417354;
							num6 = 1107417354;
						}
						else
						{
							num5 = 1809749797;
							num6 = 1809749797;
						}
						num = num5 ^ ((int)num2 * -38321730);
						continue;
					}
					case 4u:
						UpdateStaff_Admin.smethod_65(doctorBtn, eventHandler_);
						num = (int)(num2 * 423733184) ^ -90372477;
						continue;
					case 2u:
					{
						doctorBtn = _DoctorBtn;
						int num3;
						int num4;
						if (doctorBtn != null)
						{
							num3 = -1732892283;
							num4 = -1732892283;
						}
						else
						{
							num3 = -702506693;
							num4 = -702506693;
						}
						num = num3 ^ ((int)num2 * -847012134);
						continue;
					}
					case 1u:
						UpdateStaff_Admin.smethod_64(doctorBtn, eventHandler_);
						num = (int)((num2 * 1376103127) ^ 0x52AA2820);
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
			if (searchBtn != null)
			{
				goto IL_0032;
			}
			goto IL_00b4;
			IL_00b4:
			_SearchBtn = value;
			int num = 1186971823;
			goto IL_0087;
			IL_0087:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5064EF0Cu) % 7u)
				{
				case 6u:
					searchBtn = _SearchBtn;
					num = (int)(num2 * 793303171) ^ -380522746;
					continue;
				case 4u:
					break;
				case 2u:
					UpdateStaff_Admin.smethod_62((Control)(object)searchBtn, eventHandler_);
					num = ((int)num2 * -402191827) ^ 0x270D8A91;
					continue;
				case 1u:
					UpdateStaff_Admin.smethod_63((Control)(object)searchBtn, eventHandler_);
					num = (int)((num2 * 223369218) ^ 0x38C2A33D);
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (searchBtn == null)
					{
						num3 = -671049156;
						num4 = -671049156;
					}
					else
					{
						num3 = -914951953;
						num4 = -914951953;
					}
					num = num3 ^ (int)(num2 * 1257421663);
					continue;
				}
				default:
					return;
				case 5u:
					goto IL_00b4;
				case 3u:
					return;
				}
				break;
			}
			goto IL_0032;
			IL_0032:
			num = 992569506;
			goto IL_0087;
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
				int num = 1998445529;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3BB95F50u) % 8u)
					{
					case 6u:
						UpdateStaff_Admin.smethod_67(searchResultGrid, dataGridViewCellMouseEventHandler_);
						num = (int)(num2 * 1703563546) ^ -1677620656;
						continue;
					case 5u:
						_SearchResultGrid = value;
						num = 1892974003;
						continue;
					case 3u:
					{
						searchResultGrid = _SearchResultGrid;
						int num5;
						int num6;
						if (searchResultGrid != null)
						{
							num5 = -1628494468;
							num6 = -1628494468;
						}
						else
						{
							num5 = -2120925178;
							num6 = -2120925178;
						}
						num = num5 ^ ((int)num2 * -13266578);
						continue;
					}
					case 2u:
						UpdateStaff_Admin.smethod_66(searchResultGrid, dataGridViewCellMouseEventHandler_);
						num = (int)((num2 * 1252202007) ^ 0x634E82B);
						continue;
					case 1u:
						searchResultGrid = _SearchResultGrid;
						num = (int)(num2 * 52347144) ^ -1554571528;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (searchResultGrid == null)
						{
							num3 = -408942915;
							num4 = -408942915;
						}
						else
						{
							num3 = -341621110;
							num4 = -341621110;
						}
						num = num3 ^ (int)(num2 * 504830480);
						continue;
					}
					default:
						return;
					case 7u:
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
			if (updateBtn != null)
			{
				goto IL_001a;
			}
			goto IL_009f;
			IL_009f:
			_UpdateBtn = value;
			int num = 1746997725;
			goto IL_0076;
			IL_0076:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x35ECBA1Eu) % 6u)
				{
				case 5u:
					break;
				case 4u:
					UpdateStaff_Admin.smethod_63((Control)(object)updateBtn, eventHandler_);
					num = (int)(num2 * 1401090714) ^ -1398801982;
					continue;
				case 3u:
					UpdateStaff_Admin.smethod_62((Control)(object)updateBtn, eventHandler_);
					num = (int)((num2 * 389972325) ^ 0x61A11643);
					continue;
				case 1u:
				{
					updateBtn = _UpdateBtn;
					int num3;
					int num4;
					if (updateBtn != null)
					{
						num3 = -1605230811;
						num4 = -1605230811;
					}
					else
					{
						num3 = -1475372933;
						num4 = -1475372933;
					}
					num = num3 ^ (int)(num2 * 1606842183);
					continue;
				}
				default:
					return;
				case 2u:
					goto IL_009f;
				case 0u:
					return;
				}
				break;
			}
			goto IL_001a;
			IL_001a:
			num = 447285553;
			goto IL_0076;
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
			Button deleteBtn = _DeleteBtn;
			if (deleteBtn != null)
			{
				goto IL_0052;
			}
			goto IL_0088;
			IL_0088:
			_DeleteBtn = value;
			deleteBtn = _DeleteBtn;
			int num;
			int num2;
			if (deleteBtn != null)
			{
				num = -1591635138;
				num2 = -1591635138;
			}
			else
			{
				num = -1179129973;
				num2 = -1179129973;
			}
			goto IL_0057;
			IL_0057:
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num ^ 0xB54DCE95u) % 5u)
				{
				case 2u:
					UpdateStaff_Admin.smethod_63((Control)(object)deleteBtn, eventHandler_);
					num = ((int)num3 * -486143641) ^ 0x60515546;
					continue;
				case 1u:
					UpdateStaff_Admin.smethod_62((Control)(object)deleteBtn, eventHandler_);
					num = (int)((num3 * 436668943) ^ 0x32F03E3A);
					continue;
				case 0u:
					break;
				default:
					return;
				case 4u:
					goto IL_0088;
				case 3u:
					return;
				}
				break;
			}
			goto IL_0052;
			IL_0052:
			num = -1522051137;
			goto IL_0057;
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
			int num = -764997581;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA66082E8u) % 7u)
				{
				case 6u:
					num = (int)(num2 * 185605218) ^ -463168262;
					continue;
				case 5u:
					UpdateStaff_Admin.smethod_0((UserControl)(object)this, (EventHandler)UpdateStaff_Admin_Load);
					num = ((int)num2 * -472664289) ^ 0x28F9A999;
					continue;
				case 3u:
					myconnection = UpdateStaff_Admin.smethod_1();
					day = UpdateStaff_Admin.smethod_2(DateTime.Now.ToString("HH"));
					num = (int)(num2 * 1474312700) ^ -346726307;
					continue;
				case 2u:
					num = ((int)num2 * -1342829826) ^ -455473633;
					continue;
				case 1u:
					InitializeComponent();
					num = (int)((num2 * 1556778809) ^ 0x57F31413);
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

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing)
			{
				goto IL_0026;
			}
			goto IL_0093;
			IL_0026:
			int num = -284193813;
			goto IL_005b;
			IL_005b:
			int num3;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9BC35D95u) % 7u)
				{
				case 6u:
					num = (int)(num2 * 2127627387) ^ -2042084187;
					continue;
				case 4u:
					break;
				case 3u:
					num = -1082223664;
					continue;
				case 2u:
					num = (int)(num2 * 779611478) ^ -1097542248;
					continue;
				case 0u:
					UpdateStaff_Admin.smethod_3((IDisposable)components);
					num = ((int)num2 * -238597771) ^ 0x761D297D;
					continue;
				default:
					return;
				case 1u:
					goto IL_0088;
				case 5u:
					return;
				}
				break;
				IL_0088:
				if (components != null)
				{
					num = -1224965092;
					num3 = -1224965092;
					continue;
				}
				goto IL_0093;
			}
			goto IL_0026;
			IL_0093:
			num = -19773292;
			num3 = -19773292;
			goto IL_005b;
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
			int num = -1677542994;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB31D685Eu) % 361u)
				{
				case 360u:
					num = (int)(num2 * 321610863) ^ -1042744872;
					continue;
				case 359u:
					Label12 = UpdateStaff_Admin.smethod_5();
					num = (int)(num2 * 115704131) ^ -1096471710;
					continue;
				case 358u:
					num = (int)(num2 * 276673818) ^ -1299380731;
					continue;
				case 357u:
					UpdateStaff_Admin.smethod_26(Label11, "SID :");
					num = ((int)num2 * -766106808) ^ 0xE0A5B2B;
					continue;
				case 356u:
					UpdateStaff_Admin.smethod_18((Control)(object)WorkShiftTxt, "WorkShiftTxt");
					num = (int)(num2 * 457960203) ^ -1053449166;
					continue;
				case 355u:
					UpdateStaff_Admin.smethod_17((Control)(object)NameTxt, new Point(124, 77));
					num = (int)(num2 * 459082683) ^ -703518769;
					continue;
				case 354u:
					num = ((int)num2 * -885806818) ^ 0x2C2A4D73;
					continue;
				case 353u:
					num = (int)(num2 * 2029099050) ^ -1312196434;
					continue;
				case 352u:
					num = (int)(num2 * 2048551881) ^ -993960368;
					continue;
				case 351u:
					UpdateStaff_Admin.smethod_18((Control)(object)Label4, "Label4");
					num = (int)(num2 * 1595727334) ^ -1052481116;
					continue;
				case 350u:
					UpdateStaff_Admin.smethod_31(GroupBox1, "Search Staff Member");
					UpdateStaff_Admin.smethod_32((ButtonBase)(object)ClearBtn, Color.MidnightBlue);
					num = ((int)num2 * -638145227) ^ -1937154996;
					continue;
				case 349u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)Label5);
					num = (int)((num2 * 1601171565) ^ 0xCB6A9D1);
					continue;
				case 348u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)Label9);
					num = (int)((num2 * 1324782169) ^ 0x59817969);
					continue;
				case 347u:
					num = (int)(num2 * 1920045358) ^ -774118058;
					continue;
				case 346u:
					UpdateStaff_Admin.smethod_25((Control)(object)SearchResultGrid, 9);
					num = (int)((num2 * 418301786) ^ 0x2102459C);
					continue;
				case 345u:
					DoctorBtn = UpdateStaff_Admin.smethod_8();
					num = (int)(num2 * 299931031) ^ -1904312288;
					continue;
				case 344u:
					num = (int)((num2 * 273801843) ^ 0x334282D);
					continue;
				case 343u:
					UpdateStaff_Admin.smethod_19((Control)(object)SIDTxt, new Size(204, 28));
					num = (int)(num2 * 1949127095) ^ -119884681;
					continue;
				case 342u:
					UpdateStaff_Admin.smethod_17((Control)(object)ClearBtn, new Point(467, 30));
					UpdateStaff_Admin.smethod_18((Control)(object)ClearBtn, "ClearBtn");
					num = ((int)num2 * -1538705944) ^ -1964150306;
					continue;
				case 341u:
					UpdateStaff_Admin.smethod_27(Label9, (ContentAlignment)32);
					num = ((int)num2 * -913249858) ^ 0x405239A1;
					continue;
				case 340u:
					num = (int)((num2 * 577859928) ^ 0x191AC33A);
					continue;
				case 339u:
					UpdateStaff_Admin.smethod_25((Control)(object)DOBTxt, 18);
					num = ((int)num2 * -255974932) ^ -843771713;
					continue;
				case 338u:
					UpdateStaff_Admin.smethod_25((Control)(object)NameSTxt, 1);
					UpdateStaff_Admin.smethod_24((Control)(object)Label2, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -2137382730) ^ 0x38843B9B;
					continue;
				case 337u:
					num = ((int)num2 * -1524013928) ^ 0x5A760EA;
					continue;
				case 336u:
					num = (int)((num2 * 1819724960) ^ 0xC1D9A93);
					continue;
				case 335u:
					UpdateStaff_Admin.smethod_46(DesignationTxt, (ComboBoxStyle)2);
					num = (int)((num2 * 1989720130) ^ 0xE8A1014);
					continue;
				case 334u:
					num = ((int)num2 * -1844378279) ^ -532116168;
					continue;
				case 333u:
					num = (int)((num2 * 1148641624) ^ 0x6032F8AE);
					continue;
				case 332u:
					num = ((int)num2 * -1744326780) ^ -398938826;
					continue;
				case 331u:
					num = (int)((num2 * 1499920251) ^ 0x3EE06E25);
					continue;
				case 330u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)DesignationTxt);
					num = ((int)num2 * -313659580) ^ -882977406;
					continue;
				case 329u:
					UpdateStaff_Admin.smethod_27(Label8, (ContentAlignment)32);
					num = (int)((num2 * 1993072429) ^ 0x5E2AA070);
					continue;
				case 328u:
					UpdateStaff_Admin.smethod_35((ButtonBase)(object)Receptionistbtn, bool_0: true);
					num = ((int)num2 * -1685347953) ^ -1025754853;
					continue;
				case 327u:
					UpdateStaff_Admin.smethod_17((Control)(object)EmailTxt, new Point(124, 123));
					num = (int)((num2 * 1278340816) ^ 0x55C2E408);
					continue;
				case 326u:
					UpdateStaff_Admin.smethod_25((Control)(object)DoctorBtn, 5);
					num = (int)(num2 * 415212414) ^ -1624136248;
					continue;
				case 325u:
					PictureBox1 = UpdateStaff_Admin.smethod_4();
					num = ((int)num2 * -1305764601) ^ 0x3AE38F72;
					continue;
				case 324u:
					UpdateStaff_Admin.smethod_24((Control)(object)Label5, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1298009802) ^ 0x35656304;
					continue;
				case 323u:
					num = (int)(num2 * 1498378517) ^ -225183178;
					continue;
				case 322u:
					UpdateStaff_Admin.smethod_19((Control)(object)GenderTxt, new Size(156, 30));
					UpdateStaff_Admin.smethod_25((Control)(object)GenderTxt, 21);
					num = ((int)num2 * -2101041281) ^ -1188347218;
					continue;
				case 321u:
					num = ((int)num2 * -1604368955) ^ -396536391;
					continue;
				case 320u:
					num = ((int)num2 * -1698699718) ^ 0x7A2F7A56;
					continue;
				case 319u:
					num = (int)((num2 * 1619131131) ^ 0x5545846A);
					continue;
				case 318u:
					num = ((int)num2 * -1293825043) ^ -386299298;
					continue;
				case 317u:
					UpdateStaff_Admin.smethod_21(PictureBox1, 5);
					num = ((int)num2 * -1356122147) ^ -1105342638;
					continue;
				case 316u:
					UpdateStaff_Admin.smethod_19((Control)(object)DetailsBox, new Size(699, 313));
					UpdateStaff_Admin.smethod_25((Control)(object)DetailsBox, 10);
					num = (int)(num2 * 1196408883) ^ -1700657945;
					continue;
				case 315u:
					UpdateStaff_Admin.smethod_18((Control)(object)NameTxt, "NameTxt");
					num = ((int)num2 * -1909773881) ^ -469879611;
					continue;
				case 313u:
					UpdateStaff_Admin.smethod_35((ButtonBase)(object)NurseBtn, bool_0: true);
					num = (int)(num2 * 1608507355) ^ -1558199469;
					continue;
				case 312u:
					num = (int)((num2 * 2008947932) ^ 0x7517C361);
					continue;
				case 311u:
					UpdateStaff_Admin.smethod_25((Control)(object)DeleteBtn, 17);
					num = (int)(num2 * 904748271) ^ -1478104734;
					continue;
				case 310u:
					UpdateStaff_Admin.smethod_18((Control)(object)DesignationTxt, "DesignationTxt");
					num = ((int)num2 * -748548158) ^ -1332393656;
					continue;
				case 309u:
					UpdateStaff_Admin.smethod_49(UpdateStaff_Admin.smethod_48(WorkShiftTxt), new object[2] { "Day", "Night" });
					num = ((int)num2 * -152356785) ^ -254280038;
					continue;
				case 308u:
					MobileTxt = UpdateStaff_Admin.smethod_9();
					num = ((int)num2 * -1253213978) ^ 0x712E4107;
					continue;
				case 307u:
					UpdateStaff_Admin.smethod_19((Control)(object)Receptionistbtn, new Size(132, 23));
					num = (int)(num2 * 29107137) ^ -1001233589;
					continue;
				case 306u:
					num = (int)((num2 * 446115105) ^ 0x50235685);
					continue;
				case 305u:
					num = (int)(num2 * 399485401) ^ -451973456;
					continue;
				case 304u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_55((Control)(object)this), (Control)(object)GroupBox1);
					num = ((int)num2 * -81496461) ^ -384285084;
					continue;
				case 303u:
					UpdateStaff_Admin.smethod_33((Control)(object)DeleteBtn, Color.White);
					UpdateStaff_Admin.smethod_17((Control)(object)DeleteBtn, new Point(790, 680));
					num = (int)((num2 * 1588804299) ^ 0x718381C0);
					continue;
				case 302u:
					num = (int)((num2 * 1547584117) ^ 0x750D3F3);
					continue;
				case 301u:
					UpdateStaff_Admin.smethod_17((Control)(object)AddressTxt, new Point(124, 217));
					UpdateStaff_Admin.smethod_52(AddressTxt, bool_0: true);
					num = (int)(num2 * 563478202) ^ -1309774989;
					continue;
				case 300u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_55((Control)(object)this), (Control)(object)DeleteBtn);
					num = ((int)num2 * -1428417088) ^ -1896727916;
					continue;
				case 299u:
					num = ((int)num2 * -346569966) ^ 0xC526ECD;
					continue;
				case 298u:
					num = (int)((num2 * 442568757) ^ 0x3CE86C5C);
					continue;
				case 297u:
					UpdateStaff_Admin.smethod_60((Control)(object)DetailsBox);
					num = ((int)num2 * -442626264) ^ -2103890208;
					continue;
				case 296u:
					UpdateStaff_Admin.smethod_33((Control)(object)ClearBtn, Color.White);
					num = (int)((num2 * 1630380909) ^ 0x648F9B85);
					continue;
				case 295u:
					UpdateStaff_Admin.smethod_18((Control)(object)ShowAvailability, "ShowAvailability");
					num = ((int)num2 * -1190091739) ^ 0x35A38B8D;
					continue;
				case 294u:
					UpdateStaff_Admin.smethod_18((Control)(object)Label2, "Label2");
					UpdateStaff_Admin.smethod_19((Control)(object)Label2, new Size(77, 28));
					num = (int)((num2 * 1656164898) ^ 0x4310CC5C);
					continue;
				case 293u:
					num = ((int)num2 * -21663295) ^ 0x1265EBC9;
					continue;
				case 292u:
					WorkShiftTxt = UpdateStaff_Admin.smethod_12();
					num = ((int)num2 * -1623321966) ^ -818863991;
					continue;
				case 291u:
					GenderTxt = UpdateStaff_Admin.smethod_12();
					num = (int)((num2 * 919140136) ^ 0x5B06EB7E);
					continue;
				case 290u:
					UpdateStaff_Admin.smethod_31(DetailsBox, "Staff Member Detail");
					num = (int)(num2 * 429364912) ^ -960410859;
					continue;
				case 289u:
					num = (int)(num2 * 1675112297) ^ -1199734970;
					continue;
				case 288u:
					num = (int)((num2 * 1581406214) ^ 0xD54407);
					continue;
				case 287u:
					num = ((int)num2 * -557909788) ^ -977111535;
					continue;
				case 285u:
					num = (int)(num2 * 1159584722) ^ -1490943357;
					continue;
				case 284u:
					UpdateStaff_Admin.smethod_24((Control)(object)SearchBtn, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1232237188) ^ -278030957;
					continue;
				case 283u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)GroupBox1), (Control)(object)DoctorBtn);
					num = ((int)num2 * -283877023) ^ -2132579886;
					continue;
				case 282u:
					num = ((int)num2 * -747727134) ^ -297884417;
					continue;
				case 281u:
					UpdateStaff_Admin.smethod_25((Control)(object)MobileTxt, 12);
					UpdateStaff_Admin.smethod_24((Control)(object)Label9, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 56841364) ^ 0x7B00D45F);
					continue;
				case 280u:
					UpdateStaff_Admin.smethod_24((Control)(object)Label1, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1755948855) ^ 0xA473EC4);
					continue;
				case 279u:
					UpdateStaff_Admin.smethod_24((Control)(object)DeleteBtn, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1451895755) ^ -191219919;
					continue;
				case 278u:
					UpdateStaff_Admin.smethod_19((Control)(object)Label4, new Size(68, 25));
					UpdateStaff_Admin.smethod_25((Control)(object)Label4, 0);
					UpdateStaff_Admin.smethod_26(Label4, "Email :");
					num = (int)(num2 * 1562058481) ^ -2081693953;
					continue;
				case 277u:
					UpdateStaff_Admin.smethod_18((Control)(object)SearchResultGrid, "SearchResultGrid");
					num = ((int)num2 * -1031512603) ^ 0x38390EBE;
					continue;
				case 276u:
					num = (int)((num2 * 751958643) ^ 0xB426764);
					continue;
				case 275u:
					UpdateStaff_Admin.smethod_18((Control)(object)DoctorBtn, "DoctorBtn");
					num = (int)((num2 * 35647334) ^ 0x3B273538);
					continue;
				case 274u:
					UpdateStaff_Admin.smethod_27(ShowAvailability, (ContentAlignment)32);
					UpdateStaff_Admin.smethod_24((Control)(object)Label3, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1568495229) ^ -1206796128;
					continue;
				case 273u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)DOBTxt);
					num = ((int)num2 * -196531560) ^ -83559696;
					continue;
				case 272u:
					num = ((int)num2 * -901486583) ^ -1239423596;
					continue;
				case 271u:
					UpdateStaff_Admin.smethod_17((Control)(object)DoctorBtn, new Point(65, 84));
					num = ((int)num2 * -1410470413) ^ 0x7DF60E14;
					continue;
				case 270u:
					SearchBtn = UpdateStaff_Admin.smethod_7();
					num = ((int)num2 * -498218903) ^ -1694322279;
					continue;
				case 269u:
					UpdateStaff_Admin.smethod_37(NurseBtn, bool_0: true);
					UpdateStaff_Admin.smethod_34((ButtonBase)(object)NurseBtn, "Nurse");
					num = ((int)num2 * -1808793923) ^ -2137409489;
					continue;
				case 268u:
					UpdateStaff_Admin.smethod_25((Control)(object)SearchBtn, 4);
					UpdateStaff_Admin.smethod_34((ButtonBase)(object)SearchBtn, "Search");
					num = ((int)num2 * -934175323) ^ 0x745E9473;
					continue;
				case 267u:
					UpdateStaff_Admin.smethod_13((ISupportInitialize)PictureBox1);
					num = (int)((num2 * 317760512) ^ 0x510A9AC5);
					continue;
				case 266u:
					UpdateStaff_Admin.smethod_18((Control)(object)Receptionistbtn, "Receptionistbtn");
					num = ((int)num2 * -904125800) ^ -1631846326;
					continue;
				case 265u:
					num = (int)(num2 * 1577615731) ^ -198041699;
					continue;
				case 264u:
					UpdateStaff_Admin.smethod_17((Control)(object)Label2, new Point(37, 44));
					num = ((int)num2 * -622156931) ^ 0x2892FCD;
					continue;
				case 263u:
					num = (int)(num2 * 805916268) ^ -64494933;
					continue;
				case 262u:
					num = (int)((num2 * 1343445565) ^ 0x5679DE0C);
					continue;
				case 261u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)MobileTxt);
					num = (int)((num2 * 1376188454) ^ 0x1140BB83);
					continue;
				case 260u:
					UpdateStaff_Admin.smethod_42(DOBTxt, (DateTimePickerFormat)2);
					num = (int)(num2 * 103160875) ^ -1161992626;
					continue;
				case 259u:
					UpdateStaff_Admin.smethod_49(UpdateStaff_Admin.smethod_48(DesignationTxt), new object[4] { "Doctor", "Nurse", "Receptionist", "Admin" });
					num = (int)(num2 * 92666717) ^ -972074682;
					continue;
				case 258u:
					UpdateStaff_Admin.smethod_18((Control)(object)Label5, "Label5");
					num = (int)((num2 * 1504653186) ^ 0x7FC5E3B);
					continue;
				case 257u:
					UpdateStaff_Admin.smethod_25((Control)(object)DesignationTxt, 20);
					UpdateStaff_Admin.smethod_46(GenderTxt, (ComboBoxStyle)2);
					UpdateStaff_Admin.smethod_47((ListControl)(object)GenderTxt, bool_0: true);
					UpdateStaff_Admin.smethod_49(UpdateStaff_Admin.smethod_48(GenderTxt), new object[3] { "Male", "Female", "Others" });
					num = (int)(num2 * 674900803) ^ -2059020111;
					continue;
				case 256u:
					UpdateStaff_Admin.smethod_17((Control)(object)NurseBtn, new Point(174, 84));
					num = ((int)num2 * -1686316325) ^ 0x54DC74BC;
					continue;
				case 255u:
					EmailTxt = UpdateStaff_Admin.smethod_9();
					num = (int)(num2 * 1279887120) ^ -535510683;
					continue;
				case 254u:
					UpdateStaff_Admin.smethod_17((Control)(object)Label11, new Point(16, 36));
					num = ((int)num2 * -152755329) ^ -1179922382;
					continue;
				case 253u:
					num = ((int)num2 * -1588024922) ^ -1194149067;
					continue;
				case 252u:
					UpdateStaff_Admin.smethod_58((ISupportInitialize)SearchResultGrid);
					num = (int)((num2 * 232322392) ^ 0xD017BA9);
					continue;
				case 251u:
					num = (int)((num2 * 1203250244) ^ 0x50032488);
					continue;
				case 250u:
					Label7 = UpdateStaff_Admin.smethod_5();
					num = (int)((num2 * 1628545319) ^ 0x23FE9D6F);
					continue;
				case 249u:
					NameSTxt = UpdateStaff_Admin.smethod_9();
					num = ((int)num2 * -104897088) ^ 0x56DB0885;
					continue;
				case 248u:
					UpdateStaff_Admin.smethod_18((Control)(object)NameSTxt, "NameSTxt");
					num = (int)((num2 * 734764786) ^ 0x6109F8B);
					continue;
				case 247u:
					UpdateStaff_Admin.smethod_17((Control)(object)Label7, new Point(16, 217));
					num = (int)((num2 * 221030530) ^ 0x157899CB);
					continue;
				case 246u:
					num = ((int)num2 * -112233829) ^ -1013993520;
					continue;
				case 245u:
					UpdateStaff_Admin.smethod_25((Control)(object)Label1, 6);
					num = ((int)num2 * -285453760) ^ -250253646;
					continue;
				case 244u:
					DetailsBox = UpdateStaff_Admin.smethod_6();
					num = (int)((num2 * 1816076801) ^ 0x16E2C99E);
					continue;
				case 243u:
					num = ((int)num2 * -850275041) ^ -1098134403;
					continue;
				case 242u:
					num = ((int)num2 * -42655558) ^ 0x2D38FE7E;
					continue;
				case 241u:
					Label8 = UpdateStaff_Admin.smethod_5();
					num = (int)(num2 * 807488877) ^ -2093245409;
					continue;
				case 240u:
					num = ((int)num2 * -225169112) ^ 0x45511764;
					continue;
				case 239u:
					num = ((int)num2 * -829582692) ^ 0x7DE2175;
					continue;
				case 238u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_55((Control)(object)this), (Control)(object)DetailsBox);
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_55((Control)(object)this), (Control)(object)SearchResultGrid);
					num = (int)(num2 * 975746439) ^ -334268153;
					continue;
				case 237u:
					UpdateStaff_Admin.smethod_19((Control)(object)ShowAvailability, new Size(204, 23));
					num = ((int)num2 * -1502800852) ^ -2032150203;
					continue;
				case 236u:
					num = (int)(num2 * 1538197347) ^ -2109670537;
					continue;
				case 235u:
					UpdateStaff_Admin.smethod_57((Control)(object)this, new Size(977, 804));
					num = (int)(num2 * 370079521) ^ -1512080298;
					continue;
				case 234u:
					UpdateStaff_Admin.smethod_56((Control)(object)this, "UpdateStaff_Admin");
					num = ((int)num2 * -107936420) ^ -398783937;
					continue;
				case 233u:
					UpdateStaff_Admin.smethod_17((Control)(object)Label4, new Point(16, 126));
					num = (int)(num2 * 1119888025) ^ -1886646212;
					continue;
				case 232u:
					UpdateStaff_Admin.smethod_18((Control)(object)Label11, "Label11");
					UpdateStaff_Admin.smethod_19((Control)(object)Label11, new Size(68, 25));
					UpdateStaff_Admin.smethod_25((Control)(object)Label11, 16);
					num = (int)((num2 * 1988618544) ^ 0x6D90E74B);
					continue;
				case 231u:
					num = ((int)num2 * -1562492026) ^ -1843311504;
					continue;
				case 230u:
					UpdateStaff_Admin.smethod_51((Control)(object)ShowAvailability, Color.Red);
					num = (int)(num2 * 494983904) ^ -1140916372;
					continue;
				case 229u:
					num = (int)((num2 * 1903471425) ^ 0x21BCACB8);
					continue;
				case 228u:
					UpdateStaff_Admin.smethod_17((Control)(object)SearchBtn, new Point(467, 73));
					num = (int)(num2 * 1071415102) ^ -1365529373;
					continue;
				case 227u:
					UpdateStaff_Admin.smethod_19((Control)(object)PictureBox1, new Size(144, 141));
					num = (int)(num2 * 1027229427) ^ -253787439;
					continue;
				case 226u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_55((Control)(object)this), (Control)(object)Label1);
					num = ((int)num2 * -473256652) ^ -329412151;
					continue;
				case 225u:
					UpdateStaff_Admin.smethod_26(Label8, "Name : ");
					num = ((int)num2 * -1641455500) ^ -1813607955;
					continue;
				case 224u:
					num = (int)((num2 * 1491903665) ^ 0x7EA02B79);
					continue;
				case 223u:
					UpdateStaff_Admin.smethod_19((Control)(object)Label8, new Size(77, 28));
					UpdateStaff_Admin.smethod_25((Control)(object)Label8, 9);
					num = ((int)num2 * -614637137) ^ -1874304318;
					continue;
				case 222u:
					UpdateStaff_Admin.smethod_17((Control)(object)UpdateBtn, new Point(790, 608));
					UpdateStaff_Admin.smethod_18((Control)(object)UpdateBtn, "UpdateBtn");
					UpdateStaff_Admin.smethod_19((Control)(object)UpdateBtn, new Size(122, 33));
					num = ((int)num2 * -188015942) ^ -775128420;
					continue;
				case 221u:
					UpdateStaff_Admin.smethod_32((ButtonBase)(object)DeleteBtn, Color.MidnightBlue);
					num = (int)(num2 * 1335928635) ^ -327095961;
					continue;
				case 220u:
					UpdateStaff_Admin.smethod_61((Control)(object)this, bool_0: false);
					num = ((int)num2 * -934725992) ^ 0x2FDC7321;
					continue;
				case 219u:
					num = (int)(num2 * 997930999) ^ -610542589;
					continue;
				case 218u:
					UpdateStaff_Admin.smethod_17((Control)(object)DesignationTxt, new Point(505, 72));
					num = (int)(num2 * 42290535) ^ -887678284;
					continue;
				case 217u:
					UpdateStaff_Admin.smethod_35((ButtonBase)(object)UpdateBtn, bool_0: false);
					num = ((int)num2 * -648375482) ^ 0x343886BA;
					continue;
				case 216u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)Label8);
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)AddressTxt);
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)NameTxt);
					num = (int)(num2 * 162169934) ^ -1953811054;
					continue;
				case 215u:
					Label3 = UpdateStaff_Admin.smethod_5();
					num = (int)(num2 * 2009770944) ^ -2043436063;
					continue;
				case 214u:
					UpdateStaff_Admin.smethod_26(Label12, "Work Shift : ");
					num = ((int)num2 * -358045098) ^ 0x61E19ECD;
					continue;
				case 213u:
					DOBTxt = UpdateStaff_Admin.smethod_11();
					num = (int)(num2 * 713551138) ^ -1518083870;
					continue;
				case 212u:
					UpdateStaff_Admin.smethod_25((Control)(object)Label5, 1);
					num = (int)(num2 * 1380042274) ^ -1628166015;
					continue;
				case 211u:
					UpdateStaff_Admin.smethod_17((Control)(object)NameSTxt, new Point(120, 44));
					num = (int)(num2 * 1167114511) ^ -1577177604;
					continue;
				case 210u:
					UpdateStaff_Admin.smethod_26(Label1, "Update Staff");
					num = (int)(num2 * 1184232427) ^ -320831989;
					continue;
				case 209u:
					num = ((int)num2 * -361282334) ^ 0x25C71755;
					continue;
				case 208u:
					num = ((int)num2 * -386142016) ^ 0x54C619ED;
					continue;
				case 207u:
					UpdateStaff_Admin.smethod_27(Label1, (ContentAlignment)32);
					num = (int)(num2 * 286912418) ^ -2059202659;
					continue;
				case 206u:
					Label11 = UpdateStaff_Admin.smethod_5();
					num = (int)((num2 * 1169506734) ^ 0x3C88C92D);
					continue;
				case 205u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)Label7);
					num = (int)(num2 * 852633280) ^ -732542270;
					continue;
				case 204u:
					Receptionistbtn = UpdateStaff_Admin.smethod_8();
					NurseBtn = UpdateStaff_Admin.smethod_8();
					num = (int)(num2 * 755948605) ^ -21130714;
					continue;
				case 203u:
					UpdateStaff_Admin.smethod_36((ButtonBase)(object)DoctorBtn, bool_0: true);
					UpdateStaff_Admin.smethod_24((Control)(object)DoctorBtn, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1789774074) ^ 0x3513ED13;
					continue;
				case 202u:
					UpdateStaff_Admin.smethod_46(WorkShiftTxt, (ComboBoxStyle)2);
					UpdateStaff_Admin.smethod_47((ListControl)(object)WorkShiftTxt, bool_0: true);
					num = ((int)num2 * -608558092) ^ -1922012625;
					continue;
				case 201u:
					num = ((int)num2 * -1025028572) ^ 0x4350649;
					continue;
				case 200u:
					num = (int)((num2 * 1299128700) ^ 0x21411438);
					continue;
				case 199u:
					num = ((int)num2 * -586789860) ^ 0x2D7FF04B;
					continue;
				case 198u:
					num = ((int)num2 * -1735295604) ^ 0xD6E79E0;
					continue;
				case 197u:
					UpdateStaff_Admin.smethod_35((ButtonBase)(object)DeleteBtn, bool_0: false);
					num = ((int)num2 * -1093286223) ^ -2008558953;
					continue;
				case 196u:
					num = (int)((num2 * 450787719) ^ 0x35B7A7FB);
					continue;
				case 195u:
					num = ((int)num2 * -448922239) ^ 0x283F275;
					continue;
				case 194u:
					UpdateStaff_Admin.smethod_17((Control)(object)GenderTxt, new Point(521, 163));
					num = (int)((num2 * 2129136985) ^ 0x65697D4);
					continue;
				case 193u:
					UpdateStaff_Admin.smethod_25((Control)(object)Label9, 11);
					num = ((int)num2 * -475838219) ^ 0x16F3B81;
					continue;
				case 192u:
					UpdateStaff_Admin.smethod_19((Control)(object)MobileTxt, new Size(271, 28));
					num = ((int)num2 * -1860944113) ^ 0x2E3F8908;
					continue;
				case 191u:
					num = (int)(num2 * 1567170320) ^ -688583863;
					continue;
				case 190u:
					num = ((int)num2 * -133319881) ^ -1233532721;
					continue;
				case 189u:
					UpdateStaff_Admin.smethod_44(DOBTxt, new DateTime(1900, 1, 1, 0, 0, 0, 0));
					num = (int)(num2 * 2080771141) ^ -535932804;
					continue;
				case 188u:
					num = (int)(num2 * 747531570) ^ -1605096610;
					continue;
				case 187u:
					UpdateStaff_Admin.smethod_17((Control)(object)DetailsBox, new Point(79, 470));
					num = ((int)num2 * -222257827) ^ -74805371;
					continue;
				case 186u:
					UpdateStaff_Admin.smethod_25((Control)(object)NameTxt, 4);
					UpdateStaff_Admin.smethod_24((Control)(object)Label7, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 640594913) ^ -1219664547;
					continue;
				case 185u:
					UpdateStaff_Admin.smethod_18((Control)(object)DetailsBox, "DetailsBox");
					num = ((int)num2 * -871802012) ^ -1144618885;
					continue;
				case 184u:
					UpdateStaff_Admin.smethod_59((Control)(object)GroupBox1, bool_0: false);
					num = ((int)num2 * -1604797854) ^ 0x27E8C957;
					continue;
				case 183u:
					UpdateStaff_Admin.smethod_19((Control)(object)NameSTxt, new Size(292, 28));
					num = ((int)num2 * -1526284758) ^ 0x6E87D1A7;
					continue;
				case 182u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)Label6);
					num = (int)(num2 * 530454475) ^ -1615363001;
					continue;
				case 181u:
					UpdateStaff_Admin.smethod_18((Control)(object)DeleteBtn, "DeleteBtn");
					num = ((int)num2 * -797510586) ^ -576486276;
					continue;
				case 180u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)Label4);
					num = ((int)num2 * -770610841) ^ 0x72D0CF34;
					continue;
				case 179u:
					num = ((int)num2 * -2058353587) ^ 0x1A0DBC3;
					continue;
				case 178u:
					num = ((int)num2 * -1936602884) ^ -623377885;
					continue;
				case 177u:
					UpdateStaff_Admin.smethod_17((Control)(object)GroupBox1, new Point(155, 150));
					num = ((int)num2 * -1620221223) ^ -1180393310;
					continue;
				case 176u:
					num = ((int)num2 * -1038170466) ^ 0x4706AF30;
					continue;
				case 175u:
					UpdateStaff_Admin.smethod_17((Control)(object)Label6, new Point(417, 169));
					num = (int)(num2 * 1985580797) ^ -631128910;
					continue;
				case 174u:
					UpdateStaff_Admin.smethod_24((Control)(object)GroupBox1, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1815967369) ^ -1376315662;
					continue;
				case 173u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_55((Control)(object)this), (Control)(object)PictureBox1);
					num = ((int)num2 * -2013443892) ^ 0x7A41AE31;
					continue;
				case 172u:
					UpdateStaff_Admin.smethod_22(PictureBox1, bool_0: false);
					num = (int)(num2 * 449861351) ^ -1738241992;
					continue;
				case 171u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)Label12);
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)SIDTxt);
					num = ((int)num2 * -230336456) ^ -954378318;
					continue;
				case 170u:
					num = ((int)num2 * -1126650226) ^ 0x4B76CDCD;
					continue;
				case 169u:
					UpdateStaff_Admin.smethod_19((Control)(object)Label9, new Size(77, 28));
					num = ((int)num2 * -1747051730) ^ 0x645BA;
					continue;
				case 168u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)GroupBox1), (Control)(object)ClearBtn);
					num = (int)((num2 * 1351641851) ^ 0x11E36183);
					continue;
				case 167u:
					num = ((int)num2 * -1474163845) ^ -1819714223;
					continue;
				case 166u:
					UpdateStaff_Admin.smethod_25((Control)(object)ShowAvailability, 15);
					UpdateStaff_Admin.smethod_26(ShowAvailability, "UnAvailable");
					num = ((int)num2 * -587699510) ^ -348280787;
					continue;
				case 165u:
					UpdateStaff_Admin.smethod_19((Control)(object)ClearBtn, new Size(133, 37));
					num = (int)(num2 * 58589973) ^ -1172423463;
					continue;
				case 164u:
					num = ((int)num2 * -864922584) ^ -1858120021;
					continue;
				case 163u:
					UpdateStaff_Admin.smethod_24((Control)(object)Label8, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1494201850) ^ -1495849971;
					continue;
				case 162u:
					num = (int)(num2 * 971182391) ^ -1510502809;
					continue;
				case 161u:
					UpdateStaff_Admin.smethod_18((Control)(object)EmailTxt, "EmailTxt");
					num = ((int)num2 * -1326140351) ^ -2004397814;
					continue;
				case 160u:
					Label1 = UpdateStaff_Admin.smethod_5();
					num = ((int)num2 * -2088941228) ^ 0x1565DB80;
					continue;
				case 159u:
					UpdateStaff_Admin.smethod_18((Control)(object)Label7, "Label7");
					num = (int)(num2 * 1181696200) ^ -650545663;
					continue;
				case 158u:
					num = ((int)num2 * -1473181675) ^ 0x3F86BD97;
					continue;
				case 157u:
					num = (int)(num2 * 1924950451) ^ -1523327207;
					continue;
				case 156u:
					num = (int)((num2 * 777045777) ^ 0x5AF57D07);
					continue;
				case 155u:
					SIDTxt = UpdateStaff_Admin.smethod_9();
					num = ((int)num2 * -1922474596) ^ 0x5EC6ACD6;
					continue;
				case 154u:
					UpdateStaff_Admin.smethod_17((Control)(object)SIDTxt, new Point(124, 36));
					num = (int)((num2 * 1000100630) ^ 0x4CA6AADB);
					continue;
				case 153u:
					UpdateStaff_Admin.smethod_37(DoctorBtn, bool_0: true);
					num = ((int)num2 * -327409856) ^ -1036332233;
					continue;
				case 152u:
					UpdateStaff_Admin.smethod_24((Control)(object)Receptionistbtn, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					UpdateStaff_Admin.smethod_17((Control)(object)Receptionistbtn, new Point(280, 84));
					num = (int)((num2 * 1253680644) ^ 0x1CDF3359);
					continue;
				case 151u:
					UpdateStaff_Admin.smethod_19((Control)(object)EmailTxt, new Size(271, 28));
					num = ((int)num2 * -1349725948) ^ -1175142562;
					continue;
				case 150u:
					UpdateStaff_Admin.smethod_26(Label3, "Designation : ");
					UpdateStaff_Admin.smethod_27(Label3, (ContentAlignment)32);
					UpdateStaff_Admin.smethod_17((Control)(object)MobileTxt, new Point(124, 169));
					num = ((int)num2 * -2144802492) ^ -1075421065;
					continue;
				case 149u:
					num = (int)((num2 * 533597609) ^ 0x10FCAAA0);
					continue;
				case 148u:
					UpdateStaff_Admin.smethod_25((Control)(object)UpdateBtn, 16);
					UpdateStaff_Admin.smethod_34((ButtonBase)(object)UpdateBtn, "Update");
					num = (int)(num2 * 920577500) ^ -1010380959;
					continue;
				case 147u:
					UpdateStaff_Admin.smethod_14((Control)(object)GroupBox1);
					num = (int)((num2 * 1340101954) ^ 0x791FEB81);
					continue;
				case 146u:
					UpdateStaff_Admin.smethod_17((Control)(object)DOBTxt, new Point(505, 118));
					UpdateStaff_Admin.smethod_43(DOBTxt, new DateTime(2019, 2, 12, 0, 0, 0, 0));
					num = ((int)num2 * -489825351) ^ 0xCA5275C;
					continue;
				case 145u:
					UpdateStaff_Admin.smethod_36((ButtonBase)(object)NurseBtn, bool_0: true);
					UpdateStaff_Admin.smethod_24((Control)(object)NurseBtn, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1188918462) ^ -731014635;
					continue;
				case 144u:
					UpdateStaff_Admin.smethod_18((Control)(object)Label1, "Label1");
					num = ((int)num2 * -2270308) ^ 0x4EC523B4;
					continue;
				case 143u:
					ClearBtn = UpdateStaff_Admin.smethod_7();
					num = (int)((num2 * 1193070470) ^ 0x43266047);
					continue;
				case 142u:
					num = (int)(num2 * 255493128) ^ -6889824;
					continue;
				case 141u:
					UpdateStaff_Admin.smethod_25((Control)(object)Label6, 2);
					num = ((int)num2 * -1006207100) ^ 0x384C3686;
					continue;
				case 140u:
					UpdateStaff_Admin.smethod_32((ButtonBase)(object)UpdateBtn, Color.MidnightBlue);
					UpdateStaff_Admin.smethod_24((Control)(object)UpdateBtn, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -2062786282) ^ 0x375763E7;
					continue;
				case 139u:
					UpdateStaff_Admin.smethod_26(Label2, "Name : ");
					num = ((int)num2 * -929789339) ^ 0x2ECC1B2E;
					continue;
				case 138u:
					UpdateStaff_Admin.smethod_60((Control)(object)GroupBox1);
					num = ((int)num2 * -1945576934) ^ -1375450541;
					continue;
				case 137u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)Label11);
					num = (int)(num2 * 1349573956) ^ -2072371789;
					continue;
				case 136u:
					UpdateStaff_Admin.smethod_17((Control)(object)Label9, new Point(16, 169));
					num = ((int)num2 * -1301617586) ^ 0x264C8253;
					continue;
				case 135u:
					UpdateStaff_Admin.smethod_19((Control)(object)AddressTxt, new Size(271, 90));
					num = ((int)num2 * -873771729) ^ 0x10A6155F;
					continue;
				case 134u:
					num = (int)(num2 * 1159627974) ^ -525297872;
					continue;
				case 133u:
					UpdateStaff_Admin.smethod_53((ContainerControl)(object)this, new SizeF(8f, 16f));
					num = ((int)num2 * -1532356005) ^ -88846345;
					continue;
				case 132u:
					num = ((int)num2 * -1521176088) ^ 0x68392E5E;
					continue;
				case 131u:
					num = (int)(num2 * 1650591425) ^ -377343142;
					continue;
				case 130u:
					num = ((int)num2 * -1637543703) ^ -1623213815;
					continue;
				case 129u:
					UpdateStaff_Admin.smethod_25((Control)(object)SIDTxt, 17);
					num = (int)((num2 * 2040904747) ^ 0x385CC70F);
					continue;
				case 128u:
					UpdateStaff_Admin.smethod_15((Control)(object)this);
					num = ((int)num2 * -1250217825) ^ 0x2303D3DA;
					continue;
				case 127u:
					UpdateStaff_Admin.smethod_45(DOBTxt, new DateTime(2019, 2, 12, 0, 0, 0, 0));
					num = ((int)num2 * -1684298402) ^ -1964195142;
					continue;
				case 126u:
					num = ((int)num2 * -459841868) ^ 0x8B5D0CC;
					continue;
				case 125u:
					UpdateStaff_Admin.smethod_25((Control)(object)EmailTxt, 10);
					num = ((int)num2 * -285176421) ^ -205596035;
					continue;
				case 124u:
					UpdateStaff_Admin.smethod_19((Control)(object)Label7, new Size(98, 26));
					UpdateStaff_Admin.smethod_25((Control)(object)Label7, 3);
					num = (int)((num2 * 981017029) ^ 0x3281ACFF);
					continue;
				case 123u:
					UpdateStaff_Admin.smethod_18((Control)(object)NurseBtn, "NurseBtn");
					UpdateStaff_Admin.smethod_19((Control)(object)NurseBtn, new Size(78, 23));
					num = ((int)num2 * -23202185) ^ -1739218085;
					continue;
				case 122u:
					UpdateStaff_Admin.smethod_16(PictureBox1, (Image)(object)Resources.doc_Pic);
					UpdateStaff_Admin.smethod_17((Control)(object)PictureBox1, new Point(242, 3));
					num = (int)((num2 * 872840221) ^ 0x37438C77);
					continue;
				case 121u:
					UpdateStaff_Admin.smethod_34((ButtonBase)(object)DoctorBtn, "Doctor");
					num = ((int)num2 * -179118307) ^ -2019762825;
					continue;
				case 120u:
					UpdateStaff_Admin.smethod_19((Control)(object)DesignationTxt, new Size(170, 30));
					num = (int)((num2 * 426406872) ^ 0x1F74E7AD);
					continue;
				case 119u:
					UpdateStaff_Admin.smethod_30(GroupBox1, bool_0: false);
					num = (int)(num2 * 1068795113) ^ -1852310978;
					continue;
				case 118u:
					num = ((int)num2 * -1631837467) ^ 0x234027FB;
					continue;
				case 117u:
					UpdateStaff_Admin.smethod_19((Control)(object)WorkShiftTxt, new Size(134, 30));
					num = (int)((num2 * 1251039367) ^ 0x28EDC3EF);
					continue;
				case 116u:
					num = (int)((num2 * 75041472) ^ 0x4B9BC8D0);
					continue;
				case 115u:
					num = (int)(num2 * 944020485) ^ -203211843;
					continue;
				case 114u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)GroupBox1), (Control)(object)SearchBtn);
					num = ((int)num2 * -975660016) ^ 0x503D1573;
					continue;
				case 113u:
					UpdateStaff_Admin.smethod_17((Control)(object)Label12, new Point(417, 223));
					num = (int)((num2 * 1676364225) ^ 0x2654B4CA);
					continue;
				case 112u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)WorkShiftTxt);
					num = (int)((num2 * 27422265) ^ 0x6688D91C);
					continue;
				case 111u:
					Label9 = UpdateStaff_Admin.smethod_5();
					num = ((int)num2 * -604619315) ^ -372008641;
					continue;
				case 110u:
					UpdateStaff_Admin.smethod_25((Control)(object)Receptionistbtn, 7);
					num = ((int)num2 * -2128922410) ^ 0x6B85497A;
					continue;
				case 109u:
					Label4 = UpdateStaff_Admin.smethod_5();
					num = (int)((num2 * 704418985) ^ 0x78A054AF);
					continue;
				case 108u:
					num = ((int)num2 * -1020673140) ^ -643088012;
					continue;
				case 107u:
					UpdateStaff_Admin.smethod_24((Control)(object)Label11, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1278821176) ^ -831079034;
					continue;
				case 106u:
					UpdateStaff_Admin.smethod_17((Control)(object)SearchResultGrid, new Point(59, 295));
					num = (int)(num2 * 165128069) ^ -259124223;
					continue;
				case 105u:
					num = ((int)num2 * -1970569566) ^ -332285397;
					continue;
				case 104u:
					UpdateStaff_Admin.smethod_34((ButtonBase)(object)ClearBtn, "Clear");
					num = ((int)num2 * -456515438) ^ 0x6C21616E;
					continue;
				case 103u:
					num = ((int)num2 * -1792001269) ^ -1165232652;
					continue;
				case 102u:
					SearchResultGrid = UpdateStaff_Admin.smethod_10();
					num = (int)(num2 * 579649984) ^ -1608103411;
					continue;
				case 101u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)ShowAvailability);
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)Label3);
					num = ((int)num2 * -411429100) ^ -1030481762;
					continue;
				case 100u:
					UpdateStaff_Admin.smethod_17((Control)(object)Label1, new Point(392, 63));
					num = (int)((num2 * 799905802) ^ 0x2472B538);
					continue;
				case 99u:
					num = ((int)num2 * -293746880) ^ -1176950519;
					continue;
				case 98u:
					num = (int)((num2 * 589189386) ^ 0x163F9F0D);
					continue;
				case 97u:
					num = ((int)num2 * -317530342) ^ 0x6ECC94A9;
					continue;
				case 96u:
					UpdateStaff_Admin.smethod_18((Control)(object)Label9, "Label9");
					num = (int)((num2 * 62961384) ^ 0x278E3ECE);
					continue;
				case 95u:
					UpdateStaff_Admin.smethod_19((Control)(object)DoctorBtn, new Size(87, 23));
					num = (int)((num2 * 1718994682) ^ 0x1240DB2D);
					continue;
				case 94u:
					num = ((int)num2 * -1681095214) ^ 0x5D7AE6E0;
					continue;
				case 93u:
					GroupBox1 = UpdateStaff_Admin.smethod_6();
					num = ((int)num2 * -1417842154) ^ -48090155;
					continue;
				case 92u:
					UpdateStaff_Admin.smethod_19((Control)(object)GroupBox1, new Size(623, 127));
					num = ((int)num2 * -218160100) ^ -1753439577;
					continue;
				case 91u:
					num = ((int)num2 * -1363492332) ^ -780997493;
					continue;
				case 90u:
					num = (int)(num2 * 672297700) ^ -2060462186;
					continue;
				case 89u:
					num = ((int)num2 * -1625640152) ^ -193068382;
					continue;
				case 88u:
					Label2 = UpdateStaff_Admin.smethod_5();
					num = ((int)num2 * -993774629) ^ -206631811;
					continue;
				case 87u:
					UpdateStaff_Admin.smethod_19((Control)(object)NameTxt, new Size(237, 28));
					num = (int)((num2 * 996411121) ^ 0x36ACC6D0);
					continue;
				case 86u:
					num = (int)((num2 * 454946317) ^ 0x7CB9A7BF);
					continue;
				case 85u:
					UpdateStaff_Admin.smethod_18((Control)(object)SearchBtn, "SearchBtn");
					UpdateStaff_Admin.smethod_19((Control)(object)SearchBtn, new Size(133, 37));
					num = ((int)num2 * -1120183728) ^ -316489226;
					continue;
				case 84u:
					UpdateStaff_Admin.smethod_58((ISupportInitialize)PictureBox1);
					num = ((int)num2 * -471878775) ^ 0x2171B4D6;
					continue;
				case 83u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)GroupBox1), (Control)(object)Label2);
					num = ((int)num2 * -946947747) ^ 0x15687A1D;
					continue;
				case 82u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)GenderTxt);
					num = ((int)num2 * -1884371685) ^ -293749072;
					continue;
				case 81u:
					UpdateStaff_Admin.smethod_26(Label7, "Address : ");
					num = ((int)num2 * -1141765159) ^ -826416196;
					continue;
				case 80u:
					UpdateStaff_Admin.smethod_30(DetailsBox, bool_0: false);
					num = (int)(num2 * 2087121458) ^ -673576765;
					continue;
				case 79u:
					num = (int)(num2 * 1577661793) ^ -1790788554;
					continue;
				case 78u:
					UpdateStaff_Admin.smethod_25((Control)(object)Label2, 0);
					num = (int)(num2 * 2028554955) ^ -505964914;
					continue;
				case 77u:
					num = (int)(num2 * 1897454381) ^ -98115977;
					continue;
				case 76u:
					UpdateStaff_Admin.smethod_25((Control)(object)ClearBtn, 8);
					num = (int)((num2 * 1141195372) ^ 0x1AEAC12B);
					continue;
				case 75u:
					UpdateStaff_Admin.smethod_25((Control)(object)NurseBtn, 6);
					num = (int)(num2 * 1632781930) ^ -1845322250;
					continue;
				case 74u:
					UpdateStaff_Admin.smethod_33((Control)(object)SearchBtn, Color.White);
					num = ((int)num2 * -1019402001) ^ 0x1E279CA9;
					continue;
				case 73u:
					UpdateStaff_Admin.smethod_18((Control)(object)Label6, "Label6");
					UpdateStaff_Admin.smethod_19((Control)(object)Label6, new Size(84, 26));
					num = (int)((num2 * 2075680453) ^ 0x711DBD1);
					continue;
				case 72u:
					num = (int)((num2 * 798860759) ^ 0x16CE662A);
					continue;
				case 71u:
					UpdateBtn = UpdateStaff_Admin.smethod_7();
					num = (int)(num2 * 1953547457) ^ -1236388142;
					continue;
				case 70u:
					UpdateStaff_Admin.smethod_24((Control)(object)DetailsBox, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -667824153) ^ 0x3D616656;
					continue;
				case 69u:
					UpdateStaff_Admin.smethod_24((Control)(object)Label4, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 369166072) ^ 0x5EAEBBE4);
					continue;
				case 68u:
					UpdateStaff_Admin.smethod_20(PictureBox1, (PictureBoxSizeMode)1);
					num = ((int)num2 * -86002266) ^ -1463089926;
					continue;
				case 67u:
					num = (int)(num2 * 1402025574) ^ -1894210792;
					continue;
				case 66u:
					UpdateStaff_Admin.smethod_35((ButtonBase)(object)ClearBtn, bool_0: false);
					num = ((int)num2 * -65460471) ^ -615045308;
					continue;
				case 65u:
					num = ((int)num2 * -1324211519) ^ -1511551613;
					continue;
				case 64u:
					UpdateStaff_Admin.smethod_36((ButtonBase)(object)Receptionistbtn, bool_0: true);
					num = ((int)num2 * -839347293) ^ 0x1DC24D83;
					continue;
				case 63u:
					UpdateStaff_Admin.smethod_25((Control)(object)AddressTxt, 7);
					num = (int)(num2 * 1977408561) ^ -1571466529;
					continue;
				case 62u:
					UpdateStaff_Admin.smethod_18((Control)(object)Label12, "Label12");
					UpdateStaff_Admin.smethod_19((Control)(object)Label12, new Size(118, 26));
					UpdateStaff_Admin.smethod_25((Control)(object)Label12, 18);
					num = ((int)num2 * -1023345853) ^ 0x77C5B215;
					continue;
				case 61u:
					DeleteBtn = UpdateStaff_Admin.smethod_7();
					num = ((int)num2 * -601290450) ^ -1277386594;
					continue;
				case 60u:
					UpdateStaff_Admin.smethod_19((Control)(object)DeleteBtn, new Size(122, 33));
					num = ((int)num2 * -254948904) ^ -1074047374;
					continue;
				case 59u:
					UpdateStaff_Admin.smethod_27(Label2, (ContentAlignment)32);
					UpdateStaff_Admin.smethod_38(SearchResultGrid, Color.White);
					UpdateStaff_Admin.smethod_39(SearchResultGrid, (DataGridViewColumnHeadersHeightSizeMode)2);
					num = ((int)num2 * -363689863) ^ 0x5C68D245;
					continue;
				case 58u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)EmailTxt);
					num = (int)((num2 * 1486038372) ^ 0x82BC84C);
					continue;
				case 57u:
					UpdateStaff_Admin.smethod_18((Control)(object)SIDTxt, "SIDTxt");
					UpdateStaff_Admin.smethod_50((TextBoxBase)(object)SIDTxt, bool_0: true);
					num = ((int)num2 * -1661427521) ^ 0x2761A806;
					continue;
				case 56u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_55((Control)(object)this), (Control)(object)UpdateBtn);
					num = (int)((num2 * 950406580) ^ 0x1FABB17A);
					continue;
				case 55u:
					UpdateStaff_Admin.smethod_37(Receptionistbtn, bool_0: true);
					num = (int)(num2 * 1611107345) ^ -821042124;
					continue;
				case 54u:
					UpdateStaff_Admin.smethod_26(Label9, "Phone : ");
					num = ((int)num2 * -761391720) ^ -420824351;
					continue;
				case 53u:
					UpdateStaff_Admin.smethod_47((ListControl)(object)DesignationTxt, bool_0: true);
					num = ((int)num2 * -283198752) ^ -1356061286;
					continue;
				case 52u:
					num = ((int)num2 * -251497840) ^ -274180100;
					continue;
				case 51u:
					num = (int)(num2 * 229600182) ^ -285623732;
					continue;
				case 50u:
					UpdateStaff_Admin.smethod_34((ButtonBase)(object)Receptionistbtn, "Receptionist");
					num = ((int)num2 * -987153243) ^ 0x38A6FC47;
					continue;
				case 49u:
					UpdateStaff_Admin.smethod_17((Control)(object)Label5, new Point(417, 123));
					num = ((int)num2 * -1021625669) ^ -1730903759;
					continue;
				case 48u:
					num = (int)(num2 * 1531169545) ^ -2109147065;
					continue;
				case 47u:
					num = ((int)num2 * -494899180) ^ 0x62BC7311;
					continue;
				case 46u:
					UpdateStaff_Admin.smethod_24((Control)(object)Label12, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 707082378) ^ -501601744;
					continue;
				case 45u:
					UpdateStaff_Admin.smethod_25((Control)(object)GroupBox1, 8);
					num = (int)(num2 * 568226515) ^ -1265815547;
					continue;
				case 44u:
					UpdateStaff_Admin.smethod_32((ButtonBase)(object)SearchBtn, Color.MidnightBlue);
					num = (int)((num2 * 900705540) ^ 0x7D1022F9);
					continue;
				case 43u:
					num = ((int)num2 * -1030588354) ^ 0xCA2B90B;
					continue;
				case 42u:
					UpdateStaff_Admin.smethod_25((Control)(object)Label3, 13);
					num = (int)(num2 * 1993831349) ^ -217017746;
					continue;
				case 41u:
					UpdateStaff_Admin.smethod_26(Label5, "D.O.B. :");
					num = ((int)num2 * -1405888122) ^ -1898526992;
					continue;
				case 40u:
					UpdateStaff_Admin.smethod_19((Control)(object)Label1, new Size(330, 47));
					num = ((int)num2 * -2032727137) ^ 0x10AEBBE4;
					continue;
				case 39u:
					UpdateStaff_Admin.smethod_41(UpdateStaff_Admin.smethod_40(SearchResultGrid), 24);
					num = (int)(num2 * 931874870) ^ -1727777630;
					continue;
				case 38u:
					UpdateStaff_Admin.smethod_59((Control)(object)DetailsBox, bool_0: false);
					num = ((int)num2 * -244326330) ^ 0x39C7B319;
					continue;
				case 37u:
					ShowAvailability = UpdateStaff_Admin.smethod_5();
					num = (int)((num2 * 649252615) ^ 0x29C287AA);
					continue;
				case 36u:
					DesignationTxt = UpdateStaff_Admin.smethod_12();
					num = (int)((num2 * 1584340834) ^ 0x54EB0194);
					continue;
				case 35u:
					UpdateStaff_Admin.smethod_26(Label6, "Gender : ");
					num = ((int)num2 * -636228708) ^ -780003758;
					continue;
				case 34u:
					UpdateStaff_Admin.smethod_18((Control)(object)MobileTxt, "MobileTxt");
					num = ((int)num2 * -1498876846) ^ 0x43A9A840;
					continue;
				case 33u:
					UpdateStaff_Admin.smethod_18((Control)(object)PictureBox1, "PictureBox1");
					num = (int)(num2 * 563329464) ^ -1310099101;
					continue;
				case 32u:
					UpdateStaff_Admin.smethod_35((ButtonBase)(object)SearchBtn, bool_0: false);
					num = ((int)num2 * -106884795) ^ -1702881225;
					continue;
				case 31u:
					UpdateStaff_Admin.smethod_24((Control)(object)ClearBtn, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1195174779) ^ -1087170520;
					continue;
				case 30u:
					UpdateStaff_Admin.smethod_18((Control)(object)GenderTxt, "GenderTxt");
					num = (int)((num2 * 1933004288) ^ 0x6CA14C29);
					continue;
				case 29u:
					Label6 = UpdateStaff_Admin.smethod_5();
					Label5 = UpdateStaff_Admin.smethod_5();
					num = ((int)num2 * -1624403640) ^ 0x680A9580;
					continue;
				case 28u:
					UpdateStaff_Admin.smethod_17((Control)(object)Label3, new Point(367, 72));
					UpdateStaff_Admin.smethod_18((Control)(object)Label3, "Label3");
					UpdateStaff_Admin.smethod_19((Control)(object)Label3, new Size(134, 28));
					num = ((int)num2 * -1474405652) ^ 0x7A7A7AC4;
					continue;
				case 27u:
					UpdateStaff_Admin.smethod_25((Control)(object)WorkShiftTxt, 19);
					num = ((int)num2 * -277478913) ^ 0x70AA5FF2;
					continue;
				case 26u:
					num = (int)(num2 * 270054067) ^ -1806857875;
					continue;
				case 25u:
					num = ((int)num2 * -1328958569) ^ -1179348029;
					continue;
				case 24u:
					UpdateStaff_Admin.smethod_13((ISupportInitialize)SearchResultGrid);
					UpdateStaff_Admin.smethod_14((Control)(object)DetailsBox);
					num = (int)((num2 * 254975773) ^ 0x14307508);
					continue;
				case 23u:
					UpdateStaff_Admin.smethod_51((Control)(object)this, Color.White);
					num = ((int)num2 * -1735388849) ^ 0x5BBB4CD1;
					continue;
				case 22u:
					UpdateStaff_Admin.smethod_17((Control)(object)Label8, new Point(16, 78));
					num = ((int)num2 * -606085645) ^ 0x337ABE68;
					continue;
				case 21u:
					UpdateStaff_Admin.smethod_18((Control)(object)GroupBox1, "GroupBox1");
					num = (int)((num2 * 1616754176) ^ 0x66E581E5);
					continue;
				case 20u:
					UpdateStaff_Admin.smethod_18((Control)(object)Label8, "Label8");
					num = ((int)num2 * -1469540402) ^ -316694562;
					continue;
				case 19u:
					UpdateStaff_Admin.smethod_17((Control)(object)ShowAvailability, new Point(450, 24));
					num = (int)(num2 * 660186950) ^ -1984334830;
					continue;
				case 18u:
					UpdateStaff_Admin.smethod_34((ButtonBase)(object)DeleteBtn, "Delete");
					num = ((int)num2 * -59613309) ^ -619816753;
					continue;
				case 17u:
					UpdateStaff_Admin.smethod_33((Control)(object)UpdateBtn, Color.White);
					num = ((int)num2 * -1704352553) ^ 0x6B9AE81D;
					continue;
				case 16u:
					NameTxt = UpdateStaff_Admin.smethod_9();
					num = (int)(num2 * 1888804771) ^ -170570295;
					continue;
				case 15u:
					UpdateStaff_Admin.smethod_19((Control)(object)DOBTxt, new Size(171, 28));
					num = ((int)num2 * -1710489039) ^ -487703363;
					continue;
				case 14u:
					num = ((int)num2 * -2088016514) ^ 0x403C8C41;
					continue;
				case 13u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)GroupBox1), (Control)(object)Receptionistbtn);
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)GroupBox1), (Control)(object)NurseBtn);
					num = ((int)num2 * -741421554) ^ -918365745;
					continue;
				case 12u:
					AddressTxt = UpdateStaff_Admin.smethod_9();
					num = (int)((num2 * 1198051691) ^ 0x6E07420E);
					continue;
				case 11u:
					UpdateStaff_Admin.smethod_54((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -1377577614) ^ -2078165697;
					continue;
				case 10u:
					UpdateStaff_Admin.smethod_18((Control)(object)AddressTxt, "AddressTxt");
					num = (int)(num2 * 1386114928) ^ -346346773;
					continue;
				case 9u:
					UpdateStaff_Admin.smethod_24((Control)(object)Label6, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 611181313) ^ -2136882922;
					continue;
				case 8u:
					UpdateStaff_Admin.smethod_19((Control)(object)Label5, new Size(84, 26));
					num = ((int)num2 * -978116843) ^ 0x4DF945AA;
					continue;
				case 7u:
					UpdateStaff_Admin.smethod_35((ButtonBase)(object)DoctorBtn, bool_0: true);
					num = (int)(num2 * 186819875) ^ -758533112;
					continue;
				case 6u:
					UpdateStaff_Admin.smethod_19((Control)(object)SearchResultGrid, new Size(853, 169));
					num = ((int)num2 * -1054927892) ^ 0x1383A19D;
					continue;
				case 5u:
					num = (int)((num2 * 1700835669) ^ 0xA92ACC2);
					continue;
				case 4u:
					num = (int)(num2 * 1112273036) ^ -865693814;
					continue;
				case 3u:
					UpdateStaff_Admin.smethod_18((Control)(object)DOBTxt, "DOBTxt");
					num = (int)((num2 * 400192312) ^ 0x4425DD08);
					continue;
				case 2u:
					UpdateStaff_Admin.smethod_17((Control)(object)WorkShiftTxt, new Point(542, 217));
					num = (int)(num2 * 340050462) ^ -66622052;
					continue;
				case 1u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)GroupBox1), (Control)(object)NameSTxt);
					num = ((int)num2 * -471967332) ^ 0x3C882048;
					continue;
				case 0u:
					num = ((int)num2 * -1322762003) ^ -1873273969;
					continue;
				default:
					return;
				case 286u:
					break;
				case 314u:
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
			int num = -224617379;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC99FF36Au) % 4u)
				{
				case 3u:
					Designation = "";
					num = (int)((num2 * 1778582622) ^ 0x40065876);
					continue;
				case 2u:
					UpdateStaff_Admin.smethod_43(DOBTxt, UpdateStaff_Admin.smethod_71(UpdateStaff_Admin.smethod_70((object)DateTime.Now, "dd-MM-yyyy")));
					num = ((int)num2 * -1394271834) ^ -338243141;
					continue;
				case 0u:
					break;
				default:
					Hidedata();
					return;
				}
				break;
			}
		}
	}

	private void SearchBtn_Click(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected I4, but got Unknown
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Expected I4, but got Unknown
		//IL_03b6: Incompatible stack heights: 0 vs 1
		//IL_03c6: Incompatible stack heights: 0 vs 1
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Incompatible stack heights: 0 vs 1
		//IL_03e8: Incompatible stack heights: 0 vs 1
		bool flag2 = default(bool);
		DataTable dataTable_ = default(DataTable);
		bool flag = default(bool);
		while (true)
		{
			int num = -864136774;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x82492624u) % 11u)
				{
				case 10u:
					UpdateStaff_Admin.smethod_74("Enter Valid Name");
					num = (int)((num2 * 755650575) ^ 0x28FE2D61);
					continue;
				case 7u:
				{
					int num8;
					if (UpdateStaff_Admin.smethod_75(Designation, "", bool_0: false) == 0)
					{
						num = -1656327931;
						num8 = -1656327931;
					}
					else
					{
						num = -508772651;
						num8 = -508772651;
					}
					continue;
				}
				case 6u:
					flag2 = !MyProject.Forms.Form1.Name_Validation(UpdateStaff_Admin.smethod_73(UpdateStaff_Admin.smethod_72(NameSTxt)));
					num = ((int)num2 * -949898338) ^ -85469746;
					continue;
				case 4u:
				{
					int num6;
					int num7;
					if (flag2)
					{
						num6 = -877250221;
						num7 = -877250221;
					}
					else
					{
						num6 = -910954714;
						num7 = -910954714;
					}
					num = num6 ^ ((int)num2 * -1429958043);
					continue;
				}
				case 3u:
					Hidedata();
					num = ((int)num2 * -213375191) ^ 0x7554F8E8;
					continue;
				case 2u:
					num = (int)(num2 * 1294082220) ^ -987758851;
					continue;
				case 1u:
					UpdateStaff_Admin.smethod_74("click designation");
					num = (int)((num2 * 1114639967) ^ 0x5C43C56B);
					continue;
				case 9u:
					break;
				default:
					try
					{
						while (true)
						{
							int num3 = -1139491301;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x82492624u) % 17u)
								{
								case 16u:
									num3 = -308413362;
									continue;
								case 15u:
									UpdateStaff_Admin.smethod_85("Not Found.", "Result");
									num3 = (int)((num2 * 1597476156) ^ 0x77DBDC43);
									continue;
								case 14u:
									num3 = ((int)num2 * -85389612) ^ 0x4B3A58C4;
									continue;
								case 13u:
									dataTable_ = UpdateStaff_Admin.smethod_76();
									num3 = ((int)num2 * -433160822) ^ -1708958164;
									continue;
								case 12u:
									num3 = (int)(num2 * 239417084) ^ -1947989988;
									continue;
								case 10u:
								{
									OleDbDataAdapter dbDataAdapter_ = UpdateStaff_Admin.smethod_77();
									num3 = ((int)num2 * -1393820204) ^ 0x6F123147;
									continue;
								}
								case 8u:
									flag = UpdateStaff_Admin.smethod_84(SearchResultGrid) == 1;
									num3 = (int)(num2 * 1964203678) ^ -574195317;
									continue;
								case 7u:
									UpdateStaff_Admin.smethod_86(myconnection);
									num3 = (int)(num2 * 411541449) ^ -79431393;
									continue;
								case 6u:
								{
									int num4;
									int num5;
									if (!flag)
									{
										num4 = 1423723700;
										num5 = 1423723700;
									}
									else
									{
										num4 = 263336372;
										num5 = 263336372;
									}
									num3 = num4 ^ (int)(num2 * 1267593047);
									continue;
								}
								case 4u:
									UpdateStaff_Admin.smethod_86(myconnection);
									num3 = (int)(num2 * 1381740724) ^ -1307191851;
									continue;
								case 3u:
								{
									OleDbDataAdapter dbDataAdapter_ = UpdateStaff_Admin.smethod_80(UpdateStaff_Admin.smethod_79(new string[5]
									{
										"Select * from Staff where Name like '%",
										UpdateStaff_Admin.smethod_72(NameSTxt),
										"%'  And   Designation = '",
										Designation,
										"'"
									}), myconnection);
									UpdateStaff_Admin.smethod_81((DbDataAdapter)(object)dbDataAdapter_, dataTable_);
									UpdateStaff_Admin.smethod_83(SearchResultGrid, (object)UpdateStaff_Admin.smethod_82(dataTable_));
									num3 = (int)(num2 * 88573355) ^ -1299079991;
									continue;
								}
								case 2u:
									HideunusedColumns();
									num3 = ((int)num2 * -1649448501) ^ -1151500321;
									continue;
								case 1u:
									UpdateStaff_Admin.smethod_87((Control)(object)SearchResultGrid);
									num3 = ((int)num2 * -1672287502) ^ 0x5EA35A28;
									continue;
								case 0u:
									UpdateStaff_Admin.smethod_78(myconnection);
									num3 = ((int)num2 * -1478073148) ^ 0x6646AC22;
									continue;
								default:
									return;
								case 5u:
									break;
								case 9u:
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
						UpdateStaff_Admin.smethod_88(exception_);
						UpdateStaff_Admin.smethod_86(myconnection);
						while (true)
						{
							_ = -2088983044;
							while (true)
							{
								_003F val = /*Error near IL_0383: Stack underflow*/^ -2109135324;
								num2 = (uint)(int)val;
								switch (val % 5)
								{
								default:
									return;
								case 4:
									UpdateStaff_Admin.smethod_89();
									_ = (num2 * 2106940166) ^ 0x451379A2;
									continue;
								case 1:
									_ = ((int)num2 * -380142766) ^ -626707796;
									continue;
								case 0:
									UpdateStaff_Admin.smethod_74("Incorrect Credentials");
									_ = ((int)num2 * -488246095) ^ -210810501;
									continue;
								case 3:
									break;
								case 2:
									return;
								}
								break;
							}
						}
					}
				case 0u:
				case 5u:
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
			int num = -578598861;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCBABCAF2u) % 4u)
				{
				case 1u:
					UpdateStaff_Admin.smethod_92(UpdateStaff_Admin.smethod_91(UpdateStaff_Admin.smethod_90(SearchResultGrid), 7), bool_0: false);
					UpdateStaff_Admin.smethod_92(UpdateStaff_Admin.smethod_91(UpdateStaff_Admin.smethod_90(SearchResultGrid), 9), bool_0: false);
					num = (int)((num2 * 1905792022) ^ 0x2BB15B84);
					continue;
				case 0u:
					result = false;
					num = ((int)num2 * -1736746807) ^ -454938595;
					continue;
				case 2u:
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
		Designation = "Doctor";
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
		bool flag = (checked(UpdateStaff_Admin.smethod_93(e) + 1) == UpdateStaff_Admin.smethod_84(SearchResultGrid)) | (UpdateStaff_Admin.smethod_93(e) == -1);
		while (true)
		{
			int num = -18880529;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEA05F77Du) % 9u)
				{
				case 8u:
					UpdateStaff_Admin.smethod_87((Control)(object)UpdateBtn);
					num = ((int)num2 * -7449013) ^ -2022256008;
					continue;
				case 4u:
					num = (int)((num2 * 1483123005) ^ 0x6285E497);
					continue;
				case 3u:
					selectrow = UpdateStaff_Admin.smethod_93(e);
					num = -1565830788;
					continue;
				case 2u:
					UpdateStaff_Admin.smethod_94((Control)(object)DetailsBox, bool_0: true);
					num = (int)((num2 * 739608611) ^ 0x165767A7);
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -1576688298;
						num5 = -1576688298;
					}
					else
					{
						num4 = -379310848;
						num5 = -379310848;
					}
					num = num4 ^ ((int)num2 * -140927025);
					continue;
				}
				case 0u:
					UpdateStaff_Admin.smethod_87((Control)(object)DeleteBtn);
					num = ((int)num2 * -612263450) ^ 0x6ADD29B4;
					continue;
				case 5u:
					break;
				default:
					try
					{
						DataGridViewRow dataGridViewRow_ = UpdateStaff_Admin.smethod_95();
						while (true)
						{
							int num3 = -1008693297;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xEA05F77Du) % 13u)
								{
								case 12u:
									num3 = ((int)num2 * -1621203307) ^ -1223077634;
									continue;
								case 11u:
									num3 = ((int)num2 * -1312394707) ^ 0x505EA985;
									continue;
								case 10u:
									dataGridViewRow_ = UpdateStaff_Admin.smethod_97(UpdateStaff_Admin.smethod_96(SearchResultGrid), selectrow);
									UpdateStaff_Admin.smethod_102(SIDTxt, UpdateStaff_Admin.smethod_101(UpdateStaff_Admin.smethod_100(UpdateStaff_Admin.smethod_99(UpdateStaff_Admin.smethod_98(dataGridViewRow_), 0))));
									num3 = (int)(num2 * 1005316507) ^ -1573906941;
									continue;
								case 9u:
									UpdateStaff_Admin.smethod_102(MobileTxt, UpdateStaff_Admin.smethod_101(UpdateStaff_Admin.smethod_100(UpdateStaff_Admin.smethod_99(UpdateStaff_Admin.smethod_98(dataGridViewRow_), 5))));
									num3 = ((int)num2 * -1057993791) ^ -1761005987;
									continue;
								case 8u:
									num3 = (int)(num2 * 1278445357) ^ -1844178278;
									continue;
								case 7u:
									UpdateStaff_Admin.smethod_105(DOBTxt, UpdateStaff_Admin.smethod_104(UpdateStaff_Admin.smethod_100(UpdateStaff_Admin.smethod_99(UpdateStaff_Admin.smethod_98(dataGridViewRow_), 3))));
									num3 = ((int)num2 * -140297885) ^ 0xF75D583;
									continue;
								case 6u:
									UpdateStaff_Admin.smethod_103(DesignationTxt, UpdateStaff_Admin.smethod_101(UpdateStaff_Admin.smethod_100(UpdateStaff_Admin.smethod_99(UpdateStaff_Admin.smethod_98(dataGridViewRow_), 2))));
									num3 = ((int)num2 * -1804429653) ^ -875278066;
									continue;
								case 5u:
									putcolor(UpdateStaff_Admin.smethod_104(UpdateStaff_Admin.smethod_100(UpdateStaff_Admin.smethod_99(UpdateStaff_Admin.smethod_98(dataGridViewRow_), 8))));
									num3 = (int)(num2 * 598515857) ^ -1668218674;
									continue;
								case 4u:
									UpdateStaff_Admin.smethod_102(NameTxt, UpdateStaff_Admin.smethod_101(UpdateStaff_Admin.smethod_100(UpdateStaff_Admin.smethod_99(UpdateStaff_Admin.smethod_98(dataGridViewRow_), 1))));
									num3 = (int)((num2 * 1421619454) ^ 0x3326CF8C);
									continue;
								case 3u:
									UpdateStaff_Admin.smethod_103(GenderTxt, UpdateStaff_Admin.smethod_101(UpdateStaff_Admin.smethod_100(UpdateStaff_Admin.smethod_99(UpdateStaff_Admin.smethod_98(dataGridViewRow_), 4))));
									num3 = (int)(num2 * 1151705362) ^ -594407382;
									continue;
								case 2u:
									UpdateStaff_Admin.smethod_102(AddressTxt, UpdateStaff_Admin.smethod_101(UpdateStaff_Admin.smethod_100(UpdateStaff_Admin.smethod_99(UpdateStaff_Admin.smethod_98(dataGridViewRow_), 6))));
									UpdateStaff_Admin.smethod_103(WorkShiftTxt, UpdateStaff_Admin.smethod_101(UpdateStaff_Admin.smethod_100(UpdateStaff_Admin.smethod_99(UpdateStaff_Admin.smethod_98(dataGridViewRow_), 8))));
									num3 = ((int)num2 * -185540209) ^ -1842618774;
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
					catch (Exception exception_)
					{
						UpdateStaff_Admin.smethod_88(exception_);
						UpdateStaff_Admin.smethod_89();
						return;
					}
				case 6u:
					return;
				}
				break;
			}
		}
	}

	private void Hidedata()
	{
		while (true)
		{
			int num = 1696300530;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x40E63DD6u) % 7u)
				{
				case 6u:
					UpdateStaff_Admin.smethod_106((Control)(object)SearchResultGrid);
					num = ((int)num2 * -390196869) ^ -2116891232;
					continue;
				case 5u:
					num = (int)((num2 * 1304997133) ^ 0x30F46F14);
					continue;
				case 2u:
					UpdateStaff_Admin.smethod_94((Control)(object)DetailsBox, bool_0: false);
					num = ((int)num2 * -1865149140) ^ -814778110;
					continue;
				case 1u:
					UpdateStaff_Admin.smethod_106((Control)(object)DeleteBtn);
					num = ((int)num2 * -24522718) ^ -782048907;
					continue;
				case 0u:
					UpdateStaff_Admin.smethod_106((Control)(object)UpdateBtn);
					num = ((int)num2 * -1617223280) ^ 0x2498380A;
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
			int num = 1710966885;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x768D657Fu) % 13u)
				{
				case 12u:
					UpdateStaff_Admin.smethod_108(Receptionistbtn, bool_0: false);
					num = (int)(num2 * 430802951) ^ -649281753;
					continue;
				case 11u:
					UpdateStaff_Admin.smethod_107((TextBoxBase)(object)NameSTxt);
					num = ((int)num2 * -1472559678) ^ 0x62F81F94;
					continue;
				case 10u:
					Designation = "";
					num = ((int)num2 * -795650598) ^ 0x8761C38;
					continue;
				case 9u:
					num = (int)((num2 * 919136951) ^ 0x86A72D4);
					continue;
				case 8u:
					UpdateStaff_Admin.smethod_106((Control)(object)UpdateBtn);
					num = (int)((num2 * 1057330021) ^ 0x46A3CD90);
					continue;
				case 6u:
					UpdateStaff_Admin.smethod_94((Control)(object)DetailsBox, bool_0: false);
					num = (int)(num2 * 69353655) ^ -855083711;
					continue;
				case 5u:
					num = (int)(num2 * 1046014781) ^ -745786351;
					continue;
				case 4u:
					UpdateStaff_Admin.smethod_108(DoctorBtn, bool_0: false);
					num = (int)(num2 * 1208208045) ^ -2011398052;
					continue;
				case 3u:
					UpdateStaff_Admin.smethod_108(NurseBtn, bool_0: false);
					num = (int)((num2 * 693390204) ^ 0x1C82A8D4);
					continue;
				case 2u:
					num = ((int)num2 * -2206113) ^ -1907001531;
					continue;
				case 1u:
					UpdateStaff_Admin.smethod_106((Control)(object)SearchResultGrid);
					num = ((int)num2 * -1010554290) ^ -1571801349;
					continue;
				case 7u:
					break;
				default:
					UpdateStaff_Admin.smethod_106((Control)(object)DeleteBtn);
					return;
				}
				break;
			}
		}
	}

	private void putcolor(string WorkShift)
	{
		if (UpdateStaff_Admin.smethod_75(Shift(), WorkShift, bool_0: false) == 0)
		{
			goto IL_0038;
		}
		goto IL_007b;
		IL_007b:
		int num = 1842387961;
		goto IL_0052;
		IL_0052:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x2D0DCFFDu) % 6u)
			{
			case 4u:
				colourred();
				num = ((int)num2 * -544812011) ^ 0x38E04F90;
				continue;
			case 3u:
				num = (int)(num2 * 315878121) ^ -1160163786;
				continue;
			case 2u:
				break;
			case 1u:
				colourgreen();
				num = ((int)num2 * -2022381168) ^ 0x4635E7;
				continue;
			default:
				return;
			case 5u:
				goto IL_007b;
			case 0u:
				return;
			}
			break;
		}
		goto IL_0038;
		IL_0038:
		num = 896952422;
		goto IL_0052;
	}

	private string Shift()
	{
		string result = default(string);
		bool flag = default(bool);
		while (true)
		{
			int num = -1407063602;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDD8A46B5u) % 8u)
				{
				case 6u:
					result = "Day";
					num = ((int)num2 * -127176223) ^ 0x1DB4F0D3;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1739243802;
						num4 = 1739243802;
					}
					else
					{
						num3 = 215209637;
						num4 = 215209637;
					}
					num = num3 ^ (int)(num2 * 447347989);
					continue;
				}
				case 4u:
					result = "Night";
					num = ((int)num2 * -1550379865) ^ -693699525;
					continue;
				case 3u:
					flag = (day >= 7) & (day <= 19);
					num = (int)(num2 * 410868289) ^ -30718509;
					continue;
				case 2u:
					num = ((int)num2 * -1039823432) ^ 0x4EEEB22D;
					continue;
				case 1u:
					num = -270427655;
					continue;
				case 7u:
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
			int num = 17607751;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x79129364u) % 4u)
				{
				case 3u:
					UpdateStaff_Admin.smethod_51((Control)(object)ShowAvailability, Color.Green);
					num = (int)(num2 * 1563805224) ^ -234439704;
					continue;
				case 0u:
					UpdateStaff_Admin.smethod_26(ShowAvailability, "Available");
					num = (int)((num2 * 1445383103) ^ 0xD1ED545);
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

	private void colourred()
	{
		while (true)
		{
			int num = 2005056331;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x517BC8EDu) % 4u)
				{
				case 2u:
					UpdateStaff_Admin.smethod_51((Control)(object)ShowAvailability, Color.Red);
					num = (int)(num2 * 155632694) ^ -1445234024;
					continue;
				case 1u:
					UpdateStaff_Admin.smethod_26(ShowAvailability, "Unavilable");
					num = ((int)num2 * -1688602147) ^ 0x80CD53B;
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

	private void UpadateBtn_Click(object sender, EventArgs e)
	{
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Expected I4, but got Unknown
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Expected I4, but got Unknown
		//IL_03a6: Incompatible stack heights: 0 vs 1
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Incompatible stack heights: 0 vs 1
		//IL_03d5: Incompatible stack heights: 0 vs 1
		bool flag = (UpdateStaff_Admin.smethod_75(UpdateStaff_Admin.smethod_72(NameTxt), "", bool_0: false) == 0) | (UpdateStaff_Admin.smethod_75(UpdateStaff_Admin.smethod_72(MobileTxt), "", bool_0: false) == 0) | (UpdateStaff_Admin.smethod_75(UpdateStaff_Admin.smethod_109(GenderTxt), "", bool_0: false) == 0) | (UpdateStaff_Admin.smethod_75(UpdateStaff_Admin.smethod_110(DOBTxt), "", bool_0: false) == 0) | (UpdateStaff_Admin.smethod_75(UpdateStaff_Admin.smethod_109(DesignationTxt), "", bool_0: false) == 0) | (UpdateStaff_Admin.smethod_75(UpdateStaff_Admin.smethod_72(AddressTxt), "", bool_0: false) == 0) | (UpdateStaff_Admin.smethod_75(UpdateStaff_Admin.smethod_109(WorkShiftTxt), "", bool_0: false) == 0);
		string string_ = default(string);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -1899047196;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE507152Fu) % 11u)
				{
				case 10u:
					UpdateStaff_Admin.smethod_78(myconnection);
					num = ((int)num2 * -2128022649) ^ -1308184972;
					continue;
				case 8u:
				{
					int num6;
					int num7;
					if (!flag)
					{
						num6 = 536929303;
						num7 = 536929303;
					}
					else
					{
						num6 = 1606352533;
						num7 = 1606352533;
					}
					num = num6 ^ (int)(num2 * 1829522962);
					continue;
				}
				case 7u:
				{
					DateTime dateTime_ = UpdateStaff_Admin.smethod_71(UpdateStaff_Admin.smethod_70((object)UpdateStaff_Admin.smethod_111(DOBTxt), "dd-MM-yyyy"));
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
					flag2 = !(MyProject.Forms.Form1.Mobile_Validator(UpdateStaff_Admin.smethod_73(UpdateStaff_Admin.smethod_72(MobileTxt))) & MyProject.Forms.Form1.Name_Validation(UpdateStaff_Admin.smethod_73(UpdateStaff_Admin.smethod_72(NameTxt))) & MyProject.Forms.Form1.Gender_Validator(UpdateStaff_Admin.smethod_73(UpdateStaff_Admin.smethod_109(GenderTxt))));
					num = ((int)num2 * -13174296) ^ -493220171;
					continue;
				}
				case 5u:
					num = -1825299885;
					continue;
				case 4u:
					num = -1706416821;
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (!flag2)
					{
						num4 = -542772025;
						num5 = -542772025;
					}
					else
					{
						num4 = -573165454;
						num5 = -573165454;
					}
					num = num4 ^ ((int)num2 * -1645534526);
					continue;
				}
				case 1u:
					UpdateStaff_Admin.smethod_74("Invalid Credentials");
					num = ((int)num2 * -306439792) ^ -516004616;
					continue;
				case 9u:
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
							int num3 = -2020589362;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xE507152Fu) % 6u)
								{
								case 5u:
									UpdateStaff_Admin.smethod_115((Component)(object)val);
									num3 = (int)((num2 * 1777552339) ^ 0xE8DE374);
									continue;
								case 3u:
									UpdateStaff_Admin.smethod_74("Updated Sucessfully");
									UpdateStaff_Admin.smethod_86(myconnection);
									num3 = (int)(num2 * 826945833) ^ -352978920;
									continue;
								case 2u:
									ClearDetailsBox();
									num3 = ((int)num2 * -936171816) ^ 0x34D793C8;
									continue;
								case 1u:
									UpdateStaff_Admin.smethod_114(val);
									num3 = (int)(num2 * 94809219) ^ -638979643;
									continue;
								case 0u:
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
						UpdateStaff_Admin.smethod_88(exception_);
						while (true)
						{
							_ = -810796246;
							while (true)
							{
								_003F val2 = /*Error near IL_037c: Stack underflow*/^ -452520657;
								num2 = (uint)(int)val2;
								switch (val2 % 4)
								{
								case 1:
									_ = ((int)num2 * -1818765701) ^ 0x2EBB0218;
									continue;
								case 0:
									UpdateStaff_Admin.smethod_116((object)"Invalid Credentials", (MsgBoxStyle)0, (object)null);
									UpdateStaff_Admin.smethod_86(myconnection);
									_ = ((int)num2 * -1687983788) ^ -179953943;
									continue;
								case 3:
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
					return;
				}
				break;
			}
		}
	}

	private void DeleteBtn_Click(object sender, EventArgs e)
	{
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected I4, but got Unknown
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected I4, but got Unknown
		//IL_0255: Incompatible stack heights: 0 vs 1
		//IL_026a: Incompatible stack heights: 0 vs 1
		//IL_0271: Incompatible stack heights: 0 vs 1
		string string_ = default(string);
		while (true)
		{
			int num = -1417543846;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x86A5D9D3u) % 9u)
				{
				case 8u:
					UpdateStaff_Admin.smethod_78(myconnection);
					num = (int)(num2 * 332730299) ^ -191193;
					continue;
				case 6u:
					string_ = UpdateStaff_Admin.smethod_117("Delete from [Staff] where [SID] = ", UpdateStaff_Admin.smethod_72(SIDTxt), " ");
					num = ((int)num2 * -2025091046) ^ 0x67A1F6A4;
					continue;
				case 5u:
				{
					UpdateStaff_Admin.smethod_97(UpdateStaff_Admin.smethod_96(SearchResultGrid), selectrow);
					int num4;
					int num5;
					if (UpdateStaff_Admin.smethod_75(UpdateStaff_Admin.smethod_72(SIDTxt), "", bool_0: false) == 0)
					{
						num4 = -982677508;
						num5 = -982677508;
					}
					else
					{
						num4 = -1774657399;
						num5 = -1774657399;
					}
					num = num4 ^ ((int)num2 * -1699820917);
					continue;
				}
				case 4u:
					num = -1163539098;
					continue;
				case 1u:
					UpdateStaff_Admin.smethod_95();
					num = ((int)num2 * -112427327) ^ 0x69EF804B;
					continue;
				case 0u:
					num = ((int)num2 * -786786074) ^ 0x51CC7DAF;
					continue;
				case 3u:
					break;
				case 2u:
					UpdateStaff_Admin.smethod_74("No Data To Delete");
					return;
				default:
				{
					OleDbCommand val = UpdateStaff_Admin.smethod_113(string_, myconnection);
					try
					{
						while (true)
						{
							int num3 = -912501497;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x86A5D9D3u) % 9u)
								{
								case 8u:
									UpdateStaff_Admin.smethod_114(val);
									num3 = (int)(num2 * 749125294) ^ -1072777344;
									continue;
								case 7u:
									UpdateStaff_Admin.smethod_115((Component)(object)val);
									num3 = ((int)num2 * -1821488740) ^ -1457573675;
									continue;
								case 6u:
									num3 = ((int)num2 * -1939364271) ^ -1761270371;
									continue;
								case 5u:
									ClearDetailsBox();
									num3 = (int)((num2 * 137029633) ^ 0x7FD09C7E);
									continue;
								case 4u:
									UpdateTable();
									num3 = (int)(num2 * 2128350287) ^ -523866588;
									continue;
								case 3u:
									UpdateStaff_Admin.smethod_86(myconnection);
									num3 = (int)(num2 * 1000014394) ^ -714608028;
									continue;
								case 0u:
									UpdateStaff_Admin.smethod_74("Deleted  Sucessfully");
									num3 = ((int)num2 * -920599354) ^ 0xC129AE4;
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
					catch (Exception exception_)
					{
						UpdateStaff_Admin.smethod_88(exception_);
						while (true)
						{
							_ = -1951447860;
							while (true)
							{
								_003F val2 = /*Error near IL_0220: Stack underflow*/^ -2035951149;
								num2 = (uint)(int)val2;
								switch (val2 % 4)
								{
								default:
									return;
								case 3:
									UpdateStaff_Admin.smethod_86(myconnection);
									_ = ((int)num2 * -774882178) ^ 0x31FECDA9;
									continue;
								case 0:
									UpdateStaff_Admin.smethod_89();
									_ = ((int)num2 * -1852350620) ^ 0x7F60DD96;
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
				}
				break;
			}
		}
	}

	private bool UpdateTable()
	{
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected I4, but got Unknown
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected I4, but got Unknown
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Incompatible stack heights: 0 vs 1
		//IL_025a: Incompatible stack heights: 0 vs 1
		//IL_027a: Incompatible stack heights: 0 vs 1
		//IL_0281: Incompatible stack heights: 0 vs 1
		string string_ = default(string);
		DataTable dataTable = default(DataTable);
		bool result = default(bool);
		while (true)
		{
			int num = -1605928340;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x885DD8E9u) % 4u)
				{
				case 2u:
					string_ = UpdateStaff_Admin.smethod_79(new string[5]
					{
						"Select * From [Staff] Where [Name] Like '%",
						UpdateStaff_Admin.smethod_73(UpdateStaff_Admin.smethod_72(NameSTxt)),
						"%' And [Designation] Like '%",
						Designation,
						"%';"
					});
					dataTable = UpdateStaff_Admin.smethod_76();
					num = ((int)num2 * -703571434) ^ 0x5EF41F31;
					continue;
				case 1u:
					UpdateStaff_Admin.smethod_118();
					num = ((int)num2 * -1509879898) ^ -1127300763;
					continue;
				case 3u:
					break;
				default:
					UpdateStaff_Admin.smethod_78(myconnection);
					try
					{
						while (true)
						{
							IL_01ea:
							int num3 = -1826743268;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x885DD8E9u) % 12u)
								{
								case 11u:
									num3 = (int)((num2 * 1969200083) ^ 0x49B57AF4);
									continue;
								case 9u:
									UpdateStaff_Admin.smethod_94((Control)(object)SearchResultGrid, bool_0: true);
									num3 = -857484031;
									continue;
								case 8u:
									UpdateStaff_Admin.smethod_86(myconnection);
									num3 = (int)(num2 * 1951790156) ^ -235344763;
									continue;
								case 7u:
									num3 = (int)(num2 * 441361281) ^ -1437554705;
									continue;
								case 5u:
									result = false;
									num3 = ((int)num2 * -419630060) ^ -161585197;
									continue;
								case 3u:
									UpdateStaff_Admin.smethod_83(SearchResultGrid, (object)dataTable);
									num3 = (int)((num2 * 1454310325) ^ 0xCFF145);
									continue;
								case 2u:
									UpdateStaff_Admin.smethod_86(myconnection);
									num3 = (int)(num2 * 693480243) ^ -1755424316;
									continue;
								case 1u:
								{
									OleDbDataAdapter dbDataAdapter_ = UpdateStaff_Admin.smethod_80(string_, myconnection);
									UpdateStaff_Admin.smethod_81((DbDataAdapter)(object)dbDataAdapter_, dataTable);
									num3 = (int)(num2 * 1889858429) ^ -457656385;
									continue;
								}
								case 0u:
								{
									int num4;
									int num5;
									if (UpdateStaff_Admin.smethod_84(SearchResultGrid) == 1)
									{
										num4 = 2001373055;
										num5 = 2001373055;
									}
									else
									{
										num4 = 1376669732;
										num5 = 1376669732;
									}
									num3 = num4 ^ (int)(num2 * 103624072);
									continue;
								}
								case 10u:
									break;
								default:
									HideunusedColumns();
									goto end_IL_01a7;
								case 6u:
									return result;
								}
								goto IL_01ea;
								continue;
								end_IL_01a7:
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
							IL_027c:
							_ = -41679790;
							while (true)
							{
								_003F val = /*Error near IL_0211: Stack underflow*/^ -2007115543;
								num2 = (uint)(int)val;
								switch (val % 5)
								{
								default:
									goto end_IL_020b;
								case 4:
									UpdateStaff_Admin.smethod_74("Error updating table");
									_ = (num2 * 1403961664) ^ 0x873383B8u;
									continue;
								case 1:
									_ = ((int)num2 * -112546029) ^ -1795967839;
									continue;
								case 0:
									UpdateStaff_Admin.smethod_86(myconnection);
									UpdateStaff_Admin.smethod_89();
									_ = ((int)num2 * -1514416685) ^ 0x4401870;
									continue;
								case 3:
									break;
								case 2:
									goto end_IL_020b;
								}
								goto IL_027c;
								continue;
								end_IL_020b:
								break;
							}
							break;
						}
					}
					while (true)
					{
						int num6 = -2084859774;
						while (true)
						{
							switch ((num2 = (uint)num6 ^ 0x885DD8E9u) % 4u)
							{
							case 3u:
								result = true;
								num6 = ((int)num2 * -948946960) ^ -1044351191;
								continue;
							case 0u:
								num6 = (int)(num2 * 1871557077) ^ -897265780;
								continue;
							case 2u:
								break;
							default:
								return result;
							}
							break;
						}
					}
				}
				break;
			}
		}
	}

	private bool ClearDetailsBox()
	{
		bool result = default(bool);
		while (true)
		{
			int num = 469651884;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9F51995u) % 17u)
				{
				case 16u:
					UpdateStaff_Admin.smethod_107((TextBoxBase)(object)EmailTxt);
					num = ((int)num2 * -521958844) ^ 0x1D59040E;
					continue;
				case 15u:
					UpdateStaff_Admin.smethod_107((TextBoxBase)(object)AddressTxt);
					num = ((int)num2 * -1587333202) ^ 0x2B85C373;
					continue;
				case 14u:
					result = true;
					num = (int)((num2 * 755257880) ^ 0x6FCB4C7E);
					continue;
				case 12u:
					UpdateStaff_Admin.smethod_119(GenderTxt, -1);
					num = (int)(num2 * 1852152783) ^ -1542076902;
					continue;
				case 11u:
					UpdateStaff_Admin.smethod_107((TextBoxBase)(object)MobileTxt);
					num = ((int)num2 * -1205173977) ^ 0x54DFFBA;
					continue;
				case 10u:
					num = (int)(num2 * 883566380) ^ -2045178149;
					continue;
				case 9u:
					num = ((int)num2 * -2135776237) ^ 0x5F419232;
					continue;
				case 8u:
					UpdateStaff_Admin.smethod_119(WorkShiftTxt, -1);
					num = ((int)num2 * -1403988935) ^ 0x7748ACF5;
					continue;
				case 7u:
					num = ((int)num2 * -1157669176) ^ -1375440210;
					continue;
				case 6u:
					num = (int)(num2 * 314888097) ^ -1366846422;
					continue;
				case 5u:
					UpdateStaff_Admin.smethod_107((TextBoxBase)(object)SIDTxt);
					num = ((int)num2 * -44266614) ^ 0x2C4529EB;
					continue;
				case 4u:
					UpdateStaff_Admin.smethod_119(DesignationTxt, -1);
					num = ((int)num2 * -1938940249) ^ 0x4288DC80;
					continue;
				case 3u:
					UpdateStaff_Admin.smethod_107((TextBoxBase)(object)NameTxt);
					num = (int)(num2 * 2053716402) ^ -46170865;
					continue;
				case 1u:
					UpdateStaff_Admin.smethod_45(DOBTxt, UpdateStaff_Admin.smethod_71(UpdateStaff_Admin.smethod_70((object)DateTime.Now, "dd-MM-yyyy")));
					num = (int)(num2 * 1088973404) ^ -322673814;
					continue;
				case 0u:
					num = ((int)num2 * -970170495) ^ 0x44AA5307;
					continue;
				case 13u:
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
