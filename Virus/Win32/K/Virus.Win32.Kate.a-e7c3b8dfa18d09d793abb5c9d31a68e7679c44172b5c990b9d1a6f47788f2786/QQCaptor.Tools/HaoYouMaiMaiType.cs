using System.Collections.ObjectModel;

namespace QQCaptor.Tools;

internal class HaoYouMaiMaiType
{
	public Collection<HaoYouTypeInfo> m_QingAnList = new Collection<HaoYouTypeInfo>();

	public Collection<HaoYouTypeInfo> m_ZheMoList = new Collection<HaoYouTypeInfo>();

	public Collection<HaoYouTypeInfo> m_AnFuList = new Collection<HaoYouTypeInfo>();

	public string GetState(string sType)
	{
		string result = "";
		foreach (HaoYouTypeInfo zheMo in m_ZheMoList)
		{
			if (sType == zheMo.strAid)
			{
				return zheMo.strConten;
			}
		}
		return result;
	}

	public HaoYouMaiMaiType()
	{
		HaoYouTypeInfo item = new HaoYouTypeInfo
		{
			strConten = "智能选择讨好方式",
			strAid = "0"
		};
		m_QingAnList.Add(item);
		HaoYouTypeInfo item2 = new HaoYouTypeInfo
		{
			strConten = "把主人夸晕",
			strAid = "512"
		};
		m_QingAnList.Add(item2);
		HaoYouTypeInfo item3 = new HaoYouTypeInfo
		{
			strConten = "给主人请安",
			strAid = "513"
		};
		m_QingAnList.Add(item3);
		HaoYouTypeInfo item4 = new HaoYouTypeInfo
		{
			strConten = "给主人揉腿",
			strAid = "514"
		};
		m_QingAnList.Add(item4);
		HaoYouTypeInfo item5 = new HaoYouTypeInfo
		{
			strConten = "给主人唱小曲",
			strAid = "515"
		};
		m_QingAnList.Add(item5);
		HaoYouTypeInfo item6 = new HaoYouTypeInfo
		{
			strConten = "给主人跳肚皮舞",
			strAid = "516"
		};
		m_QingAnList.Add(item6);
		HaoYouTypeInfo item7 = new HaoYouTypeInfo
		{
			strConten = "帮主人洗内衣裤",
			strAid = "517"
		};
		m_QingAnList.Add(item7);
		HaoYouTypeInfo item8 = new HaoYouTypeInfo
		{
			strConten = "向主人表白",
			strAid = "518"
		};
		m_QingAnList.Add(item8);
		HaoYouTypeInfo item9 = new HaoYouTypeInfo
		{
			strConten = "狠狠亲主人一口",
			strAid = "519"
		};
		m_QingAnList.Add(item9);
		HaoYouTypeInfo item10 = new HaoYouTypeInfo
		{
			strConten = "使用QQ影音观赏大片",
			strAid = "520"
		};
		m_QingAnList.Add(item10);
		HaoYouTypeInfo item11 = new HaoYouTypeInfo
		{
			strConten = "智能选择折磨方式",
			strAid = "0"
		};
		m_ZheMoList.Add(item11);
		HaoYouTypeInfo item12 = new HaoYouTypeInfo
		{
			strConten = "一顿臭骂",
			strAid = "25"
		};
		m_ZheMoList.Add(item12);
		HaoYouTypeInfo item13 = new HaoYouTypeInfo
		{
			strConten = "拿板砖拍晕",
			strAid = "22"
		};
		m_ZheMoList.Add(item13);
		HaoYouTypeInfo item14 = new HaoYouTypeInfo
		{
			strConten = "去黑煤窖挖煤/去做家教",
			strAid = "16"
		};
		m_ZheMoList.Add(item14);
		HaoYouTypeInfo item15 = new HaoYouTypeInfo
		{
			strConten = "去挑大粪/去歌厅唱歌",
			strAid = "17"
		};
		m_ZheMoList.Add(item15);
		HaoYouTypeInfo item16 = new HaoYouTypeInfo
		{
			strConten = "去扫厕所/去当小保姆",
			strAid = "18"
		};
		m_ZheMoList.Add(item16);
		HaoYouTypeInfo item17 = new HaoYouTypeInfo
		{
			strConten = "去当小摊贩",
			strAid = "19"
		};
		m_ZheMoList.Add(item17);
		HaoYouTypeInfo item18 = new HaoYouTypeInfo
		{
			strConten = "去广场裸奔",
			strAid = "20"
		};
		m_ZheMoList.Add(item18);
		HaoYouTypeInfo item19 = new HaoYouTypeInfo
		{
			strConten = "挖个坑活埋",
			strAid = "21"
		};
		m_ZheMoList.Add(item19);
		HaoYouTypeInfo item20 = new HaoYouTypeInfo
		{
			strConten = "饿个三天三夜",
			strAid = "23"
		};
		m_ZheMoList.Add(item20);
		HaoYouTypeInfo item21 = new HaoYouTypeInfo
		{
			strConten = "绑在柱子上拿鞭子抽/给我跳一段钢管舞",
			strAid = "24"
		};
		m_ZheMoList.Add(item21);
		HaoYouTypeInfo item22 = new HaoYouTypeInfo
		{
			strConten = "派去学习充电",
			strAid = "29"
		};
		m_ZheMoList.Add(item22);
		HaoYouTypeInfo item23 = new HaoYouTypeInfo
		{
			strConten = "去为感冒病人体检",
			strAid = "27"
		};
		m_ZheMoList.Add(item23);
		HaoYouTypeInfo item24 = new HaoYouTypeInfo
		{
			strConten = "去送外卖",
			strAid = "28"
		};
		m_ZheMoList.Add(item24);
		HaoYouTypeInfo item25 = new HaoYouTypeInfo
		{
			strConten = "去扫马路",
			strAid = "30"
		};
		m_ZheMoList.Add(item25);
		HaoYouTypeInfo item26 = new HaoYouTypeInfo
		{
			strConten = "派去参加惠普“抢1行动”\u3000",
			strAid = "31"
		};
		m_ZheMoList.Add(item26);
		HaoYouTypeInfo item27 = new HaoYouTypeInfo
		{
			strConten = "智能选择安抚方式",
			strAid = "0"
		};
		m_AnFuList.Add(item27);
		HaoYouTypeInfo item28 = new HaoYouTypeInfo
		{
			strConten = "赏一根骨头",
			strAid = "256"
		};
		m_AnFuList.Add(item28);
		HaoYouTypeInfo item29 = new HaoYouTypeInfo
		{
			strConten = "请奴隶吃零食",
			strAid = "257"
		};
		m_AnFuList.Add(item29);
		HaoYouTypeInfo item30 = new HaoYouTypeInfo
		{
			strConten = "陪奴隶看电视",
			strAid = "258"
		};
		m_AnFuList.Add(item30);
		HaoYouTypeInfo item31 = new HaoYouTypeInfo
		{
			strConten = "给奴隶讲故事",
			strAid = "259"
		};
		m_AnFuList.Add(item31);
		HaoYouTypeInfo item32 = new HaoYouTypeInfo
		{
			strConten = "带去超市购物",
			strAid = "260"
		};
		m_AnFuList.Add(item32);
		HaoYouTypeInfo item33 = new HaoYouTypeInfo
		{
			strConten = "给一个幸福的拥抱",
			strAid = "261"
		};
		m_AnFuList.Add(item33);
		HaoYouTypeInfo item34 = new HaoYouTypeInfo
		{
			strConten = "开车去兜风",
			strAid = "262"
		};
		m_AnFuList.Add(item34);
		HaoYouTypeInfo item35 = new HaoYouTypeInfo
		{
			strConten = "共进烛光晚餐",
			strAid = "263"
		};
		m_AnFuList.Add(item35);
		HaoYouTypeInfo item36 = new HaoYouTypeInfo
		{
			strConten = "去欧洲十国游",
			strAid = "264"
		};
		m_AnFuList.Add(item36);
		HaoYouTypeInfo item37 = new HaoYouTypeInfo
		{
			strConten = "一起泡温泉",
			strAid = "265"
		};
		m_AnFuList.Add(item37);
		HaoYouTypeInfo item38 = new HaoYouTypeInfo
		{
			strConten = "去游乐场玩",
			strAid = "267"
		};
		m_AnFuList.Add(item38);
		HaoYouTypeInfo item39 = new HaoYouTypeInfo
		{
			strConten = "去参加选秀",
			strAid = "268"
		};
		m_AnFuList.Add(item39);
		HaoYouTypeInfo item40 = new HaoYouTypeInfo
		{
			strConten = "赏赐一台联想ideapad U350笔记",
			strAid = "269"
		};
		m_AnFuList.Add(item40);
		HaoYouTypeInfo item41 = new HaoYouTypeInfo
		{
			strConten = "送一台惠普电脑",
			strAid = "270"
		};
		m_AnFuList.Add(item41);
	}

	public void GetType(string sNum, out string sTaoHao, out string sAnFu, out string sZheMo)
	{
		sTaoHao = "";
		sAnFu = "";
		sZheMo = "";
		switch (sNum)
		{
		case "1":
			sTaoHao = "512";
			sAnFu = "258";
			sZheMo = "16";
			break;
		case "2":
			sTaoHao = "515";
			sAnFu = "259";
			sZheMo = "17";
			break;
		case "3":
			sTaoHao = "516";
			sAnFu = "260";
			sZheMo = "18";
			break;
		case "4":
			sTaoHao = "517";
			sAnFu = "261";
			sZheMo = "19";
			break;
		case "5":
			sTaoHao = "518";
			sAnFu = "262";
			sZheMo = "20";
			break;
		case "6":
			sTaoHao = "519";
			sAnFu = "263";
			sZheMo = "20";
			break;
		case "7":
			sTaoHao = "520";
			sAnFu = "264";
			sZheMo = "20";
			break;
		case "8":
			sTaoHao = "520";
			sAnFu = "265";
			sZheMo = "20";
			break;
		case "9":
			sTaoHao = "520";
			sAnFu = "267";
			sZheMo = "29";
			break;
		case "10":
			sTaoHao = "520";
			sAnFu = "268";
			sZheMo = "27";
			break;
		case "11":
			sTaoHao = "520";
			sAnFu = "269";
			sZheMo = "28";
			break;
		case "12":
			sTaoHao = "520";
			sAnFu = "270";
			sZheMo = "30";
			break;
		default:
			sTaoHao = "520";
			sAnFu = "270";
			sZheMo = "31";
			break;
		}
	}
}
