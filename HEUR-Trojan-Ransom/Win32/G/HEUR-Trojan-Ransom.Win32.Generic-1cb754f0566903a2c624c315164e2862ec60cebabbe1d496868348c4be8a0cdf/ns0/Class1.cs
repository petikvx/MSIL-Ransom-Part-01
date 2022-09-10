using System;
using System.IO;
using System.IO.Packaging;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Forms;

namespace ns0;

internal static class Class1
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 272)]
	private struct Struct0
	{
	}

	internal sealed class Class2
	{
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1 = new char[136];

	private static readonly string[] string_0;

	internal static byte byte_0/* Not supported: data(00) */;

	private static bool bool_0;

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
			throw new ArgumentException(Class3.smethod_0("\uf8f8\uf8c3\uf8cc\uf8cf\uf8c1\uf8c8\uf88d\uf8d9\uf8c2\uf88d\uf8c1\uf8c2\uf8cc\uf8c9\uf88d\uf8cc\uf8de\uf8de\uf8c8\uf8c0\uf8cf\uf8c1\uf8d4\uf897\uf88d", 63624) + string_1);
		}
		return assembly;
	}

	[SecuritySafeCritical]
	[STAThread]
	private static void Main(string[] args)
	{
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		if (!(DateTime.Now > new DateTime(635031786666052451L)))
		{
			try
			{
				using Stream stream = typeof(Class1).Assembly.GetManifestResourceStream(Class3.smethod_0("\ued16\ued59\ued0d\ued1e\ued07", 60771));
				Package val = Package.Open(stream, FileMode.Open, FileAccess.Read);
				try
				{
					Assembly assembly = smethod_0(val, Class3.smethod_0("\uf4d2\uf4be\uf48f\uf484\uf48d\uf489\uf498\uf499\uf4d3\uf48d\uf49c\uf49e\uf496\uf498\uf499\uf4d3\uf498\uf485\uf498", 62500));
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

	[SecuritySafeCritical]
	static Class1()
	{
		char[] array = new char[8];
		array[6] = '߷';
		array[4] = '⥎';
		array[3] = 'ᬊ';
		array[7] = '⟶';
		array[2] = '㇘';
		array[5] = '\u094a';
		array[0] = '㲫';
		array[1] = '⸏';
		string_0 = new string[5];
		char_0 = array;
	}
}
