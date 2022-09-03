using System.ComponentModel;
using System.Windows.Forms.Design;

public sealed class GClass1 : FolderNameEditor
{
	private FolderBrowser folderBrowser_0;

	public GClass1()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		folderBrowser_0 = new FolderBrowser();
	}

	public string method_0(string string_0)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		folderBrowser_0.set_Description(string_0);
		folderBrowser_0.set_StartLocation((FolderBrowserFolder)17);
		folderBrowser_0.set_Style((FolderBrowserStyles)2);
		folderBrowser_0.ShowDialog();
		return folderBrowser_0.get_DirectoryPath();
	}

	~GClass1()
	{
		try
		{
			((Component)(object)folderBrowser_0).Dispose();
		}
		finally
		{
			((object)this).Finalize();
		}
	}
}
