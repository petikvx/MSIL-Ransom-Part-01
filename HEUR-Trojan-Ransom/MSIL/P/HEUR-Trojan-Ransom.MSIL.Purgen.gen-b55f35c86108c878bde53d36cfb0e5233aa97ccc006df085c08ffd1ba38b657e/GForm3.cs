using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
public class GForm3 : Form
{
	private IContainer icontainer_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("MemoryCleaner")]
	private Timer timer_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Label1")]
	private Label label_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Storytelling")]
	private Timer timer_1;

	private bool bool_0;

	private int int_0;

	private int int_1;

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
			while (true)
			{
				int num = -1866591959;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9300599Au) % 8u)
					{
					case 7u:
						val = timer_0;
						num = (int)((num2 * 28134790) ^ 0x47050118);
						continue;
					case 5u:
						GForm3.smethod_34(val, eventHandler_);
						num = ((int)num2 * -746382733) ^ 0x3EFD8B04;
						continue;
					case 4u:
						GForm3.smethod_33(val, eventHandler_);
						num = (int)(num2 * 1529738712) ^ -1070923128;
						continue;
					case 3u:
					{
						int num5;
						int num6;
						if (val != null)
						{
							num5 = 1508664790;
							num6 = 1508664790;
						}
						else
						{
							num5 = 2137886120;
							num6 = 2137886120;
						}
						num = num5 ^ (int)(num2 * 885254400);
						continue;
					}
					case 2u:
						timer_0 = value;
						num = -1814215979;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (val == null)
						{
							num3 = -1891937557;
							num4 = -1891937557;
						}
						else
						{
							num3 = -1509623409;
							num4 = -1509623409;
						}
						num = num3 ^ ((int)num2 * -1004672692);
						continue;
					}
					default:
						return;
					case 6u:
						break;
					case 1u:
						return;
					}
					break;
				}
			}
		}
	}

	internal virtual Label Label_0
	{
		[CompilerGenerated]
		get
		{
			return label_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			label_0 = value;
		}
	}

	internal virtual Timer Timer_1
	{
		[CompilerGenerated]
		get
		{
			return timer_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = method_5;
			Timer val = default(Timer);
			while (true)
			{
				int num = 314470324;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCDE6773u) % 8u)
					{
					case 7u:
					{
						val = timer_1;
						int num5;
						int num6;
						if (val != null)
						{
							num5 = 1747221036;
							num6 = 1747221036;
						}
						else
						{
							num5 = 1361328373;
							num6 = 1361328373;
						}
						num = num5 ^ (int)(num2 * 270247473);
						continue;
					}
					case 5u:
					{
						int num3;
						int num4;
						if (val == null)
						{
							num3 = -1933818542;
							num4 = -1933818542;
						}
						else
						{
							num3 = -1548181225;
							num4 = -1548181225;
						}
						num = num3 ^ ((int)num2 * -563432293);
						continue;
					}
					case 3u:
						GForm3.smethod_34(val, eventHandler_);
						num = (int)(num2 * 2020613840) ^ -5186531;
						continue;
					case 2u:
						val = timer_1;
						num = ((int)num2 * -660605303) ^ 0x3CC0E364;
						continue;
					case 1u:
						timer_1 = value;
						num = 200918297;
						continue;
					case 0u:
						GForm3.smethod_33(val, eventHandler_);
						num = ((int)num2 * -1889879599) ^ 0x4567772A;
						continue;
					default:
						return;
					case 4u:
						break;
					case 6u:
						return;
					}
					break;
				}
			}
		}
	}

	public GForm3()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		GForm3.smethod_0((Form)(object)this, (EventHandler)method_1);
		GForm3.smethod_1((Form)(object)this, new FormClosingEventHandler(method_3));
		bool_0 = false;
		int_0 = 0;
		int_1 = 0;
		method_0();
	}

	[DebuggerNonUserCode]
	void Form.Dispose(bool disposing)
	{
		try
		{
			if (disposing)
			{
				goto IL_0066;
			}
			int num = 0;
			goto IL_00a1;
			IL_00a1:
			bool flag = (byte)num != 0;
			int num2 = 14429026;
			goto IL_006b;
			IL_0066:
			num2 = 540577686;
			goto IL_006b;
			IL_006b:
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x46D0284Du) % 7u)
				{
				case 6u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -3730935;
						num5 = -3730935;
					}
					else
					{
						num4 = -222849783;
						num5 = -222849783;
					}
					num2 = num4 ^ (int)(num3 * 497181790);
					continue;
				}
				case 5u:
					GForm3.smethod_2((IDisposable)icontainer_0);
					num2 = ((int)num3 * -300180677) ^ -1455271250;
					continue;
				case 3u:
					num2 = (int)(num3 * 1253156368) ^ -365159377;
					continue;
				case 2u:
					num2 = ((int)num3 * -933117253) ^ -671832307;
					continue;
				case 0u:
					break;
				default:
					return;
				case 4u:
					goto IL_0098;
				case 1u:
					return;
				}
				break;
			}
			goto IL_0066;
			IL_0098:
			num = ((icontainer_0 != null) ? 1 : 0);
			goto IL_00a1;
		}
		finally
		{
			((Form)this).Dispose(disposing);
			while (true)
			{
				IL_00de:
				int num6 = 555457433;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num6 ^ 0x46D0284Du) % 3u)
					{
					case 1u:
						goto IL_00b4;
					default:
						goto end_IL_00c1;
					case 0u:
						break;
					case 2u:
						goto end_IL_00c1;
					}
					goto IL_00de;
					IL_00b4:
					num6 = (int)(num3 * 680476273) ^ -1080687203;
					continue;
					end_IL_00c1:
					break;
				}
				break;
			}
		}
	}

	[DebuggerStepThrough]
	private void method_0()
	{
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		icontainer_0 = GForm3.smethod_3();
		Timer_0 = GForm3.smethod_4(icontainer_0);
		Label_0 = GForm3.smethod_5();
		while (true)
		{
			int num = 1642599425;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x798F277Du) % 38u)
				{
				case 37u:
					GForm3.smethod_11((Control)(object)this, GForm3.smethod_10("Consolas", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 589143812) ^ -1452226949;
					continue;
				case 36u:
					GForm3.smethod_21((Control)(object)this, (ImageLayout)3);
					GForm3.smethod_22((Form)(object)this, new Size(1025, 638));
					num = ((int)num2 * -127829745) ^ -1028414650;
					continue;
				case 35u:
					GForm3.smethod_9((Control)(object)Label_0, Color.Transparent);
					num = (int)((num2 * 1061045094) ^ 0x4F1C695A);
					continue;
				case 34u:
					GForm3.smethod_27((Form)(object)this, bool_1: false);
					num = (int)(num2 * 819116791) ^ -894669861;
					continue;
				case 33u:
					GForm3.smethod_16((Control)(object)Label_0, 0);
					num = (int)(num2 * 1305307050) ^ -1121452519;
					continue;
				case 32u:
					GForm3.smethod_26((Form)(object)this, new Padding(4));
					num = (int)(num2 * 1031830578) ^ -719973408;
					continue;
				case 31u:
					num = (int)((num2 * 1760234864) ^ 0x3B7F21B9);
					continue;
				case 30u:
					GForm3.smethod_30((Form)(object)this, "The Omegle Game");
					num = ((int)num2 * -961935428) ^ 0x301FC14C;
					continue;
				case 29u:
					GForm3.smethod_7(Timer_0, 1000);
					num = (int)((num2 * 1573431033) ^ 0x518D5EC1);
					continue;
				case 28u:
					num = ((int)num2 * -936988633) ^ -770417468;
					continue;
				case 27u:
					num = (int)((num2 * 1966354361) ^ 0x1449613C);
					continue;
				case 26u:
					GForm3.smethod_7(Timer_1, 6000);
					num = ((int)num2 * -298464514) ^ 0x744D2E22;
					continue;
				case 25u:
					GForm3.smethod_18((ContainerControl)(object)this, new SizeF(10f, 22f));
					num = ((int)num2 * -480260767) ^ -844976833;
					continue;
				case 24u:
					GForm3.smethod_20((Form)(object)this, Color.White);
					num = (int)(num2 * 1167511548) ^ -806204227;
					continue;
				case 23u:
					GForm3.smethod_32((Control)(object)this);
					num = ((int)num2 * -387646118) ^ -1524092322;
					continue;
				case 22u:
					((Control)this).set_DoubleBuffered(true);
					num = (int)((num2 * 1579208473) ^ 0x36AD6235);
					continue;
				case 21u:
					GForm3.smethod_11((Control)(object)Label_0, GForm3.smethod_10("Microsoft Sans Serif", 24f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
					GForm3.smethod_12((Control)(object)Label_0, Color.White);
					GForm3.smethod_13((Control)(object)Label_0, new Point(111, 270));
					num = (int)(num2 * 1712966252) ^ -1034535104;
					continue;
				case 20u:
					GForm3.smethod_14((Control)(object)Label_0, "Label1");
					GForm3.smethod_15((Control)(object)Label_0, new Size(862, 46));
					num = ((int)num2 * -169715258) ^ -751437162;
					continue;
				case 19u:
					num = (int)((num2 * 643546053) ^ 0x59ADCEF);
					continue;
				case 18u:
					GForm3.smethod_6((Control)(object)this);
					num = ((int)num2 * -2027692733) ^ 0x16211C8A;
					continue;
				case 16u:
					num = ((int)num2 * -670762641) ^ -2130131181;
					continue;
				case 15u:
					num = ((int)num2 * -58942523) ^ -461283080;
					continue;
				case 14u:
					num = ((int)num2 * -1481767335) ^ 0x538D701A;
					continue;
				case 13u:
					GForm3.smethod_19((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 1540215199) ^ -1412745155;
					continue;
				case 12u:
					Timer_1 = GForm3.smethod_4(icontainer_0);
					num = ((int)num2 * -1878533812) ^ -1405830875;
					continue;
				case 11u:
					GForm3.smethod_8(Label_0, bool_1: true);
					num = ((int)num2 * -1206590217) ^ -65268053;
					continue;
				case 10u:
					GForm3.smethod_25((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -1632453611) ^ 0x51D17D6D;
					continue;
				case 9u:
					GForm3.smethod_28((Control)(object)this, "StoryMode");
					num = (int)(num2 * 189676528) ^ -1908337884;
					continue;
				case 8u:
					num = ((int)num2 * -2034404262) ^ 0x208D305E;
					continue;
				case 7u:
					num = (int)(num2 * 1925410657) ^ -1021816596;
					continue;
				case 6u:
					num = (int)((num2 * 1423088598) ^ 0x5D8BE9B1);
					continue;
				case 5u:
					GForm3.smethod_24(GForm3.smethod_23((Control)(object)this), (Control)(object)Label_0);
					num = (int)((num2 * 1975234020) ^ 0x46CE2D19);
					continue;
				case 3u:
					num = (int)(num2 * 310579713) ^ -2128517778;
					continue;
				case 2u:
					GForm3.smethod_17(Label_0, "Tutto ebbe inizio in un freddo giorno d'inverno...");
					num = ((int)num2 * -234343543) ^ 0x48142E23;
					continue;
				case 1u:
					GForm3.smethod_29((Form)(object)this, (FormStartPosition)1);
					num = (int)(num2 * 1749787665) ^ -1272527121;
					continue;
				case 0u:
					GForm3.smethod_31((Control)(object)this, bool_1: false);
					num = (int)((num2 * 823221936) ^ 0x32B2509);
					continue;
				default:
					return;
				case 4u:
					break;
				case 17u:
					return;
				}
				break;
			}
		}
	}

	private void method_1(object sender, EventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = 1002162691;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3F3DD8ADu) % 12u)
				{
				case 11u:
					num = ((int)num2 * -1563491748) ^ -1261308328;
					continue;
				case 9u:
					GClass1.smethod_2().method_0();
					num = ((int)num2 * -1810541778) ^ 0x329BA51F;
					continue;
				case 8u:
					flag = int_1 == 0;
					num = ((int)num2 * -883348983) ^ 0x1A735CC4;
					continue;
				case 7u:
					GForm3.smethod_17(Label_0, "Tutto ebbe inizio in un freddo giorno d'inverno...");
					num = ((int)num2 * -1674999764) ^ -230162295;
					continue;
				case 6u:
					GForm3.smethod_36(GForm3.smethod_35(), ProcessPriorityClass.RealTime);
					num = ((int)num2 * -1568445713) ^ 0x1833A0A0;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1722587052;
						num4 = 1722587052;
					}
					else
					{
						num3 = 29265343;
						num4 = 29265343;
					}
					num = num3 ^ (int)(num2 * 229254593);
					continue;
				}
				case 3u:
					num = (int)((num2 * 1229307257) ^ 0x25CBEE4F);
					continue;
				case 2u:
					GForm3.smethod_37(Timer_1);
					num = (int)(num2 * 19213402) ^ -1989350054;
					continue;
				case 1u:
					GForm3.smethod_37(Timer_0);
					num = ((int)num2 * -1933276495) ^ 0x3953FD7A;
					continue;
				case 0u:
					num = ((int)num2 * -730022212) ^ -1546264523;
					continue;
				default:
					return;
				case 10u:
					break;
				case 4u:
					return;
				}
				break;
			}
		}
	}

	private void method_2(object sender, EventArgs e)
	{
		GForm3.smethod_38();
	}

	private void method_3(object sender, FormClosingEventArgs e)
	{
		method_4();
		bool flag = default(bool);
		while (true)
		{
			int num = 1865749759;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x29F872BEu) % 7u)
				{
				case 6u:
					num = ((int)num2 * -1738920602) ^ -800574927;
					continue;
				case 5u:
					GForm3.smethod_39((CancelEventArgs)(object)e, bool_1: true);
					num = (int)((num2 * 1031372572) ^ 0x17DF1220);
					continue;
				case 3u:
					flag = !bool_0;
					num = (int)((num2 * 1766739659) ^ 0x77F0A87F);
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 648921870;
						num4 = 648921870;
					}
					else
					{
						num3 = 1952769874;
						num4 = 1952769874;
					}
					num = num3 ^ ((int)num2 * -426206979);
					continue;
				}
				case 1u:
					num = ((int)num2 * -586161921) ^ 0x627F357F;
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

	public void method_4()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Invalid comparison between Unknown and I4
		bool flag = default(bool);
		while (true)
		{
			int num = -1458018835;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE786420Fu) % 19u)
				{
				case 18u:
					GForm3.smethod_42((object)Timer_0);
					num = ((int)num2 * -618178811) ^ -2009627351;
					continue;
				case 17u:
					GForm3.smethod_42((object)bool_0);
					num = ((int)num2 * -1929262553) ^ -454529072;
					continue;
				case 15u:
				{
					int num5;
					int num6;
					if ((int)GForm3.smethod_40("Sei sicuro di voler uscire dal gioco?", "The Omegle Game", (MessageBoxButtons)4, (MessageBoxIcon)32) != 6)
					{
						num5 = 1477124601;
						num6 = 1477124601;
					}
					else
					{
						num5 = 909312435;
						num6 = 909312435;
					}
					num = num5 ^ (int)(num2 * 16716887);
					continue;
				}
				case 14u:
					num = -365259409;
					continue;
				case 13u:
					flag = !bool_0;
					num = (int)((num2 * 2060565737) ^ 0x3D734CF0);
					continue;
				case 12u:
					num = ((int)num2 * -1012697262) ^ -1882803444;
					continue;
				case 11u:
					GForm3.smethod_42((object)bool_0);
					GForm3.smethod_38();
					GForm3.smethod_43(GForm3.smethod_35());
					num = ((int)num2 * -1196041663) ^ -1501862604;
					continue;
				case 9u:
					num = (int)((num2 * 2125432194) ^ 0x6B798FDA);
					continue;
				case 8u:
					GForm3.smethod_41(Timer_0);
					num = (int)((num2 * 399585721) ^ 0x203BAB98);
					continue;
				case 7u:
					GForm3.smethod_38();
					num = ((int)num2 * -653794603) ^ 0x2801D284;
					continue;
				case 6u:
					GForm3.smethod_41(Timer_0);
					num = (int)((num2 * 393181843) ^ 0x257893E7);
					continue;
				case 5u:
					GForm3.smethod_42((object)Timer_0);
					num = (int)(num2 * 187621657) ^ -947534375;
					continue;
				case 4u:
					num = -488701868;
					continue;
				case 3u:
					num = (int)((num2 * 243191134) ^ 0x1D72BAD9);
					continue;
				case 2u:
					num = (int)((num2 * 486924637) ^ 0x6044BB16);
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 267326799;
						num4 = 267326799;
					}
					else
					{
						num3 = 945841452;
						num4 = 945841452;
					}
					num = num3 ^ ((int)num2 * -622834319);
					continue;
				}
				case 0u:
					num = ((int)num2 * -277936931) ^ 0x4F717203;
					continue;
				default:
					return;
				case 16u:
					break;
				case 10u:
					return;
				}
				break;
			}
		}
	}

	private void method_5(object sender, EventArgs e)
	{
		checked
		{
			int_0++;
		}
		bool flag3 = default(bool);
		bool flag13 = default(bool);
		bool flag = default(bool);
		bool flag12 = default(bool);
		bool flag7 = default(bool);
		bool flag8 = default(bool);
		bool flag4 = default(bool);
		bool flag9 = default(bool);
		bool flag11 = default(bool);
		bool flag10 = default(bool);
		bool flag6 = default(bool);
		bool flag2 = default(bool);
		bool flag5 = default(bool);
		while (true)
		{
			int num = -585207059;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9B211D69u) % 84u)
				{
				case 83u:
					GClass1.smethod_2().method_0();
					num = ((int)num2 * -1013549743) ^ -748736065;
					continue;
				case 82u:
					num = (int)((num2 * 888084731) ^ 0x599090EF);
					continue;
				case 81u:
					num = (int)((num2 * 1541043700) ^ 0x1572F051);
					continue;
				case 80u:
					num = (int)(num2 * 410587433) ^ -1606449937;
					continue;
				case 79u:
				{
					int num5;
					int num6;
					if (!flag3)
					{
						num5 = 1657111026;
						num6 = 1657111026;
					}
					else
					{
						num5 = 757267863;
						num6 = 757267863;
					}
					num = num5 ^ (int)(num2 * 499877859);
					continue;
				}
				case 78u:
					num = ((int)num2 * -1519219781) ^ -1303478241;
					continue;
				case 77u:
				{
					int num27;
					int num28;
					if (flag13)
					{
						num27 = 161562465;
						num28 = 161562465;
					}
					else
					{
						num27 = 462481326;
						num28 = 462481326;
					}
					num = num27 ^ ((int)num2 * -1222068126);
					continue;
				}
				case 76u:
					num = ((int)num2 * -946983835) ^ -639092463;
					continue;
				case 75u:
					num = (int)((num2 * 569710971) ^ 0x5EF47A82);
					continue;
				case 74u:
				{
					int num11;
					int num12;
					if (!flag)
					{
						num11 = -1109296622;
						num12 = -1109296622;
					}
					else
					{
						num11 = -1678760870;
						num12 = -1678760870;
					}
					num = num11 ^ (int)(num2 * 291794375);
					continue;
				}
				case 73u:
				{
					int num31;
					if (int_0 == 4)
					{
						num = -813137201;
						num31 = -813137201;
					}
					else
					{
						num = -1109522244;
						num31 = -1109522244;
					}
					continue;
				}
				case 72u:
					num = (int)(num2 * 1020029540) ^ -190610379;
					continue;
				case 71u:
				{
					int num24;
					if (int_0 == 3)
					{
						num = -307257246;
						num24 = -307257246;
					}
					else
					{
						num = -543645044;
						num24 = -543645044;
					}
					continue;
				}
				case 70u:
					num = ((int)num2 * -1015309570) ^ -1830054994;
					continue;
				case 69u:
					flag12 = int_0 == 9;
					num = -1318052820;
					continue;
				case 67u:
					num = ((int)num2 * -2062010513) ^ -369390228;
					continue;
				case 66u:
					num = (int)(num2 * 137968733) ^ -82731557;
					continue;
				case 65u:
					GForm3.smethod_45((Control)(object)Class2.Class3_0.GForm0_0);
					GForm3.smethod_46((Form)(object)this);
					num = (int)(num2 * 724579225) ^ -1581303163;
					continue;
				case 64u:
					GClass1.smethod_2().method_4();
					num = (int)((num2 * 1273927181) ^ 0x3E082179);
					continue;
				case 63u:
				{
					int num17;
					int num18;
					if (flag7)
					{
						num17 = 1033120414;
						num18 = 1033120414;
					}
					else
					{
						num17 = 647809402;
						num18 = 647809402;
					}
					num = num17 ^ ((int)num2 * -1279875881);
					continue;
				}
				case 62u:
					GForm3.smethod_17(Label_0, "Un mondo pieno di pedofili, maniaci, assassini, pazzi,\r\npersone pluripregiudicate e morti di figa...");
					num = (int)(num2 * 2021376651) ^ -1054089288;
					continue;
				case 61u:
					num = ((int)num2 * -998800299) ^ 0x75306C2;
					continue;
				case 60u:
					GForm3.smethod_17(Label_0, "Così egli capii che c'era un solo modo di porre fine\r\nad ogni problema...");
					num = ((int)num2 * -378393266) ^ 0x44C61F22;
					continue;
				case 59u:
					GForm3.smethod_17(Label_0, "Insieme a questo mago e ai suoi fantastici amici, \r\npercorrerai tutta la strada di Omegle.");
					num = (int)(num2 * 1493848498) ^ -303649882;
					continue;
				case 58u:
					flag8 = int_0 == 10;
					num = -378796622;
					continue;
				case 57u:
				{
					int num7;
					int num8;
					if (flag4)
					{
						num7 = 1538373692;
						num8 = 1538373692;
					}
					else
					{
						num7 = 1797638425;
						num8 = 1797638425;
					}
					num = num7 ^ ((int)num2 * -832671509);
					continue;
				}
				case 56u:
					num = -2121174271;
					continue;
				case 55u:
					num = (int)((num2 * 1243722620) ^ 0x22E5ABB5);
					continue;
				case 54u:
					GForm3.smethod_17(Label_0, "Ma lui era solo un semplice mago, come poteva riuscire\r\nad affrontare le agonie contenute là dentro?");
					num = (int)(num2 * 1952351588) ^ -2131661770;
					continue;
				case 53u:
					GForm3.smethod_17(Label_0, "Ma non riuscì bene ad orientarsi... c'era tante persone\r\nche gli ostacolavano il cammino...");
					num = ((int)num2 * -230888256) ^ 0x70ACA62E;
					continue;
				case 52u:
					num = (int)((num2 * 1319151101) ^ 0xE30C954);
					continue;
				case 51u:
					num = ((int)num2 * -695553930) ^ -1065323596;
					continue;
				case 50u:
					flag9 = int_0 == 14;
					num = -1551776161;
					continue;
				case 49u:
					num = ((int)num2 * -998812091) ^ -1927573937;
					continue;
				case 48u:
					num = (int)(num2 * 644758805) ^ -407935527;
					continue;
				case 47u:
					num = (int)((num2 * 1717779451) ^ 0x359EE050);
					continue;
				case 46u:
					num = ((int)num2 * -2085040455) ^ 0x36949903;
					continue;
				case 45u:
					flag11 = int_0 == 12;
					num = -1894230899;
					continue;
				case 44u:
					num = -466840115;
					continue;
				case 43u:
					num = ((int)num2 * -804276494) ^ -945096077;
					continue;
				case 42u:
				{
					int num29;
					int num30;
					if (flag10)
					{
						num29 = 330151755;
						num30 = 330151755;
					}
					else
					{
						num29 = 196982738;
						num30 = 196982738;
					}
					num = num29 ^ (int)(num2 * 1308903799);
					continue;
				}
				case 41u:
				{
					int num25;
					int num26;
					if (!flag6)
					{
						num25 = 23628960;
						num26 = 23628960;
					}
					else
					{
						num25 = 385043239;
						num26 = 385043239;
					}
					num = num25 ^ (int)(num2 * 1299995757);
					continue;
				}
				case 40u:
					GClass1.smethod_2().method_3();
					num = ((int)num2 * -836243729) ^ 0x6DAF7516;
					continue;
				case 39u:
					num = ((int)num2 * -1448940475) ^ -1167304466;
					continue;
				case 38u:
					GForm3.smethod_17(Label_0, "Un mago molto misterioso, dagli oscuri segreti... andò\r\nsu OmeTV, quella sera.");
					num = (int)((num2 * 1935802351) ^ 0xC5C337);
					continue;
				case 37u:
					GForm3.smethod_17(Label_0, "Sono delle persone che hanno delle grandissime capacità\r\nda disabili, ma non solo.");
					num = (int)(num2 * 154158318) ^ -1586809244;
					continue;
				case 36u:
					flag13 = int_0 == 11;
					num = -521675008;
					continue;
				case 35u:
					num = (int)((num2 * 802024081) ^ 0x2B6AD826);
					continue;
				case 34u:
					GForm3.smethod_17(Label_0, "Purtroppo la noia è una droga molto cancerosa, ed egli\r\nsi mise alla ricerca di nuove avventure.");
					num = (int)(num2 * 34073588) ^ -289282668;
					continue;
				case 33u:
					num = (int)((num2 * 1674940585) ^ 0x10A47388);
					continue;
				case 32u:
					num = (int)(num2 * 1143392797) ^ -502139899;
					continue;
				case 31u:
					GForm3.smethod_17(Label_0, "Egli poteva fare trucchi di magia con le carte e con i\r\ncubi agli sconosciuti... Bello, no?");
					num = (int)((num2 * 1243409767) ^ 0x5EFD9E0F);
					continue;
				case 30u:
					GForm3.smethod_17(Label_0, "Queste persone trascorrono il loro tempo libero, la loro\r\nintera vita su Omegle, con gli altri.");
					num = ((int)num2 * -872704367) ^ -1496099099;
					continue;
				case 29u:
					flag3 = int_0 == 13;
					num = -1149266466;
					continue;
				case 28u:
					num = ((int)num2 * -611893511) ^ 0x6BF295FC;
					continue;
				case 27u:
					GForm3.smethod_17(Label_0, "Il mago e i suoi amici sono sempre pronti ad affrontare\r\nogni nuova sfida ed ogni pericolo.");
					num = ((int)num2 * -325112538) ^ -849780635;
					continue;
				case 26u:
				{
					int num23;
					if (int_0 == 6)
					{
						num = -665320583;
						num23 = -665320583;
					}
					else
					{
						num = -675238757;
						num23 = -675238757;
					}
					continue;
				}
				case 25u:
				{
					int num21;
					int num22;
					if (flag12)
					{
						num21 = -1112435216;
						num22 = -1112435216;
					}
					else
					{
						num21 = -1848503258;
						num22 = -1848503258;
					}
					num = num21 ^ (int)(num2 * 2087156641);
					continue;
				}
				case 24u:
				{
					int num19;
					int num20;
					if (!flag11)
					{
						num19 = 994305324;
						num20 = 994305324;
					}
					else
					{
						num19 = 385624835;
						num20 = 385624835;
					}
					num = num19 ^ ((int)num2 * -1797814761);
					continue;
				}
				case 23u:
				{
					int num15;
					int num16;
					if (flag8)
					{
						num15 = 959326931;
						num16 = 959326931;
					}
					else
					{
						num15 = 1079311650;
						num16 = 1079311650;
					}
					num = num15 ^ ((int)num2 * -1465940807);
					continue;
				}
				case 22u:
					flag4 = int_0 == 2;
					num = -240936552;
					continue;
				case 21u:
					flag10 = int_0 == 15;
					num = -1225383209;
					continue;
				case 20u:
					GClass1.smethod_2().method_3();
					num = (int)((num2 * 496280755) ^ 0x550E71);
					continue;
				case 19u:
					num = (int)((num2 * 727610387) ^ 0x6DB1A37C);
					continue;
				case 18u:
				{
					int num13;
					int num14;
					if (!flag9)
					{
						num13 = -24096280;
						num14 = -24096280;
					}
					else
					{
						num13 = -867653318;
						num14 = -867653318;
					}
					num = num13 ^ (int)(num2 * 1936332932);
					continue;
				}
				case 17u:
					bool_0 = true;
					num = -1751706259;
					continue;
				case 16u:
					flag2 = int_1 == 0;
					num = ((int)num2 * -1538653601) ^ -1197187051;
					continue;
				case 15u:
					num = ((int)num2 * -1370276824) ^ 0x99005DD;
					continue;
				case 14u:
					GForm3.smethod_17(Label_0, "E il mago pian piano, nel suo tortuoso cammino,\r\nne trovò tanti di tali imperatori.");
					num = ((int)num2 * -676091477) ^ 0x3F90893C;
					continue;
				case 13u:
					num = (int)(num2 * 1377141877) ^ -39782780;
					continue;
				case 12u:
					GForm3.smethod_17(Label_0, "In pochi sanno chi sono, ma lui riuscì a vedere di più:\r\nerano gli imperatori di Omegle.");
					num = (int)(num2 * 2010674524) ^ -2024564256;
					continue;
				case 11u:
				{
					int num9;
					int num10;
					if (!flag5)
					{
						num9 = 1350602229;
						num10 = 1350602229;
					}
					else
					{
						num9 = 1609452885;
						num10 = 1609452885;
					}
					num = num9 ^ (int)(num2 * 161720890);
					continue;
				}
				case 10u:
					num = (int)((num2 * 190392633) ^ 0x21585A7C);
					continue;
				case 9u:
					flag7 = int_0 == 1;
					num = (int)(num2 * 201501622) ^ -1244232220;
					continue;
				case 8u:
					GForm3.smethod_13((Control)(object)Label_0, new Point(checked(GForm3.smethod_44((Control)(object)Label_0).X + 60), GForm3.smethod_44((Control)(object)Label_0).Y));
					GForm3.smethod_17(Label_0, "Che il gioco abbia inizio!");
					num = ((int)num2 * -1769096604) ^ -1343537073;
					continue;
				case 7u:
					GForm3.smethod_17(Label_0, "Non sapeva bene cosa lo attendeva, ma sapeva bene che\r\n era un grande pericolo intrufolarsi là dentro.");
					num = (int)(num2 * 34044045) ^ -1984507862;
					continue;
				case 6u:
					flag6 = int_0 == 7;
					num = -1602974036;
					continue;
				case 5u:
					flag5 = int_0 == 5;
					num = -507414706;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (!flag2)
					{
						num3 = 824514253;
						num4 = 824514253;
					}
					else
					{
						num3 = 1684794984;
						num4 = 1684794984;
					}
					num = num3 ^ (int)(num2 * 1444385686);
					continue;
				}
				case 3u:
					num = (int)(num2 * 137838598) ^ -585363625;
					continue;
				case 1u:
					num = ((int)num2 * -527048279) ^ 0x5E8B43F0;
					continue;
				case 0u:
					flag = int_0 == 8;
					num = -810586597;
					continue;
				default:
					return;
				case 2u:
					break;
				case 68u:
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

	static void smethod_1(Form form_0, FormClosingEventHandler formClosingEventHandler_0)
	{
		form_0.add_FormClosing(formClosingEventHandler_0);
	}

	static void smethod_2(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Container smethod_3()
	{
		return new Container();
	}

	static Timer smethod_4(IContainer icontainer_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new Timer(icontainer_1);
	}

	static Label smethod_5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Label();
	}

	static void smethod_6(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_7(Timer timer_2, int int_2)
	{
		timer_2.set_Interval(int_2);
	}

	static void smethod_8(Label label_1, bool bool_1)
	{
		label_1.set_AutoSize(bool_1);
	}

	static void smethod_9(Control control_0, Color color_0)
	{
		control_0.set_BackColor(color_0);
	}

	static Font smethod_10(string string_0, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_11(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static void smethod_12(Control control_0, Color color_0)
	{
		control_0.set_ForeColor(color_0);
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

	static void smethod_16(Control control_0, int int_2)
	{
		control_0.set_TabIndex(int_2);
	}

	static void smethod_17(Label label_1, string string_0)
	{
		label_1.set_Text(string_0);
	}

	static void smethod_18(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_19(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_20(Form form_0, Color color_0)
	{
		form_0.set_BackColor(color_0);
	}

	static void smethod_21(Control control_0, ImageLayout imageLayout_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_BackgroundImageLayout(imageLayout_0);
	}

	static void smethod_22(Form form_0, Size size_0)
	{
		form_0.set_ClientSize(size_0);
	}

	static ControlCollection smethod_23(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_24(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_25(Form form_0, FormBorderStyle formBorderStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_FormBorderStyle(formBorderStyle_0);
	}

	static void smethod_26(Form form_0, Padding padding_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_Margin(padding_0);
	}

	static void smethod_27(Form form_0, bool bool_1)
	{
		form_0.set_MaximizeBox(bool_1);
	}

	static void smethod_28(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_29(Form form_0, FormStartPosition formStartPosition_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_StartPosition(formStartPosition_0);
	}

	static void smethod_30(Form form_0, string string_0)
	{
		form_0.set_Text(string_0);
	}

	static void smethod_31(Control control_0, bool bool_1)
	{
		control_0.ResumeLayout(bool_1);
	}

	static void smethod_32(Control control_0)
	{
		control_0.PerformLayout();
	}

	static void smethod_33(Timer timer_2, EventHandler eventHandler_0)
	{
		timer_2.remove_Tick(eventHandler_0);
	}

	static void smethod_34(Timer timer_2, EventHandler eventHandler_0)
	{
		timer_2.add_Tick(eventHandler_0);
	}

	static Process smethod_35()
	{
		return Process.GetCurrentProcess();
	}

	static void smethod_36(Process process_0, ProcessPriorityClass processPriorityClass_0)
	{
		process_0.PriorityClass = processPriorityClass_0;
	}

	static void smethod_37(Timer timer_2)
	{
		timer_2.Start();
	}

	static void smethod_38()
	{
		GC.Collect();
	}

	static void smethod_39(CancelEventArgs cancelEventArgs_0, bool bool_1)
	{
		cancelEventArgs_0.Cancel = bool_1;
	}

	static DialogResult smethod_40(string string_0, string string_1, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0, string_1, messageBoxButtons_0, messageBoxIcon_0);
	}

	static void smethod_41(Timer timer_2)
	{
		timer_2.Stop();
	}

	static void smethod_42(object object_0)
	{
		GC.SuppressFinalize(object_0);
	}

	static void smethod_43(Process process_0)
	{
		process_0.Kill();
	}

	static Point smethod_44(Control control_0)
	{
		return control_0.get_Location();
	}

	static void smethod_45(Control control_0)
	{
		control_0.Show();
	}

	static void smethod_46(Form form_0)
	{
		form_0.Close();
	}
}
