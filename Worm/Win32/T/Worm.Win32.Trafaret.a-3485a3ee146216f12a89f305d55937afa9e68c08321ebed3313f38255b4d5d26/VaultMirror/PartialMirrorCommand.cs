using System;
using System.IO;
using VaultMirror.Document;

namespace VaultMirror;

public class PartialMirrorCommand : Command
{
	private DateTime m_lastSyncTime;

	private string m_outputFolder;

	public PartialMirrorCommand(string username, string password, string server, string vault, string outputFolder, DateTime lastSyncTime)
		: base(username, password, server, vault)
	{
		m_lastSyncTime = lastSyncTime;
		m_outputFolder = outputFolder;
	}

	public override void Execute()
	{
		InitServices();
		SrchCond srchCond = new SrchCond();
		srchCond.SrchTxt = m_lastSyncTime.ToUniversalTime().ToString("MM/dd/yyyy HH:mm:ss");
		srchCond.SrchOper = 7L;
		srchCond.PropDefId = -31L;
		srchCond.PropTyp = PropertySearchType.SingleProperty;
		srchCond.ValTyp = "datetime";
		FileFolder[] array = m_docSvc.FindFileFoldersBySearchConditions(null, recurseFolders: true, new SrchCond[1] { srchCond }, latestOnly: true, includeCheckedOutVersions: false);
		string path = Path.Combine(m_outputFolder, m_vault);
		if (array == null)
		{
			return;
		}
		FileFolder[] array2 = array;
		foreach (FileFolder fileFolder in array2)
		{
			string fullName = fileFolder.Folder.FullName;
			fullName = ((!(fullName == "$")) ? fullName.Substring(2) : "");
			string text = Path.Combine(path, fullName);
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			DownloadFile(fileFolder.File, Path.Combine(text, fileFolder.File.Name));
		}
	}
}
