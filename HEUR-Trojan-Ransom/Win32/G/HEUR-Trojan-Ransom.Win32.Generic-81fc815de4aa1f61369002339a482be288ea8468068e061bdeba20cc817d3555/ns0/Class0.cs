using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.IO.Packaging;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Forms;

namespace ns0;

internal static class Class0
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 254)]
	private struct Struct0
	{
	}

	[StructLayout(LayoutKind.Auto)]
	internal struct Struct1
	{
		internal byte[] byte_0;
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static byte byte_0/* Not supported: data(00) */;

	private static bool bool_0;

	[SecuritySafeCritical]
	static Class0()
	{
		smethod_6();
		char_1 = new char[127];
		char[] array = new char[8];
		array[2] = '㗤';
		array[4] = '₦';
		array[1] = '㋅';
		array[6] = '⩽';
		array[3] = '⨏';
		array[7] = 'ˊ';
		array[0] = '\u1943';
		array[5] = '㝃';
		string_0 = new string[5];
		char_0 = array;
	}

	private static Assembly smethod_0(Package package_0, string string_1)
	{
		Uri uri = new Uri(string_1, UriKind.Relative);
		byte[] array;
		using (Stream stream_ = Class1.Class3.Class4.smethod_0(package_0.GetPart(uri), 133, 141))
		{
			array = new byte[(int)Class1.smethod_2(stream_, 1004, 926)];
			Class1.Class3.Class4.smethod_1(stream_, array, 0, array.Length, 941, 968);
		}
		Assembly assembly = Class1.smethod_3(array, 942, 992);
		if (Class1.smethod_4(null, assembly, 485, 410))
		{
			throw new ArgumentException(Class1.smethod_0("\ue0bf\ue084\ue08b\ue088\ue086\ue08f\ue0ca\ue09e\ue085\ue0ca\ue086\ue085\ue08b\ue08e\ue0ca\ue08b\ue099\ue099\ue08f\ue087\ue088\ue086\ue093\ue0d0\ue0ca", 57546) + string_1);
		}
		return assembly;
	}

	[SecuritySafeCritical]
	[STAThread]
	private static void Main(string[] args)
	{
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		if (!(DateTime.Now > new DateTime(635041407695963149L)))
		{
			smethod_6();
			if (Class1.Class3.smethod_0(Class1.smethod_5(701, 766), new DateTime(635041406826163399L), 24, 123))
			{
				throw new Exception();
			}
			try
			{
				using Stream stream_ = Class1.Class3.Class4.smethod_3(Class1.Class3.Class4.smethod_2(Class1.Class3.smethod_1(typeof(Class0).TypeHandle, 419, 484), 254, 185), Class1.smethod_0("\uf59c\uf5d3\uf587\uf594\uf58d", 62813), 972, 910);
				Package val = Class1.smethod_6(stream_, FileMode.Open, FileAccess.Read, 348, 379);
				try
				{
					Assembly assembly_ = smethod_0(val, Class1.smethod_0("\uea82\ueacf\ueac1\ueacc\ueace\ueac6\uea83\ueac8\uead5\ueac8", 60076));
					Class1.smethod_7(smethod_2(assembly_, 773, 813), null, new object[0], 748, 641);
					return;
				}
				finally
				{
					((IDisposable)val)?.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(Class1.Class3.Class4.smethod_4(ex, 239, 208).Name + Environment.NewLine + ex.Message + Environment.NewLine + ex.StackTrace);
				return;
			}
		}
		throw new Exception();
	}

	internal static Assembly smethod_1(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		if (Class1.smethod_4(resolveEventArgs_0.RequestingAssembly, smethod_3(968, 934), 263, 391))
		{
			return null;
		}
		string text = "C73DE52796DE476F1A7BBB391286D0793BE877EA";
		string text2 = text;
		string name = text2 + '1';
		AppDomain appDomain = smethod_4(999, 1001);
		Dictionary<string, string> dictionary = (Dictionary<string, string>)Class1.smethod_8(appDomain, name, 955, 1001);
		Assembly assembly;
		if (dictionary == null)
		{
			dictionary = new Dictionary<string, string>();
			appDomain.SetData(name, dictionary);
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			Stream stream = Class1.Class3.Class4.smethod_3(executingAssembly, text, 608, 547);
			if (stream == null)
			{
				return null;
			}
			byte[] array = new byte[Class1.smethod_2(stream, 849, 802) - 1L];
			int num = Class1.Class3.Class4.smethod_5(stream, 328, 355);
			Class1.Class3.Class4.smethod_1(stream, array, 0, array.Length, 668, 762);
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
					Class1.Class3.smethod_3(memoryStream, array2, 0, int_, 575, 525);
				}
			}
			assembly = Assembly.Load(smethod_5(memoryStream, 640, 728), (byte[])null, executingAssembly.get_Evidence());
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

	[SecuritySafeCritical]
	internal static MethodInfo smethod_2(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 40:
				return assembly_0.EntryPoint;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Assembly smethod_3(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 109:
				return Assembly.GetExecutingAssembly();
			case 110:
				return Assembly.GetExecutingAssembly();
			case 111:
				return Assembly.GetExecutingAssembly();
			}
		}
	}

	[SecuritySafeCritical]
	internal static AppDomain smethod_4(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 14:
				return AppDomain.CurrentDomain;
			}
		}
	}

	[SecuritySafeCritical]
	internal static byte[] smethod_5(MemoryStream memoryStream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 88:
				return memoryStream_0.ToArray();
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_6()
	{
		if (bool_0)
		{
			return;
		}
		lock (typeof(Class0))
		{
			if (!bool_0)
			{
				bool_0 = true;
				AppDomain.CurrentDomain.ResourceResolve += smethod_1;
			}
		}
	}
}
