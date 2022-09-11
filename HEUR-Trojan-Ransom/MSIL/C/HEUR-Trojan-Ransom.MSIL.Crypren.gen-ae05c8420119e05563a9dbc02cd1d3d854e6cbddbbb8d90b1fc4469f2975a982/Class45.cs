using System;
using System.IO;
using System.Reflection;
using System.Threading;

internal class Class45
{
	private delegate string Delegate2(int int_0);

	private static Assembly assembly_0;

	private static object object_0;

	private static int int_0;

	private static string[] string_0;

	private static Delegate2 delegate2_0;

	static Class45()
	{
		object_0 = new object();
		delegate2_0 = smethod_1;
	}

	public static void smethod_0()
	{
		if ((int_0 != 0) ? true : false)
		{
			return;
		}
		try
		{
			Monitor.Enter(object_0);
			if (int_0 == 0 && 0 == 0)
			{
				AppDomain.CurrentDomain.ResourceResolve += smethod_2;
				int_0 = 1;
			}
		}
		finally
		{
			Monitor.Exit(object_0);
		}
	}

	public static string smethod_1(int int_1)
	{
		char[] array = "\u008d\u008f\u008d\u009a\u009d".ToCharArray();
		int num = array.Length;
		while (--num >= 0)
		{
			array[num] = (char)(array[num] ^ 0x74u ^ (uint)int_1);
		}
		return new string(array);
	}

	public static Assembly smethod_2(object object_1, ResolveEventArgs resolveEventArgs_0)
	{
		return smethod_3(resolveEventArgs_0.Name);
	}

	private static Assembly smethod_3(string string_1)
	{
		if (string_0 == null && 0 == 0)
		{
			Monitor.Enter(object_0);
			try
			{
				if (string_0 == null && 0 == 0)
				{
					Stream manifestResourceStream = typeof(Class45).Assembly.GetManifestResourceStream(delegate2_0(139));
					if (manifestResourceStream != null || 1 == 0)
					{
						assembly_0 = smethod_4(manifestResourceStream);
					}
				}
			}
			catch
			{
			}
			finally
			{
				Monitor.Exit(object_0);
			}
		}
		if (string_0 != null || 1 == 0)
		{
			string[] array = string_0;
			foreach (string b in array)
			{
				if (string.Equals(string_1, b, StringComparison.OrdinalIgnoreCase) || 1 == 0)
				{
					return assembly_0;
				}
			}
		}
		return null;
	}

	private static Assembly smethod_4(Stream stream_0)
	{
		BinaryReader binaryReader = new BinaryReader(Class49.smethod_0(stream_0));
		int num = binaryReader.ReadInt32() ^ 0x14EAC873;
		string[] array = new string[num];
		for (int i = 0; i < num; i++)
		{
			string text = binaryReader.ReadString();
			char[] array2 = new char[text.Length];
			for (int j = 0; j < array2.Length; j++)
			{
				array2[j] = (char)(text[j] ^ 0xEA8u);
			}
			array[i] = new string(array2);
		}
		string_0 = array;
		num = binaryReader.ReadInt32() ^ 0x38998830;
		byte[] array3 = new byte[num];
		binaryReader.Read(array3, 0, num);
		return Assembly.Load(array3);
	}
}
