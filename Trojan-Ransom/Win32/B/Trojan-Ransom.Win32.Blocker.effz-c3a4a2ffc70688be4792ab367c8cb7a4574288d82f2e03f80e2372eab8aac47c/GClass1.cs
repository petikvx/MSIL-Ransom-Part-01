using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Runtime.InteropServices;
using SmartAssembly.SmartExceptionsCore;
using ns0;

public sealed class GClass1 : GClass0, Interface0, Interface1
{
	[StructLayout(LayoutKind.Auto)]
	internal struct Struct2
	{
		internal Struct15[] struct15_0;

		internal int int_0;
	}

	[StructLayout(LayoutKind.Auto)]
	internal struct Struct3
	{
		internal Struct15 struct15_0;

		internal Struct15 struct15_1;

		internal Struct16[] struct16_0;

		internal Struct16[] struct16_1;

		internal Struct16 struct16_2;

		internal uint uint_0;
	}

	[StructLayout(LayoutKind.Auto)]
	internal struct Struct4
	{
		internal byte[] byte_0;

		internal uint uint_0;

		internal uint uint_1;

		internal uint uint_2;

		internal Stream stream_0;
	}

	internal uint uint_9;

	internal uint uint_10;

	internal uint uint_11;

	internal uint uint_12;

	internal uint[] uint_13;

	internal uint[] uint_14;

	internal uint[] uint_15;

	internal uint[] uint_16;

	internal uint uint_17;

	internal bool bool_1;

	internal bool bool_2;

	internal uint uint_18;

	internal uint uint_19;

	internal uint uint_20;

	internal uint uint_21;

	public GClass1()
	{
		uint num = 255u;
		uint_17 = 255u;
		bool flag = true;
		bool_1 = true;
		uint num2 = 1024u;
		uint_18 = 1024u;
		uint num3 = 4u;
		uint_20 = 4u;
		uint num4 = 1048576u;
		uint_21 = 1048576u;
		base._002Ector();
		try
		{
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException6(exception, num, flag, num2, num3, num4, this);
			throw;
		}
	}

	public void method_10(int int_0, bool bool_3)
	{
		int num = default(int);
		int num2 = default(int);
		bool flag = default(bool);
		bool flag2 = default(bool);
		uint num3 = default(uint);
		uint num4 = default(uint);
		uint num5 = default(uint);
		uint num6 = default(uint);
		uint num7 = default(uint);
		uint num8 = default(uint);
		int num9 = default(int);
		int num10 = default(int);
		uint num11 = default(uint);
		try
		{
			num = 5;
			num2 = 5;
			num = 0;
			flag = (bool_1 = int_0 > 2);
			num = 3;
			flag2 = (bool_2 = bool_3);
			num = 10;
			num2 = 3;
			num = 0;
			if (bool_1)
			{
				num = 7;
				num2 = 0;
				num = 0;
				num3 = 1024u;
				uint_18 = 1024u;
				num4 = 0u;
				uint_19 = 0u;
				num = 9;
				num2 = 4;
				num = 0;
				num5 = 4u;
				uint_20 = 4u;
				num6 = (uint_21 = (bool_2 ? 8388608u : 1048576u));
			}
			else
			{
				num7 = 2u;
				uint_19 = 2u;
				num8 = 2u;
				uint_20 = 2u;
				num9 = 6;
				num10 = 4;
				num9 = 0;
				num11 = 65536u;
				uint_21 = 65536u;
				num9 = 2;
			}
		}
		catch (Exception caughtException)
		{
			StackFrameHelper.CreateExceptionN(caughtException, new object[16]
			{
				flag, flag2, num3, num4, num5, num6, num7, num8, num11, num2,
				num10, num, num9, this, int_0, bool_3
			});
			throw;
		}
	}

	private uint method_11(uint uint_22, out uint uint_23, out uint uint_24)
	{
		int num = default(int);
		uint num2 = default(uint);
		int num3 = default(int);
		try
		{
			num = 11;
			num2 = Class6.uint_0[byte_0[uint_22]] ^ byte_0[uint_22 + 1];
			num = 12;
			num3 = 3;
			num = 10;
			uint_23 = num2 & (uint_18 - 1);
			num = 9;
			num3 = 4;
			num = 10;
			num2 ^= (uint)(byte_0[uint_22 + 2] << 8);
			num = 7;
			num3 = 2;
			num = 10;
			uint_24 = num2 & 0x3FFFFu;
			return (num2 ^ (Class6.uint_0[byte_0[uint_22 + 3]] << 5)) & (uint_21 - 1);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException7(exception, num2, num3, num, this, uint_22, uint_23, uint_24);
			throw;
		}
	}

	private uint method_12(uint uint_22)
	{
		int num = default(int);
		try
		{
			num = 1;
			return (uint)(byte_0[uint_22] ^ (byte_0[uint_22 + 1] << 8));
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException4(exception, num2, num, this, uint_22);
			throw;
		}
	}

	public void imethod_0(Stream stream_1)
	{
		int num = default(int);
		int num2 = default(int);
		uint num3 = default(uint);
		uint num5 = default(uint);
		try
		{
			num = 1;
			num2 = 6;
			num = 10;
			while (true)
			{
				num = 17;
				while (true)
				{
					method_3(stream_1);
					num3 = 0u;
					num2 = 9;
					num = 10;
					while (true)
					{
						num = 18;
						while (true)
						{
							int num4;
							if (num3 < uint_21)
							{
								num = 8;
								num4 = 5;
							}
							else
							{
								num = 20;
								num4 = 1;
							}
							num2 = num4;
							num = 10;
							while (true)
							{
								switch (num2)
								{
								case 13:
									num = 19;
									num3 = 0u;
									num2 = 7;
									num = 10;
									goto case 7;
								case 7:
								{
									num = 9;
									int num7;
									if (num3 >= 262144)
									{
										num = 26;
										num7 = 4;
									}
									else
									{
										num = 6;
										num7 = 10;
									}
									num2 = num7;
									num = 10;
									continue;
								}
								case 11:
									num = 24;
									uint_15[num3] = 0u;
									num3++;
									num = 25;
									num2 = 8;
									num = 10;
									goto case 8;
								case 8:
								{
									num = 16;
									int num8;
									if (num3 >= uint_18)
									{
										num = 23;
										num8 = 13;
									}
									else
									{
										num = 0;
										num8 = 11;
									}
									num2 = num8;
									num = 10;
									continue;
								}
								case 10:
									num = 15;
									uint_16[num3] = 0u;
									num3++;
									num = 11;
									num2 = 7;
									num = 10;
									goto case 7;
								case 3:
									num = 13;
									goto IL_0091;
								case 2:
									num = 13;
									goto IL_0091;
								case 1:
								{
									num = 2;
									int num6;
									if (bool_1)
									{
										num = 14;
										num6 = 3;
									}
									else
									{
										num = 7;
										num6 = 4;
									}
									num2 = num6;
									num = 10;
									continue;
								}
								case 12:
									break;
								case 5:
									num = 21;
									uint_14[num3] = 0u;
									num3++;
									num = 3;
									num2 = 9;
									num = 10;
									goto end_IL_0104;
								case 9:
									goto end_IL_0104;
								default:
									goto end_IL_012b;
								case 6:
									goto end_IL_0133;
								case 0:
									num = 5;
									goto IL_014f;
								case 4:
									{
										num = 5;
										goto IL_014f;
									}
									IL_014f:
									num5 = 0u;
									uint_9 = 0u;
									method_9(-1);
									return;
									IL_0091:
									num3 = 0u;
									num2 = 8;
									num = 10;
									goto case 8;
								}
								break;
							}
							num = 18;
							continue;
							end_IL_0104:
							break;
						}
						continue;
						end_IL_012b:
						break;
					}
					num = 17;
					continue;
					end_IL_0133:
					break;
				}
			}
		}
		catch (Exception exception)
		{
			int num9 = default(int);
			StackFrameHelper.CreateException7(exception, num3, num5, num2, num, num9, this, stream_1);
			throw;
		}
	}

	public void imethod_1()
	{
		try
		{
			method_4();
		}
		catch (Exception exception)
		{
			int num = default(int);
			StackFrameHelper.CreateException2(exception, num, this);
			throw;
		}
	}

	public void imethod_2()
	{
		int num = default(int);
		int num2 = default(int);
		uint num3 = default(uint);
		uint num5 = default(uint);
		try
		{
			num = 7;
			num2 = 6;
			num = 15;
			while (true)
			{
				num = 0;
				while (true)
				{
					num3 = ++uint_9;
					num = 10;
					num2 = 2;
					num = 15;
					while (true)
					{
						num = 14;
						int num4;
						if (uint_9 < uint_10)
						{
							num = 13;
							num4 = 1;
						}
						else
						{
							num = 6;
							num4 = 4;
						}
						num2 = num4;
						num = 15;
						while (true)
						{
							int num6;
							switch (num2)
							{
							case 5:
								num = 8;
								goto IL_0018;
							case 4:
								num = 9;
								num5 = 0u;
								uint_9 = 0u;
								num2 = 1;
								num = 15;
								goto case 1;
							case 1:
								num = 5;
								method_5();
								goto IL_0018;
							case 2:
								break;
							default:
								goto end_IL_0080;
							case 6:
								goto end_IL_0098;
							case 0:
								num = 2;
								return;
							case 3:
								num = 3;
								goto IL_00c4;
							case 7:
								num = 3;
								goto IL_00c4;
							case 8:
								{
									num = 3;
									goto IL_00c4;
								}
								IL_00c4:
								method_14();
								return;
								IL_0018:
								if (uint_2 == int.MaxValue)
								{
									num = 11;
									num6 = 8;
								}
								else
								{
									num = 1;
									num6 = 0;
								}
								num2 = num6;
								num = 15;
								continue;
							}
							break;
						}
						continue;
						end_IL_0080:
						break;
					}
					num = 0;
					continue;
					end_IL_0098:
					break;
				}
			}
		}
		catch (Exception exception)
		{
			int num7 = default(int);
			StackFrameHelper.CreateException6(exception, num3, num5, num2, num, num7, this);
			throw;
		}
	}

	public byte imethod_3(int int_0)
	{
		int num = default(int);
		try
		{
			num = 7;
			return method_6(int_0);
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException4(exception, num2, num, this, int_0);
			throw;
		}
	}

	public uint imethod_4(int int_0, uint uint_22, uint uint_23)
	{
		int num = default(int);
		try
		{
			num = 7;
			return method_7(int_0, uint_22, uint_23);
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, num2, num, this, int_0, uint_22, uint_23);
			throw;
		}
	}

	public uint imethod_5()
	{
		int num = default(int);
		try
		{
			num = 5;
			return method_8();
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException3(exception, num2, num, this);
			throw;
		}
	}

	public void imethod_6(uint uint_22, uint uint_23, uint uint_24, uint uint_25)
	{
		int num = default(int);
		int num2 = default(int);
		uint num3 = default(uint);
		uint[] array = default(uint[]);
		uint[] array2 = default(uint[]);
		uint[] array3 = default(uint[]);
		uint[] array4 = default(uint[]);
		uint num5 = default(uint);
		uint num6 = default(uint);
		uint[] array5 = default(uint[]);
		uint[] array6 = default(uint[]);
		uint num7 = default(uint);
		uint[] array7 = default(uint[]);
		uint[] array8 = default(uint[]);
		try
		{
			num = 23;
			num2 = 10;
			num = 25;
			while (true)
			{
				num = 20;
				while (true)
				{
					num3 = (uint_22 + uint_23 + uint_24 + uint_25) / 2u + 256;
					num = 9;
					num2 = 9;
					num = 25;
					while (true)
					{
						num = 16;
						array = (uint_13 = null);
						array2 = (uint_14 = null);
						num = 15;
						num2 = 4;
						num = 25;
						while (true)
						{
							num = 2;
							array3 = (uint_15 = null);
							array4 = (uint_16 = null);
							num = 7;
							num2 = 7;
							num = 25;
							while (true)
							{
								num = 18;
								method_2(uint_22 + uint_23, uint_24 + uint_25, num3);
								int num4;
								if (uint_1 + 256 <= int.MaxValue)
								{
									num = 1;
									num4 = 0;
								}
								else
								{
									num = 3;
									num4 = 12;
								}
								num2 = num4;
								num = 25;
								while (true)
								{
									switch (num2)
									{
									case 14:
										num = 17;
										goto IL_001d;
									case 8:
										num = 8;
										goto IL_004a;
									case 11:
									{
										num = 27;
										int num8;
										if (bool_1)
										{
											num = 22;
											num8 = 5;
										}
										else
										{
											num = 5;
											num8 = 13;
										}
										num2 = num8;
										num = 25;
										continue;
									}
									case 3:
										num = 17;
										goto IL_001d;
									case 2:
										num = 8;
										goto IL_004a;
									case 0:
										num = 21;
										num5 = (uint_11 = uint_22);
										num6 = (uint_12 = uint_24);
										num = 26;
										num2 = 14;
										num = 25;
										goto case 14;
									case 7:
										break;
									case 4:
										goto end_IL_00fe;
									case 9:
										goto end_IL_0128;
									default:
										goto end_IL_0149;
									case 10:
										goto end_IL_016f;
									case 5:
										num = 4;
										array5 = (uint_15 = new uint[uint_18]);
										num = 14;
										num2 = 1;
										num = 25;
										goto case 1;
									case 1:
										num = 19;
										array6 = (uint_16 = new uint[262144]);
										num2 = 13;
										num = 25;
										goto case 13;
									case 6:
										num = 0;
										goto IL_01d7;
									case 12:
										num = 0;
										goto IL_01d7;
									case 13:
										{
											num = 24;
											return;
										}
										IL_01d7:
										throw new Exception();
										IL_001d:
										num7 = (uint_10 = uint_22 + 1);
										array7 = (uint_13 = new uint[uint_10 * 2]);
										num = 12;
										num2 = 8;
										num = 25;
										goto case 8;
										IL_004a:
										array8 = (uint_14 = new uint[uint_21]);
										num = 6;
										num2 = 11;
										num = 25;
										goto case 11;
									}
									break;
								}
								continue;
								end_IL_00fe:
								break;
							}
							continue;
							end_IL_0128:
							break;
						}
						continue;
						end_IL_0149:
						break;
					}
					num = 20;
					continue;
					end_IL_016f:
					break;
				}
			}
		}
		catch (Exception caughtException)
		{
			int num9 = default(int);
			StackFrameHelper.CreateExceptionN(caughtException, new object[20]
			{
				num3, array, array2, array3, array4, num5, num6, num7, array7, array8,
				array5, array6, num2, num, num9, this, uint_22, uint_23, uint_24, uint_25
			});
			throw;
		}
	}

	public uint imethod_7(uint[] uint_22)
	{
		int num = default(int);
		int num3 = default(int);
		bool flag = default(bool);
		uint num24 = default(uint);
		uint num13 = default(uint);
		uint num6 = default(uint);
		uint num15 = default(uint);
		uint num27 = default(uint);
		uint num14 = default(uint);
		uint num18 = default(uint);
		uint num11 = default(uint);
		uint num38 = default(uint);
		uint uint_23 = default(uint);
		uint num36 = default(uint);
		uint uint_24 = default(uint);
		uint num43 = default(uint);
		uint num10 = default(uint);
		uint num4 = default(uint);
		uint num5 = default(uint);
		uint num46 = default(uint);
		uint num21 = default(uint);
		uint num22 = default(uint);
		uint num9 = default(uint);
		uint num17 = default(uint);
		uint num41 = default(uint);
		bool flag2 = default(bool);
		try
		{
			num = 0;
			while (true)
			{
				int num2;
				if (uint_2 + uint_12 > uint_3)
				{
					num = 112;
					num2 = 58;
				}
				else
				{
					num = 24;
					num2 = 81;
				}
				num3 = num2;
				num = 58;
				while (true)
				{
					int num48;
					int num8;
					int num12;
					int num34;
					int num51;
					switch (num3)
					{
					case 83:
					{
						num = 117;
						int num30;
						if (flag)
						{
							num = 99;
							num30 = 22;
						}
						else
						{
							num = 17;
							num30 = 49;
						}
						num3 = num30;
						num = 58;
						continue;
					}
					case 82:
						num = 64;
						num24 = (uint_9 << 1) + 1;
						num13 = uint_9 << 1;
						num = 44;
						num3 = 13;
						num = 58;
						goto case 13;
					case 13:
						num = 119;
						num6 = (num15 = (num27 = uint_19));
						uint_22[num6] = uint_2 - num14 - 1;
						num = 35;
						num3 = 29;
						num = 58;
						goto case 29;
					case 29:
						num = 59;
						num18 = uint_17;
						num3 = 48;
						num = 58;
						goto case 48;
					case 48:
					{
						num = 154;
						int num35;
						if (num18 == 0)
						{
							num = 55;
							num35 = 8;
						}
						else
						{
							num = 88;
							num35 = 26;
						}
						num3 = num35;
						num = 58;
						continue;
					}
					case 81:
						num = 34;
						num11 = uint_12;
						num3 = 78;
						num = 58;
						goto case 78;
					case 78:
					{
						num = 29;
						int num45;
						if (uint_2 <= uint_11)
						{
							num = 101;
							num45 = 59;
						}
						else
						{
							num = 141;
							num45 = 38;
						}
						num3 = num45;
						num = 58;
						continue;
					}
					case 80:
						num = 42;
						num38 = uint_15[uint_23];
						num36 = uint_16[uint_24];
						num = 53;
						num3 = 55;
						num = 58;
						goto case 55;
					case 55:
					{
						num = 164;
						uint_15[uint_23] = uint_2;
						int num53;
						if (num38 >= num43)
						{
							num = 172;
							num53 = 70;
						}
						else
						{
							num = 153;
							num53 = 40;
						}
						num3 = num53;
						num = 58;
						continue;
					}
					case 79:
					{
						num = 96;
						num14 = uint_13[num13];
						int num16;
						if (num10 > num15)
						{
							num = 170;
							num16 = 71;
						}
						else
						{
							num = 65;
							num16 = 9;
						}
						num3 = num16;
						num = 58;
						continue;
					}
					case 77:
					{
						num = 162;
						int num56;
						if (num4 < uint_22[2])
						{
							num = 130;
							num56 = 45;
						}
						else
						{
							num = 120;
							num56 = 25;
						}
						num3 = num56;
						num = 58;
						continue;
					}
					case 76:
						num = 146;
						num4 = num5;
						num3 = 34;
						num = 58;
						goto case 34;
					case 34:
					{
						num = 109;
						uint_14[num46] = uint_2;
						int num50;
						if (num14 < num43)
						{
							num = 62;
							num50 = 35;
						}
						else
						{
							num = 174;
							num50 = 82;
						}
						num3 = num50;
						num = 58;
						continue;
					}
					case 75:
					{
						num = 63;
						int num32;
						if (byte_0[num21 + num10] < byte_0[num22 + num10])
						{
							num = 79;
							num32 = 19;
						}
						else
						{
							num = 81;
							num32 = 72;
						}
						num3 = num32;
						num = 58;
						continue;
					}
					case 74:
						num = 160;
						num4 = num5;
						flag = true;
						num3 = 34;
						num = 58;
						goto case 34;
					case 73:
					{
						num = 126;
						int num61;
						if (num6 < 3)
						{
							num = 127;
							num61 = 54;
						}
						else
						{
							num = 167;
							num61 = 43;
						}
						num3 = num61;
						num = 58;
						continue;
					}
					case 72:
						num = 61;
						uint_13[num24] = num14;
						num24 = num9;
						num3 = 1;
						num = 58;
						goto case 1;
					case 1:
					{
						num = 128;
						num14 = uint_13[num24];
						int num55;
						if (num10 > num27)
						{
							num = 1;
							num55 = 53;
						}
						else
						{
							num = 19;
							num55 = 9;
						}
						num3 = num55;
						num = 58;
						continue;
					}
					case 71:
						num = 31;
						num15 = num10;
						num3 = 9;
						num = 58;
						goto case 9;
					case 9:
					{
						num = 14;
						int num44;
						if (num14 >= num43)
						{
							num = 3;
							num44 = 5;
						}
						else
						{
							num = 163;
							num44 = 8;
						}
						num3 = num44;
						num = 58;
						continue;
					}
					case 70:
					{
						num = 49;
						int num39;
						if (byte_0[uint_0 + num38] == byte_0[num22])
						{
							num = 106;
							num39 = 65;
						}
						else
						{
							num = 12;
							num39 = 40;
						}
						num3 = num39;
						num = 58;
						continue;
					}
					case 69:
						num = 97;
						uint_22[++num6] = num17 - 1;
						num = 103;
						num3 = 0;
						num = 58;
						goto case 0;
					case 0:
					{
						num = 173;
						int num26;
						if (num10 <= num6)
						{
							num = 8;
							num26 = 11;
						}
						else
						{
							num = 2;
							num26 = 69;
						}
						num3 = num26;
						num = 58;
						continue;
					}
					case 68:
					{
						num = 98;
						int num20;
						if (num5 < num4)
						{
							num = 5;
							num20 = 76;
						}
						else
						{
							num = 4;
							num20 = 34;
						}
						num3 = num20;
						num = 58;
						continue;
					}
					case 65:
						num = 176;
						num4 = uint_2 - num38 - 1;
						num41 = 2u;
						flag = true;
						num = 121;
						num3 = 40;
						num = 58;
						goto case 40;
					case 40:
					{
						num = 158;
						uint_16[uint_24] = uint_2;
						int num59;
						if (num36 >= num43)
						{
							num = 115;
							num59 = 27;
						}
						else
						{
							num = 9;
							num59 = 34;
						}
						num3 = num59;
						num = 58;
						continue;
					}
					case 63:
						num = 30;
						uint_13[num24] = uint_13[num9 + 1];
						num = 86;
						num3 = 18;
						num = 58;
						goto case 18;
					case 18:
						num = 139;
						uint_13[num13] = uint_13[num9];
						num = 83;
						num3 = 17;
						num = 58;
						goto case 17;
					case 17:
					{
						num = 90;
						int num57;
						if (bool_1)
						{
							num = 157;
							num57 = 83;
						}
						else
						{
							num = 148;
							num57 = 64;
						}
						num3 = num57;
						num = 58;
						continue;
					}
					case 59:
						num = 69;
						num48 = 1;
						goto IL_03f3;
					case 23:
						num = 78;
						goto IL_0419;
					case 58:
					{
						num = 135;
						num11 = uint_3 - uint_2;
						int num40;
						if (num11 < uint_20)
						{
							num = 123;
							num40 = 51;
						}
						else
						{
							num = 145;
							num40 = 78;
						}
						num3 = num40;
						num = 58;
						continue;
					}
					case 57:
						num = 13;
						uint_22[2] = num4;
						num6 = 2u;
						num3 = 25;
						num = 58;
						goto case 25;
					case 25:
						num = 156;
						goto IL_0489;
					case 56:
					{
						num = 168;
						int num29;
						if (flag)
						{
							num = 110;
							num29 = 7;
						}
						else
						{
							num = 85;
							num29 = 25;
						}
						num3 = num29;
						num = 58;
						continue;
					}
					case 53:
						num = 125;
						num27 = num10;
						num3 = 9;
						num = 58;
						goto case 9;
					case 52:
					{
						num = 45;
						int num23;
						if (byte_0[num21 + num10] == byte_0[num22 + num10])
						{
							num = 38;
							num23 = 6;
						}
						else
						{
							num = 131;
							num23 = 44;
						}
						num3 = num23;
						num = 58;
						continue;
					}
					case 50:
						num = 66;
						num8 = (int)(uint_9 - num17);
						goto IL_0517;
					case 49:
					{
						num = 116;
						int num60;
						if (flag2)
						{
							num = 56;
							num60 = 3;
						}
						else
						{
							num = 43;
							num60 = 64;
						}
						num3 = num60;
						num = 58;
						continue;
					}
					case 47:
						num = 16;
						num36 = 0u;
						num4 = 0u;
						num5 = 0u;
						flag = false;
						flag2 = false;
						num = 33;
						num3 = 42;
						num = 58;
						goto case 42;
					case 42:
					{
						num = 161;
						int num58;
						if (bool_1)
						{
							num = 73;
							num58 = 80;
						}
						else
						{
							num = 15;
							num58 = 34;
						}
						num3 = num58;
						num = 58;
						continue;
					}
					case 45:
						num = 6;
						uint_22[2] = num4;
						num3 = 25;
						num = 58;
						goto case 25;
					case 44:
						num = 40;
						num17 = uint_2 - num14;
						num3 = 0;
						num = 58;
						goto case 0;
					case 43:
					{
						num = 165;
						int num54;
						if (num5 < uint_22[3])
						{
							num = 92;
							num54 = 66;
						}
						else
						{
							num = 23;
							num54 = 62;
						}
						num3 = num54;
						num = 58;
						continue;
					}
					case 41:
						num = 91;
						uint_13[(uint_9 << 1) + 1] = 0u;
						num = 143;
						num3 = 28;
						num = 58;
						goto case 28;
					case 28:
					{
						num = 27;
						int num52;
						if (bool_1)
						{
							num = 94;
							num52 = 67;
						}
						else
						{
							num = 166;
							num52 = 46;
						}
						num3 = num52;
						num = 58;
						continue;
					}
					case 39:
					{
						num = 71;
						int num49;
						if (bool_1)
						{
							num = 20;
							num49 = 56;
						}
						else
						{
							num = 142;
							num49 = 62;
						}
						num3 = num49;
						num = 58;
						continue;
					}
					case 38:
						num = 80;
						num48 = (int)(uint_2 - uint_11);
						goto IL_03f3;
					case 37:
						num = 76;
						uint_13[num24] = num14;
						num24 = num9;
						num3 = 2;
						num = 58;
						goto case 2;
					case 2:
					{
						num = 151;
						num14 = uint_13[num24];
						int num47;
						if (num10 > num27)
						{
							num = 132;
							num47 = 30;
						}
						else
						{
							num = 46;
							num47 = 9;
						}
						num3 = num47;
						num = 58;
						continue;
					}
					case 36:
						num = 18;
						num46 = method_12(num22);
						num3 = 15;
						num = 58;
						goto case 15;
					case 15:
						num = 36;
						num14 = uint_14[num46];
						num38 = 0u;
						num3 = 47;
						num = 58;
						goto case 47;
					case 35:
						num = 133;
						uint_13[uint_9 << 1] = 0u;
						num = 134;
						num3 = 41;
						num = 58;
						goto case 41;
					case 33:
						num = 149;
						num46 = method_11(num22, out uint_23, out uint_24);
						num3 = 15;
						num = 58;
						goto case 15;
					case 32:
						num = 48;
						num8 = (int)(uint_9 - num17 + uint_10);
						goto IL_0517;
					case 31:
						num = 25;
						num5 = uint_2 - num36 - 1;
						num41 = 3u;
						flag2 = true;
						num = 11;
						num3 = 12;
						num = 58;
						goto case 12;
					case 12:
					{
						num = 74;
						int num42;
						if (flag)
						{
							num = 82;
							num42 = 68;
						}
						else
						{
							num = 155;
							num42 = 74;
						}
						num3 = num42;
						num = 58;
						continue;
					}
					case 30:
						num = 21;
						num27 = num10;
						num3 = 9;
						num = 58;
						goto case 9;
					case 27:
					{
						num = 159;
						int num37;
						if (byte_0[uint_0 + num36] == byte_0[num22])
						{
							num = 129;
							num37 = 31;
						}
						else
						{
							num = 150;
							num37 = 34;
						}
						num3 = num37;
						num = 58;
						continue;
					}
					case 26:
						num = 26;
						num21 = uint_0 + num14;
						num10 = Exception0.smethod_6(num15, num27, 676, 738);
						num = 28;
						num3 = 10;
						num = 58;
						goto case 10;
					case 10:
					{
						num = 84;
						int num33;
						if (num10 >= num11)
						{
							num = 54;
							num33 = 44;
						}
						else
						{
							num = 140;
							num33 = 52;
						}
						num3 = num33;
						num = 58;
						continue;
					}
					case 22:
					{
						num = 105;
						int num31;
						if (num4 < uint_22[2])
						{
							num = 68;
							num31 = 20;
						}
						else
						{
							num = 37;
							num31 = 49;
						}
						num3 = num31;
						num = 58;
						continue;
					}
					case 20:
						num = 67;
						uint_22[2] = num4;
						num3 = 49;
						num = 58;
						goto case 49;
					case 19:
						num = 122;
						uint_13[num13] = num14;
						num13 = num9 + 1;
						num = 57;
						num3 = 79;
						num = 58;
						goto case 79;
					case 16:
						num = 156;
						goto IL_0489;
					case 14:
					{
						num = 100;
						int num28;
						if (num10 < uint_12)
						{
							num = 41;
							num28 = 37;
						}
						else
						{
							num = 147;
							num28 = 63;
						}
						num3 = num28;
						num = 58;
						continue;
					}
					case 11:
					{
						num = 75;
						int num25;
						if (num17 > uint_9)
						{
							num = 72;
							num25 = 32;
						}
						else
						{
							num = 137;
							num25 = 50;
						}
						num3 = num25;
						num = 58;
						continue;
					}
					case 8:
						num = 47;
						uint_13[num24] = 0u;
						uint_13[num13] = 0u;
						num = 169;
						num3 = 39;
						num = 58;
						goto case 39;
					case 7:
					{
						num = 138;
						int num19;
						if (num6 < 2)
						{
							num = 124;
							num19 = 57;
						}
						else
						{
							num = 10;
							num19 = 77;
						}
						num3 = num19;
						num = 58;
						continue;
					}
					case 6:
						num = 51;
						num10++;
						num3 = 10;
						num = 58;
						goto case 10;
					case 5:
						num = 152;
						num18--;
						num3 = 48;
						num = 58;
						goto case 48;
					case 4:
						num = 78;
						goto IL_0419;
					case 3:
					{
						num = 113;
						int num7;
						if (num5 < uint_22[3])
						{
							num = 22;
							num7 = 21;
						}
						else
						{
							num = 60;
							num7 = 64;
						}
						num3 = num7;
						num = 58;
						continue;
					}
					default:
						num = 107;
						goto IL_0a9f;
					case 61:
						num = 107;
						goto IL_0a9f;
					case 24:
						goto end_IL_0941;
					case 21:
						num = 93;
						uint_22[3] = num5;
						num3 = 64;
						num = 58;
						goto case 64;
					case 51:
						num = 87;
						return 0u;
					case 54:
						num = 50;
						uint_22[3] = num5;
						num6 = 3u;
						num3 = 62;
						num = 58;
						goto case 62;
					case 60:
						num = 52;
						goto IL_0b30;
					case 64:
						num = 32;
						return num6;
					case 66:
						num = 175;
						uint_22[3] = num5;
						num3 = 62;
						num = 58;
						goto case 62;
					case 62:
						num = 77;
						return num6;
					case 67:
						num = 7;
						uint_22[2] = num4;
						num = 52;
						goto IL_0b30;
					case 46:
						break;
						IL_0b30:
						uint_22[3] = num5;
						num3 = 46;
						num = 58;
						break;
						IL_0a9f:
						num3 = 24;
						num = 58;
						goto end_IL_0941;
						IL_0517:
						num9 = (uint)(num8 << 1);
						if (num10 != num11)
						{
							num = 104;
							num12 = 75;
						}
						else
						{
							num = 108;
							num12 = 14;
						}
						num3 = num12;
						num = 58;
						continue;
						IL_0489:
						if (flag2)
						{
							num = 111;
							num34 = 73;
						}
						else
						{
							num = 144;
							num34 = 62;
						}
						num3 = num34;
						num = 58;
						continue;
						IL_03f3:
						num43 = (uint)num48;
						num22 = uint_0 + uint_2;
						num41 = 0u;
						uint_23 = 0u;
						num = 171;
						num3 = 23;
						num = 58;
						goto case 23;
						IL_0419:
						uint_24 = 0u;
						if (bool_1)
						{
							num = 39;
							num51 = 33;
						}
						else
						{
							num = 136;
							num51 = 36;
						}
						num3 = num51;
						num = 58;
						continue;
					}
					num = 70;
					return num41;
					continue;
					end_IL_0941:
					break;
				}
				num = 0;
			}
		}
		catch (Exception caughtException)
		{
			StackFrameHelper.CreateExceptionN(caughtException, new object[28]
			{
				num11, num43, num22, num41, num46, uint_23, uint_24, num14, num38, num36,
				num4, num5, flag, flag2, num24, num13, num6, num15, num27, num18,
				num21, num10, num17, num9, num3, num, this, uint_22
			});
			throw;
		}
	}

	public void imethod_8()
	{
		int num = default(int);
		int num2 = default(int);
		uint num4 = default(uint);
		int num5 = default(int);
		int num7 = default(int);
		uint num23 = default(uint);
		uint num11 = default(uint);
		uint num13 = default(uint);
		uint num30 = default(uint);
		uint num14 = default(uint);
		uint uint_ = default(uint);
		uint uint_2 = default(uint);
		uint num15 = default(uint);
		uint num10 = default(uint);
		uint num9 = default(uint);
		uint num27 = default(uint);
		uint num8 = default(uint);
		uint num12 = default(uint);
		uint num18 = default(uint);
		uint num21 = default(uint);
		try
		{
			num = 11;
			num2 = 5;
			num = 6;
			while (true)
			{
				num = 10;
				while (true)
				{
					int num3;
					if (base.uint_2 + uint_12 > uint_3)
					{
						num = 2;
						num3 = 6;
					}
					else
					{
						num = 1;
						num3 = 3;
					}
					num2 = num3;
					num = 6;
					switch (num2)
					{
					default:
						num = 10;
						continue;
					case 0:
						num = 10;
						continue;
					case 5:
						break;
					case 1:
						num = 8;
						goto IL_0075;
					case 2:
						num = 8;
						goto IL_0075;
					case 3:
						num = 9;
						num4 = uint_12;
						goto IL_05e7;
					case 6:
						num = 8;
						goto IL_0075;
					case 4:
						{
							num = 3;
							return;
						}
						IL_0075:
						num4 = uint_3 - base.uint_2;
						if (num4 < uint_20)
						{
							num = 0;
							num2 = 4;
							num = 6;
							goto case 4;
						}
						goto IL_05e7;
						IL_05e7:
						while (true)
						{
							int num6;
							if (base.uint_2 > uint_11)
							{
								num5 = 84;
								num6 = 15;
							}
							else
							{
								num5 = 36;
								num6 = 9;
							}
							num7 = num6;
							num5 = 38;
							while (true)
							{
								int num19;
								int num20;
								int num17;
								int num35;
								switch (num7)
								{
								case 41:
								{
									num5 = 59;
									int num25;
									if (byte_0[num23 + num11] == byte_0[num13 + num11])
									{
										num5 = 37;
										num25 = 40;
									}
									else
									{
										num5 = 83;
										num25 = 16;
									}
									num7 = num25;
									num5 = 38;
									continue;
								}
								case 40:
									num5 = 6;
									num11++;
									num7 = 27;
									num5 = 38;
									goto case 27;
								case 27:
								{
									num5 = 13;
									int num34;
									if (num11 >= num4)
									{
										num5 = 31;
										num34 = 16;
									}
									else
									{
										num5 = 22;
										num34 = 41;
									}
									num7 = num34;
									num5 = 38;
									continue;
								}
								case 37:
								{
									num5 = 73;
									int num32;
									if (num11 < uint_12)
									{
										num5 = 24;
										num32 = 6;
									}
									else
									{
										num5 = 45;
										num32 = 33;
									}
									num7 = num32;
									num5 = 38;
									continue;
								}
								case 36:
								{
									num5 = 20;
									int num24;
									if (byte_0[num23 + num11] < byte_0[num13 + num11])
									{
										num5 = 48;
										num24 = 28;
									}
									else
									{
										num5 = 9;
										num24 = 22;
									}
									num7 = num24;
									num5 = 38;
									continue;
								}
								case 34:
								{
									num5 = 29;
									int num33;
									if (num30 == 0)
									{
										num5 = 56;
										num33 = 5;
									}
									else
									{
										num5 = 52;
										num33 = 25;
									}
									num7 = num33;
									num5 = 38;
									continue;
								}
								case 32:
									num5 = 25;
									num14 = method_11(num13, out uint_, out uint_2);
									num7 = 24;
									num5 = 38;
									goto case 24;
								case 24:
								{
									num5 = 47;
									num15 = uint_14[num14];
									int num36;
									if (bool_1)
									{
										num5 = 64;
										num36 = 12;
									}
									else
									{
										num5 = 40;
										num36 = 19;
									}
									num7 = num36;
									num5 = 38;
									continue;
								}
								case 31:
									num5 = 4;
									num30--;
									num7 = 34;
									num5 = 38;
									goto case 34;
								case 28:
									num5 = 66;
									uint_13[num10] = num15;
									num10 = num9 + 1;
									num5 = 16;
									num7 = 23;
									num5 = 38;
									goto case 23;
								case 23:
								{
									num5 = 35;
									num15 = uint_13[num10];
									int num29;
									if (num11 > num27)
									{
										num5 = 67;
										num29 = 20;
									}
									else
									{
										num5 = 54;
										num29 = 10;
									}
									num7 = num29;
									num5 = 38;
									continue;
								}
								case 26:
									num5 = 12;
									num8 = (uint_9 << 1) + 1;
									num5 = 69;
									goto IL_0253;
								case 8:
									num5 = 78;
									num27 = (num12 = uint_19);
									num30 = uint_17;
									num5 = 80;
									num7 = 34;
									num5 = 38;
									goto case 34;
								case 25:
									num5 = 65;
									num23 = uint_0 + num15;
									num11 = Exception0.smethod_6(num27, num12, 650, 716);
									num5 = 71;
									num7 = 27;
									num5 = 38;
									goto case 27;
								case 22:
									num5 = 0;
									uint_13[num8] = num15;
									num8 = num9;
									num7 = 17;
									num5 = 38;
									goto case 17;
								case 17:
									num5 = 72;
									num15 = uint_13[num8];
									num5 = 26;
									goto IL_02ef;
								case 21:
									num5 = 75;
									num19 = (int)(uint_9 - num18);
									goto IL_0319;
								case 20:
									num5 = 44;
									num27 = num11;
									num7 = 10;
									num5 = 38;
									goto case 10;
								case 10:
								{
									num5 = 19;
									int num31;
									if (num15 >= num21)
									{
										num5 = 30;
										num31 = 31;
									}
									else
									{
										num5 = 42;
										num31 = 5;
									}
									num7 = num31;
									num5 = 38;
									continue;
								}
								case 19:
								{
									num5 = 53;
									uint_14[num14] = base.uint_2;
									int num28;
									if (num15 < num21)
									{
										num5 = 55;
										num28 = 39;
									}
									else
									{
										num5 = 3;
										num28 = 26;
									}
									num7 = num28;
									num5 = 38;
									continue;
								}
								case 18:
									num5 = 39;
									uint_15[uint_] = base.uint_2;
									uint_16[uint_2] = base.uint_2;
									num5 = 58;
									num7 = 19;
									num5 = 38;
									goto case 19;
								case 16:
								{
									num5 = 8;
									num18 = base.uint_2 - num15;
									int num26;
									if (num18 > uint_9)
									{
										num5 = 70;
										num26 = 7;
									}
									else
									{
										num5 = 21;
										num26 = 21;
									}
									num7 = num26;
									num5 = 38;
									continue;
								}
								case 15:
									num5 = 82;
									num20 = (int)(base.uint_2 - uint_11);
									goto IL_0410;
								case 13:
								{
									num5 = 2;
									int num22;
									if (bool_1)
									{
										num5 = 51;
										num22 = 32;
									}
									else
									{
										num5 = 74;
										num22 = 4;
									}
									num7 = num22;
									num5 = 38;
									continue;
								}
								case 12:
									num5 = 63;
									num5 = 68;
									num7 = 18;
									num5 = 38;
									goto case 18;
								case 11:
									num5 = 26;
									goto IL_02ef;
								case 9:
									num5 = 79;
									num20 = 1;
									goto IL_0410;
								case 7:
									num5 = 49;
									num19 = (int)(uint_9 - num18 + uint_10);
									goto IL_0319;
								case 6:
									num5 = 77;
									uint_13[num8] = num15;
									num8 = num9;
									num7 = 2;
									num5 = 38;
									goto case 2;
								case 2:
								{
									num5 = 61;
									num15 = uint_13[num8];
									int num16;
									if (num11 > num12)
									{
										num5 = 76;
										num16 = 0;
									}
									else
									{
										num5 = 33;
										num16 = 10;
									}
									num7 = num16;
									num5 = 38;
									continue;
								}
								case 4:
									num5 = 57;
									num14 = method_12(num13);
									num7 = 24;
									num5 = 38;
									goto case 24;
								case 3:
									num5 = 43;
									num12 = num11;
									num7 = 10;
									num5 = 38;
									goto case 10;
								case 1:
									num5 = 69;
									goto IL_0253;
								case 0:
									num5 = 46;
									num12 = num11;
									num7 = 10;
									num5 = 38;
									goto case 10;
								case 14:
									goto end_IL_0525;
								default:
									num5 = 1;
									return;
								case 5:
									num5 = 41;
									uint_13[num8] = 0u;
									uint_13[num10] = 0u;
									return;
								case 30:
									num5 = 1;
									return;
								case 33:
									num5 = 28;
									uint_13[num8] = uint_13[num9 + 1];
									num5 = 32;
									num7 = 29;
									num5 = 38;
									goto case 29;
								case 29:
									num5 = 17;
									uint_13[num10] = uint_13[num9];
									return;
								case 35:
									num5 = 1;
									return;
								case 39:
									num5 = 5;
									uint_13[uint_9 << 1] = 0u;
									num5 = 81;
									num7 = 38;
									num5 = 38;
									break;
								case 38:
									break;
									IL_02ef:
									if (num11 > num12)
									{
										num5 = 11;
										num17 = 3;
									}
									else
									{
										num5 = 34;
										num17 = 10;
									}
									num7 = num17;
									num5 = 38;
									continue;
									IL_0410:
									num21 = (uint)num20;
									num13 = uint_0 + base.uint_2;
									uint_ = 0u;
									uint_2 = 0u;
									num5 = 50;
									num7 = 13;
									num5 = 38;
									goto case 13;
									IL_0253:
									num10 = uint_9 << 1;
									num7 = 8;
									num5 = 38;
									goto case 8;
									IL_0319:
									num9 = (uint)(num19 << 1);
									if (num11 != num4)
									{
										num5 = 62;
										num35 = 36;
									}
									else
									{
										num5 = 60;
										num35 = 37;
									}
									num7 = num35;
									num5 = 38;
									continue;
								}
								num5 = 15;
								uint_13[(uint_9 << 1) + 1] = 0u;
								return;
								continue;
								end_IL_0525:
								break;
							}
							num5 = 14;
						}
					}
					break;
				}
			}
		}
		catch (Exception caughtException)
		{
			StackFrameHelper.CreateExceptionN(caughtException, new object[21]
			{
				num4, num21, num13, num14, uint_, uint_2, num15, num8, num10, num27,
				num12, num30, num23, num11, num18, num9, num2, num7, num, num5,
				this
			});
			throw;
		}
	}

	private void method_13(uint[] uint_22, uint uint_23, uint uint_24)
	{
		int num = default(int);
		int num2 = default(int);
		uint num3 = default(uint);
		uint num5 = default(uint);
		try
		{
			num = 10;
			num2 = 3;
			num = 3;
			while (true)
			{
				num = 14;
				while (true)
				{
					num3 = 0u;
					num2 = 4;
					num = 3;
					while (true)
					{
						num = 7;
						int num4;
						if (num3 < uint_23)
						{
							num = 0;
							num4 = 6;
						}
						else
						{
							num = 16;
							num4 = 5;
						}
						num2 = num4;
						num = 3;
						while (true)
						{
							int num6;
							switch (num2)
							{
							case 8:
								num = 13;
								goto IL_0017;
							case 6:
								num = 11;
								num5 = uint_22[num3];
								num = 13;
								goto IL_0017;
							case 0:
								num = 1;
								goto IL_008e;
							case 1:
								num = 5;
								goto IL_0071;
							case 2:
								num = 5;
								goto IL_0071;
							case 9:
								num = 17;
								num5 = 0u;
								num2 = 7;
								num = 3;
								goto case 7;
							case 7:
								num = 12;
								uint_22[num3] = num5;
								num = 1;
								goto IL_008e;
							case 4:
								break;
							default:
								goto end_IL_00a1;
							case 3:
								goto end_IL_00af;
							case 5:
								{
									num = 8;
									return;
								}
								IL_0071:
								num5 -= uint_24;
								num2 = 7;
								num = 3;
								goto case 7;
								IL_008e:
								num3++;
								num2 = 4;
								num = 3;
								break;
								IL_0017:
								if (num5 <= uint_24)
								{
									num = 4;
									num6 = 9;
								}
								else
								{
									num = 15;
									num6 = 1;
								}
								num2 = num6;
								num = 3;
								continue;
							}
							break;
						}
						continue;
						end_IL_00a1:
						break;
					}
					num = 14;
					continue;
					end_IL_00af:
					break;
				}
			}
		}
		catch (Exception exception)
		{
			int num7 = default(int);
			StackFrameHelper.CreateException9(exception, num3, num5, num2, num, num7, this, uint_22, uint_23, uint_24);
			throw;
		}
	}

	private void method_14()
	{
		int num = default(int);
		int num2 = default(int);
		uint num3 = default(uint);
		uint num4 = default(uint);
		try
		{
			num = 1;
			num2 = 1;
			num = 11;
			while (true)
			{
				num = 12;
				while (true)
				{
					num3 = uint_2 - uint_11;
					num4 = num3 - 1;
					num = 13;
					num2 = 4;
					num = 11;
					while (true)
					{
						num = 9;
						method_13(uint_13, uint_10 * 2, num4);
						num = 3;
						num2 = 2;
						num = 11;
						while (true)
						{
							num = 8;
							method_13(uint_14, uint_21, num4);
							num2 = 5;
							num = 11;
							while (true)
							{
								num = 7;
								int num5;
								if (!bool_1)
								{
									num = 10;
									num5 = 6;
								}
								else
								{
									num = 15;
									num5 = 8;
								}
								num2 = num5;
								num = 11;
								switch (num2)
								{
								case 5:
									break;
								case 2:
									goto end_IL_004a;
								case 4:
									goto end_IL_0056;
								default:
									goto end_IL_0072;
								case 1:
									goto end_IL_0096;
								case 0:
									num = 2;
									return;
								case 6:
									num = 0;
									goto IL_00f7;
								case 7:
									num = 4;
									goto IL_00e5;
								case 8:
									num = 16;
									goto IL_00cb;
								case 9:
									num = 16;
									goto IL_00cb;
								case 3:
									{
										num = 4;
										goto IL_00e5;
									}
									IL_00cb:
									method_13(uint_15, uint_18, num4);
									num2 = 3;
									num = 11;
									goto case 3;
									IL_00e5:
									method_13(uint_16, 262144u, num4);
									goto IL_00f7;
									IL_00f7:
									method_9((int)num4);
									return;
								}
								continue;
								end_IL_004a:
								break;
							}
							continue;
							end_IL_0056:
							break;
						}
						continue;
						end_IL_0072:
						break;
					}
					num = 12;
					continue;
					end_IL_0096:
					break;
				}
			}
		}
		catch (Exception exception)
		{
			int num6 = default(int);
			StackFrameHelper.CreateException6(exception, num3, num4, num2, num, num6, this);
			throw;
		}
	}

	public void method_15(uint uint_22)
	{
		uint num = default(uint);
		try
		{
			num = (uint_17 = uint_22);
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException4(exception, num, num2, this, uint_22);
			throw;
		}
	}

	static GClass1()
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

	internal static GCHandle smethod_4(object object_0, GCHandleType gchandleType_0, int int_0, int int_1)
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
				case 61:
					num = 8;
					num2 = 1;
					break;
				default:
					num = 5;
					num2 = 7;
					break;
				}
				num3 = num2;
				num = 6;
				switch (num3)
				{
				default:
					num = 4;
					goto IL_0046;
				case 2:
					num = 4;
					goto IL_0046;
				case 3:
					num = 3;
					num3 = 0;
					num = 6;
					goto IL_0053;
				case 5:
					num = 4;
					goto IL_0046;
				case 6:
					num = 4;
					goto IL_0046;
				case 7:
					num = 12;
					num3 = 0;
					num = 6;
					goto IL_0053;
				case 0:
					goto IL_0053;
				case 1:
					num = 10;
					break;
				case 4:
					{
						num = 10;
						break;
					}
					IL_0046:
					num3 = 0;
					num = 6;
					goto IL_0053;
				}
				break;
				IL_0053:
				num = 2;
			}
			return Class10.Class11.smethod_6(object_0, gchandleType_0, 405, 502);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException6(exception, num3, num, object_0, gchandleType_0, int_0, int_1);
			throw;
		}
	}

	internal static IntPtr smethod_5(ref GCHandle gchandle_0, int int_0, int int_1)
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
				case 113:
					num = 10;
					num2 = 1;
					break;
				default:
					num = 11;
					num2 = 0;
					break;
				}
				num3 = num2;
				num = 12;
				switch (num3)
				{
				default:
					num = 3;
					goto IL_0041;
				case 0:
					num = 4;
					num3 = 4;
					num = 12;
					goto case 4;
				case 3:
					num = 3;
					goto IL_0041;
				case 5:
					num = 7;
					continue;
				case 6:
					num = 7;
					continue;
				case 7:
					num = 9;
					num3 = 4;
					num = 12;
					goto case 4;
				case 4:
					num = 7;
					continue;
				case 1:
					num = 1;
					break;
				case 2:
					{
						num = 1;
						break;
					}
					IL_0041:
					num3 = 4;
					num = 12;
					goto case 4;
				}
				break;
			}
			return Class10.Class11.smethod_7(ref gchandle_0, 364, 304);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num3, num, gchandle_0, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_6(ref GCHandle gchandle_0, int int_0, int int_1)
	{
		int num = default(int);
		int num2 = default(int);
		try
		{
			num = 2;
			num2 = 5;
			num = 5;
			while (true)
			{
				num = 1;
				while (true)
				{
					int num3;
					switch (int_1 ^ int_0)
					{
					case 127:
						num = 8;
						num3 = 0;
						break;
					default:
						num = 4;
						num3 = 2;
						break;
					}
					num2 = num3;
					num = 5;
					switch (num2)
					{
					default:
						num = 1;
						continue;
					case 3:
						num = 1;
						continue;
					case 2:
						num = 6;
						num2 = 5;
						num = 5;
						break;
					case 5:
						break;
					case 0:
						num = 0;
						goto IL_005e;
					case 1:
						num = 0;
						goto IL_005e;
					case 4:
						{
							num = 0;
							goto IL_005e;
						}
						IL_005e:
						Class10.smethod_11(ref gchandle_0, 610, 591);
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
			StackFrameHelper.CreateException7(exception, num2, num4, num, num5, gchandle_0, int_0, int_1);
			throw;
		}
	}

	internal static string smethod_7(string string_0, string string_1, int int_0, int int_1)
	{
		int num = default(int);
		int num3 = default(int);
		try
		{
			num = 3;
			while (true)
			{
				int num2;
				switch (int_1 ^ int_0)
				{
				case 8:
					num = 7;
					num2 = 1;
					break;
				default:
					num = 4;
					num2 = 6;
					break;
				}
				num3 = num2;
				num = 2;
				switch (num3)
				{
				default:
					num = 6;
					goto IL_0036;
				case 0:
					num = 6;
					goto IL_0036;
				case 3:
					num = 10;
					goto IL_0044;
				case 5:
					num = 10;
					goto IL_0044;
				case 6:
					num = 8;
					num3 = 4;
					num = 2;
					goto case 4;
				case 4:
					num = 3;
					continue;
				case 7:
					num = 3;
					continue;
				case 1:
					num = 0;
					break;
				case 2:
					{
						num = 0;
						break;
					}
					IL_0044:
					num3 = 4;
					num = 2;
					goto case 4;
					IL_0036:
					num3 = 4;
					num = 2;
					goto case 4;
				}
				break;
			}
			return Class7.Class8.Class9.smethod_9(string_0, string_1, 644, 688);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException6(exception, num3, num, string_0, string_1, int_0, int_1);
			throw;
		}
	}

	internal static Process[] smethod_8(int int_0, int int_1)
	{
		int num = default(int);
		int num3 = default(int);
		try
		{
			num = 9;
			while (true)
			{
				int num2;
				switch (int_1 ^ int_0)
				{
				case 106:
					num = 6;
					num2 = 7;
					break;
				default:
					num = 11;
					num2 = 6;
					break;
				}
				num3 = num2;
				num = 4;
				switch (num3)
				{
				default:
					num = 5;
					goto IL_0043;
				case 2:
					num = 0;
					goto IL_004b;
				case 3:
					num = 7;
					num3 = 0;
					num = 4;
					goto IL_004f;
				case 4:
					num = 5;
					goto IL_0043;
				case 6:
					num = 0;
					goto IL_004b;
				case 0:
					goto IL_004f;
				case 1:
					num = 3;
					break;
				case 5:
					num = 3;
					break;
				case 7:
					{
						num = 3;
						break;
					}
					IL_004b:
					num3 = 0;
					num = 4;
					goto IL_004f;
					IL_0043:
					num3 = 0;
					num = 4;
					goto IL_004f;
				}
				break;
				IL_004f:
				num = 9;
			}
			return Class10.Class11.smethod_13(296, 367);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num3, num, int_0, int_1);
			throw;
		}
	}

	internal static bool smethod_9(object object_0, object object_1, int int_0, int int_1)
	{
		int num = default(int);
		int num3 = default(int);
		try
		{
			num = 4;
			while (true)
			{
				int num2;
				switch (int_1 ^ int_0)
				{
				case 41:
					num = 1;
					num2 = 5;
					break;
				default:
					num = 7;
					num2 = 7;
					break;
				}
				num3 = num2;
				num = 11;
				switch (num3)
				{
				default:
					num = 6;
					goto IL_0044;
				case 2:
					num = 4;
					continue;
				case 3:
					num = 0;
					num3 = 0;
					num = 11;
					goto case 0;
				case 4:
					num = 6;
					goto IL_0044;
				case 7:
					num = 3;
					num3 = 0;
					num = 11;
					goto case 0;
				case 0:
					num = 4;
					continue;
				case 1:
					num = 5;
					break;
				case 5:
					num = 5;
					break;
				case 6:
					{
						num = 5;
						break;
					}
					IL_0044:
					num3 = 0;
					num = 11;
					goto case 0;
				}
				break;
			}
			return Class10.smethod_12(object_0, object_1, 24, 33);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException6(exception, num3, num, object_0, object_1, int_0, int_1);
			throw;
		}
	}

	internal static object smethod_10(ResourceManager resourceManager_0, string string_0, CultureInfo cultureInfo_0, int int_0, int int_1)
	{
		int num = default(int);
		int num3 = default(int);
		try
		{
			num = 10;
			while (true)
			{
				int num2;
				switch (int_1 ^ int_0)
				{
				case 84:
					num = 4;
					num2 = 5;
					break;
				default:
					num = 1;
					num2 = 3;
					break;
				}
				num3 = num2;
				num = 12;
				switch (num3)
				{
				default:
					num = 0;
					goto IL_0053;
				case 1:
					num = 8;
					goto IL_004a;
				case 2:
					num = 0;
					goto IL_0053;
				case 3:
					num = 9;
					num3 = 6;
					num = 12;
					goto IL_0058;
				case 4:
					num = 8;
					goto IL_004a;
				case 7:
					num = 0;
					goto IL_0053;
				case 6:
					goto IL_0058;
				case 0:
					num = 6;
					break;
				case 5:
					{
						num = 6;
						break;
					}
					IL_004a:
					num3 = 6;
					num = 12;
					goto IL_0058;
					IL_0053:
					num3 = 6;
					num = 12;
					goto IL_0058;
				}
				break;
				IL_0058:
				num = 10;
			}
			return Class7.Class8.Class9.smethod_12(resourceManager_0, string_0, cultureInfo_0, 800, 865);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException7(exception, num3, num, resourceManager_0, string_0, cultureInfo_0, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_11(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 0;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 2:
					Class10.Class11.smethod_12(array_0, runtimeFieldHandle_0, 103, 19);
					return;
				}
				num = 0;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, num, num2, array_0, runtimeFieldHandle_0, int_0, int_1);
			throw;
		}
	}
}
