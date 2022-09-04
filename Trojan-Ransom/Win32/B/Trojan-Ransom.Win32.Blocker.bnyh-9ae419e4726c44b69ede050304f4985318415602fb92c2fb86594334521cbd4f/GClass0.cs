using System;
using System.IO;
using ns0;

public class GClass0
{
	public byte[] byte_0;

	private Stream stream_0;

	private bool bool_0;

	public uint uint_0;

	public uint uint_1;

	public uint rceResolve;

	private uint uint_2;

	private uint uint_3;

	public uint uint_4;

	internal uint uint_5;

	internal uint[] uint_6;

	internal uint[] uint_7;

	internal bool bool_1;

	internal uint uint_8;

	internal uint uint_9;

	internal uint uint_10;

	internal uint uint_11;

	internal uint uint_12;

	internal uint uint_13;

	public GClass0()
	{
		smethod_3();
	}

	public virtual void vmethod_0()
	{
	}

	public virtual void vmethod_1()
	{
	}

	public void method_0()
	{
		vmethod_0();
		uint num = uint_0 + rceResolve - uint_13;
		uint num2 = uint_0 + uint_4 - num;
		for (uint num3 = 0u; num3 < num2; num3++)
		{
			byte_0[num3] = byte_0[num + num3];
		}
		uint_0 -= num;
		vmethod_1();
	}

	public virtual void vmethod_2()
	{
		if (bool_0)
		{
			return;
		}
		while (true)
		{
			int num = (int)(0 - uint_0 + uint_1 - uint_4);
			if (num != 0)
			{
				int num2 = stream_0.Read(byte_0, (int)(uint_0 + uint_4), num);
				if (num2 == 0)
				{
					break;
				}
				uint_4 += (uint)num2;
				if (uint_4 >= rceResolve + uint_2)
				{
					uint num3 = (uint_11 = uint_4 - uint_2);
				}
				continue;
			}
			return;
		}
		uint num4 = (uint_11 = uint_4);
		uint num5 = uint_0 + uint_11;
		if (num5 > uint_12)
		{
			uint num6 = (uint_11 = uint_12 - uint_0);
		}
		bool_0 = true;
	}

	private void method_1()
	{
		byte_0 = null;
	}

	public void method_2(uint uint_14, uint uint_15, uint uint_16)
	{
		uint num = (uint_13 = uint_14);
		uint_2 = uint_15;
		uint_3 = uint_16;
		uint num2 = uint_14 + uint_15 + uint_16;
		if (byte_0 == null || uint_1 != num2)
		{
			method_1();
			uint_1 = num2;
			byte_0 = new byte[uint_1];
		}
		uint num3 = (uint_12 = uint_1 - uint_15);
	}

	public void method_3(Stream stream_1)
	{
		stream_0 = stream_1;
		uint_0 = 0u;
		rceResolve = 0u;
		uint_4 = 0u;
		bool_0 = false;
		vmethod_2();
	}

	public void method_4()
	{
		stream_0 = null;
	}

	public void method_5()
	{
		rceResolve++;
		if (rceResolve > uint_11)
		{
			uint num = uint_0 + rceResolve;
			if (num > uint_12)
			{
				method_0();
			}
			vmethod_2();
		}
	}

	public byte method_6(int int_0)
	{
		return byte_0[uint_0 + rceResolve + int_0];
	}

	public uint method_7(int int_0, uint uint_14, uint uint_15)
	{
		if (bool_0 && rceResolve + int_0 + uint_15 > uint_4)
		{
			uint_15 = uint_4 - (uint)(int)(rceResolve + int_0);
		}
		uint_14++;
		uint num = uint_0 + rceResolve + (uint)int_0;
		uint num2;
		for (num2 = 0u; num2 < uint_15 && byte_0[num + num2] == byte_0[num + num2 - uint_14]; num2++)
		{
		}
		return num2;
	}

	public uint method_8()
	{
		return uint_4 - rceResolve;
	}

	public void method_9(int int_0)
	{
		uint_0 += (uint)int_0;
		uint_11 -= (uint)int_0;
		rceResolve -= (uint)int_0;
		uint_4 -= (uint)int_0;
	}

	internal static int smethod_0()
	{
		AppDomain.CurrentDomain.SetData("fe8ac553a4f34e4a8e054c1983ee8380", null);
		return 7;
	}

	internal static int smethod_1()
	{
		AppDomain.CurrentDomain.SetData("fe8ac553a4f34e4a8e054c1983ee8380", null);
		return 13;
	}

	internal static void smethod_2()
	{
		smethod_2();
	}

	internal static byte smethod_3()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("fe8ac553a4f34e4a8e054c1983ee8380");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				smethod_2();
			}
			num++;
			if (array[num] >= 208)
			{
				if (208 != array[num])
				{
					smethod_1();
				}
				num++;
				if (array[num] >= 71)
				{
					if (71 != array[num])
					{
						Exception0.smethod_0();
					}
					num++;
					if (array[num] >= 251)
					{
						if (251 != array[num])
						{
							GClass1.smethod_10();
						}
						num++;
						if (array[num] >= 144)
						{
							if (144 != array[num])
							{
								GClass1.smethod_10();
							}
							num++;
							return 12;
						}
						return 22;
					}
					return 22;
				}
				return 18;
			}
			return 16;
		}
		return 15;
	}

	internal static int smethod_4()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("fe8ac553a4f34e4a8e054c1983ee8380");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				Exception0.smethod_1();
			}
			num++;
			if (array[num] >= 208)
			{
				if (208 != array[num])
				{
					GClass2.smethod_3();
				}
				num++;
				if (array[num] >= 71)
				{
					if (71 != array[num])
					{
						Exception0.smethod_2();
					}
					num++;
					if (array[num] >= 251)
					{
						if (251 != array[num])
						{
							Exception1.smethod_1();
						}
						num++;
						if (array[num] >= 144)
						{
							if (144 != array[num])
							{
								smethod_1();
							}
							num++;
							if (array[num] >= 220)
							{
								if (220 != array[num])
								{
									Exception0.smethod_0();
								}
								num++;
								if (array[num] >= 229)
								{
									if (229 != array[num])
									{
										GClass3.smethod_0();
									}
									num++;
									if (array[num] >= 178)
									{
										if (178 != array[num])
										{
											Exception1.smethod_1();
										}
										num++;
										return 4;
									}
									return 4;
								}
								return 10;
							}
							return 8;
						}
						return 12;
					}
					return 14;
				}
				return 14;
			}
			return 10;
		}
		return 14;
	}

	internal static long smethod_5()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("fe8ac553a4f34e4a8e054c1983ee8380");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				GClass2.smethod_0();
			}
			num++;
			return 12L;
		}
		return 11L;
	}

	internal static byte smethod_6()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("fe8ac553a4f34e4a8e054c1983ee8380");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				Exception1.smethod_1();
			}
			num++;
			if (array[num] >= 208)
			{
				if (208 != array[num])
				{
					Exception0.smethod_3();
				}
				num++;
				if (array[num] >= 71)
				{
					if (71 != array[num])
					{
						Exception0.smethod_2();
					}
					num++;
					if (array[num] >= 251)
					{
						if (251 != array[num])
						{
							smethod_0();
						}
						num++;
						if (array[num] >= 144)
						{
							if (144 != array[num])
							{
								smethod_2();
							}
							num++;
							if (array[num] >= 220)
							{
								if (220 != array[num])
								{
									GClass3.smethod_0();
								}
								num++;
								if (array[num] >= 229)
								{
									if (229 != array[num])
									{
										GClass2.smethod_2();
									}
									num++;
									return 17;
								}
								return 6;
							}
							return 1;
						}
						return 24;
					}
					return 20;
				}
				return 24;
			}
			return 13;
		}
		return 9;
	}

	internal static string smethod_7()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("fe8ac553a4f34e4a8e054c1983ee8380");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				Exception1.smethod_1();
			}
			num++;
			if (array[num] >= 208)
			{
				if (208 != array[num])
				{
					Exception0.smethod_2();
				}
				num++;
				if (array[num] >= 71)
				{
					if (71 != array[num])
					{
						GClass2.smethod_0();
					}
					num++;
					return null;
				}
				return null;
			}
			return null;
		}
		return null;
	}

	internal static void smethod_8()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("fe8ac553a4f34e4a8e054c1983ee8380");
		if (array[0] < 8)
		{
			return;
		}
		if (8 != array[num])
		{
			GClass3.smethod_0();
		}
		num++;
		if (array[num] < 208)
		{
			return;
		}
		if (208 != array[num])
		{
			smethod_1();
		}
		num++;
		if (array[num] < 71)
		{
			return;
		}
		if (71 != array[num])
		{
			GClass2.smethod_1();
		}
		num++;
		if (array[num] < 251)
		{
			return;
		}
		if (251 != array[num])
		{
			GClass3.smethod_0();
		}
		num++;
		if (array[num] < 144)
		{
			return;
		}
		if (144 != array[num])
		{
			smethod_1();
		}
		num++;
		if (array[num] < 220)
		{
			return;
		}
		if (220 != array[num])
		{
			Exception0.smethod_2();
		}
		num++;
		if (array[num] < 229)
		{
			return;
		}
		if (229 != array[num])
		{
			smethod_2();
		}
		num++;
		if (array[num] >= 178)
		{
			if (178 != array[num])
			{
				smethod_1();
			}
			num++;
		}
	}

	internal static string smethod_9()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("fe8ac553a4f34e4a8e054c1983ee8380");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				Exception1.smethod_1();
			}
			num++;
			if (array[num] >= 208)
			{
				if (208 != array[num])
				{
					smethod_2();
				}
				num++;
				if (array[num] >= 71)
				{
					if (71 != array[num])
					{
						Exception1.smethod_0();
					}
					num++;
					if (array[num] >= 251)
					{
						if (251 != array[num])
						{
							smethod_1();
						}
						num++;
						return null;
					}
					return null;
				}
				return null;
			}
			return null;
		}
		return null;
	}
}
