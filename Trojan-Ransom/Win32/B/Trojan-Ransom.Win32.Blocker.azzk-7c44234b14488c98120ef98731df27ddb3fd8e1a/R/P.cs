using System;
using System.IO;
using System.IO.Packaging;
using System.Reflection;
using System.Windows.Forms;

namespace R;

internal static class P
{
	private static Assembly L(Package p, string u)
	{
		Uri uri = new Uri(u, UriKind.Relative);
		byte[] array;
		using (Stream stream = p.GetPart(uri).GetStream())
		{
			array = new byte[(int)stream.Length];
			stream.Read(array, 0, array.Length);
		}
		Assembly assembly = Assembly.Load(array);
		if (null == assembly)
		{
			throw new ArgumentException("Unable to load assembly: " + u);
		}
		return assembly;
	}

	[STAThread]
	private static void Main(string[] args)
	{
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			using Stream stream = typeof(P).Assembly.GetManifestResourceStream("a.zip");
			Package val = Package.Open(stream, FileMode.Open, FileAccess.Read);
			try
			{
				Assembly assembly = L(val, "/bin.exe");
				assembly.EntryPoint!.Invoke(null, new object[0]);
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
