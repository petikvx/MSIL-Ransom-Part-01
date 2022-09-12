using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hospital_Management_System.My;
using Hospital_Management_System.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Hospital_Management_System;

[DesignerGenerated]
public class AddStaff_Admin : UserControl
{
	private IContainer components;

	private string username;

	private string password;

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

	[field: AccessedThroughProperty("SuccessMsg")]
	internal virtual Label SuccessMsg
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

	[field: AccessedThroughProperty("GenderTxt")]
	internal virtual ComboBox GenderTxt
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

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
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

	[field: AccessedThroughProperty("DesignationTxt")]
	internal virtual ComboBox DesignationTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button RegisterBtn
	{
		[CompilerGenerated]
		get
		{
			return _RegisterBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = RegisterBtn_Click;
			Button registerBtn = _RegisterBtn;
			while (true)
			{
				int num = -285260583;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEF1E8619u) % 7u)
					{
					case 5u:
					{
						int num5;
						int num6;
						if (registerBtn == null)
						{
							num5 = 1786109349;
							num6 = 1786109349;
						}
						else
						{
							num5 = 704263443;
							num6 = 704263443;
						}
						num = num5 ^ (int)(num2 * 1625062934);
						continue;
					}
					case 4u:
						AddStaff_Admin.smethod_60((Control)(object)registerBtn, eventHandler_);
						num = (int)(num2 * 184142172) ^ -1135079747;
						continue;
					case 3u:
						AddStaff_Admin.smethod_61((Control)(object)registerBtn, eventHandler_);
						num = ((int)num2 * -269961523) ^ -1527587977;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (registerBtn == null)
						{
							num3 = 567190492;
							num4 = 567190492;
						}
						else
						{
							num3 = 131275306;
							num4 = 131275306;
						}
						num = num3 ^ (int)(num2 * 895913169);
						continue;
					}
					case 1u:
						_RegisterBtn = value;
						registerBtn = _RegisterBtn;
						num = -1992271132;
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
				int num = 768836481;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x378D4EBCu) % 7u)
					{
					case 6u:
						AddStaff_Admin.smethod_61((Control)(object)clearBtn, eventHandler_);
						num = ((int)num2 * -324788171) ^ 0x6FA61BC1;
						continue;
					case 5u:
						_ClearBtn = value;
						clearBtn = _ClearBtn;
						num = 79856704;
						continue;
					case 3u:
					{
						clearBtn = _ClearBtn;
						int num5;
						int num6;
						if (clearBtn == null)
						{
							num5 = 6561684;
							num6 = 6561684;
						}
						else
						{
							num5 = 36034426;
							num6 = 36034426;
						}
						num = num5 ^ ((int)num2 * -289553392);
						continue;
					}
					case 2u:
					{
						int num3;
						int num4;
						if (clearBtn == null)
						{
							num3 = -1891786768;
							num4 = -1891786768;
						}
						else
						{
							num3 = -100372799;
							num4 = -100372799;
						}
						num = num3 ^ ((int)num2 * -1943080858);
						continue;
					}
					case 0u:
						AddStaff_Admin.smethod_60((Control)(object)clearBtn, eventHandler_);
						num = (int)((num2 * 758565519) ^ 0x19BEB20E);
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

	internal virtual Timer Timer1
	{
		[CompilerGenerated]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = Timer1_Tick;
			Timer timer = _Timer1;
			while (true)
			{
				int num = -619310074;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF06C17BFu) % 7u)
					{
					case 6u:
					{
						timer = _Timer1;
						int num5;
						int num6;
						if (timer != null)
						{
							num5 = 1099895705;
							num6 = 1099895705;
						}
						else
						{
							num5 = 463219207;
							num6 = 463219207;
						}
						num = num5 ^ ((int)num2 * -1320588945);
						continue;
					}
					case 5u:
						_Timer1 = value;
						num = -1518231661;
						continue;
					case 4u:
						AddStaff_Admin.smethod_62(timer, eventHandler_);
						num = (int)(num2 * 2052828124) ^ -2001160590;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (timer != null)
						{
							num3 = -766179784;
							num4 = -766179784;
						}
						else
						{
							num3 = -1935618521;
							num4 = -1935618521;
						}
						num = num3 ^ ((int)num2 * -1737644875);
						continue;
					}
					case 0u:
						AddStaff_Admin.smethod_63(timer, eventHandler_);
						num = (int)((num2 * 1127800245) ^ 0x4EFA8149);
						continue;
					default:
						return;
					case 2u:
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

	public AddStaff_Admin()
	{
		AddStaff_Admin.smethod_0((UserControl)(object)this, (EventHandler)AddStaff_Admin_Load);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			bool flag = default(bool);
			while (true)
			{
				int num = 557566866;
				while (true)
				{
					uint num2;
					int num5;
					switch ((num2 = (uint)num ^ 0x3D2D562Au) % 9u)
					{
					case 8u:
						AddStaff_Admin.smethod_1((IDisposable)components);
						num = ((int)num2 * -484573104) ^ 0x1D2F83A6;
						continue;
					case 7u:
						num = (int)(num2 * 1002984259) ^ -892467830;
						continue;
					case 5u:
						num = ((int)num2 * -916025760) ^ -805835367;
						continue;
					case 4u:
						if (disposing)
						{
							num = (int)(num2 * 1741716067) ^ -1739350465;
							continue;
						}
						num5 = 0;
						goto IL_0052;
					case 2u:
						num = 214141611;
						continue;
					case 1u:
						num5 = ((components != null) ? 1 : 0);
						goto IL_0052;
					case 0u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -1997027396;
							num4 = -1997027396;
						}
						else
						{
							num3 = -916201323;
							num4 = -916201323;
						}
						num = num3 ^ ((int)num2 * -1828317765);
						continue;
					}
					default:
						return;
					case 3u:
						break;
					case 6u:
						return;
						IL_0052:
						flag = (byte)num5 != 0;
						num = 936928600;
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
		components = AddStaff_Admin.smethod_2();
		while (true)
		{
			int num = 643708189;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x284346D7u) % 257u)
				{
				case 256u:
					num = (int)((num2 * 1429722331) ^ 0x20B7E67E);
					continue;
				case 255u:
					AddStaff_Admin.smethod_15((Control)(object)DesignationTxt, new Point(137, 262));
					num = (int)(num2 * 2035357550) ^ -1825141960;
					continue;
				case 254u:
					AddStaff_Admin.smethod_24(Label1, "Add Staff");
					num = (int)((num2 * 275671962) ^ 0x18940DB2);
					continue;
				case 253u:
					AddStaff_Admin.smethod_22((Control)(object)Label7, AddStaff_Admin.smethod_21("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 923702951) ^ 0x4C0D90AE);
					continue;
				case 252u:
					AddStaff_Admin.smethod_17((Control)(object)Label2, new Size(92, 23));
					num = (int)(num2 * 638784766) ^ -482681141;
					continue;
				case 251u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_30((Control)(object)GroupBox2), (Control)(object)Label4);
					num = ((int)num2 * -1290214905) ^ -2024664580;
					continue;
				case 250u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_30((Control)(object)GroupBox2), (Control)(object)MobileTxt);
					num = ((int)num2 * -1946909774) ^ -2099375171;
					continue;
				case 249u:
					AddStaff_Admin.smethod_13((Control)(object)this);
					num = ((int)num2 * -1510600477) ^ 0x69EEEB99;
					continue;
				case 248u:
					num = (int)(num2 * 1739021567) ^ -1204058796;
					continue;
				case 247u:
					num = (int)(num2 * 1584149491) ^ -1753159072;
					continue;
				case 246u:
					num = ((int)num2 * -1029024506) ^ -99598478;
					continue;
				case 245u:
					num = (int)((num2 * 1486080450) ^ 0x7D36667A);
					continue;
				case 244u:
					AddStaff_Admin.smethod_24(Label4, "D.O.B :");
					num = (int)((num2 * 1383133380) ^ 0x2577AF17);
					continue;
				case 243u:
					AddStaff_Admin.smethod_16((Control)(object)Label6, "Label6");
					num = (int)(num2 * 139106568) ^ -25993400;
					continue;
				case 242u:
					num = (int)(num2 * 1773858290) ^ -972400033;
					continue;
				case 241u:
					AddStaff_Admin.smethod_16((Control)(object)Label7, "Label7");
					num = ((int)num2 * -1542506480) ^ -362928269;
					continue;
				case 240u:
					num = ((int)num2 * -1445599568) ^ 0x3DB56162;
					continue;
				case 239u:
					AddStaff_Admin.smethod_22((Control)(object)Label2, AddStaff_Admin.smethod_21("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -627157228) ^ 0x3E8CCF15;
					continue;
				case 238u:
					num = ((int)num2 * -68765629) ^ 0x6DFE8C06;
					continue;
				case 237u:
					AddStaff_Admin.smethod_23((Control)(object)Label4, 7);
					num = ((int)num2 * -1059690649) ^ 0x1DFD31D8;
					continue;
				case 236u:
					num = (int)((num2 * 1004816507) ^ 0x4EEC6EE0);
					continue;
				case 235u:
					num = (int)((num2 * 288415295) ^ 0x16C31CD1);
					continue;
				case 234u:
					AddStaff_Admin.smethod_22((Control)(object)Label4, AddStaff_Admin.smethod_21("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -859281669) ^ -504833114;
					continue;
				case 233u:
					AddStaff_Admin.smethod_16((Control)(object)PictureBox1, "PictureBox1");
					num = (int)((num2 * 1280547034) ^ 0x3AC3114);
					continue;
				case 232u:
					AddStaff_Admin.smethod_49((ButtonBase)(object)ClearBtn, bool_0: false);
					num = (int)(num2 * 1611531896) ^ -1506416281;
					continue;
				case 231u:
					num = ((int)num2 * -436874035) ^ -1115636850;
					continue;
				case 230u:
					AddStaff_Admin.smethod_16((Control)(object)DOBTxt, "DOBTxt");
					num = ((int)num2 * -465104796) ^ -525329683;
					continue;
				case 229u:
					AddStaff_Admin.smethod_23((Control)(object)Label2, 5);
					num = ((int)num2 * -1988634902) ^ 0x64C21C1B;
					continue;
				case 228u:
					AddStaff_Admin.smethod_16((Control)(object)Label9, "Label9");
					num = (int)(num2 * 428032144) ^ -546292276;
					continue;
				case 226u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_30((Control)(object)GroupBox2), (Control)(object)Label6);
					num = ((int)num2 * -9452743) ^ -2009467561;
					continue;
				case 225u:
					AddStaff_Admin.smethod_23((Control)(object)Label9, 18);
					AddStaff_Admin.smethod_24(Label9, "Email :");
					num = (int)((num2 * 420595311) ^ 0x6BBE7336);
					continue;
				case 224u:
					AddStaff_Admin.smethod_17((Control)(object)Label5, new Size(94, 29));
					AddStaff_Admin.smethod_23((Control)(object)Label5, 8);
					num = (int)((num2 * 1596544638) ^ 0x620E9F7F);
					continue;
				case 223u:
					AddStaff_Admin.smethod_25(Label4, (ContentAlignment)32);
					AddStaff_Admin.smethod_22((Control)(object)Label3, AddStaff_Admin.smethod_21("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -758548821) ^ 0x2A1778AB;
					continue;
				case 222u:
					num = ((int)num2 * -1239630323) ^ 0x4399E282;
					continue;
				case 221u:
					num = (int)(num2 * 209081024) ^ -531680448;
					continue;
				case 220u:
					AddStaff_Admin.smethod_47((ButtonBase)(object)ClearBtn, Color.MidnightBlue);
					num = (int)(num2 * 1781149015) ^ -871156385;
					continue;
				case 219u:
					AddStaff_Admin.smethod_22((Control)(object)WorkShiftTxt, AddStaff_Admin.smethod_21("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 775685642) ^ 0xBC0C3C4);
					continue;
				case 218u:
					num = ((int)num2 * -1728401946) ^ -1622643026;
					continue;
				case 217u:
					AddStaff_Admin.smethod_23((Control)(object)ClearBtn, 15);
					AddStaff_Admin.smethod_48((ButtonBase)(object)ClearBtn, "Clear");
					num = (int)((num2 * 425449568) ^ 0x2BC5E2D6);
					continue;
				case 216u:
					num = ((int)num2 * -350219382) ^ 0x12904BAD;
					continue;
				case 215u:
					AddStaff_Admin.smethod_15((Control)(object)GroupBox2, new Point(261, 235));
					num = (int)(num2 * 862776273) ^ -395626545;
					continue;
				case 214u:
					num = ((int)num2 * -40970994) ^ -128915417;
					continue;
				case 213u:
					AddStaff_Admin.smethod_40(DesignationTxt, (AutoCompleteMode)2);
					num = ((int)num2 * -525502937) ^ 0xD8796FF;
					continue;
				case 212u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_30((Control)(object)GroupBox2), (Control)(object)Label5);
					num = ((int)num2 * -2031038537) ^ 0x1B4C1CB;
					continue;
				case 211u:
					AddStaff_Admin.smethod_22((Control)(object)Label6, AddStaff_Admin.smethod_21("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -207407951) ^ 0x7D856557;
					continue;
				case 210u:
					AddStaff_Admin.smethod_15((Control)(object)EmailTxt, new Point(137, 307));
					num = ((int)num2 * -409178584) ^ -1745737009;
					continue;
				case 209u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_30((Control)(object)GroupBox2), (Control)(object)Label3);
					num = (int)(num2 * 2002640435) ^ -17729653;
					continue;
				case 208u:
					num = ((int)num2 * -853539628) ^ -970748855;
					continue;
				case 207u:
					num = ((int)num2 * -297638812) ^ 0x251C96E0;
					continue;
				case 206u:
					num = (int)(num2 * 2032326105) ^ -657893315;
					continue;
				case 205u:
					AddStaff_Admin.smethod_39(AddStaff_Admin.smethod_38(DesignationTxt), new string[3] { "Male", "Female", "Others" });
					num = (int)((num2 * 1137936310) ^ 0x49791820);
					continue;
				case 204u:
					AddStaff_Admin.smethod_22((Control)(object)Label5, AddStaff_Admin.smethod_21("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1136601107) ^ 0x2F96BC1B);
					continue;
				case 203u:
					AddStaff_Admin.smethod_52((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -685172924) ^ -1834575772;
					continue;
				case 202u:
					AddStaff_Admin.smethod_22((Control)(object)MobileTxt, AddStaff_Admin.smethod_21("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1096360838) ^ -1594583872;
					continue;
				case 201u:
					num = (int)((num2 * 337438161) ^ 0x72D90B8C);
					continue;
				case 200u:
					AddStaff_Admin.smethod_24(Label2, "Name :");
					num = ((int)num2 * -953367372) ^ -1584246526;
					continue;
				case 199u:
					AddStaff_Admin.smethod_15((Control)(object)Label5, new Point(8, 144));
					num = ((int)num2 * -1724955424) ^ 0x6F685BEE;
					continue;
				case 198u:
					num = ((int)num2 * -1578512815) ^ -9408663;
					continue;
				case 197u:
					num = ((int)num2 * -1022028318) ^ -65553231;
					continue;
				case 196u:
					AddStaff_Admin.smethod_15((Control)(object)RegisterBtn, new Point(608, 703));
					num = ((int)num2 * -62856241) ^ 0x7DE917AB;
					continue;
				case 195u:
					AddStaff_Admin.smethod_40(GenderTxt, (AutoCompleteMode)2);
					num = ((int)num2 * -1337608768) ^ -2083782884;
					continue;
				case 194u:
					AddStaff_Admin.smethod_15((Control)(object)Label6, new Point(15, 348));
					num = ((int)num2 * -698899766) ^ 0x441B1C66;
					continue;
				case 193u:
					AddStaff_Admin.smethod_15((Control)(object)DOBTxt, new Point(137, 102));
					num = (int)(num2 * 1596083691) ^ -801405923;
					continue;
				case 192u:
					num = (int)((num2 * 578388954) ^ 0xC32FAC7);
					continue;
				case 191u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_30((Control)(object)GroupBox2), (Control)(object)WorkShiftTxt);
					num = ((int)num2 * -329709892) ^ 0x4E8ED580;
					continue;
				case 190u:
					AddStaff_Admin.smethod_36(DOBTxt, new DateTime(1900, 1, 1, 0, 0, 0, 0));
					num = ((int)num2 * -1989297556) ^ -1420435257;
					continue;
				case 189u:
					AddStaff_Admin.smethod_16((Control)(object)DesignationTxt, "DesignationTxt");
					num = ((int)num2 * -2008787188) ^ 0x2DF7DD03;
					continue;
				case 188u:
					AddStaff_Admin.smethod_43((ListControl)(object)WorkShiftTxt, bool_0: true);
					AddStaff_Admin.smethod_45(AddStaff_Admin.smethod_44(WorkShiftTxt), new object[2] { "Day", "Night" });
					num = (int)((num2 * 1383329008) ^ 0x59C4B24F);
					continue;
				case 187u:
					AddStaff_Admin.smethod_54((Control)(object)this, "AddStaff_Admin");
					AddStaff_Admin.smethod_55((Control)(object)this, new Size(977, 804));
					num = (int)(num2 * 345428520) ^ -1411415792;
					continue;
				case 186u:
					AddStaff_Admin.smethod_22((Control)(object)EmailTxt, AddStaff_Admin.smethod_21("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1881413551) ^ 0x79351765;
					continue;
				case 185u:
					AddStaff_Admin.smethod_17((Control)(object)Label1, new Size(330, 47));
					num = ((int)num2 * -520162468) ^ -1638105254;
					continue;
				case 184u:
					AddStaff_Admin.smethod_22((Control)(object)Label1, AddStaff_Admin.smethod_21("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -2041235110) ^ -1192670198;
					continue;
				case 183u:
					AddStaff_Admin.smethod_15((Control)(object)Label2, new Point(8, 55));
					num = ((int)num2 * -989320850) ^ -1972751270;
					continue;
				case 182u:
					num = (int)(num2 * 605513308) ^ -460941499;
					continue;
				case 181u:
					AddStaff_Admin.smethod_17((Control)(object)DOBTxt, new Size(208, 29));
					num = ((int)num2 * -956986818) ^ 0x3DDF0D63;
					continue;
				case 180u:
					num = (int)((num2 * 213801942) ^ 0x3948D801);
					continue;
				case 179u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_53((Control)(object)this), (Control)(object)PictureBox1);
					num = (int)((num2 * 692148987) ^ 0x63F4C3DC);
					continue;
				case 178u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_53((Control)(object)this), (Control)(object)ClearBtn);
					num = ((int)num2 * -272624662) ^ -1172098460;
					continue;
				case 177u:
					AddStaff_Admin.smethod_49((ButtonBase)(object)RegisterBtn, bool_0: false);
					num = ((int)num2 * -1182632992) ^ -250176005;
					continue;
				case 176u:
					AddStaff_Admin.smethod_23((Control)(object)NameTxt, 0);
					num = (int)(num2 * 1395515843) ^ -1892381697;
					continue;
				case 175u:
					num = ((int)num2 * -1628588906) ^ 0x43F404EB;
					continue;
				case 174u:
					Label7 = AddStaff_Admin.smethod_4();
					num = ((int)num2 * -1494304714) ^ 0x1FC31C93;
					continue;
				case 173u:
					AddStaff_Admin.smethod_29((Control)(object)SuccessMsg, bool_0: false);
					num = ((int)num2 * -393351120) ^ -730431916;
					continue;
				case 172u:
					AddStaff_Admin.smethod_42(GenderTxt, (ComboBoxStyle)2);
					num = (int)((num2 * 842839714) ^ 0x282C9AE1);
					continue;
				case 171u:
					num = ((int)num2 * -778041043) ^ -922553658;
					continue;
				case 170u:
					AddStaff_Admin.smethod_23((Control)(object)DesignationTxt, 17);
					AddStaff_Admin.smethod_22((Control)(object)Label8, AddStaff_Admin.smethod_21("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -986781977) ^ 0x5875EB51;
					continue;
				case 169u:
					GenderTxt = AddStaff_Admin.smethod_8();
					num = (int)(num2 * 1586437035) ^ -1878895567;
					continue;
				case 168u:
					num = (int)(num2 * 1529719674) ^ -854179861;
					continue;
				case 167u:
					AddStaff_Admin.smethod_17((Control)(object)GroupBox2, new Size(486, 446));
					AddStaff_Admin.smethod_23((Control)(object)GroupBox2, 13);
					AddStaff_Admin.smethod_32(GroupBox2, bool_0: false);
					AddStaff_Admin.smethod_33(GroupBox2, "Patient's Information");
					num = (int)((num2 * 1391416069) ^ 0x6DFBA869);
					continue;
				case 166u:
					AddStaff_Admin.smethod_15((Control)(object)Label7, new Point(3, 222));
					num = ((int)num2 * -1723233930) ^ -1518529241;
					continue;
				case 165u:
					num = (int)((num2 * 1528894231) ^ 0xDC7B2F4);
					continue;
				case 164u:
					num = ((int)num2 * -274711564) ^ -345949622;
					continue;
				case 163u:
					AddStaff_Admin.smethod_23((Control)(object)Label8, 16);
					AddStaff_Admin.smethod_24(Label8, "Designation :");
					num = ((int)num2 * -706510296) ^ 0xCA9058A;
					continue;
				case 162u:
					num = (int)(num2 * 1717062608) ^ -2000851274;
					continue;
				case 161u:
					AddStaff_Admin.smethod_16((Control)(object)Label5, "Label5");
					num = ((int)num2 * -2049062691) ^ -902889834;
					continue;
				case 160u:
					AddStaff_Admin.smethod_15((Control)(object)WorkShiftTxt, new Point(137, 221));
					AddStaff_Admin.smethod_16((Control)(object)WorkShiftTxt, "WorkShiftTxt");
					num = ((int)num2 * -1418602524) ^ 0x1C75AF1E;
					continue;
				case 159u:
					num = (int)((num2 * 142592792) ^ 0x4820F124);
					continue;
				case 158u:
					GroupBox2 = AddStaff_Admin.smethod_5();
					num = (int)((num2 * 572720419) ^ 0x6F60EC25);
					continue;
				case 157u:
					AddStaff_Admin.smethod_24(Label6, "Address :");
					AddStaff_Admin.smethod_25(Label6, (ContentAlignment)32);
					num = ((int)num2 * -1192227921) ^ 0x2B92DD0E;
					continue;
				case 156u:
					AddStaff_Admin.smethod_59((Control)(object)this, bool_0: false);
					num = (int)((num2 * 1072386631) ^ 0x59970801);
					continue;
				case 155u:
					AddStaff_Admin.smethod_16((Control)(object)RegisterBtn, "RegisterBtn");
					AddStaff_Admin.smethod_17((Control)(object)RegisterBtn, new Size(139, 43));
					num = ((int)num2 * -1896729074) ^ 0x351527CA;
					continue;
				case 154u:
					AddStaff_Admin.smethod_15((Control)(object)Label4, new Point(8, 101));
					num = (int)(num2 * 10194266) ^ -1994616549;
					continue;
				case 153u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_30((Control)(object)GroupBox2), (Control)(object)DOBTxt);
					num = ((int)num2 * -231867073) ^ -438365680;
					continue;
				case 152u:
					AddStaff_Admin.smethod_17((Control)(object)GenderTxt, new Size(130, 27));
					num = ((int)num2 * -548431685) ^ 0x74A0C27;
					continue;
				case 151u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_30((Control)(object)GroupBox2), (Control)(object)AddressTxt);
					num = (int)((num2 * 1492730036) ^ 0x58D075E8);
					continue;
				case 150u:
					AddStaff_Admin.smethod_18(PictureBox1, (PictureBoxSizeMode)1);
					num = ((int)num2 * -1551713072) ^ 0x731618CD;
					continue;
				case 149u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_30((Control)(object)GroupBox2), (Control)(object)EmailTxt);
					num = (int)((num2 * 507908102) ^ 0x8620340);
					continue;
				case 148u:
					AddStaff_Admin.smethod_11((ISupportInitialize)PictureBox1);
					AddStaff_Admin.smethod_12((Control)(object)GroupBox2);
					num = ((int)num2 * -723403264) ^ -1669947891;
					continue;
				case 147u:
					AddStaff_Admin.smethod_22((Control)(object)Label9, AddStaff_Admin.smethod_21("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1264302701) ^ -1875860937;
					continue;
				case 146u:
					num = (int)(num2 * 289200446) ^ -1236088849;
					continue;
				case 145u:
					num = ((int)num2 * -294135512) ^ -649470407;
					continue;
				case 144u:
					Label1 = AddStaff_Admin.smethod_4();
					num = (int)((num2 * 561932095) ^ 0x1F8E680F);
					continue;
				case 143u:
					AddStaff_Admin.smethod_16((Control)(object)GroupBox2, "GroupBox2");
					num = (int)((num2 * 1194927121) ^ 0x4FD203B4);
					continue;
				case 142u:
					AddStaff_Admin.smethod_22((Control)(object)SuccessMsg, AddStaff_Admin.smethod_21("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1613069587) ^ 0x36365564;
					continue;
				case 141u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_30((Control)(object)GroupBox2), (Control)(object)Label9);
					num = (int)((num2 * 690451952) ^ 0x244F75FF);
					continue;
				case 140u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_53((Control)(object)this), (Control)(object)Label1);
					num = ((int)num2 * -1442400115) ^ -1153184779;
					continue;
				case 139u:
					Label6 = AddStaff_Admin.smethod_4();
					num = ((int)num2 * -458922301) ^ 0x57A648EC;
					continue;
				case 138u:
					num = ((int)num2 * -807542710) ^ 0xDDF3595;
					continue;
				case 137u:
					num = (int)(num2 * 1708933197) ^ -318923679;
					continue;
				case 136u:
					num = (int)((num2 * 549813145) ^ 0x4F5B9C4E);
					continue;
				case 135u:
					AddStaff_Admin.smethod_23((Control)(object)Label6, 9);
					num = (int)(num2 * 1246599191) ^ -329298419;
					continue;
				case 134u:
					AddStaff_Admin.smethod_23((Control)(object)Label3, 6);
					num = (int)((num2 * 581393743) ^ 0x3C8C0C37);
					continue;
				case 133u:
					AddStaff_Admin.smethod_56((ISupportInitialize)PictureBox1);
					num = (int)((num2 * 761127055) ^ 0x5DE254C9);
					continue;
				case 132u:
					num = ((int)num2 * -1532646758) ^ -1276142068;
					continue;
				case 131u:
					num = ((int)num2 * -605836972) ^ -1226630441;
					continue;
				case 130u:
					AddStaff_Admin.smethod_22((Control)(object)NameTxt, AddStaff_Admin.smethod_21("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					AddStaff_Admin.smethod_15((Control)(object)NameTxt, new Point(137, 55));
					num = ((int)num2 * -319901500) ^ -994370297;
					continue;
				case 129u:
					AddStaff_Admin.smethod_34(DOBTxt, (DateTimePickerFormat)2);
					num = ((int)num2 * -2104928079) ^ 0x43D4A8F4;
					continue;
				case 128u:
					AddStaff_Admin.smethod_16((Control)(object)Label8, "Label8");
					num = ((int)num2 * -118944335) ^ 0x98E32E6;
					continue;
				case 127u:
					AddStaff_Admin.smethod_46(AddressTxt, bool_0: true);
					num = ((int)num2 * -448095321) ^ -1656941396;
					continue;
				case 126u:
					AddStaff_Admin.smethod_41(GenderTxt, (AutoCompleteSource)256);
					num = ((int)num2 * -203916749) ^ -551412784;
					continue;
				case 125u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_30((Control)(object)GroupBox2), (Control)(object)NameTxt);
					num = ((int)num2 * -2043124849) ^ -1935834418;
					continue;
				case 124u:
					num = (int)((num2 * 236396473) ^ 0x5B39162E);
					continue;
				case 123u:
					AddStaff_Admin.smethod_23((Control)(object)GenderTxt, 11);
					num = ((int)num2 * -2055062384) ^ -1548305079;
					continue;
				case 122u:
					AddStaff_Admin.smethod_15((Control)(object)ClearBtn, new Point(261, 703));
					num = (int)((num2 * 1344463638) ^ 0x532D34E5);
					continue;
				case 121u:
					AddStaff_Admin.smethod_16((Control)(object)MobileTxt, "MobileTxt");
					num = ((int)num2 * -1997023442) ^ 0x77D9E3FE;
					continue;
				case 120u:
					num = (int)(num2 * 845435920) ^ -1866640345;
					continue;
				case 119u:
					MobileTxt = AddStaff_Admin.smethod_7();
					num = ((int)num2 * -513917479) ^ -1880108424;
					continue;
				case 118u:
					num = (int)(num2 * 1990737966) ^ -1864732126;
					continue;
				case 117u:
					EmailTxt = AddStaff_Admin.smethod_7();
					Label9 = AddStaff_Admin.smethod_4();
					DesignationTxt = AddStaff_Admin.smethod_8();
					num = ((int)num2 * -905732151) ^ 0x65C22DE8;
					continue;
				case 116u:
					AddStaff_Admin.smethod_57((Control)(object)GroupBox2, bool_0: false);
					AddStaff_Admin.smethod_58((Control)(object)GroupBox2);
					num = ((int)num2 * -1626895227) ^ 0x28567CFC;
					continue;
				case 115u:
					AddStaff_Admin.smethod_15((Control)(object)AddressTxt, new Point(137, 349));
					num = (int)(num2 * 1831917566) ^ -36788380;
					continue;
				case 114u:
					num = ((int)num2 * -135247149) ^ -1242818047;
					continue;
				case 113u:
					num = ((int)num2 * -175685886) ^ -625508053;
					continue;
				case 112u:
					AddStaff_Admin.smethod_25(Label7, (ContentAlignment)32);
					num = (int)((num2 * 1107400073) ^ 0x2AFC0F62);
					continue;
				case 110u:
					AddStaff_Admin.smethod_15((Control)(object)GenderTxt, new Point(137, 182));
					num = ((int)num2 * -2090499210) ^ -2052897261;
					continue;
				case 109u:
					AddStaff_Admin.smethod_24(Label7, "Work Shift :");
					num = (int)((num2 * 1861696264) ^ 0x22082037);
					continue;
				case 108u:
					AddStaff_Admin.smethod_35(DOBTxt, new DateTime(2019, 2, 11, 0, 0, 0, 0));
					num = ((int)num2 * -744185063) ^ -167862546;
					continue;
				case 107u:
					AddStaff_Admin.smethod_22((Control)(object)ClearBtn, AddStaff_Admin.smethod_21("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1860515910) ^ -120860101;
					continue;
				case 106u:
					AddStaff_Admin.smethod_16((Control)(object)GenderTxt, "GenderTxt");
					num = (int)(num2 * 1532562774) ^ -472477592;
					continue;
				case 105u:
					AddStaff_Admin.smethod_17((Control)(object)EmailTxt, new Size(324, 26));
					AddStaff_Admin.smethod_23((Control)(object)EmailTxt, 19);
					num = ((int)num2 * -1799168355) ^ -2123529550;
					continue;
				case 104u:
					num = (int)((num2 * 2042888796) ^ 0x7DC1387);
					continue;
				case 103u:
					AddStaff_Admin.smethod_22((Control)(object)GenderTxt, AddStaff_Admin.smethod_21("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					AddStaff_Admin.smethod_43((ListControl)(object)GenderTxt, bool_0: true);
					AddStaff_Admin.smethod_45(AddStaff_Admin.smethod_44(GenderTxt), new object[3] { "Male", "Female", "Others" });
					num = ((int)num2 * -308102481) ^ -1340168878;
					continue;
				case 102u:
					PictureBox1 = AddStaff_Admin.smethod_3();
					num = ((int)num2 * -307321994) ^ -1428039193;
					continue;
				case 101u:
					num = (int)((num2 * 2017854508) ^ 0x51486631);
					continue;
				case 100u:
					num = ((int)num2 * -1439400531) ^ -1306672881;
					continue;
				case 99u:
					AddStaff_Admin.smethod_17((Control)(object)Label9, new Size(87, 26));
					num = (int)(num2 * 1579376867) ^ -1312164920;
					continue;
				case 98u:
					AddStaff_Admin.smethod_50(Timer1, 1500);
					num = ((int)num2 * -1890999805) ^ -1679536480;
					continue;
				case 97u:
					num = (int)(num2 * 464026773) ^ -512220561;
					continue;
				case 96u:
					AddStaff_Admin.smethod_22((Control)(object)AddressTxt, AddStaff_Admin.smethod_21("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1304891195) ^ -154422199;
					continue;
				case 95u:
					Label5 = AddStaff_Admin.smethod_4();
					num = ((int)num2 * -1254897749) ^ 0x26D35722;
					continue;
				case 94u:
					Timer1 = AddStaff_Admin.smethod_10(components);
					num = ((int)num2 * -1480715663) ^ 0x696E2007;
					continue;
				case 93u:
					AddStaff_Admin.smethod_15((Control)(object)Label9, new Point(13, 307));
					num = ((int)num2 * -1912109243) ^ 0x2058762;
					continue;
				case 92u:
					AddStaff_Admin.smethod_26((Control)(object)this, Color.White);
					num = (int)(num2 * 1994535594) ^ -1792848130;
					continue;
				case 91u:
					AddStaff_Admin.smethod_41(DesignationTxt, (AutoCompleteSource)256);
					num = ((int)num2 * -227858452) ^ -978096493;
					continue;
				case 90u:
					num = (int)(num2 * 313077744) ^ -77016663;
					continue;
				case 89u:
					AddStaff_Admin.smethod_14(PictureBox1, (Image)(object)Resources.doc_Pic);
					AddStaff_Admin.smethod_15((Control)(object)PictureBox1, new Point(245, 17));
					num = ((int)num2 * -2062829241) ^ 0x356C70DB;
					continue;
				case 88u:
					AddStaff_Admin.smethod_19(PictureBox1, 10);
					num = ((int)num2 * -1720425556) ^ -1554818957;
					continue;
				case 87u:
					Label2 = AddStaff_Admin.smethod_4();
					NameTxt = AddStaff_Admin.smethod_7();
					num = (int)((num2 * 496617813) ^ 0x26049947);
					continue;
				case 86u:
					AddStaff_Admin.smethod_16((Control)(object)EmailTxt, "EmailTxt");
					num = (int)(num2 * 884288453) ^ -1237029255;
					continue;
				case 85u:
					num = ((int)num2 * -1192410284) ^ 0x7D11DBE3;
					continue;
				case 84u:
					num = ((int)num2 * -2021389863) ^ 0x785FE873;
					continue;
				case 83u:
					num = ((int)num2 * -2015205388) ^ 0x76924745;
					continue;
				case 82u:
					num = (int)(num2 * 1482164226) ^ -1822566894;
					continue;
				case 81u:
					AddStaff_Admin.smethod_39(AddStaff_Admin.smethod_38(GenderTxt), new string[3] { "Male", "Female", "Others" });
					num = ((int)num2 * -668753131) ^ 0x10AF8297;
					continue;
				case 80u:
					AddStaff_Admin.smethod_28((Control)(object)SuccessMsg, AddStaff_Admin.smethod_27());
					num = ((int)num2 * -2076511897) ^ 0x4ABE036F;
					continue;
				case 79u:
					num = ((int)num2 * -1447761674) ^ 0x25C52682;
					continue;
				case 78u:
					num = ((int)num2 * -949668121) ^ -1797279764;
					continue;
				case 77u:
					AddStaff_Admin.smethod_51((ContainerControl)(object)this, new SizeF(8f, 16f));
					num = ((int)num2 * -1519264606) ^ -2107919842;
					continue;
				case 76u:
					AddStaff_Admin.smethod_24(Label5, "Mobile :");
					num = (int)((num2 * 977157792) ^ 0x2461381B);
					continue;
				case 75u:
					AddStaff_Admin.smethod_15((Control)(object)Label3, new Point(13, 182));
					AddStaff_Admin.smethod_16((Control)(object)Label3, "Label3");
					AddStaff_Admin.smethod_17((Control)(object)Label3, new Size(82, 31));
					num = ((int)num2 * -915988345) ^ 0x5157BF7A;
					continue;
				case 74u:
					AddStaff_Admin.smethod_17((Control)(object)Label7, new Size(128, 26));
					num = (int)(num2 * 2091126767) ^ -2614584;
					continue;
				case 73u:
					AddStaff_Admin.smethod_17((Control)(object)WorkShiftTxt, new Size(147, 27));
					num = ((int)num2 * -384018633) ^ -1090304992;
					continue;
				case 72u:
					AddStaff_Admin.smethod_22((Control)(object)RegisterBtn, AddStaff_Admin.smethod_21("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					AddStaff_Admin.smethod_28((Control)(object)RegisterBtn, Color.White);
					num = (int)((num2 * 1545058551) ^ 0x2FA6536E);
					continue;
				case 71u:
					num = ((int)num2 * -1485360444) ^ 0x14084146;
					continue;
				case 70u:
					Label3 = AddStaff_Admin.smethod_4();
					num = ((int)num2 * -828644279) ^ -1734651059;
					continue;
				case 69u:
					AddStaff_Admin.smethod_24(SuccessMsg, "Patient Successfully registered");
					num = ((int)num2 * -862452579) ^ -1384636851;
					continue;
				case 68u:
					AddStaff_Admin.smethod_25(Label2, (ContentAlignment)32);
					num = ((int)num2 * -733621166) ^ -1408953853;
					continue;
				case 67u:
					num = ((int)num2 * -1974428605) ^ 0x85ED05B;
					continue;
				case 66u:
					num = (int)(num2 * 1580692049) ^ -29700434;
					continue;
				case 65u:
					num = ((int)num2 * -730873011) ^ 0x4F8A4D92;
					continue;
				case 64u:
					DOBTxt = AddStaff_Admin.smethod_6();
					num = ((int)num2 * -1667107447) ^ 0x163B7A1B;
					continue;
				case 63u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_30((Control)(object)GroupBox2), (Control)(object)GenderTxt);
					num = (int)(num2 * 1290216126) ^ -245400692;
					continue;
				case 62u:
					num = (int)(num2 * 1944201109) ^ -1551180818;
					continue;
				case 61u:
					AddressTxt = AddStaff_Admin.smethod_7();
					num = (int)((num2 * 792435306) ^ 0x2FB3748C);
					continue;
				case 60u:
					AddStaff_Admin.smethod_25(SuccessMsg, (ContentAlignment)32);
					num = ((int)num2 * -1051119139) ^ 0x515A68E1;
					continue;
				case 59u:
					Label4 = AddStaff_Admin.smethod_4();
					num = (int)((num2 * 1682332302) ^ 0x5AD003D5);
					continue;
				case 58u:
					Label8 = AddStaff_Admin.smethod_4();
					WorkShiftTxt = AddStaff_Admin.smethod_8();
					num = ((int)num2 * -1330399730) ^ -1118308473;
					continue;
				case 57u:
					AddStaff_Admin.smethod_41(WorkShiftTxt, (AutoCompleteSource)256);
					AddStaff_Admin.smethod_42(WorkShiftTxt, (ComboBoxStyle)2);
					num = (int)((num2 * 1505163266) ^ 0x31BD720F);
					continue;
				case 56u:
					num = ((int)num2 * -211351764) ^ -369977600;
					continue;
				case 55u:
					AddStaff_Admin.smethod_40(WorkShiftTxt, (AutoCompleteMode)2);
					num = (int)((num2 * 1336393596) ^ 0x3292B128);
					continue;
				case 54u:
					num = ((int)num2 * -919459072) ^ -914285695;
					continue;
				case 53u:
					num = (int)((num2 * 372201187) ^ 0x3B9AF0D9);
					continue;
				case 52u:
					AddStaff_Admin.smethod_17((Control)(object)DesignationTxt, new Size(147, 27));
					num = ((int)num2 * -1438124559) ^ -724746184;
					continue;
				case 51u:
					AddStaff_Admin.smethod_23((Control)(object)RegisterBtn, 14);
					num = (int)(num2 * 1646173617) ^ -1931849991;
					continue;
				case 50u:
					AddStaff_Admin.smethod_48((ButtonBase)(object)RegisterBtn, "Register");
					num = (int)(num2 * 1609482360) ^ -77467109;
					continue;
				case 49u:
					num = ((int)num2 * -1488724) ^ -1757039781;
					continue;
				case 48u:
					AddStaff_Admin.smethod_16((Control)(object)Label2, "Label2");
					num = ((int)num2 * -1552214835) ^ -2136459590;
					continue;
				case 47u:
					AddStaff_Admin.smethod_23((Control)(object)DOBTxt, 20);
					num = ((int)num2 * -404426268) ^ -1570347171;
					continue;
				case 46u:
					AddStaff_Admin.smethod_15((Control)(object)MobileTxt, new Point(137, 147));
					num = ((int)num2 * -1879579915) ^ -1133220948;
					continue;
				case 45u:
					AddStaff_Admin.smethod_25(Label5, (ContentAlignment)32);
					num = ((int)num2 * -1367637395) ^ -1945125171;
					continue;
				case 44u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_30((Control)(object)GroupBox2), (Control)(object)DesignationTxt);
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_30((Control)(object)GroupBox2), (Control)(object)Label8);
					num = ((int)num2 * -259469487) ^ -1599387407;
					continue;
				case 43u:
					AddStaff_Admin.smethod_17((Control)(object)MobileTxt, new Size(208, 26));
					num = (int)(num2 * 1948803579) ^ -95186680;
					continue;
				case 42u:
					num = ((int)num2 * -1239208970) ^ 0x3AC29D4B;
					continue;
				case 41u:
					AddStaff_Admin.smethod_47((ButtonBase)(object)RegisterBtn, Color.MidnightBlue);
					num = (int)(num2 * 1224926564) ^ -1361710528;
					continue;
				case 40u:
					AddStaff_Admin.smethod_23((Control)(object)Label7, 14);
					num = ((int)num2 * -1072302103) ^ 0x74298DE1;
					continue;
				case 39u:
					AddStaff_Admin.smethod_15((Control)(object)SuccessMsg, new Point(305, 156));
					AddStaff_Admin.smethod_16((Control)(object)SuccessMsg, "SuccessMsg");
					AddStaff_Admin.smethod_17((Control)(object)SuccessMsg, new Size(401, 44));
					num = (int)((num2 * 1633070950) ^ 0x7A900B2B);
					continue;
				case 38u:
					AddStaff_Admin.smethod_25(Label9, (ContentAlignment)32);
					num = ((int)num2 * -1370884397) ^ -1900299908;
					continue;
				case 37u:
					num = (int)((num2 * 1186056913) ^ 0x1395D306);
					continue;
				case 36u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_30((Control)(object)GroupBox2), (Control)(object)Label7);
					num = ((int)num2 * -2098549876) ^ -1337582486;
					continue;
				case 35u:
					AddStaff_Admin.smethod_16((Control)(object)ClearBtn, "ClearBtn");
					AddStaff_Admin.smethod_17((Control)(object)ClearBtn, new Size(143, 43));
					num = (int)(num2 * 414494284) ^ -1699129426;
					continue;
				case 34u:
					AddStaff_Admin.smethod_25(Label8, (ContentAlignment)32);
					num = (int)(num2 * 797467309) ^ -1212827377;
					continue;
				case 33u:
					AddStaff_Admin.smethod_15((Control)(object)Label1, new Point(392, 63));
					AddStaff_Admin.smethod_16((Control)(object)Label1, "Label1");
					num = (int)(num2 * 209150811) ^ -692384999;
					continue;
				case 32u:
					AddStaff_Admin.smethod_16((Control)(object)AddressTxt, "AddressTxt");
					AddStaff_Admin.smethod_17((Control)(object)AddressTxt, new Size(324, 91));
					AddStaff_Admin.smethod_23((Control)(object)AddressTxt, 13);
					num = (int)((num2 * 1229694577) ^ 0x7D8AA16F);
					continue;
				case 31u:
					AddStaff_Admin.smethod_28((Control)(object)ClearBtn, Color.White);
					num = (int)((num2 * 1274941693) ^ 0x78BF73DA);
					continue;
				case 30u:
					AddStaff_Admin.smethod_16((Control)(object)NameTxt, "NameTxt");
					AddStaff_Admin.smethod_17((Control)(object)NameTxt, new Size(324, 26));
					num = ((int)num2 * -181975330) ^ -2123069308;
					continue;
				case 29u:
					AddStaff_Admin.smethod_20(PictureBox1, bool_0: false);
					num = ((int)num2 * -409939949) ^ -1880231165;
					continue;
				case 28u:
					AddStaff_Admin.smethod_17((Control)(object)Label8, new Size(128, 26));
					num = (int)(num2 * 896251485) ^ -2082053564;
					continue;
				case 27u:
					AddStaff_Admin.smethod_17((Control)(object)PictureBox1, new Size(141, 136));
					num = ((int)num2 * -1926148943) ^ 0x71125437;
					continue;
				case 26u:
					num = ((int)num2 * -134724475) ^ -291291622;
					continue;
				case 25u:
					RegisterBtn = AddStaff_Admin.smethod_9();
					ClearBtn = AddStaff_Admin.smethod_9();
					num = (int)((num2 * 1699791882) ^ 0x7E420676);
					continue;
				case 24u:
					AddStaff_Admin.smethod_26((Control)(object)SuccessMsg, Color.Olive);
					num = (int)((num2 * 766065037) ^ 0x7CEF093A);
					continue;
				case 23u:
					AddStaff_Admin.smethod_25(Label1, (ContentAlignment)32);
					num = (int)((num2 * 2127679634) ^ 0x67CA2249);
					continue;
				case 22u:
					num = (int)((num2 * 2055133205) ^ 0x70927D0C);
					continue;
				case 21u:
					num = (int)((num2 * 809455444) ^ 0x2413674C);
					continue;
				case 20u:
					AddStaff_Admin.smethod_39(AddStaff_Admin.smethod_38(WorkShiftTxt), new string[3] { "Male", "Female", "Others" });
					num = ((int)num2 * -670631292) ^ -1411598148;
					continue;
				case 19u:
					AddStaff_Admin.smethod_23((Control)(object)WorkShiftTxt, 15);
					num = (int)(num2 * 740119021) ^ -2116453120;
					continue;
				case 18u:
					num = (int)((num2 * 1172486556) ^ 0x4A9D715B);
					continue;
				case 17u:
					AddStaff_Admin.smethod_37(DOBTxt, new DateTime(2019, 2, 11, 0, 0, 0, 0));
					num = (int)((num2 * 432957055) ^ 0x1BA6E561);
					continue;
				case 16u:
					AddStaff_Admin.smethod_16((Control)(object)Label4, "Label4");
					AddStaff_Admin.smethod_17((Control)(object)Label4, new Size(92, 24));
					num = (int)(num2 * 1133878047) ^ -1167042686;
					continue;
				case 15u:
					AddStaff_Admin.smethod_15((Control)(object)Label8, new Point(3, 263));
					num = (int)((num2 * 1339914755) ^ 0x60630222);
					continue;
				case 14u:
					AddStaff_Admin.smethod_23((Control)(object)Label1, 11);
					num = (int)((num2 * 589695137) ^ 0x9102C66);
					continue;
				case 13u:
					num = ((int)num2 * -1576383682) ^ 0x14F8225;
					continue;
				case 12u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_53((Control)(object)this), (Control)(object)SuccessMsg);
					num = ((int)num2 * -1456412160) ^ -1538555569;
					continue;
				case 11u:
					num = ((int)num2 * -1400064004) ^ 0x79CDBC8B;
					continue;
				case 10u:
					AddStaff_Admin.smethod_17((Control)(object)Label6, new Size(87, 26));
					num = ((int)num2 * -652287280) ^ 0xE5CDABD;
					continue;
				case 9u:
					AddStaff_Admin.smethod_24(Label3, "Gender :");
					AddStaff_Admin.smethod_25(Label3, (ContentAlignment)32);
					num = ((int)num2 * -1972593665) ^ -1391785842;
					continue;
				case 8u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_30((Control)(object)GroupBox2), (Control)(object)Label2);
					num = (int)(num2 * 2108063519) ^ -473511419;
					continue;
				case 7u:
					AddStaff_Admin.smethod_23((Control)(object)SuccessMsg, 12);
					num = ((int)num2 * -739502372) ^ 0x65BC6858;
					continue;
				case 6u:
					num = ((int)num2 * -2059275146) ^ -1455368184;
					continue;
				case 5u:
					num = ((int)num2 * -1858408742) ^ -1478772303;
					continue;
				case 4u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_53((Control)(object)this), (Control)(object)RegisterBtn);
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_53((Control)(object)this), (Control)(object)GroupBox2);
					num = (int)((num2 * 1068567849) ^ 0x36D5A8B2);
					continue;
				case 3u:
					AddStaff_Admin.smethod_42(DesignationTxt, (ComboBoxStyle)2);
					AddStaff_Admin.smethod_22((Control)(object)DesignationTxt, AddStaff_Admin.smethod_21("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					AddStaff_Admin.smethod_43((ListControl)(object)DesignationTxt, bool_0: true);
					AddStaff_Admin.smethod_45(AddStaff_Admin.smethod_44(DesignationTxt), new object[4] { "Doctor", "Nurse", "Receptionist", "Admin" });
					num = ((int)num2 * -607219555) ^ 0x1ED35FA4;
					continue;
				case 2u:
					AddStaff_Admin.smethod_22((Control)(object)GroupBox2, AddStaff_Admin.smethod_21("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1177805457) ^ 0x36ECE440;
					continue;
				case 1u:
					AddStaff_Admin.smethod_23((Control)(object)MobileTxt, 12);
					num = ((int)num2 * -2051698322) ^ 0x3A3DBED9;
					continue;
				case 0u:
					SuccessMsg = AddStaff_Admin.smethod_4();
					num = ((int)num2 * -623500214) ^ -680599361;
					continue;
				default:
					return;
				case 227u:
					break;
				case 111u:
					return;
				}
				break;
			}
		}
	}

	private void AddStaff_Admin_Load(object sender, EventArgs e)
	{
		AddStaff_Admin.smethod_35(DOBTxt, AddStaff_Admin.smethod_65(AddStaff_Admin.smethod_64((object)DateTime.Now, "dd-MM-yyyy")));
		while (true)
		{
			int num = 1872417103;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1A72BE1u) % 3u)
				{
				case 1u:
					goto IL_0026;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0026:
				num = (int)((num2 * 105715598) ^ 0x2363FD06);
			}
		}
	}

	private void ClearBtn_Click(object sender, EventArgs e)
	{
		AddStaff_Admin.smethod_66((TextBoxBase)(object)NameTxt);
		while (true)
		{
			int num = 157005507;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x19F4978Au) % 10u)
				{
				case 8u:
					AddStaff_Admin.smethod_66((TextBoxBase)(object)AddressTxt);
					num = (int)(num2 * 1808171623) ^ -1032979594;
					continue;
				case 7u:
					AddStaff_Admin.smethod_37(DOBTxt, AddStaff_Admin.smethod_65(AddStaff_Admin.smethod_64((object)AddStaff_Admin.smethod_67(), "dd-MM-yyyy")));
					num = ((int)num2 * -521410776) ^ 0x1489986C;
					continue;
				case 5u:
					AddStaff_Admin.smethod_68(DesignationTxt, -1);
					num = (int)((num2 * 395833678) ^ 0x427CC335);
					continue;
				case 4u:
					AddStaff_Admin.smethod_29((Control)(object)SuccessMsg, bool_0: false);
					num = ((int)num2 * -1168197277) ^ -1479145319;
					continue;
				case 3u:
					AddStaff_Admin.smethod_68(WorkShiftTxt, -1);
					num = ((int)num2 * -1613908717) ^ -1581278666;
					continue;
				case 2u:
					AddStaff_Admin.smethod_66((TextBoxBase)(object)EmailTxt);
					num = (int)(num2 * 1769722507) ^ -983093682;
					continue;
				case 1u:
					AddStaff_Admin.smethod_66((TextBoxBase)(object)MobileTxt);
					num = (int)((num2 * 1065447675) ^ 0x3AC61B99);
					continue;
				case 0u:
					AddStaff_Admin.smethod_68(GenderTxt, -1);
					num = (int)((num2 * 1784606797) ^ 0x46B719CD);
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

	private void RegisterBtn_Click(object sender, EventArgs e)
	{
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c8: Expected I4, but got Unknown
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fc: Expected I4, but got Unknown
		//IL_050f: Incompatible stack heights: 0 vs 1
		//IL_051f: Incompatible stack heights: 0 vs 1
		//IL_053f: Incompatible stack heights: 0 vs 1
		//IL_0558: Incompatible stack heights: 0 vs 1
		//IL_057b: Incompatible stack heights: 0 vs 1
		//IL_059a: Incompatible stack heights: 0 vs 1
		//IL_05b8: Incompatible stack heights: 0 vs 1
		//IL_05d0: Incompatible stack heights: 0 vs 1
		//IL_05e3: Incompatible stack heights: 0 vs 1
		//IL_05ed: Incompatible stack heights: 0 vs 1
		OleDbConnection oleDbConnection_ = AddStaff_Admin.smethod_69();
		string string_ = default(string);
		DateTime dateTime_ = default(DateTime);
		while (true)
		{
			int num = -991210495;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE7EF3805u) % 12u)
				{
				case 11u:
					num = ((int)num2 * -1196132741) ^ -552659693;
					continue;
				case 9u:
					password = Random_Password_Generator();
					num = ((int)num2 * -453136052) ^ -466232496;
					continue;
				case 7u:
					string_ = "Insert Into [Staff] ([Name],[Designation],[Date Of Birth],[Gender],[Mobile],[Address],[Work Shift],[Username],[Password]) Values (?,?,?,?,?,?,?,?,?)";
					num = (int)((num2 * 954898714) ^ 0x6C80612F);
					continue;
				case 6u:
					num = (int)(num2 * 2024810559) ^ -1808101436;
					continue;
				case 4u:
					AddStaff_Admin.smethod_71(oleDbConnection_, AddStaff_Admin.smethod_70(MyProject.Forms.Form1.provider, MyProject.Forms.Form1.datafile));
					num = (int)(num2 * 1212102873) ^ -1134798621;
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (!Validate_data())
					{
						num4 = 752888363;
						num5 = 752888363;
					}
					else
					{
						num4 = 901108325;
						num5 = 901108325;
					}
					num = num4 ^ ((int)num2 * -42446280);
					continue;
				}
				case 2u:
					username = AddStaff_Admin.smethod_73(username, new char[1] { ' ' })[0];
					num = ((int)num2 * -234942172) ^ 0x4961C6C0;
					continue;
				case 1u:
					dateTime_ = AddStaff_Admin.smethod_65(AddStaff_Admin.smethod_64((object)AddStaff_Admin.smethod_74(DOBTxt), "dd-MM-yyyy"));
					AddStaff_Admin.smethod_75(oleDbConnection_);
					num = (int)(num2 * 1889727099) ^ -1045529331;
					continue;
				case 0u:
					username = AddStaff_Admin.smethod_73(AddStaff_Admin.smethod_72(NameTxt), new char[1] { '.' })[0];
					num = -1300463961;
					continue;
				case 5u:
					break;
				default:
				{
					OleDbCommand val = AddStaff_Admin.smethod_76(string_, oleDbConnection_);
					try
					{
						while (true)
						{
							int num3 = -703596527;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xE7EF3805u) % 16u)
								{
								case 15u:
									num3 = ((int)num2 * -1418850310) ^ 0x3CF84794;
									continue;
								case 14u:
									AddStaff_Admin.smethod_86(oleDbConnection_);
									num3 = (int)(num2 * 1788476602) ^ -1743489630;
									continue;
								case 13u:
									AddStaff_Admin.smethod_84(val);
									num3 = ((int)num2 * -2110062321) ^ 0x3783CAB7;
									continue;
								case 12u:
									AddStaff_Admin.smethod_26((Control)(object)SuccessMsg, Color.Green);
									AddStaff_Admin.smethod_87(Timer1);
									ClearBtn_Click(AddStaff_Admin.smethod_88(sender), e);
									num3 = (int)((num2 * 532254568) ^ 0x20238006);
									continue;
								case 11u:
									Send_Mail();
									AddStaff_Admin.smethod_29((Control)(object)SuccessMsg, bool_0: true);
									num3 = ((int)num2 * -1512926113) ^ -1685045376;
									continue;
								case 9u:
									AddStaff_Admin.smethod_80(AddStaff_Admin.smethod_77(val), AddStaff_Admin.smethod_79("Username", (object)username));
									num3 = (int)((num2 * 1830466646) ^ 0x509D53E1);
									continue;
								case 8u:
									AddStaff_Admin.smethod_80(AddStaff_Admin.smethod_77(val), AddStaff_Admin.smethod_79("Designation", (object)AddStaff_Admin.smethod_78(AddStaff_Admin.smethod_81(DesignationTxt))));
									num3 = ((int)num2 * -1028187901) ^ 0x5D37808;
									continue;
								case 6u:
									AddStaff_Admin.smethod_24(SuccessMsg, "Staff Successfully Registered !!");
									num3 = ((int)num2 * -1076909221) ^ 0xDAB06BB;
									continue;
								case 5u:
									AddStaff_Admin.smethod_80(AddStaff_Admin.smethod_77(val), AddStaff_Admin.smethod_79("Date Of Birth", (object)AddStaff_Admin.smethod_82(dateTime_)));
									AddStaff_Admin.smethod_80(AddStaff_Admin.smethod_77(val), AddStaff_Admin.smethod_79("Gender", (object)AddStaff_Admin.smethod_78(AddStaff_Admin.smethod_81(GenderTxt))));
									AddStaff_Admin.smethod_80(AddStaff_Admin.smethod_77(val), AddStaff_Admin.smethod_79("Mobile", (object)AddStaff_Admin.smethod_83(AddStaff_Admin.smethod_72(MobileTxt))));
									AddStaff_Admin.smethod_80(AddStaff_Admin.smethod_77(val), AddStaff_Admin.smethod_79("Address", (object)AddStaff_Admin.smethod_83(AddStaff_Admin.smethod_72(AddressTxt))));
									AddStaff_Admin.smethod_80(AddStaff_Admin.smethod_77(val), AddStaff_Admin.smethod_79("Work Shift", (object)AddStaff_Admin.smethod_83(AddStaff_Admin.smethod_81(WorkShiftTxt))));
									num3 = (int)((num2 * 398229297) ^ 0xE5D20A9);
									continue;
								case 4u:
									AddStaff_Admin.smethod_80(AddStaff_Admin.smethod_77(val), AddStaff_Admin.smethod_79("Name", (object)AddStaff_Admin.smethod_78(AddStaff_Admin.smethod_72(NameTxt))));
									num3 = ((int)num2 * -1575266971) ^ -15518951;
									continue;
								case 3u:
									AddStaff_Admin.smethod_29((Control)(object)SuccessMsg, bool_0: true);
									num3 = ((int)num2 * -980597350) ^ -1810674940;
									continue;
								case 2u:
									AddStaff_Admin.smethod_80(AddStaff_Admin.smethod_77(val), AddStaff_Admin.smethod_79("Password", (object)password));
									num3 = (int)((num2 * 1024406922) ^ 0x53F5AABC);
									continue;
								case 1u:
									AddStaff_Admin.smethod_85((Component)(object)val);
									num3 = (int)(num2 * 246194380) ^ -888811049;
									continue;
								case 0u:
									num3 = (int)((num2 * 191184854) ^ 0x37AE7E3);
									continue;
								default:
									return;
								case 10u:
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
						AddStaff_Admin.smethod_89(exception_);
						while (true)
						{
							_ = -1943742828;
							while (true)
							{
								_003F val2 = /*Error near IL_04c5: Stack underflow*/^ -403752955;
								num2 = (uint)(int)val2;
								switch (val2 % 11)
								{
								default:
									return;
								case 10:
									_ = ((int)num2 * -244232567) ^ -1029070622;
									continue;
								case 9:
									_ = (num2 * 908093729) ^ 0x739111AB;
									continue;
								case 8:
									AddStaff_Admin.smethod_24(SuccessMsg, "Invalid Credentialsl");
									_ = ((int)num2 * -1317870572) ^ -587736154;
									continue;
								case 5:
									AddStaff_Admin.smethod_86(oleDbConnection_);
									_ = (num2 * 2029132474) ^ 0xADEE547Au;
									continue;
								case 4:
									AddStaff_Admin.smethod_26((Control)(object)SuccessMsg, Color.Red);
									_ = (num2 * 635464438) ^ 0xF7DD9856u;
									continue;
								case 3:
									AddStaff_Admin.smethod_29((Control)(object)SuccessMsg, bool_0: true);
									_ = ((int)num2 * -1202091327) ^ 0x6AE52AF5;
									continue;
								case 2:
									AddStaff_Admin.smethod_87(Timer1);
									_ = (num2 * 109184967) ^ 0x9872E2A;
									continue;
								case 1:
									AddStaff_Admin.smethod_90();
									_ = ((int)num2 * -454219552) ^ 0x7A780F34;
									continue;
								case 0:
									_ = (num2 * 212997008) ^ 0xADE0B72Eu;
									continue;
								case 7:
									break;
								case 6:
									return;
								}
								break;
							}
						}
					}
				}
				case 10u:
					return;
				}
				break;
			}
		}
	}

	private bool Send_Mail()
	{
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected I4, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected I4, but got Unknown
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Incompatible stack heights: 0 vs 1
		//IL_0275: Incompatible stack heights: 0 vs 1
		//IL_027c: Incompatible stack heights: 0 vs 1
		try
		{
			SmtpClient smtpClient_ = default(SmtpClient);
			MailMessage mailMessage_ = default(MailMessage);
			while (true)
			{
				IL_0201:
				int num = -1034021623;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAFD2298Bu) % 15u)
					{
					case 14u:
						AddStaff_Admin.smethod_98(smtpClient_, "smtp.gmail.com");
						num = (int)(num2 * 1738654221) ^ -1008019536;
						continue;
					case 13u:
						AddStaff_Admin.smethod_97(smtpClient_, bool_0: true);
						num = (int)((num2 * 1437935935) ^ 0x278CCC9C);
						continue;
					case 12u:
						AddStaff_Admin.smethod_96(smtpClient_, 587);
						num = (int)(num2 * 1968496687) ^ -1578364797;
						continue;
					case 11u:
						AddStaff_Admin.smethod_104(mailMessage_, bool_0: false);
						num = (int)((num2 * 316377411) ^ 0x58F60E5B);
						continue;
					case 10u:
						AddStaff_Admin.smethod_102(AddStaff_Admin.smethod_101(mailMessage_), AddStaff_Admin.smethod_72(EmailTxt));
						AddStaff_Admin.smethod_103(mailMessage_, "Login Credential Details");
						num = ((int)num2 * -989842808) ^ 0x79170FE6;
						continue;
					case 9u:
						num = (int)(num2 * 172060723) ^ -901404676;
						continue;
					case 8u:
						num = (int)((num2 * 1566718914) ^ 0x6308E7D0);
						continue;
					case 7u:
						num = ((int)num2 * -1963057181) ^ -891123246;
						continue;
					case 6u:
						AddStaff_Admin.smethod_106(mailMessage_, AddStaff_Admin.smethod_105(new string[5] { "Your Username is : ", username, " and Password is : ", password, ". Remember your login credentials for future use" }));
						AddStaff_Admin.smethod_107(smtpClient_, mailMessage_);
						num = (int)(num2 * 1836768479) ^ -792922741;
						continue;
					case 4u:
						smtpClient_ = AddStaff_Admin.smethod_91();
						mailMessage_ = AddStaff_Admin.smethod_92();
						AddStaff_Admin.smethod_93(smtpClient_, bool_0: false);
						num = (int)(num2 * 1162674363) ^ -1571831092;
						continue;
					case 2u:
						num = (int)((num2 * 1416088587) ^ 0x393C266A);
						continue;
					case 1u:
						AddStaff_Admin.smethod_95(smtpClient_, (ICredentialsByHost)AddStaff_Admin.smethod_94("tyagianubhav619@gmail.com", "tyagi09101999"));
						num = ((int)num2 * -505894791) ^ -925464957;
						continue;
					case 0u:
						mailMessage_ = AddStaff_Admin.smethod_92();
						AddStaff_Admin.smethod_100(mailMessage_, AddStaff_Admin.smethod_99("tyagianubhav619@gmail.com"));
						num = (int)(num2 * 403448926) ^ -976022219;
						continue;
					case 5u:
						break;
					default:
						AddStaff_Admin.smethod_108((object)"Mail Sent", (MsgBoxStyle)0, (object)null);
						goto end_IL_01b2;
					}
					goto IL_0201;
					continue;
					end_IL_01b2:
					break;
				}
				break;
			}
		}
		catch (Exception exception_)
		{
			AddStaff_Admin.smethod_89(exception_);
			while (true)
			{
				IL_0277:
				_ = -1323287003;
				while (true)
				{
					_003F val = /*Error near IL_0229: Stack underflow*/^ -1345181301;
					uint num2 = (uint)(int)val;
					switch (val % 4)
					{
					default:
						goto end_IL_0223;
					case 3:
						AddStaff_Admin.smethod_108((object)"Cannot Send Mail. Network Not available", (MsgBoxStyle)0, (object)null);
						AddStaff_Admin.smethod_90();
						_ = ((int)num2 * -650230900) ^ -2126766006;
						continue;
					case 2:
						_ = (num2 * 1611743637) ^ 0xD6D3A52Au;
						continue;
					case 0:
						break;
					case 1:
						goto end_IL_0223;
					}
					goto IL_0277;
					continue;
					end_IL_0223:
					break;
				}
				break;
			}
		}
		bool result = default(bool);
		while (true)
		{
			int num3 = -1791977411;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num3 ^ 0xAFD2298Bu) % 4u)
				{
				case 2u:
					result = true;
					num3 = (int)((num2 * 937038312) ^ 0x381D1EEE);
					continue;
				case 1u:
					num3 = (int)(num2 * 915740709) ^ -1463295095;
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

	private void Timer1_Tick(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -2074987525;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFED8FA6Bu) % 3u)
				{
				case 2u:
					goto IL_0003;
				case 0u:
					break;
				default:
					AddStaff_Admin.smethod_109(Timer1);
					return;
				}
				break;
				IL_0003:
				AddStaff_Admin.smethod_29((Control)(object)SuccessMsg, bool_0: false);
				num = (int)(num2 * 1416233887) ^ -1944581900;
			}
		}
	}

	private bool Validate_data()
	{
		bool flag = !MyProject.Forms.Form1.Name_Validation(AddStaff_Admin.smethod_78(AddStaff_Admin.smethod_72(NameTxt)));
		bool flag6 = default(bool);
		bool flag3 = default(bool);
		bool flag5 = default(bool);
		bool result = default(bool);
		bool flag4 = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -787479664;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA7E07410u) % 78u)
				{
				case 77u:
				{
					int num13;
					int num14;
					if (!flag6)
					{
						num13 = 366783267;
						num14 = 366783267;
					}
					else
					{
						num13 = 1337542093;
						num14 = 1337542093;
					}
					num = num13 ^ ((int)num2 * -603281566);
					continue;
				}
				case 76u:
					num = ((int)num2 * -610715656) ^ -924457635;
					continue;
				case 75u:
					AddStaff_Admin.smethod_29((Control)(object)SuccessMsg, bool_0: true);
					num = (int)((num2 * 2128843929) ^ 0x200B17E0);
					continue;
				case 74u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = 1737064338;
						num6 = 1737064338;
					}
					else
					{
						num5 = 1974812312;
						num6 = 1974812312;
					}
					num = num5 ^ (int)(num2 * 1495271615);
					continue;
				}
				case 73u:
					AddStaff_Admin.smethod_26((Control)(object)SuccessMsg, Color.Red);
					num = ((int)num2 * -135030575) ^ -140388;
					continue;
				case 72u:
					AddStaff_Admin.smethod_87(Timer1);
					num = (int)(num2 * 1934507898) ^ -1634436576;
					continue;
				case 71u:
					AddStaff_Admin.smethod_87(Timer1);
					num = (int)(num2 * 819831648) ^ -1547114142;
					continue;
				case 70u:
					AddStaff_Admin.smethod_29((Control)(object)SuccessMsg, bool_0: true);
					num = ((int)num2 * -1295200680) ^ 0x52D92059;
					continue;
				case 69u:
					AddStaff_Admin.smethod_87(Timer1);
					num = (int)((num2 * 784951127) ^ 0x1E83F4E9);
					continue;
				case 68u:
				{
					int num9;
					int num10;
					if (!flag3)
					{
						num9 = 1284775526;
						num10 = 1284775526;
					}
					else
					{
						num9 = 894368836;
						num10 = 894368836;
					}
					num = num9 ^ ((int)num2 * -980368101);
					continue;
				}
				case 67u:
					AddStaff_Admin.smethod_26((Control)(object)SuccessMsg, Color.Red);
					num = ((int)num2 * -1588628721) ^ 0xF4B8531;
					continue;
				case 66u:
					num = -1305541520;
					continue;
				case 65u:
					AddStaff_Admin.smethod_24(SuccessMsg, "Email field is required");
					num = (int)(num2 * 1382248515) ^ -1387027846;
					continue;
				case 64u:
				{
					int num17;
					int num18;
					if (flag5)
					{
						num17 = -1831895290;
						num18 = -1831895290;
					}
					else
					{
						num17 = -527081741;
						num18 = -527081741;
					}
					num = num17 ^ ((int)num2 * -899217076);
					continue;
				}
				case 63u:
					num = ((int)num2 * -839178947) ^ -83588290;
					continue;
				case 62u:
					num = (int)((num2 * 1612607844) ^ 0x2BD3315);
					continue;
				case 61u:
					num = -1200155875;
					continue;
				case 60u:
					AddStaff_Admin.smethod_26((Control)(object)SuccessMsg, Color.Red);
					num = (int)((num2 * 486151796) ^ 0x68058E6B);
					continue;
				case 59u:
					num = ((int)num2 * -364096358) ^ 0xCC4CE01;
					continue;
				case 58u:
					num = -1585382898;
					continue;
				case 57u:
					result = false;
					num = (int)((num2 * 2084581875) ^ 0x47DB80F2);
					continue;
				case 56u:
					num = ((int)num2 * -581764148) ^ 0x60670B69;
					continue;
				case 55u:
					num = ((int)num2 * -796098387) ^ 0x325EDFC2;
					continue;
				case 54u:
				{
					int num15;
					int num16;
					if (!flag4)
					{
						num15 = 1516205770;
						num16 = 1516205770;
					}
					else
					{
						num15 = 443380585;
						num16 = 443380585;
					}
					num = num15 ^ ((int)num2 * -560473602);
					continue;
				}
				case 53u:
				{
					int num11;
					int num12;
					if (AddStaff_Admin.smethod_111(AddStaff_Admin.smethod_72(AddressTxt), "", bool_0: false) == 0)
					{
						num11 = 1406679929;
						num12 = 1406679929;
					}
					else
					{
						num11 = 2024381686;
						num12 = 2024381686;
					}
					num = num11 ^ (int)(num2 * 1246801434);
					continue;
				}
				case 52u:
					AddStaff_Admin.smethod_24(SuccessMsg, "Invalid Workshift Number");
					num = (int)(num2 * 1927721772) ^ -1625050473;
					continue;
				case 51u:
					flag6 = !MyProject.Forms.Form1.Gender_Validator(AddStaff_Admin.smethod_78(AddStaff_Admin.smethod_81(GenderTxt)));
					num = (int)((num2 * 1940534471) ^ 0xC86E1B8);
					continue;
				case 50u:
					num = ((int)num2 * -641299066) ^ 0x6420072A;
					continue;
				case 49u:
					AddStaff_Admin.smethod_87(Timer1);
					num = (int)(num2 * 1020065031) ^ -602967168;
					continue;
				case 48u:
				{
					int num7;
					int num8;
					if (AddStaff_Admin.smethod_110(DesignationTxt) == -1)
					{
						num7 = 118720052;
						num8 = 118720052;
					}
					else
					{
						num7 = 1398137822;
						num8 = 1398137822;
					}
					num = num7 ^ ((int)num2 * -887124276);
					continue;
				}
				case 47u:
					num = ((int)num2 * -383977965) ^ 0x621A6A5C;
					continue;
				case 46u:
					num = (int)((num2 * 442111994) ^ 0x1FB7F51A);
					continue;
				case 45u:
					result = false;
					num = ((int)num2 * -1903990034) ^ 0xE93C087;
					continue;
				case 44u:
					num = (int)(num2 * 864031067) ^ -1787991749;
					continue;
				case 43u:
					result = false;
					num = ((int)num2 * -1838380952) ^ -1126690903;
					continue;
				case 42u:
					AddStaff_Admin.smethod_87(Timer1);
					num = (int)((num2 * 1254564475) ^ 0x264BE863);
					continue;
				case 41u:
					num = (int)((num2 * 2030667943) ^ 0x4FE617A2);
					continue;
				case 40u:
					AddStaff_Admin.smethod_29((Control)(object)SuccessMsg, bool_0: true);
					num = (int)(num2 * 2059053257) ^ -1319982853;
					continue;
				case 39u:
					num = -1528710374;
					continue;
				case 38u:
					num = -180559698;
					continue;
				case 37u:
					AddStaff_Admin.smethod_26((Control)(object)SuccessMsg, Color.Red);
					num = (int)((num2 * 265982374) ^ 0x54024822);
					continue;
				case 36u:
					result = false;
					num = ((int)num2 * -691209122) ^ -1105922870;
					continue;
				case 35u:
					num = (int)(num2 * 1145502116) ^ -411539319;
					continue;
				case 34u:
					AddStaff_Admin.smethod_29((Control)(object)SuccessMsg, bool_0: true);
					AddStaff_Admin.smethod_24(SuccessMsg, "Invalid Name");
					num = (int)(num2 * 236465170) ^ -527796638;
					continue;
				case 32u:
					num = (int)((num2 * 1316807077) ^ 0x2101798B);
					continue;
				case 31u:
					AddStaff_Admin.smethod_26((Control)(object)SuccessMsg, Color.Red);
					num = ((int)num2 * -1683369167) ^ -1822775719;
					continue;
				case 30u:
				{
					int num3;
					int num4;
					if (flag2)
					{
						num3 = -2113530562;
						num4 = -2113530562;
					}
					else
					{
						num3 = -606781135;
						num4 = -606781135;
					}
					num = num3 ^ ((int)num2 * -1203062441);
					continue;
				}
				case 29u:
					result = false;
					num = ((int)num2 * -1248232797) ^ -1865129980;
					continue;
				case 28u:
					flag5 = AddStaff_Admin.smethod_110(GenderTxt) == -1;
					num = ((int)num2 * -637324918) ^ -1135053862;
					continue;
				case 27u:
					AddStaff_Admin.smethod_24(SuccessMsg, "Invalid Gender");
					num = ((int)num2 * -347285611) ^ -1947360381;
					continue;
				case 26u:
					AddStaff_Admin.smethod_87(Timer1);
					num = (int)(num2 * 1255117620) ^ -2000949257;
					continue;
				case 25u:
					AddStaff_Admin.smethod_29((Control)(object)SuccessMsg, bool_0: true);
					num = (int)((num2 * 1697779620) ^ 0x5F5CAE0F);
					continue;
				case 24u:
					num = -365936929;
					continue;
				case 23u:
					num = (int)((num2 * 393745268) ^ 0x70AFE5DD);
					continue;
				case 22u:
					AddStaff_Admin.smethod_26((Control)(object)SuccessMsg, Color.Red);
					AddStaff_Admin.smethod_87(Timer1);
					num = (int)(num2 * 329989656) ^ -94162696;
					continue;
				case 21u:
					AddStaff_Admin.smethod_24(SuccessMsg, "Invalid Gender");
					num = ((int)num2 * -569337545) ^ -249540202;
					continue;
				case 20u:
					flag4 = !MyProject.Forms.Form1.Mobile_Validator(AddStaff_Admin.smethod_72(MobileTxt));
					num = (int)((num2 * 1419485950) ^ 0x23A61F78);
					continue;
				case 19u:
					AddStaff_Admin.smethod_29((Control)(object)SuccessMsg, bool_0: true);
					num = (int)(num2 * 375043052) ^ -405554416;
					continue;
				case 18u:
					AddStaff_Admin.smethod_24(SuccessMsg, "Invalid Mobile Number");
					num = (int)((num2 * 587272539) ^ 0x162B5050);
					continue;
				case 16u:
					flag3 = AddStaff_Admin.smethod_110(WorkShiftTxt) == -1;
					num = (int)(num2 * 538269164) ^ -771826838;
					continue;
				case 15u:
					AddStaff_Admin.smethod_26((Control)(object)SuccessMsg, Color.Red);
					num = ((int)num2 * -937154140) ^ -434076548;
					continue;
				case 14u:
					AddStaff_Admin.smethod_29((Control)(object)SuccessMsg, bool_0: true);
					num = ((int)num2 * -752935129) ^ -193925260;
					continue;
				case 13u:
					num = -1450389327;
					continue;
				case 12u:
					result = false;
					num = ((int)num2 * -1562480313) ^ 0x337EDADD;
					continue;
				case 11u:
					num = (int)((num2 * 1624815162) ^ 0x8937445);
					continue;
				case 10u:
					AddStaff_Admin.smethod_87(Timer1);
					num = (int)((num2 * 1521040685) ^ 0x4A22F2A1);
					continue;
				case 9u:
					AddStaff_Admin.smethod_26((Control)(object)SuccessMsg, Color.Red);
					num = (int)((num2 * 382793921) ^ 0x4CCF60C7);
					continue;
				case 8u:
					num = (int)((num2 * 176365266) ^ 0x268AAB2F);
					continue;
				case 7u:
					result = true;
					num = ((int)num2 * -1367882131) ^ -1182226165;
					continue;
				case 6u:
					num = -1686026098;
					continue;
				case 5u:
					AddStaff_Admin.smethod_24(SuccessMsg, "Adress required ");
					num = (int)(num2 * 1675506200) ^ -2110778413;
					continue;
				case 4u:
					flag2 = AddStaff_Admin.smethod_111(AddStaff_Admin.smethod_72(EmailTxt), "", bool_0: false) == 0;
					num = (int)(num2 * 132550505) ^ -819058932;
					continue;
				case 3u:
					num = ((int)num2 * -1824204072) ^ 0x50188941;
					continue;
				case 2u:
					result = false;
					num = (int)((num2 * 1702833518) ^ 0x60F13D7E);
					continue;
				case 1u:
					AddStaff_Admin.smethod_24(SuccessMsg, "Invalid Designation");
					num = (int)(num2 * 24500205) ^ -1166178888;
					continue;
				case 0u:
					AddStaff_Admin.smethod_29((Control)(object)SuccessMsg, bool_0: true);
					num = (int)(num2 * 435146826) ^ -511257735;
					continue;
				case 17u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	private string Random_Password_Generator()
	{
		char char_ = default(char);
		string string_ = default(string);
		int int_ = default(int);
		int num3 = default(int);
		string result = default(string);
		string text = default(string);
		Random random_ = default(Random);
		while (true)
		{
			int num = -1167543270;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC563EAC4u) % 10u)
				{
				case 9u:
					char_ = AddStaff_Admin.smethod_115(string_, int_);
					num = (int)((num2 * 2129664819) ^ 0x61F9B8BF);
					continue;
				case 7u:
				{
					int num4;
					int num5;
					if (num3 > 10)
					{
						num4 = -791586802;
						num5 = -791586802;
					}
					else
					{
						num4 = -829675453;
						num5 = -829675453;
					}
					num = num4 ^ ((int)num2 * -394844760);
					continue;
				}
				case 6u:
					result = text;
					num = ((int)num2 * -793518792) ^ 0x182C89A2;
					continue;
				case 5u:
					num3 = 1;
					num = (int)((num2 * 708680657) ^ 0x307BF878);
					continue;
				case 4u:
					string_ = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
					num = (int)(num2 * 1484490900) ^ -399033547;
					continue;
				case 3u:
					int_ = AddStaff_Admin.smethod_114(random_, 0, AddStaff_Admin.smethod_113(string_));
					num = -106143287;
					continue;
				case 2u:
					text = AddStaff_Admin.smethod_70(text, AddStaff_Admin.smethod_116(char_));
					num3 = checked(num3 + 1);
					num = ((int)num2 * -1527106007) ^ 0x7FEBF55;
					continue;
				case 1u:
					text = "";
					random_ = AddStaff_Admin.smethod_112();
					num = (int)(num2 * 95565911) ^ -877530008;
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

	static void smethod_1(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Container smethod_2()
	{
		return new Container();
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

	static DateTimePicker smethod_6()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new DateTimePicker();
	}

	static TextBox smethod_7()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new TextBox();
	}

	static ComboBox smethod_8()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new ComboBox();
	}

	static Button smethod_9()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Button();
	}

	static Timer smethod_10(IContainer icontainer_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new Timer(icontainer_0);
	}

	static void smethod_11(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.BeginInit();
	}

	static void smethod_12(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_13(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_14(PictureBox pictureBox_0, Image image_0)
	{
		pictureBox_0.set_Image(image_0);
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

	static void smethod_18(PictureBox pictureBox_0, PictureBoxSizeMode pictureBoxSizeMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		pictureBox_0.set_SizeMode(pictureBoxSizeMode_0);
	}

	static void smethod_19(PictureBox pictureBox_0, int int_0)
	{
		pictureBox_0.set_TabIndex(int_0);
	}

	static void smethod_20(PictureBox pictureBox_0, bool bool_0)
	{
		pictureBox_0.set_TabStop(bool_0);
	}

	static Font smethod_21(string string_0, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_22(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static void smethod_23(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static void smethod_24(Label label_0, string string_0)
	{
		label_0.set_Text(string_0);
	}

	static void smethod_25(Label label_0, ContentAlignment contentAlignment_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		label_0.set_TextAlign(contentAlignment_0);
	}

	static void smethod_26(Control control_0, Color color_0)
	{
		control_0.set_BackColor(color_0);
	}

	static Color smethod_27()
	{
		return SystemColors.ButtonHighlight;
	}

	static void smethod_28(Control control_0, Color color_0)
	{
		control_0.set_ForeColor(color_0);
	}

	static void smethod_29(Control control_0, bool bool_0)
	{
		control_0.set_Visible(bool_0);
	}

	static ControlCollection smethod_30(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_31(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_32(GroupBox groupBox_0, bool bool_0)
	{
		groupBox_0.set_TabStop(bool_0);
	}

	static void smethod_33(GroupBox groupBox_0, string string_0)
	{
		groupBox_0.set_Text(string_0);
	}

	static void smethod_34(DateTimePicker dateTimePicker_0, DateTimePickerFormat dateTimePickerFormat_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		dateTimePicker_0.set_Format(dateTimePickerFormat_0);
	}

	static void smethod_35(DateTimePicker dateTimePicker_0, DateTime dateTime_0)
	{
		dateTimePicker_0.set_MaxDate(dateTime_0);
	}

	static void smethod_36(DateTimePicker dateTimePicker_0, DateTime dateTime_0)
	{
		dateTimePicker_0.set_MinDate(dateTime_0);
	}

	static void smethod_37(DateTimePicker dateTimePicker_0, DateTime dateTime_0)
	{
		dateTimePicker_0.set_Value(dateTime_0);
	}

	static AutoCompleteStringCollection smethod_38(ComboBox comboBox_0)
	{
		return comboBox_0.get_AutoCompleteCustomSource();
	}

	static void smethod_39(AutoCompleteStringCollection autoCompleteStringCollection_0, string[] string_0)
	{
		autoCompleteStringCollection_0.AddRange(string_0);
	}

	static void smethod_40(ComboBox comboBox_0, AutoCompleteMode autoCompleteMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		comboBox_0.set_AutoCompleteMode(autoCompleteMode_0);
	}

	static void smethod_41(ComboBox comboBox_0, AutoCompleteSource autoCompleteSource_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		comboBox_0.set_AutoCompleteSource(autoCompleteSource_0);
	}

	static void smethod_42(ComboBox comboBox_0, ComboBoxStyle comboBoxStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		comboBox_0.set_DropDownStyle(comboBoxStyle_0);
	}

	static void smethod_43(ListControl listControl_0, bool bool_0)
	{
		listControl_0.set_FormattingEnabled(bool_0);
	}

	static ObjectCollection smethod_44(ComboBox comboBox_0)
	{
		return comboBox_0.get_Items();
	}

	static void smethod_45(ObjectCollection objectCollection_0, object[] object_0)
	{
		objectCollection_0.AddRange(object_0);
	}

	static void smethod_46(TextBox textBox_0, bool bool_0)
	{
		textBox_0.set_Multiline(bool_0);
	}

	static void smethod_47(ButtonBase buttonBase_0, Color color_0)
	{
		buttonBase_0.set_BackColor(color_0);
	}

	static void smethod_48(ButtonBase buttonBase_0, string string_0)
	{
		buttonBase_0.set_Text(string_0);
	}

	static void smethod_49(ButtonBase buttonBase_0, bool bool_0)
	{
		buttonBase_0.set_UseVisualStyleBackColor(bool_0);
	}

	static void smethod_50(Timer timer_0, int int_0)
	{
		timer_0.set_Interval(int_0);
	}

	static void smethod_51(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_52(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static ControlCollection smethod_53(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_54(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_55(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_56(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.EndInit();
	}

	static void smethod_57(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_58(Control control_0)
	{
		control_0.PerformLayout();
	}

	static void smethod_59(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_60(Control control_0, EventHandler eventHandler_0)
	{
		control_0.remove_Click(eventHandler_0);
	}

	static void smethod_61(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_Click(eventHandler_0);
	}

	static void smethod_62(Timer timer_0, EventHandler eventHandler_0)
	{
		timer_0.remove_Tick(eventHandler_0);
	}

	static void smethod_63(Timer timer_0, EventHandler eventHandler_0)
	{
		timer_0.add_Tick(eventHandler_0);
	}

	static string smethod_64(object object_0, string string_0)
	{
		return Strings.Format(object_0, string_0);
	}

	static DateTime smethod_65(string string_0)
	{
		return Conversions.ToDate(string_0);
	}

	static void smethod_66(TextBoxBase textBoxBase_0)
	{
		textBoxBase_0.Clear();
	}

	static DateTime smethod_67()
	{
		return DateAndTime.get_Today();
	}

	static void smethod_68(ComboBox comboBox_0, int int_0)
	{
		comboBox_0.set_SelectedIndex(int_0);
	}

	static OleDbConnection smethod_69()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new OleDbConnection();
	}

	static string smethod_70(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static void smethod_71(OleDbConnection oleDbConnection_0, string string_0)
	{
		oleDbConnection_0.set_ConnectionString(string_0);
	}

	static string smethod_72(TextBox textBox_0)
	{
		return textBox_0.get_Text();
	}

	static string[] smethod_73(string string_0, char[] char_0)
	{
		return string_0.Split(char_0);
	}

	static DateTime smethod_74(DateTimePicker dateTimePicker_0)
	{
		return dateTimePicker_0.get_Value();
	}

	static void smethod_75(OleDbConnection oleDbConnection_0)
	{
		oleDbConnection_0.Open();
	}

	static OleDbCommand smethod_76(string string_0, OleDbConnection oleDbConnection_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new OleDbCommand(string_0, oleDbConnection_0);
	}

	static OleDbParameterCollection smethod_77(OleDbCommand oleDbCommand_0)
	{
		return oleDbCommand_0.get_Parameters();
	}

	static string smethod_78(string string_0)
	{
		return string_0.ToLower();
	}

	static OleDbParameter smethod_79(string string_0, object object_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new OleDbParameter(string_0, object_0);
	}

	static OleDbParameter smethod_80(OleDbParameterCollection oleDbParameterCollection_0, OleDbParameter oleDbParameter_0)
	{
		return oleDbParameterCollection_0.Add(oleDbParameter_0);
	}

	static string smethod_81(ComboBox comboBox_0)
	{
		return comboBox_0.get_Text();
	}

	static string smethod_82(DateTime dateTime_0)
	{
		return Conversions.ToString(dateTime_0);
	}

	static string smethod_83(string string_0)
	{
		return string_0.ToString();
	}

	static int smethod_84(OleDbCommand oleDbCommand_0)
	{
		return oleDbCommand_0.ExecuteNonQuery();
	}

	static void smethod_85(Component component_0)
	{
		component_0.Dispose();
	}

	static void smethod_86(OleDbConnection oleDbConnection_0)
	{
		oleDbConnection_0.Close();
	}

	static void smethod_87(Timer timer_0)
	{
		timer_0.Start();
	}

	static object smethod_88(object object_0)
	{
		return RuntimeHelpers.GetObjectValue(object_0);
	}

	static void smethod_89(Exception exception_0)
	{
		ProjectData.SetProjectError(exception_0);
	}

	static void smethod_90()
	{
		ProjectData.ClearProjectError();
	}

	static SmtpClient smethod_91()
	{
		return new SmtpClient();
	}

	static MailMessage smethod_92()
	{
		return new MailMessage();
	}

	static void smethod_93(SmtpClient smtpClient_0, bool bool_0)
	{
		smtpClient_0.UseDefaultCredentials = bool_0;
	}

	static NetworkCredential smethod_94(string string_0, string string_1)
	{
		return new NetworkCredential(string_0, string_1);
	}

	static void smethod_95(SmtpClient smtpClient_0, ICredentialsByHost icredentialsByHost_0)
	{
		smtpClient_0.Credentials = icredentialsByHost_0;
	}

	static void smethod_96(SmtpClient smtpClient_0, int int_0)
	{
		smtpClient_0.Port = int_0;
	}

	static void smethod_97(SmtpClient smtpClient_0, bool bool_0)
	{
		smtpClient_0.EnableSsl = bool_0;
	}

	static void smethod_98(SmtpClient smtpClient_0, string string_0)
	{
		smtpClient_0.Host = string_0;
	}

	static MailAddress smethod_99(string string_0)
	{
		return new MailAddress(string_0);
	}

	static void smethod_100(MailMessage mailMessage_0, MailAddress mailAddress_0)
	{
		mailMessage_0.From = mailAddress_0;
	}

	static MailAddressCollection smethod_101(MailMessage mailMessage_0)
	{
		return mailMessage_0.To;
	}

	static void smethod_102(MailAddressCollection mailAddressCollection_0, string string_0)
	{
		mailAddressCollection_0.Add(string_0);
	}

	static void smethod_103(MailMessage mailMessage_0, string string_0)
	{
		mailMessage_0.Subject = string_0;
	}

	static void smethod_104(MailMessage mailMessage_0, bool bool_0)
	{
		mailMessage_0.IsBodyHtml = bool_0;
	}

	static string smethod_105(string[] string_0)
	{
		return string.Concat(string_0);
	}

	static void smethod_106(MailMessage mailMessage_0, string string_0)
	{
		mailMessage_0.Body = string_0;
	}

	static void smethod_107(SmtpClient smtpClient_0, MailMessage mailMessage_0)
	{
		smtpClient_0.Send(mailMessage_0);
	}

	static MsgBoxResult smethod_108(object object_0, MsgBoxStyle msgBoxStyle_0, object object_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		return Interaction.MsgBox(object_0, msgBoxStyle_0, object_1);
	}

	static void smethod_109(Timer timer_0)
	{
		timer_0.Stop();
	}

	static int smethod_110(ComboBox comboBox_0)
	{
		return comboBox_0.get_SelectedIndex();
	}

	static int smethod_111(string string_0, string string_1, bool bool_0)
	{
		return Operators.CompareString(string_0, string_1, bool_0);
	}

	static Random smethod_112()
	{
		return new Random();
	}

	static int smethod_113(string string_0)
	{
		return string_0.Length;
	}

	static int smethod_114(Random random_0, int int_0, int int_1)
	{
		return random_0.Next(int_0, int_1);
	}

	static char smethod_115(string string_0, int int_0)
	{
		return string_0[int_0];
	}

	static string smethod_116(char char_0)
	{
		return Conversions.ToString(char_0);
	}
}
