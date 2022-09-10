using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.ServiceProcess;
using System.Threading;
using CommandRegistration.Settings;
using HSPS.Common;
using HSPS.Common.Model;
using HSPS.eServices.DigitalHighway.Brokering;
using HSPS.eServices.DigitalHighway.Commands.Model;
using HSPS.eServices.DigitalHighway.Logging;
using HSPS.eServices.DigitalHighway.Model;
using HSPS.eServices.DigitalHighway.Settings;
using HSPS.eServices.DigitalHighway.Utilities;

namespace CommandRegistration;

public class RegisterAvailableCommands
{
	private string developerLicenseKey = string.Empty;

	private string settingsValue = string.Empty;

	private string settingsKey = string.Empty;

	private bool unInstalling;

	private string targetBrokerAddress = string.Empty;

	private string windowsServiceState = string.Empty;

	private KeyValidationStatus keyValidationStatus;

	private CommandRegistrationSettings commandRegistrationSettings;

	private CommandList commandList;

	public string RegisterCommands(string filePath, string isUninstall)
	{
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Invalid comparison between Unknown and I4
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Invalid comparison between Unknown and I4
		try
		{
			if (isUninstall.ToUpper().Contains("TRUE"))
			{
				unInstalling = true;
			}
			commandRegistrationSettings = new CommandRegistrationSettings(filePath, (StorageType)0);
			commandList = commandRegistrationSettings.CommandType;
			settingsKey = commandRegistrationSettings.SettingsKey;
			settingsValue = commandRegistrationSettings.SettingsValue;
			developerLicenseKey = commandRegistrationSettings.DeveloperLicenseKey;
		}
		catch (Exception ex)
		{
			Logger.Error((object)"Could not load the CommandRegistrationSettings.xml file", ex);
		}
		try
		{
			if (unInstalling)
			{
				RemoveCommandsManually(commandList.get_Commands());
			}
			else
			{
				AddCommandsManually(commandList.get_Commands());
			}
		}
		catch (Exception ex)
		{
			Logger.Error((object)"Unable to register remove or add commands manually, attempting to register via the EFS.", ex);
			Thread.Sleep(10000);
			CommandBroker val = new CommandBroker();
			try
			{
				windowsServiceState = GetCurrentWindowsServiceState();
				if (windowsServiceState == "Stopped")
				{
					StartWindowsService();
				}
				Console.WriteLine("Connecting to EFS Network...");
				Stopwatch stopwatch = Stopwatch.StartNew();
				do
				{
					Thread.Sleep(10000);
					keyValidationStatus = val.ConnectToDigitalHighway((CommandBrokerConfiguration)null, DigitalHighwayConstants.DIGITAL_HIGHWAY_DEVELOPER_LICENSE_KEY);
				}
				while (stopwatch.ElapsedMilliseconds <= 60000L && (int)keyValidationStatus == 2);
				if ((int)keyValidationStatus == 0)
				{
					string address = val.get_Address();
					string id = val.get_Id();
					targetBrokerAddress = address.Replace("." + id, "");
					if (!ValidateLicenseKey(developerLicenseKey, val))
					{
						Console.WriteLine("Disconnecting to EFS Network...");
						val.DisconnectFromDigitalHighway();
						return "Invalid License Key";
					}
					foreach (CommandListEntry command in commandList.get_Commands())
					{
						if (unInstalling)
						{
							Console.WriteLine("Removing entry for Command: " + command.get_Command());
							RemoveAvailableCommands(val, command.get_Command(), targetBrokerAddress);
						}
						else
						{
							Console.WriteLine("Adding entry for command: " + command.get_Command());
							AddAvailableCommands(val, command.get_Command(), targetBrokerAddress);
						}
					}
					if (!string.IsNullOrEmpty(settingsKey) && !string.IsNullOrEmpty(settingsValue))
					{
						Console.WriteLine("Updating Meta-Data: " + settingsKey + "/" + settingsValue);
						AddUpdateMetaData(val, targetBrokerAddress, settingsKey, settingsValue);
					}
				}
			}
			catch (Exception ex2)
			{
				Logger.Error((object)"Could not register the Commands into the AvailableCommands.xml", ex2);
			}
			finally
			{
				ReturnWindowsServiceToOriginalState(windowsServiceState);
				Console.WriteLine("Disconnecting to EFS Network...");
				val.DisconnectFromDigitalHighway();
			}
		}
		return "Commands Registered";
	}

	private void RemoveCommandsManually(List<CommandListEntry> list)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		string serviceName = "Digital Highway Server";
		string servicePath = GetServicePath(serviceName);
		string text = Path.Combine(servicePath, "AvailableCommands.xml");
		CommandSettings val = new CommandSettings(text, (StorageType)0);
		CommandList commands = val.get_Commands();
		foreach (CommandListEntry item in list)
		{
			commands.DeleteCommand(item.get_Command());
		}
		val.set_Commands(commands);
	}

	private void AddCommandsManually(List<CommandListEntry> list)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		string serviceName = "Digital Highway Server";
		string servicePath = GetServicePath(serviceName);
		string text = Path.Combine(servicePath, "AvailableCommands.xml");
		CommandSettings val = new CommandSettings(text, (StorageType)0);
		CommandList commands = val.get_Commands();
		foreach (CommandListEntry item in list)
		{
			commands.AddCommand(item.get_Command());
		}
		val.set_Commands(commands);
	}

	private string GetServicePath(string serviceName)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		string result = string.Empty;
		ManagementObjectSearcher val = new ManagementObjectSearcher("SELECT PathName from Win32_Service where DisplayName =\"" + serviceName + "\"");
		try
		{
			ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					result = Path.GetDirectoryName(((ManagementBaseObject)val2).get_Item("PathName").ToString()!.Replace("\"", ""));
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		return result;
	}

	private void ReturnWindowsServiceToOriginalState(string windowsServiceState)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		new ServiceController("Digital Highway Server");
		if (windowsServiceState == "Stopped")
		{
			StartWindowsService();
		}
	}

	private string GetCurrentWindowsServiceState()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		string empty = string.Empty;
		ServiceController val = new ServiceController("Digital Highway Server");
		if ((int)val.get_Status() == 4)
		{
			return "Running";
		}
		return "Stopped";
	}

	private bool ValidateLicenseKey(string developerLicenseKey, CommandBroker broker)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		Console.WriteLine("Validating Developer License Key...");
		bool flag = false;
		CommandRequest val = new CommandRequest();
		val.set_Type("HSPS.eServices.DigitalHighway.DeveloperLicenses.AuthenticateLicense, HSPS.eServices.DigitalHighway.DeveloperLicenses, Version=1.0.0.0, Culture=neutral, PublicKeyToken=c99984fdbc439680");
		val.set_Parameters(developerLicenseKey);
		string text = broker.ExecuteCommand(Serialization.XmlSerialize<CommandRequest>(val));
		CommandResponse val2 = Serialization.XmlDeserialize<CommandResponse>(text);
		if (val2.get_Result() == "VALID")
		{
			Console.WriteLine("Developer License Key: Valid");
			return true;
		}
		Console.WriteLine("Developer License Key: Invalid");
		return false;
	}

	private void RemoveAvailableCommands(CommandBroker broker, string command, string targetBrokerAddress)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Invalid comparison between Unknown and I4
		try
		{
			CommandProperties val = new CommandProperties();
			string[] array = command.Split(new char[1] { ',' });
			string text = array[4];
			string text2 = array[2];
			string text3 = text2.Replace("Version=", "");
			string text4 = text.Replace("PublicKeyToken=", "");
			val.set_PublicKeyToken(text4.Trim());
			val.set_AssemblyVersion(text3.Trim());
			val.set_ClassName(array[0].Trim());
			val.set_Assembly(array[1].Trim());
			CommandRequest val2 = new CommandRequest();
			val2.set_Type("HSPS.eServices.DigitalHighway.Commands.RemoveAvailableCommand, HSPS.eServices.DigitalHighway, Version=1.0.0.0, Culture=neutral, PublicKeyToken=c99984fdbc439680");
			val2.set_Parameters(Serialization.XmlSerialize<CommandProperties>(val));
			val2.set_TargetBrokerAddress(targetBrokerAddress);
			string text5 = broker.ExecuteCommand(Serialization.XmlSerialize<CommandRequest>(val2));
			CommandResponse val3 = Serialization.XmlDeserialize<CommandResponse>(text5);
			if ((int)val3.get_Status() == 0)
			{
				Logger.Info((object)"Successfully removed the command.");
			}
			else
			{
				Logger.Error((object)("Could not successfully remove the command. " + val3.get_Result()));
			}
			if (!WaitForHeartBeat(broker, targetBrokerAddress))
			{
				Thread.Sleep(3000);
			}
		}
		catch (Exception ex)
		{
			Logger.Error((object)("Error removing the Command " + command + " Re-trying"), ex);
		}
	}

	private void AddAvailableCommands(CommandBroker broker, string command, string targetBrokerAddress)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Invalid comparison between Unknown and I4
		try
		{
			CommandRequest val = new CommandRequest();
			val.set_Type("HSPS.eServices.DigitalHighway.Commands.AddAvailableCommand, HSPS.eServices.DigitalHighway, Version=1.0.0.0, Culture=neutral, PublicKeyToken=c99984fdbc439680");
			val.set_Parameters(command);
			val.set_TargetBrokerAddress(targetBrokerAddress);
			string text = broker.ExecuteCommand(Serialization.XmlSerialize<CommandRequest>(val));
			CommandResponse val2 = Serialization.XmlDeserialize<CommandResponse>(text);
			if ((int)val2.get_Status() == 0)
			{
				Logger.Info((object)"Successfully registered the command.");
			}
			else
			{
				Logger.Error((object)("Could not Register the command. " + val2.get_Result()));
			}
			if (!WaitForHeartBeat(broker, targetBrokerAddress))
			{
				Thread.Sleep(3000);
			}
		}
		catch (Exception ex)
		{
			Logger.Error((object)("Error Registering the Command" + command + "Re-trying"), ex);
		}
	}

	private bool WaitForHeartBeat(CommandBroker broker, string targetBrokerAddress)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Invalid comparison between Unknown and I4
		bool result = false;
		CommandRequest val = new CommandRequest();
		val.set_Type("HSPS.eServices.DigitalHighway.Commands.HeartBeat, HSPS.eServices.DigitalHighway, Version=1.0.0.0, Culture=neutral, PublicKeyToken=c99984fdbc439680");
		val.set_TargetBrokerAddress(targetBrokerAddress);
		string text = broker.ExecuteCommand(Serialization.XmlSerialize<CommandRequest>(val));
		CommandResponse val2 = Serialization.XmlDeserialize<CommandResponse>(text);
		if ((int)val2.get_Status() == 0)
		{
			result = true;
		}
		return result;
	}

	private void AddUpdateMetaData(CommandBroker broker, string targetBrokerAddress, string settingsKey, string settingsValue)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Invalid comparison between Unknown and I4
		try
		{
			CommandRequest val = new CommandRequest();
			val.set_Type("HSPS.eServices.DigitalHighway.RootNode.AddUpdateNodeMetaData, HSPS.eServices.DigitalHighway.RootNode, Version=1.0.0.0, Culture=neutral, PublicKeyToken=c99984fdbc439680");
			DHNSNodeLookupData val2 = new DHNSNodeLookupData();
			val2.set_BrokerAddress(targetBrokerAddress);
			val2.set_Key(settingsKey);
			val2.set_Value(settingsValue);
			val.set_Parameters(Serialization.XmlSerialize<DHNSNodeLookupData>(val2));
			string text = broker.ExecuteCommand(Serialization.XmlSerialize<CommandRequest>(val));
			CommandResponse val3 = Serialization.XmlDeserialize<CommandResponse>(text);
			if ((int)val3.get_Status() == 0)
			{
				Logger.Info((object)"Successfully Registered the module");
			}
			else
			{
				Logger.Error((object)("Could not register the module: " + val3.get_Result()));
			}
		}
		catch (Exception ex)
		{
			Logger.Error((object)"Could not connect to DHNS database.", ex);
		}
	}

	private static void StartWindowsService()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		ServiceController val = new ServiceController("Digital Highway Server");
		val.Start();
		val.WaitForStatus((ServiceControllerStatus)4);
	}
}
