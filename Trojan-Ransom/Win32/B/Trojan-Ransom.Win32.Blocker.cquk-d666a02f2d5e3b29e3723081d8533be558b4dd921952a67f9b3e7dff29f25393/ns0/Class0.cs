using System;
using System.IO;
using System.IO.Packaging;
using System.Reflection;
using System.Windows.Forms;

namespace ns0;

internal static class Class0
{
	private static bool bool_0;

	private static Assembly smethod_0(Package package_0, string string_0)
	{
		Uri uri_ = new Uri(string_0, UriKind.Relative);
		byte[] array;
		using (Stream stream_ = Class1.Class2.smethod_0(Class1.smethod_1(package_0, uri_, 726, 701), 462, 461))
		{
			array = new byte[(int)smethod_1(stream_, 671, 706)];
			smethod_2(stream_, array, 0, array.Length, 540, 618);
		}
		Assembly assembly = Class1.Class2.smethod_1(array, 932, 990);
		if ((object)assembly == null)
		{
			throw new ArgumentException(Class1.smethod_0(403405356, 0) + string_0);
		}
		return assembly;
	}

	[STAThread]
	private static void Main(string[] args)
	{
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		smethod_3();
		try
		{
			using Stream stream_ = Class1.Class2.Class3.smethod_2(Class1.Class2.Class4.smethod_0(Class1.smethod_2(typeof(Class0).TypeHandle, 380, 307), 449, 455), Class1.smethod_0(403405360, 0), 799, 863);
			Package val = Class1.smethod_3(stream_, FileMode.Open, FileAccess.Read, 414, 420);
			try
			{
				Assembly assembly_ = smethod_0(val, Class1.smethod_0(403405323, 3));
				Class1.smethod_4(Class1.Class2.Class3.smethod_3(assembly_, 273, 273), null, new object[0], 685, 658);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(Class1.smethod_6(Class1.smethod_5(ex, 682, 725), 246, 180) + Class1.smethod_0(403405339, 5) + ex.Message + Class1.smethod_0(403405338, 4) + ex.StackTrace);
		}
	}

	internal static long smethod_1(Stream stream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 93:
				return stream_0.Length;
			}
		}
	}

	internal static int smethod_2(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 118:
				return stream_0.Read(byte_0, int_0, int_1);
			}
		}
	}

	internal static void smethod_3()
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
				AppDomain.CurrentDomain.ResourceResolve += Class1.Class2.Class3.smethod_0;
			}
		}
	}

	internal static object smethod_4(AppDomain appDomain_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 39:
				return appDomain_0.GetData(string_0);
			}
		}
	}

	internal static int smethod_5(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 1:
				return stream_0.Read(byte_0, int_0, int_1);
			}
		}
	}

	internal static string[] smethod_6(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 49:
				return assembly_0.GetManifestResourceNames();
			}
		}
	}
}
