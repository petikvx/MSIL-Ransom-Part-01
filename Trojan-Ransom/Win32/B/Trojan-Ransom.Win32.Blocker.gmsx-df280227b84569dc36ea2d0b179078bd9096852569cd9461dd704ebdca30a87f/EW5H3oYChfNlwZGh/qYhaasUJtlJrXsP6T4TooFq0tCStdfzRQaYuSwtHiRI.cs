using System.Diagnostics;
using System.IO;
using System.Security.Principal;

namespace EW5H3oYChfNlwZGh;

public class qYhaasUJtlJrXsP6T4TooFq0tCStdfzRQaYuSwtHiRI
{
	public static bool V1_UnhHOYwlKQuWcAj8lia
	{
		get
		{
			bool result = false;
			try
			{
				WindowsIdentity current = WindowsIdentity.GetCurrent();
				WindowsPrincipal windowsPrincipal = new WindowsPrincipal(current);
				result = windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
				windowsPrincipal = null;
				current = null;
				return result;
			}
			catch
			{
				return result;
			}
		}
	}

	public static void Bp6n2fHsbdxRu2vINyuQktESCi(string ei8rOc_8bV)
	{
		Bp6n2fHsbdxRu2vINyuQktESCi(ei8rOc_8bV, o5N6491WSUuOqAgF2oTuLh7tdnFvve1Bp3aidTM: false);
		ei8rOc_8bV = null;
	}

	public static void Bp6n2fHsbdxRu2vINyuQktESCi(string ei8rOc_8bV, bool o5N6491WSUuOqAgF2oTuLh7tdnFvve1Bp3aidTM)
	{
		Bp6n2fHsbdxRu2vINyuQktESCi(ei8rOc_8bV, o5N6491WSUuOqAgF2oTuLh7tdnFvve1Bp3aidTM ? "runas" : "open");
	}

	public static void Bp6n2fHsbdxRu2vINyuQktESCi(string ei8rOc_8bV, string Jh3zp_3HB7uCHrnqjsQirDhbV)
	{
		try
		{
			if (!File.Exists(ei8rOc_8bV))
			{
				return;
			}
			string directoryName = Path.GetDirectoryName(ei8rOc_8bV);
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WorkingDirectory = directoryName;
			processStartInfo.Arguments = string.Empty;
			processStartInfo.FileName = ei8rOc_8bV;
			processStartInfo.Verb = Jh3zp_3HB7uCHrnqjsQirDhbV;
			Process process = new Process();
			process.EnableRaisingEvents = false;
			process.StartInfo = processStartInfo;
			process.Start();
			directoryName = null;
			processStartInfo = null;
			process = null;
		}
		catch
		{
		}
		ei8rOc_8bV = null;
		Jh3zp_3HB7uCHrnqjsQirDhbV = null;
	}
}
