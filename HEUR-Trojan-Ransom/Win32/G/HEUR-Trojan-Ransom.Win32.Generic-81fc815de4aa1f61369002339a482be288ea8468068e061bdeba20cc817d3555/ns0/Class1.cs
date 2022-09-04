using System;
using System.IO;
using System.IO.Packaging;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

namespace ns0;

internal sealed class Class1
{
	private sealed class Class2
	{
		public static readonly Class2 class2_0;

		internal byte[] byte_0;

		[SecuritySafeCritical]
		static Class2()
		{
			Class0.smethod_6();
			if (Class3.smethod_0(smethod_5(408, 475), new DateTime(635041406814172713L), 272, 371))
			{
				throw new Exception();
			}
			class2_0 = new Class2();
		}

		private Class2()
		{
			Assembly assembly_ = Class0.smethod_3(294, 331);
			Stream stream = Class3.Class4.smethod_3(assembly_, smethod_1(), 391, 453);
			if (stream != null)
			{
				byte[] array = (byte_0 = new byte[256]);
				stream.Read(byte_0, 0, byte_0.Length);
			}
		}

		public string method_0(string string_0, int int_0)
		{
			int num = Class3.smethod_2(string_0, 67, 36);
			int num2 = int_0 & 0xFF;
			char[] array = string_0.ToCharArray();
			while (--num >= 0)
			{
				array[num] = (char)(array[num] ^ (byte_0[num2] | int_0));
			}
			return string.Intern(new string(array));
		}
	}

	internal sealed class Class3
	{
		internal sealed class Class4
		{
			[SecuritySafeCritical]
			internal static Stream smethod_0(PackagePart packagePart_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 8:
						return packagePart_0.GetStream();
					}
				}
			}

			[SecuritySafeCritical]
			internal static int smethod_1(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
			{
				while (true)
				{
					switch (int_3 ^ int_2)
					{
					case 101:
						return stream_0.Read(byte_0, int_0, int_1);
					case 102:
						return stream_0.Read(byte_0, int_0, int_1);
					case 103:
						return stream_0.Read(byte_0, int_0, int_1);
					}
				}
			}

			[SecuritySafeCritical]
			internal static Assembly smethod_2(Type type_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 71:
						return type_0.Assembly;
					}
				}
			}

			[SecuritySafeCritical]
			internal static Stream smethod_3(Assembly assembly_0, string string_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 66:
						return assembly_0.GetManifestResourceStream(string_0);
					case 67:
						return assembly_0.GetManifestResourceStream(string_0);
					}
				}
			}

			[SecuritySafeCritical]
			internal static Type smethod_4(Exception exception_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 63:
						return exception_0.GetType();
					}
				}
			}

			[SecuritySafeCritical]
			internal static int smethod_5(Stream stream_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 43:
						return stream_0.ReadByte();
					}
				}
			}
		}

		[SecuritySafeCritical]
		internal static bool smethod_0(DateTime dateTime_0, DateTime dateTime_1, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 99:
					return dateTime_0 > dateTime_1;
				}
			}
		}

		[SecuritySafeCritical]
		internal static Type smethod_1(RuntimeTypeHandle runtimeTypeHandle_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 71:
					return Type.GetTypeFromHandle(runtimeTypeHandle_0);
				}
			}
		}

		[SecuritySafeCritical]
		internal static int smethod_2(string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 103:
					return string_0.Length;
				}
			}
		}

		[SecuritySafeCritical]
		internal static void smethod_3(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
		{
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 50:
					stream_0.Write(byte_0, int_0, int_1);
					return;
				}
			}
		}
	}

	[SecuritySafeCritical]
	static Class1()
	{
		Class0.smethod_6();
	}

	public static string smethod_0(string string_0, int int_0)
	{
		if (Class3.smethod_0(smethod_5(543, 604), new DateTime(635041406817132883L), 818, 849))
		{
			throw new Exception();
		}
		return string.Intern(Class2.class2_0.method_0(string_0, int_0));
	}

	[SpecialName]
	public static string smethod_1()
	{
		return "fe4e3bb920dc4e118c58eb982aba7602";
	}

	[SecuritySafeCritical]
	internal static long smethod_2(Stream stream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 114:
				return stream_0.Length;
			case 115:
				return stream_0.Length;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Assembly smethod_3(byte[] byte_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 78:
				return Assembly.Load(byte_0);
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool smethod_4(Assembly assembly_0, Assembly assembly_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 127:
				return assembly_0 == assembly_1;
			case 128:
				return assembly_0 != assembly_1;
			}
		}
	}

	[SecuritySafeCritical]
	internal static DateTime smethod_5(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 67:
				return DateTime.Now;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Package smethod_6(Stream stream_0, FileMode fileMode_0, FileAccess fileAccess_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 39:
				return Package.Open(stream_0, fileMode_0, fileAccess_0);
			}
		}
	}

	[SecuritySafeCritical]
	internal static object smethod_7(MethodBase methodBase_0, object object_0, object[] object_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 109:
				return methodBase_0.Invoke(object_0, object_1);
			}
		}
	}

	[SecuritySafeCritical]
	internal static object smethod_8(AppDomain appDomain_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 82:
				return appDomain_0.GetData(string_0);
			}
		}
	}
}
