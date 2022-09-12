using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading;
using System.Timers;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using IntelliLock.Licensing;
using Microsoft.Win32;

[DesignTimeVisible(false)]
internal class Class3 : LicenseProvider
{
	internal class Class4
	{
		internal static string string_0;

		internal static string string_1;

		internal static string string_2;

		internal static string string_3;

		internal static string string_4;

		internal static string string_5;

		internal static string string_6;

		internal static string string_7;

		internal static string string_8;

		internal static string string_9;

		internal static string string_10;

		internal static string string_11;

		internal static string string_12;

		internal static string string_13;

		internal static string string_14;

		internal static string string_15;

		internal static string string_16;

		internal static string string_17;

		internal static string string_18;

		internal static string string_19;

		internal static string string_20;

		internal static string string_21;

		internal static string string_22;

		internal static string string_23;

		internal static string string_24;

		internal static string string_25;

		internal static string string_26;

		internal static string string_27;

		internal static string string_28;

		internal static string string_29;

		internal static string string_30;

		internal static string string_31;

		internal static string string_32;

		internal static string string_33;

		internal static string string_34;

		internal static string string_35;

		internal static string string_36;

		internal static string string_37;

		internal static string string_38;

		internal static string string_39;

		static Class4()
		{
			string_0 = "Software\\CLASSES\\CID\\";
			string_1 = "CLSID\\";
			string_2 = "Software\\CLASSES\\CLSID\\";
			string_3 = "\\Isolated Storage\\";
			string_4 = "\\IsolatedStorage\\";
			string_5 = "[AssemblyName]";
			string_6 = "[AssemblyVersion]";
			string_7 = "[AssemblyCopyright]";
			string_8 = "[AssemblyTrademark]";
			string_9 = "[AssemblyCompany]";
			string_10 = "[AssemblyProduct]";
			string_11 = "[AssemblyDescription]";
			string_12 = "[AssemblyTitle]";
			string_13 = "####-####-####-####-####-####";
			string_14 = "[current_days]";
			string_15 = "[days_left]";
			string_16 = "[global_left]";
			string_17 = "[max_days]";
			string_18 = "[expiration_date]";
			string_19 = "[current_date]";
			string_20 = "[current_execution]";
			string_21 = "[max_executions]";
			string_22 = "[executions_left]";
			string_23 = "[max_instances]";
			string_24 = "[current_global]";
			string_25 = "[max_global]";
			string_26 = "X";
			string_27 = "G";
			string_28 = "V";
			string_29 = "I";
			string_30 = "C";
			string_31 = "D";
			string_32 = "L";
			string_33 = "U";
			string_34 = "S";
			string_35 = "F";
			string_36 = "H";
			string_37 = "M";
			string_38 = "*.";
			string_39 = ".";
		}
	}

	internal class Class5
	{
		internal DateTime dateTime_0 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

		internal DateTime dateTime_1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

		internal DateTime dateTime_2 = new DateTime(1700, 1, 1);

		internal int int_0;

		internal int int_1;

		internal int int_2 = 1;

		internal ulong ulong_0;

		internal int int_3;

		internal string string_0 = "";

		internal bool bool_0 = true;

		internal string string_1 = "";

		internal string string_2 = "";

		private string string_3 = "";

		internal bool method_0(string string_4, byte[] byte_0, byte[] byte_1)
		{
			byte[] array = Convert.FromBase64String(string_4);
			SymmetricAlgorithm symmetricAlgorithm = Class1.smethod_8();
			symmetricAlgorithm.Mode = CipherMode.CBC;
			ICryptoTransform transform = symmetricAlgorithm.CreateDecryptor(byte_0, byte_1);
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.FlushFinalBlock();
			byte[] array2 = memoryStream.ToArray();
			memoryStream.Close();
			cryptoStream.Close();
			string_4 = Encoding.Unicode.GetString(array2, 0, array2.Length);
			try
			{
				string[] array3 = string_4.Split(new char[1] { '|' });
				for (int i = 0; i < array3.Length / 2; i++)
				{
					if (array3[i * 2] == Class4.string_26)
					{
						int_0 = method_2(array3[i * 2 + 1]);
					}
					else if (array3[i * 2] == Class4.string_27)
					{
						int_1 = method_2(array3[i * 2 + 1]);
					}
					else if (array3[i * 2] == Class4.string_28)
					{
						int_2 = method_2(array3[i * 2 + 1]);
					}
					else if (array3[i * 2] == Class4.string_29)
					{
						int_3 = method_2(array3[i * 2 + 1]);
					}
					else if (array3[i * 2] == Class4.string_30)
					{
						ulong_0 = method_3(array3[i * 2 + 1]);
					}
					else if (array3[i * 2] == Class4.string_31)
					{
						dateTime_0 = method_4(array3[i * 2 + 1]);
					}
					else if (array3[i * 2] == Class4.string_32)
					{
						dateTime_1 = method_4(array3[i * 2 + 1]);
					}
					else if (array3[i * 2] == Class4.string_34)
					{
						dateTime_2 = method_4(array3[i * 2 + 1]);
					}
					else if (array3[i * 2] == Class4.string_35)
					{
						bool_0 = method_1(array3[i * 2 + 1]);
					}
					else if (array3[i * 2] == Class4.string_33)
					{
						string_0 = array3[i * 2 + 1];
					}
					else if (array3[i * 2] == Class4.string_36)
					{
						string_1 = array3[i * 2 + 1];
					}
					else if (array3[i * 2] == Class4.string_37)
					{
						string_2 = array3[i * 2 + 1];
					}
				}
			}
			catch
			{
				return false;
			}
			return true;
		}

		internal bool method_1(string string_4)
		{
			if (string_4 == "1")
			{
				return true;
			}
			return false;
		}

		internal int method_2(string string_4)
		{
			return Convert.ToInt32(string_4);
		}

		internal ulong method_3(string string_4)
		{
			return Convert.ToUInt64(string_4);
		}

		internal DateTime method_4(string string_4)
		{
			string value = string_4.Substring(0, 4);
			string value2 = string_4.Substring(4, 2);
			string value3 = string_4.Substring(6, 2);
			return new DateTime(Convert.ToInt32(value), Convert.ToInt32(value2), Convert.ToInt32(value3));
		}

		internal string method_5(byte[] byte_0, byte[] byte_1)
		{
			string_3 = "";
			method_6(Class4.string_26);
			method_7(int_0);
			method_6(Class4.string_27);
			method_7(int_1);
			method_6(Class4.string_28);
			method_7(int_2);
			method_6(Class4.string_29);
			method_7(int_3);
			method_6(Class4.string_30);
			method_7(ulong_0);
			method_6(Class4.string_31);
			method_7(dateTime_0);
			method_6(Class4.string_32);
			method_7(dateTime_1);
			method_6(Class4.string_34);
			method_7(dateTime_2);
			method_6(Class4.string_35);
			method_7(bool_0);
			method_6(Class4.string_33);
			method_7(string_0);
			method_6(Class4.string_36);
			method_7(string_1);
			method_6(Class4.string_37);
			method_7(string_2);
			byte[] bytes = Encoding.Unicode.GetBytes(string_3);
			SymmetricAlgorithm symmetricAlgorithm = Class1.smethod_8();
			symmetricAlgorithm.Mode = CipherMode.CBC;
			ICryptoTransform transform = symmetricAlgorithm.CreateEncryptor(byte_0, byte_1);
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			cryptoStream.Write(bytes, 0, bytes.Length);
			cryptoStream.FlushFinalBlock();
			byte[] inArray = memoryStream.ToArray();
			memoryStream.Close();
			cryptoStream.Close();
			string_3 = Convert.ToBase64String(inArray);
			return string_3;
		}

		internal void method_6(string string_4)
		{
			if (string_3.Length > 0)
			{
				string_3 += "|";
			}
			string_3 += string_4;
		}

		internal void method_7(object object_0)
		{
			string_3 += "|";
			if (object_0 is int)
			{
				string_3 += (int)object_0;
				return;
			}
			if (object_0 is DateTime)
			{
				string_3 = string_3 + ((DateTime)object_0).Year.ToString("D4") + ((DateTime)object_0).Month.ToString("D2") + ((DateTime)object_0).Day.ToString("D2");
				return;
			}
			if (object_0 is ulong)
			{
				string_3 += (ulong)object_0;
				return;
			}
			if (object_0 is string)
			{
				string_3 += object_0.ToString();
				return;
			}
			if (object_0 is bool)
			{
				if ((bool)object_0)
				{
					string_3 += "1";
				}
				else
				{
					string_3 += "0";
				}
				return;
			}
			throw new Exception("Invalid Key Type");
		}
	}

	internal class Class6
	{
		internal string string_0 = "";

		internal ArrayList arrayList_0 = new ArrayList();

		internal bool bool_0 = true;

		internal bool bool_1 = true;

		internal bool bool_2;

		internal bool bool_3;

		internal bool bool_4;

		internal string string_1 = "";

		internal string string_2 = "";

		internal bool bool_5;

		internal bool bool_6;

		internal bool bool_7 = true;

		internal bool bool_8;

		internal bool bool_9;

		internal bool bool_10 = true;

		internal bool bool_11;

		internal bool bool_12;

		internal bool bool_13;

		internal string string_3 = "";

		internal bool bool_14 = true;

		internal bool bool_15;

		internal bool bool_16;

		internal string string_4 = "http://";

		internal bool bool_17;

		internal int int_0 = 28;

		internal string string_5 = Class4.string_13;

		internal int int_1 = 5;

		internal int int_2;

		internal bool bool_18;

		internal bool bool_19;

		internal int int_3 = 31;

		internal bool bool_20;

		internal DateTime dateTime_0 = DateTime.Now.AddDays(1.0);

		internal bool bool_21;

		internal int int_4 = 20;

		internal bool bool_22;

		internal int int_5 = 10;

		internal bool bool_23;

		internal int int_6 = 60;

		internal bool bool_24;

		internal int int_7 = 1;

		internal bool bool_25;

		internal bool bool_26 = true;

		internal bool bool_27 = true;

		internal bool bool_28 = true;

		internal bool bool_29 = true;

		internal bool bool_30 = true;

		internal bool bool_31 = true;

		internal bool bool_32 = true;

		internal bool bool_33 = true;

		internal bool bool_34 = true;

		internal bool bool_35 = true;

		internal bool bool_36 = true;

		internal bool bool_37 = true;

		internal bool bool_38;

		internal bool bool_39 = true;

		internal bool bool_40 = true;

		internal bool bool_41 = true;

		internal string string_6 = "You are on day [current_days] of your [max_days] day evaluation period. Your trial period is expired! You need to purchase a license to run this software.";

		internal string string_7 = "Your expiration date([expiration_date]) is reached! You need to purchase a license file to run this software.";

		internal string string_8 = "You have used this software [current_execution] times out of a maximum of [max_executions]. You have [executions_left] uses left. Your trial period is expired! You need to purchase a license to run this software.";

		internal string string_9 = "This software won't run without a valid license file. Either a valid license file could not be found or your license file is expired.";

		internal string string_10 = "You can only run maximal [max_instances] instances of this software at the same time.";

		internal string string_11 = "You are on minute [current_global] of your [max_global] minutes evaluation period. Your trial period is expired! You need to purchase a license to run this software.";

		internal string string_12 = "Your runtime is exceeded!";

		internal string string_13 = "Nag Screen! This message will disappear when a valid license file is installed.";

		internal string string_14 = "Can't connect to floating license service. Please check your connection and firewall settings.";

		internal string string_15 = "Floating license service timeout. Please check your connection and restart the application.";

		internal string string_16 = "The number of concurrent users is currently exceeded.";

		internal bool bool_42 = true;

		internal int int_8 = 90;

		internal string string_17 = "";

		internal string string_18 = "*.license";

		internal Hashtable hashtable_0 = new Hashtable();

		internal static Class20 class20_0;

		internal bool method_0(byte[] byte_0)
		{
			try
			{
				MemoryStream memoryStream = new MemoryStream(byte_0);
				BinaryReader binaryReader = new BinaryReader(memoryStream);
				memoryStream.Position = 0L;
				byte[] array = binaryReader.ReadBytes(binaryReader.ReadInt32());
				byte[] byte_ = binaryReader.ReadBytes((int)(memoryStream.Length - 4L - array.Length));
				binaryReader.Close();
				if (smethod_37(smethod_36("<RSAKeyValue><Modulus>t0R+zt7wCeBClCmwRoOzVMQ4RbT7l4UXdrdrZ3hwYkE2LqCdBZujJLaZcoeozjRDu5zgr7slwKQpFQiQ3eu0vj07Khot/6fVgkTIoHQ58sn1weQnPy4DrvNYGuYTOT1ceNg+3vkFWrLdp8Mjo8gRNHRLqDKCMRATAWni5g/bvfVIJDmuNlF6dJqP2tHldZUoOfuIg5j+f1jO73oMSC6Hagm56i1oVDLjAusRgjY5+no8+bdhEE8JwxDFz2NA9pLo6uYX7K9eCb4N1vML6wUD5V/2kYIEO+vg0K+P987kceI78o5fwI2Hn8wSK5Bsl9aezOgUWtMbMOz+0izBKoDUGw==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>", 2048), byte_, array))
				{
					return true;
				}
				return false;
			}
			catch
			{
				return false;
			}
		}

		private static byte[] smethod_0(ref int int_9, byte[] byte_0)
		{
			byte[] array = new byte[byte_0[int_9]];
			Array.Copy(byte_0, int_9 + 1, array, 0, array.Length);
			int_9 = int_9 + 1 + array.Length;
			return array;
		}

		internal static bool smethod_1(byte[] byte_0)
		{
			try
			{
				try
				{
					if (class20_0 == null)
					{
						BinaryReader binaryReader = new BinaryReader(typeof(Class6).Assembly.GetManifestResourceStream("a021523a-476b-47cf-8138-6ea414eb0466"));
						binaryReader.BaseStream.Position = 0L;
						byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
						byte[] array2 = new byte[32];
						array2[0] = 136;
						array2[0] = 130;
						array2[0] = 108;
						array2[0] = 164;
						array2[1] = 97;
						array2[1] = 160;
						array2[1] = 60;
						array2[1] = 117;
						array2[1] = 191;
						array2[2] = 111;
						array2[2] = 122;
						array2[2] = 57;
						array2[3] = 92;
						array2[3] = 123;
						array2[3] = 162;
						array2[3] = 157;
						array2[3] = 120;
						array2[3] = 164;
						array2[4] = 102;
						array2[4] = 148;
						array2[4] = 138;
						array2[5] = 90;
						array2[5] = 86;
						array2[5] = 79;
						array2[6] = 128;
						array2[6] = 109;
						array2[6] = 172;
						array2[6] = 98;
						array2[6] = 107;
						array2[6] = 190;
						array2[7] = 114;
						array2[7] = 140;
						array2[7] = 185;
						array2[8] = 95;
						array2[8] = 123;
						array2[8] = 154;
						array2[8] = 175;
						array2[8] = 51;
						array2[9] = 191;
						array2[9] = 150;
						array2[9] = 26;
						array2[10] = 92;
						array2[10] = 192;
						array2[10] = 183;
						array2[10] = 102;
						array2[10] = 121;
						array2[10] = 200;
						array2[11] = 153;
						array2[11] = 193;
						array2[11] = 155;
						array2[11] = 219;
						array2[12] = 88;
						array2[12] = 128;
						array2[12] = 66;
						array2[12] = 46;
						array2[12] = 84;
						array2[12] = 192;
						array2[13] = 38;
						array2[13] = 73;
						array2[13] = 58;
						array2[13] = 150;
						array2[13] = 27;
						array2[14] = 208;
						array2[14] = 134;
						array2[14] = 180;
						array2[15] = 125;
						array2[15] = 86;
						array2[15] = 10;
						array2[16] = 98;
						array2[16] = 201;
						array2[16] = 136;
						array2[17] = 74;
						array2[17] = 110;
						array2[17] = 66;
						array2[17] = 209;
						array2[18] = 128;
						array2[18] = 146;
						array2[18] = 145;
						array2[18] = 136;
						array2[18] = 17;
						array2[19] = 104;
						array2[19] = 153;
						array2[19] = 136;
						array2[19] = 131;
						array2[20] = 138;
						array2[20] = 70;
						array2[20] = 106;
						array2[20] = 113;
						array2[20] = 107;
						array2[21] = 185;
						array2[21] = 106;
						array2[21] = 168;
						array2[21] = 2;
						array2[22] = 84;
						array2[22] = 111;
						array2[22] = 174;
						array2[22] = 21;
						array2[23] = 187;
						array2[23] = 135;
						array2[23] = 115;
						array2[23] = 150;
						array2[23] = 213;
						array2[23] = 95;
						array2[24] = 160;
						array2[24] = 152;
						array2[24] = 105;
						array2[24] = 174;
						array2[24] = 178;
						array2[25] = 123;
						array2[25] = 100;
						array2[25] = 80;
						array2[25] = 91;
						array2[25] = 68;
						array2[26] = 114;
						array2[26] = 84;
						array2[26] = 177;
						array2[26] = 103;
						array2[26] = 156;
						array2[26] = 72;
						array2[27] = 96;
						array2[27] = 66;
						array2[27] = 80;
						array2[28] = 148;
						array2[28] = 122;
						array2[28] = 143;
						array2[28] = 120;
						array2[28] = 143;
						array2[28] = 141;
						array2[29] = 118;
						array2[29] = 145;
						array2[29] = 115;
						array2[29] = 185;
						array2[30] = 27;
						array2[30] = 129;
						array2[30] = 90;
						array2[30] = 103;
						array2[30] = 178;
						array2[30] = 149;
						array2[31] = 119;
						array2[31] = 100;
						array2[31] = 62;
						array2[31] = 92;
						array2[31] = 116;
						array2[31] = 159;
						byte[] rgbKey = array2;
						byte[] array3 = new byte[16];
						array3[0] = 113;
						array3[0] = 103;
						array3[0] = 49;
						array3[0] = 104;
						array3[1] = 160;
						array3[1] = 96;
						array3[1] = 140;
						array3[2] = 112;
						array3[2] = 107;
						array3[2] = 143;
						array3[2] = 127;
						array3[3] = 141;
						array3[3] = 167;
						array3[3] = 42;
						array3[4] = 212;
						array3[4] = 104;
						array3[4] = 130;
						array3[4] = 154;
						array3[4] = 117;
						array3[4] = 76;
						array3[5] = 170;
						array3[5] = 131;
						array3[5] = 152;
						array3[5] = 123;
						array3[5] = 249;
						array3[6] = 147;
						array3[6] = 119;
						array3[6] = 125;
						array3[6] = 168;
						array3[7] = 96;
						array3[7] = 92;
						array3[7] = 85;
						array3[7] = 137;
						array3[7] = 243;
						array3[8] = 99;
						array3[8] = 92;
						array3[8] = 114;
						array3[9] = 42;
						array3[9] = 168;
						array3[9] = 175;
						array3[9] = 106;
						array3[10] = 105;
						array3[10] = 166;
						array3[10] = 145;
						array3[11] = 116;
						array3[11] = 118;
						array3[11] = 17;
						array3[11] = 95;
						array3[12] = 63;
						array3[12] = 139;
						array3[12] = 97;
						array3[12] = 122;
						array3[12] = 65;
						array3[12] = 220;
						array3[13] = 90;
						array3[13] = 136;
						array3[13] = 119;
						array3[13] = 204;
						array3[14] = 147;
						array3[14] = 137;
						array3[14] = 47;
						array3[14] = 118;
						array3[15] = 117;
						array3[15] = 100;
						array3[15] = 91;
						array3[15] = 135;
						array3[15] = 13;
						byte[] rgbIV = array3;
						SymmetricAlgorithm symmetricAlgorithm = Class1.smethod_8();
						symmetricAlgorithm.Mode = CipherMode.CBC;
						ICryptoTransform transform = symmetricAlgorithm.CreateDecryptor(rgbKey, rgbIV);
						MemoryStream memoryStream = new MemoryStream();
						CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
						cryptoStream.Write(array, 0, array.Length);
						cryptoStream.FlushFinalBlock();
						byte[] array4 = memoryStream.ToArray();
						memoryStream.Close();
						cryptoStream.Close();
						binaryReader.Close();
						class20_0 = new Class20(1024);
						int int_ = 0;
						class20_0.class21_0 = new Class21(smethod_0(ref int_, array4));
						class20_0.class21_1 = new Class21(smethod_0(ref int_, array4));
						if (int_ < array4.Length - 1)
						{
							class20_0.class21_2 = new Class21(smethod_0(ref int_, array4));
							class20_0.class21_3 = new Class21(smethod_0(ref int_, array4));
							class20_0.class21_4 = new Class21(smethod_0(ref int_, array4));
							class20_0.class21_5 = new Class21(smethod_0(ref int_, array4));
							class20_0.class21_6 = new Class21(smethod_0(ref int_, array4));
							class20_0.class21_7 = new Class21(smethod_0(ref int_, array4));
						}
					}
				}
				catch
				{
				}
				if (byte_0 == null)
				{
					return false;
				}
				MemoryStream memoryStream2 = new MemoryStream(byte_0);
				BinaryReader binaryReader2 = new BinaryReader(memoryStream2);
				memoryStream2.Position = 0L;
				byte[] array5 = binaryReader2.ReadBytes(binaryReader2.ReadInt32());
				byte[] byte_ = binaryReader2.ReadBytes((int)(memoryStream2.Length - 4L - array5.Length));
				binaryReader2.Close();
				if (smethod_37(class20_0, byte_, array5))
				{
					return true;
				}
				return false;
			}
			catch
			{
				return false;
			}
		}

		internal bool method_1(byte[] byte_0)
		{
			try
			{
				MemoryStream memoryStream = new MemoryStream(byte_0);
				BinaryReader binaryReader = new BinaryReader(memoryStream);
				memoryStream.Position = 0L;
				byte[] array = binaryReader.ReadBytes(binaryReader.ReadInt32());
				byte[] array2 = binaryReader.ReadBytes((int)(memoryStream.Length - 4L - array.Length));
				binaryReader.Close();
				string @string = Encoding.Unicode.GetString(array2, 0, array2.Length);
				arrayList_0.Clear();
				hashtable_0.Clear();
				string[] array3 = @string.Split(new char[1] { '|' });
				for (int i = 0; i < array3.Length / 2; i++)
				{
					switch (array3[i * 2])
					{
					case "LicenseServerEnabled":
						bool_3 = method_2(array3[i * 2 + 1]);
						break;
					case "FloatingLicense":
						bool_4 = method_2(array3[i * 2 + 1]);
						break;
					case "FloatingLicenseHost":
						string_1 = method_4(array3[i * 2 + 1]);
						break;
					case "IntranetHost":
						string_2 = method_4(array3[i * 2 + 1]);
						break;
					case "Intranet":
						bool_5 = method_2(array3[i * 2 + 1]);
						break;
					case "R_License":
						bool_0 = method_2(array3[i * 2 + 1]);
						break;
					case "D_License":
						bool_1 = method_2(array3[i * 2 + 1]);
						break;
					case "H_D_License":
						bool_2 = method_2(array3[i * 2 + 1]);
						break;
					case "HardwareLock":
						bool_6 = method_2(array3[i * 2 + 1]);
						break;
					case "HDD":
						bool_7 = method_2(array3[i * 2 + 1]);
						break;
					case "CPU":
						bool_8 = method_2(array3[i * 2 + 1]);
						break;
					case "BIOS":
						bool_10 = method_2(array3[i * 2 + 1]);
						break;
					case "OS":
						bool_11 = method_2(array3[i * 2 + 1]);
						break;
					case "Individual":
						bool_12 = method_2(array3[i * 2 + 1]);
						break;
					case "FullVersion":
						bool_13 = method_2(array3[i * 2 + 1]);
						break;
					case "IndividualV":
						string_3 = method_4(array3[i * 2 + 1]);
						break;
					case "MAC":
						bool_9 = method_2(array3[i * 2 + 1]);
						break;
					case "Mainboard":
						bool_14 = method_2(array3[i * 2 + 1]);
						break;
					case "LicenseLocks":
						bool_15 = method_2(array3[i * 2 + 1]);
						break;
					case "Internal":
						bool_16 = method_2(array3[i * 2 + 1]);
						break;
					case "LicenseServer":
						string_4 = method_4(array3[i * 2 + 1]);
						break;
					case "LicenseServerPC":
						bool_17 = method_2(array3[i * 2 + 1]);
						break;
					case "LicenseServerPD":
						int_0 = method_3(array3[i * 2 + 1]);
						break;
					case "HardwareID":
						string_5 = method_4(array3[i * 2 + 1]);
						break;
					case "FloatingLicenseValue":
						int_1 = method_3(array3[i * 2 + 1]);
						break;
					case "ToleranceLevel":
						int_2 = method_3(array3[i * 2 + 1]);
						break;
					case "RequireVistaAdmin":
						bool_18 = method_2(array3[i * 2 + 1]);
						break;
					case "ExpirationDays":
						bool_19 = method_2(array3[i * 2 + 1]);
						break;
					case "ExpirationDays_Value":
						int_3 = method_3(array3[i * 2 + 1]);
						break;
					case "ExpirationDate":
						bool_20 = method_2(array3[i * 2 + 1]);
						break;
					case "ExpirationDate_Value":
						dateTime_0 = method_5(array3[i * 2 + 1]);
						break;
					case "Executions":
						bool_21 = method_2(array3[i * 2 + 1]);
						break;
					case "Executions_Value":
						int_4 = method_3(array3[i * 2 + 1]);
						break;
					case "Runtime":
						bool_22 = method_2(array3[i * 2 + 1]);
						break;
					case "Runtime_Value":
						int_5 = method_3(array3[i * 2 + 1]);
						break;
					case "GlobalTime":
						bool_23 = method_2(array3[i * 2 + 1]);
						break;
					case "GlobalTime_Value":
						int_6 = method_3(array3[i * 2 + 1]);
						break;
					case "Instances":
						bool_24 = method_2(array3[i * 2 + 1]);
						break;
					case "Instances_Value":
						int_7 = method_3(array3[i * 2 + 1]);
						break;
					case "Custom":
						bool_25 = method_2(array3[i * 2 + 1]);
						break;
					case "ExpirationBehaviourALL":
						bool_26 = method_2(array3[i * 2 + 1]);
						break;
					case "SearchInEmbeddedResources":
						bool_27 = method_2(array3[i * 2 + 1]);
						break;
					case "SearchOnHDD":
						bool_28 = method_2(array3[i * 2 + 1]);
						break;
					case "ShutdownProcess":
						bool_29 = method_2(array3[i * 2 + 1]);
						break;
					case "RunWithoutValidLicense":
						bool_30 = method_2(array3[i * 2 + 1]);
						break;
					case "Dialog_Days":
						bool_31 = method_2(array3[i * 2 + 1]);
						break;
					case "Dialog_Date":
						bool_32 = method_2(array3[i * 2 + 1]);
						break;
					case "Dialog_Executions":
						bool_33 = method_2(array3[i * 2 + 1]);
						break;
					case "Dialog_NoLicenseFound":
						bool_35 = method_2(array3[i * 2 + 1]);
						break;
					case "Dialog_Instances":
						bool_36 = method_2(array3[i * 2 + 1]);
						break;
					case "Dialog_Global":
						bool_37 = method_2(array3[i * 2 + 1]);
						break;
					case "Dialog_Nag":
						bool_38 = method_2(array3[i * 2 + 1]);
						break;
					case "Dialog_FLSConError":
						bool_39 = method_2(array3[i * 2 + 1]);
						break;
					case "Dialog_FLSExceeded":
						bool_41 = method_2(array3[i * 2 + 1]);
						break;
					case "Dialog_FLSConTimeout":
						bool_40 = method_2(array3[i * 2 + 1]);
						break;
					case "Dialog_Runtime":
						bool_34 = method_2(array3[i * 2 + 1]);
						break;
					case "Dialog_Days_Value":
						string_6 = method_4(array3[i * 2 + 1]);
						break;
					case "Dialog_Date_Value":
						string_7 = method_4(array3[i * 2 + 1]);
						break;
					case "Dialog_Executions_Value":
						string_8 = method_4(array3[i * 2 + 1]);
						break;
					case "Dialog_NoLicenseFound_Value":
						string_9 = method_4(array3[i * 2 + 1]);
						break;
					case "Dialog_Instances_Value":
						string_10 = method_4(array3[i * 2 + 1]);
						break;
					case "Dialog_Global_Value":
						string_11 = method_4(array3[i * 2 + 1]);
						break;
					case "Dialog_Nag_Value":
						string_13 = method_4(array3[i * 2 + 1]);
						break;
					case "Dialog_FLSConError_Value":
						string_14 = method_4(array3[i * 2 + 1]);
						break;
					case "Dialog_FLSConTimeout_Value":
						string_15 = method_4(array3[i * 2 + 1]);
						break;
					case "Dialog_FLSExceeded_Value":
						string_16 = method_4(array3[i * 2 + 1]);
						break;
					case "Dialog_Runtime_Value":
						string_12 = method_4(array3[i * 2 + 1]);
						break;
					case "Dialogs_Close":
						bool_42 = method_2(array3[i * 2 + 1]);
						break;
					case "Dialogs_CloseSeconds":
						int_8 = method_3(array3[i * 2 + 1]);
						break;
					case "Dialog_Box_Interface":
						string_17 = method_4(array3[i * 2 + 1]);
						break;
					case "LicenseName":
						string_18 = method_4(array3[i * 2 + 1]);
						break;
					case "KeyValueTable":
					{
						string text = method_4(array3[i * 2 + 1]);
						string[] array4 = text.Split(new char[1] { '|' });
						for (int j = 0; j < array4.Length / 2; j++)
						{
							hashtable_0.Add(array4[j * 2].Replace("ez&#02", "|"), array4[j * 2 + 1].Replace("ez&#02", "|"));
						}
						break;
					}
					}
				}
				if (bool_19 | bool_20 | bool_21 | bool_22 | bool_23 | bool_24)
				{
					bool_25 = false;
				}
			}
			catch
			{
				return false;
			}
			return true;
		}

		internal bool method_2(string string_19)
		{
			if (string_19 == "1")
			{
				return true;
			}
			return false;
		}

		internal int method_3(string string_19)
		{
			return Convert.ToInt32(string_19);
		}

		internal string method_4(string string_19)
		{
			if (string_19.Length != 0)
			{
				byte[] array = Convert.FromBase64String(string_19);
				return Encoding.Unicode.GetString(array, 0, array.Length).Trim();
			}
			return "";
		}

		internal DateTime method_5(string string_19)
		{
			string value = string_19.Substring(0, 4);
			string value2 = string_19.Substring(4, 2);
			string value3 = string_19.Substring(6, 2);
			return new DateTime(Convert.ToInt32(value), Convert.ToInt32(value2), Convert.ToInt32(value3));
		}
	}

	internal class Class7
	{
		private Class8 class8_0;

		public Class7(string string_0)
		{
			class8_0 = new Class8(string_0);
		}

		public byte[] method_0(byte[] byte_0)
		{
			return class8_0.Activate(byte_0);
		}
	}

	[GeneratedCode("wsdl", "2.0.50727.42")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[WebServiceBinding(Name = "ActivationServiceSoap", Namespace = "http://tempuri.org/")]
	internal class Class8 : SoapHttpClientProtocol
	{
		private SendOrPostCallback sendOrPostCallback_0;

		private Delegate0 delegate0_0;

		public event Delegate0 Event_0
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				delegate0_0 = (Delegate0)Delegate.Combine(delegate0_0, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				delegate0_0 = (Delegate0)Delegate.Remove(delegate0_0, value);
			}
		}

		public Class8(string string_0)
		{
			((WebClientProtocol)this).set_Url(string_0);
		}

		[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
		[return: XmlElement(DataType = "base64Binary")]
		public byte[] Activate([XmlElement(DataType = "base64Binary")] byte[] license)
		{
			object[] array = ((SoapHttpClientProtocol)this).Invoke("Activate", new object[1] { license });
			return (byte[])array[0];
		}

		public IAsyncResult method_0(byte[] byte_0, AsyncCallback asyncCallback_0, object object_0)
		{
			return ((SoapHttpClientProtocol)this).BeginInvoke("Activate", new object[1] { byte_0 }, asyncCallback_0, object_0);
		}

		public byte[] method_1(IAsyncResult iasyncResult_0)
		{
			object[] array = ((SoapHttpClientProtocol)this).EndInvoke(iasyncResult_0);
			return (byte[])array[0];
		}

		public void method_2(byte[] byte_0)
		{
			method_3(byte_0, null);
		}

		public void method_3(byte[] byte_0, object object_0)
		{
			if (sendOrPostCallback_0 == null)
			{
				sendOrPostCallback_0 = method_4;
			}
			((SoapHttpClientProtocol)this).InvokeAsync("Activate", new object[1] { byte_0 }, sendOrPostCallback_0, object_0);
		}

		private void method_4(object object_0)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			if (delegate0_0 != null)
			{
				InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)object_0;
				delegate0_0(this, new EventArgs0(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
			}
		}

		public void method_5(object object_0)
		{
			((HttpWebClientProtocol)this).CancelAsync(object_0);
		}
	}

	[GeneratedCode("wsdl", "2.0.50727.42")]
	internal delegate void Delegate0(object sender, EventArgs0 e);

	[DesignerCategory("code")]
	[DebuggerStepThrough]
	[GeneratedCode("wsdl", "2.0.50727.42")]
	internal class EventArgs0 : AsyncCompletedEventArgs
	{
		private object[] object_0;

		internal EventArgs0(object[] object_1, Exception exception_0, bool bool_0, object object_2)
			: base(exception_0, bool_0, object_2)
		{
			object_0 = object_1;
		}

		[SpecialName]
		public byte[] method_0()
		{
			RaiseExceptionIfNecessary();
			return (byte[])object_0[0];
		}
	}

	private class Class9
	{
		internal static System.Threading.Timer timer_0;

		private static bool bool_0;

		private static object object_0;

		internal static void smethod_0(object object_1)
		{
			lock (object_0)
			{
				if (!bool_0 && bool_5)
				{
					bool_0 = true;
					smethod_13(bool_16: true);
					smethod_1();
				}
			}
		}

		public static void smethod_1()
		{
			if (timer_0 != null)
			{
				timer_0.Dispose();
			}
			timer_0 = null;
		}

		static Class9()
		{
			bool_0 = false;
			object_0 = new object();
		}
	}

	private class Class10
	{
		internal static Class10 class10_0;

		internal System.Threading.Timer timer_0;

		private ulong ulong_0;

		private byte[] byte_0;

		private int int_0;

		private string string_0;

		private DateTime dateTime_0;

		private Guid guid_0;

		private int int_1;

		private Class6 class6_0;

		internal static void smethod_0(Class6 class6_1)
		{
			if (class6_1.bool_40)
			{
				string string_ = class6_1.string_15;
				if (class6_1.bool_29)
				{
					if (bool_6)
					{
						Class14.timer_0 = new System.Threading.Timer(new Class14().method_0, null, Class3.int_1, 30000);
					}
					try
					{
						EnableWindow(Process.GetCurrentProcess().MainWindowHandle, bool_16: false);
					}
					catch
					{
					}
				}
				ShowMessage(string_);
			}
			if (class6_1.bool_29)
			{
				try
				{
					TerminateProcess(GetCurrentProcess(), 1);
				}
				catch
				{
				}
			}
		}

		public Class10(ulong ulong_1, byte[] byte_1, Guid guid_1, int int_2, string string_1, int int_3, Class6 class6_1)
		{
			ulong_0 = ulong_1;
			byte_0 = byte_1;
			guid_0 = guid_1;
			int_0 = int_2;
			string_0 = string_1;
			int_1 = int_3;
			class6_0 = class6_1;
			dateTime_0 = DateTime.Now;
		}

		public void method_0()
		{
			if (timer_0 != null)
			{
				timer_0.Dispose();
			}
			class10_0 = null;
		}

		internal void method_1(object object_0)
		{
			if ((DateTime.Now - dateTime_0).TotalSeconds > (double)int_0)
			{
				if (Class27.smethod_4().method_10() == LicenseLocation.HDD)
				{
					Class27.smethod_4().method_9(LicenseStatus.FloatingLicenseServerTimeout);
				}
				if (Class27.smethod_4().method_10() == LicenseLocation.ExternalAssembly)
				{
					Class27.smethod_4().method_7(LicenseStatus.FloatingLicenseServerTimeout);
				}
				method_0();
				Class27.smethod_0();
				smethod_0(class6_0);
				return;
			}
			try
			{
				byte[] bytes = BitConverter.GetBytes(ulong_0);
				Random random = new Random();
				byte[] array = new byte[8];
				random.NextBytes(array);
				byte[] array2 = new byte[33 + byte_0.Length];
				array2[0] = 1;
				Array.Copy(bytes, 0, array2, 1, 8);
				Array.Copy(array, 0, array2, 9, 8);
				Array.Copy(guid_0.ToByteArray(), 0, array2, 17, 16);
				Array.Copy(byte_0, 0, array2, 33, byte_0.Length);
				Class7 @class = new Class7(string_0);
				byte[] array3 = @class.method_0(array2);
				if (array3 != null && array3.Length >= 8)
				{
					byte[] array4 = new byte[0];
					SymmetricAlgorithm symmetricAlgorithm = Class1.smethod_8();
					symmetricAlgorithm.Mode = CipherMode.CBC;
					ICryptoTransform transform = symmetricAlgorithm.CreateDecryptor(byte_1, byte_2);
					MemoryStream memoryStream = new MemoryStream();
					CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
					cryptoStream.Write(array3, 0, array3.Length);
					cryptoStream.FlushFinalBlock();
					array4 = memoryStream.ToArray();
					memoryStream.Close();
					cryptoStream.Close();
					if (array4 != null && array4.Length == 8 && smethod_6(array4, array, 0, 0, 8))
					{
						dateTime_0 = DateTime.Now;
					}
				}
			}
			catch
			{
			}
		}
	}

	private class Class11
	{
		internal static Class11 class11_0;

		internal System.Threading.Timer timer_0;

		private ulong ulong_0;

		private byte[] byte_0;

		private int int_0;

		private string string_0;

		private DateTime dateTime_0;

		private Guid guid_0;

		private int int_1;

		private hKbV0NIkrxmjDtgaD7cJbeLP hKbV0NIkrxmjDtgaD7cJbeLP_0;

		private Class6 class6_0;

		private ChannelFactory<hKbV0NIkrxmjDtgaD7cJbeLP> channelFactory_0;

		private bool bool_0;

		public Class11(ulong ulong_1, byte[] byte_1, Guid guid_1, int int_2, string string_1, int int_3, Class6 class6_1, hKbV0NIkrxmjDtgaD7cJbeLP hKbV0NIkrxmjDtgaD7cJbeLP_1, ChannelFactory<hKbV0NIkrxmjDtgaD7cJbeLP> _factory)
		{
			ulong_0 = ulong_1;
			byte_0 = byte_1;
			guid_0 = guid_1;
			int_0 = int_2;
			string_0 = string_1;
			int_1 = int_3;
			class6_0 = class6_1;
			hKbV0NIkrxmjDtgaD7cJbeLP_0 = hKbV0NIkrxmjDtgaD7cJbeLP_1;
			dateTime_0 = DateTime.Now;
			channelFactory_0 = _factory;
		}

		public void method_0()
		{
			if (timer_0 != null)
			{
				timer_0.Dispose();
			}
			class11_0 = null;
		}

		internal void method_1()
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Invalid comparison between Unknown and I4
			IChannel val = null;
			try
			{
				if (hKbV0NIkrxmjDtgaD7cJbeLP_0 != null)
				{
					val = (IChannel)hKbV0NIkrxmjDtgaD7cJbeLP_0;
					if ((int)((ICommunicationObject)val).get_State() != 5)
					{
						((ICommunicationObject)val).Close();
					}
					else
					{
						((ICommunicationObject)val).Abort();
					}
				}
			}
			catch (CommunicationException)
			{
				if (val != null)
				{
					((ICommunicationObject)val).Abort();
				}
			}
			catch (TimeoutException)
			{
				if (val != null)
				{
					((ICommunicationObject)val).Abort();
				}
			}
			catch (Exception)
			{
				if (val != null)
				{
					((ICommunicationObject)val).Abort();
				}
			}
			finally
			{
				hKbV0NIkrxmjDtgaD7cJbeLP_0 = null;
			}
		}

		internal void method_2()
		{
			bool_0 = true;
			try
			{
				hKbV0NIkrxmjDtgaD7cJbeLP_0 = channelFactory_0.CreateChannel();
			}
			catch
			{
			}
			bool_0 = false;
		}

		internal void method_3(object object_0)
		{
			if ((DateTime.Now - dateTime_0).TotalSeconds > (double)int_0)
			{
				if (Class27.smethod_4().method_10() == LicenseLocation.HDD)
				{
					Class27.smethod_4().method_9(LicenseStatus.FloatingLicenseServerTimeout);
				}
				if (Class27.smethod_4().method_10() == LicenseLocation.ExternalAssembly)
				{
					Class27.smethod_4().method_7(LicenseStatus.FloatingLicenseServerTimeout);
				}
				method_0();
				Class27.smethod_0();
				Class10.smethod_0(class6_0);
			}
			else
			{
				if (bool_0)
				{
					return;
				}
				if (hKbV0NIkrxmjDtgaD7cJbeLP_0 == null)
				{
					method_2();
				}
				if (hKbV0NIkrxmjDtgaD7cJbeLP_0 == null)
				{
					return;
				}
				try
				{
					byte[] bytes = BitConverter.GetBytes(ulong_0);
					Random random = new Random();
					byte[] array = new byte[8];
					random.NextBytes(array);
					byte[] array2 = new byte[33 + byte_0.Length];
					if (object_0 is bool && (bool)object_0)
					{
						array2[0] = 2;
					}
					else
					{
						array2[0] = 1;
					}
					Array.Copy(bytes, 0, array2, 1, 8);
					Array.Copy(array, 0, array2, 9, 8);
					Array.Copy(guid_0.ToByteArray(), 0, array2, 17, 16);
					Array.Copy(byte_0, 0, array2, 33, byte_0.Length);
					byte[] array3 = hKbV0NIkrxmjDtgaD7cJbeLP_0.EIGwTGOrLkVIf0FnPhJw9iR(array2);
					if (array3 == null || array3.Length < 8)
					{
						return;
					}
					byte[] buffer = array3;
					if (Class6.smethod_1(buffer))
					{
						MemoryStream memoryStream = new MemoryStream(buffer);
						BinaryReader binaryReader = new BinaryReader(memoryStream);
						memoryStream.Position = 0L;
						byte[] array4 = binaryReader.ReadBytes(binaryReader.ReadInt32());
						byte[] byte_ = binaryReader.ReadBytes((int)(memoryStream.Length - 4L - array4.Length));
						binaryReader.Close();
						if (smethod_6(array, byte_, 0, 0, 8) && smethod_6(guid_0.ToByteArray(), byte_, 0, 8, 16))
						{
							dateTime_0 = DateTime.Now;
						}
					}
				}
				catch
				{
					try
					{
						method_1();
						method_2();
					}
					catch
					{
					}
				}
			}
		}
	}

	private class Class12
	{
		internal int int_0;

		internal int int_1;
	}

	private class Class13
	{
		internal static Class13 class13_0;

		internal System.Threading.Timer timer_0;

		internal Class12 class12_0;

		private bool bool_0;

		private Class6 class6_0;

		private Assembly assembly_0;

		public Class13(Class6 class6_1, Assembly assembly_1)
		{
			assembly_0 = assembly_1;
			class6_0 = class6_1;
		}

		public void method_0()
		{
			if (timer_0 != null)
			{
				timer_0.Dispose();
			}
			class13_0 = null;
		}

		internal void method_1(object object_0)
		{
			try
			{
				timer_0.Dispose();
			}
			catch
			{
			}
			if (!bool_0)
			{
				class12_0.int_1++;
				bool_0 = true;
			}
			try
			{
				if ((!class6_0.bool_26 || class12_0.int_0 > class12_0.int_1) && (class6_0.bool_26 || class12_0.int_1 <= 0))
				{
					return;
				}
				if (class6_0 != null && class6_0.bool_13)
				{
					Class27.smethod_4().method_5(LicenseStatus.FullVersionExpired);
				}
				else
				{
					Class27.smethod_4().method_5(LicenseStatus.EvaluationExpired);
				}
				if (Class27.smethod_4().method_10() == LicenseLocation.HDD)
				{
					Class27.smethod_4().method_9(Class27.smethod_4().method_4());
				}
				if (Class27.smethod_4().method_10() == LicenseLocation.ExternalAssembly)
				{
					Class27.smethod_4().method_7(Class27.smethod_4().method_4());
				}
				if (class6_0.bool_34)
				{
					if (bool_6)
					{
						Class14.timer_0 = new System.Threading.Timer(new Class14().method_0, null, int_1, 30000);
					}
					if (class6_0.bool_29)
					{
						try
						{
							EnableWindow(Process.GetCurrentProcess().MainWindowHandle, bool_16: false);
						}
						catch
						{
						}
					}
					string string_ = class6_0.string_12;
					ShowMessage(string_);
				}
				if (class6_0.bool_29)
				{
					try
					{
						TerminateProcess(GetCurrentProcess(), 1);
						return;
					}
					catch
					{
						return;
					}
				}
			}
			catch
			{
			}
		}
	}

	private class Class14
	{
		internal static System.Threading.Timer timer_0;

		internal void method_0(object object_0)
		{
			timer_0.Dispose();
			try
			{
				TerminateProcess(GetCurrentProcess(), 1);
			}
			catch
			{
			}
		}
	}

	private class Class15
	{
		internal static Class15 class15_0;

		internal System.Threading.Timer timer_0;

		internal Class12 class12_0;

		private bool bool_0;

		private Class6 class6_0;

		private Class5 class5_0;

		private Type type_0;

		private byte[] byte_0 = new byte[0];

		private byte[] byte_1 = new byte[0];

		public Class15(Class6 class6_1, Class5 class5_1, Type type_1, byte[] byte_2, byte[] byte_3)
		{
			class6_0 = class6_1;
			class5_0 = class5_1;
			type_0 = type_1;
			byte_0 = byte_2;
			byte_1 = byte_3;
		}

		public void method_0()
		{
			if (timer_0 != null)
			{
				timer_0.Dispose();
			}
			class15_0 = null;
		}

		internal void method_1(object object_0)
		{
			lock (Class3.object_0)
			{
				if (DateTime.Compare(DateTime.Now, class5_0.dateTime_0) >= 0)
				{
					class5_0.dateTime_0 = DateTime.Now;
					smethod_21(ref class5_0, type_0, bool_16: true, null);
				}
				if (!(class5_0.dateTime_0 >= class6_0.dateTime_0))
				{
					return;
				}
				if (!bool_0)
				{
					class12_0.int_1++;
					bool_0 = true;
				}
				if ((!class6_0.bool_26 || class12_0.int_0 > class12_0.int_1) && (class6_0.bool_26 || class12_0.int_1 <= 0))
				{
					return;
				}
				try
				{
					if (class6_0 != null && class6_0.bool_13)
					{
						Class27.smethod_4().method_5(LicenseStatus.FullVersionExpired);
					}
					else
					{
						Class27.smethod_4().method_5(LicenseStatus.EvaluationExpired);
					}
					if (Class27.smethod_4().method_10() == LicenseLocation.HDD)
					{
						Class27.smethod_4().method_9(Class27.smethod_4().method_4());
					}
					if (Class27.smethod_4().method_10() == LicenseLocation.ExternalAssembly)
					{
						Class27.smethod_4().method_7(Class27.smethod_4().method_4());
					}
					timer_0.Dispose();
					if (class6_0.bool_32)
					{
						string string_ = class6_0.string_7;
						string_ = string_.Replace(Class4.string_18, class6_0.dateTime_0.ToString());
						string_ = string_.Replace(Class4.string_19, DateTime.Now.ToString());
						if (class6_0.bool_29)
						{
							if (bool_6)
							{
								Class14.timer_0 = new System.Threading.Timer(new Class14().method_0, null, int_1, 30000);
							}
							try
							{
								EnableWindow(Process.GetCurrentProcess().MainWindowHandle, bool_16: false);
							}
							catch
							{
							}
						}
						ShowMessage(string_);
					}
					if (class6_0.bool_29)
					{
						try
						{
							TerminateProcess(GetCurrentProcess(), 1);
							return;
						}
						catch
						{
							return;
						}
					}
				}
				catch
				{
				}
			}
		}
	}

	private class Class16
	{
		internal static Class16 class16_0;

		internal System.Threading.Timer timer_0;

		private Class6 class6_0;

		private Class5 class5_0;

		internal Class12 class12_0;

		private bool bool_0;

		private Type type_0;

		private byte[] byte_0 = new byte[0];

		private byte[] byte_1 = new byte[0];

		public Class16(Class6 class6_1, Class5 class5_1, Type type_1, byte[] byte_2, byte[] byte_3)
		{
			class6_0 = class6_1;
			class5_0 = class5_1;
			type_0 = type_1;
			byte_0 = byte_2;
			byte_1 = byte_3;
		}

		public void method_0()
		{
			if (timer_0 != null)
			{
				timer_0.Dispose();
			}
			class16_0 = null;
		}

		internal void method_1(object object_0)
		{
			lock (Class3.object_0)
			{
				int int_ = class5_0.int_2;
				if (int_ != class5_0.int_2 + Math.Abs(DateTime.Now.Subtract(class5_0.dateTime_1).Days))
				{
					if (DateTime.Now.CompareTo(class5_0.dateTime_1) > 0)
					{
						class5_0.int_2 += Math.Abs(DateTime.Now.Subtract(class5_0.dateTime_1).Days);
					}
					DateTime dateTime_ = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
					class5_0.dateTime_1 = dateTime_;
					Class27.smethod_4().method_19(class5_0.int_2);
					smethod_21(ref class5_0, type_0, bool_16: true, null);
				}
				if (class5_0.int_2 <= class6_0.int_3)
				{
					return;
				}
				if (!bool_0)
				{
					class12_0.int_1++;
					bool_0 = true;
				}
				if ((!class6_0.bool_26 || class12_0.int_0 > class12_0.int_1) && (class6_0.bool_26 || class12_0.int_1 <= 0))
				{
					return;
				}
				try
				{
					if (class6_0 != null && class6_0.bool_13)
					{
						Class27.smethod_4().method_5(LicenseStatus.FullVersionExpired);
					}
					else
					{
						Class27.smethod_4().method_5(LicenseStatus.EvaluationExpired);
					}
					if (Class27.smethod_4().method_10() == LicenseLocation.HDD)
					{
						Class27.smethod_4().method_9(Class27.smethod_4().method_4());
					}
					if (Class27.smethod_4().method_10() == LicenseLocation.ExternalAssembly)
					{
						Class27.smethod_4().method_7(Class27.smethod_4().method_4());
					}
					timer_0.Dispose();
					if (class6_0.bool_31)
					{
						int num = class6_0.int_3 - class5_0.int_2;
						if (num < 0)
						{
							num = 0;
						}
						string string_ = class6_0.string_6;
						string_ = string_.Replace(Class4.string_14, class5_0.int_2.ToString());
						string_ = string_.Replace(Class4.string_17, class6_0.int_3.ToString());
						string_ = string_.Replace(Class4.string_15, num.ToString());
						if (class6_0.bool_29)
						{
							if (bool_6)
							{
								Class14.timer_0 = new System.Threading.Timer(new Class14().method_0, null, int_1, 30000);
							}
							try
							{
								EnableWindow(Process.GetCurrentProcess().MainWindowHandle, bool_16: false);
							}
							catch
							{
							}
						}
						ShowMessage(string_);
					}
					if (class6_0.bool_29)
					{
						try
						{
							TerminateProcess(GetCurrentProcess(), 1);
							return;
						}
						catch
						{
							return;
						}
					}
				}
				catch
				{
				}
			}
		}
	}

	private class Class17
	{
		internal static Class17 class17_0;

		internal System.Threading.Timer timer_0;

		private Class6 class6_0;

		private Class5 class5_0;

		internal Class12 class12_0;

		private bool bool_0;

		private Type type_0;

		private byte[] byte_0 = new byte[0];

		private byte[] byte_1 = new byte[0];

		public void method_0()
		{
			if (timer_0 != null)
			{
				timer_0.Dispose();
			}
			class17_0 = null;
		}

		public Class17(Class6 class6_1, Class5 class5_1, Type type_1, byte[] byte_2, byte[] byte_3)
		{
			class6_0 = class6_1;
			class5_0 = class5_1;
			type_0 = type_1;
			byte_0 = byte_2;
			byte_1 = byte_3;
		}

		internal void method_1(object object_0)
		{
			lock (Class3.object_0)
			{
				class5_0.int_1++;
				Class27.smethod_4().method_29(class5_0.int_1);
				smethod_21(ref class5_0, type_0, bool_16: true, null);
				if (class5_0.int_1 < class6_0.int_6)
				{
					return;
				}
				if (!bool_0)
				{
					class12_0.int_1++;
					bool_0 = true;
				}
				if ((!class6_0.bool_26 || class12_0.int_0 > class12_0.int_1) && (class6_0.bool_26 || class12_0.int_1 <= 0))
				{
					return;
				}
				if (class6_0 != null && class6_0.bool_13)
				{
					Class27.smethod_4().method_5(LicenseStatus.FullVersionExpired);
				}
				else
				{
					Class27.smethod_4().method_5(LicenseStatus.EvaluationExpired);
				}
				if (Class27.smethod_4().method_10() == LicenseLocation.HDD)
				{
					Class27.smethod_4().method_9(Class27.smethod_4().method_4());
				}
				if (Class27.smethod_4().method_10() == LicenseLocation.ExternalAssembly)
				{
					Class27.smethod_4().method_7(Class27.smethod_4().method_4());
				}
				timer_0.Dispose();
				if (class6_0.bool_37)
				{
					int num = class6_0.int_6 - class5_0.int_1;
					if (num < 0)
					{
						num = 0;
					}
					string string_ = class6_0.string_11;
					string_ = string_.Replace(Class4.string_24, class5_0.int_1.ToString());
					string_ = string_.Replace(Class4.string_25, class6_0.int_6.ToString());
					string_ = string_.Replace(Class4.string_16, num.ToString());
					if (class6_0.bool_29)
					{
						if (bool_6)
						{
							Class14.timer_0 = new System.Threading.Timer(new Class14().method_0, null, int_1, 30000);
						}
						try
						{
							EnableWindow(Process.GetCurrentProcess().MainWindowHandle, bool_16: false);
						}
						catch
						{
						}
					}
					ShowMessage(string_);
				}
				if (class6_0.bool_29)
				{
					try
					{
						TerminateProcess(GetCurrentProcess(), 1);
						return;
					}
					catch
					{
						return;
					}
				}
			}
		}
	}

	[LicenseProvider(typeof(Class3))]
	private class Class18
	{
		private void method_0()
		{
			LicenseManager.Validate(typeof(Class3));
		}
	}

	private class Class19 : License
	{
		private object object_0;

		private string string_0;

		public override string LicenseKey => string_0;

		public Class19(object object_1, string string_1)
		{
			object_0 = object_1;
			string_0 = string_1;
		}

		public override void Dispose()
		{
		}
	}

	internal struct Struct1
	{
		public IntPtr intptr_0;

		public int int_0;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string string_0;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 132)]
		public string string_1;

		public uint uint_0;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public byte[] byte_0;

		public int int_1;

		public uint uint_1;

		public uint uint_2;

		public IntPtr intptr_1;

		public Struct2 struct2_0;

		public Struct2 struct2_1;

		public Struct2 struct2_2;

		public bool bool_0;

		public Struct2 struct2_3;

		public Struct2 struct2_4;

		public int int_2;

		public int int_3;
	}

	internal struct Struct2
	{
		public IntPtr intptr_0;

		public Struct3 struct3_0;

		public Struct3 struct3_1;

		public int int_0;
	}

	internal struct Struct3
	{
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public string string_0;
	}

	internal class Class20 : RSA
	{
		private const int int_0 = 1;

		private const int int_1 = 2;

		internal static byte[] byte_0;

		internal int int_2;

		internal Class21 class21_0;

		internal Class21 class21_1;

		internal Class21 class21_2;

		internal Class21 class21_3;

		internal Class21 class21_4;

		internal Class21 class21_5;

		internal Class21 class21_6;

		internal Class21 class21_7;

		public override string KeyExchangeAlgorithm => "RSA-PKCS1-KeyEx";

		public override string SignatureAlgorithm => "http://www.w3.org/2000/09/xmldsig#rsa-sha1";

		public override int KeySize
		{
			get
			{
				return int_2 * 8;
			}
			set
			{
				throw new ArgumentException();
			}
		}

		public Class20()
		{
			int_2 = 256;
		}

		public Class20(int int_3)
		{
			int_2 = int_3 / 8;
		}

		public override void FromXmlString(string xmlString)
		{
			StringReader input = new StringReader(xmlString);
			XmlTextReader xmlTextReader = new XmlTextReader(input);
			class21_0 = (class21_1 = (class21_2 = (class21_3 = (class21_4 = (class21_5 = (class21_6 = (class21_7 = null)))))));
			while (true)
			{
				switch (xmlTextReader.MoveToContent())
				{
				case XmlNodeType.Element:
				{
					string name = xmlTextReader.Name;
					if (!method_6(xmlTextReader, name, "Modulus", ref class21_0) && !method_6(xmlTextReader, name, "Exponent", ref class21_1) && !method_6(xmlTextReader, name, "P", ref class21_2) && !method_6(xmlTextReader, name, "Q", ref class21_3) && !method_6(xmlTextReader, name, "DP", ref class21_4) && !method_6(xmlTextReader, name, "DQ", ref class21_5) && !method_6(xmlTextReader, name, "InverseQ", ref class21_6) && !method_6(xmlTextReader, name, "D", ref class21_7))
					{
						xmlTextReader.ReadString();
					}
					break;
				}
				case XmlNodeType.EndElement:
					xmlTextReader.ReadEndElement();
					break;
				default:
					throw new ArgumentException();
				case XmlNodeType.None:
					return;
				}
			}
		}

		public override void ImportParameters(RSAParameters parameters)
		{
			class21_0 = new Class21(parameters.Modulus);
			class21_1 = new Class21(parameters.Exponent);
			class21_2 = ((!object.ReferenceEquals(parameters.P, null)) ? new Class21(parameters.P) : null);
			class21_3 = ((!object.ReferenceEquals(parameters.Q, null)) ? new Class21(parameters.Q) : null);
			class21_4 = ((!object.ReferenceEquals(parameters.DP, null)) ? new Class21(parameters.DP) : null);
			class21_5 = ((!object.ReferenceEquals(parameters.DQ, null)) ? new Class21(parameters.DQ) : null);
			class21_6 = ((!object.ReferenceEquals(parameters.InverseQ, null)) ? new Class21(parameters.InverseQ) : null);
			class21_7 = ((!object.ReferenceEquals(parameters.D, null)) ? new Class21(parameters.D) : null);
		}

		public override RSAParameters ExportParameters(bool includePrivateParameters)
		{
			RSAParameters result = default(RSAParameters);
			result.Modulus = class21_0.method_2();
			result.Exponent = class21_1.method_2();
			if (includePrivateParameters)
			{
				result.P = class21_2.method_2();
				result.Q = class21_3.method_2();
				result.DP = class21_4.method_2();
				result.DQ = class21_5.method_2();
				result.InverseQ = class21_6.method_2();
				result.D = class21_7.method_2();
			}
			return result;
		}

		public byte[] method_0(byte[] byte_1)
		{
			if (byte_1.Length != int_2)
			{
				throw new ArgumentException("input.Length does not match keylen");
			}
			if (object.ReferenceEquals(class21_0, null))
			{
				throw new ArgumentException("no key set!");
			}
			Class21 @class = new Class21(byte_1);
			if (@class >= class21_0)
			{
				throw new ArgumentException("input exceeds modulus");
			}
			@class = @class.method_7(class21_1, class21_0);
			byte[] byte_2 = @class.method_2();
			return method_5(byte_2, int_2);
		}

		public byte[] method_1(byte[] byte_1)
		{
			if (byte_1.Length != int_2)
			{
				throw new ArgumentException("input.Length does not match keylen");
			}
			if (object.ReferenceEquals(class21_7, null))
			{
				throw new ArgumentException("no private key set!");
			}
			Class21 @class = new Class21(byte_1);
			if (@class >= class21_0)
			{
				throw new ArgumentException("input exceeds modulus");
			}
			@class = @class.method_7(class21_7, class21_0);
			byte[] byte_2 = @class.method_2();
			return method_5(byte_2, int_2);
		}

		public bool method_2(byte[] byte_1, byte[] byte_2)
		{
			int num = byte_2.Length;
			if (num != int_2)
			{
				return false;
			}
			byte[] array = method_0(byte_2);
			if (array[0] == 0 && array[1] == 1)
			{
				int num2 = array.Length;
				for (int i = 2; i < num2 - 1; i++)
				{
					switch (array[i])
					{
					case byte.MaxValue:
						continue;
					case 0:
					{
						i++;
						int num3 = num2 - i;
						if (num3 == 34)
						{
							if (array[i + 13] != 5)
							{
								return false;
							}
							array[i + 13] = 0;
							if (!method_4(array, i, byte_0, 0, 18))
							{
								return false;
							}
							return method_4(array, i + 18, byte_1, 0, 16);
						}
						return false;
					}
					}
					break;
				}
				return false;
			}
			return false;
		}

		public bool method_3(byte[] byte_1, byte[] byte_2)
		{
			byte[] byte_3 = Class1.smethod_9(byte_1);
			return method_2(byte_3, byte_2);
		}

		public override byte[] EncryptValue(byte[] rgb)
		{
			return method_0(rgb);
		}

		public override byte[] DecryptValue(byte[] rgb)
		{
			return method_1(rgb);
		}

		protected override void Dispose(bool disposing)
		{
			class21_0 = (class21_1 = (class21_2 = (class21_3 = (class21_4 = (class21_5 = (class21_6 = (class21_7 = null)))))));
		}

		private bool method_4(byte[] byte_1, int int_3, byte[] byte_2, int int_4, int int_5)
		{
			int num = 0;
			while (true)
			{
				if (num < int_5)
				{
					if (byte_1[num + int_3] != byte_2[num + int_4])
					{
						break;
					}
					num++;
					continue;
				}
				return true;
			}
			return false;
		}

		internal byte[] method_5(byte[] byte_1, int int_3)
		{
			int num = byte_1.Length;
			if (num >= int_3)
			{
				return byte_1;
			}
			byte[] array = new byte[int_3];
			int num2 = int_3 - num;
			for (int i = 0; i < num2; i++)
			{
				array[i] = 0;
			}
			Array.Copy(byte_1, 0, array, num2, num);
			return array;
		}

		private bool method_6(XmlReader xmlReader_0, string string_0, string string_1, ref Class21 class21_8)
		{
			if (string.Compare(string_0, string_1, ignoreCase: true) != 0)
			{
				return false;
			}
			string s = xmlReader_0.ReadString();
			byte[] array = Convert.FromBase64String(s);
			Class21 @class = (class21_8 = new Class21(array));
			return true;
		}

		static Class20()
		{
			byte_0 = new byte[18]
			{
				48, 32, 48, 12, 6, 8, 42, 134, 72, 134,
				247, 13, 2, 0, 5, 0, 4, 16
			};
		}
	}

	internal class Class21
	{
		internal enum Enum1
		{

		}

		private sealed class Class22
		{
			private Class21 class21_0;

			private Class21 class21_1;

			public Class22(Class21 class21_2)
			{
				class21_0 = class21_2;
				uint num = class21_0.uint_0 << 1;
				class21_1 = new Class21((Enum1)1, num + 1);
				class21_1.uint_1[num] = 1u;
				class21_1 /= class21_0;
			}

			public void method_0(Class21 class21_2)
			{
				Class21 @class = class21_0;
				uint uint_ = @class.uint_0;
				uint num = uint_ + 1;
				uint num2 = uint_ - 1;
				if (class21_2.uint_0 >= uint_)
				{
					if (class21_2.uint_1.Length < class21_2.uint_0)
					{
						throw new IndexOutOfRangeException("x out of range");
					}
					Class21 class2 = new Class21((Enum1)1, class21_2.uint_0 - num2 + class21_1.uint_0);
					Class23.smethod_13(class21_2.uint_1, num2, class21_2.uint_0 - num2, class21_1.uint_1, 0u, class21_1.uint_0, class2.uint_1, 0u);
					uint num3 = (class21_2.uint_0 = ((class21_2.uint_0 > num) ? num : class21_2.uint_0));
					class21_2.method_5();
					Class21 class3 = new Class21((Enum1)1, num);
					Class23.smethod_14(class2.uint_1, (int)num, (int)(class2.uint_0 - num), @class.uint_1, 0, (int)@class.uint_0, class3.uint_1, 0, (int)num);
					class3.method_5();
					if (class3 <= class21_2)
					{
						Class23.smethod_2(class21_2, class3);
					}
					else
					{
						Class21 class4 = new Class21((Enum1)1, num + 1);
						class4.uint_1[num] = 1u;
						Class23.smethod_2(class4, class3);
						Class23.smethod_3(class21_2, class4);
					}
					while (class21_2 >= @class)
					{
						Class23.smethod_2(class21_2, @class);
					}
				}
			}

			public Class21 method_1(Class21 class21_2, Class21 class21_3)
			{
				if (!(class21_2 == 0u) && !(class21_3 == 0u))
				{
					if (class21_2 > class21_0)
					{
						class21_2 %= class21_0;
					}
					if (class21_3 > class21_0)
					{
						class21_3 %= class21_0;
					}
					Class21 @class = class21_2 * class21_3;
					method_0(@class);
					return @class;
				}
				return 0;
			}

			public Class21 method_2(Class21 class21_2, Class21 class21_3)
			{
				Enum1 @enum = Class23.smethod_4(class21_2, class21_3);
				Class21 @class;
				switch (@enum)
				{
				default:
					throw new Exception();
				case (Enum1)(-1):
					@class = class21_3 - class21_2;
					break;
				case (Enum1)0:
					return 0;
				case (Enum1)1:
					@class = class21_2 - class21_3;
					break;
				}
				if (@class >= class21_0)
				{
					if (@class.uint_0 >= class21_0.uint_0 << 1)
					{
						@class %= class21_0;
					}
					else
					{
						method_0(@class);
					}
				}
				if (@enum == (Enum1)(-1))
				{
					@class = class21_0 - @class;
				}
				return @class;
			}

			public Class21 method_3(Class21 class21_2, Class21 class21_3)
			{
				Class21 @class = new Class21(1u);
				if (class21_3 == 0u)
				{
					return @class;
				}
				Class21 class2 = class21_2;
				if (class21_3.method_1(0))
				{
					@class = class21_2;
				}
				for (int i = 1; i < class21_3.method_0(); i++)
				{
					class2 = method_1(class2, class2);
					if (class21_3.method_1(i))
					{
						@class = method_1(class2, @class);
					}
				}
				return @class;
			}

			public Class21 method_4(uint uint_0, Class21 class21_2)
			{
				return method_3(new Class21(uint_0), class21_2);
			}
		}

		private sealed class Class23
		{
			public static Class21 smethod_0(Class21 class21_0, Class21 class21_1)
			{
				uint num = 0u;
				uint[] uint_;
				uint uint_2;
				uint[] uint_3;
				uint uint_4;
				if (class21_0.uint_0 < class21_1.uint_0)
				{
					uint_ = class21_1.uint_1;
					uint_2 = class21_1.uint_0;
					uint_3 = class21_0.uint_1;
					uint_4 = class21_0.uint_0;
				}
				else
				{
					uint_ = class21_0.uint_1;
					uint_2 = class21_0.uint_0;
					uint_3 = class21_1.uint_1;
					uint_4 = class21_1.uint_0;
				}
				Class21 @class = new Class21((Enum1)1, uint_2 + 1);
				uint[] uint_5 = @class.uint_1;
				ulong num2 = 0uL;
				do
				{
					num2 = (ulong)((long)uint_[num] + (long)uint_3[num]) + num2;
					uint_5[num] = (uint)num2;
					num2 >>= 32;
				}
				while (++num < uint_4);
				bool flag;
				if (flag = num2 != 0L)
				{
					if (num < uint_2)
					{
						do
						{
							flag = (uint_5[num] = uint_[num] + 1) == 0;
						}
						while (++num < uint_2 && flag);
					}
					if (flag)
					{
						uint_5[num] = 1u;
						num = (@class.uint_0 = num + 1);
						return @class;
					}
				}
				if (num < uint_2)
				{
					do
					{
						uint_5[num] = uint_[num];
					}
					while (++num < uint_2);
				}
				@class.method_5();
				return @class;
			}

			public static Class21 smethod_1(Class21 class21_0, Class21 class21_1)
			{
				Class21 @class = new Class21((Enum1)1, class21_0.uint_0);
				uint[] uint_ = @class.uint_1;
				uint[] uint_2 = class21_0.uint_1;
				uint[] uint_3 = class21_1.uint_1;
				uint num = 0u;
				uint num2 = 0u;
				do
				{
					uint num3 = uint_3[num];
					num2 = ((((num3 += num2) < num2) | ((uint_[num] = uint_2[num] - num3) > ~num3)) ? 1u : 0u);
				}
				while (++num < class21_1.uint_0);
				if (num != class21_0.uint_0)
				{
					if (num2 == 1)
					{
						do
						{
							uint_[num] = uint_2[num] - 1;
						}
						while (uint_2[num++] == 0 && num < class21_0.uint_0);
						if (num == class21_0.uint_0)
						{
							goto IL_00c8;
						}
					}
					do
					{
						uint_[num] = uint_2[num];
					}
					while (++num < class21_0.uint_0);
				}
				goto IL_00c8;
				IL_00c8:
				@class.method_5();
				return @class;
			}

			public static void smethod_2(Class21 class21_0, Class21 class21_1)
			{
				uint[] uint_ = class21_0.uint_1;
				uint[] uint_2 = class21_1.uint_1;
				uint num = 0u;
				uint num2 = 0u;
				do
				{
					uint num3 = uint_2[num];
					num2 = ((((num3 += num2) < num2) | ((uint_[num] -= num3) > ~num3)) ? 1u : 0u);
				}
				while (++num < class21_1.uint_0);
				if (num != class21_0.uint_0 && num2 == 1)
				{
					do
					{
						uint_[num]--;
					}
					while (uint_[num++] == 0 && num < class21_0.uint_0);
				}
				while (class21_0.uint_0 != 0 && class21_0.uint_1[class21_0.uint_0 - 1] == 0)
				{
					class21_0.uint_0--;
				}
				if (class21_0.uint_0 == 0)
				{
					class21_0.uint_0++;
				}
			}

			public static void smethod_3(Class21 class21_0, Class21 class21_1)
			{
				uint num = 0u;
				bool flag = false;
				uint[] uint_;
				uint uint_2;
				uint[] uint_3;
				uint uint_4;
				if (class21_0.uint_0 < class21_1.uint_0)
				{
					flag = true;
					uint_ = class21_1.uint_1;
					uint_2 = class21_1.uint_0;
					uint_3 = class21_0.uint_1;
					uint_4 = class21_0.uint_0;
				}
				else
				{
					uint_ = class21_0.uint_1;
					uint_2 = class21_0.uint_0;
					uint_3 = class21_1.uint_1;
					uint_4 = class21_1.uint_0;
				}
				uint[] uint_5 = class21_0.uint_1;
				ulong num2 = 0uL;
				do
				{
					num2 += (ulong)((long)uint_[num] + (long)uint_3[num]);
					uint_5[num] = (uint)num2;
					num2 >>= 32;
				}
				while (++num < uint_4);
				bool flag2;
				if (flag2 = num2 != 0L)
				{
					if (num < uint_2)
					{
						do
						{
							flag2 = (uint_5[num] = uint_[num] + 1) == 0;
						}
						while (++num < uint_2 && flag2);
					}
					if (flag2)
					{
						uint_5[num] = 1u;
						num = (class21_0.uint_0 = num + 1);
						return;
					}
				}
				if (flag && num < uint_2 - 1)
				{
					do
					{
						uint_5[num] = uint_[num];
					}
					while (++num < uint_2);
				}
				class21_0.uint_0 = uint_2 + 1;
				class21_0.method_5();
			}

			public static Enum1 smethod_4(Class21 class21_0, Class21 class21_1)
			{
				uint num = class21_0.uint_0;
				uint num2 = class21_1.uint_0;
				while (num != 0 && class21_0.uint_1[num - 1] == 0)
				{
					num--;
				}
				while (num2 != 0 && class21_1.uint_1[num2 - 1] == 0)
				{
					num2--;
				}
				if (num == 0 && num2 == 0)
				{
					return (Enum1)0;
				}
				if (num < num2)
				{
					return (Enum1)(-1);
				}
				if (num > num2)
				{
					return (Enum1)1;
				}
				uint num3 = num - 1;
				while (num3 != 0 && class21_0.uint_1[num3] == class21_1.uint_1[num3])
				{
					num3--;
				}
				if (class21_0.uint_1[num3] < class21_1.uint_1[num3])
				{
					return (Enum1)(-1);
				}
				if (class21_0.uint_1[num3] > class21_1.uint_1[num3])
				{
					return (Enum1)1;
				}
				return (Enum1)0;
			}

			public static uint smethod_5(Class21 class21_0, uint uint_0)
			{
				ulong num = 0uL;
				uint uint_ = class21_0.uint_0;
				while (uint_-- != 0)
				{
					num <<= 32;
					num |= class21_0.uint_1[uint_];
					class21_0.uint_1[uint_] = (uint)(num / uint_0);
					num %= uint_0;
				}
				class21_0.method_5();
				return (uint)num;
			}

			public static uint smethod_6(Class21 class21_0, uint uint_0)
			{
				ulong num = 0uL;
				uint uint_ = class21_0.uint_0;
				while (uint_-- != 0)
				{
					num <<= 32;
					num |= class21_0.uint_1[uint_];
					num %= uint_0;
				}
				return (uint)num;
			}

			public static Class21 smethod_7(Class21 class21_0, uint uint_0)
			{
				Class21 @class = new Class21((Enum1)1, class21_0.uint_0);
				ulong num = 0uL;
				uint uint_ = class21_0.uint_0;
				while (uint_-- != 0)
				{
					num <<= 32;
					num |= class21_0.uint_1[uint_];
					@class.uint_1[uint_] = (uint)(num / uint_0);
					num %= uint_0;
				}
				@class.method_5();
				return @class;
			}

			public static Class21[] smethod_8(Class21 class21_0, uint uint_0)
			{
				Class21 @class = new Class21((Enum1)1, class21_0.uint_0);
				ulong num = 0uL;
				uint uint_ = class21_0.uint_0;
				while (uint_-- != 0)
				{
					num <<= 32;
					num |= class21_0.uint_1[uint_];
					@class.uint_1[uint_] = (uint)(num / uint_0);
					num %= uint_0;
				}
				@class.method_5();
				Class21 class2 = (uint)num;
				return new Class21[2] { @class, class2 };
			}

			public static Class21[] smethod_9(Class21 class21_0, Class21 class21_1)
			{
				if (smethod_4(class21_0, class21_1) == (Enum1)(-1))
				{
					return new Class21[2]
					{
						0,
						new Class21(class21_0)
					};
				}
				class21_0.method_5();
				class21_1.method_5();
				if (class21_1.uint_0 == 1)
				{
					return smethod_8(class21_0, class21_1.uint_1[0]);
				}
				uint num = class21_0.uint_0 + 1;
				int num2 = (int)(class21_1.uint_0 + 1);
				uint num3 = 2147483648u;
				uint num4 = class21_1.uint_1[class21_1.uint_0 - 1];
				int num5 = 0;
				int num6 = (int)(class21_0.uint_0 - class21_1.uint_0);
				while (num3 != 0 && (num4 & num3) == 0)
				{
					num5++;
					num3 >>= 1;
				}
				Class21 @class = new Class21((Enum1)1, class21_0.uint_0 - class21_1.uint_0 + 1);
				Class21 class2 = class21_0 << num5;
				uint[] uint_ = class2.uint_1;
				class21_1 <<= num5;
				int num7 = (int)(num - class21_1.uint_0);
				int num8 = (int)(num - 1);
				uint num9 = class21_1.uint_1[class21_1.uint_0 - 1];
				ulong num10 = class21_1.uint_1[class21_1.uint_0 - 2];
				while (num7 > 0)
				{
					ulong num11 = ((ulong)uint_[num8] << 32) + uint_[num8 - 1];
					ulong num12 = num11 / num9;
					ulong num13 = num11 % num9;
					while (num12 == 4294967296L || num12 * num10 > (num13 << 32) + uint_[num8 - 2])
					{
						num12--;
						num13 += num9;
						if (num13 >= 4294967296L)
						{
							break;
						}
					}
					uint num14 = 0u;
					int num15 = num8 - num2 + 1;
					ulong num16 = 0uL;
					uint num17 = (uint)num12;
					do
					{
						num16 += (ulong)((long)class21_1.uint_1[num14] * (long)num17);
						uint num18 = uint_[num15];
						uint_[num15] -= (uint)(int)num16;
						num16 >>= 32;
						if (uint_[num15] > num18)
						{
							num16++;
						}
						num14++;
						num15++;
					}
					while (num14 < num2);
					num15 = num8 - num2 + 1;
					num14 = 0u;
					if (num16 != 0L)
					{
						num17--;
						ulong num19 = 0uL;
						do
						{
							num19 = (ulong)((long)uint_[num15] + (long)class21_1.uint_1[num14]) + num19;
							uint_[num15] = (uint)num19;
							num19 >>= 32;
							num14++;
							num15++;
						}
						while (num14 < num2);
					}
					@class.uint_1[num6--] = num17;
					num8--;
					num7--;
				}
				@class.method_5();
				class2.method_5();
				Class21[] array = new Class21[2] { @class, class2 };
				if (num5 != 0)
				{
					Class21[] array2;
					(array2 = array)[1] = array2[1] >> num5;
				}
				return array;
			}

			public static Class21 smethod_10(Class21 class21_0, int int_0)
			{
				if (int_0 == 0)
				{
					return new Class21(class21_0, class21_0.uint_0 + 1);
				}
				int num = int_0 >> 5;
				int_0 &= 0x1F;
				Class21 @class = new Class21((Enum1)1, class21_0.uint_0 + 1 + (uint)num);
				uint num2 = 0u;
				uint uint_ = class21_0.uint_0;
				if (int_0 != 0)
				{
					uint num3 = 0u;
					for (; num2 < uint_; num2++)
					{
						uint num4 = class21_0.uint_1[num2];
						@class.uint_1[num2 + num] = (num4 << int_0) | num3;
						num3 = num4 >> 32 - int_0;
					}
					@class.uint_1[num2 + num] = num3;
				}
				else
				{
					for (; num2 < uint_; num2++)
					{
						@class.uint_1[num2 + num] = class21_0.uint_1[num2];
					}
				}
				@class.method_5();
				return @class;
			}

			public static Class21 smethod_11(Class21 class21_0, int int_0)
			{
				if (int_0 == 0)
				{
					return new Class21(class21_0);
				}
				int num = int_0 >> 5;
				int num2 = int_0 & 0x1F;
				Class21 @class = new Class21((Enum1)1, (uint)((int)class21_0.uint_0 - num + 1));
				uint num3 = (uint)(@class.uint_1.Length - 1);
				if (num2 != 0)
				{
					uint num4 = 0u;
					while (num3-- != 0)
					{
						uint num5 = class21_0.uint_1[num3 + num];
						@class.uint_1[num3] = (num5 >> int_0) | num4;
						num4 = num5 << 32 - int_0;
					}
				}
				else
				{
					while (num3-- != 0)
					{
						@class.uint_1[num3] = class21_0.uint_1[num3 + num];
					}
				}
				@class.method_5();
				return @class;
			}

			public static Class21 smethod_12(Class21 class21_0, uint uint_0)
			{
				Class21 @class = new Class21((Enum1)1, class21_0.uint_0 + 1);
				uint num = 0u;
				ulong num2 = 0uL;
				do
				{
					num2 += (ulong)((long)class21_0.uint_1[num] * (long)uint_0);
					@class.uint_1[num] = (uint)num2;
					num2 >>= 32;
				}
				while (++num < class21_0.uint_0);
				@class.uint_1[num] = (uint)num2;
				@class.method_5();
				return @class;
			}

			public static void smethod_13(uint[] uint_0, uint uint_1, uint uint_2, uint[] uint_3, uint uint_4, uint uint_5, uint[] uint_6, uint uint_7)
			{
				uint num = uint_1;
				uint num2 = num + uint_2;
				uint num3 = uint_4 + uint_5;
				uint num4 = uint_7;
				while (num < num2)
				{
					if (uint_0[num] != 0)
					{
						ulong num5 = 0uL;
						uint num6 = num4;
						uint num7 = uint_4;
						while (num7 < num3)
						{
							num5 += (ulong)((long)uint_0[num] * (long)uint_3[num7] + uint_6[num6]);
							uint_6[num6] = (uint)num5;
							num5 >>= 32;
							num7++;
							num6++;
						}
						if (num5 != 0L)
						{
							uint_6[num6] = (uint)num5;
						}
					}
					num++;
					num4++;
				}
			}

			public static void smethod_14(uint[] uint_0, int int_0, int int_1, uint[] uint_1, int int_2, int int_3, uint[] uint_2, int int_4, int int_5)
			{
				uint num = (uint)int_0;
				uint num2 = num + (uint)int_1;
				uint num3 = (uint)(int_2 + int_3);
				uint num4 = (uint)int_4;
				uint num5 = num4 + (uint)int_5;
				while (num < num2)
				{
					if (uint_0[num] != 0)
					{
						ulong num6 = 0uL;
						uint num7 = num4;
						uint num8 = (uint)int_2;
						while (num8 < num3 && num7 < num5)
						{
							num6 += (ulong)((long)uint_0[num] * (long)uint_1[num8] + uint_2[num7]);
							uint_2[num7] = (uint)num6;
							num6 >>= 32;
							num8++;
							num7++;
						}
						if (num6 != 0L && num7 < num5)
						{
							uint_2[num7] = (uint)num6;
						}
					}
					num++;
					num4++;
				}
			}

			public static Class21 smethod_15(Class21 class21_0, Class21 class21_1)
			{
				Class21 @class = class21_0;
				Class21 class2 = class21_1;
				Class21 class3 = class2;
				while (@class.uint_0 > 1)
				{
					class3 = @class;
					@class = class2 % @class;
					class2 = class3;
				}
				if (@class == 0u)
				{
					return class3;
				}
				uint num = @class.uint_1[0];
				uint num2 = class2 % num;
				int num3 = 0;
				while (((num2 | num) & 1) == 0)
				{
					num2 >>= 1;
					num >>= 1;
					num3++;
				}
				while (num2 != 0)
				{
					while ((num2 & 1) == 0)
					{
						num2 >>= 1;
					}
					while ((num & 1) == 0)
					{
						num >>= 1;
					}
					if (num2 >= num)
					{
						num2 = num2 - num >> 1;
					}
					else
					{
						num = num - num2 >> 1;
					}
				}
				return num << num3;
			}

			public static uint smethod_16(Class21 class21_0, uint uint_0)
			{
				uint num = uint_0;
				uint num2 = class21_0 % uint_0;
				uint num3 = 0u;
				uint num4 = 1u;
				while (true)
				{
					switch (num2)
					{
					default:
						num3 += num / num2 * num4;
						num %= num2;
						switch (num)
						{
						default:
							goto IL_002b;
						case 1u:
							return uint_0 - num3;
						case 0u:
							break;
						}
						break;
					case 1u:
						return num4;
					case 0u:
						break;
					}
					break;
					IL_002b:
					num4 += num2 / num * num3;
					num2 %= num;
				}
				return 0u;
			}

			public static Class21 smethod_17(Class21 class21_0, Class21 class21_1)
			{
				if (class21_1.uint_0 == 1)
				{
					return smethod_16(class21_0, class21_1.uint_1[0]);
				}
				Class21[] array = new Class21[2] { 0, 1 };
				Class21[] array2 = new Class21[2];
				Class21[] array3 = new Class21[2] { 0, 0 };
				int num = 0;
				Class21 class21_2 = class21_1;
				Class21 @class = class21_0;
				Class22 class2 = new Class22(class21_1);
				while (@class != 0u)
				{
					if (num > 1)
					{
						Class21 class3 = class2.method_2(array[0], array[1] * array2[0]);
						array[0] = array[1];
						array[1] = class3;
					}
					Class21[] array4 = smethod_9(class21_2, @class);
					array2[0] = array2[1];
					array2[1] = array4[0];
					array3[0] = array3[1];
					array3[1] = array4[1];
					class21_2 = @class;
					@class = array4[1];
					num++;
				}
				if (array3[0] != 1u)
				{
					throw new ArithmeticException("No inverse!");
				}
				return class2.method_2(array[0], array[1] * array2[0]);
			}
		}

		private uint uint_0 = 1u;

		private uint[] uint_1;

		public Class21(Enum1 enum1_0, uint uint_2)
		{
			uint_1 = new uint[uint_2];
			uint_0 = uint_2;
		}

		public Class21(Class21 class21_0)
		{
			uint_1 = (uint[])class21_0.uint_1.Clone();
			uint_0 = class21_0.uint_0;
		}

		public Class21(Class21 class21_0, uint uint_2)
		{
			uint_1 = new uint[uint_2];
			for (uint num = 0u; num < class21_0.uint_0; num++)
			{
				uint_1[num] = class21_0.uint_1[num];
			}
			uint_0 = class21_0.uint_0;
		}

		public Class21(byte[] byte_0)
		{
			uint_0 = (uint)byte_0.Length >> 2;
			int num = byte_0.Length & 3;
			if (num != 0)
			{
				uint_0++;
			}
			uint_1 = new uint[uint_0];
			int num2 = byte_0.Length - 1;
			int num3 = 0;
			while (num2 >= 3)
			{
				uint_1[num3] = (uint)((byte_0[num2 - 3] << 24) | (byte_0[num2 - 2] << 16) | (byte_0[num2 - 1] << 8) | byte_0[num2]);
				num2 -= 4;
				num3++;
			}
			switch (num)
			{
			case 1:
				uint_1[uint_0 - 1] = byte_0[0];
				break;
			case 2:
				uint_1[uint_0 - 1] = (uint)((byte_0[0] << 8) | byte_0[1]);
				break;
			case 3:
				uint_1[uint_0 - 1] = (uint)((byte_0[0] << 16) | (byte_0[1] << 8) | byte_0[2]);
				break;
			}
			method_5();
		}

		public Class21(uint uint_2)
		{
			uint_1 = new uint[1] { uint_2 };
		}

		public Class21(ulong ulong_0)
		{
			uint_1 = new uint[2]
			{
				(uint)ulong_0,
				(uint)(ulong_0 >> 32)
			};
			uint_0 = 2u;
			method_5();
		}

		public static implicit operator Class21(uint uint_2)
		{
			return new Class21(uint_2);
		}

		public static implicit operator Class21(int int_0)
		{
			if (int_0 < 0)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			return new Class21((uint)int_0);
		}

		public static implicit operator Class21(ulong ulong_0)
		{
			return new Class21(ulong_0);
		}

		public static Class21 operator +(Class21 class21_0, Class21 class21_1)
		{
			if (class21_0 == 0u)
			{
				return new Class21(class21_1);
			}
			if (class21_1 == 0u)
			{
				return new Class21(class21_0);
			}
			return Class23.smethod_0(class21_0, class21_1);
		}

		public static Class21 operator -(Class21 class21_0, Class21 class21_1)
		{
			if (class21_1 == 0u)
			{
				return new Class21(class21_0);
			}
			if (class21_0 == 0u)
			{
				throw new ArithmeticException();
			}
			return Class23.smethod_4(class21_0, class21_1) switch
			{
				(Enum1)(-1) => throw new ArithmeticException(), 
				(Enum1)0 => 0, 
				(Enum1)1 => Class23.smethod_1(class21_0, class21_1), 
				_ => throw new Exception(), 
			};
		}

		public static int operator %(Class21 class21_0, int int_0)
		{
			if (int_0 > 0)
			{
				return (int)Class23.smethod_6(class21_0, (uint)int_0);
			}
			return (int)(0 - Class23.smethod_6(class21_0, (uint)(-int_0)));
		}

		public static uint operator %(Class21 class21_0, uint uint_2)
		{
			return Class23.smethod_6(class21_0, uint_2);
		}

		public static Class21 operator %(Class21 class21_0, Class21 class21_1)
		{
			return Class23.smethod_9(class21_0, class21_1)[1];
		}

		public static Class21 operator /(Class21 class21_0, int int_0)
		{
			if (int_0 <= 0)
			{
				throw new ArithmeticException();
			}
			return Class23.smethod_7(class21_0, (uint)int_0);
		}

		public static Class21 operator /(Class21 class21_0, Class21 class21_1)
		{
			return Class23.smethod_9(class21_0, class21_1)[0];
		}

		public static Class21 operator *(Class21 class21_0, Class21 class21_1)
		{
			if (!(class21_0 == 0u) && !(class21_1 == 0u))
			{
				if (class21_0.uint_1.Length < class21_0.uint_0)
				{
					throw new IndexOutOfRangeException("bi1 out of range");
				}
				if (class21_1.uint_1.Length < class21_1.uint_0)
				{
					throw new IndexOutOfRangeException("bi2 out of range");
				}
				Class21 @class = new Class21((Enum1)1, class21_0.uint_0 + class21_1.uint_0);
				Class23.smethod_13(class21_0.uint_1, 0u, class21_0.uint_0, class21_1.uint_1, 0u, class21_1.uint_0, @class.uint_1, 0u);
				@class.method_5();
				return @class;
			}
			return 0;
		}

		public static Class21 operator *(Class21 class21_0, int int_0)
		{
			if (int_0 < 0)
			{
				throw new ArithmeticException();
			}
			return int_0 switch
			{
				0 => 0, 
				1 => new Class21(class21_0), 
				_ => Class23.smethod_12(class21_0, (uint)int_0), 
			};
		}

		public static Class21 operator <<(Class21 class21_0, int int_0)
		{
			return Class23.smethod_10(class21_0, int_0);
		}

		public static Class21 operator >>(Class21 class21_0, int int_0)
		{
			return Class23.smethod_11(class21_0, int_0);
		}

		public int method_0()
		{
			method_5();
			uint num = uint_1[uint_0 - 1];
			uint num2 = 2147483648u;
			uint num3 = 32u;
			while (num3 != 0 && (num & num2) == 0)
			{
				num3--;
				num2 >>= 1;
			}
			return (int)(num3 + (uint_0 - 1 << 5));
		}

		public bool method_1(int int_0)
		{
			if (int_0 < 0)
			{
				throw new IndexOutOfRangeException("bitNum out of range");
			}
			uint num = (uint)int_0 >> 5;
			byte b = (byte)((uint)int_0 & 0x1Fu);
			uint num2 = (uint)(1 << (int)b);
			return (uint_1[num] | num2) == uint_1[num];
		}

		public byte[] method_2()
		{
			return method_3();
		}

		public byte[] method_3()
		{
			if (this == 0u)
			{
				return new byte[1];
			}
			int num = method_0();
			int num2 = num >> 3;
			if (((uint)num & 7u) != 0)
			{
				num2++;
			}
			byte[] array = new byte[num2];
			int num3 = num2 & 3;
			if (num3 == 0)
			{
				num3 = 4;
			}
			int num4 = 0;
			for (int num5 = (int)(uint_0 - 1); num5 >= 0; num5--)
			{
				uint num6 = uint_1[num5];
				for (int num7 = num3 - 1; num7 >= 0; num7--)
				{
					array[num4 + num7] = (byte)(num6 & 0xFFu);
					num6 >>= 8;
				}
				num4 += num3;
				num3 = 4;
			}
			return array;
		}

		public static bool operator ==(Class21 class21_0, uint uint_2)
		{
			if (class21_0.uint_0 != 1)
			{
				class21_0.method_5();
			}
			if (class21_0.uint_0 == 1)
			{
				return class21_0.uint_1[0] == uint_2;
			}
			return false;
		}

		public static bool operator !=(Class21 class21_0, uint uint_2)
		{
			if (class21_0.uint_0 != 1)
			{
				class21_0.method_5();
			}
			if (class21_0.uint_0 == 1)
			{
				return class21_0.uint_1[0] != uint_2;
			}
			return true;
		}

		public static bool operator ==(Class21 class21_0, Class21 class21_1)
		{
			if ((object)class21_0 == class21_1)
			{
				return true;
			}
			if (!(null == class21_0) && !(null == class21_1))
			{
				return Class23.smethod_4(class21_0, class21_1) == (Enum1)0;
			}
			return false;
		}

		public static bool operator !=(Class21 class21_0, Class21 class21_1)
		{
			if ((object)class21_0 == class21_1)
			{
				return false;
			}
			if (!(null == class21_0) && !(null == class21_1))
			{
				return Class23.smethod_4(class21_0, class21_1) != (Enum1)0;
			}
			return true;
		}

		public static bool operator >(Class21 class21_0, Class21 class21_1)
		{
			return Class23.smethod_4(class21_0, class21_1) > (Enum1)0;
		}

		public static bool operator <(Class21 class21_0, Class21 class21_1)
		{
			return Class23.smethod_4(class21_0, class21_1) < (Enum1)0;
		}

		public static bool operator >=(Class21 class21_0, Class21 class21_1)
		{
			return Class23.smethod_4(class21_0, class21_1) >= (Enum1)0;
		}

		public static bool operator <=(Class21 class21_0, Class21 class21_1)
		{
			return Class23.smethod_4(class21_0, class21_1) <= (Enum1)0;
		}

		public Enum1 method_4(Class21 class21_0)
		{
			return Class23.smethod_4(this, class21_0);
		}

		private void method_5()
		{
			while (uint_0 != 0 && uint_1[uint_0 - 1] == 0)
			{
				uint_0--;
			}
			if (uint_0 == 0)
			{
				uint_0++;
			}
		}

		public override int GetHashCode()
		{
			uint num = 0u;
			for (uint num2 = 0u; num2 < uint_0; num2++)
			{
				num ^= uint_1[num2];
			}
			return (int)num;
		}

		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			if (obj is int)
			{
				if ((int)obj >= 0)
				{
					return this == (uint)obj;
				}
				return false;
			}
			Class21 @class = obj as Class21;
			if (@class == null)
			{
				return false;
			}
			return Class23.smethod_4(this, @class) == (Enum1)0;
		}

		public Class21 method_6(Class21 class21_0)
		{
			return Class23.smethod_15(this, class21_0);
		}

		public Class21 method_7(Class21 class21_0, Class21 class21_1)
		{
			Class22 @class = new Class22(class21_1);
			return @class.method_3(this, class21_0);
		}
	}

	private const int int_0 = 1718264361;

	private const double double_0 = 4.656612873077393E-10;

	private const double double_1 = 2.3283064365386963E-10;

	private const uint uint_0 = 842502087u;

	private const uint uint_1 = 3579807591u;

	private const uint uint_2 = 273326509u;

	private const uint uint_3 = 1073741824u;

	private const uint uint_4 = 2147483648u;

	private const uint uint_5 = 1u;

	private const uint uint_6 = 2u;

	private const uint uint_7 = 1u;

	private const uint uint_8 = 2u;

	private const uint uint_9 = 3u;

	private const uint uint_10 = 4u;

	internal static object object_0;

	internal static object object_1;

	private static SortedList sortedList_0;

	private static SortedList sortedList_1;

	private static bool bool_0;

	private static bool bool_1;

	internal static byte[] byte_0;

	private uint uint_11;

	private uint uint_12;

	private uint uint_13;

	private uint uint_14;

	private uint uint_15;

	private uint uint_16 = 1u;

	internal static byte[] byte_1;

	internal static byte[] byte_2;

	internal static string string_0;

	internal static string string_1;

	private static System.Timers.Timer timer_0;

	private static DateTime dateTime_0;

	private static byte[] byte_3;

	private static bool bool_2;

	private static string string_2;

	private static string string_3;

	private static string string_4;

	private static string string_5;

	private static bool bool_3;

	private static bool bool_4;

	private static object object_2;

	private static bool bool_5;

	internal static bool bool_6;

	internal static int int_1;

	private static string string_6;

	internal static string string_7;

	internal static string string_8;

	private static string string_9;

	private static bool bool_7;

	private static string string_10;

	private static bool bool_8;

	private static string string_11;

	private static bool bool_9;

	private static string string_12;

	private static bool bool_10;

	private static string string_13;

	private static bool bool_11;

	private static string string_14;

	private static bool bool_12;

	private static string string_15;

	private static bool bool_13;

	private static string string_16;

	private static bool bool_14;

	private static string string_17;

	private static bool bool_15;

	static Class3()
	{
		object_0 = new object();
		object_1 = new object();
		sortedList_0 = new SortedList();
		sortedList_1 = new SortedList();
		bool_0 = false;
		bool_1 = false;
		byte_0 = new byte[0];
		byte[] array = new byte[32];
		array[0] = 118;
		array[0] = 65;
		array[0] = 188;
		array[0] = 49;
		array[1] = 145;
		array[1] = 160;
		array[1] = 162;
		array[2] = 113;
		array[2] = 161;
		array[2] = 130;
		array[2] = 150;
		array[2] = 227;
		array[3] = 180;
		array[3] = 126;
		array[3] = 108;
		array[3] = 136;
		array[3] = 90;
		array[3] = 155;
		array[4] = 28;
		array[4] = 124;
		array[4] = 96;
		array[4] = 144;
		array[4] = 201;
		array[4] = 96;
		array[5] = 128;
		array[5] = 91;
		array[5] = 51;
		array[6] = 110;
		array[6] = 138;
		array[6] = 85;
		array[6] = 45;
		array[6] = 13;
		array[7] = 97;
		array[7] = 88;
		array[7] = 140;
		array[7] = 153;
		array[7] = 120;
		array[7] = 250;
		array[8] = 164;
		array[8] = 100;
		array[8] = 110;
		array[8] = 158;
		array[8] = 108;
		array[8] = 51;
		array[9] = 103;
		array[9] = 124;
		array[9] = 140;
		array[9] = 117;
		array[9] = 92;
		array[9] = 53;
		array[10] = 89;
		array[10] = 116;
		array[10] = 142;
		array[11] = 147;
		array[11] = 41;
		array[11] = 101;
		array[11] = 12;
		array[12] = 148;
		array[12] = 74;
		array[12] = 145;
		array[12] = 1;
		array[13] = 99;
		array[13] = 162;
		array[13] = 114;
		array[13] = 19;
		array[14] = 86;
		array[14] = 65;
		array[14] = 148;
		array[14] = 208;
		array[15] = 107;
		array[15] = 109;
		array[15] = 115;
		array[15] = 162;
		array[15] = 142;
		array[16] = 102;
		array[16] = 196;
		array[16] = 106;
		array[16] = 96;
		array[17] = 76;
		array[17] = 154;
		array[17] = 135;
		array[18] = 75;
		array[18] = 142;
		array[18] = 116;
		array[18] = 111;
		array[18] = 122;
		array[18] = 248;
		array[19] = 94;
		array[19] = 155;
		array[19] = 147;
		array[19] = 70;
		array[19] = 101;
		array[19] = 205;
		array[20] = 173;
		array[20] = 67;
		array[20] = 136;
		array[20] = 153;
		array[20] = 93;
		array[20] = 71;
		array[21] = 127;
		array[21] = 143;
		array[21] = 164;
		array[22] = 65;
		array[22] = 127;
		array[22] = 166;
		array[22] = 117;
		array[23] = 86;
		array[23] = 86;
		array[23] = 146;
		array[23] = 166;
		array[23] = 128;
		array[23] = 88;
		array[24] = 128;
		array[24] = 122;
		array[24] = 79;
		array[24] = 52;
		array[25] = 104;
		array[25] = 133;
		array[25] = 121;
		array[25] = 61;
		array[25] = 171;
		array[26] = 23;
		array[26] = 132;
		array[26] = 120;
		array[26] = 162;
		array[26] = 180;
		array[26] = 57;
		array[27] = 114;
		array[27] = 134;
		array[27] = 92;
		array[27] = 170;
		array[27] = 134;
		array[27] = 73;
		array[28] = 135;
		array[28] = 145;
		array[28] = 64;
		array[29] = 207;
		array[29] = 109;
		array[29] = 123;
		array[29] = 138;
		array[30] = 110;
		array[30] = 138;
		array[30] = 158;
		array[30] = 104;
		array[30] = byte.MaxValue;
		array[31] = 90;
		array[31] = 25;
		array[31] = 81;
		array[31] = 124;
		array[31] = 29;
		byte_1 = array;
		byte[] array2 = new byte[16];
		array2[0] = 100;
		array2[0] = 105;
		array2[0] = 159;
		array2[0] = 109;
		array2[1] = 162;
		array2[1] = 128;
		array2[1] = 79;
		array2[1] = 139;
		array2[1] = 167;
		array2[1] = 186;
		array2[2] = 150;
		array2[2] = 123;
		array2[2] = 87;
		array2[2] = 141;
		array2[2] = 88;
		array2[2] = 39;
		array2[3] = 164;
		array2[3] = 167;
		array2[3] = 153;
		array2[3] = 60;
		array2[3] = 96;
		array2[4] = 134;
		array2[4] = 195;
		array2[4] = 177;
		array2[4] = 140;
		array2[4] = 4;
		array2[5] = 106;
		array2[5] = 141;
		array2[5] = 95;
		array2[5] = 129;
		array2[5] = 128;
		array2[6] = 157;
		array2[6] = 123;
		array2[6] = 224;
		array2[7] = 126;
		array2[7] = 140;
		array2[7] = 89;
		array2[8] = 158;
		array2[8] = 121;
		array2[8] = 151;
		array2[8] = 93;
		array2[8] = 129;
		array2[9] = 190;
		array2[9] = 92;
		array2[9] = 200;
		array2[10] = 229;
		array2[10] = 120;
		array2[10] = 203;
		array2[10] = 129;
		array2[10] = 60;
		array2[11] = 208;
		array2[11] = 101;
		array2[11] = 154;
		array2[11] = 129;
		array2[11] = 8;
		array2[12] = 127;
		array2[12] = 128;
		array2[12] = 111;
		array2[12] = 225;
		array2[13] = 107;
		array2[13] = 114;
		array2[13] = 120;
		array2[13] = 75;
		array2[14] = 132;
		array2[14] = 107;
		array2[14] = 100;
		array2[14] = 159;
		array2[14] = 27;
		array2[15] = 211;
		array2[15] = 112;
		array2[15] = 168;
		array2[15] = 92;
		array2[15] = 143;
		array2[15] = 167;
		byte_2 = array2;
		string_0 = "";
		string_1 = "";
		byte_3 = new byte[0];
		bool_2 = false;
		string_2 = string.Empty;
		string_3 = string.Empty;
		string_4 = string.Empty;
		string_5 = string.Empty;
		bool_3 = false;
		bool_4 = false;
		object_2 = new object();
		bool_5 = false;
		bool_6 = false;
		int_1 = -1;
		string_6 = null;
		string_7 = "";
		string_8 = "";
		string_9 = "";
		bool_7 = false;
		string_10 = "";
		bool_8 = false;
		string_11 = "";
		bool_9 = false;
		string_12 = "";
		bool_10 = false;
		string_13 = "";
		bool_11 = false;
		string_14 = "";
		bool_12 = false;
		string_15 = "";
		bool_13 = false;
		string_16 = "";
		bool_14 = false;
		string_17 = "";
		bool_15 = false;
	}

	private void method_0(object sender, DoWorkEventArgs e)
	{
		object[] array = (object[])e.Argument;
		LicenseContext licenseContext_ = array[0] as LicenseContext;
		Type type_ = array[1] as Type;
		object object_ = array[2];
		bool bool_ = (bool)array[3];
		lock (object_0)
		{
			e.Result = method_12(licenseContext_, type_, object_, bool_, bool_17: false, bool_18: false, bool_19: false, "", "", null, bool_20: false, bool_21: false, bool_22: false);
		}
	}

	private void method_1(object sender, RunWorkerCompletedEventArgs e)
	{
		lock (object_0)
		{
			Class27.smethod_2();
		}
	}

	public override License GetLicense(LicenseContext context, Type type, object instance, bool allowExceptions)
	{
		Class27.bool_1 = true;
		if (bool_0)
		{
			return new Class19(this, "");
		}
		bool_0 = true;
		if (context == null || context.UsageMode == LicenseUsageMode.Designtime)
		{
		}
		License result = method_12(context, type, instance, allowExceptions, bool_17: false, bool_18: false, bool_19: false, "", "", null, bool_20: false, bool_21: false, bool_22: false);
		bool_0 = false;
		Class27.smethod_2();
		return result;
	}

	internal static void mkLdf8923rwE89zRgl4s()
	{
		if (!bool_1)
		{
			bool_1 = true;
			lock (object_0)
			{
				new Class3().method_12(null, typeof(Class3), true, bool_16: true, bool_17: false, bool_18: false, bool_19: false, "", "", null, bool_20: false, bool_21: false, bool_22: false);
				Class27.smethod_2();
			}
		}
	}

	internal static string smethod_0(string string_18)
	{
		string arg = smethod_4(LicenseManager.CurrentContext);
		return string.Format("{0}\\{1}.lic", arg, typeof(ILLicenseModule).Assembly.GetName().Name + "_" + string_18);
	}

	internal static string smethod_1(string string_18)
	{
		string arg = smethod_4(LicenseManager.CurrentContext);
		return string.Format("{0}\\{1}.hash", arg, typeof(ILLicenseModule).Assembly.GetName().Name + "_" + string_18);
	}

	internal static string smethod_2(string string_18)
	{
		return string.Format("{0}\\{1}.lic", Path.GetTempPath(), typeof(ILLicenseModule).Assembly.GetName().Name + "_" + string_18);
	}

	internal static string smethod_3(string string_18)
	{
		if (string_18 != null && string_18.Length != 0)
		{
			byte[] bytes = Encoding.Default.GetBytes(string_18);
			byte[] array = Class1.smethod_9(bytes);
			return BitConverter.ToString(array).Replace("-", "");
		}
		return string.Empty;
	}

	internal static string smethod_4(LicenseContext licenseContext_0)
	{
		string text = null;
		if (licenseContext_0 != null)
		{
			ITypeResolutionService typeResolutionService = (ITypeResolutionService)licenseContext_0.GetService(typeof(ITypeResolutionService));
			if (typeResolutionService != null)
			{
				text = Path.GetDirectoryName(typeResolutionService.GetPathOfAssembly(typeof(ILLicenseModule).Assembly.GetName()));
			}
		}
		if (text != null)
		{
			return text;
		}
		text = typeof(ILLicenseModule).Assembly.CodeBase;
		text = ((!text.StartsWith("file:///")) ? typeof(ILLicenseModule).Module.FullyQualifiedName : text.Replace("file:///", ""));
		return Path.GetDirectoryName(text);
	}

	internal void method_2(int int_2)
	{
		uint_11 = (uint)int_2;
		uint_12 = 842502087u;
		uint_13 = 3579807591u;
		uint_14 = 273326509u;
	}

	internal int method_3()
	{
		uint num = uint_11 ^ (uint_11 << 11);
		uint_11 = uint_12;
		uint_12 = uint_13;
		uint_13 = uint_14;
		uint_14 = uint_14 ^ (uint_14 >> 19) ^ (num ^ (num >> 8));
		uint num2 = uint_14 & 0x7FFFFFFFu;
		if (num2 == int.MaxValue)
		{
			return method_3();
		}
		return (int)num2;
	}

	internal int method_4(int int_2)
	{
		if (int_2 < 0)
		{
			throw new Exception("upperBound=" + int_2 + "; upperBound must be >=0");
		}
		uint num = uint_11 ^ (uint_11 << 11);
		uint_11 = uint_12;
		uint_12 = uint_13;
		uint_13 = uint_14;
		return (int)(4.656612873077393E-10 * (double)(int)(0x7FFFFFFF & (uint_14 = uint_14 ^ (uint_14 >> 19) ^ (num ^ (num >> 8)))) * (double)int_2);
	}

	internal int method_5(int int_2, int int_3)
	{
		int num = method_6(int_2, int_3);
		if (num >= int_2 && num <= int_3)
		{
			return num;
		}
		return int_3;
	}

	private int method_6(int int_2, int int_3)
	{
		if (int_2 > int_3)
		{
			throw new Exception("upperBound must be >=lowerBound");
		}
		uint num = uint_11 ^ (uint_11 << 11);
		uint_11 = uint_12;
		uint_12 = uint_13;
		uint_13 = uint_14;
		int num2 = int_3 - int_2;
		if (num2 < 0)
		{
			return int_2 + (int)(2.3283064365386963E-10 * (double)(uint_14 = uint_14 ^ (uint_14 >> 19) ^ (num ^ (num >> 8))) * (double)((long)int_3 - (long)int_2));
		}
		return int_2 + (int)(4.656612873077393E-10 * (double)(int)(0x7FFFFFFF & (uint_14 = uint_14 ^ (uint_14 >> 19) ^ (num ^ (num >> 8)))) * (double)num2);
	}

	internal double method_7()
	{
		uint num = uint_11 ^ (uint_11 << 11);
		uint_11 = uint_12;
		uint_12 = uint_13;
		uint_13 = uint_14;
		return 4.656612873077393E-10 * (double)(int)(0x7FFFFFFF & (uint_14 = uint_14 ^ (uint_14 >> 19) ^ (num ^ (num >> 8))));
	}

	internal void method_8(byte[] byte_4)
	{
		uint num = uint_11;
		uint num2 = uint_12;
		uint num3 = uint_13;
		uint num4 = uint_14;
		int num5 = 0;
		int num6 = byte_4.Length - 3;
		while (num5 < num6)
		{
			uint num7 = num ^ (num << 11);
			num = num2;
			num2 = num3;
			num3 = num4;
			num4 = num4 ^ (num4 >> 19) ^ (num7 ^ (num7 >> 8));
			byte_4[num5++] = (byte)num4;
			byte_4[num5++] = (byte)(num4 >> 8);
			byte_4[num5++] = (byte)(num4 >> 16);
			byte_4[num5++] = (byte)(num4 >> 24);
		}
		if (num5 < byte_4.Length)
		{
			uint num7 = num ^ (num << 11);
			num = num2;
			num2 = num3;
			num3 = num4;
			num4 = num4 ^ (num4 >> 19) ^ (num7 ^ (num7 >> 8));
			byte_4[num5++] = (byte)num4;
			if (num5 < byte_4.Length)
			{
				byte_4[num5++] = (byte)(num4 >> 8);
				if (num5 < byte_4.Length)
				{
					byte_4[num5++] = (byte)(num4 >> 16);
					if (num5 < byte_4.Length)
					{
						byte_4[num5] = (byte)(num4 >> 24);
					}
				}
			}
		}
		uint_11 = num;
		uint_12 = num2;
		uint_13 = num3;
		uint_14 = num4;
	}

	internal uint method_9()
	{
		uint num = uint_11 ^ (uint_11 << 11);
		uint_11 = uint_12;
		uint_12 = uint_13;
		uint_13 = uint_14;
		return uint_14 = uint_14 ^ (uint_14 >> 19) ^ (num ^ (num >> 8));
	}

	internal int method_10()
	{
		uint num = uint_11 ^ (uint_11 << 11);
		uint_11 = uint_12;
		uint_12 = uint_13;
		uint_13 = uint_14;
		return (int)(0x7FFFFFFF & (uint_14 = uint_14 ^ (uint_14 >> 19) ^ (num ^ (num >> 8))));
	}

	internal bool method_11()
	{
		if (uint_16 == 1)
		{
			uint num = uint_11 ^ (uint_11 << 11);
			uint_11 = uint_12;
			uint_12 = uint_13;
			uint_13 = uint_14;
			uint_15 = (uint_14 = uint_14 ^ (uint_14 >> 19) ^ (num ^ (num >> 8)));
			uint_16 = 2147483648u;
			return (uint_15 & uint_16) == 0;
		}
		return (uint_15 & (uint_16 >>= 1)) == 0;
	}

	private void ilHifFeDUTsZtKIFfN18()
	{
	}

	private static void smethod_5(object sender, ElapsedEventArgs e)
	{
		if (Math.Abs(DateTime.Now.ToFileTimeUtc() - dateTime_0.ToFileTimeUtc()) < 10000000L)
		{
			TerminateProcess(GetCurrentProcess(), 1);
		}
		dateTime_0 = DateTime.Now;
	}

	private static bool smethod_6(byte[] byte_4, byte[] byte_5, int int_2, int int_3, int int_4)
	{
		if (int_2 + int_4 <= byte_4.Length && int_3 + int_4 <= byte_5.Length)
		{
			int num = 0;
			while (true)
			{
				if (num < int_4)
				{
					if (byte_4[int_2 + num] != byte_5[int_3 + num])
					{
						break;
					}
					num++;
					continue;
				}
				return true;
			}
			return false;
		}
		return false;
	}

	private static void smethod_7(Class6 class6_0)
	{
		if (class6_0.bool_39)
		{
			string message = class6_0.string_14;
			if (class6_0.bool_29)
			{
				if (bool_6)
				{
					Class14.timer_0 = new System.Threading.Timer(new Class14().method_0, null, int_1, 30000);
				}
				try
				{
					EnableWindow(Process.GetCurrentProcess().MainWindowHandle, bool_16: false);
				}
				catch
				{
				}
			}
			ShowMessage(message);
		}
		if (class6_0.bool_29)
		{
			try
			{
				TerminateProcess(GetCurrentProcess(), 1);
			}
			catch
			{
			}
		}
	}

	private static void smethod_8(Class6 class6_0)
	{
		if (class6_0.bool_41)
		{
			string message = class6_0.string_16;
			if (class6_0.bool_29)
			{
				if (bool_6)
				{
					Class14.timer_0 = new System.Threading.Timer(new Class14().method_0, null, int_1, 30000);
				}
				try
				{
					EnableWindow(Process.GetCurrentProcess().MainWindowHandle, bool_16: false);
				}
				catch
				{
				}
			}
			ShowMessage(message);
		}
		if (class6_0.bool_29)
		{
			try
			{
				TerminateProcess(GetCurrentProcess(), 1);
			}
			catch
			{
			}
		}
	}

	private static bool smethod_9(byte[] byte_4, byte[] byte_5, byte[] byte_6, Class6 class6_0, Class6 class6_1, ref LicenseStatus licenseStatus_0)
	{
		try
		{
			Random random = new Random();
			byte[] array = new byte[8];
			random.NextBytes(array);
			ulong ulong_ = BitConverter.ToUInt64(array, 0);
			byte[] bytes = Encoding.Unicode.GetBytes(smethod_30(bool_16: true, bool_17: true, bool_18: true, bool_19: true, bool_20: true, bool_21: true, bool_22: true));
			byte[] bytes2 = BitConverter.GetBytes(byte_6.Length);
			byte[] array2 = new byte[14 + bytes.Length + byte_6.Length];
			array2[0] = 0;
			Array.Copy(array, 0, array2, 1, 8);
			array2[9] = Convert.ToByte(bytes.Length);
			Array.Copy(bytes2, 0, array2, 10, 4);
			Array.Copy(bytes, 0, array2, 14, bytes.Length);
			Array.Copy(byte_6, 0, array2, 14 + bytes.Length, byte_6.Length);
			Class7 @class = new Class7(class6_0.string_1);
			byte[] array3 = @class.method_0(array2);
			if (array3 != null && array3.Length > 0 && array3[0] == 1)
			{
				licenseStatus_0 = LicenseStatus.FloatingLicenseUserExceeded;
				smethod_8(class6_1);
				return false;
			}
			if (array3 != null && array3.Length != 0)
			{
				byte[] array4 = new byte[0];
				SymmetricAlgorithm symmetricAlgorithm = Class1.smethod_8();
				symmetricAlgorithm.Mode = CipherMode.CBC;
				ICryptoTransform transform = symmetricAlgorithm.CreateDecryptor(byte_4, byte_5);
				MemoryStream memoryStream = new MemoryStream();
				CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
				cryptoStream.Write(array3, 0, array3.Length);
				cryptoStream.FlushFinalBlock();
				array4 = memoryStream.ToArray();
				memoryStream.Close();
				cryptoStream.Close();
				if (class6_1.method_0(array4))
				{
					MemoryStream memoryStream2 = new MemoryStream(array4);
					BinaryReader binaryReader = new BinaryReader(memoryStream2);
					memoryStream2.Position = 0L;
					byte[] array5 = binaryReader.ReadBytes(binaryReader.ReadInt32());
					byte[] array6 = binaryReader.ReadBytes((int)(memoryStream2.Length - 4L - array5.Length));
					binaryReader.Close();
					if (array6.Length > 0 && array6[0] == 0)
					{
						if (smethod_6(array, array6, 0, 1, 8))
						{
							byte[] array7 = new byte[16];
							Array.Copy(array6, 9, array7, 0, 16);
							Guid guid_ = new Guid(array7);
							int int_ = BitConverter.ToInt32(array6, 25);
							int num = BitConverter.ToInt32(array6, 29);
							if (Class10.class10_0 != null)
							{
								Class10.class10_0.method_0();
							}
							Class10.class10_0 = new Class10(ulong_, bytes, guid_, int_, class6_0.string_1, num, class6_1);
							Class10.class10_0.timer_0 = new System.Threading.Timer(Class10.class10_0.method_1, null, num * 1000, num * 1000);
							return true;
						}
						licenseStatus_0 = LicenseStatus.FloatingLicenseServerError;
						smethod_7(class6_1);
						return false;
					}
					licenseStatus_0 = LicenseStatus.FloatingLicenseUserExceeded;
					smethod_8(class6_1);
					return false;
				}
				licenseStatus_0 = LicenseStatus.FloatingLicenseServerError;
				smethod_7(class6_1);
				return false;
			}
			licenseStatus_0 = LicenseStatus.FloatingLicenseServerError;
			smethod_7(class6_1);
			return false;
		}
		catch
		{
			licenseStatus_0 = LicenseStatus.FloatingLicenseServerError;
			smethod_7(class6_1);
			return false;
		}
	}

	private static void smethod_10(object sender, EventArgs e)
	{
		try
		{
			if (Class11.class11_0 != null)
			{
				Class11.class11_0.method_3(true);
			}
		}
		catch
		{
		}
	}

	private static bool smethod_11(byte[] byte_4, byte[] byte_5, Class6 class6_0, Class6 class6_1, ref LicenseStatus licenseStatus_0)
	{
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		try
		{
			if (!bool_2)
			{
				bool_2 = true;
				AppDomain.CurrentDomain.ProcessExit += smethod_10;
			}
			Random random = new Random();
			byte[] array = new byte[8];
			random.NextBytes(array);
			ulong ulong_ = BitConverter.ToUInt64(array, 0);
			byte[] bytes = Encoding.Unicode.GetBytes(smethod_30(bool_16: true, bool_17: true, bool_18: true, bool_19: true, bool_20: true, bool_21: true, bool_22: true));
			byte[] bytes2 = Encoding.Unicode.GetBytes(Environment.MachineName);
			byte[] array2 = new byte[11 + bytes.Length + bytes2.Length];
			array2[0] = 0;
			Array.Copy(array, 0, array2, 1, 8);
			array2[9] = Convert.ToByte(bytes.Length);
			Array.Copy(bytes, 0, array2, 10, bytes.Length);
			array2[10 + bytes.Length] = Convert.ToByte(bytes2.Length);
			Array.Copy(bytes2, 0, array2, 11 + bytes.Length, bytes2.Length);
			EndpointAddress val = new EndpointAddress(new Uri(class6_0.string_2), (AddressHeader[])(object)new AddressHeader[0]);
			ChannelFactory<hKbV0NIkrxmjDtgaD7cJbeLP> val2 = new ChannelFactory<hKbV0NIkrxmjDtgaD7cJbeLP>((Binding)new NetTcpBinding(), val);
			hKbV0NIkrxmjDtgaD7cJbeLP hKbV0NIkrxmjDtgaD7cJbeLP2 = val2.CreateChannel();
			byte[] array3 = hKbV0NIkrxmjDtgaD7cJbeLP2.EIGwTGOrLkVIf0FnPhJw9iR(array2);
			if (array3 != null && array3.Length > 0 && array3[0] == 1)
			{
				licenseStatus_0 = LicenseStatus.FloatingLicenseUserExceeded;
				smethod_8(class6_1);
				return false;
			}
			if (array3 != null && array3.Length != 0)
			{
				byte[] buffer = array3;
				if (Class6.smethod_1(buffer))
				{
					MemoryStream memoryStream = new MemoryStream(buffer);
					BinaryReader binaryReader = new BinaryReader(memoryStream);
					memoryStream.Position = 0L;
					byte[] array4 = binaryReader.ReadBytes(binaryReader.ReadInt32());
					byte[] array5 = binaryReader.ReadBytes((int)(memoryStream.Length - 4L - array4.Length));
					binaryReader.Close();
					if (array5.Length > 0 && array5[0] == 0)
					{
						if (smethod_6(array, array5, 0, 1, 8))
						{
							byte[] array6 = new byte[16];
							Array.Copy(array5, 9, array6, 0, 16);
							Guid guid_ = new Guid(array6);
							int int_ = BitConverter.ToInt32(array5, 25);
							int num = BitConverter.ToInt32(array5, 29);
							if (Class11.class11_0 != null)
							{
								Class11.class11_0.method_0();
							}
							Class11.class11_0 = new Class11(ulong_, bytes, guid_, int_, class6_0.string_2, num, class6_1, hKbV0NIkrxmjDtgaD7cJbeLP2, val2);
							Class11.class11_0.timer_0 = new System.Threading.Timer(Class11.class11_0.method_3, null, num * 1000, num * 1000);
							return true;
						}
						licenseStatus_0 = LicenseStatus.FloatingLicenseServerError;
						smethod_7(class6_1);
						return false;
					}
					licenseStatus_0 = LicenseStatus.FloatingLicenseUserExceeded;
					smethod_8(class6_1);
					return false;
				}
				licenseStatus_0 = LicenseStatus.FloatingLicenseServerError;
				smethod_7(class6_1);
				return false;
			}
			licenseStatus_0 = LicenseStatus.FloatingLicenseServerError;
			smethod_7(class6_1);
			return false;
		}
		catch (Exception)
		{
			licenseStatus_0 = LicenseStatus.FloatingLicenseServerError;
			smethod_7(class6_1);
			return false;
		}
	}

	private static void smethod_12(object sender, DoWorkEventArgs e)
	{
		smethod_13(bool_16: true);
	}

	internal static void smethod_13(bool bool_16)
	{
		if (bool_3 && !bool_16)
		{
			return;
		}
		bool_3 = true;
		string text = "";
		bool flag = false;
		Class5 class5_ = null;
		try
		{
			text = smethod_32(bool_16: false);
			smethod_17(ref class5_, null, text);
			smethod_18(ref class5_, typeof(Class3), text);
			smethod_20(ref class5_, null, text);
			if (!bool_16 && class5_ != null && class5_.string_1 != null && class5_.string_1.Length > 0)
			{
				string[] array = class5_.string_1.Split(new char[1] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
				string_2 = array[0].Trim();
				string_3 = array[1].Trim();
				string_4 = array[2].Trim();
				string_5 = Encoding.Unicode.GetString(Convert.FromBase64String(class5_.string_2));
				flag = true;
			}
		}
		catch
		{
		}
		flag = false;
		string_2 = smethod_25(bool_16: true, bool_17: true, bool_18: true, bool_19: true, bool_20: true, bool_21: true, bool_22: false);
		string_3 = smethod_28(bool_16: true, bool_17: true, bool_18: true, bool_19: true, bool_20: true, bool_21: true, bool_22: false);
		string_4 = smethod_30(bool_16: true, bool_17: true, bool_18: true, bool_19: true, bool_20: true, bool_21: true, bool_22: false);
		if (string_10 != null && string_10.Length > 0)
		{
			string_5 = string_10;
		}
		else if (string_15 != null && string_15.Length > 0)
		{
			string_5 = string_15;
		}
		else if (string_9 != null && string_9.Length > 0)
		{
			string_5 = string_9;
		}
		if (class5_ == null)
		{
			class5_ = new Class5();
		}
		class5_.string_1 = string_2 + "\\" + string_3 + "\\" + string_4;
		class5_.string_2 = Convert.ToBase64String(Encoding.Unicode.GetBytes(string_5));
		smethod_21(ref class5_, typeof(Class3), bool_16: false, text);
		lock (object_2)
		{
			if (!bool_16 && flag && !bool_4)
			{
				bool_4 = true;
				Class9.timer_0 = new System.Threading.Timer(Class9.smethod_0, null, 500, 500);
				Class27.Event_1 += smethod_14;
			}
		}
	}

	private static void smethod_14()
	{
		if (!bool_5)
		{
			bool_5 = true;
			try
			{
				Class27.Event_1 -= smethod_14;
			}
			catch
			{
			}
		}
	}

	private static bool smethod_15(int int_2, Class6 class6_0)
	{
		string text = smethod_30(class6_0.bool_8, class6_0.bool_9, class6_0.bool_14, class6_0.bool_7, class6_0.bool_10, class6_0.bool_11, bool_22: true);
		if (text.Length == 29)
		{
			int num = 0;
			if (class6_0.bool_10 && class6_0.string_5.Substring(0, 4) != text.Substring(0, 4))
			{
				num++;
			}
			if (class6_0.bool_8 && class6_0.string_5.Substring(5, 4) != text.Substring(5, 4))
			{
				num++;
			}
			if (class6_0.bool_9 && class6_0.string_5.Substring(10, 4) != text.Substring(10, 4))
			{
				num++;
			}
			if (class6_0.bool_14 && class6_0.string_5.Substring(15, 4) != text.Substring(15, 4))
			{
				num++;
			}
			if (class6_0.bool_7 && class6_0.string_5.Substring(20, 4) != text.Substring(20, 4))
			{
				num++;
			}
			if (class6_0.bool_11 && class6_0.string_5.Substring(25, 4) != text.Substring(25, 4))
			{
				num++;
			}
			if (class6_0.int_2 - num < 0)
			{
				text = smethod_28(class6_0.bool_8, class6_0.bool_9, class6_0.bool_14, class6_0.bool_7, class6_0.bool_10, class6_0.bool_11, bool_22: true);
				if (text.Length == 29)
				{
					num = 0;
					if (class6_0.bool_10 && class6_0.string_5.Substring(0, 4) != text.Substring(0, 4))
					{
						num++;
					}
					if (class6_0.bool_8 && class6_0.string_5.Substring(5, 4) != text.Substring(5, 4))
					{
						num++;
					}
					if (class6_0.bool_9 && class6_0.string_5.Substring(10, 4) != text.Substring(10, 4))
					{
						num++;
					}
					if (class6_0.bool_14 && class6_0.string_5.Substring(15, 4) != text.Substring(15, 4))
					{
						num++;
					}
					if (class6_0.bool_7 && class6_0.string_5.Substring(20, 4) != text.Substring(20, 4))
					{
						num++;
					}
					if (class6_0.bool_11 && class6_0.string_5.Substring(25, 4) != text.Substring(25, 4))
					{
						num++;
					}
				}
				if (class6_0.int_2 - num < 0)
				{
					text = smethod_25(class6_0.bool_8, class6_0.bool_9, class6_0.bool_14, class6_0.bool_7, class6_0.bool_10, class6_0.bool_11, bool_22: true);
					if (text.Length == 29)
					{
						num = 0;
						if (class6_0.bool_10 && class6_0.string_5.Substring(0, 4) != text.Substring(0, 4))
						{
							num++;
						}
						if (class6_0.bool_8 && class6_0.string_5.Substring(5, 4) != text.Substring(5, 4))
						{
							num++;
						}
						if (class6_0.bool_9 && class6_0.string_5.Substring(10, 4) != text.Substring(10, 4))
						{
							num++;
						}
						if (class6_0.bool_14 && class6_0.string_5.Substring(15, 4) != text.Substring(15, 4))
						{
							num++;
						}
						if (class6_0.bool_7 && class6_0.string_5.Substring(20, 4) != text.Substring(20, 4))
						{
							num++;
						}
						if (class6_0.bool_11 && class6_0.string_5.Substring(25, 4) != text.Substring(25, 4))
						{
							num++;
						}
					}
					if (class6_0.int_2 - num < 0)
					{
						text = smethod_26();
						if (class6_0.string_5 == text && text != "{nohid-22222-10001-00000}")
						{
							num = 0;
						}
					}
				}
			}
			if (int_2 - num < 0)
			{
				return false;
			}
			return true;
		}
		return false;
	}

	internal static void smethod_16(ref Class5 class5_0, string string_18, bool bool_16)
	{
		if (bool_16)
		{
			smethod_17(ref class5_0, string_18, string_8);
		}
		smethod_17(ref class5_0, string_18, string_7);
	}

	internal static void smethod_17(ref Class5 class5_0, string string_18, string string_19)
	{
		try
		{
			string text = Class4.string_0;
			string text2 = Class4.string_2;
			string text3 = string_19 + "\\";
			RegistryKey registryKey = null;
			registryKey = Registry.CurrentUser;
			RegistryKey registryKey2 = null;
			if (string_18 == null)
			{
				registryKey2 = registryKey.OpenSubKey(text + text3, writable: false);
				if (registryKey2 == null)
				{
					registryKey2 = registryKey.OpenSubKey(text2 + text3, writable: false);
				}
			}
			else
			{
				registryKey2 = registryKey.OpenSubKey(string_18 + text3, writable: false);
			}
			if (registryKey2 != null)
			{
				Class5 @class = new Class5();
				@class.method_0((string)registryKey2.GetValue("1"), byte_1, byte_2);
				if (class5_0 == null)
				{
					class5_0 = @class;
				}
				if (@class.ulong_0 > class5_0.ulong_0)
				{
					class5_0 = @class;
				}
			}
		}
		catch
		{
		}
	}

	internal static void smethod_18(ref Class5 class5_0, Type type_0, string string_18)
	{
		try
		{
			string string_19 = string_7;
			if (string_18 != null && string_18.Length > 0)
			{
				string_19 = string_18;
			}
			if (Class1.smethod_13(type_0.Assembly).ToString()!.Length <= 0 || !File.Exists(Class1.smethod_13(type_0.Assembly).ToString()))
			{
				return;
			}
			Class5 @class = new Class5();
			string text = smethod_35(Path.GetDirectoryName(Class1.smethod_13(type_0.Assembly).ToString()), string_19);
			if (text != null && text.Length > 0)
			{
				@class.method_0(text, byte_1, byte_2);
				if (class5_0 == null)
				{
					class5_0 = @class;
				}
				if (@class.ulong_0 > class5_0.ulong_0)
				{
					class5_0 = @class;
				}
			}
		}
		catch
		{
		}
	}

	internal static void smethod_19(ref Class5 class5_0, string string_18, bool bool_16)
	{
		smethod_20(ref class5_0, string_18, string_7);
		if (bool_16)
		{
			smethod_20(ref class5_0, string_18, string_8);
		}
	}

	internal static void smethod_20(ref Class5 class5_0, string string_18, string string_19)
	{
		try
		{
			string text = Class4.string_3;
			if (string_18 != null)
			{
				text = string_18;
			}
			if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + text + string_19))
			{
				Class5 @class = new Class5();
				@class.method_0(Encoding.Unicode.GetString(smethod_38(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + text + string_19)), byte_1, byte_2);
				if (class5_0 == null)
				{
					class5_0 = @class;
				}
				if (@class.ulong_0 > class5_0.ulong_0)
				{
					class5_0 = @class;
				}
			}
		}
		catch
		{
		}
	}

	internal static void smethod_21(ref Class5 class5_0, Type type_0, bool bool_16, string string_18)
	{
		string text = string_7;
		if (string_18 != null && string_18.Length > 0)
		{
			text = string_18;
		}
		if (bool_16)
		{
			try
			{
				string text2 = Class4.string_0;
				string text3 = string_8 + "\\";
				RegistryKey currentUser = Registry.CurrentUser;
				RegistryKey registryKey = currentUser.OpenSubKey(text2 + text3, writable: false);
				if (registryKey == null)
				{
					currentUser = Registry.CurrentUser;
					registryKey = currentUser.CreateSubKey(text2 + text3);
				}
				currentUser = Registry.CurrentUser;
				registryKey = currentUser.OpenSubKey(text2 + text3, writable: true);
				if (registryKey != null)
				{
					string value = class5_0.method_5(byte_1, byte_2);
					registryKey.SetValue("1", value);
					registryKey.Close();
				}
			}
			catch
			{
			}
		}
		try
		{
			string text4 = Class4.string_0;
			string text5 = text + "\\";
			RegistryKey currentUser2 = Registry.CurrentUser;
			RegistryKey registryKey2 = currentUser2.OpenSubKey(text4 + text5, writable: false);
			if (registryKey2 == null)
			{
				currentUser2 = Registry.CurrentUser;
				registryKey2 = currentUser2.CreateSubKey(text4 + text5);
			}
			currentUser2 = Registry.CurrentUser;
			registryKey2 = currentUser2.OpenSubKey(text4 + text5, writable: true);
			if (registryKey2 != null)
			{
				string value2 = class5_0.method_5(byte_1, byte_2);
				registryKey2.SetValue("1", value2);
				registryKey2.Close();
			}
		}
		catch
		{
		}
		try
		{
			if (Class1.smethod_13(type_0.Assembly).ToString()!.Length > 0 && File.Exists(Class1.smethod_13(type_0.Assembly).ToString()))
			{
				smethod_34(Path.GetDirectoryName(Class1.smethod_13(type_0.Assembly).ToString()), text, class5_0.method_5(byte_1, byte_2));
			}
		}
		catch
		{
		}
		try
		{
			FileStream fileStream = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + Class4.string_3 + text, FileMode.Create, FileAccess.ReadWrite);
			byte[] bytes = Encoding.Unicode.GetBytes(class5_0.method_5(byte_1, byte_2));
			fileStream.Write(bytes, 0, bytes.Length);
			fileStream.Close();
		}
		catch
		{
		}
	}

	internal License method_12(LicenseContext licenseContext_0, Type type_0, object object_3, bool bool_16, bool bool_17, bool bool_18, bool bool_19, string string_18, string string_19, byte[] byte_4, bool bool_20, bool bool_21, bool bool_22)
	{
		if (!Class27.bool_0 && timer_0 == null)
		{
			dateTime_0 = DateTime.Now;
			timer_0 = new System.Timers.Timer(15000.0);
			timer_0.Elapsed += smethod_5;
			timer_0.Enabled = true;
		}
		Class27.bool_0 = true;
		smethod_13(bool_16: false);
		if (!bool_17 && !bool_18 && !bool_19 && !bool_21 && !bool_22)
		{
			try
			{
				if (sortedList_1[type_0.Assembly.FullName] != null)
				{
					if ((bool)sortedList_0[type_0.Assembly.FullName])
					{
						return (Class19)sortedList_1[type_0.Assembly.FullName];
					}
					return null;
				}
				if (sortedList_1[typeof(Class3).Assembly.FullName] != null)
				{
					AssemblyName[] referencedAssemblies = typeof(Class3).Assembly.GetReferencedAssemblies();
					for (int i = 0; i < referencedAssemblies.Length; i++)
					{
						if (type_0.Assembly.GetName().FullName == referencedAssemblies[i].FullName)
						{
							if ((bool)sortedList_0[typeof(Class3).Assembly.FullName])
							{
								return (Class19)sortedList_1[typeof(Class3).Assembly.FullName];
							}
							return null;
						}
					}
				}
				else
				{
					AssemblyName[] referencedAssemblies2 = typeof(Class3).Assembly.GetReferencedAssemblies();
					for (int j = 0; j < referencedAssemblies2.Length; j++)
					{
						if (typeof(Class3).Assembly.GetName().FullName == referencedAssemblies2[j].FullName)
						{
							type_0 = typeof(Class3);
							break;
						}
					}
				}
			}
			catch
			{
			}
		}
		Class6 @class = new Class6();
		new Class19(this, "");
		BinaryReader binaryReader = new BinaryReader(typeof(Class3).Assembly.GetManifestResourceStream("c9144f02-6c47-4af8-88b7-3da7cfe99a26"));
		binaryReader.BaseStream.Position = 0L;
		byte[] array = new byte[0];
		byte[] array2 = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
		try
		{
			byte[] array3 = new byte[32];
			array3[0] = 118;
			array3[0] = 65;
			array3[0] = 188;
			array3[0] = 49;
			array3[1] = 145;
			array3[1] = 160;
			array3[1] = 162;
			array3[2] = 113;
			array3[2] = 161;
			array3[2] = 130;
			array3[2] = 150;
			array3[2] = 227;
			array3[3] = 180;
			array3[3] = 126;
			array3[3] = 108;
			array3[3] = 136;
			array3[3] = 90;
			array3[3] = 155;
			array3[4] = 28;
			array3[4] = 124;
			array3[4] = 96;
			array3[4] = 144;
			array3[4] = 201;
			array3[4] = 96;
			array3[5] = 128;
			array3[5] = 91;
			array3[5] = 51;
			array3[6] = 110;
			array3[6] = 138;
			array3[6] = 85;
			array3[6] = 45;
			array3[6] = 13;
			array3[7] = 97;
			array3[7] = 88;
			array3[7] = 140;
			array3[7] = 153;
			array3[7] = 120;
			array3[7] = 250;
			array3[8] = 164;
			array3[8] = 100;
			array3[8] = 110;
			array3[8] = 158;
			array3[8] = 108;
			array3[8] = 51;
			array3[9] = 103;
			array3[9] = 124;
			array3[9] = 140;
			array3[9] = 117;
			array3[9] = 92;
			array3[9] = 53;
			array3[10] = 89;
			array3[10] = 116;
			array3[10] = 142;
			array3[11] = 147;
			array3[11] = 41;
			array3[11] = 101;
			array3[11] = 12;
			array3[12] = 148;
			array3[12] = 74;
			array3[12] = 145;
			array3[12] = 1;
			array3[13] = 99;
			array3[13] = 162;
			array3[13] = 114;
			array3[13] = 19;
			array3[14] = 86;
			array3[14] = 65;
			array3[14] = 148;
			array3[14] = 208;
			array3[15] = 107;
			array3[15] = 109;
			array3[15] = 115;
			array3[15] = 162;
			array3[15] = 142;
			array3[16] = 102;
			array3[16] = 196;
			array3[16] = 106;
			array3[16] = 96;
			array3[17] = 76;
			array3[17] = 154;
			array3[17] = 135;
			array3[18] = 75;
			array3[18] = 142;
			array3[18] = 116;
			array3[18] = 111;
			array3[18] = 122;
			array3[18] = 248;
			array3[19] = 94;
			array3[19] = 155;
			array3[19] = 147;
			array3[19] = 70;
			array3[19] = 101;
			array3[19] = 205;
			array3[20] = 173;
			array3[20] = 67;
			array3[20] = 136;
			array3[20] = 153;
			array3[20] = 93;
			array3[20] = 71;
			array3[21] = 127;
			array3[21] = 143;
			array3[21] = 164;
			array3[22] = 65;
			array3[22] = 127;
			array3[22] = 166;
			array3[22] = 117;
			array3[23] = 86;
			array3[23] = 86;
			array3[23] = 146;
			array3[23] = 166;
			array3[23] = 128;
			array3[23] = 88;
			array3[24] = 128;
			array3[24] = 122;
			array3[24] = 79;
			array3[24] = 52;
			array3[25] = 104;
			array3[25] = 133;
			array3[25] = 121;
			array3[25] = 61;
			array3[25] = 171;
			array3[26] = 23;
			array3[26] = 132;
			array3[26] = 120;
			array3[26] = 162;
			array3[26] = 180;
			array3[26] = 57;
			array3[27] = 114;
			array3[27] = 134;
			array3[27] = 92;
			array3[27] = 170;
			array3[27] = 134;
			array3[27] = 73;
			array3[28] = 135;
			array3[28] = 145;
			array3[28] = 64;
			array3[29] = 207;
			array3[29] = 109;
			array3[29] = 123;
			array3[29] = 138;
			array3[30] = 110;
			array3[30] = 138;
			array3[30] = 158;
			array3[30] = 104;
			array3[30] = byte.MaxValue;
			array3[31] = 90;
			array3[31] = 25;
			array3[31] = 81;
			array3[31] = 124;
			array3[31] = 29;
			byte_1 = array3;
			byte[] array4 = new byte[16];
			array4[0] = 100;
			array4[0] = 105;
			array4[0] = 159;
			array4[0] = 109;
			array4[1] = 162;
			array4[1] = 128;
			array4[1] = 79;
			array4[1] = 139;
			array4[1] = 167;
			array4[1] = 186;
			array4[2] = 150;
			array4[2] = 123;
			array4[2] = 87;
			array4[2] = 141;
			array4[2] = 88;
			array4[2] = 39;
			array4[3] = 164;
			array4[3] = 167;
			array4[3] = 153;
			array4[3] = 60;
			array4[3] = 96;
			array4[4] = 134;
			array4[4] = 195;
			array4[4] = 177;
			array4[4] = 140;
			array4[4] = 4;
			array4[5] = 106;
			array4[5] = 141;
			array4[5] = 95;
			array4[5] = 129;
			array4[5] = 128;
			array4[6] = 157;
			array4[6] = 123;
			array4[6] = 224;
			array4[7] = 126;
			array4[7] = 140;
			array4[7] = 89;
			array4[8] = 158;
			array4[8] = 121;
			array4[8] = 151;
			array4[8] = 93;
			array4[8] = 129;
			array4[9] = 190;
			array4[9] = 92;
			array4[9] = 200;
			array4[10] = 229;
			array4[10] = 120;
			array4[10] = 203;
			array4[10] = 129;
			array4[10] = 60;
			array4[11] = 208;
			array4[11] = 101;
			array4[11] = 154;
			array4[11] = 129;
			array4[11] = 8;
			array4[12] = 127;
			array4[12] = 128;
			array4[12] = 111;
			array4[12] = 225;
			array4[13] = 107;
			array4[13] = 114;
			array4[13] = 120;
			array4[13] = 75;
			array4[14] = 132;
			array4[14] = 107;
			array4[14] = 100;
			array4[14] = 159;
			array4[14] = 27;
			array4[15] = 211;
			array4[15] = 112;
			array4[15] = 168;
			array4[15] = 92;
			array4[15] = 143;
			array4[15] = 167;
			byte_2 = array4;
		}
		catch
		{
		}
		try
		{
			if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + Class4.string_3))
			{
				Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + Class4.string_3);
			}
		}
		catch
		{
		}
		if (bool_18)
		{
			string text = string_0;
			string_0 = "";
			try
			{
				smethod_32(bool_16: true);
				Class5 class5_ = null;
				smethod_16(ref class5_, null, bool_16: true);
				smethod_18(ref class5_, type_0, null);
				smethod_19(ref class5_, null, bool_16: true);
				if (class5_ == null)
				{
					class5_ = new Class5();
				}
				method_2(Environment.TickCount);
				class5_.int_3 = method_5(10000000, 2147483646);
				smethod_21(ref class5_, type_0, bool_16: true, null);
				SymmetricAlgorithm symmetricAlgorithm = Class1.smethod_8();
				symmetricAlgorithm.Mode = CipherMode.CBC;
				ICryptoTransform transform = symmetricAlgorithm.CreateEncryptor(byte_1, byte_2);
				MemoryStream memoryStream = new MemoryStream();
				CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
				byte[] array5 = new byte[0];
				array5 = ((string_18.Length <= 0) ? Encoding.ASCII.GetBytes(smethod_27(bool_16: true, bool_17: true, bool_18: true, bool_19: true, bool_20: true, bool_21: true) + class5_.int_3) : Encoding.ASCII.GetBytes(string_18 + class5_.int_3));
				cryptoStream.Write(array5, 0, array5.Length);
				cryptoStream.FlushFinalBlock();
				array = memoryStream.ToArray();
				Class28.string_0 = Convert.ToBase64String(array);
				memoryStream.Close();
				cryptoStream.Close();
				class5_ = null;
			}
			catch
			{
			}
			string_0 = text;
			return null;
		}
		if (bool_19)
		{
			string text2 = string_0;
			string_0 = "";
			try
			{
				smethod_32(bool_16: true);
				Class5 class5_2 = null;
				smethod_16(ref class5_2, null, bool_16: true);
				smethod_18(ref class5_2, type_0, null);
				smethod_19(ref class5_2, null, bool_16: true);
				if (class5_2.int_3 == 0)
				{
					return new Class19(this, "");
				}
				byte[] array6 = Convert.FromBase64String(string_18);
				SymmetricAlgorithm symmetricAlgorithm2 = Class1.smethod_8();
				symmetricAlgorithm2.Mode = CipherMode.CBC;
				ICryptoTransform transform2 = symmetricAlgorithm2.CreateDecryptor(byte_1, byte_2);
				MemoryStream memoryStream2 = new MemoryStream();
				CryptoStream cryptoStream2 = new CryptoStream(memoryStream2, transform2, CryptoStreamMode.Write);
				byte[] array7 = array6;
				cryptoStream2.Write(array7, 0, array7.Length);
				cryptoStream2.FlushFinalBlock();
				array = memoryStream2.ToArray();
				array6 = array;
				memoryStream2.Close();
				cryptoStream2.Close();
				string @string = Encoding.Unicode.GetString(array, 0, array.Length);
				if (@string != null && @string.Length > 0 && @string.IndexOf(class5_2.int_3.ToString()) >= 0)
				{
					class5_2.int_3 = 0;
					smethod_21(ref class5_2, type_0, bool_16: true, null);
					string_0 = text2;
					return new Class19(this, "");
				}
				string_0 = text2;
				return null;
			}
			catch
			{
				string_0 = text2;
				return null;
			}
		}
		try
		{
			SymmetricAlgorithm symmetricAlgorithm3 = Class1.smethod_8();
			symmetricAlgorithm3.Mode = CipherMode.CBC;
			ICryptoTransform transform3 = symmetricAlgorithm3.CreateDecryptor(byte_1, byte_2);
			MemoryStream memoryStream3 = new MemoryStream();
			CryptoStream cryptoStream3 = new CryptoStream(memoryStream3, transform3, CryptoStreamMode.Write);
			cryptoStream3.Write(array2, 0, array2.Length);
			cryptoStream3.FlushFinalBlock();
			array = memoryStream3.ToArray();
			memoryStream3.Close();
			cryptoStream3.Close();
			binaryReader.Close();
		}
		catch
		{
		}
		if (!@class.method_0(array))
		{
			try
			{
				TerminateProcess(GetCurrentProcess(), 1);
			}
			catch
			{
			}
			return null;
		}
		if (!@class.method_1(array))
		{
			try
			{
				TerminateProcess(GetCurrentProcess(), 1);
			}
			catch
			{
			}
			return null;
		}
		if (!@class.bool_16)
		{
			try
			{
				TerminateProcess(GetCurrentProcess(), 1);
			}
			catch
			{
			}
			return null;
		}
		if (int_1 == -1)
		{
			int_1 = @class.int_8 * 1000;
			bool_6 = @class.bool_42;
		}
		if (@class.bool_12)
		{
			string_1 = @class.string_3;
		}
		if (bool_21)
		{
			try
			{
				SymmetricAlgorithm symmetricAlgorithm4 = Class1.smethod_8();
				symmetricAlgorithm4.Mode = CipherMode.CBC;
				ICryptoTransform transform4 = symmetricAlgorithm4.CreateDecryptor(byte_1, byte_2);
				MemoryStream memoryStream4 = new MemoryStream();
				CryptoStream cryptoStream4 = new CryptoStream(memoryStream4, transform4, CryptoStreamMode.Write);
				cryptoStream4.Write(byte_4, 0, byte_4.Length);
				cryptoStream4.FlushFinalBlock();
				byte[] array8 = memoryStream4.ToArray();
				memoryStream4.Close();
				cryptoStream4.Close();
				if (!@class.method_0(array8))
				{
					return null;
				}
				return new Class19(this, "");
			}
			catch
			{
			}
		}
		if (bool_22)
		{
			try
			{
				SymmetricAlgorithm symmetricAlgorithm5 = Class1.smethod_8();
				symmetricAlgorithm5.Mode = CipherMode.CBC;
				ICryptoTransform transform5 = symmetricAlgorithm5.CreateDecryptor(byte_1, byte_2);
				MemoryStream memoryStream5 = new MemoryStream();
				CryptoStream cryptoStream5 = new CryptoStream(memoryStream5, transform5, CryptoStreamMode.Write);
				cryptoStream5.Write(byte_4, 0, byte_4.Length);
				cryptoStream5.FlushFinalBlock();
				byte[] buffer = memoryStream5.ToArray();
				memoryStream5.Close();
				cryptoStream5.Close();
				MemoryStream memoryStream6 = new MemoryStream(buffer);
				BinaryReader binaryReader2 = new BinaryReader(memoryStream6);
				memoryStream6.Position = 0L;
				byte[] array9 = binaryReader2.ReadBytes(binaryReader2.ReadInt32());
				byte[] array10 = binaryReader2.ReadBytes((int)(memoryStream6.Length - 4L - array9.Length));
				binaryReader2.Close();
				Class29.byte_0 = array10;
				return new Class19(this, "");
			}
			catch
			{
			}
		}
		try
		{
			@class.string_4 = "";
			@class.int_0 = 28;
			@class.bool_17 = false;
			@class.int_1 = 5;
			@class.int_2 = 0;
			@class.bool_3 = false;
			@class.bool_6 = false;
			@class.bool_15 = false;
			@class.bool_16 = false;
			@class.bool_4 = false;
			@class.string_1 = "http:\\\\";
			@class.string_2 = string.Empty;
			@class.bool_5 = false;
		}
		catch
		{
		}
		Class6 class2 = null;
		Class6 class3 = null;
		bool flag = false;
		if (!@class.bool_20 && !@class.bool_19 && !@class.bool_21 && !@class.bool_22 && !@class.bool_23 && !@class.bool_24 && !@class.bool_25)
		{
			sortedList_0[type_0.Assembly.FullName] = true;
			sortedList_1[type_0.Assembly.FullName] = new Class19(this, "");
			return new Class19(this, "");
		}
		sortedList_0[type_0.Assembly.FullName] = true;
		sortedList_1[type_0.Assembly.FullName] = new Class19(this, "");
		Class27.smethod_4().method_11(LicenseLocation.Inbuilt);
		smethod_32(bool_16: true);
		bool flag2 = false;
		bool flag3 = false;
		LicenseStatus licenseStatus_ = LicenseStatus.NotChecked;
		bool flag4 = false;
		Class5 class5_3 = null;
		bool flag5 = false;
		try
		{
			uint_11 = 0u;
			while (uint_11 < 2 && (uint_11 == 0 || @class.bool_12))
			{
				class5_3 = null;
				if (uint_11 == 0)
				{
					string_0 = "";
					smethod_32(bool_16: true);
				}
				else
				{
					string_0 = string_1;
					smethod_32(bool_16: true);
				}
				Class5 class5_4 = null;
				Class5 class5_5 = null;
				Class5 class5_6 = null;
				ulong num = 0uL;
				bool flag6 = false;
				smethod_16(ref class5_3, Class4.string_0, bool_16: true);
				if (class5_3 != null)
				{
					num = class5_3.ulong_0;
				}
				smethod_16(ref class5_4, Class4.string_2, bool_16: true);
				if (class5_4 != null && class5_4.ulong_0 > num)
				{
					flag6 = true;
					class5_3 = class5_4;
					num = class5_3.ulong_0;
				}
				smethod_19(ref class5_5, Class4.string_3, bool_16: true);
				smethod_19(ref class5_6, Class4.string_4, bool_16: true);
				if (class5_6 != null)
				{
					if (class5_5 != null)
					{
						if (class5_6.ulong_0 > class5_5.ulong_0)
						{
							class5_5 = class5_6;
							flag6 = true;
						}
					}
					else
					{
						class5_5 = class5_6;
					}
				}
				if (class5_5 != null && class5_5.ulong_0 > num)
				{
					class5_3 = class5_5;
					num = class5_3.ulong_0;
				}
				smethod_18(ref class5_3, type_0, null);
				if (flag6)
				{
					smethod_21(ref class5_3, type_0, bool_16: true, null);
				}
				if (class5_3 == null)
				{
					class5_3 = new Class5();
				}
				if (uint_11 == 0 && class5_3 != null && class5_3.int_3 > 0)
				{
					Class27.smethod_4().method_5(LicenseStatus.Deactivated);
					Class27.smethod_4().method_7(LicenseStatus.Deactivated);
					Class27.smethod_4().method_9(LicenseStatus.Deactivated);
					flag5 = true;
					sortedList_0[type_0.Assembly.FullName] = true;
					sortedList_1[type_0.Assembly.FullName] = new Class19(this, "");
				}
				uint_11++;
			}
		}
		catch
		{
		}
		if (!flag5)
		{
			byte[] array11 = new byte[0];
			if (licenseContext_0 != null && @class.bool_27)
			{
				try
				{
					if (licenseContext_0.UsageMode == LicenseUsageMode.Runtime)
					{
						string text3 = licenseContext_0.GetSavedLicenseKey(typeof(ILLicenseModule), null);
						if (text3 == null || text3.Length == 0)
						{
							Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
							Assembly[] array12 = assemblies;
							foreach (Assembly resourceAssembly in array12)
							{
								string savedLicenseKey = licenseContext_0.GetSavedLicenseKey(typeof(ILLicenseModule), resourceAssembly);
								if (savedLicenseKey != null && savedLicenseKey.Length > 0)
								{
									text3 = savedLicenseKey;
									break;
								}
							}
						}
						if (text3 != null && text3.Length > 0)
						{
							array11 = Convert.FromBase64String(text3);
						}
					}
				}
				catch
				{
				}
				try
				{
					if (array11.Length == 0)
					{
						string string_20 = smethod_3("<RSAKeyValue><Modulus>t0R+zt7wCeBClCmwRoOzVMQ4RbT7l4UXdrdrZ3hwYkE2LqCdBZujJLaZcoeozjRDu5zgr7slwKQpFQiQ3eu0vj07Khot/6fVgkTIoHQ58sn1weQnPy4DrvNYGuYTOT1ceNg+3vkFWrLdp8Mjo8gRNHRLqDKCMRATAWni5g/bvfVIJDmuNlF6dJqP2tHldZUoOfuIg5j+f1jO73oMSC6Hagm56i1oVDLjAusRgjY5+no8+bdhEE8JwxDFz2NA9pLo6uYX7K9eCb4N1vML6wUD5V/2kYIEO+vg0K+P987kceI78o5fwI2Hn8wSK5Bsl9aezOgUWtMbMOz+0izBKoDUGw==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
						string text4 = smethod_0(string_20);
						string text5 = smethod_2(string_20);
						string path = smethod_1(string_20);
						if (File.Exists(text4))
						{
							bool flag7 = true;
							try
							{
								if (File.Exists(path))
								{
									string[] array13 = File.ReadAllLines(path);
									if (array13 != null && array13.Length == 2 && File.Exists(array13[0]))
									{
										string text6 = Convert.ToBase64String(Class1.smethod_9(File.ReadAllBytes(array13[0])));
										if (text6 != array13[1])
										{
											flag7 = false;
										}
									}
								}
							}
							catch
							{
							}
							if (flag7)
							{
								array11 = smethod_38(text4);
								licenseContext_0.SetSavedLicenseKey(typeof(ILLicenseModule), Convert.ToBase64String(array11));
							}
						}
						else if (File.Exists(text5))
						{
							array11 = smethod_38(text5);
							licenseContext_0.SetSavedLicenseKey(typeof(ILLicenseModule), Convert.ToBase64String(array11));
						}
					}
				}
				catch
				{
				}
			}
			if (bool_17)
			{
				byte[] array14 = new byte[0];
				if (string_19.Length > 0)
				{
					try
					{
						array14 = smethod_38(string_19);
					}
					catch
					{
					}
				}
				else
				{
					array14 = byte_4;
				}
				if (array14 == null)
				{
					array14 = new byte[0];
				}
				if (array14.Length > 0)
				{
					Class6 class4 = new Class6();
					array = new byte[0];
					try
					{
						array2 = array14;
						SymmetricAlgorithm symmetricAlgorithm6 = Class1.smethod_8();
						symmetricAlgorithm6.Mode = CipherMode.CBC;
						ICryptoTransform transform6 = symmetricAlgorithm6.CreateDecryptor(byte_1, byte_2);
						MemoryStream memoryStream7 = new MemoryStream();
						CryptoStream cryptoStream6 = new CryptoStream(memoryStream7, transform6, CryptoStreamMode.Write);
						cryptoStream6.Write(array2, 0, array2.Length);
						cryptoStream6.FlushFinalBlock();
						array = memoryStream7.ToArray();
						memoryStream7.Close();
						cryptoStream6.Close();
					}
					catch
					{
						array = new byte[0];
					}
					if (array.Length > 0)
					{
						if (class4.method_0(array))
						{
							bool flag8 = true;
							try
							{
								class4.method_1(array);
								class3 = class4;
								if (class4.bool_2 && licenseContext_0 != null && licenseContext_0.UsageMode == LicenseUsageMode.Runtime)
								{
									class4.bool_6 = false;
								}
								if (class4.bool_6 && !smethod_15(class4.int_2, class4))
								{
									flag2 = true;
									flag8 = false;
									Class27.smethod_4().method_9(LicenseStatus.HardwareNotMatched);
								}
								if (flag8 && licenseContext_0 != null)
								{
									if (licenseContext_0.UsageMode == LicenseUsageMode.Runtime && !class4.bool_0)
									{
										Class27.smethod_4().method_9(LicenseStatus.NotChecked);
										flag8 = false;
									}
									if (licenseContext_0.UsageMode == LicenseUsageMode.Designtime && !class4.bool_1)
									{
										Class27.smethod_4().method_9(LicenseStatus.NotChecked);
										flag8 = false;
									}
								}
								if (class4.bool_16)
								{
									flag8 = false;
								}
								if (flag8)
								{
									class2 = class4;
								}
							}
							catch
							{
							}
							if (flag8)
							{
								Assembly[] assemblies2 = AppDomain.CurrentDomain.GetAssemblies();
								bool flag9 = false;
								try
								{
									for (int l = 0; l < assemblies2.Length; l++)
									{
										bool flag10 = true;
										IDictionaryEnumerator enumerator = class2.hashtable_0.GetEnumerator();
										while (enumerator.MoveNext())
										{
											string text7 = enumerator.Key.ToString();
											string text8 = enumerator.Value!.ToString();
											if (text7 == Class4.string_6)
											{
												string text9 = method_13(typeof(Class3).Assembly, typeof(AssemblyVersionAttribute));
												if (text8.Contains("*"))
												{
													text8 = text8.Substring(0, text8.IndexOf("*"));
												}
												if (text9.IndexOf(text8) != 0)
												{
													flag10 = false;
												}
											}
											else if (text7 == Class4.string_7)
											{
												if (method_13(assemblies2[l], typeof(AssemblyCopyrightAttribute)) != text8)
												{
													flag10 = false;
												}
											}
											else if (text7 == Class4.string_8)
											{
												if (method_13(assemblies2[l], typeof(AssemblyTrademarkAttribute)) != text8)
												{
													flag10 = false;
												}
											}
											else if (text7 == Class4.string_9)
											{
												if (method_13(assemblies2[l], typeof(AssemblyCompanyAttribute)) != text8)
												{
													flag10 = false;
												}
											}
											else if (text7 == Class4.string_10)
											{
												if (method_13(assemblies2[l], typeof(AssemblyProductAttribute)) != text8)
												{
													flag10 = false;
												}
											}
											else if (text7 == Class4.string_11)
											{
												if (method_13(assemblies2[l], typeof(AssemblyDescriptionAttribute)) != text8)
												{
													flag10 = false;
												}
											}
											else if (text7 == Class4.string_12)
											{
												if (method_13(assemblies2[l], typeof(AssemblyTitleAttribute)) != text8)
												{
													flag10 = false;
												}
											}
											else if (text7 == Class4.string_5 && method_13(assemblies2[l], typeof(AssemblyName)) != text8)
											{
												flag10 = false;
											}
										}
										if (flag10)
										{
											flag9 = true;
											break;
										}
									}
								}
								catch
								{
								}
								if (!flag9)
								{
									class2 = null;
								}
								if (class2 == null)
								{
									Class27.smethod_4().method_9(LicenseStatus.InvalidSignature);
									flag4 = true;
								}
							}
							try
							{
								if (flag8 && class2 != null && class4.bool_4)
								{
									LicenseStatus licenseStatus_2 = LicenseStatus.NotChecked;
									bool flag11 = false;
									if (!((!class4.bool_5) ? smethod_9(byte_1, byte_2, byte_4, class4, @class, ref licenseStatus_2) : smethod_11(byte_1, byte_2, class4, @class, ref licenseStatus_2)))
									{
										Class27.smethod_4().method_9(licenseStatus_2);
										licenseStatus_ = licenseStatus_2;
										flag3 = true;
										flag8 = false;
										class2 = null;
									}
								}
							}
							catch
							{
							}
							if (flag8 && class2 != null && class4.bool_3)
							{
								bool flag12 = true;
								if (class4.bool_17 && !class5_3.bool_0 && Math.Abs((DateTime.Now - class5_3.dateTime_2).TotalDays) < (double)class4.int_0)
								{
									flag12 = false;
								}
								if (flag12)
								{
									try
									{
										Class7 class5 = new Class7(class4.string_4);
										Random random = new Random();
										byte[] array15 = new byte[16];
										random.NextBytes(array15);
										byte[] array16 = new byte[byte_4.Length + 16];
										Array.Copy(array15, 0, array16, 0, array15.Length);
										Array.Copy(byte_4, 0, array16, array15.Length, byte_4.Length);
										array15 = array16;
										byte[] array17 = class5.method_0(array15);
										byte[] array18 = new byte[0];
										SymmetricAlgorithm symmetricAlgorithm7 = Class1.smethod_8();
										symmetricAlgorithm7.Mode = CipherMode.CBC;
										ICryptoTransform transform7 = symmetricAlgorithm7.CreateDecryptor(byte_1, byte_2);
										MemoryStream memoryStream8 = new MemoryStream();
										CryptoStream cryptoStream7 = new CryptoStream(memoryStream8, transform7, CryptoStreamMode.Write);
										cryptoStream7.Write(array17, 0, array17.Length);
										cryptoStream7.FlushFinalBlock();
										array18 = memoryStream8.ToArray();
										memoryStream8.Close();
										cryptoStream7.Close();
										if (@class.method_0(array18))
										{
											MemoryStream memoryStream9 = new MemoryStream(array18);
											BinaryReader binaryReader3 = new BinaryReader(memoryStream9);
											memoryStream9.Position = 0L;
											byte[] array19 = binaryReader3.ReadBytes(binaryReader3.ReadInt32());
											byte[] array20 = binaryReader3.ReadBytes((int)(memoryStream9.Length - 4L - array19.Length));
											binaryReader3.Close();
											if (Convert.ToBase64String(array15, 0, 16) != Convert.ToBase64String(array20, 0, 16))
											{
												Class27.smethod_4().method_9(LicenseStatus.ServerValidationFailed);
												flag8 = false;
												class2 = null;
												class5_3.bool_0 = true;
											}
											else if (array20[16] == 0)
											{
												Class27.smethod_4().method_9(LicenseStatus.ServerValidationFailed);
												flag8 = false;
												class2 = null;
												class5_3.bool_0 = true;
											}
											else
											{
												class5_3.dateTime_2 = DateTime.Now;
												class5_3.bool_0 = false;
												flag = true;
											}
										}
										else
										{
											Class27.smethod_4().method_9(LicenseStatus.ServerValidationFailed);
											flag8 = false;
											class2 = null;
											class5_3.bool_0 = true;
										}
									}
									catch (Exception)
									{
										Class27.smethod_4().method_9(LicenseStatus.ServerValidationFailed);
										flag8 = false;
										class2 = null;
										class5_3.bool_0 = true;
									}
								}
							}
							if (!flag8 || class2 == null || !class4.bool_4)
							{
							}
							if (class2 != null)
							{
								if (array14 != null)
								{
									byte_0 = array14;
								}
								if (class2.bool_12)
								{
									string_0 = class2.string_3;
								}
								else
								{
									string_0 = string_1;
								}
								Class27.smethod_4().method_9(LicenseStatus.NotChecked);
								Class27.smethod_4().method_11(LicenseLocation.HDD);
							}
						}
						else
						{
							Class27.smethod_4().method_9(LicenseStatus.InvalidSignature);
							flag4 = true;
						}
					}
				}
			}
			else
			{
				if (class2 == null && @class.bool_27 && array11.Length > 0)
				{
					Class27.smethod_4().method_7(LicenseStatus.LicenseFileNotFound);
					try
					{
						Class6 class6 = new Class6();
						array = new byte[0];
						byte[] array21 = new byte[0];
						try
						{
							array2 = array11;
							array21 = array2;
							SymmetricAlgorithm symmetricAlgorithm8 = Class1.smethod_8();
							symmetricAlgorithm8.Mode = CipherMode.CBC;
							ICryptoTransform transform8 = symmetricAlgorithm8.CreateDecryptor(byte_1, byte_2);
							MemoryStream memoryStream10 = new MemoryStream();
							CryptoStream cryptoStream8 = new CryptoStream(memoryStream10, transform8, CryptoStreamMode.Write);
							cryptoStream8.Write(array2, 0, array2.Length);
							cryptoStream8.FlushFinalBlock();
							array = memoryStream10.ToArray();
							memoryStream10.Close();
							cryptoStream8.Close();
						}
						catch (Exception)
						{
							array = new byte[0];
						}
						if (array.Length > 0)
						{
							if (class6.method_0(array))
							{
								bool flag13 = true;
								try
								{
									class6.method_1(array);
									class3 = class6;
									if (class6.bool_2 && licenseContext_0 != null && licenseContext_0.UsageMode == LicenseUsageMode.Runtime)
									{
										class6.bool_6 = false;
									}
									if (class6.bool_6 && !smethod_15(class6.int_2, class6))
									{
										Class27.smethod_4().method_7(LicenseStatus.HardwareNotMatched);
										flag13 = false;
										flag2 = true;
									}
									if (flag13 && licenseContext_0 != null)
									{
										if (licenseContext_0.UsageMode == LicenseUsageMode.Runtime && !class6.bool_0)
										{
											Class27.smethod_4().method_7(LicenseStatus.NotChecked);
											flag13 = false;
										}
										if (licenseContext_0.UsageMode == LicenseUsageMode.Designtime && !class6.bool_1)
										{
											Class27.smethod_4().method_7(LicenseStatus.NotChecked);
											flag13 = false;
										}
									}
									if (class6.bool_16)
									{
										flag13 = false;
									}
									if (flag13)
									{
										class2 = class6;
									}
								}
								catch
								{
								}
								try
								{
									if (flag13)
									{
										Assembly[] assemblies3 = AppDomain.CurrentDomain.GetAssemblies();
										bool flag14 = false;
										for (int m = 0; m < assemblies3.Length; m++)
										{
											bool flag15 = true;
											IDictionaryEnumerator enumerator2 = class2.hashtable_0.GetEnumerator();
											while (enumerator2.MoveNext())
											{
												string text10 = enumerator2.Key.ToString();
												string text11 = enumerator2.Value!.ToString();
												if (text10 == Class4.string_6)
												{
													string text12 = method_13(typeof(Class3).Assembly, typeof(AssemblyVersionAttribute));
													if (text11.Contains("*"))
													{
														text11 = text11.Substring(0, text11.IndexOf("*"));
													}
													if (text12.IndexOf(text11) != 0)
													{
														flag15 = false;
													}
												}
												else if (text10 == Class4.string_7)
												{
													if (method_13(assemblies3[m], typeof(AssemblyCopyrightAttribute)) != text11)
													{
														flag15 = false;
													}
												}
												else if (text10 == Class4.string_8)
												{
													if (method_13(assemblies3[m], typeof(AssemblyTrademarkAttribute)) != text11)
													{
														flag15 = false;
													}
												}
												else if (text10 == Class4.string_9)
												{
													if (method_13(assemblies3[m], typeof(AssemblyCompanyAttribute)) != text11)
													{
														flag15 = false;
													}
												}
												else if (text10 == Class4.string_10)
												{
													if (method_13(assemblies3[m], typeof(AssemblyProductAttribute)) != text11)
													{
														flag15 = false;
													}
												}
												else if (text10 == Class4.string_11)
												{
													if (method_13(assemblies3[m], typeof(AssemblyDescriptionAttribute)) != text11)
													{
														flag15 = false;
													}
												}
												else if (text10 == Class4.string_12)
												{
													if (method_13(assemblies3[m], typeof(AssemblyTitleAttribute)) != text11)
													{
														flag15 = false;
													}
												}
												else if (text10 == Class4.string_5 && method_13(assemblies3[m], typeof(AssemblyName)) != text11)
												{
													flag15 = false;
												}
											}
											if (flag15)
											{
												flag14 = true;
												break;
											}
										}
										if (!flag14)
										{
											class2 = null;
										}
										if (class2 == null)
										{
											Class27.smethod_4().method_7(LicenseStatus.InvalidSignature);
											flag4 = true;
										}
									}
								}
								catch
								{
								}
								try
								{
									if (flag13 && class2 != null && class6.bool_4)
									{
										LicenseStatus licenseStatus_3 = LicenseStatus.NotChecked;
										bool flag16 = false;
										if (!((!class6.bool_5) ? smethod_9(byte_1, byte_2, array21, class6, @class, ref licenseStatus_3) : smethod_11(byte_1, byte_2, class6, @class, ref licenseStatus_3)))
										{
											Class27.smethod_4().method_7(licenseStatus_3);
											licenseStatus_ = licenseStatus_3;
											flag3 = true;
											flag13 = false;
											class2 = null;
										}
									}
								}
								catch
								{
								}
								if (flag13 && class2 != null && class6.bool_3)
								{
									bool flag17 = true;
									if (class6.bool_17 && !class5_3.bool_0 && Math.Abs((DateTime.Now - class5_3.dateTime_2).TotalDays) < (double)class6.int_0)
									{
										flag17 = false;
									}
									if (flag17)
									{
										try
										{
											Class7 class7 = new Class7(class6.string_4);
											Random random2 = new Random();
											byte[] array22 = new byte[16];
											random2.NextBytes(array22);
											byte[] array23 = new byte[array21.Length + 16];
											Array.Copy(array22, 0, array23, 0, array22.Length);
											Array.Copy(array21, 0, array23, array22.Length, array21.Length);
											array22 = array23;
											byte[] array24 = class7.method_0(array22);
											byte[] array25 = new byte[0];
											SymmetricAlgorithm symmetricAlgorithm9 = Class1.smethod_8();
											symmetricAlgorithm9.Mode = CipherMode.CBC;
											ICryptoTransform transform9 = symmetricAlgorithm9.CreateDecryptor(byte_1, byte_2);
											MemoryStream memoryStream11 = new MemoryStream();
											CryptoStream cryptoStream9 = new CryptoStream(memoryStream11, transform9, CryptoStreamMode.Write);
											cryptoStream9.Write(array24, 0, array24.Length);
											cryptoStream9.FlushFinalBlock();
											array25 = memoryStream11.ToArray();
											memoryStream11.Close();
											cryptoStream9.Close();
											if (@class.method_0(array25))
											{
												MemoryStream memoryStream12 = new MemoryStream(array25);
												BinaryReader binaryReader4 = new BinaryReader(memoryStream12);
												memoryStream12.Position = 0L;
												byte[] array26 = binaryReader4.ReadBytes(binaryReader4.ReadInt32());
												byte[] array27 = binaryReader4.ReadBytes((int)(memoryStream12.Length - 4L - array26.Length));
												binaryReader4.Close();
												if (Convert.ToBase64String(array22, 0, 16) != Convert.ToBase64String(array27, 0, 16))
												{
													Class27.smethod_4().method_7(LicenseStatus.ServerValidationFailed);
													flag13 = false;
													class2 = null;
													class5_3.bool_0 = true;
												}
												else if (array27[16] == 0)
												{
													Class27.smethod_4().method_7(LicenseStatus.ServerValidationFailed);
													flag13 = false;
													class2 = null;
													class5_3.bool_0 = true;
												}
												else
												{
													class5_3.dateTime_2 = DateTime.Now;
													class5_3.bool_0 = false;
													flag = true;
												}
											}
											else
											{
												Class27.smethod_4().method_7(LicenseStatus.ServerValidationFailed);
												flag13 = false;
												class2 = null;
												class5_3.bool_0 = true;
											}
										}
										catch (Exception)
										{
											Class27.smethod_4().method_7(LicenseStatus.ServerValidationFailed);
											flag13 = false;
											class2 = null;
											class5_3.bool_0 = true;
										}
									}
								}
								if (class2 != null)
								{
									if (class2.bool_12)
									{
										string_0 = class2.string_3;
									}
									else
									{
										string_0 = string_1;
									}
									if (array21 != null)
									{
										byte_0 = array21;
									}
									Class27.smethod_4().method_7(LicenseStatus.NotChecked);
									Class27.smethod_4().method_11(LicenseLocation.ExternalAssembly);
								}
							}
							else
							{
								Class27.smethod_4().method_7(LicenseStatus.InvalidSignature);
								flag4 = true;
							}
						}
					}
					catch
					{
					}
				}
				if (class2 == null && @class.bool_27)
				{
					Class27.smethod_4().method_7(LicenseStatus.LicenseFileNotFound);
					ArrayList arrayList = new ArrayList();
					try
					{
						if ((object)Assembly.GetCallingAssembly() != null)
						{
							arrayList.Add(Assembly.GetCallingAssembly());
						}
					}
					catch
					{
					}
					try
					{
						if ((object)Assembly.GetEntryAssembly() != null)
						{
							arrayList.Add(Assembly.GetEntryAssembly());
						}
					}
					catch
					{
					}
					try
					{
						if ((object)Assembly.GetExecutingAssembly() != null)
						{
							arrayList.Add(Assembly.GetExecutingAssembly());
						}
					}
					catch
					{
					}
					arrayList.Add(type_0.Assembly);
					for (int n = 0; n < arrayList.Count; n++)
					{
						try
						{
							string text13 = @class.string_18.Replace(Class4.string_38, Class4.string_39);
							if (text13?.Contains("\\") ?? false)
							{
								int num2 = text13.LastIndexOf("\\");
								if (num2 + 1 < text13.Length)
								{
									text13 = text13.Substring(num2 + 1);
								}
							}
							string[] manifestResourceNames = ((Assembly)arrayList[n]).GetManifestResourceNames();
							for (int num3 = 0; num3 < manifestResourceNames.Length; num3++)
							{
								try
								{
									if (manifestResourceNames[num3].ToUpper().IndexOf(text13.ToUpper()) < 0)
									{
										continue;
									}
									Class6 class8 = new Class6();
									array = new byte[0];
									byte[] array28 = new byte[0];
									try
									{
										Stream manifestResourceStream = ((Assembly)arrayList[n]).GetManifestResourceStream(manifestResourceNames[num3]);
										manifestResourceStream.Position = 0L;
										array2 = new byte[manifestResourceStream.Length];
										manifestResourceStream.Read(array2, 0, array2.Length);
										manifestResourceStream.Close();
										array28 = array2;
										SymmetricAlgorithm symmetricAlgorithm10 = Class1.smethod_8();
										symmetricAlgorithm10.Mode = CipherMode.CBC;
										ICryptoTransform transform10 = symmetricAlgorithm10.CreateDecryptor(byte_1, byte_2);
										MemoryStream memoryStream13 = new MemoryStream();
										CryptoStream cryptoStream10 = new CryptoStream(memoryStream13, transform10, CryptoStreamMode.Write);
										cryptoStream10.Write(array2, 0, array2.Length);
										cryptoStream10.FlushFinalBlock();
										array = memoryStream13.ToArray();
										memoryStream13.Close();
										cryptoStream10.Close();
									}
									catch
									{
										array = new byte[0];
									}
									if (array.Length <= 0)
									{
										continue;
									}
									if (class8.method_0(array))
									{
										bool flag18 = true;
										class8.method_1(array);
										class3 = class8;
										if (class8.bool_2 && licenseContext_0 != null && licenseContext_0.UsageMode == LicenseUsageMode.Runtime)
										{
											class8.bool_6 = false;
										}
										if (class8.bool_6 && !smethod_15(class8.int_2, class8))
										{
											Class27.smethod_4().method_7(LicenseStatus.HardwareNotMatched);
											flag2 = true;
											flag18 = false;
										}
										if (flag18 && licenseContext_0 != null)
										{
											if (licenseContext_0.UsageMode == LicenseUsageMode.Runtime && !class8.bool_0)
											{
												Class27.smethod_4().method_7(LicenseStatus.NotChecked);
												flag18 = false;
											}
											if (licenseContext_0.UsageMode == LicenseUsageMode.Designtime && !class8.bool_1)
											{
												Class27.smethod_4().method_7(LicenseStatus.NotChecked);
												flag18 = false;
											}
										}
										if (class8.bool_16)
										{
											flag18 = false;
										}
										if (flag18)
										{
											class2 = class8;
										}
										if (flag18)
										{
											IDictionaryEnumerator enumerator3 = class2.hashtable_0.GetEnumerator();
											while (enumerator3.MoveNext())
											{
												string text14 = enumerator3.Key.ToString();
												string text15 = enumerator3.Value!.ToString();
												if (text14 == Class4.string_6)
												{
													string text16 = method_13(typeof(Class3).Assembly, typeof(AssemblyVersionAttribute));
													if (text15.Contains("*"))
													{
														text15 = text15.Substring(0, text15.IndexOf("*"));
													}
													if (text16.IndexOf(text15) != 0)
													{
														class2 = null;
													}
												}
												else if (text14 == Class4.string_7)
												{
													if (method_13((Assembly)arrayList[n], typeof(AssemblyCopyrightAttribute)) != text15)
													{
														class2 = null;
													}
												}
												else if (text14 == Class4.string_8)
												{
													if (method_13((Assembly)arrayList[n], typeof(AssemblyTrademarkAttribute)) != text15)
													{
														class2 = null;
													}
												}
												else if (text14 == Class4.string_9)
												{
													if (method_13((Assembly)arrayList[n], typeof(AssemblyCompanyAttribute)) != text15)
													{
														class2 = null;
													}
												}
												else if (text14 == Class4.string_10)
												{
													if (method_13((Assembly)arrayList[n], typeof(AssemblyProductAttribute)) != text15)
													{
														class2 = null;
													}
												}
												else if (text14 == Class4.string_11)
												{
													if (method_13((Assembly)arrayList[n], typeof(AssemblyDescriptionAttribute)) != text15)
													{
														class2 = null;
													}
												}
												else if (text14 == Class4.string_12)
												{
													if (method_13((Assembly)arrayList[n], typeof(AssemblyTitleAttribute)) != text15)
													{
														class2 = null;
													}
												}
												else if (text14 == Class4.string_5 && method_13((Assembly)arrayList[n], typeof(AssemblyName)) != text15)
												{
													class2 = null;
												}
											}
											if (class2 == null)
											{
												Class27.smethod_4().method_7(LicenseStatus.InvalidSignature);
												flag4 = true;
											}
										}
										if (flag18 && class2 != null && class8.bool_4)
										{
											LicenseStatus licenseStatus_4 = LicenseStatus.NotChecked;
											bool flag19 = false;
											if (!((!class8.bool_5) ? smethod_9(byte_1, byte_2, array28, class8, @class, ref licenseStatus_4) : smethod_11(byte_1, byte_2, class8, @class, ref licenseStatus_4)))
											{
												Class27.smethod_4().method_7(licenseStatus_4);
												licenseStatus_ = licenseStatus_4;
												flag3 = true;
												flag18 = false;
												class2 = null;
											}
										}
										if (flag18 && class2 != null && class8.bool_3)
										{
											bool flag20 = true;
											if (class8.bool_17 && !class5_3.bool_0 && Math.Abs((DateTime.Now - class5_3.dateTime_2).TotalDays) < (double)class8.int_0)
											{
												flag20 = false;
											}
											if (flag20)
											{
												try
												{
													Class7 class9 = new Class7(class8.string_4);
													Random random3 = new Random();
													byte[] array29 = new byte[16];
													random3.NextBytes(array29);
													byte[] array30 = new byte[array28.Length + 16];
													Array.Copy(array29, 0, array30, 0, array29.Length);
													Array.Copy(array28, 0, array30, array29.Length, array28.Length);
													array29 = array30;
													byte[] array31 = class9.method_0(array29);
													byte[] array32 = new byte[0];
													SymmetricAlgorithm symmetricAlgorithm11 = Class1.smethod_8();
													symmetricAlgorithm11.Mode = CipherMode.CBC;
													ICryptoTransform transform11 = symmetricAlgorithm11.CreateDecryptor(byte_1, byte_2);
													MemoryStream memoryStream14 = new MemoryStream();
													CryptoStream cryptoStream11 = new CryptoStream(memoryStream14, transform11, CryptoStreamMode.Write);
													cryptoStream11.Write(array31, 0, array31.Length);
													cryptoStream11.FlushFinalBlock();
													array32 = memoryStream14.ToArray();
													memoryStream14.Close();
													cryptoStream11.Close();
													if (@class.method_0(array32))
													{
														MemoryStream memoryStream15 = new MemoryStream(array32);
														BinaryReader binaryReader5 = new BinaryReader(memoryStream15);
														memoryStream15.Position = 0L;
														byte[] array33 = binaryReader5.ReadBytes(binaryReader5.ReadInt32());
														byte[] array34 = binaryReader5.ReadBytes((int)(memoryStream15.Length - 4L - array33.Length));
														binaryReader5.Close();
														if (Convert.ToBase64String(array29, 0, 16) != Convert.ToBase64String(array34, 0, 16))
														{
															Class27.smethod_4().method_7(LicenseStatus.ServerValidationFailed);
															flag18 = false;
															class2 = null;
															class5_3.bool_0 = true;
														}
														else if (array34[16] == 0)
														{
															Class27.smethod_4().method_7(LicenseStatus.ServerValidationFailed);
															flag18 = false;
															class2 = null;
															class5_3.bool_0 = true;
														}
														else
														{
															class5_3.dateTime_2 = DateTime.Now;
															class5_3.bool_0 = false;
															flag = true;
														}
													}
													else
													{
														Class27.smethod_4().method_7(LicenseStatus.ServerValidationFailed);
														flag18 = false;
														class2 = null;
														class5_3.bool_0 = true;
													}
												}
												catch (Exception)
												{
													Class27.smethod_4().method_7(LicenseStatus.ServerValidationFailed);
													flag18 = false;
													class2 = null;
													class5_3.bool_0 = true;
												}
											}
										}
										if (class2 != null)
										{
											if (class2.bool_12)
											{
												string_0 = class2.string_3;
											}
											else
											{
												string_0 = string_1;
											}
											if (array28 != null)
											{
												byte_0 = array28;
											}
											Class27.smethod_4().method_7(LicenseStatus.NotChecked);
											Class27.smethod_4().method_11(LicenseLocation.ExternalAssembly);
											break;
										}
									}
									else
									{
										Class27.smethod_4().method_7(LicenseStatus.InvalidSignature);
										flag4 = true;
									}
								}
								catch
								{
								}
							}
						}
						catch
						{
						}
					}
				}
				if (class2 == null && @class.bool_28)
				{
					Class27.smethod_4().method_9(LicenseStatus.LicenseFileNotFound);
					ArrayList arrayList2 = new ArrayList();
					try
					{
						if (File.Exists(smethod_23()))
						{
							arrayList2.Add(Path.GetDirectoryName(smethod_23()) + "\\");
						}
						else if (Class1.smethod_13(type_0.Assembly).ToString()!.Length > 0 && File.Exists(Class1.smethod_13(type_0.Assembly).ToString()))
						{
							arrayList2.Add(Path.GetDirectoryName(Class1.smethod_13(type_0.Assembly).ToString()) + "\\");
						}
					}
					catch
					{
					}
					try
					{
						if (File.Exists(smethod_23()) && Class1.smethod_13(type_0.Assembly).ToString()!.Length > 0 && File.Exists(Class1.smethod_13(type_0.Assembly).ToString()) && Path.GetDirectoryName(smethod_23())!.ToString() != Path.GetDirectoryName(Class1.smethod_13(type_0.Assembly).ToString())!.ToString())
						{
							arrayList2.Add(Path.GetDirectoryName(Class1.smethod_13(type_0.Assembly).ToString()) + "\\");
						}
					}
					catch
					{
					}
					try
					{
						if (Directory.Exists(AppDomain.CurrentDomain.BaseDirectory) && arrayList2.IndexOf(AppDomain.CurrentDomain.BaseDirectory) < 0)
						{
							arrayList2.Add(AppDomain.CurrentDomain.BaseDirectory);
						}
					}
					catch
					{
					}
					try
					{
						if (Directory.Exists(AppDomain.CurrentDomain.SetupInformation.get_PrivateBinPath()))
						{
							arrayList2.Add(AppDomain.CurrentDomain.SetupInformation.get_PrivateBinPath());
						}
					}
					catch
					{
					}
					try
					{
						if (AppDomain.CurrentDomain.GetData("DataDirectory") != null)
						{
							string text17 = AppDomain.CurrentDomain.GetData("DataDirectory")!.ToString();
							if (Directory.Exists(text17))
							{
								arrayList2.Add(text17 + "\\");
							}
						}
					}
					catch
					{
					}
					try
					{
						if (AppDomain.CurrentDomain.GetData("PRIVATE_BINPATH") != null)
						{
							string text18 = AppDomain.CurrentDomain.GetData("PRIVATE_BINPATH")!.ToString();
							if (Directory.Exists(text18))
							{
								arrayList2.Add(text18 + "\\");
							}
						}
					}
					catch
					{
					}
					string text19 = @class.string_18;
					if (text19?.Contains("\\") ?? false)
					{
						try
						{
							int num4 = text19.LastIndexOf("\\");
							if (num4 > 0)
							{
								string text20 = text19.Substring(0, num4);
								text20 = text20.Replace("[ApplicationData]", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).Replace("[CommonApplicationData]", Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData));
								text20 = text20.Replace("[MyDocuments]", Environment.GetFolderPath(Environment.SpecialFolder.Personal));
								text20 = text20.Replace("[LocalApplicationData]", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
								string text21 = "[AssemblyLocation]";
								if (text20.Contains(text21))
								{
									text20 = text20.Replace(text21, Path.GetDirectoryName(typeof(Class3).Assembly.Location));
								}
								arrayList2.Add(text20);
							}
							if (num4 + 1 < text19.Length)
							{
								text19 = text19.Substring(num4 + 1);
							}
						}
						catch
						{
						}
					}
					for (int num5 = 0; num5 < arrayList2.Count; num5++)
					{
						try
						{
							string[] files = Directory.GetFiles((string)arrayList2[num5], text19);
							try
							{
								DateTime[] array35 = new DateTime[files.Length];
								for (int num6 = 0; num6 < files.Length; num6++)
								{
									ref DateTime reference = ref array35[num6];
									reference = new FileInfo(files[num6]).LastWriteTime;
									if (array35[num6].Year >= 1600)
									{
										ref DateTime reference2 = ref array35[num6];
										reference2 = new FileInfo(files[num6]).CreationTime;
									}
								}
								Array.Sort(array35, files);
								Array.Reverse((Array)files);
							}
							catch
							{
							}
							for (int num7 = 0; num7 < files.Length; num7++)
							{
								try
								{
									Class6 class10 = new Class6();
									array = new byte[0];
									byte[] array36 = new byte[0];
									try
									{
										FileStream fileStream = new FileStream(files[num7], FileMode.Open, FileAccess.Read);
										fileStream.Position = 0L;
										array2 = new byte[fileStream.Length];
										fileStream.Read(array2, 0, array2.Length);
										fileStream.Close();
										array36 = array2;
										SymmetricAlgorithm symmetricAlgorithm12 = Class1.smethod_8();
										symmetricAlgorithm12.Mode = CipherMode.CBC;
										ICryptoTransform transform12 = symmetricAlgorithm12.CreateDecryptor(byte_1, byte_2);
										MemoryStream memoryStream16 = new MemoryStream();
										CryptoStream cryptoStream12 = new CryptoStream(memoryStream16, transform12, CryptoStreamMode.Write);
										cryptoStream12.Write(array2, 0, array2.Length);
										cryptoStream12.FlushFinalBlock();
										array = memoryStream16.ToArray();
										memoryStream16.Close();
										cryptoStream12.Close();
									}
									catch
									{
										array = new byte[0];
									}
									if (array.Length <= 0)
									{
										continue;
									}
									if (class10.method_0(array))
									{
										bool flag21 = true;
										class10.method_1(array);
										class3 = class10;
										if (class10.bool_2 && licenseContext_0 != null && licenseContext_0.UsageMode == LicenseUsageMode.Runtime)
										{
											class10.bool_6 = false;
										}
										if (class10.bool_6 && !smethod_15(class10.int_2, class10))
										{
											Class27.smethod_4().method_9(LicenseStatus.HardwareNotMatched);
											flag21 = false;
											flag2 = true;
										}
										if (flag21 && licenseContext_0 != null)
										{
											if (licenseContext_0.UsageMode == LicenseUsageMode.Runtime && !class10.bool_0)
											{
												Class27.smethod_4().method_9(LicenseStatus.NotChecked);
												flag21 = false;
											}
											if (licenseContext_0.UsageMode == LicenseUsageMode.Designtime && !class10.bool_1)
											{
												Class27.smethod_4().method_9(LicenseStatus.NotChecked);
												flag21 = false;
											}
										}
										if (class10.bool_16)
										{
											flag21 = false;
										}
										if (flag21)
										{
											class2 = class10;
										}
										if (flag21)
										{
											Assembly[] assemblies4 = AppDomain.CurrentDomain.GetAssemblies();
											bool flag22 = false;
											for (int num8 = 0; num8 < assemblies4.Length; num8++)
											{
												bool flag23 = true;
												IDictionaryEnumerator enumerator4 = class2.hashtable_0.GetEnumerator();
												while (enumerator4.MoveNext())
												{
													string text22 = enumerator4.Key.ToString();
													string text23 = enumerator4.Value!.ToString();
													if (text22 == Class4.string_6)
													{
														string text24 = method_13(typeof(Class3).Assembly, typeof(AssemblyVersionAttribute));
														if (text23.Contains("*"))
														{
															text23 = text23.Substring(0, text23.IndexOf("*"));
														}
														if (text24.IndexOf(text23) != 0)
														{
															flag23 = false;
														}
													}
													else if (text22 == Class4.string_7)
													{
														if (method_13(assemblies4[num8], typeof(AssemblyCopyrightAttribute)) != text23)
														{
															flag23 = false;
														}
													}
													else if (text22 == Class4.string_8)
													{
														if (method_13(assemblies4[num8], typeof(AssemblyTrademarkAttribute)) != text23)
														{
															flag23 = false;
														}
													}
													else if (text22 == Class4.string_9)
													{
														if (method_13(assemblies4[num8], typeof(AssemblyCompanyAttribute)) != text23)
														{
															flag23 = false;
														}
													}
													else if (text22 == Class4.string_10)
													{
														if (method_13(assemblies4[num8], typeof(AssemblyProductAttribute)) != text23)
														{
															flag23 = false;
														}
													}
													else if (text22 == Class4.string_11)
													{
														if (method_13(assemblies4[num8], typeof(AssemblyDescriptionAttribute)) != text23)
														{
															flag23 = false;
														}
													}
													else if (text22 == Class4.string_12)
													{
														if (method_13(assemblies4[num8], typeof(AssemblyTitleAttribute)) != text23)
														{
															flag23 = false;
														}
													}
													else if (text22 == Class4.string_5 && method_13(assemblies4[num8], typeof(AssemblyName)) != text23)
													{
														flag23 = false;
													}
												}
												if (flag23)
												{
													flag22 = true;
													break;
												}
											}
											if (!flag22)
											{
												class2 = null;
											}
											if (class2 == null)
											{
												Class27.smethod_4().method_9(LicenseStatus.InvalidSignature);
												flag4 = true;
											}
										}
										if (flag21 && class2 != null && class10.bool_4)
										{
											LicenseStatus licenseStatus_5 = LicenseStatus.NotChecked;
											bool flag24 = false;
											if (!((!class10.bool_5) ? smethod_9(byte_1, byte_2, array36, class10, @class, ref licenseStatus_5) : smethod_11(byte_1, byte_2, class10, @class, ref licenseStatus_5)))
											{
												Class27.smethod_4().method_9(licenseStatus_5);
												licenseStatus_ = licenseStatus_5;
												flag3 = true;
												flag21 = false;
												class2 = null;
											}
										}
										if (flag21 && class2 != null && class10.bool_3)
										{
											bool flag25 = true;
											if (class10.bool_17 && !class5_3.bool_0 && Math.Abs((DateTime.Now - class5_3.dateTime_2).TotalDays) < (double)class10.int_0)
											{
												flag25 = false;
											}
											if (flag25)
											{
												try
												{
													Class7 class11 = new Class7(class10.string_4);
													Random random4 = new Random();
													byte[] array37 = new byte[16];
													random4.NextBytes(array37);
													byte[] array38 = new byte[array36.Length + 16];
													Array.Copy(array37, 0, array38, 0, array37.Length);
													Array.Copy(array36, 0, array38, array37.Length, array36.Length);
													array37 = array38;
													byte[] array39 = class11.method_0(array37);
													byte[] array40 = new byte[0];
													SymmetricAlgorithm symmetricAlgorithm13 = Class1.smethod_8();
													symmetricAlgorithm13.Mode = CipherMode.CBC;
													ICryptoTransform transform13 = symmetricAlgorithm13.CreateDecryptor(byte_1, byte_2);
													MemoryStream memoryStream17 = new MemoryStream();
													CryptoStream cryptoStream13 = new CryptoStream(memoryStream17, transform13, CryptoStreamMode.Write);
													cryptoStream13.Write(array39, 0, array39.Length);
													cryptoStream13.FlushFinalBlock();
													array40 = memoryStream17.ToArray();
													memoryStream17.Close();
													cryptoStream13.Close();
													if (@class.method_0(array40))
													{
														MemoryStream memoryStream18 = new MemoryStream(array40);
														BinaryReader binaryReader6 = new BinaryReader(memoryStream18);
														memoryStream18.Position = 0L;
														byte[] array41 = binaryReader6.ReadBytes(binaryReader6.ReadInt32());
														byte[] array42 = binaryReader6.ReadBytes((int)(memoryStream18.Length - 4L - array41.Length));
														binaryReader6.Close();
														if (Convert.ToBase64String(array37, 0, 16) != Convert.ToBase64String(array42, 0, 16))
														{
															Class27.smethod_4().method_9(LicenseStatus.ServerValidationFailed);
															flag21 = false;
															class2 = null;
															class5_3.bool_0 = true;
														}
														else if (array42[16] == 0)
														{
															Class27.smethod_4().method_9(LicenseStatus.ServerValidationFailed);
															flag21 = false;
															class2 = null;
															class5_3.bool_0 = true;
														}
														else
														{
															class5_3.dateTime_2 = DateTime.Now;
															class5_3.bool_0 = false;
															flag = true;
														}
													}
													else
													{
														Class27.smethod_4().method_9(LicenseStatus.ServerValidationFailed);
														flag21 = false;
														class2 = null;
														class5_3.bool_0 = true;
													}
												}
												catch (Exception)
												{
													Class27.smethod_4().method_9(LicenseStatus.ServerValidationFailed);
													flag21 = false;
													class2 = null;
													class5_3.bool_0 = true;
												}
											}
										}
										if (class2 != null)
										{
											if (class2.bool_12)
											{
												string_0 = class2.string_3;
											}
											else
											{
												string_0 = string_1;
											}
											if (array36 != null)
											{
												byte_0 = array36;
											}
											Class27.smethod_4().method_9(LicenseStatus.NotChecked);
											Class27.smethod_4().method_11(LicenseLocation.HDD);
											if (@class.bool_27 && LicenseManager.CurrentContext != null && LicenseManager.UsageMode == LicenseUsageMode.Designtime)
											{
												Class27.smethod_7(byte_0, files[num7]);
											}
											break;
										}
									}
									else
									{
										Class27.smethod_4().method_9(LicenseStatus.InvalidSignature);
										flag4 = true;
									}
								}
								catch
								{
								}
							}
						}
						catch
						{
						}
					}
				}
			}
		}
		bool flag26 = false;
		bool flag27 = true;
		if (flag)
		{
			smethod_21(ref class5_3, type_0, bool_16: true, null);
		}
		if (class2 != null)
		{
			try
			{
				if (class2.bool_12)
				{
					string_0 = class2.string_3;
				}
				else
				{
					string_0 = string_1;
				}
				flag26 = true;
				@class.bool_3 = class2.bool_3;
				@class.string_4 = class2.string_4;
				@class.bool_4 = class2.bool_4;
				@class.string_1 = class2.string_1;
				@class.string_2 = class2.string_2;
				@class.bool_5 = class2.bool_5;
				@class.int_2 = class2.int_2;
				@class.bool_15 = class2.bool_15;
				@class.hashtable_0 = class2.hashtable_0;
				@class.bool_6 = class2.bool_6;
				@class.string_5 = class2.string_5;
				@class.bool_8 = class2.bool_8;
				@class.bool_9 = class2.bool_9;
				@class.bool_7 = class2.bool_7;
				@class.bool_14 = class2.bool_14;
				@class.bool_10 = class2.bool_10;
				@class.bool_11 = class2.bool_11;
				@class.bool_13 = class2.bool_13;
			}
			catch
			{
			}
			try
			{
				if (!class2.bool_20 && !class2.bool_19 && !class2.bool_21 && !class2.bool_22 && !class2.bool_23 && !class2.bool_24 && !class2.bool_25)
				{
					flag27 = false;
				}
				if (!class2.bool_15)
				{
					flag27 = false;
				}
				else
				{
					@class.bool_25 = class2.bool_25;
					@class.bool_20 = class2.bool_20;
					@class.dateTime_0 = class2.dateTime_0;
					@class.bool_19 = class2.bool_19;
					@class.int_3 = class2.int_3;
					@class.bool_21 = class2.bool_21;
					@class.int_4 = class2.int_4;
					@class.bool_22 = class2.bool_22;
					@class.int_5 = class2.int_5;
					@class.bool_23 = class2.bool_23;
					@class.int_6 = class2.int_6;
					@class.bool_24 = class2.bool_24;
					@class.int_7 = class2.int_7;
					@class.bool_38 = class2.bool_38;
					@class.string_13 = class2.string_13;
					@class.bool_39 = class2.bool_39;
					@class.string_14 = class2.string_14;
					@class.bool_40 = class2.bool_40;
					@class.string_15 = class2.string_15;
					@class.bool_41 = class2.bool_41;
					@class.string_16 = class2.string_16;
				}
			}
			catch
			{
			}
		}
		else
		{
			try
			{
				@class.bool_6 = false;
				@class.string_5 = Class4.string_13;
				@class.bool_8 = false;
				@class.bool_9 = false;
				@class.bool_7 = false;
				@class.bool_14 = false;
				@class.bool_10 = false;
				@class.bool_11 = false;
				@class.bool_3 = false;
				@class.string_4 = "";
				@class.bool_4 = false;
				@class.string_1 = "http:\\\\";
				@class.string_2 = string.Empty;
				@class.bool_5 = false;
				@class.int_2 = 0;
				@class.bool_13 = false;
			}
			catch
			{
			}
			if (!@class.bool_30)
			{
				if (bool_6)
				{
					Class14.timer_0 = new System.Threading.Timer(new Class14().method_0, null, int_1, 30000);
				}
				if (@class.bool_35)
				{
					string message = @class.string_9;
					try
					{
						EnableWindow(Process.GetCurrentProcess().MainWindowHandle, bool_16: false);
					}
					catch
					{
					}
					ShowMessage(message);
				}
				try
				{
					TerminateProcess(GetCurrentProcess(), 1);
				}
				catch
				{
				}
				return null;
			}
		}
		try
		{
			if (flag27 && @class.bool_25)
			{
				@class.bool_20 = false;
				@class.dateTime_0 = DateTime.Now;
				@class.bool_19 = false;
				@class.int_3 = 28;
				@class.bool_21 = false;
				@class.int_4 = 20;
				@class.bool_22 = false;
				@class.int_5 = 10;
				@class.bool_23 = false;
				@class.int_6 = 60;
				@class.bool_24 = false;
				@class.int_7 = 1;
			}
		}
		catch
		{
		}
		try
		{
			if (flag26)
			{
				if (flag27 && !@class.bool_13)
				{
					Class27.smethod_4().method_5(LicenseStatus.EvaluationMode);
				}
				else
				{
					Class27.smethod_4().method_5(LicenseStatus.Licensed);
				}
			}
			else if (@class.bool_25)
			{
				if (flag5)
				{
					Class27.smethod_4().method_5(LicenseStatus.Deactivated);
				}
				else if (flag2)
				{
					Class27.smethod_4().method_5(LicenseStatus.HardwareNotMatched);
				}
				else if (flag4)
				{
					Class27.smethod_4().method_5(LicenseStatus.InvalidSignature);
				}
				else if (flag3)
				{
					Class27.smethod_4().method_5(licenseStatus_);
				}
				else
				{
					Class27.smethod_4().method_5(LicenseStatus.LicenseFileNotFound);
				}
			}
			else if (flag27)
			{
				Class27.smethod_4().method_5(LicenseStatus.EvaluationMode);
			}
			else
			{
				Class27.smethod_4().method_5(LicenseStatus.NotChecked);
			}
			if (Class27.smethod_4().method_10() == LicenseLocation.HDD)
			{
				Class27.smethod_4().method_9(Class27.smethod_4().method_4());
			}
			if (Class27.smethod_4().method_10() == LicenseLocation.ExternalAssembly)
			{
				Class27.smethod_4().method_7(Class27.smethod_4().method_4());
			}
		}
		catch
		{
		}
		try
		{
			Class27.smethod_4().method_33(@class.bool_25);
			Class27.smethod_4().method_23(@class.bool_21);
			Class27.smethod_4().Executions = @class.int_4;
			Class27.smethod_4().method_21(0);
			Class27.smethod_4().method_15(@class.bool_20);
			Class27.smethod_4().ExpirationDate = @class.dateTime_0;
			Class27.smethod_4().method_17(@class.bool_19);
			Class27.smethod_4().ExpirationDays = @class.int_3;
			Class27.smethod_4().method_19(0);
			Class27.smethod_4().method_27(@class.bool_23);
			Class27.smethod_4().GlobalTime = @class.int_6;
			Class27.smethod_4().method_29(0);
			Class27.smethod_4().method_31(@class.bool_24);
			Class27.smethod_4().Instances = @class.int_7;
			Class27.smethod_4().method_25(@class.bool_22);
			Class27.smethod_4().Runtime = @class.int_5;
			Class27.smethod_4().method_38().Clear();
			if (class2 != null)
			{
				IDictionaryEnumerator enumerator5 = @class.hashtable_0.GetEnumerator();
				while (enumerator5.MoveNext())
				{
					Class27.smethod_4().method_38().Add(enumerator5.Key.ToString(), enumerator5.Value!.ToString());
				}
			}
			else if (class3 != null)
			{
				IDictionaryEnumerator enumerator6 = class3.hashtable_0.GetEnumerator();
				while (enumerator6.MoveNext())
				{
					Class27.smethod_4().method_38().Add(enumerator6.Key.ToString(), enumerator6.Value!.ToString());
				}
			}
		}
		catch
		{
		}
		try
		{
			Class27.smethod_4().method_13(@class.bool_3);
			Class27.smethod_4().LicenseServer = @class.string_4;
			Class27.smethod_4().FloatingLicense = @class.bool_4;
			Class27.smethod_4().method_3(@class.string_1);
			Class27.smethod_4().HardwareID = @class.string_5;
			Class27.smethod_4().method_37(@class.bool_6);
			Class27.smethod_4().method_45(@class.bool_8);
			Class27.smethod_4().method_47(@class.bool_9);
			Class27.smethod_4().method_43(@class.bool_7);
			Class27.smethod_4().method_41(@class.bool_14);
			Class27.smethod_4().method_49(@class.bool_11);
			Class27.smethod_4().method_51(@class.bool_10);
			Class27.smethod_4().method_55(@class.int_2);
			Class27.smethod_4().method_53(@class.bool_15);
			smethod_32(bool_16: true);
			if (Class17.class17_0 != null)
			{
				Class17.class17_0.method_0();
			}
			if (Class13.class13_0 != null)
			{
				Class13.class13_0.method_0();
			}
			if (Class15.class15_0 != null)
			{
				Class15.class15_0.method_0();
			}
			if (Class16.class16_0 != null)
			{
				Class16.class16_0.method_0();
			}
		}
		catch
		{
		}
		if (flag27)
		{
			if (@class.bool_25)
			{
				if (@class.bool_38 && !@class.bool_13)
				{
					string message2 = @class.string_13;
					ShowMessage(message2);
				}
				sortedList_0[type_0.Assembly.FullName] = true;
				sortedList_1[type_0.Assembly.FullName] = new Class19(this, "");
				return new Class19(this, "");
			}
			if (@class.bool_24)
			{
				try
				{
					string processName = Process.GetCurrentProcess().ProcessName;
					Process[] processesByName = Process.GetProcessesByName(processName);
					if (processesByName.Length > @class.int_7)
					{
						if (@class.bool_36)
						{
							string text25 = @class.string_10;
							text25 = text25.Replace(Class4.string_23, @class.int_7.ToString());
							if (@class.bool_29)
							{
								try
								{
									EnableWindow(Process.GetCurrentProcess().MainWindowHandle, bool_16: false);
								}
								catch
								{
								}
							}
							ShowMessage(text25);
						}
						if (@class.bool_29)
						{
							try
							{
								TerminateProcess(GetCurrentProcess(), 1);
							}
							catch
							{
							}
							return null;
						}
					}
				}
				catch
				{
				}
			}
			try
			{
				smethod_32(bool_16: true);
				if (string_0 != null && string_0.Length > 0)
				{
					class5_3 = null;
					smethod_16(ref class5_3, Class4.string_0, bool_16: true);
					smethod_18(ref class5_3, type_0, null);
					smethod_19(ref class5_3, Class4.string_3, bool_16: true);
					smethod_16(ref class5_3, Class4.string_2, bool_16: true);
					smethod_19(ref class5_3, Class4.string_4, bool_16: true);
				}
				if (class5_3 == null)
				{
					class5_3 = new Class5();
				}
			}
			catch
			{
			}
			try
			{
				class5_3.ulong_0++;
			}
			catch
			{
				class5_3.ulong_0 = 0uL;
			}
			DateTime dateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
			if (@class.bool_19 && dateTime.CompareTo(class5_3.dateTime_1) > 0)
			{
				class5_3.int_2 += Math.Abs(dateTime.Subtract(class5_3.dateTime_1).Days);
			}
			class5_3.dateTime_1 = dateTime;
			if (@class.bool_20)
			{
				if (DateTime.Compare(dateTime, class5_3.dateTime_0) >= 0)
				{
					class5_3.dateTime_0 = dateTime;
				}
			}
			else
			{
				class5_3.dateTime_0 = dateTime;
			}
			if (@class.bool_21)
			{
				class5_3.int_0++;
			}
			int num9 = 0;
			int num10 = 0;
			bool flag28 = false;
			bool flag29 = false;
			bool flag30 = false;
			bool flag31 = false;
			try
			{
				if (@class.bool_22 && @class.bool_26)
				{
					num9++;
				}
				if (@class.bool_23)
				{
					num9++;
					if (class5_3.int_1 >= @class.int_6)
					{
						num10++;
						flag31 = true;
					}
				}
				if (@class.bool_21)
				{
					num9++;
					if (class5_3.int_0 > @class.int_4)
					{
						num10++;
						flag30 = true;
					}
				}
				if (@class.bool_19)
				{
					num9++;
					if (class5_3.int_2 > @class.int_3)
					{
						num10++;
						flag29 = true;
					}
				}
				if (@class.bool_20)
				{
					num9++;
					if (class5_3.dateTime_0 >= @class.dateTime_0)
					{
						num10++;
						flag28 = true;
					}
				}
			}
			catch
			{
			}
			try
			{
				if (@class.bool_21 && flag30 && class5_3.int_0 > @class.int_4 + 1 && ((@class.bool_26 && num9 == num10) || (!@class.bool_26 && num10 > 0)))
				{
					if (@class.bool_13)
					{
						Class27.smethod_4().method_5(LicenseStatus.FullVersionExpired);
					}
					else
					{
						Class27.smethod_4().method_5(LicenseStatus.EvaluationExpired);
					}
					if (Class27.smethod_4().method_10() == LicenseLocation.HDD)
					{
						Class27.smethod_4().method_9(Class27.smethod_4().method_4());
					}
					if (Class27.smethod_4().method_10() == LicenseLocation.ExternalAssembly)
					{
						Class27.smethod_4().method_7(Class27.smethod_4().method_4());
					}
					if (@class.bool_29)
					{
						class5_3.int_0--;
					}
				}
				Class27.smethod_4().method_21(class5_3.int_0);
				Class27.smethod_4().method_19(class5_3.int_2);
				Class27.smethod_4().method_29(class5_3.int_1);
				smethod_21(ref class5_3, type_0, bool_16: true, null);
			}
			catch
			{
			}
			try
			{
				if (@class.bool_38 && !@class.bool_13)
				{
					string text26 = @class.string_13;
					text26 = text26.Replace(Class4.string_18, @class.dateTime_0.ToString());
					text26 = text26.Replace(Class4.string_19, DateTime.Now.ToString());
					int num11 = @class.int_3 - class5_3.int_2;
					if (num11 < 0)
					{
						num11 = 0;
					}
					text26 = text26.Replace(Class4.string_14, class5_3.int_2.ToString());
					text26 = text26.Replace(Class4.string_17, @class.int_3.ToString());
					text26 = text26.Replace(Class4.string_15, num11.ToString());
					int num12 = @class.int_4 - class5_3.int_0;
					if (num12 < 0)
					{
						num12 = 0;
					}
					text26 = text26.Replace(Class4.string_20, class5_3.int_0.ToString());
					text26 = text26.Replace(Class4.string_21, @class.int_4.ToString());
					text26 = text26.Replace(Class4.string_22, num12.ToString());
					int num13 = @class.int_6 - class5_3.int_1;
					if (num13 < 0)
					{
						num13 = 0;
					}
					text26 = text26.Replace(Class4.string_24, class5_3.int_1.ToString());
					text26 = text26.Replace(Class4.string_25, @class.int_6.ToString());
					text26 = text26.Replace(Class4.string_16, num13.ToString());
					ShowMessage(text26);
				}
			}
			catch
			{
			}
			if ((@class.bool_26 && num9 <= num10) || (!@class.bool_26 && num10 > 0))
			{
				if (flag28)
				{
					try
					{
						if (@class.bool_13)
						{
							Class27.smethod_4().method_5(LicenseStatus.FullVersionExpired);
						}
						else
						{
							Class27.smethod_4().method_5(LicenseStatus.EvaluationExpired);
						}
						if (Class27.smethod_4().method_10() == LicenseLocation.HDD)
						{
							Class27.smethod_4().method_9(Class27.smethod_4().method_4());
						}
						if (Class27.smethod_4().method_10() == LicenseLocation.ExternalAssembly)
						{
							Class27.smethod_4().method_7(Class27.smethod_4().method_4());
						}
						if (@class.bool_32)
						{
							string text27 = @class.string_7;
							text27 = text27.Replace(Class4.string_18, @class.dateTime_0.ToString());
							text27 = text27.Replace(Class4.string_19, DateTime.Now.ToString());
							if (@class.bool_29)
							{
								try
								{
									EnableWindow(Process.GetCurrentProcess().MainWindowHandle, bool_16: false);
								}
								catch
								{
								}
							}
							ShowMessage(text27);
						}
						if (@class.bool_29)
						{
							try
							{
								TerminateProcess(GetCurrentProcess(), 1);
							}
							catch
							{
							}
							return null;
						}
					}
					catch
					{
					}
				}
				else if (flag29)
				{
					try
					{
						if (@class.bool_13)
						{
							Class27.smethod_4().method_5(LicenseStatus.FullVersionExpired);
						}
						else
						{
							Class27.smethod_4().method_5(LicenseStatus.EvaluationExpired);
						}
						if (Class27.smethod_4().method_10() == LicenseLocation.HDD)
						{
							Class27.smethod_4().method_9(Class27.smethod_4().method_4());
						}
						if (Class27.smethod_4().method_10() == LicenseLocation.ExternalAssembly)
						{
							Class27.smethod_4().method_7(Class27.smethod_4().method_4());
						}
						if (@class.bool_31)
						{
							int num14 = @class.int_3 - class5_3.int_2;
							if (num14 < 0)
							{
								num14 = 0;
							}
							string text28 = @class.string_6;
							text28 = text28.Replace(Class4.string_14, class5_3.int_2.ToString());
							text28 = text28.Replace(Class4.string_17, @class.int_3.ToString());
							text28 = text28.Replace(Class4.string_15, num14.ToString());
							if (@class.bool_29)
							{
								try
								{
									EnableWindow(Process.GetCurrentProcess().MainWindowHandle, bool_16: false);
								}
								catch
								{
								}
							}
							ShowMessage(text28);
						}
						if (@class.bool_29)
						{
							try
							{
								TerminateProcess(GetCurrentProcess(), 1);
							}
							catch
							{
							}
							return null;
						}
					}
					catch
					{
					}
				}
				else if (flag30)
				{
					try
					{
						if (@class.bool_13)
						{
							Class27.smethod_4().method_5(LicenseStatus.FullVersionExpired);
						}
						else
						{
							Class27.smethod_4().method_5(LicenseStatus.EvaluationExpired);
						}
						if (Class27.smethod_4().method_10() == LicenseLocation.HDD)
						{
							Class27.smethod_4().method_9(Class27.smethod_4().method_4());
						}
						if (Class27.smethod_4().method_10() == LicenseLocation.ExternalAssembly)
						{
							Class27.smethod_4().method_7(Class27.smethod_4().method_4());
						}
						if (@class.bool_33)
						{
							int num15 = @class.int_4 - class5_3.int_0;
							if (num15 < 0)
							{
								num15 = 0;
							}
							string text29 = @class.string_8;
							text29 = text29.Replace(Class4.string_20, class5_3.int_0.ToString());
							text29 = text29.Replace(Class4.string_21, @class.int_4.ToString());
							text29 = text29.Replace(Class4.string_22, num15.ToString());
							if (@class.bool_29)
							{
								try
								{
									EnableWindow(Process.GetCurrentProcess().MainWindowHandle, bool_16: false);
								}
								catch
								{
								}
							}
							ShowMessage(text29);
						}
						if (@class.bool_29)
						{
							try
							{
								TerminateProcess(GetCurrentProcess(), 1);
							}
							catch
							{
							}
							return null;
						}
					}
					catch
					{
					}
				}
				else if (flag31)
				{
					try
					{
						if (@class.bool_13)
						{
							Class27.smethod_4().method_5(LicenseStatus.FullVersionExpired);
						}
						else
						{
							Class27.smethod_4().method_5(LicenseStatus.EvaluationExpired);
						}
						if (Class27.smethod_4().method_10() == LicenseLocation.HDD)
						{
							Class27.smethod_4().method_9(Class27.smethod_4().method_4());
						}
						if (Class27.smethod_4().method_10() == LicenseLocation.ExternalAssembly)
						{
							Class27.smethod_4().method_7(Class27.smethod_4().method_4());
						}
						if (@class.bool_37)
						{
							int num16 = @class.int_6 - class5_3.int_1;
							if (num16 < 0)
							{
								num16 = 0;
							}
							string text30 = @class.string_11;
							text30 = text30.Replace(Class4.string_24, class5_3.int_1.ToString());
							text30 = text30.Replace(Class4.string_25, @class.int_6.ToString());
							text30 = text30.Replace(Class4.string_16, num16.ToString());
							if (@class.bool_29)
							{
								try
								{
									EnableWindow(Process.GetCurrentProcess().MainWindowHandle, bool_16: false);
								}
								catch
								{
								}
							}
							ShowMessage(text30);
						}
						if (@class.bool_29)
						{
							try
							{
								TerminateProcess(GetCurrentProcess(), 1);
							}
							catch
							{
							}
							return null;
						}
					}
					catch
					{
					}
				}
			}
			else
			{
				Class12 class12 = new Class12();
				class12.int_0 = num9;
				class12.int_1 = num10;
				if (@class.bool_23)
				{
					if (Class17.class17_0 != null)
					{
						Class17.class17_0.method_0();
					}
					Class17.class17_0 = new Class17(@class, class5_3, type_0, byte_1, byte_2);
					Class17.class17_0.class12_0 = class12;
					Class17.class17_0.timer_0 = new System.Threading.Timer(Class17.class17_0.method_1, null, 60000, 60000);
				}
				else if (Class17.class17_0 != null)
				{
					Class17.class17_0.method_0();
				}
				if (@class.bool_22)
				{
					if (Class13.class13_0 != null)
					{
						Class13.class13_0.method_0();
					}
					Class13.class13_0 = new Class13(@class, type_0.Assembly);
					Class13.class13_0.class12_0 = class12;
					Class13.class13_0.timer_0 = new System.Threading.Timer(Class13.class13_0.method_1, null, @class.int_5 * 60000, @class.int_5 * 60000);
				}
				else if (Class13.class13_0 != null)
				{
					Class13.class13_0.method_0();
				}
				try
				{
					if (@class.bool_20 || @class.bool_19)
					{
						if (@class.bool_20 && !flag28)
						{
							if (Class15.class15_0 != null)
							{
								Class15.class15_0.method_0();
							}
							Class15.class15_0 = new Class15(@class, class5_3, type_0, byte_1, byte_2);
							Class15.class15_0.class12_0 = class12;
							Class15.class15_0.timer_0 = new System.Threading.Timer(Class15.class15_0.method_1, null, 60000, 60000);
						}
						if (@class.bool_19 && !flag29)
						{
							if (Class16.class16_0 != null)
							{
								Class16.class16_0.method_0();
							}
							Class16.class16_0 = new Class16(@class, class5_3, type_0, byte_1, byte_2);
							Class16.class16_0.class12_0 = class12;
							Class16.class16_0.timer_0 = new System.Threading.Timer(Class16.class16_0.method_1, null, 60000, 60000);
						}
					}
				}
				catch
				{
				}
			}
		}
		sortedList_0[type_0.Assembly.FullName] = true;
		sortedList_1[type_0.Assembly.FullName] = new Class19(this, "");
		return new Class19(this, "");
	}

	private string method_13(Assembly assembly_0, Type type_0)
	{
		try
		{
			if ((object)type_0 == typeof(AssemblyCompanyAttribute))
			{
				AssemblyCompanyAttribute assemblyCompanyAttribute = (AssemblyCompanyAttribute)assembly_0.GetCustomAttributes(type_0, inherit: false)[0];
				return assemblyCompanyAttribute.Company.ToString();
			}
			if ((object)type_0 == typeof(AssemblyCopyrightAttribute))
			{
				AssemblyCopyrightAttribute assemblyCopyrightAttribute = (AssemblyCopyrightAttribute)assembly_0.GetCustomAttributes(type_0, inherit: false)[0];
				return assemblyCopyrightAttribute.Copyright.ToString();
			}
			if ((object)type_0 == typeof(AssemblyDescriptionAttribute))
			{
				AssemblyDescriptionAttribute assemblyDescriptionAttribute = (AssemblyDescriptionAttribute)assembly_0.GetCustomAttributes(type_0, inherit: false)[0];
				return assemblyDescriptionAttribute.Description.ToString();
			}
			if ((object)type_0 == typeof(AssemblyProductAttribute))
			{
				AssemblyProductAttribute assemblyProductAttribute = (AssemblyProductAttribute)assembly_0.GetCustomAttributes(type_0, inherit: false)[0];
				return assemblyProductAttribute.Product.ToString();
			}
			if ((object)type_0 == typeof(AssemblyTitleAttribute))
			{
				AssemblyTitleAttribute assemblyTitleAttribute = (AssemblyTitleAttribute)assembly_0.GetCustomAttributes(type_0, inherit: false)[0];
				return assemblyTitleAttribute.Title.ToString();
			}
			if ((object)type_0 == typeof(AssemblyTrademarkAttribute))
			{
				AssemblyTrademarkAttribute assemblyTrademarkAttribute = (AssemblyTrademarkAttribute)assembly_0.GetCustomAttributes(type_0, inherit: false)[0];
				return assemblyTrademarkAttribute.Trademark.ToString();
			}
			if ((object)type_0 == typeof(AssemblyVersionAttribute))
			{
				Version version = assembly_0.GetName().Version;
				return version.ToString().Replace("v.", "").Replace("v", "");
			}
			if ((object)type_0 == typeof(AssemblyName))
			{
				return assembly_0.GetName().Name;
			}
		}
		catch
		{
			return "";
		}
		return "";
	}

	internal static void ShowMessage(string message)
	{
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			try
			{
				Type[] types = typeof(Class3).Assembly.GetTypes();
				for (int i = 0; i < types.Length; i++)
				{
					object[] customAttributes = types[i].GetCustomAttributes(inherit: false);
					for (int j = 0; j < customAttributes.Length; j++)
					{
						if (customAttributes[j].GetType().FullName == "IntelliLock.AHAECFMDKPDHBEMELAIENJGMLJLPJCOAOFBK")
						{
							types[i].InvokeMember("ShowMessage", BindingFlags.InvokeMethod, null, null, new object[1] { message });
							return;
						}
					}
				}
			}
			catch
			{
			}
			try
			{
				MessageBox.Show(message);
			}
			catch
			{
				smethod_22("<script language='javascript'>alert( \"" + message + "\" );</script>");
			}
		}
		catch
		{
		}
	}

	internal static void smethod_22(string string_18)
	{
	}

	[DllImport("user32.dll")]
	internal static extern bool EnableWindow(IntPtr intptr_0, bool bool_16);

	private static string smethod_23()
	{
		try
		{
			if (string_6 == null)
			{
				Assembly entryAssembly = Assembly.GetEntryAssembly();
				if ((object)entryAssembly == null)
				{
					try
					{
						StringBuilder stringBuilder = new StringBuilder(260);
						GetModuleFileName(IntPtr.Zero, stringBuilder, stringBuilder.Capacity);
						string_6 = Path.GetFullPath(stringBuilder.ToString());
					}
					catch
					{
						string escapedCodeBase = entryAssembly.EscapedCodeBase;
						Uri uri = new Uri(escapedCodeBase);
						if (uri.Scheme == "file")
						{
							string_6 = smethod_24(escapedCodeBase);
						}
						else
						{
							string_6 = uri.ToString();
						}
					}
				}
				else
				{
					string escapedCodeBase2 = entryAssembly.EscapedCodeBase;
					Uri uri2 = new Uri(escapedCodeBase2);
					if (uri2.Scheme == "file")
					{
						string_6 = smethod_24(escapedCodeBase2);
					}
					else
					{
						string_6 = uri2.ToString();
					}
				}
			}
			return string_6;
		}
		catch
		{
			return "";
		}
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern uint GetModuleFileName([In] IntPtr intptr_0, [Out] StringBuilder stringBuilder_0, [In][MarshalAs(UnmanagedType.U4)] int int_2);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern bool TerminateProcess(IntPtr intptr_0, int int_2);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
	internal static extern IntPtr GetCurrentProcess();

	internal static string smethod_24(string string_18)
	{
		Uri uri = new Uri(string_18);
		return uri.LocalPath + uri.Fragment;
	}

	internal static string smethod_25(bool bool_16, bool bool_17, bool bool_18, bool bool_19, bool bool_20, bool bool_21, bool bool_22)
	{
		lock (object_1)
		{
			if (bool_22 && string_2 != null && string_2.Length >= 29)
			{
				return smethod_29(string_2, bool_16, bool_17, bool_18, bool_19, bool_20, bool_21);
			}
			string text = "";
			if (bool_20)
			{
				byte[] array = Class1.smethod_9(Encoding.Unicode.GetBytes(smethod_49()));
				text = array[3].ToString("X2");
				text = text + array[11].ToString("X2") + "-";
			}
			else
			{
				text = "92A4-";
			}
			if (bool_16)
			{
				byte[] array2 = Class1.smethod_9(Encoding.Unicode.GetBytes(smethod_42()));
				text += array2[3].ToString("X2");
				text = text + array2[11].ToString("X2") + "-";
			}
			else
			{
				byte[] array3 = Class1.smethod_9(Encoding.Unicode.GetBytes(text));
				text += array3[6].ToString("X2");
				text = text + array3[7].ToString("X2") + "-";
			}
			if (bool_17)
			{
				byte[] array4 = Class1.smethod_9(Encoding.Unicode.GetBytes(smethod_44()));
				text += array4[3].ToString("X2");
				text = text + array4[11].ToString("X2") + "-";
			}
			else
			{
				byte[] array5 = Class1.smethod_9(Encoding.Unicode.GetBytes(text));
				text += array5[15].ToString("X2");
				text = text + array5[7].ToString("X2") + "-";
			}
			if (bool_18)
			{
				byte[] array6 = Class1.smethod_9(Encoding.Unicode.GetBytes(smethod_43()));
				text += array6[3].ToString("X2");
				text = text + array6[11].ToString("X2") + "-";
			}
			else
			{
				byte[] array7 = Class1.smethod_9(Encoding.Unicode.GetBytes(text));
				text += array7[2].ToString("X2");
				text = text + array7[14].ToString("X2") + "-";
			}
			if (bool_19)
			{
				byte[] array8 = Class1.smethod_9(Encoding.Unicode.GetBytes(smethod_53()));
				text += array8[3].ToString("X2");
				text = text + array8[11].ToString("X2") + "-";
			}
			else
			{
				byte[] array9 = Class1.smethod_9(Encoding.Unicode.GetBytes(text));
				text += array9[1].ToString("X2");
				text = text + array9[9].ToString("X2") + "-";
			}
			if (bool_21)
			{
				byte[] array10 = Class1.smethod_9(Encoding.Unicode.GetBytes(smethod_50()));
				text += array10[3].ToString("X2");
				return text + array10[11].ToString("X2");
			}
			byte[] array11 = Class1.smethod_9(Encoding.Unicode.GetBytes(text));
			text += array11[6].ToString("X2");
			return text + array11[8].ToString("X2");
		}
	}

	internal static string smethod_26()
	{
		return "{nohid-22222-10001-00000}";
	}

	internal static string smethod_27(bool bool_16, bool bool_17, bool bool_18, bool bool_19, bool bool_20, bool bool_21)
	{
		if ("v2" == "v1")
		{
			return smethod_28(bool_16, bool_17, bool_18, bool_19, bool_20, bool_21, bool_22: true);
		}
		return smethod_30(bool_16, bool_17, bool_18, bool_19, bool_20, bool_21, bool_22: true);
	}

	internal static string smethod_28(bool bool_16, bool bool_17, bool bool_18, bool bool_19, bool bool_20, bool bool_21, bool bool_22)
	{
		lock (object_1)
		{
			if (bool_22 && string_3 != null && string_3.Length >= 29)
			{
				return smethod_29(string_3, bool_16, bool_17, bool_18, bool_19, bool_20, bool_21);
			}
			string text = "";
			if (bool_20)
			{
				byte[] array = Class1.smethod_9(Encoding.Unicode.GetBytes(smethod_49()));
				text = array[3].ToString("X2");
				text = text + array[11].ToString("X2") + "-";
			}
			else
			{
				text = "92A4-";
			}
			if (bool_16)
			{
				byte[] array2 = Class1.smethod_9(Encoding.Unicode.GetBytes(smethod_42()));
				text += array2[3].ToString("X2");
				text = text + array2[11].ToString("X2") + "-";
			}
			else
			{
				byte[] array3 = Class1.smethod_9(Encoding.Unicode.GetBytes(text));
				text += array3[6].ToString("X2");
				text = text + array3[7].ToString("X2") + "-";
			}
			if (bool_17)
			{
				byte[] array4 = Class1.smethod_9(Encoding.Unicode.GetBytes(smethod_44()));
				text += array4[3].ToString("X2");
				text = text + array4[11].ToString("X2") + "-";
			}
			else
			{
				byte[] array5 = Class1.smethod_9(Encoding.Unicode.GetBytes(text));
				text += array5[15].ToString("X2");
				text = text + array5[7].ToString("X2") + "-";
			}
			if (bool_18)
			{
				byte[] array6 = Class1.smethod_9(Encoding.Unicode.GetBytes(smethod_43()));
				text += array6[3].ToString("X2");
				text = text + array6[11].ToString("X2") + "-";
			}
			else
			{
				byte[] array7 = Class1.smethod_9(Encoding.Unicode.GetBytes(text));
				text += array7[2].ToString("X2");
				text = text + array7[14].ToString("X2") + "-";
			}
			if (bool_19)
			{
				byte[] array8 = Class1.smethod_9(Encoding.Unicode.GetBytes(smethod_51()));
				text += array8[3].ToString("X2");
				text = text + array8[11].ToString("X2") + "-";
			}
			else
			{
				byte[] array9 = Class1.smethod_9(Encoding.Unicode.GetBytes(text));
				text += array9[1].ToString("X2");
				text = text + array9[9].ToString("X2") + "-";
			}
			if (bool_21)
			{
				byte[] array10 = Class1.smethod_9(Encoding.Unicode.GetBytes(smethod_50()));
				text += array10[3].ToString("X2");
				return text + array10[11].ToString("X2");
			}
			byte[] array11 = Class1.smethod_9(Encoding.Unicode.GetBytes(text));
			text += array11[6].ToString("X2");
			return text + array11[8].ToString("X2");
		}
	}

	internal static string smethod_29(string string_18, bool bool_16, bool bool_17, bool bool_18, bool bool_19, bool bool_20, bool bool_21)
	{
		string text = "";
		text = ((!bool_20) ? "92A4-" : (string_18.Substring(0, 4) + "-"));
		if (bool_16)
		{
			text = text + string_18.Substring(5, 4) + "-";
		}
		else
		{
			byte[] array = Class1.smethod_9(Encoding.Unicode.GetBytes(text));
			text += array[6].ToString("X2");
			text = text + array[7].ToString("X2") + "-";
		}
		if (bool_17)
		{
			text = text + string_18.Substring(10, 4) + "-";
		}
		else
		{
			byte[] array2 = Class1.smethod_9(Encoding.Unicode.GetBytes(text));
			text += array2[15].ToString("X2");
			text = text + array2[7].ToString("X2") + "-";
		}
		if (bool_18)
		{
			text = text + string_18.Substring(15, 4) + "-";
		}
		else
		{
			byte[] array3 = Class1.smethod_9(Encoding.Unicode.GetBytes(text));
			text += array3[2].ToString("X2");
			text = text + array3[14].ToString("X2") + "-";
		}
		if (bool_19)
		{
			text = text + string_18.Substring(20, 4) + "-";
		}
		else
		{
			byte[] array4 = Class1.smethod_9(Encoding.Unicode.GetBytes(text));
			text += array4[1].ToString("X2");
			text = text + array4[9].ToString("X2") + "-";
		}
		if (bool_21)
		{
			return text + string_18.Substring(25, 4);
		}
		byte[] array5 = Class1.smethod_9(Encoding.Unicode.GetBytes(text));
		text += array5[6].ToString("X2");
		return text + array5[8].ToString("X2");
	}

	internal static string smethod_30(bool bool_16, bool bool_17, bool bool_18, bool bool_19, bool bool_20, bool bool_21, bool bool_22)
	{
		lock (object_1)
		{
			if (bool_22 && string_4 != null && string_4.Length >= 29)
			{
				smethod_29(string_4, bool_16, bool_17, bool_18, bool_19, bool_20, bool_21);
			}
			string text = "";
			if (bool_20)
			{
				byte[] array = Class1.smethod_9(Encoding.Unicode.GetBytes(smethod_49()));
				text = array[3].ToString("X2");
				text = text + array[11].ToString("X2") + "-";
			}
			else
			{
				text = "92A4-";
			}
			if (bool_16)
			{
				byte[] array2 = Class1.smethod_9(Encoding.Unicode.GetBytes(smethod_42()));
				text += array2[3].ToString("X2");
				text = text + array2[11].ToString("X2") + "-";
			}
			else
			{
				byte[] array3 = Class1.smethod_9(Encoding.Unicode.GetBytes(text));
				text += array3[6].ToString("X2");
				text = text + array3[7].ToString("X2") + "-";
			}
			if (bool_17)
			{
				byte[] array4 = Class1.smethod_9(Encoding.Unicode.GetBytes(smethod_45()));
				text += array4[3].ToString("X2");
				text = text + array4[11].ToString("X2") + "-";
			}
			else
			{
				byte[] array5 = Class1.smethod_9(Encoding.Unicode.GetBytes(text));
				text += array5[15].ToString("X2");
				text = text + array5[7].ToString("X2") + "-";
			}
			if (bool_18)
			{
				byte[] array6 = Class1.smethod_9(Encoding.Unicode.GetBytes(smethod_43()));
				text += array6[3].ToString("X2");
				text = text + array6[11].ToString("X2") + "-";
			}
			else
			{
				byte[] array7 = Class1.smethod_9(Encoding.Unicode.GetBytes(text));
				text += array7[2].ToString("X2");
				text = text + array7[14].ToString("X2") + "-";
			}
			if (bool_19)
			{
				byte[] array8 = Class1.smethod_9(Encoding.Unicode.GetBytes(smethod_52()));
				text += array8[3].ToString("X2");
				text = text + array8[11].ToString("X2") + "-";
			}
			else
			{
				byte[] array9 = Class1.smethod_9(Encoding.Unicode.GetBytes(text));
				text += array9[1].ToString("X2");
				text = text + array9[9].ToString("X2") + "-";
			}
			if (bool_21)
			{
				byte[] array10 = Class1.smethod_9(Encoding.Unicode.GetBytes(smethod_50()));
				text += array10[3].ToString("X2");
				return text + array10[11].ToString("X2");
			}
			byte[] array11 = Class1.smethod_9(Encoding.Unicode.GetBytes(text));
			text += array11[6].ToString("X2");
			return text + array11[8].ToString("X2");
		}
	}

	internal static string smethod_31(string string_18)
	{
		byte[] array = new byte[32];
		array[0] = 118;
		array[0] = 65;
		array[0] = 188;
		array[0] = 49;
		array[1] = 145;
		array[1] = 160;
		array[1] = 162;
		array[2] = 113;
		array[2] = 161;
		array[2] = 130;
		array[2] = 150;
		array[2] = 227;
		array[3] = 180;
		array[3] = 126;
		array[3] = 108;
		array[3] = 136;
		array[3] = 90;
		array[3] = 155;
		array[4] = 28;
		array[4] = 124;
		array[4] = 96;
		array[4] = 144;
		array[4] = 201;
		array[4] = 96;
		array[5] = 128;
		array[5] = 91;
		array[5] = 51;
		array[6] = 110;
		array[6] = 138;
		array[6] = 85;
		array[6] = 45;
		array[6] = 13;
		array[7] = 97;
		array[7] = 88;
		array[7] = 140;
		array[7] = 153;
		array[7] = 120;
		array[7] = 250;
		array[8] = 164;
		array[8] = 100;
		array[8] = 110;
		array[8] = 158;
		array[8] = 108;
		array[8] = 51;
		array[9] = 103;
		array[9] = 124;
		array[9] = 140;
		array[9] = 117;
		array[9] = 92;
		array[9] = 53;
		array[10] = 89;
		array[10] = 116;
		array[10] = 142;
		array[11] = 147;
		array[11] = 41;
		array[11] = 101;
		array[11] = 12;
		array[12] = 148;
		array[12] = 74;
		array[12] = 145;
		array[12] = 1;
		array[13] = 99;
		array[13] = 162;
		array[13] = 114;
		array[13] = 19;
		array[14] = 86;
		array[14] = 65;
		array[14] = 148;
		array[14] = 208;
		array[15] = 107;
		array[15] = 109;
		array[15] = 115;
		array[15] = 162;
		array[15] = 142;
		array[16] = 102;
		array[16] = 196;
		array[16] = 106;
		array[16] = 96;
		array[17] = 76;
		array[17] = 154;
		array[17] = 135;
		array[18] = 75;
		array[18] = 142;
		array[18] = 116;
		array[18] = 111;
		array[18] = 122;
		array[18] = 248;
		array[19] = 94;
		array[19] = 155;
		array[19] = 147;
		array[19] = 70;
		array[19] = 101;
		array[19] = 205;
		array[20] = 173;
		array[20] = 67;
		array[20] = 136;
		array[20] = 153;
		array[20] = 93;
		array[20] = 71;
		array[21] = 127;
		array[21] = 143;
		array[21] = 164;
		array[22] = 65;
		array[22] = 127;
		array[22] = 166;
		array[22] = 117;
		array[23] = 86;
		array[23] = 86;
		array[23] = 146;
		array[23] = 166;
		array[23] = 128;
		array[23] = 88;
		array[24] = 128;
		array[24] = 122;
		array[24] = 79;
		array[24] = 52;
		array[25] = 104;
		array[25] = 133;
		array[25] = 121;
		array[25] = 61;
		array[25] = 171;
		array[26] = 23;
		array[26] = 132;
		array[26] = 120;
		array[26] = 162;
		array[26] = 180;
		array[26] = 57;
		array[27] = 114;
		array[27] = 134;
		array[27] = 92;
		array[27] = 170;
		array[27] = 134;
		array[27] = 73;
		array[28] = 135;
		array[28] = 145;
		array[28] = 64;
		array[29] = 207;
		array[29] = 109;
		array[29] = 123;
		array[29] = 138;
		array[30] = 110;
		array[30] = 138;
		array[30] = 158;
		array[30] = 104;
		array[30] = byte.MaxValue;
		array[31] = 90;
		array[31] = 25;
		array[31] = 81;
		array[31] = 124;
		array[31] = 29;
		byte[] rgbKey = array;
		byte[] array2 = new byte[16];
		array2[0] = 100;
		array2[0] = 105;
		array2[0] = 159;
		array2[0] = 109;
		array2[1] = 162;
		array2[1] = 128;
		array2[1] = 79;
		array2[1] = 139;
		array2[1] = 167;
		array2[1] = 186;
		array2[2] = 150;
		array2[2] = 123;
		array2[2] = 87;
		array2[2] = 141;
		array2[2] = 88;
		array2[2] = 39;
		array2[3] = 164;
		array2[3] = 167;
		array2[3] = 153;
		array2[3] = 60;
		array2[3] = 96;
		array2[4] = 134;
		array2[4] = 195;
		array2[4] = 177;
		array2[4] = 140;
		array2[4] = 4;
		array2[5] = 106;
		array2[5] = 141;
		array2[5] = 95;
		array2[5] = 129;
		array2[5] = 128;
		array2[6] = 157;
		array2[6] = 123;
		array2[6] = 224;
		array2[7] = 126;
		array2[7] = 140;
		array2[7] = 89;
		array2[8] = 158;
		array2[8] = 121;
		array2[8] = 151;
		array2[8] = 93;
		array2[8] = 129;
		array2[9] = 190;
		array2[9] = 92;
		array2[9] = 200;
		array2[10] = 229;
		array2[10] = 120;
		array2[10] = 203;
		array2[10] = 129;
		array2[10] = 60;
		array2[11] = 208;
		array2[11] = 101;
		array2[11] = 154;
		array2[11] = 129;
		array2[11] = 8;
		array2[12] = 127;
		array2[12] = 128;
		array2[12] = 111;
		array2[12] = 225;
		array2[13] = 107;
		array2[13] = 114;
		array2[13] = 120;
		array2[13] = 75;
		array2[14] = 132;
		array2[14] = 107;
		array2[14] = 100;
		array2[14] = 159;
		array2[14] = 27;
		array2[15] = 211;
		array2[15] = 112;
		array2[15] = 168;
		array2[15] = 92;
		array2[15] = 143;
		array2[15] = 167;
		byte[] rgbIV = array2;
		SymmetricAlgorithm symmetricAlgorithm = Class1.smethod_8();
		symmetricAlgorithm.Mode = CipherMode.CBC;
		ICryptoTransform transform = symmetricAlgorithm.CreateEncryptor(rgbKey, rgbIV);
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
		byte[] bytes = Encoding.Unicode.GetBytes(string_18);
		cryptoStream.Write(bytes, 0, bytes.Length);
		cryptoStream.FlushFinalBlock();
		byte[] inArray = memoryStream.ToArray();
		memoryStream.Close();
		cryptoStream.Close();
		return Convert.ToBase64String(inArray);
	}

	internal static string smethod_32(bool bool_16)
	{
		if (bool_16)
		{
			smethod_33();
		}
		string text = "1234567890123456789012345678901234567890";
		if (bool_16 && string_0.Length > 0)
		{
			text = string_0 + text;
		}
		text = smethod_31(text);
		byte[] bytes = Encoding.Unicode.GetBytes(text);
		text = "";
		for (int i = 0; i < 16; i++)
		{
			text += bytes[i].ToString("X2");
		}
		text = "{" + text + "}";
		text = text.Insert(9, "-");
		text = text.Insert(14, "-");
		text = text.Insert(19, "-");
		text = text.Insert(24, "-");
		if (bool_16)
		{
			string_7 = text;
		}
		return text;
	}

	internal static string smethod_33()
	{
		string_8 = "";
		if (string_5 != null && string_5.Length >= 29)
		{
			string_8 = string_5;
		}
		else
		{
			try
			{
				string_8 = smethod_43();
			}
			catch
			{
				try
				{
					string_8 = smethod_51();
				}
				catch
				{
					try
					{
						string_8 = smethod_42();
						goto end_IL_0044;
					}
					catch
					{
						string_8 = "";
						goto end_IL_0044;
					}
					end_IL_0044:;
				}
			}
		}
		string_8 += "ABC1234567890123456789012345678901234DEF";
		if (string_0.Length > 0)
		{
			string_8 = string_0 + string_8;
		}
		string_8 = smethod_31(string_8);
		byte[] bytes = Encoding.Unicode.GetBytes(string_8);
		string_8 = "";
		for (int i = 0; i < 16; i++)
		{
			string_8 += bytes[i].ToString("X2");
		}
		string_8 = "{" + string_8 + "}";
		string_8 = string_8.Insert(9, "-");
		string_8 = string_8.Insert(14, "-");
		string_8 = string_8.Insert(19, "-");
		string_8 = string_8.Insert(24, "-");
		return string_8;
	}

	internal static uint smethod_34(string string_18, string string_19, string string_20)
	{
		try
		{
			return smethod_41(string_20, string_18, string_19);
		}
		catch
		{
			return 0u;
		}
	}

	internal static string smethod_35(string string_18, string string_19)
	{
		try
		{
			return smethod_40(string_18, string_19);
		}
		catch
		{
			return "";
		}
	}

	internal static Class20 smethod_36(string string_18, int int_2)
	{
		Class20 @class = new Class20(int_2);
		@class.FromXmlString(string_18);
		return @class;
	}

	internal static bool smethod_37(Class20 class20_0, byte[] byte_4, byte[] byte_5)
	{
		return class20_0.method_3(byte_4, byte_5);
	}

	internal static byte[] smethod_38(string string_18)
	{
		using FileStream fileStream = new FileStream(string_18, FileMode.Open, FileAccess.Read, FileShare.Read);
		int num = 0;
		long length = fileStream.Length;
		int num2 = (int)length;
		byte[] array = new byte[num2];
		while (num2 > 0)
		{
			int num3 = fileStream.Read(array, num, num2);
			num += num3;
			num2 -= num3;
		}
		return array;
	}

	public static void smethod_39(string string_18, byte[] byte_4)
	{
		using FileStream fileStream = new FileStream(string_18, FileMode.Create, FileAccess.Write, FileShare.Read);
		fileStream.Write(byte_4, 0, byte_4.Length);
	}

	[DllImport("kernel32", SetLastError = true)]
	private static extern uint GetFileSize(uint uint_17, IntPtr intptr_0);

	[DllImport("kernel32", SetLastError = true)]
	private static extern uint ReadFile(uint uint_17, byte[] byte_4, uint uint_18, ref uint uint_19, IntPtr intptr_0);

	[DllImport("kernel32", SetLastError = true)]
	private static extern uint CreateFile(string string_18, uint uint_17, uint uint_18, IntPtr intptr_0, uint uint_19, uint uint_20, IntPtr intptr_1);

	[DllImport("kernel32.dll", EntryPoint = "CreateFile")]
	private static extern IntPtr CreateFile_1(string string_18, uint uint_17, int int_2, IntPtr intptr_0, int int_3, int int_4, IntPtr intptr_1);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool WriteFile(uint uint_17, byte[] byte_4, uint uint_18, ref uint uint_19, IntPtr intptr_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool CloseHandle(uint uint_17);

	private static string smethod_40(string string_18, string string_19)
	{
		uint num = CreateFile(string_18 + ":" + string_19, 2147483648u, 1u, IntPtr.Zero, 3u, 0u, IntPtr.Zero);
		if (num == uint.MaxValue)
		{
			throw new Exception(string_18);
		}
		uint fileSize = GetFileSize(num, IntPtr.Zero);
		byte[] array = new byte[fileSize];
		uint uint_ = 0u;
		ReadFile(num, array, fileSize, ref uint_, IntPtr.Zero);
		CloseHandle(num);
		return Encoding.ASCII.GetString(array, 0, array.Length);
	}

	private static uint smethod_41(string string_18, string string_19, string string_20)
	{
		byte[] bytes = Encoding.ASCII.GetBytes(string_18);
		uint uint_ = 0u;
		uint uint_2 = CreateFile(string_19 + ":" + string_20, 1073741824u, 2u, IntPtr.Zero, 2u, 0u, IntPtr.Zero);
		bool flag = WriteFile(uint_2, bytes, (uint)bytes.Length, ref uint_, IntPtr.Zero);
		CloseHandle(uint_2);
		if (!flag)
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		return uint_;
	}

	private static string smethod_42()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		if (!bool_7)
		{
			try
			{
				string text = string.Empty;
				ManagementClass val = new ManagementClass("Win32_Processor");
				ManagementObjectCollection instances = val.GetInstances();
				ManagementObjectEnumerator enumerator = instances.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						ManagementObject val2 = (ManagementObject)enumerator.get_Current();
						if (!(text == string.Empty))
						{
							continue;
						}
						try
						{
							text = ((ManagementBaseObject)val2).get_Properties().get_Item("ProcessorId").get_Value()
								.ToString();
							if (text.Length == 0)
							{
								text = string.Empty;
								continue;
							}
						}
						catch
						{
							continue;
						}
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator)?.Dispose();
				}
				string_9 = text;
			}
			catch
			{
			}
			bool_7 = true;
		}
		if (string_9 == string.Empty)
		{
			string_9 = "";
		}
		return string_9;
	}

	private static string smethod_43()
	{
		if (!bool_8)
		{
			bool_8 = true;
			try
			{
				ManagementObjectCollection managementObjectCollection_ = smethod_48("Win32_BaseBoard");
				string_10 = smethod_47(managementObjectCollection_, "Product") + smethod_47(managementObjectCollection_, "Manufacturer") + smethod_47(managementObjectCollection_, "SerialNumber");
			}
			catch
			{
			}
			if (string_10 == string.Empty)
			{
				string_10 = "";
			}
		}
		return string_10;
	}

	private static string smethod_44()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		if (!bool_9)
		{
			try
			{
				string text = smethod_54();
				if (text.Length == 0)
				{
					text = string.Empty;
					ManagementClass val = new ManagementClass("Win32_NetworkAdapterConfiguration");
					ManagementObjectCollection instances = val.GetInstances();
					ManagementObjectEnumerator enumerator = instances.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							ManagementObject val2 = (ManagementObject)enumerator.get_Current();
							if (!(text == string.Empty))
							{
								break;
							}
							try
							{
								if (((ManagementBaseObject)val2).get_Item("IPEnabled") != null && (bool)((ManagementBaseObject)val2).get_Item("IPEnabled") && ((ManagementBaseObject)val2).get_Item("MacAddress") != null && ((ManagementBaseObject)val2).get_Item("MacAddress").ToString()!.Length > 0)
								{
									text = ((ManagementBaseObject)val2).get_Item("MacAddress").ToString()!.ToUpper();
									text = text.Replace(":", "");
								}
							}
							catch
							{
							}
						}
					}
					finally
					{
						((IDisposable)enumerator)?.Dispose();
					}
				}
				string_11 = text;
			}
			catch
			{
			}
			bool_9 = true;
		}
		if (string_11 == string.Empty)
		{
			string_11 = "";
		}
		return string_11;
	}

	private static string smethod_45()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		if (!bool_10)
		{
			try
			{
				List<string> list = new List<string>();
				ManagementObjectSearcher val = new ManagementObjectSearcher("Select MACAddress,PNPDeviceID FROM Win32_NetworkAdapter WHERE MACAddress IS NOT NULL AND PNPDeviceID IS NOT NULL");
				ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						ManagementObject val2 = (ManagementObject)enumerator.get_Current();
						if (((ManagementBaseObject)val2).get_Item("PNPDeviceID").ToString()!.Contains("PCI\\"))
						{
							string item = ((ManagementBaseObject)val2).get_Item("MACAddress").ToString()!.Replace(":", "");
							list.Add(item);
						}
					}
				}
				finally
				{
					((IDisposable)enumerator)?.Dispose();
				}
				string text = "";
				int num = int.MaxValue;
				NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
				foreach (NetworkInterface networkInterface in allNetworkInterfaces)
				{
					if ((networkInterface.NetworkInterfaceType != NetworkInterfaceType.Ethernet && networkInterface.NetworkInterfaceType != NetworkInterfaceType.FastEthernetFx && networkInterface.NetworkInterfaceType != NetworkInterfaceType.FastEthernetT) || !networkInterface.Supports(NetworkInterfaceComponent.IPv4))
					{
						continue;
					}
					string text2 = networkInterface.GetPhysicalAddress().ToString();
					if (list.Contains(text2))
					{
						IPv4InterfaceProperties iPv4Properties = networkInterface.GetIPProperties().GetIPv4Properties();
						if (iPv4Properties != null && iPv4Properties.Index < num)
						{
							num = iPv4Properties.Index;
							text = text2;
						}
					}
				}
				string text3 = "";
				if (text.Length > 0)
				{
					for (int j = 0; j < text.Length / 2; j++)
					{
						if (j > 0)
						{
							text3 += "-";
						}
						text3 += text.Substring(j * 2, 2);
					}
					string_12 = text3;
				}
				else
				{
					string_12 = smethod_44();
				}
			}
			catch
			{
				string_12 = smethod_44();
			}
			bool_10 = true;
			if (string_12 == string.Empty)
			{
				string_12 = "";
			}
		}
		return string_12;
	}

	internal static string smethod_46(string string_18, string string_19)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		string text = "";
		try
		{
			ManagementClass val = new ManagementClass(string_18);
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					if (text == "")
					{
						try
						{
							return ((ManagementBaseObject)val2).get_Item(string_19).ToString();
						}
						catch
						{
							text = "";
						}
					}
				}
				return text;
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}
		catch
		{
			return "";
		}
	}

	internal static string smethod_47(ManagementObjectCollection managementObjectCollection_0, string string_18)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		string text = "";
		try
		{
			ManagementObjectEnumerator enumerator = managementObjectCollection_0.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val = (ManagementObject)enumerator.get_Current();
					if (text == "")
					{
						try
						{
							return ((ManagementBaseObject)val).get_Item(string_18).ToString();
						}
						catch
						{
							text = "";
						}
					}
				}
				return text;
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}
		catch
		{
			return "";
		}
	}

	internal static ManagementObjectCollection smethod_48(string string_18)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		ManagementClass val = new ManagementClass(string_18);
		return val.GetInstances();
	}

	private static string smethod_49()
	{
		if (!bool_11)
		{
			try
			{
				bool_11 = true;
				ManagementObjectCollection managementObjectCollection_ = smethod_48("Win32_BIOS");
				string_13 = smethod_47(managementObjectCollection_, "Manufacturer") + smethod_47(managementObjectCollection_, "SMBIOSBIOSVersion") + smethod_47(managementObjectCollection_, "ReleaseDate") + smethod_47(managementObjectCollection_, "Version");
			}
			catch
			{
				string_13 = "";
			}
		}
		return string_13;
	}

	private static string smethod_50()
	{
		if (!bool_12)
		{
			try
			{
				bool_12 = true;
				string_14 = smethod_46("Win32_OperatingSystem", "SerialNumber");
			}
			catch
			{
				string_14 = "";
			}
		}
		return string_14;
	}

	private static string smethod_51()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected O, but got Unknown
		if (bool_13)
		{
			return string_15;
		}
		bool_13 = true;
		string_15 = "";
		try
		{
			ArrayList arrayList = new ArrayList();
			ManagementObjectSearcher val = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
			ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					if (((ManagementBaseObject)val2).get_Item("DeviceID") != null && ((ManagementBaseObject)val2).get_Item("InterfaceType") != null && ((ManagementBaseObject)val2).get_Item("InterfaceType").ToString() != "USB" && ((ManagementBaseObject)val2).get_Item("InterfaceType").ToString() != "1394")
					{
						arrayList.Add(((ManagementBaseObject)val2).get_Item("DeviceID").ToString());
					}
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			val = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");
			ManagementObjectCollection val3 = val.Get();
			foreach (string item in arrayList)
			{
				ManagementObjectEnumerator enumerator3 = val3.GetEnumerator();
				try
				{
					while (enumerator3.MoveNext())
					{
						ManagementObject val4 = (ManagementObject)enumerator3.get_Current();
						if (((ManagementBaseObject)val4).get_Item("Tag") == null)
						{
							continue;
						}
						string text2 = ((ManagementBaseObject)val4).get_Item("Tag").ToString();
						if (text2 == item && ((ManagementBaseObject)val4).get_Item("SerialNumber") != null)
						{
							object obj = ((ManagementBaseObject)val4).get_Item("SerialNumber");
							if (obj != null && !(obj.ToString() == string.Empty) && obj.ToString()![0] != Convert.ToChar(31))
							{
								string_15 = obj.ToString()!.Trim();
								return string_15;
							}
							break;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator3)?.Dispose();
				}
			}
		}
		catch
		{
			string_15 = "";
		}
		return "";
	}

	private static string smethod_52()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected O, but got Unknown
		if (bool_14)
		{
			return string_16;
		}
		bool_14 = true;
		string_16 = "";
		try
		{
			ArrayList arrayList = new ArrayList();
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			ManagementObjectSearcher val = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
			ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					if (((ManagementBaseObject)val2).get_Item("DeviceID") != null && ((ManagementBaseObject)val2).get_Item("InterfaceType") != null && ((ManagementBaseObject)val2).get_Item("InterfaceType").ToString() != "USB" && ((ManagementBaseObject)val2).get_Item("InterfaceType").ToString() != "1394")
					{
						arrayList.Add(((ManagementBaseObject)val2).get_Item("DeviceID").ToString());
						if (((ManagementBaseObject)val2).get_Item("SerialNumber") != null && ((ManagementBaseObject)val2).get_Item("SerialNumber").ToString()!.Trim().Length > 0)
						{
							dictionary[((ManagementBaseObject)val2).get_Item("DeviceID").ToString()] = ((ManagementBaseObject)val2).get_Item("SerialNumber").ToString()!.Trim();
						}
					}
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			val = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");
			ManagementObjectCollection val3 = val.Get();
			foreach (string item in arrayList)
			{
				ManagementObjectEnumerator enumerator3 = val3.GetEnumerator();
				try
				{
					while (enumerator3.MoveNext())
					{
						ManagementObject val4 = (ManagementObject)enumerator3.get_Current();
						if (((ManagementBaseObject)val4).get_Item("Tag") != null)
						{
							string text2 = ((ManagementBaseObject)val4).get_Item("Tag").ToString();
							if (text2 == item && dictionary.ContainsKey(text2))
							{
								string_16 = dictionary[text2];
								return string_16;
							}
						}
					}
				}
				finally
				{
					((IDisposable)enumerator3)?.Dispose();
				}
			}
		}
		catch
		{
		}
		return "";
	}

	private static string smethod_53()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		if (!bool_15)
		{
			bool_15 = true;
			try
			{
				string text = string.Empty;
				ManagementClass val = new ManagementClass("Win32_DiskDrive");
				ManagementObjectCollection instances = val.GetInstances();
				ManagementObjectEnumerator enumerator = instances.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						ManagementObject val2 = (ManagementObject)enumerator.get_Current();
						try
						{
							if (!(text == string.Empty) || ((ManagementBaseObject)val2).get_Properties().get_Item("PnPDeviceID") == null || ((ManagementBaseObject)val2).get_Properties().get_Item("PnPDeviceID").get_Value() == null)
							{
								continue;
							}
							text = ((ManagementBaseObject)val2).get_Properties().get_Item("PnPDeviceID").get_Value()
								.ToString();
							if (text.Length > 0 && text.IndexOf("USBSTOR") >= 0)
							{
								text = "";
							}
							if (((ManagementBaseObject)val2).get_Properties().get_Item("InterfaceType") != null && ((ManagementBaseObject)val2).get_Properties().get_Item("InterfaceType").get_Value() != null)
							{
								if (((ManagementBaseObject)val2).get_Properties().get_Item("InterfaceType").get_Value()
									.ToString() == "USB")
								{
									text = "";
								}
								if (((ManagementBaseObject)val2).get_Properties().get_Item("InterfaceType").get_Value()
									.ToString() == "1394")
								{
									text = "";
								}
							}
							if (text.Length == 0)
							{
								text = string.Empty;
								continue;
							}
							break;
						}
						catch
						{
						}
					}
				}
				finally
				{
					((IDisposable)enumerator)?.Dispose();
				}
				if (text == string.Empty)
				{
					text = "";
				}
				string_17 = text;
				if (string_17.Length > 0)
				{
					string_17 = string_17.Split(new char[1] { '\\' })[^1];
				}
			}
			catch
			{
				string_17 = "";
			}
		}
		return string_17;
	}

	[DllImport("iphlpapi.dll", CharSet = CharSet.Ansi)]
	internal static extern int GetAdaptersInfo(IntPtr intptr_0, ref long long_0);

	internal static string smethod_54()
	{
		string text = string.Empty;
		try
		{
			long long_ = Marshal.SizeOf(typeof(Struct1));
			IntPtr intPtr = Marshal.AllocHGlobal(new IntPtr(long_));
			int adaptersInfo = GetAdaptersInfo(intPtr, ref long_);
			if (adaptersInfo == 111)
			{
				intPtr = Marshal.ReAllocHGlobal(intPtr, new IntPtr(long_));
				adaptersInfo = GetAdaptersInfo(intPtr, ref long_);
			}
			if (adaptersInfo == 0)
			{
				IntPtr ptr = intPtr;
				Struct1 @struct = (Struct1)Marshal.PtrToStructure(ptr, typeof(Struct1));
				for (int i = 0; i < @struct.uint_0; i++)
				{
					text += @struct.byte_0[i].ToString("X2");
				}
				Marshal.FreeHGlobal(intPtr);
			}
			else
			{
				Marshal.FreeHGlobal(intPtr);
			}
		}
		catch
		{
		}
		if (text == string.Empty)
		{
			text = "";
		}
		return text;
	}
}
