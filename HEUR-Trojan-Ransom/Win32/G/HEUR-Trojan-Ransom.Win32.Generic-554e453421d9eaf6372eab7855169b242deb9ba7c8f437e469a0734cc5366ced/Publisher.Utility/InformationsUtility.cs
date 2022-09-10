using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.Win32;

namespace Publisher.Utility;

internal class InformationsUtility
{
	public static bool showIn_special_Browser(string link_show, int internt_explorer, int firefox, int chrome)
	{
		try
		{
			bool result = default(bool);
			if (internt_explorer == 0 && firefox == 0 && chrome == 1)
			{
				foreach (string item in CommonConfig.BrowserInstalledLocation)
				{
					while (true)
					{
						bool flag = MvBZ0SNxQ6IuhBxomQs(item, "chrome");
						_ = 1;
						if (hmtOvtN4xAd8yrgIoXV())
						{
							if (hmtOvtN4xAd8yrgIoXV())
							{
							}
							switch (3)
							{
							case 5:
								break;
							case 0:
							case 1:
								goto IL_006e;
							default:
								goto IL_007f;
							case 4:
								goto IL_0087;
							case 6:
								return result;
							}
							continue;
						}
						goto IL_006e;
						IL_007f:
						Process.Start(item, link_show);
						goto IL_0087;
						IL_0087:
						return true;
						IL_006e:
						if (!flag)
						{
							break;
						}
						goto IL_007f;
					}
				}
			}
			else if (internt_explorer == 1 && firefox == 0 && chrome == 0)
			{
				bool flag2 = default(bool);
				foreach (string item2 in CommonConfig.BrowserInstalledLocation)
				{
					int num = 0;
					if (!hmtOvtN4xAd8yrgIoXV())
					{
					}
					while (true)
					{
						switch (num)
						{
						case 3:
						case 5:
							result = true;
							num = 6;
							if (!hmtOvtN4xAd8yrgIoXV())
							{
								break;
							}
							goto default;
						default:
							LwqKcKNri4vVqBcpb1j(item2, link_show);
							goto case 3;
						case 1:
						case 2:
							if (!flag2)
							{
								goto end_IL_0123;
							}
							goto default;
						case 0:
							flag2 = MvBZ0SNxQ6IuhBxomQs(item2, "iexplore");
							_ = 0;
							if (qEEgwHNeQ3M4bmt6rqQ())
							{
								num = 2;
								if (qEEgwHNeQ3M4bmt6rqQ())
								{
									break;
								}
							}
							goto case 3;
						case 6:
							return result;
						}
						continue;
						end_IL_0123:
						break;
					}
				}
			}
			else if (internt_explorer == 0 && firefox == 1 && chrome == 0)
			{
				foreach (string item3 in CommonConfig.BrowserInstalledLocation)
				{
					if (MvBZ0SNxQ6IuhBxomQs(item3, "firefox"))
					{
						_ = 1;
						if (!hmtOvtN4xAd8yrgIoXV())
						{
							LwqKcKNri4vVqBcpb1j(item3, link_show);
						}
						return true;
					}
				}
			}
			else if (internt_explorer == 0 && firefox == 1 && chrome == 1)
			{
				foreach (string item4 in CommonConfig.BrowserInstalledLocation)
				{
					hmtOvtN4xAd8yrgIoXV();
					if (qEEgwHNeQ3M4bmt6rqQ())
					{
						if (!MvBZ0SNxQ6IuhBxomQs(item4, "firefox") && !MvBZ0SNxQ6IuhBxomQs(item4, "chrome"))
						{
							continue;
						}
						LwqKcKNri4vVqBcpb1j(item4, link_show);
					}
					return true;
				}
			}
			else if (internt_explorer == 1 && firefox == 0 && chrome == 1)
			{
				foreach (string item5 in CommonConfig.BrowserInstalledLocation)
				{
					if (qEEgwHNeQ3M4bmt6rqQ())
					{
						switch (3)
						{
						case 3:
							break;
						case 1:
						case 4:
							goto IL_02da;
						default:
							goto IL_02f7;
						case 0:
							goto IL_0300;
						case 6:
							return result;
						}
					}
					if (!item5.Contains("iexplore"))
					{
						qEEgwHNeQ3M4bmt6rqQ();
						if (!hmtOvtN4xAd8yrgIoXV())
						{
							goto IL_02da;
						}
					}
					goto IL_02f7;
					IL_0300:
					return true;
					IL_02f7:
					LwqKcKNri4vVqBcpb1j(item5, link_show);
					goto IL_0300;
					IL_02da:
					if (!MvBZ0SNxQ6IuhBxomQs(item5, "chrome"))
					{
						continue;
					}
					goto IL_02f7;
				}
			}
			else if (internt_explorer == 1 && firefox == 1 && chrome == 0)
			{
				foreach (string item6 in CommonConfig.BrowserInstalledLocation)
				{
					_ = 1;
					if (!hmtOvtN4xAd8yrgIoXV())
					{
						goto IL_0350;
					}
					goto IL_03a7;
					IL_039e:
					LwqKcKNri4vVqBcpb1j(item6, link_show);
					goto IL_03a7;
					IL_03a7:
					result = true;
					int num2 = 6;
					if (hmtOvtN4xAd8yrgIoXV())
					{
					}
					goto IL_036a;
					IL_036a:
					switch (num2)
					{
					case 0:
					case 5:
						break;
					case 4:
						goto IL_038d;
					default:
						goto IL_039e;
					case 1:
					case 3:
						goto IL_03a7;
					case 6:
						return result;
					}
					goto IL_0350;
					IL_038d:
					if (!MvBZ0SNxQ6IuhBxomQs(item6, "firefox"))
					{
						continue;
					}
					goto IL_039e;
					IL_0350:
					if (!MvBZ0SNxQ6IuhBxomQs(item6, "iexplore"))
					{
						num2 = 4;
						if (!qEEgwHNeQ3M4bmt6rqQ())
						{
							return result;
						}
						goto IL_036a;
					}
					goto IL_039e;
				}
			}
			else
			{
				if (internt_explorer != 1 || firefox != 1 || chrome != 1)
				{
					bool flag3 = false;
					foreach (string item7 in CommonConfig.BrowserInstalledLocation)
					{
						while (true)
						{
							IL_04ec:
							bool flag4 = MvBZ0SNxQ6IuhBxomQs(BKmimyNvJleFDkY9GLH(item7), zu2e5nNtlhq8efkfaU2());
							qEEgwHNeQ3M4bmt6rqQ();
							if (hmtOvtN4xAd8yrgIoXV())
							{
								goto IL_050c;
							}
							goto IL_0544;
							IL_0544:
							if (!flag4)
							{
								break;
							}
							goto IL_050c;
							IL_050c:
							while (true)
							{
								Process.Start(item7, link_show);
								if (!hmtOvtN4xAd8yrgIoXV())
								{
									switch (5)
									{
									case 0:
										break;
									default:
										continue;
									case 1:
									case 4:
										goto end_IL_050c;
									case 5:
										flag3 = true;
										goto end_IL_04ec;
									case 6:
										goto end_IL_04ec;
									}
									goto IL_04ec;
								}
								break;
								continue;
								end_IL_050c:
								break;
							}
							goto IL_0544;
							continue;
							end_IL_04ec:
							break;
						}
					}
					if (!flag3)
					{
						bwDVI9NBihhs9baG9GT(link_show);
						flag3 = true;
					}
					return flag3;
				}
				foreach (string item8 in CommonConfig.BrowserInstalledLocation)
				{
					hmtOvtN4xAd8yrgIoXV();
					if (qEEgwHNeQ3M4bmt6rqQ())
					{
						goto IL_042a;
					}
					int num3 = 5;
					if (hmtOvtN4xAd8yrgIoXV())
					{
					}
					goto IL_0452;
					IL_04b3:
					return true;
					IL_04aa:
					LwqKcKNri4vVqBcpb1j(item8, link_show);
					goto IL_04b3;
					IL_0452:
					while (true)
					{
						switch (num3)
						{
						case 0:
						case 6:
							break;
						default:
							num3 = 3;
							if (qEEgwHNeQ3M4bmt6rqQ())
							{
								continue;
							}
							return result;
						case 2:
							if (!MvBZ0SNxQ6IuhBxomQs(item8, "firefox"))
							{
								goto case 1;
							}
							goto IL_04aa;
						case 1:
							if (!MvBZ0SNxQ6IuhBxomQs(item8, "chrome"))
							{
								goto IL_0498;
							}
							goto IL_04aa;
						case 3:
							goto IL_04aa;
						case 4:
						case 5:
							goto IL_04b3;
						case 7:
							return result;
						}
						break;
					}
					goto IL_042a;
					IL_042a:
					if (!MvBZ0SNxQ6IuhBxomQs(item8, "iexplore"))
					{
						num3 = 2;
						if (qEEgwHNeQ3M4bmt6rqQ())
						{
							goto IL_0452;
						}
					}
					goto IL_04aa;
					IL_0498:;
				}
			}
			return false;
		}
		catch (Exception)
		{
			throw;
		}
	}

	public static string defaultBrowser()
	{
		try
		{
			string result = null;
			RegistryKey registryKey = (RegistryKey)vOmHooNyuE2ZOjhAxt1(Registry.CurrentUser, "Software\\Microsoft\\Windows\\Shell\\Associations\\UrlAssociations\\http\\UserChoice");
			try
			{
				object obj = DEThPTNWu5Ourrm0Xxd(registryKey, "Progid");
				string text2 = default(string);
				string text = default(string);
				while (true)
				{
					IL_00c6:
					bool flag = obj != null;
					while (flag)
					{
						int num = 4;
						if (!qEEgwHNeQ3M4bmt6rqQ())
						{
							goto IL_00e0;
						}
						while (true)
						{
							switch (num)
							{
							case 5:
								if (text2 == "FirefoxURL")
								{
									result = "firefox";
									goto end_IL_00bd;
								}
								goto default;
							default:
								_ = 0;
								if (!qEEgwHNeQ3M4bmt6rqQ())
								{
									num = 9;
									if (qEEgwHNeQ3M4bmt6rqQ())
									{
										continue;
									}
									goto case 8;
								}
								goto case 3;
							case 8:
								if (!HfoTkNN5Q67sBbUP72O(text2, "IE.HTTP"))
								{
									goto case 5;
								}
								result = "explore";
								goto end_IL_00bd;
							case 4:
								text = obj.ToString();
								goto case 1;
							case 1:
								text2 = text;
								goto case 8;
							case 7:
								break;
							case 11:
								goto IL_00c6;
							case 3:
							case 6:
								if (HfoTkNN5Q67sBbUP72O(text2, "ChromeHTML"))
								{
									result = "chrome";
									goto end_IL_00bd;
								}
								goto IL_00e0;
							case 0:
								goto IL_00e0;
							case 2:
							case 9:
							case 10:
							case 12:
							case 13:
								goto end_IL_00bd;
							}
							break;
						}
						continue;
						IL_00e0:
						result = "none";
						break;
						continue;
						end_IL_00bd:
						break;
					}
					break;
				}
			}
			finally
			{
				if (registryKey != null)
				{
					utiaJfNAbnMF0eILqLW(registryKey);
				}
			}
			return result;
		}
		catch (Exception)
		{
			return "explore";
		}
	}

	public static List<string> GetInstalledBrowser()
	{
		RegistryKey registryKey = ((!SystemUtility.Is64BitOperatingSystem()) ? Registry.LocalMachine.OpenSubKey("SOFTWARE\\Clients\\StartMenuInternet") : Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Clients\\StartMenuInternet"));
		List<string> list = new List<string>();
		string[] subKeyNames = registryKey.GetSubKeyNames();
		foreach (string text in subKeyNames)
		{
			RegistryKey registryKey2 = registryKey.OpenSubKey(text + "\\DefaultIcon");
			if (registryKey2 == null)
			{
				continue;
			}
			object value = registryKey2.GetValue(null);
			if (value == null)
			{
				continue;
			}
			string text2 = value as string;
			if (text2.Contains(".exe"))
			{
				int num = text2.LastIndexOf(".exe");
				if (num >= 0)
				{
					text2 = text2.Substring(0, num + 4);
				}
				list.Add(text2);
			}
		}
		return list;
	}

	internal static bool MvBZ0SNxQ6IuhBxomQs(object object_0, object object_1)
	{
		return ((string)object_0).Contains((string)object_1);
	}

	internal static object LwqKcKNri4vVqBcpb1j(object object_0, object object_1)
	{
		return Process.Start((string)object_0, (string)object_1);
	}

	internal static object BKmimyNvJleFDkY9GLH(object object_0)
	{
		return ((string)object_0).ToLower();
	}

	internal static object zu2e5nNtlhq8efkfaU2()
	{
		return CommonConfig.DefaultBrows;
	}

	internal static object bwDVI9NBihhs9baG9GT(object object_0)
	{
		return Process.Start((string)object_0);
	}

	internal static bool qEEgwHNeQ3M4bmt6rqQ()
	{
		return true;
	}

	internal static bool hmtOvtN4xAd8yrgIoXV()
	{
		return false;
	}

	internal static object vOmHooNyuE2ZOjhAxt1(object object_0, object object_1)
	{
		return ((RegistryKey)object_0).OpenSubKey((string)object_1);
	}

	internal static object DEThPTNWu5Ourrm0Xxd(object object_0, object object_1)
	{
		return ((RegistryKey)object_0).GetValue((string?)object_1);
	}

	internal static bool HfoTkNN5Q67sBbUP72O(object object_0, object object_1)
	{
		return (string?)object_0 == (string?)object_1;
	}

	internal static void utiaJfNAbnMF0eILqLW(object object_0)
	{
		((IDisposable)object_0).Dispose();
	}
}
