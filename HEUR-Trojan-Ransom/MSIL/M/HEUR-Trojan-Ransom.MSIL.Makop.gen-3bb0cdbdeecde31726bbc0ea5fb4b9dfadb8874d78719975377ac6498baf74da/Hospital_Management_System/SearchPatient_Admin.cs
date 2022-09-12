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
			Button searchBtn = _SearchBtn;
			if (searchBtn != null)
			{
				goto IL_006c;
			}
			goto IL_009a;
			IL_009a:
			_SearchBtn = value;
			searchBtn = _SearchBtn;
			int num = -329225534;
			goto IL_0071;
			IL_0071:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA52416DCu) % 6u)
				{
				case 5u:
					SearchPatient_Admin.smethod_55((Control)(object)searchBtn, eventHandler_);
					num = (int)((num2 * 75392085) ^ 0x6D1E98C0);
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (searchBtn != null)
					{
						num3 = 1738173865;
						num4 = 1738173865;
					}
					else
					{
						num3 = 2002952138;
						num4 = 2002952138;
					}
					num = num3 ^ (int)(num2 * 1903008800);
					continue;
				}
				case 3u:
					SearchPatient_Admin.smethod_56((Control)(object)searchBtn, eventHandler_);
					num = (int)(num2 * 524735388) ^ -878737082;
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
			num = -1118415097;
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
			DataGridView searchResultGrid = default(DataGridView);
			while (true)
			{
				int num = -1152226938;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC0BDF69Cu) % 6u)
					{
					case 5u:
						SearchPatient_Admin.smethod_57(searchResultGrid, dataGridViewCellMouseEventHandler_);
						num = ((int)num2 * -523442301) ^ -2057074453;
						continue;
					case 4u:
					{
						searchResultGrid = _SearchResultGrid;
						int num4;
						int num5;
						if (searchResultGrid == null)
						{
							num4 = 2111549216;
							num5 = 2111549216;
						}
						else
						{
							num4 = 965311101;
							num5 = 965311101;
						}
						num = num4 ^ (int)(num2 * 2102371533);
						continue;
					}
					case 2u:
						SearchPatient_Admin.smethod_58(searchResultGrid, dataGridViewCellMouseEventHandler_);
						num = ((int)num2 * -2107131626) ^ 0x1D38FFCD;
						continue;
					case 0u:
					{
						_SearchResultGrid = value;
						searchResultGrid = _SearchResultGrid;
						int num3;
						if (searchResultGrid == null)
						{
							num = -964674711;
							num3 = -964674711;
						}
						else
						{
							num = -1738292822;
							num3 = -1738292822;
						}
						continue;
					}
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
				int num = 1774689947;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3E42298Fu) % 8u)
					{
					case 6u:
					{
						int num5;
						int num6;
						if (clearBtn != null)
						{
							num5 = 1740552280;
							num6 = 1740552280;
						}
						else
						{
							num5 = 509286034;
							num6 = 509286034;
						}
						num = num5 ^ ((int)num2 * -497113503);
						continue;
					}
					case 5u:
						clearBtn = _ClearBtn;
						num = ((int)num2 * -1205555552) ^ 0x27E1EC51;
						continue;
					case 4u:
					{
						clearBtn = _ClearBtn;
						int num3;
						int num4;
						if (clearBtn == null)
						{
							num3 = 1650491751;
							num4 = 1650491751;
						}
						else
						{
							num3 = 564508837;
							num4 = 564508837;
						}
						num = num3 ^ (int)(num2 * 347847960);
						continue;
					}
					case 2u:
						SearchPatient_Admin.smethod_55((Control)(object)clearBtn, eventHandler_);
						num = (int)((num2 * 1788220038) ^ 0x35F7E93B);
						continue;
					case 1u:
						SearchPatient_Admin.smethod_56((Control)(object)clearBtn, eventHandler_);
						num = ((int)num2 * -278794379) ^ -1411407663;
						continue;
					case 0u:
						_ClearBtn = value;
						num = 1896300042;
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
				int num = -87315643;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF05877FFu) % 7u)
					{
					case 6u:
						SearchPatient_Admin.smethod_55((Control)(object)updateBtn, eventHandler_);
						num = (int)(num2 * 1685395997) ^ -185310621;
						continue;
					case 5u:
						updateBtn = _UpdateBtn;
						num = (int)(num2 * 1827044222) ^ -377111037;
						continue;
					case 4u:
					{
						int num4;
						int num5;
						if (updateBtn == null)
						{
							num4 = 1237490207;
							num5 = 1237490207;
						}
						else
						{
							num4 = 1521093619;
							num5 = 1521093619;
						}
						num = num4 ^ ((int)num2 * -1549460199);
						continue;
					}
					case 3u:
					{
						_UpdateBtn = value;
						updateBtn = _UpdateBtn;
						int num3;
						if (updateBtn != null)
						{
							num = -1574829192;
							num3 = -1574829192;
						}
						else
						{
							num = -1789970536;
							num3 = -1789970536;
						}
						continue;
					}
					case 1u:
						SearchPatient_Admin.smethod_56((Control)(object)updateBtn, eventHandler_);
						num = ((int)num2 * -1367096435) ^ -2113588029;
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
			if (deleteBtn == null)
			{
				num = 2146910927;
				num2 = 2146910927;
			}
			else
			{
				num = 203712679;
				num2 = 203712679;
			}
			goto IL_0057;
			IL_0057:
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num ^ 0x30F268CFu) % 5u)
				{
				case 4u:
					SearchPatient_Admin.smethod_55((Control)(object)deleteBtn, eventHandler_);
					num = (int)(num3 * 671872364) ^ -1397860355;
					continue;
				case 3u:
					SearchPatient_Admin.smethod_56((Control)(object)deleteBtn, eventHandler_);
					num = ((int)num3 * -804802943) ^ -519854425;
					continue;
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_0088;
				case 1u:
					return;
				}
				break;
			}
			goto IL_0052;
			IL_0052:
			num = 75449081;
			goto IL_0057;
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
			int num = 589483651;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7B142F1Eu) % 5u)
				{
				case 4u:
					num = ((int)num2 * -2041407203) ^ 0x510891D8;
					continue;
				case 2u:
					SearchPatient_Admin.smethod_0((UserControl)(object)this, (EventHandler)SearchPatient_Admin_Load);
					num = (int)((num2 * 478468) ^ 0x2AA28347);
					continue;
				case 0u:
					myconnection = SearchPatient_Admin.smethod_1();
					InitializeComponent();
					num = (int)(num2 * 105192058) ^ -377891634;
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

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing)
			{
				goto IL_0007;
			}
			int num = 0;
			goto IL_0078;
			IL_0078:
			bool flag = (byte)num != 0;
			int num2 = 187685923;
			goto IL_004a;
			IL_0007:
			num2 = 503229098;
			goto IL_004a;
			IL_004a:
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xAF40DFEu) % 5u)
				{
				case 3u:
					break;
				case 2u:
					SearchPatient_Admin.smethod_2((IDisposable)components);
					num2 = ((int)num3 * -2068913538) ^ -1698693620;
					continue;
				case 0u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -666550806;
						num5 = -666550806;
					}
					else
					{
						num4 = -1844413973;
						num5 = -1844413973;
					}
					num2 = num4 ^ (int)(num3 * 195380293);
					continue;
				}
				default:
					return;
				case 4u:
					goto IL_006f;
				case 1u:
					return;
				}
				break;
			}
			goto IL_0007;
			IL_006f:
			num = ((components != null) ? 1 : 0);
			goto IL_0078;
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
			int num = 1496606695;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1EE8B708u) % 285u)
				{
				case 284u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_48((Control)(object)this), (Control)(object)PatientInfoBox);
					num = ((int)num2 * -1098925538) ^ -1923677017;
					continue;
				case 283u:
					num = ((int)num2 * -613345067) ^ 0x431A1102;
					continue;
				case 282u:
					SearchPatient_Admin.smethod_31((ButtonBase)(object)SearchBtn, "Search");
					num = (int)((num2 * 779336993) ^ 0x1031281A);
					continue;
				case 281u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_25((Control)(object)PatientInfoBox), (Control)(object)Label14);
					num = (int)(num2 * 1804281117) ^ -1410171540;
					continue;
				case 280u:
					SearchPatient_Admin.smethod_14((Control)(object)PatientInfoBox, new Point(59, 486));
					num = (int)(num2 * 1046233052) ^ -673934146;
					continue;
				case 279u:
					SearchPatient_Admin.smethod_22((Control)(object)MobileSTxt, 2);
					num = ((int)num2 * -1151549796) ^ 0x7EB9A61F;
					continue;
				case 278u:
					num = (int)(num2 * 519785840) ^ -1035145615;
					continue;
				case 277u:
					SearchPatient_Admin.smethod_21((Control)(object)Label6, SearchPatient_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					SearchPatient_Admin.smethod_14((Control)(object)Label6, new Point(13, 180));
					num = ((int)num2 * -586340693) ^ 0x67E091D3;
					continue;
				case 276u:
					num = (int)((num2 * 592288949) ^ 0x4FFD4260);
					continue;
				case 275u:
					num = (int)((num2 * 1106603069) ^ 0x365DEC05);
					continue;
				case 274u:
					SearchPatient_Admin.smethod_29((ButtonBase)(object)DeleteBtn, Color.MidnightBlue);
					num = ((int)num2 * -711873612) ^ 0x6DF8CC8;
					continue;
				case 273u:
					SearchPatient_Admin.smethod_29((ButtonBase)(object)UpdateBtn, Color.MidnightBlue);
					SearchPatient_Admin.smethod_21((Control)(object)UpdateBtn, SearchPatient_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -2098738358) ^ 0x6CB646A3;
					continue;
				case 272u:
					num = ((int)num2 * -450725241) ^ -2082359063;
					continue;
				case 271u:
					SearchPatient_Admin.smethod_24(Label3, (ContentAlignment)32);
					num = (int)(num2 * 2110975355) ^ -2090189023;
					continue;
				case 270u:
					SearchPatient_Admin.smethod_15((Control)(object)NameSTxt, "NameSTxt");
					num = (int)((num2 * 1296314368) ^ 0x39A5F5C7);
					continue;
				case 269u:
					SearchPatient_Admin.smethod_22((Control)(object)SearchResultGrid, 12);
					num = ((int)num2 * -2005652771) ^ -1089013026;
					continue;
				case 268u:
					num = ((int)num2 * -1868776168) ^ 0x456267C4;
					continue;
				case 267u:
					Label5 = SearchPatient_Admin.smethod_4();
					num = ((int)num2 * -4388556) ^ -1399851333;
					continue;
				case 266u:
					SearchPatient_Admin.smethod_32((ButtonBase)(object)DeleteBtn, bool_0: false);
					num = ((int)num2 * -1302001836) ^ -429169305;
					continue;
				case 265u:
					SearchPatient_Admin.smethod_14((Control)(object)GenderTxt, new Point(124, 178));
					SearchPatient_Admin.smethod_15((Control)(object)GenderTxt, "GenderTxt");
					num = (int)(num2 * 269219789) ^ -260566849;
					continue;
				case 264u:
					num = ((int)num2 * -1524069410) ^ 0x1153817B;
					continue;
				case 263u:
					num = (int)((num2 * 915063537) ^ 0x57A2E43D);
					continue;
				case 261u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_48((Control)(object)this), (Control)(object)Label1);
					num = (int)(num2 * 2110475376) ^ -502165828;
					continue;
				case 260u:
					SearchPatient_Admin.smethod_32((ButtonBase)(object)SearchBtn, bool_0: false);
					num = (int)(num2 * 308873917) ^ -1914510734;
					continue;
				case 259u:
					num = ((int)num2 * -704242590) ^ 0x527DE808;
					continue;
				case 258u:
					SearchPatient_Admin.smethod_14((Control)(object)PIDTxt, new Point(124, 43));
					num = (int)((num2 * 10450) ^ 0x218E1DD3);
					continue;
				case 257u:
					SearchPatient_Admin.smethod_14((Control)(object)SearchResultGrid, new Point(59, 295));
					num = (int)((num2 * 497452012) ^ 0x2A4C4FC3);
					continue;
				case 256u:
					SearchPatient_Admin.smethod_27(GroupBox1, bool_0: false);
					num = ((int)num2 * -2061410533) ^ 0x6C8779B6;
					continue;
				case 255u:
					SearchPatient_Admin.smethod_41(DOBTxt, new DateTime(1900, 1, 1, 0, 0, 0, 0));
					num = ((int)num2 * -790344470) ^ -1973465794;
					continue;
				case 254u:
					SearchPatient_Admin.smethod_23(Label6, "Gender : ");
					num = ((int)num2 * -900420938) ^ -1868547349;
					continue;
				case 253u:
					SearchPatient_Admin.smethod_30((Control)(object)ClearBtn, Color.White);
					num = ((int)num2 * -1351904628) ^ 0x6AAA82B2;
					continue;
				case 252u:
					num = ((int)num2 * -500927764) ^ -1445857939;
					continue;
				case 251u:
					SearchPatient_Admin.smethod_16((Control)(object)SearchBtn, new Size(133, 37));
					num = (int)((num2 * 124849111) ^ 0x596F006B);
					continue;
				case 250u:
					num = ((int)num2 * -1454856907) ^ 0x2F35AB3F;
					continue;
				case 249u:
					SearchPatient_Admin.smethod_15((Control)(object)Label14, "Label14");
					num = ((int)num2 * -539299559) ^ 0x24DC62B3;
					continue;
				case 248u:
					num = (int)(num2 * 1238646855) ^ -440964940;
					continue;
				case 247u:
					Label7 = SearchPatient_Admin.smethod_4();
					num = (int)(num2 * 1568013951) ^ -1975517935;
					continue;
				case 246u:
					SearchPatient_Admin.smethod_22((Control)(object)SearchBtn, 4);
					num = ((int)num2 * -667338822) ^ 0x1D2D245E;
					continue;
				case 245u:
					SearchPatient_Admin.smethod_21((Control)(object)Label2, SearchPatient_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					SearchPatient_Admin.smethod_14((Control)(object)Label2, new Point(37, 44));
					num = (int)(num2 * 249350676) ^ -736954170;
					continue;
				case 244u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_48((Control)(object)this), (Control)(object)PictureBox1);
					num = (int)((num2 * 702146127) ^ 0x891DE99);
					continue;
				case 243u:
					num = (int)(num2 * 178716011) ^ -193666965;
					continue;
				case 242u:
					num = ((int)num2 * -1243216375) ^ 0x5145A804;
					continue;
				case 241u:
					num = (int)(num2 * 2092864705) ^ -1536890676;
					continue;
				case 240u:
					num = (int)(num2 * 940919892) ^ -1633087902;
					continue;
				case 239u:
					SearchPatient_Admin.smethod_15((Control)(object)Label7, "Label7");
					num = ((int)num2 * -1267549420) ^ -579863047;
					continue;
				case 238u:
					num = ((int)num2 * -809053722) ^ 0x6FE28E08;
					continue;
				case 237u:
					num = (int)((num2 * 82109611) ^ 0x3F500385);
					continue;
				case 236u:
					SearchPatient_Admin.smethod_16((Control)(object)Label6, new Size(84, 26));
					num = ((int)num2 * -579240381) ^ -550695634;
					continue;
				case 235u:
					SearchPatient_Admin.smethod_12((Control)(object)this);
					num = ((int)num2 * -337484234) ^ -1969545789;
					continue;
				case 234u:
					num = ((int)num2 * -1229433170) ^ 0x27287E5D;
					continue;
				case 233u:
					PIDTxt = SearchPatient_Admin.smethod_7();
					num = ((int)num2 * -945090551) ^ 0x25431C60;
					continue;
				case 232u:
					SearchPatient_Admin.smethod_15((Control)(object)PictureBox1, "PictureBox1");
					num = (int)((num2 * 825201551) ^ 0x6A0921E8);
					continue;
				case 231u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_25((Control)(object)PatientInfoBox), (Control)(object)MobileTxt);
					num = (int)((num2 * 1563211156) ^ 0x975954);
					continue;
				case 230u:
					num = ((int)num2 * -778692359) ^ -1157259508;
					continue;
				case 229u:
					num = ((int)num2 * -1544319901) ^ -1728667958;
					continue;
				case 228u:
					num = ((int)num2 * -1797797721) ^ -205390630;
					continue;
				case 227u:
					SearchPatient_Admin.smethod_38((Control)(object)ClearBtn, bool_0: false);
					num = ((int)num2 * -1052125696) ^ -1862187767;
					continue;
				case 226u:
					SearchPatient_Admin.smethod_21((Control)(object)Label4, SearchPatient_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1919431223) ^ -1461752675;
					continue;
				case 225u:
					SearchPatient_Admin.smethod_21((Control)(object)Label7, SearchPatient_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -718555086) ^ 0x6FE48F7A;
					continue;
				case 224u:
					SearchPatient_Admin.smethod_23(Label3, "Mobile : ");
					num = ((int)num2 * -1530427902) ^ -1951247145;
					continue;
				case 223u:
					SearchPatient_Admin.smethod_18(PictureBox1, 9);
					SearchPatient_Admin.smethod_19(PictureBox1, bool_0: false);
					SearchPatient_Admin.smethod_21((Control)(object)Label1, SearchPatient_Admin.smethod_20("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 663197560) ^ -1472698216;
					continue;
				case 222u:
					SearchPatient_Admin.smethod_16((Control)(object)Label5, new Size(68, 26));
					num = ((int)num2 * -1277531604) ^ -1291110804;
					continue;
				case 221u:
					SearchPatient_Admin.smethod_23(Label7, "Address : ");
					num = ((int)num2 * -1794004852) ^ -1691738657;
					continue;
				case 220u:
					SearchPatient_Admin.smethod_14((Control)(object)Label5, new Point(13, 134));
					SearchPatient_Admin.smethod_15((Control)(object)Label5, "Label5");
					num = ((int)num2 * -1581116725) ^ 0x3687BCB7;
					continue;
				case 219u:
					SearchPatient_Admin.smethod_15((Control)(object)SearchResultGrid, "SearchResultGrid");
					num = ((int)num2 * -375856041) ^ -197956985;
					continue;
				case 218u:
					SearchPatient_Admin.smethod_16((Control)(object)SearchResultGrid, new Size(853, 169));
					num = ((int)num2 * -449070558) ^ -942980153;
					continue;
				case 217u:
					SearchPatient_Admin.smethod_14((Control)(object)DOBTxt, new Point(124, 132));
					SearchPatient_Admin.smethod_40(DOBTxt, new DateTime(2019, 2, 11, 0, 0, 0, 0));
					num = ((int)num2 * -475045917) ^ -1884663103;
					continue;
				case 216u:
					num = ((int)num2 * -297657550) ^ 0x2B70787B;
					continue;
				case 215u:
					SearchPatient_Admin.smethod_42(DOBTxt, new DateTime(2019, 2, 11, 0, 0, 0, 0));
					SearchPatient_Admin.smethod_14((Control)(object)MobileTxt, new Point(554, 83));
					num = (int)((num2 * 2014126658) ^ 0x2AF880B);
					continue;
				case 214u:
					SearchPatient_Admin.smethod_33(SearchResultGrid, Color.White);
					SearchPatient_Admin.smethod_34(SearchResultGrid, (DataGridViewColumnHeadersHeightSizeMode)2);
					num = ((int)num2 * -830654441) ^ 0x38283676;
					continue;
				case 213u:
					num = (int)(num2 * 71384314) ^ -2099505466;
					continue;
				case 212u:
					num = ((int)num2 * -1685255931) ^ -1993520102;
					continue;
				case 211u:
					num = ((int)num2 * -2074041126) ^ -511063678;
					continue;
				case 210u:
					SearchPatient_Admin.smethod_15((Control)(object)NameTxt, "NameTxt");
					num = ((int)num2 * -912550531) ^ -237474612;
					continue;
				case 209u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_25((Control)(object)PatientInfoBox), (Control)(object)DOBTxt);
					num = (int)((num2 * 1889694717) ^ 0x6AC54676);
					continue;
				case 208u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_25((Control)(object)GroupBox1), (Control)(object)NameSTxt);
					num = ((int)num2 * -2061190177) ^ 0x14289532;
					continue;
				case 207u:
					SearchPatient_Admin.smethod_22((Control)(object)Label14, 8);
					num = ((int)num2 * -829263820) ^ -1092874784;
					continue;
				case 206u:
					SearchPatient_Admin.smethod_15((Control)(object)AddressTxt, "AddressTxt");
					SearchPatient_Admin.smethod_16((Control)(object)AddressTxt, new Size(258, 90));
					num = (int)(num2 * 987596267) ^ -1909592179;
					continue;
				case 205u:
					num = ((int)num2 * -1323389229) ^ 0x1F4D864C;
					continue;
				case 204u:
					num = (int)(num2 * 496638808) ^ -1127355909;
					continue;
				case 203u:
					num = (int)((num2 * 772099681) ^ 0x472024C7);
					continue;
				case 202u:
					num = ((int)num2 * -138310229) ^ -1927207879;
					continue;
				case 201u:
					Label14 = SearchPatient_Admin.smethod_4();
					num = ((int)num2 * -1092803633) ^ 0x45C3C30;
					continue;
				case 200u:
					SearchPatient_Admin.smethod_14((Control)(object)Label4, new Point(13, 43));
					num = (int)(num2 * 51868336) ^ -176728713;
					continue;
				case 199u:
					SearchPatient_Admin.smethod_16((Control)(object)Label1, new Size(330, 47));
					num = ((int)num2 * -20846087) ^ -2024441221;
					continue;
				case 198u:
					SearchPatient_Admin.smethod_14((Control)(object)PictureBox1, new Point(256, 19));
					num = ((int)num2 * -80663204) ^ -1802393716;
					continue;
				case 197u:
					SearchPatient_Admin.smethod_16((Control)(object)MobileTxt, new Size(258, 28));
					num = ((int)num2 * -229921646) ^ -109209483;
					continue;
				case 196u:
					SearchPatient_Admin.smethod_29((ButtonBase)(object)ClearBtn, Color.MidnightBlue);
					SearchPatient_Admin.smethod_21((Control)(object)ClearBtn, SearchPatient_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 500302470) ^ 0x24A72D3);
					continue;
				case 195u:
					SearchPatient_Admin.smethod_47((Control)(object)this, Color.White);
					num = (int)((num2 * 349116483) ^ 0x1008313F);
					continue;
				case 194u:
					SearchPatient_Admin.smethod_16((Control)(object)UpdateBtn, new Size(97, 37));
					num = ((int)num2 * -675136649) ^ 0x54C163A8;
					continue;
				case 193u:
					SearchPatient_Admin.smethod_22((Control)(object)NameSTxt, 1);
					num = ((int)num2 * -1928149969) ^ -1628520432;
					continue;
				case 192u:
					SearchPatient_Admin.smethod_24(Label2, (ContentAlignment)32);
					num = (int)((num2 * 2054208767) ^ 0x6D68F064);
					continue;
				case 191u:
					num = ((int)num2 * -231567929) ^ 0x347E1094;
					continue;
				case 190u:
					num = (int)(num2 * 506306233) ^ -769585285;
					continue;
				case 189u:
					num = (int)(num2 * 1751925515) ^ -658907804;
					continue;
				case 188u:
					Label2 = SearchPatient_Admin.smethod_4();
					SearchResultGrid = SearchPatient_Admin.smethod_8();
					num = (int)((num2 * 675988502) ^ 0x1520C24E);
					continue;
				case 187u:
					SearchPatient_Admin.smethod_14((Control)(object)Label1, new Point(392, 63));
					SearchPatient_Admin.smethod_15((Control)(object)Label1, "Label1");
					num = ((int)num2 * -513060038) ^ 0x7041A895;
					continue;
				case 186u:
					num = ((int)num2 * -342148959) ^ 0x732EFECA;
					continue;
				case 185u:
					SearchPatient_Admin.smethod_16((Control)(object)DOBTxt, new Size(166, 28));
					num = (int)((num2 * 1288354522) ^ 0x692F430C);
					continue;
				case 184u:
					SearchPatient_Admin.smethod_16((Control)(object)NameTxt, new Size(315, 28));
					num = ((int)num2 * -1018673495) ^ 0x4D8905A2;
					continue;
				case 183u:
					SearchPatient_Admin.smethod_15((Control)(object)Label6, "Label6");
					num = (int)((num2 * 1749741156) ^ 0x691659A2);
					continue;
				case 182u:
					num = (int)((num2 * 1382504627) ^ 0x3EC5BBBC);
					continue;
				case 181u:
					SearchPatient_Admin.smethod_22((Control)(object)ClearBtn, 15);
					num = (int)((num2 * 1604431297) ^ 0x8030F78);
					continue;
				case 180u:
					SearchPatient_Admin.smethod_21((Control)(object)PatientInfoBox, SearchPatient_Admin.smethod_20("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 540321724) ^ 0x5E25696A);
					continue;
				case 179u:
					SearchPatient_Admin.smethod_16((Control)(object)Label14, new Size(80, 25));
					num = (int)(num2 * 664879623) ^ -1740995425;
					continue;
				case 178u:
					SearchPatient_Admin.smethod_16((Control)(object)Label2, new Size(77, 28));
					SearchPatient_Admin.smethod_22((Control)(object)Label2, 0);
					num = ((int)num2 * -1193884181) ^ 0x708B4374;
					continue;
				case 177u:
					SearchPatient_Admin.smethod_14((Control)(object)AddressTxt, new Point(554, 128));
					num = ((int)num2 * -38460290) ^ -1364037920;
					continue;
				case 176u:
					SearchPatient_Admin.smethod_38((Control)(object)PatientInfoBox, bool_0: false);
					num = (int)((num2 * 1989297935) ^ 0x54399AF5);
					continue;
				case 175u:
					SearchPatient_Admin.smethod_53((Control)(object)GroupBox1);
					num = ((int)num2 * -1103526474) ^ -1966795606;
					continue;
				case 174u:
					SearchPatient_Admin.smethod_49((Control)(object)this, "SearchPatient_Admin");
					num = ((int)num2 * -1989255786) ^ -1884543954;
					continue;
				case 173u:
					num = ((int)num2 * -1368289884) ^ -1071527573;
					continue;
				case 172u:
					SearchPatient_Admin.smethod_14((Control)(object)MobileSTxt, new Point(120, 86));
					num = ((int)num2 * -681996523) ^ -2088971831;
					continue;
				case 171u:
					SearchPatient_Admin.smethod_21((Control)(object)SearchBtn, SearchPatient_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					SearchPatient_Admin.smethod_30((Control)(object)SearchBtn, Color.White);
					num = ((int)num2 * -390895624) ^ -840046666;
					continue;
				case 170u:
					num = (int)((num2 * 1867359841) ^ 0x74A5249C);
					continue;
				case 169u:
					SearchPatient_Admin.smethod_16((Control)(object)Label10, new Size(76, 28));
					num = (int)((num2 * 1800659194) ^ 0x4E02263F);
					continue;
				case 168u:
					num = (int)(num2 * 608346763) ^ -1821518743;
					continue;
				case 167u:
					DeleteBtn = SearchPatient_Admin.smethod_6();
					num = ((int)num2 * -1804554308) ^ -1721377870;
					continue;
				case 166u:
					SearchPatient_Admin.smethod_43(AddressTxt, bool_0: true);
					num = (int)((num2 * 869867164) ^ 0x7F49B300);
					continue;
				case 165u:
					num = (int)((num2 * 691593821) ^ 0x6F509B15);
					continue;
				case 164u:
					UpdateBtn = SearchPatient_Admin.smethod_6();
					num = (int)((num2 * 894303645) ^ 0x6DE983A7);
					continue;
				case 163u:
					num = ((int)num2 * -2084480065) ^ -656393875;
					continue;
				case 162u:
					num = ((int)num2 * -1858780828) ^ -149722254;
					continue;
				case 161u:
					num = (int)(num2 * 1902474420) ^ -1099721237;
					continue;
				case 160u:
					SearchPatient_Admin.smethod_44((TextBoxBase)(object)PIDTxt, bool_0: true);
					num = (int)((num2 * 1219652077) ^ 0x36ED8295);
					continue;
				case 159u:
					SearchPatient_Admin.smethod_24(Label10, (ContentAlignment)32);
					num = (int)((num2 * 1282348255) ^ 0x1625027C);
					continue;
				case 158u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_48((Control)(object)this), (Control)(object)DeleteBtn);
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_48((Control)(object)this), (Control)(object)UpdateBtn);
					num = ((int)num2 * -1676491700) ^ 0x286220D3;
					continue;
				case 157u:
					SearchPatient_Admin.smethod_15((Control)(object)Label10, "Label10");
					num = (int)(num2 * 147246236) ^ -421997390;
					continue;
				case 156u:
					SearchPatient_Admin.smethod_21((Control)(object)Label10, SearchPatient_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -2074346410) ^ -1339684835;
					continue;
				case 155u:
					num = ((int)num2 * -1854269833) ^ 0x40FBF6E9;
					continue;
				case 154u:
					SearchPatient_Admin.smethod_22((Control)(object)Label6, 2);
					num = ((int)num2 * -1905977220) ^ -1924855458;
					continue;
				case 153u:
					SearchPatient_Admin.smethod_16((Control)(object)PictureBox1, new Size(130, 125));
					num = (int)((num2 * 1682133607) ^ 0x5DA55AA3);
					continue;
				case 152u:
					SearchPatient_Admin.smethod_16((Control)(object)NameSTxt, new Size(237, 28));
					num = ((int)num2 * -1347341202) ^ 0x6C27C0D1;
					continue;
				case 151u:
					SearchPatient_Admin.smethod_23(Label10, "Mobile :");
					num = (int)((num2 * 1355014922) ^ 0x392D5E80);
					continue;
				case 150u:
					SearchPatient_Admin.smethod_14((Control)(object)NameSTxt, new Point(120, 44));
					num = ((int)num2 * -1307643634) ^ -1979611379;
					continue;
				case 149u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_25((Control)(object)PatientInfoBox), (Control)(object)Label10);
					num = ((int)num2 * -169389324) ^ -1671086831;
					continue;
				case 148u:
					SearchPatient_Admin.smethod_15((Control)(object)GroupBox1, "GroupBox1");
					SearchPatient_Admin.smethod_16((Control)(object)GroupBox1, new Size(623, 128));
					num = ((int)num2 * -1005445319) ^ -1788366630;
					continue;
				case 147u:
					SearchPatient_Admin.smethod_23(Label14, "Name :");
					num = ((int)num2 * -2142530376) ^ 0x69117391;
					continue;
				case 146u:
					SearchPatient_Admin.smethod_11((Control)(object)GroupBox1);
					SearchPatient_Admin.smethod_10((ISupportInitialize)SearchResultGrid);
					num = ((int)num2 * -1835266351) ^ 0x17D961D;
					continue;
				case 145u:
					num = ((int)num2 * -438900832) ^ 0x2F44B8FC;
					continue;
				case 144u:
					Label6 = SearchPatient_Admin.smethod_4();
					num = (int)(num2 * 1692040957) ^ -1622736969;
					continue;
				case 143u:
					SearchPatient_Admin.smethod_14((Control)(object)GroupBox1, new Point(155, 150));
					num = ((int)num2 * -338638543) ^ -350618654;
					continue;
				case 142u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_25((Control)(object)PatientInfoBox), (Control)(object)AddressTxt);
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_25((Control)(object)PatientInfoBox), (Control)(object)GenderTxt);
					num = ((int)num2 * -1121406631) ^ 0x65D352C1;
					continue;
				case 141u:
					SearchPatient_Admin.smethod_37(SearchPatient_Admin.smethod_36(SearchResultGrid), 24);
					num = (int)((num2 * 715647206) ^ 0x65C60566);
					continue;
				case 140u:
					SearchPatient_Admin.smethod_22((Control)(object)DeleteBtn, 17);
					num = ((int)num2 * -214822068) ^ -723760640;
					continue;
				case 139u:
					SearchPatient_Admin.smethod_15((Control)(object)Label2, "Label2");
					num = (int)((num2 * 2012952623) ^ 0x668B46DF);
					continue;
				case 138u:
					Label10 = SearchPatient_Admin.smethod_4();
					NameTxt = SearchPatient_Admin.smethod_7();
					num = (int)(num2 * 702674741) ^ -1644432633;
					continue;
				case 137u:
					SearchPatient_Admin.smethod_21((Control)(object)Label3, SearchPatient_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					SearchPatient_Admin.smethod_14((Control)(object)Label3, new Point(37, 87));
					num = ((int)num2 * -344780093) ^ 0x6BFBA534;
					continue;
				case 136u:
					SearchPatient_Admin.smethod_22((Control)(object)AddressTxt, 7);
					num = (int)((num2 * 746342112) ^ 0x9674BA0);
					continue;
				case 135u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_25((Control)(object)PatientInfoBox), (Control)(object)Label5);
					num = ((int)num2 * -54081162) ^ 0x2D051B18;
					continue;
				case 134u:
					num = ((int)num2 * -356478997) ^ -834873777;
					continue;
				case 133u:
					num = (int)(num2 * 287134113) ^ -1573064944;
					continue;
				case 132u:
					SearchPatient_Admin.smethod_16((Control)(object)PIDTxt, new Size(116, 28));
					num = ((int)num2 * -218478922) ^ 0x1DAB11A9;
					continue;
				case 131u:
					num = ((int)num2 * -1512239191) ^ -580817973;
					continue;
				case 130u:
					num = (int)((num2 * 966043993) ^ 0x1D3A7F53);
					continue;
				case 129u:
					MobileSTxt = SearchPatient_Admin.smethod_7();
					num = (int)((num2 * 1525591384) ^ 0x37275603);
					continue;
				case 128u:
					num = ((int)num2 * -1824614989) ^ 0x46D3A9FF;
					continue;
				case 127u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_25((Control)(object)PatientInfoBox), (Control)(object)Label7);
					num = ((int)num2 * -1179702837) ^ -1946022485;
					continue;
				case 126u:
					SearchPatient_Admin.smethod_21((Control)(object)Label5, SearchPatient_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1592640359) ^ 0x2C768DD7);
					continue;
				case 125u:
					num = ((int)num2 * -1908919556) ^ -561863712;
					continue;
				case 124u:
					SearchPatient_Admin.smethod_35(SearchResultGrid, bool_0: true);
					num = (int)((num2 * 1515572771) ^ 0x1FB4F6FF);
					continue;
				case 123u:
					SearchPatient_Admin.smethod_15((Control)(object)PIDTxt, "PIDTxt");
					num = ((int)num2 * -663029299) ^ 0x7B9C5655;
					continue;
				case 122u:
					SearchPatient_Admin.smethod_51((ISupportInitialize)SearchResultGrid);
					num = (int)((num2 * 1096921631) ^ 0x40FA39BF);
					continue;
				case 121u:
					SearchPatient_Admin.smethod_31((ButtonBase)(object)UpdateBtn, "Update");
					SearchPatient_Admin.smethod_32((ButtonBase)(object)UpdateBtn, bool_0: false);
					num = ((int)num2 * -1311349515) ^ -746726426;
					continue;
				case 120u:
					num = ((int)num2 * -9301573) ^ 0x3C2210FB;
					continue;
				case 119u:
					num = ((int)num2 * -1521768867) ^ 0x52A97CC1;
					continue;
				case 118u:
					num = ((int)num2 * -648702784) ^ -628575089;
					continue;
				case 117u:
					SearchPatient_Admin.smethod_52((Control)(object)PatientInfoBox, bool_0: false);
					SearchPatient_Admin.smethod_53((Control)(object)PatientInfoBox);
					SearchPatient_Admin.smethod_54((Control)(object)this, bool_0: false);
					num = (int)((num2 * 1703259336) ^ 0x2AE69787);
					continue;
				case 116u:
					SearchPatient_Admin.smethod_16((Control)(object)Label4, new Size(68, 25));
					num = ((int)num2 * -1198994097) ^ -946573053;
					continue;
				case 115u:
					num = ((int)num2 * -1039783598) ^ -592682860;
					continue;
				case 114u:
					SearchPatient_Admin.smethod_50((Control)(object)this, new Size(977, 804));
					SearchPatient_Admin.smethod_51((ISupportInitialize)PictureBox1);
					SearchPatient_Admin.smethod_52((Control)(object)GroupBox1, bool_0: false);
					num = (int)((num2 * 1230469854) ^ 0x1E434B17);
					continue;
				case 113u:
					num = ((int)num2 * -2067833828) ^ -1019606307;
					continue;
				case 112u:
					SearchPatient_Admin.smethod_22((Control)(object)NameTxt, 9);
					SearchPatient_Admin.smethod_21((Control)(object)Label14, SearchPatient_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 4830651) ^ 0x6F8C82BF);
					continue;
				case 111u:
					SearchPatient_Admin.smethod_16((Control)(object)DeleteBtn, new Size(97, 37));
					num = (int)(num2 * 2098524232) ^ -347136629;
					continue;
				case 110u:
					SearchPatient_Admin.smethod_28(GroupBox1, "Search Patient");
					num = (int)(num2 * 1685650219) ^ -1959990784;
					continue;
				case 109u:
					SearchPatient_Admin.smethod_16((Control)(object)GenderTxt, new Size(166, 28));
					SearchPatient_Admin.smethod_22((Control)(object)GenderTxt, 6);
					num = ((int)num2 * -1988728354) ^ 0x4F2DBA3;
					continue;
				case 108u:
					num = ((int)num2 * -1229357945) ^ 0x7B06A479;
					continue;
				case 107u:
					SearchPatient_Admin.smethod_15((Control)(object)MobileTxt, "MobileTxt");
					num = (int)((num2 * 990469040) ^ 0x1936E0D1);
					continue;
				case 106u:
					SearchPatient_Admin.smethod_14((Control)(object)DeleteBtn, new Point(815, 747));
					num = (int)(num2 * 1076916526) ^ -1647900068;
					continue;
				case 105u:
					SearchPatient_Admin.smethod_15((Control)(object)Label3, "Label3");
					num = ((int)num2 * -1822391335) ^ -992324016;
					continue;
				case 104u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_25((Control)(object)GroupBox1), (Control)(object)SearchBtn);
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_25((Control)(object)GroupBox1), (Control)(object)Label3);
					num = ((int)num2 * -1832950686) ^ 0xEDF8355;
					continue;
				case 103u:
					num = ((int)num2 * -1064996781) ^ -347414822;
					continue;
				case 102u:
					SearchPatient_Admin.smethod_22((Control)(object)Label4, 0);
					SearchPatient_Admin.smethod_23(Label4, "PID :");
					num = (int)((num2 * 797358908) ^ 0x5ACB41A9);
					continue;
				case 101u:
					SearchPatient_Admin.smethod_22((Control)(object)Label7, 3);
					num = (int)(num2 * 1040178239) ^ -344045176;
					continue;
				case 100u:
					num = ((int)num2 * -339538902) ^ -1840283971;
					continue;
				case 99u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_25((Control)(object)GroupBox1), (Control)(object)MobileSTxt);
					num = ((int)num2 * -1053867148) ^ -1310266575;
					continue;
				case 98u:
					num = (int)(num2 * 23717310) ^ -28703555;
					continue;
				case 97u:
					num = ((int)num2 * -1490373538) ^ 0x77160597;
					continue;
				case 96u:
					num = ((int)num2 * -1331460271) ^ -628765754;
					continue;
				case 95u:
					num = (int)(num2 * 2085145785) ^ -1210825270;
					continue;
				case 94u:
					SearchPatient_Admin.smethod_15((Control)(object)DeleteBtn, "DeleteBtn");
					num = ((int)num2 * -1055318974) ^ -1235459426;
					continue;
				case 93u:
					num = (int)(num2 * 703650692) ^ -1153203025;
					continue;
				case 92u:
					num = ((int)num2 * -579714769) ^ 0x770BA731;
					continue;
				case 91u:
					num = (int)(num2 * 822534817) ^ -960745737;
					continue;
				case 90u:
					AddressTxt = SearchPatient_Admin.smethod_7();
					num = (int)(num2 * 1221334350) ^ -1272776586;
					continue;
				case 89u:
					num = ((int)num2 * -1317702783) ^ 0x48A1581E;
					continue;
				case 88u:
					SearchPatient_Admin.smethod_23(Label2, "Name : ");
					num = (int)((num2 * 1998991325) ^ 0x2AC2EC8E);
					continue;
				case 87u:
					num = ((int)num2 * -107766656) ^ -1582140636;
					continue;
				case 86u:
					SearchPatient_Admin.smethod_22((Control)(object)Label1, 10);
					SearchPatient_Admin.smethod_23(Label1, "Search Patient");
					num = (int)((num2 * 1179550457) ^ 0x7189EE84);
					continue;
				case 85u:
					SearchPatient_Admin.smethod_22((Control)(object)Label10, 10);
					num = (int)(num2 * 841434818) ^ -2144378291;
					continue;
				case 84u:
					DOBTxt = SearchPatient_Admin.smethod_9();
					num = ((int)num2 * -479382855) ^ -1707367151;
					continue;
				case 83u:
					num = ((int)num2 * -1944310082) ^ 0xB2C3AC2;
					continue;
				case 82u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_48((Control)(object)this), (Control)(object)ClearBtn);
					num = ((int)num2 * -1920950297) ^ -881999178;
					continue;
				case 81u:
					Label4 = SearchPatient_Admin.smethod_4();
					num = (int)((num2 * 1057694117) ^ 0x53247162);
					continue;
				case 80u:
					num = ((int)num2 * -1368178128) ^ 0x935DD03;
					continue;
				case 79u:
					SearchPatient_Admin.smethod_21((Control)(object)GroupBox1, SearchPatient_Admin.smethod_20("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 748143962) ^ -1202667656;
					continue;
				case 78u:
					SearchPatient_Admin.smethod_45((ContainerControl)(object)this, new SizeF(8f, 16f));
					SearchPatient_Admin.smethod_46((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -1441891236) ^ 0x1D7BEE09;
					continue;
				case 77u:
					SearchPatient_Admin.smethod_23(Label5, "DOB :");
					num = ((int)num2 * -1974206041) ^ -557824084;
					continue;
				case 76u:
					SearchPatient_Admin.smethod_22((Control)(object)UpdateBtn, 16);
					num = (int)((num2 * 905606037) ^ 0x1A8A571B);
					continue;
				case 75u:
					num = ((int)num2 * -463191931) ^ 0x3E086948;
					continue;
				case 74u:
					num = (int)(num2 * 28314127) ^ -1224619184;
					continue;
				case 73u:
					SearchPatient_Admin.smethod_14((Control)(object)ClearBtn, new Point(546, 747));
					SearchPatient_Admin.smethod_15((Control)(object)ClearBtn, "ClearBtn");
					num = ((int)num2 * -1011385234) ^ -895413826;
					continue;
				case 72u:
					SearchPatient_Admin.smethod_22((Control)(object)GroupBox1, 11);
					num = ((int)num2 * -1704505643) ^ -1631829693;
					continue;
				case 71u:
					num = (int)(num2 * 862019082) ^ -1017006540;
					continue;
				case 70u:
					SearchPatient_Admin.smethod_22((Control)(object)PIDTxt, 4);
					num = (int)((num2 * 875140404) ^ 0x491D3697);
					continue;
				case 69u:
					SearchPatient_Admin.smethod_22((Control)(object)Label5, 1);
					num = (int)(num2 * 775334558) ^ -1282040496;
					continue;
				case 68u:
					SearchPatient_Admin.smethod_38((Control)(object)UpdateBtn, bool_0: false);
					num = (int)(num2 * 658692651) ^ -1260100581;
					continue;
				case 67u:
					SearchPatient_Admin.smethod_15((Control)(object)Label4, "Label4");
					num = (int)((num2 * 921760653) ^ 0x70BCFC0B);
					continue;
				case 66u:
					SearchPatient_Admin.smethod_22((Control)(object)DOBTxt, 12);
					num = (int)(num2 * 1146137218) ^ -1284923594;
					continue;
				case 65u:
					num = ((int)num2 * -82798801) ^ -720758245;
					continue;
				case 64u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_48((Control)(object)this), (Control)(object)GroupBox1);
					num = (int)(num2 * 1374157544) ^ -589959235;
					continue;
				case 63u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_48((Control)(object)this), (Control)(object)SearchResultGrid);
					num = (int)(num2 * 43068770) ^ -674708794;
					continue;
				case 62u:
					SearchPatient_Admin.smethod_21((Control)(object)DeleteBtn, SearchPatient_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -144936489) ^ -446274682;
					continue;
				case 61u:
					SearchPatient_Admin.smethod_16((Control)(object)Label3, new Size(77, 28));
					num = ((int)num2 * -1055749753) ^ -1315538855;
					continue;
				case 60u:
					SearchPatient_Admin.smethod_16((Control)(object)MobileSTxt, new Size(237, 28));
					num = (int)(num2 * 573591281) ^ -1282652238;
					continue;
				case 59u:
					SearchPatient_Admin.smethod_31((ButtonBase)(object)ClearBtn, "Clear");
					SearchPatient_Admin.smethod_32((ButtonBase)(object)ClearBtn, bool_0: false);
					num = (int)(num2 * 1300387560) ^ -1672632203;
					continue;
				case 58u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_25((Control)(object)PatientInfoBox), (Control)(object)Label4);
					num = (int)(num2 * 2037206859) ^ -79034240;
					continue;
				case 57u:
					Label3 = SearchPatient_Admin.smethod_4();
					num = (int)(num2 * 1174555749) ^ -81413759;
					continue;
				case 56u:
					SearchPatient_Admin.smethod_30((Control)(object)DeleteBtn, Color.White);
					num = ((int)num2 * -748812708) ^ -1626787599;
					continue;
				case 55u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_25((Control)(object)GroupBox1), (Control)(object)Label2);
					num = (int)(num2 * 1903171496) ^ -1088377137;
					continue;
				case 54u:
					SearchPatient_Admin.smethod_14((Control)(object)NameTxt, new Point(124, 89));
					num = ((int)num2 * -325337328) ^ 0x16974351;
					continue;
				case 53u:
					num = (int)((num2 * 749491245) ^ 0xFA23842);
					continue;
				case 52u:
					SearchPatient_Admin.smethod_31((ButtonBase)(object)DeleteBtn, "Delete");
					num = (int)((num2 * 1788602277) ^ 0x40D43257);
					continue;
				case 51u:
					NameSTxt = SearchPatient_Admin.smethod_7();
					num = (int)((num2 * 323413295) ^ 0x1F14A8BD);
					continue;
				case 50u:
					num = ((int)num2 * -1377815924) ^ 0x2EDDB49C;
					continue;
				case 49u:
					SearchPatient_Admin.smethod_22((Control)(object)MobileTxt, 11);
					num = ((int)num2 * -1631454932) ^ -2067185172;
					continue;
				case 48u:
					num = (int)((num2 * 758088744) ^ 0x5AF4FFCF);
					continue;
				case 47u:
					SearchPatient_Admin.smethod_27(PatientInfoBox, bool_0: false);
					SearchPatient_Admin.smethod_28(PatientInfoBox, "Patient Information");
					num = ((int)num2 * -1607279687) ^ -1334045901;
					continue;
				case 46u:
					SearchPatient_Admin.smethod_16((Control)(object)ClearBtn, new Size(97, 37));
					num = ((int)num2 * -1248726364) ^ 0x7F5A96F4;
					continue;
				case 45u:
					SearchPatient_Admin.smethod_14((Control)(object)Label10, new Point(472, 86));
					num = ((int)num2 * -609303254) ^ 0x2F3B27B2;
					continue;
				case 44u:
					SearchPatient_Admin.smethod_13(PictureBox1, (Image)(object)Resources.patient_pic);
					num = ((int)num2 * -1089511495) ^ -2035580158;
					continue;
				case 43u:
					Label1 = SearchPatient_Admin.smethod_4();
					GroupBox1 = SearchPatient_Admin.smethod_5();
					num = ((int)num2 * -1495510061) ^ 0x4827C9F4;
					continue;
				case 42u:
					SearchBtn = SearchPatient_Admin.smethod_6();
					num = (int)(num2 * 2144664975) ^ -1844585151;
					continue;
				case 41u:
					num = (int)(num2 * 723060689) ^ -2143035932;
					continue;
				case 40u:
					GenderTxt = SearchPatient_Admin.smethod_7();
					num = (int)((num2 * 713793120) ^ 0x6D4CC67E);
					continue;
				case 39u:
					SearchPatient_Admin.smethod_38((Control)(object)DeleteBtn, bool_0: false);
					num = ((int)num2 * -2083311259) ^ 0x1DF7362;
					continue;
				case 38u:
					SearchPatient_Admin.smethod_38((Control)(object)SearchResultGrid, bool_0: false);
					num = (int)((num2 * 571908215) ^ 0x6823AC3E);
					continue;
				case 37u:
					num = (int)(num2 * 1245627963) ^ -452948133;
					continue;
				case 36u:
					SearchPatient_Admin.smethod_14((Control)(object)Label7, new Point(452, 132));
					num = ((int)num2 * -1368099216) ^ -725943244;
					continue;
				case 35u:
					num = ((int)num2 * -510938442) ^ 0x5547FC59;
					continue;
				case 34u:
					SearchPatient_Admin.smethod_22((Control)(object)Label3, 3);
					num = ((int)num2 * -1953051213) ^ 0x69D36A81;
					continue;
				case 33u:
					SearchPatient_Admin.smethod_29((ButtonBase)(object)SearchBtn, Color.MidnightBlue);
					num = (int)(num2 * 897128093) ^ -1494117530;
					continue;
				case 32u:
					ClearBtn = SearchPatient_Admin.smethod_6();
					num = ((int)num2 * -2106444341) ^ 0x6F3AFD0F;
					continue;
				case 31u:
					num = (int)((num2 * 1373174458) ^ 0x1D3C2296);
					continue;
				case 30u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_25((Control)(object)PatientInfoBox), (Control)(object)NameTxt);
					num = ((int)num2 * -1248604821) ^ -1374062842;
					continue;
				case 29u:
					SearchPatient_Admin.smethod_39(DOBTxt, (DateTimePickerFormat)2);
					num = (int)((num2 * 1694068497) ^ 0x2AF86D0B);
					continue;
				case 28u:
					num = (int)((num2 * 300608459) ^ 0x6D01FAA);
					continue;
				case 27u:
					SearchPatient_Admin.smethod_14((Control)(object)SearchBtn, new Point(468, 82));
					num = (int)((num2 * 1108113012) ^ 0x7AB59A08);
					continue;
				case 26u:
					SearchPatient_Admin.smethod_15((Control)(object)DOBTxt, "DOBTxt");
					num = ((int)num2 * -908499087) ^ -1577203756;
					continue;
				case 25u:
					num = ((int)num2 * -141960946) ^ -1351787045;
					continue;
				case 24u:
					num = (int)((num2 * 1769749427) ^ 0x7144CA77);
					continue;
				case 23u:
					SearchPatient_Admin.smethod_16((Control)(object)Label7, new Size(96, 26));
					num = (int)(num2 * 886477995) ^ -1061956622;
					continue;
				case 22u:
					SearchPatient_Admin.smethod_11((Control)(object)PatientInfoBox);
					num = (int)((num2 * 1246868025) ^ 0x7056DBCA);
					continue;
				case 21u:
					num = ((int)num2 * -858667574) ^ -194375376;
					continue;
				case 20u:
					num = (int)((num2 * 1380900223) ^ 0x22F3D776);
					continue;
				case 19u:
					SearchPatient_Admin.smethod_24(Label1, (ContentAlignment)32);
					num = ((int)num2 * -609295081) ^ -967967033;
					continue;
				case 18u:
					SearchPatient_Admin.smethod_15((Control)(object)MobileSTxt, "MobileSTxt");
					num = (int)((num2 * 1110501035) ^ 0x1CECB429);
					continue;
				case 17u:
					num = (int)((num2 * 1909684745) ^ 0x43DAEAE);
					continue;
				case 16u:
					num = (int)(num2 * 1593734882) ^ -935497834;
					continue;
				case 15u:
					num = ((int)num2 * -1137080583) ^ 0x4C6F132C;
					continue;
				case 14u:
					SearchPatient_Admin.smethod_30((Control)(object)UpdateBtn, Color.White);
					SearchPatient_Admin.smethod_14((Control)(object)UpdateBtn, new Point(681, 747));
					num = ((int)num2 * -2119245830) ^ 0x554BB283;
					continue;
				case 13u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_25((Control)(object)PatientInfoBox), (Control)(object)PIDTxt);
					num = ((int)num2 * -1757701651) ^ -1751710118;
					continue;
				case 11u:
					SearchPatient_Admin.smethod_14((Control)(object)Label14, new Point(13, 89));
					num = ((int)num2 * -2084731803) ^ -980447699;
					continue;
				case 10u:
					SearchPatient_Admin.smethod_15((Control)(object)UpdateBtn, "UpdateBtn");
					num = (int)(num2 * 1259240458) ^ -396408353;
					continue;
				case 9u:
					SearchPatient_Admin.smethod_15((Control)(object)SearchBtn, "SearchBtn");
					num = ((int)num2 * -702333030) ^ 0x3A0BAFF9;
					continue;
				case 8u:
					SearchPatient_Admin.smethod_10((ISupportInitialize)PictureBox1);
					num = (int)((num2 * 739005074) ^ 0xE72B327);
					continue;
				case 7u:
					SearchPatient_Admin.smethod_26(SearchPatient_Admin.smethod_25((Control)(object)PatientInfoBox), (Control)(object)Label6);
					num = ((int)num2 * -760878493) ^ -1587262831;
					continue;
				case 6u:
					SearchPatient_Admin.smethod_17(PictureBox1, (PictureBoxSizeMode)1);
					num = (int)(num2 * 1631113262) ^ -453572881;
					continue;
				case 5u:
					num = (int)((num2 * 61238874) ^ 0x6D29268C);
					continue;
				case 4u:
					num = ((int)num2 * -389079368) ^ 0x68C10ED5;
					continue;
				case 3u:
					PictureBox1 = SearchPatient_Admin.smethod_3();
					num = ((int)num2 * -427534008) ^ 0xB974154;
					continue;
				case 2u:
					SearchPatient_Admin.smethod_15((Control)(object)PatientInfoBox, "PatientInfoBox");
					SearchPatient_Admin.smethod_16((Control)(object)PatientInfoBox, new Size(860, 231));
					SearchPatient_Admin.smethod_22((Control)(object)PatientInfoBox, 13);
					num = ((int)num2 * -97509664) ^ 0x71EF5A46;
					continue;
				case 1u:
					PatientInfoBox = SearchPatient_Admin.smethod_5();
					num = ((int)num2 * -896787416) ^ 0x3C2E9004;
					continue;
				case 0u:
					MobileTxt = SearchPatient_Admin.smethod_7();
					num = (int)(num2 * 561382050) ^ -793235437;
					continue;
				default:
					return;
				case 12u:
					break;
				case 262u:
					return;
				}
				break;
			}
		}
	}

	private void SearchPatient_Admin_Load(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 1256649547;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD16A1Fu) % 5u)
				{
				case 4u:
					HideItemsOnForm();
					SearchPatient_Admin.smethod_40(DOBTxt, SearchPatient_Admin.smethod_62(SearchPatient_Admin.smethod_61((object)DateTime.Now, "dd-MM-yyyy")));
					num = ((int)num2 * -1119505579) ^ 0x1D72F2AB;
					continue;
				case 1u:
					SearchPatient_Admin.smethod_60(myconnection, SearchPatient_Admin.smethod_59(MyProject.Forms.Form1.provider, MyProject.Forms.Form1.datafile));
					num = (int)(num2 * 803133186) ^ -744941613;
					continue;
				case 0u:
					num = (int)((num2 * 1722515553) ^ 0x6DCFFB0A);
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

	private void SearchBtn_Click(object sender, EventArgs e)
	{
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		if (!MyProject.Forms.Form1.Name_Validation(SearchPatient_Admin.smethod_64(SearchPatient_Admin.smethod_63(NameSTxt))) | !MyProject.Forms.Form1.Mobile_Validator(SearchPatient_Admin.smethod_64(SearchPatient_Admin.smethod_63(MobileSTxt))))
		{
			goto IL_005f;
		}
		goto IL_00a9;
		IL_00a9:
		HideItemsOnForm();
		SearchPatient_Admin.smethod_66();
		string string_ = SearchPatient_Admin.smethod_67(new string[5]
		{
			"Select * From [Patient] Where [Name] Like '%",
			SearchPatient_Admin.smethod_64(SearchPatient_Admin.smethod_63(NameSTxt)),
			"%' And [Mobile] Like '%",
			SearchPatient_Admin.smethod_63(MobileSTxt),
			"%';"
		});
		int num = -622539610;
		goto IL_007f;
		IL_007f:
		DataTable dataTable = default(DataTable);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xBB46ADEDu) % 6u)
			{
			case 5u:
				dataTable = SearchPatient_Admin.smethod_68();
				num = ((int)num2 * -1007453746) ^ 0x39006240;
				continue;
			case 2u:
				break;
			case 1u:
				SearchPatient_Admin.smethod_65("No Results Found");
				num = (int)((num2 * 1599141152) ^ 0x386B2F19);
				continue;
			case 0u:
				goto IL_00a9;
			default:
				SearchPatient_Admin.smethod_69(myconnection);
				try
				{
					OleDbDataAdapter dbDataAdapter_ = SearchPatient_Admin.smethod_70(string_, myconnection);
					while (true)
					{
						int num3 = -1641891050;
						while (true)
						{
							switch ((num2 = (uint)num3 ^ 0xBB46ADEDu) % 10u)
							{
							case 9u:
								SearchPatient_Admin.smethod_74(myconnection);
								num3 = ((int)num2 * -2070084717) ^ 0x16FA373D;
								continue;
							case 8u:
								num3 = -1715707061;
								continue;
							case 7u:
							{
								int num4;
								int num5;
								if (SearchPatient_Admin.smethod_73(SearchResultGrid) != 1)
								{
									num4 = 2030972033;
									num5 = 2030972033;
								}
								else
								{
									num4 = 1008427879;
									num5 = 1008427879;
								}
								num3 = num4 ^ (int)(num2 * 346419950);
								continue;
							}
							case 6u:
								SearchPatient_Admin.smethod_38((Control)(object)SearchResultGrid, bool_0: true);
								num3 = ((int)num2 * -309429218) ^ 0x32D5C9D0;
								continue;
							case 5u:
								SearchPatient_Admin.smethod_71((DbDataAdapter)(object)dbDataAdapter_, dataTable);
								SearchPatient_Admin.smethod_72(SearchResultGrid, (object)dataTable);
								num3 = ((int)num2 * -942930777) ^ -1908724217;
								continue;
							case 2u:
								SearchPatient_Admin.smethod_65("No Result Found");
								num3 = ((int)num2 * -1069013843) ^ 0x7FED6CF8;
								continue;
							case 1u:
								num3 = (int)(num2 * 244072144) ^ -696172031;
								continue;
							case 0u:
								break;
							default:
								SearchPatient_Admin.smethod_74(myconnection);
								name_search = SearchPatient_Admin.smethod_64(SearchPatient_Admin.smethod_63(NameSTxt));
								mobile_search = SearchPatient_Admin.smethod_63(MobileSTxt);
								return;
							case 4u:
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
			case 4u:
				return;
			}
			break;
		}
		goto IL_005f;
		IL_005f:
		num = -1258532722;
		goto IL_007f;
	}

	private bool HideItemsOnForm()
	{
		bool result = default(bool);
		while (true)
		{
			int num = -1289262918;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCB32018Eu) % 7u)
				{
				case 5u:
					SearchPatient_Admin.smethod_38((Control)(object)PatientInfoBox, bool_0: false);
					num = ((int)num2 * -1831380796) ^ -2110974523;
					continue;
				case 4u:
					SearchPatient_Admin.smethod_38((Control)(object)SearchResultGrid, bool_0: false);
					num = (int)((num2 * 438530877) ^ 0x70CDA5EC);
					continue;
				case 3u:
					SearchPatient_Admin.smethod_38((Control)(object)DeleteBtn, bool_0: false);
					result = true;
					num = ((int)num2 * -1110024767) ^ 0x4ABB95CC;
					continue;
				case 2u:
					SearchPatient_Admin.smethod_38((Control)(object)ClearBtn, bool_0: false);
					SearchPatient_Admin.smethod_38((Control)(object)UpdateBtn, bool_0: false);
					num = ((int)num2 * -771528081) ^ -458048663;
					continue;
				case 1u:
					num = (int)((num2 * 1491465582) ^ 0xB4AC8F1);
					continue;
				case 6u:
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
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected I4, but got Unknown
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected I4, but got Unknown
		//IL_01f7: Incompatible stack heights: 0 vs 1
		//IL_020c: Incompatible stack heights: 0 vs 1
		//IL_0213: Incompatible stack heights: 0 vs 1
		if (SearchPatient_Admin.smethod_77(SearchPatient_Admin.smethod_63(PIDTxt), "", bool_0: false) == 0)
		{
			goto IL_0081;
		}
		goto IL_00ce;
		IL_00ce:
		int num = -1603344544;
		goto IL_009c;
		IL_009c:
		string string_ = default(string);
		OleDbCommand val = default(OleDbCommand);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xB5A22C61u) % 8u)
			{
			case 7u:
				SearchPatient_Admin.smethod_65("Nothing To Delete");
				num = ((int)num2 * -1327521012) ^ -977008571;
				continue;
			case 6u:
				string_ = SearchPatient_Admin.smethod_78("Delete From [Patient] Where [PID] = ", SearchPatient_Admin.smethod_63(PIDTxt), ";");
				num = (int)(num2 * 1054771861) ^ -890785998;
				continue;
			case 5u:
				SearchPatient_Admin.smethod_69(myconnection);
				num = (int)(num2 * 1394815432) ^ -1712912718;
				continue;
			case 2u:
				break;
			case 1u:
				val = SearchPatient_Admin.smethod_66();
				num = (int)(num2 * 334832745) ^ -1052793138;
				continue;
			case 4u:
				goto IL_00ce;
			default:
				try
				{
					while (true)
					{
						int num3 = -768324137;
						while (true)
						{
							switch ((num2 = (uint)num3 ^ 0xB5A22C61u) % 8u)
							{
							case 6u:
								val = SearchPatient_Admin.smethod_79(string_, myconnection);
								SearchPatient_Admin.smethod_80(val);
								num3 = (int)((num2 * 4554456) ^ 0x207FABA);
								continue;
							case 5u:
								UpdateTable();
								num3 = (int)((num2 * 296400373) ^ 0x196CCA09);
								continue;
							case 4u:
								num3 = ((int)num2 * -160427093) ^ 0x2589AE28;
								continue;
							case 3u:
								SearchPatient_Admin.smethod_81((Component)(object)val);
								num3 = ((int)num2 * -1259885627) ^ 0x296D2F86;
								continue;
							case 1u:
								ClearPatientInfo();
								num3 = (int)((num2 * 1760102102) ^ 0x534E63C0);
								continue;
							case 0u:
								SearchPatient_Admin.smethod_74(myconnection);
								num3 = ((int)num2 * -138049446) ^ -1602515027;
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
					SearchPatient_Admin.smethod_74(myconnection);
					while (true)
					{
						_ = -1016701792;
						while (true)
						{
							_003F val2 = /*Error near IL_01cd: Stack underflow*/^ -1247663007;
							num2 = (uint)(int)val2;
							switch (val2 % 4)
							{
							default:
								return;
							case 1:
								_ = ((int)num2 * -790501321) ^ -315214902;
								continue;
							case 0:
								SearchPatient_Admin.smethod_76();
								_ = ((int)num2 * -1889677620) ^ -1512366641;
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
				return;
			}
			break;
		}
		goto IL_0081;
		IL_0081:
		num = -66420378;
		goto IL_009c;
	}

	private void UpdateBtn_Click(object sender, EventArgs e)
	{
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected I4, but got Unknown
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Expected I4, but got Unknown
		//IL_03ae: Incompatible stack heights: 0 vs 1
		//IL_03b5: Incompatible stack heights: 0 vs 1
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		DateTime dateTime_ = default(DateTime);
		bool flag = default(bool);
		OleDbCommand val = default(OleDbCommand);
		string string_ = default(string);
		while (true)
		{
			int num = -1873702472;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCD51299Bu) % 10u)
				{
				case 8u:
					dateTime_ = SearchPatient_Admin.smethod_62(SearchPatient_Admin.smethod_61((object)SearchPatient_Admin.smethod_82(DOBTxt), "dd-MM-yyyy"));
					num = (int)((num2 * 768946838) ^ 0x62902518);
					continue;
				case 7u:
				{
					int num6;
					int num7;
					if (!((SearchPatient_Admin.smethod_77(SearchPatient_Admin.smethod_63(NameTxt), "", bool_0: false) == 0) | (SearchPatient_Admin.smethod_77(SearchPatient_Admin.smethod_63(MobileSTxt), "", bool_0: false) == 0) | (SearchPatient_Admin.smethod_77(SearchPatient_Admin.smethod_63(GenderTxt), "", bool_0: false) == 0) | (SearchPatient_Admin.smethod_77(SearchPatient_Admin.smethod_63(AddressTxt), "", bool_0: false) == 0)))
					{
						num6 = 184166765;
						num7 = 184166765;
					}
					else
					{
						num6 = 1004404354;
						num7 = 1004404354;
					}
					num = num6 ^ (int)(num2 * 2010231658);
					continue;
				}
				case 6u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -1900495626;
						num5 = -1900495626;
					}
					else
					{
						num4 = -453743442;
						num5 = -453743442;
					}
					num = num4 ^ (int)(num2 * 1266115429);
					continue;
				}
				case 3u:
					val = SearchPatient_Admin.smethod_66();
					num = -43328031;
					continue;
				case 2u:
					flag = !(MyProject.Forms.Form1.Name_Validation(SearchPatient_Admin.smethod_64(SearchPatient_Admin.smethod_63(NameTxt))) & MyProject.Forms.Form1.Mobile_Validator(SearchPatient_Admin.smethod_63(MobileSTxt)) & MyProject.Forms.Form1.Gender_Validator(SearchPatient_Admin.smethod_64(SearchPatient_Admin.smethod_63(GenderTxt))));
					num = -1234886205;
					continue;
				case 1u:
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
					SearchPatient_Admin.smethod_69(myconnection);
					num = ((int)num2 * -119444792) ^ 0x6745DD51;
					continue;
				case 4u:
					break;
				default:
					try
					{
						while (true)
						{
							int num3 = -1880447024;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xCD51299Bu) % 10u)
								{
								case 9u:
									SearchPatient_Admin.smethod_65("Successfully Updated Details");
									num3 = ((int)num2 * -672058175) ^ -1859643684;
									continue;
								case 8u:
									SearchPatient_Admin.smethod_74(myconnection);
									num3 = (int)((num2 * 1071020552) ^ 0x31FA437E);
									continue;
								case 6u:
									UpdateTable();
									num3 = ((int)num2 * -935365491) ^ -1967575676;
									continue;
								case 5u:
									val = SearchPatient_Admin.smethod_79(string_, myconnection);
									num3 = ((int)num2 * -341084332) ^ 0x14B5F8BF;
									continue;
								case 4u:
									ClearPatientInfo();
									num3 = (int)((num2 * 42495631) ^ 0x6847468B);
									continue;
								case 3u:
									SearchPatient_Admin.smethod_81((Component)(object)val);
									num3 = (int)(num2 * 262324693) ^ -534026894;
									continue;
								case 2u:
									SearchPatient_Admin.smethod_80(val);
									num3 = (int)((num2 * 1853859327) ^ 0x5C14F1DA);
									continue;
								case 1u:
									num3 = (int)((num2 * 1360143967) ^ 0x715C4ADF);
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
						SearchPatient_Admin.smethod_75(exception_);
						while (true)
						{
							_ = -744121759;
							while (true)
							{
								_003F val2 = /*Error near IL_0378: Stack underflow*/^ -850318949;
								num2 = (uint)(int)val2;
								switch (val2 % 3)
								{
								default:
									return;
								case 1:
									SearchPatient_Admin.smethod_74(myconnection);
									SearchPatient_Admin.smethod_76();
									_ = ((int)num2 * -1781472783) ^ 0x5306F131;
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
				case 5u:
					SearchPatient_Admin.smethod_65("Invalid Credentials");
					return;
				case 9u:
					SearchPatient_Admin.smethod_65("Empty Fields Not Allowed");
					return;
				}
				break;
			}
		}
	}

	private void ClearBtn_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -768690708;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD1D28BA8u) % 3u)
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
				ClearPatientInfo();
				num = (int)(num2 * 516334507) ^ -522621564;
			}
		}
	}

	private bool UpdateTable()
	{
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected I4, but got Unknown
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected I4, but got Unknown
		//IL_0239: Incompatible stack heights: 0 vs 1
		//IL_0249: Incompatible stack heights: 0 vs 1
		//IL_0250: Incompatible stack heights: 0 vs 1
		string string_ = default(string);
		DataTable dataTable = default(DataTable);
		bool flag = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = -1142139343;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE9771195u) % 5u)
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
					num = ((int)num2 * -1229336999) ^ 0x9CDE763;
					continue;
				case 2u:
					SearchPatient_Admin.smethod_66();
					num = ((int)num2 * -298424907) ^ -718138631;
					continue;
				case 1u:
					dataTable = SearchPatient_Admin.smethod_68();
					SearchPatient_Admin.smethod_69(myconnection);
					num = ((int)num2 * -141706905) ^ -1259545800;
					continue;
				case 4u:
					break;
				default:
					try
					{
						while (true)
						{
							IL_01e4:
							int num3 = -684748106;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xE9771195u) % 11u)
								{
								case 10u:
									SearchPatient_Admin.smethod_74(myconnection);
									num3 = ((int)num2 * -537156642) ^ 0x64F132D8;
									continue;
								case 9u:
									SearchPatient_Admin.smethod_74(myconnection);
									num3 = ((int)num2 * -1533921809) ^ -1582194653;
									continue;
								case 8u:
									SearchPatient_Admin.smethod_38((Control)(object)SearchResultGrid, bool_0: true);
									num3 = -535707935;
									continue;
								case 5u:
								{
									int num4;
									int num5;
									if (!flag)
									{
										num4 = 1377126488;
										num5 = 1377126488;
									}
									else
									{
										num4 = 2068377973;
										num5 = 2068377973;
									}
									num3 = num4 ^ ((int)num2 * -817828332);
									continue;
								}
								case 4u:
									result = false;
									num3 = ((int)num2 * -1162557098) ^ 0x550BBF65;
									continue;
								case 3u:
									num3 = (int)((num2 * 1336506531) ^ 0x106B76B3);
									continue;
								case 2u:
									num3 = (int)((num2 * 305221221) ^ 0x1762EE61);
									continue;
								case 1u:
								{
									OleDbDataAdapter dbDataAdapter_ = SearchPatient_Admin.smethod_70(string_, myconnection);
									SearchPatient_Admin.smethod_71((DbDataAdapter)(object)dbDataAdapter_, dataTable);
									SearchPatient_Admin.smethod_72(SearchResultGrid, (object)dataTable);
									flag = SearchPatient_Admin.smethod_73(SearchResultGrid) == 1;
									num3 = (int)(num2 * 1767462419) ^ -783375867;
									continue;
								}
								default:
									goto end_IL_01a5;
								case 0u:
									break;
								case 6u:
									goto end_IL_01a5;
								case 7u:
									return result;
								}
								goto IL_01e4;
								continue;
								end_IL_01a5:
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
							IL_024b:
							_ = -1138103744;
							while (true)
							{
								_003F val = /*Error near IL_0204: Stack underflow*/^ -378072683;
								num2 = (uint)(int)val;
								switch (val % 4)
								{
								case 3:
									SearchPatient_Admin.smethod_74(myconnection);
									_ = (num2 * 1709437023) ^ 0x201A26E;
									continue;
								case 1:
									_ = (num2 * 1533312915) ^ 0xF75364D9u;
									continue;
								case 0:
									break;
								default:
									SearchPatient_Admin.smethod_76();
									goto end_IL_01fe;
								}
								goto IL_024b;
								continue;
								end_IL_01fe:
								break;
							}
							break;
						}
					}
					while (true)
					{
						int num6 = -1401980196;
						while (true)
						{
							switch ((num2 = (uint)num6 ^ 0xE9771195u) % 4u)
							{
							case 2u:
								num6 = (int)(num2 * 1144512265) ^ -1530576604;
								continue;
							case 1u:
								result = false;
								num6 = ((int)num2 * -2104889260) ^ -1099011665;
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
				break;
			}
		}
	}

	private void SearchResultGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Expected I4, but got Unknown
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected I4, but got Unknown
		//IL_02e1: Incompatible stack heights: 0 vs 1
		//IL_02e8: Incompatible stack heights: 0 vs 1
		try
		{
			while (true)
			{
				int num = 894796018;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2D1349F9u) % 15u)
					{
					case 14u:
						num = ((int)num2 * -2144521379) ^ -1696355107;
						continue;
					case 13u:
						SearchPatient_Admin.smethod_38((Control)(object)ClearBtn, bool_0: true);
						num = (int)((num2 * 925102183) ^ 0x4FA5287E);
						continue;
					case 12u:
						num = (int)(num2 * 949014842) ^ -435227606;
						continue;
					case 11u:
						SearchPatient_Admin.smethod_38((Control)(object)DeleteBtn, bool_0: true);
						num = (int)(num2 * 605701240) ^ -219285658;
						continue;
					case 10u:
						num = ((int)num2 * -23861555) ^ -223809011;
						continue;
					case 9u:
						SearchPatient_Admin.smethod_91(GenderTxt, SearchPatient_Admin.smethod_90(SearchPatient_Admin.smethod_89(SearchPatient_Admin.smethod_88(SearchPatient_Admin.smethod_87(SearchPatient_Admin.smethod_86(SearchPatient_Admin.smethod_84(SearchResultGrid), SearchPatient_Admin.smethod_85(e))), 3))));
						SearchPatient_Admin.smethod_91(AddressTxt, SearchPatient_Admin.smethod_90(SearchPatient_Admin.smethod_89(SearchPatient_Admin.smethod_88(SearchPatient_Admin.smethod_87(SearchPatient_Admin.smethod_86(SearchPatient_Admin.smethod_84(SearchResultGrid), SearchPatient_Admin.smethod_85(e))), 5))));
						num = ((int)num2 * -1152598613) ^ 0x42F2B16B;
						continue;
					case 8u:
						SearchPatient_Admin.smethod_38((Control)(object)PatientInfoBox, bool_0: true);
						num = ((int)num2 * -568774465) ^ -512444910;
						continue;
					case 6u:
						SearchPatient_Admin.smethod_91(PIDTxt, SearchPatient_Admin.smethod_90(SearchPatient_Admin.smethod_89(SearchPatient_Admin.smethod_88(SearchPatient_Admin.smethod_87(SearchPatient_Admin.smethod_86(SearchPatient_Admin.smethod_84(SearchResultGrid), SearchPatient_Admin.smethod_85(e))), 0))));
						num = ((int)num2 * -1709296372) ^ -832439723;
						continue;
					case 5u:
						SearchPatient_Admin.smethod_91(MobileTxt, SearchPatient_Admin.smethod_90(SearchPatient_Admin.smethod_89(SearchPatient_Admin.smethod_88(SearchPatient_Admin.smethod_87(SearchPatient_Admin.smethod_86(SearchPatient_Admin.smethod_84(SearchResultGrid), SearchPatient_Admin.smethod_85(e))), 4))));
						num = ((int)num2 * -1397378900) ^ -657293220;
						continue;
					case 4u:
						SearchPatient_Admin.smethod_91(NameTxt, SearchPatient_Admin.smethod_90(SearchPatient_Admin.smethod_89(SearchPatient_Admin.smethod_88(SearchPatient_Admin.smethod_87(SearchPatient_Admin.smethod_86(SearchPatient_Admin.smethod_84(SearchResultGrid), SearchPatient_Admin.smethod_85(e))), 1))));
						SearchPatient_Admin.smethod_92(DOBTxt, SearchPatient_Admin.smethod_90(SearchPatient_Admin.smethod_89(SearchPatient_Admin.smethod_88(SearchPatient_Admin.smethod_87(SearchPatient_Admin.smethod_86(SearchPatient_Admin.smethod_84(SearchResultGrid), SearchPatient_Admin.smethod_85(e))), 2))));
						num = ((int)num2 * -643996601) ^ -256789515;
						continue;
					case 3u:
						SearchPatient_Admin.smethod_38((Control)(object)UpdateBtn, bool_0: true);
						num = (int)(num2 * 1794962040) ^ -90909129;
						continue;
					case 1u:
						num = (int)(num2 * 2104484198) ^ -1138855786;
						continue;
					case 0u:
						num = ((int)num2 * -1571355059) ^ -21392655;
						continue;
					default:
						return;
					case 7u:
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
				_ = 773514646;
				while (true)
				{
					_003F val = /*Error near IL_02bd: Stack underflow*/^ 0x2D1349F9;
					uint num2 = (uint)(int)val;
					switch (val % 3)
					{
					case 1:
						_ = (num2 * 1712793460) ^ 0xFF9DA2C1u;
						continue;
					case 2:
						break;
					default:
						SearchPatient_Admin.smethod_76();
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
			int num = -1836533112;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBC634EE6u) % 9u)
				{
				case 7u:
					num = (int)((num2 * 465189816) ^ 0x79CC54F0);
					continue;
				case 5u:
					SearchPatient_Admin.smethod_93((TextBoxBase)(object)PIDTxt);
					SearchPatient_Admin.smethod_93((TextBoxBase)(object)NameTxt);
					SearchPatient_Admin.smethod_93((TextBoxBase)(object)MobileTxt);
					num = ((int)num2 * -1008151204) ^ -10796985;
					continue;
				case 4u:
					SearchPatient_Admin.smethod_93((TextBoxBase)(object)AddressTxt);
					SearchPatient_Admin.smethod_93((TextBoxBase)(object)GenderTxt);
					num = ((int)num2 * -445834580) ^ -942247600;
					continue;
				case 3u:
					result = true;
					num = (int)((num2 * 254361807) ^ 0x193CBBB3);
					continue;
				case 2u:
					num = ((int)num2 * -7860345) ^ 0x23738B34;
					continue;
				case 1u:
					num = ((int)num2 * -1980979094) ^ 0x2FC0A71C;
					continue;
				case 0u:
					SearchPatient_Admin.smethod_42(DOBTxt, SearchPatient_Admin.smethod_62(SearchPatient_Admin.smethod_61((object)SearchPatient_Admin.smethod_94(), "dd-MM-yyyy")));
					num = (int)((num2 * 1574322751) ^ 0x2E0265D1);
					continue;
				case 6u:
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
