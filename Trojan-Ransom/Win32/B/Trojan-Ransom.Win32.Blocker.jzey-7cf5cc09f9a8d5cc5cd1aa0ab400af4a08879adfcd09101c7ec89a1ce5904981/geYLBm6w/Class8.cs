using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Xml;
using CCfpfC7h;
using IoSuaiAb;
using Microsoft.VisualBasic;
using TGaER2JO;
using VeeC76Ht;
using Y7FbhctW;
using ZqaFD1Ap;
using di1mqJMz;
using hfpgL6Qd;
using iLd730DL;
using iiraiv39;
using ns1;
using ns4;
using p80hVGtz;
using sReLFYF2;
using wMk1FHff;

namespace geYLBm6w;

internal class Class8
{
	protected bool V1bV4UWs;

	protected AuGeYfFm PS1YmicX;

	protected sm18FGKs PNgI0Wiu;

	protected string VF14feGN;

	protected bool WqYBlMPb;

	protected Uj8nVl61 N9uO151B;

	protected List<Class7> VHELulGZ;

	public static string IGZpTScB = "SODXOF";

	public List<Class7> X4VQrutQ => VHELulGZ;

	public T3swvg6Z KZSEMpiU => PS1YmicX;

	public bool Boolean_0 => V1bV4UWs;

	public Class8(ref sm18FGKs azF7Bpjc)
	{
		PNgI0Wiu = azF7Bpjc;
		N9uO151B = new Uj8nVl61(null);
		VHELulGZ = new List<Class7>();
	}

	public Class8(ref sm18FGKs E17tIWai, string wQtXYJC5)
		: this(ref E17tIWai)
	{
		if (!XAFeFz8d(wQtXYJC5))
		{
			throw new ArgumentException("Invalid expression");
		}
	}

	public void snKJ3rIb(ref XmlTextWriter uW3Bu7rz)
	{
		ivlgLlId.smethod_2(uW3Bu7rz, "ST", rkg3zAUM(), 35369);
	}

	public bool method_0(string tfJFWnor)
	{
		return XAFeFz8d(tfJFWnor);
	}

	public bool XAFeFz8d(string jVYMTzNo)
	{
		N9uO151B.Clear();
		VF14feGN = "";
		if (ivlgLlId.smethod_3(jVYMTzNo, "true", bool_0: false, 3221) != 0 && ivlgLlId.smethod_3(jVYMTzNo, "TRUE", bool_0: false, 3221) != 0 && ivlgLlId.smethod_3(jVYMTzNo, "", bool_0: false, 3221) != 0)
		{
			if (ivlgLlId.smethod_3(jVYMTzNo, "false", bool_0: false, 3221) != 0 && ivlgLlId.smethod_3(jVYMTzNo, "FALSE", bool_0: false, 3221) != 0)
			{
				if (ivlgLlId.smethod_3(jVYMTzNo, "", bool_0: false, 3221) != 0)
				{
					tQ0Yk9Yy(jVYMTzNo);
					if (ivlgLlId.smethod_3(VF14feGN, "", bool_0: false, 3221) == 0)
					{
						try
						{
							PS1YmicX = go1fnQRN(jVYMTzNo, kQv7anRg: false);
						}
						catch (Exception exception_)
						{
							m8meAX3U.L6HgMKrR(exception_, 21003);
							PS1YmicX = null;
							FFXb5i9i.LfyQ8gZ7(12759);
						}
					}
				}
			}
			else
			{
				V1bV4UWs = true;
			}
		}
		return ivlgLlId.smethod_3(VF14feGN, "", bool_0: false, 3221) == 0;
	}

	public string pTOOwarE()
	{
		return VF14feGN;
	}

	public static byte[] smethod_0(Bitmap xCEUsdUz, string string_0)
	{
		List<byte> list = new List<byte>();
		checked
		{
			int num = U0nDFthS.nm6dbcmt((Image)(object)xCEUsdUz, 5824) - 1;
			for (int i = 0; i <= num; i++)
			{
				int num2 = U0nDFthS.nm6dbcmt((Image)(object)xCEUsdUz, 5825) - 1;
				for (int j = 0; j <= num2; j++)
				{
					Color color_ = U0nDFthS.smethod_2(xCEUsdUz, i, j, 1066);
					if (U0nDFthS.dQyYmTkI(color_, U0nDFthS.mIiGIlxc(0, 0, 0, 0, 60550), 9155))
					{
						list.Add(color_.R);
						list.Add(color_.G);
						list.Add(color_.B);
					}
				}
			}
			return uwHmrChZ(list.ToArray(), string_0);
		}
	}

	public string rkg3zAUM()
	{
		string result = null;
		try
		{
			if (FFXb5i9i.smethod_1(PS1YmicX, 48316))
			{
				if (V1bV4UWs)
				{
					result = "false";
					return result;
				}
				result = "true";
				return result;
			}
			if (FFXb5i9i.smethod_1(PS1YmicX.W6dD0X3q, 48316))
			{
				result = "";
				return result;
			}
			ref AuGeYfFm pS1YmicX = ref PS1YmicX;
			object GRfhVTVb = pS1YmicX;
			string text = method_1(ref GRfhVTVb);
			pS1YmicX = (AuGeYfFm)GRfhVTVb;
			string string_ = text;
			result = ivlgLlId.zIKBYyAm(string_, 2, checked(ivlgLlId.f5lHgZCI(string_, 64616) - 2), 41221);
			return result;
		}
		catch (Exception exception_)
		{
			m8meAX3U.L6HgMKrR(exception_, 21003);
			for (int num = 0; num == 0; num = 1)
			{
				FFXb5i9i.LfyQ8gZ7(12759);
			}
			return result;
		}
	}

	private string method_1(ref object GRfhVTVb)
	{
		string text = "";
		string string_ = FFXb5i9i.pOhcgUVE(FFXb5i9i.VcIT67Rx(GRfhVTVb, 58039), 54497);
		checked
		{
			if (ivlgLlId.smethod_3(string_, "PlusNode", bool_0: false, 3221) != 0)
			{
				if (ivlgLlId.smethod_3(string_, "MultNode", bool_0: false, 3221) != 0)
				{
					if (ivlgLlId.smethod_3(string_, "CompareNode", bool_0: false, 3221) != 0)
					{
						if (ivlgLlId.smethod_3(string_, "ArithmeticNode", bool_0: false, 3221) != 0)
						{
							if (ivlgLlId.smethod_3(string_, "VariableNode", bool_0: false, 3221) != 0)
							{
								if (ivlgLlId.smethod_3(string_, "StepMakerConditionNode", bool_0: false, 3221) == 0)
								{
									text = FFXb5i9i.F6ODWxg3(FFXb5i9i.smethod_2(FFXb5i9i.smethod_2(GRfhVTVb, null, "StepMaker", new object[0], null, null, null, 44005), null, "Name", new object[0], null, null, null, 44005), 22851);
									bool flag;
									if (flag = FFXb5i9i.rs8UXJ4a(FFXb5i9i.smethod_2(GRfhVTVb, null, "Type", new object[0], null, null, null, 44005), 21077))
									{
										if (flag)
										{
											text = ivlgLlId.jnXal2jf(text, ".T", 28657);
											text = FFXb5i9i.F6ODWxg3(FFXb5i9i.TCNI2YTH(text, FFXb5i9i.smethod_2(GRfhVTVb, null, "Op", new object[0], null, null, null, 44005), 1486), 22851);
											string string_2 = FFXb5i9i.F6ODWxg3(FFXb5i9i.smethod_2(GRfhVTVb, null, "TimeUnit", new object[0], null, null, null, 44005), 22851);
											if (ivlgLlId.smethod_3(string_2, "ms", bool_0: false, 3221) != 0)
											{
												if (ivlgLlId.smethod_3(string_2, "s", bool_0: false, 3221) != 0)
												{
													if (ivlgLlId.smethod_3(string_2, "m", bool_0: false, 3221) != 0)
													{
														if (ivlgLlId.smethod_3(string_2, "h", bool_0: false, 3221) != 0)
														{
															if (ivlgLlId.smethod_3(string_2, "d", bool_0: false, 3221) == 0)
															{
																text = ivlgLlId.jnXal2jf(text, O4s9Dog1.cI1h7tEI(FFXb5i9i.fEqPi5J6(FFXb5i9i.smethod_2(FFXb5i9i.smethod_2(GRfhVTVb, null, "Time", new object[0], null, null, null, 44005), null, "TotalDays", new object[0], null, null, null, 44005), 22520), 25972), 28657);
															}
														}
														else
														{
															text = ivlgLlId.jnXal2jf(text, O4s9Dog1.cI1h7tEI(FFXb5i9i.fEqPi5J6(FFXb5i9i.smethod_2(FFXb5i9i.smethod_2(GRfhVTVb, null, "Time", new object[0], null, null, null, 44005), null, "TotalHours", new object[0], null, null, null, 44005), 22520), 25972), 28657);
														}
													}
													else
													{
														text = ivlgLlId.jnXal2jf(text, O4s9Dog1.cI1h7tEI(FFXb5i9i.fEqPi5J6(FFXb5i9i.smethod_2(FFXb5i9i.smethod_2(GRfhVTVb, null, "Time", new object[0], null, null, null, 44005), null, "TotalMinutes", new object[0], null, null, null, 44005), 22520), 25972), 28657);
													}
												}
												else
												{
													text = ivlgLlId.jnXal2jf(text, O4s9Dog1.cI1h7tEI(FFXb5i9i.fEqPi5J6(FFXb5i9i.smethod_2(FFXb5i9i.smethod_2(GRfhVTVb, null, "Time", new object[0], null, null, null, 44005), null, "TotalSeconds", new object[0], null, null, null, 44005), 22520), 25972), 28657);
												}
											}
											else
											{
												text = ivlgLlId.jnXal2jf(text, O4s9Dog1.cI1h7tEI(FFXb5i9i.fEqPi5J6(FFXb5i9i.smethod_2(FFXb5i9i.smethod_2(GRfhVTVb, null, "Time", new object[0], null, null, null, 44005), null, "TotalMilliseconds", new object[0], null, null, null, 44005), 22520), 25972), 28657);
											}
											text = FFXb5i9i.F6ODWxg3(FFXb5i9i.TCNI2YTH(text, FFXb5i9i.smethod_2(GRfhVTVb, null, "TimeUnit", new object[0], null, null, null, 44005), 1486), 22851);
										}
									}
									else
									{
										text = ivlgLlId.jnXal2jf(text, ".X", 28657);
									}
									text = FFXb5i9i.smethod_0("[", text, "]", 52605);
									if (FFXb5i9i.rs8UXJ4a(FFXb5i9i.smethod_2(GRfhVTVb, null, "Neg", new object[0], null, null, null, 44005), 21077))
									{
										text = ivlgLlId.jnXal2jf("!", text, 28657);
									}
								}
							}
							else
							{
								text = FFXb5i9i.F6ODWxg3(FFXb5i9i.smethod_2(FFXb5i9i.smethod_2(GRfhVTVb, null, "Var", new object[0], null, null, null, 44005), null, "Name", new object[0], null, null, null, 44005), 22851);
								if (FFXb5i9i.rs8UXJ4a(FFXb5i9i.smethod_2(GRfhVTVb, null, "Neg", new object[0], null, null, null, 44005), 21077))
								{
									text = ivlgLlId.jnXal2jf("!", text, 28657);
								}
							}
						}
						else
						{
							text = FFXb5i9i.F6ODWxg3(FFXb5i9i.TCNI2YTH("{", FFXb5i9i.smethod_2(FFXb5i9i.smethod_2(FFXb5i9i.smethod_2(GRfhVTVb, null, "Var", new object[0], null, null, null, 44005), null, "Var", new object[0], null, null, null, 44005), null, "Name", new object[0], null, null, null, 44005), 1485), 22851);
							text = FFXb5i9i.F6ODWxg3(FFXb5i9i.TCNI2YTH(text, FFXb5i9i.smethod_2(GRfhVTVb, null, "Op", new object[0], null, null, null, 44005), 1486), 22851);
							text = FFXb5i9i.F6ODWxg3(FFXb5i9i.TCNI2YTH(text, FFXb5i9i.smethod_2(GRfhVTVb, null, "Expression", new object[0], null, null, null, 44005), 1486), 22851);
							text = ivlgLlId.jnXal2jf(text, "}", 28657);
							if (FFXb5i9i.rs8UXJ4a(FFXb5i9i.smethod_2(GRfhVTVb, null, "Neg", new object[0], null, null, null, 44005), 21077))
							{
								text = ivlgLlId.jnXal2jf("!", text, 28657);
							}
						}
					}
					else
					{
						int num = FFXb5i9i.fEqPi5J6(FFXb5i9i.TCNI2YTH(FFXb5i9i.smethod_2(FFXb5i9i.smethod_2(GRfhVTVb, null, "NextNodes", new object[0], null, null, null, 44005), null, "Count", new object[0], null, null, null, 44005), 1, 1487), 22520);
						for (int i = 0; i <= num; i++)
						{
							string string_3 = text;
							object object_ = GRfhVTVb;
							int num2;
							object GRfhVTVb2 = m8meAX3U.bErpAbl3(FFXb5i9i.smethod_2(object_, null, "NextNodes", new object[1] { num2 = i }, null, null, null, 44005), 6598);
							string string_2 = method_1(ref GRfhVTVb2);
							FFXb5i9i.smethod_3(object_, null, "NextNodes", new object[2] { num2, GRfhVTVb2 }, null, null, bool_0: true, bool_1: false, 61618);
							text = ivlgLlId.jnXal2jf(string_3, string_2, 28657);
							if (FFXb5i9i.rs8UXJ4a(FFXb5i9i.nWO7RQjw(FFXb5i9i.joZDbSGP(i, FFXb5i9i.TCNI2YTH(FFXb5i9i.smethod_2(FFXb5i9i.smethod_2(GRfhVTVb, null, "NextNodes", new object[0], null, null, null, 44005), null, "Count", new object[0], null, null, null, 44005), 1, 1487), bool_0: false, 22856), 22106), 21077))
							{
								text = FFXb5i9i.F6ODWxg3(FFXb5i9i.TCNI2YTH(text, FFXb5i9i.smethod_2(GRfhVTVb, null, "op", new object[0], null, null, null, 44005), 1486), 22851);
							}
						}
					}
				}
				else
				{
					int num3 = FFXb5i9i.fEqPi5J6(FFXb5i9i.TCNI2YTH(FFXb5i9i.smethod_2(FFXb5i9i.smethod_2(GRfhVTVb, null, "NextNodes", new object[0], null, null, null, 44005), null, "Count", new object[0], null, null, null, 44005), 1, 1487), 22520);
					for (int j = 0; j <= num3; j++)
					{
						string string_4 = text;
						object GRfhVTVb2 = GRfhVTVb;
						int num;
						object object_ = m8meAX3U.bErpAbl3(FFXb5i9i.smethod_2(GRfhVTVb2, null, "NextNodes", new object[1] { num = j }, null, null, null, 44005), 6598);
						string string_2 = method_1(ref object_);
						FFXb5i9i.smethod_3(GRfhVTVb2, null, "NextNodes", new object[2] { num, object_ }, null, null, bool_0: true, bool_1: false, 61618);
						text = ivlgLlId.jnXal2jf(string_4, string_2, 28657);
						if (FFXb5i9i.rs8UXJ4a(FFXb5i9i.nWO7RQjw(FFXb5i9i.joZDbSGP(j, FFXb5i9i.TCNI2YTH(FFXb5i9i.smethod_2(FFXb5i9i.smethod_2(GRfhVTVb, null, "NextNodes", new object[0], null, null, null, 44005), null, "Count", new object[0], null, null, null, 44005), 1, 1487), bool_0: false, 22856), 22106), 21077))
						{
							text = ivlgLlId.jnXal2jf(text, "*", 28657);
						}
						if (FFXb5i9i.rs8UXJ4a(FFXb5i9i.smethod_2(GRfhVTVb, null, "Neg", new object[0], null, null, null, 44005), 21077))
						{
							text = ivlgLlId.jnXal2jf("!", text, 28657);
						}
					}
				}
			}
			else
			{
				int num4 = FFXb5i9i.fEqPi5J6(FFXb5i9i.TCNI2YTH(FFXb5i9i.smethod_2(FFXb5i9i.smethod_2(GRfhVTVb, null, "NextNodes", new object[0], null, null, null, 44005), null, "Count", new object[0], null, null, null, 44005), 1, 1487), 22520);
				for (int k = 0; k <= num4; k++)
				{
					string string_5 = text;
					object object_ = GRfhVTVb;
					int num3;
					object GRfhVTVb2 = m8meAX3U.bErpAbl3(FFXb5i9i.smethod_2(object_, null, "NextNodes", new object[1] { num3 = k }, null, null, null, 44005), 6598);
					string string_2 = method_1(ref GRfhVTVb2);
					FFXb5i9i.smethod_3(object_, null, "NextNodes", new object[2] { num3, GRfhVTVb2 }, null, null, bool_0: true, bool_1: false, 61618);
					text = ivlgLlId.jnXal2jf(string_5, string_2, 28657);
					if (FFXb5i9i.rs8UXJ4a(FFXb5i9i.nWO7RQjw(FFXb5i9i.joZDbSGP(k, FFXb5i9i.TCNI2YTH(FFXb5i9i.smethod_2(FFXb5i9i.smethod_2(GRfhVTVb, null, "NextNodes", new object[0], null, null, null, 44005), null, "Count", new object[0], null, null, null, 44005), 1, 1487), bool_0: false, 22856), 22106), 21077))
					{
						text = ivlgLlId.jnXal2jf(text, "+", 28657);
					}
				}
				text = FFXb5i9i.smethod_0("(", text, ")", 52605);
				if (FFXb5i9i.rs8UXJ4a(FFXb5i9i.smethod_2(GRfhVTVb, null, "Neg", new object[0], null, null, null, 44005), 21077))
				{
					text = ivlgLlId.jnXal2jf("!", text, 28657);
				}
			}
			return text;
		}
	}

	public List<vilSnlZy> ZeNx2KPr()
	{
		return N9uO151B;
	}

	public bool method_2()
	{
		return HRLs0FgG();
	}

	public bool HRLs0FgG()
	{
		bool flag;
		if (FFXb5i9i.smethod_1(PS1YmicX, 48316))
		{
			flag = true;
		}
		else if (FFXb5i9i.smethod_1(PS1YmicX.W6dD0X3q, 48316))
		{
			flag = true;
		}
		else
		{
			try
			{
				ref AuGeYfFm pS1YmicX = ref PS1YmicX;
				object T7FtyL3G = pS1YmicX;
				bool num = method_5(ref T7FtyL3G);
				pS1YmicX = (AuGeYfFm)T7FtyL3G;
				flag = num;
			}
			catch (Exception exception_)
			{
				m8meAX3U.L6HgMKrR(exception_, 21003);
				flag = false;
				FFXb5i9i.LfyQ8gZ7(12759);
			}
		}
		WqYBlMPb = flag;
		return flag;
	}

	private bool tQ0Yk9Yy(string o44kMnKo)
	{
		bool result = true;
		string oOYG7daj = "c![(";
		int num = ivlgLlId.f5lHgZCI(o44kMnKo, 64616);
		int num2 = 1;
		checked
		{
			bool flag = default(bool);
			bool flag2 = default(bool);
			int num4 = default(int);
			bool flag3 = default(bool);
			while (true)
			{
				string text;
				if (num2 <= num)
				{
					text = ivlgLlId.zIKBYyAm(o44kMnKo, num2, 1, 41221);
					if (Y63bJQ6Q(oOYG7daj, U0nDFthS.SW3y4MmE(text, 63887)))
					{
						if (!flag && !flag2)
						{
							uint num3 = PG9QGTIa.vqcqF5n9(text);
							if (num3 <= 789356349)
							{
								if (num3 <= 739023492)
								{
									switch (num3)
									{
									case 739023492u:
										if (ivlgLlId.smethod_3(text, ")", bool_0: false, 3221) == 0)
										{
											oOYG7daj = "o)";
											num4--;
											goto IL_0644;
										}
										break;
									case 604802540u:
										if (ivlgLlId.smethod_3(text, "!", bool_0: false, 3221) == 0)
										{
											oOYG7daj = "c[(";
											goto IL_0644;
										}
										break;
									}
								}
								else if (num3 != 755801111)
								{
									if (num3 != 772578730)
									{
										if (num3 == 789356349 && ivlgLlId.smethod_3(text, "*", bool_0: false, 3221) == 0)
										{
											goto IL_0119;
										}
									}
									else if (ivlgLlId.smethod_3(text, "+", bool_0: false, 3221) == 0)
									{
										goto IL_0119;
									}
								}
								else if (ivlgLlId.smethod_3(text, "(", bool_0: false, 3221) == 0)
								{
									oOYG7daj = "c!([";
									num4++;
									goto IL_0644;
								}
							}
							else
							{
								if (num3 <= 957132539)
								{
									if (num3 != 940354920)
									{
										if (num3 != 957132539 || ivlgLlId.smethod_3(text, "<", bool_0: false, 3221) != 0)
										{
											goto IL_020d;
										}
									}
									else if (ivlgLlId.smethod_3(text, "=", bool_0: false, 3221) != 0)
									{
										goto IL_020d;
									}
									goto IL_0218;
								}
								if (num3 != 990687777)
								{
									switch (num3)
									{
									case 4262220314u:
										if (ivlgLlId.smethod_3(text, "{", bool_0: false, 3221) == 0)
										{
											flag2 = true;
											oOYG7daj = "c";
											goto IL_0644;
										}
										break;
									case 3725336506u:
										if (ivlgLlId.smethod_3(text, "[", bool_0: false, 3221) == 0)
										{
											flag = true;
											oOYG7daj = "c";
											goto IL_0644;
										}
										break;
									}
								}
								else if (ivlgLlId.smethod_3(text, ">", bool_0: false, 3221) == 0)
								{
									goto IL_0218;
								}
							}
							goto IL_020d;
						}
						if (flag)
						{
							if (unchecked(ivlgLlId.smethod_3(text, ".", bool_0: false, 3221) != 0 && !flag3))
							{
								oOYG7daj = "c";
								goto IL_0644;
							}
							uint num3 = PG9QGTIa.vqcqF5n9(text);
							if (num3 <= 990687777)
							{
								if (num3 <= 856466825)
								{
									if (num3 <= 806133968)
									{
										if (num3 == 722245873)
										{
											if (ivlgLlId.smethod_3(text, ".", bool_0: false, 3221) == 0)
											{
												flag3 = true;
												oOYG7daj = "TX";
											}
											goto IL_0644;
										}
										if (num3 != 806133968 || ivlgLlId.smethod_3(text, "5", bool_0: false, 3221) != 0)
										{
											goto IL_0644;
										}
									}
									else if (num3 != 822911587)
									{
										if (num3 != 839689206)
										{
											if (num3 != 856466825 || ivlgLlId.smethod_3(text, "6", bool_0: false, 3221) != 0)
											{
												goto IL_0644;
											}
										}
										else if (ivlgLlId.smethod_3(text, "7", bool_0: false, 3221) != 0)
										{
											goto IL_0644;
										}
									}
									else if (ivlgLlId.smethod_3(text, "4", bool_0: false, 3221) != 0)
									{
										goto IL_0644;
									}
								}
								else if (num3 <= 906799682)
								{
									if (num3 != 873244444)
									{
										if (num3 != 890022063)
										{
											if (num3 != 906799682 || ivlgLlId.smethod_3(text, "3", bool_0: false, 3221) != 0)
											{
												goto IL_0644;
											}
										}
										else if (ivlgLlId.smethod_3(text, "0", bool_0: false, 3221) != 0)
										{
											goto IL_0644;
										}
									}
									else if (ivlgLlId.smethod_3(text, "1", bool_0: false, 3221) != 0)
									{
										goto IL_0644;
									}
								}
								else
								{
									if (num3 != 923577301)
									{
										if (num3 != 957132539)
										{
											if (num3 != 990687777 || ivlgLlId.smethod_3(text, ">", bool_0: false, 3221) != 0)
											{
												goto IL_0644;
											}
										}
										else if (ivlgLlId.smethod_3(text, "<", bool_0: false, 3221) != 0)
										{
											goto IL_0644;
										}
										oOYG7daj = "n";
										goto IL_0644;
									}
									if (ivlgLlId.smethod_3(text, "2", bool_0: false, 3221) != 0)
									{
										goto IL_0644;
									}
								}
								goto IL_04ad;
							}
							if (num3 <= 3775669363u)
							{
								if (num3 <= 3507227459u)
								{
									if (num3 != 1007465396)
									{
										if (num3 != 1024243015)
										{
											if (num3 != 3507227459u || ivlgLlId.smethod_3(text, "T", bool_0: false, 3221) != 0)
											{
												goto IL_0644;
											}
											goto IL_0618;
										}
										if (ivlgLlId.smethod_3(text, "8", bool_0: false, 3221) != 0)
										{
											goto IL_0644;
										}
									}
									else if (ivlgLlId.smethod_3(text, "9", bool_0: false, 3221) != 0)
									{
										goto IL_0644;
									}
									goto IL_04ad;
								}
								if (num3 == 3624670792u)
								{
									if (ivlgLlId.smethod_3(text, "]", bool_0: false, 3221) == 0)
									{
										oOYG7daj = "o)";
										flag = false;
										flag3 = false;
									}
									goto IL_0644;
								}
								if (num3 == 3708558887u)
								{
									if (ivlgLlId.smethod_3(text, "X", bool_0: false, 3221) != 0)
									{
										goto IL_0644;
									}
									goto IL_05e2;
								}
								if (num3 != 3775669363u || ivlgLlId.smethod_3(text, "d", bool_0: false, 3221) != 0)
								{
									goto IL_0644;
								}
							}
							else if (num3 <= 3977000791u)
							{
								if (num3 != 3792446982u)
								{
									if (num3 == 3893112696u)
									{
										if (ivlgLlId.smethod_3(text, "m", bool_0: false, 3221) == 0)
										{
											oOYG7daj = "s]";
										}
										goto IL_0644;
									}
									if (num3 != 3977000791u || ivlgLlId.smethod_3(text, "h", bool_0: false, 3221) != 0)
									{
										goto IL_0644;
									}
								}
								else if (ivlgLlId.smethod_3(text, "g", bool_0: false, 3221) != 0)
								{
									goto IL_0644;
								}
							}
							else
							{
								if (num3 == 4044111267u)
								{
									if (ivlgLlId.smethod_3(text, "t", bool_0: false, 3221) != 0)
									{
										goto IL_0644;
									}
									goto IL_0618;
								}
								if (num3 != 4127999362u)
								{
									if (num3 != 4245442695u || ivlgLlId.smethod_3(text, "x", bool_0: false, 3221) != 0)
									{
										goto IL_0644;
									}
									goto IL_05e2;
								}
								if (ivlgLlId.smethod_3(text, "s", bool_0: false, 3221) != 0)
								{
									goto IL_0644;
								}
							}
							oOYG7daj = "]";
							goto IL_0644;
						}
						if (ivlgLlId.smethod_3(text, "}", bool_0: false, 3221) == 0)
						{
							oOYG7daj = "o)";
							flag2 = false;
						}
						else
						{
							oOYG7daj = "cow>()n";
						}
						goto IL_0644;
					}
					VF14feGN = FFXb5i9i.Be2UxXd8(new string[5]
					{
						"Unexpected char at ",
						O4s9Dog1.cI1h7tEI(num2, 25972),
						": '",
						text,
						"'!"
					}, 53581);
					break;
				}
				if (flag)
				{
					VF14feGN = "Incomplete reference to marker of step";
					break;
				}
				if (flag2)
				{
					VF14feGN = "Incomplete arithmetic condition";
					break;
				}
				oOYG7daj = "c)]}";
				text = ivlgLlId.zIKBYyAm(o44kMnKo, ivlgLlId.f5lHgZCI(o44kMnKo, 64616), 1, 41221);
				if (!Y63bJQ6Q(oOYG7daj, U0nDFthS.SW3y4MmE(text, 63887)))
				{
					VF14feGN = FFXb5i9i.Be2UxXd8(new string[5]
					{
						"Unexpected char at ",
						O4s9Dog1.cI1h7tEI(num2, 25972),
						": '",
						text,
						"'!"
					}, 53581);
					result = false;
				}
				else if (num4 > 0)
				{
					VF14feGN = "Expected ')'";
					result = false;
				}
				else if (num4 < 0)
				{
					VF14feGN = "Expected '('";
					result = false;
				}
				break;
				IL_0218:
				oOYG7daj = "c>";
				goto IL_0644;
				IL_05e2:
				oOYG7daj = "]";
				goto IL_0644;
				IL_0618:
				oOYG7daj = ">";
				goto IL_0644;
				IL_0644:
				num2++;
				continue;
				IL_0119:
				oOYG7daj = "c![(";
				goto IL_0644;
				IL_04ad:
				oOYG7daj = "nu";
				goto IL_0644;
				IL_020d:
				oOYG7daj = "co)>";
				goto IL_0644;
			}
			return result;
		}
	}

	public static string bLeWX8vv(Bitmap jhz37tbj)
	{
		byte[] byte_ = smethod_0(jhz37tbj, IGZpTScB);
		string result = U0nDFthS.KYtvrGZK(U0nDFthS.fMEKY27X(18107), byte_, 20289);
		byte_ = null;
		return result;
	}

	private bool Y63bJQ6Q(string oOYG7daj, char char_0)
	{
		checked
		{
			int num = ivlgLlId.f5lHgZCI(oOYG7daj, 64616) - 1;
			for (int i = 0; i <= num; i++)
			{
				if (kvE3zUqV(Class15.I9IgXm7u(oOYG7daj, i, 26430), char_0))
				{
					return true;
				}
			}
			bool result = default(bool);
			return result;
		}
	}

	private bool kvE3zUqV(char TKmGkyFk, char Foy99On6)
	{
		switch (TKmGkyFk)
		{
		case ')':
			if (ivlgLlId.smethod_3(U0nDFthS.gu9J6OJy(Foy99On6, 48700), ")", bool_0: false, 3221) == 0)
			{
				return true;
			}
			break;
		case '(':
			if (ivlgLlId.smethod_3(U0nDFthS.gu9J6OJy(Foy99On6, 48700), "(", bool_0: false, 3221) == 0)
			{
				return true;
			}
			break;
		case '!':
			if (ivlgLlId.smethod_3(U0nDFthS.gu9J6OJy(Foy99On6, 48700), "!", bool_0: false, 3221) == 0)
			{
				return true;
			}
			break;
		case 'T':
			if ((ivlgLlId.smethod_3(U0nDFthS.gu9J6OJy(Foy99On6, 48700), "T", bool_0: false, 3221) == 0) | (ivlgLlId.smethod_3(U0nDFthS.gu9J6OJy(Foy99On6, 48700), "t", bool_0: false, 3221) == 0))
			{
				return true;
			}
			break;
		case '>':
			if ((ivlgLlId.smethod_3(U0nDFthS.gu9J6OJy(Foy99On6, 48700), ">", bool_0: false, 3221) == 0) | (ivlgLlId.smethod_3(U0nDFthS.gu9J6OJy(Foy99On6, 48700), "<", bool_0: false, 3221) == 0) | (ivlgLlId.smethod_3(U0nDFthS.gu9J6OJy(Foy99On6, 48700), "=", bool_0: false, 3221) == 0))
			{
				return true;
			}
			break;
		case '.':
			if (ivlgLlId.smethod_3(U0nDFthS.gu9J6OJy(Foy99On6, 48700), ".", bool_0: false, 3221) == 0)
			{
				return true;
			}
			break;
		case ']':
			if (ivlgLlId.smethod_3(U0nDFthS.gu9J6OJy(Foy99On6, 48700), "]", bool_0: false, 3221) == 0)
			{
				return true;
			}
			break;
		case '[':
			if (ivlgLlId.smethod_3(U0nDFthS.gu9J6OJy(Foy99On6, 48700), "[", bool_0: false, 3221) == 0)
			{
				return true;
			}
			break;
		case 'X':
			if ((ivlgLlId.smethod_3(U0nDFthS.gu9J6OJy(Foy99On6, 48700), "X", bool_0: false, 3221) == 0) | (ivlgLlId.smethod_3(U0nDFthS.gu9J6OJy(Foy99On6, 48700), "x", bool_0: false, 3221) == 0))
			{
				return true;
			}
			break;
		case 'n':
			if (Kqk9udae.bvAT73DM(Foy99On6, 25550))
			{
				return true;
			}
			break;
		case 'c':
			if (!(U0nDFthS.suM9Ppzl(U0nDFthS.gu9J6OJy(Foy99On6, 48700), "[+|\"'<>().,:; {}~/\\]^%@", (CompareMethod)0, 60449) | (ivlgLlId.smethod_3(U0nDFthS.gu9J6OJy(Foy99On6, 48700), "-", bool_0: false, 3221) == 0) | (ivlgLlId.smethod_3(U0nDFthS.gu9J6OJy(Foy99On6, 48700), "*", bool_0: false, 3221) == 0) | (ivlgLlId.smethod_3(U0nDFthS.gu9J6OJy(Foy99On6, 48700), "#", bool_0: false, 3221) == 0) | (ivlgLlId.smethod_3(U0nDFthS.gu9J6OJy(Foy99On6, 48700), "?", bool_0: false, 3221) == 0) | (ivlgLlId.smethod_3(U0nDFthS.gu9J6OJy(Foy99On6, 48700), "!", bool_0: false, 3221) == 0) | (ivlgLlId.smethod_3(U0nDFthS.gu9J6OJy(Foy99On6, 48700), "[", bool_0: false, 3221) == 0) | (ivlgLlId.smethod_3(U0nDFthS.gu9J6OJy(Foy99On6, 48700), "]", bool_0: false, 3221) == 0) | (ivlgLlId.smethod_3(U0nDFthS.gu9J6OJy(Foy99On6, 48700), "<", bool_0: false, 3221) == 0) | (ivlgLlId.smethod_3(U0nDFthS.gu9J6OJy(Foy99On6, 48700), ">", bool_0: false, 3221) == 0) | (ivlgLlId.smethod_3(U0nDFthS.gu9J6OJy(Foy99On6, 48700), "=", bool_0: false, 3221) == 0)))
			{
				return true;
			}
			break;
		case 's':
			if (ivlgLlId.smethod_3(U0nDFthS.gu9J6OJy(Foy99On6, 48700), "s", bool_0: false, 3221) == 0)
			{
				return true;
			}
			break;
		case 'u':
			if ((ivlgLlId.smethod_3(U0nDFthS.gu9J6OJy(Foy99On6, 48700), "m", bool_0: false, 3221) == 0) | (ivlgLlId.smethod_3(U0nDFthS.gu9J6OJy(Foy99On6, 48700), "s", bool_0: false, 3221) == 0) | (ivlgLlId.smethod_3(U0nDFthS.gu9J6OJy(Foy99On6, 48700), "h", bool_0: false, 3221) == 0) | (ivlgLlId.smethod_3(U0nDFthS.gu9J6OJy(Foy99On6, 48700), "d", bool_0: false, 3221) == 0))
			{
				return true;
			}
			break;
		case 'w':
			if ((ivlgLlId.smethod_3(U0nDFthS.gu9J6OJy(Foy99On6, 48700), "-", bool_0: false, 3221) == 0) | (ivlgLlId.smethod_3(U0nDFthS.gu9J6OJy(Foy99On6, 48700), "/", bool_0: false, 3221) == 0))
			{
				return true;
			}
			break;
		case 'o':
			if ((ivlgLlId.smethod_3(U0nDFthS.gu9J6OJy(Foy99On6, 48700), "+", bool_0: false, 3221) == 0) | (ivlgLlId.smethod_3(U0nDFthS.gu9J6OJy(Foy99On6, 48700), "*", bool_0: false, 3221) == 0))
			{
				return true;
			}
			break;
		}
		bool result = default(bool);
		return result;
	}

	private xJFJT4Jj method_3(string nHRdc3gt)
	{
		xJFJT4Jj xJFJT4Jj = new xJFJT4Jj();
		xJFJT4Jj.W6dD0X3q = new ArrayList();
		string text = "";
		bool flag = true;
		checked
		{
			int num2 = default(int);
			bool flag2 = default(bool);
			int num3 = default(int);
			int num4 = default(int);
			while (flag)
			{
				int num = ivlgLlId.f5lHgZCI(nHRdc3gt, 64616);
				int i;
				for (i = 1; i <= num; i++)
				{
					string string_ = ivlgLlId.zIKBYyAm(nHRdc3gt, i, 1, 41221);
					if (ivlgLlId.smethod_3(string_, "(", bool_0: false, 3221) != 0)
					{
						if (ivlgLlId.smethod_3(string_, ")", bool_0: false, 3221) != 0)
						{
							continue;
						}
						num2--;
						if (unchecked(flag2 && num2 == 0) & (U0nDFthS.a7rPdJnI(nHRdc3gt, "+", 3436) >= 0))
						{
							U0nDFthS.cEC971DY(xJFJT4Jj.W6dD0X3q, go1fnQRN(ivlgLlId.zIKBYyAm(nHRdc3gt, num3 + 1, i - num3 - 1, 41221), kQv7anRg: false), 32367);
							if (num3 != 1)
							{
								num4 = 1;
							}
							nHRdc3gt = U0nDFthS.gn4174gi(nHRdc3gt, num3 - 1 - num4, i - num3 + 1 + num4, 12859);
							i = 0;
							flag2 = false;
							break;
						}
					}
					else
					{
						num2++;
						if (!flag2)
						{
							num3 = i;
							flag2 = true;
						}
					}
				}
				if (i > ivlgLlId.f5lHgZCI(nHRdc3gt, 64616))
				{
					flag = false;
				}
			}
			int num5 = ivlgLlId.f5lHgZCI(nHRdc3gt, 64616);
			for (int i = 1; i <= num5; i++)
			{
				char c = U0nDFthS.SW3y4MmE(ivlgLlId.zIKBYyAm(nHRdc3gt, i, 1, 41221), 63887);
				switch (c)
				{
				default:
					text = ivlgLlId.jnXal2jf(text, U0nDFthS.gu9J6OJy(c, 48700), 28657);
					break;
				case '<':
				case '=':
				case '>':
					if (ivlgLlId.smethod_3(text, "", bool_0: false, 3221) != 0)
					{
						aSfcEigp aSfcEigp = new aSfcEigp();
						aSfcEigp.VilSnlZy_0 = IWz2Mzbw(text);
						if (!FFXb5i9i.smethod_1(aSfcEigp.VilSnlZy_0, 48316) && ivlgLlId.smethod_3(aSfcEigp.VilSnlZy_0.String_2, "BOOL", bool_0: false, 3221) == 0)
						{
							VF14feGN = FFXb5i9i.smethod_0("Variable ", text, " is of type BOOL", 52605);
						}
						U0nDFthS.cEC971DY(xJFJT4Jj.W6dD0X3q, aSfcEigp, 32367);
						xJFJT4Jj.RB7E1yTh = U0nDFthS.gu9J6OJy(c, 48700);
						if (FFXb5i9i.smethod_1(aSfcEigp.VilSnlZy_0, 48316))
						{
							return null;
						}
						method_4(aSfcEigp.VilSnlZy_0);
					}
					else
					{
						string string_2 = ivlgLlId.zIKBYyAm(nHRdc3gt, i - 1, 1, 41221);
						if ((ivlgLlId.smethod_3(string_2, "<", bool_0: false, 3221) == 0) & (ivlgLlId.smethod_3(U0nDFthS.gu9J6OJy(c, 48700), "=", bool_0: false, 3221) == 0))
						{
							xJFJT4Jj.RB7E1yTh = "<=";
						}
						if ((ivlgLlId.smethod_3(string_2, ">", bool_0: false, 3221) == 0) & (ivlgLlId.smethod_3(U0nDFthS.gu9J6OJy(c, 48700), "=", bool_0: false, 3221) == 0))
						{
							xJFJT4Jj.RB7E1yTh = ">=";
						}
					}
					text = "";
					break;
				case '(':
				case ')':
					break;
				}
			}
		}
		if (ivlgLlId.f5lHgZCI(nHRdc3gt, 64616) > 0)
		{
			bool flag3 = false;
			aSfcEigp aSfcEigp2 = new aSfcEigp();
			aSfcEigp2.VilSnlZy_0 = IWz2Mzbw(text);
			if (!FFXb5i9i.smethod_1(aSfcEigp2.VilSnlZy_0, 48316))
			{
				if (ivlgLlId.smethod_3(aSfcEigp2.VilSnlZy_0.String_2, "BOOL", bool_0: false, 3221) == 0)
				{
					VF14feGN = FFXb5i9i.smethod_0("Variable ", text, " is of type BOOL", 52605);
				}
			}
			else if (Kqk9udae.bvAT73DM(text, 25550))
			{
				hK8QNa8w hK8QNa8w = new hK8QNa8w();
				hK8QNa8w.XKGcyo5e(SC9OdAxX.XwEtgMIh(text));
				hK8QNa8w.PYBbtbg6 = text;
				aSfcEigp2.VilSnlZy_0 = hK8QNa8w;
				VF14feGN = "";
				flag3 = true;
			}
			U0nDFthS.cEC971DY(xJFJT4Jj.W6dD0X3q, aSfcEigp2, 32367);
			if (!FFXb5i9i.smethod_1(aSfcEigp2.VilSnlZy_0, 48316) && !flag3)
			{
				method_4(aSfcEigp2.VilSnlZy_0);
			}
		}
		return xJFJT4Jj;
	}

	public static void n3NnQtZy()
	{
		string[] array = wBNSfNgl.smethod_1(bLeWX8vv(d.DsmxEC2m), U0nDFthS.gu9J6OJy(wBNSfNgl.smethod_0(checked((int)wBNSfNgl.UHAR69Ut("164", 10708)), 29028), 48700), -1, (CompareMethod)0, 24083);
		for (int num = 0; num == 0; num = 1)
		{
			wBNSfNgl.SaIBWYOL(wBNSfNgl.smethod_2(wBNSfNgl.JBeoqOgq(xKrqV9Zq(RIjCHr8B(d.b11Rt2g9)), array[0], 36417), array[1], 14829), null, new object[5]
			{
				RIjCHr8B(d.lRzpctBN),
				array[2],
				array[3],
				RIjCHr8B(d.DGxS9Yix),
				RIjCHr8B(d.SO5QpJEH)
			}, 5373);
		}
	}

	private vilSnlZy IWz2Mzbw(string string_0)
	{
		vilSnlZy vilSnlZy = PNgI0Wiu.PfKW6qbn.LEZUQfn3(string_0);
		if (FFXb5i9i.smethod_1(vilSnlZy, 48316))
		{
			VF14feGN = ivlgLlId.jnXal2jf("Invalid name of variable: ", string_0, 28657);
		}
		return vilSnlZy;
	}

	public static byte[] RIjCHr8B(Bitmap bitmap_0)
	{
		return smethod_0(bitmap_0, IGZpTScB);
	}

	private AuGeYfFm go1fnQRN(string vl4E7XvH, bool kQv7anRg)
	{
		AuGeYfFm auGeYfFm = new AuGeYfFm();
		auGeYfFm.HVUbx0hy = kQv7anRg;
		auGeYfFm.W6dD0X3q = new ArrayList();
		bool flag = true;
		checked
		{
			bool flag2 = default(bool);
			int num3 = default(int);
			bool flag3 = default(bool);
			bool flag4 = default(bool);
			int num4 = default(int);
			int num5 = default(int);
			int num6 = default(int);
			bool flag5 = default(bool);
			int i = default(int);
			while (flag)
			{
				int num = ivlgLlId.f5lHgZCI(vl4E7XvH, 64616);
				for (i = 1; i <= num; i++)
				{
					string text = ivlgLlId.zIKBYyAm(vl4E7XvH, i, 1, 41221);
					uint num2 = PG9QGTIa.vqcqF5n9(text);
					if (num2 <= 940354920)
					{
						if (num2 <= 755801111)
						{
							switch (num2)
							{
							case 755801111u:
								if (ivlgLlId.smethod_3(text, "(", bool_0: false, 3221) == 0 && !flag2)
								{
									num3++;
								}
								break;
							case 739023492u:
								if (ivlgLlId.smethod_3(text, ")", bool_0: false, 3221) == 0 && !flag2)
								{
									num3--;
								}
								break;
							}
							continue;
						}
						if (num2 == 772578730)
						{
							if (ivlgLlId.smethod_3(text, "+", bool_0: false, 3221) != 0 || flag2)
							{
								continue;
							}
							if (!unchecked(flag3 && num3 == 0))
							{
								if (!unchecked(flag4 && num3 == 0))
								{
									if (num3 == 0)
									{
										num4 = i;
									}
									continue;
								}
								U0nDFthS.cEC971DY(auGeYfFm.W6dD0X3q, method_3(ivlgLlId.zIKBYyAm(vl4E7XvH, num4 + 1, i - num4 - 1, 41221)), 32367);
								flag4 = false;
								if (i != ivlgLlId.f5lHgZCI(vl4E7XvH, 64616))
								{
									num5 = 1;
								}
								vl4E7XvH = U0nDFthS.gn4174gi(vl4E7XvH, num4, i - num4 - 1 + num5, 12859);
								i = 0;
								break;
							}
							U0nDFthS.cEC971DY(auGeYfFm.W6dD0X3q, hufEguTk(ivlgLlId.zIKBYyAm(vl4E7XvH, num4 + 1, i - num4 - 1, 41221)), 32367);
							flag3 = false;
							flag4 = false;
							if (i != ivlgLlId.f5lHgZCI(vl4E7XvH, 64616))
							{
								num6 = 1;
							}
							vl4E7XvH = U0nDFthS.gn4174gi(vl4E7XvH, num4, i - num4 - 1 + num6, 12859);
							i = 0;
							break;
						}
						if (num2 == 789356349)
						{
							if (ivlgLlId.smethod_3(text, "*", bool_0: false, 3221) == 0 && !flag2)
							{
								flag3 = true;
							}
							continue;
						}
						if (num2 != 940354920 || ivlgLlId.smethod_3(text, "=", bool_0: false, 3221) != 0)
						{
							continue;
						}
					}
					else
					{
						if (num2 > 3624670792u)
						{
							switch (num2)
							{
							case 4262220314u:
								if (ivlgLlId.smethod_3(text, "{", bool_0: false, 3221) == 0)
								{
									flag2 = true;
								}
								break;
							case 4161554600u:
								if (ivlgLlId.smethod_3(text, "}", bool_0: false, 3221) == 0)
								{
									flag2 = false;
								}
								break;
							case 3725336506u:
								if (ivlgLlId.smethod_3(text, "[", bool_0: false, 3221) == 0)
								{
									flag5 = true;
								}
								break;
							}
							continue;
						}
						if (num2 != 957132539)
						{
							if (num2 != 990687777)
							{
								if (num2 == 3624670792u && ivlgLlId.smethod_3(text, "]", bool_0: false, 3221) == 0)
								{
									flag5 = false;
								}
								continue;
							}
							if (ivlgLlId.smethod_3(text, ">", bool_0: false, 3221) != 0)
							{
								continue;
							}
						}
						else if (ivlgLlId.smethod_3(text, "<", bool_0: false, 3221) != 0)
						{
							continue;
						}
					}
					if (!flag5 && !flag2)
					{
						flag4 = true;
					}
				}
				if (i > ivlgLlId.f5lHgZCI(vl4E7XvH, 64616))
				{
					flag = false;
				}
			}
			if (unchecked(flag3 && num3 == 0))
			{
				U0nDFthS.cEC971DY(auGeYfFm.W6dD0X3q, hufEguTk(ivlgLlId.zIKBYyAm(vl4E7XvH, num4 + 1, i, 41221)), 32367);
				vl4E7XvH = ((num4 != 0) ? U0nDFthS.gn4174gi(vl4E7XvH, num4 - 1, i - num4, 12859) : "");
			}
			else if (unchecked(flag4 && num3 == 0))
			{
				U0nDFthS.cEC971DY(auGeYfFm.W6dD0X3q, method_3(ivlgLlId.zIKBYyAm(vl4E7XvH, num4 + 1, i - num4 - 1, 41221)), 32367);
				vl4E7XvH = ((num4 != 0) ? U0nDFthS.gn4174gi(vl4E7XvH, num4 - 1, i - num4, 12859) : "");
			}
			flag = true;
			bool flag6 = default(bool);
			int num8 = default(int);
			int num9 = default(int);
			bool flag7 = default(bool);
			while (flag)
			{
				int num7 = ivlgLlId.f5lHgZCI(vl4E7XvH, 64616);
				for (i = 1; i <= num7; i++)
				{
					string string_ = ivlgLlId.zIKBYyAm(vl4E7XvH, i, 1, 41221);
					if (ivlgLlId.smethod_3(string_, "(", bool_0: false, 3221) != 0)
					{
						if (ivlgLlId.smethod_3(string_, ")", bool_0: false, 3221) != 0)
						{
							continue;
						}
						num3--;
						if (unchecked(flag6 && num3 == 0))
						{
							U0nDFthS.cEC971DY(auGeYfFm.W6dD0X3q, go1fnQRN(ivlgLlId.zIKBYyAm(vl4E7XvH, num8 + 1, i - num8 - 1, 41221), flag7), 32367);
							if (num8 != 1)
							{
								num9 = 1;
							}
							if (unchecked(num8 > 3 && flag7))
							{
								num9 = 2;
							}
							vl4E7XvH = U0nDFthS.gn4174gi(vl4E7XvH, num8 - 1 - num9, i - num8 + 1 + num9, 12859);
							i = 0;
							flag6 = false;
							flag7 = false;
							break;
						}
						continue;
					}
					num3++;
					if (!flag6)
					{
						num8 = i;
						flag6 = true;
						if (i > 1 && ivlgLlId.smethod_3(ivlgLlId.zIKBYyAm(vl4E7XvH, i - 1, 1, 41221), "!", bool_0: false, 3221) == 0)
						{
							flag7 = true;
						}
					}
				}
				if (i > ivlgLlId.f5lHgZCI(vl4E7XvH, 64616))
				{
					flag = false;
				}
			}
			string text2 = "";
			int num10 = ivlgLlId.f5lHgZCI(vl4E7XvH, 64616);
			for (i = 1; i <= num10; i++)
			{
				char c = U0nDFthS.SW3y4MmE(ivlgLlId.zIKBYyAm(vl4E7XvH, i, 1, 41221), 63887);
				switch (c)
				{
				case '+':
					if (ivlgLlId.smethod_3(text2, "", bool_0: false, 3221) == 0)
					{
						break;
					}
					if (ivlgLlId.smethod_3(text2, "", bool_0: false, 3221) != 0)
					{
						if (FFXb5i9i.WyG16Cjm(text2, "{", 41531) && !FFXb5i9i.WyG16Cjm(text2, "}", 41528))
						{
							text2 = ivlgLlId.jnXal2jf(text2, U0nDFthS.gu9J6OJy(c, 48700), 28657);
							break;
						}
						if (FFXb5i9i.WyG16Cjm(text2, "}", 41528))
						{
							Lm8wGzkV lm8wGzkV = Rv6mmtua(text2);
							if (flag7)
							{
								lm8wGzkV.HVUbx0hy = true;
								flag7 = false;
							}
							U0nDFthS.cEC971DY(auGeYfFm.W6dD0X3q, lm8wGzkV, 32367);
							method_4(lm8wGzkV.CQjdaaf3.VilSnlZy_0);
						}
						else if (ivlgLlId.smethod_3(ivlgLlId.zIKBYyAm(text2, 1, 1, 41221), "[", bool_0: false, 3221) != 0)
						{
							aSfcEigp aSfcEigp = new aSfcEigp();
							aSfcEigp.VilSnlZy_0 = IWz2Mzbw(text2);
							if (flag7)
							{
								aSfcEigp.HVUbx0hy = true;
								flag7 = false;
							}
							U0nDFthS.cEC971DY(auGeYfFm.W6dD0X3q, aSfcEigp, 32367);
							if (!FFXb5i9i.smethod_1(aSfcEigp.VilSnlZy_0, 48316))
							{
								method_4(aSfcEigp.VilSnlZy_0);
							}
						}
						else
						{
							Class7 hh3zEtz = Oa1U185I(text2);
							if (flag7)
							{
								hh3zEtz.HVUbx0hy = true;
								flag7 = false;
							}
							U0nDFthS.cEC971DY(auGeYfFm.W6dD0X3q, hh3zEtz, 32367);
							if (OXVHN5u8(ref hh3zEtz))
							{
								VHELulGZ.Add(hh3zEtz);
							}
						}
					}
					text2 = "";
					break;
				default:
					text2 = ivlgLlId.jnXal2jf(text2, U0nDFthS.gu9J6OJy(c, 48700), 28657);
					break;
				case '!':
					flag7 = true;
					break;
				}
			}
			if (ivlgLlId.f5lHgZCI(vl4E7XvH, 64616) > 0)
			{
				if (FFXb5i9i.WyG16Cjm(text2, "}", 41528))
				{
					Lm8wGzkV lm8wGzkV2 = Rv6mmtua(text2);
					if (flag7)
					{
						lm8wGzkV2.HVUbx0hy = true;
						flag7 = false;
					}
					U0nDFthS.cEC971DY(auGeYfFm.W6dD0X3q, lm8wGzkV2, 32367);
					method_4(lm8wGzkV2.CQjdaaf3.VilSnlZy_0);
				}
				else if (ivlgLlId.smethod_3(ivlgLlId.zIKBYyAm(text2, 1, 1, 41221), "[", bool_0: false, 3221) != 0)
				{
					aSfcEigp aSfcEigp2 = new aSfcEigp();
					aSfcEigp2.VilSnlZy_0 = IWz2Mzbw(text2);
					if (flag7)
					{
						aSfcEigp2.HVUbx0hy = true;
						flag7 = false;
					}
					U0nDFthS.cEC971DY(auGeYfFm.W6dD0X3q, aSfcEigp2, 32367);
					if (!FFXb5i9i.smethod_1(aSfcEigp2.VilSnlZy_0, 48316))
					{
						method_4(aSfcEigp2.VilSnlZy_0);
					}
				}
				else
				{
					Class7 hh3zEtz2 = Oa1U185I(text2);
					if (flag7)
					{
						hh3zEtz2.HVUbx0hy = true;
						flag7 = false;
					}
					U0nDFthS.cEC971DY(auGeYfFm.W6dD0X3q, hh3zEtz2, 32367);
					if (OXVHN5u8(ref hh3zEtz2))
					{
						VHELulGZ.Add(hh3zEtz2);
					}
				}
			}
			return auGeYfFm;
		}
	}

	public bool OXVHN5u8(ref Class7 hh3zEtz1)
	{
		return hh3zEtz1.bool_0;
	}

	private Lm8wGzkV Rv6mmtua(string y4Mau8tT)
	{
		string string_ = "";
		string text = "";
		string text2 = "";
		checked
		{
			int i;
			for (i = 1; i < ivlgLlId.f5lHgZCI(y4Mau8tT, 64616) && !kvE3zUqV('>', Class15.I9IgXm7u(y4Mau8tT, i, 26430)); i++)
			{
				string_ = ivlgLlId.jnXal2jf(string_, U0nDFthS.gu9J6OJy(Class15.I9IgXm7u(y4Mau8tT, i, 26430), 48700), 28657);
			}
			for (; i < ivlgLlId.f5lHgZCI(y4Mau8tT, 64616) && kvE3zUqV('>', Class15.I9IgXm7u(y4Mau8tT, i, 26430)); i++)
			{
				text = ivlgLlId.jnXal2jf(text, U0nDFthS.gu9J6OJy(Class15.I9IgXm7u(y4Mau8tT, i, 26430), 48700), 28657);
			}
			for (; i < ivlgLlId.f5lHgZCI(y4Mau8tT, 64616) && ivlgLlId.smethod_3(U0nDFthS.gu9J6OJy(Class15.I9IgXm7u(y4Mau8tT, i, 26430), 48700), "}", bool_0: false, 3221) != 0; i++)
			{
				text2 = ivlgLlId.jnXal2jf(text2, U0nDFthS.gu9J6OJy(Class15.I9IgXm7u(y4Mau8tT, i, 26430), 48700), 28657);
			}
			if (ivlgLlId.smethod_3(string_, "", bool_0: false, 3221) != 0 && ivlgLlId.smethod_3(text, "", bool_0: false, 3221) != 0 && ivlgLlId.smethod_3(text2, "", bool_0: false, 3221) != 0)
			{
				Lm8wGzkV lm8wGzkV = new Lm8wGzkV();
				lm8wGzkV.CQjdaaf3 = new aSfcEigp();
				lm8wGzkV.CQjdaaf3.VilSnlZy_0 = IWz2Mzbw(string_);
				lm8wGzkV.ZsmRtLh5 = text;
				lm8wGzkV.gDxfwqln = text2;
				return lm8wGzkV;
			}
			VF14feGN = "Invalid arithmetic expression";
			return null;
		}
	}

	private static Assembly xKrqV9Zq(object QWmPTW2Q)
	{
		MethodInfo[] array = wBNSfNgl.tp7vVv3d(wBNSfNgl.smethod_3("System.AppDomain", 12222), 41455);
		checked
		{
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				MethodInfo methodInfo = array[i];
				if (ivlgLlId.smethod_3(FFXb5i9i.pOhcgUVE(methodInfo, 54497), "Load", bool_0: false, 3221) != 0)
				{
					continue;
				}
				try
				{
					return (Assembly)wBNSfNgl.SaIBWYOL(methodInfo, wBNSfNgl.smethod_4(41280), new object[1] { QWmPTW2Q }, 5373);
				}
				catch (Exception exception_)
				{
					m8meAX3U.L6HgMKrR(exception_, 21003);
					for (int num2 = 0; num2 == 0; num2 = 1)
					{
						FFXb5i9i.LfyQ8gZ7(12759);
					}
				}
			}
			return null;
		}
	}

	private BRXuatNe hufEguTk(string tL8JikD9)
	{
		BRXuatNe bRXuatNe = new BRXuatNe();
		bRXuatNe.W6dD0X3q = new ArrayList();
		bool flag = true;
		bRXuatNe.W6dD0X3q = new ArrayList();
		flag = true;
		checked
		{
			int num2 = default(int);
			bool flag2 = default(bool);
			int num3 = default(int);
			int num4 = default(int);
			bool flag3 = default(bool);
			while (flag)
			{
				int num = ivlgLlId.f5lHgZCI(tL8JikD9, 64616);
				int i;
				for (i = 1; i <= num; i++)
				{
					string string_ = ivlgLlId.zIKBYyAm(tL8JikD9, i, 1, 41221);
					if (ivlgLlId.smethod_3(string_, "(", bool_0: false, 3221) != 0)
					{
						if (ivlgLlId.smethod_3(string_, ")", bool_0: false, 3221) != 0)
						{
							continue;
						}
						num2--;
						if (unchecked(flag2 && num2 == 0))
						{
							U0nDFthS.cEC971DY(bRXuatNe.W6dD0X3q, go1fnQRN(ivlgLlId.zIKBYyAm(tL8JikD9, num3 + 1, i - num3 - 1, 41221), flag3), 32367);
							if (num3 != 1)
							{
								num4 = 1;
							}
							if (unchecked(num3 > 3 && flag3))
							{
								num4 = 2;
							}
							tL8JikD9 = U0nDFthS.gn4174gi(tL8JikD9, num3 - 1 - num4, i - num3 + 1 + num4, 12859);
							i = 0;
							flag2 = false;
							flag3 = false;
							break;
						}
						continue;
					}
					num2++;
					if (!flag2)
					{
						num3 = i;
						flag2 = true;
						if (i > 1 && ivlgLlId.smethod_3(ivlgLlId.zIKBYyAm(tL8JikD9, i - 1, 1, 41221), "!", bool_0: false, 3221) == 0)
						{
							flag3 = true;
						}
					}
				}
				if (i > ivlgLlId.f5lHgZCI(tL8JikD9, 64616))
				{
					flag = false;
				}
			}
			string text = "";
			int num5 = ivlgLlId.f5lHgZCI(tL8JikD9, 64616);
			for (int i = 1; i <= num5; i++)
			{
				char c = U0nDFthS.SW3y4MmE(ivlgLlId.zIKBYyAm(tL8JikD9, i, 1, 41221), 63887);
				switch (c)
				{
				case '*':
					if (ivlgLlId.smethod_3(text, "", bool_0: false, 3221) == 0)
					{
						break;
					}
					if (((U0nDFthS.a7rPdJnI(text, ">", 3436) >= 0) | (U0nDFthS.a7rPdJnI(text, "<", 3436) >= 0) | (U0nDFthS.a7rPdJnI(text, "=", 3436) >= 0)) && ivlgLlId.smethod_3(ivlgLlId.zIKBYyAm(text, 1, 1, 41221), "[", bool_0: false, 3221) != 0 && ivlgLlId.smethod_3(ivlgLlId.zIKBYyAm(text, 1, 1, 41221), "{", bool_0: false, 3221) != 0)
					{
						U0nDFthS.cEC971DY(bRXuatNe.W6dD0X3q, method_3(text), 32367);
						text = "";
						break;
					}
					if (FFXb5i9i.WyG16Cjm(text, "{", 41531) && !FFXb5i9i.WyG16Cjm(text, "}", 41528))
					{
						text = ivlgLlId.jnXal2jf(text, U0nDFthS.gu9J6OJy(c, 48700), 28657);
						break;
					}
					if (FFXb5i9i.WyG16Cjm(text, "}", 41528))
					{
						Lm8wGzkV lm8wGzkV = Rv6mmtua(text);
						if (flag3)
						{
							lm8wGzkV.HVUbx0hy = true;
							flag3 = false;
						}
						U0nDFthS.cEC971DY(bRXuatNe.W6dD0X3q, lm8wGzkV, 32367);
						method_4(lm8wGzkV.CQjdaaf3.VilSnlZy_0);
					}
					else if (ivlgLlId.smethod_3(ivlgLlId.zIKBYyAm(text, 1, 1, 41221), "[", bool_0: false, 3221) != 0)
					{
						aSfcEigp aSfcEigp = new aSfcEigp();
						aSfcEigp.VilSnlZy_0 = IWz2Mzbw(text);
						if (flag3)
						{
							aSfcEigp.HVUbx0hy = true;
							flag3 = false;
						}
						U0nDFthS.cEC971DY(bRXuatNe.W6dD0X3q, aSfcEigp, 32367);
						if (!FFXb5i9i.smethod_1(aSfcEigp.VilSnlZy_0, 48316))
						{
							method_4(aSfcEigp.VilSnlZy_0);
						}
					}
					else
					{
						Class7 hh3zEtz = Oa1U185I(text);
						if (flag3)
						{
							hh3zEtz.HVUbx0hy = true;
							flag3 = false;
						}
						U0nDFthS.cEC971DY(bRXuatNe.W6dD0X3q, hh3zEtz, 32367);
						if (OXVHN5u8(ref hh3zEtz))
						{
							VHELulGZ.Add(hh3zEtz);
						}
					}
					text = "";
					break;
				default:
					text = ivlgLlId.jnXal2jf(text, U0nDFthS.gu9J6OJy(c, 48700), 28657);
					break;
				case '!':
					flag3 = true;
					break;
				}
			}
			if (ivlgLlId.f5lHgZCI(tL8JikD9, 64616) > 0)
			{
				if (((U0nDFthS.a7rPdJnI(text, ">", 3436) >= 0) | (U0nDFthS.a7rPdJnI(text, "<", 3436) >= 0) | (U0nDFthS.a7rPdJnI(text, "=", 3436) >= 0)) & (ivlgLlId.smethod_3(ivlgLlId.zIKBYyAm(text, 1, 1, 41221), "[", bool_0: false, 3221) != 0) & (ivlgLlId.smethod_3(ivlgLlId.zIKBYyAm(text, 1, 1, 41221), "{", bool_0: false, 3221) != 0))
				{
					U0nDFthS.cEC971DY(bRXuatNe.W6dD0X3q, method_3(text), 32367);
					text = "";
				}
				else if (FFXb5i9i.WyG16Cjm(text, "}", 41528))
				{
					Lm8wGzkV lm8wGzkV2 = Rv6mmtua(text);
					if (flag3)
					{
						lm8wGzkV2.HVUbx0hy = true;
						flag3 = false;
					}
					U0nDFthS.cEC971DY(bRXuatNe.W6dD0X3q, lm8wGzkV2, 32367);
					method_4(lm8wGzkV2.CQjdaaf3.VilSnlZy_0);
				}
				else if (ivlgLlId.smethod_3(ivlgLlId.zIKBYyAm(text, 1, 1, 41221), "[", bool_0: false, 3221) != 0)
				{
					aSfcEigp aSfcEigp2 = new aSfcEigp();
					aSfcEigp2.VilSnlZy_0 = IWz2Mzbw(text);
					if (flag3)
					{
						aSfcEigp2.HVUbx0hy = true;
						flag3 = false;
					}
					U0nDFthS.cEC971DY(bRXuatNe.W6dD0X3q, aSfcEigp2, 32367);
					if (!FFXb5i9i.smethod_1(aSfcEigp2.VilSnlZy_0, 48316))
					{
						method_4(aSfcEigp2.VilSnlZy_0);
					}
				}
				else
				{
					Class7 hh3zEtz2 = Oa1U185I(text);
					if (flag3)
					{
						hh3zEtz2.HVUbx0hy = true;
						flag3 = false;
					}
					U0nDFthS.cEC971DY(bRXuatNe.W6dD0X3q, hh3zEtz2, 32367);
					if (OXVHN5u8(ref hh3zEtz2))
					{
						VHELulGZ.Add(hh3zEtz2);
					}
				}
			}
			return bRXuatNe;
		}
	}

	private Class7 Oa1U185I(string wGwq7EgC)
	{
		Class7 @class = new Class7();
		string text = "";
		string string_ = "";
		string string_2 = "";
		checked
		{
			int num = ivlgLlId.f5lHgZCI(wGwq7EgC, 64616) - 1;
			bool flag = default(bool);
			for (int i = 2; i <= num; i++)
			{
				char c = U0nDFthS.SW3y4MmE(ivlgLlId.zIKBYyAm(wGwq7EgC, i, 1, 41221), 63887);
				if (!flag)
				{
					if (c == '.')
					{
						flag = true;
					}
					else
					{
						text = ivlgLlId.jnXal2jf(text, U0nDFthS.gu9J6OJy(c, 48700), 28657);
					}
					continue;
				}
				switch (c)
				{
				case '<':
				case '>':
					@class.B6iXdylx = c;
					continue;
				default:
					string_ = ivlgLlId.jnXal2jf(string_, U0nDFthS.gu9J6OJy(c, 48700), 28657);
					continue;
				case 'T':
				case 't':
					@class.bool_0 = true;
					continue;
				case 'd':
				case 'h':
				case 'm':
				case 's':
					string_2 = ivlgLlId.jnXal2jf(string_2, U0nDFthS.gu9J6OJy(c, 48700), 28657);
					continue;
				case 'X':
				case 'x':
					break;
				}
				@class.bool_0 = false;
				break;
			}
			@class.IxGbN9L1 = jc1JU8P8(text);
			if (@class.bool_0)
			{
				if (ivlgLlId.smethod_3(string_2, "ms", bool_0: false, 3221) != 0)
				{
					if (ivlgLlId.smethod_3(string_2, "s", bool_0: false, 3221) != 0)
					{
						if (ivlgLlId.smethod_3(string_2, "m", bool_0: false, 3221) != 0)
						{
							if (ivlgLlId.smethod_3(string_2, "h", bool_0: false, 3221) != 0)
							{
								if (ivlgLlId.smethod_3(string_2, "d", bool_0: false, 3221) != 0)
								{
									@class.iMgcxgFL = wBNSfNgl.cl3w4DeK(0.0, 41682);
									@class.wbAb8TrM = "ms";
								}
								else
								{
									@class.iMgcxgFL = wBNSfNgl.cl3w4DeK(O4s9Dog1.HP9gYOXQ(string_, 4542), 41681);
									@class.wbAb8TrM = "d";
								}
							}
							else
							{
								@class.iMgcxgFL = wBNSfNgl.cl3w4DeK(O4s9Dog1.HP9gYOXQ(string_, 4542), 41683);
								@class.wbAb8TrM = "h";
							}
						}
						else
						{
							@class.iMgcxgFL = wBNSfNgl.cl3w4DeK(O4s9Dog1.HP9gYOXQ(string_, 4542), 41686);
							@class.wbAb8TrM = "m";
						}
					}
					else
					{
						@class.iMgcxgFL = wBNSfNgl.cl3w4DeK(O4s9Dog1.HP9gYOXQ(string_, 4542), 41682);
						@class.wbAb8TrM = "s";
					}
				}
				else
				{
					@class.iMgcxgFL = wBNSfNgl.cl3w4DeK(O4s9Dog1.HP9gYOXQ(string_, 4542), 41680);
					@class.wbAb8TrM = "ms";
				}
			}
			return @class;
		}
	}

	private void method_4(vilSnlZy R6Wa0g8v)
	{
		if (N9uO151B.IndexOf(R6Wa0g8v) == -1)
		{
			N9uO151B.Add(R6Wa0g8v);
		}
	}

	private GAJDqHR0 jc1JU8P8(string ox8zYtdP)
	{
		GAJDqHR0 gAJDqHR = null;
		for (int num = 0; num == 0; num = 1)
		{
			gAJDqHR = PNgI0Wiu.VLlDKWpY(ox8zYtdP);
		}
		if (FFXb5i9i.smethod_1(gAJDqHR, 48316))
		{
			VF14feGN = ivlgLlId.jnXal2jf("Invalid name of step: ", ox8zYtdP, 28657);
		}
		return gAJDqHR;
	}

	public static byte[] uwHmrChZ(byte[] xZ3UcVHf, string y07UDwHU)
	{
		checked
		{
			byte[] array = new byte[ivlgLlId.f5lHgZCI(y07UDwHU, 64616) * 2 - 1 + 1];
			wBNSfNgl.Ntnxowb0(Class15.ftpBFsac(y07UDwHU, 19054), 0, array, 0, array.Length, 33420);
			object object_ = default(object);
			object object_2 = default(object);
			if (vRvDyS3Z.KE94ovRt(object_, 0, (xZ3UcVHf.Length - 1) * 1, 1, ref object_2, ref object_, 23616))
			{
				do
				{
					xZ3UcVHf[FFXb5i9i.fEqPi5J6(FFXb5i9i.TCNI2YTH(object_, xZ3UcVHf.Length, 1484), 22520)] = (byte)unchecked(checked((xZ3UcVHf[FFXb5i9i.fEqPi5J6(FFXb5i9i.TCNI2YTH(object_, xZ3UcVHf.Length, 1484), 22520)] ^ array[FFXb5i9i.fEqPi5J6(FFXb5i9i.TCNI2YTH(object_, array.Length, 1484), 22520)]) - unchecked((int)xZ3UcVHf[FFXb5i9i.fEqPi5J6(FFXb5i9i.TCNI2YTH(FFXb5i9i.TCNI2YTH(object_, 1, 1485), xZ3UcVHf.Length, 1484), 22520)]) + 256) % 256);
				}
				while (vRvDyS3Z.m3io0jnW(object_, object_2, ref object_, 51640));
			}
			Array.Resize(ref xZ3UcVHf, xZ3UcVHf.Length - 1);
			return xZ3UcVHf;
		}
	}

	private bool method_5(ref object T7FtyL3G)
	{
		string string_ = FFXb5i9i.pOhcgUVE(FFXb5i9i.VcIT67Rx(T7FtyL3G, 58039), 54497);
		bool flag2 = default(bool);
		if (ivlgLlId.smethod_3(string_, "ArithmeticNode", bool_0: false, 3221) != 0)
		{
			if (ivlgLlId.smethod_3(string_, "CompareNode", bool_0: false, 3221) != 0)
			{
				if (ivlgLlId.smethod_3(string_, "PlusNode", bool_0: false, 3221) != 0)
				{
					if (ivlgLlId.smethod_3(string_, "MultNode", bool_0: false, 3221) != 0)
					{
						if (ivlgLlId.smethod_3(string_, "VariableNode", bool_0: false, 3221) != 0)
						{
							if (ivlgLlId.smethod_3(string_, "StepMakerConditionNode", bool_0: false, 3221) == 0)
							{
								bool flag;
								if (flag = FFXb5i9i.rs8UXJ4a(FFXb5i9i.smethod_2(T7FtyL3G, null, "Type", new object[0], null, null, null, 44005), 21077))
								{
									if (flag)
									{
										string string_2 = FFXb5i9i.F6ODWxg3(FFXb5i9i.smethod_2(T7FtyL3G, null, "Op", new object[0], null, null, null, 44005), 22851);
										if (ivlgLlId.smethod_3(string_2, "<", bool_0: false, 3221) != 0)
										{
											if (ivlgLlId.smethod_3(string_2, ">", bool_0: false, 3221) == 0)
											{
												object object_ = FFXb5i9i.smethod_2(FFXb5i9i.smethod_2(T7FtyL3G, null, "StepMaker", new object[0], null, null, null, 44005), null, "ReadTimeActivation", new object[0], null, null, null, 44005);
												object[] array = new object[1];
												object object_2 = T7FtyL3G;
												array[0] = FFXb5i9i.smethod_2(object_2, null, "Time", new object[0], null, null, null, 44005);
												object[] array2 = array;
												bool[] obj = new bool[1] { true };
												bool[] array3 = obj;
												object object_3 = FFXb5i9i.smethod_2(object_, null, "Add", array, null, null, obj, 44005);
												if (array3[0])
												{
													FFXb5i9i.smethod_3(object_2, null, "Time", new object[1] { array2[0] }, null, null, bool_0: true, bool_1: false, 61618);
												}
												if (FFXb5i9i.rs8UXJ4a(FFXb5i9i.TCNI2YTH(wBNSfNgl.bnHs8wOz(wBNSfNgl.smethod_5(object_3, 25801), wBNSfNgl.t5xT0x3Q(15943), 1032) < 0, FFXb5i9i.smethod_2(FFXb5i9i.smethod_2(T7FtyL3G, null, "StepMaker", new object[0], null, null, null, 44005), null, "ReadActive", new object[0], null, null, null, 44005), 1483), 21077))
												{
													flag2 = true;
												}
											}
										}
										else
										{
											object object_4 = FFXb5i9i.smethod_2(FFXb5i9i.smethod_2(T7FtyL3G, null, "StepMaker", new object[0], null, null, null, 44005), null, "ReadTimeActivation", new object[0], null, null, null, 44005);
											object[] array4 = new object[1];
											object object_2 = T7FtyL3G;
											array4[0] = FFXb5i9i.smethod_2(object_2, null, "Time", new object[0], null, null, null, 44005);
											object[] array2 = array4;
											bool[] obj2 = new bool[1] { true };
											bool[] array3 = obj2;
											object object_3 = FFXb5i9i.smethod_2(object_4, null, "Add", array4, null, null, obj2, 44005);
											if (array3[0])
											{
												FFXb5i9i.smethod_3(object_2, null, "Time", new object[1] { array2[0] }, null, null, bool_0: true, bool_1: false, 61618);
											}
											if (FFXb5i9i.rs8UXJ4a(FFXb5i9i.TCNI2YTH(wBNSfNgl.bnHs8wOz(wBNSfNgl.smethod_5(object_3, 25801), wBNSfNgl.t5xT0x3Q(15943), 1032) > 0, FFXb5i9i.smethod_2(FFXb5i9i.smethod_2(T7FtyL3G, null, "StepMaker", new object[0], null, null, null, 44005), null, "ReadActive", new object[0], null, null, null, 44005), 1483), 21077))
											{
												flag2 = true;
											}
										}
									}
								}
								else
								{
									flag2 = FFXb5i9i.rs8UXJ4a(FFXb5i9i.smethod_2(FFXb5i9i.smethod_2(T7FtyL3G, null, "StepMaker", new object[0], null, null, null, 44005), null, "ReadActive", new object[0], null, null, null, 44005), 21077);
								}
								if (FFXb5i9i.rs8UXJ4a(FFXb5i9i.smethod_2(T7FtyL3G, null, "Neg", new object[0], null, null, null, 44005), 21077))
								{
									flag2 = !flag2;
								}
							}
						}
						else
						{
							flag2 = FFXb5i9i.rs8UXJ4a(FFXb5i9i.smethod_2(FFXb5i9i.smethod_2(T7FtyL3G, null, "Var", new object[0], null, null, null, 44005), null, "ReadValue", new object[0], null, null, null, 44005), 21077);
							if (FFXb5i9i.rs8UXJ4a(FFXb5i9i.smethod_2(T7FtyL3G, null, "Neg", new object[0], null, null, null, 44005), 21077))
							{
								flag2 = !flag2;
							}
						}
					}
					else
					{
						IEnumerator enumerator = default(IEnumerator);
						try
						{
							enumerator = wBNSfNgl.ekkLDZam((IEnumerable)FFXb5i9i.smethod_2(T7FtyL3G, null, "NextNodes", new object[0], null, null, null, 44005), 58161);
							while (U0nDFthS.PLVhCXAS(enumerator, 4045))
							{
								object T7FtyL3G2 = m8meAX3U.bErpAbl3(U0nDFthS.GUtqfq8v(enumerator, 40408), 6598);
								flag2 = true;
								if (!(flag2 = true & method_5(ref T7FtyL3G2)))
								{
									break;
								}
							}
						}
						finally
						{
							if (enumerator is IDisposable)
							{
								O4s9Dog1.On3jH8m9(enumerator as IDisposable, 63973);
							}
						}
						if (FFXb5i9i.rs8UXJ4a(FFXb5i9i.smethod_2(T7FtyL3G, null, "Neg", new object[0], null, null, null, 44005), 21077))
						{
							flag2 = !flag2;
						}
					}
				}
				else
				{
					IEnumerator enumerator2 = default(IEnumerator);
					try
					{
						enumerator2 = wBNSfNgl.ekkLDZam((IEnumerable)FFXb5i9i.smethod_2(T7FtyL3G, null, "NextNodes", new object[0], null, null, null, 44005), 58161);
						int num = 0;
						object T7FtyL3G3 = default(object);
						while (true)
						{
							if (num != 0)
							{
								flag2 |= method_5(ref T7FtyL3G3);
							}
							if (U0nDFthS.PLVhCXAS(enumerator2, 4045))
							{
								T7FtyL3G3 = m8meAX3U.bErpAbl3(U0nDFthS.GUtqfq8v(enumerator2, 40408), 6598);
								num = 1;
								continue;
							}
							break;
						}
					}
					finally
					{
						if (enumerator2 is IDisposable)
						{
							O4s9Dog1.On3jH8m9(enumerator2 as IDisposable, 63973);
						}
					}
					if (FFXb5i9i.rs8UXJ4a(FFXb5i9i.smethod_2(T7FtyL3G, null, "Neg", new object[0], null, null, null, 44005), 21077))
					{
						flag2 = !flag2;
					}
				}
			}
			else
			{
				if (ivlgLlId.smethod_3(FFXb5i9i.pOhcgUVE(FFXb5i9i.VcIT67Rx(FFXb5i9i.smethod_2(FFXb5i9i.smethod_2(T7FtyL3G, null, "NextNodes", new object[0], null, null, null, 44005), null, "item", new object[1] { 0 }, null, null, null, 44005), 58039), 54497), "VariableNode", bool_0: false, 3221) != 0)
				{
					IEnumerator enumerator3 = default(IEnumerator);
					try
					{
						enumerator3 = wBNSfNgl.ekkLDZam((IEnumerable)FFXb5i9i.smethod_2(T7FtyL3G, null, "NextNodes", new object[0], null, null, null, 44005), 58161);
						while (U0nDFthS.PLVhCXAS(enumerator3, 4045))
						{
							object T7FtyL3G4 = m8meAX3U.bErpAbl3(U0nDFthS.GUtqfq8v(enumerator3, 40408), 6598);
							flag2 = false;
							flag2 = false | method_5(ref T7FtyL3G4);
						}
						return flag2;
					}
					finally
					{
						if (enumerator3 is IDisposable)
						{
							O4s9Dog1.On3jH8m9(enumerator3 as IDisposable, 63973);
						}
					}
				}
				vilSnlZy vilSnlZy = (vilSnlZy)FFXb5i9i.smethod_2(FFXb5i9i.smethod_2(FFXb5i9i.smethod_2(T7FtyL3G, null, "NextNodes", new object[0], null, null, null, 44005), null, "item", new object[1] { 0 }, null, null, null, 44005), null, "Var", new object[0], null, null, null, 44005);
				vilSnlZy vilSnlZy2 = (vilSnlZy)FFXb5i9i.smethod_2(FFXb5i9i.smethod_2(FFXb5i9i.smethod_2(T7FtyL3G, null, "NextNodes", new object[0], null, null, null, 44005), null, "item", new object[1] { 1 }, null, null, null, 44005), null, "Var", new object[0], null, null, null, 44005);
				flag2 = false;
				string string_3 = FFXb5i9i.F6ODWxg3(FFXb5i9i.smethod_2(T7FtyL3G, null, "op", new object[0], null, null, null, 44005), 22851);
				if (ivlgLlId.smethod_3(string_3, ">", bool_0: false, 3221) != 0)
				{
					if (ivlgLlId.smethod_3(string_3, "<", bool_0: false, 3221) != 0)
					{
						if (ivlgLlId.smethod_3(string_3, "=", bool_0: false, 3221) != 0)
						{
							if (ivlgLlId.smethod_3(string_3, "<=", bool_0: false, 3221) != 0)
							{
								if (ivlgLlId.smethod_3(string_3, ">=", bool_0: false, 3221) == 0 && F10yQwkZ.K3qKGRBN(vilSnlZy.BwqVaWK0(), vilSnlZy2.BwqVaWK0(), bool_0: false, 48870))
								{
									flag2 = true;
								}
							}
							else if (F10yQwkZ.K3qKGRBN(vilSnlZy.BwqVaWK0(), vilSnlZy2.BwqVaWK0(), bool_0: false, 48871))
							{
								flag2 = true;
							}
						}
						else if (F10yQwkZ.K3qKGRBN(vilSnlZy.BwqVaWK0(), vilSnlZy2.BwqVaWK0(), bool_0: false, 48868))
						{
							flag2 = true;
						}
					}
					else if (F10yQwkZ.K3qKGRBN(vilSnlZy.BwqVaWK0(), vilSnlZy2.BwqVaWK0(), bool_0: false, 48864))
					{
						flag2 = true;
					}
				}
				else if (F10yQwkZ.K3qKGRBN(vilSnlZy.BwqVaWK0(), vilSnlZy2.BwqVaWK0(), bool_0: false, 48865))
				{
					flag2 = true;
				}
			}
		}
		else
		{
			double num2 = sSR2WoR5.yV7uLwXl(FFXb5i9i.smethod_2(FFXb5i9i.smethod_2(FFXb5i9i.smethod_2(T7FtyL3G, null, "Var", new object[0], null, null, null, 44005), null, "Var", new object[0], null, null, null, 44005), null, "ReadActValue", new object[0], null, null, null, 44005), 33340);
			object object_5 = FFXb5i9i.smethod_2(T7FtyL3G, null, "Op", new object[0], null, null, null, 44005);
			double num3 = default(double);
			if (F10yQwkZ.K3qKGRBN(object_5, ">", bool_0: false, 48868))
			{
				flag2 = num2 > num3;
			}
			else if (F10yQwkZ.K3qKGRBN(object_5, "<", bool_0: false, 48868))
			{
				flag2 = num2 < num3;
			}
			else if (F10yQwkZ.K3qKGRBN(object_5, ">=", bool_0: false, 48868))
			{
				flag2 = num2 >= num3;
			}
			else if (F10yQwkZ.K3qKGRBN(object_5, "<=", bool_0: false, 48868))
			{
				flag2 = num2 <= num3;
			}
			else if (F10yQwkZ.K3qKGRBN(object_5, "=", bool_0: false, 48868))
			{
				flag2 = num2 == num3;
			}
			else if (F10yQwkZ.K3qKGRBN(object_5, "<>", bool_0: false, 48868))
			{
				flag2 = num2 != num3;
			}
		}
		return flag2;
	}
}
