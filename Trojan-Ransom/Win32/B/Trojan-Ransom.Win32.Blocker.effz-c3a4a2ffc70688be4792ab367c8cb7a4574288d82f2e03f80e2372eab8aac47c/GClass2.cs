using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.SmartExceptionsCore;
using ns0;

public sealed class GClass2
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1320)]
	private struct Struct5
	{
	}

	[StructLayout(LayoutKind.Auto)]
	internal struct Struct6
	{
		internal GClass2 gclass2_0;

		internal Class5 class5_0;

		internal Struct15[] struct15_0;

		internal Struct15[] struct15_1;

		internal Struct15[] struct15_2;

		internal Struct15[] struct15_3;

		internal Struct15[] struct15_4;

		internal Struct15[] struct15_5;

		internal Struct16[] struct16_0;

		internal Struct15[] struct15_6;

		internal Struct16 struct16_1;

		internal uint uint_0;

		internal uint uint_1;

		internal uint uint_2;
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 16)]
	private struct Struct7
	{
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static Struct5 struct5_0/* Not supported: data(00 00 11 00 00 00 4F 1D 38 15 87 26 88 08 55 3A 20 3E 49 03 3D 2D 56 1D 37 15 83 26 88 08 54 3A 2C 3E 59 03 78 2D 74 1D 01 00 0A 00 00 00 12 15 90 26 9D 08 58 3A 69 3E 68 03 6F 2D 74 1D 39 15 83 26 02 00 04 00 00 00 DF 26 8D 08 55 3A 25 3E 03 00 01 00 00 00 C7 08 04 00 03 00 00 00 62 3A 67 3E 70 03 05 00 01 00 00 00 63 3E 06 00 02 00 00 00 03 03 37 2D 07 00 1B 01 00 00 49 2D 6E 1D 3F 15 82 26 C9 08 58 3A 39 3E 5D 03 71 2D 6F 1D 35 15 90 26 9D 08 50 3A 26 3E 43 03 3D 2D 6F 1D 25 15 D1 26 8A 08 56 3A 24 3E 5D 03 6F 2D 63 1D 25 15 82 26 8C 08 5D 3A 69 3E 5A 03 74 2D 72 1D 3E 15 D1 26 C7 08 57 3A 2C 3E 59 03 6E 2D 6E 1D 24 15 98 26 87 08 52 3A 69 3E 4C 03 73 2D 62 1D 76 15 99 26 88 08 4A 3A 69 3E 48 03 65 2D 76 1D 3F 15 83 26 8C 08 5D 3A 69 3E 05 03 74 2D 72 1D 76 15 86 26 88 08 4A 3A 69 3E 4E 03 72 2D 6B 1D 26 15 83 26 8C 08 4A 3A 3A 3E 48 03 79 2D 26 1D 21 15 98 26 9D 08 51 3A 69 3E 4C 03 3D 2D 62 1D 33 15 9C 26 86 08 19 3A 3F 3E 48 03 6F 2D 75 1D 3F 15 9E 26 87 08 19 3A 26 3E 4B 03 3D 2D 28 1D 38 15 94 26 9D 08 4A 3A 21 3E 5F 03 74 2D 68 1D 3D 15 D8 26 C7 08 33 3A 43 3E 6C 03 6D 2D 76 1D 3A 15 98 26 8A 08 58 3A 3D 3E 44 03 72 2D 68 1D 76 15 97 26 80 08 55 3A 2C 3E 0D 03 74 2D 75 1D 76 15 9D 26 86 08 5A 3A 28 3E 59 03 78 2D 62 1D 76 15 90 26 9D 08 03 3A 43 3E 27 03 66 2D 36 1D 2B 15 FB 26 E3 08 17 3A 27 3E 48 03 69 2D 75 1D 3E 15 83 26 80 08 57 3A 22 3E 0D 03 74 2D 75 1D 76 15 90 26 C9 08 5F 3A 20 3E 41 03 78 2D 26 1D 35 15 9E 26 84 08 49 3A 3B 3E 48 03 6E 2D 75 1D 39 15 83 26 C9 08 58 3A 27 3E 49 03 3D 2D 76 1D 37 15 82 26 9A 08 4E 3A 26 3E 5F 03 79 2D 26 1D 26 15 83 26 86 08 4D 3A 2C 3E 4E 03 69 2D 69 1D 24 15 D1 26 8F 08 56 3A 3B 3E 0D 03 33 2D 48 1D 13 15 A5 26 C9 08 58 3A 39 3E 5D 03 71 2D 6F 1D 35 15 90 26 9D 08 50 3A 26 3E 43 03 6E 2D 0C 1D 5C 15 A7 26 80 08 4A 3A 20 3E 59 03 3D 2D 73 1D 25 15 D1 26 88 08 4D 3A 69 3E 5A 03 6A 2D 71 1D 78 15 81 26 8C 08 55 3A 26 3E 4E 03 76 2D 28 1D 35 15 9E 26 84 08 19 3A 2F 3E 42 03 6F 2D 26 1D 3B 15 9E 26 9B 08 5C 3A 69 3E 44 03 73 2D 60 1D 39 15 83 26 84 08 58 3A 3D 3E 44 03 72 2D 68 1D 78 15 08 00 17 00 00 00 47 1D 26 15 81 26 85 08 50 3A 2A 3E 4C 03 69 2D 6F 1D 39 15 9F 26 C9 08 51 3A 28 3E 5E 03 3D 2D 63 1D 2E 15 81 26 80 08 4B 3A 2C 3E 49 03 09 00 FF 00 00 00 02 15 99 26 80 08 4A 3A 69 3E 4C 03 6D 2D 76 1D 3A 15 98 26 8A 08 58 3A 3D 3E 44 03 72 2D 68 1D 76 15 98 26 9A 08 19 3A 2A 3E 42 03 70 2D 76 1D 24 15 94 26 9A 08 4A 3A 2C 3E 49 03 3D 2D 71 1D 3F 15 85 26 81 08 19 3A 67 3E 43 03 78 2D 72 1D 25 15 99 26 9B 08 50 3A 27 3E 46 03 3D 2D 2E 1D 32 15 94 26 84 08 56 3A 69 3E 5B 03 78 2D 74 1D 25 15 98 26 86 08 57 3A 60 3E 0D 03 7C 2D 68 1D 32 15 D1 26 80 08 4D 3A 69 3E 5A 03 72 2D 68 1D 71 15 85 26 C9 08 4B 3A 3C 3E 43 03 3D 2D 67 1D 30 15 85 26 8C 08 4B 3A 69 3E 56 03 2D 2D 7B 1D 78 15 FB 26 E3 08 78 3A 39 3E 5D 03 71 2D 6F 1D 35 15 90 26 9D 08 50 3A 26 3E 43 03 3D 2D 60 1D 3F 15 9D 26 8C 08 19 3A 20 3E 5E 03 3D 2D 6A 1D 39 15 92 26 88 08 4D 3A 2C 3E 49 03 3D 2D 67 1D 22 15 CB 26 E3 08 33 3A 32 3E 1C 03 60 2D 0C 1D 5C 15 DF 26 87 08 5C 3A 3D 3E 5E 03 75 2D 74 1D 3F 15 9F 26 82 08 19 3A 20 3E 5E 03 3D 2D 67 1D 76 15 97 26 80 08 55 3A 2C 3E 0D 03 7E 2D 69 1D 3B 15 81 26 9B 08 5C 3A 3A 3E 5E 03 72 2D 74 1D 76 15 90 26 87 08 5D 3A 69 3E 5D 03 7C 2D 75 1D 25 15 86 26 86 08 4B 3A 2D 3E 0D 03 6D 2D 74 1D 39 15 85 26 8C 08 5A 3A 3D 3E 42 03 6F 2D 26 1D 30 15 9E 26 9B 08 19 3A 67 3E 63 03 58 2D 52 1D 76 15 90 26 99 08 49 3A 25 3E 44 03 7E 2D 67 1D 22 15 98 26 86 08 57 3A 3A 3E 27 03 17 2D 50 1D 3F 15 82 26 80 08 4D 3A 69 3E 58 03 6E 2D 26 1D 37 15 85 26 C9 08 4E 3A 3E 3E 5A 03 33 2D 76 1D 33 15 9D 26 86 08 5A 3A 22 3E 03 03 7E 2D 69 1D 3B 15 D1 26 8F 08 56 3A 3B 3E 0D 03 70 2D 69 1D 24 15 94 26 C9 08 50 3A 27 3E 4B 03 72 2D 74 1D 3B 15 90 26 9D 08 50 3A 26 3E 43 03 33 2D 0A 00 0B 00 00 00 B8 26 87 08 5F 3A 26 3E 5F 03 70 2D 67 1D 22 15 98 26 86 08 57 3A 0B 00 0A 00 00 00 90 08 40 3A 30 3E 54 03 30 2D 4B 1D 1B 15 DC 26 8D 08 5D 3A 0C 00 01 00 00 00 5F 3A) */;

	private static readonly char[] char_2;

	private static readonly char[] char_3;

	private static readonly string[] string_1;

	internal static Struct7 struct7_0/* Not supported: data(00 00 05 00 00 00 76 39 82 05 F7 35 DF 2C 2E 23) */;

	internal byte[] byte_0;

	internal uint uint_0;

	internal uint uint_1;

	internal uint uint_2;

	internal Stream stream_0;

	public GClass2()
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

	public void method_0(uint uint_3)
	{
		int num = default(int);
		int num2 = default(int);
		byte[] o = default(byte[]);
		uint num4 = default(uint);
		uint num5 = default(uint);
		uint num6 = default(uint);
		try
		{
			num = 7;
			num2 = 5;
			num = 0;
			while (true)
			{
				num = 4;
				while (true)
				{
					int num3;
					if (uint_1 == uint_3)
					{
						num = 9;
						num3 = 6;
					}
					else
					{
						num = 5;
						num3 = 1;
					}
					num2 = num3;
					num = 0;
					switch (num2)
					{
					default:
						num = 4;
						continue;
					case 0:
						num = 4;
						continue;
					case 4:
						num = 4;
						continue;
					case 5:
						break;
					case 1:
						num = 3;
						o = (byte_0 = new byte[uint_3]);
						num2 = 6;
						num = 0;
						goto case 6;
					case 3:
						num = 1;
						return;
					case 6:
						num = 2;
						num4 = (uint_1 = uint_3);
						num5 = 0u;
						uint_0 = 0u;
						num = 6;
						num2 = 2;
						num = 0;
						goto case 2;
					case 2:
						num = 12;
						num6 = 0u;
						uint_2 = 0u;
						num = 1;
						return;
					}
					break;
				}
			}
		}
		catch (Exception exception)
		{
			int num7 = default(int);
			StackFrameHelper.CreateException9(exception, o, num4, num5, num6, num2, num, num7, this, uint_3);
			throw;
		}
	}

	public void method_1(Stream stream_1, bool bool_0)
	{
		int num = default(int);
		int num2 = default(int);
		Stream o = default(Stream);
		uint num4 = default(uint);
		uint num5 = default(uint);
		try
		{
			num = 6;
			num2 = 2;
			num = 1;
			while (true)
			{
				num = 5;
				while (true)
				{
					method_3();
					o = (stream_0 = stream_1);
					int num3;
					if (bool_0)
					{
						num = 9;
						num3 = 4;
					}
					else
					{
						num = 0;
						num3 = 1;
					}
					num2 = num3;
					num = 1;
					switch (num2)
					{
					default:
						num = 5;
						continue;
					case 0:
						num = 5;
						continue;
					case 5:
						num = 5;
						continue;
					case 2:
						break;
					case 1:
						num = 8;
						num4 = 0u;
						uint_2 = 0u;
						num = 10;
						goto IL_006a;
					case 3:
						num = 10;
						goto IL_006a;
					case 4:
						{
							num = 4;
							return;
						}
						IL_006a:
						num5 = 0u;
						uint_0 = 0u;
						num2 = 4;
						num = 1;
						goto case 4;
					}
					break;
				}
			}
		}
		catch (Exception exception)
		{
			int num6 = default(int);
			StackFrameHelper.CreateException9(exception, o, num4, num5, num2, num, num6, this, stream_1, bool_0);
			throw;
		}
	}

	public void method_2(Stream stream_1)
	{
		try
		{
			method_1(stream_1, bool_0: false);
		}
		catch (Exception exception)
		{
			int num = default(int);
			StackFrameHelper.CreateException3(exception, num, this, stream_1);
			throw;
		}
	}

	public void method_3()
	{
		Stream o = default(Stream);
		try
		{
			method_4();
			o = (stream_0 = null);
		}
		catch (Exception exception)
		{
			int num = default(int);
			StackFrameHelper.CreateException3(exception, o, num, this);
			throw;
		}
	}

	public void method_4()
	{
		int num = default(int);
		int num2 = default(int);
		uint num3 = default(uint);
		int num4 = default(int);
		int num5 = default(int);
		uint num8 = default(uint);
		uint num7 = default(uint);
		try
		{
			num = 7;
			num2 = 0;
			num = 2;
			num3 = uint_0 - uint_2;
			num = 9;
			num2 = 5;
			num = 2;
			if (num3 == 0)
			{
				num = 0;
				num2 = 1;
				num = 2;
				return;
			}
			while (true)
			{
				Class1.smethod_4(stream_0, byte_0, (int)uint_2, (int)num3, 68, 0);
				while (true)
				{
					num4 = 3;
					num5 = 12;
					while (true)
					{
						num5 = 2;
						int num6;
						if (uint_0 < uint_1)
						{
							num5 = 0;
							num6 = 7;
						}
						else
						{
							num5 = 1;
							num6 = 2;
						}
						num4 = num6;
						num5 = 12;
						switch (num4)
						{
						case 3:
							continue;
						case 4:
							num5 = 13;
							break;
						case 6:
							num5 = 13;
							break;
						case 5:
							goto end_IL_007f;
						default:
							num5 = 4;
							return;
						case 0:
							num5 = 6;
							goto IL_00ba;
						case 1:
							num5 = 4;
							return;
						case 2:
							num5 = 6;
							goto IL_00ba;
						case 7:
							{
								num5 = 7;
								num8 = (uint_2 = uint_0);
								return;
							}
							IL_00ba:
							num7 = 0u;
							uint_0 = 0u;
							num4 = 7;
							num5 = 12;
							goto case 7;
						}
						break;
					}
					continue;
					end_IL_007f:
					break;
				}
				num5 = 5;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException8(exception, num3, num7, num8, num2, num4, num, num5, this);
			throw;
		}
	}

	public void method_5(uint uint_3, uint uint_4)
	{
		int num = default(int);
		int num2 = default(int);
		uint num3 = default(uint);
		uint num8 = default(uint);
		uint num7 = default(uint);
		try
		{
			num = 7;
			num2 = 8;
			num = 1;
			while (true)
			{
				num = 11;
				while (true)
				{
					num3 = uint_0 - uint_3 - 1;
					num = 8;
					while (true)
					{
						int num4;
						if (num3 < uint_1)
						{
							num = 5;
							num4 = 5;
						}
						else
						{
							num = 4;
							num4 = 10;
						}
						num2 = num4;
						num = 1;
						while (true)
						{
							switch (num2)
							{
							case 12:
								num = 9;
								goto IL_0019;
							case 5:
							{
								num = 17;
								int num6;
								if (uint_4 == 0)
								{
									num = 15;
									num6 = 0;
								}
								else
								{
									num = 18;
									num6 = 3;
								}
								num2 = num6;
								num = 1;
								continue;
							}
							case 11:
								num = 3;
								num3 = 0u;
								num2 = 2;
								num = 1;
								goto case 2;
							case 2:
							{
								num = 24;
								byte[] array = byte_0;
								num8 = (uint_0 = (num7 = uint_0) + 1);
								array[num7] = byte_0[num3++];
								num = 10;
								num2 = 6;
								num = 1;
								goto case 6;
							}
							case 6:
							{
								num = 23;
								int num9;
								if (uint_0 >= uint_1)
								{
									num = 19;
									num9 = 1;
								}
								else
								{
									num = 22;
									num9 = 7;
								}
								num2 = num9;
								num = 1;
								continue;
							}
							case 10:
								num = 16;
								num3 += uint_1;
								num2 = 5;
								num = 1;
								goto case 5;
							case 7:
								num = 6;
								goto IL_001f;
							case 3:
							{
								num = 2;
								int num5;
								if (num3 >= uint_1)
								{
									num = 20;
									num5 = 11;
								}
								else
								{
									num = 12;
									num5 = 2;
								}
								num2 = num5;
								num = 1;
								continue;
							}
							case 1:
								num = 9;
								goto IL_0019;
							case 9:
								break;
							default:
								goto end_IL_0127;
							case 4:
								goto IL_013a;
							case 8:
								goto end_IL_013d;
							case 0:
								{
									num = 14;
									return;
								}
								IL_0019:
								method_4();
								goto IL_001f;
								IL_001f:
								uint_4--;
								num2 = 5;
								num = 1;
								goto case 5;
							}
							break;
						}
						num = 8;
						continue;
						end_IL_0127:
						break;
					}
					num = 11;
					continue;
					IL_013a:
					num = 11;
					continue;
					end_IL_013d:
					break;
				}
			}
		}
		catch (Exception exception)
		{
			int num10 = default(int);
			StackFrameHelper.CreateException9(exception, num3, num7, num8, num2, num, num10, this, uint_3, uint_4);
			throw;
		}
	}

	public void method_6(byte byte_1)
	{
		int num = default(int);
		int num2 = default(int);
		uint num4 = default(uint);
		uint num3 = default(uint);
		try
		{
			num = 7;
			num2 = 5;
			num = 4;
			while (true)
			{
				num = 9;
				while (true)
				{
					byte[] array = byte_0;
					num4 = (uint_0 = (num3 = uint_0) + 1);
					array[num3] = byte_1;
					num = 2;
					while (true)
					{
						num2 = 6;
						num = 4;
						while (true)
						{
							num = 5;
							while (true)
							{
								int num5;
								if (uint_0 < uint_1)
								{
									num = 6;
									num5 = 1;
								}
								else
								{
									num = 11;
									num5 = 4;
								}
								num2 = num5;
								num = 4;
								switch (num2)
								{
								case 3:
									break;
								case 6:
									goto end_IL_003c;
								case 2:
									goto end_IL_004c;
								default:
									goto end_IL_0052;
								case 0:
									goto IL_005d;
								case 5:
									goto end_IL_0060;
								case 1:
									num = 0;
									return;
								case 4:
									num = 10;
									method_4();
									return;
								}
								num = 5;
								continue;
								end_IL_003c:
								break;
							}
							continue;
							end_IL_004c:
							break;
						}
						num = 2;
						continue;
						end_IL_0052:
						break;
					}
					num = 9;
					continue;
					IL_005d:
					num = 9;
					continue;
					end_IL_0060:
					break;
				}
			}
		}
		catch (Exception exception)
		{
			int num6 = default(int);
			StackFrameHelper.CreateException7(exception, num3, num4, num2, num, num6, this, byte_1);
			throw;
		}
	}

	public byte method_7(uint uint_3)
	{
		int num = default(int);
		uint num2 = default(uint);
		int num4 = default(int);
		try
		{
			num = 8;
			while (true)
			{
				num2 = uint_0 - uint_3 - 1;
				num = 9;
				while (true)
				{
					int num3;
					if (num2 < uint_1)
					{
						num = 4;
						num3 = 1;
					}
					else
					{
						num = 11;
						num3 = 4;
					}
					num4 = num3;
					num = 1;
					switch (num4)
					{
					case 3:
						goto IL_002e;
					default:
						num = 3;
						goto IL_004e;
					case 0:
						num = 3;
						goto IL_004e;
					case 2:
						num = 3;
						goto IL_004e;
					case 6:
						goto end_IL_0039;
					case 4:
						num = 5;
						num2 += uint_1;
						num4 = 1;
						num = 1;
						goto case 1;
					case 1:
						num = 2;
						break;
					case 5:
						{
							num = 2;
							break;
						}
						IL_004e:
						num4 = 6;
						num = 1;
						goto end_IL_0039;
					}
					return byte_0[num2];
					IL_002e:
					num = 9;
					continue;
					end_IL_0039:
					break;
				}
				num = 8;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num2, num4, num, this, uint_3);
			throw;
		}
	}

	static GClass2()
	{
		int num = default(int);
		char[] array = default(char[]);
		int num2 = default(int);
		char[] array2 = default(char[]);
		try
		{
			num = 8;
			char[] array_ = new char[8];
			Class10.Class11.smethod_12(array_, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 303, 347);
			char_3 = array_;
			array = new char[8];
			num = 15;
			array[4] = '⍬';
			array[1] = '\u05b7';
			array[7] = '⦯';
			num = 7;
			array[0] = '㥛';
			array[5] = '⎘';
			array[3] = '⳦';
			num = 16;
			array[6] = '㈶';
			array[2] = '㗆';
			string_1 = new string[1];
			num = 1;
			char_2 = array;
			num2 = 5;
			num = 14;
			Exception1.smethod_3();
			char[] array_2 = new char[660];
			Class10.Class11.smethod_12(array_2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 449, 437);
			char_1 = array_2;
			num = 9;
			array2 = new char[8];
			num2 = 4;
			num = 14;
			array2[7] = 'ⴝ';
			array2[4] = '㨹';
			array2[0] = 'ᴆ';
			num = 11;
			num2 = 1;
			num = 14;
			array2[6] = '\u032d';
			array2[2] = '⛱';
			array2[3] = '\u08e9';
			num = 10;
			num2 = 6;
			num = 14;
			array2[5] = '㹉';
			num = 2;
			array2[1] = 'ᕖ';
			num = 12;
			string_0 = new string[13];
			num2 = 3;
			num = 14;
			char_0 = array2;
		}
		catch (Exception exception)
		{
			int num3 = default(int);
			StackFrameHelper.CreateException5(exception, array2, num2, array, num, num3);
			throw;
		}
	}

	internal static string smethod_0(int int_0, int int_1)
	{
		int num = default(int);
		int num2 = default(int);
		char[] array = default(char[]);
		int num3 = default(int);
		int num4 = default(int);
		string text = default(string);
		int num8 = default(int);
		int num6 = default(int);
		char[] array2 = default(char[]);
		char[] array3 = default(char[]);
		int num7 = default(int);
		try
		{
			num = 24;
			while (true)
			{
				num2 = int_0 ^ 0x607C1959 ^ int_1;
				array = char_1;
				num = 12;
				while (true)
				{
					num3 = array[num2];
					num4 = 3;
					num = 4;
					while (true)
					{
						num = 25;
						int num5;
						if ((text = string_0[num3]) == null)
						{
							num = 15;
							num5 = 4;
						}
						else
						{
							num = 10;
							num5 = 10;
						}
						num4 = num5;
						num = 4;
						while (true)
						{
							switch (num4)
							{
							case 13:
								num = 11;
								num8 = 0;
								num4 = 12;
								num = 4;
								goto case 12;
							case 12:
							{
								num = 13;
								int num9;
								if (num8 >= num6)
								{
									num = 8;
									num9 = 6;
								}
								else
								{
									num = 20;
									num9 = 11;
								}
								num4 = num9;
								num = 4;
								continue;
							}
							case 11:
								num = 17;
								array2[num8] = (char)(array[num2 + num8] ^ array3[(num8 + num3) % num7]);
								num = 2;
								num4 = 2;
								num = 4;
								goto case 2;
							case 2:
								num = 7;
								num8 = 1 + num8;
								num4 = 12;
								num = 4;
								goto case 12;
							case 9:
								num = 0;
								array2 = new char[num6];
								array3 = char_0;
								num7 = array3.Length;
								num2 += 3;
								num = 5;
								num4 = 13;
								num = 4;
								goto case 13;
							case 4:
								num = 16;
								num6 = array[num2 + 1];
								num6 = (int)((uint)array[num2 + 2] << 16) + num6;
								num = 23;
								num4 = 9;
								num = 4;
								goto case 9;
							case 3:
								break;
							case 1:
								goto end_IL_0100;
							case 7:
								goto IL_0118;
							default:
								num = 22;
								goto IL_012f;
							case 0:
								num = 22;
								goto IL_012f;
							case 8:
								num = 24;
								goto end_IL_011b;
							case 5:
								num = 9;
								goto IL_0160;
							case 6:
								num = 14;
								text = new string(array2);
								num = 9;
								goto IL_0160;
							case 10:
								{
									num = 18;
									return text;
								}
								IL_0160:
								string_0[num3] = text;
								return text;
								IL_012f:
								num4 = 8;
								num = 4;
								goto case 8;
							}
							break;
						}
						continue;
						end_IL_0100:
						break;
					}
					num = 12;
					continue;
					IL_0118:
					num = 12;
					continue;
					end_IL_011b:
					break;
				}
			}
		}
		catch (Exception caughtException)
		{
			StackFrameHelper.CreateExceptionN(caughtException, new object[13]
			{
				num2, num3, num6, array, text, array2, array3, num7, num8, num4,
				num, int_0, int_1
			});
			throw;
		}
	}

	internal static string smethod_1(AssemblyName assemblyName_0, int int_0, int int_1)
	{
		int num = default(int);
		int num3 = default(int);
		try
		{
			num = 11;
			while (true)
			{
				int num2;
				switch (int_1 ^ int_0)
				{
				case 74:
					num = 6;
					num2 = 1;
					break;
				default:
					num = 12;
					num2 = 2;
					break;
				}
				num3 = num2;
				num = 5;
				switch (num3)
				{
				default:
					num = 7;
					goto IL_004c;
				case 2:
					num = 0;
					num3 = 0;
					num = 5;
					goto case 0;
				case 4:
					num = 3;
					num3 = 0;
					num = 5;
					goto case 0;
				case 5:
					num = 11;
					continue;
				case 7:
					num = 7;
					goto IL_004c;
				case 0:
					num = 11;
					continue;
				case 1:
					num = 2;
					break;
				case 3:
					num = 2;
					break;
				case 6:
					{
						num = 2;
						break;
					}
					IL_004c:
					num3 = 0;
					num = 5;
					goto case 0;
				}
				break;
			}
			return Class10.smethod_10(assemblyName_0, 331, 288);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num3, num, assemblyName_0, int_0, int_1);
			throw;
		}
	}

	internal static int smethod_2(string string_2, int int_0, int int_1)
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
				case 91:
					num = 4;
					num2 = 5;
					break;
				default:
					num = 0;
					num2 = 0;
					break;
				}
				num3 = num2;
				num = 8;
				switch (num3)
				{
				default:
					num = 11;
					goto IL_0044;
				case 0:
					num = 5;
					num3 = 7;
					num = 8;
					goto case 7;
				case 2:
					num = 7;
					continue;
				case 3:
					num = 11;
					goto IL_0044;
				case 4:
					num = 2;
					goto IL_0050;
				case 6:
					num = 2;
					goto IL_0050;
				case 7:
					num = 7;
					continue;
				case 1:
					num = 9;
					break;
				case 5:
					{
						num = 9;
						break;
					}
					IL_0050:
					num3 = 7;
					num = 8;
					goto case 7;
					IL_0044:
					num3 = 7;
					num = 8;
					goto case 7;
				}
				break;
			}
			return Class7.Class8.Class9.smethod_10(string_2, 171, 226);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num3, num, string_2, int_0, int_1);
			throw;
		}
	}

	internal static string smethod_3(string string_2, object object_0, int int_0, int int_1)
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
				case 121:
					num = 10;
					num2 = 3;
					break;
				default:
					num = 3;
					num2 = 7;
					break;
				}
				num3 = num2;
				num = 8;
				switch (num3)
				{
				default:
					num = 6;
					goto IL_0038;
				case 0:
					num = 6;
					goto IL_0038;
				case 1:
					num = 5;
					goto IL_0048;
				case 2:
					num = 5;
					goto IL_0048;
				case 5:
					num = 5;
					goto IL_0048;
				case 6:
					num = 9;
					break;
				case 7:
					num = 11;
					num3 = 4;
					num = 8;
					goto case 4;
				case 4:
					num = 9;
					break;
				case 3:
					{
						num = 0;
						return Class7.Class8.Class9.smethod_11(string_2, object_0, 812, 781);
					}
					IL_0048:
					num3 = 4;
					num = 8;
					goto case 4;
					IL_0038:
					num3 = 4;
					num = 8;
					goto case 4;
				}
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException6(exception, num3, num, string_2, object_0, int_0, int_1);
			throw;
		}
	}

	internal static Assembly smethod_4(Type type_0, int int_0, int int_1)
	{
		int num = default(int);
		int num3 = default(int);
		try
		{
			num = 11;
			while (true)
			{
				int num2;
				switch (int_1 ^ int_0)
				{
				case 120:
					num = 1;
					num2 = 5;
					break;
				default:
					num = 9;
					num2 = 6;
					break;
				}
				num3 = num2;
				num = 10;
				switch (num3)
				{
				default:
					num = 3;
					goto IL_0049;
				case 0:
					num = 3;
					goto IL_0049;
				case 1:
					num = 2;
					goto IL_0040;
				case 2:
					num = 2;
					goto IL_0040;
				case 4:
					num = 3;
					goto IL_0049;
				case 6:
					num = 7;
					num3 = 3;
					num = 10;
					goto IL_0057;
				case 3:
					goto IL_0057;
				case 5:
					num = 0;
					break;
				case 7:
					{
						num = 0;
						break;
					}
					IL_0040:
					num3 = 3;
					num = 10;
					goto IL_0057;
					IL_0049:
					num3 = 3;
					num = 10;
					goto IL_0057;
				}
				break;
				IL_0057:
				num = 11;
			}
			return Class7.Class8.smethod_9(type_0, 69, 73);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num3, num, type_0, int_0, int_1);
			throw;
		}
	}

	internal static string smethod_5(int int_0, int int_1)
	{
		int num = default(int);
		char[] array = default(char[]);
		int num2 = default(int);
		int num3 = default(int);
		string text = default(string);
		int num4 = default(int);
		char[] array2 = default(char[]);
		char[] array3 = default(char[]);
		int num5 = default(int);
		int num6 = default(int);
		try
		{
			num = int_0 ^ 0x607C1959 ^ int_1;
			array = char_3;
			num2 = array[num];
			num3 = 3;
			if ((text = string_1[num2]) != null)
			{
				num3 = 7;
				return text;
			}
			num3 = 8;
			num4 = array[num + 1];
			num4 = (int)((uint)array[num + 2] << 16) + num4;
			num3 = 5;
			array2 = new char[num4];
			array3 = char_2;
			num5 = array3.Length;
			num += 3;
			num3 = 12;
			num6 = 0;
			num3 = 9;
			while (num6 < num4)
			{
				num3 = 1;
				array2[num6] = (char)(array[num + num6] ^ array3[(num6 + num2) % num5]);
				num3 = 4;
				num6 = 1 + num6;
				num3 = 9;
			}
			num3 = 2;
			text = new string(array2);
			string_1[num2] = text;
			return text;
		}
		catch (Exception caughtException)
		{
			StackFrameHelper.CreateExceptionN(caughtException, new object[12]
			{
				num, num2, num4, array, text, array2, array3, num5, num6, num3,
				int_0, int_1
			});
			throw;
		}
	}
}
