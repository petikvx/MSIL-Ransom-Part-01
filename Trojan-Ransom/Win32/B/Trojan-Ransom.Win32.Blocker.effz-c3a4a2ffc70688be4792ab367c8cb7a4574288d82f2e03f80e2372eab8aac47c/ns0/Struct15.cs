using System;
using SmartAssembly.SmartExceptionsCore;

namespace ns0;

internal struct Struct15
{
	internal uint uint_0;

	public void method_0()
	{
		uint num = default(uint);
		try
		{
			num = 1024u;
			uint_0 = 1024u;
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException3(exception, num, num2, this);
			throw;
		}
	}

	public uint method_1(Class5 class5_0)
	{
		int num = default(int);
		uint num2 = default(uint);
		int num3 = default(int);
		uint num6 = default(uint);
		uint num5 = default(uint);
		try
		{
			num = 13;
			while (true)
			{
				num2 = (class5_0.uint_0 >> 11) * uint_0;
				num3 = 8;
				num = 30;
				while (true)
				{
					num = 25;
					int num4;
					if (class5_0.uint_1 >= num2)
					{
						num = 4;
						num4 = 13;
					}
					else
					{
						num = 20;
						num4 = 10;
					}
					num3 = num4;
					num = 30;
					while (true)
					{
						switch (num3)
						{
						case 15:
							num = 9;
							goto IL_0018;
						case 0:
						{
							num = 26;
							int num8;
							if (class5_0.uint_0 < 16777216)
							{
								num = 19;
								num8 = 16;
							}
							else
							{
								num = 10;
								num8 = 12;
							}
							num3 = num8;
							num = 30;
							continue;
						}
						case 14:
						{
							num = 16;
							int num7;
							if (class5_0.uint_0 < 16777216)
							{
								num = 5;
								num7 = 4;
							}
							else
							{
								num = 0;
								num7 = 9;
							}
							num3 = num7;
							num = 30;
							continue;
						}
						case 13:
							num = 6;
							class5_0.uint_0 -= num2;
							num = 8;
							goto IL_0076;
						case 2:
							num = 11;
							num6 = (uint_0 -= uint_0 >> 5);
							num = 9;
							goto IL_0018;
						case 10:
							num = 27;
							goto IL_00b0;
						case 7:
							num = 8;
							goto IL_0076;
						case 1:
							num = 27;
							goto IL_00b0;
						case 8:
							break;
						default:
							num = 28;
							goto IL_015a;
						case 3:
							num = 28;
							goto IL_015a;
						case 11:
							goto end_IL_0141;
						case 4:
							num = 21;
							class5_0.uint_1 = (class5_0.uint_1 << 8) | (byte)Class0.smethod_3(class5_0.stream_0, 330, 290);
							num = 1;
							num3 = 5;
							num = 30;
							goto case 5;
						case 5:
							num = 7;
							class5_0.uint_0 <<= 8;
							num3 = 9;
							num = 30;
							goto case 9;
						case 9:
							num = 2;
							return 0u;
						case 16:
							num = 14;
							class5_0.uint_1 = (class5_0.uint_1 << 8) | (byte)Class0.smethod_3(class5_0.stream_0, 1013, 925);
							num = 15;
							num3 = 6;
							num = 30;
							goto case 6;
						case 6:
							num = 3;
							class5_0.uint_0 <<= 8;
							num3 = 12;
							num = 30;
							goto case 12;
						case 12:
							{
								num = 23;
								return 1u;
							}
							IL_015a:
							num3 = 11;
							num = 30;
							goto end_IL_0141;
							IL_00b0:
							class5_0.uint_0 = num2;
							num5 = (uint_0 += 2048 - uint_0 >> 5);
							num = 22;
							num3 = 14;
							num = 30;
							goto case 14;
							IL_0076:
							class5_0.uint_1 -= num2;
							num3 = 2;
							num = 30;
							goto case 2;
							IL_0018:
							num3 = 0;
							num = 30;
							goto case 0;
						}
						break;
					}
					continue;
					end_IL_0141:
					break;
				}
				num = 13;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException7(exception, num2, num5, num6, num3, num, this, class5_0);
			throw;
		}
	}

	static Struct15()
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
}
