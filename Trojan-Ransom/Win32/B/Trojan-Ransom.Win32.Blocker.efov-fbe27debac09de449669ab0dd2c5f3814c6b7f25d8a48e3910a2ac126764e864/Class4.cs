using System;
using System.IO;
using System.IO.Packaging;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Policy;

internal sealed class Class4
{
	internal sealed class Class5
	{
		internal static Package smethod_0(Stream stream_0, FileMode fileMode_0, FileAccess fileAccess_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 2:
					return Package.Open(stream_0, fileMode_0, fileAccess_0);
				}
			}
		}

		internal static int smethod_1(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
		{
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 74:
					return stream_0.Read(byte_0, int_0, int_1);
				}
			}
		}
	}

	static Class4()
	{
		Class7.NArwkSIzVu170();
		Class1.smethod_9();
	}

	internal static Stream smethod_0(PackagePart packagePart_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 35:
				return packagePart_0.GetStream();
			}
		}
	}

	internal static Assembly smethod_1(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 99:
				return Assembly.GetExecutingAssembly();
			}
		}
	}

	internal static string roPmksypt(string string_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 122:
				return string_0 + string_1;
			}
		}
	}

	internal static void smethod_2(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 32:
				RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
				return;
			}
		}
	}

	internal static Evidence smethod_3(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 20:
				return assembly_0.get_Evidence();
			}
		}
	}
}
