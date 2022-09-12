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
internal class RegisterDonor : UserControl
{
	private IContainer components;

	private OleDbConnection myconnection;

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
			Timer timer = default(Timer);
			while (true)
			{
				int num = 1526056818;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x66A2909Bu) % 7u)
					{
					case 6u:
					{
						int num5;
						int num6;
						if (timer != null)
						{
							num5 = -337398168;
							num6 = -337398168;
						}
						else
						{
							num5 = -879167326;
							num6 = -879167326;
						}
						num = num5 ^ ((int)num2 * -275949859);
						continue;
					}
					case 5u:
						_Timer1 = value;
						timer = _Timer1;
						num = 559281731;
						continue;
					case 3u:
					{
						timer = _Timer1;
						int num3;
						int num4;
						if (timer != null)
						{
							num3 = 1089040179;
							num4 = 1089040179;
						}
						else
						{
							num3 = 1335636299;
							num4 = 1335636299;
						}
						num = num3 ^ (int)(num2 * 1339283894);
						continue;
					}
					case 2u:
						RegisterDonor.smethod_57(timer, eventHandler_);
						num = (int)(num2 * 1929009097) ^ -394053383;
						continue;
					case 1u:
						RegisterDonor.smethod_56(timer, eventHandler_);
						num = ((int)num2 * -1520243712) ^ -599205395;
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

	[field: AccessedThroughProperty("SuccessMsg")]
	internal virtual Label SuccessMsg
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
				int num = -1431607310;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x939441E1u) % 8u)
					{
					case 7u:
						RegisterDonor.smethod_59((Control)(object)clearBtn, eventHandler_);
						num = (int)(num2 * 1480142730) ^ -1748590523;
						continue;
					case 6u:
					{
						int num5;
						int num6;
						if (clearBtn == null)
						{
							num5 = -1634372799;
							num6 = -1634372799;
						}
						else
						{
							num5 = -1542445340;
							num6 = -1542445340;
						}
						num = num5 ^ ((int)num2 * -810858577);
						continue;
					}
					case 5u:
						_ClearBtn = value;
						num = -451038819;
						continue;
					case 4u:
						clearBtn = _ClearBtn;
						num = (int)((num2 * 873531380) ^ 0x5E9B1B8F);
						continue;
					case 3u:
					{
						clearBtn = _ClearBtn;
						int num3;
						int num4;
						if (clearBtn != null)
						{
							num3 = -1228343295;
							num4 = -1228343295;
						}
						else
						{
							num3 = -1605752755;
							num4 = -1605752755;
						}
						num = num3 ^ (int)(num2 * 1560388187);
						continue;
					}
					case 1u:
						RegisterDonor.smethod_58((Control)(object)clearBtn, eventHandler_);
						num = ((int)num2 * -2073034502) ^ -171413322;
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

	internal virtual Button AddBtn
	{
		[CompilerGenerated]
		get
		{
			return _AddBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = Button1_Click;
			Button addBtn = _AddBtn;
			if (addBtn != null)
			{
				goto IL_0048;
			}
			goto IL_00b4;
			IL_00b4:
			_AddBtn = value;
			int num = -606715175;
			goto IL_0087;
			IL_0087:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEC020BF9u) % 7u)
				{
				case 6u:
					RegisterDonor.smethod_59((Control)(object)addBtn, eventHandler_);
					num = ((int)num2 * -187112075) ^ 0x32BBB0FC;
					continue;
				case 5u:
					addBtn = _AddBtn;
					num = ((int)num2 * -565885638) ^ -590407398;
					continue;
				case 4u:
					break;
				case 1u:
					RegisterDonor.smethod_58((Control)(object)addBtn, eventHandler_);
					num = (int)(num2 * 248344310) ^ -586731309;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (addBtn != null)
					{
						num3 = 696099125;
						num4 = 696099125;
					}
					else
					{
						num3 = 124730508;
						num4 = 124730508;
					}
					num = num3 ^ (int)(num2 * 452491285);
					continue;
				}
				default:
					return;
				case 2u:
					goto IL_00b4;
				case 3u:
					return;
				}
				break;
			}
			goto IL_0048;
			IL_0048:
			num = -69924263;
			goto IL_0087;
		}
	}

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckBox8")]
	internal virtual CheckBox CheckBox8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckBox7")]
	internal virtual CheckBox CheckBox7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckBox6")]
	internal virtual CheckBox CheckBox6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckBox5")]
	internal virtual CheckBox CheckBox5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckBox4")]
	internal virtual CheckBox CheckBox4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckBox3")]
	internal virtual CheckBox CheckBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckBox2")]
	internal virtual CheckBox CheckBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckBox1")]
	internal virtual CheckBox CheckBox1
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

	[field: AccessedThroughProperty("DateTxt")]
	internal virtual TextBox DateTxt
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

	[field: AccessedThroughProperty("QuantityTxt")]
	internal virtual TextBox QuantityTxt
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

	[field: AccessedThroughProperty("WarningLbl")]
	internal virtual Label WarningLbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("BloodGrpTxt")]
	internal virtual ComboBox BloodGrpTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("BloodGrpLbl")]
	internal virtual Label BloodGrpLbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox GenderTxt
	{
		[CompilerGenerated]
		get
		{
			return _GenderTxt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = GenderTxt_SelectionChangeCommitted;
			ComboBox genderTxt = _GenderTxt;
			if (genderTxt != null)
			{
				goto IL_0082;
			}
			goto IL_00b4;
			IL_00b4:
			_GenderTxt = value;
			int num = -1509295379;
			goto IL_0087;
			IL_0087:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF9D61AE4u) % 7u)
				{
				case 5u:
				{
					int num3;
					int num4;
					if (genderTxt == null)
					{
						num3 = 476417462;
						num4 = 476417462;
					}
					else
					{
						num3 = 1521948387;
						num4 = 1521948387;
					}
					num = num3 ^ (int)(num2 * 592814164);
					continue;
				}
				case 4u:
					genderTxt = _GenderTxt;
					num = (int)(num2 * 567459464) ^ -1627434378;
					continue;
				case 3u:
					RegisterDonor.smethod_60(genderTxt, eventHandler_);
					num = ((int)num2 * -1490727394) ^ -1196685516;
					continue;
				case 2u:
					RegisterDonor.smethod_61(genderTxt, eventHandler_);
					num = ((int)num2 * -524828016) ^ -584886706;
					continue;
				case 0u:
					break;
				default:
					return;
				case 6u:
					goto IL_00b4;
				case 1u:
					return;
				}
				break;
			}
			goto IL_0082;
			IL_0082:
			num = -135238356;
			goto IL_0087;
		}
	}

	[field: AccessedThroughProperty("AgeLbl")]
	internal virtual Label AgeLbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("AgeTxt")]
	internal virtual TextBox AgeTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MobileLbl")]
	internal virtual Label MobileLbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GenderLbl")]
	internal virtual Label GenderLbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("NameLbl")]
	internal virtual Label NameLbl
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

	[field: AccessedThroughProperty("NameTxt")]
	internal virtual TextBox NameTxt
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

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
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

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public RegisterDonor()
	{
		while (true)
		{
			int num = 713246800;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x17167219u) % 5u)
				{
				case 4u:
					RegisterDonor.smethod_0((UserControl)(object)this, (EventHandler)RegisterDonor_Load);
					myconnection = RegisterDonor.smethod_1();
					InitializeComponent();
					num = (int)(num2 * 1744199900) ^ -784947008;
					continue;
				case 1u:
					num = ((int)num2 * -1938772694) ^ 0x64867043;
					continue;
				case 0u:
					num = ((int)num2 * -759837588) ^ -1397361017;
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

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			bool flag = default(bool);
			while (true)
			{
				int num = 483575153;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x51C54F35u) % 7u)
					{
					case 6u:
						num3 = ((components != null) ? 1 : 0);
						goto IL_0010;
					case 4u:
						num = 1531304543;
						continue;
					case 3u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = -336102616;
							num5 = -336102616;
						}
						else
						{
							num4 = -1162982124;
							num5 = -1162982124;
						}
						num = num4 ^ (int)(num2 * 603692236);
						continue;
					}
					case 1u:
						if (disposing)
						{
							num = ((int)num2 * -1378954530) ^ 0x131B95BD;
							continue;
						}
						num3 = 0;
						goto IL_0010;
					case 0u:
						RegisterDonor.smethod_2((IDisposable)components);
						num = ((int)num2 * -1267439371) ^ 0x5CFB3C7D;
						continue;
					default:
						return;
					case 5u:
						break;
					case 2u:
						return;
						IL_0010:
						flag = (byte)num3 != 0;
						num = 865923838;
						continue;
					}
					break;
				}
			}
		}
		finally
		{
			while (true)
			{
				IL_00ed:
				int num6 = 2029216200;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num6 ^ 0x51C54F35u) % 4u)
					{
					case 1u:
						((ContainerControl)this).Dispose(disposing);
						num6 = (int)(num2 * 51317137) ^ -1586587092;
						continue;
					case 0u:
						num6 = ((int)num2 * -1046104119) ^ -1229796809;
						continue;
					default:
						goto end_IL_00cc;
					case 3u:
						break;
					case 2u:
						goto end_IL_00cc;
					}
					goto IL_00ed;
					continue;
					end_IL_00cc:
					break;
				}
				break;
			}
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		while (true)
		{
			int num = 1499547710;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1F8A2131u) % 406u)
				{
				case 405u:
					RegisterDonor.smethod_27((Control)(object)ClearBtn, Color.White);
					num = ((int)num2 * -1176466998) ^ -1243722196;
					continue;
				case 404u:
					RegisterDonor.smethod_17((Control)(object)AddBtn, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1896761420) ^ 0x771851AA);
					continue;
				case 403u:
					num = (int)((num2 * 1803086054) ^ 0x65538715);
					continue;
				case 402u:
					RegisterDonor.smethod_36(MobileLbl, bool_0: true);
					num = (int)(num2 * 284118662) ^ -494834394;
					continue;
				case 401u:
					RegisterDonor.smethod_21((Control)(object)Label4, 26);
					num = ((int)num2 * -1086964232) ^ 0x4C18E292;
					continue;
				case 400u:
					NameTxt = RegisterDonor.smethod_9();
					num = (int)((num2 * 163181581) ^ 0x47E26775);
					continue;
				case 399u:
					RegisterDonor.smethod_20((Control)(object)CheckBox7, new Size(116, 23));
					num = ((int)num2 * -420727022) ^ 0x57D31F2C;
					continue;
				case 398u:
					Timer1 = RegisterDonor.smethod_4(components);
					num = (int)(num2 * 195422354) ^ -881800835;
					continue;
				case 397u:
					RegisterDonor.smethod_22(GenderLbl, "Gender :");
					RegisterDonor.smethod_23(GenderLbl, (ContentAlignment)32);
					num = (int)(num2 * 659151257) ^ -1234597748;
					continue;
				case 396u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_48((Control)(object)this), (Control)(object)GroupBox2);
					num = ((int)num2 * -1165462194) ^ -1343568420;
					continue;
				case 395u:
					RegisterDonor.smethod_20((Control)(object)BloodGrpTxt, new Size(113, 27));
					num = (int)((num2 * 2102661312) ^ 0x48394A3A);
					continue;
				case 394u:
					RegisterDonor.smethod_18((Control)(object)BloodGrpTxt, new Point(163, 277));
					num = ((int)num2 * -349767162) ^ 0x3782BEA4;
					continue;
				case 393u:
					RegisterDonor.smethod_21((Control)(object)Label7, 22);
					num = (int)(num2 * 340313758) ^ -1081879760;
					continue;
				case 392u:
					RegisterDonor.smethod_19((Control)(object)WarningLbl, "WarningLbl");
					num = ((int)num2 * -153983088) ^ -65915117;
					continue;
				case 391u:
					num = (int)(num2 * 1967816892) ^ -442186975;
					continue;
				case 390u:
					num = ((int)num2 * -1964271322) ^ 0x1513742E;
					continue;
				case 389u:
					num = (int)((num2 * 430435083) ^ 0x6849899D);
					continue;
				case 388u:
					RegisterDonor.smethod_18((Control)(object)GenderLbl, new Point(25, 229));
					num = (int)((num2 * 447777810) ^ 0x785E957);
					continue;
				case 387u:
					RegisterDonor.smethod_19((Control)(object)NameTxt, "NameTxt");
					num = ((int)num2 * -1970822714) ^ 0x6D714614;
					continue;
				case 386u:
					RegisterDonor.smethod_20((Control)(object)CheckBox8, new Size(96, 23));
					num = ((int)num2 * -1703571031) ^ 0x7CFDC237;
					continue;
				case 385u:
					num = ((int)num2 * -341387677) ^ 0x1550145;
					continue;
				case 384u:
					RegisterDonor.smethod_21((Control)(object)CheckBox2, 1);
					num = (int)((num2 * 1098521277) ^ 0x609677D1);
					continue;
				case 383u:
					RegisterDonor.smethod_28((ButtonBase)(object)CheckBox3, "HIV");
					num = (int)((num2 * 762761638) ^ 0x2AA38681);
					continue;
				case 382u:
					num = (int)((num2 * 1184721000) ^ 0x3B65AA65);
					continue;
				case 381u:
					num = (int)((num2 * 691758023) ^ 0x62DD7CC8);
					continue;
				case 380u:
					RegisterDonor.smethod_17((Control)(object)GroupBox2, RegisterDonor.smethod_26("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -2042616241) ^ 0x6C4E56FA;
					continue;
				case 379u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox2), (Control)(object)MobileLbl);
					num = ((int)num2 * -1245517773) ^ -1555949934;
					continue;
				case 378u:
					RegisterDonor.smethod_19((Control)(object)Label3, "Label3");
					num = (int)(num2 * 2074625501) ^ -1921486723;
					continue;
				case 377u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox1), (Control)(object)CheckBox6);
					num = (int)((num2 * 1825152167) ^ 0x633263C6);
					continue;
				case 376u:
					num = (int)((num2 * 217541195) ^ 0x7745CFFD);
					continue;
				case 375u:
					RegisterDonor.smethod_20((Control)(object)Label1, new Size(242, 35));
					num = (int)((num2 * 1745277986) ^ 0x52C2BD2F);
					continue;
				case 374u:
					num = ((int)num2 * -1213774153) ^ -246331676;
					continue;
				case 373u:
					RegisterDonor.smethod_19((Control)(object)MobileTxt, "MobileTxt");
					num = ((int)num2 * -602784051) ^ 0x3C91ACC9;
					continue;
				case 372u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox1), (Control)(object)CheckBox3);
					num = (int)((num2 * 1099135921) ^ 0x40ED76D);
					continue;
				case 371u:
					RegisterDonor.smethod_29((ButtonBase)(object)CheckBox7, bool_0: true);
					num = ((int)num2 * -1736341950) ^ 0x658A8C73;
					continue;
				case 370u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_48((Control)(object)this), (Control)(object)SuccessMsg);
					num = ((int)num2 * -820946498) ^ 0x40D3FD70;
					continue;
				case 369u:
					RegisterDonor.smethod_21((Control)(object)ClearBtn, 20);
					num = (int)((num2 * 1785209835) ^ 0x4541E124);
					continue;
				case 368u:
					RegisterDonor.smethod_28((ButtonBase)(object)CheckBox1, "Hepatitus B");
					num = ((int)num2 * -2012943598) ^ 0x14498FA6;
					continue;
				case 367u:
					RegisterDonor.smethod_17((Control)(object)CheckBox2, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					RegisterDonor.smethod_18((Control)(object)CheckBox2, new Point(34, 137));
					num = (int)((num2 * 564854376) ^ 0x4C528487);
					continue;
				case 366u:
					RegisterDonor.smethod_21((Control)(object)GenderLbl, 6);
					num = ((int)num2 * -164539141) ^ 0x32493B08;
					continue;
				case 365u:
					RegisterDonor.smethod_17((Control)(object)GroupBox1, RegisterDonor.smethod_26("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1799688445) ^ 0xFC04639);
					continue;
				case 364u:
					RegisterDonor.smethod_20((Control)(object)QuantityTxt, new Size(87, 26));
					num = ((int)num2 * -432063635) ^ -930032268;
					continue;
				case 363u:
					num = (int)(num2 * 1079851295) ^ -2012422901;
					continue;
				case 362u:
					RegisterDonor.smethod_18((Control)(object)CheckBox6, new Point(34, 333));
					num = ((int)num2 * -1248919970) ^ 0x4B9F5C4E;
					continue;
				case 361u:
					RegisterDonor.smethod_18((Control)(object)CheckBox7, new Point(34, 387));
					num = (int)((num2 * 1688035746) ^ 0x2360C462);
					continue;
				case 360u:
					RegisterDonor.smethod_21((Control)(object)CheckBox7, 6);
					num = ((int)num2 * -2018288470) ^ 0x3D1C17BE;
					continue;
				case 359u:
					RegisterDonor.smethod_20((Control)(object)AgeTxt, new Size(124, 26));
					num = ((int)num2 * -103077170) ^ 0x2086FCF6;
					continue;
				case 358u:
					RegisterDonor.smethod_29((ButtonBase)(object)CheckBox4, bool_0: true);
					num = ((int)num2 * -764385416) ^ 0x706B4146;
					continue;
				case 357u:
					num = (int)((num2 * 1813079177) ^ 0x1928FEB6);
					continue;
				case 356u:
					num = (int)((num2 * 289619156) ^ 0x3CBCA2CA);
					continue;
				case 355u:
					RegisterDonor.smethod_45((ContainerControl)(object)this, new SizeF(8f, 16f));
					num = (int)(num2 * 1810950632) ^ -327466310;
					continue;
				case 354u:
					RegisterDonor.smethod_18((Control)(object)CheckBox4, new Point(34, 237));
					num = ((int)num2 * -1211168422) ^ 0x2E02CDE8;
					continue;
				case 353u:
					RegisterDonor.smethod_23(Label2, (ContentAlignment)32);
					num = ((int)num2 * -1862656168) ^ 0x2A6B4488;
					continue;
				case 352u:
					num = ((int)num2 * -1819843266) ^ 0x3E06D2D1;
					continue;
				case 351u:
					num = (int)(num2 * 860213409) ^ -179868107;
					continue;
				case 350u:
					RegisterDonor.smethod_21((Control)(object)CheckBox1, 0);
					num = ((int)num2 * -778340476) ^ -1562286987;
					continue;
				case 349u:
					num = (int)((num2 * 1721352703) ^ 0x121401B8);
					continue;
				case 348u:
					num = ((int)num2 * -1863832808) ^ 0x56810D29;
					continue;
				case 347u:
					num = (int)(num2 * 1640231307) ^ -1053404952;
					continue;
				case 346u:
					num = ((int)num2 * -1471169311) ^ 0xDDC2A2F;
					continue;
				case 345u:
					RegisterDonor.smethod_37(BloodGrpTxt, (ComboBoxStyle)2);
					num = (int)((num2 * 2095327881) ^ 0xC1BEDE9);
					continue;
				case 344u:
					num = ((int)num2 * -492251825) ^ 0xBB106B1;
					continue;
				case 343u:
					RegisterDonor.smethod_21((Control)(object)Label2, 24);
					num = ((int)num2 * -768100634) ^ 0x4A7D14DE;
					continue;
				case 342u:
					GroupBox1 = RegisterDonor.smethod_7();
					num = (int)((num2 * 534010203) ^ 0x13DCB928);
					continue;
				case 341u:
					RegisterDonor.smethod_20((Control)(object)CheckBox6, new Size(93, 23));
					RegisterDonor.smethod_21((Control)(object)CheckBox6, 5);
					num = ((int)num2 * -1859275941) ^ -712696489;
					continue;
				case 340u:
					num = ((int)num2 * -1470866254) ^ 0x6E8B4028;
					continue;
				case 339u:
					RegisterDonor.smethod_18((Control)(object)GroupBox1, new Point(614, 198));
					num = (int)(num2 * 565358128) ^ -1481883133;
					continue;
				case 338u:
					RegisterDonor.smethod_36(Label4, bool_0: true);
					num = (int)(num2 * 1146234423) ^ -379827396;
					continue;
				case 337u:
					RegisterDonor.smethod_51((Control)(object)GroupBox1, bool_0: false);
					num = (int)((num2 * 1036659448) ^ 0x5969AEAC);
					continue;
				case 336u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox2), (Control)(object)AgeTxt);
					num = ((int)num2 * -294376342) ^ -974104342;
					continue;
				case 335u:
					RegisterDonor.smethod_17((Control)(object)CheckBox7, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -146686360) ^ -13779348;
					continue;
				case 334u:
					num = ((int)num2 * -1075152879) ^ -776660215;
					continue;
				case 333u:
					RegisterDonor.smethod_12((Control)(object)GroupBox2);
					num = ((int)num2 * -814980762) ^ 0x3576AA;
					continue;
				case 332u:
					CheckBox5 = RegisterDonor.smethod_8();
					num = ((int)num2 * -1984838603) ^ -5141480;
					continue;
				case 331u:
					RegisterDonor.smethod_21((Control)(object)CheckBox3, 2);
					num = (int)((num2 * 1809258082) ^ 0x51F6DD39);
					continue;
				case 330u:
					num = ((int)num2 * -37514147) ^ -1751725819;
					continue;
				case 329u:
					num = (int)(num2 * 931245311) ^ -1107663181;
					continue;
				case 328u:
					num = ((int)num2 * -80358537) ^ 0x34D7495C;
					continue;
				case 327u:
					RegisterDonor.smethod_14((Control)(object)this);
					num = ((int)num2 * -841901274) ^ -1338309232;
					continue;
				case 326u:
					CheckBox2 = RegisterDonor.smethod_8();
					num = (int)(num2 * 171139580) ^ -657903385;
					continue;
				case 325u:
					num = ((int)num2 * -1454034114) ^ 0x5DBA6D85;
					continue;
				case 324u:
					num = (int)((num2 * 2062116360) ^ 0xE0FC972);
					continue;
				case 323u:
					RegisterDonor.smethod_21((Control)(object)AddBtn, 19);
					num = ((int)num2 * -1442291892) ^ -1357058863;
					continue;
				case 322u:
					Label3 = RegisterDonor.smethod_5();
					num = ((int)num2 * -696180122) ^ -405926707;
					continue;
				case 321u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox1), (Control)(object)CheckBox4);
					num = (int)((num2 * 198815694) ^ 0xB27BBD7);
					continue;
				case 320u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox2), (Control)(object)GenderLbl);
					num = (int)(num2 * 818092923) ^ -2107322206;
					continue;
				case 319u:
					num = ((int)num2 * -663331873) ^ 0x4B97B021;
					continue;
				case 318u:
					CheckBox8 = RegisterDonor.smethod_8();
					num = (int)(num2 * 1939802607) ^ -411709434;
					continue;
				case 317u:
					num = ((int)num2 * -2129184865) ^ -277921188;
					continue;
				case 316u:
					RegisterDonor.smethod_22(Label2, "Date :");
					num = (int)((num2 * 196484788) ^ 0x2A30F57E);
					continue;
				case 315u:
					num = (int)(num2 * 335821546) ^ -1126270647;
					continue;
				case 314u:
					RegisterDonor.smethod_21((Control)(object)MobileTxt, 2);
					num = (int)((num2 * 1100623177) ^ 0x5AFE1C4D);
					continue;
				case 313u:
					RegisterDonor.smethod_17((Control)(object)CheckBox5, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -434391742) ^ 0x35F6A770;
					continue;
				case 312u:
					RegisterDonor.smethod_53((ISupportInitialize)PictureBox1);
					num = (int)(num2 * 802013081) ^ -1633345817;
					continue;
				case 311u:
					num = (int)(num2 * 1365284581) ^ -1323949476;
					continue;
				case 310u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox1), (Control)(object)CheckBox5);
					num = (int)((num2 * 984121995) ^ 0x4877D7DD);
					continue;
				case 309u:
					num = ((int)num2 * -1895039588) ^ -1844786759;
					continue;
				case 308u:
					RegisterDonor.smethod_18((Control)(object)CheckBox8, new Point(34, 434));
					num = ((int)num2 * -2005732842) ^ -1686787698;
					continue;
				case 307u:
					RegisterDonor.smethod_23(WarningLbl, (ContentAlignment)32);
					num = ((int)num2 * -1058002832) ^ 0x73D415B0;
					continue;
				case 306u:
					RegisterDonor.smethod_20((Control)(object)PictureBox1, new Size(230, 123));
					num = (int)(num2 * 986984261) ^ -306286895;
					continue;
				case 305u:
					num = ((int)num2 * -2042143019) ^ 0x303C6043;
					continue;
				case 304u:
					RegisterDonor.smethod_34((ButtonBase)(object)CheckBox2, bool_0: true);
					num = ((int)num2 * -664824690) ^ 0x220CBFBA;
					continue;
				case 303u:
					num = (int)(num2 * 2034227416) ^ -1692324989;
					continue;
				case 302u:
					RegisterDonor.smethod_18((Control)(object)MobileLbl, new Point(25, 181));
					num = (int)(num2 * 560806603) ^ -1793267134;
					continue;
				case 301u:
					RegisterDonor.smethod_19((Control)(object)PictureBox1, "PictureBox1");
					num = (int)((num2 * 1767214116) ^ 0x3F4FBF4D);
					continue;
				case 300u:
					num = (int)(num2 * 1204503493) ^ -875093721;
					continue;
				case 299u:
					RegisterDonor.smethod_19((Control)(object)CheckBox7, "CheckBox7");
					num = ((int)num2 * -393996311) ^ 0x66ED4C71;
					continue;
				case 298u:
					RegisterDonor.smethod_20((Control)(object)CheckBox3, new Size(60, 23));
					num = (int)(num2 * 777710871) ^ -1224071337;
					continue;
				case 297u:
					num = ((int)num2 * -1878771450) ^ -922159842;
					continue;
				case 296u:
					num = ((int)num2 * -1010703302) ^ 0x6B999928;
					continue;
				case 295u:
					RegisterDonor.smethod_18((Control)(object)AgeLbl, new Point(25, 131));
					num = (int)(num2 * 30491512) ^ -1859409403;
					continue;
				case 294u:
					ClearBtn = RegisterDonor.smethod_6();
					num = ((int)num2 * -539529165) ^ -904974009;
					continue;
				case 293u:
					RegisterDonor.smethod_17((Control)(object)AgeTxt, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 806864513) ^ 0x22677BDC);
					continue;
				case 292u:
					RegisterDonor.smethod_19((Control)(object)GenderTxt, "GenderTxt");
					RegisterDonor.smethod_20((Control)(object)GenderTxt, new Size(124, 27));
					num = ((int)num2 * -613123385) ^ 0x29C38490;
					continue;
				case 291u:
					RegisterDonor.smethod_18((Control)(object)NameLbl, new Point(25, 76));
					num = (int)(num2 * 1696137314) ^ -2012701668;
					continue;
				case 290u:
					RegisterDonor.smethod_23(Label7, (ContentAlignment)32);
					num = (int)(num2 * 932305677) ^ -687276698;
					continue;
				case 289u:
					RegisterDonor.smethod_19((Control)(object)BloodGrpLbl, "BloodGrpLbl");
					num = (int)(num2 * 1686497092) ^ -1832290596;
					continue;
				case 288u:
					RegisterDonor.smethod_22(NameLbl, "Name :");
					num = (int)(num2 * 165693874) ^ -265816408;
					continue;
				case 287u:
					num = ((int)num2 * -530096086) ^ 0x584F8D21;
					continue;
				case 286u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox2), (Control)(object)WarningLbl);
					num = (int)((num2 * 1417805426) ^ 0x10875CE8);
					continue;
				case 285u:
					num = (int)((num2 * 1024643082) ^ 0x49DCC5ED);
					continue;
				case 284u:
					RegisterDonor.smethod_20((Control)(object)CheckBox4, new Size(85, 23));
					num = (int)((num2 * 1744462666) ^ 0x6D590F6C);
					continue;
				case 283u:
					num = (int)((num2 * 1136366421) ^ 0x171F57BC);
					continue;
				case 282u:
					CheckBox3 = RegisterDonor.smethod_8();
					num = ((int)num2 * -1971430560) ^ -834787289;
					continue;
				case 281u:
					GroupBox2 = RegisterDonor.smethod_7();
					DateTxt = RegisterDonor.smethod_9();
					num = ((int)num2 * -1338305437) ^ -1453455890;
					continue;
				case 280u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox2), (Control)(object)Label2);
					num = ((int)num2 * -906847887) ^ -319826343;
					continue;
				case 279u:
					RegisterDonor.smethod_13((ISupportInitialize)PictureBox1);
					num = ((int)num2 * -1085972101) ^ -827542513;
					continue;
				case 278u:
					QuantityTxt = RegisterDonor.smethod_9();
					Label7 = RegisterDonor.smethod_5();
					WarningLbl = RegisterDonor.smethod_5();
					num = ((int)num2 * -414193835) ^ -2128348910;
					continue;
				case 277u:
					num = ((int)num2 * -720596623) ^ -743258122;
					continue;
				case 276u:
					RegisterDonor.smethod_18((Control)(object)PictureBox1, new Point(156, 33));
					num = (int)((num2 * 159243595) ^ 0x5A0055C3);
					continue;
				case 275u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_48((Control)(object)this), (Control)(object)Label1);
					num = ((int)num2 * -156961099) ^ 0x2186739D;
					continue;
				case 274u:
					RegisterDonor.smethod_27((Control)(object)WarningLbl, Color.Red);
					num = (int)((num2 * 1764682148) ^ 0xFCA977C);
					continue;
				case 273u:
					num = ((int)num2 * -350195437) ^ -1608601924;
					continue;
				case 272u:
					num = ((int)num2 * -1408396648) ^ 0x268427D6;
					continue;
				case 271u:
					RegisterDonor.smethod_36(WarningLbl, bool_0: true);
					RegisterDonor.smethod_17((Control)(object)WarningLbl, RegisterDonor.smethod_26("Microsoft Sans Serif", 7.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1361854238) ^ -1326884791;
					continue;
				case 270u:
					RegisterDonor.smethod_18((Control)(object)Label1, new Point(392, 60));
					num = (int)((num2 * 726101252) ^ 0x4FEDE7AF);
					continue;
				case 269u:
					RegisterDonor.smethod_18((Control)(object)CheckBox3, new Point(34, 187));
					RegisterDonor.smethod_19((Control)(object)CheckBox3, "CheckBox3");
					num = ((int)num2 * -1416593536) ^ 0x67801AE4;
					continue;
				case 268u:
					RegisterDonor.smethod_21((Control)(object)MobileLbl, 8);
					num = ((int)num2 * -827498494) ^ -135837186;
					continue;
				case 267u:
					RegisterDonor.smethod_25((ButtonBase)(object)ClearBtn, Color.MidnightBlue);
					num = ((int)num2 * -1325021686) ^ -1941238815;
					continue;
				case 266u:
					num = ((int)num2 * -1114440192) ^ -658659326;
					continue;
				case 265u:
					RegisterDonor.smethod_17((Control)(object)QuantityTxt, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1611106041) ^ -2033240673;
					continue;
				case 264u:
					PictureBox1 = RegisterDonor.smethod_11();
					Label4 = RegisterDonor.smethod_5();
					num = (int)(num2 * 1442219977) ^ -409951775;
					continue;
				case 263u:
					num = (int)((num2 * 1408448782) ^ 0x6E613309);
					continue;
				case 262u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox2), (Control)(object)QuantityTxt);
					num = (int)(num2 * 1754108511) ^ -1482714790;
					continue;
				case 261u:
					RegisterDonor.smethod_17((Control)(object)CheckBox3, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1424664104) ^ 0x5C4F62EE;
					continue;
				case 260u:
					RegisterDonor.smethod_34((ButtonBase)(object)CheckBox6, bool_0: true);
					RegisterDonor.smethod_17((Control)(object)CheckBox6, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1518942807) ^ -1135336567;
					continue;
				case 259u:
					num = ((int)num2 * -1129691160) ^ -694754171;
					continue;
				case 258u:
					RegisterDonor.smethod_18((Control)(object)MobileTxt, new Point(147, 178));
					num = (int)((num2 * 504853113) ^ 0x6195D75D);
					continue;
				case 257u:
					num = ((int)num2 * -1480224210) ^ 0x4272F0EA;
					continue;
				case 256u:
					Label1 = RegisterDonor.smethod_5();
					num = (int)(num2 * 800211948) ^ -1146328289;
					continue;
				case 255u:
					RegisterDonor.smethod_17((Control)(object)BloodGrpTxt, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -411233441) ^ -1081526200;
					continue;
				case 254u:
					RegisterDonor.smethod_29((ButtonBase)(object)CheckBox2, bool_0: true);
					num = ((int)num2 * -1518969263) ^ 0x48E06B99;
					continue;
				case 253u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_48((Control)(object)this), (Control)(object)AddBtn);
					num = (int)(num2 * 1816077230) ^ -1747995190;
					continue;
				case 252u:
					RegisterDonor.smethod_34((ButtonBase)(object)CheckBox1, bool_0: true);
					RegisterDonor.smethod_17((Control)(object)CheckBox1, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1668492465) ^ 0x272D8D2F);
					continue;
				case 251u:
					RegisterDonor.smethod_21((Control)(object)DateTxt, 25);
					num = ((int)num2 * -335272594) ^ -44607099;
					continue;
				case 250u:
					num = (int)((num2 * 1073708977) ^ 0x5E6200BC);
					continue;
				case 249u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_48((Control)(object)this), (Control)(object)ClearBtn);
					num = ((int)num2 * -457897334) ^ 0x3A091F46;
					continue;
				case 248u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_48((Control)(object)this), (Control)(object)PictureBox1);
					num = ((int)num2 * -655381953) ^ 0x3D787871;
					continue;
				case 247u:
					RegisterDonor.smethod_22(Label1, "Register Donor");
					RegisterDonor.smethod_23(Label1, (ContentAlignment)32);
					RegisterDonor.smethod_41(PictureBox1, (Image)(object)Resources.images1232);
					num = (int)((num2 * 381559657) ^ 0x11522F7C);
					continue;
				case 246u:
					num = ((int)num2 * -1561624699) ^ 0x6E3EF3B9;
					continue;
				case 245u:
					RegisterDonor.smethod_46((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 2136615304) ^ 0x2736317D);
					continue;
				case 244u:
					RegisterDonor.smethod_23(AgeLbl, (ContentAlignment)32);
					num = ((int)num2 * -1609950919) ^ -795991430;
					continue;
				case 243u:
					num = (int)((num2 * 1062553543) ^ 0x74B1E74B);
					continue;
				case 242u:
					RegisterDonor.smethod_19((Control)(object)Label2, "Label2");
					num = (int)(num2 * 21267854) ^ -899339058;
					continue;
				case 241u:
					RegisterDonor.smethod_17((Control)(object)CheckBox8, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 429298879) ^ 0x114A798C);
					continue;
				case 240u:
					AgeTxt = RegisterDonor.smethod_9();
					num = ((int)num2 * -741933987) ^ 0x20B1BC87;
					continue;
				case 239u:
					RegisterDonor.smethod_17((Control)(object)Label7, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 2067796192) ^ -857991590;
					continue;
				case 238u:
					RegisterDonor.smethod_23(NameLbl, (ContentAlignment)32);
					num = ((int)num2 * -2059066104) ^ 0x780C8AB1;
					continue;
				case 237u:
					RegisterDonor.smethod_20((Control)(object)CheckBox1, new Size(127, 23));
					num = (int)((num2 * 1716801502) ^ 0x6B5504FB);
					continue;
				case 236u:
					num = ((int)num2 * -1864205925) ^ 0x5B577EA0;
					continue;
				case 235u:
					RegisterDonor.smethod_18((Control)(object)GroupBox2, new Point(68, 234));
					num = ((int)num2 * -1842162987) ^ -119652644;
					continue;
				case 234u:
					num = ((int)num2 * -2050481796) ^ -1086692550;
					continue;
				case 233u:
					num = (int)((num2 * 1160858732) ^ 0x562D752A);
					continue;
				case 232u:
					RegisterDonor.smethod_28((ButtonBase)(object)CheckBox2, "Hepatitus C");
					num = (int)((num2 * 801097492) ^ 0x74E200CB);
					continue;
				case 231u:
					RegisterDonor.smethod_23(Label3, (ContentAlignment)32);
					RegisterDonor.smethod_34((ButtonBase)(object)CheckBox8, bool_0: true);
					num = (int)(num2 * 251153096) ^ -312303262;
					continue;
				case 230u:
					RegisterDonor.smethod_25((ButtonBase)(object)AddBtn, Color.MidnightBlue);
					num = (int)(num2 * 639155786) ^ -1623900705;
					continue;
				case 229u:
					RegisterDonor.smethod_19((Control)(object)CheckBox5, "CheckBox5");
					num = (int)(num2 * 249635507) ^ -600843470;
					continue;
				case 228u:
					RegisterDonor.smethod_20((Control)(object)ClearBtn, new Size(148, 51));
					num = ((int)num2 * -923781196) ^ 0x5ADE7A52;
					continue;
				case 227u:
					num = (int)((num2 * 432425941) ^ 0x2060067A);
					continue;
				case 226u:
					num = (int)(num2 * 1912090346) ^ -1616374918;
					continue;
				case 225u:
					num = (int)((num2 * 1658041633) ^ 0x57F291D);
					continue;
				case 224u:
					num = ((int)num2 * -1073441417) ^ 0x1E2EDF1;
					continue;
				case 223u:
					RegisterDonor.smethod_29((ButtonBase)(object)CheckBox5, bool_0: true);
					num = (int)(num2 * 472968405) ^ -888354774;
					continue;
				case 222u:
					RegisterDonor.smethod_19((Control)(object)GroupBox2, "GroupBox2");
					num = ((int)num2 * -967836674) ^ 0x2AA97ED;
					continue;
				case 221u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox2), (Control)(object)Label4);
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox2), (Control)(object)DateTxt);
					num = ((int)num2 * -710595209) ^ -1576646839;
					continue;
				case 220u:
					RegisterDonor.smethod_19((Control)(object)DateTxt, "DateTxt");
					RegisterDonor.smethod_35((TextBoxBase)(object)DateTxt, bool_0: true);
					RegisterDonor.smethod_20((Control)(object)DateTxt, new Size(167, 26));
					num = ((int)num2 * -436929261) ^ -2081044456;
					continue;
				case 219u:
					num = (int)(num2 * 812454943) ^ -681950123;
					continue;
				case 218u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox1), (Control)(object)CheckBox7);
					num = ((int)num2 * -575088458) ^ -1942520824;
					continue;
				case 217u:
					RegisterDonor.smethod_36(NameLbl, bool_0: true);
					num = (int)(num2 * 428910547) ^ -482813928;
					continue;
				case 216u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox2), (Control)(object)BloodGrpLbl);
					num = ((int)num2 * -2086820608) ^ -214560452;
					continue;
				case 215u:
					RegisterDonor.smethod_22(MobileLbl, "Mobile :");
					num = (int)(num2 * 1756667049) ^ -2077765723;
					continue;
				case 214u:
					MobileLbl = RegisterDonor.smethod_5();
					GenderLbl = RegisterDonor.smethod_5();
					NameLbl = RegisterDonor.smethod_5();
					MobileTxt = RegisterDonor.smethod_9();
					num = ((int)num2 * -1994860502) ^ 0x4EAFCAF7;
					continue;
				case 213u:
					RegisterDonor.smethod_28((ButtonBase)(object)CheckBox8, "Typhoid");
					num = (int)(num2 * 1755062509) ^ -1240502691;
					continue;
				case 212u:
					num = ((int)num2 * -212323705) ^ -650504862;
					continue;
				case 211u:
					RegisterDonor.smethod_18((Control)(object)ClearBtn, new Point(547, 704));
					RegisterDonor.smethod_19((Control)(object)ClearBtn, "ClearBtn");
					num = ((int)num2 * -540948949) ^ -704523387;
					continue;
				case 210u:
					num = ((int)num2 * -1969083551) ^ -1678148579;
					continue;
				case 209u:
					RegisterDonor.smethod_33(GroupBox2, "Donor Information");
					num = ((int)num2 * -486147593) ^ -1915657312;
					continue;
				case 208u:
					num = (int)((num2 * 1356585880) ^ 0x2A25282);
					continue;
				case 207u:
					RegisterDonor.smethod_18((Control)(object)QuantityTxt, new Point(250, 324));
					RegisterDonor.smethod_19((Control)(object)QuantityTxt, "QuantityTxt");
					num = ((int)num2 * -307373177) ^ -221137144;
					continue;
				case 206u:
					num = ((int)num2 * -1063350283) ^ 0x895E945;
					continue;
				case 205u:
					RegisterDonor.smethod_20((Control)(object)GroupBox2, new Size(520, 444));
					num = (int)(num2 * 57586589) ^ -1892261145;
					continue;
				case 204u:
					num = (int)((num2 * 1512744513) ^ 0x3013D7F0);
					continue;
				case 203u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox2), (Control)(object)NameLbl);
					num = (int)((num2 * 87871797) ^ 0x517AB4F5);
					continue;
				case 202u:
					RegisterDonor.smethod_17((Control)(object)GenderTxt, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -573465349) ^ -124186850;
					continue;
				case 201u:
					RegisterDonor.smethod_21((Control)(object)GenderTxt, 14);
					num = ((int)num2 * -474197375) ^ 0x565795BE;
					continue;
				case 200u:
					num = (int)((num2 * 1653442928) ^ 0x1836B1B9);
					continue;
				case 199u:
					RegisterDonor.smethod_19((Control)(object)NameLbl, "NameLbl");
					num = ((int)num2 * -1484938950) ^ 0x608226D9;
					continue;
				case 198u:
					Label2 = RegisterDonor.smethod_5();
					num = ((int)num2 * -437169919) ^ -1145149823;
					continue;
				case 197u:
					RegisterDonor.smethod_20((Control)(object)BloodGrpLbl, new Size(127, 19));
					num = (int)(num2 * 1256017460) ^ -1845332171;
					continue;
				case 196u:
					num = (int)(num2 * 1241203402) ^ -884530646;
					continue;
				case 195u:
					num = (int)(num2 * 2027294495) ^ -122280931;
					continue;
				case 194u:
					num = ((int)num2 * -1414904223) ^ -1686829246;
					continue;
				case 193u:
					num = ((int)num2 * -2126769049) ^ 0x3355BBC5;
					continue;
				case 192u:
					num = ((int)num2 * -1868012018) ^ 0x55CF3CC7;
					continue;
				case 191u:
					RegisterDonor.smethod_36(GenderLbl, bool_0: true);
					num = ((int)num2 * -1302626161) ^ 0x5089245C;
					continue;
				case 190u:
					RegisterDonor.smethod_17((Control)(object)MobileTxt, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1188886068) ^ -721659469;
					continue;
				case 189u:
					RegisterDonor.smethod_34((ButtonBase)(object)CheckBox7, bool_0: true);
					num = ((int)num2 * -59274170) ^ 0x258E37C8;
					continue;
				case 188u:
					num = ((int)num2 * -107033505) ^ 0x4BD1AAFE;
					continue;
				case 186u:
					RegisterDonor.smethod_20((Control)(object)AgeLbl, new Size(54, 19));
					num = (int)((num2 * 798427609) ^ 0x1CA04F67);
					continue;
				case 185u:
					RegisterDonor.smethod_23(SuccessMsg, (ContentAlignment)32);
					num = ((int)num2 * -463812069) ^ 0x3D4DC427;
					continue;
				case 184u:
					num = ((int)num2 * -1073428467) ^ 0x6A8B207A;
					continue;
				case 183u:
					RegisterDonor.smethod_44(PictureBox1, bool_0: false);
					num = (int)(num2 * 1992536106) ^ -302060284;
					continue;
				case 182u:
					num = (int)(num2 * 1192853014) ^ -510763247;
					continue;
				case 181u:
					num = (int)(num2 * 1164953310) ^ -1098110686;
					continue;
				case 180u:
					RegisterDonor.smethod_15(Timer1, 1500);
					num = ((int)num2 * -1870513090) ^ 0x46B65EA5;
					continue;
				case 179u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox2), (Control)(object)BloodGrpTxt);
					num = (int)(num2 * 263140790) ^ -2022924843;
					continue;
				case 178u:
					num = ((int)num2 * -2090688601) ^ -1849618351;
					continue;
				case 177u:
					RegisterDonor.smethod_21((Control)(object)BloodGrpTxt, 20);
					num = ((int)num2 * -279403393) ^ 0x6107DBBE;
					continue;
				case 176u:
					num = ((int)num2 * -1097988209) ^ -449538624;
					continue;
				case 175u:
					RegisterDonor.smethod_27((Control)(object)Label4, Color.Red);
					num = ((int)num2 * -168774728) ^ 0x3ACD1786;
					continue;
				case 174u:
					RegisterDonor.smethod_20((Control)(object)Label3, new Size(212, 36));
					RegisterDonor.smethod_21((Control)(object)Label3, 23);
					num = (int)((num2 * 520168529) ^ 0x62DB51A0);
					continue;
				case 173u:
					num = (int)(num2 * 217605205) ^ -745020934;
					continue;
				case 172u:
					RegisterDonor.smethod_28((ButtonBase)(object)CheckBox4, "HTLV I");
					num = (int)((num2 * 1426640420) ^ 0x47B72BE9);
					continue;
				case 171u:
					RegisterDonor.smethod_20((Control)(object)SuccessMsg, new Size(401, 44));
					num = ((int)num2 * -748649096) ^ 0x13E4926;
					continue;
				case 170u:
					RegisterDonor.smethod_50((Control)(object)this, new Size(977, 804));
					num = (int)((num2 * 1087378478) ^ 0xA4A8243);
					continue;
				case 169u:
					RegisterDonor.smethod_29((ButtonBase)(object)AddBtn, bool_0: false);
					num = ((int)num2 * -2036631363) ^ 0x748787A7;
					continue;
				case 168u:
					num = (int)((num2 * 1051443481) ^ 0x38B1452A);
					continue;
				case 167u:
					RegisterDonor.smethod_19((Control)(object)CheckBox6, "CheckBox6");
					num = (int)((num2 * 1324409642) ^ 0x21C33B97);
					continue;
				case 166u:
					RegisterDonor.smethod_19((Control)(object)GenderLbl, "GenderLbl");
					num = (int)(num2 * 297646730) ^ -681777997;
					continue;
				case 165u:
					BloodGrpLbl = RegisterDonor.smethod_5();
					GenderTxt = RegisterDonor.smethod_10();
					num = (int)(num2 * 1367870114) ^ -822946589;
					continue;
				case 164u:
					RegisterDonor.smethod_29((ButtonBase)(object)CheckBox3, bool_0: true);
					num = ((int)num2 * -618329645) ^ -1969263869;
					continue;
				case 163u:
					num = (int)(num2 * 526454163) ^ -221856825;
					continue;
				case 162u:
					RegisterDonor.smethod_18((Control)(object)AgeTxt, new Point(127, 128));
					num = (int)(num2 * 875952681) ^ -985179720;
					continue;
				case 161u:
					RegisterDonor.smethod_52((Control)(object)GroupBox1);
					num = (int)((num2 * 170845271) ^ 0x51B6DA2B);
					continue;
				case 160u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox2), (Control)(object)Label7);
					num = ((int)num2 * -1595437297) ^ 0x6B4E0E05;
					continue;
				case 159u:
					num = ((int)num2 * -1622896866) ^ -1497944565;
					continue;
				case 158u:
					RegisterDonor.smethod_21((Control)(object)CheckBox8, 7);
					num = (int)((num2 * 1264637889) ^ 0x56D972F0);
					continue;
				case 157u:
					RegisterDonor.smethod_18((Control)(object)DateTxt, new Point(121, 374));
					num = (int)(num2 * 2031269834) ^ -768703613;
					continue;
				case 156u:
					RegisterDonor.smethod_28((ButtonBase)(object)CheckBox5, "HTLV II");
					num = ((int)num2 * -930262032) ^ 0x30B148ED;
					continue;
				case 155u:
					RegisterDonor.smethod_36(AgeLbl, bool_0: true);
					num = (int)((num2 * 1803489816) ^ 0x7EDB7322);
					continue;
				case 154u:
					num = ((int)num2 * -2008704965) ^ 0x1A8A188B;
					continue;
				case 153u:
					num = ((int)num2 * -1712715822) ^ 0x5CB04FEE;
					continue;
				case 152u:
					RegisterDonor.smethod_21((Control)(object)BloodGrpLbl, 19);
					RegisterDonor.smethod_22(BloodGrpLbl, "Blood Group :");
					num = ((int)num2 * -662469632) ^ 0x5C3C4E1A;
					continue;
				case 151u:
					RegisterDonor.smethod_17((Control)(object)GenderLbl, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -955107613) ^ -794128438;
					continue;
				case 150u:
					RegisterDonor.smethod_38((ListControl)(object)BloodGrpTxt, bool_0: true);
					num = (int)((num2 * 2030986540) ^ 0x52B160DD);
					continue;
				case 149u:
					num = (int)(num2 * 2130022859) ^ -1921393873;
					continue;
				case 148u:
					num = ((int)num2 * -1800926843) ^ -1064686055;
					continue;
				case 147u:
					RegisterDonor.smethod_21((Control)(object)CheckBox4, 3);
					num = (int)(num2 * 768882859) ^ -1050045607;
					continue;
				case 146u:
					RegisterDonor.smethod_22(SuccessMsg, "Name :");
					num = (int)((num2 * 786144353) ^ 0x30BCFBFC);
					continue;
				case 145u:
					num = (int)((num2 * 573670067) ^ 0x76BC165B);
					continue;
				case 144u:
					RegisterDonor.smethod_21((Control)(object)QuantityTxt, 23);
					num = ((int)num2 * -640373626) ^ 0xF444157;
					continue;
				case 143u:
					RegisterDonor.smethod_32(GroupBox1, bool_0: false);
					num = (int)(num2 * 406563033) ^ -755643569;
					continue;
				case 142u:
					RegisterDonor.smethod_42(PictureBox1, (PictureBoxSizeMode)1);
					num = (int)(num2 * 768578871) ^ -2129306900;
					continue;
				case 141u:
					num = (int)(num2 * 688985821) ^ -2067839148;
					continue;
				case 140u:
					num = (int)(num2 * 158926144) ^ -119179819;
					continue;
				case 139u:
					RegisterDonor.smethod_21((Control)(object)GroupBox2, 17);
					num = ((int)num2 * -1750848825) ^ 0x2DAFC048;
					continue;
				case 138u:
					RegisterDonor.smethod_17((Control)(object)SuccessMsg, RegisterDonor.smethod_16("MS Reference Sans Serif", 10.8f, (FontStyle)1));
					num = (int)(num2 * 1127501532) ^ -1740248010;
					continue;
				case 137u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox2), (Control)(object)AgeLbl);
					num = ((int)num2 * -146813978) ^ -1578922630;
					continue;
				case 136u:
					num = ((int)num2 * -1390162146) ^ 0x5D7B4BE0;
					continue;
				case 135u:
					RegisterDonor.smethod_28((ButtonBase)(object)CheckBox7, "Cholestrol");
					num = (int)((num2 * 815473084) ^ 0x1E310FBA);
					continue;
				case 134u:
					RegisterDonor.smethod_29((ButtonBase)(object)CheckBox8, bool_0: true);
					num = (int)((num2 * 1842908597) ^ 0x423FD326);
					continue;
				case 133u:
					RegisterDonor.smethod_21((Control)(object)SuccessMsg, 21);
					num = (int)(num2 * 1668802467) ^ -1264079600;
					continue;
				case 132u:
					RegisterDonor.smethod_20((Control)(object)AddBtn, new Size(148, 51));
					num = ((int)num2 * -1402247951) ^ 0x162F90B2;
					continue;
				case 131u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox1), (Control)(object)CheckBox2);
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox1), (Control)(object)CheckBox1);
					num = (int)(num2 * 1836641938) ^ -529897260;
					continue;
				case 130u:
					RegisterDonor.smethod_12((Control)(object)GroupBox1);
					num = ((int)num2 * -2023186318) ^ -1112777086;
					continue;
				case 129u:
					CheckBox7 = RegisterDonor.smethod_8();
					num = (int)((num2 * 1806676291) ^ 0x394CDF00);
					continue;
				case 128u:
					num = ((int)num2 * -139478439) ^ 0x50496301;
					continue;
				case 127u:
					RegisterDonor.smethod_22(Label7, "Amount Donated: ");
					num = (int)((num2 * 879959480) ^ 0x47C2B381);
					continue;
				case 126u:
					num = (int)(num2 * 1071131834) ^ -1687538346;
					continue;
				case 125u:
					num = ((int)num2 * -1305542634) ^ 0x1CB1666F;
					continue;
				case 124u:
					num = (int)(num2 * 62742148) ^ -714828231;
					continue;
				case 123u:
					num = (int)((num2 * 432511728) ^ 0x621A502B);
					continue;
				case 122u:
					num = ((int)num2 * -510910568) ^ 0x73E16612;
					continue;
				case 121u:
					RegisterDonor.smethod_20((Control)(object)Label4, new Size(84, 18));
					num = ((int)num2 * -275981485) ^ 0x2F99CD96;
					continue;
				case 120u:
					num = (int)(num2 * 1249410823) ^ -121677486;
					continue;
				case 119u:
					num = ((int)num2 * -234349934) ^ 0xE2CF0EF;
					continue;
				case 118u:
					num = ((int)num2 * -1697253078) ^ 0x216642AD;
					continue;
				case 117u:
					num = (int)(num2 * 1132452978) ^ -1531586984;
					continue;
				case 116u:
					RegisterDonor.smethod_47((Control)(object)this, Color.White);
					num = ((int)num2 * -1610878404) ^ -1068292859;
					continue;
				case 115u:
					num = ((int)num2 * -1971346547) ^ -1392017415;
					continue;
				case 114u:
					RegisterDonor.smethod_22(WarningLbl, "(18-55 years)");
					num = (int)(num2 * 1037347654) ^ -116206362;
					continue;
				case 113u:
					num = (int)((num2 * 1398923175) ^ 0x351AC5BA);
					continue;
				case 112u:
					RegisterDonor.smethod_18((Control)(object)NameTxt, new Point(127, 73));
					num = ((int)num2 * -1663884767) ^ -1772291294;
					continue;
				case 111u:
					RegisterDonor.smethod_23(MobileLbl, (ContentAlignment)32);
					num = ((int)num2 * -1992050074) ^ -37403972;
					continue;
				case 110u:
					num = ((int)num2 * -1416673772) ^ 0x34CF86BD;
					continue;
				case 109u:
					RegisterDonor.smethod_18((Control)(object)Label7, new Point(25, 327));
					num = ((int)num2 * -2056575822) ^ 0x6CFD269;
					continue;
				case 108u:
					RegisterDonor.smethod_36(Label1, bool_0: true);
					num = ((int)num2 * -2078394888) ^ 0x30376E3E;
					continue;
				case 107u:
					num = ((int)num2 * -926599581) ^ -1666261612;
					continue;
				case 106u:
					RegisterDonor.smethod_17((Control)(object)BloodGrpLbl, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					RegisterDonor.smethod_18((Control)(object)BloodGrpLbl, new Point(25, 280));
					num = (int)((num2 * 901130376) ^ 0x499546);
					continue;
				case 105u:
					RegisterDonor.smethod_17((Control)(object)NameLbl, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1924240300) ^ -1235008941;
					continue;
				case 104u:
					RegisterDonor.smethod_20((Control)(object)MobileTxt, new Size(232, 26));
					num = (int)((num2 * 1081176048) ^ 0x309D06A0);
					continue;
				case 103u:
					num = ((int)num2 * -1555021344) ^ 0x73B82307;
					continue;
				case 102u:
					RegisterDonor.smethod_18((Control)(object)AddBtn, new Point(760, 704));
					RegisterDonor.smethod_19((Control)(object)AddBtn, "AddBtn");
					num = (int)(num2 * 745691337) ^ -1760956057;
					continue;
				case 101u:
					RegisterDonor.smethod_19((Control)(object)CheckBox8, "CheckBox8");
					num = ((int)num2 * -2003470373) ^ 0x2876675E;
					continue;
				case 100u:
					RegisterDonor.smethod_29((ButtonBase)(object)ClearBtn, bool_0: false);
					num = ((int)num2 * -542026987) ^ -579088117;
					continue;
				case 99u:
					RegisterDonor.smethod_17((Control)(object)MobileLbl, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -353379951) ^ 0xE5E281A;
					continue;
				case 98u:
					RegisterDonor.smethod_28((ButtonBase)(object)AddBtn, "Add Donor");
					num = ((int)num2 * -826458781) ^ -869560291;
					continue;
				case 97u:
					RegisterDonor.smethod_20((Control)(object)CheckBox5, new Size(91, 23));
					num = (int)((num2 * 1988333338) ^ 0x6D290D75);
					continue;
				case 96u:
					RegisterDonor.smethod_36(Label7, bool_0: true);
					num = ((int)num2 * -1858810323) ^ -1682827906;
					continue;
				case 95u:
					BloodGrpTxt = RegisterDonor.smethod_10();
					num = ((int)num2 * -1079500171) ^ -197055549;
					continue;
				case 94u:
					RegisterDonor.smethod_38((ListControl)(object)GenderTxt, bool_0: true);
					RegisterDonor.smethod_40(RegisterDonor.smethod_39(GenderTxt), new object[3] { "MALE", "FEMALE", "OTHERS" });
					num = ((int)num2 * -1746843881) ^ -967167968;
					continue;
				case 93u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox1), (Control)(object)Label3);
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox1), (Control)(object)CheckBox8);
					num = (int)(num2 * 1357251752) ^ -1636127343;
					continue;
				case 92u:
					RegisterDonor.smethod_20((Control)(object)NameLbl, new Size(71, 19));
					RegisterDonor.smethod_21((Control)(object)NameLbl, 5);
					num = ((int)num2 * -2116947529) ^ -1686034615;
					continue;
				case 91u:
					RegisterDonor.smethod_19((Control)(object)CheckBox4, "CheckBox4");
					num = (int)(num2 * 1443102697) ^ -1763338538;
					continue;
				case 90u:
					RegisterDonor.smethod_36(BloodGrpLbl, bool_0: true);
					num = (int)((num2 * 708547994) ^ 0x634AE15);
					continue;
				case 89u:
					RegisterDonor.smethod_43(PictureBox1, 15);
					num = ((int)num2 * -697267505) ^ -677960385;
					continue;
				case 88u:
					num = (int)(num2 * 1320586913) ^ -1303715675;
					continue;
				case 87u:
					RegisterDonor.smethod_19((Control)(object)Label7, "Label7");
					RegisterDonor.smethod_20((Control)(object)Label7, new Size(164, 19));
					num = ((int)num2 * -1664416622) ^ 0x47648CB9;
					continue;
				case 86u:
					RegisterDonor.smethod_19((Control)(object)BloodGrpTxt, "BloodGrpTxt");
					num = (int)(num2 * 68004101) ^ -1655595564;
					continue;
				case 85u:
					RegisterDonor.smethod_22(Label4, "(In litres)");
					num = ((int)num2 * -838409468) ^ 0x747E68A3;
					continue;
				case 84u:
					RegisterDonor.smethod_19((Control)(object)AgeLbl, "AgeLbl");
					num = (int)((num2 * 928860808) ^ 0x59265903);
					continue;
				case 83u:
					RegisterDonor.smethod_19((Control)(object)AgeTxt, "AgeTxt");
					num = (int)(num2 * 117430423) ^ -1267517673;
					continue;
				case 82u:
					RegisterDonor.smethod_19((Control)(object)CheckBox1, "CheckBox1");
					num = (int)(num2 * 354822202) ^ -1571110330;
					continue;
				case 81u:
					num = (int)(num2 * 64094869) ^ -1372839485;
					continue;
				case 80u:
					RegisterDonor.smethod_18((Control)(object)GenderTxt, new Point(127, 226));
					num = ((int)num2 * -11243252) ^ -1978162632;
					continue;
				case 79u:
					num = (int)((num2 * 1053431930) ^ 0xD6D6F8B);
					continue;
				case 78u:
					RegisterDonor.smethod_18((Control)(object)WarningLbl, new Point(272, 133));
					num = (int)((num2 * 1169807772) ^ 0x6BCA45A9);
					continue;
				case 77u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox2), (Control)(object)NameTxt);
					num = (int)((num2 * 1050844985) ^ 0x11FB0B7);
					continue;
				case 76u:
					RegisterDonor.smethod_23(Label4, (ContentAlignment)32);
					num = ((int)num2 * -142252795) ^ 0x3821560F;
					continue;
				case 75u:
					RegisterDonor.smethod_17((Control)(object)Label3, RegisterDonor.smethod_26("Microsoft Sans Serif", 7.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					RegisterDonor.smethod_27((Control)(object)Label3, Color.Red);
					num = ((int)num2 * -1721301049) ^ -869791670;
					continue;
				case 74u:
					num = (int)((num2 * 1858708056) ^ 0x32199118);
					continue;
				case 73u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_48((Control)(object)this), (Control)(object)GroupBox1);
					num = (int)((num2 * 1957271882) ^ 0x45977969);
					continue;
				case 72u:
					RegisterDonor.smethod_27((Control)(object)AddBtn, Color.White);
					num = (int)(num2 * 273850113) ^ -1379221141;
					continue;
				case 71u:
					num = (int)(num2 * 790798731) ^ -340938453;
					continue;
				case 70u:
					RegisterDonor.smethod_54((Control)(object)this, bool_0: false);
					num = (int)(num2 * 1874251567) ^ -1846412954;
					continue;
				case 69u:
					RegisterDonor.smethod_21((Control)(object)Label1, 16);
					num = ((int)num2 * -603633142) ^ 0x1FAD3318;
					continue;
				case 68u:
					CheckBox6 = RegisterDonor.smethod_8();
					num = ((int)num2 * -956117579) ^ 0xC4EB5A1;
					continue;
				case 67u:
					RegisterDonor.smethod_17((Control)(object)AgeLbl, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1561400991) ^ 0x4AFC27DD;
					continue;
				case 66u:
					RegisterDonor.smethod_49((Control)(object)this, "RegisterDonor");
					num = (int)((num2 * 670308081) ^ 0x439965E2);
					continue;
				case 65u:
					AgeLbl = RegisterDonor.smethod_5();
					num = ((int)num2 * -1075668830) ^ 0x2B43CE96;
					continue;
				case 64u:
					RegisterDonor.smethod_18((Control)(object)CheckBox5, new Point(34, 284));
					num = (int)((num2 * 949845559) ^ 0x258568AC);
					continue;
				case 63u:
					RegisterDonor.smethod_17((Control)(object)CheckBox4, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -548379804) ^ 0x73FA9915;
					continue;
				case 62u:
					RegisterDonor.smethod_19((Control)(object)GroupBox1, "GroupBox1");
					RegisterDonor.smethod_20((Control)(object)GroupBox1, new Size(269, 480));
					num = ((int)num2 * -2065280809) ^ -995182505;
					continue;
				case 61u:
					num = (int)((num2 * 1476468885) ^ 0x17D86992);
					continue;
				case 60u:
					RegisterDonor.smethod_24((Control)(object)SuccessMsg, bool_0: false);
					num = (int)(num2 * 788589611) ^ -1697022286;
					continue;
				case 59u:
					RegisterDonor.smethod_17((Control)(object)Label4, RegisterDonor.smethod_26("MS Reference Sans Serif", 7.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1686865422) ^ 0x41F1BB08);
					continue;
				case 58u:
					RegisterDonor.smethod_19((Control)(object)SuccessMsg, "SuccessMsg");
					num = ((int)num2 * -1526432447) ^ -1732074601;
					continue;
				case 57u:
					RegisterDonor.smethod_22(Label3, "Diseases Not Present");
					num = (int)((num2 * 844837931) ^ 0x7F503E49);
					continue;
				case 56u:
					RegisterDonor.smethod_24((Control)(object)Label4, bool_0: false);
					num = ((int)num2 * -1115001320) ^ 0xEA9A934;
					continue;
				case 55u:
					num = (int)(num2 * 391697069) ^ -602288178;
					continue;
				case 54u:
					RegisterDonor.smethod_18((Control)(object)Label3, new Point(31, 36));
					num = (int)((num2 * 1537740575) ^ 0x6CB952E7);
					continue;
				case 53u:
					RegisterDonor.smethod_20((Control)(object)WarningLbl, new Size(107, 17));
					RegisterDonor.smethod_21((Control)(object)WarningLbl, 21);
					num = (int)((num2 * 689755896) ^ 0x7B5C4EC9);
					continue;
				case 52u:
					RegisterDonor.smethod_21((Control)(object)NameTxt, 0);
					num = (int)((num2 * 2088211730) ^ 0x194F8173);
					continue;
				case 51u:
					RegisterDonor.smethod_20((Control)(object)GenderLbl, new Size(83, 19));
					num = ((int)num2 * -486563414) ^ 0x19AD3753;
					continue;
				case 50u:
					RegisterDonor.smethod_28((ButtonBase)(object)ClearBtn, "Clear");
					num = ((int)num2 * -1905850585) ^ 0x4F14A51E;
					continue;
				case 49u:
					AddBtn = RegisterDonor.smethod_6();
					num = (int)(num2 * 1215295679) ^ -1044794864;
					continue;
				case 48u:
					RegisterDonor.smethod_34((ButtonBase)(object)CheckBox4, bool_0: true);
					num = ((int)num2 * -1602373795) ^ 0x7BC3DACC;
					continue;
				case 47u:
					RegisterDonor.smethod_34((ButtonBase)(object)CheckBox3, bool_0: true);
					num = ((int)num2 * -518319436) ^ 0x4CD64B46;
					continue;
				case 46u:
					RegisterDonor.smethod_32(GroupBox2, bool_0: false);
					num = (int)(num2 * 358876055) ^ -471513851;
					continue;
				case 45u:
					RegisterDonor.smethod_17((Control)(object)Label1, RegisterDonor.smethod_26("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 377779184) ^ -808173733;
					continue;
				case 44u:
					RegisterDonor.smethod_21((Control)(object)CheckBox5, 4);
					num = ((int)num2 * -1052174399) ^ -1541522968;
					continue;
				case 42u:
					num = (int)(num2 * 209979663) ^ -1245008504;
					continue;
				case 41u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox2), (Control)(object)MobileTxt);
					num = ((int)num2 * -142286615) ^ -1590791819;
					continue;
				case 40u:
					RegisterDonor.smethod_28((ButtonBase)(object)CheckBox6, "Syphilis");
					num = (int)(num2 * 1190648479) ^ -1310521610;
					continue;
				case 39u:
					RegisterDonor.smethod_19((Control)(object)MobileLbl, "MobileLbl");
					num = ((int)num2 * -910438022) ^ -642525567;
					continue;
				case 38u:
					num = (int)((num2 * 184473143) ^ 0x98C0834);
					continue;
				case 37u:
					components = RegisterDonor.smethod_3();
					num = (int)((num2 * 292705444) ^ 0x52535B87);
					continue;
				case 36u:
					RegisterDonor.smethod_21((Control)(object)GroupBox1, 18);
					num = ((int)num2 * -839245314) ^ -1108710206;
					continue;
				case 35u:
					num = ((int)num2 * -1699500540) ^ 0x790950D;
					continue;
				case 34u:
					RegisterDonor.smethod_18((Control)(object)CheckBox1, new Point(34, 86));
					num = ((int)num2 * -651373681) ^ 0x1F2A72C8;
					continue;
				case 33u:
					RegisterDonor.smethod_20((Control)(object)Label2, new Size(62, 19));
					num = (int)((num2 * 464579424) ^ 0x11F49A2A);
					continue;
				case 32u:
					num = ((int)num2 * -1461386122) ^ 0x4B3EDB4F;
					continue;
				case 31u:
					RegisterDonor.smethod_23(BloodGrpLbl, (ContentAlignment)32);
					num = ((int)num2 * -493245679) ^ 0x5F10E19E;
					continue;
				case 30u:
					RegisterDonor.smethod_36(Label2, bool_0: true);
					RegisterDonor.smethod_17((Control)(object)Label2, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					RegisterDonor.smethod_18((Control)(object)Label2, new Point(25, 377));
					num = ((int)num2 * -2023425481) ^ -650788539;
					continue;
				case 29u:
					num = (int)(num2 * 1734732543) ^ -1028122350;
					continue;
				case 28u:
					RegisterDonor.smethod_21((Control)(object)AgeLbl, 13);
					RegisterDonor.smethod_22(AgeLbl, "Age :");
					num = ((int)num2 * -2102143530) ^ -608447181;
					continue;
				case 27u:
					RegisterDonor.smethod_20((Control)(object)CheckBox2, new Size(128, 23));
					num = ((int)num2 * -440189287) ^ 0x1FC62052;
					continue;
				case 26u:
					num = ((int)num2 * -1406054783) ^ -448193052;
					continue;
				case 25u:
					RegisterDonor.smethod_33(GroupBox1, "Parameter Check");
					num = ((int)num2 * -1372468032) ^ 0x764891AE;
					continue;
				case 24u:
					num = (int)(num2 * 1416873304) ^ -260414821;
					continue;
				case 23u:
					num = ((int)num2 * -1711909985) ^ 0x302B0127;
					continue;
				case 22u:
					RegisterDonor.smethod_19((Control)(object)CheckBox2, "CheckBox2");
					num = ((int)num2 * -357542454) ^ -839629076;
					continue;
				case 21u:
					RegisterDonor.smethod_18((Control)(object)Label4, new Point(357, 328));
					RegisterDonor.smethod_19((Control)(object)Label4, "Label4");
					num = ((int)num2 * -1528203926) ^ 0x70AA653C;
					continue;
				case 20u:
					RegisterDonor.smethod_29((ButtonBase)(object)CheckBox6, bool_0: true);
					RegisterDonor.smethod_34((ButtonBase)(object)CheckBox5, bool_0: true);
					num = (int)(num2 * 1908970221) ^ -1488798418;
					continue;
				case 19u:
					RegisterDonor.smethod_17((Control)(object)ClearBtn, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 804220036) ^ -1748876782;
					continue;
				case 18u:
					num = ((int)num2 * -1990135074) ^ -1253589397;
					continue;
				case 17u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox2), (Control)(object)GenderTxt);
					num = ((int)num2 * -175609380) ^ -510507959;
					continue;
				case 16u:
					RegisterDonor.smethod_40(RegisterDonor.smethod_39(BloodGrpTxt), new object[9] { "--Select--", "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
					num = (int)((num2 * 1371858507) ^ 0x5073CC13);
					continue;
				case 15u:
					RegisterDonor.smethod_17((Control)(object)DateTxt, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -660020586) ^ 0x399FBD78;
					continue;
				case 14u:
					CheckBox1 = RegisterDonor.smethod_8();
					num = ((int)num2 * -265069889) ^ -1652067714;
					continue;
				case 13u:
					RegisterDonor.smethod_51((Control)(object)GroupBox2, bool_0: false);
					RegisterDonor.smethod_52((Control)(object)GroupBox2);
					num = ((int)num2 * -1785723932) ^ 0x1D74ED0D;
					continue;
				case 12u:
					CheckBox4 = RegisterDonor.smethod_8();
					num = (int)(num2 * 866881511) ^ -656626061;
					continue;
				case 11u:
					RegisterDonor.smethod_20((Control)(object)NameTxt, new Size(355, 26));
					num = (int)((num2 * 875175922) ^ 0x2886C3E1);
					continue;
				case 10u:
					RegisterDonor.smethod_17((Control)(object)NameTxt, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1436440890) ^ -1737825212;
					continue;
				case 9u:
					RegisterDonor.smethod_21((Control)(object)AgeTxt, 10);
					num = (int)(num2 * 1555134271) ^ -556720772;
					continue;
				case 8u:
					num = (int)(num2 * 1244927571) ^ -1886443261;
					continue;
				case 7u:
					RegisterDonor.smethod_29((ButtonBase)(object)CheckBox1, bool_0: true);
					num = ((int)num2 * -482672137) ^ -1772484232;
					continue;
				case 6u:
					num = ((int)num2 * -1168952124) ^ 0x62AB7862;
					continue;
				case 5u:
					num = ((int)num2 * -939192905) ^ 0x35F7F5EC;
					continue;
				case 4u:
					SuccessMsg = RegisterDonor.smethod_5();
					num = (int)(num2 * 246016803) ^ -1905001143;
					continue;
				case 3u:
					num = (int)(num2 * 339024667) ^ -1540792827;
					continue;
				case 2u:
					RegisterDonor.smethod_19((Control)(object)Label1, "Label1");
					num = ((int)num2 * -1197011605) ^ -813074948;
					continue;
				case 1u:
					RegisterDonor.smethod_18((Control)(object)SuccessMsg, new Point(117, 174));
					num = ((int)num2 * -2072813831) ^ 0xCE44C02;
					continue;
				case 0u:
					RegisterDonor.smethod_20((Control)(object)MobileLbl, new Size(76, 19));
					num = ((int)num2 * -2101980281) ^ -194113823;
					continue;
				case 43u:
					break;
				default:
					RegisterDonor.smethod_55((Control)(object)this);
					return;
				}
				break;
			}
		}
	}

	private void RegisterDonor_Load(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -602318086;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x856C9AE4u) % 5u)
				{
				case 3u:
					RegisterDonor.smethod_63(myconnection, RegisterDonor.smethod_62(MyProject.Forms.Form1.provider, MyProject.Forms.Form1.datafile));
					num = ((int)num2 * -1868841084) ^ -1407689283;
					continue;
				case 2u:
					RegisterDonor.smethod_65(DateTxt, DateTime.Today.ToShortDateString());
					num = ((int)num2 * -1780481742) ^ -39663626;
					continue;
				case 1u:
					RegisterDonor.smethod_64(BloodGrpTxt, 0);
					RegisterDonor.smethod_64(GenderTxt, -1);
					num = (int)((num2 * 1126241831) ^ 0x4AA8DC4D);
					continue;
				default:
					return;
				case 0u:
					break;
				case 4u:
					return;
				}
				break;
			}
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Expected I4, but got Unknown
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Expected I4, but got Unknown
		//IL_041a: Incompatible stack heights: 0 vs 1
		//IL_0435: Incompatible stack heights: 0 vs 1
		//IL_044d: Incompatible stack heights: 0 vs 1
		//IL_0470: Incompatible stack heights: 0 vs 1
		//IL_0483: Incompatible stack heights: 0 vs 1
		//IL_0496: Incompatible stack heights: 0 vs 1
		//IL_04a9: Incompatible stack heights: 0 vs 1
		//IL_04c8: Incompatible stack heights: 0 vs 1
		//IL_04d2: Incompatible stack heights: 0 vs 1
		bool flag = default(bool);
		string string_ = default(string);
		OleDbCommand val = default(OleDbCommand);
		while (true)
		{
			int num = 727396603;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7AFE8F9Bu) % 7u)
				{
				case 4u:
					flag = !Validate_data();
					num = ((int)num2 * -703448969) ^ -969918209;
					continue;
				case 3u:
					string_ = "Insert Into [Donor] (Name,Gender,Age,Blood,Mobile,[Blood Amount],[Donation Date]) Values (?,?,?,?,?,?,?)";
					num = ((int)num2 * -1165567385) ^ 0x29F10E44;
					continue;
				case 2u:
					num = 52772599;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1667615292;
						num5 = 1667615292;
					}
					else
					{
						num4 = 729869339;
						num5 = 729869339;
					}
					num = num4 ^ (int)(num2 * 1464037590);
					continue;
				}
				case 0u:
					break;
				default:
					RegisterDonor.smethod_66(myconnection);
					try
					{
						while (true)
						{
							int num3 = 1852576348;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x7AFE8F9Bu) % 19u)
								{
								case 18u:
									RegisterDonor.smethod_78(myconnection);
									num3 = ((int)num2 * -1882893941) ^ 0x56B1F4FC;
									continue;
								case 17u:
									num3 = ((int)num2 * -1199094597) ^ 0x43C359A5;
									continue;
								case 16u:
									RegisterDonor.smethod_76(val);
									num3 = ((int)num2 * -1098068903) ^ -624498497;
									continue;
								case 15u:
									RegisterDonor.smethod_72(RegisterDonor.smethod_68(val), RegisterDonor.smethod_71("Blood", (object)RegisterDonor.smethod_73(BloodGrpTxt)));
									num3 = (int)((num2 * 327215519) ^ 0x2721B266);
									continue;
								case 14u:
									RegisterDonor.smethod_79(Timer1);
									num3 = ((int)num2 * -188186074) ^ -1603121073;
									continue;
								case 13u:
									num3 = (int)((num2 * 1853058642) ^ 0xA02202F);
									continue;
								case 12u:
									val = RegisterDonor.smethod_67(string_, myconnection);
									num3 = (int)((num2 * 442406352) ^ 0x6840B092);
									continue;
								case 11u:
									RegisterDonor.smethod_72(RegisterDonor.smethod_68(val), RegisterDonor.smethod_71("Blood Amount", (object)RegisterDonor.smethod_69(QuantityTxt)));
									num3 = ((int)num2 * -389550777) ^ 0x617B4A4C;
									continue;
								case 9u:
									RegisterDonor.smethod_24((Control)(object)SuccessMsg, bool_0: true);
									num3 = ((int)num2 * -806295760) ^ -330175886;
									continue;
								case 8u:
									RegisterDonor.smethod_77((Component)(object)val);
									num3 = ((int)num2 * -78042622) ^ 0x3AC6A445;
									continue;
								case 7u:
									RegisterDonor.smethod_72(RegisterDonor.smethod_68(val), RegisterDonor.smethod_71("Mobile", (object)RegisterDonor.smethod_75(RegisterDonor.smethod_69(MobileTxt))));
									num3 = (int)(num2 * 1768104610) ^ -2070839192;
									continue;
								case 5u:
									RegisterDonor.smethod_72(RegisterDonor.smethod_68(val), RegisterDonor.smethod_71("Donation Date", (object)RegisterDonor.smethod_75(RegisterDonor.smethod_69(DateTxt))));
									num3 = ((int)num2 * -142700048) ^ 0x7C4EC54E;
									continue;
								case 4u:
									num3 = ((int)num2 * -1188327108) ^ -1108380672;
									continue;
								case 3u:
									RegisterDonor.smethod_72(RegisterDonor.smethod_68(val), RegisterDonor.smethod_71("Name", (object)RegisterDonor.smethod_70(RegisterDonor.smethod_69(NameTxt))));
									RegisterDonor.smethod_72(RegisterDonor.smethod_68(val), RegisterDonor.smethod_71("Gender", (object)RegisterDonor.smethod_70(RegisterDonor.smethod_73(GenderTxt))));
									num3 = ((int)num2 * -325492953) ^ -2031749045;
									continue;
								case 2u:
									RegisterDonor.smethod_72(RegisterDonor.smethod_68(val), RegisterDonor.smethod_71("Age", (object)(int)RegisterDonor.smethod_74(RegisterDonor.smethod_69(AgeTxt))));
									num3 = (int)((num2 * 989854981) ^ 0x7D069B0B);
									continue;
								case 1u:
									RegisterDonor.smethod_22(SuccessMsg, "Donor Successfully Registered !!");
									RegisterDonor.smethod_47((Control)(object)SuccessMsg, Color.Green);
									num3 = (int)(num2 * 700023860) ^ -1167676887;
									continue;
								case 0u:
									num3 = ((int)num2 * -1500288155) ^ -1313645793;
									continue;
								default:
									return;
								case 6u:
									break;
								case 10u:
									return;
								}
								break;
							}
						}
					}
					catch (Exception exception_)
					{
						RegisterDonor.smethod_80(exception_);
						while (true)
						{
							_ = 1574419956;
							while (true)
							{
								_003F val2 = /*Error near IL_03b9: Stack underflow*/^ 0x7AFE8F9B;
								num2 = (uint)(int)val2;
								switch (val2 % 10)
								{
								default:
									return;
								case 9:
									RegisterDonor.smethod_47((Control)(object)SuccessMsg, Color.Red);
									RegisterDonor.smethod_79(Timer1);
									_ = (num2 * 416146724) ^ 0xB537CC9Fu;
									continue;
								case 7:
									RegisterDonor.smethod_78(myconnection);
									_ = (num2 * 422684444) ^ 0xC938F2F3u;
									continue;
								case 6:
									RegisterDonor.smethod_81();
									_ = ((int)num2 * -1444046848) ^ 0x7307B969;
									continue;
								case 5:
									RegisterDonor.smethod_22(SuccessMsg, "Invalid Credentials");
									_ = (num2 * 387298189) ^ 0xDF655212u;
									continue;
								case 3:
									_ = ((int)num2 * -1121461458) ^ -1027135388;
									continue;
								case 2:
									_ = ((int)num2 * -1760496903) ^ 0x2C7BDAE8;
									continue;
								case 1:
									_ = ((int)num2 * -55266061) ^ -1519939049;
									continue;
								case 0:
									RegisterDonor.smethod_24((Control)(object)SuccessMsg, bool_0: true);
									_ = (num2 * 1467250332) ^ 0x892810B6u;
									continue;
								case 4:
									break;
								case 8:
									return;
								}
								break;
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

	private bool Validate_data()
	{
		bool flag = !MyProject.Forms.Form1.Name_Validation(RegisterDonor.smethod_70(RegisterDonor.smethod_69(NameTxt)));
		bool flag5 = default(bool);
		bool result = default(bool);
		bool flag6 = default(bool);
		bool flag4 = default(bool);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 514648480;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x588D15E1u) % 69u)
				{
				case 68u:
					RegisterDonor.smethod_24((Control)(object)SuccessMsg, bool_0: true);
					num = ((int)num2 * -861277844) ^ -301179827;
					continue;
				case 67u:
				{
					int num16;
					int num17;
					if (flag5)
					{
						num16 = 683747913;
						num17 = 683747913;
					}
					else
					{
						num16 = 807055623;
						num17 = 807055623;
					}
					num = num16 ^ (int)(num2 * 2091452075);
					continue;
				}
				case 66u:
					RegisterDonor.smethod_47((Control)(object)SuccessMsg, Color.Red);
					RegisterDonor.smethod_79(Timer1);
					result = false;
					num = ((int)num2 * -2070798297) ^ -1413938628;
					continue;
				case 65u:
					num = 1984287869;
					continue;
				case 64u:
				{
					int num14;
					int num15;
					if (!flag6)
					{
						num14 = -422226486;
						num15 = -422226486;
					}
					else
					{
						num14 = -198458724;
						num15 = -198458724;
					}
					num = num14 ^ (int)(num2 * 2090897577);
					continue;
				}
				case 63u:
					RegisterDonor.smethod_47((Control)(object)SuccessMsg, Color.Red);
					num = (int)(num2 * 103313327) ^ -1030486996;
					continue;
				case 62u:
					num = ((int)num2 * -926811310) ^ 0x5952922F;
					continue;
				case 61u:
					num = (int)((num2 * 504483527) ^ 0x2CEEECB7);
					continue;
				case 60u:
					num = 1144290001;
					continue;
				case 59u:
					RegisterDonor.smethod_79(Timer1);
					num = (int)(num2 * 737635979) ^ -505992153;
					continue;
				case 58u:
				{
					int num7;
					int num8;
					if (!flag4)
					{
						num7 = 1102428920;
						num8 = 1102428920;
					}
					else
					{
						num7 = 48095657;
						num8 = 48095657;
					}
					num = num7 ^ ((int)num2 * -1025563195);
					continue;
				}
				case 57u:
					flag3 = !MyProject.Forms.Form1.Mobile_Validator(RegisterDonor.smethod_69(MobileTxt));
					num = ((int)num2 * -946980180) ^ -1147903948;
					continue;
				case 56u:
					RegisterDonor.smethod_24((Control)(object)SuccessMsg, bool_0: true);
					num = (int)((num2 * 2125475658) ^ 0x333237C9);
					continue;
				case 55u:
					num = ((int)num2 * -1848409822) ^ -1609648056;
					continue;
				case 54u:
					num = ((int)num2 * -344006825) ^ 0x556ED16A;
					continue;
				case 53u:
					RegisterDonor.smethod_24((Control)(object)SuccessMsg, bool_0: true);
					RegisterDonor.smethod_22(SuccessMsg, "Invalid Mobile Number");
					num = (int)((num2 * 1015484099) ^ 0x64137367);
					continue;
				case 52u:
					RegisterDonor.smethod_79(Timer1);
					num = (int)(num2 * 1788759564) ^ -352358286;
					continue;
				case 51u:
					num = 165915249;
					continue;
				case 50u:
					RegisterDonor.smethod_79(Timer1);
					num = ((int)num2 * -961758701) ^ 0x4681FA0F;
					continue;
				case 49u:
					num = ((int)num2 * -421978642) ^ 0x635893A;
					continue;
				case 48u:
					num = ((int)num2 * -1302954680) ^ -1812031120;
					continue;
				case 47u:
					result = false;
					num = ((int)num2 * -929194206) ^ 0x6268D417;
					continue;
				case 46u:
					num = ((int)num2 * -1162827296) ^ 0x18B8F283;
					continue;
				case 45u:
					RegisterDonor.smethod_24((Control)(object)SuccessMsg, bool_0: true);
					num = (int)(num2 * 198788364) ^ -627618956;
					continue;
				case 44u:
					num = ((int)num2 * -1417677734) ^ 0x3E589B95;
					continue;
				case 43u:
					result = false;
					num = (int)((num2 * 1942893739) ^ 0x3E897349);
					continue;
				case 42u:
				{
					int num12;
					int num13;
					if (!MyProject.Forms.Form1.Decimal_Validator(RegisterDonor.smethod_69(QuantityTxt)))
					{
						num12 = -860262393;
						num13 = -860262393;
					}
					else
					{
						num12 = -620585815;
						num13 = -620585815;
					}
					num = num12 ^ ((int)num2 * -444055113);
					continue;
				}
				case 41u:
					RegisterDonor.smethod_22(SuccessMsg, "Invalid Name");
					RegisterDonor.smethod_47((Control)(object)SuccessMsg, Color.Red);
					num = ((int)num2 * -744538273) ^ 0x7F41B86E;
					continue;
				case 40u:
					num = (int)((num2 * 1187617932) ^ 0x17AC1972);
					continue;
				case 39u:
					result = false;
					num = (int)((num2 * 935952109) ^ 0x4F0B118B);
					continue;
				case 38u:
					num = 1521420669;
					continue;
				case 37u:
					RegisterDonor.smethod_47((Control)(object)SuccessMsg, Color.Red);
					num = ((int)num2 * -1006581464) ^ 0x4266A99F;
					continue;
				case 35u:
					num = 1702155713;
					continue;
				case 34u:
				{
					int num10;
					int num11;
					if (!flag3)
					{
						num10 = -1992493850;
						num11 = -1992493850;
					}
					else
					{
						num10 = -1464716145;
						num11 = -1464716145;
					}
					num = num10 ^ (int)(num2 * 1078162773);
					continue;
				}
				case 33u:
					RegisterDonor.smethod_22(SuccessMsg, "Select Proper Blood Group");
					num = ((int)num2 * -1717284123) ^ 0x7AAF80BA;
					continue;
				case 32u:
					flag6 = !MyProject.Forms.Form1.age_validator(RegisterDonor.smethod_69(AgeTxt));
					num = 1976641800;
					continue;
				case 31u:
					num = ((int)num2 * -1230883142) ^ 0xF170C93;
					continue;
				case 30u:
					result = false;
					num = ((int)num2 * -145692424) ^ 0x320B2B84;
					continue;
				case 29u:
					RegisterDonor.smethod_22(SuccessMsg, "Invalid Age");
					num = ((int)num2 * -729245711) ^ 0x238D0AAF;
					continue;
				case 28u:
					result = true;
					num = ((int)num2 * -1222829820) ^ -1438121877;
					continue;
				case 27u:
					num = ((int)num2 * -295503747) ^ 0x509C6493;
					continue;
				case 26u:
					result = false;
					num = (int)(num2 * 1135525660) ^ -951252651;
					continue;
				case 25u:
					flag5 = !RegisterDonor.smethod_83(CheckBox1) | !RegisterDonor.smethod_83(CheckBox2) | !RegisterDonor.smethod_83(CheckBox3) | !RegisterDonor.smethod_83(CheckBox4) | !RegisterDonor.smethod_83(CheckBox5) | !RegisterDonor.smethod_83(CheckBox6) | !RegisterDonor.smethod_83(CheckBox7) | !RegisterDonor.smethod_83(CheckBox8);
					num = ((int)num2 * -14450386) ^ -1628874131;
					continue;
				case 24u:
					RegisterDonor.smethod_24((Control)(object)SuccessMsg, bool_0: true);
					RegisterDonor.smethod_22(SuccessMsg, "Invalid Gender");
					num = ((int)num2 * -1992549666) ^ 0x74A53572;
					continue;
				case 23u:
					RegisterDonor.smethod_24((Control)(object)SuccessMsg, bool_0: true);
					num = (int)(num2 * 627060147) ^ -1476426991;
					continue;
				case 22u:
					result = false;
					num = (int)(num2 * 149226067) ^ -1359736096;
					continue;
				case 21u:
					RegisterDonor.smethod_22(SuccessMsg, "Donor Not Eligible");
					RegisterDonor.smethod_47((Control)(object)SuccessMsg, Color.Red);
					num = ((int)num2 * -654543127) ^ 0xB0F8AC2;
					continue;
				case 20u:
					flag4 = !MyProject.Forms.Form1.Gender_Validator(RegisterDonor.smethod_70(RegisterDonor.smethod_73(GenderTxt)));
					num = 1353531529;
					continue;
				case 19u:
				{
					int num9;
					if (!(int.TryParse(RegisterDonor.smethod_69(AgeTxt), out var result2) && (result2 < 18 || result2 > 55)))
					{
						num = 1815413838;
						num9 = 1815413838;
					}
					else
					{
						num = 875627508;
						num9 = 875627508;
					}
					continue;
				}
				case 18u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = -1015383774;
						num6 = -1015383774;
					}
					else
					{
						num5 = -1161609246;
						num6 = -1161609246;
					}
					num = num5 ^ ((int)num2 * -206371059);
					continue;
				}
				case 17u:
					num = (int)((num2 * 477930147) ^ 0x3140DADC);
					continue;
				case 16u:
					num = (int)(num2 * 738726469) ^ -1992171557;
					continue;
				case 15u:
					result = false;
					num = (int)(num2 * 642474617) ^ -529150634;
					continue;
				case 14u:
					RegisterDonor.smethod_24((Control)(object)SuccessMsg, bool_0: true);
					RegisterDonor.smethod_22(SuccessMsg, "Invalid Quantity");
					RegisterDonor.smethod_47((Control)(object)SuccessMsg, Color.Red);
					num = (int)((num2 * 794071762) ^ 0x3BDFA8ED);
					continue;
				case 13u:
					num = ((int)num2 * -671554546) ^ 0x27E59994;
					continue;
				case 11u:
				{
					int num3;
					int num4;
					if (!flag2)
					{
						num3 = -152995006;
						num4 = -152995006;
					}
					else
					{
						num3 = -1515821197;
						num4 = -1515821197;
					}
					num = num3 ^ ((int)num2 * -1742239451);
					continue;
				}
				case 10u:
					num = (int)((num2 * 1146852725) ^ 0x3BE2038A);
					continue;
				case 9u:
					RegisterDonor.smethod_79(Timer1);
					num = (int)((num2 * 1649129997) ^ 0x244D8864);
					continue;
				case 8u:
					RegisterDonor.smethod_79(Timer1);
					num = ((int)num2 * -418090322) ^ -970383886;
					continue;
				case 7u:
					flag2 = RegisterDonor.smethod_82(BloodGrpTxt) == 0;
					num = ((int)num2 * -162713404) ^ 0x18543BDA;
					continue;
				case 6u:
					RegisterDonor.smethod_79(Timer1);
					num = (int)((num2 * 469135932) ^ 0x10862BF9);
					continue;
				case 5u:
					RegisterDonor.smethod_47((Control)(object)SuccessMsg, Color.Red);
					num = ((int)num2 * -1651856549) ^ 0x6AA07AD8;
					continue;
				case 4u:
					RegisterDonor.smethod_47((Control)(object)SuccessMsg, Color.Red);
					num = (int)(num2 * 1779271836) ^ -278725629;
					continue;
				case 3u:
					RegisterDonor.smethod_24((Control)(object)SuccessMsg, bool_0: true);
					num = ((int)num2 * -719415343) ^ -1250869710;
					continue;
				case 2u:
					RegisterDonor.smethod_22(SuccessMsg, "Donor Not Eligible.");
					num = (int)(num2 * 1084982312) ^ -930766539;
					continue;
				case 1u:
					RegisterDonor.smethod_79(Timer1);
					num = ((int)num2 * -525021407) ^ -362700887;
					continue;
				case 0u:
					num = (int)(num2 * 807124388) ^ -1550292339;
					continue;
				case 36u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	private void ClearBtn_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -1113807749;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE518112Bu) % 15u)
				{
				case 14u:
					RegisterDonor.smethod_85(CheckBox7, bool_0: false);
					num = ((int)num2 * -1096711664) ^ -1763494282;
					continue;
				case 13u:
					RegisterDonor.smethod_64(BloodGrpTxt, 0);
					RegisterDonor.smethod_85(CheckBox1, bool_0: false);
					RegisterDonor.smethod_85(CheckBox2, bool_0: false);
					RegisterDonor.smethod_85(CheckBox3, bool_0: false);
					num = (int)(num2 * 1939294785) ^ -1008153685;
					continue;
				case 12u:
					RegisterDonor.smethod_85(CheckBox4, bool_0: false);
					num = ((int)num2 * -750650440) ^ 0x5E72EE18;
					continue;
				case 11u:
					RegisterDonor.smethod_84((TextBoxBase)(object)MobileTxt);
					num = (int)((num2 * 1671032589) ^ 0x45D46D10);
					continue;
				case 10u:
					RegisterDonor.smethod_64(GenderTxt, -1);
					num = (int)((num2 * 1194060701) ^ 0x23345695);
					continue;
				case 9u:
					num = (int)(num2 * 277570027) ^ -1001379959;
					continue;
				case 8u:
					RegisterDonor.smethod_85(CheckBox8, bool_0: false);
					num = ((int)num2 * -256869124) ^ -1445292232;
					continue;
				case 7u:
					num = (int)(num2 * 67388614) ^ -1610880102;
					continue;
				case 5u:
					num = (int)(num2 * 1336715098) ^ -1311823550;
					continue;
				case 4u:
					RegisterDonor.smethod_84((TextBoxBase)(object)AgeTxt);
					num = (int)((num2 * 63491993) ^ 0x2F277E70);
					continue;
				case 3u:
					num = ((int)num2 * -1790421397) ^ 0x7E55D521;
					continue;
				case 1u:
					RegisterDonor.smethod_84((TextBoxBase)(object)NameTxt);
					num = ((int)num2 * -1939276398) ^ -715722980;
					continue;
				case 0u:
					RegisterDonor.smethod_85(CheckBox5, bool_0: false);
					RegisterDonor.smethod_85(CheckBox6, bool_0: false);
					num = (int)((num2 * 1720373626) ^ 0xC5D2DC8);
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

	private void Timer1_Tick(object sender, EventArgs e)
	{
		RegisterDonor.smethod_24((Control)(object)SuccessMsg, bool_0: false);
		while (true)
		{
			int num = 2108737419;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2423BBC9u) % 4u)
				{
				case 3u:
					num = ((int)num2 * -1559547301) ^ 0x26FE1475;
					continue;
				case 2u:
					RegisterDonor.smethod_86(Timer1);
					num = (int)((num2 * 1867988682) ^ 0x1B03EDA);
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

	private void GenderTxt_SelectionChangeCommitted(object sender, EventArgs e)
	{
		RegisterDonor.smethod_87((Control)(object)BloodGrpTxt);
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

	static Container smethod_3()
	{
		return new Container();
	}

	static Timer smethod_4(IContainer icontainer_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new Timer(icontainer_0);
	}

	static Label smethod_5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Label();
	}

	static Button smethod_6()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Button();
	}

	static GroupBox smethod_7()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new GroupBox();
	}

	static CheckBox smethod_8()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new CheckBox();
	}

	static TextBox smethod_9()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new TextBox();
	}

	static ComboBox smethod_10()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new ComboBox();
	}

	static PictureBox smethod_11()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new PictureBox();
	}

	static void smethod_12(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_13(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.BeginInit();
	}

	static void smethod_14(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_15(Timer timer_0, int int_0)
	{
		timer_0.set_Interval(int_0);
	}

	static Font smethod_16(string string_0, float float_0, FontStyle fontStyle_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0);
	}

	static void smethod_17(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static void smethod_18(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_19(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_20(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_21(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static void smethod_22(Label label_0, string string_0)
	{
		label_0.set_Text(string_0);
	}

	static void smethod_23(Label label_0, ContentAlignment contentAlignment_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		label_0.set_TextAlign(contentAlignment_0);
	}

	static void smethod_24(Control control_0, bool bool_0)
	{
		control_0.set_Visible(bool_0);
	}

	static void smethod_25(ButtonBase buttonBase_0, Color color_0)
	{
		buttonBase_0.set_BackColor(color_0);
	}

	static Font smethod_26(string string_0, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0, graphicsUnit_0, byte_0);
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

	static void smethod_34(ButtonBase buttonBase_0, bool bool_0)
	{
		buttonBase_0.set_AutoSize(bool_0);
	}

	static void smethod_35(TextBoxBase textBoxBase_0, bool bool_0)
	{
		textBoxBase_0.set_ReadOnly(bool_0);
	}

	static void smethod_36(Label label_0, bool bool_0)
	{
		label_0.set_AutoSize(bool_0);
	}

	static void smethod_37(ComboBox comboBox_0, ComboBoxStyle comboBoxStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		comboBox_0.set_DropDownStyle(comboBoxStyle_0);
	}

	static void smethod_38(ListControl listControl_0, bool bool_0)
	{
		listControl_0.set_FormattingEnabled(bool_0);
	}

	static ObjectCollection smethod_39(ComboBox comboBox_0)
	{
		return comboBox_0.get_Items();
	}

	static void smethod_40(ObjectCollection objectCollection_0, object[] object_0)
	{
		objectCollection_0.AddRange(object_0);
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

	static void smethod_51(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_52(Control control_0)
	{
		control_0.PerformLayout();
	}

	static void smethod_53(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.EndInit();
	}

	static void smethod_54(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_55(Control control_0)
	{
		control_0.PerformLayout();
	}

	static void smethod_56(Timer timer_0, EventHandler eventHandler_0)
	{
		timer_0.remove_Tick(eventHandler_0);
	}

	static void smethod_57(Timer timer_0, EventHandler eventHandler_0)
	{
		timer_0.add_Tick(eventHandler_0);
	}

	static void smethod_58(Control control_0, EventHandler eventHandler_0)
	{
		control_0.remove_Click(eventHandler_0);
	}

	static void smethod_59(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_Click(eventHandler_0);
	}

	static void smethod_60(ComboBox comboBox_0, EventHandler eventHandler_0)
	{
		comboBox_0.remove_SelectionChangeCommitted(eventHandler_0);
	}

	static void smethod_61(ComboBox comboBox_0, EventHandler eventHandler_0)
	{
		comboBox_0.add_SelectionChangeCommitted(eventHandler_0);
	}

	static string smethod_62(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static void smethod_63(OleDbConnection oleDbConnection_0, string string_0)
	{
		oleDbConnection_0.set_ConnectionString(string_0);
	}

	static void smethod_64(ComboBox comboBox_0, int int_0)
	{
		comboBox_0.set_SelectedIndex(int_0);
	}

	static void smethod_65(TextBox textBox_0, string string_0)
	{
		textBox_0.set_Text(string_0);
	}

	static void smethod_66(OleDbConnection oleDbConnection_0)
	{
		oleDbConnection_0.Open();
	}

	static OleDbCommand smethod_67(string string_0, OleDbConnection oleDbConnection_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new OleDbCommand(string_0, oleDbConnection_0);
	}

	static OleDbParameterCollection smethod_68(OleDbCommand oleDbCommand_0)
	{
		return oleDbCommand_0.get_Parameters();
	}

	static string smethod_69(TextBox textBox_0)
	{
		return textBox_0.get_Text();
	}

	static string smethod_70(string string_0)
	{
		return string_0.ToLower();
	}

	static OleDbParameter smethod_71(string string_0, object object_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new OleDbParameter(string_0, object_0);
	}

	static OleDbParameter smethod_72(OleDbParameterCollection oleDbParameterCollection_0, OleDbParameter oleDbParameter_0)
	{
		return oleDbParameterCollection_0.Add(oleDbParameter_0);
	}

	static string smethod_73(ComboBox comboBox_0)
	{
		return comboBox_0.get_Text();
	}

	static short smethod_74(string string_0)
	{
		return Convert.ToInt16(string_0);
	}

	static string smethod_75(string string_0)
	{
		return string_0.ToString();
	}

	static int smethod_76(OleDbCommand oleDbCommand_0)
	{
		return oleDbCommand_0.ExecuteNonQuery();
	}

	static void smethod_77(Component component_0)
	{
		component_0.Dispose();
	}

	static void smethod_78(OleDbConnection oleDbConnection_0)
	{
		oleDbConnection_0.Close();
	}

	static void smethod_79(Timer timer_0)
	{
		timer_0.Start();
	}

	static void smethod_80(Exception exception_0)
	{
		ProjectData.SetProjectError(exception_0);
	}

	static void smethod_81()
	{
		ProjectData.ClearProjectError();
	}

	static int smethod_82(ComboBox comboBox_0)
	{
		return comboBox_0.get_SelectedIndex();
	}

	static bool smethod_83(CheckBox checkBox_0)
	{
		return checkBox_0.get_Checked();
	}

	static void smethod_84(TextBoxBase textBoxBase_0)
	{
		textBoxBase_0.Clear();
	}

	static void smethod_85(CheckBox checkBox_0, bool bool_0)
	{
		checkBox_0.set_Checked(bool_0);
	}

	static void smethod_86(Timer timer_0)
	{
		timer_0.Stop();
	}

	static bool smethod_87(Control control_0)
	{
		return control_0.Focus();
	}
}
