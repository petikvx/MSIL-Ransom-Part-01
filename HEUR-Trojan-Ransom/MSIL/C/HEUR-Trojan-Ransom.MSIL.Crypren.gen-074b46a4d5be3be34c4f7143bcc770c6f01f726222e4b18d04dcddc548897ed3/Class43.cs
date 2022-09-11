using System;

internal class Class43
{
	internal static bool bool_0;

	static Class43()
	{
		bool_0 = (byte)Class84.smethod_0(0) != 0;
		Delegate502.smethod_0();
	}

	internal static string smethod_0(string string_0, string string_1)
	{
		string string_2 = string_1;
		string[] commandLineArgs = default(string[]);
		int i = default(int);
		while (true)
		{
			int num = Class46.Class47.smethod_0(82);
			while (true)
			{
				switch (num ^ Class84.smethod_0(60))
				{
				case -99:
					num = -23;
					continue;
				case -100:
					commandLineArgs = Environment.GetCommandLineArgs();
					num = -17;
					continue;
				case -101:
					i = Class84.smethod_0(1);
					num = Class49.smethod_0(74);
					continue;
				case -98:
					for (; i < commandLineArgs.Length; i += Class84.smethod_0(1))
					{
						Delegate503.smethod_0(commandLineArgs[i], string_0, ref string_2);
					}
					return string_2;
				}
				break;
			}
		}
	}

	internal static string smethod_1(int int_0, string string_0)
	{
		string string_ = string_0;
		int num3 = default(int);
		int num2 = default(int);
		string[] commandLineArgs = default(string[]);
		while (true)
		{
			int num = Class84.smethod_0(79);
			while (true)
			{
				switch (num ^ Class84.smethod_0(404))
				{
				case 112:
					num3 = Class84.smethod_0(0);
					num = 8;
					continue;
				case 111:
					num2 = Class84.smethod_0(1);
					num = 22;
					continue;
				case 110:
					commandLineArgs = Environment.GetCommandLineArgs();
					num = 23;
					continue;
				case 109:
					num = 10;
					continue;
				case 113:
					while (true)
					{
						if (num2 < commandLineArgs.Length)
						{
							if (Delegate504.smethod_0(commandLineArgs[num2], ref string_) || 1 == 0)
							{
								if (int_0 == num3)
								{
									break;
								}
								string_ = string_0;
								num3 += Class84.smethod_0(1);
							}
							num2 += Class84.smethod_0(1);
							continue;
						}
						return string_;
					}
					return string_;
				}
				break;
			}
		}
	}

	internal static bool smethod_2(string string_0, bool bool_1)
	{
		bool result = bool_1;
		string[] commandLineArgs = default(string[]);
		int i = default(int);
		while (true)
		{
			int num = Class49.smethod_0(84);
			while (true)
			{
				switch (num ^ Class84.smethod_0(408))
				{
				case -107:
					commandLineArgs = Environment.GetCommandLineArgs();
					num = -29;
					continue;
				case -108:
					num = -28;
					continue;
				case -109:
					i = Class84.smethod_0(1);
					num = -26;
					continue;
				case -106:
					for (; i < commandLineArgs.Length; i += Class84.smethod_0(1))
					{
						Delegate505.smethod_0(commandLineArgs[i], string_0, ref result);
					}
					return result;
				}
				break;
			}
		}
	}

	internal static int smethod_3(string string_0, int int_0)
	{
		int int_ = int_0;
		int i = default(int);
		string[] commandLineArgs = default(string[]);
		while (true)
		{
			int num = Class89.smethod_1(63);
			while (true)
			{
				switch (num ^ Class84.smethod_0(409))
				{
				case -102:
					i = Class84.smethod_0(1);
					num = -15;
					continue;
				case -103:
					commandLineArgs = Environment.GetCommandLineArgs();
					num = -16;
					continue;
				case -104:
					num = Class89.smethod_1(52);
					continue;
				case -101:
					for (; i < commandLineArgs.Length; i += Class84.smethod_0(1))
					{
						Delegate506.smethod_0(commandLineArgs[i], string_0, ref int_);
					}
					return int_;
				}
				break;
			}
		}
	}

	private static void smethod_4(string string_0, string string_1, ref bool bool_1)
	{
		if (string_0.Length >= string_1.Length + Class84.smethod_0(1) && (Class84.smethod_0(127) == string_0[Class84.smethod_0(0)] || Class84.smethod_0(122) == string_0[Class84.smethod_0(0)]) && (string_0.Substring(Class84.smethod_0(1), string_1.Length).ToLower() == string_1.ToLower() || 1 == 0))
		{
			bool_1 = (byte)Class84.smethod_0(1) != 0;
		}
	}

	private static void smethod_5(string string_0, string string_1, ref int int_0)
	{
		if (string_0.Length < string_1.Length + Class84.smethod_0(7) || (Class84.smethod_0(127) != string_0[Class84.smethod_0(0)] && Class84.smethod_0(122) != string_0[Class84.smethod_0(0)]) || ((!(string_0.Substring(Class84.smethod_0(1), string_1.Length).ToLower() == string_1.ToLower())) ? true : false))
		{
			return;
		}
		try
		{
			int_0 = Convert.ToInt32(string_0.Substring(string_1.Length + Class84.smethod_0(6), string_0.Length - string_1.Length - Class84.smethod_0(6)));
		}
		catch
		{
		}
	}

	private static bool smethod_6(string string_0, ref string string_1)
	{
		if (Class84.smethod_0(127) != string_0[Class84.smethod_0(0)] && Class84.smethod_0(122) != string_0[Class84.smethod_0(0)])
		{
			string_1 = string_0;
			return (byte)Class84.smethod_0(1) != 0;
		}
		return (byte)Class84.smethod_0(0) != 0;
	}

	private static void smethod_7(string string_0, string string_1, ref string string_2)
	{
		if (string_0.Length >= string_1.Length + Class84.smethod_0(7) && (Class84.smethod_0(127) == string_0[Class84.smethod_0(0)] || Class84.smethod_0(122) == string_0[Class84.smethod_0(0)]) && (string_0.Substring(Class84.smethod_0(1), string_1.Length).ToLower() == string_1.ToLower() || 1 == 0))
		{
			string_2 = string_0.Substring(string_1.Length + Class84.smethod_0(6), string_0.Length - string_1.Length - Class84.smethod_0(6));
		}
	}

	private static void smethod_8()
	{
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		for (int i = Class84.smethod_0(1); i < commandLineArgs.Length; i += Class84.smethod_0(1))
		{
			Delegate505.smethod_0(commandLineArgs[i], Class86.smethod_0("\ue410", 58382), ref bool_0);
			while (true)
			{
				int num = Class84.smethod_0(80);
				int num2 = 5;
				while (true)
				{
					switch (num2 ^ Class84.smethod_0(59))
					{
					case 116:
						num ^= Class84.smethod_0(404);
						goto default;
					default:
						num2 = Class84.smethod_0(7);
						continue;
					case 115:
						num2 = 2;
						continue;
					case 114:
						switch (num)
						{
						default:
							num2 = 0;
							continue;
						case 109:
							Delegate505.smethod_0(commandLineArgs[i], Class86.smethod_0("\uec94", 60652), ref bool_0);
							num = 8;
							break;
						case 110:
							num = Class84.smethod_0(79);
							break;
						case 111:
							Delegate505.smethod_0(commandLineArgs[i], Class86.smethod_0("\uf3df\uf3d2\uf3db\uf3c7", 62247), ref bool_0);
							num = 23;
							break;
						case 112:
							goto end_IL_00e0;
						}
						goto case 116;
					case 113:
						break;
					}
					break;
				}
				continue;
				end_IL_00e0:
				break;
			}
		}
	}
}
