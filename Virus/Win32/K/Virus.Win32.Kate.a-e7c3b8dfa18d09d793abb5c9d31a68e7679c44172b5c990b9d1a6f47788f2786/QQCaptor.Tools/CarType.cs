using System.Collections.ObjectModel;

namespace QQCaptor.Tools;

internal class CarType
{
	public string[] carColor = new string[7] { "黑色", "白色", "灰色", "蓝色", "红色", "黄色", "绿色" };

	public string[] CarFirstType = new string[8] { "代步车", "普通私家车", "精致私家车", "高级私家车", "酷车一族", "高级车", "尊贵车", "贵族车" };

	public Collection<CarTypeInfo> m_CarTypeList = new Collection<CarTypeInfo>();

	public int GetCount()
	{
		return m_CarTypeList.Count;
	}

	public int GetColorCount()
	{
		return 7;
	}

	public string GetColorName(int index)
	{
		if (index >= 7)
		{
			return null;
		}
		return carColor[index];
	}

	public int GetTypeCount()
	{
		return 8;
	}

	public string GetTypeName(int index)
	{
		if (index >= 8)
		{
			return null;
		}
		return CarFirstType[index];
	}

	public CarTypeInfo GetCarTypeInfoByIndex(int index)
	{
		if (index >= m_CarTypeList.Count)
		{
			return null;
		}
		return m_CarTypeList[index];
	}

	public CarTypeInfo GetCarTypeInfo(int code)
	{
		foreach (CarTypeInfo carType in m_CarTypeList)
		{
			if (code == carType.code)
			{
				return carType;
			}
		}
		return null;
	}

	public int GetCarIndex(int code)
	{
		int num = 0;
		foreach (CarTypeInfo carType in m_CarTypeList)
		{
			if (code != carType.code)
			{
				num++;
				continue;
			}
			return num;
		}
		return -1;
	}

	public int GetCountByType(int type)
	{
		int num = 0;
		foreach (CarTypeInfo carType in m_CarTypeList)
		{
			if (type == carType.type)
			{
				num++;
			}
		}
		return num;
	}

	public CarTypeInfo GetCarTypeInfoByType(int type, int iIndex)
	{
		int num = 0;
		foreach (CarTypeInfo carType in m_CarTypeList)
		{
			if (type == carType.type)
			{
				if (num == iIndex)
				{
					return carType;
				}
				num++;
			}
		}
		return null;
	}

	public CarType()
	{
		CarTypeInfo item = new CarTypeInfo
		{
			code = 34,
			CarName = "二手奥拓",
			MinuteMoney = 5,
			CarPrice = 16000,
			type = 1,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item);
		CarTypeInfo item2 = new CarTypeInfo
		{
			code = 35,
			CarName = "江南奥拓",
			MinuteMoney = 6,
			CarPrice = 25000,
			type = 1,
			sColorType = "黑色白色灰色蓝色红色黄色绿色"
		};
		m_CarTypeList.Add(item2);
		CarTypeInfo item3 = new CarTypeInfo
		{
			code = 36,
			CarName = "夏利",
			MinuteMoney = 6,
			CarPrice = 32000,
			type = 1,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item3);
		CarTypeInfo item4 = new CarTypeInfo
		{
			code = 37,
			CarName = "奇瑞QQ",
			MinuteMoney = 7,
			CarPrice = 36000,
			type = 1,
			sColorType = "黑色白色灰色蓝色红色黄色"
		};
		m_CarTypeList.Add(item4);
		CarTypeInfo item5 = new CarTypeInfo
		{
			code = 38,
			CarName = "spark乐驰",
			MinuteMoney = 8,
			CarPrice = 45800,
			type = 1,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item5);
		CarTypeInfo item6 = new CarTypeInfo
		{
			code = 39,
			CarName = "吉利自由舰",
			MinuteMoney = 9,
			CarPrice = 48000,
			type = 1,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item6);
		CarTypeInfo item7 = new CarTypeInfo
		{
			code = 7,
			CarName = "富康",
			MinuteMoney = 10,
			CarPrice = 62000,
			type = 2,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item7);
		CarTypeInfo item8 = new CarTypeInfo
		{
			code = 40,
			CarName = "雨燕",
			MinuteMoney = 11,
			CarPrice = 69000,
			type = 2,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item8);
		CarTypeInfo item9 = new CarTypeInfo
		{
			code = 41,
			CarName = "标志206",
			MinuteMoney = 11,
			CarPrice = 78000,
			type = 2,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item9);
		CarTypeInfo item10 = new CarTypeInfo
		{
			code = 79,
			CarName = "雪铁龙C2",
			MinuteMoney = 12,
			CarPrice = 79000,
			type = 2,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item10);
		CarTypeInfo item11 = new CarTypeInfo
		{
			code = 9,
			CarName = "名爵3SW",
			MinuteMoney = 12,
			CarPrice = 79800,
			type = 2,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item11);
		CarTypeInfo item12 = new CarTypeInfo
		{
			code = 10,
			CarName = "桑塔纳",
			MinuteMoney = 13,
			CarPrice = 80000,
			type = 2,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item12);
		CarTypeInfo item13 = new CarTypeInfo
		{
			code = 22,
			CarName = "POLO",
			MinuteMoney = 14,
			CarPrice = 91000,
			type = 2,
			sColorType = "黑色白色蓝色黄色绿色"
		};
		m_CarTypeList.Add(item13);
		CarTypeInfo item14 = new CarTypeInfo
		{
			code = 43,
			CarName = "福田欧马可",
			MinuteMoney = 14,
			CarPrice = 98800,
			type = 2,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item14);
		CarTypeInfo item15 = new CarTypeInfo
		{
			code = 11,
			CarName = "别克凯越",
			MinuteMoney = 14,
			CarPrice = 105000,
			type = 2,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item15);
		CarTypeInfo item16 = new CarTypeInfo
		{
			code = 77,
			CarName = "标志307",
			MinuteMoney = 15,
			CarPrice = 110000,
			type = 3,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item16);
		CarTypeInfo item17 = new CarTypeInfo
		{
			code = 23,
			CarName = "宝来",
			MinuteMoney = 15,
			CarPrice = 116000,
			type = 3,
			sColorType = "黑色灰色蓝色红色"
		};
		m_CarTypeList.Add(item17);
		CarTypeInfo item18 = new CarTypeInfo
		{
			code = 44,
			CarName = "赛拉图",
			MinuteMoney = 15,
			CarPrice = 127800,
			type = 3,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item18);
		CarTypeInfo item19 = new CarTypeInfo
		{
			code = 24,
			CarName = "福特福克斯",
			MinuteMoney = 15,
			CarPrice = 128000,
			type = 3,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item19);
		CarTypeInfo item20 = new CarTypeInfo
		{
			code = 3,
			CarName = "飞度",
			MinuteMoney = 15,
			CarPrice = 129800,
			type = 3,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item20);
		CarTypeInfo item21 = new CarTypeInfo
		{
			code = 25,
			CarName = "卡罗拉",
			MinuteMoney = 15,
			CarPrice = 132000,
			type = 3,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item21);
		CarTypeInfo item22 = new CarTypeInfo
		{
			code = 26,
			CarName = "速腾",
			MinuteMoney = 15,
			CarPrice = 138000,
			type = 3,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item22);
		CarTypeInfo item23 = new CarTypeInfo
		{
			code = 30,
			CarName = "高尔夫",
			MinuteMoney = 15,
			CarPrice = 139000,
			type = 3,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item23);
		CarTypeInfo item24 = new CarTypeInfo
		{
			code = 12,
			CarName = "斯柯达明锐",
			MinuteMoney = 15,
			CarPrice = 139800,
			type = 3,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item24);
		CarTypeInfo item25 = new CarTypeInfo
		{
			code = 13,
			CarName = "本田CIVIC",
			MinuteMoney = 15,
			CarPrice = 140000,
			type = 3,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item25);
		CarTypeInfo item26 = new CarTypeInfo
		{
			code = 31,
			CarName = "骐达",
			MinuteMoney = 15,
			CarPrice = 149800,
			type = 3,
			sColorType = "黑色白色蓝色红色黄色"
		};
		m_CarTypeList.Add(item26);
		CarTypeInfo item27 = new CarTypeInfo
		{
			code = 89,
			CarName = "Smart",
			MinuteMoney = 16,
			CarPrice = 150000,
			type = 4,
			sColorType = "黑色白色灰色蓝色红色",
			sZsType = "1"
		};
		m_CarTypeList.Add(item27);
		CarTypeInfo item28 = new CarTypeInfo
		{
			code = 32,
			CarName = "朗逸",
			MinuteMoney = 15,
			CarPrice = 152000,
			type = 3,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item28);
		CarTypeInfo item29 = new CarTypeInfo
		{
			code = 6,
			CarName = "新毕加索",
			MinuteMoney = 16,
			CarPrice = 157800,
			type = 4,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item29);
		CarTypeInfo item30 = new CarTypeInfo
		{
			code = 33,
			CarName = "马自达6",
			MinuteMoney = 16,
			CarPrice = 178000,
			type = 4,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item30);
		CarTypeInfo item31 = new CarTypeInfo
		{
			code = 45,
			CarName = "帕萨特",
			MinuteMoney = 16,
			CarPrice = 186000,
			type = 4,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item31);
		CarTypeInfo item32 = new CarTypeInfo
		{
			code = 46,
			CarName = "现代酷派",
			MinuteMoney = 16,
			CarPrice = 190000,
			type = 4,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item32);
		CarTypeInfo item33 = new CarTypeInfo
		{
			code = 47,
			CarName = "迈腾",
			MinuteMoney = 16,
			CarPrice = 198000,
			type = 4,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item33);
		CarTypeInfo item34 = new CarTypeInfo
		{
			code = 14,
			CarName = "雅阁",
			MinuteMoney = 16,
			CarPrice = 199000,
			type = 4,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item34);
		CarTypeInfo item35 = new CarTypeInfo
		{
			code = 87,
			CarName = "Chevrolet Camaro",
			MinuteMoney = 18,
			CarPrice = 210000,
			type = 5,
			sColorType = "黑色白色灰色蓝色红色黄色",
			sZsType = "2"
		};
		m_CarTypeList.Add(item35);
		CarTypeInfo item36 = new CarTypeInfo
		{
			code = 48,
			CarName = "S-MAX",
			MinuteMoney = 18,
			CarPrice = 219800,
			type = 5,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item36);
		CarTypeInfo item37 = new CarTypeInfo
		{
			code = 49,
			CarName = "斯巴鲁翼豹",
			MinuteMoney = 18,
			CarPrice = 239800,
			type = 5,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item37);
		CarTypeInfo item38 = new CarTypeInfo
		{
			code = 15,
			CarName = "蒙迪欧致胜",
			MinuteMoney = 18,
			CarPrice = 239900,
			type = 5,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item38);
		CarTypeInfo item39 = new CarTypeInfo
		{
			code = 21,
			CarName = "本田CRV",
			MinuteMoney = 18,
			CarPrice = 240000,
			type = 5,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item39);
		CarTypeInfo item40 = new CarTypeInfo
		{
			code = 16,
			CarName = "PT漫步者",
			MinuteMoney = 18,
			CarPrice = 241000,
			type = 5,
			sColorType = "黑色白色灰色黄色"
		};
		m_CarTypeList.Add(item40);
		CarTypeInfo item41 = new CarTypeInfo
		{
			code = 50,
			CarName = "途胜",
			MinuteMoney = 18,
			CarPrice = 241800,
			type = 5,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item41);
		CarTypeInfo item42 = new CarTypeInfo
		{
			code = 17,
			CarName = "甲壳虫",
			MinuteMoney = 18,
			CarPrice = 250000,
			type = 5,
			sColorType = "白色蓝色红色黄色绿色"
		};
		m_CarTypeList.Add(item42);
		CarTypeInfo item43 = new CarTypeInfo
		{
			code = 18,
			CarName = "奥迪A4",
			MinuteMoney = 18,
			CarPrice = 280000,
			type = 5,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item43);
		CarTypeInfo item44 = new CarTypeInfo
		{
			code = 51,
			CarName = "指南者",
			MinuteMoney = 18,
			CarPrice = 290000,
			type = 5,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item44);
		CarTypeInfo item45 = new CarTypeInfo
		{
			code = 52,
			CarName = "哈雷摩托",
			MinuteMoney = 18,
			CarPrice = 300000,
			type = 5,
			sColorType = "黑色白色"
		};
		m_CarTypeList.Add(item45);
		CarTypeInfo item46 = new CarTypeInfo
		{
			code = 4,
			CarName = "Mini Cooper",
			MinuteMoney = 20,
			CarPrice = 320000,
			type = 6,
			sColorType = "黑色白色灰色蓝色红色黄色绿色"
		};
		m_CarTypeList.Add(item46);
		CarTypeInfo item47 = new CarTypeInfo
		{
			code = 53,
			CarName = "宝马320",
			MinuteMoney = 20,
			CarPrice = 330000,
			type = 6,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item47);
		CarTypeInfo item48 = new CarTypeInfo
		{
			code = 54,
			CarName = "切诺基",
			MinuteMoney = 21,
			CarPrice = 420000,
			type = 6,
			sColorType = "黑色白色蓝色黄色绿色"
		};
		m_CarTypeList.Add(item48);
		CarTypeInfo item49 = new CarTypeInfo
		{
			code = 65,
			CarName = "牧马人",
			MinuteMoney = 22,
			CarPrice = 525000,
			type = 6,
			sColorType = "黑色白色灰色蓝色红色绿色"
		};
		m_CarTypeList.Add(item49);
		CarTypeInfo item50 = new CarTypeInfo
		{
			code = 27,
			CarName = "宝马Z4",
			MinuteMoney = 23,
			CarPrice = 568000,
			type = 6,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item50);
		CarTypeInfo item51 = new CarTypeInfo
		{
			code = 19,
			CarName = "奥迪A6",
			MinuteMoney = 24,
			CarPrice = 620000,
			type = 6,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item51);
		CarTypeInfo item52 = new CarTypeInfo
		{
			code = 28,
			CarName = "奥迪TT",
			MinuteMoney = 24,
			CarPrice = 645000,
			type = 6,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item52);
		CarTypeInfo item53 = new CarTypeInfo
		{
			code = 66,
			CarName = "悍马",
			MinuteMoney = 25,
			CarPrice = 800000,
			type = 6,
			sColorType = "黑色白色灰色蓝色红色黄色"
		};
		m_CarTypeList.Add(item53);
		CarTypeInfo item54 = new CarTypeInfo
		{
			code = 20,
			CarName = "凯迪拉克",
			MinuteMoney = 25,
			CarPrice = 878000,
			type = 6,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item54);
		CarTypeInfo item55 = new CarTypeInfo
		{
			code = 83,
			CarName = "FIAT500",
			MinuteMoney = 26,
			CarPrice = 900000,
			type = 7,
			sColorType = "黑色白色灰色蓝色红色",
			sZsType = "3"
		};
		m_CarTypeList.Add(item55);
		CarTypeInfo item56 = new CarTypeInfo
		{
			code = 29,
			CarName = "宝马730",
			MinuteMoney = 26,
			CarPrice = 1080000,
			type = 7,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item56);
		CarTypeInfo item57 = new CarTypeInfo
		{
			code = 74,
			CarName = "沃尔沃XC90",
			MinuteMoney = 26,
			CarPrice = 1168000,
			type = 7,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item57);
		CarTypeInfo item58 = new CarTypeInfo
		{
			code = 90,
			CarName = "MUSTANG GT",
			MinuteMoney = 27,
			CarPrice = 1200000,
			type = 7,
			sColorType = "黑色白色灰色蓝色红色",
			sZsType = "4"
		};
		m_CarTypeList.Add(item58);
		CarTypeInfo item59 = new CarTypeInfo
		{
			code = 76,
			CarName = "奥迪Q7",
			MinuteMoney = 27,
			CarPrice = 1232000,
			type = 7,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item59);
		CarTypeInfo item60 = new CarTypeInfo
		{
			code = 67,
			CarName = "路虎",
			MinuteMoney = 27,
			CarPrice = 1280000,
			type = 7,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item60);
		CarTypeInfo item61 = new CarTypeInfo
		{
			code = 68,
			CarName = "宝马X5",
			MinuteMoney = 27,
			CarPrice = 1336000,
			type = 7,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item61);
		CarTypeInfo item62 = new CarTypeInfo
		{
			code = 69,
			CarName = "林肯加长",
			MinuteMoney = 27,
			CarPrice = 1380000,
			type = 7,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item62);
		CarTypeInfo item63 = new CarTypeInfo
		{
			code = 92,
			CarName = "Lancer Evolution X",
			MinuteMoney = 28,
			CarPrice = 1500000,
			type = 8,
			sColorType = "黑色白色灰色蓝色红色",
			sZsType = "5"
		};
		m_CarTypeList.Add(item63);
		CarTypeInfo item64 = new CarTypeInfo
		{
			code = 55,
			CarName = "保时捷911",
			MinuteMoney = 28,
			CarPrice = 1510000,
			type = 8,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item64);
		CarTypeInfo item65 = new CarTypeInfo
		{
			code = 70,
			CarName = "RIMOR奔驰房车",
			MinuteMoney = 28,
			CarPrice = 1510000,
			type = 8,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item65);
		CarTypeInfo item66 = new CarTypeInfo
		{
			code = 71,
			CarName = "保时捷卡宴",
			MinuteMoney = 28,
			CarPrice = 1520000,
			type = 8,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item66);
		CarTypeInfo item67 = new CarTypeInfo
		{
			code = 56,
			CarName = "捷豹XK",
			MinuteMoney = 28,
			CarPrice = 1540000,
			type = 8,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item67);
		CarTypeInfo item68 = new CarTypeInfo
		{
			code = 72,
			CarName = "途锐",
			MinuteMoney = 28,
			CarPrice = 1580000,
			type = 8,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item68);
		CarTypeInfo item69 = new CarTypeInfo
		{
			code = 80,
			CarName = "雷克萨斯LS600",
			MinuteMoney = 28,
			CarPrice = 1598000,
			type = 8,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item69);
		CarTypeInfo item70 = new CarTypeInfo
		{
			code = 57,
			CarName = "奥迪R8",
			MinuteMoney = 28,
			CarPrice = 1599000,
			type = 8,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item70);
		CarTypeInfo item71 = new CarTypeInfo
		{
			code = 84,
			CarName = "SEAT LEON",
			MinuteMoney = 29,
			CarPrice = 1690000,
			type = 8,
			sColorType = "黑色白色灰色蓝色红色",
			sZsType = "6"
		};
		m_CarTypeList.Add(item71);
		CarTypeInfo item72 = new CarTypeInfo
		{
			code = 93,
			CarName = "NISSAN GTR",
			MinuteMoney = 30,
			CarPrice = 1800000,
			type = 8,
			sColorType = "黑色白色灰色蓝色红色",
			sZsType = "7"
		};
		m_CarTypeList.Add(item72);
		CarTypeInfo item73 = new CarTypeInfo
		{
			code = 5,
			CarName = "玛莎拉蒂",
			MinuteMoney = 30,
			CarPrice = 1900000,
			type = 8,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item73);
		CarTypeInfo item74 = new CarTypeInfo
		{
			code = 78,
			CarName = "奔驰S600",
			MinuteMoney = 30,
			CarPrice = 2000000,
			type = 8,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item74);
		CarTypeInfo item75 = new CarTypeInfo
		{
			code = 73,
			CarName = "奔驰豪华大巴",
			MinuteMoney = 30,
			CarPrice = 2500000,
			type = 8,
			sColorType = "黑色白色蓝色红色黄色绿色"
		};
		m_CarTypeList.Add(item75);
		CarTypeInfo item76 = new CarTypeInfo
		{
			code = 91,
			CarName = "Honda NSX GT",
			MinuteMoney = 31,
			CarPrice = 3000000,
			type = 8,
			sColorType = "黑色白色灰色蓝色红色",
			sZsType = "8"
		};
		m_CarTypeList.Add(item76);
		CarTypeInfo item77 = new CarTypeInfo
		{
			code = 58,
			CarName = "法拉利F430",
			MinuteMoney = 31,
			CarPrice = 3200000,
			type = 8,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item77);
		CarTypeInfo item78 = new CarTypeInfo
		{
			code = 94,
			CarName = "Continental GTC",
			MinuteMoney = 32,
			CarPrice = 3400000,
			type = 8,
			sColorType = "黑色白色灰色蓝色红色",
			sZsType = "9"
		};
		m_CarTypeList.Add(item78);
		CarTypeInfo item79 = new CarTypeInfo
		{
			code = 59,
			CarName = "阿斯顿马丁",
			MinuteMoney = 32,
			CarPrice = 3620000,
			type = 8,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item79);
		CarTypeInfo item80 = new CarTypeInfo
		{
			code = 8,
			CarName = "兰博基尼",
			MinuteMoney = 32,
			CarPrice = 3890000,
			type = 8,
			sColorType = "黑色白色灰色红色黄色"
		};
		m_CarTypeList.Add(item80);
		CarTypeInfo item81 = new CarTypeInfo
		{
			code = 82,
			CarName = "McLaren_F1",
			MinuteMoney = 33,
			CarPrice = 5200000,
			type = 8,
			sColorType = "黑色白色灰色红色黄色",
			sZsType = "10"
		};
		m_CarTypeList.Add(item81);
		CarTypeInfo item82 = new CarTypeInfo
		{
			code = 60,
			CarName = "迈巴赫62",
			MinuteMoney = 34,
			CarPrice = 6180000,
			type = 8,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item82);
		CarTypeInfo item83 = new CarTypeInfo
		{
			code = 61,
			CarName = "劳斯莱斯",
			MinuteMoney = 34,
			CarPrice = 6200000,
			type = 8,
			sColorType = "黑色白色灰色蓝色红色"
		};
		m_CarTypeList.Add(item83);
		CarTypeInfo item84 = new CarTypeInfo
		{
			code = 95,
			CarName = "Spyker C8",
			MinuteMoney = 35,
			CarPrice = 7000000,
			type = 8,
			sColorType = "黑色白色灰色蓝色红色",
			sZsType = "11"
		};
		m_CarTypeList.Add(item84);
		CarTypeInfo item85 = new CarTypeInfo
		{
			code = 98,
			CarName = "Lotus 2 Eleven",
			MinuteMoney = 36,
			CarPrice = 10000000,
			type = 8,
			sColorType = "黑色白色灰色蓝色红色",
			sZsType = "12"
		};
		m_CarTypeList.Add(item85);
		CarTypeInfo item86 = new CarTypeInfo
		{
			code = 62,
			CarName = "帕加尼",
			MinuteMoney = 36,
			CarPrice = 12990000,
			type = 8,
			sColorType = "黑色白色灰色蓝色红色黄色绿色"
		};
		m_CarTypeList.Add(item86);
		CarTypeInfo item87 = new CarTypeInfo
		{
			code = 96,
			CarName = "Ferrari Enzo",
			MinuteMoney = 37,
			CarPrice = 13000000,
			type = 8,
			sColorType = "黑色白色灰色蓝色红色",
			sZsType = "13"
		};
		m_CarTypeList.Add(item87);
		CarTypeInfo item88 = new CarTypeInfo
		{
			code = 99,
			CarName = "Edonis BEX38",
			MinuteMoney = 38,
			CarPrice = 13500000,
			type = 8,
			sColorType = "黑色白色灰色蓝色红色",
			sZsType = "14"
		};
		m_CarTypeList.Add(item88);
		CarTypeInfo item89 = new CarTypeInfo
		{
			code = 75,
			CarName = "雅致728",
			MinuteMoney = 38,
			CarPrice = 13880000,
			type = 8,
			sColorType = "黑色白色灰色蓝色红色黄色绿色"
		};
		m_CarTypeList.Add(item89);
		CarTypeInfo item90 = new CarTypeInfo
		{
			code = 97,
			CarName = "Spyker C12",
			MinuteMoney = 39,
			CarPrice = 20000000,
			type = 8,
			sColorType = "黑色白色灰色蓝色红色",
			sZsType = "15"
		};
		m_CarTypeList.Add(item90);
		CarTypeInfo item91 = new CarTypeInfo
		{
			code = 63,
			CarName = "布加迪威龙",
			MinuteMoney = 40,
			CarPrice = 25000000,
			type = 8,
			sColorType = "黑色红色"
		};
		m_CarTypeList.Add(item91);
		CarTypeInfo item92 = new CarTypeInfo
		{
			code = 64,
			CarName = "布加迪威航",
			MinuteMoney = 50,
			CarPrice = 43000000,
			type = 8,
			sColorType = "黑色白色黄色"
		};
		m_CarTypeList.Add(item92);
	}
}
