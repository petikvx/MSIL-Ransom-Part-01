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
				int num = -1312401860;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x971293B6u) % 7u)
					{
					case 6u:
						SearchPatient_Admin.smethod_55((Control)(object)searchBtn, eventHandler_);
						num = (int)(num2 * 775763688) ^ -865577420;
						continue;
					case 4u:
						SearchPatient_Admin.smethod_56((Control)(object)searchBtn, eventHandler_);
						num = ((int)num2 * -1285579147) ^ 0x66893C0A;
						continue;
					case 2u:
						searchBtn = _SearchBtn;
						num = (int)((num2 * 50118997) ^ 0x5E76A4D1);
						continue;
					case 1u:
					{
						int num4;
						int num5;
						if (searchBtn == null)
						{
							num4 = -1081737691;
							num5 = -1081737691;
						}
						else
						{
							num4 = -1297281812;
							num5 = -1297281812;
						}
						num = num4 ^ ((int)num2 * -618194651);
						continue;
					}
					case 0u:
					{
						_SearchBtn = value;
						searchBtn = _SearchBtn;
						int num3;
						if (searchBtn == null)
						{
							num = -1294082059;
							num3 = -1294082059;
						}
						else
						{
							num = -806059627;
							num3 = -806059627;
						}
						continue;
					}
					default:
						return;
					case 5u:
						break;
					case 3u:
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
				int num = 1469756163;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x28D6F279u) % 7u)
					{
					case 6u:
					{
						searchResultGrid = _SearchResultGrid;
						int num5;
						int num6;
						if (searchResultGrid != null)
						{
							num5 = -1297174760;
							num6 = -1297174760;
						}
						else
						{
							num5 = -1552666696;
							num6 = -1552666696;
						}
						num = num5 ^ (int)(num2 * 2094041842);
						continue;
					}
					case 5u:
						SearchPatient_Admin.smethod_58(searchResultGrid, dataGridViewCellMouseEventHandler_);
						num = ((int)num2 * -224028235) ^ -195613267;
						continue;
					case 4u:
						SearchPatient_Admin.smethod_57(searchResultGrid, dataGridViewCellMouseEventHandler_);
						num = ((int)num2 * -727459680) ^ -1816023785;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (searchResultGrid == null)
						{
							num3 = -1307512833;
							num4 = -1307512833;
						}
						else
						{
							num3 = -97022949;
							num4 = -97022949;
						}
						num = num3 ^ (int)(num2 * 106407652);
						continue;
					}
					case 1u:
						_SearchResultGrid = value;
						num = 894200373;
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
				int num = -742560953;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9F55F0D0u) % 9u)
					{
					case 7u:
						_ClearBtn = value;
						num = -1446955431;
						continue;
					case 6u:
					{
						int num5;
						int num6;
						if (clearBtn != null)
						{
							num5 = 1035184912;
							num6 = 1035184912;
						}
						else
						{
							num5 = 715823017;
							num6 = 715823017;
						}
						num = num5 ^ (int)(num2 * 490489250);
						continue;
					}
					case 5u:
						clearBtn = _ClearBtn;
						num = ((int)num2 * -1374526056) ^ -644339962;
						continue;
					case 3u:
						clearBtn = _ClearBtn;
						num = (int)(num2 * 1159500315) ^ -1870453082;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (clearBtn == null)
						{
							num3 = 1624747742;
							num4 = 1624747742;
						}
						else
						{
							num3 = 256199096;
							num4 = 256199096;
						}
						num = num3 ^ ((int)num2 * -1167780423);
						continue;
					}
					case 1u:
						SearchPatient_Admin.smethod_55((Control)(object)clearBtn, eventHandler_);
						num = ((int)num2 * -1726196222) ^ -573311763;
						continue;
					case 0u:
						SearchPatient_Admin.smethod_56((Control)(object)clearBtn, eventHandler_);
						num = ((int)num2 * -20745733) ^ 0x76357674;
						continue;
					default:
						return;
					case 8u:
						break;
					case 4u:
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
				int num = -1975303414;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB44D935Bu) % 8u)
					{
					case 7u:
					{
						int num5;
						int num6;
						if (updateBtn != null)
						{
							num5 = -1800239239;
							num6 = -1800239239;
						}
						else
						{
							num5 = -2094596844;
							num6 = -2094596844;
						}
						num = num5 ^ (int)(num2 * 1072896756);
						continue;
					}
					case 6u:
						SearchPatient_Admin.smethod_55((Control)(object)updateBtn, eventHandler_);
						num = (int)(num2 * 1209018568) ^ -1815614488;
						continue;
					case 3u:
						_UpdateBtn = value;
						updateBtn = _UpdateBtn;
						num = -1811837877;
						continue;
					case 2u:
						SearchPatient_Admin.smethod_56((Control)(object)updateBtn, eventHandler_);
						num = (int)((num2 * 1762040109) ^ 0x73379E94);
						continue;
					case 1u:
						updateBtn = _UpdateBtn;
						num = (int)((num2 * 1039908274) ^ 0x3C8AF7F6);
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (updateBtn != null)
						{
							num3 = -1339825583;
							num4 = -1339825583;
						}
						else
						{
							num3 = -1030536554;
							num4 = -1030536554;
						}
						num = num3 ^ (int)(num2 * 1851850583);
						continue;
					}
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
			while (true)
			{
				int num = -1301263405;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9053DA54u) % 8u)
					{
					case 7u:
					{
						int num5;
						int num6;
						if (deleteBtn == null)
						{
							num5 = -2017432282;
							num6 = -2017432282;
						}
						else
						{
							num5 = -1931968472;
							num6 = -1931968472;
						}
						num = num5 ^ ((int)num2 * -22190048);
						continue;
					}
					case 4u:
						SearchPatient_Admin.smethod_55((Control)(object)deleteBtn, eventHandler_);
						num = ((int)num2 * -55378457) ^ 0x6E7BD302;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (deleteBtn == null)
						{
							num3 = 1191957637;
							num4 = 1191957637;
						}
						else
						{
							num3 = 1648119720;
							num4 = 1648119720;
						}
						num = num3 ^ ((int)num2 * -796929380);
						continue;
					}
					case 2u:
						_DeleteBtn = value;
						num = -1904067603;
						continue;
					case 1u:
						deleteBtn = _DeleteBtn;
						num = ((int)num2 * -50053268) ^ -1097405965;
						continue;
					case 0u:
						SearchPatient_Admin.smethod_56((Control)(object)deleteBtn, eventHandler_);
						num = ((int)num2 * -140949363) ^ -2019838055;
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
			int num = -1362567625;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD860FC7Eu) % 8u)
				{
				case 7u:
					num = (int)((num2 * 65207133) ^ 0x1ABE22CB);
					continue;
				case 5u:
					myconnection = SearchPatient_Admin.smethod_1();
					num = (int)(num2 * 1179094466) ^ -1484243096;
					continue;
				case 4u:
					InitializeComponent();
					num = ((int)num2 * -1387483979) ^ -536756115;
					continue;
				case 3u:
					SearchPatient_Admin.smethod_0((UserControl)(object)this, (EventHandler)SearchPatient_Admin_Load);
					num = (int)((num2 * 1094898446) ^ 0x21236924);
					continue;
				case 1u:
					num = ((int)num2 * -522763412) ^ 0x29DD55C1;
					continue;
				case 0u:
					num = ((int)num2 * -97970619) ^ -99925285;
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

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			bool flag = default(bool);
			while (true)
			{
				int num = 1527538264;
				while (true)
				{
					uint num2;
					int num5;
					switch ((num2 = (uint)num ^ 0x234BEDD6u) % 8u)
					{
					case 7u:
						num = ((int)num2 * -1131710049) ^ -1555808573;
						continue;
					case 6u:
						if (disposing)
						{
							num = (int)((num2 * 1565582025) ^ 0x50FAAC61);
							continue;
						}
						num5 = 0;
						goto IL_0029;
					case 4u:
						num = (int)((num2 * 883483022) ^ 0x65630ECB);
						continue;
					case 2u:
						SearchPatient_Admin.smethod_2((IDisposable)components);
						num = (int)((num2 * 576116351) ^ 0x16B94477);
						continue;
					case 1u:
						num5 = ((components != null) ? 1 : 0);
						goto IL_0029;
					case 0u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 1954610564;
							num4 = 1954610564;
						}
						else
						{
							num3 = 1679553267;
							num4 = 1679553267;
						}
						num = num3 ^ ((int)num2 * -505762648);
						continue;
					}
					default:
						return;
					case 3u:
						break;
					case 5u:
						return;
						IL_0029:
						flag = (byte)num5 != 0;
						num = 1063913030;
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
		PictureBox1 = SearchPatient_Admin.smethod_3();
		while (true)
		{
			int num = -769465028;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x999B8EA2u) % 258u)
				{
				case 257u:
					num = ((int)num2 * -446559434) ^ -1722784996;
					continue;
				case 256u:
					SearchPatient_Admin.smethod_23(Label14, "Name :");
					SearchPatient_Admin.smethod_14((Control)(object)AddressTxt, new Point(554, 128));
					SearchPatient_Admin.smethod_43(AddressTxt, bool_0: true);
					num = (int)((num2 * 1959819338) ^ 0x7F661CE7);
					continue;
				case 255u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_48((Control)(object)this), (Control)(object)PatientInfoBox);
					num = ((int)num2 * -1778983065) ^ -1458790725;
					continue;
				case 254u:
					SearchPatient_Admin.smethod_22((Control)(object)DeleteBtn, 17);
					num = ((int)num2 * -1699126855) ^ 0x2C7DC4FA;
					continue;
				case 253u:
					num = ((int)num2 * -2138965504) ^ 0x5A9320A;
					continue;
				case 252u:
					num = ((int)num2 * -840194816) ^ 0x31E31A4D;
					continue;
				case 251u:
					SearchPatient_Admin.smethod_15((Control)(object)NameTxt, "NameTxt");
					num = (int)((num2 * 83542701) ^ 0x3E9E26EC);
					continue;
				case 250u:
					SearchPatient_Admin.smethod_51((ISupportInitialize)SearchResultGrid);
					num = (int)((num2 * 1853944588) ^ 0xCBC3F1D);
					continue;
				case 249u:
					SearchPatient_Admin.smethod_15((Control)(object)MobileTxt, "MobileTxt");
					SearchPatient_Admin.smethod_16((Control)(object)MobileTxt, new Size(258, 28));
					num = ((int)num2 * -1403082344) ^ -1327287723;
					continue;
				case 248u:
					num = ((int)num2 * -1671362027) ^ -1203467686;
					continue;
				case 247u:
					SearchPatient_Admin.smethod_19(PictureBox1, bool_0: false);
					num = ((int)num2 * -494420611) ^ -1103555197;
					continue;
				case 246u:
					SearchPatient_Admin.smethod_30((Control)(object)UpdateBtn, Color.White);
					SearchPatient_Admin.smethod_14((Control)(object)UpdateBtn, new Point(681, 747));
					num = (int)(num2 * 493187468) ^ -2049758291;
					continue;
				case 245u:
					SearchPatient_Admin.smethod_12((Control)(object)this);
					num = (int)((num2 * 1129154306) ^ 0xC5AE6CB);
					continue;
				case 244u:
					SearchPatient_Admin.smethod_53((Control)(object)PatientInfoBox);
					num = (int)((num2 * 1943248747) ^ 0x26D0A3DB);
					continue;
				case 243u:
					num = (int)((num2 * 260336177) ^ 0x3808F59E);
					continue;
				case 242u:
					num = (int)(num2 * 147758387) ^ -701539893;
					continue;
				case 241u:
					SearchPatient_Admin.smethod_15((Control)(object)Label1, "Label1");
					SearchPatient_Admin.smethod_16((Control)(object)Label1, new Size(330, 47));
					num = (int)((num2 * 1758755726) ^ 0x47A81981);
					continue;
				case 240u:
					PatientInfoBox = SearchPatient_Admin.smethod_5();
					num = (int)((num2 * 254328765) ^ 0x4C28B605);
					continue;
				case 239u:
					num = ((int)num2 * -57773591) ^ -1703359862;
					continue;
				case 238u:
					SearchPatient_Admin.smethod_52((Control)(object)GroupBox1, bool_0: false);
					num = (int)(num2 * 196859355) ^ -2037613465;
					continue;
				case 237u:
					UpdateBtn = SearchPatient_Admin.smethod_6();
					num = (int)((num2 * 159280273) ^ 0x6602B457);
					continue;
				case 236u:
					SearchPatient_Admin.smethod_14((Control)(object)Label4, new Point(13, 43));
					num = ((int)num2 * -1743989908) ^ -1729127094;
					continue;
				case 235u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_25((Control)(object)PatientInfoBox), (Control)(object)AddressTxt);
					num = ((int)num2 * -742742199) ^ 0x6C0A4D0;
					continue;
				case 234u:
					num = (int)((num2 * 521886428) ^ 0x2575D27D);
					continue;
				case 233u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_25((Control)(object)GroupBox1), (Control)(object)NameSTxt);
					num = ((int)num2 * -212502357) ^ 0x7F01C791;
					continue;
				case 232u:
					num = (int)((num2 * 93115978) ^ 0x1D278B37);
					continue;
				case 231u:
					SearchPatient_Admin.smethod_29((ButtonBase)(object)SearchBtn, Color.MidnightBlue);
					SearchPatient_Admin.smethod_21((Control)(object)SearchBtn, SearchPatient_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1057536829) ^ 0x11F73865;
					continue;
				case 230u:
					num = (int)(num2 * 17289751) ^ -918622581;
					continue;
				case 229u:
					SearchPatient_Admin.smethod_21((Control)(object)Label7, SearchPatient_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 427951209) ^ -314484385;
					continue;
				case 228u:
					num = ((int)num2 * -1565070703) ^ -1559675361;
					continue;
				case 227u:
					SearchPatient_Admin.smethod_16((Control)(object)DeleteBtn, new Size(97, 37));
					num = (int)(num2 * 1477038097) ^ -2024579981;
					continue;
				case 226u:
					SearchPatient_Admin.smethod_21((Control)(object)Label2, SearchPatient_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -217663592) ^ -1826122685;
					continue;
				case 225u:
					SearchPatient_Admin.smethod_46((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 923995122) ^ -1789460881;
					continue;
				case 224u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_25((Control)(object)PatientInfoBox), (Control)(object)Label14);
					num = (int)(num2 * 304909402) ^ -1834421051;
					continue;
				case 223u:
					SearchPatient_Admin.smethod_14((Control)(object)PictureBox1, new Point(256, 19));
					num = (int)((num2 * 1600903903) ^ 0x638B008A);
					continue;
				case 222u:
					SearchPatient_Admin.smethod_21((Control)(object)GroupBox1, SearchPatient_Admin.smethod_20("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1645224770) ^ -1527053541;
					continue;
				case 221u:
					SearchPatient_Admin.smethod_23(Label4, "PID :");
					num = ((int)num2 * -384754581) ^ 0x7641F2FB;
					continue;
				case 220u:
					SearchPatient_Admin.smethod_16((Control)(object)Label6, new Size(84, 26));
					num = (int)((num2 * 477326376) ^ 0x2C285CB7);
					continue;
				case 219u:
					num = (int)((num2 * 1698844707) ^ 0x163294F1);
					continue;
				case 218u:
					num = (int)(num2 * 1734765345) ^ -905351635;
					continue;
				case 217u:
					GenderTxt = SearchPatient_Admin.smethod_7();
					PIDTxt = SearchPatient_Admin.smethod_7();
					num = (int)(num2 * 1635715817) ^ -1272780033;
					continue;
				case 216u:
					SearchPatient_Admin.smethod_10((ISupportInitialize)SearchResultGrid);
					num = (int)((num2 * 705243528) ^ 0x81F91FD);
					continue;
				case 215u:
					num = (int)(num2 * 102675488) ^ -877228873;
					continue;
				case 214u:
					num = ((int)num2 * -1123580689) ^ 0x56F0B370;
					continue;
				case 213u:
					SearchPatient_Admin.smethod_16((Control)(object)Label10, new Size(76, 28));
					SearchPatient_Admin.smethod_22((Control)(object)Label10, 10);
					num = ((int)num2 * -1158407234) ^ 0x417FC696;
					continue;
				case 212u:
					SearchPatient_Admin.smethod_21((Control)(object)Label1, SearchPatient_Admin.smethod_20("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1948038989) ^ 0x70119F13;
					continue;
				case 211u:
					num = ((int)num2 * -385821191) ^ 0x889A83B;
					continue;
				case 210u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_25((Control)(object)PatientInfoBox), (Control)(object)Label10);
					num = (int)(num2 * 527614059) ^ -712732982;
					continue;
				case 209u:
					SearchPatient_Admin.smethod_16((Control)(object)MobileSTxt, new Size(237, 28));
					SearchPatient_Admin.smethod_22((Control)(object)MobileSTxt, 2);
					num = ((int)num2 * -1188982461) ^ -1890150613;
					continue;
				case 208u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_25((Control)(object)GroupBox1), (Control)(object)SearchBtn);
					num = ((int)num2 * -44458298) ^ -1713225013;
					continue;
				case 207u:
					num = ((int)num2 * -2092374317) ^ -1738205749;
					continue;
				case 206u:
					num = ((int)num2 * -2101590525) ^ -547482646;
					continue;
				case 205u:
					SearchPatient_Admin.smethod_22((Control)(object)AddressTxt, 7);
					num = ((int)num2 * -1213182557) ^ -1742863275;
					continue;
				case 204u:
					SearchPatient_Admin.smethod_44((TextBoxBase)(object)PIDTxt, bool_0: true);
					num = ((int)num2 * -285922217) ^ -220344550;
					continue;
				case 203u:
					num = ((int)num2 * -1566358445) ^ 0x4A7BB579;
					continue;
				case 202u:
					SearchPatient_Admin.smethod_16((Control)(object)SearchBtn, new Size(133, 37));
					SearchPatient_Admin.smethod_22((Control)(object)SearchBtn, 4);
					SearchPatient_Admin.smethod_31((ButtonBase)(object)SearchBtn, "Search");
					num = ((int)num2 * -828033222) ^ -1107456479;
					continue;
				case 201u:
					num = ((int)num2 * -1463077819) ^ 0x7617EA33;
					continue;
				case 200u:
					num = ((int)num2 * -580218684) ^ 0x10CFD387;
					continue;
				case 199u:
					num = ((int)num2 * -17680856) ^ 0x38ACE4AD;
					continue;
				case 198u:
					num = ((int)num2 * -1641741204) ^ 0x169C3201;
					continue;
				case 197u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_48((Control)(object)this), (Control)(object)UpdateBtn);
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_48((Control)(object)this), (Control)(object)ClearBtn);
					num = (int)((num2 * 1219376878) ^ 0x521971C5);
					continue;
				case 196u:
					SearchPatient_Admin.smethod_38((Control)(object)ClearBtn, bool_0: false);
					SearchPatient_Admin.smethod_29((ButtonBase)(object)UpdateBtn, Color.MidnightBlue);
					num = ((int)num2 * -313755144) ^ 0x3C634592;
					continue;
				case 195u:
					num = ((int)num2 * -1539685820) ^ 0x54151296;
					continue;
				case 194u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_25((Control)(object)PatientInfoBox), (Control)(object)PIDTxt);
					num = (int)(num2 * 1459317294) ^ -859482305;
					continue;
				case 193u:
					SearchPatient_Admin.smethod_11((Control)(object)GroupBox1);
					num = (int)(num2 * 2059386354) ^ -1383765070;
					continue;
				case 192u:
					SearchPatient_Admin.smethod_16((Control)(object)PIDTxt, new Size(116, 28));
					SearchPatient_Admin.smethod_22((Control)(object)PIDTxt, 4);
					num = ((int)num2 * -592420125) ^ 0x60BCD922;
					continue;
				case 191u:
					SearchPatient_Admin.smethod_15((Control)(object)AddressTxt, "AddressTxt");
					num = ((int)num2 * -1812985441) ^ -420540912;
					continue;
				case 189u:
					SearchPatient_Admin.smethod_16((Control)(object)GenderTxt, new Size(166, 28));
					SearchPatient_Admin.smethod_22((Control)(object)GenderTxt, 6);
					num = (int)((num2 * 525807314) ^ 0x203B4F32);
					continue;
				case 188u:
					SearchPatient_Admin.smethod_42(DOBTxt, new DateTime(2019, 2, 11, 0, 0, 0, 0));
					num = (int)(num2 * 1064938268) ^ -458521290;
					continue;
				case 187u:
					SearchPatient_Admin.smethod_49((Control)(object)this, "SearchPatient_Admin");
					SearchPatient_Admin.smethod_50((Control)(object)this, new Size(977, 804));
					SearchPatient_Admin.smethod_51((ISupportInitialize)PictureBox1);
					num = ((int)num2 * -1031898080) ^ -578992520;
					continue;
				case 186u:
					SearchPatient_Admin.smethod_14((Control)(object)PIDTxt, new Point(124, 43));
					num = (int)(num2 * 1560308050) ^ -1444131043;
					continue;
				case 185u:
					num = ((int)num2 * -801009862) ^ -1526218283;
					continue;
				case 184u:
					SearchPatient_Admin.smethod_32((ButtonBase)(object)ClearBtn, bool_0: false);
					num = (int)((num2 * 1174006460) ^ 0x4DF9984C);
					continue;
				case 183u:
					SearchPatient_Admin.smethod_16((Control)(object)Label14, new Size(80, 25));
					SearchPatient_Admin.smethod_22((Control)(object)Label14, 8);
					num = (int)((num2 * 859126924) ^ 0x77E7F762);
					continue;
				case 182u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_48((Control)(object)this), (Control)(object)SearchResultGrid);
					num = (int)((num2 * 1922972219) ^ 0x1B4FD7A1);
					continue;
				case 181u:
					num = (int)((num2 * 1533875616) ^ 0x34636A9D);
					continue;
				case 180u:
					SearchPatient_Admin.smethod_38((Control)(object)SearchResultGrid, bool_0: false);
					num = (int)(num2 * 135245455) ^ -71617332;
					continue;
				case 179u:
					SearchPatient_Admin.smethod_14((Control)(object)Label1, new Point(392, 63));
					num = ((int)num2 * -975403856) ^ 0x3BD5B221;
					continue;
				case 178u:
					SearchPatient_Admin.smethod_21((Control)(object)DeleteBtn, SearchPatient_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					SearchPatient_Admin.smethod_30((Control)(object)DeleteBtn, Color.White);
					num = (int)((num2 * 252141269) ^ 0xB3EFA4F);
					continue;
				case 177u:
					SearchPatient_Admin.smethod_16((Control)(object)GroupBox1, new Size(623, 128));
					num = ((int)num2 * -45527955) ^ 0x1250407A;
					continue;
				case 176u:
					SearchPatient_Admin.smethod_28(GroupBox1, "Search Patient");
					num = ((int)num2 * -504125981) ^ -1764634601;
					continue;
				case 175u:
					SearchPatient_Admin.smethod_16((Control)(object)Label5, new Size(68, 26));
					num = ((int)num2 * -1970924639) ^ 0x6FFF5F2F;
					continue;
				case 174u:
					SearchPatient_Admin.smethod_23(Label10, "Mobile :");
					num = ((int)num2 * -632628003) ^ -354992448;
					continue;
				case 172u:
					SearchPatient_Admin.smethod_15((Control)(object)Label4, "Label4");
					num = (int)(num2 * 529712784) ^ -328926219;
					continue;
				case 171u:
					Label3 = SearchPatient_Admin.smethod_4();
					num = (int)(num2 * 588074004) ^ -530845255;
					continue;
				case 170u:
					SearchPatient_Admin.smethod_14((Control)(object)GenderTxt, new Point(124, 178));
					SearchPatient_Admin.smethod_15((Control)(object)GenderTxt, "GenderTxt");
					num = (int)((num2 * 590483690) ^ 0x13DADD23);
					continue;
				case 169u:
					SearchPatient_Admin.smethod_22((Control)(object)Label5, 1);
					num = (int)(num2 * 1777244662) ^ -560220846;
					continue;
				case 168u:
					SearchPatient_Admin.smethod_22((Control)(object)Label4, 0);
					num = (int)((num2 * 1384659672) ^ 0x2C59CDFE);
					continue;
				case 167u:
					num = (int)((num2 * 1500348887) ^ 0x3680D0E0);
					continue;
				case 166u:
					SearchPatient_Admin.smethod_14((Control)(object)Label5, new Point(13, 134));
					num = ((int)num2 * -1492759818) ^ 0xB5F05AA;
					continue;
				case 165u:
					SearchPatient_Admin.smethod_47((Control)(object)this, Color.White);
					num = (int)((num2 * 119003886) ^ 0x3E175E45);
					continue;
				case 164u:
					SearchPatient_Admin.smethod_22((Control)(object)GroupBox1, 11);
					num = (int)((num2 * 1617255133) ^ 0x4398AB95);
					continue;
				case 163u:
					SearchBtn = SearchPatient_Admin.smethod_6();
					num = ((int)num2 * -1056782462) ^ -623398941;
					continue;
				case 162u:
					num = (int)(num2 * 456855396) ^ -873699172;
					continue;
				case 161u:
					SearchPatient_Admin.smethod_53((Control)(object)GroupBox1);
					num = ((int)num2 * -1397077397) ^ -1945524580;
					continue;
				case 160u:
					SearchPatient_Admin.smethod_23(Label5, "DOB :");
					num = ((int)num2 * -622411351) ^ -1580898908;
					continue;
				case 159u:
					SearchPatient_Admin.smethod_29((ButtonBase)(object)DeleteBtn, Color.MidnightBlue);
					num = (int)((num2 * 287972211) ^ 0x6E74F45);
					continue;
				case 158u:
					num = (int)((num2 * 1450373479) ^ 0x34C83A12);
					continue;
				case 157u:
					SearchPatient_Admin.smethod_22((Control)(object)NameTxt, 9);
					num = ((int)num2 * -255219508) ^ 0x544A02CA;
					continue;
				case 156u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_25((Control)(object)PatientInfoBox), (Control)(object)GenderTxt);
					num = (int)(num2 * 1582695421) ^ -1259276092;
					continue;
				case 155u:
					num = ((int)num2 * -214010884) ^ 0x3F35D02;
					continue;
				case 154u:
					num = ((int)num2 * -1866294090) ^ 0x21B9BE16;
					continue;
				case 153u:
					num = (int)((num2 * 267942604) ^ 0x1F561C97);
					continue;
				case 152u:
					SearchPatient_Admin.smethod_27(GroupBox1, bool_0: false);
					num = (int)((num2 * 1087336046) ^ 0x3A1E5625);
					continue;
				case 151u:
					SearchPatient_Admin.smethod_22((Control)(object)Label6, 2);
					SearchPatient_Admin.smethod_23(Label6, "Gender : ");
					num = ((int)num2 * -1499016026) ^ 0x5830BE2A;
					continue;
				case 150u:
					num = (int)((num2 * 1413412280) ^ 0x7C761010);
					continue;
				case 149u:
					SearchPatient_Admin.smethod_16((Control)(object)NameTxt, new Size(315, 28));
					num = ((int)num2 * -1393886743) ^ -363397096;
					continue;
				case 148u:
					num = ((int)num2 * -1439211958) ^ 0x20F679C8;
					continue;
				case 147u:
					SearchPatient_Admin.smethod_14((Control)(object)DeleteBtn, new Point(815, 747));
					num = (int)((num2 * 1450894241) ^ 0x7D97D663);
					continue;
				case 146u:
					num = (int)(num2 * 2042322472) ^ -990582526;
					continue;
				case 145u:
					SearchPatient_Admin.smethod_15((Control)(object)SearchResultGrid, "SearchResultGrid");
					num = (int)(num2 * 783152207) ^ -973838770;
					continue;
				case 144u:
					SearchPatient_Admin.smethod_14((Control)(object)Label7, new Point(452, 132));
					SearchPatient_Admin.smethod_15((Control)(object)Label7, "Label7");
					num = (int)((num2 * 1408865159) ^ 0x3AABD707);
					continue;
				case 143u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_25((Control)(object)PatientInfoBox), (Control)(object)MobileTxt);
					num = (int)((num2 * 1557740307) ^ 0x4A1C39B5);
					continue;
				case 142u:
					SearchPatient_Admin.smethod_14((Control)(object)NameSTxt, new Point(120, 44));
					num = (int)((num2 * 778772945) ^ 0x68C0BBB1);
					continue;
				case 141u:
					num = ((int)num2 * -227903331) ^ -2078152090;
					continue;
				case 140u:
					num = ((int)num2 * -11275680) ^ -1799444934;
					continue;
				case 139u:
					SearchPatient_Admin.smethod_11((Control)(object)PatientInfoBox);
					num = (int)(num2 * 1838727631) ^ -325661514;
					continue;
				case 138u:
					SearchPatient_Admin.smethod_22((Control)(object)UpdateBtn, 16);
					num = ((int)num2 * -86419606) ^ -765978508;
					continue;
				case 137u:
					SearchPatient_Admin.smethod_37(SearchPatient_Admin.smethod_36(SearchResultGrid), 24);
					SearchPatient_Admin.smethod_16((Control)(object)SearchResultGrid, new Size(853, 169));
					num = ((int)num2 * -409846706) ^ 0x28629236;
					continue;
				case 136u:
					SearchPatient_Admin.smethod_21((Control)(object)Label5, SearchPatient_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1733318226) ^ -322411604;
					continue;
				case 135u:
					SearchPatient_Admin.smethod_30((Control)(object)SearchBtn, Color.White);
					SearchPatient_Admin.smethod_14((Control)(object)SearchBtn, new Point(468, 82));
					num = (int)((num2 * 1767794940) ^ 0x363D4ACA);
					continue;
				case 134u:
					SearchResultGrid = SearchPatient_Admin.smethod_8();
					num = (int)((num2 * 1615653117) ^ 0x4E9005B4);
					continue;
				case 133u:
					MobileSTxt = SearchPatient_Admin.smethod_7();
					num = ((int)num2 * -1674555103) ^ 0x6C033D33;
					continue;
				case 132u:
					num = ((int)num2 * -472805217) ^ -636684243;
					continue;
				case 131u:
					SearchPatient_Admin.smethod_22((Control)(object)ClearBtn, 15);
					SearchPatient_Admin.smethod_31((ButtonBase)(object)ClearBtn, "Clear");
					num = ((int)num2 * -1896592823) ^ -746288552;
					continue;
				case 130u:
					SearchPatient_Admin.smethod_14((Control)(object)NameTxt, new Point(124, 89));
					num = (int)((num2 * 740570447) ^ 0x500631EF);
					continue;
				case 129u:
					SearchPatient_Admin.smethod_23(Label3, "Mobile : ");
					num = (int)((num2 * 1318228340) ^ 0x3B865CE2);
					continue;
				case 128u:
					SearchPatient_Admin.smethod_21((Control)(object)Label14, SearchPatient_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					SearchPatient_Admin.smethod_14((Control)(object)Label14, new Point(13, 89));
					SearchPatient_Admin.smethod_15((Control)(object)Label14, "Label14");
					num = ((int)num2 * -1869748503) ^ -710863857;
					continue;
				case 127u:
					SearchPatient_Admin.smethod_22((Control)(object)Label1, 10);
					num = ((int)num2 * -913409379) ^ 0x56D301B2;
					continue;
				case 126u:
					SearchPatient_Admin.smethod_14((Control)(object)MobileTxt, new Point(554, 83));
					num = (int)(num2 * 1221552486) ^ -782086465;
					continue;
				case 125u:
					SearchPatient_Admin.smethod_15((Control)(object)PictureBox1, "PictureBox1");
					num = ((int)num2 * -468264650) ^ -1354100917;
					continue;
				case 124u:
					SearchPatient_Admin.smethod_22((Control)(object)Label7, 3);
					num = ((int)num2 * -894732985) ^ 0x1EB06F83;
					continue;
				case 123u:
					SearchPatient_Admin.smethod_14((Control)(object)MobileSTxt, new Point(120, 86));
					num = ((int)num2 * -683866832) ^ 0x79024B38;
					continue;
				case 122u:
					num = ((int)num2 * -694512610) ^ -1058014031;
					continue;
				case 121u:
					SearchPatient_Admin.smethod_22((Control)(object)SearchResultGrid, 12);
					num = ((int)num2 * -563562529) ^ 0x20B33FB5;
					continue;
				case 120u:
					num = (int)((num2 * 20153430) ^ 0x54F7BFF5);
					continue;
				case 119u:
					num = (int)((num2 * 1093237382) ^ 0x528F6EEC);
					continue;
				case 118u:
					num = ((int)num2 * -1416920273) ^ 0x1796FB03;
					continue;
				case 117u:
					SearchPatient_Admin.smethod_15((Control)(object)Label10, "Label10");
					num = (int)((num2 * 1358653195) ^ 0x56997D50);
					continue;
				case 116u:
					Label7 = SearchPatient_Admin.smethod_4();
					num = ((int)num2 * -1533985242) ^ -1770046514;
					continue;
				case 115u:
					num = (int)((num2 * 1066353365) ^ 0x180926B6);
					continue;
				case 114u:
					num = ((int)num2 * -922211952) ^ -1552653408;
					continue;
				case 113u:
					SearchPatient_Admin.smethod_54((Control)(object)this, bool_0: false);
					num = (int)((num2 * 704246152) ^ 0x40524B4F);
					continue;
				case 112u:
					SearchPatient_Admin.smethod_31((ButtonBase)(object)DeleteBtn, "Delete");
					num = ((int)num2 * -1667442659) ^ -559221200;
					continue;
				case 111u:
					AddressTxt = SearchPatient_Admin.smethod_7();
					num = ((int)num2 * -1340445983) ^ 0x777590E6;
					continue;
				case 110u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_25((Control)(object)PatientInfoBox), (Control)(object)DOBTxt);
					num = ((int)num2 * -354920623) ^ 0x4CA25C74;
					continue;
				case 109u:
					SearchPatient_Admin.smethod_15((Control)(object)UpdateBtn, "UpdateBtn");
					SearchPatient_Admin.smethod_16((Control)(object)UpdateBtn, new Size(97, 37));
					num = ((int)num2 * -447453194) ^ 0x4E876D9B;
					continue;
				case 108u:
					SearchPatient_Admin.smethod_21((Control)(object)PatientInfoBox, SearchPatient_Admin.smethod_20("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					SearchPatient_Admin.smethod_14((Control)(object)PatientInfoBox, new Point(59, 486));
					num = (int)(num2 * 1521262106) ^ -937602502;
					continue;
				case 107u:
					SearchPatient_Admin.smethod_21((Control)(object)UpdateBtn, SearchPatient_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1072222025) ^ 0x51EF8A83;
					continue;
				case 106u:
					SearchPatient_Admin.smethod_23(Label2, "Name : ");
					num = ((int)num2 * -1037857439) ^ 0x7BCD5441;
					continue;
				case 105u:
					num = ((int)num2 * -1234044751) ^ 0x4C9C4E77;
					continue;
				case 104u:
					Label6 = SearchPatient_Admin.smethod_4();
					Label5 = SearchPatient_Admin.smethod_4();
					num = (int)(num2 * 1998730285) ^ -541566619;
					continue;
				case 103u:
					SearchPatient_Admin.smethod_16((Control)(object)Label3, new Size(77, 28));
					SearchPatient_Admin.smethod_22((Control)(object)Label3, 3);
					num = ((int)num2 * -1518318649) ^ -894321448;
					continue;
				case 102u:
					SearchPatient_Admin.smethod_16((Control)(object)PatientInfoBox, new Size(860, 231));
					SearchPatient_Admin.smethod_22((Control)(object)PatientInfoBox, 13);
					SearchPatient_Admin.smethod_27(PatientInfoBox, bool_0: false);
					num = (int)((num2 * 65504901) ^ 0x8F1CE7F);
					continue;
				case 101u:
					num = ((int)num2 * -934025904) ^ -410419331;
					continue;
				case 100u:
					SearchPatient_Admin.smethod_22((Control)(object)NameSTxt, 1);
					num = ((int)num2 * -1754553062) ^ 0x3A7937C3;
					continue;
				case 99u:
					SearchPatient_Admin.smethod_16((Control)(object)NameSTxt, new Size(237, 28));
					num = (int)((num2 * 2018956143) ^ 0x2AEFAAD2);
					continue;
				case 98u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_25((Control)(object)GroupBox1), (Control)(object)Label2);
					num = ((int)num2 * -1804023387) ^ -230394468;
					continue;
				case 97u:
					Label4 = SearchPatient_Admin.smethod_4();
					ClearBtn = SearchPatient_Admin.smethod_6();
					num = (int)(num2 * 134795069) ^ -1023845124;
					continue;
				case 96u:
					SearchPatient_Admin.smethod_10((ISupportInitialize)PictureBox1);
					num = (int)(num2 * 995418985) ^ -1149386736;
					continue;
				case 95u:
					SearchPatient_Admin.smethod_14((Control)(object)Label6, new Point(13, 180));
					num = ((int)num2 * -1319496391) ^ 0x1F31FF07;
					continue;
				case 94u:
					SearchPatient_Admin.smethod_15((Control)(object)PatientInfoBox, "PatientInfoBox");
					num = ((int)num2 * -692376337) ^ 0x532D3404;
					continue;
				case 93u:
					num = ((int)num2 * -1441718842) ^ -1600639034;
					continue;
				case 92u:
					NameSTxt = SearchPatient_Admin.smethod_7();
					Label2 = SearchPatient_Admin.smethod_4();
					num = ((int)num2 * -473406818) ^ 0x7D79E3D4;
					continue;
				case 91u:
					SearchPatient_Admin.smethod_23(Label7, "Address : ");
					num = (int)((num2 * 923631462) ^ 0x425A7CA5);
					continue;
				case 90u:
					SearchPatient_Admin.smethod_15((Control)(object)DOBTxt, "DOBTxt");
					SearchPatient_Admin.smethod_16((Control)(object)DOBTxt, new Size(166, 28));
					num = ((int)num2 * -621633191) ^ -1151436114;
					continue;
				case 89u:
					SearchPatient_Admin.smethod_35(SearchResultGrid, bool_0: true);
					num = ((int)num2 * -661099547) ^ -388012975;
					continue;
				case 88u:
					num = (int)((num2 * 1541017325) ^ 0x52621A0A);
					continue;
				case 87u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_48((Control)(object)this), (Control)(object)PictureBox1);
					num = (int)(num2 * 1683612909) ^ -391717290;
					continue;
				case 86u:
					num = (int)((num2 * 1718811049) ^ 0x1D191C9);
					continue;
				case 85u:
					num = ((int)num2 * -65903556) ^ -743776627;
					continue;
				case 84u:
					Label1 = SearchPatient_Admin.smethod_4();
					num = (int)((num2 * 2075642009) ^ 0x269A9232);
					continue;
				case 83u:
					num = ((int)num2 * -1909160467) ^ 0x5DB5AC6A;
					continue;
				case 82u:
					num = (int)(num2 * 1667777213) ^ -290683025;
					continue;
				case 81u:
					Label10 = SearchPatient_Admin.smethod_4();
					NameTxt = SearchPatient_Admin.smethod_7();
					num = ((int)num2 * -1975703292) ^ -501730425;
					continue;
				case 80u:
					GroupBox1 = SearchPatient_Admin.smethod_5();
					num = ((int)num2 * -1602892092) ^ -1525911229;
					continue;
				case 79u:
					SearchPatient_Admin.smethod_16((Control)(object)Label7, new Size(96, 26));
					num = ((int)num2 * -1418736156) ^ -444672084;
					continue;
				case 78u:
					SearchPatient_Admin.smethod_24(Label3, (ContentAlignment)32);
					num = (int)(num2 * 1525857063) ^ -570861533;
					continue;
				case 77u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_48((Control)(object)this), (Control)(object)DeleteBtn);
					num = (int)((num2 * 755583088) ^ 0xB36C4B1);
					continue;
				case 76u:
					num = (int)(num2 * 1477872993) ^ -648335281;
					continue;
				case 75u:
					SearchPatient_Admin.smethod_14((Control)(object)SearchResultGrid, new Point(59, 295));
					num = ((int)num2 * -1501812708) ^ 0x1A3EFC89;
					continue;
				case 74u:
					SearchPatient_Admin.smethod_15((Control)(object)GroupBox1, "GroupBox1");
					num = (int)(num2 * 630013832) ^ -1175054457;
					continue;
				case 73u:
					SearchPatient_Admin.smethod_21((Control)(object)Label6, SearchPatient_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -37437507) ^ -987666568;
					continue;
				case 72u:
					SearchPatient_Admin.smethod_32((ButtonBase)(object)SearchBtn, bool_0: false);
					num = (int)((num2 * 884237632) ^ 0x591FAC92);
					continue;
				case 71u:
					SearchPatient_Admin.smethod_16((Control)(object)AddressTxt, new Size(258, 90));
					num = ((int)num2 * -294776603) ^ -1821397134;
					continue;
				case 70u:
					num = (int)((num2 * 1018672975) ^ 0x4576205A);
					continue;
				case 69u:
					SearchPatient_Admin.smethod_21((Control)(object)Label3, SearchPatient_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1298430543) ^ -1313261007;
					continue;
				case 68u:
					SearchPatient_Admin.smethod_21((Control)(object)ClearBtn, SearchPatient_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1582327205) ^ 0x59B383C9;
					continue;
				case 67u:
					num = ((int)num2 * -1823349864) ^ 0x320ABCE2;
					continue;
				case 66u:
					SearchPatient_Admin.smethod_15((Control)(object)Label3, "Label3");
					num = ((int)num2 * -1981412772) ^ -185378532;
					continue;
				case 65u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_25((Control)(object)PatientInfoBox), (Control)(object)Label6);
					num = ((int)num2 * -841286997) ^ -1802304131;
					continue;
				case 64u:
					SearchPatient_Admin.smethod_15((Control)(object)Label5, "Label5");
					num = (int)((num2 * 969636102) ^ 0x24CDA8B9);
					continue;
				case 63u:
					SearchPatient_Admin.smethod_15((Control)(object)NameSTxt, "NameSTxt");
					num = ((int)num2 * -201450389) ^ -438007394;
					continue;
				case 62u:
					SearchPatient_Admin.smethod_18(PictureBox1, 9);
					num = ((int)num2 * -5240712) ^ 0x4921A555;
					continue;
				case 61u:
					SearchPatient_Admin.smethod_15((Control)(object)ClearBtn, "ClearBtn");
					SearchPatient_Admin.smethod_16((Control)(object)ClearBtn, new Size(97, 37));
					num = ((int)num2 * -689681428) ^ 0x12074AE0;
					continue;
				case 60u:
					SearchPatient_Admin.smethod_32((ButtonBase)(object)DeleteBtn, bool_0: false);
					num = ((int)num2 * -678688043) ^ -484984258;
					continue;
				case 59u:
					SearchPatient_Admin.smethod_16((Control)(object)Label4, new Size(68, 25));
					num = ((int)num2 * -226366827) ^ 0x47162C35;
					continue;
				case 58u:
					SearchPatient_Admin.smethod_23(Label1, "Search Patient");
					num = (int)((num2 * 2072941956) ^ 0x16CB5822);
					continue;
				case 57u:
					num = (int)(num2 * 85500052) ^ -1733150008;
					continue;
				case 56u:
					SearchPatient_Admin.smethod_31((ButtonBase)(object)UpdateBtn, "Update");
					SearchPatient_Admin.smethod_32((ButtonBase)(object)UpdateBtn, bool_0: false);
					num = ((int)num2 * -951870491) ^ -1648377791;
					continue;
				case 55u:
					MobileTxt = SearchPatient_Admin.smethod_7();
					num = ((int)num2 * -876534353) ^ -152170966;
					continue;
				case 54u:
					SearchPatient_Admin.smethod_24(Label1, (ContentAlignment)32);
					num = ((int)num2 * -392748507) ^ 0x3C196916;
					continue;
				case 53u:
					SearchPatient_Admin.smethod_22((Control)(object)MobileTxt, 11);
					SearchPatient_Admin.smethod_21((Control)(object)Label10, SearchPatient_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1650327938) ^ 0x5453099C;
					continue;
				case 52u:
					num = ((int)num2 * -504203696) ^ -1947197397;
					continue;
				case 51u:
					SearchPatient_Admin.smethod_22((Control)(object)Label2, 0);
					num = (int)((num2 * 593892764) ^ 0x61767F90);
					continue;
				case 50u:
					num = (int)((num2 * 656206867) ^ 0x391AA2A0);
					continue;
				case 49u:
					SearchPatient_Admin.smethod_30((Control)(object)ClearBtn, Color.White);
					num = (int)(num2 * 2073536811) ^ -331558009;
					continue;
				case 48u:
					SearchPatient_Admin.smethod_21((Control)(object)Label4, SearchPatient_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 43031749) ^ -1193435544;
					continue;
				case 47u:
					SearchPatient_Admin.smethod_24(Label10, (ContentAlignment)32);
					num = (int)((num2 * 1913384561) ^ 0x22572E6F);
					continue;
				case 46u:
					num = ((int)num2 * -681422452) ^ -1467698807;
					continue;
				case 45u:
					SearchPatient_Admin.smethod_45((ContainerControl)(object)this, new SizeF(8f, 16f));
					num = ((int)num2 * -258627175) ^ -1994118546;
					continue;
				case 44u:
					SearchPatient_Admin.smethod_16((Control)(object)Label2, new Size(77, 28));
					num = ((int)num2 * -1981343664) ^ -56730523;
					continue;
				case 43u:
					SearchPatient_Admin.smethod_14((Control)(object)Label10, new Point(472, 86));
					num = ((int)num2 * -1676443042) ^ -1714739401;
					continue;
				case 42u:
					SearchPatient_Admin.smethod_15((Control)(object)Label2, "Label2");
					num = ((int)num2 * -950530608) ^ 0x4328D73F;
					continue;
				case 41u:
					SearchPatient_Admin.smethod_34(SearchResultGrid, (DataGridViewColumnHeadersHeightSizeMode)2);
					num = (int)((num2 * 1883748633) ^ 0x6970F4DF);
					continue;
				case 40u:
					num = (int)(num2 * 544241701) ^ -540238063;
					continue;
				case 39u:
					SearchPatient_Admin.smethod_28(PatientInfoBox, "Patient Information");
					num = (int)((num2 * 639278767) ^ 0x50F54009);
					continue;
				case 38u:
					num = ((int)num2 * -716629144) ^ -253790563;
					continue;
				case 37u:
					num = ((int)num2 * -852353427) ^ 0x5C216D86;
					continue;
				case 36u:
					num = ((int)num2 * -557956179) ^ 0x4134165E;
					continue;
				case 35u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_25((Control)(object)PatientInfoBox), (Control)(object)Label7);
					num = ((int)num2 * -1435452427) ^ 0x54BF53C4;
					continue;
				case 34u:
					SearchPatient_Admin.smethod_15((Control)(object)DeleteBtn, "DeleteBtn");
					num = (int)(num2 * 578094185) ^ -1448867334;
					continue;
				case 33u:
					SearchPatient_Admin.smethod_40(DOBTxt, new DateTime(2019, 2, 11, 0, 0, 0, 0));
					SearchPatient_Admin.smethod_41(DOBTxt, new DateTime(1900, 1, 1, 0, 0, 0, 0));
					num = (int)((num2 * 1544058380) ^ 0x55F561B2);
					continue;
				case 32u:
					SearchPatient_Admin.smethod_15((Control)(object)Label6, "Label6");
					num = (int)((num2 * 1065976137) ^ 0x7037AAFC);
					continue;
				case 31u:
					SearchPatient_Admin.smethod_24(Label2, (ContentAlignment)32);
					SearchPatient_Admin.smethod_33(SearchResultGrid, Color.White);
					num = ((int)num2 * -473418554) ^ -1500256041;
					continue;
				case 30u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_25((Control)(object)GroupBox1), (Control)(object)Label3);
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_25((Control)(object)GroupBox1), (Control)(object)MobileSTxt);
					num = ((int)num2 * -1871351024) ^ -1773310384;
					continue;
				case 29u:
					DeleteBtn = SearchPatient_Admin.smethod_6();
					num = ((int)num2 * -1610297175) ^ 0x35FCC94;
					continue;
				case 28u:
					SearchPatient_Admin.smethod_29((ButtonBase)(object)ClearBtn, Color.MidnightBlue);
					num = ((int)num2 * -1085984669) ^ 0x14F6A3DC;
					continue;
				case 27u:
					num = (int)(num2 * 1502186264) ^ -1471159822;
					continue;
				case 26u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_25((Control)(object)PatientInfoBox), (Control)(object)Label5);
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_25((Control)(object)PatientInfoBox), (Control)(object)Label4);
					num = ((int)num2 * -297572219) ^ -1834090139;
					continue;
				case 25u:
					SearchPatient_Admin.smethod_14((Control)(object)GroupBox1, new Point(155, 150));
					num = (int)(num2 * 1064451787) ^ -537126531;
					continue;
				case 24u:
					SearchPatient_Admin.smethod_38((Control)(object)PatientInfoBox, bool_0: false);
					num = ((int)num2 * -122389398) ^ -909665540;
					continue;
				case 23u:
					SearchPatient_Admin.smethod_14((Control)(object)Label2, new Point(37, 44));
					num = ((int)num2 * -771700288) ^ 0x65D6E408;
					continue;
				case 22u:
					SearchPatient_Admin.smethod_38((Control)(object)DeleteBtn, bool_0: false);
					num = ((int)num2 * -340470588) ^ -472076802;
					continue;
				case 21u:
					SearchPatient_Admin.smethod_15((Control)(object)PIDTxt, "PIDTxt");
					num = ((int)num2 * -2109567816) ^ 0x7A64030E;
					continue;
				case 20u:
					SearchPatient_Admin.smethod_14((Control)(object)Label3, new Point(37, 87));
					num = (int)((num2 * 233354604) ^ 0x3FC13478);
					continue;
				case 19u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_48((Control)(object)this), (Control)(object)Label1);
					num = (int)(num2 * 919204334) ^ -1468952377;
					continue;
				case 18u:
					SearchPatient_Admin.smethod_14((Control)(object)ClearBtn, new Point(546, 747));
					num = ((int)num2 * -2095066753) ^ 0x537BD2F5;
					continue;
				case 17u:
					SearchPatient_Admin.smethod_52((Control)(object)PatientInfoBox, bool_0: false);
					num = ((int)num2 * -1226259129) ^ -1840053791;
					continue;
				case 16u:
					SearchPatient_Admin.smethod_39(DOBTxt, (DateTimePickerFormat)2);
					SearchPatient_Admin.smethod_14((Control)(object)DOBTxt, new Point(124, 132));
					num = (int)(num2 * 361156677) ^ -2137280341;
					continue;
				case 15u:
					DOBTxt = SearchPatient_Admin.smethod_9();
					num = (int)((num2 * 1403798753) ^ 0x12FD77F1);
					continue;
				case 14u:
					num = (int)(num2 * 1381671847) ^ -1109540342;
					continue;
				case 13u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_48((Control)(object)this), (Control)(object)GroupBox1);
					num = (int)(num2 * 1967164635) ^ -405678348;
					continue;
				case 12u:
					SearchPatient_Admin.smethod_22((Control)(object)DOBTxt, 12);
					num = (int)((num2 * 916632593) ^ 0x76C2DDA6);
					continue;
				case 11u:
					SearchPatient_Admin.smethod_16((Control)(object)PictureBox1, new Size(130, 125));
					SearchPatient_Admin.smethod_17(PictureBox1, (PictureBoxSizeMode)1);
					num = (int)(num2 * 381891336) ^ -274449498;
					continue;
				case 10u:
					SearchPatient_Admin.smethod_38((Control)(object)UpdateBtn, bool_0: false);
					num = ((int)num2 * -2012569750) ^ -2110856465;
					continue;
				case 9u:
					num = ((int)num2 * -205703944) ^ -1819181629;
					continue;
				case 8u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_25((Control)(object)PatientInfoBox), (Control)(object)NameTxt);
					num = ((int)num2 * -775803055) ^ 0x646AA5DA;
					continue;
				case 7u:
					Label14 = SearchPatient_Admin.smethod_4();
					num = (int)((num2 * 1486074239) ^ 0x71E50547);
					continue;
				case 6u:
					num = (int)((num2 * 1760368708) ^ 0x4B2DFF7D);
					continue;
				case 5u:
					SearchPatient_Admin.smethod_13(PictureBox1, (Image)(object)Resources.patient_pic);
					num = ((int)num2 * -518851422) ^ -545744222;
					continue;
				case 4u:
					num = (int)(num2 * 2066177859) ^ -677306071;
					continue;
				case 3u:
					num = (int)(num2 * 1319427368) ^ -388000176;
					continue;
				case 2u:
					SearchPatient_Admin.smethod_15((Control)(object)MobileSTxt, "MobileSTxt");
					num = (int)(num2 * 846717360) ^ -863791001;
					continue;
				case 1u:
					num = (int)(num2 * 60731564) ^ -1807346028;
					continue;
				case 0u:
					SearchPatient_Admin.smethod_15((Control)(object)SearchBtn, "SearchBtn");
					num = ((int)num2 * -398199338) ^ 0x15510801;
					continue;
				default:
					return;
				case 190u:
					break;
				case 173u:
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
			int num = 1642566002;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x700EE057u) % 3u)
				{
				case 1u:
					goto IL_0030;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0030:
				HideItemsOnForm();
				SearchPatient_Admin.smethod_40(DOBTxt, SearchPatient_Admin.smethod_62(SearchPatient_Admin.smethod_61((object)DateTime.Now, "dd-MM-yyyy")));
				num = ((int)num2 * -558266228) ^ -242631496;
			}
		}
	}

	private void SearchBtn_Click(object sender, EventArgs e)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected I4, but got Unknown
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Expected I4, but got Unknown
		//IL_0300: Incompatible stack heights: 0 vs 1
		//IL_0315: Incompatible stack heights: 0 vs 1
		//IL_0330: Incompatible stack heights: 0 vs 1
		//IL_0340: Incompatible stack heights: 0 vs 1
		//IL_0347: Incompatible stack heights: 0 vs 1
		bool flag = !MyProject.Forms.Form1.Name_Validation(SearchPatient_Admin.smethod_64(SearchPatient_Admin.smethod_63(NameSTxt))) | !MyProject.Forms.Form1.Mobile_Validator(SearchPatient_Admin.smethod_64(SearchPatient_Admin.smethod_63(MobileSTxt)));
		bool flag2 = default(bool);
		while (true)
		{
			int num = 2094615230;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA1FCE6Bu) % 6u)
				{
				case 5u:
					SearchPatient_Admin.smethod_65("No Results Found");
					num = ((int)num2 * -436342272) ^ 0x2F312041;
					continue;
				case 4u:
					HideItemsOnForm();
					num = 1618506762;
					continue;
				case 1u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = 376491191;
						num7 = 376491191;
					}
					else
					{
						num6 = 480043510;
						num7 = 480043510;
					}
					num = num6 ^ (int)(num2 * 448293757);
					continue;
				}
				case 2u:
					break;
				default:
				{
					SearchPatient_Admin.smethod_66();
					string string_ = SearchPatient_Admin.smethod_67(new string[5]
					{
						"Select * From [Patient] Where [Name] Like '%",
						SearchPatient_Admin.smethod_64(SearchPatient_Admin.smethod_63(NameSTxt)),
						"%' And [Mobile] Like '%",
						SearchPatient_Admin.smethod_63(MobileSTxt),
						"%';"
					});
					DataTable dataTable = SearchPatient_Admin.smethod_68();
					SearchPatient_Admin.smethod_69(myconnection);
					try
					{
						OleDbDataAdapter dbDataAdapter_ = SearchPatient_Admin.smethod_70(string_, myconnection);
						while (true)
						{
							int num3 = 1815533705;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xA1FCE6Bu) % 13u)
								{
								case 12u:
									SearchPatient_Admin.smethod_71((DbDataAdapter)(object)dbDataAdapter_, dataTable);
									SearchPatient_Admin.smethod_72(SearchResultGrid, (object)dataTable);
									num3 = (int)(num2 * 1227246396) ^ -63129871;
									continue;
								case 11u:
									mobile_search = SearchPatient_Admin.smethod_63(MobileSTxt);
									num3 = (int)((num2 * 147672718) ^ 0x5696533);
									continue;
								case 10u:
									SearchPatient_Admin.smethod_38((Control)(object)SearchResultGrid, bool_0: true);
									num3 = ((int)num2 * -1507184180) ^ 0x532469F7;
									continue;
								case 8u:
									SearchPatient_Admin.smethod_74(myconnection);
									num3 = ((int)num2 * -661846681) ^ -1566193638;
									continue;
								case 7u:
									num3 = 1273159631;
									continue;
								case 6u:
									name_search = SearchPatient_Admin.smethod_64(SearchPatient_Admin.smethod_63(NameSTxt));
									num3 = (int)((num2 * 975074952) ^ 0x4F034159);
									continue;
								case 5u:
								{
									int num4;
									int num5;
									if (flag2)
									{
										num4 = -546290122;
										num5 = -546290122;
									}
									else
									{
										num4 = -2056916712;
										num5 = -2056916712;
									}
									num3 = num4 ^ ((int)num2 * -1198669208);
									continue;
								}
								case 4u:
									num3 = (int)((num2 * 2126990908) ^ 0x1E5C8AD4);
									continue;
								case 2u:
									SearchPatient_Admin.smethod_65("No Result Found");
									num3 = ((int)num2 * -594419102) ^ -1443413821;
									continue;
								case 1u:
									flag2 = SearchPatient_Admin.smethod_73(SearchResultGrid) == 1;
									num3 = (int)(num2 * 1375950698) ^ -1101807112;
									continue;
								default:
									return;
								case 0u:
									break;
								case 3u:
									SearchPatient_Admin.smethod_74(myconnection);
									return;
								case 9u:
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
							_ = 63235870;
							while (true)
							{
								_003F val = /*Error near IL_02ce: Stack underflow*/^ 0xA1FCE6B;
								num2 = (uint)(int)val;
								switch (val % 6)
								{
								default:
									return;
								case 5:
									_ = (num2 * 1328184487) ^ 0x5E14AEE3;
									continue;
								case 3:
									SearchPatient_Admin.smethod_76();
									_ = ((int)num2 * -1940507398) ^ -1775481939;
									continue;
								case 1:
									SearchPatient_Admin.smethod_74(myconnection);
									_ = ((int)num2 * -1792265616) ^ -460800581;
									continue;
								case 0:
									_ = ((int)num2 * -335658354) ^ -1462585680;
									continue;
								case 4:
									break;
								case 2:
									return;
								}
								break;
							}
						}
					}
				}
				case 0u:
					return;
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
			int num = -1923534179;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8A4BF108u) % 10u)
				{
				case 9u:
					SearchPatient_Admin.smethod_38((Control)(object)SearchResultGrid, bool_0: false);
					num = ((int)num2 * -1763642063) ^ 0x16ECF989;
					continue;
				case 7u:
					num = ((int)num2 * -725354144) ^ -611874759;
					continue;
				case 6u:
					SearchPatient_Admin.smethod_38((Control)(object)PatientInfoBox, bool_0: false);
					num = ((int)num2 * -1917296592) ^ -1513101329;
					continue;
				case 5u:
					SearchPatient_Admin.smethod_38((Control)(object)UpdateBtn, bool_0: false);
					num = (int)(num2 * 795802929) ^ -476669388;
					continue;
				case 3u:
					SearchPatient_Admin.smethod_38((Control)(object)DeleteBtn, bool_0: false);
					result = true;
					num = ((int)num2 * -1710816312) ^ -551916104;
					continue;
				case 2u:
					num = ((int)num2 * -964298000) ^ -1797606504;
					continue;
				case 1u:
					SearchPatient_Admin.smethod_38((Control)(object)ClearBtn, bool_0: false);
					num = ((int)num2 * -541309068) ^ 0x75B6DC2C;
					continue;
				case 0u:
					num = (int)(num2 * 1442214084) ^ -2128092603;
					continue;
				case 8u:
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
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		if (SearchPatient_Admin.smethod_77(SearchPatient_Admin.smethod_63(PIDTxt), "", bool_0: false) == 0)
		{
			goto IL_0048;
		}
		goto IL_0092;
		IL_0092:
		OleDbCommand val = SearchPatient_Admin.smethod_66();
		int num = -621782588;
		goto IL_0068;
		IL_0068:
		string string_ = default(string);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x8E781A94u) % 6u)
			{
			case 4u:
				string_ = SearchPatient_Admin.smethod_78("Delete From [Patient] Where [PID] = ", SearchPatient_Admin.smethod_63(PIDTxt), ";");
				num = ((int)num2 * -1464367913) ^ 0x285A848C;
				continue;
			case 3u:
				break;
			case 2u:
				SearchPatient_Admin.smethod_65("Nothing To Delete");
				num = ((int)num2 * -1532008312) ^ 0x480A77EF;
				continue;
			case 5u:
				goto IL_0092;
			default:
				SearchPatient_Admin.smethod_69(myconnection);
				try
				{
					val = SearchPatient_Admin.smethod_79(string_, myconnection);
					SearchPatient_Admin.smethod_80(val);
					SearchPatient_Admin.smethod_81((Component)(object)val);
					while (true)
					{
						int num3 = -1686928691;
						while (true)
						{
							switch ((num2 = (uint)num3 ^ 0x8E781A94u) % 6u)
							{
							case 4u:
								ClearPatientInfo();
								SearchPatient_Admin.smethod_65("Successfully Deleted Entry");
								num3 = (int)(num2 * 30190672) ^ -648026081;
								continue;
							case 3u:
								SearchPatient_Admin.smethod_74(myconnection);
								num3 = (int)(num2 * 813507471) ^ -520893627;
								continue;
							case 1u:
								UpdateTable();
								num3 = (int)((num2 * 1046713313) ^ 0x72C2A287);
								continue;
							case 0u:
								num3 = (int)(num2 * 1783423891) ^ -1077399205;
								continue;
							default:
								return;
							case 2u:
								break;
							case 5u:
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
			case 1u:
				return;
			}
			break;
		}
		goto IL_0048;
		IL_0048:
		num = -411743652;
		goto IL_0068;
	}

	private void UpdateBtn_Click(object sender, EventArgs e)
	{
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Expected I4, but got Unknown
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected I4, but got Unknown
		//IL_03a1: Incompatible stack heights: 0 vs 1
		//IL_03b1: Incompatible stack heights: 0 vs 1
		//IL_03b8: Incompatible stack heights: 0 vs 1
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		string string_ = default(string);
		DateTime dateTime_ = default(DateTime);
		while (true)
		{
			int num = 94756583;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2AE0B32Eu) % 12u)
				{
				case 11u:
					SearchPatient_Admin.smethod_69(myconnection);
					num = (int)((num2 * 1059232089) ^ 0x3C78008D);
					continue;
				case 9u:
				{
					int num6;
					int num7;
					if (!((SearchPatient_Admin.smethod_77(SearchPatient_Admin.smethod_63(NameTxt), "", bool_0: false) == 0) | (SearchPatient_Admin.smethod_77(SearchPatient_Admin.smethod_63(MobileSTxt), "", bool_0: false) == 0) | (SearchPatient_Admin.smethod_77(SearchPatient_Admin.smethod_63(GenderTxt), "", bool_0: false) == 0) | (SearchPatient_Admin.smethod_77(SearchPatient_Admin.smethod_63(AddressTxt), "", bool_0: false) == 0)))
					{
						num6 = 993791756;
						num7 = 993791756;
					}
					else
					{
						num6 = 1012650994;
						num7 = 1012650994;
					}
					num = num6 ^ (int)(num2 * 36856404);
					continue;
				}
				case 7u:
				{
					int num4;
					int num5;
					if (!(MyProject.Forms.Form1.Name_Validation(SearchPatient_Admin.smethod_64(SearchPatient_Admin.smethod_63(NameTxt))) & MyProject.Forms.Form1.Mobile_Validator(SearchPatient_Admin.smethod_63(MobileSTxt)) & MyProject.Forms.Form1.Gender_Validator(SearchPatient_Admin.smethod_64(SearchPatient_Admin.smethod_63(GenderTxt)))))
					{
						num4 = -1415617952;
						num5 = -1415617952;
					}
					else
					{
						num4 = -29565451;
						num5 = -29565451;
					}
					num = num4 ^ ((int)num2 * -852152179);
					continue;
				}
				case 6u:
					num = 1375333081;
					continue;
				case 3u:
				{
					OleDbCommand val = SearchPatient_Admin.smethod_66();
					num = ((int)num2 * -1629026368) ^ -228169561;
					continue;
				}
				case 2u:
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
					num = ((int)num2 * -2005060493) ^ -429460077;
					continue;
				case 1u:
					dateTime_ = SearchPatient_Admin.smethod_62(SearchPatient_Admin.smethod_61((object)SearchPatient_Admin.smethod_82(DOBTxt), "dd-MM-yyyy"));
					num = ((int)num2 * -1563059995) ^ 0x25FE5011;
					continue;
				case 0u:
					num = 30317853;
					continue;
				case 10u:
					break;
				default:
					try
					{
						OleDbCommand val = SearchPatient_Admin.smethod_79(string_, myconnection);
						while (true)
						{
							int num3 = 858723617;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x2AE0B32Eu) % 8u)
								{
								case 7u:
									SearchPatient_Admin.smethod_80(val);
									num3 = ((int)num2 * -157691769) ^ -1171225294;
									continue;
								case 6u:
									SearchPatient_Admin.smethod_65("Successfully Updated Details");
									num3 = (int)((num2 * 2109469798) ^ 0x2F3410D1);
									continue;
								case 5u:
									SearchPatient_Admin.smethod_81((Component)(object)val);
									num3 = ((int)num2 * -950152738) ^ -1079237348;
									continue;
								case 4u:
									SearchPatient_Admin.smethod_74(myconnection);
									num3 = ((int)num2 * -735181790) ^ -1773221508;
									continue;
								case 3u:
									ClearPatientInfo();
									num3 = (int)(num2 * 1235139869) ^ -1540464776;
									continue;
								case 2u:
									num3 = (int)((num2 * 1213895273) ^ 0x55279AA2);
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
						SearchPatient_Admin.smethod_75(exception_);
						while (true)
						{
							_ = 835901401;
							while (true)
							{
								_003F val2 = /*Error near IL_036c: Stack underflow*/^ 0x2AE0B32E;
								num2 = (uint)(int)val2;
								switch (val2 % 4)
								{
								case 3:
									SearchPatient_Admin.smethod_74(myconnection);
									_ = (num2 * 1932502005) ^ 0xD04899D4u;
									continue;
								case 1:
									_ = ((int)num2 * -1491057966) ^ -800096498;
									continue;
								case 0:
									break;
								default:
									SearchPatient_Admin.smethod_76();
									return;
								}
								break;
							}
						}
					}
				case 5u:
					SearchPatient_Admin.smethod_65("Invalid Credentials");
					return;
				case 8u:
					SearchPatient_Admin.smethod_65("Empty Fields Not Allowed");
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
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected I4, but got Unknown
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected I4, but got Unknown
		//IL_0245: Incompatible stack heights: 0 vs 1
		//IL_0255: Incompatible stack heights: 0 vs 1
		//IL_026a: Incompatible stack heights: 0 vs 1
		//IL_027a: Incompatible stack heights: 0 vs 1
		//IL_0281: Incompatible stack heights: 0 vs 1
		SearchPatient_Admin.smethod_66();
		bool result = default(bool);
		DataTable dataTable = default(DataTable);
		bool flag = default(bool);
		string string_ = default(string);
		while (true)
		{
			int num = -1172776683;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFBB2DEA4u) % 3u)
				{
				case 2u:
					goto IL_0008;
				case 0u:
					break;
				default:
					SearchPatient_Admin.smethod_69(myconnection);
					try
					{
						while (true)
						{
							IL_01e8:
							int num3 = -446390219;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xFBB2DEA4u) % 13u)
								{
								case 12u:
									result = false;
									num3 = (int)(num2 * 1858341471) ^ -1919123459;
									continue;
								case 11u:
									num3 = ((int)num2 * -1730817919) ^ -556880775;
									continue;
								case 8u:
									SearchPatient_Admin.smethod_72(SearchResultGrid, (object)dataTable);
									num3 = (int)((num2 * 610645189) ^ 0x3F5502A3);
									continue;
								case 7u:
									SearchPatient_Admin.smethod_74(myconnection);
									num3 = (int)((num2 * 738656949) ^ 0x206095C5);
									continue;
								case 6u:
									num3 = (int)(num2 * 1126339054) ^ -729525922;
									continue;
								case 5u:
									SearchPatient_Admin.smethod_38((Control)(object)SearchResultGrid, bool_0: true);
									num3 = -177030229;
									continue;
								case 4u:
									flag = SearchPatient_Admin.smethod_73(SearchResultGrid) == 1;
									num3 = ((int)num2 * -1120710068) ^ -1785777094;
									continue;
								case 2u:
									SearchPatient_Admin.smethod_74(myconnection);
									num3 = (int)((num2 * 566092298) ^ 0xAE614E8);
									continue;
								case 1u:
								{
									OleDbDataAdapter dbDataAdapter_ = SearchPatient_Admin.smethod_70(string_, myconnection);
									SearchPatient_Admin.smethod_71((DbDataAdapter)(object)dbDataAdapter_, dataTable);
									num3 = ((int)num2 * -2014088504) ^ -676981819;
									continue;
								}
								case 0u:
								{
									int num4;
									int num5;
									if (flag)
									{
										num4 = -343689642;
										num5 = -343689642;
									}
									else
									{
										num4 = -1699505113;
										num5 = -1699505113;
									}
									num3 = num4 ^ ((int)num2 * -1246745669);
									continue;
								}
								default:
									goto end_IL_01a1;
								case 10u:
									break;
								case 3u:
									goto end_IL_01a1;
								case 9u:
									return result;
								}
								goto IL_01e8;
								continue;
								end_IL_01a1:
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
							IL_027c:
							_ = -1118019134;
							while (true)
							{
								_003F val = /*Error near IL_0208: Stack underflow*/^ -72163676;
								num2 = (uint)(int)val;
								switch (val % 6)
								{
								default:
									goto end_IL_0202;
								case 5:
									SearchPatient_Admin.smethod_74(myconnection);
									_ = (num2 * 628646441) ^ 0x933CDB02u;
									continue;
								case 4:
									_ = (num2 * 384062255) ^ 0x1D14BC5;
									continue;
								case 3:
									SearchPatient_Admin.smethod_76();
									_ = ((int)num2 * -1786729173) ^ 0x5AA5020D;
									continue;
								case 1:
									_ = ((int)num2 * -1829624365) ^ 0x6F65F060;
									continue;
								case 0:
									break;
								case 2:
									goto end_IL_0202;
								}
								goto IL_027c;
								continue;
								end_IL_0202:
								break;
							}
							break;
						}
					}
					while (true)
					{
						int num6 = -391113088;
						while (true)
						{
							switch ((num2 = (uint)num6 ^ 0xFBB2DEA4u) % 3u)
							{
							case 2u:
								goto IL_0288;
							case 0u:
								break;
							default:
								return result;
							}
							break;
							IL_0288:
							result = false;
							num6 = ((int)num2 * -325122997) ^ -1891117752;
						}
					}
				}
				break;
				IL_0008:
				string_ = SearchPatient_Admin.smethod_67(new string[5]
				{
					"Select * From [Patient] Where [Name] Like '%",
					SearchPatient_Admin.smethod_64(name_search),
					"%' And [Mobile] Like '%",
					mobile_search,
					"%';"
				});
				dataTable = SearchPatient_Admin.smethod_68();
				num = (int)(num2 * 1746059437) ^ -367008611;
			}
		}
	}

	private void SearchResultGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected I4, but got Unknown
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected I4, but got Unknown
		//IL_02ec: Incompatible stack heights: 0 vs 1
		//IL_02f3: Incompatible stack heights: 0 vs 1
		try
		{
			while (true)
			{
				int num = 97022566;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x177EB444u) % 15u)
					{
					case 14u:
						num = (int)(num2 * 1759713860) ^ -385217211;
						continue;
					case 13u:
						num = ((int)num2 * -1397900801) ^ -1826189224;
						continue;
					case 12u:
						SearchPatient_Admin.smethod_91(PIDTxt, SearchPatient_Admin.smethod_90(SearchPatient_Admin.smethod_89(SearchPatient_Admin.smethod_88(SearchPatient_Admin.smethod_87(SearchPatient_Admin.smethod_86(SearchPatient_Admin.smethod_84(SearchResultGrid), SearchPatient_Admin.smethod_85(e))), 0))));
						num = ((int)num2 * -1893177042) ^ 0x5A573464;
						continue;
					case 11u:
						num = (int)(num2 * 1289229647) ^ -1576823461;
						continue;
					case 10u:
						num = ((int)num2 * -160455687) ^ -1068327216;
						continue;
					case 9u:
						SearchPatient_Admin.smethod_38((Control)(object)DeleteBtn, bool_0: true);
						num = ((int)num2 * -293941446) ^ 0x90093B9;
						continue;
					case 7u:
						SearchPatient_Admin.smethod_38((Control)(object)ClearBtn, bool_0: true);
						SearchPatient_Admin.smethod_38((Control)(object)UpdateBtn, bool_0: true);
						num = (int)(num2 * 1824468137) ^ -57972469;
						continue;
					case 6u:
						SearchPatient_Admin.smethod_92(DOBTxt, SearchPatient_Admin.smethod_90(SearchPatient_Admin.smethod_89(SearchPatient_Admin.smethod_88(SearchPatient_Admin.smethod_87(SearchPatient_Admin.smethod_86(SearchPatient_Admin.smethod_84(SearchResultGrid), SearchPatient_Admin.smethod_85(e))), 2))));
						num = (int)((num2 * 715663035) ^ 0x2FEF71E8);
						continue;
					case 5u:
						SearchPatient_Admin.smethod_91(GenderTxt, SearchPatient_Admin.smethod_90(SearchPatient_Admin.smethod_89(SearchPatient_Admin.smethod_88(SearchPatient_Admin.smethod_87(SearchPatient_Admin.smethod_86(SearchPatient_Admin.smethod_84(SearchResultGrid), SearchPatient_Admin.smethod_85(e))), 3))));
						num = ((int)num2 * -811993545) ^ 0x110CCC2C;
						continue;
					case 4u:
						SearchPatient_Admin.smethod_38((Control)(object)PatientInfoBox, bool_0: true);
						num = (int)(num2 * 2041677920) ^ -1467119584;
						continue;
					case 3u:
						SearchPatient_Admin.smethod_91(MobileTxt, SearchPatient_Admin.smethod_90(SearchPatient_Admin.smethod_89(SearchPatient_Admin.smethod_88(SearchPatient_Admin.smethod_87(SearchPatient_Admin.smethod_86(SearchPatient_Admin.smethod_84(SearchResultGrid), SearchPatient_Admin.smethod_85(e))), 4))));
						num = ((int)num2 * -1187848311) ^ -1712166749;
						continue;
					case 1u:
						SearchPatient_Admin.smethod_91(NameTxt, SearchPatient_Admin.smethod_90(SearchPatient_Admin.smethod_89(SearchPatient_Admin.smethod_88(SearchPatient_Admin.smethod_87(SearchPatient_Admin.smethod_86(SearchPatient_Admin.smethod_84(SearchResultGrid), SearchPatient_Admin.smethod_85(e))), 1))));
						num = ((int)num2 * -280623143) ^ -2001179391;
						continue;
					case 0u:
						SearchPatient_Admin.smethod_91(AddressTxt, SearchPatient_Admin.smethod_90(SearchPatient_Admin.smethod_89(SearchPatient_Admin.smethod_88(SearchPatient_Admin.smethod_87(SearchPatient_Admin.smethod_86(SearchPatient_Admin.smethod_84(SearchResultGrid), SearchPatient_Admin.smethod_85(e))), 5))));
						num = (int)((num2 * 1204637102) ^ 0x1016DB49);
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
		catch (Exception exception_)
		{
			SearchPatient_Admin.smethod_75(exception_);
			while (true)
			{
				_ = 355293515;
				while (true)
				{
					_003F val = /*Error near IL_02c3: Stack underflow*/^ 0x177EB444;
					uint num2 = (uint)(int)val;
					switch (val % 3)
					{
					default:
						return;
					case 1:
						SearchPatient_Admin.smethod_76();
						_ = (num2 * 1863927612) ^ 0x4B7EA51C;
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

	private bool ClearPatientInfo()
	{
		bool result = default(bool);
		while (true)
		{
			int num = 359906438;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x257E6C8Bu) % 12u)
				{
				case 11u:
					num = ((int)num2 * -1265545189) ^ 0x390679DB;
					continue;
				case 10u:
					num = (int)((num2 * 856843915) ^ 0x78F321B7);
					continue;
				case 9u:
					SearchPatient_Admin.smethod_93((TextBoxBase)(object)PIDTxt);
					num = (int)(num2 * 1395043591) ^ -1420243191;
					continue;
				case 8u:
					num = (int)((num2 * 1848707379) ^ 0x533DF5A3);
					continue;
				case 7u:
					SearchPatient_Admin.smethod_93((TextBoxBase)(object)MobileTxt);
					num = ((int)num2 * -1627625222) ^ -1742369481;
					continue;
				case 6u:
					SearchPatient_Admin.smethod_42(DOBTxt, SearchPatient_Admin.smethod_62(SearchPatient_Admin.smethod_61((object)SearchPatient_Admin.smethod_94(), "dd-MM-yyyy")));
					num = (int)(num2 * 81152966) ^ -755749740;
					continue;
				case 5u:
					result = true;
					num = (int)(num2 * 828272666) ^ -1012851793;
					continue;
				case 3u:
					SearchPatient_Admin.smethod_93((TextBoxBase)(object)AddressTxt);
					num = (int)((num2 * 1139201151) ^ 0x39078B3E);
					continue;
				case 1u:
					SearchPatient_Admin.smethod_93((TextBoxBase)(object)NameTxt);
					num = ((int)num2 * -518040940) ^ -231695920;
					continue;
				case 0u:
					SearchPatient_Admin.smethod_93((TextBoxBase)(object)GenderTxt);
					num = ((int)num2 * -1300192590) ^ -273264932;
					continue;
				case 4u:
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
