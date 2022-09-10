using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Policy;
using SmartAssembly.SmartExceptionsCore;

namespace ns0;

internal sealed class Class5
{
	[StructLayout(LayoutKind.Auto)]
	internal struct Struct17
	{
		internal uint uint_0;

		internal uint uint_1;

		internal uint uint_2;

		internal uint uint_3;

		internal uint[] uint_4;

		internal uint[] uint_5;

		internal uint[] uint_6;

		internal uint[] uint_7;

		internal uint uint_8;

		internal bool bool_0;

		internal bool bool_1;

		internal uint uint_9;

		internal uint uint_10;

		internal uint uint_11;

		internal uint uint_12;
	}

	public uint uint_0;

	public uint uint_1;

	public Stream stream_0;

	public Class5()
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

	public void method_0(Stream stream_1)
	{
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		try
		{
			num = 1;
			num2 = 7;
			num = 9;
			while (true)
			{
				num = 11;
				while (true)
				{
					stream_0 = stream_1;
					uint_1 = 0u;
					uint_0 = uint.MaxValue;
					num3 = 0;
					num = 6;
					num2 = 1;
					num = 9;
					while (true)
					{
						num = 3;
						while (true)
						{
							int num4;
							if (num3 < 5)
							{
								num = 5;
								num4 = 6;
							}
							else
							{
								num = 12;
								num4 = 4;
							}
							num2 = num4;
							num = 9;
							switch (num2)
							{
							case 0:
								break;
							case 5:
								num = 10;
								goto IL_0074;
							case 6:
								num = 8;
								uint_1 = (uint_1 << 8) | (byte)Class0.smethod_3(stream_0, 79, 39);
								num = 10;
								goto IL_0074;
							case 3:
								num = 7;
								num3++;
								num2 = 1;
								num = 9;
								goto end_IL_0045;
							case 1:
								goto end_IL_0045;
							default:
								goto end_IL_0084;
							case 7:
								goto end_IL_008b;
							case 2:
								num = 2;
								return;
							case 4:
								{
									num = 2;
									return;
								}
								IL_0074:
								num2 = 3;
								num = 9;
								goto case 3;
							}
							num = 3;
							continue;
							end_IL_0045:
							break;
						}
						continue;
						end_IL_0084:
						break;
					}
					num = 11;
					continue;
					end_IL_008b:
					break;
				}
			}
		}
		catch (Exception exception)
		{
			int num5 = default(int);
			StackFrameHelper.CreateException6(exception, num3, num2, num, num5, this, stream_1);
			throw;
		}
	}

	public void method_1()
	{
		try
		{
			stream_0 = null;
		}
		catch (Exception exception)
		{
			int num = default(int);
			StackFrameHelper.CreateException2(exception, num, this);
			throw;
		}
	}

	public uint method_2(int int_0)
	{
		int num = default(int);
		uint num2 = default(uint);
		uint num3 = default(uint);
		uint num4 = default(uint);
		int num5 = default(int);
		int num6 = default(int);
		uint num8 = default(uint);
		try
		{
			num = 12;
			while (true)
			{
				num2 = uint_0;
				num3 = uint_1;
				num4 = 0u;
				num5 = int_0;
				num = 15;
				num6 = 10;
				num = 19;
				while (true)
				{
					num = 13;
					int num7;
					if (num5 > 0)
					{
						num = 21;
						num7 = 9;
					}
					else
					{
						num = 10;
						num7 = 4;
					}
					num6 = num7;
					num = 19;
					while (true)
					{
						int num9;
						switch (num6)
						{
						case 9:
							num = 11;
							num2 >>= 1;
							num8 = num3 - num2 >> 31;
							num = 4;
							num6 = 3;
							num = 19;
							goto case 3;
						case 3:
							num = 6;
							num3 -= num2 & (num8 - 1);
							num4 = (num4 << 1) | (1 - num8);
							num = 2;
							num6 = 8;
							num = 19;
							goto case 8;
						case 8:
							num = 9;
							if (num2 < 16777216)
							{
								num = 1;
								num9 = 2;
							}
							else
							{
								num = 20;
								num9 = 7;
							}
							goto IL_005a;
						case 0:
							num = 23;
							goto IL_00a7;
						case 1:
							num = 22;
							goto IL_00d1;
						case 2:
							num = 23;
							goto IL_00a7;
						case 5:
							num = 7;
							goto IL_00c8;
						case 11:
							num = 22;
							goto IL_00d1;
						case 7:
							num = 3;
							num5--;
							num6 = 10;
							num = 19;
							break;
						case 10:
							break;
						default:
							num = 16;
							goto IL_0108;
						case 12:
							num = 16;
							goto IL_0108;
						case 6:
							goto end_IL_00f3;
						case 4:
							{
								num = 14;
								uint_0 = num2;
								uint_1 = num3;
								return num4;
							}
							IL_0108:
							num6 = 6;
							num = 19;
							goto end_IL_00f3;
							IL_00a7:
							num3 = (num3 << 8) | (byte)Class0.smethod_3(stream_0, 732, 692);
							num = 7;
							goto IL_00c8;
							IL_00c8:
							num6 = 11;
							num = 19;
							goto case 11;
							IL_00d1:
							num2 <<= 8;
							num6 = 7;
							num = 19;
							goto case 7;
						}
						break;
						IL_005a:
						num6 = num9;
						num = 19;
					}
					continue;
					end_IL_00f3:
					break;
				}
				num = 12;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException9(exception, num2, num3, num4, num5, num8, num6, num, this, int_0);
			throw;
		}
	}

	static Class5()
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

	internal static object smethod_0(IntPtr intptr_0, Type type_0, int int_0, int int_1)
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
				case 120:
					num = 3;
					num2 = 6;
					break;
				default:
					num = 7;
					num2 = 0;
					break;
				}
				num3 = num2;
				num = 8;
				switch (num3)
				{
				default:
					num = 10;
					goto IL_004d;
				case 0:
					num = 5;
					num3 = 1;
					num = 8;
					goto case 1;
				case 3:
					num = 10;
					goto IL_004d;
				case 4:
					num = 4;
					num3 = 1;
					num = 8;
					goto case 1;
				case 5:
					num = 10;
					goto IL_004d;
				case 1:
					num = 6;
					continue;
				case 7:
					num = 6;
					continue;
				case 2:
					num = 11;
					break;
				case 6:
					{
						num = 11;
						break;
					}
					IL_004d:
					num3 = 1;
					num = 8;
					goto case 1;
				}
				break;
			}
			return Class7.Class8.Class9.smethod_1(intptr_0, type_0, 592, 635);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException6(exception, num3, num, intptr_0, type_0, int_0, int_1);
			throw;
		}
	}

	internal static string smethod_1(Assembly assembly_0, int int_0, int int_1)
	{
		int num = default(int);
		int num3 = default(int);
		try
		{
			num = 2;
			while (true)
			{
				int num2;
				switch (int_1 ^ int_0)
				{
				case 42:
					num = 11;
					num2 = 2;
					break;
				default:
					num = 3;
					num2 = 7;
					break;
				}
				num3 = num2;
				num = 1;
				switch (num3)
				{
				default:
					num = 8;
					goto IL_0043;
				case 1:
					num = 8;
					goto IL_0043;
				case 3:
					num = 7;
					num3 = 5;
					num = 1;
					goto IL_004f;
				case 6:
					num = 8;
					goto IL_0043;
				case 7:
					num = 6;
					num3 = 5;
					num = 1;
					goto IL_004f;
				case 5:
					goto IL_004f;
				case 0:
					num = 4;
					break;
				case 2:
					num = 4;
					break;
				case 4:
					{
						num = 4;
						break;
					}
					IL_0043:
					num3 = 5;
					num = 1;
					goto IL_004f;
				}
				break;
				IL_004f:
				num = 2;
			}
			return Class10.smethod_4(assembly_0, 92, 114);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num3, num, assembly_0, int_0, int_1);
			throw;
		}
	}

	internal static AppDomain smethod_2(int int_0, int int_1)
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
				case 116:
					num = 8;
					num2 = 5;
					break;
				default:
					num = 5;
					num2 = 4;
					break;
				}
				num3 = num2;
				num = 9;
				switch (num3)
				{
				default:
					num = 0;
					goto IL_0048;
				case 0:
					num = 0;
					goto IL_0048;
				case 2:
					num = 6;
					num3 = 3;
					num = 9;
					goto IL_0056;
				case 4:
					num = 1;
					goto IL_0051;
				case 6:
					num = 0;
					goto IL_0048;
				case 7:
					num = 1;
					goto IL_0051;
				case 3:
					goto IL_0056;
				case 1:
					num = 11;
					break;
				case 5:
					{
						num = 11;
						break;
					}
					IL_0051:
					num3 = 3;
					num = 9;
					goto IL_0056;
					IL_0048:
					num3 = 3;
					num = 9;
					goto IL_0056;
				}
				break;
				IL_0056:
				num = 7;
			}
			return Class10.Class11.smethod_1(404, 472);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num3, num, int_0, int_1);
			throw;
		}
	}

	internal static byte[] smethod_3(MemoryStream memoryStream_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 120:
					return Class10.smethod_1(memoryStream_0, 726, 762);
				}
				num = 5;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, memoryStream_0, int_0, int_1);
			throw;
		}
	}

	internal static Assembly smethod_4(byte[] byte_0, byte[] byte_1, Evidence evidence_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 91:
					return Class7.Class8.smethod_2(byte_0, byte_1, evidence_0, 66, 59);
				}
				num = 5;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException6(exception, num, byte_0, byte_1, evidence_0, int_0, int_1);
			throw;
		}
	}
}
