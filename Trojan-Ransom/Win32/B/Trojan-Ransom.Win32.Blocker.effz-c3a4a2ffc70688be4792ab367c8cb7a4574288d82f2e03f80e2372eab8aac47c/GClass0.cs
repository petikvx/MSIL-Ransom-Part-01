using System;
using System.Configuration;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.SmartExceptionsCore;
using ns0;

public class GClass0
{
	[StructLayout(LayoutKind.Auto)]
	internal struct Struct0
	{
		internal uint uint_0;
	}

	[StructLayout(LayoutKind.Auto)]
	internal struct Struct1
	{
		internal Stream stream_0;

		internal uint uint_0;

		internal bool bool_0;

		internal uint uint_1;

		internal uint uint_2;

		internal uint uint_3;

		internal uint uint_4;
	}

	public byte[] byte_0;

	public uint uint_0;

	public uint uint_1;

	public uint uint_2;

	public uint uint_3;

	internal Stream stream_0;

	internal uint uint_4;

	internal bool bool_0;

	internal uint uint_5;

	internal uint uint_6;

	internal uint uint_7;

	internal uint uint_8;

	public GClass0()
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

	public virtual void vmethod_0()
	{
	}

	public virtual void vmethod_1()
	{
	}

	public void method_0()
	{
		int num = default(int);
		int num2 = default(int);
		uint num3 = default(uint);
		uint num4 = default(uint);
		uint num5 = default(uint);
		try
		{
			num = 11;
			num2 = 8;
			num = 14;
			while (true)
			{
				num = 9;
				while (true)
				{
					vmethod_0();
					num3 = uint_0 + uint_2 - uint_6;
					num = 10;
					num2 = 2;
					num = 14;
					while (true)
					{
						num = 5;
						while (true)
						{
							num4 = uint_0 + uint_3 - num3;
							num5 = 0u;
							num = 16;
							num2 = 6;
							num = 14;
							while (true)
							{
								num = 3;
								int num6;
								if (num5 < num4)
								{
									num = 12;
									num6 = 3;
								}
								else
								{
									num = 6;
									num6 = 0;
								}
								num2 = num6;
								num = 14;
								switch (num2)
								{
								case 1:
									num = 15;
									goto IL_0068;
								case 3:
									num = 2;
									byte_0[num5] = byte_0[num3 + num5];
									num = 4;
									num2 = 4;
									num = 14;
									goto case 4;
								case 4:
									num = 15;
									goto IL_0068;
								case 6:
									break;
								case 7:
									goto end_IL_007a;
								case 2:
									goto end_IL_0085;
								default:
									goto end_IL_00a2;
								case 8:
									goto end_IL_00a9;
								case 0:
									num = 0;
									uint_0 -= num3;
									vmethod_1();
									return;
								case 5:
									{
										num = 13;
										return;
									}
									IL_0068:
									num5++;
									num2 = 6;
									num = 14;
									break;
								}
								continue;
								end_IL_007a:
								break;
							}
							num = 5;
							continue;
							end_IL_0085:
							break;
						}
						continue;
						end_IL_00a2:
						break;
					}
					num = 9;
					continue;
					end_IL_00a9:
					break;
				}
			}
		}
		catch (Exception exception)
		{
			int num7 = default(int);
			StackFrameHelper.CreateException7(exception, num3, num4, num5, num2, num, num7, this);
			throw;
		}
	}

	public virtual void vmethod_2()
	{
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		int num5 = default(int);
		uint num10 = default(uint);
		int num11 = default(int);
		uint num9 = default(uint);
		uint num8 = default(uint);
		uint num7 = default(uint);
		bool flag = default(bool);
		try
		{
			num = 3;
			num2 = 1;
			num = 1;
			if (bool_0)
			{
				num = 0;
				num2 = 0;
				num = 1;
				return;
			}
			while (true)
			{
				num3 = (int)(0 - uint_0 + uint_1 - uint_3);
				num4 = 12;
				num5 = 7;
				num4 = 19;
				while (true)
				{
					num4 = 22;
					int num6;
					if (num3 != 0)
					{
						num4 = 14;
						num6 = 0;
					}
					else
					{
						num4 = 3;
						num6 = 5;
					}
					num5 = num6;
					num4 = 19;
					while (true)
					{
						int num13;
						switch (num5)
						{
						case 14:
						{
							num4 = 6;
							int num14;
							if (num10 > uint_5)
							{
								num4 = 13;
								num14 = 11;
							}
							else
							{
								num4 = 1;
								num14 = 10;
							}
							num5 = num14;
							num4 = 19;
							continue;
						}
						case 13:
							num4 = 0;
							goto IL_0052;
						case 12:
							num4 = 0;
							goto IL_0052;
						case 6:
							num4 = 29;
							goto IL_0074;
						case 4:
						{
							num4 = 9;
							uint_3 += (uint)num11;
							int num12;
							if (uint_3 >= uint_2 + uint_7)
							{
								num4 = 10;
								num12 = 2;
							}
							else
							{
								num4 = 24;
								num12 = 9;
							}
							num5 = num12;
							num4 = 19;
							continue;
						}
						case 1:
							num4 = 17;
							num9 = (uint_4 = uint_3);
							num10 = uint_0 + uint_4;
							num4 = 15;
							num5 = 14;
							num4 = 19;
							goto case 14;
						case 0:
							num4 = 29;
							goto IL_0074;
						case 7:
							break;
						case 2:
							num4 = 27;
							num8 = (uint_4 = uint_3 - uint_7);
							num4 = 30;
							num5 = 9;
							num4 = 19;
							goto case 9;
						case 8:
							num4 = 5;
							goto end_IL_0170;
						case 9:
							num4 = 5;
							goto end_IL_0170;
						default:
							num4 = 2;
							return;
						case 3:
							num4 = 2;
							return;
						case 5:
							num4 = 8;
							return;
						case 11:
							num4 = 4;
							num7 = (uint_4 = uint_5 - uint_0);
							num4 = 11;
							num5 = 10;
							num4 = 19;
							goto case 10;
						case 10:
							{
								num4 = 7;
								flag = true;
								bool_0 = true;
								return;
							}
							IL_0052:
							if (num11 == 0)
							{
								num4 = 16;
								num13 = 1;
							}
							else
							{
								num4 = 18;
								num13 = 4;
							}
							num5 = num13;
							num4 = 19;
							continue;
							IL_0074:
							num11 = Exception0.smethod_0(stream_0, byte_0, (int)(uint_0 + uint_3), num3, 556, 618);
							num4 = 28;
							num5 = 12;
							num4 = 19;
							goto case 12;
						}
						break;
					}
					continue;
					end_IL_0170:
					break;
				}
			}
		}
		catch (Exception caughtException)
		{
			StackFrameHelper.CreateExceptionN(caughtException, new object[12]
			{
				num3, num11, num10, num9, num7, flag, num8, num2, num5, num,
				num4, this
			});
			throw;
		}
	}

	private void method_1()
	{
		try
		{
			byte_0 = null;
		}
		catch (Exception exception)
		{
			int num = default(int);
			StackFrameHelper.CreateException2(exception, num, this);
			throw;
		}
	}

	public void method_2(uint uint_9, uint uint_10, uint uint_11)
	{
		int num = default(int);
		int num2 = default(int);
		uint num3 = default(uint);
		uint num4 = default(uint);
		uint num5 = default(uint);
		uint num6 = default(uint);
		uint num8 = default(uint);
		try
		{
			num = 5;
			num2 = 1;
			num = 1;
			while (true)
			{
				num = 8;
				while (true)
				{
					num3 = (uint_6 = uint_9);
					num4 = (uint_7 = uint_10);
					num = 4;
					num2 = 3;
					num = 1;
					while (true)
					{
						num = 12;
						num5 = (uint_8 = uint_11);
						num = 6;
						while (true)
						{
							num6 = uint_9 + uint_10 + uint_11;
							num2 = 0;
							num = 1;
							while (true)
							{
								num = 7;
								int num7;
								if (byte_0 == null)
								{
									num = 11;
									num7 = 7;
								}
								else
								{
									num = 14;
									num7 = 5;
								}
								num2 = num7;
								num = 1;
								while (true)
								{
									switch (num2)
									{
									case 5:
									{
										num = 10;
										int num9;
										if (uint_1 != num6)
										{
											num = 17;
											num9 = 7;
										}
										else
										{
											num = 13;
											num9 = 2;
										}
										num2 = num9;
										num = 1;
										continue;
									}
									case 0:
										break;
									case 8:
										goto end_IL_005f;
									case 3:
										goto end_IL_006d;
									default:
										goto end_IL_0079;
									case 4:
										goto IL_008f;
									case 1:
										goto end_IL_0091;
									case 6:
										num = 15;
										goto IL_00b9;
									case 7:
										num = 15;
										goto IL_00b9;
									case 2:
										{
											num = 3;
											num8 = (uint_5 = uint_1 - uint_10);
											return;
										}
										IL_00b9:
										method_1();
										uint_1 = num6;
										byte_0 = new byte[uint_1];
										num = 9;
										num2 = 2;
										num = 1;
										goto case 2;
									}
									break;
								}
								continue;
								end_IL_005f:
								break;
							}
							num = 6;
							continue;
							end_IL_006d:
							break;
						}
						continue;
						end_IL_0079:
						break;
					}
					num = 8;
					continue;
					IL_008f:
					num = 8;
					continue;
					end_IL_0091:
					break;
				}
			}
		}
		catch (Exception caughtException)
		{
			int num10 = default(int);
			StackFrameHelper.CreateExceptionN(caughtException, new object[12]
			{
				num6, num3, num4, num5, num8, num2, num, num10, this, uint_9,
				uint_10, uint_11
			});
			throw;
		}
	}

	public void method_3(Stream stream_1)
	{
		int num = default(int);
		int num2 = default(int);
		Stream o = default(Stream);
		bool flag = default(bool);
		try
		{
			num = 0;
			num2 = 0;
			num = 8;
			o = (stream_0 = stream_1);
			uint_0 = 0u;
			num2 = 1;
			num = 8;
			uint_2 = 0u;
			uint_3 = 0u;
			num = 2;
			flag = false;
			bool_0 = false;
			num2 = 3;
			num = 8;
			vmethod_2();
		}
		catch (Exception exception)
		{
			int num3 = default(int);
			StackFrameHelper.CreateException7(exception, o, flag, num2, num, num3, this, stream_1);
			throw;
		}
	}

	public void method_4()
	{
		Stream o = default(Stream);
		try
		{
			o = (stream_0 = null);
		}
		catch (Exception exception)
		{
			int num = default(int);
			StackFrameHelper.CreateException3(exception, o, num, this);
			throw;
		}
	}

	public void method_5()
	{
		int num = default(int);
		int num2 = default(int);
		uint num4 = default(uint);
		try
		{
			num = 9;
			num2 = 6;
			num = 4;
			while (true)
			{
				num = 0;
				while (true)
				{
					uint_2++;
					num = 14;
					while (true)
					{
						int num3;
						if (uint_2 <= uint_4)
						{
							num = 3;
							num3 = 3;
						}
						else
						{
							num = 10;
							num3 = 2;
						}
						num2 = num3;
						num = 4;
						while (true)
						{
							int num5;
							switch (num2)
							{
							case 2:
								num = 12;
								num4 = uint_0 + uint_2;
								if (num4 > uint_5)
								{
									num = 1;
									num5 = 1;
								}
								else
								{
									num = 6;
									num5 = 4;
								}
								goto IL_0036;
							case 5:
								goto end_IL_0039;
							default:
								goto end_IL_006c;
							case 6:
								break;
							case 0:
								num = 2;
								return;
							case 1:
								num = 8;
								method_0();
								goto IL_00aa;
							case 3:
								num = 2;
								return;
							case 4:
								num = 13;
								goto IL_00aa;
							case 7:
								{
									num = 2;
									return;
								}
								IL_00aa:
								vmethod_2();
								return;
							}
							goto end_IL_007e;
							IL_0036:
							num2 = num5;
							num = 4;
							continue;
							end_IL_0039:
							break;
						}
						num = 14;
						continue;
						end_IL_006c:
						break;
					}
					num = 0;
					continue;
					end_IL_007e:
					break;
				}
			}
		}
		catch (Exception exception)
		{
			int num6 = default(int);
			StackFrameHelper.CreateException5(exception, num4, num2, num, num6, this);
			throw;
		}
	}

	public byte method_6(int int_0)
	{
		int num = default(int);
		try
		{
			num = 7;
			return byte_0[uint_0 + uint_2 + int_0];
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException4(exception, num2, num, this, int_0);
			throw;
		}
	}

	public uint method_7(int int_0, uint uint_9, uint uint_10)
	{
		int num = default(int);
		int num3 = default(int);
		uint num4 = default(uint);
		uint num6 = default(uint);
		try
		{
			num = 25;
			while (true)
			{
				int num2;
				if (!bool_0)
				{
					num = 6;
					num2 = 6;
				}
				else
				{
					num = 2;
					num2 = 0;
				}
				num3 = num2;
				num = 20;
				while (true)
				{
					switch (num3)
					{
					case 12:
						num = 16;
						goto IL_0017;
					case 11:
						num = 10;
						num4 = 0u;
						num3 = 2;
						num = 20;
						goto case 2;
					case 2:
					{
						num = 13;
						int num8;
						if (num4 < uint_10)
						{
							num = 12;
							num8 = 1;
						}
						else
						{
							num = 19;
							num8 = 10;
						}
						num3 = num8;
						num = 20;
						continue;
					}
					case 9:
						num = 16;
						goto IL_0017;
					case 8:
						num = 1;
						num4++;
						num3 = 2;
						num = 20;
						goto case 2;
					case 6:
						num = 16;
						goto IL_0017;
					case 5:
						num = 4;
						uint_10 = uint_3 - (uint)(int)(uint_2 + int_0);
						num = 21;
						num3 = 6;
						num = 20;
						goto case 6;
					case 3:
						num = 16;
						goto IL_0017;
					case 1:
					{
						num = 3;
						int num7;
						if (byte_0[num6 + num4] != byte_0[num6 + num4 - uint_9])
						{
							num = 14;
							num7 = 10;
						}
						else
						{
							num = 15;
							num7 = 8;
						}
						num3 = num7;
						num = 20;
						continue;
					}
					case 0:
					{
						num = 11;
						int num5;
						if (uint_2 + int_0 + uint_10 > uint_3)
						{
							num = 17;
							num5 = 5;
						}
						else
						{
							num = 18;
							num5 = 6;
						}
						num3 = num5;
						num = 20;
						continue;
					}
					default:
						num = 7;
						goto IL_0131;
					case 4:
						num = 7;
						goto IL_0131;
					case 7:
						break;
					case 10:
						{
							num = 0;
							return num4;
						}
						IL_0131:
						num3 = 7;
						num = 20;
						break;
						IL_0017:
						uint_9++;
						num6 = uint_0 + uint_2 + (uint)int_0;
						num = 23;
						num3 = 11;
						num = 20;
						goto case 11;
					}
					break;
				}
				num = 25;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException8(exception, num6, num4, num3, num, this, int_0, uint_9, uint_10);
			throw;
		}
	}

	public uint method_8()
	{
		int num = default(int);
		try
		{
			num = 3;
			return uint_3 - uint_2;
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException3(exception, num2, num, this);
			throw;
		}
	}

	public void method_9(int int_0)
	{
		int num = default(int);
		int num2 = default(int);
		uint num3 = default(uint);
		try
		{
			num = 5;
			num2 = 1;
			num = 8;
			uint_0 += (uint)int_0;
			num = 2;
			num3 = (uint_4 -= (uint)int_0);
			num = 7;
			num2 = 2;
			num = 8;
			uint_2 -= (uint)int_0;
			uint_3 -= (uint)int_0;
			num = 0;
		}
		catch (Exception exception)
		{
			int num4 = default(int);
			StackFrameHelper.CreateException6(exception, num3, num2, num, num4, this, int_0);
			throw;
		}
	}

	static GClass0()
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

	internal static SettingsBase smethod_0(SettingsBase settingsBase_0, int int_0, int int_1)
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
				case 125:
					num = 12;
					num2 = 1;
					break;
				default:
					num = 8;
					num2 = 0;
					break;
				}
				num3 = num2;
				num = 5;
				switch (num3)
				{
				default:
					num = 4;
					goto IL_003c;
				case 0:
					num = 9;
					goto IL_004d;
				case 2:
					num = 4;
					goto IL_003c;
				case 3:
					num = 1;
					num3 = 6;
					num = 5;
					goto IL_0051;
				case 4:
					num = 9;
					goto IL_004d;
				case 6:
					goto IL_0051;
				case 1:
					num = 6;
					break;
				case 5:
					num = 6;
					break;
				case 7:
					{
						num = 6;
						break;
					}
					IL_004d:
					num3 = 6;
					num = 5;
					goto IL_0051;
					IL_003c:
					num3 = 6;
					num = 5;
					goto IL_0051;
				}
				break;
				IL_0051:
				num = 2;
			}
			return Class7.smethod_6(settingsBase_0, 133, 174);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num3, num, settingsBase_0, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_1(int int_0, int int_1, int int_2)
	{
		int num = default(int);
		int num2 = default(int);
		try
		{
			num = 9;
			num2 = 3;
			num = 7;
			while (true)
			{
				num = 1;
				while (true)
				{
					int num3;
					switch (int_2 ^ int_1)
					{
					case 59:
						num = 4;
						num3 = 4;
						break;
					default:
						num = 5;
						num3 = 0;
						break;
					}
					num2 = num3;
					num = 7;
					switch (num2)
					{
					default:
						num = 1;
						continue;
					case 5:
						num = 1;
						continue;
					case 0:
						num = 3;
						goto IL_0051;
					case 1:
						num = 3;
						goto IL_0051;
					case 3:
						break;
					case 2:
						num = 6;
						goto IL_005f;
					case 4:
						{
							num = 6;
							goto IL_005f;
						}
						IL_005f:
						Class10.Class11.smethod_9(int_0, 81, 5);
						return;
						IL_0051:
						num2 = 3;
						num = 7;
						break;
					}
					break;
				}
			}
		}
		catch (Exception exception)
		{
			int num4 = default(int);
			int num5 = default(int);
			StackFrameHelper.CreateException7(exception, num2, num4, num, num5, int_0, int_1, int_2);
			throw;
		}
	}

	internal static int smethod_2(Stream stream_1, byte[] byte_1, int int_0, int int_1, int int_2, int int_3)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 49:
					return Class7.Class8.smethod_1(stream_1, byte_1, int_0, int_1, 930, 946);
				}
				num = 5;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException7(exception, num, stream_1, byte_1, int_0, int_1, int_2, int_3);
			throw;
		}
	}

	internal static string[] smethod_3(Assembly assembly_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 1:
					return Class7.Class8.smethod_10(assembly_0, 558, 563);
				}
				num = 6;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, assembly_0, int_0, int_1);
			throw;
		}
	}
}
