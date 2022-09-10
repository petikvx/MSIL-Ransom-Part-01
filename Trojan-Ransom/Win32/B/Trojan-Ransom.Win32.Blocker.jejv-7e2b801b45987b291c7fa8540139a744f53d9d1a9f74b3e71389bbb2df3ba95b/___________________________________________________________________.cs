using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class ___________________________________________________________________
{
	public unsafe static string _(string string_0, string string_1 = "")
	{
		string s = ______________________________________________________________.__________________;
		int num = _003CModule_003E.____________;
		if (Operators.CompareString(string_1, _003CModule_003E.__________((int)(((0x800000 & ((num * 8388608 + -8858) ^ (~num << 23))) == 0) ? ((nint)Type.EmptyTypes.LongLength + 3099) : (((uint)num % 1708u == 1721556701) ? ((nint)Type.EmptyTypes.LongLength + 1673567021) : (sizeof(Guid) + 1290060372))), (int)((nint)Type.EmptyTypes.LongLength + 2760), (int)((nint)Type.EmptyTypes.LongLength + 110)), false) != 0)
		{
			s = string_1;
		}
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		string text = _003CModule_003E.__________((int)((nint)Type.EmptyTypes.LongLength + 3207), ((num << 24) + -301989888 == num << 24) ? 1798868283 : 2879, (int)(((((uint)num >> 9) & 0x800000) != (uint)((num - (num - 3954) << 23) & 0x800000)) ? ((nint)Type.EmptyTypes.LongLength + -2125133704) : (((-47 | (128 * num - 6455)) != -39) ? (-1678629619) : ((((uint)(18544 * num) & 3u) != 0) ? 1891066686 : ((~(num - ((num + -3741) | num)) == num - -41) ? (-2077553378) : 219)))));
		string result = default(string);
		try
		{
			int num2 = _003CModule_003E._____________;
			byte[] array = default(byte[]);
			if ((-1713953234 ^ (((num2 << 20) & num2) + 7089)) != 1965)
			{
				array = new byte[32];
				byte[] sourceArray = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(s));
				nint num3 = (nint)Type.EmptyTypes.LongLength + 1;
				while (true)
				{
					switch (num3)
					{
					default:
						goto IL_019e;
					case 0:
						break;
					}
					break;
					IL_019e:
					Array.Copy(sourceArray, 0, array, 0, 16);
					Array.Copy(sourceArray, 0, array, 15, 16);
					num3 = sizeof(uint) + -4;
				}
			}
			rijndaelManaged.Key = array;
			rijndaelManaged.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
			_003CModule_003E.___ = null;
			byte[] array2 = Convert.FromBase64String(string_0);
			text = Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array2, 0, array2.Length));
			string text2 = text;
			_003CModule_003E._______ = 1818084011;
			result = text2;
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public unsafe static string __(string string_0)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		string text = _003CModule_003E.__________(sizeof(byte) + 66008, sizeof(uint) + 66740, (int)((nint)Type.EmptyTypes.LongLength + 251));
		string result = default(string);
		try
		{
			int num = default(int);
			if ((1 & ((uint)(~num) >> 3)) != ((6127 + (uint)num / 8u) & 1))
			{
			}
			byte[] array = new byte[32];
			byte[] sourceArray = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(______________________________________________________________.__________________));
			nint num2 = sizeof(short) + -2;
			int num3 = default(int);
			while (true)
			{
				switch (num2)
				{
				default:
					while (true)
					{
						Array.Copy(sourceArray, 0, array, 0, 16);
						Array.Copy(sourceArray, 0, array, 15, 16);
						int ________________ = _003CModule_003E._________________;
						if (-1249902593 != (int)((uint)________________ / 29u))
						{
							break;
						}
						if (((((6 * num3 + num3 * 2) ^ -893582246) | (num3 - 8794)) & 2) != 2)
						{
						}
					}
					break;
				case 1:
				{
					rijndaelManaged.Key = array;
					rijndaelManaged.Mode = CipherMode.ECB;
					ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor();
					byte[] bytes = Encoding.Unicode.GetBytes(string_0);
					text = Convert.ToBase64String(cryptoTransform.TransformFinalBlock(bytes, 0, bytes.Length));
					result = text;
					return result;
				}
				}
				num2 = (nint)Type.EmptyTypes.LongLength + 1;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public unsafe static string ___(string string_0)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		string text = _003CModule_003E.__________((int)((nint)Type.EmptyTypes.LongLength + 50374), 49600, sizeof(ushort) + 244);
		string result = default(string);
		try
		{
			int num = default(int);
			byte[] array = default(byte[]);
			if ((((-(47 * num + 17 * num) + num) ^ (num & 0x1365)) & 0x20) == 0)
			{
				array = new byte[32];
				byte[] sourceArray = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(______________________________________________________________.__________________));
				nint num2 = ((((75 * num + num * 53) | -61) != -61) ? ((nint)Type.EmptyTypes.LongLength + 1814130466) : (sizeof(long) + -7));
				while (true)
				{
					switch (num2)
					{
					default:
						goto IL_009b;
					case 0:
						break;
					}
					break;
					IL_009b:
					Array.Copy(sourceArray, 0, array, 0, 16);
					Array.Copy(sourceArray, 0, array, 15, 16);
					num2 = sizeof(byte) + -1;
				}
			}
			rijndaelManaged.Key = array;
			rijndaelManaged.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
			byte[] array2 = Convert.FromBase64String(string_0);
			string @string = Encoding.Unicode.GetString(cryptoTransform.TransformFinalBlock(array2, 0, array2.Length));
			_003CModule_003E._________ = null;
			text = @string;
			result = text;
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string ____(string string_0)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		string text = _003CModule_003E.__________((int)((nint)Type.EmptyTypes.LongLength + 28746), 30513, (int)((nint)Type.EmptyTypes.LongLength + 162));
		string result = default(string);
		try
		{
			byte[] array;
			byte[] sourceArray;
			int ________________;
			int num = default(int);
			do
			{
				array = new byte[32];
				sourceArray = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(______________________________________________________________.__________________));
				________________ = _003CModule_003E._________________;
			}
			while ((0x3B1 ^ ((uint)________________ / 17698076u)) + 1543503872 == 32 * ((uint)num % 2u));
			Array.Copy(sourceArray, 0, array, 0, 16);
			Array.Copy(sourceArray, 0, array, 15, 16);
			switch ((nint)Type.EmptyTypes.LongLength + 0)
			{
			default:
			{
				rijndaelManaged.Key = array;
				rijndaelManaged.Mode = CipherMode.ECB;
				ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor();
				byte[] bytes = Encoding.ASCII.GetBytes(string_0);
				text = Convert.ToBase64String(cryptoTransform.TransformFinalBlock(bytes, 0, bytes.Length));
				result = text;
				return result;
			}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public unsafe static string _____(byte[] byte_0)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		string text = _003CModule_003E.__________(55054, (int)((nint)Type.EmptyTypes.LongLength + 57362), sizeof(double) + 3);
		string result = default(string);
		try
		{
			byte[] array = new byte[32];
			byte[] sourceArray = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(______________________________________________________________.__________________));
			nint num = sizeof(ulong) + -8;
			int num2 = default(int);
			int num3 = default(int);
			while (true)
			{
				switch (num)
				{
				default:
					Array.Copy(sourceArray, 0, array, 0, 16);
					Array.Copy(sourceArray, 0, array, 15, 16);
					num = (((0x1DFF | ((uint)num2 / 1024u / 64281073u)) != 7679) ? (((uint)num3 / 452375622u + 3605 != 2477440793u) ? ((nint)Type.EmptyTypes.LongLength + 107451157) : ((nint)Type.EmptyTypes.LongLength + 1161485371)) : ((nint)Type.EmptyTypes.LongLength + 1));
					break;
				case 1:
				{
					rijndaelManaged.Key = array;
					rijndaelManaged.Mode = CipherMode.ECB;
					ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor();
					text = Convert.ToBase64String(cryptoTransform.TransformFinalBlock(byte_0, 0, byte_0.Length));
					result = text;
					return result;
				}
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public unsafe static bool ______()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		try
		{
			if (File.Exists(Path.GetTempPath() + _003CModule_003E._______<string>(2459158558u)))
			{
				return false;
			}
			ManagementObjectSearcher val = new ManagementObjectSearcher(_003CModule_003E.____<string>(795934529u), _003CModule_003E.______<string>(3869725961u));
			string empty = string.Empty;
			ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
			try
			{
				enumerator = val.Get().GetEnumerator();
				string text = default(string);
				int num3 = default(int);
				bool result = default(bool);
				int num4 = default(int);
				while (true)
				{
					ManagementObjectEnumerator obj = enumerator;
					_003CModule_003E._______ = 1957620381;
					if (!obj.MoveNext())
					{
						break;
					}
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					int num = 14777;
					empty = Convert.ToString(RuntimeHelpers.GetObjectValue(((ManagementBaseObject)val2).get_Item(_003CModule_003E._____<string>(1814773821u))));
					num = sizeof(Guid) + -30525;
					nint num2 = (nint)Type.EmptyTypes.LongLength + 2;
					while (true)
					{
						switch (num2)
						{
						case 3:
							if (!text.Contains(_003CModule_003E.______<string>(3024994053u)))
							{
								if (!text.Contains(_003CModule_003E.___<string>(2323656759u)))
								{
									if (num == -1628)
									{
										break;
									}
									if (!text.Contains(_003CModule_003E._____<string>(1720640825u)))
									{
										if (!text.Contains(_003CModule_003E.____<string>(3413919150u)))
										{
											num2 = ((((num3 + 15 * num3) ^ -8421) == 0) ? (sizeof(short) + -1159374780) : (sizeof(short) + -2));
											continue;
										}
										return true;
									}
								}
								return true;
							}
							return true;
						default:
							while (true)
							{
								text = Strings.StrConv(empty, (VbStrConv)2, 0);
								if (text.Contains(_003CModule_003E._____<string>(2076862217u)))
								{
									break;
								}
								if (6 * num + num * 2 != 5001 && num == -18181)
								{
									continue;
								}
								goto IL_016f;
							}
							goto case 4;
						case 0:
							if (!text.Contains(_003CModule_003E.___<string>(85258705u)))
							{
								if (!text.Contains(_003CModule_003E.______<string>(1023570339u)))
								{
									num2 = 5;
									continue;
								}
								return true;
							}
							return true;
						case 5:
							break;
						case 4:
							return true;
						case 1:
							{
								return result;
							}
							IL_016f:
							if (!text.Contains(_003CModule_003E._____<string>(3352247986u)))
							{
								if (!text.Contains(_003CModule_003E.______<string>(1704528494u)))
								{
									num3 = _003CModule_003E._____________;
									num = (int)(((0x4000000u & (uint)((-1736441856 * num3) ^ (8388608 * num3))) != 0) ? ((nint)Type.EmptyTypes.LongLength + -1990278693) : (((uint)num % 707u != 4294963520u) ? ((nint)Type.EmptyTypes.LongLength + -6995) : ((-9330688 + (int)((uint)(num4 + num4) >> 1) != num4) ? ((nint)Type.EmptyTypes.LongLength + 1188331054) : ((nint)Type.EmptyTypes.LongLength + -1992123313))));
									num2 = (nint)Type.EmptyTypes.LongLength + 3;
									continue;
								}
								result = true;
								if ((uint)num3 / 316779108u == 1996039184)
								{
									num2 = (nint)Type.EmptyTypes.LongLength + -2054006470;
									continue;
								}
								return result;
							}
							return true;
						}
						break;
					}
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			return Debugger.IsAttached;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public unsafe static byte[] _______(byte[] byte_0, string string_0 = "")
	{
		byte[] result = default(byte[]);
		try
		{
			int num2 = default(int);
			uint[] array = default(uint[]);
			uint num8 = default(uint);
			int num9 = default(int);
			uint num11 = default(uint);
			uint num10 = default(uint);
			byte[] array2 = default(byte[]);
			int num13 = default(int);
			byte[] bytes = default(byte[]);
			while (true)
			{
				IL_0001:
				string s = ______________________________________________________________.__________________;
				nint num = (nint)Type.EmptyTypes.LongLength + 33389;
				int num3;
				nint num4;
				if (((num2 + num2 * 7) ^ -6041) == 0)
				{
					num3 = sizeof(double) + -1384965803;
					num4 = num3;
				}
				else
				{
					num4 = (nint)Type.EmptyTypes.LongLength + 33880;
				}
				int num5 = 78;
				int num6;
				nint num7;
				if (Operators.CompareString(string_0, _003CModule_003E.__________((int)num, num3, 78), false) != 0)
				{
					num6 = sizeof(short) + -2;
					num7 = num6;
					goto IL_029b;
				}
				goto IL_02f2;
				IL_02c6:
				array[num8] = num8;
				num8++;
				num9 = (int)((nint)Type.EmptyTypes.LongLength + -32656);
				num7 = (nint)Type.EmptyTypes.LongLength + 7;
				goto IL_029b;
				IL_029b:
				while (true)
				{
					switch (num7)
					{
					case 8:
						break;
					case 7:
						goto IL_00bb;
					case 1:
						goto IL_00dc;
					case 6:
					{
						num11 = array[num8];
						array[num8] = array[num10];
						int num12 = _003CModule_003E.__________;
						if ((0x10EFu ^ (uint)(num12 * 15682)) != 0)
						{
							num7 = (nint)Type.EmptyTypes.LongLength + 8;
							continue;
						}
						goto IL_02f0;
					}
					case 5:
						goto IL_018a;
					case 4:
						goto IL_0203;
					case 2:
						num10 = (uint)((num10 + array[num8]) & 0xFFuL);
						num7 = (nint)Type.EmptyTypes.LongLength + 6;
						continue;
					case 3:
						goto end_IL_029b;
					default:
						goto IL_02f0;
					}
					array[num10] = num11;
					array2[num13] = (byte)(byte_0[num13] ^ array[(int)((long)(array[num8] + array[num10]) & 0xFFL)]);
					num13++;
					goto IL_008a;
					IL_0203:
					do
					{
						num11 = array[num8];
						array[num8] = array[num10];
					}
					while (num9 != 10107);
					array[num10] = num11;
					num8++;
					if (((num11 * 307757056) | 0x57F) - 16441344 != 0 - (0x24D0 & num11) << 11)
					{
						num7 = (nint)Type.EmptyTypes.LongLength + 5;
						continue;
					}
					if (((5854 + num5 * -1241513984) | -7609) != -2337)
					{
						num7 = (nint)Type.EmptyTypes.LongLength + -1032371424;
						continue;
					}
					goto IL_02f0;
					IL_0119:
					num10 = (uint)((num10 + bytes[(int)((long)num8 % (long)bytes.Length)] + array[num8]) & 0xFFuL);
					num9 = (int)((nint)Type.EmptyTypes.LongLength + 10107);
					num7 = (nint)Type.EmptyTypes.LongLength + 4;
					continue;
					IL_00dc:
					num2 = array2.Length - 1;
					num13 = 0;
					int num14 = ___________._;
					if ((((uint)num14 ^ ((uint)(num14 << 7) >> 7)) & 0xA6BCB0u) != 0 || num9 != -17638)
					{
						goto IL_0001;
					}
					goto IL_008a;
					IL_00bb:
					if (num8 > 255)
					{
						bytes = Encoding.UTF8.GetBytes(s);
						if (num9 != -32656)
						{
							goto IL_00dc;
						}
						num8 = 0u;
						goto IL_0119;
					}
					goto IL_02c6;
					IL_008a:
					if (num13 <= num2)
					{
						num8 = (uint)(((ulong)num8 + 1uL) & 0xFFuL);
						num6 = sizeof(double) + -6;
						num7 = num6;
						continue;
					}
					result = array2;
					return result;
					IL_018a:
					if (num8 > 255)
					{
						num8 = 0u;
						num10 = 0u;
						int ______________ = _003CModule_003E._______________;
						num9 = (int)(((1 & (-(______________ * 2 + ______________ * 2) - -349)) == 1) ? (-17638) : ((nint)Type.EmptyTypes.LongLength + -438041807));
						int num15 = ______________________._______;
						num7 = (((0x1122u ^ (uint)((num15 << 11) - 6079)) != 0) ? ((nint)Type.EmptyTypes.LongLength + 1) : ((nint)Type.EmptyTypes.LongLength + 1478133092));
						continue;
					}
					goto IL_0119;
					continue;
					end_IL_029b:
					break;
				}
				goto IL_02eb;
				IL_02eb:
				num8 = 0u;
				goto IL_02c6;
				IL_02f0:
				s = string_0;
				goto IL_02f2;
				IL_02f2:
				array = new uint[256];
				array2 = new byte[byte_0.Length - 1 + 1];
				goto IL_02eb;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static bool ________()
	{
		try
		{
			WindowsIdentity current = WindowsIdentity.GetCurrent();
			WindowsPrincipal windowsPrincipal = new WindowsPrincipal(current);
			return windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static object _________()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			PowerStatus powerStatus = SystemInformation.get_PowerStatus();
			string text = ((Enum)powerStatus.get_BatteryChargeStatus()).ToString();
			if (Operators.CompareString(text, _003CModule_003E._____<string>(3551643924u), false) == 0)
			{
				return _003CModule_003E._____<string>(943744901u);
			}
			return _003CModule_003E._____<string>(3370703587u);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = _003CModule_003E._______<string>(2386334509u);
			ProjectData.ClearProjectError();
			return result;
		}
	}
}
