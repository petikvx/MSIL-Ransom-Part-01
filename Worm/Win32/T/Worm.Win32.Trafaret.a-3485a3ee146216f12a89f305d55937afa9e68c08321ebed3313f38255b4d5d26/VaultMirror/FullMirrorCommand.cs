using System.IO;
using VaultMirror.Document;

namespace VaultMirror;

public class FullMirrorCommand : Command
{
	private string m_outputFolder;

	public FullMirrorCommand(string username, string password, string server, string vault, string outputFolder)
		: base(username, password, server, vault)
	{
		m_outputFolder = outputFolder;
	}

	public override void Execute()
	{
		InitServices();
		Folder folderRoot = m_docSvc.GetFolderRoot();
		string localFolder = Path.Combine(m_outputFolder, m_vault);
		FullMirrorVaultFolder(folderRoot, localFolder);
		FullMirrorLocalFolder(folderRoot, localFolder);
	}

	private void FullMirrorVaultFolder(Folder folder, string localFolder)
	{
		if (!Directory.Exists(localFolder))
		{
			Directory.CreateDirectory(localFolder);
		}
		VaultMirror.Document.File[] latestFilesByFolderId = m_docSvc.GetLatestFilesByFolderId(folder.Id, includeHidden: true);
		if (latestFilesByFolderId != null)
		{
			VaultMirror.Document.File[] array = latestFilesByFolderId;
			foreach (VaultMirror.Document.File file in array)
			{
				string text = Path.Combine(localFolder, file.Name);
				if (System.IO.File.Exists(text))
				{
					if (file.Cksum != Checksum.CalcCRC32(text))
					{
						DownloadFile(file, text);
					}
				}
				else
				{
					DownloadFile(file, text);
				}
			}
		}
		Folder[] foldersByParentId = m_docSvc.GetFoldersByParentId(folder.Id, recurse: false);
		if (foldersByParentId != null)
		{
			Folder[] array2 = foldersByParentId;
			foreach (Folder folder2 in array2)
			{
				FullMirrorVaultFolder(folder2, Path.Combine(localFolder, folder2.Name));
			}
		}
	}

	private void FullMirrorLocalFolder(Folder folder, string localFolder)
	{
		string[] files = Directory.GetFiles(localFolder);
		VaultMirror.Document.File[] latestFilesByFolderId = m_docSvc.GetLatestFilesByFolderId(folder.Id, includeHidden: true);
		if (latestFilesByFolderId == null && files != null)
		{
			string[] array = files;
			foreach (string filePath in array)
			{
				DeleteFile(filePath);
			}
		}
		else
		{
			string[] array2 = files;
			foreach (string text in array2)
			{
				bool flag = false;
				string fileName = Path.GetFileName(text);
				VaultMirror.Document.File[] array3 = latestFilesByFolderId;
				foreach (VaultMirror.Document.File file in array3)
				{
					if (file.Name == fileName)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					DeleteFile(text);
				}
			}
		}
		string[] directories = Directory.GetDirectories(localFolder);
		if (directories == null)
		{
			return;
		}
		string[] array4 = directories;
		foreach (string text2 in array4)
		{
			string text3 = folder.FullName + "/" + Path.GetFileName(text2);
			Folder[] array5 = m_docSvc.FindFoldersByPaths(new string[1] { text3 });
			if (array5[0].Id < 0L)
			{
				DeleteFolder(text2);
			}
			else
			{
				FullMirrorLocalFolder(array5[0], text2);
			}
		}
	}
}
