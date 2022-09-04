using System;
using System.IO;
using System.IO.Packaging;
using System.Reflection;
using System.Security;
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
			throw new ArgumentException(Class1.smethod_0("\ue8c1\ue8fa\ue8f5\ue8f6\ue8f8\ue8f1\ue8b4\ue8e0\ue8fb\ue8b4\ue8f8\ue8fb\ue8f5\ue8f0\ue8b4\ue8f5\ue8e7\ue8e7\ue8f1\ue8f9\ue8f6\ue8f8\ue8ed\ue8ae\ue8b4", 59540) + string_0);
		}
		return assembly;
	}

	[SecuritySafeCritical]
	[STAThread]
	private static void Main(string[] args)
	{
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		if (DateTime.Now > new DateTime(634925624812124373L))
		{
			throw new Exception();
		}
		try
		{
			using Stream stream = typeof(Class0).Assembly.GetManifestResourceStream(Class1.smethod_0("\uf23b\uf274\uf220\uf233\uf22a", 61954));
			Package val = Package.Open(stream, FileMode.Open, FileAccess.Read);
			try
			{
				Assembly assembly = smethod_0(val, Class1.smethod_0("\uf3f9\uf385\uf3b3\uf3a4\uf3a0\uf3b3\uf3a4\uf3b7\uf3b7\uf3b7\uf3b7\uf3b7\uf3b7\uf3b7\uf3b7\uf3b7\uf3b7\uf3fb\uf3fb\uf3fb\uf395\uf3b9\uf3a6\uf3af\uf3f8\uf3b3\uf3ae\uf3b3", 62342));
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
		Class1.Class3.smethod_12();
	}
}
