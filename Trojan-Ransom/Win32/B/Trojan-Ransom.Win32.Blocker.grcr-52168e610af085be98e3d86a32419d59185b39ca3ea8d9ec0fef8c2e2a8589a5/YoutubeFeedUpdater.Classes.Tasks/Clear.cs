using System;
using System.IO;
using System.Windows.Forms;

namespace YoutubeFeedUpdater.Classes.Tasks;

public class Clear : ITask
{
	private WebBrowser webBrowser_0;

	public Clear(WebBrowser webBrowser)
	{
		webBrowser_0 = webBrowser;
	}

	public void Run(TaskSystem taskSystem)
	{
		taskSystem.LogCallBack("Clearing Cache");
		method_0(new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.InternetCache)));
		webBrowser_0.Navigate("");
	}

	private void method_0(DirectoryInfo directoryInfo_0)
	{
		FileInfo[] files = directoryInfo_0.GetFiles();
		foreach (FileInfo fileInfo in files)
		{
			try
			{
				if (!fileInfo.IsReadOnly)
				{
					fileInfo.Delete();
				}
			}
			catch
			{
			}
		}
		DirectoryInfo[] directories = directoryInfo_0.GetDirectories();
		foreach (DirectoryInfo directoryInfo_ in directories)
		{
			method_0(directoryInfo_);
		}
	}
}
