using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Resources;

public sealed class GClass0
{
	private static c2 c2_0;

	private static ResourceManager resourceManager_0 = fw.a();

	internal static string string_0;

	internal static bool bool_0;

	internal static bool bool_1;

	internal static string string_1;

	internal static bool bool_2;

	internal static bool bool_3;

	internal static bool bool_4;

	internal static bool smethod_0(string[] string_2)
	{
		if (string_2.Length == 0)
		{
			return true;
		}
		int num = 0;
		while (true)
		{
			if (num < string_2.Length)
			{
				string text = string_2[num];
				if (text.StartsWith("-g") || text.StartsWith("/g"))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	internal static c2 smethod_1(string[] string_2, ee ee_0, Hashtable hashtable_0)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		Hashtable hashtable = new Hashtable();
		bool flag = false;
		c2_0 = (c2)ee_0.a();
		if (string_2.Length == 0)
		{
			bool_0 = true;
			smethod_20(hashtable_0, ee_0.a());
			return null;
		}
		string[] array = string_2;
		int num = 0;
		while (true)
		{
			string text;
			if (num < array.Length)
			{
				text = array[num];
				if (!text.StartsWith("-") && !text.StartsWith("/"))
				{
					if (flag)
					{
						throw new ApplicationException(fw.a(resourceManager_0.GetString("MSG_CLI_MULTIPLE_CONFIGFILES"), new object[2] { string_0, text }));
					}
					string_0 = text;
					flag = true;
				}
				else
				{
					if (text.Length == 2 && text[1] == '?')
					{
						break;
					}
					if (text.Length == 2 && text[1] == 'g')
					{
						bool_0 = true;
					}
					else if (text.Length >= 2)
					{
						string string_3 = null;
						string string_4 = null;
						smethod_2(text, ref string_3, ref string_4);
						if (string_3.Equals("p"))
						{
							hashtable_0 = smethod_7(string_4, hashtable_0);
						}
						else if (string_3.Equals("make"))
						{
							smethod_13(string_4);
						}
					}
				}
				num++;
				continue;
			}
			smethod_20(hashtable_0, ee_0.a());
			c2_0.a(hashtable_0);
			if (flag)
			{
				c2_0.m(Path.GetFullPath(string_0));
				smethod_19(ee_0.a(""));
			}
			else
			{
				smethod_17(c2_0);
			}
			array = string_2;
			num = 0;
			while (true)
			{
				if (num < array.Length)
				{
					text = array[num];
					if (text.StartsWith("-") || text.StartsWith("/"))
					{
						if (text.Length == 2)
						{
							if (hashtable[text] != null)
							{
								throw new ApplicationException(fw.a(resourceManager_0.GetString("MSG_CLI_DUPLICATE_ARG"), new object[1] { text }));
							}
							switch (text[1])
							{
							case 'e':
								c2_0.h(true);
								bool_3 = true;
								break;
							case 'i':
								c2_0.f(true);
								break;
							case 'v':
								c2_0.d(true);
								c2_0.g(false);
								bool_2 = true;
								break;
							case 'q':
								c2_0.g(true);
								c2_0.d(false);
								bool_2 = false;
								break;
							case '?':
							case 'g':
							case 'n':
								break;
							default:
								throw new ApplicationException(fw.a(resourceManager_0.GetString("MSG_CLI_BAD_ARGUMENT"), new object[1] { text }));
							}
							hashtable[text] = text;
						}
						if (text.Length > 2)
						{
							string string_3 = null;
							string string_4 = null;
							smethod_2(text, ref string_3, ref string_4);
							if (hashtable[string_3] != null && !string_3.ToLower(CultureInfo.InvariantCulture).EndsWith("link"))
							{
								throw new ApplicationException(fw.a(resourceManager_0.GetString("MSG_CLI_DUPLICATE_ARG"), new object[1] { text }));
							}
							if (!string_3.Equals("p") && !string_3.Equals("c"))
							{
								if (string_3.Equals("appl"))
								{
									smethod_6(string_3);
								}
								else if (string_3.Equals("clob"))
								{
									smethod_9(string_4);
								}
								else if (string_3.Equals("rena"))
								{
									smethod_8(string_4);
								}
								else if (string_3.Equals("in"))
								{
									smethod_10(string_4);
								}
								else if (string_3.Equals("out"))
								{
									smethod_11(string_4);
								}
								else if (string_3.Equals("mapo"))
								{
									smethod_12(string_4);
								}
								else if (!string_3.Equals("make"))
								{
									if (string_3.Equals("keep"))
									{
										smethod_14(string_4);
									}
									else if (string_3.Equals("disa"))
									{
										smethod_15(string_4);
									}
									else if (string_3.Equals("cont"))
									{
										smethod_16(text);
									}
									else if (string_3.Equals("encr"))
									{
										smethod_16(text);
									}
									else if (string_3.Equals("prun"))
									{
										smethod_16(text);
									}
									else if (string_3.Equals("enha"))
									{
										smethod_16(text);
									}
									else if (string_3.Equals("mapi"))
									{
										smethod_16(text);
									}
									else if (string_3.Equals("nami"))
									{
										smethod_16(text);
									}
									else if (string_3.Equals("brea"))
									{
										smethod_16(text);
									}
									else if (string_3.Equals("debu"))
									{
										smethod_16(text);
									}
									else if (string_3.Equals("pref"))
									{
										smethod_16(text);
									}
									else if (string_3.Equals("inpl"))
									{
										smethod_16(text);
									}
									else if (string_3.Equals("link"))
									{
										smethod_16(text);
									}
									else if (string_3.Equals("prem"))
									{
										smethod_16(text);
									}
									else if (string_3.Equals("wate"))
									{
										smethod_16(text);
									}
									else if (string_3.Equals("pass"))
									{
										smethod_16(text);
									}
									else
									{
										if (!string_3.Equals("char"))
										{
											break;
										}
										smethod_16(text);
									}
								}
							}
							hashtable[string_3] = string_3;
						}
					}
					num++;
					continue;
				}
				if (flag)
				{
					smethod_18(c2_0, hashtable);
				}
				c2_0.g();
				if (string_1 != null)
				{
					smethod_21();
				}
				return c2_0;
			}
			throw new ApplicationException(fw.a(resourceManager_0.GetString("MSG_CLI_BAD_ARGUMENT"), new object[1] { text }));
		}
		bool_1 = true;
		return null;
	}

	private static void smethod_2(string string_2, ref string string_3, ref string string_4)
	{
		string_2 = string_2.Substring(1);
		int num = string_2.IndexOf("=");
		int num2 = string_2.IndexOf(":");
		int num3 = -1;
		num3 = ((num > -1 && num2 > -1) ? ((num > num2) ? num2 : num) : ((num != -1) ? num : num2));
		if (num3 >= 0)
		{
			string_3 = string_2.Substring(0, num3);
			if (num3 < string_2.Length - 1)
			{
				string_4 = string_2.Substring(num3 + 1);
			}
		}
		else
		{
			string_3 = string_2;
		}
		if (string_3.Length > 4)
		{
			string_3 = string_3.Substring(0, 4);
		}
	}

	private static bool smethod_3(string string_2)
	{
		if (string_2.Equals("off"))
		{
			return true;
		}
		if (string_2.Equals("on"))
		{
			return false;
		}
		throw new ApplicationException(fw.a(resourceManager_0.GetString("MSG_CLI_INVALID_SUBARG"), new object[1] { string_2 }));
	}

	private static string smethod_4(string string_2)
	{
		string directoryName = Path.GetDirectoryName(string_2);
		if (directoryName == null || directoryName.Length == 0)
		{
			string_2 = "." + Path.DirectorySeparatorChar + string_2;
		}
		return string_2;
	}

	private static void smethod_5(string string_2)
	{
		if (string_2 == null)
		{
			throw new ApplicationException(resourceManager_0.GetString("MSG_CLI_ARG_INCOMPLETE"));
		}
	}

	private static void smethod_6(string string_2)
	{
		Console.WriteLine(fw.a(resourceManager_0.GetString("MSG_ARG_DEPRECATED"), new object[1] { string_2 }));
	}

	private static Hashtable smethod_7(string string_2, Hashtable hashtable_0)
	{
		if (string_2 == null)
		{
			throw new ApplicationException(fw.a(resourceManager_0.GetString("MSG_PROPERTY_PARSE_BAD_ARGUMENT"), new object[1] { string_2 }));
		}
		string[] array = string_2.Split(new char[1] { ',' });
		string[] array2 = array;
		foreach (string text in array2)
		{
			int num = text.IndexOf("=");
			if (num > 0)
			{
				string text2 = text.Substring(0, num).Trim();
				string value = text.Substring(num + 1).Trim();
				if (text2.Length != 0)
				{
					if (hashtable_0[text2] == null)
					{
						hashtable_0.Add(text2, value);
					}
					continue;
				}
				throw new ApplicationException(fw.a(resourceManager_0.GetString("MSG_PROPERTY_PARSE_MISSING_NAME"), new object[1] { text }));
			}
			throw new ApplicationException(fw.a(resourceManager_0.GetString("MSG_PROPERTY_PARSE_MISSING_VALUE"), new object[1] { text }));
		}
		return hashtable_0;
	}

	private static void smethod_8(string string_2)
	{
		smethod_5(string_2);
		if (!bool_4)
		{
			c2_0.j(smethod_3(string_2));
		}
	}

	private static void smethod_9(string string_2)
	{
		smethod_5(string_2);
		c2_0.b(!smethod_3(string_2));
	}

	private static void smethod_10(string string_2)
	{
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		smethod_5(string_2);
		string[] array = string_2.Split(new char[1] { ',' });
		ArrayList arrayList = c2_0.e();
		bool flag = false;
		for (int i = 0; i < array.Length; i++)
		{
			string text = array[i].Trim();
			if (text != null && text.Length != 0)
			{
				if (text[0] == '"' && text[text.Length - 1] == '"')
				{
					text = text.Substring(1, text.Length - 2);
				}
				flag |= !text.ToLower().EndsWith(".exe");
				string path = smethod_4(text);
				b6 value = new b6(Path.GetFileName(path), Path.GetDirectoryName(path));
				arrayList.Add(value);
			}
		}
		foreach (b6 item in arrayList)
		{
			b6 val = item;
			val.c(flag);
		}
	}

	private static void smethod_11(string string_2)
	{
		smethod_5(string_2);
		c2_0.l(smethod_4(string_2));
	}

	private static void smethod_12(string string_2)
	{
		smethod_5(string_2);
		c2_0.k(smethod_4(string_2));
	}

	private static void smethod_13(string string_2)
	{
		smethod_5(string_2);
		string_1 = string_2;
	}

	private static void smethod_14(string string_2)
	{
		smethod_5(string_2);
		string text = string_2.ToLower(CultureInfo.InvariantCulture);
		if (text.Equals("namespace"))
		{
			c2_0.a(true);
			c2_0.m(false);
			return;
		}
		if (text.Equals("hierarchy"))
		{
			c2_0.a(false);
			c2_0.m(true);
			return;
		}
		if (text.Equals("none"))
		{
			c2_0.a(false);
			c2_0.m(false);
			return;
		}
		throw new ApplicationException(fw.a(resourceManager_0.GetString("MSG_CLI_INVALID_SUBARG"), new object[1] { string_2 }));
	}

	private static void smethod_15(string string_2)
	{
		bool_4 = true;
		c2_0.j(true);
	}

	public static void smethod_16(string string_2)
	{
		throw new ApplicationException(fw.a(resourceManager_0.GetString("MSG_CLI_PRO_ONLY"), new object[1] { string_2 }));
	}

	private static void smethod_17(c2 c2_1)
	{
		c2_1.h("2.1");
		c2_1.f(false);
		c2_1.d(false);
		c2_1.g(false);
		c2_1.h(false);
		c2_1.c(true);
		c2_1.l(Environment.CurrentDirectory + Path.DirectorySeparatorChar + "Dotfuscated");
		c2_1.k(Environment.CurrentDirectory + Path.DirectorySeparatorChar + "Dotfuscated" + Path.DirectorySeparatorChar + "map.xml");
		c2_1.b(false);
		c2_1.j(false);
		c2_1.m(false);
		c2_1.a(false);
	}

	private static void smethod_18(c2 c2_1, Hashtable hashtable_0)
	{
		if (hashtable_0["out"] == null && c2_1.c() == null)
		{
			c2_1.l(Environment.CurrentDirectory + Path.DirectorySeparatorChar + "Dotfuscated");
		}
		if (hashtable_0["mapo"] == null && c2_1.i() == null)
		{
			c2_1.k(Environment.CurrentDirectory + Path.DirectorySeparatorChar + "Dotfuscated" + Path.DirectorySeparatorChar + "map.xml");
		}
	}

	private static void smethod_19(cv cv_0)
	{
		FileStream fileStream = new FileStream(c2_0.b(), FileMode.Open, FileAccess.Read);
		bool flag = !bool_0;
		cv_0.a((ei)(object)c2_0, (Stream)fileStream, flag);
	}

	private static void smethod_20(Hashtable hashtable_0, c6 c6_0)
	{
		if (hashtable_0["applicationdir"] == null)
		{
			hashtable_0.Add("applicationdir", c6_0.f());
		}
		if (string_1 != null)
		{
			if (hashtable_0["configdir"] == null)
			{
				hashtable_0.Add("configdir", Path.GetDirectoryName(Path.GetFullPath(string_1)));
			}
		}
		else if (string_0 != null && hashtable_0["configdir"] == null)
		{
			hashtable_0.Add("configdir", Path.GetDirectoryName(Path.GetFullPath(string_0)));
		}
		if (hashtable_0["appdatadir"] == null)
		{
			hashtable_0.Add("appdatadir", Path.GetFullPath(dp.a(false)));
		}
	}

	private static void smethod_21()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		FileStream fileStream = null;
		try
		{
			fileStream = new FileStream(string_1, FileMode.Create, FileAccess.Write);
			y val = new y(Console.Out);
			val.a((ei)(object)c2_0, (Stream)fileStream);
			c2_0.m(string_1);
		}
		finally
		{
			fileStream?.Close();
		}
	}
}
