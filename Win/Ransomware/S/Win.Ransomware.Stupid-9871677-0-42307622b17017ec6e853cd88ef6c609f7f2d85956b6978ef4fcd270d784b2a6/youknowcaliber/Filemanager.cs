namespace youknowcaliber;

internal sealed class Filemanager
{
	public static extern void RecursiveDelete(string path);

	public static extern void CopyDirectory(string sourceFolder, string destFolder);

	public static extern long DirectorySize(string path);

	public extern Filemanager();
}
