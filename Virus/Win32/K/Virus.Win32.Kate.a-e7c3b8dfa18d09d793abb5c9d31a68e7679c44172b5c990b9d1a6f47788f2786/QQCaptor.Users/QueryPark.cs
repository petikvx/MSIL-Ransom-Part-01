using System;
using System.Collections.ObjectModel;
using Helper;
using QQCaptor.Tools;

namespace QQCaptor.Users;

internal class QueryPark
{
	private User m_use;

	private string m_SelfNick = "";

	private int m_iSelfMoney;

	private int m_iHaveCarNum;

	private string m_StartGameTime = "";

	public Collection<ParkInfo> m_parkInfoList = new Collection<ParkInfo>();

	public Collection<ParkInfo> m_parkInfoListJB = new Collection<ParkInfo>();

	public int m_iEmptyNum;

	public int m_ilastLogin = -1;

	public int m_iLoveColor = 1;

	public string m_sDengji = "";

	public string m_sJinYan = "";

	public QueryPark()
	{
	}

	public QueryPark(User use)
	{
		m_use = use;
	}

	public string GetQQNick(string sQQNum)
	{
		m_use.LingQuJiangJin();
		string url = "http://world.show.qq.com/cgi-bin/parker_user_front?uin=" + sQQNum;
		string text = m_use.m_hh.Get(url, null);
		if (!(text == string.Empty) && text != null)
		{
			string text2 = null;
			int num = text.IndexOf(" nick=", 0);
			if (num == -1)
			{
				return null;
			}
			int num2 = text.IndexOf(" money=", num);
			if (num != -1 && num2 != -1)
			{
				num += 7;
				string strInput = text.Substring(num, num2 - num - 1);
				return StringChar.ChinaUnicodeToASCII(strInput);
			}
			return null;
		}
		return null;
	}

	public void QueryParkerInfoForActive(string sQQNumPark)
	{
		string url = "http://world.show.qq.com/cgi-bin/parker_user_front?uin=" + sQQNumPark;
		m_use.m_hh.Get(url, null);
	}

	public void QueryDengJi(string sQQNumPark)
	{
		m_iEmptyNum = 0;
		m_ilastLogin = -1;
		string text = m_use.m_hh.Get("http://world.show.qq.com/cgi-bin/parker_user_front?uin=" + sQQNumPark, null);
		int num = 0;
		int num2 = text.IndexOf(" score=", 0);
		if (num2 == -1)
		{
			return;
		}
		int num3 = text.IndexOf(" lv=", num2);
		if (num2 == -1 || num3 == -1)
		{
			return;
		}
		num2 += 8;
		num = num3;
		string text2 = (m_sJinYan = text.Substring(num2, num3 - num2 - 1));
		num2 = text.IndexOf(" lv=", num);
		if (num2 != -1)
		{
			num3 = text.IndexOf(" regtime=", num2);
			if (num2 != -1 && num3 != -1)
			{
				num2 += 5;
				num = num3;
				text2 = (m_sDengji = text.Substring(num2, num3 - num2 - 1));
			}
		}
	}

	public bool QueryParkerInfo(string sQQNumPark, out bool bPark1, out bool bPark2, out bool bPark3, out bool bPark4)
	{
		m_parkInfoList.Clear();
		m_ilastLogin = -1;
		m_iEmptyNum = 0;
		bPark1 = false;
		bPark2 = false;
		bPark3 = false;
		bPark4 = false;
		Random random = new Random();
		string text = random.NextDouble().ToString();
		string url = "http://world.show.qq.com/cgi-bin/parker_user_front?uin=" + sQQNumPark + "&" + text;
		string text2 = m_use.m_hh.Get(url, null);
		int num = 0;
		int num2 = text2.IndexOf("scene uin=", 0);
		if (num2 == -1)
		{
			return false;
		}
		int num3 = text2.IndexOf(" bg=", num2);
		if (num2 != -1 && num3 != -1)
		{
			num2 += 11;
			num = num3;
			string text3 = text2.Substring(num2, num3 - num2 - 1);
			text3 = text3.Trim();
			sQQNumPark = sQQNumPark.Trim();
			if (sQQNumPark != text3)
			{
				m_SelfNick = "";
				m_iSelfMoney = 0;
				m_iHaveCarNum = 0;
				m_StartGameTime = "";
				return false;
			}
			num2 = text2.IndexOf(" nick=", num);
			if (num2 == -1)
			{
				return false;
			}
			num3 = text2.IndexOf(" money=", num2);
			if (num2 != -1 && num3 != -1)
			{
				num2 += 7;
				num = num3;
				text3 = text2.Substring(num2, num3 - num2 - 1);
				m_SelfNick = StringChar.ChinaUnicodeToASCII(text3);
				num2 = text2.IndexOf(" money=", num);
				if (num2 == -1)
				{
					return false;
				}
				num3 = text2.IndexOf(" carnum=", num2);
				if (num2 != -1 && num3 != -1)
				{
					num2 += 8;
					num = num3;
					text3 = text2.Substring(num2, num3 - num2 - 1);
					m_iSelfMoney = StringChar.SToInt(text3);
					num2 = text2.IndexOf(" carnum=", num);
					if (num2 == -1)
					{
						return false;
					}
					num3 = text2.IndexOf(" score=", num2);
					if (num2 != -1 && num3 != -1)
					{
						num2 += 9;
						num = num3;
						text3 = text2.Substring(num2, num3 - num2 - 1);
						m_iHaveCarNum = StringChar.SToInt(text3);
						num2 = text2.IndexOf(" score=", num);
						if (num2 == -1)
						{
							return false;
						}
						num3 = text2.IndexOf(" lv=", num2);
						if (num2 != -1 && num3 != -1)
						{
							num2 += 8;
							num = num3;
							text3 = (m_sJinYan = text2.Substring(num2, num3 - num2 - 1));
							num2 = text2.IndexOf(" lv=", num);
							if (num2 == -1)
							{
								return false;
							}
							num3 = text2.IndexOf(" regtime=", num2);
							if (num2 != -1 && num3 != -1)
							{
								num2 += 5;
								num = num3;
								text3 = (m_sDengji = text2.Substring(num2, num3 - num2 - 1));
								num2 = text2.IndexOf(" regtime=", num);
								if (num2 == -1)
								{
									return false;
								}
								num3 = text2.IndexOf(" lastlogin=", num2);
								if (num2 != -1 && num3 != -1)
								{
									num2 += 10;
									num = num3;
									text3 = (m_StartGameTime = text2.Substring(num2, num3 - num2 - 1));
									num2 = text2.IndexOf(" lastlogin=", num);
									if (num2 == -1)
									{
										return false;
									}
									num3 = text2.IndexOf(" isDirty=", num2);
									if (num2 != -1 && num3 != -1)
									{
										num2 += 12;
										num = num3;
										text3 = text2.Substring(num2, num3 - num2 - 1);
										m_ilastLogin = StringChar.SToInt(text3);
										num2 = text2.IndexOf(" color=", num);
										if (num2 == -1)
										{
											return false;
										}
										num3 = text2.IndexOf(">", num2);
										if (num2 != -1 && num3 != -1)
										{
											num2 += 8;
											num = num3;
											text3 = text2.Substring(num2, num3 - num2 - 1);
											m_iLoveColor = StringChar.SToInt(text3);
											num = num3;
											int num4 = 1;
											while (true)
											{
												ParkInfo parkInfo = new ParkInfo();
												parkInfo.Id = num4++;
												parkInfo.sParkID = parkInfo.Id.ToString();
												num2 = text2.IndexOf("<owner", num);
												if (num2 == -1)
												{
													break;
												}
												num3 = text2.IndexOf("/owner>", num2);
												if (num2 == -1)
												{
													break;
												}
												m_parkInfoList.Add(parkInfo);
												if (num3 - num2 < 30)
												{
													if (num4 - 1 == 1)
													{
														bPark1 = true;
													}
													else
													{
														m_iEmptyNum++;
														if (num4 - 1 == 2)
														{
															bPark2 = true;
														}
														if (num4 - 1 == 3)
														{
															bPark3 = true;
														}
														if (num4 - 1 == 4)
														{
															bPark4 = true;
														}
													}
													num = num3;
													continue;
												}
												num2 = text2.IndexOf("owner uin=", num);
												if (num2 == -1)
												{
													break;
												}
												num3 = text2.IndexOf(" nick=", num2);
												if (num2 == -1)
												{
													break;
												}
												num2 += 11;
												num = num3;
												text3 = text2.Substring(num2, num3 - num2 - 1);
												parkInfo.sQQNum = text3.Trim();
												num2 = text2.IndexOf(" nick=", num);
												if (num2 == -1)
												{
													break;
												}
												num3 = text2.IndexOf(" getmoney=", num2);
												if (num2 == -1 || num3 == -1)
												{
													break;
												}
												num2 += 7;
												num = num3;
												text3 = text2.Substring(num2, num3 - num2 - 1);
												parkInfo.sQQName = StringChar.ChinaUnicodeToASCII(text3);
												num2 = text2.IndexOf(" getmoney=", num);
												if (num2 == -1)
												{
													break;
												}
												num3 = text2.IndexOf(" carid=", num2);
												if (num2 == -1 || num3 == -1)
												{
													break;
												}
												num2 += 11;
												num = num3;
												text3 = text2.Substring(num2, num3 - num2 - 1);
												parkInfo.iTime = StringChar.SToInt(text3);
												num2 = text2.IndexOf(" carid=", num);
												if (num2 == -1)
												{
													break;
												}
												num3 = text2.IndexOf(" carno=", num2);
												if (num2 == -1 || num3 == -1)
												{
													break;
												}
												num2 += 8;
												num = num3;
												text3 = (parkInfo.sCarNum = text2.Substring(num2, num3 - num2 - 1));
												num2 = text2.IndexOf(" carno=", num);
												if (num2 == -1)
												{
													break;
												}
												num3 = text2.IndexOf(" carcolor=", num2);
												if (num2 == -1 || num3 == -1)
												{
													break;
												}
												num2 += 8;
												num = num3;
												text3 = (parkInfo.sCarName = text2.Substring(num2, num3 - num2 - 1));
											}
											return true;
										}
										return false;
									}
									return false;
								}
								return false;
							}
							return false;
						}
						return false;
					}
					return false;
				}
				return false;
			}
			return false;
		}
		return false;
	}

	public bool QueryParkerInfoJB(string sQQNumPark, out bool bPark1, out bool bPark2, out bool bPark3, out bool bPark4)
	{
		m_parkInfoListJB.Clear();
		m_ilastLogin = -1;
		m_iEmptyNum = 0;
		bPark1 = false;
		bPark2 = false;
		bPark3 = false;
		bPark4 = false;
		Random random = new Random();
		string text = random.NextDouble().ToString();
		string url = "http://world.show.qq.com/cgi-bin/parker_user_front?uin=" + sQQNumPark + "&" + text;
		string text2 = m_use.m_hh.Get(url, null);
		int num = 0;
		int num2 = text2.IndexOf("scene uin=", 0);
		if (num2 == -1)
		{
			return false;
		}
		int num3 = text2.IndexOf(" bg=", num2);
		if (num2 != -1 && num3 != -1)
		{
			num2 += 11;
			num = num3;
			string text3 = text2.Substring(num2, num3 - num2 - 1);
			text3 = text3.Trim();
			sQQNumPark = sQQNumPark.Trim();
			if (sQQNumPark != text3)
			{
				m_SelfNick = "";
				m_iSelfMoney = 0;
				m_iHaveCarNum = 0;
				m_StartGameTime = "";
				return false;
			}
			num2 = text2.IndexOf(" nick=", num);
			if (num2 == -1)
			{
				return false;
			}
			num3 = text2.IndexOf(" money=", num2);
			if (num2 != -1 && num3 != -1)
			{
				num2 += 7;
				num = num3;
				text3 = text2.Substring(num2, num3 - num2 - 1);
				m_SelfNick = StringChar.ChinaUnicodeToASCII(text3);
				num2 = text2.IndexOf(" money=", num);
				if (num2 == -1)
				{
					return false;
				}
				num3 = text2.IndexOf(" carnum=", num2);
				if (num2 != -1 && num3 != -1)
				{
					num2 += 8;
					num = num3;
					text3 = text2.Substring(num2, num3 - num2 - 1);
					m_iSelfMoney = StringChar.SToInt(text3);
					num2 = text2.IndexOf(" carnum=", num);
					if (num2 == -1)
					{
						return false;
					}
					num3 = text2.IndexOf(" score=", num2);
					if (num2 != -1 && num3 != -1)
					{
						num2 += 9;
						num = num3;
						text3 = text2.Substring(num2, num3 - num2 - 1);
						m_iHaveCarNum = StringChar.SToInt(text3);
						num2 = text2.IndexOf(" regtime=", num);
						if (num2 == -1)
						{
							return false;
						}
						num3 = text2.IndexOf(" lastlogin=", num2);
						if (num2 != -1 && num3 != -1)
						{
							num2 += 10;
							num = num3;
							text3 = (m_StartGameTime = text2.Substring(num2, num3 - num2 - 1));
							num2 = text2.IndexOf(" lastlogin=", num);
							if (num2 == -1)
							{
								return false;
							}
							num3 = text2.IndexOf(" isDirty=", num2);
							if (num2 != -1 && num3 != -1)
							{
								num2 += 12;
								num = num3;
								text3 = text2.Substring(num2, num3 - num2 - 1);
								m_ilastLogin = StringChar.SToInt(text3);
								num = num3;
								int num4 = 1;
								while (true)
								{
									ParkInfo parkInfo = new ParkInfo();
									parkInfo.Id = num4++;
									parkInfo.sParkID = parkInfo.Id.ToString();
									num2 = text2.IndexOf("<owner", num);
									if (num2 == -1)
									{
										break;
									}
									num3 = text2.IndexOf("/owner>", num2);
									if (num2 == -1)
									{
										break;
									}
									m_parkInfoListJB.Add(parkInfo);
									if (num3 - num2 < 30)
									{
										if (num4 - 1 == 1)
										{
											bPark1 = true;
										}
										else
										{
											m_iEmptyNum++;
											if (num4 - 1 == 2)
											{
												bPark2 = true;
											}
											if (num4 - 1 == 3)
											{
												bPark3 = true;
											}
											if (num4 - 1 == 4)
											{
												bPark4 = true;
											}
										}
										num = num3;
										continue;
									}
									num2 = text2.IndexOf("owner uin=", num);
									if (num2 == -1)
									{
										break;
									}
									num3 = text2.IndexOf(" nick=", num2);
									if (num2 == -1)
									{
										break;
									}
									num2 += 11;
									num = num3;
									text3 = text2.Substring(num2, num3 - num2 - 1);
									parkInfo.sQQNum = text3.Trim();
									num2 = text2.IndexOf(" nick=", num);
									if (num2 == -1)
									{
										break;
									}
									num3 = text2.IndexOf(" getmoney=", num2);
									if (num2 == -1 || num3 == -1)
									{
										break;
									}
									num2 += 7;
									num = num3;
									text3 = text2.Substring(num2, num3 - num2 - 1);
									parkInfo.sQQName = StringChar.ChinaUnicodeToASCII(text3);
									num2 = text2.IndexOf(" getmoney=", num);
									if (num2 == -1)
									{
										break;
									}
									num3 = text2.IndexOf(" carid=", num2);
									if (num2 == -1 || num3 == -1)
									{
										break;
									}
									num2 += 11;
									num = num3;
									text3 = text2.Substring(num2, num3 - num2 - 1);
									parkInfo.iTime = StringChar.SToInt(text3);
									num2 = text2.IndexOf(" carid=", num);
									if (num2 == -1)
									{
										break;
									}
									num3 = text2.IndexOf(" carno=", num2);
									if (num2 == -1 || num3 == -1)
									{
										break;
									}
									num2 += 8;
									num = num3;
									text3 = (parkInfo.sCarNum = text2.Substring(num2, num3 - num2 - 1));
									num2 = text2.IndexOf(" carno=", num);
									if (num2 == -1)
									{
										break;
									}
									num3 = text2.IndexOf(" carcolor=", num2);
									if (num2 == -1 || num3 == -1)
									{
										break;
									}
									num2 += 8;
									num = num3;
									text3 = (parkInfo.sCarName = text2.Substring(num2, num3 - num2 - 1));
								}
								return true;
							}
							return false;
						}
						return false;
					}
					return false;
				}
				return false;
			}
			return false;
		}
		return false;
	}

	public void QueryEmptyParker(HttpHelper _hh, string QQNum)
	{
		m_iEmptyNum = 0;
		m_ilastLogin = -1;
		string text = _hh.Get("http://world.show.qq.com/cgi-bin/parker_user_front?uin=" + QQNum, null);
		int num = 0;
		int num2 = text.IndexOf(" score=", 0);
		if (num2 == -1)
		{
			return;
		}
		int num3 = text.IndexOf(" lv=", num2);
		if (num2 == -1 || num3 == -1)
		{
			return;
		}
		num2 += 8;
		num = num3;
		string text2 = (m_sJinYan = text.Substring(num2, num3 - num2 - 1));
		num2 = text.IndexOf(" lv=", num);
		if (num2 == -1)
		{
			return;
		}
		num3 = text.IndexOf(" regtime=", num2);
		if (num2 == -1 || num3 == -1)
		{
			return;
		}
		num2 += 5;
		num = num3;
		text2 = (m_sDengji = text.Substring(num2, num3 - num2 - 1));
		num2 = text.IndexOf(" lastlogin=", num);
		if (num2 == -1)
		{
			return;
		}
		num3 = text.IndexOf(" isDirty=", num2);
		if (num2 == -1 || num3 == -1)
		{
			return;
		}
		num2 += 12;
		num = num3;
		text2 = text.Substring(num2, num3 - num2 - 1);
		m_ilastLogin = StringChar.SToInt(text2);
		num2 = text.IndexOf(" color=", num);
		if (num2 == -1)
		{
			return;
		}
		num3 = text.IndexOf(">", num2);
		if (num2 == -1 || num3 == -1)
		{
			return;
		}
		num2 += 8;
		num = num3;
		text2 = text.Substring(num2, num3 - num2 - 1);
		m_iLoveColor = StringChar.SToInt(text2);
		int num4 = 1;
		while (true)
		{
			num4++;
			num2 = text.IndexOf("<owner", num);
			if (num2 != -1)
			{
				num3 = text.IndexOf("/owner>", num2);
				if (num2 == -1)
				{
					break;
				}
				if (num3 - num2 < 30 && num4 - 1 != 1)
				{
					m_iEmptyNum++;
				}
				num = num3;
				continue;
			}
			break;
		}
	}

	public int GetEmptyCount()
	{
		return m_iEmptyNum;
	}

	public int GetLastLogin()
	{
		return m_ilastLogin;
	}

	public int GetCount()
	{
		return m_parkInfoList.Count;
	}

	public int GetCountJB()
	{
		return m_parkInfoListJB.Count;
	}

	public int GetSelfMoney()
	{
		return m_iSelfMoney;
	}

	public string GetSelfNick()
	{
		return m_SelfNick;
	}

	public int GetHaveCarNum()
	{
		return m_iHaveCarNum;
	}

	public string GetStartGameTime()
	{
		return m_StartGameTime;
	}

	public ParkInfo GetParkInfo(int iIndex)
	{
		int num = 0;
		foreach (ParkInfo parkInfo in m_parkInfoList)
		{
			if (num != iIndex)
			{
				num++;
				continue;
			}
			return parkInfo;
		}
		return null;
	}

	public ParkInfo GetParkInfoJB(int iIndex)
	{
		int num = 0;
		foreach (ParkInfo item in m_parkInfoListJB)
		{
			if (num != iIndex)
			{
				num++;
				continue;
			}
			return item;
		}
		return null;
	}
}
