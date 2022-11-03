using System;
using System.Linq;
using System.Text.RegularExpressions;
using PenterWare.Actions.Results;
using PenterWare.Utils;

namespace PenterWare.Actions;

internal class DeleteShadowCopyAction : SubAction<ShadowCopyResult>
{
	private static string Name = "ShadowCopies";

	private static string DeleteShellCommandLine = "vssadmin.exe delete shadows /all /quiet /?";

	private static string DeleteWMICommandLine = "wmic.exe shadowcopy delete /?";

	private static string ListWMICCommandLine = "wmic shadowcopy get DeviceObject,ID,ServiceMachine";

	private static string ListShellCommandLine = "vssadmin.exe list shadows";

	public override string ActionName => Name;

	protected override void Run()
	{
		string deleteShadowMode = ResourceData.DeleteShadowMode;
		if (!(deleteShadowMode == "WMI"))
		{
			if (!(deleteShadowMode == "Shell"))
			{
				GeneralUtils.Log("Unknown shadow copy deletion mode: " + ResourceData.DeleteShadowMode);
				return;
			}
			base.Result.Command = DeleteShellCommandLine;
			GetShadowCopyInfoVss();
		}
		else
		{
			base.Result.Command = DeleteWMICommandLine;
			GetShadowCopyInfoWmi();
		}
		try
		{
			ProcessUtils.ExecuteCommandLine(base.Result.Command, out var output, out var _);
			base.Result.ExecuteSuccess = !output.Equals(string.Empty);
		}
		catch (Exception ex)
		{
			GeneralUtils.Log("Exception occured during shadow copy deletion: " + ex.Message);
			base.Result.ExecuteSuccess = false;
		}
	}

	private void GetShadowCopyInfoWmi()
	{
		ProcessUtils.ExecuteCommandLine(ListWMICCommandLine, out var output, out var exitCode);
		if (exitCode != 0 || !Regex.IsMatch(output, "DeviceObject\\s+ID\\s+ServiceMachine") || Regex.Split(output, "\\s*\\n").Length <= 1)
		{
			return;
		}
		foreach (string item in Regex.Split(output, "\\s*\\n").Skip(1))
		{
			string[] array = Regex.Split(item, "\\s+");
			if (array.Length >= 2)
			{
				base.Result.ShadowCopies.Add(new ShadowCopyResult.ShadowCopy
				{
					Volume = array[0].Trim(),
					Id = array[1].Trim(),
					ComputerName = array[2].Trim()
				});
			}
		}
	}

	private void GetShadowCopyInfoVss()
	{
		ProcessUtils.ExecuteCommandLine(ListShellCommandLine, out var output, out var exitCode);
		if (exitCode != 0 || !Regex.IsMatch(output, "Contents of shadow copy set ID"))
		{
			return;
		}
		string[] array = Regex.Split(output, "Contents of shadow copy set ID");
		for (int i = 0; i < array.Length; i++)
		{
			Match match = Regex.Match(array[i], "Shadow Copy ID: (?'ID'.+?\\n).*Shadow Copy Volume: (?'Volume'.+?\\n).*Originating Machine: (?'Machine'.+?\\n)", RegexOptions.Singleline);
			if (match.Success)
			{
				base.Result.ShadowCopies.Add(new ShadowCopyResult.ShadowCopy
				{
					Volume = match.Groups["Volume"].Value.Trim(),
					Id = match.Groups["ID"].Value.Trim(),
					ComputerName = match.Groups["Machine"].Value.Trim()
				});
			}
		}
	}
}
