using System;
using System.Timers;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Traffic_Simulation;

internal class Light
{
	private Simulation sim = null;

	public void StartLight(Simulation sim)
	{
		this.sim = sim;
		Timer timer_ = default(Timer);
		while (true)
		{
			int num = 1568424602;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x57E73E90u) % 8u)
				{
				case 7u:
					Light.smethod_2(timer_, 2000.0);
					num = ((int)num2 * -899517266) ^ 0x575A8CB3;
					continue;
				case 5u:
					num = (int)((num2 * 432052341) ^ 0x68D38AEE);
					continue;
				case 3u:
					Light.smethod_1(timer_, (ElapsedEventHandler)SetLight);
					num = ((int)num2 * -591256157) ^ -732595332;
					continue;
				case 2u:
					timer_ = Light.smethod_0();
					num = (int)((num2 * 647172287) ^ 0xCDCAE45);
					continue;
				case 1u:
					Light.smethod_3(timer_, bool_0: true);
					num = ((int)num2 * -1123055799) ^ -204865263;
					continue;
				case 0u:
					num = (int)(num2 * 926202032) ^ -626066634;
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

	private void SetLight(object sender, ElapsedEventArgs e)
	{
		while (true)
		{
			int num = -596554391;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB033BE31u) % 3u)
				{
				case 1u:
					goto IL_0003;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0003:
				Light.smethod_5(Light.smethod_4((DispatcherObject)(object)sim), (Delegate)new Action(changeLight), (DispatcherPriority)4, new object[0]);
				num = ((int)num2 * -802991964) ^ -467371624;
			}
		}
	}

	private void changeLight()
	{
		while (true)
		{
			int num = -847307537;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xED03132Cu) % 67u)
				{
				case 66u:
					Light.smethod_7((Shape)(object)sim.light22, TrafficPlan.red);
					num = ((int)num2 * -623179419) ^ 0x1E370A12;
					continue;
				case 65u:
					num = -798954738;
					continue;
				case 64u:
					Light.smethod_7((Shape)(object)sim.light7, TrafficPlan.green);
					num = (int)((num2 * 1295142552) ^ 0xDC931CF);
					continue;
				case 63u:
					num = ((int)num2 * -1521835670) ^ 0x52A2695;
					continue;
				case 62u:
					Light.smethod_7((Shape)(object)sim.light23, TrafficPlan.red);
					num = ((int)num2 * -1545053607) ^ -1775810274;
					continue;
				case 61u:
					Light.smethod_7((Shape)(object)sim.light23, TrafficPlan.green);
					num = ((int)num2 * -673588016) ^ 0x15C72FB;
					continue;
				case 60u:
					Light.smethod_7((Shape)(object)sim.light14, TrafficPlan.green);
					num = ((int)num2 * -1653860273) ^ -1930661441;
					continue;
				case 59u:
					Light.smethod_7((Shape)(object)sim.light12, TrafficPlan.green);
					num = (int)((num2 * 161358764) ^ 0x59FD88DA);
					continue;
				case 58u:
					Light.smethod_7((Shape)(object)sim.light5, TrafficPlan.red);
					num = ((int)num2 * -348748483) ^ -688362797;
					continue;
				case 57u:
					Light.smethod_7((Shape)(object)sim.light3, TrafficPlan.green);
					num = ((int)num2 * -646741789) ^ 0x79D503DB;
					continue;
				case 56u:
					Light.smethod_7((Shape)(object)sim.light8, TrafficPlan.green);
					num = (int)(num2 * 472984078) ^ -890242366;
					continue;
				case 55u:
					Light.smethod_7((Shape)(object)sim.light11, TrafficPlan.green);
					num = (int)((num2 * 454853981) ^ 0xF474AF3);
					continue;
				case 54u:
					Light.smethod_7((Shape)(object)sim.light18, TrafficPlan.green);
					num = (int)((num2 * 517369689) ^ 0x9CBE7FB);
					continue;
				case 53u:
					Light.smethod_7((Shape)(object)sim.light2, TrafficPlan.green);
					num = ((int)num2 * -434146252) ^ 0x6F490D04;
					continue;
				case 52u:
					Light.smethod_7((Shape)(object)sim.light6, TrafficPlan.green);
					num = (int)((num2 * 1040038405) ^ 0x1E3623C3);
					continue;
				case 51u:
					Light.smethod_7((Shape)(object)sim.light20, TrafficPlan.green);
					Light.smethod_7((Shape)(object)sim.light21, TrafficPlan.green);
					num = (int)((num2 * 610117873) ^ 0x5F120ABC);
					continue;
				case 50u:
					num = (int)((num2 * 282159040) ^ 0x52DBF6BC);
					continue;
				case 49u:
					num = ((int)num2 * -2030611186) ^ 0x150CAB13;
					continue;
				case 48u:
					Light.smethod_7((Shape)(object)sim.light9, TrafficPlan.red);
					num = (int)((num2 * 728769082) ^ 0x20E46217);
					continue;
				case 47u:
					num = (int)((num2 * 35011801) ^ 0x7DB44C8F);
					continue;
				case 46u:
					Light.smethod_7((Shape)(object)sim.light15, TrafficPlan.green);
					num = (int)((num2 * 1726360453) ^ 0x75312CC8);
					continue;
				case 45u:
					num = (int)(num2 * 447256245) ^ -392836433;
					continue;
				case 44u:
					Light.smethod_7((Shape)(object)sim.light25, TrafficPlan.red);
					num = (int)((num2 * 1368197107) ^ 0x6680C4B2);
					continue;
				case 43u:
					Light.smethod_7((Shape)(object)sim.light22, TrafficPlan.green);
					num = ((int)num2 * -1648889823) ^ -373153941;
					continue;
				case 42u:
					Light.smethod_7((Shape)(object)sim.light9, TrafficPlan.green);
					num = ((int)num2 * -819365055) ^ 0x5784EFA8;
					continue;
				case 41u:
					Light.smethod_7((Shape)(object)sim.light1, TrafficPlan.green);
					num = ((int)num2 * -399699087) ^ 0x12884879;
					continue;
				case 40u:
					num = (int)(num2 * 699718606) ^ -1469629158;
					continue;
				case 39u:
					num = ((int)num2 * -752662361) ^ -282483613;
					continue;
				case 38u:
					num = ((int)num2 * -1500083780) ^ -690638352;
					continue;
				case 37u:
					Light.smethod_7((Shape)(object)sim.light24, TrafficPlan.green);
					num = ((int)num2 * -653546916) ^ -241679988;
					continue;
				case 36u:
					Light.smethod_7((Shape)(object)sim.light1, TrafficPlan.red);
					num = ((int)num2 * -263368253) ^ 0x7CEB426A;
					continue;
				case 35u:
					Light.smethod_7((Shape)(object)sim.light4, TrafficPlan.green);
					num = (int)(num2 * 947526935) ^ -1580999815;
					continue;
				case 34u:
					num = ((int)num2 * -1552394438) ^ 0x4194EF58;
					continue;
				case 33u:
					Light.smethod_7((Shape)(object)sim.light5, TrafficPlan.green);
					Light.smethod_7((Shape)(object)sim.light6, TrafficPlan.red);
					num = ((int)num2 * -2147161364) ^ 0x3F28890C;
					continue;
				case 32u:
					Light.smethod_7((Shape)(object)sim.light18, TrafficPlan.red);
					num = (int)((num2 * 1069993420) ^ 0x75C4B8B6);
					continue;
				case 31u:
					num = ((int)num2 * -1776214870) ^ -1752611744;
					continue;
				case 30u:
					Light.smethod_7((Shape)(object)sim.light16, TrafficPlan.green);
					num = ((int)num2 * -1873120476) ^ 0x4AFE1240;
					continue;
				case 28u:
				{
					int num3;
					int num4;
					if (TrafficPlan.green == Light.smethod_6((Shape)(object)sim.light1))
					{
						num3 = 990844883;
						num4 = 990844883;
					}
					else
					{
						num3 = 2075860531;
						num4 = 2075860531;
					}
					num = num3 ^ (int)(num2 * 739761193);
					continue;
				}
				case 27u:
					Light.smethod_7((Shape)(object)sim.light21, TrafficPlan.red);
					num = ((int)num2 * -670395529) ^ 0x52C6A23F;
					continue;
				case 26u:
					num = ((int)num2 * -1774469211) ^ -948297953;
					continue;
				case 25u:
					num = ((int)num2 * -351744723) ^ -883303768;
					continue;
				case 24u:
					Light.smethod_7((Shape)(object)sim.light19, TrafficPlan.red);
					Light.smethod_7((Shape)(object)sim.light20, TrafficPlan.red);
					num = (int)(num2 * 1279297910) ^ -332145126;
					continue;
				case 23u:
					Light.smethod_7((Shape)(object)sim.light19, TrafficPlan.green);
					num = ((int)num2 * -1364739422) ^ 0x4187FB6F;
					continue;
				case 22u:
					num = (int)(num2 * 1044198875) ^ -301370172;
					continue;
				case 21u:
					Light.smethod_7((Shape)(object)sim.light3, TrafficPlan.red);
					num = ((int)num2 * -1524896861) ^ 0xDE477C;
					continue;
				case 20u:
					Light.smethod_7((Shape)(object)sim.light2, TrafficPlan.red);
					num = ((int)num2 * -2113455776) ^ 0x45507FD6;
					continue;
				case 19u:
					Light.smethod_7((Shape)(object)sim.light13, TrafficPlan.red);
					num = (int)((num2 * 2116749364) ^ 0x453D5C46);
					continue;
				case 18u:
					num = (int)(num2 * 1237649303) ^ -1451810472;
					continue;
				case 17u:
					num = (int)(num2 * 1889242356) ^ -1453539284;
					continue;
				case 16u:
					Light.smethod_7((Shape)(object)sim.light16, TrafficPlan.red);
					num = (int)((num2 * 1801225367) ^ 0x30D3D0FF);
					continue;
				case 15u:
					num = (int)(num2 * 207254394) ^ -1450704190;
					continue;
				case 14u:
					Light.smethod_7((Shape)(object)sim.light12, TrafficPlan.red);
					num = ((int)num2 * -95838965) ^ -1004397565;
					continue;
				case 12u:
					Light.smethod_7((Shape)(object)sim.light17, TrafficPlan.red);
					num = (int)((num2 * 2115268030) ^ 0x31B62DCB);
					continue;
				case 11u:
					num = (int)((num2 * 597353799) ^ 0x5FD895DE);
					continue;
				case 10u:
					Light.smethod_7((Shape)(object)sim.light15, TrafficPlan.red);
					num = (int)(num2 * 1195706502) ^ -86163469;
					continue;
				case 9u:
					Light.smethod_7((Shape)(object)sim.light10, TrafficPlan.red);
					num = (int)((num2 * 973126484) ^ 0x68A321E5);
					continue;
				case 8u:
					Light.smethod_7((Shape)(object)sim.light11, TrafficPlan.red);
					num = (int)(num2 * 941909413) ^ -1794026563;
					continue;
				case 7u:
					Light.smethod_7((Shape)(object)sim.light17, TrafficPlan.green);
					num = ((int)num2 * -1254590644) ^ -1283716881;
					continue;
				case 6u:
					Light.smethod_7((Shape)(object)sim.light14, TrafficPlan.red);
					num = ((int)num2 * -1138760972) ^ 0x5C301C81;
					continue;
				case 5u:
					Light.smethod_7((Shape)(object)sim.light7, TrafficPlan.red);
					Light.smethod_7((Shape)(object)sim.light8, TrafficPlan.red);
					num = ((int)num2 * -688447875) ^ -1411264300;
					continue;
				case 4u:
					num = ((int)num2 * -103780543) ^ -1211412897;
					continue;
				case 3u:
					Light.smethod_7((Shape)(object)sim.light13, TrafficPlan.green);
					num = ((int)num2 * -424100817) ^ -2007316640;
					continue;
				case 2u:
					Light.smethod_7((Shape)(object)sim.light24, TrafficPlan.red);
					Light.smethod_7((Shape)(object)sim.light25, TrafficPlan.green);
					num = (int)((num2 * 850802482) ^ 0x6A5E9099);
					continue;
				case 1u:
					Light.smethod_7((Shape)(object)sim.light10, TrafficPlan.green);
					num = (int)(num2 * 329557098) ^ -1198137205;
					continue;
				case 0u:
					Light.smethod_7((Shape)(object)sim.light4, TrafficPlan.red);
					num = ((int)num2 * -517356334) ^ 0x6384FB7;
					continue;
				default:
					return;
				case 29u:
					break;
				case 13u:
					return;
				}
				break;
			}
		}
	}

	static Timer smethod_0()
	{
		return new Timer();
	}

	static void smethod_1(Timer timer_0, ElapsedEventHandler elapsedEventHandler_0)
	{
		timer_0.Elapsed += elapsedEventHandler_0;
	}

	static void smethod_2(Timer timer_0, double double_0)
	{
		timer_0.Interval = double_0;
	}

	static void smethod_3(Timer timer_0, bool bool_0)
	{
		timer_0.Enabled = bool_0;
	}

	static Dispatcher smethod_4(DispatcherObject dispatcherObject_0)
	{
		return dispatcherObject_0.get_Dispatcher();
	}

	static DispatcherOperation smethod_5(Dispatcher dispatcher_0, Delegate delegate_0, DispatcherPriority dispatcherPriority_0, object[] object_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return dispatcher_0.BeginInvoke(delegate_0, dispatcherPriority_0, object_0);
	}

	static Brush smethod_6(Shape shape_0)
	{
		return shape_0.get_Fill();
	}

	static void smethod_7(Shape shape_0, Brush brush_0)
	{
		shape_0.set_Fill(brush_0);
	}
}
