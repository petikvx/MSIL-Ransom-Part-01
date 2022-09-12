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
			Timer val = default(Timer);
			while (true)
			{
				int num = -895984937;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC517A1F9u) % 8u)
					{
					case 7u:
					{
						int num5;
						int num6;
						if (val != null)
						{
							num5 = 1284143080;
							num6 = 1284143080;
						}
						else
						{
							num5 = 1132695273;
							num6 = 1132695273;
						}
						num = num5 ^ ((int)num2 * -2134813457);
						continue;
					}
					case 6u:
						val = timer_0;
						num = (int)(num2 * 789584537) ^ -325534496;
						continue;
					case 5u:
					{
						val = timer_0;
						int num3;
						int num4;
						if (val == null)
						{
							num3 = -16765745;
							num4 = -16765745;
						}
						else
						{
							num3 = -1610102143;
							num4 = -1610102143;
						}
						num = num3 ^ (int)(num2 * 849104932);
						continue;
					}
					case 4u:
						GForm2.smethod_38(val, eventHandler_);
						num = (int)((num2 * 42071577) ^ 0x4BAD27D7);
						continue;
					case 1u:
						timer_0 = value;
						num = -501424588;
						continue;
					case 0u:
						GForm2.smethod_37(val, eventHandler_);
						num = (int)((num2 * 114634948) ^ 0x2767DD20);
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
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Expected O, but got Unknown
			EventHandler eventHandler_ = method_4;
			EventHandler eventHandler_2 = default(EventHandler);
			MouseEventHandler mouseEventHandler_ = default(MouseEventHandler);
			PictureBox val = default(PictureBox);
			while (true)
			{
				int num = -1010540324;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAC333C0Bu) % 12u)
					{
					case 11u:
						eventHandler_2 = method_5;
						mouseEventHandler_ = new MouseEventHandler(method_10);
						num = (int)((num2 * 1627052473) ^ 0x101373B8);
						continue;
					case 10u:
						GForm2.smethod_39((Control)(object)val, eventHandler_);
						num = ((int)num2 * -1014663890) ^ 0x12005548;
						continue;
					case 8u:
						val = pictureBox_3;
						num = ((int)num2 * -1650427835) ^ 0x1ED0E63D;
						continue;
					case 7u:
						GForm2.smethod_43((Control)(object)val, eventHandler_2);
						GForm2.smethod_44((Control)(object)val, mouseEventHandler_);
						num = (int)((num2 * 1763394660) ^ 0x5EE9468E);
						continue;
					case 6u:
					{
						int num5;
						int num6;
						if (val == null)
						{
							num5 = -646314668;
							num6 = -646314668;
						}
						else
						{
							num5 = -389603069;
							num6 = -389603069;
						}
						num = num5 ^ (int)(num2 * 720975701);
						continue;
					}
					case 5u:
						GForm2.smethod_41((Control)(object)val, mouseEventHandler_);
						num = (int)((num2 * 1705142618) ^ 0x25047A6C);
						continue;
					case 4u:
						GForm2.smethod_42((Control)(object)val, eventHandler_);
						num = (int)((num2 * 678806185) ^ 0x32B8E758);
						continue;
					case 3u:
						GForm2.smethod_40((Control)(object)val, eventHandler_2);
						num = (int)((num2 * 1054966326) ^ 0x4F279138);
						continue;
					case 1u:
						pictureBox_3 = value;
						val = pictureBox_3;
						num = -775355077;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (val != null)
						{
							num3 = 500112603;
							num4 = 500112603;
						}
						else
						{
							num3 = 1789869922;
							num4 = 1789869922;
						}
						num = num3 ^ (int)(num2 * 829021428);
						continue;
					}
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
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Expected O, but got Unknown
			EventHandler eventHandler_ = method_6;
			EventHandler eventHandler_2 = method_7;
			PictureBox val = default(PictureBox);
			MouseEventHandler mouseEventHandler_ = default(MouseEventHandler);
			while (true)
			{
				int num = -317671812;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD05B95AEu) % 10u)
					{
					case 8u:
					{
						int num5;
						int num6;
						if (val != null)
						{
							num5 = -95036419;
							num6 = -95036419;
						}
						else
						{
							num5 = -1832607135;
							num6 = -1832607135;
						}
						num = num5 ^ (int)(num2 * 637282690);
						continue;
					}
					case 7u:
					{
						val = pictureBox_4;
						int num3;
						int num4;
						if (val != null)
						{
							num3 = -345538053;
							num4 = -345538053;
						}
						else
						{
							num3 = -50060844;
							num4 = -50060844;
						}
						num = num3 ^ ((int)num2 * -2119576984);
						continue;
					}
					case 6u:
						mouseEventHandler_ = new MouseEventHandler(method_11);
						num = ((int)num2 * -820885013) ^ -1364176273;
						continue;
					case 5u:
						GForm2.smethod_42((Control)(object)val, eventHandler_);
						num = ((int)num2 * -1617515946) ^ 0x3A713416;
						continue;
					case 4u:
						pictureBox_4 = value;
						num = -1325297919;
						continue;
					case 3u:
						val = pictureBox_4;
						num = (int)(num2 * 744599105) ^ -2126023349;
						continue;
					case 2u:
						GForm2.smethod_43((Control)(object)val, eventHandler_2);
						GForm2.smethod_44((Control)(object)val, mouseEventHandler_);
						num = ((int)num2 * -165239920) ^ 0x4B522F55;
						continue;
					case 1u:
						GForm2.smethod_39((Control)(object)val, eventHandler_);
						GForm2.smethod_40((Control)(object)val, eventHandler_2);
						GForm2.smethod_41((Control)(object)val, mouseEventHandler_);
						num = ((int)num2 * -1499894644) ^ 0x45EA7810;
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
	}

	public GForm2()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		while (true)
		{
			int num = 514220191;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1252BC83u) % 7u)
				{
				case 5u:
					GForm2.smethod_1((Control)(object)this, new KeyEventHandler(method_3));
					num = (int)(num2 * 1371186578) ^ -506622941;
					continue;
				case 3u:
					GForm2.smethod_2((Form)(object)this, new FormClosingEventHandler(method_8));
					num = (int)((num2 * 1268581888) ^ 0x297C9441);
					continue;
				case 2u:
					num = ((int)num2 * -2131781540) ^ 0x50AFC54A;
					continue;
				case 1u:
					GForm2.smethod_0((Form)(object)this, (EventHandler)method_1);
					num = ((int)num2 * -1729012887) ^ 0xCB306AD;
					continue;
				case 0u:
					num = ((int)num2 * -1278013910) ^ -74055088;
					continue;
				case 4u:
					break;
				default:
					int_0 = 0;
					bool_0 = false;
					method_0();
					return;
				}
				break;
			}
		}
	}

	[DebuggerNonUserCode]
	void Form.Dispose(bool disposing)
	{
		try
		{
			if (disposing)
			{
				goto IL_002f;
			}
			int num = 0;
			goto IL_00ac;
			IL_00ac:
			bool flag = (byte)num != 0;
			int num2 = 1296952491;
			goto IL_0072;
			IL_002f:
			num2 = 2103723594;
			goto IL_0072;
			IL_0072:
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x2635D383u) % 8u)
				{
				case 7u:
					num2 = (int)((num3 * 1559382737) ^ 0x79F900EA);
					continue;
				case 6u:
					num2 = 295244223;
					continue;
				case 5u:
					num2 = ((int)num3 * -55866050) ^ -704174558;
					continue;
				case 3u:
					break;
				case 2u:
					GForm2.smethod_3((IDisposable)icontainer_0);
					num2 = ((int)num3 * -225528185) ^ -846171424;
					continue;
				case 0u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1107971573;
						num5 = 1107971573;
					}
					else
					{
						num4 = 526947833;
						num5 = 526947833;
					}
					num2 = num4 ^ ((int)num3 * -662739779);
					continue;
				}
				default:
					return;
				case 1u:
					goto IL_00a3;
				case 4u:
					return;
				}
				break;
			}
			goto IL_002f;
			IL_00a3:
			num = ((icontainer_0 != null) ? 1 : 0);
			goto IL_00ac;
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void method_0()
	{
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0379: Expected O, but got Unknown
		//IL_0642: Unknown result type (might be due to invalid IL or missing references)
		icontainer_0 = GForm2.smethod_4();
		ComponentResourceManager resourceManager_ = GForm2.smethod_6(GForm2.smethod_5(typeof(GForm2).TypeHandle));
		PictureBox_0 = GForm2.smethod_7();
		while (true)
		{
			int num = -1138208041;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEB8CE48Au) % 92u)
				{
				case 91u:
					GForm2.smethod_24((Form)(object)this, new Size(1025, 638));
					num = ((int)num2 * -247756144) ^ -2087861628;
					continue;
				case 90u:
					num = ((int)num2 * -344944903) ^ -305293169;
					continue;
				case 89u:
					GForm2.smethod_12((Control)(object)PictureBox_2, (ImageLayout)3);
					num = ((int)num2 * -916168734) ^ -405408042;
					continue;
				case 88u:
					num = (int)((num2 * 256614265) ^ 0x67F8DB6B);
					continue;
				case 87u:
					num = (int)((num2 * 1619620844) ^ 0x6335F620);
					continue;
				case 86u:
					GForm2.smethod_14((Control)(object)PictureBox_0, "PictureBox1");
					num = ((int)num2 * -1863934180) ^ -1827689384;
					continue;
				case 85u:
					GForm2.smethod_14((Control)(object)PictureBox_3, "PictureBox4");
					num = (int)(num2 * 1494586089) ^ -866712959;
					continue;
				case 83u:
					num = ((int)num2 * -1329722723) ^ -608403897;
					continue;
				case 82u:
					PictureBox_3 = GForm2.smethod_7();
					PictureBox_4 = GForm2.smethod_7();
					num = (int)((num2 * 557799217) ^ 0x1CF5CF31);
					continue;
				case 81u:
					GForm2.smethod_20((Control)(object)PictureBox_3, (Image)GForm2.smethod_19((ResourceManager)resourceManager_, "PictureBox4.BackgroundImage"));
					num = (int)((num2 * 2071748952) ^ 0x74020DC7);
					continue;
				case 80u:
					GForm2.smethod_26(GForm2.smethod_25((Control)(object)this), (Control)(object)PictureBox_2);
					num = (int)((num2 * 468693261) ^ 0x6BC13795);
					continue;
				case 79u:
					num = ((int)num2 * -1977133939) ^ 0x7B19FA2C;
					continue;
				case 78u:
					GForm2.smethod_15((Control)(object)PictureBox_2, new Size(353, 42));
					num = ((int)num2 * -589068985) ^ 0x6CE02455;
					continue;
				case 77u:
					GForm2.smethod_14((Control)(object)PictureBox_2, "PictureBox3");
					num = (int)((num2 * 283938528) ^ 0x4EA4C4B8);
					continue;
				case 76u:
					GForm2.smethod_31((Form)(object)this, bool_1: false);
					GForm2.smethod_32((Control)(object)this, "SelectDuelType");
					num = (int)(num2 * 545347937) ^ -1789482664;
					continue;
				case 75u:
					GForm2.smethod_29((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -911775899) ^ -744005956;
					continue;
				case 74u:
					num = ((int)num2 * -100365178) ^ 0x50EDD587;
					continue;
				case 73u:
					num = ((int)num2 * -595842587) ^ 0x1A01239C;
					continue;
				case 72u:
					GForm2.smethod_17(PictureBox_2, bool_1: false);
					num = ((int)num2 * -1763554833) ^ 0x53E72D6D;
					continue;
				case 71u:
					num = ((int)num2 * -1361155258) ^ 0x74193CD0;
					continue;
				case 70u:
					GForm2.smethod_9((ISupportInitialize)PictureBox_4);
					num = ((int)num2 * -1836931527) ^ -146508173;
					continue;
				case 69u:
					GForm2.smethod_26(GForm2.smethod_25((Control)(object)this), (Control)(object)PictureBox_4);
					num = (int)((num2 * 487309365) ^ 0x74CA7975);
					continue;
				case 68u:
					num = ((int)num2 * -531848319) ^ -2142863472;
					continue;
				case 67u:
					GForm2.smethod_35((ISupportInitialize)PictureBox_0);
					num = ((int)num2 * -770193552) ^ -1632356458;
					continue;
				case 66u:
					GForm2.smethod_13((Control)(object)PictureBox_2, new Point(338, 306));
					num = (int)((num2 * 1992399196) ^ 0x6C7DA3AD);
					continue;
				case 65u:
					GForm2.smethod_21((ContainerControl)(object)this, new SizeF(10f, 22f));
					num = (int)((num2 * 763375103) ^ 0x77F5257A);
					continue;
				case 64u:
					GForm2.smethod_9((ISupportInitialize)PictureBox_1);
					num = ((int)num2 * -902863525) ^ -1031500303;
					continue;
				case 63u:
					GForm2.smethod_9((ISupportInitialize)PictureBox_3);
					num = (int)((num2 * 473630540) ^ 0x79A688C9);
					continue;
				case 62u:
					GForm2.smethod_20((Control)(object)PictureBox_4, (Image)GForm2.smethod_19((ResourceManager)resourceManager_, "PictureBox5.BackgroundImage"));
					num = ((int)num2 * -944209029) ^ -226281128;
					continue;
				case 61u:
					GForm2.smethod_12((Control)(object)PictureBox_1, (ImageLayout)3);
					num = ((int)num2 * -157071472) ^ -1134616642;
					continue;
				case 60u:
					num = (int)(num2 * 439465740) ^ -1117175485;
					continue;
				case 59u:
					num = ((int)num2 * -1622006727) ^ 0x5B20EA5B;
					continue;
				case 58u:
					GForm2.smethod_35((ISupportInitialize)PictureBox_4);
					GForm2.smethod_36((Control)(object)this, bool_1: false);
					num = ((int)num2 * -515049409) ^ -192534904;
					continue;
				case 57u:
					GForm2.smethod_12((Control)(object)PictureBox_4, (ImageLayout)3);
					num = (int)(num2 * 1911807501) ^ -1793764855;
					continue;
				case 56u:
					num = (int)(num2 * 136150985) ^ -1365062030;
					continue;
				case 55u:
					GForm2.smethod_26(GForm2.smethod_25((Control)(object)this), (Control)(object)PictureBox_0);
					num = ((int)num2 * -1028582614) ^ -2022553187;
					continue;
				case 54u:
					PictureBox_1 = GForm2.smethod_7();
					num = (int)((num2 * 444143194) ^ 0x511FEBFD);
					continue;
				case 53u:
					GForm2.smethod_12((Control)(object)PictureBox_3, (ImageLayout)3);
					num = ((int)num2 * -1746291420) ^ -738603177;
					continue;
				case 52u:
					Timer_0 = GForm2.smethod_8(icontainer_0);
					num = ((int)num2 * -457492140) ^ -257376974;
					continue;
				case 51u:
					GForm2.smethod_16(PictureBox_4, 5);
					num = (int)((num2 * 719046567) ^ 0x36694AD5);
					continue;
				case 50u:
					GForm2.smethod_15((Control)(object)PictureBox_3, new Size(504, 57));
					num = (int)((num2 * 236921346) ^ 0x7BBE7B06);
					continue;
				case 49u:
					GForm2.smethod_9((ISupportInitialize)PictureBox_0);
					num = (int)((num2 * 862853947) ^ 0x1D7C9211);
					continue;
				case 48u:
					num = (int)(num2 * 209071535) ^ -1428633030;
					continue;
				case 47u:
					GForm2.smethod_13((Control)(object)PictureBox_4, new Point(268, 555));
					num = ((int)num2 * -2124652037) ^ -41349708;
					continue;
				case 46u:
					GForm2.smethod_11((Control)(object)PictureBox_2, Color.Transparent);
					num = ((int)num2 * -1250749368) ^ 0x755DC5DE;
					continue;
				case 45u:
					GForm2.smethod_16(PictureBox_2, 3);
					num = ((int)num2 * -2091645809) ^ 0x48CD31D;
					continue;
				case 44u:
					GForm2.smethod_16(PictureBox_3, 4);
					num = (int)(num2 * 1796453398) ^ -605646285;
					continue;
				case 43u:
					GForm2.smethod_28((Control)(object)this, GForm2.smethod_27("Consolas", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1975213634) ^ 0x6C354C2B;
					continue;
				case 42u:
					num = ((int)num2 * -1253465124) ^ -751065037;
					continue;
				case 41u:
					GForm2.smethod_18(Timer_0, 1000);
					GForm2.smethod_11((Control)(object)PictureBox_1, Color.Transparent);
					num = ((int)num2 * -2083403060) ^ -2039335773;
					continue;
				case 39u:
					num = ((int)num2 * -1216985613) ^ 0x5BD6F872;
					continue;
				case 38u:
					GForm2.smethod_17(PictureBox_4, bool_1: false);
					num = (int)((num2 * 1515902667) ^ 0xB99A0BD);
					continue;
				case 37u:
					GForm2.smethod_30((Form)(object)this, new Padding(4));
					num = ((int)num2 * -1367741066) ^ 0x6248C444;
					continue;
				case 36u:
					GForm2.smethod_26(GForm2.smethod_25((Control)(object)this), (Control)(object)PictureBox_3);
					num = (int)((num2 * 2082827799) ^ 0x48D00696);
					continue;
				case 35u:
					GForm2.smethod_11((Control)(object)PictureBox_4, Color.Transparent);
					num = ((int)num2 * -1250641275) ^ -190326261;
					continue;
				case 34u:
					GForm2.smethod_17(PictureBox_0, bool_1: false);
					num = ((int)num2 * -92149739) ^ -1480304359;
					continue;
				case 33u:
					((Control)this).set_DoubleBuffered(true);
					num = (int)(num2 * 1071630350) ^ -18397541;
					continue;
				case 32u:
					GForm2.smethod_15((Control)(object)PictureBox_4, new Size(504, 57));
					num = (int)((num2 * 796464205) ^ 0x57AB3549);
					continue;
				case 31u:
					GForm2.smethod_11((Control)(object)PictureBox_3, Color.Transparent);
					num = (int)((num2 * 1225892618) ^ 0x88E706);
					continue;
				case 30u:
					GForm2.smethod_15((Control)(object)PictureBox_0, new Size(617, 69));
					num = (int)(num2 * 1051149849) ^ -512819826;
					continue;
				case 29u:
					GForm2.smethod_17(PictureBox_3, bool_1: false);
					num = ((int)num2 * -1257322915) ^ -1016276780;
					continue;
				case 28u:
					num = ((int)num2 * -165565195) ^ -514693487;
					continue;
				case 27u:
					num = ((int)num2 * -876306529) ^ -1382794640;
					continue;
				case 26u:
					GForm2.smethod_17(PictureBox_1, bool_1: false);
					num = ((int)num2 * -1526924897) ^ 0x133735B6;
					continue;
				case 25u:
					num = ((int)num2 * -468153077) ^ -1513722979;
					continue;
				case 24u:
					GForm2.smethod_23((Form)(object)this, Color.White);
					GForm2.smethod_12((Control)(object)this, (ImageLayout)3);
					num = ((int)num2 * -1472115898) ^ 0x79CB944D;
					continue;
				case 23u:
					GForm2.smethod_22((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 349961964) ^ 0x1BCB8D2);
					continue;
				case 22u:
					GForm2.smethod_26(GForm2.smethod_25((Control)(object)this), (Control)(object)PictureBox_1);
					num = ((int)num2 * -246702435) ^ 0x53B87A5F;
					continue;
				case 21u:
					num = (int)(num2 * 1326074135) ^ -89003080;
					continue;
				case 20u:
					GForm2.smethod_16(PictureBox_1, 2);
					num = ((int)num2 * -824268476) ^ 0xE34CD64;
					continue;
				case 19u:
					GForm2.smethod_35((ISupportInitialize)PictureBox_1);
					num = ((int)num2 * -3711940) ^ -1278581821;
					continue;
				case 18u:
					GForm2.smethod_9((ISupportInitialize)PictureBox_2);
					num = (int)(num2 * 2044804698) ^ -951417786;
					continue;
				case 17u:
					GForm2.smethod_35((ISupportInitialize)PictureBox_3);
					num = ((int)num2 * -510182396) ^ 0x2A3BCEE4;
					continue;
				case 16u:
					GForm2.smethod_13((Control)(object)PictureBox_1, new Point(268, 168));
					GForm2.smethod_14((Control)(object)PictureBox_1, "PictureBox2");
					GForm2.smethod_15((Control)(object)PictureBox_1, new Size(504, 57));
					num = ((int)num2 * -1684407427) ^ -2045790230;
					continue;
				case 15u:
					GForm2.smethod_35((ISupportInitialize)PictureBox_2);
					num = ((int)num2 * -2012952804) ^ 0x2F77C1DE;
					continue;
				case 14u:
					num = (int)(num2 * 553211787) ^ -271212040;
					continue;
				case 13u:
					num = (int)(num2 * 1964483536) ^ -884837067;
					continue;
				case 12u:
					num = ((int)num2 * -2073878607) ^ -148553388;
					continue;
				case 11u:
					GForm2.smethod_10((Control)(object)this);
					num = ((int)num2 * -814028091) ^ 0x5F32A3E8;
					continue;
				case 10u:
					GForm2.smethod_33((Form)(object)this, (FormStartPosition)1);
					GForm2.smethod_34((Form)(object)this, "The Omegle Game");
					num = ((int)num2 * -1649229571) ^ -622800833;
					continue;
				case 9u:
					GForm2.smethod_13((Control)(object)PictureBox_0, new Point(214, 12));
					num = ((int)num2 * -408949379) ^ 0x16E5C59D;
					continue;
				case 8u:
					num = (int)(num2 * 947871618) ^ -1070026977;
					continue;
				case 7u:
					num = ((int)num2 * -1791529058) ^ -216401834;
					continue;
				case 6u:
					GForm2.smethod_16(PictureBox_0, 1);
					num = ((int)num2 * -2129068449) ^ -484607352;
					continue;
				case 5u:
					num = ((int)num2 * -1467644434) ^ -653627019;
					continue;
				case 4u:
					GForm2.smethod_14((Control)(object)PictureBox_4, "PictureBox5");
					num = (int)((num2 * 519711869) ^ 0xC55F8A);
					continue;
				case 3u:
					GForm2.smethod_11((Control)(object)PictureBox_0, Color.Transparent);
					GForm2.smethod_12((Control)(object)PictureBox_0, (ImageLayout)3);
					num = ((int)num2 * -1723321435) ^ 0x7FFB1DBC;
					continue;
				case 2u:
					PictureBox_2 = GForm2.smethod_7();
					num = (int)((num2 * 1766516829) ^ 0x66D1259A);
					continue;
				case 1u:
					GForm2.smethod_13((Control)(object)PictureBox_3, new Point(268, 492));
					num = (int)(num2 * 1147695587) ^ -195425650;
					continue;
				case 0u:
					num = (int)((num2 * 422408460) ^ 0x4FCDB6D9);
					continue;
				default:
					return;
				case 40u:
					break;
				case 84u:
					return;
				}
				break;
			}
		}
	}

	private void method_1(object sender, EventArgs e)
	{
		GForm2.smethod_46(GForm2.smethod_45(), ProcessPriorityClass.RealTime);
		while (true)
		{
			int num = -1666835172;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xED5A5754u) % 11u)
				{
				case 10u:
					GForm2.smethod_50(Timer_0);
					num = (int)((num2 * 2009752961) ^ 0x36CDD479);
					continue;
				case 9u:
					num = (int)((num2 * 1276566600) ^ 0x5628B113);
					continue;
				case 8u:
					num = ((int)num2 * -1043447388) ^ -603627697;
					continue;
				case 6u:
					GForm2.smethod_20((Control)(object)PictureBox_2, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\con_la_cpu_hover.png")));
					num = ((int)num2 * -2001163707) ^ -399904913;
					continue;
				case 4u:
					GForm2.smethod_20((Control)(object)PictureBox_0, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\logo.png")));
					num = ((int)num2 * -611007911) ^ -1791097262;
					continue;
				case 3u:
					GForm2.smethod_20((Control)(object)this, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\main_menu.jpg")));
					num = (int)((num2 * 1068658237) ^ 0x23052726);
					continue;
				case 2u:
					GForm2.smethod_20((Control)(object)PictureBox_4, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\torna_indietro.png")));
					num = (int)((num2 * 383997264) ^ 0x37480302);
					continue;
				case 1u:
					GForm2.smethod_20((Control)(object)PictureBox_1, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\seleziona_una_modalita.png")));
					num = (int)((num2 * 68562564) ^ 0x2A3F2203);
					continue;
				case 0u:
					GForm2.smethod_20((Control)(object)PictureBox_3, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\fai_un_duello.png")));
					num = ((int)num2 * -1940746278) ^ 0x74AFD6B9;
					continue;
				default:
					return;
				case 7u:
					break;
				case 5u:
					return;
				}
				break;
			}
		}
	}

	private void method_2(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 1528975150;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x714B5CAFu) % 4u)
				{
				case 2u:
					num = ((int)num2 * -11040062) ^ -284519720;
					continue;
				case 1u:
					GForm2.smethod_51();
					num = ((int)num2 * -1539485522) ^ -2019149009;
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

	private void method_3(object sender, KeyEventArgs e)
	{
		bool flag = default(bool);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			int num = -1365042612;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8A2A89C3u) % 19u)
				{
				case 16u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -853797594;
						num5 = -853797594;
					}
					else
					{
						num4 = -843749565;
						num5 = -843749565;
					}
					num = num4 ^ (int)(num2 * 192203831);
					continue;
				}
				case 15u:
					num = (int)((num2 * 2016842780) ^ 0x29F7102F);
					continue;
				case 14u:
					num = -1656508276;
					continue;
				case 13u:
					int_0 = 0;
					num = -199334930;
					continue;
				case 12u:
					num = (int)((num2 * 962844271) ^ 0x4594745A);
					continue;
				case 11u:
					int_0 = 1;
					num = (int)(num2 * 166193594) ^ -200718410;
					continue;
				case 10u:
				{
					int num8;
					int num9;
					if (flag2)
					{
						num8 = -1364868936;
						num9 = -1364868936;
					}
					else
					{
						num8 = -640271068;
						num9 = -640271068;
					}
					num = num8 ^ ((int)num2 * -927698579);
					continue;
				}
				case 9u:
					flag3 = (GForm2.smethod_52(e) == 37) | (GForm2.smethod_52(e) == 39);
					num = (int)(num2 * 1619297496) ^ -1938788912;
					continue;
				case 8u:
				{
					int num6;
					int num7;
					if (!flag3)
					{
						num6 = -1561236027;
						num7 = -1561236027;
					}
					else
					{
						num6 = -1954264442;
						num7 = -1954264442;
					}
					num = num6 ^ ((int)num2 * -1529515061);
					continue;
				}
				case 7u:
					num = (int)((num2 * 902543382) ^ 0x5C84F392);
					continue;
				case 6u:
					num = (int)((num2 * 1251279090) ^ 0x74EC0D19);
					continue;
				case 5u:
				{
					int num3;
					if (int_0 == 0)
					{
						num = -40308436;
						num3 = -40308436;
					}
					else
					{
						num = -309837096;
						num3 = -309837096;
					}
					continue;
				}
				case 4u:
					GForm2.smethod_20((Control)(object)PictureBox_2, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\con_gli_altri.png")));
					num = ((int)num2 * -601418109) ^ 0x4F58D4E5;
					continue;
				case 3u:
					flag2 = int_0 == 1;
					num = -639958090;
					continue;
				case 2u:
					GForm2.smethod_20((Control)(object)PictureBox_2, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\con_la_cpu_hover.png")));
					num = (int)(num2 * 1993091159) ^ -29620152;
					continue;
				case 1u:
					flag = int_0 == 0;
					num = ((int)num2 * -1886838883) ^ -1188785859;
					continue;
				case 0u:
					num = (int)((num2 * 1363286054) ^ 0x7033CF99);
					continue;
				default:
					return;
				case 18u:
					break;
				case 17u:
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
		GForm2.smethod_20((Control)(object)PictureBox_3, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\fai_un_duello.png")));
		while (true)
		{
			int num = -234447943;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB5662CA3u) % 3u)
				{
				case 1u:
					goto IL_0021;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0021:
				num = ((int)num2 * -1755954731) ^ 0x35E821B3;
			}
		}
	}

	private void method_6(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -1734872457;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8A66BBE8u) % 3u)
				{
				case 2u:
					goto IL_0003;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0003:
				GForm2.smethod_20((Control)(object)PictureBox_4, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\torna_indietro_hover.png")));
				num = ((int)num2 * -6099858) ^ 0x44BF48E5;
			}
		}
	}

	private void method_7(object sender, EventArgs e)
	{
		GForm2.smethod_20((Control)(object)PictureBox_4, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\torna_indietro.png")));
	}

	private void method_8(object sender, FormClosingEventArgs e)
	{
		while (true)
		{
			int num = 1637205145;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x35EAB0BCu) % 8u)
				{
				case 7u:
					num = (int)(num2 * 1535723252) ^ -472889748;
					continue;
				case 6u:
					num = (int)((num2 * 1772711383) ^ 0x54C36157);
					continue;
				case 5u:
					method_9();
					num = ((int)num2 * -1241410432) ^ -550793077;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (bool_0)
					{
						num3 = -1891179115;
						num4 = -1891179115;
					}
					else
					{
						num3 = -1282605457;
						num4 = -1282605457;
					}
					num = num3 ^ (int)(num2 * 999215982);
					continue;
				}
				case 3u:
					GForm2.smethod_53((CancelEventArgs)(object)e, bool_1: true);
					num = (int)((num2 * 1283177663) ^ 0x4AE63D9F);
					continue;
				case 1u:
					num = 1833053332;
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

	public void method_9()
	{
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Invalid comparison between Unknown and I4
		if (!bool_0)
		{
			goto IL_0231;
		}
		goto IL_02d7;
		IL_02d7:
		int num = -70613314;
		goto IL_0259;
		IL_0259:
		bool flag = default(bool);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xBA8D2A79u) % 27u)
			{
			case 26u:
				num = ((int)num2 * -754032173) ^ -173294636;
				continue;
			case 25u:
				GForm2.smethod_51();
				num = (int)(num2 * 1512394993) ^ -315703363;
				continue;
			case 24u:
				GForm2.smethod_56((object)int_0);
				num = (int)(num2 * 371802297) ^ -144095018;
				continue;
			case 23u:
				GForm2.smethod_56((object)bool_0);
				num = (int)(num2 * 1319552489) ^ -553005906;
				continue;
			case 22u:
				GForm2.smethod_56((object)bool_0);
				num = (int)((num2 * 1874198407) ^ 0x24C10B61);
				continue;
			case 21u:
			{
				int num3;
				int num4;
				if (flag)
				{
					num3 = -626920192;
					num4 = -626920192;
				}
				else
				{
					num3 = -39828984;
					num4 = -39828984;
				}
				num = num3 ^ ((int)num2 * -1808848088);
				continue;
			}
			case 20u:
				num = ((int)num2 * -1124632488) ^ -1196828153;
				continue;
			case 19u:
				num = (int)(num2 * 2118944443) ^ -150257236;
				continue;
			case 18u:
				GForm2.smethod_55(Timer_0);
				num = (int)((num2 * 2077279299) ^ 0x7031C380);
				continue;
			case 17u:
				num = (int)(num2 * 1341390138) ^ -1647711648;
				continue;
			case 16u:
				num = ((int)num2 * -256319370) ^ 0x2003EDBE;
				continue;
			case 15u:
				num = (int)((num2 * 877110701) ^ 0x1ED8295B);
				continue;
			case 14u:
				num = (int)(num2 * 361426644) ^ -486078687;
				continue;
			case 13u:
				flag = (int)GForm2.smethod_54("Sei sicuro di voler uscire dal gioco?", "The Omegle Game", (MessageBoxButtons)4, (MessageBoxIcon)32) == 6;
				num = (int)(num2 * 19673736) ^ -968811292;
				continue;
			case 12u:
				GForm2.smethod_56((object)Timer_0);
				num = ((int)num2 * -712749102) ^ -1834642847;
				continue;
			case 11u:
				num = (int)((num2 * 1080382968) ^ 0x391B2C17);
				continue;
			case 10u:
				num = (int)(num2 * 752395425) ^ -1426167307;
				continue;
			case 9u:
				num = (int)((num2 * 207604235) ^ 0x69995C17);
				continue;
			case 8u:
				GForm2.smethod_56((object)int_0);
				num = (int)((num2 * 1634790716) ^ 0x236A2D25);
				continue;
			case 6u:
				GForm2.smethod_57(GForm2.smethod_45());
				num = ((int)num2 * -827173352) ^ 0x1C6D70E6;
				continue;
			case 5u:
				GForm2.smethod_55(Timer_0);
				GForm2.smethod_56((object)Timer_0);
				num = (int)((num2 * 1818606195) ^ 0x586F4DFD);
				continue;
			case 4u:
				num = -1022263339;
				continue;
			case 3u:
				break;
			case 2u:
				GForm2.smethod_51();
				num = ((int)num2 * -548677255) ^ 0x4AA9F6DF;
				continue;
			case 0u:
				num = ((int)num2 * -654240646) ^ -46301251;
				continue;
			default:
				return;
			case 7u:
				goto IL_02d7;
			case 1u:
				return;
			}
			break;
		}
		goto IL_0231;
		IL_0231:
		num = -711297293;
		goto IL_0259;
	}

	private void method_10(object sender, MouseEventArgs e)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		bool_0 = true;
		while (true)
		{
			int num = -850388263;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC59542CDu) % 3u)
				{
				case 1u:
					goto IL_0009;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0009:
				GForm2.smethod_54("Ci dispiace, ma la modalità duello non è attualmente disponibile.", "The Omegle Game", (MessageBoxButtons)0, (MessageBoxIcon)48);
				num = ((int)num2 * -298106884) ^ -15363862;
			}
		}
	}

	private void method_11(object sender, MouseEventArgs e)
	{
		while (true)
		{
			int num = 454122842;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x316749CCu) % 4u)
				{
				case 2u:
					bool_0 = true;
					GForm2.smethod_58((Control)(object)Class2.Class3_0.GForm1_0);
					num = ((int)num2 * -1572741381) ^ 0x7D0DFE73;
					continue;
				case 1u:
					GForm2.smethod_59((Form)(object)this);
					num = ((int)num2 * -104851606) ^ 0x38176A36;
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
