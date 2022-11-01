using System.IO;
using PenterWare.Actions.Results;
using PenterWare.Filesystem.FilesystemTarget;
using PenterWare.Utils;

namespace PenterWare.Actions;

internal class FilesEnumerationAction : BaseAction<FilesEnumerationResult>
{
	public static string Name = "FilesEnumeration";

	public BaseFilesystem Filesystem { get; private set; }

	public override string ActionName => Name;

	protected override void Run()
	{
		Filesystem = FilesystemFactory.GetFilesystem(Policy.InitialTargetPaths, ResourceData.FilesystemBackupType, ResourceData.MaxCopySizeMB);
		RunRegistry.Filesystem = Filesystem;
		base.Result.BaseDirectory = Policy.BaseDirectory;
		base.Result.TargetUsername = Policy.TargetUsername;
		Filesystem.EnumerateFilesystemFiles();
		base.Result.TotalEnumerationSizeMB = Filesystem.CurrentEnumSize;
		foreach (string key in Filesystem.EnumeratedFilePathsToBackups.Keys)
		{
			if (File.Exists(key))
			{
				base.Result.EnumeratedFiles[key] = new FilesEnumerationResult.EnumeratedFileData
				{
					BackupPath = Filesystem.EnumeratedFilePathsToBackups[key],
					SizeMB = FileUtils.GetFileSizeMB(key),
					Done = true,
					SHA256 = CryptoUtils.SHA256File(key)
				};
			}
		}
	}
}
