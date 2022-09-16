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
		Timer timer_ = Light.smethod_0();
		while (true)
		{
			int num = 229120671;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1B6753D8u) % 6u)
				{
				case 5u:
					Light.smethod_3(timer_, bool_0: true);
					num = (int)(num2 * 977355369) ^ -1043982432;
					continue;
				case 3u:
					num = (int)(num2 * 1198250063) ^ -1213377671;
					continue;
				case 2u:
					Light.smethod_2(timer_, 2000.0);
					num = (int)(num2 * 1688103560) ^ -1846871543;
					continue;
				case 1u:
					Light.smethod_1(timer_, (ElapsedEventHandler)SetLight);
					num = (int)((num2 * 2041242178) ^ 0x12DD0C4A);
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

	private void SetLight(object sender, ElapsedEventArgs e)
	{
		Light.smethod_5(Light.smethod_4((DispatcherObject)(object)sim), (Delegate)new Action(changeLight), (DispatcherPriority)4, new object[0]);
	}

	private void changeLight()
	{
		if (TrafficPlan.green == Light.smethod_6((Shape)(object)sim.light1))
		{
			goto IL_035d;
		}
		goto IL_097c;
		IL_097c:
		Light.smethod_7((Shape)(object)sim.light1, TrafficPlan.green);
		Light.smethod_7((Shape)(object)sim.light2, TrafficPlan.red);
		int num = -411892568;
		goto IL_0866;
		IL_0866:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xAF08B468u) % 65u)
			{
			case 64u:
				Light.smethod_7((Shape)(object)sim.light24, TrafficPlan.green);
				num = (int)((num2 * 173238333) ^ 0x12A84504);
				continue;
			case 63u:
				Light.smethod_7((Shape)(object)sim.light8, TrafficPlan.green);
				num = ((int)num2 * -2131649658) ^ 0x6FB69C6A;
				continue;
			case 62u:
				num = ((int)num2 * -891222083) ^ 0xF2E4F3E;
				continue;
			case 61u:
				Light.smethod_7((Shape)(object)sim.light7, TrafficPlan.green);
				num = ((int)num2 * -1168951427) ^ 0x1CA0517C;
				continue;
			case 60u:
				num = (int)(num2 * 1553478113) ^ -1278428871;
				continue;
			case 59u:
				Light.smethod_7((Shape)(object)sim.light11, TrafficPlan.red);
				num = (int)(num2 * 1012554864) ^ -1640793417;
				continue;
			case 58u:
				num = (int)(num2 * 880927087) ^ -1750840873;
				continue;
			case 57u:
				num = ((int)num2 * -1701665197) ^ 0x3DD49401;
				continue;
			case 56u:
				num = ((int)num2 * -2123863286) ^ 0x724CAF16;
				continue;
			case 55u:
				Light.smethod_7((Shape)(object)sim.light23, TrafficPlan.green);
				num = (int)(num2 * 1647069976) ^ -617880165;
				continue;
			case 54u:
				num = ((int)num2 * -1904209037) ^ 0x19AF901A;
				continue;
			case 53u:
				Light.smethod_7((Shape)(object)sim.light1, TrafficPlan.red);
				num = (int)((num2 * 1759369190) ^ 0x79D7D549);
				continue;
			case 52u:
				num = ((int)num2 * -1341189845) ^ 0x10CE3A71;
				continue;
			case 51u:
				Light.smethod_7((Shape)(object)sim.light18, TrafficPlan.green);
				num = (int)(num2 * 319261442) ^ -658490792;
				continue;
			case 50u:
				num = ((int)num2 * -879812902) ^ 0x274A1547;
				continue;
			case 48u:
				num = ((int)num2 * -1463540081) ^ -1210932949;
				continue;
			case 47u:
				Light.smethod_7((Shape)(object)sim.light3, TrafficPlan.green);
				num = ((int)num2 * -1763879570) ^ 0x5DCA1DA3;
				continue;
			case 46u:
				Light.smethod_7((Shape)(object)sim.light21, TrafficPlan.green);
				Light.smethod_7((Shape)(object)sim.light22, TrafficPlan.red);
				num = (int)(num2 * 1149413744) ^ -1908786717;
				continue;
			case 45u:
				Light.smethod_7((Shape)(object)sim.light22, TrafficPlan.green);
				num = ((int)num2 * -318657171) ^ -1871265281;
				continue;
			case 44u:
				Light.smethod_7((Shape)(object)sim.light10, TrafficPlan.green);
				num = (int)(num2 * 1263981872) ^ -772483452;
				continue;
			case 43u:
				Light.smethod_7((Shape)(object)sim.light6, TrafficPlan.green);
				num = ((int)num2 * -1344972066) ^ -707691656;
				continue;
			case 42u:
				Light.smethod_7((Shape)(object)sim.light9, TrafficPlan.green);
				num = ((int)num2 * -1242041767) ^ -1077794947;
				continue;
			case 41u:
				Light.smethod_7((Shape)(object)sim.light24, TrafficPlan.red);
				num = (int)(num2 * 2100519391) ^ -1216026206;
				continue;
			case 40u:
				Light.smethod_7((Shape)(object)sim.light4, TrafficPlan.green);
				Light.smethod_7((Shape)(object)sim.light5, TrafficPlan.red);
				num = ((int)num2 * -170045549) ^ 0x7D9F0B1A;
				continue;
			case 39u:
				Light.smethod_7((Shape)(object)sim.light7, TrafficPlan.red);
				num = ((int)num2 * -1262220004) ^ -1027239147;
				continue;
			case 38u:
				break;
			case 37u:
				Light.smethod_7((Shape)(object)sim.light12, TrafficPlan.green);
				Light.smethod_7((Shape)(object)sim.light13, TrafficPlan.green);
				num = (int)((num2 * 821536309) ^ 0x6F9E5788);
				continue;
			case 36u:
				Light.smethod_7((Shape)(object)sim.light25, TrafficPlan.red);
				num = ((int)num2 * -2106538220) ^ -2042079149;
				continue;
			case 35u:
				Light.smethod_7((Shape)(object)sim.light2, TrafficPlan.green);
				num = ((int)num2 * -698373484) ^ 0x76B9E003;
				continue;
			case 34u:
				Light.smethod_7((Shape)(object)sim.light10, TrafficPlan.red);
				num = ((int)num2 * -827656221) ^ -1755319305;
				continue;
			case 33u:
				Light.smethod_7((Shape)(object)sim.light3, TrafficPlan.red);
				num = (int)((num2 * 611071336) ^ 0x25BE1A33);
				continue;
			case 32u:
				num = (int)(num2 * 1538974025) ^ -198946537;
				continue;
			case 31u:
				Light.smethod_7((Shape)(object)sim.light19, TrafficPlan.red);
				Light.smethod_7((Shape)(object)sim.light20, TrafficPlan.red);
				num = ((int)num2 * -591840539) ^ -198649280;
				continue;
			case 30u:
				Light.smethod_7((Shape)(object)sim.light5, TrafficPlan.green);
				num = (int)((num2 * 1594524657) ^ 0x6B112217);
				continue;
			case 28u:
				num = (int)((num2 * 494786417) ^ 0x2B5A9603);
				continue;
			case 27u:
				Light.smethod_7((Shape)(object)sim.light14, TrafficPlan.green);
				num = (int)(num2 * 467117536) ^ -892351972;
				continue;
			case 26u:
				Light.smethod_7((Shape)(object)sim.light16, TrafficPlan.green);
				Light.smethod_7((Shape)(object)sim.light17, TrafficPlan.green);
				num = (int)((num2 * 1722257781) ^ 0x15B01051);
				continue;
			case 25u:
				Light.smethod_7((Shape)(object)sim.light15, TrafficPlan.green);
				num = ((int)num2 * -500603102) ^ 0x2ABEC57A;
				continue;
			case 24u:
				Light.smethod_7((Shape)(object)sim.light11, TrafficPlan.green);
				num = (int)((num2 * 1982451613) ^ 0x395BB817);
				continue;
			case 23u:
				num = (int)(num2 * 249439596) ^ -412072049;
				continue;
			case 22u:
				Light.smethod_7((Shape)(object)sim.light14, TrafficPlan.red);
				num = ((int)num2 * -647449119) ^ 0xFC390E7;
				continue;
			case 21u:
				Light.smethod_7((Shape)(object)sim.light17, TrafficPlan.red);
				num = ((int)num2 * -453460451) ^ 0x7F25FD54;
				continue;
			case 20u:
				Light.smethod_7((Shape)(object)sim.light8, TrafficPlan.red);
				num = (int)((num2 * 2017382671) ^ 0x63B3A7E);
				continue;
			case 19u:
				num = ((int)num2 * -656311558) ^ 0x7EAA2C89;
				continue;
			case 18u:
				Light.smethod_7((Shape)(object)sim.light16, TrafficPlan.red);
				num = (int)((num2 * 118969166) ^ 0x1226427E);
				continue;
			case 17u:
				Light.smethod_7((Shape)(object)sim.light15, TrafficPlan.red);
				num = (int)(num2 * 2122622870) ^ -50270815;
				continue;
			case 16u:
				num = (int)(num2 * 1058931104) ^ -1219865459;
				continue;
			case 15u:
				Light.smethod_7((Shape)(object)sim.light18, TrafficPlan.red);
				Light.smethod_7((Shape)(object)sim.light19, TrafficPlan.green);
				Light.smethod_7((Shape)(object)sim.light20, TrafficPlan.green);
				num = ((int)num2 * -382844956) ^ 0x3DFFDAEB;
				continue;
			case 14u:
				Light.smethod_7((Shape)(object)sim.light9, TrafficPlan.red);
				num = ((int)num2 * -1040567883) ^ -1516956624;
				continue;
			case 13u:
				num = (int)(num2 * 515431796) ^ -1135890450;
				continue;
			case 12u:
				num = ((int)num2 * -1731290234) ^ 0x71EAD499;
				continue;
			case 11u:
				Light.smethod_7((Shape)(object)sim.light12, TrafficPlan.red);
				Light.smethod_7((Shape)(object)sim.light13, TrafficPlan.red);
				num = ((int)num2 * -1671595125) ^ 0xF72EDEA;
				continue;
			case 10u:
				num = (int)(num2 * 2066109227) ^ -1927597172;
				continue;
			case 9u:
				num = (int)((num2 * 234120250) ^ 0x39D3BE08);
				continue;
			case 8u:
				num = (int)((num2 * 575757385) ^ 0x1F188636);
				continue;
			case 7u:
				Light.smethod_7((Shape)(object)sim.light21, TrafficPlan.red);
				num = (int)((num2 * 846441867) ^ 0x3848DBF8);
				continue;
			case 6u:
				num = ((int)num2 * -1321028967) ^ -910874109;
				continue;
			case 5u:
				Light.smethod_7((Shape)(object)sim.light25, TrafficPlan.green);
				num = ((int)num2 * -17449598) ^ 0x373D61ED;
				continue;
			case 4u:
				Light.smethod_7((Shape)(object)sim.light4, TrafficPlan.red);
				num = ((int)num2 * -989992628) ^ -198420933;
				continue;
			case 3u:
				Light.smethod_7((Shape)(object)sim.light23, TrafficPlan.red);
				num = ((int)num2 * -436415468) ^ -1975845768;
				continue;
			case 2u:
				Light.smethod_7((Shape)(object)sim.light6, TrafficPlan.red);
				num = (int)(num2 * 1026434538) ^ -591372311;
				continue;
			case 1u:
				num = (int)((num2 * 49899049) ^ 0x29C341AB);
				continue;
			case 0u:
				num = (int)(num2 * 1025657841) ^ -1709419940;
				continue;
			default:
				return;
			case 29u:
				goto IL_097c;
			case 49u:
				return;
			}
			break;
		}
		goto IL_035d;
		IL_035d:
		num = -1033219998;
		goto IL_0866;
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
