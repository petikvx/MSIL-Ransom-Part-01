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
				int num = 1688907811;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1D02959Eu) % 7u)
					{
					case 6u:
						timer_0 = value;
						val = timer_0;
						num = 1519280827;
						continue;
					case 4u:
					{
						int num5;
						int num6;
						if (val != null)
						{
							num5 = 1107674491;
							num6 = 1107674491;
						}
						else
						{
							num5 = 899930072;
							num6 = 899930072;
						}
						num = num5 ^ ((int)num2 * -1365839581);
						continue;
					}
					case 3u:
					{
						val = timer_0;
						int num3;
						int num4;
						if (val != null)
						{
							num3 = -960020008;
							num4 = -960020008;
						}
						else
						{
							num3 = -768141105;
							num4 = -768141105;
						}
						num = num3 ^ ((int)num2 * -906100014);
						continue;
					}
					case 1u:
						GForm2.smethod_38(val, eventHandler_);
						num = ((int)num2 * -1094139041) ^ -1264833279;
						continue;
					case 0u:
						GForm2.smethod_37(val, eventHandler_);
						num = ((int)num2 * -1744099862) ^ 0x5F6458BD;
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
				int num = -421609500;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x843344E4u) % 11u)
					{
					case 10u:
						eventHandler_2 = method_5;
						mouseEventHandler_ = new MouseEventHandler(method_10);
						val = pictureBox_3;
						num = (int)(num2 * 1790378648) ^ -350826224;
						continue;
					case 9u:
						pictureBox_3 = value;
						val = pictureBox_3;
						num = -2067118460;
						continue;
					case 8u:
						GForm2.smethod_40((Control)(object)val, eventHandler_2);
						num = (int)(num2 * 744413747) ^ -303911588;
						continue;
					case 5u:
						GForm2.smethod_43((Control)(object)val, eventHandler_2);
						GForm2.smethod_44((Control)(object)val, mouseEventHandler_);
						num = (int)((num2 * 301667080) ^ 0x838C3AD);
						continue;
					case 4u:
						GForm2.smethod_42((Control)(object)val, eventHandler_);
						num = ((int)num2 * -297188728) ^ 0x780BC99C;
						continue;
					case 3u:
						GForm2.smethod_39((Control)(object)val, eventHandler_);
						num = ((int)num2 * -652149319) ^ -1840262908;
						continue;
					case 2u:
					{
						int num5;
						int num6;
						if (val == null)
						{
							num5 = -1409278601;
							num6 = -1409278601;
						}
						else
						{
							num5 = -1705738282;
							num6 = -1705738282;
						}
						num = num5 ^ ((int)num2 * -988732007);
						continue;
					}
					case 1u:
						GForm2.smethod_41((Control)(object)val, mouseEventHandler_);
						num = (int)(num2 * 238576468) ^ -1641310933;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (val == null)
						{
							num3 = 1940790029;
							num4 = 1940790029;
						}
						else
						{
							num3 = 29970404;
							num4 = 29970404;
						}
						num = num3 ^ (int)(num2 * 271632601);
						continue;
					}
					default:
						return;
					case 7u:
						break;
					case 6u:
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
			PictureBox val = default(PictureBox);
			while (true)
			{
				int num = 612658615;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3B1DB024u) % 10u)
					{
					case 8u:
						GForm2.smethod_39((Control)(object)val, eventHandler_);
						GForm2.smethod_40((Control)(object)val, eventHandler_2);
						GForm2.smethod_41((Control)(object)val, mouseEventHandler_);
						num = (int)(num2 * 1826186307) ^ -2013551591;
						continue;
					case 7u:
						val = pictureBox_4;
						num = ((int)num2 * -1042269454) ^ 0x7AB0ECD5;
						continue;
					case 6u:
						GForm2.smethod_44((Control)(object)val, mouseEventHandler_);
						num = (int)((num2 * 541806484) ^ 0x6414C6EB);
						continue;
					case 5u:
						pictureBox_4 = value;
						val = pictureBox_4;
						num = 252182720;
						continue;
					case 4u:
						GForm2.smethod_43((Control)(object)val, eventHandler_2);
						num = ((int)num2 * -791981270) ^ 0x2168D990;
						continue;
					case 3u:
						GForm2.smethod_42((Control)(object)val, eventHandler_);
						num = ((int)num2 * -1899797818) ^ -1853527050;
						continue;
					case 2u:
					{
						int num5;
						int num6;
						if (val != null)
						{
							num5 = 1089789417;
							num6 = 1089789417;
						}
						else
						{
							num5 = 2131425119;
							num6 = 2131425119;
						}
						num = num5 ^ (int)(num2 * 819664425);
						continue;
					}
					case 1u:
					{
						int num3;
						int num4;
						if (val == null)
						{
							num3 = -71827114;
							num4 = -71827114;
						}
						else
						{
							num3 = -1961613841;
							num4 = -1961613841;
						}
						num = num3 ^ ((int)num2 * -906605725);
						continue;
					}
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
				int num = 626592446;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x18ED2EC1u) % 8u)
					{
					case 7u:
						if (disposing)
						{
							num = ((int)num2 * -1696056998) ^ 0x5D3E82AF;
							continue;
						}
						num3 = 0;
						goto IL_001a;
					case 4u:
						num = (int)((num2 * 37641810) ^ 0x94BF840);
						continue;
					case 3u:
						GForm2.smethod_3((IDisposable)icontainer_0);
						num = ((int)num2 * -698681471) ^ -155040586;
						continue;
					case 2u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = -1475223448;
							num5 = -1475223448;
						}
						else
						{
							num4 = -1918882702;
							num5 = -1918882702;
						}
						num = num4 ^ (int)(num2 * 1136942800);
						continue;
					}
					case 1u:
						num = 554218951;
						continue;
					case 0u:
						num3 = ((icontainer_0 != null) ? 1 : 0);
						goto IL_001a;
					default:
						return;
					case 5u:
						break;
					case 6u:
						return;
						IL_001a:
						flag = (byte)num3 != 0;
						num = 1363253035;
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
				IL_00ef:
				int num6 = 1576359955;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num6 ^ 0x18ED2EC1u) % 3u)
					{
					case 1u:
						goto IL_00be;
					default:
						goto end_IL_00d2;
					case 0u:
						break;
					case 2u:
						goto end_IL_00d2;
					}
					goto IL_00ef;
					IL_00be:
					((Form)this).Dispose(disposing);
					num6 = (int)(num2 * 1875352214) ^ -1260005446;
					continue;
					end_IL_00d2:
					break;
				}
				break;
			}
		}
	}

	[DebuggerStepThrough]
	private void method_0()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0466: Expected O, but got Unknown
		//IL_079f: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager resourceManager_ = default(ComponentResourceManager);
		while (true)
		{
			int num = -2055439531;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC4399025u) % 97u)
				{
				case 96u:
					GForm2.smethod_20((Control)(object)PictureBox_3, (Image)GForm2.smethod_19((ResourceManager)resourceManager_, "PictureBox4.BackgroundImage"));
					num = (int)((num2 * 10485704) ^ 0x328549C0);
					continue;
				case 95u:
					Timer_0 = GForm2.smethod_8(icontainer_0);
					num = (int)((num2 * 489354204) ^ 0x6CEE25A8);
					continue;
				case 94u:
					GForm2.smethod_14((Control)(object)PictureBox_3, "PictureBox4");
					num = ((int)num2 * -1233087816) ^ 0x2B262D54;
					continue;
				case 93u:
					num = (int)((num2 * 2081399160) ^ 0xCC750A1);
					continue;
				case 92u:
					GForm2.smethod_11((Control)(object)PictureBox_2, Color.Transparent);
					num = ((int)num2 * -873435805) ^ 0x3D195D95;
					continue;
				case 91u:
					GForm2.smethod_9((ISupportInitialize)PictureBox_2);
					num = ((int)num2 * -467720324) ^ -329854721;
					continue;
				case 90u:
					num = (int)(num2 * 2047166909) ^ -196158564;
					continue;
				case 89u:
					GForm2.smethod_21((ContainerControl)(object)this, new SizeF(10f, 22f));
					num = ((int)num2 * -1802612652) ^ -115366629;
					continue;
				case 87u:
					GForm2.smethod_17(PictureBox_1, bool_1: false);
					num = (int)((num2 * 1225140090) ^ 0x5C295579);
					continue;
				case 86u:
					GForm2.smethod_11((Control)(object)PictureBox_1, Color.Transparent);
					num = (int)((num2 * 219707676) ^ 0x1B7BFF1C);
					continue;
				case 85u:
					num = ((int)num2 * -559659753) ^ -580394973;
					continue;
				case 84u:
					GForm2.smethod_31((Form)(object)this, bool_1: false);
					num = ((int)num2 * -218089277) ^ -2079813943;
					continue;
				case 83u:
					num = (int)((num2 * 168545125) ^ 0x393AE49B);
					continue;
				case 82u:
					GForm2.smethod_33((Form)(object)this, (FormStartPosition)1);
					num = ((int)num2 * -1250325430) ^ 0x4E115938;
					continue;
				case 81u:
					GForm2.smethod_9((ISupportInitialize)PictureBox_4);
					num = (int)(num2 * 458341120) ^ -687346111;
					continue;
				case 80u:
					GForm2.smethod_16(PictureBox_3, 4);
					GForm2.smethod_17(PictureBox_3, bool_1: false);
					num = ((int)num2 * -647443731) ^ 0x28206C10;
					continue;
				case 79u:
					GForm2.smethod_15((Control)(object)PictureBox_3, new Size(504, 57));
					num = (int)(num2 * 1278372600) ^ -742903827;
					continue;
				case 78u:
					GForm2.smethod_16(PictureBox_4, 5);
					num = (int)(num2 * 161835793) ^ -1517258506;
					continue;
				case 77u:
					GForm2.smethod_13((Control)(object)PictureBox_1, new Point(268, 168));
					GForm2.smethod_14((Control)(object)PictureBox_1, "PictureBox2");
					num = (int)(num2 * 356500884) ^ -175720463;
					continue;
				case 76u:
					GForm2.smethod_14((Control)(object)PictureBox_4, "PictureBox5");
					num = ((int)num2 * -1278524466) ^ 0x3511326B;
					continue;
				case 75u:
					num = ((int)num2 * -341393818) ^ 0x5FA082ED;
					continue;
				case 74u:
					num = (int)((num2 * 175118359) ^ 0x2502421A);
					continue;
				case 73u:
					num = ((int)num2 * -2007661851) ^ 0x19177CB0;
					continue;
				case 72u:
					num = (int)((num2 * 38577139) ^ 0x10B02636);
					continue;
				case 71u:
					PictureBox_1 = GForm2.smethod_7();
					num = ((int)num2 * -395296800) ^ -1532090786;
					continue;
				case 70u:
					GForm2.smethod_9((ISupportInitialize)PictureBox_0);
					GForm2.smethod_9((ISupportInitialize)PictureBox_1);
					num = (int)((num2 * 609648164) ^ 0x3D11DDE1);
					continue;
				case 69u:
					num = ((int)num2 * -74418385) ^ -2070651358;
					continue;
				case 68u:
					PictureBox_0 = GForm2.smethod_7();
					num = (int)(num2 * 1039298607) ^ -1440677669;
					continue;
				case 67u:
					GForm2.smethod_22((ContainerControl)(object)this, (AutoScaleMode)1);
					GForm2.smethod_23((Form)(object)this, Color.White);
					num = ((int)num2 * -862814483) ^ 0xD93DB4E;
					continue;
				case 66u:
					GForm2.smethod_11((Control)(object)PictureBox_0, Color.Transparent);
					num = ((int)num2 * -1358857260) ^ -1946642366;
					continue;
				case 65u:
					num = ((int)num2 * -1327445688) ^ 0x47D41187;
					continue;
				case 64u:
					num = (int)(num2 * 1146112364) ^ -2147250184;
					continue;
				case 63u:
					num = (int)((num2 * 1672139444) ^ 0x362C4A35);
					continue;
				case 62u:
					GForm2.smethod_13((Control)(object)PictureBox_3, new Point(268, 492));
					num = ((int)num2 * -1624583269) ^ 0x9B106AD;
					continue;
				case 61u:
					GForm2.smethod_26(GForm2.smethod_25((Control)(object)this), (Control)(object)PictureBox_3);
					num = (int)(num2 * 1157392573) ^ -859686673;
					continue;
				case 60u:
					GForm2.smethod_12((Control)(object)PictureBox_1, (ImageLayout)3);
					num = ((int)num2 * -1074220371) ^ 0x5568B1D4;
					continue;
				case 59u:
					num = ((int)num2 * -582796397) ^ 0x48E53B02;
					continue;
				case 58u:
					GForm2.smethod_11((Control)(object)PictureBox_4, Color.Transparent);
					GForm2.smethod_20((Control)(object)PictureBox_4, (Image)GForm2.smethod_19((ResourceManager)resourceManager_, "PictureBox5.BackgroundImage"));
					num = ((int)num2 * -1114253247) ^ -1114981791;
					continue;
				case 57u:
					GForm2.smethod_10((Control)(object)this);
					num = (int)((num2 * 2021579279) ^ 0x5D2E99DA);
					continue;
				case 56u:
					num = (int)(num2 * 825168026) ^ -2029796181;
					continue;
				case 55u:
					PictureBox_3 = GForm2.smethod_7();
					PictureBox_4 = GForm2.smethod_7();
					num = ((int)num2 * -503857687) ^ 0x75458AD4;
					continue;
				case 53u:
					GForm2.smethod_12((Control)(object)PictureBox_4, (ImageLayout)3);
					num = ((int)num2 * -419860690) ^ -343102452;
					continue;
				case 52u:
					GForm2.smethod_15((Control)(object)PictureBox_0, new Size(617, 69));
					num = (int)((num2 * 1322231794) ^ 0x1882A76C);
					continue;
				case 51u:
					GForm2.smethod_16(PictureBox_0, 1);
					num = ((int)num2 * -547525423) ^ 0x3FFD8F33;
					continue;
				case 50u:
					GForm2.smethod_15((Control)(object)PictureBox_1, new Size(504, 57));
					GForm2.smethod_16(PictureBox_1, 2);
					num = ((int)num2 * -714515008) ^ 0x1EEED149;
					continue;
				case 49u:
					GForm2.smethod_26(GForm2.smethod_25((Control)(object)this), (Control)(object)PictureBox_0);
					((Control)this).set_DoubleBuffered(true);
					num = (int)((num2 * 176648218) ^ 0x28FC52DC);
					continue;
				case 48u:
					num = (int)(num2 * 96891636) ^ -417586740;
					continue;
				case 47u:
					GForm2.smethod_11((Control)(object)PictureBox_3, Color.Transparent);
					num = ((int)num2 * -2062103567) ^ 0x42901348;
					continue;
				case 46u:
					GForm2.smethod_18(Timer_0, 1000);
					num = ((int)num2 * -2051340995) ^ -1704148405;
					continue;
				case 45u:
					GForm2.smethod_26(GForm2.smethod_25((Control)(object)this), (Control)(object)PictureBox_1);
					num = ((int)num2 * -1570798931) ^ 0x167EA4CD;
					continue;
				case 44u:
					num = ((int)num2 * -1000867193) ^ 0x7390334C;
					continue;
				case 43u:
					GForm2.smethod_14((Control)(object)PictureBox_2, "PictureBox3");
					num = ((int)num2 * -954129638) ^ -2078393183;
					continue;
				case 42u:
					GForm2.smethod_35((ISupportInitialize)PictureBox_4);
					num = (int)(num2 * 933496035) ^ -440454089;
					continue;
				case 41u:
					GForm2.smethod_34((Form)(object)this, "The Omegle Game");
					GForm2.smethod_35((ISupportInitialize)PictureBox_0);
					num = ((int)num2 * -840634209) ^ 0x5ABC0E3F;
					continue;
				case 40u:
					num = (int)(num2 * 2011825408) ^ -1478237100;
					continue;
				case 39u:
					num = ((int)num2 * -832666848) ^ -1106564892;
					continue;
				case 38u:
					num = (int)(num2 * 890448781) ^ -1394133523;
					continue;
				case 37u:
					GForm2.smethod_15((Control)(object)PictureBox_2, new Size(353, 42));
					num = (int)(num2 * 1506348481) ^ -65084217;
					continue;
				case 36u:
					num = ((int)num2 * -1821070470) ^ -653306454;
					continue;
				case 35u:
					GForm2.smethod_17(PictureBox_0, bool_1: false);
					num = ((int)num2 * -398988065) ^ 0x7EFBCA79;
					continue;
				case 34u:
					num = (int)((num2 * 1534736481) ^ 0x7B2E9C5);
					continue;
				case 33u:
					num = (int)(num2 * 1246637694) ^ -1652356304;
					continue;
				case 32u:
					GForm2.smethod_35((ISupportInitialize)PictureBox_3);
					num = (int)((num2 * 597381181) ^ 0x2CBAB81F);
					continue;
				case 31u:
					GForm2.smethod_26(GForm2.smethod_25((Control)(object)this), (Control)(object)PictureBox_2);
					num = ((int)num2 * -572534009) ^ -742405743;
					continue;
				case 30u:
					GForm2.smethod_16(PictureBox_2, 3);
					GForm2.smethod_17(PictureBox_2, bool_1: false);
					num = ((int)num2 * -168047228) ^ -703109543;
					continue;
				case 29u:
					GForm2.smethod_30((Form)(object)this, new Padding(4));
					num = (int)((num2 * 2013608942) ^ 0x186026AF);
					continue;
				case 28u:
					GForm2.smethod_12((Control)(object)this, (ImageLayout)3);
					num = ((int)num2 * -73214489) ^ -175859798;
					continue;
				case 27u:
					num = ((int)num2 * -1292058583) ^ -497686974;
					continue;
				case 26u:
					GForm2.smethod_12((Control)(object)PictureBox_3, (ImageLayout)3);
					num = (int)((num2 * 559725846) ^ 0x766B9A6E);
					continue;
				case 25u:
					GForm2.smethod_15((Control)(object)PictureBox_4, new Size(504, 57));
					num = (int)(num2 * 697989968) ^ -1001556602;
					continue;
				case 24u:
					num = (int)((num2 * 813755107) ^ 0x1407214B);
					continue;
				case 23u:
					num = (int)((num2 * 1413160003) ^ 0x28AA46A2);
					continue;
				case 22u:
					GForm2.smethod_12((Control)(object)PictureBox_2, (ImageLayout)3);
					GForm2.smethod_13((Control)(object)PictureBox_2, new Point(338, 306));
					num = (int)((num2 * 1960956814) ^ 0x6F3453E5);
					continue;
				case 21u:
					PictureBox_2 = GForm2.smethod_7();
					num = ((int)num2 * -2091179573) ^ -1987909225;
					continue;
				case 20u:
					GForm2.smethod_9((ISupportInitialize)PictureBox_3);
					num = (int)(num2 * 89380195) ^ -1961345083;
					continue;
				case 19u:
					num = ((int)num2 * -698599603) ^ 0x46A85CB9;
					continue;
				case 18u:
					GForm2.smethod_35((ISupportInitialize)PictureBox_2);
					num = ((int)num2 * -1524806463) ^ 0x335353CC;
					continue;
				case 17u:
					GForm2.smethod_24((Form)(object)this, new Size(1025, 638));
					GForm2.smethod_26(GForm2.smethod_25((Control)(object)this), (Control)(object)PictureBox_4);
					num = (int)(num2 * 1743160709) ^ -1124507714;
					continue;
				case 16u:
					num = (int)(num2 * 1239795069) ^ -1484866883;
					continue;
				case 15u:
					num = (int)(num2 * 1737582814) ^ -1612238908;
					continue;
				case 14u:
					GForm2.smethod_13((Control)(object)PictureBox_4, new Point(268, 555));
					num = (int)(num2 * 1465029867) ^ -779066625;
					continue;
				case 13u:
					GForm2.smethod_13((Control)(object)PictureBox_0, new Point(214, 12));
					GForm2.smethod_14((Control)(object)PictureBox_0, "PictureBox1");
					num = ((int)num2 * -1119226030) ^ 0x774670D1;
					continue;
				case 12u:
					num = ((int)num2 * -284567914) ^ 0x2D68E5A8;
					continue;
				case 11u:
					num = ((int)num2 * -1596774984) ^ -2063827626;
					continue;
				case 10u:
					GForm2.smethod_17(PictureBox_4, bool_1: false);
					num = ((int)num2 * -1331787853) ^ -927185103;
					continue;
				case 9u:
					GForm2.smethod_28((Control)(object)this, GForm2.smethod_27("Consolas", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -387559376) ^ -996725850;
					continue;
				case 8u:
					icontainer_0 = GForm2.smethod_4();
					resourceManager_ = GForm2.smethod_6(GForm2.smethod_5(typeof(GForm2).TypeHandle));
					num = (int)(num2 * 1382336173) ^ -995458670;
					continue;
				case 7u:
					GForm2.smethod_29((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -932059569) ^ 0x42BCCC76;
					continue;
				case 6u:
					num = (int)(num2 * 1140351938) ^ -732188892;
					continue;
				case 5u:
					num = ((int)num2 * -983909468) ^ -346769407;
					continue;
				case 4u:
					GForm2.smethod_35((ISupportInitialize)PictureBox_1);
					num = (int)(num2 * 2007805989) ^ -1569298414;
					continue;
				case 3u:
					GForm2.smethod_12((Control)(object)PictureBox_0, (ImageLayout)3);
					num = (int)((num2 * 55238850) ^ 0x9F6E605);
					continue;
				case 2u:
					GForm2.smethod_32((Control)(object)this, "SelectDuelType");
					num = ((int)num2 * -1220291968) ^ -1649550871;
					continue;
				case 1u:
					num = (int)(num2 * 479321437) ^ -690357386;
					continue;
				case 0u:
					num = (int)((num2 * 664979934) ^ 0x40E10AC);
					continue;
				case 88u:
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
			int num = -485355861;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x86BB4EA4u) % 12u)
				{
				case 11u:
					num = ((int)num2 * -687176296) ^ -851015157;
					continue;
				case 10u:
					GForm2.smethod_20((Control)(object)PictureBox_2, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\con_la_cpu_hover.png")));
					num = (int)(num2 * 1772165765) ^ -740034849;
					continue;
				case 8u:
					GForm2.smethod_50(Timer_0);
					num = ((int)num2 * -1847597915) ^ 0x68EE62FE;
					continue;
				case 7u:
					GForm2.smethod_46(GForm2.smethod_45(), ProcessPriorityClass.RealTime);
					num = (int)(num2 * 1182855161) ^ -923058470;
					continue;
				case 5u:
					num = ((int)num2 * -765743860) ^ -1527312238;
					continue;
				case 4u:
					num = ((int)num2 * -1940098307) ^ 0x3E4C7650;
					continue;
				case 3u:
					GForm2.smethod_20((Control)(object)PictureBox_4, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\torna_indietro.png")));
					num = (int)(num2 * 152940072) ^ -1656662068;
					continue;
				case 2u:
					GForm2.smethod_20((Control)(object)PictureBox_3, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\fai_un_duello.png")));
					num = ((int)num2 * -519711302) ^ 0x6D4A9AD3;
					continue;
				case 1u:
					GForm2.smethod_20((Control)(object)this, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\main_menu.jpg")));
					GForm2.smethod_20((Control)(object)PictureBox_0, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\logo.png")));
					num = ((int)num2 * -64900826) ^ 0x2CAE493A;
					continue;
				case 0u:
					GForm2.smethod_20((Control)(object)PictureBox_1, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\seleziona_una_modalita.png")));
					num = ((int)num2 * -1539188351) ^ 0x79D0230E;
					continue;
				default:
					return;
				case 9u:
					break;
				case 6u:
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
			int num = 1631014678;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB2C9D5u) % 3u)
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
				GForm2.smethod_51();
				num = (int)((num2 * 1947092496) ^ 0xF2398F1);
			}
		}
	}

	private void method_3(object sender, KeyEventArgs e)
	{
		bool flag = (GForm2.smethod_52(e) == 37) | (GForm2.smethod_52(e) == 39);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			int num = 773488975;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2D4B1851u) % 18u)
				{
				case 17u:
					num = 545002618;
					continue;
				case 16u:
				{
					int num7;
					int num8;
					if (int_0 == 0)
					{
						num7 = 841282014;
						num8 = 841282014;
					}
					else
					{
						num7 = 97288708;
						num8 = 97288708;
					}
					num = num7 ^ ((int)num2 * -1831864697);
					continue;
				}
				case 14u:
				{
					int num9;
					int num10;
					if (!flag2)
					{
						num9 = -2056253052;
						num10 = -2056253052;
					}
					else
					{
						num9 = -757778312;
						num10 = -757778312;
					}
					num = num9 ^ ((int)num2 * -646311109);
					continue;
				}
				case 13u:
					GForm2.smethod_20((Control)(object)PictureBox_2, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\con_la_cpu_hover.png")));
					num = ((int)num2 * -166112660) ^ 0x26982550;
					continue;
				case 11u:
					num = ((int)num2 * -860312779) ^ 0x35A2A736;
					continue;
				case 10u:
					GForm2.smethod_20((Control)(object)PictureBox_2, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\con_gli_altri.png")));
					num = ((int)num2 * -818490959) ^ 0x5E7831AE;
					continue;
				case 9u:
				{
					int num5;
					int num6;
					if (flag3)
					{
						num5 = 296766169;
						num6 = 296766169;
					}
					else
					{
						num5 = 1866864006;
						num6 = 1866864006;
					}
					num = num5 ^ ((int)num2 * -898176426);
					continue;
				}
				case 8u:
					num = 405483845;
					continue;
				case 7u:
					flag3 = int_0 == 1;
					num = 812076336;
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 274673645;
						num4 = 274673645;
					}
					else
					{
						num3 = 2074514337;
						num4 = 2074514337;
					}
					num = num3 ^ (int)(num2 * 903894126);
					continue;
				}
				case 5u:
					num = ((int)num2 * -1824920193) ^ -727419213;
					continue;
				case 4u:
					flag2 = int_0 == 0;
					num = (int)(num2 * 1462813513) ^ -1226086249;
					continue;
				case 3u:
					int_0 = 0;
					num = ((int)num2 * -181650308) ^ -896923621;
					continue;
				case 2u:
					num = ((int)num2 * -1860390820) ^ -1561014135;
					continue;
				case 1u:
					int_0 = 1;
					num = (int)(num2 * 940470506) ^ -550725228;
					continue;
				case 0u:
					num = 647700807;
					continue;
				default:
					return;
				case 12u:
					break;
				case 15u:
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
			int num = 1587724706;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x746FFB07u) % 4u)
				{
				case 1u:
					GForm2.smethod_20((Control)(object)PictureBox_3, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\fai_un_duello_hover.png")));
					num = ((int)num2 * -52651851) ^ -664403058;
					continue;
				case 0u:
					num = ((int)num2 * -240034744) ^ -2016977663;
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

	private void method_5(object sender, EventArgs e)
	{
		GForm2.smethod_20((Control)(object)PictureBox_3, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\fai_un_duello.png")));
	}

	private void method_6(object sender, EventArgs e)
	{
		GForm2.smethod_20((Control)(object)PictureBox_4, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\torna_indietro_hover.png")));
	}

	private void method_7(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -605259846;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC31ECCCEu) % 3u)
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
				GForm2.smethod_20((Control)(object)PictureBox_4, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\torna_indietro.png")));
				num = ((int)num2 * -900099252) ^ -2116935467;
			}
		}
	}

	private void method_8(object sender, FormClosingEventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = 1534043963;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3E67E16Du) % 8u)
				{
				case 7u:
					num = (int)((num2 * 1477528447) ^ 0x24ABBB31);
					continue;
				case 6u:
					method_9();
					num = (int)(num2 * 218644083) ^ -1692222733;
					continue;
				case 4u:
					num = ((int)num2 * -1508918801) ^ 0x2C5079F8;
					continue;
				case 3u:
					GForm2.smethod_53((CancelEventArgs)(object)e, bool_1: true);
					num = (int)((num2 * 1853014837) ^ 0x630F33A5);
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1326128668;
						num4 = 1326128668;
					}
					else
					{
						num3 = 1996228858;
						num4 = 1996228858;
					}
					num = num3 ^ ((int)num2 * -1274174026);
					continue;
				}
				case 1u:
					flag = !bool_0;
					num = ((int)num2 * -1070580273) ^ 0x7566F830;
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

	public void method_9()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Invalid comparison between Unknown and I4
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 1649816395;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1BB372EAu) % 26u)
				{
				case 25u:
					num = 795608397;
					continue;
				case 24u:
					GForm2.smethod_56((object)Timer_0);
					num = (int)((num2 * 234947485) ^ 0x15BD4E7);
					continue;
				case 23u:
					flag2 = (int)GForm2.smethod_54("Sei sicuro di voler uscire dal gioco?", "The Omegle Game", (MessageBoxButtons)4, (MessageBoxIcon)32) == 6;
					num = ((int)num2 * -1282185290) ^ -221612186;
					continue;
				case 22u:
					num = (int)(num2 * 411443250) ^ -887994322;
					continue;
				case 21u:
					num = ((int)num2 * -1065680982) ^ -1623869682;
					continue;
				case 20u:
					num = (int)((num2 * 1349734261) ^ 0x1B671611);
					continue;
				case 19u:
					GForm2.smethod_56((object)int_0);
					num = ((int)num2 * -476107602) ^ -298611733;
					continue;
				case 18u:
					GForm2.smethod_55(Timer_0);
					num = (int)((num2 * 1041979811) ^ 0x226E8F4A);
					continue;
				case 16u:
					GForm2.smethod_56((object)Timer_0);
					num = (int)(num2 * 939374955) ^ -1706858396;
					continue;
				case 15u:
					GForm2.smethod_56((object)bool_0);
					GForm2.smethod_51();
					num = (int)(num2 * 534247861) ^ -1747473137;
					continue;
				case 14u:
					GForm2.smethod_55(Timer_0);
					num = (int)((num2 * 1331044724) ^ 0x34B27CCE);
					continue;
				case 13u:
					num = 276880548;
					continue;
				case 12u:
					num = (int)(num2 * 521769001) ^ -1173273556;
					continue;
				case 11u:
					num = ((int)num2 * -1818449995) ^ -1929604656;
					continue;
				case 10u:
					GForm2.smethod_56((object)int_0);
					num = (int)((num2 * 1693563125) ^ 0x4F55C404);
					continue;
				case 9u:
					num = (int)(num2 * 2057510588) ^ -239951062;
					continue;
				case 8u:
					num = (int)(num2 * 710334966) ^ -198786593;
					continue;
				case 7u:
					flag = !bool_0;
					num = (int)((num2 * 1704013678) ^ 0x5CB121FF);
					continue;
				case 6u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = -393480979;
						num6 = -393480979;
					}
					else
					{
						num5 = -2115589618;
						num6 = -2115589618;
					}
					num = num5 ^ (int)(num2 * 29003481);
					continue;
				}
				case 5u:
					GForm2.smethod_56((object)bool_0);
					num = ((int)num2 * -2065725673) ^ -506083429;
					continue;
				case 3u:
					GForm2.smethod_51();
					num = ((int)num2 * -571997457) ^ -2082383702;
					continue;
				case 2u:
					num = (int)((num2 * 738187272) ^ 0x61B18E31);
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1183644629;
						num4 = -1183644629;
					}
					else
					{
						num3 = -1639436527;
						num4 = -1639436527;
					}
					num = num3 ^ ((int)num2 * -238487818);
					continue;
				}
				case 0u:
					GForm2.smethod_57(GForm2.smethod_45());
					num = (int)((num2 * 1033918169) ^ 0x446CCBA6);
					continue;
				default:
					return;
				case 17u:
					break;
				case 4u:
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
			int num = 1981017722;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x58D5761u) % 3u)
				{
				case 2u:
					goto IL_0009;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0009:
				GForm2.smethod_54("Ci dispiace, ma la modalità duello non è attualmente disponibile.", "The Omegle Game", (MessageBoxButtons)0, (MessageBoxIcon)48);
				num = ((int)num2 * -1665448837) ^ 0x2F02BAA9;
			}
		}
	}

	private void method_11(object sender, MouseEventArgs e)
	{
		while (true)
		{
			int num = 2132858490;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x492AC1FFu) % 6u)
				{
				case 4u:
					num = (int)((num2 * 979928579) ^ 0x43DF5542);
					continue;
				case 3u:
					num = (int)((num2 * 489744222) ^ 0x2B62F3C7);
					continue;
				case 1u:
					bool_0 = true;
					GForm2.smethod_58((Control)(object)Class2.Class3_0.GForm1_0);
					num = ((int)num2 * -643822888) ^ 0x3AE8EB2E;
					continue;
				case 0u:
					GForm2.smethod_59((Form)(object)this);
					num = ((int)num2 * -1458256328) ^ 0xF9AF921;
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
