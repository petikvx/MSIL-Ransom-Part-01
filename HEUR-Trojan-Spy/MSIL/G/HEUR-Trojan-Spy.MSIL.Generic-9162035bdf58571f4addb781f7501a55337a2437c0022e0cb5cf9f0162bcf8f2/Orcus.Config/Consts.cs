using System;
using System.IO;
using System.Windows.Forms;
using Orcus.Plugins;
using Orcus.Shared.Settings;

namespace Orcus.Config;

internal class Consts : IPathInformation
{
	public static string KeyLogFile { get; }

	public static string ExceptionFile { get; }

	public static string PluginsDirectory { get; }

	public static string ApplicationPath { get; }

	public static string FileTransferTempDirectory { get; }

	public static string PotentialCommandsDirectory { get; }

	public static string StaticCommandPluginsDirectory { get; }

	public static string SendToServerPackages { get; }

	public static string LibrariesDirectory { get; }

	string ExceptionFile => ExceptionFile;

	string PluginsDirectory => PluginsDirectory;

	string ApplicationPath => ApplicationPath;

	string FileTransferTempDirectory => FileTransferTempDirectory;

	string PotentialCommandsDirectory => PotentialCommandsDirectory;

	string StaticCommandPluginsDirectory => StaticCommandPluginsDirectory;

	string SendToServerPackages => SendToServerPackages;

	string KeyLogFile => KeyLogFile;

	string LibrariesDirectory => LibrariesDirectory;

	static Consts()
	{
		string mutex = Settings.GetBuilderProperty<MutexBuilderProperty>().get_Mutex();
		string path = Settings.GetBuilderProperty<DataFolderBuilderProperty>().get_Path();
		KeyLogFile = Path.Combine(Environment.ExpandEnvironmentVariables(path), $"klg_{mutex}.dat");
		ExceptionFile = Path.Combine(Environment.ExpandEnvironmentVariables(path), $"err_{mutex}.dat");
		PluginsDirectory = Path.Combine(Environment.ExpandEnvironmentVariables(path), $"plg_{mutex}");
		FileTransferTempDirectory = Path.Combine(Environment.ExpandEnvironmentVariables(path), $"psh_{mutex}");
		PotentialCommandsDirectory = Path.Combine(Environment.ExpandEnvironmentVariables(path), $"ptc_{mutex}");
		StaticCommandPluginsDirectory = Path.Combine(Environment.ExpandEnvironmentVariables(path), $"stp_{mutex}");
		SendToServerPackages = Path.Combine(Environment.ExpandEnvironmentVariables(path), $"sts_{mutex}");
		LibrariesDirectory = Path.Combine(Environment.ExpandEnvironmentVariables(path), $"lib_{mutex}");
		ApplicationPath = Application.get_ExecutablePath();
	}
}
