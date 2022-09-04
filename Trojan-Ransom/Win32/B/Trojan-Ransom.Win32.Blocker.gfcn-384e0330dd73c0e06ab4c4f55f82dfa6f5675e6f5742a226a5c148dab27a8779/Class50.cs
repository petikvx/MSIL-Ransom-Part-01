using System;
using System.IO;
using System.Reflection;
using System.Security;
using System.Security.Policy;

internal sealed class Class50
{
	internal static string smethod_0<T>(object object_0, char char_0, short short_0)
	{
		byte[] byte_ = default(byte[]);
		int num = default(int);
		int num2 = default(int);
		ICloneable cloneable = default(ICloneable);
		int num3 = default(int);
		try
		{
			byte_ = Class35.byte_1;
			while (true)
			{
				num = 0;
				num2 = 2;
				while (true)
				{
					IL_00bb:
					switch (((short_0 ^ char_0) - 19) ^ num)
					{
					case 0:
						num2 = 8;
						goto IL_0096;
					default:
						{
							num2 = 3;
							goto IL_0055;
						}
						IL_0096:
						cloneable = ((T)object_0).ToString();
						num2 = byte_[93] - 236;
						goto IL_005d;
						IL_005d:
						while (true)
						{
							switch (num2)
							{
							case 5:
							case 11:
								break;
							case 0:
								goto IL_0024;
							default:
								num2 = byte_[209] - 131;
								continue;
							case 9:
								num2 = byte_[185];
								continue;
							case 3:
								goto IL_0055;
							case 8:
								goto IL_0096;
							case 2:
								goto IL_00bb;
							case 1:
								goto end_IL_00c3;
							case 7:
								return (string)cloneable;
							}
							break;
						}
						goto IL_0015;
						IL_0055:
						cloneable = null;
						num2 = 11;
						goto IL_0015;
						IL_0015:
						num++;
						num3 = char_0 * char_0;
						num3 = char_0 + num3;
						num2 = 0;
						goto IL_0024;
						IL_0024:
						if (num3 % 2 == 0)
						{
							num2 = (int)byte_[38] / 5;
							goto IL_005d;
						}
						num2 = 2;
						continue;
						end_IL_00c3:
						break;
					}
					break;
				}
			}
		}
		catch (Exception exception_)
		{
			int num4 = default(int);
			Class25.smethod_9(exception_, num, cloneable, num3, num4, num2, byte_, (T)object_0, char_0, short_0);
			throw;
		}
	}

	internal static string[] smethod_1<T>(object object_0, short short_0, char char_0) where T : Assembly
	{
		byte[] byte_ = default(byte[]);
		char[] char_ = default(char[]);
		int num = default(int);
		int num2 = default(int);
		int num4 = default(int);
		int num3 = default(int);
		object obj = default(object);
		try
		{
			byte_ = Class35.byte_1;
			char_ = Class45.char_0;
			while (true)
			{
				num = 0;
				num2 = (int)byte_[38] / 7;
				while (true)
				{
					switch (num2)
					{
					case 11:
						num4 = 864;
						if (2592 <= 864 - num3 * 3)
						{
							num2 = byte_[155] * 2;
							continue;
						}
						num2 = 3;
						goto case 3;
					case 10:
						num2 = 5;
						goto case 5;
					case 5:
						switch (((char_0 ^ short_0) - 89) ^ num)
						{
						case 0:
							goto IL_0063;
						}
						num2 = 1;
						goto case 1;
					case 1:
						obj = null;
						num2 = char_[50] - 52658;
						continue;
					case 6:
						obj = ((Assembly)object_0).GetManifestResourceNames();
						num2 = char_[239] - 44255;
						continue;
					case 7:
						num2 = 5;
						goto case 5;
					case 0:
					case 4:
						num++;
						num3 = 629;
						goto case 11;
					default:
						num2 = 2;
						break;
					case 2:
					case 9:
						break;
					case 3:
						{
							return obj as string[];
						}
						IL_0063:
						num2 = 6;
						goto case 6;
					}
					break;
				}
			}
		}
		catch (Exception exception_)
		{
			int num5 = default(int);
			Class25.smethod_11(exception_, new object[11]
			{
				num, obj, num4, num3, num5, num2, byte_, char_, object_0, short_0,
				char_0
			});
			throw;
		}
	}

	internal static string smethod_2(int int_0, short short_0)
	{
		char[] char_ = default(char[]);
		byte[] byte_ = default(byte[]);
		int num = default(int);
		int num2 = default(int);
		ICloneable cloneable = default(ICloneable);
		int num3 = default(int);
		try
		{
			char_ = Class45.char_0;
			byte_ = Class35.byte_1;
			while (true)
			{
				num = 0;
				num2 = 8;
				while (true)
				{
					IL_00b5:
					switch (((short_0 ^ int_0) - 16) ^ num)
					{
					case 0:
						num2 = 3;
						goto IL_0093;
					default:
						{
							num2 = char_[160] - 24031;
							goto IL_002e;
						}
						IL_0093:
						cloneable = Path.GetTempPath();
						num2 = 6;
						goto IL_0082;
						IL_0082:
						num++;
						num3 = short_0 * short_0;
						num3 = short_0 + num3;
						goto IL_007e;
						IL_007e:
						num2 = 0;
						goto IL_0076;
						IL_0076:
						num2 = ((num3 % 2 == 0) ? (byte_[147] - 233) : (byte_[156] - 32));
						goto IL_002e;
						IL_002e:
						while (true)
						{
							switch (num2)
							{
							case 7:
								cloneable = null;
								num2 = byte_[265];
								continue;
							case 0:
							case 4:
								break;
							case 10:
								goto IL_007e;
							case 6:
								goto IL_0082;
							case 3:
								goto IL_0093;
							case 2:
								num2 = 8;
								goto IL_00b5;
							case 8:
								goto IL_00b5;
							default:
								num2 = 9;
								goto end_IL_00bd;
							case 5:
							case 9:
								goto end_IL_00bd;
							case 1:
								return (string)cloneable;
							}
							break;
						}
						goto IL_0076;
						end_IL_00bd:
						break;
					}
					break;
				}
			}
		}
		catch (Exception exception_)
		{
			int num4 = default(int);
			Class25.smethod_9(exception_, num, cloneable, num3, num4, num2, char_, byte_, int_0, short_0);
			throw;
		}
	}

	internal static Assembly smethod_3<T>(byte[] byte_0, byte[] byte_1, object object_0, int int_0, char char_0) where T : Evidence
	{
		char[] char_ = default(char[]);
		int num = default(int);
		int num2 = default(int);
		IEvidenceFactory val = default(IEvidenceFactory);
		try
		{
			char_ = Class45.char_0;
			while (true)
			{
				num = 0;
				num2 = char_[149] - 59338;
				switch (num2)
				{
				default:
					goto IL_000a;
				case 1:
					continue;
				case 8:
					num2 = 5;
					goto case 2;
				case 4:
				case 11:
					num2 = 5;
					goto case 2;
				case 3:
					val = null;
					num2 = 7;
					goto case 7;
				case 0:
				case 10:
					val = (IEvidenceFactory)(object)Assembly.Load(byte_0, byte_1, (Evidence)object_0);
					num2 = 7;
					goto case 7;
				case 7:
					num++;
					if ((char_0 * char_0 + char_0) % 2 != 0)
					{
						num2 = 11;
						goto case 4;
					}
					num2 = 9;
					break;
				case 2:
				case 5:
					switch (((char_0 ^ int_0) - 44) ^ num)
					{
					case 0:
						goto IL_0065;
					}
					num2 = 3;
					goto case 3;
				case 9:
					break;
					IL_0065:
					num2 = 10;
					goto case 0;
				}
				break;
				IL_000a:
				num2 = 1;
			}
			return val as Assembly;
		}
		catch (Exception exception_)
		{
			int num3 = default(int);
			Class25.smethod_10(exception_, num, val, num3, num2, char_, byte_0, byte_1, object_0, int_0, char_0);
			throw;
		}
	}

	internal static AppDomain smethod_4(char char_0, int int_0)
	{
		char[] char_ = default(char[]);
		int num = default(int);
		int num2 = default(int);
		IEvidenceFactory val = default(IEvidenceFactory);
		int num3 = default(int);
		int num4 = default(int);
		try
		{
			char_ = Class45.char_0;
			while (true)
			{
				num = 0;
				num2 = 8;
				while (true)
				{
					switch (((int_0 ^ char_0) - 56) ^ num)
					{
					default:
						num2 = char_[142] - 26704;
						while (true)
						{
							switch (num2)
							{
							case 9:
								num2 = char_[206] - 63985;
								continue;
							default:
								num2 = char_[6] - 64569;
								continue;
							case 3:
							case 5:
								num2 = 8;
								break;
							case 8:
								break;
							case 6:
								goto end_IL_0075;
							case 10:
							case 11:
								val = null;
								num2 = 4;
								goto IL_0098;
							case 0:
							case 7:
								goto IL_008f;
							case 4:
								goto IL_0098;
							case 1:
								goto IL_00ab;
							}
							break;
						}
						continue;
					case 0:
						{
							num2 = 0;
							goto IL_008f;
						}
						IL_00ab:
						return (AppDomain)(object)val;
						IL_008f:
						val = (IEvidenceFactory)(object)AppDomain.CurrentDomain;
						num2 = 4;
						goto IL_0098;
						IL_0098:
						num++;
						num3 = 878;
						num4 = 926;
						num2 = 1;
						goto IL_00ab;
						end_IL_0075:
						break;
					}
					break;
				}
			}
		}
		catch (Exception exception_)
		{
			int num5 = default(int);
			Class25.smethod_9(exception_, num, val, num4, num3, num5, num2, char_, char_0, int_0);
			throw;
		}
	}

	internal static int smethod_5<T>(object object_0, byte[] byte_0, int int_0, int int_1, char char_0, short short_0) where T : Stream
	{
		char[] char_ = default(char[]);
		byte[] byte_ = default(byte[]);
		int num = default(int);
		int num2 = default(int);
		int num4 = default(int);
		int num5 = default(int);
		int num3 = default(int);
		try
		{
			char_ = Class45.char_0;
			byte_ = Class35.byte_1;
			while (true)
			{
				num = 0;
				num2 = 8;
				while (true)
				{
					IL_00e4:
					switch (((short_0 ^ char_0) - 106) ^ num)
					{
					case 0:
						num2 = char_[95] - 44798;
						goto IL_00a6;
					default:
						{
							num2 = 3;
							goto IL_0078;
						}
						IL_00a6:
						while (true)
						{
							switch (num2)
							{
							case 11:
								num++;
								num4 = 204;
								goto case 7;
							case 7:
								num5 = 208;
								goto case 2;
							case 2:
								if (624 <= num5 - num4 * 3)
								{
									num2 = 1;
									goto case 1;
								}
								num2 = char_[299] - 19523;
								continue;
							case 1:
								num2 = char_[54] - 62830;
								continue;
							case 5:
								num2 = char_[205] - 42762;
								continue;
							case 3:
								break;
							case 0:
								num3 = ((Stream)object_0).Read(byte_0, int_0, int_1);
								num2 = char_[98] - 39528;
								continue;
							case 8:
							case 10:
								goto IL_00e4;
							default:
								num2 = 6;
								goto end_IL_00ee;
							case 6:
								goto end_IL_00ee;
							case 9:
								return num3;
							}
							break;
						}
						goto IL_0078;
						IL_0078:
						num3 = 9;
						num2 = byte_[84] - 129;
						goto IL_00a6;
						end_IL_00ee:
						break;
					}
					break;
				}
			}
		}
		catch (Exception exception_)
		{
			int num6 = default(int);
			Class25.smethod_11(exception_, new object[14]
			{
				num, num3, num5, num4, num6, num2, char_, byte_, object_0, byte_0,
				int_0, int_1, char_0, short_0
			});
			throw;
		}
	}

	internal static byte[] smethod_6<T>(object object_0, int int_0, int int_1) where T : MemoryStream
	{
		char[] char_ = default(char[]);
		byte[] byte_ = default(byte[]);
		int num = default(int);
		int num2 = default(int);
		object obj = default(object);
		int num3 = default(int);
		int num4 = default(int);
		try
		{
			char_ = Class45.char_0;
			byte_ = Class35.byte_1;
			while (true)
			{
				num = 0;
				num2 = char_[72] - 30380;
				while (true)
				{
					switch (num2)
					{
					case 1:
					case 11:
						obj = ((MemoryStream)object_0).ToArray();
						num2 = 8;
						goto case 8;
					case 8:
						num++;
						num3 = 469;
						num4 = 503;
						num2 = byte_[11] - 104;
						continue;
					case 10:
					{
						char num5 = char_[208];
						Class35.byte_1[87] = (byte)((Class35.byte_1[87] | int_1) & 0x16);
						num2 = num5 - 58579;
						continue;
					}
					case 9:
						obj = null;
						goto case 0;
					case 0:
						num2 = char_[196] - 60755;
						continue;
					case 6:
						switch (((int_0 ^ int_1) - 123) ^ num)
						{
						case 0:
							goto IL_0091;
						}
						num2 = 9;
						goto case 9;
					default:
						num2 = char_[275] - 57095;
						continue;
					case 4:
						num2 = 6;
						goto case 6;
					case 3:
					case 7:
						break;
					case 2:
						{
							return obj as byte[];
						}
						IL_0091:
						num2 = 11;
						goto case 1;
					}
					break;
				}
			}
		}
		catch (Exception exception_)
		{
			int num6 = default(int);
			Class25.smethod_11(exception_, new object[11]
			{
				num, obj, num4, num3, num6, num2, char_, byte_, object_0, int_0,
				int_1
			});
			throw;
		}
	}
}
