using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Traffic_Simulation;

public class Simulation : Window, IComponentConnector
{
	private int numberOfCars;

	private List<Car> listCar = new List<Car>();

	private Light lights = new Light();

	private int speedCar = 200;

	private int stopCar_nextPoint = 150;

	private int stopCar_entryInRoad = 150;

	private int stopCar_ExitCheckPoint = 150;

	private int timeDriveByTunnel = 4000;

	private int timeDriveUnderViaductWest = 800;

	private int timeDriveUndeViaductInsideRondoNorth = 800;

	private int timeDriveUnderViaductInsideRondoEast = 800;

	private readonly object lock_object = Simulation.smethod_0();

	private int done = 0;

	internal Canvas SomeWhere;

	internal Ellipse light1;

	internal Ellipse light2;

	internal Ellipse light3;

	internal Ellipse light4;

	internal Ellipse light5;

	internal Ellipse light6;

	internal Ellipse light7;

	internal Ellipse light8;

	internal Ellipse light9;

	internal Ellipse light10;

	internal Ellipse light11;

	internal Ellipse light12;

	internal Ellipse light13;

	internal Ellipse light14;

	internal Ellipse light15;

	internal Ellipse light16;

	internal Ellipse light17;

	internal Ellipse light18;

	internal Ellipse light19;

	internal Ellipse light20;

	internal Ellipse light21;

	internal Ellipse light22;

	internal Ellipse light23;

	internal Ellipse light24;

	internal Ellipse light25;

	private bool _contentLoaded;

	public Simulation(int countCar)
	{
		Thread thread_ = default(Thread);
		while (true)
		{
			int num = 1121622583;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x14655AFBu) % 8u)
				{
				case 7u:
					Simulation.smethod_2(thread_, bool_0: true);
					num = (int)((num2 * 1440309002) ^ 0xB3E13CF);
					continue;
				case 6u:
					InitializeComponent();
					numberOfCars = countCar;
					thread_ = Simulation.smethod_1((ThreadStart)endSimulation);
					num = (int)(num2 * 610793379) ^ -731905226;
					continue;
				case 5u:
					Simulation.smethod_3(thread_);
					num = (int)((num2 * 590868914) ^ 0x48A94BF2);
					continue;
				case 4u:
					num = (int)(num2 * 2114237589) ^ -1164787855;
					continue;
				case 3u:
					num = (int)(num2 * 601591033) ^ -723983231;
					continue;
				case 2u:
					num = ((int)num2 * -535481206) ^ -1521602198;
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

	private void endSimulation()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		bool flag = default(bool);
		while (true)
		{
			int num = 662495919;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x729B773Du) % 12u)
				{
				case 11u:
					flag = done == numberOfCars;
					num = (int)((num2 * 1920510081) ^ 0x7141DB66);
					continue;
				case 10u:
					num = ((int)num2 * -823118885) ^ -313213727;
					continue;
				case 9u:
					Simulation.smethod_4("Simulation has been done!");
					num = ((int)num2 * -1160884098) ^ -1183053468;
					continue;
				default:
					num = 394478078;
					continue;
				case 7u:
					Simulation.smethod_6(Simulation.smethod_5((DispatcherObject)(object)this), (DispatcherPriority)4, (Delegate)(Action)delegate
					{
						Simulation.smethod_19((Window)(object)this);
					});
					num = (int)(num2 * 502202191) ^ -747361406;
					continue;
				case 6u:
					Simulation.smethod_7(2000);
					num = 1164386240;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 2048451597;
						num4 = 2048451597;
					}
					else
					{
						num3 = 1458228099;
						num4 = 1458228099;
					}
					num = num3 ^ ((int)num2 * -1932866317);
					continue;
				}
				case 2u:
					num = ((int)num2 * -1917188371) ^ 0x4F9DFBEA;
					continue;
				case 1u:
					num = 1341081990;
					continue;
				case 0u:
					num = ((int)num2 * -892288916) ^ -1201877752;
					continue;
				case 5u:
					break;
				}
				break;
			}
		}
	}

	private void Window_Loaded(object sender, RoutedEventArgs e)
	{
		Points.LoadTrace();
		while (true)
		{
			int num = 1262638285;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5108D799u) % 7u)
				{
				case 5u:
					num = ((int)num2 * -1206895731) ^ 0x4FF6EF49;
					continue;
				case 3u:
					startThread();
					num = ((int)num2 * -1508542859) ^ 0x45B81183;
					continue;
				case 2u:
					createCar();
					num = (int)(num2 * 782450320) ^ -697320410;
					continue;
				case 1u:
					num = (int)(num2 * 1595676685) ^ -818407773;
					continue;
				case 0u:
					lights.StartLight(this);
					num = ((int)num2 * -814427268) ^ 0x20A07D99;
					continue;
				default:
					return;
				case 6u:
					break;
				case 4u:
					return;
				}
				break;
			}
		}
	}

	private void createCar()
	{
		Random random_ = Simulation.smethod_8();
		int num5 = default(int);
		bool flag2 = default(bool);
		int num6 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -1875012582;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC9D3151Au) % 28u)
				{
				case 27u:
					num = (int)((num2 * 1315553961) ^ 0x625AD58F);
					continue;
				case 26u:
					TrafficPlan.trafficList.Add(new CarInfo(num5));
					num = (int)(num2 * 1652822673) ^ -1177156925;
					continue;
				case 25u:
					listCar.Add(new Car(num5, "Picture/mario.png"));
					num = ((int)num2 * -98622485) ^ -1786408831;
					continue;
				case 24u:
					num5 = 0;
					num = ((int)num2 * -1934073589) ^ 0x4928D37;
					continue;
				case 22u:
					flag2 = 2 == num6;
					num = -1283127408;
					continue;
				case 20u:
					num6 = Simulation.smethod_9(random_, 1, 5);
					num = -680753977;
					continue;
				case 19u:
					num = ((int)num2 * -1275360844) ^ -134804659;
					continue;
				case 18u:
					TrafficPlan.trafficList.Add(new CarInfo(num5));
					num = (int)(num2 * 2022794105) ^ -1974581928;
					continue;
				case 17u:
					num = -2019291980;
					continue;
				case 16u:
					num = (int)(num2 * 1092449285) ^ -24445711;
					continue;
				case 15u:
				{
					int num10;
					if (num5 >= numberOfCars)
					{
						num = -2091184345;
						num10 = -2091184345;
					}
					else
					{
						num = -1889878278;
						num10 = -1889878278;
					}
					continue;
				}
				case 14u:
				{
					int num8;
					int num9;
					if (flag2)
					{
						num8 = -599863030;
						num9 = -599863030;
					}
					else
					{
						num8 = -1159206529;
						num9 = -1159206529;
					}
					num = num8 ^ ((int)num2 * -654526295);
					continue;
				}
				case 13u:
					num = ((int)num2 * -968870536) ^ 0x3CC7DD69;
					continue;
				case 12u:
					TrafficPlan.trafficList.Add(new CarInfo(num5));
					num = ((int)num2 * -472654339) ^ 0x44A69D4B;
					continue;
				case 11u:
					num = -136350525;
					continue;
				case 10u:
					listCar.Add(new Car(num5, "Picture/pikachu.png"));
					num = (int)(num2 * 17689984) ^ -1360351159;
					continue;
				case 9u:
					flag = 1 == num6;
					num = (int)((num2 * 480214217) ^ 0x37DB8913);
					continue;
				case 8u:
					listCar.Add(new Car(num5, "Picture/star.png"));
					TrafficPlan.trafficList.Add(new CarInfo(num5));
					num = (int)(num2 * 753497528) ^ -82265115;
					continue;
				case 7u:
				{
					int num7;
					if (3 == num6)
					{
						num = -400119966;
						num7 = -400119966;
					}
					else
					{
						num = -2076030425;
						num7 = -2076030425;
					}
					continue;
				}
				case 6u:
					num = ((int)num2 * -1801697580) ^ 0x3431DED1;
					continue;
				case 5u:
					num5++;
					num = (int)((num2 * 740858205) ^ 0x56A62144);
					continue;
				case 4u:
					num = (int)(num2 * 625725470) ^ -1439100914;
					continue;
				case 3u:
					num = (int)((num2 * 1752358334) ^ 0x423C372);
					continue;
				case 2u:
					listCar.Add(new Car(num5, "Picture/pic.png"));
					num = ((int)num2 * -1836352957) ^ -1802789150;
					continue;
				case 1u:
					num = ((int)num2 * -765119336) ^ -1811047639;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 412307028;
						num4 = 412307028;
					}
					else
					{
						num3 = 2028807039;
						num4 = 2028807039;
					}
					num = num3 ^ ((int)num2 * -236640363);
					continue;
				}
				default:
					return;
				case 23u:
					break;
				case 21u:
					return;
				}
				break;
			}
		}
	}

	private void startThread()
	{
		bool flag = default(bool);
		Thread thread_ = default(Thread);
		int num3 = default(int);
		while (true)
		{
			int num = 1130802842;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x23417F0Eu) % 13u)
				{
				case 12u:
					num = ((int)num2 * -1249326938) ^ -1195218163;
					continue;
				case 11u:
					num = ((int)num2 * -888049973) ^ -1473676977;
					continue;
				case 10u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 365756321;
						num5 = 365756321;
					}
					else
					{
						num4 = 525257084;
						num5 = 525257084;
					}
					num = num4 ^ ((int)num2 * -836008410);
					continue;
				}
				case 9u:
					thread_ = Simulation.smethod_10((ParameterizedThreadStart)animate);
					num = (int)(num2 * 1343983207) ^ -614581280;
					continue;
				case 8u:
					num3++;
					num = (int)(num2 * 1813637895) ^ -1665332504;
					continue;
				case 7u:
					num = 1082619004;
					continue;
				case 6u:
					num3 = 0;
					num = ((int)num2 * -797399741) ^ 0x565E71FC;
					continue;
				case 5u:
					Simulation.smethod_12(thread_, (object)num3);
					num = ((int)num2 * -1973686808) ^ -1793561588;
					continue;
				case 4u:
					Simulation.smethod_2(thread_, bool_0: true);
					Simulation.smethod_11(thread_, num3.ToString());
					num = ((int)num2 * -1878711850) ^ 0x1B3A3262;
					continue;
				case 3u:
					flag = num3 < numberOfCars;
					num = 864844699;
					continue;
				case 1u:
					num = ((int)num2 * -1887118341) ^ -778474072;
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

	private void animate(object idCar)
	{
		List<Point> list = default(List<Point>);
		Car car = default(Car);
		int num3 = default(int);
		Random random_ = default(Random);
		WhereIsNow whereIsNow = default(WhereIsNow);
		WhereIsNow iAmHere = default(WhereIsNow);
		bool flag7 = default(bool);
		bool flag5 = default(bool);
		bool flag8 = default(bool);
		bool flag6 = default(bool);
		bool flag3 = default(bool);
		bool flag = default(bool);
		Simulation simulation = default(Simulation);
		bool flag2 = default(bool);
		bool flag4 = default(bool);
		while (true)
		{
			int num = -2082574900;
			while (true)
			{
				int num10;
				object object_;
				bool bool_;
				uint num2;
				switch ((num2 = (uint)num ^ 0xFC8A319Au) % 184u)
				{
				case 183u:
					list = Points.Bitwy_North_Right_Aleje;
					num = ((int)num2 * -386514591) ^ -174662582;
					continue;
				case 182u:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_1_South_Inside_Rondo_2_Inside;
					num = -498113323;
					continue;
				case 181u:
					num = (int)((num2 * 1656840016) ^ 0x1C47D190);
					continue;
				case 180u:
					driveByViaduct(car, timeDriveByTunnel);
					num = ((int)num2 * -1284953559) ^ 0xD11B827;
					continue;
				case 179u:
					num = ((int)num2 * -2044681593) ^ -577542154;
					continue;
				case 178u:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_2_East_Exit;
					num = (int)((num2 * 947747983) ^ 0x769EA746);
					continue;
				case 177u:
					num3 = Simulation.smethod_9(random_, 1, 3);
					num = -1084897104;
					continue;
				case 176u:
					list = Points.Aleje_West_Entry_Bitwy;
					num = (int)((num2 * 1801971528) ^ 0x7F9D7B30);
					continue;
				case 175u:
					list = Points.Rondo_1_East_Entry_Rondo_2;
					num = (int)((num2 * 1823626955) ^ 0x3EA0CDA5);
					continue;
				case 174u:
					list = Points.Aleje_East_Exit_2;
					goto IL_024d;
				case 173u:
					goto IL_01be;
				case 1u:
				case 7u:
				case 10u:
				case 16u:
				case 24u:
				case 32u:
				case 34u:
				case 39u:
				case 52u:
				case 54u:
				case 55u:
				case 59u:
				case 66u:
				case 73u:
				case 78u:
				case 93u:
				case 104u:
				case 107u:
				case 109u:
				case 113u:
				case 123u:
				case 132u:
				case 145u:
				case 153u:
				case 154u:
				case 170u:
					goto IL_024d;
				case 29u:
					goto IL_0277;
				case 172u:
					list = Points.Aleje_West_Exit_1;
					num = ((int)num2 * -381848510) ^ -251948901;
					continue;
				case 171u:
					list = Points.Bitwy_North_Exit_1;
					num = (int)(num2 * 972461741) ^ -1535828381;
					continue;
				case 169u:
					list = Points.Rondo_1_North_Entry_Rondo_2;
					num = ((int)num2 * -988338932) ^ 0x6CAE4E96;
					continue;
				case 168u:
					num = (int)(num2 * 1585559606) ^ -1559438958;
					continue;
				case 167u:
					goto IL_02df;
				case 166u:
					num = (int)(num2 * 518284895) ^ -693182573;
					continue;
				case 165u:
					list = Points.Bitwy_North_Entry_2;
					num = (int)(num2 * 490235032) ^ -2042097772;
					continue;
				case 164u:
					list = Points.Bitwy_North_Left_Exit;
					num = ((int)num2 * -1910910180) ^ 0x6C428BDE;
					continue;
				case 163u:
					list = Points.Rondo_1_West_Entry_Rondo_2;
					num = ((int)num2 * -1774634917) ^ -1537221838;
					continue;
				case 162u:
					list = Points.Rondo_2_East_Exit;
					num = ((int)num2 * -761616358) ^ -722048128;
					continue;
				case 161u:
					driveByViaduct(car, timeDriveUnderViaductInsideRondoEast);
					num = -828990951;
					continue;
				case 160u:
					goto IL_0397;
				case 159u:
					goto IL_03bd;
				case 158u:
					goto IL_03d0;
				case 157u:
					whereIsNow = iAmHere;
					num = (int)(num2 * 2061335902) ^ -907977460;
					continue;
				case 156u:
					list = Points.Aleje_East_Exit_2;
					num = ((int)num2 * -1478303844) ^ -1621889263;
					continue;
				case 155u:
					list = null;
					num = ((int)num2 * -556151469) ^ 0x12BE65FE;
					continue;
				case 152u:
					num = ((int)num2 * -293886042) ^ -1914427318;
					continue;
				case 151u:
					num = (int)(num2 * 1499829917) ^ -1922777888;
					continue;
				case 150u:
					list = Points.Bitwy_North_Exit_2;
					num = (int)((num2 * 1190134566) ^ 0xD896FF0);
					continue;
				case 149u:
				{
					int num21;
					int num22;
					if (!flag7)
					{
						num21 = 1201388069;
						num22 = 1201388069;
					}
					else
					{
						num21 = 257243422;
						num22 = 257243422;
					}
					num = num21 ^ ((int)num2 * -178982184);
					continue;
				}
				case 148u:
					num = ((int)num2 * -1015609728) ^ 0x593F4976;
					continue;
				case 147u:
					num = (int)(num2 * 876924311) ^ -1801397674;
					continue;
				case 146u:
					num = (int)(num2 * 1161485553) ^ -262479501;
					continue;
				case 144u:
					goto IL_04dc;
				case 143u:
					goto IL_0508;
				case 142u:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_East_Inside;
					num = -1653509985;
					continue;
				case 141u:
				{
					int num19;
					int num20;
					if (flag5)
					{
						num19 = 3972727;
						num20 = 3972727;
					}
					else
					{
						num19 = 393361398;
						num20 = 393361398;
					}
					num = num19 ^ (int)(num2 * 650236508);
					continue;
				}
				case 140u:
					list = null;
					goto IL_024d;
				case 139u:
				{
					int num17;
					int num18;
					if (!flag8)
					{
						num17 = 1268140785;
						num18 = 1268140785;
					}
					else
					{
						num17 = 1219518832;
						num18 = 1219518832;
					}
					num = num17 ^ ((int)num2 * -1295568511);
					continue;
				}
				case 138u:
					flag8 = num3 == 1;
					num = (int)((num2 * 1050882954) ^ 0x364AB68D);
					continue;
				case 137u:
					list = Points.Bitwy_South_Exit_2;
					goto IL_024d;
				case 136u:
					num = ((int)num2 * -383762539) ^ 0x593CD2FD;
					continue;
				case 135u:
					list = Points.Rondo_1_South_Inside_Rondo_2_Inside;
					num = (int)((num2 * 817653542) ^ 0x7D36A8A5);
					continue;
				case 134u:
					driveByViaduct(car, timeDriveUndeViaductInsideRondoNorth);
					num = (int)((num2 * 1214493652) ^ 0x3028A16A);
					continue;
				case 133u:
					list = Points.Rondo_East_Inside;
					num = ((int)num2 * -2030291209) ^ -1287253478;
					continue;
				case 131u:
					goto IL_063b;
				default:
					goto IL_0661;
				case 128u:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Bitwy_North_Entry_2;
					num = -1308178741;
					continue;
				case 127u:
					num = ((int)num2 * -336903731) ^ -191473435;
					continue;
				case 126u:
					num = ((int)num2 * -1295605941) ^ -747474412;
					continue;
				case 125u:
					num = ((int)num2 * -378626580) ^ 0x2D2C09F6;
					continue;
				case 124u:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_1_West_Entry_Rondo_2;
					num = ((int)num2 * -1915599886) ^ 0x120D939;
					continue;
				case 122u:
					num = (int)(num2 * 87513027) ^ -214474823;
					continue;
				case 121u:
					goto IL_07eb;
				case 120u:
					switch (whereIsNow)
					{
					case WhereIsNow.Rondo_1_East_Entry_Rondo_2:
						break;
					case WhereIsNow.Done:
						goto IL_015d;
					case WhereIsNow.Rondo_2_South_Exit:
						goto IL_02df;
					case WhereIsNow.Aleje_Entry_Left_Bitwy:
						goto IL_0397;
					case WhereIsNow.Rondo_3_North_Exit:
						goto IL_03bd;
					case WhereIsNow.Bitwy_North_Exit_2:
						goto IL_03d0;
					case WhereIsNow.Bitwy_North_Entry_2:
						goto IL_04dc;
					case WhereIsNow.Aleje_West_Exit_2:
						goto IL_0508;
					case WhereIsNow.Rondo_1_Inside_Left_Entry_Rondo_2:
						goto IL_063b;
					case WhereIsNow.Beginning:
						goto IL_0661;
					case WhereIsNow.Aleje_West_Entry_2:
						goto IL_07eb;
					default:
						goto IL_08b5;
					case WhereIsNow.Aleje_East_Entry_Rondo:
						goto IL_08c8;
					case WhereIsNow.Aleje_East_Exit_1:
						goto IL_08ee;
					case WhereIsNow.Aleje_East_Exit_2:
						goto IL_0913;
					case WhereIsNow.Aleje_East_Right_Bitwy:
						goto IL_0936;
					case WhereIsNow.Aleje_West_Entry_1:
						goto IL_095c;
					case WhereIsNow.Aleje_West_Entry_Bitwy:
						goto IL_096f;
					case WhereIsNow.Aleje_West_Exit_1:
						goto IL_0996;
					case WhereIsNow.Bitwy_North_Entry_1:
						goto IL_09bc;
					case WhereIsNow.Bitwy_North_Entry_Left_Rondo:
						goto IL_09cf;
					case WhereIsNow.Bitwy_North_Exit_1:
						goto IL_09f5;
					case WhereIsNow.Bitwy_North_Left_Exit:
						goto IL_0a1b;
					case WhereIsNow.Bitwy_North_Right_Aleje:
						goto IL_0a41;
					case WhereIsNow.Bitwy_South_Entry_1:
						goto IL_0a67;
					case WhereIsNow.Bitwy_South_Entry_2:
						goto IL_0a80;
					case WhereIsNow.Bitwy_South_Exit_1:
						goto IL_0aa6;
					case WhereIsNow.Bitwy_South_Exit_2:
						goto IL_0acc;
					case WhereIsNow.Bitwy_South_Right_Aleje:
						goto IL_0af2;
					case WhereIsNow.Rondo_1_North_Entry_Rondo_2:
						goto IL_0b17;
					case WhereIsNow.Rondo_1_South_Entry_Rondo_2:
						goto IL_0b3d;
					case WhereIsNow.Rondo_1_South_Inside_Rondo_2_Inside:
						goto IL_0b50;
					case WhereIsNow.Rondo_1_West_Entry_Rondo_2:
						goto IL_0b76;
					case WhereIsNow.Rondo_2_East_Exit:
						goto IL_0b9c;
					case WhereIsNow.Rondo_2_Inside_Left_Entry_Rondo_3:
						goto IL_0bc2;
					case WhereIsNow.Rondo_2_North_Entry_Rondo_3:
						goto IL_0be8;
					case WhereIsNow.Rondo_2_South_Inside_Exit:
						goto IL_0c0f;
					case WhereIsNow.Rondo_2_West_Exit:
						goto IL_0c28;
					case WhereIsNow.Rondo_3_Inside_Left_exit:
						goto IL_0c4e;
					case WhereIsNow.Rondo_East_Inside:
						goto IL_0c73;
					}
					goto case 177u;
				case 40u:
					goto IL_08c8;
				case 23u:
					goto IL_08ee;
				case 88u:
					goto IL_0913;
				case 20u:
					goto IL_0936;
				case 63u:
					goto IL_095c;
				case 60u:
					goto IL_096f;
				case 110u:
					goto IL_0996;
				case 89u:
					goto IL_09bc;
				case 36u:
					goto IL_09cf;
				case 85u:
					goto IL_09f5;
				case 68u:
					goto IL_0a1b;
				case 42u:
					goto IL_0a41;
				case 50u:
					goto IL_0a67;
				case 79u:
					goto IL_0a80;
				case 108u:
					goto IL_0aa6;
				case 3u:
					goto IL_0acc;
				case 69u:
					goto IL_0af2;
				case 31u:
					goto IL_0b17;
				case 82u:
					goto IL_0b3d;
				case 8u:
					goto IL_0b50;
				case 22u:
					goto IL_0b76;
				case 53u:
					goto IL_0b9c;
				case 11u:
					goto IL_0bc2;
				case 33u:
					goto IL_0be8;
				case 57u:
					goto IL_0c0f;
				case 9u:
					goto IL_0c28;
				case 49u:
					goto IL_0c4e;
				case 117u:
					goto IL_0c73;
				case 119u:
					list = Points.Rondo_2_North_Entry_Rondo_3;
					num = ((int)num2 * -1269231336) ^ -597040321;
					continue;
				case 118u:
					num = ((int)num2 * -186633484) ^ -2068733333;
					continue;
				case 116u:
					list = Points.Rondo_2_South_Exit;
					num = (int)((num2 * 611805530) ^ 0x5C70E601);
					continue;
				case 115u:
					num = (int)(num2 * 1925164034) ^ -126168182;
					continue;
				case 114u:
					list = Points.Bitwy_South_Entry_2;
					num = ((int)num2 * -1413050601) ^ 0x4C315D4D;
					continue;
				case 112u:
					driveByViaduct(car, timeDriveUnderViaductInsideRondoEast);
					num = -720066052;
					continue;
				case 111u:
					num = ((int)num2 * -1819952665) ^ -743904948;
					continue;
				case 106u:
					list = Points.Rondo_2_North_Entry_Rondo_3;
					goto IL_024d;
				case 105u:
					list = Points.Aleje_West_Exit_2;
					num = (int)((num2 * 1401712303) ^ 0x5C35F1F2);
					continue;
				case 103u:
					flag6 = num3 == 1;
					num = ((int)num2 * -170430313) ^ 0x3B30674F;
					continue;
				case 102u:
					iAmHere = TrafficPlan.trafficList[car.id].iAmHere;
					num = (int)(num2 * 1525956810) ^ -1838237909;
					continue;
				case 101u:
					num = (int)(num2 * 1442582078) ^ -53366500;
					continue;
				case 100u:
				{
					int num13;
					int num14;
					if (!flag6)
					{
						num13 = -385174247;
						num14 = -385174247;
					}
					else
					{
						num13 = -460796502;
						num14 = -460796502;
					}
					num = num13 ^ ((int)num2 * -490280617);
					continue;
				}
				case 99u:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Bitwy_North_Right_Aleje;
					num = ((int)num2 * -1623594979) ^ -1025830830;
					continue;
				case 98u:
					flag5 = num3 == 1;
					num = (int)(num2 * 2001299799) ^ -347734711;
					continue;
				case 97u:
					num = (int)((num2 * 2144921504) ^ 0x4EFEB6D9);
					continue;
				case 96u:
					num = ((int)num2 * -904588649) ^ 0x6A03EC31;
					continue;
				case 95u:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Bitwy_South_Entry_2;
					num = ((int)num2 * -246400224) ^ 0xC8DF4A0;
					continue;
				case 94u:
					list = Points.Rondo_2_South_Inside_Exit;
					num = ((int)num2 * -1351063205) ^ -1843952399;
					continue;
				case 92u:
					list = null;
					goto IL_024d;
				case 91u:
					num = (int)(num2 * 1471076516) ^ -2004311665;
					continue;
				case 90u:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Aleje_West_Exit_1;
					num = ((int)num2 * -1896070588) ^ -194937196;
					continue;
				case 87u:
					num = ((int)num2 * -1059429627) ^ 0x3908C915;
					continue;
				case 86u:
					driveByViaduct(car, timeDriveUnderViaductWest);
					num = (int)((num2 * 855785020) ^ 0x374D207B);
					continue;
				case 84u:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Bitwy_South_Right_Aleje;
					list = Points.Bitwy_South_Right_Aleje;
					num = ((int)num2 * -1913821483) ^ -1140871375;
					continue;
				case 83u:
					list = Points.Rondo_3_Inside_Left_exit;
					goto IL_024d;
				case 81u:
					num = (int)(num2 * 2011793268) ^ -2028455211;
					continue;
				case 80u:
				{
					int num8;
					int num9;
					if (flag3)
					{
						num8 = 734812482;
						num9 = 734812482;
					}
					else
					{
						num8 = 1269122996;
						num9 = 1269122996;
					}
					num = num8 ^ (int)(num2 * 73559422);
					continue;
				}
				case 77u:
					num = ((int)num2 * -680592414) ^ -380775624;
					continue;
				case 76u:
					flag3 = 1 == num3;
					num = ((int)num2 * -2096162793) ^ 0x72F1800E;
					continue;
				case 75u:
					list = Points.Aleje_West_Exit_2;
					goto IL_024d;
				case 74u:
					flag = 1 == num3;
					num = ((int)num2 * -1817166865) ^ -731802146;
					continue;
				case 72u:
					num = (int)((num2 * 133432240) ^ 0x21FD7E00);
					continue;
				case 71u:
					num = ((int)num2 * -1703461612) ^ 0x1ECEA5EF;
					continue;
				case 70u:
					num = (int)((num2 * 621107153) ^ 0x1172DEB7);
					continue;
				case 67u:
					Simulation.smethod_6(Simulation.smethod_5((DispatcherObject)(object)this), (DispatcherPriority)4, (Delegate)(Action)delegate
					{
						_003C_003Ec__DisplayClass18_0.smethod_2((UIElement)(object)car.picture, -30.0);
					});
					Simulation.smethod_6(Simulation.smethod_5((DispatcherObject)(object)this), (DispatcherPriority)4, (Delegate)(Action)delegate
					{
						_003C_003Ec__DisplayClass18_0.smethod_3((UIElement)(object)car.picture, -30.0);
					});
					num = (int)(num2 * 1919636687) ^ -1564311214;
					continue;
				case 65u:
					num = ((int)num2 * -2022006755) ^ 0x5AA8DB6D;
					continue;
				case 64u:
					list = Points.Aleje_East_Exit_1;
					num = ((int)num2 * -645725484) ^ 0x55A0633D;
					continue;
				case 62u:
					simulation = this;
					num = ((int)num2 * -1340766538) ^ -1288626910;
					continue;
				case 61u:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_2_East_Exit;
					num = ((int)num2 * -468583507) ^ 0x6B5E33C5;
					continue;
				case 58u:
					num = ((int)num2 * -1794640459) ^ 0x412811B;
					continue;
				case 56u:
					num = -626294346;
					continue;
				case 51u:
					list = Points.Rondo_2_Inside_Left_Entry_Rondo_3;
					num = ((int)num2 * -770156605) ^ -1357105715;
					continue;
				case 48u:
					list = Points.Aleje_West_Entry_2;
					num = (int)(num2 * 560891973) ^ -1327138713;
					continue;
				case 47u:
					num = -949860419;
					continue;
				case 46u:
					num = (int)(num2 * 574790944) ^ -1303061779;
					continue;
				case 45u:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Aleje_West_Entry_Bitwy;
					num = (int)(num2 * 176708471) ^ -173228799;
					continue;
				case 44u:
					num = ((int)num2 * -1898043235) ^ 0x2DF838E9;
					continue;
				case 43u:
					list = Points.Bitwy_South_Exit_1;
					num = ((int)num2 * -1416090877) ^ -1248985053;
					continue;
				case 41u:
					num = (int)(num2 * 1495126280) ^ -1009806707;
					continue;
				case 38u:
					list = Points.Rondo_2_East_Exit;
					num = (int)(num2 * 1125545144) ^ -116323105;
					continue;
				case 37u:
					list = Points.Bitwy_North_Exit_2;
					num = ((int)num2 * -615407884) ^ -610016980;
					continue;
				case 35u:
					num = ((int)num2 * -1059512109) ^ 0x4839F006;
					continue;
				case 30u:
					num = (int)(num2 * 1708359877) ^ -1242863056;
					continue;
				case 28u:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Aleje_West_Entry_2;
					num = (int)(num2 * 631798027) ^ -1992244986;
					continue;
				case 27u:
				{
					int num6;
					int num7;
					if (!flag2)
					{
						num6 = -1755646184;
						num7 = -1755646184;
					}
					else
					{
						num6 = -1043748861;
						num7 = -1043748861;
					}
					num = num6 ^ (int)(num2 * 1187674012);
					continue;
				}
				case 26u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -201656522;
						num5 = -201656522;
					}
					else
					{
						num4 = -1571751507;
						num5 = -1571751507;
					}
					num = num4 ^ ((int)num2 * -1925680887);
					continue;
				}
				case 25u:
					num = ((int)num2 * -191799576) ^ -1261535257;
					continue;
				case 21u:
					list = null;
					num = (int)((num2 * 1514491165) ^ 0x2C0F4CA7);
					continue;
				case 19u:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_2_South_Exit;
					num = (int)(num2 * 535121246) ^ -1905761090;
					continue;
				case 18u:
					list = Points.Rondo_2_West_Exit;
					num = (int)((num2 * 1056646011) ^ 0x4CBE9D7A);
					continue;
				case 17u:
					num = (int)(num2 * 1288923630) ^ -919449339;
					continue;
				case 15u:
					num = -904707601;
					continue;
				case 14u:
					list = Points.Aleje_East_Exit_1;
					num = (int)(num2 * 1843891737) ^ -911306052;
					continue;
				case 13u:
					num = (int)(num2 * 985511193) ^ -1020505175;
					continue;
				case 12u:
					car = listCar[(int)idCar];
					random_ = Simulation.smethod_8();
					list = null;
					num3 = 0;
					Simulation.smethod_6(Simulation.smethod_5((DispatcherObject)(object)this), (DispatcherPriority)4, (Delegate)(Action)delegate
					{
						_003C_003Ec__DisplayClass18_0.smethod_1(_003C_003Ec__DisplayClass18_0.smethod_0((Panel)(object)simulation.SomeWhere), (UIElement)(object)car.picture);
					});
					num = ((int)num2 * -1271278886) ^ -2104876927;
					continue;
				case 6u:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_East_Inside;
					list = Points.Rondo_East_Inside;
					num = -264886558;
					continue;
				case 5u:
					num = (int)((num2 * 490579139) ^ 0x4F74E7E7);
					continue;
				case 4u:
					num = ((int)num2 * -1043487584) ^ 0xDFA5B1A;
					continue;
				case 2u:
					list = Points.Rondo_1_Inside_Left_Entry_Rondo_2;
					num = (int)(num2 * 158183207) ^ -1105105152;
					continue;
				case 130u:
					break;
				case 0u:
					goto IL_16ea;
					IL_02df:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Aleje_East_Exit_1;
					num = -821645010;
					continue;
					IL_01ff:
					while (true)
					{
						switch ((num2 = (uint)num10 ^ 0xFC8A319Au) % 14u)
						{
						case 13u:
							moveCar(car, list);
							num10 = ((int)num2 * -640824218) ^ 0x25D56815;
							continue;
						case 10u:
						{
							int num11;
							int num12;
							if (!flag4)
							{
								num11 = -935790261;
								num12 = -935790261;
							}
							else
							{
								num11 = -283259389;
								num12 = -283259389;
							}
							num10 = num11 ^ ((int)num2 * -1486777528);
							continue;
						}
						case 9u:
							break;
						case 8u:
							num10 = (int)((num2 * 131195512) ^ 0x30ABFBED);
							continue;
						case 7u:
							canExitCheckpoint(car);
							num10 = ((int)num2 * -969498020) ^ 0x5BBFC7E2;
							continue;
						case 6u:
							goto IL_01be;
						case 3u:
							done++;
							num10 = (int)((num2 * 1910687092) ^ 0x68FADA44);
							continue;
						case 2u:
							num10 = (int)(num2 * 348987298) ^ -296010957;
							continue;
						case 1u:
							num10 = -223918570;
							continue;
						case 0u:
							num10 = -530195787;
							continue;
						default:
							return;
						case 5u:
							goto IL_024d;
						case 4u:
							goto IL_0277;
						case 12u:
							goto IL_16ea;
						case 11u:
							return;
						}
						break;
					}
					goto IL_015d;
					IL_16ea:
					throw Simulation.smethod_15("xD");
					IL_024d:
					flag4 = TrafficPlan.trafficList[car.id].iAmHere != WhereIsNow.Done;
					num10 = -1087073836;
					goto IL_01ff;
					IL_01be:
					num10 = -1563252704;
					goto IL_01ff;
					IL_015d:
					Simulation.smethod_6(Simulation.smethod_5((DispatcherObject)(object)this), (DispatcherPriority)4, (Delegate)(Action)delegate
					{
						_003C_003Ec__DisplayClass18_0.smethod_4(_003C_003Ec__DisplayClass18_0.smethod_0((Panel)(object)simulation.SomeWhere), (UIElement)(object)car.picture);
						while (true)
						{
							int num23 = 1026668376;
							while (true)
							{
								uint num24;
								switch ((num24 = (uint)num23 ^ 0x227E4CC4u) % 3u)
								{
								case 1u:
									goto IL_0022;
								default:
									return;
								case 0u:
									break;
								case 2u:
									return;
								}
								break;
								IL_0022:
								num23 = ((int)num24 * -1088818123) ^ -805556393;
							}
						}
					});
					num10 = -168981323;
					goto IL_01ff;
					IL_0277:
					num = -1377122988;
					continue;
					IL_0c73:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_2_North_Entry_Rondo_3;
					num = -2109299624;
					continue;
					IL_0c4e:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Aleje_East_Exit_1;
					num = -1366748804;
					continue;
					IL_0c28:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Bitwy_South_Exit_1;
					num = -1002495308;
					continue;
					IL_0c0f:
					num3 = Simulation.smethod_9(random_, 1, 3);
					flag2 = num3 == 1;
					num = -1065531087;
					continue;
					IL_0be8:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_3_North_Exit;
					list = Points.Rondo_3_North_Exit;
					goto IL_024d;
					IL_0bc2:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_3_Inside_Left_exit;
					num = -131641496;
					continue;
					IL_0b9c:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Bitwy_North_Exit_1;
					num = -204780912;
					continue;
					IL_0b76:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_2_West_Exit;
					num = -132807912;
					continue;
					IL_0b50:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_2_South_Inside_Exit;
					num = -1588521281;
					continue;
					IL_0b3d:
					num3 = Simulation.smethod_9(random_, 1, 3);
					num = -1838047370;
					continue;
					IL_0b17:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_2_North_Entry_Rondo_3;
					num = -1189269835;
					continue;
					IL_0af2:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Aleje_East_Exit_2;
					num = -1053754716;
					continue;
					IL_0acc:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Done;
					num = -1125487651;
					continue;
					IL_0aa6:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Bitwy_South_Exit_2;
					num = -1172279183;
					continue;
					IL_0a80:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_1_East_Entry_Rondo_2;
					num = -1226887190;
					continue;
					IL_0a67:
					num3 = Simulation.smethod_9(random_, 1, 3);
					flag7 = num3 == 1;
					num = -940828713;
					continue;
					IL_0a41:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Aleje_West_Exit_2;
					num = -617243575;
					continue;
					IL_0a1b:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Done;
					num = -1233403904;
					continue;
					IL_09f5:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Bitwy_North_Exit_2;
					num = -1705433113;
					continue;
					IL_09cf:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_1_Inside_Left_Entry_Rondo_2;
					num = -145216528;
					continue;
					IL_09bc:
					num3 = Simulation.smethod_9(random_, 1, 3);
					num = -545832504;
					continue;
					IL_0996:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Aleje_West_Exit_2;
					num = -235951533;
					continue;
					IL_096f:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Bitwy_South_Exit_2;
					list = Points.Bitwy_South_Exit_2;
					goto IL_024d;
					IL_095c:
					num3 = Simulation.smethod_9(random_, 1, 3);
					num = -596087811;
					continue;
					IL_0936:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Bitwy_North_Exit_2;
					num = -74752895;
					continue;
					IL_0913:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Done;
					list = null;
					goto IL_024d;
					IL_08ee:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Aleje_East_Exit_2;
					num = -2005953650;
					continue;
					IL_08c8:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_1_North_Entry_Rondo_2;
					num = -1812536941;
					continue;
					IL_08b5:
					num = (int)((num2 * 906508700) ^ 0x44E32D72);
					continue;
					IL_07eb:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_1_South_Entry_Rondo_2;
					list = Points.Rondo_1_South_Entry_Rondo_2;
					goto IL_024d;
					IL_0661:
					object_ = lock_object;
					bool_ = false;
					try
					{
						Simulation.smethod_13(object_, ref bool_);
						while (true)
						{
							IL_06e9:
							int num15 = -1096885534;
							while (true)
							{
								switch ((num2 = (uint)num15 ^ 0xFC8A319Au) % 5u)
								{
								case 3u:
									list = choiseStartTrace(car.id);
									num15 = ((int)num2 * -631101380) ^ 0x3C73920A;
									continue;
								case 2u:
									canEntryToScene(car);
									num15 = (int)((num2 * 518612118) ^ 0x14BDBD4A);
									continue;
								case 1u:
									num15 = (int)((num2 * 2132491793) ^ 0x409757C3);
									continue;
								default:
									goto end_IL_06c3;
								case 0u:
									break;
								case 4u:
									goto end_IL_06c3;
								}
								goto IL_06e9;
								continue;
								end_IL_06c3:
								break;
							}
							break;
						}
					}
					finally
					{
						if (bool_)
						{
							while (true)
							{
								IL_0742:
								int num16 = -507926857;
								while (true)
								{
									switch ((num2 = (uint)num16 ^ 0xFC8A319Au) % 4u)
									{
									case 1u:
										Simulation.smethod_14(object_);
										num16 = ((int)num2 * -712555861) ^ 0x765FDA61;
										continue;
									case 0u:
										num16 = ((int)num2 * -709948879) ^ 0x7C2E71B1;
										continue;
									default:
										goto end_IL_0720;
									case 2u:
										break;
									case 3u:
										goto end_IL_0720;
									}
									goto IL_0742;
									continue;
									end_IL_0720:
									break;
								}
								break;
							}
						}
					}
					goto IL_024d;
					IL_063b:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_2_Inside_Left_Entry_Rondo_3;
					num = -1886391671;
					continue;
					IL_0508:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Done;
					num = -1724138354;
					continue;
					IL_04dc:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_1_West_Entry_Rondo_2;
					list = Points.Rondo_1_West_Entry_Rondo_2;
					num = -625904168;
					continue;
					IL_03d0:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Done;
					num = -1982539295;
					continue;
					IL_03bd:
					num3 = Simulation.smethod_9(random_, 1, 3);
					num = -1157653320;
					continue;
					IL_0397:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Bitwy_North_Left_Exit;
					num = -1421625290;
					continue;
				}
				break;
			}
		}
	}

	private List<Point> choiseStartTrace(int idCar)
	{
		bool flag3 = default(bool);
		int num5 = default(int);
		List<Point> result = default(List<Point>);
		bool flag5 = default(bool);
		bool flag2 = default(bool);
		bool flag = default(bool);
		Random random_ = default(Random);
		bool flag4 = default(bool);
		while (true)
		{
			int num = -322649792;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9D265C77u) % 37u)
				{
				case 36u:
					num = ((int)num2 * -1914909203) ^ -1221480119;
					continue;
				case 35u:
					flag3 = 6 == num5;
					num = -1775168575;
					continue;
				case 34u:
					result = Points.Aleje_East_Entry_Rondo;
					num = (int)((num2 * 1118289039) ^ 0x2E521F36);
					continue;
				case 33u:
				{
					int num13;
					int num14;
					if (!flag5)
					{
						num13 = 1958940777;
						num14 = 1958940777;
					}
					else
					{
						num13 = 979347074;
						num14 = 979347074;
					}
					num = num13 ^ (int)(num2 * 1932004);
					continue;
				}
				case 32u:
					result = Points.Aleje_West_Entry_1;
					num = (int)(num2 * 1891088108) ^ -1457286196;
					continue;
				case 31u:
					num = (int)(num2 * 1463815426) ^ -1387491936;
					continue;
				case 30u:
					TrafficPlan.trafficList[idCar].iAmHere = WhereIsNow.Bitwy_North_Entry_Left_Rondo;
					num = (int)((num2 * 788774638) ^ 0x3FAC0958);
					continue;
				case 29u:
					TrafficPlan.trafficList[idCar].iAmHere = WhereIsNow.Aleje_East_Right_Bitwy;
					result = Points.Aleje_East_Right_Bitwy;
					num = -1674559563;
					continue;
				case 28u:
					num = (int)(num2 * 1855751256) ^ -402949310;
					continue;
				case 27u:
					num = (int)((num2 * 139028919) ^ 0x48CB2B73);
					continue;
				case 26u:
					result = Points.Bitwy_North_Entry_1;
					num = (int)((num2 * 2140274362) ^ 0x79335598);
					continue;
				case 25u:
				{
					int num6;
					if (3 == num5)
					{
						num = -1366909583;
						num6 = -1366909583;
					}
					else
					{
						num = -972694755;
						num6 = -972694755;
					}
					continue;
				}
				case 24u:
					TrafficPlan.trafficList[idCar].iAmHere = WhereIsNow.Aleje_East_Entry_Rondo;
					num = (int)((num2 * 175557084) ^ 0xB952775);
					continue;
				case 23u:
					TrafficPlan.trafficList[idCar].iAmHere = WhereIsNow.Aleje_West_Entry_1;
					num = (int)(num2 * 23601303) ^ -2041723861;
					continue;
				case 22u:
					num = (int)((num2 * 480875392) ^ 0x76F550AD);
					continue;
				case 21u:
				{
					int num11;
					int num12;
					if (flag2)
					{
						num11 = 95662744;
						num12 = 95662744;
					}
					else
					{
						num11 = 1003674956;
						num12 = 1003674956;
					}
					num = num11 ^ ((int)num2 * -158465883);
					continue;
				}
				case 20u:
					num = (int)((num2 * 1581648761) ^ 0x20AD583);
					continue;
				case 19u:
					TrafficPlan.trafficList[idCar].iAmHere = WhereIsNow.Bitwy_South_Entry_1;
					num = ((int)num2 * -456736749) ^ -1524052484;
					continue;
				case 18u:
					num = ((int)num2 * -1201729684) ^ 0x751B0F1;
					continue;
				case 17u:
					TrafficPlan.trafficList[idCar].iAmHere = WhereIsNow.Aleje_Entry_Left_Bitwy;
					num = ((int)num2 * -572399577) ^ -997725267;
					continue;
				case 16u:
					result = Points.Bitwy_South_Entry_1;
					num = (int)(num2 * 749654842) ^ -455245296;
					continue;
				case 14u:
					flag5 = 2 == num5;
					num = -1549036633;
					continue;
				case 13u:
					num = ((int)num2 * -639538346) ^ 0x1E12B410;
					continue;
				case 12u:
					num = (int)(num2 * 1877552783) ^ -1529383040;
					continue;
				case 11u:
					flag = 5 == num5;
					num = -966347610;
					continue;
				case 10u:
					random_ = Simulation.smethod_8();
					num = (int)(num2 * 1341638495) ^ -2016673249;
					continue;
				case 8u:
					TrafficPlan.trafficList[idCar].iAmHere = WhereIsNow.Bitwy_North_Entry_1;
					num = ((int)num2 * -1079494600) ^ 0x3BA043D4;
					continue;
				case 7u:
				{
					int num9;
					int num10;
					if (!flag4)
					{
						num9 = -509032073;
						num10 = -509032073;
					}
					else
					{
						num9 = -1468534590;
						num10 = -1468534590;
					}
					num = num9 ^ (int)(num2 * 1291943867);
					continue;
				}
				case 6u:
					num5 = Simulation.smethod_9(random_, 1, 8);
					flag4 = 1 == num5;
					num = (int)((num2 * 709274826) ^ 0x6FF8E11);
					continue;
				case 5u:
					result = Points.Bitwy_North_Entry_Left_Rondo;
					num = (int)(num2 * 1658207155) ^ -835661769;
					continue;
				case 4u:
					num = (int)((num2 * 1735390013) ^ 0x7C4AE474);
					continue;
				case 3u:
				{
					int num7;
					int num8;
					if (flag3)
					{
						num7 = 1842326789;
						num8 = 1842326789;
					}
					else
					{
						num7 = 794656041;
						num8 = 794656041;
					}
					num = num7 ^ (int)(num2 * 145706738);
					continue;
				}
				case 2u:
					result = Points.Aleje_Entry_Left_Bitwy;
					num = (int)((num2 * 1527332828) ^ 0x4A162E35);
					continue;
				case 1u:
					flag2 = 4 == num5;
					num = -1699642506;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -450662680;
						num4 = -450662680;
					}
					else
					{
						num3 = -474162373;
						num4 = -474162373;
					}
					num = num3 ^ (int)(num2 * 814161382);
					continue;
				}
				case 15u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	private void canEntryToScene(Car car)
	{
		while (true)
		{
			int num = -232259216;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8EAC3C85u) % 7u)
				{
				case 5u:
					Simulation.smethod_7(stopCar_entryInRoad);
					num = (int)(num2 * 5095695) ^ -913021105;
					continue;
				case 4u:
					num = -953807573;
					continue;
				case 2u:
					num = ((int)num2 * -127137571) ^ -133331974;
					continue;
				case 1u:
					num = ((int)num2 * -677397135) ^ -439306749;
					continue;
				case 0u:
				{
					int num3;
					if (TrafficPlan.CanEntryInRoad(car.id, TrafficPlan.trafficList[car.id].iAmHere))
					{
						num = -542696434;
						num3 = -542696434;
					}
					else
					{
						num = -312362449;
						num3 = -312362449;
					}
					continue;
				}
				default:
					return;
				case 3u:
					break;
				case 6u:
					return;
				}
				break;
			}
		}
	}

	private void moveCar(Car car, List<Point> list)
	{
		_003C_003Ec__DisplayClass21_0 _003C_003Ec__DisplayClass21_ = new _003C_003Ec__DisplayClass21_0();
		_003C_003Ec__DisplayClass21_.car = car;
		int num = 0;
		using List<Point>.Enumerator enumerator = list.GetEnumerator();
		_003C_003Ec__DisplayClass21_1 _003C_003Ec__DisplayClass21_2 = default(_003C_003Ec__DisplayClass21_1);
		bool flag = default(bool);
		while (true)
		{
			int num2;
			int num3;
			if (enumerator.MoveNext())
			{
				num2 = -774267292;
				num3 = -774267292;
			}
			else
			{
				num2 = -189018662;
				num3 = -189018662;
			}
			while (true)
			{
				uint num4;
				switch ((num4 = (uint)num2 ^ 0xB22075EDu) % 17u)
				{
				case 16u:
					Simulation.smethod_6(Simulation.smethod_5((DispatcherObject)(object)this), (DispatcherPriority)4, (Delegate)new Action(_003C_003Ec__DisplayClass21_2._003CmoveCar_003Eb__1));
					num2 = ((int)num4 * -767875616) ^ 0x34BA0B;
					continue;
				case 15u:
					flag = !TrafficPlan.CanMoveCar(_003C_003Ec__DisplayClass21_2.CS_0024_003C_003E8__locals1.car.id, TrafficPlan.trafficList[_003C_003Ec__DisplayClass21_2.CS_0024_003C_003E8__locals1.car.id].iAmHere);
					num2 = -159108396;
					continue;
				case 14u:
					_003C_003Ec__DisplayClass21_2.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass21_;
					_003C_003Ec__DisplayClass21_2.item = enumerator.Current;
					num2 = (int)(num4 * 67645373) ^ -978434437;
					continue;
				case 13u:
					num2 = ((int)num4 * -1864519654) ^ -1739224612;
					continue;
				case 12u:
					num2 = ((int)num4 * -533889452) ^ -693219028;
					continue;
				case 11u:
					num2 = -774267292;
					continue;
				case 10u:
					Simulation.smethod_7(speedCar);
					num2 = ((int)num4 * -15498054) ^ -462753269;
					continue;
				case 9u:
					Simulation.smethod_7(stopCar_nextPoint);
					num2 = -1913114761;
					continue;
				case 8u:
					num2 = (int)((num4 * 1124448536) ^ 0x19EFED41);
					continue;
				case 7u:
					num++;
					TrafficPlan.trafficList[_003C_003Ec__DisplayClass21_2.CS_0024_003C_003E8__locals1.car.id].countMove = num;
					num2 = ((int)num4 * -1652601606) ^ 0x4D080E5F;
					continue;
				case 6u:
					_003C_003Ec__DisplayClass21_2 = new _003C_003Ec__DisplayClass21_1();
					num2 = -450361901;
					continue;
				case 4u:
					num2 = ((int)num4 * -375662047) ^ -1999029697;
					continue;
				case 3u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = -596361524;
						num6 = -596361524;
					}
					else
					{
						num5 = -1438449486;
						num6 = -1438449486;
					}
					num2 = num5 ^ ((int)num4 * -1288326334);
					continue;
				}
				case 2u:
					Simulation.smethod_6(Simulation.smethod_5((DispatcherObject)(object)this), (DispatcherPriority)4, (Delegate)new Action(_003C_003Ec__DisplayClass21_2._003CmoveCar_003Eb__0));
					num2 = ((int)num4 * -1892301500) ^ -1474853639;
					continue;
				case 1u:
					num2 = ((int)num4 * -715779161) ^ 0x749DAFA0;
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

	private void canExitCheckpoint(Car car)
	{
		while (true)
		{
			bool flag = !TrafficPlan.CanEntryInTheCheckPoint(car.id, this);
			int num = 997386980;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6977D89Fu) % 7u)
				{
				case 6u:
					Simulation.smethod_7(stopCar_ExitCheckPoint);
					num = 2072367360;
					continue;
				case 5u:
					num = 1839087121;
					continue;
				case 4u:
					num = ((int)num2 * -147255694) ^ 0x55598A21;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1606723586;
						num4 = 1606723586;
					}
					else
					{
						num3 = 1199180709;
						num4 = 1199180709;
					}
					num = num3 ^ ((int)num2 * -1941422884);
					continue;
				}
				case 0u:
					num = (int)(num2 * 313134395) ^ -1109146588;
					continue;
				default:
					return;
				case 3u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	private void driveByViaduct(Car car, int how_long)
	{
		_003C_003Ec__DisplayClass23_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass23_0();
		while (true)
		{
			int num = 1024958422;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x19C780E5u) % 5u)
				{
				case 3u:
					Simulation.smethod_7(how_long);
					num = ((int)num2 * -833237213) ^ 0x649BE10E;
					continue;
				case 1u:
					CS_0024_003C_003E8__locals0.car = car;
					Simulation.smethod_6(Simulation.smethod_5((DispatcherObject)(object)this), (DispatcherPriority)4, (Delegate)(Action)delegate
					{
						_003C_003Ec__DisplayClass23_0.smethod_0((UIElement)(object)CS_0024_003C_003E8__locals0.car.picture, -30.0);
						while (true)
						{
							int num3 = 365224304;
							while (true)
							{
								uint num4;
								switch ((num4 = (uint)num3 ^ 0x250C6E05u) % 3u)
								{
								case 1u:
									goto IL_001b;
								default:
									return;
								case 2u:
									break;
								case 0u:
									return;
								}
								break;
								IL_001b:
								num3 = (int)((num4 * 1154289966) ^ 0x58CC904A);
							}
						}
					});
					num = ((int)num2 * -1397688141) ^ 0x6C75CAFE;
					continue;
				case 0u:
					Simulation.smethod_6(Simulation.smethod_5((DispatcherObject)(object)this), (DispatcherPriority)4, (Delegate)(Action)delegate
					{
						_003C_003Ec__DisplayClass23_0.smethod_1((UIElement)(object)CS_0024_003C_003E8__locals0.car.picture, -30.0);
					});
					num = (int)((num2 * 1098869019) ^ 0x17C2E6A2);
					continue;
				default:
					return;
				case 2u:
					break;
				case 4u:
					return;
				}
				break;
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (_contentLoaded)
		{
			goto IL_0008;
		}
		goto IL_007d;
		IL_007d:
		_contentLoaded = true;
		Uri uri_ = Simulation.smethod_16("/FOqv;component/simulation.xaml", UriKind.Relative);
		int num = -262096757;
		goto IL_0050;
		IL_0050:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xE5CE33ADu) % 7u)
			{
			case 6u:
				break;
			case 5u:
				num = ((int)num2 * -1798811263) ^ 0xD12986C;
				continue;
			case 4u:
				Simulation.smethod_17((object)this, uri_);
				num = ((int)num2 * -1612117611) ^ -173564061;
				continue;
			case 2u:
				num = (int)((num2 * 252626200) ^ 0x75A93D09);
				continue;
			case 1u:
				num = ((int)num2 * -901645712) ^ 0x23FD05A1;
				continue;
			default:
				return;
			case 3u:
				goto IL_007d;
			case 0u:
				return;
			}
			break;
		}
		goto IL_0008;
		IL_0008:
		num = -561021077;
		goto IL_0050;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected O, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected O, but got Unknown
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected O, but got Unknown
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected O, but got Unknown
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected O, but got Unknown
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected O, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected O, but got Unknown
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected O, but got Unknown
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected O, but got Unknown
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Expected O, but got Unknown
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Expected O, but got Unknown
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Expected O, but got Unknown
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Expected O, but got Unknown
		while (true)
		{
			int num = 236936330;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x76649B2Bu) % 50u)
				{
				case 49u:
					light13 = (Ellipse)target;
					num = 1538167549;
					continue;
				case 48u:
					goto IL_001d;
				case 47u:
					num = ((int)num2 * -1670616865) ^ -1397536087;
					continue;
				case 46u:
					goto IL_0045;
				case 45u:
					goto IL_005b;
				case 44u:
					goto IL_0071;
				case 43u:
					num = ((int)num2 * -758576342) ^ 0x1D49C4E6;
					continue;
				case 42u:
					goto IL_0099;
				case 41u:
					goto IL_00af;
				case 40u:
					goto IL_00c5;
				case 39u:
					goto IL_00db;
				case 38u:
					num = ((int)num2 * -1011470999) ^ 0x6ACC7E90;
					continue;
				case 36u:
					num = ((int)num2 * -827282887) ^ 0x7D97431E;
					continue;
				case 35u:
					num = (int)((num2 * 435069287) ^ 0x675D03D7);
					continue;
				case 34u:
					goto IL_0127;
				case 33u:
					goto IL_013d;
				case 32u:
					num = ((int)num2 * -866158619) ^ -1412856118;
					continue;
				case 31u:
					goto IL_0170;
				case 30u:
					goto IL_0186;
				case 29u:
					goto IL_019c;
				case 28u:
					num = ((int)num2 * -671580320) ^ 0x1E31F92C;
					continue;
				case 27u:
					goto IL_01c4;
				case 26u:
					goto IL_01da;
				case 25u:
					goto IL_01f0;
				case 24u:
					_contentLoaded = true;
					num = 1918468460;
					continue;
				case 23u:
					num = ((int)num2 * -486711496) ^ 0x27A98354;
					continue;
				case 22u:
					goto IL_0229;
				case 21u:
					num = (int)(num2 * 1865869418) ^ -809994791;
					continue;
				case 20u:
					goto IL_0251;
				case 19u:
					goto IL_0267;
				case 17u:
					num = ((int)num2 * -1167509081) ^ 0xAC89E57;
					continue;
				case 16u:
					num = ((int)num2 * -2072544045) ^ 0x39A1C26A;
					continue;
				case 15u:
					goto IL_02a1;
				case 14u:
					goto IL_02b7;
				case 13u:
					goto IL_02cd;
				case 12u:
					num = ((int)num2 * -575148346) ^ -1121968112;
					continue;
				case 11u:
					num = (int)(num2 * 111540261) ^ -471110793;
					continue;
				case 10u:
					num = (int)(num2 * 989101279) ^ -370952186;
					continue;
				case 9u:
					goto IL_0319;
				case 8u:
					num = ((int)num2 * -2079820500) ^ 0x1AC07CD4;
					continue;
				case 7u:
					num = ((int)num2 * -1244298145) ^ 0x10451B85;
					continue;
				case 6u:
					num = ((int)num2 * -379127853) ^ -717620438;
					continue;
				case 5u:
					goto IL_0365;
				case 4u:
					num = ((int)num2 * -1602806115) ^ -1590987024;
					continue;
				case 3u:
					switch (connectionId)
					{
					case 15:
						break;
					case 25:
						goto IL_001d;
					case 6:
						goto IL_0045;
					case 26:
						goto IL_005b;
					case 24:
						goto IL_0071;
					case 7:
						goto IL_0099;
					case 12:
						goto IL_00af;
					case 21:
						goto IL_00c5;
					case 10:
						goto IL_00db;
					case 13:
						goto IL_0127;
					case 1:
						goto IL_013d;
					case 2:
						goto IL_0170;
					case 3:
						goto IL_0186;
					case 11:
						goto IL_019c;
					case 14:
						goto IL_01c4;
					case 20:
						goto IL_01da;
					case 5:
						goto IL_01f0;
					case 9:
						goto IL_0229;
					case 22:
						goto IL_0251;
					case 16:
						goto IL_0267;
					case 19:
						goto IL_02a1;
					case 4:
						goto IL_02b7;
					case 23:
						goto IL_02cd;
					case 18:
						goto IL_0319;
					case 17:
						goto IL_0365;
					default:
						goto IL_0403;
					case 8:
						goto IL_0412;
					case 27:
						goto IL_0425;
					}
					goto case 49u;
				case 0u:
					goto IL_0412;
				case 1u:
					goto IL_0425;
				case 2u:
					num = ((int)num2 * -622483662) ^ -1091424892;
					continue;
				default:
					return;
				case 18u:
					break;
				case 37u:
					return;
					IL_0425:
					light25 = (Ellipse)target;
					num = 1164756621;
					continue;
					IL_0412:
					light6 = (Ellipse)target;
					num = 1722498580;
					continue;
					IL_0403:
					num = ((int)num2 * -1424183060) ^ -1163492312;
					continue;
					IL_0365:
					light15 = (Ellipse)target;
					num = 1918468460;
					continue;
					IL_0319:
					light16 = (Ellipse)target;
					num = 1918468460;
					continue;
					IL_02cd:
					light21 = (Ellipse)target;
					num = 53757225;
					continue;
					IL_02b7:
					light2 = (Ellipse)target;
					num = 721701311;
					continue;
					IL_02a1:
					light17 = (Ellipse)target;
					num = 115565414;
					continue;
					IL_0267:
					light14 = (Ellipse)target;
					num = 948670055;
					continue;
					IL_0251:
					light20 = (Ellipse)target;
					num = 1918468460;
					continue;
					IL_0229:
					light7 = (Ellipse)target;
					num = 1918468460;
					continue;
					IL_01f0:
					light3 = (Ellipse)target;
					num = 2132367749;
					continue;
					IL_01da:
					light18 = (Ellipse)target;
					num = 1918468460;
					continue;
					IL_01c4:
					light12 = (Ellipse)target;
					num = 570812250;
					continue;
					IL_019c:
					light9 = (Ellipse)target;
					num = 925677697;
					continue;
					IL_0186:
					light1 = (Ellipse)target;
					num = 1918468460;
					continue;
					IL_0170:
					SomeWhere = (Canvas)target;
					num = 2067710118;
					continue;
					IL_013d:
					Simulation.smethod_18((FrameworkElement)(object)(Simulation)target, new RoutedEventHandler(Window_Loaded));
					num = 1624694217;
					continue;
					IL_0127:
					light11 = (Ellipse)target;
					num = 1813163529;
					continue;
					IL_00db:
					light8 = (Ellipse)target;
					num = 507373450;
					continue;
					IL_00c5:
					light19 = (Ellipse)target;
					num = 1918468460;
					continue;
					IL_00af:
					light10 = (Ellipse)target;
					num = 387297207;
					continue;
					IL_0099:
					light5 = (Ellipse)target;
					num = 691758241;
					continue;
					IL_0071:
					light22 = (Ellipse)target;
					num = 471863536;
					continue;
					IL_005b:
					light24 = (Ellipse)target;
					num = 1918468460;
					continue;
					IL_0045:
					light4 = (Ellipse)target;
					num = 1918468460;
					continue;
					IL_001d:
					light23 = (Ellipse)target;
					num = 1414168220;
					continue;
				}
				break;
			}
		}
	}

	static object smethod_0()
	{
		return new object();
	}

	static Thread smethod_1(ThreadStart threadStart_0)
	{
		return new Thread(threadStart_0);
	}

	static void smethod_2(Thread thread_0, bool bool_0)
	{
		thread_0.IsBackground = bool_0;
	}

	static void smethod_3(Thread thread_0)
	{
		thread_0.Start();
	}

	static MessageBoxResult smethod_4(string string_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0);
	}

	static Dispatcher smethod_5(DispatcherObject dispatcherObject_0)
	{
		return dispatcherObject_0.get_Dispatcher();
	}

	static DispatcherOperation smethod_6(Dispatcher dispatcher_0, DispatcherPriority dispatcherPriority_0, Delegate delegate_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return dispatcher_0.BeginInvoke(dispatcherPriority_0, delegate_0);
	}

	static void smethod_7(int int_0)
	{
		Thread.Sleep(int_0);
	}

	static Random smethod_8()
	{
		return new Random();
	}

	static int smethod_9(Random random_0, int int_0, int int_1)
	{
		return random_0.Next(int_0, int_1);
	}

	static Thread smethod_10(ParameterizedThreadStart parameterizedThreadStart_0)
	{
		return new Thread(parameterizedThreadStart_0);
	}

	static void smethod_11(Thread thread_0, string string_0)
	{
		thread_0.Name = string_0;
	}

	static void smethod_12(Thread thread_0, object object_0)
	{
		thread_0.Start(object_0);
	}

	static void smethod_13(object object_0, ref bool bool_0)
	{
		Monitor.Enter(object_0, ref bool_0);
	}

	static void smethod_14(object object_0)
	{
		Monitor.Exit(object_0);
	}

	static Exception smethod_15(string string_0)
	{
		return new Exception(string_0);
	}

	static Uri smethod_16(string string_0, UriKind uriKind_0)
	{
		return new Uri(string_0, uriKind_0);
	}

	static void smethod_17(object object_0, Uri uri_0)
	{
		Application.LoadComponent(object_0, uri_0);
	}

	static void smethod_18(FrameworkElement frameworkElement_0, RoutedEventHandler routedEventHandler_0)
	{
		frameworkElement_0.add_Loaded(routedEventHandler_0);
	}

	static void smethod_19(Window window_0)
	{
		window_0.Close();
	}
}
