using System;
using System.IO;
using System.IO.Packaging;
using System.Reflection;
using System.Windows.Forms;

internal static class Class1
{
	private static Assembly gOtKffAdF(Package package_0, string string_0)
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
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			using Stream stream = typeof(Class1).Assembly.GetManifestResourceStream("a.zip");
			Package val = Package.Open(stream, FileMode.Open, FileAccess.Read);
			try
			{
				Assembly assembly = gOtKffAdF(val, "/clean.exe");
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
