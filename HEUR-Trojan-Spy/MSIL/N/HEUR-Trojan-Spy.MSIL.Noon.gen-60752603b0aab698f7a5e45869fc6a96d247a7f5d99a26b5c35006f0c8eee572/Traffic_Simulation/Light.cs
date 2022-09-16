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
		Timer timer_ = default(Timer);
		while (true)
		{
			int num = -480997726;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBA5A5C7Du) % 10u)
				{
				case 9u:
					timer_ = Light.smethod_0();
					num = (int)((num2 * 1545802781) ^ 0x60F3D38E);
					continue;
				case 8u:
					Light.smethod_1(timer_, (ElapsedEventHandler)SetLight);
					num = ((int)num2 * -111381928) ^ 0x6C10538D;
					continue;
				case 7u:
					num = ((int)num2 * -726508455) ^ 0x142BCC3E;
					continue;
				case 6u:
					num = (int)(num2 * 159386404) ^ -1664364615;
					continue;
				case 5u:
					Light.smethod_2(timer_, 2000.0);
					num = (int)((num2 * 200096784) ^ 0x155B1875);
					continue;
				case 2u:
					num = ((int)num2 * -2100053750) ^ 0x4950F9E6;
					continue;
				case 1u:
					this.sim = sim;
					num = (int)((num2 * 475953436) ^ 0x6624E62);
					continue;
				case 0u:
					Light.smethod_3(timer_, bool_0: true);
					num = ((int)num2 * -605515408) ^ 0x7F0B18EE;
					continue;
				default:
					return;
				case 3u:
					break;
				case 4u:
					return;
				}
				break;
			}
		}
	}

	private void SetLight(object sender, ElapsedEventArgs e)
	{
		Light.smethod_5(Light.smethod_4((DispatcherObject)(object)sim), (Delegate)new Action(changeLight), (DispatcherPriority)4, new object[0]);
	}

	private void changeLight()
	{
		while (true)
		{
			int num = -498053587;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA3B59399u) % 70u)
				{
				case 69u:
					Light.smethod_7((Shape)(object)sim.light19, TrafficPlan.green);
					Light.smethod_7((Shape)(object)sim.light20, TrafficPlan.green);
					num = (int)(num2 * 1333204213) ^ -1051737552;
					continue;
				case 68u:
					Light.smethod_7((Shape)(object)sim.light14, TrafficPlan.green);
					Light.smethod_7((Shape)(object)sim.light15, TrafficPlan.red);
					num = ((int)num2 * -846463847) ^ 0x2BC45048;
					continue;
				case 67u:
					num = (int)((num2 * 1286758086) ^ 0x236BAD06);
					continue;
				case 66u:
					num = ((int)num2 * -587800973) ^ 0x45A97A48;
					continue;
				case 65u:
					Light.smethod_7((Shape)(object)sim.light14, TrafficPlan.red);
					num = ((int)num2 * -178477175) ^ -1387868496;
					continue;
				case 64u:
					Light.smethod_7((Shape)(object)sim.light21, TrafficPlan.red);
					Light.smethod_7((Shape)(object)sim.light22, TrafficPlan.green);
					num = (int)(num2 * 1656189771) ^ -153643974;
					continue;
				case 63u:
					Light.smethod_7((Shape)(object)sim.light21, TrafficPlan.green);
					num = (int)((num2 * 1714923070) ^ 0x5C77A1B3);
					continue;
				case 62u:
					Light.smethod_7((Shape)(object)sim.light10, TrafficPlan.red);
					num = (int)((num2 * 1279168004) ^ 0x7754C8D5);
					continue;
				case 61u:
					num = ((int)num2 * -1868523847) ^ -330177752;
					continue;
				case 60u:
					Light.smethod_7((Shape)(object)sim.light11, TrafficPlan.red);
					num = ((int)num2 * -1777920934) ^ 0x7283F0A6;
					continue;
				case 59u:
					Light.smethod_7((Shape)(object)sim.light17, TrafficPlan.red);
					num = (int)((num2 * 931289083) ^ 0x6B18D3A8);
					continue;
				case 58u:
					Light.smethod_7((Shape)(object)sim.light10, TrafficPlan.green);
					num = (int)(num2 * 1276284463) ^ -238588473;
					continue;
				case 57u:
					num = ((int)num2 * -127184959) ^ 0x1FC4D6A0;
					continue;
				case 56u:
					num = (int)((num2 * 2034561134) ^ 0x3FF98EE5);
					continue;
				case 55u:
					Light.smethod_7((Shape)(object)sim.light25, TrafficPlan.red);
					num = ((int)num2 * -1909537640) ^ 0x41C30A3A;
					continue;
				case 54u:
					Light.smethod_7((Shape)(object)sim.light11, TrafficPlan.green);
					num = ((int)num2 * -57922746) ^ 0x285C7D33;
					continue;
				case 53u:
					num = (int)((num2 * 826411160) ^ 0x4D14BAFC);
					continue;
				case 52u:
					Light.smethod_7((Shape)(object)sim.light25, TrafficPlan.green);
					num = ((int)num2 * -1470247437) ^ 0x3E0705EB;
					continue;
				case 51u:
					num = (int)(num2 * 1037263361) ^ -184203067;
					continue;
				case 50u:
					num = ((int)num2 * -844872894) ^ -524907988;
					continue;
				case 49u:
					num = (int)((num2 * 726007367) ^ 0x38ED3C21);
					continue;
				case 48u:
					Light.smethod_7((Shape)(object)sim.light8, TrafficPlan.red);
					Light.smethod_7((Shape)(object)sim.light9, TrafficPlan.red);
					num = ((int)num2 * -1518665905) ^ -1118707718;
					continue;
				case 47u:
					Light.smethod_7((Shape)(object)sim.light6, TrafficPlan.red);
					num = (int)(num2 * 875765997) ^ -1526566932;
					continue;
				case 46u:
					Light.smethod_7((Shape)(object)sim.light13, TrafficPlan.green);
					num = ((int)num2 * -1761396357) ^ -1997676439;
					continue;
				case 45u:
					Light.smethod_7((Shape)(object)sim.light20, TrafficPlan.red);
					num = (int)(num2 * 364517593) ^ -566059429;
					continue;
				case 43u:
					num = ((int)num2 * -1102817988) ^ -925705511;
					continue;
				case 42u:
					num = (int)((num2 * 1187240682) ^ 0x5912D152);
					continue;
				case 41u:
					Light.smethod_7((Shape)(object)sim.light12, TrafficPlan.red);
					num = ((int)num2 * -1205676055) ^ 0x324A7A05;
					continue;
				case 40u:
				{
					int num3;
					int num4;
					if (TrafficPlan.green == Light.smethod_6((Shape)(object)sim.light1))
					{
						num3 = 1760426952;
						num4 = 1760426952;
					}
					else
					{
						num3 = 23578733;
						num4 = 23578733;
					}
					num = num3 ^ (int)(num2 * 1682367900);
					continue;
				}
				case 39u:
					Light.smethod_7((Shape)(object)sim.light4, TrafficPlan.green);
					Light.smethod_7((Shape)(object)sim.light5, TrafficPlan.red);
					num = (int)(num2 * 1769982416) ^ -1835549830;
					continue;
				case 38u:
					Light.smethod_7((Shape)(object)sim.light7, TrafficPlan.red);
					num = (int)(num2 * 1922097063) ^ -92794187;
					continue;
				case 37u:
					num = (int)((num2 * 2051594403) ^ 0x2219BC32);
					continue;
				case 36u:
					Light.smethod_7((Shape)(object)sim.light15, TrafficPlan.green);
					num = (int)((num2 * 893435491) ^ 0x251713FD);
					continue;
				case 35u:
					num = ((int)num2 * -538243387) ^ 0x6E9D9AF0;
					continue;
				case 34u:
					Light.smethod_7((Shape)(object)sim.light13, TrafficPlan.red);
					num = (int)(num2 * 1913807858) ^ -1851719154;
					continue;
				case 33u:
					num = (int)((num2 * 1552458353) ^ 0x20B4D200);
					continue;
				case 32u:
					Light.smethod_7((Shape)(object)sim.light18, TrafficPlan.red);
					num = (int)(num2 * 733119399) ^ -367884489;
					continue;
				case 31u:
					Light.smethod_7((Shape)(object)sim.light5, TrafficPlan.green);
					num = ((int)num2 * -306490009) ^ -584347572;
					continue;
				case 30u:
					Light.smethod_7((Shape)(object)sim.light17, TrafficPlan.green);
					num = (int)(num2 * 235491091) ^ -1778625836;
					continue;
				case 29u:
					Light.smethod_7((Shape)(object)sim.light1, TrafficPlan.red);
					Light.smethod_7((Shape)(object)sim.light2, TrafficPlan.green);
					num = (int)(num2 * 726934396) ^ -1490160948;
					continue;
				case 28u:
					num = ((int)num2 * -921985942) ^ -708119476;
					continue;
				case 27u:
					Light.smethod_7((Shape)(object)sim.light18, TrafficPlan.green);
					num = (int)((num2 * 88017092) ^ 0x42537F46);
					continue;
				case 26u:
					Light.smethod_7((Shape)(object)sim.light8, TrafficPlan.green);
					num = (int)((num2 * 738421993) ^ 0x1CFA9868);
					continue;
				case 25u:
					num = (int)(num2 * 509848534) ^ -1527988643;
					continue;
				case 24u:
					Light.smethod_7((Shape)(object)sim.light16, TrafficPlan.red);
					num = (int)((num2 * 417312415) ^ 0x6B962499);
					continue;
				case 23u:
					Light.smethod_7((Shape)(object)sim.light23, TrafficPlan.green);
					num = ((int)num2 * -294281378) ^ -425343270;
					continue;
				case 22u:
					Light.smethod_7((Shape)(object)sim.light1, TrafficPlan.green);
					Light.smethod_7((Shape)(object)sim.light2, TrafficPlan.red);
					num = -2138856211;
					continue;
				case 21u:
					num = (int)(num2 * 1692577277) ^ -502269809;
					continue;
				case 20u:
					num = (int)((num2 * 1705720057) ^ 0x635A45C1);
					continue;
				case 19u:
					Light.smethod_7((Shape)(object)sim.light6, TrafficPlan.green);
					Light.smethod_7((Shape)(object)sim.light7, TrafficPlan.green);
					num = ((int)num2 * -146644652) ^ 0x3C2550B8;
					continue;
				case 18u:
					Light.smethod_7((Shape)(object)sim.light3, TrafficPlan.green);
					num = ((int)num2 * -2053801413) ^ -187635857;
					continue;
				case 17u:
					Light.smethod_7((Shape)(object)sim.light24, TrafficPlan.red);
					num = (int)(num2 * 487319102) ^ -619894309;
					continue;
				case 16u:
					num = (int)(num2 * 750638606) ^ -587375626;
					continue;
				case 15u:
					num = ((int)num2 * -485150433) ^ -1778049532;
					continue;
				case 14u:
					num = ((int)num2 * -1648206026) ^ 0x6030BB6C;
					continue;
				case 13u:
					Light.smethod_7((Shape)(object)sim.light23, TrafficPlan.red);
					Light.smethod_7((Shape)(object)sim.light24, TrafficPlan.green);
					num = (int)((num2 * 1027880181) ^ 0x1DBE7819);
					continue;
				case 12u:
					num = (int)(num2 * 1228360572) ^ -1625161166;
					continue;
				case 11u:
					num = ((int)num2 * -6359063) ^ 0x3326B618;
					continue;
				case 10u:
					Light.smethod_7((Shape)(object)sim.light3, TrafficPlan.red);
					num = (int)(num2 * 2108615572) ^ -1266510781;
					continue;
				case 9u:
					num = ((int)num2 * -1266421316) ^ -825375299;
					continue;
				case 8u:
					Light.smethod_7((Shape)(object)sim.light4, TrafficPlan.red);
					num = (int)(num2 * 1367338241) ^ -1906216274;
					continue;
				case 7u:
					num = (int)((num2 * 614975887) ^ 0x586CA785);
					continue;
				case 6u:
					num = ((int)num2 * -1792228021) ^ -1287236960;
					continue;
				case 5u:
					Light.smethod_7((Shape)(object)sim.light9, TrafficPlan.green);
					num = (int)((num2 * 2137742274) ^ 0x5C4675E9);
					continue;
				case 4u:
					Light.smethod_7((Shape)(object)sim.light16, TrafficPlan.green);
					num = (int)((num2 * 815401133) ^ 0x6EB20ABA);
					continue;
				case 3u:
					Light.smethod_7((Shape)(object)sim.light19, TrafficPlan.red);
					num = ((int)num2 * -1269851876) ^ 0x473AB5D0;
					continue;
				case 2u:
					Light.smethod_7((Shape)(object)sim.light22, TrafficPlan.red);
					num = (int)((num2 * 980924603) ^ 0x4DE5E755);
					continue;
				case 1u:
					Light.smethod_7((Shape)(object)sim.light12, TrafficPlan.green);
					num = (int)(num2 * 22429212) ^ -2135036936;
					continue;
				default:
					return;
				case 0u:
					break;
				case 44u:
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
