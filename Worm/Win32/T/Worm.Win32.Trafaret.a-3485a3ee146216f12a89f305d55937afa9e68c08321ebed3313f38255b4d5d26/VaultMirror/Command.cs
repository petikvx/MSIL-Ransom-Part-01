using System.IO;
using VaultMirror.Document;

namespace VaultMirror;

public abstract class Command
{
	private static long MAX_FILE_SIZE = 47185920L;

	protected DocumentServiceWse m_docSvc;

	protected string m_username;

	protected string m_password;

	protected string m_server;

	protected string m_vault;

	public IStatusDisplay Display;

	public Command(string username, string password, string server, string vault)
	{
		m_username = username;
		m_password = password;
		m_server = server;
		m_vault = vault;
		Display = null;
	}

	protected void InitServices()
	{
		ServiceManager.GetServiceManager().CreateSecurityService(m_username, m_password, m_server, m_vault);
		m_docSvc = ServiceManager.GetDocumentService();
	}

	protected void DeleteFile(string filePath)
	{
		if (Display != null)
		{
			Display.ChangeStatusMessage("Deleting " + filePath);
		}
		System.IO.File.SetAttributes(filePath, FileAttributes.Normal);
		System.IO.File.Delete(filePath);
	}

	protected void DeleteFolder(string dirPath)
	{
		string[] directories = Directory.GetDirectories(dirPath);
		if (directories != null)
		{
			string[] array = directories;
			foreach (string dirPath2 in array)
			{
				DeleteFolder(dirPath2);
			}
		}
		string[] files = Directory.GetFiles(dirPath);
		if (files != null)
		{
			string[] array2 = files;
			foreach (string filePath in array2)
			{
				DeleteFile(filePath);
			}
		}
		Directory.Delete(dirPath);
	}

	protected void DownloadFile(VaultMirror.Document.File file, string filePath)
	{
		if (Display != null)
		{
			Display.ChangeStatusMessage("Downloading " + file.Name);
		}
		if (System.IO.File.Exists(filePath))
		{
			System.IO.File.SetAttributes(filePath, FileAttributes.Normal);
		}
		if (file.FileSize > MAX_FILE_SIZE)
		{
			DownloadFileLarge(file, filePath);
		}
		else
		{
			DownloadFileStandard(file, filePath);
		}
		System.IO.File.SetAttributes(filePath, FileAttributes.ReadOnly);
	}

	private void DownloadFileStandard(VaultMirror.Document.File file, string filePath)
	{
		using FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite);
		m_docSvc.DownloadFile(file.Id, allowSync: true, out var fileContents);
		fileStream.Write(fileContents, 0, fileContents.Length);
		fileStream.Close();
	}

	private void DownloadFileLarge(VaultMirror.Document.File file, string filePath)
	{
		if (System.IO.File.Exists(filePath))
		{
			System.IO.File.SetAttributes(filePath, FileAttributes.Normal);
		}
		using FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite);
		long num = 0L;
		long num2 = MAX_FILE_SIZE - 1L;
		byte[] array;
		for (; num < file.FileSize; num += array.Length)
		{
			num2 = num + MAX_FILE_SIZE;
			if (num2 > file.FileSize)
			{
				num2 = file.FileSize;
			}
			array = m_docSvc.DownloadFilePart(file.Id, num, num2, allowSync: true);
			fileStream.Write(array, 0, array.Length);
		}
		fileStream.Close();
	}

	public abstract void Execute();
}
