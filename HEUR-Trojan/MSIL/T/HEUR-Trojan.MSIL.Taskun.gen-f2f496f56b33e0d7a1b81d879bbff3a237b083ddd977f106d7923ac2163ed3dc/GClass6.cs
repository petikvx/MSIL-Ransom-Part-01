public sealed class GClass6
{
	public enum GEnum2
	{
		Ad_Agency,
		Activism_Organization,
		Airport,
		Ambulance_Service,
		Amusement_Park,
		Apartments,
		Aquarium,
		Architecture_Firm,
		Bar,
		Black_Market,
		Botanical_Garden,
		Cancer_Hospital,
		Cartel,
		Casino,
		Church,
		City_Wall,
		Civic_Center,
		Coal_Power_Plant,
		Coffee_Shop,
		Community_Center,
		Concert_Venue,
		Conglomerate,
		Conservation_Area,
		Construction_Site,
		Correctional_Facility,
		Courthouse,
		Crime_Ring,
		Cult,
		Customs_House,
		Daycare_Center,
		Department_Store,
		Detective_Agency,
		Embassy,
		Emergency_Hospital,
		Exurb,
		Factory,
		Farm,
		Fast_Food_Chain,
		Fire_Station,
		Fishery,
		Freeway,
		Gas_Power_Plant,
		Gas_Station,
		Geriatric_Hospital,
		Golf_Course,
		Government_Bureau,
		Graveyard,
		Grocery_Store,
		Gym,
		Harbor,
		Hotel,
		Hydro_Power_Plant,
		Laboratory,
		Land_Developer,
		Law_Firm,
		Library,
		Lumber_Mill,
		Mall,
		Mass_Transit,
		Maternity_Hospital,
		Mine,
		Monument,
		Military_Base,
		Museum,
		Nuclear_Power_Plant,
		Observatory,
		Oil_Well,
		Office,
		Park,
		Parking_Garage,
		Parking_Lot,
		Pediatric_Hospital,
		Pharmacy,
		Police_Station,
		Polling_Place,
		Private_Security_Company,
		Ranch,
		Rehab_Clinic,
		Research_Hospital,
		Restaurant,
		Retirement_Home,
		Safe_House,
		School,
		Shipping_Center,
		Sidewalks,
		Ski_Resort,
		Skyscraper,
		Solar_Power_Plant,
		Stadium,
		Startup_Incubator,
		Steel_Mill,
		Suburb,
		Tax_Assessor,
		Taxi_Service,
		Temp_Agency,
		Textile_Mill,
		Theater,
		Think_Tank,
		Toll_Booth,
		Tourism_Agency,
		TV_Station,
		University,
		Warehouse,
		Welfare_Service,
		Wind_Power_Plant,
		Zoo,
		BuildingCount
	}

	public enum GEnum3
	{
		Athletic,
		Coffee,
		Commerce,
		Criminal,
		Disreputable,
		Entertainment,
		Food,
		Franchise,
		Government,
		Manufacturing,
		Medical,
		Monument,
		Nature,
		Power,
		Science,
		Security,
		Transportation
	}

	public string method_0(int int_0)
	{
		GEnum2 gEnum = (GEnum2)int_0;
		string text = gEnum.ToString();
		return text.Replace('_', ' ');
	}

	public string method_1(int int_0)
	{
		GEnum3 gEnum = (GEnum3)int_0;
		string text = gEnum.ToString();
		return text.Replace('_', ' ');
	}

	public int method_2(int int_0)
	{
		return int_0 switch
		{
			0 => 110, 
			1 => 65, 
			2 => 510, 
			3 => 280, 
			4 => 455, 
			5 => 360, 
			6 => 195, 
			7 => 210, 
			8 => 60, 
			9 => 305, 
			10 => 260, 
			11 => 270, 
			12 => 140, 
			13 => 395, 
			14 => 180, 
			15 => 100, 
			16 => 635, 
			17 => 450, 
			18 => 75, 
			19 => 210, 
			20 => 385, 
			21 => 425, 
			22 => 65, 
			23 => 160, 
			24 => 185, 
			25 => 130, 
			26 => 50, 
			27 => 70, 
			28 => 255, 
			29 => 80, 
			30 => 185, 
			31 => 80, 
			32 => 215, 
			33 => 240, 
			34 => 435, 
			35 => 125, 
			36 => 80, 
			37 => 50, 
			38 => 100, 
			39 => 165, 
			40 => 275, 
			41 => 400, 
			42 => 110, 
			43 => 200, 
			44 => 140, 
			45 => 220, 
			46 => 100, 
			47 => 95, 
			48 => 65, 
			49 => 95, 
			50 => 275, 
			51 => 350, 
			52 => 205, 
			53 => 350, 
			54 => 280, 
			55 => 105, 
			56 => 130, 
			57 => 385, 
			58 => 175, 
			59 => 250, 
			60 => 55, 
			61 => 85, 
			62 => 260, 
			63 => 150, 
			64 => 575, 
			65 => 95, 
			66 => 445, 
			67 => 145, 
			68 => 125, 
			69 => 155, 
			70 => 50, 
			71 => 190, 
			72 => 70, 
			73 => 155, 
			74 => 255, 
			75 => 205, 
			76 => 130, 
			77 => 145, 
			78 => 260, 
			79 => 115, 
			80 => 130, 
			81 => 65, 
			82 => 160, 
			83 => 175, 
			84 => 35, 
			85 => 215, 
			86 => 325, 
			87 => 100, 
			88 => 310, 
			89 => 325, 
			90 => 505, 
			91 => 220, 
			92 => 125, 
			93 => 145, 
			94 => 135, 
			95 => 295, 
			96 => 180, 
			97 => 275, 
			98 => 40, 
			99 => 70, 
			100 => 250, 
			101 => 370, 
			102 => 210, 
			103 => 100, 
			104 => 175, 
			105 => 410, 
			_ => -1, 
		};
	}

	public GClass9 method_3(int int_0)
	{
		while (true)
		{
			if (int_0 < 0)
			{
				int_0 = Class24.smethod_0(0, 105);
			}
			switch (int_0)
			{
			case 0:
			{
				GClass9 gClass105 = new GClass9(int_0, method_2(int_0), 2);
				gClass105.method_0(3, 20, -2);
				gClass105.method_0(4, 10, 2);
				gClass105.method_8(2);
				gClass105.method_2(Class16.smethod_0(-561782191));
				gClass105.method_4(string.Empty);
				return gClass105;
			}
			case 1:
			{
				GClass44 gClass104 = new GClass44(int_0, method_2(int_0), 1);
				gClass104.method_0(0, 20, 2);
				gClass104.method_0(1, 30, 4);
				gClass104.method_0(3, 15, 1);
				gClass104.method_2(Class16.smethod_0(-561782070));
				return gClass104;
			}
			case 2:
			{
				GClass70 gClass103 = new GClass70(int_0, method_2(int_0), 6);
				gClass103.method_0(0, 15, -1);
				gClass103.method_0(5, 18, 10);
				gClass103.method_0(1, 15, -1);
				gClass103.method_8(16);
				gClass103.method_8(6);
				gClass103.method_2(Class16.smethod_0(-561779389));
				gClass103.method_4(Class16.smethod_0(-561779245));
				return gClass103;
			}
			case 3:
			{
				GClass22 gClass102 = new GClass22(int_0, method_2(int_0), 2);
				gClass102.method_0(1, 10, 4);
				gClass102.method_0(5, 10, 1);
				gClass102.method_8(10);
				gClass102.method_8(16);
				gClass102.method_2(Class16.smethod_0(-561779612));
				gClass102.method_4(Class16.smethod_0(-561779500));
				return gClass102;
			}
			case 4:
			{
				GClass29 gClass101 = new GClass29(int_0, method_2(int_0), 4, 14);
				gClass101.method_0(0, 16, 7);
				gClass101.method_0(1, 20, -1);
				gClass101.method_8(6);
				gClass101.method_8(5);
				gClass101.method_2(Class16.smethod_0(-561778875));
				gClass101.method_4(Class16.smethod_0(-561778701));
				return gClass101;
			}
			case 5:
			{
				GClass9 gClass100 = new GClass9(int_0, method_2(int_0), 1);
				gClass100.method_2(Class16.smethod_0(-561779168));
				gClass100.method_4(Class16.smethod_0(-561779056));
				return gClass100;
			}
			case 6:
			{
				GClass60 gClass99 = new GClass60(int_0, method_2(int_0), 3);
				gClass99.method_0(0, 25, 3);
				gClass99.method_0(1, 15, 2);
				gClass99.method_0(3, 15, 1);
				gClass99.method_8(12);
				gClass99.method_8(5);
				gClass99.method_2(string.Empty);
				gClass99.method_4(Class16.smethod_0(-561778965));
				return gClass99;
			}
			case 7:
			{
				GClass71 gClass98 = new GClass71(int_0, method_2(int_0), 2);
				gClass98.method_0(3, 10, 2);
				gClass98.method_0(4, 18, 4);
				gClass98.method_8(2);
				gClass98.method_2(Class16.smethod_0(-561780418));
				gClass98.method_4(Class16.smethod_0(-561780303));
				return gClass98;
			}
			case 8:
			{
				GClass84 gClass97 = new GClass84(int_0, method_2(int_0), 1);
				gClass97.method_0(0, 30, 4);
				gClass97.method_0(1, 10, 0);
				gClass97.method_0(6, 30, 6);
				gClass97.method_8(6);
				gClass97.method_2(Class16.smethod_0(-561780715));
				gClass97.method_4(Class16.smethod_0(-561780623));
				return gClass97;
			}
			case 9:
			{
				GClass12 gClass96 = new GClass12(int_0, method_2(int_0), 2);
				gClass96.method_0(7, 50, 3);
				gClass96.method_8(3);
				gClass96.method_8(2);
				gClass96.method_2(Class16.smethod_0(-561780490));
				return gClass96;
			}
			case 10:
			{
				GClass59 gClass95 = new GClass59(int_0, method_2(int_0), 2);
				gClass95.method_0(0, 30, 2);
				gClass95.method_0(1, 45, 2);
				gClass95.method_0(4, 15, 1);
				gClass95.method_8(12);
				gClass95.method_8(14);
				gClass95.method_2(Class16.smethod_0(-561779902));
				gClass95.method_4(Class16.smethod_0(-561779741));
				return gClass95;
			}
			case 11:
			{
				GClass81 gClass94 = new GClass81(int_0, method_2(int_0), 3);
				gClass94.method_0(0, 10, -5);
				gClass94.method_0(1, 30, 5);
				gClass94.method_8(10);
				gClass94.method_2(Class16.smethod_0(-561787064));
				gClass94.method_4(Class16.smethod_0(-561786978));
				return gClass94;
			}
			case 12:
			{
				GClass82 gClass93 = new GClass82(int_0, method_2(int_0), 3);
				gClass93.method_0(0, 28, 5);
				gClass93.method_0(1, 12, -7);
				gClass93.method_0(6, 30, 10);
				gClass93.method_0(7, 30, 4);
				gClass93.method_8(3);
				gClass93.method_8(9);
				gClass93.method_2(Class16.smethod_0(-561780171));
				gClass93.method_4(Class16.smethod_0(-561780013));
				return gClass93;
			}
			case 13:
			{
				GClass64 gClass92 = new GClass64(int_0, method_2(int_0), 4);
				gClass92.method_0(0, 50, 3);
				gClass92.method_0(6, 50, 3);
				gClass92.method_0(7, 22, 3);
				gClass92.method_8(2);
				gClass92.method_8(5);
				gClass92.method_8(4);
				gClass92.method_2(Class16.smethod_0(-561777374));
				gClass92.method_4(Class16.smethod_0(-561777263));
				return gClass92;
			}
			case 14:
			{
				GClass47 gClass91 = new GClass47(int_0, method_2(int_0), 1);
				gClass91.method_0(0, 14, 7);
				gClass91.method_0(6, 35, -4);
				gClass91.method_0(7, 16, -3);
				gClass91.method_2(Class16.smethod_0(-561777193));
				gClass91.method_4(Class16.smethod_0(-561777569));
				return gClass91;
			}
			case 15:
			{
				GClass9 gClass90 = new GClass9(int_0, method_2(int_0), 0);
				gClass90.method_0(5, 15, -3);
				gClass90.method_0(7, 15, -3);
				gClass90.method_8(8);
				gClass90.method_2(Class16.smethod_0(-561777487));
				gClass90.method_4(Class16.smethod_0(-561776860));
				return gClass90;
			}
			case 16:
			{
				GClass9 gClass89 = new GClass9(int_0, method_2(int_0), 8);
				gClass89.method_0(0, 25, 3);
				gClass89.method_0(3, 25, 3);
				gClass89.method_0(4, 25, 3);
				gClass89.method_8(2);
				gClass89.method_2(Class16.smethod_0(-561776647));
				gClass89.method_4(Class16.smethod_0(-561777046));
				return gClass89;
			}
			case 17:
			{
				GClass16 gClass88 = new GClass16(int_0, method_2(int_0), 3);
				gClass88.method_0(0, 40, -5);
				gClass88.method_0(1, 20, -2);
				gClass88.method_8(13);
				gClass88.method_2(string.Empty);
				gClass88.method_4(Class16.smethod_0(-561776957));
				return gClass88;
			}
			case 18:
			{
				GClass9 gClass87 = new GClass9(int_0, method_2(int_0), 1, 14);
				gClass87.method_0(0, 20, 1);
				gClass87.method_0(1, 15, 0);
				gClass87.method_0(5, 20, 1);
				gClass87.method_0(6, 40, -1);
				gClass87.method_8(6);
				gClass87.method_2(Class16.smethod_0(-561778423));
				gClass87.method_4(Class16.smethod_0(-561778299));
				return gClass87;
			}
			case 19:
			{
				GClass31 gClass86 = new GClass31(int_0, method_2(int_0), 2, 14);
				gClass86.method_0(1, 10, 2);
				gClass86.method_0(0, 10, 2);
				gClass86.method_0(3, 10, 2);
				gClass86.method_0(4, 10, 2);
				gClass86.method_0(5, 10, 2);
				gClass86.method_0(6, 10, -2);
				gClass86.method_0(7, 10, -2);
				gClass86.method_8(8);
				gClass86.method_2(Class16.smethod_0(-561778208));
				gClass86.method_4(Class16.smethod_0(-561778607));
				return gClass86;
			}
			case 20:
			{
				GClass9 gClass85 = new GClass9(int_0, method_2(int_0), 3);
				gClass85.method_0(0, 45, 1);
				gClass85.method_0(4, 55, 4);
				gClass85.method_0(6, 45, 3);
				gClass85.method_8(5);
				gClass85.method_8(4);
				gClass85.method_2(Class16.smethod_0(-561778489));
				gClass85.method_4(string.Empty);
				return gClass85;
			}
			case 21:
			{
				GClass65 gClass84 = new GClass65(int_0, method_2(int_0), 7);
				gClass84.method_0(0, 15, -2);
				gClass84.method_0(6, 20, 3);
				gClass84.method_0(4, 30, -4);
				gClass84.method_8(2);
				gClass84.method_2(string.Empty);
				gClass84.method_4(string.Empty);
				return gClass84;
			}
			case 22:
			{
				GClass61 gClass83 = new GClass61(int_0, method_2(int_0), 0);
				gClass83.method_0(1, 15, 1);
				gClass83.method_8(12);
				gClass83.method_2(Class16.smethod_0(-561777866));
				gClass83.method_4(Class16.smethod_0(-561777800));
				return gClass83;
			}
			case 23:
			{
				GClass73 gClass82 = new GClass73(int_0, method_2(int_0), 3);
				gClass82.method_0(7, 30, 2);
				gClass82.method_2(string.Empty);
				gClass82.method_2(Class16.smethod_0(-561777712));
				gClass82.method_4(Class16.smethod_0(-561778037));
				return gClass82;
			}
			case 24:
			{
				GClass24 gClass81 = new GClass24(int_0, method_2(int_0), 2);
				gClass81.method_0(7, 60, -2);
				gClass81.method_2(string.Empty);
				return gClass81;
			}
			case 25:
			{
				GClass9 gClass80 = new GClass9(int_0, method_2(int_0), 2);
				gClass80.method_0(0, 12, -5);
				gClass80.method_0(3, 15, 1);
				gClass80.method_0(7, 25, -3);
				gClass80.method_8(11);
				gClass80.method_8(8);
				gClass80.method_2(Class16.smethod_0(-561775318));
				gClass80.method_4(Class16.smethod_0(-561775108));
				return gClass80;
			}
			case 26:
			{
				GClass66 gClass79 = new GClass66(int_0, method_2(int_0), 4, 10);
				gClass79.method_0(7, 14, 10);
				gClass79.method_8(3);
				gClass79.method_8(4);
				gClass79.method_2(Class16.smethod_0(-561775442));
				gClass79.method_4(Class16.smethod_0(-561774814));
				return gClass79;
			}
			case 27:
			{
				GClass51 gClass78 = new GClass51(int_0, method_2(int_0), 2);
				gClass78.method_0(0, 5, 20);
				gClass78.method_0(3, 10, -6);
				gClass78.method_0(7, 25, 3);
				gClass78.method_8(7);
				gClass78.method_8(4);
				gClass78.method_2(string.Empty);
				return gClass78;
			}
			case 28:
			{
				GClass9 gClass77 = new GClass9(int_0, method_2(int_0), 2);
				gClass77.method_0(4, 33, 3);
				gClass77.method_0(7, 10, 2);
				gClass77.method_8(8);
				gClass77.method_8(2);
				gClass77.method_2(Class16.smethod_0(-561774716));
				gClass77.method_4(Class16.smethod_0(-561775094));
				return gClass77;
			}
			case 29:
			{
				GClass86 gClass76 = new GClass86(int_0, method_2(int_0), 1);
				gClass76.method_0(0, 20, 5);
				gClass76.method_0(1, 18, 2);
				gClass76.method_0(7, 20, -2);
				gClass76.method_2(Class16.smethod_0(-561774971));
				gClass76.method_4(Class16.smethod_0(-561776312));
				return gClass76;
			}
			case 30:
			{
				GClass49 gClass75 = new GClass49(int_0, method_2(int_0), 3, 14);
				gClass75.method_0(0, 8, 1);
				gClass75.method_0(4, 12, -1);
				gClass75.method_8(7);
				gClass75.method_8(2);
				gClass75.method_2(Class16.smethod_0(-561776266));
				gClass75.method_4(Class16.smethod_0(-561776152));
				return gClass75;
			}
			case 31:
			{
				GClass34 gClass74 = new GClass34(int_0, method_2(int_0), 1);
				gClass74.method_0(7, 8, -8);
				gClass74.method_8(15);
				gClass74.method_2(Class16.smethod_0(-561776577));
				gClass74.method_4(Class16.smethod_0(-561776408));
				return gClass74;
			}
			case 32:
			{
				GClass39 gClass73 = new GClass39(int_0, method_2(int_0), 2);
				gClass73.method_0(3, 10, 8);
				gClass73.method_0(7, 10, 7);
				gClass73.method_8(8);
				gClass73.method_2(string.Empty);
				gClass73.method_4(Class16.smethod_0(-561775706));
				return gClass73;
			}
			case 33:
			{
				GClass77 gClass72 = new GClass77(int_0, method_2(int_0), 3);
				gClass72.method_0(0, 25, -2);
				gClass72.method_0(1, 30, 5);
				gClass72.method_0(6, 12, -3);
				gClass72.method_8(10);
				gClass72.method_2(Class16.smethod_0(-561787298));
				gClass72.method_4(Class16.smethod_0(-561787181));
				return gClass72;
			}
			case 34:
			{
				GClass53 gClass71 = new GClass53(int_0, method_2(int_0), 0);
				gClass71.method_0(5, 15, 2);
				gClass71.method_2(Class16.smethod_0(-561776063));
				gClass71.method_4(Class16.smethod_0(-561775919));
				return gClass71;
			}
			case 35:
			{
				GClass82 gClass70 = new GClass82(int_0, method_2(int_0), 5);
				gClass70.method_0(0, 16, -3);
				gClass70.method_0(1, 33, -6);
				gClass70.method_8(2);
				gClass70.method_8(4);
				gClass70.method_2(Class16.smethod_0(-561789575));
				gClass70.method_4(Class16.smethod_0(-561789468));
				return gClass70;
			}
			case 36:
			{
				GClass88 gClass69 = new GClass88(int_0, method_2(int_0), 1, 12);
				gClass69.method_0(1, 65, 2);
				gClass69.method_8(6);
				gClass69.method_8(12);
				gClass69.method_2(Class16.smethod_0(-561789895));
				gClass69.method_4(Class16.smethod_0(-561789788));
				return gClass69;
			}
			case 37:
			{
				GClass50 gClass68 = new GClass50(int_0, method_2(int_0), 1, 14);
				gClass68.method_0(0, 65, 1);
				gClass68.method_0(1, 65, -2);
				gClass68.method_0(5, 15, 1);
				gClass68.method_8(6);
				gClass68.method_8(7);
				gClass68.method_2(Class16.smethod_0(-561789167));
				gClass68.method_4(Class16.smethod_0(-561789025));
				return gClass68;
			}
			case 38:
			{
				GClass35 gClass67 = new GClass35(int_0, method_2(int_0), 2);
				gClass67.method_0(1, 5, 1);
				gClass67.method_8(15);
				gClass67.method_8(8);
				gClass67.method_2(Class16.smethod_0(-561788931));
				gClass67.method_4(Class16.smethod_0(-561789322));
				return gClass67;
			}
			case 39:
			{
				GClass82 gClass66 = new GClass82(int_0, method_2(int_0), 2);
				gClass66.method_0(0, 10, -2);
				gClass66.method_0(1, 5, 1);
				gClass66.method_8(9);
				gClass66.method_8(6);
				gClass66.method_2(string.Empty);
				return gClass66;
			}
			case 40:
			{
				GClass41 gClass65 = new GClass41(int_0, method_2(int_0), 0);
				gClass65.method_0(1, 10, -3);
				gClass65.method_0(5, 20, 6);
				gClass65.method_8(16);
				gClass65.method_2(Class16.smethod_0(-561789264));
				gClass65.method_4(Class16.smethod_0(-561790696));
				return gClass65;
			}
			case 41:
			{
				GClass18 gClass64 = new GClass18(int_0, method_2(int_0), 2);
				gClass64.method_0(0, 15, -8);
				gClass64.method_0(1, 15, -1);
				gClass64.method_8(13);
				gClass64.method_2(string.Empty);
				gClass64.method_4(Class16.smethod_0(-561790605));
				return gClass64;
			}
			case 42:
			{
				GClass75 gClass63 = new GClass75(int_0, method_2(int_0), 1);
				gClass63.method_0(1, 30, -2);
				gClass63.method_0(5, 38, 3);
				gClass63.method_8(16);
				gClass63.method_8(6);
				gClass63.method_2(Class16.smethod_0(-561790541));
				gClass63.method_4(Class16.smethod_0(-561790940));
				return gClass63;
			}
			case 43:
			{
				GClass78 gClass62 = new GClass78(int_0, method_2(int_0), 3);
				gClass62.method_0(0, 20, -2);
				gClass62.method_0(1, 30, 3);
				gClass62.method_8(10);
				gClass62.method_2(Class16.smethod_0(-561788541));
				gClass62.method_4(Class16.smethod_0(-561788429));
				return gClass62;
			}
			case 44:
			{
				GClass21 gClass61 = new GClass21(int_0, method_2(int_0), 1, 13);
				gClass61.method_0(0, 10, 1);
				gClass61.method_0(1, 22, 1);
				gClass61.method_0(6, 10, 1);
				gClass61.method_8(5);
				gClass61.method_2(Class16.smethod_0(-561790793));
				gClass61.method_4(Class16.smethod_0(-561790120));
				return gClass61;
			}
			case 45:
			{
				GClass9 gClass60 = new GClass9(int_0, method_2(int_0), 5);
				gClass60.method_0(1, 20, 1);
				gClass60.method_0(7, 10, 1);
				gClass60.method_8(8);
				gClass60.method_2(Class16.smethod_0(-561790001));
				gClass60.method_4(Class16.smethod_0(-561790425));
				return gClass60;
			}
			case 47:
			{
				GClass27 gClass59 = new GClass27(int_0, method_2(int_0), 2, 14);
				gClass59.method_0(1, 75, 1);
				gClass59.method_0(6, 15, 1);
				gClass59.method_8(6);
				gClass59.method_2(Class16.smethod_0(-561790372));
				gClass59.method_4(Class16.smethod_0(-561790216));
				return gClass59;
			}
			case 48:
			{
				GClass42 gClass58 = new GClass42(int_0, method_2(int_0), 1);
				gClass58.method_0(1, 12, 6);
				gClass58.method_2(Class16.smethod_0(-561787581));
				gClass58.method_4(Class16.smethod_0(-561787510));
				return gClass58;
			}
			case 49:
			{
				GClass68 gClass57 = new GClass68(int_0, method_2(int_0), 2);
				gClass57.method_0(5, 12, 2);
				gClass57.method_0(7, 12, 2);
				gClass57.method_0(6, 20, 2);
				gClass57.method_8(16);
				gClass57.method_2(Class16.smethod_0(-561787444));
				gClass57.method_4(Class16.smethod_0(-561787772));
				return gClass57;
			}
			case 50:
			{
				GClass54 gClass56 = new GClass54(int_0, method_2(int_0), 3);
				gClass56.method_0(5, 20, 2);
				gClass56.method_8(16);
				gClass56.method_2(Class16.smethod_0(-561785476));
				gClass56.method_4(Class16.smethod_0(-561785424));
				return gClass56;
			}
			case 51:
			{
				GClass20 gClass55 = new GClass20(int_0, method_2(int_0), 2);
				gClass55.method_0(5, 25, -3);
				gClass55.method_8(13);
				gClass55.method_2(string.Empty);
				gClass55.method_4(Class16.smethod_0(-561785847));
				return gClass55;
			}
			case 52:
			{
				GClass9 gClass54 = new GClass9(int_0, method_2(int_0), 2);
				gClass54.method_0(1, 20, -2);
				gClass54.method_0(3, 16, 8);
				gClass54.method_8(14);
				gClass54.method_2(Class16.smethod_0(-561785773));
				gClass54.method_4(Class16.smethod_0(-561785614));
				return gClass54;
			}
			case 53:
			{
				GClass9 gClass53 = new GClass9(int_0, method_2(int_0), 5);
				gClass53.method_0(4, 10, 1);
				gClass53.method_2(string.Empty);
				return gClass53;
			}
			case 54:
			{
				GClass9 gClass52 = new GClass9(int_0, method_2(int_0), 3);
				gClass52.method_0(0, 20, -2);
				gClass52.method_0(3, 20, 3);
				gClass52.method_0(7, 20, -2);
				gClass52.method_2(Class16.smethod_0(-561784958));
				gClass52.method_4(Class16.smethod_0(-561784844));
				return gClass52;
			}
			case 55:
			{
				GClass9 gClass51 = new GClass9(int_0, method_2(int_0), 2);
				gClass51.method_0(0, 14, 1);
				gClass51.method_0(3, 15, 4);
				gClass51.method_0(4, 10, 1);
				gClass51.method_8(8);
				gClass51.method_2(Class16.smethod_0(-561785236));
				gClass51.method_4(Class16.smethod_0(-561785139));
				return gClass51;
			}
			case 56:
			{
				GClass82 gClass50 = new GClass82(int_0, method_2(int_0), 2);
				gClass50.method_0(1, 15, -2);
				gClass50.method_8(9);
				gClass50.method_2(Class16.smethod_0(-561786597));
				gClass50.method_4(Class16.smethod_0(-561786495));
				return gClass50;
			}
			case 57:
			{
				GClass55 gClass49 = new GClass55(int_0, method_2(int_0), 5, 14);
				gClass49.method_0(0, 35, 3);
				gClass49.method_0(4, 20, -3);
				gClass49.method_8(2);
				gClass49.method_8(6);
				gClass49.method_8(5);
				gClass49.method_2(Class16.smethod_0(-561786859));
				gClass49.method_4(Class16.smethod_0(-561786708));
				return gClass49;
			}
			case 58:
			{
				GClass89 gClass48 = new GClass89(int_0, method_2(int_0), 1);
				gClass48.method_0(5, 32, 5);
				gClass48.method_8(16);
				gClass48.method_2(Class16.smethod_0(-561786636));
				gClass48.method_4(Class16.smethod_0(-561786021));
				return gClass48;
			}
			case 59:
			{
				GClass79 gClass47 = new GClass79(int_0, method_2(int_0), 3);
				gClass47.method_0(0, 20, -2);
				gClass47.method_0(1, 30, 3);
				gClass47.method_8(10);
				gClass47.method_2(Class16.smethod_0(-561788785));
				gClass47.method_4(Class16.smethod_0(-561788125));
				return gClass47;
			}
			case 60:
			{
				GClass28 gClass46 = new GClass28(int_0, method_2(int_0), 2);
				gClass46.method_0(0, 18, -4);
				gClass46.method_0(1, 50, -3);
				gClass46.method_8(2);
				gClass46.method_2(Class16.smethod_0(-561786153));
				gClass46.method_4(Class16.smethod_0(-561783492));
				return gClass46;
			}
			case 61:
			{
				GClass43 gClass45 = new GClass43(int_0, method_2(int_0), 0);
				gClass45.method_0(0, 10, 1);
				gClass45.method_0(4, 16, 3);
				gClass45.method_2(Class16.smethod_0(-561783358));
				gClass45.method_4(Class16.smethod_0(-561783751));
				return gClass45;
			}
			case 62:
			{
				GClass33 gClass44 = new GClass33(int_0, method_2(int_0), 5);
				gClass44.method_0(0, 15, -1);
				gClass44.method_0(1, 15, 1);
				gClass44.method_0(4, 30, -2);
				gClass44.method_0(6, 14, 7);
				gClass44.method_0(7, 30, -3);
				gClass44.method_8(8);
				gClass44.method_8(11);
				gClass44.method_8(15);
				gClass44.method_2(Class16.smethod_0(-561785884));
				gClass44.method_4(Class16.smethod_0(-561786215));
				return gClass44;
			}
			case 63:
			{
				GClass9 gClass43 = new GClass9(int_0, method_2(int_0), 1);
				gClass43.method_0(3, 32, 2);
				gClass43.method_0(4, 22, 10);
				gClass43.method_8(11);
				gClass43.method_2(Class16.smethod_0(-561783655));
				gClass43.method_4(string.Empty);
				return gClass43;
			}
			case 64:
			{
				GClass17 gClass42 = new GClass17(int_0, method_2(int_0), 2);
				gClass42.method_8(13);
				gClass42.method_8(4);
				gClass42.method_2(string.Empty);
				gClass42.method_4(Class16.smethod_0(-561783613));
				return gClass42;
			}
			case 65:
			{
				GClass9 gClass41 = new GClass9(int_0, method_2(int_0), 1);
				gClass41.method_0(3, 20, 4);
				gClass41.method_8(14);
				gClass41.method_2(Class16.smethod_0(-561782970));
				gClass41.method_4(Class16.smethod_0(-561782820));
				return gClass41;
			}
			case 66:
			{
				GClass9 gClass40 = new GClass9(int_0, method_2(int_0), 4);
				gClass40.method_0(1, 35, -4);
				gClass40.method_0(5, 75, 1);
				gClass40.method_8(2);
				gClass40.method_2(Class16.smethod_0(-561783215));
				gClass40.method_4(Class16.smethod_0(-561783065));
				return gClass40;
			}
			case 67:
			{
				GClass9 gClass39 = new GClass9(int_0, method_2(int_0), 4);
				gClass39.method_0(4, 30, -2);
				gClass39.method_8(2);
				gClass39.method_2(Class16.smethod_0(-561784478));
				gClass39.method_4(Class16.smethod_0(-561784357));
				return gClass39;
			}
			case 68:
			{
				GClass9 gClass38 = new GClass9(int_0, method_2(int_0), 1);
				gClass38.method_0(0, 15, 2);
				gClass38.method_0(1, 40, 2);
				gClass38.method_0(4, 20, 2);
				gClass38.method_8(12);
				gClass38.method_8(11);
				gClass38.method_8(5);
				gClass38.method_2(Class16.smethod_0(-561784827));
				gClass38.method_4(string.Empty);
				return gClass38;
			}
			case 69:
			{
				GClass69 gClass37 = new GClass69(int_0, method_2(int_0), 1);
				gClass37.method_0(4, 20, -1);
				gClass37.method_0(5, 40, 1);
				gClass37.method_0(7, 20, 2);
				gClass37.method_8(16);
				gClass37.method_2(Class16.smethod_0(-561784675));
				gClass37.method_4(Class16.smethod_0(-561784052));
				return gClass37;
			}
			case 70:
			{
				GClass56 gClass36 = new GClass56(int_0, method_2(int_0), 0);
				gClass36.method_0(4, 10, -1);
				gClass36.method_0(5, 20, 1);
				gClass36.method_0(7, 10, 1);
				gClass36.method_8(16);
				gClass36.method_2(Class16.smethod_0(-561783923));
				gClass36.method_4(Class16.smethod_0(-561784302));
				return gClass36;
			}
			case 71:
			{
				GClass80 gClass35 = new GClass80(int_0, method_2(int_0), 3);
				gClass35.method_0(0, 20, -3);
				gClass35.method_0(1, 30, 4);
				gClass35.method_8(10);
				gClass35.method_2(Class16.smethod_0(-561787970));
				gClass35.method_4(Class16.smethod_0(-561788382));
				return gClass35;
			}
			case 72:
			{
				GClass9 gClass34 = new GClass9(int_0, method_2(int_0), 1);
				gClass34.method_0(1, 50, 1);
				gClass34.method_0(6, 5, 5);
				gClass34.method_8(10);
				gClass34.method_8(14);
				gClass34.method_2(Class16.smethod_0(-561784174));
				gClass34.method_4(Class16.smethod_0(-561784065));
				return gClass34;
			}
			case 73:
			{
				GClass37 gClass33 = new GClass37(int_0, method_2(int_0), 2);
				gClass33.method_0(0, 15, -1);
				gClass33.method_0(7, 50, -3);
				gClass33.method_8(15);
				gClass33.method_8(8);
				gClass33.method_2(Class16.smethod_0(-561797801));
				gClass33.method_4(Class16.smethod_0(-561797691));
				return gClass33;
			}
			case 74:
			{
				GClass10 gClass32 = new GClass10(int_0, method_2(int_0), 1);
				gClass32.method_0(0, 25, 2);
				gClass32.method_0(3, 25, 1);
				gClass32.method_8(8);
				gClass32.method_2(Class16.smethod_0(-561798141));
				gClass32.method_4(string.Empty);
				return gClass32;
			}
			case 75:
			{
				GClass36 gClass31 = new GClass36(int_0, method_2(int_0), 2);
				gClass31.method_0(7, 12, -5);
				gClass31.method_8(15);
				gClass31.method_2(Class16.smethod_0(-561798024));
				gClass31.method_4(Class16.smethod_0(-561797894));
				return gClass31;
			}
			case 76:
			{
				GClass57 gClass30 = new GClass57(int_0, method_2(int_0), 2, 12);
				gClass30.method_0(0, 30, 1);
				gClass30.method_0(1, 33, 2);
				gClass30.method_8(6);
				gClass30.method_8(12);
				gClass30.method_2(Class16.smethod_0(-561797278));
				gClass30.method_4(Class16.smethod_0(-561797147));
				return gClass30;
			}
			case 77:
			{
				GClass45 gClass29 = new GClass45(int_0, method_2(int_0), 1);
				gClass29.method_0(1, 10, 4);
				gClass29.method_0(6, 50, -2);
				gClass29.method_8(10);
				gClass29.method_8(4);
				gClass29.method_2(Class16.smethod_0(-561797520));
				gClass29.method_4(Class16.smethod_0(-561798903));
				return gClass29;
			}
			case 78:
			{
				GClass76 gClass28 = new GClass76(int_0, method_2(int_0), 3);
				gClass28.method_0(1, 5, 10);
				gClass28.method_0(3, 40, 5);
				gClass28.method_8(10);
				gClass28.method_8(14);
				gClass28.method_2(Class16.smethod_0(-561788225));
				gClass28.method_4(Class16.smethod_0(-561785554));
				return gClass28;
			}
			case 79:
			{
				GClass83 gClass27 = new GClass83(int_0, method_2(int_0), 2, 14);
				gClass27.method_0(0, 40, 1);
				gClass27.method_0(1, 26, 1);
				gClass27.method_0(6, 5, 1);
				gClass27.method_8(6);
				gClass27.method_8(5);
				gClass27.method_2(Class16.smethod_0(-561798664));
				gClass27.method_4(Class16.smethod_0(-561799092));
				return gClass27;
			}
			case 80:
			{
				GClass11 gClass26 = new GClass11(int_0, method_2(int_0), 1);
				gClass26.method_0(0, 20, 4);
				gClass26.method_0(1, 18, 3);
				gClass26.method_0(5, 20, -3);
				gClass26.method_0(6, 20, -2);
				gClass26.method_2(Class16.smethod_0(-561798945));
				gClass26.method_4(Class16.smethod_0(-561798249));
				return gClass26;
			}
			case 81:
			{
				GClass23 gClass25 = new GClass23(int_0, method_2(int_0), 0);
				gClass25.method_0(4, 15, -3);
				gClass25.method_0(5, 20, -3);
				gClass25.method_0(3, 20, 3);
				gClass25.method_8(16);
				gClass25.method_2(Class16.smethod_0(-561798175));
				gClass25.method_4(Class16.smethod_0(-561798552));
				return gClass25;
			}
			case 82:
			{
				GClass30 gClass24 = new GClass30(int_0, method_2(int_0), 2);
				gClass24.method_0(0, 33, -1);
				gClass24.method_0(3, 50, 4);
				gClass24.method_0(4, 33, 1);
				gClass24.method_2(Class16.smethod_0(-561798404));
				gClass24.method_4(Class16.smethod_0(-561795687));
				return gClass24;
			}
			case 83:
			{
				GClass46 gClass23 = new GClass46(int_0, method_2(int_0), 1);
				gClass23.method_0(5, 12, 2);
				gClass23.method_8(16);
				gClass23.method_2(Class16.smethod_0(-561795633));
				gClass23.method_4(Class16.smethod_0(-561795995));
				return gClass23;
			}
			case 84:
			{
				GClass72 gClass22 = new GClass72(int_0, method_2(int_0), 0);
				gClass22.method_0(0, 8, 1);
				gClass22.method_0(5, 30, 1);
				gClass22.method_8(16);
				gClass22.method_2(Class16.smethod_0(-561795901));
				gClass22.method_4(Class16.smethod_0(-561795318));
				return gClass22;
			}
			case 85:
			{
				GClass85 gClass21 = new GClass85(int_0, method_2(int_0), 3);
				gClass21.method_0(0, 10, 6);
				gClass21.method_0(1, 12, 3);
				gClass21.method_0(5, 5, 2);
				gClass21.method_0(6, 5, 2);
				gClass21.method_8(5);
				gClass21.method_2(Class16.smethod_0(-561795248));
				gClass21.method_4(Class16.smethod_0(-561795104));
				return gClass21;
			}
			case 86:
			{
				GClass13 gClass20 = new GClass13(int_0, method_2(int_0), 6);
				gClass20.method_0(3, 30, 1);
				gClass20.method_8(2);
				gClass20.method_2(Class16.smethod_0(-561795560));
				return gClass20;
			}
			case 87:
			{
				GClass15 gClass19 = new GClass15(int_0, method_2(int_0), 0);
				gClass19.method_8(13);
				gClass19.method_2(string.Empty);
				gClass19.method_4(Class16.smethod_0(-561795447));
				return gClass19;
			}
			case 88:
			{
				GClass9 gClass18 = new GClass9(int_0, method_2(int_0), 4);
				gClass18.method_0(0, 24, 4);
				gClass18.method_0(1, 5, 5);
				gClass18.method_0(6, 20, 3);
				gClass18.method_8(5);
				gClass18.method_8(4);
				gClass18.method_2(Class16.smethod_0(-561795380));
				return gClass18;
			}
			case 89:
			{
				GClass25 gClass17 = new GClass25(int_0, method_2(int_0), 1);
				gClass17.method_0(0, 12, 2);
				gClass17.method_0(4, 10, 5);
				gClass17.method_8(2);
				gClass17.method_2(string.Empty);
				return gClass17;
			}
			case 90:
			{
				GClass82 gClass16 = new GClass82(int_0, method_2(int_0), 3);
				gClass16.method_0(1, 36, -3);
				gClass16.method_8(9);
				gClass16.method_2(string.Empty);
				return gClass16;
			}
			case 91:
			{
				GClass38 gClass15 = new GClass38(int_0, method_2(int_0), 1);
				gClass15.method_0(4, 30, -4);
				gClass15.method_0(7, 12, -2);
				gClass15.method_2(string.Empty);
				gClass15.method_4(Class16.smethod_0(-561796737));
				return gClass15;
			}
			case 92:
			{
				GClass9 gClass14 = new GClass9(int_0, method_2(int_0), 1);
				gClass14.method_0(0, 50, -2);
				gClass14.method_0(3, 10, 2);
				gClass14.method_0(7, 10, 2);
				gClass14.method_8(8);
				gClass14.method_8(2);
				gClass14.method_2(string.Empty);
				return gClass14;
			}
			case 93:
			{
				GClass67 gClass13 = new GClass67(int_0, method_2(int_0), 2);
				gClass13.method_0(5, 8, 4);
				gClass13.method_8(16);
				gClass13.method_2(string.Empty);
				return gClass13;
			}
			case 94:
			{
				GClass52 gClass12 = new GClass52(int_0, method_2(int_0), 1);
				gClass12.method_0(0, 15, -1);
				gClass12.method_0(3, 15, -1);
				gClass12.method_8(2);
				gClass12.method_2(string.Empty);
				return gClass12;
			}
			case 95:
			{
				GClass82 gClass11 = new GClass82(int_0, method_2(int_0), 2);
				gClass11.method_0(0, 22, -2);
				gClass11.method_8(9);
				gClass11.method_2(string.Empty);
				return gClass11;
			}
			case 96:
			{
				GClass9 gClass10 = new GClass9(int_0, method_2(int_0), 2, 14);
				gClass10.method_0(0, 30, 3);
				gClass10.method_0(4, 25, 3);
				gClass10.method_8(5);
				gClass10.method_2(Class16.smethod_0(-561796626));
				return gClass10;
			}
			case 97:
			{
				GClass74 gClass9 = new GClass74(int_0, method_2(int_0), 1);
				gClass9.method_0(3, 12, 7);
				gClass9.method_2(string.Empty);
				return gClass9;
			}
			case 98:
			{
				GClass87 gClass8 = new GClass87(int_0, method_2(int_0), 1);
				gClass8.method_0(0, 25, -1);
				gClass8.method_0(5, 25, -1);
				gClass8.method_8(16);
				gClass8.method_8(8);
				gClass8.method_2(string.Empty);
				return gClass8;
			}
			case 99:
			{
				GClass9 gClass7 = new GClass9(int_0, method_2(int_0), 1);
				gClass7.method_0(0, 5, 5);
				gClass7.method_0(1, 5, 1);
				gClass7.method_0(3, 5, 3);
				gClass7.method_0(4, 5, 4);
				gClass7.method_0(5, 5, 8);
				gClass7.method_2(string.Empty);
				return gClass7;
			}
			case 100:
			{
				GClass9 gClass6 = new GClass9(int_0, method_2(int_0), 3);
				gClass6.method_0(0, 70, 2);
				gClass6.method_0(4, 50, -1);
				gClass6.method_8(5);
				gClass6.method_2(Class16.smethod_0(-561797016));
				return gClass6;
			}
			case 101:
			{
				GClass9 gClass5 = new GClass9(int_0, method_2(int_0), 3);
				gClass5.method_0(3, 30, 8);
				gClass5.method_0(4, 25, 3);
				gClass5.method_0(6, 40, 2);
				gClass5.method_8(14);
				gClass5.method_2(Class16.smethod_0(-561796909));
				gClass5.method_4(Class16.smethod_0(-561796269));
				return gClass5;
			}
			case 102:
			{
				GClass26 gClass4 = new GClass26(int_0, method_2(int_0), 1);
				gClass4.method_0(5, 20, -2);
				gClass4.method_0(7, 15, 2);
				gClass4.method_2(string.Empty);
				gClass4.method_4(Class16.smethod_0(-561796187));
				return gClass4;
			}
			case 103:
			{
				GClass40 gClass3 = new GClass40(int_0, method_2(int_0), 1);
				gClass3.method_0(1, 10, 2);
				gClass3.method_0(3, 10, -2);
				gClass3.method_0(4, 10, -2);
				gClass3.method_8(8);
				gClass3.method_2(string.Empty);
				return gClass3;
			}
			case 104:
			{
				GClass19 gClass2 = new GClass19(int_0, method_2(int_0), 0);
				gClass2.method_8(13);
				gClass2.method_2(string.Empty);
				gClass2.method_4(Class16.smethod_0(-561796108));
				return gClass2;
			}
			case 105:
			{
				GClass62 gClass = new GClass62(int_0, method_2(int_0), 3);
				gClass.method_0(0, 26, 2);
				gClass.method_0(1, 26, 2);
				gClass.method_0(3, 26, 1);
				gClass.method_0(4, 6, 0);
				gClass.method_8(12);
				gClass.method_8(5);
				gClass.method_2(string.Empty);
				gClass.method_4(Class16.smethod_0(-561796554));
				return gClass;
			}
			}
			int_0 = -1;
		}
	}
}
