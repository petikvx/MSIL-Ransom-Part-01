using System;
using System.CodeDom.Compiler;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Security.Policy;
using SmartAssembly.SmartExceptionsCore;
using ns0;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
internal sealed class Class1
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	internal Class1()
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

	internal static ResourceManager smethod_0()
	{
		int num = default(int);
		int num3 = default(int);
		ResourceManager o = default(ResourceManager);
		try
		{
			num = 1;
			while (true)
			{
				int num2;
				if (!GClass1.smethod_9(resourceManager_0, null, 866, 843))
				{
					num = 11;
					num2 = 5;
				}
				else
				{
					num = 13;
					num2 = 3;
				}
				num3 = num2;
				num = 2;
				switch (num3)
				{
				default:
					num = 7;
					goto IL_003b;
				case 0:
					num = 1;
					continue;
				case 4:
					num = 7;
					goto IL_003b;
				case 6:
					num = 1;
					continue;
				case 2:
					num = 9;
					goto IL_00a5;
				case 3:
					num = 10;
					o = new ResourceManager("stub_2.netrsrc", GClass2.smethod_4(Class0.smethod_4(typeof(Class1).TypeHandle, 418, 443), 383, 263));
					num = 8;
					goto IL_009e;
				case 7:
					num = 8;
					goto IL_009e;
				case 1:
					num = 9;
					goto IL_00a5;
				case 5:
					break;
					IL_009e:
					num3 = 1;
					num = 2;
					goto case 1;
					IL_00a5:
					resourceManager_0 = o;
					num3 = 5;
					num = 2;
					break;
					IL_003b:
					num3 = 6;
					num = 2;
					goto case 6;
				}
				break;
			}
			num = 0;
			return resourceManager_0;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, o, num3, num);
			throw;
		}
	}

	internal static byte[] smethod_1()
	{
		int num = default(int);
		object obj = default(object);
		int num2 = default(int);
		try
		{
			num = 4;
			obj = GClass1.smethod_10(smethod_0(), GClass2.smethod_0(1618746319, 6), cultureInfo_0, 621, 569);
			num = 6;
			num2 = 0;
			num = 3;
			return (byte[])obj;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, obj, num2, num);
			throw;
		}
	}

	static Class1()
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

	internal static long smethod_2(Stream stream_0, long long_0, SeekOrigin seekOrigin_0, int int_0, int int_1)
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
				case 17:
					num = 3;
					num2 = 5;
					break;
				default:
					num = 7;
					num2 = 4;
					break;
				}
				num3 = num2;
				num = 2;
				switch (num3)
				{
				default:
					num = 0;
					goto IL_0040;
				case 0:
					num = 12;
					goto IL_004e;
				case 1:
					num = 10;
					goto IL_0057;
				case 2:
					num = 0;
					goto IL_0040;
				case 3:
					num = 10;
					goto IL_0057;
				case 4:
					num = 12;
					goto IL_004e;
				case 6:
					num = 10;
					goto IL_0057;
				case 7:
					break;
				case 5:
					{
						num = 11;
						return Class7.Class8.Class9.smethod_3(stream_0, long_0, seekOrigin_0, 718, 661);
					}
					IL_0057:
					num3 = 7;
					num = 2;
					break;
					IL_004e:
					num3 = 7;
					num = 2;
					break;
					IL_0040:
					num3 = 7;
					num = 2;
					break;
				}
				num = 6;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException7(exception, num3, num, stream_0, long_0, seekOrigin_0, int_0, int_1);
			throw;
		}
	}

	internal static Assembly smethod_3(int int_0, int int_1)
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
				case 115:
					num = 6;
					num2 = 1;
					break;
				default:
					num = 7;
					num2 = 0;
					break;
				}
				num3 = num2;
				num = 4;
				switch (num3)
				{
				default:
					num = 9;
					goto IL_0041;
				case 0:
					num = 12;
					goto IL_0052;
				case 2:
					num = 8;
					break;
				case 3:
					num = 9;
					goto IL_0041;
				case 4:
					num = 3;
					num3 = 5;
					num = 4;
					goto case 5;
				case 6:
					num = 12;
					goto IL_0052;
				case 5:
					num = 8;
					break;
				case 7:
					num = 8;
					break;
				case 1:
					{
						num = 5;
						return Class7.Class8.Class9.smethod_5(380, 290);
					}
					IL_0052:
					num3 = 5;
					num = 4;
					goto case 5;
					IL_0041:
					num3 = 5;
					num = 4;
					goto case 5;
				}
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num3, num, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_4(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		int num = default(int);
		int num2 = default(int);
		try
		{
			num = 10;
			num2 = 1;
			num = 0;
			while (true)
			{
				num = 6;
				while (true)
				{
					int num3;
					switch (int_3 ^ int_2)
					{
					case 68:
						num = 7;
						num3 = 2;
						break;
					default:
						num = 2;
						num3 = 0;
						break;
					}
					num2 = num3;
					num = 0;
					switch (num2)
					{
					default:
						num = 6;
						continue;
					case 3:
						num = 6;
						continue;
					case 0:
						num = 4;
						num2 = 1;
						num = 0;
						break;
					case 1:
						break;
					case 2:
						num = 5;
						goto IL_0061;
					case 4:
						num = 3;
						return;
					case 5:
						{
							num = 5;
							goto IL_0061;
						}
						IL_0061:
						Class7.Class8.smethod_6(stream_0, byte_0, int_0, int_1, 799, 791);
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
			StackFrameHelper.CreateException10(exception, num2, num4, num, num5, stream_0, byte_0, int_0, int_1, int_2, int_3);
			throw;
		}
	}

	internal static Assembly smethod_5(int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 113:
					return Class7.Class8.Class9.smethod_5(140, 210);
				}
				num = 6;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, num, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_6(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		int num = default(int);
		try
		{
			num = 0;
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 103:
					Class7.Class8.smethod_6(stream_0, byte_0, int_0, int_1, 393, 385);
					return;
				}
				num = 0;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException8(exception, num, num2, stream_0, byte_0, int_0, int_1, int_2, int_3);
			throw;
		}
	}

	internal static Evidence smethod_7(Assembly assembly_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 34:
					return Class10.smethod_8(assembly_0, 416, 439);
				}
				num = 2;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, assembly_0, int_0, int_1);
			throw;
		}
	}
}
