using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Threading;
using SmartAssembly.SmartExceptionsCore;

namespace ns0;

internal sealed class Class10
{
	internal sealed class Class11
	{
		internal static string smethod_0(Process process_0, int int_0, int int_1)
		{
			int num = default(int);
			try
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 76:
						return process_0.ProcessName;
					case 77:
						return process_0.MainWindowTitle;
					}
					num = 5;
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException4(exception, num, process_0, int_0, int_1);
				throw;
			}
		}

		internal static AppDomain smethod_1(int int_0, int int_1)
		{
			int num = default(int);
			try
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 76:
						return AppDomain.CurrentDomain;
					}
					num = 4;
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException3(exception, num, int_0, int_1);
				throw;
			}
		}

		internal static void smethod_2(AppDomain appDomain_0, ResolveEventHandler resolveEventHandler_0, int int_0, int int_1)
		{
			int num = default(int);
			try
			{
				num = 3;
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 16:
						appDomain_0.ResourceResolve += resolveEventHandler_0;
						return;
					}
					num = 3;
				}
			}
			catch (Exception exception)
			{
				int num2 = default(int);
				StackFrameHelper.CreateException6(exception, num, num2, appDomain_0, resolveEventHandler_0, int_0, int_1);
				throw;
			}
		}

		internal static void smethod_3(object object_0, int int_0, int int_1)
		{
			int num = default(int);
			try
			{
				num = 1;
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 34:
						Monitor.Exit(object_0);
						return;
					}
					num = 1;
				}
			}
			catch (Exception exception)
			{
				int num2 = default(int);
				StackFrameHelper.CreateException5(exception, num, num2, object_0, int_0, int_1);
				throw;
			}
		}

		internal static object smethod_4(AppDomain appDomain_0, string string_0, int int_0, int int_1)
		{
			int num = default(int);
			try
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 31:
						return appDomain_0.GetData(string_0);
					}
					num = 0;
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException5(exception, num, appDomain_0, string_0, int_0, int_1);
				throw;
			}
		}

		internal static DateTime smethod_5(int int_0, int int_1)
		{
			int num = default(int);
			try
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 1:
						return DateTime.Today;
					}
					num = 2;
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException3(exception, num, int_0, int_1);
				throw;
			}
		}

		internal static GCHandle smethod_6(object object_0, GCHandleType gchandleType_0, int int_0, int int_1)
		{
			int num = default(int);
			try
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 99:
						return GCHandle.Alloc(object_0, gchandleType_0);
					}
					num = 0;
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException5(exception, num, object_0, gchandleType_0, int_0, int_1);
				throw;
			}
		}

		internal static IntPtr smethod_7(ref GCHandle gchandle_0, int int_0, int int_1)
		{
			int num = default(int);
			try
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 92:
						return gchandle_0.AddrOfPinnedObject();
					}
					num = 1;
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException4(exception, num, gchandle_0, int_0, int_1);
				throw;
			}
		}

		internal static string smethod_8(string string_0, char char_0, char char_1, int int_0, int int_1)
		{
			int num = default(int);
			try
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 80:
						return string_0.Replace(char_0, char_1);
					}
					num = 2;
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException6(exception, num, string_0, char_0, char_1, int_0, int_1);
				throw;
			}
		}

		internal static void smethod_9(int int_0, int int_1, int int_2)
		{
			int num = default(int);
			try
			{
				num = 1;
				while (true)
				{
					switch (int_2 ^ int_1)
					{
					case 84:
						Thread.Sleep(int_0);
						return;
					}
					num = 1;
				}
			}
			catch (Exception exception)
			{
				int num2 = default(int);
				StackFrameHelper.CreateException5(exception, num, num2, int_0, int_1, int_2);
				throw;
			}
		}

		internal static object smethod_10(MethodBase methodBase_0, object object_0, object[] object_1, int int_0, int int_1)
		{
			int num = default(int);
			try
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 35:
						return methodBase_0.Invoke(object_0, object_1);
					}
					num = 1;
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException6(exception, num, methodBase_0, object_0, object_1, int_0, int_1);
				throw;
			}
		}

		internal static void smethod_11(Thread thread_0, int int_0, int int_1)
		{
			int num = default(int);
			try
			{
				num = 1;
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 22:
						thread_0.Start();
						return;
					}
					num = 1;
				}
			}
			catch (Exception exception)
			{
				int num2 = default(int);
				StackFrameHelper.CreateException5(exception, num, num2, thread_0, int_0, int_1);
				throw;
			}
		}

		internal static void smethod_12(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0, int int_0, int int_1)
		{
			int num = default(int);
			try
			{
				num = 0;
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 116:
						RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
						return;
					}
					num = 0;
				}
			}
			catch (Exception exception)
			{
				int num2 = default(int);
				StackFrameHelper.CreateException6(exception, num, num2, array_0, runtimeFieldHandle_0, int_0, int_1);
				throw;
			}
		}

		internal static Process[] smethod_13(int int_0, int int_1)
		{
			int num = default(int);
			try
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 71:
						return Process.GetProcesses();
					}
					num = 7;
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException3(exception, num, int_0, int_1);
				throw;
			}
		}
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 78)]
	private struct Struct19
	{
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static byte byte_0/* Not supported: data(00) */;

	static Class10()
	{
		int num = default(int);
		char[] array = default(char[]);
		try
		{
			num = 6;
			char_1 = new char[39];
			array = new char[8] { '\0', '\0', '\0', '\0', '\u103e', '\0', '\0', '\0' };
			num = 5;
			array[2] = 'ᱜ';
			array[1] = '\u1de9';
			array[7] = 'ቁ';
			num = 2;
			array[3] = 'ᠩ';
			array[0] = '⛎';
			array[5] = '㍹';
			num = 0;
			array[6] = 'Ẫ';
			string_0 = new string[1];
			char_0 = array;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, array, num);
			throw;
		}
	}

	internal static Type smethod_0(RuntimeTypeHandle runtimeTypeHandle_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 55:
					return Type.GetTypeFromHandle(runtimeTypeHandle_0);
				}
				num = 7;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, runtimeTypeHandle_0, int_0, int_1);
			throw;
		}
	}

	internal static byte[] smethod_1(MemoryStream memoryStream_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 44:
					return memoryStream_0.ToArray();
				}
				num = 0;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, memoryStream_0, int_0, int_1);
			throw;
		}
	}

	internal static bool smethod_2(DateTime dateTime_0, DateTime dateTime_1, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 85:
					return dateTime_0 > dateTime_1;
				}
				num = 6;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, dateTime_0, dateTime_1, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_3(AppDomain appDomain_0, string string_1, object object_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 2;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 108:
					appDomain_0.SetData(string_1, object_0);
					return;
				}
				num = 2;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException7(exception, num, num2, appDomain_0, string_1, object_0, int_0, int_1);
			throw;
		}
	}

	internal static string smethod_4(Assembly assembly_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 46:
					return assembly_0.Location;
				}
				num = 3;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, assembly_0, int_0, int_1);
			throw;
		}
	}

	internal static Assembly smethod_5(byte[] byte_1, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 106:
					return Assembly.Load(byte_1);
				}
				num = 4;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, byte_1, int_0, int_1);
			throw;
		}
	}

	internal static string smethod_6(ref DateTime dateTime_0, string string_1, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 14:
					return dateTime_0.ToString(string_1);
				}
				num = 3;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, dateTime_0, string_1, int_0, int_1);
			throw;
		}
	}

	internal static string[] smethod_7(string string_1, char[] char_2, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 52:
					return string_1.Split(char_2);
				}
				num = 3;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, string_1, char_2, int_0, int_1);
			throw;
		}
	}

	internal static Evidence smethod_8(Assembly assembly_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 23:
					return assembly_0.get_Evidence();
				}
				num = 3;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, assembly_0, int_0, int_1);
			throw;
		}
	}

	internal static int smethod_9(Stream stream_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 70:
					return stream_0.ReadByte();
				}
				num = 3;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, stream_0, int_0, int_1);
			throw;
		}
	}

	internal static string smethod_10(AssemblyName assemblyName_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 107:
					return assemblyName_0.Name;
				}
				num = 1;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, assemblyName_0, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_11(ref GCHandle gchandle_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 3;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 45:
					gchandle_0.Free();
					return;
				}
				num = 3;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException5(exception, num, num2, gchandle_0, int_0, int_1);
			throw;
		}
	}

	internal static bool smethod_12(object object_0, object object_1, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 57:
					return object.ReferenceEquals(object_0, object_1);
				}
				num = 6;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, object_0, object_1, int_0, int_1);
			throw;
		}
	}
}
