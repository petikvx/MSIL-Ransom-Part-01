using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

internal sealed class Class4
{
	public struct Struct2
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;
	}

	public struct Struct3
	{
		public bool bool_0;

		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public int int_4;
	}

	public static Struct3 struct3_0;

	public static string[] string_0;

	public static MemoryStream[] memoryStream_0;

	public static string[] string_1;

	public static string[] string_2;

	public static bool bool_0 = false;

	private static long smethod_0(Stream stream_0)
	{
		long num = 0L;
		for (int i = 0; i < 8; i++)
		{
			int num2 = stream_0.ReadByte();
			num |= (long)((ulong)(byte)num2 << 8 * i);
		}
		return num;
	}

	private static Struct3 smethod_1(MemoryStream memoryStream_1)
	{
		byte[] array = new byte[Marshal.SizeOf(typeof(Struct3))];
		memoryStream_1.Read(array, 0, Marshal.SizeOf(typeof(Struct3)));
		GCHandle gCHandle = GCHandle.Alloc(array, GCHandleType.Pinned);
		Struct3 result = (Struct3)Marshal.PtrToStructure(gCHandle.AddrOfPinnedObject(), typeof(Struct3));
		gCHandle.Free();
		return result;
	}

	private static Struct2 smethod_2(MemoryStream memoryStream_1, int int_0, ref string string_3, ref MemoryStream memoryStream_2)
	{
		byte[] array = new byte[Marshal.SizeOf(typeof(Struct2))];
		memoryStream_1.Seek(int_0, SeekOrigin.Begin);
		memoryStream_1.Read(array, 0, Marshal.SizeOf(typeof(Struct2)));
		GCHandle gCHandle = GCHandle.Alloc(array, GCHandleType.Pinned);
		Struct2 result = (Struct2)Marshal.PtrToStructure(gCHandle.AddrOfPinnedObject(), typeof(Struct2));
		gCHandle.Free();
		byte[] array2 = new byte[result.int_3];
		memoryStream_1.Seek(result.int_2, SeekOrigin.Begin);
		memoryStream_1.Read(array2, 0, result.int_3);
		string_3 = Encoding.UTF8.GetString(array2);
		byte[] buffer = new byte[result.int_1];
		memoryStream_1.Seek(result.int_0, SeekOrigin.Begin);
		memoryStream_1.Read(buffer, 0, result.int_1);
		memoryStream_2.Write(buffer, 0, result.int_1);
		return result;
	}

	private static string smethod_3(MemoryStream memoryStream_1, int int_0, int int_1)
	{
		byte[] array = new byte[int_1];
		memoryStream_1.Seek(int_0, SeekOrigin.Begin);
		memoryStream_1.Read(array, 0, int_1);
		return Encoding.UTF8.GetString(array);
	}

	private static Assembly smethod_4(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		string strB = new AssemblyName(resolveEventArgs_0.Name).Name + GClass4.smethod_0(193);
		int num = 1;
		while (true)
		{
			if (num < struct3_0.int_0)
			{
				if (string.Compare(string_0[num], strB, ignoreCase: true) == 0)
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return Assembly.Load(memoryStream_0[num].ToArray());
	}

	public static bool smethod_5(string string_3, string string_4)
	{
		if (string_3 != null && string_3.Length != 0)
		{
			Regex regex = new Regex(string_4.Replace(GClass4.smethod_0(202), GClass4.smethod_0(207)).Replace(GClass4.smethod_0(212), GClass4.smethod_0(217)).Replace('?', '.')
				.ToLower());
			return regex.IsMatch(string_3.ToLower());
		}
		return false;
	}

	public static bool smethod_6(string string_3, string[] string_4)
	{
		int num = 0;
		while (true)
		{
			if (num < string_4.Length)
			{
				string string_5 = string_4[num];
				if (smethod_5(string_3, string_5))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public static void smethod_7()
	{
		Process.GetCurrentProcess().CloseMainWindow();
		Process.GetCurrentProcess().Close();
		Process.GetCurrentProcess().Kill();
	}

	public static void smethod_8()
	{
		while (!bool_0)
		{
			Process[] processes = Process.GetProcesses();
			for (int i = 0; i < processes.Length - 1; i++)
			{
				if (smethod_6(processes[i].ProcessName, string_1))
				{
					smethod_7();
				}
				if (smethod_6(processes[i].MainWindowTitle, string_2))
				{
					smethod_7();
				}
				Thread.Sleep(100);
			}
			Thread.Sleep(1500);
		}
	}

	[STAThread]
	private static void Main(string[] args)
	{
		MemoryStream memoryStream = new MemoryStream();
		MemoryStream memoryStream2 = new MemoryStream(Class1.smethod_1());
		memoryStream2.Seek(-8L, SeekOrigin.End);
		long num = smethod_0(memoryStream2);
		memoryStream2.Seek(-num - 8L, SeekOrigin.Current);
		byte[] array = new byte[5];
		memoryStream2.Read(array, 0, 5);
		GClass3 gClass = new GClass3();
		gClass.imethod_1(array);
		long long_ = smethod_0(memoryStream2);
		gClass.imethod_0(memoryStream2, memoryStream, num, long_, null);
		memoryStream2.Close();
		memoryStream.Seek(0L, SeekOrigin.Begin);
		struct3_0 = smethod_1(memoryStream);
		if (struct3_0.bool_0)
		{
			string_1 = smethod_3(memoryStream, struct3_0.int_1, struct3_0.int_2).Split(new char[1] { '|' });
			string_2 = smethod_3(memoryStream, struct3_0.int_3, struct3_0.int_4).Split(new char[1] { '|' });
			Thread thread = new Thread(smethod_8);
			thread.Start();
		}
		string_0 = new string[struct3_0.int_0];
		memoryStream_0 = new MemoryStream[struct3_0.int_0];
		int num2 = Marshal.SizeOf(typeof(Struct3));
		for (int i = 0; i < struct3_0.int_0; i++)
		{
			string_0[i] = string.Empty;
			memoryStream_0[i] = new MemoryStream();
			smethod_2(memoryStream, num2, ref string_0[i], ref memoryStream_0[i]);
			num2 += Marshal.SizeOf(typeof(Struct2));
		}
		if (struct3_0.int_0 > 1)
		{
			AppDomain.CurrentDomain.AssemblyResolve += smethod_4;
		}
		Assembly assembly = Assembly.Load(memoryStream_0[0].ToArray());
		if ((object)assembly != null)
		{
			if (assembly.EntryPoint!.GetParameters().Length == 0)
			{
				assembly.EntryPoint!.Invoke(null, null);
			}
			else
			{
				assembly.EntryPoint!.Invoke(null, new object[1] { args });
			}
		}
		if (struct3_0.bool_0)
		{
			bool_0 = struct3_0.bool_0;
		}
	}
}
