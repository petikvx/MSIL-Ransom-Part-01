using System;
using System.Diagnostics;
using SmartAssembly.SmartExceptionsCore;

namespace ns0;

internal sealed class Exception1 : ApplicationException
{
	private static bool bool_0;

	public Exception1()
		: base(GClass2.smethod_0(1618745691, 2))
	{
		try
		{
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException1(exception, this);
			throw;
		}
	}

	static Exception1()
	{
		try
		{
			smethod_3();
		}
		catch (Exception exception)
		{
			int num = default(int);
			StackFrameHelper.CreateException1(exception, num);
			throw;
		}
	}

	internal static int smethod_0(string string_0, string string_1, bool bool_1, int int_0, int int_1)
	{
		int num = default(int);
		int num3 = default(int);
		try
		{
			num = 0;
			while (true)
			{
				int num2;
				switch (int_1 ^ int_0)
				{
				case 106:
					num = 3;
					num2 = 5;
					break;
				default:
					num = 2;
					num2 = 4;
					break;
				}
				num3 = num2;
				num = 6;
				switch (num3)
				{
				default:
					num = 9;
					goto IL_0056;
				case 0:
					num = 1;
					num3 = 7;
					num = 6;
					break;
				case 1:
					num = 9;
					goto IL_0056;
				case 2:
					num = 9;
					goto IL_0056;
				case 3:
					num = 4;
					goto IL_004d;
				case 4:
					num = 4;
					goto IL_004d;
				case 6:
					num = 9;
					goto IL_0056;
				case 7:
					break;
				case 5:
					{
						num = 10;
						return Class7.smethod_0(string_0, string_1, bool_1, 654, 646);
					}
					IL_004d:
					num3 = 7;
					num = 6;
					break;
					IL_0056:
					num3 = 7;
					num = 6;
					break;
				}
				num = 0;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException7(exception, num3, num, string_0, string_1, bool_1, int_0, int_1);
			throw;
		}
	}

	internal static string smethod_1(string string_0, string string_1, string string_2, int int_0, int int_1)
	{
		int num = default(int);
		int num3 = default(int);
		try
		{
			num = 0;
			while (true)
			{
				int num2;
				switch (int_1 ^ int_0)
				{
				case 62:
					num = 9;
					num2 = 2;
					break;
				default:
					num = 8;
					num2 = 6;
					break;
				}
				num3 = num2;
				num = 5;
				switch (num3)
				{
				default:
					num = 11;
					goto IL_0042;
				case 0:
					num = 11;
					goto IL_0042;
				case 3:
					num = 1;
					goto IL_004f;
				case 4:
					num = 11;
					goto IL_0042;
				case 5:
					num = 10;
					goto IL_0058;
				case 6:
					num = 1;
					goto IL_004f;
				case 7:
					num = 10;
					goto IL_0058;
				case 1:
					break;
				case 2:
					{
						num = 2;
						return Class7.smethod_1(string_0, string_1, string_2, 851, 860);
					}
					IL_0058:
					num3 = 1;
					num = 5;
					break;
					IL_004f:
					num3 = 1;
					num = 5;
					break;
					IL_0042:
					num3 = 1;
					num = 5;
					break;
				}
				num = 0;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException7(exception, num3, num, string_0, string_1, string_2, int_0, int_1);
			throw;
		}
	}

	internal static string smethod_2(Process process_0, int int_0, int int_1)
	{
		int num = default(int);
		int num3 = default(int);
		try
		{
			num = 6;
			while (true)
			{
				int num2;
				switch (int_1 ^ int_0)
				{
				case 99:
					num = 11;
					num2 = 7;
					break;
				case 98:
					num = 12;
					num2 = 8;
					break;
				default:
					num = 5;
					num2 = 6;
					break;
				}
				num3 = num2;
				num = 9;
				switch (num3)
				{
				default:
					num = 2;
					goto IL_0052;
				case 0:
					num = 4;
					num3 = 2;
					num = 9;
					break;
				case 1:
					num = 2;
					goto IL_0052;
				case 3:
					num = 10;
					goto IL_005c;
				case 4:
					num = 2;
					goto IL_0052;
				case 5:
					num = 2;
					goto IL_0052;
				case 6:
					num = 10;
					goto IL_005c;
				case 2:
					break;
				case 7:
					num = 7;
					return Class10.Class11.smethod_0(process_0, 577, 524);
				case 8:
					{
						num = 8;
						return Class10.Class11.smethod_0(process_0, 256, 332);
					}
					IL_005c:
					num3 = 2;
					num = 9;
					break;
					IL_0052:
					num3 = 2;
					num = 9;
					break;
				}
				num = 6;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num3, num, process_0, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_3()
	{
		int num = default(int);
		int num2 = default(int);
		Type type = default(Type);
		int num3 = default(int);
		int num4 = default(int);
		int num6 = default(int);
		int num7 = default(int);
		int num8 = default(int);
		try
		{
			num = 2;
			num2 = 1;
			num = 5;
			if (bool_0)
			{
				return;
			}
			num = 3;
			num2 = 3;
			num = 5;
			Class7.Class8.smethod_0(type = Class10.smethod_0(typeof(Exception1).TypeHandle, 560, 519), 695, 719);
			try
			{
				num3 = 1;
				num4 = 5;
				num3 = 4;
				while (true)
				{
					IL_0087:
					num3 = 12;
					while (true)
					{
						int num5;
						if (bool_0)
						{
							num3 = 2;
							num5 = 2;
						}
						else
						{
							num3 = 3;
							num5 = 0;
						}
						num4 = num5;
						num3 = 4;
						switch (num4)
						{
						default:
							num3 = 12;
							continue;
						case 1:
							num3 = 12;
							continue;
						case 4:
							num3 = 12;
							continue;
						case 5:
							break;
						case 0:
							num3 = 5;
							bool_0 = true;
							num3 = 0;
							goto IL_009a;
						case 3:
							num3 = 0;
							goto IL_009a;
						case 2:
							{
								num3 = 10;
								goto end_IL_007e;
							}
							IL_009a:
							Class10.Class11.smethod_2(Class10.Class11.smethod_1(784, 860), Class0.smethod_1, 663, 647);
							num3 = 11;
							num4 = 2;
							num3 = 4;
							goto case 2;
						}
						goto IL_0087;
						continue;
						end_IL_007e:
						break;
					}
					break;
				}
			}
			finally
			{
				num6 = 2;
				Class10.Class11.smethod_3(type, 219, 249);
			}
			num7 = 3;
			num8 = 3;
			num7 = 1;
			num8 = 5;
			num7 = 1;
		}
		catch (Exception exception)
		{
			int num9 = default(int);
			StackFrameHelper.CreateException9(exception, type, num2, num4, num8, num, num3, num6, num7, num9);
			throw;
		}
	}

	internal static AppDomain smethod_4(int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 92:
					return Class10.Class11.smethod_1(265, 325);
				}
				num = 0;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, num, int_0, int_1);
			throw;
		}
	}

	internal static object smethod_5(AppDomain appDomain_0, string string_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 38:
					return Class10.Class11.smethod_4(appDomain_0, string_0, 309, 298);
				}
				num = 4;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, appDomain_0, string_0, int_0, int_1);
			throw;
		}
	}
}
