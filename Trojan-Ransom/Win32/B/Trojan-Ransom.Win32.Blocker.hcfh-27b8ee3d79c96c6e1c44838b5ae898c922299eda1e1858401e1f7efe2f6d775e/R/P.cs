using System;
using System.IO;
using System.IO.Packaging;
using System.Reflection;
using System.Windows.Forms;
using SmartAssembly.License;
using SmartAssembly.MemoryManagement;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartExceptionsWithoutUI;

namespace R;

internal static class P
{
	private static Assembly L(Package p, string u)
	{
		Uri uri = default(Uri);
		Stream stream = default(Stream);
		byte[] array = default(byte[]);
		Assembly assembly = default(Assembly);
		try
		{
			uri = new Uri(u, UriKind.Relative);
			stream = p.GetPart(uri).GetStream();
			try
			{
				array = new byte[(int)stream.Length];
				stream.Read(array, 0, array.Length);
			}
			finally
			{
				((IDisposable)stream)?.Dispose();
			}
			assembly = Assembly.Load(array);
			if (null == assembly)
			{
				throw new ArgumentException("Unable to load assembly: " + u);
			}
			return assembly;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException6(exception, array, uri, stream, assembly, p, u);
			throw;
		}
	}

	[STAThread]
	private static void Main(string[] args)
	{
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		if (!License.Validate())
		{
			return;
		}
		Stream manifestResourceStream = default(Stream);
		Package val = default(Package);
		Assembly assembly = default(Assembly);
		object[] array = default(object[]);
		Exception ex2 = default(Exception);
		string[] array2 = default(string[]);
		try
		{
			if (!UnhandledExceptionHandlerWithoutUI.AttachApp())
			{
				return;
			}
			try
			{
				MemoryManager.AttachApp();
				manifestResourceStream = typeof(P).Assembly.GetManifestResourceStream("a.zip");
				try
				{
					val = Package.Open(manifestResourceStream, FileMode.Open, FileAccess.Read);
					try
					{
						assembly = L(val, "/Server.exe");
						MethodInfo? entryPoint = assembly.EntryPoint;
						array = new object[1] { args };
						entryPoint!.Invoke(null, array);
					}
					finally
					{
						((IDisposable)val)?.Dispose();
					}
				}
				finally
				{
					((IDisposable)manifestResourceStream)?.Dispose();
				}
			}
			catch (Exception ex)
			{
				ex2 = ex;
				array2 = new string[5]
				{
					ex2.GetType().Name,
					Environment.NewLine,
					ex2.Message,
					Environment.NewLine,
					ex2.StackTrace
				};
				MessageBox.Show(string.Concat(array2));
			}
		}
		catch (Exception exception)
		{
			UnhandledExceptionHandler.EntryPointException(exception, new object[7] { manifestResourceStream, val, assembly, ex2, array, array2, args });
		}
	}
}
