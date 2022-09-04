using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;

internal sealed class Class15
{
	internal sealed class Class16
	{
		internal sealed class Class17
		{
			internal static int smethod_0(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
			{
				while (true)
				{
					switch (int_3 ^ int_2)
					{
					case 39:
						return stream_0.Read(byte_0, int_0, int_1);
					}
				}
			}

			internal static void smethod_1(AppDomain appDomain_0, string string_0, object object_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 118:
						appDomain_0.SetData(string_0, object_0);
						return;
					}
				}
			}

			internal static string smethod_2(ResolveEventArgs resolveEventArgs_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 124:
						return resolveEventArgs_0.Name;
					}
				}
			}

			internal static string smethod_3(byte[] byte_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 11:
						return Convert.ToBase64String(byte_0);
					}
				}
			}

			internal static int smethod_4(AppDomain appDomain_0, AssemblyName assemblyName_0, Evidence evidence_0, string[] string_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 110:
						return appDomain_0.ExecuteAssemblyByName(assemblyName_0, evidence_0, string_0);
					}
				}
			}

			internal static AppDomain smethod_5(int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 55:
						return AppDomain.CurrentDomain;
					}
				}
			}

			internal static object smethod_6(AppDomain appDomain_0, string string_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 66:
						return appDomain_0.GetData(string_0);
					}
				}
			}

			internal static Stream smethod_7(Assembly assembly_0, string string_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 93:
						return assembly_0.GetManifestResourceStream(string_0);
					}
				}
			}

			static Class17()
			{
				if (DateTime.Now > new DateTime(635043797220468750L))
				{
					throw new Exception();
				}
			}
		}

		internal sealed class Class18
		{
			[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 86)]
			private struct Struct4
			{
			}

			private static readonly char[] char_0;

			private static readonly char[] char_1;

			private static readonly string[] string_0;

			internal static byte byte_0/* Not supported: data(00) */;

			internal static string smethod_0(object object_0, object object_1, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 84:
						return string.Concat(object_0, object_1);
					}
				}
			}

			internal static AppDomain smethod_1(int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 54:
						return AppDomain.CurrentDomain;
					}
				}
			}

			internal static Encoding smethod_2(int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 46:
						return Encoding.Default;
					}
				}
			}

			internal static Assembly smethod_3(int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 94:
						return Assembly.GetExecutingAssembly();
					}
				}
			}

			static Class18()
			{
				if (DateTime.Now > new DateTime(635043797220498046L))
				{
					throw new Exception();
				}
				char_1 = new char[43];
				char[] array = new char[8];
				array[2] = '㙊';
				array[5] = '᪃';
				array[3] = '\u12d7';
				array[0] = '㼋';
				array[6] = 'Ჵ';
				array[1] = '㶜';
				array[7] = '㝑';
				array[4] = '\u243d';
				string_0 = new string[1];
				char_0 = array;
			}

			internal static byte[] smethod_4(MemoryStream memoryStream_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 8:
						return memoryStream_0.ToArray();
					}
				}
			}

			internal static Evidence smethod_5(Assembly assembly_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 42:
						return assembly_0.get_Evidence();
					}
				}
			}
		}

		private static bool bool_0;

		internal static Assembly smethod_0(object object_0, ResolveEventArgs resolveEventArgs_0)
		{
			string text = "9239C7FFFC9325E140DDF6688BF72DFECE3EB68A";
			string text2 = text;
			string string_ = text2 + '1';
			AppDomain appDomain = Class17.smethod_5(922, 941);
			Dictionary<string, string> dictionary = (Dictionary<string, string>)Class17.smethod_6(appDomain, string_, 238, 172);
			Assembly assembly;
			if (dictionary == null)
			{
				dictionary = new Dictionary<string, string>();
				smethod_8(appDomain, string_, dictionary, 527, 634);
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				Stream stream = Class17.smethod_7(executingAssembly, text, 889, 804);
				if (stream == null)
				{
					return null;
				}
				byte[] array = new byte[stream.Length - 1L];
				int num = stream.ReadByte();
				smethod_9(stream, array, 0, array.Length, 662, 644);
				for (int i = 0; i < array.Length; i++)
				{
					array[i] ^= (byte)((i + num) & 0xFF);
				}
				MemoryStream memoryStream = new MemoryStream();
				using (DeflateStream deflateStream = new DeflateStream(new MemoryStream(array), CompressionMode.Decompress, leaveOpen: true))
				{
					byte[] array2 = new byte[1024];
					int int_;
					while ((int_ = deflateStream.Read(array2, 0, array2.Length)) > 0)
					{
						smethod_10(memoryStream, array2, 0, int_, 456, 433);
					}
				}
				assembly = Class19.smethod_9(Class18.smethod_4(memoryStream, 165, 173), null, Class18.smethod_5(executingAssembly, 450, 488), 725, 713);
				appDomain.SetData(text2, assembly);
				string[] manifestResourceNames = assembly.GetManifestResourceNames();
				foreach (string text3 in manifestResourceNames)
				{
					dictionary[text3] = text3;
				}
			}
			else
			{
				assembly = (Assembly)appDomain.GetData(text2);
			}
			if (dictionary.ContainsKey(resolveEventArgs_0.Name))
			{
				return assembly;
			}
			return null;
		}

		internal static bool smethod_1(DateTime dateTime_0, DateTime dateTime_1, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 44:
					return dateTime_0 > dateTime_1;
				}
			}
		}

		internal static void smethod_2(AppDomain appDomain_0, ResolveEventHandler resolveEventHandler_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 78:
					appDomain_0.ResourceResolve += resolveEventHandler_0;
					return;
				case 79:
					appDomain_0.AssemblyResolve += resolveEventHandler_0;
					return;
				}
			}
		}

		internal static Assembly smethod_3(byte[] byte_0, byte[] byte_1, Evidence evidence_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 122:
					return Assembly.Load(byte_0, byte_1, evidence_0);
				}
			}
		}

		internal static Stream smethod_4(Assembly assembly_0, string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 31:
					return assembly_0.GetManifestResourceStream(string_0);
				}
			}
		}

		internal static byte[] smethod_5(MemoryStream memoryStream_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 80:
					return memoryStream_0.ToArray();
				}
			}
		}

		internal static byte[] smethod_6(BinaryReader binaryReader_0, int int_0, int int_1, int int_2)
		{
			while (true)
			{
				switch (int_2 ^ int_1)
				{
				case 109:
					return binaryReader_0.ReadBytes(int_0);
				}
			}
		}

		internal static void smethod_7()
		{
			if (bool_0)
			{
				return;
			}
			lock (typeof(Class16))
			{
				if (!bool_0)
				{
					bool_0 = true;
					AppDomain.CurrentDomain.ResourceResolve += smethod_0;
				}
			}
		}

		internal static void smethod_8(AppDomain appDomain_0, string string_0, object object_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 117:
					appDomain_0.SetData(string_0, object_0);
					return;
				}
			}
		}

		internal static int smethod_9(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
		{
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 18:
					return stream_0.Read(byte_0, int_0, int_1);
				case 19:
					return stream_0.Read(byte_0, int_0, int_1);
				}
			}
		}

		internal static void smethod_10(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
		{
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 121:
					stream_0.Write(byte_0, int_0, int_1);
					return;
				}
			}
		}

		static Class16()
		{
			if (DateTime.Now > new DateTime(635043653220439453L))
			{
				throw new Exception();
			}
		}
	}

	static Class15()
	{
		if (DateTime.Now > new DateTime(635043653220400390L))
		{
			throw new Exception();
		}
		Class16.smethod_7();
	}

	internal static Evidence smethod_0(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 18:
				return assembly_0.get_Evidence();
			}
		}
	}

	internal static int smethod_1(Stream stream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 101:
				return stream_0.ReadByte();
			}
		}
	}

	internal static long smethod_2(Stream stream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 12:
				return stream_0.Length;
			}
		}
	}

	internal static void smethod_3(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 112:
				RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
				return;
			}
		}
	}

	internal static byte[] smethod_4(Encoding encoding_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 12:
				return encoding_0.GetBytes(string_0);
			}
		}
	}
}
