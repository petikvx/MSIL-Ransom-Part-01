using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using MSHelpServices;

namespace CoreLab.Common.Setup;

public class InnovaHxReg
{
	private string exeFile;

	private string helpDir;

	private string installationDirectory;

	private string ideList;

	private string productName;

	public InnovaHxReg(string helpDir, string installationDirectory, string ideList, string productName)
	{
		exeFile = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
		if (exeFile.Substring(0, 5) == "file:")
		{
			exeFile = Path.Combine(exeFile.Substring(6), "InnovaHxReg.exe");
		}
		this.helpDir = helpDir;
		this.installationDirectory = installationDirectory;
		this.ideList = ideList;
		this.productName = productName;
	}

	public void RegisterProduct(string namespaceName, string description, string helpFile, string[] helpCollections, bool merge, bool filter)
	{
		string arguments = $"/QA /R /N /Namespace:\"{namespaceName}\" /Description:\"{description}\" /Collection:\"{helpFile}.hxc\"";
		ExecuteProcess(exeFile, arguments, helpDir);
		arguments = string.Format("/QA /R /T /Namespace:\"{0}\" /ID:\"{1}\" /LangID:1033 /HelpFile:\"{1}.hxs\"", namespaceName, helpFile);
		ExecuteProcess(exeFile, arguments, helpDir);
		foreach (string arg in helpCollections)
		{
			arguments = $"/QA /R /P /ProductNamespace:\"{arg}\" /ProductHxt:_DEFAULT /Namespace:\"{namespaceName}\" /Hxt:_DEFAULT /Hxa:\"{helpFile}.hxa\"";
			ExecuteProcess(exeFile, arguments, helpDir);
		}
		if (filter)
		{
			ExecuteProcess(exeFile, $"/R /F /Namespace:\"{namespaceName}\" /FilterName:\"Core Lab Documentation\" /FilterQuery:\"'DocSet'='CoreLab'\"", helpDir);
		}
		if (merge)
		{
			foreach (string helpCollection in helpCollections)
			{
				UpdateHelp(helpCollection);
			}
		}
	}

	public void UnregisterProduct(string namespaceName, string helpFile, string[] helpCollections, bool merge)
	{
		string arguments;
		foreach (string arg in helpCollections)
		{
			arguments = $"/QA /U /P /ProductNamespace:\"{arg}\" /ProductHxt:_DEFAULT /Namespace:\"{namespaceName}\" /Hxt:_DEFAULT /Hxa:\"{helpFile}.hxa\"";
			ExecuteProcess(exeFile, arguments, helpDir);
		}
		arguments = string.Format("/QA /U /T /Namespace:\"{0}\" /ID:\"{1}\" /LangID:1033 /HelpFile:\"{1}.hxs\"", namespaceName, helpFile);
		ExecuteProcess(exeFile, arguments, helpDir);
		arguments = $"/QA /U /N /Namespace:\"{namespaceName}\"";
		ExecuteProcess(exeFile, arguments, helpDir);
		if (merge)
		{
			foreach (string helpCollection in helpCollections)
			{
				UpdateHelp(helpCollection);
			}
		}
	}

	private static void ExecuteProcess(string target, string arguments, string workDir)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo(target);
		processStartInfo.Arguments = arguments;
		processStartInfo.WorkingDirectory = workDir;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.RedirectStandardOutput = true;
		Process process = Process.Start(processStartInfo);
		process.WaitForExit();
		if (process.ExitCode == 2)
		{
			throw new CustomActionException(null, "Hxds.dll is missing or unregistered. This library is required to register or unregister help files.");
		}
		if (process.ExitCode > 2)
		{
			throw new CustomActionException(new Exception(process.StandardOutput.ReadToEnd()), "Error occured in Hxds.dll while processing help files");
		}
	}

	private void UpdateHelp(string helpCollection)
	{
		IHxSession hxSession = null;
		try
		{
			HxSessionClass hxSessionClass = new HxSessionClass();
			hxSession = (IHxSession)hxSessionClass;
			hxSession.Initialize("ms-help://" + helpCollection, 0);
			hxSession.GetNavigationObject("!DefaultKeywordIndex", "");
		}
		catch (Exception ex)
		{
			bool logSaved;
			if (logSaved = installationDirectory != null)
			{
				logSaved = CustomActionUtils.WriteError(installationDirectory, "HelpReg", ex);
			}
			if (ideList.ToUpper().Trim() != "NOIDE")
			{
				CustomActionUtils.ShowMessage("Exception message: " + ex.Message, logSaved, productName);
			}
		}
		finally
		{
			if (hxSession != null)
			{
				Marshal.ReleaseComObject(hxSession);
				hxSession = null;
			}
		}
	}
}
