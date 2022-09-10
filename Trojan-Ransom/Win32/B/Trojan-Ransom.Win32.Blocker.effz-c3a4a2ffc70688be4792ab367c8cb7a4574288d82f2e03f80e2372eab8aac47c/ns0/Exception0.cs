using System;
using System.IO;
using SmartAssembly.SmartExceptionsCore;

namespace ns0;

internal sealed class Exception0 : ApplicationException
{
	public Exception0()
		: base(GClass2.smethod_0(1618745677, 0))
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

	static Exception0()
	{
		try
		{
			Exception1.smethod_3();
		}
		catch (Exception exception)
		{
			int num = default(int);
			StackFrameHelper.CreateException1(exception, num);
			throw;
		}
	}

	internal static int smethod_0(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		int num = default(int);
		int num3 = default(int);
		try
		{
			num = 11;
			while (true)
			{
				int num2;
				switch (int_3 ^ int_2)
				{
				case 70:
					num = 12;
					num2 = 3;
					break;
				default:
					num = 7;
					num2 = 7;
					break;
				}
				num3 = num2;
				num = 9;
				switch (num3)
				{
				default:
					num = 6;
					goto IL_004e;
				case 0:
					num = 2;
					goto IL_0057;
				case 1:
					num = 5;
					num3 = 6;
					num = 9;
					break;
				case 2:
					num = 2;
					goto IL_0057;
				case 4:
					num = 2;
					goto IL_0057;
				case 5:
					num = 6;
					goto IL_004e;
				case 7:
					num = 2;
					goto IL_0057;
				case 6:
					break;
				case 3:
					{
						num = 3;
						return Class7.Class8.smethod_1(stream_0, byte_0, int_0, int_1, 845, 861);
					}
					IL_0057:
					num3 = 6;
					num = 9;
					break;
					IL_004e:
					num3 = 6;
					num = 9;
					break;
				}
				num = 11;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException8(exception, num3, num, stream_0, byte_0, int_0, int_1, int_2, int_3);
			throw;
		}
	}

	internal static byte[] smethod_1(MemoryStream memoryStream_0, int int_0, int int_1)
	{
		int num = default(int);
		int num3 = default(int);
		try
		{
			num = 5;
			while (true)
			{
				int num2;
				switch (int_1 ^ int_0)
				{
				case 21:
					num = 0;
					num2 = 2;
					break;
				default:
					num = 6;
					num2 = 3;
					break;
				}
				num3 = num2;
				num = 12;
				switch (num3)
				{
				default:
					num = 9;
					goto IL_005a;
				case 0:
					num = 3;
					num3 = 6;
					num = 12;
					goto case 6;
				case 1:
					num = 9;
					goto IL_005a;
				case 3:
					num = 11;
					goto IL_004c;
				case 4:
					num = 11;
					goto IL_004c;
				case 5:
					num = 5;
					break;
				case 7:
					num = 9;
					goto IL_005a;
				case 6:
					num = 5;
					break;
				case 2:
					{
						num = 2;
						return Class10.smethod_1(memoryStream_0, 206, 226);
					}
					IL_004c:
					num3 = 6;
					num = 12;
					goto case 6;
					IL_005a:
					num3 = 6;
					num = 12;
					goto case 6;
				}
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num3, num, memoryStream_0, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_2(Stream stream_0, int int_0, int int_1)
	{
		int num = default(int);
		int num2 = default(int);
		try
		{
			num = 9;
			num2 = 0;
			num = 8;
			while (true)
			{
				num = 7;
				while (true)
				{
					int num3;
					switch (int_1 ^ int_0)
					{
					case 92:
						num = 3;
						num3 = 2;
						break;
					default:
						num = 0;
						num3 = 5;
						break;
					}
					num2 = num3;
					num = 8;
					switch (num2)
					{
					default:
						goto IL_002d;
					case 5:
						num = 2;
						num2 = 0;
						num = 8;
						break;
					case 0:
						break;
					case 1:
						num = 6;
						return;
					case 2:
						num = 5;
						goto IL_005b;
					case 3:
						num = 5;
						goto IL_005b;
					case 4:
						{
							num = 6;
							return;
						}
						IL_005b:
						Class7.Class8.Class9.smethod_0(stream_0, 922, 952);
						return;
					}
					break;
					IL_002d:
					num = 7;
				}
			}
		}
		catch (Exception exception)
		{
			int num4 = default(int);
			int num5 = default(int);
			StackFrameHelper.CreateException7(exception, num2, num4, num, num5, stream_0, int_0, int_1);
			throw;
		}
	}

	internal static DateTime smethod_3(int int_0, int int_1)
	{
		int num = default(int);
		int num3 = default(int);
		try
		{
			num = 8;
			while (true)
			{
				int num2;
				switch (int_1 ^ int_0)
				{
				case 8:
					num = 4;
					num2 = 4;
					break;
				default:
					num = 7;
					num2 = 2;
					break;
				}
				num3 = num2;
				num = 5;
				switch (num3)
				{
				default:
					num = 12;
					goto IL_0038;
				case 0:
					num = 12;
					goto IL_0038;
				case 1:
					num = 0;
					num3 = 7;
					num = 5;
					goto case 7;
				case 2:
					num = 2;
					goto IL_0050;
				case 3:
					num = 8;
					continue;
				case 6:
					num = 2;
					goto IL_0050;
				case 7:
					num = 8;
					continue;
				case 4:
					num = 10;
					break;
				case 5:
					{
						num = 10;
						break;
					}
					IL_0050:
					num3 = 7;
					num = 5;
					goto case 7;
					IL_0038:
					num3 = 7;
					num = 5;
					goto case 7;
				}
				break;
			}
			return Class10.Class11.smethod_5(449, 448);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num3, num, int_0, int_1);
			throw;
		}
	}

	internal static bool smethod_4(DateTime dateTime_0, DateTime dateTime_1, int int_0, int int_1)
	{
		int num = default(int);
		int num3 = default(int);
		try
		{
			num = 7;
			while (true)
			{
				int num2;
				switch (int_1 ^ int_0)
				{
				case 58:
					num = 3;
					num2 = 4;
					break;
				default:
					num = 0;
					num2 = 5;
					break;
				}
				num3 = num2;
				num = 1;
				switch (num3)
				{
				default:
					num = 11;
					goto IL_003c;
				case 1:
					num = 5;
					goto IL_0044;
				case 2:
					num = 11;
					goto IL_003c;
				case 5:
					num = 5;
					goto IL_0044;
				case 7:
					num = 12;
					num3 = 6;
					num = 1;
					goto IL_0051;
				case 6:
					goto IL_0051;
				case 0:
					num = 4;
					break;
				case 3:
					num = 4;
					break;
				case 4:
					{
						num = 4;
						break;
					}
					IL_0044:
					num3 = 6;
					num = 1;
					goto IL_0051;
					IL_003c:
					num3 = 6;
					num = 1;
					goto IL_0051;
				}
				break;
				IL_0051:
				num = 7;
			}
			return Class10.smethod_2(dateTime_0, dateTime_1, 186, 239);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException6(exception, num3, num, dateTime_0, dateTime_1, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_5(AppDomain appDomain_0, ResolveEventHandler resolveEventHandler_0, int int_0, int int_1)
	{
		int num = default(int);
		int num2 = default(int);
		try
		{
			num = 2;
			num2 = 1;
			num = 6;
			while (true)
			{
				num = 5;
				while (true)
				{
					int num3;
					switch (int_1 ^ int_0)
					{
					case 76:
						num = 7;
						num3 = 0;
						break;
					default:
						num = 9;
						num3 = 5;
						break;
					}
					num2 = num3;
					num = 6;
					switch (num2)
					{
					default:
						num = 5;
						continue;
					case 2:
						num = 5;
						continue;
					case 3:
						num = 5;
						continue;
					case 5:
						num = 0;
						num2 = 1;
						num = 6;
						break;
					case 1:
						break;
					case 0:
						num = 1;
						goto IL_005f;
					case 4:
						{
							num = 1;
							goto IL_005f;
						}
						IL_005f:
						Class7.smethod_2(appDomain_0, resolveEventHandler_0, 575, 627);
						return;
					}
					break;
				}
			}
		}
		catch (Exception exception)
		{
			int num4 = default(int);
			int num5 = default(int);
			StackFrameHelper.CreateException8(exception, num2, num4, num, num5, appDomain_0, resolveEventHandler_0, int_0, int_1);
			throw;
		}
	}

	internal static uint smethod_6(uint uint_0, uint uint_1, int int_0, int int_1)
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
				case 70:
					num = 2;
					num2 = 4;
					break;
				case 69:
					num = 3;
					num2 = 2;
					break;
				default:
					num = 12;
					num2 = 5;
					break;
				}
				num3 = num2;
				num = 7;
				switch (num3)
				{
				default:
					num = 1;
					goto IL_003a;
				case 1:
					num = 1;
					goto IL_003a;
				case 3:
					num = 13;
					goto IL_0056;
				case 5:
					num = 9;
					goto IL_004d;
				case 7:
					num = 9;
					goto IL_004d;
				case 8:
					num = 13;
					goto IL_0056;
				case 6:
					break;
				case 0:
					num = 8;
					goto IL_0084;
				case 2:
					num = 8;
					goto IL_0084;
				case 4:
					{
						num = 11;
						return Class7.smethod_3(uint_0, uint_1, 724, 698);
					}
					IL_0084:
					return Class7.smethod_3(uint_0, uint_1, 384, 493);
					IL_004d:
					num3 = 6;
					num = 7;
					break;
					IL_0056:
					num3 = 6;
					num = 7;
					break;
					IL_003a:
					num3 = 6;
					num = 7;
					break;
				}
				num = 0;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException6(exception, num3, num, uint_0, uint_1, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_7(AppDomain appDomain_0, string string_0, object object_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 4;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 74:
					Class10.smethod_3(appDomain_0, string_0, object_0, 391, 491);
					return;
				case 75:
					appDomain_0.SetData(string_0, object_0);
					return;
				}
				num = 4;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException7(exception, num, num2, appDomain_0, string_0, object_0, int_0, int_1);
			throw;
		}
	}
}
