using System;
using System.Configuration;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using SmartAssembly.SmartExceptionsCore;

namespace ns0;

internal sealed class Class7
{
	internal sealed class Class8
	{
		internal sealed class Class9
		{
			internal static void smethod_0(Stream stream_0, int int_0, int int_1)
			{
				int num = default(int);
				try
				{
					num = 0;
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 34:
							stream_0.Close();
							return;
						}
						num = 0;
					}
				}
				catch (Exception exception)
				{
					int num2 = default(int);
					StackFrameHelper.CreateException5(exception, num, num2, stream_0, int_0, int_1);
					throw;
				}
			}

			internal static object smethod_1(IntPtr intptr_0, Type type_0, int int_0, int int_1)
			{
				int num = default(int);
				try
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 43:
							return Marshal.PtrToStructure(intptr_0, type_0);
						}
						num = 2;
					}
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException5(exception, num, intptr_0, type_0, int_0, int_1);
					throw;
				}
			}

			internal static Encoding smethod_2(int int_0, int int_1)
			{
				int num = default(int);
				try
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 106:
							return Encoding.UTF8;
						}
						num = 1;
					}
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException3(exception, num, int_0, int_1);
					throw;
				}
			}

			internal static long smethod_3(Stream stream_0, long long_0, SeekOrigin seekOrigin_0, int int_0, int int_1)
			{
				int num = default(int);
				try
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 91:
							return stream_0.Seek(long_0, seekOrigin_0);
						}
						num = 4;
					}
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException6(exception, num, stream_0, long_0, seekOrigin_0, int_0, int_1);
					throw;
				}
			}

			internal static void smethod_4(Process process_0, int int_0, int int_1)
			{
				int num = default(int);
				try
				{
					num = 1;
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 52:
							process_0.Close();
							return;
						}
						num = 1;
					}
				}
				catch (Exception exception)
				{
					int num2 = default(int);
					StackFrameHelper.CreateException5(exception, num, num2, process_0, int_0, int_1);
					throw;
				}
			}

			internal static Assembly smethod_5(int int_0, int int_1)
			{
				int num = default(int);
				try
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 94:
							return Assembly.GetExecutingAssembly();
						}
						num = 1;
					}
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException3(exception, num, int_0, int_1);
					throw;
				}
			}

			internal static string smethod_6(string string_0, object object_0, object object_1, int int_0, int int_1)
			{
				int num = default(int);
				try
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 74:
							return string.Format(string_0, object_0, object_1);
						}
						num = 3;
					}
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException6(exception, num, string_0, object_0, object_1, int_0, int_1);
					throw;
				}
			}

			internal static ParameterInfo[] smethod_7(MethodBase methodBase_0, int int_0, int int_1)
			{
				int num = default(int);
				try
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 124:
							return methodBase_0.GetParameters();
						}
						num = 3;
					}
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException4(exception, num, methodBase_0, int_0, int_1);
					throw;
				}
			}

			internal static bool smethod_8(Process process_0, int int_0, int int_1)
			{
				int num = default(int);
				try
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 36:
							return process_0.CloseMainWindow();
						}
						num = 4;
					}
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException4(exception, num, process_0, int_0, int_1);
					throw;
				}
			}

			internal static string smethod_9(string string_0, string string_1, int int_0, int int_1)
			{
				int num = default(int);
				try
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 52:
							return string_0 + string_1;
						}
						num = 5;
					}
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException5(exception, num, string_0, string_1, int_0, int_1);
					throw;
				}
			}

			internal static int smethod_10(string string_0, int int_0, int int_1)
			{
				int num = default(int);
				try
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 73:
							return string_0.Length;
						}
						num = 4;
					}
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException4(exception, num, string_0, int_0, int_1);
					throw;
				}
			}

			internal static string smethod_11(string string_0, object object_0, int int_0, int int_1)
			{
				int num = default(int);
				try
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 33:
							return string.Format(string_0, object_0);
						}
						num = 1;
					}
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException5(exception, num, string_0, object_0, int_0, int_1);
					throw;
				}
			}

			internal static object smethod_12(ResourceManager resourceManager_0, string string_0, CultureInfo cultureInfo_0, int int_0, int int_1)
			{
				int num = default(int);
				try
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 65:
							return resourceManager_0.GetObject(string_0, cultureInfo_0);
						}
						num = 5;
					}
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException6(exception, num, resourceManager_0, string_0, cultureInfo_0, int_0, int_1);
					throw;
				}
			}
		}

		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1080)]
		private struct Struct18
		{
		}

		private static readonly char[] char_0;

		private static readonly char[] char_1;

		private static readonly string[] string_0;

		internal static byte byte_0/* Not supported: data(00) */;

		internal static void smethod_0(object object_0, int int_0, int int_1)
		{
			int num = default(int);
			try
			{
				num = 0;
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 120:
						Monitor.Enter(object_0);
						return;
					}
					num = 0;
				}
			}
			catch (Exception exception)
			{
				int num2 = default(int);
				StackFrameHelper.CreateException5(exception, num, num2, object_0, int_0, int_1);
				throw;
			}
		}

		internal static int smethod_1(Stream stream_0, byte[] byte_1, int int_0, int int_1, int int_2, int int_3)
		{
			int num = default(int);
			try
			{
				while (true)
				{
					switch (int_3 ^ int_2)
					{
					case 16:
						return stream_0.Read(byte_1, int_0, int_1);
					}
					num = 1;
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException7(exception, num, stream_0, byte_1, int_0, int_1, int_2, int_3);
				throw;
			}
		}

		internal static Assembly smethod_2(byte[] byte_1, byte[] byte_2, Evidence evidence_0, int int_0, int int_1)
		{
			int num = default(int);
			try
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 121:
						return Assembly.Load(byte_1, byte_2, evidence_0);
					}
					num = 4;
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException6(exception, num, byte_1, byte_2, evidence_0, int_0, int_1);
				throw;
			}
		}

		internal static string smethod_3(Encoding encoding_0, byte[] byte_1, int int_0, int int_1)
		{
			int num = default(int);
			try
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 6:
						return encoding_0.GetString(byte_1);
					}
					num = 4;
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException5(exception, num, encoding_0, byte_1, int_0, int_1);
				throw;
			}
		}

		internal static Process smethod_4(int int_0, int int_1)
		{
			int num = default(int);
			try
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 28:
						return Process.GetCurrentProcess();
					}
					num = 0;
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException3(exception, num, int_0, int_1);
				throw;
			}
		}

		internal static MethodInfo smethod_5(Assembly assembly_0, int int_0, int int_1)
		{
			int num = default(int);
			try
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 45:
						return assembly_0.EntryPoint;
					}
					num = 0;
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException4(exception, num, assembly_0, int_0, int_1);
				throw;
			}
		}

		internal static void smethod_6(Stream stream_0, byte[] byte_1, int int_0, int int_1, int int_2, int int_3)
		{
			int num = default(int);
			try
			{
				num = 3;
				while (true)
				{
					switch (int_3 ^ int_2)
					{
					case 8:
						stream_0.Write(byte_1, int_0, int_1);
						return;
					}
					num = 3;
				}
			}
			catch (Exception exception)
			{
				int num2 = default(int);
				StackFrameHelper.CreateException8(exception, num, num2, stream_0, byte_1, int_0, int_1, int_2, int_3);
				throw;
			}
		}

		internal static string smethod_7(ResolveEventArgs resolveEventArgs_0, int int_0, int int_1)
		{
			int num = default(int);
			try
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 119:
						return resolveEventArgs_0.Name;
					}
					num = 6;
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException4(exception, num, resolveEventArgs_0, int_0, int_1);
				throw;
			}
		}

		internal static int smethod_8(Type type_0, int int_0, int int_1)
		{
			int num = default(int);
			try
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 85:
						return Marshal.SizeOf(type_0);
					}
					num = 5;
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException4(exception, num, type_0, int_0, int_1);
				throw;
			}
		}

		internal static Assembly smethod_9(Type type_0, int int_0, int int_1)
		{
			int num = default(int);
			try
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 12:
						return type_0.Assembly;
					}
					num = 7;
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException4(exception, num, type_0, int_0, int_1);
				throw;
			}
		}

		internal static string[] smethod_10(Assembly assembly_0, int int_0, int int_1)
		{
			int num = default(int);
			try
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 29:
						return assembly_0.GetManifestResourceNames();
					}
					num = 0;
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException4(exception, num, assembly_0, int_0, int_1);
				throw;
			}
		}

		static Class8()
		{
			char_1 = new char[540];
			char[] array = new char[8];
			array[2] = '\u0ad1';
			array[4] = '\u05f5';
			array[0] = '㏞';
			array[6] = '\u0873';
			array[3] = 'Ƽ';
			array[1] = '\u073c';
			array[7] = '㐠';
			array[5] = 'Ս';
			string_0 = new string[38];
			char_0 = array;
		}
	}

	internal static int smethod_0(string string_0, string string_1, bool bool_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 8:
					return string.Compare(string_0, string_1, bool_0);
				}
				num = 7;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException6(exception, num, string_0, string_1, bool_0, int_0, int_1);
			throw;
		}
	}

	internal static string smethod_1(string string_0, string string_1, string string_2, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 15:
					return string_0.Replace(string_1, string_2);
				}
				num = 7;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException6(exception, num, string_0, string_1, string_2, int_0, int_1);
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
				case 76:
					appDomain_0.AssemblyResolve += resolveEventHandler_0;
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

	internal static uint smethod_3(uint uint_0, uint uint_1, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 109:
					return Math.Max(uint_0, uint_1);
				case 110:
					return Math.Min(uint_0, uint_1);
				}
				num = 0;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, uint_0, uint_1, int_0, int_1);
			throw;
		}
	}

	internal static string smethod_4(string string_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 40:
					return string_0.ToLower();
				}
				num = 0;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, string_0, int_0, int_1);
			throw;
		}
	}

	internal static DialogResult smethod_5(string string_0, string string_1, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0, int int_0, int int_1)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 36:
					return MessageBox.Show(string_0, string_1, messageBoxButtons_0, messageBoxIcon_0);
				}
				num = 2;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException7(exception, num, string_0, string_1, messageBoxButtons_0, messageBoxIcon_0, int_0, int_1);
			throw;
		}
	}

	internal static SettingsBase smethod_6(SettingsBase settingsBase_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 43:
					return SettingsBase.Synchronized(settingsBase_0);
				}
				num = 5;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, settingsBase_0, int_0, int_1);
			throw;
		}
	}
}
