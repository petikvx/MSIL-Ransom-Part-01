using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

internal sealed class Class36
{
	internal sealed class Class37
	{
		private static bool bool_0;

		internal static Assembly smethod_0(object object_0, ResolveEventArgs resolveEventArgs_0)
		{
			string text = "1AFDB890EB5F56084C7E7CE461313529ADDFDB23";
			string text2 = text;
			string text3 = Class39.smethod_15(text2, '1', 102, 88);
			AppDomain currentDomain = AppDomain.CurrentDomain;
			Dictionary<string, string> dictionary = (Dictionary<string, string>)Class38.smethod_11(currentDomain, text3, 920, 974);
			Assembly assembly;
			if (dictionary == null)
			{
				dictionary = new Dictionary<string, string>();
				Class39.Class40.smethod_9(currentDomain, text3, dictionary, 864, 804);
				Assembly assembly_ = Class38.smethod_12(368, 273);
				Stream stream = Class38.smethod_13(assembly_, text, 1018, 998);
				if (stream == null)
				{
					return null;
				}
				byte[] array = new byte[Class39.Class40.smethod_10(stream, 785, 855) - 1L];
				int num = smethod_16(stream, 249, 158);
				smethod_17(stream, array, 0, array.Length, 105, 10);
				for (int i = 0; i < array.Length; i++)
				{
					array[i] ^= (byte)((i + num) & 0xFF);
				}
				MemoryStream memoryStream = new MemoryStream();
				using (DeflateStream stream_ = new DeflateStream(new MemoryStream(array), CompressionMode.Decompress, leaveOpen: true))
				{
					byte[] array2 = new byte[1024];
					int int_;
					while ((int_ = Class38.smethod_14(stream_, array2, 0, array2.Length, 794, 850)) > 0)
					{
						Class39.smethod_16(memoryStream, array2, 0, int_, 665, 737);
					}
				}
				assembly = smethod_18(memoryStream.ToArray(), null, Class39.smethod_17(assembly_, 645, 645), 104, 4);
				currentDomain.SetData(text2, assembly);
				string[] manifestResourceNames = assembly.GetManifestResourceNames();
				foreach (string text4 in manifestResourceNames)
				{
					dictionary[text4] = text4;
				}
			}
			else
			{
				assembly = (Assembly)currentDomain.GetData(text2);
			}
			if (dictionary.ContainsKey(resolveEventArgs_0.Name))
			{
				return assembly;
			}
			return null;
		}

		internal static string[] smethod_1(string string_0, char[] char_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 0:
					return string_0.Split(char_0);
				}
			}
		}

		internal static ParameterInfo[] smethod_2(MethodBase methodBase_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 114:
					return methodBase_0.GetParameters();
				}
			}
		}

		internal static short smethod_3(byte[] byte_0, int int_0, int int_1, int int_2)
		{
			while (true)
			{
				switch (int_2 ^ int_1)
				{
				case 48:
					return BitConverter.ToInt16(byte_0, int_0);
				}
			}
		}

		internal static string smethod_4(string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 5:
					return string_0.ToLower();
				case 6:
					return string.Intern(string_0);
				}
			}
		}

		internal static char[] smethod_5(string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 25:
					return string_0.ToCharArray();
				}
			}
		}

		internal static decimal smethod_6(decimal decimal_0, decimal decimal_1, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 98:
					return decimal.Add(decimal_0, decimal_1);
				}
			}
		}

		internal static int smethod_7(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
		{
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 121:
					return stream_0.Read(byte_0, int_0, int_1);
				}
			}
		}

		internal static string[] smethod_8(Assembly assembly_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 95:
					return assembly_0.GetManifestResourceNames();
				}
			}
		}

		internal static void smethod_9(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 68:
					ProjectData.ClearProjectError();
					return;
				}
			}
		}

		internal static string smethod_10(object object_0, object object_1, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 87:
					return string.Concat(object_0, object_1);
				}
			}
		}

		internal static AppDomain smethod_11(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 67:
					return AppDomain.CurrentDomain;
				}
			}
		}

		internal static object smethod_12(ResourceManager resourceManager_0, string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 74:
					return resourceManager_0.GetObject(string_0);
				}
			}
		}

		internal static byte[] smethod_13(string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 4:
					return Convert.FromBase64String(string_0);
				}
			}
		}

		internal static Evidence smethod_14(Assembly assembly_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 35:
					return assembly_0.get_Evidence();
				}
			}
		}

		internal static void smethod_15()
		{
			if (bool_0)
			{
				return;
			}
			lock (typeof(Class37))
			{
				if (!bool_0)
				{
					bool_0 = true;
					AppDomain.CurrentDomain.ResourceResolve += smethod_0;
				}
			}
		}

		internal static int smethod_16(Stream stream_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 103:
					return stream_0.ReadByte();
				}
			}
		}

		internal static int smethod_17(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
		{
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 99:
					return stream_0.Read(byte_0, int_0, int_1);
				}
			}
		}

		internal static Assembly smethod_18(byte[] byte_0, byte[] byte_1, Evidence evidence_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 108:
					return Assembly.Load(byte_0, byte_1, evidence_0);
				}
			}
		}
	}

	internal sealed class Class38
	{
		internal static byte smethod_0(ref Color color_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 114:
					return color_0.R;
				}
			}
		}

		internal static string smethod_1(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 36:
					return Environment.SystemDirectory;
				}
			}
		}

		internal static Color smethod_2(int int_0, int int_1, int int_2, int int_3, int int_4, int int_5)
		{
			while (true)
			{
				switch (int_5 ^ int_4)
				{
				case 11:
					return Color.FromArgb(int_0, int_1, int_2, int_3);
				}
			}
		}

		internal static long smethod_3(Stream stream_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 48:
					return stream_0.Length;
				}
			}
		}

		internal static int smethod_4(ref Color color_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 79:
					return color_0.ToArgb();
				}
			}
		}

		internal static void smethod_5(Thread thread_0, ApartmentState apartmentState_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 11:
					thread_0.SetApartmentState(apartmentState_0);
					return;
				}
			}
		}

		internal static bool smethod_6(DateTime dateTime_0, DateTime dateTime_1, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 108:
					return dateTime_0 > dateTime_1;
				}
			}
		}

		internal static Assembly smethod_7(byte[] byte_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 26:
					return Assembly.Load(byte_0);
				}
			}
		}

		internal static void smethod_8(Array array_0, int int_0, Array array_1, int int_1, int int_2, int int_3, int int_4)
		{
			while (true)
			{
				switch (int_4 ^ int_3)
				{
				case 66:
					Buffer.BlockCopy(array_0, int_0, array_1, int_1, int_2);
					return;
				}
			}
		}

		internal static Delegate smethod_9(IntPtr intptr_0, Type type_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 22:
					return Marshal.GetDelegateForFunctionPointer(intptr_0, type_0);
				}
			}
		}

		internal static Exception smethod_10(int int_0, int int_1, int int_2)
		{
			while (true)
			{
				switch (int_2 ^ int_1)
				{
				case 78:
					return ProjectData.CreateProjectError(int_0);
				}
			}
		}

		internal static object smethod_11(AppDomain appDomain_0, string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 86:
					return appDomain_0.GetData(string_0);
				}
			}
		}

		internal static Assembly smethod_12(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 97:
					return Assembly.GetExecutingAssembly();
				}
			}
		}

		internal static Stream smethod_13(Assembly assembly_0, string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 28:
					return assembly_0.GetManifestResourceStream(string_0);
				}
			}
		}

		internal static int smethod_14(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
		{
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 72:
					return stream_0.Read(byte_0, int_0, int_1);
				}
			}
		}
	}

	static Class36()
	{
		Class37.smethod_15();
	}

	internal static char smethod_0(int int_0, int int_1, int int_2)
	{
		while (true)
		{
			switch (int_2 ^ int_1)
			{
			case 124:
				return Convert.ToChar(int_0);
			}
		}
	}

	internal static bool smethod_1(string string_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 0:
				return string_0.Contains(string_1);
			}
		}
	}

	internal static void smethod_2(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 2:
				stream_0.Write(byte_0, int_0, int_1);
				return;
			}
		}
	}

	internal static bool smethod_3(string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 0:
				return Directory.Exists(string_0);
			}
		}
	}

	internal static string smethod_4(ResolveEventArgs resolveEventArgs_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 84:
				return resolveEventArgs_0.Name;
			}
		}
	}

	internal static Color smethod_5(int int_0, int int_1, int int_2)
	{
		while (true)
		{
			switch (int_2 ^ int_1)
			{
			case 32:
				return Color.FromArgb(int_0);
			}
		}
	}

	internal static Assembly smethod_6(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 95:
				return Assembly.GetExecutingAssembly();
			}
		}
	}

	internal static Process smethod_7(int int_0, int int_1, int int_2)
	{
		while (true)
		{
			switch (int_2 ^ int_1)
			{
			case 88:
				return Process.GetProcessById(int_0);
			}
		}
	}

	internal static void smethod_8(Exception exception_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 96:
				ProjectData.SetProjectError(exception_0);
				return;
			}
		}
	}

	internal static Type smethod_9(RuntimeTypeHandle runtimeTypeHandle_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 7:
				return Type.GetTypeFromHandle(runtimeTypeHandle_0);
			}
		}
	}

	internal static int smethod_10(string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 80:
				return string_0.Length;
			}
		}
	}

	internal static string[] smethod_11(string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 25:
				return Directory.GetDirectories(string_0);
			}
		}
	}
}
