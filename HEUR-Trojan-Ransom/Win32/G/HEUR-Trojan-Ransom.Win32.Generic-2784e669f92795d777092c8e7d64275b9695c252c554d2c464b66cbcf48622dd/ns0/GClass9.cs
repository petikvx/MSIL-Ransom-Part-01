using System;
using System.Diagnostics;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.MyServices;

namespace ns0;

public class GClass9
{
	[DebuggerNonUserCode]
	public GClass9()
	{
		smethod_16(this);
	}

	public static byte smethod_0(object object_0)
	{
		byte[] array = (byte[])smethod_19(smethod_18(smethod_17()), object_0);
		return smethod_20(array, 0L, array.Length);
	}

	public static byte smethod_1(object object_0, long long_0, int int_0)
	{
		byte[] array = (byte[])smethod_19(smethod_18(smethod_17()), object_0);
		return smethod_20(array, long_0, array.Length);
	}

	public static byte smethod_2(object object_0)
	{
		return smethod_20(object_0, 0L, ((Array)object_0).Length);
	}

	public static byte smethod_3(object object_0, long long_0, long long_1)
	{
		smethod_22();
		byte b = default(byte);
		byte[] array = default(byte[]);
		int num = default(int);
		if (smethod_21())
		{
			while (true)
			{
				b = 0;
				if (smethod_21())
				{
					switch (8)
					{
					case 0:
					case 2:
						break;
					case 8:
						array = (byte[])object_0;
						goto case 1;
					case 1:
						num = 0;
						goto IL_0065;
					default:
						goto IL_005c;
					case 7:
						goto IL_0061;
					case 4:
					case 5:
					case 6:
						goto IL_0065;
					case 9:
						goto end_IL_000d;
					}
					continue;
				}
				break;
				continue;
				end_IL_000d:
				break;
			}
			goto IL_006c;
		}
		goto IL_0065;
		IL_0065:
		byte b2 = default(byte);
		if (num < array.Length)
		{
			b2 = array[num];
			goto IL_005c;
		}
		goto IL_006c;
		IL_006c:
		return b;
		IL_0061:
		num = checked(num + 1);
		goto IL_0065;
		IL_005c:
		checked
		{
			b = (byte)unchecked((uint)(b + b2));
			goto IL_0061;
		}
	}

	public static ushort smethod_4(object object_0, GEnum3 genum3_0)
	{
		byte[] array = (byte[])smethod_19(smethod_18(smethod_17()), object_0);
		return smethod_23(array, genum3_0, 0L, array.Length);
	}

	public static ushort smethod_5(object object_0, GEnum3 genum3_0, long long_0, int int_0)
	{
		byte[] array = (byte[])smethod_19(smethod_18(smethod_17()), object_0);
		return smethod_23(array, genum3_0, long_0, array.Length);
	}

	public static ushort smethod_6(object object_0, GEnum3 genum3_0)
	{
		return smethod_23(object_0, genum3_0, 0L, ((Array)object_0).Length);
	}

	public static ushort smethod_7(object object_0, GEnum3 genum3_0, long long_0, long long_1)
	{
		GClass1 object_ = new GClass1((byte[])object_0, genum3_0, long_0);
		byte[] array = (byte[])smethod_24(object_, checked((int)long_1));
		smethod_25(object_);
		ushort num = 0;
		byte[] array2 = array;
		int num2 = 0;
		_ = 1;
		if (!smethod_22())
		{
			goto IL_002e;
		}
		goto IL_0043;
		IL_0043:
		num2 = checked(num2 + 1);
		goto IL_002e;
		IL_002e:
		checked
		{
			if (num2 < array2.Length)
			{
				ushort num3 = array2[num2];
				num = (ushort)unchecked((uint)(num + num3));
				goto IL_0043;
			}
			return num;
		}
	}

	public static uint smethod_8(object object_0, GEnum3 genum3_0)
	{
		byte[] array = (byte[])smethod_19(smethod_18(smethod_17()), object_0);
		return smethod_26(array, genum3_0, 0L, array.Length);
	}

	public static uint smethod_9(object object_0, GEnum3 genum3_0, long long_0, int int_0)
	{
		byte[] array = (byte[])smethod_19(smethod_18(smethod_17()), object_0);
		return smethod_26(array, genum3_0, long_0, array.Length);
	}

	public static uint smethod_10(object object_0, GEnum3 genum3_0)
	{
		return smethod_26(object_0, genum3_0, 0L, ((Array)object_0).Length);
	}

	public static uint smethod_11(object object_0, GEnum3 genum3_0, long long_0, long long_1)
	{
		checked
		{
			uint num3 = default(uint);
			while (true)
			{
				GClass1 object_ = new GClass1((byte[])object_0, genum3_0, long_0);
				while (true)
				{
					byte[] array = (byte[])smethod_24(object_, (int)long_1);
					while (true)
					{
						smethod_25(object_);
						while (true)
						{
							uint num = 0u;
							while (true)
							{
								byte[] array2 = array;
								while (true)
								{
									int num2 = 0;
									while (true)
									{
										smethod_22();
										if (!smethod_21())
										{
											goto IL_0013;
										}
										goto IL_0065;
										IL_0065:
										if (num2 < array2.Length)
										{
											num3 = array2[num2];
											goto IL_0013;
										}
										goto IL_00a5;
										IL_00a5:
										return num;
										IL_0013:
										while (true)
										{
											num += num3;
											if (smethod_22())
											{
											}
											switch (5)
											{
											case 4:
											case 7:
												continue;
											case 5:
												num2++;
												goto IL_0065;
											case 0:
											case 2:
											case 6:
												goto IL_0065;
											case 1:
												goto end_IL_0006;
											case 9:
												goto end_IL_0079;
											case 10:
												goto end_IL_007e;
											case 8:
												goto end_IL_0083;
											case 11:
												goto end_IL_0087;
											case 3:
												goto end_IL_008f;
											case 12:
												goto IL_00a5;
											}
											break;
										}
										continue;
										end_IL_0006:
										break;
									}
									continue;
									end_IL_0079:
									break;
								}
								continue;
								end_IL_007e:
								break;
							}
							continue;
							end_IL_0083:
							break;
						}
						continue;
						end_IL_0087:
						break;
					}
					continue;
					end_IL_008f:
					break;
				}
			}
		}
	}

	public static ulong smethod_12(object object_0, GEnum3 genum3_0)
	{
		byte[] array = (byte[])smethod_19(smethod_18(smethod_17()), object_0);
		return smethod_27(array, genum3_0, 0L, array.Length);
	}

	public static ulong smethod_13(object object_0, GEnum3 genum3_0, long long_0, int int_0)
	{
		byte[] array = (byte[])smethod_19(smethod_18(smethod_17()), object_0);
		return smethod_27(array, genum3_0, long_0, array.Length);
	}

	public static ulong smethod_14(object object_0, GEnum3 genum3_0)
	{
		return smethod_27(object_0, genum3_0, 0L, ((Array)object_0).Length);
	}

	public static ulong smethod_15(object object_0, GEnum3 genum3_0, long long_0, long long_1)
	{
		int num = 8;
		if (!smethod_21())
		{
			goto IL_0064;
		}
		goto IL_0093;
		IL_0093:
		GClass1 object_ = default(GClass1);
		ulong num2 = default(ulong);
		byte[] array = default(byte[]);
		byte[] array2 = default(byte[]);
		while (true)
		{
			switch (num)
			{
			case 11:
				smethod_25(object_);
				goto case 10;
			case 10:
				num2 = 0uL;
				num = 1;
				if (smethod_21())
				{
					continue;
				}
				goto IL_0064;
			case 6:
			case 7:
				break;
			case 3:
				goto IL_004b;
			case 0:
				goto IL_0061;
			default:
				goto IL_0064;
			case 8:
				object_ = new GClass1((byte[])object_0, genum3_0, long_0);
				goto case 4;
			case 4:
				array = (byte[])smethod_24(object_, checked((int)long_1));
				goto case 11;
			case 1:
				array2 = array;
				goto IL_0061;
			case 12:
				return num2;
			}
			break;
		}
		goto IL_0046;
		IL_0061:
		int num3 = 0;
		goto IL_0064;
		IL_0046:
		ulong num4 = default(ulong);
		num2 = checked(num2 + num4);
		goto IL_004b;
		IL_004b:
		num3 = checked(num3 + 1);
		goto IL_0064;
		IL_0064:
		if (num3 < array2.Length)
		{
			num4 = array2[num3];
			smethod_21();
			if (!smethod_22())
			{
				goto IL_0046;
			}
			num = 5;
			if (smethod_22())
			{
				goto IL_0061;
			}
		}
		else
		{
			num = 12;
			if (smethod_22())
			{
			}
		}
		goto IL_0093;
	}

	internal static void smethod_16(object object_0)
	{
		object_0._002Ector();
	}

	internal static object smethod_17()
	{
		return Class11.Class10_0;
	}

	internal static object smethod_18(object object_0)
	{
		return ((ServerComputer)object_0).get_FileSystem();
	}

	internal static object smethod_19(object object_0, object object_1)
	{
		return ((FileSystemProxy)object_0).ReadAllBytes((string)object_1);
	}

	internal static byte smethod_20(object object_0, long long_0, long long_1)
	{
		return smethod_3(object_0, long_0, long_1);
	}

	internal static bool smethod_21()
	{
		return true;
	}

	internal static bool smethod_22()
	{
		return false;
	}

	internal static ushort smethod_23(object object_0, GEnum3 genum3_0, long long_0, long long_1)
	{
		return smethod_7(object_0, genum3_0, long_0, long_1);
	}

	internal static object smethod_24(object object_0, int int_0)
	{
		return ((GClass1)object_0).method_22(int_0);
	}

	internal static void smethod_25(object object_0)
	{
		((GClass1)object_0).method_71();
	}

	internal static uint smethod_26(object object_0, GEnum3 genum3_0, long long_0, long long_1)
	{
		return smethod_11(object_0, genum3_0, long_0, long_1);
	}

	internal static ulong smethod_27(object object_0, GEnum3 genum3_0, long long_0, long long_1)
	{
		return smethod_15(object_0, genum3_0, long_0, long_1);
	}
}
