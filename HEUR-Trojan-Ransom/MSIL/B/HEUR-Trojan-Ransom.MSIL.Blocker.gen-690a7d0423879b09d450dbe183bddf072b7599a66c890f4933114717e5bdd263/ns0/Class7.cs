using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Threading;

namespace ns0;

internal sealed class Class7
{
	internal sealed class Class8
	{
		internal static AppDomain smethod_0(char char_0, int int_0)
		{
			char[] char_ = Class1.char_1;
			int[] int_ = Class0.int_0;
			MarshalByRefObject marshalByRefObject = default(MarshalByRefObject);
			while (true)
			{
				int num = 0;
				int num2 = int_[9] - 30923;
				while (true)
				{
					switch (num2)
					{
					case 8:
						marshalByRefObject = AppDomain.CurrentDomain;
						num2 = 1;
						continue;
					default:
						num2 = char_[6] - 62444;
						continue;
					case 3:
						marshalByRefObject = null;
						num2 = 1;
						continue;
					case 2:
						num2 = 0;
						continue;
					case 1:
					{
						num++;
						int num3 = 708;
						int num4 = 62;
						Class1.char_1[219] = (char)((Class1.char_1[219] ^ int_0) & 'ë');
						num2 = ((177 >= num3 / 4 - num4) ? 5 : 0);
						continue;
					}
					case 0:
						num2 = (((int_0 ^ char_0) - 125) ^ num) switch
						{
							0 => 8, 
							_ => 3, 
						};
						continue;
					case 9:
						break;
					case 4:
					case 5:
					case 10:
						return marshalByRefObject as AppDomain;
					}
					break;
				}
			}
		}

		internal static Assembly smethod_1(byte[] byte_0, short short_0, int int_0)
		{
			char[] char_ = Class1.char_1;
			int[] int_ = Class0.int_0;
			_Assembly val = default(_Assembly);
			int num3 = default(int);
			while (true)
			{
				int num = 0;
				int num2 = 9;
				while (true)
				{
					switch (num2)
					{
					case 7:
					case 10:
						val = null;
						num2 = int_[153] - 14054;
						continue;
					case 3:
					case 9:
						num2 = (((short_0 ^ int_0) - 31) ^ num) switch
						{
							0 => char_[108] - char_[108], 
							_ => 10, 
						};
						continue;
					default:
						num2 = 2;
						continue;
					case 6:
					{
						int num4 = 7;
						num2 = ((266 >= num3 / 4 - num4) ? 1 : 9);
						continue;
					}
					case 5:
						num++;
						num3 = 1064;
						goto case 6;
					case 4:
						num2 = int_[322] - 34273;
						continue;
					case 0:
						val = (_Assembly)(object)Assembly.Load(byte_0);
						num2 = char_[423] - 27282;
						continue;
					case 2:
						break;
					case 1:
						return val as Assembly;
					}
					break;
				}
			}
		}

		internal static Stream smethod_2<T, U>(T gparam_0, U gparam_1, char char_0, short short_0) where T : Assembly where U : string
		{
			int[] int_ = Class0.int_0;
			char[] char_ = Class1.char_1;
			IDisposable disposable = default(IDisposable);
			while (true)
			{
				int num = 0;
				int num2 = 11;
				while (true)
				{
					switch (num2)
					{
					case 2:
					case 11:
						num2 = (((char_0 ^ short_0) - 109) ^ num) switch
						{
							0 => 1, 
							_ => int_[132] - 44273, 
						};
						continue;
					case 8:
					case 10:
						num2 = int_[13] - 44993;
						continue;
					case 9:
					{
						num++;
						int num3 = char_0 * char_0;
						Class1.char_1[420] = (char)(Class1.char_1[420] & short_0 & '\u00a0');
						num2 = (((num3 + char_0) % 2 == 0) ? 7 : (char_[423] - 27284));
						continue;
					}
					case 1:
					case 6:
						disposable = gparam_0.GetManifestResourceStream(gparam_1);
						num2 = int_[225] - 24484;
						continue;
					case 5:
						disposable = null;
						num2 = char_[387] - 28622;
						continue;
					default:
						num2 = 0;
						continue;
					case 3:
						num2 = char_[265] - 43822;
						continue;
					case 0:
						break;
					case 7:
						return disposable as Stream;
					}
					break;
				}
			}
		}
	}

	internal static void smethod_0<T>(T gparam_0, short short_0, int int_0)
	{
		int[] int_ = Class0.int_0;
		int num = 7;
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			switch (num)
			{
			case 9:
				Monitor.Exit(gparam_0);
				goto case 4;
			case 4:
				num2++;
				num3 = 2144;
				num4 = 9;
				goto case 0;
			case 0:
				num = ((536 < num3 / 4 - num4) ? (int_[215] - 15135) : 6);
				break;
			default:
				num2 = 0;
				num = 5;
				break;
			case 5:
				num = (((int_0 ^ short_0) - 114) ^ num2) switch
				{
					0 => 2, 
					1 => 9, 
					_ => 1, 
				};
				break;
			case 1:
			case 3:
				num = 4;
				break;
			case 2:
				Monitor.Enter(gparam_0);
				num = 4;
				break;
			case 6:
				Class1.char_1[158] = (char)((Class1.char_1[158] * int_0) & 'µ');
				return;
			}
		}
	}

	internal static Evidence smethod_1<T>(T gparam_0, short short_0, short short_1) where T : Assembly
	{
		int[] int_ = Class0.int_0;
		char[] char_ = Class1.char_1;
		ICollection collection = default(ICollection);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = int_[76] - 54378;
			while (true)
			{
				switch (num2)
				{
				case 10:
				case 11:
					num2 = char_[405] - 54222;
					continue;
				case 9:
					num2 = 0;
					continue;
				case 8:
					collection = ((Assembly)gparam_0).get_Evidence();
					num2 = int_[126] - 49957;
					continue;
				case 7:
					num++;
					num3 = 146;
					num4 = 198;
					goto case 5;
				case 5:
					num2 = ((594 > num4 - num3 * 3) ? (char_[182] - 53675) : 10);
					continue;
				default:
					num2 = int_[151] - 30226;
					continue;
				case 1:
					collection = null;
					num2 = 7;
					continue;
				case 0:
					num2 = (((short_1 ^ short_0) - 27) ^ num) switch
					{
						0 => 8, 
						_ => int_[368] - 27287, 
					};
					continue;
				case 4:
					break;
				case 6:
					return (Evidence)collection;
				}
				break;
			}
		}
	}
}
