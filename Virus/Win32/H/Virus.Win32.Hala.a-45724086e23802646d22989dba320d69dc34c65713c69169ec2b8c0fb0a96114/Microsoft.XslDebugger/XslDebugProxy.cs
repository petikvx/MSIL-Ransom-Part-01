using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.Remoting.Lifetime;
using System.Windows.Forms;
using System.Xml;
using Microsoft.Win32.SafeHandles;
using Microsoft.XmlEditor;

namespace Microsoft.XslDebugger;

public class XslDebugProxy
{
	private static void Main(string[] args)
	{
		//IL_0058: Expected O, but got Unknown
		if (args.Length < 5)
		{
			throw new ArgumentNullException();
		}
		IntPtr preexistingHandle = new IntPtr(long.Parse(args[4], CultureInfo.InvariantCulture));
		SafeFileHandle handle = new SafeFileHandle(preexistingHandle, ownsHandle: true);
		FileStream fileStream = new FileStream(handle, FileAccess.Write, 8);
		XslDebugProxy xslDebugProxy = new XslDebugProxy();
		LifetimeServices.set_LeaseTime(TimeSpan.Zero);
		try
		{
			xslDebugProxy.ExecuteSafe(args[0], args[1], args[2], args[3], fileStream);
		}
		catch (XsltCompileException val)
		{
			XsltCompileException val2 = val;
			string @string = SR.GetString("XsltCompileError");
			ShowError(@string, ((Exception)(object)val2).Message);
		}
		catch
		{
			throw;
		}
		finally
		{
			fileStream.Close();
			preexistingHandle = IntPtr.Zero;
		}
	}

	private void ExecuteSafe(string xslPath, string xmlPath, string xslLocalPath, string xmlLocalPath, FileStream pipe)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		AssemblyName name = GetType().Assembly.GetName();
		XslAppDomain val = new XslAppDomain(name, "Microsoft.Xsl.XslDebuggerPlugin", 1);
		List<string> list = new List<string>();
		XsltDebuggerResolver val2 = new XsltDebuggerResolver(xslPath, xslLocalPath, list);
		((XmlResolver)(object)val2).Credentials = CredentialCache.DefaultCredentials;
		XmlUrlResolver xmlUrlResolver = new XmlUrlResolver();
		xmlUrlResolver.Credentials = CredentialCache.DefaultCredentials;
		string text = default(string);
		XmlOutputMethod xmlOutputMethod = default(XmlOutputMethod);
		val.Transform(xmlPath, xslPath, xmlLocalPath, xslLocalPath, (XmlResolver)(object)val2, (XmlResolver)xmlUrlResolver, (StatusHandler)null, (Stream)pipe, true, ref text, ref xmlOutputMethod);
	}

	internal static void ShowError(string caption, string message)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		RTLAwareMessageBox.Show((IWin32Window)null, message, caption, (MessageBoxButtons)0, (MessageBoxIcon)16, (MessageBoxDefaultButton)0, (MessageBoxOptions)0);
	}

	public static string GetExceptionText(Exception ex)
	{
		Exception ex2 = null;
		string text = ex.Message;
		ex2 = ex;
		while ((ex2 = ex2.InnerException) != null)
		{
			if (ex2.Message != null)
			{
				text = text + " " + ex2.Message;
			}
		}
		return text;
	}
}
