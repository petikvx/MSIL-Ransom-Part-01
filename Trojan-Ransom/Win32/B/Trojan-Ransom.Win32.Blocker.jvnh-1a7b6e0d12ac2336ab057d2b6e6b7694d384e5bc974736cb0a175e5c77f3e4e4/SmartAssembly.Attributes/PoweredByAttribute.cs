using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Resources;
using Microsoft.VisualBasic.CompilerServices;
using ns1;

namespace SmartAssembly.Attributes;

public sealed class PoweredByAttribute : Attribute
{
	internal sealed class Class7
	{
		internal static int smethod_0(string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 58:
					return string_0.Length;
				}
			}
		}

		internal static char smethod_1(string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 124:
					return Conversions.ToChar(string_0);
				}
			}
		}

		internal static Assembly smethod_2(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 72:
					return Assembly.GetEntryAssembly();
				case 73:
					return Assembly.GetExecutingAssembly();
				}
			}
		}

		internal static string smethod_3(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 26:
					return Environment.SystemDirectory;
				}
			}
		}

		internal static string smethod_4(char char_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 39:
					return Conversions.ToString(char_0);
				}
			}
		}

		internal static string smethod_5(string string_0, string string_1, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 72:
					return string_0 + string_1;
				}
			}
		}

		internal static bool smethod_6(string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 123:
					return Directory.Exists(string_0);
				}
			}
		}

		internal static object smethod_7(ResourceManager resourceManager_0, string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 87:
					return resourceManager_0.GetObject(string_0);
				}
			}
		}

		internal static Color smethod_8(int int_0, int int_1, int int_2)
		{
			while (true)
			{
				switch (int_2 ^ int_1)
				{
				case 58:
					return Color.FromArgb(int_0);
				}
			}
		}

		internal static object smethod_9(MethodBase methodBase_0, object object_0, object[] object_1, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 2:
					return methodBase_0.Invoke(object_0, object_1);
				}
			}
		}

		internal static void smethod_10(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
		{
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 65:
					stream_0.Write(byte_0, int_0, int_1);
					return;
				}
			}
		}
	}

	public PoweredByAttribute(string s)
	{
	}

	static PoweredByAttribute()
	{
		Class1.smethod_11();
	}

	internal static string smethod_0(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 4:
				return assembly_0.Location;
			}
		}
	}

	internal static Process[] smethod_1(string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 126:
				return Process.GetProcessesByName(string_0);
			}
		}
	}

	internal static void smethod_2(Process process_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 3:
				process_0.Kill();
				return;
			}
		}
	}

	internal static short smethod_3(byte[] byte_0, int int_0, int int_1, int int_2)
	{
		while (true)
		{
			switch (int_2 ^ int_1)
			{
			case 35:
				return BitConverter.ToInt16(byte_0, int_0);
			}
		}
	}

	internal static int smethod_4(ref IntPtr intptr_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 85:
				return intptr_0.ToInt32();
			}
		}
	}

	internal static Assembly smethod_5(byte[] byte_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 71:
				return Assembly.Load(byte_0);
			}
		}
	}
}
