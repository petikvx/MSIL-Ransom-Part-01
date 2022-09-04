using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace ns0;

internal sealed class Class12
{
	internal sealed class Class13
	{
		internal sealed class Class14
		{
		}

		internal sealed class Class15
		{
		}

		internal static char[] smethod_0(string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 77:
					return string_0.ToCharArray();
				}
			}
		}

		internal static int smethod_1(Array array_0, int int_0, int int_1, int int_2)
		{
			while (true)
			{
				switch (int_2 ^ int_1)
				{
				case 58:
					return array_0.GetLength(int_0);
				}
			}
		}

		internal static AppDomain smethod_2(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 3:
					return AppDomain.CurrentDomain;
				}
			}
		}
	}

	internal sealed class Class16
	{
	}

	internal static byte[] smethod_0(MemoryStream memoryStream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 113:
				return memoryStream_0.ToArray();
			}
		}
	}

	internal static MethodInfo smethod_1(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 12:
				return assembly_0.EntryPoint;
			}
		}
	}

	internal static Assembly smethod_2(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 65:
				return Assembly.GetExecutingAssembly();
			}
		}
	}

	internal static int smethod_3(Random random_0, int int_0, int int_1, int int_2, int int_3)
	{
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 35:
				return random_0.Next(int_0, int_1);
			}
		}
	}

	internal static Encoding smethod_4(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 13:
				return Encoding.Default;
			}
		}
	}
}
