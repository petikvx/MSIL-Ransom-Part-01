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
				int num = -875796828;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9D26D21Bu) % 8u)
					{
					case 7u:
						clearBtn = _ClearBtn;
						num = (int)(num2 * 1611100057) ^ -1298212201;
						continue;
					case 6u:
						UpdateStaff_Admin.smethod_62((Control)(object)clearBtn, eventHandler_);
						num = ((int)num2 * -1177476827) ^ 0xB993895;
						continue;
					case 4u:
					{
						int num5;
						int num6;
						if (clearBtn == null)
						{
							num5 = 1327394437;
							num6 = 1327394437;
						}
						else
						{
							num5 = 1581130358;
							num6 = 1581130358;
						}
						num = num5 ^ ((int)num2 * -789719435);
						continue;
					}
					case 3u:
					{
						int num3;
						int num4;
						if (clearBtn != null)
						{
							num3 = 1821275688;
							num4 = 1821275688;
						}
						else
						{
							num3 = 1411290206;
							num4 = 1411290206;
						}
						num = num3 ^ (int)(num2 * 560773775);
						continue;
					}
					case 1u:
						UpdateStaff_Admin.smethod_63((Control)(object)clearBtn, eventHandler_);
						num = (int)((num2 * 1145604046) ^ 0x59727807);
						continue;
					case 0u:
						_ClearBtn = value;
						clearBtn = _ClearBtn;
						num = -2013167417;
						continue;
					default:
						return;
					case 5u:
						break;
					case 2u:
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
			while (true)
			{
				int num = -2139829476;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA97D616Au) % 6u)
					{
					case 5u:
						UpdateStaff_Admin.smethod_65(receptionistbtn, eventHandler_);
						num = ((int)num2 * -223770994) ^ 0x78A72F30;
						continue;
					case 2u:
					{
						int num4;
						int num5;
						if (receptionistbtn == null)
						{
							num4 = -391700218;
							num5 = -391700218;
						}
						else
						{
							num4 = -731392077;
							num5 = -731392077;
						}
						num = num4 ^ ((int)num2 * -1226962164);
						continue;
					}
					case 1u:
						UpdateStaff_Admin.smethod_64(receptionistbtn, eventHandler_);
						num = ((int)num2 * -2130724314) ^ 0x1D297288;
						continue;
					case 0u:
					{
						_Receptionistbtn = value;
						receptionistbtn = _Receptionistbtn;
						int num3;
						if (receptionistbtn != null)
						{
							num = -225444611;
							num3 = -225444611;
						}
						else
						{
							num = -1122476814;
							num3 = -1122476814;
						}
						continue;
					}
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
				int num = 513087232;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3F177019u) % 9u)
					{
					case 8u:
						nurseBtn = _NurseBtn;
						num = ((int)num2 * -2007120764) ^ -1321816037;
						continue;
					case 7u:
					{
						int num5;
						int num6;
						if (nurseBtn == null)
						{
							num5 = -1872061013;
							num6 = -1872061013;
						}
						else
						{
							num5 = -1744283231;
							num6 = -1744283231;
						}
						num = num5 ^ ((int)num2 * -1742003001);
						continue;
					}
					case 4u:
						UpdateStaff_Admin.smethod_64(nurseBtn, eventHandler_);
						num = ((int)num2 * -409924746) ^ 0x5FAE125B;
						continue;
					case 3u:
						nurseBtn = _NurseBtn;
						num = (int)((num2 * 1122382710) ^ 0x3BEACB92);
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (nurseBtn != null)
						{
							num3 = 1380919643;
							num4 = 1380919643;
						}
						else
						{
							num3 = 998701536;
							num4 = 998701536;
						}
						num = num3 ^ (int)(num2 * 631415501);
						continue;
					}
					case 1u:
						_NurseBtn = value;
						num = 1385790399;
						continue;
					case 0u:
						UpdateStaff_Admin.smethod_65(nurseBtn, eventHandler_);
						num = (int)(num2 * 394548057) ^ -929132861;
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
				int num = 190223128;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7FE4B996u) % 8u)
					{
					case 7u:
					{
						int num5;
						int num6;
						if (doctorBtn != null)
						{
							num5 = 1849943841;
							num6 = 1849943841;
						}
						else
						{
							num5 = 1780412780;
							num6 = 1780412780;
						}
						num = num5 ^ (int)(num2 * 834825766);
						continue;
					}
					case 6u:
						doctorBtn = _DoctorBtn;
						num = ((int)num2 * -157541977) ^ -1063439125;
						continue;
					case 5u:
						UpdateStaff_Admin.smethod_64(doctorBtn, eventHandler_);
						num = (int)((num2 * 447840282) ^ 0x3CBB27E4);
						continue;
					case 3u:
						UpdateStaff_Admin.smethod_65(doctorBtn, eventHandler_);
						num = ((int)num2 * -1389843098) ^ -2135489107;
						continue;
					case 2u:
					{
						doctorBtn = _DoctorBtn;
						int num3;
						int num4;
						if (doctorBtn != null)
						{
							num3 = -1261999117;
							num4 = -1261999117;
						}
						else
						{
							num3 = -862488159;
							num4 = -862488159;
						}
						num = num3 ^ ((int)num2 * -859079281);
						continue;
					}
					case 0u:
						_DoctorBtn = value;
						num = 1216478500;
						continue;
					default:
						return;
					case 4u:
						break;
					case 1u:
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
			Button searchBtn = default(Button);
			while (true)
			{
				int num = 681186852;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x49AD9B6Fu) % 7u)
					{
					case 6u:
					{
						searchBtn = _SearchBtn;
						int num5;
						int num6;
						if (searchBtn == null)
						{
							num5 = 312377133;
							num6 = 312377133;
						}
						else
						{
							num5 = 1106819194;
							num6 = 1106819194;
						}
						num = num5 ^ (int)(num2 * 605511467);
						continue;
					}
					case 5u:
						UpdateStaff_Admin.smethod_62((Control)(object)searchBtn, eventHandler_);
						num = (int)(num2 * 1565783771) ^ -1113338000;
						continue;
					case 4u:
						UpdateStaff_Admin.smethod_63((Control)(object)searchBtn, eventHandler_);
						num = ((int)num2 * -1707753277) ^ -424753782;
						continue;
					case 2u:
						_SearchBtn = value;
						searchBtn = _SearchBtn;
						num = 1987674874;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (searchBtn != null)
						{
							num3 = 1377749930;
							num4 = 1377749930;
						}
						else
						{
							num3 = 1877969229;
							num4 = 1877969229;
						}
						num = num3 ^ (int)(num2 * 458199764);
						continue;
					}
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
			DataGridView searchResultGrid = _SearchResultGrid;
			while (true)
			{
				int num = 469019834;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5AB8993Eu) % 7u)
					{
					case 6u:
						UpdateStaff_Admin.smethod_66(searchResultGrid, dataGridViewCellMouseEventHandler_);
						num = ((int)num2 * -502143460) ^ 0x17B999B7;
						continue;
					case 5u:
						UpdateStaff_Admin.smethod_67(searchResultGrid, dataGridViewCellMouseEventHandler_);
						num = (int)((num2 * 1949877342) ^ 0x2D944A3F);
						continue;
					case 4u:
						_SearchResultGrid = value;
						searchResultGrid = _SearchResultGrid;
						num = 1672055464;
						continue;
					case 2u:
					{
						int num5;
						int num6;
						if (searchResultGrid == null)
						{
							num5 = 793326359;
							num6 = 793326359;
						}
						else
						{
							num5 = 1176995849;
							num6 = 1176995849;
						}
						num = num5 ^ (int)(num2 * 1958893713);
						continue;
					}
					case 1u:
					{
						int num3;
						int num4;
						if (searchResultGrid == null)
						{
							num3 = 1018378739;
							num4 = 1018378739;
						}
						else
						{
							num3 = 1972031270;
							num4 = 1972031270;
						}
						num = num3 ^ (int)(num2 * 1938919525);
						continue;
					}
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
			Button updateBtn = default(Button);
			while (true)
			{
				int num = -1012005738;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB4BBF609u) % 8u)
					{
					case 7u:
					{
						updateBtn = _UpdateBtn;
						int num5;
						int num6;
						if (updateBtn == null)
						{
							num5 = -1161666889;
							num6 = -1161666889;
						}
						else
						{
							num5 = -1538039588;
							num6 = -1538039588;
						}
						num = num5 ^ ((int)num2 * -668628495);
						continue;
					}
					case 6u:
					{
						int num3;
						int num4;
						if (updateBtn != null)
						{
							num3 = -925934094;
							num4 = -925934094;
						}
						else
						{
							num3 = -1398500252;
							num4 = -1398500252;
						}
						num = num3 ^ ((int)num2 * -1992659148);
						continue;
					}
					case 4u:
						updateBtn = _UpdateBtn;
						num = (int)((num2 * 2098124418) ^ 0x271D7F0F);
						continue;
					case 3u:
						UpdateStaff_Admin.smethod_63((Control)(object)updateBtn, eventHandler_);
						num = ((int)num2 * -1243207343) ^ -1871466065;
						continue;
					case 2u:
						UpdateStaff_Admin.smethod_62((Control)(object)updateBtn, eventHandler_);
						num = (int)((num2 * 1220440651) ^ 0x6DDE4FA6);
						continue;
					case 1u:
						_UpdateBtn = value;
						num = -236334939;
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
				int num = 1295493139;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBBBFB99u) % 8u)
					{
					case 7u:
						_DeleteBtn = value;
						num = 1787883361;
						continue;
					case 5u:
						UpdateStaff_Admin.smethod_63((Control)(object)deleteBtn, eventHandler_);
						num = (int)(num2 * 2084324276) ^ -1580396794;
						continue;
					case 4u:
					{
						int num5;
						int num6;
						if (deleteBtn != null)
						{
							num5 = 565516736;
							num6 = 565516736;
						}
						else
						{
							num5 = 444356790;
							num6 = 444356790;
						}
						num = num5 ^ (int)(num2 * 1783071707);
						continue;
					}
					case 2u:
					{
						deleteBtn = _DeleteBtn;
						int num3;
						int num4;
						if (deleteBtn != null)
						{
							num3 = -1581816626;
							num4 = -1581816626;
						}
						else
						{
							num3 = -1625845296;
							num4 = -1625845296;
						}
						num = num3 ^ (int)(num2 * 1148650587);
						continue;
					}
					case 1u:
						UpdateStaff_Admin.smethod_62((Control)(object)deleteBtn, eventHandler_);
						num = (int)(num2 * 730348750) ^ -216210880;
						continue;
					case 0u:
						deleteBtn = _DeleteBtn;
						num = ((int)num2 * -275354431) ^ 0x5A20729D;
						continue;
					default:
						return;
					case 6u:
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
			int num = 1588202069;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x13DB532u) % 6u)
				{
				case 5u:
					myconnection = UpdateStaff_Admin.smethod_1();
					num = ((int)num2 * -2090530445) ^ 0x4FFDC4D3;
					continue;
				case 3u:
					num = (int)(num2 * 1169280990) ^ -1585980972;
					continue;
				case 2u:
					UpdateStaff_Admin.smethod_0((UserControl)(object)this, (EventHandler)UpdateStaff_Admin_Load);
					num = ((int)num2 * -2070146843) ^ 0x7D2CA1DF;
					continue;
				case 1u:
					num = (int)((num2 * 712898526) ^ 0x5F69A5B3);
					continue;
				case 4u:
					break;
				default:
					day = UpdateStaff_Admin.smethod_2(DateTime.Now.ToString("HH"));
					InitializeComponent();
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
				int num = 338349696;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0xF171E29u) % 8u)
					{
					case 7u:
						UpdateStaff_Admin.smethod_3((IDisposable)components);
						num = (int)(num2 * 823498872) ^ -379388012;
						continue;
					case 6u:
						num = ((int)num2 * -1314507363) ^ 0x55EFC7B3;
						continue;
					case 5u:
						num = ((int)num2 * -1930163594) ^ 0x781C39C1;
						continue;
					case 4u:
						num = 49875978;
						continue;
					case 2u:
						if (components != null)
						{
							num = 26055118;
							num3 = 26055118;
							continue;
						}
						goto IL_0051;
					case 1u:
						if (disposing)
						{
							num = (int)((num2 * 1216670177) ^ 0x46691B4A);
							continue;
						}
						goto IL_0051;
					default:
						return;
					case 0u:
						break;
					case 3u:
						return;
						IL_0051:
						num = 1010748189;
						num3 = 1010748189;
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
			int num = -266223471;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD255212Bu) % 375u)
				{
				case 374u:
					num = ((int)num2 * -167345300) ^ 0x1C8CF3D6;
					continue;
				case 373u:
					num = ((int)num2 * -1631849204) ^ -912674014;
					continue;
				case 372u:
					UpdateStaff_Admin.smethod_26(Label6, "Gender : ");
					num = ((int)num2 * -1972002146) ^ -1195955249;
					continue;
				case 371u:
					num = ((int)num2 * -1822791341) ^ 0x568496D1;
					continue;
				case 370u:
					NurseBtn = UpdateStaff_Admin.smethod_8();
					DoctorBtn = UpdateStaff_Admin.smethod_8();
					num = ((int)num2 * -208219805) ^ -879453643;
					continue;
				case 369u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_55((Control)(object)this), (Control)(object)PictureBox1);
					num = (int)((num2 * 1186341147) ^ 0x6D059A5F);
					continue;
				case 368u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)GenderTxt);
					num = ((int)num2 * -1641872065) ^ 0x6044120C;
					continue;
				case 367u:
					UpdateStaff_Admin.smethod_26(Label8, "Name : ");
					num = ((int)num2 * -1649249226) ^ -1065391108;
					continue;
				case 366u:
					num = ((int)num2 * -2682464) ^ 0x1678EC62;
					continue;
				case 365u:
					UpdateStaff_Admin.smethod_18((Control)(object)Label12, "Label12");
					UpdateStaff_Admin.smethod_19((Control)(object)Label12, new Size(118, 26));
					num = ((int)num2 * -1891833942) ^ -1815063528;
					continue;
				case 364u:
					num = ((int)num2 * -1754342992) ^ -2081735008;
					continue;
				case 363u:
					UpdateStaff_Admin.smethod_15((Control)(object)this);
					num = (int)(num2 * 1940858616) ^ -683652584;
					continue;
				case 362u:
					UpdateStaff_Admin.smethod_26(Label2, "Name : ");
					UpdateStaff_Admin.smethod_27(Label2, (ContentAlignment)32);
					num = ((int)num2 * -1162259301) ^ -795218699;
					continue;
				case 361u:
					UpdateStaff_Admin.smethod_25((Control)(object)Label5, 1);
					num = ((int)num2 * -2053581637) ^ -565448816;
					continue;
				case 360u:
					UpdateStaff_Admin.smethod_25((Control)(object)DOBTxt, 18);
					num = (int)((num2 * 562588782) ^ 0x2B98D0A2);
					continue;
				case 359u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_55((Control)(object)this), (Control)(object)DetailsBox);
					num = ((int)num2 * -824187918) ^ 0x70B058F7;
					continue;
				case 358u:
					UpdateStaff_Admin.smethod_26(Label5, "D.O.B. :");
					num = (int)(num2 * 462501034) ^ -1267497;
					continue;
				case 357u:
					num = ((int)num2 * -744586284) ^ 0x75A49791;
					continue;
				case 356u:
					Label1 = UpdateStaff_Admin.smethod_5();
					num = (int)(num2 * 406340626) ^ -426626880;
					continue;
				case 355u:
					UpdateStaff_Admin.smethod_34((ButtonBase)(object)DeleteBtn, "Delete");
					UpdateStaff_Admin.smethod_35((ButtonBase)(object)DeleteBtn, bool_0: false);
					num = ((int)num2 * -871203915) ^ -788442355;
					continue;
				case 354u:
					num = (int)((num2 * 851695320) ^ 0x67F5B247);
					continue;
				case 353u:
					UpdateStaff_Admin.smethod_30(DetailsBox, bool_0: false);
					num = ((int)num2 * -1126438777) ^ 0x59CFCB1D;
					continue;
				case 352u:
					num = ((int)num2 * -1914173657) ^ 0x24A10227;
					continue;
				case 351u:
					num = (int)((num2 * 1079343764) ^ 0x2133F844);
					continue;
				case 350u:
					UpdateStaff_Admin.smethod_19((Control)(object)Label3, new Size(134, 28));
					num = (int)(num2 * 1828789906) ^ -867249945;
					continue;
				case 349u:
					UpdateStaff_Admin.smethod_19((Control)(object)DesignationTxt, new Size(170, 30));
					num = ((int)num2 * -1736006268) ^ -1806742578;
					continue;
				case 348u:
					UpdateStaff_Admin.smethod_24((Control)(object)Label4, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -468750641) ^ 0x7CF2E845;
					continue;
				case 347u:
					EmailTxt = UpdateStaff_Admin.smethod_9();
					Label8 = UpdateStaff_Admin.smethod_5();
					num = (int)((num2 * 71072502) ^ 0x5007C638);
					continue;
				case 346u:
					UpdateStaff_Admin.smethod_25((Control)(object)DoctorBtn, 5);
					num = ((int)num2 * -1863371933) ^ -1862172161;
					continue;
				case 345u:
					UpdateStaff_Admin.smethod_59((Control)(object)GroupBox1, bool_0: false);
					num = ((int)num2 * -285262674) ^ 0x25901EB6;
					continue;
				case 344u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)GroupBox1), (Control)(object)Label2);
					num = (int)((num2 * 1076669798) ^ 0x533AD4DA);
					continue;
				case 343u:
					UpdateStaff_Admin.smethod_25((Control)(object)AddressTxt, 7);
					num = ((int)num2 * -1160228065) ^ 0x393B142E;
					continue;
				case 342u:
					UpdateStaff_Admin.smethod_18((Control)(object)SearchBtn, "SearchBtn");
					num = ((int)num2 * -1243012029) ^ 0x6370708C;
					continue;
				case 341u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)GroupBox1), (Control)(object)Receptionistbtn);
					num = ((int)num2 * -317625151) ^ 0x1BE4F769;
					continue;
				case 340u:
					num = (int)((num2 * 1797240157) ^ 0x732A2613);
					continue;
				case 339u:
					UpdateStaff_Admin.smethod_19((Control)(object)Label8, new Size(77, 28));
					num = ((int)num2 * -251390101) ^ 0x468A5F16;
					continue;
				case 338u:
					UpdateStaff_Admin.smethod_18((Control)(object)DetailsBox, "DetailsBox");
					num = (int)(num2 * 581059350) ^ -739966742;
					continue;
				case 337u:
					UpdateStaff_Admin.smethod_18((Control)(object)Label3, "Label3");
					num = (int)((num2 * 1259655660) ^ 0x8D7E370);
					continue;
				case 336u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_55((Control)(object)this), (Control)(object)UpdateBtn);
					num = ((int)num2 * -1846217474) ^ -1893854540;
					continue;
				case 335u:
					UpdateStaff_Admin.smethod_24((Control)(object)Label7, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -139607845) ^ 0x2988D181;
					continue;
				case 334u:
					num = ((int)num2 * -185014212) ^ -291123446;
					continue;
				case 333u:
					UpdateStaff_Admin.smethod_18((Control)(object)ClearBtn, "ClearBtn");
					num = (int)((num2 * 828882412) ^ 0x683738B3);
					continue;
				case 332u:
					UpdateStaff_Admin.smethod_25((Control)(object)GenderTxt, 21);
					num = (int)(num2 * 392348236) ^ -807444364;
					continue;
				case 331u:
					UpdateStaff_Admin.smethod_17((Control)(object)DOBTxt, new Point(505, 118));
					num = ((int)num2 * -180821831) ^ 0x73A3B283;
					continue;
				case 330u:
					num = ((int)num2 * -1739797990) ^ -1798587291;
					continue;
				case 329u:
					UpdateStaff_Admin.smethod_17((Control)(object)Label12, new Point(417, 223));
					num = (int)((num2 * 1698727643) ^ 0x295B0793);
					continue;
				case 328u:
					UpdateStaff_Admin.smethod_18((Control)(object)Receptionistbtn, "Receptionistbtn");
					num = ((int)num2 * -1564217422) ^ -1993351121;
					continue;
				case 327u:
					UpdateStaff_Admin.smethod_18((Control)(object)Label8, "Label8");
					num = ((int)num2 * -1661904229) ^ 0x5FA7314;
					continue;
				case 326u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)Label11);
					num = ((int)num2 * -956846288) ^ -1340610881;
					continue;
				case 325u:
					UpdateStaff_Admin.smethod_17((Control)(object)Label5, new Point(417, 123));
					num = (int)((num2 * 133223120) ^ 0x33831B3F);
					continue;
				case 324u:
					num = ((int)num2 * -718463320) ^ 0x1079242D;
					continue;
				case 323u:
					UpdateStaff_Admin.smethod_31(GroupBox1, "Search Staff Member");
					num = ((int)num2 * -2057663835) ^ -2092281491;
					continue;
				case 322u:
					num = (int)(num2 * 1710835922) ^ -2108076850;
					continue;
				case 321u:
					UpdateStaff_Admin.smethod_58((ISupportInitialize)SearchResultGrid);
					UpdateStaff_Admin.smethod_59((Control)(object)DetailsBox, bool_0: false);
					num = (int)(num2 * 930024737) ^ -468643207;
					continue;
				case 320u:
					UpdateStaff_Admin.smethod_25((Control)(object)DesignationTxt, 20);
					num = (int)(num2 * 630881608) ^ -2126101548;
					continue;
				case 319u:
					UpdateStaff_Admin.smethod_18((Control)(object)DOBTxt, "DOBTxt");
					num = (int)(num2 * 2042840941) ^ -1610776479;
					continue;
				case 318u:
					num = ((int)num2 * -1256579952) ^ -565609704;
					continue;
				case 317u:
					num = (int)(num2 * 1014962621) ^ -312932270;
					continue;
				case 316u:
					num = (int)(num2 * 172470791) ^ -861426792;
					continue;
				case 315u:
					UpdateStaff_Admin.smethod_57((Control)(object)this, new Size(977, 804));
					num = ((int)num2 * -939313475) ^ -381644402;
					continue;
				case 314u:
					UpdateStaff_Admin.smethod_46(DesignationTxt, (ComboBoxStyle)2);
					num = ((int)num2 * -1431487568) ^ 0x4773541F;
					continue;
				case 313u:
					UpdateStaff_Admin.smethod_24((Control)(object)Label11, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1089379241) ^ 0x34C8780E;
					continue;
				case 312u:
					UpdateStaff_Admin.smethod_24((Control)(object)Label12, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -2097050019) ^ 0x3E45F76;
					continue;
				case 311u:
					UpdateStaff_Admin.smethod_25((Control)(object)Label3, 13);
					num = (int)((num2 * 195451246) ^ 0x6C8FA2E5);
					continue;
				case 310u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_55((Control)(object)this), (Control)(object)GroupBox1);
					num = ((int)num2 * -672696365) ^ 0x7294B5BE;
					continue;
				case 309u:
					UpdateStaff_Admin.smethod_17((Control)(object)Label7, new Point(16, 217));
					num = ((int)num2 * -1353567665) ^ -1139888882;
					continue;
				case 308u:
					UpdateStaff_Admin.smethod_17((Control)(object)EmailTxt, new Point(124, 123));
					num = ((int)num2 * -891714621) ^ -1155225499;
					continue;
				case 307u:
					UpdateStaff_Admin.smethod_46(GenderTxt, (ComboBoxStyle)2);
					num = (int)((num2 * 2043579892) ^ 0x69C94D3D);
					continue;
				case 306u:
					PictureBox1 = UpdateStaff_Admin.smethod_4();
					num = ((int)num2 * -814592157) ^ -137621187;
					continue;
				case 305u:
					num = ((int)num2 * -151469409) ^ 0x69E42C79;
					continue;
				case 304u:
					num = (int)(num2 * 1274671287) ^ -1703587080;
					continue;
				case 303u:
					UpdateStaff_Admin.smethod_36((ButtonBase)(object)Receptionistbtn, bool_0: true);
					num = ((int)num2 * -470631462) ^ 0x4FE77469;
					continue;
				case 302u:
					num = ((int)num2 * -1557344320) ^ 0x31E7B0E4;
					continue;
				case 301u:
					num = ((int)num2 * -343469923) ^ -1890256510;
					continue;
				case 300u:
					UpdateBtn = UpdateStaff_Admin.smethod_7();
					DeleteBtn = UpdateStaff_Admin.smethod_7();
					num = ((int)num2 * -879699512) ^ 0xB7F1068;
					continue;
				case 299u:
					UpdateStaff_Admin.smethod_42(DOBTxt, (DateTimePickerFormat)2);
					num = ((int)num2 * -1815184036) ^ 0x170C0BAB;
					continue;
				case 298u:
					UpdateStaff_Admin.smethod_18((Control)(object)GenderTxt, "GenderTxt");
					num = ((int)num2 * -656094335) ^ -1921105615;
					continue;
				case 297u:
					num = (int)(num2 * 303821493) ^ -1729228513;
					continue;
				case 296u:
					num = ((int)num2 * -792177373) ^ -2062215865;
					continue;
				case 295u:
					DetailsBox = UpdateStaff_Admin.smethod_6();
					num = (int)((num2 * 713631373) ^ 0x67307D41);
					continue;
				case 294u:
					UpdateStaff_Admin.smethod_37(DoctorBtn, bool_0: true);
					num = (int)(num2 * 404798566) ^ -949331723;
					continue;
				case 293u:
					UpdateStaff_Admin.smethod_32((ButtonBase)(object)ClearBtn, Color.MidnightBlue);
					num = (int)((num2 * 1208426080) ^ 0x74D08D7A);
					continue;
				case 292u:
					num = ((int)num2 * -1946078417) ^ 0x123E7B75;
					continue;
				case 291u:
					Label5 = UpdateStaff_Admin.smethod_5();
					num = (int)(num2 * 484675285) ^ -748267054;
					continue;
				case 290u:
					UpdateStaff_Admin.smethod_17((Control)(object)MobileTxt, new Point(124, 169));
					num = (int)((num2 * 1942626371) ^ 0x315DBE5);
					continue;
				case 289u:
					UpdateStaff_Admin.smethod_24((Control)(object)DetailsBox, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					UpdateStaff_Admin.smethod_17((Control)(object)DetailsBox, new Point(79, 470));
					num = (int)(num2 * 1839405893) ^ -1306331948;
					continue;
				case 288u:
					UpdateStaff_Admin.smethod_24((Control)(object)UpdateBtn, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 2052515419) ^ 0x134F8983);
					continue;
				case 287u:
					num = ((int)num2 * -2043984645) ^ -1045560096;
					continue;
				case 286u:
					num = (int)((num2 * 973534326) ^ 0x4AAC6D9A);
					continue;
				case 285u:
					num = (int)((num2 * 851086509) ^ 0x64A238EE);
					continue;
				case 284u:
					UpdateStaff_Admin.smethod_26(Label11, "SID :");
					num = ((int)num2 * -1439781099) ^ -1093659462;
					continue;
				case 283u:
					DesignationTxt = UpdateStaff_Admin.smethod_12();
					num = ((int)num2 * -1752133898) ^ 0x6C3C86C1;
					continue;
				case 282u:
					num = (int)(num2 * 1047180839) ^ -723187338;
					continue;
				case 281u:
					Label6 = UpdateStaff_Admin.smethod_5();
					num = ((int)num2 * -1505785937) ^ 0x5D4A72DD;
					continue;
				case 280u:
					UpdateStaff_Admin.smethod_61((Control)(object)this, bool_0: false);
					num = (int)((num2 * 698508207) ^ 0x320D6F4F);
					continue;
				case 279u:
					UpdateStaff_Admin.smethod_19((Control)(object)ClearBtn, new Size(133, 37));
					num = ((int)num2 * -971648106) ^ -1773231921;
					continue;
				case 278u:
					UpdateStaff_Admin.smethod_25((Control)(object)DetailsBox, 10);
					num = ((int)num2 * -2022307148) ^ -1739169167;
					continue;
				case 277u:
					UpdateStaff_Admin.smethod_18((Control)(object)DesignationTxt, "DesignationTxt");
					num = ((int)num2 * -303308486) ^ 0x71334B5A;
					continue;
				case 276u:
					num = (int)((num2 * 2081830875) ^ 0x6DB0663B);
					continue;
				case 275u:
					num = ((int)num2 * -897207429) ^ 0x109FB9C8;
					continue;
				case 274u:
					num = (int)(num2 * 1406986809) ^ -1890920687;
					continue;
				case 273u:
					UpdateStaff_Admin.smethod_24((Control)(object)ClearBtn, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1411307824) ^ 0x317CC9E0;
					continue;
				case 272u:
					num = (int)((num2 * 962961390) ^ 0x7AC2D2E7);
					continue;
				case 271u:
					UpdateStaff_Admin.smethod_35((ButtonBase)(object)DoctorBtn, bool_0: true);
					num = (int)((num2 * 1329887444) ^ 0x55EECFCE);
					continue;
				case 270u:
					SearchResultGrid = UpdateStaff_Admin.smethod_10();
					num = ((int)num2 * -1166953264) ^ 0x7629A6B6;
					continue;
				case 269u:
					num = (int)((num2 * 1355639011) ^ 0x5F0179D8);
					continue;
				case 268u:
					UpdateStaff_Admin.smethod_35((ButtonBase)(object)NurseBtn, bool_0: true);
					num = (int)(num2 * 1522078552) ^ -255005772;
					continue;
				case 267u:
					UpdateStaff_Admin.smethod_25((Control)(object)Receptionistbtn, 7);
					num = (int)(num2 * 129637721) ^ -1480691340;
					continue;
				case 266u:
					UpdateStaff_Admin.smethod_19((Control)(object)SearchBtn, new Size(133, 37));
					UpdateStaff_Admin.smethod_25((Control)(object)SearchBtn, 4);
					num = ((int)num2 * -580740902) ^ -996100487;
					continue;
				case 265u:
					num = (int)((num2 * 2011943881) ^ 0x5EFF293E);
					continue;
				case 264u:
					num = ((int)num2 * -385824502) ^ 0x1BF64F46;
					continue;
				case 263u:
					UpdateStaff_Admin.smethod_17((Control)(object)NurseBtn, new Point(174, 84));
					num = ((int)num2 * -1782521968) ^ -1516076024;
					continue;
				case 262u:
					UpdateStaff_Admin.smethod_27(Label9, (ContentAlignment)32);
					num = ((int)num2 * -1196095284) ^ -1410645987;
					continue;
				case 261u:
					num = ((int)num2 * -1156608767) ^ -1353752400;
					continue;
				case 260u:
					UpdateStaff_Admin.smethod_18((Control)(object)Label7, "Label7");
					num = ((int)num2 * -1411896918) ^ 0x37679933;
					continue;
				case 259u:
					UpdateStaff_Admin.smethod_18((Control)(object)PictureBox1, "PictureBox1");
					num = (int)(num2 * 1930444864) ^ -1212166791;
					continue;
				case 258u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)Label8);
					num = (int)(num2 * 2035276866) ^ -300248619;
					continue;
				case 257u:
					UpdateStaff_Admin.smethod_34((ButtonBase)(object)ClearBtn, "Clear");
					num = ((int)num2 * -722217944) ^ 0x2624816;
					continue;
				case 256u:
					num = (int)(num2 * 1932632066) ^ -1324304841;
					continue;
				case 255u:
					UpdateStaff_Admin.smethod_14((Control)(object)GroupBox1);
					num = (int)(num2 * 37450790) ^ -1516762653;
					continue;
				case 254u:
					UpdateStaff_Admin.smethod_17((Control)(object)NameTxt, new Point(124, 77));
					num = ((int)num2 * -76798794) ^ -1192577595;
					continue;
				case 253u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)SIDTxt);
					num = ((int)num2 * -498100163) ^ 0x9AEBAF;
					continue;
				case 252u:
					UpdateStaff_Admin.smethod_33((Control)(object)SearchBtn, Color.White);
					num = ((int)num2 * -51761455) ^ -150520907;
					continue;
				case 251u:
					UpdateStaff_Admin.smethod_25((Control)(object)Label12, 18);
					num = (int)((num2 * 18576923) ^ 0x530689F3);
					continue;
				case 250u:
					UpdateStaff_Admin.smethod_19((Control)(object)NurseBtn, new Size(78, 23));
					num = (int)((num2 * 1252906826) ^ 0x12E97F25);
					continue;
				case 249u:
					num = ((int)num2 * -1703345029) ^ -994594698;
					continue;
				case 248u:
					UpdateStaff_Admin.smethod_19((Control)(object)DOBTxt, new Size(171, 28));
					num = (int)((num2 * 1398062697) ^ 0x713365F7);
					continue;
				case 247u:
					UpdateStaff_Admin.smethod_19((Control)(object)Label7, new Size(98, 26));
					num = ((int)num2 * -468891477) ^ 0x40D48480;
					continue;
				case 246u:
					UpdateStaff_Admin.smethod_34((ButtonBase)(object)UpdateBtn, "Update");
					UpdateStaff_Admin.smethod_35((ButtonBase)(object)UpdateBtn, bool_0: false);
					num = ((int)num2 * -675635190) ^ 0x41030D62;
					continue;
				case 245u:
					UpdateStaff_Admin.smethod_18((Control)(object)Label9, "Label9");
					num = ((int)num2 * -1047075666) ^ -1234370951;
					continue;
				case 244u:
					num = (int)((num2 * 1145463487) ^ 0x27FE893D);
					continue;
				case 243u:
					UpdateStaff_Admin.smethod_19((Control)(object)Label11, new Size(68, 25));
					num = (int)((num2 * 287027921) ^ 0x7662CBCD);
					continue;
				case 242u:
					UpdateStaff_Admin.smethod_24((Control)(object)Label5, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 756807932) ^ -1002635711;
					continue;
				case 241u:
					UpdateStaff_Admin.smethod_17((Control)(object)ClearBtn, new Point(467, 30));
					num = ((int)num2 * -522280219) ^ 0x3C658708;
					continue;
				case 240u:
					UpdateStaff_Admin.smethod_25((Control)(object)Label11, 16);
					num = (int)((num2 * 334746676) ^ 0xECECA2D);
					continue;
				case 239u:
					Label11 = UpdateStaff_Admin.smethod_5();
					ShowAvailability = UpdateStaff_Admin.smethod_5();
					Label3 = UpdateStaff_Admin.smethod_5();
					num = (int)((num2 * 1497704758) ^ 0x5C2F9ACC);
					continue;
				case 238u:
					num = ((int)num2 * -1083036461) ^ -1029551611;
					continue;
				case 237u:
					AddressTxt = UpdateStaff_Admin.smethod_9();
					num = (int)((num2 * 1736534977) ^ 0x77D4372E);
					continue;
				case 236u:
					UpdateStaff_Admin.smethod_22(PictureBox1, bool_0: false);
					num = (int)((num2 * 424698275) ^ 0x74027F1D);
					continue;
				case 235u:
					NameTxt = UpdateStaff_Admin.smethod_9();
					num = ((int)num2 * -2070473229) ^ -548264099;
					continue;
				case 234u:
					UpdateStaff_Admin.smethod_34((ButtonBase)(object)SearchBtn, "Search");
					UpdateStaff_Admin.smethod_35((ButtonBase)(object)SearchBtn, bool_0: false);
					num = ((int)num2 * -191786433) ^ 0x59E4D39E;
					continue;
				case 233u:
					num = ((int)num2 * -771788599) ^ 0x2F431DA1;
					continue;
				case 232u:
					UpdateStaff_Admin.smethod_17((Control)(object)AddressTxt, new Point(124, 217));
					num = ((int)num2 * -1089363529) ^ 0x1433BB00;
					continue;
				case 231u:
					num = ((int)num2 * -813099905) ^ 0x6A5D0F8A;
					continue;
				case 230u:
					UpdateStaff_Admin.smethod_17((Control)(object)UpdateBtn, new Point(790, 608));
					num = (int)(num2 * 1590379457) ^ -1926152920;
					continue;
				case 229u:
					UpdateStaff_Admin.smethod_33((Control)(object)DeleteBtn, Color.White);
					UpdateStaff_Admin.smethod_17((Control)(object)DeleteBtn, new Point(790, 680));
					num = (int)((num2 * 2002613804) ^ 0x8A7B6F1);
					continue;
				case 228u:
					MobileTxt = UpdateStaff_Admin.smethod_9();
					num = ((int)num2 * -256555946) ^ -283079927;
					continue;
				case 227u:
					UpdateStaff_Admin.smethod_17((Control)(object)Label4, new Point(16, 126));
					num = ((int)num2 * -531249093) ^ 0x74B13E1D;
					continue;
				case 226u:
					UpdateStaff_Admin.smethod_25((Control)(object)SearchResultGrid, 9);
					num = (int)(num2 * 815496246) ^ -146665;
					continue;
				case 225u:
					num = ((int)num2 * -1589592095) ^ 0x2969724;
					continue;
				case 224u:
					UpdateStaff_Admin.smethod_17((Control)(object)Label3, new Point(367, 72));
					num = ((int)num2 * -404272948) ^ 0x67E9DF;
					continue;
				case 223u:
					UpdateStaff_Admin.smethod_18((Control)(object)Label4, "Label4");
					num = ((int)num2 * -1849390272) ^ 0x7BF13842;
					continue;
				case 222u:
					num = (int)(num2 * 1221274086) ^ -1671817912;
					continue;
				case 221u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)MobileTxt);
					num = ((int)num2 * -449844838) ^ -671421591;
					continue;
				case 220u:
					UpdateStaff_Admin.smethod_17((Control)(object)NameSTxt, new Point(120, 44));
					num = ((int)num2 * -1615510729) ^ 0x68F0B46E;
					continue;
				case 219u:
					UpdateStaff_Admin.smethod_37(NurseBtn, bool_0: true);
					num = (int)(num2 * 1773204068) ^ -1586447359;
					continue;
				case 218u:
					UpdateStaff_Admin.smethod_52(AddressTxt, bool_0: true);
					num = ((int)num2 * -811189210) ^ 0x7A8FEB97;
					continue;
				case 217u:
					UpdateStaff_Admin.smethod_24((Control)(object)Label3, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1257949667) ^ -66832886;
					continue;
				case 216u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)GroupBox1), (Control)(object)NurseBtn);
					num = ((int)num2 * -773467845) ^ -1159238023;
					continue;
				case 215u:
					num = (int)((num2 * 682322468) ^ 0x33E2365E);
					continue;
				case 214u:
					UpdateStaff_Admin.smethod_19((Control)(object)AddressTxt, new Size(271, 90));
					num = ((int)num2 * -1671051323) ^ -1115577113;
					continue;
				case 213u:
					UpdateStaff_Admin.smethod_27(Label3, (ContentAlignment)32);
					num = (int)(num2 * 1679173331) ^ -715770045;
					continue;
				case 212u:
					num = ((int)num2 * -1012498177) ^ 0x4357F1FF;
					continue;
				case 211u:
					UpdateStaff_Admin.smethod_25((Control)(object)Label1, 6);
					num = (int)(num2 * 1911258384) ^ -198791124;
					continue;
				case 210u:
					UpdateStaff_Admin.smethod_19((Control)(object)SIDTxt, new Size(204, 28));
					num = (int)(num2 * 77202001) ^ -445089573;
					continue;
				case 209u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)WorkShiftTxt);
					num = (int)((num2 * 1126920617) ^ 0x899B40E);
					continue;
				case 208u:
					UpdateStaff_Admin.smethod_17((Control)(object)DesignationTxt, new Point(505, 72));
					num = (int)(num2 * 1071356773) ^ -2095969020;
					continue;
				case 207u:
					UpdateStaff_Admin.smethod_26(Label1, "Update Staff");
					UpdateStaff_Admin.smethod_27(Label1, (ContentAlignment)32);
					num = ((int)num2 * -805606871) ^ -1353559010;
					continue;
				case 206u:
					num = ((int)num2 * -484327787) ^ 0x36BB07FC;
					continue;
				case 205u:
					UpdateStaff_Admin.smethod_18((Control)(object)SearchResultGrid, "SearchResultGrid");
					num = ((int)num2 * -1635552662) ^ -1637110908;
					continue;
				case 203u:
					UpdateStaff_Admin.smethod_24((Control)(object)Label1, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1059633675) ^ 0x4C99973F;
					continue;
				case 202u:
					num = ((int)num2 * -567850409) ^ 0xEA92321;
					continue;
				case 201u:
					num = ((int)num2 * -1223375813) ^ -1923406732;
					continue;
				case 200u:
					UpdateStaff_Admin.smethod_20(PictureBox1, (PictureBoxSizeMode)1);
					UpdateStaff_Admin.smethod_21(PictureBox1, 5);
					num = ((int)num2 * -910554605) ^ -866345711;
					continue;
				case 199u:
					UpdateStaff_Admin.smethod_19((Control)(object)MobileTxt, new Size(271, 28));
					UpdateStaff_Admin.smethod_25((Control)(object)MobileTxt, 12);
					num = ((int)num2 * -860528176) ^ -428286054;
					continue;
				case 198u:
					UpdateStaff_Admin.smethod_44(DOBTxt, new DateTime(1900, 1, 1, 0, 0, 0, 0));
					num = ((int)num2 * -1552112601) ^ -1540294623;
					continue;
				case 197u:
					UpdateStaff_Admin.smethod_26(Label7, "Address : ");
					num = ((int)num2 * -594951791) ^ 0x97CD65;
					continue;
				case 196u:
					UpdateStaff_Admin.smethod_18((Control)(object)Label5, "Label5");
					num = (int)(num2 * 157781385) ^ -547548946;
					continue;
				case 195u:
					NameSTxt = UpdateStaff_Admin.smethod_9();
					num = (int)(num2 * 1126967490) ^ -155137947;
					continue;
				case 194u:
					num = ((int)num2 * -554919528) ^ -2065273816;
					continue;
				case 193u:
					UpdateStaff_Admin.smethod_18((Control)(object)NurseBtn, "NurseBtn");
					num = (int)((num2 * 1253779199) ^ 0x111CAFBF);
					continue;
				case 192u:
					Label12 = UpdateStaff_Admin.smethod_5();
					num = (int)(num2 * 1521153656) ^ -987311022;
					continue;
				case 191u:
					UpdateStaff_Admin.smethod_36((ButtonBase)(object)NurseBtn, bool_0: true);
					num = ((int)num2 * -931516793) ^ -1159854643;
					continue;
				case 190u:
					UpdateStaff_Admin.smethod_18((Control)(object)DoctorBtn, "DoctorBtn");
					num = ((int)num2 * -1155147357) ^ -1431935985;
					continue;
				case 189u:
					num = ((int)num2 * -483673695) ^ -677603290;
					continue;
				case 188u:
					num = ((int)num2 * -357157161) ^ 0x7B11E6A4;
					continue;
				case 187u:
					UpdateStaff_Admin.smethod_45(DOBTxt, new DateTime(2019, 2, 12, 0, 0, 0, 0));
					UpdateStaff_Admin.smethod_46(WorkShiftTxt, (ComboBoxStyle)2);
					UpdateStaff_Admin.smethod_47((ListControl)(object)WorkShiftTxt, bool_0: true);
					num = ((int)num2 * -352226514) ^ 0x721EA26A;
					continue;
				case 186u:
					GenderTxt = UpdateStaff_Admin.smethod_12();
					num = ((int)num2 * -920468577) ^ -551930240;
					continue;
				case 185u:
					UpdateStaff_Admin.smethod_18((Control)(object)NameTxt, "NameTxt");
					num = (int)(num2 * 581270036) ^ -819990975;
					continue;
				case 184u:
					UpdateStaff_Admin.smethod_19((Control)(object)Label2, new Size(77, 28));
					num = (int)(num2 * 1056701948) ^ -1606844182;
					continue;
				case 183u:
					UpdateStaff_Admin.smethod_13((ISupportInitialize)SearchResultGrid);
					num = (int)((num2 * 1977123445) ^ 0x2AE83A51);
					continue;
				case 182u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)GroupBox1), (Control)(object)SearchBtn);
					num = (int)(num2 * 270525317) ^ -850978699;
					continue;
				case 181u:
					UpdateStaff_Admin.smethod_37(Receptionistbtn, bool_0: true);
					num = (int)(num2 * 1447642043) ^ -282755038;
					continue;
				case 180u:
					num = ((int)num2 * -1441370687) ^ -1771881729;
					continue;
				case 179u:
					Label4 = UpdateStaff_Admin.smethod_5();
					num = ((int)num2 * -2081848295) ^ 0x58315F0D;
					continue;
				case 178u:
					UpdateStaff_Admin.smethod_18((Control)(object)AddressTxt, "AddressTxt");
					num = ((int)num2 * -104938971) ^ 0x73B7627B;
					continue;
				case 177u:
					num = ((int)num2 * -1875742252) ^ -541907942;
					continue;
				case 176u:
					UpdateStaff_Admin.smethod_25((Control)(object)UpdateBtn, 16);
					num = ((int)num2 * -608063) ^ -308087594;
					continue;
				case 175u:
					num = ((int)num2 * -1883621826) ^ -1905682139;
					continue;
				case 174u:
					UpdateStaff_Admin.smethod_33((Control)(object)ClearBtn, Color.White);
					num = (int)(num2 * 1066333805) ^ -1923928552;
					continue;
				case 173u:
					UpdateStaff_Admin.smethod_25((Control)(object)Label9, 11);
					UpdateStaff_Admin.smethod_26(Label9, "Phone : ");
					num = ((int)num2 * -138288594) ^ -2050624112;
					continue;
				case 172u:
					UpdateStaff_Admin.smethod_18((Control)(object)Label11, "Label11");
					num = ((int)num2 * -434461943) ^ 0x5633FB7C;
					continue;
				case 171u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)Label12);
					num = ((int)num2 * -227521281) ^ -217416493;
					continue;
				case 170u:
					UpdateStaff_Admin.smethod_17((Control)(object)PictureBox1, new Point(242, 3));
					num = ((int)num2 * -1739825966) ^ 0x45AE3C09;
					continue;
				case 169u:
					UpdateStaff_Admin.smethod_60((Control)(object)GroupBox1);
					num = ((int)num2 * -605292680) ^ 0xF62D77F;
					continue;
				case 168u:
					num = (int)(num2 * 384354711) ^ -1882238197;
					continue;
				case 167u:
					num = (int)((num2 * 1602987120) ^ 0x606F89C5);
					continue;
				case 166u:
					num = (int)((num2 * 1536531611) ^ 0x4DC9E73);
					continue;
				case 165u:
					num = ((int)num2 * -1967135136) ^ 0x46D5952;
					continue;
				case 164u:
					UpdateStaff_Admin.smethod_18((Control)(object)MobileTxt, "MobileTxt");
					num = ((int)num2 * -43082390) ^ -1899739008;
					continue;
				case 163u:
					num = ((int)num2 * -1540464603) ^ 0xFC795A3;
					continue;
				case 162u:
					UpdateStaff_Admin.smethod_16(PictureBox1, (Image)(object)Resources.doc_Pic);
					num = (int)((num2 * 1922963779) ^ 0x1F2ED750);
					continue;
				case 161u:
					num = ((int)num2 * -624835451) ^ 0x77D3C568;
					continue;
				case 160u:
					num = (int)(num2 * 345224058) ^ -1441556175;
					continue;
				case 159u:
					UpdateStaff_Admin.smethod_24((Control)(object)Label6, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					UpdateStaff_Admin.smethod_17((Control)(object)Label6, new Point(417, 169));
					num = (int)(num2 * 1455977255) ^ -1500934835;
					continue;
				case 158u:
					UpdateStaff_Admin.smethod_25((Control)(object)SIDTxt, 17);
					num = (int)(num2 * 1000206443) ^ -1123293385;
					continue;
				case 157u:
					WorkShiftTxt = UpdateStaff_Admin.smethod_12();
					num = ((int)num2 * -284209932) ^ -845720629;
					continue;
				case 156u:
					num = (int)((num2 * 2036096618) ^ 0x5F7084B0);
					continue;
				case 155u:
					UpdateStaff_Admin.smethod_34((ButtonBase)(object)DoctorBtn, "Doctor");
					num = (int)((num2 * 1587136920) ^ 0x520F9993);
					continue;
				case 154u:
					UpdateStaff_Admin.smethod_32((ButtonBase)(object)DeleteBtn, Color.MidnightBlue);
					num = ((int)num2 * -531001160) ^ 0x1ED23CC2;
					continue;
				case 153u:
					UpdateStaff_Admin.smethod_25((Control)(object)NurseBtn, 6);
					num = (int)((num2 * 1240060704) ^ 0x459C76A7);
					continue;
				case 152u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_55((Control)(object)this), (Control)(object)SearchResultGrid);
					num = ((int)num2 * -1241935937) ^ 0xA5E494F;
					continue;
				case 151u:
					num = ((int)num2 * -1356777673) ^ 0x6CC02FC8;
					continue;
				case 150u:
					UpdateStaff_Admin.smethod_17((Control)(object)ShowAvailability, new Point(450, 24));
					num = ((int)num2 * -1173222386) ^ 0x786E251C;
					continue;
				case 149u:
					num = (int)((num2 * 1815908841) ^ 0x31F99CC1);
					continue;
				case 148u:
					UpdateStaff_Admin.smethod_36((ButtonBase)(object)DoctorBtn, bool_0: true);
					num = (int)((num2 * 1375706615) ^ 0x4175169A);
					continue;
				case 147u:
					UpdateStaff_Admin.smethod_24((Control)(object)GroupBox1, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					UpdateStaff_Admin.smethod_17((Control)(object)GroupBox1, new Point(155, 150));
					num = (int)((num2 * 2127532052) ^ 0x52316CE0);
					continue;
				case 146u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_55((Control)(object)this), (Control)(object)Label1);
					num = ((int)num2 * -1409930697) ^ 0x30E75A15;
					continue;
				case 145u:
					num = ((int)num2 * -1569546119) ^ -536565153;
					continue;
				case 144u:
					UpdateStaff_Admin.smethod_19((Control)(object)PictureBox1, new Size(144, 141));
					num = ((int)num2 * -716648828) ^ -371724154;
					continue;
				case 143u:
					UpdateStaff_Admin.smethod_18((Control)(object)NameSTxt, "NameSTxt");
					UpdateStaff_Admin.smethod_19((Control)(object)NameSTxt, new Size(292, 28));
					num = (int)(num2 * 1845931784) ^ -1966443309;
					continue;
				case 142u:
					UpdateStaff_Admin.smethod_19((Control)(object)Receptionistbtn, new Size(132, 23));
					num = ((int)num2 * -1773415352) ^ -1653567556;
					continue;
				case 141u:
					num = (int)(num2 * 284774368) ^ -679620953;
					continue;
				case 140u:
					UpdateStaff_Admin.smethod_34((ButtonBase)(object)NurseBtn, "Nurse");
					num = ((int)num2 * -176735035) ^ -300867549;
					continue;
				case 139u:
					UpdateStaff_Admin.smethod_25((Control)(object)DeleteBtn, 17);
					num = ((int)num2 * -1524721557) ^ -1285163459;
					continue;
				case 138u:
					UpdateStaff_Admin.smethod_19((Control)(object)Label5, new Size(84, 26));
					num = (int)(num2 * 865696001) ^ -1954365084;
					continue;
				case 137u:
					UpdateStaff_Admin.smethod_25((Control)(object)EmailTxt, 10);
					UpdateStaff_Admin.smethod_24((Control)(object)Label8, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1231527941) ^ -1333756986;
					continue;
				case 136u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)Label9);
					num = ((int)num2 * -655732032) ^ -1663069482;
					continue;
				case 135u:
					UpdateStaff_Admin.smethod_25((Control)(object)Label7, 3);
					num = (int)(num2 * 509774824) ^ -429695383;
					continue;
				case 134u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)Label4);
					num = (int)((num2 * 779507185) ^ 0x603AEEF9);
					continue;
				case 133u:
					SIDTxt = UpdateStaff_Admin.smethod_9();
					num = (int)((num2 * 708650672) ^ 0xB357D88);
					continue;
				case 132u:
					UpdateStaff_Admin.smethod_25((Control)(object)ShowAvailability, 15);
					num = ((int)num2 * -283882539) ^ 0x5685F476;
					continue;
				case 131u:
					UpdateStaff_Admin.smethod_17((Control)(object)SearchResultGrid, new Point(59, 295));
					num = (int)((num2 * 1025643163) ^ 0x260597F7);
					continue;
				case 130u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)Label6);
					num = (int)(num2 * 1700558351) ^ -401827870;
					continue;
				case 129u:
					Label2 = UpdateStaff_Admin.smethod_5();
					num = ((int)num2 * -536671117) ^ -64534714;
					continue;
				case 128u:
					num = (int)((num2 * 2089655857) ^ 0x2CDA856E);
					continue;
				case 127u:
					UpdateStaff_Admin.smethod_19((Control)(object)NameTxt, new Size(237, 28));
					UpdateStaff_Admin.smethod_25((Control)(object)NameTxt, 4);
					num = ((int)num2 * -1606744879) ^ -2143361379;
					continue;
				case 126u:
					UpdateStaff_Admin.smethod_19((Control)(object)Label9, new Size(77, 28));
					num = (int)((num2 * 515020679) ^ 0xBEC62EC);
					continue;
				case 125u:
					UpdateStaff_Admin.smethod_24((Control)(object)Label9, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					UpdateStaff_Admin.smethod_17((Control)(object)Label9, new Point(16, 169));
					num = ((int)num2 * -531271467) ^ 0x33ED570C;
					continue;
				case 124u:
					num = ((int)num2 * -1245096836) ^ -1778005004;
					continue;
				case 123u:
					UpdateStaff_Admin.smethod_26(Label12, "Work Shift : ");
					num = ((int)num2 * -1342098720) ^ -1551818000;
					continue;
				case 122u:
					UpdateStaff_Admin.smethod_34((ButtonBase)(object)Receptionistbtn, "Receptionist");
					num = ((int)num2 * -1374366515) ^ 0x6DA49F8D;
					continue;
				case 121u:
					num = ((int)num2 * -259668202) ^ -328035260;
					continue;
				case 120u:
					UpdateStaff_Admin.smethod_47((ListControl)(object)DesignationTxt, bool_0: true);
					num = (int)((num2 * 1848133176) ^ 0xA20B131);
					continue;
				case 119u:
					SearchBtn = UpdateStaff_Admin.smethod_7();
					num = ((int)num2 * -169867418) ^ 0x30C2DA01;
					continue;
				case 118u:
					UpdateStaff_Admin.smethod_25((Control)(object)Label6, 2);
					num = (int)((num2 * 524131808) ^ 0x3C60E75D);
					continue;
				case 117u:
					UpdateStaff_Admin.smethod_17((Control)(object)Label8, new Point(16, 78));
					num = (int)((num2 * 1505029553) ^ 0x1CE8FDD7);
					continue;
				case 116u:
					UpdateStaff_Admin.smethod_18((Control)(object)Label1, "Label1");
					UpdateStaff_Admin.smethod_19((Control)(object)Label1, new Size(330, 47));
					num = (int)(num2 * 13118052) ^ -971985297;
					continue;
				case 115u:
					UpdateStaff_Admin.smethod_32((ButtonBase)(object)UpdateBtn, Color.MidnightBlue);
					num = ((int)num2 * -2045143965) ^ -2143559495;
					continue;
				case 114u:
					UpdateStaff_Admin.smethod_17((Control)(object)DoctorBtn, new Point(65, 84));
					num = (int)((num2 * 345490493) ^ 0x2557BC19);
					continue;
				case 113u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)GroupBox1), (Control)(object)ClearBtn);
					num = (int)(num2 * 489559263) ^ -1700360058;
					continue;
				case 112u:
					num = ((int)num2 * -1332875269) ^ 0x2E10F470;
					continue;
				case 111u:
					UpdateStaff_Admin.smethod_25((Control)(object)Label4, 0);
					num = (int)((num2 * 1037051903) ^ 0x51D09275);
					continue;
				case 110u:
					UpdateStaff_Admin.smethod_17((Control)(object)SIDTxt, new Point(124, 36));
					num = (int)(num2 * 1823936625) ^ -2056517954;
					continue;
				case 109u:
					num = ((int)num2 * -441547671) ^ -1375698187;
					continue;
				case 108u:
					UpdateStaff_Admin.smethod_14((Control)(object)DetailsBox);
					num = ((int)num2 * -462013724) ^ -712319360;
					continue;
				case 107u:
					num = ((int)num2 * -898183048) ^ -167813746;
					continue;
				case 106u:
					num = ((int)num2 * -1648300593) ^ 0x156C323C;
					continue;
				case 105u:
					num = (int)((num2 * 853852989) ^ 0x75A6917E);
					continue;
				case 104u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)GroupBox1), (Control)(object)NameSTxt);
					num = ((int)num2 * -74038496) ^ -2096237418;
					continue;
				case 103u:
					num = (int)((num2 * 937855933) ^ 0x22F61ABB);
					continue;
				case 102u:
					UpdateStaff_Admin.smethod_17((Control)(object)Receptionistbtn, new Point(280, 84));
					num = ((int)num2 * -1014974092) ^ 0x3CBADAD4;
					continue;
				case 101u:
					UpdateStaff_Admin.smethod_18((Control)(object)DeleteBtn, "DeleteBtn");
					UpdateStaff_Admin.smethod_19((Control)(object)DeleteBtn, new Size(122, 33));
					num = (int)(num2 * 1124388226) ^ -1814499928;
					continue;
				case 100u:
					num = (int)((num2 * 1982574992) ^ 0x4757478C);
					continue;
				case 99u:
					UpdateStaff_Admin.smethod_18((Control)(object)UpdateBtn, "UpdateBtn");
					UpdateStaff_Admin.smethod_19((Control)(object)UpdateBtn, new Size(122, 33));
					num = (int)((num2 * 1287164273) ^ 0x4E0F9B50);
					continue;
				case 98u:
					num = (int)((num2 * 1281444156) ^ 0x67E6C923);
					continue;
				case 97u:
					UpdateStaff_Admin.smethod_19((Control)(object)DetailsBox, new Size(699, 313));
					num = ((int)num2 * -1420876153) ^ 0x2C2A50B3;
					continue;
				case 96u:
					num = (int)(num2 * 45353927) ^ -1103868902;
					continue;
				case 95u:
					ClearBtn = UpdateStaff_Admin.smethod_7();
					Receptionistbtn = UpdateStaff_Admin.smethod_8();
					num = (int)((num2 * 1479485013) ^ 0x7BBF2E03);
					continue;
				case 94u:
					num = (int)(num2 * 12859461) ^ -1241792297;
					continue;
				case 93u:
					num = (int)((num2 * 202168195) ^ 0x373EC943);
					continue;
				case 92u:
					UpdateStaff_Admin.smethod_24((Control)(object)DoctorBtn, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 295772437) ^ -850092452;
					continue;
				case 91u:
					GroupBox1 = UpdateStaff_Admin.smethod_6();
					num = ((int)num2 * -274940811) ^ -177054676;
					continue;
				case 90u:
					UpdateStaff_Admin.smethod_49(UpdateStaff_Admin.smethod_48(WorkShiftTxt), new object[2] { "Day", "Night" });
					num = ((int)num2 * -1670890509) ^ 0x5EC9A4FB;
					continue;
				case 89u:
					num = (int)(num2 * 1589495064) ^ -397008706;
					continue;
				case 88u:
					UpdateStaff_Admin.smethod_18((Control)(object)EmailTxt, "EmailTxt");
					UpdateStaff_Admin.smethod_19((Control)(object)EmailTxt, new Size(271, 28));
					num = ((int)num2 * -321753664) ^ -77790713;
					continue;
				case 87u:
					num = ((int)num2 * -1526935505) ^ 0x3076BE23;
					continue;
				case 86u:
					UpdateStaff_Admin.smethod_43(DOBTxt, new DateTime(2019, 2, 12, 0, 0, 0, 0));
					num = (int)(num2 * 164856932) ^ -839832257;
					continue;
				case 85u:
					UpdateStaff_Admin.smethod_19((Control)(object)Label4, new Size(68, 25));
					num = (int)((num2 * 2140780196) ^ 0x40F12855);
					continue;
				case 84u:
					num = (int)((num2 * 1069591765) ^ 0x68EDE323);
					continue;
				case 83u:
					num = (int)((num2 * 2142203471) ^ 0x46E1E02E);
					continue;
				case 82u:
					UpdateStaff_Admin.smethod_35((ButtonBase)(object)Receptionistbtn, bool_0: true);
					num = ((int)num2 * -834104992) ^ -1509721238;
					continue;
				case 81u:
					UpdateStaff_Admin.smethod_25((Control)(object)Label8, 9);
					num = ((int)num2 * -474998484) ^ 0x4FD34283;
					continue;
				case 80u:
					num = (int)(num2 * 1152744132) ^ -2051730500;
					continue;
				case 79u:
					UpdateStaff_Admin.smethod_49(UpdateStaff_Admin.smethod_48(DesignationTxt), new object[4] { "Doctor", "Nurse", "Receptionist", "Admin" });
					num = (int)((num2 * 1580064783) ^ 0x30A18765);
					continue;
				case 78u:
					UpdateStaff_Admin.smethod_49(UpdateStaff_Admin.smethod_48(GenderTxt), new object[3] { "Male", "Female", "Others" });
					UpdateStaff_Admin.smethod_17((Control)(object)GenderTxt, new Point(521, 163));
					num = (int)((num2 * 1079086895) ^ 0x17B1AD4D);
					continue;
				case 77u:
					UpdateStaff_Admin.smethod_24((Control)(object)NurseBtn, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1153946478) ^ -663296970;
					continue;
				case 76u:
					UpdateStaff_Admin.smethod_17((Control)(object)Label1, new Point(392, 63));
					num = (int)(num2 * 125936082) ^ -568366630;
					continue;
				case 75u:
					UpdateStaff_Admin.smethod_53((ContainerControl)(object)this, new SizeF(8f, 16f));
					num = ((int)num2 * -329632861) ^ 0x67DD84F8;
					continue;
				case 74u:
					num = (int)((num2 * 1930465108) ^ 0x244A8834);
					continue;
				case 73u:
					UpdateStaff_Admin.smethod_58((ISupportInitialize)PictureBox1);
					num = (int)((num2 * 1698680882) ^ 0x3CBF2EE4);
					continue;
				case 72u:
					UpdateStaff_Admin.smethod_18((Control)(object)GroupBox1, "GroupBox1");
					num = ((int)num2 * -710313489) ^ 0x4A646B;
					continue;
				case 71u:
					num = ((int)num2 * -1060277399) ^ 0x24143072;
					continue;
				case 70u:
					UpdateStaff_Admin.smethod_24((Control)(object)Receptionistbtn, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 857788893) ^ -1980714982;
					continue;
				case 69u:
					UpdateStaff_Admin.smethod_27(ShowAvailability, (ContentAlignment)32);
					num = (int)((num2 * 905868393) ^ 0x60A54C9A);
					continue;
				case 68u:
					num = (int)(num2 * 2043854449) ^ -1964576868;
					continue;
				case 67u:
					UpdateStaff_Admin.smethod_17((Control)(object)WorkShiftTxt, new Point(542, 217));
					UpdateStaff_Admin.smethod_18((Control)(object)WorkShiftTxt, "WorkShiftTxt");
					UpdateStaff_Admin.smethod_19((Control)(object)WorkShiftTxt, new Size(134, 30));
					UpdateStaff_Admin.smethod_25((Control)(object)WorkShiftTxt, 19);
					num = (int)(num2 * 1701835381) ^ -359069729;
					continue;
				case 66u:
					num = (int)(num2 * 723183136) ^ -2114411909;
					continue;
				case 65u:
					UpdateStaff_Admin.smethod_19((Control)(object)GroupBox1, new Size(623, 127));
					num = (int)((num2 * 954242505) ^ 0x5747814B);
					continue;
				case 64u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)Label5);
					num = (int)((num2 * 926803948) ^ 0x7C00503F);
					continue;
				case 63u:
					UpdateStaff_Admin.smethod_32((ButtonBase)(object)SearchBtn, Color.MidnightBlue);
					UpdateStaff_Admin.smethod_24((Control)(object)SearchBtn, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -681303908) ^ -618537750;
					continue;
				case 62u:
					num = (int)(num2 * 1327660388) ^ -139863984;
					continue;
				case 61u:
					num = ((int)num2 * -756924919) ^ -1314404095;
					continue;
				case 60u:
					UpdateStaff_Admin.smethod_31(DetailsBox, "Staff Member Detail");
					num = (int)(num2 * 1774554212) ^ -844723928;
					continue;
				case 59u:
					UpdateStaff_Admin.smethod_39(SearchResultGrid, (DataGridViewColumnHeadersHeightSizeMode)2);
					num = ((int)num2 * -244072534) ^ -1617882061;
					continue;
				case 58u:
					num = ((int)num2 * -1539100034) ^ -1517109862;
					continue;
				case 57u:
					num = (int)((num2 * 472451247) ^ 0x4F94AFF5);
					continue;
				case 56u:
					UpdateStaff_Admin.smethod_26(ShowAvailability, "UnAvailable");
					num = (int)((num2 * 1336378644) ^ 0x3FD88F88);
					continue;
				case 55u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)ShowAvailability);
					num = (int)((num2 * 256275143) ^ 0x615D5863);
					continue;
				case 54u:
					UpdateStaff_Admin.smethod_51((Control)(object)ShowAvailability, Color.Red);
					num = (int)(num2 * 1078596001) ^ -1444374512;
					continue;
				case 53u:
					num = ((int)num2 * -291871591) ^ 0x6F03F52E;
					continue;
				case 52u:
					UpdateStaff_Admin.smethod_24((Control)(object)Label2, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					UpdateStaff_Admin.smethod_17((Control)(object)Label2, new Point(37, 44));
					num = ((int)num2 * -1252836240) ^ -1206734164;
					continue;
				case 51u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)AddressTxt);
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)NameTxt);
					num = (int)((num2 * 678958659) ^ 0x3BCD4D7A);
					continue;
				case 50u:
					UpdateStaff_Admin.smethod_17((Control)(object)Label11, new Point(16, 36));
					num = (int)(num2 * 1609155278) ^ -284176368;
					continue;
				case 49u:
					UpdateStaff_Admin.smethod_35((ButtonBase)(object)ClearBtn, bool_0: false);
					num = (int)((num2 * 1810863518) ^ 0x393D7BB0);
					continue;
				case 48u:
					DOBTxt = UpdateStaff_Admin.smethod_11();
					num = (int)((num2 * 443363959) ^ 0x3E6570AE);
					continue;
				case 47u:
					UpdateStaff_Admin.smethod_24((Control)(object)DeleteBtn, UpdateStaff_Admin.smethod_23("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 766008183) ^ 0x16CEA173);
					continue;
				case 46u:
					UpdateStaff_Admin.smethod_13((ISupportInitialize)PictureBox1);
					num = (int)(num2 * 2082350414) ^ -1075353914;
					continue;
				case 45u:
					num = (int)(num2 * 395738772) ^ -2141286713;
					continue;
				case 44u:
					UpdateStaff_Admin.smethod_25((Control)(object)Label2, 0);
					num = ((int)num2 * -539266070) ^ -1051069437;
					continue;
				case 43u:
					UpdateStaff_Admin.smethod_18((Control)(object)Label6, "Label6");
					num = ((int)num2 * -1468106961) ^ 0x401FD000;
					continue;
				case 42u:
					num = ((int)num2 * -78492045) ^ 0x692B03A6;
					continue;
				case 41u:
					num = ((int)num2 * -1683462064) ^ -1287202837;
					continue;
				case 40u:
					UpdateStaff_Admin.smethod_56((Control)(object)this, "UpdateStaff_Admin");
					num = ((int)num2 * -731541266) ^ -758860781;
					continue;
				case 39u:
					num = (int)(num2 * 1231648412) ^ -1335578043;
					continue;
				case 38u:
					UpdateStaff_Admin.smethod_60((Control)(object)DetailsBox);
					num = (int)((num2 * 1752952482) ^ 0x5C084554);
					continue;
				case 37u:
					num = (int)((num2 * 1829903989) ^ 0x22EFC452);
					continue;
				case 36u:
					UpdateStaff_Admin.smethod_30(GroupBox1, bool_0: false);
					num = ((int)num2 * -519695915) ^ -745803765;
					continue;
				case 35u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)GroupBox1), (Control)(object)DoctorBtn);
					num = ((int)num2 * -1563794589) ^ -1400784792;
					continue;
				case 34u:
					num = ((int)num2 * -281724189) ^ 0x2F538B8E;
					continue;
				case 33u:
					UpdateStaff_Admin.smethod_26(Label4, "Email :");
					num = ((int)num2 * -291324846) ^ 0x4A05F95B;
					continue;
				case 32u:
					Label7 = UpdateStaff_Admin.smethod_5();
					num = (int)((num2 * 829487798) ^ 0x2AC85B71);
					continue;
				case 31u:
					num = (int)(num2 * 1155388691) ^ -1163803305;
					continue;
				case 30u:
					UpdateStaff_Admin.smethod_38(SearchResultGrid, Color.White);
					num = ((int)num2 * -364461415) ^ 0x33777609;
					continue;
				case 29u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)DesignationTxt);
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)DOBTxt);
					num = (int)((num2 * 949545034) ^ 0x428E7ECF);
					continue;
				case 28u:
					UpdateStaff_Admin.smethod_18((Control)(object)Label2, "Label2");
					num = ((int)num2 * -915128341) ^ -177421445;
					continue;
				case 27u:
					UpdateStaff_Admin.smethod_26(Label3, "Designation : ");
					num = ((int)num2 * -424548988) ^ 0x4601C9E0;
					continue;
				case 26u:
					num = (int)(num2 * 1762968315) ^ -44309514;
					continue;
				case 25u:
					num = ((int)num2 * -2007861048) ^ -583952105;
					continue;
				case 24u:
					UpdateStaff_Admin.smethod_19((Control)(object)DoctorBtn, new Size(87, 23));
					num = (int)(num2 * 1287125216) ^ -719476592;
					continue;
				case 23u:
					num = (int)(num2 * 1323200553) ^ -1742044616;
					continue;
				case 22u:
					UpdateStaff_Admin.smethod_47((ListControl)(object)GenderTxt, bool_0: true);
					num = ((int)num2 * -1295201359) ^ 0x44157958;
					continue;
				case 21u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)Label3);
					num = (int)((num2 * 1159918419) ^ 0x2BAB7380);
					continue;
				case 20u:
					UpdateStaff_Admin.smethod_18((Control)(object)SIDTxt, "SIDTxt");
					UpdateStaff_Admin.smethod_50((TextBoxBase)(object)SIDTxt, bool_0: true);
					num = (int)((num2 * 2059591709) ^ 0x3340704C);
					continue;
				case 19u:
					num = ((int)num2 * -772398794) ^ -1849102326;
					continue;
				case 18u:
					num = ((int)num2 * -76964604) ^ -396859704;
					continue;
				case 17u:
					UpdateStaff_Admin.smethod_19((Control)(object)GenderTxt, new Size(156, 30));
					num = ((int)num2 * -942592391) ^ 0x295D8D49;
					continue;
				case 16u:
					UpdateStaff_Admin.smethod_54((ContainerControl)(object)this, (AutoScaleMode)1);
					UpdateStaff_Admin.smethod_51((Control)(object)this, Color.White);
					num = ((int)num2 * -733678058) ^ -174512852;
					continue;
				case 15u:
					Label9 = UpdateStaff_Admin.smethod_5();
					num = ((int)num2 * -1071316014) ^ 0x43E0DB2A;
					continue;
				case 13u:
					UpdateStaff_Admin.smethod_25((Control)(object)NameSTxt, 1);
					num = ((int)num2 * -582175795) ^ -1074320205;
					continue;
				case 12u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_55((Control)(object)this), (Control)(object)DeleteBtn);
					num = ((int)num2 * -1264892815) ^ 0x4A517D0B;
					continue;
				case 11u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)EmailTxt);
					num = ((int)num2 * -1695392303) ^ -917851949;
					continue;
				case 10u:
					num = ((int)num2 * -1928494699) ^ -1740895353;
					continue;
				case 9u:
					UpdateStaff_Admin.smethod_27(Label8, (ContentAlignment)32);
					num = (int)((num2 * 962752287) ^ 0x4201DBD1);
					continue;
				case 8u:
					UpdateStaff_Admin.smethod_18((Control)(object)ShowAvailability, "ShowAvailability");
					UpdateStaff_Admin.smethod_19((Control)(object)ShowAvailability, new Size(204, 23));
					num = (int)(num2 * 1956579550) ^ -70707058;
					continue;
				case 7u:
					UpdateStaff_Admin.smethod_41(UpdateStaff_Admin.smethod_40(SearchResultGrid), 24);
					UpdateStaff_Admin.smethod_19((Control)(object)SearchResultGrid, new Size(853, 169));
					num = (int)((num2 * 1505636993) ^ 0x6C5FF1F5);
					continue;
				case 6u:
					UpdateStaff_Admin.smethod_25((Control)(object)GroupBox1, 8);
					num = ((int)num2 * -754177194) ^ -559525453;
					continue;
				case 5u:
					UpdateStaff_Admin.smethod_25((Control)(object)ClearBtn, 8);
					num = (int)((num2 * 385696832) ^ 0x3BD1432);
					continue;
				case 4u:
					UpdateStaff_Admin.smethod_19((Control)(object)Label6, new Size(84, 26));
					num = (int)((num2 * 145588579) ^ 0x354E229D);
					continue;
				case 3u:
					UpdateStaff_Admin.smethod_29(UpdateStaff_Admin.smethod_28((Control)(object)DetailsBox), (Control)(object)Label7);
					num = (int)((num2 * 1666952904) ^ 0x5FEC1B27);
					continue;
				case 2u:
					num = (int)(num2 * 984683852) ^ -300927789;
					continue;
				case 1u:
					UpdateStaff_Admin.smethod_33((Control)(object)UpdateBtn, Color.White);
					num = ((int)num2 * -704786725) ^ -729482324;
					continue;
				case 0u:
					UpdateStaff_Admin.smethod_17((Control)(object)SearchBtn, new Point(467, 73));
					num = (int)((num2 * 32889611) ^ 0x76335B9F);
					continue;
				default:
					return;
				case 204u:
					break;
				case 14u:
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
			int num = -1279639826;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFE259BD8u) % 4u)
				{
				case 2u:
					Designation = "";
					UpdateStaff_Admin.smethod_43(DOBTxt, UpdateStaff_Admin.smethod_71(UpdateStaff_Admin.smethod_70((object)DateTime.Now, "dd-MM-yyyy")));
					num = ((int)num2 * -573866071) ^ -426450829;
					continue;
				case 1u:
					Hidedata();
					num = ((int)num2 * -1157372080) ^ 0x48EA63FF;
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

	private void SearchBtn_Click(object sender, EventArgs e)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected I4, but got Unknown
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Expected I4, but got Unknown
		//IL_0334: Incompatible stack heights: 0 vs 1
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Incompatible stack heights: 0 vs 1
		//IL_0356: Incompatible stack heights: 0 vs 1
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		DataTable dataTable_ = default(DataTable);
		bool flag = default(bool);
		while (true)
		{
			int num = -1817747690;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8A07EF36u) % 10u)
				{
				case 9u:
				{
					int num8;
					int num9;
					if (flag3)
					{
						num8 = 638668439;
						num9 = 638668439;
					}
					else
					{
						num8 = 415265111;
						num9 = 415265111;
					}
					num = num8 ^ (int)(num2 * 1033559878);
					continue;
				}
				case 8u:
					Hidedata();
					num = ((int)num2 * -1366099021) ^ 0x63484231;
					continue;
				case 5u:
					flag2 = UpdateStaff_Admin.smethod_75(Designation, "", bool_0: false) == 0;
					num = -1578015214;
					continue;
				case 4u:
					UpdateStaff_Admin.smethod_74("click designation");
					num = (int)(num2 * 960942076) ^ -1141029007;
					continue;
				case 3u:
					flag3 = !MyProject.Forms.Form1.Name_Validation(UpdateStaff_Admin.smethod_73(UpdateStaff_Admin.smethod_72(NameSTxt)));
					num = (int)((num2 * 1427107253) ^ 0x335DC4DA);
					continue;
				case 2u:
				{
					int num6;
					int num7;
					if (!flag2)
					{
						num6 = -1589949848;
						num7 = -1589949848;
					}
					else
					{
						num6 = -566275284;
						num7 = -566275284;
					}
					num = num6 ^ ((int)num2 * -1891589069);
					continue;
				}
				case 6u:
					break;
				default:
					try
					{
						while (true)
						{
							int num3 = -757287092;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x8A07EF36u) % 13u)
								{
								case 12u:
									UpdateStaff_Admin.smethod_83(SearchResultGrid, (object)UpdateStaff_Admin.smethod_82(dataTable_));
									num3 = ((int)num2 * -1797151979) ^ -390324511;
									continue;
								case 11u:
								{
									int num4;
									int num5;
									if (!flag)
									{
										num4 = -977756625;
										num5 = -977756625;
									}
									else
									{
										num4 = -180978220;
										num5 = -180978220;
									}
									num3 = num4 ^ ((int)num2 * -1520130906);
									continue;
								}
								case 10u:
									UpdateStaff_Admin.smethod_87((Control)(object)SearchResultGrid);
									num3 = -449421608;
									continue;
								case 8u:
								{
									dataTable_ = UpdateStaff_Admin.smethod_76();
									OleDbDataAdapter dbDataAdapter_ = UpdateStaff_Admin.smethod_77();
									num3 = ((int)num2 * -1678668715) ^ 0x5227011B;
									continue;
								}
								case 6u:
									UpdateStaff_Admin.smethod_78(myconnection);
									num3 = ((int)num2 * -272937389) ^ 0x5E56FD4E;
									continue;
								case 5u:
									UpdateStaff_Admin.smethod_86(myconnection);
									num3 = (int)(num2 * 765365345) ^ -645193616;
									continue;
								case 4u:
									num3 = ((int)num2 * -841203632) ^ 0x52703E84;
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
									num3 = (int)(num2 * 165319138) ^ -877858438;
									continue;
								}
								case 2u:
									flag = UpdateStaff_Admin.smethod_84(SearchResultGrid) == 1;
									num3 = ((int)num2 * -246700455) ^ -1012952942;
									continue;
								case 1u:
									UpdateStaff_Admin.smethod_85("Not Found.", "Result");
									num3 = (int)(num2 * 1217068261) ^ -765235221;
									continue;
								case 0u:
									break;
								case 7u:
									return;
								default:
									UpdateStaff_Admin.smethod_86(myconnection);
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
						UpdateStaff_Admin.smethod_86(myconnection);
						while (true)
						{
							_ = -1937028559;
							while (true)
							{
								_003F val = /*Error near IL_030a: Stack underflow*/^ -1979191498;
								num2 = (uint)(int)val;
								switch (val % 4)
								{
								case 3:
									_ = ((int)num2 * -2112852335) ^ -839936493;
									continue;
								case 2:
									UpdateStaff_Admin.smethod_74("Incorrect Credentials");
									_ = ((int)num2 * -824819748) ^ 0x58CF10BF;
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
				case 1u:
					UpdateStaff_Admin.smethod_74("Enter Valid Name");
					return;
				case 7u:
					return;
				}
				break;
			}
		}
	}

	private bool HideunusedColumns()
	{
		UpdateStaff_Admin.smethod_92(UpdateStaff_Admin.smethod_91(UpdateStaff_Admin.smethod_90(SearchResultGrid), 7), bool_0: false);
		bool result = default(bool);
		while (true)
		{
			int num = -1569168378;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD4DC890Bu) % 3u)
				{
				case 1u:
					goto IL_0019;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0019:
				UpdateStaff_Admin.smethod_92(UpdateStaff_Admin.smethod_91(UpdateStaff_Admin.smethod_90(SearchResultGrid), 9), bool_0: false);
				result = false;
				num = ((int)num2 * -1792744439) ^ 0x130D2B1F;
			}
		}
	}

	private void RadioButton1_CheckedChanged(object sender, EventArgs e)
	{
		Designation = "Doctor";
	}

	private void RadioButton2_CheckedChanged(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 1203615709;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1E20EFD2u) % 3u)
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
				Designation = "Nurse";
				num = ((int)num2 * -1449277697) ^ -1253018146;
			}
		}
	}

	private void RadioButton3_CheckedChanged(object sender, EventArgs e)
	{
		Designation = "Receptionist";
	}

	private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = 1701098648;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3289B9C1u) % 8u)
				{
				case 6u:
					UpdateStaff_Admin.smethod_87((Control)(object)UpdateBtn);
					num = (int)((num2 * 1156398869) ^ 0x7B94A20B);
					continue;
				case 3u:
					num = 998443299;
					continue;
				case 2u:
					selectrow = UpdateStaff_Admin.smethod_93(e);
					UpdateStaff_Admin.smethod_94((Control)(object)DetailsBox, bool_0: true);
					num = ((int)num2 * -574258570) ^ -1442866285;
					continue;
				case 1u:
					flag = (checked(UpdateStaff_Admin.smethod_93(e) + 1) == UpdateStaff_Admin.smethod_84(SearchResultGrid)) | (UpdateStaff_Admin.smethod_93(e) == -1);
					num = (int)((num2 * 1465080868) ^ 0x1EBAC9A5);
					continue;
				case 0u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1609025988;
						num5 = -1609025988;
					}
					else
					{
						num4 = -1888314454;
						num5 = -1888314454;
					}
					num = num4 ^ (int)(num2 * 1637962008);
					continue;
				}
				case 7u:
					break;
				default:
					UpdateStaff_Admin.smethod_87((Control)(object)DeleteBtn);
					try
					{
						DataGridViewRow val = UpdateStaff_Admin.smethod_95();
						val = UpdateStaff_Admin.smethod_97(UpdateStaff_Admin.smethod_96(SearchResultGrid), selectrow);
						while (true)
						{
							int num3 = 1674789946;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x3289B9C1u) % 11u)
								{
								case 10u:
									putcolor(UpdateStaff_Admin.smethod_104(UpdateStaff_Admin.smethod_100(UpdateStaff_Admin.smethod_99(UpdateStaff_Admin.smethod_98(val), 8))));
									num3 = ((int)num2 * -1005712696) ^ -1973752628;
									continue;
								case 8u:
									UpdateStaff_Admin.smethod_105(DOBTxt, UpdateStaff_Admin.smethod_104(UpdateStaff_Admin.smethod_100(UpdateStaff_Admin.smethod_99(UpdateStaff_Admin.smethod_98(val), 3))));
									UpdateStaff_Admin.smethod_103(GenderTxt, UpdateStaff_Admin.smethod_101(UpdateStaff_Admin.smethod_100(UpdateStaff_Admin.smethod_99(UpdateStaff_Admin.smethod_98(val), 4))));
									num3 = (int)((num2 * 1778731465) ^ 0x2A133671);
									continue;
								case 7u:
									UpdateStaff_Admin.smethod_102(MobileTxt, UpdateStaff_Admin.smethod_101(UpdateStaff_Admin.smethod_100(UpdateStaff_Admin.smethod_99(UpdateStaff_Admin.smethod_98(val), 5))));
									num3 = (int)(num2 * 1305250362) ^ -78514448;
									continue;
								case 6u:
									num3 = ((int)num2 * -83182195) ^ -322098574;
									continue;
								case 5u:
									UpdateStaff_Admin.smethod_103(WorkShiftTxt, UpdateStaff_Admin.smethod_101(UpdateStaff_Admin.smethod_100(UpdateStaff_Admin.smethod_99(UpdateStaff_Admin.smethod_98(val), 8))));
									num3 = (int)(num2 * 877131967) ^ -2013080633;
									continue;
								case 4u:
									UpdateStaff_Admin.smethod_102(NameTxt, UpdateStaff_Admin.smethod_101(UpdateStaff_Admin.smethod_100(UpdateStaff_Admin.smethod_99(UpdateStaff_Admin.smethod_98(val), 1))));
									UpdateStaff_Admin.smethod_103(DesignationTxt, UpdateStaff_Admin.smethod_101(UpdateStaff_Admin.smethod_100(UpdateStaff_Admin.smethod_99(UpdateStaff_Admin.smethod_98(val), 2))));
									num3 = (int)((num2 * 1711910069) ^ 0x7205EA4D);
									continue;
								case 3u:
									UpdateStaff_Admin.smethod_102(SIDTxt, UpdateStaff_Admin.smethod_101(UpdateStaff_Admin.smethod_100(UpdateStaff_Admin.smethod_99(UpdateStaff_Admin.smethod_98(val), 0))));
									num3 = ((int)num2 * -1264880805) ^ 0x11A4F8DE;
									continue;
								case 2u:
									num3 = (int)((num2 * 176953779) ^ 0x58D3A31F);
									continue;
								case 1u:
									UpdateStaff_Admin.smethod_102(AddressTxt, UpdateStaff_Admin.smethod_101(UpdateStaff_Admin.smethod_100(UpdateStaff_Admin.smethod_99(UpdateStaff_Admin.smethod_98(val), 6))));
									num3 = (int)((num2 * 2072747651) ^ 0x2EE3AA00);
									continue;
								default:
									return;
								case 0u:
									break;
								case 9u:
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
		}
	}

	private void Hidedata()
	{
		while (true)
		{
			int num = -1366176279;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8D9529D8u) % 6u)
				{
				case 5u:
					UpdateStaff_Admin.smethod_106((Control)(object)UpdateBtn);
					num = ((int)num2 * -1890780659) ^ 0x724AAC4E;
					continue;
				case 3u:
					num = (int)(num2 * 1424999096) ^ -2032079524;
					continue;
				case 2u:
					UpdateStaff_Admin.smethod_106((Control)(object)SearchResultGrid);
					num = (int)((num2 * 1551228568) ^ 0x3C8E2B39);
					continue;
				case 1u:
					UpdateStaff_Admin.smethod_94((Control)(object)DetailsBox, bool_0: false);
					num = ((int)num2 * -321876293) ^ 0x11EDD10F;
					continue;
				case 4u:
					break;
				default:
					UpdateStaff_Admin.smethod_106((Control)(object)DeleteBtn);
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
			int num = -113381498;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF94DFFA1u) % 15u)
				{
				case 12u:
					num = ((int)num2 * -1655391104) ^ -1235923043;
					continue;
				case 11u:
					UpdateStaff_Admin.smethod_106((Control)(object)UpdateBtn);
					num = ((int)num2 * -626821513) ^ -1393633457;
					continue;
				case 10u:
					Designation = "";
					num = (int)((num2 * 1763608668) ^ 0x577E6EC5);
					continue;
				case 9u:
					UpdateStaff_Admin.smethod_106((Control)(object)DeleteBtn);
					num = ((int)num2 * -1949599251) ^ -1703752885;
					continue;
				case 8u:
					UpdateStaff_Admin.smethod_94((Control)(object)DetailsBox, bool_0: false);
					num = ((int)num2 * -804081907) ^ 0x625D63C;
					continue;
				case 7u:
					UpdateStaff_Admin.smethod_108(NurseBtn, bool_0: false);
					num = (int)(num2 * 1466075948) ^ -1454265529;
					continue;
				case 6u:
					UpdateStaff_Admin.smethod_108(Receptionistbtn, bool_0: false);
					num = (int)((num2 * 484979670) ^ 0x71F9D4D0);
					continue;
				case 5u:
					num = ((int)num2 * -1668662359) ^ -815658391;
					continue;
				case 4u:
					num = ((int)num2 * -1251712347) ^ 0x2B104C43;
					continue;
				case 3u:
					num = ((int)num2 * -1604270969) ^ -303887457;
					continue;
				case 2u:
					UpdateStaff_Admin.smethod_106((Control)(object)SearchResultGrid);
					num = ((int)num2 * -1828637172) ^ -644055587;
					continue;
				case 1u:
					UpdateStaff_Admin.smethod_108(DoctorBtn, bool_0: false);
					num = (int)((num2 * 194819143) ^ 0x471FAE2C);
					continue;
				case 0u:
					num = ((int)num2 * -401427524) ^ -1307105939;
					continue;
				default:
					return;
				case 14u:
					break;
				case 13u:
					return;
				}
				break;
			}
		}
	}

	private void putcolor(string WorkShift)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = 290220728;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x363DBCDAu) % 10u)
				{
				case 9u:
					num = ((int)num2 * -579957479) ^ -2051305875;
					continue;
				case 6u:
					num = (int)((num2 * 591073383) ^ 0x29514D43);
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 413884258;
						num4 = 413884258;
					}
					else
					{
						num3 = 1604871930;
						num4 = 1604871930;
					}
					num = num3 ^ ((int)num2 * -1562955601);
					continue;
				}
				case 4u:
					flag = UpdateStaff_Admin.smethod_75(Shift(), WorkShift, bool_0: false) == 0;
					num = (int)(num2 * 1944992888) ^ -636039251;
					continue;
				case 3u:
					num = 1422313974;
					continue;
				case 2u:
					num = ((int)num2 * -1230847005) ^ 0x70175931;
					continue;
				case 1u:
					colourgreen();
					num = (int)(num2 * 1224187768) ^ -1281584994;
					continue;
				case 0u:
					colourred();
					num = ((int)num2 * -649445831) ^ 0x1647B07B;
					continue;
				default:
					return;
				case 8u:
					break;
				case 7u:
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
			goto IL_001c;
		}
		goto IL_0083;
		IL_0083:
		int num = 709009755;
		goto IL_005a;
		IL_005a:
		string result = default(string);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x57548257u) % 6u)
			{
			case 5u:
				break;
			case 4u:
				num = ((int)num2 * -258678231) ^ -790385555;
				continue;
			case 2u:
				result = "Night";
				num = (int)(num2 * 2018406882) ^ -482747279;
				continue;
			case 1u:
				result = "Day";
				num = ((int)num2 * -67280961) ^ 0x2782E2B2;
				continue;
			case 3u:
				goto IL_0083;
			default:
				return result;
			}
			break;
		}
		goto IL_001c;
		IL_001c:
		num = 666237912;
		goto IL_005a;
	}

	private void colourgreen()
	{
		UpdateStaff_Admin.smethod_51((Control)(object)ShowAvailability, Color.Green);
		UpdateStaff_Admin.smethod_26(ShowAvailability, "Available");
		while (true)
		{
			int num = 2023554900;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1562F895u) % 3u)
				{
				case 2u:
					goto IL_0022;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0022:
				num = (int)((num2 * 1177609618) ^ 0x62ADBBE7);
			}
		}
	}

	private void colourred()
	{
		while (true)
		{
			int num = -794395996;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCA937B9Fu) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 2u:
					break;
				default:
					UpdateStaff_Admin.smethod_26(ShowAvailability, "Unavilable");
					return;
				}
				break;
				IL_0003:
				UpdateStaff_Admin.smethod_51((Control)(object)ShowAvailability, Color.Red);
				num = ((int)num2 * -373467788) ^ -1386124635;
			}
		}
	}

	private void UpadateBtn_Click(object sender, EventArgs e)
	{
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		if ((UpdateStaff_Admin.smethod_75(UpdateStaff_Admin.smethod_72(NameTxt), "", bool_0: false) == 0) | (UpdateStaff_Admin.smethod_75(UpdateStaff_Admin.smethod_72(MobileTxt), "", bool_0: false) == 0) | (UpdateStaff_Admin.smethod_75(UpdateStaff_Admin.smethod_109(GenderTxt), "", bool_0: false) == 0) | (UpdateStaff_Admin.smethod_75(UpdateStaff_Admin.smethod_110(DOBTxt), "", bool_0: false) == 0) | (UpdateStaff_Admin.smethod_75(UpdateStaff_Admin.smethod_109(DesignationTxt), "", bool_0: false) == 0) | (UpdateStaff_Admin.smethod_75(UpdateStaff_Admin.smethod_72(AddressTxt), "", bool_0: false) == 0) | (UpdateStaff_Admin.smethod_75(UpdateStaff_Admin.smethod_109(WorkShiftTxt), "", bool_0: false) == 0))
		{
			goto IL_0252;
		}
		goto IL_0296;
		IL_0296:
		int num = 2118639839;
		goto IL_0257;
		IL_0257:
		bool flag = default(bool);
		string string_ = default(string);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x5A837A73u) % 11u)
			{
			case 10u:
				UpdateStaff_Admin.smethod_74("Fields Cannot be empty");
				num = (int)(num2 * 368978341) ^ -1788415320;
				continue;
			case 9u:
				flag = !(MyProject.Forms.Form1.Mobile_Validator(UpdateStaff_Admin.smethod_73(UpdateStaff_Admin.smethod_72(MobileTxt))) & MyProject.Forms.Form1.Name_Validation(UpdateStaff_Admin.smethod_73(UpdateStaff_Admin.smethod_72(NameTxt))) & MyProject.Forms.Form1.Gender_Validator(UpdateStaff_Admin.smethod_73(UpdateStaff_Admin.smethod_109(GenderTxt))));
				num = (int)(num2 * 603706032) ^ -1400706146;
				continue;
			case 8u:
			{
				int num4;
				int num5;
				if (flag)
				{
					num4 = -2071272487;
					num5 = -2071272487;
				}
				else
				{
					num4 = -1428113425;
					num5 = -1428113425;
				}
				num = num4 ^ (int)(num2 * 430419754);
				continue;
			}
			case 5u:
				UpdateStaff_Admin.smethod_78(myconnection);
				num = (int)((num2 * 1762579287) ^ 0x48952E13);
				continue;
			case 4u:
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
				num = ((int)num2 * -1351691040) ^ 0x11E3798D;
				continue;
			}
			case 3u:
				num = 937342770;
				continue;
			case 2u:
				break;
			case 6u:
				goto IL_0296;
			case 0u:
				UpdateStaff_Admin.smethod_74("Invalid Credentials");
				return;
			default:
			{
				OleDbCommand val = UpdateStaff_Admin.smethod_113(string_, myconnection);
				try
				{
					UpdateStaff_Admin.smethod_114(val);
					UpdateStaff_Admin.smethod_115((Component)(object)val);
					while (true)
					{
						int num3 = 1510084311;
						while (true)
						{
							switch ((num2 = (uint)num3 ^ 0x5A837A73u) % 5u)
							{
							case 4u:
								ClearDetailsBox();
								UpdateStaff_Admin.smethod_74("Updated Sucessfully");
								UpdateStaff_Admin.smethod_86(myconnection);
								num3 = ((int)num2 * -1268195794) ^ 0x206AA21A;
								continue;
							case 2u:
								UpdateTable();
								num3 = ((int)num2 * -1908490499) ^ -148917235;
								continue;
							case 0u:
								num3 = (int)(num2 * 181043574) ^ -464409411;
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
				catch (Exception exception_)
				{
					UpdateStaff_Admin.smethod_88(exception_);
					UpdateStaff_Admin.smethod_116((object)"Invalid Credentials", (MsgBoxStyle)0, (object)null);
					UpdateStaff_Admin.smethod_86(myconnection);
					UpdateStaff_Admin.smethod_89();
					return;
				}
			}
			case 7u:
				return;
			}
			break;
		}
		goto IL_0252;
		IL_0252:
		num = 1307456528;
		goto IL_0257;
	}

	private void DeleteBtn_Click(object sender, EventArgs e)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected I4, but got Unknown
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected I4, but got Unknown
		//IL_020f: Incompatible stack heights: 0 vs 1
		//IL_0216: Incompatible stack heights: 0 vs 1
		UpdateStaff_Admin.smethod_95();
		string string_ = default(string);
		while (true)
		{
			int num = 1022580098;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x18BF1C64u) % 9u)
				{
				case 5u:
					UpdateStaff_Admin.smethod_74("No Data To Delete");
					num = ((int)num2 * -555722053) ^ 0x50771BC8;
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (UpdateStaff_Admin.smethod_75(UpdateStaff_Admin.smethod_72(SIDTxt), "", bool_0: false) == 0)
					{
						num4 = -1912141508;
						num5 = -1912141508;
					}
					else
					{
						num4 = -905275769;
						num5 = -905275769;
					}
					num = num4 ^ ((int)num2 * -1914826918);
					continue;
				}
				case 3u:
					UpdateStaff_Admin.smethod_78(myconnection);
					num = ((int)num2 * -1028615608) ^ -1903886822;
					continue;
				case 2u:
					string_ = UpdateStaff_Admin.smethod_117("Delete from [Staff] where [SID] = ", UpdateStaff_Admin.smethod_72(SIDTxt), " ");
					num = 65401276;
					continue;
				case 1u:
					UpdateStaff_Admin.smethod_97(UpdateStaff_Admin.smethod_96(SearchResultGrid), selectrow);
					num = (int)(num2 * 223978578) ^ -87861724;
					continue;
				case 0u:
					num = ((int)num2 * -112305812) ^ -510244646;
					continue;
				case 8u:
					break;
				default:
				{
					OleDbCommand val = UpdateStaff_Admin.smethod_113(string_, myconnection);
					try
					{
						UpdateStaff_Admin.smethod_114(val);
						while (true)
						{
							int num3 = 806891236;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x18BF1C64u) % 6u)
								{
								case 5u:
									num3 = (int)((num2 * 299018227) ^ 0x47889C9A);
									continue;
								case 4u:
									UpdateStaff_Admin.smethod_115((Component)(object)val);
									num3 = (int)(num2 * 672248655) ^ -552730272;
									continue;
								case 1u:
									UpdateStaff_Admin.smethod_74("Deleted  Sucessfully");
									UpdateTable();
									ClearDetailsBox();
									num3 = (int)(num2 * 939769622) ^ -1484321474;
									continue;
								case 0u:
									UpdateStaff_Admin.smethod_86(myconnection);
									num3 = (int)(num2 * 861990956) ^ -1012081363;
									continue;
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
					catch (Exception exception_)
					{
						UpdateStaff_Admin.smethod_88(exception_);
						while (true)
						{
							_ = 156944600;
							while (true)
							{
								_003F val2 = /*Error near IL_01d9: Stack underflow*/^ 0x18BF1C64;
								num2 = (uint)(int)val2;
								switch (val2 % 3)
								{
								default:
									return;
								case 1:
									UpdateStaff_Admin.smethod_86(myconnection);
									UpdateStaff_Admin.smethod_89();
									_ = (num2 * 355638218) ^ 0x3CA8AD94;
									continue;
								case 2:
									break;
								case 0:
									return;
								}
								break;
							}
						}
					}
				}
				case 7u:
					return;
				}
				break;
			}
		}
	}

	private bool UpdateTable()
	{
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected I4, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected I4, but got Unknown
		//IL_0287: Incompatible stack heights: 0 vs 1
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Incompatible stack heights: 0 vs 1
		//IL_02bd: Incompatible stack heights: 0 vs 1
		//IL_02c4: Incompatible stack heights: 0 vs 1
		UpdateStaff_Admin.smethod_118();
		string string_ = default(string);
		DataTable dataTable = default(DataTable);
		bool flag = default(bool);
		OleDbDataAdapter dbDataAdapter_ = default(OleDbDataAdapter);
		bool result = default(bool);
		while (true)
		{
			int num = 127432620;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x235D49EDu) % 4u)
				{
				case 1u:
					string_ = UpdateStaff_Admin.smethod_79(new string[5]
					{
						"Select * From [Staff] Where [Name] Like '%",
						UpdateStaff_Admin.smethod_73(UpdateStaff_Admin.smethod_72(NameSTxt)),
						"%' And [Designation] Like '%",
						Designation,
						"%';"
					});
					dataTable = UpdateStaff_Admin.smethod_76();
					num = ((int)num2 * -1290193460) ^ -167323391;
					continue;
				case 0u:
					UpdateStaff_Admin.smethod_78(myconnection);
					num = (int)(num2 * 1446324071) ^ -1923648526;
					continue;
				case 2u:
					break;
				default:
					try
					{
						while (true)
						{
							IL_0234:
							int num3 = 744529672;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x235D49EDu) % 15u)
								{
								case 14u:
									UpdateStaff_Admin.smethod_86(myconnection);
									HideunusedColumns();
									num3 = (int)((num2 * 1279142002) ^ 0x50DE3EE6);
									continue;
								case 13u:
								{
									int num4;
									int num5;
									if (flag)
									{
										num4 = -162743715;
										num5 = -162743715;
									}
									else
									{
										num4 = -1286906203;
										num5 = -1286906203;
									}
									num3 = num4 ^ ((int)num2 * -1198603832);
									continue;
								}
								case 11u:
									UpdateStaff_Admin.smethod_81((DbDataAdapter)(object)dbDataAdapter_, dataTable);
									num3 = (int)((num2 * 1017238356) ^ 0x57830ADF);
									continue;
								case 10u:
									UpdateStaff_Admin.smethod_94((Control)(object)SearchResultGrid, bool_0: true);
									num3 = 977783049;
									continue;
								case 9u:
									dbDataAdapter_ = UpdateStaff_Admin.smethod_80(string_, myconnection);
									num3 = ((int)num2 * -1635593499) ^ -319501648;
									continue;
								case 8u:
									num3 = (int)((num2 * 845961636) ^ 0x67272D22);
									continue;
								case 6u:
									UpdateStaff_Admin.smethod_83(SearchResultGrid, (object)dataTable);
									num3 = (int)(num2 * 1943995842) ^ -257283044;
									continue;
								case 4u:
									num3 = ((int)num2 * -611539540) ^ 0x18FEAA76;
									continue;
								case 3u:
									flag = UpdateStaff_Admin.smethod_84(SearchResultGrid) == 1;
									num3 = ((int)num2 * -145638187) ^ 0x6080CB9B;
									continue;
								case 2u:
									num3 = ((int)num2 * -1373712979) ^ 0x1CEBA49D;
									continue;
								case 1u:
									result = false;
									num3 = ((int)num2 * -1758237887) ^ -138191178;
									continue;
								case 0u:
									UpdateStaff_Admin.smethod_86(myconnection);
									num3 = (int)((num2 * 1155577931) ^ 0x43218C95);
									continue;
								default:
									goto end_IL_01e5;
								case 7u:
									break;
								case 5u:
									goto end_IL_01e5;
								case 12u:
									return result;
								}
								goto IL_0234;
								continue;
								end_IL_01e5:
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
							IL_02bf:
							_ = 102528050;
							while (true)
							{
								_003F val = /*Error near IL_0254: Stack underflow*/^ 0x235D49ED;
								num2 = (uint)(int)val;
								switch (val % 5)
								{
								default:
									goto end_IL_024e;
								case 4:
									UpdateStaff_Admin.smethod_89();
									_ = ((int)num2 * -1182720345) ^ 0x278E1662;
									continue;
								case 3:
									UpdateStaff_Admin.smethod_74("Error updating table");
									UpdateStaff_Admin.smethod_86(myconnection);
									_ = (num2 * 219930171) ^ 0x15797D6E;
									continue;
								case 1:
									_ = ((int)num2 * -1924244951) ^ -1652604773;
									continue;
								case 2:
									break;
								case 0:
									goto end_IL_024e;
								}
								goto IL_02bf;
								continue;
								end_IL_024e:
								break;
							}
							break;
						}
					}
					while (true)
					{
						int num6 = 701329160;
						while (true)
						{
							switch ((num2 = (uint)num6 ^ 0x235D49EDu) % 3u)
							{
							case 1u:
								goto IL_02c8;
							case 0u:
								break;
							default:
								return result;
							}
							break;
							IL_02c8:
							result = true;
							num6 = ((int)num2 * -2032286022) ^ -1866083040;
						}
					}
				}
				break;
			}
		}
	}

	private bool ClearDetailsBox()
	{
		UpdateStaff_Admin.smethod_107((TextBoxBase)(object)SIDTxt);
		bool result = default(bool);
		while (true)
		{
			int num = 292559950;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2849A410u) % 18u)
				{
				case 17u:
					UpdateStaff_Admin.smethod_45(DOBTxt, UpdateStaff_Admin.smethod_71(UpdateStaff_Admin.smethod_70((object)DateTime.Now, "dd-MM-yyyy")));
					num = (int)(num2 * 524172769) ^ -1900339396;
					continue;
				case 16u:
					num = ((int)num2 * -80171003) ^ -599770747;
					continue;
				case 15u:
					UpdateStaff_Admin.smethod_107((TextBoxBase)(object)EmailTxt);
					num = ((int)num2 * -81110358) ^ 0x5B3C4535;
					continue;
				case 14u:
					num = (int)(num2 * 1848152168) ^ -1937945510;
					continue;
				case 13u:
					num = ((int)num2 * -124264514) ^ -1240742505;
					continue;
				case 12u:
					num = (int)((num2 * 346420905) ^ 0x7E747828);
					continue;
				case 11u:
					UpdateStaff_Admin.smethod_107((TextBoxBase)(object)MobileTxt);
					num = ((int)num2 * -1197546495) ^ -2063872914;
					continue;
				case 10u:
					UpdateStaff_Admin.smethod_119(WorkShiftTxt, -1);
					num = (int)((num2 * 918413287) ^ 0x3FBC8E1C);
					continue;
				case 9u:
					UpdateStaff_Admin.smethod_107((TextBoxBase)(object)AddressTxt);
					num = ((int)num2 * -745750921) ^ 0x3D669ABE;
					continue;
				case 8u:
					num = ((int)num2 * -812391172) ^ -1450209502;
					continue;
				case 5u:
					UpdateStaff_Admin.smethod_119(DesignationTxt, -1);
					num = ((int)num2 * -1936495599) ^ -1809368997;
					continue;
				case 4u:
					num = (int)(num2 * 1700766782) ^ -1462707163;
					continue;
				case 3u:
					UpdateStaff_Admin.smethod_119(GenderTxt, -1);
					num = (int)((num2 * 1463341928) ^ 0x383F04B8);
					continue;
				case 2u:
					result = true;
					num = (int)((num2 * 1427377380) ^ 0x7ECFD2F0);
					continue;
				case 1u:
					num = ((int)num2 * -1023827711) ^ -893036656;
					continue;
				case 0u:
					UpdateStaff_Admin.smethod_107((TextBoxBase)(object)NameTxt);
					num = (int)((num2 * 6285259) ^ 0x305E8368);
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
