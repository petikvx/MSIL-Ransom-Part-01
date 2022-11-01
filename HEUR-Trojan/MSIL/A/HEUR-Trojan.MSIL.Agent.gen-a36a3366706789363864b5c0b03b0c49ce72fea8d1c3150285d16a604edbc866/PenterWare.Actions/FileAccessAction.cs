using System.IO;
using PenterWare.Actions.Results;
using PenterWare.Utils;

namespace PenterWare.Actions;

internal class FileAccessAction : SubAction<FileAccessResult>
{
	public static string Name = "FileAccess";

	public override string ActionName => Name;

	protected override void Run()
	{
		foreach (string item in Policy.PathsToAccess)
		{
			GeneralUtils.Log("Accessing " + item);
			File.Exists(item);
			base.Result.Filenames.Add(item);
		}
	}
}
