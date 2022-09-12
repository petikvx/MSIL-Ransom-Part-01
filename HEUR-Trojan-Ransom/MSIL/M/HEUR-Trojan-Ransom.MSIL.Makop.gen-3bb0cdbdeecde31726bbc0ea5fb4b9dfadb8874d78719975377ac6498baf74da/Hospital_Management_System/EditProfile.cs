using System;
using System.ComponentModel;
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
public class EditProfile : UserControl
{
	private IContainer components;

	private OleDbConnection myconnection;

	private string password;

	private string primary_key;

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox2")]
	internal virtual GroupBox GroupBox2
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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
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

	[field: AccessedThroughProperty("MobileTxt")]
	internal virtual TextBox MobileTxt
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

	[field: AccessedThroughProperty("Label7")]
	internal virtual Label Label7
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

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
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

	[field: AccessedThroughProperty("OldPasswdTxt")]
	internal virtual TextBox OldPasswdTxt
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
			Button updateBtn = _UpdateBtn;
			while (true)
			{
				int num = -315184196;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA040773Cu) % 7u)
					{
					case 6u:
						EditProfile.smethod_47((Control)(object)updateBtn, eventHandler_);
						num = (int)(num2 * 549526665) ^ -1122462607;
						continue;
					case 5u:
					{
						int num5;
						int num6;
						if (updateBtn != null)
						{
							num5 = 1616974088;
							num6 = 1616974088;
						}
						else
						{
							num5 = 296780379;
							num6 = 296780379;
						}
						num = num5 ^ ((int)num2 * -50930263);
						continue;
					}
					case 4u:
						EditProfile.smethod_46((Control)(object)updateBtn, eventHandler_);
						num = ((int)num2 * -206569182) ^ 0x3CEEE533;
						continue;
					case 2u:
						_UpdateBtn = value;
						updateBtn = _UpdateBtn;
						num = -760355413;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (updateBtn != null)
						{
							num3 = 1123895039;
							num4 = 1123895039;
						}
						else
						{
							num3 = 1365621138;
							num4 = 1365621138;
						}
						num = num3 ^ ((int)num2 * -1039451815);
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

	internal virtual CheckBox CheckBox1
	{
		[CompilerGenerated]
		get
		{
			return _CheckBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = CheckBox1_CheckedChanged;
			CheckBox checkBox = default(CheckBox);
			while (true)
			{
				int num = -1264421564;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDD443725u) % 9u)
					{
					case 8u:
					{
						int num5;
						int num6;
						if (checkBox != null)
						{
							num5 = 798129651;
							num6 = 798129651;
						}
						else
						{
							num5 = 694701560;
							num6 = 694701560;
						}
						num = num5 ^ ((int)num2 * -592452592);
						continue;
					}
					case 7u:
					{
						int num3;
						int num4;
						if (checkBox != null)
						{
							num3 = 2021206233;
							num4 = 2021206233;
						}
						else
						{
							num3 = 658900404;
							num4 = 658900404;
						}
						num = num3 ^ (int)(num2 * 896330771);
						continue;
					}
					case 6u:
						checkBox = _CheckBox1;
						num = ((int)num2 * -1150375244) ^ 0x299D1DF9;
						continue;
					case 4u:
						EditProfile.smethod_49(checkBox, eventHandler_);
						num = (int)((num2 * 462805009) ^ 0x5C90A08E);
						continue;
					case 3u:
						EditProfile.smethod_48(checkBox, eventHandler_);
						num = (int)((num2 * 213444919) ^ 0x73CBA490);
						continue;
					case 2u:
						_CheckBox1 = value;
						num = -1925439005;
						continue;
					case 0u:
						checkBox = _CheckBox1;
						num = (int)((num2 * 1420875727) ^ 0x823731C);
						continue;
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

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
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

	[field: AccessedThroughProperty("NewPasswdTxt")]
	internal virtual TextBox NewPasswdTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button ChangePasswdBtn
	{
		[CompilerGenerated]
		get
		{
			return _ChangePasswdBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = ChangePasswdBtn_Click;
			Button changePasswdBtn = default(Button);
			while (true)
			{
				int num = -589164663;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC5769E7Fu) % 8u)
					{
					case 7u:
					{
						changePasswdBtn = _ChangePasswdBtn;
						int num5;
						int num6;
						if (changePasswdBtn != null)
						{
							num5 = -1011038838;
							num6 = -1011038838;
						}
						else
						{
							num5 = -689672821;
							num6 = -689672821;
						}
						num = num5 ^ ((int)num2 * -81448260);
						continue;
					}
					case 6u:
						changePasswdBtn = _ChangePasswdBtn;
						num = (int)(num2 * 1108736852) ^ -563584686;
						continue;
					case 5u:
					{
						int num3;
						int num4;
						if (changePasswdBtn == null)
						{
							num3 = -985853169;
							num4 = -985853169;
						}
						else
						{
							num3 = -528507938;
							num4 = -528507938;
						}
						num = num3 ^ ((int)num2 * -1721032081);
						continue;
					}
					case 3u:
						_ChangePasswdBtn = value;
						num = -310210320;
						continue;
					case 2u:
						EditProfile.smethod_46((Control)(object)changePasswdBtn, eventHandler_);
						num = ((int)num2 * -2041137835) ^ 0x3BD1BBD6;
						continue;
					case 1u:
						EditProfile.smethod_47((Control)(object)changePasswdBtn, eventHandler_);
						num = ((int)num2 * -2046132686) ^ -588978275;
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
	}

	public EditProfile()
	{
		while (true)
		{
			int num = 1260567894;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1F007DA5u) % 5u)
				{
				case 4u:
					InitializeComponent();
					num = (int)((num2 * 1539487948) ^ 0x34A3CCFF);
					continue;
				case 3u:
					EditProfile.smethod_0((UserControl)(object)this, (EventHandler)EditProfile_Load);
					num = (int)(num2 * 519963412) ^ -2028361043;
					continue;
				case 0u:
					myconnection = EditProfile.smethod_1();
					num = (int)(num2 * 1479418456) ^ -1765238398;
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

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			while (true)
			{
				int num = -1617168731;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0xE5F6B7DFu) % 7u)
					{
					case 6u:
						EditProfile.smethod_2((IDisposable)components);
						num = (int)(num2 * 1279575320) ^ -704945051;
						continue;
					case 4u:
						num = (int)(num2 * 593728536) ^ -2015615026;
						continue;
					case 2u:
						num = ((int)num2 * -1268348727) ^ -399056419;
						continue;
					case 1u:
						if (disposing)
						{
							num = (int)(num2 * 482954387) ^ -437561870;
							continue;
						}
						goto IL_0060;
					case 0u:
						if (components != null)
						{
							num = -1132803736;
							num3 = -1132803736;
							continue;
						}
						goto IL_0060;
					default:
						return;
					case 5u:
						break;
					case 3u:
						return;
						IL_0060:
						num = -1829924658;
						num3 = -1829924658;
						continue;
					}
					break;
				}
			}
		}
		finally
		{
			((ContainerControl)this).Dispose(disposing);
			while (true)
			{
				IL_00e1:
				int num4 = -768077651;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num4 ^ 0xE5F6B7DFu) % 3u)
					{
					case 2u:
						goto IL_00b7;
					default:
						goto end_IL_00c4;
					case 0u:
						break;
					case 1u:
						goto end_IL_00c4;
					}
					goto IL_00e1;
					IL_00b7:
					num4 = (int)((num2 * 1348134078) ^ 0x7D3CABD0);
					continue;
					end_IL_00c4:
					break;
				}
				break;
			}
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		Label1 = EditProfile.smethod_3();
		while (true)
		{
			int num = 631758868;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4BA27573u) % 266u)
				{
				case 265u:
					num = (int)((num2 * 414378189) ^ 0x620E5A33);
					continue;
				case 264u:
					num = (int)((num2 * 89457501) ^ 0x607C0F08);
					continue;
				case 263u:
					EditProfile.smethod_23(GroupBox2, "Personal Information");
					num = (int)((num2 * 1483632505) ^ 0x5056FB46);
					continue;
				case 262u:
					EditProfile.smethod_31(OldPasswdTxt, bool_0: true);
					EditProfile.smethod_13((Control)(object)Label8, EditProfile.smethod_12("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1315017958) ^ -240372259;
					continue;
				case 261u:
					EditProfile.smethod_16((Control)(object)SIDTxt, new Size(91, 26));
					num = (int)((num2 * 1994686503) ^ 0x29FF8A21);
					continue;
				case 260u:
					num = (int)(num2 * 2095430916) ^ -32833974;
					continue;
				case 259u:
					EditProfile.smethod_13((Control)(object)OldPasswdTxt, EditProfile.smethod_12("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					EditProfile.smethod_14((Control)(object)OldPasswdTxt, new Point(197, 36));
					num = ((int)num2 * -255834158) ^ 0x299C9884;
					continue;
				case 258u:
					EditProfile.smethod_13((Control)(object)UpdateBtn, EditProfile.smethod_12("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1454881680) ^ 0x45541E94);
					continue;
				case 257u:
					num = ((int)num2 * -673566134) ^ -235946980;
					continue;
				case 256u:
					EditProfile.smethod_17((Control)(object)GroupBox1, 16);
					num = ((int)num2 * -173634917) ^ 0x538062D1;
					continue;
				case 255u:
					num = (int)(num2 * 2056983895) ^ -2126159734;
					continue;
				case 254u:
					EditProfile.smethod_42((Control)(object)GroupBox2, bool_0: false);
					num = ((int)num2 * -625122194) ^ -25437212;
					continue;
				case 253u:
					EditProfile.smethod_21(EditProfile.smethod_39((Control)(object)this), (Control)(object)GroupBox1);
					num = ((int)num2 * -1999716017) ^ 0x6D0B5566;
					continue;
				case 252u:
					EditProfile.smethod_18(Label9, "New Password :");
					num = ((int)num2 * -1626640237) ^ 0x1D9CB85;
					continue;
				case 251u:
					EditProfile.smethod_27((ButtonBase)(object)CheckBox1, "Show Password");
					num = (int)((num2 * 2082145832) ^ 0x2A75A3F9);
					continue;
				case 250u:
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox2), (Control)(object)Label4);
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox2), (Control)(object)Label3);
					num = (int)(num2 * 50034071) ^ -1161260264;
					continue;
				case 249u:
					EditProfile.smethod_15((Control)(object)Label2, "Label2");
					num = ((int)num2 * -179334336) ^ -1905641352;
					continue;
				case 248u:
					num = ((int)num2 * -1171398545) ^ 0x1C4EF95C;
					continue;
				case 247u:
					num = ((int)num2 * -1141437258) ^ -1377722963;
					continue;
				case 246u:
					EditProfile.smethod_14((Control)(object)PictureBox1, new Point(281, 42));
					EditProfile.smethod_15((Control)(object)PictureBox1, "PictureBox1");
					num = (int)(num2 * 1483259460) ^ -1813929453;
					continue;
				case 245u:
					EditProfile.smethod_16((Control)(object)Label2, new Size(87, 29));
					num = (int)((num2 * 1539990021) ^ 0x3FE0AAE0);
					continue;
				case 244u:
					EditProfile.smethod_17((Control)(object)NewPasswdTxt, 16);
					num = ((int)num2 * -333123165) ^ 0x758BC5D3;
					continue;
				case 243u:
					EditProfile.smethod_17((Control)(object)ChangePasswdBtn, 17);
					num = ((int)num2 * -397011312) ^ -1362520846;
					continue;
				case 242u:
					num = ((int)num2 * -1083140836) ^ 0x64049C65;
					continue;
				case 241u:
					num = ((int)num2 * -1899402365) ^ -1989890518;
					continue;
				case 240u:
					AddressTxt = EditProfile.smethod_5();
					num = (int)((num2 * 1431279244) ^ 0x2F1FF5B0);
					continue;
				case 239u:
					EditProfile.smethod_15((Control)(object)Label8, "Label8");
					num = ((int)num2 * -683737243) ^ -400042799;
					continue;
				case 238u:
					num = (int)((num2 * 1928532483) ^ 0x423D73CB);
					continue;
				case 237u:
					EditProfile.smethod_41((Control)(object)this, new Size(977, 804));
					num = ((int)num2 * -56470872) ^ 0x6ACECD59;
					continue;
				case 236u:
					EditProfile.smethod_36((ContainerControl)(object)this, new SizeF(8f, 16f));
					num = ((int)num2 * -1484728679) ^ 0x3E561CE5;
					continue;
				case 235u:
					EditProfile.smethod_14((Control)(object)Label9, new Point(21, 73));
					EditProfile.smethod_15((Control)(object)Label9, "Label9");
					num = (int)(num2 * 997405405) ^ -383958352;
					continue;
				case 234u:
					EditProfile.smethod_13((Control)(object)SIDTxt, EditProfile.smethod_12("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 704742773) ^ -1263797020;
					continue;
				case 233u:
					num = ((int)num2 * -1432011884) ^ 0x64B509A6;
					continue;
				case 232u:
					EditProfile.smethod_19(Label2, (ContentAlignment)32);
					num = (int)((num2 * 934388611) ^ 0x4FEEF853);
					continue;
				case 231u:
					EditProfile.smethod_19(Label8, (ContentAlignment)32);
					num = ((int)num2 * -456480128) ^ 0x109B9285;
					continue;
				case 230u:
					num = (int)(num2 * 570062261) ^ -150046079;
					continue;
				case 229u:
					num = (int)(num2 * 1883240321) ^ -776372466;
					continue;
				case 228u:
					EditProfile.smethod_17((Control)(object)Label5, 8);
					num = (int)((num2 * 537196774) ^ 0x496AF7AC);
					continue;
				case 227u:
					EditProfile.smethod_15((Control)(object)UpdateBtn, "UpdateBtn");
					num = ((int)num2 * -2081597274) ^ -865622680;
					continue;
				case 226u:
					EditProfile.smethod_34(PictureBox1, 7);
					EditProfile.smethod_35(PictureBox1, bool_0: false);
					num = ((int)num2 * -527330965) ^ 0x3AEEF109;
					continue;
				case 225u:
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox2), (Control)(object)GenderTxt);
					num = ((int)num2 * -607597480) ^ 0x41ECA05E;
					continue;
				case 224u:
					EditProfile.smethod_17((Control)(object)OldPasswdTxt, 14);
					num = ((int)num2 * -1792375078) ^ -2144528035;
					continue;
				case 223u:
					num = ((int)num2 * -2094267290) ^ 0x7D300049;
					continue;
				case 222u:
					EditProfile.smethod_14((Control)(object)Label3, new Point(269, 146));
					num = ((int)num2 * -502803394) ^ -1007020792;
					continue;
				case 221u:
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox1), (Control)(object)ChangePasswdBtn);
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox1), (Control)(object)NewPasswdTxt);
					num = (int)(num2 * 1413771650) ^ -372926083;
					continue;
				case 220u:
					Label6 = EditProfile.smethod_3();
					Label5 = EditProfile.smethod_3();
					num = (int)(num2 * 1049043489) ^ -925386578;
					continue;
				case 219u:
					EditProfile.smethod_13((Control)(object)Label5, EditProfile.smethod_12("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -336041376) ^ 0x58620610;
					continue;
				case 218u:
					num = ((int)num2 * -838934870) ^ 0x51D6950A;
					continue;
				case 217u:
					EditProfile.smethod_15((Control)(object)Label3, "Label3");
					EditProfile.smethod_16((Control)(object)Label3, new Size(73, 31));
					num = ((int)num2 * -2136274146) ^ 0x2D331239;
					continue;
				case 216u:
					num = ((int)num2 * -1570880005) ^ 0x7C786708;
					continue;
				case 215u:
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox1), (Control)(object)OldPasswdTxt);
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox1), (Control)(object)Label8);
					num = (int)((num2 * 19501946) ^ 0x758B6BD7);
					continue;
				case 214u:
					EditProfile.smethod_17((Control)(object)Label1, 6);
					num = ((int)num2 * -946562649) ^ 0x46D83DCD;
					continue;
				case 213u:
					GenderTxt = EditProfile.smethod_5();
					num = (int)(num2 * 699318142) ^ -360260565;
					continue;
				case 212u:
					PictureBox1 = EditProfile.smethod_8();
					num = (int)((num2 * 705903665) ^ 0x329EB866);
					continue;
				case 211u:
					num = ((int)num2 * -58882447) ^ -1532890861;
					continue;
				case 210u:
					OldPasswdTxt = EditProfile.smethod_5();
					num = ((int)num2 * -614262337) ^ 0x7645554F;
					continue;
				case 209u:
					EditProfile.smethod_14((Control)(object)UpdateBtn, new Point(311, 372));
					num = ((int)num2 * -1585962406) ^ -1581348744;
					continue;
				case 208u:
					EditProfile.smethod_16((Control)(object)NewPasswdTxt, new Size(247, 26));
					num = ((int)num2 * -1458200953) ^ -1448413391;
					continue;
				case 207u:
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox2), (Control)(object)Label5);
					num = (int)(num2 * 1312049910) ^ -271330627;
					continue;
				case 206u:
					EditProfile.smethod_19(Label3, (ContentAlignment)32);
					num = ((int)num2 * -294056267) ^ -1932638254;
					continue;
				case 205u:
					EditProfile.smethod_22(GroupBox2, bool_0: false);
					num = (int)(num2 * 586945995) ^ -2072672741;
					continue;
				case 204u:
					num = ((int)num2 * -1533528035) ^ -422432436;
					continue;
				case 203u:
					EditProfile.smethod_14((Control)(object)NewPasswdTxt, new Point(197, 73));
					EditProfile.smethod_15((Control)(object)NewPasswdTxt, "NewPasswdTxt");
					num = (int)(num2 * 1608304353) ^ -298265948;
					continue;
				case 202u:
					num = (int)(num2 * 1041868611) ^ -487880601;
					continue;
				case 201u:
					num = ((int)num2 * -519872502) ^ 0x5885D1B;
					continue;
				case 200u:
					num = ((int)num2 * -1380417173) ^ -1442572778;
					continue;
				case 199u:
					EditProfile.smethod_17((Control)(object)GroupBox2, 8);
					num = (int)((num2 * 367423609) ^ 0x786E1CAA);
					continue;
				case 198u:
					num = ((int)num2 * -1389325929) ^ 0x68B0E37A;
					continue;
				case 197u:
					EditProfile.smethod_24((TextBoxBase)(object)SIDTxt, bool_0: true);
					num = (int)((num2 * 497694017) ^ 0xBB7E22A);
					continue;
				case 196u:
					EditProfile.smethod_13((Control)(object)NewPasswdTxt, EditProfile.smethod_12("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1404129005) ^ -1257315354;
					continue;
				case 195u:
					EditProfile.smethod_30((ButtonBase)(object)CheckBox1, bool_0: true);
					EditProfile.smethod_13((Control)(object)CheckBox1, EditProfile.smethod_12("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1489739222) ^ 0x10D023CF;
					continue;
				case 194u:
					EditProfile.smethod_19(Label7, (ContentAlignment)32);
					num = (int)((num2 * 2128106133) ^ 0x70CD1B6C);
					continue;
				case 193u:
					num = ((int)num2 * -495689053) ^ -651892633;
					continue;
				case 192u:
					NewPasswdTxt = EditProfile.smethod_5();
					num = (int)(num2 * 1060426969) ^ -901822869;
					continue;
				case 191u:
					EditProfile.smethod_18(Label8, "Old Password :");
					num = ((int)num2 * -449660068) ^ -697347251;
					continue;
				case 190u:
					EditProfile.smethod_17((Control)(object)MobileTxt, 2);
					num = (int)(num2 * 1176155738) ^ -562767206;
					continue;
				case 189u:
					num = (int)(num2 * 495331731) ^ -1055859463;
					continue;
				case 188u:
					num = (int)(num2 * 1627530240) ^ -2021234606;
					continue;
				case 186u:
					EditProfile.smethod_21(EditProfile.smethod_39((Control)(object)this), (Control)(object)Label1);
					num = ((int)num2 * -637846747) ^ 0x3A2F99F7;
					continue;
				case 185u:
					EditProfile.smethod_18(Label3, "Gender :");
					num = (int)(num2 * 1851910660) ^ -1433780864;
					continue;
				case 184u:
					EditProfile.smethod_13((Control)(object)Label9, EditProfile.smethod_12("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 525937319) ^ 0x11D4CE00);
					continue;
				case 183u:
					num = ((int)num2 * -409137893) ^ 0x3D43CDB;
					continue;
				case 182u:
					num = ((int)num2 * -986411102) ^ -253185231;
					continue;
				case 181u:
					EditProfile.smethod_13((Control)(object)DOBTxt, EditProfile.smethod_12("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1281949089) ^ 0x738C4350;
					continue;
				case 180u:
					EditProfile.smethod_16((Control)(object)GroupBox1, new Size(486, 178));
					num = (int)((num2 * 944479478) ^ 0x370C0A46);
					continue;
				case 179u:
					EditProfile.smethod_43((Control)(object)GroupBox2);
					num = ((int)num2 * -1383869428) ^ -718485392;
					continue;
				case 178u:
					EditProfile.smethod_44((ISupportInitialize)PictureBox1);
					EditProfile.smethod_45((Control)(object)this, bool_0: false);
					num = ((int)num2 * -523144023) ^ 0x4E81304E;
					continue;
				case 177u:
					num = (int)((num2 * 1454526319) ^ 0x2FC7A89C);
					continue;
				case 176u:
					EditProfile.smethod_16((Control)(object)Label9, new Size(154, 26));
					num = ((int)num2 * -836819383) ^ 0x11998324;
					continue;
				case 175u:
					num = (int)(num2 * 22434552) ^ -1262066981;
					continue;
				case 174u:
					EditProfile.smethod_13((Control)(object)NameTxt, EditProfile.smethod_12("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1990512765) ^ -628079809;
					continue;
				case 173u:
					Label3 = EditProfile.smethod_3();
					num = (int)((num2 * 661437399) ^ 0x6C57057C);
					continue;
				case 172u:
					num = (int)((num2 * 275248161) ^ 0x188DA058);
					continue;
				case 171u:
					num = (int)(num2 * 1592574788) ^ -1608224153;
					continue;
				case 170u:
					EditProfile.smethod_16((Control)(object)Label5, new Size(94, 29));
					num = (int)(num2 * 104487930) ^ -1070272827;
					continue;
				case 169u:
					EditProfile.smethod_17((Control)(object)SIDTxt, 12);
					num = ((int)num2 * -1018920520) ^ 0x6C105E55;
					continue;
				case 168u:
					EditProfile.smethod_17((Control)(object)GenderTxt, 10);
					num = (int)(num2 * 494987576) ^ -1987044305;
					continue;
				case 167u:
					EditProfile.smethod_10((ISupportInitialize)PictureBox1);
					num = ((int)num2 * -605979379) ^ 0x707871F5;
					continue;
				case 166u:
					EditProfile.smethod_16((Control)(object)ChangePasswdBtn, new Size(172, 37));
					num = (int)((num2 * 1017121535) ^ 0x3E133979);
					continue;
				case 165u:
					num = (int)(num2 * 10131672) ^ -850395838;
					continue;
				case 164u:
					EditProfile.smethod_28((ButtonBase)(object)CheckBox1, bool_0: true);
					num = ((int)num2 * -1529157800) ^ -69851243;
					continue;
				case 163u:
					EditProfile.smethod_16((Control)(object)AddressTxt, new Size(309, 97));
					EditProfile.smethod_17((Control)(object)AddressTxt, 4);
					num = ((int)num2 * -1655176567) ^ 0x2A9AE4C8;
					continue;
				case 162u:
					num = (int)((num2 * 1290251348) ^ 0x4E8800DC);
					continue;
				case 161u:
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox2), (Control)(object)DOBTxt);
					num = ((int)num2 * -1222973973) ^ 0x44AF58AF;
					continue;
				case 160u:
					num = (int)((num2 * 50077920) ^ 0x5D6F9F5A);
					continue;
				case 159u:
					num = ((int)num2 * -1032818399) ^ -566604307;
					continue;
				case 158u:
					EditProfile.smethod_15((Control)(object)Label6, "Label6");
					EditProfile.smethod_16((Control)(object)Label6, new Size(87, 26));
					EditProfile.smethod_17((Control)(object)Label6, 9);
					num = (int)(num2 * 273016663) ^ -22374971;
					continue;
				case 157u:
					EditProfile.smethod_15((Control)(object)OldPasswdTxt, "OldPasswdTxt");
					num = ((int)num2 * -417002823) ^ -648098161;
					continue;
				case 156u:
					Label2 = EditProfile.smethod_3();
					num = (int)(num2 * 1106534964) ^ -2133414571;
					continue;
				case 155u:
					EditProfile.smethod_16((Control)(object)UpdateBtn, new Size(133, 37));
					num = ((int)num2 * -1826726028) ^ -505524072;
					continue;
				case 154u:
					EditProfile.smethod_16((Control)(object)PictureBox1, new Size(172, 90));
					num = (int)(num2 * 2022686848) ^ -610849669;
					continue;
				case 153u:
					num = (int)(num2 * 459090010) ^ -1386377081;
					continue;
				case 152u:
					num = ((int)num2 * -311011656) ^ -1365866914;
					continue;
				case 151u:
					num = ((int)num2 * -367177558) ^ 0x2AC6C626;
					continue;
				case 150u:
					EditProfile.smethod_14((Control)(object)Label8, new Point(21, 32));
					num = (int)((num2 * 10465371) ^ 0xC6ED);
					continue;
				case 149u:
					EditProfile.smethod_15((Control)(object)NameTxt, "NameTxt");
					num = ((int)num2 * -1946347466) ^ 0x50E087EF;
					continue;
				case 148u:
					Label9 = EditProfile.smethod_3();
					num = (int)(num2 * 225646036) ^ -442900795;
					continue;
				case 147u:
					EditProfile.smethod_17((Control)(object)Label7, 11);
					num = ((int)num2 * -868528625) ^ -904639827;
					continue;
				case 146u:
					EditProfile.smethod_15((Control)(object)Label5, "Label5");
					num = (int)(num2 * 1748844387) ^ -1189300259;
					continue;
				case 145u:
					EditProfile.smethod_16((Control)(object)GenderTxt, new Size(96, 26));
					num = ((int)num2 * -1768058713) ^ 0x1870B8CA;
					continue;
				case 144u:
					EditProfile.smethod_17((Control)(object)NameTxt, 0);
					num = (int)((num2 * 1382806345) ^ 0x3BD2D210);
					continue;
				case 143u:
					EditProfile.smethod_14((Control)(object)Label5, new Point(31, 211));
					num = (int)((num2 * 32335210) ^ 0x6119AFFF);
					continue;
				case 142u:
					EditProfile.smethod_32(PictureBox1, (Image)(object)Resources.patient_pic);
					num = (int)((num2 * 476046338) ^ 0x186CF2FC);
					continue;
				case 141u:
					EditProfile.smethod_19(Label4, (ContentAlignment)32);
					num = ((int)num2 * -369115387) ^ 0x1F8A1457;
					continue;
				case 140u:
					num = ((int)num2 * -722082999) ^ -463216029;
					continue;
				case 139u:
					EditProfile.smethod_16((Control)(object)OldPasswdTxt, new Size(247, 26));
					num = (int)((num2 * 1171790346) ^ 0x26F4AD87);
					continue;
				case 138u:
					CheckBox1 = EditProfile.smethod_7();
					num = ((int)num2 * -6062543) ^ 0x74B1728F;
					continue;
				case 137u:
					num = ((int)num2 * -1695858183) ^ 0x65572A50;
					continue;
				case 136u:
					EditProfile.smethod_14((Control)(object)GroupBox1, new Point(261, 591));
					num = (int)((num2 * 1392873924) ^ 0x5E25D82B);
					continue;
				case 135u:
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox1), (Control)(object)Label9);
					num = (int)((num2 * 1459001706) ^ 0x22928C64);
					continue;
				case 134u:
					EditProfile.smethod_27((ButtonBase)(object)UpdateBtn, "Update");
					num = (int)(num2 * 1349953565) ^ -1351400895;
					continue;
				case 133u:
					num = (int)((num2 * 1983111144) ^ 0x2BE5F867);
					continue;
				case 132u:
					EditProfile.smethod_16((Control)(object)GroupBox2, new Size(486, 418));
					num = ((int)num2 * -1533131889) ^ 0x773C838C;
					continue;
				case 131u:
					num = ((int)num2 * -754598811) ^ 0x30AA93E5;
					continue;
				case 130u:
					EditProfile.smethod_15((Control)(object)GroupBox2, "GroupBox2");
					num = (int)(num2 * 213537806) ^ -1353652515;
					continue;
				case 129u:
					EditProfile.smethod_16((Control)(object)MobileTxt, new Size(204, 26));
					num = (int)(num2 * 582628444) ^ -1657042789;
					continue;
				case 128u:
					EditProfile.smethod_22(GroupBox1, bool_0: false);
					num = (int)((num2 * 1364519182) ^ 0x797BE801);
					continue;
				case 127u:
					DOBTxt = EditProfile.smethod_5();
					num = ((int)num2 * -757674845) ^ 0x287FC64F;
					continue;
				case 126u:
					EditProfile.smethod_16((Control)(object)Label7, new Size(87, 23));
					num = ((int)num2 * -948261849) ^ 0x6AAE5EE5;
					continue;
				case 125u:
					EditProfile.smethod_14((Control)(object)Label7, new Point(21, 51));
					EditProfile.smethod_15((Control)(object)Label7, "Label7");
					num = (int)(num2 * 118889056) ^ -1429649970;
					continue;
				case 124u:
					EditProfile.smethod_14((Control)(object)Label4, new Point(21, 152));
					num = (int)((num2 * 1925355623) ^ 0x20B82316);
					continue;
				case 123u:
					EditProfile.smethod_43((Control)(object)GroupBox1);
					num = (int)(num2 * 2004245802) ^ -1240274850;
					continue;
				case 122u:
					EditProfile.smethod_25((ButtonBase)(object)UpdateBtn, Color.MidnightBlue);
					num = (int)(num2 * 323857926) ^ -1941012225;
					continue;
				case 121u:
					num = (int)((num2 * 207727537) ^ 0x982E26B);
					continue;
				case 120u:
					EditProfile.smethod_18(Label4, "D.O.B  :");
					num = (int)(num2 * 1854896501) ^ -1046499374;
					continue;
				case 119u:
					EditProfile.smethod_17((Control)(object)UpdateBtn, 9);
					num = ((int)num2 * -2083423133) ^ 0x52FB4C72;
					continue;
				case 118u:
					Label8 = EditProfile.smethod_3();
					num = ((int)num2 * -1124019460) ^ -1115061659;
					continue;
				case 117u:
					EditProfile.smethod_18(Label5, "Mobile :");
					num = (int)((num2 * 1089246062) ^ 0x10F24594);
					continue;
				case 116u:
					EditProfile.smethod_33(PictureBox1, (PictureBoxSizeMode)1);
					num = ((int)num2 * -1163770384) ^ -46881813;
					continue;
				case 115u:
					num = (int)(num2 * 73871267) ^ -748320770;
					continue;
				case 114u:
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox2), (Control)(object)UpdateBtn);
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox2), (Control)(object)Label7);
					num = ((int)num2 * -1082548934) ^ -329793202;
					continue;
				case 113u:
					num = (int)((num2 * 670405732) ^ 0x5155F1AC);
					continue;
				case 112u:
					EditProfile.smethod_19(Label9, (ContentAlignment)32);
					num = (int)((num2 * 1343699208) ^ 0x2CA52F55);
					continue;
				case 110u:
					num = (int)((num2 * 302429065) ^ 0x5A85390C);
					continue;
				case 109u:
					EditProfile.smethod_17((Control)(object)Label8, 13);
					num = ((int)num2 * -798723669) ^ 0x73DE297C;
					continue;
				case 108u:
					ChangePasswdBtn = EditProfile.smethod_6();
					num = ((int)num2 * -1777684468) ^ -986655785;
					continue;
				case 107u:
					EditProfile.smethod_21(EditProfile.smethod_39((Control)(object)this), (Control)(object)GroupBox2);
					num = ((int)num2 * -2000074265) ^ 0x6E6A6161;
					continue;
				case 106u:
					EditProfile.smethod_42((Control)(object)GroupBox1, bool_0: false);
					num = (int)(num2 * 14544096) ^ -1115751419;
					continue;
				case 105u:
					NameTxt = EditProfile.smethod_5();
					num = (int)(num2 * 1240885972) ^ -1537249735;
					continue;
				case 104u:
					num = (int)((num2 * 535291896) ^ 0xAD64121);
					continue;
				case 103u:
					EditProfile.smethod_15((Control)(object)Label4, "Label4");
					EditProfile.smethod_16((Control)(object)Label4, new Size(85, 24));
					num = ((int)num2 * -952927054) ^ -104105498;
					continue;
				case 102u:
					num = (int)(num2 * 1664283915) ^ -541797293;
					continue;
				case 101u:
					EditProfile.smethod_19(Label6, (ContentAlignment)32);
					num = ((int)num2 * -447064737) ^ 0x5E508890;
					continue;
				case 100u:
					EditProfile.smethod_17((Control)(object)DOBTxt, 1);
					num = ((int)num2 * -1358368675) ^ 0x39885BAA;
					continue;
				case 99u:
					EditProfile.smethod_27((ButtonBase)(object)ChangePasswdBtn, "Change Password");
					num = ((int)num2 * -119061841) ^ -464076493;
					continue;
				case 98u:
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox2), (Control)(object)AddressTxt);
					num = (int)(num2 * 1368689665) ^ -2032759077;
					continue;
				case 97u:
					EditProfile.smethod_17((Control)(object)Label9, 15);
					num = (int)((num2 * 843896558) ^ 0x2D747EC3);
					continue;
				case 96u:
					EditProfile.smethod_16((Control)(object)NameTxt, new Size(309, 26));
					num = ((int)num2 * -1198606686) ^ -368691653;
					continue;
				case 95u:
					EditProfile.smethod_19(Label1, (ContentAlignment)32);
					num = (int)((num2 * 718081670) ^ 0x35687177);
					continue;
				case 94u:
					EditProfile.smethod_14((Control)(object)AddressTxt, new Point(135, 269));
					num = (int)((num2 * 613423543) ^ 0xFB67840);
					continue;
				case 93u:
					num = ((int)num2 * -1173360306) ^ -1027332392;
					continue;
				case 92u:
					EditProfile.smethod_13((Control)(object)GroupBox1, EditProfile.smethod_12("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -48723144) ^ -88598347;
					continue;
				case 91u:
					num = (int)(num2 * 1943070195) ^ -2053226454;
					continue;
				case 90u:
					num = (int)(num2 * 868761526) ^ -3377445;
					continue;
				case 89u:
					EditProfile.smethod_17((Control)(object)Label2, 5);
					num = ((int)num2 * -1074489778) ^ -1324695075;
					continue;
				case 88u:
					EditProfile.smethod_15((Control)(object)GroupBox1, "GroupBox1");
					num = ((int)num2 * -1276232194) ^ -52998689;
					continue;
				case 87u:
					num = (int)((num2 * 166014622) ^ 0x291248E9);
					continue;
				case 86u:
					EditProfile.smethod_17((Control)(object)CheckBox1, 15);
					num = ((int)num2 * -2125266882) ^ 0x428CA16E;
					continue;
				case 85u:
					EditProfile.smethod_13((Control)(object)GroupBox2, EditProfile.smethod_12("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 57145419) ^ 0x597F776C);
					continue;
				case 84u:
					EditProfile.smethod_15((Control)(object)GenderTxt, "GenderTxt");
					num = (int)(num2 * 1936432716) ^ -1683981474;
					continue;
				case 83u:
					num = ((int)num2 * -56301520) ^ -86724299;
					continue;
				case 82u:
					num = (int)(num2 * 1788644791) ^ -1284689646;
					continue;
				case 81u:
					num = ((int)num2 * -755385136) ^ 0x78ADF244;
					continue;
				case 80u:
					EditProfile.smethod_14((Control)(object)DOBTxt, new Point(135, 148));
					EditProfile.smethod_15((Control)(object)DOBTxt, "DOBTxt");
					num = (int)((num2 * 746391707) ^ 0x5784A192);
					continue;
				case 79u:
					num = (int)(num2 * 741838181) ^ -1361870279;
					continue;
				case 78u:
					EditProfile.smethod_25((ButtonBase)(object)ChangePasswdBtn, Color.MidnightBlue);
					num = (int)(num2 * 683922145) ^ -767618250;
					continue;
				case 77u:
					EditProfile.smethod_13((Control)(object)ChangePasswdBtn, EditProfile.smethod_12("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					EditProfile.smethod_26((Control)(object)ChangePasswdBtn, Color.White);
					EditProfile.smethod_14((Control)(object)ChangePasswdBtn, new Point(272, 135));
					EditProfile.smethod_15((Control)(object)ChangePasswdBtn, "ChangePasswdBtn");
					num = (int)(num2 * 758347041) ^ -1625622858;
					continue;
				case 76u:
					Label4 = EditProfile.smethod_3();
					num = ((int)num2 * -899928008) ^ 0x38DB1189;
					continue;
				case 75u:
					EditProfile.smethod_13((Control)(object)Label1, EditProfile.smethod_12("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1835835750) ^ 0x2D2491F4);
					continue;
				case 74u:
					EditProfile.smethod_28((ButtonBase)(object)UpdateBtn, bool_0: false);
					num = ((int)num2 * -182619105) ^ 0x7F810550;
					continue;
				case 73u:
					EditProfile.smethod_26((Control)(object)UpdateBtn, Color.White);
					num = (int)((num2 * 343687940) ^ 0x70B0896C);
					continue;
				case 72u:
					EditProfile.smethod_38((Control)(object)this, Color.White);
					num = ((int)num2 * -39166952) ^ -1133488142;
					continue;
				case 71u:
					GroupBox1 = EditProfile.smethod_4();
					num = ((int)num2 * -1088145604) ^ -1931824419;
					continue;
				case 70u:
					EditProfile.smethod_29(AddressTxt, bool_0: true);
					EditProfile.smethod_15((Control)(object)AddressTxt, "AddressTxt");
					num = ((int)num2 * -1520712085) ^ -1842637500;
					continue;
				case 69u:
					EditProfile.smethod_18(Label1, "Edit Profile");
					num = ((int)num2 * -993245448) ^ -1523215149;
					continue;
				case 68u:
					num = (int)(num2 * 189012633) ^ -1526823520;
					continue;
				case 67u:
					EditProfile.smethod_28((ButtonBase)(object)ChangePasswdBtn, bool_0: false);
					num = (int)((num2 * 1329009144) ^ 0x494BE993);
					continue;
				case 66u:
					num = (int)((num2 * 517574938) ^ 0x6C81E0F1);
					continue;
				case 65u:
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox2), (Control)(object)SIDTxt);
					num = ((int)num2 * -1420580909) ^ 0x44EFB6C8;
					continue;
				case 64u:
					num = (int)(num2 * 1177919049) ^ -1225187249;
					continue;
				case 63u:
					num = ((int)num2 * -213011707) ^ -392221486;
					continue;
				case 62u:
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox2), (Control)(object)MobileTxt);
					num = (int)((num2 * 1000854461) ^ 0x54F8E2C4);
					continue;
				case 61u:
					num = (int)((num2 * 1987743640) ^ 0x40174AB7);
					continue;
				case 60u:
					num = ((int)num2 * -340682371) ^ 0x5C944D2C;
					continue;
				case 59u:
					EditProfile.smethod_18(Label7, "SID :");
					num = ((int)num2 * -255651153) ^ 0x32A256F4;
					continue;
				case 58u:
					EditProfile.smethod_18(Label6, "Address :");
					num = (int)(num2 * 800027844) ^ -1230909706;
					continue;
				case 57u:
					EditProfile.smethod_24((TextBoxBase)(object)DOBTxt, bool_0: true);
					EditProfile.smethod_16((Control)(object)DOBTxt, new Size(128, 26));
					num = ((int)num2 * -802176538) ^ 0x588C0727;
					continue;
				case 56u:
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox2), (Control)(object)NameTxt);
					num = (int)(num2 * 1420451571) ^ -587497870;
					continue;
				case 55u:
					EditProfile.smethod_9((Control)(object)GroupBox2);
					EditProfile.smethod_9((Control)(object)GroupBox1);
					num = ((int)num2 * -1720829091) ^ 0x6AE1E39F;
					continue;
				case 54u:
					EditProfile.smethod_13((Control)(object)AddressTxt, EditProfile.smethod_12("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1502634022) ^ 0xC852EDF);
					continue;
				case 53u:
					num = ((int)num2 * -78838344) ^ -1345184764;
					continue;
				case 52u:
					EditProfile.smethod_14((Control)(object)GroupBox2, new Point(261, 167));
					num = ((int)num2 * -1762260389) ^ -1817728623;
					continue;
				case 51u:
					EditProfile.smethod_14((Control)(object)Label1, new Point(392, 63));
					EditProfile.smethod_15((Control)(object)Label1, "Label1");
					num = ((int)num2 * -1730671872) ^ -927005803;
					continue;
				case 50u:
					EditProfile.smethod_14((Control)(object)NameTxt, new Point(135, 98));
					num = ((int)num2 * -756499778) ^ 0x1B2C1295;
					continue;
				case 49u:
					EditProfile.smethod_24((TextBoxBase)(object)NameTxt, bool_0: true);
					num = ((int)num2 * -752528653) ^ -1471598756;
					continue;
				case 48u:
					EditProfile.smethod_37((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 467035702) ^ -1140866521;
					continue;
				case 47u:
					EditProfile.smethod_13((Control)(object)Label4, EditProfile.smethod_12("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -300555201) ^ 0xB73856;
					continue;
				case 46u:
					EditProfile.smethod_16((Control)(object)Label1, new Size(330, 47));
					num = (int)((num2 * 1053772904) ^ 0x54C9D84B);
					continue;
				case 45u:
					EditProfile.smethod_24((TextBoxBase)(object)GenderTxt, bool_0: true);
					num = (int)(num2 * 81950332) ^ -1684982354;
					continue;
				case 44u:
					EditProfile.smethod_13((Control)(object)MobileTxt, EditProfile.smethod_12("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -2114215010) ^ 0x265EB8FB;
					continue;
				case 43u:
					EditProfile.smethod_17((Control)(object)Label4, 7);
					num = ((int)num2 * -111466132) ^ 0x53CB347C;
					continue;
				case 42u:
					GroupBox2 = EditProfile.smethod_4();
					SIDTxt = EditProfile.smethod_5();
					UpdateBtn = EditProfile.smethod_6();
					num = (int)(num2 * 1892551601) ^ -1243173490;
					continue;
				case 41u:
					num = ((int)num2 * -538335648) ^ 0x509C6D7A;
					continue;
				case 40u:
					EditProfile.smethod_16((Control)(object)CheckBox1, new Size(163, 23));
					num = ((int)num2 * -916435245) ^ -650349892;
					continue;
				case 39u:
					EditProfile.smethod_16((Control)(object)Label8, new Size(154, 26));
					num = ((int)num2 * -212281123) ^ 0x3BB3613F;
					continue;
				case 38u:
					num = (int)(num2 * 1699034547) ^ -2036213612;
					continue;
				case 37u:
					EditProfile.smethod_15((Control)(object)CheckBox1, "CheckBox1");
					num = ((int)num2 * -1034418764) ^ -769111261;
					continue;
				case 36u:
					num = (int)((num2 * 1230488703) ^ 0x72715929);
					continue;
				case 35u:
					num = (int)((num2 * 1361843466) ^ 0x35D9A191);
					continue;
				case 34u:
					EditProfile.smethod_13((Control)(object)Label6, EditProfile.smethod_12("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					EditProfile.smethod_14((Control)(object)Label6, new Point(31, 269));
					num = (int)((num2 * 534097393) ^ 0x748D1525);
					continue;
				case 33u:
					EditProfile.smethod_19(Label5, (ContentAlignment)32);
					num = (int)(num2 * 1635041501) ^ -297363833;
					continue;
				case 32u:
					EditProfile.smethod_14((Control)(object)CheckBox1, new Point(197, 110));
					num = ((int)num2 * -1310462511) ^ -1352174110;
					continue;
				case 31u:
					EditProfile.smethod_15((Control)(object)SIDTxt, "SIDTxt");
					num = ((int)num2 * -1383455472) ^ -1729889106;
					continue;
				case 30u:
					num = (int)((num2 * 736447203) ^ 0x10D28AA8);
					continue;
				case 29u:
					EditProfile.smethod_17((Control)(object)Label3, 6);
					num = (int)(num2 * 2043340744) ^ -598609450;
					continue;
				case 28u:
					num = (int)(num2 * 555362238) ^ -313753675;
					continue;
				case 27u:
					EditProfile.smethod_21(EditProfile.smethod_39((Control)(object)this), (Control)(object)PictureBox1);
					num = ((int)num2 * -594727289) ^ -1801499028;
					continue;
				case 26u:
					EditProfile.smethod_14((Control)(object)SIDTxt, new Point(135, 51));
					num = (int)(num2 * 1144676205) ^ -494495044;
					continue;
				case 25u:
					EditProfile.smethod_11((Control)(object)this);
					num = ((int)num2 * -1948246412) ^ 0x405B86A8;
					continue;
				case 24u:
					num = ((int)num2 * -1016031394) ^ -583278549;
					continue;
				case 23u:
					Label7 = EditProfile.smethod_3();
					num = (int)(num2 * 434419003) ^ -1294397469;
					continue;
				case 22u:
					EditProfile.smethod_23(GroupBox1, "Change Password");
					num = ((int)num2 * -2096317580) ^ -598643729;
					continue;
				case 21u:
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox2), (Control)(object)Label6);
					num = ((int)num2 * -1316630484) ^ -1639590138;
					continue;
				case 20u:
					num = ((int)num2 * -1534836783) ^ -1612032032;
					continue;
				case 19u:
					MobileTxt = EditProfile.smethod_5();
					num = (int)(num2 * 240902007) ^ -1782107015;
					continue;
				case 18u:
					EditProfile.smethod_31(NewPasswdTxt, bool_0: true);
					num = (int)((num2 * 1538566656) ^ 0x54D60757);
					continue;
				case 17u:
					EditProfile.smethod_14((Control)(object)GenderTxt, new Point(348, 147));
					num = (int)(num2 * 2064083602) ^ -1146415566;
					continue;
				case 16u:
					EditProfile.smethod_13((Control)(object)Label3, EditProfile.smethod_12("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1194332803) ^ -59211834;
					continue;
				case 15u:
					num = ((int)num2 * -398663732) ^ 0x63B1121A;
					continue;
				case 14u:
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox1), (Control)(object)CheckBox1);
					num = ((int)num2 * -1706826731) ^ 0x530190B4;
					continue;
				case 13u:
					EditProfile.smethod_40((Control)(object)this, "EditProfile");
					num = ((int)num2 * -1728205556) ^ -2091792222;
					continue;
				case 12u:
					num = ((int)num2 * -457062991) ^ 0xED02912;
					continue;
				case 11u:
					num = ((int)num2 * -1531919030) ^ -7877386;
					continue;
				case 10u:
					EditProfile.smethod_13((Control)(object)Label2, EditProfile.smethod_12("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					EditProfile.smethod_14((Control)(object)Label2, new Point(17, 98));
					num = ((int)num2 * -1795930133) ^ -2061150110;
					continue;
				case 9u:
					EditProfile.smethod_13((Control)(object)Label7, EditProfile.smethod_12("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1721098738) ^ 0x5B655D7D;
					continue;
				case 8u:
					num = ((int)num2 * -1602763044) ^ -1890886054;
					continue;
				case 7u:
					num = ((int)num2 * -1693156031) ^ -1971910727;
					continue;
				case 6u:
					num = ((int)num2 * -1211691854) ^ 0x43B1645A;
					continue;
				case 5u:
					EditProfile.smethod_14((Control)(object)MobileTxt, new Point(135, 211));
					EditProfile.smethod_15((Control)(object)MobileTxt, "MobileTxt");
					num = (int)((num2 * 989844861) ^ 0x5266BC6F);
					continue;
				case 4u:
					num = (int)((num2 * 774127826) ^ 0x15BF7F2D);
					continue;
				case 3u:
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox2), (Control)(object)Label2);
					num = (int)(num2 * 1425925999) ^ -1684004053;
					continue;
				case 2u:
					num = ((int)num2 * -1785982205) ^ 0x3DFA5B8E;
					continue;
				case 1u:
					EditProfile.smethod_13((Control)(object)GenderTxt, EditProfile.smethod_12("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -132882361) ^ 0x141E1FDB;
					continue;
				case 0u:
					EditProfile.smethod_18(Label2, "Name :");
					num = ((int)num2 * -675306249) ^ -351253857;
					continue;
				default:
					return;
				case 111u:
					break;
				case 187u:
					return;
				}
				break;
			}
		}
	}

	private void EditProfile_Load(object sender, EventArgs e)
	{
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Expected I4, but got Unknown
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected I4, but got Unknown
		//IL_0346: Incompatible stack heights: 0 vs 1
		//IL_0361: Incompatible stack heights: 0 vs 1
		//IL_0376: Incompatible stack heights: 0 vs 1
		//IL_037d: Incompatible stack heights: 0 vs 1
		string string_ = default(string);
		bool flag = default(bool);
		while (true)
		{
			int num = -1193626952;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD77AA10Fu) % 6u)
				{
				case 5u:
					EditProfile.smethod_51(myconnection, EditProfile.smethod_50(MyProject.Forms.Form1.provider, MyProject.Forms.Form1.datafile));
					num = ((int)num2 * -212618013) ^ 0x5F077282;
					continue;
				case 4u:
				{
					OleDbCommand oleDbCommand_ = EditProfile.smethod_52();
					num = ((int)num2 * -1517304260) ^ -1514374044;
					continue;
				}
				case 1u:
					string_ = EditProfile.smethod_53("Select * From [Staff] Where [Username] = '", MyProject.Forms.Form1.username, "';");
					num = (int)((num2 * 1684612247) ^ 0x70241C34);
					continue;
				case 0u:
					EditProfile.smethod_54(myconnection);
					num = (int)((num2 * 1681685193) ^ 0x1806E7E8);
					continue;
				case 2u:
					break;
				default:
					try
					{
						OleDbCommand oleDbCommand_ = EditProfile.smethod_55(string_, myconnection);
						OleDbDataReader oleDbDataReader_ = EditProfile.smethod_56(oleDbCommand_);
						while (true)
						{
							int num3 = -984186160;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xD77AA10Fu) % 16u)
								{
								case 15u:
									num3 = ((int)num2 * -218036564) ^ -68416979;
									continue;
								case 14u:
								{
									int num4;
									int num5;
									if (!flag)
									{
										num4 = 1668088194;
										num5 = 1668088194;
									}
									else
									{
										num4 = 639808261;
										num5 = 639808261;
									}
									num3 = num4 ^ ((int)num2 * -1211072547);
									continue;
								}
								case 13u:
									EditProfile.smethod_59(NameTxt, EditProfile.smethod_58(EditProfile.smethod_57(oleDbDataReader_, 1)));
									num3 = ((int)num2 * -1054559415) ^ 0x50622CEA;
									continue;
								case 12u:
									EditProfile.smethod_59(SIDTxt, EditProfile.smethod_58(EditProfile.smethod_57(oleDbDataReader_, 0)));
									num3 = -1937333666;
									continue;
								case 11u:
									EditProfile.smethod_61(myconnection);
									num3 = (int)(num2 * 687737330) ^ -1872598272;
									continue;
								case 10u:
									num3 = ((int)num2 * -627087784) ^ -722431863;
									continue;
								case 8u:
									EditProfile.smethod_59(DOBTxt, EditProfile.smethod_58(EditProfile.smethod_57(oleDbDataReader_, 3)));
									num3 = ((int)num2 * -1470491679) ^ 0x7A751B02;
									continue;
								case 7u:
									num3 = ((int)num2 * -2015894195) ^ 0x1632E0A7;
									continue;
								case 6u:
									flag = EditProfile.smethod_60(oleDbDataReader_);
									num3 = -378794223;
									continue;
								case 5u:
									EditProfile.smethod_59(GenderTxt, EditProfile.smethod_58(EditProfile.smethod_57(oleDbDataReader_, 4)));
									num3 = (int)((num2 * 1255968032) ^ 0x664D1F18);
									continue;
								case 4u:
									EditProfile.smethod_59(AddressTxt, EditProfile.smethod_58(EditProfile.smethod_57(oleDbDataReader_, 6)));
									primary_key = EditProfile.smethod_58(EditProfile.smethod_57(oleDbDataReader_, 0));
									password = EditProfile.smethod_58(EditProfile.smethod_57(oleDbDataReader_, 9));
									num3 = ((int)num2 * -170524088) ^ 0x218563E5;
									continue;
								case 3u:
									EditProfile.smethod_59(MobileTxt, EditProfile.smethod_58(EditProfile.smethod_57(oleDbDataReader_, 5)));
									num3 = ((int)num2 * -888056264) ^ -690544733;
									continue;
								case 1u:
									num3 = (int)((num2 * 848976115) ^ 0xD138A71);
									continue;
								case 0u:
									num3 = ((int)num2 * -1697948964) ^ -600541113;
									continue;
								default:
									return;
								case 2u:
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
						EditProfile.smethod_62(exception_);
						while (true)
						{
							_ = -967060464;
							while (true)
							{
								_003F val = /*Error near IL_0318: Stack underflow*/^ -679829233;
								num2 = (uint)(int)val;
								switch (val % 5)
								{
								default:
									return;
								case 4:
									_ = ((int)num2 * -448665201) ^ -2129349676;
									continue;
								case 3:
									EditProfile.smethod_61(myconnection);
									_ = (num2 * 75377095) ^ 0x274E4D75;
									continue;
								case 1:
									EditProfile.smethod_63();
									_ = ((int)num2 * -392094094) ^ 0x5A74398E;
									continue;
								case 0:
									break;
								case 2:
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

	private void UpdateBtn_Click(object sender, EventArgs e)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected I4, but got Unknown
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected I4, but got Unknown
		//IL_0232: Incompatible stack heights: 0 vs 1
		//IL_0239: Incompatible stack heights: 0 vs 1
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		bool flag = default(bool);
		string string_ = default(string);
		while (true)
		{
			int num = -1175198505;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF69C3B1Cu) % 8u)
				{
				case 6u:
				{
					OleDbCommand val = EditProfile.smethod_52();
					num = -1000664996;
					continue;
				}
				case 5u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1447023129;
						num5 = 1447023129;
					}
					else
					{
						num4 = 1614368371;
						num5 = 1614368371;
					}
					num = num4 ^ ((int)num2 * -1517803657);
					continue;
				}
				case 4u:
					EditProfile.smethod_67("Incorrect Credentials");
					num = ((int)num2 * -981648116) ^ 0x665BE475;
					continue;
				case 3u:
					flag = !MyProject.Forms.Form1.Mobile_Validator(EditProfile.smethod_65(EditProfile.smethod_64(MobileTxt))) | (EditProfile.smethod_66(EditProfile.smethod_64(AddressTxt), "", bool_0: false) == 0);
					num = (int)(num2 * 677755128) ^ -1188195519;
					continue;
				case 0u:
					string_ = EditProfile.smethod_68(new string[7]
					{
						"Update [Staff] Set [Mobile] = '",
						EditProfile.smethod_64(MobileTxt),
						"', [Address] = '",
						EditProfile.smethod_64(AddressTxt),
						"' Where [SID] = ",
						primary_key,
						";"
					});
					num = ((int)num2 * -1412675566) ^ 0xCF91D86;
					continue;
				case 7u:
					break;
				default:
					EditProfile.smethod_54(myconnection);
					try
					{
						OleDbCommand val = EditProfile.smethod_55(string_, myconnection);
						EditProfile.smethod_69(val);
						while (true)
						{
							int num3 = -285049858;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xF69C3B1Cu) % 6u)
								{
								case 4u:
									EditProfile.smethod_61(myconnection);
									num3 = (int)(num2 * 715729325) ^ -2116246907;
									continue;
								case 3u:
									num3 = (int)(num2 * 673436630) ^ -727470534;
									continue;
								case 2u:
									EditProfile.smethod_70((Component)(object)val);
									num3 = ((int)num2 * -1100985350) ^ -1630824831;
									continue;
								case 1u:
									EditProfile.smethod_67("Successfully Updated Details");
									num3 = (int)(num2 * 1268798485) ^ -2036093461;
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
					catch (Exception ex)
					{
						EditProfile.smethod_62(ex);
						Exception exception_ = ex;
						while (true)
						{
							_ = -597895489;
							while (true)
							{
								_003F val2 = /*Error near IL_0201: Stack underflow*/^ -157533412;
								num2 = (uint)(int)val2;
								switch (val2 % 3)
								{
								case 1:
									EditProfile.smethod_61(myconnection);
									_ = ((int)num2 * -1319040594) ^ 0x7AEFBF1F;
									continue;
								case 2:
									break;
								default:
									EditProfile.smethod_67(EditProfile.smethod_71(exception_));
									EditProfile.smethod_63();
									return;
								}
								break;
							}
						}
					}
				case 1u:
					return;
				}
				break;
			}
		}
	}

	private void ChangePasswdBtn_Click(object sender, EventArgs e)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected I4, but got Unknown
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected I4, but got Unknown
		//IL_0291: Incompatible stack heights: 0 vs 1
		//IL_02a6: Incompatible stack heights: 0 vs 1
		//IL_02c1: Incompatible stack heights: 0 vs 1
		//IL_02c8: Incompatible stack heights: 0 vs 1
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		if (EditProfile.smethod_66(EditProfile.smethod_64(OldPasswdTxt), password, bool_0: false) != 0)
		{
			goto IL_003f;
		}
		goto IL_0138;
		IL_0138:
		int num = -733988417;
		goto IL_00fd;
		IL_00fd:
		string string_ = default(string);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x9B6027B0u) % 10u)
			{
			case 8u:
				EditProfile.smethod_54(myconnection);
				num = (int)((num2 * 1865703416) ^ 0x71487490);
				continue;
			case 7u:
				break;
			case 5u:
			{
				OleDbCommand val = EditProfile.smethod_52();
				num = -1943593680;
				continue;
			}
			case 3u:
				EditProfile.smethod_67("Invalid Old Password");
				num = (int)(num2 * 529062833) ^ -1641999051;
				continue;
			case 1u:
			{
				int num4;
				int num5;
				if (EditProfile.smethod_66(EditProfile.smethod_64(NewPasswdTxt), "", bool_0: false) == 0)
				{
					num4 = 92489164;
					num5 = 92489164;
				}
				else
				{
					num4 = 955940121;
					num5 = 955940121;
				}
				num = num4 ^ (int)(num2 * 1002476328);
				continue;
			}
			case 0u:
				string_ = EditProfile.smethod_68(new string[5]
				{
					"Update [Staff] Set [Password] = '",
					EditProfile.smethod_64(NewPasswdTxt),
					"' Where [SID] = ",
					primary_key,
					";"
				});
				num = ((int)num2 * -872097871) ^ 0x69FE9380;
				continue;
			case 9u:
				goto IL_0138;
			default:
				try
				{
					while (true)
					{
						int num3 = -287616847;
						while (true)
						{
							switch ((num2 = (uint)num3 ^ 0x9B6027B0u) % 9u)
							{
							case 8u:
								EditProfile.smethod_61(myconnection);
								num3 = ((int)num2 * -960038566) ^ -1222728599;
								continue;
							case 6u:
								EditProfile.smethod_67("Successfully Updated Password");
								num3 = (int)(num2 * 646619983) ^ -1584090210;
								continue;
							case 4u:
							{
								OleDbCommand val = EditProfile.smethod_55(string_, myconnection);
								EditProfile.smethod_69(val);
								EditProfile.smethod_70((Component)(object)val);
								num3 = ((int)num2 * -1574386008) ^ -2093461898;
								continue;
							}
							case 3u:
								EditProfile.smethod_72((TextBoxBase)(object)NewPasswdTxt);
								num3 = (int)(num2 * 1937072742) ^ -290155606;
								continue;
							case 2u:
								num3 = (int)((num2 * 1854955875) ^ 0x289CF91);
								continue;
							case 1u:
								num3 = ((int)num2 * -210803247) ^ -1961826948;
								continue;
							case 0u:
								password = EditProfile.smethod_64(NewPasswdTxt);
								EditProfile.smethod_72((TextBoxBase)(object)OldPasswdTxt);
								num3 = ((int)num2 * -1782317187) ^ 0xC01B063;
								continue;
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
				catch (Exception exception_)
				{
					EditProfile.smethod_62(exception_);
					while (true)
					{
						_ = -964253261;
						while (true)
						{
							_003F val2 = /*Error near IL_0263: Stack underflow*/^ -1688197200;
							num2 = (uint)(int)val2;
							switch (val2 % 5)
							{
							default:
								return;
							case 3:
								_ = (num2 * 422080402) ^ 0xC6E6CE47u;
								continue;
							case 1:
								EditProfile.smethod_63();
								_ = ((int)num2 * -663118704) ^ 0x643698C2;
								continue;
							case 0:
								EditProfile.smethod_61(myconnection);
								_ = (num2 * 842422628) ^ 0x7339AF47;
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
			case 6u:
				EditProfile.smethod_67("Password cannot be empty field");
				return;
			case 4u:
				return;
			}
			break;
		}
		goto IL_003f;
		IL_003f:
		num = -157337619;
		goto IL_00fd;
	}

	private void CheckBox1_CheckedChanged(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 105155906;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x565A1C6Au) % 11u)
				{
				case 9u:
					num = ((int)num2 * -750486673) ^ -106347942;
					continue;
				case 8u:
					EditProfile.smethod_31(OldPasswdTxt, bool_0: false);
					num = ((int)num2 * -943109707) ^ -1730936973;
					continue;
				case 7u:
					num = ((int)num2 * -1828191524) ^ 0xBAF9837;
					continue;
				case 6u:
					EditProfile.smethod_31(OldPasswdTxt, bool_0: true);
					EditProfile.smethod_31(NewPasswdTxt, bool_0: true);
					num = 347744805;
					continue;
				case 5u:
					EditProfile.smethod_31(NewPasswdTxt, bool_0: false);
					num = ((int)num2 * -1947150468) ^ -1287810206;
					continue;
				case 3u:
					num = ((int)num2 * -321706774) ^ 0x5403B531;
					continue;
				case 2u:
					num = ((int)num2 * -1899673908) ^ 0x3441DAD7;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!EditProfile.smethod_73(OldPasswdTxt))
					{
						num3 = -255779333;
						num4 = -255779333;
					}
					else
					{
						num3 = -567848170;
						num4 = -567848170;
					}
					num = num3 ^ ((int)num2 * -712018242);
					continue;
				}
				case 0u:
					num = ((int)num2 * -750166063) ^ -151543358;
					continue;
				default:
					return;
				case 4u:
					break;
				case 10u:
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

	static TextBox smethod_5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new TextBox();
	}

	static Button smethod_6()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Button();
	}

	static CheckBox smethod_7()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new CheckBox();
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

	static Font smethod_12(string string_0, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_13(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
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

	static void smethod_17(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static void smethod_18(Label label_0, string string_0)
	{
		label_0.set_Text(string_0);
	}

	static void smethod_19(Label label_0, ContentAlignment contentAlignment_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		label_0.set_TextAlign(contentAlignment_0);
	}

	static ControlCollection smethod_20(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_21(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_22(GroupBox groupBox_0, bool bool_0)
	{
		groupBox_0.set_TabStop(bool_0);
	}

	static void smethod_23(GroupBox groupBox_0, string string_0)
	{
		groupBox_0.set_Text(string_0);
	}

	static void smethod_24(TextBoxBase textBoxBase_0, bool bool_0)
	{
		textBoxBase_0.set_ReadOnly(bool_0);
	}

	static void smethod_25(ButtonBase buttonBase_0, Color color_0)
	{
		buttonBase_0.set_BackColor(color_0);
	}

	static void smethod_26(Control control_0, Color color_0)
	{
		control_0.set_ForeColor(color_0);
	}

	static void smethod_27(ButtonBase buttonBase_0, string string_0)
	{
		buttonBase_0.set_Text(string_0);
	}

	static void smethod_28(ButtonBase buttonBase_0, bool bool_0)
	{
		buttonBase_0.set_UseVisualStyleBackColor(bool_0);
	}

	static void smethod_29(TextBox textBox_0, bool bool_0)
	{
		textBox_0.set_Multiline(bool_0);
	}

	static void smethod_30(ButtonBase buttonBase_0, bool bool_0)
	{
		buttonBase_0.set_AutoSize(bool_0);
	}

	static void smethod_31(TextBox textBox_0, bool bool_0)
	{
		textBox_0.set_UseSystemPasswordChar(bool_0);
	}

	static void smethod_32(PictureBox pictureBox_0, Image image_0)
	{
		pictureBox_0.set_Image(image_0);
	}

	static void smethod_33(PictureBox pictureBox_0, PictureBoxSizeMode pictureBoxSizeMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		pictureBox_0.set_SizeMode(pictureBoxSizeMode_0);
	}

	static void smethod_34(PictureBox pictureBox_0, int int_0)
	{
		pictureBox_0.set_TabIndex(int_0);
	}

	static void smethod_35(PictureBox pictureBox_0, bool bool_0)
	{
		pictureBox_0.set_TabStop(bool_0);
	}

	static void smethod_36(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_37(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_38(Control control_0, Color color_0)
	{
		control_0.set_BackColor(color_0);
	}

	static ControlCollection smethod_39(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_40(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_41(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_42(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_43(Control control_0)
	{
		control_0.PerformLayout();
	}

	static void smethod_44(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.EndInit();
	}

	static void smethod_45(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_46(Control control_0, EventHandler eventHandler_0)
	{
		control_0.remove_Click(eventHandler_0);
	}

	static void smethod_47(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_Click(eventHandler_0);
	}

	static void smethod_48(CheckBox checkBox_0, EventHandler eventHandler_0)
	{
		checkBox_0.remove_CheckedChanged(eventHandler_0);
	}

	static void smethod_49(CheckBox checkBox_0, EventHandler eventHandler_0)
	{
		checkBox_0.add_CheckedChanged(eventHandler_0);
	}

	static string smethod_50(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static void smethod_51(OleDbConnection oleDbConnection_0, string string_0)
	{
		oleDbConnection_0.set_ConnectionString(string_0);
	}

	static OleDbCommand smethod_52()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new OleDbCommand();
	}

	static string smethod_53(string string_0, string string_1, string string_2)
	{
		return string_0 + string_1 + string_2;
	}

	static void smethod_54(OleDbConnection oleDbConnection_0)
	{
		oleDbConnection_0.Open();
	}

	static OleDbCommand smethod_55(string string_0, OleDbConnection oleDbConnection_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new OleDbCommand(string_0, oleDbConnection_0);
	}

	static OleDbDataReader smethod_56(OleDbCommand oleDbCommand_0)
	{
		return oleDbCommand_0.ExecuteReader();
	}

	static object smethod_57(OleDbDataReader oleDbDataReader_0, int int_0)
	{
		return oleDbDataReader_0.get_Item(int_0);
	}

	static string smethod_58(object object_0)
	{
		return Conversions.ToString(object_0);
	}

	static void smethod_59(TextBox textBox_0, string string_0)
	{
		textBox_0.set_Text(string_0);
	}

	static bool smethod_60(OleDbDataReader oleDbDataReader_0)
	{
		return oleDbDataReader_0.Read();
	}

	static void smethod_61(OleDbConnection oleDbConnection_0)
	{
		oleDbConnection_0.Close();
	}

	static void smethod_62(Exception exception_0)
	{
		ProjectData.SetProjectError(exception_0);
	}

	static void smethod_63()
	{
		ProjectData.ClearProjectError();
	}

	static string smethod_64(TextBox textBox_0)
	{
		return textBox_0.get_Text();
	}

	static string smethod_65(string string_0)
	{
		return string_0.ToLower();
	}

	static int smethod_66(string string_0, string string_1, bool bool_0)
	{
		return Operators.CompareString(string_0, string_1, bool_0);
	}

	static DialogResult smethod_67(string string_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0);
	}

	static string smethod_68(string[] string_0)
	{
		return string.Concat(string_0);
	}

	static int smethod_69(OleDbCommand oleDbCommand_0)
	{
		return oleDbCommand_0.ExecuteNonQuery();
	}

	static void smethod_70(Component component_0)
	{
		component_0.Dispose();
	}

	static string smethod_71(Exception exception_0)
	{
		return exception_0.Message;
	}

	static void smethod_72(TextBoxBase textBoxBase_0)
	{
		textBoxBase_0.Clear();
	}

	static bool smethod_73(TextBox textBox_0)
	{
		return textBox_0.get_UseSystemPasswordChar();
	}
}
