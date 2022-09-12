using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
public class GForm2 : Form
{
	private IContainer icontainer_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PictureBox1")]
	private PictureBox pictureBox_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("MemoryCleaner")]
	private Timer timer_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PictureBox2")]
	private PictureBox pictureBox_1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PictureBox3")]
	private PictureBox pictureBox_2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PictureBox4")]
	private PictureBox pictureBox_3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PictureBox5")]
	private PictureBox pictureBox_4;

	private int int_0;

	private bool bool_0;

	internal virtual PictureBox PictureBox_0
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			pictureBox_0 = value;
		}
	}

	internal virtual Timer Timer_0
	{
		[CompilerGenerated]
		get
		{
			return timer_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = method_2;
			Timer val = timer_0;
			if (val != null)
			{
				goto IL_0082;
			}
			goto IL_00b4;
			IL_00b4:
			timer_0 = value;
			int num = 1818050101;
			goto IL_0087;
			IL_0087:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x60BFF1D7u) % 7u)
				{
				case 6u:
					val = timer_0;
					num = ((int)num2 * -1320669656) ^ 0x543C0D1C;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (val != null)
					{
						num3 = -2068224611;
						num4 = -2068224611;
					}
					else
					{
						num3 = -48307735;
						num4 = -48307735;
					}
					num = num3 ^ ((int)num2 * -2110520187);
					continue;
				}
				case 4u:
					GForm2.smethod_37(val, eventHandler_);
					num = (int)((num2 * 1582076613) ^ 0x984BBF6);
					continue;
				case 3u:
					GForm2.smethod_38(val, eventHandler_);
					num = ((int)num2 * -776399876) ^ 0x5495D6A2;
					continue;
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_00b4;
				case 1u:
					return;
				}
				break;
			}
			goto IL_0082;
			IL_0082:
			num = 2022767950;
			goto IL_0087;
		}
	}

	internal virtual PictureBox PictureBox_1
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			pictureBox_1 = value;
		}
	}

	internal virtual PictureBox PictureBox_2
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			pictureBox_2 = value;
		}
	}

	internal virtual PictureBox PictureBox_3
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Expected O, but got Unknown
			EventHandler eventHandler_ = method_4;
			EventHandler eventHandler_2 = default(EventHandler);
			MouseEventHandler mouseEventHandler_ = default(MouseEventHandler);
			PictureBox val = default(PictureBox);
			while (true)
			{
				int num = 828101184;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1AEBB4Au) % 9u)
					{
					case 7u:
						pictureBox_3 = value;
						num = 2061970123;
						continue;
					case 6u:
						eventHandler_2 = method_5;
						mouseEventHandler_ = new MouseEventHandler(method_10);
						num = (int)((num2 * 1050794762) ^ 0x2816F6CD);
						continue;
					case 5u:
						GForm2.smethod_43((Control)(object)val, eventHandler_2);
						GForm2.smethod_44((Control)(object)val, mouseEventHandler_);
						num = ((int)num2 * -1149896519) ^ 0x72D47E61;
						continue;
					case 4u:
						GForm2.smethod_39((Control)(object)val, eventHandler_);
						GForm2.smethod_40((Control)(object)val, eventHandler_2);
						GForm2.smethod_41((Control)(object)val, mouseEventHandler_);
						num = (int)(num2 * 1887990189) ^ -916733620;
						continue;
					case 3u:
						GForm2.smethod_42((Control)(object)val, eventHandler_);
						num = (int)(num2 * 751530293) ^ -1313994592;
						continue;
					case 2u:
					{
						val = pictureBox_3;
						int num5;
						int num6;
						if (val == null)
						{
							num5 = 517912580;
							num6 = 517912580;
						}
						else
						{
							num5 = 1584904481;
							num6 = 1584904481;
						}
						num = num5 ^ (int)(num2 * 2129608616);
						continue;
					}
					case 1u:
					{
						val = pictureBox_3;
						int num3;
						int num4;
						if (val != null)
						{
							num3 = 1860850036;
							num4 = 1860850036;
						}
						else
						{
							num3 = 997906514;
							num4 = 997906514;
						}
						num = num3 ^ (int)(num2 * 861114594);
						continue;
					}
					default:
						return;
					case 0u:
						break;
					case 8u:
						return;
					}
					break;
				}
			}
		}
	}

	internal virtual PictureBox PictureBox_4
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			EventHandler eventHandler_ = method_6;
			EventHandler eventHandler_2 = method_7;
			MouseEventHandler mouseEventHandler_ = new MouseEventHandler(method_11);
			PictureBox val = pictureBox_4;
			if (val != null)
			{
				goto IL_007c;
			}
			goto IL_0114;
			IL_0114:
			pictureBox_4 = value;
			val = pictureBox_4;
			int num = -1362579891;
			goto IL_00dd;
			IL_00dd:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCC2FF6CBu) % 9u)
				{
				case 8u:
					GForm2.smethod_42((Control)(object)val, eventHandler_);
					GForm2.smethod_43((Control)(object)val, eventHandler_2);
					num = (int)((num2 * 203048565) ^ 0x3F81991A);
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (val != null)
					{
						num3 = -863324635;
						num4 = -863324635;
					}
					else
					{
						num3 = -1627059246;
						num4 = -1627059246;
					}
					num = num3 ^ (int)(num2 * 987660639);
					continue;
				}
				case 4u:
					break;
				case 3u:
					GForm2.smethod_39((Control)(object)val, eventHandler_);
					num = (int)((num2 * 793075028) ^ 0x6F00AC58);
					continue;
				case 2u:
					GForm2.smethod_40((Control)(object)val, eventHandler_2);
					num = (int)(num2 * 208897149) ^ -164629589;
					continue;
				case 1u:
					GForm2.smethod_41((Control)(object)val, mouseEventHandler_);
					num = ((int)num2 * -1942785948) ^ -1066513308;
					continue;
				case 0u:
					GForm2.smethod_44((Control)(object)val, mouseEventHandler_);
					num = (int)(num2 * 1344091270) ^ -1511238954;
					continue;
				default:
					return;
				case 6u:
					goto IL_0114;
				case 7u:
					return;
				}
				break;
			}
			goto IL_007c;
			IL_007c:
			num = -673387877;
			goto IL_00dd;
		}
	}

	public GForm2()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		GForm2.smethod_0((Form)(object)this, (EventHandler)method_1);
		GForm2.smethod_1((Control)(object)this, new KeyEventHandler(method_3));
		GForm2.smethod_2((Form)(object)this, new FormClosingEventHandler(method_8));
		int_0 = 0;
		bool_0 = false;
		method_0();
	}

	[DebuggerNonUserCode]
	void Form.Dispose(bool disposing)
	{
		try
		{
			bool flag = default(bool);
			while (true)
			{
				int num = 1207714295;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x39A42F4Eu) % 8u)
					{
					case 7u:
						num = 765340416;
						continue;
					case 5u:
						GForm2.smethod_3((IDisposable)icontainer_0);
						num = ((int)num2 * -1468151474) ^ 0x59D7F7C3;
						continue;
					case 4u:
						num3 = ((icontainer_0 != null) ? 1 : 0);
						goto IL_0031;
					case 3u:
						num = ((int)num2 * -1497368497) ^ -785885108;
						continue;
					case 2u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = 1071316239;
							num5 = 1071316239;
						}
						else
						{
							num4 = 1619973533;
							num5 = 1619973533;
						}
						num = num4 ^ ((int)num2 * -326227782);
						continue;
					}
					case 1u:
						if (disposing)
						{
							num = (int)((num2 * 459592234) ^ 0x4ACBF4F0);
							continue;
						}
						num3 = 0;
						goto IL_0031;
					default:
						return;
					case 0u:
						break;
					case 6u:
						return;
						IL_0031:
						flag = (byte)num3 != 0;
						num = 1516225404;
						continue;
					}
					break;
				}
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void method_0()
	{
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected O, but got Unknown
		//IL_0536: Unknown result type (might be due to invalid IL or missing references)
		//IL_0604: Unknown result type (might be due to invalid IL or missing references)
		//IL_060e: Expected O, but got Unknown
		icontainer_0 = GForm2.smethod_4();
		ComponentResourceManager resourceManager_ = GForm2.smethod_6(GForm2.smethod_5(typeof(GForm2).TypeHandle));
		while (true)
		{
			int num = 1053680951;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x12AB4F37u) % 93u)
				{
				case 92u:
					num = ((int)num2 * -422886498) ^ 0x19B05619;
					continue;
				case 91u:
					num = ((int)num2 * -1102771417) ^ 0x49525432;
					continue;
				case 90u:
					num = ((int)num2 * -1010886412) ^ 0x7B051028;
					continue;
				case 89u:
					GForm2.smethod_12((Control)(object)PictureBox_3, (ImageLayout)3);
					num = ((int)num2 * -1430390847) ^ -1741454519;
					continue;
				case 88u:
					GForm2.smethod_12((Control)(object)PictureBox_4, (ImageLayout)3);
					num = (int)((num2 * 90922855) ^ 0x1E47D395);
					continue;
				case 87u:
					num = ((int)num2 * -891334632) ^ -1271231301;
					continue;
				case 86u:
					num = ((int)num2 * -234317768) ^ 0x30414916;
					continue;
				case 85u:
					GForm2.smethod_9((ISupportInitialize)PictureBox_4);
					num = (int)((num2 * 471561439) ^ 0x1DF45990);
					continue;
				case 83u:
					num = ((int)num2 * -1658629255) ^ -768630603;
					continue;
				case 82u:
					GForm2.smethod_15((Control)(object)PictureBox_0, new Size(617, 69));
					num = (int)(num2 * 589782297) ^ -82178190;
					continue;
				case 81u:
					num = ((int)num2 * -310317928) ^ -270696145;
					continue;
				case 80u:
					GForm2.smethod_16(PictureBox_3, 4);
					num = ((int)num2 * -352781539) ^ 0x4AA7E43E;
					continue;
				case 79u:
					GForm2.smethod_17(PictureBox_4, bool_1: false);
					num = (int)(num2 * 2004108630) ^ -838187574;
					continue;
				case 78u:
					GForm2.smethod_16(PictureBox_2, 3);
					num = (int)(num2 * 646659250) ^ -257320596;
					continue;
				case 77u:
					num = ((int)num2 * -165739848) ^ 0x318FF426;
					continue;
				case 76u:
					GForm2.smethod_26(GForm2.smethod_25((Control)(object)this), (Control)(object)PictureBox_1);
					num = ((int)num2 * -85382625) ^ 0x19CC171C;
					continue;
				case 75u:
					GForm2.smethod_13((Control)(object)PictureBox_0, new Point(214, 12));
					num = ((int)num2 * -726699647) ^ -551715011;
					continue;
				case 74u:
					num = (int)((num2 * 1976672190) ^ 0x58BB70D4);
					continue;
				case 73u:
					num = ((int)num2 * -328838155) ^ 0x6950AE20;
					continue;
				case 72u:
					GForm2.smethod_20((Control)(object)PictureBox_4, (Image)GForm2.smethod_19((ResourceManager)resourceManager_, "PictureBox5.BackgroundImage"));
					num = (int)(num2 * 504065523) ^ -1082869896;
					continue;
				case 71u:
					GForm2.smethod_15((Control)(object)PictureBox_3, new Size(504, 57));
					num = (int)((num2 * 132773410) ^ 0x493067E2);
					continue;
				case 70u:
					PictureBox_4 = GForm2.smethod_7();
					num = (int)((num2 * 2088546317) ^ 0x30464C5);
					continue;
				case 69u:
					GForm2.smethod_14((Control)(object)PictureBox_1, "PictureBox2");
					GForm2.smethod_15((Control)(object)PictureBox_1, new Size(504, 57));
					num = (int)((num2 * 667550315) ^ 0x68D2BDB);
					continue;
				case 68u:
					GForm2.smethod_12((Control)(object)PictureBox_1, (ImageLayout)3);
					num = ((int)num2 * -19333835) ^ 0x12AA357A;
					continue;
				case 67u:
					PictureBox_0 = GForm2.smethod_7();
					num = (int)(num2 * 422333693) ^ -1889355104;
					continue;
				case 66u:
					GForm2.smethod_21((ContainerControl)(object)this, new SizeF(10f, 22f));
					GForm2.smethod_22((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 829548133) ^ -1905107873;
					continue;
				case 65u:
					GForm2.smethod_11((Control)(object)PictureBox_4, Color.Transparent);
					num = (int)((num2 * 530428584) ^ 0x7263BAA9);
					continue;
				case 64u:
					GForm2.smethod_26(GForm2.smethod_25((Control)(object)this), (Control)(object)PictureBox_3);
					GForm2.smethod_26(GForm2.smethod_25((Control)(object)this), (Control)(object)PictureBox_2);
					num = (int)(num2 * 1267897424) ^ -2042859089;
					continue;
				case 63u:
					Timer_0 = GForm2.smethod_8(icontainer_0);
					num = ((int)num2 * -334219717) ^ 0x3EBC4A0B;
					continue;
				case 62u:
					GForm2.smethod_17(PictureBox_3, bool_1: false);
					num = ((int)num2 * -1113364372) ^ -33028043;
					continue;
				case 61u:
					num = ((int)num2 * -1992761558) ^ -782704692;
					continue;
				case 60u:
					num = ((int)num2 * -915859853) ^ -337973587;
					continue;
				case 59u:
					GForm2.smethod_17(PictureBox_2, bool_1: false);
					num = ((int)num2 * -1048711914) ^ 0x7A87B3F9;
					continue;
				case 58u:
					num = ((int)num2 * -1790117268) ^ 0x516D0008;
					continue;
				case 57u:
					GForm2.smethod_31((Form)(object)this, bool_1: false);
					num = (int)((num2 * 969174961) ^ 0x606093A);
					continue;
				case 56u:
					GForm2.smethod_11((Control)(object)PictureBox_2, Color.Transparent);
					GForm2.smethod_12((Control)(object)PictureBox_2, (ImageLayout)3);
					num = ((int)num2 * -29430010) ^ 0x7B990C6A;
					continue;
				case 55u:
					GForm2.smethod_14((Control)(object)PictureBox_4, "PictureBox5");
					num = (int)((num2 * 42252429) ^ 0x4499DE2);
					continue;
				case 54u:
					num = ((int)num2 * -706109558) ^ 0x17BA6A91;
					continue;
				case 53u:
					num = (int)(num2 * 641374911) ^ -2024693276;
					continue;
				case 52u:
					GForm2.smethod_13((Control)(object)PictureBox_4, new Point(268, 555));
					num = ((int)num2 * -209648123) ^ 0x3749D6BD;
					continue;
				case 51u:
					GForm2.smethod_23((Form)(object)this, Color.White);
					num = (int)((num2 * 1906058034) ^ 0x7C7587F3);
					continue;
				case 50u:
					GForm2.smethod_14((Control)(object)PictureBox_2, "PictureBox3");
					num = (int)(num2 * 1169727304) ^ -2123825854;
					continue;
				case 49u:
					GForm2.smethod_26(GForm2.smethod_25((Control)(object)this), (Control)(object)PictureBox_0);
					num = (int)((num2 * 744980110) ^ 0x1A66EC15);
					continue;
				case 48u:
					PictureBox_1 = GForm2.smethod_7();
					num = (int)(num2 * 1098969992) ^ -767435941;
					continue;
				case 47u:
					GForm2.smethod_30((Form)(object)this, new Padding(4));
					num = ((int)num2 * -1483845798) ^ 0xC1E3EAE;
					continue;
				case 46u:
					GForm2.smethod_24((Form)(object)this, new Size(1025, 638));
					num = (int)((num2 * 1587248648) ^ 0x43D65BBC);
					continue;
				case 45u:
					GForm2.smethod_11((Control)(object)PictureBox_3, Color.Transparent);
					num = ((int)num2 * -2027348843) ^ -1977669416;
					continue;
				case 44u:
					num = ((int)num2 * -2029127458) ^ -44802769;
					continue;
				case 43u:
					num = (int)((num2 * 1071125652) ^ 0x57A19A76);
					continue;
				case 42u:
					num = ((int)num2 * -1387103257) ^ -1085475038;
					continue;
				case 41u:
					GForm2.smethod_14((Control)(object)PictureBox_3, "PictureBox4");
					num = (int)((num2 * 1377758137) ^ 0x7D19C92B);
					continue;
				case 40u:
					GForm2.smethod_20((Control)(object)PictureBox_3, (Image)GForm2.smethod_19((ResourceManager)resourceManager_, "PictureBox4.BackgroundImage"));
					num = (int)(num2 * 1485334624) ^ -674914727;
					continue;
				case 39u:
					num = (int)((num2 * 1305381762) ^ 0x775B7D90);
					continue;
				case 38u:
					GForm2.smethod_12((Control)(object)this, (ImageLayout)3);
					num = (int)(num2 * 1319421343) ^ -1460965157;
					continue;
				case 37u:
					GForm2.smethod_13((Control)(object)PictureBox_3, new Point(268, 492));
					num = ((int)num2 * -1770262958) ^ 0x6DD5CC48;
					continue;
				case 36u:
					GForm2.smethod_12((Control)(object)PictureBox_0, (ImageLayout)3);
					num = (int)(num2 * 653932122) ^ -954171831;
					continue;
				case 35u:
					num = (int)(num2 * 1483748625) ^ -765524546;
					continue;
				case 34u:
					GForm2.smethod_13((Control)(object)PictureBox_1, new Point(268, 168));
					num = (int)((num2 * 2106250616) ^ 0x43C3DEBE);
					continue;
				case 33u:
					GForm2.smethod_16(PictureBox_0, 1);
					num = (int)((num2 * 1237476713) ^ 0x5DC41315);
					continue;
				case 32u:
					GForm2.smethod_9((ISupportInitialize)PictureBox_0);
					GForm2.smethod_9((ISupportInitialize)PictureBox_1);
					num = (int)((num2 * 1464951108) ^ 0x16301E0B);
					continue;
				case 31u:
					GForm2.smethod_11((Control)(object)PictureBox_1, Color.Transparent);
					num = (int)((num2 * 956806848) ^ 0x2AE03D5E);
					continue;
				case 30u:
					num = ((int)num2 * -455232056) ^ -1095850666;
					continue;
				case 29u:
					GForm2.smethod_9((ISupportInitialize)PictureBox_2);
					num = (int)(num2 * 987733611) ^ -1203719690;
					continue;
				case 28u:
					num = (int)((num2 * 34219451) ^ 0x71C33ACD);
					continue;
				case 27u:
					GForm2.smethod_16(PictureBox_1, 2);
					num = (int)((num2 * 1059128007) ^ 0x7A155850);
					continue;
				case 26u:
					GForm2.smethod_28((Control)(object)this, GForm2.smethod_27("Consolas", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 516665295) ^ 0x18B4C4EE);
					continue;
				case 25u:
					GForm2.smethod_35((ISupportInitialize)PictureBox_3);
					num = (int)((num2 * 452460371) ^ 0x108C7DB5);
					continue;
				case 24u:
					GForm2.smethod_17(PictureBox_1, bool_1: false);
					num = ((int)num2 * -214839718) ^ -2034802154;
					continue;
				case 23u:
					GForm2.smethod_32((Control)(object)this, "SelectDuelType");
					GForm2.smethod_33((Form)(object)this, (FormStartPosition)1);
					num = (int)(num2 * 302055109) ^ -49789018;
					continue;
				case 22u:
					GForm2.smethod_10((Control)(object)this);
					num = (int)((num2 * 1796664823) ^ 0x799F65BD);
					continue;
				case 21u:
					GForm2.smethod_18(Timer_0, 1000);
					num = ((int)num2 * -1480585613) ^ 0x46999A7D;
					continue;
				case 20u:
					num = (int)(num2 * 943352639) ^ -134774326;
					continue;
				case 19u:
					GForm2.smethod_13((Control)(object)PictureBox_2, new Point(338, 306));
					num = (int)(num2 * 1435870453) ^ -630689132;
					continue;
				case 18u:
					GForm2.smethod_15((Control)(object)PictureBox_4, new Size(504, 57));
					GForm2.smethod_16(PictureBox_4, 5);
					num = ((int)num2 * -1189642287) ^ 0x215083A1;
					continue;
				case 17u:
					GForm2.smethod_9((ISupportInitialize)PictureBox_3);
					num = (int)((num2 * 792667164) ^ 0x718F7E2A);
					continue;
				case 16u:
					((Control)this).set_DoubleBuffered(true);
					num = ((int)num2 * -264587590) ^ 0x6D55F0B8;
					continue;
				case 15u:
					GForm2.smethod_35((ISupportInitialize)PictureBox_4);
					num = ((int)num2 * -1061359198) ^ -1871411790;
					continue;
				case 14u:
					GForm2.smethod_29((Form)(object)this, (FormBorderStyle)1);
					num = (int)((num2 * 1985901960) ^ 0x49897E35);
					continue;
				case 13u:
					num = ((int)num2 * -1518155720) ^ -1240139614;
					continue;
				case 12u:
					GForm2.smethod_14((Control)(object)PictureBox_0, "PictureBox1");
					num = ((int)num2 * -1460951467) ^ -119504773;
					continue;
				case 10u:
					num = (int)((num2 * 273723340) ^ 0xAC885FD);
					continue;
				case 9u:
					GForm2.smethod_35((ISupportInitialize)PictureBox_2);
					num = (int)((num2 * 823207559) ^ 0x57917871);
					continue;
				case 8u:
					PictureBox_2 = GForm2.smethod_7();
					PictureBox_3 = GForm2.smethod_7();
					num = (int)((num2 * 892421916) ^ 0x36E6B279);
					continue;
				case 7u:
					num = ((int)num2 * -1819219518) ^ 0x4EEF184E;
					continue;
				case 6u:
					GForm2.smethod_34((Form)(object)this, "The Omegle Game");
					GForm2.smethod_35((ISupportInitialize)PictureBox_0);
					GForm2.smethod_35((ISupportInitialize)PictureBox_1);
					num = (int)(num2 * 326213749) ^ -897181047;
					continue;
				case 5u:
					num = ((int)num2 * -948546760) ^ -1759044888;
					continue;
				case 4u:
					num = (int)((num2 * 570049308) ^ 0xAA0A9CB);
					continue;
				case 3u:
					GForm2.smethod_11((Control)(object)PictureBox_0, Color.Transparent);
					num = ((int)num2 * -723128010) ^ -701997461;
					continue;
				case 2u:
					GForm2.smethod_15((Control)(object)PictureBox_2, new Size(353, 42));
					num = ((int)num2 * -1728687315) ^ 0x4D2C3A08;
					continue;
				case 1u:
					GForm2.smethod_17(PictureBox_0, bool_1: false);
					num = ((int)num2 * -1967885793) ^ -1390432020;
					continue;
				case 0u:
					GForm2.smethod_26(GForm2.smethod_25((Control)(object)this), (Control)(object)PictureBox_4);
					num = ((int)num2 * -653496314) ^ 0x55BCE8D1;
					continue;
				case 11u:
					break;
				default:
					GForm2.smethod_36((Control)(object)this, bool_1: false);
					return;
				}
				break;
			}
		}
	}

	private void method_1(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -1257995850;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9FAFEA0Eu) % 13u)
				{
				case 12u:
					GForm2.smethod_46(GForm2.smethod_45(), ProcessPriorityClass.RealTime);
					num = ((int)num2 * -460014089) ^ 0x5BFEBC71;
					continue;
				case 11u:
					num = (int)(num2 * 224347123) ^ -1351010862;
					continue;
				case 10u:
					GForm2.smethod_20((Control)(object)PictureBox_0, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\logo.png")));
					num = (int)((num2 * 904506634) ^ 0x43FAC6F2);
					continue;
				case 9u:
					GForm2.smethod_20((Control)(object)PictureBox_3, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\fai_un_duello.png")));
					num = ((int)num2 * -1788346677) ^ -8260827;
					continue;
				case 8u:
					num = (int)(num2 * 336440512) ^ -49422701;
					continue;
				case 7u:
					GForm2.smethod_50(Timer_0);
					num = (int)(num2 * 964411453) ^ -1888704492;
					continue;
				case 6u:
					GForm2.smethod_20((Control)(object)this, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\main_menu.jpg")));
					num = ((int)num2 * -1789662716) ^ 0x152D3778;
					continue;
				case 5u:
					num = (int)(num2 * 1120075998) ^ -268582073;
					continue;
				case 4u:
					GForm2.smethod_20((Control)(object)PictureBox_4, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\torna_indietro.png")));
					num = ((int)num2 * -1784759068) ^ 0x6280CB2E;
					continue;
				case 2u:
					GForm2.smethod_20((Control)(object)PictureBox_1, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\seleziona_una_modalita.png")));
					num = (int)((num2 * 1939097) ^ 0x4699EE25);
					continue;
				case 1u:
					GForm2.smethod_20((Control)(object)PictureBox_2, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\con_la_cpu_hover.png")));
					num = ((int)num2 * -1716277638) ^ 0x38D2CE94;
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

	private void method_2(object sender, EventArgs e)
	{
		GForm2.smethod_51();
	}

	private void method_3(object sender, KeyEventArgs e)
	{
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -1423296542;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA4DC42EFu) % 18u)
				{
				case 17u:
					num = ((int)num2 * -1164217958) ^ 0x1D1867E6;
					continue;
				case 16u:
					num = ((int)num2 * -695570868) ^ 0x30DC5EE2;
					continue;
				case 15u:
				{
					int num7;
					int num8;
					if (int_0 == 0)
					{
						num7 = 1951918363;
						num8 = 1951918363;
					}
					else
					{
						num7 = 2110628148;
						num8 = 2110628148;
					}
					num = num7 ^ (int)(num2 * 1139705963);
					continue;
				}
				case 14u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = 1136639057;
						num6 = 1136639057;
					}
					else
					{
						num5 = 1617831006;
						num6 = 1617831006;
					}
					num = num5 ^ (int)(num2 * 2139129442);
					continue;
				}
				case 13u:
				{
					int num9;
					int num10;
					if (!((GForm2.smethod_52(e) == 37) | (GForm2.smethod_52(e) == 39)))
					{
						num9 = -46474191;
						num10 = -46474191;
					}
					else
					{
						num9 = -1747015862;
						num10 = -1747015862;
					}
					num = num9 ^ ((int)num2 * -1520479366);
					continue;
				}
				case 12u:
					num = ((int)num2 * -246659941) ^ 0xE9F855F;
					continue;
				case 11u:
					GForm2.smethod_20((Control)(object)PictureBox_2, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\con_la_cpu_hover.png")));
					num = (int)((num2 * 747304364) ^ 0x2C4CB86D);
					continue;
				case 10u:
					flag2 = int_0 == 1;
					num = -673783969;
					continue;
				case 8u:
				{
					int num3;
					int num4;
					if (!flag2)
					{
						num3 = -656884492;
						num4 = -656884492;
					}
					else
					{
						num3 = -1162571448;
						num4 = -1162571448;
					}
					num = num3 ^ (int)(num2 * 1726278754);
					continue;
				}
				case 7u:
					GForm2.smethod_20((Control)(object)PictureBox_2, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\con_gli_altri.png")));
					num = ((int)num2 * -805790835) ^ -2108772840;
					continue;
				case 6u:
					num = -1459412221;
					continue;
				case 5u:
					int_0 = 1;
					num = (int)(num2 * 450804558) ^ -238230725;
					continue;
				case 4u:
					num = ((int)num2 * -1864131139) ^ -159576062;
					continue;
				case 2u:
					flag = int_0 == 0;
					num = -2127751077;
					continue;
				case 1u:
					num = ((int)num2 * -264785090) ^ -523977921;
					continue;
				case 0u:
					int_0 = 0;
					num = -156587530;
					continue;
				default:
					return;
				case 3u:
					break;
				case 9u:
					return;
				}
				break;
			}
		}
	}

	private void method_4(object sender, EventArgs e)
	{
		GForm2.smethod_20((Control)(object)PictureBox_3, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\fai_un_duello_hover.png")));
	}

	private void method_5(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 1181157425;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF0ECC8Cu) % 4u)
				{
				case 2u:
					num = ((int)num2 * -657312595) ^ 0x2D059F32;
					continue;
				case 1u:
					GForm2.smethod_20((Control)(object)PictureBox_3, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\fai_un_duello.png")));
					num = ((int)num2 * -155001090) ^ 0x68B20880;
					continue;
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

	private void method_6(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -829224481;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBB8E0FA5u) % 4u)
				{
				case 2u:
					GForm2.smethod_20((Control)(object)PictureBox_4, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\torna_indietro_hover.png")));
					num = ((int)num2 * -500880862) ^ 0x64D84170;
					continue;
				case 1u:
					num = (int)((num2 * 1050039524) ^ 0x7D48FB09);
					continue;
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

	private void method_7(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 338391273;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6EEE33C2u) % 4u)
				{
				case 3u:
					GForm2.smethod_20((Control)(object)PictureBox_4, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\torna_indietro.png")));
					num = (int)(num2 * 2047900829) ^ -1626601531;
					continue;
				case 0u:
					num = ((int)num2 * -21354609) ^ 0x5D75A3F;
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

	private void method_8(object sender, FormClosingEventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -140259153;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEC03B3C1u) % 9u)
				{
				case 8u:
					flag = !bool_0;
					num = (int)((num2 * 1832680427) ^ 0x3E57CCD);
					continue;
				case 6u:
					method_9();
					num = ((int)num2 * -709404939) ^ 0x3E839404;
					continue;
				case 5u:
					num = -2095999322;
					continue;
				case 4u:
					GForm2.smethod_53((CancelEventArgs)(object)e, bool_1: true);
					num = (int)((num2 * 2108707091) ^ 0x75FF83D7);
					continue;
				case 3u:
					num = ((int)num2 * -1886412968) ^ -1596316207;
					continue;
				case 1u:
					num = (int)(num2 * 1601583621) ^ -310273767;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 653897352;
						num4 = 653897352;
					}
					else
					{
						num3 = 1802365032;
						num4 = 1802365032;
					}
					num = num3 ^ ((int)num2 * -609941802);
					continue;
				}
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

	public void method_9()
	{
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Invalid comparison between Unknown and I4
		while (true)
		{
			int num = -2090908593;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDC2FA259u) % 22u)
				{
				case 21u:
					num = ((int)num2 * -352321071) ^ 0x58C0BB5C;
					continue;
				case 20u:
					GForm2.smethod_56((object)int_0);
					num = (int)(num2 * 1955993427) ^ -1866032510;
					continue;
				case 19u:
					num = ((int)num2 * -1504773895) ^ 0x1373E26D;
					continue;
				case 18u:
					GForm2.smethod_55(Timer_0);
					num = (int)((num2 * 439630418) ^ 0x28C52199);
					continue;
				case 17u:
					GForm2.smethod_56((object)Timer_0);
					num = (int)(num2 * 909774793) ^ -18810884;
					continue;
				case 16u:
					num = -669407227;
					continue;
				case 15u:
					num = ((int)num2 * -1194465945) ^ -725706684;
					continue;
				case 14u:
					GForm2.smethod_56((object)Timer_0);
					num = ((int)num2 * -780417322) ^ 0x65E717C0;
					continue;
				case 13u:
					GForm2.smethod_56((object)bool_0);
					GForm2.smethod_51();
					GForm2.smethod_57(GForm2.smethod_45());
					num = ((int)num2 * -1102774553) ^ -1610103959;
					continue;
				case 12u:
					num = (int)(num2 * 1858215205) ^ -1515074157;
					continue;
				case 11u:
					num = ((int)num2 * -1458614314) ^ -2084802915;
					continue;
				case 9u:
					GForm2.smethod_55(Timer_0);
					num = (int)(num2 * 1050377685) ^ -1267521323;
					continue;
				case 8u:
					num = ((int)num2 * -307110393) ^ 0x4E1E6C25;
					continue;
				case 7u:
					num = -1862032933;
					continue;
				case 6u:
				{
					int num5;
					int num6;
					if (!bool_0)
					{
						num5 = -735074548;
						num6 = -735074548;
					}
					else
					{
						num5 = -1564436702;
						num6 = -1564436702;
					}
					num = num5 ^ ((int)num2 * -469842660);
					continue;
				}
				case 5u:
					GForm2.smethod_51();
					num = ((int)num2 * -1380779072) ^ 0x58D4269F;
					continue;
				case 4u:
					GForm2.smethod_56((object)bool_0);
					num = ((int)num2 * -206960159) ^ 0x6DFD89CE;
					continue;
				case 3u:
					num = ((int)num2 * -498552704) ^ 0x64290BF6;
					continue;
				case 2u:
					GForm2.smethod_56((object)int_0);
					num = ((int)num2 * -370639471) ^ -660088552;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if ((int)GForm2.smethod_54("Sei sicuro di voler uscire dal gioco?", "The Omegle Game", (MessageBoxButtons)4, (MessageBoxIcon)32) == 6)
					{
						num3 = -674756996;
						num4 = -674756996;
					}
					else
					{
						num3 = -1109213831;
						num4 = -1109213831;
					}
					num = num3 ^ ((int)num2 * -1727766714);
					continue;
				}
				default:
					return;
				case 0u:
					break;
				case 10u:
					return;
				}
				break;
			}
		}
	}

	private void method_10(object sender, MouseEventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		bool_0 = true;
		GForm2.smethod_54("Ci dispiace, ma la modalità duello non è attualmente disponibile.", "The Omegle Game", (MessageBoxButtons)0, (MessageBoxIcon)48);
	}

	private void method_11(object sender, MouseEventArgs e)
	{
		while (true)
		{
			int num = 609253474;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1EECC772u) % 5u)
				{
				case 4u:
					GForm2.smethod_58((Control)(object)Class2.Class3_0.GForm1_0);
					num = ((int)num2 * -1060002998) ^ -775577771;
					continue;
				case 3u:
					bool_0 = true;
					num = (int)((num2 * 2132798913) ^ 0x3558845C);
					continue;
				case 1u:
					GForm2.smethod_59((Form)(object)this);
					num = ((int)num2 * -1136984147) ^ -2010673190;
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

	static void smethod_0(Form form_0, EventHandler eventHandler_0)
	{
		form_0.add_Load(eventHandler_0);
	}

	static void smethod_1(Control control_0, KeyEventHandler keyEventHandler_0)
	{
		control_0.add_KeyDown(keyEventHandler_0);
	}

	static void smethod_2(Form form_0, FormClosingEventHandler formClosingEventHandler_0)
	{
		form_0.add_FormClosing(formClosingEventHandler_0);
	}

	static void smethod_3(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Container smethod_4()
	{
		return new Container();
	}

	static Type smethod_5(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static ComponentResourceManager smethod_6(Type type_0)
	{
		return new ComponentResourceManager(type_0);
	}

	static PictureBox smethod_7()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new PictureBox();
	}

	static Timer smethod_8(IContainer icontainer_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new Timer(icontainer_1);
	}

	static void smethod_9(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.BeginInit();
	}

	static void smethod_10(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_11(Control control_0, Color color_0)
	{
		control_0.set_BackColor(color_0);
	}

	static void smethod_12(Control control_0, ImageLayout imageLayout_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_BackgroundImageLayout(imageLayout_0);
	}

	static void smethod_13(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_14(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_15(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_16(PictureBox pictureBox_5, int int_1)
	{
		pictureBox_5.set_TabIndex(int_1);
	}

	static void smethod_17(PictureBox pictureBox_5, bool bool_1)
	{
		pictureBox_5.set_TabStop(bool_1);
	}

	static void smethod_18(Timer timer_1, int int_1)
	{
		timer_1.set_Interval(int_1);
	}

	static object smethod_19(ResourceManager resourceManager_0, string string_0)
	{
		return resourceManager_0.GetObject(string_0);
	}

	static void smethod_20(Control control_0, Image image_0)
	{
		control_0.set_BackgroundImage(image_0);
	}

	static void smethod_21(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_22(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_23(Form form_0, Color color_0)
	{
		form_0.set_BackColor(color_0);
	}

	static void smethod_24(Form form_0, Size size_0)
	{
		form_0.set_ClientSize(size_0);
	}

	static ControlCollection smethod_25(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_26(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static Font smethod_27(string string_0, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_28(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static void smethod_29(Form form_0, FormBorderStyle formBorderStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_FormBorderStyle(formBorderStyle_0);
	}

	static void smethod_30(Form form_0, Padding padding_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_Margin(padding_0);
	}

	static void smethod_31(Form form_0, bool bool_1)
	{
		form_0.set_MaximizeBox(bool_1);
	}

	static void smethod_32(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_33(Form form_0, FormStartPosition formStartPosition_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_StartPosition(formStartPosition_0);
	}

	static void smethod_34(Form form_0, string string_0)
	{
		form_0.set_Text(string_0);
	}

	static void smethod_35(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.EndInit();
	}

	static void smethod_36(Control control_0, bool bool_1)
	{
		control_0.ResumeLayout(bool_1);
	}

	static void smethod_37(Timer timer_1, EventHandler eventHandler_0)
	{
		timer_1.remove_Tick(eventHandler_0);
	}

	static void smethod_38(Timer timer_1, EventHandler eventHandler_0)
	{
		timer_1.add_Tick(eventHandler_0);
	}

	static void smethod_39(Control control_0, EventHandler eventHandler_0)
	{
		control_0.remove_MouseEnter(eventHandler_0);
	}

	static void smethod_40(Control control_0, EventHandler eventHandler_0)
	{
		control_0.remove_MouseLeave(eventHandler_0);
	}

	static void smethod_41(Control control_0, MouseEventHandler mouseEventHandler_0)
	{
		control_0.remove_MouseClick(mouseEventHandler_0);
	}

	static void smethod_42(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_MouseEnter(eventHandler_0);
	}

	static void smethod_43(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_MouseLeave(eventHandler_0);
	}

	static void smethod_44(Control control_0, MouseEventHandler mouseEventHandler_0)
	{
		control_0.add_MouseClick(mouseEventHandler_0);
	}

	static Process smethod_45()
	{
		return Process.GetCurrentProcess();
	}

	static void smethod_46(Process process_0, ProcessPriorityClass processPriorityClass_0)
	{
		process_0.PriorityClass = processPriorityClass_0;
	}

	static string smethod_47()
	{
		return Application.get_StartupPath();
	}

	static string smethod_48(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static Image smethod_49(string string_0)
	{
		return Image.FromFile(string_0);
	}

	static void smethod_50(Timer timer_1)
	{
		timer_1.Start();
	}

	static void smethod_51()
	{
		GC.Collect();
	}

	static int smethod_52(KeyEventArgs keyEventArgs_0)
	{
		return keyEventArgs_0.get_KeyValue();
	}

	static void smethod_53(CancelEventArgs cancelEventArgs_0, bool bool_1)
	{
		cancelEventArgs_0.Cancel = bool_1;
	}

	static DialogResult smethod_54(string string_0, string string_1, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0, string_1, messageBoxButtons_0, messageBoxIcon_0);
	}

	static void smethod_55(Timer timer_1)
	{
		timer_1.Stop();
	}

	static void smethod_56(object object_0)
	{
		GC.SuppressFinalize(object_0);
	}

	static void smethod_57(Process process_0)
	{
		process_0.Kill();
	}

	static void smethod_58(Control control_0)
	{
		control_0.Show();
	}

	static void smethod_59(Form form_0)
	{
		form_0.Close();
	}
}
