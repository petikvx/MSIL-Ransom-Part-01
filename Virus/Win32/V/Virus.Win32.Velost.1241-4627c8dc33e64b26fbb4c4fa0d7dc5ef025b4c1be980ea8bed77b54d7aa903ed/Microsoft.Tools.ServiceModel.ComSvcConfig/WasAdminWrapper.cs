using System;
using System.Collections;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Runtime.InteropServices;

namespace Microsoft.Tools.ServiceModel.ComSvcConfig;

internal static class WasAdminWrapper
{
	private const string webService = "IIS://localhost/w3svc";

	private const string defaultWebServer = "1";

	public static string DefaultWebServer => "IIS://localhost/w3svc/1";

	public static bool IsIISInstalled()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			DirectoryEntry val = new DirectoryEntry("IIS://localhost/w3svc");
			IEnumerator enumerator = val.get_Children().GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					_ = (DirectoryEntry)enumerator.Current;
					return true;
				}
			}
			finally
			{
				IDisposable disposable = enumerator as IDisposable;
				if (disposable != null)
				{
					disposable.Dispose();
				}
			}
		}
		catch (COMException)
		{
			return false;
		}
		return true;
	}

	public static string[] GetWebServerNames()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		if (!IsIISInstalled())
		{
			return null;
		}
		try
		{
			List<string> list = new List<string>();
			DirectoryEntry val = new DirectoryEntry("IIS://localhost/w3svc");
			foreach (DirectoryEntry child in val.get_Children())
			{
				DirectoryEntry val2 = child;
				if (val2.get_SchemaClassName().ToUpperInvariant() == "IISWEBSERVER")
				{
					list.Add("IIS://localhost/w3svc/" + val2.get_Name());
				}
			}
			return list.ToArray();
		}
		catch (COMException ex)
		{
			ToolConsole.WriteWarning(SR.GetString("CannotGetWebServersIgnoringWas", ex.ErrorCode, ex.Message));
			return null;
		}
	}

	public static string[] GetWebDirectoryNames(string webServer)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		if (!IsIISInstalled())
		{
			return null;
		}
		try
		{
			List<string> list = new List<string>();
			DirectoryEntry val = new DirectoryEntry(webServer);
			foreach (DirectoryEntry child in val.get_Children())
			{
				DirectoryEntry val2 = child;
				if (!(val2.get_SchemaClassName().ToUpperInvariant() == "IISWEBDIRECTORY") && !(val2.get_SchemaClassName().ToUpperInvariant() == "IISWEBVIRTUALDIR"))
				{
					continue;
				}
				list.Add(val2.get_Name());
				if (!(val2.get_Name().ToUpperInvariant() == "ROOT"))
				{
					continue;
				}
				foreach (DirectoryEntry child2 in val2.get_Children())
				{
					DirectoryEntry val3 = child2;
					if (val3.get_SchemaClassName().ToUpperInvariant() == "IISWEBDIRECTORY" || val3.get_SchemaClassName().ToUpperInvariant() == "IISWEBVIRTUALDIR")
					{
						list.Add("ROOT/" + val3.get_Name());
					}
				}
			}
			return list.ToArray();
		}
		catch (COMException ex)
		{
			ToolConsole.WriteWarning(SR.GetString("CannotGetWebDirectoryForServer", webServer, ex.ErrorCode, ex.Message));
			return null;
		}
	}

	public static bool GetWebDirectoryPath(string webServer, string webDirectory, out string webDirectoryPath)
	{
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		webDirectoryPath = null;
		if (!IsIISInstalled())
		{
			return false;
		}
		if (!webDirectory.ToUpperInvariant().StartsWith("ROOT", StringComparison.Ordinal))
		{
			webDirectory = "root/" + webDirectory;
		}
		string[] webDirectoryNames = GetWebDirectoryNames(webServer);
		if (webDirectoryNames == null)
		{
			return false;
		}
		bool flag = false;
		string[] array = webDirectoryNames;
		foreach (string text in array)
		{
			if (text.ToUpperInvariant() == webDirectory.ToUpperInvariant())
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			return false;
		}
		DirectoryEntry val = new DirectoryEntry(webServer + "/" + webDirectory);
		try
		{
			if (val.get_Properties().Contains("Path"))
			{
				webDirectoryPath = (string)val.get_Properties().get_Item("Path").get_Value();
				return true;
			}
			return false;
		}
		catch (COMException ex)
		{
			ToolConsole.WriteWarning(SR.GetString("CannotGetWebDirectoryPathOnWebDirOfWebServIgnoring", webServer, webDirectory, ex.ErrorCode, ex.Message));
			return false;
		}
	}
}
