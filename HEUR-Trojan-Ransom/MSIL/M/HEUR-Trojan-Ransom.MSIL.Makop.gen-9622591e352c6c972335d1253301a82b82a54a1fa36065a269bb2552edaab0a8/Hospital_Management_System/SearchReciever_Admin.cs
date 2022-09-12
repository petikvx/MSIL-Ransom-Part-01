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
public class SearchReciever_Admin : UserControl
{
	private IContainer components;

	private OleDbConnection myconnection;

	private string name_search;

	private string mobile_search;

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
			Button searchBtn = _SearchBtn;
			if (searchBtn != null)
			{
				goto IL_006c;
			}
			goto IL_009a;
			IL_009a:
			_SearchBtn = value;
			searchBtn = _SearchBtn;
			int num = -715835463;
			goto IL_0071;
			IL_0071:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCD389175u) % 6u)
				{
				case 4u:
					SearchReciever_Admin.smethod_54((Control)(object)searchBtn, eventHandler_);
					num = ((int)num2 * -1165016583) ^ 0x9E43772;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (searchBtn == null)
					{
						num3 = -965158918;
						num4 = -965158918;
					}
					else
					{
						num3 = -2092874716;
						num4 = -2092874716;
					}
					num = num3 ^ ((int)num2 * -734787981);
					continue;
				}
				case 1u:
					SearchReciever_Admin.smethod_55((Control)(object)searchBtn, eventHandler_);
					num = (int)(num2 * 1888570908) ^ -372497774;
					continue;
				case 0u:
					break;
				default:
					return;
				case 5u:
					goto IL_009a;
				case 3u:
					return;
				}
				break;
			}
			goto IL_006c;
			IL_006c:
			num = -888315607;
			goto IL_0071;
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
				int num = -1323009024;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE24A2809u) % 8u)
					{
					case 7u:
						searchResultGrid = _SearchResultGrid;
						num = (int)(num2 * 236669543) ^ -311071780;
						continue;
					case 5u:
						SearchReciever_Admin.smethod_56(searchResultGrid, dataGridViewCellMouseEventHandler_);
						num = (int)(num2 * 841764527) ^ -1283926264;
						continue;
					case 4u:
					{
						int num5;
						int num6;
						if (searchResultGrid != null)
						{
							num5 = 1798579493;
							num6 = 1798579493;
						}
						else
						{
							num5 = 371899726;
							num6 = 371899726;
						}
						num = num5 ^ ((int)num2 * -1754461631);
						continue;
					}
					case 2u:
						_SearchResultGrid = value;
						num = -1425043442;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (searchResultGrid == null)
						{
							num3 = -2005107757;
							num4 = -2005107757;
						}
						else
						{
							num3 = -539461444;
							num4 = -539461444;
						}
						num = num3 ^ (int)(num2 * 540332208);
						continue;
					}
					case 0u:
						SearchReciever_Admin.smethod_57(searchResultGrid, dataGridViewCellMouseEventHandler_);
						num = ((int)num2 * -252871393) ^ 0x243AFA92;
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

	[field: AccessedThroughProperty("RecieverInfoBox")]
	internal virtual GroupBox RecieverInfoBox
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("QuantityTxt")]
	internal virtual TextBox QuantityTxt
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

	[field: AccessedThroughProperty("IDTxt")]
	internal virtual TextBox IDTxt
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

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
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

	[field: AccessedThroughProperty("DateRecievedTxt")]
	internal virtual TextBox DateRecievedTxt
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

	[field: AccessedThroughProperty("DOBTxt")]
	internal virtual TextBox DOBTxt
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

	[field: AccessedThroughProperty("Label10")]
	internal virtual Label Label10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
				goto IL_0082;
			}
			goto IL_00b4;
			IL_00b4:
			_DeleteBtn = value;
			int num = 761898911;
			goto IL_0087;
			IL_0087:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3F0839D8u) % 7u)
				{
				case 5u:
					deleteBtn = _DeleteBtn;
					num = ((int)num2 * -1945616275) ^ 0xF576730;
					continue;
				case 4u:
					SearchReciever_Admin.smethod_55((Control)(object)deleteBtn, eventHandler_);
					num = ((int)num2 * -5839775) ^ -1438460895;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (deleteBtn != null)
					{
						num3 = -564642862;
						num4 = -564642862;
					}
					else
					{
						num3 = -595905909;
						num4 = -595905909;
					}
					num = num3 ^ (int)(num2 * 939221425);
					continue;
				}
				case 1u:
					SearchReciever_Admin.smethod_54((Control)(object)deleteBtn, eventHandler_);
					num = (int)((num2 * 1239493968) ^ 0x2EAFC93B);
					continue;
				case 0u:
					break;
				default:
					return;
				case 3u:
					goto IL_00b4;
				case 6u:
					return;
				}
				break;
			}
			goto IL_0082;
			IL_0082:
			num = 169863556;
			goto IL_0087;
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
			Button clearBtn = default(Button);
			while (true)
			{
				int num = 898979544;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1C852FC7u) % 8u)
					{
					case 7u:
						clearBtn = _ClearBtn;
						num = ((int)num2 * -1067528428) ^ 0x76DB4EB0;
						continue;
					case 6u:
					{
						int num5;
						int num6;
						if (clearBtn != null)
						{
							num5 = 894551388;
							num6 = 894551388;
						}
						else
						{
							num5 = 978182231;
							num6 = 978182231;
						}
						num = num5 ^ ((int)num2 * -964473517);
						continue;
					}
					case 5u:
						SearchReciever_Admin.smethod_54((Control)(object)clearBtn, eventHandler_);
						num = ((int)num2 * -687338096) ^ 0x366C1053;
						continue;
					case 4u:
						_ClearBtn = value;
						clearBtn = _ClearBtn;
						num = 540051025;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (clearBtn != null)
						{
							num3 = 80575859;
							num4 = 80575859;
						}
						else
						{
							num3 = 1984615866;
							num4 = 1984615866;
						}
						num = num3 ^ ((int)num2 * -461049669);
						continue;
					}
					case 1u:
						SearchReciever_Admin.smethod_55((Control)(object)clearBtn, eventHandler_);
						num = ((int)num2 * -799982951) ^ 0x17E4BEE4;
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
			Button updateBtn = _UpdateBtn;
			if (updateBtn != null)
			{
				goto IL_006c;
			}
			goto IL_00b4;
			IL_00b4:
			_UpdateBtn = value;
			int num = -1141208065;
			goto IL_0087;
			IL_0087:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA61BD423u) % 7u)
				{
				case 5u:
				{
					int num3;
					int num4;
					if (updateBtn == null)
					{
						num3 = 686734636;
						num4 = 686734636;
					}
					else
					{
						num3 = 181044062;
						num4 = 181044062;
					}
					num = num3 ^ ((int)num2 * -1305144312);
					continue;
				}
				case 4u:
					SearchReciever_Admin.smethod_55((Control)(object)updateBtn, eventHandler_);
					num = (int)(num2 * 1988512702) ^ -1185457942;
					continue;
				case 3u:
					SearchReciever_Admin.smethod_54((Control)(object)updateBtn, eventHandler_);
					num = (int)((num2 * 1010238436) ^ 0x1B755F9B);
					continue;
				case 2u:
					break;
				case 1u:
					updateBtn = _UpdateBtn;
					num = (int)(num2 * 859535400) ^ -234219197;
					continue;
				default:
					return;
				case 6u:
					goto IL_00b4;
				case 0u:
					return;
				}
				break;
			}
			goto IL_006c;
			IL_006c:
			num = -639621616;
			goto IL_0087;
		}
	}

	[field: AccessedThroughProperty("GenderTxt")]
	internal virtual ComboBox GenderTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("BloodGroupTxt")]
	internal virtual ComboBox BloodGroupTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public SearchReciever_Admin()
	{
		SearchReciever_Admin.smethod_0((UserControl)(object)this, (EventHandler)SearchDonor_Admin_Load);
		myconnection = SearchReciever_Admin.smethod_1();
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
			goto IL_004f;
			IL_004f:
			int num = -1609601657;
			goto IL_005b;
			IL_005b:
			int num3;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAC7375F5u) % 7u)
				{
				case 5u:
					num = (int)((num2 * 1678910519) ^ 0x2057380F);
					continue;
				case 4u:
					num = (int)((num2 * 592514305) ^ 0x42049CBB);
					continue;
				case 3u:
					SearchReciever_Admin.smethod_2((IDisposable)components);
					num = ((int)num2 * -163047284) ^ -2066748915;
					continue;
				case 2u:
					break;
				case 0u:
					num = -1824970582;
					continue;
				default:
					return;
				case 1u:
					goto IL_0088;
				case 6u:
					return;
				}
				break;
				IL_0088:
				if (components != null)
				{
					num = -896379357;
					num3 = -896379357;
					continue;
				}
				goto IL_000a;
			}
			goto IL_004f;
			IL_000a:
			num = -1207131683;
			num3 = -1207131683;
			goto IL_005b;
		}
		finally
		{
			while (true)
			{
				IL_00f2:
				int num4 = -1567659024;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num4 ^ 0xAC7375F5u) % 4u)
					{
					case 1u:
						((ContainerControl)this).Dispose(disposing);
						num4 = (int)(num2 * 584694900) ^ -958445775;
						continue;
					case 0u:
						num4 = (int)(num2 * 1649456258) ^ -1203724213;
						continue;
					default:
						goto end_IL_00d1;
					case 3u:
						break;
					case 2u:
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
		PictureBox1 = SearchReciever_Admin.smethod_3();
		while (true)
		{
			int num = -135456265;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBDDCF6D7u) % 306u)
				{
				case 305u:
					SearchReciever_Admin.smethod_23(Label1, "Search Reciever");
					num = (int)((num2 * 706793818) ^ 0x2F09D5BC);
					continue;
				case 304u:
					SearchReciever_Admin.smethod_22((Control)(object)UpdateBtn, 17);
					num = (int)((num2 * 1836251521) ^ 0x5241AAE5);
					continue;
				case 303u:
					SearchReciever_Admin.smethod_23(Label3, "Mobile : ");
					num = ((int)num2 * -1479041681) ^ 0x881020E;
					continue;
				case 302u:
					SearchReciever_Admin.smethod_21((Control)(object)Label2, SearchReciever_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1602130085) ^ -224284932;
					continue;
				case 301u:
					SearchReciever_Admin.smethod_16((Control)(object)Label1, new Size(330, 47));
					SearchReciever_Admin.smethod_22((Control)(object)Label1, 8);
					num = ((int)num2 * -158345663) ^ -2026050155;
					continue;
				case 300u:
					SearchReciever_Admin.smethod_21((Control)(object)Label1, SearchReciever_Admin.smethod_20("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1583014373) ^ 0x5DCF164B;
					continue;
				case 299u:
					num = (int)((num2 * 1883133193) ^ 0x3B44D1F6);
					continue;
				case 298u:
					ClearBtn = SearchReciever_Admin.smethod_6();
					UpdateBtn = SearchReciever_Admin.smethod_6();
					num = (int)((num2 * 371690471) ^ 0x51624C25);
					continue;
				case 297u:
					num = (int)(num2 * 1943691993) ^ -571642488;
					continue;
				case 296u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)RecieverInfoBox), (Control)(object)NameTxt);
					num = ((int)num2 * -856259680) ^ 0x47E12C81;
					continue;
				case 295u:
					SearchReciever_Admin.smethod_15((Control)(object)Label3, "Label3");
					SearchReciever_Admin.smethod_16((Control)(object)Label3, new Size(77, 28));
					num = ((int)num2 * -792134430) ^ -881434889;
					continue;
				case 294u:
					SearchReciever_Admin.smethod_16((Control)(object)GenderTxt, new Size(146, 30));
					num = (int)((num2 * 1937491062) ^ 0x1E93ABAB);
					continue;
				case 293u:
					num = (int)(num2 * 1381918465) ^ -220790678;
					continue;
				case 292u:
					SearchReciever_Admin.smethod_14((Control)(object)Label12, new Point(401, 217));
					SearchReciever_Admin.smethod_15((Control)(object)Label12, "Label12");
					SearchReciever_Admin.smethod_16((Control)(object)Label12, new Size(100, 26));
					num = (int)(num2 * 827334758) ^ -514758081;
					continue;
				case 291u:
					SearchReciever_Admin.smethod_14((Control)(object)BloodGroupTxt, new Point(531, 164));
					num = (int)(num2 * 2036239090) ^ -1990745854;
					continue;
				case 290u:
					SearchReciever_Admin.smethod_15((Control)(object)NameSTxt, "NameSTxt");
					num = ((int)num2 * -1727055823) ^ -134129421;
					continue;
				case 289u:
					SearchReciever_Admin.smethod_16((Control)(object)QuantityTxt, new Size(169, 28));
					num = ((int)num2 * -930317138) ^ 0x7BBE2583;
					continue;
				case 288u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_47((Control)(object)this), (Control)(object)GroupBox1);
					num = ((int)num2 * -1019998996) ^ -108613909;
					continue;
				case 287u:
					SearchReciever_Admin.smethod_50((ISupportInitialize)PictureBox1);
					num = ((int)num2 * -1929592236) ^ 0xDF0D7EF;
					continue;
				case 286u:
					num = (int)((num2 * 156412407) ^ 0x188CB8D);
					continue;
				case 285u:
					SearchReciever_Admin.smethod_16((Control)(object)DateRecievedTxt, new Size(222, 28));
					num = (int)(num2 * 1683228624) ^ -1129165095;
					continue;
				case 284u:
					SearchReciever_Admin.smethod_39((ListControl)(object)BloodGroupTxt, bool_0: true);
					SearchReciever_Admin.smethod_41(SearchReciever_Admin.smethod_40(BloodGroupTxt), new object[8] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
					num = (int)((num2 * 152625177) ^ 0x2CF9291C);
					continue;
				case 283u:
					SearchReciever_Admin.smethod_34(SearchResultGrid, (DataGridViewColumnHeadersHeightSizeMode)2);
					num = (int)((num2 * 1252144176) ^ 0xB9BE8E1);
					continue;
				case 282u:
					SearchReciever_Admin.smethod_15((Control)(object)IDTxt, "IDTxt");
					num = (int)(num2 * 35609121) ^ -743659982;
					continue;
				case 281u:
					SearchReciever_Admin.smethod_15((Control)(object)NameTxt, "NameTxt");
					num = ((int)num2 * -1217746821) ^ 0x5AB28D7B;
					continue;
				case 280u:
					num = ((int)num2 * -10104025) ^ -1500597061;
					continue;
				case 279u:
					num = (int)((num2 * 522633198) ^ 0x4A9CED16);
					continue;
				case 278u:
					SearchReciever_Admin.smethod_14((Control)(object)Label1, new Point(392, 63));
					num = ((int)num2 * -183295402) ^ -1515261578;
					continue;
				case 277u:
					SearchReciever_Admin.smethod_42((TextBoxBase)(object)QuantityTxt, bool_0: true);
					num = ((int)num2 * -1272975444) ^ 0x7CA4B8CE;
					continue;
				case 276u:
					Label10 = SearchReciever_Admin.smethod_4();
					num = (int)((num2 * 188941677) ^ 0x5F167E15);
					continue;
				case 275u:
					SearchReciever_Admin.smethod_22((Control)(object)Label3, 3);
					num = (int)((num2 * 989811983) ^ 0x7BDABEDC);
					continue;
				case 274u:
					SearchReciever_Admin.smethod_16((Control)(object)Label2, new Size(77, 28));
					SearchReciever_Admin.smethod_22((Control)(object)Label2, 0);
					num = (int)(num2 * 1760942837) ^ -568041171;
					continue;
				case 273u:
					SearchReciever_Admin.smethod_22((Control)(object)Label8, 9);
					SearchReciever_Admin.smethod_23(Label8, "Name : ");
					num = ((int)num2 * -1506202379) ^ -766541947;
					continue;
				case 272u:
					num = ((int)num2 * -2103407986) ^ -725403237;
					continue;
				case 271u:
					SearchReciever_Admin.smethod_15((Control)(object)DOBTxt, "DOBTxt");
					num = ((int)num2 * -1054483904) ^ -1601707439;
					continue;
				case 270u:
					SearchReciever_Admin.smethod_22((Control)(object)NameTxt, 4);
					num = (int)((num2 * 1005384249) ^ 0x7C389A5C);
					continue;
				case 269u:
					SearchReciever_Admin.smethod_30((Control)(object)ClearBtn, Color.White);
					SearchReciever_Admin.smethod_14((Control)(object)ClearBtn, new Point(808, 649));
					num = ((int)num2 * -1610866440) ^ 0x2EC9C784;
					continue;
				case 268u:
					SearchReciever_Admin.smethod_22((Control)(object)DOBTxt, 5);
					num = ((int)num2 * -1018993710) ^ -670119077;
					continue;
				case 267u:
					num = ((int)num2 * -1531896427) ^ 0x5480DF64;
					continue;
				case 266u:
					num = ((int)num2 * -587706067) ^ 0x311632C7;
					continue;
				case 265u:
					SearchReciever_Admin.smethod_33(SearchResultGrid, Color.White);
					num = ((int)num2 * -700840615) ^ -1367728111;
					continue;
				case 264u:
					SearchReciever_Admin.smethod_14((Control)(object)SearchBtn, new Point(468, 82));
					num = ((int)num2 * -1942101376) ^ 0x2412E2E5;
					continue;
				case 263u:
					SearchReciever_Admin.smethod_15((Control)(object)Label5, "Label5");
					num = (int)(num2 * 1581776320) ^ -29338111;
					continue;
				case 262u:
					num = (int)(num2 * 1613617123) ^ -1761559995;
					continue;
				case 261u:
					SearchReciever_Admin.smethod_22((Control)(object)Label11, 16);
					num = (int)(num2 * 234113040) ^ -1190674078;
					continue;
				case 260u:
					SearchReciever_Admin.smethod_14((Control)(object)UpdateBtn, new Point(808, 517));
					SearchReciever_Admin.smethod_15((Control)(object)UpdateBtn, "UpdateBtn");
					num = (int)((num2 * 1598153118) ^ 0x5B2C192E);
					continue;
				case 259u:
					SearchReciever_Admin.smethod_22((Control)(object)Label12, 18);
					num = ((int)num2 * -912622986) ^ 0x5AB2A81D;
					continue;
				case 258u:
					DOBTxt = SearchReciever_Admin.smethod_7();
					NameTxt = SearchReciever_Admin.smethod_7();
					num = ((int)num2 * -2080359506) ^ -1242705;
					continue;
				case 257u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)RecieverInfoBox), (Control)(object)Label11);
					num = (int)(num2 * 269398536) ^ -1408540532;
					continue;
				case 256u:
					num = ((int)num2 * -1996668738) ^ -1270302025;
					continue;
				case 255u:
					num = ((int)num2 * -1284271173) ^ -783615909;
					continue;
				case 254u:
					DateRecievedTxt = SearchReciever_Admin.smethod_7();
					num = ((int)num2 * -783590014) ^ -1112694422;
					continue;
				case 253u:
					SearchReciever_Admin.smethod_21((Control)(object)RecieverInfoBox, SearchReciever_Admin.smethod_20("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 967269053) ^ -1879923063;
					continue;
				case 252u:
					num = ((int)num2 * -394017457) ^ 0x7BB09B80;
					continue;
				case 251u:
					num = (int)((num2 * 1853467720) ^ 0xCCFA241);
					continue;
				case 250u:
					SearchReciever_Admin.smethod_14((Control)(object)Label3, new Point(37, 87));
					num = (int)(num2 * 161823279) ^ -1364492470;
					continue;
				case 249u:
					SearchReciever_Admin.smethod_14((Control)(object)QuantityTxt, new Point(507, 215));
					num = ((int)num2 * -1195932403) ^ -1449221633;
					continue;
				case 248u:
					num = ((int)num2 * -1250877067) ^ 0x3552B613;
					continue;
				case 247u:
					num = ((int)num2 * -1981915514) ^ -1016636306;
					continue;
				case 246u:
					SearchReciever_Admin.smethod_14((Control)(object)NameTxt, new Point(117, 77));
					num = ((int)num2 * -407670581) ^ 0x66EDDE3E;
					continue;
				case 245u:
					SearchReciever_Admin.smethod_23(Label9, "Phone : ");
					SearchReciever_Admin.smethod_24(Label9, (ContentAlignment)32);
					num = (int)((num2 * 1217036508) ^ 0x1CCC8227);
					continue;
				case 244u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_47((Control)(object)this), (Control)(object)ClearBtn);
					num = (int)(num2 * 103163528) ^ -75262940;
					continue;
				case 243u:
					num = (int)((num2 * 1282563070) ^ 0x4E62025B);
					continue;
				case 242u:
					SearchReciever_Admin.smethod_31((ButtonBase)(object)DeleteBtn, "Delete");
					num = (int)((num2 * 2041796038) ^ 0x405665E5);
					continue;
				case 241u:
					num = ((int)num2 * -2136439641) ^ 0x121A03BB;
					continue;
				case 240u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)RecieverInfoBox), (Control)(object)DOBTxt);
					num = (int)((num2 * 2101566012) ^ 0x648D426E);
					continue;
				case 239u:
					SearchReciever_Admin.smethod_15((Control)(object)MobileTxt, "MobileTxt");
					num = ((int)num2 * -637085304) ^ -169049968;
					continue;
				case 238u:
					SearchReciever_Admin.smethod_13(PictureBox1, (Image)(object)Resources.images);
					num = (int)((num2 * 345555618) ^ 0x38B92AD1);
					continue;
				case 237u:
					SearchReciever_Admin.smethod_21((Control)(object)Label3, SearchReciever_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 414324829) ^ -273616752;
					continue;
				case 236u:
					num = ((int)num2 * -1915796267) ^ 0x644875CF;
					continue;
				case 235u:
					SearchReciever_Admin.smethod_16((Control)(object)GroupBox1, new Size(623, 128));
					SearchReciever_Admin.smethod_22((Control)(object)GroupBox1, 12);
					num = ((int)num2 * -1270294006) ^ 0x3BD6FCF3;
					continue;
				case 234u:
					SearchReciever_Admin.smethod_31((ButtonBase)(object)ClearBtn, "Clear");
					num = (int)(num2 * 1946207999) ^ -499726042;
					continue;
				case 233u:
					SearchReciever_Admin.smethod_23(Label4, "Blood Group : ");
					SearchReciever_Admin.smethod_24(Label4, (ContentAlignment)32);
					num = ((int)num2 * -1913881409) ^ 0x60476FF8;
					continue;
				case 232u:
					SearchReciever_Admin.smethod_23(Label12, "Quantity : ");
					num = ((int)num2 * -1598264736) ^ -513178396;
					continue;
				case 231u:
					SearchReciever_Admin.smethod_14((Control)(object)GenderTxt, new Point(530, 117));
					num = ((int)num2 * -142756451) ^ -2065710269;
					continue;
				case 230u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)GroupBox1), (Control)(object)Label3);
					num = (int)((num2 * 1914782055) ^ 0x6B334DFF);
					continue;
				case 229u:
					num = (int)(num2 * 491693279) ^ -240808344;
					continue;
				case 228u:
					SearchReciever_Admin.smethod_14((Control)(object)DeleteBtn, new Point(808, 584));
					num = (int)((num2 * 768289421) ^ 0xCE942AE);
					continue;
				case 227u:
					SearchReciever_Admin.smethod_14((Control)(object)RecieverInfoBox, new Point(79, 470));
					num = ((int)num2 * -1654000249) ^ -1218507844;
					continue;
				case 226u:
					num = (int)((num2 * 1061608897) ^ 0x6931821A);
					continue;
				case 225u:
					SearchReciever_Admin.smethod_14((Control)(object)Label8, new Point(16, 78));
					num = ((int)num2 * -1125667102) ^ 0x1F3C83DF;
					continue;
				case 224u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)RecieverInfoBox), (Control)(object)Label12);
					num = (int)((num2 * 186345272) ^ 0xCEA2860);
					continue;
				case 223u:
					SearchReciever_Admin.smethod_49((Control)(object)this, new Size(977, 804));
					num = (int)((num2 * 1993440263) ^ 0x58BF6313);
					continue;
				case 222u:
					num = ((int)num2 * -2100539767) ^ 0x24E910F0;
					continue;
				case 221u:
					SearchReciever_Admin.smethod_38(GenderTxt, (ComboBoxStyle)2);
					SearchReciever_Admin.smethod_39((ListControl)(object)GenderTxt, bool_0: true);
					num = ((int)num2 * -1668466034) ^ -1364465381;
					continue;
				case 220u:
					num = (int)(num2 * 276708223) ^ -1928445854;
					continue;
				case 219u:
					SearchReciever_Admin.smethod_22((Control)(object)RecieverInfoBox, 14);
					num = ((int)num2 * -556633581) ^ -228196103;
					continue;
				case 218u:
					SearchReciever_Admin.smethod_31((ButtonBase)(object)UpdateBtn, "Update");
					SearchReciever_Admin.smethod_32((ButtonBase)(object)UpdateBtn, bool_0: false);
					num = (int)(num2 * 1142252445) ^ -1582238687;
					continue;
				case 217u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)RecieverInfoBox), (Control)(object)Label9);
					num = (int)((num2 * 728929727) ^ 0x1B04C3AB);
					continue;
				case 216u:
					SearchReciever_Admin.smethod_15((Control)(object)BloodGroupTxt, "BloodGroupTxt");
					num = ((int)num2 * -579316738) ^ -1024205;
					continue;
				case 215u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)GroupBox1), (Control)(object)SearchBtn);
					num = (int)((num2 * 601411019) ^ 0x54C81564);
					continue;
				case 214u:
					SearchReciever_Admin.smethod_16((Control)(object)Label4, new Size(134, 28));
					num = (int)(num2 * 191957420) ^ -1780383374;
					continue;
				case 213u:
					SearchReciever_Admin.smethod_16((Control)(object)UpdateBtn, new Size(104, 37));
					num = ((int)num2 * -2050733628) ^ 0x59190C9E;
					continue;
				case 212u:
					Label12 = SearchReciever_Admin.smethod_4();
					num = (int)(num2 * 1624366342) ^ -549953759;
					continue;
				case 211u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)RecieverInfoBox), (Control)(object)GenderTxt);
					num = (int)((num2 * 192294550) ^ 0x13B81972);
					continue;
				case 210u:
					NameSTxt = SearchReciever_Admin.smethod_7();
					num = (int)(num2 * 549415335) ^ -203564714;
					continue;
				case 209u:
					num = (int)((num2 * 1123052374) ^ 0x4FA32BA1);
					continue;
				case 208u:
					SearchReciever_Admin.smethod_15((Control)(object)GroupBox1, "GroupBox1");
					num = (int)((num2 * 2023163582) ^ 0x21B36319);
					continue;
				case 206u:
					SearchReciever_Admin.smethod_32((ButtonBase)(object)ClearBtn, bool_0: false);
					num = (int)((num2 * 2143346795) ^ 0x5CCE2B90);
					continue;
				case 205u:
					Label9 = SearchReciever_Admin.smethod_4();
					num = (int)((num2 * 1118807718) ^ 0x5DCDA357);
					continue;
				case 204u:
					SearchReciever_Admin.smethod_16((Control)(object)MobileSTxt, new Size(237, 28));
					num = (int)((num2 * 447154674) ^ 0x567A07F);
					continue;
				case 203u:
					SearchReciever_Admin.smethod_15((Control)(object)DeleteBtn, "DeleteBtn");
					num = (int)((num2 * 967631086) ^ 0x2C315AFC);
					continue;
				case 202u:
					num = (int)(num2 * 728291389) ^ -406882348;
					continue;
				case 201u:
					num = ((int)num2 * -1528240064) ^ -2089452560;
					continue;
				case 200u:
					SearchReciever_Admin.smethod_51((Control)(object)GroupBox1, bool_0: false);
					SearchReciever_Admin.smethod_52((Control)(object)GroupBox1);
					SearchReciever_Admin.smethod_50((ISupportInitialize)SearchResultGrid);
					num = ((int)num2 * -296296524) ^ -16616735;
					continue;
				case 199u:
					SearchReciever_Admin.smethod_29((ButtonBase)(object)ClearBtn, Color.MidnightBlue);
					SearchReciever_Admin.smethod_21((Control)(object)ClearBtn, SearchReciever_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 76228149) ^ 0x21C7D249);
					continue;
				case 198u:
					SearchReciever_Admin.smethod_16((Control)(object)ClearBtn, new Size(104, 37));
					num = ((int)num2 * -1582479988) ^ -702115772;
					continue;
				case 197u:
					SearchReciever_Admin.smethod_43((Control)(object)UpdateBtn, bool_0: false);
					SearchReciever_Admin.smethod_44((ContainerControl)(object)this, new SizeF(8f, 16f));
					num = (int)((num2 * 84442637) ^ 0x5756532C);
					continue;
				case 196u:
					num = (int)((num2 * 1365178448) ^ 0x2702581);
					continue;
				case 195u:
					SearchReciever_Admin.smethod_23(Label11, "ID :");
					num = (int)((num2 * 1494832954) ^ 0x677C76E);
					continue;
				case 194u:
					num = (int)((num2 * 1574051272) ^ 0x3606C101);
					continue;
				case 193u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)RecieverInfoBox), (Control)(object)IDTxt);
					num = (int)((num2 * 803202248) ^ 0x106F901A);
					continue;
				case 192u:
					SearchReciever_Admin.smethod_15((Control)(object)Label6, "Label6");
					num = ((int)num2 * -1970983585) ^ 0x637604A4;
					continue;
				case 191u:
					num = (int)((num2 * 2029628526) ^ 0x2A128FF7);
					continue;
				case 190u:
					num = ((int)num2 * -1906465562) ^ -291611813;
					continue;
				case 189u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)RecieverInfoBox), (Control)(object)Label10);
					num = (int)((num2 * 619712058) ^ 0x382860D4);
					continue;
				case 188u:
					num = ((int)num2 * -2084646633) ^ 0x1129F194;
					continue;
				case 187u:
					SearchReciever_Admin.smethod_21((Control)(object)DeleteBtn, SearchReciever_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -2117192429) ^ 0x5798733E;
					continue;
				case 186u:
					num = ((int)num2 * -629993782) ^ -1826736262;
					continue;
				case 185u:
					num = ((int)num2 * -533488700) ^ -1578574892;
					continue;
				case 184u:
					SearchReciever_Admin.smethod_14((Control)(object)Label9, new Point(16, 124));
					num = (int)(num2 * 1376757580) ^ -2103941760;
					continue;
				case 183u:
					MobileSTxt = SearchReciever_Admin.smethod_7();
					num = ((int)num2 * -1147924086) ^ -141326990;
					continue;
				case 182u:
					SearchReciever_Admin.smethod_30((Control)(object)UpdateBtn, Color.White);
					num = ((int)num2 * -486916016) ^ 0x70A14D79;
					continue;
				case 181u:
					num = ((int)num2 * -305426823) ^ 0x1AF3EF2B;
					continue;
				case 179u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)RecieverInfoBox), (Control)(object)QuantityTxt);
					num = (int)((num2 * 1178336037) ^ 0x7F3C7ED1);
					continue;
				case 178u:
					SearchReciever_Admin.smethod_22((Control)(object)MobileTxt, 12);
					SearchReciever_Admin.smethod_21((Control)(object)Label9, SearchReciever_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1890917148) ^ -1866290842;
					continue;
				case 177u:
					SearchReciever_Admin.smethod_24(Label8, (ContentAlignment)32);
					SearchReciever_Admin.smethod_14((Control)(object)DOBTxt, new Point(117, 167));
					num = (int)((num2 * 703298141) ^ 0x37DF43F7);
					continue;
				case 176u:
					num = ((int)num2 * -2094197040) ^ 0x8B0A08E;
					continue;
				case 175u:
					SearchReciever_Admin.smethod_21((Control)(object)Label4, SearchReciever_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -2040693681) ^ 0x380C0DA;
					continue;
				case 174u:
					num = (int)(num2 * 1814302589) ^ -1203901850;
					continue;
				case 173u:
					SearchReciever_Admin.smethod_16((Control)(object)SearchBtn, new Size(133, 37));
					num = (int)((num2 * 1591704433) ^ 0x3BA51B9C);
					continue;
				case 172u:
					SearchReciever_Admin.smethod_16((Control)(object)Label8, new Size(77, 28));
					num = ((int)num2 * -1082538924) ^ 0x5D1D2612;
					continue;
				case 171u:
					num = ((int)num2 * -430454096) ^ 0x4265FFB7;
					continue;
				case 170u:
					SearchReciever_Admin.smethod_22((Control)(object)BloodGroupTxt, 21);
					num = (int)((num2 * 1240960814) ^ 0x2FCB3FC);
					continue;
				case 169u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)RecieverInfoBox), (Control)(object)DateRecievedTxt);
					num = ((int)num2 * -139886577) ^ -1686284027;
					continue;
				case 168u:
					num = (int)(num2 * 2078610540) ^ -192603109;
					continue;
				case 167u:
					SearchReciever_Admin.smethod_42((TextBoxBase)(object)DateRecievedTxt, bool_0: true);
					num = ((int)num2 * -1123995255) ^ -1620767391;
					continue;
				case 166u:
					SearchReciever_Admin.smethod_22((Control)(object)SearchBtn, 4);
					num = ((int)num2 * -640031586) ^ -974368910;
					continue;
				case 165u:
					SearchReciever_Admin.smethod_24(Label2, (ContentAlignment)32);
					num = (int)((num2 * 168381972) ^ 0x773BE724);
					continue;
				case 164u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)GroupBox1), (Control)(object)MobileSTxt);
					num = ((int)num2 * -339255509) ^ 0x10C9DE66;
					continue;
				case 163u:
					num = ((int)num2 * -537787586) ^ -1010774401;
					continue;
				case 162u:
					SearchReciever_Admin.smethod_16((Control)(object)NameSTxt, new Size(237, 28));
					num = (int)((num2 * 1891429239) ^ 0x4EE779F6);
					continue;
				case 161u:
					num = (int)(num2 * 1470769848) ^ -885579270;
					continue;
				case 160u:
					SearchReciever_Admin.smethod_14((Control)(object)Label6, new Point(401, 129));
					num = ((int)num2 * -1096898226) ^ 0x291CB1B1;
					continue;
				case 159u:
					RecieverInfoBox = SearchReciever_Admin.smethod_5();
					num = ((int)num2 * -1050575464) ^ 0x25EFEAD5;
					continue;
				case 158u:
					SearchReciever_Admin.smethod_45((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 853557816) ^ -1321203831;
					continue;
				case 157u:
					SearchReciever_Admin.smethod_15((Control)(object)Label9, "Label9");
					num = (int)((num2 * 1097799416) ^ 0x5592AC96);
					continue;
				case 156u:
					SearchReciever_Admin.smethod_14((Control)(object)MobileTxt, new Point(117, 124));
					num = (int)(num2 * 1635262675) ^ -899061238;
					continue;
				case 155u:
					num = (int)((num2 * 1591997968) ^ 0x1E7B606F);
					continue;
				case 154u:
					SearchReciever_Admin.smethod_10((ISupportInitialize)PictureBox1);
					SearchReciever_Admin.smethod_11((Control)(object)GroupBox1);
					SearchReciever_Admin.smethod_10((ISupportInitialize)SearchResultGrid);
					num = ((int)num2 * -905266344) ^ 0x32939BC1;
					continue;
				case 153u:
					SearchReciever_Admin.smethod_15((Control)(object)QuantityTxt, "QuantityTxt");
					num = ((int)num2 * -1630203512) ^ 0x48915064;
					continue;
				case 152u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)RecieverInfoBox), (Control)(object)Label5);
					num = (int)(num2 * 1158541011) ^ -1256789608;
					continue;
				case 151u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)GroupBox1), (Control)(object)Label2);
					num = (int)((num2 * 153593863) ^ 0x408D8BD1);
					continue;
				case 150u:
					Label4 = SearchReciever_Admin.smethod_4();
					num = ((int)num2 * -2008131738) ^ 0x6D754F93;
					continue;
				case 149u:
					num = ((int)num2 * -1650833302) ^ 0x3D15AEE0;
					continue;
				case 148u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_47((Control)(object)this), (Control)(object)SearchResultGrid);
					num = (int)((num2 * 1872716002) ^ 0x40F098B1);
					continue;
				case 147u:
					SearchReciever_Admin.smethod_14((Control)(object)Label2, new Point(37, 44));
					num = (int)(num2 * 719852924) ^ -117232035;
					continue;
				case 146u:
					SearchReciever_Admin.smethod_16((Control)(object)PictureBox1, new Size(197, 126));
					SearchReciever_Admin.smethod_17(PictureBox1, (PictureBoxSizeMode)1);
					num = (int)((num2 * 401690923) ^ 0xAAA6379);
					continue;
				case 145u:
					Label2 = SearchReciever_Admin.smethod_4();
					SearchResultGrid = SearchReciever_Admin.smethod_8();
					num = ((int)num2 * -2003824653) ^ -231106821;
					continue;
				case 144u:
					SearchReciever_Admin.smethod_51((Control)(object)RecieverInfoBox, bool_0: false);
					num = ((int)num2 * -1024835121) ^ 0x60A2B02;
					continue;
				case 143u:
					num = (int)((num2 * 787217910) ^ 0x7DD25132);
					continue;
				case 142u:
					SearchReciever_Admin.smethod_22((Control)(object)DateRecievedTxt, 10);
					SearchReciever_Admin.smethod_21((Control)(object)Label8, SearchReciever_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -644004300) ^ 0x1A4CEDA8;
					continue;
				case 141u:
					SearchReciever_Admin.smethod_42((TextBoxBase)(object)IDTxt, bool_0: true);
					SearchReciever_Admin.smethod_16((Control)(object)IDTxt, new Size(204, 28));
					SearchReciever_Admin.smethod_22((Control)(object)IDTxt, 17);
					num = (int)(num2 * 412096054) ^ -2016984370;
					continue;
				case 140u:
					SearchReciever_Admin.smethod_14((Control)(object)GroupBox1, new Point(155, 150));
					num = (int)((num2 * 1363712855) ^ 0x435F4EE6);
					continue;
				case 139u:
					SearchReciever_Admin.smethod_23(Label10, "Date Recieved :");
					num = (int)(num2 * 803689565) ^ -457359758;
					continue;
				case 138u:
					SearchReciever_Admin.smethod_30((Control)(object)SearchBtn, Color.White);
					num = ((int)num2 * -571844514) ^ 0xB4F6E8B;
					continue;
				case 137u:
					num = ((int)num2 * -1627658633) ^ -973518019;
					continue;
				case 136u:
					num = (int)(num2 * 725294540) ^ -941410070;
					continue;
				case 135u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)RecieverInfoBox), (Control)(object)MobileTxt);
					num = (int)(num2 * 1842469129) ^ -1961872791;
					continue;
				case 134u:
					num = (int)((num2 * 1689546084) ^ 0x2F9A9A68);
					continue;
				case 133u:
					num = ((int)num2 * -702857847) ^ 0x5C4F7C27;
					continue;
				case 132u:
					SearchReciever_Admin.smethod_27(GroupBox1, bool_0: false);
					num = ((int)num2 * -59492536) ^ -1084341809;
					continue;
				case 131u:
					num = ((int)num2 * -353169965) ^ 0x7EAD0CE3;
					continue;
				case 130u:
					Label1 = SearchReciever_Admin.smethod_4();
					num = ((int)num2 * -9739998) ^ 0x7B95AA27;
					continue;
				case 129u:
					SearchReciever_Admin.smethod_21((Control)(object)GroupBox1, SearchReciever_Admin.smethod_20("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 955594194) ^ 0x7FF35995);
					continue;
				case 128u:
					num = ((int)num2 * -789142836) ^ 0x356009A5;
					continue;
				case 127u:
					num = ((int)num2 * -1000341272) ^ 0x7E73AAA6;
					continue;
				case 126u:
					SearchReciever_Admin.smethod_22((Control)(object)Label6, 2);
					SearchReciever_Admin.smethod_23(Label6, "Gender : ");
					num = (int)(num2 * 1916795250) ^ -1499415614;
					continue;
				case 125u:
					SearchReciever_Admin.smethod_31((ButtonBase)(object)SearchBtn, "Search");
					SearchReciever_Admin.smethod_32((ButtonBase)(object)SearchBtn, bool_0: false);
					num = ((int)num2 * -1241706794) ^ -1033986032;
					continue;
				case 124u:
					num = (int)(num2 * 464855615) ^ -1325105286;
					continue;
				case 123u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)RecieverInfoBox), (Control)(object)BloodGroupTxt);
					num = ((int)num2 * -541593586) ^ 0x5BEF1A62;
					continue;
				case 122u:
					SearchReciever_Admin.smethod_29((ButtonBase)(object)SearchBtn, Color.MidnightBlue);
					SearchReciever_Admin.smethod_21((Control)(object)SearchBtn, SearchReciever_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1306590979) ^ -66639875;
					continue;
				case 121u:
					SearchReciever_Admin.smethod_14((Control)(object)SearchResultGrid, new Point(59, 295));
					num = ((int)num2 * -166423254) ^ -1557815118;
					continue;
				case 120u:
					num = ((int)num2 * -1627577675) ^ 0x28757239;
					continue;
				case 119u:
					Label3 = SearchReciever_Admin.smethod_4();
					num = (int)(num2 * 710221478) ^ -733520005;
					continue;
				case 118u:
					SearchReciever_Admin.smethod_14((Control)(object)PictureBox1, new Point(203, 18));
					num = (int)(num2 * 188305792) ^ -868237970;
					continue;
				case 117u:
					SearchReciever_Admin.smethod_46((Control)(object)this, Color.White);
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_47((Control)(object)this), (Control)(object)UpdateBtn);
					num = (int)(num2 * 1805414766) ^ -183360235;
					continue;
				case 116u:
					SearchReciever_Admin.smethod_15((Control)(object)DateRecievedTxt, "DateRecievedTxt");
					num = ((int)num2 * -2145406868) ^ 0x5B515739;
					continue;
				case 115u:
					SearchReciever_Admin.smethod_22((Control)(object)ClearBtn, 16);
					num = ((int)num2 * -1454622243) ^ -117089358;
					continue;
				case 114u:
					SearchReciever_Admin.smethod_15((Control)(object)SearchBtn, "SearchBtn");
					num = ((int)num2 * -906739118) ^ 0x7B0127C;
					continue;
				case 113u:
					SearchReciever_Admin.smethod_37(SearchReciever_Admin.smethod_36(SearchResultGrid), 24);
					num = (int)((num2 * 943287321) ^ 0x23BCA93F);
					continue;
				case 112u:
					GroupBox1 = SearchReciever_Admin.smethod_5();
					num = ((int)num2 * -213414767) ^ 0x792F3D36;
					continue;
				case 111u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)RecieverInfoBox), (Control)(object)Label4);
					num = ((int)num2 * -700951388) ^ 0xE37BF22;
					continue;
				case 110u:
					DeleteBtn = SearchReciever_Admin.smethod_6();
					num = (int)(num2 * 490144264) ^ -714887334;
					continue;
				case 109u:
					SearchReciever_Admin.smethod_24(Label1, (ContentAlignment)32);
					num = ((int)num2 * -1387898438) ^ -975882416;
					continue;
				case 108u:
					BloodGroupTxt = SearchReciever_Admin.smethod_9();
					num = (int)((num2 * 578514055) ^ 0x456B5974);
					continue;
				case 107u:
					num = (int)(num2 * 1158365757) ^ -1526305223;
					continue;
				case 106u:
					SearchReciever_Admin.smethod_14((Control)(object)Label10, new Point(16, 221));
					num = (int)((num2 * 685701276) ^ 0x27669051);
					continue;
				case 105u:
					num = ((int)num2 * -1698764274) ^ 0x19F09552;
					continue;
				case 104u:
					num = ((int)num2 * -1755962782) ^ -1681559808;
					continue;
				case 103u:
					SearchReciever_Admin.smethod_22((Control)(object)NameSTxt, 1);
					num = ((int)num2 * -1194193679) ^ 0x745C9F7C;
					continue;
				case 102u:
					SearchReciever_Admin.smethod_11((Control)(object)RecieverInfoBox);
					SearchReciever_Admin.smethod_12((Control)(object)this);
					num = ((int)num2 * -288197369) ^ -404005997;
					continue;
				case 101u:
					SearchReciever_Admin.smethod_16((Control)(object)Label9, new Size(77, 28));
					SearchReciever_Admin.smethod_22((Control)(object)Label9, 11);
					num = ((int)num2 * -842055283) ^ -183324385;
					continue;
				case 100u:
					SearchReciever_Admin.smethod_14((Control)(object)DateRecievedTxt, new Point(166, 215));
					num = ((int)num2 * -292743111) ^ -1851257657;
					continue;
				case 99u:
					num = (int)((num2 * 1062487566) ^ 0x20042A72);
					continue;
				case 98u:
					SearchReciever_Admin.smethod_15((Control)(object)PictureBox1, "PictureBox1");
					num = ((int)num2 * -2138406467) ^ -1073652319;
					continue;
				case 97u:
					SearchReciever_Admin.smethod_21((Control)(object)Label5, SearchReciever_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -550340125) ^ 0x5B5C5BBC;
					continue;
				case 96u:
					MobileTxt = SearchReciever_Admin.smethod_7();
					num = (int)((num2 * 730268338) ^ 0x30EF1176);
					continue;
				case 95u:
					SearchReciever_Admin.smethod_29((ButtonBase)(object)UpdateBtn, Color.MidnightBlue);
					num = (int)(num2 * 1358144532) ^ -70015689;
					continue;
				case 94u:
					num = (int)(num2 * 526731589) ^ -1521905519;
					continue;
				case 93u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)RecieverInfoBox), (Control)(object)Label8);
					num = (int)((num2 * 1166490208) ^ 0x4D97B2B);
					continue;
				case 92u:
					SearchReciever_Admin.smethod_30((Control)(object)DeleteBtn, Color.White);
					num = (int)(num2 * 1031457592) ^ -636815099;
					continue;
				case 91u:
					SearchReciever_Admin.smethod_15((Control)(object)SearchResultGrid, "SearchResultGrid");
					SearchReciever_Admin.smethod_35(SearchResultGrid, bool_0: true);
					num = ((int)num2 * -473384248) ^ -957977725;
					continue;
				case 90u:
					num = ((int)num2 * -1259581096) ^ -1695003698;
					continue;
				case 89u:
					SearchReciever_Admin.smethod_23(Label2, "Name : ");
					num = (int)(num2 * 746406256) ^ -911581749;
					continue;
				case 88u:
					num = (int)((num2 * 659349224) ^ 0x698681D2);
					continue;
				case 87u:
					num = (int)(num2 * 1376601126) ^ -1792656273;
					continue;
				case 86u:
					SearchReciever_Admin.smethod_22((Control)(object)MobileSTxt, 2);
					num = ((int)num2 * -1852628077) ^ -678882955;
					continue;
				case 85u:
					SearchReciever_Admin.smethod_15((Control)(object)ClearBtn, "ClearBtn");
					num = (int)(num2 * 1153703126) ^ -47232271;
					continue;
				case 84u:
					SearchReciever_Admin.smethod_14((Control)(object)Label5, new Point(16, 169));
					num = ((int)num2 * -1518651508) ^ -1039509340;
					continue;
				case 83u:
					num = ((int)num2 * -1573014001) ^ 0x2F032314;
					continue;
				case 82u:
					SearchReciever_Admin.smethod_21((Control)(object)Label6, SearchReciever_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1524327197) ^ 0x46BE3F90;
					continue;
				case 81u:
					num = ((int)num2 * -404080069) ^ -1106784984;
					continue;
				case 80u:
					SearchReciever_Admin.smethod_15((Control)(object)Label1, "Label1");
					num = ((int)num2 * -1270574830) ^ 0x76656B50;
					continue;
				case 79u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_47((Control)(object)this), (Control)(object)DeleteBtn);
					num = (int)(num2 * 793284565) ^ -1236714068;
					continue;
				case 78u:
					SearchReciever_Admin.smethod_16((Control)(object)RecieverInfoBox, new Size(699, 259));
					num = ((int)num2 * -1508802620) ^ 0x6455B4CF;
					continue;
				case 77u:
					SearchReciever_Admin.smethod_16((Control)(object)SearchResultGrid, new Size(853, 169));
					num = ((int)num2 * -1305577713) ^ 0x53D06421;
					continue;
				case 76u:
					SearchReciever_Admin.smethod_14((Control)(object)NameSTxt, new Point(120, 44));
					num = (int)((num2 * 1317622875) ^ 0x54F04A26);
					continue;
				case 75u:
					SearchReciever_Admin.smethod_16((Control)(object)MobileTxt, new Size(271, 28));
					num = ((int)num2 * -1304096555) ^ -1254746414;
					continue;
				case 74u:
					SearchReciever_Admin.smethod_41(SearchReciever_Admin.smethod_40(GenderTxt), new object[3] { "Male", "Female", "Others" });
					num = (int)((num2 * 853839078) ^ 0x1D044382);
					continue;
				case 73u:
					num = (int)(num2 * 1975370813) ^ -1411882155;
					continue;
				case 72u:
					num = (int)(num2 * 2062873622) ^ -2109097769;
					continue;
				case 71u:
					num = ((int)num2 * -2096506914) ^ 0xF61CBC3;
					continue;
				case 70u:
					SearchReciever_Admin.smethod_22((Control)(object)QuantityTxt, 19);
					num = ((int)num2 * -1140833779) ^ -1356953312;
					continue;
				case 69u:
					num = (int)((num2 * 2101087252) ^ 0x26753DEA);
					continue;
				case 68u:
					SearchReciever_Admin.smethod_48((Control)(object)this, "SearchReciever_Admin");
					num = ((int)num2 * -60898745) ^ 0x24B3298E;
					continue;
				case 67u:
					num = (int)(num2 * 989275481) ^ -2106071478;
					continue;
				case 66u:
					num = ((int)num2 * -2081707124) ^ -1847872618;
					continue;
				case 65u:
					SearchReciever_Admin.smethod_22((Control)(object)Label4, 13);
					num = ((int)num2 * -178122108) ^ 0x2198CB4E;
					continue;
				case 64u:
					num = ((int)num2 * -1030518470) ^ -1762443281;
					continue;
				case 63u:
					SearchReciever_Admin.smethod_15((Control)(object)Label2, "Label2");
					num = ((int)num2 * -879058442) ^ 0x6D9D5C05;
					continue;
				case 62u:
					SearchReciever_Admin.smethod_22((Control)(object)Label10, 0);
					num = (int)((num2 * 301028002) ^ 0x29229896);
					continue;
				case 61u:
					num = (int)((num2 * 408600056) ^ 0x7C7C2379);
					continue;
				case 60u:
					num = (int)((num2 * 1189765946) ^ 0x329DE627);
					continue;
				case 59u:
					num = (int)((num2 * 1735811199) ^ 0x56701623);
					continue;
				case 58u:
					SearchReciever_Admin.smethod_22((Control)(object)GenderTxt, 20);
					num = (int)(num2 * 30237112) ^ -188660795;
					continue;
				case 57u:
					Label8 = SearchReciever_Admin.smethod_4();
					num = (int)((num2 * 76653681) ^ 0x2291958);
					continue;
				case 56u:
					num = (int)((num2 * 323172157) ^ 0x5BB37CCC);
					continue;
				case 55u:
					num = (int)((num2 * 399762538) ^ 0x3125DB8A);
					continue;
				case 54u:
					num = ((int)num2 * -6915594) ^ -1410016809;
					continue;
				case 53u:
					SearchReciever_Admin.smethod_16((Control)(object)NameTxt, new Size(271, 28));
					num = ((int)num2 * -1660490403) ^ 0x2C8E7E4E;
					continue;
				case 52u:
					num = ((int)num2 * -1848582050) ^ -1487928119;
					continue;
				case 51u:
					SearchReciever_Admin.smethod_15((Control)(object)Label10, "Label10");
					num = (int)(num2 * 641424783) ^ -2107584641;
					continue;
				case 50u:
					num = ((int)num2 * -385119900) ^ 0x6D3BBA5B;
					continue;
				case 49u:
					SearchReciever_Admin.smethod_16((Control)(object)Label6, new Size(84, 26));
					num = ((int)num2 * -945631610) ^ -39936769;
					continue;
				case 48u:
					SearchReciever_Admin.smethod_18(PictureBox1, 7);
					num = ((int)num2 * -2064281676) ^ 0x3C710F9A;
					continue;
				case 47u:
					SearchReciever_Admin.smethod_52((Control)(object)RecieverInfoBox);
					SearchReciever_Admin.smethod_53((Control)(object)this, bool_0: false);
					num = (int)((num2 * 1681718384) ^ 0x45A1F1E5);
					continue;
				case 46u:
					Label6 = SearchReciever_Admin.smethod_4();
					Label5 = SearchReciever_Admin.smethod_4();
					num = (int)(num2 * 719508816) ^ -780877907;
					continue;
				case 45u:
					num = (int)(num2 * 1025526743) ^ -1148064858;
					continue;
				case 44u:
					SearchBtn = SearchReciever_Admin.smethod_6();
					num = (int)((num2 * 903497619) ^ 0x52412124);
					continue;
				case 43u:
					SearchReciever_Admin.smethod_27(RecieverInfoBox, bool_0: false);
					num = ((int)num2 * -886716979) ^ -1787970409;
					continue;
				case 42u:
					SearchReciever_Admin.smethod_15((Control)(object)GenderTxt, "GenderTxt");
					num = ((int)num2 * -697452495) ^ 0x7E26CB95;
					continue;
				case 41u:
					SearchReciever_Admin.smethod_22((Control)(object)SearchResultGrid, 13);
					num = ((int)num2 * -292798733) ^ 0x51A1CA23;
					continue;
				case 40u:
					SearchReciever_Admin.smethod_24(Label3, (ContentAlignment)32);
					SearchReciever_Admin.smethod_14((Control)(object)MobileSTxt, new Point(120, 86));
					SearchReciever_Admin.smethod_15((Control)(object)MobileSTxt, "MobileSTxt");
					num = ((int)num2 * -2008352572) ^ -1825854088;
					continue;
				case 39u:
					num = ((int)num2 * -1078337781) ^ -1444239140;
					continue;
				case 38u:
					QuantityTxt = SearchReciever_Admin.smethod_7();
					num = ((int)num2 * -1936115719) ^ -1056262302;
					continue;
				case 37u:
					SearchReciever_Admin.smethod_28(RecieverInfoBox, "Reciever Information");
					SearchReciever_Admin.smethod_38(BloodGroupTxt, (ComboBoxStyle)2);
					num = (int)(num2 * 1829369085) ^ -727628044;
					continue;
				case 36u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_47((Control)(object)this), (Control)(object)Label1);
					num = (int)(num2 * 1088487142) ^ -1507105298;
					continue;
				case 35u:
					GenderTxt = SearchReciever_Admin.smethod_9();
					num = (int)((num2 * 1239504465) ^ 0x4211784);
					continue;
				case 34u:
					num = (int)(num2 * 75736021) ^ -1205320008;
					continue;
				case 33u:
					SearchReciever_Admin.smethod_21((Control)(object)Label11, SearchReciever_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					SearchReciever_Admin.smethod_14((Control)(object)Label11, new Point(16, 36));
					SearchReciever_Admin.smethod_15((Control)(object)Label11, "Label11");
					SearchReciever_Admin.smethod_16((Control)(object)Label11, new Size(68, 25));
					num = (int)(num2 * 818503081) ^ -2118860039;
					continue;
				case 32u:
					SearchReciever_Admin.smethod_15((Control)(object)RecieverInfoBox, "RecieverInfoBox");
					num = (int)(num2 * 208575549) ^ -416282981;
					continue;
				case 31u:
					SearchReciever_Admin.smethod_28(GroupBox1, "Search Patient");
					num = (int)(num2 * 1580245019) ^ -2121659994;
					continue;
				case 30u:
					SearchReciever_Admin.smethod_16((Control)(object)Label5, new Size(84, 26));
					SearchReciever_Admin.smethod_22((Control)(object)Label5, 1);
					num = (int)(num2 * 530587101) ^ -939010242;
					continue;
				case 29u:
					SearchReciever_Admin.smethod_23(Label5, "Age :");
					SearchReciever_Admin.smethod_21((Control)(object)Label10, SearchReciever_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1828299344) ^ -462853977;
					continue;
				case 28u:
					Label11 = SearchReciever_Admin.smethod_4();
					num = ((int)num2 * -331385959) ^ -128206590;
					continue;
				case 27u:
					num = ((int)num2 * -1131091151) ^ 0x47CE7DFA;
					continue;
				case 26u:
					SearchReciever_Admin.smethod_15((Control)(object)Label8, "Label8");
					num = (int)((num2 * 302575996) ^ 0x3F98DD8C);
					continue;
				case 25u:
					SearchReciever_Admin.smethod_21((Control)(object)UpdateBtn, SearchReciever_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1320159187) ^ -1241614886;
					continue;
				case 24u:
					num = ((int)num2 * -1516477798) ^ -413338785;
					continue;
				case 23u:
					num = (int)(num2 * 1551244506) ^ -1603586930;
					continue;
				case 22u:
					SearchReciever_Admin.smethod_16((Control)(object)DOBTxt, new Size(169, 28));
					num = (int)(num2 * 1118771486) ^ -1461172917;
					continue;
				case 21u:
					SearchReciever_Admin.smethod_16((Control)(object)DeleteBtn, new Size(104, 37));
					SearchReciever_Admin.smethod_22((Control)(object)DeleteBtn, 15);
					num = (int)(num2 * 1790360856) ^ -2082813081;
					continue;
				case 20u:
					num = (int)((num2 * 1594806072) ^ 0x3A696C30);
					continue;
				case 19u:
					SearchReciever_Admin.smethod_16((Control)(object)Label10, new Size(174, 25));
					num = (int)(num2 * 2021201817) ^ -1910138669;
					continue;
				case 18u:
					SearchReciever_Admin.smethod_14((Control)(object)Label4, new Point(388, 164));
					SearchReciever_Admin.smethod_15((Control)(object)Label4, "Label4");
					num = (int)((num2 * 2069282250) ^ 0x1C78C943);
					continue;
				case 17u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)RecieverInfoBox), (Control)(object)Label6);
					num = ((int)num2 * -990077994) ^ -400851661;
					continue;
				case 16u:
					IDTxt = SearchReciever_Admin.smethod_7();
					num = ((int)num2 * -1632363034) ^ 0x74B09FA6;
					continue;
				case 15u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)GroupBox1), (Control)(object)NameSTxt);
					num = (int)((num2 * 1717089551) ^ 0x2BAA2E85);
					continue;
				case 14u:
					num = (int)((num2 * 437801262) ^ 0x25EBD807);
					continue;
				case 13u:
					num = ((int)num2 * -2026831441) ^ 0x3F021A30;
					continue;
				case 12u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_47((Control)(object)this), (Control)(object)RecieverInfoBox);
					num = ((int)num2 * -2001458900) ^ -203635;
					continue;
				case 11u:
					SearchReciever_Admin.smethod_21((Control)(object)Label12, SearchReciever_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1635325188) ^ -592532994;
					continue;
				case 10u:
					SearchReciever_Admin.smethod_32((ButtonBase)(object)DeleteBtn, bool_0: false);
					num = ((int)num2 * -2146676407) ^ -1268711792;
					continue;
				case 9u:
					num = (int)(num2 * 1483379163) ^ -305230009;
					continue;
				case 8u:
					num = (int)(num2 * 1057592719) ^ -833010327;
					continue;
				case 7u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_47((Control)(object)this), (Control)(object)PictureBox1);
					num = (int)((num2 * 675346370) ^ 0x44475E31);
					continue;
				case 6u:
					SearchReciever_Admin.smethod_16((Control)(object)BloodGroupTxt, new Size(146, 30));
					num = ((int)num2 * -1240564491) ^ -1693244261;
					continue;
				case 5u:
					num = (int)(num2 * 371790856) ^ -2008163219;
					continue;
				case 4u:
					num = (int)((num2 * 711051312) ^ 0x6D14D0B);
					continue;
				case 3u:
					SearchReciever_Admin.smethod_19(PictureBox1, bool_0: false);
					num = (int)(num2 * 1906490525) ^ -1649599594;
					continue;
				case 2u:
					SearchReciever_Admin.smethod_29((ButtonBase)(object)DeleteBtn, Color.MidnightBlue);
					num = (int)((num2 * 668552789) ^ 0x59ECD6A6);
					continue;
				case 1u:
					SearchReciever_Admin.smethod_14((Control)(object)IDTxt, new Point(117, 36));
					num = ((int)num2 * -959079445) ^ -1665361424;
					continue;
				case 0u:
					num = (int)(num2 * 375436122) ^ -120645243;
					continue;
				default:
					return;
				case 207u:
					break;
				case 180u:
					return;
				}
				break;
			}
		}
	}

	private void SearchDonor_Admin_Load(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 1364527956;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4DFDD1Bu) % 5u)
				{
				case 4u:
					HideItemsOnForm();
					num = (int)((num2 * 1946261717) ^ 0x2DD49652);
					continue;
				case 3u:
					num = (int)((num2 * 728500667) ^ 0x6B5A1B73);
					continue;
				case 1u:
					SearchReciever_Admin.smethod_59(myconnection, SearchReciever_Admin.smethod_58(MyProject.Forms.Form1.provider, MyProject.Forms.Form1.datafile));
					num = (int)((num2 * 810121656) ^ 0x3551BDDB);
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

	private bool HideItemsOnForm()
	{
		SearchReciever_Admin.smethod_43((Control)(object)SearchResultGrid, bool_0: false);
		bool result = default(bool);
		while (true)
		{
			int num = -507961714;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA9A9B578u) % 11u)
				{
				case 9u:
					num = ((int)num2 * -1590893285) ^ 0x246457FE;
					continue;
				case 8u:
					SearchReciever_Admin.smethod_43((Control)(object)ClearBtn, bool_0: false);
					num = ((int)num2 * -1278494846) ^ 0x7314BF94;
					continue;
				case 7u:
					num = ((int)num2 * -166824170) ^ -617741298;
					continue;
				case 6u:
					SearchReciever_Admin.smethod_43((Control)(object)RecieverInfoBox, bool_0: false);
					num = ((int)num2 * -1918340966) ^ 0x72BFC7EE;
					continue;
				case 5u:
					SearchReciever_Admin.smethod_43((Control)(object)DeleteBtn, bool_0: false);
					num = (int)(num2 * 508486932) ^ -1456016341;
					continue;
				case 4u:
					num = (int)((num2 * 781434244) ^ 0x31F8AC74);
					continue;
				case 2u:
					num = (int)(num2 * 92814012) ^ -365579890;
					continue;
				case 1u:
					result = true;
					num = (int)((num2 * 1375344477) ^ 0x144A5631);
					continue;
				case 0u:
					SearchReciever_Admin.smethod_43((Control)(object)UpdateBtn, bool_0: false);
					num = (int)((num2 * 1705774696) ^ 0x2937C4F2);
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

	private void SearchBtn_Click(object sender, EventArgs e)
	{
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected I4, but got Unknown
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Expected I4, but got Unknown
		//IL_02ac: Incompatible stack heights: 0 vs 1
		//IL_02c7: Incompatible stack heights: 0 vs 1
		//IL_02ce: Incompatible stack heights: 0 vs 1
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		string string_ = default(string);
		bool flag = default(bool);
		while (true)
		{
			int num = 1711633595;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x27BB16A2u) % 6u)
				{
				case 4u:
					HideItemsOnForm();
					SearchReciever_Admin.smethod_63();
					name_search = SearchReciever_Admin.smethod_61(SearchReciever_Admin.smethod_60(NameSTxt));
					mobile_search = SearchReciever_Admin.smethod_61(SearchReciever_Admin.smethod_60(MobileSTxt));
					num = 1945172770;
					continue;
				case 3u:
				{
					int num6;
					int num7;
					if (!MyProject.Forms.Form1.Name_Validation(SearchReciever_Admin.smethod_61(SearchReciever_Admin.smethod_60(NameSTxt))) | !MyProject.Forms.Form1.Mobile_Validator(SearchReciever_Admin.smethod_61(SearchReciever_Admin.smethod_60(MobileSTxt))))
					{
						num6 = 2127428329;
						num7 = 2127428329;
					}
					else
					{
						num6 = 745020490;
						num7 = 745020490;
					}
					num = num6 ^ ((int)num2 * -84417958);
					continue;
				}
				case 2u:
					string_ = SearchReciever_Admin.smethod_64(new string[5]
					{
						"Select * From [Recievers] Where [Name] Like '%",
						SearchReciever_Admin.smethod_61(SearchReciever_Admin.smethod_60(NameSTxt)),
						"%' And [Contact Number] Like '%",
						SearchReciever_Admin.smethod_60(MobileSTxt),
						"%';"
					});
					num = ((int)num2 * -1039777279) ^ 0x1FB6C27C;
					continue;
				case 5u:
					break;
				default:
				{
					DataTable dataTable = SearchReciever_Admin.smethod_65();
					SearchReciever_Admin.smethod_66(myconnection);
					try
					{
						OleDbDataAdapter dbDataAdapter_ = SearchReciever_Admin.smethod_67(string_, myconnection);
						SearchReciever_Admin.smethod_68((DbDataAdapter)(object)dbDataAdapter_, dataTable);
						SearchReciever_Admin.smethod_69(SearchResultGrid, (object)dataTable);
						while (true)
						{
							int num3 = 1372698790;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x27BB16A2u) % 10u)
								{
								case 9u:
									SearchReciever_Admin.smethod_62("No Result Found");
									num3 = ((int)num2 * -1729869231) ^ 0x4F4366DF;
									continue;
								case 8u:
									SearchReciever_Admin.smethod_43((Control)(object)SearchResultGrid, bool_0: true);
									num3 = 1551509735;
									continue;
								case 7u:
									num3 = ((int)num2 * -710745336) ^ 0x6F8B1F49;
									continue;
								case 6u:
									SearchReciever_Admin.smethod_71(myconnection);
									num3 = (int)(num2 * 16190756) ^ -521498967;
									continue;
								case 5u:
									flag = SearchReciever_Admin.smethod_70(SearchResultGrid) == 1;
									num3 = (int)((num2 * 1708144011) ^ 0x3860E5C5);
									continue;
								case 2u:
									num3 = ((int)num2 * -1129275157) ^ -1889508635;
									continue;
								case 0u:
								{
									int num4;
									int num5;
									if (!flag)
									{
										num4 = 1218038746;
										num5 = 1218038746;
									}
									else
									{
										num4 = 1074432291;
										num5 = 1074432291;
									}
									num3 = num4 ^ (int)(num2 * 1688421424);
									continue;
								}
								case 4u:
									break;
								case 1u:
									return;
								default:
									SearchReciever_Admin.smethod_71(myconnection);
									return;
								}
								break;
							}
						}
					}
					catch (Exception exception_)
					{
						SearchReciever_Admin.smethod_72(exception_);
						while (true)
						{
							_ = 936139983;
							while (true)
							{
								_003F val = /*Error near IL_027d: Stack underflow*/^ 0x27BB16A2;
								num2 = (uint)(int)val;
								switch (val % 4)
								{
								default:
									return;
								case 2:
									SearchReciever_Admin.smethod_73();
									_ = ((int)num2 * -540523122) ^ -1563244342;
									continue;
								case 1:
									SearchReciever_Admin.smethod_71(myconnection);
									_ = ((int)num2 * -1004264571) ^ -907673907;
									continue;
								case 3:
									break;
								case 0:
									return;
								}
								break;
							}
						}
					}
				}
				case 1u:
					SearchReciever_Admin.smethod_62("No Results Found");
					return;
				}
				break;
			}
		}
	}

	private void UpdateBtn_Click(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected I4, but got Unknown
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Expected I4, but got Unknown
		//IL_03b6: Incompatible stack heights: 0 vs 1
		//IL_03d1: Incompatible stack heights: 0 vs 1
		//IL_03e1: Incompatible stack heights: 0 vs 1
		//IL_03e8: Incompatible stack heights: 0 vs 1
		bool flag = default(bool);
		while (true)
		{
			int num = -132986650;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB56C15A3u) % 12u)
				{
				case 11u:
					SearchReciever_Admin.smethod_62("Invalid Credentitals");
					num = ((int)num2 * -1186117676) ^ 0x7D157663;
					continue;
				case 10u:
					num = -2135153121;
					continue;
				case 9u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = -1550479265;
						num7 = -1550479265;
					}
					else
					{
						num6 = -878651986;
						num7 = -878651986;
					}
					num = num6 ^ ((int)num2 * -848560425);
					continue;
				}
				case 8u:
				{
					OleDbCommand val = SearchReciever_Admin.smethod_63();
					num = (int)(num2 * 1700830802) ^ -1019573792;
					continue;
				}
				case 6u:
					flag = !(MyProject.Forms.Form1.Name_Validation(SearchReciever_Admin.smethod_61(SearchReciever_Admin.smethod_60(NameTxt))) & MyProject.Forms.Form1.Mobile_Validator(SearchReciever_Admin.smethod_60(MobileTxt)) & MyProject.Forms.Form1.age_validator(SearchReciever_Admin.smethod_60(DOBTxt)));
					num = (int)(num2 * 1777202100) ^ -1137991254;
					continue;
				case 5u:
					SearchReciever_Admin.smethod_62("Fields Cannot be empty");
					num = (int)(num2 * 1372226253) ^ -632931767;
					continue;
				case 2u:
					num = -354865019;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (!((SearchReciever_Admin.smethod_74(SearchReciever_Admin.smethod_60(NameTxt), "", bool_0: false) == 0) | (SearchReciever_Admin.smethod_74(SearchReciever_Admin.smethod_60(MobileTxt), "", bool_0: false) == 0) | (SearchReciever_Admin.smethod_74(SearchReciever_Admin.smethod_75(GenderTxt), "", bool_0: false) == 0) | (SearchReciever_Admin.smethod_74(SearchReciever_Admin.smethod_60(DOBTxt), "", bool_0: false) == 0) | (SearchReciever_Admin.smethod_74(SearchReciever_Admin.smethod_75(BloodGroupTxt), "", bool_0: false) == 0)))
					{
						num4 = 1814826615;
						num5 = 1814826615;
					}
					else
					{
						num4 = 2115530952;
						num5 = 2115530952;
					}
					num = num4 ^ ((int)num2 * -1841746318);
					continue;
				}
				case 0u:
					break;
				default:
				{
					string string_ = SearchReciever_Admin.smethod_64(new string[13]
					{
						"Update [Recievers] Set [Name] = '",
						SearchReciever_Admin.smethod_60(NameTxt),
						"', [Contact Number] = '",
						SearchReciever_Admin.smethod_60(MobileTxt),
						"', [Age] = ",
						SearchReciever_Admin.smethod_60(DOBTxt),
						", [Gender] = '",
						SearchReciever_Admin.smethod_75(GenderTxt),
						"', [Blood Group] = '",
						SearchReciever_Admin.smethod_75(BloodGroupTxt),
						"' Where [ID] = ",
						SearchReciever_Admin.smethod_60(IDTxt),
						";"
					});
					SearchReciever_Admin.smethod_66(myconnection);
					try
					{
						OleDbCommand val = SearchReciever_Admin.smethod_76(string_, myconnection);
						SearchReciever_Admin.smethod_77(val);
						while (true)
						{
							int num3 = -2057443350;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xB56C15A3u) % 8u)
								{
								case 7u:
									UpdateTable();
									num3 = ((int)num2 * -855217132) ^ 0x6459D86A;
									continue;
								case 5u:
									SearchReciever_Admin.smethod_62("Successfully Updated Details");
									num3 = ((int)num2 * -373405263) ^ 0x5F3BA652;
									continue;
								case 4u:
									ClearDonorInfoBox();
									num3 = (int)(num2 * 1519962578) ^ -1508078811;
									continue;
								case 3u:
									num3 = ((int)num2 * -1159228780) ^ 0x6C122B60;
									continue;
								case 1u:
									SearchReciever_Admin.smethod_78((Component)(object)val);
									num3 = ((int)num2 * -278030674) ^ -1567462443;
									continue;
								case 0u:
									SearchReciever_Admin.smethod_71(myconnection);
									num3 = (int)(num2 * 780049535) ^ -1067122120;
									continue;
								default:
									return;
								case 2u:
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
						SearchReciever_Admin.smethod_72(exception_);
						while (true)
						{
							_ = -173061570;
							while (true)
							{
								_003F val2 = /*Error near IL_0383: Stack underflow*/^ -1251207773;
								num2 = (uint)(int)val2;
								switch (val2 % 5)
								{
								default:
									return;
								case 2:
									SearchReciever_Admin.smethod_73();
									_ = (num2 * 880739795) ^ 0xA153F70Au;
									continue;
								case 1:
									SearchReciever_Admin.smethod_71(myconnection);
									_ = (num2 * 1846654072) ^ 0x2705284D;
									continue;
								case 0:
									_ = (num2 * 1536306532) ^ 0xAE1F7B93u;
									continue;
								case 4:
									break;
								case 3:
									return;
								}
								break;
							}
						}
					}
				}
				case 4u:
				case 7u:
					return;
				}
				break;
			}
		}
	}

	private void DeleteBtn_Click(object sender, EventArgs e)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected I4, but got Unknown
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected I4, but got Unknown
		//IL_0202: Incompatible stack heights: 0 vs 1
		//IL_0217: Incompatible stack heights: 0 vs 1
		//IL_0227: Incompatible stack heights: 0 vs 1
		//IL_022e: Incompatible stack heights: 0 vs 1
		bool flag = default(bool);
		string string_ = default(string);
		while (true)
		{
			int num = 450801619;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x210E444Au) % 10u)
				{
				case 9u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -597262151;
						num5 = -597262151;
					}
					else
					{
						num4 = -1267771084;
						num5 = -1267771084;
					}
					num = num4 ^ (int)(num2 * 819326317);
					continue;
				}
				case 8u:
					num = 1066727364;
					continue;
				case 7u:
					SearchReciever_Admin.smethod_62("Nothing To Delete");
					num = (int)(num2 * 746471160) ^ -89789794;
					continue;
				case 5u:
					flag = SearchReciever_Admin.smethod_74(SearchReciever_Admin.smethod_60(IDTxt), "", bool_0: false) == 0;
					num = (int)((num2 * 1689057882) ^ 0x1B4ADDCB);
					continue;
				case 4u:
					SearchReciever_Admin.smethod_66(myconnection);
					num = ((int)num2 * -2012089488) ^ -1491818835;
					continue;
				case 3u:
					string_ = SearchReciever_Admin.smethod_79("Delete From [Recievers] Where [ID] = ", SearchReciever_Admin.smethod_60(IDTxt), ";");
					num = (int)((num2 * 1257161204) ^ 0x73FB80);
					continue;
				case 0u:
				{
					OleDbCommand val = SearchReciever_Admin.smethod_63();
					num = (int)((num2 * 839866216) ^ 0x2E6E6A09);
					continue;
				}
				case 6u:
					break;
				default:
					try
					{
						OleDbCommand val = SearchReciever_Admin.smethod_76(string_, myconnection);
						SearchReciever_Admin.smethod_77(val);
						SearchReciever_Admin.smethod_78((Component)(object)val);
						while (true)
						{
							int num3 = 104492904;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x210E444Au) % 5u)
								{
								case 4u:
									ClearDonorInfoBox();
									SearchReciever_Admin.smethod_62("Successfully Deleted Entry");
									num3 = (int)(num2 * 1493038439) ^ -1761471425;
									continue;
								case 3u:
									SearchReciever_Admin.smethod_71(myconnection);
									num3 = (int)((num2 * 1867008729) ^ 0x57A5A481);
									continue;
								case 0u:
									UpdateTable();
									num3 = (int)(num2 * 942407397) ^ -487078551;
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
						SearchReciever_Admin.smethod_72(exception_);
						while (true)
						{
							_ = 1709529114;
							while (true)
							{
								_003F val2 = /*Error near IL_01c9: Stack underflow*/^ 0x210E444A;
								num2 = (uint)(int)val2;
								switch (val2 % 5)
								{
								default:
									return;
								case 3:
									SearchReciever_Admin.smethod_71(myconnection);
									_ = (num2 * 2104633013) ^ 0x51EE01D1;
									continue;
								case 2:
									SearchReciever_Admin.smethod_73();
									_ = ((int)num2 * -1306311162) ^ -466596901;
									continue;
								case 1:
									_ = ((int)num2 * -250416990) ^ 0x43EF0E68;
									continue;
								case 4:
									break;
								case 0:
									return;
								}
								break;
							}
						}
					}
				case 2u:
					return;
				}
				break;
			}
		}
	}

	private void SearchResultGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		try
		{
			SearchReciever_Admin.smethod_87(IDTxt, SearchReciever_Admin.smethod_86(SearchReciever_Admin.smethod_85(SearchReciever_Admin.smethod_84(SearchReciever_Admin.smethod_83(SearchReciever_Admin.smethod_82(SearchReciever_Admin.smethod_80(SearchResultGrid), SearchReciever_Admin.smethod_81(e))), 0))));
			while (true)
			{
				int num = -784487578;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCA7B03A9u) % 19u)
					{
					case 17u:
						SearchReciever_Admin.smethod_43((Control)(object)RecieverInfoBox, bool_0: true);
						SearchReciever_Admin.smethod_43((Control)(object)ClearBtn, bool_0: true);
						num = ((int)num2 * -490176951) ^ -923898348;
						continue;
					case 16u:
						num = ((int)num2 * -123494005) ^ -578293517;
						continue;
					case 15u:
						SearchReciever_Admin.smethod_87(DateRecievedTxt, SearchReciever_Admin.smethod_86(SearchReciever_Admin.smethod_85(SearchReciever_Admin.smethod_84(SearchReciever_Admin.smethod_83(SearchReciever_Admin.smethod_82(SearchReciever_Admin.smethod_80(SearchResultGrid), SearchReciever_Admin.smethod_81(e))), 7))));
						num = (int)((num2 * 1621693701) ^ 0x1C2EAB36);
						continue;
					case 14u:
						SearchReciever_Admin.smethod_88(BloodGroupTxt, SearchReciever_Admin.smethod_86(SearchReciever_Admin.smethod_85(SearchReciever_Admin.smethod_84(SearchReciever_Admin.smethod_83(SearchReciever_Admin.smethod_82(SearchReciever_Admin.smethod_80(SearchResultGrid), SearchReciever_Admin.smethod_81(e))), 4))));
						num = (int)((num2 * 1056186952) ^ 0x39B93A46);
						continue;
					case 13u:
						SearchReciever_Admin.smethod_88(GenderTxt, SearchReciever_Admin.smethod_86(SearchReciever_Admin.smethod_85(SearchReciever_Admin.smethod_84(SearchReciever_Admin.smethod_83(SearchReciever_Admin.smethod_82(SearchReciever_Admin.smethod_80(SearchResultGrid), SearchReciever_Admin.smethod_81(e))), 2))));
						num = ((int)num2 * -308841925) ^ 0x6691D42F;
						continue;
					case 12u:
						num = (int)(num2 * 1998614117) ^ -554970997;
						continue;
					case 11u:
						num = (int)((num2 * 1459458843) ^ 0x7F9CE5D7);
						continue;
					case 10u:
						SearchReciever_Admin.smethod_87(NameTxt, SearchReciever_Admin.smethod_86(SearchReciever_Admin.smethod_85(SearchReciever_Admin.smethod_84(SearchReciever_Admin.smethod_83(SearchReciever_Admin.smethod_82(SearchReciever_Admin.smethod_80(SearchResultGrid), SearchReciever_Admin.smethod_81(e))), 1))));
						num = (int)(num2 * 1892310172) ^ -38414431;
						continue;
					case 9u:
						num = ((int)num2 * -1102074444) ^ 0xEE53C16;
						continue;
					case 8u:
						SearchReciever_Admin.smethod_43((Control)(object)UpdateBtn, bool_0: true);
						num = ((int)num2 * -1808556209) ^ -835597998;
						continue;
					case 7u:
						num = ((int)num2 * -1445868421) ^ 0x1B0279D3;
						continue;
					case 6u:
						SearchReciever_Admin.smethod_87(MobileTxt, SearchReciever_Admin.smethod_86(SearchReciever_Admin.smethod_85(SearchReciever_Admin.smethod_84(SearchReciever_Admin.smethod_83(SearchReciever_Admin.smethod_82(SearchReciever_Admin.smethod_80(SearchResultGrid), SearchReciever_Admin.smethod_81(e))), 5))));
						num = ((int)num2 * -890394768) ^ 0x3348723E;
						continue;
					case 5u:
						num = (int)((num2 * 1632430886) ^ 0x348937DE);
						continue;
					case 4u:
						num = (int)(num2 * 2111532391) ^ -73443185;
						continue;
					case 2u:
						SearchReciever_Admin.smethod_87(QuantityTxt, SearchReciever_Admin.smethod_86(SearchReciever_Admin.smethod_85(SearchReciever_Admin.smethod_84(SearchReciever_Admin.smethod_83(SearchReciever_Admin.smethod_82(SearchReciever_Admin.smethod_80(SearchResultGrid), SearchReciever_Admin.smethod_81(e))), 6))));
						num = (int)((num2 * 675104446) ^ 0x26A4B16);
						continue;
					case 1u:
						SearchReciever_Admin.smethod_43((Control)(object)DeleteBtn, bool_0: true);
						num = ((int)num2 * -388723402) ^ 0x3BB42BD1;
						continue;
					case 0u:
						SearchReciever_Admin.smethod_87(DOBTxt, SearchReciever_Admin.smethod_86(SearchReciever_Admin.smethod_85(SearchReciever_Admin.smethod_84(SearchReciever_Admin.smethod_83(SearchReciever_Admin.smethod_82(SearchReciever_Admin.smethod_80(SearchResultGrid), SearchReciever_Admin.smethod_81(e))), 3))));
						num = (int)((num2 * 1674600153) ^ 0x4044F7D3);
						continue;
					default:
						return;
					case 18u:
						break;
					case 3u:
						return;
					}
					break;
				}
			}
		}
		catch (Exception exception_)
		{
			SearchReciever_Admin.smethod_72(exception_);
			SearchReciever_Admin.smethod_73();
		}
	}

	private void ClearBtn_Click(object sender, EventArgs e)
	{
		ClearDonorInfoBox();
	}

	private bool ClearDonorInfoBox()
	{
		SearchReciever_Admin.smethod_89((TextBoxBase)(object)IDTxt);
		bool result = default(bool);
		while (true)
		{
			int num = 1665722342;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7AED88B7u) % 13u)
				{
				case 12u:
					SearchReciever_Admin.smethod_89((TextBoxBase)(object)QuantityTxt);
					result = true;
					num = (int)(num2 * 2120319112) ^ -1783048440;
					continue;
				case 11u:
					SearchReciever_Admin.smethod_89((TextBoxBase)(object)DOBTxt);
					num = (int)((num2 * 1750810722) ^ 0x658D0BF0);
					continue;
				case 10u:
					SearchReciever_Admin.smethod_90(GenderTxt, -1);
					num = ((int)num2 * -142771002) ^ 0x789F7A37;
					continue;
				case 9u:
					SearchReciever_Admin.smethod_89((TextBoxBase)(object)NameTxt);
					num = ((int)num2 * -1211904299) ^ 0x6CA8FBCF;
					continue;
				case 8u:
					SearchReciever_Admin.smethod_89((TextBoxBase)(object)DateRecievedTxt);
					num = ((int)num2 * -1306088073) ^ -297075939;
					continue;
				case 6u:
					num = ((int)num2 * -129360135) ^ -1697769842;
					continue;
				case 5u:
					num = (int)(num2 * 1808869032) ^ -1233607534;
					continue;
				case 4u:
					SearchReciever_Admin.smethod_89((TextBoxBase)(object)MobileTxt);
					num = (int)(num2 * 729028655) ^ -1195718035;
					continue;
				case 3u:
					SearchReciever_Admin.smethod_90(BloodGroupTxt, -1);
					num = (int)((num2 * 1220009323) ^ 0x2A268003);
					continue;
				case 2u:
					num = (int)((num2 * 1267764897) ^ 0xFDAA60C);
					continue;
				case 1u:
					num = ((int)num2 * -1355246952) ^ 0x69145955;
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

	private bool UpdateTable()
	{
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected I4, but got Unknown
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected I4, but got Unknown
		//IL_01b3: Incompatible stack heights: 0 vs 1
		//IL_01ba: Incompatible stack heights: 0 vs 1
		SearchReciever_Admin.smethod_63();
		DataTable dataTable = default(DataTable);
		string string_ = default(string);
		while (true)
		{
			int num = -178624421;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x900F43F9u) % 5u)
				{
				case 3u:
					SearchReciever_Admin.smethod_66(myconnection);
					num = ((int)num2 * -382320009) ^ -100696823;
					continue;
				case 2u:
					dataTable = SearchReciever_Admin.smethod_65();
					num = (int)((num2 * 1849623476) ^ 0x263C0354);
					continue;
				case 1u:
					string_ = SearchReciever_Admin.smethod_64(new string[5] { "Select * From [Recievers] Where [Name] Like '%", name_search, "%' And [Contact Number] Like '%", mobile_search, "%';" });
					num = ((int)num2 * -1219998738) ^ -1277008435;
					continue;
				case 0u:
					break;
				default:
				{
					try
					{
						while (true)
						{
							IL_016a:
							int num3 = -798987827;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x900F43F9u) % 7u)
								{
								case 5u:
									SearchReciever_Admin.smethod_69(SearchResultGrid, (object)dataTable);
									num3 = (int)((num2 * 1729135233) ^ 0x54951FA);
									continue;
								case 4u:
									num3 = (int)((num2 * 524433106) ^ 0x6557781C);
									continue;
								case 3u:
									SearchReciever_Admin.smethod_71(myconnection);
									num3 = ((int)num2 * -1935700566) ^ -1472635395;
									continue;
								case 2u:
								{
									OleDbDataAdapter dbDataAdapter_ = SearchReciever_Admin.smethod_67(string_, myconnection);
									SearchReciever_Admin.smethod_68((DbDataAdapter)(object)dbDataAdapter_, dataTable);
									num3 = (int)((num2 * 1105542624) ^ 0x6BECCF51);
									continue;
								}
								case 1u:
									SearchReciever_Admin.smethod_43((Control)(object)SearchResultGrid, bool_0: true);
									num3 = (int)(num2 * 1441102730) ^ -1348345984;
									continue;
								default:
									goto end_IL_013c;
								case 6u:
									break;
								case 0u:
									goto end_IL_013c;
								}
								goto IL_016a;
								continue;
								end_IL_013c:
								break;
							}
							break;
						}
					}
					catch (Exception exception_)
					{
						SearchReciever_Admin.smethod_72(exception_);
						while (true)
						{
							IL_01b5:
							_ = -1019350346;
							while (true)
							{
								_003F val = /*Error near IL_0182: Stack underflow*/^ -1878047751;
								num2 = (uint)(int)val;
								switch (val % 3)
								{
								case 2:
									SearchReciever_Admin.smethod_71(myconnection);
									_ = (num2 * 504111538) ^ 0x41F698D0;
									continue;
								case 0:
									break;
								default:
									SearchReciever_Admin.smethod_73();
									goto end_IL_017c;
								}
								goto IL_01b5;
								continue;
								end_IL_017c:
								break;
							}
							break;
						}
					}
					bool result = true;
					while (true)
					{
						int num4 = -232253619;
						while (true)
						{
							switch ((num2 = (uint)num4 ^ 0x900F43F9u) % 3u)
							{
							case 2u:
								goto IL_01c7;
							case 0u:
								break;
							default:
								return result;
							}
							break;
							IL_01c7:
							num4 = ((int)num2 * -1180418635) ^ -1524846791;
						}
					}
				}
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

	static ComboBox smethod_9()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new ComboBox();
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

	static void smethod_38(ComboBox comboBox_0, ComboBoxStyle comboBoxStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		comboBox_0.set_DropDownStyle(comboBoxStyle_0);
	}

	static void smethod_39(ListControl listControl_0, bool bool_0)
	{
		listControl_0.set_FormattingEnabled(bool_0);
	}

	static ObjectCollection smethod_40(ComboBox comboBox_0)
	{
		return comboBox_0.get_Items();
	}

	static void smethod_41(ObjectCollection objectCollection_0, object[] object_0)
	{
		objectCollection_0.AddRange(object_0);
	}

	static void smethod_42(TextBoxBase textBoxBase_0, bool bool_0)
	{
		textBoxBase_0.set_ReadOnly(bool_0);
	}

	static void smethod_43(Control control_0, bool bool_0)
	{
		control_0.set_Visible(bool_0);
	}

	static void smethod_44(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_45(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_46(Control control_0, Color color_0)
	{
		control_0.set_BackColor(color_0);
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

	static void smethod_50(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.EndInit();
	}

	static void smethod_51(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_52(Control control_0)
	{
		control_0.PerformLayout();
	}

	static void smethod_53(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_54(Control control_0, EventHandler eventHandler_0)
	{
		control_0.remove_Click(eventHandler_0);
	}

	static void smethod_55(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_Click(eventHandler_0);
	}

	static void smethod_56(DataGridView dataGridView_0, DataGridViewCellMouseEventHandler dataGridViewCellMouseEventHandler_0)
	{
		dataGridView_0.remove_CellMouseClick(dataGridViewCellMouseEventHandler_0);
	}

	static void smethod_57(DataGridView dataGridView_0, DataGridViewCellMouseEventHandler dataGridViewCellMouseEventHandler_0)
	{
		dataGridView_0.add_CellMouseClick(dataGridViewCellMouseEventHandler_0);
	}

	static string smethod_58(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static void smethod_59(OleDbConnection oleDbConnection_0, string string_0)
	{
		oleDbConnection_0.set_ConnectionString(string_0);
	}

	static string smethod_60(TextBox textBox_0)
	{
		return textBox_0.get_Text();
	}

	static string smethod_61(string string_0)
	{
		return string_0.ToLower();
	}

	static DialogResult smethod_62(string string_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0);
	}

	static OleDbCommand smethod_63()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new OleDbCommand();
	}

	static string smethod_64(string[] string_0)
	{
		return string.Concat(string_0);
	}

	static DataTable smethod_65()
	{
		return new DataTable();
	}

	static void smethod_66(OleDbConnection oleDbConnection_0)
	{
		oleDbConnection_0.Open();
	}

	static OleDbDataAdapter smethod_67(string string_0, OleDbConnection oleDbConnection_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new OleDbDataAdapter(string_0, oleDbConnection_0);
	}

	static int smethod_68(DbDataAdapter dbDataAdapter_0, DataTable dataTable_0)
	{
		return dbDataAdapter_0.Fill(dataTable_0);
	}

	static void smethod_69(DataGridView dataGridView_0, object object_0)
	{
		dataGridView_0.set_DataSource(object_0);
	}

	static int smethod_70(DataGridView dataGridView_0)
	{
		return dataGridView_0.get_RowCount();
	}

	static void smethod_71(OleDbConnection oleDbConnection_0)
	{
		oleDbConnection_0.Close();
	}

	static void smethod_72(Exception exception_0)
	{
		ProjectData.SetProjectError(exception_0);
	}

	static void smethod_73()
	{
		ProjectData.ClearProjectError();
	}

	static int smethod_74(string string_0, string string_1, bool bool_0)
	{
		return Operators.CompareString(string_0, string_1, bool_0);
	}

	static string smethod_75(ComboBox comboBox_0)
	{
		return comboBox_0.get_Text();
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

	static string smethod_79(string string_0, string string_1, string string_2)
	{
		return string_0 + string_1 + string_2;
	}

	static DataGridViewRowCollection smethod_80(DataGridView dataGridView_0)
	{
		return dataGridView_0.get_Rows();
	}

	static int smethod_81(DataGridViewCellMouseEventArgs dataGridViewCellMouseEventArgs_0)
	{
		return dataGridViewCellMouseEventArgs_0.get_RowIndex();
	}

	static DataGridViewRow smethod_82(DataGridViewRowCollection dataGridViewRowCollection_0, int int_0)
	{
		return dataGridViewRowCollection_0.get_Item(int_0);
	}

	static DataGridViewCellCollection smethod_83(DataGridViewRow dataGridViewRow_0)
	{
		return dataGridViewRow_0.get_Cells();
	}

	static DataGridViewCell smethod_84(DataGridViewCellCollection dataGridViewCellCollection_0, int int_0)
	{
		return dataGridViewCellCollection_0.get_Item(int_0);
	}

	static object smethod_85(DataGridViewCell dataGridViewCell_0)
	{
		return dataGridViewCell_0.get_Value();
	}

	static string smethod_86(object object_0)
	{
		return Conversions.ToString(object_0);
	}

	static void smethod_87(TextBox textBox_0, string string_0)
	{
		textBox_0.set_Text(string_0);
	}

	static void smethod_88(ComboBox comboBox_0, string string_0)
	{
		comboBox_0.set_Text(string_0);
	}

	static void smethod_89(TextBoxBase textBoxBase_0)
	{
		textBoxBase_0.Clear();
	}

	static void smethod_90(ComboBox comboBox_0, int int_0)
	{
		comboBox_0.set_SelectedIndex(int_0);
	}
}
