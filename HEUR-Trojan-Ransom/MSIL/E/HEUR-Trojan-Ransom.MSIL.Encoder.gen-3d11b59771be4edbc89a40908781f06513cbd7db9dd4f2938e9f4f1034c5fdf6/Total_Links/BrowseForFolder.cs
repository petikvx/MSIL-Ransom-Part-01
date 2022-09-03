using System.Windows.Forms.Design;

namespace Total_Links;

public class BrowseForFolder : FolderNameEditor
{
	private FolderBrowser bDialog;

	public BrowseForFolder()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		bDialog = new FolderBrowser();
	}

	public object BrowseDialog(string sTitle)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		FolderBrowser val = bDialog;
		val.set_Style((FolderBrowserStyles)16384);
		val.set_StartLocation((FolderBrowserFolder)0);
		val.set_Description(sTitle);
		val.ShowDialog();
		object directoryPath = val.get_DirectoryPath();
		val = null;
		return directoryPath;
	}
}
