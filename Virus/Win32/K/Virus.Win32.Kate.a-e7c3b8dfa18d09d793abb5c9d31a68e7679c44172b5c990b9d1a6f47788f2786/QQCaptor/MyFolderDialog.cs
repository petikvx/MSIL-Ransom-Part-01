using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace QQCaptor;

public class MyFolderDialog : FolderNameEditor
{
	private FolderBrowser fDialog = new FolderBrowser();

	public string Path => fDialog.get_DirectoryPath();

	public MyFolderDialog()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		fDialog.set_Style((FolderBrowserStyles)16400);
		fDialog.set_StartLocation((FolderBrowserFolder)17);
	}

	public DialogResult DisplayDialog()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		return DisplayDialog("请选择一个文件夹");
	}

	public DialogResult DisplayDialog(string description)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		fDialog.set_Description(description);
		return fDialog.ShowDialog();
	}

	~MyFolderDialog()
	{
		try
		{
			((Component)(object)fDialog).Dispose();
		}
		finally
		{
			((object)this).Finalize();
		}
	}
}
