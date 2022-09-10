using System;
using SmartAssembly.SmartExceptionsCore;

namespace ns0;

internal sealed class Class6
{
	public static readonly uint[] uint_0;

	internal uint uint_1;

	static Class6()
	{
		int num = default(int);
		int num2 = default(int);
		uint num3 = default(uint);
		int num6 = default(int);
		uint num5 = default(uint);
		try
		{
			num = 1;
			Exception1.smethod_3();
			num2 = 12;
			num = 11;
			while (true)
			{
				num = 0;
				while (true)
				{
					uint_0 = new uint[256];
					num3 = 0u;
					num2 = 0;
					num = 11;
					while (true)
					{
						num = 20;
						int num4;
						if (num3 < 256)
						{
							num = 16;
							num4 = 6;
						}
						else
						{
							num = 10;
							num4 = 11;
						}
						num2 = num4;
						num = 11;
						while (true)
						{
							switch (num2)
							{
							case 10:
								num = 13;
								goto IL_0020;
							case 1:
							{
								num = 2;
								int num8;
								if (num6 >= 8)
								{
									num = 9;
									num8 = 8;
								}
								else
								{
									num = 15;
									num8 = 7;
								}
								num2 = num8;
								num = 11;
								continue;
							}
							case 9:
								num = 12;
								num6++;
								num2 = 1;
								num = 11;
								goto case 1;
							case 7:
							{
								num = 7;
								int num7;
								if ((num5 & (true ? 1u : 0u)) != 0)
								{
									num = 5;
									num7 = 5;
								}
								else
								{
									num = 4;
									num7 = 3;
								}
								num2 = num7;
								num = 11;
								continue;
							}
							case 6:
								num = 18;
								num5 = num3;
								num6 = 0;
								num = 13;
								goto IL_0020;
							case 5:
								num = 6;
								num5 = (num5 >> 1) ^ 0xEDB88320u;
								num2 = 9;
								num = 11;
								goto case 9;
							case 3:
								num = 3;
								num5 >>= 1;
								num2 = 9;
								num = 11;
								goto case 9;
							case 4:
								num = 21;
								goto IL_00d4;
							case 8:
								num = 21;
								goto IL_00d4;
							case 0:
								break;
							default:
								goto end_IL_00f2;
							case 2:
								goto IL_0106;
							case 12:
								goto end_IL_0108;
							case 11:
								{
									num = 8;
									return;
								}
								IL_00d4:
								uint_0[num3] = num5;
								num3++;
								num2 = 0;
								num = 11;
								break;
								IL_0020:
								num2 = 1;
								num = 11;
								goto case 1;
							}
							break;
						}
						continue;
						end_IL_00f2:
						break;
					}
					num = 0;
					continue;
					IL_0106:
					num = 0;
					continue;
					end_IL_0108:
					break;
				}
			}
		}
		catch (Exception exception)
		{
			int num9 = default(int);
			StackFrameHelper.CreateException6(exception, num3, num5, num6, num2, num, num9);
			throw;
		}
	}

	public Class6()
	{
		uint num = uint.MaxValue;
		uint_1 = uint.MaxValue;
		base._002Ector();
		try
		{
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, num, this);
			throw;
		}
	}
}
