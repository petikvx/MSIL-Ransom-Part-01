using System;
using SmartAssembly.SmartExceptionsCore;

namespace ns0;

internal struct Struct16
{
	internal Struct15[] struct15_0;

	internal int int_0;

	public Struct16(int int_1)
	{
		int num = default(int);
		Struct15[] o = default(Struct15[]);
		try
		{
			num = (int_0 = int_1);
			o = (struct15_0 = new Struct15[1 << int_1]);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, o, this, int_1);
			throw;
		}
	}

	public void method_0()
	{
		int num = default(int);
		int num2 = default(int);
		uint num3 = default(uint);
		try
		{
			num = 1;
			num2 = 1;
			num = 8;
			while (true)
			{
				num = 5;
				while (true)
				{
					num3 = 1u;
					num2 = 5;
					num = 8;
					while (true)
					{
						num = 7;
						int num4;
						if (num3 < 1 << int_0)
						{
							num = 10;
							num4 = 4;
						}
						else
						{
							num = 6;
							num4 = 6;
						}
						num2 = num4;
						num = 8;
						switch (num2)
						{
						case 0:
							num = 0;
							goto IL_003d;
						case 2:
							num = 0;
							goto IL_003d;
						case 4:
							num = 0;
							goto IL_003d;
						case 5:
							continue;
						default:
							goto end_IL_0060;
						case 1:
							break;
						case 3:
							num = 11;
							return;
						case 6:
							{
								num = 11;
								return;
							}
							IL_003d:
							struct15_0[num3].method_0();
							num3++;
							num = 2;
							num2 = 5;
							num = 8;
							continue;
						}
						goto end_IL_0076;
						continue;
						end_IL_0060:
						break;
					}
					num = 5;
					continue;
					end_IL_0076:
					break;
				}
			}
		}
		catch (Exception exception)
		{
			int num5 = default(int);
			StackFrameHelper.CreateException5(exception, num3, num2, num, num5, this);
			throw;
		}
	}

	public uint method_1(Class5 class5_0)
	{
		int num = default(int);
		uint num2 = default(uint);
		int num3 = default(int);
		int num4 = default(int);
		try
		{
			num = 11;
			while (true)
			{
				num2 = 1u;
				num3 = int_0;
				num4 = 7;
				num = 2;
				while (true)
				{
					num = 4;
					while (true)
					{
						int num5;
						if (num3 > 0)
						{
							num = 12;
							num5 = 2;
						}
						else
						{
							num = 0;
							num5 = 1;
						}
						num4 = num5;
						num = 2;
						switch (num4)
						{
						case 3:
							goto IL_003b;
						case 2:
							num = 3;
							goto IL_0050;
						case 4:
							num = 3;
							goto IL_0050;
						case 5:
							num = 10;
							goto IL_0070;
						case 0:
							num = 13;
							num3--;
							num4 = 7;
							num = 2;
							break;
						case 7:
							break;
						default:
							num = 7;
							goto IL_0089;
						case 6:
							num = 7;
							goto IL_0089;
						case 8:
							goto end_IL_007f;
						case 1:
							{
								num = 6;
								return num2 - (uint)(1 << int_0);
							}
							IL_0089:
							num4 = 8;
							num = 2;
							goto end_IL_007f;
							IL_0050:
							num2 = (num2 << 1) + struct15_0[num2].method_1(class5_0);
							num = 10;
							goto IL_0070;
							IL_0070:
							num4 = 0;
							num = 2;
							goto case 0;
						}
						break;
						IL_003b:
						num = 4;
					}
					continue;
					end_IL_007f:
					break;
				}
				num = 11;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException6(exception, num2, num3, num4, num, this, class5_0);
			throw;
		}
	}

	public uint method_2(Class5 class5_0)
	{
		int num = default(int);
		uint num2 = default(uint);
		uint num3 = default(uint);
		int num4 = default(int);
		int num5 = default(int);
		uint num7 = default(uint);
		try
		{
			num = 1;
			while (true)
			{
				num2 = 1u;
				num3 = 0u;
				num4 = 0;
				num5 = 6;
				num = 14;
				while (true)
				{
					num = 3;
					int num6;
					if (num4 < int_0)
					{
						num = 15;
						num6 = 2;
					}
					else
					{
						num = 6;
						num6 = 7;
					}
					num5 = num6;
					num = 14;
					switch (num5)
					{
					case 2:
						num = 12;
						num7 = struct15_0[num2].method_1(class5_0);
						num5 = 0;
						num = 14;
						goto case 0;
					case 0:
						num = 13;
						goto IL_0068;
					case 3:
						num = 0;
						goto IL_007e;
					case 8:
						num = 13;
						goto IL_0068;
					case 1:
						num = 8;
						num4++;
						num5 = 6;
						num = 14;
						continue;
					case 6:
						continue;
					default:
						num = 11;
						goto IL_00b3;
					case 4:
						num = 11;
						goto IL_00b3;
					case 5:
						num = 1;
						break;
					case 9:
						num = 1;
						break;
					case 7:
						{
							num = 9;
							return num3;
						}
						IL_00b3:
						num5 = 5;
						num = 14;
						goto case 5;
						IL_0068:
						num2 <<= 1;
						num2 += num7;
						num3 |= num7 << num4;
						num = 0;
						goto IL_007e;
						IL_007e:
						num5 = 1;
						num = 14;
						goto case 1;
					}
					break;
				}
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException8(exception, num2, num3, num4, num7, num5, num, this, class5_0);
			throw;
		}
	}

	public static uint smethod_0(Struct15[] struct15_1, uint uint_0, Class5 class5_0, int int_1)
	{
		int num = default(int);
		uint num2 = default(uint);
		uint num3 = default(uint);
		int num4 = default(int);
		int num5 = default(int);
		uint num7 = default(uint);
		try
		{
			num = 11;
			while (true)
			{
				num2 = 1u;
				num3 = 0u;
				num4 = 0;
				num5 = 3;
				num = 13;
				while (true)
				{
					num = 9;
					while (true)
					{
						int num6;
						if (num4 < int_1)
						{
							num = 6;
							num6 = 9;
						}
						else
						{
							num = 1;
							num6 = 7;
						}
						num5 = num6;
						num = 13;
						switch (num5)
						{
						case 0:
							break;
						case 5:
							goto IL_0045;
						case 9:
							num = 10;
							num7 = struct15_1[uint_0 + num2].method_1(class5_0);
							num2 <<= 1;
							num = 4;
							num5 = 4;
							num = 13;
							goto case 4;
						case 4:
							num = 0;
							num2 += num7;
							num3 |= num7 << num4;
							num = 12;
							num5 = 2;
							num = 13;
							goto case 2;
						case 2:
							num = 3;
							num4++;
							num5 = 3;
							num = 13;
							goto end_IL_004f;
						case 3:
							goto end_IL_004f;
						default:
							num = 8;
							goto IL_00a6;
						case 6:
							num = 8;
							goto IL_00a6;
						case 1:
							num = 11;
							goto end_IL_009b;
						case 8:
							num = 11;
							goto end_IL_009b;
						case 7:
							{
								num = 14;
								return num3;
							}
							IL_00a6:
							num5 = 1;
							num = 13;
							goto case 1;
						}
						num = 9;
						continue;
						IL_0045:
						num = 9;
						continue;
						end_IL_004f:
						break;
					}
					continue;
					end_IL_009b:
					break;
				}
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException10(exception, num2, num3, num4, num7, num5, num, struct15_1, uint_0, class5_0, int_1);
			throw;
		}
	}

	static Struct16()
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
