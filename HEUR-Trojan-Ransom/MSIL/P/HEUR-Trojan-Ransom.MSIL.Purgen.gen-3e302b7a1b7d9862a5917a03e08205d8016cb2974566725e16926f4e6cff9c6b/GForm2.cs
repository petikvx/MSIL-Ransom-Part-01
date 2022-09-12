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
				int num = -1161782615;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBC99F374u) % 8u)
					{
					case 6u:
						GForm2.smethod_38(val, eventHandler_);
						num = ((int)num2 * -125434751) ^ 0xBF62AE5;
						continue;
					case 5u:
						val = timer_0;
						num = (int)(num2 * 192700867) ^ -2146455973;
						continue;
					case 4u:
						GForm2.smethod_37(val, eventHandler_);
						num = ((int)num2 * -589359235) ^ -1369375629;
						continue;
					case 3u:
						timer_0 = value;
						num = -1709608915;
						continue;
					case 1u:
					{
						val = timer_0;
						int num5;
						int num6;
						if (val == null)
						{
							num5 = -1029289469;
							num6 = -1029289469;
						}
						else
						{
							num5 = -335575918;
							num6 = -335575918;
						}
						num = num5 ^ ((int)num2 * -938163392);
						continue;
					}
					case 0u:
					{
						int num3;
						int num4;
						if (val != null)
						{
							num3 = 2017663560;
							num4 = 2017663560;
						}
						else
						{
							num3 = 752202239;
							num4 = 752202239;
						}
						num = num3 ^ (int)(num2 * 351684660);
						continue;
					}
					default:
						return;
					case 2u:
						break;
					case 7u:
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
			//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Expected O, but got Unknown
			EventHandler eventHandler_ = method_4;
			EventHandler eventHandler_2 = method_5;
			PictureBox val = default(PictureBox);
			MouseEventHandler mouseEventHandler_ = default(MouseEventHandler);
			while (true)
			{
				int num = -2064527839;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9D8B3C86u) % 11u)
					{
					case 10u:
						GForm2.smethod_39((Control)(object)val, eventHandler_);
						num = ((int)num2 * -495864536) ^ 0x1B7116CB;
						continue;
					case 9u:
						GForm2.smethod_41((Control)(object)val, mouseEventHandler_);
						num = (int)(num2 * 35393316) ^ -321541986;
						continue;
					case 8u:
						pictureBox_3 = value;
						val = pictureBox_3;
						num = -1150985504;
						continue;
					case 7u:
						GForm2.smethod_40((Control)(object)val, eventHandler_2);
						num = ((int)num2 * -321114025) ^ 0x47896F2A;
						continue;
					case 6u:
					{
						val = pictureBox_3;
						int num5;
						int num6;
						if (val == null)
						{
							num5 = 850328802;
							num6 = 850328802;
						}
						else
						{
							num5 = 529970947;
							num6 = 529970947;
						}
						num = num5 ^ ((int)num2 * -1041738544);
						continue;
					}
					case 4u:
						mouseEventHandler_ = new MouseEventHandler(method_10);
						num = ((int)num2 * -1763812103) ^ -1169372013;
						continue;
					case 2u:
						GForm2.smethod_42((Control)(object)val, eventHandler_);
						GForm2.smethod_43((Control)(object)val, eventHandler_2);
						num = ((int)num2 * -1095246423) ^ 0x4E2ECF44;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (val != null)
						{
							num3 = 1180080260;
							num4 = 1180080260;
						}
						else
						{
							num3 = 1138959656;
							num4 = 1138959656;
						}
						num = num3 ^ ((int)num2 * -707565518);
						continue;
					}
					case 0u:
						GForm2.smethod_44((Control)(object)val, mouseEventHandler_);
						num = (int)(num2 * 929183778) ^ -211620356;
						continue;
					default:
						return;
					case 3u:
						break;
					case 5u:
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
			//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Expected O, but got Unknown
			EventHandler eventHandler_ = method_6;
			PictureBox val = default(PictureBox);
			EventHandler eventHandler_2 = default(EventHandler);
			MouseEventHandler mouseEventHandler_ = default(MouseEventHandler);
			while (true)
			{
				int num = -41663297;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEF97999Du) % 11u)
					{
					case 9u:
						GForm2.smethod_42((Control)(object)val, eventHandler_);
						num = (int)(num2 * 825876109) ^ -1004912991;
						continue;
					case 8u:
						val = pictureBox_4;
						num = ((int)num2 * -1918479195) ^ 0x4252CC43;
						continue;
					case 7u:
						pictureBox_4 = value;
						num = -1057230074;
						continue;
					case 5u:
					{
						int num5;
						int num6;
						if (val == null)
						{
							num5 = -645999202;
							num6 = -645999202;
						}
						else
						{
							num5 = -859030208;
							num6 = -859030208;
						}
						num = num5 ^ ((int)num2 * -2019588525);
						continue;
					}
					case 4u:
					{
						int num3;
						int num4;
						if (val != null)
						{
							num3 = -1430928193;
							num4 = -1430928193;
						}
						else
						{
							num3 = -1082633169;
							num4 = -1082633169;
						}
						num = num3 ^ ((int)num2 * -104311750);
						continue;
					}
					case 3u:
						GForm2.smethod_40((Control)(object)val, eventHandler_2);
						GForm2.smethod_41((Control)(object)val, mouseEventHandler_);
						num = ((int)num2 * -1159872313) ^ 0x9440FDF;
						continue;
					case 2u:
						GForm2.smethod_43((Control)(object)val, eventHandler_2);
						GForm2.smethod_44((Control)(object)val, mouseEventHandler_);
						num = (int)((num2 * 1635379225) ^ 0x27E3B531);
						continue;
					case 1u:
						eventHandler_2 = method_7;
						mouseEventHandler_ = new MouseEventHandler(method_11);
						val = pictureBox_4;
						num = ((int)num2 * -1210855237) ^ 0x3AB165AF;
						continue;
					case 0u:
						GForm2.smethod_39((Control)(object)val, eventHandler_);
						num = ((int)num2 * -2017172851) ^ 0x56A9DD8B;
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
	}

	public GForm2()
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		while (true)
		{
			int num = 385558177;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF7D2D64u) % 9u)
				{
				case 7u:
					GForm2.smethod_0((Form)(object)this, (EventHandler)method_1);
					num = ((int)num2 * -2121830145) ^ -591612620;
					continue;
				case 6u:
					num = ((int)num2 * -176300649) ^ -1559720321;
					continue;
				case 5u:
					method_0();
					num = ((int)num2 * -705133161) ^ -576195459;
					continue;
				case 4u:
					int_0 = 0;
					num = (int)(num2 * 380412263) ^ -96530202;
					continue;
				case 3u:
					GForm2.smethod_1((Control)(object)this, new KeyEventHandler(method_3));
					num = (int)(num2 * 806174659) ^ -927540325;
					continue;
				case 1u:
					GForm2.smethod_2((Form)(object)this, new FormClosingEventHandler(method_8));
					num = (int)(num2 * 315440487) ^ -1820098918;
					continue;
				case 0u:
					bool_0 = false;
					num = ((int)num2 * -2077002981) ^ -1193867441;
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

	[DebuggerNonUserCode]
	void Form.Dispose(bool disposing)
	{
		try
		{
			if (!disposing)
			{
				goto IL_000a;
			}
			goto IL_0017;
			IL_0017:
			int num = 1677083305;
			goto IL_005b;
			IL_005b:
			int num3;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2E1A8B87u) % 7u)
				{
				case 5u:
					break;
				case 3u:
					num = ((int)num2 * -2137246648) ^ 0x26D045EA;
					continue;
				case 2u:
					num = (int)((num2 * 1385174073) ^ 0x364F3E67);
					continue;
				case 1u:
					GForm2.smethod_3((IDisposable)icontainer_0);
					num = (int)((num2 * 178432778) ^ 0x3D9D66B9);
					continue;
				case 0u:
					num = 699527183;
					continue;
				default:
					return;
				case 6u:
					goto IL_0088;
				case 4u:
					return;
				}
				break;
				IL_0088:
				if (icontainer_0 != null)
				{
					num = 1769766747;
					num3 = 1769766747;
					continue;
				}
				goto IL_000a;
			}
			goto IL_0017;
			IL_000a:
			num = 769207122;
			num3 = 769207122;
			goto IL_005b;
		}
		finally
		{
			while (true)
			{
				IL_00df:
				int num4 = 119895096;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num4 ^ 0x2E1A8B87u) % 3u)
					{
					case 1u:
						goto IL_00ae;
					default:
						goto end_IL_00c2;
					case 2u:
						break;
					case 0u:
						goto end_IL_00c2;
					}
					goto IL_00df;
					IL_00ae:
					((Form)this).Dispose(disposing);
					num4 = ((int)num2 * -342622598) ^ 0x693F9C72;
					continue;
					end_IL_00c2:
					break;
				}
				break;
			}
		}
	}

	[DebuggerStepThrough]
	private void method_0()
	{
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected O, but got Unknown
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_0699: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a3: Expected O, but got Unknown
		ComponentResourceManager resourceManager_ = default(ComponentResourceManager);
		while (true)
		{
			int num = -1059274041;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE1F30598u) % 94u)
				{
				case 93u:
					GForm2.smethod_11((Control)(object)PictureBox_2, Color.Transparent);
					num = (int)((num2 * 2012804858) ^ 0x230DF54B);
					continue;
				case 92u:
					num = ((int)num2 * -1869530563) ^ -831207799;
					continue;
				case 91u:
					GForm2.smethod_21((ContainerControl)(object)this, new SizeF(10f, 22f));
					num = (int)(num2 * 1272227728) ^ -1833394689;
					continue;
				case 90u:
					GForm2.smethod_15((Control)(object)PictureBox_3, new Size(504, 57));
					num = (int)(num2 * 1178438073) ^ -2144823191;
					continue;
				case 89u:
					GForm2.smethod_35((ISupportInitialize)PictureBox_1);
					num = ((int)num2 * -1545347159) ^ -1363869228;
					continue;
				case 88u:
					GForm2.smethod_17(PictureBox_0, bool_1: false);
					num = (int)(num2 * 265281221) ^ -240090514;
					continue;
				case 87u:
					GForm2.smethod_12((Control)(object)PictureBox_1, (ImageLayout)3);
					num = (int)((num2 * 2108565995) ^ 0x320BA464);
					continue;
				case 86u:
					num = (int)((num2 * 1279188305) ^ 0x688C9BA0);
					continue;
				case 85u:
					num = ((int)num2 * -809882622) ^ -856925117;
					continue;
				case 84u:
					GForm2.smethod_29((Form)(object)this, (FormBorderStyle)1);
					num = (int)(num2 * 51360400) ^ -742355883;
					continue;
				case 83u:
					PictureBox_1 = GForm2.smethod_7();
					num = ((int)num2 * -1251143088) ^ 0x54F07CDD;
					continue;
				case 82u:
					GForm2.smethod_33((Form)(object)this, (FormStartPosition)1);
					num = ((int)num2 * -1859905891) ^ -1424064166;
					continue;
				case 81u:
					num = (int)(num2 * 1352057011) ^ -1562069593;
					continue;
				case 80u:
					GForm2.smethod_14((Control)(object)PictureBox_3, "PictureBox4");
					num = (int)(num2 * 676382155) ^ -1482626625;
					continue;
				case 79u:
					GForm2.smethod_17(PictureBox_1, bool_1: false);
					num = ((int)num2 * -1564236042) ^ -1111252217;
					continue;
				case 78u:
					num = ((int)num2 * -586827011) ^ -89434948;
					continue;
				case 77u:
					GForm2.smethod_11((Control)(object)PictureBox_3, Color.Transparent);
					GForm2.smethod_20((Control)(object)PictureBox_3, (Image)GForm2.smethod_19((ResourceManager)resourceManager_, "PictureBox4.BackgroundImage"));
					num = ((int)num2 * -1945111590) ^ -927672875;
					continue;
				case 76u:
					num = ((int)num2 * -1905356397) ^ -1624159713;
					continue;
				case 75u:
					GForm2.smethod_26(GForm2.smethod_25((Control)(object)this), (Control)(object)PictureBox_0);
					num = ((int)num2 * -1945318004) ^ 0x5E709515;
					continue;
				case 74u:
					GForm2.smethod_16(PictureBox_0, 1);
					num = (int)((num2 * 1134675891) ^ 0x56EB764A);
					continue;
				case 73u:
					GForm2.smethod_16(PictureBox_3, 4);
					num = (int)((num2 * 171926462) ^ 0x75DEE5FC);
					continue;
				case 72u:
					GForm2.smethod_14((Control)(object)PictureBox_4, "PictureBox5");
					num = ((int)num2 * -121610650) ^ -2142570450;
					continue;
				case 71u:
					GForm2.smethod_9((ISupportInitialize)PictureBox_1);
					num = (int)((num2 * 26750159) ^ 0x6C08F5F5);
					continue;
				case 70u:
					GForm2.smethod_11((Control)(object)PictureBox_0, Color.Transparent);
					num = ((int)num2 * -1029078765) ^ 0x2CD1DB16;
					continue;
				case 69u:
					num = (int)(num2 * 639018414) ^ -1145533233;
					continue;
				case 68u:
					GForm2.smethod_12((Control)(object)this, (ImageLayout)3);
					num = (int)((num2 * 14157921) ^ 0x74A7907A);
					continue;
				case 67u:
					GForm2.smethod_13((Control)(object)PictureBox_4, new Point(268, 555));
					num = (int)(num2 * 1719943911) ^ -706650997;
					continue;
				case 66u:
					GForm2.smethod_26(GForm2.smethod_25((Control)(object)this), (Control)(object)PictureBox_1);
					num = (int)((num2 * 147661370) ^ 0x60D7C423);
					continue;
				case 65u:
					GForm2.smethod_14((Control)(object)PictureBox_0, "PictureBox1");
					num = ((int)num2 * -1641084363) ^ -2014923657;
					continue;
				case 64u:
					num = (int)(num2 * 562235084) ^ -1089712140;
					continue;
				case 63u:
					icontainer_0 = GForm2.smethod_4();
					num = (int)(num2 * 747350774) ^ -1773618529;
					continue;
				case 62u:
					num = ((int)num2 * -586258608) ^ -1079870945;
					continue;
				case 61u:
					num = ((int)num2 * -1829850017) ^ 0x781A8E11;
					continue;
				case 60u:
					GForm2.smethod_9((ISupportInitialize)PictureBox_3);
					num = (int)(num2 * 941538990) ^ -1412292550;
					continue;
				case 59u:
					GForm2.smethod_16(PictureBox_1, 2);
					num = (int)((num2 * 1997588057) ^ 0x6171038E);
					continue;
				case 58u:
					GForm2.smethod_9((ISupportInitialize)PictureBox_4);
					num = (int)((num2 * 1152711397) ^ 0x6E51C4D5);
					continue;
				case 57u:
					resourceManager_ = GForm2.smethod_6(GForm2.smethod_5(typeof(GForm2).TypeHandle));
					num = (int)((num2 * 1320554291) ^ 0x24B33B1E);
					continue;
				case 56u:
					num = (int)(num2 * 1402756346) ^ -1877884798;
					continue;
				case 55u:
					GForm2.smethod_30((Form)(object)this, new Padding(4));
					GForm2.smethod_31((Form)(object)this, bool_1: false);
					GForm2.smethod_32((Control)(object)this, "SelectDuelType");
					num = ((int)num2 * -2049226878) ^ -991574822;
					continue;
				case 54u:
					num = (int)(num2 * 1867687677) ^ -1832598022;
					continue;
				case 53u:
					GForm2.smethod_35((ISupportInitialize)PictureBox_2);
					num = (int)((num2 * 1945774502) ^ 0xC258705);
					continue;
				case 52u:
					num = ((int)num2 * -1079600943) ^ -1591567794;
					continue;
				case 51u:
					GForm2.smethod_18(Timer_0, 1000);
					GForm2.smethod_11((Control)(object)PictureBox_1, Color.Transparent);
					num = ((int)num2 * -1451683551) ^ 0x4E3FC332;
					continue;
				case 50u:
					GForm2.smethod_23((Form)(object)this, Color.White);
					num = (int)((num2 * 221136587) ^ 0xD9E534D);
					continue;
				case 49u:
					num = ((int)num2 * -1397276331) ^ -2024504184;
					continue;
				case 48u:
					GForm2.smethod_10((Control)(object)this);
					num = ((int)num2 * -232981556) ^ 0x455D096C;
					continue;
				case 46u:
					num = (int)((num2 * 1102422406) ^ 0x53261BAF);
					continue;
				case 45u:
					GForm2.smethod_9((ISupportInitialize)PictureBox_0);
					num = ((int)num2 * -1389227990) ^ 0x51C819A3;
					continue;
				case 43u:
					GForm2.smethod_12((Control)(object)PictureBox_3, (ImageLayout)3);
					GForm2.smethod_13((Control)(object)PictureBox_3, new Point(268, 492));
					num = (int)((num2 * 330025663) ^ 0x3D8F7335);
					continue;
				case 42u:
					GForm2.smethod_12((Control)(object)PictureBox_0, (ImageLayout)3);
					num = ((int)num2 * -1656257429) ^ 0x165D188A;
					continue;
				case 41u:
					num = (int)((num2 * 1641517394) ^ 0x47A7054E);
					continue;
				case 40u:
					num = (int)(num2 * 384293476) ^ -272040609;
					continue;
				case 39u:
					GForm2.smethod_15((Control)(object)PictureBox_2, new Size(353, 42));
					num = ((int)num2 * -879334273) ^ -1628511428;
					continue;
				case 38u:
					GForm2.smethod_13((Control)(object)PictureBox_0, new Point(214, 12));
					num = ((int)num2 * -1794670705) ^ 0x51562527;
					continue;
				case 37u:
					GForm2.smethod_12((Control)(object)PictureBox_2, (ImageLayout)3);
					num = (int)((num2 * 770887990) ^ 0x60F9FFBC);
					continue;
				case 36u:
					num = ((int)num2 * -630377424) ^ -140392189;
					continue;
				case 35u:
					GForm2.smethod_35((ISupportInitialize)PictureBox_0);
					num = ((int)num2 * -319963377) ^ -1884589153;
					continue;
				case 34u:
					num = (int)((num2 * 268599909) ^ 0x41330572);
					continue;
				case 33u:
					GForm2.smethod_20((Control)(object)PictureBox_4, (Image)GForm2.smethod_19((ResourceManager)resourceManager_, "PictureBox5.BackgroundImage"));
					num = ((int)num2 * -1313113174) ^ -1795820045;
					continue;
				case 32u:
					num = ((int)num2 * -1884037479) ^ 0x6583B21F;
					continue;
				case 31u:
					((Control)this).set_DoubleBuffered(true);
					num = ((int)num2 * -1019956597) ^ 0x650AF4B8;
					continue;
				case 30u:
					GForm2.smethod_26(GForm2.smethod_25((Control)(object)this), (Control)(object)PictureBox_2);
					num = ((int)num2 * -306402196) ^ -1167207470;
					continue;
				case 29u:
					PictureBox_3 = GForm2.smethod_7();
					num = ((int)num2 * -12940261) ^ -680388597;
					continue;
				case 28u:
					GForm2.smethod_9((ISupportInitialize)PictureBox_2);
					num = (int)((num2 * 532033448) ^ 0x1DE08372);
					continue;
				case 27u:
					GForm2.smethod_17(PictureBox_2, bool_1: false);
					num = (int)(num2 * 1735563203) ^ -361835528;
					continue;
				case 26u:
					num = (int)(num2 * 496432525) ^ -758433804;
					continue;
				case 25u:
					num = (int)((num2 * 1282665770) ^ 0x1FF346B2);
					continue;
				case 24u:
					GForm2.smethod_13((Control)(object)PictureBox_2, new Point(338, 306));
					num = ((int)num2 * -2080578175) ^ 0x5E2D2CE9;
					continue;
				case 23u:
					PictureBox_2 = GForm2.smethod_7();
					num = ((int)num2 * -1577714041) ^ 0x7F7C6356;
					continue;
				case 22u:
					GForm2.smethod_34((Form)(object)this, "The Omegle Game");
					num = (int)(num2 * 416607486) ^ -661049042;
					continue;
				case 21u:
					PictureBox_0 = GForm2.smethod_7();
					num = (int)(num2 * 162682541) ^ -323556105;
					continue;
				case 20u:
					GForm2.smethod_15((Control)(object)PictureBox_4, new Size(504, 57));
					num = ((int)num2 * -461794373) ^ 0x3D047F9A;
					continue;
				case 19u:
					PictureBox_4 = GForm2.smethod_7();
					num = (int)((num2 * 699404816) ^ 0x1557E06C);
					continue;
				case 18u:
					num = (int)((num2 * 627371800) ^ 0x3353167E);
					continue;
				case 17u:
					GForm2.smethod_28((Control)(object)this, GForm2.smethod_27("Consolas", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1196439110) ^ 0x2774F44A);
					continue;
				case 16u:
					GForm2.smethod_35((ISupportInitialize)PictureBox_4);
					GForm2.smethod_36((Control)(object)this, bool_1: false);
					num = ((int)num2 * -1245638426) ^ -353531685;
					continue;
				case 15u:
					GForm2.smethod_22((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -231015200) ^ 0x2C654DDC;
					continue;
				case 14u:
					GForm2.smethod_26(GForm2.smethod_25((Control)(object)this), (Control)(object)PictureBox_4);
					num = (int)(num2 * 68011213) ^ -38162597;
					continue;
				case 13u:
					num = ((int)num2 * -530281546) ^ -1404720316;
					continue;
				case 12u:
					GForm2.smethod_17(PictureBox_3, bool_1: false);
					GForm2.smethod_11((Control)(object)PictureBox_4, Color.Transparent);
					num = (int)(num2 * 1432581288) ^ -260046275;
					continue;
				case 11u:
					GForm2.smethod_12((Control)(object)PictureBox_4, (ImageLayout)3);
					num = ((int)num2 * -1663968331) ^ -832313316;
					continue;
				case 10u:
					GForm2.smethod_26(GForm2.smethod_25((Control)(object)this), (Control)(object)PictureBox_3);
					num = ((int)num2 * -1445539867) ^ 0x59E24AF8;
					continue;
				case 9u:
					GForm2.smethod_14((Control)(object)PictureBox_2, "PictureBox3");
					num = (int)(num2 * 97714694) ^ -949674854;
					continue;
				case 8u:
					GForm2.smethod_24((Form)(object)this, new Size(1025, 638));
					num = (int)((num2 * 1502668089) ^ 0x4423FDDB);
					continue;
				case 7u:
					GForm2.smethod_16(PictureBox_2, 3);
					num = ((int)num2 * -68950457) ^ 0x79B808F4;
					continue;
				case 6u:
					GForm2.smethod_16(PictureBox_4, 5);
					GForm2.smethod_17(PictureBox_4, bool_1: false);
					num = ((int)num2 * -713631858) ^ -28703374;
					continue;
				case 5u:
					GForm2.smethod_35((ISupportInitialize)PictureBox_3);
					num = (int)(num2 * 1675589873) ^ -1007965629;
					continue;
				case 4u:
					GForm2.smethod_15((Control)(object)PictureBox_0, new Size(617, 69));
					num = ((int)num2 * -1696053230) ^ -241391302;
					continue;
				case 3u:
					GForm2.smethod_13((Control)(object)PictureBox_1, new Point(268, 168));
					num = (int)(num2 * 2126154606) ^ -2012326795;
					continue;
				case 2u:
					Timer_0 = GForm2.smethod_8(icontainer_0);
					num = (int)(num2 * 215623844) ^ -95479557;
					continue;
				case 1u:
					GForm2.smethod_14((Control)(object)PictureBox_1, "PictureBox2");
					num = (int)(num2 * 603051588) ^ -304972112;
					continue;
				case 0u:
					GForm2.smethod_15((Control)(object)PictureBox_1, new Size(504, 57));
					num = (int)(num2 * 1779047303) ^ -1046441483;
					continue;
				default:
					return;
				case 44u:
					break;
				case 47u:
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
			int num = -1068331908;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA2280FD4u) % 9u)
				{
				case 7u:
					GForm2.smethod_20((Control)(object)this, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\main_menu.jpg")));
					GForm2.smethod_20((Control)(object)PictureBox_0, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\logo.png")));
					GForm2.smethod_20((Control)(object)PictureBox_1, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\seleziona_una_modalita.png")));
					num = ((int)num2 * -1086058677) ^ 0x294FB56B;
					continue;
				case 6u:
					GForm2.smethod_46(GForm2.smethod_45(), ProcessPriorityClass.RealTime);
					num = ((int)num2 * -1149313950) ^ 0x39F2CF57;
					continue;
				case 5u:
					GForm2.smethod_20((Control)(object)PictureBox_4, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\torna_indietro.png")));
					num = (int)((num2 * 407878407) ^ 0xF5CED1F);
					continue;
				case 4u:
					num = ((int)num2 * -672540854) ^ 0x7C5D5EE1;
					continue;
				case 3u:
					GForm2.smethod_20((Control)(object)PictureBox_3, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\fai_un_duello.png")));
					num = (int)(num2 * 1742602579) ^ -609121106;
					continue;
				case 1u:
					GForm2.smethod_20((Control)(object)PictureBox_2, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\con_la_cpu_hover.png")));
					num = ((int)num2 * -280531128) ^ -1223482882;
					continue;
				case 0u:
					GForm2.smethod_50(Timer_0);
					num = ((int)num2 * -564846423) ^ 0x3BA682EB;
					continue;
				default:
					return;
				case 2u:
					break;
				case 8u:
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
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 1411661300;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7508F381u) % 16u)
				{
				case 15u:
					GForm2.smethod_20((Control)(object)PictureBox_2, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\con_gli_altri.png")));
					num = (int)(num2 * 265609152) ^ -1303044707;
					continue;
				case 13u:
					num = 773188810;
					continue;
				case 11u:
					flag2 = int_0 == 0;
					num = 1186848630;
					continue;
				case 10u:
					num = (int)((num2 * 834612884) ^ 0x6FDCC1F4);
					continue;
				case 9u:
				{
					int num7;
					int num8;
					if (int_0 != 0)
					{
						num7 = -1025240740;
						num8 = -1025240740;
					}
					else
					{
						num7 = -662803222;
						num8 = -662803222;
					}
					num = num7 ^ ((int)num2 * -1803513433);
					continue;
				}
				case 8u:
					num = ((int)num2 * -579235808) ^ -700994851;
					continue;
				case 7u:
				{
					int num9;
					int num10;
					if (!flag2)
					{
						num9 = -2123136481;
						num10 = -2123136481;
					}
					else
					{
						num9 = -2014486951;
						num10 = -2014486951;
					}
					num = num9 ^ ((int)num2 * -1102237182);
					continue;
				}
				case 6u:
					GForm2.smethod_20((Control)(object)PictureBox_2, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\con_la_cpu_hover.png")));
					num = ((int)num2 * -437715683) ^ -801794713;
					continue;
				case 5u:
				{
					int num5;
					int num6;
					if ((GForm2.smethod_52(e) == 37) | (GForm2.smethod_52(e) == 39))
					{
						num5 = 1894419138;
						num6 = 1894419138;
					}
					else
					{
						num5 = 313097456;
						num6 = 313097456;
					}
					num = num5 ^ ((int)num2 * -212575214);
					continue;
				}
				case 4u:
					int_0 = 1;
					num = ((int)num2 * -1595719361) ^ 0x3ED0E40;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 374851926;
						num4 = 374851926;
					}
					else
					{
						num3 = 2139771093;
						num4 = 2139771093;
					}
					num = num3 ^ ((int)num2 * -28003911);
					continue;
				}
				case 2u:
					num = 2097965264;
					continue;
				case 1u:
					int_0 = 0;
					num = ((int)num2 * -2096983838) ^ 0x56061FC9;
					continue;
				case 0u:
					flag = int_0 == 1;
					num = 2101387746;
					continue;
				default:
					return;
				case 14u:
					break;
				case 12u:
					return;
				}
				break;
			}
		}
	}

	private void method_4(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -1868154128;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEB11DFBCu) % 3u)
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
				GForm2.smethod_20((Control)(object)PictureBox_3, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\fai_un_duello_hover.png")));
				num = (int)((num2 * 2011579203) ^ 0x3B1E5CF);
			}
		}
	}

	private void method_5(object sender, EventArgs e)
	{
		GForm2.smethod_20((Control)(object)PictureBox_3, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\fai_un_duello.png")));
	}

	private void method_6(object sender, EventArgs e)
	{
		GForm2.smethod_20((Control)(object)PictureBox_4, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\torna_indietro_hover.png")));
		while (true)
		{
			int num = 89422815;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFEB14EEu) % 3u)
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
				num = ((int)num2 * -350374894) ^ -674652275;
			}
		}
	}

	private void method_7(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 845861054;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3F371237u) % 4u)
				{
				case 1u:
					GForm2.smethod_20((Control)(object)PictureBox_4, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\torna_indietro.png")));
					num = ((int)num2 * -355920444) ^ -1877385229;
					continue;
				case 0u:
					num = ((int)num2 * -1686834758) ^ 0x58173B3C;
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

	private void method_8(object sender, FormClosingEventArgs e)
	{
		method_9();
		while (true)
		{
			int num = 201567249;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2504EB5Cu) % 5u)
				{
				case 3u:
					num = 1196749054;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!bool_0)
					{
						num3 = 1789585910;
						num4 = 1789585910;
					}
					else
					{
						num3 = 793369136;
						num4 = 793369136;
					}
					num = num3 ^ ((int)num2 * -180793141);
					continue;
				}
				case 0u:
					GForm2.smethod_53((CancelEventArgs)(object)e, bool_1: true);
					num = ((int)num2 * -528781289) ^ -832854292;
					continue;
				default:
					return;
				case 4u:
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
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Invalid comparison between Unknown and I4
		bool flag = default(bool);
		while (true)
		{
			int num = -1221614656;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE6DCFB15u) % 26u)
				{
				case 25u:
					num = ((int)num2 * -1654106790) ^ -988741869;
					continue;
				case 24u:
					GForm2.smethod_57(GForm2.smethod_45());
					num = ((int)num2 * -1724389199) ^ 0x6AC8F524;
					continue;
				case 23u:
					num = -1649983390;
					continue;
				case 22u:
					num = ((int)num2 * -1029276066) ^ 0x51373CC7;
					continue;
				case 21u:
				{
					int num5;
					int num6;
					if (!bool_0)
					{
						num5 = 1466538550;
						num6 = 1466538550;
					}
					else
					{
						num5 = 239360933;
						num6 = 239360933;
					}
					num = num5 ^ ((int)num2 * -1773450647);
					continue;
				}
				case 20u:
					num = ((int)num2 * -326004552) ^ -1997922914;
					continue;
				case 19u:
					GForm2.smethod_55(Timer_0);
					num = (int)((num2 * 159981279) ^ 0x4419C29A);
					continue;
				case 18u:
					num = ((int)num2 * -946369968) ^ 0x23F4F506;
					continue;
				case 17u:
					num = (int)((num2 * 1443679839) ^ 0x77DBF186);
					continue;
				case 16u:
					GForm2.smethod_56((object)int_0);
					num = ((int)num2 * -1460380194) ^ -1640032008;
					continue;
				case 15u:
					GForm2.smethod_56((object)bool_0);
					num = ((int)num2 * -1250369619) ^ 0x5E066397;
					continue;
				case 14u:
					GForm2.smethod_56((object)int_0);
					num = ((int)num2 * -1148608766) ^ 0x16E8AEC0;
					continue;
				case 13u:
					GForm2.smethod_56((object)bool_0);
					num = ((int)num2 * -1678342617) ^ -1536625992;
					continue;
				case 12u:
					GForm2.smethod_51();
					num = (int)(num2 * 144662251) ^ -647253649;
					continue;
				case 11u:
					num = ((int)num2 * -1855209157) ^ 0x3F44A244;
					continue;
				case 10u:
					GForm2.smethod_56((object)Timer_0);
					num = ((int)num2 * -569840421) ^ -594763603;
					continue;
				case 9u:
					num = ((int)num2 * -1421333949) ^ -2011022697;
					continue;
				case 8u:
					GForm2.smethod_51();
					num = (int)((num2 * 176350436) ^ 0x4B470DCC);
					continue;
				case 6u:
					num = (int)(num2 * 1911826780) ^ -826557654;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1476671185;
						num4 = -1476671185;
					}
					else
					{
						num3 = -1497129958;
						num4 = -1497129958;
					}
					num = num3 ^ ((int)num2 * -462030471);
					continue;
				}
				case 4u:
					num = (int)((num2 * 85345031) ^ 0x75E6569D);
					continue;
				case 3u:
					num = -1740128349;
					continue;
				case 2u:
					flag = (int)GForm2.smethod_54("Sei sicuro di voler uscire dal gioco?", "The Omegle Game", (MessageBoxButtons)4, (MessageBoxIcon)32) == 6;
					num = (int)((num2 * 1891250945) ^ 0x31E7309E);
					continue;
				case 0u:
					GForm2.smethod_55(Timer_0);
					GForm2.smethod_56((object)Timer_0);
					num = ((int)num2 * -1845135456) ^ 0x2E892E57;
					continue;
				default:
					return;
				case 7u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	private void method_10(object sender, MouseEventArgs e)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		bool_0 = true;
		while (true)
		{
			int num = -2018006164;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAE2D41FBu) % 3u)
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
				num = ((int)num2 * -147452431) ^ -1597043880;
			}
		}
	}

	private void method_11(object sender, MouseEventArgs e)
	{
		bool_0 = true;
		while (true)
		{
			int num = 1467557000;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3053403Bu) % 4u)
				{
				case 3u:
					GForm2.smethod_58((Control)(object)Class2.Class3_0.GForm1_0);
					GForm2.smethod_59((Form)(object)this);
					num = ((int)num2 * -953817624) ^ 0x7848611B;
					continue;
				case 0u:
					num = (int)((num2 * 1126449310) ^ 0x68C4C33E);
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
