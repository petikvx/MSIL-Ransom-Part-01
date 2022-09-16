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
			int num = 494999617;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x18217740u) % 9u)
				{
				case 7u:
					numberOfCars = countCar;
					num = ((int)num2 * -1797567823) ^ 0x36DA613C;
					continue;
				case 6u:
					InitializeComponent();
					num = (int)(num2 * 1905431130) ^ -231989760;
					continue;
				case 5u:
					thread_ = Simulation.smethod_1((ThreadStart)endSimulation);
					Simulation.smethod_2(thread_, bool_0: true);
					num = (int)(num2 * 727603537) ^ -1122622804;
					continue;
				case 4u:
					num = ((int)num2 * -1594473354) ^ -1394035399;
					continue;
				case 3u:
					num = ((int)num2 * -1380562942) ^ 0x10AFC022;
					continue;
				case 1u:
					num = ((int)num2 * -250679121) ^ 0x182B297D;
					continue;
				case 0u:
					Simulation.smethod_3(thread_);
					num = ((int)num2 * -2135399734) ^ 0x6E8628E5;
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

	private void endSimulation()
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		bool flag = default(bool);
		while (true)
		{
			int num = 885433762;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x30003550u) % 11u)
				{
				case 10u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1757998565;
						num4 = 1757998565;
					}
					else
					{
						num3 = 1840639086;
						num4 = 1840639086;
					}
					num = num3 ^ ((int)num2 * -1039074050);
					continue;
				}
				case 9u:
					num = 1476597172;
					continue;
				case 8u:
					Simulation.smethod_6(Simulation.smethod_5((DispatcherObject)(object)this), (DispatcherPriority)4, (Delegate)(Action)delegate
					{
						Simulation.smethod_19((Window)(object)this);
					});
					num = ((int)num2 * -1256340684) ^ 0x2583DF5F;
					continue;
				case 7u:
					Simulation.smethod_4("Simulation has been done!");
					num = (int)((num2 * 1588068254) ^ 0x50483D22);
					continue;
				case 5u:
					Simulation.smethod_7(2000);
					num = 489978807;
					continue;
				case 4u:
					num = ((int)num2 * -582099841) ^ -371529;
					continue;
				case 3u:
					num = ((int)num2 * -1443916611) ^ -398113364;
					continue;
				case 1u:
					flag = done == numberOfCars;
					num = (int)((num2 * 690084403) ^ 0x516B1802);
					continue;
				case 0u:
					num = (int)(num2 * 1658291878) ^ -559998414;
					continue;
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
			int num = -1030269140;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA592B607u) % 3u)
				{
				case 1u:
					goto IL_0007;
				case 0u:
					break;
				default:
					lights.StartLight(this);
					startThread();
					return;
				}
				break;
				IL_0007:
				createCar();
				num = ((int)num2 * -2019907774) ^ 0x7DEDCBC0;
			}
		}
	}

	private void createCar()
	{
		int num3 = default(int);
		Random random_ = default(Random);
		int num6 = default(int);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 1039330669;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF31D5B7u) % 31u)
				{
				case 30u:
					TrafficPlan.trafficList.Add(new CarInfo(num3));
					num = ((int)num2 * -350114683) ^ 0x214C2779;
					continue;
				case 29u:
					listCar.Add(new Car(num3, "Picture/pic.png"));
					num = 1492341359;
					continue;
				case 28u:
					num = ((int)num2 * -640250468) ^ 0x1BDEEFA2;
					continue;
				case 27u:
					random_ = Simulation.smethod_8();
					num = (int)(num2 * 366688651) ^ -1039929894;
					continue;
				case 26u:
					num = 355516570;
					continue;
				case 24u:
					listCar.Add(new Car(num3, "Picture/pikachu.png"));
					TrafficPlan.trafficList.Add(new CarInfo(num3));
					num = ((int)num2 * -673510519) ^ 0x21FD4960;
					continue;
				case 23u:
					num = (int)(num2 * 1979007171) ^ -366468602;
					continue;
				case 22u:
					listCar.Add(new Car(num3, "Picture/mario.png"));
					TrafficPlan.trafficList.Add(new CarInfo(num3));
					num = (int)((num2 * 1597831211) ^ 0xB5A00CF);
					continue;
				case 21u:
					num = (int)((num2 * 153056557) ^ 0x606A19D6);
					continue;
				case 20u:
					num = ((int)num2 * -1477183650) ^ -1056550369;
					continue;
				case 18u:
					num6 = Simulation.smethod_9(random_, 1, 5);
					num = ((int)num2 * -638080329) ^ -1845947852;
					continue;
				case 17u:
				{
					int num10;
					int num11;
					if (flag3)
					{
						num10 = 1172521166;
						num11 = 1172521166;
					}
					else
					{
						num10 = 1286969931;
						num11 = 1286969931;
					}
					num = num10 ^ (int)(num2 * 430977551);
					continue;
				}
				case 16u:
					flag2 = 1 == num6;
					num = (int)(num2 * 952966987) ^ -1048784788;
					continue;
				case 15u:
					num = (int)(num2 * 848465855) ^ -62313807;
					continue;
				case 14u:
					num = ((int)num2 * -339613417) ^ -1322867141;
					continue;
				case 13u:
					num = ((int)num2 * -701928261) ^ 0x14D6C6C3;
					continue;
				case 12u:
					num = (int)((num2 * 316056882) ^ 0x494C4A95);
					continue;
				case 11u:
					num3++;
					num = ((int)num2 * -430797942) ^ -954824095;
					continue;
				case 10u:
					num = 1025942742;
					continue;
				case 9u:
				{
					int num9;
					if (2 != num6)
					{
						num = 1590951263;
						num9 = 1590951263;
					}
					else
					{
						num = 942758125;
						num9 = 942758125;
					}
					continue;
				}
				case 8u:
					num = ((int)num2 * -758033821) ^ -1774356618;
					continue;
				case 7u:
					num = ((int)num2 * -296297505) ^ 0x2E1821C7;
					continue;
				case 6u:
					flag3 = 3 == num6;
					num = 464731794;
					continue;
				case 5u:
				{
					int num7;
					int num8;
					if (flag)
					{
						num7 = -2032843970;
						num8 = -2032843970;
					}
					else
					{
						num7 = -2054794524;
						num8 = -2054794524;
					}
					num = num7 ^ ((int)num2 * -946473026);
					continue;
				}
				case 4u:
					num3 = 0;
					num = ((int)num2 * -152325076) ^ 0xEDAF7E7;
					continue;
				case 3u:
					listCar.Add(new Car(num3, "Picture/star.png"));
					num = (int)(num2 * 589703238) ^ -1414471468;
					continue;
				case 2u:
					TrafficPlan.trafficList.Add(new CarInfo(num3));
					num = (int)(num2 * 1628654349) ^ -1220255754;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (flag2)
					{
						num4 = -1618200779;
						num5 = -1618200779;
					}
					else
					{
						num4 = -795128978;
						num5 = -795128978;
					}
					num = num4 ^ ((int)num2 * -1569853334);
					continue;
				}
				case 0u:
					flag = num3 < numberOfCars;
					num = 572776404;
					continue;
				default:
					return;
				case 19u:
					break;
				case 25u:
					return;
				}
				break;
			}
		}
	}

	private void startThread()
	{
		int num = 0;
		Thread thread_ = default(Thread);
		while (true)
		{
			int num2 = 1705197078;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x3682B642u) % 9u)
				{
				case 7u:
					num++;
					num2 = ((int)num3 * -952589981) ^ -219593157;
					continue;
				case 6u:
					num2 = ((int)num3 * -521775765) ^ -2001214755;
					continue;
				case 5u:
				{
					int num4;
					if (num >= numberOfCars)
					{
						num2 = 1451326986;
						num4 = 1451326986;
					}
					else
					{
						num2 = 1052417102;
						num4 = 1052417102;
					}
					continue;
				}
				case 4u:
					thread_ = Simulation.smethod_10((ParameterizedThreadStart)animate);
					Simulation.smethod_2(thread_, bool_0: true);
					num2 = 1690988951;
					continue;
				case 2u:
					Simulation.smethod_11(thread_, num.ToString());
					num2 = (int)(num3 * 121073465) ^ -840514798;
					continue;
				case 1u:
					num2 = (int)(num3 * 112301441) ^ -1777640461;
					continue;
				case 0u:
					Simulation.smethod_12(thread_, (object)num);
					num2 = (int)(num3 * 2032324341) ^ -1155557588;
					continue;
				default:
					return;
				case 3u:
					break;
				case 8u:
					return;
				}
				break;
			}
		}
	}

	private void animate(object idCar)
	{
		Car car = listCar[(int)idCar];
		bool flag4 = default(bool);
		List<Point> list = default(List<Point>);
		int num3 = default(int);
		bool flag = default(bool);
		bool flag6 = default(bool);
		Random random_ = default(Random);
		bool flag3 = default(bool);
		WhereIsNow whereIsNow = default(WhereIsNow);
		bool flag5 = default(bool);
		bool flag2 = default(bool);
		bool flag7 = default(bool);
		while (true)
		{
			int num = -832037248;
			while (true)
			{
				int num8;
				object object_;
				bool bool_;
				WhereIsNow iAmHere;
				int num15;
				uint num2;
				switch ((num2 = (uint)num ^ 0x882D43FCu) % 169u)
				{
				case 8u:
				case 23u:
				case 25u:
				case 26u:
				case 35u:
				case 42u:
				case 45u:
				case 53u:
				case 59u:
				case 66u:
				case 73u:
				case 80u:
				case 84u:
				case 95u:
				case 108u:
				case 110u:
				case 124u:
				case 128u:
				case 132u:
				case 150u:
				case 158u:
				case 164u:
				case 165u:
				case 167u:
				case 168u:
					goto IL_0154;
				case 49u:
					goto IL_017e;
				case 166u:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Bitwy_South_Entry_2;
					num = ((int)num2 * -680934362) ^ -317468789;
					continue;
				case 163u:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Aleje_West_Entry_2;
					num = ((int)num2 * -1893869768) ^ 0x46DE29A3;
					continue;
				case 162u:
					goto IL_0205;
				case 161u:
					num = (int)(num2 * 968501168) ^ -1340170383;
					continue;
				case 160u:
					num = (int)((num2 * 1786704175) ^ 0x992CA8D);
					continue;
				default:
					goto IL_0244;
				case 157u:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_2_South_Exit;
					num = ((int)num2 * -1889219495) ^ -2084127210;
					continue;
				case 156u:
				{
					int num9;
					int num10;
					if (!flag4)
					{
						num9 = -359172614;
						num10 = -359172614;
					}
					else
					{
						num9 = -679522878;
						num10 = -679522878;
					}
					num = num9 ^ (int)(num2 * 613731806);
					continue;
				}
				case 155u:
					num = (int)((num2 * 1351904834) ^ 0x2CC9B05D);
					continue;
				case 154u:
					num = (int)(num2 * 1707239816) ^ -1347853843;
					continue;
				case 153u:
					list = null;
					num = (int)((num2 * 623402447) ^ 0x6A630B7A);
					continue;
				case 152u:
					flag4 = 1 == num3;
					num = (int)((num2 * 450693539) ^ 0x2F59A2C3);
					continue;
				case 151u:
					list = Points.Aleje_West_Exit_1;
					num = (int)(num2 * 341480100) ^ -1256850531;
					continue;
				case 149u:
					list = Points.Rondo_2_North_Entry_Rondo_3;
					num = ((int)num2 * -1037959786) ^ 0x476AFD1B;
					continue;
				case 148u:
					list = Points.Rondo_2_South_Inside_Exit;
					num = (int)(num2 * 115194628) ^ -1882789182;
					continue;
				case 147u:
					goto IL_043b;
				case 146u:
					list = Points.Rondo_East_Inside;
					num = ((int)num2 * -867275447) ^ 0x6AF3647B;
					continue;
				case 145u:
					num = (int)(num2 * 1668034428) ^ -289210785;
					continue;
				case 144u:
					num = (int)(num2 * 1982814717) ^ -1818752320;
					continue;
				case 143u:
					list = Points.Rondo_3_Inside_Left_exit;
					goto IL_0154;
				case 142u:
					goto IL_04b1;
				case 141u:
					list = Points.Bitwy_South_Entry_2;
					num = ((int)num2 * -956334876) ^ 0x7D8E686E;
					continue;
				case 140u:
					num = (int)(num2 * 1912383829) ^ -64898588;
					continue;
				case 139u:
				{
					int num18;
					int num19;
					if (!flag)
					{
						num18 = 387316527;
						num19 = 387316527;
					}
					else
					{
						num18 = 811532477;
						num19 = 811532477;
					}
					num = num18 ^ (int)(num2 * 1622098360);
					continue;
				}
				case 138u:
					goto IL_052c;
				case 137u:
					Simulation.smethod_6(Simulation.smethod_5((DispatcherObject)(object)this), (DispatcherPriority)4, (Delegate)(Action)delegate
					{
						_003C_003Ec__DisplayClass18_0.smethod_2((UIElement)(object)car.picture, -30.0);
						while (true)
						{
							int num22 = 1336587095;
							while (true)
							{
								uint num23;
								switch ((num23 = (uint)num22 ^ 0x65255901u) % 3u)
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
								num22 = (int)((num23 * 1580977999) ^ 0x7B25575E);
							}
						}
					});
					Simulation.smethod_6(Simulation.smethod_5((DispatcherObject)(object)this), (DispatcherPriority)4, (Delegate)(Action)delegate
					{
						_003C_003Ec__DisplayClass18_0.smethod_3((UIElement)(object)car.picture, -30.0);
					});
					goto IL_0105;
				case 136u:
					num = -1891026265;
					continue;
				case 135u:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Bitwy_North_Entry_2;
					num = (int)((num2 * 447242457) ^ 0x3A64C5E8);
					continue;
				case 134u:
					list = Points.Bitwy_North_Right_Aleje;
					num = ((int)num2 * -1344462207) ^ -928026475;
					continue;
				case 133u:
					goto IL_05c8;
				case 131u:
				{
					int num16;
					int num17;
					if (flag6)
					{
						num16 = -1310845467;
						num17 = -1310845467;
					}
					else
					{
						num16 = -220421952;
						num17 = -220421952;
					}
					num = num16 ^ ((int)num2 * -258550966);
					continue;
				}
				case 130u:
					goto IL_0604;
				case 129u:
					list = Points.Rondo_2_East_Exit;
					num = (int)(num2 * 1781602882) ^ -36725994;
					continue;
				case 127u:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Bitwy_South_Right_Aleje;
					list = Points.Bitwy_South_Right_Aleje;
					num = (int)((num2 * 2041733519) ^ 0x1396A48E);
					continue;
				case 126u:
					list = Points.Aleje_East_Exit_2;
					goto IL_0154;
				case 125u:
					list = Points.Rondo_1_East_Entry_Rondo_2;
					num = (int)(num2 * 523345648) ^ -1554421511;
					continue;
				case 123u:
					goto IL_069c;
				case 122u:
					num = ((int)num2 * -852487515) ^ -1818552742;
					continue;
				case 121u:
					num = ((int)num2 * -72810801) ^ -422093560;
					continue;
				case 120u:
					num = ((int)num2 * -1067929852) ^ -1247978066;
					continue;
				case 119u:
					list = Points.Aleje_West_Entry_Bitwy;
					num = ((int)num2 * -2075799944) ^ -2142675381;
					continue;
				case 118u:
					goto IL_0714;
				case 117u:
					list = Points.Rondo_1_South_Inside_Rondo_2_Inside;
					num = (int)((num2 * 1096362680) ^ 0x74E22A70);
					continue;
				case 116u:
					goto IL_0753;
				case 115u:
					list = Points.Rondo_1_North_Entry_Rondo_2;
					goto IL_0154;
				case 114u:
					num = (int)((num2 * 20758839) ^ 0xE814601);
					continue;
				case 113u:
					goto IL_079c;
				case 112u:
					num = -2007731758;
					continue;
				case 111u:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_2_East_Exit;
					list = Points.Rondo_2_East_Exit;
					num = ((int)num2 * -1222266994) ^ 0x65E6A0E0;
					continue;
				case 109u:
					list = Points.Bitwy_South_Exit_2;
					num = ((int)num2 * -2077876664) ^ 0x565EEB50;
					continue;
				case 107u:
					random_ = Simulation.smethod_8();
					num = ((int)num2 * -1131247231) ^ 0x643BB1AE;
					continue;
				case 106u:
					flag3 = num3 == 1;
					num = ((int)num2 * -184783307) ^ 0x7D2861C9;
					continue;
				case 105u:
					list = Points.Bitwy_North_Exit_2;
					num = ((int)num2 * -734122414) ^ -74297857;
					continue;
				case 104u:
					goto IL_086a;
				case 103u:
					num = -1850450171;
					continue;
				case 102u:
					goto IL_089a;
				case 101u:
					num = ((int)num2 * -361447594) ^ 0x38C63FAB;
					continue;
				case 100u:
					switch (whereIsNow)
					{
					case WhereIsNow.Done:
						break;
					case WhereIsNow.Aleje_West_Entry_1:
						goto IL_0205;
					case WhereIsNow.Beginning:
						goto IL_0244;
					case WhereIsNow.Rondo_2_West_Exit:
						goto IL_043b;
					case WhereIsNow.Rondo_1_Inside_Left_Entry_Rondo_2:
						goto IL_04b1;
					case WhereIsNow.Bitwy_South_Entry_1:
						goto IL_052c;
					case WhereIsNow.Rondo_1_South_Entry_Rondo_2:
						goto IL_05c8;
					case WhereIsNow.Bitwy_South_Entry_2:
						goto IL_0604;
					case WhereIsNow.Bitwy_South_Exit_1:
						goto IL_069c;
					case WhereIsNow.Rondo_2_Inside_Left_Entry_Rondo_3:
						goto IL_0714;
					case WhereIsNow.Rondo_3_North_Exit:
						goto IL_0753;
					case WhereIsNow.Rondo_2_South_Exit:
						goto IL_079c;
					case WhereIsNow.Bitwy_North_Exit_2:
						goto IL_086a;
					case WhereIsNow.Bitwy_South_Right_Aleje:
						goto IL_089a;
					default:
						goto IL_0975;
					case WhereIsNow.Aleje_East_Entry_Rondo:
						goto IL_0988;
					case WhereIsNow.Aleje_East_Exit_1:
						goto IL_09ae;
					case WhereIsNow.Aleje_East_Exit_2:
						goto IL_09d3;
					case WhereIsNow.Aleje_East_Right_Bitwy:
						goto IL_09f9;
					case WhereIsNow.Aleje_Entry_Left_Bitwy:
						goto IL_0a1f;
					case WhereIsNow.Aleje_West_Entry_2:
						goto IL_0a4b;
					case WhereIsNow.Aleje_West_Entry_Bitwy:
						goto IL_0a71;
					case WhereIsNow.Aleje_West_Exit_1:
						goto IL_0a97;
					case WhereIsNow.Aleje_West_Exit_2:
						goto IL_0abd;
					case WhereIsNow.Bitwy_North_Entry_1:
						goto IL_0ae3;
					case WhereIsNow.Bitwy_North_Entry_2:
						goto IL_0afc;
					case WhereIsNow.Bitwy_North_Entry_Left_Rondo:
						goto IL_0b22;
					case WhereIsNow.Bitwy_North_Exit_1:
						goto IL_0b48;
					case WhereIsNow.Bitwy_North_Left_Exit:
						goto IL_0b6e;
					case WhereIsNow.Bitwy_North_Right_Aleje:
						goto IL_0b94;
					case WhereIsNow.Bitwy_South_Exit_2:
						goto IL_0bba;
					case WhereIsNow.Rondo_1_East_Entry_Rondo_2:
						goto IL_0be0;
					case WhereIsNow.Rondo_1_North_Entry_Rondo_2:
						goto IL_0bf3;
					case WhereIsNow.Rondo_1_South_Inside_Rondo_2_Inside:
						goto IL_0c19;
					case WhereIsNow.Rondo_1_West_Entry_Rondo_2:
						goto IL_0c3f;
					case WhereIsNow.Rondo_2_East_Exit:
						goto IL_0c7d;
					case WhereIsNow.Rondo_2_North_Entry_Rondo_3:
						goto IL_0ca3;
					case WhereIsNow.Rondo_2_South_Inside_Exit:
						goto IL_0ccf;
					case WhereIsNow.Rondo_3_Inside_Left_exit:
						goto IL_0ce2;
					case WhereIsNow.Rondo_East_Inside:
						goto IL_0d08;
					}
					goto IL_00c2;
				case 24u:
					goto IL_0988;
				case 50u:
					goto IL_09ae;
				case 9u:
					goto IL_09d3;
				case 91u:
					goto IL_09f9;
				case 37u:
					goto IL_0a1f;
				case 86u:
					goto IL_0a4b;
				case 48u:
					goto IL_0a71;
				case 15u:
					goto IL_0a97;
				case 30u:
					goto IL_0abd;
				case 70u:
					goto IL_0ae3;
				case 83u:
					goto IL_0afc;
				case 64u:
					goto IL_0b22;
				case 92u:
					goto IL_0b48;
				case 75u:
					goto IL_0b6e;
				case 39u:
					goto IL_0b94;
				case 62u:
					goto IL_0bba;
				case 90u:
					goto IL_0be0;
				case 69u:
					goto IL_0bf3;
				case 22u:
					goto IL_0c19;
				case 65u:
					goto IL_0c3f;
				case 68u:
					goto IL_0c7d;
				case 32u:
					goto IL_0ca3;
				case 81u:
					goto IL_0ccf;
				case 19u:
					goto IL_0ce2;
				case 87u:
					goto IL_0d08;
				case 99u:
					flag6 = 1 == num3;
					num = ((int)num2 * -1977439237) ^ 0x7E3D23C2;
					continue;
				case 98u:
					driveByViaduct(car, timeDriveUndeViaductInsideRondoNorth);
					num = ((int)num2 * -1018096198) ^ -2045601736;
					continue;
				case 97u:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_East_Inside;
					num = -1572556389;
					continue;
				case 96u:
					num = ((int)num2 * -63160450) ^ 0x34B0C215;
					continue;
				case 94u:
					num = ((int)num2 * -1315327828) ^ 0x5F77324B;
					continue;
				case 93u:
					list = Points.Aleje_East_Exit_2;
					goto IL_0154;
				case 89u:
					num = ((int)num2 * -1061782912) ^ 0x68E18569;
					continue;
				case 88u:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Bitwy_North_Right_Aleje;
					num = (int)((num2 * 1436134237) ^ 0x486F8097);
					continue;
				case 85u:
					num = ((int)num2 * -1623302667) ^ -1733709539;
					continue;
				case 82u:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Aleje_West_Exit_1;
					num = (int)((num2 * 2030958415) ^ 0x4DB84DF1);
					continue;
				case 79u:
					list = Points.Rondo_1_South_Entry_Rondo_2;
					goto IL_0154;
				case 78u:
					list = null;
					num = (int)((num2 * 941717842) ^ 0x70FED6BC);
					continue;
				case 77u:
					list = Points.Rondo_East_Inside;
					num = ((int)num2 * -1319688558) ^ 0x9C732AC;
					continue;
				case 76u:
					list = Points.Bitwy_North_Exit_1;
					num = ((int)num2 * -720066612) ^ -1293876621;
					continue;
				case 74u:
				{
					int num11;
					int num12;
					if (!flag5)
					{
						num11 = -215044320;
						num12 = -215044320;
					}
					else
					{
						num11 = -525156071;
						num12 = -525156071;
					}
					num = num11 ^ ((int)num2 * -1303519154);
					continue;
				}
				case 72u:
					num = -371372147;
					continue;
				case 71u:
					list = Points.Aleje_West_Entry_2;
					num = (int)((num2 * 790139754) ^ 0x43860462);
					continue;
				case 67u:
					list = Points.Aleje_West_Exit_2;
					goto IL_0154;
				case 63u:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Aleje_West_Entry_Bitwy;
					num = -1223537288;
					continue;
				case 61u:
				{
					int num6;
					int num7;
					if (!flag3)
					{
						num6 = -1637159539;
						num7 = -1637159539;
					}
					else
					{
						num6 = -1139890915;
						num7 = -1139890915;
					}
					num = num6 ^ (int)(num2 * 74034376);
					continue;
				}
				case 60u:
					list = Points.Rondo_2_South_Exit;
					num = (int)(num2 * 886986063) ^ -417991733;
					continue;
				case 58u:
					num = ((int)num2 * -2049611942) ^ 0x5353762;
					continue;
				case 57u:
					list = Points.Bitwy_North_Exit_2;
					goto IL_0154;
				case 56u:
					num = (int)((num2 * 462362905) ^ 0x196F5AFA);
					continue;
				case 55u:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_East_Inside;
					num = -849939998;
					continue;
				case 54u:
					list = null;
					goto IL_0154;
				case 52u:
					list = Points.Bitwy_North_Entry_2;
					num = (int)(num2 * 1492177419) ^ -366890698;
					continue;
				case 51u:
					driveByViaduct(car, timeDriveUnderViaductInsideRondoEast);
					num = -197657701;
					continue;
				case 47u:
				{
					int num4;
					int num5;
					if (!flag2)
					{
						num4 = 1458846882;
						num5 = 1458846882;
					}
					else
					{
						num4 = 1016992327;
						num5 = 1016992327;
					}
					num = num4 ^ ((int)num2 * -1270284644);
					continue;
				}
				case 46u:
					flag = num3 == 1;
					num = ((int)num2 * -1643570545) ^ 0x172088CB;
					continue;
				case 44u:
					list = Points.Rondo_2_North_Entry_Rondo_3;
					num = (int)(num2 * 1818807162) ^ -1933738322;
					continue;
				case 43u:
					list = Points.Aleje_West_Exit_2;
					goto IL_0154;
				case 41u:
					list = null;
					num = (int)(num2 * 1092489608) ^ -1282749246;
					continue;
				case 40u:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_1_South_Inside_Rondo_2_Inside;
					num = ((int)num2 * -1567583220) ^ -2037773304;
					continue;
				case 38u:
					num3 = 0;
					Simulation.smethod_6(Simulation.smethod_5((DispatcherObject)(object)this), (DispatcherPriority)4, (Delegate)(Action)delegate
					{
						_003C_003Ec__DisplayClass18_0.smethod_1(_003C_003Ec__DisplayClass18_0.smethod_0((Panel)(object)SomeWhere), (UIElement)(object)car.picture);
					});
					num = ((int)num2 * -1797736782) ^ -1868979827;
					continue;
				case 36u:
					num = ((int)num2 * -1846353387) ^ 0x52103BAD;
					continue;
				case 34u:
					num = ((int)num2 * -416092573) ^ -1450399999;
					continue;
				case 33u:
					num = (int)(num2 * 330232489) ^ -847410778;
					continue;
				case 31u:
					num = ((int)num2 * -1756644225) ^ -54148114;
					continue;
				case 29u:
					list = Points.Rondo_1_West_Entry_Rondo_2;
					num = (int)(num2 * 798721923) ^ -355637808;
					continue;
				case 28u:
					num = (int)(num2 * 1926082779) ^ -1887839606;
					continue;
				case 27u:
					list = Points.Bitwy_South_Exit_2;
					num = ((int)num2 * -1382630680) ^ 0x45D13B09;
					continue;
				case 21u:
					num = (int)(num2 * 788536318) ^ -1981547712;
					continue;
				case 20u:
					num = ((int)num2 * -89188322) ^ -659771317;
					continue;
				case 18u:
					driveByViaduct(car, timeDriveUnderViaductInsideRondoEast);
					num = -241939780;
					continue;
				case 17u:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_2_East_Exit;
					num = ((int)num2 * -1416690415) ^ 0x1DD2D01E;
					continue;
				case 16u:
					num = ((int)num2 * -840739967) ^ -299240996;
					continue;
				case 14u:
					driveByViaduct(car, timeDriveByTunnel);
					num = (int)(num2 * 1179250912) ^ -149517360;
					continue;
				case 13u:
					list = null;
					num = (int)((num2 * 1270154888) ^ 0x2331E50C);
					continue;
				case 12u:
					list = Points.Rondo_1_Inside_Left_Entry_Rondo_2;
					goto IL_0154;
				case 11u:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_1_West_Entry_Rondo_2;
					num = (int)((num2 * 2042988184) ^ 0x10E9EF3F);
					continue;
				case 7u:
					num = ((int)num2 * -857850254) ^ -809795035;
					continue;
				case 6u:
					list = Points.Rondo_2_Inside_Left_Entry_Rondo_3;
					num = ((int)num2 * -18494346) ^ -1728452989;
					continue;
				case 5u:
					num = (int)((num2 * 460506496) ^ 0x69A77389);
					continue;
				case 4u:
					list = Points.Rondo_1_West_Entry_Rondo_2;
					goto IL_0154;
				case 3u:
					num = (int)(num2 * 663338166) ^ -761475660;
					continue;
				case 1u:
					num = (int)((num2 * 510205947) ^ 0x4379944C);
					continue;
				case 0u:
					list = null;
					num = ((int)num2 * -884126088) ^ -246316485;
					continue;
				case 2u:
					break;
				case 10u:
					goto IL_157f;
					IL_0105:
					num8 = -594129680;
					goto IL_010a;
					IL_00c2:
					Simulation.smethod_6(Simulation.smethod_5((DispatcherObject)(object)this), (DispatcherPriority)4, (Delegate)(Action)delegate
					{
						_003C_003Ec__DisplayClass18_0.smethod_4(_003C_003Ec__DisplayClass18_0.smethod_0((Panel)(object)SomeWhere), (UIElement)(object)car.picture);
					});
					done++;
					num8 = -691674218;
					goto IL_010a;
					IL_0244:
					object_ = lock_object;
					bool_ = false;
					try
					{
						Simulation.smethod_13(object_, ref bool_);
						while (true)
						{
							IL_02f7:
							int num13 = -719800471;
							while (true)
							{
								switch ((num2 = (uint)num13 ^ 0x882D43FCu) % 7u)
								{
								case 5u:
									canEntryToScene(car);
									num13 = (int)((num2 * 153551233) ^ 0x62F41E11);
									continue;
								case 4u:
									list = choiseStartTrace(car.id);
									num13 = (int)((num2 * 608962905) ^ 0x7FCB7101);
									continue;
								case 3u:
									num13 = (int)((num2 * 1310602198) ^ 0x152110D1);
									continue;
								case 1u:
									num13 = ((int)num2 * -275254886) ^ -1387744822;
									continue;
								case 0u:
									num13 = ((int)num2 * -900181665) ^ -14171808;
									continue;
								default:
									goto end_IL_02c9;
								case 2u:
									break;
								case 6u:
									goto end_IL_02c9;
								}
								goto IL_02f7;
								continue;
								end_IL_02c9:
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
								IL_033c:
								int num14 = -1933160858;
								while (true)
								{
									switch ((num2 = (uint)num14 ^ 0x882D43FCu) % 3u)
									{
									case 1u:
										goto IL_0309;
									default:
										goto end_IL_031e;
									case 2u:
										break;
									case 0u:
										goto end_IL_031e;
									}
									goto IL_033c;
									IL_0309:
									Simulation.smethod_14(object_);
									num14 = (int)((num2 * 382840208) ^ 0x1D40350B);
									continue;
									end_IL_031e:
									break;
								}
								break;
							}
						}
					}
					goto IL_0154;
					IL_017e:
					iAmHere = TrafficPlan.trafficList[car.id].iAmHere;
					whereIsNow = iAmHere;
					num = -1863786483;
					continue;
					IL_0d08:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_2_North_Entry_Rondo_3;
					num = -557797025;
					continue;
					IL_0ce2:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Aleje_East_Exit_1;
					list = Points.Aleje_East_Exit_1;
					goto IL_0154;
					IL_0ccf:
					num3 = Simulation.smethod_9(random_, 1, 3);
					num = -782418373;
					continue;
					IL_0ca3:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_3_North_Exit;
					list = Points.Rondo_3_North_Exit;
					num = -327188279;
					continue;
					IL_0c7d:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Bitwy_North_Exit_1;
					num = -908376344;
					continue;
					IL_0c3f:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_2_West_Exit;
					list = Points.Rondo_2_West_Exit;
					driveByViaduct(car, timeDriveUnderViaductWest);
					num = -2016632999;
					continue;
					IL_0c19:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_2_South_Inside_Exit;
					num = -714036527;
					continue;
					IL_0bf3:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_2_North_Entry_Rondo_3;
					num = -2086447557;
					continue;
					IL_0be0:
					num3 = Simulation.smethod_9(random_, 1, 3);
					num = -1690226184;
					continue;
					IL_0bba:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Done;
					num = -835926765;
					continue;
					IL_0b94:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Aleje_West_Exit_2;
					num = -1209113602;
					continue;
					IL_0b6e:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Done;
					num = -1126806958;
					continue;
					IL_0b48:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Bitwy_North_Exit_2;
					num = -1899630600;
					continue;
					IL_0b22:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_1_Inside_Left_Entry_Rondo_2;
					num = -915816521;
					continue;
					IL_0afc:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_1_West_Entry_Rondo_2;
					num = -1151493531;
					continue;
					IL_0ae3:
					num3 = Simulation.smethod_9(random_, 1, 3);
					flag5 = num3 == 1;
					num = -452214932;
					continue;
					IL_0abd:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Done;
					num = -2088403058;
					continue;
					IL_0a97:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Aleje_West_Exit_2;
					num = -565237995;
					continue;
					IL_0a71:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Bitwy_South_Exit_2;
					num = -1104606745;
					continue;
					IL_0a4b:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_1_South_Entry_Rondo_2;
					num = -1862619572;
					continue;
					IL_0a1f:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Bitwy_North_Left_Exit;
					list = Points.Bitwy_North_Left_Exit;
					num = -1172047879;
					continue;
					IL_09f9:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Bitwy_North_Exit_2;
					num = -2127657105;
					continue;
					IL_09d3:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Done;
					num = -1466053587;
					continue;
					IL_09ae:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Aleje_East_Exit_2;
					num = -1711707501;
					continue;
					IL_0988:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_1_North_Entry_Rondo_2;
					num = -1793702335;
					continue;
					IL_0975:
					num = ((int)num2 * -1630603591) ^ -1081844983;
					continue;
					IL_089a:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Aleje_East_Exit_2;
					num = -100537402;
					continue;
					IL_086a:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Done;
					num = -1411501707;
					continue;
					IL_079c:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Aleje_East_Exit_1;
					list = Points.Aleje_East_Exit_1;
					num = -2013656467;
					continue;
					IL_0753:
					num3 = Simulation.smethod_9(random_, 1, 3);
					if (num3 != 1)
					{
						num = -72216813;
						num15 = -72216813;
					}
					else
					{
						num = -1884885379;
						num15 = -1884885379;
					}
					continue;
					IL_0714:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_3_Inside_Left_exit;
					num = -1020311920;
					continue;
					IL_069c:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Bitwy_South_Exit_2;
					num = -1486839505;
					continue;
					IL_0604:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_1_East_Entry_Rondo_2;
					num = -1801541412;
					continue;
					IL_0205:
					num3 = Simulation.smethod_9(random_, 1, 3);
					flag2 = num3 == 1;
					num = -522786237;
					continue;
					IL_05c8:
					num3 = Simulation.smethod_9(random_, 1, 3);
					num = -1691312098;
					continue;
					IL_052c:
					num3 = Simulation.smethod_9(random_, 1, 3);
					num = -622931270;
					continue;
					IL_010a:
					while (true)
					{
						switch ((num2 = (uint)num8 ^ 0x882D43FCu) % 13u)
						{
						case 11u:
							num8 = -166526628;
							continue;
						case 8u:
							num8 = (int)((num2 * 1649487890) ^ 0x5EF507C7);
							continue;
						case 7u:
							canExitCheckpoint(car);
							num8 = ((int)num2 * -221368570) ^ 0x394B72B5;
							continue;
						case 6u:
							num8 = (int)((num2 * 852206030) ^ 0x741E50EC);
							continue;
						case 5u:
						{
							int num20;
							int num21;
							if (!flag7)
							{
								num20 = -1489860829;
								num21 = -1489860829;
							}
							else
							{
								num20 = -629773921;
								num21 = -629773921;
							}
							num8 = num20 ^ (int)(num2 * 492184847);
							continue;
						}
						case 4u:
							moveCar(car, list);
							num8 = (int)(num2 * 865261288) ^ -443877701;
							continue;
						case 2u:
							num8 = -1823605579;
							continue;
						case 1u:
							break;
						case 0u:
							goto IL_0105;
						default:
							return;
						case 3u:
							goto IL_0154;
						case 12u:
							goto IL_017e;
						case 10u:
							goto IL_157f;
						case 9u:
							return;
						}
						break;
					}
					goto IL_00c2;
					IL_157f:
					throw Simulation.smethod_15("xD");
					IL_0154:
					flag7 = TrafficPlan.trafficList[car.id].iAmHere != WhereIsNow.Done;
					num8 = -117966005;
					goto IL_010a;
					IL_04b1:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_2_Inside_Left_Entry_Rondo_3;
					num = -739751137;
					continue;
					IL_043b:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Bitwy_South_Exit_1;
					list = Points.Bitwy_South_Exit_1;
					num = -1649379679;
					continue;
				}
				break;
			}
		}
	}

	private List<Point> choiseStartTrace(int idCar)
	{
		bool flag4 = default(bool);
		List<Point> result = default(List<Point>);
		bool flag2 = default(bool);
		int num3 = default(int);
		bool flag3 = default(bool);
		Random random_ = default(Random);
		bool flag = default(bool);
		while (true)
		{
			int num = 965515993;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5E465FEFu) % 39u)
				{
				case 38u:
				{
					int num12;
					int num13;
					if (!flag4)
					{
						num12 = 820111136;
						num13 = 820111136;
					}
					else
					{
						num12 = 1413851341;
						num13 = 1413851341;
					}
					num = num12 ^ ((int)num2 * -425347002);
					continue;
				}
				case 37u:
					num = (int)((num2 * 304361753) ^ 0x1C10D9C8);
					continue;
				case 36u:
					TrafficPlan.trafficList[idCar].iAmHere = WhereIsNow.Aleje_Entry_Left_Bitwy;
					result = Points.Aleje_Entry_Left_Bitwy;
					num = (int)(num2 * 1714363412) ^ -1870810836;
					continue;
				case 35u:
					TrafficPlan.trafficList[idCar].iAmHere = WhereIsNow.Aleje_West_Entry_1;
					num = (int)((num2 * 1275142668) ^ 0x6E823B87);
					continue;
				case 34u:
					flag2 = 4 == num3;
					num = 622111607;
					continue;
				case 33u:
					flag4 = 3 == num3;
					num = 628357988;
					continue;
				case 32u:
					result = Points.Aleje_West_Entry_1;
					num = ((int)num2 * -855571039) ^ 0x2CE60649;
					continue;
				case 31u:
					num = (int)((num2 * 1501732304) ^ 0x30189F1D);
					continue;
				case 30u:
					result = Points.Aleje_East_Entry_Rondo;
					num = ((int)num2 * -849719144) ^ -1046311980;
					continue;
				case 29u:
					result = Points.Bitwy_North_Entry_1;
					num = (int)(num2 * 786582862) ^ -879653036;
					continue;
				case 28u:
					TrafficPlan.trafficList[idCar].iAmHere = WhereIsNow.Bitwy_South_Entry_1;
					num = ((int)num2 * -925074976) ^ -1759231080;
					continue;
				case 27u:
					TrafficPlan.trafficList[idCar].iAmHere = WhereIsNow.Aleje_East_Entry_Rondo;
					num = ((int)num2 * -2097700622) ^ 0x3E9DD32B;
					continue;
				case 26u:
					num = (int)(num2 * 635268781) ^ -1926586356;
					continue;
				case 25u:
				{
					int num11;
					if (5 == num3)
					{
						num = 390534827;
						num11 = 390534827;
					}
					else
					{
						num = 192122454;
						num11 = 192122454;
					}
					continue;
				}
				case 23u:
					flag3 = 1 == num3;
					num = (int)((num2 * 1343602999) ^ 0x56DF6DB);
					continue;
				case 22u:
				{
					int num10;
					if (6 != num3)
					{
						num = 1550482716;
						num10 = 1550482716;
					}
					else
					{
						num = 51005985;
						num10 = 51005985;
					}
					continue;
				}
				case 21u:
					num3 = Simulation.smethod_9(random_, 1, 8);
					num = ((int)num2 * -758957367) ^ -535464971;
					continue;
				case 20u:
					num = 1507485853;
					continue;
				case 19u:
					num = ((int)num2 * -442092872) ^ -1581733027;
					continue;
				case 18u:
					num = (int)((num2 * 881462480) ^ 0x4CAE8F2D);
					continue;
				case 17u:
				{
					int num8;
					int num9;
					if (!flag)
					{
						num8 = 1121686880;
						num9 = 1121686880;
					}
					else
					{
						num8 = 890223242;
						num9 = 890223242;
					}
					num = num8 ^ (int)(num2 * 460560258);
					continue;
				}
				case 16u:
					result = Points.Aleje_East_Right_Bitwy;
					num = ((int)num2 * -1116757677) ^ 0xD34BCBB;
					continue;
				case 15u:
					num = ((int)num2 * -1667872334) ^ 0x715B527A;
					continue;
				case 14u:
				{
					int num6;
					int num7;
					if (flag3)
					{
						num6 = 1275355705;
						num7 = 1275355705;
					}
					else
					{
						num6 = 692117366;
						num7 = 692117366;
					}
					num = num6 ^ (int)(num2 * 1800407541);
					continue;
				}
				case 13u:
				{
					int num4;
					int num5;
					if (!flag2)
					{
						num4 = 1429847477;
						num5 = 1429847477;
					}
					else
					{
						num4 = 1421116878;
						num5 = 1421116878;
					}
					num = num4 ^ (int)(num2 * 763888298);
					continue;
				}
				case 12u:
					num = (int)((num2 * 741994826) ^ 0x4F9848C2);
					continue;
				case 11u:
					num = ((int)num2 * -1117701795) ^ -1010051963;
					continue;
				case 10u:
					num = ((int)num2 * -1934873025) ^ -1906840345;
					continue;
				case 9u:
					TrafficPlan.trafficList[idCar].iAmHere = WhereIsNow.Bitwy_North_Entry_1;
					num = ((int)num2 * -842344865) ^ 0x5C266941;
					continue;
				case 8u:
					num = (int)(num2 * 1171088413) ^ -208547116;
					continue;
				case 7u:
					num = (int)(num2 * 574352867) ^ -1936543829;
					continue;
				case 6u:
					num = (int)(num2 * 1313840455) ^ -1355624028;
					continue;
				case 5u:
					TrafficPlan.trafficList[idCar].iAmHere = WhereIsNow.Aleje_East_Right_Bitwy;
					num = ((int)num2 * -21098403) ^ -1241050034;
					continue;
				case 4u:
					flag = 2 == num3;
					num = 1846945663;
					continue;
				case 3u:
					result = Points.Bitwy_South_Entry_1;
					num = ((int)num2 * -1486101590) ^ 0x5739835;
					continue;
				case 2u:
					TrafficPlan.trafficList[idCar].iAmHere = WhereIsNow.Bitwy_North_Entry_Left_Rondo;
					result = Points.Bitwy_North_Entry_Left_Rondo;
					num = (int)((num2 * 225845042) ^ 0xB0B7B73);
					continue;
				case 1u:
					random_ = Simulation.smethod_8();
					num = ((int)num2 * -772955380) ^ -926516755;
					continue;
				case 24u:
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
		bool flag = default(bool);
		while (true)
		{
			int num = -1554361683;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDF78C425u) % 7u)
				{
				case 5u:
					Simulation.smethod_7(stopCar_entryInRoad);
					num = -1862188783;
					continue;
				case 4u:
					num = ((int)num2 * -1976547137) ^ 0x2A417CD3;
					continue;
				case 3u:
					flag = !TrafficPlan.CanEntryInRoad(car.id, TrafficPlan.trafficList[car.id].iAmHere);
					num = -1684065989;
					continue;
				case 1u:
					num = (int)(num2 * 1004872958) ^ -583759309;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 725553982;
						num4 = 725553982;
					}
					else
					{
						num3 = 1415662625;
						num4 = 1415662625;
					}
					num = num3 ^ (int)(num2 * 308895188);
					continue;
				}
				default:
					return;
				case 6u:
					break;
				case 2u:
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
		_003C_003Ec__DisplayClass21_1 _003C_003Ec__DisplayClass21_2 = default(_003C_003Ec__DisplayClass21_1);
		int num5 = default(int);
		while (true)
		{
			int num = -604538113;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA9067474u) % 3u)
				{
				case 1u:
					goto IL_000f;
				case 0u:
					break;
				default:
				{
					List<Point>.Enumerator enumerator = list.GetEnumerator();
					try
					{
						while (true)
						{
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = -243656097;
								num4 = -243656097;
							}
							else
							{
								num3 = -1221943199;
								num4 = -1221943199;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xA9067474u) % 17u)
								{
								case 16u:
								{
									int num6;
									if (TrafficPlan.CanMoveCar(_003C_003Ec__DisplayClass21_2.CS_0024_003C_003E8__locals1.car.id, TrafficPlan.trafficList[_003C_003Ec__DisplayClass21_2.CS_0024_003C_003E8__locals1.car.id].iAmHere))
									{
										num3 = -587069422;
										num6 = -587069422;
									}
									else
									{
										num3 = -1195202958;
										num6 = -1195202958;
									}
									continue;
								}
								case 15u:
									num3 = (int)((num2 * 838451053) ^ 0x4DC7EC96);
									continue;
								case 13u:
									num3 = ((int)num2 * -1440067438) ^ -2130835932;
									continue;
								case 12u:
									_003C_003Ec__DisplayClass21_2.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass21_;
									num3 = (int)((num2 * 289023531) ^ 0x47FA0922);
									continue;
								case 11u:
									num3 = -243656097;
									continue;
								case 10u:
									_003C_003Ec__DisplayClass21_2.item = enumerator.Current;
									num3 = (int)(num2 * 594552025) ^ -2137247627;
									continue;
								case 9u:
									Simulation.smethod_7(stopCar_nextPoint);
									num3 = (int)(num2 * 1389743808) ^ -1582187873;
									continue;
								case 8u:
									_003C_003Ec__DisplayClass21_2 = new _003C_003Ec__DisplayClass21_1();
									num3 = -2000725663;
									continue;
								case 7u:
									num3 = ((int)num2 * -1036636864) ^ -2085103113;
									continue;
								case 6u:
									Simulation.smethod_7(speedCar);
									num3 = ((int)num2 * -1461639616) ^ 0x3F3A3756;
									continue;
								case 5u:
									num3 = ((int)num2 * -729045834) ^ 0x3CAC1981;
									continue;
								case 4u:
									num3 = -47806523;
									continue;
								case 3u:
									TrafficPlan.trafficList[_003C_003Ec__DisplayClass21_2.CS_0024_003C_003E8__locals1.car.id].countMove = num5;
									num3 = ((int)num2 * -1236324919) ^ -443948627;
									continue;
								case 2u:
									num3 = ((int)num2 * -1550058632) ^ 0x7D7CEC78;
									continue;
								case 0u:
									Simulation.smethod_6(Simulation.smethod_5((DispatcherObject)(object)this), (DispatcherPriority)4, (Delegate)new Action(_003C_003Ec__DisplayClass21_2._003CmoveCar_003Eb__0));
									Simulation.smethod_6(Simulation.smethod_5((DispatcherObject)(object)this), (DispatcherPriority)4, (Delegate)new Action(_003C_003Ec__DisplayClass21_2._003CmoveCar_003Eb__1));
									num5++;
									num3 = ((int)num2 * -1517000634) ^ 0x3DA760E;
									continue;
								default:
									return;
								case 14u:
									break;
								case 1u:
									return;
								}
								break;
							}
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						while (true)
						{
							IL_02d1:
							int num7 = -1215125975;
							while (true)
							{
								switch ((num2 = (uint)num7 ^ 0xA9067474u) % 3u)
								{
								case 1u:
									goto IL_02a5;
								default:
									goto end_IL_02b3;
								case 0u:
									break;
								case 2u:
									goto end_IL_02b3;
								}
								goto IL_02d1;
								IL_02a5:
								num7 = (int)((num2 * 964227441) ^ 0x27FD9238);
								continue;
								end_IL_02b3:
								break;
							}
							break;
						}
					}
				}
				}
				break;
				IL_000f:
				num5 = 0;
				num = (int)((num2 * 149409316) ^ 0x66233B3F);
			}
		}
	}

	private void canExitCheckpoint(Car car)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = 200262225;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x26FF41D3u) % 9u)
				{
				case 8u:
					num = ((int)num2 * -525370481) ^ 0x4B799C0C;
					continue;
				case 6u:
					num = ((int)num2 * -1681457947) ^ 0x1328424F;
					continue;
				case 5u:
					flag = !TrafficPlan.CanEntryInTheCheckPoint(car.id, this);
					num = 882170217;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 636043415;
						num4 = 636043415;
					}
					else
					{
						num3 = 1739831170;
						num4 = 1739831170;
					}
					num = num3 ^ ((int)num2 * -1429267893);
					continue;
				}
				case 3u:
					Simulation.smethod_7(stopCar_ExitCheckPoint);
					num = ((int)num2 * -1677826839) ^ -283570628;
					continue;
				case 2u:
					num = 1780495886;
					continue;
				case 1u:
					num = ((int)num2 * -1556471956) ^ -1574295398;
					continue;
				default:
					return;
				case 0u:
					break;
				case 7u:
					return;
				}
				break;
			}
		}
	}

	private void driveByViaduct(Car car, int how_long)
	{
		while (true)
		{
			int num = 123567474;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x76CE1EB3u) % 5u)
				{
				case 4u:
					Simulation.smethod_6(Simulation.smethod_5((DispatcherObject)(object)this), (DispatcherPriority)4, (Delegate)(Action)delegate
					{
						_003C_003Ec__DisplayClass23_0.smethod_0((UIElement)(object)car.picture, -30.0);
					});
					Simulation.smethod_6(Simulation.smethod_5((DispatcherObject)(object)this), (DispatcherPriority)4, (Delegate)(Action)delegate
					{
						_003C_003Ec__DisplayClass23_0.smethod_1((UIElement)(object)car.picture, -30.0);
					});
					num = ((int)num2 * -743466814) ^ -1762349379;
					continue;
				case 2u:
					num = (int)((num2 * 605618005) ^ 0x725DAD4A);
					continue;
				case 0u:
					Simulation.smethod_7(how_long);
					num = (int)((num2 * 1720845153) ^ 0x151E8DE3);
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

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		Uri uri_ = default(Uri);
		while (true)
		{
			int num = -1811723376;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC1402798u) % 7u)
				{
				case 5u:
					num = (int)(num2 * 508294251) ^ -1923053754;
					continue;
				case 4u:
					uri_ = Simulation.smethod_16("/tusP;component/simulation.xaml", UriKind.Relative);
					num = (int)((num2 * 439037787) ^ 0x1C5282C4);
					continue;
				case 3u:
					_contentLoaded = true;
					num = -1179548690;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (_contentLoaded)
					{
						num3 = 2068368126;
						num4 = 2068368126;
					}
					else
					{
						num3 = 59879101;
						num4 = 59879101;
					}
					num = num3 ^ ((int)num2 * -84161985);
					continue;
				}
				case 0u:
					Simulation.smethod_17((object)this, uri_);
					num = (int)((num2 * 849789078) ^ 0x1C4E54B8);
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

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected O, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected O, but got Unknown
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected O, but got Unknown
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected O, but got Unknown
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected O, but got Unknown
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected O, but got Unknown
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected O, but got Unknown
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected O, but got Unknown
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected O, but got Unknown
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected O, but got Unknown
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected O, but got Unknown
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected O, but got Unknown
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected O, but got Unknown
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Expected O, but got Unknown
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Expected O, but got Unknown
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Expected O, but got Unknown
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected O, but got Unknown
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Expected O, but got Unknown
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Expected O, but got Unknown
		int num4 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = 1168791172;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6ABC3AFAu) % 52u)
				{
				case 51u:
					light7 = (Ellipse)target;
					num = 1624163215;
					continue;
				case 50u:
					goto IL_001c;
				case 49u:
					goto IL_0032;
				case 48u:
					num = (int)(num2 * 741514334) ^ -1749371947;
					continue;
				case 47u:
					num = (int)((num2 * 1965520438) ^ 0x424E080F);
					continue;
				case 46u:
					num = (int)((num2 * 530353031) ^ 0x1FAC77FB);
					continue;
				case 45u:
					num = ((int)num2 * -1645513469) ^ 0x27603EE2;
					continue;
				case 44u:
					goto IL_0090;
				case 43u:
					_contentLoaded = true;
					num = 1302485949;
					continue;
				case 42u:
					goto IL_00b7;
				case 41u:
					goto IL_00cd;
				case 40u:
					num = ((int)num2 * -1215928528) ^ -807337475;
					continue;
				case 39u:
					goto IL_00f5;
				case 38u:
					goto IL_010b;
				case 37u:
					goto IL_0121;
				case 36u:
					goto IL_0137;
				case 35u:
					num = ((int)num2 * -1327225660) ^ 0xC3037D1;
					continue;
				case 34u:
					switch (num4)
					{
					case 9:
						break;
					case 14:
						goto IL_001c;
					case 12:
						goto IL_0032;
					case 15:
						goto IL_0090;
					case 27:
						goto IL_00b7;
					case 22:
						goto IL_00cd;
					case 3:
						goto IL_00f5;
					case 11:
						goto IL_010b;
					case 24:
						goto IL_0121;
					case 10:
						goto IL_0137;
					default:
						goto IL_01d3;
					case 1:
						goto IL_01e5;
					case 2:
						goto IL_0206;
					case 4:
						goto IL_021c;
					case 5:
						goto IL_0232;
					case 6:
						goto IL_0248;
					case 7:
						goto IL_025e;
					case 8:
						goto IL_0274;
					case 13:
						goto IL_028a;
					case 16:
						goto IL_02a0;
					case 17:
						goto IL_02b6;
					case 18:
						goto IL_02cc;
					case 19:
						goto IL_02e2;
					case 20:
						goto IL_02f8;
					case 21:
						goto IL_030e;
					case 23:
						goto IL_0324;
					case 25:
						goto IL_033a;
					case 26:
						goto IL_0350;
					}
					goto case 51u;
				case 0u:
					goto IL_01e5;
				case 20u:
					goto IL_0206;
				case 25u:
					goto IL_021c;
				case 18u:
					goto IL_0232;
				case 5u:
					goto IL_0248;
				case 14u:
					goto IL_025e;
				case 1u:
					goto IL_0274;
				case 23u:
					goto IL_028a;
				case 26u:
					goto IL_02a0;
				case 15u:
					goto IL_02b6;
				case 22u:
					goto IL_02cc;
				case 17u:
					goto IL_02e2;
				case 30u:
					goto IL_02f8;
				case 9u:
					goto IL_030e;
				case 24u:
					goto IL_0324;
				case 19u:
					goto IL_033a;
				case 16u:
					goto IL_0350;
				case 33u:
					num = (int)(num2 * 1917775745) ^ -722422344;
					continue;
				case 32u:
					num = ((int)num2 * -804452922) ^ -951428331;
					continue;
				case 31u:
					num = (int)((num2 * 2092915831) ^ 0x55918FCC);
					continue;
				case 29u:
					num = (int)((num2 * 855371009) ^ 0xD380550);
					continue;
				case 28u:
					num = (int)((num2 * 1627661312) ^ 0x7012BBBD);
					continue;
				case 27u:
					num = (int)((num2 * 1304249916) ^ 0x110D9EA9);
					continue;
				case 21u:
					num = (int)(num2 * 59932194) ^ -419434497;
					continue;
				case 13u:
					num = ((int)num2 * -1255556712) ^ 0x7C37C9A5;
					continue;
				case 11u:
					num = ((int)num2 * -33160261) ^ 0x34B67AA4;
					continue;
				case 10u:
					num = (int)(num2 * 2120055485) ^ -1267057029;
					continue;
				case 8u:
					num = ((int)num2 * -922680601) ^ 0x158849E5;
					continue;
				case 6u:
					num = (int)((num2 * 1415241327) ^ 0x1866DE53);
					continue;
				case 4u:
					num = ((int)num2 * -1539001149) ^ -1431113127;
					continue;
				case 3u:
					num4 = num3;
					num = (int)(num2 * 748196634) ^ -103694118;
					continue;
				case 2u:
					num3 = connectionId;
					num = ((int)num2 * -1115035607) ^ -1953651173;
					continue;
				default:
					return;
				case 12u:
					break;
				case 7u:
					return;
					IL_0350:
					light24 = (Ellipse)target;
					num = 1814870655;
					continue;
					IL_033a:
					light23 = (Ellipse)target;
					num = 1302485949;
					continue;
					IL_0324:
					light21 = (Ellipse)target;
					num = 949001270;
					continue;
					IL_030e:
					light19 = (Ellipse)target;
					num = 1470039825;
					continue;
					IL_02f8:
					light18 = (Ellipse)target;
					num = 1136026187;
					continue;
					IL_02e2:
					light17 = (Ellipse)target;
					num = 1779133686;
					continue;
					IL_02cc:
					light16 = (Ellipse)target;
					num = 48042086;
					continue;
					IL_02b6:
					light15 = (Ellipse)target;
					num = 2039951595;
					continue;
					IL_02a0:
					light14 = (Ellipse)target;
					num = 826620598;
					continue;
					IL_028a:
					light11 = (Ellipse)target;
					num = 1302485949;
					continue;
					IL_0274:
					light6 = (Ellipse)target;
					num = 2113062337;
					continue;
					IL_025e:
					light5 = (Ellipse)target;
					num = 1302485949;
					continue;
					IL_0248:
					light4 = (Ellipse)target;
					num = 1770882544;
					continue;
					IL_0232:
					light3 = (Ellipse)target;
					num = 711844525;
					continue;
					IL_021c:
					light2 = (Ellipse)target;
					num = 1302485949;
					continue;
					IL_0206:
					SomeWhere = (Canvas)target;
					num = 1302485949;
					continue;
					IL_01e5:
					Simulation.smethod_18((FrameworkElement)(object)(Simulation)target, new RoutedEventHandler(Window_Loaded));
					num = 1302485949;
					continue;
					IL_01d3:
					num = ((int)num2 * -379767214) ^ 0xAF4895;
					continue;
					IL_0137:
					light8 = (Ellipse)target;
					num = 165311752;
					continue;
					IL_0121:
					light22 = (Ellipse)target;
					num = 1302485949;
					continue;
					IL_010b:
					light9 = (Ellipse)target;
					num = 9166098;
					continue;
					IL_00f5:
					light1 = (Ellipse)target;
					num = 1302485949;
					continue;
					IL_00cd:
					light20 = (Ellipse)target;
					num = 1302485949;
					continue;
					IL_00b7:
					light25 = (Ellipse)target;
					num = 389205783;
					continue;
					IL_0090:
					light13 = (Ellipse)target;
					num = 1424575106;
					continue;
					IL_0032:
					light10 = (Ellipse)target;
					num = 910233825;
					continue;
					IL_001c:
					light12 = (Ellipse)target;
					num = 399779524;
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
