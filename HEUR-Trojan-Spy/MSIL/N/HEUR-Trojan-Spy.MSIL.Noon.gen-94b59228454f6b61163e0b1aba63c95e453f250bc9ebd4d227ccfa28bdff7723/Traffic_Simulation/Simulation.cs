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
		InitializeComponent();
		numberOfCars = countCar;
		Thread thread_ = Simulation.smethod_1((ThreadStart)endSimulation);
		Simulation.smethod_2(thread_, bool_0: true);
		Simulation.smethod_3(thread_);
	}

	private void endSimulation()
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		bool flag = default(bool);
		while (true)
		{
			int num = 1303687261;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x75E3C16Eu) % 11u)
				{
				case 10u:
					Simulation.smethod_6(Simulation.smethod_5((DispatcherObject)(object)this), (DispatcherPriority)4, (Delegate)(Action)delegate
					{
						Simulation.smethod_19((Window)(object)this);
					});
					num = ((int)num2 * -1760503099) ^ -736023964;
					continue;
				case 9u:
					num = (int)(num2 * 1983738222) ^ -1957647466;
					continue;
				case 8u:
					num = ((int)num2 * -1752147715) ^ 0xC9654A4;
					continue;
				case 7u:
					Simulation.smethod_7(2000);
					num = 451289157;
					continue;
				case 5u:
					num = ((int)num2 * -1764019128) ^ -1043930788;
					continue;
				case 4u:
					Simulation.smethod_4("Simulation has been done!");
					num = ((int)num2 * -863662804) ^ -1544000481;
					continue;
				default:
					flag = done == numberOfCars;
					num = 1975980534;
					continue;
				case 1u:
					num = ((int)num2 * -1300014728) ^ 0x7F09DA04;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1002757501;
						num4 = 1002757501;
					}
					else
					{
						num3 = 906997508;
						num4 = 906997508;
					}
					num = num3 ^ ((int)num2 * -1534656904);
					continue;
				}
				case 6u:
					break;
				}
				break;
			}
		}
	}

	private void Window_Loaded(object sender, RoutedEventArgs e)
	{
		while (true)
		{
			int num = -1175368994;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE3021D7Eu) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 2u:
					break;
				default:
					startThread();
					return;
				}
				break;
				IL_0003:
				Points.LoadTrace();
				createCar();
				lights.StartLight(this);
				num = (int)((num2 * 2066027780) ^ 0x73153776);
			}
		}
	}

	private void createCar()
	{
		int num3 = default(int);
		int num4 = default(int);
		Random random_ = default(Random);
		while (true)
		{
			int num = -593550586;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xED5A0C37u) % 28u)
				{
				case 27u:
					listCar.Add(new Car(num3, "Picture/pic.png"));
					num = -898924521;
					continue;
				case 26u:
					num = ((int)num2 * -2114873860) ^ 0x2AB8BF6A;
					continue;
				case 25u:
				{
					int num8;
					if (3 == num4)
					{
						num = -2035513708;
						num8 = -2035513708;
					}
					else
					{
						num = -568356740;
						num8 = -568356740;
					}
					continue;
				}
				case 24u:
					num = (int)((num2 * 378350228) ^ 0x74ED86F9);
					continue;
				case 23u:
					listCar.Add(new Car(num3, "Picture/pikachu.png"));
					TrafficPlan.trafficList.Add(new CarInfo(num3));
					num = ((int)num2 * -916004818) ^ 0x4344D9F9;
					continue;
				case 22u:
					num = (int)(num2 * 177887438) ^ -441098707;
					continue;
				case 21u:
				{
					int num9;
					if (num3 < numberOfCars)
					{
						num = -1888906380;
						num9 = -1888906380;
					}
					else
					{
						num = -373743064;
						num9 = -373743064;
					}
					continue;
				}
				case 20u:
					TrafficPlan.trafficList.Add(new CarInfo(num3));
					num = ((int)num2 * -874937349) ^ -648151801;
					continue;
				case 19u:
					listCar.Add(new Car(num3, "Picture/star.png"));
					num = ((int)num2 * -1004231707) ^ 0x3D27B2F4;
					continue;
				case 18u:
					num3++;
					num = (int)((num2 * 970312366) ^ 0x4C6C7FD6);
					continue;
				case 17u:
					num = (int)(num2 * 1039321251) ^ -119259402;
					continue;
				case 16u:
					num = (int)(num2 * 1353573286) ^ -800901038;
					continue;
				case 14u:
					num = -1672803303;
					continue;
				case 13u:
					num4 = Simulation.smethod_9(random_, 1, 5);
					num = ((int)num2 * -2038279332) ^ -1089230018;
					continue;
				case 11u:
				{
					int num7;
					if (2 != num4)
					{
						num = -1147272382;
						num7 = -1147272382;
					}
					else
					{
						num = -1852625756;
						num7 = -1852625756;
					}
					continue;
				}
				case 10u:
					num = ((int)num2 * -470528618) ^ 0x4778CD2D;
					continue;
				case 9u:
					num3 = 0;
					num = (int)(num2 * 1539383808) ^ -1296462283;
					continue;
				case 8u:
					num = (int)(num2 * 1166982435) ^ -685250115;
					continue;
				case 7u:
					num = -1550084062;
					continue;
				case 6u:
					listCar.Add(new Car(num3, "Picture/mario.png"));
					num = ((int)num2 * -1320614296) ^ -554425681;
					continue;
				case 5u:
				{
					int num5;
					int num6;
					if (1 == num4)
					{
						num5 = 1164092404;
						num6 = 1164092404;
					}
					else
					{
						num5 = 1684209395;
						num6 = 1684209395;
					}
					num = num5 ^ (int)(num2 * 537504151);
					continue;
				}
				case 4u:
					TrafficPlan.trafficList.Add(new CarInfo(num3));
					num = (int)((num2 * 947390219) ^ 0x1574511D);
					continue;
				case 3u:
					num = ((int)num2 * -802649519) ^ -878859353;
					continue;
				case 2u:
					TrafficPlan.trafficList.Add(new CarInfo(num3));
					num = ((int)num2 * -577049594) ^ -757590515;
					continue;
				case 1u:
					random_ = Simulation.smethod_8();
					num = ((int)num2 * -1830502107) ^ 0x20DE79A3;
					continue;
				case 0u:
					num = ((int)num2 * -872366699) ^ 0x5BC58A25;
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

	private void startThread()
	{
		Thread thread_ = default(Thread);
		int num3 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 1356618852;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4E932199u) % 12u)
				{
				case 10u:
					Simulation.smethod_2(thread_, bool_0: true);
					Simulation.smethod_11(thread_, num3.ToString());
					num = (int)(num2 * 1397165691) ^ -1905896797;
					continue;
				case 9u:
					num3++;
					num = ((int)num2 * -1568749483) ^ 0x4C8EE91C;
					continue;
				case 8u:
					Simulation.smethod_12(thread_, (object)num3);
					num = (int)((num2 * 1109208030) ^ 0x11143512);
					continue;
				case 7u:
					num = (int)(num2 * 1921548060) ^ -765845447;
					continue;
				case 6u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 202708441;
						num5 = 202708441;
					}
					else
					{
						num4 = 1238738016;
						num5 = 1238738016;
					}
					num = num4 ^ ((int)num2 * -201138829);
					continue;
				}
				case 5u:
					num = (int)(num2 * 1771979104) ^ -2016229335;
					continue;
				case 4u:
					num = (int)((num2 * 989925488) ^ 0x55F2B1D8);
					continue;
				case 2u:
					thread_ = Simulation.smethod_10((ParameterizedThreadStart)animate);
					num = 299133035;
					continue;
				case 1u:
					num3 = 0;
					num = ((int)num2 * -1650895917) ^ 0x31F34173;
					continue;
				case 0u:
					flag = num3 < numberOfCars;
					num = 1265536123;
					continue;
				default:
					return;
				case 3u:
					break;
				case 11u:
					return;
				}
				break;
			}
		}
	}

	private void animate(object idCar)
	{
		Car car = default(Car);
		List<Point> list = default(List<Point>);
		WhereIsNow whereIsNow = default(WhereIsNow);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		Simulation simulation = default(Simulation);
		int num5 = default(int);
		bool flag = default(bool);
		Random random_ = default(Random);
		object object_ = default(object);
		WhereIsNow iAmHere = default(WhereIsNow);
		bool flag4 = default(bool);
		while (true)
		{
			int num = 1824663915;
			while (true)
			{
				int num10;
				int num13;
				int num14;
				int num15;
				int num16;
				uint num2;
				switch ((num2 = (uint)num ^ 0x1BD083AAu) % 175u)
				{
				case 0u:
				case 14u:
				case 15u:
				case 33u:
				case 35u:
				case 49u:
				case 50u:
				case 51u:
				case 52u:
				case 68u:
				case 70u:
				case 73u:
				case 84u:
				case 106u:
				case 109u:
				case 113u:
				case 116u:
				case 121u:
				case 124u:
				case 138u:
				case 152u:
				case 156u:
				case 166u:
				case 167u:
				case 168u:
				case 174u:
					goto IL_010b;
				case 146u:
					goto IL_0135;
				case 173u:
					num = (int)(num2 * 1215405131) ^ -226748758;
					continue;
				case 172u:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Aleje_West_Exit_1;
					num = (int)(num2 * 1028566268) ^ -1894557693;
					continue;
				case 171u:
					goto IL_019c;
				case 170u:
					goto IL_01ae;
				case 169u:
					num = (int)((num2 * 885649569) ^ 0x4D045C12);
					continue;
				case 165u:
					goto IL_01da;
				case 164u:
					num = ((int)num2 * -673371070) ^ -18586456;
					continue;
				case 163u:
					goto IL_0218;
				case 162u:
					list = Points.Rondo_1_East_Entry_Rondo_2;
					num = ((int)num2 * -244548305) ^ 0x2FC548E4;
					continue;
				case 161u:
					num = (int)((num2 * 1009819854) ^ 0xE202536);
					continue;
				case 160u:
					goto IL_026a;
				case 159u:
					goto IL_0290;
				case 158u:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Bitwy_North_Entry_2;
					num = ((int)num2 * -2112944229) ^ 0x2C5C41F5;
					continue;
				case 157u:
					list = null;
					goto IL_010b;
				case 155u:
					num = ((int)num2 * -1814269309) ^ 0x1ABE68A9;
					continue;
				case 154u:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_East_Inside;
					num = 1116169376;
					continue;
				case 153u:
					list = Points.Rondo_1_South_Inside_Rondo_2_Inside;
					num = (int)(num2 * 1516109511) ^ -327173864;
					continue;
				case 151u:
					num = (int)((num2 * 1405047125) ^ 0x4A84FB7F);
					continue;
				case 150u:
					goto IL_0351;
				case 149u:
					list = Points.Aleje_West_Entry_2;
					num = (int)((num2 * 1813534392) ^ 0xB751B1A);
					continue;
				case 148u:
					num = (int)(num2 * 112005964) ^ -1615975215;
					continue;
				case 147u:
					list = Points.Rondo_1_West_Entry_Rondo_2;
					num = ((int)num2 * -1568317502) ^ -562582821;
					continue;
				case 145u:
					list = Points.Rondo_East_Inside;
					num = ((int)num2 * -1890117825) ^ -638626909;
					continue;
				case 144u:
					goto IL_03d5;
				case 143u:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_2_East_Exit;
					num = ((int)num2 * -1382516618) ^ -1169338280;
					continue;
				case 142u:
					list = Points.Rondo_2_East_Exit;
					num = (int)((num2 * 567765703) ^ 0x652710FC);
					continue;
				case 141u:
					num = ((int)num2 * -220741406) ^ -393076941;
					continue;
				case 140u:
					num = (int)((num2 * 1855208727) ^ 0x4C586F57);
					continue;
				case 139u:
					goto IL_0469;
				case 137u:
					goto IL_048f;
				case 136u:
					list = Points.Bitwy_North_Left_Exit;
					num = ((int)num2 * -721301461) ^ -1670145954;
					continue;
				case 135u:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_East_Inside;
					num = ((int)num2 * -509359128) ^ 0x4A5D649D;
					continue;
				case 134u:
					list = Points.Aleje_East_Exit_1;
					goto IL_010b;
				case 133u:
					list = Points.Rondo_2_East_Exit;
					num = (int)((num2 * 1333896894) ^ 0x36F8ACFA);
					continue;
				case 132u:
					num = (int)(num2 * 943723435) ^ -78901656;
					continue;
				case 131u:
					driveByViaduct(car, timeDriveByTunnel);
					num = (int)(num2 * 1721435741) ^ -2091790638;
					continue;
				case 130u:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Aleje_West_Entry_Bitwy;
					list = Points.Aleje_West_Entry_Bitwy;
					num = (int)(num2 * 1679249917) ^ -734649402;
					continue;
				case 129u:
					list = Points.Rondo_2_West_Exit;
					driveByViaduct(car, timeDriveUnderViaductWest);
					num = ((int)num2 * -1085676588) ^ -842978717;
					continue;
				case 128u:
					list = Points.Rondo_3_North_Exit;
					goto IL_010b;
				case 127u:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Bitwy_South_Right_Aleje;
					list = Points.Bitwy_South_Right_Aleje;
					num = (int)((num2 * 507224955) ^ 0x433D2A8E);
					continue;
				case 126u:
					list = Points.Bitwy_South_Exit_1;
					num = ((int)num2 * -1582658997) ^ -2142955324;
					continue;
				case 125u:
					num = 969159953;
					continue;
				case 123u:
					num = 545253735;
					continue;
				case 122u:
					goto IL_0625;
				case 120u:
					num = (int)(num2 * 370054687) ^ -1823703889;
					continue;
				case 119u:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_2_East_Exit;
					num = ((int)num2 * -2143524188) ^ -875709152;
					continue;
				case 118u:
					list = Points.Rondo_3_Inside_Left_exit;
					goto IL_010b;
				case 117u:
					list = Points.Bitwy_North_Exit_2;
					num = (int)((num2 * 1377293315) ^ 0x3AB0BD95);
					continue;
				case 115u:
					switch (whereIsNow)
					{
					case WhereIsNow.Done:
						break;
					case WhereIsNow.Beginning:
						goto IL_019c;
					case WhereIsNow.Rondo_3_North_Exit:
						goto IL_01ae;
					case WhereIsNow.Bitwy_South_Entry_1:
						goto IL_01da;
					case WhereIsNow.Bitwy_South_Exit_2:
						goto IL_0218;
					case WhereIsNow.Rondo_2_North_Entry_Rondo_3:
						goto IL_026a;
					case WhereIsNow.Rondo_2_Inside_Left_Entry_Rondo_3:
						goto IL_0290;
					case WhereIsNow.Rondo_1_North_Entry_Rondo_2:
						goto IL_0351;
					case WhereIsNow.Rondo_1_West_Entry_Rondo_2:
						goto IL_03d5;
					case WhereIsNow.Bitwy_North_Left_Exit:
						goto IL_0469;
					case WhereIsNow.Bitwy_South_Entry_2:
						goto IL_048f;
					case WhereIsNow.Aleje_West_Entry_2:
						goto IL_0625;
					default:
						goto IL_075a;
					case WhereIsNow.Aleje_East_Entry_Rondo:
						goto IL_076d;
					case WhereIsNow.Aleje_East_Exit_1:
						goto IL_0793;
					case WhereIsNow.Aleje_East_Exit_2:
						goto IL_07b8;
					case WhereIsNow.Aleje_East_Right_Bitwy:
						goto IL_07de;
					case WhereIsNow.Aleje_Entry_Left_Bitwy:
						goto IL_0804;
					case WhereIsNow.Aleje_West_Entry_1:
						goto IL_082a;
					case WhereIsNow.Aleje_West_Entry_Bitwy:
						goto IL_0843;
					case WhereIsNow.Aleje_West_Exit_1:
						goto IL_0869;
					case WhereIsNow.Aleje_West_Exit_2:
						goto IL_088f;
					case WhereIsNow.Bitwy_North_Entry_1:
						goto IL_08b5;
					case WhereIsNow.Bitwy_North_Entry_2:
						goto IL_08c8;
					case WhereIsNow.Bitwy_North_Entry_Left_Rondo:
						goto IL_08ee;
					case WhereIsNow.Bitwy_North_Exit_1:
						goto IL_0915;
					case WhereIsNow.Bitwy_North_Exit_2:
						goto IL_093b;
					case WhereIsNow.Bitwy_North_Right_Aleje:
						goto IL_0961;
					case WhereIsNow.Bitwy_South_Exit_1:
						goto IL_0987;
					case WhereIsNow.Bitwy_South_Right_Aleje:
						goto IL_09ad;
					case WhereIsNow.Rondo_1_East_Entry_Rondo_2:
						goto IL_09d2;
					case WhereIsNow.Rondo_1_Inside_Left_Entry_Rondo_2:
						goto IL_09fd;
					case WhereIsNow.Rondo_1_South_Entry_Rondo_2:
						goto IL_0a29;
					case WhereIsNow.Rondo_1_South_Inside_Rondo_2_Inside:
						goto IL_0a54;
					case WhereIsNow.Rondo_2_East_Exit:
						goto IL_0a7a;
					case WhereIsNow.Rondo_2_South_Exit:
						goto IL_0aa0;
					case WhereIsNow.Rondo_2_South_Inside_Exit:
						goto IL_0ac5;
					case WhereIsNow.Rondo_2_West_Exit:
						goto IL_0af0;
					case WhereIsNow.Rondo_3_Inside_Left_exit:
						goto IL_0b16;
					case WhereIsNow.Rondo_East_Inside:
						goto IL_0b3b;
					}
					goto IL_000b;
				case 55u:
					goto IL_076d;
				case 34u:
					goto IL_0793;
				case 79u:
					goto IL_07b8;
				case 22u:
					goto IL_07de;
				case 114u:
					goto IL_0804;
				case 8u:
					goto IL_082a;
				case 99u:
					goto IL_0843;
				case 86u:
					goto IL_0869;
				case 20u:
					goto IL_088f;
				case 4u:
					goto IL_08b5;
				case 94u:
					goto IL_08c8;
				case 53u:
					goto IL_08ee;
				case 12u:
					goto IL_0915;
				case 62u:
					goto IL_093b;
				case 44u:
					goto IL_0961;
				case 97u:
					goto IL_0987;
				case 69u:
					goto IL_09ad;
				case 29u:
					goto IL_09d2;
				case 81u:
					goto IL_09fd;
				case 89u:
					goto IL_0a29;
				case 98u:
					goto IL_0a54;
				case 74u:
					goto IL_0a7a;
				case 26u:
					goto IL_0aa0;
				case 105u:
					goto IL_0ac5;
				case 6u:
					goto IL_0af0;
				case 83u:
					goto IL_0b16;
				case 27u:
					goto IL_0b3b;
				case 112u:
					car = listCar[(int)idCar];
					num = ((int)num2 * -585001429) ^ 0x4FF8B053;
					continue;
				case 111u:
					list = Points.Rondo_2_North_Entry_Rondo_3;
					num = (int)(num2 * 296128553) ^ -1451091275;
					continue;
				case 110u:
					list = Points.Bitwy_North_Right_Aleje;
					num = (int)(num2 * 74900653) ^ -1841784682;
					continue;
				case 108u:
					list = Points.Aleje_West_Exit_2;
					goto IL_010b;
				case 107u:
					num = 2050966558;
					continue;
				case 104u:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_1_West_Entry_Rondo_2;
					num = 58550801;
					continue;
				case 103u:
					driveByViaduct(car, timeDriveUnderViaductInsideRondoEast);
					goto IL_010b;
				case 102u:
					list = null;
					num = (int)((num2 * 2141967826) ^ 0x26485F1F);
					continue;
				case 101u:
					num = ((int)num2 * -1416488818) ^ -649382876;
					continue;
				case 100u:
					list = Points.Bitwy_South_Exit_2;
					num = ((int)num2 * -1869997308) ^ 0x5A8883E9;
					continue;
				case 96u:
					num = ((int)num2 * -1964044400) ^ -2125912094;
					continue;
				case 95u:
				{
					int num11;
					int num12;
					if (!flag2)
					{
						num11 = -1738971046;
						num12 = -1738971046;
					}
					else
					{
						num11 = -1196957654;
						num12 = -1196957654;
					}
					num = num11 ^ ((int)num2 * -1205339615);
					continue;
				}
				case 93u:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Bitwy_South_Entry_2;
					num = (int)(num2 * 605863012) ^ -358206132;
					continue;
				case 92u:
				{
					int num8;
					int num9;
					if (flag3)
					{
						num8 = 1587343016;
						num9 = 1587343016;
					}
					else
					{
						num8 = 45722025;
						num9 = 45722025;
					}
					num = num8 ^ ((int)num2 * -567076325);
					continue;
				}
				case 91u:
					list = Points.Rondo_1_North_Entry_Rondo_2;
					num = (int)(num2 * 8856918) ^ -1743671872;
					continue;
				case 90u:
					simulation = this;
					num = ((int)num2 * -1281347320) ^ -756560623;
					continue;
				case 88u:
					num = (int)(num2 * 569991106) ^ -1772182958;
					continue;
				case 87u:
					num = ((int)num2 * -818411399) ^ -1316558373;
					continue;
				case 85u:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Bitwy_North_Right_Aleje;
					num = (int)((num2 * 1684090618) ^ 0x9681CBA);
					continue;
				case 82u:
					list = Points.Aleje_East_Exit_2;
					num = ((int)num2 * -1737998819) ^ -1365426480;
					continue;
				case 80u:
					flag2 = num5 == 1;
					num = ((int)num2 * -759069522) ^ -1001908079;
					continue;
				case 78u:
					Simulation.smethod_6(Simulation.smethod_5((DispatcherObject)(object)this), (DispatcherPriority)4, (Delegate)(Action)delegate
					{
						_003C_003Ec__DisplayClass18_0.smethod_3((UIElement)(object)car.picture, -30.0);
						while (true)
						{
							int num19 = -1013702821;
							while (true)
							{
								uint num20;
								switch ((num20 = (uint)num19 ^ 0xD3AABE0Fu) % 3u)
								{
								case 2u:
									goto IL_001b;
								default:
									return;
								case 0u:
									break;
								case 1u:
									return;
								}
								break;
								IL_001b:
								num19 = (int)(num20 * 438342158) ^ -1029128620;
							}
						}
					});
					goto IL_0135;
				case 77u:
					list = Points.Rondo_East_Inside;
					num = (int)((num2 * 179617283) ^ 0x6BFA5DC);
					continue;
				case 76u:
					num = ((int)num2 * -384951929) ^ -1162352517;
					continue;
				case 75u:
				{
					int num6;
					int num7;
					if (!flag)
					{
						num6 = -185384827;
						num7 = -185384827;
					}
					else
					{
						num6 = -276441132;
						num7 = -276441132;
					}
					num = num6 ^ (int)(num2 * 250544819);
					continue;
				}
				case 72u:
					list = null;
					num = ((int)num2 * -359687275) ^ -1664301358;
					continue;
				case 67u:
					num = (int)(num2 * 691846988) ^ -1635210740;
					continue;
				case 66u:
					list = Points.Aleje_West_Exit_2;
					num = (int)((num2 * 623313668) ^ 0x21593437);
					continue;
				case 65u:
					list = Points.Bitwy_North_Exit_1;
					num = (int)(num2 * 1342464673) ^ -1325326907;
					continue;
				case 64u:
					num = (int)((num2 * 76674852) ^ 0x23251486);
					continue;
				case 63u:
					list = Points.Bitwy_North_Exit_2;
					num = ((int)num2 * -836705392) ^ 0x5DF29AB0;
					continue;
				case 61u:
					num = ((int)num2 * -1937430310) ^ -722355443;
					continue;
				case 60u:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_2_South_Exit;
					list = Points.Rondo_2_South_Exit;
					num = ((int)num2 * -186455543) ^ -96995995;
					continue;
				case 59u:
					num = ((int)num2 * -1008223084) ^ -1395043874;
					continue;
				case 58u:
					list = Points.Aleje_East_Exit_1;
					goto IL_010b;
				case 57u:
					num = (int)(num2 * 1646725967) ^ -1674246259;
					continue;
				case 56u:
					num = ((int)num2 * -52083682) ^ 0x2223AFF0;
					continue;
				case 54u:
					num = 1425742636;
					continue;
				case 48u:
					list = Points.Aleje_East_Exit_2;
					num = (int)(num2 * 747406394) ^ -193126940;
					continue;
				case 47u:
					list = Points.Rondo_1_West_Entry_Rondo_2;
					num = (int)((num2 * 2038082984) ^ 0x640FC9DD);
					continue;
				case 46u:
					driveByViaduct(car, timeDriveUnderViaductInsideRondoEast);
					num = 257458991;
					continue;
				case 45u:
					num = (int)((num2 * 1002333429) ^ 0x48B77ADD);
					continue;
				case 43u:
					list = Points.Rondo_2_South_Inside_Exit;
					num = ((int)num2 * -1028407142) ^ 0x2600DD3;
					continue;
				case 42u:
					num = (int)(num2 * 330447675) ^ -2140309148;
					continue;
				case 41u:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Aleje_West_Entry_2;
					num = (int)((num2 * 48397178) ^ 0x5CFAE9DA);
					continue;
				case 40u:
					num = (int)((num2 * 291518458) ^ 0x47406D93);
					continue;
				case 39u:
					list = Points.Aleje_West_Exit_1;
					num = ((int)num2 * -1394901866) ^ -960086075;
					continue;
				case 38u:
					list = null;
					goto IL_010b;
				case 37u:
					list = Points.Bitwy_North_Entry_2;
					num = (int)((num2 * 311025293) ^ 0x1BC81520);
					continue;
				case 36u:
					random_ = Simulation.smethod_8();
					num = (int)((num2 * 109134846) ^ 0x253FF3E5);
					continue;
				case 32u:
					num = (int)(num2 * 157107522) ^ -1034603816;
					continue;
				case 31u:
					num5 = 0;
					num = (int)((num2 * 1183921304) ^ 0x3C21162A);
					continue;
				case 30u:
					num = (int)(num2 * 1141848762) ^ -683645436;
					continue;
				case 28u:
					list = null;
					goto IL_010b;
				case 25u:
					num = (int)(num2 * 1422934765) ^ -493373232;
					continue;
				case 24u:
					num = (int)(num2 * 2053937799) ^ -1779755459;
					continue;
				default:
				{
					bool bool_ = false;
					try
					{
						Simulation.smethod_13(object_, ref bool_);
						while (true)
						{
							IL_1161:
							int num3 = 1186836386;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x1BD083AAu) % 7u)
								{
								case 6u:
									num3 = (int)(num2 * 316526016) ^ -50313628;
									continue;
								case 5u:
									num3 = ((int)num2 * -1406045048) ^ -911146637;
									continue;
								case 3u:
									num3 = (int)(num2 * 1594554407) ^ -1232785765;
									continue;
								case 1u:
									num3 = ((int)num2 * -253484837) ^ -149235921;
									continue;
								case 0u:
									list = choiseStartTrace(car.id);
									canEntryToScene(car);
									num3 = (int)(num2 * 1989573185) ^ -1229111200;
									continue;
								default:
									goto end_IL_1133;
								case 2u:
									break;
								case 4u:
									goto end_IL_1133;
								}
								goto IL_1161;
								continue;
								end_IL_1133:
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
								IL_11ba:
								int num4 = 930197415;
								while (true)
								{
									switch ((num2 = (uint)num4 ^ 0x1BD083AAu) % 4u)
									{
									case 3u:
										num4 = (int)((num2 * 1728747384) ^ 0x6F91D4EA);
										continue;
									case 1u:
										Simulation.smethod_14(object_);
										num4 = (int)((num2 * 441972494) ^ 0x1687874F);
										continue;
									default:
										goto end_IL_1198;
									case 2u:
										break;
									case 0u:
										goto end_IL_1198;
									}
									goto IL_11ba;
									continue;
									end_IL_1198:
									break;
								}
								break;
							}
						}
					}
					goto IL_010b;
				}
				case 21u:
					num = 2006233249;
					continue;
				case 19u:
					Simulation.smethod_6(Simulation.smethod_5((DispatcherObject)(object)this), (DispatcherPriority)4, (Delegate)(Action)delegate
					{
						_003C_003Ec__DisplayClass18_0.smethod_1(_003C_003Ec__DisplayClass18_0.smethod_0((Panel)(object)simulation.SomeWhere), (UIElement)(object)car.picture);
					});
					Simulation.smethod_6(Simulation.smethod_5((DispatcherObject)(object)this), (DispatcherPriority)4, (Delegate)(Action)delegate
					{
						_003C_003Ec__DisplayClass18_0.smethod_2((UIElement)(object)car.picture, -30.0);
					});
					num = (int)((num2 * 64918117) ^ 0x50395381);
					continue;
				case 18u:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_1_South_Inside_Rondo_2_Inside;
					num = (int)((num2 * 1589182803) ^ 0x4F6E7AC5);
					continue;
				case 17u:
					list = Points.Bitwy_South_Entry_2;
					num = (int)((num2 * 667088242) ^ 0x2C00429E);
					continue;
				case 13u:
					num = (int)((num2 * 62400344) ^ 0x10637822);
					continue;
				case 11u:
					num = (int)(num2 * 1333612766) ^ -238113450;
					continue;
				case 10u:
					whereIsNow = iAmHere;
					num = ((int)num2 * -1468306896) ^ 0x224D6829;
					continue;
				case 9u:
					num = ((int)num2 * -9344826) ^ -1496264807;
					continue;
				case 7u:
					driveByViaduct(car, timeDriveUndeViaductInsideRondoNorth);
					num = (int)((num2 * 137697924) ^ 0x7D49DFF5);
					continue;
				case 5u:
					list = Points.Bitwy_South_Exit_2;
					num = (int)(num2 * 1263545078) ^ -905869393;
					continue;
				case 3u:
					num = (int)((num2 * 1157281880) ^ 0x557CC4F9);
					continue;
				case 2u:
					num = ((int)num2 * -363364415) ^ 0x7BCC1208;
					continue;
				case 1u:
					list = null;
					num = (int)((num2 * 799378208) ^ 0x58E70F2B);
					continue;
				case 16u:
					break;
				case 71u:
					goto IL_15ea;
					IL_0218:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Done;
					num = 1060705755;
					continue;
					IL_01da:
					num5 = Simulation.smethod_9(random_, 1, 3);
					if (num5 != 1)
					{
						num = 2014652423;
						num10 = 2014652423;
					}
					else
					{
						num = 2125115359;
						num10 = 2125115359;
					}
					continue;
					IL_0135:
					iAmHere = TrafficPlan.trafficList[car.id].iAmHere;
					num = 2059895474;
					continue;
					IL_01ae:
					num5 = Simulation.smethod_9(random_, 1, 3);
					flag = num5 == 1;
					num = 894742932;
					continue;
					IL_000b:
					Simulation.smethod_6(Simulation.smethod_5((DispatcherObject)(object)this), (DispatcherPriority)4, (Delegate)(Action)delegate
					{
						_003C_003Ec__DisplayClass18_0.smethod_4(_003C_003Ec__DisplayClass18_0.smethod_0((Panel)(object)simulation.SomeWhere), (UIElement)(object)car.picture);
					});
					done++;
					num13 = 2117844659;
					goto IL_00c9;
					IL_0b3b:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_2_North_Entry_Rondo_3;
					list = Points.Rondo_2_North_Entry_Rondo_3;
					goto IL_010b;
					IL_0b16:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Aleje_East_Exit_1;
					num = 751823059;
					continue;
					IL_0af0:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Bitwy_South_Exit_1;
					num = 1097947348;
					continue;
					IL_0ac5:
					num5 = Simulation.smethod_9(random_, 1, 3);
					if (num5 != 1)
					{
						num = 771885009;
						num14 = 771885009;
					}
					else
					{
						num = 1845483932;
						num14 = 1845483932;
					}
					continue;
					IL_019c:
					object_ = lock_object;
					num = 2077804653;
					continue;
					IL_0aa0:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Aleje_East_Exit_1;
					num = 1912031149;
					continue;
					IL_0a7a:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Bitwy_North_Exit_1;
					num = 127017322;
					continue;
					IL_0a54:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_2_South_Inside_Exit;
					num = 1371503417;
					continue;
					IL_0a29:
					num5 = Simulation.smethod_9(random_, 1, 3);
					if (1 != num5)
					{
						num = 883185032;
						num15 = 883185032;
					}
					else
					{
						num = 1757822783;
						num15 = 1757822783;
					}
					continue;
					IL_010b:
					flag4 = TrafficPlan.trafficList[car.id].iAmHere != WhereIsNow.Done;
					num13 = 811956634;
					goto IL_00c9;
					IL_09fd:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_2_Inside_Left_Entry_Rondo_3;
					list = Points.Rondo_2_Inside_Left_Entry_Rondo_3;
					num = 1745163027;
					continue;
					IL_09d2:
					num5 = Simulation.smethod_9(random_, 1, 3);
					if (1 != num5)
					{
						num = 699477486;
						num16 = 699477486;
					}
					else
					{
						num = 488651007;
						num16 = 488651007;
					}
					continue;
					IL_00c9:
					while (true)
					{
						switch ((num2 = (uint)num13 ^ 0x1BD083AAu) % 11u)
						{
						case 10u:
							break;
						case 9u:
							num13 = ((int)num2 * -856067484) ^ -1967623343;
							continue;
						case 7u:
							moveCar(car, list);
							num13 = (int)((num2 * 1964417102) ^ 0x6DF09F1B);
							continue;
						case 6u:
							num13 = 1560674458;
							continue;
						case 5u:
							num13 = 969614681;
							continue;
						case 3u:
							canExitCheckpoint(car);
							num13 = (int)(num2 * 946677968) ^ -1565378129;
							continue;
						case 2u:
						{
							int num17;
							int num18;
							if (flag4)
							{
								num17 = -1974399043;
								num18 = -1974399043;
							}
							else
							{
								num17 = -2064105867;
								num18 = -2064105867;
							}
							num13 = num17 ^ ((int)num2 * -1946243709);
							continue;
						}
						default:
							return;
						case 4u:
							goto IL_010b;
						case 0u:
							goto IL_0135;
						case 8u:
							goto IL_15ea;
						case 1u:
							return;
						}
						break;
					}
					goto IL_000b;
					IL_15ea:
					throw Simulation.smethod_15("xD");
					IL_09ad:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Aleje_East_Exit_2;
					num = 731475017;
					continue;
					IL_0987:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Bitwy_South_Exit_2;
					num = 1435539103;
					continue;
					IL_0961:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Aleje_West_Exit_2;
					num = 1360191254;
					continue;
					IL_093b:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Done;
					num = 2057800648;
					continue;
					IL_0915:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Bitwy_North_Exit_2;
					num = 1518766915;
					continue;
					IL_08ee:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_1_Inside_Left_Entry_Rondo_2;
					list = Points.Rondo_1_Inside_Left_Entry_Rondo_2;
					goto IL_010b;
					IL_08c8:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_1_West_Entry_Rondo_2;
					num = 1612916647;
					continue;
					IL_08b5:
					num5 = Simulation.smethod_9(random_, 1, 3);
					num = 546957911;
					continue;
					IL_088f:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Done;
					num = 198193730;
					continue;
					IL_0869:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Aleje_West_Exit_2;
					num = 1208769293;
					continue;
					IL_0843:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Bitwy_South_Exit_2;
					num = 1465832710;
					continue;
					IL_082a:
					num5 = Simulation.smethod_9(random_, 1, 3);
					flag3 = num5 == 1;
					num = 1438127539;
					continue;
					IL_0804:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Bitwy_North_Left_Exit;
					num = 39100847;
					continue;
					IL_07de:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Bitwy_North_Exit_2;
					num = 462280434;
					continue;
					IL_07b8:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Done;
					num = 170718436;
					continue;
					IL_0793:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Aleje_East_Exit_2;
					num = 1527273259;
					continue;
					IL_076d:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_1_North_Entry_Rondo_2;
					num = 1182444846;
					continue;
					IL_075a:
					num = ((int)num2 * -238473050) ^ -1198693003;
					continue;
					IL_0625:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_1_South_Entry_Rondo_2;
					list = Points.Rondo_1_South_Entry_Rondo_2;
					num = 1234325514;
					continue;
					IL_048f:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_1_East_Entry_Rondo_2;
					num = 1671444051;
					continue;
					IL_0469:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Done;
					num = 774233536;
					continue;
					IL_03d5:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_2_West_Exit;
					num = 1260257122;
					continue;
					IL_0351:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_2_North_Entry_Rondo_3;
					num = 1343756762;
					continue;
					IL_0290:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_3_Inside_Left_exit;
					num = 567132514;
					continue;
					IL_026a:
					TrafficPlan.trafficList[car.id].iAmHere = WhereIsNow.Rondo_3_North_Exit;
					num = 739664327;
					continue;
				}
				break;
			}
		}
	}

	private List<Point> choiseStartTrace(int idCar)
	{
		Random random_ = default(Random);
		int num9 = default(int);
		List<Point> result = default(List<Point>);
		bool flag3 = default(bool);
		bool flag4 = default(bool);
		bool flag5 = default(bool);
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 1467645950;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x19FAE342u) % 42u)
				{
				case 41u:
					num = (int)((num2 * 1995111403) ^ 0x616C6393);
					continue;
				case 40u:
					random_ = Simulation.smethod_8();
					num = (int)(num2 * 37980238) ^ -678034331;
					continue;
				case 39u:
					num9 = Simulation.smethod_9(random_, 1, 8);
					num = ((int)num2 * -701646001) ^ 0x3D69DD25;
					continue;
				case 38u:
					num = ((int)num2 * -200474805) ^ -1633763336;
					continue;
				case 37u:
					result = Points.Aleje_East_Right_Bitwy;
					num = ((int)num2 * -1029830177) ^ -165123608;
					continue;
				case 36u:
					TrafficPlan.trafficList[idCar].iAmHere = WhereIsNow.Aleje_East_Entry_Rondo;
					num = (int)((num2 * 1700498661) ^ 0x511F81E0);
					continue;
				case 35u:
					num = ((int)num2 * -1054892111) ^ 0x43E26D43;
					continue;
				case 34u:
					TrafficPlan.trafficList[idCar].iAmHere = WhereIsNow.Bitwy_North_Entry_1;
					num = ((int)num2 * -2021100378) ^ 0x7879CE8A;
					continue;
				case 33u:
					flag3 = 4 == num9;
					num = 241334676;
					continue;
				case 32u:
					result = Points.Aleje_Entry_Left_Bitwy;
					num = ((int)num2 * -545056663) ^ 0x331C29AA;
					continue;
				case 31u:
					flag4 = 2 == num9;
					num = 1578746950;
					continue;
				case 30u:
				{
					int num7;
					int num8;
					if (!flag3)
					{
						num7 = 610332599;
						num8 = 610332599;
					}
					else
					{
						num7 = 1879841489;
						num8 = 1879841489;
					}
					num = num7 ^ ((int)num2 * -596192617);
					continue;
				}
				case 29u:
					num = (int)((num2 * 1408210570) ^ 0x5FF373DA);
					continue;
				case 28u:
					TrafficPlan.trafficList[idCar].iAmHere = WhereIsNow.Aleje_East_Right_Bitwy;
					num = 705477629;
					continue;
				case 27u:
				{
					int num14;
					int num15;
					if (flag5)
					{
						num14 = -2109280095;
						num15 = -2109280095;
					}
					else
					{
						num14 = -169109101;
						num15 = -169109101;
					}
					num = num14 ^ (int)(num2 * 1739256566);
					continue;
				}
				case 26u:
					TrafficPlan.trafficList[idCar].iAmHere = WhereIsNow.Bitwy_North_Entry_Left_Rondo;
					num = (int)(num2 * 1336960978) ^ -1695933749;
					continue;
				case 25u:
					num = (int)(num2 * 1218700525) ^ -1624105593;
					continue;
				case 24u:
					TrafficPlan.trafficList[idCar].iAmHere = WhereIsNow.Aleje_Entry_Left_Bitwy;
					num = (int)(num2 * 1753786362) ^ -1972527763;
					continue;
				case 23u:
					num = ((int)num2 * -1439859226) ^ -1908618912;
					continue;
				case 22u:
					result = Points.Aleje_West_Entry_1;
					num = ((int)num2 * -717563726) ^ 0x10D641A2;
					continue;
				case 21u:
					num = (int)(num2 * 583221476) ^ -796840644;
					continue;
				case 20u:
				{
					int num12;
					int num13;
					if (!flag4)
					{
						num12 = -1110022685;
						num13 = -1110022685;
					}
					else
					{
						num12 = -1481280649;
						num13 = -1481280649;
					}
					num = num12 ^ ((int)num2 * -1082800622);
					continue;
				}
				case 19u:
					flag2 = 6 == num9;
					num = 251983376;
					continue;
				case 17u:
					flag5 = 5 == num9;
					num = 350985017;
					continue;
				case 16u:
				{
					int num10;
					int num11;
					if (1 != num9)
					{
						num10 = -49996751;
						num11 = -49996751;
					}
					else
					{
						num10 = -154685363;
						num11 = -154685363;
					}
					num = num10 ^ ((int)num2 * -1798391528);
					continue;
				}
				case 15u:
					num = ((int)num2 * -1757108859) ^ 0x4F3062F2;
					continue;
				case 14u:
					TrafficPlan.trafficList[idCar].iAmHere = WhereIsNow.Bitwy_South_Entry_1;
					num = (int)(num2 * 756132262) ^ -1767435234;
					continue;
				case 13u:
					flag = 3 == num9;
					num = 2064735940;
					continue;
				case 12u:
					num = ((int)num2 * -404880642) ^ -1425153703;
					continue;
				case 11u:
					result = Points.Aleje_East_Entry_Rondo;
					num = (int)((num2 * 2051090871) ^ 0x407E1811);
					continue;
				case 10u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = 270307745;
						num6 = 270307745;
					}
					else
					{
						num5 = 898824718;
						num6 = 898824718;
					}
					num = num5 ^ (int)(num2 * 627385359);
					continue;
				}
				case 9u:
					num = (int)(num2 * 68760847) ^ -1863844123;
					continue;
				case 8u:
					num = ((int)num2 * -663632841) ^ -14566560;
					continue;
				case 7u:
					TrafficPlan.trafficList[idCar].iAmHere = WhereIsNow.Aleje_West_Entry_1;
					num = ((int)num2 * -568642298) ^ -158881610;
					continue;
				case 6u:
					result = Points.Bitwy_North_Entry_1;
					num = ((int)num2 * -1906042377) ^ -1035047668;
					continue;
				case 5u:
					num = (int)((num2 * 1884278650) ^ 0x5C4B8DC);
					continue;
				case 3u:
					num = (int)((num2 * 1877885814) ^ 0x5479C95C);
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1682717519;
						num4 = -1682717519;
					}
					else
					{
						num3 = -667007157;
						num4 = -667007157;
					}
					num = num3 ^ (int)(num2 * 1991702385);
					continue;
				}
				case 1u:
					result = Points.Bitwy_North_Entry_Left_Rondo;
					num = ((int)num2 * -315116125) ^ -138994052;
					continue;
				case 0u:
					result = Points.Bitwy_South_Entry_1;
					num = (int)((num2 * 1020368097) ^ 0x1B9940EB);
					continue;
				case 18u:
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
			int num;
			int num2;
			if (TrafficPlan.CanEntryInRoad(car.id, TrafficPlan.trafficList[car.id].iAmHere))
			{
				num = -1075637316;
				num2 = -1075637316;
			}
			else
			{
				num = -259839134;
				num2 = -259839134;
			}
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num ^ 0x940F5A19u) % 7u)
				{
				case 5u:
					num = -259839134;
					continue;
				case 4u:
					Simulation.smethod_7(stopCar_entryInRoad);
					num = ((int)num3 * -1779471729) ^ 0x6AD4BF93;
					continue;
				case 3u:
					num = -1317787466;
					continue;
				case 1u:
					num = (int)(num3 * 537335827) ^ -752901026;
					continue;
				case 0u:
					num = ((int)num3 * -1337060971) ^ 0x21A1FE5D;
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

	private void moveCar(Car car, List<Point> list)
	{
		_003C_003Ec__DisplayClass21_0 _003C_003Ec__DisplayClass21_ = new _003C_003Ec__DisplayClass21_0();
		int num5 = default(int);
		bool flag = default(bool);
		_003C_003Ec__DisplayClass21_1 _003C_003Ec__DisplayClass21_2 = default(_003C_003Ec__DisplayClass21_1);
		while (true)
		{
			int num = -237100574;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB01B7A63u) % 4u)
				{
				case 2u:
					num5 = 0;
					num = (int)((num2 * 326243365) ^ 0x66330C66);
					continue;
				case 1u:
					_003C_003Ec__DisplayClass21_.car = car;
					num = ((int)num2 * -174285538) ^ 0x156374AF;
					continue;
				case 0u:
					break;
				default:
				{
					using List<Point>.Enumerator enumerator = list.GetEnumerator();
					while (true)
					{
						int num3;
						int num4;
						if (!enumerator.MoveNext())
						{
							num3 = -1427779766;
							num4 = -1427779766;
						}
						else
						{
							num3 = -1084166593;
							num4 = -1084166593;
						}
						while (true)
						{
							switch ((num2 = (uint)num3 ^ 0xB01B7A63u) % 15u)
							{
							case 14u:
								num3 = (int)(num2 * 1280084078) ^ -1200854718;
								continue;
							case 12u:
								Simulation.smethod_7(speedCar);
								num3 = ((int)num2 * -782183239) ^ 0x77C5C006;
								continue;
							case 11u:
							{
								int num6;
								int num7;
								if (!flag)
								{
									num6 = -1719432564;
									num7 = -1719432564;
								}
								else
								{
									num6 = -1162318514;
									num7 = -1162318514;
								}
								num3 = num6 ^ ((int)num2 * -1611938133);
								continue;
							}
							case 10u:
								num3 = (int)((num2 * 85609030) ^ 0x33556EE8);
								continue;
							case 9u:
								num3 = (int)(num2 * 171459104) ^ -2033362917;
								continue;
							case 8u:
								Simulation.smethod_7(stopCar_nextPoint);
								num3 = -722475579;
								continue;
							case 6u:
								_003C_003Ec__DisplayClass21_2.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass21_;
								_003C_003Ec__DisplayClass21_2.item = enumerator.Current;
								num3 = (int)(num2 * 1642171315) ^ -574591530;
								continue;
							case 5u:
								flag = !TrafficPlan.CanMoveCar(_003C_003Ec__DisplayClass21_2.CS_0024_003C_003E8__locals1.car.id, TrafficPlan.trafficList[_003C_003Ec__DisplayClass21_2.CS_0024_003C_003E8__locals1.car.id].iAmHere);
								num3 = -397186644;
								continue;
							case 4u:
								num3 = -1084166593;
								continue;
							case 3u:
								_003C_003Ec__DisplayClass21_2 = new _003C_003Ec__DisplayClass21_1();
								num3 = -354420652;
								continue;
							case 2u:
								Simulation.smethod_6(Simulation.smethod_5((DispatcherObject)(object)this), (DispatcherPriority)4, (Delegate)new Action(_003C_003Ec__DisplayClass21_2._003CmoveCar_003Eb__0));
								Simulation.smethod_6(Simulation.smethod_5((DispatcherObject)(object)this), (DispatcherPriority)4, (Delegate)new Action(_003C_003Ec__DisplayClass21_2._003CmoveCar_003Eb__1));
								num3 = ((int)num2 * -2147404407) ^ -282713573;
								continue;
							case 1u:
								num3 = (int)(num2 * 1227407547) ^ -763616676;
								continue;
							case 0u:
								num5++;
								TrafficPlan.trafficList[_003C_003Ec__DisplayClass21_2.CS_0024_003C_003E8__locals1.car.id].countMove = num5;
								num3 = (int)(num2 * 36959608) ^ -90012019;
								continue;
							default:
								return;
							case 13u:
								break;
							case 7u:
								return;
							}
							break;
						}
					}
				}
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
			int num = 247817865;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x52C4C832u) % 6u)
				{
				case 4u:
					num = (int)(num2 * 2137864102) ^ -1906530085;
					continue;
				case 2u:
					Simulation.smethod_7(stopCar_ExitCheckPoint);
					num = 1516295146;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -2010114560;
						num4 = -2010114560;
					}
					else
					{
						num3 = -910156793;
						num4 = -910156793;
					}
					num = num3 ^ (int)(num2 * 405606178);
					continue;
				}
				case 0u:
					num = 409288662;
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

	private void driveByViaduct(Car car, int how_long)
	{
		while (true)
		{
			int num = 1329279580;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCBDBA8u) % 5u)
				{
				case 4u:
					Simulation.smethod_7(how_long);
					num = ((int)num2 * -90295921) ^ 0x1F917D1C;
					continue;
				case 1u:
					Simulation.smethod_6(Simulation.smethod_5((DispatcherObject)(object)this), (DispatcherPriority)4, (Delegate)(Action)delegate
					{
						_003C_003Ec__DisplayClass23_0.smethod_0((UIElement)(object)car.picture, -30.0);
					});
					num = (int)((num2 * 1303963307) ^ 0x257E6DC9);
					continue;
				case 0u:
					Simulation.smethod_6(Simulation.smethod_5((DispatcherObject)(object)this), (DispatcherPriority)4, (Delegate)(Action)delegate
					{
						_003C_003Ec__DisplayClass23_0.smethod_1((UIElement)(object)car.picture, -30.0);
					});
					num = (int)((num2 * 208766696) ^ 0x3234BC56);
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

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		Uri uri_ = default(Uri);
		while (true)
		{
			int num = -1124885836;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEC548016u) % 7u)
				{
				case 6u:
					num = (int)((num2 * 781972756) ^ 0x3B40B37E);
					continue;
				case 5u:
					uri_ = Simulation.smethod_16("/xrauUd;component/simulation.xaml", UriKind.Relative);
					num = ((int)num2 * -847364664) ^ -1231855294;
					continue;
				case 4u:
					_contentLoaded = true;
					num = -1596188902;
					continue;
				case 2u:
					Simulation.smethod_17((object)this, uri_);
					num = (int)((num2 * 358672720) ^ 0x6F58F2EA);
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!_contentLoaded)
					{
						num3 = 1250336111;
						num4 = 1250336111;
					}
					else
					{
						num3 = 1909548775;
						num4 = 1909548775;
					}
					num = num3 ^ (int)(num2 * 117584960);
					continue;
				}
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

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected O, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected O, but got Unknown
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected O, but got Unknown
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected O, but got Unknown
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected O, but got Unknown
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected O, but got Unknown
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected O, but got Unknown
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected O, but got Unknown
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected O, but got Unknown
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected O, but got Unknown
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected O, but got Unknown
		int num4 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = -8226032;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD6F1E384u) % 50u)
				{
				case 49u:
					num = ((int)num2 * -221329295) ^ 0x5BE94783;
					continue;
				case 48u:
					switch (num4)
					{
					case 1:
						goto IL_009e;
					case 2:
						goto IL_00bf;
					case 3:
						goto IL_00d5;
					case 4:
						goto IL_00eb;
					case 5:
						goto IL_0101;
					case 6:
						goto IL_0117;
					case 7:
						goto IL_012d;
					case 8:
						goto IL_0143;
					case 9:
						goto IL_0159;
					case 10:
						goto IL_016f;
					case 11:
						goto IL_0185;
					case 12:
						goto IL_019b;
					case 13:
						goto IL_01b1;
					case 14:
						goto IL_01c7;
					case 15:
						goto IL_01dd;
					case 16:
						goto IL_01f3;
					case 17:
						goto IL_0209;
					case 18:
						goto IL_021f;
					case 19:
						goto IL_0235;
					case 20:
						goto IL_024b;
					case 21:
						goto IL_0261;
					case 22:
						goto IL_0277;
					case 23:
						goto IL_028d;
					case 24:
						goto IL_02a3;
					case 25:
						goto IL_02b9;
					case 26:
						goto IL_02cf;
					case 27:
						goto IL_02e5;
					}
					num = (int)((num2 * 1971874541) ^ 0x236AB620);
					continue;
				case 33u:
					goto IL_009e;
				case 41u:
					goto IL_00bf;
				case 17u:
					goto IL_00d5;
				case 30u:
					goto IL_00eb;
				case 8u:
					goto IL_0101;
				case 32u:
					goto IL_0117;
				case 47u:
					goto IL_012d;
				case 44u:
					goto IL_0143;
				case 31u:
					goto IL_0159;
				case 46u:
					goto IL_016f;
				case 7u:
					goto IL_0185;
				case 21u:
					goto IL_019b;
				case 22u:
					goto IL_01b1;
				case 45u:
					goto IL_01c7;
				case 36u:
					goto IL_01dd;
				case 18u:
					goto IL_01f3;
				case 26u:
					goto IL_0209;
				case 29u:
					goto IL_021f;
				case 0u:
					goto IL_0235;
				case 40u:
					goto IL_024b;
				case 11u:
					goto IL_0261;
				case 15u:
					goto IL_0277;
				case 3u:
					goto IL_028d;
				case 1u:
					goto IL_02a3;
				case 13u:
					goto IL_02b9;
				case 5u:
					goto IL_02cf;
				case 27u:
					goto IL_02e5;
				case 43u:
					num = (int)((num2 * 927366761) ^ 0x15C6B311);
					continue;
				case 42u:
					num = ((int)num2 * -1519093116) ^ 0x290F0E1F;
					continue;
				case 39u:
					num = ((int)num2 * -742303099) ^ 0x2BEB01B9;
					continue;
				case 38u:
					num = (int)(num2 * 2070230819) ^ -1062560442;
					continue;
				case 37u:
					num = (int)(num2 * 1328280678) ^ -1037837188;
					continue;
				case 35u:
					num = ((int)num2 * -354358033) ^ 0x4187894F;
					continue;
				case 34u:
					num = ((int)num2 * -1361858945) ^ -19958682;
					continue;
				case 25u:
					num4 = num3;
					num = ((int)num2 * -604741608) ^ -1527821720;
					continue;
				case 24u:
					num = ((int)num2 * -364929211) ^ -168609200;
					continue;
				case 23u:
					num = (int)(num2 * 302236255) ^ -1883261253;
					continue;
				case 20u:
					num = (int)((num2 * 102167965) ^ 0x4F5258E0);
					continue;
				case 19u:
					num = ((int)num2 * -831413147) ^ 0x532A86F3;
					continue;
				case 16u:
					num = (int)(num2 * 839205107) ^ -274007098;
					continue;
				case 12u:
					num = ((int)num2 * -474883960) ^ 0x5B74454E;
					continue;
				case 10u:
					num = ((int)num2 * -809436560) ^ 0x6C00ED9E;
					continue;
				case 9u:
					_contentLoaded = true;
					num = -552980962;
					continue;
				case 6u:
					num3 = connectionId;
					num = ((int)num2 * -1919917504) ^ 0x4BD61519;
					continue;
				case 4u:
					num = ((int)num2 * -2044988963) ^ -643355658;
					continue;
				case 2u:
					num = ((int)num2 * -1010847648) ^ -1675509666;
					continue;
				default:
					return;
				case 28u:
					break;
				case 14u:
					return;
					IL_02e5:
					light25 = (Ellipse)target;
					num = -552980962;
					continue;
					IL_02cf:
					light24 = (Ellipse)target;
					num = -908694708;
					continue;
					IL_02b9:
					light23 = (Ellipse)target;
					num = -346868115;
					continue;
					IL_02a3:
					light22 = (Ellipse)target;
					num = -552980962;
					continue;
					IL_028d:
					light21 = (Ellipse)target;
					num = -552980962;
					continue;
					IL_0277:
					light20 = (Ellipse)target;
					num = -552980962;
					continue;
					IL_0261:
					light19 = (Ellipse)target;
					num = -468450484;
					continue;
					IL_024b:
					light18 = (Ellipse)target;
					num = -552980962;
					continue;
					IL_0235:
					light17 = (Ellipse)target;
					num = -552980962;
					continue;
					IL_021f:
					light16 = (Ellipse)target;
					num = -553788788;
					continue;
					IL_0209:
					light15 = (Ellipse)target;
					num = -2027681175;
					continue;
					IL_01f3:
					light14 = (Ellipse)target;
					num = -157396462;
					continue;
					IL_01dd:
					light13 = (Ellipse)target;
					num = -552980962;
					continue;
					IL_01c7:
					light12 = (Ellipse)target;
					num = -1369256901;
					continue;
					IL_01b1:
					light11 = (Ellipse)target;
					num = -615806094;
					continue;
					IL_019b:
					light10 = (Ellipse)target;
					num = -1503068017;
					continue;
					IL_0185:
					light9 = (Ellipse)target;
					num = -43015373;
					continue;
					IL_016f:
					light8 = (Ellipse)target;
					num = -286770676;
					continue;
					IL_0159:
					light7 = (Ellipse)target;
					num = -967505502;
					continue;
					IL_0143:
					light6 = (Ellipse)target;
					num = -552980962;
					continue;
					IL_012d:
					light5 = (Ellipse)target;
					num = -1367834484;
					continue;
					IL_0117:
					light4 = (Ellipse)target;
					num = -164165377;
					continue;
					IL_0101:
					light3 = (Ellipse)target;
					num = -552980962;
					continue;
					IL_00eb:
					light2 = (Ellipse)target;
					num = -552980962;
					continue;
					IL_00d5:
					light1 = (Ellipse)target;
					num = -552980962;
					continue;
					IL_00bf:
					SomeWhere = (Canvas)target;
					num = -70258354;
					continue;
					IL_009e:
					Simulation.smethod_18((FrameworkElement)(object)(Simulation)target, new RoutedEventHandler(Window_Loaded));
					num = -343010113;
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
