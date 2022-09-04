using System.IO;
using System.Reflection;
using CryptoSrv.Shared.Managers;

namespace CryptoSrvc.Starter;

public class StarterManager
{
	private readonly string _embeddedFileName;

	private readonly string _embeddedNamespace;

	private readonly string _workerDir;

	private readonly Assembly _workerAsm;

	public StarterManager(string workerDir, string embeddedFileName, string embeddedNamespace, Assembly workerAsm)
	{
		_workerDir = workerDir;
		_embeddedFileName = embeddedFileName;
		_embeddedNamespace = embeddedNamespace;
		_workerAsm = workerAsm;
	}

	public bool Run(out string outMessage)
	{
		EmbeddedManager embeddedManager = new EmbeddedManager(_workerAsm, _workerDir, _embeddedFileName, _embeddedNamespace, AppManager.Worker.UsedProcessNames);
		if (!CreateWorkerDirectory())
		{
			outMessage = $"Can't create base folder '{_workerDir}'";
			return false;
		}
		ExtactEmbeddedStatus extactEmbeddedStatus = embeddedManager.Install(out outMessage, clearRootFiles: true);
		return extactEmbeddedStatus == ExtactEmbeddedStatus.UpToDate || extactEmbeddedStatus == ExtactEmbeddedStatus.Success;
	}

	public bool CreateWorkerDirectory()
	{
		try
		{
			if (!Directory.Exists(_workerDir))
			{
				Directory.CreateDirectory(_workerDir);
			}
			return true;
		}
		catch
		{
			return false;
		}
	}
}
